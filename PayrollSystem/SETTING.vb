
'
'   設定類別
'
Namespace SETTING

#Region "主設定"
    ''' <summary>
    ''' XML 設定
    ''' </summary>
    Public Class clsSettings

#Region "外部屬性"

        ''' <summary>
        ''' 員工資料設定
        ''' </summary>
        ''' <returns></returns>
        Public Property ColumnDefineList As New List(Of ColumnList)

        ''' <summary>
        ''' 格式化設定
        ''' </summary>
        ''' <returns></returns>
        Public Property FormatList As FormatList

#End Region

#Region "公開函式"

        ''' <summary>
        ''' 回傳格式化的值
        ''' </summary>
        ''' <param name="ColumnDefine">選件列表欄位設定</param>
        ''' <param name="Value">要格式化的值</param>
        ''' <returns></returns>
        Public Function GetFormatValue(ByVal ColumnDefine As ColumnDefine, ByVal Value As String) As String

            '沒指定直接回傳
            If ColumnDefine.CustomizeRule = "" Then Return Value

            Return modCustomizeValue.GetCustomizeValue(ColumnDefine)

        End Function

        Public Function GetColumnList(Id As String) As ColumnList

            For Each E_ColumnList In ColumnDefineList
                If E_ColumnList.Id = Id Then Return E_ColumnList
            Next

            Return Nothing

        End Function

#End Region

    End Class

#End Region

#Region "子畫面定義"

    Public Class StaffDefine

        ''' <summary>
        ''' 欄位定義
        ''' </summary>
        ''' <returns></returns>
        Public Property ColumnList As ColumnList

    End Class

    Public Class WageDefine

        ''' <summary>
        ''' 欄位定義
        ''' </summary>
        ''' <returns></returns>
        Public Property ColumnList As ColumnList

    End Class

    Public Class AttendanceDefine

        ''' <summary>
        ''' 欄位定義
        ''' </summary>
        ''' <returns></returns>
        Public Property ColumnList As ColumnList

    End Class

    Public Class WorkOvertimeDefine

        ''' <summary>
        ''' 欄位定義
        ''' </summary>
        ''' <returns></returns>
        Public Property ColumnList As ColumnList

    End Class

    Public Class VacationDefine

        ''' <summary>
        ''' 欄位定義
        ''' </summary>
        ''' <returns></returns>
        Public Property ColumnList As ColumnList

    End Class

#End Region

#Region "欄位定義"

    ''' <summary>
    ''' 欄位集合
    ''' </summary>
    Public Class ColumnList
        Inherits List(Of ColumnDefine)

        Public Property Id As String

        Public Sub New(Id As String)
            Me.Id = Id
        End Sub

    End Class

    ''' <summary>
    ''' 欄位項目
    ''' </summary>
    <DebuggerDisplay("Name = {Name} | FormatId = {FormatId}")>
    Public Class ColumnDefine
        ''' <summary>
        ''' 欄位代號
        ''' </summary>
        ''' <returns></returns>
        Public Property Id As String
        ''' <summary>
        ''' 欄位顯示名稱
        ''' </summary>
        ''' <returns></returns>
        Public Property Name As String
        ''' <summary>
        ''' 對應XML的欄位名稱
        ''' </summary>
        ''' <returns></returns>
        Public Property PropertyName As String
        ''' <summary>
        ''' 對應元件名稱
        ''' </summary>
        ''' <returns></returns>
        Public Property ControlName As String
        ''' <summary>
        ''' 客製規則
        ''' </summary>
        ''' <returns></returns>
        Public Property CustomizeRule As String
        ''' <summary>
        ''' 客製值
        ''' </summary>
        ''' <returns></returns>
        Public Property CustomizeValue As String

    End Class

#End Region

#Region "客製格式定義"
    ''' <summary>
    ''' 格式化設定
    ''' </summary>
    Public Class FormatList
        Inherits List(Of FormatDefine)

        ''' <summary>
        ''' 取得設定規則
        ''' </summary>
        ''' <param name="sId">識別代號</param>
        ''' <returns></returns>
        Public Function GetRule(ByVal sId As String)

            Return MyBase.Find(Function(x) x.Id = sId)

        End Function

    End Class

    ''' <summary>
    ''' 格式化設定項目
    ''' </summary>
    <DebuggerDisplay("Id = {Id} | Name = {Name}")>
    Public Class FormatDefine
        ''' <summary>
        ''' 識別代號
        ''' </summary>
        ''' <returns></returns>
        Public Property Id As String
        ''' <summary>
        ''' 描述
        ''' </summary>
        ''' <returns></returns>
        Public Property Name As String
        ''' <summary>
        ''' 規則名稱
        ''' </summary>
        ''' <returns></returns>
        Public Property Rule As String
        ''' <summary>
        ''' 格式化參數
        ''' </summary>
        ''' <returns></returns>
        Public Property FormatValue As String

    End Class


#End Region

End Namespace
