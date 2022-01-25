Public Class frmSetPassword

    '拖曳偏移量
    Private _Offset As Point = Nothing

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
        Call Me.Close()
    End Sub

    '縮小
    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click

        Me.WindowState = FormWindowState.Minimized

    End Sub
    Private Sub frmSetPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtId.Text = __StaffId
        txtId.ReadOnly = True

        Call txtPassword.Select()
        txtPassword.SelectionStart = txtPassword.TextLength

    End Sub

    Private Sub Btn_Login_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        If txtPassword.Text = "" Then
            MessageBox.Show("請輸入密碼", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If

        If txtPasswordCheck.Text = "" Then
            MessageBox.Show("請再次輸入密碼確認", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If

        If txtPassword.Text <> txtPasswordCheck.Text Then
            Dim MessageResult As DialogResult = MessageBox.Show($"兩次密碼輸入不符{vbCrLf}是否要清除重新輸入？
{vbCrLf}【是】清除重新輸入{vbCrLf}【否】不清除再次確認", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Select Case MessageResult
                Case DialogResult.Yes
                    txtPassword.Text = ""
                    txtPasswordCheck.Text = ""
                    Call txtPassword.Select()
            End Select
            Exit Sub
        End If

        Call modSystem.SaveLoginInfo(txtId.Text, txtPassword.Text, cbRememberPassword.Checked)
        Me.Close()

    End Sub
End Class