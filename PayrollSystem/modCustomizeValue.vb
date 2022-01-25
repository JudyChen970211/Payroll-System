Public Module modCustomizeValue
    Friend Function GetCustomizeValue(ByVal ColumnDefine As SETTING.ColumnDefine) As String

        Dim DL As New Jibrary.DATA.clsDataList(ColumnDefine.CustomizeValue)

        For i As Integer = 1 To DL.Count

            Dim CustomizeValue As String = DL.GetItem(i)
            '判斷這個 CustomizeValue 是否為欄位名稱

            If CustomizeValue.StartsWith("#") AndAlso CustomizeValue.EndsWith("#") Then

                CustomizeValue = Mid(CustomizeValue, 2, CustomizeValue.Length - 2)

                If CustomizeValue.Contains(".") Then
                    Split(CustomizeValue)
                End If


                'TODO:轉換值
                DL.SetItem(i, CustomizeValue)

                End If

        Next

        Return CustomizeValue(ColumnDefine.CustomizeRule, DL)

    End Function



    Friend Function CustomizeValue(cCustomizeRule As String, DL_CustomizeValue As Jibrary.DATA.clsDataList) As String

        Select Case cCustomizeRule.ToUpper

            Case "".ToUpper
                Return ""

            Case "IIF".ToUpper

                '|FieldId|MatchValue|TrueResponse|FalseResponse|	
                '若 FieldId 的值符合 MatchValue則以 TrueResonse寫入，反之以 FalseResponse 寫入

                If DL_CustomizeValue.Count <> 4 Then
                    Throw New Exception("CustomizeRule IIF 無法處理 DL 資料：" + DL_CustomizeValue.ToString + "，原因為：參數應該要有四個。")
                End If

                If DL_CustomizeValue.GetItem(1).ToUpper = DL_CustomizeValue.GetItem(2).ToUpper Then
                    Return DL_CustomizeValue.GetItem(3)
                Else
                    Return DL_CustomizeValue.GetItem(4)
                End If

                '2015/12/21 增加 Contains (多選項目存在某個項目值)
            Case "Contains".ToUpper

                '|FieldId|ContainValue|TrueResponse|FalseResponse|	
                '若 FieldId 為多選項目(以逗點分隔)，若存在 ContainValue 的項目，則以 TrueResonse寫入，反之以 FalseResponse 寫入

                If DL_CustomizeValue.Count <> 4 Then
                    Throw New Exception("CustomizeRule Contains 無法處理 DL 資料：" + DL_CustomizeValue.ToString + "，原因為：參數應該要有四個。")
                End If

                '先前後補上,, 以免誤判 xx, 和 x,
                Dim ValueString As String = "," + DL_CustomizeValue.GetItem(1) + ","
                '轉字串陣列
                Dim Values() As String = Strings.Split(ValueString, ",")
                '轉 DL
                Dim DL_Values As New Jibrary.DATA.clsDataList(Values)

                '如果存在
                If DL_Values.Contains(DL_CustomizeValue.GetItem(2).ToUpper) = True Then
                    Return DL_CustomizeValue.GetItem(3)
                Else
                    Return DL_CustomizeValue.GetItem(4)
                End If

            Case "FirstNotEmpty".ToUpper

                '|FieldId1|FieldId2|…|	依序取一個非空值
                '如果 Field1 有值，就直接輸出
                '如果沒有就繼續往下面抓()
                '如果遇到不是(FieldId, 會直接把他當值輸出)

                For Each TheItem As String In DL_CustomizeValue.ConvertToList
                    If TheItem.Trim <> "" Then
                        Return TheItem
                    End If
                Next

                '如果都沒有符合的就回傳空值
                Return ""

                '2015/09/22 增加
            Case "Date7To8".ToUpper

                '民國年七碼 yyyMMdd  轉西元年八碼 yyyyMMdd
                '前題是 Field1 必須要符合民國年的邏輯
                '若(FieldId = 空值, 或錯誤的格式, 轉出來都為空值)

                Dim TheItem As String = DL_CustomizeValue.GetFirstItem
                Try
                    Dim yyy As Int32 = Strings.Left(TheItem, 3)
                    Dim mm As Int32 = Strings.Mid(TheItem, 4, 2)
                    Dim dd As Int32 = Strings.Right(TheItem, 2)
                    Return CDate(CStr(yyy + 1911) + "/" + mm.ToString + "/" + dd.ToString).ToString("yyyyMMdd")
                Catch ex As Exception
                    '任何錯誤回傳空值
                    Return ""
                End Try

                '2016/01/28 增加
            Case "Date78To8".ToUpper

                Dim TheItem As String = DL_CustomizeValue.GetFirstItem
                Try
                    If TheItem.Length = 7 Then
                        Dim yyy As Int32 = Strings.Left(TheItem, 3)
                        Dim mm As Int32 = Strings.Mid(TheItem, 4, 2)
                        Dim dd As Int32 = Strings.Right(TheItem, 2)
                        Return CDate(CStr(yyy + 1911) + "/" + mm.ToString + "/" + dd.ToString).ToString("yyyyMMdd")
                    ElseIf TheItem.Length = 8 Then
                        Dim yyyy As Int32 = Strings.Left(TheItem, 4)
                        Dim mm As Int32 = Strings.Mid(TheItem, 5, 2)
                        Dim dd As Int32 = Strings.Right(TheItem, 2)
                        Return CDate(yyyy.ToString + "/" + mm.ToString + "/" + dd.ToString).ToString("yyyyMMdd")
                    End If

                Catch ex As Exception
                    '任何錯誤回傳空值
                    Return ""
                End Try

                '2017/01/09 增加
            Case "Date3To4".ToUpper

                '民國年3碼 yyy 轉西元年4碼 yyyy
                Dim TheItem As String = DL_CustomizeValue.GetFirstItem
                Try
                    Dim yyy As Int32 = Strings.Left(TheItem, 3)
                    Return CStr(yyy + 1911)
                Catch ex As Exception
                    '任何錯誤回傳空值
                    Return ""
                End Try


                '2015/09/22 增加
            Case "MathMultiply".ToUpper

                '乘法
                '|FieldId|乘多少|Format|

                If DL_CustomizeValue.Count <> 3 Then
                    Throw New Exception("CustomizeRule MathMultiply 無法處理 DL 資料：" + DL_CustomizeValue.ToString + "，原因為：參數應該要有3個。")
                End If

                Try
                    Dim Value1 As Single = DL_CustomizeValue.GetItem(1)
                    Dim Value2 As Single = DL_CustomizeValue.GetItem(2)
                    Dim Format As String = DL_CustomizeValue.GetItem(3)
                    Return CSng(Value1 * Value2).ToString(Format)
                Catch ex As Exception
                    Return ""
                End Try

                '2015/09/22 增加
            Case "MathDivide".ToUpper

                '除法
                '|FieldId|除多少|Format|

                If DL_CustomizeValue.Count <> 3 Then
                    Throw New Exception("CustomizeRule MathDivide 無法處理 DL 資料：" + DL_CustomizeValue.ToString + "，原因為：參數應該要有3個。")
                End If

                Try
                    Dim Value1 As Single = DL_CustomizeValue.GetItem(1)
                    Dim Value2 As Single = DL_CustomizeValue.GetItem(2)
                    Dim Format As String = DL_CustomizeValue.GetItem(3)
                    Return CSng(Value1 / Value2).ToString(Format)
                Catch ex As Exception
                    Return ""
                End Try

            Case "Logic".ToUpper

                If DL_CustomizeValue.Count < 3 Then
                    Throw New Exception("CustomizeRule Logic 無法處理 DL 資料：" + DL_CustomizeValue.ToString + "，原因為：參數至少要有 3 個。")
                End If

                Dim Logic As String = DL_CustomizeValue.GetItem(1)
                Dim TrueResponse As String = DL_CustomizeValue.GetItem(2)
                Dim FalseResponse As String = DL_CustomizeValue.GetItem(3)

                '判斷有幾個參數
                For i As Int32 = 1 To 9

                    Dim ParameterId As String = "{" + i.ToString + "}"
                    If Logic.Contains(ParameterId) = False Then
                        Exit For
                    End If
                    '如果有定義{1}, 表示要去抓 DL.GetItem(4) 因為 1=Logic, 2=TrueResponse 3=FalseResponse 4=參數1 5.....  
                    If DL_CustomizeValue.Count < i + 3 Then
                        Throw New Exception("Logic 後處理，Logic=" + Logic + " 定義參數 {" + ParameterId + "} 但是後面參數數量不足。")
                    End If

                    Dim ParameterValue As String = DL_CustomizeValue.GetItem(i + 3)

                    '取代 Logic
                    Logic = Logic.Replace(ParameterId, ParameterValue)

                Next


                '利用XML的 XPATH 來做邏輯運算
                Dim xml As New Xml.XmlDocument
                xml.LoadXml("<ROOT></ROOT>")

                Try
                    If xml.SelectNodes("//ROOT[" + Logic + "]").Count = 1 Then
                        Return TrueResponse
                    Else
                        Return FalseResponse
                    End If
                Catch ex As Exception
                    '邏輯發生例外，都算 False
                    Return FalseResponse
                End Try

                '2016/01/28 增加功能
            Case "CodeConvert".ToUpper

                If DL_CustomizeValue.Count <> 3 Then
                    Throw New Exception("CustomizeRule CodeConvert 無法處理 DL 資料：" + DL_CustomizeValue.ToString + "，原因為：參數要有 3 個。")
                End If

                '|FieldId |BeforeList| AfterList |
                '代碼轉換，將 FieldId 的值，從BeforeList的定義，轉成 AfterList 的定義，若找不到對應的 BeforeList 將回傳空值

                '2017/04/07 Jerry 說 Field 裡面可能是多選值，所以要能夠支援 多個 CODE 轉換

                '原本欄位值
                Dim DL_ValueList As New Jibrary.DATA.clsDataList(Strings.Split(DL_CustomizeValue.GetFirstItem, ","))

                '原代碼對照表
                Dim DL_BeforeCodeList As New Jibrary.DATA.clsDataList(Split(DL_CustomizeValue.GetItem(2), ","))

                '新代碼對照表
                Dim DL_AfterCodeList As New Jibrary.DATA.clsDataList(Split(DL_CustomizeValue.GetItem(3), ","))

                '兩邊定義長度不一樣跳錯誤
                If DL_BeforeCodeList.Count <> DL_AfterCodeList.Count Then
                    Throw New Exception("CodeConvert 定義的 BeforeList(" + DL_BeforeCodeList.Count.ToString + ") 和 AfterList(" + DL_AfterCodeList.Count.ToString + ") 的數量不一致。")
                End If

                '毎個對應值都跑
                For i As Int32 = 1 To DL_ValueList.Count

                    Dim BeforeValue As String = DL_ValueList.GetItem(i)

                    '如果有那就去對應新的CODE
                    Dim CodeIndex As Int32 = DL_BeforeCodeList.GetItem(BeforeValue)

                    '判斷代碼表裡面有沒有
                    If CodeIndex > 0 Then

                        Dim NewValue As String = DL_AfterCodeList.GetItem(CodeIndex)

                        If NewValue.StartsWith("#") AndAlso NewValue.EndsWith("#") Then

                            'NewValue = TheData.GetNodeValue()

                        End If

                        '把值寫回去 DL
                        DL_ValueList.SetItem(i, NewValue)

                    Else
                        '沒有就寫原本的值
                        DL_ValueList.SetItem(i, BeforeValue)
                    End If

                Next

                '把結果吐回去
                Return ""'DL_ValueList.ConvertToList(Jibrary.DATA.jibraryDataType.M)

                '2018/05/18 David 新增數學運算式，雖然客戶沒提，但這個還滿有用的，而且可以取代 MathMultiply, MathDivide
            Case "Mathematics".ToUpper

                If DL_CustomizeValue.Count < 3 Then
                    Throw New Exception("CustomizeRule Mathematics 無法處理 DL 資料：" + DL_CustomizeValue.ToString + "，原因為：參數至少要有 3 個。")
                End If

                Dim sMath As String = DL_CustomizeValue.GetItem(1)
                Dim sFormat As String = DL_CustomizeValue.GetItem(2)

                '判斷有幾個參數
                For i As Int32 = 1 To 9

                    Dim ParameterId As String = "{" + i.ToString + "}"
                    If sMath.Contains(ParameterId) = False Then
                        Exit For
                    End If
                    '如果有定義{1}, 表示要去抓 DL.GetItem(3) 因為 1=Math, 2=Format 3=參數1 4.....  
                    If DL_CustomizeValue.Count < i + 2 Then
                        Throw New Exception("Mathematics 後處理，Math=" + sMath + " 定義參數 {" + ParameterId + "} 但是後面參數數量不足。")
                    End If

                    Dim ParameterValue As String = DL_CustomizeValue.GetItem(i + 2)

                    '取代 Math
                    sMath = sMath.Replace(ParameterId, ParameterValue)

                Next

                Dim xsltExpression As String = String.Format("number({0})", New Text.RegularExpressions.Regex("([\+\-\*])").Replace(sMath, " ${1} ").Replace("/", " div ").Replace("%", " mod "))

                Dim nResult As Double
                Using SR As New IO.StringReader("<r/>")
                    nResult = CDbl(New Xml.XPath.XPathDocument(SR).CreateNavigator().Evaluate(xsltExpression))
                End Using

                Return nResult.ToString(sFormat)

            Case "SubString".ToUpper
                'String.SubString 主要作用是切電話號碼
                If DL_CustomizeValue.Count < 3 Then Throw New Exception

                Dim cValue As String = DL_CustomizeValue.GetItem(1)
                Dim nStart As String = DL_CustomizeValue.GetItem(2)
                Dim nLenght As String = DL_CustomizeValue.GetItem(3)

                If IsNumeric(nStart) = False OrElse IsNumeric(nLenght) = False Then
                    Throw New Exception
                End If

                If cValue.Length < CInt(nStart) Then Return ""

                cValue += Space(nStart + nLenght)

                Return Trim(cValue.Substring(nStart, nLenght))


            Case "StringLeft".ToUpper
                'String.Left
                If DL_CustomizeValue.Count < 2 Then Throw New Exception
                Dim TheItem As String = DL_CustomizeValue.GetItem(1)
                Dim Length As String = DL_CustomizeValue.GetItem(2)

                If IsNumeric(Length) = False Then Throw New Exception

                Return Strings.Left(TheItem, CInt(Length))

            Case "StringRight".ToUpper
                'String.Right
                If DL_CustomizeValue.Count < 2 Then Throw New Exception
                Dim TheItem As String = DL_CustomizeValue.GetItem(1)
                Dim Length As String = DL_CustomizeValue.GetItem(2)

                If IsNumeric(Length) = False Then Throw New Exception

                Return Strings.Right(TheItem, CInt(Length))

            Case "StringJoin".ToUpper

                Dim separator As String = DL_CustomizeValue.GetFirstItem
                Dim oc As New List(Of String)
                For i As Integer = 2 To DL_CustomizeValue.Count
                    Call oc.Add(DL_CustomizeValue.GetItem(i))
                Next

                Return String.Join(separator, oc.ToArray())


            Case "MemberShip".ToUpper
                '這個直接先寫死，傳進來的值為  "| 串接的字元 | 欄位值 | 轉換值 | 欄位值 | 轉換值 | ... |"
                '碰到 Y 就輸出下一個項目的值
                If DL_CustomizeValue.Count / 2 = 0 OrElse DL_CustomizeValue.Count < 3 Then
                    Throw New Exception("參數至少三個") '至少三個，且扣除第一個必須是成對的偶數
                End If

                Dim separator As String = DL_CustomizeValue.GetFirstItem
                Dim oc As New List(Of String)
                For i As Integer = 2 To DL_CustomizeValue.Count Step 2
                    '
                    If DL_CustomizeValue.GetItem(i) = "Y" Then
                        Call oc.Add(DL_CustomizeValue.GetItem(i + 1))
                    End If

                Next

                Return String.Join(separator, oc.ToArray())

            Case Else

                Throw New Exception("未定義的 CustomizeRule 規則名稱：" + cCustomizeRule + " 參數：" + DL_CustomizeValue.ToString)

        End Select

        Return ""

    End Function

End Module
