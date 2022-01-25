Imports System.ComponentModel

Public Class frmMain

    ''' <summary>
    ''' 發生無法處理的錯誤，需關閉畫面
    ''' </summary>
    ''' <remarks></remarks>
    Public Event onError(sender As Object)

    ''' <summary>
    ''' 變更流程
    ''' </summary>
    ''' <param name="enumFlow">校登流程常數</param>
    ''' <remarks></remarks>
    Public Event onFlowHandle(ByVal enumFlow As enumFlowHandle)

    ''' <summary>
    ''' 離開系統
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <remarks></remarks>
    Public Event onExitSystem(sender As Object)

    'MDI子視窗--員工資料
    Friend WithEvents _WinForm_Staff As frmStaff
    'MDI子視窗--薪資資料
    Friend WithEvents _WinForm_Wage As frmWage
    'MDI子視窗--出勤資料
    Friend WithEvents _WinForm_Attendance As frmAttendance
    'MDI子視窗--加班資料
    Friend WithEvents _WinForm_WorkOvertime As frmWorkOvertime
    'MDI子視窗--休假資料
    Friend WithEvents _WinForm_Vacation As frmVacation

    Public Sub New()

        ' 設計工具需要此呼叫。
        InitializeComponent()

        ' 在 InitializeComponent() 呼叫之後加入所有初始設定。

        _WinForm_Staff = New frmStaff
        _WinForm_Staff.MdiParent = Me
        _WinForm_Staff.Dock = DockStyle.Fill

        _WinForm_Wage = New frmWage
        _WinForm_Wage.MdiParent = Me
        _WinForm_Wage.Dock = DockStyle.Fill

        _WinForm_Attendance = New frmAttendance
        _WinForm_Attendance.MdiParent = Me
        _WinForm_Attendance.Dock = DockStyle.Fill

        _WinForm_WorkOvertime = New frmWorkOvertime
        _WinForm_WorkOvertime.MdiParent = Me
        _WinForm_WorkOvertime.Dock = DockStyle.Fill

        _WinForm_Vacation = New frmVacation
        _WinForm_Vacation.MdiParent = Me
        _WinForm_Vacation.Dock = DockStyle.Fill

        Me.WindowState = Windows.Forms.FormWindowState.Maximized

    End Sub

    Private Sub frmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        End
    End Sub

    Private Sub frmMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown


        Me.Text = "系統 ( 人員：" + __StaffId + "、權限：" + __Level.ToString + " )"

    End Sub

    Private Sub Mnu_File_Close_Click(sender As Object, e As EventArgs) Handles Mnu_File_Close.Click

        RaiseEvent onFlowHandle(enumFlowHandle.FLOW_EXIT)

    End Sub

    Private Sub Mnu_File_Logout_Click(sender As Object, e As EventArgs) Handles Mnu_File_Logout.Click

        RaiseEvent onFlowHandle(enumFlowHandle.FLOW_LOGIN)

    End Sub

    Private Sub Mnu_Manager_Staff_Click(sender As Object, e As EventArgs) Handles Mnu_Manager_Staff.Click

        __frmCheckStaff.Show()
        __frmCheckStaff.TopMost = True

    End Sub

    Private Sub Mnu_Manager_Login_Click(sender As Object, e As EventArgs) Handles Mnu_Manager_Login.Click

        __frmCheckLogin.Show()
        __frmCheckStaff.TopMost = True

    End Sub

    Private Sub Mnu_System_AccountSetting_Click(sender As Object, e As EventArgs) Handles Mnu_System_AccountSetting.Click
        __frmSetPassword.ShowDialog()
    End Sub


#Region "Button - 事件"

    Private Sub btnStaff_Click(sender As Object, e As EventArgs) Handles btnStaff.Click
        RaiseEvent onFlowHandle(enumFlowHandle.FLOW_STAFF)
    End Sub

    Private Sub btnWage_Click(sender As Object, e As EventArgs) Handles btnWage.Click
        RaiseEvent onFlowHandle(enumFlowHandle.FLOW_WAGECALCULATE)
    End Sub

    Private Sub btnAttendance_Click(sender As Object, e As EventArgs) Handles btnAttendance.Click
        RaiseEvent onFlowHandle(enumFlowHandle.FLOW_ATTENDANCE)
    End Sub

    Private Sub btnWorkOvertime_Click(sender As Object, e As EventArgs) Handles btnWorkOvertime.Click
        RaiseEvent onFlowHandle(enumFlowHandle.FLOW_WORKOVERTIME)
    End Sub

    Private Sub btnVacation_Click(sender As Object, e As EventArgs) Handles btnVacation.Click
        RaiseEvent onFlowHandle(enumFlowHandle.FLOW_VACATION)
    End Sub

#End Region

    Private Sub InitForm()

        btnStaff.BackColor = Color.Ivory
        btnWage.BackColor = Color.Ivory
        btnAttendance.BackColor = Color.Ivory
        btnWorkOvertime.BackColor = Color.Ivory
        btnVacation.BackColor = Color.Ivory

        Call spcMain.Panel2.Controls.Clear()

    End Sub

    Public Sub ChangeForm(enumFlowHandle As enumFlowHandle)

        Call InitForm()

        Select Case enumFlowHandle

            Case enumFlowHandle.FLOW_STAFF
                btnStaff.BackColor = Color.Tan
                spcMain.Panel2.Controls.Add(_WinForm_Staff)
                Call _WinForm_Staff.RefreshForm()
                Call _WinForm_Staff.Show()

            Case enumFlowHandle.FLOW_WAGECALCULATE
                btnWage.BackColor = Color.Tan
                spcMain.Panel2.Controls.Add(_WinForm_Wage)
                Call _WinForm_Wage.Show()

            Case enumFlowHandle.FLOW_ATTENDANCE
                btnAttendance.BackColor = Color.Tan
                spcMain.Panel2.Controls.Add(_WinForm_Attendance)
                Call _WinForm_Attendance.Show()

            Case enumFlowHandle.FLOW_WORKOVERTIME
                btnWorkOvertime.BackColor = Color.Tan
                spcMain.Panel2.Controls.Add(_WinForm_WorkOvertime)
                Call _WinForm_WorkOvertime.Show()

            Case enumFlowHandle.FLOW_VACATION
                btnVacation.BackColor = Color.Tan
                spcMain.Panel2.Controls.Add(_WinForm_Vacation)
                Call _WinForm_Vacation.Show()

        End Select


    End Sub

End Class