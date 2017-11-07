Imports MaterialSkin
Imports System.Net

Public Class Login

    Public sql As New SQLControl
    Public email As New Emailing

    Dim score As Integer = 0

    Public doneKindsList As New List(Of Integer)

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim _skinManager As MaterialSkinManager = MaterialSkinManager.Instance
        _skinManager.AddFormToManage(Me)
        _skinManager.Theme = MaterialSkinManager.Themes.LIGHT
        _skinManager.ColorScheme = New ColorScheme(Primary.Blue600, Primary.Blue700, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)

        MaximizeBox = False
        MinimizeBox = False

        ' Get IP .. lagay natin to kung mas okay as security ..
        'Dim myClientMachineAddressList As IPHostEntry = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName())
        'Dim myClientMachineIP As String = myClientMachineAddressList.AddressList(0).ToString()

        ' Reads the config.ini to get the SQL Connection
        Dim connectionIni As New IniFile
        With connectionIni
            .Filename = My.Application.Info.DirectoryPath & "\config.ini"
            Dim db_Server As String
            Dim db_Name As String
            Dim db_Username As String
            Dim db_Password As String

            If .OpenIniFile() Then
                db_Server = .GetValue("1")
                db_Name = .GetValue("2")
                db_Username = .GetValue("3")
                db_Password = .GetValue("4")
                SQLControl.sqlConn.ConnectionString = "server=" & db_Server & "; userid=" & db_Username & "; password= " & db_Password & "; database=" & db_Name & "; allowuservariables=true"
            Else
                SQLControl.TestConnection()
            End If
        End With



    End Sub

    Private Function HashPass(stringPassword) As String
        Dim _salt1 = "Egg"
        Dim _salt2 = "Bacon"
        Dim _bytes() As Byte = System.Text.Encoding.UTF8.GetBytes(stringPassword)
        Dim _hashOfBytes() As Byte = New System.Security.Cryptography.SHA1Managed().ComputeHash(_bytes)
        Dim _stringHash As String = _salt1 & Convert.ToBase64String(_hashOfBytes) & _salt2
        Return _stringHash
    End Function

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' CHECKS IF NULL
        If txtExamineeDateID.Text = "" Or txtLastName.Text = "" Then
            MessageBox.Show("Details are incorrect")
        End If

        ' SELECTING FROM tbl_admin
        Dim _adminUsername As String = txtExamineeDateID.Text
        Dim _adminPassword As String = HashPass(txtLastName.Text)

        sql.AddParam("@adminUsername", _adminUsername)
        sql.AddParam("@adminPassword", _adminPassword)
        sql.ExecuteQuery("SELECT * FROM tbl_admin 
                                  WHERE adminUsername = @adminUsername 
                                    AND adminPassword = @adminPassword")

        ' Checks if there is an admin
        If sql.recordCount > 0 Then
            email.InitializeEmailSettings()
            AdminDashboard.Show()
            Me.Close()
            Exit Sub
        Else

            ' If there is TEMPORARY ADMIN
            sql.AddParam("@adminUsername", _adminUsername)
            sql.AddParam("@adminPassword", txtLastName.Text)

            sql.ExecuteQuery("SELECT * FROM tbl_admin 
                                      WHERE adminUsername = @adminUsername 
                                        AND adminPassword = @adminPassword
                                        AND adminLevel = 1")

            If sql.recordCount > 0 Then
                AdminTempDashboard.Show()
                Me.Close()
                Exit Sub
            End If


            ' EXAMINEE CASE
            Dim _examineeDateID As String = txtExamineeDateID.Text
            Dim _examineeLastName As String = txtLastName.Text

            sql.AddParam("@examineeDateID", _examineeDateID)
            sql.AddParam("@examineeLastName", _examineeLastName)
            sql.ExecuteQuery("SELECT * FROM tbl_examinee 
                                      WHERE examineeDateID = @examineeDateID
                                        AND lastName = @examineeLastName")

            ' Checks if Examinee exists
            If sql.recordCount > 0 Then

                email.InitializeEmailSettings()
                ' Get both examinee ID and Active Level
                Dim _examineeID As String = sql.sqlDataSet.Tables(0).Rows(0).Item("examineeID").ToString
                Dim _activeLevel As String = sql.sqlDataSet.Tables(0).Rows(0).Item("activeLevel").ToString


                sql.AddParam("@examineeID", _examineeID)
                sql.AddParam("@levelID", _activeLevel) ' Use activeLvel on tbl_examinee_set because AN EXAMINEE CAN ONLY HAVE ONE LEVEL 
                sql.ExecuteQuery("SELECT * FROM tbl_examinee
                              INNER JOIN tbl_examinee_set
                                      ON tbl_examinee.examineeID = tbl_examinee_set.examineeID
                                   WHERE tbl_examinee_set.levelID = @levelID
                                     AND tbl_examinee.examineeID = @examineeID")


                If sql.recordCount > 0 Then ' If statement to know if there is tbl_examinee_set instance

                    Dim _result As String = sql.sqlDataSet.Tables(0).Rows(0).Item("result").ToString

                    ' Case A and B
                    If sql.recordCount = 1 Then ' If statement to know if there is RESULT in tbl_examinee_set

                        If _result = "" Then
                            ' No test taken yet
                            Examinee.lblSetDescription.Text = "A"
                            DoExamination(_activeLevel)
                        ElseIf _result = "Failed" Then
                            ' Examinee has taken test A but failed
                            Examinee.lblSetDescription.Text = "B"
                            DoExamination(_activeLevel)
                        ElseIf _result = "Passed" Then
                            MessageBox.Show("You have passed")
                            Exit Sub
                        End If

                    ElseIf sql.recordCount = 2 Then ' Case B

                        ' You know there are two rows. You get the recent row. 
                        _result = sql.sqlDataSet.Tables(0).Rows(1).Item("result").ToString

                        If _result = "Failed" Then
                            Examinee.lblSetDescription.Text = "C"
                            DoExamination(_activeLevel)
                        ElseIf _result = "Passed" Then
                            MessageBox.Show("You have passed")
                            Exit Sub
                        End If

                    ElseIf sql.recordCount = 3 Then
                        MessageBox.Show("You have done all 3 tests for the specified level")
                        Exit Sub
                    End If ' End of if statement for tbl_examinee_set 

                End If ' End of if statement to know if there is a tbl_examinee_set instance

            Else
                ' NO SUCH EXAMINEE
                MessageBox.Show("Login unsuccessful")
                Exit Sub
            End If ' End of if statement to know if examinee exists
        End If
    End Sub

    ' Proceed to Examination
    Private Sub DoExamination(_activeLevel As String)

        Dim _allTestsDone As Boolean

        Examinee.lblExamineeDateID.Text = txtExamineeDateID.Text

        ' Getting results for Examinee
        sql.AddParam("@examineeDateID", txtExamineeDateID.Text)
        sql.AddParam("@levelID", _activeLevel)
        sql.ExecuteQuery("SELECT * FROM tbl_examinee
                      INNER JOIN tbl_examinee_set
                              ON tbl_examinee_set.examineeID = tbl_examinee.examineeID
                      INNER JOIN tbl_level
                              ON tbl_examinee_set.levelID = tbl_level.levelID
                      INNER JOIN tbl_position
                              ON tbl_examinee_set.positionID = tbl_position.positionID
                           WHERE tbl_examinee.examineeDateID = @examineeDateID
                             AND tbl_examinee_set.levelID = @levelID")





        ' Passing Examinee Credentials to Examinee form
        For Each r As DataRow In sql.sqlDataSet.Tables(0).Rows
            Examinee.lblExamineeID.Text = r("examineeID")
            Examinee.lblExamineeDateID.Text = r("examineeDateID")
            Examinee.lblFirstName.Text = r("firstName")
            Examinee.lblLastName.Text = r("lastName")
            Examinee.lblLevelDescription.Text = r("levelDescription")
            Examinee.lblPositionDescription.Text = r("positionDescription")
        Next



        ' Get test types and pass it to Examinee form
        sql.AddParam("@levelID", _activeLevel)
        sql.ExecuteQuery("SELECT * FROM tbl_kind
                                     INNER JOIN tbl_test_type
                                             ON tbl_kind.testTypeID = tbl_test_type.testTypeID
                                           WHERE tbl_kind.levelID = @levelID")


        Examinee.lblTest1.Text = sql.sqlDataSet.Tables(0).Rows(0).Item("testTypeDescription")
        Examinee.lblTime1.Text = sql.sqlDataSet.Tables(0).Rows(0).Item("timer")
        Examinee.lblTestID1.Text = sql.sqlDataSet.Tables(0).Rows(0).Item("testTypeID")

        Examinee.lblTest2.Text = sql.sqlDataSet.Tables(0).Rows(1).Item("testTypeDescription")
        Examinee.lblTime2.Text = sql.sqlDataSet.Tables(0).Rows(1).Item("timer")
        Examinee.lblTestID2.Text = sql.sqlDataSet.Tables(0).Rows(1).Item("testTypeID")

        Examinee.lblTest3.Text = sql.sqlDataSet.Tables(0).Rows(2).Item("testTypeDescription")
        Examinee.lblTime3.Text = sql.sqlDataSet.Tables(0).Rows(2).Item("timer")
        Examinee.lblTestID3.Text = sql.sqlDataSet.Tables(0).Rows(2).Item("testTypeID")


        ' IF CLERICAL THEN SEND Test type 4 and 5 GOOD
        If _activeLevel = 3 Then

            Examinee.lblTest4.Text = sql.sqlDataSet.Tables(0).Rows(3).Item("testTypeDescription")
            Examinee.lblTime4.Text = sql.sqlDataSet.Tables(0).Rows(3).Item("timer")
            Examinee.lblTestID4.Text = sql.sqlDataSet.Tables(0).Rows(3).Item("testTypeID")

            Examinee.lblTest5.Text = sql.sqlDataSet.Tables(0).Rows(4).Item("testTypeDescription")
            Examinee.lblTime5.Text = sql.sqlDataSet.Tables(0).Rows(4).Item("timer")
            Examinee.lblTestID5.Text = sql.sqlDataSet.Tables(0).Rows(4).Item("testTypeID")
        End If


        Examinee.lblLevelID.Text = _activeLevel

        If HasAlreadyAnswered(Examinee.lblExamineeID.Text, _activeLevel, Examinee.lblSetDescription.Text) Then


            Dim _questionCount As Integer
            Dim _answeredCount As Integer

            ' Check if the KindIDs are already done for Examinee's set
            For Each kindID As Integer In doneKindsList
                ' Get Question_Count of kindID and Level
                sql.AddParam("@kindID", kindID)
                sql.AddParam("@activeLevel", _activeLevel)
                sql.AddParam("@setDescription", Examinee.lblSetDescription.Text)
                sql.ExecuteQuery("SELECT COUNT(*) AS Question_Count 
                                                FROM tbl_question 
                                          INNER JOIN tbl_kind
                                                  ON tbl_kind.kindID = tbl_question.kindID
                                               WHERE tbl_kind.levelID = @activeLevel
                                                 AND tbl_question.kindID = @kindID
                                                 AND tbl_question.setDescription = @setDescription")

                _questionCount = sql.sqlDataSet.Tables(0).Rows(0).Item("Question_Count")


                ' Retrieves how many Examinee has answered for KindID
                sql.AddParam("@examineeID", Examinee.lblExamineeID.Text)
                sql.AddParam("@kindID", kindID)
                sql.AddParam("@activeLevel", _activeLevel)
                sql.ExecuteQuery("SELECT COUNT(*) As Examinee_Question_Count 
                                                     FROM tbl_kind
                                                     JOIN tbl_question 
                                                       ON tbl_question.kindID = tbl_kind.kindID
                                                     JOIN tbl_response 
                                                       ON tbl_response.questionID = tbl_question.questionID
                                                    WHERE tbl_response.examineeID = @examineeID 
                                                      AND tbl_question.kindID = @kindID")

                _answeredCount = sql.sqlDataSet.Tables(0).Rows(0).Item("Examinee_Question_Count")

                ' If Question_Count == Examinee.Answered_Question_Count .. Then Compute Scores + Insert Scores + increment Test Done + Hide Button
                If _questionCount = _answeredCount Then
                    ComputeScore(Examinee.lblExamineeID.Text, kindID, Examinee.lblSetDescription.Text)
                    InsertScore(Examinee.lblExamineeID.Text, kindID, Examinee.lblSetDescription.Text)



                    ' Hide Button by kindID
                    '   '   Level = { 1, 2 }
                    '    ' Button 1 { 1, 4 }
                    '    ' Button 2 { 2, 5 }
                    '    ' Button 3 { 3, 6 }

                    '   '   Level = { 3 }
                    '    ' Button 1 { 7 }
                    '    ' Button 2 { 8 }
                    '    ' Button 3 { 9 }
                    '    ' Button 4 { 10 }
                    '    ' Button 5 { 11 }
                    If _activeLevel <> 3 Then
                        If kindID = 1 Or kindID = 4 Then
                            Examinee.btnTestStart1.Visible = False
                            Examinee.lblTestsDone.Text = Examinee.lblTestsDone.Text + 1
                        End If

                        If kindID = 2 Or kindID = 5 Then
                            Examinee.btnTestStart2.Visible = False
                            Examinee.lblTestsDone.Text = Examinee.lblTestsDone.Text + 1
                        End If

                        If kindID = 3 Or kindID = 6 Then
                            Examinee.btnTestStart3.Visible = False
                            Examinee.lblTestsDone.Text = Examinee.lblTestsDone.Text + 1
                        End If

                    Else
                        If kindID = 7 Then
                            Examinee.btnTestStart1.Visible = False
                            Examinee.lblTestsDone.Text = Examinee.lblTestsDone.Text + 1
                        End If

                        If kindID = 8 Then
                            Examinee.btnTestStart2.Visible = False
                            Examinee.lblTestsDone.Text = Examinee.lblTestsDone.Text + 1
                        End If

                        If kindID = 9 Then
                            Examinee.btnTestStart3.Visible = False
                            Examinee.lblTestsDone.Text = Examinee.lblTestsDone.Text + 1
                        End If

                        If kindID = 10 Then
                            Examinee.btnTestStart4.Visible = False
                            Examinee.lblTestsDone.Text = Examinee.lblTestsDone.Text + 1
                        End If

                        If kindID = 11 Then
                            Examinee.btnTestStart5.Visible = False
                            Examinee.lblTestsDone.Text = Examinee.lblTestsDone.Text + 1
                        End If

                    End If

                    _allTestsDone = TestTypeFinished(_activeLevel)

                End If
            Next



        End If

        If _allTestsDone = False Then
            Examinee.Show()
            Me.Close()
        End If


    End Sub

    Private Function TestTypeFinished(_activeLevel As String) As Boolean

        ' If tapos na yung exam
        If (Examinee.lblLevelID.Text = "3" And Examinee.lblTestsDone.Text = "5") Or (Examinee.lblLevelID.Text <> 3 And Examinee.lblTestsDone.Text = "3") Then
            ' Insertion of pass or Fail
            Examinee.InsertPassOrFail()


            ' Dito ilalagay na IF NULL EMAIL FIELD, PROMPT USER IF THEY WANT EMAIL

            sql.AddParam("@examineeID", Examinee.lblExamineeID.Text)
            sql.ExecuteQuery("SELECT emailAddress FROM tbl_examinee WHERE examineeID = @examineeID")

            ' If examinee exists 
            If sql.recordCount > 0 Then
                Dim _examineeEmail As String

                If IsDBNull(sql.sqlDataSet.Tables(0).Rows(0).Item("emailAddress")) Or sql.sqlDataSet.Tables(0).Rows(0).Item("emailAddress").ToString() = "" Then
                    ' emailAddress NULL or empty

                    ' Prompt for email
                    _examineeEmail = InputBox("Enter your Email Address: ", "", "")
                Else
                    _examineeEmail = sql.sqlDataSet.Tables(0).Rows(0).Item("emailAddress").ToString()
                End If

                ' sendMAIL NAO ~!
                email.SendExamineeEmail(Examinee.lblExamineeID.Text, Examinee.lblSetDescription.Text, Examinee.lblLevelID.Text, Examinee.lblPositionDescription.Text, _examineeEmail)

            End If

            Me.txtExamineeDateID.Text = ""
            Me.txtLastName.Text = ""

            MessageBox.Show("Thank you for taking the Pre-qualification exam." & vbNewLine & "Please consult the administrator for further instructions")
            Return True
        Else
            Return False
        End If
    End Function

    Public Function HasAlreadyAnswered(examineeID As String, activeLevel As String, setDescription As String) As Boolean

        ' See if Examinee has already answered in such a level
        sql.AddParam("@examineeID", examineeID)
        sql.AddParam("@activeLevel", activeLevel)
        sql.AddParam("@setDescription", setDescription)
        sql.ExecuteQuery("SELECT tbl_question.kindID FROM tbl_kind
                                                     JOIN tbl_question 
                                                       ON tbl_question.kindID = tbl_kind.kindID
                                                     JOIN tbl_response 
                                                       ON tbl_response.questionID = tbl_question.questionID
                                                    WHERE tbl_response.examineeID = @examineeID
                                                      AND tbl_kind.levelID = @activeLevel
                                                      AND tbl_question.setDescription = @setDescription
                                                    GROUP BY tbl_question.kindID")
        If sql.recordCount > 0 Then

            ' Give to global list int variable the queried kindIDs
            For Each r As DataRow In sql.sqlDataSet.Tables(0).Rows
                doneKindsList.Add(Convert.ToInt32(r("kindID").ToString()))
            Next

            Return True
        Else
            Return False
        End If

    End Function

    Public Sub ComputeScore(examineeID As String, kindID As String, setDescription As String)
        sql.AddParam("@examineeID", examineeID)
        sql.AddParam("@kindID", kindID)
        sql.AddParam("@setDescription", setDescription)

        ' Compare tbl_response answer with tbl_question correct answer
        sql.ExecuteQuery("SELECT * FROM tbl_response INNER JOIN tbl_question ON tbl_response.questionID = tbl_question.questionID 
                          WHERE tbl_question.kindID = @kindID AND tbl_question.setDescription = @setDescription AND tbl_response.examineeID = @examineeID")

        For Each r As DataRow In sql.sqlDataSet.Tables(0).Rows
            If r("examineeAnswer").ToString = r("correctAnswer").ToString Then
                score = score + 1
            End If
        Next
    End Sub

    Public Sub InsertScore(examineeID As String, kindID As String, setDescription As String)
        ' Checks if there is a record
        sql.AddParam("@examineeID", examineeID)
        sql.AddParam("@kindID", kindID)
        sql.AddParam("@setDescription", setDescription)
        sql.ExecuteQuery("SELECT * FROM tbl_examinee_score WHERE examineeID = @examineeID AND kindID = @kindID AND setDescription = @setDescription")

        sql.AddParam("@examineeID", examineeID)
        sql.AddParam("@kindID", kindID)
        sql.AddParam("@setDescription", setDescription)
        sql.AddParam("@examineeScore", score)
        If sql.recordCount > 0 Then

            ' UPDATE CURRENT Examinee_Score
            sql.ExecuteQuery("UPDATE tbl_examinee_score
                             SET examineeScore = @examineeScore
                           WHERE examineeID = @examineeID
                             AND kindID = @kindID
                             AND setDescription = @setDescription")

        Else
            ' INSERT INTO Examinee_Score
            sql.ExecuteQuery("INSERT INTO tbl_examinee_score (examineeID, kindID, examineeScore, setDescription) 
                                            VALUES (@examineeID, @kindID, @examineeScore, @setDescription)")

        End If


    End Sub

    Private Sub txtExamineeDateID_Click(sender As Object, e As EventArgs) Handles txtExamineeDateID.TextChanged
        If txtExamineeDateID.Text = "admin" Then
            txtLastName.PasswordChar = "*"
        Else
            txtLastName.PasswordChar = ""
        End If
    End Sub

    ' Tab-indexing for MaterialSkin Single Line Text Field
    Private Sub txtExamineeDateID_KeyPressed(sender As Object, e As PreviewKeyDownEventArgs) Handles txtExamineeDateID.PreviewKeyDown
        ' If Tab-key pressed
        If Convert.ToInt32(e.KeyCode) = 9 Then
            txtLastName.Select()
            txtLastName.Select()
        End If

        ' If Enter-key pressed
        If Convert.ToInt32(e.KeyCode) = 13 Then
            btnLogin_Click(sender, e)
        End If
    End Sub

    Private Sub txtLastName_Click(sender As Object, e As PreviewKeyDownEventArgs) Handles txtLastName.PreviewKeyDown
        ' If Enter-key pressed


        If Convert.ToInt32(e.KeyCode) = 13 Then
            btnLogin_Click(sender, e)
        Else
            Exit Sub
        End If
    End Sub



End Class
