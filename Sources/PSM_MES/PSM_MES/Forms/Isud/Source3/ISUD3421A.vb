Public Class ISUD3421A

#Region "Variable"
    Private wJOB As Integer

    Private W3421 As New T3421_AREA
    Private L3421 As New T3421_AREA

    Private W3422 As New T3422_AREA
    Private L3422 As New T3422_AREA

    Private W3011 As New T3011_AREA

    Private WRITE_CHK As String
    Private formA As Boolean
    Private CHK(0 To 5) As String

    Private _chk_CheckIOType As String
    Private _chk_CheckPurchasingOrder As String

#End Region

#Region "Link"
    Public Function Link_ISUD3421A(job As Integer, FactOrderNo As String, chk_CheckIOType As String, chk_CheckPurchasingOrder As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        Link_ISUD3421A = False

        D3421.FactOrderNo = FactOrderNo
        D3422.FactOrderNo = FactOrderNo

        _chk_CheckIOType = chk_CheckIOType
        _chk_CheckPurchasingOrder = chk_CheckPurchasingOrder

        If chk_CheckIOType = "2" And chk_CheckPurchasingOrder = "1" Then
     
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
                        txt_DateAccept.Enabled = False
                    End If
            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD3421A = isudCHK


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

        Call FORM_INIT()
        Call DATA_INIT()

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

                cmd_DEL.Visible = False

                Call KEY_COUNT()
                Call DATA_SEARCH_VS1()
                Call HideColumn()

                Setfocus(txt_cdBuyingType)
            Case 2
                Me.Text = Me.Text & " - SEARCH"
                If CHK(2) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                pcl_CheckField.Enabled = False

                cmd_DEL.Visible = False
                cmd_OK.Visible = False

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

                pcl_CheckField.Enabled = False
                txt_FactOrderNo.Enabled = False

                cmd_DEL.Visible = False

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS1()
                Call HideColumn()

                '-----------------------------------------------------------------------------------------------------
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
                '-----------------------------------------------------------------------------------------------------

            Case 4
                Me.Text = Me.Text & " - DELETE"
                If CHK(4) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                pcl_CheckField.Enabled = False
                cmd_OK.Visible = False

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS1()
                Call HideColumn()

                '-----------------------------------------------------------------------------------------------------
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
                '-----------------------------------------------------------------------------------------------------

            Case 5
                Me.Text = Me.Text & " - UPDATE AFTER"
                If CHK(1) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                txt_FactOrderNo.Enabled = False
                cmd_DEL.Visible = False

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS1()
                Call HideColumn()

                pcl_CheckField.Enabled = False
                '-----------------------------------------------------------------------------------------------------
                ' Data Check ==>> Customer, Department
                If CheckData_Customer(Me.FindForm.FindCode("CustomerCode").Code(), wJOB) = False Then
                    isudCHK = False
                    formA = True
                    MsgBoxP("No Correct Customer !")
                    Exit Sub
                End If

                If CheckData_Department(Me.FindForm.FindCode("cdDepartment").Code(), wJOB) = False Then
                    isudCHK = False
                    formA = True
                    MsgBoxP("No Correct Department !")
                    Exit Sub
                End If
                '-----------------------------------------------------------------------------------------------------
        End Select

        formA = True
        If wJOB = 1 Then txt_DateExchange.Data = Pub.DAT

    End Sub
#End Region

#Region "Search"
    Private Function DATA_SEARCH01() As Boolean
        DATA_SEARCH01 = False

        DS1 = PrcDS("USP_ISUD3421A_SEARCH_HEAD", cn, L3421.FactOrderNo)

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

            DS1 = PrcDS("USP_ISUD3421A_SEARCH_VS1_" & _chk_CheckIOType & _chk_CheckPurchasingOrder, cn, L3421.FactOrderNo)
            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs1, DS1, "USP_ISUD3421A_SEARCH_VS1_" & _chk_CheckIOType & _chk_CheckPurchasingOrder, "Vs1")
                Call SPR_SearchType(Vs1, SearchType.Material)
                Call SPR_SearchType(Vs1, SearchType.ColorName)
                Vs1.ActiveSheet.RowCount = 1
                Vs1.Enabled = True
                Exit Function
            End If

            txt_DateExchange.Data = GetDsData(DS1, 0, "DateExchange")
            txt_PriceExchange.Data = GetDsData(DS1, 0, "PriceExchange")

            SPR_PRO_NEW(Vs1, DS1, "USP_ISUD3421A_SEARCH_VS1_" & _chk_CheckIOType & _chk_CheckPurchasingOrder, "Vs1")
            Call SPR_SearchType(Vs1, SearchType.Material)
            Call SPR_SearchType(Vs1, SearchType.ColorName)

            If wJOB <> 5 Then
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

                    Call SPR_ChkLock(Vs1, False, getColumIndex(Vs1, "QtyPurchasing"))
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
        j = 0
        For i = 0 To Vs1.ActiveSheet.RowCount - 1

            If Trim(getData(Vs1, getColumIndex(Vs1, "MaterialCode"), i)) = "" Then GoTo skip

            j = j + 1
            If K3422_MOVE(Vs1, i, W3422, L3422.FactOrderNo, getData(Vs1, getColumIndex(Vs1, "KEY_FactOrderSeq"), i)) = True Then
                W3422.Dseq = j

                If W3422.CheckPurchasing = "1" Then

                    If rad_CheckRelationType1.Checked = True Then W3422.CheckRelationType = "1"
                    If rad_CheckRelationType2.Checked = True Then W3422.CheckRelationType = "2"

                    W3422.QtyPurchasing = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyPurchasing"), i))
                    W3422.PackPurchasing = CDecp(getData(Vs1, getColumIndex(Vs1, "PackPurchasing"), i))
                    W3422.QtyBasic = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyBasic"), i))

                    If Trim((getData(Vs1, getColumIndex(Vs1, "DateDelivery"), i))) = "" Then W3422.DateDelivery = txt_DateDelivery.Data
                    If Trim((getData(Vs1, getColumIndex(Vs1, "DateStart"), i))) = "" Then W3422.DateStart = txt_DateStart.Data
                    If Trim((getData(Vs1, getColumIndex(Vs1, "DateFinish"), i))) = "" Then W3422.DateFinish = txt_DateFinish.Data

                    If W3422.CustomerSupplier = "" Then W3422.CustomerSupplier = txt_SupplierCode.Code
                    If W3422.cdSite = "" Then W3422.cdSite = "001"

                    W3422.PriceExchange = CDecp(txt_PriceExchange.Data)
                    W3422.DateExchange = txt_DateExchange.Data

                    W3422.cdDepartment = txt_cdDepartment.Code

                    If READ_PFK3011(W3422.AutokeyK3011) Then
                        W3011 = D3011
                        W3011.QtyRequest = W3422.QtyPurchasing
                        Call REWRITE_PFK3011(W3011)
                    End If

                    Call DATA_MOVE_DEFAULT()
                    Call REWRITE_PFK3422(W3422)
                End If
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

                W3422.CheckComplete = "2"

                If rad_CheckRelationType1.Checked = True Then W3422.CheckRelationType = "1"
                If rad_CheckRelationType2.Checked = True Then W3422.CheckRelationType = "2"

                If Trim((getData(Vs1, getColumIndex(Vs1, "DateDelivery"), i))) = "" Then W3422.DateDelivery = txt_DateDelivery.Data
                If Trim((getData(Vs1, getColumIndex(Vs1, "DateStart"), i))) = "" Then W3422.DateStart = txt_DateStart.Data
                If Trim((getData(Vs1, getColumIndex(Vs1, "DateFinish"), i))) = "" Then W3422.DateFinish = txt_DateFinish.Data

                W3422.cdDepartment = txt_cdDepartment.Code

                If READ_PFK3011(W3422.AutokeyK3011) Then
                    W3011 = D3011
                    W3011.QtyRequest = W3422.QtyPurchasing

                    Call REWRITE_PFK3011(W3011)
                End If

                Call DATA_MOVE_DEFAULT()
                Call WRITE_PFK3422(W3422)
            End If
skip:

        Next

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
                W3421.cdSite = txt_cdSite.Code
                W3421.DateInsert = System_Date_8()
                W3421.InchargeInsert = Pub.SAW
                Call DATA_MOVE_DEFAULT()

                If WRITE_PFK3421(W3421) = True Then
                    Call DATA_MOVE_WRITE01()

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
                W3421.cdSite = txt_cdSite.Code
                W3421.DateUpdate = System_Date_8()
                W3421.InchargeUpdate = Pub.SAW
                Call DATA_MOVE_DEFAULT()
                If REWRITE_PFK3421(W3421) = True Then
                    Call DATA_MOVE_WRITE01()

                    isudCHK = True
                    Me.Dispose()
                End If
            End If
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_UPDATE")
        End Try
    End Sub

    Private Sub DATA_MOVE_WRITE01_AFTER()

        Dim i As Integer
        Dim j As Integer
        j = 0
        For i = 0 To Vs1.ActiveSheet.RowCount - 1
            If Trim(getData(Vs1, getColumIndex(Vs1, "MaterialCode"), i)) = "" Then GoTo skip

            j = j + 1
            If READ_PFK3422(L3422.FactOrderNo, getData(Vs1, getColumIndex(Vs1, "KEY_FactOrderSeq"), i)) = True Then
                W3422 = D3422
                W3422.QtyPurchasing = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyPurchasing"), i))
                W3422.Remark = CDecp(getData(Vs1, getColumIndex(Vs1, "Remark"), i))

                Call REWRITE_PFK3422(W3422)

            End If
skip:

        Next

    End Sub

    Private Sub DATA_UPDATE_AFTER()
        If MsgBoxPPW("Please type the password to modify!", const_pwPO) = False Then Exit Sub

        Try
            If READ_PFK3421(L3421.FactOrderNo) = True Then
                W3421 = D3421
                W3421.Remark = txt_Remark.Data

                If REWRITE_PFK3421(W3421) = True Then
                    isudCHK = True
                    Call DATA_MOVE_WRITE01_AFTER()

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

                If W3422.CheckPurchasing <> "1" Then MsgBoxP("Can not delete this ! This is Valided order !") : Exit Function
                If W3422.QtyWarehouse > 0 Then MsgBoxP("Can not Delete because of InBound Data") : Exit Function

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
        Dim Prefix As String = "PO"

        If _chk_CheckIOType = "1" Then

            Select Case _chk_CheckPurchasingOrder
                Case "1" : Prefix = "PO"
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
                W3422.FactOrderSeq = CInt(rd!MAX_MCODE + 1)
            End If

            rd.Close()

            L3422.FactOrderSeq = W3422.FactOrderSeq

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT_3422")
        End Try
    End Sub
    Private Sub FORM_INIT()
        cmb_CheckInPurchasingOrder.Enabled = False
        cmb_CheckOutPurchasingOrder.Enabled = False
    End Sub

    Private Sub DATA_INIT()
        Try

            If READ_PFK7411(Pub.SAW) Then
                txt_InchargePurchasing.Data = D7411.Name
                txt_InchargePurchasing.Code = D7411.IDNO

                txt_InchargePurchasing.Enabled = False
            End If

            txt_FactOrderNo.Enabled = False

            txt_DateAccept.Data = Pub.DAT
            txt_DateDelivery.Data = Pub.DAT
            txt_DateExchange.Data = Pub.DAT
            txt_DateFinish.Data = Pub.DAT
            txt_DateStart.Data = Pub.DAT
            txt_DatePosted.Data = Pub.DAT

            txt_PriceExchange.Data = 1
            txt_cdUnitPrice.Data = "VND"
            txt_cdUnitPrice.Code = "001"

            txt_Destination.Data = ""

            rad_CheckProcessType1.Checked = True
            pan_Process.Enabled = False

            If _chk_CheckIOType = "1" Then
                rad_CheckIOType1.Checked = True
                cmb_CheckInPurchasingOrder.Visible = True
                cmb_CheckInPurchasingOrder.Enabled = False

                pan_ioType.Enabled = False

                txt_cdDepartment.Visible = False


            End If

            If _chk_CheckIOType = "2" Then
                rad_CheckIOType2.Checked = True
                cmb_CheckOutPurchasingOrder.Visible = True
                cmb_CheckInPurchasingOrder.Enabled = False

                pan_ioType.Enabled = False

                txt_cdDepartment.Visible = True


            End If

            If _chk_CheckIOType = "1" Then cmb_CheckInPurchasingOrder.InSelected = CIntp_S(_chk_CheckPurchasingOrder) - 1
            If _chk_CheckIOType = "2" Then cmb_CheckOutPurchasingOrder.InSelected = CIntp_S(_chk_CheckPurchasingOrder) - 1

            rad_CheckRelationType2.Checked = True

            Setfocus(txt_cdBuyingType)
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INIT")
        End Try

    End Sub

    Private Function Data_Check() As Boolean
        Data_Check = True
        Dim i As Integer

        Try
            For i = 0 To Vs1.ActiveSheet.RowCount - 1
                If FormatCut(getData(Vs1, getColumIndex(Vs1, "MaterialName"), i)) = "" Then MsgBoxP("Material Name at Line" & (i + 1)) : Exit Function
                If FormatCut(getData(Vs1, getColumIndex(Vs1, "cdUnitMaterial"), i)) = "" Then MsgBoxP("UnitMaterial Name at Line" & (i + 1)) : Exit Function

                If FormatCut(getData(Vs1, getColumIndex(Vs1, "cdDepartment"), i)) = "" Then setData(Vs1, getColumIndex(Vs1, "cdDepartment"), i, txt_cdDepartment.Code)
                If FormatCut(getData(Vs1, getColumIndex(Vs1, "cdTax"), i)) = "" Then MsgBoxP("Tax Name at Line" & (i + 1)) : Exit Function

                If FormatCut(getData(Vs1, getColumIndex(Vs1, "cdUnitPrice"), i)) = "" Then MsgBoxP("Unit Price Name at Line" & (i + 1)) : Exit Function
                If FormatCut(getData(Vs1, getColumIndex(Vs1, "cdUnitPacking"), i)) = "" Then MsgBoxP("Unit Packing at Line" & (i + 1)) : Exit Function

            Next

        Catch ex As Exception
            MsgBox("Data_Check !")
        End Try
    End Function

    Private Sub HideColumn()
        Try
            Dim ListColumn As New List(Of Integer)

            ListColumn.Add(getColumIndex(Vs1, "AutokeyK3422"))
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
                '---------------Data Check ==>>  Insert 
                If _chk_CheckIOType = "1" Then
                    If CheckData_Department(Me.FindForm.FindCode("cdDepartment").Code(), wJOB) = False Then
                        MsgBox("No Correct Department !")
                        Exit Sub
                    End If
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

                wJOB = 3
                Call DATA_SEARCH_VS1()
                Call HideColumn()

            Case 2
                Me.Dispose()
            Case 3
                If _chk_CheckIOType = "1" Then
                    If CheckData_Incharge(Me.FindForm.FindCode("InchargePurchasing").Code(), wJOB) = False Then
                        MsgBox("No Correct InchargePurchasing !")
                        Exit Sub
                    End If
                End If

                If DataCheck(Me, "PFK3421") = False Then Exit Sub
                If Data_Check() = False Then Exit Sub

                Call DATA_UPDATE()
            Case 4
                If CheckData_Incharge(Me.FindForm.FindCode("InchargePurchasing").Code(), wJOB) = False Then
                    MsgBox("No Correct InchargePurchasing !")
                    Exit Sub
                End If

                Call DATA_DELETE()

            Case 5
                If CheckData_Incharge(Me.FindForm.FindCode("InchargePurchasing").Code(), wJOB) = False Then
                    MsgBox("No Correct InchargePurchasing !")
                    Exit Sub
                End If

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
        If CheckData_Incharge(Me.FindForm.FindCode("InchargePurchasing").Code(), wJOB) = False Then
            MsgBox("No Correct InchargePurchasing !")
            Exit Sub
        End If

        If txt_DateAccept.Data <> Pub.DAT Then
            MsgBoxP("Can not edit because of not today!")
            If MsgBoxPPW("Please type the password to modify!", const_pwPO) = False Then Exit Sub
        End If

        Dim str As String = MsgBoxP("Do you want to delete it?", vbYesNo)

        If str <> vbYes Then Exit Sub

        Call DATA_DELETE()
    End Sub

    Private Sub Vs1_ButtonClicked(sender As Object, e As EditorNotifyEventArgs) Handles Vs1.ButtonClicked
        Dim xCOL As Integer
        Dim xROW As Integer
        Dim i As Integer
        Dim Value1() As String
        Dim Value2(5) As String

        xROW = e.Row
        xCOL = e.Column

        Select Case xCOL
            Case getColumIndex(Vs1, "cdMaterialCode_NoLink")
                If rad_CheckRelationType1.Checked = True Then

                    If HLP3011A_P.Link_HLP3011Material = True Then

                        If hlp0000SeVa = "" Then Exit Sub
                        Value1 = hlp0000SeVa.Split("|")

                        For i = 0 To Value1.Length - 1
                            Value2 = Value1(i).Split(",")
                            If READ_PFK3011(Value2(0)) = True Then
                                Vs1.ActiveSheet.RowCount += 1

                                If READ_PFK7231(D3011.Materialcode) = True Then
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

                                    setData(sender, getColumIndex(Vs1, "AutokeyK3011"), xROW, D3011.Autokey)
                                    setData(sender, getColumIndex(Vs1, "PRNo"), xROW, D3011.PRNo)

                                    setData(sender, getColumIndex(Vs1, "QtyPurchasing"), xROW, D3011.QtyPurchasing)
                                    setData(sender, getColumIndex(Vs1, "PRQtyPurchasing"), xROW, D3011.QtyPurchasing)

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
                ElseIf rad_CheckRelationType2.Checked = True Then
                    Dim f As New PeaceForm
                    f = New HLP7231C
                    f.ShowDialog()
                    If hlp0000SeVaTt = "" Then Exit Sub

                    Call READ_PFK7231(hlp0000SeVaTt)

                    setData(sender, getColumIndex(Vs1, "MaterialCode"), xROW, D7231.MaterialCode)
                    setData(sender, getColumIndex(Vs1, "MaterialName"), xROW, D7231.MaterialName)
                    setData(sender, getColumIndex(Vs1, "QtyBasic"), xROW, D7231.QtyBasic)

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

                    setData(Vs1, getColumIndex(Vs1, "DateExchange"), xROW, txt_DateExchange.Data)
                    setData(Vs1, getColumIndex(Vs1, "DateDelivery"), xROW, txt_DateDelivery.Data)
                    setData(Vs1, getColumIndex(Vs1, "DateFinish"), xROW, txt_DateFinish.Data)
                    setData(Vs1, getColumIndex(Vs1, "DateStart"), xROW, txt_DateStart.Data)

                End If


            Case getColumIndex(Vs1, "CLcdMaterialCode_In")
                Dim f As New PeaceForm
                f = New HLP7231I
                f.ShowDialog()

                If Array_hlp0000SeVaTt.Count = 0 Then Exit Sub

                Dim j As Integer = -1

                For i = 0 To Array_hlp0000SeVaTt.Count - 1
                    If READ_PFK7231(Array_hlp0000SeVaTt(i)) Then
                        j += 1

                        If xROW + j = Vs1.ActiveSheet.RowCount - 1 Then
                            Vs1.ActiveSheet.RowCount += 1
                        End If

                        setData(sender, getColumIndex(Vs1, "ColorName"), xROW, Array_hlp0000SeVaTt1(i))

                        setData(sender, getColumIndex(Vs1, "MaterialCode"), xROW, D7231.MaterialCode)
                        setData(sender, getColumIndex(Vs1, "MaterialName"), xROW, D7231.MaterialName)
                        setData(sender, getColumIndex(Vs1, "QtyBasic"), xROW, D7231.QtyBasic)

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

                        setData(Vs1, getColumIndex(Vs1, "DateExchange"), xROW, txt_DateExchange.Data)
                        setData(Vs1, getColumIndex(Vs1, "DateDelivery"), xROW, txt_DateDelivery.Data)
                        setData(Vs1, getColumIndex(Vs1, "DateFinish"), xROW, txt_DateFinish.Data)
                        setData(Vs1, getColumIndex(Vs1, "DateStart"), xROW, txt_DateStart.Data)

                        xROW = xROW + 1

                    End If
                Next


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

            If xCOL = getColumIndex(sender, "MaterialName") Then
                TranValue = getData(sender, xCOL, xROW)

                If IsNumeric(TranValue) Then
                    If READ_PFK7231_CODE(TranValue) = True Then

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

                        setData(sender, getColumIndex(Vs1, "AutokeyK3011"), xROW, D3011.Autokey)
                        setData(sender, getColumIndex(Vs1, "PRNo"), xROW, D3011.PRNo)

                        setData(sender, getColumIndex(Vs1, "QtyPurchasing"), xROW, D3011.QtyPurchasing)
                        setData(sender, getColumIndex(Vs1, "PRQtyPurchasing"), xROW, D3011.QtyPurchasing)

                        GoTo KeyTab7

                    End If
                Else
                    If READ_PFK7231_NAME(TranValue) = True Then
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

                        setData(sender, getColumIndex(Vs1, "AutokeyK3011"), xROW, D3011.Autokey)
                        setData(sender, getColumIndex(Vs1, "PRNo"), xROW, D3011.PRNo)

                        setData(sender, getColumIndex(Vs1, "QtyPurchasing"), xROW, D3011.QtyPurchasing)
                        setData(sender, getColumIndex(Vs1, "PRQtyPurchasing"), xROW, D3011.QtyPurchasing)

                        GoTo KeyTab7

                    End If
                End If

                If HLP7231C.Link_HLP7231C(TranValue) = False Then
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

                    setData(sender, getColumIndex(Vs1, "AutokeyK3011"), xROW, D3011.Autokey)
                    setData(sender, getColumIndex(Vs1, "PRNo"), xROW, D3011.PRNo)

                    setData(sender, getColumIndex(Vs1, "QtyPurchasing"), xROW, D3011.QtyPurchasing)
                    setData(sender, getColumIndex(Vs1, "PRQtyPurchasing"), xROW, D3011.QtyPurchasing)
                    Exit Sub
                End If

                If READ_PFK7231(hlp0000SeVaTt) Then
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

                    setData(sender, getColumIndex(Vs1, "AutokeyK3011"), xROW, D3011.Autokey)
                    setData(sender, getColumIndex(Vs1, "PRNo"), xROW, D3011.PRNo)

                    setData(sender, getColumIndex(Vs1, "QtyPurchasing"), xROW, D3011.QtyPurchasing)
                    setData(sender, getColumIndex(Vs1, "PRQtyPurchasing"), xROW, D3011.QtyPurchasing)

                    GoTo KeyTab7
                End If
            End If

KeyTab7:
        Catch ex As Exception

        End Try

    End Sub

    Private Sub vSChange(xROW As Integer)
        If wJOB = 2 Then Exit Sub

        If CheckData_Incharge(Me.FindForm.FindCode("InchargePurchasing").Code(), wJOB) = False Then
            MsgBox("No Correct InchargePurchasing !")
            Exit Sub
        End If

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
                If CheckData_Incharge(Me.FindForm.FindCode("InchargePurchasing").Code(), wJOB) = False Then
                    MsgBox("No Correct InchargePurchasing !")
                    Exit Sub
                End If

                W3422.FactOrderNo = txt_FactOrderNo.Data
                W3422.FactOrderSeq = getData(Vs1, getColumIndex(Vs1, "KEY_FactOrderSeq"), xROW)

                If READ_PFK3422(W3422.FactOrderNo, W3422.FactOrderSeq) = True Then
                    If D3422.CheckPurchasing <> "1" Then MsgBox("Check condition at row " & xROW) : Exit Sub
                    If CDblp(D3422.QtyWarehouse) > 0 Then MsgBox("Check condition at row " & xROW) : Exit Sub

                    Msg_Result = MsgBoxP("Do you want to delete?", vbYesNo)

                    If Msg_Result <> vbYes Then Exit Sub

                    If txt_DateAccept.Data <> Pub.DAT Then
                        MsgBoxP("Can not edit because of not today!")
                        If MsgBoxPPW("Please type the password to modify!", const_pwPO) = False Then Exit Sub
                    End If

                    If DELETE_PFK3422(D3422) Then
                        Call Delete_History("PFK3422", W3422.FactOrderNo & "-" & W3422.FactOrderSeq.ToString)

                        If READ_PFK3011(D3422.AutokeyK3011) Then
                            W3011 = D3011
                            W3011.QtyRequest = 0

                            Call REWRITE_PFK3011(W3011)
                        End If

                        If READ_PFK3422_1(L3421.FactOrderNo) = False Then
                            If READ_PFK3421(L3421.FactOrderNo) = True Then
                                W3421 = D3421

                                If DELETE_PFK3421(W3421) = True Then

                                    Call Delete_History("PFK3421", W3421.FactOrderNo)

                                    isudCHK = True
                                    Me.Dispose()
                                End If

                            End If

                        End If

                    End If

                    SPR_DEL(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex)

                Else

                    SPR_DEL(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex)

                End If

                Vs1.Focus()

            Case Keys.Enter
                Select Case xCOL
                    Case getColumIndex(sender, "cdMaterialCode")

                        If CheckData_Incharge(Me.FindForm.FindCode("InchargePurchasing").Code(), wJOB) = False Then
                            MsgBox("No Correct InchargePurchasing !")
                            Exit Sub
                        End If

                        If rad_CheckRelationType1.Checked = True Then

                            If HLP3011A_P.Link_HLP3011Material = True Then
                                If hlp0000SeVa = "" Then Exit Sub
                                Value1 = hlp0000SeVa.Split("|")

                                For i = 0 To Value1.Length - 1
                                    Value2 = Value1(i).Split(",")
                                    If READ_PFK3011(Value2(0)) = True Then
                                        Vs1.ActiveSheet.RowCount += 1

                                        If READ_PFK7231(D3011.Materialcode) = True Then
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

                                            setData(sender, getColumIndex(Vs1, "AutokeyK3011"), xROW, D3011.Autokey)
                                            setData(sender, getColumIndex(Vs1, "PRNo"), xROW, D3011.PRNo)

                                            setData(sender, getColumIndex(Vs1, "QtyPurchasing"), xROW, D3011.QtyPurchasing)
                                            setData(sender, getColumIndex(Vs1, "PRQtyPurchasing"), xROW, D3011.QtyPurchasing)

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

                        Else
                            Dim f As New PeaceForm
                            f = New HLP7231C
                            f.ShowDialog()
                            If hlp0000SeVaTt = "" Then Exit Sub

                            Call READ_PFK7231(hlp0000SeVaTt)

                            setData(sender, getColumIndex(Vs1, "MaterialCode"), xROW, D7231.MaterialCode)
                            setData(sender, getColumIndex(Vs1, "MaterialName"), xROW, D7231.MaterialName)
                            setData(sender, getColumIndex(Vs1, "QtyBasic"), xROW, D7231.QtyBasic)

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

                            setData(Vs1, getColumIndex(Vs1, "DateExchange"), xROW, txt_DateExchange.Data)
                            setData(Vs1, getColumIndex(Vs1, "DateDelivery"), xROW, txt_DateDelivery.Data)
                            setData(Vs1, getColumIndex(Vs1, "DateFinish"), xROW, txt_DateFinish.Data)
                            setData(Vs1, getColumIndex(Vs1, "DateStart"), xROW, txt_DateStart.Data)

                        End If


                    Case getColumIndex(Vs1, "DateDelivery"), getColumIndex(Vs1, "DateStart"), getColumIndex(Vs1, "DateFinish")

                        If CheckData_Incharge(Me.FindForm.FindCode("InchargePurchasing").Code(), wJOB) = False Then
                            MsgBox("No Correct InchargePurchasing !")
                            Exit Sub
                        End If

                        If CALENDAR_SINGLE.CALENDAR_SINGLE_Link(getData(Vs1, xCOL, xROW)) = False Then Exit Sub
                        If CIntp(syearn) = 0 Or CIntp(smonth) = 0 Or CIntp(sday) = 0 Then Exit Sub

                        Dim CalDate As String
                        CalDate = syearn.ToString & smonth.ToString("00") & sday.ToString("00")
                        setData(Vs1, xCOL, xROW, FSDate(CalDate))
                        setCell(Vs1, xCOL, xROW, CalDate)
                        Vs1.ActiveSheet.ActiveColumnIndex += 1 : Vs1.ActiveSheet.ActiveRowIndex = xROW

                        Vs1.Focus()
                End Select

                Call vSChange(xROW)
            Case Keys.Insert
                If CheckData_Incharge(Me.FindForm.FindCode("InchargePurchasing").Code(), wJOB) = False Then
                    MsgBox("No Correct InchargePurchasing !")
                    Exit Sub
                End If

        End Select

    End Sub

    Private Sub rad_CheckIOType1_CheckedChanged(sender As Object, e As EventArgs) Handles rad_CheckIOType1.CheckedChanged, rad_CheckIOType2.CheckedChanged
        If rad_CheckIOType1.Checked = True Then
            '           rad_CheckProcessType1.Checked = True

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

#End Region



    
End Class
