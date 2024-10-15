Imports System.Net.Mail
Imports System.Text
Imports System.IO.Ports

Public Class ISUD1311A

#Region "Variable"
    Private wJOB As Integer
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
    Private Link_W1313 As List(Of T1313_AREA)

    Dim rowList As Integer
    Dim rowChk As Integer
    Dim List1312KW As New List(Of T1312_AREA)
    Dim List1313KW As New List(Of T1313_AREA)

#End Region

#Region "Link"
    Public Function Link_ISUD1311A(job As Integer, OrderNo As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        D1311.OrderNo = OrderNo

        wJOB = job : L1311 = D1311

        Link_ISUD1311A = False
        Try

            Select Case job
                Case 1, 11
                  

                Case Else

                    If READ_PFK1312_APPROVAL(OrderNo) Then
                        wJOB = 2
                        cmd_DEL.Visible = False
                        cmd_OK.Visible = False
                    End If

                    cmd_Convert.Visible = False
                    cmd_Upload.Visible = False
            End Select

            If TAG = "PFP13120" Then
                If READ_PFK7171(ListCode("OrderGroup"), "001") Then
                    txt_cdOrderGroup.Code = D7171.BasicCode
                    txt_cdOrderGroup.Data = D7171.BasicName
                    txt_cdOrderGroup.Enabled = False
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

            Link_ISUD1311A = isudCHK

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
                    cmd_Convert.Visible = False

            End Select

            If TAG = "PFP13120" Then
                If READ_PFK7171(ListCode("OrderGroup"), "001") Then
                    txt_cdOrderGroup.Code = D7171.BasicCode
                    txt_cdOrderGroup.Data = D7171.BasicName
                    txt_cdOrderGroup.Enabled = False
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

                cmd_DEL.Visible = False

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
                    Call DATA_SEARCH_vS20()

                ElseIf Check_AutoLink = True Then
                    Call DATA_SEARCH_vS10_AUTO()
                    Call DATA_SEARCH_vS20_AUTO()

                End If

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
                Call DATA_SEARCH_vS20()

                cmd_DEL.Visible = False
                cmd_OK.Visible = False

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
                Call DATA_SEARCH_vS20()


                cmd_DEL.Visible = False

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
                Call DATA_SEARCH_vS20()


                cmd_DEL.Visible = True
                cmd_OK.Visible = False

        End Select

        formA = True
    End Sub

    Private Sub DATA_INIT()
        Try
            txt_OrderNo.Enabled = False
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
                vS10.ActiveSheet.RowCount = 1
                vS10.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS10, DS1, "USP_ISU1311A_SEARCH_VS10", "Vs10")
            Call DATA_SEARCH_CHECK_SPECNO()

            Dim i As Integer
            For i = 0 To vS10.ActiveSheet.RowCount - 1

                If READ_PFK1312(getData(vS10, getColumIndex(vS10, "KEY_OrderNo"), i), getData(vS10, getColumIndex(vS10, "KEY_OrderNoSeq"), i)) Then
                    If D1312.OrderDetailStatus <> "1" Then SPR_LOCK(vS10, i) : SPR_BACKCOLOR(vS10, cSprLockBackColor, i)
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
            SPR_PRO_NEW(vS10, DS1, "USP_ISU1311A_SEARCH_VS10", "Vs10")


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

                    'txt_cdDeliveryTerm.Code = D7101.cdDeliveryTerm

                    'txt_cdPaymentCondition.Code = D7101.cdPaymentCondition

                    'txt_cdPaymentDay.Code = D7101.cdPaymentDay

                    'txt_cdPaymentTerm.Code = D7101.cdPaymentTerm

                    'txt_cdPaymentTime.Code = D7101.cdPaymentTime

                End If

                txt_cdSeason.Code = D7106.cdSeason
                txt_cdOrderKind.Code = "001"
                txt_cdOrderType.Code = "001"
                txt_cdOrderWork.Code = "001"
                txt_cdMarketType.Code = "001"

                If READ_PFK7171(ListCode("Season"), txt_cdSeason.Code) = True Then txt_cdSeason.Data = D7171.BasicName

                If READ_PFK7171(ListCode("OrderKind"), txt_cdOrderKind.Code) = True Then txt_cdOrderKind.Data = D7171.BasicName
                If READ_PFK7171(ListCode("OrderType"), txt_cdOrderType.Code) = True Then txt_cdOrderType.Data = D7171.BasicName
                If READ_PFK7171(ListCode("OrderWork"), txt_cdOrderWork.Code) = True Then txt_cdOrderWork.Data = D7171.BasicName
                If READ_PFK7171(ListCode("MarketType"), txt_cdMarketType.Code) = True Then txt_cdMarketType.Data = D7171.BasicName

                If READ_PFK7171(ListCode("DeliveryTerm"), txt_cdDeliveryTerm.Code) = True Then txt_cdDeliveryTerm.Data = D7171.BasicName
                If READ_PFK7171(ListCode("PaymentCondition"), txt_cdPaymentCondition.Code) = True Then txt_cdPaymentCondition.Data = D7171.BasicName
                If READ_PFK7171(ListCode("PaymentDay"), txt_cdPaymentDay.Code) = True Then txt_cdPaymentDay.Data = D7171.BasicName
                If READ_PFK7171(ListCode("PaymentTerm"), txt_cdPaymentTerm.Code) = True Then txt_cdPaymentTerm.Data = D7171.BasicName
                If READ_PFK7171(ListCode("PaymentTime"), txt_cdPaymentTime.Code) = True Then txt_cdPaymentTime.Data = D7171.BasicName


            End If

            DATA_SEARCH_vS10_AUTO = True

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_SEARCH_vS10")
        End Try

    End Function

    Private Function DATA_SEARCH_vS20_AUTO() As Boolean
        DATA_SEARCH_vS20_AUTO = False
        Dim DSNEW As New DataSet

        Try
            DATA_SEARCH_vS20_AUTO = False
            Try

                DS1 = PrcDS("USP_ISU1311A_SEARCH_vS20_AUTO", cn, str_AutoLink)
                SPR_PRO_NEW(vS20, DS1, "USP_ISU1311A_SEARCH_vS20", "vS20")

                Call VsSizeRange(vS20, "USP_ISU1311A_SEARCH_VS20_HEAD_AUTO", str_AutoLink)
                'VsSizeRangeNew_Many(vS20, "USP_PFPSIZERANGE_MULTI", getColumIndex(vS20, "SizeQty01") - 1, txt_CustomerCode.Code)

                DATA_SEARCH_vS20_AUTO = True

            Catch ex As Exception
                Call MsgBoxP("35", "DATA_SEARCH_vS20")
            End Try
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_SEARCH_vS20")
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
    Private Function DATA_SEARCH_vS20() As Boolean
        DATA_SEARCH_vS20 = False
        Dim DSNEW As New DataSet

        Try
            DATA_SEARCH_vS20 = False
            Try

                DS1 = PrcDS("USP_ISU1311A_SEARCH_vS20", cn, L1311.OrderNo)

                If GetDsRc(DS1) = 0 Then
                    SPR_PRO_NEW(vS20, DS1, "USP_ISU1311A_SEARCH_vS20", "vS20")
                    vS20.Enabled = True
                    Exit Function
                End If

                SPR_PRO_NEW(vS20, DS1, "USP_ISU1311A_SEARCH_vS20", "vS20")
                Call VsSizeRange(vS20, "USP_ISU1311A_SEARCH_VS20_HEAD", L1311.OrderNo)

                Dim i As Integer
                For i = 0 To vS20.ActiveSheet.RowCount - 1

                    If READ_PFK1312(getData(vS20, getColumIndex(vS20, "KEY_OrderNo"), i), getData(vS20, getColumIndex(vS20, "KEY_OrderNoSeq"), i)) Then
                        'If D1312.OrderDetailStatus <> "1" Then SPR_LOCK(vS20, i) : SPR_BACKCOLOR(vS20, cSprLockBackColor, i)
                    End If
                Next


                DATA_SEARCH_vS20 = True

            Catch ex As Exception
                Call MsgBoxP("35", "DATA_SEARCH_vS20")
            End Try
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_SEARCH_vS20")
        End Try

    End Function

#End Region

#Region "Function"
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
            W1311.seUnitPrice = ListCode("UnitPrice")
            W1311.seShippingTerm = ListCode("ShippingTerm")
            W1311.seMarketType = ListCode("MarketType")

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
                W1311.cdUnitPrice = txt_cdUnitPrice.Code
                W1311.cdSeason = txt_cdSeason.Code
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
                W1311.cdUnitPrice = txt_cdUnitPrice.Code
                W1311.cdSeason = txt_cdSeason.Code
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
                'If Trim(getData(vS10, getColumIndex(vS10, "cdSpecStatus"), i)) = "" Then GoTo skip
                'If Trim(getData(vS10, getColumIndex(vS10, "cdSizeRange"), i)) = "" Then GoTo skip

                j = j + 1

                If K1312_MOVE(vS10, i, W1312, txt_OrderNo.Data, getData(vS10, getColumIndex(vS10, "KEY_OrderNoSeq"), i)) = True Then

                    DATA_MOVE_DEFAULT()

                    W1312.SizeRange = getData(vS10, getColumIndex(vS10, "SizeRange"), i)
                    Call REWRITE_PFK1312(W1312)

                    isudCHK = True
                Else
                    W1312.OrderNo = L1311.OrderNo

                    Call KEY_COUNT_PFK1312()

                    DATA_MOVE_DEFAULT()

                    W1312.SizeRange = getData(vS10, getColumIndex(vS10, "SizeRange"), i)
                    W1312.OrderDetailStatus = "1"
                    W1312.DateOrder = Pub.DAT
                    W1312.DateInsert = Pub.DAT
                    W1312.InchargeInsert = Pub.DAT

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

            For i = 0 To vS20.ActiveSheet.RowCount - 1
                If Trim(getData(vS10, getColumIndex(vS10, "KEY_OrderNo"), i)) = "" Then GoTo skip

                j = j + 1

                If K1313_MOVE(vS20, i, W1313, txt_OrderNo.Data, getData(vS20, getColumIndex(vS20, "KEY_OrderNoSeq"), i)) = True Then

                    W1313.SizeQty01 = CDblp(getData(vS20, colstart, i))
                    W1313.SizeQty02 = CDblp(getData(vS20, colstart + 1, i))
                    W1313.SizeQty03 = CDblp(getData(vS20, colstart + 2, i))
                    W1313.SizeQty04 = CDblp(getData(vS20, colstart + 3, i))
                    W1313.SizeQty05 = CDblp(getData(vS20, colstart + 4, i))
                    W1313.SizeQty06 = CDblp(getData(vS20, colstart + 5, i))
                    W1313.SizeQty07 = CDblp(getData(vS20, colstart + 6, i))
                    W1313.SizeQty08 = CDblp(getData(vS20, colstart + 7, i))
                    W1313.SizeQty09 = CDblp(getData(vS20, colstart + 8, i))
                    W1313.SizeQty10 = CDblp(getData(vS20, colstart + 9, i))
                    W1313.SizeQty11 = CDblp(getData(vS20, colstart + 10, i))
                    W1313.SizeQty12 = CDblp(getData(vS20, colstart + 11, i))
                    W1313.SizeQty13 = CDblp(getData(vS20, colstart + 12, i))
                    W1313.SizeQty14 = CDblp(getData(vS20, colstart + 13, i))
                    W1313.SizeQty15 = CDblp(getData(vS20, colstart + 14, i))
                    W1313.SizeQty16 = CDblp(getData(vS20, colstart + 15, i))
                    W1313.SizeQty17 = CDblp(getData(vS20, colstart + 16, i))
                    W1313.SizeQty18 = CDblp(getData(vS20, colstart + 17, i))
                    W1313.SizeQty19 = CDblp(getData(vS20, colstart + 18, i))
                    W1313.SizeQty20 = CDblp(getData(vS20, colstart + 19, i))
                    W1313.SizeQty21 = CDblp(getData(vS20, colstart + 20, i))
                    W1313.SizeQty22 = CDblp(getData(vS20, colstart + 21, i))
                    W1313.SizeQty23 = CDblp(getData(vS20, colstart + 22, i))
                    W1313.SizeQty24 = CDblp(getData(vS20, colstart + 23, i))
                    W1313.SizeQty25 = CDblp(getData(vS20, colstart + 24, i))
                    W1313.SizeQty26 = CDblp(getData(vS20, colstart + 25, i))
                    W1313.SizeQty27 = CDblp(getData(vS20, colstart + 26, i))
                    W1313.SizeQty28 = CDblp(getData(vS20, colstart + 27, i))
                    W1313.SizeQty29 = CDblp(getData(vS20, colstart + 28, i))
                    W1313.SizeQty30 = CDblp(getData(vS20, colstart + 29, i))

                    If REWRITE_PFK1313(W1313) Then
                        Call PrcExe("USP_PFK1312_UPDATE_SIZEQTY", cn, W1313.OrderNo)
                    End If
                    isudCHK = True

                Else

                    W1313.OrderNo = L1311.OrderNo
                    W1313.OrderNoSeq = getData(vS10, getColumIndex(vS10, "KEY_OrderNoSeq"), i)

                    W1313.SizeQty01 = CDblp(getData(vS20, colstart, i))
                    W1313.SizeQty02 = CDblp(getData(vS20, colstart + 1, i))
                    W1313.SizeQty03 = CDblp(getData(vS20, colstart + 2, i))
                    W1313.SizeQty04 = CDblp(getData(vS20, colstart + 3, i))
                    W1313.SizeQty05 = CDblp(getData(vS20, colstart + 4, i))
                    W1313.SizeQty06 = CDblp(getData(vS20, colstart + 5, i))
                    W1313.SizeQty07 = CDblp(getData(vS20, colstart + 6, i))
                    W1313.SizeQty08 = CDblp(getData(vS20, colstart + 7, i))
                    W1313.SizeQty09 = CDblp(getData(vS20, colstart + 8, i))
                    W1313.SizeQty10 = CDblp(getData(vS20, colstart + 9, i))
                    W1313.SizeQty11 = CDblp(getData(vS20, colstart + 10, i))
                    W1313.SizeQty12 = CDblp(getData(vS20, colstart + 11, i))
                    W1313.SizeQty13 = CDblp(getData(vS20, colstart + 12, i))
                    W1313.SizeQty14 = CDblp(getData(vS20, colstart + 13, i))
                    W1313.SizeQty15 = CDblp(getData(vS20, colstart + 14, i))
                    W1313.SizeQty16 = CDblp(getData(vS20, colstart + 15, i))
                    W1313.SizeQty17 = CDblp(getData(vS20, colstart + 16, i))
                    W1313.SizeQty18 = CDblp(getData(vS20, colstart + 17, i))
                    W1313.SizeQty19 = CDblp(getData(vS20, colstart + 18, i))
                    W1313.SizeQty20 = CDblp(getData(vS20, colstart + 19, i))
                    W1313.SizeQty21 = CDblp(getData(vS20, colstart + 20, i))
                    W1313.SizeQty22 = CDblp(getData(vS20, colstart + 21, i))
                    W1313.SizeQty23 = CDblp(getData(vS20, colstart + 22, i))
                    W1313.SizeQty24 = CDblp(getData(vS20, colstart + 23, i))
                    W1313.SizeQty25 = CDblp(getData(vS20, colstart + 24, i))
                    W1313.SizeQty26 = CDblp(getData(vS20, colstart + 25, i))
                    W1313.SizeQty27 = CDblp(getData(vS20, colstart + 26, i))
                    W1313.SizeQty28 = CDblp(getData(vS20, colstart + 27, i))
                    W1313.SizeQty29 = CDblp(getData(vS20, colstart + 28, i))
                    W1313.SizeQty30 = CDblp(getData(vS20, colstart + 29, i))

                    If WRITE_PFK1313(W1313) Then
                        Call PrcExe("USP_PFK1312_UPDATE_SIZEQTY", cn, W1313.OrderNo)
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

            If Trim(getData(vS20, getColumIndex(vS20, "KEY_OrderNo"), i)) = "" Then Exit Function

            j = j + 1
            colstart += 1
            If K1313_MOVE(vS20, i, W1313, txt_OrderNo.Data, getData(vS20, getColumIndex(vS20, "KEY_OrderNoSeq"), i)) = True Then

                W1313.SizeQty01 = CDblp(getData(vS20, colstart, i))
                W1313.SizeQty02 = CDblp(getData(vS20, colstart + 1, i))
                W1313.SizeQty03 = CDblp(getData(vS20, colstart + 2, i))
                W1313.SizeQty04 = CDblp(getData(vS20, colstart + 3, i))
                W1313.SizeQty05 = CDblp(getData(vS20, colstart + 4, i))
                W1313.SizeQty06 = CDblp(getData(vS20, colstart + 5, i))
                W1313.SizeQty07 = CDblp(getData(vS20, colstart + 6, i))
                W1313.SizeQty08 = CDblp(getData(vS20, colstart + 7, i))
                W1313.SizeQty09 = CDblp(getData(vS20, colstart + 8, i))
                W1313.SizeQty10 = CDblp(getData(vS20, colstart + 9, i))
                W1313.SizeQty11 = CDblp(getData(vS20, colstart + 10, i))
                W1313.SizeQty12 = CDblp(getData(vS20, colstart + 11, i))
                W1313.SizeQty13 = CDblp(getData(vS20, colstart + 12, i))
                W1313.SizeQty14 = CDblp(getData(vS20, colstart + 13, i))
                W1313.SizeQty15 = CDblp(getData(vS20, colstart + 14, i))
                W1313.SizeQty16 = CDblp(getData(vS20, colstart + 15, i))
                W1313.SizeQty17 = CDblp(getData(vS20, colstart + 16, i))
                W1313.SizeQty18 = CDblp(getData(vS20, colstart + 17, i))
                W1313.SizeQty19 = CDblp(getData(vS20, colstart + 18, i))
                W1313.SizeQty20 = CDblp(getData(vS20, colstart + 19, i))
                W1313.SizeQty21 = CDblp(getData(vS20, colstart + 20, i))
                W1313.SizeQty22 = CDblp(getData(vS20, colstart + 21, i))
                W1313.SizeQty23 = CDblp(getData(vS20, colstart + 22, i))
                W1313.SizeQty24 = CDblp(getData(vS20, colstart + 23, i))
                W1313.SizeQty25 = CDblp(getData(vS20, colstart + 24, i))
                W1313.SizeQty26 = CDblp(getData(vS20, colstart + 25, i))
                W1313.SizeQty27 = CDblp(getData(vS20, colstart + 26, i))
                W1313.SizeQty28 = CDblp(getData(vS20, colstart + 27, i))
                W1313.SizeQty29 = CDblp(getData(vS20, colstart + 28, i))
                W1313.SizeQty30 = CDblp(getData(vS20, colstart + 29, i))

                Call REWRITE_PFK1313(W1313)
                isudCHK = True

            Else

                W1313.OrderNo = L1311.OrderNo
                W1313.OrderNoSeq = getData(vS20, getColumIndex(vS20, "KEY_OrderNoSeq"), i)

                W1313.SizeQty01 = CDblp(getData(vS20, colstart, i))
                W1313.SizeQty02 = CDblp(getData(vS20, colstart + 1, i))
                W1313.SizeQty03 = CDblp(getData(vS20, colstart + 2, i))
                W1313.SizeQty04 = CDblp(getData(vS20, colstart + 3, i))
                W1313.SizeQty05 = CDblp(getData(vS20, colstart + 4, i))
                W1313.SizeQty06 = CDblp(getData(vS20, colstart + 5, i))
                W1313.SizeQty07 = CDblp(getData(vS20, colstart + 6, i))
                W1313.SizeQty08 = CDblp(getData(vS20, colstart + 7, i))
                W1313.SizeQty09 = CDblp(getData(vS20, colstart + 8, i))
                W1313.SizeQty10 = CDblp(getData(vS20, colstart + 9, i))
                W1313.SizeQty11 = CDblp(getData(vS20, colstart + 10, i))
                W1313.SizeQty12 = CDblp(getData(vS20, colstart + 11, i))
                W1313.SizeQty13 = CDblp(getData(vS20, colstart + 12, i))
                W1313.SizeQty14 = CDblp(getData(vS20, colstart + 13, i))
                W1313.SizeQty15 = CDblp(getData(vS20, colstart + 14, i))
                W1313.SizeQty16 = CDblp(getData(vS20, colstart + 15, i))
                W1313.SizeQty17 = CDblp(getData(vS20, colstart + 16, i))
                W1313.SizeQty18 = CDblp(getData(vS20, colstart + 17, i))
                W1313.SizeQty19 = CDblp(getData(vS20, colstart + 18, i))
                W1313.SizeQty20 = CDblp(getData(vS20, colstart + 19, i))
                W1313.SizeQty21 = CDblp(getData(vS20, colstart + 20, i))
                W1313.SizeQty22 = CDblp(getData(vS20, colstart + 21, i))
                W1313.SizeQty23 = CDblp(getData(vS20, colstart + 22, i))
                W1313.SizeQty24 = CDblp(getData(vS20, colstart + 23, i))
                W1313.SizeQty25 = CDblp(getData(vS20, colstart + 24, i))
                W1313.SizeQty26 = CDblp(getData(vS20, colstart + 25, i))
                W1313.SizeQty27 = CDblp(getData(vS20, colstart + 26, i))
                W1313.SizeQty28 = CDblp(getData(vS20, colstart + 27, i))
                W1313.SizeQty29 = CDblp(getData(vS20, colstart + 28, i))
                W1313.SizeQty30 = CDblp(getData(vS20, colstart + 29, i))

                Call WRITE_PFK1313(W1313)

                isudCHK = True

            End If


            DATA_MOVE_WRITE03_ROW = True

        Catch ex As Exception
            MsgBoxP("DATA_MOVE_WRITE03_ROW")
        End Try

    End Function
    Private Function Data_Check() As Boolean
        Data_Check = False
        Dim i As Integer

        Try
            For i = 0 To vS10.ActiveSheet.RowCount - 1
                If getData(vS10, getColumIndex(vS10, "SizeRange"), i).ToString.Trim = "" Then MsgBoxP("Size Range at Row " & (i + 1)) : Exit Function
                If getData(vS10, getColumIndex(vS10, "ShoesCode"), i).ToString.Trim = "" Then MsgBoxP("ITEM CODE at Row " & (i + 1)) : Exit Function

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
                'If getData(vS10, getColumIndex(vS10, "cdSpecStatus"), i).ToString.Trim = "" Then MsgBoxP("Spec Status at Row " & (i + 1)) : Exit Function

                'If READ_PFK1312_SEASON(txt_cdSeason.Code, getData(vS10, getColumIndex(vS10, "SlNo"), i)) Then MsgBoxP("Already Slno at Row " & (i + 1)) : Exit Function

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

                W1311.Buyer = L1311.Buyer
                W1311.Destination = L1311.Destination

                W1311.OrderNo = L1311.OrderNo
                W1311.CustPoNo = txt_CustPoNo.Data

                If WRITE_PFK1311(W1311) = True Then

                    Call DATA_MOVE_WRITE02()
                    Call DATA_SEARCH_vS10()
                    Call DATA_MOVE_WRITE03()
                    Call DATA_SEARCH_vS20()
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

                If REWRITE_PFK1311(W1311) = True Then
                    Call DATA_MOVE_WRITE02()
                    Call DATA_MOVE_WRITE03()
                    Call DATA_SEARCH_vS10()
                    Call DATA_SEARCH_vS20()
                    Call MsgBoxP("Update Successfully !", vbInformation)

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

            Dim lENsLNO As String

            Call READ_PFK7101(txt_CustomerCode.Code)
            Call READ_PFK7171(ListCode("StateOfficial"), txt_cdStateOfficial.Code)

            lENsLNO = D7101.CustomerNameSimply.Length

            SQL = "SELECT MAX( CAST (RIGHT([K1312_SLNo], LEN([K1312_SLNo]) - " & lENsLNO & " - LEN( ISNULL(K7171_NameSimply,'')) ) AS INT) ) AS MAX_MCODE "
            SQL = SQL & "  FROM  [PFK1312] "
            SQL = SQL & "  INNER JOIN PFK1311 ON K1312_OrderNo = K1311_OrderNo "
            SQL = SQL & "  INNER JOIN PFK7101 ON	K1311_CustomerCode = K7101_CustomerCode "
            SQL = SQL & "  INNER JOIN PFK7171 ON  K7171_BasicCode = K1311_cdStateOfficial AND K7171_BasicSel  = K1311_seStateOfficial "
            SQL = SQL & " WHERE K1311_CustomerCode = '" & txt_CustomerCode.Code & "' "
            SQL = SQL & "  AND ISNULL(K7101_CustomerNameSimply,'') = LEFT([K1312_SLNo]," & lENsLNO & " )  "
            SQL = SQL & "  AND SUBSTRING([K1312_SLNo]," & lENsLNO + 1 & " ,LEN( ISNULL(K7171_NameSimply,'')) ) = ISNULL(K7171_NameSimply,'') "
            SQL = SQL & "  AND K1311_cdSeason           = '" & txt_cdSeason.Code & "' "
            SQL = SQL & "  AND K1311_cdStateOfficial    = '" & txt_cdStateOfficial.Code & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                W1312.SLNoSys = "0001"
            Else
                W1312.SLNoSys = CIntp(rd!MAX_MCODE + 1).ToString("0000")
            End If



            W1312.SLNoSys = D7101.CustomerNameSimply & D7171.NameSimply & W1312.SLNoSys
            W1312.SLNoSys = Trim(W1312.SLNoSys)

            L1312.SLNoSys = W1312.SLNoSys


            W1312.SLNo = W1312.SLNoSys
            L1312.SLNo = W1312.SLNoSys

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
    Private Function GEOX_LOADING(ByVal ListC As List(Of String)) As Boolean
        GEOX_LOADING = False
        Try

            Dim k As Integer
            Dim l As Integer

            Dim CC As Integer ' continue searcj

            Dim ListJobCard As New List(Of String)
            Dim ListShoesCode As New List(Of String)
            Dim ListSize As New List(Of String)


            Dim ListQuantity As New List(Of String)
            Dim List1312 As New List(Of T1312_AREA)
            Dim List1313 As New List(Of T1313_AREA)

            Dim ListSizeRange As New List(Of T7104_AREA)

            Dim ListSizeArray As New List(Of List(Of String))

            Dim ListSizeRangeString As New List(Of String)
            Dim SizeRangeL As String
            Dim ListSizeL As String

            Dim ListSize1704 As New List(Of T7104_AREA)
            Dim ChkQuantiy As Boolean = False
            Dim ChkSize As Boolean = False


            Dim LastPA As Integer
            Dim LastMinus As Integer

            DS1 = PrcDS("USP_ISUD_K7104_MULTI_CHECK", cn, txt_CustomerCode.Code)

            For Each RD01 As DataRow In DS1.Tables(0).Rows
                D7104_CLEAR()
                Call K7104_MOVE(RD01)
                ListSizeRange.Add(D7104)

                SizeRangeL = ""
                For rowList = 0 To DS1.Tables(0).Columns.Count - 1
                    SizeRangeL = SizeRangeL & RD01.Item(rowList).ToString & ","
                Next

                ListSizeRangeString.Add(SizeRangeL)
            Next


            For rowList = 0 To ListC.Count - 1
                If ListC(rowList).Contains("Job card") Then
                    rowChk = rowList
                    ListJobCard.AddRange(ListC(rowList).ToString.Split(" "))
                    ListShoesCode.AddRange(ListC(rowList + 1).ToString.Split(" "))
                    ListSizeL = ""

                    For rowChk = rowList + 1 To rowList + 20

                        If ListC(rowChk).Contains(".Size") And ChkSize = False Then
                            ListSize.AddRange(ListC(rowChk).ToString.Split(" "))
                            ListSize.RemoveAt(0)

                            For k = 0 To ListSize.Count - 1
                                If ListSize(k).ToString.Replace(" ", "").Replace(Chr(13), "").Replace(Chr(10), "") <> "" Then

                                    If ListSizeL.Contains(ListSize(k).ToString.Replace(" ", "").Replace(Chr(13), "").Replace(Chr(10), "")) = False Then
                                        ListSizeL = ListSizeL & ListSize(k).ToString.Replace(" ", "").Replace(Chr(13), "").Replace(Chr(10), "") & ","
                                    End If

                                End If
                            Next

                            For CC = 1 To 20
                                If ListC(rowChk + CC).Contains("Job card") = True Then ChkSize = True : Exit For

                                If ListC(rowChk + CC).Contains(".Size") And ChkSize = False Then
                                    ListC(rowChk + CC) = ListC(rowChk + CC).ToString.Replace(".Size", "")
                                    ListC(rowChk + CC) = Trim(ListC(rowChk + CC))

                                    ListSize.AddRange(ListC(rowChk + CC).ToString.Split(" "))

                                    For k = 0 To ListSize.Count - 1
                                        If ListSize(k).ToString.Replace(" ", "").Replace(Chr(13), "").Replace(Chr(10), "") <> "" Then
                                            If ListSizeL.Contains(ListSize(k).ToString.Replace(" ", "").Replace(Chr(13), "").Replace(Chr(10), "")) = False Then
                                                ListSizeL = ListSizeL & ListSize(k).ToString.Replace(" ", "").Replace(Chr(13), "").Replace(Chr(10), "") & ","
                                            End If
                                        End If
                                    Next

                                End If

                            Next

                        End If

                        If ListC(rowChk).Contains("Quantity") And ListC(rowChk).Contains("Item") = False And ListC(rowChk).Contains("Amount") = False And ChkQuantiy = False Then
                            ListC(rowChk) = ListC(rowChk).ToString
                            ListQuantity.AddRange(ListC(rowChk).ToString.Split(" "))
                            'ListQuantity.RemoveAt(0)

                            For CC = 1 To 20
                                If ListC(rowChk + CC).Contains("Job card") = True Then ChkQuantiy = True : Exit For

                                If ListC(rowChk + CC).Contains("Quantity") And ListC(rowChk + CC).Contains("Item") = False And ListC(rowChk + CC).Contains("Amount") = False Then
                                    ListC(rowChk + CC) = ListC(rowChk + CC).ToString.Replace("Quantity", "").Replace(Chr(13), "").Replace(Chr(10), "")
                                    ListC(rowChk + CC) = Trim(ListC(rowChk + CC))

                                    ListQuantity.AddRange(ListC(rowChk + CC).ToString.Split(" "))
                                    'ListQuantity.RemoveAt(0)
                                End If

                            Next

                            If READ_PFK7106_1_GX(txt_cdSeason.Code, "006", FormatCut(ListShoesCode(0)), Strings.Right(ListShoesCode(1), 4), Strings.Right(ListShoesCode(2), 4)) Then

                                l = ListQuantity.Count - 1

                                While l >= 0
                                    If IsNumeric(ListQuantity(l)) = False Then
                                        ListQuantity.RemoveAt(l)
                                    End If

                                    l -= 1
                                End While


                                l = ListSize.Count - 1
                                While l >= 0
                                    If ListSize(l).Replace(Chr(13), "").Replace(Chr(10), "").Replace(" ", "") = "" Then
                                        ListSize.RemoveAt(l)
                                    End If
                                    l -= 1
                                End While


                                For l = 4 To ListShoesCode.Count - 1
                                    If FormatCutAll(ListShoesCode(l)) = "PA" Then
                                        LastPA = l
                                    End If
                                Next

                                For k = 0 To ListSizeRangeString.Count - 1
                                    If CheckListContaint(ListSizeRangeString(k), ListSizeL) Then
                                        D1313_CLEAR()

                                        For l = 0 To ListSize.Count - 1

                                            Select Case READ_PFK7104_SZNO(ListSizeRangeString(k).Substring(0, 6), ListSize(l))

                                                Case "01" : D1313.SizeQty01 = ListQuantity(l)
                                                Case "02" : D1313.SizeQty02 = ListQuantity(l)
                                                Case "03" : D1313.SizeQty03 = ListQuantity(l)
                                                Case "04" : D1313.SizeQty04 = ListQuantity(l)
                                                Case "05" : D1313.SizeQty05 = ListQuantity(l)
                                                Case "06" : D1313.SizeQty06 = ListQuantity(l)
                                                Case "07" : D1313.SizeQty07 = ListQuantity(l)
                                                Case "08" : D1313.SizeQty08 = ListQuantity(l)
                                                Case "09" : D1313.SizeQty09 = ListQuantity(l)
                                                Case "10" : D1313.SizeQty10 = ListQuantity(l)
                                                Case "11" : D1313.SizeQty11 = ListQuantity(l)
                                                Case "12" : D1313.SizeQty12 = ListQuantity(l)
                                                Case "13" : D1313.SizeQty13 = ListQuantity(l)
                                                Case "14" : D1313.SizeQty14 = ListQuantity(l)
                                                Case "15" : D1313.SizeQty15 = ListQuantity(l)
                                                Case "16" : D1313.SizeQty16 = ListQuantity(l)
                                                Case "17" : D1313.SizeQty17 = ListQuantity(l)
                                                Case "18" : D1313.SizeQty18 = ListQuantity(l)
                                                Case "19" : D1313.SizeQty19 = ListQuantity(l)
                                                Case "20" : D1313.SizeQty20 = ListQuantity(l)
                                                Case "21" : D1313.SizeQty21 = ListQuantity(l)
                                                Case "22" : D1313.SizeQty22 = ListQuantity(l)
                                                Case "23" : D1313.SizeQty23 = ListQuantity(l)
                                                Case "24" : D1313.SizeQty24 = ListQuantity(l)
                                                Case "25" : D1313.SizeQty25 = ListQuantity(l)
                                                Case "26" : D1313.SizeQty26 = ListQuantity(l)
                                                Case "27" : D1313.SizeQty27 = ListQuantity(l)
                                                Case "28" : D1313.SizeQty28 = ListQuantity(l)
                                                Case "29" : D1313.SizeQty29 = ListQuantity(l)
                                                Case "30" : D1313.SizeQty30 = ListQuantity(l)


                                            End Select


                                        Next

                                        D1312_CLEAR()
                                        D1312.ShoesCode = D7106.ShoesCode
                                        D1312.JbCard = ListJobCard(4) & ListJobCard(5)
                                        D1312.PONO = txt_CustPoNo.Data
                                        D1312.DateOrder = Pub.DAT
                                        D1312.Datedelivery = ListJobCard(8)

                                        Dim QtyOrder As String
                                        QtyOrder = ListShoesCode(LastPA + 1).Replace(",", ":")
                                        QtyOrder = QtyOrder.Replace(".", ",")
                                        QtyOrder = QtyOrder.Replace(":", ".")

                                        D1312.QtyOrder = CDecp(QtyOrder)

                                        List1312.Add(D1312)
                                        List1313.Add(D1313)

                                        Exit For

                                    End If
                                Next



                            ElseIf READ_PFK7106_ALL_GX(ListShoesCode(0), Strings.Right(ListShoesCode(1), 4), Strings.Right(ListShoesCode(2), 4)) Then
                                W7106 = D7106
                                W7106.ShoesCodeBase = D7106.ShoesCode

                                W7106.cdSpecState = "006"
                                W7106.cdSeason = txt_cdSeason.Code


                                W7106.Customercode = txt_CustomerCode.Code
                                W7106.SizeRange = ListShoesCode(3)
                                W7106.DateInsert = Pub.DAT
                                W7106.InchargeInsert = Pub.SAW
                                W7106.Remark = "AUTO INSERT PFK7106 PFK1311- NOT PROD"
                                W7106.CheckUse = "2"
                                Call KEY_COUNT_K7106()

                                W7106.seGender = ListCode("Gender")
                                W7106.seSeason = ListCode("Season")
                                W7106.seSpecState = ListCode("SpecState")

                                W7106.Line = ListShoesCode(3)

                                For l = 4 To ListShoesCode.Count - 1
                                    If FormatCutAll(ListShoesCode(l)) = "PA" Then
                                        LastPA = l
                                    End If
                                Next

                                For l = 4 To ListShoesCode.Count - 1
                                    If ListShoesCode(l) = "-" Then
                                        LastMinus = l
                                    End If
                                Next

                                W7106.ColorCode = Strings.Right(ListShoesCode(2), 4)
                                W7106.MCODE = Strings.Right(ListShoesCode(1), 4)
                                W7106.MCODEName = ListShoesCode(LastMinus + 1)

                                W7106.ColorName = ""

                                For l = LastMinus + 2 To LastPA - 1
                                    W7106.ColorName = W7106.ColorName & Space(1) & ListShoesCode(l)
                                Next


                                For l = 4 To LastPA - 3

                                    If ListShoesCode(l) <> "-" Then
                                        W7106.Line = W7106.Line & Space(1) & ListShoesCode(l)

                                    ElseIf ListShoesCode(l) = "-" Then
                                        Exit For
                                    End If

                                Next

                                W7106.ColorName = Trim(W7106.ColorName)
                                W7106.Line = Trim(W7106.Line)

                                D1312_CLEAR()
                                D1312.ShoesCode = W7106.ShoesCode
                                D1312.JbCard = ListJobCard(0)
                                D1312.PONO = ""
                                D1312.DateOrder = Pub.DAT
                                D1312.Datedelivery = ListJobCard(0)

                                Dim QtyOrder As String
                                QtyOrder = ListShoesCode(LastPA + 1).Replace(",", ":")
                                QtyOrder = QtyOrder.Replace(".", ",")
                                QtyOrder = QtyOrder.Replace(":", ".")

                                D1312.QtyOrder = CDecp(QtyOrder)


                                ListSize.Clear()
                                ListSize.AddRange(ListSizeL.Split(","))

                                l = ListQuantity.Count - 1

                                While l >= 0
                                    If IsNumeric(ListQuantity(l)) = False Then
                                        ListQuantity.RemoveAt(l)

                                    End If
                                    l -= 1
                                End While


                                l = ListSize.Count - 1
                                While l >= 0
                                    If ListSize(l).Replace(Chr(13), "").Replace(Chr(10), "").Replace(" ", "") = "" Then
                                        ListSize.RemoveAt(l)
                                    End If
                                    l -= 1
                                End While

                                For k = 0 To ListSizeRangeString.Count - 1
                                    If CheckListContaint(ListSizeRangeString(k), ListSizeL) Then
                                        D1313_CLEAR()

                                        For l = 0 To ListSize.Count - 1
                                            Select Case READ_PFK7104_SZNO(ListSizeRangeString(k).Substring(0, 6), ListSize(l))

                                                Case "01" : D1313.SizeQty01 = ListQuantity(l)
                                                Case "02" : D1313.SizeQty02 = ListQuantity(l)
                                                Case "03" : D1313.SizeQty03 = ListQuantity(l)
                                                Case "04" : D1313.SizeQty04 = ListQuantity(l)
                                                Case "05" : D1313.SizeQty05 = ListQuantity(l)
                                                Case "06" : D1313.SizeQty06 = ListQuantity(l)
                                                Case "07" : D1313.SizeQty07 = ListQuantity(l)
                                                Case "08" : D1313.SizeQty08 = ListQuantity(l)
                                                Case "09" : D1313.SizeQty09 = ListQuantity(l)
                                                Case "10" : D1313.SizeQty10 = ListQuantity(l)
                                                Case "11" : D1313.SizeQty11 = ListQuantity(l)
                                                Case "12" : D1313.SizeQty12 = ListQuantity(l)
                                                Case "13" : D1313.SizeQty13 = ListQuantity(l)
                                                Case "14" : D1313.SizeQty14 = ListQuantity(l)
                                                Case "15" : D1313.SizeQty15 = ListQuantity(l)
                                                Case "16" : D1313.SizeQty16 = ListQuantity(l)
                                                Case "17" : D1313.SizeQty17 = ListQuantity(l)
                                                Case "18" : D1313.SizeQty18 = ListQuantity(l)
                                                Case "19" : D1313.SizeQty19 = ListQuantity(l)
                                                Case "20" : D1313.SizeQty20 = ListQuantity(l)
                                                Case "21" : D1313.SizeQty21 = ListQuantity(l)
                                                Case "22" : D1313.SizeQty22 = ListQuantity(l)
                                                Case "23" : D1313.SizeQty23 = ListQuantity(l)
                                                Case "24" : D1313.SizeQty24 = ListQuantity(l)
                                                Case "25" : D1313.SizeQty25 = ListQuantity(l)
                                                Case "26" : D1313.SizeQty26 = ListQuantity(l)
                                                Case "27" : D1313.SizeQty27 = ListQuantity(l)
                                                Case "28" : D1313.SizeQty28 = ListQuantity(l)
                                                Case "29" : D1313.SizeQty29 = ListQuantity(l)
                                                Case "30" : D1313.SizeQty30 = ListQuantity(l)


                                            End Select


                                        Next

                                        W7106.SizeRange = ListSizeRangeString(k).Substring(0, 6)
                                        Call WRITE_PFK7106(W7106)

                                        D1312_CLEAR()
                                        D1312.ShoesCode = D7106.ShoesCode
                                        D1312.JbCard = ListJobCard(4) & ListJobCard(5)
                                        D1312.PONO = txt_CustPoNo.Data
                                        D1312.DateOrder = Pub.DAT
                                        D1312.Datedelivery = ListJobCard(8)

                                        List1312.Add(D1312)
                                        List1313.Add(D1313)

                                        Exit For

                                    End If
                                Next


                            Else
                                W7106 = D7106
                                W7106.ShoesCodeBase = D7106.ShoesCode

                                W7106.cdSpecState = "006"
                                W7106.cdSeason = txt_cdSeason.Code

                                W7106.Article = ListShoesCode(0)
                                W7106.seGender = ListCode("Gender")
                                W7106.seSeason = ListCode("Season")
                                W7106.seSpecState = ListCode("SpecState")


                                W7106.Line = ListShoesCode(3)

                                For l = 4 To ListShoesCode.Count - 1
                                    If FormatCutAll(ListShoesCode(l)) = "PA" Then
                                        LastPA = l
                                    End If
                                Next

                                For l = 4 To ListShoesCode.Count - 1
                                    If ListShoesCode(l) = "-" Then
                                        LastMinus = l
                                    End If
                                Next

                                W7106.ColorName = ""
                                W7106.ColorCode = Strings.Right(ListShoesCode(2), 4)
                                W7106.MCODE = Strings.Right(ListShoesCode(1), 4)
                                W7106.MCODEName = ListShoesCode(LastMinus + 1)

                                For l = LastMinus + 2 To LastPA - 1
                                    W7106.ColorName = W7106.ColorName & Space(1) & ListShoesCode(l)
                                Next


                                For l = 4 To LastPA - 3

                                    If ListShoesCode(l) <> "-" Then
                                        W7106.Line = W7106.Line & Space(1) & ListShoesCode(l)

                                    ElseIf ListShoesCode(l) = "-" Then
                                        Exit For
                                    End If

                                Next

                                W7106.ColorName = Trim(W7106.ColorName)
                                W7106.Line = Trim(W7106.Line)


                                W7106.Customercode = txt_CustomerCode.Code
                                W7106.SizeRange = ListShoesCode(3)
                                W7106.DateInsert = Pub.DAT
                                W7106.InchargeInsert = Pub.SAW
                                W7106.Remark = "AUTO INSERT PFK7106 FROM PFK1311 - NO SHOES"
                                W7106.CheckUse = "2"
                                Call KEY_COUNT_K7106()

                                l = ListQuantity.Count - 1

                                While l >= 0
                                    If IsNumeric(ListQuantity(l)) = False Then
                                        ListQuantity.RemoveAt(l)

                                    End If
                                    l -= 1
                                End While


                                l = ListSize.Count - 1
                                While l >= 0
                                    If ListSize(l).Replace(Chr(13), "").Replace(Chr(10), "").Replace(" ", "") = "" Then
                                        ListSize.RemoveAt(l)
                                    End If
                                    l -= 1

                                End While


                                For k = 0 To ListSizeRangeString.Count - 1
                                    If CheckListContaint(ListSizeRangeString(k), ListSizeL) Then
                                        D1313_CLEAR()

                                        For l = 0 To ListSize.Count - 1
                                            Select Case READ_PFK7104_SZNO(ListSizeRangeString(k).Substring(0, 6), ListSize(l))

                                                Case "01" : D1313.SizeQty01 = ListQuantity(l)
                                                Case "02" : D1313.SizeQty02 = ListQuantity(l)
                                                Case "03" : D1313.SizeQty03 = ListQuantity(l)
                                                Case "04" : D1313.SizeQty04 = ListQuantity(l)
                                                Case "05" : D1313.SizeQty05 = ListQuantity(l)
                                                Case "06" : D1313.SizeQty06 = ListQuantity(l)
                                                Case "07" : D1313.SizeQty07 = ListQuantity(l)
                                                Case "08" : D1313.SizeQty08 = ListQuantity(l)
                                                Case "09" : D1313.SizeQty09 = ListQuantity(l)
                                                Case "10" : D1313.SizeQty10 = ListQuantity(l)
                                                Case "11" : D1313.SizeQty11 = ListQuantity(l)
                                                Case "12" : D1313.SizeQty12 = ListQuantity(l)
                                                Case "13" : D1313.SizeQty13 = ListQuantity(l)
                                                Case "14" : D1313.SizeQty14 = ListQuantity(l)
                                                Case "15" : D1313.SizeQty15 = ListQuantity(l)
                                                Case "16" : D1313.SizeQty16 = ListQuantity(l)
                                                Case "17" : D1313.SizeQty17 = ListQuantity(l)
                                                Case "18" : D1313.SizeQty18 = ListQuantity(l)
                                                Case "19" : D1313.SizeQty19 = ListQuantity(l)
                                                Case "20" : D1313.SizeQty20 = ListQuantity(l)
                                                Case "21" : D1313.SizeQty21 = ListQuantity(l)
                                                Case "22" : D1313.SizeQty22 = ListQuantity(l)
                                                Case "23" : D1313.SizeQty23 = ListQuantity(l)
                                                Case "24" : D1313.SizeQty24 = ListQuantity(l)
                                                Case "25" : D1313.SizeQty25 = ListQuantity(l)
                                                Case "26" : D1313.SizeQty26 = ListQuantity(l)
                                                Case "27" : D1313.SizeQty27 = ListQuantity(l)
                                                Case "28" : D1313.SizeQty28 = ListQuantity(l)
                                                Case "29" : D1313.SizeQty29 = ListQuantity(l)
                                                Case "30" : D1313.SizeQty30 = ListQuantity(l)


                                            End Select
                                        Next

                                        W7106.SizeRange = ListSizeRangeString(k).Substring(0, 6)
                                        Call WRITE_PFK7106(W7106)

                                        D1312_CLEAR()
                                        D1312.ShoesCode = D7106.ShoesCode
                                        D1312.JbCard = ListJobCard(4) & ListJobCard(5)
                                        D1312.PONO = txt_CustPoNo.Data
                                        D1312.DateOrder = Pub.DAT
                                        D1312.Datedelivery = ListJobCard(8)

                                        Dim QtyOrder As String
                                        QtyOrder = ListShoesCode(LastPA + 1).Replace(",", ":")
                                        QtyOrder = QtyOrder.Replace(".", ",")
                                        QtyOrder = QtyOrder.Replace(":", ".")

                                        D1312.QtyOrder = CDecp(QtyOrder)


                                        List1312.Add(D1312)
                                        List1313.Add(D1313)

                                        Exit For

                                    End If
                                Next

                            End If

                            'If ListC(rowChk).Contains("Job card") Then
                            '    rowList = rowChk - 1
                            '    Exit For
                            'End If

                            For CC = 1 To 20
                                If ListC(rowList + CC).Contains("Job card") = True Then rowList = rowList + CC - 1 : Exit For
                            Next


                        End If

                    Next

                    ListJobCard.Clear()
                    ListShoesCode.Clear()
                    ListSize.Clear()
                    ListQuantity.Clear()
                    ChkQuantiy = False
                    ChkSize = False
                End If


            Next

            vS10.ActiveSheet.RowCount = List1312.Count
            vS20.ActiveSheet.RowCount = List1312.Count

            str_AutoLink = ""

            For rowList = 0 To List1312.Count - 1
                str_AutoLink = str_AutoLink & "''" & List1312(rowList).ShoesCode + "'',"
            Next

            If str_AutoLink = "" Then Exit Function

            str_AutoLink = Strings.Left(str_AutoLink, Len(str_AutoLink) - 1)

            For rowList = 0 To vS10.ActiveSheet.RowCount - 1
                setData(vS10, getColumIndex(vS10, "ShoesCode"), rowList, List1312(rowList).ShoesCode)

                If READ_PFK7106(List1312(rowList).ShoesCode) Then
                    setData(vS10, getColumIndex(vS10, "cdSpecState"), rowList, D7106.cdSpecState)
                    setData(vS10, getColumIndex(vS10, "ShoesCode"), rowList, D7106.ShoesCode)
                    setData(vS10, getColumIndex(vS10, "Style"), rowList, D7106.Style)
                    setData(vS10, getColumIndex(vS10, "CustSpecNo"), rowList, D7106.CustSpecNo)
                    setData(vS10, getColumIndex(vS10, "ProductCode"), rowList, D7106.ProductCode)

                    setData(vS10, getColumIndex(vS10, "Line"), rowList, D7106.Line)
                    setData(vS10, getColumIndex(vS10, "Article"), rowList, D7106.Article)
                    setData(vS10, getColumIndex(vS10, "MCODE"), rowList, D7106.MCODE)
                    setData(vS10, getColumIndex(vS10, "MCODEName"), rowList, D7106.MCODEName)

                    setData(vS10, getColumIndex(vS10, "ColorCode"), rowList, D7106.ColorCode)
                    setData(vS10, getColumIndex(vS10, "ColorName"), rowList, D7106.ColorName)
                    setData(vS10, getColumIndex(vS10, "SizeRange"), rowList, D7106.SizeRange)

                    Call READ_PFK7104(D7106.SizeRange)

                    setData(vS10, getColumIndex(vS10, "SizeRangeName"), rowList, D7104.SizeRangeName)
                End If

                setData(vS10, getColumIndex(vS10, "QtyOrder"), rowList, List1312(rowList).QtyOrder)
                setData(vS10, getColumIndex(vS10, "JbCard"), rowList, List1312(rowList).JbCard)
                setData(vS10, getColumIndex(vS10, "PONO"), rowList, List1312(rowList).PONO)

                Dim Sdate As Date
                Dim Datedeliverytmp As String
                Datedeliverytmp = List1312(rowList).Datedelivery

                If Len(Datedeliverytmp) >= 10 Then

                    Datedeliverytmp = Strings.Mid(Datedeliverytmp, 7, 4) & "/" & Strings.Mid(Datedeliverytmp, 4, 2) & "/" & Strings.Mid(Datedeliverytmp, 1, 2)
                    If IsDate(Datedeliverytmp) = True Then
                        Sdate = CDate(Datedeliverytmp)
                        setData(vS10, getColumIndex(vS10, "Datedelivery"), rowList, Sdate.Year.ToString("0000") & Sdate.Month.ToString("00") & Sdate.Day.ToString("00"))
                    End If

                End If

            Next


            For rowList = 0 To vS20.ActiveSheet.RowCount - 1
                setData(vS20, getColumIndex(vS20, "SizeQty01"), rowList, List1313(rowList).SizeQty01)
                setData(vS20, getColumIndex(vS20, "SizeQty02"), rowList, List1313(rowList).SizeQty02)
                setData(vS20, getColumIndex(vS20, "SizeQty03"), rowList, List1313(rowList).SizeQty03)
                setData(vS20, getColumIndex(vS20, "SizeQty04"), rowList, List1313(rowList).SizeQty04)
                setData(vS20, getColumIndex(vS20, "SizeQty05"), rowList, List1313(rowList).SizeQty05)
                setData(vS20, getColumIndex(vS20, "SizeQty06"), rowList, List1313(rowList).SizeQty06)
                setData(vS20, getColumIndex(vS20, "SizeQty07"), rowList, List1313(rowList).SizeQty07)
                setData(vS20, getColumIndex(vS20, "SizeQty08"), rowList, List1313(rowList).SizeQty08)
                setData(vS20, getColumIndex(vS20, "SizeQty09"), rowList, List1313(rowList).SizeQty09)
                setData(vS20, getColumIndex(vS20, "SizeQty10"), rowList, List1313(rowList).SizeQty10)
                setData(vS20, getColumIndex(vS20, "SizeQty11"), rowList, List1313(rowList).SizeQty11)
                setData(vS20, getColumIndex(vS20, "SizeQty12"), rowList, List1313(rowList).SizeQty12)
                setData(vS20, getColumIndex(vS20, "SizeQty13"), rowList, List1313(rowList).SizeQty13)
                setData(vS20, getColumIndex(vS20, "SizeQty14"), rowList, List1313(rowList).SizeQty14)
                setData(vS20, getColumIndex(vS20, "SizeQty15"), rowList, List1313(rowList).SizeQty15)
                setData(vS20, getColumIndex(vS20, "SizeQty16"), rowList, List1313(rowList).SizeQty16)
                setData(vS20, getColumIndex(vS20, "SizeQty17"), rowList, List1313(rowList).SizeQty17)
                setData(vS20, getColumIndex(vS20, "SizeQty18"), rowList, List1313(rowList).SizeQty18)
                setData(vS20, getColumIndex(vS20, "SizeQty19"), rowList, List1313(rowList).SizeQty19)
                setData(vS20, getColumIndex(vS20, "SizeQty20"), rowList, List1313(rowList).SizeQty20)
                setData(vS20, getColumIndex(vS20, "SizeQty21"), rowList, List1313(rowList).SizeQty21)
                setData(vS20, getColumIndex(vS20, "SizeQty22"), rowList, List1313(rowList).SizeQty22)
                setData(vS20, getColumIndex(vS20, "SizeQty23"), rowList, List1313(rowList).SizeQty23)
                setData(vS20, getColumIndex(vS20, "SizeQty24"), rowList, List1313(rowList).SizeQty24)
                setData(vS20, getColumIndex(vS20, "SizeQty25"), rowList, List1313(rowList).SizeQty25)
                setData(vS20, getColumIndex(vS20, "SizeQty26"), rowList, List1313(rowList).SizeQty26)
                setData(vS20, getColumIndex(vS20, "SizeQty27"), rowList, List1313(rowList).SizeQty27)
                setData(vS20, getColumIndex(vS20, "SizeQty28"), rowList, List1313(rowList).SizeQty28)
                setData(vS20, getColumIndex(vS20, "SizeQty29"), rowList, List1313(rowList).SizeQty29)
                setData(vS20, getColumIndex(vS20, "SizeQty30"), rowList, List1313(rowList).SizeQty30)
            Next


        Catch ex As Exception

        End Try


    End Function
    Private Function KW_LOADING(ByVal ListC As List(Of String)) As Boolean
        KW_LOADING = False
        Try
            Dim i As Integer
            Dim j As Integer
            Dim k As Integer
            Dim l As Integer

            Dim CC As Integer ' continue searcj

            Dim ListJobCard As New List(Of String)
            Dim ListShoesCode As New List(Of String)
            Dim ListSize As New List(Of String)


            Dim ListQuantity As New List(Of String)

            Dim ListAddDesi As New List(Of String)

            Dim ListSizeRange As New List(Of T7104_AREA)

            Dim ListSizeArray As New List(Of List(Of String))

            Dim ListSizeRangeString As New List(Of String)
            Dim SizeRangeL As String
            Dim ListSizeL As String = ""

            Dim ListSize1704 As New List(Of T7104_AREA)
            Dim ChkQuantiy As Boolean = False
            Dim ChkSize As Boolean = False

            Dim CNTlINE As Integer

            DS1 = PrcDS("USP_ISUD_K7104_MULTI_CHECK", cn, txt_CustomerCode.Code)

            'For Each RD01 As DataRow In DS1.Tables(0).Rows
            'D7104_CLEAR()
            'Call K7104_MOVE(RD01)
            'ListSizeRange.Add(D7104)

            'SizeRangeL = ""
            'For i = 0 To 34
            '    SizeRangeL = SizeRangeL & RD01.Item(i).ToString & ","
            'Next

            'ListSizeRangeString.Add(SizeRangeL)

            For Each RD01 As DataRow In DS1.Tables(0).Rows
                D7104_CLEAR()
                Call K7104_MOVE(RD01)
                ListSizeRange.Add(D7104)

                SizeRangeL = ""
                For rowList = 0 To DS1.Tables(0).Columns.Count - 1
                    SizeRangeL = SizeRangeL & RD01.Item(rowList).ToString & ","
                Next

                ListSizeRangeString.Add(SizeRangeL)
            Next

            'Next


            For i = 0 To ListC.Count - 1
                If ListC(i).Contains("Customer #") Then
                    L1311.Buyer = Strings.Right(ListC(i), ListC(i).Length - ListC(i).IndexOf("Customer #") - 10)

                End If

                If ListC(i).Contains("Currency: ") Then
                    L1311.cdUnitPrice = Strings.Right(ListC(i), ListC(i).Length - ListC(i).IndexOf("Currency: ") - 10)

                    If READ_PFK7171_NAME(ListCode("UnitPrice"), FormatCut(L1311.cdUnitPrice)) Then
                        L1311.cdUnitPrice = D7171.BasicCode
                    Else
                        L1311.cdUnitPrice = ""
                    End If

                End If

                If ListC(i).Contains("Customer Name #") Then
                    L1311.Destination = Strings.Right(ListC(i), ListC(i).Length - ListC(i).IndexOf("Customer Name #") - 15)

                End If

                If ListC(i).Contains("PO #") Then
                    L1311.CustPoNo = Strings.Right(ListC(i), ListC(i).Length - ListC(i).IndexOf("PO #") - 4)
                    txt_CustPoNo.Data = D1311.CustPoNo
                End If

                If ListC(i).Contains("Size-UPC") Then
                    For j = i To i + 5

                        If ListC(j).Contains("Total Value") = False Then

                            ListSize.AddRange(ListC(j).ToString.Split(" "))

                        ElseIf ListC(j).Contains("Total Value") = False Then
                            Exit For
                        End If
                    Next

                End If
            Next

            For i = 0 To ListC.Count - 1
                If ListC(i).Contains("Please separate") Then
                    For j = i + 1 To ListC.Count - 1
                        If ListC(j).Contains("Total Value") = True Then Exit For
                        ListAddDesi.Add(ListC(j))
                        CNTlINE += 1
                    Next

                End If
            Next

            If CNTlINE > 1 Then
                ListAddDesi.RemoveAt(ListAddDesi.Count - 1)
                CNTlINE -= 1
            End If

            For i = 0 To ListC.Count - 1
                If ListC(i).Contains("Description") Then
                    ListJobCard.Add(ListC(i + 1))
                    Exit For
                End If
            Next

            For i = 0 To ListC.Count - 1
                If ListC(i).Contains("Purchase Order:") Then
                    ListJobCard.Add(ListC(i))
                    Exit For
                End If
            Next

            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            For k = 0 To ListSize.Count - 1
                If ListSize(k).ToString.Replace(" ", "").Replace(Chr(13), "").Replace(Chr(10), "") <> "" Then
                    Dim strSzize As String
                    Dim sS As Integer

                    strSzize = ListSize(k).ToString.Replace(" ", "").Replace(Chr(13), "").Replace(Chr(10), "")

                    sS = strSzize.IndexOf("-")



                    If strSzize.Contains("-") And strSzize.Contains("(") And strSzize.Contains(")") And strSzize.Contains(":") = False Then
                        strSzize = Strings.Left(strSzize, sS)
                        strSzize = strSzize.Replace("H", ".5").Replace(" ", "")
                        strSzize = Trim(strSzize)


                        If ListSizeL.Split(",").Contains(strSzize) = False Then
                            ListSizeL = ListSizeL & strSzize & ","
                        End If

                        Dim StrQty As String
                        Dim sP As Integer
                        Dim eP As Integer

                        StrQty = ListSize(k).ToString.Replace(" ", "").Replace(Chr(13), "").Replace(Chr(10), "")
                        sP = StrQty.IndexOf("(")
                        eP = StrQty.IndexOf(")")

                        If eP > sP Then
                            StrQty = StrQty
                            StrQty = Strings.Mid(StrQty, sP + 2, eP - sP - 1)

                            ListQuantity.Add(StrQty)

                        End If


                    End If



                End If

            Next


            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Dim xxx As String

            xxx = "111"

            Dim ListShoesDraft As New List(Of String)

            ListShoesDraft.AddRange(ListJobCard(0).Split(" "))
            ListShoesCode.Clear()

            Dim tmpLine As String
            Dim tmpPrice As String

            Dim tmpArticle As String
            Dim tmpSizeRange As String
            Dim tmpMCode As String
            Dim tmpCCode As String

            Dim tmpColorName As String

            Dim tmpQty As String
            Dim tmpDeliveryDate As String



            tmpArticle = ListShoesDraft(1).Split("-")(0)
            tmpMCode = ListShoesDraft(1).Split("-")(0)
            tmpCCode = ListShoesDraft(1).Split("-")(1)
            tmpSizeRange = ListShoesDraft(1).Split("-")(2)

            tmpLine = ""

            tmpLine = tmpLine + " " + ListShoesDraft(2)

            For i = 2 To ListShoesDraft.Count - 1
                If ListShoesDraft(i).Contains("~") Then
                    'ListShoesDraft.RemoveAt(i)
                    'ListShoesDraft.Add(ListShoesDraft(i).Split("~")(0))
                    'ListShoesDraft.Add(ListShoesDraft(i).Split("~")(0))
                    For j = 0 To ListShoesDraft(i).Split("~").Length - 1
                        ListShoesDraft.Insert(i + j, ListShoesDraft(i + j).Split("~")(j))

                    Next

                    ListShoesDraft.RemoveAt(i + j)

                End If
            Next

            For i = 2 To ListShoesDraft.Count - 1
                If ListShoesDraft(i).Contains("Pair") Then
                    'ListShoesDraft.RemoveAt(i)
                    'ListShoesDraft.Add(ListShoesDraft(i).Split("~")(0))
                    'ListShoesDraft.Add(ListShoesDraft(i).Split("~")(0))

                    If ListShoesDraft(i).Length > 4 Then
                        ListShoesDraft.Insert(i, ListShoesDraft(i).Split("Pair")(0))
                        ListShoesDraft.Insert(i + 1, "Pair")

                        ListShoesDraft.RemoveAt(i + 2)
                    End If

                End If
            Next

            i = ListShoesDraft.Count - 1

            While i > 2
                If ListShoesDraft(i) = "M" Then
                    ListShoesDraft.RemoveAt(i)
                    Exit While
                End If

                i = i - 1
            End While


            For i = 2 To ListShoesDraft.Count - 1

                If ListShoesDraft(i + 3).Contains("Pair") Then
                    j = i + 3

                    Dim strListDraft As String = ""
                    Dim Cnt As Integer

                    For Cnt = 2 To j - 3
                        strListDraft = strListDraft & " " & ListShoesDraft(Cnt)
                    Next


                    tmpQty = Replace(ListShoesDraft(j - 1), "M", 0)
                    tmpPrice = ListShoesDraft(j + 1)

                    tmpLine = strListDraft


                    tmpColorName = ListShoesDraft(j - 2)

                    tmpDeliveryDate = ListShoesDraft(j + 3) & ListShoesDraft(j + 4) & ListShoesDraft(j + 5)

                    If IsDate(tmpDeliveryDate) Then
                        Dim TmpDate As New Date
                        TmpDate = CDate(tmpDeliveryDate)
                        tmpDeliveryDate = TmpDate.Year & TmpDate.Month.ToString("00") & TmpDate.Day.ToString("00")
                    End If

                    Exit For
                End If

            Next

            tmpLine = Trim(tmpLine)

            Dim tmpPO As String
            tmpPO = ListJobCard(1).Split(":")(1)
            tmpPO = Trim(tmpPO)

            ListSize.Clear()
            ListSize.AddRange(ListSizeL.Split(","))

            If READ_PFK7106_1_ALL_CUSTOMER_COLORNAME(txt_cdSeason.Code, txt_CustomerCode.Code, "006", tmpLine, tmpArticle, tmpColorName) Then

                For k = 0 To ListSizeRangeString.Count - 1
                    If CheckListContaint(ListSizeRangeString(k), ListSizeL) Then
                        D1313_CLEAR()

                        For l = 0 To ListSize.Count - 1

                            ListSize(l) = ListSize(l).Replace("H", ".5").Replace(" ", "")

                            If FormatCut(ListSize(l)) <> "" Then
                                Select Case READ_PFK7104_SZNO(ListSizeRangeString(k).Substring(0, 6), ListSize(l))

                                    Case "01" : D1313.SizeQty01 = ListQuantity(l)
                                    Case "02" : D1313.SizeQty02 = ListQuantity(l)
                                    Case "03" : D1313.SizeQty03 = ListQuantity(l)
                                    Case "04" : D1313.SizeQty04 = ListQuantity(l)
                                    Case "05" : D1313.SizeQty05 = ListQuantity(l)
                                    Case "06" : D1313.SizeQty06 = ListQuantity(l)
                                    Case "07" : D1313.SizeQty07 = ListQuantity(l)
                                    Case "08" : D1313.SizeQty08 = ListQuantity(l)
                                    Case "09" : D1313.SizeQty09 = ListQuantity(l)
                                    Case "10" : D1313.SizeQty10 = ListQuantity(l)
                                    Case "11" : D1313.SizeQty11 = ListQuantity(l)
                                    Case "12" : D1313.SizeQty12 = ListQuantity(l)
                                    Case "13" : D1313.SizeQty13 = ListQuantity(l)
                                    Case "14" : D1313.SizeQty14 = ListQuantity(l)
                                    Case "15" : D1313.SizeQty15 = ListQuantity(l)
                                    Case "16" : D1313.SizeQty16 = ListQuantity(l)
                                    Case "17" : D1313.SizeQty17 = ListQuantity(l)
                                    Case "18" : D1313.SizeQty18 = ListQuantity(l)
                                    Case "19" : D1313.SizeQty19 = ListQuantity(l)
                                    Case "20" : D1313.SizeQty20 = ListQuantity(l)
                                    Case "21" : D1313.SizeQty21 = ListQuantity(l)
                                    Case "22" : D1313.SizeQty22 = ListQuantity(l)
                                    Case "23" : D1313.SizeQty23 = ListQuantity(l)
                                    Case "24" : D1313.SizeQty24 = ListQuantity(l)
                                    Case "25" : D1313.SizeQty25 = ListQuantity(l)
                                    Case "26" : D1313.SizeQty26 = ListQuantity(l)
                                    Case "27" : D1313.SizeQty27 = ListQuantity(l)
                                    Case "28" : D1313.SizeQty28 = ListQuantity(l)
                                    Case "29" : D1313.SizeQty29 = ListQuantity(l)
                                    Case "30" : D1313.SizeQty30 = ListQuantity(l)


                                End Select
                            End If

                        Next

                        D1312_CLEAR()
                        D1312.ShoesCode = D7106.ShoesCode
                        D1312.SizeRange = D7106.SizeRange

                        D1312.JbCard = tmpPO
                        D1312.PONO = tmpPO
                        D1312.DateOrder = Pub.DAT
                        D1312.Datedelivery = tmpDeliveryDate

                        D1312.PriceOrder = tmpPrice

                        D1312.cdUnitPrice = L1311.cdUnitPrice

                        D1312.QtyOrder = CDecp(tmpQty)

                        List1312KW.Add(D1312)
                        List1313KW.Add(D1313)

                        Exit For

                    End If
                Next



            ElseIf READ_PFK7106_ALL(tmpArticle, tmpMCode, tmpCCode, tmpColorName) Then
                W7106 = D7106
                W7106.ShoesCodeBase = D7106.ShoesCode

                W7106.cdSpecState = "006"
                W7106.cdSeason = txt_cdSeason.Code

                W7106.Customercode = txt_CustomerCode.Code
                W7106.DateInsert = Pub.DAT
                W7106.InchargeInsert = Pub.SAW
                W7106.Remark = "AUTO INSERT PFK7106 PFK1311- NOT PROD"
                W7106.CheckUse = "2"
                Call KEY_COUNT_K7106()

                W7106.seGender = ListCode("Gender")
                W7106.seSeason = ListCode("Season")
                W7106.seSpecState = ListCode("SpecState")

                W7106.Line = tmpLine

                D1312_CLEAR()
                D1312.ShoesCode = W7106.ShoesCode
                D1312.JbCard = tmpPO
                D1312.PONO = tmpPO
                D1312.DateOrder = Pub.DAT
                D1312.Datedelivery = tmpDeliveryDate



                For k = 0 To ListSizeRangeString.Count - 1
                    If CheckListContaint(ListSizeRangeString(k), ListSizeL) Then
                        D1313_CLEAR()

                        For l = 0 To ListSize.Count - 1

                            If FormatCut(ListSize(l)) <> "" Then
                                Select Case READ_PFK7104_SZNO(ListSizeRangeString(k).Substring(0, 6), ListSize(l))

                                    Case "01" : D1313.SizeQty01 = ListQuantity(l)
                                    Case "02" : D1313.SizeQty02 = ListQuantity(l)
                                    Case "03" : D1313.SizeQty03 = ListQuantity(l)
                                    Case "04" : D1313.SizeQty04 = ListQuantity(l)
                                    Case "05" : D1313.SizeQty05 = ListQuantity(l)
                                    Case "06" : D1313.SizeQty06 = ListQuantity(l)
                                    Case "07" : D1313.SizeQty07 = ListQuantity(l)
                                    Case "08" : D1313.SizeQty08 = ListQuantity(l)
                                    Case "09" : D1313.SizeQty09 = ListQuantity(l)
                                    Case "10" : D1313.SizeQty10 = ListQuantity(l)
                                    Case "11" : D1313.SizeQty11 = ListQuantity(l)
                                    Case "12" : D1313.SizeQty12 = ListQuantity(l)
                                    Case "13" : D1313.SizeQty13 = ListQuantity(l)
                                    Case "14" : D1313.SizeQty14 = ListQuantity(l)
                                    Case "15" : D1313.SizeQty15 = ListQuantity(l)
                                    Case "16" : D1313.SizeQty16 = ListQuantity(l)
                                    Case "17" : D1313.SizeQty17 = ListQuantity(l)
                                    Case "18" : D1313.SizeQty18 = ListQuantity(l)
                                    Case "19" : D1313.SizeQty19 = ListQuantity(l)
                                    Case "20" : D1313.SizeQty20 = ListQuantity(l)
                                    Case "21" : D1313.SizeQty21 = ListQuantity(l)
                                    Case "22" : D1313.SizeQty22 = ListQuantity(l)
                                    Case "23" : D1313.SizeQty23 = ListQuantity(l)
                                    Case "24" : D1313.SizeQty24 = ListQuantity(l)
                                    Case "25" : D1313.SizeQty25 = ListQuantity(l)
                                    Case "26" : D1313.SizeQty26 = ListQuantity(l)
                                    Case "27" : D1313.SizeQty27 = ListQuantity(l)
                                    Case "28" : D1313.SizeQty28 = ListQuantity(l)
                                    Case "29" : D1313.SizeQty29 = ListQuantity(l)
                                    Case "30" : D1313.SizeQty30 = ListQuantity(l)


                                End Select
                            End If

                        Next

                        W7106.SizeRange = ListSizeRangeString(k).Substring(0, 6)
                        Call WRITE_PFK7106(W7106)

                        D1312_CLEAR()
                        D1312.ShoesCode = D7106.ShoesCode
                        D1312.JbCard = tmpPO
                        D1312.PONO = tmpPO
                        D1312.DateOrder = Pub.DAT
                        D1312.Datedelivery = tmpDeliveryDate
                        D1312.SizeRange = W7106.SizeRange
                        D1312.PriceOrder = tmpPrice

                        D1312.cdUnitPrice = L1311.cdUnitPrice

                        List1312KW.Add(D1312)
                        List1313KW.Add(D1313)

                        Exit For

                    End If
                Next

            Else
                W7106 = D7106
                W7106.ShoesCodeBase = D7106.ShoesCode

                W7106.cdSpecState = "006"
                W7106.cdSeason = txt_cdSeason.Code

                W7106.ColorCode = tmpCCode
                W7106.ColorName = tmpColorName

                W7106.Article = tmpArticle
                W7106.seGender = ListCode("Gender")
                W7106.seSeason = ListCode("Season")
                W7106.seSpecState = ListCode("SpecState")


                W7106.Line = tmpLine

                W7106.MCODE = tmpMCode
                W7106.MCODEName = tmpMCode

                W7106.Customercode = txt_CustomerCode.Code
                W7106.DateInsert = Pub.DAT
                W7106.InchargeInsert = Pub.SAW

                W7106.Remark = "AUTO INSERT PFK7106 FROM PFK1311 - NO SHOES"
                W7106.CheckUse = "2"
                Call KEY_COUNT_K7106()



                For k = 0 To ListSizeRangeString.Count - 1
                    If CheckListContaint(ListSizeRangeString(k), ListSizeL) Then
                        D1313_CLEAR()

                        For l = 0 To ListSize.Count - 1

                            If FormatCut(ListSize(l)) <> "" Then
                                Select Case READ_PFK7104_SZNO(ListSizeRangeString(k).Substring(0, 6), ListSize(l))

                                    Case "01" : D1313.SizeQty01 = ListQuantity(l)
                                    Case "02" : D1313.SizeQty02 = ListQuantity(l)
                                    Case "03" : D1313.SizeQty03 = ListQuantity(l)
                                    Case "04" : D1313.SizeQty04 = ListQuantity(l)
                                    Case "05" : D1313.SizeQty05 = ListQuantity(l)
                                    Case "06" : D1313.SizeQty06 = ListQuantity(l)
                                    Case "07" : D1313.SizeQty07 = ListQuantity(l)
                                    Case "08" : D1313.SizeQty08 = ListQuantity(l)
                                    Case "09" : D1313.SizeQty09 = ListQuantity(l)
                                    Case "10" : D1313.SizeQty10 = ListQuantity(l)
                                    Case "11" : D1313.SizeQty11 = ListQuantity(l)
                                    Case "12" : D1313.SizeQty12 = ListQuantity(l)
                                    Case "13" : D1313.SizeQty13 = ListQuantity(l)
                                    Case "14" : D1313.SizeQty14 = ListQuantity(l)
                                    Case "15" : D1313.SizeQty15 = ListQuantity(l)
                                    Case "16" : D1313.SizeQty16 = ListQuantity(l)
                                    Case "17" : D1313.SizeQty17 = ListQuantity(l)
                                    Case "18" : D1313.SizeQty18 = ListQuantity(l)
                                    Case "19" : D1313.SizeQty19 = ListQuantity(l)
                                    Case "20" : D1313.SizeQty20 = ListQuantity(l)
                                    Case "21" : D1313.SizeQty21 = ListQuantity(l)
                                    Case "22" : D1313.SizeQty22 = ListQuantity(l)
                                    Case "23" : D1313.SizeQty23 = ListQuantity(l)
                                    Case "24" : D1313.SizeQty24 = ListQuantity(l)
                                    Case "25" : D1313.SizeQty25 = ListQuantity(l)
                                    Case "26" : D1313.SizeQty26 = ListQuantity(l)
                                    Case "27" : D1313.SizeQty27 = ListQuantity(l)
                                    Case "28" : D1313.SizeQty28 = ListQuantity(l)
                                    Case "29" : D1313.SizeQty29 = ListQuantity(l)
                                    Case "30" : D1313.SizeQty30 = ListQuantity(l)


                                End Select

                            End If
                        Next

                        W7106.SizeRange = ListSizeRangeString(k).Substring(0, 6)

                        Call WRITE_PFK7106(W7106)

                        D1312_CLEAR()
                        D1312.ShoesCode = W7106.ShoesCode
                        D1312.JbCard = tmpPO
                        D1312.PONO = tmpPO
                        D1312.DateOrder = Pub.DAT
                        D1312.Datedelivery = tmpDeliveryDate
                        D1312.SizeRange = W7106.SizeRange
                        D1312.PriceOrder = tmpPrice

                        D1312.cdUnitPrice = L1311.cdUnitPrice

                        List1312KW.Add(D1312)
                        List1313KW.Add(D1313)

                        Exit For

                    End If
                Next

            End If


            Dim W1312xxx As New List(Of T1312_AREA)
            Dim W1313xxx As New List(Of T1313_AREA)

            For i = 0 To CNTlINE - 1
                D1312 = List1312KW(List1312KW.Count - 1)
                D1312.Destination = ListAddDesi(i).Split(",")(0).ToString
                W1312xxx.Add(D1312)

            Next

            If CNTlINE > 0 Then
                List1312KW.RemoveAt(List1312KW.Count - 1)
                List1312KW.AddRange(W1312xxx)
            End If


            For i = 0 To CNTlINE - 1
                D1313 = List1313KW(List1313KW.Count - 1)

                ListSize.Clear()
                ListSize.AddRange(ListAddDesi(i).Split(","))

                l = ListSize.Count - 1

                While l >= 0
                    If ListSize(l).Contains("/") = False Then
                        ListSize.RemoveAt(l)
                    Else
                        l = l - 1
                    End If

                End While

                l = ListSize.Count - 1

                While l >= 0
                    If ListSize(l).Contains("=") = True Then
                        ListSize(l) = Strings.Left(ListSize(l), ListSize(l).IndexOf("="))

                    End If

                    l = l - 1
                End While

                D1313_CLEAR()

                For l = 0 To ListSize.Count - 1

                    If FormatCut(ListSize(l)) <> "" Then

                        ListSize(l) = ListSize(l).Replace("H", ".5").Replace(" ", "")

                        Select Case READ_PFK7104_SZNO(D1312.SizeRange, ListSize(l).Split("/")(0))

                            Case "01" : D1313.SizeQty01 = ListSize(l).Split("/")(1)
                            Case "02" : D1313.SizeQty02 = ListSize(l).Split("/")(1)
                            Case "03" : D1313.SizeQty03 = ListSize(l).Split("/")(1)
                            Case "04" : D1313.SizeQty04 = ListSize(l).Split("/")(1)
                            Case "05" : D1313.SizeQty05 = ListSize(l).Split("/")(1)
                            Case "06" : D1313.SizeQty06 = ListSize(l).Split("/")(1)
                            Case "07" : D1313.SizeQty07 = ListSize(l).Split("/")(1)
                            Case "08" : D1313.SizeQty08 = ListSize(l).Split("/")(1)
                            Case "09" : D1313.SizeQty09 = ListSize(l).Split("/")(1)
                            Case "10" : D1313.SizeQty10 = ListSize(l).Split("/")(1)
                            Case "11" : D1313.SizeQty11 = ListSize(l).Split("/")(1)
                            Case "12" : D1313.SizeQty12 = ListSize(l).Split("/")(1)
                            Case "13" : D1313.SizeQty13 = ListSize(l).Split("/")(1)
                            Case "14" : D1313.SizeQty14 = ListSize(l).Split("/")(1)
                            Case "15" : D1313.SizeQty15 = ListSize(l).Split("/")(1)
                            Case "16" : D1313.SizeQty16 = ListSize(l).Split("/")(1)
                            Case "17" : D1313.SizeQty17 = ListSize(l).Split("/")(1)
                            Case "18" : D1313.SizeQty18 = ListSize(l).Split("/")(1)
                            Case "19" : D1313.SizeQty19 = ListSize(l).Split("/")(1)
                            Case "20" : D1313.SizeQty20 = ListSize(l).Split("/")(1)
                            Case "21" : D1313.SizeQty21 = ListSize(l).Split("/")(1)
                            Case "22" : D1313.SizeQty22 = ListSize(l).Split("/")(1)
                            Case "23" : D1313.SizeQty23 = ListSize(l).Split("/")(1)
                            Case "24" : D1313.SizeQty24 = ListSize(l).Split("/")(1)
                            Case "25" : D1313.SizeQty25 = ListSize(l).Split("/")(1)
                            Case "26" : D1313.SizeQty26 = ListSize(l).Split("/")(1)
                            Case "27" : D1313.SizeQty27 = ListSize(l).Split("/")(1)
                            Case "28" : D1313.SizeQty28 = ListSize(l).Split("/")(1)
                            Case "29" : D1313.SizeQty29 = ListSize(l).Split("/")(1)
                            Case "30" : D1313.SizeQty30 = ListSize(l).Split("/")(1)


                        End Select




                    End If
                Next

                W1313xxx.Add(D1313)

            Next

            If CNTlINE > 0 Then
                List1313KW.RemoveAt(List1313KW.Count - 1)
                List1313KW.AddRange(W1313xxx)
            End If



        Catch ex As Exception

        End Try


    End Function
    Private Function WW_LOADING(ByVal ListC As List(Of String)) As Boolean
        WW_LOADING = False
        Try
            Dim i As Integer
            Dim j As Integer
            Dim k As Integer
            Dim l As Integer

            Dim CC As Integer ' continue searcj

            Dim ListJobCard As New List(Of String)
            Dim ListShoesCode As New List(Of String)
            Dim ListSize As New List(Of String)


            Dim ListQuantity As New List(Of String)


            Dim ListSizeRange As New List(Of T7104_AREA)

            Dim ListSizeArray As New List(Of List(Of String))

            Dim ListSizeRangeString As New List(Of String)
            Dim SizeRangeL As String

            Dim ListSizeGroup As String = ""
            Dim ListSizeL As String = ""

            Dim ListSize1704 As New List(Of T7104_AREA)
            Dim ChkQuantiy As Boolean = False
            Dim ChkSize As Boolean = False

            DS1 = PrcDS("USP_ISUD_K7104_MULTI_CHECK", cn, txt_CustomerCode.Code)

            For Each RD01 As DataRow In DS1.Tables(0).Rows
                D7104_CLEAR()
                Call K7104_MOVE(RD01)
                ListSizeRange.Add(D7104)

                SizeRangeL = ""
                For i = 0 To 34
                    SizeRangeL = SizeRangeL & RD01.Item(i).ToString & ","
                Next

                ListSizeRangeString.Add(SizeRangeL)
            Next


            For i = 0 To ListC.Count - 1
                If ListC(i).Contains("Size/Width") Then
                    For j = i To i + 10

                        If ListC(j).Contains("Size/Width") = True Then

                            ListSize.AddRange(ListC(j).ToString.Split(" "))

                        ElseIf ListC(j).Contains("Total Quantity") = True Then
                            Exit For
                        End If
                    Next

                End If
            Next

            For i = 0 To ListC.Count - 1
                If ListC(i).Contains("Size/Width") Then
                    For j = i To i + 10

                        If ListC(j).Contains("Quantity") = True Then

                            ListQuantity.AddRange(ListC(j).ToString.Split(" "))

                        ElseIf ListC(j).Contains("Total Quantity") = True Then
                            Exit For
                        End If
                    Next

                End If
            Next

            For i = 1 To ListC.Count - 1
                If ListC(i).Contains("Item #") Then
                    ListJobCard.Add(ListC(i))

                ElseIf ListC(i - 1).Contains("OA No:") = True Then
                    Exit For
                End If
            Next

            For i = 0 To ListC.Count - 1
                If ListC(i).Contains("Customer PO No:") Then
                    ListJobCard.Add(ListC(i))
                    Exit For
                End If
            Next

            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            For k = 0 To ListSize.Count - 1
                If ListSize(k).ToString.Replace(" ", "").Replace(Chr(13), "").Replace(Chr(10), "") <> "" Then
                    Dim strSzize As String
                    Dim sS As Integer

                    strSzize = ListSize(k).ToString.Replace(" ", "").Replace(Chr(13), "").Replace(Chr(10), "")

                    If strSzize.Contains("/") = False Then
                        strSzize = Trim(strSzize)


                        If IsNumeric(strSzize) = False Then
                            If ListSizeGroup.Split(",").Contains(strSzize) = False Then
                                ListSizeGroup = ListSizeGroup & strSzize & ","
                            End If

                        Else

                            If ListSizeL.Split(",").Contains(strSzize) = False Then
                                ListSizeL = ListSizeL & strSzize & ","
                            End If

                            Dim StrQty As String
                            Dim sP As Integer
                            Dim eP As Integer

                            StrQty = ListSize(k).ToString.Replace(" ", "").Replace(Chr(13), "").Replace(Chr(10), "")
                            sP = StrQty.IndexOf("(")
                            eP = StrQty.IndexOf(")")

                            If eP > sP Then
                                StrQty = StrQty
                                StrQty = Strings.Mid(StrQty, sP + 2, eP - sP - 1)

                                ListQuantity.Add(StrQty)

                            End If

                        End If



                    End If



                End If

            Next


            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Dim xxx As String

            xxx = "111"

            Dim ListShoesDraft As New List(Of String)

            ListShoesDraft.AddRange(ListJobCard(0).Split(" "))
            ListShoesCode.Clear()

            Dim tmpLine As String

            Dim tmpArticle As String
                                        Dim tmpSizeRange As String
                                        Dim tmpMCode As String
                                        Dim tmpCCode As String

                                        Dim tmpColorName As String
                                        Dim tmpPrice As String
                                        Dim tmpQty As String
                                        Dim tmpDeliveryDate As String



                                        tmpArticle = ListShoesDraft(1).Split("-")(0)
                                        tmpMCode = ListShoesDraft(1).Split("-")(0)
                                        tmpCCode = ListShoesDraft(1).Split("-")(1)
                                        tmpSizeRange = ListShoesDraft(1).Split("-")(2)

                                        tmpLine = ""

                                        For i = 2 To ListShoesDraft.Count - 1
                                            tmpLine = tmpLine + " " + ListShoesDraft(i)

                                            If ListShoesDraft(i + 3).Contains("Pair") Then
                                                j = i + 3

                                                tmpQty = ListShoesDraft(j - 1)
                                                tmpPrice = ListShoesDraft(j + 1)

                                                tmpLine = tmpLine + " " + ListShoesDraft(j - 2).Split("~")(0)
                                                tmpColorName = ListShoesDraft(j - 2).Split("~")(1)

                                                tmpDeliveryDate = ListShoesDraft(j + 3) & ListShoesDraft(j + 4) & ListShoesDraft(j + 5)

                                                If IsDate(tmpDeliveryDate) Then
                                                    Dim TmpDate As New Date
                                                    TmpDate = CDate(tmpDeliveryDate)
                                                    tmpDeliveryDate = TmpDate.Year & TmpDate.Month.ToString("00") & TmpDate.Day.ToString("00")
                                                End If

                                                Exit For
                                            End If

                                        Next

                                        tmpLine = Trim(tmpLine)

                                        Dim tmpPO As String
                                        tmpPO = ListJobCard(1).Split(":")(1)
                                        tmpPO = Trim(tmpPO)

                                        ListSize.Clear()
                                        ListSize.AddRange(ListSizeL.Split(","))

                                        If READ_PFK7106_1_ABT(txt_cdSeason.Code, "006", tmpLine, tmpArticle, tmpCCode) Then

                                            For k = 0 To ListSizeRangeString.Count - 1
                                                If CheckListContaint(ListSizeRangeString(k), ListSizeL) Then
                                                    D1313_CLEAR()

                                                    For l = 0 To ListSize.Count - 1

                                                        If FormatCut(ListSize(l)) <> "" Then
                                                            Select Case READ_PFK7104_SZNO(ListSizeRangeString(k).Substring(0, 6), ListSize(l))

                                                                Case "01" : D1313.SizeQty01 = ListQuantity(l)
                                                                Case "02" : D1313.SizeQty02 = ListQuantity(l)
                                                                Case "03" : D1313.SizeQty03 = ListQuantity(l)
                                                                Case "04" : D1313.SizeQty04 = ListQuantity(l)
                                                                Case "05" : D1313.SizeQty05 = ListQuantity(l)
                                                                Case "06" : D1313.SizeQty06 = ListQuantity(l)
                                                                Case "07" : D1313.SizeQty07 = ListQuantity(l)
                                                                Case "08" : D1313.SizeQty08 = ListQuantity(l)
                                                                Case "09" : D1313.SizeQty09 = ListQuantity(l)
                                                                Case "10" : D1313.SizeQty10 = ListQuantity(l)
                                                                Case "11" : D1313.SizeQty11 = ListQuantity(l)
                                                                Case "12" : D1313.SizeQty12 = ListQuantity(l)
                                                                Case "13" : D1313.SizeQty13 = ListQuantity(l)
                                                                Case "14" : D1313.SizeQty14 = ListQuantity(l)
                                                                Case "15" : D1313.SizeQty15 = ListQuantity(l)
                                                                Case "16" : D1313.SizeQty16 = ListQuantity(l)
                                                                Case "17" : D1313.SizeQty17 = ListQuantity(l)
                                                                Case "18" : D1313.SizeQty18 = ListQuantity(l)
                                                                Case "19" : D1313.SizeQty19 = ListQuantity(l)
                                                                Case "20" : D1313.SizeQty20 = ListQuantity(l)
                                                                Case "21" : D1313.SizeQty21 = ListQuantity(l)
                                                                Case "22" : D1313.SizeQty22 = ListQuantity(l)
                                                                Case "23" : D1313.SizeQty23 = ListQuantity(l)
                                                                Case "24" : D1313.SizeQty24 = ListQuantity(l)
                                                                Case "25" : D1313.SizeQty25 = ListQuantity(l)
                                                                Case "26" : D1313.SizeQty26 = ListQuantity(l)
                                                                Case "27" : D1313.SizeQty27 = ListQuantity(l)
                                                                Case "28" : D1313.SizeQty28 = ListQuantity(l)
                                                                Case "29" : D1313.SizeQty29 = ListQuantity(l)
                                                                Case "30" : D1313.SizeQty30 = ListQuantity(l)


                                                            End Select
                                                        End If

                                                    Next

                                                    D1312_CLEAR()
                                                    D1312.ShoesCode = D7106.ShoesCode
                                                    D1312.JbCard = tmpPO
                                                    D1312.PONO = tmpPO
                                                    D1312.DateOrder = Pub.DAT
                                                    D1312.Datedelivery = tmpDeliveryDate

                                                    D1312.QtyOrder = CDecp(tmpQty)

                                                    List1312KW.Add(D1312)
                                                    List1313KW.Add(D1313)

                                                    Exit For

                                                End If
                                            Next



                                        ElseIf READ_PFK7106_ALL_GX(tmpArticle, tmpMCode, tmpCCode) Then
                                            W7106 = D7106
                                            W7106.ShoesCodeBase = D7106.ShoesCode

                                            W7106.cdSpecState = "006"
                                            W7106.cdSeason = txt_cdSeason.Code

                                            W7106.Customercode = txt_CustomerCode.Code
                                            W7106.DateInsert = Pub.DAT
                                            W7106.InchargeInsert = Pub.SAW
                                            W7106.Remark = "AUTO INSERT PFK7106 PFK1311- NOT PROD"
                                            W7106.CheckUse = "2"
                                            Call KEY_COUNT_K7106()

                                            W7106.seGender = ListCode("Gender")
                                            W7106.seSeason = ListCode("Season")
                                            W7106.seSpecState = ListCode("SpecState")

                                            W7106.Line = tmpLine

                                            D1312_CLEAR()
                                            D1312.ShoesCode = W7106.ShoesCode
                                            D1312.JbCard = tmpPO
                                            D1312.PONO = tmpPO
                                            D1312.DateOrder = Pub.DAT
                                            D1312.Datedelivery = tmpDeliveryDate


                                            For k = 0 To ListSizeRangeString.Count - 1
                                                If CheckListContaint(ListSizeRangeString(k), ListSizeL) Then
                                                    D1313_CLEAR()

                                                    For l = 0 To ListSize.Count - 1

                                                        If FormatCut(ListSize(l)) <> "" Then
                                                            Select Case READ_PFK7104_SZNO(ListSizeRangeString(k).Substring(0, 6), ListSize(l))

                                                                Case "01" : D1313.SizeQty01 = ListQuantity(l)
                                                                Case "02" : D1313.SizeQty02 = ListQuantity(l)
                                                                Case "03" : D1313.SizeQty03 = ListQuantity(l)
                                                                Case "04" : D1313.SizeQty04 = ListQuantity(l)
                                                                Case "05" : D1313.SizeQty05 = ListQuantity(l)
                                                                Case "06" : D1313.SizeQty06 = ListQuantity(l)
                                                                Case "07" : D1313.SizeQty07 = ListQuantity(l)
                                                                Case "08" : D1313.SizeQty08 = ListQuantity(l)
                                                                Case "09" : D1313.SizeQty09 = ListQuantity(l)
                                                                Case "10" : D1313.SizeQty10 = ListQuantity(l)
                                                                Case "11" : D1313.SizeQty11 = ListQuantity(l)
                                                                Case "12" : D1313.SizeQty12 = ListQuantity(l)
                                                                Case "13" : D1313.SizeQty13 = ListQuantity(l)
                                                                Case "14" : D1313.SizeQty14 = ListQuantity(l)
                                                                Case "15" : D1313.SizeQty15 = ListQuantity(l)
                                                                Case "16" : D1313.SizeQty16 = ListQuantity(l)
                                                                Case "17" : D1313.SizeQty17 = ListQuantity(l)
                                                                Case "18" : D1313.SizeQty18 = ListQuantity(l)
                                                                Case "19" : D1313.SizeQty19 = ListQuantity(l)
                                                                Case "20" : D1313.SizeQty20 = ListQuantity(l)
                                                                Case "21" : D1313.SizeQty21 = ListQuantity(l)
                                                                Case "22" : D1313.SizeQty22 = ListQuantity(l)
                                                                Case "23" : D1313.SizeQty23 = ListQuantity(l)
                                                                Case "24" : D1313.SizeQty24 = ListQuantity(l)
                                                                Case "25" : D1313.SizeQty25 = ListQuantity(l)
                                                                Case "26" : D1313.SizeQty26 = ListQuantity(l)
                                                                Case "27" : D1313.SizeQty27 = ListQuantity(l)
                                                                Case "28" : D1313.SizeQty28 = ListQuantity(l)
                                                                Case "29" : D1313.SizeQty29 = ListQuantity(l)
                                                                Case "30" : D1313.SizeQty30 = ListQuantity(l)


                                                            End Select
                                                        End If

                                                    Next

                                                    W7106.SizeRange = ListSizeRangeString(k).Substring(0, 6)
                                                    Call WRITE_PFK7106(W7106)

                                                    D1312_CLEAR()
                                                    D1312.ShoesCode = D7106.ShoesCode
                                                    D1312.JbCard = tmpPO
                                                    D1312.PONO = tmpPO
                                                    D1312.DateOrder = Pub.DAT
                                                    D1312.Datedelivery = tmpDeliveryDate

                                                    List1312KW.Add(D1312)
                                                    List1313KW.Add(D1313)

                                                    Exit For

                                                End If
                                            Next


                                        Else
                                            W7106 = D7106
                                            W7106.ShoesCodeBase = D7106.ShoesCode

                                            W7106.cdSpecState = "006"
                                            W7106.cdSeason = txt_cdSeason.Code

                                            W7106.ColorCode = tmpCCode
                                            W7106.ColorName = tmpColorName

                                            W7106.Article = tmpArticle
                                            W7106.seGender = ListCode("Gender")
                                            W7106.seSeason = ListCode("Season")
                                            W7106.seSpecState = ListCode("SpecState")


                                            W7106.Line = tmpLine

                                            W7106.MCODE = tmpMCode
                                            W7106.MCODEName = tmpMCode

                                            W7106.Customercode = txt_CustomerCode.Code
                                            W7106.DateInsert = Pub.DAT
                                            W7106.InchargeInsert = Pub.SAW

                                            W7106.Remark = "AUTO INSERT PFK7106 FROM PFK1311 - NO SHOES"
                                            W7106.CheckUse = "2"
                                            Call KEY_COUNT_K7106()



                                            For k = 0 To ListSizeRangeString.Count - 1
                                                If CheckListContaint(ListSizeRangeString(k), ListSizeL) Then
                                                    D1313_CLEAR()

                                                    For l = 0 To ListSize.Count - 1

                                                        If FormatCut(ListSize(l)) <> "" Then
                                                            Select Case READ_PFK7104_SZNO(ListSizeRangeString(k).Substring(0, 6), ListSize(l))

                                                                Case "01" : D1313.SizeQty01 = ListQuantity(l)
                                                                Case "02" : D1313.SizeQty02 = ListQuantity(l)
                                                                Case "03" : D1313.SizeQty03 = ListQuantity(l)
                                                                Case "04" : D1313.SizeQty04 = ListQuantity(l)
                                                                Case "05" : D1313.SizeQty05 = ListQuantity(l)
                                                                Case "06" : D1313.SizeQty06 = ListQuantity(l)
                                                                Case "07" : D1313.SizeQty07 = ListQuantity(l)
                                                                Case "08" : D1313.SizeQty08 = ListQuantity(l)
                                                                Case "09" : D1313.SizeQty09 = ListQuantity(l)
                                                                Case "10" : D1313.SizeQty10 = ListQuantity(l)
                                                                Case "11" : D1313.SizeQty11 = ListQuantity(l)
                                                                Case "12" : D1313.SizeQty12 = ListQuantity(l)
                                                                Case "13" : D1313.SizeQty13 = ListQuantity(l)
                                                                Case "14" : D1313.SizeQty14 = ListQuantity(l)
                                                                Case "15" : D1313.SizeQty15 = ListQuantity(l)
                                                                Case "16" : D1313.SizeQty16 = ListQuantity(l)
                                                                Case "17" : D1313.SizeQty17 = ListQuantity(l)
                                                                Case "18" : D1313.SizeQty18 = ListQuantity(l)
                                                                Case "19" : D1313.SizeQty19 = ListQuantity(l)
                                                                Case "20" : D1313.SizeQty20 = ListQuantity(l)
                                                                Case "21" : D1313.SizeQty21 = ListQuantity(l)
                                                                Case "22" : D1313.SizeQty22 = ListQuantity(l)
                                                                Case "23" : D1313.SizeQty23 = ListQuantity(l)
                                                                Case "24" : D1313.SizeQty24 = ListQuantity(l)
                                                                Case "25" : D1313.SizeQty25 = ListQuantity(l)
                                                                Case "26" : D1313.SizeQty26 = ListQuantity(l)
                                                                Case "27" : D1313.SizeQty27 = ListQuantity(l)
                                                                Case "28" : D1313.SizeQty28 = ListQuantity(l)
                                                                Case "29" : D1313.SizeQty29 = ListQuantity(l)
                                                                Case "30" : D1313.SizeQty30 = ListQuantity(l)


                                                            End Select

                                                        End If
                                                    Next

                                                    W7106.SizeRange = ListSizeRangeString(k).Substring(0, 6)
                                                    Call WRITE_PFK7106(W7106)

                                                    D1312_CLEAR()
                                                    D1312.ShoesCode = W7106.ShoesCode
                                                    D1312.JbCard = tmpPO
                                                    D1312.PONO = tmpPO
                                                    D1312.DateOrder = Pub.DAT
                                                    D1312.Datedelivery = tmpDeliveryDate

                                                    List1312KW.Add(D1312)
                                                    List1313KW.Add(D1313)

                                                    Exit For

                                                End If
                                            Next

                                        End If


                                        vS10.ActiveSheet.RowCount = List1312KW.Count
                                        str_AutoLink = ""

                                        For i = 0 To List1312KW.Count - 1
                                            str_AutoLink = str_AutoLink & "''" & List1312KW(i).ShoesCode + "'',"
                                        Next

                                        If str_AutoLink = "" Then Exit Function

                                        str_AutoLink = Strings.Left(str_AutoLink, Len(str_AutoLink) - 1)

                                        'Call DATA_SEARCH_vS10_AUTO()
                                        'Call DATA_SEARCH_vS20_AUTO()

                                        'For j = 0 To List1312KW.Count - 1
                                        '    For i = 0 To vS10.ActiveSheet.RowCount - 1
                                        '        If getData(vS10, getColumIndex(vS10, "ShoesCode"), i) = List1312KW(j).ShoesCode Then
                                        '            vS10.ActiveSheet.MoveRow(i, j, True)
                                        '            vS20.ActiveSheet.MoveRow(i, j, True)
                                        '            Exit For
                                        '        End If

                                        '    Next
                                        'Next


                                        'For i = 0 To vS10.ActiveSheet.RowCount - 1
                                        '    setData(vS10, getColumIndex(vS10, "QtyOrder"), i, List1312KW(i).QtyOrder)
                                        '    setData(vS10, getColumIndex(vS10, "JbCard"), i, List1312KW(i).JbCard)
                                        '    setData(vS10, getColumIndex(vS10, "PONO"), i, List1312KW(i).PONO)
                                        'Next

                                        For i = 0 To vS10.ActiveSheet.RowCount - 1
                                            setData(vS10, getColumIndex(vS10, "ShoesCode"), i, List1312KW(i).ShoesCode)

                                            If READ_PFK7106(List1312KW(i).ShoesCode) Then
                                                setData(vS10, getColumIndex(vS10, "cdSpecState"), i, D7106.cdSpecState)


                                                setData(vS10, getColumIndex(vS10, "ShoesCode"), i, D7106.ShoesCode)
                                                setData(vS10, getColumIndex(vS10, "Style"), i, D7106.Style)
                                                setData(vS10, getColumIndex(vS10, "CustSpecNo"), i, D7106.CustSpecNo)
                                                setData(vS10, getColumIndex(vS10, "ProductCode"), i, D7106.ProductCode)

                                                setData(vS10, getColumIndex(vS10, "Line"), i, D7106.Line)
                                                setData(vS10, getColumIndex(vS10, "Article"), i, D7106.Article)
                                                setData(vS10, getColumIndex(vS10, "MCODE"), i, D7106.MCODE)
                                                setData(vS10, getColumIndex(vS10, "MCODEName"), i, D7106.MCODEName)

                                                setData(vS10, getColumIndex(vS10, "ColorCode"), i, D7106.ColorCode)
                                                setData(vS10, getColumIndex(vS10, "ColorName"), i, D7106.ColorName)
                                                setData(vS10, getColumIndex(vS10, "SizeRange"), i, D7106.SizeRange)

                                                Call READ_PFK7104(D7106.SizeRange)

                                                setData(vS10, getColumIndex(vS10, "SizeRangeName"), i, D7104.SizeRangeName)

                                            End If

                                            setData(vS10, getColumIndex(vS10, "QtyOrder"), i, List1312KW(i).QtyOrder)
                                            setData(vS10, getColumIndex(vS10, "JbCard"), i, List1312KW(i).JbCard)
                                            setData(vS10, getColumIndex(vS10, "PONO"), i, List1312KW(i).PONO)

                                        Next

                                        For i = 0 To vS20.ActiveSheet.RowCount - 1
                                            setData(vS20, getColumIndex(vS20, "SizeQty01"), i, List1313KW(i).SizeQty01)
                                            setData(vS20, getColumIndex(vS20, "SizeQty02"), i, List1313KW(i).SizeQty02)
                                            setData(vS20, getColumIndex(vS20, "SizeQty03"), i, List1313KW(i).SizeQty03)
                                            setData(vS20, getColumIndex(vS20, "SizeQty04"), i, List1313KW(i).SizeQty04)
                                            setData(vS20, getColumIndex(vS20, "SizeQty05"), i, List1313KW(i).SizeQty05)
                                            setData(vS20, getColumIndex(vS20, "SizeQty06"), i, List1313KW(i).SizeQty06)
                                            setData(vS20, getColumIndex(vS20, "SizeQty07"), i, List1313KW(i).SizeQty07)
                                            setData(vS20, getColumIndex(vS20, "SizeQty08"), i, List1313KW(i).SizeQty08)
                                            setData(vS20, getColumIndex(vS20, "SizeQty09"), i, List1313KW(i).SizeQty09)
                                            setData(vS20, getColumIndex(vS20, "SizeQty10"), i, List1313KW(i).SizeQty10)
                                            setData(vS20, getColumIndex(vS20, "SizeQty11"), i, List1313KW(i).SizeQty11)
                                            setData(vS20, getColumIndex(vS20, "SizeQty12"), i, List1313KW(i).SizeQty12)
                                            setData(vS20, getColumIndex(vS20, "SizeQty13"), i, List1313KW(i).SizeQty13)
                                            setData(vS20, getColumIndex(vS20, "SizeQty14"), i, List1313KW(i).SizeQty14)
                                            setData(vS20, getColumIndex(vS20, "SizeQty15"), i, List1313KW(i).SizeQty15)
                                            setData(vS20, getColumIndex(vS20, "SizeQty16"), i, List1313KW(i).SizeQty16)
                                            setData(vS20, getColumIndex(vS20, "SizeQty17"), i, List1313KW(i).SizeQty17)
                                            setData(vS20, getColumIndex(vS20, "SizeQty18"), i, List1313KW(i).SizeQty18)
                                            setData(vS20, getColumIndex(vS20, "SizeQty19"), i, List1313KW(i).SizeQty19)
                                            setData(vS20, getColumIndex(vS20, "SizeQty20"), i, List1313KW(i).SizeQty20)
                                            setData(vS20, getColumIndex(vS20, "SizeQty21"), i, List1313KW(i).SizeQty21)
                                            setData(vS20, getColumIndex(vS20, "SizeQty22"), i, List1313KW(i).SizeQty22)
                                            setData(vS20, getColumIndex(vS20, "SizeQty23"), i, List1313KW(i).SizeQty23)
                                            setData(vS20, getColumIndex(vS20, "SizeQty24"), i, List1313KW(i).SizeQty24)
                                            setData(vS20, getColumIndex(vS20, "SizeQty25"), i, List1313KW(i).SizeQty25)
                                            setData(vS20, getColumIndex(vS20, "SizeQty26"), i, List1313KW(i).SizeQty26)
                                            setData(vS20, getColumIndex(vS20, "SizeQty27"), i, List1313KW(i).SizeQty27)
                                            setData(vS20, getColumIndex(vS20, "SizeQty28"), i, List1313KW(i).SizeQty28)
                                            setData(vS20, getColumIndex(vS20, "SizeQty29"), i, List1313KW(i).SizeQty29)
                                            setData(vS20, getColumIndex(vS20, "SizeQty30"), i, List1313KW(i).SizeQty30)
                                        Next

        Catch ex As Exception

        End Try


    End Function

#End Region

#Region "Event"

    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Try
            Select Case wJOB
                Case 1

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
        Catch ex As Exception
            MsgBoxP("cmd_DEL_Click")
        End Try

    End Sub
    Private Sub Vs10_ButtonClicked(sender As Object, e As EditorNotifyEventArgs) Handles vS10.ButtonClicked
        Try
            vS10.ActiveSheet.ActiveRowIndex = e.Row
            vS10.ActiveSheet.ActiveColumnIndex = e.Column
            Select Case e.Column
                'Case getColumIndex(vS10, "CLcdSizeRange")

                '    HLP7104C.Link_HLP7104C(txt_CustomerCode.Code)
                '    If hlp0000SeVaTt = "" Or hlp0000SeVa = "" Then Exit Sub
                '    If READ_PFK7104(hlp0000SeVaTt) Then
                '        W7104 = D7104
                '        setData(vS10, getColumIndex(vS10, "CLcdSizeRange") + 1, vS10.ActiveSheet.ActiveRowIndex, W7104.SizeRange)
                '        setData(vS10, getColumIndex(vS10, "CLcdSizeRange") + 2, vS10.ActiveSheet.ActiveRowIndex, W7104.SizeRangeName)
                '    End If

                Case getColumIndex(vS10, "CLShoesCode")

                    If txt_cdOrderGroup.Code = "001" Then HLP7106A.Link_HLP7106A(txt_CustomerCode.Code, txt_cdSeason.Code, False)
                    If txt_cdOrderGroup.Code = "002" Then HLP7106A.Link_HLP7106A(txt_CustomerCode.Code, txt_cdSeason.Code, True)


                    If hlp0000SeVaTt = "" Or hlp0000SeVa = "" Then Exit Sub

                    str_AutoLink = hlp0000SeVaTt
                    Call DATA_SEARCH_vS10_AUTO()
                    Call DATA_SEARCH_vS20_AUTO()

                    'If READ_PFK7106(hlp0000SeVaTt) Then
                    '    setData(vS10, getColumIndex(vS10, "Style"), e.Row, D7106.Style)
                    '    setData(vS10, getColumIndex(vS10, "ShoesCode"), e.Row, D7106.ShoesCode)

                    '    setData(vS10, getColumIndex(vS10, "CustSpecNo"), e.Row, D7106.CustSpecNo)
                    '    setData(vS10, getColumIndex(vS10, "ProductCode"), e.Row, D7106.ProductCode)

                    '    setData(vS10, getColumIndex(vS10, "SizeRange"), e.Row, D7106.SizeRange)

                    '    If READ_PFK7104(D7106.SizeRange) Then
                    '        setData(vS10, getColumIndex(vS10, "SizeRangeName"), e.Row, D7104.SizeRangeName)
                    '    End If

                    '    setData(vS10, getColumIndex(vS10, "Article"), e.Row, D7106.Article)
                    '    setData(vS10, getColumIndex(vS10, "Line"), e.Row, D7106.Line)
                    '    setData(vS10, getColumIndex(vS10, "ColorName"), e.Row, D7106.ColorName)
                    '    setData(vS10, getColumIndex(vS10, "ColorCode"), e.Row, D7106.ColorCode)

                    '    setData(vS10, getColumIndex(vS10, "MCODE"), e.Row, D7106.MCODE)
                    '    setData(vS10, getColumIndex(vS10, "MCODEName"), e.Row, D7106.MCODEName)

                    '    setData(vS10, getColumIndex(vS10, "MoldCode"), e.Row, D7106.MoldCode)

                    '    If READ_PFK7231(D7106.MoldCode) Then
                    '        setData(vS10, getColumIndex(vS10, "MoldName"), e.Row, D7231.MaterialName)
                    '    End If

                    '    setData(vS10, getColumIndex(vS10, "LastCode"), e.Row, D7106.LastCode)

                    '    If READ_PFK7231(D7106.LastCode) Then
                    '        setData(vS10, getColumIndex(vS10, "LastName"), e.Row, D7231.MaterialName)
                    '    End If

                    '    setData(vS10, getColumIndex(vS10, "cdSpecState"), e.Row, D7106.cdSpecState)

                    '    If READ_PFK7171(ListCode("SpecState"), D7106.cdSpecState) Then
                    '        setData(vS10, getColumIndex(vS10, "cdSpecStateName"), e.Row, D7171.BasicName)
                    '    End If

                    'End If

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
                                    Call DATA_SEARCH_vS20()

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
    Private Sub cmd_Upload_Click(sender As Object, e As EventArgs) Handles cmd_Upload.Click
        Dim ListDs As New List(Of String)

        If txt_CustomerCode.Code = "" Then MsgBoxP("Customer Code!") : Exit Sub
        If txt_cdSeason.Code = "" Then MsgBoxP("Season Code!") : Exit Sub
        If txt_cdStateOfficial.Code = "" Then MsgBoxP("Official State") : Exit Sub

        Try
            txt_CustomerCode.Enabled = False
            txt_cdSeason.Enabled = False
            txt_cdStateOfficial.Enabled = False

            If txt_CustomerCode.Code = "000002" Then
                Using OpenFileDialog As OpenFileDialog = Me.GetOpenFileDialog()
                    OpenFileDialog.Multiselect = True

                    List1312KW.Clear()
                    List1313KW.Clear()

                    'Open the File Dialog to select the file
                    If (OpenFileDialog.ShowDialog(Me) = DialogResult.OK) Then
                        Dim file As String

                        For Each file In OpenFileDialog.FileNames
                            ListDs.Clear()

                            If IO.Path.GetExtension(file).ToUpper = ".PDF" Then

                                Using documentProcessor As New DevExpress.Pdf.PdfDocumentProcessor()
                                    documentProcessor.LoadDocument(file)

                                    ListDs.AddRange(documentProcessor.Text.Split(Chr(13)))

                                    KW_LOADING(ListDs)

                                End Using

                            End If
                        Next


                        vS10.ActiveSheet.RowCount = List1312KW.Count
                        vS20.ActiveSheet.RowCount = List1312KW.Count

                        str_AutoLink = ""

                        Dim i As Integer

                        For i = 0 To List1312KW.Count - 1
                            str_AutoLink = str_AutoLink & "''" & List1312KW(i).ShoesCode + "'',"
                        Next

                        If str_AutoLink = "" Then Exit Sub

                        str_AutoLink = Strings.Left(str_AutoLink, Len(str_AutoLink) - 1)



                        For i = 0 To vS10.ActiveSheet.RowCount - 1
                            setData(vS10, getColumIndex(vS10, "ShoesCode"), i, List1312KW(i).ShoesCode)

                            If READ_PFK7106(List1312KW(i).ShoesCode) Then
                                setData(vS10, getColumIndex(vS10, "cdSpecState"), i, D7106.cdSpecState)


                                setData(vS10, getColumIndex(vS10, "ShoesCode"), i, D7106.ShoesCode)
                                setData(vS10, getColumIndex(vS10, "Style"), i, D7106.Style)
                                setData(vS10, getColumIndex(vS10, "CustSpecNo"), i, D7106.CustSpecNo)
                                setData(vS10, getColumIndex(vS10, "ProductCode"), i, D7106.ProductCode)

                                setData(vS10, getColumIndex(vS10, "Line"), i, D7106.Line)
                                setData(vS10, getColumIndex(vS10, "Article"), i, D7106.Article)
                                setData(vS10, getColumIndex(vS10, "MCODE"), i, D7106.MCODE)
                                setData(vS10, getColumIndex(vS10, "MCODEName"), i, D7106.MCODEName)

                                setData(vS10, getColumIndex(vS10, "ColorCode"), i, D7106.ColorCode)
                                setData(vS10, getColumIndex(vS10, "ColorName"), i, D7106.ColorName)
                                setData(vS10, getColumIndex(vS10, "SizeRange"), i, D7106.SizeRange)

                                Call READ_PFK7104(D7106.SizeRange)

                                setData(vS10, getColumIndex(vS10, "SizeRangeName"), i, D7104.SizeRangeName)

                            End If

                            setData(vS10, getColumIndex(vS10, "QtyOrder"), i, List1312KW(i).QtyOrder)
                            setData(vS10, getColumIndex(vS10, "JbCard"), i, List1312KW(i).JbCard)
                            setData(vS10, getColumIndex(vS10, "PONO"), i, List1312KW(i).PONO)

                            setData(vS10, getColumIndex(vS10, "PriceOrder"), i, List1312KW(i).PriceOrder)
                            setData(vS10, getColumIndex(vS10, "Destination"), i, List1312KW(i).Destination)
                            setData(vS10, getColumIndex(vS10, "Country"), i, List1312KW(i).Country)

                            setData(vS10, getColumIndex(vS10, "CustomerName"), i, List1312KW(i).CustomerName)
                            setData(vS10, getColumIndex(vS10, "FinalShop"), i, List1312KW(i).Destination)

                            setData(vS10, getColumIndex(vS10, "Datedelivery"), i, List1312KW(i).Datedelivery)

                            setData(vS10, getColumIndex(vS10, "DateLable"), i, List1312KW(i).DateLable)
                            setData(vS10, getColumIndex(vS10, "cdUnitPrice"), i, List1312KW(i).cdUnitPrice)

                        Next


                        'For i = 0 To vS10.ActiveSheet.RowCount - 1
                        '    setData(vS10, getColumIndex(vS10, "QtyOrder"), i, List1312KW(i).QtyOrder)
                        '    setData(vS10, getColumIndex(vS10, "JbCard"), i, List1312KW(i).JbCard)
                        '    setData(vS10, getColumIndex(vS10, "PONO"), i, List1312KW(i).PONO)
                        'Next

                        For i = 0 To vS20.ActiveSheet.RowCount - 1
                            setData(vS20, getColumIndex(vS20, "SizeQty01"), i, List1313KW(i).SizeQty01)
                            setData(vS20, getColumIndex(vS20, "SizeQty02"), i, List1313KW(i).SizeQty02)
                            setData(vS20, getColumIndex(vS20, "SizeQty03"), i, List1313KW(i).SizeQty03)
                            setData(vS20, getColumIndex(vS20, "SizeQty04"), i, List1313KW(i).SizeQty04)
                            setData(vS20, getColumIndex(vS20, "SizeQty05"), i, List1313KW(i).SizeQty05)
                            setData(vS20, getColumIndex(vS20, "SizeQty06"), i, List1313KW(i).SizeQty06)
                            setData(vS20, getColumIndex(vS20, "SizeQty07"), i, List1313KW(i).SizeQty07)
                            setData(vS20, getColumIndex(vS20, "SizeQty08"), i, List1313KW(i).SizeQty08)
                            setData(vS20, getColumIndex(vS20, "SizeQty09"), i, List1313KW(i).SizeQty09)
                            setData(vS20, getColumIndex(vS20, "SizeQty10"), i, List1313KW(i).SizeQty10)
                            setData(vS20, getColumIndex(vS20, "SizeQty11"), i, List1313KW(i).SizeQty11)
                            setData(vS20, getColumIndex(vS20, "SizeQty12"), i, List1313KW(i).SizeQty12)
                            setData(vS20, getColumIndex(vS20, "SizeQty13"), i, List1313KW(i).SizeQty13)
                            setData(vS20, getColumIndex(vS20, "SizeQty14"), i, List1313KW(i).SizeQty14)
                            setData(vS20, getColumIndex(vS20, "SizeQty15"), i, List1313KW(i).SizeQty15)
                            setData(vS20, getColumIndex(vS20, "SizeQty16"), i, List1313KW(i).SizeQty16)
                            setData(vS20, getColumIndex(vS20, "SizeQty17"), i, List1313KW(i).SizeQty17)
                            setData(vS20, getColumIndex(vS20, "SizeQty18"), i, List1313KW(i).SizeQty18)
                            setData(vS20, getColumIndex(vS20, "SizeQty19"), i, List1313KW(i).SizeQty19)
                            setData(vS20, getColumIndex(vS20, "SizeQty20"), i, List1313KW(i).SizeQty20)
                            setData(vS20, getColumIndex(vS20, "SizeQty21"), i, List1313KW(i).SizeQty21)
                            setData(vS20, getColumIndex(vS20, "SizeQty22"), i, List1313KW(i).SizeQty22)
                            setData(vS20, getColumIndex(vS20, "SizeQty23"), i, List1313KW(i).SizeQty23)
                            setData(vS20, getColumIndex(vS20, "SizeQty24"), i, List1313KW(i).SizeQty24)
                            setData(vS20, getColumIndex(vS20, "SizeQty25"), i, List1313KW(i).SizeQty25)
                            setData(vS20, getColumIndex(vS20, "SizeQty26"), i, List1313KW(i).SizeQty26)
                            setData(vS20, getColumIndex(vS20, "SizeQty27"), i, List1313KW(i).SizeQty27)
                            setData(vS20, getColumIndex(vS20, "SizeQty28"), i, List1313KW(i).SizeQty28)
                            setData(vS20, getColumIndex(vS20, "SizeQty29"), i, List1313KW(i).SizeQty29)
                            setData(vS20, getColumIndex(vS20, "SizeQty30"), i, List1313KW(i).SizeQty30)
                        Next


                    Else 'Cancel

                        Exit Sub

                    End If



                End Using
                Exit Sub
            End If

            Using OpenFileDialog As OpenFileDialog = Me.GetOpenFileDialog()

                'Open the File Dialog to select the file
                If (OpenFileDialog.ShowDialog(Me) = DialogResult.OK) Then
                    If IO.Path.GetExtension(OpenFileDialog.FileName).ToUpper = ".PDF" Then

                        Using documentProcessor As New DevExpress.Pdf.PdfDocumentProcessor()
                            documentProcessor.LoadDocument(OpenFileDialog.FileName)

                            ListDs.AddRange(documentProcessor.Text.Split(Chr(13)))

                            If txt_CustomerCode.Code = "000001" Then Call GEOX_LOADING(ListDs)
                            If txt_CustomerCode.Code = "000002" Then Call KW_LOADING(ListDs)
                            If txt_CustomerCode.Code = "000004" Then Call WW_LOADING(ListDs)

                        End Using

                    End If

                Else 'Cancel

                    Exit Sub

                End If

            End Using
        Catch ex As Exception

        End Try
    End Sub
    Private Sub cmd_FullView_Click(sender As Object, e As EventArgs) Handles cmd_FullView.Click
        Try
            If tbl_Main.RowStyles(0).Height > 0 Then
                tbl_Main.RowStyles(0).Height = 0
            Else
                tbl_Main.RowStyles(0).Height = 185
            End If

        Catch ex As Exception

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

    Private Function DATA_SEARCH_VS20_LINE(OrderNo As String, OrderNoSeq As String) As Boolean
        Dim DSNEW As New DataSet

        DATA_SEARCH_VS20_LINE = False

        Try
            DSNEW = PrcDS("USP_ISU1311A_SEARCH_VS20_LINE", cn, OrderNo, OrderNoSeq)

            If GetDsRc(DSNEW) = 0 Then
                Exit Function
            End If
            READ_SPREAD(vS20, DSNEW, "USP_ISU1311A_SEARCH_VS20", "vS20", vS20.ActiveSheet.ActiveRowIndex)

            DATA_SEARCH_VS20_LINE = True
        Catch ex As Exception
            Call MsgBoxP("DATA_SEARCH_VS20_LINE")
        End Try
    End Function

    

#End Region

#Region "Keydown"

    Private Sub Vs20_KeyDown(sender As Object, e As KeyEventArgs) Handles vS20.KeyDown
        If wJOB = 2 Then Exit Sub
        Dim xCOL As Long
        Dim xROW As Long

        xCOL = vS20.ActiveSheet.ActiveColumnIndex
        xROW = vS20.ActiveSheet.ActiveRowIndex
        Try

            Select Case e.KeyCode
                Case Keys.Insert


                Case Keys.Delete


                Case Keys.Enter

            End Select

        Catch ex As Exception
            Call MsgBoxP("vS20_KeyDown")
        End Try
    End Sub

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

    Private Sub vS20_Change(sender As Object, e As ChangeEventArgs) Handles vS20.Change
        If Data_Check() = False Then Exit Sub

        Try
            If DATA_MOVE_WRITE03_ROW(e.Row) = True Then
                DATA_SEARCH_VS20_LINE(getData(vS20, getColumIndex(vS20, "KEY_OrderNo"), vS20.ActiveSheet.ActiveRowIndex), getData(vS20, getColumIndex(vS20, "KEY_OrderNoSeq"), vS20.ActiveSheet.ActiveRowIndex))
                Call PrcExe("USP_PFK1312_UPDATE_SIZEQTY", cn, W1313.OrderNo)
            End If

        Catch ex As Exception
            Call MsgBoxP("vS20_Change")
        End Try
    End Sub


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

    
    Private Sub cmd_AttachID_Click(sender As Object, e As EventArgs) Handles cmd_AttachID.Click
        If ISUD7555A.Link_ISUD7555A(3, "ISUD1312", txt_OrderNo.Data & ";" & txt_OrderNoSeq.Data) = False Then Exit Sub


    End Sub

    Private Sub vS10_CellClick(sender As Object, e As CellClickEventArgs) Handles vS10.CellClick
        txt_OrderNoSeq.Data = getData(vS10, getColumIndex(vS10, "KEY_OrderNoSeq"), e.Row)

    End Sub

    Private Sub cmd_Convert_Click(sender As Object, e As EventArgs) Handles cmd_Convert.Click


    End Sub
#End Region


    

    
End Class