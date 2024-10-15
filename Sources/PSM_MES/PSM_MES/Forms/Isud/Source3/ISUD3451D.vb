Public Class ISUD3451D

#Region "Variable"
    Private wJOB As Integer

    Private W3451 As New T3451_AREA
    Private L3451 As New T3451_AREA

    Private W3452 As New T3452_AREA
    Private L3452 As New T3452_AREA

    Private W3454 As New T3454_AREA

    Private W3011 As New T3011_AREA

    Private WRITE_CHK As String
    Private formA As Boolean
    Private CHK(0 To 5) As String

    Private _chk_CheckIOType As String
    Private _chk_CheckPurchasingOrder As String

#End Region

#Region "Link"
    Public Function Link_ISUD3451D(job As Integer, FactOrderNo As String, chk_CheckIOType As String, chk_CheckPurchasingOrder As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        D3451.FactOrderNo = FactOrderNo
        D3452.FactOrderNo = FactOrderNo

        _chk_CheckIOType = chk_CheckIOType
        _chk_CheckPurchasingOrder = chk_CheckPurchasingOrder

        wJOB = job : L3451 = D3451 : L3452 = D3452

        Link_ISUD3451D = False
        Try

            Select Case job
                Case 1
                Case Else
                    If READ_PFK3451(L3451.FactOrderNo) = False Then
                        Call MsgBoxP("3", "LINK_ISUD")

                        Me.Dispose()
                        Exit Function
                    Else
                        L3451 = D3451
                    End If
                    txt_DateAccept.Enabled = False
            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD3451D = isudCHK


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
                cmd_DEL.Visible = False

                If CHK(1) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call KEY_COUNT()

                Call DATA_SEARCH_VS1()
                Call DATA_SEARCH_VS2()
                Call HideColumn()
                Setfocus(txt_cdBuyingType)
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
                Call DATA_SEARCH_VS1()
                Call DATA_SEARCH_VS2()

                Call HideColumn()
                pcl_CheckField.Enabled = True

            Case 3
                Me.Text = Me.Text & " - UPDATE"
                txt_FactOrderNo.Enabled = False
                cmd_DEL.Visible = False

                pcl_CheckField.Enabled = True

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
                        cmd_OK.Visible = False
                        Call Error_Message("16", "Form_Activate")
                    End If
                End If

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS1()
                Call DATA_SEARCH_VS2()
                Call HideColumn()
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
                Call DATA_SEARCH_VS1()
                Call DATA_SEARCH_VS2()
                Call HideColumn()
                pcl_CheckField.Enabled = True

            Case 5
                Me.Text = Me.Text & " - UPDATE AFTER"

                txt_FactOrderNo.Enabled = False
                cmd_DEL.Visible = False

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS1()
                Call DATA_SEARCH_VS2()
                Call HideColumn()

                pcl_CheckField.Enabled = True

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
                        cmd_OK.Visible = False
                        Call Error_Message("16", "Form_Activate")
                    End If
                End If


        End Select

        formA = True
        If wJOB = 1 Then txt_DateExchange.Data = Pub.DAT

    End Sub
#End Region

#Region "Search"
    Private Function DATA_SEARCH01() As Boolean
        DATA_SEARCH01 = False

        DS1 = PrcDS("USP_ISUD3451D_SEARCH_HEAD", cn, L3451.FactOrderNo)

        If GetDsRc(DS1) = 0 Then
            Exit Function
            isudCHK = False
        End If

        Call STORE_MOVE(Me, DS1)

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

            DS1 = PrcDS("USP_ISUD3451D_SEARCH_VS1_" & _chk_CheckIOType & _chk_CheckPurchasingOrder, cn, L3451.FactOrderNo)
            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs1, DS1, "USP_ISUD3451D_SEARCH_VS1_" & _chk_CheckIOType & _chk_CheckPurchasingOrder, "Vs1")
                Vs1.ActiveSheet.RowCount = 1
                Vs1.Enabled = True
                Exit Function
            End If

            txt_DateExchange.Data = GetDsData(DS1, 0, "DateExchange")
            txt_PriceExchange.Data = GetDsData(DS1, 0, "PriceExchange")

            SPR_PRO_NEW(Vs1, DS1, "USP_ISUD3451D_SEARCH_VS1_" & _chk_CheckIOType & _chk_CheckPurchasingOrder, "Vs1")

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

            Next

            DATA_SEARCH_VS1 = True

        Catch ex As Exception

        End Try
    End Function

    Private Function DATA_SEARCH_VS2() As Boolean
        DATA_SEARCH_VS2 = False
        Dim str_AutoLink As String
        Dim i As Integer

        Try

            DS1 = PrcDS("USP_ISUD3451D_SEARCH_VS2_" & _chk_CheckIOType & _chk_CheckPurchasingOrder, cn, L3451.FactOrderNo)
            If GetDsRc(DS1) = 0 Then

                DS2 = PrcDS("USP_ISUD3451D_SEARCH_VS2_" & _chk_CheckIOType & _chk_CheckPurchasingOrder & "_INSERT", cn, L3451.FactOrderNo)

                SPR_PRO_NEW(vS2, DS2, "USP_ISUD3451D_SEARCH_VS2_" & _chk_CheckIOType & _chk_CheckPurchasingOrder, "VS2")

                Call VsSizeRangeNew(vS2, "USP_VS_SIZERANGE_MATERIALCODE", "SizeQty01", getData(Vs1, getColumIndex(Vs1, "MaterialCode"), 0), getData(Vs1, getColumIndex(Vs1, "cdSubProcess"), 0))

                vS2.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS2, DS1, "USP_ISUD3451D_SEARCH_VS2_" & _chk_CheckIOType & _chk_CheckPurchasingOrder, "VS2")

            str_AutoLink = ""

            For i = 0 To Vs1.ActiveSheet.RowCount - 1 - 1
                If READ_PFK1312(getData(Vs1, getColumIndex(Vs1, "OrderNo"), i), getData(Vs1, getColumIndex(Vs1, "OrderNoSeq"), i)) Then
                    str_AutoLink = str_AutoLink & "''" & D1312.ShoesCode + "'',"
                End If
            Next

            If str_AutoLink = "" Then Exit Function

            str_AutoLink = Strings.Left(str_AutoLink, Len(str_AutoLink) - 1)
            Call VsSizeRange(vS2, "USP_VS_SIZERANGE_3451D", str_AutoLink, getData(Vs1, getColumIndex(Vs1, "cdSubProcess"), 0))

            DATA_SEARCH_VS2 = True

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
        W3451.seBuyingType = ListCode("BuyingType")
        W3451.seCommercialTerm = ListCode("CommercialTerm")
        W3451.selUnitPrice = ListCode("UnitPrice")
        W3451.seOrigin = ListCode("Origin")
        W3451.seSeason = ListCode("Season")

        W3451.seDeliveryTerm = ListCode("DeliveryTerm")
        W3451.sePaymentTerm = ListCode("PaymentTerm")
        W3451.sePaymentCondition = ListCode("PaymentCondition")
        W3451.sePaymentTime = ListCode("PaymentTime")
        W3451.sePaymentDay = ListCode("PaymentDay")

        W3452.seOrigin = ListCode("Origin")
        W3452.seTax = ListCode("Tax")
        W3452.seUnitMaterial = ListCode("UnitMaterial")
        W3452.seUnitPacking = ListCode("UnitPacking")
        W3452.seUnitPrice = ListCode("UnitPrice")
        W3452.seSite = ListCode("Site")
        W3452.seDepartment = ListCode("Department")


    End Sub

    Private Sub DATA_MOVE_WRITE01()
        Dim i As Integer
        Dim j As Integer
        j = 0

        For i = 0 To Vs1.ActiveSheet.RowCount - 1
            If Trim(getData(Vs1, getColumIndex(Vs1, "MaterialCode"), i)) = "" Then GoTo skip

            j = j + 1
            If K3452_MOVE(Vs1, i, W3452, L3452.FactOrderNo, getData(Vs1, getColumIndex(Vs1, "KEY_FactOrderSeq"), i)) = True Then
                W3452.Dseq = j

                If rad_CheckRelationType1.Checked = True Then W3452.CheckRelationType = "1"
                If rad_CheckRelationType2.Checked = True Then W3452.CheckRelationType = "2"

                W3452.QtyPurchasing = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyPurchasing"), i))
                W3452.PackPurchasing = CDecp(getData(Vs1, getColumIndex(Vs1, "PackPurchasing"), i))
                W3452.QtyBasic = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyBasic"), i))

                If Trim((getData(Vs1, getColumIndex(Vs1, "DateDelivery"), i))) = "" Then W3452.DateDelivery = txt_DateDelivery.Data
                If Trim((getData(Vs1, getColumIndex(Vs1, "DateStart"), i))) = "" Then W3452.DateStart = txt_DateStart.Data
                If Trim((getData(Vs1, getColumIndex(Vs1, "DateFinish"), i))) = "" Then W3452.DateFinish = txt_DateFinish.Data

                If W3452.CustomerSupplier = "" Then W3452.CustomerSupplier = txt_SupplierCode.Code
                If W3452.cdSite = "" Then W3452.cdSite = "001"

                W3452.PriceExchange = CDecp(txt_PriceExchange.Data)
                W3452.DateExchange = txt_DateExchange.Data

                W3452.cdDepartment = txt_cdDepartment.Code

                Call DATA_MOVE_DEFAULT()
                Call REWRITE_PFK3452(W3452)
            Else
                W3452.FactOrderNo = L3451.FactOrderNo
                W3452.Dseq = j

                Call KEY_COUNT_3452()

                W3452.CheckPurchasing = "1"
                W3452.DateAccept = txt_DateAccept.Data

                If W3452.CustomerSupplier = "" Then W3452.CustomerSupplier = txt_SupplierCode.Code
                If W3452.cdSite = "" Then W3452.cdSite = "001"

                W3452.PriceExchange = CDecp(txt_PriceExchange.Data)
                W3452.DateExchange = txt_DateExchange.Data

                W3452.QtyPurchasing = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyPurchasing"), i))
                W3452.PackPurchasing = CDecp(getData(Vs1, getColumIndex(Vs1, "PackPurchasing"), i))
                W3452.QtyBasic = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyBasic"), i))

                W3452.CheckComplete = "2"

                If rad_CheckRelationType1.Checked = True Then W3452.CheckRelationType = "1"
                If rad_CheckRelationType2.Checked = True Then W3452.CheckRelationType = "2"

                If Trim((getData(Vs1, getColumIndex(Vs1, "DateDelivery"), i))) = "" Then W3452.DateDelivery = txt_DateDelivery.Data
                If Trim((getData(Vs1, getColumIndex(Vs1, "DateStart"), i))) = "" Then W3452.DateStart = txt_DateStart.Data
                If Trim((getData(Vs1, getColumIndex(Vs1, "DateFinish"), i))) = "" Then W3452.DateFinish = txt_DateFinish.Data

                W3452.cdDepartment = txt_cdDepartment.Code

                Call DATA_MOVE_DEFAULT()
                Call WRITE_PFK3452(W3452)
            End If
skip:

        Next

    End Sub

    Private Sub DATA_UPDATE_SIZERANGE()
        Try
            Call PrcExe("USP_PFK3452_UPDATE_SIZEQTY", cn, L3451.FactOrderNo)
        Catch ex As Exception

        End Try

    End Sub


    Private Sub DATA_MOVE_WRITE02()

        Dim i As Integer
        Dim j As Integer
        j = 0
        For i = 0 To vS2.ActiveSheet.RowCount - 1
            If Trim(getData(vS2, getColumIndex(vS2, "KEY_FactOrderNo"), i)) = "" Then GoTo skip

            j = j + 1
            If K3454_MOVE(vS2, i, W3454, L3451.FactOrderNo, getData(vS2, getColumIndex(vS2, "KEY_FactOrderSeq"), i)) = True Then
                Call REWRITE_PFK3454(W3454)
                Call PrcExe("USP_PFK3454_UPDATE_SIZEQTY", cn, W3454.FactOrderNo, W3454.FactOrderSeq)

            Else
                W3454.FactOrderNo = L3451.FactOrderNo
                W3454.FactOrderSeq = getData(vS2, getColumIndex(vS2, "KEY_FactOrderSeq"), i)

                Call WRITE_PFK3454(W3454)
                Call PrcExe("USP_PFK3454_UPDATE_SIZEQTY", cn, W3454.FactOrderNo, W3454.FactOrderSeq)
            End If
skip:

        Next

    End Sub
    Private Sub DATA_INSERT()

        Try
            If K3451_MOVE(Me, W3451, 1, L3451.FactOrderNo) = False Then

                Call KEY_COUNT()

                If rad_CheckRelationType1.Checked = True Then W3451.CheckRelationType = "1"
                If rad_CheckRelationType2.Checked = True Then W3451.CheckRelationType = "2"

                If rad_CheckProcessType1.Checked = True Then W3451.CheckProcessType = "1"
                If rad_CheckProcessType2.Checked = True Then W3451.CheckProcessType = "2"

                If rad_CheckIOType1.Checked = True Then W3451.CheckIOType = "1"
                If rad_CheckIOType2.Checked = True Then W3451.CheckIOType = "2"

                If rad_CheckMaterialType1.Checked = True Then W3451.CheckMaterialType = "1"
                If rad_CheckMaterialType2.Checked = True Then W3451.CheckMaterialType = "2"

                If rad_CheckMarketType1.Checked = True Then W3451.CheckMarketType = "1"
                If rad_CheckMarketType2.Checked = True Then W3451.CheckMarketType = "2"

                W3451.CheckInPurchasingOrder = cmb_CheckInPurchasingOrder.InSelected + 1
                W3451.CheckOutPurchasingOrder = cmb_CheckOutPurchasingOrder.InSelected + 1

                Call DATA_MOVE_DEFAULT()
                If WRITE_PFK3451(W3451) = True Then
                    Call DATA_MOVE_WRITE01()
                    Call DATA_MOVE_WRITE02()
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
            If K3451_MOVE(Me, W3451, 3, L3451.FactOrderNo) = True Then
                If rad_CheckProcessType1.Checked = True Then W3451.CheckProcessType = "1"
                If rad_CheckProcessType2.Checked = True Then W3451.CheckProcessType = "2"

                If rad_CheckIOType1.Checked = True Then W3451.CheckIOType = "1"
                If rad_CheckIOType2.Checked = True Then W3451.CheckIOType = "2"

                If rad_CheckMaterialType1.Checked = True Then W3451.CheckMaterialType = "1"
                If rad_CheckMaterialType2.Checked = True Then W3451.CheckMaterialType = "2"

                If rad_CheckMarketType1.Checked = True Then W3451.CheckMarketType = "1"
                If rad_CheckMarketType2.Checked = True Then W3451.CheckMarketType = "2"

                If rad_CheckRelationType1.Checked = True Then W3451.CheckRelationType = "1"
                If rad_CheckRelationType2.Checked = True Then W3451.CheckRelationType = "2"

                W3451.CheckInPurchasingOrder = cmb_CheckInPurchasingOrder.InSelected + 1
                W3451.CheckOutPurchasingOrder = cmb_CheckOutPurchasingOrder.InSelected + 1

                Call DATA_MOVE_DEFAULT()
                If REWRITE_PFK3451(W3451) = True Then
                    Call DATA_MOVE_WRITE01()
                    Call DATA_MOVE_WRITE02()
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
            If READ_PFK3451(L3451.FactOrderNo) = True Then
                W3451 = D3451
                W3451.Remark = txt_Remark.Data

                If REWRITE_PFK3451(W3451) = True Then
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

            If READ_PFK3452_1(L3451.FactOrderNo) = False Then
                If READ_PFK3451(L3451.FactOrderNo) = True Then
                    W3451 = D3451

                    If DELETE_PFK3451(W3451) = True Then
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
            'If READ_PFK3452(getData(Vs1, getColumIndex(Vs1, "KEY_FactOrderNo"), xrow),
            '                getData(Vs1, getColumIndex(Vs1, "KEY_FactOrderSeq"), xrow)) = True Then

            '    W3452 = D3452

            '    If W3452.CheckPurchasing <> "1" Then MsgBoxP("Can not delete this ! This is Valided order !") : Exit Function
            '    If W3452.QtyWarehouse > 0 Then MsgBoxP("Can not Delete because of InBound Data") : Exit Function


            '    If DELETE_PFK3452(W3452) = True Then
            '        isudCHK = True
            '    End If
            'End If
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
            End Select

        End If

        Try
            SQL = "SELECT MAX(CAST(SUBSTRING(K3451_FactOrderNo,5,5) AS DECIMAL)) AS MAX_MCODE FROM PFK3451 "
            SQL = SQL & " WHERE SUBSTRING(K3451_FactOrderNo,3,2) = '" & YRNO.ToString & "' "
            SQL = SQL & " AND SUBSTRING(K3451_FactOrderNo,1,2) = '" & Prefix & "' "



            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                W3451.FactOrderNo = Prefix & YRNO & "00001"
            Else
                W3451.FactOrderNo = Prefix & YRNO & Format(CInt(rd!MAX_MCODE + 1), "00000")
            End If

            rd.Close()

            txt_FactOrderNo.Data = W3451.FactOrderNo
            L3451.FactOrderNo = W3451.FactOrderNo

            L3452.FactOrderNo = W3451.FactOrderNo
            W3452.FactOrderNo = W3451.FactOrderNo
        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub
    Private Sub KEY_COUNT_3452()
        Try

            SQL = "SELECT MAX(CAST(K3452_FactOrderSeq AS DECIMAL)) AS MAX_MCODE FROM PFK3452 "
            SQL = SQL & " WHERE K3452_FactOrderNo = '" & L3452.FactOrderNo & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                W3452.FactOrderSeq = 1
            Else
                W3452.FactOrderSeq = CIntp(rd!MAX_MCODE + 1)
            End If

            rd.Close()

            L3452.FactOrderSeq = W3452.FactOrderSeq

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub
    Private Sub DATA_INIT()
        Try
            txt_FactOrderNo.Enabled = False

            txt_DateAccept.Data = Pub.DAT
            txt_DateDelivery.Data = Pub.DAT
            txt_DateExchange.Data = Pub.DAT
            txt_DateFinish.Data = Pub.DAT
            txt_DateStart.Data = Pub.DAT

            txt_DatePosted.Data = Pub.DAT

            If READ_PFK7411(Pub.SAW) Then
                txt_InchargePurchasing.Data = D7411.Name
                txt_InchargePurchasing.Code = D7411.IDNO

            End If

            txt_PriceExchange.Data = 1
            txt_cdUnitPrice.Data = "VND"
            txt_cdUnitPrice.Code = "001"

            txt_Destination.Data = ""


            If _chk_CheckIOType = "1" Then
                rad_CheckIOType1.Checked = True : cmb_CheckInPurchasingOrder.Visible = True : cmb_CheckInPurchasingOrder.Enabled = False
            End If

            If _chk_CheckIOType = "2" Then
                rad_CheckIOType2.Checked = True : cmb_CheckOutPurchasingOrder.Visible = True : cmb_CheckInPurchasingOrder.Enabled = False
            End If

            If _chk_CheckIOType = "1" Then cmb_CheckInPurchasingOrder.InSelected = CIntp_S(_chk_CheckPurchasingOrder) - 1
            If _chk_CheckIOType = "2" Then cmb_CheckOutPurchasingOrder.InSelected = CIntp_S(_chk_CheckPurchasingOrder) - 1

            rad_CheckRelationType2.Checked = True

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

        Try
            For i = 0 To Vs1.ActiveSheet.RowCount - 1
                If FormatCut(getData(Vs1, getColumIndex(Vs1, "MaterialName"), i)) = "" Then MsgBoxP("Material Name at Line" & (i + 1)) : Exit Function
                If FormatCut(getData(Vs1, getColumIndex(Vs1, "cdUnitMaterial"), i)) = "" Then MsgBoxP("UnitMaterial Name at Line" & (i + 1)) : Exit Function

                'If FormatCut(getData(Vs1, getColumIndex(Vs1, "cdDepartment"), i)) = "" Then MsgBoxP("Department Name at Line" & (i + 1)) : Exit Function
                'If FormatCut(getData(Vs1, getColumIndex(Vs1, "cdTax"), i)) = "" Then MsgBoxP("Tax Name at Line" & (i + 1)) : Exit Function

                'If FormatCut(getData(Vs1, getColumIndex(Vs1, "cdUnitPrice"), i)) = "" Then MsgBoxP("Unit Price Name at Line" & (i + 1)) : Exit Function
                If FormatCut(getData(Vs1, getColumIndex(Vs1, "cdUnitPacking"), i)) = "" Then MsgBoxP("Unit Packing at Line" & (i + 1)) : Exit Function

            Next

            Data_Check = True
        Catch ex As Exception

        End Try
    End Function

    Private Sub HideColumn()
        Try
            Dim ListColumn As New List(Of Integer)

            ListColumn.Add(getColumIndex(Vs1, "AutokeyK3452"))
            ListColumn.Add(getColumIndex(Vs1, "PRNo"))
            ListColumn.Add(getColumIndex(Vs1, "QtyRequest"))

            If rad_CheckRelationType1.Checked = True Then
                SPR_HIDE(Vs1, True, ListColumn.ToArray)

            ElseIf rad_CheckRelationType2.Checked = True Then
                SPR_HIDE(Vs1, False, ListColumn.ToArray)

            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Event"
    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Select Case wJOB
            Case 1
                If DataCheck(Me, "PFK3451") = False Then Exit Sub
                If Data_Check() = False Then Exit Sub
                Call KEY_COUNT()
                Call DATA_INSERT()
                Call DATA_SEARCH_VS2()
                Call DATA_UPDATE_SIZERANGE()

                wJOB = 3
                Call DATA_SEARCH_VS1()
                Call DATA_SEARCH_VS2()
                Call HideColumn()

            Case 2
                Me.Dispose()
            Case 3
                If DataCheck(Me, "PFK3451") = False Then Exit Sub
                If Data_Check() = False Then Exit Sub

                Call DATA_UPDATE()
                Call DATA_SEARCH_VS1()
                Call DATA_SEARCH_VS2()

            Case 4
                Call DATA_DELETE()

            Case 5
                Call DATA_UPDATE_AFTER()
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

        If txt_DateAccept.Data <> Pub.DAT Then
            MsgBoxP("Can not edit because of not today!")
            If MsgBoxPPW("Please type the password to modify!", const_pwPO) = False Then Exit Sub
        End If

        If CHK(4) <> "1" Then
            Call MsgBoxP("4", "cmd_DEL_Click")
            Exit Sub
        End If

        Dim str As String = MsgBoxP("Do you want to delete it?", vbYesNo)

        If str <> vbYes Then Exit Sub

        If txt_DateAccept.Data <> Pub.DAT Then
            MsgBoxP("Can not edit because of not today!")
            If MsgBoxPPW("Please type the password to modify!", const_pwPO) = False Then Exit Sub
        End If

        Call DATA_DELETE()
    End Sub

    Private Sub Vs1_ButtonClicked(sender As Object, e As EditorNotifyEventArgs) Handles Vs1.ButtonClicked
        If txt_cdSeason.Code = "" Then MsgBoxP("No season!") : Setfocus(txt_cdSeason) : Exit Sub
        If txt_CustomerCode.Code = "" Then MsgBoxP("No Customer!") : Setfocus(txt_CustomerCode) : Exit Sub

        txt_cdSeason.Enabled = False
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
                If HLP3011A_OS_SL.Link_HLP3011Material(txt_cdSeason.Code, txt_CustomerCode.Code) = True Then

                    If hlp0000SeVa = "" Then Exit Sub
                    Value1 = hlp0000SeVa.Split("|")

                    For i = 0 To Value1.Length - 1
                        Value2 = Value1(i).Split(",")

                        If Value2.Length > 1 Then
                            If READ_PFK1312(Value2(0), Value2(1)) = True Then
                                Vs1.ActiveSheet.RowCount += 1

                                Call READ_PFK7106(D1312.ShoesCode)

                                setData(sender, getColumIndex(Vs1, "Line"), xROW, D7106.Line)
                                setData(sender, getColumIndex(Vs1, "Article"), xROW, D7106.Article)
                                setData(sender, getColumIndex(Vs1, "ColorCode"), xROW, D7106.ColorCode)
                                setData(sender, getColumIndex(Vs1, "ColorName"), xROW, D7106.ColorName)
                                setData(sender, getColumIndex(Vs1, "MCODE"), xROW, D7106.MCODE)
                                setData(sender, getColumIndex(Vs1, "MCODEName"), xROW, D7106.MCODEName)

                                If READ_PFK7231_SHOESCODE(D1312.ShoesCode) = True Then
                                    setData(sender, getColumIndex(Vs1, "MaterialCode"), xROW, D7231.MaterialCode)
                                    setData(sender, getColumIndex(Vs1, "MaterialName"), xROW, D7231.MaterialName)

                                    setData(sender, getColumIndex(Vs1, "seUnitMaterial"), xROW, D7231.seUnitMaterial)
                                    setData(sender, getColumIndex(Vs1, "cdUnitMaterial"), xROW, D7231.cdUnitMaterial)
                                    Call READ_PFK7171(D7231.seUnitMaterial, D7231.cdUnitMaterial)
                                    setData(sender, getColumIndex(Vs1, "cdUnitMaterialName"), xROW, D7171.BasicName)

                                    setData(sender, getColumIndex(Vs1, "seUnitPacking"), xROW, D7231.seUnitPacking)
                                    setData(sender, getColumIndex(Vs1, "cdUnitPacking"), xROW, D7231.cdUnitPacking)
                                    Call READ_PFK7171(D7231.seUnitPacking, D7231.cdUnitPacking)
                                    setData(sender, getColumIndex(Vs1, "cdUnitPackingName"), xROW, D7171.BasicName)

                                    setData(sender, getColumIndex(Vs1, "seUnitPrice"), xROW, D7231.seUnitPrice)
                                    setData(sender, getColumIndex(Vs1, "cdUnitPrice"), xROW, D7231.cdUnitPrice)
                                    Call READ_PFK7171(D7231.seUnitPrice, D7231.cdUnitPrice)
                                    setData(sender, getColumIndex(Vs1, "cdUnitPriceName"), xROW, D7171.BasicName)

                                    setData(sender, getColumIndex(Vs1, "SLNO"), xROW, D1312.SLNo)
                                    setData(sender, getColumIndex(Vs1, "OrderNo"), xROW, D1312.OrderNo)
                                    setData(sender, getColumIndex(Vs1, "OrderNoSeq"), xROW, D1312.OrderNoSeq)

                                    setData(sender, getColumIndex(Vs1, "QtyPurchasing"), xROW, D1312.QtyOrder)
                                    setData(sender, getColumIndex(Vs1, "PRQtyPurchasing"), xROW, D1312.QtyOrder)

                                    Vs1.ActiveSheet.ActiveColumnIndex += 1 : Vs1.ActiveSheet.ActiveRowIndex = xROW
                                End If

                                setData(Vs1, getColumIndex(Vs1, "DateExchange"), xROW, txt_DateExchange.Data)
                                setData(Vs1, getColumIndex(Vs1, "DateDelivery"), xROW, txt_DateDelivery.Data)
                                setData(Vs1, getColumIndex(Vs1, "DateFinish"), xROW, txt_DateFinish.Data)
                                setData(Vs1, getColumIndex(Vs1, "DateStart"), xROW, txt_DateStart.Data)

                                If rad_CheckMarketType1.Checked = True Then
                                    setData(Vs1, getColumIndex(Vs1, "cdTax"), xROW, "001")
                                    setData(Vs1, getColumIndex(Vs1, "cdTaxName"), xROW, "0.1")
                                    setData(Vs1, getColumIndex(Vs1, "cdUnitPrice"), xROW, "001")
                                    setData(Vs1, getColumIndex(Vs1, "cdUnitPriceName"), xROW, "VND")

                                End If

                                xROW = xROW + 1
                            End If
                        End If

                        If READ_PFK4010(Value2(0)) = True Then
                            Call READ_PFK4002(D4010.WorkOrder, D4010.WorkOrderSeq)
                            Call READ_PFK1312(D4002.OrderNo, D4002.OrderNoSeq)

                            setData(sender, getColumIndex(Vs1, "JobCard"), xROW, D4010.JobCard)
                            setData(sender, getColumIndex(Vs1, "SLNO"), xROW, D4010.SlNoD)

                            Vs1.ActiveSheet.RowCount += 1

                            If READ_PFK7231_SHOESCODE(D1312.ShoesCode) = True Then
                                setData(sender, getColumIndex(Vs1, "MaterialCode"), xROW, D7231.MaterialCode)
                                setData(sender, getColumIndex(Vs1, "MaterialName"), xROW, D7231.MaterialName)

                                setData(sender, getColumIndex(Vs1, "seUnitMaterial"), xROW, D7231.seUnitMaterial)
                                setData(sender, getColumIndex(Vs1, "cdUnitMaterial"), xROW, D7231.cdUnitMaterial)
                                Call READ_PFK7171(D7231.seUnitMaterial, D7231.cdUnitMaterial)
                                setData(sender, getColumIndex(Vs1, "cdUnitMaterialName"), xROW, D7171.BasicName)

                                setData(sender, getColumIndex(Vs1, "seUnitPacking"), xROW, D7231.seUnitPacking)
                                setData(sender, getColumIndex(Vs1, "cdUnitPacking"), xROW, D7231.cdUnitPacking)
                                Call READ_PFK7171(D7231.seUnitPacking, D7231.cdUnitPacking)
                                setData(sender, getColumIndex(Vs1, "cdUnitPackingName"), xROW, D7171.BasicName)

                                setData(sender, getColumIndex(Vs1, "seUnitPrice"), xROW, D7231.seUnitPrice)
                                setData(sender, getColumIndex(Vs1, "cdUnitPrice"), xROW, D7231.cdUnitPrice)
                                Call READ_PFK7171(D7231.seUnitPrice, D7231.cdUnitPrice)
                                setData(sender, getColumIndex(Vs1, "cdUnitPriceName"), xROW, D7171.BasicName)

                                setData(sender, getColumIndex(Vs1, "OrderNo"), xROW, D1312.OrderNo)
                                setData(sender, getColumIndex(Vs1, "OrderNoSeq"), xROW, D1312.OrderNoSeq)

                                setData(sender, getColumIndex(Vs1, "QtyPurchasing"), xROW, D4010.QtyOrder)
                                setData(sender, getColumIndex(Vs1, "PRQtyPurchasing"), xROW, D4010.QtyOrder)

                                Vs1.ActiveSheet.ActiveColumnIndex += 1 : Vs1.ActiveSheet.ActiveRowIndex = xROW
                            End If

                            setData(Vs1, getColumIndex(Vs1, "DateExchange"), xROW, txt_DateExchange.Data)
                            setData(Vs1, getColumIndex(Vs1, "DateDelivery"), xROW, txt_DateDelivery.Data)
                            setData(Vs1, getColumIndex(Vs1, "DateFinish"), xROW, txt_DateFinish.Data)
                            setData(Vs1, getColumIndex(Vs1, "DateStart"), xROW, txt_DateStart.Data)

                            If rad_CheckMarketType1.Checked = True Then
                                setData(Vs1, getColumIndex(Vs1, "cdTax"), xROW, "001")
                                setData(Vs1, getColumIndex(Vs1, "cdTaxName"), xROW, "0.1")
                                setData(Vs1, getColumIndex(Vs1, "cdUnitPrice"), xROW, "001")
                                setData(Vs1, getColumIndex(Vs1, "cdUnitPriceName"), xROW, "VND")

                            End If

                            xROW = xROW + 1
                        End If
                    Next

                End If
                Vs1.Focus()

        End Select

        vSChange(e.Row)
    End Sub

    Private Sub Vs1_Change(sender As Object, e As ChangeEventArgs) Handles Vs1.Change
        Dim xCOL As Integer
        Dim xROW As Integer
        Dim ListColumn As New List(Of Integer)

        ListColumn.Add(getColumIndex(Vs1, "cdTax"))
        ListColumn.Add(getColumIndex(Vs1, "cdUnitPrice"))
        ListColumn.Add(getColumIndex(Vs1, "PricePurchasing"))
        ListColumn.Add(getColumIndex(Vs1, "QtyPurchasing"))
        ListColumn.Add(getColumIndex(Vs1, "PackPurchasing"))
        ListColumn.Add(getColumIndex(Vs1, "UnitBaseCheck"))

        Try
            xROW = e.Row
            xCOL = e.Column

            If ListColumn.Contains(xCOL) Then
                vSChange(xROW)
            End If

KeyTab7:
        Catch ex As Exception

        End Try

    End Sub

    Private Sub vSChange(xROW As Integer)
        If wJOB = 2 Then Exit Sub

        If getData(Vs1, getColumIndex(Vs1, "cdTax"), xROW) = "" Then
            If rad_CheckMarketType1.Checked = True Then setData(Vs1, getColumIndex(Vs1, "cdTax"), xROW, "001") : setData(Vs1, getColumIndex(Vs1, "cdTaxName"), xROW, "0.1")
            If rad_CheckMarketType2.Checked = True Then setData(Vs1, getColumIndex(Vs1, "cdTax"), xROW, "002") : setData(Vs1, getColumIndex(Vs1, "cdTaxName"), xROW, "0")
        End If

        setData(Vs1, getColumIndex(Vs1, "seUnitPrice"), xROW, ListCode("UnitPrice"))
        setData(Vs1, getColumIndex(Vs1, "cdUnitPrice"), xROW, txt_cdUnitPrice.Code)
        setData(Vs1, getColumIndex(Vs1, "cdUnitPriceName"), xROW, txt_cdUnitPrice.Data)

        If getData(Vs1, getColumIndex(Vs1, "cdUnitPriceName"), xROW) = "" Then
            If rad_CheckMarketType1.Checked = True Then setData(Vs1, getColumIndex(Vs1, "cdUnitPrice"), xROW, "001") : setData(Vs1, getColumIndex(Vs1, "cdUnitPriceName"), xROW, "VND")
        End If

        If CDecp(getData(Vs1, getColumIndex(Vs1, "PackPurchasing"), xROW)) > 0 And getDataM(Vs1, getColumIndex(Vs1, "UnitBaseCheck"), xROW) = "1" Then
            Dim PackPurchasing As Decimal
            Dim QtyBasic As Decimal
            Dim QtyPurchasing As Decimal

            PackPurchasing = CDecp(getData(Vs1, getColumIndex(Vs1, "PackPurchasing"), xROW))
            QtyBasic = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyBasic"), xROW))
            QtyPurchasing = PackPurchasing * QtyBasic

            setData(Vs1, getColumIndex(Vs1, "QtyPurchasing"), xROW, QtyPurchasing)
        End If

        If CDecp(getData(Vs1, getColumIndex(Vs1, "PricePurchasing"), xROW)) >= 0 And CDecp(getData(Vs1, getColumIndex(Vs1, "QtyPurchasing"), xROW)) > 0 Then
            If getData(Vs1, getColumIndex(Vs1, "cdUnitPriceName"), xROW) <> "VND" Then
                setData(Vs1, getColumIndex(Vs1, "PricePurchasingEX"), xROW, CDecp(getData(Vs1, getColumIndex(Vs1, "PricePurchasing"), xROW)))
                setData(Vs1, getColumIndex(Vs1, "PricePurchasingVND"), xROW, CDecp(getData(Vs1, getColumIndex(Vs1, "PricePurchasingEX"), xROW) * CDecp(txt_PriceExchange.Data)))
                setData(Vs1, getColumIndex(Vs1, "AmountPurchasingEX"), xROW, CDecp(getData(Vs1, getColumIndex(Vs1, "PricePurchasingEX"), xROW) * _
                                                                           CDecp(getData(Vs1, getColumIndex(Vs1, "QtyPurchasing"), xROW))))
                setData(Vs1, getColumIndex(Vs1, "AmountPurchasingVND"), xROW, CDecp(getData(Vs1, getColumIndex(Vs1, "AmountPurchasingEX"), xROW) * CDecp(txt_PriceExchange.Data)))

                setData(Vs1, getColumIndex(Vs1, "AmountTaxEX"), xROW, CDecp(getData(Vs1, getColumIndex(Vs1, "AmountPurchasingEX"), xROW) * _
                                                                               CDecp(getData(Vs1, getColumIndex(Vs1, "cdTaxName"), xROW))))

                setData(Vs1, getColumIndex(Vs1, "AmountTaxVND"), xROW, CDecp(getData(Vs1, getColumIndex(Vs1, "AmountPurchasingVND"), xROW) * _
                                                                               CDecp(getData(Vs1, getColumIndex(Vs1, "cdTaxName"), xROW))))

            ElseIf getData(Vs1, getColumIndex(Vs1, "cdUnitPriceName"), xROW) = "VND" Then
                If CDecp(txt_PriceExchange.Data) = 0 Then Exit Sub
                setData(Vs1, getColumIndex(Vs1, "PricePurchasingVND"), xROW, CDecp(getData(Vs1, getColumIndex(Vs1, "PricePurchasing"), xROW)))
                setData(Vs1, getColumIndex(Vs1, "PricePurchasingEX"), xROW, CDecp(getData(Vs1, getColumIndex(Vs1, "PricePurchasingVND"), xROW) / CDecp(txt_PriceExchange.Data)))
                setData(Vs1, getColumIndex(Vs1, "AmountPurchasingEX"), xROW, CDecp(getData(Vs1, getColumIndex(Vs1, "PricePurchasingEX"), xROW) * _
                                                                           CDecp(getData(Vs1, getColumIndex(Vs1, "QtyPurchasing"), xROW))))
                setData(Vs1, getColumIndex(Vs1, "AmountPurchasingVND"), xROW, CDecp(getData(Vs1, getColumIndex(Vs1, "AmountPurchasingEX"), xROW) * CDecp(txt_PriceExchange.Data)))

                setData(Vs1, getColumIndex(Vs1, "AmountTaxEX"), xROW, CDecp(getData(Vs1, getColumIndex(Vs1, "AmountPurchasingEX"), xROW) * _
                                                                               CDecp(getData(Vs1, getColumIndex(Vs1, "cdTaxName"), xROW))))

                setData(Vs1, getColumIndex(Vs1, "AmountTaxVND"), xROW, CDecp(getData(Vs1, getColumIndex(Vs1, "AmountPurchasingVND"), xROW) * _
                                                                               CDecp(getData(Vs1, getColumIndex(Vs1, "cdTaxName"), xROW))))
            End If

            'NAM MARKET PRICE
            If CDecp(getData(Vs1, getColumIndex(Vs1, "PriceMarket"), xROW)) >= 0 Then
                If getData(Vs1, getColumIndex(Vs1, "cdUnitPriceName"), xROW) = "EX" Then
                    setData(Vs1, getColumIndex(Vs1, "PriceMarketEX"), xROW, CDecp(getData(Vs1, getColumIndex(Vs1, "PriceMarket"), xROW)))
                    setData(Vs1, getColumIndex(Vs1, "PriceMarketVND"), xROW, CDecp(getData(Vs1, getColumIndex(Vs1, "PriceMarketEX"), xROW) * CDecp(txt_PriceExchange.Data)))

                ElseIf getData(Vs1, getColumIndex(Vs1, "cdUnitPriceName"), xROW) = "VND" Then
                    If CDecp(txt_PriceExchange.Data) = 0 Then Exit Sub
                    setData(Vs1, getColumIndex(Vs1, "PriceMarketVND"), xROW, CDecp(getData(Vs1, getColumIndex(Vs1, "PriceMarket"), xROW)))
                    setData(Vs1, getColumIndex(Vs1, "PriceMarketEX"), xROW, CDecp(getData(Vs1, getColumIndex(Vs1, "PriceMarketVND"), xROW) / CDecp(txt_PriceExchange.Data)))

                End If
            End If

        End If

    End Sub

    Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellDoubleClick
        Dim xCOL As Long
        Dim xROW As Long

        xCOL = Vs1.ActiveSheet.ActiveColumnIndex
        xROW = Vs1.ActiveSheet.ActiveRowIndex
        Select Case xCOL

            Case getColumIndex(Vs1, "DateDelivery"), getColumIndex(Vs1, "DateStart"), getColumIndex(Vs1, "DateFinish")
                If CALENDAR_SINGLE.CALENDAR_SINGLE_Link(getData(Vs1, xCOL, xROW)) = False Then Exit Sub
                If CIntp(syearn) = 0 Or CIntp(smonth) = 0 Or CIntp(sday) = 0 Then Exit Sub

                Dim CalDate As String
                CalDate = syearn.ToString & smonth.ToString("00") & sday.ToString("00")
                setData(Vs1, xCOL, xROW, FSDate(CalDate))
                setCell(Vs1, xCOL, xROW, CalDate)
                Vs1.ActiveSheet.ActiveColumnIndex += 1 : Vs1.ActiveSheet.ActiveRowIndex = xROW

                Vs1.Focus()

                Call vSChange(xROW)
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

                Msg_Result = MsgBoxP("Do you want to delete?", vbYesNo)

                If Msg_Result <> vbYes Then Exit Sub

                If txt_DateAccept.Data <> Pub.DAT Then
                    MsgBoxP("Can not edit because of not today!")
                    If MsgBoxPPW("Please type the password to modify!", const_pwPO) = False Then Exit Sub
                End If

                W3452.FactOrderNo = txt_FactOrderNo.Data
                W3452.FactOrderSeq = getData(Vs1, getColumIndex(Vs1, "KEY_FactOrderSeq"), xROW)

                'If READ_PFK3452(W3452.FactOrderNo, W3452.FactOrderSeq) = True Then
                '    If D3452.CheckPurchasing <> "1" Then MsgBoxP("Check condition at row " & xROW) : Exit Sub
                '    If CDblp(D3452.QtyWarehouse) > 0 Then MsgBoxP("Check condition at row " & xROW) : Exit Sub

                '    If DELETE_PFK3452(D3452) Then

                '        If READ_PFK3452_1(L3451.FactOrderNo) = False Then
                '            If READ_PFK3451(L3451.FactOrderNo) = True Then
                '                W3451 = D3451

                '                If DELETE_PFK3451(W3451) = True Then
                '                    isudCHK = True
                '                    Me.Dispose()
                '                End If

                '            End If

                '        End If

                '    End If

                'End If

                SPR_DEL(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex)
                Vs1.Focus()

            Case Keys.Enter
                Select Case xCOL
                    Case getColumIndex(sender, "CLcdMaterialCode_D")

                        If HLP3011A_OS.Link_HLP3011Material = True Then

                            If hlp0000SeVa = "" Then Exit Sub
                            Value1 = hlp0000SeVa.Split("|")

                            For i = 0 To Value1.Length - 1
                                Value2 = Value1(i).Split(",")
                                If READ_PFK1312(Value2(0), Value2(1)) = True Then
                                    Vs1.ActiveSheet.RowCount += 1

                                    If READ_PFK7231_SHOESCODE(D1312.ShoesCode) = True Then
                                        setData(sender, getColumIndex(Vs1, "MaterialCode"), xROW, D7231.MaterialCode)
                                        setData(sender, getColumIndex(Vs1, "MaterialName"), xROW, D7231.MaterialName)

                                        setData(sender, getColumIndex(Vs1, "seUnitMaterial"), xROW, D7231.seUnitMaterial)
                                        setData(sender, getColumIndex(Vs1, "cdUnitMaterial"), xROW, D7231.cdUnitMaterial)
                                        Call READ_PFK7171(D7231.seUnitMaterial, D7231.cdUnitMaterial)
                                        setData(sender, getColumIndex(Vs1, "cdUnitMaterialName"), xROW, D7171.BasicName)

                                        setData(sender, getColumIndex(Vs1, "seUnitPacking"), xROW, D7231.seUnitPacking)
                                        setData(sender, getColumIndex(Vs1, "cdUnitPacking"), xROW, D7231.cdUnitPacking)
                                        Call READ_PFK7171(D7231.seUnitPacking, D7231.cdUnitPacking)
                                        setData(sender, getColumIndex(Vs1, "cdUnitPackingName"), xROW, D7171.BasicName)

                                        setData(sender, getColumIndex(Vs1, "seUnitPrice"), xROW, D7231.seUnitPrice)
                                        setData(sender, getColumIndex(Vs1, "cdUnitPrice"), xROW, D7231.cdUnitPrice)
                                        Call READ_PFK7171(D7231.seUnitPrice, D7231.cdUnitPrice)
                                        setData(sender, getColumIndex(Vs1, "cdUnitPriceName"), xROW, D7171.BasicName)

                                        setData(sender, getColumIndex(Vs1, "SLNO"), xROW, D1312.SLNo)
                                        setData(sender, getColumIndex(Vs1, "OrderNo"), xROW, D1312.OrderNo)
                                        setData(sender, getColumIndex(Vs1, "OrderNoSeq"), xROW, D1312.OrderNoSeq)

                                        setData(sender, getColumIndex(Vs1, "QtyPurchasing"), xROW, D1312.QtyOrder)
                                        setData(sender, getColumIndex(Vs1, "PRQtyPurchasing"), xROW, D1312.QtyOrder)

                                        Vs1.ActiveSheet.ActiveColumnIndex += 1 : Vs1.ActiveSheet.ActiveRowIndex = xROW
                                    End If

                                    setData(Vs1, getColumIndex(Vs1, "DateExchange"), xROW, txt_DateExchange.Data)
                                    setData(Vs1, getColumIndex(Vs1, "DateDelivery"), xROW, txt_DateDelivery.Data)
                                    setData(Vs1, getColumIndex(Vs1, "DateFinish"), xROW, txt_DateFinish.Data)
                                    setData(Vs1, getColumIndex(Vs1, "DateStart"), xROW, txt_DateStart.Data)

                                    If rad_CheckMarketType1.Checked = True Then
                                        setData(Vs1, getColumIndex(Vs1, "cdTax"), xROW, "001")
                                        setData(Vs1, getColumIndex(Vs1, "cdTaxName"), xROW, "0.1")
                                        setData(Vs1, getColumIndex(Vs1, "cdUnitPrice"), xROW, "001")
                                        setData(Vs1, getColumIndex(Vs1, "cdUnitPriceName"), xROW, "VND")

                                    End If

                                    xROW = xROW + 1
                                End If


                                If READ_PFK4010(Value2(0)) = True Then
                                    Call READ_PFK4002(D4010.WorkOrder, D4010.WorkOrderSeq)
                                    Call READ_PFK1312(D4002.OrderNo, D4002.OrderNoSeq)

                                    Vs1.ActiveSheet.RowCount += 1

                                    If READ_PFK7231_SHOESCODE(D1312.ShoesCode) = True Then
                                        setData(sender, getColumIndex(Vs1, "MaterialCode"), xROW, D7231.MaterialCode)
                                        setData(sender, getColumIndex(Vs1, "MaterialName"), xROW, D7231.MaterialName)

                                        setData(sender, getColumIndex(Vs1, "seUnitMaterial"), xROW, D7231.seUnitMaterial)
                                        setData(sender, getColumIndex(Vs1, "cdUnitMaterial"), xROW, D7231.cdUnitMaterial)
                                        Call READ_PFK7171(D7231.seUnitMaterial, D7231.cdUnitMaterial)
                                        setData(sender, getColumIndex(Vs1, "cdUnitMaterialName"), xROW, D7171.BasicName)

                                        setData(sender, getColumIndex(Vs1, "seUnitPacking"), xROW, D7231.seUnitPacking)
                                        setData(sender, getColumIndex(Vs1, "cdUnitPacking"), xROW, D7231.cdUnitPacking)
                                        Call READ_PFK7171(D7231.seUnitPacking, D7231.cdUnitPacking)
                                        setData(sender, getColumIndex(Vs1, "cdUnitPackingName"), xROW, D7171.BasicName)

                                        setData(sender, getColumIndex(Vs1, "seUnitPrice"), xROW, D7231.seUnitPrice)
                                        setData(sender, getColumIndex(Vs1, "cdUnitPrice"), xROW, D7231.cdUnitPrice)
                                        Call READ_PFK7171(D7231.seUnitPrice, D7231.cdUnitPrice)
                                        setData(sender, getColumIndex(Vs1, "cdUnitPriceName"), xROW, D7171.BasicName)

                                        setData(sender, getColumIndex(Vs1, "SLNO"), xROW, D1312.SLNo)
                                        setData(sender, getColumIndex(Vs1, "OrderNo"), xROW, D1312.OrderNo)
                                        setData(sender, getColumIndex(Vs1, "OrderNoSeq"), xROW, D1312.OrderNoSeq)

                                        setData(sender, getColumIndex(Vs1, "QtyPurchasing"), xROW, D1312.QtyOrder)
                                        setData(sender, getColumIndex(Vs1, "PRQtyPurchasing"), xROW, D1312.QtyOrder)

                                        Vs1.ActiveSheet.ActiveColumnIndex += 1 : Vs1.ActiveSheet.ActiveRowIndex = xROW
                                    End If

                                    setData(Vs1, getColumIndex(Vs1, "DateExchange"), xROW, txt_DateExchange.Data)
                                    setData(Vs1, getColumIndex(Vs1, "DateDelivery"), xROW, txt_DateDelivery.Data)
                                    setData(Vs1, getColumIndex(Vs1, "DateFinish"), xROW, txt_DateFinish.Data)
                                    setData(Vs1, getColumIndex(Vs1, "DateStart"), xROW, txt_DateStart.Data)

                                    If rad_CheckMarketType1.Checked = True Then
                                        setData(Vs1, getColumIndex(Vs1, "cdTax"), xROW, "001")
                                        setData(Vs1, getColumIndex(Vs1, "cdTaxName"), xROW, "0.1")
                                        setData(Vs1, getColumIndex(Vs1, "cdUnitPrice"), xROW, "001")
                                        setData(Vs1, getColumIndex(Vs1, "cdUnitPriceName"), xROW, "VND")

                                    End If

                                    xROW = xROW + 1
                                End If
                            Next

                        End If

                End Select

                Call vSChange(xROW)
        End Select

    End Sub

    Private Sub rad_CheckIOType1_CheckedChanged(sender As Object, e As EventArgs) Handles rad_CheckIOType1.CheckedChanged, rad_CheckIOType2.CheckedChanged
        If rad_CheckIOType1.Checked = True Then
            rad_CheckProcessType1.Checked = True

            cmb_CheckInPurchasingOrder.Visible = True
            cmb_CheckOutPurchasingOrder.Visible = False
        ElseIf rad_CheckIOType2.Checked = True Then
            rad_CheckProcessType2.Checked = True

            cmb_CheckInPurchasingOrder.Visible = False
            cmb_CheckOutPurchasingOrder.Visible = True
        End If

    End Sub

    Private Sub txt_PriceExchange_txtTextChanged(sender As Object, e As EventArgs) Handles txt_PriceExchange.txtTextChanged, txt_cdUnitPrice.txtTextChange
        If formA = False Then Exit Sub
        Dim i As Integer
        Try

            If READ_PFK7199(txt_DateExchange.Data, ListCode("UnitPrice"), txt_cdUnitPrice.Code) Then
                txt_PriceExchange.Data = D7199.Value

                For i = 0 To Vs1.ActiveSheet.RowCount - 1
                    vSChange(i)
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

    Private Sub rad_CheckRelationType1_CheckedChanged(sender As Object, e As EventArgs) Handles rad_CheckRelationType1.CheckedChanged, rad_CheckRelationType2.CheckedChanged
        Call HideColumn()
    End Sub

    Private Sub cmd_UpdateSize_Click(sender As Object, e As EventArgs) Handles cmd_UpdateSize.Click
        If READ_PFK1312(getData(Vs1, getColumIndex(Vs1, "OrderNo"), Vs1.ActiveSheet.ActiveRowIndex), getData(Vs1, getColumIndex(Vs1, "OrderNoSeq"), Vs1.ActiveSheet.ActiveRowIndex)) = False Then Exit Sub

        If HLP7106G.Link_HLP7106G(D1312.ShoesCode) Then
            Call DATA_SEARCH_VS2()
        End If

    End Sub
#End Region



    
End Class