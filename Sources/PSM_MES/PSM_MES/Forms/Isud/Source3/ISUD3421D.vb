Public Class ISUD3421D

#Region "Variable"
    Private wJOB As Integer

    Private W3421 As New T3421_AREA
    Private L3421 As New T3421_AREA

    Private W3422 As New T3422_AREA
    Private L3422 As New T3422_AREA

    Private W3424 As New T3424_AREA

    Private W3011 As New T3011_AREA
    Private W7113 As New T7113_AREA

    Private WRITE_CHK As String
    Private formA As Boolean
    Private CHK(0 To 5) As String

    Private _chk_CheckIOType As String
    Private _chk_CheckPurchasingOrder As String
    Private _cdSubProcess As String
    Private _chkProcessName As String

#End Region

#Region "Link"
    Public Function Link_ISUD3421D(job As Integer, FactOrderNo As String, chk_CheckIOType As String, chk_CheckPurchasingOrder As String, Optional ByVal TAG As String = "", Optional ByVal link_Subprocess As String = "", Optional ByVal link_ProcessName As String = "") As Boolean
        Link_ISUD3421D = False

        Me.Tag = TAG

        D3421.FactOrderNo = FactOrderNo
        D3422.FactOrderNo = FactOrderNo

        _chk_CheckIOType = chk_CheckIOType
        _chk_CheckPurchasingOrder = chk_CheckPurchasingOrder

        _chkProcessName = link_ProcessName  '"PLAN", "OUTSOLE"

        If link_Subprocess = "" Then
            _cdSubProcess = ""
        Else
            _cdSubProcess = link_Subprocess
        End If

        wJOB = job : L3421 = D3421 : L3422 = D3422

        Try

            Select Case job
                Case 1
                Case Else
                    If READ_PFK3421(L3421.FactOrderNo) = False Then
                        Call MsgBoxP("3", "LINK_ISUD")

                        Me.Dispose()
                        Exit Function
                    Else
                        L3421 = D3421
                    End If
                    txt_DateAccept.Enabled = False
            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD3421D = isudCHK


        Catch ex As Exception
            Call MsgBoxP("61", WordConv("Request Order Processing"))
        End Try


    End Function

    Public Function Link_ISUD3421D_INSERT(job As Integer, cdSubProcess As String, FactOrderNo As String, chk_CheckIOType As String, chk_CheckPurchasingOrder As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        D3421.FactOrderNo = FactOrderNo
        D3422.FactOrderNo = FactOrderNo

        _chk_CheckIOType = chk_CheckIOType
        _chk_CheckPurchasingOrder = chk_CheckPurchasingOrder
        _cdSubProcess = cdSubProcess

        wJOB = job : L3421 = D3421 : L3422 = D3422

        Link_ISUD3421D_INSERT = False
        Try

            Select Case job
                Case 1
                Case Else
                    If READ_PFK3421(L3421.FactOrderNo) = False Then
                        Call MsgBoxP("3", "LINK_ISUD")

                        Me.Dispose()
                        Exit Function
                    Else
                        L3421 = D3421
                    End If
                    txt_DateAccept.Enabled = False
            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD3421D_INSERT = isudCHK


        Catch ex As Exception
            Call MsgBoxP("61", WordConv("Request Order Processing"))
        End Try


    End Function

#End Region

#Region "Form"
    Private Sub Form_Activate(sender As Object, e As EventArgs) Handles Me.Load
        If formA = True Then Exit Sub

        WRITE_CHK = ""
        Me.Form_KeyDown()

        Call DATA_INIT()
        Call FORM_INIT()

        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

        Select Case wJOB
            Case 1
                Me.Text = Me.Text & " - INSERT"
                tst_iDelete.Visible = False

                If CHK(1) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call KEY_COUNT()

                Call DATA_SEARCH_VS1()
                Call HideColumn()
                Setfocus(txt_cdSite)
            Case 2
                Me.Text = Me.Text & " - SEARCH"
                If CHK(2) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                pcl_CheckField.Enabled = True

                tst_iDelete.Visible = False
                tst_iSave.Visible = False

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS1()

                Call HideColumn()

                '-------------------------------------------------------------------------------------------------- Start
                ' Data Check ==>> Customer, Department

                If CheckData_Customer(Me.FindForm.FindCode("CustomerCode").Code(), wJOB) = False Then
                    isudCHK = False
                    formA = True
                    MsgBoxP("No Correct Customer !")
                    Exit Sub
                End If


                If _chk_CheckIOType = "1" Then
                    If CheckData_Department(Me.FindForm.FindCode("cdDepartment").Code(), wJOB) = False Then
                        isudCHK = False
                        formA = True
                        MsgBoxP("No Correct Department !")
                        Exit Sub
                    End If
                End If
                '-------------------------------------------------------------------------------------------------- End

            Case 3
                Me.Text = Me.Text & " - UPDATE"
                If CHK(3) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                pcl_CheckField.Enabled = True
                txt_FactOrderNo.Enabled = False

                tst_iDelete.Visible = False

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS1()
                Call HideColumn()

                '-------------------------------------------------------------------------------------------------- Start
                ' Data Check ==>> Customer, Department
                If CheckData_Customer(Me.FindForm.FindCode("CustomerCode").Code(), wJOB) = False Then
                    isudCHK = False
                    formA = True
                    MsgBoxP("No Correct Customer !")
                    Exit Sub
                End If

                If _chk_CheckIOType = "1" Then
                    If CheckData_Department(Me.FindForm.FindCode("cdDepartment").Code(), wJOB) = False Then
                        isudCHK = False
                        formA = True
                        MsgBoxP("No Correct Department !")
                        Exit Sub
                    End If
                End If
                '-------------------------------------------------------------------------------------------------- End

                Setfocus(txt_cdSite)
            Case 4
                Me.Text = Me.Text & " - DELETE"

                If CHK(4) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                pcl_CheckField.Enabled = True
                tst_iSave.Visible = False

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS1()
                Call HideColumn()

                '-------------------------------------------------------------------------------------------------- Start
                ' Data Check ==>> Customer, Department

                If CheckData_Customer(Me.FindForm.FindCode("CustomerCode").Code(), wJOB) = False Then
                    isudCHK = False
                    formA = True
                    MsgBoxP("No Correct Customer !")
                    Exit Sub
                End If

                If _chk_CheckIOType = "1" Then
                    If CheckData_Department(Me.FindForm.FindCode("cdDepartment").Code(), wJOB) = False Then
                        isudCHK = False
                        formA = True
                        MsgBoxP("No Correct Department !")
                        Exit Sub
                    End If
                End If
                '-------------------------------------------------------------------------------------------------- End
            Case 5
                Me.Text = Me.Text & " - UPDATE AFTER"

                If CHK(3) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                txt_FactOrderNo.Enabled = False
                pcl_CheckField.Enabled = True

                tst_iDelete.Visible = False

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS1()
                Call HideColumn()

                Setfocus(txt_cdSite)
            Case 6
                Me.Text = Me.Text & " - COPY"
                If CHK(1) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                txt_FactOrderNo.Enabled = False
                pcl_CheckField.Enabled = True

                tst_iDelete.Visible = False

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS1()
                Call HideColumn()

                Call KEY_COUNT()
                wJOB = 1

                Setfocus(txt_cdSite)
        End Select

        formA = True
        If wJOB = 1 Then txt_DateExchange.Data = Pub.DAT

    End Sub
#End Region

#Region "Search"
    Private Function DATA_SEARCH01() As Boolean
        DATA_SEARCH01 = False

        DS1 = PrcDS("USP_ISUD3421D_SEARCH_HEAD", cn, L3421.FactOrderNo)

        If GetDsRc(DS1) = 0 Then
            Exit Function
            isudCHK = False
        End If

        Call STORE_MOVE(Me, DS1)

        txt_SupplierCode.Data = GetDsData(DS1, 0, "SupplierName")
        txt_SupplierCode.Code = GetDsData(DS1, 0, "SupplierCode")

        CheckProcessType(GetDsData(DS1, 0, "CheckProcessType"))
        CheckIOType(GetDsData(DS1, 0, "CheckIOType"))
        CheckMaterialType(GetDsData(DS1, 0, "CheckMaterialType"))
        CheckMarketType(GetDsData(DS1, 0, "CheckMarketType"))
        CheckRelationType(GetDsData(DS1, 0, "CheckRelationType"))

        cmb_CheckInPurchasingOrder.InSelected = CIntp_S(GetDsData(DS1, 0, "CheckInPurchasingOrder")) - 1
        cmb_CheckOutPurchasingOrder.InSelected = CIntp_S(GetDsData(DS1, 0, "CheckOutPurchasingOrder")) - 1

        DATA_SEARCH01 = True

    End Function

    Private Function DATA_SEARCH_VS1() As Boolean
        DATA_SEARCH_VS1 = False
        Try
            Dim i As Integer

            'MR.SON FIX
            _chk_CheckPurchasingOrder = "1"

            DS1 = PrcDS("USP_ISUD3421D_SEARCH_VS1_" & _chk_CheckIOType & _chk_CheckPurchasingOrder, cn, L3421.FactOrderNo)
            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs1, DS1, "USP_ISUD3421D_SEARCH_VS1_" & _chk_CheckIOType & _chk_CheckPurchasingOrder, "Vs1")
                Vs1.ActiveSheet.RowCount = 1
                Vs1.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(Vs1, DS1, "USP_ISUD3421D_SEARCH_VS1_" & _chk_CheckIOType & _chk_CheckPurchasingOrder, "Vs1")

            If wJOB <> 6 Then
                For i = 0 To Vs1.ActiveSheet.RowCount - 1

                    If CDblp(getData(Vs1, getColumIndex(Vs1, "CheckPurchasing"), i)) <> "1" Then
                        Call SPR_LOCK(Vs1, i)
                        Call SPR_BACKCOLOR(Vs1, Color.Pink, i)
                        If wJOB <> 5 Then
                            Call DisableAllType()

                            pan_Process.Enabled = False
                            pan_ioType.Enabled = False
                            pan_FabricType.Enabled = False
                            pan_MarketType.Enabled = False
                        End If


                    End If

                    If CDblp(getData(Vs1, getColumIndex(Vs1, "QtyWarehouse"), i)) > 0 Then
                        pan_Process.Enabled = False
                        pan_ioType.Enabled = False
                    End If

                    If i = 0 Then
                        txt_cdSubProcess.Data = GetDsData(DS1, i, "cdSubProcessName")
                        txt_cdSubProcess.Code = GetDsData(DS1, i, "cdSubProcess")
                    End If

                Next

                If wJOB = "5" Then
                    For i = 0 To Vs1.ActiveSheet.RowCount - 1
                        Vs1.ActiveSheet.Cells(i, getColumIndex(Vs1, "CLcdUnitPrice")).Locked = False
                        Vs1.ActiveSheet.Cells(i, getColumIndex(Vs1, "PricePurchasing")).Locked = False
                    Next
                    'SPR_ChkLock(Vs1, False, getColumIndex(Vs1, "CLcdUnitPrice"), getColumIndex(Vs1, "PricePurchasing"))
                End If
            Else

                Call READ_PFK7171(ListCode("SubProcess"), _cdSubProcess)

                For i = 0 To Vs1.ActiveSheet.RowCount - 1
                    setData(Vs1, getColumIndex(Vs1, "cdSubProcess"), i, D7171.BasicCode)
                    setData(Vs1, getColumIndex(Vs1, "cdSubProcessName"), i, D7171.BasicName)
                Next


            End If

            DATA_SEARCH_VS1 = True

        Catch ex As Exception

        End Try
    End Function


#End Region

#Region "Function"
    Private Sub CheckProcessType(Process As String)
        Select Case Process
            Case "1" : rad_CheckProcessType1.Checked = True
            Case "2" : rad_CheckProcessType2.Checked = True
            Case Else : rad_CheckProcessType1.Checked = True
        End Select
    End Sub
    Private Sub CheckIOType(IOType As String)
        Select Case IOType
            Case "1" : rad_CheckIOType1.Checked = True : cmb_CheckInPurchasingOrder.Visible = True : cmb_CheckOutPurchasingOrder.Visible = False
            Case "2" : rad_CheckIOType2.Checked = True : cmb_CheckInPurchasingOrder.Visible = False : cmb_CheckOutPurchasingOrder.Visible = True
            Case Else : rad_CheckIOType1.Checked = True : cmb_CheckInPurchasingOrder.Visible = True : cmb_CheckOutPurchasingOrder.Visible = False
        End Select
    End Sub

    Private Sub CheckMaterialType(MaterialType As String)
        Select Case MaterialType
            Case "1" : rad_CheckMaterialType1.Checked = True
            Case "2" : rad_CheckMaterialType2.Checked = True
            Case Else : rad_CheckMaterialType1.Checked = True
        End Select
    End Sub

    Private Sub CheckRelationType(RelationType As String)
        Select Case RelationType
            Case "1" : rad_CheckRelationType1.Checked = True
            Case "2" : rad_CheckRelationType2.Checked = True
            Case Else : rad_CheckRelationType1.Checked = True
        End Select
    End Sub

    Private Sub CheckMarketType(Market As String)
        Select Case Market
            Case "1" : rad_CheckMarketType1.Checked = True
            Case "2" : rad_CheckMarketType2.Checked = True
            Case Else : rad_CheckMarketType1.Checked = True
        End Select
    End Sub
    Private Sub DATA_MOVE_DEFAULT()
        W3421.seBuyingType = ListCode("BuyingType")
        W3421.seCommercialTerm = ListCode("CommercialTerm")
        W3421.selUnitPrice = ListCode("UnitPrice")
        W3421.seOrigin = ListCode("Origin")
        W3421.seSeason = ListCode("Season")
        W3421.seSite = ListCode("Site")

        W3421.seDeliveryTerm = ListCode("DeliveryTerm")
        W3421.sePaymentTerm = ListCode("PaymentTerm")
        W3421.sePaymentCondition = ListCode("PaymentCondition")
        W3421.sePaymentTime = ListCode("PaymentTime")
        W3421.sePaymentDay = ListCode("PaymentDay")

        W3422.seOrigin = ListCode("Origin")
        W3422.seTax = ListCode("Tax")

        W3422.seTax1 = ListCode("Tax1")
        W3422.seTax2 = ListCode("Tax2")
        W3422.seTax3 = ListCode("Tax3")

        W3422.seUnitMaterial = ListCode("UnitMaterial")
        W3422.seUnitPacking = ListCode("UnitPacking")
        W3422.seUnitPrice = ListCode("UnitPrice")
        W3422.seSite = ListCode("Site")
        W3422.seDepartment = ListCode("Department")

        W3422.seSubProcess = ListCode("SubProcess")
        W3422.seLineProd = ListCode("LineProd")
        W3422.seFactory = ListCode("Factory")

    End Sub

    Private Sub DATA_MOVE_WRITE01()
        Dim i As Integer
        Dim j As Integer
        Dim tComponentName As String = ""

        j = 0

        For i = 0 To Vs1.ActiveSheet.RowCount - 1
            If Trim(getData(Vs1, getColumIndex(Vs1, "MaterialCode"), i)) = "" Then GoTo skip

            If i = 0 Then tComponentName = getData(Vs1, getColumIndex(Vs1, "ComponentName"), i)

            j = j + 1
            If K3422_MOVE(Vs1, i, W3422, L3422.FactOrderNo, getData(Vs1, getColumIndex(Vs1, "KEY_FactOrderSeq"), i)) = True Then
                W3422.Dseq = j

                If rad_CheckRelationType1.Checked = True Then W3422.CheckRelationType = "1"
                If rad_CheckRelationType2.Checked = True Then W3422.CheckRelationType = "2"

                W3422.QtyPurchasing = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyPurchasing"), i))
                W3422.PackPurchasing = CDecp(getData(Vs1, getColumIndex(Vs1, "PackPurchasing"), i))
                W3422.QtyBasic = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyBasic"), i))
                W3422.ComponentName = getData(Vs1, getColumIndex(Vs1, "ComponentName"), i)

                W3422.cdSubProcess = txt_cdSubProcess.Code
             
                W3422.OrderNo = getData(Vs1, getColumIndex(Vs1, "OrderNo"), i)
                W3422.OrderNoSeq = getData(Vs1, getColumIndex(Vs1, "OrderNoSeq"), i)

                If Trim((getData(Vs1, getColumIndex(Vs1, "ComponentName"), i))) = "" Then W3422.DateDelivery = txt_DateDelivery.Data

                If Trim((getData(Vs1, getColumIndex(Vs1, "DateDelivery"), i))) = "" Then W3422.DateDelivery = txt_DateDelivery.Data
                If Trim((getData(Vs1, getColumIndex(Vs1, "DateStart"), i))) = "" Then W3422.DateStart = txt_DateStart.Data
                If Trim((getData(Vs1, getColumIndex(Vs1, "DateFinish"), i))) = "" Then W3422.DateFinish = txt_DateFinish.Data

                If W3422.CustomerSupplier = "" Then W3422.CustomerSupplier = txt_SupplierCode.Code
                If W3422.cdSite = "" Then W3422.cdSite = "001"

                W3422.PriceExchange = CDecp(txt_PriceExchange.Data)
                W3422.DateExchange = txt_DateExchange.Data

                If READ_PFK3011(W3422.AutokeyK3011) Then
                    W3011 = D3011
                    W3011.QtyRequest = W3422.QtyPurchasing
                    Call REWRITE_PFK3011(W3011)
                End If

                W3422.cdDepartment = txt_cdDepartment.Code

                W3422.PricePurchasingEX = W3422.PricePurchasing
                W3422.PricePurchasingVND = W3422.PricePurchasing * W3422.PriceExchange

                W3422.AmountPurchasingEX = W3422.PricePurchasing * W3422.QtyPurchasing
                W3422.AmountPurchasingVND = W3422.PricePurchasing * W3422.QtyPurchasing * W3422.PriceExchange

                If txt_cdUnitPrice.Code = "001" Then
                    W3422.AmountTax3 = W3422.PricePurchasing * W3422.QtyPurchasing * 0.1
                    W3422.AmountTaxVND = W3422.PricePurchasing * W3422.QtyPurchasing * 0.1

                    W3422.AmountTaxEX = W3422.AmountTaxVND

                End If

                W3422.AmountEX = W3422.AmountPurchasingEX
                W3422.AmountVND = W3422.AmountPurchasingVND + W3422.AmountTaxVND

                Call DATA_MOVE_DEFAULT()
                Call REWRITE_PFK3422(W3422)
            Else
                W3422.FactOrderNo = L3421.FactOrderNo
                W3422.Dseq = j

                Call KEY_COUNT_3422()

                W3422.CheckPurchasing = "1"
                W3422.DateAccept = txt_DateAccept.Data

                If W3422.CustomerSupplier = "" Then W3422.CustomerSupplier = txt_SupplierCode.Code
                If W3422.cdSite = "" Then W3422.cdSite = "001"

                W3422.PriceExchange = CDecp(txt_PriceExchange.Data)
                W3422.DateExchange = txt_DateExchange.Data

                W3422.QtyPurchasing = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyPurchasing"), i))
                W3422.PackPurchasing = CDecp(getData(Vs1, getColumIndex(Vs1, "PackPurchasing"), i))
                W3422.QtyBasic = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyBasic"), i))
                W3422.ComponentName = getData(Vs1, getColumIndex(Vs1, "ComponentName"), i)

                W3422.OrderNo = getData(Vs1, getColumIndex(Vs1, "OrderNo"), i)
                W3422.OrderNoSeq = getData(Vs1, getColumIndex(Vs1, "OrderNoSeq"), i)

                W3422.CheckComplete = "2"

                If rad_CheckRelationType1.Checked = True Then W3422.CheckRelationType = "1"
                If rad_CheckRelationType2.Checked = True Then W3422.CheckRelationType = "2"

                If Trim((getData(Vs1, getColumIndex(Vs1, "DateDelivery"), i))) = "" Then W3422.DateDelivery = txt_DateDelivery.Data
                If Trim((getData(Vs1, getColumIndex(Vs1, "DateStart"), i))) = "" Then W3422.DateStart = txt_DateStart.Data
                If Trim((getData(Vs1, getColumIndex(Vs1, "DateFinish"), i))) = "" Then W3422.DateFinish = txt_DateFinish.Data

                W3422.cdSubProcess = txt_cdSubProcess.Code

                If tComponentName <> "" Then
                    If W3422.ComponentName = "" Then W3422.ComponentName = tComponentName
                End If

                If READ_PFK3011(W3422.AutokeyK3011) Then
                    W3011 = D3011
                    W3011.QtyRequest = W3422.QtyPurchasing

                    Call REWRITE_PFK3011(W3011)
                End If

                W3422.cdDepartment = txt_cdDepartment.Code

                Call DATA_MOVE_DEFAULT()
                Call WRITE_PFK3422(W3422)
            End If
skip:

        Next

    End Sub

    Private Sub DATA_UPDATE_SIZERANGE()
        Try
            Call PrcExeNoError(" EXP_CLOSSING_PFK3422D_PRICE", cn, txt_FactOrderNo.Data)
            Exit Sub

        Catch ex As Exception

        End Try

    End Sub

    Private Sub DATA_INSERT()

        Try
            If K3421_MOVE(Me, W3421, 1, L3421.FactOrderNo) = False Then

                Call KEY_COUNT()

                If rad_CheckRelationType1.Checked = True Then W3421.CheckRelationType = "1"
                If rad_CheckRelationType2.Checked = True Then W3421.CheckRelationType = "2"

                If rad_CheckProcessType1.Checked = True Then W3421.CheckProcessType = "1"
                If rad_CheckProcessType2.Checked = True Then W3421.CheckProcessType = "2"

                If rad_CheckIOType1.Checked = True Then W3421.CheckIOType = "1"
                If rad_CheckIOType2.Checked = True Then W3421.CheckIOType = "2"

                If rad_CheckMaterialType1.Checked = True Then W3421.CheckMaterialType = "1"
                If rad_CheckMaterialType2.Checked = True Then W3421.CheckMaterialType = "2"

                If rad_CheckMarketType1.Checked = True Then W3421.CheckMarketType = "1"
                If rad_CheckMarketType2.Checked = True Then W3421.CheckMarketType = "2"

                W3421.CheckInPurchasingOrder = cmb_CheckInPurchasingOrder.InSelected + 1
                W3421.CheckOutPurchasingOrder = cmb_CheckOutPurchasingOrder.InSelected + 1

                Call DATA_MOVE_DEFAULT()

                If WRITE_PFK3421(W3421) = True Then
                    Call DATA_MOVE_WRITE01()
                    Call DATA_UPDATE_SIZERANGE()
                    isudCHK = True : WRITE_CHK = "*"
                    Exit Sub
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub DATA_UPDATE()
        Try
            If K3421_MOVE(Me, W3421, 3, L3421.FactOrderNo) = True Then
                If rad_CheckProcessType1.Checked = True Then W3421.CheckProcessType = "1"
                If rad_CheckProcessType2.Checked = True Then W3421.CheckProcessType = "2"

                If rad_CheckIOType1.Checked = True Then W3421.CheckIOType = "1"
                If rad_CheckIOType2.Checked = True Then W3421.CheckIOType = "2"

                If rad_CheckMaterialType1.Checked = True Then W3421.CheckMaterialType = "1"
                If rad_CheckMaterialType2.Checked = True Then W3421.CheckMaterialType = "2"

                If rad_CheckMarketType1.Checked = True Then W3421.CheckMarketType = "1"
                If rad_CheckMarketType2.Checked = True Then W3421.CheckMarketType = "2"

                If rad_CheckRelationType1.Checked = True Then W3421.CheckRelationType = "1"
                If rad_CheckRelationType2.Checked = True Then W3421.CheckRelationType = "2"

                W3421.CheckInPurchasingOrder = cmb_CheckInPurchasingOrder.InSelected + 1
                W3421.CheckOutPurchasingOrder = cmb_CheckOutPurchasingOrder.InSelected + 1

                Call DATA_MOVE_DEFAULT()
                If REWRITE_PFK3421(W3421) = True Then
                    Call DATA_MOVE_WRITE01()
                    Call DATA_UPDATE_SIZERANGE()
                    isudCHK = True
                End If
            End If
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_UPDATE")
        End Try
    End Sub

    Private Sub DATA_UPDATE_AFTER()
        Try
            If READ_PFK3421(L3421.FactOrderNo) = True Then
                W3421 = D3421
                W3421.Remark = txt_Remark.Data

                If REWRITE_PFK3421(W3421) = True Then

                    Call DATA_MOVE_WRITE01()
                    Call DATA_UPDATE_SIZERANGE()
                    isudCHK = True
                    Me.Dispose()
                End If
            End If

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_UPDATE")
        End Try
    End Sub
    Private Sub DATA_DELETE()
        Dim i As Integer

        Try
            For i = 0 To Vs1.ActiveSheet.RowCount - 1
                If getDataM(Vs1, getColumIndex(Vs1, "Dchk"), i) = "1" Then
                    If DATA_LINE_DELETE(i) = False Then Exit Sub
                End If
            Next

            If READ_PFK3422_1(L3421.FactOrderNo) = False Then
                If READ_PFK3421(L3421.FactOrderNo) = True Then
                    W3421 = D3421

                    If DELETE_PFK3421(W3421) = True Then
                        isudCHK = True
                        Me.Dispose()
                    End If

                End If
            End If

        Catch ex As Exception
            Call MsgBoxP("38", "DATA_DELETE")
        End Try

    End Sub
    Private Function DATA_LINE_DELETE(xrow As Integer) As Boolean
        DATA_LINE_DELETE = False

        Try
            If READ_PFK3422(getData(Vs1, getColumIndex(Vs1, "KEY_FactOrderNo"), xrow),
                            getData(Vs1, getColumIndex(Vs1, "KEY_FactOrderSeq"), xrow)) = True Then

                W3422 = D3422

                'If W3422.CheckPurchasing <> "1" Then MsgBoxP("Can not delete this ! This is Valided order !") : Exit Function
                'If W3422.QtyWarehouse > 0 Then MsgBoxP("Can not Delete because of InBound Data") : Exit Function

                If READ_PFK3011(W3422.AutokeyK3011) Then
                    W3011 = D3011
                    W3011.QtyRequest = 0

                    Call REWRITE_PFK3011(W3011)
                End If

                If DELETE_PFK3422(W3422) = True Then

                    Call Delete_History("PFK3422", W3422.FactOrderNo & "-" & W3422.FactOrderSeq.ToString)

                    isudCHK = True
                End If
            End If
            DATA_LINE_DELETE = True
        Catch ex As Exception
            Call MsgBoxP("38", "DATA_DELETE")
        End Try

    End Function


    Private Function CheckSamePO(FactFactOrderNo As String, FactFactOrderSeq As String) As Boolean
        CheckSamePO = True
        Dim i As Integer
        Try
            For i = 0 To Vs1.ActiveSheet.RowCount - 1
                If getData(Vs1, getColumIndex(Vs1, "FactFactOrderNo"), i) = FactFactOrderNo _
                    And getData(Vs1, getColumIndex(Vs1, "FactFactOrderSeq"), i) = FactFactOrderSeq Then
                    CheckSamePO = False
                    MsgBoxP("Already Data! No again!") : Exit Function
                End If
            Next

        Catch ex As Exception

        End Try



    End Function
    Private Sub KEY_COUNT()
        Dim YRNO As Integer
        YRNO = Mid(Pub.DAT, 3, 2)
        Dim Prefix As String = "PS"

        If _chk_CheckIOType = "1" Then

            Select Case _chk_CheckPurchasingOrder
                Case "1" : Prefix = "PS"
                Case "2" : Prefix = "PB"
                Case "3" : Prefix = "PP"
                Case "4" : Prefix = "RI"
                Case "5" : Prefix = "RO"
                Case "6" : Prefix = "RS"
                Case "7" : Prefix = "RT"
                Case "8" : Prefix = "RP"
            End Select

        ElseIf _chk_CheckIOType = "2" Then
            Select Case _chk_CheckPurchasingOrder
                Case "1" : Prefix = "OI"
                Case "2" : Prefix = "OB"
                Case "3" : Prefix = "OS"
                Case "4" : Prefix = "OT"
                Case "5" : Prefix = "OO"
                Case "6" : Prefix = "OP"
            End Select

        End If

        Try
            SQL = "SELECT MAX(CAST(SUBSTRING(K3421_FactOrderNo,5,5) AS DECIMAL)) AS MAX_MCODE FROM PFK3421 "
            SQL = SQL & " WHERE SUBSTRING(K3421_FactOrderNo,3,2) = '" & YRNO.ToString & "' "
            SQL = SQL & " AND SUBSTRING(K3421_FactOrderNo,1,2) = '" & Prefix & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                W3421.FactOrderNo = Prefix & YRNO & "00001"
            Else
                W3421.FactOrderNo = Prefix & YRNO & Format(CInt(rd!MAX_MCODE + 1), "00000")
            End If

            rd.Close()

            txt_FactOrderNo.Data = W3421.FactOrderNo
            L3421.FactOrderNo = W3421.FactOrderNo

            L3422.FactOrderNo = W3421.FactOrderNo
            W3422.FactOrderNo = W3421.FactOrderNo
        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub
    Private Sub KEY_COUNT_3422()
        Try

            SQL = "SELECT MAX(CAST(K3422_FactOrderSeq AS DECIMAL)) AS MAX_MCODE FROM PFK3422 "
            SQL = SQL & " WHERE K3422_FactOrderNo = '" & L3422.FactOrderNo & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                W3422.FactOrderSeq = 1
            Else
                W3422.FactOrderSeq = CIntp(rd!MAX_MCODE + 1)
            End If

            rd.Close()

            L3422.FactOrderSeq = W3422.FactOrderSeq

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub
    Private Sub DATA_INIT()
        Try



            If wJOB = "1" Or wJOB = "6" Then

                If READ_PFK7411(Pub.SAW) Then
                    txt_InchargePurchasing.Data = D7411.Name
                    txt_InchargePurchasing.Code = D7411.IDNO
                    txt_InchargePurchasing.Enabled = False
                End If
            End If

            If _chk_CheckIOType = "1" Then
                rad_CheckIOType1.Checked = True : cmb_CheckInPurchasingOrder.Visible = True : cmb_CheckInPurchasingOrder.Enabled = False
            End If

            If _chk_CheckIOType = "2" Then
                rad_CheckIOType2.Checked = True : cmb_CheckOutPurchasingOrder.Visible = True : cmb_CheckInPurchasingOrder.Enabled = False
            End If

            If _chk_CheckIOType = "1" Then cmb_CheckInPurchasingOrder.InSelected = CIntp_S(_chk_CheckPurchasingOrder) - 1
            If _chk_CheckIOType = "2" Then cmb_CheckOutPurchasingOrder.InSelected = CIntp_S(_chk_CheckPurchasingOrder) - 1


            rad_CheckProcessType2.Checked = True

            Select Case Tag
                Case "PFP34219_PLAI1"

                Case "PFP34219_PLAI2"


                Case "PFP34219_PLAI3"
                Case "PFP34219_PLAI4"
                Case "PFP34219_PLAI5"
                Case "PFP34219_PLAI6"
                Case "PFP34219_PLAI7"
                Case "PFP34219_PLAI8"

                Case "PFP34219_PLAO1"
                Case "PFP34219_PLAO2"
                Case "PFP34219_PLAO3"
                Case "PFP34219_PLAO4"
                Case "PFP34219_PLAO5"
                Case "PFP34219_PLAO6"

                    ' OUTSOLE InBound 
                Case "PFP34218_SOLEI1"

                Case "PFP34218_SOLEI2"

                Case "PFP34218_SOLEI3"
                Case "PFP34218_SOLEI4"
                Case "PFP34218_SOLEI5"
                Case "PFP34218_SOLEI6"
                Case "PFP34218_SOLEI7"
                Case "PFP34218_SOLEI8"

                Case "PFP34218_SOLEO1"
                Case "PFP34218_SOLEO2"
                Case "PFP34218_SOLEO3"
                Case "PFP34218_SOLEO4"
                Case "PFP34218_SOLEO6"

            End Select

            txt_FactOrderNo.Enabled = False

            pan_ioType.Enabled = False

            cmb_CheckInPurchasingOrder.Visible = True
            cmb_CheckOutPurchasingOrder.Visible = False

            pan_Process.Enabled = False

            rad_CheckRelationType2.Checked = True
            rad_CheckRelationType1.Checked = False

            rad_CheckRelationType2.Enabled = False
            rad_CheckRelationType1.Enabled = False

            txt_DateAccept.Data = Pub.DAT
            txt_DateDelivery.Data = Pub.DAT
            txt_DateExchange.Data = Pub.DAT
            txt_DateFinish.Data = Pub.DAT
            txt_DateStart.Data = Pub.DAT

            txt_DatePosted.Data = Pub.DAT

            txt_PriceExchange.Data = 1
            txt_cdUnitPrice.Data = "VND"
            txt_cdUnitPrice.Code = "001"

            Setfocus(txt_cdBuyingType)
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INIT")
        End Try

    End Sub

    Private Sub FORM_INIT()
        cmb_CheckInPurchasingOrder.Enabled = False
        cmb_CheckOutPurchasingOrder.Enabled = False
    End Sub

    Private Function Data_Check() As Boolean
        Data_Check = False
        Dim i As Integer
        Dim AmtBegin As Decimal
        Dim AmtEnd As Decimal

        If txt_cdUnitPrice.Code = "001" Then txt_PriceExchange.Data = "1" : txt_cdUnitPrice.Data = "VND"

        If txt_cdUnitPrice.Code <> "001" Then
            If READ_PFK7171(ListCode("UnitPrice"), txt_cdUnitPrice.Code) Then
                AmtBegin = CDecp(D7171.CheckName9)
                AmtEnd = CDecp(D7171.CheckName10)

                If CDecp(txt_PriceExchange.Data) < AmtBegin Or CDecp(txt_PriceExchange.Data) > AmtEnd Then MsgBoxEx("Wrong Price Exchange!") : Setfocus(txt_PriceExchange) : Exit Function

            End If
        End If

        Try
            For i = 0 To Vs1.ActiveSheet.RowCount - 1
                If FormatCut(getData(Vs1, getColumIndex(Vs1, "JobCard"), i)) = "" Then MsgBoxP("JobCard Name at Line" & (i + 1)) : Exit Function
                If CDecp(getData(Vs1, getColumIndex(Vs1, "QtyPurchasing"), i)) = 0 Then MsgBoxP("Qty at Line" & (i + 1)) : Exit Function

                'If FormatCut(getData(Vs1, getColumIndex(Vs1, "cdUnitPacking"), i)) = "" Then MsgBoxP("Unit Packing at Line" & (i + 1)) : Exit Function

            Next

            Data_Check = True
        Catch ex As Exception

        End Try
    End Function

    Private Sub HideColumn()
       
    End Sub

#End Region

#Region "Event"
    Private Sub tst_iSave_Click(sender As Object, e As EventArgs) Handles tst_iSave.Click
        Select Case wJOB
            Case 1
                '---------------Data Check ==>>  Insert 
                If CheckData_Department(Me.FindForm.FindCode("cdDepartment").Code(), wJOB) = False Then
                    MsgBox("No Correct Department !")
                    Exit Sub
                End If

                If CheckData_Customer(Me.FindForm.FindCode("CustomerCode").Code(), wJOB) = False Then
                    MsgBox("No Correct Customer !")
                    Exit Sub
                End If

                If CheckData_Incharge(Me.FindForm.FindCode("InchargePurchasing").Code(), wJOB) = False Then
                    MsgBox("No Correct InchargePurchasing !")
                    Exit Sub
                End If
                '----------------------------------------------------------------------------------------------------------

                If DataCheck(Me, "PFK3421") = False Then Exit Sub
                If Data_Check() = False Then Exit Sub
                Call KEY_COUNT()
                Call DATA_INSERT()
                Call DATA_UPDATE_SIZERANGE()

                wJOB = 3
                Call DATA_SEARCH_VS1()
                Call HideColumn()

            Case 2
                Me.Dispose()
            Case 3
                '---------------Data Check ----------------------------------------------------------------------------------
                If CheckData_Incharge(Me.FindForm.FindCode("InchargePurchasing").Code(), wJOB) = False Then
                    MsgBox("No Correct InchargePurchasing !")
                    Exit Sub
                End If
                '----------------------------------------------------------------------------------------------------------

                If DataCheck(Me, "PFK3421") = False Then Exit Sub
                If Data_Check() = False Then Exit Sub

                If READ_PFK3429_FactOrder(txt_FactOrderNo.Data, "") = True Then
                    MsgBox("Already make Payable can't modify !")
                    Exit Sub
                End If

                Call DATA_UPDATE()
                Call DATA_SEARCH_VS1()

            Case 4
                '---------------Data Check ----------------------------------------------------------------------------------
                If CheckData_Incharge(Me.FindForm.FindCode("InchargePurchasing").Code(), wJOB) = False Then
                    MsgBox("No Correct InchargePurchasing !")
                    Exit Sub
                End If

                If READ_PFK3429_FactOrder(txt_FactOrderNo.Data, "") = True Then
                    MsgBox("Already make Payable can't modify !")
                    Exit Sub
                End If

                '----------------------------------------------------------------------------------------------------------
                Call DATA_DELETE()

            Case 5
                '---------------Data Check ----------------------------------------------------------------------------------
                If CheckData_Incharge(Me.FindForm.FindCode("InchargePurchasing").Code(), wJOB) = False Then
                    MsgBox("No Correct InchargePurchasing !")
                    Exit Sub
                End If

                If READ_PFK3429_FactOrder(txt_FactOrderNo.Data, "") = True Then
                    MsgBox("Already make Payable can't modify !")
                    Exit Sub
                End If

                '----------------------------------------------------------------------------------------------------------
                Call DATA_UPDATE_AFTER()
        End Select
    End Sub

    Private Sub tst_iClose_Click(sender As Object, e As EventArgs) Handles tst_iClose.Click
        If WRITE_CHK = "*" Then
            isudCHK = True
        Else
            isudCHK = False
        End If

        Me.Dispose()
    End Sub

    Private Sub tst_iDelete_Click(sender As Object, e As EventArgs) Handles tst_iDelete.Click
        '---------------Data Check ----------------------------------------------------------------------------------
        If CheckData_Incharge(Me.FindForm.FindCode("InchargePurchasing").Code(), wJOB) = False Then
            MsgBox("No Correct InchargePurchasing !")
            Exit Sub
        End If
        '----------------------------------------------------------------------------------------------------------

        If txt_DateAccept.Data <> Pub.DAT Then
            MsgBoxP("Can not edit because of not today!")
            If MsgBoxPPW("Please type the password to modify!", const_pwPO) = False Then Exit Sub
        End If

        Dim str As String = MsgBoxP("Do you want to delete it?", vbYesNo)

        If str <> vbYes Then Exit Sub

        Call DATA_DELETE()
    End Sub

    Private Sub Vs1_ButtonClicked(sender As Object, e As EditorNotifyEventArgs) Handles Vs1.ButtonClicked
        If txt_cdSite.Code = "" Then MsgBoxP("No Site!") : Setfocus(txt_cdSite) : Exit Sub
        If txt_CustomerCode.Code = "" Then MsgBoxP("No Customer!") : Setfocus(txt_CustomerCode) : Exit Sub

        txt_cdSite.Enabled = False
        txt_CustomerCode.Enabled = False

        Dim xCOL As Integer
        Dim xROW As Integer
        Dim i As Integer
        Dim Value1() As String
        Dim Value2(5) As String

        xROW = e.Row
        xCOL = e.Column

        Select Case xCOL
            Case getColumIndex(Vs1, "CLcdMaterialCode_D")

                If HLP3011A_OS_4010.Link_HLP3011Material(txt_cdSite.Code, txt_CustomerCode.Code) = True Then

                    If hlp0000SeVa = "" Then Exit Sub
                    Value1 = hlp0000SeVa.Split("|")

                    For i = 0 To Value1.Length - 1
                        Value2 = Value1(i).Split(",")

                        If READ_PFK4010(Value2(0)) = True Then
                            DS1 = PrcDS("USP_ISUD3421D_SEARCH_VS1_INSERT_" & _chk_CheckIOType & _chk_CheckPurchasingOrder, cn, Value2(0), txt_SupplierCode.Code)
                            Call READ_SPREAD_N(Vs1, DS1, xROW, GetDsRc(DS1), "USP_ISUD3421D_SEARCH_VS1_" & _chk_CheckIOType & _chk_CheckPurchasingOrder, "VS1")

                            Vs1.ActiveSheet.RowCount += 1

                            xROW = xROW + 1
                        End If
                    Next
                End If
                Vs1.Focus()

           
        End Select

    End Sub


    Private Sub vS1_KeyDown(sender As Object, e As KeyEventArgs) Handles Vs1.KeyDown
        If wJOB = 2 And wJOB = 5 Then Exit Sub
        Dim xCOL As Long
        Dim xROW As Long
        Dim i As Integer
        Dim Value1() As String
        Dim Value2(5) As String

        xCOL = Vs1.ActiveSheet.ActiveColumnIndex
        xROW = Vs1.ActiveSheet.ActiveRowIndex

        Select Case e.KeyCode

            Case Keys.Delete
                '---------------Data Check ----------------------------------------------------------------------------------
                If CheckData_Incharge(Me.FindForm.FindCode("InchargePurchasing").Code(), wJOB) = False Then
                    MsgBox("No Correct InchargePurchasing !")
                    Exit Sub
                End If
                '----------------------------------------------------------------------------------------------------------

                Msg_Result = MsgBoxP("Do you want to delete?", vbYesNo)

                If Msg_Result <> vbYes Then Exit Sub

                If txt_DateAccept.Data <> Pub.DAT Then
                    MsgBoxP("Can not edit because of not today!")
                    If MsgBoxPPW("Please type the password to modify!", const_pwPO) = False Then Exit Sub
                End If

                W3422.FactOrderNo = txt_FactOrderNo.Data
                W3422.FactOrderSeq = getData(Vs1, getColumIndex(Vs1, "KEY_FactOrderSeq"), xROW)

                If READ_PFK3422(W3422.FactOrderNo, W3422.FactOrderSeq) = True Then
                    If D3422.CheckPurchasing <> "1" Then MsgBoxP("Check condition at row " & xROW) : Exit Sub
                    If CDblp(D3422.QtyWarehouse) > 0 Then MsgBoxP("Check condition at row " & xROW) : Exit Sub

                    If READ_PFK3429_FactOrder(W3422.FactOrderNo, W3422.FactOrderSeq) = True Then
                        MsgBox("Already make Payable can't modify !")
                        Exit Sub
                    End If


                    If DELETE_PFK3422(D3422) Then
                        Call Delete_History("PFK3422", D3422.FactOrderNo & "-" & D3422.FactOrderSeq.ToString)

                        If READ_PFK3011(D3422.AutokeyK3011) Then
                            W3011 = D3011
                            W3011.QtyRequest = 0

                            Call REWRITE_PFK3011(W3011)
                        End If

                        If READ_PFK3422_1(L3421.FactOrderNo) = False Then
                            If READ_PFK3421(L3421.FactOrderNo) = True Then
                                W3421 = D3421

                                If DELETE_PFK3421(W3421) = True Then

                                    Call Delete_History("PFK3422", W3421.FactOrderNo)

                                    isudCHK = True
                                    Me.Dispose()
                                End If

                            End If

                        End If

                    End If

                End If

                SPR_DEL(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex)
                Vs1.Focus()


        End Select

    End Sub

    Private Sub rad_CheckIOType1_CheckedChanged(sender As Object, e As EventArgs) Handles rad_CheckIOType1.CheckedChanged, rad_CheckIOType2.CheckedChanged
        If rad_CheckIOType1.Checked = True Then
            '          rad_CheckProcessType1.Checked = True

            cmb_CheckInPurchasingOrder.Visible = True
            cmb_CheckOutPurchasingOrder.Visible = False
        ElseIf rad_CheckIOType2.Checked = True Then
            '            rad_CheckProcessType2.Checked = True

            cmb_CheckInPurchasingOrder.Visible = False
            cmb_CheckOutPurchasingOrder.Visible = True
        End If

    End Sub

    Private Sub txt_PriceExchange_txtTextChanged(sender As Object, e As EventArgs) Handles txt_PriceExchange.txtTextChanged, txt_cdUnitPrice.txtTextChange
        If formA = False Then Exit Sub
        Exit Sub
        Dim i As Integer
        Try

            If READ_PFK7199(txt_DateExchange.Data, ListCode("UnitPrice"), txt_cdUnitPrice.Code) Then
                txt_PriceExchange.Data = D7199.Value

                For i = 0 To Vs1.ActiveSheet.RowCount - 1
                    'vSChange(i)
                Next

            End If
        Catch ex As Exception

        End Try


    End Sub

    Private Sub txt_DateDelivery_m_Textchange(sender As Object, e As EventArgs) Handles txt_DateDelivery.m_Textchange
        If formA = False Then Exit Sub

        If wJOB <> 3 Then Exit Sub
        Try
            Dim i As Integer

            For i = 0 To Vs1.ActiveSheet.RowCount - 1
                setData(Vs1, getColumIndex(Vs1, "DateDelivery"), i, txt_DateDelivery.Data)
            Next

        Catch ex As Exception

        End Try


    End Sub

#End Region


    
End Class