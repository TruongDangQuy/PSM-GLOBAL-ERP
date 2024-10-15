Public Class ISUD7262A

#Region "Variable"
    Private wJOB As Integer

    Private W7262 As New T7262_AREA
    Private L7262 As New T7262_AREA

    Private W7263 As New T7263_AREA
    Private L7263 As New T7263_AREA


    Private WRITE_CHK As String
    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_ISUD7262A(job As Integer, ContractID As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        D7262.ContractID = ContractID
        D7263.ContractID = ContractID

        wJOB = job : L7262 = D7262 : L7263 = D7263

        Link_ISUD7262A = False
        Try

            Select Case job
                Case 1
                    D7262.CustomerCode = ContractID

                    If READ_PFK7101(ContractID) Then
                        txt_CustomerCode.Code = D7101.CustomerCode
                        txt_CustomerCode.Data = D7101.CustomerName
                        txt_CustomerCode.Enabled = False

                        DS1 = PrcDS("USP_PFP71011_SEARCH_VS1_LINE", cn, txt_CustomerCode.Code)

                        If GetDsRc(DS1) = 0 Then
                            txt_cdDeliveryTerm.Code = "" : txt_cdDeliveryTerm.Data = ""

                            txt_cdPaymentTerm.Code = "" : txt_cdPaymentTerm.Data = ""
                            txt_cdPaymentCondition.Code = "" : txt_cdPaymentCondition.Data = ""
                            txt_cdPaymentTime.Code = "" : txt_cdPaymentTime.Data = ""
                            txt_cdPaymentDay.Code = "" : txt_cdPaymentDay.Data = ""
                        End If

                        Call STORE_MOVE(Me, DS1)

                    Else

                        txt_CustomerCode.Enabled = True
                        'Me.Dispose()
                        'Exit Function
                    End If

                Case Else
                    If READ_PFK7262(L7262.ContractID) = False Then
                        Call MsgBoxP("3", "LINK_ISUD")

                        Me.Dispose()
                        Exit Function
                    Else
                        L7262 = D7262

                    End If

                    txt_DateAccept.Enabled = False
            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD7262A = isudCHK
        Catch ex As Exception
            Call MsgBoxP("61", WordConv("Link_ISUD7262A"))
        End Try


    End Function

    Private _MaterialCode As String
    Public Function Link_ISUD7262A_MaterialCode(job As Integer, ContractID As String, MaterialCode As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        Link_ISUD7262A_MaterialCode = False

        Try
            wJOB = job

            D7262.ContractID = ContractID
            D7263.ContractID = ContractID

            L7262 = D7262 : L7263 = D7263

            _MaterialCode = MaterialCode

            Select Case job
                Case 1
                    D7262.CustomerCode = ContractID
                    txt_CustomerCode.Code = ContractID

                    If READ_PFK7101(ContractID) Then
                        txt_CustomerCode.Code = D7101.CustomerCode
                        txt_CustomerCode.Data = D7101.CustomerName
                        txt_CustomerCode.Enabled = False
                    Else
                        'Me.Dispose()
                        'Exit Function
                    End If

                    DS1 = PrcDS("USP_PFP71011_SEARCH_VS1_LINE", cn, txt_CustomerCode.Code)

                    If GetDsRc(DS1) = 0 Then
                        txt_cdDeliveryTerm.Code = "" : txt_cdDeliveryTerm.Data = ""

                        txt_cdPaymentTerm.Code = "" : txt_cdPaymentTerm.Data = ""
                        txt_cdPaymentCondition.Code = "" : txt_cdPaymentCondition.Data = ""
                        txt_cdPaymentTime.Code = "" : txt_cdPaymentTime.Data = ""
                        txt_cdPaymentDay.Code = "" : txt_cdPaymentDay.Data = ""
                    End If

                    Call STORE_MOVE(Me, DS1)
                Case Else
                    If READ_PFK7262(L7262.ContractID) = False Then
                        Call MsgBoxP("3", "Link_ISUD7262A")

                        Me.Dispose()
                        Exit Function
                    Else
                        L7262 = D7262
                    End If

                    txt_DateAccept.Enabled = False
            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD7262A_MaterialCode = isudCHK
        Catch ex As Exception
            Call MsgBoxP("61", WordConv("Link_ISUD7262A"))
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

                Frame1.Enabled = True

                tst_iDelete.Visible = False

                Call KEY_COUNT()
                Call DATA_SEARCH_VS1()

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

                Frame1.Enabled = True
                pcl_CheckField.Enabled = False

                tst_iDelete.Visible = False
                tst_iSave.Visible = False

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS1()
            Case 3
                Me.Text = Me.Text & " - UPDATE"
                If CHK(3) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Frame1.Enabled = True
                pcl_CheckField.Enabled = False

                tst_iDelete.Visible = False

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS1()

            Case 4
                Me.Text = Me.Text & " - DELETE"
                If CHK(4) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Frame1.Enabled = False
                pcl_CheckField.Enabled = False

                tst_iDelete.Visible = True
                tst_iSave.Visible = False

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS1()
            Case 5
                Me.Text = Me.Text & " - COPY"
                If CHK(1) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                txt_DateAccept.Data = Pub.DAT
                txt_ContractNo.Data = ""
                pcl_CheckField.Enabled = True

                tst_iDelete.Visible = False
                tst_iSave.Visible = True

                pan_FabricType.Enabled = True

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS1()

                rad_CheckMaterialType1.Enabled = True
                rad_CheckMaterialType2.Enabled = True

                txt_DateAccept.Enabled = True
                txt_CustomerCode.Enabled = True

                Call KEY_COUNT()

                wJOB = 1

        End Select

        formA = True

    End Sub
    Private Sub DATA_INIT()
        Try
            If Trim(Pub.DEPARTMENT) <> "" And wJOB = "1" Then
            End If

              rad_CheckMaterialType1.Enabled = False
            rad_CheckMaterialType2.Enabled = False
            rad_CheckMaterialType2.Checked = True

            txt_ContractID.Enabled = False
            txt_DateAccept.Data = Pub.DAT
            txt_DateExchange.Data = Pub.DAT

            If wJOB = "1" Then txt_CustomerCode.Enabled = True Else txt_CustomerCode.Enabled = False

            If wJOB <> "2" And rad_CheckMaterialType2.Checked Then
                If bolCheckSalesPrice = False Then
                    If MsgBoxPPW("Please type the password to modify!", const_pwSALESPrice) = False Then wJOB = "2" : GoTo next1
                    bolCheckSalesPrice = True

                End If
            End If

next1:
            If READ_PFK7411(Pub.SAW) Then
                txt_InchargePurchasing.Data = D7411.Name
                txt_InchargePurchasing.Code = D7411.IDNO
            End If

            If READ_PFK7171_NAME(ListCode("UnitPrice"), "USD") Then
                txt_cdUnitPrice.Code = D7171.BasicCode
                txt_cdUnitPrice.Data = D7171.BasicName
            End If


            tst_iUtilities.Visible = True
            tst_iAttach.Visible = True
            tst_iHistory.Visible = False

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INIT")
        End Try

    End Sub

    Private Sub FORM_INIT()

    End Sub
#End Region

#Region "Search"
    Private Function DATA_SEARCH01() As Boolean
        DATA_SEARCH01 = False

        DS1 = PrcDS("USP_ISUD7262A_SEARCH_HEAD", cn, L7262.ContractID)

        If GetDsRc(DS1) = 0 Then
            Exit Function
            isudCHK = False
        End If

        Call DATASET_MOVE(Me, DS1)

        CheckProcessType(GetDsData(DS1, 0, "K7262_CheckProcessType"))
        CheckIOType(GetDsData(DS1, 0, "K7262_CheckIOType"))
        CheckMaterialType(GetDsData(DS1, 0, "K7262_CheckMaterialType"))
        CheckMarketType(GetDsData(DS1, 0, "K7262_CheckMarketType"))
        CheckRelationType(GetDsData(DS1, 0, "K7262_CheckRelationType"))
        CheckUse(GetDsData(DS1, 0, "K7262_CheckUse"))

        DATA_SEARCH01 = True

    End Function

    Private Function DATA_SEARCH_VS1() As Boolean
        DATA_SEARCH_VS1 = False
        Try
            Dim i As Integer

            DS1 = PrcDS("USP_ISUD7262A_SEARCH_VS1", cn, L7262.ContractID)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs1, DS1, "USP_ISUD7262A_SEARCH_VS1", "Vs1")

                Vs1.ActiveSheet.RowCount = 1

                If _MaterialCode <> "" Then
                    If READ_PFK7231(_MaterialCode) Then
                        setData(Vs1, getColumIndex(Vs1, "MaterialCode"), 0, D7231.MaterialCode)
                        setData(Vs1, getColumIndex(Vs1, "MaterialName"), 0, D7231.MaterialName)
                        setData(Vs1, getColumIndex(Vs1, "PriceMaterialVND"), 0, D7231.PriceUSD)
                        setData(Vs1, getColumIndex(Vs1, "PriceMaterialEX"), 0, D7231.PriceVND)

                        setData(Vs1, getColumIndex(Vs1, "cdUnitMaterial"), 0, D7231.cdUnitMaterial)

                        If READ_PFK7171(ListCode("UnitMaterial"), D7231.cdUnitMaterial) Then
                            setData(Vs1, getColumIndex(Vs1, "cdUnitMaterialName"), 0, D7171.BasicName)
                        End If
                    End If
                End If

                Vs1.Enabled = True
                Exit Function
            End If


            SPR_PRO_NEW(Vs1, DS1, "USP_ISUD7262A_SEARCH_VS1", "Vs1")

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

    Private Sub CheckUse(Use As String)
        Select Case Use
            Case "1" : opt_XCHK0.Checked = True
            Case "2" : opt_XCHK1.Checked = True
            Case Else : opt_XCHK0.Checked = True
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
        W7262.seBuyingType = ListCode("BuyingType")
        W7262.seCommercialTerm = ListCode("CommercialTerm")
        W7262.seOrigin = ListCode("Origin")

        W7262.seDeliveryTerm = ListCode("DeliveryTerm")
        W7262.sePaymentTerm = ListCode("PaymentTerm")
        W7262.sePaymentCondition = ListCode("PaymentCondition")
        W7262.sePaymentTime = ListCode("PaymentTime")
        W7262.sePaymentDay = ListCode("PaymentDay")

        W7262.seUnitPrice = ListCode("UnitPrice")

        W7263.seDepartment = ListCode("Department")
        W7263.seUnitMaterial = ListCode("UnitMaterial")
        W7263.seUnitPacking = ListCode("UnitPacking")
        W7263.seUnitPrice = ListCode("UnitPrice")

    End Sub

    Private Sub DATA_MOVE_WRITE01()

        Dim i As Integer
        Dim j As Integer
        j = 0
        For i = 0 To Vs1.ActiveSheet.RowCount - 1
            If Trim(getData(Vs1, getColumIndex(Vs1, "MaterialCode"), i)) = "" Then GoTo skip

            j = j + 1
            If K7263_MOVE(Vs1, i, W7263, L7263.ContractID, getData(Vs1, getColumIndex(Vs1, "KEY_ContracSeq"), i)) = True Then


                W7263.PriceMaterialEX = CDecp(txt_PriceExchange.Data) * W7263.PriceMaterialVND
                W7263.cdUnitPrice = txt_cdUnitPrice.Code
                W7263.Dseq = j

                If W7263.cdDepartment = "" Then
                    If txt_cdDepartment.Code <> "" Then W7263.cdDepartment = txt_cdDepartment.Code
                End If

                Call DATA_MOVE_DEFAULT()
                Call REWRITE_PFK7263(W7263)
            Else
                W7263.ContractID = L7262.ContractID
                W7263.PriceMaterialEX = CDecp(txt_PriceExchange.Data) * W7263.PriceMaterialVND
                Call KEY_COUNT_SEQ()

                W7263.Dseq = j

                If W7263.cdDepartment = "" Then
                    If txt_cdDepartment.Code <> "" Then W7263.cdDepartment = txt_cdDepartment.Code
                End If

                W7263.cdUnitPrice = txt_cdUnitPrice.Code

                Call DATA_MOVE_DEFAULT()
                Call WRITE_PFK7263(W7263)
            End If
skip:

        Next

    End Sub


    Private Sub DATA_INSERT()

        Try
            If K7262_MOVE(Me, W7262, 1, L7262.ContractID) = False Then

                Call KEY_COUNT()

                If rad_CheckRelationType1.Checked = True Then W7262.CheckRelationType = "1"
                If rad_CheckRelationType2.Checked = True Then W7262.CheckRelationType = "2"

                If rad_CheckProcessType1.Checked = True Then W7262.CheckProcessType = "1"
                If rad_CheckProcessType2.Checked = True Then W7262.CheckProcessType = "2"

                If rad_CheckIOType1.Checked = True Then W7262.CheckIOType = "1"
                If rad_CheckIOType2.Checked = True Then W7262.CheckIOType = "2"

                If rad_CheckMaterialType1.Checked = True Then W7262.CheckMaterialType = "1"
                If rad_CheckMaterialType2.Checked = True Then W7262.CheckMaterialType = "2"

                If rad_CheckMarketType1.Checked = True Then W7262.CheckMarketType = "1"
                If rad_CheckMarketType2.Checked = True Then W7262.CheckMarketType = "2"

                If opt_XCHK0.Checked = True Then W7262.CheckUse = "1"
                If opt_XCHK1.Checked = True Then W7262.CheckUse = "2"

                Call DATA_MOVE_DEFAULT()

                W7262.DateInsert = Pub.DAT
                W7262.InchargeInsert = Pub.SAW
                W7262.CheckSupplierPrice = "3"

                If WRITE_PFK7262(W7262) = True Then
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

            If K7262_MOVE(Me, W7262, 3, L7262.ContractID) = True Then
                If rad_CheckProcessType1.Checked = True Then W7262.CheckProcessType = "1"
                If rad_CheckProcessType2.Checked = True Then W7262.CheckProcessType = "2"

                If rad_CheckIOType1.Checked = True Then W7262.CheckIOType = "1"
                If rad_CheckIOType2.Checked = True Then W7262.CheckIOType = "2"

                If rad_CheckMaterialType1.Checked = True Then W7262.CheckMaterialType = "1"
                If rad_CheckMaterialType2.Checked = True Then W7262.CheckMaterialType = "2"

                If rad_CheckMarketType1.Checked = True Then W7262.CheckMarketType = "1"
                If rad_CheckMarketType2.Checked = True Then W7262.CheckMarketType = "2"

                If rad_CheckRelationType1.Checked = True Then W7262.CheckRelationType = "1"
                If rad_CheckRelationType2.Checked = True Then W7262.CheckRelationType = "2"

                If opt_XCHK0.Checked = True Then W7262.CheckUse = "1"
                If opt_XCHK1.Checked = True Then W7262.CheckUse = "2"

                Call DATA_MOVE_DEFAULT()

                W7262.DateUpdate = Pub.DAT
                W7262.InchargeUpdate = Pub.SAW

                If REWRITE_PFK7262(W7262) = True Then
                    Call DATA_MOVE_WRITE01()

                    isudCHK = True
                    Me.Dispose()
                End If
            End If
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_UPDATE")
        End Try
    End Sub

    Private Sub DATA_UPDATE_AFTER()
        Try

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_UPDATE")
        End Try
    End Sub
    Private Sub DATA_DELETE()

        Try
            If READ_PFK7262(L7262.ContractID) Then
                W7262 = D7262
                Call DELETE_PFK7262(W7262)

                Call Delete_History("PFK7262", W7262.ContractID)
            End If

        Catch ex As Exception
            Call MsgBoxP("38", "DATA_DELETE")
        End Try

    End Sub
    Private Function DATA_LINE_DELETE(xrow As Integer) As Boolean
        DATA_LINE_DELETE = False

        Try
            If READ_PFK7263(getData(Vs1, getColumIndex(Vs1, "KEY_ContractID"), xrow),
                            getData(Vs1, getColumIndex(Vs1, "KEY_ContracSeq"), xrow)) = True Then

                W7263 = D7263

                If DELETE_PFK7263(W7263) = True Then

                    Call Delete_History("PFK7263", W7263.ContractID & "-" & W7263.MaterialCode & "-" & W7263.ColorName)

                    isudCHK = True
                End If
            End If
            DATA_LINE_DELETE = True
        Catch ex As Exception
            Call MsgBoxP("38", "DATA_DELETE")
        End Try

    End Function

    Private Sub KEY_COUNT()
        Dim YRNO As Integer
        YRNO = Mid(Pub.DAT, 3, 4)

        Try
            SQL = "SELECT MAX(CAST(K7262_ContractID AS DECIMAL)) AS MAX_MCODE FROM PFK7262 "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                W7262.ContractID = "000001"
            Else
                W7262.ContractID = Format(CIntp(rd!MAX_MCODE + 1), "000000")
            End If

            rd.Close()

            txt_ContractID.Data = W7262.ContractID
            L7262.ContractID = W7262.ContractID

            L7263.ContractID = W7262.ContractID
            W7263.ContractID = W7262.ContractID

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub

    Private Sub KEY_COUNT_SEQ()
        Try
            SQL = "SELECT MAX(CAST(K7263_ContracSeq AS DECIMAL)) AS MAX_MCODE FROM PFK7263 WHERE K7263_ContractID =  '" + L7262.ContractID + "'"

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                W7263.ContracSeq = 1
            Else
                W7263.ContracSeq = CIntp(rd!MAX_MCODE + 1)
            End If

            rd.Close()

            L7263.ContracSeq = W7263.ContracSeq
            W7263.ContracSeq = W7263.ContracSeq

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub

    Private Function Data_Check() As Boolean
        Data_Check = False
        Dim AmtBegin As Decimal
        Dim AmtEnd As Decimal

        Try

            If txt_cdUnitPrice.Code = "001" Then txt_PriceExchange.Data = "1"

            If txt_cdUnitPrice.Code <> "001" Then
                If READ_PFK7171(ListCode("UnitPrice"), txt_cdUnitPrice.Code) Then
                    AmtBegin = CDecp(D7171.CheckName9)
                    AmtEnd = CDecp(D7171.CheckName10)

                    If CDecp(txt_PriceExchange.Data) < AmtBegin Or CDecp(txt_PriceExchange.Data) > AmtEnd Then MsgBoxEx("Wrong Price Exchange!") : Setfocus(txt_PriceExchange) : Exit Function

                End If
            End If


            Data_Check = True

        Catch ex As Exception

        End Try
    End Function
    Private Function DATA_UPDATE_APPROVED(xStatus As String) As Boolean
        DATA_UPDATE_APPROVED = False

        Try
            If READ_PFK7262(L7262.ContractID) = True Then
                W7262 = D7262
                Select Case xStatus
                    Case "1"
                        W7262.CheckSupplierPrice = xStatus
                        W7262.DatePending1 = ""

                    Case "3"
                        W7262.CheckSupplierPrice = xStatus
                        W7262.DateApproved = Pub.DAT

                    Case "5"
                        W7262.CheckSupplierPrice = xStatus
                        W7262.DatePending2 = ""

                    Case "6"
                        W7262.CheckSupplierPrice = xStatus
                        W7262.DatePending2 = Pub.DAT

                End Select

                If REWRITE_PFK7262(W7262) = True Then
                    isudCHK = True
                End If
            End If

            DATA_UPDATE_APPROVED = True
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_UPDATE")
        End Try

    End Function
#End Region

#Region "Event"
    Private Sub tst_iSave_Click(sender As Object, e As EventArgs) Handles tst_iSave.Click
        Select Case wJOB
            Case 1
                If DataCheck(Me, "PFK7262") = False Then Exit Sub
                If Data_Check() = False Then Exit Sub
                Call KEY_COUNT()
                Call DATA_INSERT()

                wJOB = 3
                Call DATA_SEARCH_VS1()
                Setfocus(txt_CustomerCode)

            Case 2
                Me.Dispose()
            Case 3
                If DataCheck(Me, "PFK7262") = False Then Exit Sub
                If Data_Check() = False Then Exit Sub

                Call DATA_UPDATE()
            Case 4
                Call DATA_DELETE()

            Case 5
                Call DATA_UPDATE_AFTER()

            Case 91
                Call DATA_UPDATE_APPROVED("6")  'PENDDING 2
                WRITE_CHK = "*"

                Me.Dispose()

            Case 92
                Call DATA_UPDATE_APPROVED("3")  'Approved
                WRITE_CHK = "*"

                Me.Dispose()

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
        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

        If CHK(4) <> "1" Then
            Call MsgBoxP("4", "tst_iDelete_Click")
            Exit Sub
        End If

        Dim str As String = MsgBoxP("Do you want to delete it?", vbYesNo)

        If str <> vbYes Then Exit Sub
        Call DATA_DELETE()
        Me.Dispose()

    End Sub

    Private Sub Vs1_ButtonClicked(sender As Object, e As EditorNotifyEventArgs) Handles Vs1.ButtonClicked
        Exit Sub

        'Dim xCOL As Integer
        'Dim xROW As Integer

        'xROW = e.Row
        'xCOL = e.Column

        'Select Case xCOL
        '    Case getColumIndex(Vs1, "cLMaterialCode")
        '        HLP7231C.ShowDialog()
        '        If hlp0000SeVaTt = "" Then Exit Sub

        '        Call READ_PFK7231(hlp0000SeVaTt)
        '        Call SetData_Material(Vs1, xROW)

        'End Select

        'vSChange(e.Row)
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
        ListColumn.Add(getColumIndex(Vs1, "PriceMaterialVND"))

        Try
            xROW = e.Row
            xCOL = e.Column

            If ListColumn.Contains(xCOL) Then

                vSChange(xROW)

            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub vSChange(xROW As Integer)
        If wJOB = 2 Then Exit Sub
        Try
            Dim PriceMaterialVND As Decimal

            PriceMaterialVND = getData(Vs1, getColumIndex(Vs1, "PriceMaterialVND"), xROW)

            setData(Vs1, getColumIndex(Vs1, "PriceMaterialEX"), xROW, PriceMaterialVND * CDecp(txt_PriceExchange.Data))

        Catch ex As Exception

        End Try
    End Sub


    Private Sub vS1_KeyDown(sender As Object, e As KeyEventArgs) Handles Vs1.KeyDown
        If wJOB = 2 And wJOB = 5 Then Exit Sub
        Dim xCOL As Long
        Dim xROW As Long

        xCOL = Vs1.ActiveSheet.ActiveColumnIndex
        xROW = Vs1.ActiveSheet.ActiveRowIndex

        Select Case e.KeyCode

            Case Keys.Delete
                Msg_Result = MsgBoxP("Do you want to delete?", vbYesNo)
                If Msg_Result <> vbYes Then Exit Sub

                SPR_DEL(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex)
                Vs1.Focus()

            Case Keys.Enter
                Select Case xCOL
                    Case getColumIndex(sender, "CLMaterialCode")
                        HLP7231C.ShowDialog()
                        If hlp0000SeVaTt = "" Then Exit Sub
                        Call READ_PFK7231(hlp0000SeVaTt)
                        Call SetData_Material(Vs1, xROW)


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
            rad_CheckProcessType1.Checked = True

            cmb_CheckInPurchasingOrder.Visible = False
            cmb_CheckOutPurchasingOrder.Visible = True
        End If

    End Sub


#End Region

End Class
