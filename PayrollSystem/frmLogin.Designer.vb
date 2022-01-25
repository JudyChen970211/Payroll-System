<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.cbRememberPassword = New System.Windows.Forms.CheckBox()
        Me.tblMain = New System.Windows.Forms.TableLayoutPanel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.btnShowPassword = New System.Windows.Forms.Button()
        Me.btnDeleteId = New System.Windows.Forms.Button()
        Me.lbTitle = New System.Windows.Forms.Label()
        Me.btnMin = New System.Windows.Forms.Button()
        Me.pnlAll = New System.Windows.Forms.Panel()
        Me.txtId = New PayrollSystem.WaterMarkTextBox()
        Me.txtPassword = New PayrollSystem.WaterMarkTextBox()
        Me.tblMain.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.pnlAll.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnLogin.BackColor = System.Drawing.SystemColors.Window
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(150, 182)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(73, 30)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "登  入"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'cbRememberPassword
        '
        Me.cbRememberPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbRememberPassword.AutoSize = True
        Me.cbRememberPassword.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cbRememberPassword.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cbRememberPassword.Location = New System.Drawing.Point(119, 117)
        Me.cbRememberPassword.Name = "cbRememberPassword"
        Me.cbRememberPassword.Size = New System.Drawing.Size(92, 24)
        Me.cbRememberPassword.TabIndex = 2
        Me.cbRememberPassword.TabStop = False
        Me.cbRememberPassword.Text = "記住密碼"
        Me.cbRememberPassword.UseVisualStyleBackColor = True
        '
        'tblMain
        '
        Me.tblMain.BackColor = System.Drawing.Color.Linen
        Me.tblMain.ColumnCount = 3
        Me.tblMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tblMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tblMain.Controls.Add(Me.btnExit, 2, 0)
        Me.tblMain.Controls.Add(Me.btnLogin, 1, 2)
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
        Me.tblMain.Size = New System.Drawing.Size(373, 225)
        Me.tblMain.TabIndex = 6
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnExit.Location = New System.Drawing.Point(348, 0)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(25, 25)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "╳"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'pnlMain
        '
        Me.pnlMain.Controls.Add(Me.txtPassword)
        Me.pnlMain.Controls.Add(Me.btnShowPassword)
        Me.pnlMain.Controls.Add(Me.btnDeleteId)
        Me.pnlMain.Controls.Add(Me.lbTitle)
        Me.pnlMain.Controls.Add(Me.txtId)
        Me.pnlMain.Controls.Add(Me.cbRememberPassword)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(28, 28)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(317, 148)
        Me.pnlMain.TabIndex = 1
        '
        'btnShowPassword
        '
        Me.btnShowPassword.BackColor = System.Drawing.SystemColors.Window
        Me.btnShowPassword.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace
        Me.btnShowPassword.FlatAppearance.BorderSize = 0
        Me.btnShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowPassword.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnShowPassword.ForeColor = System.Drawing.Color.Gray
        Me.btnShowPassword.Location = New System.Drawing.Point(224, 81)
        Me.btnShowPassword.Margin = New System.Windows.Forms.Padding(0)
        Me.btnShowPassword.Name = "btnShowPassword"
        Me.btnShowPassword.Size = New System.Drawing.Size(48, 22)
        Me.btnShowPassword.TabIndex = 8
        Me.btnShowPassword.Text = "Show"
        Me.btnShowPassword.UseVisualStyleBackColor = False
        '
        'btnDeleteId
        '
        Me.btnDeleteId.BackColor = System.Drawing.SystemColors.Window
        Me.btnDeleteId.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace
        Me.btnDeleteId.FlatAppearance.BorderSize = 0
        Me.btnDeleteId.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteId.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnDeleteId.ForeColor = System.Drawing.Color.Gray
        Me.btnDeleteId.Location = New System.Drawing.Point(224, 52)
        Me.btnDeleteId.Margin = New System.Windows.Forms.Padding(0)
        Me.btnDeleteId.Name = "btnDeleteId"
        Me.btnDeleteId.Size = New System.Drawing.Size(48, 22)
        Me.btnDeleteId.TabIndex = 7
        Me.btnDeleteId.Text = "╳"
        Me.btnDeleteId.UseVisualStyleBackColor = False
        '
        'lbTitle
        '
        Me.lbTitle.AutoSize = True
        Me.lbTitle.Font = New System.Drawing.Font("微軟正黑體", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lbTitle.Location = New System.Drawing.Point(52, 5)
        Me.lbTitle.Name = "lbTitle"
        Me.lbTitle.Size = New System.Drawing.Size(231, 34)
        Me.lbTitle.TabIndex = 6
        Me.lbTitle.Text = "昇揚製程薪資系統"
        '
        'btnMin
        '
        Me.btnMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMin.BackColor = System.Drawing.Color.Transparent
        Me.btnMin.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace
        Me.btnMin.FlatAppearance.BorderSize = 0
        Me.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnMin.Location = New System.Drawing.Point(319, 0)
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
        Me.pnlAll.Size = New System.Drawing.Size(375, 227)
        Me.pnlAll.TabIndex = 7
        '
        'txtId
        '
        Me.txtId.BackColor = System.Drawing.SystemColors.Window
        Me.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtId.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtId.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtId.Location = New System.Drawing.Point(62, 52)
        Me.txtId.Margin = New System.Windows.Forms.Padding(5)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(162, 22)
        Me.txtId.TabIndex = 0
        Me.txtId.WaterMarkColor = System.Drawing.Color.Gray
        Me.txtId.WaterMarkText = "UserName"
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(62, 81)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(5)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPassword.Size = New System.Drawing.Size(162, 22)
        Me.txtPassword.TabIndex = 9
        Me.txtPassword.WaterMarkColor = System.Drawing.Color.Gray
        Me.txtPassword.WaterMarkText = "Password"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(375, 227)
        Me.Controls.Add(Me.pnlAll)
        Me.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "登入"
        Me.tblMain.ResumeLayout(False)
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        Me.pnlAll.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnLogin As Windows.Forms.Button
    Friend WithEvents cbRememberPassword As Windows.Forms.CheckBox
    Friend WithEvents txtId As WaterMarkTextBox
    Friend WithEvents tblMain As Windows.Forms.TableLayoutPanel
    Friend WithEvents pnlMain As Windows.Forms.Panel
    Friend WithEvents btnExit As Button
    Friend WithEvents btnMin As Button
    Friend WithEvents lbTitle As Label
    Friend WithEvents pnlAll As Panel
    Friend WithEvents btnShowPassword As Button
    Friend WithEvents btnDeleteId As Button
    Friend WithEvents txtPassword As WaterMarkTextBox
End Class
