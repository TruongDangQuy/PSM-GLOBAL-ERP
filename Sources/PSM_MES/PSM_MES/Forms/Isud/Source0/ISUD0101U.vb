Public Class ISUD0101U
#Region "Variable"
    Private wJOB As Integer

    Private W7106 As T7106_AREA

    Private W1311 As New T1311_AREA
    Private L1311 As New T1311_AREA

    Private W1312 As New T1312_AREA
    Private L1312 As New T1312_AREA

    Private L1313 As New T1313_AREA
    Private W1313 As New T1313_AREA

    Private WRITE_CHK As String
    Private ChkUpload As Boolean = False

    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_ISUD0101U(job As Integer, ShoesCode As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        D7115.ShoesCode = ShoesCode

        wJOB = job

        Link_ISUD0101U = False

        Try
            Select Case job
                Case 1
                Case Else
                    If READ_PFK7106(ShoesCode) = False Then
                        Call MsgBoxP("3", "LINK_ISUD")

                        Me.Dispose()
                        Exit Function
                    End If
            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD0101U = isudCHK


        Catch ex As Exception
            Call MsgBoxP("61", WordConv("BaseComponentBOM"))
        End Try


    End Function

#End Region

#Region "Form"
    Private Sub Form_Activate(sender As Object, e As EventArgs) Handles Me.Load
        If formA = True Then Exit Sub

        WRITE_CHK = ""
        Me.Form_Initial()
        Me.Form_KeyDown()

        wJOB = 1

        Call DATA_INIT()
        Call FORM_INIT()
        Call KEY_COUNT_1311()

        If GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5)) = False Then
            isudCHK = False
            Me.Dispose()
            formA = True

            Call MsgBoxP("You have no right is this program !")
            Exit Sub
        End If

        Select Case wJOB
            Case 1
                Me.Text = Me.Text & " - INSERT"
                If CHK(1) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS2()

            Case 2
                Me.Text = Me.Text & " - SEARCH"

                If CHK(2) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS2()
            Case 3
                Me.Text = Me.Text & " - UPDATE"

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS2()

                If CHK(3) <> "1" Then
                    If CHK(2) <> "1" Then
                        isudCHK = False
                        Me.Dispose()
                        formA = True
                        Call MsgBoxP("You have no right is this program !")
                        Exit Sub
                    Else

                        Me.Text = Me.Text & " - SEARCH"
                        isudCHK = False
                        formA = True
                        wJOB = 2
                        Call MsgBoxP("16", "Form_Activate")
                    End If
                End If

            Case 4
                Me.Text = Me.Text & " - DELETE"

                If CHK(4) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS2()

        End Select

        formA = True
    End Sub
    Private Sub DATA_INIT()
        Try
            Call D7115_CLEAR()

            If READ_PFK7171(ListCode("Season"), "000") Then
                txt_cdSeason.Code = D7171.BasicCode
                txt_cdSeason.Data = D7171.BasicName
            End If

            If READ_PFK7171(ListCode("StateOfficial"), "001") Then
                txt_cdStateOfficial.Code = D7171.BasicCode
                txt_cdStateOfficial.Data = D7171.BasicName
            End If

            If READ_PFK7171(ListCode("OrderGroup"), "002") Then
                txt_cdOrderGroup.Code = D7171.BasicCode
                txt_cdOrderGroup.Data = D7171.BasicName
            End If

            If READ_PFK7171(ListCode("OrderType"), "001") Then
                txt_cdOrderType.Code = D7171.BasicCode
                txt_cdOrderType.Data = D7171.BasicName
            End If

            If READ_PFK7171(ListCode("OrderKind"), "001") Then
                txt_cdOrderKind.Code = D7171.BasicCode
                txt_cdOrderKind.Data = D7171.BasicName
            End If

            If READ_PFK7171(ListCode("OrderWork"), "001") Then
                txt_cdOrderWork.Code = D7171.BasicCode
                txt_cdOrderWork.Data = D7171.BasicName
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub FORM_INIT()

    End Sub
#End Region

#Region "Data_Search"
    Private Function DATA_SEARCH01() As Boolean
        DATA_SEARCH01 = False
        Dim i As Integer

        If CIntp(txt_CustomerCode.Code) = 0 Then Exit Function
        If READ_PFK7101_CODE(txt_CustomerCode.Code) = False Then Exit Function

        SQL = " SELECT K9001_MappingNo, K9001_MappingName FROM PFK9001 WHERE (K9001_CustomerCode = '" + txt_CustomerCode.Code + "' OR K9001_CustomerCode = '') "
        cmd = New SqlClient.SqlCommand(SQL, cn)
        DS1 = PrcDS(cmd, cn)

        txt_MappingNo.Items.Clear()

        If GetDsRc(DS1) > 0 Then
            For i = 0 To GetDsRc(DS1) - 1
                txt_MappingNo.Items.Add(GetDsData(DS1, i, "K9001_MappingNo") & ";" & GetDsData(DS1, i, "K9001_MappingName"))
            Next
            txt_MappingNo.SelectedIndex = 0
        End If


    End Function

    Private Function DATA_SEARCH_VS2() As Boolean
        DATA_SEARCH_VS2 = False
        Dim Value() As String

        Value = txt_MappingNo.Text.Split(";")

        DS1 = PrcDS("USP_ISUD0101U_SEARCH_VS2", cn, Value(0))

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(VS2, DS1, "USP_ISUD0101U_SEARCH_VS2", "VS2")
            vS2.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(VS2, DS1, "USP_ISUD0101U_SEARCH_VS2", "VS2")

        DATA_SEARCH_VS2 = True
    End Function

    Private Structure DVALUE
        Dim RowBegin As Integer
        Dim RowEnd As Integer

        Dim ColBegin As Integer
        Dim ColEnd As Integer

        Dim ItemName As String
    End Structure
    Private Function DATA_SEARCH_VS3() As Boolean
        DATA_SEARCH_VS3 = False
        Dim Starting = New DevExpress.Utils.WaitDialogForm("Loading data...", "PSM")

        Try

            Dim i As Integer
            Dim j As Integer
            Dim ArrValue As New List(Of DVALUE)
            Dim ArrValue_1 As DVALUE
            Dim CntRowEnd As Integer
            Dim Rowbegin As Integer

            DS1 = PrcDS("USP_ISUD0101U_SEARCH_VS3", cn)
            SPR_PRO_NEW(VS3, DS1, "USP_ISUD0101U_SEARCH_VS3", "VS3")

            If GetDsRc(DS1) > 0 Then Exit Function


            For i = 0 To Vs1.ActiveSheet.RowCount - 1
                If getData(Vs1, 0, i) <> "" Then
                    If Rowbegin = 0 Then Rowbegin = i + 1

                    CntRowEnd += 1
                End If
            Next

            If CntRowEnd > 1 Then CntRowEnd -= 1

            For i = 0 To vS2.ActiveSheet.RowCount - 1
                If CIntp(getData(vS2, getColumIndex(vS2, "RowEnd"), i)) > 0 Then
                    ArrValue_1.RowBegin = CIntp(getData(vS2, getColumIndex(vS2, "RowBegin"), i))
                    ArrValue_1.RowEnd = CIntp(getData(vS2, getColumIndex(vS2, "RowEnd"), i))

                    ArrValue_1.ColBegin = CIntp(getData(vS2, getColumIndex(vS2, "ColBegin"), i))
                    ArrValue_1.ColEnd = CIntp(getData(vS2, getColumIndex(vS2, "ColEnd"), i))

                    ArrValue_1.ItemName = getData(vS2, getColumIndex(vS2, "ItemName"), i)

                    ArrValue.Add(ArrValue_1)
                End If
            Next

          
            For j = Rowbegin To Rowbegin + CntRowEnd - 1
                VS3.ActiveSheet.RowCount += 1
                For i = 0 To ArrValue.Count - 1
                    If ArrValue(i).ItemName = "cdSeasonName" Then
                        setData(VS3, getColumIndex(VS3, "cdSeason"), VS3.ActiveSheet.RowCount - 1, txt_cdSeason.Code)
                        setData(VS3, getColumIndex(VS3, "cdSeasonName"), VS3.ActiveSheet.RowCount - 1, txt_cdSeason.Data)

                        'If READ_PFK7171_NAME(ListCode("Season"), getData(Vs1, ArrValue(i).ColBegin, j)) Then
                        '    setData(VS3, getColumIndex(VS3, "cdSeason"), VS3.ActiveSheet.RowCount - 1, D7171.BasicCode)
                        'Else
                        '    setData(VS3, getColumIndex(VS3, "cdSeason"), VS3.ActiveSheet.RowCount - 1, txt_cdSeason.Code)
                        '    setData(VS3, getColumIndex(VS3, "cdSeasonName"), VS3.ActiveSheet.RowCount - 1, txt_cdSeason.Data)
                        'End If
                        GoTo SkipNext
                    End If

                    If ArrValue(i).ItemName = "cdPackingCodeName" Then
                        If READ_PFK7171_NAME(ListCode("PackingCode"), getData(Vs1, ArrValue(i).ColBegin, j)) Then
                            setData(VS3, getColumIndex(VS3, "cdPackingCode"), VS3.ActiveSheet.RowCount - 1, D7171.BasicCode)
                        End If
                    End If

                    If ArrValue(i).ItemName = "ColorCode" Then
                        If getData(Vs1, ArrValue(i).ColBegin, j) = "" Then
                            setData(VS3, getColumIndex(VS3, "ColorCode"), VS3.ActiveSheet.RowCount - 1, "1/0")
                        End If
                    End If

                    If ArrValue(i).ItemName = "ColorName" Then
                        If getData(Vs1, ArrValue(i).ColBegin, j) = "" Then
                            setData(VS3, getColumIndex(VS3, "ColorCode"), VS3.ActiveSheet.RowCount - 1, "1/0")
                        End If
                    End If

                    If ArrValue(i).ItemName = "ProductCode" Then
                        setData(VS3, getColumIndex(VS3, ArrValue(i).ItemName), VS3.ActiveSheet.RowCount - 1, getData(Vs1, ArrValue(i).ColBegin, j))
                        setData(VS3, getColumIndex(VS3, "CustSpecNo"), VS3.ActiveSheet.RowCount - 1, getData(Vs1, ArrValue(i).ColBegin, j))
                        GoTo SkipNext
                    End If

                    If ArrValue(i).ItemName = "CustomerName" Then
                        setData(VS3, getColumIndex(VS3, "CustomerCode"), VS3.ActiveSheet.RowCount - 1, txt_CustomerCode.Code)
                        setData(VS3, getColumIndex(VS3, "CustomerName"), VS3.ActiveSheet.RowCount - 1, txt_CustomerCode.Data)
                        GoTo SkipNext
                    End If

                    If ArrValue(i).ItemName = "SizeRangeName" Then
                        If READ_PFK7104("000001") Then
                            setData(VS3, getColumIndex(VS3, "SizeRange"), VS3.ActiveSheet.RowCount - 1, D7104.SizeRange)
                            setData(VS3, getColumIndex(VS3, "SizeRangeName"), VS3.ActiveSheet.RowCount - 1, D7104.SizeRangeName)
                        End If

                        If READ_PFK7106_1_ALL_CUSTOMER(txt_cdSeason.Code, txt_CustomerCode.Code, "006", getData(VS3, getColumIndex(VS3, "Line"), VS3.ActiveSheet.RowCount - 1), getData(VS3, getColumIndex(VS3, "Article"), VS3.ActiveSheet.RowCount - 1), getData(VS3, getColumIndex(VS3, "ColorName"), VS3.ActiveSheet.RowCount - 1), getData(VS3, getColumIndex(VS3, "ColorCode"), VS3.ActiveSheet.RowCount - 1), getData(VS3, getColumIndex(VS3, "SizeRange"), VS3.ActiveSheet.RowCount - 1)) Then
                            setData(VS3, getColumIndex(VS3, "ShoesCode"), VS3.ActiveSheet.RowCount - 1, D7106.ShoesCode)
                        End If

                        GoTo SkipNext
                    End If

                    setData(VS3, getColumIndex(VS3, ArrValue(i).ItemName), VS3.ActiveSheet.RowCount - 1, getData(Vs1, ArrValue(i).ColBegin, j))

                    If ArrValue(i).ItemName = "DatePO" Or ArrValue(i).ItemName = "DateDelivery" Then
                        Dim tmpDeliveryDate As String

                        tmpDeliveryDate = getData(Vs1, ArrValue(i).ColBegin, j)

                        If IsDate(tmpDeliveryDate) Then
                            Dim TmpDate As New Date
                            TmpDate = CDate(tmpDeliveryDate)
                            tmpDeliveryDate = TmpDate.Year & TmpDate.Month.ToString("00") & TmpDate.Day.ToString("00")
                            setData(VS3, getColumIndex(VS3, ArrValue(i).ItemName), VS3.ActiveSheet.RowCount - 1, tmpDeliveryDate)
                        End If
                    End If

SkipNext:

                Next
            Next

            SPR_BackColumn(VS3, Color.Yellow, getColumIndex(VS3, "cdSeason"))
            SPR_BackColumn(VS3, Color.Yellow, getColumIndex(VS3, "ShoesCode"))
            SPR_BackColumn(VS3, Color.Yellow, getColumIndex(VS3, "SizeRange"))
            SPR_BackColumn(VS3, Color.Yellow, getColumIndex(VS3, "cdPackingCode"))

            If chk_ErrorOnly.Checked = True Then Data_Info(True) Else Data_Info(False)

            DATA_SEARCH_VS3 = True

        Catch ex As Exception

        Finally
            Starting.close()
        End Try

    End Function

    Private Function DATA_SEARCH_VS3_ORDER() As Boolean
        DATA_SEARCH_VS3_ORDER = False
        Dim Starting = New DevExpress.Utils.WaitDialogForm("Loading data...", "PSM")

        Try

            DS1 = PrcDS("USP_ISUD0101U_SEARCH_VS3_ORDER", cn, txt_OrderNo.Data)
            SPR_PRO_NEW(VS3, DS1, "USP_ISUD0101U_SEARCH_VS3_ORDER", "VS3")

            DATA_SEARCH_VS3_ORDER = True

        Catch ex As Exception

        Finally
            Starting.close()
        End Try



    End Function
#End Region

#Region "Function"

    Private Function Data_Check_SizeRange() As Boolean
        Data_Check_SizeRange = False
        Dim i As Integer

        Try

            For i = 0 To VS3.ActiveSheet.RowCount - 1
                If getData(VS3, getColumIndex(VS3, "cdSeason"), i) = "" Then MsgBoxP("Season" & " at row " & (i + 1).ToString) : Exit Function
                If getData(VS3, getColumIndex(VS3, "SizeRange"), i) = "" Then MsgBoxP("SizeRange" & " at row " & (i + 1).ToString) : Exit Function
            Next

            Data_Check_SizeRange = True
skip_1:
        Catch ex As Exception
        End Try
    End Function


    Private Function Data_Check_ShoesCode() As Boolean
        Data_Check_ShoesCode = False
        Dim i As Integer

        Try

            For i = 0 To VS3.ActiveSheet.RowCount - 1
                If getData(VS3, getColumIndex(VS3, "Article"), i) = "" Then MsgBoxP("Article" & " at row " & (i + 1).ToString) : Exit Function
                If getData(VS3, getColumIndex(VS3, "ColorName"), i) = "" Then MsgBoxP("ColorName" & " at row " & (i + 1).ToString) : Exit Function
                If getData(VS3, getColumIndex(VS3, "ColorCode"), i) = "" Then MsgBoxP("Color Code" & " at row " & (i + 1).ToString) : Exit Function
            Next

            Data_Check_ShoesCode = True
skip_1:
        Catch ex As Exception
            Call MsgBoxP("61", WordConv("Data_Check_ShoesCode"))
        End Try
    End Function

    Private Function Data_Check() As Boolean
        Data_Check = False
        Dim i As Integer

        Try

            For i = 0 To VS3.ActiveSheet.RowCount - 1
                If getData(VS3, getColumIndex(VS3, "cdSeason"), i) = "" Then MsgBoxP("Season" & " at row " & (i + 1).ToString) : Exit Function
                If getData(VS3, getColumIndex(VS3, "ShoesCode"), i) = "" Then MsgBoxP("ShoesCode" & " at row " & (i + 1).ToString) : Exit Function
                If getData(VS3, getColumIndex(VS3, "SizeRange"), i) = "" Then MsgBoxP("SizeRange" & " at row " & (i + 1).ToString) : Exit Function
            Next

            Data_Check = True
skip_1:
        Catch ex As Exception

        End Try
    End Function

    Private Function Data_Info(CheckUse As Boolean) As Boolean
        Data_Info = False
        Dim i As Integer

        Try
            If CheckUse = False Then

                For i = 0 To VS3.ActiveSheet.RowCount - 1


                    If getData(VS3, getColumIndex(VS3, "cdSeason"), i) = "" _
                    Or getData(VS3, getColumIndex(VS3, "ShoesCode"), i) = "" _
                    Or getData(VS3, getColumIndex(VS3, "SizeRange"), i) = "" Then
                        SPR_BACKCOLORCELL(VS3, Color.Red, 0, i)

                    End If
                Next
            Else

                For i = 0 To VS3.ActiveSheet.RowCount - 1
                    VS3.ActiveSheet.Rows(i).Visible = False

                    If getData(VS3, getColumIndex(VS3, "cdSeason"), i) = "" _
                    Or getData(VS3, getColumIndex(VS3, "ShoesCode"), i) = "" _
                    Or getData(VS3, getColumIndex(VS3, "SizeRange"), i) = "" Then
                        SPR_BACKCOLORCELL(VS3, Color.Red, 0, i)
                        VS3.ActiveSheet.Rows(i).Visible = True
                    End If
                Next

            End If

            Data_Info = True
skip_1:
        Catch ex As Exception

        End Try
    End Function


    Private Sub DATA_MOVE_DEFAULT()
        Try
            W1311.seSeason = ListCode("Season")
            W1311.seStateOfficial = ListCode("StateOfficial")
            W1311.seOrderGroup = ListCode("OrderGroup")
            W1311.seOrderKind = ListCode("OrderKind")
            W1311.seOrderType = ListCode("OrderType")
            W1311.seOrderKind = ListCode("OrderKind")
            W1311.seOrderWork = ListCode("OrderWork")
            W1311.seStateSample = ListCode("StateSample")
            W1311.seDepartment = ListCode("Department")
            W1311.seBrand = ListCode("Brand")
            W1311.seDeliveryTerm = ListCode("DeliveryTerm")
            W1311.sePaymentTerm = ListCode("PaymentTerm")
            W1311.sePaymentCondition = ListCode("PaymentCondition")
            W1311.sePaymentTime = ListCode("PaymentTime")
            W1311.sePaymentDay = ListCode("PaymentDay")
            W1311.seSite = ListCode("Site")
            W1311.seShippingTerm = ListCode("ShippingTerm")
            W1311.seMarketType = ListCode("MarketType")

            W1312.seSpecStatus = ListCode("SpecStatus")
            W1312.seUnitMaterial = ListCode("UnitMaterial")
            W1312.seUnitPacking = ListCode("UnitPacking")
            W1312.seUnitPrice = ListCode("UnitPrice")
            W1312.sePackingCode = ListCode("PackingCode")
            W1312.seSite = ListCode("Site")
        Catch ex As Exception
            Call Error_Message("62", "DATA_MOVE_DEFAULT")
        End Try

    End Sub
    Private Sub DATA_UPDATE()
        Try
            Call KEY_COUNT_7106()
            If K1311_MOVE(Me, W1311, 1, L1311.OrderNo) = False Then

                Call DATA_MOVE_DEFAULT()
                W1311.OrderNo = L1311.OrderNo
                W1311.cdOrderGroup = "002"
                W1311.DateOrder = Pub.DAT
                W1311.DateInsert = Pub.DAT
                W1311.InchargePPC = Pub.SAW
                W1311.cdSite = Pub.SITE
                W1311.cdDepartment = Pub.DEPARTMENT
                W1311.StatusOrder = "1"
                W1311.CustPoNo = txt_CustPoNo.Data

                If WRITE_PFK1311(W1311) = True Then
                    Call DATA_MOVE_WRITE()

                    isudCHK = True : WRITE_CHK = "*" : wJOB = 3
                    Exit Sub
                End If
            End If

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_UPDATE")
        End Try
    End Sub

    Private Sub KEY_COUNT_PFK1312()
        Try
            SQL = "SELECT MAX(CAST(K1312_OrderNoSeq AS DECIMAL)) AS MAX_MCODE FROM PFK1312 "
            SQL = SQL & " WHERE K1312_OrderNo = '" & txt_OrderNo.Data & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                W1312.OrderNoSeq = "001"
            Else
                W1312.OrderNoSeq = CIntp(rd!MAX_MCODE + 1).ToString("000")
            End If

            rd.Close()

            L1312.OrderNoSeq = W1312.OrderNoSeq

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT_PFK1312")
        End Try
    End Sub
    Private Function DATA_MOVE_WRITE() As Boolean
        DATA_MOVE_WRITE = False
        Try
            Dim i As Integer
            Dim j As Integer
            Dim colstart As Integer = getColumIndex(VS3, "SizeQty01")

            j = 0
            For i = 0 To VS3.ActiveSheet.RowCount - 1

                j = j + 1

                'If READ_PFK1312_SEASON(txt_cdSeason.Code, getData(VS3, getColumIndex(VS3, "SlNo"), i)) Then GoTo skip

                If K1312_MOVE(VS3, i, W1312, txt_OrderNo.Data, "000") = False Then
                    W1312.OrderNo = L1311.OrderNo

                    Call KEY_COUNT_PFK1312()

                    DATA_MOVE_DEFAULT()

                    W1312.SizeRange = getData(VS3, getColumIndex(VS3, "SizeRange"), i)
                    W1312.OrderDetailStatus = "1"
                    W1312.DateApproval = Pub.DAT

                    W1312.DateOrder = Pub.DAT
                    W1312.DateInsert = Pub.DAT
                    W1312.InchargeInsert = Pub.SAW


                    If WRITE_PFK1312(W1312) = True Then
                        W1313.OrderNo = W1312.OrderNo
                        W1313.OrderNoSeq = W1312.OrderNoSeq

                        W1313.SizeQty01 = CDblp(getData(VS3, colstart, i))
                        W1313.SizeQty02 = CDblp(getData(VS3, colstart + 1, i))
                        W1313.SizeQty03 = CDblp(getData(VS3, colstart + 2, i))
                        W1313.SizeQty04 = CDblp(getData(VS3, colstart + 3, i))
                        W1313.SizeQty05 = CDblp(getData(VS3, colstart + 4, i))
                        W1313.SizeQty06 = CDblp(getData(VS3, colstart + 5, i))
                        W1313.SizeQty07 = CDblp(getData(VS3, colstart + 6, i))
                        W1313.SizeQty08 = CDblp(getData(VS3, colstart + 7, i))
                        W1313.SizeQty09 = CDblp(getData(VS3, colstart + 8, i))
                        W1313.SizeQty10 = CDblp(getData(VS3, colstart + 9, i))
                        W1313.SizeQty11 = CDblp(getData(VS3, colstart + 10, i))
                        W1313.SizeQty12 = CDblp(getData(VS3, colstart + 11, i))
                        W1313.SizeQty13 = CDblp(getData(VS3, colstart + 12, i))
                        W1313.SizeQty14 = CDblp(getData(VS3, colstart + 13, i))
                        W1313.SizeQty15 = CDblp(getData(VS3, colstart + 14, i))
                        W1313.SizeQty16 = CDblp(getData(VS3, colstart + 15, i))
                        W1313.SizeQty17 = CDblp(getData(VS3, colstart + 16, i))
                        W1313.SizeQty18 = CDblp(getData(VS3, colstart + 17, i))
                        W1313.SizeQty19 = CDblp(getData(VS3, colstart + 18, i))
                        W1313.SizeQty20 = CDblp(getData(VS3, colstart + 19, i))
                        W1313.SizeQty21 = CDblp(getData(VS3, colstart + 20, i))
                        W1313.SizeQty22 = CDblp(getData(VS3, colstart + 21, i))
                        W1313.SizeQty23 = CDblp(getData(VS3, colstart + 22, i))
                        W1313.SizeQty24 = CDblp(getData(VS3, colstart + 23, i))
                        W1313.SizeQty25 = CDblp(getData(VS3, colstart + 24, i))
                        W1313.SizeQty26 = CDblp(getData(VS3, colstart + 25, i))
                        W1313.SizeQty27 = CDblp(getData(VS3, colstart + 26, i))
                        W1313.SizeQty28 = CDblp(getData(VS3, colstart + 27, i))
                        W1313.SizeQty29 = CDblp(getData(VS3, colstart + 28, i))
                        W1313.SizeQty30 = CDblp(getData(VS3, colstart + 29, i))

                        Call WRITE_PFK1313(W1313)
                        isudCHK = True

                    End If

                    isudCHK = True
                End If
skip:
            Next

            DATA_MOVE_WRITE = True

        Catch ex As Exception
            MsgBoxP("DATA_MOVE_WRITE")
        End Try

    End Function

#End Region

#Region "Event"
    Private Sub ptc_Main_DoubleClick(sender As Object, e As EventArgs) Handles ptc_Main.DoubleClick
        If formA = False Then ptc_Main.SelectedIndex = 0

        Select Case ptc_Main.SelectedIndex
            Case 0

            Case 1
                Call DATA_SEARCH_VS2()
            Case 2
                Call DATA_SEARCH_VS3()
        End Select
    End Sub
    Private Sub ptc_Main_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ptc_Main.SelectedIndexChanged
        If formA = False Then ptc_Main.SelectedIndex = 0

    End Sub

    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        If Data_Check() = False Then Exit Sub
        Try
            Call DATA_UPDATE()

            Call PrcExeNoError("EXP_CLOSSING_ISUD0101U", cn, txt_OrderNo.Data)

            Call DATA_SEARCH_VS3_ORDER()

            cmd_OK.Visible = False

        Catch ex As Exception

        End Try

    End Sub

    Private Sub cmd_CANCEL_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        If WRITE_CHK = "*" Then
            isudCHK = True
        Else
            isudCHK = False
        End If

        Me.Dispose()
    End Sub

    Private Sub Vs3_CellClick(sender As Object, e As CellClickEventArgs) Handles VS3.CellClick
        Vs3.ActiveSheet.ActiveRowIndex = e.Row
        Vs3.ActiveSheet.ActiveColumnIndex = e.Column

    End Sub


    Private Sub cmd_UploadOrder_Click(sender As Object, e As EventArgs) Handles cmd_UploadOrder.Click
        Try

            Using OpenFileDialog As OpenFileDialog = Me.GetOpenFileDialog()

                'Open the File Dialog to select the file
                If (OpenFileDialog.ShowDialog(Me) = DialogResult.OK) Then

                    Dim File As String
                    Dim DestTemp As String = OpenFileDialog.FileName + ".temp"

                    IO.File.Copy(OpenFileDialog.FileName, DestTemp)

                    Vs1.OpenExcel(DestTemp)

                    IO.File.Delete(DestTemp)

                    ChkUpload = True
                Else 'Cancel

                    Exit Sub

                End If

            End Using

        Catch ex As Exception

        End Try
    End Sub

    Friend Shared Function GetExcelFile(ByVal strFileName As String, ByVal strPath As String) As DataTable

        Try

            Dim dt As New DataTable

            Dim ConStr As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & strPath & ";Extended Properties=""Text;HDR=Yes;FMT=Delimited\"""
            Dim conn As New OleDb.OleDbConnection(ConStr)
            Dim da As New OleDb.OleDbDataAdapter("Select * from " & strFileName, conn)
            da.Fill(dt)

            Return dt

        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Private Function GetOpenFileDialog() As OpenFileDialog

        Dim openFileDialog As New OpenFileDialog

        openFileDialog.CheckFileExists = True
        openFileDialog.Multiselect = False
        openFileDialog.AddExtension = True
        openFileDialog.ValidateNames = True
        openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)

        Return openFileDialog


    End Function
    Private Sub cmd_Rule_Click(sender As Object, e As EventArgs) Handles cmd_Rule.Click
        Dim Value() As String

        Value = txt_MappingNo.Text.Split(";")


        If txt_MappingNo.Text <> "" Then
            If ISUD9001A.Link_ISUD9001A(3, Value(0), "") Then

            End If
        Else
            If ISUD9001A.Link_ISUD9001A(1, txt_CustomerCode.Code, "") Then

            End If

        End If


        Call DATA_SEARCH01()

    End Sub

    Private Sub cmd_Link7235_btnTitleClick(sender As Object, e As EventArgs)
        If ISUD7235A.Link_ISUD7235A("3", "PFP71080") = False Then Exit Sub
    End Sub

    Private Sub VS3_KeyDown(sender As Object, e As KeyEventArgs) Handles VS3.KeyDown
        Dim xCOL As Long
        Dim xROW As Long
        xCOL = VS3.ActiveSheet.ActiveColumnIndex
        xROW = VS3.ActiveSheet.ActiveRowIndex

        Select Case e.KeyCode
            Case Keys.Delete

                Call Select_Message("3", WordConv("PROCESSING"), 2)

                If Msg_Result = vbNo Then Exit Sub

                SPR_DEL(VS3, xCOL, xROW)
                VS3.ActiveSheet.ActiveColumnIndex = xCOL
                VS3.ActiveSheet.ActiveRowIndex = xROW
                VS3.Focus()

            Case Keys.Enter
                Select Case xCOL

                End Select
        End Select
    End Sub

    Private Sub txt_CustomerCode_txtTextChange(sender As Object, e As EventArgs) Handles txt_CustomerCode.txtTextChange
        If formA = False Then Exit Sub

        If CIntp(txt_CustomerCode.Code) = 0 Then Exit Sub
        If READ_PFK7101_CODE(txt_CustomerCode.Code) = False Then Exit Sub

        Call DATA_SEARCH01()
        Call DATA_SEARCH_VS2()
    End Sub

    Private Sub txt_CustomerCode_txtTextKeyDown(sender As Object, e As KeyPressEventArgs) Handles txt_CustomerCode.txtTextKeyPress
        If formA = False Then Exit Sub

        If e.KeyChar = ChrW(Keys.Enter) Then

            Call DATA_SEARCH01()
            Call DATA_SEARCH_VS2()
        End If
    End Sub


    Private Sub Generate_7106_ALL_CUSTOMER()
        Try
            Dim i As Integer

            For i = 0 To VS3.ActiveSheet.RowCount - 1
                D7106_CLEAR()
                W7106 = D7106

                W7106.Line = getData(VS3, getColumIndex(VS3, "Line"), i)
                W7106.Article = getData(VS3, getColumIndex(VS3, "Article"), i)
                W7106.ColorCode = getData(VS3, getColumIndex(VS3, "ColorCode"), i)
                W7106.ColorName = getData(VS3, getColumIndex(VS3, "ColorName"), i)
                W7106.MCODE = getData(VS3, getColumIndex(VS3, "MCODE"), i)
                W7106.SizeRange = getData(VS3, getColumIndex(VS3, "SizeRange"), i)
                W7106.Style = getData(VS3, getColumIndex(VS3, "Style"), i)
                W7106.ProductCode = getData(VS3, getColumIndex(VS3, "ProductCode"), i)
                W7106.CustSpecNo = getData(VS3, getColumIndex(VS3, "CustSpecNo"), i)
                W7106.cdSpecState = "006"
                W7106.cdSeason = txt_cdSeason.Code
                W7106.Customercode = txt_CustomerCode.Code

                If READ_PFK7106_1_ALL_CUSTOMER(W7106.cdSeason, W7106.Customercode, W7106.cdSpecState, W7106.Line, W7106.Article, W7106.ColorName, W7106.ColorCode, W7106.SizeRange) Then
                    GoTo next1
                Else
                    Call D7106_CLEAR()

                    W7106 = D7106

                    Call KEY_COUNT_7106()

                    W7106.Customercode = txt_CustomerCode.Code
                    W7106.cdSeason = txt_cdSeason.Code
                    W7106.cdSeason = "000"
                    W7106.SizeRange = "000001"
                    W7106.SpeciticSize = "1"
                    W7106.cdSpecState = "006"

                    W7106.seGender = ListCode("Gender")
                    W7106.seSeason = ListCode("Season")
                    W7106.seSpecState = ListCode("SpecState")
                    W7106.seSite = ListCode("Site")
                    W7106.seProductType = ListCode("ProductType")
                    W7106.seProductSize = ListCode("ProductSize")

                    If READ_PFK7171(ListCode("ProductSize"), getData(VS3, getColumIndex(VS3, "cdProductSize"), i)) Then
                        W7106.cdProductSize = D7171.BasicCode
                    End If

                    If READ_PFK7171(ListCode("ProductType"), getData(VS3, getColumIndex(VS3, "cdProductType"), i)) Then
                        W7106.cdProductType = D7171.BasicCode
                    End If

                    W7106.Line = getData(VS3, getColumIndex(VS3, "Line"), i)
                    W7106.Article = getData(VS3, getColumIndex(VS3, "Article"), i)
                    W7106.Style = getData(VS3, getColumIndex(VS3, "Style"), i)
                    W7106.ProductCode = getData(VS3, getColumIndex(VS3, "ProductCode"), i)
                    W7106.CustSpecNo = getData(VS3, getColumIndex(VS3, "CustSpecNo"), i)
                    W7106.ColorCode = getData(VS3, getColumIndex(VS3, "ColorCode"), i)
                    W7106.ColorName = getData(VS3, getColumIndex(VS3, "ColorName"), i)

                    W7106.MCODE = getData(VS3, getColumIndex(VS3, "MCODE"), i)
                    W7106.MCODEName = getData(VS3, getColumIndex(VS3, "MCODEName"), i)

                    W7106.cdSpecState = "006"
                    W7106.SizeRange = getData(VS3, getColumIndex(VS3, "SizeRange"), i)
                    W7106.PriceUSD = getData(VS3, getColumIndex(VS3, "Price"), i)
                    W7106.Remark = "AUTO INSERT PFK7106 BY UPLOAD ORDER & " & System_Date_time()
                    W7106.InchargeDesigner = Pub.SAW
                    W7106.CheckUse = "1"

                    W7106.DateInsert = Pub.DAT
                    W7106.InchargeInsert = Pub.SAW

                    If READ_PFK7106_SHOESPARENT(W7106.cdSeason, W7106.cdSpecState, W7106.Article) = False Then
                        W7106.CheckParent = "1"
                        W7106.ShoesParent = W7106.ShoesCode
                    Else
                        If W7106.CheckParent <> "1" Then
                            W7106.ShoesParent = D7106.ShoesCode
                            W7106.CheckParent = "2"
                        End If
                    End If

                    Call WRITE_PFK7106(W7106)

                End If
next1:
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmd_GenerateShoesCode_Click(sender As Object, e As EventArgs) Handles cmd_GenerateShoesCode.Click

        Dim StrMsg As String

        StrMsg = MsgBox("Quan trọng ! Vui lòng kiểm tra kỹ khi tạo ! Hệ thống tự động tạo mã sản phẩm ! Important! Please check carefully !", vbYesNo)

        If StrMsg <> vbYes Then Exit Sub

        If Data_Check_SizeRange() = False Then Exit Sub

        Dim Starting = New DevExpress.Utils.WaitDialogForm("Loading data...", "PSM")
        Try

            Call Generate_7106_ALL_CUSTOMER()
NEXT1:
        Catch ex As Exception

        Finally
            Starting.close()
        End Try

        Call DATA_SEARCH_VS3()
    End Sub

    Private Sub KEY_COUNT_7106()
        Dim SQL As String
        Dim rd As SqlClient.SqlDataReader


        SQL = "SELECT MAX(CAST(K7106_ShoesCode AS DECIMAL)) AS MAX_CODE FROM PFK7106 "

        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_CODE) Then
            W7106.ShoesCode = "000001"
        Else
            W7106.ShoesCode = Format(CInt(rd!MAX_CODE + 1), "000000")
        End If

    End Sub

    Private Sub KEY_COUNT_1311()

        Dim YRNO As Integer
        YRNO = Mid(System_Date_8(), 3, 4)

        Try
            SQL = "SELECT MAX(CAST(SUBSTRING(K1311_OrderNo,7,3) AS DECIMAL)) AS MAX_MCODE FROM PFK1311 "
            SQL = SQL & " WHERE SUBSTRING(K1311_OrderNo,3,4) = '" & YRNO.ToString & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                W1311.OrderNo = "SO" & YRNO & "001"
            Else
                W1311.OrderNo = "SO" & YRNO & FormatP(CInt(rd!MAX_MCODE + 1), "000")
            End If

            rd.Close()

            txt_OrderNo.Data = W1311.OrderNo
            L1311.OrderNo = W1311.OrderNo

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub

    Private Sub chk_Error_CheckedChanged(sender As Object, e As EventArgs) Handles chk_ErrorOnly.CheckedChanged
        If chk_ErrorOnly.Checked = True Then
            Call Data_Info(True)
        End If
    End Sub

#End Region

    Private Sub cmd_File_Click(sender As Object, e As EventArgs) Handles cmd_File.Click
        ISUD7555A.Link_ISUD7555A_MANUAL(3, Me.Name)
    End Sub
End Class