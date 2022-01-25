<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSetPassword
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
        Me.btnOK = New System.Windows.Forms.Button()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.txtId = New PayrollSystem.WaterMarkTextBox()
        Me.cbRememberPassword = New System.Windows.Forms.CheckBox()
        Me.txtPasswordCheck = New PayrollSystem.WaterMarkTextBox()
        Me.lbTitle = New System.Windows.Forms.Label()
        Me.txtPassword = New PayrollSystem.WaterMarkTextBox()
        Me.tblMain = New System.Windows.Forms.TableLayoutPanel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnMin = New System.Windows.Forms.Button()
        Me.pnlAll = New System.Windows.Forms.Panel()
        Me.pnlMain.SuspendLayout()
        Me.tblMain.SuspendLayout()
        Me.pnlAll.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnOK.BackColor = System.Drawing.SystemColors.Window
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnOK.Location = New System.Drawing.Point(156, 211)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(73, 30)
        Me.btnOK.TabIndex = 3
        Me.btnOK.Text = "確  認"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'pnlMain
        '
        Me.pnlMain.Controls.Add(Me.txtId)
        Me.pnlMain.Controls.Add(Me.cbRememberPassword)
        Me.pnlMain.Controls.Add(Me.txtPasswordCheck)
        Me.pnlMain.Controls.Add(Me.lbTitle)
        Me.pnlMain.Controls.Add(Me.txtPassword)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(28, 28)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(330, 177)
        Me.pnlMain.TabIndex = 1
        '
        'txtId
        '
        Me.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtId.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtId.Location = New System.Drawing.Point(59, 33)
        Me.txtId.Margin = New System.Windows.Forms.Padding(5)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(210, 22)
        Me.txtId.TabIndex = 10
        Me.txtId.WaterMarkColor = System.Drawing.Color.Gray
        Me.txtId.WaterMarkText = "UserName"
        '
        'cbRememberPassword
        '
        Me.cbRememberPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbRememberPassword.AutoSize = True
        Me.cbRememberPassword.Location = New System.Drawing.Point(116, 145)
        Me.cbRememberPassword.Name = "cbRememberPassword"
        Me.cbRememberPassword.Size = New System.Drawing.Size(92, 24)
        Me.cbRememberPassword.TabIndex = 9
        Me.cbRememberPassword.Text = "記住密碼"
        Me.cbRememberPassword.UseVisualStyleBackColor = True
        '
        'txtPasswordCheck
        '
        Me.txtPasswordCheck.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPasswordCheck.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtPasswordCheck.Location = New System.Drawing.Point(59, 104)
        Me.txtPasswordCheck.Margin = New System.Windows.Forms.Padding(5)
        Me.txtPasswordCheck.Name = "txtPasswordCheck"
        Me.txtPasswordCheck.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPasswordCheck.Size = New System.Drawing.Size(210, 22)
        Me.txtPasswordCheck.TabIndex = 7
        Me.txtPasswordCheck.WaterMarkColor = System.Drawing.Color.Gray
        Me.txtPasswordCheck.WaterMarkText = "Password Again"
        '
        'lbTitle
        '
        Me.lbTitle.AutoSize = True
        Me.lbTitle.Location = New System.Drawing.Point(113, 0)
        Me.lbTitle.Name = "lbTitle"
        Me.lbTitle.Size = New System.Drawing.Size(105, 20)
        Me.lbTitle.TabIndex = 6
        Me.lbTitle.Text = "帳號密碼設定"
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(59, 68)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(5)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPassword.Size = New System.Drawing.Size(210, 22)
        Me.txtPassword.TabIndex = 1
        Me.txtPassword.WaterMarkColor = System.Drawing.Color.Gray
        Me.txtPassword.WaterMarkText = "Password"
        '
        'tblMain
        '
        Me.tblMain.BackColor = System.Drawing.Color.Linen
        Me.tblMain.ColumnCount = 3
        Me.tblMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tblMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tblMain.Controls.Add(Me.btnExit, 2, 0)
        Me.tblMain.Controls.Add(Me.btnOK, 1, 2)
        Me.tblMain.Controls.Add(Me.pnlMain, 1, 1)
        Me.tblMain.Controls.Add(Me.btnMin, 1, 0)
        Me.tblMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblMain.Location = New System.Drawing.Point(1, 1)
        Me.tblMain.Name = "tblMain"
        Me.tblMain.RowCount = 4
        Me.tblMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tblMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tblMain.Size = New System.Drawing.Size(386, 254)
        Me.tblMain.TabIndex = 6
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnExit.Location = New System.Drawing.Point(361, 0)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(25, 25)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "╳"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnMin
        '
        Me.btnMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMin.BackColor = System.Drawing.Color.Transparent
        Me.btnMin.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace
        Me.btnMin.FlatAppearance.BorderSize = 0
        Me.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnMin.Location = New System.Drawing.Point(332, 0)
        Me.btnMin.Margin = New System.Windows.Forms.Padding(0)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Size = New System.Drawing.Size(29, 25)
        Me.btnMin.TabIndex = 5
        Me.btnMin.TabStop = False
        Me.btnMin.Text = "─"
        Me.btnMin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMin.UseVisualStyleBackColor = False
        '
        'pnlAll
        '
        Me.pnlAll.BackColor = System.Drawing.Color.Tan
        Me.pnlAll.Controls.Add(Me.tblMain)
        Me.pnlAll.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlAll.Location = New System.Drawing.Point(0, 0)
        Me.pnlAll.Name = "pnlAll"
        Me.pnlAll.Padding = New System.Windows.Forms.Padding(1)
        Me.pnlAll.Size = New System.Drawing.Size(388, 256)
        Me.pnlAll.TabIndex = 8
        '
        'frmSetPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(388, 256)
        Me.Controls.Add(Me.pnlAll)
        Me.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSetPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "設定密碼"
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        Me.tblMain.ResumeLayout(False)
        Me.pnlAll.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnOK As Button
    Friend WithEvents pnlMain As Panel
    Friend WithEvents txtPasswordCheck As WaterMarkTextBox
    Friend WithEvents lbTitle As Label
    Friend WithEvents txtPassword As WaterMarkTextBox
    Friend WithEvents tblMain As TableLayoutPanel
    Friend WithEvents btnExit As Button
    Friend WithEvents btnMin As Button
    Friend WithEvents pnlAll As Panel
    Friend WithEvents txtId As WaterMarkTextBox
    Friend WithEvents cbRememberPassword As CheckBox
End Class
