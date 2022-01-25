Public Module modEnum

    Public Enum enumLevel

        None = -1

        Administrator = 0

        Editor = 1

        Viewer = 2

    End Enum


    ''' <summary>
    ''' 流程常數
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum enumFlowHandle
        ''' <summary>
        ''' None
        ''' </summary>
        FLOW_NONE = -99
        ''' <summary>
        ''' Login
        ''' </summary>
        FLOW_LOGIN = 0
        ''' <summary>
        ''' 員工資料
        ''' </summary>
        FLOW_STAFF = 1
        ''' <summary>
        ''' 薪資計算
        ''' </summary>
        FLOW_WAGECALCULATE = 2
        ''' <summary>
        ''' 出勤紀錄
        ''' </summary>
        FLOW_ATTENDANCE = 3
        ''' <summary>
        ''' 加班紀錄
        ''' </summary>
        FLOW_WORKOVERTIME = 4
        ''' <summary>
        ''' 休假紀錄
        ''' </summary>
        FLOW_VACATION = 5
        ''' <summary>
        ''' 離開
        ''' </summary>
        FLOW_EXIT = 99
    End Enum


    Public Enum enumEditMode

        None = 0

        Insert = 1

        Update = 2

    End Enum


End Module
