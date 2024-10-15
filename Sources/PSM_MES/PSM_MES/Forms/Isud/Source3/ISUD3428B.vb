Public Class ISUD3428B

#Region "Variable"
    Private wJOB As Integer
    Private WcheckType As Integer

    Private W3428 As New T3428_AREA
    Private L3428 As New T3428_AREA

    Private W3429 As New T3429_AREA
    Private L3429 As New T3429_AREA
    Private WRITE_CHK As String
    Private ImportTax As Decimal
    Private EnvironmentTax As Decimal
    Private VatTax As Decimal
    Private formA As Boolean
    Private CHK(0 To 5) As String
    Private cdSemiGroupMaterial As String

#End Region

#Region "Link"
    Public Function Link_ISUD3428B(job As Integer, PayableNo As String, checkType As Integer, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        D3428.PayableNo = PayableNo
        L3428.PayableNo = PayableNo

        wJOB = job : L3428 = D3428
        WcheckType = checkType

        Link_ISUD3428B = False
        Try

            Select Case job
                Case 1
                Case Else
                    If READ_PFK3428(PayableNo) = False Then Exit Function
                    If D3428.CheckComplete = "1" Then wJOB = 2

            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD3428B = isudCHK


        Catch ex As Exception
            Call MsgBoxP("61", WordConv("PAYABLE PROCESSING"))
        End Try

    End Function

    Private strValue As String = ""
    Public Function Link_ISUD3428B_AUTO(job As Integer, PayableNo As String, checkType As Integer, _strValue As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        D3428.PayableNo = PayableNo
        L3428.PayableNo = PayableNo

        strValue = _strValue

        wJOB = job : L3428 = D3428
        WcheckType = checkType

        Link_ISUD3428B_AUTO = False
        Try

            Select Case job
                Case 1
                Case Else
                    If READ_PFK3428(PayableNo) = False Then Exit Function
                    If D3428.CheckComplete = "1" Then wJOB = 2

            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD3428B_AUTO = isudCHK


        Catch ex As Exception
            Call MsgBoxP("61", WordConv("PAYABLE PROCESSING"))
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
            Case 1                                                      'ÀÔ·Â
                Me.Text = Me.Text & " - INSERT"
                Frame1.Enabled = True
                cmd_DEL.Visible = False

                If CHK(1) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call KEY_COUNT()
                Call DATA_SEARCH_vS1()

                'cmd_Print_PA.Visible = False

            Case 2
                Me.Text = Me.Text & " - SEARCH"

                Frame1.Enabled = True
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
                Call DATA_SEARCH_vS1()

                'cmd_Print_PA.Visible = False

            Case 3
                Me.Text = Me.Text & " - UPDATE"

                Frame1.Enabled = True
                txt_PayableNo.Enabled = False

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
                Call DATA_SEARCH_vS1()

                'cmd_Print_PA.Visible = True
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
                Call DATA_SEARCH_vS1()
                'cmd_Print_PA.Visible = False

        End Select

        formA = True
    End Sub
#End Region

#Region "Search"
    Private Function DATA_SEARCH01() As Boolean

        DATA_SEARCH01 = False

        DS1 = PrcDS("USP_ISUD3428B_SEARCH_HEAD", cn, L3428.PayableNo)


        If GetDsRc(DS1) = 0 Then
            DS2 = READ_PFK3428(L3428.PayableNo, cn)

            If GetDsRc(DS2) > 0 Then
                Call READER_MOVE(Me, DS2)
                Call CheckMarketType(GetDsData(DS2, 0, "CheckMarketType"))
                Call CheckMaterialType(GetDsData(DS2, 0, "CheckMaterialType"))
                Call CheckRelationType(GetDsData(DS2, 0, "CheckRelationType"))
                txt_PayableNo.Data = L3428.PayableNo
            End If

            Exit Function
            isudCHK = False
        End If

        STORE_MOVE(Me, DS1)
        txt_PayableNo.Data = L3428.PayableNo

        txt_cdSite.Code = GetDsData(DS1, 0, "cdSite")
        txt_cdSite.Data = GetDsData(DS1, 0, "SiteName")

        txt_InchargeInBound.Code = GetDsData(DS1, 0, "InchargePurchasingCode")
        txt_InchargeInBound.Data = GetDsData(DS1, 0, "InchargePurchasingName")

        txt_SupplierCode.Code = GetDsData(DS1, 0, "SupplierCode")
        txt_SupplierCode.Data = GetDsData(DS1, 0, "SupplierName")

        txt_cdUnitPrice.Code = GetDsData(DS1, 0, "cdUnitPrice")
        txt_cdUnitPrice.Data = GetDsData(DS1, 0, "UnitPriceName")

        Call CheckMarketType(GetDsData(DS1, 0, "CheckMarketType"))
        Call CheckMaterialType(GetDsData(DS1, 0, "CheckMaterialType"))

        If READ_PFK7171(ListCode("PaymentTerm"), GetDsData(DS1, 0, "cdPaymentTerm")) Then
            txt_cdPaymentTerm.Data = D7171.BasicName
            txt_cdPaymentTerm.Code = D7171.BasicCode
        End If


        If READ_PFK7101(txt_SupplierCode.Code) = True Then
            txt_SupplierCode.Data = D7101.CustomerName
        End If


        txt_AmountExpenseEX.Data = Format2(GetDsData(DS1, 0, "AmountExpenseEX"))
        txt_AmountExpenseVND.Data = Format0(GetDsData(DS1, 0, "AmountExpenseVND"))

        DATA_SEARCH01 = True

    End Function

    Private Function DATA_SEARCH_vS1() As Boolean
        DATA_SEARCH_vS1 = False
        Try

            DS1 = PrcDS("USP_ISUD3428B_SEARCH_VS1", cn, L3428.PayableNo)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO(Vs1, DS1, "USP_ISUD3428B_SEARCH_VS1", "Vs1")
                Vs1.ActiveSheet.RowCount = 1
                Vs1.Enabled = True
                Exit Function
            End If

            SPR_PRO(Vs1, DS1, "USP_ISUD3428B_SEARCH_VS1", "Vs1")

            DATA_SEARCH_vS1 = True
        Catch ex As Exception

        End Try
    End Function



    Private Function DATA_SEARCH_vS3() As Boolean
        DATA_SEARCH_vS3 = False
        DATA_SEARCH_vS3 = True

    End Function
#End Region

#Region "Function"
    Private Sub CheckMarketType(Market As String)
        Select Case Market
            Case "1" : rad_CheckMarketType1.Checked = True
            Case "2" : rad_CheckMarketType2.Checked = True
            Case Else : rad_CheckMarketType1.Checked = True
        End Select
    End Sub


    Private Sub CheckMarketType()
        If rad_CheckMarketType1.Checked = True Then W3428.CheckMarketType = "1"
        If rad_CheckMarketType2.Checked = True Then W3428.CheckMarketType = "2"
    End Sub

    Private Sub CheckMaterialType(Market As String)
        Select Case Market
            Case "1" : rad_CheckMaterialType1.Checked = True
            Case "2" : rad_CheckMaterialType2.Checked = True
            Case Else : rad_CheckMaterialType1.Checked = True
        End Select
    End Sub

    Private Sub CheckMaterialType()
        If rad_CheckMaterialType1.Checked = True Then W3428.CheckMaterialType = "1"
        If rad_CheckMaterialType2.Checked = True Then W3428.CheckMaterialType = "2"
    End Sub

    Private Sub CheckRelationType(Market As String)
        Select Case Market
            Case "1" : chk_CheckRelationType.Checked = True
            Case "2" : chk_CheckRelationType.Checked = False
            Case Else : chk_CheckRelationType.Checked = False
        End Select
    End Sub

    Private Sub CheckRelationType()
        If chk_CheckRelationType.Checked = True Then W3428.CheckRelationType = "1"
        If chk_CheckRelationType.Checked = False Then W3428.CheckRelationType = "2"
    End Sub
    Private Sub DATA_MOVE()
        W3428.ContractNo = txt_ContractNo.Data
    End Sub

    Private Sub DATA_MOVE_DEFAULT()

    End Sub

    Private Function DATA_MOVE_WRITE01() As Boolean
        DATA_MOVE_WRITE01 = False
        Try
            Dim i As Integer
            Dim j As Integer

            For i = 0 To Vs1.ActiveSheet.RowCount - 1


                If K3429_MOVE(Vs1, i, W3429, txt_PayableNo.Data, getData(Vs1, getColumIndex(Vs1, "PayableNoSeq"), i)) = True Then

                    Call CheckMarketType()
                    Call CheckMaterialType()
                    Call DATA_MOVE_DEFAULT()

                    W3429.CustomerSupplier = txt_SupplierCode.Code

                    W3429.CheckTypePayable = WcheckType

                    W3429.PurchaseInvoice1 = getData(Vs1, getColumIndex(Vs1, "PurchaseInvoice1"), i)
                    W3429.DateInvoice = Replace(getData(Vs1, getColumIndex(Vs1, "DateInvoice"), i), "/", "")

                    W3429.PricePurchasing = getData(Vs1, getColumIndex(Vs1, "PricePurchasing"), i)
                    W3429.PriceMarket = getData(Vs1, getColumIndex(Vs1, "PriceMarket"), i)
                    W3429.PriceExchange = getData(Vs1, getColumIndex(Vs1, "PriceExchange"), i)
                    W3429.PriceExchangeAP = getData(Vs1, getColumIndex(Vs1, "PriceExchangeAP"), i)
                    W3429.DateExchange = Replace(getData(Vs1, getColumIndex(Vs1, "DateExchange"), i), "/", "")
                    W3429.PricePurchasingEX = getData(Vs1, getColumIndex(Vs1, "PricePurchasingEX"), i)
                    W3429.PriceMarketEX = getData(Vs1, getColumIndex(Vs1, "PriceMarketEX"), i)
                    W3429.PricePurchasingVND = getData(Vs1, getColumIndex(Vs1, "PricePurchasingVND"), i)
                    W3429.PriceMarketVND = getData(Vs1, getColumIndex(Vs1, "PriceMarketVND"), i)
                    W3429.AmountPurchasingEX = getData(Vs1, getColumIndex(Vs1, "AmountPurchasingEX"), i)
                    W3429.AmountPurchasingVND = getData(Vs1, getColumIndex(Vs1, "AmountPurchasingVND"), i)
                    W3429.AmountTaxEX = getData(Vs1, getColumIndex(Vs1, "AmountTaxEX"), i)
                    W3429.AmountTaxVND = getData(Vs1, getColumIndex(Vs1, "AmountTaxVND"), i)
                    W3429.seTax1 = getData(Vs1, getColumIndex(Vs1, "seTax1"), i)
                    W3429.cdTax1 = getData(Vs1, getColumIndex(Vs1, "cdTax1"), i)
                    W3429.PerTax1 = getData(Vs1, getColumIndex(Vs1, "PerTax1"), i)

                    W3429.AmountTax1 = getData(Vs1, getColumIndex(Vs1, "AmountTax1"), i)
                    W3429.seTax2 = getData(Vs1, getColumIndex(Vs1, "seTax2"), i)
                    W3429.cdTax2 = getData(Vs1, getColumIndex(Vs1, "cdTax2"), i)
                    W3429.PerTax2 = getData(Vs1, getColumIndex(Vs1, "PerTax2"), i)
                    W3429.AmountTax2 = getData(Vs1, getColumIndex(Vs1, "AmountTax2"), i)
                    W3429.seTax3 = getData(Vs1, getColumIndex(Vs1, "seTax3"), i)
                    W3429.cdTax3 = getData(Vs1, getColumIndex(Vs1, "cdTax3"), i)
                    W3429.PerTax3 = getData(Vs1, getColumIndex(Vs1, "PerTax3"), i)
                    W3429.AmountTax3 = getData(Vs1, getColumIndex(Vs1, "AmountTax3"), i)
                    W3429.QtyPurchasing = getData(Vs1, getColumIndex(Vs1, "QtyPurchasing"), i)
                    W3429.PackPurchasing = getData(Vs1, getColumIndex(Vs1, "PackPurchasing"), i)
                    W3429.QtyWarehouse = getData(Vs1, getColumIndex(Vs1, "QtyWarehouse"), i)
                    W3429.PackWarehouse = getData(Vs1, getColumIndex(Vs1, "PackWarehouse"), i)

                    W3429.AmountEX = getData(Vs1, getColumIndex(Vs1, "AmountEX"), i)
                    W3429.AmountVND = getData(Vs1, getColumIndex(Vs1, "AmountVND"), i)
                    W3429.AmountInBoundEX = getData(Vs1, getColumIndex(Vs1, "AmountInBoundEX"), i)
                    W3429.AmountInBoundVND = getData(Vs1, getColumIndex(Vs1, "AmountInBoundVND"), i)
                    W3429.DateDelivery = Replace(getData(Vs1, getColumIndex(Vs1, "DateDelivery"), i), "/", "")
                    W3429.DateStart = Replace(getData(Vs1, getColumIndex(Vs1, "DateStart"), i), "/", "")
                    W3429.DateFinish = Replace(getData(Vs1, getColumIndex(Vs1, "DateFinish"), i), "/", "")
                    W3429.CheckPurchasing = getData(Vs1, getColumIndex(Vs1, "CheckPurchasing"), i)
                    W3429.DateAccept = Replace(getData(Vs1, getColumIndex(Vs1, "DateAccept"), i), "/", "")
                    W3429.DatePosted = Replace(getData(Vs1, getColumIndex(Vs1, "DatePosted"), i), "/", "")
                    W3429.IsPosted = getData(Vs1, getColumIndex(Vs1, "IsPosted"), i)
                    W3429.DateComplete = Replace(getData(Vs1, getColumIndex(Vs1, "DateComplete"), i), "/", "")
                    W3429.DateApproval = Replace(getData(Vs1, getColumIndex(Vs1, "DateApproval"), i), "/", "")
                    W3429.DateCancel = Replace(getData(Vs1, getColumIndex(Vs1, "DateCancel"), i), "/", "")
                    W3429.PurchasingOrderNo = getData(Vs1, getColumIndex(Vs1, "PurchasingOrderNo"), i)
                    W3429.PurchasingOrderSeq = getData(Vs1, getColumIndex(Vs1, "PurchasingOrderSeq"), i)
                    W3429.JobCardWorking = getData(Vs1, getColumIndex(Vs1, "JobCardWorking"), i)
                    W3429.JobCardWorkingSeq = getData(Vs1, getColumIndex(Vs1, "JobCardWorkingSeq"), i)
                    W3429.JobCardType = getData(Vs1, getColumIndex(Vs1, "JobCardType"), i)
                    W3429.Remark = getData(Vs1, getColumIndex(Vs1, "Remark_3429"), i)

                    W3429.seTax1 = ListCode("Tax1")
                    W3429.seTax2 = ListCode("Tax2")
                    W3429.seTax3 = ListCode("Tax3")

                    W3429.PctExpense = CDecp(getData(Vs1, getColumIndex(Vs1, "PctExpense"), i))

                    Call REWRITE_PFK3429(W3429)
                    isudCHK = True
                Else

                    Call CheckMarketType()
                    Call CheckMaterialType()
                    Call DATA_MOVE_DEFAULT()
                    Call KEY_COUNT_3429()

                    W3429.CustomerSupplier = txt_SupplierCode.Code

                    W3429.CheckTypePayable = WcheckType

                    W3429.PayableNo = txt_PayableNo.Data
                    W3429.PayableNoSeq = L3429.PayableNoSeq

                    W3429.FactOrderNo = getData(Vs1, getColumIndex(Vs1, "FactOrderNo"), i)
                    W3429.FactOrderSeq = getData(Vs1, getColumIndex(Vs1, "FactOrderSeq"), i)

                    W3429.MaterialInBoundNo = getData(Vs1, getColumIndex(Vs1, "MaterialInBoundNo"), i)
                    W3429.MaterialInBoundSeq = getData(Vs1, getColumIndex(Vs1, "MaterialInBoundSeq"), i)

                    W3429.PurchaseInvoice1 = getData(Vs1, getColumIndex(Vs1, "PurchaseInvoice1"), i)
                    W3429.DateInvoice = Replace(getData(Vs1, getColumIndex(Vs1, "DateInvoice"), i), "/", "")

                    W3429.seSite = getData(Vs1, getColumIndex(Vs1, "seSite"), i)
                    W3429.cdSite = getData(Vs1, getColumIndex(Vs1, "cdSite"), i)
                    W3429.seDepartment = getData(Vs1, getColumIndex(Vs1, "seDepartment"), i)
                    W3429.cdDepartment = getData(Vs1, getColumIndex(Vs1, "cdDepartment"), i)

                    W3429.CustomerSupplier = getData(Vs1, getColumIndex(Vs1, "CustomerSupplier"), i)
                    W3429.Dseq = i
                    W3429.AutokeyK3011 = getData(Vs1, getColumIndex(Vs1, "AutokeyK3011"), i)
                    W3429.CheckRelationType = getData(Vs1, getColumIndex(Vs1, "CheckRelationType"), i)
                    W3429.MaterialCode = getData(Vs1, getColumIndex(Vs1, "MaterialCode"), i)
                    W3429.Specification = getData(Vs1, getColumIndex(Vs1, "Specification"), i)
                    W3429.Width = getData(Vs1, getColumIndex(Vs1, "Width"), i)
                    W3429.Height = getData(Vs1, getColumIndex(Vs1, "Height"), i)
                    W3429.SizeNo = getData(Vs1, getColumIndex(Vs1, "SizeNo"), i)
                    W3429.SizeName = getData(Vs1, getColumIndex(Vs1, "SizeName"), i)
                    W3429.ColorCode = getData(Vs1, getColumIndex(Vs1, "ColorCode"), i)
                    W3429.ColorName = getData(Vs1, getColumIndex(Vs1, "ColorName"), i)
                    W3429.seOrigin = getData(Vs1, getColumIndex(Vs1, "seOrigin"), i)
                    W3429.cdOrigin = getData(Vs1, getColumIndex(Vs1, "cdOrigin"), i)
                    W3429.MaterialCheck = getDataM(Vs1, getColumIndex(Vs1, "MaterialCheck"), i)
                    W3429.seUnitPrice = getData(Vs1, getColumIndex(Vs1, "seUnitPrice"), i)
                    W3429.cdUnitPrice = getData(Vs1, getColumIndex(Vs1, "cdUnitPrice"), i)
                    W3429.seTax = getData(Vs1, getColumIndex(Vs1, "seTax"), i)
                    W3429.cdTax = getData(Vs1, getColumIndex(Vs1, "cdTax"), i)
                    W3429.seUnitMaterial = getData(Vs1, getColumIndex(Vs1, "seUnitMaterial"), i)
                    W3429.cdUnitMaterial = getData(Vs1, getColumIndex(Vs1, "cdUnitMaterial"), i)
                    W3429.seUnitPacking = getData(Vs1, getColumIndex(Vs1, "seUnitPacking"), i)
                    W3429.cdUnitPacking = getData(Vs1, getColumIndex(Vs1, "cdUnitPacking"), i)
                    W3429.UnitBaseCheck = getDataM(Vs1, getColumIndex(Vs1, "UnitBaseCheck"), i)
                    W3429.QtyBasic = getData(Vs1, getColumIndex(Vs1, "QtyBasic"), i)
                    W3429.PricePurchasing = getData(Vs1, getColumIndex(Vs1, "PricePurchasing"), i)
                    W3429.PriceMarket = getData(Vs1, getColumIndex(Vs1, "PriceMarket"), i)
                    W3429.PriceExchange = getData(Vs1, getColumIndex(Vs1, "PriceExchange"), i)
                    W3429.PriceExchangeAP = getData(Vs1, getColumIndex(Vs1, "PriceExchangeAP"), i)
                    W3429.DateExchange = Replace(getData(Vs1, getColumIndex(Vs1, "DateExchange"), i), "/", "")
                    W3429.PricePurchasingEX = getData(Vs1, getColumIndex(Vs1, "PricePurchasingEX"), i)
                    W3429.PriceMarketEX = getData(Vs1, getColumIndex(Vs1, "PriceMarketEX"), i)
                    W3429.PricePurchasingVND = getData(Vs1, getColumIndex(Vs1, "PricePurchasingVND"), i)
                    W3429.PriceMarketVND = getData(Vs1, getColumIndex(Vs1, "PriceMarketVND"), i)
                    W3429.AmountPurchasingEX = getData(Vs1, getColumIndex(Vs1, "AmountPurchasingEX"), i)
                    W3429.AmountPurchasingVND = getData(Vs1, getColumIndex(Vs1, "AmountPurchasingVND"), i)
                    W3429.AmountTaxEX = getData(Vs1, getColumIndex(Vs1, "AmountTaxEX"), i)
                    W3429.AmountTaxVND = getData(Vs1, getColumIndex(Vs1, "AmountTaxVND"), i)
                    W3429.seTax1 = getData(Vs1, getColumIndex(Vs1, "seTax1"), i)
                    W3429.cdTax1 = getData(Vs1, getColumIndex(Vs1, "cdTax1"), i)
                    W3429.PerTax1 = getData(Vs1, getColumIndex(Vs1, "PerTax1"), i)

                    W3429.AmountTax1 = getData(Vs1, getColumIndex(Vs1, "AmountTax1"), i)
                    W3429.seTax2 = getData(Vs1, getColumIndex(Vs1, "seTax2"), i)
                    W3429.cdTax2 = getData(Vs1, getColumIndex(Vs1, "cdTax2"), i)
                    W3429.PerTax2 = getData(Vs1, getColumIndex(Vs1, "PerTax2"), i)
                    W3429.AmountTax2 = getData(Vs1, getColumIndex(Vs1, "AmountTax2"), i)
                    W3429.seTax3 = getData(Vs1, getColumIndex(Vs1, "seTax3"), i)
                    W3429.cdTax3 = getData(Vs1, getColumIndex(Vs1, "cdTax3"), i)
                    W3429.PerTax3 = getData(Vs1, getColumIndex(Vs1, "PerTax3"), i)
                    W3429.AmountTax3 = getData(Vs1, getColumIndex(Vs1, "AmountTax3"), i)
                    W3429.QtyPurchasing = getData(Vs1, getColumIndex(Vs1, "QtyPurchasing"), i)
                    W3429.PackPurchasing = getData(Vs1, getColumIndex(Vs1, "PackPurchasing"), i)
                    W3429.QtyWarehouse = getData(Vs1, getColumIndex(Vs1, "QtyWarehouse"), i)
                    W3429.PackWarehouse = getData(Vs1, getColumIndex(Vs1, "PackWarehouse"), i)

                    W3429.AmountEX = getData(Vs1, getColumIndex(Vs1, "AmountEX"), i)
                    W3429.AmountVND = getData(Vs1, getColumIndex(Vs1, "AmountVND"), i)
                    W3429.AmountInBoundEX = getData(Vs1, getColumIndex(Vs1, "AmountInBoundEX"), i)
                    W3429.AmountInBoundVND = getData(Vs1, getColumIndex(Vs1, "AmountInBoundVND"), i)
                    W3429.DateDelivery = Replace(getData(Vs1, getColumIndex(Vs1, "DateDelivery"), i), "/", "")
                    W3429.DateStart = Replace(getData(Vs1, getColumIndex(Vs1, "DateStart"), i), "/", "")
                    W3429.DateFinish = Replace(getData(Vs1, getColumIndex(Vs1, "DateFinish"), i), "/", "")

                    W3429.DateAccept = Replace(getData(Vs1, getColumIndex(Vs1, "DateAccept"), i), "/", "")
                    W3429.DatePosted = Replace(getData(Vs1, getColumIndex(Vs1, "DatePosted"), i), "/", "")
                    W3429.IsPosted = getData(Vs1, getColumIndex(Vs1, "IsPosted"), i)
                    W3429.DateComplete = Replace(getData(Vs1, getColumIndex(Vs1, "DateComplete"), i), "/", "")
                    W3429.DateApproval = Replace(getData(Vs1, getColumIndex(Vs1, "DateApproval"), i), "/", "")
                    W3429.DateCancel = Replace(getData(Vs1, getColumIndex(Vs1, "DateCancel"), i), "/", "")
                    W3429.PurchasingOrderNo = getData(Vs1, getColumIndex(Vs1, "PurchasingOrderNo"), i)
                    W3429.PurchasingOrderSeq = getData(Vs1, getColumIndex(Vs1, "PurchasingOrderSeq"), i)
                    W3429.JobCardWorking = getData(Vs1, getColumIndex(Vs1, "JobCardWorking"), i)
                    W3429.JobCardWorkingSeq = getData(Vs1, getColumIndex(Vs1, "JobCardWorkingSeq"), i)
                    W3429.JobCardType = getData(Vs1, getColumIndex(Vs1, "JobCardType"), i)
                    W3429.Remark = getData(Vs1, getColumIndex(Vs1, "Remark_3429"), i)


                    W3429.seTax1 = ListCode("Tax1")
                    W3429.seTax2 = ListCode("Tax2")
                    W3429.seTax3 = ListCode("Tax3")

                    W3429.PctExpense = CDecp(getData(Vs1, getColumIndex(Vs1, "PctExpense"), i))

                    If WRITE_PFK3429(W3429) Then
                        wJOB = 3
                        isudCHK = True
                    End If
                End If

skip:

            Next

            DATA_MOVE_WRITE01 = True
        Catch ex As Exception
            MsgBoxP("DATA_MOVE_WRITE01")
        End Try

    End Function

    Private Sub DATA_INSERT()

        Try

            If K3428_MOVE(Me, W3428, 1, L3428.PayableNo) = False Then

                Call KEY_COUNT()
                Call CheckRelationType()

                W3428.CheckProcessType = "3"

                If rad_CheckMaterialType1.Checked = True Then W3428.CheckMaterialType = "1"
                If rad_CheckMaterialType2.Checked = True Then W3428.CheckMaterialType = "2"

                If rad_CheckMarketType1.Checked = True Then W3428.CheckMarketType = "1"
                If rad_CheckMarketType2.Checked = True Then W3428.CheckMarketType = "2"

                W3428.seSite = ListCode("Site")
                W3428.cdSite = txt_cdSite.Code

                W3428.SupplierCode = txt_SupplierCode.Code
                W3428.DateAccept = txt_DateAccept.Data
                W3428.DateEstimate = txt_DateEstimate.Data

                W3428.selUnitPrice = ListCode("UnitPrice")
                W3428.cdUnitPrice = txt_cdUnitPrice.Code

                W3428.ContractNo = txt_ContractNo.Data

                W3428.seSite = ListCode("Site")
                W3428.cdSite = txt_cdSite.Code

                W3428.seDepartment = ListCode("Department")
                W3428.cdDepartment = txt_cdDepartment.Code

                W3428.cdPaymentTerm = txt_cdPaymentTerm.Code
                W3428.sePaymentTerm = ListCode("PaymentTerm")
                W3428.CheckComplete = "2"

                W3428.InchargePurchasing = txt_InchargeInBound.Code
                W3428.DateInsert = Pub.DAT
                W3428.InchargeInsert = Pub.SAW

                Call DATA_MOVE()
                If WRITE_PFK3428(W3428) = True Then
                    Call DATA_MOVE_WRITE01()

                    isudCHK = True : WRITE_CHK = "*"
                    wJOB = 3
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub DATA_UPDATE()
        Try
            If K3428_MOVE(Me, W3428, 3, L3428.PayableNo) = True Then

                Call CheckRelationType()
                W3428.ContractNo = txt_ContractNo.Data

                W3428.cdPaymentTerm = txt_cdPaymentTerm.Code
                W3428.sePaymentTerm = ListCode("PaymentTerm")

                W3428.seSite = ListCode("Site")
                W3428.cdSite = txt_cdSite.Code

                W3428.seDepartment = ListCode("Department")
                W3428.cdDepartment = txt_cdDepartment.Code

                W3428.selUnitPrice = ListCode("UnitPrice")
                W3428.cdUnitPrice = txt_cdUnitPrice.Code

                W3428.CheckComplete = "2"

                W3428.SupplierCode = txt_SupplierCode.Code
                W3428.DateAccept = txt_DateAccept.Data
                W3428.DateEstimate = txt_DateEstimate.Data

                W3428.InchargePurchasing = txt_InchargeInBound.Code

                If rad_CheckMaterialType1.Checked = True Then W3428.CheckMaterialType = "1"
                If rad_CheckMaterialType2.Checked = True Then W3428.CheckMaterialType = "2"

                If rad_CheckMarketType1.Checked = True Then W3428.CheckMarketType = "1"
                If rad_CheckMarketType2.Checked = True Then W3428.CheckMarketType = "2"

                W3428.DateUpdate = Pub.DAT
                W3428.InchargeUpdate = Pub.SAW


                If REWRITE_PFK3428(W3428) = True Then

                    Call DATA_MOVE_WRITE01()

                    isudCHK = True
                End If
            End If
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_UPDATE")
        End Try
    End Sub


    Private Sub DATA_DELETE()
        Try
            Dim i As Integer

            For i = 0 To Vs1.ActiveSheet.RowCount - 1

                If Trim(getData(Vs1, getColumIndex(Vs1, "KEY_PayableNo"), i)) = "" Then GoTo skip
                If Trim(getData(Vs1, getColumIndex(Vs1, "KEY_PayableNoSeq"), i)) = "" Then GoTo skip

                W3428.PayableNo = txt_PayableNo.Data

                If getData(Vs1, getColumIndex(Vs1, "KEY_PayableNoSeq"), i) <> "0" Then
                    Call K3429_MOVE(Vs1, i, W3429, txt_PayableNo.Data, getData(Vs1, getColumIndex(Vs1, "KEY_PayableNoSeq"), i))
                    W3429.PayableNo = txt_PayableNo.Data
                    W3429.PayableNoSeq = getDataM(Vs1, getColumIndex(Vs1, "PayableNoSeq"), i)
                    Call DELETE_PFK3429(W3429)

                    Call Delete_History("PFK3429", W3429.PayableNo & "-" & W3429.PayableNoSeq.ToString)

                End If
skip:
            Next
            If READ_PFK3429_CNT(txt_PayableNo.Data) = False Then
                If READ_PFK3428(txt_PayableNo.Data) = True Then
                    W3428 = D3428
                    If DELETE_PFK3428(W3428) = True Then

                        Call Delete_History("PFK3428", W3428.PayableNo)

                        isudCHK = True
                        Me.Dispose()
                    End If
                End If
            End If
        Catch ex As Exception

            Call MsgBoxP("38", "DATA_DELETE")
        End Try
    End Sub

    Private Sub KEY_COUNT_3429()
        Try
            SQL = "SELECT MAX(K3429_PayableNoSeq) AS MAX_MCODE FROM PFK3429 "
            SQL = SQL & " WHERE K3429_PayableNo = '" & txt_PayableNo.Data & "' "


            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                W3429.PayableNoSeq = 1
            Else
                W3429.PayableNoSeq = CIntp(rd!MAX_MCODE + 1)
            End If

            rd.Close()

            L3429.PayableNoSeq = W3429.PayableNoSeq

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub

    Private Sub KEY_COUNT()

        Dim YRNO As Integer
        Dim MaxChk As Boolean = False

        YRNO = Mid(System_Date_8(), 3, 4)

        Try
            SQL = "SELECT MAX(CAST(SUBSTRING(K3428_PayableNo,7,3) AS DECIMAL)) AS MAX_MCODE FROM PFK3428 "
            SQL = SQL & " WHERE SUBSTRING(K3428_PayableNo,3,4) = '" & YRNO.ToString & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then

            Else
                If rd!MAX_MCODE = 999 Then
                    MaxChk = True
                    YRNO += 1
                End If

            End If
            rd.Close()


            SQL = "SELECT MAX(CAST(SUBSTRING(K3428_PayableNo,7,3) AS DECIMAL)) AS MAX_MCODE FROM PFK3428 "
            SQL = SQL & " WHERE SUBSTRING(K3428_PayableNo,3,4) = '" & YRNO.ToString & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                W3428.PayableNo = "PA" & YRNO & "001"
            Else
                W3428.PayableNo = "PA" & YRNO & Format(CInt(rd!MAX_MCODE + 1), "000")

            End If

            rd.Close()

            L3428.PayableNo = W3428.PayableNo
            txt_PayableNo.Data = W3428.PayableNo


        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub


    Private Sub DATA_INIT()
        Try
            txt_PayableNo.Enabled = False
            Call D3428_CLEAR()

            txt_DateAccept.Data = System_Date_8()
            txt_DateExchange.Data = System_Date_8()

            If READ_PFK7411(Pub.SAW) Then
                txt_InchargeInBound.Data = D7411.Name
                txt_InchargeInBound.Code = D7411.IDNO
            End If

            txt_cdUnitPrice.Code = "001"
            txt_cdUnitPrice.Data = "VND"

            txt_DateEstimate.Data = Pub.DAT
            W3428 = D3428

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INIT")
        End Try

    End Sub

    Private Sub FORM_INIT()

        txt_cdDepartment.Enabled = True
        txt_cdDepartment.TextEnabled = True
        txt_cdDepartment.ButtonEnabled = True
    End Sub

    Private Function READ_SHEETPRINT_MATCHING(PROG As String) As Boolean
        READ_SHEETPRINT_MATCHING = False
        Try
            SQL = "SELECT *  FROM [CS_PRINT].[dbo].[A_SHEETPRINT_MATCHING] "
            SQL = SQL + " WHERE [PROG] = '" + PROG + "'"

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = False Then GoTo pass
            READ_SHEETPRINT_MATCHING = True
        Catch ex As Exception

        End Try
pass:
        rd.Close()
    End Function

    Private Function READ_SHEETPRINT_MATCHING_MULTI(PROG As String, SheetReportName As String) As Boolean
        READ_SHEETPRINT_MATCHING_MULTI = False
        Try
            SQL = "SELECT *  FROM [CS_PRINT].[dbo].[A_SHEETPRINT_MATCHING_MULTI] "
            SQL = SQL + " WHERE [PROG]          = '" + PROG + "'"
            SQL = SQL + "   AND [SHEETREPORT]   = '" + SheetReportName + "'"

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = False Then GoTo pass
            READ_SHEETPRINT_MATCHING_MULTI = True
        Catch ex As Exception

        End Try
pass:
        rd.Close()
    End Function

#End Region

#Region "Event"
    Private Function Data_Check() As Boolean
        Data_Check = False
        Dim i As Integer
        Dim AmtBegin As Decimal
        Dim AmtEnd As Decimal

        Dim Sdate As String = txt_DateAccept.Data
        Dim Edate As String = txt_DateEstimate.Data

        Dim NDate As String
        NDate = Strings.Left(Pub.DAT, 6)

        'If Strings.Left(Sdate, 6) <> NDate Or Strings.Left(Edate, 6) <> NDate Then
        '    MsgBoxP("Payable List only on this month!") : Exit Function
        'End If

        If Sdate > Edate Then
            MsgBoxP("Start Date  > End Date!") : Exit Function
        End If

        If txt_cdUnitPrice.Code = "001" Then txt_PriceExchange.Data = "1"

        If txt_cdUnitPrice.Code <> "001" Then
            If READ_PFK7171(ListCode("UnitPrice"), txt_cdUnitPrice.Code) Then
                AmtBegin = CDecp(D7171.CheckName9)
                AmtEnd = CDecp(D7171.CheckName10)

                If CDecp(txt_PriceExchange.Data) < AmtBegin Or CDecp(txt_PriceExchange.Data) > AmtEnd Then MsgBoxEx("Wrong Price Exchange!") : Setfocus(txt_PriceExchange) : Exit Function

            End If
        End If


        Try
            For i = 0 To Vs1.ActiveSheet.RowCount - 1
                If getData(Vs1, getColumIndex(Vs1, "MaterialCode"), i) = "" Then MsgBoxP("Sai vật tư ở dòng " & (i + 1)) : Exit Function

                If FormatCut(getData(Vs1, getColumIndex(Vs1, "PurchaseInvoice1"), i)) = "" Then MsgBoxP("Không có Invoice ở dòng " & (i + 1)) : Exit Function
                If FormatCut(getData(Vs1, getColumIndex(Vs1, "DateInvoice"), i)) = "" Then MsgBoxP("Không có ngày Invoice ở dòng " & (i + 1)) : Exit Function

                If FormatCut(getData(Vs1, getColumIndex(Vs1, "DateInvoice"), i)) < Sdate Or FormatCut(getData(Vs1, getColumIndex(Vs1, "DateInvoice"), i)) > Edate Then
                    MsgBoxP("Sai ngày Invoice ! Phải ở giữa ngày " & FSDate(Sdate) & " và " & FSDate(Edate) & ". Vui lòng kiểm tra ở dòng " & (i + 1)) : Exit Function
                End If

                If CDblp(getData(Vs1, getColumIndex(Vs1, "PricePurchasing"), i)) = 0 Then MsgBoxP("Không có giá ở dòng " & (i + 1)) : Exit Function
                If CDblp(getData(Vs1, getColumIndex(Vs1, "QtyPurchasing"), i)) = 0 Then MsgBoxP("Không có số lượng ở dòng " & (i + 1)) : Exit Function

                If FormatCut(getData(Vs1, getColumIndex(Vs1, "cdTax3"), i)) = "" Then MsgBoxP("Không có VAT ở dòng " & (i + 1)) : Exit Function
                'If FormatCut(getData(Vs1, getColumIndex(Vs1, "Specification"), i)) = "" Then MsgBoxP("Thiếu mô tả ở dòng " & (i + 1)) : Exit Function

skip:
            Next

            Data_Check = True
        Catch ex As Exception

        End Try
    End Function
    Private Sub DATA_CLOSE()
        Try
            Call PrcExeNoError(" EXP_CLOSSING_PFK3428", cn, txt_PayableNo.Data)

        Catch ex As Exception

        End Try
    End Sub
    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Select Case wJOB
            Case 1
                If Data_Check = False Then Exit Sub
                'If DataCheck(Me, "PFK3428") = False Then Exit Sub

                Call KEY_COUNT()
                Call DATA_INSERT()
                Call DATA_CLOSE()

                Call DATA_SEARCH01()
                Call DATA_SEARCH_vS1()

                Call MsgBoxP("Update Successully!", vbInformation)
                wJOB = 3
                cmd_Print_PA.Visible = True

            Case 2
                Me.Dispose()

            Case 3
                If Data_Check = False Then Exit Sub
                'If DataCheck(Me, "PFK3428") = False Then Exit Sub

                Call DATA_UPDATE()
                Call DATA_CLOSE()
                Call MsgBoxP("Update Successully!", vbInformation)

                Call DATA_SEARCH01()
                Call DATA_SEARCH_vS1()

            Case 4
                Call DATA_DELETE()
                Call DATA_CLOSE()
                Me.Dispose()

            Case 11
                If Data_Check = False Then Exit Sub
                'If DataCheck(Me, "PFK3428") = False Then Exit Sub

                Call DATA_INSERT()
                Call DATA_CLOSE()
        End Select
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

        Call DATA_DELETE()
        Call DATA_CLOSE()
        Me.Dispose()
    End Sub

    Private Sub Vs1_Change(sender As Object, e As ChangeEventArgs) Handles Vs1.Change
        Dim xCOL As Long
        Dim xROW As Long

        Try

            xROW = e.Row
            xCOL = e.Column

            vSChange(xROW)

        Catch ex As Exception

        End Try

    End Sub

    Private Sub vSChange(xROW As Integer)
        Try

            Dim PricePurchasing As Decimal
            Dim PricePurchasingEX As Decimal
            Dim PriceExchange As Decimal
            Dim PricePurchasingVND As Decimal

            Dim QtyPurchasing As Decimal

            Dim AmountPurchasingEX As Decimal
            Dim AmountPurchasingVND As Decimal
            Dim AmountTaxEX As Decimal
            Dim AmountTaxVND As Decimal
            Dim PerTax3 As Decimal
            Dim AmountTax3 As Decimal

            Dim AmountEX As Decimal
            Dim AmountVND As Decimal

            PriceExchange = CDecp(txt_PriceExchange.Data)
            PricePurchasing = CDecp(getData(Vs1, getColumIndex(Vs1, "PricePurchasing"), xROW))
            PricePurchasingEX = PricePurchasing
            PricePurchasingVND = PricePurchasing * PriceExchange

            QtyPurchasing = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyPurchasing"), xROW))
            AmountPurchasingEX = PricePurchasingEX * QtyPurchasing
            AmountPurchasingVND = PricePurchasingVND * QtyPurchasing

            PerTax3 = CDecp(getData(Vs1, getColumIndex(Vs1, "cdTax3Name"), xROW))
            AmountTax3 = CDecp(getData(Vs1, getColumIndex(Vs1, "cdTax3Name"), xROW)) * AmountPurchasingVND
            AmountTaxVND = AmountTax3
            AmountTaxEX = AmountTax3

            AmountEX = AmountTaxEX + AmountPurchasingEX
            AmountVND = AmountTaxVND + AmountPurchasingVND

            setData(Vs1, getColumIndex(Vs1, "PricePurchasing"), xROW, PricePurchasing)
            setData(Vs1, getColumIndex(Vs1, "PricePurchasingEX"), xROW, PricePurchasingEX)
            setData(Vs1, getColumIndex(Vs1, "PricePurchasingVND"), xROW, PricePurchasingVND)

            setData(Vs1, getColumIndex(Vs1, "AmountPurchasingEX"), xROW, AmountPurchasingEX)
            setData(Vs1, getColumIndex(Vs1, "AmountPurchasingVND"), xROW, AmountPurchasingVND)
            setData(Vs1, getColumIndex(Vs1, "AmountTaxEX"), xROW, AmountTaxEX)
            setData(Vs1, getColumIndex(Vs1, "AmountTaxVND"), xROW, AmountTaxVND)
            setData(Vs1, getColumIndex(Vs1, "PerTax3"), xROW, PerTax3)
            setData(Vs1, getColumIndex(Vs1, "AmountTax3"), xROW, AmountTax3)
            setData(Vs1, getColumIndex(Vs1, "QtyPurchasing"), xROW, QtyPurchasing)

            setData(Vs1, getColumIndex(Vs1, "AmountEX"), xROW, AmountEX)
            setData(Vs1, getColumIndex(Vs1, "AmountVND"), xROW, AmountVND)

        Catch ex As Exception

        End Try
    End Sub


    Private Sub vS1_KeyDown(sender As Object, e As KeyEventArgs) Handles Vs1.KeyDown
        If wJOB = 2 Then Exit Sub
        Dim xCOL As Long
        Dim xROW As Long

        xCOL = Vs1.ActiveSheet.ActiveColumnIndex
        xROW = Vs1.ActiveSheet.ActiveRowIndex

        Select Case e.KeyCode
            Case Keys.Insert

                If xROW = sender.ActiveSheet.RowCount - 1 Then
                    Vs1.ActiveSheet.RowCount += 1
                    Vs1.ActiveSheet.ActiveRowIndex = xROW + 1
                Else
                    Vs1.ActiveSheet.AddRows(xROW + 1, 1)
                End If

            Case Keys.Delete

                Msg_Result = MsgBoxP("Do you want to delete?", vbYesNo)

                If Msg_Result <> vbYes Then Exit Sub

                If getData(Vs1, getColumIndex(Vs1, "KEY_PayableNoSeq"), xROW) <> "0" Then

                    If READ_PFK3429(txt_PayableNo.Data, getData(Vs1, getColumIndex(Vs1, "KEY_PayableNoSeq"), xROW)) Then
                        W3429.PayableNo = txt_PayableNo.Data
                        W3429.PayableNoSeq = getDataM(Vs1, getColumIndex(Vs1, "PayableNoSeq"), xROW)
                        Call DELETE_PFK3429(W3429)

                        Call Delete_History("PFK3429", W3429.PayableNo & "-" & W3429.PayableNoSeq.ToString)

                    End If
                End If


                SPR_DEL(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex)
                Vs1.Focus()


            Case Keys.Enter
                vSChange(xROW)
        End Select
    End Sub
    Private Sub txt_DateExchange_Load(sender As Object, e As EventArgs) Handles txt_DateExchange.m_Textchange
        Try

        Catch ex As Exception

        End Try

    End Sub

    Public Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        gpp = e.Graphics
        Call TAG_PRINT_MATERIAL_NEW_F1()
    End Sub

    Private Sub txt_PriceExchange_txtTextChanged(sender As Object, e As EventArgs) Handles txt_DateExchange.m_Textchange, txt_cdUnitPrice.txtTextChange
        If formA = False Then Exit Sub
        Dim i As Integer
        Try


            If READ_PFK7199(txt_DateExchange.Data, ListCode("UnitPrice"), txt_cdUnitPrice.Code) Then
                txt_PriceExchange.Data = D7199.Value
            Else
                txt_PriceExchange.Data = 0
            End If

        Catch ex As Exception

        End Try


    End Sub

    Private Sub txt_PriceExchange_txtLostFocus(sender As Object, e As EventArgs) Handles txt_DateExchange.txtTextLostFocus, txt_cdUnitPrice.txtTextLostFocus, txt_PriceExchange.txtTextLostFocus
        If formA = False Then Exit Sub
        Dim i As Integer
        Try


            If READ_PFK7199(txt_DateExchange.Data, ListCode("UnitPrice"), txt_cdUnitPrice.Code) Then
                txt_PriceExchange.Data = D7199.Value
            Else
                txt_PriceExchange.Data = 0
            End If

        Catch ex As Exception

        End Try


    End Sub


    Private Sub Vs1_ButtonClicked(sender As Object, e As EditorNotifyEventArgs) Handles Vs1.ButtonClicked
        Dim xCOL As Integer
        Dim xROW As Integer
        Dim i As Integer
        Dim Value1() As String
        Dim Value2 As String
        Dim Chk_PayType As Integer
        Dim hlp_cdSite As String
        Dim hlp_SupplierCode As String


        xROW = e.Row
        xCOL = e.Column

        Select Case xCOL
            Case getColumIndex(Vs1, "clPayableNo")

                Chk_PayType = "3"

                If txt_SupplierCode.Data <> "" Then hlp_SupplierCode = txt_SupplierCode.Code

                If HLP3428B.Link_HLP3428B(Chk_PayType) = True Then
                    If hlp0000SeVa = "" Then Exit Sub
                    Value1 = hlp0000SeVa.Split(",")

                    For i = 0 To Value1.Length - 1
                        Value2 = Value1(i)

                        If READ_PFK7171("510", Value2) Then

                            setData(Vs1, getColumIndex(Vs1, "CheckTypePayable"), xROW, WcheckType)

                            setData(Vs1, getColumIndex(Vs1, "KEY_PayableNo"), xROW, txt_PayableNo.Data)
                            setData(Vs1, getColumIndex(Vs1, "KEY_PayableNoSeq"), xROW, "0")
                            setData(Vs1, getColumIndex(Vs1, "PayableNo"), xROW, txt_PayableNo.Data)
                            setData(Vs1, getColumIndex(Vs1, "PayableNoSeq"), xROW, "0")

                            setData(Vs1, getColumIndex(Vs1, "MaterialName"), xROW, D7171.BasicName)

                            If READ_PFK7231_NAME(D7171.BasicName) Then
                                setData(Vs1, getColumIndex(Vs1, "MaterialCode"), xROW, D7231.MaterialCode)
                            End If

                            setData(Vs1, getColumIndex(Vs1, "Specification"), xROW, "")
                            setData(Vs1, getColumIndex(Vs1, "PricePurchasing"), xROW, 0)
                            setData(Vs1, getColumIndex(Vs1, "PricePurchasingEX"), xROW, 0)
                            setData(Vs1, getColumIndex(Vs1, "PricePurchasingVND"), xROW, 0)

                            setData(Vs1, getColumIndex(Vs1, "AmountPurchasingEX"), xROW, 0)
                            setData(Vs1, getColumIndex(Vs1, "AmountPurchasingVND"), xROW, 0)
                            setData(Vs1, getColumIndex(Vs1, "AmountTaxEX"), xROW, 0)
                            setData(Vs1, getColumIndex(Vs1, "AmountTaxVND"), xROW, 0)
                            setData(Vs1, getColumIndex(Vs1, "seTax1"), xROW, "")
                            setData(Vs1, getColumIndex(Vs1, "cdTax1"), xROW, "")
                            setData(Vs1, getColumIndex(Vs1, "PerTax1"), xROW, 0)

                            setData(Vs1, getColumIndex(Vs1, "AmountTax1"), xROW, 0)
                            setData(Vs1, getColumIndex(Vs1, "seTax2"), xROW, "")
                            setData(Vs1, getColumIndex(Vs1, "cdTax2"), xROW, "")
                            setData(Vs1, getColumIndex(Vs1, "PerTax2"), xROW, 0)
                            setData(Vs1, getColumIndex(Vs1, "AmountTax2"), xROW, 0)
                            setData(Vs1, getColumIndex(Vs1, "seTax3"), xROW, "")
                            setData(Vs1, getColumIndex(Vs1, "cdTax3"), xROW, "")
                            setData(Vs1, getColumIndex(Vs1, "PerTax3"), xROW, 0)
                            setData(Vs1, getColumIndex(Vs1, "AmountTax3"), xROW, 0)
                            setData(Vs1, getColumIndex(Vs1, "QtyPurchasing"), xROW, 0)

                            setData(Vs1, getColumIndex(Vs1, "AmountEX"), xROW, 0)
                            setData(Vs1, getColumIndex(Vs1, "AmountVND"), xROW, 0)
                            setData(Vs1, getColumIndex(Vs1, "AmountInBoundEX"), xROW, 0)
                            setData(Vs1, getColumIndex(Vs1, "AmountInBoundVND"), xROW, 0)


                            Vs1.ActiveSheet.RowCount += 1

                            xROW = xROW + 1

                        End If
                    Next
                End If

        End Select

        Vs1.Focus()

        vSChange(e.Row)
    End Sub

    Private Sub cmd_Print_PA_Click(sender As Object, e As EventArgs) Handles cmd_Print_PA.Click
        Dim f As New Form
        f = Me.FindForm

        Pub.CLI = "1"

        If READ_FROM_MULTI(f.Tag) Then Pub.CLI = "2"

        If Pub.CLI = "1" Then
            If Not f.Tag Is Nothing Then
                If READ_SHEETPRINT_MATCHING(f.Tag) = True Then
                    If SheetReport.Link_SheetReport(3, f.Tag, f) = True Then

                        If READ_SHEETPRINT_MATCHING_MULTI(f.Tag, SheetReportName) = True Then
                            ChuoiValue1 = ""
                            ChuoiValue2 = ""

                            If PRINTSHEET_MULTI.Link_PrintSheet(SheetReportName, ChuoiValue1, ChuoiValue2, f) = True Then
                            End If
                        Else
                            ChuoiValue1 = ""
                            ChuoiValue2 = ""

                            If GETCHUOI1(ChuoiValue1, SheetReportName) = False Then Exit Sub

                            If GETCHUOI2_01(f, ChuoiValue2, SheetReportName, ChuoiValue1) = False Then Exit Sub

                            If PRINTSHEET_PA.Link_PRINTSHEET_PA(txt_PayableNo.Data, SheetReportName, ChuoiValue1, ChuoiValue2) = True Then

                            End If
                        End If
                    End If
                Else

                End If
            Else

            End If

        ElseIf Pub.CLI = "2" Then
            If PRINTSHEET_NEW_F1.Link_SheetReport(3, f.Tag, f) = True Then

            End If
        End If
    End Sub
#End Region
    

    
End Class