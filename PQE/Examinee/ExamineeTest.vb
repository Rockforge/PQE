Imports MaterialSkin
Imports System.Text

Public Class ExamineeTest

    Public sql As New SQLControl
    Public mail As New Emailing
    Dim rs As New Resizer

    Dim questionCounter As Integer = 0
    Dim numberOfQuestion As Integer = 0
    Dim examineeAnswer As String
    Dim score As Integer = 0

    Dim rowClicked As Integer

    Dim hasClickedAnswer As Boolean = False

    ' changed id
    Dim levelID As String
    Dim pastExamineeAnswer As String

    ' Timer. Code Source: Idle_Mind from Stackoverflow (Timer to count down in VB.Net 2010?)
    Dim targetDT As DateTime
    Dim countdownFrom As TimeSpan

    Private Sub ExamineeTest_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim _skinManager As MaterialSkinManager = MaterialSkinManager.Instance
        _skinManager.AddFormToManage(Me)
        _skinManager.Theme = MaterialSkinManager.Themes.LIGHT
        _skinManager.ColorScheme = New ColorScheme(Primary.Blue600, Primary.Blue700, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)

        ' DGV UI
        dgvQuestionNumber.MultiSelect = False
        dgvUnansweredQuestion.MultiSelect = False

        ' Checks question availability
        sql.AddParam("@kindID", lblKindID.Text)
        sql.AddParam("@setDescription", lblSetDescription.Text)
        sql.ExecuteQuery("SELECT * FROM tbl_question WHERE kindID = @kindID AND setDescription = @setDescription")
        If sql.recordCount <= 0 Then
            MessageBox.Show("No questions yet." & vbNewLine & "Please inform the administrator." & vbNewLine & "The application will now close.")

            ' Close Examinee.vb and this form. Go back to Login.vb
            Login.Show()
            Examinee.Close()
            Me.Close()
            Exit Sub
        End If
        ' Timer configuration
        countdownFrom = TimeSpan.FromMinutes(Integer.Parse(lblTimer.Text))
        tmrTest.Interval = 500
        targetDT = DateTime.Now.Add(countdownFrom)
        ' Starts timer
        tmrTest.Start()

        ' Loads all unanswered questions
        LoadDgvUnansweredQuestion()
        ' Load All Question Number for the specific test with the Question ID
        LoadDgvQuestionNumber()

        ' Getting first question
        LoadFirstQuestion()

        rs.FindAllControls(Me)
    End Sub

    Private Sub ExamineeTest_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        rs.ResizeAllControls(Me)
    End Sub


    Private Sub LoadFirstQuestion()
        sql.AddParam("@questionID", lblQuestionID.Text)
        sql.ExecuteQuery("SELECT * FROM tbl_question WHERE questionID = @questionID")

        rtfQuestion.Rtf = Encoding.ASCII.GetChars(sql.sqlDataSet.Tables(0).Rows(0).Item("question"))
        rbChoice1.Text = sql.sqlDataSet.Tables(0).Rows(0).Item("choice1").ToString
        rbChoice2.Text = sql.sqlDataSet.Tables(0).Rows(0).Item("choice2").ToString
        rbChoice3.Text = sql.sqlDataSet.Tables(0).Rows(0).Item("choice3").ToString
        rbChoice4.Text = sql.sqlDataSet.Tables(0).Rows(0).Item("choice4").ToString
    End Sub

    ' Loads our DGV
    Private Sub LoadDgvQuestionNumber()
        sql.AddParam("@examineeID", lblExamineeID.Text)
        sql.AddParam("@kindID", lblKindID.Text)
        sql.AddParam("@setDescription", lblSetDescription.Text)
        sql.ExecuteQuery("SET @rowNumber = 0;
                       SELECT @rowNumber:=@rowNumber + 1 AS 'Question List', questionID FROM tbl_question
                        WHERE questionID IN (SELECT questionID FROM tbl_response WHERE tbl_response.examineeID = @examineeID)
                          AND kindID = @kindID
                          AND setDescription = @setDescription")



        dgvQuestionNumber.DataSource = sql.sqlDataSet.Tables(0)
        dgvQuestionNumber.Columns(1).Visible = False

    End Sub

    Private Sub LoadDgvUnansweredQuestion()
        sql.AddParam("@examineeID", lblExamineeID.Text)
        sql.AddParam("@kindID", lblKindID.Text)
        sql.AddParam("@setDescription", lblSetDescription.Text)

        sql.ExecuteQuery("SET @rowNumber = 0;
                       SELECT @rowNumber:=@rowNumber +1 AS 'Unanswered Question', questionID FROM tbl_question
                        WHERE questionID NOT IN (SELECT questionID FROM tbl_response WHERE tbl_response.examineeID = @examineeID)
                          AND kindID = @kindID
                          AND setDescription = @setDescription")

        dgvUnansweredQuestion.DataSource = sql.sqlDataSet.Tables(0)
        dgvUnansweredQuestion.Columns(1).Visible = False

        ' Catches error if there is no record left
        If sql.recordCount > 0 Then
            lblQuestionID.Text = sql.sqlDataSet.Tables(0).Rows(0).Item("questionID").ToString
        Else
            Exit Sub
        End If

    End Sub

    ' Insertion/Update of Answer
    Private Sub InsertResponse(examineeAnswer As String)
        ' CHECK IF EXISTING EXAMINEE ANSWER .. IF YES UPDATE .. ELSE INSERT
        sql.AddParam("@examineeID", lblExamineeID.Text)
        sql.AddParam("@questionID", lblQuestionID.Text)
        sql.AddParam("@examineeAnswer", examineeAnswer)
        sql.ExecuteQuery("SELECT * FROM tbl_response
                                  WHERE examineeID = @examineeID
                                    AND questionID = @questionID")

        ' PARAMS for REQUERYING
        sql.AddParam("@examineeID", lblExamineeID.Text)
        sql.AddParam("@questionID", lblQuestionID.Text)
        sql.AddParam("@examineeAnswer", examineeAnswer)

        If sql.recordCount > 0 Then

            ' UPDATE CURRENT RESPONSE
            sql.ExecuteQuery("UPDATE tbl_response
                             SET examineeAnswer = @examineeAnswer
                           WHERE examineeID = @examineeID
                             AND questionID = @questionID")


        Else
            ' INSERT INTO response
            sql.ExecuteQuery("INSERT INTO tbl_response (examineeID, questionID, examineeAnswer) 
                                            VALUES (@examineeID, @questionID, @examineeAnswer)")


        End If
        lblScoreHide.Text = score

    End Sub

    ' Reloads answer
    Private Sub ReloadRecordedAnswer()
        ' RELOADING Examinee's Answer
        sql.AddParam("@examineeID", lblExamineeID.Text)
        sql.AddParam("@questionID", lblQuestionID.Text)
        sql.AddParam("@examineeAnswer", examineeAnswer)
        sql.ExecuteQuery("SELECT * FROM tbl_response
                                  WHERE examineeID = @examineeID
                                    AND questionID = @questionID")

        If sql.recordCount > 0 Then

            ' If there is an examinee answer
            If Not IsDBNull(sql.sqlDataSet.Tables(0).Rows(0).Item("examineeAnswer")) Then

                For Each r As DataRow In sql.sqlDataSet.Tables(0).Rows
                    If rbChoice1.Text = r("examineeAnswer") Then
                        rbChoice1.Checked = True
                        rtfChosenAnswer.Text = rbChoice1.Text
                    ElseIf rbChoice2.Text = r("examineeAnswer") Then
                        rbChoice2.Checked = True
                        rtfChosenAnswer.Text = rbChoice2.Text
                    ElseIf rbChoice3.Text = r("examineeAnswer") Then
                        rbChoice3.Checked = True
                        rtfChosenAnswer.Text = rbChoice3.Text
                    ElseIf rbChoice4.Text = r("examineeAnswer") Then
                        rbChoice4.Checked = True
                        rtfChosenAnswer.Text = rbChoice4.Text
                    End If
                Next
            Else
                UncheckRadioButton()
                rtfChosenAnswer.Text = ""
                Exit Sub
            End If

        Else
            UncheckRadioButton()
            rtfChosenAnswer.Text = ""
            Exit Sub
        End If


    End Sub

    ' Insert score
    Private Sub InsertScore()
        ' Checks if there is a record
        sql.AddParam("@examineeID", lblExamineeID.Text)
        sql.AddParam("@kindID", lblKindID.Text)
        sql.AddParam("@setDescription", lblSetDescription.Text)
        sql.ExecuteQuery("SELECT * FROM tbl_examinee_score WHERE examineeID = @examineeID AND kindID = @kindID AND setDescription = @setDescription")

        sql.AddParam("@examineeID", lblExamineeID.Text)
        sql.AddParam("@kindID", lblKindID.Text)
        sql.AddParam("@examineeScore", score)
        sql.AddParam("@setDescription", lblSetDescription.Text)

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

    ' Timer for test. NOTE: Setting are changed in property
    Private Sub timerTest_Tick(sender As Object, e As EventArgs) Handles tmrTest.Tick
        Dim _ts As TimeSpan = targetDT.Subtract(DateTime.Now)

        If _ts.TotalMilliseconds > 0 Then
            lblTimer.Text = _ts.ToString("hh\:mm\:ss")
        Else

            lblTimer.Text = "00:00"
            ' Stops timer
            tmrTest.Stop()
            MessageBox.Show("Time is finished")

            ' Knows that the exam is finished
            TestTypeFinished()

            ' Shows examinee and closes this form
            Me.Close()
            Exit Sub
        End If

    End Sub

    ' Buttons
    Private Sub btnQuestionNext_Click(sender As Object, e As EventArgs) Handles btnQuestionNext.Click

        If dgvQuestionNumber.RowCount <= 0 Then
            Exit Sub
        End If
        Dim _maxRowIndex As Integer = dgvQuestionNumber.Rows.Count - 1

        Dim _currentGridViewRow As DataGridViewRow = dgvQuestionNumber.CurrentRow
        Dim _currentRowIndex As Integer = _currentGridViewRow.Index


        If _currentRowIndex >= _maxRowIndex Then
            MessageBox.Show("No more rows left")
            Exit Sub
        Else
            Dim _nextRow As DataGridViewRow = dgvQuestionNumber.Rows(_currentRowIndex + 1)

            dgvQuestionNumber.CurrentCell = _nextRow.Cells(0)
            _nextRow.Selected = True

            ReloadRecordedAnswer()

            lblQuestionID.Text = _nextRow.Cells(1).Value.ToString

            sql.AddParam("@questionID", lblQuestionID.Text)
            sql.ExecuteQuery("SELECT * FROM tbl_question WHERE questionID = @questionID")

            rtfQuestion.Rtf = Encoding.ASCII.GetChars(sql.sqlDataSet.Tables(0).Rows(0).Item("question"))
            rbChoice1.Text = sql.sqlDataSet.Tables(0).Rows(0).Item("choice1").ToString
            rbChoice2.Text = sql.sqlDataSet.Tables(0).Rows(0).Item("choice2").ToString
            rbChoice3.Text = sql.sqlDataSet.Tables(0).Rows(0).Item("choice3").ToString
            rbChoice4.Text = sql.sqlDataSet.Tables(0).Rows(0).Item("choice4").ToString

            ReloadRecordedAnswer()
        End If

    End Sub

    Private Sub btnQuestionPrevious_Click(sender As Object, e As EventArgs) Handles btnQuestionPrevious.Click

        If dgvQuestionNumber.RowCount <= 0 Then
            Exit Sub
        End If

        Dim _currentGridViewRow As DataGridViewRow = dgvQuestionNumber.CurrentRow
        Dim _currentRowIndex As Integer = _currentGridViewRow.Index

        If _currentRowIndex <= 0 Then
            MessageBox.Show("No more rows left")
            Exit Sub
        Else
            Dim _prevRow As DataGridViewRow = dgvQuestionNumber.Rows(_currentRowIndex - 1)

            dgvQuestionNumber.CurrentCell = _prevRow.Cells(0)
            _prevRow.Selected = True

            lblQuestionID.Text = _prevRow.Cells(1).Value.ToString

            sql.AddParam("@questionID", lblQuestionID.Text)
            sql.ExecuteQuery("SELECT * FROM tbl_question WHERE questionID = @questionID")

            rtfQuestion.Rtf = Encoding.ASCII.GetChars(sql.sqlDataSet.Tables(0).Rows(0).Item("question"))
            rbChoice1.Text = sql.sqlDataSet.Tables(0).Rows(0).Item("choice1").ToString
            rbChoice2.Text = sql.sqlDataSet.Tables(0).Rows(0).Item("choice2").ToString
            rbChoice3.Text = sql.sqlDataSet.Tables(0).Rows(0).Item("choice3").ToString
            rbChoice4.Text = sql.sqlDataSet.Tables(0).Rows(0).Item("choice4").ToString

            ReloadRecordedAnswer()
        End If

    End Sub

    Private Sub dgvQuestionNumber_MouseDown(sender As Object, e As MouseEventArgs) Handles dgvQuestionNumber.MouseDown
        Dim _ht = dgvQuestionNumber.HitTest(e.Location.X, e.Location.Y)

        If _ht.Type = DataGridViewHitTestType.None Or _ht.Type = DataGridViewHitTestType.ColumnHeader Then
            Exit Sub
        End If

        UncheckRadioButton()

        rowClicked = dgvQuestionNumber.HitTest(e.Location.X, e.Location.Y).RowIndex
        dgvQuestionNumber.ClearSelection()
        dgvQuestionNumber.Rows(rowClicked).Selected = True

        lblQuestionID.Text = dgvQuestionNumber.SelectedRows(0).Cells("questionID").Value.ToString
        sql.AddParam("@questionID", lblQuestionID.Text)
        sql.ExecuteQuery("SELECT * FROM tbl_question WHERE questionID = @questionID")

        rtfQuestion.Rtf = Encoding.ASCII.GetChars(sql.sqlDataSet.Tables(0).Rows(0).Item("question"))
        rbChoice1.Text = sql.sqlDataSet.Tables(0).Rows(0).Item("choice1").ToString
        rbChoice2.Text = sql.sqlDataSet.Tables(0).Rows(0).Item("choice2").ToString
        rbChoice3.Text = sql.sqlDataSet.Tables(0).Rows(0).Item("choice3").ToString
        rbChoice4.Text = sql.sqlDataSet.Tables(0).Rows(0).Item("choice4").ToString
        lblAnswer.Text = sql.sqlDataSet.Tables(0).Rows(0).Item("correctAnswer").ToString

        ReloadRecordedAnswer()
        dgvUnansweredQuestion.ClearSelection()
    End Sub

    Private Sub UncheckRadioButton()
        rbChoice1.Checked = False
        rbChoice2.Checked = False
        rbChoice3.Checked = False
        rbChoice4.Checked = False
    End Sub

    ' Gets our score
    Private Sub ComputeScore()
        sql.AddParam("@examineeID", lblExamineeID.Text)
        sql.AddParam("@kindID", lblKindID.Text)
        sql.AddParam("@setDescription", lblSetDescription.Text)

        ' Compare tbl_response answer with tbl_question correct answer
        sql.ExecuteQuery("SELECT * FROM tbl_response INNER JOIN tbl_question ON tbl_response.questionID = tbl_question.questionID 
                          WHERE tbl_question.kindID = @kindID AND tbl_question.setDescription = @setDescription AND tbl_response.examineeID = @examineeID")

        For Each r As DataRow In sql.sqlDataSet.Tables(0).Rows

            If r("examineeAnswer").ToString = r("correctAnswer").ToString Then
                score = score + 1
            End If

        Next

    End Sub

    ' ComputeScore() and InsertScore() are used here
    Private Sub TestTypeFinished()

        ' Compute scores
        ComputeScore()

        ' Insert scores
        InsertScore()

        ' Passing TestID to Examinee Form
        Examinee.lblLevelID.Text = lblLevelID.Text
        sql.AddParam("@levelID", lblLevelID.Text)
        sql.ExecuteQuery("SELECT * FROM tbl_kind
                             INNER JOIN tbl_test_type
                                     ON tbl_kind.testTypeID = tbl_test_type.testTypeID
                                  WHERE tbl_kind.levelID = @levelID")

        ' Passing Tests to Examinee Form
        Examinee.lblTest1.Text = sql.sqlDataSet.Tables(0).Rows(0).Item("testTypeDescription")
        Examinee.lblTime1.Text = sql.sqlDataSet.Tables(0).Rows(0).Item("timer")
        Examinee.lblTestID1.Text = sql.sqlDataSet.Tables(0).Rows(0).Item("testTypeID")

        Examinee.lblTest2.Text = sql.sqlDataSet.Tables(0).Rows(1).Item("testTypeDescription")
        Examinee.lblTime2.Text = sql.sqlDataSet.Tables(0).Rows(1).Item("timer")
        Examinee.lblTestID2.Text = sql.sqlDataSet.Tables(0).Rows(1).Item("testTypeID")

        Examinee.lblTest3.Text = sql.sqlDataSet.Tables(0).Rows(2).Item("testTypeDescription")
        Examinee.lblTime3.Text = sql.sqlDataSet.Tables(0).Rows(2).Item("timer")
        Examinee.lblTestID3.Text = sql.sqlDataSet.Tables(0).Rows(2).Item("testTypeID")


        ' Passing Examinee Credentials to Examinee form
        Examinee.lblExamineeDateID.Text = lblExamineeDateID.Text
        Examinee.lblExamineeID.Text = lblExamineeID.Text
        Examinee.lblFirstName.Text = lblFirstName.Text
        Examinee.lblLastName.Text = lblLastName.Text
        Examinee.lblLevelDescription.Text = lblLevelDescription.Text
        Examinee.lblPositionDescription.Text = lblPositionDescription.Text


        ' update FLAGS if all tests = DONE
        Examinee.lblTestsDone.Text = Examinee.lblTestsDone.Text + 1

        ' nilipat ni mem yung TestDoneChecker() sa Test.vb
        ' If tapos na yung exam
        If (Examinee.lblLevelID.Text = "3" And Examinee.lblTestsDone.Text = "5") Or (Examinee.lblLevelID.Text <> 3 And Examinee.lblTestsDone.Text = "3") Then
            ' Insertion of pass or Fail
            Examinee.InsertPassOrFail()


            ' Dito ilalagay na IF NULL EMAIL FIELD, PROMPT USER IF THEY WANT EMAIL

            sql.AddParam("@examineeID", lblExamineeID.Text)
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
                mail.SendExamineeEmail(lblExamineeID.Text, lblSetDescription.Text, lblLevelID.Text, lblPositionDescription.Text, _examineeEmail)

            End If

            Login.txtExamineeDateID.Text = ""
            Login.txtLastName.Text = ""

            MessageBox.Show("Thank you for taking the Pre-qualification exam." & vbNewLine & "Please consult the administrator for further instructions")
            Examinee.Close()

            Login.Show()
        Else
            Examinee.Show()
        End If

        Me.Close()
    End Sub

    Private Sub btnAnswer_Click(sender As Object, e As EventArgs) Handles btnAnswer.Click

        If rbChoice1.Checked = True Then
            examineeAnswer = rbChoice1.Text
        ElseIf rbChoice2.Checked = True Then
            examineeAnswer = rbChoice2.Text
        ElseIf rbChoice3.Checked = True Then
            examineeAnswer = rbChoice3.Text
        ElseIf rbChoice4.Checked = True Then
            examineeAnswer = rbChoice4.Text
        End If


        If examineeAnswer = "" Then
            MessageBox.Show("No Examinee Answer")
            Exit Sub
        End If


        ' Insert Answer by Examinee. NOTE: examineeAnswer is reliant upon Radio Buttons
        InsertResponse(examineeAnswer)

        ' Place examinee answer inside the box
        rtfChosenAnswer.Text = examineeAnswer

        ' Remove examinee answer
        examineeAnswer = ""

        ' Loads dgv to remove answered question
        LoadDgvUnansweredQuestion()
        LoadDgvQuestionNumber()

        ' Clear selection from dgvUnansweredQuestion
        dgvUnansweredQuestion.ClearSelection()

    End Sub

    Private Sub btnFinishTest_Click(sender As Object, e As EventArgs) Handles btnFinishTest.Click
        If MessageBox.Show("You will not be able to go back to this test after you finish it. " & vbNewLine & "Are you sure you want to finish the test?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            TestTypeFinished()
        End If
    End Sub

    Private Sub dgvUnansweredQuestion_MouseDown(sender As Object, e As MouseEventArgs) Handles dgvUnansweredQuestion.MouseDown
        Dim _ht = dgvUnansweredQuestion.HitTest(e.Location.X, e.Location.Y)

        If _ht.Type = DataGridViewHitTestType.None Or _ht.Type = DataGridViewHitTestType.ColumnHeader Then
            Exit Sub
        End If

        UncheckRadioButton()

        rowClicked = dgvUnansweredQuestion.HitTest(e.Location.X, e.Location.Y).RowIndex
        dgvUnansweredQuestion.ClearSelection()
        dgvUnansweredQuestion.Rows(rowClicked).Selected = True

        lblQuestionID.Text = dgvUnansweredQuestion.SelectedRows(0).Cells("questionID").Value.ToString
        sql.AddParam("@questionID", lblQuestionID.Text)
        sql.ExecuteQuery("SELECT * FROM tbl_question WHERE questionID = @questionID")

        rtfQuestion.Rtf = Encoding.ASCII.GetChars(sql.sqlDataSet.Tables(0).Rows(0).Item("question"))
        rbChoice1.Text = sql.sqlDataSet.Tables(0).Rows(0).Item("choice1").ToString
        rbChoice2.Text = sql.sqlDataSet.Tables(0).Rows(0).Item("choice2").ToString
        rbChoice3.Text = sql.sqlDataSet.Tables(0).Rows(0).Item("choice3").ToString
        rbChoice4.Text = sql.sqlDataSet.Tables(0).Rows(0).Item("choice4").ToString
        lblAnswer.Text = sql.sqlDataSet.Tables(0).Rows(0).Item("correctAnswer").ToString

        ReloadRecordedAnswer()

        ' Deselect anything from dgvQuestionNumber
        dgvQuestionNumber.ClearSelection()
    End Sub
End Class