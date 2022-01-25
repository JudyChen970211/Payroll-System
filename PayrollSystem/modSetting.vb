Module modSetting

    ''' <summary>
    ''' 目前載入的設定
    ''' </summary>
    Public __CurrentSetting As SETTING.clsSettings = Nothing

    ''' <summary>
    ''' 載設定
    ''' </summary>
    ''' <param name="SettingFile">設定檔路徑</param>
    Friend Sub LoadSetting(ByVal SettingFile As Jibrary.PATH.clsPathInfo)

        Dim TheSetting As New SETTING.clsSettings

        Try

            Dim oXML As New Xml.XmlDocument
            Call oXML.LoadXml(Jibrary.FILE.LoadTextFile(SettingFile, FILE.enumFileEncoding.UTF8))

            Try

                For Each E_NodeString As String In {"Staff", "Wage", "Attendance", "WorkOvertime", "Vacation"}

                    Dim TheNode As Xml.XmlNode = oXML.SelectSingleNode("//" + E_NodeString)

                    Dim ColumnList As New SETTING.ColumnList(TheNode.Name)

                    For Each E_Node As Xml.XmlNode In TheNode.SelectNodes("ColumnList/Column")

                        Dim theColumn As New SETTING.ColumnDefine With {
                        .Id = E_Node.Attributes("Id").Value,
                        .Name = E_Node.Attributes("Name").Value,
                        .PropertyName = E_Node.Attributes("Property").Value,
                        .ControlName = E_Node.Attributes("Control").Value
                    }

                        Call ColumnList.Add(theColumn)

                    Next

                    TheSetting.ColumnDefineList.Add(ColumnList)

                Next

            Catch ex As Exception

                Throw New Exception("載入欄位定義，" & ex.Message)

            End Try

            Try

                Dim TheNode As Xml.XmlNode = oXML.SelectSingleNode("//FormatList")

                Dim FormatList As New SETTING.FormatList()

                For Each E_Node As Xml.XmlNode In TheNode.SelectNodes("Format")

                    Dim theDefine As New SETTING.FormatDefine With {
                    .Id = E_Node.Attributes("Id").Value,
                    .Name = TryGetAttributeValue(E_Node, "Name", ""),
                    .Rule = E_Node.Attributes("Rule").Value,
                    .FormatValue = E_Node.Attributes("Value").Value
                }

                    Call FormatList.Add(theDefine)

                Next

                TheSetting.FormatList = FormatList

            Catch ex As Exception

                Throw New Exception("載入客製格式定義，" & ex.Message)

            End Try

            __CurrentSetting = TheSetting

        Catch ex As Exception

            Throw New Exception("設定檔，" & SettingFile.Path & "，載入失敗，" & ex.Message)

        End Try

    End Sub

    ''' <summary>
    ''' 取得屬性值，錯誤給預設值
    ''' </summary>
    ''' <param name="TheNode">節點</param>
    ''' <param name="AttributeName">屬性名稱</param>
    ''' <param name="DefaultValue">預設值</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function TryGetAttributeValue(ByVal TheNode As Xml.XmlNode, ByVal AttributeName As String, ByVal DefaultValue As String) As String

        Try
            Return TheNode.Attributes(AttributeName).Value
        Catch ex As Exception
            Return DefaultValue
        End Try

    End Function

End Module
