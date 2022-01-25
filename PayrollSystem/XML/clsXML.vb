Public Class clsNode

    Public Property Id As String = ""

    Public Property pl As New Jibrary.DATA.clsParameterList

    Public Sub New(Id As String)
        Me.Id = Id
    End Sub

    Public Sub New(Id As String, pl As Jibrary.DATA.clsParameterList)
        Me.Id = Id
        Me.pl = pl
    End Sub

End Class

Public Class clsXML

    ''' <summary>
    ''' Root
    ''' </summary>
    ''' <returns></returns>
    Public Property Root As String = ""

    ''' <summary>
    ''' Xml檔案路徑
    ''' </summary>
    ''' <returns></returns>
    Public Property XmlPath As Jibrary.PATH.clsPathInfo

    ''' <summary>
    ''' XmlDocument
    ''' </summary>
    ''' <returns></returns>
    Public Property XmlDoc As Xml.XmlDocument

    ''' <summary>
    ''' 節點清單
    ''' </summary>
    ''' <returns></returns>
    Public Property NodeList As New List(Of clsNode)

    ''' <summary>
    ''' 是否已載入
    ''' </summary>
    ''' <returns></returns>
    Public Property IsLoad As Boolean = False

    Public Sub New(Root As String)
        Me.Root = Root
        Me.XmlPath = New Jibrary.PATH.clsPathInfo(Application.StartupPath + "\" + Root + ".xml")
    End Sub


    Public Sub LoadXML()

        If IsLoad = True Then Exit Sub

        Dim XmlDocument As New Xml.XmlDocument
        Call XmlDocument.LoadXml(Jibrary.FILE.LoadTextFile(XmlPath, FILE.enumFileEncoding.UTF8))
        Me.XmlDoc = XmlDocument

        Try

            For Each xmlElement As Xml.XmlElement In XmlDocument.SelectNodes("//" + Root)
                Dim Node As New clsNode(xmlElement.GetAttribute("Id"))
                For Each E_Node As Xml.XmlNode In xmlElement.ChildNodes
                    Node.pl.Add(E_Node.Name, E_Node.InnerText)
                Next
                NodeList.Add(Node)
            Next


        Catch ex As Exception

            Throw New Exception("設定檔，" & Root & "，載入失敗，" & ex.Message)

        End Try

        IsLoad = True

    End Sub

    Public Sub InsertXML(Node As clsNode)

        Me.NodeList.Add(Node)

        Dim XmlRoot As Xml.XmlNode = XmlDoc.DocumentElement
        Dim XmlElement As Xml.XmlElement = XmlDoc.CreateElement(Me.Root)
        Call XmlElement.SetAttribute("Id", Node.Id)

        For Each E_Node As Jibrary.DATA.clsParameter In Node.pl.ConvertToList

            Dim newNode As Xml.XmlElement = XmlDoc.CreateElement(E_Node.Key)
            newNode.InnerText = E_Node.Value
            Call XmlElement.AppendChild(newNode)

        Next

        Call XmlRoot.AppendChild(XmlElement)

        Call XmlDoc.Save(XmlPath.Path)

    End Sub

    Public Sub UpdateXML(Id As String, Node As clsNode)

        For Each E_Node As clsNode In Me.NodeList
            If E_Node.Id = Node.Id Then
                E_Node = Node
                Exit For
            End If
        Next

        Dim XmlElement As Xml.XmlElement = XmlDoc.SelectSingleNode($"//{Me.Root}[@Id='{Id}']")

        For Each E_Node As Xml.XmlElement In XmlElement.ChildNodes
            E_Node.InnerText = Node.pl.GetValueUnsure(E_Node.Name)
        Next

        Call XmlDoc.Save(XmlPath.Path)

    End Sub

    Public Sub DeleteXML(Id As String)

        For Each E_Node As clsNode In Me.NodeList
            If E_Node.Id = Id Then
                Me.NodeList.Remove(E_Node)
                Exit For
            End If
        Next

        Dim XmlRoot As Xml.XmlNode = XmlDoc.DocumentElement

        Dim XmlElement As Xml.XmlElement = XmlDoc.SelectSingleNode($"//{Me.Root}[@Id='{Id}']")

        Call XmlRoot.RemoveChild(XmlElement)

        Call XmlDoc.Save(XmlPath.Path)

    End Sub

End Class
