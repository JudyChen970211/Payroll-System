Public Class frmStaff

    ''' <summary>
    ''' 編輯模式
    ''' </summary>
    Private EditMode As enumEditMode = enumEditMode.None

    ''' <summary>
    ''' 已選取資料
    ''' </summary>
    Private _SelectedRow As New DataGridViewRow

    Public Sub New()

        ' 設計工具需要此呼叫。
        InitializeComponent()

        ' 在 InitializeComponent() 呼叫之後加入所有初始設定。

        With dgvStaff

            '不允許使用者異動
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToResizeColumns = False

            '最後一欄填滿右邊剩餘空間
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

            '自動換行
            .DefaultCellStyle.WrapMode = DataGridViewTriState.True

            '自動調整列高
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
            .ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False
            .AllowUserToResizeRows = False

            '標題行 - 不顯示
            .RowHeadersVisible = False

            '標題列 - 置中、換色、換字型
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            '儲存格 - 換字型
            .RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            '唯讀
            .ReadOnly = True

            '整列選取
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect

            For Each E_Item In __CurrentSetting.GetColumnList("Staff")

                Dim Idx As Integer = .Columns.Add(E_Item.Id, E_Item.Name)
                .Columns(Idx).Tag = E_Item

            Next

            .Columns.Item("Email").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            .ClearSelection()

        End With

        lbResignation.Visible = False
        dtpResignation.Visible = False
        rbtnShowEmployed.Checked = True

    End Sub

#Region "DataGridView - 事件"

    Private Sub dgvStaff_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvStaff.CellMouseClick

        If e.RowIndex > -1 Then

            If _SelectedRow Is dgvStaff.Rows(e.RowIndex) Then Exit Sub

            If CheckEdited() Then
                Dim MsgResult As Windows.Forms.DialogResult = MessageBox.Show($"尚未編輯完畢，是否要儲存？{vbCrLf}【是】儲存{vbCrLf}【否】不儲存離開{vbCrLf}【取消】繼續編輯", Me.Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Select Case MsgResult
                    Case DialogResult.Yes
                        Call btnOK.PerformClick()
                    Case DialogResult.No

                    Case DialogResult.Cancel
                        Exit Sub
                End Select
            End If

            _SelectedRow = dgvStaff.Rows(e.RowIndex)

            Call SetData(_SelectedRow)

            Call SetEditorMode(enumEditMode.Update)

        End If

    End Sub

#End Region

#Region "Button - 事件"
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        If CheckData() = False Then Exit Sub

        Dim pl As Jibrary.DATA.clsParameterList = GetData()

        Select Case EditMode

            Case enumEditMode.Insert
                dgvStaff.Rows.Add(pl.GetValueList())
                Call __StaffXmlData.InsertXML(New clsNode(txtWorkId.Text, pl))

            Case enumEditMode.Update
                _SelectedRow.SetValues(pl.GetValueList())
                Call __StaffXmlData.UpdateXML(txtWorkId.Text, New clsNode(txtWorkId.Text, pl))

        End Select

        Call RefreshForm()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If _SelectedRow IsNot Nothing Then
            dgvStaff.Rows.Remove(_SelectedRow)
            Call __StaffXmlData.DeleteXML(txtWorkId.Text)
        End If

        Call RefreshForm()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Call RefreshForm()
    End Sub

    '滑鼠進入 - UI變色
    Private Sub Button_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOK.MouseEnter, btnDelete.MouseEnter, btnCancel.MouseEnter
        sender.BackColor = Color.Peru
        sender.ForeColor = Color.OldLace
    End Sub

    '滑鼠離開 - UI復原
    Private Sub Button_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOK.MouseLeave, btnDelete.MouseLeave, btnCancel.MouseLeave
        sender.BackColor = Color.OldLace
        sender.ForeColor = Color.SaddleBrown
    End Sub

#End Region

#Region "TextBox - 事件"
    '輸入法切換
    Private Sub txtEnglish_GotFocus(sender As Object, e As EventArgs) Handles txtWorkId.GotFocus, txtBankAccount.GotFocus, txtPension.GotFocus, txtWage.GotFocus, txtEmail.GotFocus
        DirectCast(sender, TextBox).ImeMode = Windows.Forms.ImeMode.Alpha
    End Sub

    Private Sub txtChinese_GotFocus(sender As Object, e As EventArgs) Handles txtName.GotFocus, txtPosition.GotFocus
        DirectCast(sender, TextBox).ImeMode = ImeMode.On
    End Sub

#End Region

    Private Sub rbtn_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnShowAll.CheckedChanged, rbtnShowEmployed.CheckedChanged, rbtnShowResignation.CheckedChanged

        Call SetShowMode()

    End Sub

    Private Sub cbResignation_CheckedChanged(sender As Object, e As EventArgs) Handles cbResigned.CheckedChanged

        lbResignation.Visible = cbResigned.Checked
        dtpResignation.Visible = cbResigned.Checked

    End Sub

#Region "公開函式"

    Public Sub RefreshForm()

        Call dgvStaff.Rows.Clear()

        Call dgvStaff.SuspendLayout()

        For Each E_Staff In __StaffXmlData.NodeList

            Dim values As New List(Of String)

            For Each E_Column As DataGridViewColumn In Me.dgvStaff.Columns

                Dim ColumnDefine As SETTING.ColumnDefine = E_Column.Tag
                Dim sTemp As String = __CurrentSetting.GetFormatValue(ColumnDefine, E_Staff.pl.GetValueUnsure(ColumnDefine.PropertyName))

                Call values.Add(sTemp)

            Next

            dgvStaff.Rows.Add(values.ToArray)

        Next

        Call dgvStaff.ResumeLayout()

        _SelectedRow = Nothing
        dgvStaff.ClearSelection()

        Call ClearData()
        Call SetEditorMode(enumEditMode.Insert)

        Call txtName.Select()

        Call SetShowMode()

    End Sub

#End Region

#Region "內部函式"

    ''' <summary>
    ''' 清除資料
    ''' </summary>
    Private Sub ClearData()

        Call SetData(Nothing)

        '取最新工號
        Dim LastId As String = __StaffXmlData.NodeList.Last.Id.Replace("SY-", "")
        If IsNumeric(LastId) Then
            txtWorkId.Text = "SY-" + (CInt(LastId) + 1).ToString.PadLeft(3, "0")
        End If
        txtWorkId.ReadOnly = False

    End Sub

    ''' <summary>
    ''' 設定編輯模式(新增/修改)
    ''' </summary>
    ''' <param name="Mode"></param>
    Private Sub SetEditorMode(Mode As enumEditMode)

        EditMode = Mode
        If EditMode = enumEditMode.Update Then
            btnOK.Text = "修改"
            txtWorkId.ReadOnly = True
        Else
            btnOK.Text = "新增"
        End If

    End Sub

    ''' <summary>
    ''' 設定顯示模式(在職/離職/全部)
    ''' </summary>
    Public Sub SetShowMode()

        If rbtnShowEmployed.Checked Then

            For Each E_Row As DataGridViewRow In dgvStaff.Rows

                If E_Row.Cells("Resignation").Value <> "" Then
                    E_Row.Visible = False
                Else
                    E_Row.Visible = True
                End If

            Next

        ElseIf rbtnShowResignation.Checked Then

            For Each E_Row As DataGridViewRow In dgvStaff.Rows

                If E_Row.Cells("Resignation").Value = "" Then
                    E_Row.Visible = False
                Else
                    E_Row.Visible = True
                End If

            Next

        Else

            For Each E_Row As DataGridViewRow In dgvStaff.Rows

                E_Row.Visible = True

            Next

        End If

    End Sub

    ''' <summary>
    ''' 檢核資料正確性
    ''' </summary>
    ''' <returns></returns>
    Private Function CheckData() As Boolean

        Dim ErrorMessage As New List(Of String)

        '檢查工號不可重複
        If EditMode = enumEditMode.Insert Then
            For Each drStaff As DataGridViewRow In dgvStaff.Rows
                If drStaff.Cells("WorkId").Value = txtWorkId.Text Then
                    ErrorMessage.Add("工號不可重複")
                    Exit For
                End If
            Next
        End If

        '檢查工號不可空白
        If txtWorkId.Text = "" Then ErrorMessage.Add("請輸入工號")

        '檢查姓名不可空白
        If txtName.Text = "" Then ErrorMessage.Add("請輸入姓名")

        '檢查 Email 正確性
        If txtEmail.Text <> "" Then
            Dim idx As Integer = txtEmail.Text.IndexOf("@")
            If idx < 0 OrElse txtEmail.Text.IndexOf(".", idx) = -1 Then ErrorMessage.Add("Email 格式不符")
        End If

        '離職日不可小於到職日
        If cbResigned.Checked = True Then
            If DateTime.Compare(dtpOnBoard.Value, dtpResignation.Value) > 0 Then
                ErrorMessage.Add("離職日不可小於到職日")
            End If
        End If

        '檢查薪資正確性
        If txtWage.Text = "" Then
            ErrorMessage.Add("請輸入薪資")
        Else
            If IsNumeric(txtWage.Text) = False Then ErrorMessage.Add("薪資格式不符(數字)")
        End If

        If ErrorMessage.Count <> 0 Then
            MessageBox.Show(Join(ErrorMessage.ToArray, vbCrLf), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Return False
        End If

        Return True

    End Function

    ''' <summary>
    ''' 檢查是否編輯過
    ''' </summary>
    ''' <returns></returns>
    Private Function CheckEdited() As Boolean

        If _SelectedRow Is Nothing Then Return False

        Dim pl As Jibrary.DATA.clsParameterList = GetData()

        For Each E_Column As DataGridViewColumn In dgvStaff.Columns
            If _SelectedRow.Cells(E_Column.Name).Value <> pl.GetValue(E_Column.Name) Then Return True
        Next

        Return False

    End Function

    Private Function GetData() As Jibrary.DATA.clsParameterList

        Dim pl As New Jibrary.DATA.clsParameterList

        For Each E_Column As DataGridViewColumn In dgvStaff.Columns
            Select Case E_Column.Name
                Case "OnBoard", "Resignation"
                    pl.Add(E_Column.Name, CType(Me.Controls.Find(E_Column.Tag.ControlName, True).First, DateTimePicker).Value.ToString("yyyy-MM-dd"))
                Case Else
                    pl.Add(E_Column.Name, Me.Controls.Find(E_Column.Tag.ControlName, True).First.Text)
            End Select
        Next

        If Not cbResigned.Checked Then pl.SetValue("Resignation", "")

        Return pl
    End Function

    Private Sub SetData(dataRow As DataGridViewRow)

        If dataRow IsNot Nothing Then

            For Each E_Column As DataGridViewColumn In dgvStaff.Columns
                Select Case E_Column.Name
                    Case "Identity"
                        cbIdentity.SelectedIndex = cbIdentity.FindStringExact(dataRow.Cells(E_Column.Name).Value)
                    Case "OnBoard", "Resignation"
                        If dataRow.Cells(E_Column.Name).Value <> "" Then CType(Me.Controls.Find("dtp" + E_Column.Name, True).First, DateTimePicker).Value = CDate(dataRow.Cells(E_Column.Name).Value)
                    Case Else
                        CType(Me.Controls.Find("txt" + E_Column.Name, True).First, TextBox).Text = dataRow.Cells(E_Column.Name).Value
                End Select
            Next

            cbResigned.Checked = dataRow.Cells("Resignation").Value <> ""

        Else

            For Each E_Column As DataGridViewColumn In dgvStaff.Columns
                Select Case E_Column.Name
                    Case "Identity"
                        cbIdentity.SelectedIndex = 1
                    Case "OnBoard", "Resignation"
                        CType(Me.Controls.Find("dtp" + E_Column.Name, True).First, DateTimePicker).ResetText()
                    Case Else
                        CType(Me.Controls.Find("txt" + E_Column.Name, True).First, TextBox).Text = ""
                End Select
            Next

            cbResigned.Checked = False

        End If
    End Sub

#End Region

End Class

