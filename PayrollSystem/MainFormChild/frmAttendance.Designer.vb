<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAttendance
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"交通費", "3500"}, -1)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"伙食費", "120"}, -1)
        Me.dgvStaff = New System.Windows.Forms.DataGridView()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.lbEndDateTime = New System.Windows.Forms.Label()
        Me.lbStartDateTime = New System.Windows.Forms.Label()
        Me.txtProject = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lbProject = New System.Windows.Forms.Label()
        Me.IbName = New System.Windows.Forms.Label()
        Me.lbWorkId = New System.Windows.Forms.Label()
        Me.spcMain = New System.Windows.Forms.SplitContainer()
        Me.pnlCost = New System.Windows.Forms.Panel()
        Me.lstCost = New System.Windows.Forms.ListView()
        Me.Item = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Cost = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pnlAddCost = New System.Windows.Forms.Panel()
        Me.txtItem = New PayrollSystem.WaterMarkTextBox()
        Me.txtCost = New PayrollSystem.WaterMarkTextBox()
        Me.btnAddCost = New System.Windows.Forms.Button()
        Me.lbCost = New System.Windows.Forms.Label()
        Me.dtpEndTime = New System.Windows.Forms.DateTimePicker()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpStartTime = New System.Windows.Forms.DateTimePicker()
        Me.txtContent = New System.Windows.Forms.TextBox()
        Me.lbContent = New System.Windows.Forms.Label()
        Me.cbWorkId = New System.Windows.Forms.ComboBox()
        Me.lbTitle = New System.Windows.Forms.Label()
        CType(Me.dgvStaff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spcMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spcMain.Panel1.SuspendLayout()
        Me.spcMain.Panel2.SuspendLayout()
        Me.spcMain.SuspendLayout()
        Me.pnlCost.SuspendLayout()
        Me.pnlAddCost.SuspendLayout()
        Me.SuspendLayout()
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
        Me.dgvStaff.Name = "dgvStaff"
        Me.dgvStaff.RowTemplate.Height = 24
        Me.dgvStaff.Size = New System.Drawing.Size(700, 224)
        Me.dgvStaff.TabIndex = 0
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnCancel.BackColor = System.Drawing.Color.OldLace
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.ForeColor = System.Drawing.Color.SaddleBrown
        Me.btnCancel.Location = New System.Drawing.Point(242, 435)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 29)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "取消"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnDelete.BackColor = System.Drawing.Color.OldLace
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.ForeColor = System.Drawing.Color.SaddleBrown
        Me.btnDelete.Location = New System.Drawing.Point(126, 435)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(100, 29)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "刪除"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnOK
        '
        Me.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnOK.BackColor = System.Drawing.Color.OldLace
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.ForeColor = System.Drawing.Color.SaddleBrown
        Me.btnOK.Location = New System.Drawing.Point(12, 435)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(100, 29)
        Me.btnOK.TabIndex = 7
        Me.btnOK.Text = "新增"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dtpStartDate.Location = New System.Drawing.Point(55, 340)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(158, 29)
        Me.dtpStartDate.TabIndex = 3
        '
        'lbEndDateTime
        '
        Me.lbEndDateTime.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbEndDateTime.AutoSize = True
        Me.lbEndDateTime.Location = New System.Drawing.Point(5, 393)
        Me.lbEndDateTime.Name = "lbEndDateTime"
        Me.lbEndDateTime.Size = New System.Drawing.Size(41, 20)
        Me.lbEndDateTime.TabIndex = 15
        Me.lbEndDateTime.Text = "迄時"
        '
        'lbStartDateTime
        '
        Me.lbStartDateTime.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbStartDateTime.AutoSize = True
        Me.lbStartDateTime.Location = New System.Drawing.Point(5, 343)
        Me.lbStartDateTime.Name = "lbStartDateTime"
        Me.lbStartDateTime.Size = New System.Drawing.Size(41, 20)
        Me.lbStartDateTime.TabIndex = 14
        Me.lbStartDateTime.Text = "起時"
        '
        'txtProject
        '
        Me.txtProject.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtProject.Location = New System.Drawing.Point(55, 240)
        Me.txtProject.Name = "txtProject"
        Me.txtProject.Size = New System.Drawing.Size(292, 29)
        Me.txtProject.TabIndex = 2
        '
        'txtName
        '
        Me.txtName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtName.Enabled = False
        Me.txtName.Location = New System.Drawing.Point(55, 190)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(292, 29)
        Me.txtName.TabIndex = 1
        '
        'lbProject
        '
        Me.lbProject.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbProject.AutoSize = True
        Me.lbProject.Location = New System.Drawing.Point(5, 243)
        Me.lbProject.Name = "lbProject"
        Me.lbProject.Size = New System.Drawing.Size(41, 20)
        Me.lbProject.TabIndex = 13
        Me.lbProject.Text = "專案"
        '
        'IbName
        '
        Me.IbName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.IbName.AutoSize = True
        Me.IbName.Location = New System.Drawing.Point(5, 193)
        Me.IbName.Name = "IbName"
        Me.IbName.Size = New System.Drawing.Size(41, 20)
        Me.IbName.TabIndex = 12
        Me.IbName.Text = "姓名"
        '
        'lbWorkId
        '
        Me.lbWorkId.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbWorkId.AutoSize = True
        Me.lbWorkId.Location = New System.Drawing.Point(5, 143)
        Me.lbWorkId.Name = "lbWorkId"
        Me.lbWorkId.Size = New System.Drawing.Size(41, 20)
        Me.lbWorkId.TabIndex = 11
        Me.lbWorkId.Text = "工號"
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
        Me.spcMain.Panel1.BackColor = System.Drawing.Color.Ivory
        Me.spcMain.Panel1.Controls.Add(Me.pnlCost)
        Me.spcMain.Panel1.Controls.Add(Me.dtpEndTime)
        Me.spcMain.Panel1.Controls.Add(Me.dtpEndDate)
        Me.spcMain.Panel1.Controls.Add(Me.dtpStartTime)
        Me.spcMain.Panel1.Controls.Add(Me.txtContent)
        Me.spcMain.Panel1.Controls.Add(Me.lbContent)
        Me.spcMain.Panel1.Controls.Add(Me.cbWorkId)
        Me.spcMain.Panel1.Controls.Add(Me.btnCancel)
        Me.spcMain.Panel1.Controls.Add(Me.btnDelete)
        Me.spcMain.Panel1.Controls.Add(Me.btnOK)
        Me.spcMain.Panel1.Controls.Add(Me.dtpStartDate)
        Me.spcMain.Panel1.Controls.Add(Me.lbEndDateTime)
        Me.spcMain.Panel1.Controls.Add(Me.lbStartDateTime)
        Me.spcMain.Panel1.Controls.Add(Me.txtProject)
        Me.spcMain.Panel1.Controls.Add(Me.txtName)
        Me.spcMain.Panel1.Controls.Add(Me.lbProject)
        Me.spcMain.Panel1.Controls.Add(Me.IbName)
        Me.spcMain.Panel1.Controls.Add(Me.lbWorkId)
        Me.spcMain.Panel1.Controls.Add(Me.lbTitle)
        '
        'spcMain.Panel2
        '
        Me.spcMain.Panel2.Controls.Add(Me.dgvStaff)
        Me.spcMain.Size = New System.Drawing.Size(700, 700)
        Me.spcMain.SplitterDistance = 472
        Me.spcMain.TabIndex = 3
        '
        'pnlCost
        '
        Me.pnlCost.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pnlCost.Controls.Add(Me.lstCost)
        Me.pnlCost.Controls.Add(Me.pnlAddCost)
        Me.pnlCost.Controls.Add(Me.lbCost)
        Me.pnlCost.Location = New System.Drawing.Point(353, 140)
        Me.pnlCost.Name = "pnlCost"
        Me.pnlCost.Size = New System.Drawing.Size(340, 324)
        Me.pnlCost.TabIndex = 24
        '
        'lstCost
        '
        Me.lstCost.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstCost.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Item, Me.Cost})
        Me.lstCost.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstCost.FullRowSelect = True
        Me.lstCost.GridLines = True
        Me.lstCost.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lstCost.HideSelection = False
        Me.lstCost.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2})
        Me.lstCost.Location = New System.Drawing.Point(0, 25)
        Me.lstCost.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.lstCost.MultiSelect = False
        Me.lstCost.Name = "lstCost"
        Me.lstCost.Size = New System.Drawing.Size(340, 241)
        Me.lstCost.TabIndex = 26
        Me.lstCost.UseCompatibleStateImageBehavior = False
        Me.lstCost.View = System.Windows.Forms.View.Details
        '
        'Item
        '
        Me.Item.Text = "項目"
        Me.Item.Width = 214
        '
        'Cost
        '
        Me.Cost.Text = "金額"
        Me.Cost.Width = 126
        '
        'pnlAddCost
        '
        Me.pnlAddCost.Controls.Add(Me.txtItem)
        Me.pnlAddCost.Controls.Add(Me.txtCost)
        Me.pnlAddCost.Controls.Add(Me.btnAddCost)
        Me.pnlAddCost.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlAddCost.Location = New System.Drawing.Point(0, 266)
        Me.pnlAddCost.Name = "pnlAddCost"
        Me.pnlAddCost.Size = New System.Drawing.Size(340, 58)
        Me.pnlAddCost.TabIndex = 25
        '
        'txtItem
        '
        Me.txtItem.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtItem.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtItem.Location = New System.Drawing.Point(0, 0)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(265, 29)
        Me.txtItem.TabIndex = 27
        Me.txtItem.WaterMarkColor = System.Drawing.Color.Gray
        Me.txtItem.WaterMarkText = "項目"
        '
        'txtCost
        '
        Me.txtCost.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtCost.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtCost.Location = New System.Drawing.Point(0, 29)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(265, 29)
        Me.txtCost.TabIndex = 26
        Me.txtCost.WaterMarkColor = System.Drawing.Color.Gray
        Me.txtCost.WaterMarkText = "金額"
        '
        'btnAddCost
        '
        Me.btnAddCost.BackColor = System.Drawing.Color.OldLace
        Me.btnAddCost.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAddCost.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddCost.ForeColor = System.Drawing.Color.SaddleBrown
        Me.btnAddCost.Location = New System.Drawing.Point(265, 0)
        Me.btnAddCost.Name = "btnAddCost"
        Me.btnAddCost.Size = New System.Drawing.Size(75, 58)
        Me.btnAddCost.TabIndex = 24
        Me.btnAddCost.Text = "加入"
        Me.btnAddCost.UseVisualStyleBackColor = False
        '
        'lbCost
        '
        Me.lbCost.BackColor = System.Drawing.Color.Tan
        Me.lbCost.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbCost.ForeColor = System.Drawing.Color.White
        Me.lbCost.Location = New System.Drawing.Point(0, 0)
        Me.lbCost.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.lbCost.Name = "lbCost"
        Me.lbCost.Size = New System.Drawing.Size(340, 25)
        Me.lbCost.TabIndex = 18
        Me.lbCost.Text = "花費"
        Me.lbCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpEndTime
        '
        Me.dtpEndTime.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpEndTime.Location = New System.Drawing.Point(219, 390)
        Me.dtpEndTime.Name = "dtpEndTime"
        Me.dtpEndTime.Size = New System.Drawing.Size(128, 29)
        Me.dtpEndTime.TabIndex = 22
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dtpEndDate.Location = New System.Drawing.Point(55, 390)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(158, 29)
        Me.dtpEndDate.TabIndex = 21
        '
        'dtpStartTime
        '
        Me.dtpStartTime.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpStartTime.Location = New System.Drawing.Point(219, 340)
        Me.dtpStartTime.Name = "dtpStartTime"
        Me.dtpStartTime.Size = New System.Drawing.Size(128, 29)
        Me.dtpStartTime.TabIndex = 20
        '
        'txtContent
        '
        Me.txtContent.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtContent.Location = New System.Drawing.Point(55, 290)
        Me.txtContent.Name = "txtContent"
        Me.txtContent.Size = New System.Drawing.Size(292, 29)
        Me.txtContent.TabIndex = 18
        '
        'lbContent
        '
        Me.lbContent.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbContent.AutoSize = True
        Me.lbContent.Location = New System.Drawing.Point(5, 293)
        Me.lbContent.Name = "lbContent"
        Me.lbContent.Size = New System.Drawing.Size(41, 20)
        Me.lbContent.TabIndex = 19
        Me.lbContent.Text = "事由"
        '
        'cbWorkId
        '
        Me.cbWorkId.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cbWorkId.FormattingEnabled = True
        Me.cbWorkId.Location = New System.Drawing.Point(55, 140)
        Me.cbWorkId.Name = "cbWorkId"
        Me.cbWorkId.Size = New System.Drawing.Size(292, 28)
        Me.cbWorkId.TabIndex = 17
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
        Me.lbTitle.TabIndex = 10
        Me.lbTitle.Text = "出勤紀錄"
        '
        'frmAttendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Ivory
        Me.ClientSize = New System.Drawing.Size(700, 700)
        Me.Controls.Add(Me.spcMain)
        Me.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "frmAttendance"
        Me.Text = "frmAttendance"
        CType(Me.dgvStaff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spcMain.Panel1.ResumeLayout(False)
        Me.spcMain.Panel1.PerformLayout()
        Me.spcMain.Panel2.ResumeLayout(False)
        CType(Me.spcMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spcMain.ResumeLayout(False)
        Me.pnlCost.ResumeLayout(False)
        Me.pnlAddCost.ResumeLayout(False)
        Me.pnlAddCost.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvStaff As DataGridView
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents dtpStartDate As DateTimePicker
    Friend WithEvents lbEndDateTime As Label
    Friend WithEvents lbStartDateTime As Label
    Friend WithEvents txtProject As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents lbProject As Label
    Friend WithEvents IbName As Label
    Friend WithEvents lbWorkId As Label
    Friend WithEvents spcMain As SplitContainer
    Friend WithEvents cbWorkId As ComboBox
    Friend WithEvents lbTitle As Label
    Friend WithEvents dtpEndTime As DateTimePicker
    Friend WithEvents dtpEndDate As DateTimePicker
    Friend WithEvents dtpStartTime As DateTimePicker
    Friend WithEvents txtContent As TextBox
    Friend WithEvents lbContent As Label
    Friend WithEvents pnlCost As Panel
    Private WithEvents lstCost As ListView
    Private WithEvents Item As ColumnHeader
    Private WithEvents Cost As ColumnHeader
    Friend WithEvents pnlAddCost As Panel
    Friend WithEvents txtItem As WaterMarkTextBox
    Friend WithEvents txtCost As WaterMarkTextBox
    Friend WithEvents btnAddCost As Button
    Private WithEvents lbCost As Label
End Class
