Imports MaterialSkin

Imports MigraDoc.DocumentObjectModel
Imports MigraDoc.DocumentObjectModel.Styles
Imports MigraDoc.Rendering
Imports MigraDoc.RtfRendering
Imports MigraDoc.DocumentObjectModel.Tables

Imports System.IO
Imports System.IO.Path
Imports System.Text

Public Class AdminTempDashboard


    Dim sql As New SQLControl

    ' For date
    Dim currentDate As String = Date.Now.ToString("yyyy-MM-dd")
    Dim newID As String
    Dim printDate As String

    ' For Examinee Tab
    Dim isEditable As Boolean = False

    ' For rowClicking
    Dim rowClicked As Integer
    Dim hasPicture As Boolean = False

    Dim rs As New Resizer



    Private Sub AdminTempDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim _skinManager As MaterialSkinManager = MaterialSkinManager.Instance
        _skinManager.AddFormToManage(Me)
        _skinManager.Theme = MaterialSkinManager.Themes.LIGHT
        _skinManager.ColorScheme = New ColorScheme(Primary.Blue600, Primary.Blue700, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)

        ' Get current month name
        Dim _currentDate As Date = Date.Now
        printDate = _currentDate.ToString("MMMM dd, yyyy")

        ' Examinee tab

        LoadExamineeDgv()
        LoadExamineePosition()
        btnExamineeEdit.Visible = False
        lblExamineeError.Visible = False
        picExamineeError.Visible = False

        ' Filter Dates
        dtpFromFilter.Enabled = False
        dtpToFilter.Enabled = False

        ' Load lastBackup and lastRestore
        sql.ExecuteQuery("SELECT * from tbl_admin
                           WHERE adminID = 1
                             AND adminUsername = 'admin'
                             AND adminLevel = 0")


        rs.FindAllControls(Me)
    End Sub

    Private Sub txtFirstName_Leave() Handles txtFirstName.Leave
        If Not txtFirstName.NameCheck(txtFirstName.Text) Then
            lblFirstNameError.Visible = True
        Else
            lblFirstNameError.Visible = False
        End If
    End Sub

    Private Sub txtLastName_Leave() Handles txtLastName.Leave
        If Not txtLastName.NameCheck(txtLastName.Text) Then
            lblLastNameError.Visible = True
        Else
            lblLastNameError.Visible = False
        End If
    End Sub

    Private Sub txtEmailAddress_Leave() Handles txtEmailAddress.Leave
        If Not txtEmailAddress.EmailAddressCheck(txtEmailAddress.Text, lblExamineeDateID.Text) Then
            lblEmailError.Visible = True
        Else
            lblEmailError.Visible = False
        End If
    End Sub

    Private Sub btnExamineeRegister_Click(sender As Object, e As EventArgs) Handles btnExamineeRegister.Click

        ' Error catching


        If txtFirstName.Text = "" Or txtLastName.Text = "" Then
            picExamineeError.Visible = True
            lblExamineeError.Text = "Incorrect Details"
            lblExamineeError.Visible = True
            Exit Sub
        End If

        If lblEmailError.Visible = True Or lblFirstNameError.Visible = True Or lblLastNameError.Visible = True Then
            MessageBox.Show("Please validate the fields")
            Exit Sub
        End If



        ' To check if there exists at least 1 Position level
        Dim _positionFlag As Boolean = False

        If Not cboSupervisoryPosition.Text = "" Then
            _positionFlag = True
        End If

        If Not cboNonSupervisoryPosition.Text = "" Then
            _positionFlag = True
        End If

        If Not cboClericalPosition.Text = "" Then
            _positionFlag = True
        End If

        If Not _positionFlag Then
            MessageBox.Show("Please select at least one Position Title")
            _positionFlag = False
            Exit Sub
        End If

        ' To check if there exists at least 1 active level CHECKED
        Dim _activeFlag As Boolean = False
        Dim _activeLevel As Integer

        If rbSupervisoryActive.Checked Then
            If cboSupervisoryPosition.Text = "" Then
                MessageBox.Show("Please fill up the Position title for Active Exam Level")
                Exit Sub
            End If
            _activeLevel = 1
            _activeFlag = True
        End If

        If rbNonSupervisoryActive.Checked Then
            If cboNonSupervisoryPosition.Text = "" Then
                MessageBox.Show("Please fill up the Position title for Active Exam Level")
                Exit Sub
            End If
            _activeLevel = 2
            _activeFlag = True
        End If
        If rbClericalActive.Checked Then
            If cboClericalPosition.Text = "" Then
                MessageBox.Show("Please fill up the Position title for Active Exam Level")
                Exit Sub
            End If
            _activeLevel = 3
            _activeFlag = True
        End If

        If Not _activeFlag Then
            MessageBox.Show("Please Select at least one active Exam Level")
            _activeFlag = False
            Exit Sub
        End If





        ' The Examinee Date ID
        newID = currentDate

        ' INSERTION OF EXAMINEE
        sql.AddParam("@firstName", txtFirstName.Text)
        sql.AddParam("@lastName", txtLastName.Text)
        sql.AddParam("@newID", newID)
        sql.AddParam("@activeLevel", _activeLevel)
        sql.AddParam("@emailAddress", txtEmailAddress.Text)
        sql.ExecuteQuery("INSERT INTO tbl_examinee (firstName, lastName, dateTaken, activeLevel, emailAddress) VALUES (@firstName, @lastName, @newID, @activeLevel, @emailAddress)")

        ' PUT newID/examineeDateID to LAST INSERTED ROW
        sql.AddParam("@newID", newID)
        sql.ExecuteQuery("UPDATE tbl_examinee
                           SET examineeDateID = CONCAT(@newID, '-', LAST_INSERT_ID())
                         WHERE examineeID = LAST_INSERT_ID() ")


        If cboSupervisoryPosition.Text <> "" Then
            InsertExamLevels(1)
        End If

        If cboNonSupervisoryPosition.Text <> "" Then
            InsertExamLevels(2)
        End If

        If cboClericalPosition.Text <> "" Then
            InsertExamLevels(3)
        End If



        LoadExamineeDgv()

        ' Select who is REGISTERED

        dgvExaminee.Rows(0).Selected = True

        lblExamineeError.Visible = False
        picExamineeError.Visible = False
    End Sub

    Private Sub btnExamineeClear_Click(sender As Object, e As EventArgs) Handles btnExamineeClear.Click

        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtEmailAddress.Text = ""
        lblExamineeDateID.Text = ""
        cboSupervisoryPosition.SelectedIndex = -1
        cboNonSupervisoryPosition.SelectedIndex = -1
        cboClericalPosition.SelectedIndex = -1
        rbSupervisoryActive.Checked = False
        rbNonSupervisoryActive.Checked = False
        rbClericalActive.Checked = False

        btnExamineeEdit.Visible = False
        btnExamineeRegister.Visible = True

        picExamineeError.Visible = False
        lblExamineeError.Visible = False

        cboSupervisoryPosition.Enabled = True
        cboNonSupervisoryPosition.Enabled = True
        cboClericalPosition.Enabled = True

        txtSupervisoryResultA.Text = "N/A"
        txtSupervisoryResultB.Text = "N/A"
        txtSupervisoryResultC.Text = "N/A"

        txtNonSupervisoryResultA.Text = "N/A"
        txtNonSupervisoryResultB.Text = "N/A"
        txtNonSupervisoryResultC.Text = "N/A"

        txtClericalResultA.Text = "N/A"
        txtClericalResultB.Text = "N/A"
        txtClericalResultC.Text = "N/A"


        ' If dgvRow is not 0, then deselect
        If dgvExaminee.Rows.Count <> 0 Then
            dgvExaminee.Rows(rowClicked).Selected = False
        End If
    End Sub

    Private Sub btnExamineeEdit_Click(sender As Object, e As EventArgs) Handles btnExamineeEdit.Click

        ' Checks to see if there is no data inside text fields 
        If lblExamineeDateID.Text = "" Or txtFirstName.Text = "" Or txtLastName.Text = "" Then
            lblExamineeError.Text = "Please select a record first!"
            lblExamineeError.Visible = True
            picExamineeError.Visible = True
            Exit Sub
        End If

        If lblEmailError.Visible = True Or lblFirstNameError.Visible = True Or lblLastNameError.Visible = True Then
            MessageBox.Show("Please validate the fields")
            Exit Sub
        End If

        Dim _activeLevel As Integer

        If rbSupervisoryActive.Checked Then
            ' respective cboPosition must not be null
            If cboSupervisoryPosition.Text = "" Then
                MessageBox.Show("Please fill up Active level's position")
                Exit Sub
            End If
            _activeLevel = 1
        ElseIf rbNonSupervisoryActive.Checked Then
            If cboNonSupervisoryPosition.Text = "" Then
                MessageBox.Show("Please fill up Active level's position")
                Exit Sub
            End If
            _activeLevel = 2
        ElseIf rbClericalActive.Checked Then
            If cboClericalPosition.Text = "" Then
                MessageBox.Show("Please fill up Active level's position")
                Exit Sub
            End If
            _activeLevel = 3
        End If


        ' Edit function for tbl_examinee
        sql.AddParam("@examineeDateID", lblExamineeDateID.Text)
        sql.AddParam("@newFirstName", txtFirstName.Text)
        sql.AddParam("@newLastName", txtLastName.Text)
        sql.AddParam("@activeLevel", _activeLevel)
        sql.AddParam("@emailAddress", txtEmailAddress.Text)
        sql.ExecuteQuery("UPDATE tbl_examinee
                             SET      firstName = @newFirstName,
                                       lastName = @newLastname,
                                    activeLevel = @activeLevel,
                                   emailAddress = @emailAddress
                           WHERE examineeDateID = @examineeDateID")


        ' { Edit function for tbl_examinee_set

        ' Get ID of position
        Dim _superVisoryPositionID As Integer
        Dim _nonSuperVisoryPositionID As Integer
        Dim _clericalPositionID As Integer


        If Not cboSupervisoryPosition.Text = "" Then

            sql.AddParam("@superPosition", cboSupervisoryPosition.Text)
            sql.ExecuteQuery("SELECT * FROM tbl_position WHERE positionDescription = @superPosition")
            If sql.recordCount <> 0 Then
                _superVisoryPositionID = Integer.Parse(sql.sqlDataSet.Tables(0).Rows(0).Item("positionID"))

                EditExamineePosition(1, _superVisoryPositionID)
            End If
        End If

        If Not cboNonSupervisoryPosition.Text = "" Then
            sql.AddParam("@nonSuperPosition", cboNonSupervisoryPosition.Text)
            sql.ExecuteQuery("SELECT * FROM tbl_position WHERE positionDescription = @nonSuperPosition")
            If sql.recordCount <> 0 Then
                _nonSuperVisoryPositionID = Integer.Parse(sql.sqlDataSet.Tables(0).Rows(0).Item("positionID"))

                EditExamineePosition(2, _nonSuperVisoryPositionID)
            End If
        End If

        If Not cboClericalPosition.Text = "" Then
            sql.AddParam("@clericalPosition", cboClericalPosition.Text)
            sql.ExecuteQuery("SELECT * FROM tbl_position WHERE positionDescription = @clericalPosition")
            If sql.recordCount <> 0 Then
                _clericalPositionID = Integer.Parse(sql.sqlDataSet.Tables(0).Rows(0).Item("positionID"))

                EditExamineePosition(3, _clericalPositionID)
            End If
        End If

        LoadExamineeDgv()

        ' Select who is EDITED
        ' TO SELECT ROW OF WHAT IS EDITED
        For Each row In dgvExaminee.Rows
            If row.Cells(0).Value.ToString = lblExamineeDateID.Text Then
                row.Selected = True
                Exit For
            End If
        Next

    End Sub

    Private Sub btnChangePicture_Click(sender As Object, e As EventArgs) Handles btnChangePicture.Click
        ExamineePicture.lblExamineeDateID.Text = lblExamineeDateID.Text
        ExamineePicture.Show()
    End Sub


    Private Function GetExamineeID() As Integer

        sql.AddParam("@examineeDateID", lblExamineeDateID.Text)
        sql.ExecuteQuery("SELECT examineeID from tbl_examinee WHERE examineeDateID = @examineeDateID")

        Return Integer.Parse(sql.sqlDataSet.Tables(0).Rows(0).Item("examineeID"))
    End Function

    Private Sub InsertExamLevels(_levelID As Integer)

        ' Get what position is currently active
        Dim _levelPosition As String = ""

        If _levelID = 1 Then
            _levelPosition = cboSupervisoryPosition.Text
        ElseIf _levelID = 2 Then
            _levelPosition = cboNonSupervisoryPosition.Text
        ElseIf _levelID = 3 Then
            _levelPosition = cboClericalPosition.Text
        End If

        Dim _positionID As Integer
        sql.AddParam("@positionSelected", _levelPosition)
        sql.ExecuteQuery("SELECT * FROM tbl_position WHERE positionDescription = @positionSelected")
        If sql.recordCount > 0 Then
            For Each r As DataRow In sql.sqlDataSet.Tables(0).Rows
                ' Converts position ID to integer
                _positionID = Convert.ToInt64((r("positionID")))
            Next
        Else
            picExamineeError.Visible = True
            lblExamineeError.Text = "No Position selected yet!"
            lblExamineeError.Visible = True
        End If

        ' INSERT to tbl_examinee_set. Reason: Each newly registered user has Test A
        sql.AddParam("@setDescription", "A")
        sql.AddParam("@levelID", _levelID)
        sql.AddParam("@positionID", _positionID)
        sql.ExecuteQuery("INSERT INTO tbl_examinee_set (examineeID, setDescription, levelID, positionID)
                               VALUES (LAST_INSERT_ID(), @setDescription, @levelID, @positionID)")

    End Sub

    Public Function CreateTableSupervisory(_levelDescription As String, _examineeID As String, _setDescription As String) As Table

        ' Get Number of questions. Using LevelDescription, Examinee ID, SetDescription
        Dim _paraTestType As Paragraph = New Paragraph()
        Dim _paraCorrectAnswers As Paragraph = New Paragraph()
        Dim _paraTotalItems As Paragraph = New Paragraph()

        _paraTestType.AddText("Type of Test")
        _paraTestType.Format.Alignment = ParagraphAlignment.Center

        _paraCorrectAnswers.AddText("Correct Answers")
        _paraCorrectAnswers.Format.Alignment = ParagraphAlignment.Center

        _paraTotalItems.AddText("Total Items")
        _paraTotalItems.Format.Alignment = ParagraphAlignment.Center

        ' setDescription is a Variable
        sql.AddParam("@setDescription", _setDescription)
        sql.ExecuteQuery("SELECT tbl_kind.kindID, COUNT(tbl_question.questionID) AS NumberOfQuestions FROM tbl_question
                      INNER JOIN tbl_kind
                              ON tbl_question.kindID = tbl_kind.kindID
                      INNER JOIN tbl_level
                              ON tbl_kind.levelID = tbl_level.levelID
                           WHERE tbl_question.setDescription = @setDescription AND tbl_level.levelDescription = 'Supervisory'
                        GROUP BY tbl_kind.kindID")

        ' kindID = 1. Management and Leadership Concept
        ' kindID = 2. Numerical
        ' kindID = 3. Verbal
        Dim _maxSupervisoryManagement As String = sql.sqlDataSet.Tables(0).Rows(0).Item("NumberOfQuestions").ToString
        Dim _maxSupervisoryNumerical As String = sql.sqlDataSet.Tables(0).Rows(1).Item("NumberOfQuestions").ToString
        Dim _maxSupervisoryVerbal As String = sql.sqlDataSet.Tables(0).Rows(2).Item("NumberOfQuestions").ToString

        ' Get Scores. Uses kindID, setDescription, and examineeID
        sql.AddParam("@setDescription", _setDescription)
        sql.AddParam("@examineeID", _examineeID)
        sql.ExecuteQuery("SELECT tbl_kind.kindID, tbl_examinee_score.examineeScore AS ExamineeScore FROM tbl_examinee_score
                      INNER JOIN tbl_kind
                              ON tbl_examinee_score.kindID = tbl_kind.kindID
                           WHERE tbl_examinee_score.setDescription = @setDescription AND tbl_examinee_score.examineeID = @examineeID
                        ORDER BY tbl_kind.kindID ASC")

        Dim _supervisoryManagement As String = sql.sqlDataSet.Tables(0).Rows(0).Item("ExamineeScore").ToString
        Dim _supervisoryNumerical As String = sql.sqlDataSet.Tables(0).Rows(1).Item("ExamineeScore").ToString
        Dim _supervisoryVerbal As String = sql.sqlDataSet.Tables(0).Rows(2).Item("ExamineeScore").ToString


        ' Creating our table
        Dim _table As Table = New Table()
        _table.Borders.Width = 0.75

        Dim _column As Column = New Column()
        Dim _row As Row = New Row()
        Dim _cell As Cell = New Cell()


        _column = _table.AddColumn(Unit.FromInch(3.25))
        _column = _table.AddColumn(Unit.FromInch(1.625))
        _column = _table.AddColumn(Unit.FromInch(1.625))

        ' Headers
        _row = _table.AddRow()
        _row.Shading.Color = Colors.PaleGoldenrod
        _cell = _row.Cells(0)
        _cell.Add(_paraTestType)
        _cell = _row.Cells(1)
        _cell.Add(_paraTotalItems)
        _cell = _row.Cells(2)
        _cell.Add(_paraCorrectAnswers)

        _row = _table.AddRow()
        _cell = _row.Cells(0)
        _cell.AddParagraph("Numerical")
        _cell = _row.Cells(1)
        _cell.Format.Alignment = ParagraphAlignment.Center
        _cell.AddParagraph(_maxSupervisoryNumerical)
        _cell = _row.Cells(2)
        _cell.Format.Alignment = ParagraphAlignment.Center
        _cell.AddParagraph(_supervisoryNumerical)


        _row = _table.AddRow()
        _cell = _row.Cells(0)
        _cell.AddParagraph("Verbal")
        _cell = _row.Cells(1)
        _cell.Format.Alignment = ParagraphAlignment.Center
        _cell.AddParagraph(_maxSupervisoryVerbal)
        _cell = _row.Cells(2)
        _cell.Format.Alignment = ParagraphAlignment.Center
        _cell.AddParagraph(_supervisoryVerbal)


        _row = _table.AddRow()
        _cell = _row.Cells(0)
        _cell.AddParagraph("Management and Leadership Concept")
        _cell = _row.Cells(1)
        _cell.Format.Alignment = ParagraphAlignment.Center
        _cell.AddParagraph(_maxSupervisoryManagement)
        _cell = _row.Cells(2)
        _cell.Format.Alignment = ParagraphAlignment.Center
        _cell.AddParagraph(_supervisoryManagement)

        ' Grand totals
        Dim _grandTotalItems As Integer = Integer.Parse(_maxSupervisoryManagement) + Integer.Parse(_maxSupervisoryNumerical) + Integer.Parse(_maxSupervisoryVerbal)
        Dim _grandTotalScore As Integer = Integer.Parse(_supervisoryManagement) + Integer.Parse(_supervisoryNumerical) + Integer.Parse(_supervisoryVerbal)


        _row = _table.AddRow()
        _cell = _row.Cells(0)
        _cell.Format.Font.Bold = True
        _cell.AddParagraph("Grand Total")
        _cell = _row.Cells(1)
        _cell.Format.Alignment = ParagraphAlignment.Center
        _cell.Format.Font.Bold = True
        _cell.AddParagraph(_grandTotalItems)
        _cell = _row.Cells(2)
        _cell.Format.Font.Bold = True
        _cell.Format.Alignment = ParagraphAlignment.Center
        _cell.AddParagraph(_grandTotalScore)

        Return _table

    End Function

    Public Function CreateTableNonSupervisory(_levelDescription As String, _examineeID As String, _setDescription As String) As Table

        ' Get Number of questions. Using LevelDescription, Examinee ID, SetDescription
        Dim _paraTestType As Paragraph = New Paragraph()
        Dim _paraCorrectAnswers As Paragraph = New Paragraph()
        Dim _paraTotalItems As Paragraph = New Paragraph()

        _paraTestType.AddText("Type of Test")
        _paraTestType.Format.Alignment = ParagraphAlignment.Center

        _paraCorrectAnswers.AddText("Correct Answers")
        _paraCorrectAnswers.Format.Alignment = ParagraphAlignment.Center

        _paraTotalItems.AddText("Total Items")
        _paraTotalItems.Format.Alignment = ParagraphAlignment.Center

        ' setDescription is a Variable
        sql.AddParam("@setDescription", _setDescription)
        sql.ExecuteQuery("SELECT tbl_kind.kindID, COUNT(tbl_question.questionID) AS NumberOfQuestions FROM tbl_question
                      INNER JOIN tbl_kind
                              ON tbl_question.kindID = tbl_kind.kindID
                      INNER JOIN tbl_level
                              ON tbl_kind.levelID = tbl_level.levelID
                           WHERE tbl_question.setDescription = @setDescription AND tbl_level.levelDescription = 'Non-Supervisory'
                        GROUP BY tbl_kind.kindID")

        ' kindID = 4. Reading Comprehension 
        ' kindID = 5. Numerical
        ' kindID = 6. Verbal
        Dim _maxNonSupervisoryReading As String = sql.sqlDataSet.Tables(0).Rows(0).Item("NumberOfQuestions").ToString
        Dim _maxNonSupervisoryNumerical As String = sql.sqlDataSet.Tables(0).Rows(1).Item("NumberOfQuestions").ToString
        Dim _maxNonSupervisoryVerbal As String = sql.sqlDataSet.Tables(0).Rows(2).Item("NumberOfQuestions").ToString

        ' Get Scores. Uses kindID, setDescription, and examineeID
        sql.AddParam("@setDescription", _setDescription)
        sql.AddParam("@examineeID", _examineeID)
        sql.ExecuteQuery("SELECT tbl_kind.kindID, tbl_examinee_score.examineeScore AS ExamineeScore FROM tbl_examinee_score
                      INNER JOIN tbl_kind
                              ON tbl_examinee_score.kindID = tbl_kind.kindID
                           WHERE tbl_examinee_score.setDescription = @setDescription AND tbl_examinee_score.examineeID = @examineeID
                        ORDER BY tbl_kind.kindID ASC")

        Dim _nonSupervisoryReading As String = sql.sqlDataSet.Tables(0).Rows(0).Item("ExamineeScore").ToString
        Dim _nonSupervisoryNumerical As String = sql.sqlDataSet.Tables(0).Rows(1).Item("ExamineeScore").ToString
        Dim _nonSupervisoryVerbal As String = sql.sqlDataSet.Tables(0).Rows(2).Item("ExamineeScore").ToString


        ' Creating our table
        Dim _table As Table = New Table()
        _table.Borders.Width = 0.75

        Dim _column As Column = New Column()
        Dim _row As Row = New Row()
        Dim _cell As Cell = New Cell()


        _column = _table.AddColumn(Unit.FromInch(3.25))
        _column = _table.AddColumn(Unit.FromInch(1.625))
        _column = _table.AddColumn(Unit.FromInch(1.625))

        ' Headers
        _row = _table.AddRow()
        _row.Shading.Color = Colors.PaleGoldenrod
        _cell = _row.Cells(0)
        _cell.Add(_paraTestType)
        _cell = _row.Cells(1)
        _cell.Add(_paraTotalItems)
        _cell = _row.Cells(2)
        _cell.Add(_paraCorrectAnswers)

        _row = _table.AddRow()
        _cell = _row.Cells(0)
        _cell.AddParagraph("Numerical")
        _cell = _row.Cells(1)
        _cell.Format.Alignment = ParagraphAlignment.Center
        _cell.AddParagraph(_maxNonSupervisoryNumerical)
        _cell = _row.Cells(2)
        _cell.Format.Alignment = ParagraphAlignment.Center
        _cell.AddParagraph(_nonSupervisoryNumerical)


        _row = _table.AddRow()
        _cell = _row.Cells(0)
        _cell.AddParagraph("Verbal")
        _cell = _row.Cells(1)
        _cell.Format.Alignment = ParagraphAlignment.Center
        _cell.AddParagraph(_maxNonSupervisoryVerbal)
        _cell = _row.Cells(2)
        _cell.Format.Alignment = ParagraphAlignment.Center
        _cell.AddParagraph(_nonSupervisoryNumerical)


        _row = _table.AddRow()
        _cell = _row.Cells(0)
        _cell.AddParagraph("Reading Comprehension")
        _cell = _row.Cells(1)
        _cell.Format.Alignment = ParagraphAlignment.Center
        _cell.AddParagraph(_maxNonSupervisoryReading)
        _cell = _row.Cells(2)
        _cell.Format.Alignment = ParagraphAlignment.Center
        _cell.AddParagraph(_nonSupervisoryReading)


        ' Grand totals
        Dim _grandTotalItems As Integer = Integer.Parse(_maxNonSupervisoryNumerical) + Integer.Parse(_maxNonSupervisoryReading) + Integer.Parse(_maxNonSupervisoryVerbal)
        Dim _grandTotalScore As Integer = Integer.Parse(_nonSupervisoryNumerical) + Integer.Parse(_nonSupervisoryReading) + Integer.Parse(_nonSupervisoryVerbal)


        _row = _table.AddRow()
        _cell = _row.Cells(0)
        _cell.Format.Font.Bold = True
        _cell.AddParagraph("Grand Total")
        _cell = _row.Cells(1)
        _cell.Format.Alignment = ParagraphAlignment.Center
        _cell.Format.Font.Bold = True
        _cell.AddParagraph(_grandTotalItems)
        _cell = _row.Cells(2)
        _cell.Format.Font.Bold = True
        _cell.Format.Alignment = ParagraphAlignment.Center
        _cell.AddParagraph(_grandTotalScore)

        Return _table

    End Function

    Public Function CreateTableClerical(_levelDescription As String, _examineeID As String, _setDescription As String) As Table

        ' Get Number of questions. Using LevelDescription, Examinee ID, SetDescription
        Dim _paraTestType As Paragraph = New Paragraph()
        Dim _paraCorrectAnswers As Paragraph = New Paragraph()
        Dim _paraTotalItems As Paragraph = New Paragraph()

        _paraTestType.AddText("Type of Test")
        _paraTestType.Format.Alignment = ParagraphAlignment.Center

        _paraCorrectAnswers.AddText("Correct Answers")
        _paraCorrectAnswers.Format.Alignment = ParagraphAlignment.Center

        _paraTotalItems.AddText("Total Items")
        _paraTotalItems.Format.Alignment = ParagraphAlignment.Center

        ' setDescription is a Variable
        sql.AddParam("@setDescription", _setDescription)
        sql.ExecuteQuery("SELECT tbl_kind.kindID, COUNT(tbl_question.questionID) AS NumberOfQuestions FROM tbl_question
                      INNER JOIN tbl_kind
                              ON tbl_question.kindID = tbl_kind.kindID
                      INNER JOIN tbl_level
                              ON tbl_kind.levelID = tbl_level.levelID
                           WHERE tbl_question.setDescription = @setDescription AND tbl_level.levelDescription = 'Clerical'
                        GROUP BY tbl_kind.kindID")

        ' kindID = 7. Numerical  
        ' kindID = 8. Verbal
        ' kindID = 9. General Information and Current Events
        ' kindID = 10. Clerical Reasoning
        ' kindID = 11. Abstract Reasoning 
        Dim _maxClericalNumerical As String = sql.sqlDataSet.Tables(0).Rows(0).Item("NumberOfQuestions").ToString
        Dim _maxClericalVerbal As String = sql.sqlDataSet.Tables(0).Rows(1).Item("NumberOfQuestions").ToString
        Dim _maxClericalGeneralInfo As String = sql.sqlDataSet.Tables(0).Rows(2).Item("NumberOfQuestions").ToString
        Dim _maxClericalClericalReasoning As String = sql.sqlDataSet.Tables(0).Rows(3).Item("NumberOfQuestions").ToString
        Dim _maxClericalAbstractReasoning As String = sql.sqlDataSet.Tables(0).Rows(4).Item("NumberOfQuestions").ToString

        ' Get Scores. Uses kindID, setDescription, and examineeID
        sql.AddParam("@setDescription", _setDescription)
        sql.AddParam("@examineeID", _examineeID)
        sql.ExecuteQuery("SELECT tbl_kind.kindID, tbl_examinee_score.examineeScore AS ExamineeScore FROM tbl_examinee_score
                      INNER JOIN tbl_kind
                              ON tbl_examinee_score.kindID = tbl_kind.kindID
                           WHERE tbl_examinee_score.setDescription = @setDescription AND tbl_examinee_score.examineeID = @examineeID
                        ORDER BY tbl_kind.kindID ASC")

        Dim _clericalNumerical As String = sql.sqlDataSet.Tables(0).Rows(0).Item("ExamineeScore").ToString
        Dim _clericalVerbal As String = sql.sqlDataSet.Tables(0).Rows(1).Item("ExamineeScore").ToString
        Dim _clericalGeneralInfo As String = sql.sqlDataSet.Tables(0).Rows(2).Item("ExamineeScore").ToString
        Dim _clericalClericalReasoning As String = sql.sqlDataSet.Tables(0).Rows(3).Item("ExamineeScore").ToString
        Dim _clericalAbstractReasoning As String = sql.sqlDataSet.Tables(0).Rows(4).Item("ExamineeScore").ToString

        ' Creating our table
        Dim _table As Table = New Table()
        _table.Borders.Width = 0.75

        Dim _column As Column = New Column()
        Dim _row As Row = New Row()
        Dim _cell As Cell = New Cell()


        _column = _table.AddColumn(Unit.FromInch(3.25))
        _column = _table.AddColumn(Unit.FromInch(1.625))
        _column = _table.AddColumn(Unit.FromInch(1.625))

        ' Headers
        _row = _table.AddRow()
        _row.Shading.Color = Colors.PaleGoldenrod
        _cell = _row.Cells(0)
        _cell.Add(_paraTestType)
        _cell = _row.Cells(1)
        _cell.Add(_paraTotalItems)
        _cell = _row.Cells(2)
        _cell.Add(_paraCorrectAnswers)

        _row = _table.AddRow()
        _cell = _row.Cells(0)
        _cell.AddParagraph("Numerical")
        _cell = _row.Cells(1)
        _cell.Format.Alignment = ParagraphAlignment.Center
        _cell.AddParagraph(_maxClericalNumerical)
        _cell = _row.Cells(2)
        _cell.Format.Alignment = ParagraphAlignment.Center
        _cell.AddParagraph(_clericalNumerical)


        _row = _table.AddRow()
        _cell = _row.Cells(0)
        _cell.AddParagraph("Verbal")
        _cell = _row.Cells(1)
        _cell.Format.Alignment = ParagraphAlignment.Center
        _cell.AddParagraph(_maxClericalVerbal)
        _cell = _row.Cells(2)
        _cell.Format.Alignment = ParagraphAlignment.Center
        _cell.AddParagraph(_clericalVerbal)


        _row = _table.AddRow()
        _cell = _row.Cells(0)
        _cell.AddParagraph("General Information and Current Events")
        _cell = _row.Cells(1)
        _cell.Format.Alignment = ParagraphAlignment.Center
        _cell.AddParagraph(_maxClericalGeneralInfo)
        _cell = _row.Cells(2)
        _cell.Format.Alignment = ParagraphAlignment.Center
        _cell.AddParagraph(_clericalGeneralInfo)

        _row = _table.AddRow()
        _cell = _row.Cells(0)
        _cell.AddParagraph("Clerical Reasoning")
        _cell = _row.Cells(1)
        _cell.Format.Alignment = ParagraphAlignment.Center
        _cell.AddParagraph(_maxClericalClericalReasoning)
        _cell = _row.Cells(2)
        _cell.Format.Alignment = ParagraphAlignment.Center
        _cell.AddParagraph(_clericalClericalReasoning)


        _row = _table.AddRow()
        _cell = _row.Cells(0)
        _cell.AddParagraph("Abstract Reasoning")
        _cell = _row.Cells(1)
        _cell.Format.Alignment = ParagraphAlignment.Center
        _cell.AddParagraph(_maxClericalAbstractReasoning)
        _cell = _row.Cells(2)
        _cell.Format.Alignment = ParagraphAlignment.Center
        _cell.AddParagraph(_clericalAbstractReasoning)


        ' Grand totals
        Dim _grandTotalItems As Integer = Integer.Parse(_maxClericalNumerical) + Integer.Parse(_maxClericalVerbal) + Integer.Parse(_maxClericalGeneralInfo) + Integer.Parse(_maxClericalAbstractReasoning) + Integer.Parse(_maxClericalClericalReasoning)
        Dim _grandTotalScore As Integer = Integer.Parse(_clericalNumerical) + Integer.Parse(_clericalVerbal) + Integer.Parse(_clericalGeneralInfo) + Integer.Parse(_clericalAbstractReasoning) + Integer.Parse(_clericalClericalReasoning)

        _row = _table.AddRow()
        _cell = _row.Cells(0)
        _cell.Format.Font.Bold = True
        _cell.AddParagraph("Grand Total")
        _cell = _row.Cells(1)
        _cell.Format.Alignment = ParagraphAlignment.Center
        _cell.Format.Font.Bold = True
        _cell.AddParagraph(_grandTotalItems)
        _cell = _row.Cells(2)
        _cell.Format.Font.Bold = True
        _cell.Format.Alignment = ParagraphAlignment.Center
        _cell.AddParagraph(_grandTotalScore)

        Return _table

    End Function

    Private Sub EditExamineePosition(_levelID As Integer, _positionID As Integer)
        ' Ginawa ko tong function para hindi ichunk ng 3x yung code sa baba

        ' ADDING IF NO INSTANCE OF ACTIVE respective to tbl_examinee_set
        ' If no instance active in tbl_examinee_set THEN ADD Instance
        ' ELSE edit the instance

        sql.AddParam("@examineeID", GetExamineeID())
        sql.AddParam("@levelID", _levelID)
        sql.AddParam("@positionID", _positionID)
        sql.ExecuteQuery("SELECT * FROM tbl_examinee_set WHERE examineeID = @examineeID AND levelID = @levelID")

        If sql.recordCount = 0 Then

            sql.AddParam("@examineeID", GetExamineeID())
            sql.AddParam("@levelID", _levelID)
            sql.AddParam("@positionID", _positionID)
            sql.ExecuteQuery("INSERT INTO tbl_examinee_set (examineeID, setDescription, levelID, positionID) VALUES (@examineeID, 'A', @levelID, @positionID)")

        Else
            sql.AddParam("@examineeID", GetExamineeID())
            sql.AddParam("@positionID", _positionID)
            sql.AddParam("@levelID", _levelID)
            sql.ExecuteQuery("UPDATE tbl_examinee_set
                                 SET positionID = @positionID
                               WHERE examineeID = @examineeID
                                 AND levelID = @levelID")
        End If
    End Sub

    Public Sub LoadExamineeDgv()


        sql.ExecuteQuery("SELECT tbl_examinee.examineeDateID       AS Examinee_ID, 
                                 tbl_examinee.firstName            AS First_Name, 
                                 tbl_examinee.lastName             AS Last_Name,
                                 tbl_examinee.dateTaken            AS Date_Taken
                            FROM tbl_examinee


                        ORDER BY CASE WHEN tbl_examinee.examineeID = LAST_INSERT_ID() THEN 1 Else 2 END, tbl_examinee.examineeID DESC")

        dgvExaminee.DataSource = sql.sqlDataSet.Tables(0)

        lblExamineeCount.Text = sql.recordCount

        dgvExaminee.ClearSelection()
    End Sub

    Private Sub btnExportToExcel_Click(sender As Object, e As EventArgs) Handles btnExportToExcel.Click
        Try
            Dim xlApp As New Microsoft.Office.Interop.Excel.Application
            Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
            Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
            Dim misValue As Object = System.Reflection.Missing.Value

            Dim _excelFile As String

            sfdExcel.Filter = "Excel File|*.xlsx"
            sfdExcel.FileName = "PQE Table Examinee Excel.xlsx"

            If sfdExcel.ShowDialog = DialogResult.OK Then

                xlWorkBook = xlApp.Workbooks.Add(misValue)
                xlWorkSheet = xlWorkBook.Sheets("sheet1")

                xlWorkSheet.Range("A1").ColumnWidth = 15
                xlWorkSheet.Range("B1").ColumnWidth = 20
                xlWorkSheet.Range("C1").ColumnWidth = 20
                xlWorkSheet.Range("D1").ColumnWidth = 16
                xlWorkSheet.Range("E1").ColumnWidth = 30
                xlWorkSheet.Range("F1").ColumnWidth = 10
                xlWorkSheet.Range("G1").ColumnWidth = 12

                _excelFile = sfdExcel.FileName

                LoadExamineeDgv()

                For i As Integer = 0 To dgvExaminee.RowCount - 1
                    For j As Integer = 0 To dgvExaminee.ColumnCount - 1
                        For k As Integer = 1 To dgvExaminee.Columns.Count
                            xlWorkSheet.Cells(1, k) = dgvExaminee.Columns(k - 1).HeaderText
                            xlWorkSheet.Cells(i + 2, j + 1) = dgvExaminee(j, i).Value.ToString()
                        Next
                    Next
                Next

                xlWorkSheet.SaveAs(_excelFile)
                xlWorkBook.Close()
                xlApp.Quit()

                ReleaseObject(xlApp)
                ReleaseObject(xlWorkBook)
                ReleaseObject(xlWorkSheet)

                MessageBox.Show("Exporting to Excel file format successful.")

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ReleaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub btnRefreshExamineeDgv_Click(sender As Object, e As EventArgs) Handles btnRefreshExamineeDgv.Click
        LoadExamineeDgv()
    End Sub

    Private Sub btnPrintExamineeDgv_Click(sender As Object, e As EventArgs) Handles btnPrintExamineeDgv.Click

        ' Create document
        Dim _doc As Document = New Document()
        ' Add sections to document
        Dim _sect As Section = _doc.AddSection()
        _sect.PageSetup.Orientation = Orientation.Landscape

        ' Header Logo
        Dim _logo As Shapes.Image = _sect.Headers.Primary.AddImage("...\...\Resources\rsz_dost.png")
        _logo.LockAspectRatio = True
        _logo.RelativeHorizontal = Shapes.RelativeHorizontal.Margin
        _logo.WrapFormat.Style = Shapes.WrapStyle.Through

        Dim _fontStyle As Style = _doc.Styles("Heading1")
        _fontStyle.Font.Size = 15
        _fontStyle.Font.Bold = True
        _fontStyle.Font.Underline = 1


        Dim _headerText As Paragraph = New Paragraph()
        _headerText.AddSpace(30)
        _headerText.AddFormattedText("Republic of the Philippines" & vbNewLine, TextFormat.Bold)
        _headerText.AddSpace(30)
        _headerText.AddFormattedText("Department of Science and Technology" & vbNewLine, "Heading1")
        _headerText.AddSpace(30)
        _headerText.AddFormattedText("DOST Regional Operations Building, A. Bonifacio Avenue, Bicutan, Taguig, Metro Manila")


        ' Add this at the end so that it doesn't interfere with our image
        _sect.Headers.Primary.Add(_headerText)

        ' Footer 
        Dim _footer As Paragraph = New Paragraph()
        _footer.Format.Alignment = ParagraphAlignment.Right
        _footer.AddText("Page ")
        _footer.AddPageField()
        _footer.AddText(" of ")
        _footer.AddNumPagesField()

        _sect.Footers.Primary.Add(_footer)

        _sect.AddParagraph(vbNewLine & vbNewLine & vbNewLine & vbNewLine)

        Dim _printDate As Paragraph = New Paragraph()
        _printDate.AddText(printDate)
        _printDate.Format.Alignment = ParagraphAlignment.Right
        _sect.Add(_printDate)

        _sect.AddParagraph(vbNewLine & vbNewLine)

        ' Declare table
        Dim _table As Table = New Table()
        _table.Borders.Width = 0.75

        ' First column
        Dim _column As Column = New Column()
        _column = _table.AddColumn(Unit.FromCentimeter(3))
        _column.Format.Alignment = ParagraphAlignment.Center
        ' NOTE BEFORE YOU CAN ADD CELLS, YOU MUST ADD THE COLUMN
        _column = _table.AddColumn(Unit.FromCentimeter(4))
        _column = _table.AddColumn(Unit.FromCentimeter(4))
        _column = _table.AddColumn(Unit.FromCentimeter(4))
        _column = _table.AddColumn(Unit.FromCentimeter(7))
        _column = _table.AddColumn(Unit.FromCentimeter(4))
        Dim _row As Row = New Row()
        ' For table header
        _row = _table.AddRow()
        ' Adds color to the first row
        _row.Shading.Color = Colors.PaleGoldenrod
        Dim _cell As Cell = New Cell()
        _cell = _row.Cells(0)
        _cell.AddParagraph("Examinee ID")
        _cell = _row.Cells(1)
        _cell.AddParagraph("First Name")
        _cell = _row.Cells(2)
        _cell.AddParagraph("Last Name")
        _cell = _row.Cells(3)
        _cell.AddParagraph("Level")
        _cell = _row.Cells(4)
        _cell.AddParagraph("Position")
        _cell = _row.Cells(5)
        _cell.AddParagraph("Result")


        ' Execute query to get data on the appropriate set
        'sql.AddParam("@setDescription", cboExamineeSet.Text)
        sql.ExecuteQuery("SELECT * FROM tbl_examinee
                      INNER JOIN tbl_level
                              ON tbl_examinee.levelID = tbl_level.levelID
                      INNER JOIN tbl_position
                              ON tbl_examinee.positionID = tbl_position.positionID
                      INNER JOIN tbl_examinee_set
                              ON tbl_examinee.examineeID = tbl_examinee_set.examineeID
                           WHERE tbl_examinee_set.setDescription = @setDescription")

        For Each r As DataRow In sql.sqlDataSet.Tables(0).Rows
            _row = _table.AddRow()
            _cell = _row.Cells(0)
            _cell.AddParagraph(r("examineeDateID"))

            _cell = _row.Cells(1)
            _cell.AddParagraph(r("firstName"))

            _cell = _row.Cells(2)
            _cell.AddParagraph(r("lastName"))

            _cell = _row.Cells(3)
            _cell.AddParagraph(r("levelDescription"))

            _cell = _row.Cells(4)
            _cell.AddParagraph(r("positionDescription"))

            If IsDBNull(r("result")) Then
                _cell = _row.Cells(5)
                _cell.AddParagraph("N/A")
            Else
                _cell = _row.Cells(5)
                _cell.AddParagraph(r("result"))
            End If
        Next

        ' You need to add it to the section
        _sect.Add(_table)

        ' Renders the doocument
        Dim _renderer As PdfDocumentRenderer = New PdfDocumentRenderer(True, PdfSharp.Pdf.PdfFontEmbedding.Always)
        _renderer.Document = _doc
        _renderer.RenderDocument()

        ' Save document
        Dim filename As String = "Examinee.pdf"
        _renderer.PdfDocument.Save(filename)
        ' Start view
        Process.Start(filename)
    End Sub



    ' Used for Filters
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ' Used for filtering
        Dim _stringBuilder As New StringBuilder

        ' Main flow is to add clauses(filters) in WHERE clause if parameters are checked
        ' Add extra space after every clause for safety

        ' Main SELECT Query
        'sql.AddParam("@setDescription", cboExamineeSet.Text)

        _stringBuilder.Append("SELECT DISTINCT tbl_examinee.examineeDateID  AS Examinee_ID, 
                                 tbl_examinee.firstName            AS First_Name, 
                                 tbl_examinee.lastName             AS Last_Name,
                                 tbl_examinee.dateTaken            AS Date_Taken
                            FROM tbl_examinee

                      LEFT JOIN tbl_examinee_set
                              ON tbl_examinee_set.examineeID = tbl_examinee.examineeID

                           WHERE 1 ")

        ' Examinee ID Filter
        If txtExamineeIDFilter.Text <> Nothing Then
            sql.AddParam("@examineeIDFilter", txtExamineeIDFilter.Text)
            _stringBuilder.Append("AND tbl_examinee.examineeID LIKE CONCAT('%',@examineeIDFilter,'%') ")
        End If


        ' Name Filter
        If txtFirstNameFilter.Text <> Nothing Then
            sql.AddParam("@firstNameFilter", txtFirstNameFilter.Text)
            _stringBuilder.Append("AND tbl_examinee.firstName LIKE CONCAT('%',@firstNameFilter,'%') ")
        End If

        If txtLastNameFilter.Text <> Nothing Then
            sql.AddParam("@lastNameFilter", txtLastNameFilter.Text)
            _stringBuilder.Append("AND tbl_examinee.lastName LIKE CONCAT('%',@lastNameFilter,'%') ")
        End If



        ' Passed/Failed Filters
        If rbPassedFilter.Checked Then
            _stringBuilder.Append("AND tbl_examinee_set.result = 'Passed' ")
        End If

        If rbFailedFilter.Checked Then
            _stringBuilder.Append("AND tbl_examinee_set.result = 'Failed' ")
        End If

        If rbNoResultFilter.Checked Then
            _stringBuilder.Append("AND tbl_examinee_set.result IS NULL ")
            ' do nothing because passed or failed are already included in current query
        End If


        ' Position Title Filters
        If cboPositionFilter.SelectedIndex <> -1 Then
            sql.AddParam("@positionDescription", cboPositionFilter.Text)
            sql.ExecuteQuery("SELECT positionID FROM tbl_position WHERE positionDescription = @positionDescription ")

            sql.AddParam("@positionFilter", Integer.Parse(sql.sqlDataSet.Tables(0).Rows(0).Item("positionID")))
            _stringBuilder.Append("AND tbl_examinee_set.positionID = @positionFilter ")
        End If


        ' Date Filter
        If chkDateFilter.Checked Then

            sql.AddParam("@fromDateFilter", dtpFromFilter.Value.ToString("yyyy-MM-dd"))
            sql.AddParam("@toDateFilter", dtpToFilter.Value.ToString("yyyy-MM-dd"))

            _stringBuilder.Append("AND tbl_examinee.dateTaken BETWEEN @fromDateFilter AND @toDateFilter ")

        End If


        _stringBuilder.Append("ORDER BY CASE WHEN tbl_examinee.examineeID = LAST_INSERT_ID() THEN 1 Else 2 END, tbl_examinee.examineeID DESC")

        sql.ExecuteQuery(_stringBuilder.ToString())
        dgvExaminee.DataSource = sql.sqlDataSet.Tables(0)
        dgvExaminee.ClearSelection()
    End Sub

    Private Sub btnClearFilter_Click(sender As Object, e As EventArgs) Handles btnClearFilter.Click

        txtExamineeIDFilter.Text = ""
        txtFirstNameFilter.Text = ""
        txtLastNameFilter.Text = ""
        cboPositionFilter.SelectedIndex = -1

        rbPassedFilter.Checked = False
        rbFailedFilter.Checked = False
        rbNoResultFilter.Checked = False

        chkDateFilter.Checked = False
        dtpFromFilter.Enabled = False
        dtpToFilter.Enabled = False


        LoadExamineeDgv()
    End Sub

    Private Sub chkDateFilter_CheckedChanged(sender As Object, e As EventArgs) Handles chkDateFilter.CheckedChanged
        If chkDateFilter.Checked Then
            dtpFromFilter.Enabled = True
            dtpToFilter.Enabled = True
        Else
            dtpFromFilter.Enabled = False
            dtpToFilter.Enabled = False
        End If
    End Sub

    Private Sub btnBackLogin_Click(sender As Object, e As EventArgs) Handles btnBackLogin.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub btnUserManual_Click(sender As Object, e As EventArgs) Handles btnUserManual.Click
        Dim _doc As Document = New Document()
        Dim _sect As Section = _doc.AddSection()
        _sect.PageSetup.PageFormat = PageFormat.A4
        _sect.PageSetup.Orientation = Orientation.Portrait

        'Logo Code source: Image to left of text. Code by the wonderful Thomas Hoevel
        'Also view Invoice Example for Migradoc. Really useful
        Dim _logo As Shapes.Image = _sect.Headers.Primary.AddImage(My.Application.Info.DirectoryPath & "\..\..\Resources\rsz_dost.png")
        _logo.LockAspectRatio = True
        _logo.RelativeHorizontal = Shapes.RelativeHorizontal.Margin
        _logo.WrapFormat.Style = Shapes.WrapStyle.None


        Dim _fontStyle As Style = _doc.Styles("Heading1")
        _fontStyle.Font.Size = 15
        _fontStyle.Font.Bold = True
        _fontStyle.Font.Underline = 1


        _fontStyle = _doc.Styles("Heading2")
        _fontStyle.Font.Size = 9
        _fontStyle.Font.Bold = False
        _fontStyle.Font.Underline = 0

        Dim _headerText As Paragraph = New Paragraph()
        _headerText.AddSpace(30)
        _headerText.AddFormattedText("Republic of the Philippines" & vbNewLine, TextFormat.Bold)
        _headerText.AddSpace(30)
        _headerText.AddFormattedText("Department of Science and Technology" & vbNewLine, "Heading1")
        _headerText.AddSpace(30)
        _headerText.AddFormattedText("DOST Regional Operations Building, A. Bonifacio Avenue, Bicutan, Taguig, Metro Manila", "Heading2")

        'Add this at the end so that it doesn't interfere with our image
        _sect.Headers.Primary.Add(_headerText)

        Dim _footer As Paragraph = New Paragraph()
        _footer.Format.Alignment = ParagraphAlignment.Right
        _footer.AddText("Page ")
        _footer.AddPageField()
        _footer.AddText(" of ")
        _footer.AddNumPagesField()

        _sect.Footers.Primary.Add(_footer)

        Dim _paraTitle As Paragraph = New Paragraph()

        _paraTitle.AddFormattedText("User Manual for Pre-Qualification Examination", TextFormat.Bold)
        _paraTitle.Format.Alignment = ParagraphAlignment.Center


        _sect.AddParagraph(vbNewLine & vbNewLine & vbNewLine & vbNewLine)

        _sect.Add(_paraTitle)

        'Spaces needed
        _sect.AddParagraph(vbNewLine & vbNewLine & vbNewLine & vbNewLine)

        Dim _paraAdministrator As Paragraph = New Paragraph()
        _paraAdministrator.AddFormattedText("Administrator Side and Temporary Administrator Side", TextFormat.Bold)
        _paraAdministrator.Format.Alignment = ParagraphAlignment.Left
        _sect.Add(_paraAdministrator)

        _sect.AddParagraph("Step 1. As you open the login module the Admin must enter the required fields in order to manage all the questions and supervise the examinees who are going to take the exam." & vbNewLine & vbNewLine)
        _sect.AddParagraph("Step 2. After logging in, the program will be redirected to the Admin dashboard which contains tabs for Examinee, Exams and Configuration." & vbNewLine & vbNewLine)
        _sect.AddParagraph("Step 3. The Admin must first insert the Examinee credentials like first name and last name. The admin must also choose a level and position." & vbNewLine & vbNewLine)
        _sect.AddParagraph("Step 4. After registering the Examinee, the Admin can allow the Examinee to take a picture." & vbNewLine & vbNewLine)
        _sect.AddParagraph("Step 5. Then the Admin can go to the Exams tab to insert a variety of questions for the examinee. The Admin can categorize the question to a specific level and to a specific exam type." & vbNewLine & vbNewLine)
        _sect.AddParagraph("Step 6. Next to the Exams tab is the Configuration tab wherein the Admin can configure the time for each level of exam, backup and restore database, and lastly " & vbNewLine & vbNewLine)

        _sect.AddParagraph(vbNewLine & vbNewLine)

        Dim _paraExaminee As Paragraph = New Paragraph()
        _paraExaminee.AddFormattedText("Examinee Side", TextFormat.Bold)
        _paraExaminee.Format.Alignment = ParagraphAlignment.Left
        _sect.Add(_paraExaminee)

        _sect.AddParagraph("Step 1. As you open the login module the Examinee must enter the required fields in order to take the exam prepared by the Admin. (The Examinee must ask for their ID from the Admin)" & vbNewLine & vbNewLine)
        _sect.AddParagraph("Step 2. In the Examinee dashboard, the Examinee can select what type of exam he can take first then continue onto the exam." & vbNewLine & vbNewLine)
        _sect.AddParagraph("Step 3. In the Examination module, the Examinee will take the exam with the given time limit. If the Examinee can’t finish the exam within the given time, the exam will automatically stop." & vbNewLine & vbNewLine)
        _sect.AddParagraph("Step 4. After the exam is over, the program will compute for the grade of the examinee and the result will be notified to the Administrator" & vbNewLine & vbNewLine)
        _sect.AddParagraph("Step 5. The Examinee then must consult the Administrator." & vbNewLine & vbNewLine)




        'Renders the doocument
        Dim _renderer As PdfDocumentRenderer = New PdfDocumentRenderer(True, PdfSharp.Pdf.PdfFontEmbedding.Always)
        _renderer.Document = _doc
        _renderer.RenderDocument()

        'Save document
        Dim filename As String = "UserManual.pdf"
        _renderer.PdfDocument.Save(filename)
        'Start view
        Process.Start(filename)
    End Sub

    Private Sub dgvExaminee_MouseDown(sender As Object, e As MouseEventArgs) Handles dgvExaminee.MouseDown
        Dim _ht = dgvExaminee.HitTest(e.Location.X, e.Location.Y)

        ' Check if there is data on row clicked or data is column header
        If _ht.Type = DataGridViewHitTestType.None Or _ht.Type = DataGridViewHitTestType.ColumnHeader Then
            Exit Sub
        End If


        btnChangePicture.Visible = True

        ' Gets of row clicked
        rowClicked = dgvExaminee.HitTest(e.Location.X, e.Location.Y).RowIndex
        ' Clears highlight
        dgvExaminee.ClearSelection()
        ' Highlights rowClicked row
        dgvExaminee.Rows(rowClicked).Selected = True


        ' BALI ISESEPARATE MO YUNG QUERIES FOR SUPERVISORY, NON-SUPER, CLERICAL
        ' ANG GAGAMITIN MONG KEY NILA AY examineeID
        lblExamineeDateID.Text = dgvExaminee.SelectedRows(0).Cells("Examinee_ID").Value.ToString()
        txtFirstName.Text = dgvExaminee.SelectedRows(0).Cells("First_Name").Value.ToString()
        txtLastName.Text = dgvExaminee.SelectedRows(0).Cells("Last_Name").Value.ToString()

        ViewLevelStatus()

        btnExamineeEdit.Visible = True
        btnExamineeRegister.Visible = False

        ' Gets the image and pass to picturebox
        sql.AddParam("@examineeDateID", lblExamineeDateID.Text)
        sql.ExecuteQuery("SELECT examineePic FROM tbl_examinee WHERE examineeDateID = @examineeDateID")

        If IsDBNull(sql.sqlDataSet.Tables(0).Rows(0).Item("examineePic")) Then
            ' Set to false if there is no picture
            hasPicture = False
            picExaminee.Visible = True
            picExaminee.Image = PQE.My.Resources.NoExamineePic
        Else
            ' Set to true if there is picture
            picExaminee.Visible = True
            hasPicture = True

            Dim _examineePicByte() As Byte = sql.sqlDataSet.Tables(0).Rows(0).Item("examineePic")

            Using _examineePicStream As New System.IO.MemoryStream(_examineePicByte)
                picExaminee.Image = Image.FromStream(_examineePicStream)
                picExaminee.SizeMode = PictureBoxSizeMode.StretchImage
                _examineePicStream.Close()
            End Using

            Dim _saveLocation As String = My.Computer.FileSystem.SpecialDirectories.MyPictures
            Dim _imageOutput As String = Combine(_saveLocation, "Image.jpg")

            SaveImageCopy(_imageOutput)

        End If

        ' Get email Address
        sql.AddParam("@examineeDateID", lblExamineeDateID.Text)
        sql.ExecuteQuery("SELECT emailAddress FROM tbl_examinee WHERE examineeDateID = @examineeDateID")

        If Not IsDBNull(sql.sqlDataSet.Tables(0).Rows(0).Item("emailAddress")) Then
            txtEmailAddress.Text = sql.sqlDataSet.Tables(0).Rows(0).Item("emailAddress")
        End If


        'Used for dat gr33n colors
        txtFirstName.NameCheck(txtFirstName.Text)
        txtLastName.NameCheck(txtFirstName.Text)
        txtEmailAddress.EmailAddressCheck(txtEmailAddress.Text, lblExamineeDateID.Text)


    End Sub

    Private Sub SaveImageCopy(filePath As String)

        Try
            ' We scale the image by using the function ScaleImage
            Using bmp As New Bitmap(ScaleImage(picExaminee.Image, 100, 100))
                bmp.Save(filePath, Drawing.Imaging.ImageFormat.Jpeg)
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Function ScaleImage(ByVal OldImage As Image, ByVal TargetHeight As Integer, ByVal TargetWidth As Integer) As System.Drawing.Image

        'Dim NewHeight As Integer = TargetHeight
        'Dim NewWidth As Integer = NewHeight / OldImage.Height * OldImage.Width

        Dim NewWidth As Integer = TargetWidth
        Dim NewHeight As Integer = TargetHeight

        'If NewWidth > TargetWidth Then
        ' NewWidth = TargetWidth
        ' NewHeight = NewWidth / OldImage.Width * OldImage.Height
        'End If

        Return New Bitmap(OldImage, NewWidth, NewHeight)

    End Function


    Private Sub ViewLevelStatus()

        ' to get active level
        Dim _activeLevel As Integer

        ' -- SELECT for SUPERVISORY
        sql.AddParam("@examineeDateID", lblExamineeDateID.Text)
        sql.ExecuteQuery("SELECT * FROM tbl_examinee

                               INNER JOIN tbl_examinee_set
                                       ON tbl_examinee.examineeID = tbl_examinee_set.examineeID

                               INNER JOIN tbl_position
                                       ON tbl_examinee_set.positionID = tbl_position.positionID

                                INNER JOIN tbl_level
                                       ON tbl_examinee_set.levelID = tbl_level.levelID
                                
                                WHERE tbl_examinee.examineeDateID = @examineeDateID
                                  AND tbl_examinee_set.levelID = '1'
                                  ORDER BY setDescription")

        ' If merong record then dapat may position title 
        If sql.recordCount Then

            cboSupervisoryPosition.Text = sql.sqlDataSet.Tables(0).Rows(0).Item("positionDescription")

            ' If may resulta na ba, maski-isa? 
            If Not IsDBNull(sql.sqlDataSet.Tables(0).Rows(0).Item("result")) Then
                ' then disable Position editing
                cboSupervisoryPosition.Enabled = False

                If sql.recordCount = 1 Then
                    ' If 1 result, then Set A natake, thus 1 result
                    txtSupervisoryResultA.Text = sql.sqlDataSet.Tables(0).Rows(0).Item("result")
                    txtSupervisoryResultB.Text = "N/A"
                    txtSupervisoryResultC.Text = "N/A"
                ElseIf sql.recordCount = 2 Then
                    ' If 2 result, then Set A, B natake, thus 2 result
                    txtSupervisoryResultA.Text = sql.sqlDataSet.Tables(0).Rows(0).Item("result")
                    txtSupervisoryResultB.Text = sql.sqlDataSet.Tables(0).Rows(1).Item("result")
                    txtSupervisoryResultC.Text = "N/A"
                ElseIf sql.recordCount = 3 Then
                    ' If 3 result, then Set A, B, Cnatake, thus 3 result
                    txtSupervisoryResultA.Text = sql.sqlDataSet.Tables(0).Rows(0).Item("result")
                    txtSupervisoryResultB.Text = sql.sqlDataSet.Tables(0).Rows(1).Item("result")
                    txtSupervisoryResultC.Text = sql.sqlDataSet.Tables(0).Rows(2).Item("result")
                End If
            Else
                cboSupervisoryPosition.Enabled = True
                txtSupervisoryResultA.Text = "N/A"
                txtSupervisoryResultB.Text = "N/A"
                txtSupervisoryResultC.Text = "N/A"
            End If

        Else
            cboSupervisoryPosition.SelectedIndex = -1
            cboSupervisoryPosition.Enabled = True
            txtSupervisoryResultA.Text = "N/A"
            txtSupervisoryResultB.Text = "N/A"
            txtSupervisoryResultC.Text = "N/A"
        End If


        '!-- SELECT for SUPERVISORY

        ' -- SELECT for NON SUPERVISORY
        sql.AddParam("@examineeDateID", lblExamineeDateID.Text)
        sql.ExecuteQuery("SELECT * FROM tbl_examinee

                               INNER JOIN tbl_examinee_set
                                       ON tbl_examinee.examineeID = tbl_examinee_set.examineeID

                               INNER JOIN tbl_position
                                       ON tbl_examinee_set.positionID = tbl_position.positionID

                                INNER JOIN tbl_level
                                       ON tbl_examinee_set.levelID = tbl_level.levelID
                                
                                WHERE tbl_examinee.examineeDateID = @examineeDateID
                                  AND tbl_examinee_set.levelID = '2'
                                  ORDER BY setDescription")

        ' If merong record then dapat may position title 
        If sql.recordCount Then

            cboNonSupervisoryPosition.Text = sql.sqlDataSet.Tables(0).Rows(0).Item("positionDescription")

            ' If may resulta na ba, maski-isa? then disable Position editing
            If Not IsDBNull(sql.sqlDataSet.Tables(0).Rows(0).Item("result")) Then

                cboNonSupervisoryPosition.Enabled = False

                If sql.recordCount = 1 Then
                    ' If 1 result, then Set A natake, thus 1 result
                    txtNonSupervisoryResultA.Text = sql.sqlDataSet.Tables(0).Rows(0).Item("result")
                    txtNonSupervisoryResultB.Text = "N/A"
                    txtNonSupervisoryResultC.Text = "N/A"
                ElseIf sql.recordCount = 2 Then
                    ' If 2 result, then Set A, B natake, thus 2 result
                    txtNonSupervisoryResultA.Text = sql.sqlDataSet.Tables(0).Rows(0).Item("result")
                    txtNonSupervisoryResultB.Text = sql.sqlDataSet.Tables(0).Rows(1).Item("result")
                    txtNonSupervisoryResultC.Text = "N/A"
                ElseIf sql.recordCount = 3 Then
                    ' If 3 result, then Set A, B, Cnatake, thus 3 result
                    txtNonSupervisoryResultA.Text = sql.sqlDataSet.Tables(0).Rows(0).Item("result")
                    txtNonSupervisoryResultB.Text = sql.sqlDataSet.Tables(0).Rows(1).Item("result")
                    txtNonSupervisoryResultC.Text = sql.sqlDataSet.Tables(0).Rows(2).Item("result")
                End If
            Else
                cboNonSupervisoryPosition.Enabled = True
                txtNonSupervisoryResultA.Text = "N/A"
                txtNonSupervisoryResultB.Text = "N/A"
                txtNonSupervisoryResultC.Text = "N/A"
            End If
        Else
            cboNonSupervisoryPosition.SelectedIndex = -1
            cboNonSupervisoryPosition.Enabled = True
            txtNonSupervisoryResultA.Text = "N/A"
            txtNonSupervisoryResultB.Text = "N/A"
            txtNonSupervisoryResultC.Text = "N/A"
        End If

        '!-- SELECT for NON SUPERVISORY

        ' -- SELECT for CLERICAL
        sql.AddParam("@examineeDateID", lblExamineeDateID.Text)
        sql.ExecuteQuery("SELECT * FROM tbl_examinee

                               INNER JOIN tbl_examinee_set
                                       ON tbl_examinee.examineeID = tbl_examinee_set.examineeID

                               INNER JOIN tbl_position
                                       ON tbl_examinee_set.positionID = tbl_position.positionID

                                INNER JOIN tbl_level
                                       ON tbl_examinee_set.levelID = tbl_level.levelID
                                
                                WHERE tbl_examinee.examineeDateID = @examineeDateID
                                  AND tbl_examinee_set.levelID = '3'
                                  ORDER BY setDescription")

        ' If merong record then dapat may position title 
        If sql.recordCount Then

            cboClericalPosition.Text = sql.sqlDataSet.Tables(0).Rows(0).Item("positionDescription")

            ' If may resulta na ba, maski-isa? then disable Position editing
            If Not IsDBNull(sql.sqlDataSet.Tables(0).Rows(0).Item("result")) Then

                cboClericalPosition.Enabled = False
                If sql.recordCount = 1 Then
                    ' If 1 result, then Set A natake, thus 1 result
                    txtClericalResultA.Text = sql.sqlDataSet.Tables(0).Rows(0).Item("result")
                    txtClericalResultB.Text = "N/A"
                    txtClericalResultC.Text = "N/A"
                ElseIf sql.recordCount = 2 Then
                    ' If 2 result, then Set A, B natake, thus 2 result
                    txtClericalResultA.Text = sql.sqlDataSet.Tables(0).Rows(0).Item("result")
                    txtClericalResultB.Text = sql.sqlDataSet.Tables(0).Rows(1).Item("result")
                    txtClericalResultC.Text = "N/A"
                ElseIf sql.recordCount = 3 Then
                    ' If 3 result, then Set A, B, Cnatake, thus 3 result
                    txtClericalResultA.Text = sql.sqlDataSet.Tables(0).Rows(0).Item("result")
                    txtClericalResultB.Text = sql.sqlDataSet.Tables(0).Rows(1).Item("result")
                    txtClericalResultC.Text = sql.sqlDataSet.Tables(0).Rows(2).Item("result")
                End If
            Else
                cboClericalPosition.Enabled = True
                txtClericalResultA.Text = "N/A"
                txtClericalResultB.Text = "N/A"
                txtClericalResultC.Text = "N/A"
            End If
        Else
            cboClericalPosition.SelectedIndex = -1
            cboClericalPosition.Enabled = True
            txtClericalResultA.Text = "N/A"
            txtClericalResultB.Text = "N/A"
            txtClericalResultC.Text = "N/A"
        End If

        '!-- SELECT for CLERICAL

        ' Checks what is active for the selected Examinee
        sql.AddParam("@examineeDateID", lblExamineeDateID.Text)
        sql.ExecuteQuery("SELECT * FROM tbl_examinee WHERE examineeDateID = @examineeDateID")
        _activeLevel = sql.sqlDataSet.Tables(0).Rows(0).Item("activeLevel")

        If _activeLevel = 1 Then
            rbSupervisoryActive.Checked = True
        ElseIf _activeLevel = 2 Then
            rbNonSupervisoryActive.Checked = True
        ElseIf _activeLevel = 3 Then
            rbClericalActive.Checked = True
        End If

    End Sub

    Private Sub LoadExamineePosition()
        ' Comboboxes clear
        cboSupervisoryPosition.Items.Clear()
        cboNonSupervisoryPosition.Items.Clear()
        cboClericalPosition.Items.Clear()

        sql.ExecuteQuery("SELECT * FROM tbl_position ORDER BY positionDescription ASC")

        ' FILLING OF CBs
        If sql.recordCount > 0 Then
            For Each r As DataRow In sql.sqlDataSet.Tables(0).Rows
                cboSupervisoryPosition.Items.Add(r("positionDescription"))
                cboNonSupervisoryPosition.Items.Add(r("positionDescription"))
                cboClericalPosition.Items.Add(r("positionDescription"))
                cboPositionFilter.Items.Add(r("positionDescription"))
            Next
        Else
            cboSupervisoryPosition.Items.Add("No positions yet.")
            cboNonSupervisoryPosition.Items.Add("No positions yet.")
            cboClericalPosition.Items.Add("No positions yet.")
            cboPositionFilter.Items.Add("No positions yet.")
        End If

    End Sub

    Private Sub txtEmailAddress_Leave(sender As Object, e As EventArgs) Handles txtEmailAddress.Leave

    End Sub

    Private Sub txtLastName_Leave(sender As Object, e As EventArgs) Handles txtLastName.Leave

    End Sub

    Private Sub txtFirstName_Leave(sender As Object, e As EventArgs) Handles txtFirstName.Leave

    End Sub
End Class