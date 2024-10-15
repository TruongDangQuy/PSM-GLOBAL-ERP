Imports System.Net.Mail
Imports System.Text
Imports System.IO.Ports

Public Class ISUD4901A

#Region "Variable"
    Private wJOB As Integer

    Private W0102 As New T0102_AREA

    Private W4901 As New T4901_AREA
    Private L4901 As New T4901_AREA

    Private W4902 As New T4902_AREA
    Private L4902 As New T4902_AREA

    Private W4903 As New T4903_AREA
    Private L4903 As New T4903_AREA

    Private WRITE_CHK As String
    Private ImportTax As Decimal
    Private EnvironmentTax As Decimal
    Private VatTax As Decimal
    Private formA As Boolean
    Private CHK(0 To 5) As String

    Private sizeInfo As Boolean = False
    Private specInfo As Boolean = False
    Private schedulaInfo As Boolean = False
    Private remarkInfo As Boolean = False

    Private ShippingWorkOrderSeq As String = ""

    Private Schedula As String = ""

#End Region

#Region "Link"
    Public Function Link_ISUD4901A(job As Integer, ShippingWorkOrder As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        D4901.ShippingWorkOrder = ShippingWorkOrder

        wJOB = job : L4901 = D4901

        Link_ISUD4901A = False
        Try

            Select Case job
                Case 1
                Case Else
                   

            End Select


            formA = False
            Me.ShowDialog()
            Application.DoEvents()
            Cursor = Cursors.Default

            Link_ISUD4901A = isudCHK

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("YARN PROCESSING"))
        End Try

    End Function
    Public Function Link_ISUD4901A_AUTO(job As Integer, OrderNo As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        D4902.OrderNo = OrderNo

        wJOB = job : L4901 = D4901 : L4902 = D4902

        Link_ISUD4901A_AUTO = False
        Try

            Select Case job
                Case 1
                    DS1 = READ_PFK1311(OrderNo, cn)

                    If GetDsRc(DS1) = 0 Then
                        Exit Function
                        isudCHK = False
                    End If

                    READER_MOVE(Me, DS1)

                Case Else

            End Select


            formA = False
            Me.ShowDialog()
            Application.DoEvents()
            Cursor = Cursors.Default

            Link_ISUD4901A_AUTO = isudCHK

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("YARN PROCESSING"))
        End Try

    End Function

#End Region

#Region "Form"
    Private Sub Form_Activate(sender As Object, e As EventArgs) Handles Me.Load
        If formA = True Then Exit Sub

        WRITE_CHK = ""
        'Me.Form_Initial()
        Me.Form_KeyDown()

        Call DATA_INIT()
        Call FORM_INIT()

        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

        Select Case wJOB
            Case 1
                Me.Text = Me.Text & " - INSERT"
                cmd_DEL.Visible = False

                If CHK(1) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call KEY_COUNT()
                Call DATA_SEARCH_vS10()
                Call DATA_SEARCH_vS20()
                Setfocus(txt_CustomerCode)

            Case 2
                Me.Text = Me.Text & " - SEARCH"
                cmd_DEL.Visible = False
                cmd_OK.Visible = False

                If CHK(2) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCH01()
                Call DATA_SEARCH_vS10()
                Call DATA_SEARCH_vS20()

            Case 3
                Me.Text = Me.Text & " - UPDATE"
                txt_ShippingWorkOrder.Enabled = False

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
                        cmd_DEL.Visible = False
                        Call MsgBoxP("Only Search !") : cmd_OK.Visible = False
                    End If
                End If

                Call DATA_SEARCH01()
                Call DATA_SEARCH_vS10()
                Call DATA_SEARCH_vS20()

            Case 4
                Me.Text = Me.Text & " - DELETE"
                cmd_OK.Visible = False


                If CHK(4) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCH01()
                Call DATA_SEARCH_vS10()
                Call DATA_SEARCH_vS20()

        End Select

        formA = True
    End Sub

    Private Sub DATA_INIT()
        Try
            txt_ShippingWorkOrder.Enabled = False
            Call D4901_CLEAR()
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INIT")
        End Try
    End Sub

    Private Sub FORM_INIT()
        vS20.InsChk = False
    End Sub

#End Region

#Region "Search"

    Private Function DATA_SEARCH01() As Boolean
        DATA_SEARCH01 = False
        Try
            DS1 = READ_PFK4901(L4901.ShippingWorkOrder, cn)

            If GetDsRc(DS1) = 0 Then
                Exit Function
                isudCHK = False
            End If

            READER_MOVE(Me, DS1)

            DATA_SEARCH01 = True

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_SEARCH01")
        End Try

    End Function

    Private Function DATA_SEARCH02(SpecNo As String, SpecNoSeq As String) As Boolean

        DATA_SEARCH02 = False
        Try

            DS1 = PrcDS("USP_ISUD4901A_SEARCH_HEAD_SPECINFO", cn, SpecNo, SpecNoSeq)

            If GetDsRc(DS1) = 0 Then
                DS2 = READ_PFK0102(SpecNo, SpecNoSeq, cn)

                If GetDsRc(DS2) > 0 Then
                    Call READER_MOVE(Me, DS2)
                End If

                Exit Function
                isudCHK = False
            End If

            STORE_MOVE(Me, DS1)

            DATA_SEARCH02 = True

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_SEARCH02")
        End Try

    End Function

    Private Function DATA_SEARCH03(ShippingWorkOrder As String) As Boolean

        DATA_SEARCH03 = False

    End Function

    Private Function DATA_SEARCH_vS10() As Boolean
        DATA_SEARCH_vS10 = False
        Try

            DS1 = PrcDS("USP_ISUD4901A_SEARCH_VS10", cn, L4901.ShippingWorkOrder)

            If GetDsRc(DS1) = 0 Then
                DS2 = PrcDS("USP_ISUD4901A_SEARCH_VS10_INSERT_F1", cn, L4902.OrderNo)
                SPR_PRO_NEW(vS10, DS2, "USP_ISUD4901A_SEARCH_VS10", "VS10")
                SPR_INSERT(vS10)
                vS10.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS10, DS1, "USP_ISUD4901A_SEARCH_VS10", "Vs10")
            Call DATA_SEARCH_CHECK_SPECNO()

            DATA_SEARCH_vS10 = True

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_SEARCH_vS10")
        End Try

    End Function

    Private Function DATA_SEARCH_vS20() As Boolean
        DATA_SEARCH_vS20 = False
        Dim DSNEW As New DataSet

        Try
            DATA_SEARCH_vS20 = False
            Try
                If chk_PriceCheck.Checked = False Then
                    DS1 = PrcDS("USP_ISUD4901A_SEARCH_vS20", cn, L4901.ShippingWorkOrder)

                    If GetDsRc(DS1) = 0 Then
                        DS2 = PrcDS("USP_ISUD4901A_SEARCH_vS20_INSERT_F1", cn, L4902.OrderNo)
                        SPR_SET(vS20, , , , OperationMode.Normal)
                        SPR_PRO(vS20, DS2, "USP_ISUD4901A_SEARCH_vS20", "vS10")
                        SPR_INSERT(vS20)
                        vS20.Enabled = True
                        Exit Function
                    End If

                    SPR_PRO_NEW(vS20, DS1, "USP_ISUD4901A_SEARCH_vS20", "vS20")
                    Call VsSizeRange(vS20, "USP_ISUD4901A_SEARCH_VS20_HEAD", L4901.ShippingWorkOrder)

                Else
                    DS1 = PrcDS("USP_ISUD4901A_SEARCH_vS20_PRICE", cn, L4901.ShippingWorkOrder)
                    SPR_PRO_NEW(vS20, DS1, "USP_ISUD4901A_SEARCH_vS20_PRICE", "vS20")
                    Call VsSizeRange(vS20, "USP_ISUD4901A_SEARCH_VS20_HEAD", L4901.ShippingWorkOrder)
                End If

                DATA_SEARCH_vS20 = True

            Catch ex As Exception
                Call MsgBoxP("35", "DATA_SEARCH_vS20")
            End Try
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_SEARCH_vS20")
        End Try

    End Function

    Private Sub DATA_SEARCH_CHECK_SPECNO()
        Try
            Dim i As Integer
            For i = 0 To vS10.ActiveSheet.RowCount - 1

                If READ_PFK4902(getData(vS10, getColumIndex(vS10, "KEY_ShippingWorkOrder"), i), getData(vS10, getColumIndex(vS10, "KEY_ShippingWorkOrderSeq"), i)) Then
                    If D4902.ShippingWorkOrderStatus <> "1" Then SPR_LOCK(vS10, i) : SPR_BACKCOLOR(vS10, cSprLockBackColor, i)
                End If
            Next

        Catch ex As Exception

        End Try
      

    End Sub


#End Region

#Region "Function"

    Private Sub DATA_MOVE_DEFAULT()
        Try
            'PFK4901

            W4901.seSeason = ListCode("Season")
            W4901.seOrderGroup = ListCode("OrderGroup")
            W4901.seStateOfficial = ListCode("StateOfficial")
            W4901.seOrderGroup = ListCode("OrderGroup")
            W4901.seOrderKind = ListCode("OrderKind")
            W4901.seOrderType = ListCode("OrderType")
            W4901.seOrderKind = ListCode("OrderKind")
            W4901.seOrderWork = ListCode("OrderWork")
            W4901.seStateSample = ListCode("StateSample")
            W4901.seDepartment = ListCode("Department")
            W4901.seBrand = ListCode("Brand")
            W4901.sePaymentTerm = ListCode("PaymentTerm")
            W4901.seDeliveryTerm = ListCode("DeliveryTerm")
            W4901.seShippingTerm = ListCode("ShippingTerm")
            W4901.seMarketType = ListCode("MarketType")

            W4902.seUnitMaterial = ListCode("UnitMaterial")


        Catch ex As Exception
            Call Error_Message("62", "DATA_MOVE_DEFAULT")
        End Try

    End Sub

    Private Function DATA_MOVE_WRITE01() As Boolean
        DATA_MOVE_WRITE01 = False
        Try

            If READ_PFK4901(txt_ShippingWorkOrder.Data) = True Then

                W4901.CustomerCode = txt_CustomerCode.Code
                W4901.CustPoNo = txt_CustPoNo.Data

                W4901.cdSeason = txt_cdSeason.Code
                W4901.cdSeason = txt_cdOrderGroup.Code
                W4901.cdOrderKind = txt_cdOrderKind.Code
                W4901.cdOrderType = txt_cdOrderType.Code
                W4901.cdOrderWork = txt_cdOrderWork.Code
                W4901.InchargeSales = txt_InchargeSales.Code
                W4901.cdDepartment = txt_cdDepartment.Code
                W4901.cdBrand = txt_cdBrand.Code
                W4901.InchargePPC = txt_InchargePPC.Code
                W4901.cdPaymentTerm = txt_cdPaymentTerm.Code
                W4901.cdDeliveryTerm = txt_cdDeliveryTerm.Code
                W4901.cdShippingTerm = txt_cdShippingTerm.Code
                W4901.cdMarketType = txt_cdMarketType.Code

                DATA_MOVE_DEFAULT()

                Call REWRITE_PFK4901(W4901)
                isudCHK = True
            Else
                W4901.ShippingWorkOrder = L4901.ShippingWorkOrder

                W4901.CustomerCode = txt_CustomerCode.Code
                W4901.CustPoNo = txt_CustPoNo.Data

                W4901.cdSeason = txt_cdSeason.Code
                W4901.cdSeason = txt_cdOrderGroup.Code
                W4901.cdOrderKind = txt_cdOrderKind.Code
                W4901.cdOrderType = txt_cdOrderType.Code
                W4901.cdOrderWork = txt_cdOrderWork.Code
                W4901.InchargeSales = txt_InchargeSales.Code
                W4901.cdDepartment = txt_cdDepartment.Code
                W4901.cdBrand = txt_cdBrand.Code
                W4901.InchargePPC = txt_InchargePPC.Code
                W4901.cdPaymentTerm = txt_cdPaymentTerm.Code
                W4901.cdDeliveryTerm = txt_cdDeliveryTerm.Code
                W4901.cdShippingTerm = txt_cdShippingTerm.Code
                W4901.cdMarketType = txt_cdMarketType.Code

                DATA_MOVE_DEFAULT()

                Call WRITE_PFK4901(W4901)

                isudCHK = True
            End If

            DATA_MOVE_WRITE01 = True
        Catch ex As Exception
            MsgBoxP("DATA_MOVE_WRITE01")
        End Try
    End Function

    Private Function DATA_MOVE_WRITE02() As Boolean
        DATA_MOVE_WRITE02 = False
        Try
            Dim i As Integer
            Dim j As Integer

            j = 0
            For i = 0 To vS10.ActiveSheet.RowCount - 1
                j = j + 1

                If K4902_MOVE(vS10, i, W4902, txt_ShippingWorkOrder.Data, getData(vS10, getColumIndex(vS10, "KEY_ShippingWorkOrderSeq"), i)) = True Then

                    DATA_MOVE_DEFAULT()

                    Call REWRITE_PFK4902(W4902)

                    isudCHK = True
                Else
                    W4902.ShippingWorkOrder = L4901.ShippingWorkOrder

                    Call KEY_COUNT_PFK4902()

                    DATA_MOVE_DEFAULT()

                    W4902.ShippingWorkOrderStatus = "1"
                    W4902.DateShipping = Pub.DAT
                    W4902.DateInsert = Pub.DAT
                    W4902.InchargeInsert = Pub.SAW

                    Call WRITE_PFK4902(W4902)

                    isudCHK = True
                End If
skip:
            Next

            DATA_MOVE_WRITE02 = True

        Catch ex As Exception
            MsgBoxP("DATA_MOVE_WRITE02")
        End Try

    End Function

    Private Function DATA_MOVE_WRITE02_ROW(i As Integer) As Boolean
        DATA_MOVE_WRITE02_ROW = False
        Try

            Dim j As Integer

            j = 0

            If Trim(getData(vS10, getColumIndex(vS10, "MaterialCode"), i)) = "" Then Exit Function

            j = j + 1

            If K4902_MOVE(vS10, i, W4902, txt_ShippingWorkOrder.Data, getData(vS10, getColumIndex(vS10, "KEY_ShippingWorkOrderSeq"), i)) = True Then

                W4902.PKO = getData(vS10, getColumIndex(vS10, "PKO"), i)
                W4902.cdUnitMaterial = getData(vS10, getColumIndex(vS10, "cdUnitMaterial"), i)
                W4902.cdUnitPacking = getData(vS10, getColumIndex(vS10, "cdUnitPacking"), i)

                W4902.cdUnitPacking = getData(vS10, getColumIndex(vS10, "SpecNo"), i)
                W4902.cdUnitPacking = getData(vS10, getColumIndex(vS10, "SpecNoSeq"), i)

                DATA_MOVE_DEFAULT()

                Call REWRITE_PFK4902(W4902)

                isudCHK = True
            Else
                W4902.ShippingWorkOrder = L4901.ShippingWorkOrder

                Call KEY_COUNT_PFK4902()

                W4902.PKO = getData(vS10, getColumIndex(vS10, "PKO"), i)

                W4902.cdUnitMaterial = getData(vS10, getColumIndex(vS10, "cdUnitMaterial"), i)
                W4902.cdUnitPacking = getData(vS10, getColumIndex(vS10, "cdUnitPacking"), i)

                DATA_MOVE_DEFAULT()
                W4902.ShippingWorkOrderStatus = "1"

                Call WRITE_PFK4902(W4902)

                isudCHK = True
            End If

            DATA_MOVE_WRITE02_ROW = True

        Catch ex As Exception
            MsgBoxP("DATA_MOVE_WRITE02_ROW")
        End Try

    End Function

    Private Function DATA_MOVE_WRITE03() As Boolean
        DATA_MOVE_WRITE03 = False
        Try
            Dim i As Integer
            Dim j As Integer

            Dim colstart As Integer

            j = 0

            'For XXX As Integer = 0 To vS20.ActiveSheet.ColumnCount - 1
            '    If getDataCH(vS20, XXX, 0) <> "" Then
            '        colstart = XXX
            '        Exit For
            '    End If
            'Next

            colstart = getColumIndex(vS20, "SizeQty01")

            If chk_PriceCheck.Checked Then colstart = getColumIndex(vS20, "PriceS01")

            For i = 0 To vS20.ActiveSheet.RowCount - 1
                If txt_ShippingWorkOrder.Data = "" Then GoTo skip

                j = j + 1

                If K4903_MOVE(vS20, i, W4903, txt_ShippingWorkOrder.Data, getData(vS20, getColumIndex(vS20, "KEY_ShippingWorkOrderSeq"), i)) = True Then

                    If chk_PriceCheck.Checked = False Then
                        W4903.SizeQty01 = CDblp(getData(vS20, colstart, i))
                        W4903.SizeQty02 = CDblp(getData(vS20, colstart + 1, i))
                        W4903.SizeQty03 = CDblp(getData(vS20, colstart + 2, i))
                        W4903.SizeQty04 = CDblp(getData(vS20, colstart + 3, i))
                        W4903.SizeQty05 = CDblp(getData(vS20, colstart + 4, i))
                        W4903.SizeQty06 = CDblp(getData(vS20, colstart + 5, i))
                        W4903.SizeQty07 = CDblp(getData(vS20, colstart + 6, i))
                        W4903.SizeQty08 = CDblp(getData(vS20, colstart + 7, i))
                        W4903.SizeQty09 = CDblp(getData(vS20, colstart + 8, i))
                        W4903.SizeQty10 = CDblp(getData(vS20, colstart + 9, i))
                        W4903.SizeQty11 = CDblp(getData(vS20, colstart + 10, i))
                        W4903.SizeQty12 = CDblp(getData(vS20, colstart + 11, i))
                        W4903.SizeQty13 = CDblp(getData(vS20, colstart + 12, i))
                        W4903.SizeQty14 = CDblp(getData(vS20, colstart + 13, i))
                        W4903.SizeQty15 = CDblp(getData(vS20, colstart + 14, i))
                        W4903.SizeQty16 = CDblp(getData(vS20, colstart + 15, i))
                        W4903.SizeQty17 = CDblp(getData(vS20, colstart + 16, i))
                        W4903.SizeQty18 = CDblp(getData(vS20, colstart + 17, i))
                        W4903.SizeQty19 = CDblp(getData(vS20, colstart + 18, i))
                        W4903.SizeQty20 = CDblp(getData(vS20, colstart + 19, i))
                        W4903.SizeQty21 = CDblp(getData(vS20, colstart + 20, i))
                        W4903.SizeQty22 = CDblp(getData(vS20, colstart + 21, i))
                        W4903.SizeQty23 = CDblp(getData(vS20, colstart + 22, i))
                        W4903.SizeQty24 = CDblp(getData(vS20, colstart + 23, i))
                        W4903.SizeQty25 = CDblp(getData(vS20, colstart + 24, i))
                        W4903.SizeQty26 = CDblp(getData(vS20, colstart + 25, i))
                        W4903.SizeQty27 = CDblp(getData(vS20, colstart + 26, i))
                        W4903.SizeQty28 = CDblp(getData(vS20, colstart + 27, i))
                        W4903.SizeQty29 = CDblp(getData(vS20, colstart + 28, i))
                        W4903.SizeQty30 = CDblp(getData(vS20, colstart + 29, i))
                    End If

                    If chk_PriceCheck.Checked = True Then
                        W4903.PriceS01 = CDblp(getData(vS20, colstart, i))
                        W4903.PriceS02 = CDblp(getData(vS20, colstart + 1, i))
                        W4903.PriceS03 = CDblp(getData(vS20, colstart + 2, i))
                        W4903.PriceS04 = CDblp(getData(vS20, colstart + 3, i))
                        W4903.PriceS05 = CDblp(getData(vS20, colstart + 4, i))
                        W4903.PriceS06 = CDblp(getData(vS20, colstart + 5, i))
                        W4903.PriceS07 = CDblp(getData(vS20, colstart + 6, i))
                        W4903.PriceS08 = CDblp(getData(vS20, colstart + 7, i))
                        W4903.PriceS09 = CDblp(getData(vS20, colstart + 8, i))
                        W4903.PriceS10 = CDblp(getData(vS20, colstart + 9, i))
                        W4903.PriceS11 = CDblp(getData(vS20, colstart + 10, i))
                        W4903.PriceS12 = CDblp(getData(vS20, colstart + 11, i))
                        W4903.PriceS13 = CDblp(getData(vS20, colstart + 12, i))
                        W4903.PriceS14 = CDblp(getData(vS20, colstart + 13, i))
                        W4903.PriceS15 = CDblp(getData(vS20, colstart + 14, i))
                        W4903.PriceS16 = CDblp(getData(vS20, colstart + 15, i))
                        W4903.PriceS17 = CDblp(getData(vS20, colstart + 16, i))
                        W4903.PriceS18 = CDblp(getData(vS20, colstart + 17, i))
                        W4903.PriceS19 = CDblp(getData(vS20, colstart + 18, i))
                        W4903.PriceS20 = CDblp(getData(vS20, colstart + 19, i))
                        W4903.PriceS21 = CDblp(getData(vS20, colstart + 20, i))
                        W4903.PriceS22 = CDblp(getData(vS20, colstart + 21, i))
                        W4903.PriceS23 = CDblp(getData(vS20, colstart + 22, i))
                        W4903.PriceS24 = CDblp(getData(vS20, colstart + 23, i))
                        W4903.PriceS25 = CDblp(getData(vS20, colstart + 24, i))
                        W4903.PriceS26 = CDblp(getData(vS20, colstart + 25, i))
                        W4903.PriceS27 = CDblp(getData(vS20, colstart + 26, i))
                        W4903.PriceS28 = CDblp(getData(vS20, colstart + 27, i))
                        W4903.PriceS29 = CDblp(getData(vS20, colstart + 28, i))
                        W4903.PriceS30 = CDblp(getData(vS20, colstart + 29, i))
                    End If

                    If REWRITE_PFK4903(W4903) Then
                        Call PrcExe("USP_PFK4901_UPDATE_SIZEQTY", cn, W4903.ShippingWorkOrder)
                    End If
                    isudCHK = True

                Else

                    W4903.ShippingWorkOrder = L4901.ShippingWorkOrder
                    W4903.ShippingWorkOrderSeq = getData(vS10, getColumIndex(vS10, "KEY_ShippingWorkOrderSeq"), i)

                    If chk_PriceCheck.Checked = False Then
                        W4903.SizeQty01 = CDblp(getData(vS20, colstart, i))
                        W4903.SizeQty02 = CDblp(getData(vS20, colstart + 1, i))
                        W4903.SizeQty03 = CDblp(getData(vS20, colstart + 2, i))
                        W4903.SizeQty04 = CDblp(getData(vS20, colstart + 3, i))
                        W4903.SizeQty05 = CDblp(getData(vS20, colstart + 4, i))
                        W4903.SizeQty06 = CDblp(getData(vS20, colstart + 5, i))
                        W4903.SizeQty07 = CDblp(getData(vS20, colstart + 6, i))
                        W4903.SizeQty08 = CDblp(getData(vS20, colstart + 7, i))
                        W4903.SizeQty09 = CDblp(getData(vS20, colstart + 8, i))
                        W4903.SizeQty10 = CDblp(getData(vS20, colstart + 9, i))
                        W4903.SizeQty11 = CDblp(getData(vS20, colstart + 10, i))
                        W4903.SizeQty12 = CDblp(getData(vS20, colstart + 11, i))
                        W4903.SizeQty13 = CDblp(getData(vS20, colstart + 12, i))
                        W4903.SizeQty14 = CDblp(getData(vS20, colstart + 13, i))
                        W4903.SizeQty15 = CDblp(getData(vS20, colstart + 14, i))
                        W4903.SizeQty16 = CDblp(getData(vS20, colstart + 15, i))
                        W4903.SizeQty17 = CDblp(getData(vS20, colstart + 16, i))
                        W4903.SizeQty18 = CDblp(getData(vS20, colstart + 17, i))
                        W4903.SizeQty19 = CDblp(getData(vS20, colstart + 18, i))
                        W4903.SizeQty20 = CDblp(getData(vS20, colstart + 19, i))
                        W4903.SizeQty21 = CDblp(getData(vS20, colstart + 20, i))
                        W4903.SizeQty22 = CDblp(getData(vS20, colstart + 21, i))
                        W4903.SizeQty23 = CDblp(getData(vS20, colstart + 22, i))
                        W4903.SizeQty24 = CDblp(getData(vS20, colstart + 23, i))
                        W4903.SizeQty25 = CDblp(getData(vS20, colstart + 24, i))
                        W4903.SizeQty26 = CDblp(getData(vS20, colstart + 25, i))
                        W4903.SizeQty27 = CDblp(getData(vS20, colstart + 26, i))
                        W4903.SizeQty28 = CDblp(getData(vS20, colstart + 27, i))
                        W4903.SizeQty29 = CDblp(getData(vS20, colstart + 28, i))
                        W4903.SizeQty30 = CDblp(getData(vS20, colstart + 29, i))
                    End If

                    If READ_PFK4902(W4903.ShippingWorkOrder, W4903.ShippingWorkOrderSeq) Then
                        W4903.PriceS01 = D4902.PriceOrder
                        W4903.PriceS02 = D4902.PriceOrder
                        W4903.PriceS03 = D4902.PriceOrder
                        W4903.PriceS04 = D4902.PriceOrder
                        W4903.PriceS05 = D4902.PriceOrder
                        W4903.PriceS06 = D4902.PriceOrder
                        W4903.PriceS07 = D4902.PriceOrder
                        W4903.PriceS08 = D4902.PriceOrder
                        W4903.PriceS09 = D4902.PriceOrder
                        W4903.PriceS10 = D4902.PriceOrder
                        W4903.PriceS11 = D4902.PriceOrder
                        W4903.PriceS12 = D4902.PriceOrder
                        W4903.PriceS13 = D4902.PriceOrder
                        W4903.PriceS14 = D4902.PriceOrder
                        W4903.PriceS15 = D4902.PriceOrder
                        W4903.PriceS16 = D4902.PriceOrder
                        W4903.PriceS17 = D4902.PriceOrder
                        W4903.PriceS18 = D4902.PriceOrder
                        W4903.PriceS19 = D4902.PriceOrder
                        W4903.PriceS20 = D4902.PriceOrder
                        W4903.PriceS21 = D4902.PriceOrder
                        W4903.PriceS22 = D4902.PriceOrder
                        W4903.PriceS23 = D4902.PriceOrder
                        W4903.PriceS24 = D4902.PriceOrder
                        W4903.PriceS25 = D4902.PriceOrder
                        W4903.PriceS26 = D4902.PriceOrder
                        W4903.PriceS27 = D4902.PriceOrder
                        W4903.PriceS28 = D4902.PriceOrder
                        W4903.PriceS29 = D4902.PriceOrder
                        W4903.PriceS30 = D4902.PriceOrder
                    End If

                    If WRITE_PFK4903(W4903) Then
                        Call PrcExe("USP_PFK4901_UPDATE_SIZEQTY", cn, W4903.ShippingWorkOrder)
                    End If

                    isudCHK = True

                    End If
skip:
            Next

            DATA_MOVE_WRITE03 = True

        Catch ex As Exception
            MsgBoxP("DATA_MOVE_WRITE03")
        End Try

    End Function

    Private Function DATA_MOVE_WRITE03_ROW(i As Integer) As Boolean
        DATA_MOVE_WRITE03_ROW = False
        Try

            Dim j As Integer
            Dim colstart As Integer

            j = 0

            For xxx As Integer = 0 To vS20.ActiveSheet.ColumnCount - 1
                If getDataCH(vS20, xxx, 0) <> "" Then
                    colstart = xxx
                    Exit For
                End If
            Next

            If Trim(getData(vS20, getColumIndex(vS20, "KEY_ShippingWorkOrder"), i)) = "" Then Exit Function

            j = j + 1
            colstart += 1
            If K4903_MOVE(vS20, i, W4903, txt_ShippingWorkOrder.Data, getData(vS20, getColumIndex(vS20, "KEY_ShippingWorkOrderSeq"), i)) = True Then

                W4903.SizeQty01 = CDblp(getData(vS20, colstart, i))
                W4903.SizeQty02 = CDblp(getData(vS20, colstart + 1, i))
                W4903.SizeQty03 = CDblp(getData(vS20, colstart + 2, i))
                W4903.SizeQty04 = CDblp(getData(vS20, colstart + 3, i))
                W4903.SizeQty05 = CDblp(getData(vS20, colstart + 4, i))
                W4903.SizeQty06 = CDblp(getData(vS20, colstart + 5, i))
                W4903.SizeQty07 = CDblp(getData(vS20, colstart + 6, i))
                W4903.SizeQty08 = CDblp(getData(vS20, colstart + 7, i))
                W4903.SizeQty09 = CDblp(getData(vS20, colstart + 8, i))
                W4903.SizeQty10 = CDblp(getData(vS20, colstart + 9, i))
                W4903.SizeQty11 = CDblp(getData(vS20, colstart + 10, i))
                W4903.SizeQty12 = CDblp(getData(vS20, colstart + 11, i))
                W4903.SizeQty13 = CDblp(getData(vS20, colstart + 12, i))
                W4903.SizeQty14 = CDblp(getData(vS20, colstart + 13, i))
                W4903.SizeQty15 = CDblp(getData(vS20, colstart + 14, i))
                W4903.SizeQty16 = CDblp(getData(vS20, colstart + 15, i))
                W4903.SizeQty17 = CDblp(getData(vS20, colstart + 16, i))
                W4903.SizeQty18 = CDblp(getData(vS20, colstart + 17, i))
                W4903.SizeQty19 = CDblp(getData(vS20, colstart + 18, i))
                W4903.SizeQty20 = CDblp(getData(vS20, colstart + 19, i))
                W4903.SizeQty21 = CDblp(getData(vS20, colstart + 20, i))
                W4903.SizeQty22 = CDblp(getData(vS20, colstart + 21, i))
                W4903.SizeQty23 = CDblp(getData(vS20, colstart + 22, i))
                W4903.SizeQty24 = CDblp(getData(vS20, colstart + 23, i))
                W4903.SizeQty25 = CDblp(getData(vS20, colstart + 24, i))
                W4903.SizeQty26 = CDblp(getData(vS20, colstart + 25, i))
                W4903.SizeQty27 = CDblp(getData(vS20, colstart + 26, i))
                W4903.SizeQty28 = CDblp(getData(vS20, colstart + 27, i))
                W4903.SizeQty29 = CDblp(getData(vS20, colstart + 28, i))
                W4903.SizeQty30 = CDblp(getData(vS20, colstart + 29, i))

                Call REWRITE_PFK4903(W4903)
                isudCHK = True

            Else

                W4903.ShippingWorkOrder = L4901.ShippingWorkOrder
                W4903.ShippingWorkOrderSeq = getData(vS20, getColumIndex(vS20, "KEY_ShippingWorkOrderSeq"), i)

                W4903.SizeQty01 = CDblp(getData(vS20, colstart, i))
                W4903.SizeQty02 = CDblp(getData(vS20, colstart + 1, i))
                W4903.SizeQty03 = CDblp(getData(vS20, colstart + 2, i))
                W4903.SizeQty04 = CDblp(getData(vS20, colstart + 3, i))
                W4903.SizeQty05 = CDblp(getData(vS20, colstart + 4, i))
                W4903.SizeQty06 = CDblp(getData(vS20, colstart + 5, i))
                W4903.SizeQty07 = CDblp(getData(vS20, colstart + 6, i))
                W4903.SizeQty08 = CDblp(getData(vS20, colstart + 7, i))
                W4903.SizeQty09 = CDblp(getData(vS20, colstart + 8, i))
                W4903.SizeQty10 = CDblp(getData(vS20, colstart + 9, i))
                W4903.SizeQty11 = CDblp(getData(vS20, colstart + 10, i))
                W4903.SizeQty12 = CDblp(getData(vS20, colstart + 11, i))
                W4903.SizeQty13 = CDblp(getData(vS20, colstart + 12, i))
                W4903.SizeQty14 = CDblp(getData(vS20, colstart + 13, i))
                W4903.SizeQty15 = CDblp(getData(vS20, colstart + 14, i))
                W4903.SizeQty16 = CDblp(getData(vS20, colstart + 15, i))
                W4903.SizeQty17 = CDblp(getData(vS20, colstart + 16, i))
                W4903.SizeQty18 = CDblp(getData(vS20, colstart + 17, i))
                W4903.SizeQty19 = CDblp(getData(vS20, colstart + 18, i))
                W4903.SizeQty20 = CDblp(getData(vS20, colstart + 19, i))
                W4903.SizeQty21 = CDblp(getData(vS20, colstart + 20, i))
                W4903.SizeQty22 = CDblp(getData(vS20, colstart + 21, i))
                W4903.SizeQty23 = CDblp(getData(vS20, colstart + 22, i))
                W4903.SizeQty24 = CDblp(getData(vS20, colstart + 23, i))
                W4903.SizeQty25 = CDblp(getData(vS20, colstart + 24, i))
                W4903.SizeQty26 = CDblp(getData(vS20, colstart + 25, i))
                W4903.SizeQty27 = CDblp(getData(vS20, colstart + 26, i))
                W4903.SizeQty28 = CDblp(getData(vS20, colstart + 27, i))
                W4903.SizeQty29 = CDblp(getData(vS20, colstart + 28, i))
                W4903.SizeQty30 = CDblp(getData(vS20, colstart + 29, i))

                Call WRITE_PFK4903(W4903)

                isudCHK = True

            End If


            DATA_MOVE_WRITE03_ROW = True

        Catch ex As Exception
            MsgBoxP("DATA_MOVE_WRITE03_ROW")
        End Try

    End Function

  
    Private Sub DATA_INSERT()
        Try
            If K4901_MOVE(Me, W4901, 1, L4901.ShippingWorkOrder) = False Then

                Call DATA_MOVE_DEFAULT()

                W4901.ShippingWorkOrder = L4901.ShippingWorkOrder
                W4901.CustPoNo = txt_CustPoNo.Data

                If WRITE_PFK4901(W4901) = True Then
                    Call DATA_MOVE_WRITE02()
                    Call DATA_SEARCH_vS10()
                    Call DATA_MOVE_WRITE03()

                    Call MsgBoxP("Insert Succesully !", vbInformation)
                    isudCHK = True : WRITE_CHK = "*"
                    Exit Sub
                End If
            End If

        Catch ex As Exception
            MsgBoxP("DATA_INSERT")
        End Try

    End Sub

    Private Sub DATA_UPDATE()
        Try
            If K4901_MOVE(Me, W4901, 3, L4901.ShippingWorkOrder) = True Then

                Call DATA_MOVE_DEFAULT()

                W4901.ShippingWorkOrder = L4901.ShippingWorkOrder

                If REWRITE_PFK4901(W4901) = True Then
                    Call DATA_MOVE_WRITE02()
                    Call DATA_MOVE_WRITE03()
                    Call MsgBoxP("Update Succesully !", vbInformation)

                    isudCHK = True : WRITE_CHK = "*"
                    Exit Sub
                End If
            End If

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_UPDATE")
        End Try
    End Sub

    Private Sub DATA_DELETE()
        Try
            Dim i As Integer
            Dim Chk_All As Boolean

            For i = 0 To vS10.ActiveSheet.RowCount - 1

                If READ_PFK4902(getData(vS10, getColumIndex(vS10, "KEY_ShippingWorkOrder"), i), getData(vS10, getColumIndex(vS10, "KEY_ShippingWorkOrderSeq"), i)) Then
                    If D4902.ShippingWorkOrderStatus = "1" Then
                        W4902 = D4902 : DELETE_PFK4902(W4902)
                    Else
                        Chk_All = True
                    End If

                End If
            Next

            If Chk_All = True Then Exit Sub

            If READ_PFK4901(L4901.ShippingWorkOrder) = True Then
                W4901 = D4901
                DELETE_PFK4901(W4901)
                isudCHK = True : Exit Sub
            End If
            MsgBoxP("DATA_DELETE Order!")

        Catch ex As Exception
            Call MsgBoxP("38", "DATA_DELETE")
        End Try

    End Sub


    Private Sub KEY_COUNT_PFK4902()
        Try
            SQL = "SELECT MAX(CAST(K4902_ShippingWorkOrderSeq AS DECIMAL)) AS MAX_MCODE FROM PFK4902 "
            SQL = SQL & " WHERE K4902_ShippingWorkOrder = '" & txt_ShippingWorkOrder.Data & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                W4902.ShippingWorkOrderSeq = "001"
            Else
                W4902.ShippingWorkOrderSeq = CIntp(rd!MAX_MCODE + 1).ToString("000")
            End If

            rd.Close()

            L4902.ShippingWorkOrderSeq = W4902.ShippingWorkOrderSeq

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT_PFK4902")
        End Try
    End Sub


    Private Sub KEY_COUNT()

        Dim YRNO As Integer
        YRNO = Mid(System_Date_8(), 3, 4)

        Try
            SQL = "SELECT MAX(CAST(SUBSTRING(K4901_ShippingWorkOrder,7,3) AS DECIMAL)) AS MAX_MCODE FROM PFK4901 "
            SQL = SQL & " WHERE SUBSTRING(K4901_ShippingWorkOrder,3,4) = '" & YRNO.ToString & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                W4901.ShippingWorkOrder = "SR" & YRNO & "001"
            Else
                W4901.ShippingWorkOrder = "SR" & YRNO & FormatP(CInt(rd!MAX_MCODE + 1), "000")
            End If

            rd.Close()

            txt_ShippingWorkOrder.Data = W4901.ShippingWorkOrder
            L4901.ShippingWorkOrder = W4901.ShippingWorkOrder

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub



#End Region

#Region "Event"
    Private Function Data_Check() As Boolean
        Data_Check = False
        Dim i As Integer

        Try
            For i = 0 To vS10.ActiveSheet.RowCount - 1
                If getData(vS10, getColumIndex(vS10, "SizeRange"), i) = "" Then MsgBoxP("Size Range at Row " & (i + 1)) : Exit Function
                If getData(vS10, getColumIndex(vS10, "ShoesCode"), i) = "" Then MsgBoxP("ITEM CODE at Row " & (i + 1)) : Exit Function
                If getData(vS10, getColumIndex(vS10, "cdUnitPrice"), i) = "" Then MsgBoxP("Unit Price at Row " & (i + 1)) : Exit Function
            Next

            Data_Check = True
        Catch ex As Exception

        End Try
    End Function


    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Try
            Select Case wJOB
                Case 1
                    If data_check = False Then Exit Sub
                    If DataCheck(Me, "PFK4901") = False Then Exit Sub
                    Call DATA_INSERT()
                    wJOB = 3
                    Call DATA_SEARCH_vS10()
                    Call DATA_SEARCH_vS20()

                Case 2
                    Me.Dispose()
                Case 3
                    If data_check = False Then Exit Sub
                    If DataCheck(Me, "PFK4901") = False Then Exit Sub
                    Call DATA_UPDATE()
                    Call DATA_SEARCH_vS10()
                    Call DATA_SEARCH_vS20()
                Case 4
            End Select
        Catch ex As Exception
            MsgBoxP("cmd_OK_Click")
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

    Private Sub cmd_DEL_Click(sender As Object, e As EventArgs) Handles cmd_DEL.Click

        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

        If CHK(4) <> "1" Then
            Call MsgBoxP("4", "cmd_DEL_Click")
            Exit Sub
        End If

        Dim str As String = MsgBoxP("Do you want to delete it?", vbYesNo)

        If str <> vbYes Then Exit Sub
        Try
            Call DATA_DELETE()
            Me.Dispose()
        Catch ex As Exception
            MsgBoxP("cmd_DEL_Click")
        End Try

    End Sub

    Private Sub ptc_Main_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ptc_Main.Click
        Try
            Select Case True
                Case ptc_Main.SelectedIndex = 0
                    Call DATA_SEARCH_vS10()
                    Call DATA_SEARCH_vS20()

            End Select
        Catch ex As Exception
            MsgBoxP("ptc_Main_SelectedIndexChanged")
        End Try
    End Sub


    Private Sub vS10_KeyDown(sender As Object, e As KeyEventArgs) Handles vS10.KeyDown
        If wJOB = 2 Then Exit Sub
        Dim xCOL As Long
        Dim xROW As Long

        xCOL = vS10.ActiveSheet.ActiveColumnIndex
        xROW = vS10.ActiveSheet.ActiveRowIndex
        Try

            Select Case e.KeyCode
                Case Keys.Delete

                    Msg_Result = MsgBoxP("Do you want to delete?", vbYesNo)

                    If Msg_Result <> vbYes Then Exit Sub
                    Try

                        If K4902_MOVE(vS10, xROW, W4902, txt_ShippingWorkOrder.Data, getData(vS10, getColumIndex(vS10, "KEY_ShippingWorkOrderSeq"), xROW)) = True Then

                            W4902 = D4902
                            If W4902.ShippingWorkOrderStatus = "1" Then

                                If READ_PFK4903(W4902.ShippingWorkOrder, W4902.ShippingWorkOrderSeq) = True Then
                                    W4903 = D4903
                                    DELETE_PFK4903(W4903)
                                End If

                                If READ_PFK4902(W4902.ShippingWorkOrder, W4902.ShippingWorkOrderSeq) = True Then
                                    W4902 = D4902
                                    DELETE_PFK4902(W4902)
                                End If

                            Else
                                MsgBoxP("Data Already") : Exit Sub
                            End If
                        End If

                        SPR_DEL(vS10, 0, vS10.ActiveSheet.ActiveRowIndex)
                        vS10.Focus()

                    Catch ex As Exception
                        Call MsgBoxP("Vs10 Keys.Delete!")
                    End Try
                Case Keys.Enter


            End Select

        Catch ex As Exception
            Call MsgBoxP("vS10_KeyDown")
        End Try
    End Sub

    Private Sub VS10_ButtonClicked(sender As Object, e As EditorNotifyEventArgs) Handles vS10.ButtonClicked
        Dim xCOL As Integer
        Dim xROW As Integer
        Dim Value2(5) As String

        xROW = e.Row
        xCOL = e.Column

        Select Case xCOL
            Case getColumIndex(vS10, "CLOrderNo")
                If HLP1312A.Link_HLP1312Material() = True Then
                    hlp0000SeVa = hlp0000SeVa.Replace("|", ",")
                    DS1 = PrcDS("USP_ISUD4901A_SEARCH_VS10_INSERT", cn, hlp0000SeVa)
                    Call READ_SPREAD_N(vS10, DS1, xROW, GetDsRc(DS1), "USP_ISUD4901A_SEARCH_VS10", "VS10")

                    Exit Sub
                End If

                vS10.Focus()

        End Select

    End Sub
#End Region

#Region "Search Line"

    Private Function DATA_SEARCH_VS10_LINE(ShippingWorkOrder As String, ShippingWorkOrderSeq As String) As Boolean
        Dim DSNEW As New DataSet

        DATA_SEARCH_VS10_LINE = False

        Try
            DSNEW = PrcDS("USP_ISUD4901A_SEARCH_VS10_LINE", cn, ShippingWorkOrder, ShippingWorkOrderSeq)

            If GetDsRc(DSNEW) = 0 Then
                Exit Function
            End If
            READ_SPREAD(vS10, DSNEW, "USP_ISUD4901A_SEARCH_VS10", "vS10", vS10.ActiveSheet.ActiveRowIndex)

            DATA_SEARCH_VS10_LINE = True
        Catch ex As Exception
            Call MsgBoxP("DATA_SEARCH_VS10_LINE")
        End Try
    End Function

    Private Function DATA_SEARCH_VS20_LINE(ShippingWorkOrder As String, ShippingWorkOrderSeq As String) As Boolean
        Dim DSNEW As New DataSet

        DATA_SEARCH_VS20_LINE = False

        Try
            DSNEW = PrcDS("USP_ISUD4901A_SEARCH_VS20_LINE", cn, ShippingWorkOrder, ShippingWorkOrderSeq)

            If GetDsRc(DSNEW) = 0 Then
                Exit Function
            End If
            READ_SPREAD(vS20, DSNEW, "USP_ISUD4901A_SEARCH_VS20", "vS20", vS20.ActiveSheet.ActiveRowIndex)

            DATA_SEARCH_VS20_LINE = True
        Catch ex As Exception
            Call MsgBoxP("DATA_SEARCH_VS20_LINE")
        End Try
    End Function

    Private Function USP_ISUD4901A_SEARCH_VS20_PRICE_LINE(ShippingWorkOrder As String, ShippingWorkOrderSeq As String) As Boolean
        Dim DSNEW As New DataSet

        USP_ISUD4901A_SEARCH_VS20_PRICE_LINE = False

        Try
            DSNEW = PrcDS("USP_ISUD4901A_SEARCH_VS20_PRICE_LINE", cn, ShippingWorkOrder, ShippingWorkOrderSeq)

            If GetDsRc(DSNEW) = 0 Then
                Exit Function
            End If
            READ_SPREAD(vS20, DSNEW, "USP_ISUD4901A_SEARCH_VS20_PRICE", "vS20", vS20.ActiveSheet.ActiveRowIndex)

            USP_ISUD4901A_SEARCH_VS20_PRICE_LINE = True
        Catch ex As Exception
            Call MsgBoxP("USP_ISUD4901A_SEARCH_VS20_PRICE_LINE")
        End Try
    End Function
#End Region

#Region "Keydown"

    Private Sub Vs20_KeyDown(sender As Object, e As KeyEventArgs) Handles vS20.KeyDown
        If wJOB = 2 Then Exit Sub
        Dim xCOL As Long
        Dim xROW As Long

        Dim ColB As Integer
        Dim ColE As Integer
        Dim SpanC As Integer
        Dim Value As Cell

        Dim SizeBegin As String
        Dim SizeEnd As String
        Dim SizeBeginName As String
        Dim SizeEndName As String

        Dim i As Integer
        Dim colstart As Integer

        xCOL = vS20.ActiveSheet.ActiveColumnIndex
        xROW = vS20.ActiveSheet.ActiveRowIndex
        Try

            Select Case e.KeyCode
                Case Keys.Insert
                    Value = vS20.ActiveSheet.ActiveCell
                    Dim cr() As FarPoint.Win.Spread.Model.CellRange
                    cr = vS20.ActiveSheet.GetSelections

                    If cr.Length = 0 Then MsgBoxP("No size choose") : Exit Sub

                    ColB = cr(0).Column
                    ColE = ColB + cr(0).ColumnCount - 1
                    SpanC = cr(0).ColumnCount
                    If ColE < ColB Then Exit Sub

                    SizeBegin = ColB.ToString("00")
                    SizeEnd = ColE.ToString("00")

                    SizeBeginName = getDataCH(vS20, ColB, 0)
                    SizeEndName = getDataCH(vS20, ColE, 0)

                    If chk_PriceCheck.Checked Then colstart = getColumIndex(vS20, "PriceS01")

                    If READ_PFK4902(txt_ShippingWorkOrder.Data, getData(vS20, getColumIndex(vS20, "KEY_ShippingWorkOrderSeq"), xROW)) Then
                        Dim InputValue As String = InputBox("Price Order Input ", "Price Control", D4902.PriceOrder)
                        If CDecp(InputValue) < 0 Then MsgBoxP("Price Invalid!") : Exit Sub

                        If READ_PFK4903(txt_ShippingWorkOrder.Data, getData(vS20, getColumIndex(vS20, "KEY_ShippingWorkOrderSeq"), xROW)) Then
                            W4903 = D4903

                            If colstart + 1 - 1 >= ColB And colstart + 1 - 1 <= ColE Then W4903.PriceS01 = CDecp(InputValue)
                            If colstart + 2 - 1 >= ColB And colstart + 2 - 1 <= ColE Then W4903.PriceS02 = CDecp(InputValue)
                            If colstart + 3 - 1 >= ColB And colstart + 3 - 1 <= ColE Then W4903.PriceS03 = CDecp(InputValue)
                            If colstart + 4 - 1 >= ColB And colstart + 4 - 1 <= ColE Then W4903.PriceS04 = CDecp(InputValue)
                            If colstart + 5 - 1 >= ColB And colstart + 5 - 1 <= ColE Then W4903.PriceS05 = CDecp(InputValue)
                            If colstart + 6 - 1 >= ColB And colstart + 6 - 1 <= ColE Then W4903.PriceS06 = CDecp(InputValue)
                            If colstart + 7 - 1 >= ColB And colstart + 7 - 1 <= ColE Then W4903.PriceS07 = CDecp(InputValue)
                            If colstart + 8 - 1 >= ColB And colstart + 8 - 1 <= ColE Then W4903.PriceS08 = CDecp(InputValue)
                            If colstart + 9 - 1 >= ColB And colstart + 9 - 1 <= ColE Then W4903.PriceS09 = CDecp(InputValue)
                            If colstart + 10 - 1 >= ColB And colstart + 10 - 1 <= ColE Then W4903.PriceS10 = CDecp(InputValue)
                            If colstart + 11 - 1 >= ColB And colstart + 11 - 1 <= ColE Then W4903.PriceS11 = CDecp(InputValue)
                            If colstart + 12 - 1 >= ColB And colstart + 12 - 1 <= ColE Then W4903.PriceS12 = CDecp(InputValue)
                            If colstart + 13 - 1 >= ColB And colstart + 13 - 1 <= ColE Then W4903.PriceS13 = CDecp(InputValue)
                            If colstart + 14 - 1 >= ColB And colstart + 14 - 1 <= ColE Then W4903.PriceS14 = CDecp(InputValue)
                            If colstart + 15 - 1 >= ColB And colstart + 15 - 1 <= ColE Then W4903.PriceS15 = CDecp(InputValue)
                            If colstart + 16 - 1 >= ColB And colstart + 16 - 1 <= ColE Then W4903.PriceS16 = CDecp(InputValue)
                            If colstart + 17 - 1 >= ColB And colstart + 17 - 1 <= ColE Then W4903.PriceS17 = CDecp(InputValue)
                            If colstart + 18 - 1 >= ColB And colstart + 18 - 1 <= ColE Then W4903.PriceS18 = CDecp(InputValue)
                            If colstart + 19 - 1 >= ColB And colstart + 19 - 1 <= ColE Then W4903.PriceS19 = CDecp(InputValue)
                            If colstart + 20 - 1 >= ColB And colstart + 20 - 1 <= ColE Then W4903.PriceS20 = CDecp(InputValue)
                            If colstart + 21 - 1 >= ColB And colstart + 21 - 1 <= ColE Then W4903.PriceS21 = CDecp(InputValue)
                            If colstart + 22 - 1 >= ColB And colstart + 22 - 1 <= ColE Then W4903.PriceS22 = CDecp(InputValue)
                            If colstart + 23 - 1 >= ColB And colstart + 23 - 1 <= ColE Then W4903.PriceS23 = CDecp(InputValue)
                            If colstart + 24 - 1 >= ColB And colstart + 24 - 1 <= ColE Then W4903.PriceS24 = CDecp(InputValue)
                            If colstart + 25 - 1 >= ColB And colstart + 25 - 1 <= ColE Then W4903.PriceS25 = CDecp(InputValue)
                            If colstart + 26 - 1 >= ColB And colstart + 26 - 1 <= ColE Then W4903.PriceS26 = CDecp(InputValue)
                            If colstart + 27 - 1 >= ColB And colstart + 27 - 1 <= ColE Then W4903.PriceS27 = CDecp(InputValue)
                            If colstart + 28 - 1 >= ColB And colstart + 28 - 1 <= ColE Then W4903.PriceS28 = CDecp(InputValue)
                            If colstart + 29 - 1 >= ColB And colstart + 29 - 1 <= ColE Then W4903.PriceS29 = CDecp(InputValue)
                            If colstart + 30 - 1 >= ColB And colstart + 30 - 1 <= ColE Then W4903.PriceS30 = CDecp(InputValue)

                            If REWRITE_PFK4903(W4903) Then
                                Call PrcExe("USP_PFK4901_UPDATE_SIZEQTY", cn, txt_ShippingWorkOrder.Data)
                                Call USP_ISUD4901A_SEARCH_VS20_PRICE_LINE(txt_ShippingWorkOrder.Data, getData(vS20, getColumIndex(vS20, "KEY_ShippingWorkOrderSeq"), xROW))
                            End If
                        End If


                    End If



                Case Keys.Delete

                    Msg_Result = MsgBoxP("Do you want to delete?", vbYesNo)

                    If Msg_Result <> vbYes Then Exit Sub

                    If K4903_MOVE(vS20, xROW, W4903, txt_ShippingWorkOrder.Data, getData(vS20, getColumIndex(vS20, "KEY_ShippingWorkOrderSeq"), xROW)) = False Then Exit Sub

                    W4903 = D4903

                    If CheckAprroval(W4903.ShippingWorkOrder, W4903.ShippingWorkOrderSeq) = True Then
                        DELETE_PFK4903(W4903)
                    Else
                        MsgBoxP("Data Already") : Exit Sub
                    End If

                    SPR_DEL(vS20, 0, vS20.ActiveSheet.ActiveRowIndex)
                    vS20.Focus()

                Case Keys.Enter

            End Select

        Catch ex As Exception
            Call MsgBoxP("vS10_KeyDown")
        End Try
    End Sub


    Private Function CheckAprroval(ShippingWorkOrder As String, ShippingWorkOrderSeq As String) As Boolean
        CheckAprroval = False
        Try
            If READ_PFK4902(ShippingWorkOrder, ShippingWorkOrderSeq) = True Then
                W4902 = D4902
                If W4902.ShippingWorkOrderStatus = "1" Then CheckAprroval = True Else CheckAprroval = False
            End If
        Catch ex As Exception
            MsgBoxP("CheckAprroval")
        End Try
    End Function


#End Region

#Region "Sheet Change"
    Private Sub chk_MaterialList_CheckedChanged(sender As Object, e As EventArgs) Handles chk_PriceCheck.CheckedChanged
        If formA = False Then Exit Sub
        Call DATA_SEARCH_vS20()
    End Sub

    Private Sub vS10_Change(sender As Object, e As ChangeEventArgs) Handles vS10.Change
        Try


        Catch ex As Exception
            Call MsgBoxP("vS10_Change")
        End Try
    End Sub

    Private Sub vS20_Change(sender As Object, e As ChangeEventArgs) Handles vS20.Change
        Try
            

        Catch ex As Exception
            Call MsgBoxP("vS20_Change")
        End Try
    End Sub


#End Region




End Class