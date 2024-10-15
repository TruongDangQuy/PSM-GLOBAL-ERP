Public Class ISUD3421F

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
    Private _Department As String

    Private chk_Auto As Boolean = False

#End Region

#Region "Link"
    Public Function Link_ISUD3421F(job As Integer, FactOrderNo As String, chk_CheckIOType As String, chk_CheckPurchasingOrder As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        D3421.FactOrderNo = FactOrderNo
        D3422.FactOrderNo = FactOrderNo

        _chk_CheckIOType = chk_CheckIOType
        _chk_CheckPurchasingOrder = chk_CheckPurchasingOrder

        If chk_CheckIOType = "2" And chk_CheckPurchasingOrder = "1" Then
      
        End If

        wJOB = job : L3421 = D3421 : L3422 = D3422

        Link_ISUD3421F = False
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
                    cmd_Refresh.Visible = False
                    cmd_Explaination.Visible = False
            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD3421F = isudCHK


        Catch ex As Exception
            Call MsgBoxP("61", WordConv("Request Order Processing"))
        End Try


    End Function

    Public Function Link_ISUD3421F_AUTO(job As Integer, JobCard As String, OrderNo As String, OrderNoSeq As String, chk_CheckIOType As String, chk_CheckPurchasingOrder As String,
                                        Optional ByVal Department As String = "",
                                        Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        D3422.JobCard = JobCard

        D3422.OrderNo = OrderNo
        D3422.OrderNoSeq = OrderNoSeq

        txt_JobCard.Data = JobCard
        txt_OrderNo.Data = OrderNo
        txt_OrderNoSeq.Data = OrderNoSeq

        _chk_CheckIOType = chk_CheckIOType
        _chk_CheckPurchasingOrder = chk_CheckPurchasingOrder
        _Department = Department

        If chk_CheckIOType = "2" And chk_CheckPurchasingOrder = "1" Then
          
        End If

        If READ_PFK1312(OrderNo, OrderNoSeq) Then
            Call READ_PFK7106(D1312.ShoesCode)
            txt_Article.Data = D7106.Article
            txt_cdSite.Code = D7106.cdSeason
            txt_CustomerCode.Code = D7106.Customercode

            Call READ_PFK7171(ListCode("Season"), D7106.cdSeason)
            txt_cdSite.Data = D7171.BasicName

            Call READ_PFK7101(D7106.Customercode)
            txt_CustomerCode.Data = D7101.CustomerNameSimply
        End If

        chk_Auto = True

        wJOB = job : L3421 = D3421 : L3422 = D3422

        Link_ISUD3421F_AUTO = False
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

            Link_ISUD3421F_AUTO = isudCHK


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
                If CHK(1) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                cmd_DEL.Visible = False

                Call KEY_COUNT()

                If chk_Auto = True Then
                    Call DATA_SEARCH_VS0_AUTO()
                Else
                    Call DATA_SEARCH_VS0()
                    Call DATA_SEARCH_VS1()
                End If


            Case 2
                Me.Text = Me.Text & " - SEARCH"
                If CHK(2) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                cmd_DEL.Visible = False
                cmd_OK.Visible = False

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS0()
                Call DATA_SEARCH_VS1()

                pcl_CheckField.Enabled = False

                '----------------------------------------------------------------------------------------------------- Start
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
                '---------------------------------------------------------------------------------------------------- End

            Case 3
                Me.Text = Me.Text & " - UPDATE"
                If CHK(3) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                txt_FactOrderNo.Enabled = False
                cmd_DEL.Visible = False

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS0()
                Call DATA_SEARCH_VS1()
                pcl_CheckField.Enabled = False

                '----------------------------------------------------------------------------------------------------- Start
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
                '---------------------------------------------------------------------------------------------------- End
            Case 4
                Me.Text = Me.Text & " - DELETE"
                If CHK(4) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                cmd_OK.Visible = False

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS0()
                Call DATA_SEARCH_VS1()

                pcl_CheckField.Enabled = False
                '----------------------------------------------------------------------------------------------------- Start
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
                '---------------------------------------------------------------------------------------------------- End


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
                cmd_DEL.Visible = False

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS1()

                pcl_CheckField.Enabled = False

                '----------------------------------------------------------------------------------------------------- Start
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
                '---------------------------------------------------------------------------------------------------- End
        End Select

        formA = True

    End Sub
#End Region

#Region "Search"
    Private Function DATA_SEARCH01() As Boolean
        DATA_SEARCH01 = False

        DS1 = PrcDS("USP_ISUD3421F_SEARCH_HEAD", cn, L3421.FactOrderNo)

        If GetDsRc(DS1) = 0 Then
            Exit Function
            isudCHK = False
        End If

        Call STORE_MOVE(Me, DS1)


        cmb_CheckOutPurchasingOrder.InSelected = CIntp_S(GetDsData(DS1, 0, "CheckOutPurchasingOrder")) - 1

        DATA_SEARCH01 = True

    End Function
    Private Function DATA_SEARCH_VS0() As Boolean
        DATA_SEARCH_VS0 = False
        Try
            DS1 = PrcDS("USP_ISUD3421F_SEARCH_VS0_AUTO", cn, L3422.JobCard, L3422.OrderNo, L3422.OrderNoSeq)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS0, DS1, "USP_ISUD3421F_SEARCH_VS0", "VS0")
                vS0.ActiveSheet.RowCount = 1
                vS0.Enabled = True
                Exit Function
            End If

            Call SPR_PRO_NEW(vS0, DS1, "USP_ISUD3421F_SEARCH_VS0", "VS0")
            Call VsSizeRangeNew_one(vS0, "USP_VS_SIZERANGE_ORDERBASE", getColumIndex(vS0, "SizeQty01"), getData(vS0, getColumIndex(vS0, "OrderNo"), vS0.ActiveSheet.ActiveRowIndex), getData(vS0, getColumIndex(vS0, "OrderNoSeq"), vS0.ActiveSheet.ActiveRowIndex))

            DATA_SEARCH_VS0 = True

        Catch ex As Exception

        End Try
    End Function

    Private Function DATA_SEARCH_VS0_AUTO() As Boolean
        DATA_SEARCH_VS0_AUTO = False
        Try
            L3422.JobCard = txt_JobCard.Data
            DS1 = PrcDS("USP_ISUD3421F_SEARCH_VS0_AUTO", cn, L3422.JobCard, L3422.OrderNo, L3422.OrderNoSeq)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS0, DS1, "USP_ISUD3421F_SEARCH_VS0", "VS0")
                vS0.Enabled = True
                Exit Function
            End If
            SPR_PRO_NEW(vS0, DS1, "USP_ISUD3421F_SEARCH_VS0", "VS0")

            Call VsSizeRangeNew_one(vS0, "USP_VS_SIZERANGE_ORDERBASE", getColumIndex(vS0, "SizeQty01"), L3422.OrderNo, L3422.OrderNoSeq)

            DATA_SEARCH_VS0_AUTO = True

        Catch ex As Exception

        End Try
    End Function
    Private Function DATA_SEARCH_VS1() As Boolean
        DATA_SEARCH_VS1 = False
        Try
            Dim i As Integer

            DS1 = PrcDS("USP_ISUD3421F_SEARCH_VS1", cn, L3421.FactOrderNo)
            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs1, DS1, "USP_ISUD3421F_SEARCH_VS1", "Vs1")
                Vs1.ActiveSheet.RowCount = 1
                Vs1.Enabled = True
                Exit Function
            End If
            SPR_PRO_NEW(Vs1, DS1, "USP_ISUD3421F_SEARCH_VS1", "Vs1")

            For i = 0 To Vs1.ActiveSheet.RowCount - 1
                If CDblp(getData(Vs1, getColumIndex(Vs1, "QtyWarehouse"), i)) > 0 Then
                    pan_ioType.Enabled = False
                End If

                Call SPR_ChkLock(Vs1, False, getColumIndex(Vs1, "QtyPurchasing"))
            Next

            DATA_SEARCH_VS1 = True

        Catch ex As Exception

        End Try
    End Function
    Private Function DATA_SEARCH_VS1_AUTO() As Boolean
        DATA_SEARCH_VS1_AUTO = False
        Try

            If READ_PFK3421(L3421.FactOrderNo) = True Then
                DS1 = PrcDS("USP_ISUD3421F_SEARCH_VS1_AUTO_F2", cn, L3422.JobCard, L3422.OrderNo, L3422.OrderNoSeq, "000", txt_cdLargeGroupMaterial.Code, txt_cdSubProcess.Code, L3421.FactOrderNo)
            Else
                DS1 = PrcDS("USP_ISUD3421F_SEARCH_VS1_AUTO_F3", cn, L3422.JobCard, L3422.OrderNo, L3422.OrderNoSeq, "000", txt_cdLargeGroupMaterial.Code, txt_cdSubProcess.Code)
            End If



            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs1, DS1, "USP_ISUD3421F_SEARCH_VS1_AUTO_F3", "Vs1")
                Vs1.Enabled = True
                Exit Function
            End If
            SPR_PRO_NEW(Vs1, DS1, "USP_ISUD3421F_SEARCH_VS1_AUTO_F3", "Vs1")


            DATA_SEARCH_VS1_AUTO = True

        Catch ex As Exception

        End Try
    End Function

#End Region

#Region "Function"
    Private Sub DATA_MOVE_DEFAULT()
        W3421.seBuyingType = ListCode("BuyingType")
        W3421.seCommercialTerm = ListCode("CommercialTerm")
        W3421.selUnitPrice = ListCode("UnitPrice")
        W3421.seOrigin = ListCode("Origin")
        W3421.seSeason = ListCode("Season")

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
        W3422.seGroupComponent = ListCode("GroupComponent")

        W3422.seSubProcess = ListCode("SubProcess")
        W3422.seLineProd = ListCode("LineProd")
        W3422.seFactory = ListCode("Factory")

    End Sub

    Private Sub DATA_MOVE_WRITE01()

        Dim i As Integer
        Dim j As Integer
        j = 0
        For i = 0 To Vs1.ActiveSheet.RowCount - 1

            If getDataM(Vs1, getColumIndex(Vs1, "Dchk"), i) = "1" Then

                If Trim(getData(Vs1, getColumIndex(Vs1, "MaterialCode"), i)) = "" Then GoTo skip

                j = j + 1
                If K3422_MOVE(Vs1, i, W3422, L3422.FactOrderNo, CDecp(getData(Vs1, getColumIndex(Vs1, "KEY_FactOrderSeq"), i))) = True Then
                    W3422.Dseq = j
                    W3422.Pseq = CInt(getData(Vs1, getColumIndex(Vs1, "Key_Pseq"), i))

                    W3422.QtyPurchasing = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyPurchasing"), i))
                    W3422.PackPurchasing = CDecp(getData(Vs1, getColumIndex(Vs1, "PackPurchasing"), i))
                    W3422.QtyBasic = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyBasic"), i))

                    If W3422.cdSite = "" Then W3422.cdSite = "001"
                    W3422.cdDepartment = txt_cdDepartment.Code
                    W3422.CustomerSupplier = txt_SupplierCode.Code
                    W3422.CheckRelationType = "1"

                    W3422.cdSubProcess = txt_cdSubProcess.Code
                    W3422.cdGroupComponent = "000"
                    W3422.cdLineProd = txt_cdLineProd.Code

                    If READ_PFK3011(W3422.AutokeyK3011) Then
                        W3011 = D3011
                        W3011.QtyRequest = W3422.QtyPurchasing
                        Call REWRITE_PFK3011(W3011)
                    End If

                    Call DATA_MOVE_DEFAULT()
                    Call REWRITE_PFK3422(W3422)
                Else
                    W3422.FactOrderNo = L3421.FactOrderNo
                    W3422.Dseq = j
                    W3422.Pseq = CInt(getData(Vs1, getColumIndex(Vs1, "Key_Pseq"), i))
                    W3422.CustomerSupplier = txt_SupplierCode.Code

                    Call KEY_COUNT_3422()

                    W3422.CheckPurchasing = "1"
                    W3422.CheckRelationType = "1"
                    W3422.DateAccept = txt_DateAccept.Data

                    If W3422.cdSite = "" Then W3422.cdSite = "001"
                    W3422.QtyPurchasing = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyPurchasing"), i))
                    W3422.PackPurchasing = CDecp(getData(Vs1, getColumIndex(Vs1, "PackPurchasing"), i))
                    W3422.QtyBasic = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyBasic"), i))

                    W3422.CheckComplete = "2"

                    W3422.cdDepartment = txt_cdDepartment.Code
                    W3422.cdSubProcess = txt_cdSubProcess.Code
                    W3422.cdGroupComponent = "000"
                    W3422.cdLineProd = txt_cdLineProd.Code

                    'If READ_PFK3011(W3422.AutokeyK3011) Then
                    '    W3011 = D3011
                    '    W3011.QtyRequest = W3422.QtyPurchasing

                    '    Call REWRITE_PFK3011(W3011)
                    'End If

                    Call DATA_MOVE_DEFAULT()
                    Call WRITE_PFK3422(W3422)
                End If
            End If
skip:

        Next

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

                Call REWRITE_PFK3422(W3422)

            End If
skip:

        Next

    End Sub

    Private Sub DATA_INSERT()

        Try
            If K3421_MOVE(Me, W3421, 1, L3421.FactOrderNo) = False Then

                Call KEY_COUNT()

                W3421.CheckInPurchasingOrder = "1"
                W3421.CheckOutPurchasingOrder = cmb_CheckOutPurchasingOrder.InSelected + 1
                W3421.CheckIOType = "2"
                W3421.CheckRelationType = "1"

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
                If rad_CheckIOType1.Checked = True Then W3421.CheckIOType = "1"
                If rad_CheckIOType2.Checked = True Then W3421.CheckIOType = "2"

                W3421.CheckIOType = "2"
                W3421.CheckInPurchasingOrder = "1"
                W3421.CheckOutPurchasingOrder = cmb_CheckOutPurchasingOrder.InSelected + 1
                W3421.CheckRelationType = "1"

                Call DATA_MOVE_DEFAULT()
                If REWRITE_PFK3421(W3421) = True Then
                    Call DATA_MOVE_WRITE01()

                    isudCHK = True

                End If
            End If
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_UPDATE")
        End Try
    End Sub

    Private Sub DATA_UPDATE_AFTER()
        If MsgBoxPPW("Please type the password to modify!", const_pwPO) = False Then Exit Sub

        Try
            If READ_PFK3421(L3421.FactOrderNo) = True Then
                W3421 = D3421
                W3421.cdSeason = txt_cdSite.Code
                W3421.CustomerCode = txt_CustomerCode.Code
                W3421.CheckRelationType = "1"

                W3421.seSeason = ListCode("Season")

                If REWRITE_PFK3421(W3421) = True Then
                    Call DATA_MOVE_WRITE01_AFTER()
                    isudCHK = True

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
        Dim Prefix As String = "OI"
        _chk_CheckIOType = "2"

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
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub
    Private Sub DATA_INIT()
        Try
            txt_DateAccept.Data = Pub.DAT
            txt_DatePosted.Data = Pub.DAT

            If READ_PFK7171(ListCode("Department"), _Department) = True Then
                txt_cdDepartmentPIC.Data = D7171.BasicName
                txt_cdDepartmentPIC.Code = D7171.BasicCode
                txt_cdDepartmentPIC.Enabled = False
            End If

            If READ_PFK7411(Pub.SAW) Then
                txt_InchargePurchasing.Data = D7411.Name
                txt_InchargePurchasing.Code = D7411.IDNO

                txt_InchargePurchasing.Enabled = False

                If READ_PFK7171(ListCode("Department"), D7411.cdDepartment) = True Then
                    txt_cdDepartmentPIC.Data = D7171.BasicName
                    txt_cdDepartmentPIC.Code = D7171.BasicCode
                    txt_cdDepartmentPIC.Enabled = False
                End If

            End If

            txt_FactOrderNo.Enabled = False

            If _chk_CheckIOType = "2" Then cmb_CheckOutPurchasingOrder.InSelected = CIntp_S(_chk_CheckPurchasingOrder) - 1

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INIT")
        End Try

    End Sub

    Private Sub FORM_INIT()
        cmb_CheckOutPurchasingOrder.Enabled = True
    End Sub

    Private Function Data_Check() As Boolean
        Data_Check = False
        Dim i As Integer

        Try
            For i = 0 To Vs1.ActiveSheet.RowCount - 1
                If txt_cdDepartment.Code = "" Then MsgBoxP("Department Pls!") : Exit Function
                If txt_cdSite.Code = "" Then MsgBoxP("Season Pls!") : Exit Function
                If txt_CustomerCode.Code = "" Then MsgBoxP("CustomerCode Pls!") : Exit Function
                If txt_cdSubProcess.Code = "" Then MsgBoxP("SubProcess Pls!") : Exit Function
                If txt_InchargePurchasing.Code = "" Then MsgBoxP("InchargePurchasing Pls!") : Exit Function

                If FormatCut(getData(Vs1, getColumIndex(Vs1, "MaterialName"), i)) = "" Then MsgBoxP("Material Name at Line" & (i + 1)) : Exit Function
                If FormatCut(getData(Vs1, getColumIndex(Vs1, "cdUnitMaterial"), i)) = "" Then MsgBoxP("UnitMaterial Name at Line" & (i + 1)) : Exit Function

            Next

            Data_Check = True
        Catch ex As Exception

        End Try
    End Function

#End Region

#Region "Event"
    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Select Case wJOB
            Case 1
                'If _chk_CheckIOType = "1" Then
                '    '---------------Data Check ==>>  Insert 
                '    If CheckData_Department(Me.FindForm.FindCode("cdDepartment").Code(), wJOB) = False Then
                '        MsgBox("No Correct Department !")
                '        Exit Sub
                '    End If
                'End If

                'If CheckData_Customer(Me.FindForm.FindCode("CustomerCode").Code(), wJOB) = False Then
                '    MsgBox("No Correct Customer !")
                '    Exit Sub
                'End If

                'If CheckData_Incharge(Me.FindForm.FindCode("InchargePurchasing").Code(), wJOB) = False Then
                '    MsgBox("No Correct InchargePurchasing !")
                '    Exit Sub
                'End If
                '----------------------------------------------------------------------------------------------------------

                If DataCheck(Me, "PFK3421") = False Then Exit Sub
                If Data_Check() = False Then Exit Sub
                Call KEY_COUNT()
                Call DATA_INSERT()

                wJOB = 3
                Call DATA_SEARCH_VS1()

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

        If txt_DateAccept.Data <> Pub.DAT Then
            MsgBoxP("Can not edit because of not today!")
            If MsgBoxPPW("Please type the password to modify!", const_pwPO) = False Then Exit Sub
        End If

        Call DATA_DELETE()
    End Sub

    Private Sub Vs1_ButtonClicked(sender As Object, e As EditorNotifyEventArgs) Handles Vs1.ButtonClicked
        Dim xCOL As Integer
        Dim xROW As Integer
        Dim i As Integer
        'Dim Value1() As String
        'Dim Value2(5) As String

        xROW = e.Row
        xCOL = e.Column

        Select Case xCOL
            Case getColumIndex(Vs1, "cdMaterialCode_NoLink")
                Dim f As New PeaceForm
                f = New HLP7231C
                f.ShowDialog()
                If hlp0000SeVaTt = "" Then Exit Sub

                Call READ_PFK7231(hlp0000SeVaTt)

                setData(sender, getColumIndex(Vs1, "MaterialCode"), xROW, D7231.MaterialCode)
                setData(sender, getColumIndex(Vs1, "MaterialName"), xROW, D7231.MaterialName + " " + D7231.MaterialPName)

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
        End Select

        vSChange(e.Row)
    End Sub


    Private Sub vSChange(xROW As Integer)
        If wJOB = 2 Then Exit Sub

        If CheckData_Incharge(Me.FindForm.FindCode("InchargePurchasing").Code(), wJOB) = False Then
            MsgBox("No Correct InchargePurchasing !")
            Exit Sub
        End If

        setData(Vs1, getColumIndex(Vs1, "seUnitPrice"), xROW, ListCode("UnitPrice"))
        If CDecp(getData(Vs1, getColumIndex(Vs1, "PackPurchasing"), xROW)) > 0 And getDataM(Vs1, getColumIndex(Vs1, "UnitBaseCheck"), xROW) = "1" Then
            Dim PackPurchasing As Decimal
            Dim QtyBasic As Decimal
            Dim QtyPurchasing As Decimal

            PackPurchasing = CDecp(getData(Vs1, getColumIndex(Vs1, "PackPurchasing"), xROW))
            QtyBasic = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyBasic"), xROW))
            QtyPurchasing = PackPurchasing * QtyBasic

            setData(Vs1, getColumIndex(Vs1, "QtyPurchasing"), xROW, QtyPurchasing)
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
                If CheckData_Incharge(Me.FindForm.FindCode("InchargePurchasing").Code(), wJOB) = False Then
                    MsgBox("No Correct InchargePurchasing !")
                    Exit Sub
                End If

                Msg_Result = MsgBoxP("Do you want to delete?", vbYesNo)

                If Msg_Result <> vbYes Then Exit Sub

                If txt_DateAccept.Data <> Pub.DAT Then
                    MsgBoxP("Can not edit because of not today!")
                    If MsgBoxPPW("Please type the password to modify!", const_pwPO) = False Then Exit Sub
                End If

                W3422.FactOrderNo = txt_FactOrderNo.Data
                W3422.FactOrderSeq = CDecp(getData(Vs1, getColumIndex(Vs1, "KEY_FactOrderSeq"), xROW))

                If READ_PFK3422(W3422.FactOrderNo, W3422.FactOrderSeq) = True Then
                    If D3422.CheckPurchasing <> "1" Then MsgBoxP("Check condition at row " & xROW) : Exit Sub
                    If CDblp(D3422.QtyWarehouse) > 0 Then MsgBoxP("Check condition at row " & xROW) : Exit Sub

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

                                    Call Delete_History("PFK3421", W3421.FactOrderNo)

                                    isudCHK = True
                                    Me.Dispose()
                                End If

                            End If

                        End If

                    End If

                End If

                SPR_DEL(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex)
                Vs1.Focus()

                Call vSChange(xROW)

            Case Keys.Insert
                If CheckData_Incharge(Me.FindForm.FindCode("InchargePurchasing").Code(), wJOB) = False Then
                    MsgBox("No Correct InchargePurchasing !")
                    Exit Sub
                End If
        End Select

    End Sub

    Private Sub cmd_Refresh_Click(sender As Object, e As EventArgs) Handles cmd_Refresh.Click
        cmd_DEL.Visible = True

        If wJOB = 1 Then DATA_SEARCH_VS1_AUTO() : cmd_OK.Visible = True
        If wJOB = 3 Then DATA_SEARCH_VS1() : cmd_OK.Visible = True

    End Sub

    Private Sub cmd_Explaination_Click(sender As Object, e As EventArgs) Handles cmd_Explaination.Click
        Try
            cmd_OK.Visible = False
            L3422.JobCard = txt_JobCard.Data

            DS1 = PrcDS("USP_ISUD3421F_SEARCH_VS1_AUTO_EXPLAIN", cn, L3422.JobCard, L3422.OrderNo, L3422.OrderNoSeq, "000", txt_cdLargeGroupMaterial.Code)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs1, DS1, "USP_ISUD3421F_SEARCH_VS1_AUTO_EXPLAIN", "Vs1")
                Vs1.Enabled = True
                Exit Sub
            End If
            SPR_PRO_NEW(Vs1, DS1, "USP_ISUD3421F_SEARCH_VS1_AUTO_EXPLAIN", "Vs1")

            Dim i As Integer
            Dim Str_Array() As String

            If READ_PFK3421(L3421.FactOrderNo) = True Then
                W3421 = D3421

                If FormatCut(W3421.ComponentList) <> "" Then
                    Str_Array = Replace(W3421.ComponentList, "''", "'").Split(",")

                End If
                For i = 0 To Vs1.ActiveSheet.RowCount - 1
                    If Str_Array.Contains("'" & getData(Vs1, getColumIndex(Vs1, "ComponentName"), i) & "'") Then
                        setData(Vs1, getColumIndex(Vs1, "dchk"), i, "1", , True)
                    End If
                Next

            End If



        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmd_ComponnetList_Refresh_Click(sender As Object, e As EventArgs) Handles cmd_ComponnetList_Refresh.Click
        Try
            cmd_OK.Visible = False
            L3422.JobCard = txt_JobCard.Data

            DS1 = PrcDS("USP_ISUD3421F_SEARCH_VS1_AUTO_EXPLAIN_COM", cn, L3422.JobCard, L3422.OrderNo, L3422.OrderNoSeq, "000", txt_cdLargeGroupMaterial.Code)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs1, DS1, "USP_ISUD3421F_SEARCH_VS1_AUTO_EXPLAIN_COM", "Vs1")
                Vs1.Enabled = True
                Exit Sub
            End If
            SPR_PRO_NEW(Vs1, DS1, "USP_ISUD3421F_SEARCH_VS1_AUTO_EXPLAIN_COM", "Vs1")

            Dim i As Integer
            Dim Str_Array() As String

            If READ_PFK3421(L3421.FactOrderNo) = True Then
                W3421 = D3421

                If FormatCut(W3421.ComponentList) <> "" Then
                    Str_Array = Replace(W3421.ComponentList, "''", "'").Split(",")

                End If
                For i = 0 To Vs1.ActiveSheet.RowCount - 1
                    If Str_Array.Contains("'" & getData(Vs1, getColumIndex(Vs1, "ComponentName"), i) & "'") Then
                        setData(Vs1, getColumIndex(Vs1, "dchk"), i, "1", , True)
                    End If
                Next

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmd_ComponnetList_Click(sender As Object, e As EventArgs) Handles cmd_ComponnetList.Click
        Try
            If cmd_OK.Visible = True Then Exit Sub

            Dim SpecNoList As String

            Dim SpecNoList_List As New List(Of String)

            Dim i As Integer

            For i = 0 To Vs1.ActiveSheet.RowCount - 1
                If getDataM(Vs1, getColumIndex(Vs1, "dchk"), i) <> "1" Then GoTo next1

                If SpecNoList_List.Contains(getData(Vs1, getColumIndex(Vs1, "ComponentName"), i)) = False Then
                    SpecNoList_List.Add(getData(Vs1, getColumIndex(Vs1, "ComponentName"), i))
                    SpecNoList = SpecNoList & "'" & FormatSQL(getData(Vs1, getColumIndex(Vs1, "ComponentName"), i)) & "'"
                    SpecNoList = SpecNoList & ","

                End If
next1:
            Next


            If SpecNoList = "" Then Exit Sub
            SpecNoList = Strings.Left(SpecNoList, Len(SpecNoList) - 1)

            If K3421_MOVE(Me, W3421, 1, L3421.FactOrderNo) = False Then

                Call KEY_COUNT()

                W3421.CheckInPurchasingOrder = "1"
                W3421.CheckOutPurchasingOrder = cmb_CheckOutPurchasingOrder.InSelected + 1
                W3421.CheckIOType = "2"
                W3421.CheckRelationType = "1"

                Call DATA_MOVE_DEFAULT()

                If WRITE_PFK3421(W3421) = True Then
                    isudCHK = True : WRITE_CHK = "*"

                End If

            End If

            If READ_PFK3421(L3421.FactOrderNo) = True Then
                W3421 = D3421
                W3421.ComponentList = SpecNoList
                If REWRITE_PFK3421(W3421) = True Then
                    isudCHK = True
                    MsgBoxP("Update Successfully !", vbInformation)
                End If
            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmd_ComponnetListCLR_Click(sender As Object, e As EventArgs) Handles cmd_ComponnetListCLR.Click
        Try
            If READ_PFK3421(L3421.FactOrderNo) = True Then
                W3421 = D3421
                W3421.ComponentList = ""
                If REWRITE_PFK3421(W3421) = True Then

                    MsgBoxP("Clear Successfully !", vbInformation)
                    cmd_ComponnetList_Refresh.PerformClick()
                    isudCHK = True
                End If
            End If


        Catch ex As Exception

        End Try
    End Sub

#End Region

    
End Class