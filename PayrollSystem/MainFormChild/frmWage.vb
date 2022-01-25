Public Class frmWage


    Public Sub New()

        ' 設計工具需要此呼叫。
        InitializeComponent()

        ' 在 InitializeComponent() 呼叫之後加入所有初始設定。

        With dgvWage

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
            .SelectionMode = DataGridViewSelectionMode.CellSelect

            For Each E_Item In __CurrentSetting.GetColumnList("Wage")

                Dim Idx As Integer = .Columns.Add(E_Item.Id, E_Item.Name)
                .Columns(Idx).Tag = E_Item

            Next

            .Columns.Item("Wage").Frozen = True
            .Columns.Item("Totle").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            .ClearSelection()

        End With
    End Sub

    'Public Sub New()

    '    ' 設計工具需要此呼叫。
    '    InitializeComponent()

    '    ' 在 InitializeComponent() 呼叫之後加入所有初始設定。
    '    With dgvWage

    '        '不允許使用者異動
    '        .AllowUserToAddRows = False
    '        .AllowUserToDeleteRows = False
    '        .AllowUserToResizeColumns = False

    '        '最後一欄填滿右邊剩餘空間
    '        .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

    '        '自動換行
    '        .DefaultCellStyle.WrapMode = DataGridViewTriState.True

    '        '自動調整列高
    '        .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
    '        .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
    '        .ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False
    '        .AllowUserToResizeRows = False

    '        '標題行 - 不顯示
    '        .RowHeadersVisible = False

    '        '標題列 - 置中、換色、換字型
    '        .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

    '        '儲存格 - 換字型
    '        .RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

    '        '唯讀
    '        .ReadOnly = True

    '        '整列選取
    '        .SelectionMode = DataGridViewSelectionMode.FullRowSelect

    '        .Columns.Add("WorkId", "工號")
    '        .Columns.Add("Identity", "身分")
    '        .Columns.Add("Name", "姓名")
    '        .Columns.Add("Position", "職稱")
    '        .Columns.Add("BankAccount", "帳戶")
    '        .Columns.Add("BasicWage", "本薪")
    '        .Columns.Add("Allowance", "職務加給")
    '        .Columns.Add("FoodExpenses", "伙食費")
    '        .Columns.Add("Wage", "合計薪資")
    '        .Columns.Add("PensionByFirm", "勞退金(公司提撥6%)")
    '        .Columns.Add("Pension", "勞退金(自願提撥率)")
    '        .Columns.Add("PensionIndividual", "勞退金(自願提撥)")
    '        .Columns.Add("OnBoard", "到職日")
    '        .Columns.Add("Resignation", "離職日")
    '        .Columns.Add("Email", "Email")

    '        .Columns.Item("Email").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

    '        .Columns.Item("WorkId").Tag = txtWorkId.Text
    '        .Columns.Item("Identity").Tag = cbIdentity.SelectedValue
    '        .Columns.Item("Name").Tag = txtName.Text
    '        .Columns.Item("Position").Tag = txtPosition.Text
    '        .Columns.Item("BankAccount").Tag = txtBankAccount.Text
    '        .Columns.Item("BasicWage").Tag = Nothing
    '        .Columns.Item("Allowance").Tag = Nothing
    '        .Columns.Item("FoodExpenses").Tag = Nothing
    '        .Columns.Item("Wage").Tag = txtWage.Text
    '        .Columns.Item("PensionByFirm").Tag = Nothing
    '        .Columns.Item("Pension").Tag = txtPension.Text
    '        .Columns.Item("PensionIndividual").Tag = Nothing
    '        .Columns.Item("OnBoard").Tag = dtpOnBoard.Value.ToString("yyyy-MM-dd")
    '        .Columns.Item("Resignation").Tag = IIf(cbResignation.Checked, dtpResignation.Value.ToString("yyyy-MM-dd"), "")
    '        .Columns.Item("Email").Tag = txtEmail.Text

    '        .ClearSelection()

    '    End With

    '    Private Function GetAllColumnPL(DataRow As DataGridViewRow) As Jibrary.DATA.clsParameterList

    '    Dim pl As New Jibrary.DATA.clsParameterList

    '    .Columns.Item("WorkId").Tag = txtWorkId.Text
    '    .Columns.Item("Identity").Tag = cbIdentity.SelectedValue
    '    .Columns.Item("Name").Tag = txtName.Text
    '    .Columns.Item("Position").Tag = txtPosition.Text
    '    .Columns.Item("BankAccount").Tag = txtBankAccount.Text
    '    .Columns.Item("BasicWage").Tag = Nothing
    '    .Columns.Item("Allowance").Tag = Nothing
    '    .Columns.Item("FoodExpenses").Tag = Nothing
    '    .Columns.Item("Wage").Tag = txtWage.Text
    '    .Columns.Item("PensionByFirm").Tag = Nothing
    '    .Columns.Item("Pension").Tag = txtPension.Text
    '    .Columns.Item("PensionIndividual").Tag = Nothing
    '    .Columns.Item("OnBoard").Tag = dtpOnBoard.Value.ToString("yyyy-MM-dd")
    '    .Columns.Item("Resignation").Tag = IIf(cbResignation.Checked, dtpResignation.Value.ToString("yyyy-MM-dd"), "")
    '    .Columns.Item("Email").Tag = txtEmail.Text

    '    For Each E_Column As DataGridViewColumn In dgvStaff.Columns
    '        Select Case E_Column.Name
    '            Case "BasicWage"
    '                pl.Add(E_Column.Name, CInt(DataRow.Cells("Wage").Value) * 0.75)
    '            Case "Allowance"
    '                pl.Add(E_Column.Name, CInt(DataRow.Cells("Wage").Value) * 0.25)
    '            Case "FoodExpenses"
    '                'TODO:設定伙食費
    '                pl.Add(E_Column.Name, "2400")
    '            Case "PensionByFirm"
    '                'TODO:設定對照表
    '                pl.Add(E_Column.Name, "1000")
    '            Case "Pension"
    '                pl.Add(E_Column.Name,)
    '            Case Else
    '                If E_Column.Tag IsNot Nothing Then pl.Add(E_Column.Name, DataRow.Cells(E_Column.Name).Value)
    '        End Select

    '    Next



    'End Function
    'End Sub
End Class