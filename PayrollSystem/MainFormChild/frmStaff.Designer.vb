<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStaff
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lbTitle = New System.Windows.Forms.Label()
        Me.spcMain = New System.Windows.Forms.SplitContainer()
        Me.cbIdentity = New System.Windows.Forms.ComboBox()
        Me.lbIdentity = New System.Windows.Forms.Label()
        Me.txtPension = New PayrollSystem.WaterMarkTextBox()
        Me.lbPercent = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbPension = New System.Windows.Forms.Label()
        Me.txtBankAccount = New System.Windows.Forms.TextBox()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.lbBankAccount = New System.Windows.Forms.Label()
        Me.lbPosition = New System.Windows.Forms.Label()
        Me.rbtnShowResignation = New System.Windows.Forms.RadioButton()
        Me.rbtnShowEmployed = New System.Windows.Forms.RadioButton()
        Me.rbtnShowAll = New System.Windows.Forms.RadioButton()
        Me.lbAlert = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.cbResigned = New System.Windows.Forms.CheckBox()
        Me.dtpResignation = New System.Windows.Forms.DateTimePicker()
        Me.dtpOnBoard = New System.Windows.Forms.DateTimePicker()
        Me.lbResignation = New System.Windows.Forms.Label()
        Me.lbOnBoard = New System.Windows.Forms.Label()
        Me.txtWage = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtWorkId = New System.Windows.Forms.TextBox()
        Me.lbWage = New System.Windows.Forms.Label()
        Me.lbEmail = New System.Windows.Forms.Label()
        Me.IbName = New System.Windows.Forms.Label()
        Me.lbWorkId = New System.Windows.Forms.Label()
        Me.dgvStaff = New System.Windows.Forms.DataGridView()
        CType(Me.spcMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spcMain.Panel1.SuspendLayout()
        Me.spcMain.Panel2.SuspendLayout()
        Me.spcMain.SuspendLayout()
        CType(Me.dgvStaff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbTitle
        '
        Me.lbTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbTitle.AutoSize = True
        Me.lbTitle.Font = New System.Drawing.Font("微軟正黑體", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lbTitle.Location = New System.Drawing.Point(240, 30)
        Me.lbTitle.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbTitle.Name = "lbTitle"
        Me.lbTitle.Size = New System.Drawing.Size(219, 61)
        Me.lbTitle.TabIndex = 14
        Me.lbTitle.Text = "員工資料"
        '
        'spcMain
        '
        Me.spcMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spcMain.Location = New System.Drawing.Point(0, 0)
        Me.spcMain.Name = "spcMain"
        Me.spcMain.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'spcMain.Panel1
        '
        Me.spcMain.Panel1.Controls.Add(Me.cbIdentity)
        Me.spcMain.Panel1.Controls.Add(Me.lbIdentity)
        Me.spcMain.Panel1.Controls.Add(Me.txtPension)
        Me.spcMain.Panel1.Controls.Add(Me.lbPercent)
        Me.spcMain.Panel1.Controls.Add(Me.Label1)
        Me.spcMain.Panel1.Controls.Add(Me.lbPension)
        Me.spcMain.Panel1.Controls.Add(Me.txtBankAccount)
        Me.spcMain.Panel1.Controls.Add(Me.txtPosition)
        Me.spcMain.Panel1.Controls.Add(Me.lbBankAccount)
        Me.spcMain.Panel1.Controls.Add(Me.lbPosition)
        Me.spcMain.Panel1.Controls.Add(Me.rbtnShowResignation)
        Me.spcMain.Panel1.Controls.Add(Me.rbtnShowEmployed)
        Me.spcMain.Panel1.Controls.Add(Me.rbtnShowAll)
        Me.spcMain.Panel1.Controls.Add(Me.lbAlert)
        Me.spcMain.Panel1.Controls.Add(Me.btnCancel)
        Me.spcMain.Panel1.Controls.Add(Me.btnDelete)
        Me.spcMain.Panel1.Controls.Add(Me.btnOK)
        Me.spcMain.Panel1.Controls.Add(Me.cbResigned)
        Me.spcMain.Panel1.Controls.Add(Me.dtpResignation)
        Me.spcMain.Panel1.Controls.Add(Me.dtpOnBoard)
        Me.spcMain.Panel1.Controls.Add(Me.lbResignation)
        Me.spcMain.Panel1.Controls.Add(Me.lbOnBoard)
        Me.spcMain.Panel1.Controls.Add(Me.txtWage)
        Me.spcMain.Panel1.Controls.Add(Me.txtEmail)
        Me.spcMain.Panel1.Controls.Add(Me.txtName)
        Me.spcMain.Panel1.Controls.Add(Me.txtWorkId)
        Me.spcMain.Panel1.Controls.Add(Me.lbWage)
        Me.spcMain.Panel1.Controls.Add(Me.lbEmail)
        Me.spcMain.Panel1.Controls.Add(Me.IbName)
        Me.spcMain.Panel1.Controls.Add(Me.lbWorkId)
        Me.spcMain.Panel1.Controls.Add(Me.lbTitle)
        '
        'spcMain.Panel2
        '
        Me.spcMain.Panel2.Controls.Add(Me.dgvStaff)
        Me.spcMain.Size = New System.Drawing.Size(700, 700)
        Me.spcMain.SplitterDistance = 441
        Me.spcMain.TabIndex = 2
        '
        'cbIdentity
        '
        Me.cbIdentity.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cbIdentity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbIdentity.FormattingEnabled = True
        Me.cbIdentity.Items.AddRange(New Object() {"雇主", "勞工"})
        Me.cbIdentity.Location = New System.Drawing.Point(420, 140)
        Me.cbIdentity.Name = "cbIdentity"
        Me.cbIdentity.Size = New System.Drawing.Size(250, 28)
        Me.cbIdentity.TabIndex = 1
        '
        'lbIdentity
        '
        Me.lbIdentity.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbIdentity.AutoSize = True
        Me.lbIdentity.Location = New System.Drawing.Point(370, 143)
        Me.lbIdentity.Name = "lbIdentity"
        Me.lbIdentity.Size = New System.Drawing.Size(41, 20)
        Me.lbIdentity.TabIndex = 16
        Me.lbIdentity.Text = "身分"
        '
        'txtPension
        '
        Me.txtPension.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtPension.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtPension.Location = New System.Drawing.Point(360, 260)
        Me.txtPension.Name = "txtPension"
        Me.txtPension.Size = New System.Drawing.Size(31, 29)
        Me.txtPension.TabIndex = 5
        Me.txtPension.WaterMarkColor = System.Drawing.Color.Gray
        Me.txtPension.WaterMarkText = "0"
        '
        'lbPercent
        '
        Me.lbPercent.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbPercent.AutoSize = True
        Me.lbPercent.Location = New System.Drawing.Point(397, 263)
        Me.lbPercent.Name = "lbPercent"
        Me.lbPercent.Size = New System.Drawing.Size(23, 20)
        Me.lbPercent.TabIndex = 21
        Me.lbPercent.Text = "%"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(360, 289)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 16)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "( 自願提撥 )"
        '
        'lbPension
        '
        Me.lbPension.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbPension.AutoSize = True
        Me.lbPension.Location = New System.Drawing.Point(294, 263)
        Me.lbPension.Name = "lbPension"
        Me.lbPension.Size = New System.Drawing.Size(57, 20)
        Me.lbPension.TabIndex = 20
        Me.lbPension.Text = "勞退金"
        '
        'txtBankAccount
        '
        Me.txtBankAccount.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtBankAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBankAccount.Location = New System.Drawing.Point(100, 260)
        Me.txtBankAccount.Name = "txtBankAccount"
        Me.txtBankAccount.Size = New System.Drawing.Size(190, 29)
        Me.txtBankAccount.TabIndex = 4
        '
        'txtPosition
        '
        Me.txtPosition.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPosition.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtPosition.Location = New System.Drawing.Point(420, 200)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(250, 29)
        Me.txtPosition.TabIndex = 3
        '
        'lbBankAccount
        '
        Me.lbBankAccount.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbBankAccount.AutoSize = True
        Me.lbBankAccount.Location = New System.Drawing.Point(50, 263)
        Me.lbBankAccount.Name = "lbBankAccount"
        Me.lbBankAccount.Size = New System.Drawing.Size(41, 20)
        Me.lbBankAccount.TabIndex = 19
        Me.lbBankAccount.Text = "帳戶"
        '
        'lbPosition
        '
        Me.lbPosition.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbPosition.AutoSize = True
        Me.lbPosition.Location = New System.Drawing.Point(370, 203)
        Me.lbPosition.Name = "lbPosition"
        Me.lbPosition.Size = New System.Drawing.Size(41, 20)
        Me.lbPosition.TabIndex = 18
        Me.lbPosition.Text = "職位"
        '
        'rbtnShowResignation
        '
        Me.rbtnShowResignation.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rbtnShowResignation.AutoSize = True
        Me.rbtnShowResignation.Location = New System.Drawing.Point(253, 414)
        Me.rbtnShowResignation.Name = "rbtnShowResignation"
        Me.rbtnShowResignation.Size = New System.Drawing.Size(139, 24)
        Me.rbtnShowResignation.TabIndex = 29
        Me.rbtnShowResignation.TabStop = True
        Me.rbtnShowResignation.Text = "僅顯示離職員工"
        Me.rbtnShowResignation.UseVisualStyleBackColor = True
        '
        'rbtnShowEmployed
        '
        Me.rbtnShowEmployed.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rbtnShowEmployed.AutoSize = True
        Me.rbtnShowEmployed.Location = New System.Drawing.Point(108, 414)
        Me.rbtnShowEmployed.Name = "rbtnShowEmployed"
        Me.rbtnShowEmployed.Size = New System.Drawing.Size(139, 24)
        Me.rbtnShowEmployed.TabIndex = 28
        Me.rbtnShowEmployed.TabStop = True
        Me.rbtnShowEmployed.Text = "僅顯示在職員工"
        Me.rbtnShowEmployed.UseVisualStyleBackColor = True
        '
        'rbtnShowAll
        '
        Me.rbtnShowAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rbtnShowAll.AutoSize = True
        Me.rbtnShowAll.Location = New System.Drawing.Point(13, 414)
        Me.rbtnShowAll.Name = "rbtnShowAll"
        Me.rbtnShowAll.Size = New System.Drawing.Size(91, 24)
        Me.rbtnShowAll.TabIndex = 27
        Me.rbtnShowAll.TabStop = True
        Me.rbtnShowAll.Text = "全部顯示"
        Me.rbtnShowAll.UseVisualStyleBackColor = True
        '
        'lbAlert
        '
        Me.lbAlert.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbAlert.AutoSize = True
        Me.lbAlert.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lbAlert.Location = New System.Drawing.Point(100, 169)
        Me.lbAlert.Name = "lbAlert"
        Me.lbAlert.Size = New System.Drawing.Size(106, 16)
        Me.lbAlert.TabIndex = 20
        Me.lbAlert.Text = "( 新增後無法修改 )"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnCancel.BackColor = System.Drawing.Color.OldLace
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.ForeColor = System.Drawing.Color.SaddleBrown
        Me.btnCancel.Location = New System.Drawing.Point(580, 380)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(95, 29)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "取消"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnDelete.BackColor = System.Drawing.Color.OldLace
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.ForeColor = System.Drawing.Color.SaddleBrown
        Me.btnDelete.Location = New System.Drawing.Point(480, 380)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(95, 29)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "刪除"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnOK
        '
        Me.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnOK.BackColor = System.Drawing.Color.OldLace
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.ForeColor = System.Drawing.Color.SaddleBrown
        Me.btnOK.Location = New System.Drawing.Point(380, 380)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(95, 29)
        Me.btnOK.TabIndex = 11
        Me.btnOK.Text = "新增"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'cbResigned
        '
        Me.cbResigned.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cbResigned.AutoSize = True
        Me.cbResigned.Location = New System.Drawing.Point(316, 320)
        Me.cbResigned.Name = "cbResigned"
        Me.cbResigned.Size = New System.Drawing.Size(76, 24)
        Me.cbResigned.TabIndex = 8
        Me.cbResigned.Text = "已離職"
        Me.cbResigned.UseVisualStyleBackColor = True
        '
        'dtpResignation
        '
        Me.dtpResignation.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dtpResignation.Cursor = System.Windows.Forms.Cursors.Default
        Me.dtpResignation.Location = New System.Drawing.Point(480, 320)
        Me.dtpResignation.Name = "dtpResignation"
        Me.dtpResignation.Size = New System.Drawing.Size(190, 29)
        Me.dtpResignation.TabIndex = 9
        '
        'dtpOnBoard
        '
        Me.dtpOnBoard.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dtpOnBoard.Cursor = System.Windows.Forms.Cursors.Default
        Me.dtpOnBoard.Location = New System.Drawing.Point(100, 320)
        Me.dtpOnBoard.Name = "dtpOnBoard"
        Me.dtpOnBoard.Size = New System.Drawing.Size(190, 29)
        Me.dtpOnBoard.TabIndex = 7
        '
        'lbResignation
        '
        Me.lbResignation.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbResignation.AutoSize = True
        Me.lbResignation.Location = New System.Drawing.Point(414, 323)
        Me.lbResignation.Name = "lbResignation"
        Me.lbResignation.Size = New System.Drawing.Size(57, 20)
        Me.lbResignation.TabIndex = 24
        Me.lbResignation.Text = "離職日"
        '
        'lbOnBoard
        '
        Me.lbOnBoard.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbOnBoard.AutoSize = True
        Me.lbOnBoard.Location = New System.Drawing.Point(34, 323)
        Me.lbOnBoard.Name = "lbOnBoard"
        Me.lbOnBoard.Size = New System.Drawing.Size(57, 20)
        Me.lbOnBoard.TabIndex = 23
        Me.lbOnBoard.Text = "到職日"
        '
        'txtWage
        '
        Me.txtWage.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtWage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtWage.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtWage.Location = New System.Drawing.Point(480, 260)
        Me.txtWage.Name = "txtWage"
        Me.txtWage.Size = New System.Drawing.Size(190, 29)
        Me.txtWage.TabIndex = 6
        '
        'txtEmail
        '
        Me.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Location = New System.Drawing.Point(100, 380)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(250, 29)
        Me.txtEmail.TabIndex = 10
        '
        'txtName
        '
        Me.txtName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Location = New System.Drawing.Point(100, 200)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(250, 29)
        Me.txtName.TabIndex = 2
        '
        'txtWorkId
        '
        Me.txtWorkId.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtWorkId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtWorkId.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtWorkId.Location = New System.Drawing.Point(100, 140)
        Me.txtWorkId.Name = "txtWorkId"
        Me.txtWorkId.Size = New System.Drawing.Size(250, 29)
        Me.txtWorkId.TabIndex = 0
        '
        'lbWage
        '
        Me.lbWage.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbWage.AutoSize = True
        Me.lbWage.Location = New System.Drawing.Point(430, 263)
        Me.lbWage.Name = "lbWage"
        Me.lbWage.Size = New System.Drawing.Size(41, 20)
        Me.lbWage.TabIndex = 22
        Me.lbWage.Text = "薪資"
        '
        'lbEmail
        '
        Me.lbEmail.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbEmail.AutoSize = True
        Me.lbEmail.Location = New System.Drawing.Point(41, 383)
        Me.lbEmail.Name = "lbEmail"
        Me.lbEmail.Size = New System.Drawing.Size(50, 20)
        Me.lbEmail.TabIndex = 25
        Me.lbEmail.Text = "Email"
        '
        'IbName
        '
        Me.IbName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.IbName.AutoSize = True
        Me.IbName.Location = New System.Drawing.Point(50, 203)
        Me.IbName.Name = "IbName"
        Me.IbName.Size = New System.Drawing.Size(41, 20)
        Me.IbName.TabIndex = 17
        Me.IbName.Text = "姓名"
        '
        'lbWorkId
        '
        Me.lbWorkId.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbWorkId.AutoSize = True
        Me.lbWorkId.Location = New System.Drawing.Point(50, 143)
        Me.lbWorkId.Name = "lbWorkId"
        Me.lbWorkId.Size = New System.Drawing.Size(41, 20)
        Me.lbWorkId.TabIndex = 15
        Me.lbWorkId.Text = "工號"
        '
        'dgvStaff
        '
        Me.dgvStaff.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvStaff.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Linen
        DataGridViewCellStyle1.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Linen
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStaff.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStaff.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvStaff.Location = New System.Drawing.Point(0, 0)
        Me.dgvStaff.MultiSelect = False
        Me.dgvStaff.Name = "dgvStaff"
        Me.dgvStaff.RowTemplate.Height = 24
        Me.dgvStaff.Size = New System.Drawing.Size(700, 255)
        Me.dgvStaff.TabIndex = 0
        '
        'frmStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Ivory
        Me.ClientSize = New System.Drawing.Size(700, 700)
        Me.Controls.Add(Me.spcMain)
        Me.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "frmStaff"
        Me.Text = "frmStaff"
        Me.spcMain.Panel1.ResumeLayout(False)
        Me.spcMain.Panel1.PerformLayout()
        Me.spcMain.Panel2.ResumeLayout(False)
        CType(Me.spcMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spcMain.ResumeLayout(False)
        CType(Me.dgvStaff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbTitle As Label
    Friend WithEvents spcMain As SplitContainer
    Friend WithEvents txtWage As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtWorkId As TextBox
    Friend WithEvents lbWage As Label
    Friend WithEvents lbEmail As Label
    Friend WithEvents IbName As Label
    Friend WithEvents lbWorkId As Label
    Friend WithEvents cbResigned As CheckBox
    Friend WithEvents dtpResignation As DateTimePicker
    Friend WithEvents dtpOnBoard As DateTimePicker
    Friend WithEvents lbResignation As Label
    Friend WithEvents lbOnBoard As Label
    Friend WithEvents btnOK As Button
    Friend WithEvents dgvStaff As DataGridView
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lbAlert As Label
    Friend WithEvents rbtnShowResignation As RadioButton
    Friend WithEvents rbtnShowEmployed As RadioButton
    Friend WithEvents rbtnShowAll As RadioButton
    Friend WithEvents lbPercent As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbPension As Label
    Friend WithEvents txtBankAccount As TextBox
    Friend WithEvents txtPosition As TextBox
    Friend WithEvents lbBankAccount As Label
    Friend WithEvents lbPosition As Label
    Friend WithEvents txtPension As WaterMarkTextBox
    Friend WithEvents cbIdentity As ComboBox
    Friend WithEvents lbIdentity As Label
End Class
