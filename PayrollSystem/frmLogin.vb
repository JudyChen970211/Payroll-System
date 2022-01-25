Imports System.Windows.Forms

Public Class frmLogin

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

    '拖曳偏移量
    Private _Offset As Point = Nothing
    Private ShowPassword As Boolean = False

#Region "Form - 視窗移動"

    Private Sub tblMain_MouseDown(sender As Object, e As MouseEventArgs) Handles tblMain.MouseDown
        If e.Button = MouseButtons.Left Then
            '只有按住左鍵才要拖曳
            _Offset = e.Location
        End If
    End Sub

    Private Sub tblMain_MouseMove(sender As Object, e As MouseEventArgs) Handles tblMain.MouseMove
        If _Offset <> Nothing Then
            Me.Location = Me.Location + (e.Location - _Offset)
        End If
    End Sub

    Private Sub tblMain_MouseUp(sender As Object, e As MouseEventArgs) Handles tblMain.MouseUp
        _Offset = Nothing
    End Sub

#End Region

    '離開
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        RaiseEvent onFlowHandle(enumFlowHandle.FLOW_EXIT)
    End Sub

    '縮小
    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Btn_Login_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim ErrorMessage As New List(Of String)

        '檢查帳密不可空白
        If txtId.Text = "" Then ErrorMessage.Add("請輸入帳號")
        If txtPassword.Text = "" Then ErrorMessage.Add("請輸入密碼")


        'TODO:檢查帳密正確性


        If ErrorMessage.Count > 0 Then
            MessageBox.Show(Join(ErrorMessage.ToArray, vbCrLf), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If


        '若無此帳號->新增
        If MsgBox("無此帳號，請問是否要新增", vbYesNo) = MsgBoxResult.No Then
            Exit Sub
        Else
            'TODO:新增
        End If

        '紀錄狀態
        __StaffId = txtId.Text
        __StaffPassword = txtPassword.Text
        'TODO:分級
        __Level = enumLevel.Administrator

        Call modSystem.SaveLoginInfo(txtId.Text, txtPassword.Text, cbRememberPassword.Checked)

        '登入後進入主畫面
        RaiseEvent onFlowHandle(enumFlowHandle.FLOW_STAFF)

    End Sub

    Private Sub CheckPasswordChar()

        If ShowPassword Then
            btnShowPassword.Text = "Hide"
            txtPassword.PasswordChar = ""
        Else
            btnShowPassword.Text = "Show"
            txtPassword.PasswordChar = "●"
        End If

    End Sub

    Private Sub btnShowPassword_Click(sender As Object, e As EventArgs) Handles btnShowPassword.Click

        ShowPassword = Not ShowPassword
        Call CheckPasswordChar()

    End Sub

    Private Sub btnDeleteId_Click(sender As Object, e As EventArgs) Handles btnDeleteId.Click
        txtId.Text = ""
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs)

        If (e.KeyCode = Keys.Enter) Then
            Call btnLogin.PerformClick()
        End If

    End Sub

    Public Sub LoadData()

        Try

            Dim LoginInfo As New Jibrary.DATA.clsDataList(LoadLoginInfo())
            txtId.Text = LoginInfo.GetItem(0)
            txtPassword.Text = Jibrary.STR.Decrypt(LoginInfo.GetItem(1))
            cbRememberPassword.Checked = txtPassword.Text <> ""

        Catch ex As Exception

            txtId.Text = ""
            txtPassword.Text = ""
            cbRememberPassword.Checked = False

        End Try

        If txtId.Text <> "" Then
            Call txtPassword.Select()
            txtPassword.SelectionStart = txtPassword.TextLength
        Else
            Call txtId.Select()
        End If

    End Sub


End Class