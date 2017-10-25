Imports MaterialSkin




Public Class ExamineePicture
    Private WithEvents cam As New DSCamCapture
    Dim MyPicturesFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)

    ' To check whether capture button is clicked
    Dim hasClickedCapture As Boolean = False
    Dim examineePic As System.Drawing.Bitmap


    Public sql As New SQLControl

    Dim rs As New Resizer

    ' Disposes the cam on closing the form
    Private Sub ExamineePicture_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        cam.Dispose()
    End Sub

    Private Sub ExamineePicture_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim _skinManager As MaterialSkinManager = MaterialSkinManager.Instance
        _skinManager.AddFormToManage(Me)
        _skinManager.Theme = MaterialSkinManager.Themes.LIGHT
        _skinManager.ColorScheme = New ColorScheme(Primary.Blue600, Primary.Blue700, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)

        cboDevice.Items.AddRange(cam.GetCaptureDevices)
        If cboDevice.Items.Count > 0 Then cboDevice.SelectedIndex = 0

        For Each sz As String In [Enum].GetNames(GetType(DSCamCapture.FrameSizes))
            cboFrameSize.Items.Add(sz.Replace("s", ""))
        Next
        If cboFrameSize.Items.Count > 2 Then cboFrameSize.SelectedIndex = 2

        btnConnect.Enabled = (cboDevice.Items.Count > 0)
        btnCapture.Enabled = False

        ' This is where my code starts
        ' Hide picCapture
        picCapture.Visible = False

        ' Hide btnRetake and connect button since we're automatically connecting
        btnRetake.Visible = False
        btnConnect.Visible = False

        ' Connect to Camera automatically
        ConnectCamera()

        rs.FindAllControls(Me)
    End Sub

    Private Sub ConnectCamera()

        If Not cam.IsConnected Then
            Dim si As Integer = cboFrameSize.SelectedIndex
            Dim SelectedSize As DSCamCapture.FrameSizes = CType(si, DSCamCapture.FrameSizes)
            If cam.ConnectToDevice(cboDevice.SelectedIndex, 15, picCamera.ClientSize, SelectedSize, picCamera.Handle) Then
                cam.Start()
                btnConnect.Text = "Disconnect"
            End If
        Else
            cam.Dispose()
            btnConnect.Text = "Connect"
        End If

        btnCapture.Enabled = cam.IsConnected
        cboDevice.Enabled = Not cam.IsConnected
        cboFrameSize.Enabled = Not cam.IsConnected
    End Sub

    Private Sub cboDevice_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDevice.DropDown
        cboDevice.Items.Clear()
        cboDevice.Items.AddRange(cam.GetCaptureDevices)
        btnConnect.Enabled = (cboDevice.Items.Count > 0)
        If cboDevice.SelectedIndex = -1 And cboDevice.Items.Count > 0 Then cboDevice.SelectedIndex = 0
    End Sub

    Private Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click
        If Not cam.IsConnected Then
            Dim si As Integer = cboFrameSize.SelectedIndex
            Dim SelectedSize As DSCamCapture.FrameSizes = CType(si, DSCamCapture.FrameSizes)
            If cam.ConnectToDevice(cboDevice.SelectedIndex, 15, picCamera.ClientSize, SelectedSize, picCamera.Handle) Then
                cam.Start()
                btnConnect.Text = "Disconnect"
            End If
        Else
            cam.Dispose()
            btnConnect.Text = "Connect"
        End If
        btnCapture.Enabled = cam.IsConnected
        cboDevice.Enabled = Not cam.IsConnected
        cboFrameSize.Enabled = Not cam.IsConnected
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCapture.Click
        If Not IO.Directory.Exists(MyPicturesFolder) Then IO.Directory.CreateDirectory(MyPicturesFolder)
        Dim fName As String = Now.ToString.Replace("/", "-").Replace(":", "-").Replace(" ", "_") & ".jpg"
        Dim SaveAs As String = IO.Path.Combine(MyPicturesFolder, fName)
        cam.SaveCurrentFrame(SaveAs, Imaging.ImageFormat.Jpeg)


        ' Capture button has been clicked
        hasClickedCapture = True
        ' Hide Capture button and then show Retake button
        btnCapture.Visible = False
        btnRetake.Visible = True
        ' Hide picCamera and show picCapture
        picCamera.Visible = False
        picCapture.Visible = True

    End Sub

    Private Sub picCamera_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles picCamera.SizeChanged
        cam.ResizeWindow(0, 0, picCamera.ClientSize.Width, picCamera.ClientSize.Height)
    End Sub

    Private Sub cam_FrameSaved(ByVal capImage As System.Drawing.Bitmap, ByVal imgPath As String) Handles cam.FrameSaved
        picCapture.Image = New Bitmap(capImage)
        ' Label2.Text = "Saved As - " & IO.Path.GetFileName(imgPath)
        ' Label3.Text = "Image Size - " & picCapture.Image.Size.ToString

        ' Saves it to a member variable
        examineePic = capImage
    End Sub

    ' Our function for saving
    Public Sub SaveExamineePic(ByVal capImage As System.Drawing.Bitmap)
        Dim arrImage As Byte()

        Using mstream As New System.IO.MemoryStream
            capImage.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            arrImage = mstream.GetBuffer()
            mstream.Close()
        End Using



        sql.AddParam("@examineePic", arrImage)
        sql.AddParam("@examineeDateID", lblExamineeDateID.Text)
        sql.ExecuteQuery("UPDATE tbl_examinee SET examineePic = @examineePic WHERE examineeDateID = @examineeDateID")

    End Sub

    Public Sub SaveExamineePic(ByVal capImage As System.Drawing.Bitmap, ByVal isRegisterClicked As String)

        ' If register ba pinindot or nah .. if register then go insert ze picture
        If isRegisterClicked <> 1 Then
            Exit Sub
        End If

        Dim arrImage As Byte()

        Using mstream As New System.IO.MemoryStream
            capImage.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            arrImage = mstream.GetBuffer()
            mstream.Close()
        End Using


        sql.AddParam("@examineePic", arrImage)
        sql.ExecuteQuery("UPDATE tbl_examinee SET examineePic = @examineePic WHERE examineeID = LAST_INSERT_ID()")

    End Sub

    ' Retakes the picture
    Private Sub btnRetake_Click(sender As Object, e As EventArgs) Handles btnRetake.Click
        'Sets it back to false so that it could not proceed
        hasClickedCapture = False

        If Not cam.IsConnected Then
            Dim si As Integer = cboFrameSize.SelectedIndex
            Dim SelectedSize As DSCamCapture.FrameSizes = CType(si, DSCamCapture.FrameSizes)
            If cam.ConnectToDevice(cboDevice.SelectedIndex, 15, picCamera.ClientSize, SelectedSize, picCamera.Handle) Then
                cam.Start()
                btnConnect.Text = "Disconnect"
            End If
        End If

        'Show capture button and hide retake button
        btnCapture.Visible = True
        btnRetake.Visible = False
        'Hide picCapture and show picCamera
        picCamera.Visible = True
        picCapture.Visible = False

    End Sub

    ' Proceed and save the picture
    Public Sub btnProceed_Click(sender As Object, e As EventArgs) Handles btnProceed.Click

        If hasClickedCapture = False Then
            MessageBox.Show("Picture Not Saved")
            Exit Sub
        End If

        ' Save to database
        SaveExamineePic(examineePic)

        AdminDashboard.lblExamineePicChanged.Text = 1
        AdminDashboard.picExaminee.Image = examineePic
        AdminDashboard.LoadExamineeDgv()

        Me.Close()
    End Sub

    Private Sub ExamineePicture_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        rs.ResizeAllControls(Me)
    End Sub

End Class