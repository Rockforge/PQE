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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnUserManual = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnBackLogin = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.dgvExaminee = New System.Windows.Forms.DataGridView()
        Me.lblExamineeCount = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.lblExamineeError = New System.Windows.Forms.Label()
        Me.picExamineeError = New System.Windows.Forms.PictureBox()
        Me.btnExamineeClear = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnExamineeEdit = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnExamineeRegister = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.lblExamineeID = New System.Windows.Forms.Label()
        Me.cboExamineePosition = New System.Windows.Forms.ComboBox()
        Me.cboExamineeLevel = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.picExaminee = New System.Windows.Forms.PictureBox()
        Me.btnRefreshExamineeDgv = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.sfdBackup = New System.Windows.Forms.SaveFileDialog()
        Me.cboExamineeSet = New System.Windows.Forms.ComboBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.btnChangePicture = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialDivider5 = New MaterialSkin.Controls.MaterialDivider()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.MaterialDivider4 = New MaterialSkin.Controls.MaterialDivider()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.MaterialDivider1 = New MaterialSkin.Controls.MaterialDivider()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MaterialDivider6 = New MaterialSkin.Controls.MaterialDivider()
        Me.chkDateFilter = New System.Windows.Forms.CheckBox()
        Me.dtpToFilter = New System.Windows.Forms.DateTimePicker()
        Me.dtpFromFilter = New System.Windows.Forms.DateTimePicker()
        Me.btnSearch = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnClearFilter = New MaterialSkin.Controls.MaterialFlatButton()
        Me.cboPositionFilter = New System.Windows.Forms.ComboBox()
        Me.cboLevelFilter = New System.Windows.Forms.ComboBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.txtFirstNameFilter = New System.Windows.Forms.TextBox()
        Me.txtLastNameFilter = New System.Windows.Forms.TextBox()
        Me.Label48 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvExaminee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picExamineeError, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picExaminee, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'dgvExaminee
        '
        Me.dgvExaminee.AllowUserToAddRows = False
        Me.dgvExaminee.AllowUserToDeleteRows = False
        Me.dgvExaminee.AllowUserToResizeColumns = False
        Me.dgvExaminee.AllowUserToResizeRows = False
        Me.dgvExaminee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvExaminee.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
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
        Me.dgvExaminee.Location = New System.Drawing.Point(22, 450)
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
        Me.dgvExaminee.Size = New System.Drawing.Size(1236, 278)
        Me.dgvExaminee.TabIndex = 19
        '
        'lblExamineeCount
        '
        Me.lblExamineeCount.AutoSize = True
        Me.lblExamineeCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExamineeCount.Location = New System.Drawing.Point(1151, 425)
        Me.lblExamineeCount.Name = "lblExamineeCount"
        Me.lblExamineeCount.Size = New System.Drawing.Size(105, 16)
        Me.lblExamineeCount.TabIndex = 21
        Me.lblExamineeCount.Text = "Examinee Count"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(1004, 425)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(141, 16)
        Me.Label30.TabIndex = 20
        Me.Label30.Text = "Registered Examinee:"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(679, 262)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(170, 13)
        Me.Label34.TabIndex = 37
        Me.Label34.Text = "Register Button behind Edit Button"
        Me.Label34.Visible = False
        '
        'lblExamineeError
        '
        Me.lblExamineeError.AutoSize = True
        Me.lblExamineeError.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExamineeError.Location = New System.Drawing.Point(738, 249)
        Me.lblExamineeError.Name = "lblExamineeError"
        Me.lblExamineeError.Size = New System.Drawing.Size(97, 16)
        Me.lblExamineeError.TabIndex = 36
        Me.lblExamineeError.Text = "Error Message"
        Me.lblExamineeError.Visible = False
        '
        'picExamineeError
        '
        Me.picExamineeError.Image = Global.PQE.My.Resources.Resources.error1
        Me.picExamineeError.Location = New System.Drawing.Point(682, 225)
        Me.picExamineeError.Name = "picExamineeError"
        Me.picExamineeError.Size = New System.Drawing.Size(50, 50)
        Me.picExamineeError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picExamineeError.TabIndex = 35
        Me.picExamineeError.TabStop = False
        Me.picExamineeError.Visible = False
        '
        'btnExamineeClear
        '
        Me.btnExamineeClear.Depth = 0
        Me.btnExamineeClear.Location = New System.Drawing.Point(682, 346)
        Me.btnExamineeClear.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnExamineeClear.Name = "btnExamineeClear"
        Me.btnExamineeClear.Primary = True
        Me.btnExamineeClear.Size = New System.Drawing.Size(130, 44)
        Me.btnExamineeClear.TabIndex = 32
        Me.btnExamineeClear.Text = "Clear Fields"
        Me.btnExamineeClear.UseVisualStyleBackColor = True
        '
        'btnExamineeEdit
        '
        Me.btnExamineeEdit.Depth = 0
        Me.btnExamineeEdit.Location = New System.Drawing.Point(682, 288)
        Me.btnExamineeEdit.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnExamineeEdit.Name = "btnExamineeEdit"
        Me.btnExamineeEdit.Primary = True
        Me.btnExamineeEdit.Size = New System.Drawing.Size(130, 44)
        Me.btnExamineeEdit.TabIndex = 33
        Me.btnExamineeEdit.Text = "Edit"
        Me.btnExamineeEdit.UseVisualStyleBackColor = True
        '
        'btnExamineeRegister
        '
        Me.btnExamineeRegister.Depth = 0
        Me.btnExamineeRegister.Location = New System.Drawing.Point(682, 288)
        Me.btnExamineeRegister.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnExamineeRegister.Name = "btnExamineeRegister"
        Me.btnExamineeRegister.Primary = True
        Me.btnExamineeRegister.Size = New System.Drawing.Size(130, 44)
        Me.btnExamineeRegister.TabIndex = 34
        Me.btnExamineeRegister.Text = "Register"
        Me.btnExamineeRegister.UseVisualStyleBackColor = True
        '
        'lblExamineeID
        '
        Me.lblExamineeID.AutoSize = True
        Me.lblExamineeID.Location = New System.Drawing.Point(410, 262)
        Me.lblExamineeID.Name = "lblExamineeID"
        Me.lblExamineeID.Size = New System.Drawing.Size(67, 13)
        Me.lblExamineeID.TabIndex = 31
        Me.lblExamineeID.Text = "Examinee ID"
        '
        'cboExamineePosition
        '
        Me.cboExamineePosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboExamineePosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboExamineePosition.FormattingEnabled = True
        Me.cboExamineePosition.Location = New System.Drawing.Point(410, 371)
        Me.cboExamineePosition.Name = "cboExamineePosition"
        Me.cboExamineePosition.Size = New System.Drawing.Size(260, 24)
        Me.cboExamineePosition.TabIndex = 29
        '
        'cboExamineeLevel
        '
        Me.cboExamineeLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboExamineeLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboExamineeLevel.FormattingEnabled = True
        Me.cboExamineeLevel.Location = New System.Drawing.Point(410, 341)
        Me.cboExamineeLevel.Name = "cboExamineeLevel"
        Me.cboExamineeLevel.Size = New System.Drawing.Size(260, 24)
        Me.cboExamineeLevel.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(317, 260)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 16)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Examinee ID:"
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(410, 313)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(260, 22)
        Me.txtLastName.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(328, 288)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 16)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "First Name:"
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(410, 285)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(260, 22)
        Me.txtFirstName.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(328, 316)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 16)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Last Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(316, 374)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Position Title:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(331, 344)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 16)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Level Title:"
        '
        'picExaminee
        '
        Me.picExaminee.Image = Global.PQE.My.Resources.Resources.NoExamineePic
        Me.picExaminee.Location = New System.Drawing.Point(173, 247)
        Me.picExaminee.Name = "picExaminee"
        Me.picExaminee.Size = New System.Drawing.Size(120, 120)
        Me.picExaminee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picExaminee.TabIndex = 38
        Me.picExaminee.TabStop = False
        '
        'btnRefreshExamineeDgv
        '
        Me.btnRefreshExamineeDgv.Depth = 0
        Me.btnRefreshExamineeDgv.Location = New System.Drawing.Point(1118, 733)
        Me.btnRefreshExamineeDgv.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnRefreshExamineeDgv.Name = "btnRefreshExamineeDgv"
        Me.btnRefreshExamineeDgv.Primary = True
        Me.btnRefreshExamineeDgv.Size = New System.Drawing.Size(141, 23)
        Me.btnRefreshExamineeDgv.TabIndex = 39
        Me.btnRefreshExamineeDgv.Text = "Refresh Table"
        Me.btnRefreshExamineeDgv.UseVisualStyleBackColor = True
        '
        'cboExamineeSet
        '
        Me.cboExamineeSet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboExamineeSet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboExamineeSet.FormattingEnabled = True
        Me.cboExamineeSet.Location = New System.Drawing.Point(138, 422)
        Me.cboExamineeSet.Name = "cboExamineeSet"
        Me.cboExamineeSet.Size = New System.Drawing.Size(50, 24)
        Me.cboExamineeSet.TabIndex = 42
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(38, 427)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(94, 16)
        Me.Label38.TabIndex = 41
        Me.Label38.Text = "Examinee Set:"
        '
        'btnChangePicture
        '
        Me.btnChangePicture.Depth = 0
        Me.btnChangePicture.Location = New System.Drawing.Point(173, 373)
        Me.btnChangePicture.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnChangePicture.Name = "btnChangePicture"
        Me.btnChangePicture.Primary = True
        Me.btnChangePicture.Size = New System.Drawing.Size(120, 26)
        Me.btnChangePicture.TabIndex = 43
        Me.btnChangePicture.Text = "Change Picture"
        Me.btnChangePicture.UseVisualStyleBackColor = True
        Me.btnChangePicture.Visible = False
        '
        'MaterialDivider5
        '
        Me.MaterialDivider5.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider5.Depth = 0
        Me.MaterialDivider5.Location = New System.Drawing.Point(37, 419)
        Me.MaterialDivider5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider5.Name = "MaterialDivider5"
        Me.MaterialDivider5.Size = New System.Drawing.Size(1207, 1)
        Me.MaterialDivider5.TabIndex = 44
        Me.MaterialDivider5.Text = "MaterialDivider5"
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MaterialDivider6)
        Me.GroupBox1.Controls.Add(Me.chkDateFilter)
        Me.GroupBox1.Controls.Add(Me.dtpToFilter)
        Me.GroupBox1.Controls.Add(Me.dtpFromFilter)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.btnClearFilter)
        Me.GroupBox1.Controls.Add(Me.cboPositionFilter)
        Me.GroupBox1.Controls.Add(Me.cboLevelFilter)
        Me.GroupBox1.Controls.Add(Me.Label42)
        Me.GroupBox1.Controls.Add(Me.Label46)
        Me.GroupBox1.Controls.Add(Me.Label45)
        Me.GroupBox1.Controls.Add(Me.Label43)
        Me.GroupBox1.Controls.Add(Me.Label47)
        Me.GroupBox1.Controls.Add(Me.txtFirstNameFilter)
        Me.GroupBox1.Controls.Add(Me.txtLastNameFilter)
        Me.GroupBox1.Controls.Add(Me.Label48)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(855, 194)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(404, 226)
        Me.GroupBox1.TabIndex = 49
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Filters"
        '
        'MaterialDivider6
        '
        Me.MaterialDivider6.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider6.Depth = 0
        Me.MaterialDivider6.Location = New System.Drawing.Point(120, 151)
        Me.MaterialDivider6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider6.Name = "MaterialDivider6"
        Me.MaterialDivider6.Size = New System.Drawing.Size(1, 45)
        Me.MaterialDivider6.TabIndex = 19
        Me.MaterialDivider6.Text = "MaterialDivider6"
        '
        'chkDateFilter
        '
        Me.chkDateFilter.AutoSize = True
        Me.chkDateFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDateFilter.Location = New System.Drawing.Point(56, 152)
        Me.chkDateFilter.Name = "chkDateFilter"
        Me.chkDateFilter.Size = New System.Drawing.Size(60, 19)
        Me.chkDateFilter.TabIndex = 5
        Me.chkDateFilter.Text = "DATE:"
        Me.chkDateFilter.UseVisualStyleBackColor = True
        '
        'dtpToFilter
        '
        Me.dtpToFilter.Location = New System.Drawing.Point(173, 176)
        Me.dtpToFilter.Name = "dtpToFilter"
        Me.dtpToFilter.Size = New System.Drawing.Size(207, 20)
        Me.dtpToFilter.TabIndex = 4
        '
        'dtpFromFilter
        '
        Me.dtpFromFilter.Location = New System.Drawing.Point(173, 148)
        Me.dtpFromFilter.Name = "dtpFromFilter"
        Me.dtpFromFilter.Size = New System.Drawing.Size(207, 20)
        Me.dtpFromFilter.TabIndex = 4
        '
        'btnSearch
        '
        Me.btnSearch.Depth = 0
        Me.btnSearch.Location = New System.Drawing.Point(298, 206)
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
        Me.btnClearFilter.Location = New System.Drawing.Point(7, 198)
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
        Me.cboPositionFilter.Location = New System.Drawing.Point(120, 119)
        Me.cboPositionFilter.Name = "cboPositionFilter"
        Me.cboPositionFilter.Size = New System.Drawing.Size(260, 21)
        Me.cboPositionFilter.TabIndex = 1
        '
        'cboLevelFilter
        '
        Me.cboLevelFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLevelFilter.FormattingEnabled = True
        Me.cboLevelFilter.Location = New System.Drawing.Point(120, 93)
        Me.cboLevelFilter.Name = "cboLevelFilter"
        Me.cboLevelFilter.Size = New System.Drawing.Size(260, 21)
        Me.cboLevelFilter.TabIndex = 1
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(49, 96)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(65, 15)
        Me.Label42.TabIndex = 0
        Me.Label42.Text = "Level Title:"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(124, 153)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(43, 15)
        Me.Label46.TabIndex = 0
        Me.Label46.Text = "FROM"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(144, 178)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(23, 15)
        Me.Label45.TabIndex = 0
        Me.Label45.Text = "TO"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(34, 122)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(80, 15)
        Me.Label43.TabIndex = 0
        Me.Label43.Text = "Position Title:"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.Location = New System.Drawing.Point(44, 37)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(70, 15)
        Me.Label47.TabIndex = 0
        Me.Label47.Text = "First Name:"
        '
        'txtFirstNameFilter
        '
        Me.txtFirstNameFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstNameFilter.Location = New System.Drawing.Point(120, 34)
        Me.txtFirstNameFilter.MaxLength = 50
        Me.txtFirstNameFilter.Name = "txtFirstNameFilter"
        Me.txtFirstNameFilter.Size = New System.Drawing.Size(260, 22)
        Me.txtFirstNameFilter.TabIndex = 0
        '
        'txtLastNameFilter
        '
        Me.txtLastNameFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastNameFilter.Location = New System.Drawing.Point(120, 59)
        Me.txtLastNameFilter.MaxLength = 50
        Me.txtLastNameFilter.Name = "txtLastNameFilter"
        Me.txtLastNameFilter.Size = New System.Drawing.Size(260, 22)
        Me.txtLastNameFilter.TabIndex = 1
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.Location = New System.Drawing.Point(44, 62)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(70, 15)
        Me.Label48.TabIndex = 0
        Me.Label48.Text = "Last Name:"
        '
        'AdminTempDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1280, 768)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MaterialDivider1)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.MaterialDivider4)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.MaterialDivider5)
        Me.Controls.Add(Me.btnChangePicture)
        Me.Controls.Add(Me.cboExamineeSet)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.btnRefreshExamineeDgv)
        Me.Controls.Add(Me.picExaminee)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.lblExamineeError)
        Me.Controls.Add(Me.picExamineeError)
        Me.Controls.Add(Me.btnExamineeClear)
        Me.Controls.Add(Me.btnExamineeEdit)
        Me.Controls.Add(Me.btnExamineeRegister)
        Me.Controls.Add(Me.lblExamineeID)
        Me.Controls.Add(Me.cboExamineePosition)
        Me.Controls.Add(Me.cboExamineeLevel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblExamineeCount)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.dgvExaminee)
        Me.Controls.Add(Me.btnUserManual)
        Me.Controls.Add(Me.btnBackLogin)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "AdminTempDashboard"
        Me.Text = "Temporary-Admin Dashboard"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvExaminee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picExamineeError, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picExaminee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnUserManual As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnBackLogin As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents dgvExaminee As DataGridView
    Friend WithEvents lblExamineeCount As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents lblExamineeError As Label
    Friend WithEvents picExamineeError As PictureBox
    Friend WithEvents btnExamineeClear As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnExamineeEdit As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnExamineeRegister As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents lblExamineeID As Label
    Friend WithEvents cboExamineePosition As ComboBox
    Friend WithEvents cboExamineeLevel As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents picExaminee As PictureBox
    Friend WithEvents btnRefreshExamineeDgv As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents sfdBackup As SaveFileDialog
    Friend WithEvents cboExamineeSet As ComboBox
    Friend WithEvents Label38 As Label
    Friend WithEvents btnChangePicture As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialDivider5 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents Label33 As Label
    Friend WithEvents MaterialDivider4 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents Label31 As Label
    Friend WithEvents MaterialDivider1 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MaterialDivider6 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents chkDateFilter As CheckBox
    Friend WithEvents dtpToFilter As DateTimePicker
    Friend WithEvents dtpFromFilter As DateTimePicker
    Friend WithEvents btnSearch As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnClearFilter As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents cboPositionFilter As ComboBox
    Friend WithEvents cboLevelFilter As ComboBox
    Friend WithEvents Label42 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents Label47 As Label
    Friend WithEvents txtFirstNameFilter As TextBox
    Friend WithEvents txtLastNameFilter As TextBox
    Friend WithEvents Label48 As Label
End Class
