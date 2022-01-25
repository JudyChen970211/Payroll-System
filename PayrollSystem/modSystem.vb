Module modSystem

    ''' <summary>
    ''' 系統名稱
    ''' </summary>
    Public __SystemName As String = "昇揚製程薪資系統"

    ''' <summary>
    ''' 登入人員Id
    ''' </summary>
    Friend __StaffId As String = ""

    ''' <summary>
    ''' 登入人員Password
    ''' </summary>
    Friend __StaffPassword As String = ""

    ''' <summary>
    ''' 登入權限
    ''' </summary>
    Friend __Level As enumLevel = enumLevel.None

    ''' <summary>
    ''' 更改密碼子視窗
    ''' </summary>
    Friend __frmSetPassword As New frmSetPassword

    ''' <summary>
    ''' 查看人員列表子視窗
    ''' </summary>
    Friend __frmCheckStaff As New frmCheckStaff

    ''' <summary>
    ''' 查看登入紀錄子視窗
    ''' </summary>
    Friend __frmCheckLogin As New frmCheckLogin

    ''' <summary>
    ''' 目前流程
    ''' </summary>
    ''' <remarks></remarks>
    Public __CurrentFlowHandle As enumFlowHandle = enumFlowHandle.FLOW_NONE

    ''' <summary>
    ''' 登入資訊檔
    ''' </summary>
    Private __LoginInfoFile As New Jibrary.PATH.clsPathInfo(System.Windows.Forms.Application.StartupPath + "\LoginInfo.txt")

    ''' <summary>
    ''' 新增設定檔路徑
    ''' </summary>
    Public __SettingFile As New Jibrary.PATH.clsPathInfo(Application.StartupPath + "\Settings.xml")

    ''' <summary>
    ''' 人員資料
    ''' </summary>
    Public __StaffXmlData As New clsXML("Staff")

    ''' <summary>
    ''' 當月出勤紀錄
    ''' </summary>
    Public __AttendanceXmlData As New clsXML("Attendance")

    ''' <summary>
    ''' 當月加班紀錄
    ''' </summary>
    Public __WorkOvertimeXmlData As New clsXML("WorkOvertime")

    ''' <summary>
    ''' 當月休假紀錄
    ''' </summary>
    Public __VacationXmlData As New clsXML("Vacation")

    Public Sub SaveLoginInfo(Id As String, Password As String, RememberPassword As Boolean)

        Dim DL As New Jibrary.DATA.clsDataList
        DL.Add(Id)
        If RememberPassword Then
            DL.Add(Jibrary.STR.Encrypt(Password))
        Else
            DL.Add(Jibrary.STR.Encrypt(""))
        End If

        Call Jibrary.FILE.SaveTextFile(DL.ConvertToString, __LoginInfoFile, Jibrary.FILE.enumFileEncoding.UTF8)

    End Sub

    Public Function LoadLoginInfo() As String
        Return Jibrary.FILE.LoadTextFile(__LoginInfoFile, Jibrary.FILE.enumFileEncoding.UTF8)
    End Function

End Module
