Public Class ISUD2345A

#Region "Variable"
    Private wJOB As Integer

    Private W2345 As New T2345_AREA
    Private L2345 As New T2345_AREA

    Private W2346 As New T2346_AREA
    Private L2346 As New T2346_AREA


    Private WRITE_CHK As String
    Private List_AutoKey As String = ""

    Private formA As Boolean
    Private CHK(0 To 5) As String

    Private Chk_AutoLink As Boolean = False
    Private pri_CustomerCode As String


    Private L_SupplierCode As String
    Private L_CustomerCode As String
    Private L_cdSeason As String
    Private L_Line As String
    Private L_cdLargeGroupMaterial As String
    Private L_cdSemiGroupMaterial As String
    Private L_checkSample As String
#End Region

#Region "Link"
    Public Function Link_ISUD2345A(job As Integer, FactOrderNo As String, Optional ByVal TAG As String = "") As Boolean
        Link_ISUD2345A = False

        Try
            Me.Tag = TAG
            D2345.FactOrderNo = FactOrderNo
            D2346.FactOrderNo = FactOrderNo

            wJOB = job : L2345 = D2345 : L2346 = D2346



            Select Case job
                Case 1
                Case Else
                    If READ_PFK2345(L2345.FactOrderNo) = False Then
                        MsgBox("Error ==>> Try your actions again Data!")

                        Me.Dispose()
                        Exit Function
                    Else
                        L2345 = D2345
                    End If

                    pri_CustomerCode = L2345.CustomerCode

                    txt_DateAccept.Enabled = True
            End Select


            formA = False
            Me.ShowDialog()

            Link_ISUD2345A = isudCHK
        Catch ex As Exception
            Call MsgBoxP("61", WordConv("Request Order Processing"))
        End Try
    End Function


    Public Function Link_ISUD2345A_AUTO(job As Integer, cdSeason As String, CustomerCode As String, SupplierCode As String, _Line As String, _cdLargeGroupMaterial As String, _cdSemiGroupMaterial As String, _checkSample As String, FactOrderNo As String, Optional ByVal TAG As String = "") As Boolean
        Link_ISUD2345A_AUTO = False

        Try
            Me.Tag = TAG
            Chk_AutoLink = True

            D2345.SupplierCode = SupplierCode
            D2345.cdSeason = cdSeason
            D2345.FactOrderNo = FactOrderNo

            L_SupplierCode = SupplierCode
            L_CustomerCode = CustomerCode
            L_cdSeason = cdSeason
            L_Line = _Line
            L_cdLargeGroupMaterial = _cdLargeGroupMaterial
            L_cdSemiGroupMaterial = _cdSemiGroupMaterial
            L_checkSample = _checkSample

            If READ_PFK7101(SupplierCode) Then
                txt_SupplierCode.Data = D7101.CustomerName
                txt_SupplierCode.Code = D7101.CustomerCode
                txt_SupplierCode.Enabled = False
            End If

            If READ_PFK7171(ListCode("Season"), cdSeason) Then
                txt_cdSeason.Data = D7171.BasicName
                txt_cdSeason.Code = D7171.BasicCode
                txt_cdSeason.Enabled = False
            End If

            wJOB = job : L2345 = D2345

            Select Case job
                Case 1
                Case Else
                    If READ_PFK2345(L2345.FactOrderNo) = False Then
                        MsgBox("Error ==>> Try your actions again Data!")

                        Me.Dispose()
                        Exit Function
                    Else
                        L2345 = D2345
                    End If
                    txt_DateAccept.Enabled = True
            End Select

            pri_CustomerCode = L2345.CustomerCode

            formA = False
            Me.ShowDialog()

            Link_ISUD2345A_AUTO = isudCHK
        Catch ex As Exception
            '          Call MsgBoxP("61", WordConv("Request Order Processing"))
        End Try
    End Function

    Public Function Link_ISUD2345A_AUTO_NEW(job As Integer, PRNO As String, Value As String, Optional ByVal TAG As String = "") As Boolean
        Link_ISUD2345A_AUTO_NEW = False
        Try
            Me.Tag = TAG
            Chk_AutoLink = True


            If READ_PFK7101(D3011.CustomerCode) Then
                txt_CustomerCode.Code = D7101.CustomerCode
                txt_CustomerCode.Data = D7101.CustomerNameSimply
            End If

            If READ_PFK7101(D3011.SupplierCode) Then
                txt_SupplierCode.Code = D7101.CustomerCode
                txt_SupplierCode.Data = D7101.CustomerNameSimply
            End If

            wJOB = job : L2345 = D2345

            Select Case job
                Case 1
                Case Else
                    If READ_PFK2345(L2345.FactOrderNo) = False Then
                        Call MsgBoxP("3", "LINK_ISUD")

                        Me.Dispose()
                        Exit Function
                    Else
                        L2345 = D2345
                    End If
                    txt_DateAccept.Enabled = True

            End Select
            pri_CustomerCode = L2345.CustomerCode

            formA = False
            Me.ShowDialog()

            Link_ISUD2345A_AUTO_NEW = isudCHK
        Catch ex As Exception
            '            Call MsgBoxP("61", WordConv("Request Order Processing"))
        End Try


    End Function

    Public Function Link_ISUD2345A_INSERT_MULTI(job As Integer, Value As String, Optional ByVal TAG As String = "") As Boolean
        Link_ISUD2345A_INSERT_MULTI = False
        Try
            List_AutoKey = Value


            Me.Tag = TAG

            wJOB = job : L2345 = D2345

            Select Case job
                Case 11


            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD2345A_INSERT_MULTI = isudCHK
        Catch ex As Exception

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
                    formA = True
                    Me.Dispose()
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If


                tst_iDelete.Visible = False
                tst_iSave.Visible = True

                Call KEY_COUNT()

                Call DATA_SEARCH_VS1()
                Call DATA_SEARCH_VS2()
                Call DATA_SEARCH_VS0()
                Call HideColumn()

            Case 2
                Me.Text = Me.Text & " - SEARCH"
                If CHK(2) <> "1" Then
                    isudCHK = False
                    formA = True
                    Me.Dispose()
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                tst_iDelete.Visible = False
                tst_iSave.Visible = False
                pcl_CheckField.Enabled = False

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS1()
                Call DATA_SEARCH_VS2()
                Call DATA_SEARCH_VS0()
                Call HideColumn()

                '-------------------------------------------------------------------------------------------------- Start
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
                '-------------------------------------------------------------------------------------------------- End
            Case 3
                Me.Text = Me.Text & " - UPDATE"
                If CHK(3) <> "1" Then
                    isudCHK = False
                    formA = True
                    Me.Dispose()
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                txt_FactOrderNo.Enabled = False
                tst_iDelete.Visible = False
                tst_iSave.Visible = True

                pcl_CheckField.Enabled = False

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS1()
                Call DATA_SEARCH_VS2()
                Call DATA_SEARCH_VS0()
                Call HideColumn()

                '-------------------------------------------------------------------------------------------------- Start
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
                '-------------------------------------------------------------------------------------------------- End
            Case 4
                Me.Text = Me.Text & " - DELETE"
                If CHK(4) <> "1" Then
                    isudCHK = False
                    formA = True
                    Me.Dispose()
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                tst_iDelete.Visible = True
                tst_iSave.Visible = False
                pcl_CheckField.Enabled = False


                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS1()
                Call DATA_SEARCH_VS2()
                Call DATA_SEARCH_VS0()
                Call HideColumn()
                '-------------------------------------------------------------------------------------------------- Start
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

                tst_iDelete.Visible = False
                tst_iSave.Visible = True
                txt_FactOrderNo.Enabled = False
                pcl_CheckField.Enabled = False


                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS1()
                Call DATA_SEARCH_VS0()
                Call HideColumn()

                '-------------------------------------------------------------------------------------------------- Start
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
                '-------------------------------------------------------------------------------------------------- End

            Case 9
                Me.Text = Me.Text & " - COPY STOCK"
                If CHK(3) <> "1" Then
                    isudCHK = False
                    formA = True
                    Me.Dispose()
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                txt_FactOrderNo.Enabled = False
                tst_iDelete.Visible = False
                tst_iSave.Visible = True

                pcl_CheckField.Enabled = False
                cmb_CheckInPurchasingOrder.InSelected = 1
                rad_CheckRelationType2.Checked = True

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS1_STOCK()

                txt_DateAccept.Data = Pub.DAT
                txt_DatePosted.Data = Pub.DAT

                Call DATA_SEARCH_VS2()
                Call DATA_SEARCH_VS0()
                Call HideColumn()
                wJOB = 1

            Case 10
                Me.Text = Me.Text & " - COPY REQUEST"
                If CHK(3) <> "1" Then
                    isudCHK = False
                    formA = True
                    Me.Dispose()
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                txt_FactOrderNo.Enabled = False
                tst_iDelete.Visible = False
                tst_iSave.Visible = True

                pcl_CheckField.Enabled = False
                cmb_CheckInPurchasingOrder.InSelected = 0
                rad_CheckRelationType2.Checked = True

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS1_STOCK()

                txt_DateAccept.Data = Pub.DAT

                txt_DatePosted.Data = Pub.DAT

                Call DATA_SEARCH_VS2()
                Call DATA_SEARCH_VS0()
                Call HideColumn()
                wJOB = 1

            Case 11
                Me.Text = Me.Text & " - INSERT AUTO"
                If CHK(1) <> "1" Then
                    isudCHK = False
                    formA = True
                    Me.Dispose()
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If


                tst_iDelete.Visible = False
                tst_iSave.Visible = True


                Call DATA_SEARCH_VS1_INSERT()
                Call DATA_SEARCH_VS2()
                Call DATA_SEARCH_VS0()
                Call HideColumn()

                Call KEY_COUNT()
  
        End Select


        formA = True
    End Sub
#End Region

#Region "Search"
    Private Function DATA_SEARCH01() As Boolean
        DATA_SEARCH01 = False

        DS1 = PrcDS("USP_ISUD2345A_SEARCH_HEAD", cn, L2345.FactOrderNo)

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

    Private Function DATA_SEARCH_VS0() As Boolean
        DATA_SEARCH_VS0 = False

        If SplitContainer1.Panel1Collapsed = True Then Exit Function

        DS1 = PrcDS("USP_ISUD2345A_SEARCH_VS0", cn, L2345.FactOrderNo)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS0, DS1, "USP_ISUD2345A_SEARCH_VS0", "VS0")
            vS0.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS0, DS1, "USP_ISUD2345A_SEARCH_VS0", "VS0")


        DATA_SEARCH_VS0 = True
    End Function
    Private Function DATA_SEARCH_VS2() As Boolean
        DATA_SEARCH_VS2 = False
        DATA_SEARCH_VS2 = True
    End Function

    Private Function DATA_SEARCH_VS1_INSERT() As Boolean
        DATA_SEARCH_VS1_INSERT = False
        Try
            Dim i As Integer

            DS1 = PrcDS("USP_ISUD2345A_SEARCH_VS1_INSERT_MULTI", cn, List_AutoKey)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs1, DS1, "USP_ISUD2345A_SEARCH_VS1_F1", "Vs1")
                Vs1.ActiveSheet.RowCount = 1
                Vs1.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(Vs1, DS1, "USP_ISUD2345A_SEARCH_VS1_F1", "Vs1")

            Dim strAutokey As String
            strAutokey = GetDsData(DS1, 0, "AutokeyK3011")

            If READ_PFK3011(strAutokey) Then

                Call READ_PFK7101(D3011.CustomerCode)

                txt_CustomerCode.Code = D7101.CustomerCode
                txt_CustomerCode.Data = D7101.CustomerName

          
            End If



            DATA_SEARCH_VS1_INSERT = True

        Catch ex As Exception

        End Try
    End Function

    Private Function DATA_SEARCH_VS1() As Boolean
        DATA_SEARCH_VS1 = False
        Try
            Dim i As Integer

            DS1 = PrcDS("USP_ISUD2345A_SEARCH_VS1_F1", cn, L2345.FactOrderNo)
            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs1, DS1, "USP_ISUD2345A_SEARCH_VS1_F1", "Vs1")
                Vs1.ActiveSheet.RowCount = 1
                Vs1.Enabled = True
                Exit Function
            End If



            SPR_PRO_NEW(Vs1, DS1, "USP_ISUD2345A_SEARCH_VS1_F1", "Vs1")

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

            Next

            DATA_SEARCH_VS1 = True

        Catch ex As Exception

        End Try
    End Function

    Private Function DATA_SEARCH_VS1_STOCK() As Boolean
        DATA_SEARCH_VS1_STOCK = False
        Try
            Dim i As Integer

            DS1 = PrcDS("USP_ISUD2345A_SEARCH_VS1_F1_COPY", cn, L2345.FactOrderNo)
            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs1, DS1, "USP_ISUD2345A_SEARCH_VS1_F1", "Vs1")
                Vs1.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(Vs1, DS1, "USP_ISUD2345A_SEARCH_VS1_F1", "Vs1")
            DATA_SEARCH_VS1_STOCK = True

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
        W2345.seBuyingType = ListCode("BuyingType")
        W2345.selUnitPrice = ListCode("UnitPrice")
        W2345.seOrigin = ListCode("Origin")
        W2345.seSeason = ListCode("Season")
        W2345.seSite = ListCode("Site")

        W2345.seDeliveryTerm = ListCode("DeliveryTerm")
        W2345.sePaymentTerm = ListCode("PaymentTerm")
        W2345.sePaymentCondition = ListCode("PaymentCondition")
        W2345.sePaymentTime = ListCode("PaymentTime")
        W2345.sePaymentDay = ListCode("PaymentDay")

        W2346.seOrigin = ListCode("Origin")
        W2346.seTax = ListCode("Tax")
        W2346.seUnitMaterial = ListCode("UnitMaterial")
        W2346.seUnitPacking = ListCode("UnitPacking")
        W2346.seUnitPrice = ListCode("UnitPrice")
        W2346.seSite = ListCode("Site")
        W2346.seDepartment = ListCode("Department")

        W2346.seTax1 = ListCode("Tax1")
        W2346.seTax2 = ListCode("Tax2")
        W2346.seTax3 = ListCode("Tax3")


    End Sub

    Private Sub DATA_MOVE_WRITE01()

        Dim i As Integer
        Dim j As Integer
        j = 0
        For i = 0 To Vs1.ActiveSheet.RowCount - 1
            If Trim(getData(Vs1, getColumIndex(Vs1, "MaterialCode"), i)) = "" Then GoTo skip

            j = j + 1
            If K2346_MOVE(Vs1, i, W2346, L2346.FactOrderNo, getData(Vs1, getColumIndex(Vs1, "KEY_FactOrderSeq"), i)) = True Then
                W2346.Dseq = j

                If rad_CheckRelationType1.Checked = True Then W2346.CheckRelationType = "1"
                If rad_CheckRelationType2.Checked = True Then W2346.CheckRelationType = "2"

                W2346.QtyPurchasing = FormatNumber(CDecp(getData(Vs1, getColumIndex(Vs1, "QtyPurchasing"), i)), 2)
                W2346.PackPurchasing = FormatNumber(CDecp(getData(Vs1, getColumIndex(Vs1, "PackPurchasing"), i)), 0)

                If W2346.CustomerSupplier = "" Then W2346.CustomerSupplier = txt_SupplierCode.Code
                If W2346.cdSite = "" Then W2346.cdSite = "001"


                Call DATA_MOVE_DEFAULT()
                Call REWRITE_PFK2346(W2346)
            Else
                W2346.FactOrderNo = L2345.FactOrderNo
                W2346.Dseq = j

                Call KEY_COUNT_2346()

                W2346.CheckPurchasing = "1"
                W2346.DateAccept = txt_DateAccept.Data

                If W2346.CustomerSupplier = "" Then W2346.CustomerSupplier = txt_SupplierCode.Code
                If W2346.cdSite = "" Then W2346.cdSite = "001"


                W2346.QtyPurchasing = FormatNumber(CDecp(getData(Vs1, getColumIndex(Vs1, "QtyPurchasing"), i)), 2)
                W2346.PackPurchasing = FormatNumber(CDecp(getData(Vs1, getColumIndex(Vs1, "PackPurchasing"), i)), 0)

                W2346.CheckComplete = "2"

                If rad_CheckRelationType1.Checked = True Then W2346.CheckRelationType = "1"
                If rad_CheckRelationType2.Checked = True Then W2346.CheckRelationType = "2"

                Call DATA_MOVE_DEFAULT()
                Call WRITE_PFK2346(W2346)
            End If
skip:

        Next



    End Sub


    Private Function DATA_INSERT() As Boolean
        DATA_INSERT = False
        Try
            If K2345_MOVE(Me, W2345, 1, L2345.FactOrderNo) = False Then

                Call KEY_COUNT()

                If rad_CheckRelationType1.Checked = True Then W2345.CheckRelationType = "1"
                If rad_CheckRelationType2.Checked = True Then W2345.CheckRelationType = "2"

                If rad_CheckProcessType1.Checked = True Then W2345.CheckProcessType = "1"
                If rad_CheckProcessType2.Checked = True Then W2345.CheckProcessType = "2"

                If rad_CheckIOType1.Checked = True Then W2345.CheckIOType = "1"
                If rad_CheckIOType2.Checked = True Then W2345.CheckIOType = "2"

                If rad_CheckMaterialType1.Checked = True Then W2345.CheckMaterialType = "1"
                If rad_CheckMaterialType2.Checked = True Then W2345.CheckMaterialType = "2"

                If rad_CheckMarketType1.Checked = True Then W2345.CheckMarketType = "1"
                If rad_CheckMarketType2.Checked = True Then W2345.CheckMarketType = "2"

                W2345.CheckInPurchasingOrder = cmb_CheckInPurchasingOrder.InSelected + 1
                W2345.CheckOutPurchasingOrder = cmb_CheckOutPurchasingOrder.InSelected + 1


                Call DATA_MOVE_DEFAULT()
                If WRITE_PFK2345(W2345) = True Then
                    Call DATA_MOVE_WRITE01()
                    DATA_INSERT = True
                    isudCHK = True : WRITE_CHK = "*"
                    Exit Function
                End If
            End If
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_UPDATE")
        End Try

    End Function

    Private Function DATA_UPDATE() As Boolean
        DATA_UPDATE = False
        Try
            If K2345_MOVE(Me, W2345, 3, L2345.FactOrderNo) = True Then
                If rad_CheckProcessType1.Checked = True Then W2345.CheckProcessType = "1"
                If rad_CheckProcessType2.Checked = True Then W2345.CheckProcessType = "2"

                If rad_CheckIOType1.Checked = True Then W2345.CheckIOType = "1"
                If rad_CheckIOType2.Checked = True Then W2345.CheckIOType = "2"

                If rad_CheckMaterialType1.Checked = True Then W2345.CheckMaterialType = "1"
                If rad_CheckMaterialType2.Checked = True Then W2345.CheckMaterialType = "2"

                If rad_CheckMarketType1.Checked = True Then W2345.CheckMarketType = "1"
                If rad_CheckMarketType2.Checked = True Then W2345.CheckMarketType = "2"

                If rad_CheckRelationType1.Checked = True Then W2345.CheckRelationType = "1"
                If rad_CheckRelationType2.Checked = True Then W2345.CheckRelationType = "2"

                W2345.CheckInPurchasingOrder = cmb_CheckInPurchasingOrder.InSelected + 1
                W2345.CheckOutPurchasingOrder = cmb_CheckOutPurchasingOrder.InSelected + 1

                Call DATA_MOVE_DEFAULT()
                If REWRITE_PFK2345(W2345) = True Then
                    Call DATA_MOVE_WRITE01()
                    DATA_UPDATE = True

                    isudCHK = True
                End If
            End If
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_UPDATE")
        End Try
    End Function

    Private Sub DATA_CLOSE()
        Try
            Call PrcExeNoError("EXP_CLOSSING_PFK2346", cn, txt_FactOrderNo.Data)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub DATA_UPDATE_AFTER()
        Try
            Dim AmtBegin As Decimal
            Dim AmtEnd As Decimal


            If READ_PFK2345(L2345.FactOrderNo) = True Then
                W2345 = D2345

                If REWRITE_PFK2345(W2345) = True Then
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
        Catch ex As Exception
            Call MsgBoxP("38", "DATA_DELETE")
        End Try

    End Sub
    Private Function DATA_LINE_DELETE(xrow As Integer) As Boolean
        DATA_LINE_DELETE = False

        Try
            If READ_PFK2346(getData(Vs1, getColumIndex(Vs1, "KEY_FactOrderNo"), xrow),
                            getData(Vs1, getColumIndex(Vs1, "KEY_FactOrderSeq"), xrow)) = True Then

                W2346 = D2346

                If W2346.CheckPurchasing <> "1" Then MsgBoxP("Can not delete this ! This is Valided order !") : Exit Function
                If W2346.QtyWarehouse > 0 Then MsgBoxP("Can not Delete because of InBound Data") : Exit Function

                If DELETE_PFK2346(W2346) = True Then
                    Call Delete_History("PFK2346", W2346.FactOrderNo & "-" & W2346.FactOrderSeq.ToString)

                    isudCHK = True
                End If
            End If
            DATA_LINE_DELETE = True
        Catch ex As Exception
            Call MsgBoxP("38", "DATA_DELETE")
        End Try

    End Function



    Private Function CheckSamePO(FactOrderNo As String, FactOrderSeq As String) As Boolean
        CheckSamePO = True
        Dim i As Integer
        Try
            For i = 0 To Vs1.ActiveSheet.RowCount - 1
                If getData(Vs1, getColumIndex(Vs1, "FactOrderNo"), i) = FactOrderNo _
                    And getData(Vs1, getColumIndex(Vs1, "FactOrderSeq"), i) = FactOrderSeq Then
                    CheckSamePO = False
                    MsgBoxP("Already Data! No again!") : Exit Function
                End If
            Next

        Catch ex As Exception
            Call MsgBox("35", "CheckSamePO")
        End Try
    End Function
    Private Sub KEY_COUNT()
        Dim YRNO As Integer
        YRNO = Mid(Pub.DAT, 3, 4)
        YRNO = Mid(Pub.DAT, 3, 2)

        Dim PreFix As String


        If rad_CheckIOType1.Checked Then
            Select Case cmb_CheckInPurchasingOrder.PeaceCombobox1.SelectedIndex + 1
                Case "1" : PreFix = "PO"
                Case "2" : PreFix = "PB"
                Case "3" : PreFix = "PP"
                Case "4" : PreFix = "RI"
                Case "5" : PreFix = "RO"
                Case "6" : PreFix = "RS"
                Case "7" : PreFix = "RT"
                Case "8" : PreFix = "RP"

            End Select
        End If
        If rad_CheckIOType2.Checked Then
            Select Case cmb_CheckOutPurchasingOrder.PeaceCombobox1.SelectedIndex + 1
                Case "1" : PreFix = "OI"
                Case "2" : PreFix = "OB"
                Case "3" : PreFix = "OS"
                Case "4" : PreFix = "OT"
                Case "5" : PreFix = "OO"
                Case "6" : PreFix = "OP"

            End Select
        End If

        Try
            SQL = "SELECT MAX(CAST(SUBSTRING(K2345_FactOrderNo,5,5) AS DECIMAL)) AS MAX_MCODE FROM PFK2345 "
            SQL = SQL & " WHERE SUBSTRING(K2345_FactOrderNo,3,2) = '" & YRNO.ToString & "' "
            SQL = SQL & " AND SUBSTRING(K2345_FactOrderNo,1,2) = '" & PreFix & "' AND ISNUMERIC(SUBSTRING(K2345_FactOrderNo,5,5)) > 0"

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()


            If IsDBNull(rd!MAX_MCODE) Then
                W2345.FactOrderNo = PreFix & YRNO & "00001"
            Else
                W2345.FactOrderNo = PreFix & YRNO & Format(CInt(rd!MAX_MCODE + 1), "00000")
            End If

            rd.Close()

            txt_FactOrderNo.Data = W2345.FactOrderNo
            L2345.FactOrderNo = W2345.FactOrderNo

            L2346.FactOrderNo = W2345.FactOrderNo
            W2346.FactOrderNo = W2345.FactOrderNo

        Catch ex As Exception
            Call MsgBox("35", "KEY_COUNT")
        End Try
    End Sub
    Private Sub KEY_COUNT_2346()
        Try

            SQL = "SELECT MAX(CAST(K2346_FactOrderSeq AS DECIMAL)) AS MAX_MCODE FROM PFK2346 "
            SQL = SQL & " WHERE K2346_FactOrderNo = '" & L2346.FactOrderNo & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                W2346.FactOrderSeq = 1
            Else
                W2346.FactOrderSeq = Format(CInt(rd!MAX_MCODE + 1), "0")
            End If

            rd.Close()

            L2346.FactOrderSeq = W2346.FactOrderSeq

        Catch ex As Exception
            Call MsgBox("35", "KEY_COUNT")
        End Try
    End Sub

    Private Sub FORM_INIT()
        SplitContainer1.Panel1Collapsed = True

        If Tag = "PFP23452" Or Tag = "PFP23458" Then
            rad_CheckRelationType2.Checked = True
            rad_CheckRelationType1.Checked = False

            rad_CheckRelationType2.Enabled = False
            rad_CheckRelationType1.Enabled = False

            cmb_CheckInPurchasingOrder.Visible = True
            cmb_CheckOutPurchasingOrder.Visible = False

            pan_ioType.Enabled = False
            pan_Process.Enabled = False
            cmb_CheckInPurchasingOrder.Enabled = False
        End If

        If Chk_AutoLink = True Then
            rad_CheckRelationType1.Checked = True
            rad_CheckRelationType2.Enabled = False
            rad_CheckRelationType1.Enabled = False

            cmb_CheckInPurchasingOrder.Visible = True
            cmb_CheckOutPurchasingOrder.Visible = False

            pan_ioType.Enabled = False
            pan_Process.Enabled = False
            cmb_CheckInPurchasingOrder.Enabled = False
        End If
    End Sub

    Private Sub DATA_INIT()
        Try
            If READ_PFK7171(ListCode("Site"), Pub.SITE) Then
                txt_cdSite.Data = D7171.BasicName
                txt_cdSite.Code = D7171.BasicCode
            End If

            If READ_PFK7411(Pub.SAW) Then
                txt_InchargePurchasing.Data = D7411.Name
                txt_InchargePurchasing.Code = D7411.IDNO
                txt_InchargePurchasing.Enabled = False
            End If

            txt_DateAccept.Data = Pub.DAT
            txt_DatePosted.Data = Pub.DAT

        Catch ex As Exception
            Call MsgBox("35", "DATA_INIT")
        End Try

    End Sub



    Private Function Data_Check() As Boolean
        Data_Check = False
        Dim i As Integer
        Dim AmtBegin As Decimal
        Dim AmtEnd As Decimal


        Try
            For i = 0 To Vs1.ActiveSheet.RowCount - 1
                If getData(Vs1, getColumIndex(Vs1, "MaterialCode"), i).ToString.Trim = "" Then MsgBoxP("MaterialCode at Row " & (i + 1)) : Exit Function
                If getData(Vs1, getColumIndex(Vs1, "cdUnitMaterial"), i).ToString.Trim = "" Then MsgBoxP("Unit Material at Row " & (i + 1)) : Exit Function
                If CDecp(getData(Vs1, getColumIndex(Vs1, "QtyPurchasing"), i)) = 0 Then MsgBoxP("QtyPurchasing <=0 at Row " & (i + 1)) : Exit Function
            Next



            Data_Check = True
        Catch ex As Exception

        End Try
    End Function
    Private Sub HideColumn()
        Exit Sub
        Try
            Dim ListColumnOrder As New List(Of Integer)

            ListColumnOrder.Add(getColumIndex(Vs1, "AutokeyK2346"))
            ListColumnOrder.Add(getColumIndex(Vs1, "PRNo"))
            ListColumnOrder.Add(getColumIndex(Vs1, "PRNoSeq"))
            ListColumnOrder.Add(getColumIndex(Vs1, "cdPRNo"))
            ListColumnOrder.Add(getColumIndex(Vs1, "AutokeyK3011"))

            ListColumnOrder.Add(getColumIndex(Vs1, "Article"))
            ListColumnOrder.Add(getColumIndex(Vs1, "Line"))
            ListColumnOrder.Add(getColumIndex(Vs1, "ColorOrder"))
            ListColumnOrder.Add(getColumIndex(Vs1, "QtyRequest"))

            Dim ListColumnRequest As New List(Of Integer)

            ListColumnRequest.Add(getColumIndex(Vs1, "cdMaterialCode_1"))
            ListColumnRequest.Add(getColumIndex(Vs1, "CLcdDepartment"))

            If rad_CheckRelationType1.Checked = True Then
                SPR_HIDE(Vs1, True, ListColumnOrder.ToArray)
                SPR_HIDE(Vs1, False, ListColumnRequest.ToArray)

            ElseIf rad_CheckRelationType2.Checked = True Then
                SPR_HIDE(Vs1, False, ListColumnOrder.ToArray)
                SPR_HIDE(Vs1, True, ListColumnRequest.ToArray)

            End If
        Catch ex As Exception

        End Try
    End Sub

#End Region

#Region "Event"
    Private Sub tst_iSave_Click(sender As Object, e As EventArgs) Handles tst_iSave.Click
        Select Case wJOB
            Case 1, 11


                If DataCheck(Me, "PFK2345") = False Then Exit Sub
                If Data_Check() = False Then Exit Sub
                Call KEY_COUNT()

                If DATA_INSERT() = True Then
                    Call DATA_CLOSE()
                    Chk_AutoLink = False

                    wJOB = 3
                    Call DATA_SEARCH_VS1()
                    Call DATA_SEARCH_VS2()
                    Call DATA_SEARCH_VS0()
                    Call HideColumn()

                    MsgBoxP("Insert Successfylly !", vbInformation)

                End If

            Case 2
                Me.Dispose()
            Case 3
                If CheckData_Incharge(Me.FindForm.FindCode("InchargePurchasing").Code(), wJOB) = False Then
                    MsgBox("No Correct InchargePurchasing !")
                    Exit Sub
                End If

                If READ_PFK3429_FactOrder(txt_FactOrderNo.Data, "") = True Then
                    MsgBox("Already make Payable can't modify !")
                    Exit Sub
                End If


                If DataCheck(Me, "PFK2345") = False Then Exit Sub
                If Data_Check() = False Then Exit Sub
                If DATA_UPDATE() Then

                    Call DATA_CLOSE()
                    Call DATA_SEARCH_VS1()
                    Call DATA_SEARCH_VS2()
                    Call DATA_SEARCH_VS0()
                    Chk_AutoLink = False
                    Call HideColumn()

                    MsgBoxP("Update Successfylly !", vbInformation)

                End If


            Case 4
                If CheckData_Incharge(Me.FindForm.FindCode("InchargePurchasing").Code(), wJOB) = False Then
                    MsgBox("No Correct InchargePurchasing !")
                    Exit Sub
                End If

                If READ_PFK3429_FactOrder(txt_FactOrderNo.Data, "") = True Then
                    MsgBox("Already make Payable can't modify !")
                    Exit Sub
                End If


                Call DATA_DELETE()

            Case 5
                If CheckData_Incharge(Me.FindForm.FindCode("InchargePurchasing").Code(), wJOB) = False Then
                    MsgBox("No Correct InchargePurchasing !")
                    Exit Sub
                End If

                If READ_PFK3429_FactOrder(txt_FactOrderNo.Data, "") = True Then
                    MsgBox("Already make Payable can't modify !")
                    Exit Sub
                End If

                If Data_Check() = False Then Exit Sub

                Call DATA_UPDATE_AFTER()
                Call DATA_CLOSE()
                Call DATA_SEARCH_VS1()
                Call DATA_SEARCH_VS2()
                Call DATA_SEARCH_VS0()

                Chk_AutoLink = False
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
        If CheckData_Incharge(Me.FindForm.FindCode("InchargePurchasing").Code(), wJOB) = False Then
            MsgBox("No Correct InchargePurchasing !")
            Exit Sub
        End If

        Dim str As String = MsgBoxP("Do you want to delete it?", vbYesNo)

        If str <> vbYes Then Exit Sub

        Call DATA_DELETE()

        Me.Dispose()
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

            Case getColumIndex(Vs1, "CLcdMaterialCode_F1")
                If rad_CheckRelationType2.Checked = True Then
                    Dim SupplierCode As String
                    Dim xCheckMaterialType As String = "1"

                    If Me.Tag = "PFP23451" Then xCheckMaterialType = "2"
                    SupplierCode = txt_SupplierCode.Code

                    If READ_PFK7101(txt_SupplierCode.Code) = True Then

                        If HLP7260B.Link_HLP7260B(SupplierCode, xCheckMaterialType) = False Then Exit Sub

                        If Array_hlp0000SeVaTt.Count = 0 Then Exit Sub

                        Dim j As Integer = -1

                        For i = 0 To Array_hlp0000SeVaTt.Count - 1
                            If READ_PFK7231(Array_hlp0000SeVaTt1(i)) Then
                                j += 1

                                If e.Row + j = Vs1.ActiveSheet.RowCount - 1 Then
                                    Vs1.ActiveSheet.RowCount += 1
                                End If

                                xROW = e.Row + j

                                DS1 = PrcDS("USP_ISUD2345A_SEARCH_VS1_INSERT_SUPPLIER", cn, Array_hlp0000SeVaTt(i), Array_hlp0000SeVaTt1(i), xCheckMaterialType)

                                Call READ_SPREAD_N(Vs1, DS1, xROW, GetDsRc(DS1), "USP_ISUD2345A_SEARCH_VS1_F1", "VS1")

                            End If

                        Next
                    End If
                End If

        End Select

        vSChange(e.Row)
    End Sub

    Private Sub Vs1_Change(sender As Object, e As ChangeEventArgs) Handles Vs1.Change
        Dim xCOL As Integer
        Dim xROW As Integer
        Dim ListColumn As New List(Of Integer)

        ListColumn.Add(getColumIndex(Vs1, "cdTax3"))
        ListColumn.Add(getColumIndex(Vs1, "cdUnitPrice"))
        ListColumn.Add(getColumIndex(Vs1, "PricePurchasing"))
        ListColumn.Add(getColumIndex(Vs1, "QtyPurchasing"))
        ListColumn.Add(getColumIndex(Vs1, "PackPurchasing"))
        ListColumn.Add(getColumIndex(Vs1, "UnitBaseCheck"))

        Try
            xROW = e.Row
            xCOL = e.Column

            If xCOL = getColumIndex(Vs1, "QtyPurchasingMOQ") Or xCOL = getColumIndex(Vs1, "QtyPurchasingNet") Then
                Dim QtyPurchasingNet As Decimal = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyPurchasingNet"), xROW))
                Dim QtyPurchasingMOQ As Decimal = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyPurchasingMOQ"), xROW))

                setData(Vs1, getColumIndex(Vs1, "QtyPurchasing"), xROW, QtyPurchasingNet + QtyPurchasingMOQ)
                Exit Sub
            End If


            If xCOL = getColumIndex(Vs1, "Width") Then
                If IsNumeric(getData(Vs1, xCOL, xROW)) Then
                    Dim intcone As Decimal
                    Dim decMOQ As Decimal

                    Dim decleng As Decimal = CDecp(getData(Vs1, xCOL, xROW))
                    Dim decMRO As Decimal = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyRequest"), xROW))

                    If decleng <= 0 Then Exit Sub
                    intcone = Math.Ceiling(decMRO / decleng)
                    decMOQ = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyPurchasingMOQ"), xROW))

                    setData(Vs1, getColumIndex(Vs1, "QtyPurchasingNet"), xROW, intcone)
                    setData(Vs1, getColumIndex(Vs1, "QtyPurchasing"), xROW, decMOQ + intcone)

                End If

                Exit Sub

            End If

            If ListColumn.Contains(xCOL) Then

                Call vSChange(xROW)

            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub vSChange(xROW As Integer)
        If wJOB = 2 Then Exit Sub

        If CheckData_Incharge(Me.FindForm.FindCode("InchargePurchasing").Code(), wJOB) = False Then
            MsgBox("No Correct InchargePurchasing !")
            Exit Sub
        End If

        If getData(Vs1, getColumIndex(Vs1, "cdTax1"), xROW) = "" Then
            setData(Vs1, getColumIndex(Vs1, "cdTax1"), xROW, "001") : setData(Vs1, getColumIndex(Vs1, "cdTax1Name"), xROW, "0")
        End If

        If getData(Vs1, getColumIndex(Vs1, "cdTax2"), xROW) = "" Then
            setData(Vs1, getColumIndex(Vs1, "cdTax2"), xROW, "001") : setData(Vs1, getColumIndex(Vs1, "cdTax2Name"), xROW, "0")
        End If

        If getData(Vs1, getColumIndex(Vs1, "cdTax3"), xROW) = "" Then
            If rad_CheckMarketType1.Checked = True Then setData(Vs1, getColumIndex(Vs1, "cdTax3"), xROW, "001") : setData(Vs1, getColumIndex(Vs1, "cdTax3Name"), xROW, "0")
            If rad_CheckMarketType2.Checked = True Then setData(Vs1, getColumIndex(Vs1, "cdTax3"), xROW, "002") : setData(Vs1, getColumIndex(Vs1, "cdTax3Name"), xROW, "0.1")
        End If

        setData(Vs1, getColumIndex(Vs1, "seUnitPrice"), xROW, ListCode("UnitPrice"))


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

                W2346.FactOrderNo = txt_FactOrderNo.Data
                W2346.FactOrderSeq = getData(Vs1, getColumIndex(Vs1, "KEY_FactOrderSeq"), xROW)

                If READ_PFK2346(W2346.FactOrderNo, W2346.FactOrderSeq) = True Then
                    If D2346.CheckPurchasing <> "1" Then MsgBoxP("Check condition at row " & xROW) : Exit Sub
                    If CDblp(D2346.QtyWarehouse) > 0 Then MsgBoxP("Check condition at row " & xROW) : Exit Sub

                    If DELETE_PFK2346(D2346) Then

                        Call Delete_History("PFK2346", D2346.FactOrderNo & "-" & D2346.FactOrderSeq.ToString)

                        If READ_PFK2346_1(L2345.FactOrderNo) = False Then
                            If READ_PFK2345(L2345.FactOrderNo) = True Then
                                W2345 = D2345

                                If DELETE_PFK2345(W2345) = True Then

                                    Call Delete_History("PFK2345", W2345.FactOrderNo)

                                    isudCHK = True
                                    Me.Dispose()
                                End If

                            End If

                        End If

                    End If

                End If

                Call DATA_SEARCH_VS0()

                SPR_DEL(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex)
                Vs1.Focus()

            Case Keys.Enter
                If CheckData_Incharge(Me.FindForm.FindCode("InchargePurchasing").Code(), wJOB) = False Then
                    MsgBox("No Correct InchargePurchasing !")
                    Exit Sub
                End If

                'If xCOL = getColumIndex(Vs1, "QtyPurchasingMOQ") Then
                If xCOL = getColumIndex(Vs1, "QtyPurchasingMOQ") Or xCOL = getColumIndex(Vs1, "QtyPurchasingNet") Then
                    Dim QtyPurchasingNet As Decimal = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyPurchasingNet"), xROW))
                    Dim QtyPurchasingMOQ As Decimal = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyPurchasingMOQ"), xROW))

                    setData(Vs1, getColumIndex(Vs1, "QtyPurchasing"), xROW, QtyPurchasingNet + QtyPurchasingMOQ)
                End If



                If xCOL = getColumIndex(Vs1, "Width") Then
                    If IsNumeric(getData(Vs1, xCOL, xROW)) Then
                        Dim intcone As Integer
                        Dim decMOQ As Integer

                        Dim decleng As Decimal = CDecp(getData(Vs1, xCOL, xROW))
                        Dim decMRO As Decimal = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyRequest"), xROW))

                        If decleng <= 0 Then Exit Sub
                        'intcone = Math.Round(decMRO / decleng, 0)
                        'intcone = Math.Round(decMRO / decleng, System.MidpointRounding.AwayFromZero)
                        intcone = Math.Ceiling(decMRO / decleng)
                        decMOQ = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyPurchasingMOQ"), xROW))

                        setData(Vs1, getColumIndex(Vs1, "QtyPurchasingNet"), xROW, intcone)
                        setData(Vs1, getColumIndex(Vs1, "QtyPurchasing"), xROW, decMOQ + intcone)

                    End If
                    Exit Select

                End If

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

    Private Sub rad_CheckRelationType1_CheckedChanged(sender As Object, e As EventArgs) Handles rad_CheckRelationType1.CheckedChanged, rad_CheckRelationType2.CheckedChanged
        Call HideColumn()
    End Sub



    Private Sub txt_SupplierCode_txtTextChange(sender As Object, e As EventArgs) Handles txt_SupplierCode.txtTextChange
        If formA = False Then Exit Sub

        DS1 = PrcDS("USP_PFP71011_SEARCH_VS1_LINE", cn, txt_SupplierCode.Code)
        If GetDsRc(DS1) = 0 Then Exit Sub

        Call STORE_MOVE(Me, DS1)

    End Sub

#End Region



End Class
