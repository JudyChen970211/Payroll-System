<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Mnu_File = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mnu_File_Logout = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mnu_File_Close = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mnu_Manager = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mnu_Manager_Staff = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mnu_Manager_Login = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mnu_Setting = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mnu_Setting_Insurance = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mnu_System = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mnu_System_AccountSetting = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mnu_System_ReportSetting = New System.Windows.Forms.ToolStripMenuItem()
        Me.spcMain = New System.Windows.Forms.SplitContainer()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnVacation = New System.Windows.Forms.Button()
        Me.btnAttendance = New System.Windows.Forms.Button()
        Me.btnWage = New System.Windows.Forms.Button()
        Me.btnStaff = New System.Windows.Forms.Button()
        Me.btnWorkOvertime = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.spcMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spcMain.Panel1.SuspendLayout()
        Me.spcMain.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Mnu_File, Me.Mnu_Manager, Me.Mnu_Setting, Me.Mnu_System})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(1600, 30)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Mnu_File
        '
        Me.Mnu_File.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Mnu_File_Logout, Me.Mnu_File_Close})
        Me.Mnu_File.Name = "Mnu_File"
        Me.Mnu_File.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.Mnu_File.Size = New System.Drawing.Size(53, 24)
        Me.Mnu_File.Text = "檔案"
        '
        'Mnu_File_Logout
        '
        Me.Mnu_File_Logout.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Mnu_File_Logout.Name = "Mnu_File_Logout"
        Me.Mnu_File_Logout.Size = New System.Drawing.Size(110, 24)
        Me.Mnu_File_Logout.Text = "登出"
        '
        'Mnu_File_Close
        '
        Me.Mnu_File_Close.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Mnu_File_Close.Name = "Mnu_File_Close"
        Me.Mnu_File_Close.Size = New System.Drawing.Size(110, 24)
        Me.Mnu_File_Close.Text = "結束"
        '
        'Mnu_Manager
        '
        Me.Mnu_Manager.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Mnu_Manager_Staff, Me.Mnu_Manager_Login})
        Me.Mnu_Manager.Name = "Mnu_Manager"
        Me.Mnu_Manager.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.Mnu_Manager.Size = New System.Drawing.Size(53, 24)
        Me.Mnu_Manager.Text = "管理"
        '
        'Mnu_Manager_Staff
        '
        Me.Mnu_Manager_Staff.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Mnu_Manager_Staff.Name = "Mnu_Manager_Staff"
        Me.Mnu_Manager_Staff.Size = New System.Drawing.Size(174, 24)
        Me.Mnu_Manager_Staff.Text = "管理帳號"
        '
        'Mnu_Manager_Login
        '
        Me.Mnu_Manager_Login.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Mnu_Manager_Login.Name = "Mnu_Manager_Login"
        Me.Mnu_Manager_Login.Size = New System.Drawing.Size(174, 24)
        Me.Mnu_Manager_Login.Text = "查看登入紀錄"
        '
        'Mnu_Setting
        '
        Me.Mnu_Setting.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Mnu_Setting_Insurance})
        Me.Mnu_Setting.Name = "Mnu_Setting"
        Me.Mnu_Setting.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.Mnu_Setting.Size = New System.Drawing.Size(53, 24)
        Me.Mnu_Setting.Text = "設定"
        '
        'Mnu_Setting_Insurance
        '
        Me.Mnu_Setting_Insurance.Name = "Mnu_Setting_Insurance"
        Me.Mnu_Setting_Insurance.Size = New System.Drawing.Size(206, 24)
        Me.Mnu_Setting_Insurance.Text = "勞健保費級距設定"
        '
        'Mnu_System
        '
        Me.Mnu_System.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Mnu_System_AccountSetting, Me.Mnu_System_ReportSetting})
        Me.Mnu_System.Name = "Mnu_System"
        Me.Mnu_System.Size = New System.Drawing.Size(53, 24)
        Me.Mnu_System.Text = "系統"
        '
        'Mnu_System_AccountSetting
        '
        Me.Mnu_System_AccountSetting.Name = "Mnu_System_AccountSetting"
        Me.Mnu_System_AccountSetting.Size = New System.Drawing.Size(174, 24)
        Me.Mnu_System_AccountSetting.Text = "帳號密碼設定"
        '
        'Mnu_System_ReportSetting
        '
        Me.Mnu_System_ReportSetting.Name = "Mnu_System_ReportSetting"
        Me.Mnu_System_ReportSetting.Size = New System.Drawing.Size(174, 24)
        Me.Mnu_System_ReportSetting.Text = "報表匯出設定"
        '
        'spcMain
        '
        Me.spcMain.BackColor = System.Drawing.Color.Tan
        Me.spcMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spcMain.Location = New System.Drawing.Point(0, 30)
        Me.spcMain.Margin = New System.Windows.Forms.Padding(5)
        Me.spcMain.Name = "spcMain"
        '
        'spcMain.Panel1
        '
        Me.spcMain.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.spcMain.Size = New System.Drawing.Size(1600, 935)
        Me.spcMain.SplitterDistance = 173
        Me.spcMain.SplitterWidth = 2
        Me.spcMain.TabIndex = 2
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Linen
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnVacation, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.btnAttendance, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btnWage, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnStaff, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnWorkOvertime, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox1, 0, 5)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(173, 935)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'btnVacation
        '
        Me.btnVacation.BackColor = System.Drawing.Color.Ivory
        Me.btnVacation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnVacation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVacation.Location = New System.Drawing.Point(1, 141)
        Me.btnVacation.Margin = New System.Windows.Forms.Padding(1)
        Me.btnVacation.Name = "btnVacation"
        Me.btnVacation.Size = New System.Drawing.Size(171, 33)
        Me.btnVacation.TabIndex = 19
        Me.btnVacation.Text = "休假紀錄"
        Me.btnVacation.UseVisualStyleBackColor = False
        '
        'btnAttendance
        '
        Me.btnAttendance.BackColor = System.Drawing.Color.Ivory
        Me.btnAttendance.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAttendance.Location = New System.Drawing.Point(1, 71)
        Me.btnAttendance.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAttendance.Name = "btnAttendance"
        Me.btnAttendance.Size = New System.Drawing.Size(171, 33)
        Me.btnAttendance.TabIndex = 18
        Me.btnAttendance.Text = "出勤紀錄"
        Me.btnAttendance.UseVisualStyleBackColor = False
        '
        'btnWage
        '
        Me.btnWage.BackColor = System.Drawing.Color.Ivory
        Me.btnWage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnWage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWage.Location = New System.Drawing.Point(1, 36)
        Me.btnWage.Margin = New System.Windows.Forms.Padding(1)
        Me.btnWage.Name = "btnWage"
        Me.btnWage.Size = New System.Drawing.Size(171, 33)
        Me.btnWage.TabIndex = 17
        Me.btnWage.Text = "薪資計算"
        Me.btnWage.UseVisualStyleBackColor = False
        '
        'btnStaff
        '
        Me.btnStaff.BackColor = System.Drawing.Color.Ivory
        Me.btnStaff.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStaff.Location = New System.Drawing.Point(1, 1)
        Me.btnStaff.Margin = New System.Windows.Forms.Padding(1)
        Me.btnStaff.Name = "btnStaff"
        Me.btnStaff.Size = New System.Drawing.Size(171, 33)
        Me.btnStaff.TabIndex = 11
        Me.btnStaff.Text = "員工資料"
        Me.btnStaff.UseVisualStyleBackColor = False
        '
        'btnWorkOvertime
        '
        Me.btnWorkOvertime.BackColor = System.Drawing.Color.Ivory
        Me.btnWorkOvertime.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnWorkOvertime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWorkOvertime.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnWorkOvertime.Location = New System.Drawing.Point(1, 106)
        Me.btnWorkOvertime.Margin = New System.Windows.Forms.Padding(1)
        Me.btnWorkOvertime.Name = "btnWorkOvertime"
        Me.btnWorkOvertime.Size = New System.Drawing.Size(171, 33)
        Me.btnWorkOvertime.TabIndex = 20
        Me.btnWorkOvertime.Text = "加班紀錄"
        Me.btnWorkOvertime.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Location = New System.Drawing.Point(3, 178)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(167, 754)
        Me.TextBox1.TabIndex = 21
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(1600, 965)
        Me.Controls.Add(Me.spcMain)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "frmMain"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.spcMain.Panel1.ResumeLayout(False)
        CType(Me.spcMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spcMain.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As Windows.Forms.MenuStrip
    Friend WithEvents Mnu_File As Windows.Forms.ToolStripMenuItem
    Friend WithEvents Mnu_File_Logout As Windows.Forms.ToolStripMenuItem
    Friend WithEvents Mnu_File_Close As Windows.Forms.ToolStripMenuItem
    Friend WithEvents Mnu_Manager As Windows.Forms.ToolStripMenuItem
    Friend WithEvents Mnu_Manager_Staff As Windows.Forms.ToolStripMenuItem
    Friend WithEvents Mnu_Manager_Login As Windows.Forms.ToolStripMenuItem
    Friend WithEvents Mnu_Setting As Windows.Forms.ToolStripMenuItem
    Friend WithEvents spcMain As Windows.Forms.SplitContainer
    Friend WithEvents Mnu_Setting_Insurance As ToolStripMenuItem
    Friend WithEvents Mnu_System As ToolStripMenuItem
    Friend WithEvents Mnu_System_AccountSetting As ToolStripMenuItem
    Friend WithEvents Mnu_System_ReportSetting As ToolStripMenuItem
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnVacation As Button
    Friend WithEvents btnAttendance As Button
    Friend WithEvents btnWage As Button
    Friend WithEvents btnStaff As Button
    Friend WithEvents btnWorkOvertime As Button
    Friend WithEvents TextBox1 As TextBox
End Class
