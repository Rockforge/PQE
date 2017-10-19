Imports MaterialSkin
Imports System.Net

Public Class Login

    Public sql As New SQLControl
    Public email As New Emailing

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
                            DoExamination(_activeLevel)
                            Examinee.lblSetDescription.Text = "A"
                        ElseIf _result = "Failed" Then
                            ' Examinee has taken test A but failed
                            DoExamination(_activeLevel)
                            Examinee.lblSetDescription.Text = "B"
                        ElseIf _result = "Passed" Then
                            MessageBox.Show("You have passed")
                            Exit Sub
                        End If

                    ElseIf sql.recordCount = 2 Then ' Case B

                        ' You know there are two rows. You get the recent row. 
                        _result = sql.sqlDataSet.Tables(0).Rows(1).Item("result").ToString

                        If _result = "Failed" Then
                            DoExamination(_activeLevel)
                            Examinee.lblSetDescription.Text = "C"
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



        Examinee.Show()
        Me.Close()
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
