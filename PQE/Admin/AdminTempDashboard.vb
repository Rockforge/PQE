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

    ' For date
    Dim currentDate As String = Date.Now.ToString("yyyy-MM-dd")
    Dim newID As String
    Dim printDate As String

    ' For Examinee Tab
    Dim isEditable As Boolean = False



    ' For rowClicking
    Dim rowClicked As Integer
    Dim hasPicture As Boolean = False

    Dim sql As New SQLControl

    Private Sub AdminTempDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim _skinManager As MaterialSkinManager = MaterialSkinManager.Instance
        _skinManager.AddFormToManage(Me)
        _skinManager.Theme = MaterialSkinManager.Themes.LIGHT
        _skinManager.ColorScheme = New ColorScheme(Primary.Blue600, Primary.Blue700, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)

        LoadExamineeSet()
        LoadExamineeDgv()
        LoadExamineePosition()
        LoadExamineeLevel()
    End Sub

    Private Sub cboExamineeSet_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboExamineeSet.SelectedIndexChanged
        LoadExamineeDgv()
    End Sub

    Public Sub LoadExamineeSet()
        cboExamineeSet.Items.Add("A")
        cboExamineeSet.Items.Add("B")
        cboExamineeSet.Items.Add("C")

        cboExamineeSet.SelectedIndex = 0
    End Sub

    Public Sub LoadExamineeDgv()
        sql.AddParam("@setDescription", cboExamineeSet.Text)

        sql.ExecuteQuery("SELECT tbl_examinee.examineeDateID        AS Examinee_ID, 
                                 tbl_examinee.firstName             AS First_Name, 
                                 tbl_examinee.lastName              AS Last_Name,
                                 tbl_level.levelDescription         AS Level,
                                 tbl_position.positionDescription   AS Position,
                                 tbl_examinee.dateTaken             AS Date_Taken
                            FROM tbl_examinee
   
                      INNER JOIN tbl_position
                              ON tbl_examinee.positionID = tbl_position.positionID
                      INNER JOIN tbl_level
                              ON tbl_examinee.levelID = tbl_level.levelID
                      INNER JOIN tbl_examinee_set
                              ON tbl_examinee.examineeID = tbl_examinee_set.examineeID

                           WHERE tbl_examinee_set.setDescription = @setDescription

                        ORDER BY CASE WHEN tbl_examinee.examineeID = LAST_INSERT_ID() THEN 1 Else 2 END, tbl_examinee.examineeID DESC")

        dgvExaminee.DataSource = sql.sqlDataSet.Tables(0)

        lblExamineeCount.Text = sql.recordCount
    End Sub

    Private Sub LoadExamineeLevel()
        ' Comboboxes clear
        cboExamineeLevel.Items.Clear()

        sql.ExecuteQuery("SELECT * FROM tbl_level")

        ' FILLING OF CBs
        If sql.recordCount > 0 Then
            For Each r As DataRow In sql.sqlDataSet.Tables(0).Rows
                cboExamineeLevel.Items.Add(r("levelDescription"))
            Next
        Else
            cboExamineeLevel.Items.Add("No levels yet.")
        End If
    End Sub

    Private Sub LoadExamineePosition()
        ' Comboboxes clear
        cboExamineePosition.Items.Clear()

        sql.ExecuteQuery("SELECT * FROM tbl_position")

        ' FILLING OF CBs
        If sql.recordCount > 0 Then
            For Each r As DataRow In sql.sqlDataSet.Tables(0).Rows
                cboExamineePosition.Items.Add(r("positionDescription"))
            Next
        Else
            cboExamineePosition.Items.Add("No positions yet.")
        End If
    End Sub

    Private Sub dgvExaminee_MouseDown(sender As Object, e As MouseEventArgs) Handles dgvExaminee.MouseDown
        Dim _ht = dgvExaminee.HitTest(e.Location.X, e.Location.Y)

        ' Check if there is data on row clicked or data is column header
        If _ht.Type = DataGridViewHitTestType.None Or _ht.Type = DataGridViewHitTestType.ColumnHeader Then
            Exit Sub
        End If

        If e.Button = MouseButtons.Left Then

            ' Gets of row clicked
            rowClicked = dgvExaminee.HitTest(e.Location.X, e.Location.Y).RowIndex
            ' Clears highlight
            dgvExaminee.ClearSelection()
            ' Highlights rowClicked row
            dgvExaminee.Rows(rowClicked).Selected = True

            Dim _examineeID As String = dgvExaminee.SelectedRows(0).Cells("Examinee_ID").Value.ToString()
            Dim _firstName As String = dgvExaminee.SelectedRows(0).Cells("First_Name").Value.ToString()
            Dim _lastName As String = dgvExaminee.SelectedRows(0).Cells("Last_Name").Value.ToString()
            Dim _level As String = dgvExaminee.SelectedRows(0).Cells("Level").Value.ToString()
            Dim _jobTitle As String = dgvExaminee.SelectedRows(0).Cells("Position").Value.ToString()

            lblExamineeID.Text = _examineeID
            txtFirstName.Text = _firstName
            txtLastName.Text = _lastName
            cboExamineePosition.Text = _jobTitle
            cboExamineeLevel.Text = _level

            btnExamineeEdit.Visible = True
            btnExamineeRegister.Visible = False

            ' Gets the image and pass to picturebox
            sql.AddParam("@examineeDateID", lblExamineeID.Text)
            sql.ExecuteQuery("SELECT examineePic FROM tbl_examinee WHERE examineeDateID = @examineeDateID")

            If IsDBNull(sql.sqlDataSet.Tables(0).Rows(0).Item("examineePic")) Then
                ' Set to false if there is no picture
                hasPicture = False
                picExaminee.Visible = False
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

        ElseIf e.Button = MouseButtons.Right Then
            ' Gets of row clicked
            rowClicked = dgvExaminee.HitTest(e.Location.X, e.Location.Y).RowIndex
            ' Clears highlight
            dgvExaminee.ClearSelection()
            ' Highlights rowClicked row
            dgvExaminee.Rows(rowClicked).Selected = True
            ' Get ID
            Dim _examineeDateID = dgvExaminee.Rows(rowClicked).Cells("Examinee_ID").Value.ToString
            ' Passes to the text field
            lblExamineeID.Text = _examineeDateID


            ' Gets the image and pass to picturebox
            sql.AddParam("@examineeDateID", lblExamineeID.Text)
            sql.ExecuteQuery("SELECT examineePic FROM tbl_examinee WHERE examineeDateID = @examineeDateID")

            If IsDBNull(sql.sqlDataSet.Tables(0).Rows(0).Item("examineePic")) Then

                ' Set to false if there is no picture
                hasPicture = False
                picExaminee.Visible = False

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

        End If
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

    ' Code source: Simple Proper Image Scaling in Correct Aspect Ratio by the awesome stepdragon. This function resizes by Pixels
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

    Private Sub btnExamineeRegister_Click(sender As Object, e As EventArgs) Handles btnExamineeRegister.Click

        ' Error catching
        If txtFirstName.Text = "" Or txtLastName.Text = "" Or cboExamineePosition.SelectedIndex = -1 Or cboExamineeLevel.SelectedIndex = -1 Then
            picExamineeError.Visible = True
            lblExamineeError.Text = "Incorrect Details"
            lblExamineeError.Visible = True
            Exit Sub
        End If

        ' newID build
        newID = currentDate

        ' Get ID of position
        Dim _positionID As Integer

        sql.AddParam("@positionSelected", cboExamineePosition.Text)
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



        ' Get ID of levels
        Dim _levelID As Integer

        sql.AddParam("@levelSelected", cboExamineeLevel.Text)
        sql.ExecuteQuery("SELECT * FROM tbl_level WHERE levelDescription = @levelSelected")
        If sql.recordCount > 0 Then
            For Each r As DataRow In sql.sqlDataSet.Tables(0).Rows
                _levelID = Convert.ToInt64((r("levelID")))
            Next
        Else
            picExamineeError.Visible = True
            lblExamineeError.Text = "No Level selected yet!"
            lblExamineeError.Visible = True
        End If

        ' INSERTION OF EXAMINEE
        sql.AddParam("@firstName", txtFirstName.Text)
        sql.AddParam("@lastName", txtLastName.Text)
        sql.AddParam("@newID", newID)
        ' FK here
        sql.AddParam("@levelID", _levelID)
        sql.AddParam("@positionID", _positionID)
        sql.ExecuteQuery("INSERT INTO tbl_examinee (firstName, lastName, dateTaken, levelID, positionID) VALUES (@firstName, @lastName, @newID, @levelID, @positionID)")

        ' PUT newID to LAST INSERTED ROW
        sql.AddParam("@newID", newID)
        sql.ExecuteQuery("UPDATE tbl_examinee
                           SET examineeDateID = CONCAT(@newID, '-', LAST_INSERT_ID())
                         WHERE examineeID = LAST_INSERT_ID() ")

        txtFirstName.Text = ""
        txtLastName.Text = ""
        lblExamineeID.Text = ""
        cboExamineeLevel.SelectedIndex = -1
        cboExamineePosition.SelectedIndex = -1

        LoadExamineeDgv()

        lblExamineeError.Visible = False
        picExamineeError.Visible = False
    End Sub

    Private Sub btnExamineeEdit_Click(sender As Object, e As EventArgs) Handles btnExamineeEdit.Click

        ' Checks to see if there is no data inside text fields 
        If lblExamineeID.Text = "" Or txtFirstName.Text = "" Or txtLastName.Text = "" Then
            lblExamineeError.Text = "Please select a record below first!"
            lblExamineeError.Visible = True
            picExamineeError.Visible = True
            Exit Sub
        End If

        ' Get ID of position
        Dim _positionID As Integer

        sql.AddParam("@positionSelected", cboExamineePosition.Text)
        sql.ExecuteQuery("SELECT * FROM tbl_position WHERE positionDescription = @positionSelected")
        If sql.recordCount > 0 Then
            For Each r As DataRow In sql.sqlDataSet.Tables(0).Rows
                _positionID = Convert.ToInt64((r("positionID")))
            Next
        Else
            lblExamineeError.Text = "No Position selected yet!"
            lblExamineeError.Visible = True
            picExamineeError.Visible = True
        End If



        ' Get ID of levels
        Dim _levelID As Integer

        sql.AddParam("@levelSelected", cboExamineeLevel.Text)
        sql.ExecuteQuery("SELECT * FROM tbl_level WHERE levelDescription = @levelSelected")
        If sql.recordCount > 0 Then
            For Each r As DataRow In sql.sqlDataSet.Tables(0).Rows
                _levelID = Convert.ToInt64((r("levelID")))
            Next
        Else
            lblExamineeError.Text = "No Level selected yet!"
            lblExamineeError.Visible = True
            picExamineeError.Visible = True
        End If



        ' Edit function
        sql.AddParam("@examineeDateID", lblExamineeID.Text)
        sql.AddParam("@newFirstName", txtFirstName.Text)
        sql.AddParam("@newLastName", txtLastName.Text)
        ' Adding foreign keys as parameter
        sql.AddParam("@levelID", _levelID)
        sql.AddParam("@positionID", _positionID)
        sql.ExecuteQuery("UPDATE tbl_examinee
                             SET      firstName = @newFirstName,
                                       lastName = @newLastname,
                                        levelID = @levelID,
                                     positionID = @positionID
                           WHERE examineeDateID = @examineeDateID")
        lblExamineeID.Text = ""
        txtFirstName.Text = ""
        txtLastName.Text = ""
        cboExamineeLevel.Text = ""
        cboExamineePosition.Text = ""

        LoadExamineeDgv()

        ' Hindi ko alam bakit may ganito to
        'LoadJobs()

        lblExamineeError.Visible = False
        picExamineeError.Visible = False

        btnExamineeEdit.Visible = False
        btnExamineeRegister.Visible = True

    End Sub

    Private Sub btnExamineeClear_Click(sender As Object, e As EventArgs) Handles btnExamineeClear.Click
        lblExamineeID.Text = ""
        txtFirstName.Text = ""
        txtLastName.Text = ""
        cboExamineeLevel.SelectedIndex = -1
        cboExamineePosition.SelectedIndex = -1

        btnExamineeEdit.Visible = False
        btnExamineeRegister.Visible = True

        picExamineeError.Visible = False
        lblExamineeError.Visible = False
    End Sub

    Private Sub btnRefreshExamineeDgv_Click(sender As Object, e As EventArgs) Handles btnRefreshExamineeDgv.Click
        LoadExamineeDgv()
    End Sub

    'Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
    '    BackupFunction()
    'End Sub

    'Private Function BackupFunction()

    '    Dim _currDate As String = Date.Now.ToString("MMMM dd, yyyy - HH:mm")
    '    Dim _dbFile As String

    '    Try
    '        sfdBackup.Filter = "SQL Dump File (*.sql)|*.sql|All Files (*.*)|*.*"
    '        sfdBackup.FileName = "PQE Database Backup " + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".sql"

    '        If sfdBackup.ShowDialog = DialogResult.OK Then

    '            sql.AddParam("@currDate", _currDate)
    '            sql.ExecuteQuery("UPDATE tbl_admin
    '                                 SET lastBackup = @currDate
    '                               WHERE adminID = 1
    '                                 AND adminUsername = 'admin'
    '                                 AND adminLevel = 0")


    '            _dbFile = sfdBackup.FileName

    '            Dim backUpProcess As New Process
    '            backUpProcess.StartInfo.FileName = "cmd.exe"
    '            backUpProcess.StartInfo.UseShellExecute = False
    '            backUpProcess.StartInfo.WorkingDirectory = "C:\xampp\mysql\bin\"
    '            backUpProcess.StartInfo.RedirectStandardInput = True
    '            backUpProcess.StartInfo.RedirectStandardOutput = True
    '            backUpProcess.Start()

    '            Dim backUpStream As StreamWriter = backUpProcess.StandardInput
    '            Dim streamReady As StreamReader = backUpProcess.StandardOutput
    '            backUpStream.WriteLine("mysqldump --user=root --password=  -h localhost db_dost > """ + _dbFile + """")

    '            backUpStream.Close()
    '            backUpProcess.WaitForExit()
    '            backUpProcess.Close()

    '            MsgBox("Backup database successful", MsgBoxStyle.Information, "Backup MySql Database")


    '        End If

    '    Catch ex As Exception
    '        MsgBox("Backup database failed", MsgBoxStyle.Information, "Backup MySql Database")
    '    End Try

    '    Return 0
    'End Function

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

    Private Sub btnChangePicture_Click(sender As Object, e As EventArgs) Handles btnChangePicture.Click
        ExamineePicture.lblExamineeDateID.Text = lblExamineeID.Text
        ExamineePicture.Show()
    End Sub


    ' Used for Filters
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ' Used for filtering
        Dim _stringBuilder As New StringBuilder

        ' Main flow is to add clauses(filters) in WHERE clause if parameters are checked
        ' Add extra space after every clause for safety

        ' Main SELECT Query
        sql.AddParam("@setDescription", cboExamineeSet.Text)

        _stringBuilder.Append("SELECT tbl_examinee.examineeDateID  AS Examinee_ID, 
                                 tbl_examinee.firstName            AS First_Name, 
                                 tbl_examinee.lastName             AS Last_Name,
                                 tbl_level.levelDescription        AS Level,
                                 tbl_position.positionDescription  AS Position,
                                 tbl_examinee_set.result           AS Result,
                                 tbl_examinee.dateTaken            AS Date_Taken,
                                 tbl_examinee.examineePic          AS Examinee_Picture
                            FROM tbl_examinee
   
                      INNER JOIN tbl_position
                              ON tbl_examinee.positionID = tbl_position.positionID
                      INNER JOIN tbl_level
                              ON tbl_examinee.levelID = tbl_level.levelID
                      INNER JOIN tbl_examinee_set
                              ON tbl_examinee.examineeID = tbl_examinee_set.examineeID

                           WHERE tbl_examinee_set.setDescription = @setDescription ")


        ' Name Filter
        If txtFirstNameFilter.Text <> Nothing Then
            sql.AddParam("@firstNameFilter", txtFirstNameFilter.Text)
            _stringBuilder.Append("AND tbl_examinee.firstName = @firstNameFilter ")
        End If

        If txtLastNameFilter.Text <> Nothing Then
            sql.AddParam("@lastNameFilter", txtLastNameFilter.Text)
            _stringBuilder.Append("AND tbl_examinee.lastName = @lastNameFilter ")
        End If

        ' Level Title Filters
        If cboLevelFilter.SelectedIndex <> -1 Then
            sql.AddParam("@levelFilter", cboLevelFilter.Text)
            _stringBuilder.Append("AND tbl_level.levelDescription = @levelFilter ")
        End If

        ' Position Title Filters
        If cboPositionFilter.SelectedIndex <> -1 Then
            sql.AddParam("@positionFilter", cboPositionFilter.Text)
            _stringBuilder.Append("AND tbl_position.positionDescription = @positionFilter ")
        End If


        ' Date Filter
        If chkDateFilter.Checked Then

            sql.AddParam("@fromDateFilter", dtpFromFilter.Value.ToString("yyyy-MM-dd"))
            sql.AddParam("@toDateFilter", dtpToFilter.Value.ToString("yyyy-MM-dd"))

            _stringBuilder.Append("AND dateTaken BETWEEN @fromDateFilter AND @toDateFilter ")

        End If


        _stringBuilder.Append("ORDER BY CASE WHEN tbl_examinee.examineeID = LAST_INSERT_ID() THEN 1 Else 2 END, tbl_examinee.examineeID DESC")

        sql.ExecuteQuery(_stringBuilder.ToString())
        dgvExaminee.DataSource = sql.sqlDataSet.Tables(0)
        MessageBox.Show(_stringBuilder.ToString())
    End Sub

    Private Sub btnClearFilter_Click(sender As Object, e As EventArgs) Handles btnClearFilter.Click

        cboLevelFilter.SelectedIndex = -1
        cboPositionFilter.SelectedIndex = -1

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

End Class