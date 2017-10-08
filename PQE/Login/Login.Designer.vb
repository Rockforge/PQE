<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits MaterialSkin.Controls.MaterialForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnLogin = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtExamineeDateID = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtLastName = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MaterialDivider1 = New MaterialSkin.Controls.MaterialDivider()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmsConnection = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ChangeConnectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtServerIP = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnServerIPChange = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsConnection.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.Depth = 0
        Me.btnLogin.Location = New System.Drawing.Point(57, 386)
        Me.btnLogin.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Primary = True
        Me.btnLogin.Size = New System.Drawing.Size(233, 46)
        Me.btnLogin.TabIndex = 0
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PQE.My.Resources.Resources.dost
        Me.PictureBox1.Location = New System.Drawing.Point(120, 78)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(45, 275)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Examinee/User ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(140, 520)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 9)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Developed by:"
        '
        'txtExamineeDateID
        '
        Me.txtExamineeDateID.Depth = 0
        Me.txtExamineeDateID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExamineeDateID.Hint = ""
        Me.txtExamineeDateID.Location = New System.Drawing.Point(48, 297)
        Me.txtExamineeDateID.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtExamineeDateID.Name = "txtExamineeDateID"
        Me.txtExamineeDateID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtExamineeDateID.SelectedText = ""
        Me.txtExamineeDateID.SelectionLength = 0
        Me.txtExamineeDateID.SelectionStart = 0
        Me.txtExamineeDateID.Size = New System.Drawing.Size(249, 23)
        Me.txtExamineeDateID.TabIndex = 3
        Me.txtExamineeDateID.UseSystemPasswordChar = False
        '
        'txtLastName
        '
        Me.txtLastName.Depth = 0
        Me.txtLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Hint = ""
        Me.txtLastName.Location = New System.Drawing.Point(48, 343)
        Me.txtLastName.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLastName.SelectedText = ""
        Me.txtLastName.SelectionLength = 0
        Me.txtLastName.SelectionStart = 0
        Me.txtLastName.Size = New System.Drawing.Size(249, 23)
        Me.txtLastName.TabIndex = 3
        Me.txtLastName.UseSystemPasswordChar = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Location = New System.Drawing.Point(137, 224)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Login"
        '
        'MaterialDivider1
        '
        Me.MaterialDivider1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider1.Depth = 0
        Me.MaterialDivider1.Location = New System.Drawing.Point(20, 507)
        Me.MaterialDivider1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider1.Name = "MaterialDivider1"
        Me.MaterialDivider1.Size = New System.Drawing.Size(295, 1)
        Me.MaterialDivider1.TabIndex = 5
        Me.MaterialDivider1.Text = "MaterialDivider1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label4.Location = New System.Drawing.Point(164, 533)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(153, 12)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Visual Studio, MySQL, MaterialSkin"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label5.Location = New System.Drawing.Point(203, 519)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 12)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "ITerate Development Team"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label6.Location = New System.Drawing.Point(106, 533)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 9)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Powered by:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label7.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label7.Location = New System.Drawing.Point(45, 322)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Last Name"
        '
        'cmsConnection
        '
        Me.cmsConnection.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeConnectionToolStripMenuItem})
        Me.cmsConnection.Name = "cmsConnection"
        Me.cmsConnection.Size = New System.Drawing.Size(179, 26)
        '
        'ChangeConnectionToolStripMenuItem
        '
        Me.ChangeConnectionToolStripMenuItem.Name = "ChangeConnectionToolStripMenuItem"
        Me.ChangeConnectionToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.ChangeConnectionToolStripMenuItem.Text = "Change connection"
        '
        'txtServerIP
        '
        Me.txtServerIP.Location = New System.Drawing.Point(120, 252)
        Me.txtServerIP.Name = "txtServerIP"
        Me.txtServerIP.Size = New System.Drawing.Size(100, 20)
        Me.txtServerIP.TabIndex = 7
        Me.txtServerIP.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(59, 255)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Server IP:"
        Me.Label8.Visible = False
        '
        'btnServerIPChange
        '
        Me.btnServerIPChange.Location = New System.Drawing.Point(226, 250)
        Me.btnServerIPChange.Name = "btnServerIPChange"
        Me.btnServerIPChange.Size = New System.Drawing.Size(75, 23)
        Me.btnServerIPChange.TabIndex = 9
        Me.btnServerIPChange.Text = "Change"
        Me.btnServerIPChange.UseVisualStyleBackColor = True
        Me.btnServerIPChange.Visible = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 551)
        Me.ContextMenuStrip = Me.cmsConnection
        Me.Controls.Add(Me.btnServerIPChange)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtServerIP)
        Me.Controls.Add(Me.MaterialDivider1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtExamineeDateID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnLogin)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "         D.O.S.T - Pre-Qualification Exam"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsConnection.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLogin As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtExamineeDateID As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtLastName As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label3 As Label
    Friend WithEvents MaterialDivider1 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cmsConnection As ContextMenuStrip
    Friend WithEvents ChangeConnectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtServerIP As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnServerIPChange As Button
End Class
