<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ExamineeTest
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.rtfQuestion = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblExamineeDateID = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.lblKindID = New System.Windows.Forms.Label()
        Me.lblExamineeID = New System.Windows.Forms.Label()
        Me.lblQuestionID = New System.Windows.Forms.Label()
        Me.lblNumOfQuestion = New System.Windows.Forms.Label()
        Me.lblQuestionCounter = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.tmrTest = New System.Windows.Forms.Timer(Me.components)
        Me.rbChoice1 = New MaterialSkin.Controls.MaterialRadioButton()
        Me.rbChoice2 = New MaterialSkin.Controls.MaterialRadioButton()
        Me.rbChoice3 = New MaterialSkin.Controls.MaterialRadioButton()
        Me.rbChoice4 = New MaterialSkin.Controls.MaterialRadioButton()
        Me.btnQuestionPrevious = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnQuestionNext = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblLevelID = New System.Windows.Forms.Label()
        Me.lblLevelDescription = New System.Windows.Forms.Label()
        Me.lblPositionDescription = New System.Windows.Forms.Label()
        Me.lblScoreHide = New System.Windows.Forms.Label()
        Me.lblSetDescription = New System.Windows.Forms.Label()
        Me.dgvQuestionNumber = New System.Windows.Forms.DataGridView()
        Me.btnAnswer = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnFinishTest = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.rtfChosenAnswer = New System.Windows.Forms.RichTextBox()
        Me.dgvUnansweredQuestion = New System.Windows.Forms.DataGridView()
        Me.lblTestTypeID = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.dgvQuestionNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvUnansweredQuestion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rtfQuestion
        '
        Me.rtfQuestion.Location = New System.Drawing.Point(112, 131)
        Me.rtfQuestion.Name = "rtfQuestion"
        Me.rtfQuestion.ReadOnly = True
        Me.rtfQuestion.Size = New System.Drawing.Size(715, 276)
        Me.rtfQuestion.TabIndex = 0
        Me.rtfQuestion.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Examinee ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "First Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Last Name:"
        '
        'lblExamineeDateID
        '
        Me.lblExamineeDateID.AutoSize = True
        Me.lblExamineeDateID.Location = New System.Drawing.Point(88, 71)
        Me.lblExamineeDateID.Name = "lblExamineeDateID"
        Me.lblExamineeDateID.Size = New System.Drawing.Size(87, 13)
        Me.lblExamineeDateID.TabIndex = 2
        Me.lblExamineeDateID.Text = "ExamineeDateID"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(88, 93)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(54, 13)
        Me.lblFirstName.TabIndex = 2
        Me.lblFirstName.Text = "FirstName"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(88, 115)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(58, 13)
        Me.lblLastName.TabIndex = 2
        Me.lblLastName.Text = "Last Name"
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Location = New System.Drawing.Point(232, 71)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(42, 13)
        Me.lblAnswer.TabIndex = 3
        Me.lblAnswer.Text = "Answer"
        Me.lblAnswer.Visible = False
        '
        'lblKindID
        '
        Me.lblKindID.AutoSize = True
        Me.lblKindID.Location = New System.Drawing.Point(232, 93)
        Me.lblKindID.Name = "lblKindID"
        Me.lblKindID.Size = New System.Drawing.Size(42, 13)
        Me.lblKindID.TabIndex = 3
        Me.lblKindID.Text = "Kind ID"
        Me.lblKindID.Visible = False
        '
        'lblExamineeID
        '
        Me.lblExamineeID.AutoSize = True
        Me.lblExamineeID.Location = New System.Drawing.Point(232, 115)
        Me.lblExamineeID.Name = "lblExamineeID"
        Me.lblExamineeID.Size = New System.Drawing.Size(67, 13)
        Me.lblExamineeID.TabIndex = 3
        Me.lblExamineeID.Text = "Examinee ID"
        Me.lblExamineeID.Visible = False
        '
        'lblQuestionID
        '
        Me.lblQuestionID.AutoSize = True
        Me.lblQuestionID.Location = New System.Drawing.Point(334, 71)
        Me.lblQuestionID.Name = "lblQuestionID"
        Me.lblQuestionID.Size = New System.Drawing.Size(63, 13)
        Me.lblQuestionID.TabIndex = 3
        Me.lblQuestionID.Text = "Question ID"
        Me.lblQuestionID.Visible = False
        '
        'lblNumOfQuestion
        '
        Me.lblNumOfQuestion.AutoSize = True
        Me.lblNumOfQuestion.Location = New System.Drawing.Point(334, 93)
        Me.lblNumOfQuestion.Name = "lblNumOfQuestion"
        Me.lblNumOfQuestion.Size = New System.Drawing.Size(101, 13)
        Me.lblNumOfQuestion.TabIndex = 3
        Me.lblNumOfQuestion.Text = "Number of Question"
        Me.lblNumOfQuestion.Visible = False
        '
        'lblQuestionCounter
        '
        Me.lblQuestionCounter.AutoSize = True
        Me.lblQuestionCounter.Location = New System.Drawing.Point(334, 115)
        Me.lblQuestionCounter.Name = "lblQuestionCounter"
        Me.lblQuestionCounter.Size = New System.Drawing.Size(89, 13)
        Me.lblQuestionCounter.TabIndex = 3
        Me.lblQuestionCounter.Text = "Question Counter"
        Me.lblQuestionCounter.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(682, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Timer:"
        '
        'lblTimer
        '
        Me.lblTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.Location = New System.Drawing.Point(724, 86)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(158, 20)
        Me.lblTimer.TabIndex = 5
        Me.lblTimer.Text = "Time in Mins."
        '
        'tmrTest
        '
        Me.tmrTest.Interval = 60000
        '
        'rbChoice1
        '
        Me.rbChoice1.AutoSize = True
        Me.rbChoice1.Depth = 0
        Me.rbChoice1.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rbChoice1.Location = New System.Drawing.Point(112, 410)
        Me.rbChoice1.Margin = New System.Windows.Forms.Padding(0)
        Me.rbChoice1.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rbChoice1.MouseState = MaterialSkin.MouseState.HOVER
        Me.rbChoice1.Name = "rbChoice1"
        Me.rbChoice1.Ripple = True
        Me.rbChoice1.Size = New System.Drawing.Size(83, 30)
        Me.rbChoice1.TabIndex = 6
        Me.rbChoice1.TabStop = True
        Me.rbChoice1.Text = "Choice 1"
        Me.rbChoice1.UseVisualStyleBackColor = True
        '
        'rbChoice2
        '
        Me.rbChoice2.AutoSize = True
        Me.rbChoice2.Depth = 0
        Me.rbChoice2.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rbChoice2.Location = New System.Drawing.Point(112, 440)
        Me.rbChoice2.Margin = New System.Windows.Forms.Padding(0)
        Me.rbChoice2.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rbChoice2.MouseState = MaterialSkin.MouseState.HOVER
        Me.rbChoice2.Name = "rbChoice2"
        Me.rbChoice2.Ripple = True
        Me.rbChoice2.Size = New System.Drawing.Size(83, 30)
        Me.rbChoice2.TabIndex = 6
        Me.rbChoice2.TabStop = True
        Me.rbChoice2.Text = "Choice 2"
        Me.rbChoice2.UseVisualStyleBackColor = True
        '
        'rbChoice3
        '
        Me.rbChoice3.AutoSize = True
        Me.rbChoice3.Depth = 0
        Me.rbChoice3.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rbChoice3.Location = New System.Drawing.Point(112, 470)
        Me.rbChoice3.Margin = New System.Windows.Forms.Padding(0)
        Me.rbChoice3.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rbChoice3.MouseState = MaterialSkin.MouseState.HOVER
        Me.rbChoice3.Name = "rbChoice3"
        Me.rbChoice3.Ripple = True
        Me.rbChoice3.Size = New System.Drawing.Size(83, 30)
        Me.rbChoice3.TabIndex = 6
        Me.rbChoice3.TabStop = True
        Me.rbChoice3.Text = "Choice 3"
        Me.rbChoice3.UseVisualStyleBackColor = True
        '
        'rbChoice4
        '
        Me.rbChoice4.AutoSize = True
        Me.rbChoice4.Depth = 0
        Me.rbChoice4.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rbChoice4.Location = New System.Drawing.Point(112, 500)
        Me.rbChoice4.Margin = New System.Windows.Forms.Padding(0)
        Me.rbChoice4.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rbChoice4.MouseState = MaterialSkin.MouseState.HOVER
        Me.rbChoice4.Name = "rbChoice4"
        Me.rbChoice4.Ripple = True
        Me.rbChoice4.Size = New System.Drawing.Size(83, 30)
        Me.rbChoice4.TabIndex = 6
        Me.rbChoice4.TabStop = True
        Me.rbChoice4.Text = "Choice 4"
        Me.rbChoice4.UseVisualStyleBackColor = True
        '
        'btnQuestionPrevious
        '
        Me.btnQuestionPrevious.Depth = 0
        Me.btnQuestionPrevious.Location = New System.Drawing.Point(115, 585)
        Me.btnQuestionPrevious.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnQuestionPrevious.Name = "btnQuestionPrevious"
        Me.btnQuestionPrevious.Primary = True
        Me.btnQuestionPrevious.Size = New System.Drawing.Size(230, 30)
        Me.btnQuestionPrevious.TabIndex = 7
        Me.btnQuestionPrevious.Text = "Previous"
        Me.btnQuestionPrevious.UseVisualStyleBackColor = True
        '
        'btnQuestionNext
        '
        Me.btnQuestionNext.Depth = 0
        Me.btnQuestionNext.Location = New System.Drawing.Point(591, 585)
        Me.btnQuestionNext.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnQuestionNext.Name = "btnQuestionNext"
        Me.btnQuestionNext.Primary = True
        Me.btnQuestionNext.Size = New System.Drawing.Size(230, 30)
        Me.btnQuestionNext.TabIndex = 7
        Me.btnQuestionNext.Text = "Next"
        Me.btnQuestionNext.UseVisualStyleBackColor = True
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Location = New System.Drawing.Point(441, 71)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(60, 13)
        Me.lblScore.TabIndex = 3
        Me.lblScore.Text = "Hide Score"
        Me.lblScore.Visible = False
        '
        'lblLevelID
        '
        Me.lblLevelID.AutoSize = True
        Me.lblLevelID.Location = New System.Drawing.Point(441, 93)
        Me.lblLevelID.Name = "lblLevelID"
        Me.lblLevelID.Size = New System.Drawing.Size(72, 13)
        Me.lblLevelID.TabIndex = 3
        Me.lblLevelID.Text = "Hide Level ID"
        Me.lblLevelID.Visible = False
        '
        'lblLevelDescription
        '
        Me.lblLevelDescription.AutoSize = True
        Me.lblLevelDescription.Location = New System.Drawing.Point(441, 115)
        Me.lblLevelDescription.Name = "lblLevelDescription"
        Me.lblLevelDescription.Size = New System.Drawing.Size(86, 13)
        Me.lblLevelDescription.TabIndex = 3
        Me.lblLevelDescription.Text = "Hide Level Desc"
        Me.lblLevelDescription.Visible = False
        '
        'lblPositionDescription
        '
        Me.lblPositionDescription.AutoSize = True
        Me.lblPositionDescription.Location = New System.Drawing.Point(533, 115)
        Me.lblPositionDescription.Name = "lblPositionDescription"
        Me.lblPositionDescription.Size = New System.Drawing.Size(97, 13)
        Me.lblPositionDescription.TabIndex = 3
        Me.lblPositionDescription.Text = "Hide Position Desc"
        Me.lblPositionDescription.Visible = False
        '
        'lblScoreHide
        '
        Me.lblScoreHide.AutoSize = True
        Me.lblScoreHide.Location = New System.Drawing.Point(453, 71)
        Me.lblScoreHide.Name = "lblScoreHide"
        Me.lblScoreHide.Size = New System.Drawing.Size(60, 13)
        Me.lblScoreHide.TabIndex = 3
        Me.lblScoreHide.Text = "Hide Score"
        Me.lblScoreHide.Visible = False
        '
        'lblSetDescription
        '
        Me.lblSetDescription.AutoSize = True
        Me.lblSetDescription.Location = New System.Drawing.Point(517, 71)
        Me.lblSetDescription.Name = "lblSetDescription"
        Me.lblSetDescription.Size = New System.Drawing.Size(23, 13)
        Me.lblSetDescription.TabIndex = 8
        Me.lblSetDescription.Text = "Set"
        Me.lblSetDescription.Visible = False
        '
        'dgvQuestionNumber
        '
        Me.dgvQuestionNumber.AllowUserToAddRows = False
        Me.dgvQuestionNumber.AllowUserToDeleteRows = False
        Me.dgvQuestionNumber.AllowUserToResizeColumns = False
        Me.dgvQuestionNumber.AllowUserToResizeRows = False
        Me.dgvQuestionNumber.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvQuestionNumber.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvQuestionNumber.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvQuestionNumber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvQuestionNumber.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvQuestionNumber.EnableHeadersVisualStyles = False
        Me.dgvQuestionNumber.GridColor = System.Drawing.SystemColors.MenuBar
        Me.dgvQuestionNumber.Location = New System.Drawing.Point(15, 131)
        Me.dgvQuestionNumber.Name = "dgvQuestionNumber"
        Me.dgvQuestionNumber.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvQuestionNumber.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvQuestionNumber.RowHeadersVisible = False
        Me.dgvQuestionNumber.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvQuestionNumber.Size = New System.Drawing.Size(91, 484)
        Me.dgvQuestionNumber.TabIndex = 10
        '
        'btnAnswer
        '
        Me.btnAnswer.Depth = 0
        Me.btnAnswer.Location = New System.Drawing.Point(353, 585)
        Me.btnAnswer.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnAnswer.Name = "btnAnswer"
        Me.btnAnswer.Primary = True
        Me.btnAnswer.Size = New System.Drawing.Size(230, 30)
        Me.btnAnswer.TabIndex = 11
        Me.btnAnswer.Text = "Answer"
        Me.btnAnswer.UseVisualStyleBackColor = True
        '
        'btnFinishTest
        '
        Me.btnFinishTest.Depth = 0
        Me.btnFinishTest.Location = New System.Drawing.Point(776, 29)
        Me.btnFinishTest.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnFinishTest.Name = "btnFinishTest"
        Me.btnFinishTest.Primary = True
        Me.btnFinishTest.Size = New System.Drawing.Size(149, 28)
        Me.btnFinishTest.TabIndex = 12
        Me.btnFinishTest.Text = "Finish Test"
        Me.btnFinishTest.UseVisualStyleBackColor = True
        '
        'rtfChosenAnswer
        '
        Me.rtfChosenAnswer.Enabled = False
        Me.rtfChosenAnswer.Location = New System.Drawing.Point(6, 16)
        Me.rtfChosenAnswer.Name = "rtfChosenAnswer"
        Me.rtfChosenAnswer.Size = New System.Drawing.Size(700, 29)
        Me.rtfChosenAnswer.TabIndex = 13
        Me.rtfChosenAnswer.Text = ""
        '
        'dgvUnansweredQuestion
        '
        Me.dgvUnansweredQuestion.AllowUserToAddRows = False
        Me.dgvUnansweredQuestion.AllowUserToDeleteRows = False
        Me.dgvUnansweredQuestion.AllowUserToResizeColumns = False
        Me.dgvUnansweredQuestion.AllowUserToResizeRows = False
        Me.dgvUnansweredQuestion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvUnansweredQuestion.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvUnansweredQuestion.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvUnansweredQuestion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvUnansweredQuestion.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvUnansweredQuestion.EnableHeadersVisualStyles = False
        Me.dgvUnansweredQuestion.GridColor = System.Drawing.SystemColors.MenuBar
        Me.dgvUnansweredQuestion.Location = New System.Drawing.Point(833, 131)
        Me.dgvUnansweredQuestion.Name = "dgvUnansweredQuestion"
        Me.dgvUnansweredQuestion.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvUnansweredQuestion.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvUnansweredQuestion.RowHeadersVisible = False
        Me.dgvUnansweredQuestion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUnansweredQuestion.Size = New System.Drawing.Size(91, 484)
        Me.dgvUnansweredQuestion.TabIndex = 14
        '
        'lblTestTypeID
        '
        Me.lblTestTypeID.AutoSize = True
        Me.lblTestTypeID.Location = New System.Drawing.Point(557, 71)
        Me.lblTestTypeID.Name = "lblTestTypeID"
        Me.lblTestTypeID.Size = New System.Drawing.Size(63, 13)
        Me.lblTestTypeID.TabIndex = 8
        Me.lblTestTypeID.Text = "TestTypeID"
        Me.lblTestTypeID.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rtfChosenAnswer)
        Me.GroupBox1.Location = New System.Drawing.Point(112, 533)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(712, 49)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Chosen Answer"
        '
        'ExamineeTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(937, 622)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvUnansweredQuestion)
        Me.Controls.Add(Me.btnFinishTest)
        Me.Controls.Add(Me.btnAnswer)
        Me.Controls.Add(Me.dgvQuestionNumber)
        Me.Controls.Add(Me.lblTestTypeID)
        Me.Controls.Add(Me.lblSetDescription)
        Me.Controls.Add(Me.btnQuestionNext)
        Me.Controls.Add(Me.btnQuestionPrevious)
        Me.Controls.Add(Me.rbChoice4)
        Me.Controls.Add(Me.rbChoice3)
        Me.Controls.Add(Me.rbChoice2)
        Me.Controls.Add(Me.rbChoice1)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblPositionDescription)
        Me.Controls.Add(Me.lblLevelDescription)
        Me.Controls.Add(Me.lblQuestionCounter)
        Me.Controls.Add(Me.lblExamineeID)
        Me.Controls.Add(Me.lblLevelID)
        Me.Controls.Add(Me.lblScoreHide)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblNumOfQuestion)
        Me.Controls.Add(Me.lblQuestionID)
        Me.Controls.Add(Me.lblKindID)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.lblExamineeDateID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rtfQuestion)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ExamineeTest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Examinee Test"
        CType(Me.dgvQuestionNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvUnansweredQuestion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rtfQuestion As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblExamineeDateID As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblAnswer As Label
    Friend WithEvents lblKindID As Label
    Friend WithEvents lblExamineeID As Label
    Friend WithEvents lblQuestionID As Label
    Friend WithEvents lblNumOfQuestion As Label
    Friend WithEvents lblQuestionCounter As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTimer As Label
    Friend WithEvents tmrTest As Timer
    Friend WithEvents rbChoice1 As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents rbChoice2 As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents rbChoice3 As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents rbChoice4 As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents btnQuestionPrevious As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnQuestionNext As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents lblScore As Label
    Friend WithEvents lblLevelID As Label
    Friend WithEvents lblLevelDescription As Label
    Friend WithEvents lblPositionDescription As Label
    Friend WithEvents lblScoreHide As Label
    Friend WithEvents lblSetDescription As Label
    Friend WithEvents dgvQuestionNumber As DataGridView
    Friend WithEvents btnAnswer As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnFinishTest As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents rtfChosenAnswer As RichTextBox
    Friend WithEvents dgvUnansweredQuestion As DataGridView
    Friend WithEvents lblTestTypeID As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
