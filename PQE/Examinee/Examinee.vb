Imports MaterialSkin
Public Class Examinee

    Public sql As New SQLControl
    Dim rs As New Resizer

    Private Sub Examinee_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim _skinManager As MaterialSkinManager = MaterialSkinManager.Instance
        _skinManager.AddFormToManage(Me)
        _skinManager.Theme = MaterialSkinManager.Themes.LIGHT
        _skinManager.ColorScheme = New ColorScheme(Primary.Blue600, Primary.Blue700, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)

        ' Query for Exmainee Pic
        sql.AddParam("@examineeDateID", lblExamineeDateID.Text)
        sql.ExecuteQuery("SELECT examineePic FROM tbl_examinee WHERE examineeDateID = @examineeDateID")

        If IsDBNull(sql.sqlDataSet.Tables(0).Rows(0).Item("examineePic")) Then
            picExaminee.Image = PQE.My.Resources.NoExamineePic
        Else
            Dim _examineePicByte() As Byte = sql.sqlDataSet.Tables(0).Rows(0).Item("examineePic")
            Using _examineePicStream As New System.IO.MemoryStream(_examineePicByte)
                picExaminee.Image = Image.FromStream(_examineePicStream)
                picExaminee.SizeMode = PictureBoxSizeMode.StretchImage
                _examineePicStream.Close()
            End Using
        End If


        ' If Clerical show extra 2 Tests
        If lblLevelID.Text = "3" Then

            ' VISIBLE LABELS, BUTTONS, BOXES
            lblTest4.Visible = True
            lblTest5.Visible = True
            lblTime4.Visible = True
            lblTime5.Visible = True
            btnTestStart4.Visible = True
            btnTestStart5.Visible = True

        End If



        rs.FindAllControls(Me)
    End Sub

    Private Sub Examinee_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        rs.ResizeAllControls(Me)
    End Sub

    Private Sub btnTestStart1_Click(sender As Object, e As EventArgs) Handles btnTestStart1.Click

        ' HIDES BUTTON
        btnTestStart1.Visible = False
        ' GET KIND_ID
        sql.AddParam("@levelID", lblLevelID.Text)
        sql.AddParam("@testTypeID", lblTestID1.Text)
        sql.ExecuteQuery("SELECT * FROM tbl_kind
                                  WHERE levelID = @levelID
                                    AND testTypeID = @testTypeID")


        ' Passing variables
        ExamineeTest.Text = "DOST: " & lblLevelDescription.Text & ", " & lblTest1.Text & " Exam"
        ExamineeTest.lblExamineeDateID.Text = lblExamineeDateID.Text
        ExamineeTest.lblExamineeID.Text = lblExamineeID.Text
        ExamineeTest.lblFirstName.Text = lblFirstName.Text
        ExamineeTest.lblLastName.Text = lblLastName.Text
        ExamineeTest.lblLevelDescription.Text = lblLevelDescription.Text
        ExamineeTest.lblPositionDescription.Text = lblPositionDescription.Text
        ExamineeTest.lblLevelID.Text = lblLevelID.Text
        ExamineeTest.lblTestTypeID.Text = lblTestID1.Text
        ExamineeTest.lblSetDescription.Text = lblSetDescription.Text
        ExamineeTest.lblKindID.Text = sql.sqlDataSet.Tables(0).Rows(0).Item("kindID")
        ' Getting the value of time and passing it
        ExamineeTest.lblTimer.Text = lblTime1.Text

        ExamineeTest.Show()
        Me.Hide()

    End Sub

    Private Sub btnTestStart2_Click(sender As Object, e As EventArgs) Handles btnTestStart2.Click

        ' HIDES BUTTON
        btnTestStart2.Visible = False

        ' GET KIND_ID
        sql.AddParam("@levelID", lblLevelID.Text)
        sql.AddParam("@testTypeID", lblTestID2.Text)
        sql.ExecuteQuery("SELECT * FROM tbl_kind
                                  WHERE levelID = @levelID
                                    AND testTypeID = @testTypeID")

        ' Passing variables
        ExamineeTest.Text = "DOST: " & lblLevelDescription.Text & ", " & lblTest2.Text & " Exam"
        ExamineeTest.lblExamineeDateID.Text = lblExamineeDateID.Text
        ExamineeTest.lblExamineeID.Text = lblExamineeID.Text
        ExamineeTest.lblFirstName.Text = lblFirstName.Text
        ExamineeTest.lblLastName.Text = lblLastName.Text
        ExamineeTest.lblLevelDescription.Text = lblLevelDescription.Text
        ExamineeTest.lblPositionDescription.Text = lblPositionDescription.Text
        ExamineeTest.lblLevelID.Text = lblLevelID.Text
        ExamineeTest.lblTestTypeID.Text = lblTestID2.Text
        ExamineeTest.lblSetDescription.Text = lblSetDescription.Text
        ExamineeTest.lblKindID.Text = sql.sqlDataSet.Tables(0).Rows(0).Item("kindID")

        ' Getting the value of time and passing it
        ExamineeTest.lblTimer.Text = lblTime2.Text

        ExamineeTest.Show()

        Me.Hide()
    End Sub

    Private Sub btnTestStart3_Click(sender As Object, e As EventArgs) Handles btnTestStart3.Click

        ' HIDES BUTTON
        btnTestStart3.Visible = False

        ' GET KIND_ID
        sql.AddParam("@levelID", lblLevelID.Text)
        sql.AddParam("@testTypeID", lblTestID3.Text)
        sql.ExecuteQuery("SELECT * FROM tbl_kind
                                  WHERE levelID = @levelID
                                    AND testTypeID = @testTypeID")

        ' Passing variables
        ExamineeTest.Text = "DOST: " & lblLevelDescription.Text & ", " & lblTest3.Text & " Exam"
        ExamineeTest.lblExamineeDateID.Text = lblExamineeDateID.Text
        ExamineeTest.lblExamineeID.Text = lblExamineeID.Text
        ExamineeTest.lblFirstName.Text = lblFirstName.Text
        ExamineeTest.lblLastName.Text = lblLastName.Text
        ExamineeTest.lblLevelDescription.Text = lblLevelDescription.Text
        ExamineeTest.lblPositionDescription.Text = lblPositionDescription.Text
        ExamineeTest.lblLevelID.Text = lblLevelID.Text
        ExamineeTest.lblTestTypeID.Text = lblTestID3.Text
        ExamineeTest.lblSetDescription.Text = lblSetDescription.Text
        ExamineeTest.lblKindID.Text = sql.sqlDataSet.Tables(0).Rows(0).Item("kindID")


        ' Getting the value of time and passing it
        ExamineeTest.lblTimer.Text = lblTime3.Text

        ExamineeTest.Show()
        Me.Hide()
    End Sub

    Private Sub btnTestStart4_Click(sender As Object, e As EventArgs) Handles btnTestStart4.Click

        ' HIDES BUTTON
        btnTestStart4.Visible = False

        ' GET KIND_ID
        sql.AddParam("@levelID", lblLevelID.Text)
        sql.AddParam("@testTypeID", lblTestID4.Text)
        sql.ExecuteQuery("SELECT * FROM tbl_kind
                                  WHERE levelID = @levelID
                                    AND testTypeID = @testTypeID")

        ' Passing variables -> TEST FORM
        ExamineeTest.Text = "DOST: " & lblLevelDescription.Text & ", " & lblTest4.Text & " Exam"
        ExamineeTest.lblExamineeDateID.Text = lblExamineeDateID.Text
        ExamineeTest.lblExamineeID.Text = lblExamineeID.Text
        ExamineeTest.lblFirstName.Text = lblFirstName.Text
        ExamineeTest.lblLastName.Text = lblLastName.Text
        ExamineeTest.lblLevelDescription.Text = lblLevelDescription.Text
        ExamineeTest.lblPositionDescription.Text = lblPositionDescription.Text
        ExamineeTest.lblLevelID.Text = lblLevelID.Text
        ExamineeTest.lblTestTypeID.Text = lblTestID4.Text
        ExamineeTest.lblSetDescription.Text = lblSetDescription.Text
        ExamineeTest.lblKindID.Text = sql.sqlDataSet.Tables(0).Rows(0).Item("kindID")


        ' Getting the value of time and passing it
        ExamineeTest.lblTimer.Text = lblTime4.Text

        ExamineeTest.Show()
        Me.Hide()
    End Sub

    Private Sub btnTestStart5_Click(sender As Object, e As EventArgs) Handles btnTestStart5.Click

        ' HIDES BUTTON
        btnTestStart5.Visible = False

        ' GET KIND_ID
        sql.AddParam("@levelID", lblLevelID.Text)
        sql.AddParam("@testTypeID", lblTestID5.Text)
        sql.ExecuteQuery("SELECT * FROM tbl_kind
                                  WHERE levelID = @levelID
                                    AND testTypeID = @testTypeID")

        ' Passing variables -> TEST FORM
        ExamineeTest.Text = "DOST: " & lblLevelDescription.Text & ", " & lblTest5.Text & " Exam"
        ExamineeTest.lblExamineeDateID.Text = lblExamineeDateID.Text
        ExamineeTest.lblExamineeID.Text = lblExamineeID.Text
        ExamineeTest.lblFirstName.Text = lblFirstName.Text
        ExamineeTest.lblLastName.Text = lblLastName.Text
        ExamineeTest.lblLevelDescription.Text = lblLevelDescription.Text
        ExamineeTest.lblPositionDescription.Text = lblPositionDescription.Text
        ExamineeTest.lblLevelID.Text = lblLevelID.Text
        ExamineeTest.lblTestTypeID.Text = lblTestID5.Text
        ExamineeTest.lblSetDescription.Text = lblSetDescription.Text
        ExamineeTest.lblKindID.Text = sql.sqlDataSet.Tables(0).Rows(0).Item("kindID")


        ' Getting the value of time and passing it
        ExamineeTest.lblTimer.Text = lblTime5.Text

        ExamineeTest.Show()
        Me.Hide()
    End Sub

    ' Insert Passed or Failed in tbl_examinee_set 
    Public Sub InsertPassOrFail()

        Dim _examineeScore As Integer = 0
        Dim _result As String


        ' GET ALL SCORES OF EXAMINEE
        sql.AddParam("@examineeID", lblExamineeID.Text)
        sql.AddParam("@setDescription", lblSetDescription.Text)
        sql.AddParam("@levelID", lblLevelID.Text)
        sql.ExecuteQuery("SELECT * FROM tbl_examinee_score

                      INNER JOIN tbl_kind ON tbl_examinee_score.kindID = tbl_kind.kindID
                                
                           WHERE examineeID = @examineeID 
                             AND tbl_kind.levelID = @levelID
                             AND setDescription = @setDescription")

        _examineeScore = _examineeScore + sql.sqlDataSet.Tables(0).Rows(0).Item("examineeScore")
        _examineeScore = _examineeScore + sql.sqlDataSet.Tables(0).Rows(1).Item("examineeScore")
        _examineeScore = _examineeScore + sql.sqlDataSet.Tables(0).Rows(2).Item("examineeScore")

        ' If Clerical
        If lblLevelID.Text = "3" Then
            _examineeScore = _examineeScore + sql.sqlDataSet.Tables(0).Rows(3).Item("examineeScore")
            _examineeScore = _examineeScore + sql.sqlDataSet.Tables(0).Rows(4).Item("examineeScore")
        End If


        ' PASSING SCORE SETTING AND RESULT
        If _examineeScore >= 5 Then
            _result = "Passed"
        Else
            _result = "Failed"
        End If

        ' Since there is no positionID
        Dim _positionID As String = GetPositionID()

        ' Since a record for Set A was already inserted upon register
        If lblSetDescription.Text = "A" Then
            sql.AddParam("@examineeID", lblExamineeID.Text)
            sql.AddParam("@setDescription", lblSetDescription.Text)
            sql.AddParam("@levelID", lblLevelID.Text)

            sql.AddParam("@positionID", _positionID)
            sql.AddParam("@result", _result)
            sql.ExecuteQuery("UPDATE tbl_examinee_set SET result = @result 
                               WHERE examineeID = @examineeID
                                 AND levelID = @levelID
                                 AND setDescription = @setDescription
                                 AND positionID = @positionID")
        Else

            sql.AddParam("@levelID", lblLevelID.Text)
            sql.AddParam("@positionID", _positionID)
            sql.AddParam("@examineeID", lblExamineeID.Text)
            sql.AddParam("@setDescription", lblSetDescription.Text)
            sql.AddParam("@result", _result)
            sql.ExecuteQuery("INSERT INTO tbl_examinee_set (examineeID, setDescription, result, levelID, positionID)
                               VALUES (@examineeID, @setDescription, @result, @levelID, @positionID)")
        End If


    End Sub

    Private Function GetPositionID() As String
        sql.AddParam("@positionDescription", lblPositionDescription.Text)
        sql.ExecuteQuery("SELECT positionID FROM tbl_position WHERE positionDescription = @positionDescription")

        Return sql.sqlDataSet.Tables(0).Rows(0).Item("positionID").ToString
    End Function


End Class