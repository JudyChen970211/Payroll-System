Public Class frmAttendance

    ''' <summary>
    ''' 編輯模式
    ''' </summary>
    Private EditMode As enumEditMode = enumEditMode.None

    ''' <summary>
    ''' 已選取資料
    ''' </summary>
    Private _SelectedRow As New DataGridViewRow

    ''' <summary>
    ''' Xml檔路徑
    ''' </summary>
    Private _pi_Xml As New Jibrary.PATH.clsPathInfo(Application.StartupPath + "\Staff.xml")

    ''' <summary>
    ''' 資料檔
    ''' </summary>
    Private _XmlData As New clsXML("Staff")

    ''' <summary>
    ''' 是否載入
    ''' </summary>
    Private _bLoaded As Boolean = False


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

            .Columns.Add("mWorkId", "工號")
            .Columns.Add("cName", "姓名")
            .Columns.Add("cProject", "專案")
            .Columns.Add("cContent", "事由")
            .Columns.Add("dStartDateTime", "起時")
            .Columns.Add("dEndDateTime", "迄時")
            .Columns.Add("cMemo", "備註")


            .Columns.Item("cMemo").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            .ClearSelection()

        End With


        'Call lstCost.Items.Clear()

    End Sub

#Region "Button - 事件"

    '滑鼠進入 - UI變色
    Private Sub Button_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOK.MouseEnter, btnDelete.MouseEnter, btnCancel.MouseEnter, btnAddCost.MouseEnter
        sender.BackColor = Color.Peru
        sender.ForeColor = Color.OldLace
    End Sub

    '滑鼠離開 - UI復原
    Private Sub Button_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOK.MouseLeave, btnDelete.MouseLeave, btnCancel.MouseLeave, btnAddCost.MouseLeave
        sender.BackColor = Color.OldLace
        sender.ForeColor = Color.SaddleBrown
    End Sub

    Private Sub lstCost_ColumnWidthChanging(sender As Object, e As ColumnWidthChangingEventArgs) Handles lstCost.ColumnWidthChanging
        e.Cancel = True
    End Sub

#End Region

#Region "lstCost - 事件"

    Private Sub lstCost_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lstCost.MouseDoubleClick

        If e.Button <> MouseButtons.Left Then
            Exit Sub
        End If

        Dim TheViewItem As ListViewItem = lstCost.FocusedItem

        If TheViewItem IsNot Nothing AndAlso TheViewItem.Selected Then

            Call lstCost.Items.Remove(TheViewItem)

        End If

    End Sub

    Private Sub lstCost_KeyDown(sender As Object, e As KeyEventArgs) Handles lstCost.KeyDown

        If e.KeyCode = Keys.Delete Then

            Dim TheViewItem As ListViewItem = lstCost.FocusedItem

            If TheViewItem IsNot Nothing AndAlso TheViewItem.Selected Then

                Call lstCost.Items.Remove(TheViewItem)

            End If

        End If

    End Sub

    Private Sub btnAddCost_Click(sender As Object, e As EventArgs) Handles btnAddCost.Click

        Dim ErrorMessage As New List(Of String)

        '檢查項目不可空白
        If txtItem.Text = "" Then ErrorMessage.Add("項目不可空白")

        '檢查金額不可空白
        If txtCost.Text = "" Then ErrorMessage.Add("金額不可空白")

        '檢查金額正確性
        If IsNumeric(txtCost.Text) = False Then ErrorMessage.Add("金額格式不符(數字)")

        If ErrorMessage.Count <> 0 Then
            MessageBox.Show(Join(ErrorMessage.ToArray, vbCrLf), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If

        Dim ViewItem As New ListViewItem({txtItem.Text, txtCost.Text})
        Call Me.lstCost.Items.Add(ViewItem)

        txtItem.Text = ""
        txtCost.Text = ""

    End Sub

#End Region

End Class