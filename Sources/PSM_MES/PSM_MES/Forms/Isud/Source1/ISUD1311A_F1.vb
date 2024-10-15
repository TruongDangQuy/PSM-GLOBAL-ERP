Imports System.Net.Mail
Imports System.Text
Imports System.IO.Ports

Public Class ISUD1311A_F1

#Region "Variable"
    'Private wJOB As Integer
    Private W7106 As T7106_AREA

    Private W0102 As New T0102_AREA

    Private W1311 As New T1311_AREA
    Private L1311 As New T1311_AREA

    Private W1312 As New T1312_AREA
    Private L1312 As New T1312_AREA

    Private W1313 As New T1313_AREA
    Private L1313 As New T1313_AREA

    Private W1314 As New T1314_AREA
    Private L1314 As New T1314_AREA

    Private W1315 As New T1315_AREA
    Private L1315 As New T1315_AREA

    Private W1316 As New T1316_AREA
    Private L1316 As New T1316_AREA

    Private W7156 As New T7156_AREA
    Private W7104 As New T7104_AREA

    Private W0111 As T0111_AREA
    Private L0111 As T0111_AREA

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

    Private OrderNoSeq As String = ""

    Private Schedula As String = ""

    Private Link_W1311 As T1311_AREA
    Private Link_W1312 As List(Of T1312_AREA)

    Dim rowList As Integer
    Dim rowChk As Integer
    Dim List1312KW As New List(Of T1312_AREA)
    Dim bolCopy As Boolean = False

#End Region

#Region "Link"
    Public Function Link_ISUD1311A_F1(job As Integer, OrderNo As String, Optional ByVal TAG As String = "", Optional ByVal CheckCopy As Boolean = False) As Boolean
        Me.Tag = TAG
        D1311.OrderNo = OrderNo

        bolCopy = CheckCopy

        wJOB = job : L1311 = D1311

        Link_ISUD1311A_F1 = False
        Try

            Select Case job
                Case 1, 11

                Case 5, 6
                    If READ_PFK1312_APPROVAL(OrderNo) = False Then
                        MsgBoxEx("Not Approval Order ! Can not revise ! ")
                        Exit Function
                    End If

                Case Else

                    If READ_PFK1312_APPROVAL(OrderNo) Then
                        wJOB = 2
                        tst_iDelete.Visible = False
                        tst_iSave.Visible = False
                    End If

            End Select

            If TAG = "PFP13120" Then
                If READ_PFK7171(ListCode("OrderGroup"), "001") Then
                    txt_cdOrderGroup.Code = D7171.BasicCode
                    txt_cdOrderGroup.Data = D7171.BasicName
                    txt_cdOrderGroup.Enabled = False

                    txt_cdStateOfficial.Visible = False
                    txt_cdStateSample.Visible = True
                End If

            ElseIf TAG = "PFP13121" Then
                If READ_PFK7171(ListCode("OrderGroup"), "002") Then
                    txt_cdOrderGroup.Code = D7171.BasicCode
                    txt_cdOrderGroup.Data = D7171.BasicName
                    txt_cdOrderGroup.Enabled = False
                    txt_cdStateOfficial.Visible = True

                    If READ_PFK7171(ListCode("StateOfficial"), "001") Then
                        txt_cdStateOfficial.Code = D7171.BasicCode
                        txt_cdStateOfficial.Data = D7171.BasicName
                    End If

                End If

            ElseIf TAG = "PFP13123" Then
                If READ_PFK7171(ListCode("OrderGroup"), "002") Then
                    txt_cdOrderGroup.Code = D7171.BasicCode
                    txt_cdOrderGroup.Data = D7171.BasicName
                    txt_cdOrderGroup.Enabled = False

                    txt_cdStateOfficial.Visible = True


                    If READ_PFK7171(ListCode("StateOfficial"), "001") Then
                        txt_cdStateOfficial.Code = D7171.BasicCode
                        txt_cdStateOfficial.Data = D7171.BasicName
                    End If

                End If

            End If


            formA = False
            Me.ShowDialog()
            Application.DoEvents()
            Cursor = Cursors.Default

            Link_ISUD1311A_F1 = isudCHK

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("YARN PROCESSING"))
        End Try

    End Function
    Private Check_AutoLink As Boolean = False
    Private str_AutoLink As String
    Public Function Link_ISUD1311A_AUTO(job As Integer, Value As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        Check_AutoLink = True
        str_AutoLink = Value
        wJOB = job : L1311 = D1311

        Link_ISUD1311A_AUTO = False

        Try

            Select Case job
                Case 1, 11
                Case Else

            End Select

            If TAG = "PFP13120" Then
                If READ_PFK7171(ListCode("OrderGroup"), "001") Then
                    txt_cdOrderGroup.Code = D7171.BasicCode
                    txt_cdOrderGroup.Data = D7171.BasicName
                    txt_cdOrderGroup.Enabled = False

                    txt_cdStateOfficial.Visible = False
                    txt_cdStateSample.Visible = True

                    Me.Text = Me.Text.Replace("OFFICIAL", "SAMPLE")
                End If

            ElseIf TAG = "PFP13121" Then
                If READ_PFK7171(ListCode("OrderGroup"), "002") Then
                    txt_cdOrderGroup.Code = D7171.BasicCode
                    txt_cdOrderGroup.Data = D7171.BasicName
                    txt_cdOrderGroup.Enabled = False
                End If
            End If


            formA = False
            Me.ShowDialog()
            Application.DoEvents()
            Cursor = Cursors.Default

            Link_ISUD1311A_AUTO = isudCHK

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("YARN PROCESSING"))
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

                tst_iDelete.Visible = False

                If CHK(1) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call KEY_COUNT()

                If Check_AutoLink = False Then
                    Call DATA_SEARCH_vS10()

                ElseIf Check_AutoLink = True Then
                    Call DATA_SEARCH_vS10()
                    Call DATA_SEARCH_vS10_AUTO()

                End If

                txt_DateOrder.Data = Pub.DAT

                Setfocus(txt_CustomerCode)

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
                Call DATA_SEARCH_vS10()

                tst_iDelete.Visible = False
                tst_iSave.Visible = False

            Case 3
                Me.Text = Me.Text & " - UPDATE"

                If CHK(3) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                End If

                txt_OrderNo.Enabled = False

                Call DATA_SEARCH01()
                Call DATA_SEARCH_vS10()


                tst_iDelete.Visible = False

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
                Call DATA_SEARCH_vS10()

                tst_iDelete.Visible = True
                tst_iSave.Visible = False

            Case 5
                Me.Text = Me.Text & " - REVISE"

                If CHK(3) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                End If

                txt_OrderNo.Enabled = False

                txt_cdSite.Enabled = False
                txt_CustPoNo.Enabled = False
                txt_CustomerCode.Enabled = False

                Call DATA_SEARCH01()
                Call DATA_SEARCH_vS10()


                tst_iDelete.Visible = False

            Case 6
                Me.Text = Me.Text & " - REVISE ALL"

                If CHK(3) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                End If

                txt_OrderNo.Enabled = False

                Call DATA_SEARCH01()
                Call DATA_SEARCH_vS10()


                tst_iDelete.Visible = False

        End Select

        formA = True
    End Sub

    Private Sub DATA_INIT()
        Try
            txt_OrderNo.Enabled = False

            If bolCopy = True Then
                chk_CopyPacking.Visible = True

            End If
            Call D1311_CLEAR()
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INIT")
        End Try
    End Sub

    Private Sub FORM_INIT()
        vS10.InsChk = True
        Me.chk_Attach = False
    End Sub

#End Region

#Region "Search"

    Private Function DATA_SEARCH01() As Boolean
        DATA_SEARCH01 = False
        Try
            DS1 = READ_PFK1311(L1311.OrderNo, cn)

            If GetDsRc(DS1) = 0 Then
                Exit Function
                isudCHK = False
            End If

            READER_MOVE(Me, DS1)

            txt_MContractIn.Text = GetDsData(DS1, 0, "K1311_ContractIn")
            txt_MContractOut.Text = GetDsData(DS1, 0, "K1311_ContractOut")
            txt_MDestination.Text = GetDsData(DS1, 0, "K1311_Destination")

            DATA_SEARCH01 = True

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_SEARCH01")
        End Try

    End Function

    Private Function DATA_SEARCH02(SpecNo As String, SpecNoSeq As String) As Boolean

        DATA_SEARCH02 = False
        Try

            DS1 = PrcDS("USP_ISU1311A_SEARCH_HEAD_SPECINFO", cn, SpecNo, SpecNoSeq)

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

    Private Function DATA_SEARCH03(OrderNo As String) As Boolean

        DATA_SEARCH03 = False
        Try

            DS1 = PrcDS("USP_ISU1311A_SEARCH_HEAD_SPECINFO_SUM", cn, OrderNo)

            If GetDsRc(DS1) = 0 Then
                DS2 = READ_PFK0102_OrderNo(OrderNo, cn)

                If GetDsRc(DS2) > 0 Then
                    Call READER_MOVE(Me, DS2)
                End If

                Exit Function
                isudCHK = False
            End If

            STORE_MOVE(Me, DS1)

            DATA_SEARCH03 = True

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_SEARCH02")
        End Try

    End Function

    Private Function DATA_SEARCH_vS10() As Boolean
        DATA_SEARCH_vS10 = False
        Try

            DS1 = PrcDS("USP_ISU1311A_SEARCH_VS10", cn, L1311.OrderNo)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS10, DS1, "USP_ISU1311A_SEARCH_VS10", "VS10")
                SPR_TEXTBOXM(vS10, getColumIndex(vS10, "RemarkOther"))
                SPR_TEXTBOXM(vS10, getColumIndex(vS10, "Destination"))
                SPR_TEXTBOXM(vS10, getColumIndex(vS10, "SLNoSys"))
                vS10.ActiveSheet.RowCount = 1
                vS10.Enabled = True
                Exit Function
            End If


            SPR_PRO_NEW(vS10, DS1, "USP_ISU1311A_SEARCH_VS10", "Vs10")
            SPR_TEXTBOXM(vS10, getColumIndex(vS10, "RemarkOther"))
            SPR_TEXTBOXM(vS10, getColumIndex(vS10, "Destination"))
            SPR_TEXTBOXM(vS10, getColumIndex(vS10, "SLNoSys"))
            Call DATA_SEARCH_CHECK_SPECNO()

            Dim i As Integer
            For i = 0 To vS10.ActiveSheet.RowCount - 1
                If wJOB <> 5 And wJOB <> 6 Then
                    If READ_PFK1312(getData(vS10, getColumIndex(vS10, "KEY_OrderNo"), i), getData(vS10, getColumIndex(vS10, "KEY_OrderNoSeq"), i)) Then
                        If D1312.OrderDetailStatus <> "1" Then SPR_LOCK(vS10, i) : SPR_BACKCOLOR(vS10, cSprLockBackColor, i)
                    End If
                Else
                    SPR_LOCK_COL(vS10, getColumIndex(vS10, "ShoesCode"))
                    SPR_LOCK_COL(vS10, getColumIndex(vS10, "CLShoesCode"))
                End If

            
            

            Next


            DATA_SEARCH_vS10 = True

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_SEARCH_vS10")
        End Try

    End Function
    Private Function DATA_SEARCH_vS10_AUTO() As Boolean
        DATA_SEARCH_vS10_AUTO = False
        Try

            DS1 = PrcDS("USP_ISU1311A_SEARCH_VS10_AUTO", cn, str_AutoLink)
            'SPR_PRO_NEW(vS10, DS1, "USP_ISU1311A_SEARCH_VS10", "Vs10")
            Call READ_SPREAD_N(vS10, DS1, vS10.ActiveSheet.ActiveRowIndex, GetDsRc(DS1), "USP_ISU1311A_SEARCH_VS10", "VS10")

            Dim ShoesCode As String
            ShoesCode = getData(vS10, getColumIndex(vS10, "ShoesCode"), 0)

            If READ_PFK7106(ShoesCode) Then
                txt_CustomerCode.Code = D7106.Customercode

                If READ_PFK7101(D7106.Customercode) Then

                    txt_CustomerCode.Data = D7101.CustomerName

                    If txt_cdDeliveryTerm.Code = "" Then
                        txt_cdDeliveryTerm.Code = D7101.cdDeliveryTerm
                    End If

                    If txt_cdPaymentCondition.Code = "" Then
                        txt_cdPaymentCondition.Code = D7101.cdPaymentCondition
                    End If

                    If txt_cdPaymentDay.Code = "" Then
                        txt_cdPaymentDay.Code = D7101.cdPaymentDay
                    End If

                    If txt_cdPaymentTerm.Code = "" Then
                        txt_cdPaymentTerm.Code = D7101.cdPaymentTerm
                    End If

                    If txt_cdPaymentTime.Code = "" Then
                        txt_cdPaymentTime.Code = D7101.cdPaymentTime
                    End If


                End If

                If wJOB = "1" Then
                    txt_cdOrderKind.Code = "001"
                    txt_cdOrderType.Code = "001"
                    txt_cdOrderWork.Code = "001"
                    txt_cdMarketType.Code = "002"

                    If READ_PFK7171(ListCode("OrderKind"), txt_cdOrderKind.Code) = True Then txt_cdOrderKind.Data = D7171.BasicName
                    If READ_PFK7171(ListCode("OrderType"), txt_cdOrderType.Code) = True Then txt_cdOrderType.Data = D7171.BasicName
                    If READ_PFK7171(ListCode("OrderWork"), txt_cdOrderWork.Code) = True Then txt_cdOrderWork.Data = D7171.BasicName
                    If READ_PFK7171(ListCode("MarketType"), txt_cdMarketType.Code) = True Then txt_cdMarketType.Data = D7171.BasicName

                    If READ_PFK7171(ListCode("DeliveryTerm"), txt_cdDeliveryTerm.Code) = True Then txt_cdDeliveryTerm.Data = D7171.BasicName
                    If READ_PFK7171(ListCode("PaymentCondition"), txt_cdPaymentCondition.Code) = True Then txt_cdPaymentCondition.Data = D7171.BasicName
                    If READ_PFK7171(ListCode("PaymentDay"), txt_cdPaymentDay.Code) = True Then txt_cdPaymentDay.Data = D7171.BasicName
                    If READ_PFK7171(ListCode("PaymentTerm"), txt_cdPaymentTerm.Code) = True Then txt_cdPaymentTerm.Data = D7171.BasicName
                    If READ_PFK7171(ListCode("PaymentTime"), txt_cdPaymentTime.Code) = True Then txt_cdPaymentTime.Data = D7171.BasicName


                    txt_cdDepartment.Code = "002"
                    If READ_PFK7171(ListCode("Department"), txt_cdDepartment.Code) = True Then txt_cdDepartment.Data = D7171.BasicName

                End If
               
                If READ_PFK7411(D7101.InChargeSale) = True Then txt_InchargeSales.Code = D7411.IDNO : txt_InchargeSales.Data = D7411.Name
                If READ_PFK7411(Pub.SAW) = True Then txt_InchargePPC.Code = D7411.IDNO : txt_InchargePPC.Data = D7411.Name

            End If

            DATA_SEARCH_vS10_AUTO = True

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_SEARCH_vS10")
        End Try

    End Function

    Private Function DATA_SEARCH_CHECK_SPECNO()
        Try
            Dim i As Integer
            Dim SpecNo As String
            Dim SpecNoSeq As String
            Dim CF As String

            For i = 0 To vS10.ActiveSheet.RowCount - 1
                SpecNo = getData(vS10, getColumIndex(vS10, "SpecNo"), i)
                SpecNoSeq = getData(vS10, getColumIndex(vS10, "SpecNoseq"), i)

                If SpecNo = "" Then GoTo next1

                Dim StrMsg = " SELECT TOP 1 K0102_SpecNoSeq AS CF FROM PFK0102"
                StrMsg &= "  WHERE K0102_SpecNo = '" + SpecNo + "'  "
                StrMsg &= "	AND		K0102_SpecNoSeq	>	'" + SpecNoSeq + "'"
                StrMsg &= "		ORDER	BY	K0102_SpecNoSeq DESC"

                cmd = New SqlClient.SqlCommand(StrMsg, cn)
                rd = cmd.ExecuteReader
                rd.Read()

                If rd.HasRows Then
                    CF = rd!CF
                    If READ_PFK7401(Pub.SAW, SpecNo, CF) Then
                        If D7401.CheckConfirm = "1" Then rd.Close() : GoTo next1

                        Dim StrYesNo As String = MsgBox("New SpecSheet has been created! From Specno " & SpecNo & "-" & SpecNoSeq & " to " _
                                                        & SpecNo & "-" & CF & " .Do you accept this change and view it ?", vbYesNo)

                        If StrYesNo <> vbYes Then rd.Close() : GoTo next1

                        D7401.CheckConfirm = "1"
                        D7401.TimeConfirm = System_Date_time()
                        D7401.DateConfirm = Pub.DAT

                        Call REWRITE_PFK7401(D7401)


                    Else
                        Dim StrYesNo As String = MsgBox("New SpecSheet has been created! From Specno " & SpecNo & "-" & SpecNoSeq & " to " _
                                                      & SpecNo & "-" & CF & " .Do you accept this change and view it ?", vbYesNo)

                        If StrYesNo <> vbYes Then rd.Close() : GoTo next1

                        D7401.CheckConfirm = "1"
                        D7401.TimeConfirm = System_Date_time()
                        D7401.DateConfirm = Pub.DAT
                        D7401.IDNO = Pub.SAW
                        D7401.SpecNo = SpecNo
                        D7401.SpecNoSeq = CF

                        Call WRITE_PFK7401(D7401)


                    End If

                End If

                rd.Close()

next1:
            Next

        Catch ex As Exception

        End Try
    End Function


#End Region

#Region "Function"
    Private Sub DATA_MOVE_DEFAULT()
        Try

            W1311.ContractIn = txt_MContractIn.Text
            W1311.ContractOut = txt_MContractOut.Text
            W1311.Destination = txt_MDestination.Text


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
            W1311.seUnitPrice = ListCode("UnitPrice")
            W1311.seShippingTerm = ListCode("ShippingTerm")
            W1311.seMarketType = ListCode("MarketType")

            W1311.seSite = ListCode("Site")
            'PFK1312
            W1312.seSpecStatus = ListCode("SpecStatus")
            W1312.seUnitMaterial = ListCode("UnitMaterial")
            W1312.seUnitPacking = ListCode("UnitPacking")

            'PFK1314
            W1314.seOrderProcess = ListCode("OrderProcess")
            W1314.seProcessState = ListCode("ProcessState")

            'PFK1316
            W1316.seProcessType = ListCode("ProcessType")

        Catch ex As Exception
            Call Error_Message("62", "DATA_MOVE_DEFAULT")
        End Try

    End Sub
    Private Function DATA_MOVE_WRITE01() As Boolean
        DATA_MOVE_WRITE01 = False
        Try

            If READ_PFK1311(txt_OrderNo.Data) = True Then

                W1311.CustomerCode = txt_CustomerCode.Code
                W1311.CustPoNo = txt_CustPoNo.Data
                W1311.CustPoNoParent = txt_CustPoNoParent.Data
                W1311.cdUnitPrice = txt_cdUnitPrice.Code
                W1311.cdSeason = "000"
                W1311.cdOrderGroup = txt_cdOrderGroup.Code
                W1311.cdOrderKind = txt_cdOrderKind.Code
                W1311.cdOrderType = txt_cdOrderType.Code
                W1311.cdOrderWork = txt_cdOrderWork.Code
                W1311.InchargeSales = txt_InchargeSales.Code
                W1311.cdDepartment = txt_cdDepartment.Code
                W1311.InchargePPC = txt_InchargePPC.Code
                W1311.cdPaymentTerm = txt_cdPaymentTerm.Code
                W1311.cdDeliveryTerm = txt_cdDeliveryTerm.Code
                W1311.cdMarketType = txt_cdMarketType.Code

                DATA_MOVE_DEFAULT()

                Call REWRITE_PFK1311(W1311)
                isudCHK = True
            Else
                W1311.OrderNo = L1311.OrderNo

                W1311.CustomerCode = txt_CustomerCode.Code
                W1311.CustPoNo = txt_CustPoNo.Data
                W1311.CustPoNoParent = txt_CustPoNoParent.Data
                W1311.cdUnitPrice = txt_cdUnitPrice.Code
                W1311.cdSeason = "000"
                W1311.cdOrderGroup = txt_cdOrderGroup.Code
                W1311.cdOrderKind = txt_cdOrderKind.Code
                W1311.cdOrderType = txt_cdOrderType.Code
                W1311.cdOrderWork = txt_cdOrderWork.Code
                W1311.InchargeSales = txt_InchargeSales.Code
                W1311.cdDepartment = txt_cdDepartment.Code
                W1311.InchargePPC = txt_InchargePPC.Code
                W1311.cdPaymentTerm = txt_cdPaymentTerm.Code
                W1311.cdDeliveryTerm = txt_cdDeliveryTerm.Code
                W1311.cdMarketType = txt_cdMarketType.Code

                DATA_MOVE_DEFAULT()

                Call WRITE_PFK1311(W1311)

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

                If K1312_MOVE(vS10, i, W1312, txt_OrderNo.Data, getData(vS10, getColumIndex(vS10, "KEY_OrderNoSeq"), i)) = True Then

                    DATA_MOVE_DEFAULT()

                    W1312.DateUpdate = Pub.DAT
                    W1312.InchargeUpdate = Pub.SAW
                    W1312.DateOrder = txt_DateOrder.Data

                    W1312.SizeRange = getData(vS10, getColumIndex(vS10, "SizeRange"), i)

                    W1312.QtyOrderSample01 = CDecp(getData(vS10, getColumIndex(vS10, "QtyOrderSample01"), i))
                    W1312.QtyOrderSample02 = CDecp(getData(vS10, getColumIndex(vS10, "QtyOrderSample02"), i))

                    W1312.QtyOrderSample = W1312.QtyOrderSample01 + W1312.QtyOrderSample02

                    Call REWRITE_PFK1312(W1312)

                    isudCHK = True
                Else
                    W1312.OrderNo = L1311.OrderNo

                    Call KEY_COUNT_PFK1312()

                    DATA_MOVE_DEFAULT()

                    W1312.SizeRange = getData(vS10, getColumIndex(vS10, "SizeRange"), i)
                    W1312.OrderDetailStatus = "1"


                    W1312.QtyOrderSample01 = CDecp(getData(vS10, getColumIndex(vS10, "QtyOrderSample01"), i))
                    W1312.QtyOrderSample02 = CDecp(getData(vS10, getColumIndex(vS10, "QtyOrderSample02"), i))

                    W1312.QtyOrderSample = W1312.QtyOrderSample01 + W1312.QtyOrderSample02

                    W1312.DateOrder = txt_DateOrder.Data

                    W1312.DateInsert = Pub.DAT
                    W1312.InchargeInsert = Pub.SAW

                    Call WRITE_PFK1312(W1312)

                    isudCHK = True
                End If
skip:
            Next

            DATA_MOVE_WRITE02 = True

        Catch ex As Exception
            MsgBoxP("DATA_MOVE_WRITE02")
        End Try

    End Function

    Private Function DATA_MOVE_WRITE02_AFTER() As Boolean
        DATA_MOVE_WRITE02_AFTER = False
        Try
            Dim i As Integer
            Dim j As Integer

            j = 0
            For i = 0 To vS10.ActiveSheet.RowCount - 1
                j = j + 1

                If K1312_MOVE(vS10, i, W1312, txt_OrderNo.Data, getData(vS10, getColumIndex(vS10, "KEY_OrderNoSeq"), i)) = True Then

                    DATA_MOVE_DEFAULT()

                    W1312.DateUpdate = Pub.DAT
                    W1312.InchargeUpdate = Pub.SAW
                    W1312.DateOrder = txt_DateOrder.Data


                    W1312.QtyOrderSample01 = CDecp(getData(vS10, getColumIndex(vS10, "QtyOrderSample01"), i))
                    W1312.QtyOrderSample02 = CDecp(getData(vS10, getColumIndex(vS10, "QtyOrderSample02"), i))

                    W1312.QtyOrderSample = W1312.QtyOrderSample01 + W1312.QtyOrderSample02

                    W1312.SizeRange = getData(vS10, getColumIndex(vS10, "SizeRange"), i)
                    Call REWRITE_PFK1312(W1312)

                    isudCHK = True
                Else
                    W1312.OrderNo = L1311.OrderNo

                    Call KEY_COUNT_PFK1312()

                    DATA_MOVE_DEFAULT()

                    W1312.SizeRange = getData(vS10, getColumIndex(vS10, "SizeRange"), i)
                    W1312.OrderDetailStatus = "1"

                    W1312.QtyOrderSample01 = CDecp(getData(vS10, getColumIndex(vS10, "QtyOrderSample01"), i))
                    W1312.QtyOrderSample02 = CDecp(getData(vS10, getColumIndex(vS10, "QtyOrderSample02"), i))

                    W1312.QtyOrderSample = W1312.QtyOrderSample01 + W1312.QtyOrderSample02

                    W1312.DateOrder = txt_DateOrder.Data

                    W1312.DateInsert = Pub.DAT
                    W1312.InchargeInsert = Pub.SAW

                    Call WRITE_PFK1312(W1312)

                    isudCHK = True
                End If
skip:
            Next

            DATA_MOVE_WRITE02_AFTER = True

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

            If K1312_MOVE(vS10, i, W1312, txt_OrderNo.Data, getData(vS10, getColumIndex(vS10, "KEY_OrderNoSeq"), i)) = True Then

                W1312.PKO = getData(vS10, getColumIndex(vS10, "PKO"), i)
                W1312.cdSpecStatus = getData(vS10, getColumIndex(vS10, "cdSpecStatus"), i)

                W1312.SizeRange = getData(vS10, getColumIndex(vS10, "SizeRange"), i)
                W1312.SpeciticSize = getData(vS10, getColumIndex(vS10, "SpeciticSize"), i)

                W1312.cdUnitMaterial = getData(vS10, getColumIndex(vS10, "cdUnitMaterial"), i)
                W1312.cdUnitPacking = getData(vS10, getColumIndex(vS10, "cdUnitPacking"), i)

                W1312.cdUnitPacking = getData(vS10, getColumIndex(vS10, "SpecNo"), i)
                W1312.cdUnitPacking = getData(vS10, getColumIndex(vS10, "SpecNoSeq"), i)

                DATA_MOVE_DEFAULT()
                W1312.DateOrder = txt_DateOrder.Data

                W1312.QtyOrderSample01 = CDecp(getData(vS10, getColumIndex(vS10, "QtyOrderSample01"), i))
                W1312.QtyOrderSample02 = CDecp(getData(vS10, getColumIndex(vS10, "QtyOrderSample02"), i))

                W1312.QtyOrderSample = W1312.QtyOrderSample01 + W1312.QtyOrderSample02

                Call REWRITE_PFK1312(W1312)

                isudCHK = True
            Else
                W1312.OrderNo = L1311.OrderNo

                Call KEY_COUNT_PFK1312()

                W1312.PKO = getData(vS10, getColumIndex(vS10, "PKO"), i)
                W1312.cdSpecStatus = getData(vS10, getColumIndex(vS10, "cdSpecStatus"), i)

                W1312.SizeRange = getData(vS10, getColumIndex(vS10, "SizeRange"), i)
                W1312.SpeciticSize = getData(vS10, getColumIndex(vS10, "SpeciticSize"), i)
                W1312.cdUnitMaterial = getData(vS10, getColumIndex(vS10, "cdUnitMaterial"), i)
                W1312.cdUnitPacking = getData(vS10, getColumIndex(vS10, "cdUnitPacking"), i)

                W1312.SpecNo = getData(vS10, getColumIndex(vS10, "SpecNo"), i)
                W1312.SpecNoSeq = getData(vS10, getColumIndex(vS10, "SpecNoSeq"), i)

                W1312.QtyOrderSample01 = CDecp(getData(vS10, getColumIndex(vS10, "QtyOrderSample01"), i))
                W1312.QtyOrderSample02 = CDecp(getData(vS10, getColumIndex(vS10, "QtyOrderSample02"), i))

                W1312.QtyOrderSample = W1312.QtyOrderSample01 + W1312.QtyOrderSample02

                W1312.DateOrder = txt_DateOrder.Data


                DATA_MOVE_DEFAULT()
                W1312.OrderDetailStatus = "1"

                Call WRITE_PFK1312(W1312)

                isudCHK = True
            End If

            DATA_MOVE_WRITE02_ROW = True

        Catch ex As Exception
            MsgBoxP("DATA_MOVE_WRITE02_ROW")
        End Try

    End Function

    Private Function Data_Check() As Boolean
        Data_Check = False
        Dim i As Integer

        Try
            For i = 0 To vS10.ActiveSheet.RowCount - 1
                If getData(vS10, getColumIndex(vS10, "ShoesCode"), i).ToString.Trim = "" Then MsgBoxP("ITEM CODE at Row " & (i + 1)) : Exit Function


                If CDecp(getData(vS10, getColumIndex(vS10, "QtyOrder"), i)) = 0 Then MsgBoxP("Zero qty at Row " & (i + 1)) : Exit Function

                If txt_cdOrderGroup.Code = "002" Then
                    If getData(vS10, getColumIndex(vS10, "PONO"), i) = "" Then MsgBoxP("PONO at Row " & (i + 1)) : Exit Function
                    If getData(vS10, getColumIndex(vS10, "PKO"), i) = "" Then MsgBoxP("UPC/Barcode at Row " & (i + 1)) : Exit Function
                End If


                If chk_CheckPKO.Checked Then
                    Dim Article As String
                    Dim cdSpecState As String = "007"
                    Dim ShoesCode As String
                    Dim FacPO As String

                    Article = getData(vS10, getColumIndex(vS10, "Article"), i)
                    ShoesCode = getData(vS10, getColumIndex(vS10, "ShoesCode"), i)
                    FacPO = getData(vS10, getColumIndex(vS10, "FacPO"), i)

                    Call READ_PFK7106(ShoesCode)
step1:
                    'If READ_PFK7106_CHECK_NOCOLOR(cdSpecState, D7106.Article, FacPO, D7106.Customercode, D7106.ColorCode) = False Then
                    '    MsgBoxP("No Item Code at Row " & (i + 1))

                    '    Msg_Result = MsgBox("Do you want to create " & Article, vbYesNo)

                    '    If Msg_Result = vbYes Then
                    '        If ISUD7106A.Link_ISUD7106A_COPY("5", ShoesCode, cdSpecState, Article) Then

                    '        End If

                    '    Else
                    '        Exit Function
                    '    End If

                    '    GoTo step1

                    'End If

                End If


            Next

            Data_Check = True
        Catch ex As Exception

        End Try
    End Function
    Private Function Data_Check_UPDATE() As Boolean
        Data_Check_UPDATE = False
        Dim i As Integer

        Try
            For i = 0 To vS10.ActiveSheet.RowCount - 1
                If getData(vS10, getColumIndex(vS10, "SizeRange"), i).ToString.Trim = "" Then MsgBoxP("Size Range at Row " & (i + 1)) : Exit Function
                If getData(vS10, getColumIndex(vS10, "ShoesCode"), i).ToString.Trim = "" Then MsgBoxP("ITEM CODE at Row " & (i + 1)) : Exit Function

                If chk_CheckPKO.Checked Then
                    Dim FacPO As String
                    Dim cdSpecState As String = "007"
                    Dim ShoesCode As String

                    FacPO = getData(vS10, getColumIndex(vS10, "FacPO"), i) & getData(vS10, getColumIndex(vS10, "PKO"), i)
                    ShoesCode = getData(vS10, getColumIndex(vS10, "ShoesCode"), i)

                    If FormatCut(FacPO) = "" Then MsgBoxP("No UPC/SKU at Row " & (i + 1)) : Exit Function

                    Call READ_PFK7106(ShoesCode)
step1:
                    'If READ_PFK7106_CHECK_NOCOLOR(cdSpecState, D7106.Article, FacPO, txt_CustomerCode.Code, D7106.ColorCode) = False Then
                    '    MsgBoxP("No Item Code at Row " & (i + 1))

                    '    Msg_Result = MsgBox("Do you want to create " & FacPO, vbYesNo)

                    '    If Msg_Result = vbYes Then
                    '        If ISUD7106A.Link_ISUD7106A_COPY("5", ShoesCode, cdSpecState, FacPO) Then

                    '        End If

                    '    Else
                    '        Exit Function

                    '    End If

                    '    GoTo step1

                    'End If

                End If
            Next

            Data_Check_UPDATE = True
        Catch ex As Exception

        End Try
    End Function
    Private Sub DATA_INSERT()
        Try

            If CheckData_Customer(Me.FindForm.FindCode("CustomerCode").Code(), wJOB) = False Then
                MsgBoxP("The customer name is different!")
                Exit Sub
            End If

            If Data_Check() = False Then Exit Sub

            Call KEY_COUNT()
            If K1311_MOVE(Me, W1311, 1, L1311.OrderNo) = False Then

                Call DATA_MOVE_DEFAULT()

                W1311.cdUnitPrice = txt_cdUnitPrice.Code
                If chk_CheckPKO.Checked = True Then W1311.CheckPKO = "1"
                If chk_CheckPKO.Checked = False Then W1311.CheckPKO = "2"

                W1311.DateAccept = txt_DateOrder.Data

                W1311.Buyer = L1311.Buyer
                W1311.Destination = L1311.Destination

                W1311.OrderNo = L1311.OrderNo
                W1311.CustPoNo = txt_CustPoNo.Data
                W1311.CustPoNoParent = txt_CustPoNoParent.Data
                W1311.cdStateOfficial = txt_cdStateOfficial.Code

                W1311.InchargeInsert = Pub.SAW
                W1311.DateInsert = Pub.DAT

                W1311.cdStateOfficial = txt_cdStateOfficial.Code
                W1311.DateInsert = Pub.DAT
                W1311.InchargeInsert = Pub.SAW

                If WRITE_PFK1311(W1311) = True Then

                    Call DATA_MOVE_WRITE02()
                    Call PrcExe("USP_PFK1312_UPDATE_SIZEQTY", cn, L1311.OrderNo)

                    Call DATA_SEARCH_vS10()
                    Call MsgBoxP("Insert Successfully !", vbInformation)


                    isudCHK = True : WRITE_CHK = "*" : wJOB = 3
                    Exit Sub
                End If
            End If

        Catch ex As Exception
            MsgBoxP("DATA_INSERT")
        End Try

    End Sub
    Private Sub DATA_UPDATE()
        Try


            If K1311_MOVE(Me, W1311, 3, L1311.OrderNo) = True Then

                Call DATA_MOVE_DEFAULT()

                W1311.OrderNo = L1311.OrderNo
                W1311.DateAccept = txt_DateOrder.Data

                If chk_CheckPKO.Checked = True Then W1311.CheckPKO = "1"
                If chk_CheckPKO.Checked = False Then W1311.CheckPKO = "2"

                W1311.DateUpdate = Pub.DAT
                W1311.InchargeUpdate = Pub.SAW

                If REWRITE_PFK1311(W1311) = True Then
                    Call DATA_MOVE_WRITE02()
                    Call PrcExe("USP_PFK1312_UPDATE_SIZEQTY", cn, L1311.OrderNo)

                    Call DATA_SEARCH_vS10()
                    Call MsgBoxP("Update Successfully !", vbInformation)

                    isudCHK = True : WRITE_CHK = "*"
                    Exit Sub
                End If
            End If

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_UPDATE")
        End Try
    End Sub

    Private Sub DATA_UPDATE_AFTER()
        Try
            str = InputBox("Could you input reason to revise this order ? At least 20 characters ! ")
            If FormatCut(str) = "" Or Len(str) < 20 Then MsgBoxEx("No reason (20 chars) ! Can not revise !") : Exit Sub

            If PrcExe("USP_PFK1311_REVISE_ORDER", cn, L1311.OrderNo, Pub.SAW, str) Then

                If K1311_MOVE(Me, W1311, 3, L1311.OrderNo) = True Then
                    Call DATA_MOVE_DEFAULT()
                    W1311.DateAccept = txt_DateOrder.Data
                    If chk_CheckPKO.Checked = True Then W1311.CheckPKO = "1"
                    If chk_CheckPKO.Checked = False Then W1311.CheckPKO = "2"
                    W1311.DateUpdate = Pub.DAT
                    W1311.InchargeUpdate = Pub.SAW
                    W1311.CustPoNoParent = txt_CustPoNoParent.Data

                    If REWRITE_PFK1311(W1311) = True Then
                        Call DATA_MOVE_WRITE02_AFTER()
                        Call PrcExe("USP_PFK1312_UPDATE_SIZEQTY", cn, L1311.OrderNo)

                        Call DATA_SEARCH_vS10()
                        Call MsgBoxP("Update Successfully !", vbInformation)

                        isudCHK = True : WRITE_CHK = "*"
                        Exit Sub
                    End If
                End If

            End If


        Catch ex As Exception
            Call MsgBoxP("35", "DATA_UPDATE")
        End Try
    End Sub
    Private Sub DATA_DELETE()
        Try
            If PrcExe("USP_ISUD1311A_sTAB1_ITEM_MASTER_DELETE", cn, txt_OrderNo.Data) = True Then
                isudCHK = True : Me.Dispose() : Exit Sub
            End If
            MsgBoxP("DATA_DELETE Order!")

        Catch ex As Exception
            Call MsgBoxP("38", "DATA_DELETE")
        End Try

    End Sub
    Private Function DELETE_T1312() As Boolean
        DELETE_T1312 = False
        Dim DSNEW As New DataSet
        Try
            DSNEW = READ_PFK1312_ORDERNO(L1311.OrderNo, cn)
            For Each Row As DataRow In DSNEW.Tables(0).Rows
                If READ_PFK1312(Row!K1312_OrderNo, Row!K1312_OrderNoSeq) = True Then
                    W1312 = D1312
                    DELETE_PFK1312(W1312)
                End If
            Next
            If GetDsRc(READ_PFK1312_ORDERNO(L1311.OrderNo, cn)) = 0 Then DELETE_T1312 = True
        Catch ex As Exception

        End Try
    End Function
    Private Function DELETE_T1313() As Boolean
        DELETE_T1313 = False
        Dim DSNEW As New DataSet
        Try
            DSNEW = READ_PFK1313_ORDERNO(L1311.OrderNo, cn)
            For Each Row As DataRow In DSNEW.Tables(0).Rows
                If READ_PFK1313(Row!K1313_OrderNo, Row!K1313_OrderNoSeq) = True Then
                    W1313 = D1313
                    DELETE_PFK1313(W1313)
                End If
            Next
            If GetDsRc(READ_PFK1313_ORDERNO(L1311.OrderNo, cn)) = 0 Then DELETE_T1313 = True
        Catch ex As Exception

        End Try
    End Function
    Private Function DELETE_T1314() As Boolean
        DELETE_T1314 = False
        Dim DSNEW As New DataSet
        Try
            DSNEW = READ_PFK1314_ORDERNO(L1311.OrderNo, cn)
            For Each Row As DataRow In DSNEW.Tables(0).Rows
                If READ_PFK1314(Row!K1314_OrderNo, Row!K1314_OrderNoSeq, Row!K1314_ProcessOrder) = True Then
                    W1314 = D1314
                    DELETE_PFK1314(W1314)
                End If
            Next
            If GetDsRc(READ_PFK1314_ORDERNO(L1311.OrderNo, cn)) = 0 Then DELETE_T1314 = True
        Catch ex As Exception

        End Try
    End Function
    Private Function DELETE_T1315() As Boolean
        DELETE_T1315 = False
        Dim DSNEW As New DataSet
        Try
            DSNEW = READ_PFK1315_ORDERNO(L1311.OrderNo, cn)
            For Each Row As DataRow In DSNEW.Tables(0).Rows
                If READ_PFK1315(Row!K1315_OrderNo, Row!K1315_OrderNoSeq) = True Then
                    W1315 = D1315
                    DELETE_PFK1315(W1315)
                End If
            Next
            If GetDsRc(READ_PFK1315_ORDERNO(L1311.OrderNo, cn)) = 0 Then DELETE_T1315 = True
        Catch ex As Exception

        End Try
    End Function
    Private Function DELETE_T1316() As Boolean
        DELETE_T1316 = False
        Dim DSNEW As New DataSet
        Try
            DSNEW = READ_PFK1316_ORDERNO(L1316.OrderNo, cn)
            For Each Row As DataRow In DSNEW.Tables(0).Rows
                If READ_PFK1316(Row!K1316_ScheduleID) = True Then
                    W1316 = D1316
                    DELETE_PFK1316(W1316)
                End If
            Next
            If GetDsRc(READ_PFK1316_ORDERNO(L1311.OrderNo, cn)) = 0 Then DELETE_T1316 = True
        Catch ex As Exception

        End Try
    End Function
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

            ' -------------------------------------------------------------------------------

            'Dim lENsLNO As String

            'Call READ_PFK7101(txt_CustomerCode.Code)
            'Call READ_PFK7171(ListCode("StateOfficial"), txt_cdStateOfficial.Code)

            'lENsLNO = D7101.CustomerNameSimply.Length

            'SQL = "SELECT MAX( CAST (RIGHT([K1312_SLNo], LEN([K1312_SLNo]) - " & lENsLNO & " - LEN( ISNULL(K7171_NameSimply,'')) ) AS INT) ) AS MAX_MCODE "
            'SQL = SQL & "  FROM  [PFK1312] "
            'SQL = SQL & "  INNER JOIN PFK1311 ON K1312_OrderNo = K1311_OrderNo "
            'SQL = SQL & "  INNER JOIN PFK7101 ON	K1311_CustomerCode = K7101_CustomerCode "
            'SQL = SQL & "  INNER JOIN PFK7171 ON  K7171_BasicCode = K1311_cdStateOfficial AND K7171_BasicSel  = K1311_seStateOfficial "
            'SQL = SQL & " WHERE K1311_CustomerCode = '" & txt_CustomerCode.Code & "' "
            'SQL = SQL & "  AND ISNULL(K7101_CustomerNameSimply,'') = LEFT([K1312_SLNo]," & lENsLNO & " )  "
            'SQL = SQL & "  AND SUBSTRING([K1312_SLNo]," & lENsLNO + 1 & " ,LEN( ISNULL(K7171_NameSimply,'')) ) = ISNULL(K7171_NameSimply,'') "
            'SQL = SQL & "  AND K1311_cdSeason           = '" & txt_cdSeason.Code & "' "
            'SQL = SQL & "  AND K1311_cdStateOfficial    = '" & txt_cdStateOfficial.Code & "' "

            'cmd = New SqlClient.SqlCommand(SQL, cn)
            'rd = cmd.ExecuteReader
            'rd.Read()

            'If IsDBNull(rd!MAX_MCODE) Then
            '    W1312.SLNoSys = "0001"
            'Else
            '    W1312.SLNoSys = CIntp(rd!MAX_MCODE + 1).ToString("0000")
            'End If



            'W1312.SLNoSys = D7101.CustomerNameSimply & D7171.NameSimply & W1312.SLNoSys
            'W1312.SLNoSys = Trim(W1312.SLNoSys)

            'L1312.SLNoSys = W1312.SLNoSys


            'W1312.SLNo = W1312.SLNoSys
            'L1312.SLNo = W1312.SLNoSys

            rd.Close()

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT_PFK1312")
        End Try
    End Sub
    Private Sub KEY_COUNT_PFK1316()
        Try
            SQL = "SELECT MAX(CAST(K1316_ScheduleID AS DECIMAL)) AS MAX_MCODE FROM PFK1316 "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                W1316.ScheduleID = "000001"
            Else
                W1316.ScheduleID = FormatP(CIntp(rd!MAX_MCODE + 1), "000000")
            End If

            rd.Close()

            L1316.ScheduleID = W1316.ScheduleID

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT_PFK1316")
        End Try
    End Sub
    Private Sub KEY_COUNT()

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
    Private Sub KEY_COUNT_PFK1316(OrderNo As String, OrderNoSeq As String)
        Try
            SQL = "SELECT MAX(CAST(K1316_Seq AS DECIMAL)) AS MAX_MCODE FROM PFK1316 "
            SQL = SQL & " WHERE K1316_OrderNo = '" & OrderNo & "' "
            SQL = SQL & " AND K1316_OrderNoSeq = '" & OrderNoSeq & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                W1316.Seq = 1
            Else
                W1316.Seq = CIntp(rd!MAX_MCODE + 1)
            End If

            rd.Close()

            L1316.Seq = W1316.Seq

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT_PFK1316")
        End Try
    End Sub
    Private Function GetOpenFileDialog() As OpenFileDialog

        Dim openFileDialog As New OpenFileDialog

        openFileDialog.CheckFileExists = True
        openFileDialog.Multiselect = False
        openFileDialog.AddExtension = True
        openFileDialog.ValidateNames = True
        openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)

        Return openFileDialog


    End Function
    Private Sub KEY_COUNT_K7106()
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
    Private Function CheckListContaint(ListSizeRangeString As String, ListSizeL As String)
        CheckListContaint = True
        Dim ListSizeLArray() As String
        Dim ListSizeLArray_Origin() As String

        ListSizeLArray = ListSizeL.Split(",")
        ListSizeLArray_Origin = ListSizeRangeString.Split(",")



        Try
            Dim i As Integer

            For i = 0 To ListSizeLArray.Count - 1
                If ListSizeLArray_Origin.Contains(ListSizeLArray(i)) = False And ListSizeLArray(i) <> "" Then
                    CheckListContaint = False

                End If
            Next

        Catch ex As Exception
            CheckListContaint = True
        End Try

    End Function

#End Region

#Region "Event"

    Private Sub tst_iSave_Click(sender As Object, e As EventArgs) Handles tst_iSave.Click
        Try
            Select Case wJOB
                Case 1
                    If CheckData_Customer(Me.FindForm.FindCode("CustomerCode").Code(), wJOB) = False Then
                        MsgBoxP("The customer name is different!")
                        Exit Sub
                    End If

                    If txt_cdDepartment.Data <> "" And (Trim(Pub.DEPARTMENT) = txt_cdDepartment.Data) Then
                        MsgBoxP("The Department name is different!")
                        Exit Sub
                    End If

                    If Data_Check() = False Then Exit Sub
                    If DataCheck(Me, "PFK1311") = False Then Exit Sub

                    Call DATA_INSERT()

                Case 2
                    Me.Dispose()
                Case 3
                    'If Data_Check() = False Then Exit Sub
                    If Data_Check_UPDATE() = False Then Exit Sub
                    If DataCheck(Me, "PFK1311") = False Then Exit Sub
                    Call DATA_UPDATE()

                    If chk_CopyPacking.Checked = True Then
                        Dim str As String = MsgBoxP("Do you want to copy packing ?", vbYesNo)

                        If PrcExe("USP_ISUD1311A_sTAB1_ITEM_COPY_ALL_PACKING", cn, W1312.OrderNo) = True Then
                            MsgBoxP("Copy sucessfully !", vbInformation)
                            chk_CopyPacking.Visible = False
                        End If
                    End If


                Case 5
                    'If Data_Check() = False Then Exit Sub
                    If Data_Check_UPDATE() = False Then Exit Sub
                    If DataCheck(Me, "PFK1311") = False Then Exit Sub
                    Call DATA_UPDATE_AFTER()

                Case 6
                    'If Data_Check() = False Then Exit Sub
                    If Data_Check_UPDATE() = False Then Exit Sub
                    If DataCheck(Me, "PFK1311") = False Then Exit Sub
                    Call DATA_UPDATE_AFTER()

                Case 4
            End Select
        Catch ex As Exception
            MsgBoxP("tst_iSave_Click")
        End Try

    End Sub
    Private Sub cmd_CANCEL_Click(sender As Object, e As EventArgs) Handles tst_iClose.Click
        If WRITE_CHK = "*" Then
            isudCHK = True
        Else
            isudCHK = False
        End If

        Me.Dispose()
    End Sub
    Private Sub tst_iDelete_Click(sender As Object, e As EventArgs) Handles tst_iDelete.Click

        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

        If CHK(4) <> "1" Then
            Call MsgBoxP("4", "tst_iDelete_Click")
            Exit Sub
        End If

        Dim str As String = MsgBoxP("Do you want to delete it?", vbYesNo)

        If str <> vbYes Then Exit Sub
        Try
            Call DATA_DELETE()
        Catch ex As Exception
            MsgBoxP("tst_iDelete_Click")
        End Try

    End Sub
    Private Sub Vs10_ButtonClicked(sender As Object, e As EditorNotifyEventArgs) Handles vS10.ButtonClicked
        Try
            vS10.ActiveSheet.ActiveRowIndex = e.Row
            vS10.ActiveSheet.ActiveColumnIndex = e.Column
            Select Case e.Column

                Case getColumIndex(vS10, "CLShoesCode")

                    If txt_cdOrderGroup.Code = "001" Then HLP7106A.Link_HLP7106A(txt_CustomerCode.Code, "", False)
                    If txt_cdOrderGroup.Code = "002" Then HLP7106A.Link_HLP7106A(txt_CustomerCode.Code, "", True)


                    If hlp0000SeVaTt = "" Or hlp0000SeVa = "" Then Exit Sub

                    str_AutoLink = hlp0000SeVaTt
                    Call DATA_SEARCH_vS10_AUTO()

                Case getColumIndex(vS10, "clcdDestinationCode")
                    If txt_CustomerCode.Code <> "000211" Then Exit Sub

                    If HLP7171ALL.Link_HLP7171A("160", "") = False Then Exit Sub

                    If READ_PFK7171(HLPNA, hlp0000SeVaTt) Then
                        setData(vS10, getColumIndex(vS10, "Destination"), e.Row, D7171.BasicName)
                    End If

            End Select


        Catch ex As Exception
            MsgBoxP("Vs10_ButtonClicked")
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

                        If READ_PFK1312(txt_OrderNo.Data, getData(vS10, getColumIndex(vS10, "KEY_OrderNoSeq"), xROW)) Then
                            W1312 = D1312

                            If W1312.OrderDetailStatus = "1" Then
                                If CheckExist(W1312.OrderNo, W1312.OrderNoSeq) = True Then Exit Sub
                                If PrcExe("USP_ISUD1311A_sTAB1_ITEM_DELETE", cn, W1312.OrderNo, W1312.OrderNoSeq) = True Then
                                    SPR_DEL(vS10, 0, vS10.ActiveSheet.ActiveRowIndex)
                                    vS10.Focus()
                                    Exit Sub
                                End If
                            Else
                                MsgBoxP("Approval Already") : Exit Sub
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


#End Region

#Region "Search Line"

    Private Function DATA_SEARCH_VS10_LINE(OrderNo As String, OrderNoSeq As String) As Boolean
        Dim DSNEW As New DataSet

        DATA_SEARCH_VS10_LINE = False

        Try
            DSNEW = PrcDS("USP_ISU1311A_SEARCH_VS10_LINE", cn, OrderNo, OrderNoSeq)

            If GetDsRc(DSNEW) = 0 Then
                Exit Function
            End If
            READ_SPREAD(vS10, DSNEW, "USP_ISU1311A_SEARCH_VS10", "vS10", vS10.ActiveSheet.ActiveRowIndex)

            DATA_SEARCH_VS10_LINE = True
        Catch ex As Exception
            Call MsgBoxP("DATA_SEARCH_VS10_LINE")
        End Try
    End Function




#End Region

#Region "Keydown"

    Private Function CheckAprroval(OrderNo As String, OrderNoSeq As String) As Boolean
        CheckAprroval = False
        Try
            If READ_PFK1312(OrderNo, OrderNoSeq) = True Then
                W1312 = D1312
                If W1312.OrderDetailStatus = "1" Then CheckAprroval = True Else CheckAprroval = False
            End If
        Catch ex As Exception
            MsgBoxP("CheckAprroval")
        End Try
    End Function



#End Region

#Region "Sheet Change"



    Private Function CheckExist(OrderNo As String, OrderNoSeq As String) As Boolean
        CheckExist = False

        Dim RC As Integer
        Try
            rd = PrcDR("USP_ISUD1311A_SEARCH_VS00_CHECKEXIST", cn, OrderNo, OrderNoSeq)

            If rd.HasRows = True Then
                rd.Read()
                RC = rd!RC
                If RC > 0 Then MsgBoxP("Next Data Already!") : rd.Close() : CheckExist = True : Exit Function
            End If

            rd.Close()
        Catch ex As Exception

        Finally

            If rd IsNot Nothing Then
                If rd.IsClosed = False Then
                    rd.Close()
                End If
            End If
        End Try

    End Function


    Private Sub vS10_CellClick(sender As Object, e As CellClickEventArgs) Handles vS10.CellClick
        txt_OrderNoSeq.Data = getData(vS10, getColumIndex(vS10, "KEY_OrderNoSeq"), e.Row)
        txt_ShoesCode.Data = getData(vS10, getColumIndex(vS10, "ShoesCode"), e.Row)

        If READ_PFK7108_SHOESCODE(txt_ShoesCode.Data) Then
            txt_GroupComponentBOM.Data = D7108.GroupComponentBOM
        End If

    End Sub


#End Region


    Private Sub vS10_Change(sender As Object, e As ChangeEventArgs) Handles vS10.Change
        Try
            Dim QtyOrderSample01 As Decimal
            Dim QtyOrderSample02 As Decimal
            Dim QtyOrderSample As Decimal

            QtyOrderSample01 = CDecp(getData(vS10, getColumIndex(vS10, "QtyOrderSample01"), e.Row))
            QtyOrderSample02 = CDecp(getData(vS10, getColumIndex(vS10, "QtyOrderSample02"), e.Row))

            QtyOrderSample = QtyOrderSample01 + QtyOrderSample02
            setData(vS10, getColumIndex(vS10, "QtyOrderSample"), e.Row, QtyOrderSample)

            Dim strCode As String
            strCode = getData(vS10, getColumIndex(vS10, "Destination"), e.Row)

            If READ_PFK7171("160", strCode) And Len(strCode) = 3 Then
                setData(vS10, getColumIndex(vS10, "Destination"), e.Row, D7171.BasicName)
            End If


        Catch ex As Exception

        End Try
    End Sub
End Class