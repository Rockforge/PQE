Imports System.Net
Imports System.Net.Mail
Imports System.Net.WebClient
Imports System.IO

Imports MigraDoc.DocumentObjectModel
Imports MigraDoc.Rendering
Imports MigraDoc.DocumentObjectModel.Tables



Public Class Emailing

    ' SMTP Goodness
    Public Shared smtp As SmtpClient
    Public Shared smtpServer As String
    Public Shared smtpPort As Integer
    Public Shared emailAddress As String
    Public Shared emailPassword As String
    Public Shared mailSubject As String
    Public Shared mailMessagePasser As String
    Public Shared mailMessageNonPasser As String

    Dim hasNull As Boolean

    Public sql As New SQLControl

    Public Sub InitializeEmailSettings()

        hasNull = False

        sql.ExecuteQuery("SELECT * FROM tbl_admin WHERE adminLevel = '0'")

        If IsDBNull(sql.sqlDataSet.Tables(0).Rows(0).Item("smtp")) Then
            smtpServer = ""
        Else
            smtpServer = sql.sqlDataSet.Tables(0).Rows(0).Item("smtp").ToString()
        End If

        If IsDBNull(sql.sqlDataSet.Tables(0).Rows(0).Item("smtpPort")) Then
            ' Do nothing
        Else
            smtpPort = Convert.ToInt32(sql.sqlDataSet.Tables(0).Rows(0).Item("smtpPort").ToString())
        End If

        If IsDBNull(sql.sqlDataSet.Tables(0).Rows(0).Item("emailAddress")) Then
            emailAddress = ""
        Else
            emailAddress = sql.sqlDataSet.Tables(0).Rows(0).Item("emailAddress").ToString()
        End If

        If IsDBNull(sql.sqlDataSet.Tables(0).Rows(0).Item("gmailSpecificPassword")) Then
            emailPassword = ""
        Else
            emailPassword = sql.sqlDataSet.Tables(0).Rows(0).Item("gmailSpecificPassword").ToString()
        End If

        If IsDBNull(sql.sqlDataSet.Tables(0).Rows(0).Item("mailSubject")) Then
            mailSubject = ""
        Else
            mailSubject = sql.sqlDataSet.Tables(0).Rows(0).Item("mailSubject").ToString()
        End If

        If IsDBNull(sql.sqlDataSet.Tables(0).Rows(0).Item("mailMessagePasser")) Then
            mailMessagePasser = ""
        Else
            mailMessagePasser = sql.sqlDataSet.Tables(0).Rows(0).Item("mailMessagePasser").ToString()
        End If

        If IsDBNull(sql.sqlDataSet.Tables(0).Rows(0).Item("mailMessageNonPasser")) Then
            mailMessageNonPasser = ""
        Else
            mailMessageNonPasser = sql.sqlDataSet.Tables(0).Rows(0).Item("mailMessageNonPasser").ToString()
        End If

        ' Check if any is null
        If smtpServer = "" Or smtpPort = Nothing Or emailAddress = "" Or emailPassword = "" Or mailSubject = "" Or mailMessagePasser = "" Or mailMessageNonPasser = "" Then
            hasNull = True
            MessageBox.Show("Not all fields are filled.")
            Exit Sub
        End If

        'rebtebrwspnxkmex yung app specific pass
        If Not hasNull Then
            smtp = New SmtpClient(smtpServer) With {
            .EnableSsl = True,
            .Port = smtpPort,
            .Credentials = New NetworkCredential(emailAddress, emailPassword)
        }
        End If

    End Sub

    Public Sub adminProcessMail()
        ' Get all records to be sent with respective emails
        sql.ExecuteQuery("SELECT tbl_pending_emails.emailID, 
                                tbl_pending_emails.examineeID,
                                tbl_examinee_set.result,
                                tbl_examinee.emailAddress, 
                                tbl_pending_emails.pdfDocument 

                             FROM tbl_pending_emails
                             INNER JOIN tbl_examinee     ON tbl_examinee.examineeID = tbl_pending_emails.examineeID
                             INNER JOIN tbl_examinee_set ON tbl_examinee_set.examineeID = tbl_pending_emails.examineeID")

        Dim _emailID As String
        Dim _examineeID As String
        Dim _result As String
        Dim _examineeEmailAddress As String
        Dim _pdfBytes() As Byte

        For Each r As DataRow In sql.sqlDataSet.Tables(0).Rows

            If HasInternetConnection() Then
                _emailID = r("emailID")
                _examineeID = r("examineeID")
                _result = r("result")
                _examineeEmailAddress = r("emailAddress")
                _pdfBytes = r("pdfDocument")

                ' Convert to PDF then SEND
                ConvertToPDF(_pdfBytes) ' Converted PDF writes it into same File Directory as the EXE-file

                ' Send this Email
                Dim mail As New MailMessage()
                mail.From = New MailAddress(emailAddress)
                mail.To.Add(_examineeEmailAddress)
                mail.Subject = mailSubject

                If _result = "Passed" Then
                    mail.Body = mailMessagePasser
                ElseIf _result = "Failed" Then
                    mail.Body = mailMessageNonPasser
                End If

                Dim attachment As System.Net.Mail.Attachment
                attachment = New System.Net.Mail.Attachment("ExamineeSummary.pdf")
                mail.Attachments.Add(attachment)

                ' sending mail
                smtp.Send(mail)
                mail.Dispose()
                ' Delete instance of the mail in database(tbl_pending_emails)
                sql.AddParam("@emailID", _emailID)
                sql.ExecuteQuery("DELETE FROM tbl_pending_emails WHERE emailID = @emailID")

                MessageBox.Show("Mail Sent")


            Else
                MessageBox.Show("No Connection yet")
                Exit Sub
            End If
        Next



    End Sub

    Private Sub ProcessMail(_examineeIDParam As String, _examineeEmailAddress As String, _setDescriptionParam As String, _levelID As String, _positionDescription As String, _result As String)
        Try
            If HasInternetConnection() Then

                ' Get Passed/Failed of Examinee


                Dim mail As New MailMessage()
                mail.From = New MailAddress(emailAddress)
                mail.To.Add(_examineeEmailAddress)
                mail.Subject = mailSubject

                If _result = "Passed" Then
                    mail.Body = mailMessagePasser
                ElseIf _result = "Failed" Then
                    mail.Body = mailMessageNonPasser
                End If

                Dim attachment As System.Net.Mail.Attachment
                attachment = New System.Net.Mail.Attachment("ExamineeSummary.pdf")
                mail.Attachments.Add(attachment)

                ' sending mail
                smtp.Send(mail)
                mail.Dispose()
                MessageBox.Show("Mail Sent")

                Exit Sub

            Else
                MessageBox.Show("Mail not sent. No internet connection")
                ' Start uploading pdf to database(tbl_pending_emails)

                sql.AddParam("@examineeID", _examineeIDParam)
                sql.AddParam("@result", _result)
                sql.AddParam("@pdfBlob", ConvertToBytes("ExamineeSummary.pdf"))
                sql.ExecuteQuery("INSERT INTO tbl_pending_emails (examineeID, result, pdfDocument) VALUES (@examineeID, @result, @pdfBlob)")

                MessageBox.Show("Examinee result temporarily uploaded to database.")

            End If

        Catch ex As Exception
            MessageBox.Show("Email not sent" & vbNewLine & ex.Message)

            ' Insert the email to database
            sql.AddParam("@examineeID", _examineeIDParam)
            sql.AddParam("@result", _result)
            sql.AddParam("@pdfBlob", ConvertToBytes("ExamineeSummary.pdf"))
            sql.ExecuteQuery("INSERT INTO tbl_pending_emails (examineeID, result, pdfDocument) VALUES (@examineeID, @result, @pdfBlob)")

            MessageBox.Show("Examinee result temporarily uploaded to database.")
        End Try
    End Sub

    Private Function HasInternetConnection() As Boolean
        Try
            Dim _client As New WebClient()

            Using _client.OpenRead("http://google.com")
                Return True
            End Using

            Return False
        Catch ex As Exception
            MessageBox.Show("No internet access")
            Return False
        End Try

    End Function

    Public Sub SendExamineeEmail(_examineeIDParam As String, _setDescriptionParam As String, _levelID As String, _positionDescription As String, _emailAddress As String)
        ' This Sub Accepts examineeID, setDescription, levelID, positionDescription, examineeEmailAddress

        If _levelID = "1" Then

            GenerateSupervisoryDocument(_examineeIDParam, _setDescriptionParam)
            MessageBox.Show("natapos siya mag generate")
            ' Ilagay mo yung sending process sa GenerateSupervisoryDocument then dun, Catch mo kung nagsend o hindi, pag hindi pasok mo sa database

            ' Get positionID of positionDescription

            Dim _positionID As String
            sql.AddParam("@positionDescription", _positionDescription)
            sql.ExecuteQuery("SELECT * FROM tbl_position WHERE positionDescription = @positionDescription")

            If sql.recordCount > 0 Then
                _positionID = sql.sqlDataSet.Tables(0).Rows(0).Item("positionID").ToString()
            Else
                MessageBox.Show("No positionID found")
                Exit Sub
            End If

            ' Get Passed/Failed of examinee

            Dim _result As String
            sql.AddParam("@examineeID", _examineeIDParam)
            sql.AddParam("@setDescription", _setDescriptionParam)
            sql.AddParam("@levelID", _levelID)
            sql.AddParam("@positionID", _positionID)
            sql.ExecuteQuery("SELECT * FROM tbl_examinee_set WHERE examineeID = @examineeID AND setDescription = @setDescription AND levelID = @levelID AND positionID = @positionID")

            If sql.recordCount > 0 Then
                _result = sql.sqlDataSet.Tables(0).Rows(0).Item("result").ToString()
            Else
                MessageBox.Show("No Examinee Result")
                Exit Sub
            End If

            ' Send to process mail with all the needed IDs and params
            ProcessMail(_examineeIDParam, _emailAddress, _setDescriptionParam, _levelID, _positionDescription, _result)



        ElseIf _levelID = "2" Then

            GenerateNonSupervisoryDocument(_examineeIDParam, _setDescriptionParam)
            MessageBox.Show("natapos siya mag generate")
            ' Ilagay mo yung sending process sa GenerateSupervisoryDocument then dun, Catch mo kung nagsend o hindi, pag hindi pasok mo sa database

            ' Get positionID of positionDescription

            Dim _positionID As String
            sql.AddParam("@positionDescription", _positionDescription)
            sql.ExecuteQuery("SELECT * FROM tbl_position WHERE positionDescription = @positionDescription")

            If sql.recordCount > 0 Then
                _positionID = sql.sqlDataSet.Tables(0).Rows(0).Item("positionID").ToString()
            Else
                MessageBox.Show("No positionID found")
                Exit Sub
            End If

            ' Get Passed/Failed of examinee

            Dim _result As String
            sql.AddParam("@examineeID", _examineeIDParam)
            sql.AddParam("@setDescription", _setDescriptionParam)
            sql.AddParam("@levelID", _levelID)
            sql.AddParam("@positionID", _positionID)
            sql.ExecuteQuery("SELECT * FROM tbl_examinee_set WHERE examineeID = @examineeID AND setDescription = @setDescription AND levelID = @levelID AND positionID = @positionID")

            If sql.recordCount > 0 Then
                _result = sql.sqlDataSet.Tables(0).Rows(0).Item("result").ToString()
            Else
                MessageBox.Show("No Examinee Result")
                Exit Sub
            End If

            ' Send to process mail with all the needed IDs and params
            ProcessMail(_examineeIDParam, _emailAddress, _setDescriptionParam, _levelID, _positionDescription, _result)



        ElseIf _levelID = "3" Then

            GenerateClericalDocument(_examineeIDParam, _setDescriptionParam)
            MessageBox.Show("natapos siya mag generateClerical")
            ' Ilagay mo yung sending process sa GenerateSupervisoryDocument then dun, Catch mo kung nagsend o hindi, pag hindi pasok mo sa database

            ' Get positionID of positionDescription

            Dim _positionID As String
            sql.AddParam("@positionDescription", _positionDescription)
            sql.ExecuteQuery("SELECT * FROM tbl_position WHERE positionDescription = @positionDescription")

            If sql.recordCount > 0 Then
                _positionID = sql.sqlDataSet.Tables(0).Rows(0).Item("positionID").ToString()
            Else
                MessageBox.Show("No positionID found")
                Exit Sub
            End If

            ' Get Passed/Failed of examinee

            Dim _result As String
            sql.AddParam("@examineeID", _examineeIDParam)
            sql.AddParam("@setDescription", _setDescriptionParam)
            sql.AddParam("@levelID", _levelID)
            sql.AddParam("@positionID", _positionID)
            sql.ExecuteQuery("SELECT * FROM tbl_examinee_set WHERE examineeID = @examineeID AND setDescription = @setDescription AND levelID = @levelID AND positionID = @positionID")

            If sql.recordCount > 0 Then
                _result = sql.sqlDataSet.Tables(0).Rows(0).Item("result").ToString()
            Else
                MessageBox.Show("No Examinee Result")
                Exit Sub
            End If

            ' Send to process mail with all the needed IDs and params
            ProcessMail(_examineeIDParam, _emailAddress, _setDescriptionParam, _levelID, _positionDescription, _result)
        End If

    End Sub

    Public Shared Function ConvertToBytes(_filename) As Byte()
        Dim bytes() As Byte = System.IO.File.ReadAllBytes(_filename)
        Return bytes
    End Function

    Public Shared Sub ConvertToPDF(_pdfBytes As Byte())

        File.WriteAllBytes("ExamineeSummary.pdf", _pdfBytes)

    End Sub


    Public Sub GenerateSupervisoryDocument(_examineeIDParam As String, _setDescriptionParam As String)

        sql.AddParam("@examineeID", _examineeIDParam)
        sql.AddParam("@setDescription", _setDescriptionParam)
        sql.AddParam("@levelID", "1")



        sql.ExecuteQuery("SELECT * FROM tbl_examinee
                          INNER JOIN tbl_examinee_score
                          ON tbl_examinee.examineeID = tbl_examinee_score.examineeID
                          INNER JOIN tbl_examinee_set
                          ON tbl_examinee.examineeID = tbl_examinee_set.examineeID
                          INNER JOIN tbl_kind
                          ON tbl_kind.kindID = tbl_examinee_score.kindID
                          INNER JOIN tbl_level
                          ON tbl_kind.levelID = tbl_level.levelID
                          INNER JOIN tbl_position
                          ON tbl_position.positionID = tbl_examinee_set.positionID
                          WHERE tbl_examinee.examineeID = @examineeID
                          AND tbl_level.levelID = @levelID
                          AND tbl_examinee_set.levelID = @levelID
                          AND tbl_examinee_score.setDescription = @setDescription")

        ' Examinee Details
        If sql.recordCount > 0 Then
            Dim _examineeDateID As String = sql.sqlDataSet.Tables(0).Rows(0).Item("examineeDateID").ToString
            Dim _examineeID As String = sql.sqlDataSet.Tables(0).Rows(0).Item("examineeID").ToString
            Dim _firstName As String = sql.sqlDataSet.Tables(0).Rows(0).Item("firstName").ToString
            Dim _lastName As String = sql.sqlDataSet.Tables(0).Rows(0).Item("lastName").ToString
            Dim _levelDescription As String = sql.sqlDataSet.Tables(0).Rows(0).Item("levelDescription").ToString
            Dim _positionDescription As String = sql.sqlDataSet.Tables(0).Rows(0).Item("positionDescription").ToString
            Dim _result As String = sql.sqlDataSet.Tables(0).Rows(0).Item("result").ToString
            Dim _dateTaken As String = sql.sqlDataSet.Tables(0).Rows(0).Item("dateTaken").ToString
            Dim _setDescription As String = sql.sqlDataSet.Tables(0).Rows(0).Item("setDescription").ToString

            Dim _dateTakenHolder As Date = Date.Parse(_dateTaken)
            _dateTaken = _dateTakenHolder.ToString("MMMM dd, yyyy")


            Dim _doc As Document = New Document()
            Dim _sect As Section = _doc.AddSection()
            _sect.PageSetup.PageFormat = PageFormat.A4
            _sect.PageSetup.Orientation = Orientation.Portrait

            ' Logo Code source: Image to left of text. Code by the wonderful Thomas Hoevel
            ' Also view Invoice Example for Migradoc. Really useful
            Dim _logo As Shapes.Image = _sect.Headers.Primary.AddImage(My.Application.Info.DirectoryPath & "\..\..\Resources\rsz_dost.png")
            _logo.LockAspectRatio = True
            _logo.RelativeHorizontal = Shapes.RelativeHorizontal.Margin
            _logo.WrapFormat.Style = Shapes.WrapStyle.None


            Dim _fontstyle As Style = _doc.Styles("Normal")

            _fontstyle = _doc.AddStyle("Heading1", "Normal")
            _fontstyle.Font.Size = 15
            _fontstyle.Font.Bold = True
            _fontstyle.Font.Underline = 1


            _fontstyle = _doc.AddStyle("Heading2", "Normal")
            _fontstyle.Font.Size = 9
            _fontstyle.Font.Bold = False
            _fontstyle.Font.Underline = 0

            Dim _headerText As Paragraph = New Paragraph()
            _headerText.AddSpace(30)
            _headerText.AddFormattedText("Republic of the Philippines" & vbNewLine, TextFormat.Bold)
            _headerText.AddSpace(30)
            _headerText.AddFormattedText("Department of Science and Technology" & vbNewLine, "Heading1")
            _headerText.AddSpace(30)
            _headerText.AddFormattedText("DOST Regional Operations Building, A. Bonifacio Avenue, Bicutan, Taguig, Metro Manila", "Heading2")

            ' Add this at the end so that it doesn't interfere with our image
            _sect.Headers.Primary.Add(_headerText)



            'Footer 
            Dim _footer As Paragraph = New Paragraph()
            _footer.Format.Alignment = ParagraphAlignment.Center
            _footer.AddFormattedText("Note: This is a system generated report and does not need a seal or signature.", TextFormat.Italic)

            _sect.Footers.Primary.Add(_footer)


            'Footer 
            _footer = New Paragraph()
            _footer.Format.Alignment = ParagraphAlignment.Right
            _footer.AddText("Page ")
            _footer.AddPageField()
            _footer.AddText(" of ")
            _footer.AddNumPagesField()

            _sect.Footers.Primary.Add(_footer)

            ' Spaces needed
            _sect.AddParagraph(vbNewLine & vbNewLine & vbNewLine & vbNewLine)
            _sect.AddParagraph(vbNewLine & vbNewLine & vbNewLine & vbNewLine)



            If Not IsDBNull(sql.sqlDataSet.Tables(0).Rows(0).Item("examineePic")) Then
                Dim _examineePic As Shapes.Image = _sect.AddImage(My.Computer.FileSystem.SpecialDirectories.MyPictures & "\Image.jpg")
                _examineePic.RelativeHorizontal = Shapes.RelativeHorizontal.Margin
                _examineePic.Top = Shapes.ShapePosition.Top
                _examineePic.Left = Shapes.ShapePosition.Right
                _examineePic.WrapFormat.Style = Shapes.WrapStyle.Through
            End If


            ' Adds date
            _sect.AddParagraph(Date.Now.ToString("MMMM dd, yyyy"))
            ' Add new line
            _sect.AddParagraph(vbNewLine)

            _fontstyle = _doc.AddStyle("Paragraph", "Normal")
            _fontstyle.Font.Size = 12

            Dim _examineeDetails As Paragraph = New Paragraph()
            _examineeDetails.AddFormattedText("Name: " & _firstName & " " & _lastName & vbNewLine, "Paragraph")
            _examineeDetails.AddFormattedText("Level: " & _levelDescription & vbNewLine, "Paragraph")
            _examineeDetails.AddFormattedText("Position: " & _positionDescription & vbNewLine, "Paragraph")
            _examineeDetails.AddFormattedText("Examinee ID: " & _examineeDateID & vbNewLine, "Paragraph")
            _examineeDetails.AddFormattedText("Date of Exam: " & _dateTaken, "Paragraph")

            _sect.Add(_examineeDetails)

            ' Adds a new line
            _sect.AddParagraph(vbNewLine & vbNewLine)


            ' Table Holder and If statements for table Creation
            Dim _tableHolder As Table = New Table()
            _tableHolder = AdminDashboard.CreateTableSupervisory("Supervisory", _examineeID, _setDescription)

            ' Paragraph for Results
            Dim _paraResult As Paragraph = New Paragraph()

            ' Paragraph and table for examinee results
            If _result = "Passed" Then

                _paraResult.AddFormattedText("Dear Applicant, " & vbNewLine & vbNewLine & "Congratulations!" & vbNewLine & vbNewLine & "You passed the pre-qualification examination as part of the recruitment process." _
                                   & vbNewLine & vbNewLine & "Below is the result of your examination" & vbNewLine & vbNewLine & vbNewLine, "Paragraph")

                _sect.Add(_paraResult)

                _sect.Add(_tableHolder) ' Add table

            ElseIf _result = "Failed" Then

                _paraResult.AddFormattedText("Dear Applicant, " & vbNewLine & vbNewLine & "We regret to inform you that you did not pass the pre-qualification examination as part of the recruitment process." _
                                   & vbNewLine & vbNewLine & "Below is the result of your examination" & vbNewLine & vbNewLine & vbNewLine, "Paragraph")

                _sect.Add(_paraResult)

                _sect.Add(_tableHolder) ' Add table
            End If

            _sect.AddParagraph(vbNewLine & vbNewLine & vbNewLine & vbNewLine)
            _sect.AddParagraph(vbNewLine & vbNewLine & vbNewLine & vbNewLine)

            'Dim _paraSignature As Paragraph = New Paragraph()
            '_paraSignature.AddFormattedText("______________________" & vbNewLine & "Printed Name and Signature", "Paragraph")
            '_paraSignature.Format.Alignment = ParagraphAlignment.Right

            '_sect.Add(_paraSignature)


            ' Renders the doocument
            Dim _renderer As PdfDocumentRenderer = New PdfDocumentRenderer(True, PdfSharp.Pdf.PdfFontEmbedding.Always)
            _renderer.Document = _doc
            _renderer.RenderDocument()

            ' Save document
            Dim filename As String = "ExamineeSummary.pdf"
            _renderer.PdfDocument.Save(filename)

        Else
            MessageBox.Show("Examinee has no results yet on the specified Set")
        End If

    End Sub

    Public Sub GenerateNonSupervisoryDocument(_examineeIDParam As String, _setDescriptionParam As String)

        sql.AddParam("@examineeID", _examineeIDParam)
        sql.AddParam("@setDescription", _setDescriptionParam)
        sql.AddParam("@levelID", "2")



        sql.ExecuteQuery("SELECT * FROM tbl_examinee
                          INNER JOIN tbl_examinee_score
                          ON tbl_examinee.examineeID = tbl_examinee_score.examineeID
                          INNER JOIN tbl_examinee_set
                          ON tbl_examinee.examineeID = tbl_examinee_set.examineeID
                          INNER JOIN tbl_kind
                          ON tbl_kind.kindID = tbl_examinee_score.kindID
                          INNER JOIN tbl_level
                          ON tbl_kind.levelID = tbl_level.levelID
                          INNER JOIN tbl_position
                          ON tbl_position.positionID = tbl_examinee_set.positionID
                          WHERE tbl_examinee.examineeID = @examineeID
                          AND tbl_level.levelID = @levelID
                          AND tbl_examinee_set.levelID = @levelID
                          AND tbl_examinee_score.setDescription = @setDescription")

        ' Examinee Detials
        If sql.recordCount > 0 Then
            Dim _examineeDateID As String = sql.sqlDataSet.Tables(0).Rows(0).Item("examineeDateID").ToString
            Dim _examineeID As String = sql.sqlDataSet.Tables(0).Rows(0).Item("examineeID").ToString
            Dim _firstName As String = sql.sqlDataSet.Tables(0).Rows(0).Item("firstName").ToString
            Dim _lastName As String = sql.sqlDataSet.Tables(0).Rows(0).Item("lastName").ToString
            Dim _levelDescription As String = sql.sqlDataSet.Tables(0).Rows(0).Item("levelDescription").ToString
            Dim _positionDescription As String = sql.sqlDataSet.Tables(0).Rows(0).Item("positionDescription").ToString
            Dim _result As String = sql.sqlDataSet.Tables(0).Rows(0).Item("result").ToString
            Dim _dateTaken As String = sql.sqlDataSet.Tables(0).Rows(0).Item("dateTaken").ToString
            Dim _setDescription As String = sql.sqlDataSet.Tables(0).Rows(0).Item("setDescription").ToString

            Dim _dateTakenHolder As Date = Date.Parse(_dateTaken)
            _dateTaken = _dateTakenHolder.ToString("MMMM dd, yyyy")


            Dim _doc As Document = New Document()
            Dim _sect As Section = _doc.AddSection()
            _sect.PageSetup.PageFormat = PageFormat.A4
            _sect.PageSetup.Orientation = Orientation.Portrait

            ' Logo Code source: Image to left of text. Code by the wonderful Thomas Hoevel
            ' Also view Invoice Example for Migradoc. Really useful
            Dim _logo As Shapes.Image = _sect.Headers.Primary.AddImage(My.Application.Info.DirectoryPath & "\..\..\Resources\rsz_dost.png")
            _logo.LockAspectRatio = True
            _logo.RelativeHorizontal = Shapes.RelativeHorizontal.Margin
            _logo.WrapFormat.Style = Shapes.WrapStyle.None


            Dim _fontstyle As Style = _doc.Styles("Normal")

            _fontstyle = _doc.AddStyle("Heading1", "Normal")
            _fontstyle.Font.Size = 15
            _fontstyle.Font.Bold = True
            _fontstyle.Font.Underline = 1


            _fontstyle = _doc.AddStyle("Heading2", "Normal")
            _fontstyle.Font.Size = 9
            _fontstyle.Font.Bold = False
            _fontstyle.Font.Underline = 0

            Dim _headerText As Paragraph = New Paragraph()
            _headerText.AddSpace(30)
            _headerText.AddFormattedText("Republic of the Philippines" & vbNewLine, TextFormat.Bold)
            _headerText.AddSpace(30)
            _headerText.AddFormattedText("Department of Science and Technology" & vbNewLine, "Heading1")
            _headerText.AddSpace(30)
            _headerText.AddFormattedText("DOST Regional Operations Building, A. Bonifacio Avenue, Bicutan, Taguig, Metro Manila", "Heading2")

            ' Add this at the end so that it doesn't interfere with our image
            _sect.Headers.Primary.Add(_headerText)


            'Footer 
            Dim _footer As Paragraph = New Paragraph()
            _footer.Format.Alignment = ParagraphAlignment.Center
            _footer.AddFormattedText("Note: This is a system generated report and does not need a seal or signature.", TextFormat.Italic)

            _sect.Footers.Primary.Add(_footer)

            'Footer 
            _footer = New Paragraph()
            _footer.Format.Alignment = ParagraphAlignment.Right
            _footer.AddText("Page ")
            _footer.AddPageField()
            _footer.AddText(" of ")
            _footer.AddNumPagesField()

            _sect.Footers.Primary.Add(_footer)

            ' Spaces needed
            _sect.AddParagraph(vbNewLine & vbNewLine & vbNewLine & vbNewLine)
            _sect.AddParagraph(vbNewLine & vbNewLine & vbNewLine & vbNewLine)



            If Not IsDBNull(sql.sqlDataSet.Tables(0).Rows(0).Item("examineePic")) Then
                Dim _examineePic As Shapes.Image = _sect.AddImage(My.Computer.FileSystem.SpecialDirectories.MyPictures & "\Image.jpg")
                _examineePic.RelativeHorizontal = Shapes.RelativeHorizontal.Margin
                _examineePic.Top = Shapes.ShapePosition.Top
                _examineePic.Left = Shapes.ShapePosition.Right
                _examineePic.WrapFormat.Style = Shapes.WrapStyle.Through
            End If


            ' Adds date
            _sect.AddParagraph(Date.Now.ToString("MMMM dd, yyyy"))
            ' Add new line
            _sect.AddParagraph(vbNewLine)

            _fontstyle = _doc.AddStyle("Paragraph", "Normal")
            _fontstyle.Font.Size = 12

            Dim _examineeDetails As Paragraph = New Paragraph()
            _examineeDetails.AddFormattedText("Name: " & _firstName & " " & _lastName & vbNewLine, "Paragraph")
            _examineeDetails.AddFormattedText("Level: " & _levelDescription & vbNewLine, "Paragraph")
            _examineeDetails.AddFormattedText("Position: " & _positionDescription & vbNewLine, "Paragraph")
            _examineeDetails.AddFormattedText("Examinee ID: " & _examineeDateID & vbNewLine, "Paragraph")
            _examineeDetails.AddFormattedText("Date of Exam: " & _dateTaken, "Paragraph")

            _sect.Add(_examineeDetails)

            ' Adds a new line
            _sect.AddParagraph(vbNewLine & vbNewLine)


            ' Table Holder and If statements for table Creation
            Dim _tableHolder As Table = New Table()
            _tableHolder = AdminDashboard.CreateTableNonSupervisory("Non-Supervisory", _examineeID, _setDescription)

            ' Paragraph for Results
            Dim _paraResult As Paragraph = New Paragraph()

            ' Paragraph and table for examinee results
            If _result = "Passed" Then

                _paraResult.AddFormattedText("Dear Applicant, " & vbNewLine & vbNewLine & "Congratulations!" & vbNewLine & vbNewLine & "You passed the pre-qualification examination as part of the recruitment process." _
                                   & vbNewLine & vbNewLine & "Below is the result of your examination" & vbNewLine & vbNewLine & vbNewLine, "Paragraph")

                _sect.Add(_paraResult)

                _sect.Add(_tableHolder) ' Add table

            ElseIf _result = "Failed" Then

                _paraResult.AddFormattedText("Dear Applicant, " & vbNewLine & vbNewLine & "We regret to inform you that you did not pass the pre-qualification examination as part of the recruitment process." _
                                   & vbNewLine & vbNewLine & "Below is the result of your examination" & vbNewLine & vbNewLine & vbNewLine, "Paragraph")

                _sect.Add(_paraResult)

                _sect.Add(_tableHolder) ' Add table
            End If

            _sect.AddParagraph(vbNewLine & vbNewLine & vbNewLine & vbNewLine)
            _sect.AddParagraph(vbNewLine & vbNewLine & vbNewLine & vbNewLine)

            'Dim _paraSignature As Paragraph = New Paragraph()
            '_paraSignature.AddFormattedText("______________________" & vbNewLine & "Printed Name and Signature", "Paragraph")
            '_paraSignature.Format.Alignment = ParagraphAlignment.Right

            '_sect.Add(_paraSignature)


            ' Renders the doocument
            Dim _renderer As PdfDocumentRenderer = New PdfDocumentRenderer(True, PdfSharp.Pdf.PdfFontEmbedding.Always)
            _renderer.Document = _doc
            _renderer.RenderDocument()

            ' Save document
            Dim filename As String = "ExamineeSummary.pdf"
            _renderer.PdfDocument.Save(filename)
        Else
            MessageBox.Show("Examinee has no results yet on the specified Set")
        End If

    End Sub

    Public Sub GenerateClericalDocument(_examineeIDParam As String, _setDescriptionParam As String)

        sql.AddParam("@examineeID", _examineeIDParam)
        sql.AddParam("@setDescription", _setDescriptionParam)
        sql.AddParam("@levelID", "3")



        sql.ExecuteQuery("SELECT * FROM tbl_examinee
                          INNER JOIN tbl_examinee_score
                          ON tbl_examinee.examineeID = tbl_examinee_score.examineeID
                          INNER JOIN tbl_examinee_set
                          ON tbl_examinee.examineeID = tbl_examinee_set.examineeID
                          INNER JOIN tbl_kind
                          ON tbl_kind.kindID = tbl_examinee_score.kindID
                          INNER JOIN tbl_level
                          ON tbl_kind.levelID = tbl_level.levelID
                          INNER JOIN tbl_position
                          ON tbl_position.positionID = tbl_examinee_set.positionID
                          WHERE tbl_examinee.examineeID = @examineeID
                          AND tbl_level.levelID = @levelID
                          AND tbl_examinee_set.levelID = @levelID
                          AND tbl_examinee_score.setDescription = @setDescription")

        ' Examinee Detials
        If sql.recordCount > 0 Then
            Dim _examineeDateID As String = sql.sqlDataSet.Tables(0).Rows(0).Item("examineeDateID").ToString
            Dim _examineeID As String = sql.sqlDataSet.Tables(0).Rows(0).Item("examineeID").ToString
            Dim _firstName As String = sql.sqlDataSet.Tables(0).Rows(0).Item("firstName").ToString
            Dim _lastName As String = sql.sqlDataSet.Tables(0).Rows(0).Item("lastName").ToString
            Dim _levelDescription As String = sql.sqlDataSet.Tables(0).Rows(0).Item("levelDescription").ToString
            Dim _positionDescription As String = sql.sqlDataSet.Tables(0).Rows(0).Item("positionDescription").ToString
            Dim _result As String = sql.sqlDataSet.Tables(0).Rows(0).Item("result").ToString
            Dim _dateTaken As String = sql.sqlDataSet.Tables(0).Rows(0).Item("dateTaken").ToString
            Dim _setDescription As String = sql.sqlDataSet.Tables(0).Rows(0).Item("setDescription").ToString

            Dim _dateTakenHolder As Date = Date.Parse(_dateTaken)
            _dateTaken = _dateTakenHolder.ToString("MMMM dd, yyyy")


            Dim _doc As Document = New Document()
            Dim _sect As Section = _doc.AddSection()
            _sect.PageSetup.PageFormat = PageFormat.A4
            _sect.PageSetup.Orientation = Orientation.Portrait

            ' Logo Code source: Image to left of text. Code by the wonderful Thomas Hoevel
            ' Also view Invoice Example for Migradoc. Really useful
            Dim _logo As Shapes.Image = _sect.Headers.Primary.AddImage(My.Application.Info.DirectoryPath & "\..\..\Resources\rsz_dost.png")
            _logo.LockAspectRatio = True
            _logo.RelativeHorizontal = Shapes.RelativeHorizontal.Margin
            _logo.WrapFormat.Style = Shapes.WrapStyle.None


            Dim _fontstyle As Style = _doc.Styles("Normal")

            _fontstyle = _doc.AddStyle("Heading1", "Normal")
            _fontstyle.Font.Size = 15
            _fontstyle.Font.Bold = True
            _fontstyle.Font.Underline = 1


            _fontstyle = _doc.AddStyle("Heading2", "Normal")
            _fontstyle.Font.Size = 9
            _fontstyle.Font.Bold = False
            _fontstyle.Font.Underline = 0

            Dim _headerText As Paragraph = New Paragraph()
            _headerText.AddSpace(30)
            _headerText.AddFormattedText("Republic of the Philippines" & vbNewLine, TextFormat.Bold)
            _headerText.AddSpace(30)
            _headerText.AddFormattedText("Department of Science and Technology" & vbNewLine, "Heading1")
            _headerText.AddSpace(30)
            _headerText.AddFormattedText("DOST Regional Operations Building, A. Bonifacio Avenue, Bicutan, Taguig, Metro Manila", "Heading2")

            ' Add this at the end so that it doesn't interfere with our image
            _sect.Headers.Primary.Add(_headerText)


            'Footer 
            Dim _footer As Paragraph = New Paragraph()
            _footer.Format.Alignment = ParagraphAlignment.Center
            _footer.AddFormattedText("Note: This is a system generated report and does not need a seal or signature.", TextFormat.Italic)

            _sect.Footers.Primary.Add(_footer)

            'Footer 
            _footer = New Paragraph()
            _footer.Format.Alignment = ParagraphAlignment.Right
            _footer.AddText("Page ")
            _footer.AddPageField()
            _footer.AddText(" of ")
            _footer.AddNumPagesField()

            _sect.Footers.Primary.Add(_footer)

            ' Spaces needed
            _sect.AddParagraph(vbNewLine & vbNewLine & vbNewLine & vbNewLine)
            _sect.AddParagraph(vbNewLine & vbNewLine & vbNewLine & vbNewLine)



            If Not IsDBNull(sql.sqlDataSet.Tables(0).Rows(0).Item("examineePic")) Then
                Dim _examineePic As Shapes.Image = _sect.AddImage(My.Computer.FileSystem.SpecialDirectories.MyPictures & "\Image.jpg")
                _examineePic.RelativeHorizontal = Shapes.RelativeHorizontal.Margin
                _examineePic.Top = Shapes.ShapePosition.Top
                _examineePic.Left = Shapes.ShapePosition.Right
                _examineePic.WrapFormat.Style = Shapes.WrapStyle.Through
            End If


            ' Adds date
            _sect.AddParagraph(Date.Now.ToString("MMMM dd, yyyy"))
            ' Add new line
            _sect.AddParagraph(vbNewLine)

            _fontstyle = _doc.AddStyle("Paragraph", "Normal")
            _fontstyle.Font.Size = 12

            Dim _examineeDetails As Paragraph = New Paragraph()
            _examineeDetails.AddFormattedText("Name: " & _firstName & " " & _lastName & vbNewLine, "Paragraph")
            _examineeDetails.AddFormattedText("Level: " & _levelDescription & vbNewLine, "Paragraph")
            _examineeDetails.AddFormattedText("Position: " & _positionDescription & vbNewLine, "Paragraph")
            _examineeDetails.AddFormattedText("Examinee ID: " & _examineeDateID & vbNewLine, "Paragraph")
            _examineeDetails.AddFormattedText("Date of Exam: " & _dateTaken, "Paragraph")

            _sect.Add(_examineeDetails)

            ' Adds a new line
            _sect.AddParagraph(vbNewLine & vbNewLine)


            ' Table Holder and If statements for table Creation
            Dim _tableHolder As Table = New Table()
            _tableHolder = AdminDashboard.CreateTableClerical("Clerical", _examineeID, _setDescription)

            ' Paragraph for Results
            Dim _paraResult As Paragraph = New Paragraph()

            ' Paragraph and table for examinee results
            If _result = "Passed" Then

                _paraResult.AddFormattedText("Dear Applicant, " & vbNewLine & vbNewLine & "Congratulations!" & vbNewLine & vbNewLine & "You passed the pre-qualification examination as part of the recruitment process." _
                                   & vbNewLine & vbNewLine & "Below is the result of your examination" & vbNewLine & vbNewLine & vbNewLine, "Paragraph")

                _sect.Add(_paraResult)

                _sect.Add(_tableHolder) ' Add table

            ElseIf _result = "Failed" Then

                _paraResult.AddFormattedText("Dear Applicant, " & vbNewLine & vbNewLine & "We regret to inform you that you did not pass the pre-qualification examination as part of the recruitment process." _
                                   & vbNewLine & vbNewLine & "Below is the result of your examination" & vbNewLine & vbNewLine & vbNewLine, "Paragraph")

                _sect.Add(_paraResult)

                _sect.Add(_tableHolder) ' Add table
            End If

            _sect.AddParagraph(vbNewLine & vbNewLine & vbNewLine & vbNewLine)
            _sect.AddParagraph(vbNewLine & vbNewLine & vbNewLine & vbNewLine)

            'Dim _paraSignature As Paragraph = New Paragraph()
            '_paraSignature.AddFormattedText("______________________" & vbNewLine & "Printed Name and Signature", "Paragraph")
            '_paraSignature.Format.Alignment = ParagraphAlignment.Right

            '_sect.Add(_paraSignature)


            ' Renders the doocument
            Dim _renderer As PdfDocumentRenderer = New PdfDocumentRenderer(True, PdfSharp.Pdf.PdfFontEmbedding.Always)
            _renderer.Document = _doc
            _renderer.RenderDocument()

            ' Save document
            Dim filename As String = "ExamineeSummary.pdf"
            _renderer.PdfDocument.Save(filename)

        Else
            MessageBox.Show("Examinee has no results yet on the specified Set")
        End If
    End Sub

    Public Shared Function SendEmailFromAdmin(_examineeEmailAddress As String, _result As String) As Boolean

        Try
            Dim mail As New MailMessage()
            mail.From = New MailAddress(emailAddress)
            mail.To.Add(_examineeEmailAddress)
            mail.Subject = mailSubject

            If _result = "Passed" Then
                mail.Body = mailMessagePasser
            ElseIf _result = "Failed" Then
                mail.Body = mailMessageNonPasser
            End If

            Dim attachment As System.Net.Mail.Attachment
            attachment = New System.Net.Mail.Attachment("ExamineeSummary.pdf")
            mail.Attachments.Add(attachment)

            ' sending mail
            smtp.Send(mail)

            mail.Dispose()
            MessageBox.Show("Mail Sent")

            Return True


        Catch ex As Exception
            MessageBox.Show("Email sending error. Now cancelling request." & vbNewLine & ex.Message)
            Return False
        End Try

    End Function

End Class
