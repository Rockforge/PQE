<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminTempDashboard
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnUserManual = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnBackLogin = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.sfdBackup = New System.Windows.Forms.SaveFileDialog()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.MaterialDivider4 = New MaterialSkin.Controls.MaterialDivider()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.MaterialDivider1 = New MaterialSkin.Controls.MaterialDivider()
        Me.txtEmailAddress = New PQE.TextBoxEx()
        Me.lblEmailError = New System.Windows.Forms.Label()
        Me.lblLastNameError = New System.Windows.Forms.Label()
        Me.lblFirstNameError = New System.Windows.Forms.Label()
        Me.lblExamineeDateID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLastName = New PQE.TextBoxEx()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFirstName = New PQE.TextBoxEx()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnExamineeRegister = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnExamineeClear = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnExamineeEdit = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnChangePicture = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.picExaminee = New System.Windows.Forms.PictureBox()
        Me.MaterialDivider10 = New MaterialSkin.Controls.MaterialDivider()
        Me.MaterialDivider11 = New MaterialSkin.Controls.MaterialDivider()
        Me.MaterialDivider5 = New MaterialSkin.Controls.MaterialDivider()
        Me.MaterialDivider8 = New MaterialSkin.Controls.MaterialDivider()
        Me.MaterialDivider9 = New MaterialSkin.Controls.MaterialDivider()
        Me.MaterialDivider7 = New MaterialSkin.Controls.MaterialDivider()
        Me.rbClericalActive = New MaterialSkin.Controls.MaterialRadioButton()
        Me.rbNonSupervisoryActive = New MaterialSkin.Controls.MaterialRadioButton()
        Me.rbSupervisoryActive = New MaterialSkin.Controls.MaterialRadioButton()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.cboSupervisoryPosition = New System.Windows.Forms.ComboBox()
        Me.cboNonSupervisoryPosition = New System.Windows.Forms.ComboBox()
        Me.cboClericalPosition = New System.Windows.Forms.ComboBox()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.txtClericalResultB = New System.Windows.Forms.Label()
        Me.txtNonSupervisoryResultB = New System.Windows.Forms.Label()
        Me.txtClericalResultC = New System.Windows.Forms.Label()
        Me.txtSupervisoryResultB = New System.Windows.Forms.Label()
        Me.txtNonSupervisoryResultC = New System.Windows.Forms.Label()
        Me.txtClericalResultA = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.txtNonSupervisoryResultA = New System.Windows.Forms.Label()
        Me.txtSupervisoryResultC = New System.Windows.Forms.Label()
        Me.txtSupervisoryResultA = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.lblExamineeError = New System.Windows.Forms.Label()
        Me.picExamineeError = New System.Windows.Forms.PictureBox()
        Me.dgvExaminee = New System.Windows.Forms.DataGridView()
        Me.lblExamineeCount = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.btnExportToExcel = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.sfdExcel = New System.Windows.Forms.SaveFileDialog()
        Me.btnRefreshExamineeDgv = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnPrintExamineeDgv = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtExamineeIDFilter = New System.Windows.Forms.TextBox()
        Me.MaterialDivider6 = New MaterialSkin.Controls.MaterialDivider()
        Me.rbNoResultFilter = New System.Windows.Forms.RadioButton()
        Me.rbFailedFilter = New System.Windows.Forms.RadioButton()
        Me.rbPassedFilter = New System.Windows.Forms.RadioButton()
        Me.chkDateFilter = New System.Windows.Forms.CheckBox()
        Me.dtpToFilter = New System.Windows.Forms.DateTimePicker()
        Me.dtpFromFilter = New System.Windows.Forms.DateTimePicker()
        Me.btnSearch = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnClearFilter = New MaterialSkin.Controls.MaterialFlatButton()
        Me.cboPositionFilter = New System.Windows.Forms.ComboBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.txtFirstNameFilter = New System.Windows.Forms.TextBox()
        Me.txtLastNameFilter = New System.Windows.Forms.TextBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.MaterialDivider12 = New MaterialSkin.Controls.MaterialDivider()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picExaminee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picExamineeError, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvExaminee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PQE.My.Resources.Resources.dost
        Me.PictureBox1.Location = New System.Drawing.Point(12, 74)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'btnUserManual
        '
        Me.btnUserManual.Depth = 0
        Me.btnUserManual.Location = New System.Drawing.Point(1158, 136)
        Me.btnUserManual.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnUserManual.Name = "btnUserManual"
        Me.btnUserManual.Primary = True
        Me.btnUserManual.Size = New System.Drawing.Size(112, 37)
        Me.btnUserManual.TabIndex = 18
        Me.btnUserManual.Text = "User Manual"
        Me.btnUserManual.UseVisualStyleBackColor = True
        '
        'btnBackLogin
        '
        Me.btnBackLogin.Depth = 0
        Me.btnBackLogin.Location = New System.Drawing.Point(1157, 74)
        Me.btnBackLogin.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnBackLogin.Name = "btnBackLogin"
        Me.btnBackLogin.Primary = True
        Me.btnBackLogin.Size = New System.Drawing.Size(112, 37)
        Me.btnBackLogin.TabIndex = 17
        Me.btnBackLogin.Text = "Back to Login"
        Me.btnBackLogin.UseVisualStyleBackColor = True
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(119, 136)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(399, 31)
        Me.Label33.TabIndex = 47
        Me.Label33.Text = "Pre-Qualification Examination"
        '
        'MaterialDivider4
        '
        Me.MaterialDivider4.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider4.Depth = 0
        Me.MaterialDivider4.Location = New System.Drawing.Point(119, 120)
        Me.MaterialDivider4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider4.Name = "MaterialDivider4"
        Me.MaterialDivider4.Size = New System.Drawing.Size(1151, 6)
        Me.MaterialDivider4.TabIndex = 46
        Me.MaterialDivider4.Text = "MaterialDivider3"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(118, 87)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(653, 24)
        Me.Label31.TabIndex = 45
        Me.Label31.Text = "Republic of the Philippines - Department Of Science and Technology"
        '
        'MaterialDivider1
        '
        Me.MaterialDivider1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider1.Depth = 0
        Me.MaterialDivider1.Location = New System.Drawing.Point(16, 187)
        Me.MaterialDivider1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider1.Name = "MaterialDivider1"
        Me.MaterialDivider1.Size = New System.Drawing.Size(1250, 1)
        Me.MaterialDivider1.TabIndex = 48
        Me.MaterialDivider1.Text = "MaterialDivider1"
        '
        'txtEmailAddress
        '
        Me.txtEmailAddress.Location = New System.Drawing.Point(792, 334)
        Me.txtEmailAddress.Name = "txtEmailAddress"
        Me.txtEmailAddress.Size = New System.Drawing.Size(294, 20)
        Me.txtEmailAddress.TabIndex = 59
        '
        'lblEmailError
        '
        Me.lblEmailError.AutoSize = True
        Me.lblEmailError.ForeColor = System.Drawing.Color.Tomato
        Me.lblEmailError.Location = New System.Drawing.Point(959, 354)
        Me.lblEmailError.Name = "lblEmailError"
        Me.lblEmailError.Size = New System.Drawing.Size(127, 13)
        Me.lblEmailError.TabIndex = 56
        Me.lblEmailError.Text = "(Only accepts valid email)"
        Me.lblEmailError.Visible = False
        '
        'lblLastNameError
        '
        Me.lblLastNameError.AutoSize = True
        Me.lblLastNameError.ForeColor = System.Drawing.Color.Tomato
        Me.lblLastNameError.Location = New System.Drawing.Point(855, 314)
        Me.lblLastNameError.Name = "lblLastNameError"
        Me.lblLastNameError.Size = New System.Drawing.Size(231, 13)
        Me.lblLastNameError.TabIndex = 57
        Me.lblLastNameError.Text = "(Only accepts letters, apostrophes, and dashes)"
        Me.lblLastNameError.Visible = False
        '
        'lblFirstNameError
        '
        Me.lblFirstNameError.AutoSize = True
        Me.lblFirstNameError.ForeColor = System.Drawing.Color.Tomato
        Me.lblFirstNameError.Location = New System.Drawing.Point(855, 272)
        Me.lblFirstNameError.Name = "lblFirstNameError"
        Me.lblFirstNameError.Size = New System.Drawing.Size(231, 13)
        Me.lblFirstNameError.TabIndex = 58
        Me.lblFirstNameError.Text = "(Only accepts letters, apostrophes, and dashes)"
        Me.lblFirstNameError.Visible = False
        '
        'lblExamineeDateID
        '
        Me.lblExamineeDateID.AutoSize = True
        Me.lblExamineeDateID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExamineeDateID.Location = New System.Drawing.Point(792, 224)
        Me.lblExamineeDateID.Name = "lblExamineeDateID"
        Me.lblExamineeDateID.Size = New System.Drawing.Size(0, 16)
        Me.lblExamineeDateID.TabIndex = 54
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(699, 225)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 16)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Examinee ID:"
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(792, 292)
        Me.txtLastName.MaxLength = 50
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(294, 22)
        Me.txtLastName.TabIndex = 55
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(709, 251)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 16)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "First Name:"
        '
        'txtFirstName
        '
        Me.txtFirstName.BackColor = System.Drawing.Color.LightCyan
        Me.txtFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(792, 250)
        Me.txtFirstName.MaxLength = 50
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(294, 22)
        Me.txtFirstName.TabIndex = 51
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(685, 335)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(99, 16)
        Me.Label38.TabIndex = 52
        Me.Label38.Text = "Email Address:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(711, 293)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 16)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Last Name:"
        '
        'btnExamineeRegister
        '
        Me.btnExamineeRegister.Depth = 0
        Me.btnExamineeRegister.Location = New System.Drawing.Point(1104, 260)
        Me.btnExamineeRegister.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnExamineeRegister.Name = "btnExamineeRegister"
        Me.btnExamineeRegister.Primary = True
        Me.btnExamineeRegister.Size = New System.Drawing.Size(130, 36)
        Me.btnExamineeRegister.TabIndex = 60
        Me.btnExamineeRegister.Text = "Register"
        Me.btnExamineeRegister.UseVisualStyleBackColor = True
        '
        'btnExamineeClear
        '
        Me.btnExamineeClear.Depth = 0
        Me.btnExamineeClear.Location = New System.Drawing.Point(1104, 302)
        Me.btnExamineeClear.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnExamineeClear.Name = "btnExamineeClear"
        Me.btnExamineeClear.Primary = True
        Me.btnExamineeClear.Size = New System.Drawing.Size(130, 36)
        Me.btnExamineeClear.TabIndex = 61
        Me.btnExamineeClear.Text = "Clear Fields"
        Me.btnExamineeClear.UseVisualStyleBackColor = True
        '
        'btnExamineeEdit
        '
        Me.btnExamineeEdit.Depth = 0
        Me.btnExamineeEdit.Location = New System.Drawing.Point(1104, 342)
        Me.btnExamineeEdit.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnExamineeEdit.Name = "btnExamineeEdit"
        Me.btnExamineeEdit.Primary = True
        Me.btnExamineeEdit.Size = New System.Drawing.Size(130, 36)
        Me.btnExamineeEdit.TabIndex = 62
        Me.btnExamineeEdit.Text = "Edit"
        Me.btnExamineeEdit.UseVisualStyleBackColor = True
        '
        'btnChangePicture
        '
        Me.btnChangePicture.Depth = 0
        Me.btnChangePicture.Location = New System.Drawing.Point(538, 341)
        Me.btnChangePicture.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnChangePicture.Name = "btnChangePicture"
        Me.btnChangePicture.Primary = True
        Me.btnChangePicture.Size = New System.Drawing.Size(120, 26)
        Me.btnChangePicture.TabIndex = 64
        Me.btnChangePicture.Text = "Change Picture"
        Me.btnChangePicture.UseVisualStyleBackColor = True
        '
        'picExaminee
        '
        Me.picExaminee.BackColor = System.Drawing.Color.DimGray
        Me.picExaminee.Image = Global.PQE.My.Resources.Resources.NoExamineePic
        Me.picExaminee.Location = New System.Drawing.Point(538, 218)
        Me.picExaminee.Name = "picExaminee"
        Me.picExaminee.Size = New System.Drawing.Size(120, 120)
        Me.picExaminee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picExaminee.TabIndex = 63
        Me.picExaminee.TabStop = False
        '
        'MaterialDivider10
        '
        Me.MaterialDivider10.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider10.Depth = 0
        Me.MaterialDivider10.Location = New System.Drawing.Point(564, 628)
        Me.MaterialDivider10.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider10.Name = "MaterialDivider10"
        Me.MaterialDivider10.Size = New System.Drawing.Size(650, 2)
        Me.MaterialDivider10.TabIndex = 100
        Me.MaterialDivider10.Text = "MaterialDivider10"
        '
        'MaterialDivider11
        '
        Me.MaterialDivider11.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider11.Depth = 0
        Me.MaterialDivider11.Location = New System.Drawing.Point(661, 640)
        Me.MaterialDivider11.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider11.Name = "MaterialDivider11"
        Me.MaterialDivider11.Size = New System.Drawing.Size(1, 65)
        Me.MaterialDivider11.TabIndex = 99
        Me.MaterialDivider11.Text = "MaterialDivider10"
        '
        'MaterialDivider5
        '
        Me.MaterialDivider5.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider5.Depth = 0
        Me.MaterialDivider5.Location = New System.Drawing.Point(511, 400)
        Me.MaterialDivider5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider5.Name = "MaterialDivider5"
        Me.MaterialDivider5.Size = New System.Drawing.Size(730, 2)
        Me.MaterialDivider5.TabIndex = 98
        Me.MaterialDivider5.Text = "MaterialDivider10"
        '
        'MaterialDivider8
        '
        Me.MaterialDivider8.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider8.Depth = 0
        Me.MaterialDivider8.Location = New System.Drawing.Point(661, 414)
        Me.MaterialDivider8.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider8.Name = "MaterialDivider8"
        Me.MaterialDivider8.Size = New System.Drawing.Size(1, 65)
        Me.MaterialDivider8.TabIndex = 97
        Me.MaterialDivider8.Text = "MaterialDivider10"
        '
        'MaterialDivider9
        '
        Me.MaterialDivider9.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider9.Depth = 0
        Me.MaterialDivider9.Location = New System.Drawing.Point(564, 511)
        Me.MaterialDivider9.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider9.Name = "MaterialDivider9"
        Me.MaterialDivider9.Size = New System.Drawing.Size(650, 2)
        Me.MaterialDivider9.TabIndex = 96
        Me.MaterialDivider9.Text = "MaterialDivider10"
        '
        'MaterialDivider7
        '
        Me.MaterialDivider7.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider7.Depth = 0
        Me.MaterialDivider7.Location = New System.Drawing.Point(661, 523)
        Me.MaterialDivider7.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider7.Name = "MaterialDivider7"
        Me.MaterialDivider7.Size = New System.Drawing.Size(1, 65)
        Me.MaterialDivider7.TabIndex = 95
        Me.MaterialDivider7.Text = "MaterialDivider10"
        '
        'rbClericalActive
        '
        Me.rbClericalActive.AutoSize = True
        Me.rbClericalActive.Depth = 0
        Me.rbClericalActive.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rbClericalActive.Location = New System.Drawing.Point(582, 662)
        Me.rbClericalActive.Margin = New System.Windows.Forms.Padding(0)
        Me.rbClericalActive.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rbClericalActive.MouseState = MaterialSkin.MouseState.HOVER
        Me.rbClericalActive.Name = "rbClericalActive"
        Me.rbClericalActive.Ripple = True
        Me.rbClericalActive.Size = New System.Drawing.Size(68, 30)
        Me.rbClericalActive.TabIndex = 92
        Me.rbClericalActive.TabStop = True
        Me.rbClericalActive.Text = "Active"
        Me.rbClericalActive.UseVisualStyleBackColor = True
        '
        'rbNonSupervisoryActive
        '
        Me.rbNonSupervisoryActive.AutoSize = True
        Me.rbNonSupervisoryActive.Depth = 0
        Me.rbNonSupervisoryActive.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rbNonSupervisoryActive.Location = New System.Drawing.Point(581, 545)
        Me.rbNonSupervisoryActive.Margin = New System.Windows.Forms.Padding(0)
        Me.rbNonSupervisoryActive.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rbNonSupervisoryActive.MouseState = MaterialSkin.MouseState.HOVER
        Me.rbNonSupervisoryActive.Name = "rbNonSupervisoryActive"
        Me.rbNonSupervisoryActive.Ripple = True
        Me.rbNonSupervisoryActive.Size = New System.Drawing.Size(68, 30)
        Me.rbNonSupervisoryActive.TabIndex = 93
        Me.rbNonSupervisoryActive.TabStop = True
        Me.rbNonSupervisoryActive.Text = "Active"
        Me.rbNonSupervisoryActive.UseVisualStyleBackColor = True
        '
        'rbSupervisoryActive
        '
        Me.rbSupervisoryActive.AutoSize = True
        Me.rbSupervisoryActive.Depth = 0
        Me.rbSupervisoryActive.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rbSupervisoryActive.Location = New System.Drawing.Point(581, 433)
        Me.rbSupervisoryActive.Margin = New System.Windows.Forms.Padding(0)
        Me.rbSupervisoryActive.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rbSupervisoryActive.MouseState = MaterialSkin.MouseState.HOVER
        Me.rbSupervisoryActive.Name = "rbSupervisoryActive"
        Me.rbSupervisoryActive.Ripple = True
        Me.rbSupervisoryActive.Size = New System.Drawing.Size(68, 30)
        Me.rbSupervisoryActive.TabIndex = 94
        Me.rbSupervisoryActive.TabStop = True
        Me.rbSupervisoryActive.Text = "Active"
        Me.rbSupervisoryActive.UseVisualStyleBackColor = True
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.Location = New System.Drawing.Point(716, 603)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(43, 16)
        Me.Label59.TabIndex = 89
        Me.Label59.Text = "Set C:"
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.Location = New System.Drawing.Point(716, 579)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(43, 16)
        Me.Label60.TabIndex = 90
        Me.Label60.Text = "Set B:"
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.Location = New System.Drawing.Point(716, 556)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(43, 16)
        Me.Label61.TabIndex = 91
        Me.Label61.Text = "Set A:"
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.Location = New System.Drawing.Point(716, 720)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(43, 16)
        Me.Label56.TabIndex = 86
        Me.Label56.Text = "Set C:"
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.Location = New System.Drawing.Point(716, 697)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(43, 16)
        Me.Label57.TabIndex = 87
        Me.Label57.Text = "Set B:"
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.Location = New System.Drawing.Point(716, 674)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(43, 16)
        Me.Label58.TabIndex = 88
        Me.Label58.Text = "Set A:"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.Location = New System.Drawing.Point(671, 646)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(88, 16)
        Me.Label52.TabIndex = 85
        Me.Label52.Text = "Position Title:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(671, 527)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 16)
        Me.Label5.TabIndex = 84
        Me.Label5.Text = "Position Title:"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.Location = New System.Drawing.Point(598, 641)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(61, 16)
        Me.Label51.TabIndex = 83
        Me.Label51.Text = "Clerical"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.Location = New System.Drawing.Point(535, 523)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(124, 16)
        Me.Label50.TabIndex = 82
        Me.Label50.Text = "Non-Supervisory"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(564, 413)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(91, 16)
        Me.Label49.TabIndex = 81
        Me.Label49.Text = "Supervisory"
        '
        'cboSupervisoryPosition
        '
        Me.cboSupervisoryPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSupervisoryPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSupervisoryPosition.FormattingEnabled = True
        Me.cboSupervisoryPosition.Location = New System.Drawing.Point(762, 413)
        Me.cboSupervisoryPosition.Name = "cboSupervisoryPosition"
        Me.cboSupervisoryPosition.Size = New System.Drawing.Size(294, 24)
        Me.cboSupervisoryPosition.TabIndex = 80
        '
        'cboNonSupervisoryPosition
        '
        Me.cboNonSupervisoryPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNonSupervisoryPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNonSupervisoryPosition.FormattingEnabled = True
        Me.cboNonSupervisoryPosition.Location = New System.Drawing.Point(762, 523)
        Me.cboNonSupervisoryPosition.Name = "cboNonSupervisoryPosition"
        Me.cboNonSupervisoryPosition.Size = New System.Drawing.Size(294, 24)
        Me.cboNonSupervisoryPosition.TabIndex = 79
        '
        'cboClericalPosition
        '
        Me.cboClericalPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboClericalPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboClericalPosition.FormattingEnabled = True
        Me.cboClericalPosition.Location = New System.Drawing.Point(762, 641)
        Me.cboClericalPosition.Name = "cboClericalPosition"
        Me.cboClericalPosition.Size = New System.Drawing.Size(294, 24)
        Me.cboClericalPosition.TabIndex = 78
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.Location = New System.Drawing.Point(716, 489)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(43, 16)
        Me.Label55.TabIndex = 66
        Me.Label55.Text = "Set C:"
        '
        'txtClericalResultB
        '
        Me.txtClericalResultB.AutoSize = True
        Me.txtClericalResultB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClericalResultB.Location = New System.Drawing.Point(765, 697)
        Me.txtClericalResultB.Name = "txtClericalResultB"
        Me.txtClericalResultB.Size = New System.Drawing.Size(31, 16)
        Me.txtClericalResultB.TabIndex = 67
        Me.txtClericalResultB.Text = "N/A"
        '
        'txtNonSupervisoryResultB
        '
        Me.txtNonSupervisoryResultB.AutoSize = True
        Me.txtNonSupervisoryResultB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNonSupervisoryResultB.Location = New System.Drawing.Point(765, 579)
        Me.txtNonSupervisoryResultB.Name = "txtNonSupervisoryResultB"
        Me.txtNonSupervisoryResultB.Size = New System.Drawing.Size(31, 16)
        Me.txtNonSupervisoryResultB.TabIndex = 68
        Me.txtNonSupervisoryResultB.Text = "N/A"
        '
        'txtClericalResultC
        '
        Me.txtClericalResultC.AutoSize = True
        Me.txtClericalResultC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClericalResultC.Location = New System.Drawing.Point(765, 720)
        Me.txtClericalResultC.Name = "txtClericalResultC"
        Me.txtClericalResultC.Size = New System.Drawing.Size(31, 16)
        Me.txtClericalResultC.TabIndex = 71
        Me.txtClericalResultC.Text = "N/A"
        '
        'txtSupervisoryResultB
        '
        Me.txtSupervisoryResultB.AutoSize = True
        Me.txtSupervisoryResultB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupervisoryResultB.Location = New System.Drawing.Point(765, 466)
        Me.txtSupervisoryResultB.Name = "txtSupervisoryResultB"
        Me.txtSupervisoryResultB.Size = New System.Drawing.Size(31, 16)
        Me.txtSupervisoryResultB.TabIndex = 69
        Me.txtSupervisoryResultB.Text = "N/A"
        '
        'txtNonSupervisoryResultC
        '
        Me.txtNonSupervisoryResultC.AutoSize = True
        Me.txtNonSupervisoryResultC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNonSupervisoryResultC.Location = New System.Drawing.Point(765, 603)
        Me.txtNonSupervisoryResultC.Name = "txtNonSupervisoryResultC"
        Me.txtNonSupervisoryResultC.Size = New System.Drawing.Size(31, 16)
        Me.txtNonSupervisoryResultC.TabIndex = 70
        Me.txtNonSupervisoryResultC.Text = "N/A"
        '
        'txtClericalResultA
        '
        Me.txtClericalResultA.AutoSize = True
        Me.txtClericalResultA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClericalResultA.Location = New System.Drawing.Point(765, 674)
        Me.txtClericalResultA.Name = "txtClericalResultA"
        Me.txtClericalResultA.Size = New System.Drawing.Size(31, 16)
        Me.txtClericalResultA.TabIndex = 76
        Me.txtClericalResultA.Text = "N/A"
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.Location = New System.Drawing.Point(716, 466)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(43, 16)
        Me.Label54.TabIndex = 72
        Me.Label54.Text = "Set B:"
        '
        'txtNonSupervisoryResultA
        '
        Me.txtNonSupervisoryResultA.AutoSize = True
        Me.txtNonSupervisoryResultA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNonSupervisoryResultA.Location = New System.Drawing.Point(765, 556)
        Me.txtNonSupervisoryResultA.Name = "txtNonSupervisoryResultA"
        Me.txtNonSupervisoryResultA.Size = New System.Drawing.Size(31, 16)
        Me.txtNonSupervisoryResultA.TabIndex = 73
        Me.txtNonSupervisoryResultA.Text = "N/A"
        '
        'txtSupervisoryResultC
        '
        Me.txtSupervisoryResultC.AutoSize = True
        Me.txtSupervisoryResultC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupervisoryResultC.Location = New System.Drawing.Point(765, 489)
        Me.txtSupervisoryResultC.Name = "txtSupervisoryResultC"
        Me.txtSupervisoryResultC.Size = New System.Drawing.Size(31, 16)
        Me.txtSupervisoryResultC.TabIndex = 74
        Me.txtSupervisoryResultC.Text = "N/A"
        '
        'txtSupervisoryResultA
        '
        Me.txtSupervisoryResultA.AutoSize = True
        Me.txtSupervisoryResultA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupervisoryResultA.Location = New System.Drawing.Point(765, 443)
        Me.txtSupervisoryResultA.Name = "txtSupervisoryResultA"
        Me.txtSupervisoryResultA.Size = New System.Drawing.Size(31, 16)
        Me.txtSupervisoryResultA.TabIndex = 75
        Me.txtSupervisoryResultA.Text = "N/A"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.Location = New System.Drawing.Point(716, 443)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(43, 16)
        Me.Label53.TabIndex = 77
        Me.Label53.Text = "Set A:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(671, 416)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Position Title:"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(1089, 240)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(170, 13)
        Me.Label34.TabIndex = 112
        Me.Label34.Text = "Register Button behind Edit Button"
        Me.Label34.Visible = False
        '
        'lblExamineeError
        '
        Me.lblExamineeError.AutoSize = True
        Me.lblExamineeError.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExamineeError.Location = New System.Drawing.Point(1148, 218)
        Me.lblExamineeError.Name = "lblExamineeError"
        Me.lblExamineeError.Size = New System.Drawing.Size(97, 16)
        Me.lblExamineeError.TabIndex = 111
        Me.lblExamineeError.Text = "Error Message"
        Me.lblExamineeError.Visible = False
        '
        'picExamineeError
        '
        Me.picExamineeError.Image = Global.PQE.My.Resources.Resources.error1
        Me.picExamineeError.Location = New System.Drawing.Point(1092, 204)
        Me.picExamineeError.Name = "picExamineeError"
        Me.picExamineeError.Size = New System.Drawing.Size(50, 50)
        Me.picExamineeError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picExamineeError.TabIndex = 110
        Me.picExamineeError.TabStop = False
        Me.picExamineeError.Visible = False
        '
        'dgvExaminee
        '
        Me.dgvExaminee.AllowUserToAddRows = False
        Me.dgvExaminee.AllowUserToDeleteRows = False
        Me.dgvExaminee.AllowUserToResizeColumns = False
        Me.dgvExaminee.AllowUserToResizeRows = False
        Me.dgvExaminee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvExaminee.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvExaminee.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvExaminee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvExaminee.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvExaminee.EnableHeadersVisualStyles = False
        Me.dgvExaminee.GridColor = System.Drawing.SystemColors.MenuBar
        Me.dgvExaminee.Location = New System.Drawing.Point(52, 488)
        Me.dgvExaminee.Name = "dgvExaminee"
        Me.dgvExaminee.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvExaminee.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvExaminee.RowHeadersVisible = False
        Me.dgvExaminee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvExaminee.Size = New System.Drawing.Size(416, 198)
        Me.dgvExaminee.TabIndex = 113
        '
        'lblExamineeCount
        '
        Me.lblExamineeCount.AutoSize = True
        Me.lblExamineeCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExamineeCount.Location = New System.Drawing.Point(359, 463)
        Me.lblExamineeCount.Name = "lblExamineeCount"
        Me.lblExamineeCount.Size = New System.Drawing.Size(105, 16)
        Me.lblExamineeCount.TabIndex = 115
        Me.lblExamineeCount.Text = "Examinee Count"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(212, 463)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(141, 16)
        Me.Label30.TabIndex = 114
        Me.Label30.Text = "Registered Examinee:"
        '
        'btnExportToExcel
        '
        Me.btnExportToExcel.Depth = 0
        Me.btnExportToExcel.Location = New System.Drawing.Point(338, 697)
        Me.btnExportToExcel.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnExportToExcel.Name = "btnExportToExcel"
        Me.btnExportToExcel.Primary = True
        Me.btnExportToExcel.Size = New System.Drawing.Size(130, 23)
        Me.btnExportToExcel.TabIndex = 116
        Me.btnExportToExcel.Text = "Export to excel"
        Me.btnExportToExcel.UseVisualStyleBackColor = True
        '
        'btnRefreshExamineeDgv
        '
        Me.btnRefreshExamineeDgv.Depth = 0
        Me.btnRefreshExamineeDgv.Location = New System.Drawing.Point(195, 697)
        Me.btnRefreshExamineeDgv.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnRefreshExamineeDgv.Name = "btnRefreshExamineeDgv"
        Me.btnRefreshExamineeDgv.Primary = True
        Me.btnRefreshExamineeDgv.Size = New System.Drawing.Size(130, 23)
        Me.btnRefreshExamineeDgv.TabIndex = 117
        Me.btnRefreshExamineeDgv.Text = "Refresh Table"
        Me.btnRefreshExamineeDgv.UseVisualStyleBackColor = True
        '
        'btnPrintExamineeDgv
        '
        Me.btnPrintExamineeDgv.Depth = 0
        Me.btnPrintExamineeDgv.Location = New System.Drawing.Point(52, 697)
        Me.btnPrintExamineeDgv.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnPrintExamineeDgv.Name = "btnPrintExamineeDgv"
        Me.btnPrintExamineeDgv.Primary = True
        Me.btnPrintExamineeDgv.Size = New System.Drawing.Size(130, 23)
        Me.btnPrintExamineeDgv.TabIndex = 118
        Me.btnPrintExamineeDgv.Text = "Print Table"
        Me.btnPrintExamineeDgv.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtExamineeIDFilter)
        Me.GroupBox1.Controls.Add(Me.MaterialDivider6)
        Me.GroupBox1.Controls.Add(Me.rbNoResultFilter)
        Me.GroupBox1.Controls.Add(Me.rbFailedFilter)
        Me.GroupBox1.Controls.Add(Me.rbPassedFilter)
        Me.GroupBox1.Controls.Add(Me.chkDateFilter)
        Me.GroupBox1.Controls.Add(Me.dtpToFilter)
        Me.GroupBox1.Controls.Add(Me.dtpFromFilter)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.btnClearFilter)
        Me.GroupBox1.Controls.Add(Me.cboPositionFilter)
        Me.GroupBox1.Controls.Add(Me.Label44)
        Me.GroupBox1.Controls.Add(Me.Label46)
        Me.GroupBox1.Controls.Add(Me.Label45)
        Me.GroupBox1.Controls.Add(Me.Label43)
        Me.GroupBox1.Controls.Add(Me.Label62)
        Me.GroupBox1.Controls.Add(Me.Label47)
        Me.GroupBox1.Controls.Add(Me.txtFirstNameFilter)
        Me.GroupBox1.Controls.Add(Me.txtLastNameFilter)
        Me.GroupBox1.Controls.Add(Me.Label48)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(52, 218)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(416, 231)
        Me.GroupBox1.TabIndex = 119
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Filters"
        '
        'txtExamineeIDFilter
        '
        Me.txtExamineeIDFilter.Location = New System.Drawing.Point(120, 18)
        Me.txtExamineeIDFilter.Name = "txtExamineeIDFilter"
        Me.txtExamineeIDFilter.Size = New System.Drawing.Size(272, 20)
        Me.txtExamineeIDFilter.TabIndex = 1
        '
        'MaterialDivider6
        '
        Me.MaterialDivider6.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider6.Depth = 0
        Me.MaterialDivider6.Location = New System.Drawing.Point(120, 148)
        Me.MaterialDivider6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider6.Name = "MaterialDivider6"
        Me.MaterialDivider6.Size = New System.Drawing.Size(1, 45)
        Me.MaterialDivider6.TabIndex = 19
        Me.MaterialDivider6.Text = "MaterialDivider6"
        '
        'rbNoResultFilter
        '
        Me.rbNoResultFilter.AutoSize = True
        Me.rbNoResultFilter.Location = New System.Drawing.Point(297, 95)
        Me.rbNoResultFilter.Name = "rbNoResultFilter"
        Me.rbNoResultFilter.Size = New System.Drawing.Size(81, 17)
        Me.rbNoResultFilter.TabIndex = 6
        Me.rbNoResultFilter.TabStop = True
        Me.rbNoResultFilter.Text = "No Result"
        Me.rbNoResultFilter.UseVisualStyleBackColor = True
        '
        'rbFailedFilter
        '
        Me.rbFailedFilter.AutoSize = True
        Me.rbFailedFilter.Location = New System.Drawing.Point(214, 95)
        Me.rbFailedFilter.Name = "rbFailedFilter"
        Me.rbFailedFilter.Size = New System.Drawing.Size(59, 17)
        Me.rbFailedFilter.TabIndex = 5
        Me.rbFailedFilter.TabStop = True
        Me.rbFailedFilter.Text = "Failed"
        Me.rbFailedFilter.UseVisualStyleBackColor = True
        '
        'rbPassedFilter
        '
        Me.rbPassedFilter.AutoSize = True
        Me.rbPassedFilter.Location = New System.Drawing.Point(123, 95)
        Me.rbPassedFilter.Name = "rbPassedFilter"
        Me.rbPassedFilter.Size = New System.Drawing.Size(66, 17)
        Me.rbPassedFilter.TabIndex = 4
        Me.rbPassedFilter.TabStop = True
        Me.rbPassedFilter.Text = "Passed"
        Me.rbPassedFilter.UseVisualStyleBackColor = True
        '
        'chkDateFilter
        '
        Me.chkDateFilter.AutoSize = True
        Me.chkDateFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDateFilter.Location = New System.Drawing.Point(56, 149)
        Me.chkDateFilter.Name = "chkDateFilter"
        Me.chkDateFilter.Size = New System.Drawing.Size(60, 19)
        Me.chkDateFilter.TabIndex = 5
        Me.chkDateFilter.Text = "DATE:"
        Me.chkDateFilter.UseVisualStyleBackColor = True
        '
        'dtpToFilter
        '
        Me.dtpToFilter.Location = New System.Drawing.Point(170, 173)
        Me.dtpToFilter.Name = "dtpToFilter"
        Me.dtpToFilter.Size = New System.Drawing.Size(222, 20)
        Me.dtpToFilter.TabIndex = 9
        '
        'dtpFromFilter
        '
        Me.dtpFromFilter.Location = New System.Drawing.Point(170, 145)
        Me.dtpFromFilter.Name = "dtpFromFilter"
        Me.dtpFromFilter.Size = New System.Drawing.Size(222, 20)
        Me.dtpFromFilter.TabIndex = 8
        '
        'btnSearch
        '
        Me.btnSearch.Depth = 0
        Me.btnSearch.Location = New System.Drawing.Point(298, 200)
        Me.btnSearch.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Primary = True
        Me.btnSearch.Size = New System.Drawing.Size(94, 28)
        Me.btnSearch.TabIndex = 10
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnClearFilter
        '
        Me.btnClearFilter.AutoSize = True
        Me.btnClearFilter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnClearFilter.Depth = 0
        Me.btnClearFilter.Location = New System.Drawing.Point(7, 196)
        Me.btnClearFilter.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnClearFilter.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnClearFilter.Name = "btnClearFilter"
        Me.btnClearFilter.Primary = False
        Me.btnClearFilter.Size = New System.Drawing.Size(109, 36)
        Me.btnClearFilter.TabIndex = 11
        Me.btnClearFilter.Text = "Clear Filters"
        Me.btnClearFilter.UseVisualStyleBackColor = True
        '
        'cboPositionFilter
        '
        Me.cboPositionFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPositionFilter.FormattingEnabled = True
        Me.cboPositionFilter.Location = New System.Drawing.Point(120, 118)
        Me.cboPositionFilter.Name = "cboPositionFilter"
        Me.cboPositionFilter.Size = New System.Drawing.Size(272, 21)
        Me.cboPositionFilter.TabIndex = 7
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(69, 95)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(45, 15)
        Me.Label44.TabIndex = 0
        Me.Label44.Text = "Result:"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(124, 150)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(43, 15)
        Me.Label46.TabIndex = 0
        Me.Label46.Text = "FROM"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(144, 175)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(23, 15)
        Me.Label45.TabIndex = 0
        Me.Label45.Text = "TO"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(34, 121)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(80, 15)
        Me.Label43.TabIndex = 0
        Me.Label43.Text = "Position Title:"
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label62.Location = New System.Drawing.Point(33, 20)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(81, 15)
        Me.Label62.TabIndex = 0
        Me.Label62.Text = "Examinee ID:"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.Location = New System.Drawing.Point(44, 46)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(70, 15)
        Me.Label47.TabIndex = 0
        Me.Label47.Text = "First Name:"
        '
        'txtFirstNameFilter
        '
        Me.txtFirstNameFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstNameFilter.Location = New System.Drawing.Point(120, 43)
        Me.txtFirstNameFilter.MaxLength = 50
        Me.txtFirstNameFilter.Name = "txtFirstNameFilter"
        Me.txtFirstNameFilter.Size = New System.Drawing.Size(272, 22)
        Me.txtFirstNameFilter.TabIndex = 2
        '
        'txtLastNameFilter
        '
        Me.txtLastNameFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastNameFilter.Location = New System.Drawing.Point(120, 69)
        Me.txtLastNameFilter.MaxLength = 50
        Me.txtLastNameFilter.Name = "txtLastNameFilter"
        Me.txtLastNameFilter.Size = New System.Drawing.Size(272, 22)
        Me.txtLastNameFilter.TabIndex = 3
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.Location = New System.Drawing.Point(44, 72)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(70, 15)
        Me.Label48.TabIndex = 0
        Me.Label48.Text = "Last Name:"
        '
        'MaterialDivider12
        '
        Me.MaterialDivider12.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider12.Depth = 0
        Me.MaterialDivider12.Location = New System.Drawing.Point(493, 220)
        Me.MaterialDivider12.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider12.Name = "MaterialDivider12"
        Me.MaterialDivider12.Size = New System.Drawing.Size(2, 480)
        Me.MaterialDivider12.TabIndex = 44
        Me.MaterialDivider12.Text = "MaterialDivider10"
        '
        'AdminTempDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1280, 768)
        Me.Controls.Add(Me.MaterialDivider12)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnPrintExamineeDgv)
        Me.Controls.Add(Me.btnRefreshExamineeDgv)
        Me.Controls.Add(Me.btnExportToExcel)
        Me.Controls.Add(Me.lblExamineeCount)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.dgvExaminee)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.lblExamineeError)
        Me.Controls.Add(Me.picExamineeError)
        Me.Controls.Add(Me.MaterialDivider10)
        Me.Controls.Add(Me.MaterialDivider11)
        Me.Controls.Add(Me.MaterialDivider5)
        Me.Controls.Add(Me.MaterialDivider8)
        Me.Controls.Add(Me.MaterialDivider9)
        Me.Controls.Add(Me.MaterialDivider7)
        Me.Controls.Add(Me.rbClericalActive)
        Me.Controls.Add(Me.rbNonSupervisoryActive)
        Me.Controls.Add(Me.rbSupervisoryActive)
        Me.Controls.Add(Me.Label59)
        Me.Controls.Add(Me.Label60)
        Me.Controls.Add(Me.Label61)
        Me.Controls.Add(Me.Label56)
        Me.Controls.Add(Me.Label57)
        Me.Controls.Add(Me.Label58)
        Me.Controls.Add(Me.Label52)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label51)
        Me.Controls.Add(Me.Label50)
        Me.Controls.Add(Me.Label49)
        Me.Controls.Add(Me.cboSupervisoryPosition)
        Me.Controls.Add(Me.cboNonSupervisoryPosition)
        Me.Controls.Add(Me.cboClericalPosition)
        Me.Controls.Add(Me.Label55)
        Me.Controls.Add(Me.txtClericalResultB)
        Me.Controls.Add(Me.txtNonSupervisoryResultB)
        Me.Controls.Add(Me.txtClericalResultC)
        Me.Controls.Add(Me.txtSupervisoryResultB)
        Me.Controls.Add(Me.txtNonSupervisoryResultC)
        Me.Controls.Add(Me.txtClericalResultA)
        Me.Controls.Add(Me.Label54)
        Me.Controls.Add(Me.txtNonSupervisoryResultA)
        Me.Controls.Add(Me.txtSupervisoryResultC)
        Me.Controls.Add(Me.txtSupervisoryResultA)
        Me.Controls.Add(Me.Label53)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnChangePicture)
        Me.Controls.Add(Me.picExaminee)
        Me.Controls.Add(Me.btnExamineeEdit)
        Me.Controls.Add(Me.btnExamineeClear)
        Me.Controls.Add(Me.btnExamineeRegister)
        Me.Controls.Add(Me.txtEmailAddress)
        Me.Controls.Add(Me.lblEmailError)
        Me.Controls.Add(Me.lblLastNameError)
        Me.Controls.Add(Me.lblFirstNameError)
        Me.Controls.Add(Me.lblExamineeDateID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MaterialDivider1)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.MaterialDivider4)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.btnUserManual)
        Me.Controls.Add(Me.btnBackLogin)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "AdminTempDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Temporary-Admin Dashboard"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picExaminee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picExamineeError, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvExaminee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnUserManual As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnBackLogin As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents sfdBackup As SaveFileDialog
    Friend WithEvents Label33 As Label
    Friend WithEvents MaterialDivider4 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents Label31 As Label
    Friend WithEvents MaterialDivider1 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents txtEmailAddress As TextBoxEx
    Friend WithEvents lblEmailError As Label
    Friend WithEvents lblLastNameError As Label
    Friend WithEvents lblFirstNameError As Label
    Friend WithEvents lblExamineeDateID As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtLastName As TextBoxEx
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFirstName As TextBoxEx
    Friend WithEvents Label38 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnExamineeRegister As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnExamineeClear As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnExamineeEdit As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnChangePicture As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents picExaminee As PictureBox
    Friend WithEvents MaterialDivider10 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents MaterialDivider11 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents MaterialDivider5 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents MaterialDivider8 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents MaterialDivider9 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents MaterialDivider7 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents rbClericalActive As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents rbNonSupervisoryActive As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents rbSupervisoryActive As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents Label59 As Label
    Friend WithEvents Label60 As Label
    Friend WithEvents Label61 As Label
    Friend WithEvents Label56 As Label
    Friend WithEvents Label57 As Label
    Friend WithEvents Label58 As Label
    Friend WithEvents Label52 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label51 As Label
    Friend WithEvents Label50 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents cboSupervisoryPosition As ComboBox
    Friend WithEvents cboNonSupervisoryPosition As ComboBox
    Friend WithEvents cboClericalPosition As ComboBox
    Friend WithEvents Label55 As Label
    Friend WithEvents txtClericalResultB As Label
    Friend WithEvents txtNonSupervisoryResultB As Label
    Friend WithEvents txtClericalResultC As Label
    Friend WithEvents txtSupervisoryResultB As Label
    Friend WithEvents txtNonSupervisoryResultC As Label
    Friend WithEvents txtClericalResultA As Label
    Friend WithEvents Label54 As Label
    Friend WithEvents txtNonSupervisoryResultA As Label
    Friend WithEvents txtSupervisoryResultC As Label
    Friend WithEvents txtSupervisoryResultA As Label
    Friend WithEvents Label53 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents lblExamineeError As Label
    Friend WithEvents picExamineeError As PictureBox
    Friend WithEvents dgvExaminee As DataGridView
    Friend WithEvents lblExamineeCount As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents btnExportToExcel As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents sfdExcel As SaveFileDialog
    Friend WithEvents btnRefreshExamineeDgv As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnPrintExamineeDgv As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtExamineeIDFilter As TextBox
    Friend WithEvents MaterialDivider6 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents rbNoResultFilter As RadioButton
    Friend WithEvents rbFailedFilter As RadioButton
    Friend WithEvents rbPassedFilter As RadioButton
    Friend WithEvents chkDateFilter As CheckBox
    Friend WithEvents dtpToFilter As DateTimePicker
    Friend WithEvents dtpFromFilter As DateTimePicker
    Friend WithEvents btnSearch As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnClearFilter As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents cboPositionFilter As ComboBox
    Friend WithEvents Label44 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents Label62 As Label
    Friend WithEvents Label47 As Label
    Friend WithEvents txtFirstNameFilter As TextBox
    Friend WithEvents txtLastNameFilter As TextBox
    Friend WithEvents Label48 As Label
    Friend WithEvents MaterialDivider12 As MaterialSkin.Controls.MaterialDivider
End Class
