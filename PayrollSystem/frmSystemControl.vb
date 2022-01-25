'****************************
'*                          *
'*    程式起始及流程控制       *
'*                          *
'****************************
Public Class frmSystemControl

    '登入畫面
    Private WithEvents _Form_Login As frmLogin = Nothing
    '主畫面
    Private WithEvents _Form_Main As frmMain = Nothing

    Public Sub New()

        ' 設計工具需要此呼叫。
        InitializeComponent()

        ' 在 InitializeComponent() 呼叫之後加入所有初始設定。

    End Sub

    Private Sub frmSystemControl_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed

        '釋放物件
        If _Form_Login IsNot Nothing Then
            Call _Form_Login.Dispose()
            _Form_Login = Nothing
        End If

        If _Form_Main IsNot Nothing Then
            Call _Form_Main.Dispose()
            _Form_Main = Nothing
        End If

        End

    End Sub

    '關閉視窗
    Private Sub frmSystemControl_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Call Me.Dispose()
    End Sub

    '載入視窗
    Private Sub frmSystemControl_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        '0. -- 先隱藏自己
        Me.Visible = False
        Me.Hide()

        Call bgwOnLoad.RunWorkerAsync()

    End Sub

#Region "BackGroundWorker 事件"

    '背景作業載入
    Private Sub bgwOnLoad_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwOnLoad.DoWork

        Dim nTotalProgress As Integer = 7
        Dim nCurrentProgess As Integer = 0

        Dim sStatus As String = ""
        Dim sErrorMessage As String = ""

        Try
            '1. -- 載入設定檔
            Call LoadSetting(__SettingFile)
            sStatus = "載入設定檔..."
            nCurrentProgess += 1
            'Call bgwOnLoad.ReportProgress((nCurrentProgess / nTotalProgress * 100), sStatus)

            '2. -- 載入員工資料
            Call __StaffXmlData.LoadXML()
            sStatus = "載入員工資料..."
            nCurrentProgess += 1
            'Call bgwOnLoad.ReportProgress((nCurrentProgess / nTotalProgress * 100), sStatus)

            '3. -- 載入當月薪資計算
            'Call __WageXmlData.LoadXML()
            sStatus = "載入當月薪資計算..."
            nCurrentProgess += 1
            'Call bgwOnLoad.ReportProgress((nCurrentProgess / nTotalProgress * 100), sStatus)

            '4. -- 載入當月出勤紀錄
            Call __AttendanceXmlData.LoadXML()
            sStatus = "載入設定..."
            nCurrentProgess += 1
            'Call bgwOnLoad.ReportProgress((nCurrentProgess / nTotalProgress * 100), sStatus)

            '5. -- 載入當月加班紀錄
            Call __WorkOvertimeXmlData.LoadXML()
            sStatus = "載入設定..."
            nCurrentProgess += 1
            'Call bgwOnLoad.ReportProgress((nCurrentProgess / nTotalProgress * 100), sStatus)

            '6. -- 載入當月休假紀錄
            Call __VacationXmlData.LoadXML()
            sStatus = "載入設定..."
            nCurrentProgess += 1
            'Call bgwOnLoad.ReportProgress((nCurrentProgess / nTotalProgress * 100), sStatus)

        Catch ex As Exception

            sErrorMessage = ex.Message

        Finally

            '記錄處理結果，沒錯誤給Nothing
            e.Result = IIf(sErrorMessage = "", Nothing, sErrorMessage)

        End Try

    End Sub

    '更新啟動畫面訊息
    'Private Sub bgwOnLoad_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bgwOnLoad.ProgressChanged

    '    '設定訊息會連主視窗一起顯示，所以要再隱藏自己，只是SystemControl本身是透明視窗看不到
    '    Me.Visible = False
    '    Call Me.Hide()

    'End Sub

    '背景作業完成
    Private Sub bgwOnLoad_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwOnLoad.RunWorkerCompleted

        '開始處理跟視窗有關的事
        Try

            '顯示載入過程的錯誤
            If e.Result IsNot Nothing Then
                Throw New Exception(e.Result.ToString)
            End If

            Call FlowHandle(enumFlowHandle.FLOW_LOGIN)

        Catch ex As Exception

            '錯誤的話就把表單關閉
            'TODO:紀錄LOG
            '__Sys.Log = ("x SystemControl Load Editor Error: " & ex.Message)
            Call MessageBox.Show(ex.Message, __SystemName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Call FlowHandle(enumFlowHandle.FLOW_EXIT)

        End Try

    End Sub

#End Region

#Region "_Form_MainEdit 事件"

    '主視窗變更校登流程
    Private Sub _Form_MainEdit_onFlowHandle(enumFlow As enumFlowHandle) Handles _Form_Main.onFlowHandle

        Call FlowHandle(enumFlow)

    End Sub

#End Region

#Region "FLOW - 流程控管"

    ''' <summary>
    ''' 流程控管
    ''' </summary>
    Private Sub FlowHandle(enumFlow As enumFlowHandle)

        If __CurrentFlowHandle = enumFlow Then Exit Sub

        __CurrentFlowHandle = enumFlow

        Select Case enumFlow

            Case enumFlowHandle.FLOW_LOGIN
                If _Form_Main IsNot Nothing Then _Form_Main.Hide() '先隱藏主畫面
                If _Form_Login Is Nothing Then _Form_Login = New frmLogin
                _Form_Login.LoadData()
                _Form_Login.Show()

            Case enumFlowHandle.FLOW_STAFF, enumFlowHandle.FLOW_WAGECALCULATE, enumFlowHandle.FLOW_ATTENDANCE, enumFlowHandle.FLOW_WORKOVERTIME, enumFlowHandle.FLOW_VACATION

                If _Form_Login IsNot Nothing Then _Form_Login.Hide() '先隱藏登入
                If _Form_Main Is Nothing Then _Form_Main = New frmMain

                Call _Form_Main.ChangeForm(enumFlow)
                Call _Form_Main.Show()

            Case enumFlowHandle.FLOW_EXIT
                '儲存系統設定
                Call My.Settings.Save()
                '處理關閉程式時該做的事
                Call Me.Close()

            Case Else

        End Select
    End Sub

#End Region

#Region "內部表單 - 事件"
    '內部表單變更校登流程
    Private Sub Form_onFlowHandle(ByVal enumFlow As enumFlowHandle) Handles _Form_Login.onFlowHandle, _Form_Main.onFlowHandle

        Call FlowHandle(enumFlow)

    End Sub

    '呼叫離開系統
    Private Sub Form_onExitSystem(sender As Object) Handles _Form_Login.onExitSystem, _Form_Main.onExitSystem

        '__Sys.Log = (">> " & sender.Name & " Exit Editor")
        Call FlowHandle(enumFlowHandle.FLOW_EXIT)

    End Sub

    '須關閉畫面的錯誤
    Private Sub Form_onError(sender As Object) Handles _Form_Login.onError, _Form_Main.onError

        '__Sys.Log = (">> " & sender.Name & " onError! Exit Editor")
        Call MessageBox.Show("系統出現無法預期的錯誤，詳情請參閱 Log 檔。", __SystemName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Call FlowHandle(enumFlowHandle.FLOW_EXIT)

    End Sub

#End Region
End Class