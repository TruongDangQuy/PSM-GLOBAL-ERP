Imports System.Net.Mail
Imports System.Text
Imports System.IO.Ports

Public Class ISUD4107A

    '#Region "Variable"
    '    Private wJOB As Integer

    '    Private W0102 As New T0102_AREA

    '    Private W1311 As New T1311_AREA
    '    Private L1311 As New T1311_AREA

    '    Private W1312 As New T1312_AREA
    '    Private L1312 As New T1312_AREA

    '    Private W1313 As New T1313_AREA
    '    Private L1313 As New T1313_AREA

    '    Private W1314 As New T1314_AREA
    '    Private L1314 As New T1314_AREA

    '    Private W1315 As New T1315_AREA
    '    Private L1315 As New T1315_AREA

    '    Private W1316 As New T1316_AREA
    '    Private L1316 As New T1316_AREA

    '    Private W7156 As New T7156_AREA
    '    Private W7104 As New T7104_AREA


    '    Private WRITE_CHK As String
    '    Private ImportTax As Decimal
    '    Private EnvironmentTax As Decimal
    '    Private VatTax As Decimal
    '    Private formA As Boolean
    '    Private CHK(0 To 5) As String

    '    Private sizeInfo As Boolean = False
    '    Private specInfo As Boolean = False
    '    Private schedulaInfo As Boolean = False
    '    Private remarkInfo As Boolean = False


    '#End Region

    '#Region "Link"
    '    Public Function Link_ISUD1311A(job As Integer, OrderNo As String, Optional ByVal TAG As String = "") As Boolean
    '        Me.Tag = TAG
    '        D1311.OrderNo = OrderNo

    '        wJOB = job : L1311 = D1311

    '        Link_ISUD1311A = False
    '        Try

    '            Select Case job
    '                Case 1
    '                Case 5

    '            End Select

    '            formA = False
    '            Me.ShowDialog()

    '            Link_ISUD1311A = isudCHK


    '        Catch ex As Exception
    '            Call MsgBoxP("61", WordConv("YARN PROCESSING"))
    '        End Try

    '    End Function

    '#End Region

    '#Region "Form"
    '    Private Sub Form_Activate(sender As Object, e As EventArgs) Handles Me.Load
    '        If formA = True Then Exit Sub

    '        WRITE_CHK = ""
    '        'Me.Form_Initial()
    '        Me.Form_KeyDown()

    '        Call DATA_INIT()
    '        Call FORM_INIT()

    '        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

    '        Select Case wJOB
    '            Case 1
    '                Me.Text = Me.Text & " - INSERT"
    '                cmd_DEL.Visible = False

    '                If CHK(1) <> "1" Then
    '                    isudCHK = False
    '                    Me.Dispose()
    '                    formA = True
    '                    Call MsgBoxP("You have no right is this program !")
    '                    Exit Sub
    '                End If

    '                Call KEY_COUNT()
    '                Call DATA_SEARCH_vS10()
    '                Setfocus(txt_CustomerCode)

    '            Case 2
    '                Me.Text = Me.Text & " - SEARCH"
    '                cmd_DEL.Visible = False
    '                cmd_OK.Visible = False

    '                If CHK(2) <> "1" Then
    '                    isudCHK = False
    '                    Me.Dispose()
    '                    formA = True
    '                    Call MsgBoxP("You have no right is this program !")
    '                    Exit Sub
    '                End If

    '                Call DATA_SEARCH01()
    '                Call DATA_SEARCH_vS10()

    '            Case 3
    '                Me.Text = Me.Text & " - UPDATE"
    '                txt_OrderNo.Enabled = False

    '                If CHK(3) <> "1" Then
    '                    If CHK(2) <> "1" Then
    '                        isudCHK = False
    '                        Me.Dispose()
    '                        formA = True
    '                        Call MsgBoxP("You have no right is this program !")
    '                        Exit Sub
    '                    Else

    '                        Me.Text = Me.Text & " - SEARCH"
    '                        isudCHK = False
    '                        formA = True
    '                        wJOB = 2
    '                        cmd_DEL.Visible = False
    '                        Call MsgBoxP("Only Search !") : cmd_OK.Visible = False
    '                    End If
    '                End If

    '                Call DATA_SEARCH01()
    '                Call DATA_SEARCH_vS10()

    '            Case 4
    '                Me.Text = Me.Text & " - DELETE"
    '                cmd_OK.Visible = False


    '                If CHK(4) <> "1" Then
    '                    isudCHK = False
    '                    Me.Dispose()
    '                    formA = True
    '                    Call MsgBoxP("You have no right is this program !")
    '                    Exit Sub
    '                End If

    '                Call DATA_SEARCH01()
    '                Call DATA_SEARCH_vS10()

    '        End Select

    '        formA = True
    '    End Sub

    '    Private Sub DATA_INIT()
    '        Try
    '            txt_OrderNo.Enabled = False
    '            Call D1311_CLEAR()
    '        Catch ex As Exception
    '            Call MsgBoxP("35", "DATA_INIT")
    '        End Try
    '    End Sub

    '    Private Sub FORM_INIT()

    '    End Sub

    '#End Region

    '#Region "Search"

    '    Private Function DATA_SEARCH01() As Boolean
    '        DATA_SEARCH01 = False
    '        Try
    '            DS1 = PrcDS("USP_ISU1311A_SEARCH_HEAD", cn, L1311.OrderNo)

    '            If GetDsRc(DS1) = 0 Then
    '                DS2 = READ_PFK1311(L1311.OrderNo, cn)
    '                If GetDsRc(DS2) > 0 Then
    '                    Call READER_MOVE(Me, DS2)
    '                End If
    '                Exit Function
    '                isudCHK = False
    '            End If

    '            STORE_MOVE(Me, DS1)
    '            txt_Remark_Order.Data = GetDsData(DS1, 0, "RemarkOrder")
    '            txt_Remark_Customer.Data = GetDsData(DS1, 0, "RemarkCustomer")
    '            txt_CustPoNo.Data = GetDsData(DS1, 0, "CustPoNo")

    '            DATA_SEARCH01 = True

    '        Catch ex As Exception
    '            Call MsgBoxP("35", "DATA_SEARCH01")
    '        End Try

    '    End Function

    '    Private Function DATA_SEARCH02(SpecNo As String, SpecNoSeq As String) As Boolean

    '        DATA_SEARCH02 = False
    '        Try

    '            DS1 = PrcDS("USP_ISU1311A_SEARCH_HEAD_SPECINFO", cn, SpecNo, SpecNoSeq)

    '            If GetDsRc(DS1) = 0 Then
    '                DS2 = READ_PFK0102(SpecNo, SpecNoSeq, cn)

    '                If GetDsRc(DS2) > 0 Then
    '                    Call READER_MOVE(Me, DS2)
    '                End If

    '                Exit Function
    '                isudCHK = False
    '            End If

    '            STORE_MOVE(Me, DS1)
    '            txt_RemarkOrder.Data = GetDsData(DS1, 0, "RemarkOrder")
    '            txt_RemarkCustomer.Data = GetDsData(DS1, 0, "RemarkCustomer")

    '            'Call CheckInBoundMaterial(GetDsData(DS1, 0, "CheckInBoundMaterial"))
    '            'Call CheckMarketType(GetDsData(DS1, 0, "CheckMarketType"))
    '            'Call CheckMaterialType(GetDsData(DS1, 0, "CheckMaterialType"))

    '            'If READ_PFK7101(txt_SupplierCode.Code) = True Then
    '            '    txt_SupplierCode.Data = D7101.CustomerName
    '            'End If

    '            DATA_SEARCH02 = True

    '        Catch ex As Exception
    '            Call MsgBoxP("35", "DATA_SEARCH02")
    '        End Try

    '    End Function

    '    Private Function DATA_SEARCH03(OrderNo As String) As Boolean

    '        DATA_SEARCH03 = False
    '        Try

    '            DS1 = PrcDS("USP_ISU1311A_SEARCH_HEAD_SPECINFO_SUM", cn, OrderNo)

    '            If GetDsRc(DS1) = 0 Then
    '                DS2 = READ_PFK0102_OrderNo(OrderNo, cn)

    '                If GetDsRc(DS2) > 0 Then
    '                    Call READER_MOVE(Me, DS2)
    '                End If

    '                Exit Function
    '                isudCHK = False
    '            End If

    '            STORE_MOVE(Me, DS1)
    '            'txt_RemarkOrder.Data = GetDsData(DS1, 0, "RemarkOrder")
    '            'txt_RemarkCustomer.Data = GetDsData(DS1, 0, "RemarkCustomer")

    '            'Call CheckInBoundMaterial(GetDsData(DS1, 0, "CheckInBoundMaterial"))
    '            'Call CheckMarketType(GetDsData(DS1, 0, "CheckMarketType"))
    '            'Call CheckMaterialType(GetDsData(DS1, 0, "CheckMaterialType"))

    '            'If READ_PFK7101(txt_SupplierCode.Code) = True Then
    '            '    txt_SupplierCode.Data = D7101.CustomerName
    '            'End If

    '            DATA_SEARCH03 = True

    '        Catch ex As Exception
    '            Call MsgBoxP("35", "DATA_SEARCH02")
    '        End Try

    '    End Function

    '    Private Function DATA_SEARCH_vS10() As Boolean
    '        DATA_SEARCH_vS10 = False
    '        Try

    '            DS1 = PrcDS("USP_ISU1311A_SEARCH_VS10", cn, L1311.OrderNo)

    '            If GetDsRc(DS1) = 0 Then
    '                SPR_PRO_NEW(Vs10, DS1, "USP_ISU1311A_SEARCH_VS10", "VS10")
    '                Vs10.ActiveSheet.RowCount = 10
    '                Vs10.Enabled = True
    '                Exit Function
    '            End If

    '            SPR_PRO_NEW(Vs10, DS1, "USP_ISU1311A_SEARCH_VS10", "Vs10")

    '            DATA_SEARCH_vS10 = True

    '        Catch ex As Exception
    '            Call MsgBoxP("35", "DATA_SEARCH_vS10")
    '        End Try

    '    End Function

    '    Private Function DATA_SEARCH_vS20() As Boolean
    '        DATA_SEARCH_vS20 = False
    '        Dim DSNEW As New DataSet
    '        Dim i As Integer
    '        Try
    '            DSNEW = PrcDS("USP_ISU1311A_SEARCH_VS20_HEAD", cn, L1311.OrderNo)
    '            Dim cc = GetDsCc(DSNEW)
    '            Vs20.Enabled = True

    '            DS1 = PrcDS("USP_ISU1311A_SEARCH_VS20", cn, L1311.OrderNo)

    '            If GetDsRc(DS1) = 0 Then
    '                DS2 = PrcDS("USP_ISU1311A_SEARCH_VS20_INSERT", cn, L1311.OrderNo)
    '                SPR_PRO_MULTICOLUMNHEADROW(Vs20, DS2, GetDsRc(DS2), "USP_ISU1311A_SEARCH_VS20_INSERT", "Vs20")
    '                Vs20.ActiveSheet.RowCount = GetDsRc(DS2)
    '                Vs20.ActiveSheet.ColumnCount = GetDsCc(DS2) + cc

    '                i = -1
    '                For Each RS01 As DataRow In DSNEW.Tables(0).Rows
    '                    i += 1
    '                    For j As Integer = 0 To cc - 1
    '                        setDataCH(Vs20, j + GetDsCc(DS2) - 1, i, RS01(j))
    '                    Next
    '                Next

    '                Vs20.Enabled = True
    '                Exit Function
    '            End If

    '            SPR_PRO_MULTICOLUMNHEADROW(Vs20, DS1, GetDsRc(DS1), "USP_ISU1311A_SEARCH_VS20", "Vs20")
    '            i = -1
    '            DS2 = PrcDS("USP_ISU1311A_SEARCH_VS20_INSERT", cn, L1311.OrderNo)
    '            For Each RS01 As DataRow In DSNEW.Tables(0).Rows
    '                i += 1
    '                For j As Integer = 0 To cc - 1
    '                    setDataCH(Vs20, j + GetDsCc(DS2) - 1, i, RS01(j))
    '                Next
    '            Next

    '            Vs20.Enabled = True
    '            DATA_SEARCH_vS20 = True

    '        Catch ex As Exception
    '            Call MsgBoxP("35", "DATA_SEARCH_vS20")
    '        End Try

    '    End Function

    '    Private Function DATA_SEARCH_vS30() As Boolean
    '        DATA_SEARCH_vS30 = False
    '        Try

    '            DS1 = PrcDS("USP_ISU1311A_SEARCH_VS30", cn, L1311.OrderNo)

    '            If GetDsRc(DS1) = 0 Then
    '                SPR_PRO_NEW(Vs30, DS1, "USP_ISU1311A_SEARCH_VS30", "Vs30")
    '                Vs30.ActiveSheet.RowCount = 10
    '                Vs30.Enabled = True
    '                Exit Function
    '            End If

    '            SPR_PRO(Vs30, DS1, "USP_ISU1311A_SEARCH_VS30", "vS30")
    '            DATA_SEARCH_vS30 = True

    '        Catch ex As Exception
    '            Call MsgBoxP("35", "DATA_SEARCH_vS30")
    '        End Try

    '    End Function

    '    Private Function DATA_SEARCH_vS31(SpecNo As String, SpecNoSeq As String) As Boolean
    '        DATA_SEARCH_vS31 = False
    '        Try

    '            DS1 = PrcDS("USP_ISU1311A_SEARCH_VS31", cn, SpecNo, SpecNoSeq)

    '            If GetDsRc(DS1) = 0 Then
    '                SPR_PRO_NEW(Vs31, DS1, "USP_ISU1311A_SEARCH_VS31", "Vs31")
    '                Vs31.ActiveSheet.RowCount = 10
    '                Vs31.Enabled = True
    '                Exit Function
    '            End If

    '            SPR_PRO(Vs31, DS1, "USP_ISU1311A_SEARCH_VS31", "Vs31")
    '            DATA_SEARCH_vS31 = True

    '        Catch ex As Exception
    '            Call MsgBoxP("35", "DATA_SEARCH_vS31")
    '        End Try

    '    End Function

    '    Private Function DATA_SEARCH_vS32(SpecNo As String, SpecNoSeq As String) As Boolean
    '        DATA_SEARCH_vS32 = False
    '        Try
    '            DS1 = PrcDS("USP_ISU1311A_SEARCH_VS32", cn, SpecNo, SpecNoSeq)

    '            If GetDsRc(DS1) = 0 Then
    '                SPR_PRO_NEW(Vs32, DS1, "USP_ISU1311A_SEARCH_VS32", "Vs32")
    '                Vs32.ActiveSheet.RowCount = 10
    '                Vs32.Enabled = True
    '                Exit Function
    '            End If

    '            SPR_PRO(Vs32, DS1, "USP_ISU1311A_SEARCH_VS32", "Vs32")
    '            DATA_SEARCH_vS32 = True

    '        Catch ex As Exception
    '            Call MsgBoxP("35", "DATA_SEARCH_vS32")
    '        End Try

    '    End Function

    '    Private Function DATA_SEARCH_vS33(SpecNo As String, SpecNoSeq As String) As Boolean
    '        DATA_SEARCH_vS33 = False
    '        Try
    '            DS1 = PrcDS("USP_ISU1311A_SEARCH_VS33", cn, SpecNo, SpecNoSeq)

    '            If GetDsRc(DS1) = 0 Then
    '                SPR_PRO_NEW(Vs33, DS1, "USP_ISU1311A_SEARCH_VS33", "Vs33")
    '                Vs33.ActiveSheet.RowCount = 10
    '                Vs33.Enabled = True
    '                Exit Function
    '            End If

    '            SPR_PRO(Vs33, DS1, "USP_ISU1311A_SEARCH_VS33", "Vs33")
    '            DATA_SEARCH_vS33 = True

    '        Catch ex As Exception
    '            Call MsgBoxP("35", "DATA_SEARCH_vS33")
    '        End Try

    '    End Function

    '    Private Function DATA_SEARCH_vS34(SpecNo As String, SpecNoSeq As String) As Boolean
    '        DATA_SEARCH_vS34 = False
    '        Try
    '            DS1 = PrcDS("USP_ISU1311A_SEARCH_VS34", cn, SpecNo, SpecNoSeq)

    '            If GetDsRc(DS1) = 0 Then
    '                SPR_PRO_NEW(Vs34, DS1, "USP_ISU1311A_SEARCH_VS34", "Vs34")
    '                Vs34.ActiveSheet.RowCount = 10
    '                Vs34.Enabled = True
    '                Exit Function
    '            End If

    '            SPR_PRO(Vs34, DS1, "USP_ISU1311A_SEARCH_VS34", "Vs34")
    '            DATA_SEARCH_vS34 = True

    '        Catch ex As Exception
    '            Call MsgBoxP("35", "DATA_SEARCH_vS34")
    '        End Try

    '    End Function

    '    Private Function DATA_SEARCH_vS35(SpecNo As String, SpecNoSeq As String) As Boolean
    '        DATA_SEARCH_vS35 = False
    '        Try
    '            DS1 = PrcDS("USP_ISU1311A_SEARCH_VS35", cn, SpecNo, SpecNoSeq)

    '            If GetDsRc(DS1) = 0 Then
    '                SPR_PRO_NEW(Vs35, DS1, "USP_ISU1311A_SEARCH_VS34", "Vs35")
    '                Vs35.ActiveSheet.RowCount = 10
    '                Vs35.Enabled = True
    '                Exit Function
    '            End If

    '            SPR_PRO(Vs35, DS1, "USP_ISU1311A_SEARCH_VS35", "Vs35")

    '            DATA_SEARCH_vS35 = True

    '        Catch ex As Exception
    '            Call MsgBoxP("35", "DATA_SEARCH_vS35")
    '        End Try

    '    End Function

    '    Private Function DATA_SEARCH_vS36(SpecNo As String, SpecNoSeq As String) As Boolean
    '        DATA_SEARCH_vS36 = False
    '        Try
    '            DS1 = PrcDS("USP_ISU1311A_SEARCH_VS36", cn, SpecNo, SpecNoSeq)

    '            If GetDsRc(DS1) = 0 Then
    '                SPR_PRO_NEW(Vs36, DS1, "USP_ISU1311A_SEARCH_VS36", "Vs36")
    '                Vs36.ActiveSheet.RowCount = 10
    '                Vs36.Enabled = True
    '                Exit Function
    '            End If

    '            SPR_PRO(Vs36, DS1, "USP_ISU1311A_SEARCH_VS36", "Vs36")

    '            DATA_SEARCH_vS36 = True

    '        Catch ex As Exception
    '            Call MsgBoxP("35", "DATA_SEARCH_vS36")
    '        End Try

    '    End Function

    '    Private Function DATA_SEARCH_vS37(SpecNo As String, SpecNoSeq As String) As Boolean
    '        DATA_SEARCH_vS37 = False
    '        Try
    '            DS1 = PrcDS("USP_ISU1311A_SEARCH_VS37", cn, SpecNo, SpecNoSeq)

    '            If GetDsRc(DS1) = 0 Then
    '                SPR_PRO_NEW(Vs37, DS1, "USP_ISU1311A_SEARCH_VS37", "Vs37")
    '                Vs37.ActiveSheet.RowCount = 10
    '                Vs37.Enabled = True
    '                Exit Function
    '            End If

    '            SPR_PRO(Vs37, DS1, "USP_ISU1311A_SEARCH_VS37", "Vs37")

    '            DATA_SEARCH_vS37 = True

    '        Catch ex As Exception
    '            Call MsgBoxP("35", "DATA_SEARCH_vS37")
    '        End Try

    '    End Function

    '    Private Function DATA_SEARCH_vS40() As Boolean
    '        DATA_SEARCH_vS40 = False
    '        Try
    '            DS1 = PrcDS("USP_ISU1311A_SEARCH_VS40", cn, L1311.OrderNo)

    '            If GetDsRc(DS1) = 0 Then
    '                SPR_PRO_NEW(Vs40, DS1, "USP_ISU1311A_SEARCH_VS40", "Vs40")
    '                Vs40.ActiveSheet.RowCount = 10
    '                Vs40.Enabled = True
    '                Exit Function
    '            End If

    '            SPR_PRO(Vs40, DS1, "USP_ISU1311A_SEARCH_VS40", "Vs40")

    '            DATA_SEARCH_vS40 = True

    '        Catch ex As Exception
    '            Call MsgBoxP("35", "DATA_SEARCH_vS40")
    '        End Try

    '    End Function

    '    Private Function DATA_SEARCH_vS41(OrderNo As String, OrderNoSeq As String) As Boolean
    '        DATA_SEARCH_vS41 = False
    '        Try
    '            DS1 = PrcDS("USP_ISU1311A_SEARCH_VS41", cn, OrderNo, OrderNoSeq)

    '            If GetDsRc(DS1) = 0 Then
    '                SPR_PRO_NEW(Vs41, DS1, "USP_ISU1311A_SEARCH_VS41", "Vs41")
    '                Vs41.ActiveSheet.RowCount = 10
    '                Vs41.Enabled = True
    '                Exit Function
    '            End If

    '            SPR_PRO(Vs41, DS1, "USP_ISU1311A_SEARCH_VS41", "Vs41")

    '            DATA_SEARCH_vS41 = True

    '        Catch ex As Exception
    '            Call MsgBoxP("35", "DATA_SEARCH_vS41")
    '        End Try

    '    End Function

    '    Private Function DATA_SEARCH_vS50() As Boolean
    '        DATA_SEARCH_vS50 = False
    '        'Try
    '        '    DS1 = PrcDS("USP_ISU1311A_SEARCH_VS50", cn, L1311.OrderNo)

    '        '    If GetDsRc(DS1) = 0 Then
    '        '        DS2 = PrcDS("USP_ISU1311A_SEARCH_VS50_INSERT", cn, L1311.OrderNo)

    '        '        SPR_SET(vS50, , , , OperationMode.Normal)
    '        '        SPR_PRO(vS50, DS2, "USP_ISU1311A_SEARCH_VS50", "vS50")
    '        '        SPR_INSERT(vS50)
    '        '        vS50.Enabled = True
    '        '        Exit Function
    '        '    End If

    '        '    SPR_SET(vS50, , , , OperationMode.Normal)
    '        '    SPR_PRO(vS50, DS1, "USP_ISU1311A_SEARCH_VS50", "vS50")

    '        '    DATA_SEARCH_vS50 = True

    '        'Catch ex As Exception
    '        '    Call MsgBoxP("35", "DATA_SEARCH_vS50")
    '        'End Try

    '    End Function

    '#End Region

    '#Region "Function"

    '    Private Sub DATA_MOVE_DEFAULT()
    '        Try
    '            'PFK1311

    '            W1311.seSeason = ListCode("Season")
    '            W1311.seOrderGroup = ListCode("OrderGroup")
    '            W1311.seStateOfficial = ListCode("StateOfficial")
    '            W1311.seOrderGroup = ListCode("OrderGroup")
    '            W1311.seOrderKind = ListCode("OrderKind")
    '            W1311.seOrderType = ListCode("OrderType")
    '            W1311.seOrderKind = ListCode("OrderKind")
    '            W1311.seOrderWork = ListCode("OrderWork")
    '            W1311.seStateSample = ListCode("StateSample")
    '            W1311.seDepartment = ListCode("Department")
    '            W1311.seBrand = ListCode("Brand")
    '            W1311.sePaymentTerm = ListCode("PaymentTerm")
    '            W1311.seDeliveryTerm = ListCode("DeliveryTerm")
    '            W1311.seShippingTerm = ListCode("ShippingTerm")
    '            W1311.seMarketType = ListCode("MarketType")

    '            'PFK1312
    '            W1312.seSpecStatus = ListCode("SpecStatus")
    '            W1312.seUnitMaterial = ListCode("UnitMaterial")
    '            W1312.seUnitPacking = ListCode("UnitPacking")

    '            'PFK1314
    '            W1314.seOrderProcess = ListCode("OrderProcess")
    '            W1314.seProcessState = ListCode("ProcessState")

    '            'PFK1316
    '            W1316.seProcessType = ListCode("ProcessType")

    '        Catch ex As Exception
    '            Call Error_Message("62", "DATA_MOVE_DEFAULT")
    '        End Try

    '    End Sub

    '    Private Function DATA_MOVE_WRITE01() As Boolean
    '        DATA_MOVE_WRITE01 = False
    '        Try

    '            If READ_PFK1311(txt_OrderNo.Data) = True Then

    '                W1311.CustomerCode = txt_CustomerCode.Code
    '                W1311.CustPoNo = txt_CustPoNo.Data

    '                W1311.cdSeason = txt_cdSeason.Code
    '                W1311.cdStateOfficial = txt_cdStateOfficial.Code
    '                W1311.cdSeason = txt_cdOrderGroup.Code
    '                W1311.cdOrderKind = txt_cdOrderKind.Code
    '                W1311.cdOrderType = txt_cdOrderType.Code
    '                W1311.cdOrderWork = txt_cdOrderWork.Code
    '                W1311.cdStateSample = txt_cdStateSample.Code
    '                W1311.InchargeSales = txt_InchargeSales.Code
    '                W1311.cdDepartment = txt_cdDepartment.Code
    '                W1311.cdBrand = txt_cdBrand.Code
    '                W1311.InchargePPC = txt_InchargePPC.Code
    '                W1311.cdPaymentTerm = txt_cdPaymentTerm.Code
    '                W1311.cdDeliveryTerm = txt_cdDeliveryTerm.Code
    '                W1311.cdShippingTerm = txt_cdShippingTerm.Code
    '                W1311.cdMarketType = txt_cdMarketType.Code

    '                DATA_MOVE_DEFAULT()

    '                Call REWRITE_PFK1311(W1311)
    '                isudCHK = True
    '            Else
    '                W1311.OrderNo = L1311.OrderNo

    '                W1311.CustomerCode = txt_CustomerCode.Code
    '                W1311.CustPoNo = txt_CustPoNo.Data

    '                W1311.cdSeason = txt_cdSeason.Code
    '                W1311.cdStateOfficial = txt_cdStateOfficial.Code
    '                W1311.cdSeason = txt_cdOrderGroup.Code
    '                W1311.cdOrderKind = txt_cdOrderKind.Code
    '                W1311.cdOrderType = txt_cdOrderType.Code
    '                W1311.cdOrderWork = txt_cdOrderWork.Code
    '                W1311.cdStateSample = txt_cdStateSample.Code
    '                W1311.InchargeSales = txt_InchargeSales.Code
    '                W1311.cdDepartment = txt_cdDepartment.Code
    '                W1311.cdBrand = txt_cdBrand.Code
    '                W1311.InchargePPC = txt_InchargePPC.Code
    '                W1311.cdPaymentTerm = txt_cdPaymentTerm.Code
    '                W1311.cdDeliveryTerm = txt_cdDeliveryTerm.Code
    '                W1311.cdShippingTerm = txt_cdShippingTerm.Code
    '                W1311.cdMarketType = txt_cdMarketType.Code

    '                DATA_MOVE_DEFAULT()

    '                Call WRITE_PFK1311(W1311)

    '                isudCHK = True
    '            End If

    '            DATA_MOVE_WRITE01 = True
    '        Catch ex As Exception
    '            MsgBoxP("DATA_MOVE_WRITE01")
    '        End Try
    '    End Function

    '    Private Function DATA_MOVE_WRITE02() As Boolean
    '        DATA_MOVE_WRITE02 = False
    '        Try
    '            Dim i As Integer
    '            Dim j As Integer

    '            j = 0
    '            For i = 0 To Vs10.ActiveSheet.RowCount - 1
    '                If Trim(getData(Vs10, getColumIndex(Vs10, "MaterialCode"), i)) = "" Then GoTo skip

    '                j = j + 1

    '                If K1312_MOVE(Vs10, i, W1312, txt_OrderNo.Data, getData(Vs10, getColumIndex(Vs10, "KEY_OrderNoSeq"), i)) = True Then

    '                    W1312.PKO = getData(Vs10, getColumIndex(Vs10, "PKO"), i)
    '                    W1312.cdSpecStatus = getData(Vs10, getColumIndex(Vs10, "cdSpecStatus"), i)
    '                    W1312.Article = getData(Vs10, getColumIndex(Vs10, "Article"), i)
    '                    W1312.Line = getData(Vs10, getColumIndex(Vs10, "Line"), i)
    '                    W1312.Color = getData(Vs10, getColumIndex(Vs10, "Color"), i)

    '                    W1312.MaterialCode = getData(Vs10, getColumIndex(Vs10, "MaterialCode"), i)
    '                    W1312.MoldCode = getData(Vs10, getColumIndex(Vs10, "cdMoldCode"), i)
    '                    W1312.LastCode = getData(Vs10, getColumIndex(Vs10, "cdLastCode"), i)
    '                    W1312.CuttingDieCode = getData(Vs10, getColumIndex(Vs10, "cdCuttingDieCode"), i)

    '                    W1312.SizeRange = getData(Vs10, getColumIndex(Vs10, "cdSizeRange"), i)
    '                    W1312.SpeciticSize = getData(Vs10, getColumIndex(Vs10, "SpeciticSize"), i)

    '                    W1312.cdUnitMaterial = getData(Vs10, getColumIndex(Vs10, "cdUnitMaterial"), i)
    '                    W1312.cdUnitPacking = getData(Vs10, getColumIndex(Vs10, "cdUnitPacking"), i)

    '                    W1312.cdUnitPacking = getData(Vs10, getColumIndex(Vs10, "SpecNo"), i)
    '                    W1312.cdUnitPacking = getData(Vs10, getColumIndex(Vs10, "SpecNoSeq"), i)

    '                    DATA_MOVE_DEFAULT()
    '                    W1312.RemarkOrder = txt_Remark_Order.Data
    '                    W1312.RemarkCustomer = txt_Remark_Customer.Data

    '                    Call REWRITE_PFK1312(W1312)

    '                    isudCHK = True
    '                Else
    '                    W1312.OrderNo = L1311.OrderNo

    '                    Call KEY_COUNT_PFK1312()

    '                    W1312.PKO = getData(Vs10, getColumIndex(Vs10, "PKO"), i)
    '                    W1312.cdSpecStatus = getData(Vs10, getColumIndex(Vs10, "cdSpecStatus"), i)
    '                    W1312.Article = getData(Vs10, getColumIndex(Vs10, "Article"), i)
    '                    W1312.Line = getData(Vs10, getColumIndex(Vs10, "Line"), i)
    '                    W1312.Color = getData(Vs10, getColumIndex(Vs10, "Color"), i)

    '                    W1312.MaterialCode = getData(Vs10, getColumIndex(Vs10, "MaterialCode"), i)
    '                    W1312.MoldCode = getData(Vs10, getColumIndex(Vs10, "cdMoldCode"), i)
    '                    W1312.LastCode = getData(Vs10, getColumIndex(Vs10, "cdLastCode"), i)
    '                    W1312.CuttingDieCode = getData(Vs10, getColumIndex(Vs10, "cdCuttingDieCode"), i)

    '                    W1312.SizeRange = getData(Vs10, getColumIndex(Vs10, "cdSizeRange"), i)
    '                    W1312.SpeciticSize = getData(Vs10, getColumIndex(Vs10, "SpeciticSize"), i)
    '                    W1312.cdUnitMaterial = getData(Vs10, getColumIndex(Vs10, "cdUnitMaterial"), i)
    '                    W1312.cdUnitPacking = getData(Vs10, getColumIndex(Vs10, "cdUnitPacking"), i)

    '                    W1312.SpecNo = getData(Vs10, getColumIndex(Vs10, "SpecNo"), i)
    '                    W1312.SpecNoSeq = getData(Vs10, getColumIndex(Vs10, "SpecNoSeq"), i)

    '                    DATA_MOVE_DEFAULT()

    '                    W1312.RemarkOrder = txt_Remark_Order.Data
    '                    W1312.RemarkCustomer = txt_Remark_Customer.Data

    '                    W1312.OrderDetailStatus = "1"

    '                    Call WRITE_PFK1312(W1312)

    '                    isudCHK = True
    '                End If
    'skip:
    '            Next

    '            DATA_MOVE_WRITE02 = True

    '        Catch ex As Exception
    '            MsgBoxP("DATA_MOVE_WRITE02")
    '        End Try

    '    End Function

    '    Private Function DATA_MOVE_WRITE03() As Boolean
    '        DATA_MOVE_WRITE03 = False
    '        Try
    '            Dim i As Integer
    '            Dim j As Integer

    '            Dim colstart As Integer

    '            j = 0

    '            For XXX As Integer = 0 To Vs20.ActiveSheet.ColumnCount - 1
    '                If getDataCH(Vs20, XXX, 0) <> "" Then
    '                    colstart = XXX
    '                    Exit For
    '                End If
    '            Next

    '            For i = 0 To Vs20.ActiveSheet.RowCount - 1
    '                If Trim(getData(Vs20, getColumIndex(Vs20, "KEY_OrderNo"), i)) = "" Then GoTo skip

    '                j = j + 1

    '                If K1313_MOVE(Vs20, i, W1313, txt_OrderNo.Data, getData(Vs20, getColumIndex(Vs20, "KEY_OrderNoSeq"), i)) = True Then

    '                    W1313.SizeQty01 = CDblp(getData(Vs20, colstart, i))
    '                    W1313.SizeQty02 = CDblp(getData(Vs20, colstart + 1, i))
    '                    W1313.SizeQty03 = CDblp(getData(Vs20, colstart + 2, i))
    '                    W1313.SizeQty04 = CDblp(getData(Vs20, colstart + 3, i))
    '                    W1313.SizeQty05 = CDblp(getData(Vs20, colstart + 4, i))
    '                    W1313.SizeQty06 = CDblp(getData(Vs20, colstart + 5, i))
    '                    W1313.SizeQty07 = CDblp(getData(Vs20, colstart + 6, i))
    '                    W1313.SizeQty08 = CDblp(getData(Vs20, colstart + 7, i))
    '                    W1313.SizeQty09 = CDblp(getData(Vs20, colstart + 8, i))
    '                    W1313.SizeQty10 = CDblp(getData(Vs20, colstart + 9, i))
    '                    W1313.SizeQty11 = CDblp(getData(Vs20, colstart + 10, i))
    '                    W1313.SizeQty12 = CDblp(getData(Vs20, colstart + 11, i))
    '                    W1313.SizeQty13 = CDblp(getData(Vs20, colstart + 12, i))
    '                    W1313.SizeQty14 = CDblp(getData(Vs20, colstart + 13, i))
    '                    W1313.SizeQty15 = CDblp(getData(Vs20, colstart + 14, i))
    '                    W1313.SizeQty16 = CDblp(getData(Vs20, colstart + 15, i))
    '                    W1313.SizeQty17 = CDblp(getData(Vs20, colstart + 16, i))
    '                    W1313.SizeQty18 = CDblp(getData(Vs20, colstart + 17, i))
    '                    W1313.SizeQty19 = CDblp(getData(Vs20, colstart + 18, i))
    '                    W1313.SizeQty20 = CDblp(getData(Vs20, colstart + 19, i))
    '                    W1313.SizeQty21 = CDblp(getData(Vs20, colstart + 20, i))
    '                    W1313.SizeQty22 = CDblp(getData(Vs20, colstart + 21, i))
    '                    W1313.SizeQty23 = CDblp(getData(Vs20, colstart + 22, i))
    '                    W1313.SizeQty24 = CDblp(getData(Vs20, colstart + 23, i))
    '                    W1313.SizeQty25 = CDblp(getData(Vs20, colstart + 24, i))
    '                    W1313.SizeQty26 = CDblp(getData(Vs20, colstart + 25, i))
    '                    W1313.SizeQty27 = CDblp(getData(Vs20, colstart + 26, i))
    '                    W1313.SizeQty28 = CDblp(getData(Vs20, colstart + 27, i))
    '                    W1313.SizeQty29 = CDblp(getData(Vs20, colstart + 28, i))
    '                    W1313.SizeQty30 = CDblp(getData(Vs20, colstart + 29, i))

    '                    Call REWRITE_PFK1313(W1313)
    '                    isudCHK = True

    '                Else

    '                    W1313.OrderNo = L1311.OrderNo
    '                    W1313.OrderNoSeq = getData(Vs20, getColumIndex(Vs20, "KEY_OrderNoSeq"), i)

    '                    W1313.SizeQty01 = CDblp(getData(Vs20, colstart, i))
    '                    W1313.SizeQty02 = CDblp(getData(Vs20, colstart + 1, i))
    '                    W1313.SizeQty03 = CDblp(getData(Vs20, colstart + 2, i))
    '                    W1313.SizeQty04 = CDblp(getData(Vs20, colstart + 3, i))
    '                    W1313.SizeQty05 = CDblp(getData(Vs20, colstart + 4, i))
    '                    W1313.SizeQty06 = CDblp(getData(Vs20, colstart + 5, i))
    '                    W1313.SizeQty07 = CDblp(getData(Vs20, colstart + 6, i))
    '                    W1313.SizeQty08 = CDblp(getData(Vs20, colstart + 7, i))
    '                    W1313.SizeQty09 = CDblp(getData(Vs20, colstart + 8, i))
    '                    W1313.SizeQty10 = CDblp(getData(Vs20, colstart + 9, i))
    '                    W1313.SizeQty11 = CDblp(getData(Vs20, colstart + 10, i))
    '                    W1313.SizeQty12 = CDblp(getData(Vs20, colstart + 11, i))
    '                    W1313.SizeQty13 = CDblp(getData(Vs20, colstart + 12, i))
    '                    W1313.SizeQty14 = CDblp(getData(Vs20, colstart + 13, i))
    '                    W1313.SizeQty15 = CDblp(getData(Vs20, colstart + 14, i))
    '                    W1313.SizeQty16 = CDblp(getData(Vs20, colstart + 15, i))
    '                    W1313.SizeQty17 = CDblp(getData(Vs20, colstart + 16, i))
    '                    W1313.SizeQty18 = CDblp(getData(Vs20, colstart + 17, i))
    '                    W1313.SizeQty19 = CDblp(getData(Vs20, colstart + 18, i))
    '                    W1313.SizeQty20 = CDblp(getData(Vs20, colstart + 19, i))
    '                    W1313.SizeQty21 = CDblp(getData(Vs20, colstart + 20, i))
    '                    W1313.SizeQty22 = CDblp(getData(Vs20, colstart + 21, i))
    '                    W1313.SizeQty23 = CDblp(getData(Vs20, colstart + 22, i))
    '                    W1313.SizeQty24 = CDblp(getData(Vs20, colstart + 23, i))
    '                    W1313.SizeQty25 = CDblp(getData(Vs20, colstart + 24, i))
    '                    W1313.SizeQty26 = CDblp(getData(Vs20, colstart + 25, i))
    '                    W1313.SizeQty27 = CDblp(getData(Vs20, colstart + 26, i))
    '                    W1313.SizeQty28 = CDblp(getData(Vs20, colstart + 27, i))
    '                    W1313.SizeQty29 = CDblp(getData(Vs20, colstart + 28, i))
    '                    W1313.SizeQty30 = CDblp(getData(Vs20, colstart + 29, i))

    '                    Call WRITE_PFK1313(W1313)

    '                    isudCHK = True

    '                End If
    'skip:
    '            Next

    '            DATA_MOVE_WRITE03 = True

    '        Catch ex As Exception
    '            MsgBoxP("DATA_MOVE_WRITE03")
    '        End Try

    '    End Function

    '    Private Function DATA_MOVE_WRITE04() As Boolean
    '        DATA_MOVE_WRITE04 = False
    '        Try
    '            Dim i As Integer
    '            Dim j As Integer

    '            j = 0
    '            For i = 0 To Vs40.ActiveSheet.RowCount - 1
    '                If Trim(getData(Vs41, getColumIndex(Vs41, "KEY_ScheduleID"), i)) = "" Then GoTo skip

    '                j = j + 1

    '                If K1316_MOVE(Vs41, i, W1316, txt_OrderNo.Data, getData(Vs41, getColumIndex(Vs41, "KEY_OrderNoSeq"), i)) = True Then

    '                    W1316.Seq = CDblp(getData(Vs41, getColumIndex(Vs41, "Seq"), i))
    '                    W1316.cdProcessType = (getData(Vs41, getColumIndex(Vs41, "cdProcessType"), i))
    '                    W1316.DateProcess = (getData(Vs41, getColumIndex(Vs41, "DateProcess"), i))
    '                    W1316.DateProcess = (getData(Vs41, getColumIndex(Vs41, "DateSent"), i))
    '                    W1316.DateReceived = (getData(Vs41, getColumIndex(Vs41, "DateReceived"), i))
    '                    W1316.DateReceived = (getData(Vs41, getColumIndex(Vs41, "DateResult"), i))
    '                    W1316.Result = (getData(Vs41, getColumIndex(Vs41, "Result"), i))
    '                    W1316.Comment1 = (getData(Vs41, getColumIndex(Vs41, "Comment1"), i))
    '                    W1316.Comment2 = (getData(Vs41, getColumIndex(Vs41, "Comment2"), i))
    '                    W1316.Comment3 = (getData(Vs41, getColumIndex(Vs41, "Comment3"), i))
    '                    W1316.Comment4 = (getData(Vs41, getColumIndex(Vs41, "Comment4"), i))
    '                    W1316.Comment5 = (getData(Vs41, getColumIndex(Vs41, "Comment5"), i))
    '                    W1316.PructionNote = (getData(Vs41, getColumIndex(Vs41, "PructionNote"), i))

    '                    DATA_MOVE_DEFAULT()

    '                    W1316.Remark = getData(Vs41, getColumIndex(Vs41, "Remark"), i)

    '                    Call REWRITE_PFK1316(W1316)
    '                    isudCHK = True

    '                Else
    '                    W1316.OrderNo = txt_OrderNo.Data
    '                    W1316.OrderNoSeq = getData(Vs41, getColumIndex(Vs41, "KEY_OrderNoSeq"), i)

    '                    W1316.Seq = CDblp(getData(Vs41, getColumIndex(Vs41, "Seq"), i))
    '                    W1316.cdProcessType = (getData(Vs41, getColumIndex(Vs41, "cdProcessType"), i))
    '                    W1316.DateProcess = (getData(Vs41, getColumIndex(Vs41, "DateProcess"), i))
    '                    W1316.DateProcess = (getData(Vs41, getColumIndex(Vs41, "DateSent"), i))
    '                    W1316.DateReceived = (getData(Vs41, getColumIndex(Vs41, "DateReceived"), i))
    '                    W1316.DateReceived = (getData(Vs41, getColumIndex(Vs41, "DateResult"), i))
    '                    W1316.Result = (getData(Vs41, getColumIndex(Vs41, "Result"), i))
    '                    W1316.Comment1 = (getData(Vs41, getColumIndex(Vs41, "Comment1"), i))
    '                    W1316.Comment2 = (getData(Vs41, getColumIndex(Vs41, "Comment2"), i))
    '                    W1316.Comment3 = (getData(Vs41, getColumIndex(Vs41, "Comment3"), i))
    '                    W1316.Comment4 = (getData(Vs41, getColumIndex(Vs41, "Comment4"), i))
    '                    W1316.Comment5 = (getData(Vs41, getColumIndex(Vs41, "Comment5"), i))
    '                    W1316.PructionNote = (getData(Vs41, getColumIndex(Vs41, "PructionNote"), i))

    '                    W1316.Remark = getData(Vs41, getColumIndex(Vs41, "Remark"), i)

    '                    Call WRITE_PFK1316(W1316)

    '                    isudCHK = True
    '                End If
    'skip:
    '            Next

    '            DATA_MOVE_WRITE04 = True
    '        Catch ex As Exception
    '            MsgBoxP("DATA_MOVE_WRITE04")
    '        End Try
    '    End Function

    '    '    Private Function DATA_MOVE_WRITE02() As Boolean
    '    '        DATA_MOVE_WRITE02 = False
    '    '        Try
    '    '            Dim i As Integer
    '    '            Dim j As Integer
    '    '            j = 0
    '    '            For i = 0 To vS2.ActiveSheet.RowCount - 1
    '    '                j = j + 1

    '    '                If K2352_MOVE(vS2, i, W2352, getData(vS2, getColumIndex(vS2, "KEY_MaterialInBoundNo"), i),
    '    '                               getData(vS2, getColumIndex(vS2, "KEY_MaterialInBoundSeq"), i),
    '    '                               getData(vS2, getColumIndex(vS2, "KEY_MaterialInBoundSno"), i)) = True Then

    '    '                    Call REWRITE_PFK2352(W2352)
    '    '                    isudCHK = True
    '    '                Else
    '    '                    W2352.MaterialInBoundNo = getData(vS2, getColumIndex(vS2, "KEY_MaterialInBoundNo"), 0)
    '    '                    W2352.MaterialInBoundSeq = getData(vS2, getColumIndex(vS2, "KEY_MaterialInBoundSeq"), 0)

    '    '                    L2352.MaterialInBoundNo = W2352.MaterialInBoundNo
    '    '                    L2352.MaterialInBoundSeq = W2352.MaterialInBoundSeq

    '    '                    Call KEY_COUNT_2352()
    '    '                    Call WRITE_PFK2352(W2352)
    '    '                    isudCHK = True
    '    '                End If
    '    'skip:

    '    '            Next
    '    '            DATA_MOVE_WRITE02 = True
    '    '        Catch ex As Exception
    '    '            MsgBoxP("DATA_MOVE_WRITE01")
    '    '        End Try
    '    '    End Function

    '    Private Sub DATA_INSERT()
    '        Try
    '            If K1311_MOVE(Me, W1311, 1, L1311.OrderNo) = False Then

    '                Call DATA_MOVE_DEFAULT()

    '                W1311.OrderNo = L1311.OrderNo
    '                W1311.CustPoNo = txt_CustPoNo.Data

    '                If WRITE_PFK1311(W1311) = True Then
    '                    Call DATA_MOVE_WRITE02()
    '                    Call DATA_MOVE_WRITE03()

    '                    isudCHK = True : WRITE_CHK = "*"
    '                    Exit Sub
    '                End If
    '            End If

    '        Catch ex As Exception
    '            MsgBoxP("DATA_INSERT")
    '        End Try

    '    End Sub

    '    Private Sub DATA_UPDATE()
    '        Try
    '            If K1311_MOVE(Me, W1311, 3, L1311.OrderNo) = True Then

    '                Call DATA_MOVE_DEFAULT()

    '                W1311.OrderNo = L1311.OrderNo

    '                If REWRITE_PFK1311(W1311) = True Then
    '                    Call DATA_MOVE_WRITE02()
    '                    Call DATA_MOVE_WRITE03()

    '                    ' DATA_MOVE_WRITE02()

    '                    isudCHK = True : WRITE_CHK = "*"
    '                    Exit Sub
    '                End If
    '            End If

    '        Catch ex As Exception
    '            Call MsgBoxP("35", "DATA_UPDATE")
    '        End Try
    '    End Sub

    '    Private Sub DATA_DELETE()
    '        Try
    '            If DELETE_T1316() = False Then Exit Sub

    '            If DELETE_T1315() = False Then Exit Sub

    '            If DELETE_T1314() = False Then Exit Sub

    '            If DELETE_T1313() = False Then Exit Sub

    '            If DELETE_T1312() = False Then Exit Sub

    '            If READ_PFK1311(L1311.OrderNo) = True Then
    '                W1311 = D1311
    '                DELETE_PFK1311(W1311)

    '                isudCHK = True : Me.Dispose() : Exit Sub

    '            End If

    '        Catch ex As Exception
    '            Call MsgBoxP("38", "DATA_DELETE")
    '        End Try

    '    End Sub


    '    Private Function DELETE_T1312() As Boolean
    '        DELETE_T1312 = False
    '        Dim DSNEW As New DataSet
    '        Try
    '            DSNEW = READ_PFK1312_ORDERNO(L1311.OrderNo, cn)
    '            For Each Row As DataRow In DSNEW.Tables(0).Rows
    '                If READ_PFK1312(Row!K1312_OrderNo, Row!K1312_OrderNoSeq) = True Then
    '                    W1312 = D1312
    '                    DELETE_PFK1312(W1312)
    '                End If
    '            Next
    '            If GetDsRc(READ_PFK1312_ORDERNO(L1311.OrderNo, cn)) = 0 Then DELETE_T1312 = True
    '        Catch ex As Exception

    '        End Try
    '    End Function

    '    Private Function DELETE_T1313() As Boolean
    '        DELETE_T1313 = False
    '        Dim DSNEW As New DataSet
    '        Try
    '            DSNEW = READ_PFK1313_ORDERNO(L1311.OrderNo, cn)
    '            For Each Row As DataRow In DSNEW.Tables(0).Rows
    '                If READ_PFK1313(Row!K1313_OrderNo, Row!K1313_OrderNoSeq) = True Then
    '                    W1313 = D1313
    '                    DELETE_PFK1313(W1313)
    '                End If
    '            Next
    '            If GetDsRc(READ_PFK1313_ORDERNO(L1311.OrderNo, cn)) = 0 Then DELETE_T1313 = True
    '        Catch ex As Exception

    '        End Try
    '    End Function

    '    Private Function DELETE_T1314() As Boolean
    '        DELETE_T1314 = False
    '        Dim DSNEW As New DataSet
    '        Try
    '            DSNEW = READ_PFK1314_ORDERNO(L1311.OrderNo, cn)
    '            For Each Row As DataRow In DSNEW.Tables(0).Rows
    '                If READ_PFK1314(Row!K1314_OrderNo, Row!K1314_OrderNoSeq, Row!K1314_ProcessOrder) = True Then
    '                    W1314 = D1314
    '                    DELETE_PFK1314(W1314)
    '                End If
    '            Next
    '            If GetDsRc(READ_PFK1314_ORDERNO(L1311.OrderNo, cn)) = 0 Then DELETE_T1314 = True
    '        Catch ex As Exception

    '        End Try
    '    End Function


    '    Private Function DELETE_T1315() As Boolean
    '        DELETE_T1315 = False
    '        Dim DSNEW As New DataSet
    '        Try
    '            DSNEW = READ_PFK1315_ORDERNO(L1311.OrderNo, cn)
    '            For Each Row As DataRow In DSNEW.Tables(0).Rows
    '                If READ_PFK1315(Row!K1315_OrderNo, Row!K1315_OrderNoSeq) = True Then
    '                    W1315 = D1315
    '                    DELETE_PFK1315(W1315)
    '                End If
    '            Next
    '            If GetDsRc(READ_PFK1315_ORDERNO(L1311.OrderNo, cn)) = 0 Then DELETE_T1315 = True
    '        Catch ex As Exception

    '        End Try
    '    End Function

    '    Private Function DELETE_T1316() As Boolean
    '        DELETE_T1316 = False
    '        Dim DSNEW As New DataSet
    '        Try
    '            DSNEW = READ_PFK1316_ORDERNO(L1316.OrderNo, cn)
    '            For Each Row As DataRow In DSNEW.Tables(0).Rows
    '                If READ_PFK1316(Row!K1316_ScheduleID) = True Then
    '                    W1316 = D1316
    '                    DELETE_PFK1316(W1316)
    '                End If
    '            Next
    '            If GetDsRc(READ_PFK1316_ORDERNO(L1311.OrderNo, cn)) = 0 Then DELETE_T1316 = True
    '        Catch ex As Exception

    '        End Try
    '    End Function


    '    Private Sub KEY_COUNT_PFK1312()
    '        Try
    '            SQL = "SELECT MAX(CAST(K1312_OrderNoSeq AS DECIMAL)) AS MAX_MCODE FROM PFK1312 "
    '            SQL = SQL & " WHERE K1312_OrderNo = '" & txt_OrderNo.Data & "' "
    '            cmd = New SqlClient.SqlCommand(SQL, cn)
    '            rd = cmd.ExecuteReader
    '            rd.Read()

    '            If IsDBNull(rd!MAX_MCODE) Then
    '                W1312.OrderNoSeq = "001"
    '            Else
    '                W1312.OrderNoSeq = CIntp(rd!MAX_MCODE + 1).ToString("000")
    '            End If

    '            rd.Close()

    '            L1312.OrderNoSeq = W1312.OrderNoSeq

    '        Catch ex As Exception
    '            Call MsgBoxP("35", "KEY_COUNT_PFK1312")
    '        End Try
    '    End Sub

    '    Private Sub KEY_COUNT_PFK1316()
    '        Try
    '            SQL = "SELECT MAX(CAST(K1316_OrderNoSeq AS DECIMAL)) AS MAX_MCODE FROM PFK1316 "
    '            SQL = SQL & " WHERE K1316_OrderNo = '" & txt_OrderNo.Data & "' "
    '            cmd = New SqlClient.SqlCommand(SQL, cn)
    '            rd = cmd.ExecuteReader
    '            rd.Read()

    '            If IsDBNull(rd!MAX_MCODE) Then
    '                W1316.OrderNoSeq = "001"
    '            Else
    '                W1316.OrderNoSeq = CIntp(rd!MAX_MCODE + 1).ToString("000")
    '            End If

    '            rd.Close()

    '            L1312.OrderNoSeq = W1312.OrderNoSeq

    '        Catch ex As Exception
    '            Call MsgBoxP("35", "KEY_COUNT_PFK1312")
    '        End Try
    '    End Sub

    '    Private Sub KEY_COUNT()

    '        Dim YRNO As Integer
    '        YRNO = Mid(System_Date_8(), 3, 4)

    '        Try
    '            SQL = "SELECT MAX(CAST(SUBSTRING(K1311_OrderNo,7,3) AS DECIMAL)) AS MAX_MCODE FROM PFK1311 "
    '            SQL = SQL & " WHERE SUBSTRING(K1311_OrderNo,3,4) = '" & YRNO.ToString & "' "
    '            cmd = New SqlClient.SqlCommand(SQL, cn)
    '            rd = cmd.ExecuteReader
    '            rd.Read()

    '            If IsDBNull(rd!MAX_MCODE) Then
    '                W1311.OrderNo = "SO" & YRNO & "001"
    '            Else
    '                W1311.OrderNo = "SO" & YRNO & Format(CInt(rd!MAX_MCODE + 1), "000")
    '            End If

    '            rd.Close()

    '            txt_OrderNo.Data = W1311.OrderNo
    '            L1311.OrderNo = W1311.OrderNo

    '        Catch ex As Exception
    '            Call MsgBoxP("35", "KEY_COUNT")
    '        End Try
    '    End Sub

    '    '    Private Sub vS2_DATA_INSERT(xrow As Integer)
    '    '        Try
    '    '            setData(vS2, getColumIndex(vS2, "KEY_MaterialInBoundNo"), xrow, getData(vS2, getColumIndex(vS2, "KEY_MaterialInBoundNo"), 0))
    '    '            setData(vS2, getColumIndex(vS2, "KEY_MaterialInBoundSeq"), xrow, getData(vS2, getColumIndex(vS2, "KEY_MaterialInBoundSeq"), 0))
    '    '            setData(vS2, getColumIndex(vS2, "KEY_MaterialInBoundSno"), xrow, getData(vS2, getColumIndex(vS2, "KEY_MaterialInBoundSno"), 0))
    '    '            setData(vS2, getColumIndex(vS2, "GydFabric"), xrow, 0)
    '    '            setData(vS2, getColumIndex(vS2, "Grm2Fabric"), xrow, 0)
    '    '            setData(vS2, getColumIndex(vS2, "RollInboundFabric"), xrow, 1)
    '    '            setData(vS2, getColumIndex(vS2, "YdsInboundFabric"), xrow, 0)

    '    '        Catch ex As Exception

    '    '        End Try

    '    '    End Sub

    '#End Region

    '#Region "Event"

    '    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
    '        Select Case wJOB
    '            Case 1
    '                If DataCheck(Me, "PFK1311") = False Then Exit Sub

    '                Call DATA_INSERT()
    '                Me.Dispose()
    '            Case 2
    '                Me.Dispose()
    '            Case 3
    '                If DataCheck(Me, "PFK1311") = False Then Exit Sub

    '                Call DATA_UPDATE()
    '            Case 4
    '                ' Call DATA_DELETE()
    '                Me.Dispose()

    '        End Select
    '    End Sub

    '    Private Sub cmd_CANCEL_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
    '        If WRITE_CHK = "*" Then
    '            isudCHK = True
    '        Else
    '            isudCHK = False
    '        End If

    '        Me.Dispose()
    '    End Sub

    '    Private Sub cmd_DEL_Click(sender As Object, e As EventArgs) Handles cmd_DEL.Click
    '        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

    '        If CHK(4) <> "1" Then
    '            Call MsgBoxP("4", "cmd_DEL_Click")
    '            Exit Sub
    '        End If

    '        Dim str As String = MsgBoxP("Do you want to delete it?", vbYesNo)

    '        If str <> vbYes Then Exit Sub
    '        Try
    '            Call DATA_DELETE()
    '        Catch ex As Exception

    '        End Try

    '    End Sub

    '    '    Private Sub Vs1_ButtonClicked(sender As Object, e As EditorNotifyEventArgs) Handles Vs1.ButtonClicked
    '    '        Dim xrow As Integer
    '    '        xrow = e.Row

    '    '        Select Case e.Column
    '    '            Case getColumIndex(Vs1, "MaterialCode")
    '    '                'Later    Dim f As New Form
    '    '                'f = New HLP3131A
    '    '                'f.ShowDialog()

    '    '                'If hlp0000SeVaTt = "" Or hlp0000SeVa = "" Then Exit Sub

    '    '                'setData(Vs1, getColumIndex(Vs1, "RequestPurchasingNo"), xrow, D3132.RequestPurchasingNo)
    '    '                'setData(Vs1, getColumIndex(Vs1, "RequestPurchasingSeq"), xrow, D3132.RequestPurchasingSeq)

    '    '                'If READ_PFK3132(D3132.RequestPurchasingNo, D3132.RequestPurchasingSeq) = True Then
    '    '                '    setData(Vs1, getColumIndex(Vs1, "MaterialCode"), xrow, D3132.MaterialCode)
    '    '                'End If

    '    '                'setData(Vs1, getColumIndex(Vs1, "cdUnitPriceMaterial"), xrow, "001")
    '    '                'setData(Vs1, getColumIndex(Vs1, "cdUnitPriceMaterialName"), xrow, "USD")

    '    '            Case getColumIndex(Vs1, "cdUnitPriceMaterial")
    '    '                Call HLPCHECK("Const_UnitPrice")

    '    '                If hlp0000SeVa = "" Or hlp0000SeVaTt = "" Then Exit Sub
    '    '                setData(Vs1, getColumIndex(Vs1, "cdUnitPriceMaterial"), xrow, hlp0000SeVaTt)
    '    '                setData(Vs1, getColumIndex(Vs1, "cdUnitPriceMaterialName"), xrow, hlp0000SeVa)

    '    '                setData(Vs1, getColumIndex(Vs1, "TaxImport"), xrow, ImportTax)
    '    '                setData(Vs1, getColumIndex(Vs1, "TaxVat"), xrow, VatTax)

    '    '        End Select

    '    '        vSChange(e.Row)

    '    '    End Sub
    '    '    Private Sub Vs1_Change(sender As Object, e As ChangeEventArgs) Handles Vs1.Change
    '    '        Dim xCOL As Long
    '    '        Dim xROW As Long

    '    '        Try

    '    '            xROW = e.Row
    '    '            xCOL = e.Column

    '    '            vSChange(xROW)

    '    '        Catch ex As Exception

    '    '        End Try

    '    '    End Sub

    '    '    Private Sub vSChange(xROW As Integer)
    '    '        Try
    '    '            Dim TaxImport As Decimal
    '    '            Dim TaxVat As Decimal

    '    '            Dim AmountTaxImport As Decimal
    '    '            Dim AmountTaxVat As Decimal

    '    '            Dim AmountPurchasingUSD As Decimal
    '    '            Dim AmountPurchasingVND As Decimal
    '    '            Dim PricePurchasingUSD As Decimal
    '    '            Dim PricePurchasingVND As Decimal

    '    '            Dim AmountInboundFabricUSD As Decimal
    '    '            Dim AmountInboundFabricVND As Decimal

    '    '            Dim PriceExchange As Decimal
    '    '            Dim PriceMaterial As Decimal
    '    '            Dim cdUnitPriceMaterialName As String
    '    '            Dim cdUnitFabricName As Decimal

    '    '            Dim PackInBound As Decimal
    '    '            Dim QtyInBound As Decimal

    '    '            PriceExchange = CDecp(txt_PriceExchange.Data)
    '    '            PriceMaterial = CDecp(getData(Vs1, getColumIndex(Vs1, "PriceMaterial"), xROW))

    '    '            PackInBound = CDecp(getData(Vs1, getColumIndex(Vs1, "PackInBound"), xROW))
    '    '            QtyInBound = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyInBound"), xROW))

    '    '            cdUnitFabricName = 1
    '    '            If getData(Vs1, getColumIndex(Vs1, "cdUnitPriceMaterialName"), xROW) = "" Then Exit Sub
    '    '            cdUnitPriceMaterialName = getData(Vs1, getColumIndex(Vs1, "cdUnitPriceMaterialName"), xROW).ToString.ToUpper 'USD OR VND

    '    '            TaxImport = CDecp(getData(Vs1, getColumIndex(Vs1, "TaxImport"), xROW))
    '    '            TaxVat = CDecp(getData(Vs1, getColumIndex(Vs1, "TaxVat"), xROW))

    '    '            If PriceExchange >= 0 And PriceMaterial >= 0 And QtyInBound >= 0 Then
    '    '                If cdUnitPriceMaterialName = "USD" Then
    '    '                    AmountPurchasingUSD = PriceMaterial * QtyInBound
    '    '                    If PriceExchange > 0 Then AmountPurchasingVND = PriceMaterial * PriceExchange * QtyInBound

    '    '                    AmountTaxImport = TaxImport * AmountPurchasingVND

    '    '                    AmountInboundFabricVND = AmountPurchasingVND + AmountTaxImport
    '    '                    AmountTaxVat = TaxVat * AmountInboundFabricVND

    '    '                    AmountInboundFabricVND = AmountInboundFabricVND + AmountTaxVat
    '    '                    If PriceExchange > 0 Then AmountInboundFabricUSD = AmountInboundFabricVND / PriceExchange

    '    '                    If QtyInBound > 0 Then PricePurchasingVND = (AmountInboundFabricVND - AmountTaxVat) / QtyInBound
    '    '                    If QtyInBound > 0 Then PricePurchasingUSD = AmountInboundFabricUSD / QtyInBound

    '    '                    setData(Vs1, getColumIndex(Vs1, "TaxImport"), xROW, TaxImport)
    '    '                    setData(Vs1, getColumIndex(Vs1, "TaxVat"), xROW, TaxVat)

    '    '                    setData(Vs1, getColumIndex(Vs1, "QtyInBound"), xROW, QtyInBound)

    '    '                    setData(Vs1, getColumIndex(Vs1, "AmountPurchasingUSD"), xROW, AmountPurchasingUSD)
    '    '                    setData(Vs1, getColumIndex(Vs1, "AmountPurchasingVND"), xROW, AmountPurchasingVND)
    '    '                    setData(Vs1, getColumIndex(Vs1, "AmountTaxImport"), xROW, AmountTaxImport)
    '    '                    setData(Vs1, getColumIndex(Vs1, "AmountTaxVat"), xROW, AmountTaxVat)
    '    '                    setData(Vs1, getColumIndex(Vs1, "AmountInboundFabricVND"), xROW, AmountInboundFabricVND)
    '    '                    setData(Vs1, getColumIndex(Vs1, "AmountInboundFabricUSD"), xROW, AmountInboundFabricUSD)
    '    '                    setData(Vs1, getColumIndex(Vs1, "PricePurchasingVND"), xROW, PricePurchasingVND)
    '    '                    setData(Vs1, getColumIndex(Vs1, "PricePurchasingUSD"), xROW, PricePurchasingUSD)

    '    '                ElseIf cdUnitPriceMaterialName = "VND" Then
    '    '                    AmountPurchasingVND = PriceMaterial * QtyInBound
    '    '                    If PriceExchange > 0 Then AmountPurchasingUSD = PriceMaterial / PriceExchange * QtyInBound
    '    '                    AmountTaxImport = TaxImport * AmountPurchasingVND

    '    '                    AmountInboundFabricVND = AmountPurchasingVND + AmountTaxImport
    '    '                    AmountTaxVat = TaxVat * AmountInboundFabricVND

    '    '                    AmountInboundFabricVND = AmountInboundFabricVND + AmountTaxVat
    '    '                    If PriceExchange > 0 Then AmountInboundFabricUSD = AmountInboundFabricVND / PriceExchange

    '    '                    If QtyInBound > 0 Then PricePurchasingVND = (AmountInboundFabricVND - AmountTaxVat) / QtyInBound
    '    '                    If QtyInBound > 0 Then PricePurchasingUSD = AmountInboundFabricUSD / QtyInBound

    '    '                    setData(Vs1, getColumIndex(Vs1, "TaxImport"), xROW, TaxImport)
    '    '                    setData(Vs1, getColumIndex(Vs1, "TaxVat"), xROW, TaxVat)

    '    '                    setData(Vs1, getColumIndex(Vs1, "QtyInBound"), xROW, QtyInBound)

    '    '                    setData(Vs1, getColumIndex(Vs1, "AmountPurchasingUSD"), xROW, AmountPurchasingUSD)
    '    '                    setData(Vs1, getColumIndex(Vs1, "AmountPurchasingVND"), xROW, AmountPurchasingVND)
    '    '                    setData(Vs1, getColumIndex(Vs1, "AmountTaxImport"), xROW, AmountTaxImport)
    '    '                    setData(Vs1, getColumIndex(Vs1, "AmountTaxVat"), xROW, AmountTaxVat)
    '    '                    setData(Vs1, getColumIndex(Vs1, "AmountInboundFabricVND"), xROW, AmountInboundFabricVND)
    '    '                    setData(Vs1, getColumIndex(Vs1, "AmountInboundFabricUSD"), xROW, AmountInboundFabricUSD)
    '    '                    setData(Vs1, getColumIndex(Vs1, "PricePurchasingVND"), xROW, PricePurchasingVND)
    '    '                    setData(Vs1, getColumIndex(Vs1, "PricePurchasingUSD"), xROW, PricePurchasingUSD)

    '    '                End If
    '    '            End If

    '    '        Catch ex As Exception
    '    '            MsgBoxP("vSChange")
    '    '        End Try
    '    '    End Sub

    '    '    Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellClick
    '    '        Vs1.ActiveSheet.ActiveRowIndex = e.Row
    '    '        Vs1.ActiveSheet.ActiveColumnIndex = e.Column
    '    '    End Sub

    '    '    Private Sub Vs1_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellDoubleClick
    '    '        Call DATA_SEARCH_vS20()
    '    '    End Sub

    '    Private Sub ptc_Main_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ptc_Main.SelectedIndexChanged
    '        Try
    '            Select Case True
    '                Case ptc_Main.SelectedIndex = 0
    '                    Call DATA_SEARCH_vS10()

    '                Case ptc_Main.SelectedIndex = 1
    '                    Call DATA_SEARCH_vS20()

    '                Case ptc_Main.SelectedIndex = 2
    '                    Call DATA_SEARCH_vS30()
    '                    If txt_OrderNo.Data <> "" Then Call DATA_SEARCH03(txt_OrderNo.Data)
    '                    ptc_Sub1.SelectedIndex = 0

    '                Case ptc_Main.SelectedIndex = 3
    '                    Call DATA_SEARCH_vS40()

    '                Case ptc_Main.SelectedIndex = 4
    '                    Call DATA_SEARCH_vS50()

    '            End Select
    '        Catch ex As Exception
    '            MsgBoxP("ptc_Main_SelectedIndexChanged")
    '        End Try
    '    End Sub


    '    Private Sub ptc_Sub1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ptc_Sub1.SelectedIndexChanged
    '        Try
    '            Select Case True
    '                Case ptc_Sub1.SelectedIndex = 0
    '                    ' Call DATA_SEARCH_vS31()
    '                Case ptc_Sub1.SelectedIndex = 1
    '                    'Call DATA_SEARCH_vS32()
    '                Case ptc_Sub1.SelectedIndex = 2

    '                Case ptc_Sub1.SelectedIndex = 3

    '            End Select
    '        Catch ex As Exception
    '            MsgBoxP("ptc_Sub1_SelectedIndexChanged")
    '        End Try
    '    End Sub


    '    Private Sub Vs10_ButtonClicked(sender As Object, e As EditorNotifyEventArgs) Handles Vs10.ButtonClicked
    '        Try
    '            Vs10.ActiveSheet.ActiveRowIndex = e.Row
    '            Vs10.ActiveSheet.ActiveColumnIndex = e.Column
    '            Select Case e.Column
    '                Case getColumIndex(Vs10, "cdSpecNo")
    '                    Dim f As New Form
    '                    f = New HLP0102A
    '                    f.ShowDialog()

    '                    If hlp0000SeVaTt = "" Or hlp0000SeVa = "" Then Exit Sub

    '                    If READ_PFK0102(hlp0000SeVaTt, hlp0000SeVa) Then
    '                        W0102 = D0102
    '                        setData(Vs10, getColumIndex(Vs10, "cdSpecNo") + 1, Vs10.ActiveSheet.ActiveRowIndex, W0102.SpecNo)
    '                        setData(Vs10, getColumIndex(Vs10, "cdSpecNo") + 2, Vs10.ActiveSheet.ActiveRowIndex, W0102.SpecNoSeq)
    '                    End If

    '                Case getColumIndex(Vs10, "CLcdMoldCode")
    '                    If HLP7156A.Link_HLP7156A("002") = False Then Exit Sub
    '                    If READ_PFK7156(hlp0000SeVaTt) Then
    '                        W7156 = D7156
    '                        setData(Vs10, getColumIndex(Vs10, "CLcdMoldCode") + 1, Vs10.ActiveSheet.ActiveRowIndex, W7156.ToolCode)
    '                        setData(Vs10, getColumIndex(Vs10, "CLcdMoldCode") + 2, Vs10.ActiveSheet.ActiveRowIndex, W7156.ToolName)
    '                    End If

    '                Case getColumIndex(Vs10, "CLcdLastCode")
    '                    If HLP7156A.Link_HLP7156A("001") = False Then Exit Sub
    '                    If READ_PFK7156(hlp0000SeVaTt) Then
    '                        W7156 = D7156
    '                        setData(Vs10, getColumIndex(Vs10, "CLcdLastCode") + 1, Vs10.ActiveSheet.ActiveRowIndex, W7156.ToolCode)
    '                        setData(Vs10, getColumIndex(Vs10, "CLcdLastCode") + 2, Vs10.ActiveSheet.ActiveRowIndex, W7156.ToolName)
    '                    End If

    '                Case getColumIndex(Vs10, "CLcdCuttingDieCode")
    '                    If HLP7156A.Link_HLP7156A("003") = False Then Exit Sub
    '                    If READ_PFK7156(hlp0000SeVaTt) Then
    '                        W7156 = D7156
    '                        setData(Vs10, getColumIndex(Vs10, "CLcdCuttingDieCode") + 1, Vs10.ActiveSheet.ActiveRowIndex, W7156.ToolCode)
    '                        setData(Vs10, getColumIndex(Vs10, "CLcdCuttingDieCode") + 2, Vs10.ActiveSheet.ActiveRowIndex, W7156.ToolName)
    '                    End If

    '                Case getColumIndex(Vs10, "CLcdSizeRange")
    '                    Dim f As New Form
    '                    f = New HLP7104C
    '                    f.ShowDialog()

    '                    If hlp0000SeVaTt = "" Or hlp0000SeVa = "" Then Exit Sub
    '                    If READ_PFK7104(hlp0000SeVaTt) Then
    '                        W7104 = D7104
    '                        setData(Vs10, getColumIndex(Vs10, "CLcdSizeRange") + 1, Vs10.ActiveSheet.ActiveRowIndex, W7104.SizeRange)
    '                        setData(Vs10, getColumIndex(Vs10, "CLcdSizeRange") + 2, Vs10.ActiveSheet.ActiveRowIndex, W7104.SizeRangeName)
    '                    End If

    '            End Select
    '        Catch ex As Exception
    '            MsgBoxP("Vs10_ButtonClicked")
    '        End Try
    '    End Sub

    '    Private Sub Vs30_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs30.CellDoubleClick
    '        Dim xRow As Integer
    '        Dim OrderNo As String
    '        Dim OrderNoSeq As String

    '        Dim SpecNo As String
    '        Dim SpecNoSeq As String

    '        Try
    '            xRow = Vs30.ActiveSheet.ActiveRowIndex
    '            OrderNo = getData(Vs30, getColumIndex(Vs30, "KEY_OrderNo"), xRow)
    '            OrderNoSeq = getData(Vs30, getColumIndex(Vs30, "KEY_OrderNoSeq"), xRow)

    '            SpecNo = getData(Vs30, getColumIndex(Vs30, "KEY_SpecNo"), xRow)
    '            SpecNoSeq = getData(Vs30, getColumIndex(Vs30, "KEY_SpecNoSeq"), xRow)

    '            Select Case ptc_Sub1.SelectedIndex
    '                Case 0
    '                    DATA_SEARCH02(SpecNo, SpecNoSeq)
    '                    DATA_SEARCH_vS31(SpecNo, SpecNoSeq)
    '                Case 1
    '                    DATA_SEARCH_vS32(SpecNo, SpecNoSeq)
    '                Case 2
    '                    DATA_SEARCH_vS33(SpecNo, SpecNoSeq)
    '                Case 3
    '                    Select Case ptc_Sub1.SelectedIndex
    '                        Case 0
    '                            DATA_SEARCH_vS34(SpecNo, SpecNoSeq)
    '                        Case 1
    '                            DATA_SEARCH_vS35(SpecNo, SpecNoSeq)
    '                        Case 2
    '                            DATA_SEARCH_vS36(SpecNo, SpecNoSeq)
    '                    End Select

    '                Case 4
    '                    DATA_SEARCH_vS37(SpecNo, SpecNoSeq)

    '            End Select

    '        Catch ex As Exception
    '            Call MsgBoxP("Vs30_CellDoubleClick")
    '        End Try
    '    End Sub

    '    Private Sub vS10_KeyDown(sender As Object, e As KeyEventArgs) Handles Vs10.KeyDown
    '        If wJOB = 2 Then Exit Sub
    '        Dim xCOL As Long
    '        Dim xROW As Long

    '        xCOL = Vs10.ActiveSheet.ActiveColumnIndex
    '        xROW = Vs10.ActiveSheet.ActiveRowIndex
    '        Try

    '            Select Case e.KeyCode
    '                Case Keys.Insert

    '                    'If xROW = sender.ActiveSheet.RowCount - 1 Then
    '                    '    Vs10.ActiveSheet.RowCount += 1
    '                    '    Vs10.ActiveSheet.ActiveRowIndex = xROW + 1
    '                    'Else
    '                    '    Vs10.ActiveSheet.AddRows(xROW + 1, 1)
    '                    'End If

    '                Case Keys.Delete

    '                    Msg_Result = MsgBoxP("Do you want to delete?", vbYesNo)

    '                    If Msg_Result <> vbYes Then Exit Sub

    '                    If K1312_MOVE(Vs10, xROW, W1312, txt_OrderNo.Data, getData(Vs10, getColumIndex(Vs10, "KEY_OrderNoSeq"), xROW)) = False Then Exit Sub

    '                    W1312 = D1312
    '                    If W1312.OrderDetailStatus = "1" Then

    '                        If READ_PFK1313(W1312.OrderNo, W1312.OrderNoSeq) = True Then
    '                            W1313 = D1313
    '                            DELETE_PFK1313(W1313)
    '                        End If

    '                        Dim dsnew As New DataSet
    '                        dsnew = READ_PFK1314_ORDERNOSEQ(W1312.OrderNo, W1312.OrderNoSeq, cn)
    '                        If GetDsRc(dsnew) > 0 Then
    '                            For Each row As DataRow In dsnew.Tables(0).Rows
    '                                If READ_PFK1314(row!K1314_OrderNo, row!K1314_OrderNoSeq, row!K1314_ProcessOrder) Then
    '                                    W1314 = D1314
    '                                    DELETE_PFK1314(W1314)
    '                                End If
    '                            Next

    '                        End If

    '                        If READ_PFK1315(W1312.OrderNo, W1312.OrderNoSeq) = True Then
    '                            W1315 = D1315
    '                            DELETE_PFK1315(W1315)
    '                        End If

    '                        Dim dsnew1 As New DataSet
    '                        dsnew1 = READ_PFK1316_ORDERNOSEQ(W1312.OrderNo, W1312.OrderNoSeq, cn)
    '                        If GetDsRc(dsnew1) > 0 Then
    '                            For Each row As DataRow In dsnew.Tables(0).Rows
    '                                If READ_PFK1316(row!K1316_ScheduleID) Then
    '                                    W1316 = D1316
    '                                    DELETE_PFK1316(W1316)
    '                                End If
    '                            Next
    '                        End If

    '                        If READ_PFK1313(W1312.OrderNo, W1312.OrderNoSeq) = True Then Exit Sub
    '                        If GetDsRc(READ_PFK1314_ORDERNOSEQ(W1312.OrderNo, W1312.OrderNoSeq, cn)) > 0 Then Exit Sub

    '                        If READ_PFK1315(W1312.OrderNo, W1312.OrderNoSeq) = True Then Exit Sub
    '                        If GetDsRc(READ_PFK1316_ORDERNOSEQ(W1312.OrderNo, W1312.OrderNoSeq, cn)) > 0 Then Exit Sub

    '                        DELETE_PFK1312(W1312)
    '                    Else
    '                        MsgBoxP("Data Already") : Exit Sub
    '                    End If

    '                    SPR_DEL(Vs10, 0, Vs10.ActiveSheet.ActiveRowIndex)
    '                    Vs10.Focus()

    '                Case Keys.Enter
    '                    Select Case xCOL
    '                        Case getColumIndex(Vs10, "MaterialCode")
    '                            Dim f As New Form

    '                    End Select

    '            End Select

    '        Catch ex As Exception
    '            Call MsgBoxP("vS10_KeyDown")
    '        End Try
    '    End Sub

    '    Private Sub Vs20_KeyDown(sender As Object, e As KeyEventArgs) Handles Vs20.KeyDown
    '        If wJOB = 2 Then Exit Sub
    '        Dim xCOL As Long
    '        Dim xROW As Long

    '        xCOL = Vs20.ActiveSheet.ActiveColumnIndex
    '        xROW = Vs20.ActiveSheet.ActiveRowIndex
    '        Try

    '            Select Case e.KeyCode
    '                Case Keys.Insert

    '                    If xROW = sender.ActiveSheet.RowCount - 1 Then
    '                        Vs20.ActiveSheet.RowCount += 1
    '                        Vs20.ActiveSheet.ActiveRowIndex = xROW + 1
    '                    Else
    '                        Vs20.ActiveSheet.AddRows(xROW + 1, 1)
    '                    End If

    '                Case Keys.Delete

    '                    Msg_Result = MsgBoxP("Do you want to delete?", vbYesNo)

    '                    If Msg_Result <> vbYes Then Exit Sub

    '                    If K1313_MOVE(Vs20, xROW, W1313, txt_OrderNo.Data, getData(Vs20, getColumIndex(Vs20, "KEY_OrderNoSeq"), xROW)) = False Then Exit Sub

    '                    W1313 = D1313

    '                    If CheckAprroval(W1313.OrderNo, W1313.OrderNoSeq) = True Then
    '                        DELETE_PFK1313(W1313)
    '                    Else
    '                        MsgBoxP("Data Already") : Exit Sub
    '                    End If

    '                    SPR_DEL(Vs20, 0, Vs20.ActiveSheet.ActiveRowIndex)
    '                    Vs20.Focus()

    '                Case Keys.Enter
    '                    Select Case xCOL
    '                        Case getColumIndex(Vs10, "MaterialCode")
    '                            Dim f As New Form

    '                    End Select

    '            End Select

    '        Catch ex As Exception
    '            Call MsgBoxP("vS10_KeyDown")
    '        End Try
    '    End Sub

    '    Private Sub Vs41_KeyDown(sender As Object, e As KeyEventArgs) Handles Vs41.KeyDown
    '        If wJOB = 2 Then Exit Sub
    '        Dim xCOL As Long
    '        Dim xROW As Long

    '        xCOL = Vs41.ActiveSheet.ActiveColumnIndex
    '        xROW = Vs41.ActiveSheet.ActiveRowIndex
    '        Try

    '            Select Case e.KeyCode
    '                Case Keys.Insert

    '                    If xROW = sender.ActiveSheet.RowCount - 1 Then
    '                        Vs41.ActiveSheet.RowCount += 1
    '                        Vs41.ActiveSheet.ActiveRowIndex = xROW + 1
    '                    Else
    '                        Vs41.ActiveSheet.AddRows(xROW + 1, 1)
    '                    End If

    '                Case Keys.Delete

    '                    Msg_Result = MsgBoxP("Do you want to delete?", vbYesNo)

    '                    If Msg_Result <> vbYes Then Exit Sub

    '                    If K1316_MOVE(Vs41, xROW, W1316, getData(Vs41, getColumIndex(Vs41, "KEY_ScheduleID"), xROW)) = False Then Exit Sub

    '                    W1316 = D1316

    '                    If CheckAprroval(W1316.OrderNo, W1316.OrderNoSeq) = True Then
    '                        DELETE_PFK1316(W1316)
    '                    Else
    '                        MsgBoxP("Data Already") : Exit Sub
    '                    End If

    '                    SPR_DEL(Vs41, 0, Vs41.ActiveSheet.ActiveRowIndex)
    '                    Vs41.Focus()

    '                Case Keys.Enter
    '                    Select Case xCOL
    '                        Case getColumIndex(Vs10, "MaterialCode")
    '                            Dim f As New Form

    '                    End Select

    '            End Select

    '        Catch ex As Exception
    '            Call MsgBoxP("vS10_KeyDown")
    '        End Try
    '    End Sub

    '    Private Function CheckAprroval(OrderNo As String, OrderNoSeq As String) As Boolean
    '        CheckAprroval = False
    '        Try
    '            If READ_PFK1312(OrderNo, OrderNoSeq) = True Then
    '                W1312 = D1312
    '                If W1312.OrderDetailStatus = "1" Then CheckAprroval = True Else CheckAprroval = False
    '            End If
    '        Catch ex As Exception

    '        End Try
    '    End Function

    '    Private Sub Vs40_CellClick(sender As Object, e As CellClickEventArgs)
    '        Dim xRow As Integer
    '        Dim OrderNo As String
    '        Dim OrderNoSeq As String
    '        Try
    '            xRow = Vs40.ActiveSheet.ActiveRowIndex
    '            OrderNo = getData(Vs40, getColumIndex(Vs40, "KEY_OrderNo"), xRow)
    '            OrderNoSeq = getData(Vs40, getColumIndex(Vs40, "KEY_OrderNoSeq"), xRow)

    '            Call DATA_SEARCH_vS41(OrderNo, OrderNoSeq)
    '        Catch ex As Exception
    '            MsgBoxP("Vs40_CellClick")
    '        End Try
    '    End Sub

    '#End Region


End Class