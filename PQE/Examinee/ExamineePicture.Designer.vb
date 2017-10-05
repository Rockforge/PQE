<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExamineePicture
    Inherits MaterialSkin.Controls.MaterialForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cboDevice = New System.Windows.Forms.ComboBox()
        Me.cboFrameSize = New System.Windows.Forms.ComboBox()
        Me.btnConnect = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnCapture = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnProceed = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.picCapture = New System.Windows.Forms.PictureBox()
        Me.btnRetake = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.picCamera = New System.Windows.Forms.PictureBox()
        Me.lblExamineeDateID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.picCapture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCamera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboDevice
        '
        Me.cboDevice.FormattingEnabled = True
        Me.cboDevice.Location = New System.Drawing.Point(12, 79)
        Me.cboDevice.Name = "cboDevice"
        Me.cboDevice.Size = New System.Drawing.Size(121, 21)
        Me.cboDevice.TabIndex = 0
        Me.cboDevice.Visible = False
        '
        'cboFrameSize
        '
        Me.cboFrameSize.FormattingEnabled = True
        Me.cboFrameSize.Location = New System.Drawing.Point(12, 106)
        Me.cboFrameSize.Name = "cboFrameSize"
        Me.cboFrameSize.Size = New System.Drawing.Size(121, 21)
        Me.cboFrameSize.TabIndex = 0
        Me.cboFrameSize.Visible = False
        '
        'btnConnect
        '
        Me.btnConnect.Depth = 0
        Me.btnConnect.Location = New System.Drawing.Point(12, 146)
        Me.btnConnect.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Primary = True
        Me.btnConnect.Size = New System.Drawing.Size(75, 23)
        Me.btnConnect.TabIndex = 1
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        Me.btnConnect.Visible = False
        '
        'btnCapture
        '
        Me.btnCapture.Depth = 0
        Me.btnCapture.Location = New System.Drawing.Point(294, 325)
        Me.btnCapture.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnCapture.Name = "btnCapture"
        Me.btnCapture.Primary = True
        Me.btnCapture.Size = New System.Drawing.Size(75, 23)
        Me.btnCapture.TabIndex = 2
        Me.btnCapture.Text = "Capture"
        Me.btnCapture.UseVisualStyleBackColor = True
        '
        'btnProceed
        '
        Me.btnProceed.Depth = 0
        Me.btnProceed.Location = New System.Drawing.Point(553, 388)
        Me.btnProceed.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnProceed.Name = "btnProceed"
        Me.btnProceed.Primary = True
        Me.btnProceed.Size = New System.Drawing.Size(75, 23)
        Me.btnProceed.TabIndex = 3
        Me.btnProceed.Text = "Proceed"
        Me.btnProceed.UseVisualStyleBackColor = True
        '
        'picCapture
        '
        Me.picCapture.Location = New System.Drawing.Point(169, 79)
        Me.picCapture.Name = "picCapture"
        Me.picCapture.Size = New System.Drawing.Size(320, 240)
        Me.picCapture.TabIndex = 4
        Me.picCapture.TabStop = False
        '
        'btnRetake
        '
        Me.btnRetake.Depth = 0
        Me.btnRetake.Location = New System.Drawing.Point(294, 325)
        Me.btnRetake.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnRetake.Name = "btnRetake"
        Me.btnRetake.Primary = True
        Me.btnRetake.Size = New System.Drawing.Size(75, 23)
        Me.btnRetake.TabIndex = 2
        Me.btnRetake.Text = "Retake"
        Me.btnRetake.UseVisualStyleBackColor = True
        '
        'picCamera
        '
        Me.picCamera.Location = New System.Drawing.Point(169, 79)
        Me.picCamera.Name = "picCamera"
        Me.picCamera.Size = New System.Drawing.Size(320, 240)
        Me.picCamera.TabIndex = 5
        Me.picCamera.TabStop = False
        '
        'lblExamineeDateID
        '
        Me.lblExamineeDateID.AutoSize = True
        Me.lblExamineeDateID.Location = New System.Drawing.Point(12, 130)
        Me.lblExamineeDateID.Name = "lblExamineeDateID"
        Me.lblExamineeDateID.Size = New System.Drawing.Size(87, 13)
        Me.lblExamineeDateID.TabIndex = 6
        Me.lblExamineeDateID.Text = "ExamineeDateID"
        Me.lblExamineeDateID.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 191)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "picCapture is behind picCamera"
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(291, 361)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(195, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Button Capture is behind Button Retake"
        Me.Label2.Visible = False
        '
        'ExamineePicture
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 425)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblExamineeDateID)
        Me.Controls.Add(Me.picCamera)
        Me.Controls.Add(Me.picCapture)
        Me.Controls.Add(Me.btnProceed)
        Me.Controls.Add(Me.btnRetake)
        Me.Controls.Add(Me.btnCapture)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.cboFrameSize)
        Me.Controls.Add(Me.cboDevice)
        Me.Name = "ExamineePicture"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Examinee Picture"
        CType(Me.picCapture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCamera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboDevice As ComboBox
    Friend WithEvents cboFrameSize As ComboBox
    Friend WithEvents btnConnect As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnCapture As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnProceed As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents picCapture As PictureBox
    Friend WithEvents btnRetake As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents picCamera As PictureBox
    Friend WithEvents lblExamineeDateID As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
