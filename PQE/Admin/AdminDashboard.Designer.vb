<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminDashboard
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.mtcAdminDashboard = New MaterialSkin.Controls.MaterialTabControl()
        Me.tabExaminee = New System.Windows.Forms.TabPage()
        Me.btnPrintClericalC = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnPrintClericalB = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnPrintClericalA = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnPrintNonSupervisoryC = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnPrintNonSupervisoryB = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnPrintNonSupervisoryA = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnPrintSupervisoryC = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnPrintSupervisoryB = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnPrintSupervisoryA = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialDivider12 = New MaterialSkin.Controls.MaterialDivider()
        Me.MaterialDivider10 = New MaterialSkin.Controls.MaterialDivider()
        Me.MaterialDivider11 = New MaterialSkin.Controls.MaterialDivider()
        Me.MaterialDivider5 = New MaterialSkin.Controls.MaterialDivider()
        Me.MaterialDivider8 = New MaterialSkin.Controls.MaterialDivider()
        Me.MaterialDivider9 = New MaterialSkin.Controls.MaterialDivider()
        Me.MaterialDivider7 = New MaterialSkin.Controls.MaterialDivider()
        Me.txtEmailAddress = New PQE.TextBoxEx()
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
        Me.btnChangePicture = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnExportToExcel = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.lblEmailError = New System.Windows.Forms.Label()
        Me.lblLastNameError = New System.Windows.Forms.Label()
        Me.lblFirstNameError = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.btnRefreshExamineeDgv = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnPrintExamineeDgv = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.picExaminee = New System.Windows.Forms.PictureBox()
        Me.lblExamineeCount = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.lblExamineeError = New System.Windows.Forms.Label()
        Me.picExamineeError = New System.Windows.Forms.PictureBox()
        Me.dgvExaminee = New System.Windows.Forms.DataGridView()
        Me.btnExamineeClear = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnExamineeEdit = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnExamineeRegister = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.lblExamineeDateID = New System.Windows.Forms.Label()
        Me.cboSupervisoryPosition = New System.Windows.Forms.ComboBox()
        Me.cboNonSupervisoryPosition = New System.Windows.Forms.ComboBox()
        Me.cboClericalPosition = New System.Windows.Forms.ComboBox()
        Me.txtLastName = New PQE.TextBoxEx()
        Me.txtFirstName = New PQE.TextBoxEx()
        Me.Label38 = New System.Windows.Forms.Label()
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
        Me.tabExam = New System.Windows.Forms.TabPage()
        Me.MaterialDivider3 = New MaterialSkin.Controls.MaterialDivider()
        Me.lblExamSet = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.cboExamSet = New System.Windows.Forms.ComboBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblExamError = New System.Windows.Forms.Label()
        Me.lblKindID = New System.Windows.Forms.Label()
        Me.lblExamLevelID = New System.Windows.Forms.Label()
        Me.lblExamTypeID = New System.Windows.Forms.Label()
        Me.lblQuestionID = New System.Windows.Forms.Label()
        Me.btnExamClear = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnQuestionDelete = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnQuestionSave = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.txtChoice4 = New System.Windows.Forms.TextBox()
        Me.txtChoice3 = New System.Windows.Forms.TextBox()
        Me.txtChoice2 = New System.Windows.Forms.TextBox()
        Me.txtChoice1 = New System.Windows.Forms.TextBox()
        Me.rbChoice4 = New MaterialSkin.Controls.MaterialRadioButton()
        Me.rbChoice3 = New MaterialSkin.Controls.MaterialRadioButton()
        Me.rbChoice2 = New MaterialSkin.Controls.MaterialRadioButton()
        Me.rbChoice1 = New MaterialSkin.Controls.MaterialRadioButton()
        Me.tscQuestion = New System.Windows.Forms.ToolStripContainer()
        Me.rtfQuestion = New System.Windows.Forms.RichTextBox()
        Me.tsQuestion = New System.Windows.Forms.ToolStrip()
        Me.tsbInsertImage = New System.Windows.Forms.ToolStripButton()
        Me.tslInsertImage = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbChangeFont = New System.Windows.Forms.ToolStripButton()
        Me.tslChangeFont = New System.Windows.Forms.ToolStripLabel()
        Me.dgvExam = New System.Windows.Forms.DataGridView()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblQuestionCounter = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboExamType = New System.Windows.Forms.ComboBox()
        Me.cboExamLevel = New System.Windows.Forms.ComboBox()
        Me.picExamError = New System.Windows.Forms.PictureBox()
        Me.tabConfiguration = New System.Windows.Forms.TabPage()
        Me.MaterialDivider19 = New MaterialSkin.Controls.MaterialDivider()
        Me.txtSettingMessageNonPasser = New System.Windows.Forms.RichTextBox()
        Me.txtSettingMessagePasser = New System.Windows.Forms.RichTextBox()
        Me.MaterialDivider18 = New MaterialSkin.Controls.MaterialDivider()
        Me.btnEmailSettingsSave = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.txtSettingMailSubject = New PQE.TextBoxEx()
        Me.txtSettingGmailAppPassword = New PQE.TextBoxEx()
        Me.txtSettingSmtpPort = New PQE.TextBoxEx()
        Me.txtSettingSmtp = New PQE.TextBoxEx()
        Me.txtSettingEmailAddress = New PQE.TextBoxEx()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.MaterialDivider17 = New MaterialSkin.Controls.MaterialDivider()
        Me.MaterialDivider16 = New MaterialSkin.Controls.MaterialDivider()
        Me.MaterialDivider15 = New MaterialSkin.Controls.MaterialDivider()
        Me.MaterialDivider14 = New MaterialSkin.Controls.MaterialDivider()
        Me.dgvTempo = New System.Windows.Forms.DataGridView()
        Me.cmsPrintExaminee = New MaterialSkin.Controls.MaterialContextMenuStrip()
        Me.tsmPrintExaminee = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnTempoAdd = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnTempoDelete = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.txtTempoPass = New System.Windows.Forms.TextBox()
        Me.txtTempoUser = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.chkShowPassword = New MaterialSkin.Controls.MaterialCheckBox()
        Me.btnChangePassword = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.txtCurrentPassword = New System.Windows.Forms.TextBox()
        Me.btnRestore = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnBrowse = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.txtClericalVerbalTime = New System.Windows.Forms.TextBox()
        Me.txtAbstractReasoningTime = New System.Windows.Forms.TextBox()
        Me.txtNonSupervisoryVerbalTime = New System.Windows.Forms.TextBox()
        Me.txtClericalNumericalTime = New System.Windows.Forms.TextBox()
        Me.txtSupervisoryVerbalTime = New System.Windows.Forms.TextBox()
        Me.txtClericalReasoningTime = New System.Windows.Forms.TextBox()
        Me.txtGeneralInfoTime = New System.Windows.Forms.TextBox()
        Me.txtNonSupervisoryNumericalTime = New System.Windows.Forms.TextBox()
        Me.txtReadingComprehensionTime = New System.Windows.Forms.TextBox()
        Me.txtSupervisoryNumericalTime = New System.Windows.Forms.TextBox()
        Me.txtManagementTime = New System.Windows.Forms.TextBox()
        Me.MaterialDivider13 = New MaterialSkin.Controls.MaterialDivider()
        Me.MaterialDivider2 = New MaterialSkin.Controls.MaterialDivider()
        Me.MaterialDivider1 = New MaterialSkin.Controls.MaterialDivider()
        Me.btnTimerSave = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.lblLastRestore = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.lblLastBackup = New System.Windows.Forms.Label()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.mtsAdminDashboard = New MaterialSkin.Controls.MaterialTabSelector()
        Me.sfdBackup = New System.Windows.Forms.SaveFileDialog()
        Me.ofdRestore = New System.Windows.Forms.OpenFileDialog()
        Me.btnBackLogin = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnUserManual = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.fdChangeFont = New System.Windows.Forms.FontDialog()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.MaterialDivider4 = New MaterialSkin.Controls.MaterialDivider()
        Me.sfdExcel = New System.Windows.Forms.SaveFileDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.mtcAdminDashboard.SuspendLayout()
        Me.tabExaminee.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.picExaminee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picExamineeError, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvExaminee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabExam.SuspendLayout()
        Me.tscQuestion.ContentPanel.SuspendLayout()
        Me.tscQuestion.TopToolStripPanel.SuspendLayout()
        Me.tscQuestion.SuspendLayout()
        Me.tsQuestion.SuspendLayout()
        CType(Me.dgvExam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picExamError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabConfiguration.SuspendLayout()
        CType(Me.dgvTempo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsPrintExaminee.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(651, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Examinee ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(661, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "First Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(663, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Last Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(653, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Position Title:"
        '
        'mtcAdminDashboard
        '
        Me.mtcAdminDashboard.Controls.Add(Me.tabExaminee)
        Me.mtcAdminDashboard.Controls.Add(Me.tabExam)
        Me.mtcAdminDashboard.Controls.Add(Me.tabConfiguration)
        Me.mtcAdminDashboard.Depth = 0
        Me.mtcAdminDashboard.Location = New System.Drawing.Point(12, 207)
        Me.mtcAdminDashboard.MouseState = MaterialSkin.MouseState.HOVER
        Me.mtcAdminDashboard.Name = "mtcAdminDashboard"
        Me.mtcAdminDashboard.SelectedIndex = 0
        Me.mtcAdminDashboard.Size = New System.Drawing.Size(1256, 549)
        Me.mtcAdminDashboard.TabIndex = 0
        '
        'tabExaminee
        '
        Me.tabExaminee.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tabExaminee.Controls.Add(Me.btnPrintClericalC)
        Me.tabExaminee.Controls.Add(Me.btnPrintClericalB)
        Me.tabExaminee.Controls.Add(Me.btnPrintClericalA)
        Me.tabExaminee.Controls.Add(Me.btnPrintNonSupervisoryC)
        Me.tabExaminee.Controls.Add(Me.btnPrintNonSupervisoryB)
        Me.tabExaminee.Controls.Add(Me.btnPrintNonSupervisoryA)
        Me.tabExaminee.Controls.Add(Me.btnPrintSupervisoryC)
        Me.tabExaminee.Controls.Add(Me.btnPrintSupervisoryB)
        Me.tabExaminee.Controls.Add(Me.btnPrintSupervisoryA)
        Me.tabExaminee.Controls.Add(Me.MaterialDivider12)
        Me.tabExaminee.Controls.Add(Me.MaterialDivider10)
        Me.tabExaminee.Controls.Add(Me.MaterialDivider11)
        Me.tabExaminee.Controls.Add(Me.MaterialDivider5)
        Me.tabExaminee.Controls.Add(Me.MaterialDivider8)
        Me.tabExaminee.Controls.Add(Me.MaterialDivider9)
        Me.tabExaminee.Controls.Add(Me.MaterialDivider7)
        Me.tabExaminee.Controls.Add(Me.txtEmailAddress)
        Me.tabExaminee.Controls.Add(Me.rbClericalActive)
        Me.tabExaminee.Controls.Add(Me.rbNonSupervisoryActive)
        Me.tabExaminee.Controls.Add(Me.rbSupervisoryActive)
        Me.tabExaminee.Controls.Add(Me.Label59)
        Me.tabExaminee.Controls.Add(Me.Label60)
        Me.tabExaminee.Controls.Add(Me.Label61)
        Me.tabExaminee.Controls.Add(Me.Label56)
        Me.tabExaminee.Controls.Add(Me.Label57)
        Me.tabExaminee.Controls.Add(Me.Label58)
        Me.tabExaminee.Controls.Add(Me.Label52)
        Me.tabExaminee.Controls.Add(Me.Label5)
        Me.tabExaminee.Controls.Add(Me.Label51)
        Me.tabExaminee.Controls.Add(Me.Label50)
        Me.tabExaminee.Controls.Add(Me.Label49)
        Me.tabExaminee.Controls.Add(Me.GroupBox1)
        Me.tabExaminee.Controls.Add(Me.btnChangePicture)
        Me.tabExaminee.Controls.Add(Me.btnExportToExcel)
        Me.tabExaminee.Controls.Add(Me.lblEmailError)
        Me.tabExaminee.Controls.Add(Me.lblLastNameError)
        Me.tabExaminee.Controls.Add(Me.lblFirstNameError)
        Me.tabExaminee.Controls.Add(Me.Label34)
        Me.tabExaminee.Controls.Add(Me.btnRefreshExamineeDgv)
        Me.tabExaminee.Controls.Add(Me.btnPrintExamineeDgv)
        Me.tabExaminee.Controls.Add(Me.picExaminee)
        Me.tabExaminee.Controls.Add(Me.lblExamineeCount)
        Me.tabExaminee.Controls.Add(Me.Label30)
        Me.tabExaminee.Controls.Add(Me.lblExamineeError)
        Me.tabExaminee.Controls.Add(Me.picExamineeError)
        Me.tabExaminee.Controls.Add(Me.dgvExaminee)
        Me.tabExaminee.Controls.Add(Me.btnExamineeClear)
        Me.tabExaminee.Controls.Add(Me.btnExamineeEdit)
        Me.tabExaminee.Controls.Add(Me.btnExamineeRegister)
        Me.tabExaminee.Controls.Add(Me.lblExamineeDateID)
        Me.tabExaminee.Controls.Add(Me.cboSupervisoryPosition)
        Me.tabExaminee.Controls.Add(Me.cboNonSupervisoryPosition)
        Me.tabExaminee.Controls.Add(Me.cboClericalPosition)
        Me.tabExaminee.Controls.Add(Me.Label1)
        Me.tabExaminee.Controls.Add(Me.txtLastName)
        Me.tabExaminee.Controls.Add(Me.Label2)
        Me.tabExaminee.Controls.Add(Me.txtFirstName)
        Me.tabExaminee.Controls.Add(Me.Label38)
        Me.tabExaminee.Controls.Add(Me.Label3)
        Me.tabExaminee.Controls.Add(Me.Label55)
        Me.tabExaminee.Controls.Add(Me.txtClericalResultB)
        Me.tabExaminee.Controls.Add(Me.txtNonSupervisoryResultB)
        Me.tabExaminee.Controls.Add(Me.txtClericalResultC)
        Me.tabExaminee.Controls.Add(Me.txtSupervisoryResultB)
        Me.tabExaminee.Controls.Add(Me.txtNonSupervisoryResultC)
        Me.tabExaminee.Controls.Add(Me.txtClericalResultA)
        Me.tabExaminee.Controls.Add(Me.Label54)
        Me.tabExaminee.Controls.Add(Me.txtNonSupervisoryResultA)
        Me.tabExaminee.Controls.Add(Me.txtSupervisoryResultC)
        Me.tabExaminee.Controls.Add(Me.txtSupervisoryResultA)
        Me.tabExaminee.Controls.Add(Me.Label53)
        Me.tabExaminee.Controls.Add(Me.Label4)
        Me.tabExaminee.Location = New System.Drawing.Point(4, 22)
        Me.tabExaminee.Name = "tabExaminee"
        Me.tabExaminee.Padding = New System.Windows.Forms.Padding(3)
        Me.tabExaminee.Size = New System.Drawing.Size(1248, 523)
        Me.tabExaminee.TabIndex = 0
        Me.tabExaminee.Text = "Examinee"
        '
        'btnPrintClericalC
        '
        Me.btnPrintClericalC.Depth = 0
        Me.btnPrintClericalC.Location = New System.Drawing.Point(832, 493)
        Me.btnPrintClericalC.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnPrintClericalC.Name = "btnPrintClericalC"
        Me.btnPrintClericalC.Primary = True
        Me.btnPrintClericalC.Size = New System.Drawing.Size(75, 23)
        Me.btnPrintClericalC.TabIndex = 44
        Me.btnPrintClericalC.Text = "Print"
        Me.btnPrintClericalC.UseVisualStyleBackColor = True
        '
        'btnPrintClericalB
        '
        Me.btnPrintClericalB.Depth = 0
        Me.btnPrintClericalB.Location = New System.Drawing.Point(832, 469)
        Me.btnPrintClericalB.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnPrintClericalB.Name = "btnPrintClericalB"
        Me.btnPrintClericalB.Primary = True
        Me.btnPrintClericalB.Size = New System.Drawing.Size(75, 23)
        Me.btnPrintClericalB.TabIndex = 44
        Me.btnPrintClericalB.Text = "Print"
        Me.btnPrintClericalB.UseVisualStyleBackColor = True
        '
        'btnPrintClericalA
        '
        Me.btnPrintClericalA.Depth = 0
        Me.btnPrintClericalA.Location = New System.Drawing.Point(832, 445)
        Me.btnPrintClericalA.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnPrintClericalA.Name = "btnPrintClericalA"
        Me.btnPrintClericalA.Primary = True
        Me.btnPrintClericalA.Size = New System.Drawing.Size(75, 23)
        Me.btnPrintClericalA.TabIndex = 44
        Me.btnPrintClericalA.Text = "Print"
        Me.btnPrintClericalA.UseVisualStyleBackColor = True
        '
        'btnPrintNonSupervisoryC
        '
        Me.btnPrintNonSupervisoryC.Depth = 0
        Me.btnPrintNonSupervisoryC.Location = New System.Drawing.Point(832, 375)
        Me.btnPrintNonSupervisoryC.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnPrintNonSupervisoryC.Name = "btnPrintNonSupervisoryC"
        Me.btnPrintNonSupervisoryC.Primary = True
        Me.btnPrintNonSupervisoryC.Size = New System.Drawing.Size(75, 23)
        Me.btnPrintNonSupervisoryC.TabIndex = 44
        Me.btnPrintNonSupervisoryC.Text = "Print"
        Me.btnPrintNonSupervisoryC.UseVisualStyleBackColor = True
        '
        'btnPrintNonSupervisoryB
        '
        Me.btnPrintNonSupervisoryB.Depth = 0
        Me.btnPrintNonSupervisoryB.Location = New System.Drawing.Point(832, 351)
        Me.btnPrintNonSupervisoryB.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnPrintNonSupervisoryB.Name = "btnPrintNonSupervisoryB"
        Me.btnPrintNonSupervisoryB.Primary = True
        Me.btnPrintNonSupervisoryB.Size = New System.Drawing.Size(75, 23)
        Me.btnPrintNonSupervisoryB.TabIndex = 44
        Me.btnPrintNonSupervisoryB.Text = "Print"
        Me.btnPrintNonSupervisoryB.UseVisualStyleBackColor = True
        '
        'btnPrintNonSupervisoryA
        '
        Me.btnPrintNonSupervisoryA.Depth = 0
        Me.btnPrintNonSupervisoryA.Location = New System.Drawing.Point(832, 327)
        Me.btnPrintNonSupervisoryA.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnPrintNonSupervisoryA.Name = "btnPrintNonSupervisoryA"
        Me.btnPrintNonSupervisoryA.Primary = True
        Me.btnPrintNonSupervisoryA.Size = New System.Drawing.Size(75, 23)
        Me.btnPrintNonSupervisoryA.TabIndex = 44
        Me.btnPrintNonSupervisoryA.Text = "Print"
        Me.btnPrintNonSupervisoryA.UseVisualStyleBackColor = True
        '
        'btnPrintSupervisoryC
        '
        Me.btnPrintSupervisoryC.Depth = 0
        Me.btnPrintSupervisoryC.Location = New System.Drawing.Point(832, 262)
        Me.btnPrintSupervisoryC.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnPrintSupervisoryC.Name = "btnPrintSupervisoryC"
        Me.btnPrintSupervisoryC.Primary = True
        Me.btnPrintSupervisoryC.Size = New System.Drawing.Size(75, 23)
        Me.btnPrintSupervisoryC.TabIndex = 44
        Me.btnPrintSupervisoryC.Text = "Print"
        Me.btnPrintSupervisoryC.UseVisualStyleBackColor = True
        '
        'btnPrintSupervisoryB
        '
        Me.btnPrintSupervisoryB.Depth = 0
        Me.btnPrintSupervisoryB.Location = New System.Drawing.Point(832, 238)
        Me.btnPrintSupervisoryB.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnPrintSupervisoryB.Name = "btnPrintSupervisoryB"
        Me.btnPrintSupervisoryB.Primary = True
        Me.btnPrintSupervisoryB.Size = New System.Drawing.Size(75, 23)
        Me.btnPrintSupervisoryB.TabIndex = 44
        Me.btnPrintSupervisoryB.Text = "Print"
        Me.btnPrintSupervisoryB.UseVisualStyleBackColor = True
        '
        'btnPrintSupervisoryA
        '
        Me.btnPrintSupervisoryA.Depth = 0
        Me.btnPrintSupervisoryA.Location = New System.Drawing.Point(832, 214)
        Me.btnPrintSupervisoryA.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnPrintSupervisoryA.Name = "btnPrintSupervisoryA"
        Me.btnPrintSupervisoryA.Primary = True
        Me.btnPrintSupervisoryA.Size = New System.Drawing.Size(75, 23)
        Me.btnPrintSupervisoryA.TabIndex = 44
        Me.btnPrintSupervisoryA.Text = "Print"
        Me.btnPrintSupervisoryA.UseVisualStyleBackColor = True
        '
        'MaterialDivider12
        '
        Me.MaterialDivider12.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider12.Depth = 0
        Me.MaterialDivider12.Location = New System.Drawing.Point(466, 15)
        Me.MaterialDivider12.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider12.Name = "MaterialDivider12"
        Me.MaterialDivider12.Size = New System.Drawing.Size(2, 480)
        Me.MaterialDivider12.TabIndex = 43
        Me.MaterialDivider12.Text = "MaterialDivider10"
        '
        'MaterialDivider10
        '
        Me.MaterialDivider10.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider10.Depth = 0
        Me.MaterialDivider10.Location = New System.Drawing.Point(546, 403)
        Me.MaterialDivider10.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider10.Name = "MaterialDivider10"
        Me.MaterialDivider10.Size = New System.Drawing.Size(650, 2)
        Me.MaterialDivider10.TabIndex = 42
        Me.MaterialDivider10.Text = "MaterialDivider10"
        '
        'MaterialDivider11
        '
        Me.MaterialDivider11.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider11.Depth = 0
        Me.MaterialDivider11.Location = New System.Drawing.Point(643, 415)
        Me.MaterialDivider11.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider11.Name = "MaterialDivider11"
        Me.MaterialDivider11.Size = New System.Drawing.Size(1, 65)
        Me.MaterialDivider11.TabIndex = 41
        Me.MaterialDivider11.Text = "MaterialDivider10"
        '
        'MaterialDivider5
        '
        Me.MaterialDivider5.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider5.Depth = 0
        Me.MaterialDivider5.Location = New System.Drawing.Point(493, 175)
        Me.MaterialDivider5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider5.Name = "MaterialDivider5"
        Me.MaterialDivider5.Size = New System.Drawing.Size(730, 2)
        Me.MaterialDivider5.TabIndex = 40
        Me.MaterialDivider5.Text = "MaterialDivider10"
        '
        'MaterialDivider8
        '
        Me.MaterialDivider8.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider8.Depth = 0
        Me.MaterialDivider8.Location = New System.Drawing.Point(643, 189)
        Me.MaterialDivider8.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider8.Name = "MaterialDivider8"
        Me.MaterialDivider8.Size = New System.Drawing.Size(1, 65)
        Me.MaterialDivider8.TabIndex = 39
        Me.MaterialDivider8.Text = "MaterialDivider10"
        '
        'MaterialDivider9
        '
        Me.MaterialDivider9.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider9.Depth = 0
        Me.MaterialDivider9.Location = New System.Drawing.Point(546, 286)
        Me.MaterialDivider9.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider9.Name = "MaterialDivider9"
        Me.MaterialDivider9.Size = New System.Drawing.Size(650, 2)
        Me.MaterialDivider9.TabIndex = 38
        Me.MaterialDivider9.Text = "MaterialDivider10"
        '
        'MaterialDivider7
        '
        Me.MaterialDivider7.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider7.Depth = 0
        Me.MaterialDivider7.Location = New System.Drawing.Point(643, 298)
        Me.MaterialDivider7.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider7.Name = "MaterialDivider7"
        Me.MaterialDivider7.Size = New System.Drawing.Size(1, 65)
        Me.MaterialDivider7.TabIndex = 36
        Me.MaterialDivider7.Text = "MaterialDivider10"
        '
        'txtEmailAddress
        '
        Me.txtEmailAddress.Location = New System.Drawing.Point(744, 128)
        Me.txtEmailAddress.Name = "txtEmailAddress"
        Me.txtEmailAddress.Size = New System.Drawing.Size(294, 20)
        Me.txtEmailAddress.TabIndex = 33
        '
        'rbClericalActive
        '
        Me.rbClericalActive.AutoSize = True
        Me.rbClericalActive.Depth = 0
        Me.rbClericalActive.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rbClericalActive.Location = New System.Drawing.Point(564, 437)
        Me.rbClericalActive.Margin = New System.Windows.Forms.Padding(0)
        Me.rbClericalActive.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rbClericalActive.MouseState = MaterialSkin.MouseState.HOVER
        Me.rbClericalActive.Name = "rbClericalActive"
        Me.rbClericalActive.Ripple = True
        Me.rbClericalActive.Size = New System.Drawing.Size(68, 30)
        Me.rbClericalActive.TabIndex = 32
        Me.rbClericalActive.TabStop = True
        Me.rbClericalActive.Text = "Active"
        Me.rbClericalActive.UseVisualStyleBackColor = True
        '
        'rbNonSupervisoryActive
        '
        Me.rbNonSupervisoryActive.AutoSize = True
        Me.rbNonSupervisoryActive.Depth = 0
        Me.rbNonSupervisoryActive.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rbNonSupervisoryActive.Location = New System.Drawing.Point(563, 320)
        Me.rbNonSupervisoryActive.Margin = New System.Windows.Forms.Padding(0)
        Me.rbNonSupervisoryActive.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rbNonSupervisoryActive.MouseState = MaterialSkin.MouseState.HOVER
        Me.rbNonSupervisoryActive.Name = "rbNonSupervisoryActive"
        Me.rbNonSupervisoryActive.Ripple = True
        Me.rbNonSupervisoryActive.Size = New System.Drawing.Size(68, 30)
        Me.rbNonSupervisoryActive.TabIndex = 32
        Me.rbNonSupervisoryActive.TabStop = True
        Me.rbNonSupervisoryActive.Text = "Active"
        Me.rbNonSupervisoryActive.UseVisualStyleBackColor = True
        '
        'rbSupervisoryActive
        '
        Me.rbSupervisoryActive.AutoSize = True
        Me.rbSupervisoryActive.Depth = 0
        Me.rbSupervisoryActive.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rbSupervisoryActive.Location = New System.Drawing.Point(563, 208)
        Me.rbSupervisoryActive.Margin = New System.Windows.Forms.Padding(0)
        Me.rbSupervisoryActive.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rbSupervisoryActive.MouseState = MaterialSkin.MouseState.HOVER
        Me.rbSupervisoryActive.Name = "rbSupervisoryActive"
        Me.rbSupervisoryActive.Ripple = True
        Me.rbSupervisoryActive.Size = New System.Drawing.Size(68, 30)
        Me.rbSupervisoryActive.TabIndex = 32
        Me.rbSupervisoryActive.TabStop = True
        Me.rbSupervisoryActive.Text = "Active"
        Me.rbSupervisoryActive.UseVisualStyleBackColor = True
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.Location = New System.Drawing.Point(698, 378)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(43, 16)
        Me.Label59.TabIndex = 29
        Me.Label59.Text = "Set C:"
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.Location = New System.Drawing.Point(698, 354)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(43, 16)
        Me.Label60.TabIndex = 30
        Me.Label60.Text = "Set B:"
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.Location = New System.Drawing.Point(698, 331)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(43, 16)
        Me.Label61.TabIndex = 31
        Me.Label61.Text = "Set A:"
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.Location = New System.Drawing.Point(698, 495)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(43, 16)
        Me.Label56.TabIndex = 26
        Me.Label56.Text = "Set C:"
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.Location = New System.Drawing.Point(698, 472)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(43, 16)
        Me.Label57.TabIndex = 27
        Me.Label57.Text = "Set B:"
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.Location = New System.Drawing.Point(698, 449)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(43, 16)
        Me.Label58.TabIndex = 28
        Me.Label58.Text = "Set A:"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.Location = New System.Drawing.Point(653, 421)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(88, 16)
        Me.Label52.TabIndex = 25
        Me.Label52.Text = "Position Title:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(653, 302)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 16)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Position Title:"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.Location = New System.Drawing.Point(580, 416)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(61, 16)
        Me.Label51.TabIndex = 21
        Me.Label51.Text = "Clerical"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.Location = New System.Drawing.Point(517, 298)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(124, 16)
        Me.Label50.TabIndex = 20
        Me.Label50.Text = "Non-Supervisory"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(546, 188)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(91, 16)
        Me.Label49.TabIndex = 19
        Me.Label49.Text = "Supervisory"
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
        Me.GroupBox1.Location = New System.Drawing.Point(21, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(404, 231)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Filters"
        '
        'txtExamineeIDFilter
        '
        Me.txtExamineeIDFilter.Location = New System.Drawing.Point(120, 18)
        Me.txtExamineeIDFilter.Name = "txtExamineeIDFilter"
        Me.txtExamineeIDFilter.Size = New System.Drawing.Size(260, 20)
        Me.txtExamineeIDFilter.TabIndex = 20
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
        Me.rbFailedFilter.TabIndex = 6
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
        Me.rbPassedFilter.TabIndex = 6
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
        Me.dtpToFilter.Size = New System.Drawing.Size(210, 20)
        Me.dtpToFilter.TabIndex = 4
        '
        'dtpFromFilter
        '
        Me.dtpFromFilter.Location = New System.Drawing.Point(170, 145)
        Me.dtpFromFilter.Name = "dtpFromFilter"
        Me.dtpFromFilter.Size = New System.Drawing.Size(210, 20)
        Me.dtpFromFilter.TabIndex = 4
        '
        'btnSearch
        '
        Me.btnSearch.Depth = 0
        Me.btnSearch.Location = New System.Drawing.Point(298, 200)
        Me.btnSearch.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Primary = True
        Me.btnSearch.Size = New System.Drawing.Size(82, 28)
        Me.btnSearch.TabIndex = 3
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
        Me.btnClearFilter.TabIndex = 2
        Me.btnClearFilter.Text = "Clear Filters"
        Me.btnClearFilter.UseVisualStyleBackColor = True
        '
        'cboPositionFilter
        '
        Me.cboPositionFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPositionFilter.FormattingEnabled = True
        Me.cboPositionFilter.Location = New System.Drawing.Point(120, 118)
        Me.cboPositionFilter.Name = "cboPositionFilter"
        Me.cboPositionFilter.Size = New System.Drawing.Size(260, 21)
        Me.cboPositionFilter.TabIndex = 1
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
        Me.txtFirstNameFilter.Size = New System.Drawing.Size(260, 22)
        Me.txtFirstNameFilter.TabIndex = 0
        '
        'txtLastNameFilter
        '
        Me.txtLastNameFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastNameFilter.Location = New System.Drawing.Point(120, 69)
        Me.txtLastNameFilter.MaxLength = 50
        Me.txtLastNameFilter.Name = "txtLastNameFilter"
        Me.txtLastNameFilter.Size = New System.Drawing.Size(260, 22)
        Me.txtLastNameFilter.TabIndex = 1
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
        'btnChangePicture
        '
        Me.btnChangePicture.Depth = 0
        Me.btnChangePicture.Location = New System.Drawing.Point(499, 138)
        Me.btnChangePicture.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnChangePicture.Name = "btnChangePicture"
        Me.btnChangePicture.Primary = True
        Me.btnChangePicture.Size = New System.Drawing.Size(120, 26)
        Me.btnChangePicture.TabIndex = 16
        Me.btnChangePicture.Text = "Change Picture"
        Me.btnChangePicture.UseVisualStyleBackColor = True
        '
        'btnExportToExcel
        '
        Me.btnExportToExcel.Depth = 0
        Me.btnExportToExcel.Location = New System.Drawing.Point(307, 485)
        Me.btnExportToExcel.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnExportToExcel.Name = "btnExportToExcel"
        Me.btnExportToExcel.Primary = True
        Me.btnExportToExcel.Size = New System.Drawing.Size(130, 23)
        Me.btnExportToExcel.TabIndex = 14
        Me.btnExportToExcel.Text = "Export to excel"
        Me.btnExportToExcel.UseVisualStyleBackColor = True
        '
        'lblEmailError
        '
        Me.lblEmailError.AutoSize = True
        Me.lblEmailError.ForeColor = System.Drawing.Color.Tomato
        Me.lblEmailError.Location = New System.Drawing.Point(911, 148)
        Me.lblEmailError.Name = "lblEmailError"
        Me.lblEmailError.Size = New System.Drawing.Size(127, 13)
        Me.lblEmailError.TabIndex = 12
        Me.lblEmailError.Text = "(Only accepts valid email)"
        Me.lblEmailError.Visible = False
        '
        'lblLastNameError
        '
        Me.lblLastNameError.AutoSize = True
        Me.lblLastNameError.ForeColor = System.Drawing.Color.Tomato
        Me.lblLastNameError.Location = New System.Drawing.Point(807, 108)
        Me.lblLastNameError.Name = "lblLastNameError"
        Me.lblLastNameError.Size = New System.Drawing.Size(231, 13)
        Me.lblLastNameError.TabIndex = 12
        Me.lblLastNameError.Text = "(Only accepts letters, apostrophes, and dashes)"
        Me.lblLastNameError.Visible = False
        '
        'lblFirstNameError
        '
        Me.lblFirstNameError.AutoSize = True
        Me.lblFirstNameError.ForeColor = System.Drawing.Color.Tomato
        Me.lblFirstNameError.Location = New System.Drawing.Point(807, 66)
        Me.lblFirstNameError.Name = "lblFirstNameError"
        Me.lblFirstNameError.Size = New System.Drawing.Size(231, 13)
        Me.lblFirstNameError.TabIndex = 12
        Me.lblFirstNameError.Text = "(Only accepts letters, apostrophes, and dashes)"
        Me.lblFirstNameError.Visible = False
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(1051, 50)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(170, 13)
        Me.Label34.TabIndex = 12
        Me.Label34.Text = "Register Button behind Edit Button"
        Me.Label34.Visible = False
        '
        'btnRefreshExamineeDgv
        '
        Me.btnRefreshExamineeDgv.Depth = 0
        Me.btnRefreshExamineeDgv.Location = New System.Drawing.Point(166, 485)
        Me.btnRefreshExamineeDgv.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnRefreshExamineeDgv.Name = "btnRefreshExamineeDgv"
        Me.btnRefreshExamineeDgv.Primary = True
        Me.btnRefreshExamineeDgv.Size = New System.Drawing.Size(130, 23)
        Me.btnRefreshExamineeDgv.TabIndex = 11
        Me.btnRefreshExamineeDgv.Text = "Refresh Table"
        Me.btnRefreshExamineeDgv.UseVisualStyleBackColor = True
        '
        'btnPrintExamineeDgv
        '
        Me.btnPrintExamineeDgv.Depth = 0
        Me.btnPrintExamineeDgv.Location = New System.Drawing.Point(21, 485)
        Me.btnPrintExamineeDgv.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnPrintExamineeDgv.Name = "btnPrintExamineeDgv"
        Me.btnPrintExamineeDgv.Primary = True
        Me.btnPrintExamineeDgv.Size = New System.Drawing.Size(130, 23)
        Me.btnPrintExamineeDgv.TabIndex = 10
        Me.btnPrintExamineeDgv.Text = "Print Table"
        Me.btnPrintExamineeDgv.UseVisualStyleBackColor = True
        '
        'picExaminee
        '
        Me.picExaminee.BackColor = System.Drawing.Color.DimGray
        Me.picExaminee.Image = Global.PQE.My.Resources.Resources.NoExamineePic
        Me.picExaminee.Location = New System.Drawing.Point(499, 15)
        Me.picExaminee.Name = "picExaminee"
        Me.picExaminee.Size = New System.Drawing.Size(120, 120)
        Me.picExaminee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picExaminee.TabIndex = 9
        Me.picExaminee.TabStop = False
        '
        'lblExamineeCount
        '
        Me.lblExamineeCount.AutoSize = True
        Me.lblExamineeCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExamineeCount.Location = New System.Drawing.Point(304, 253)
        Me.lblExamineeCount.Name = "lblExamineeCount"
        Me.lblExamineeCount.Size = New System.Drawing.Size(105, 16)
        Me.lblExamineeCount.TabIndex = 8
        Me.lblExamineeCount.Text = "Examinee Count"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(157, 253)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(141, 16)
        Me.Label30.TabIndex = 7
        Me.Label30.Text = "Registered Examinee:"
        '
        'lblExamineeError
        '
        Me.lblExamineeError.AutoSize = True
        Me.lblExamineeError.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExamineeError.Location = New System.Drawing.Point(1110, 28)
        Me.lblExamineeError.Name = "lblExamineeError"
        Me.lblExamineeError.Size = New System.Drawing.Size(97, 16)
        Me.lblExamineeError.TabIndex = 7
        Me.lblExamineeError.Text = "Error Message"
        Me.lblExamineeError.Visible = False
        '
        'picExamineeError
        '
        Me.picExamineeError.Image = Global.PQE.My.Resources.Resources.error1
        Me.picExamineeError.Location = New System.Drawing.Point(1054, 14)
        Me.picExamineeError.Name = "picExamineeError"
        Me.picExamineeError.Size = New System.Drawing.Size(50, 50)
        Me.picExamineeError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picExamineeError.TabIndex = 6
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvExaminee.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvExaminee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvExaminee.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvExaminee.EnableHeadersVisualStyles = False
        Me.dgvExaminee.GridColor = System.Drawing.SystemColors.MenuBar
        Me.dgvExaminee.Location = New System.Drawing.Point(21, 281)
        Me.dgvExaminee.Name = "dgvExaminee"
        Me.dgvExaminee.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvExaminee.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvExaminee.RowHeadersVisible = False
        Me.dgvExaminee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvExaminee.Size = New System.Drawing.Size(416, 198)
        Me.dgvExaminee.TabIndex = 5
        '
        'btnExamineeClear
        '
        Me.btnExamineeClear.Depth = 0
        Me.btnExamineeClear.Location = New System.Drawing.Point(1054, 112)
        Me.btnExamineeClear.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnExamineeClear.Name = "btnExamineeClear"
        Me.btnExamineeClear.Primary = True
        Me.btnExamineeClear.Size = New System.Drawing.Size(130, 36)
        Me.btnExamineeClear.TabIndex = 4
        Me.btnExamineeClear.Text = "Clear Fields"
        Me.btnExamineeClear.UseVisualStyleBackColor = True
        '
        'btnExamineeEdit
        '
        Me.btnExamineeEdit.Depth = 0
        Me.btnExamineeEdit.Location = New System.Drawing.Point(1077, 71)
        Me.btnExamineeEdit.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnExamineeEdit.Name = "btnExamineeEdit"
        Me.btnExamineeEdit.Primary = True
        Me.btnExamineeEdit.Size = New System.Drawing.Size(130, 36)
        Me.btnExamineeEdit.TabIndex = 4
        Me.btnExamineeEdit.Text = "Edit"
        Me.btnExamineeEdit.UseVisualStyleBackColor = True
        '
        'btnExamineeRegister
        '
        Me.btnExamineeRegister.Depth = 0
        Me.btnExamineeRegister.Location = New System.Drawing.Point(1054, 70)
        Me.btnExamineeRegister.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnExamineeRegister.Name = "btnExamineeRegister"
        Me.btnExamineeRegister.Primary = True
        Me.btnExamineeRegister.Size = New System.Drawing.Size(130, 36)
        Me.btnExamineeRegister.TabIndex = 4
        Me.btnExamineeRegister.Text = "Register"
        Me.btnExamineeRegister.UseVisualStyleBackColor = True
        '
        'lblExamineeDateID
        '
        Me.lblExamineeDateID.AutoSize = True
        Me.lblExamineeDateID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExamineeDateID.Location = New System.Drawing.Point(744, 18)
        Me.lblExamineeDateID.Name = "lblExamineeDateID"
        Me.lblExamineeDateID.Size = New System.Drawing.Size(0, 16)
        Me.lblExamineeDateID.TabIndex = 3
        '
        'cboSupervisoryPosition
        '
        Me.cboSupervisoryPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSupervisoryPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSupervisoryPosition.FormattingEnabled = True
        Me.cboSupervisoryPosition.Location = New System.Drawing.Point(744, 188)
        Me.cboSupervisoryPosition.Name = "cboSupervisoryPosition"
        Me.cboSupervisoryPosition.Size = New System.Drawing.Size(294, 24)
        Me.cboSupervisoryPosition.TabIndex = 3
        '
        'cboNonSupervisoryPosition
        '
        Me.cboNonSupervisoryPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNonSupervisoryPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNonSupervisoryPosition.FormattingEnabled = True
        Me.cboNonSupervisoryPosition.Location = New System.Drawing.Point(744, 298)
        Me.cboNonSupervisoryPosition.Name = "cboNonSupervisoryPosition"
        Me.cboNonSupervisoryPosition.Size = New System.Drawing.Size(294, 24)
        Me.cboNonSupervisoryPosition.TabIndex = 3
        '
        'cboClericalPosition
        '
        Me.cboClericalPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboClericalPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboClericalPosition.FormattingEnabled = True
        Me.cboClericalPosition.Location = New System.Drawing.Point(744, 416)
        Me.cboClericalPosition.Name = "cboClericalPosition"
        Me.cboClericalPosition.Size = New System.Drawing.Size(294, 24)
        Me.cboClericalPosition.TabIndex = 3
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(744, 86)
        Me.txtLastName.MaxLength = 50
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(294, 22)
        Me.txtLastName.TabIndex = 1
        '
        'txtFirstName
        '
        Me.txtFirstName.BackColor = System.Drawing.Color.LightCyan
        Me.txtFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(744, 44)
        Me.txtFirstName.MaxLength = 50
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(294, 22)
        Me.txtFirstName.TabIndex = 0
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(637, 129)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(99, 16)
        Me.Label38.TabIndex = 0
        Me.Label38.Text = "Email Address:"
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.Location = New System.Drawing.Point(698, 264)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(43, 16)
        Me.Label55.TabIndex = 0
        Me.Label55.Text = "Set C:"
        '
        'txtClericalResultB
        '
        Me.txtClericalResultB.AutoSize = True
        Me.txtClericalResultB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClericalResultB.Location = New System.Drawing.Point(747, 472)
        Me.txtClericalResultB.Name = "txtClericalResultB"
        Me.txtClericalResultB.Size = New System.Drawing.Size(31, 16)
        Me.txtClericalResultB.TabIndex = 0
        Me.txtClericalResultB.Text = "N/A"
        '
        'txtNonSupervisoryResultB
        '
        Me.txtNonSupervisoryResultB.AutoSize = True
        Me.txtNonSupervisoryResultB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNonSupervisoryResultB.Location = New System.Drawing.Point(747, 354)
        Me.txtNonSupervisoryResultB.Name = "txtNonSupervisoryResultB"
        Me.txtNonSupervisoryResultB.Size = New System.Drawing.Size(31, 16)
        Me.txtNonSupervisoryResultB.TabIndex = 0
        Me.txtNonSupervisoryResultB.Text = "N/A"
        '
        'txtClericalResultC
        '
        Me.txtClericalResultC.AutoSize = True
        Me.txtClericalResultC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClericalResultC.Location = New System.Drawing.Point(747, 495)
        Me.txtClericalResultC.Name = "txtClericalResultC"
        Me.txtClericalResultC.Size = New System.Drawing.Size(31, 16)
        Me.txtClericalResultC.TabIndex = 0
        Me.txtClericalResultC.Text = "N/A"
        '
        'txtSupervisoryResultB
        '
        Me.txtSupervisoryResultB.AutoSize = True
        Me.txtSupervisoryResultB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupervisoryResultB.Location = New System.Drawing.Point(747, 241)
        Me.txtSupervisoryResultB.Name = "txtSupervisoryResultB"
        Me.txtSupervisoryResultB.Size = New System.Drawing.Size(31, 16)
        Me.txtSupervisoryResultB.TabIndex = 0
        Me.txtSupervisoryResultB.Text = "N/A"
        '
        'txtNonSupervisoryResultC
        '
        Me.txtNonSupervisoryResultC.AutoSize = True
        Me.txtNonSupervisoryResultC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNonSupervisoryResultC.Location = New System.Drawing.Point(747, 378)
        Me.txtNonSupervisoryResultC.Name = "txtNonSupervisoryResultC"
        Me.txtNonSupervisoryResultC.Size = New System.Drawing.Size(31, 16)
        Me.txtNonSupervisoryResultC.TabIndex = 0
        Me.txtNonSupervisoryResultC.Text = "N/A"
        '
        'txtClericalResultA
        '
        Me.txtClericalResultA.AutoSize = True
        Me.txtClericalResultA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClericalResultA.Location = New System.Drawing.Point(747, 449)
        Me.txtClericalResultA.Name = "txtClericalResultA"
        Me.txtClericalResultA.Size = New System.Drawing.Size(31, 16)
        Me.txtClericalResultA.TabIndex = 0
        Me.txtClericalResultA.Text = "N/A"
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.Location = New System.Drawing.Point(698, 241)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(43, 16)
        Me.Label54.TabIndex = 0
        Me.Label54.Text = "Set B:"
        '
        'txtNonSupervisoryResultA
        '
        Me.txtNonSupervisoryResultA.AutoSize = True
        Me.txtNonSupervisoryResultA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNonSupervisoryResultA.Location = New System.Drawing.Point(747, 331)
        Me.txtNonSupervisoryResultA.Name = "txtNonSupervisoryResultA"
        Me.txtNonSupervisoryResultA.Size = New System.Drawing.Size(31, 16)
        Me.txtNonSupervisoryResultA.TabIndex = 0
        Me.txtNonSupervisoryResultA.Text = "N/A"
        '
        'txtSupervisoryResultC
        '
        Me.txtSupervisoryResultC.AutoSize = True
        Me.txtSupervisoryResultC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupervisoryResultC.Location = New System.Drawing.Point(747, 264)
        Me.txtSupervisoryResultC.Name = "txtSupervisoryResultC"
        Me.txtSupervisoryResultC.Size = New System.Drawing.Size(31, 16)
        Me.txtSupervisoryResultC.TabIndex = 0
        Me.txtSupervisoryResultC.Text = "N/A"
        '
        'txtSupervisoryResultA
        '
        Me.txtSupervisoryResultA.AutoSize = True
        Me.txtSupervisoryResultA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupervisoryResultA.Location = New System.Drawing.Point(747, 218)
        Me.txtSupervisoryResultA.Name = "txtSupervisoryResultA"
        Me.txtSupervisoryResultA.Size = New System.Drawing.Size(31, 16)
        Me.txtSupervisoryResultA.TabIndex = 0
        Me.txtSupervisoryResultA.Text = "N/A"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.Location = New System.Drawing.Point(698, 218)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(43, 16)
        Me.Label53.TabIndex = 0
        Me.Label53.Text = "Set A:"
        '
        'tabExam
        '
        Me.tabExam.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tabExam.Controls.Add(Me.MaterialDivider3)
        Me.tabExam.Controls.Add(Me.lblExamSet)
        Me.tabExam.Controls.Add(Me.Label37)
        Me.tabExam.Controls.Add(Me.cboExamSet)
        Me.tabExam.Controls.Add(Me.txtSearch)
        Me.tabExam.Controls.Add(Me.lblExamError)
        Me.tabExam.Controls.Add(Me.lblKindID)
        Me.tabExam.Controls.Add(Me.lblExamLevelID)
        Me.tabExam.Controls.Add(Me.lblExamTypeID)
        Me.tabExam.Controls.Add(Me.lblQuestionID)
        Me.tabExam.Controls.Add(Me.btnExamClear)
        Me.tabExam.Controls.Add(Me.btnQuestionDelete)
        Me.tabExam.Controls.Add(Me.btnQuestionSave)
        Me.tabExam.Controls.Add(Me.txtChoice4)
        Me.tabExam.Controls.Add(Me.txtChoice3)
        Me.tabExam.Controls.Add(Me.txtChoice2)
        Me.tabExam.Controls.Add(Me.txtChoice1)
        Me.tabExam.Controls.Add(Me.rbChoice4)
        Me.tabExam.Controls.Add(Me.rbChoice3)
        Me.tabExam.Controls.Add(Me.rbChoice2)
        Me.tabExam.Controls.Add(Me.rbChoice1)
        Me.tabExam.Controls.Add(Me.tscQuestion)
        Me.tabExam.Controls.Add(Me.dgvExam)
        Me.tabExam.Controls.Add(Me.Label35)
        Me.tabExam.Controls.Add(Me.Label8)
        Me.tabExam.Controls.Add(Me.lblQuestionCounter)
        Me.tabExam.Controls.Add(Me.Label36)
        Me.tabExam.Controls.Add(Me.Label7)
        Me.tabExam.Controls.Add(Me.Label6)
        Me.tabExam.Controls.Add(Me.cboExamType)
        Me.tabExam.Controls.Add(Me.cboExamLevel)
        Me.tabExam.Controls.Add(Me.picExamError)
        Me.tabExam.Location = New System.Drawing.Point(4, 22)
        Me.tabExam.Name = "tabExam"
        Me.tabExam.Padding = New System.Windows.Forms.Padding(3)
        Me.tabExam.Size = New System.Drawing.Size(1248, 523)
        Me.tabExam.TabIndex = 1
        Me.tabExam.Text = "Exam"
        '
        'MaterialDivider3
        '
        Me.MaterialDivider3.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider3.Depth = 0
        Me.MaterialDivider3.Location = New System.Drawing.Point(168, 17)
        Me.MaterialDivider3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider3.Name = "MaterialDivider3"
        Me.MaterialDivider3.Size = New System.Drawing.Size(2, 50)
        Me.MaterialDivider3.TabIndex = 18
        Me.MaterialDivider3.Text = "MaterialDivider3"
        '
        'lblExamSet
        '
        Me.lblExamSet.AutoSize = True
        Me.lblExamSet.Location = New System.Drawing.Point(1031, 21)
        Me.lblExamSet.Name = "lblExamSet"
        Me.lblExamSet.Size = New System.Drawing.Size(37, 13)
        Me.lblExamSet.TabIndex = 17
        Me.lblExamSet.Text = "Set ID"
        Me.lblExamSet.Visible = False
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(34, 18)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(68, 16)
        Me.Label37.TabIndex = 16
        Me.Label37.Text = "Exam Set:"
        '
        'cboExamSet
        '
        Me.cboExamSet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboExamSet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboExamSet.FormattingEnabled = True
        Me.cboExamSet.Location = New System.Drawing.Point(108, 14)
        Me.cboExamSet.Name = "cboExamSet"
        Me.cboExamSet.Size = New System.Drawing.Size(50, 24)
        Me.cboExamSet.TabIndex = 0
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(1122, 87)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(122, 22)
        Me.txtSearch.TabIndex = 14
        '
        'lblExamError
        '
        Me.lblExamError.AutoSize = True
        Me.lblExamError.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExamError.Location = New System.Drawing.Point(821, 39)
        Me.lblExamError.Name = "lblExamError"
        Me.lblExamError.Size = New System.Drawing.Size(97, 16)
        Me.lblExamError.TabIndex = 13
        Me.lblExamError.Text = "Error Message"
        Me.lblExamError.Visible = False
        '
        'lblKindID
        '
        Me.lblKindID.AutoSize = True
        Me.lblKindID.Location = New System.Drawing.Point(1087, 42)
        Me.lblKindID.Name = "lblKindID"
        Me.lblKindID.Size = New System.Drawing.Size(42, 13)
        Me.lblKindID.TabIndex = 11
        Me.lblKindID.Text = "Kind ID"
        Me.lblKindID.Visible = False
        '
        'lblExamLevelID
        '
        Me.lblExamLevelID.AutoSize = True
        Me.lblExamLevelID.Location = New System.Drawing.Point(1087, 20)
        Me.lblExamLevelID.Name = "lblExamLevelID"
        Me.lblExamLevelID.Size = New System.Drawing.Size(62, 13)
        Me.lblExamLevelID.TabIndex = 11
        Me.lblExamLevelID.Text = "Exam Level"
        Me.lblExamLevelID.Visible = False
        '
        'lblExamTypeID
        '
        Me.lblExamTypeID.AutoSize = True
        Me.lblExamTypeID.Location = New System.Drawing.Point(1160, 20)
        Me.lblExamTypeID.Name = "lblExamTypeID"
        Me.lblExamTypeID.Size = New System.Drawing.Size(60, 13)
        Me.lblExamTypeID.TabIndex = 11
        Me.lblExamTypeID.Text = "Exam Type"
        Me.lblExamTypeID.Visible = False
        '
        'lblQuestionID
        '
        Me.lblQuestionID.AutoSize = True
        Me.lblQuestionID.Location = New System.Drawing.Point(952, 39)
        Me.lblQuestionID.Name = "lblQuestionID"
        Me.lblQuestionID.Size = New System.Drawing.Size(63, 13)
        Me.lblQuestionID.TabIndex = 11
        Me.lblQuestionID.Text = "Question ID"
        '
        'btnExamClear
        '
        Me.btnExamClear.Depth = 0
        Me.btnExamClear.Location = New System.Drawing.Point(834, 484)
        Me.btnExamClear.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnExamClear.Name = "btnExamClear"
        Me.btnExamClear.Primary = True
        Me.btnExamClear.Size = New System.Drawing.Size(208, 32)
        Me.btnExamClear.TabIndex = 10
        Me.btnExamClear.Text = "Clear Fields"
        Me.btnExamClear.UseVisualStyleBackColor = True
        '
        'btnQuestionDelete
        '
        Me.btnQuestionDelete.Depth = 0
        Me.btnQuestionDelete.Location = New System.Drawing.Point(834, 446)
        Me.btnQuestionDelete.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnQuestionDelete.Name = "btnQuestionDelete"
        Me.btnQuestionDelete.Primary = True
        Me.btnQuestionDelete.Size = New System.Drawing.Size(208, 32)
        Me.btnQuestionDelete.TabIndex = 10
        Me.btnQuestionDelete.Text = "Delete Question"
        Me.btnQuestionDelete.UseVisualStyleBackColor = True
        '
        'btnQuestionSave
        '
        Me.btnQuestionSave.Depth = 0
        Me.btnQuestionSave.Location = New System.Drawing.Point(834, 410)
        Me.btnQuestionSave.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnQuestionSave.Name = "btnQuestionSave"
        Me.btnQuestionSave.Primary = True
        Me.btnQuestionSave.Size = New System.Drawing.Size(208, 32)
        Me.btnQuestionSave.TabIndex = 10
        Me.btnQuestionSave.Text = "Save Question"
        Me.btnQuestionSave.UseVisualStyleBackColor = True
        '
        'txtChoice4
        '
        Me.txtChoice4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChoice4.Location = New System.Drawing.Point(75, 494)
        Me.txtChoice4.Name = "txtChoice4"
        Me.txtChoice4.Size = New System.Drawing.Size(735, 22)
        Me.txtChoice4.TabIndex = 6
        '
        'txtChoice3
        '
        Me.txtChoice3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChoice3.Location = New System.Drawing.Point(75, 466)
        Me.txtChoice3.Name = "txtChoice3"
        Me.txtChoice3.Size = New System.Drawing.Size(735, 22)
        Me.txtChoice3.TabIndex = 5
        '
        'txtChoice2
        '
        Me.txtChoice2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChoice2.Location = New System.Drawing.Point(75, 438)
        Me.txtChoice2.Name = "txtChoice2"
        Me.txtChoice2.Size = New System.Drawing.Size(735, 22)
        Me.txtChoice2.TabIndex = 4
        '
        'txtChoice1
        '
        Me.txtChoice1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChoice1.Location = New System.Drawing.Point(75, 410)
        Me.txtChoice1.Name = "txtChoice1"
        Me.txtChoice1.Size = New System.Drawing.Size(735, 22)
        Me.txtChoice1.TabIndex = 3
        '
        'rbChoice4
        '
        Me.rbChoice4.AutoSize = True
        Me.rbChoice4.Depth = 0
        Me.rbChoice4.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rbChoice4.Location = New System.Drawing.Point(27, 491)
        Me.rbChoice4.Margin = New System.Windows.Forms.Padding(0)
        Me.rbChoice4.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rbChoice4.MouseState = MaterialSkin.MouseState.HOVER
        Me.rbChoice4.Name = "rbChoice4"
        Me.rbChoice4.Ripple = True
        Me.rbChoice4.Size = New System.Drawing.Size(38, 30)
        Me.rbChoice4.TabIndex = 8
        Me.rbChoice4.TabStop = True
        Me.rbChoice4.Text = "D"
        Me.rbChoice4.UseVisualStyleBackColor = True
        '
        'rbChoice3
        '
        Me.rbChoice3.AutoSize = True
        Me.rbChoice3.Depth = 0
        Me.rbChoice3.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rbChoice3.Location = New System.Drawing.Point(27, 463)
        Me.rbChoice3.Margin = New System.Windows.Forms.Padding(0)
        Me.rbChoice3.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rbChoice3.MouseState = MaterialSkin.MouseState.HOVER
        Me.rbChoice3.Name = "rbChoice3"
        Me.rbChoice3.Ripple = True
        Me.rbChoice3.Size = New System.Drawing.Size(38, 30)
        Me.rbChoice3.TabIndex = 8
        Me.rbChoice3.TabStop = True
        Me.rbChoice3.Text = "C"
        Me.rbChoice3.UseVisualStyleBackColor = True
        '
        'rbChoice2
        '
        Me.rbChoice2.AutoSize = True
        Me.rbChoice2.Depth = 0
        Me.rbChoice2.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rbChoice2.Location = New System.Drawing.Point(27, 435)
        Me.rbChoice2.Margin = New System.Windows.Forms.Padding(0)
        Me.rbChoice2.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rbChoice2.MouseState = MaterialSkin.MouseState.HOVER
        Me.rbChoice2.Name = "rbChoice2"
        Me.rbChoice2.Ripple = True
        Me.rbChoice2.Size = New System.Drawing.Size(38, 30)
        Me.rbChoice2.TabIndex = 8
        Me.rbChoice2.TabStop = True
        Me.rbChoice2.Text = "B"
        Me.rbChoice2.UseVisualStyleBackColor = True
        '
        'rbChoice1
        '
        Me.rbChoice1.AutoSize = True
        Me.rbChoice1.Depth = 0
        Me.rbChoice1.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rbChoice1.Location = New System.Drawing.Point(27, 407)
        Me.rbChoice1.Margin = New System.Windows.Forms.Padding(0)
        Me.rbChoice1.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rbChoice1.MouseState = MaterialSkin.MouseState.HOVER
        Me.rbChoice1.Name = "rbChoice1"
        Me.rbChoice1.Ripple = True
        Me.rbChoice1.Size = New System.Drawing.Size(38, 30)
        Me.rbChoice1.TabIndex = 8
        Me.rbChoice1.TabStop = True
        Me.rbChoice1.Text = "A"
        Me.rbChoice1.UseVisualStyleBackColor = True
        '
        'tscQuestion
        '
        '
        'tscQuestion.ContentPanel
        '
        Me.tscQuestion.ContentPanel.Controls.Add(Me.rtfQuestion)
        Me.tscQuestion.ContentPanel.Size = New System.Drawing.Size(1041, 275)
        Me.tscQuestion.Location = New System.Drawing.Point(16, 85)
        Me.tscQuestion.Name = "tscQuestion"
        Me.tscQuestion.Size = New System.Drawing.Size(1041, 300)
        Me.tscQuestion.TabIndex = 7
        Me.tscQuestion.Text = "ToolStripContainer1"
        '
        'tscQuestion.TopToolStripPanel
        '
        Me.tscQuestion.TopToolStripPanel.Controls.Add(Me.tsQuestion)
        '
        'rtfQuestion
        '
        Me.rtfQuestion.Location = New System.Drawing.Point(0, 0)
        Me.rtfQuestion.Name = "rtfQuestion"
        Me.rtfQuestion.Size = New System.Drawing.Size(1041, 275)
        Me.rtfQuestion.TabIndex = 0
        Me.rtfQuestion.Text = ""
        '
        'tsQuestion
        '
        Me.tsQuestion.Dock = System.Windows.Forms.DockStyle.None
        Me.tsQuestion.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbInsertImage, Me.tslInsertImage, Me.ToolStripSeparator1, Me.tsbChangeFont, Me.tslChangeFont})
        Me.tsQuestion.Location = New System.Drawing.Point(3, 0)
        Me.tsQuestion.Name = "tsQuestion"
        Me.tsQuestion.Size = New System.Drawing.Size(167, 25)
        Me.tsQuestion.TabIndex = 0
        '
        'tsbInsertImage
        '
        Me.tsbInsertImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbInsertImage.Image = Global.PQE.My.Resources.Resources.AddImage
        Me.tsbInsertImage.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbInsertImage.Name = "tsbInsertImage"
        Me.tsbInsertImage.Size = New System.Drawing.Size(23, 22)
        Me.tsbInsertImage.Text = "Insert Image"
        '
        'tslInsertImage
        '
        Me.tslInsertImage.Name = "tslInsertImage"
        Me.tslInsertImage.Size = New System.Drawing.Size(72, 22)
        Me.tslInsertImage.Text = "Insert Image"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsbChangeFont
        '
        Me.tsbChangeFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbChangeFont.Image = Global.PQE.My.Resources.Resources.ChangeFont
        Me.tsbChangeFont.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbChangeFont.Name = "tsbChangeFont"
        Me.tsbChangeFont.Size = New System.Drawing.Size(23, 22)
        Me.tsbChangeFont.Text = "Change Font"
        '
        'tslChangeFont
        '
        Me.tslChangeFont.Name = "tslChangeFont"
        Me.tslChangeFont.Size = New System.Drawing.Size(31, 22)
        Me.tslChangeFont.Text = "Font"
        '
        'dgvExam
        '
        Me.dgvExam.AllowUserToAddRows = False
        Me.dgvExam.AllowUserToDeleteRows = False
        Me.dgvExam.AllowUserToResizeColumns = False
        Me.dgvExam.AllowUserToResizeRows = False
        Me.dgvExam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvExam.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvExam.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvExam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvExam.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvExam.EnableHeadersVisualStyles = False
        Me.dgvExam.GridColor = System.Drawing.SystemColors.MenuBar
        Me.dgvExam.Location = New System.Drawing.Point(1059, 109)
        Me.dgvExam.Name = "dgvExam"
        Me.dgvExam.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvExam.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvExam.RowHeadersVisible = False
        Me.dgvExam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvExam.Size = New System.Drawing.Size(185, 411)
        Me.dgvExam.TabIndex = 6
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(1057, 88)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(54, 16)
        Me.Label35.TabIndex = 1
        Me.Label35.Text = "Search:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(1055, 57)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 16)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Question Counter:"
        '
        'lblQuestionCounter
        '
        Me.lblQuestionCounter.AutoSize = True
        Me.lblQuestionCounter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestionCounter.Location = New System.Drawing.Point(1182, 58)
        Me.lblQuestionCounter.Name = "lblQuestionCounter"
        Me.lblQuestionCounter.Size = New System.Drawing.Size(15, 16)
        Me.lblQuestionCounter.TabIndex = 1
        Me.lblQuestionCounter.Text = "0"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(18, 388)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(101, 16)
        Me.Label36.TabIndex = 1
        Me.Label36.Text = "Correct Answer:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(178, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 16)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Exam Type:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(177, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 16)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Exam Level:"
        '
        'cboExamType
        '
        Me.cboExamType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboExamType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboExamType.FormattingEnabled = True
        Me.cboExamType.Location = New System.Drawing.Point(264, 44)
        Me.cboExamType.Name = "cboExamType"
        Me.cboExamType.Size = New System.Drawing.Size(265, 24)
        Me.cboExamType.TabIndex = 2
        '
        'cboExamLevel
        '
        Me.cboExamLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboExamLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboExamLevel.FormattingEnabled = True
        Me.cboExamLevel.Location = New System.Drawing.Point(264, 14)
        Me.cboExamLevel.Name = "cboExamLevel"
        Me.cboExamLevel.Size = New System.Drawing.Size(265, 24)
        Me.cboExamLevel.TabIndex = 1
        '
        'picExamError
        '
        Me.picExamError.Image = Global.PQE.My.Resources.Resources.error1
        Me.picExamError.Location = New System.Drawing.Point(765, 22)
        Me.picExamError.Name = "picExamError"
        Me.picExamError.Size = New System.Drawing.Size(50, 50)
        Me.picExamError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picExamError.TabIndex = 12
        Me.picExamError.TabStop = False
        Me.picExamError.Visible = False
        '
        'tabConfiguration
        '
        Me.tabConfiguration.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tabConfiguration.Controls.Add(Me.MaterialDivider19)
        Me.tabConfiguration.Controls.Add(Me.txtSettingMessageNonPasser)
        Me.tabConfiguration.Controls.Add(Me.txtSettingMessagePasser)
        Me.tabConfiguration.Controls.Add(Me.MaterialDivider18)
        Me.tabConfiguration.Controls.Add(Me.btnEmailSettingsSave)
        Me.tabConfiguration.Controls.Add(Me.txtSettingMailSubject)
        Me.tabConfiguration.Controls.Add(Me.txtSettingGmailAppPassword)
        Me.tabConfiguration.Controls.Add(Me.txtSettingSmtpPort)
        Me.tabConfiguration.Controls.Add(Me.txtSettingSmtp)
        Me.tabConfiguration.Controls.Add(Me.txtSettingEmailAddress)
        Me.tabConfiguration.Controls.Add(Me.Label69)
        Me.tabConfiguration.Controls.Add(Me.Label68)
        Me.tabConfiguration.Controls.Add(Me.Label67)
        Me.tabConfiguration.Controls.Add(Me.Label66)
        Me.tabConfiguration.Controls.Add(Me.MaterialDivider17)
        Me.tabConfiguration.Controls.Add(Me.MaterialDivider16)
        Me.tabConfiguration.Controls.Add(Me.MaterialDivider15)
        Me.tabConfiguration.Controls.Add(Me.MaterialDivider14)
        Me.tabConfiguration.Controls.Add(Me.dgvTempo)
        Me.tabConfiguration.Controls.Add(Me.btnTempoAdd)
        Me.tabConfiguration.Controls.Add(Me.btnTempoDelete)
        Me.tabConfiguration.Controls.Add(Me.txtTempoPass)
        Me.tabConfiguration.Controls.Add(Me.txtTempoUser)
        Me.tabConfiguration.Controls.Add(Me.Label39)
        Me.tabConfiguration.Controls.Add(Me.Label40)
        Me.tabConfiguration.Controls.Add(Me.Label41)
        Me.tabConfiguration.Controls.Add(Me.chkShowPassword)
        Me.tabConfiguration.Controls.Add(Me.btnChangePassword)
        Me.tabConfiguration.Controls.Add(Me.txtNewPassword)
        Me.tabConfiguration.Controls.Add(Me.txtCurrentPassword)
        Me.tabConfiguration.Controls.Add(Me.btnRestore)
        Me.tabConfiguration.Controls.Add(Me.btnBrowse)
        Me.tabConfiguration.Controls.Add(Me.txtClericalVerbalTime)
        Me.tabConfiguration.Controls.Add(Me.txtAbstractReasoningTime)
        Me.tabConfiguration.Controls.Add(Me.txtNonSupervisoryVerbalTime)
        Me.tabConfiguration.Controls.Add(Me.txtClericalNumericalTime)
        Me.tabConfiguration.Controls.Add(Me.txtSupervisoryVerbalTime)
        Me.tabConfiguration.Controls.Add(Me.txtClericalReasoningTime)
        Me.tabConfiguration.Controls.Add(Me.txtGeneralInfoTime)
        Me.tabConfiguration.Controls.Add(Me.txtNonSupervisoryNumericalTime)
        Me.tabConfiguration.Controls.Add(Me.txtReadingComprehensionTime)
        Me.tabConfiguration.Controls.Add(Me.txtSupervisoryNumericalTime)
        Me.tabConfiguration.Controls.Add(Me.txtManagementTime)
        Me.tabConfiguration.Controls.Add(Me.MaterialDivider13)
        Me.tabConfiguration.Controls.Add(Me.MaterialDivider2)
        Me.tabConfiguration.Controls.Add(Me.MaterialDivider1)
        Me.tabConfiguration.Controls.Add(Me.btnTimerSave)
        Me.tabConfiguration.Controls.Add(Me.Label23)
        Me.tabConfiguration.Controls.Add(Me.Label21)
        Me.tabConfiguration.Controls.Add(Me.Label22)
        Me.tabConfiguration.Controls.Add(Me.Label18)
        Me.tabConfiguration.Controls.Add(Me.Label20)
        Me.tabConfiguration.Controls.Add(Me.Label15)
        Me.tabConfiguration.Controls.Add(Me.Label19)
        Me.tabConfiguration.Controls.Add(Me.Label17)
        Me.tabConfiguration.Controls.Add(Me.Label29)
        Me.tabConfiguration.Controls.Add(Me.Label26)
        Me.tabConfiguration.Controls.Add(Me.lblLastRestore)
        Me.tabConfiguration.Controls.Add(Me.Label28)
        Me.tabConfiguration.Controls.Add(Me.lblLastBackup)
        Me.tabConfiguration.Controls.Add(Me.Label65)
        Me.tabConfiguration.Controls.Add(Me.Label25)
        Me.tabConfiguration.Controls.Add(Me.Label16)
        Me.tabConfiguration.Controls.Add(Me.Label14)
        Me.tabConfiguration.Controls.Add(Me.Label13)
        Me.tabConfiguration.Controls.Add(Me.Label12)
        Me.tabConfiguration.Controls.Add(Me.Label27)
        Me.tabConfiguration.Controls.Add(Me.Label24)
        Me.tabConfiguration.Controls.Add(Me.Label11)
        Me.tabConfiguration.Controls.Add(Me.Label10)
        Me.tabConfiguration.Controls.Add(Me.Label32)
        Me.tabConfiguration.Controls.Add(Me.Label64)
        Me.tabConfiguration.Controls.Add(Me.Label63)
        Me.tabConfiguration.Controls.Add(Me.Label42)
        Me.tabConfiguration.Controls.Add(Me.Label9)
        Me.tabConfiguration.Location = New System.Drawing.Point(4, 22)
        Me.tabConfiguration.Name = "tabConfiguration"
        Me.tabConfiguration.Padding = New System.Windows.Forms.Padding(3)
        Me.tabConfiguration.Size = New System.Drawing.Size(1248, 523)
        Me.tabConfiguration.TabIndex = 2
        Me.tabConfiguration.Text = "Configuration"
        '
        'MaterialDivider19
        '
        Me.MaterialDivider19.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider19.Depth = 0
        Me.MaterialDivider19.Location = New System.Drawing.Point(372, 335)
        Me.MaterialDivider19.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider19.Name = "MaterialDivider19"
        Me.MaterialDivider19.Size = New System.Drawing.Size(360, 1)
        Me.MaterialDivider19.TabIndex = 84
        Me.MaterialDivider19.Text = "MaterialDivider2"
        '
        'txtSettingMessageNonPasser
        '
        Me.txtSettingMessageNonPasser.Location = New System.Drawing.Point(354, 367)
        Me.txtSettingMessageNonPasser.Name = "txtSettingMessageNonPasser"
        Me.txtSettingMessageNonPasser.Size = New System.Drawing.Size(397, 96)
        Me.txtSettingMessageNonPasser.TabIndex = 83
        Me.txtSettingMessageNonPasser.Text = ""
        '
        'txtSettingMessagePasser
        '
        Me.txtSettingMessagePasser.Location = New System.Drawing.Point(354, 233)
        Me.txtSettingMessagePasser.Name = "txtSettingMessagePasser"
        Me.txtSettingMessagePasser.Size = New System.Drawing.Size(397, 96)
        Me.txtSettingMessagePasser.TabIndex = 83
        Me.txtSettingMessagePasser.Text = ""
        '
        'MaterialDivider18
        '
        Me.MaterialDivider18.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider18.Depth = 0
        Me.MaterialDivider18.Location = New System.Drawing.Point(362, 198)
        Me.MaterialDivider18.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider18.Name = "MaterialDivider18"
        Me.MaterialDivider18.Size = New System.Drawing.Size(380, 1)
        Me.MaterialDivider18.TabIndex = 82
        Me.MaterialDivider18.Text = "MaterialDivider2"
        '
        'btnEmailSettingsSave
        '
        Me.btnEmailSettingsSave.Depth = 0
        Me.btnEmailSettingsSave.Location = New System.Drawing.Point(417, 477)
        Me.btnEmailSettingsSave.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnEmailSettingsSave.Name = "btnEmailSettingsSave"
        Me.btnEmailSettingsSave.Primary = True
        Me.btnEmailSettingsSave.Size = New System.Drawing.Size(255, 37)
        Me.btnEmailSettingsSave.TabIndex = 81
        Me.btnEmailSettingsSave.Text = "Save Settings"
        Me.btnEmailSettingsSave.UseVisualStyleBackColor = True
        '
        'txtSettingMailSubject
        '
        Me.txtSettingMailSubject.Location = New System.Drawing.Point(541, 169)
        Me.txtSettingMailSubject.Name = "txtSettingMailSubject"
        Me.txtSettingMailSubject.Size = New System.Drawing.Size(210, 20)
        Me.txtSettingMailSubject.TabIndex = 80
        '
        'txtSettingGmailAppPassword
        '
        Me.txtSettingGmailAppPassword.Location = New System.Drawing.Point(541, 143)
        Me.txtSettingGmailAppPassword.Name = "txtSettingGmailAppPassword"
        Me.txtSettingGmailAppPassword.Size = New System.Drawing.Size(210, 20)
        Me.txtSettingGmailAppPassword.TabIndex = 80
        '
        'txtSettingSmtpPort
        '
        Me.txtSettingSmtpPort.Location = New System.Drawing.Point(541, 116)
        Me.txtSettingSmtpPort.Name = "txtSettingSmtpPort"
        Me.txtSettingSmtpPort.Size = New System.Drawing.Size(210, 20)
        Me.txtSettingSmtpPort.TabIndex = 80
        '
        'txtSettingSmtp
        '
        Me.txtSettingSmtp.Location = New System.Drawing.Point(541, 89)
        Me.txtSettingSmtp.Name = "txtSettingSmtp"
        Me.txtSettingSmtp.Size = New System.Drawing.Size(210, 20)
        Me.txtSettingSmtp.TabIndex = 80
        '
        'txtSettingEmailAddress
        '
        Me.txtSettingEmailAddress.Location = New System.Drawing.Point(541, 63)
        Me.txtSettingEmailAddress.Name = "txtSettingEmailAddress"
        Me.txtSettingEmailAddress.Size = New System.Drawing.Size(210, 20)
        Me.txtSettingEmailAddress.TabIndex = 80
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label69.Location = New System.Drawing.Point(351, 171)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(84, 16)
        Me.Label69.TabIndex = 79
        Me.Label69.Text = "Mail Subject:"
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label68.Location = New System.Drawing.Point(351, 145)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(189, 16)
        Me.Label68.TabIndex = 79
        Me.Label68.Text = "Gmail App-Specific Password:"
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.Location = New System.Drawing.Point(351, 117)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(76, 16)
        Me.Label67.TabIndex = 79
        Me.Label67.Text = "SMTP Port:"
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.Location = New System.Drawing.Point(351, 89)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(183, 16)
        Me.Label66.TabIndex = 79
        Me.Label66.Text = "Outgoing mail server (SMTP):"
        '
        'MaterialDivider17
        '
        Me.MaterialDivider17.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider17.Depth = 0
        Me.MaterialDivider17.Location = New System.Drawing.Point(795, 331)
        Me.MaterialDivider17.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider17.Name = "MaterialDivider17"
        Me.MaterialDivider17.Size = New System.Drawing.Size(430, 1)
        Me.MaterialDivider17.TabIndex = 78
        Me.MaterialDivider17.Text = "MaterialDivider2"
        '
        'MaterialDivider16
        '
        Me.MaterialDivider16.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider16.Depth = 0
        Me.MaterialDivider16.Location = New System.Drawing.Point(795, 193)
        Me.MaterialDivider16.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider16.Name = "MaterialDivider16"
        Me.MaterialDivider16.Size = New System.Drawing.Size(430, 1)
        Me.MaterialDivider16.TabIndex = 77
        Me.MaterialDivider16.Text = "MaterialDivider2"
        '
        'MaterialDivider15
        '
        Me.MaterialDivider15.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider15.Depth = 0
        Me.MaterialDivider15.Location = New System.Drawing.Point(14, 177)
        Me.MaterialDivider15.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider15.Name = "MaterialDivider15"
        Me.MaterialDivider15.Size = New System.Drawing.Size(305, 1)
        Me.MaterialDivider15.TabIndex = 76
        Me.MaterialDivider15.Text = "MaterialDivider2"
        '
        'MaterialDivider14
        '
        Me.MaterialDivider14.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider14.Depth = 0
        Me.MaterialDivider14.Location = New System.Drawing.Point(14, 300)
        Me.MaterialDivider14.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider14.Name = "MaterialDivider14"
        Me.MaterialDivider14.Size = New System.Drawing.Size(305, 1)
        Me.MaterialDivider14.TabIndex = 75
        Me.MaterialDivider14.Text = "MaterialDivider2"
        '
        'dgvTempo
        '
        Me.dgvTempo.AllowUserToAddRows = False
        Me.dgvTempo.AllowUserToDeleteRows = False
        Me.dgvTempo.AllowUserToResizeColumns = False
        Me.dgvTempo.AllowUserToResizeRows = False
        Me.dgvTempo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTempo.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTempo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvTempo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTempo.ContextMenuStrip = Me.cmsPrintExaminee
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTempo.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvTempo.EnableHeadersVisualStyles = False
        Me.dgvTempo.GridColor = System.Drawing.SystemColors.MenuBar
        Me.dgvTempo.Location = New System.Drawing.Point(801, 447)
        Me.dgvTempo.Name = "dgvTempo"
        Me.dgvTempo.ReadOnly = True
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTempo.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvTempo.RowHeadersVisible = False
        Me.dgvTempo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTempo.Size = New System.Drawing.Size(422, 67)
        Me.dgvTempo.TabIndex = 74
        '
        'cmsPrintExaminee
        '
        Me.cmsPrintExaminee.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmsPrintExaminee.Depth = 0
        Me.cmsPrintExaminee.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmPrintExaminee})
        Me.cmsPrintExaminee.MouseState = MaterialSkin.MouseState.HOVER
        Me.cmsPrintExaminee.Name = "cmsPrintExaminee"
        Me.cmsPrintExaminee.Size = New System.Drawing.Size(153, 26)
        '
        'tsmPrintExaminee
        '
        Me.tsmPrintExaminee.Name = "tsmPrintExaminee"
        Me.tsmPrintExaminee.Size = New System.Drawing.Size(152, 22)
        Me.tsmPrintExaminee.Text = "Print Examinee"
        '
        'btnTempoAdd
        '
        Me.btnTempoAdd.Depth = 0
        Me.btnTempoAdd.Location = New System.Drawing.Point(1130, 381)
        Me.btnTempoAdd.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnTempoAdd.Name = "btnTempoAdd"
        Me.btnTempoAdd.Primary = True
        Me.btnTempoAdd.Size = New System.Drawing.Size(93, 23)
        Me.btnTempoAdd.TabIndex = 73
        Me.btnTempoAdd.Text = "Add"
        Me.btnTempoAdd.UseVisualStyleBackColor = True
        '
        'btnTempoDelete
        '
        Me.btnTempoDelete.Depth = 0
        Me.btnTempoDelete.Location = New System.Drawing.Point(1130, 409)
        Me.btnTempoDelete.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnTempoDelete.Name = "btnTempoDelete"
        Me.btnTempoDelete.Primary = True
        Me.btnTempoDelete.Size = New System.Drawing.Size(93, 23)
        Me.btnTempoDelete.TabIndex = 72
        Me.btnTempoDelete.Text = "Delete"
        Me.btnTempoDelete.UseVisualStyleBackColor = True
        '
        'txtTempoPass
        '
        Me.txtTempoPass.Location = New System.Drawing.Point(929, 409)
        Me.txtTempoPass.Name = "txtTempoPass"
        Me.txtTempoPass.Size = New System.Drawing.Size(180, 20)
        Me.txtTempoPass.TabIndex = 71
        '
        'txtTempoUser
        '
        Me.txtTempoUser.Location = New System.Drawing.Point(929, 386)
        Me.txtTempoUser.Name = "txtTempoUser"
        Me.txtTempoUser.Size = New System.Drawing.Size(180, 20)
        Me.txtTempoUser.TabIndex = 70
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(843, 410)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(71, 16)
        Me.Label39.TabIndex = 68
        Me.Label39.Text = "Password:"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(858, 386)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(56, 16)
        Me.Label40.TabIndex = 69
        Me.Label40.Text = "User ID:"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(937, 348)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(143, 17)
        Me.Label41.TabIndex = 67
        Me.Label41.Text = "Temporary Admins"
        '
        'chkShowPassword
        '
        Me.chkShowPassword.AutoSize = True
        Me.chkShowPassword.Depth = 0
        Me.chkShowPassword.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.chkShowPassword.Location = New System.Drawing.Point(929, 291)
        Me.chkShowPassword.Margin = New System.Windows.Forms.Padding(0)
        Me.chkShowPassword.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.chkShowPassword.MouseState = MaterialSkin.MouseState.HOVER
        Me.chkShowPassword.Name = "chkShowPassword"
        Me.chkShowPassword.Ripple = True
        Me.chkShowPassword.Size = New System.Drawing.Size(128, 30)
        Me.chkShowPassword.TabIndex = 10
        Me.chkShowPassword.Text = "Show Password"
        Me.chkShowPassword.UseVisualStyleBackColor = True
        '
        'btnChangePassword
        '
        Me.btnChangePassword.Depth = 0
        Me.btnChangePassword.Location = New System.Drawing.Point(1130, 239)
        Me.btnChangePassword.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnChangePassword.Name = "btnChangePassword"
        Me.btnChangePassword.Primary = True
        Me.btnChangePassword.Size = New System.Drawing.Size(93, 50)
        Me.btnChangePassword.TabIndex = 9
        Me.btnChangePassword.Text = "Change Password"
        Me.btnChangePassword.UseVisualStyleBackColor = True
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPassword.Location = New System.Drawing.Point(929, 264)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPassword.Size = New System.Drawing.Size(180, 22)
        Me.txtNewPassword.TabIndex = 12
        '
        'txtCurrentPassword
        '
        Me.txtCurrentPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrentPassword.Location = New System.Drawing.Point(929, 239)
        Me.txtCurrentPassword.Name = "txtCurrentPassword"
        Me.txtCurrentPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtCurrentPassword.Size = New System.Drawing.Size(180, 22)
        Me.txtCurrentPassword.TabIndex = 11
        '
        'btnRestore
        '
        Me.btnRestore.Depth = 0
        Me.btnRestore.Location = New System.Drawing.Point(1130, 144)
        Me.btnRestore.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.Primary = True
        Me.btnRestore.Size = New System.Drawing.Size(93, 23)
        Me.btnRestore.TabIndex = 7
        Me.btnRestore.Text = "Restore"
        Me.btnRestore.UseVisualStyleBackColor = True
        '
        'btnBrowse
        '
        Me.btnBrowse.Depth = 0
        Me.btnBrowse.Location = New System.Drawing.Point(1130, 116)
        Me.btnBrowse.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Primary = True
        Me.btnBrowse.Size = New System.Drawing.Size(93, 23)
        Me.btnBrowse.TabIndex = 7
        Me.btnBrowse.Text = "Backup"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'txtClericalVerbalTime
        '
        Me.txtClericalVerbalTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClericalVerbalTime.Location = New System.Drawing.Point(266, 440)
        Me.txtClericalVerbalTime.Name = "txtClericalVerbalTime"
        Me.txtClericalVerbalTime.Size = New System.Drawing.Size(45, 22)
        Me.txtClericalVerbalTime.TabIndex = 10
        '
        'txtAbstractReasoningTime
        '
        Me.txtAbstractReasoningTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAbstractReasoningTime.Location = New System.Drawing.Point(266, 390)
        Me.txtAbstractReasoningTime.Name = "txtAbstractReasoningTime"
        Me.txtAbstractReasoningTime.Size = New System.Drawing.Size(45, 22)
        Me.txtAbstractReasoningTime.TabIndex = 8
        '
        'txtNonSupervisoryVerbalTime
        '
        Me.txtNonSupervisoryVerbalTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNonSupervisoryVerbalTime.Location = New System.Drawing.Point(266, 265)
        Me.txtNonSupervisoryVerbalTime.Name = "txtNonSupervisoryVerbalTime"
        Me.txtNonSupervisoryVerbalTime.Size = New System.Drawing.Size(45, 22)
        Me.txtNonSupervisoryVerbalTime.TabIndex = 5
        '
        'txtClericalNumericalTime
        '
        Me.txtClericalNumericalTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClericalNumericalTime.Location = New System.Drawing.Point(266, 415)
        Me.txtClericalNumericalTime.Name = "txtClericalNumericalTime"
        Me.txtClericalNumericalTime.Size = New System.Drawing.Size(45, 22)
        Me.txtClericalNumericalTime.TabIndex = 9
        '
        'txtSupervisoryVerbalTime
        '
        Me.txtSupervisoryVerbalTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupervisoryVerbalTime.Location = New System.Drawing.Point(266, 144)
        Me.txtSupervisoryVerbalTime.Name = "txtSupervisoryVerbalTime"
        Me.txtSupervisoryVerbalTime.Size = New System.Drawing.Size(45, 22)
        Me.txtSupervisoryVerbalTime.TabIndex = 2
        '
        'txtClericalReasoningTime
        '
        Me.txtClericalReasoningTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClericalReasoningTime.Location = New System.Drawing.Point(266, 365)
        Me.txtClericalReasoningTime.Name = "txtClericalReasoningTime"
        Me.txtClericalReasoningTime.Size = New System.Drawing.Size(45, 22)
        Me.txtClericalReasoningTime.TabIndex = 7
        '
        'txtGeneralInfoTime
        '
        Me.txtGeneralInfoTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGeneralInfoTime.Location = New System.Drawing.Point(266, 340)
        Me.txtGeneralInfoTime.Name = "txtGeneralInfoTime"
        Me.txtGeneralInfoTime.Size = New System.Drawing.Size(45, 22)
        Me.txtGeneralInfoTime.TabIndex = 6
        '
        'txtNonSupervisoryNumericalTime
        '
        Me.txtNonSupervisoryNumericalTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNonSupervisoryNumericalTime.Location = New System.Drawing.Point(266, 240)
        Me.txtNonSupervisoryNumericalTime.Name = "txtNonSupervisoryNumericalTime"
        Me.txtNonSupervisoryNumericalTime.Size = New System.Drawing.Size(45, 22)
        Me.txtNonSupervisoryNumericalTime.TabIndex = 4
        '
        'txtReadingComprehensionTime
        '
        Me.txtReadingComprehensionTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReadingComprehensionTime.Location = New System.Drawing.Point(266, 216)
        Me.txtReadingComprehensionTime.Name = "txtReadingComprehensionTime"
        Me.txtReadingComprehensionTime.Size = New System.Drawing.Size(45, 22)
        Me.txtReadingComprehensionTime.TabIndex = 3
        '
        'txtSupervisoryNumericalTime
        '
        Me.txtSupervisoryNumericalTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupervisoryNumericalTime.Location = New System.Drawing.Point(266, 119)
        Me.txtSupervisoryNumericalTime.Name = "txtSupervisoryNumericalTime"
        Me.txtSupervisoryNumericalTime.Size = New System.Drawing.Size(45, 22)
        Me.txtSupervisoryNumericalTime.TabIndex = 1
        '
        'txtManagementTime
        '
        Me.txtManagementTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtManagementTime.Location = New System.Drawing.Point(266, 93)
        Me.txtManagementTime.Name = "txtManagementTime"
        Me.txtManagementTime.Size = New System.Drawing.Size(45, 22)
        Me.txtManagementTime.TabIndex = 0
        '
        'MaterialDivider13
        '
        Me.MaterialDivider13.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider13.Depth = 0
        Me.MaterialDivider13.Location = New System.Drawing.Point(334, 59)
        Me.MaterialDivider13.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider13.Name = "MaterialDivider13"
        Me.MaterialDivider13.Size = New System.Drawing.Size(2, 453)
        Me.MaterialDivider13.TabIndex = 5
        Me.MaterialDivider13.Text = "MaterialDivider2"
        '
        'MaterialDivider2
        '
        Me.MaterialDivider2.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider2.Depth = 0
        Me.MaterialDivider2.Location = New System.Drawing.Point(769, 59)
        Me.MaterialDivider2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider2.Name = "MaterialDivider2"
        Me.MaterialDivider2.Size = New System.Drawing.Size(2, 453)
        Me.MaterialDivider2.TabIndex = 5
        Me.MaterialDivider2.Text = "MaterialDivider2"
        '
        'MaterialDivider1
        '
        Me.MaterialDivider1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider1.Depth = 0
        Me.MaterialDivider1.Location = New System.Drawing.Point(6, 48)
        Me.MaterialDivider1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider1.Name = "MaterialDivider1"
        Me.MaterialDivider1.Size = New System.Drawing.Size(1236, 3)
        Me.MaterialDivider1.TabIndex = 4
        Me.MaterialDivider1.Text = "MaterialDivider1"
        '
        'btnTimerSave
        '
        Me.btnTimerSave.Depth = 0
        Me.btnTimerSave.Location = New System.Drawing.Point(43, 477)
        Me.btnTimerSave.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnTimerSave.Name = "btnTimerSave"
        Me.btnTimerSave.Primary = True
        Me.btnTimerSave.Size = New System.Drawing.Size(255, 37)
        Me.btnTimerSave.TabIndex = 3
        Me.btnTimerSave.Text = "Save All Timers"
        Me.btnTimerSave.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(173, 443)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(87, 16)
        Me.Label23.TabIndex = 2
        Me.Label23.Text = "Verbal Ability"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(134, 393)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(126, 16)
        Me.Label21.TabIndex = 2
        Me.Label21.Text = "Abstract Reasoning"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(152, 418)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(108, 16)
        Me.Label22.TabIndex = 2
        Me.Label22.Text = "Numerical Ability"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(173, 268)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(87, 16)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Verbal Ability"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(138, 368)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(122, 16)
        Me.Label20.TabIndex = 2
        Me.Label20.Text = "Clerical Reasoning"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(173, 144)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(87, 16)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Verbal Ability"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(50, 343)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(210, 16)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "General Information and Concepts"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(152, 243)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(108, 16)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "Numerical Ability"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(813, 267)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(101, 16)
        Me.Label29.TabIndex = 2
        Me.Label29.Text = "New Password:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(827, 147)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(87, 16)
        Me.Label26.TabIndex = 2
        Me.Label26.Text = "Last Restore:"
        '
        'lblLastRestore
        '
        Me.lblLastRestore.AutoSize = True
        Me.lblLastRestore.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastRestore.Location = New System.Drawing.Point(926, 147)
        Me.lblLastRestore.Name = "lblLastRestore"
        Me.lblLastRestore.Size = New System.Drawing.Size(155, 16)
        Me.lblLastRestore.TabIndex = 2
        Me.lblLastRestore.Text = "Month 00, YYYY, HH-MM"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(798, 242)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(116, 16)
        Me.Label28.TabIndex = 2
        Me.Label28.Text = "Current Password:"
        '
        'lblLastBackup
        '
        Me.lblLastBackup.AutoSize = True
        Me.lblLastBackup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastBackup.Location = New System.Drawing.Point(926, 119)
        Me.lblLastBackup.Name = "lblLastBackup"
        Me.lblLastBackup.Size = New System.Drawing.Size(155, 16)
        Me.lblLastBackup.TabIndex = 2
        Me.lblLastBackup.Text = "Month 00, YYYY, HH-MM"
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.Location = New System.Drawing.Point(351, 63)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(99, 16)
        Me.Label65.TabIndex = 2
        Me.Label65.Text = "Email Address:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(829, 119)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(85, 16)
        Me.Label25.TabIndex = 2
        Me.Label25.Text = "Last Backup:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(102, 219)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(158, 16)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "Reading Comprehension"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(152, 119)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(108, 16)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Numerical Ability"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(23, 96)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(237, 16)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Management and Leadership Concept"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(134, 313)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 16)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Clerical"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(947, 209)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(123, 16)
        Me.Label27.TabIndex = 1
        Me.Label27.Text = "Admin Password"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(917, 84)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(192, 16)
        Me.Label24.TabIndex = 1
        Me.Label24.Text = "Backup/Restore Database"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(99, 187)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(124, 16)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Non-Supervisory"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(121, 63)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 16)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Supervisory"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(780, 19)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(116, 20)
        Me.Label32.TabIndex = 0
        Me.Label32.Text = "Administrator"
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.Location = New System.Drawing.Point(344, 342)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(235, 16)
        Me.Label64.TabIndex = 0
        Me.Label64.Text = "Mail Message - For Non-Passers"
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.Location = New System.Drawing.Point(345, 207)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(202, 16)
        Me.Label63.TabIndex = 0
        Me.Label63.Text = "Mail Message - For Passers"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(346, 19)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(125, 20)
        Me.Label42.TabIndex = 0
        Me.Label42.Text = "Email Settings"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(10, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(182, 20)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Exam Timer (minutes)"
        '
        'mtsAdminDashboard
        '
        Me.mtsAdminDashboard.BaseTabControl = Me.mtcAdminDashboard
        Me.mtsAdminDashboard.Depth = 0
        Me.mtsAdminDashboard.Location = New System.Drawing.Point(12, 179)
        Me.mtsAdminDashboard.MouseState = MaterialSkin.MouseState.HOVER
        Me.mtsAdminDashboard.Name = "mtsAdminDashboard"
        Me.mtsAdminDashboard.Size = New System.Drawing.Size(1252, 23)
        Me.mtsAdminDashboard.TabIndex = 3
        Me.mtsAdminDashboard.Text = "MaterialTabSelector1"
        '
        'ofdRestore
        '
        Me.ofdRestore.FileName = "OpenFileDialog1"
        '
        'btnBackLogin
        '
        Me.btnBackLogin.Depth = 0
        Me.btnBackLogin.Location = New System.Drawing.Point(1152, 73)
        Me.btnBackLogin.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnBackLogin.Name = "btnBackLogin"
        Me.btnBackLogin.Primary = True
        Me.btnBackLogin.Size = New System.Drawing.Size(112, 37)
        Me.btnBackLogin.TabIndex = 5
        Me.btnBackLogin.Text = "Back to Login"
        Me.btnBackLogin.UseVisualStyleBackColor = True
        '
        'btnUserManual
        '
        Me.btnUserManual.Depth = 0
        Me.btnUserManual.Location = New System.Drawing.Point(1152, 135)
        Me.btnUserManual.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnUserManual.Name = "btnUserManual"
        Me.btnUserManual.Primary = True
        Me.btnUserManual.Size = New System.Drawing.Size(112, 37)
        Me.btnUserManual.TabIndex = 6
        Me.btnUserManual.Text = "User Manual"
        Me.btnUserManual.UseVisualStyleBackColor = True
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(116, 86)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(653, 24)
        Me.Label31.TabIndex = 8
        Me.Label31.Text = "Republic of the Philippines - Department Of Science and Technology"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(117, 135)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(399, 31)
        Me.Label33.TabIndex = 10
        Me.Label33.Text = "Pre-Qualification Examination"
        '
        'MaterialDivider4
        '
        Me.MaterialDivider4.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider4.Depth = 0
        Me.MaterialDivider4.Location = New System.Drawing.Point(117, 120)
        Me.MaterialDivider4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider4.Name = "MaterialDivider4"
        Me.MaterialDivider4.Size = New System.Drawing.Size(1147, 6)
        Me.MaterialDivider4.TabIndex = 9
        Me.MaterialDivider4.Text = "MaterialDivider3"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PQE.My.Resources.Resources.dost
        Me.PictureBox1.Location = New System.Drawing.Point(11, 72)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'AdminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1280, 768)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.MaterialDivider4)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.btnUserManual)
        Me.Controls.Add(Me.btnBackLogin)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.mtsAdminDashboard)
        Me.Controls.Add(Me.mtcAdminDashboard)
        Me.Name = "AdminDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin Dashboard"
        Me.mtcAdminDashboard.ResumeLayout(False)
        Me.tabExaminee.ResumeLayout(False)
        Me.tabExaminee.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.picExaminee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picExamineeError, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvExaminee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabExam.ResumeLayout(False)
        Me.tabExam.PerformLayout()
        Me.tscQuestion.ContentPanel.ResumeLayout(False)
        Me.tscQuestion.TopToolStripPanel.ResumeLayout(False)
        Me.tscQuestion.TopToolStripPanel.PerformLayout()
        Me.tscQuestion.ResumeLayout(False)
        Me.tscQuestion.PerformLayout()
        Me.tsQuestion.ResumeLayout(False)
        Me.tsQuestion.PerformLayout()
        CType(Me.dgvExam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picExamError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabConfiguration.ResumeLayout(False)
        Me.tabConfiguration.PerformLayout()
        CType(Me.dgvTempo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsPrintExaminee.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtFirstName As TextBoxEx
    Friend WithEvents txtLastName As TextBoxEx
    Friend WithEvents mtcAdminDashboard As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents tabExaminee As TabPage
    Friend WithEvents tabExam As TabPage
    Friend WithEvents tabConfiguration As TabPage
    Friend WithEvents mtsAdminDashboard As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents lblExamineeDateID As Label
    Friend WithEvents dgvExaminee As DataGridView
    Friend WithEvents btnExamineeClear As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnExamineeEdit As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnExamineeRegister As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents cboExamType As ComboBox
    Friend WithEvents cboExamLevel As ComboBox
    Friend WithEvents btnExamClear As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnQuestionDelete As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnQuestionSave As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents txtChoice4 As TextBox
    Friend WithEvents txtChoice3 As TextBox
    Friend WithEvents txtChoice2 As TextBox
    Friend WithEvents txtChoice1 As TextBox
    Friend WithEvents rbChoice4 As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents rbChoice3 As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents rbChoice2 As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents rbChoice1 As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents tscQuestion As ToolStripContainer
    Friend WithEvents rtfQuestion As RichTextBox
    Friend WithEvents tsQuestion As ToolStrip
    Friend WithEvents tsbInsertImage As ToolStripButton
    Friend WithEvents dgvExam As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblKindID As Label
    Friend WithEvents lblExamLevelID As Label
    Friend WithEvents lblExamTypeID As Label
    Friend WithEvents lblQuestionID As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblQuestionCounter As Label
    Friend WithEvents txtClericalVerbalTime As TextBox
    Friend WithEvents txtAbstractReasoningTime As TextBox
    Friend WithEvents txtNonSupervisoryVerbalTime As TextBox
    Friend WithEvents txtClericalNumericalTime As TextBox
    Friend WithEvents txtSupervisoryVerbalTime As TextBox
    Friend WithEvents txtClericalReasoningTime As TextBox
    Friend WithEvents txtGeneralInfoTime As TextBox
    Friend WithEvents txtNonSupervisoryNumericalTime As TextBox
    Friend WithEvents txtReadingComprehensionTime As TextBox
    Friend WithEvents txtSupervisoryNumericalTime As TextBox
    Friend WithEvents txtManagementTime As TextBox
    Friend WithEvents MaterialDivider2 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents MaterialDivider1 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents btnTimerSave As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents Label23 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblExamineeError As Label
    Friend WithEvents picExamineeError As PictureBox
    Friend WithEvents lblExamError As Label
    Friend WithEvents picExamError As PictureBox
    Friend WithEvents lblExamineeCount As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents picExaminee As PictureBox
    Friend WithEvents btnRestore As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnBrowse As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents Label26 As Label
    Friend WithEvents lblLastRestore As Label
    Friend WithEvents lblLastBackup As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents sfdBackup As SaveFileDialog
    Friend WithEvents ofdRestore As OpenFileDialog
    Friend WithEvents btnChangePassword As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents txtCurrentPassword As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents chkShowPassword As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBackLogin As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnUserManual As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnPrintExamineeDgv As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnRefreshExamineeDgv As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents Label30 As Label
    Friend WithEvents tslInsertImage As ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbChangeFont As ToolStripButton
    Friend WithEvents tslChangeFont As ToolStripLabel
    Friend WithEvents cmsPrintExaminee As MaterialSkin.Controls.MaterialContextMenuStrip
    Friend WithEvents tsmPrintExaminee As ToolStripMenuItem
    Friend WithEvents fdChangeFont As FontDialog
    Friend WithEvents Label31 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents MaterialDivider4 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents btnExportToExcel As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents sfdExcel As SaveFileDialog
    Friend WithEvents Label37 As Label
    Friend WithEvents cboExamSet As ComboBox
    Friend WithEvents lblExamSet As Label
    Friend WithEvents btnTempoAdd As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnTempoDelete As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents txtTempoPass As TextBox
    Friend WithEvents txtTempoUser As TextBox
    Friend WithEvents Label39 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents dgvTempo As DataGridView
    Friend WithEvents btnChangePicture As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cboPositionFilter As ComboBox
    Friend WithEvents Label43 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents btnSearch As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnClearFilter As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Label46 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents dtpFromFilter As DateTimePicker
    Friend WithEvents chkDateFilter As CheckBox
    Friend WithEvents dtpToFilter As DateTimePicker
    Friend WithEvents rbNoResultFilter As RadioButton
    Friend WithEvents rbFailedFilter As RadioButton
    Friend WithEvents rbPassedFilter As RadioButton
    Friend WithEvents Label47 As Label
    Friend WithEvents txtFirstNameFilter As TextBox
    Friend WithEvents txtLastNameFilter As TextBox
    Friend WithEvents Label48 As Label
    Friend WithEvents MaterialDivider3 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents MaterialDivider6 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents Label32 As Label
    Friend WithEvents Label51 As Label
    Friend WithEvents Label50 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents Label52 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cboSupervisoryPosition As ComboBox
    Friend WithEvents cboNonSupervisoryPosition As ComboBox
    Friend WithEvents cboClericalPosition As ComboBox
    Friend WithEvents Label59 As Label
    Friend WithEvents Label60 As Label
    Friend WithEvents Label61 As Label
    Friend WithEvents Label56 As Label
    Friend WithEvents Label57 As Label
    Friend WithEvents Label58 As Label
    Friend WithEvents Label55 As Label
    Friend WithEvents Label54 As Label
    Friend WithEvents Label53 As Label
    Friend WithEvents txtClericalResultB As Label
    Friend WithEvents txtNonSupervisoryResultB As Label
    Friend WithEvents txtClericalResultC As Label
    Friend WithEvents txtSupervisoryResultB As Label
    Friend WithEvents txtNonSupervisoryResultC As Label
    Friend WithEvents txtClericalResultA As Label
    Friend WithEvents txtNonSupervisoryResultA As Label
    Friend WithEvents txtSupervisoryResultC As Label
    Friend WithEvents txtSupervisoryResultA As Label
    Friend WithEvents rbClericalActive As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents rbNonSupervisoryActive As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents rbSupervisoryActive As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents txtEmailAddress As TextBoxEx
    Friend WithEvents Label38 As Label
    Friend WithEvents lblLastNameError As Label
    Friend WithEvents lblFirstNameError As Label
    Friend WithEvents lblEmailError As Label
    Friend WithEvents MaterialDivider7 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents MaterialDivider9 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents MaterialDivider10 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents MaterialDivider11 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents MaterialDivider5 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents MaterialDivider8 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents MaterialDivider12 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents txtExamineeIDFilter As TextBox
    Friend WithEvents Label62 As Label
    Friend WithEvents btnPrintClericalA As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnPrintNonSupervisoryA As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnPrintSupervisoryA As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnPrintSupervisoryC As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnPrintSupervisoryB As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnPrintClericalC As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnPrintClericalB As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnPrintNonSupervisoryC As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnPrintNonSupervisoryB As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialDivider13 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents MaterialDivider14 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents MaterialDivider15 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents Label42 As Label
    Friend WithEvents MaterialDivider17 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents MaterialDivider16 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents Label66 As Label
    Friend WithEvents Label65 As Label
    Friend WithEvents Label68 As Label
    Friend WithEvents Label67 As Label
    Friend WithEvents txtSettingGmailAppPassword As TextBoxEx
    Friend WithEvents txtSettingSmtpPort As TextBoxEx
    Friend WithEvents txtSettingSmtp As TextBoxEx
    Friend WithEvents txtSettingEmailAddress As TextBoxEx
    Friend WithEvents btnEmailSettingsSave As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents Label64 As Label
    Friend WithEvents Label63 As Label
    Friend WithEvents MaterialDivider18 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents txtSettingMailSubject As TextBoxEx
    Friend WithEvents Label69 As Label
    Friend WithEvents txtSettingMessagePasser As RichTextBox
    Friend WithEvents MaterialDivider19 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents txtSettingMessageNonPasser As RichTextBox
End Class
