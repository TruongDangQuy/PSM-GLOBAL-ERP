Public Class ISUD7360A

#Region "Variable"
    Private wJOB As Integer

    Private W7360 As New T7360_AREA
    Private L7360 As New T7360_AREA

    Private W7361 As New T7361_AREA
    Private L7361 As New T7361_AREA

    Private W3011 As New T3011_AREA

    Private WRITE_CHK As String
    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_ISUD7360A(job As Integer, ContractID As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        D7360.ContractID = ContractID
        D7361.ContractID = ContractID

        wJOB = job : L7360 = D7360 : L7361 = D7361

        Link_ISUD7360A = False
        Try

            Select Case job
                Case 1
                    D7360.CustomerCode = ContractID

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
                    If READ_PFK7360(L7360.ContractID) = False Then
                        Call MsgBoxP("3", "LINK_ISUD")

                        Me.Dispose()
                        Exit Function
                    Else
                        L7360 = D7360
                    End If
                    txt_DateAccept.Enabled = False
            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD7360A = isudCHK
        Catch ex As Exception
            Call MsgBoxP("61", WordConv("Link_ISUD7360A"))
        End Try


    End Function

    Private _MaterialCode As String
    Public Function Link_ISUD7360A_MaterialCode(job As Integer, ContractID As String, MaterialCode As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        Link_ISUD7360A_MaterialCode = False

        Dim i As Integer

        Try
            wJOB = job

            D7360.ContractID = ContractID
            D7361.ContractID = ContractID

            L7360 = D7360 : L7361 = D7361

            _MaterialCode = MaterialCode

            Select Case job
                Case 1
                    D7360.CustomerCode = ContractID

                    If READ_PFK7101(ContractID) Then
                        txt_CustomerCode.Code = D7101.CustomerCode
                        txt_CustomerCode.Data = D7101.CustomerName
                        txt_CustomerCode.Enabled = False
                    Else
                        Me.Dispose()
                        Exit Function
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
                    If READ_PFK7360(L7360.ContractID) = False Then
                        Call MsgBoxP("3", "Link_ISUD7360A")

                        Me.Dispose()
                        Exit Function
                    Else
                        L7360 = D7360
                    End If

                    txt_DateAccept.Enabled = False
            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD7360A_MaterialCode = isudCHK
        Catch ex As Exception
            Call MsgBoxP("61", WordConv("Link_ISUD7360A"))
        End Try


    End Function
#End Region

#Region "Form"
    Private Sub Form_Activate(sender As Object, e As EventArgs) Handles Me.Load
        If formA = True Then Exit Sub

        WRITE_CHK = ""
        Me.Form_KeyDown()

        Call DATA_INIT()

        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

        Select Case wJOB
            Case 1
                Me.Text = Me.Text & " - INSERT"
                Frame1.Enabled = True
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

                If rad_CheckType1.Checked = True Then
                    Vs1.ActiveSheet.Columns(getColumnIndex(Vs1, "CLLine")).Visible = False
                    Vs1.ActiveSheet.Columns(getColumnIndex(Vs1, "Line")).Visible = False
                    Vs1.ActiveSheet.Columns(getColumnIndex(Vs1, "CLArticle")).Visible = False
                    Vs1.ActiveSheet.Columns(getColumnIndex(Vs1, "Article")).Visible = False
                Else
                    Vs1.ActiveSheet.Columns(getColumnIndex(Vs1, "FromSize")).Visible = False
                    Vs1.ActiveSheet.Columns(getColumnIndex(Vs1, "ToSize")).Visible = False
                End If

                Setfocus(txt_cdBuyingType)

            Case 2
                Me.Text = Me.Text & " - SEARCH"

                Frame1.Enabled = True
                tst_iDelete.Visible = False
                tst_iSave.Visible = False

                If CHK(2) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS1()

                If rad_CheckType1.Checked = True Then
                    Vs1.ActiveSheet.Columns(getColumnIndex(Vs1, "CLLine")).Visible = False
                    Vs1.ActiveSheet.Columns(getColumnIndex(Vs1, "Line")).Visible = False
                    Vs1.ActiveSheet.Columns(getColumnIndex(Vs1, "CLArticle")).Visible = False
                    Vs1.ActiveSheet.Columns(getColumnIndex(Vs1, "Article")).Visible = False
                Else
                    Vs1.ActiveSheet.Columns(getColumnIndex(Vs1, "FromSize")).Visible = False
                    Vs1.ActiveSheet.Columns(getColumnIndex(Vs1, "ToSize")).Visible = False
                End If


                pcl_CheckField.Enabled = False

            Case 3
                Me.Text = Me.Text & " - UPDATE"
                Frame1.Enabled = True

                tst_iDelete.Visible = False

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS1()

                If rad_CheckType1.Checked = True Then
                    Vs1.ActiveSheet.Columns(getColumnIndex(Vs1, "CLLine")).Visible = False
                    Vs1.ActiveSheet.Columns(getColumnIndex(Vs1, "Line")).Visible = False
                    Vs1.ActiveSheet.Columns(getColumnIndex(Vs1, "CLArticle")).Visible = False
                    Vs1.ActiveSheet.Columns(getColumnIndex(Vs1, "Article")).Visible = False
                Else
                    Vs1.ActiveSheet.Columns(getColumnIndex(Vs1, "FromSize")).Visible = False
                    Vs1.ActiveSheet.Columns(getColumnIndex(Vs1, "ToSize")).Visible = False
                End If


                pcl_CheckField.Enabled = False

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
                        tst_iDelete.Visible = False
                        tst_iSave.Visible = False
                        Call Error_Message("16", "Form_Activate")
                    End If
                End If

            Case 4
                Me.Text = Me.Text & " - DELETE"

                tst_iSave.Visible = False


                If CHK(4) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS1()

                If rad_CheckType1.Checked = True Then
                    Vs1.ActiveSheet.Columns(getColumnIndex(Vs1, "CLLine")).Visible = False
                    Vs1.ActiveSheet.Columns(getColumnIndex(Vs1, "Line")).Visible = False
                    Vs1.ActiveSheet.Columns(getColumnIndex(Vs1, "CLArticle")).Visible = False
                    Vs1.ActiveSheet.Columns(getColumnIndex(Vs1, "Article")).Visible = False
                Else
                    Vs1.ActiveSheet.Columns(getColumnIndex(Vs1, "FromSize")).Visible = False
                    Vs1.ActiveSheet.Columns(getColumnIndex(Vs1, "ToSize")).Visible = False
                End If

                pcl_CheckField.Enabled = False

            Case 5
                Me.Text = Me.Text & " - COPY"

                tst_iDelete.Visible = False

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS1()

                Call KEY_COUNT()
                txt_DateAccept.Data = Pub.DAT
                txt_ContractNo.Data = ""

                pcl_CheckField.Enabled = False

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
                        tst_iDelete.Visible = False
                        tst_iSave.Visible = False
                        Call Error_Message("16", "Form_Activate")
                    End If
                End If

                wJOB = 1
                'Case 91
                '    Me.Text = Me.Text & " - Approved"

                '    tst_iSave.Visible = True
                '    tst_iSave2.Visible = True
                '    tst_iDelete.Visible = False
                '    pcl_CheckField.Enabled = False

                '    tst_iSave2.Text = "NotApproved"
                '    tst_iSave.Text = "Pending2"

                '    Call DATA_SEARCH01()
                '    Call DATA_SEARCH_VS1()

                'Case 92
                '    Me.Text = Me.Text & " - Approved"

                '    tst_iSave.Visible = True
                '    tst_iSave2.Visible = True
                '    tst_iDelete.Visible = False
                '    pcl_CheckField.Enabled = False

                '    tst_iSave2.Text = "Pending1"
                '    tst_iSave.Text = "Approved"

                '    Call DATA_SEARCH01()
                '    Call DATA_SEARCH_VS1()
        End Select

        formA = True

    End Sub
    Private Sub DATA_INIT()
        Try
            tst_iUtilities.Visible = True
            tst_iAttach.Visible = True
            tst_iHistory.Visible = False

            If Me.Tag = "PFP73600RnD" Then
                rad_CheckMaterialType1.Enabled = False
                rad_CheckMaterialType2.Enabled = False

                rad_CheckMaterialType2.Checked = True
            ElseIf Me.Tag = "PFP73600" Then
                rad_CheckMaterialType1.Enabled = False
                rad_CheckMaterialType2.Enabled = False

                rad_CheckMaterialType1.Checked = True
            Else
                rad_CheckMaterialType1.Enabled = True
                rad_CheckMaterialType2.Enabled = True
            End If

            txt_ContractID.Enabled = False
            txt_DateAccept.Data = Pub.DAT
            If wJOB = "1" Then txt_CustomerCode.Enabled = True Else txt_CustomerCode.Enabled = False

            If READ_PFK7411(Pub.SAW) Then
                txt_InchargePurchasing.Data = D7411.Name
                txt_InchargePurchasing.Code = D7411.IDNO
            End If

            If READ_PFK7171_NAME(ListCode("UnitPrice"), "USD") Then
                txt_cdUnitPrice.Code = D7171.BasicCode
                txt_cdUnitPrice.Data = D7171.BasicName
            End If

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

        DS1 = PrcDS("USP_ISUD7360A_SEARCH_HEAD", cn, L7360.ContractID)

        If GetDsRc(DS1) = 0 Then
            Exit Function
            isudCHK = False
        End If

        Call DATASET_MOVE(Me, DS1)

        CheckProcessType(GetDsData(DS1, 0, "K7360_CheckProcessType"))
        CheckIOType(GetDsData(DS1, 0, "K7360_CheckIOType"))
        CheckMaterialType(GetDsData(DS1, 0, "K7360_CheckMaterialType"))
        CheckMarketType(GetDsData(DS1, 0, "K7360_CheckMarketType"))
        CheckRelationType(GetDsData(DS1, 0, "K7360_CheckRelationType"))
        CheckUse(GetDsData(DS1, 0, "K7360_CheckUse"))

        DATA_SEARCH01 = True

    End Function

    Private Function DATA_SEARCH_VS1() As Boolean
        DATA_SEARCH_VS1 = False
        Try
            Dim i As Integer

            DS1 = PrcDS("USP_ISUD7360A_SEARCH_VS1", cn, L7360.ContractID)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs1, DS1, "USP_ISUD7360A_SEARCH_VS1", "Vs1")

                Vs1.ActiveSheet.RowCount = 1

                If _MaterialCode <> "" Then
                    If READ_PFK7231(_MaterialCode) Then
                        setData(Vs1, getColumIndex(Vs1, "MaterialCode"), 0, D7231.MaterialCode)
                        setData(Vs1, getColumIndex(Vs1, "MaterialName"), 0, D7231.MaterialName)
                    End If
                End If

                Vs1.Enabled = True
                Exit Function
            End If


            SPR_PRO_NEW(Vs1, DS1, "USP_ISUD7360A_SEARCH_VS1", "Vs1")

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

        W7360.seTax3 = ListCode("Tax3")
        W7360.seSubProcess = ListCode("SubProcess")
        W7360.cdSubProcess = txt_cdSubProcess.Code
        W7361.seUnitPrice = ListCode("UnitPrice")
        W7360.cdTax3 = txt_cdTax3.Code

        If txt_cdUnitPrice.Data <> "" Then W7361.cdUnitPrice = txt_cdUnitPrice.Code
        If txt_cdTax3.Data <> "" Then W7361.PerTax3 = CIntp(txt_cdTax3.Name)
        W7361.PriceExchange = txt_PriceExchange.Data

        If rad_CheckType1.Checked = True Then W7361.CheckType = "1"
        If rad_CheckType2.Checked = True Then W7361.CheckType = "2"

        If rad_CheckType1.Checked = True Then W7361.CheckSize = "1"
        If rad_CheckType2.Checked = True Then W7361.CheckSize = "2"

    End Sub

    Private Sub DATA_MOVE_WRITE01()

        Dim i As Integer
        Dim j As Integer
        Dim Dseq As Integer

        j = 0
        For i = 0 To Vs1.ActiveSheet.RowCount - 1
            If Trim(getData(Vs1, getColumIndex(Vs1, "MaterialCode"), i)) = "" Then GoTo skip
            Dseq = getData(Vs1, getColumIndex(Vs1, "KEY_ContractSeq"), i)
            L7361.ContractID = txt_ContractID.Data

            j = j + 1


            If K7361_MOVE(Vs1, i, W7361, True, L7361.ContractID, Dseq) = True Then
                W7361.PriceMaterialEX = CDecp(txt_PriceExchange.Data) * W7361.PriceMaterialVND
                Call DATA_MOVE_DEFAULT()
                Call REWRITE_PFK7361(W7361)
            Else
                W7361.ContractID = L7360.ContractID
                W7361.PriceMaterialEX = CDecp(txt_PriceExchange.Data) * W7361.PriceMaterialVND
                Call DATA_MOVE_DEFAULT()
                Call KEY_COUNT_7361()
                Call WRITE_PFK7361(W7361)
            End If
skip:

        Next

    End Sub


    Private Sub DATA_INSERT()

        Try
            If K7360_MOVE(Me, W7360, 1, L7360.ContractID) = False Then

                Call KEY_COUNT()


                If rad_CheckProcessType1.Checked = True Then W7360.CheckProcessType = "1"
                If rad_CheckProcessType2.Checked = True Then W7360.CheckProcessType = "2"

                If rad_CheckIOType1.Checked = True Then W7360.CheckIOType = "1"
                If rad_CheckIOType2.Checked = True Then W7360.CheckIOType = "2"

                If opt_XCHK0.Checked = True Then W7360.CheckUse = "1"
                If opt_XCHK1.Checked = True Then W7360.CheckUse = "2"

                Call DATA_MOVE_DEFAULT()
                If WRITE_PFK7360(W7360) = True Then
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

            If K7360_MOVE(Me, W7360, 3, L7360.ContractID) = True Then
                If rad_CheckProcessType1.Checked = True Then W7360.CheckProcessType = "1"
                If rad_CheckProcessType2.Checked = True Then W7360.CheckProcessType = "2"

                If rad_CheckIOType1.Checked = True Then W7360.CheckIOType = "1"
                If rad_CheckIOType2.Checked = True Then W7360.CheckIOType = "2"

                If opt_XCHK0.Checked = True Then W7360.CheckUse = "1"
                If opt_XCHK1.Checked = True Then W7360.CheckUse = "2"

                Call DATA_MOVE_DEFAULT()
                If REWRITE_PFK7360(W7360) = True Then
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
            If READ_PFK7360(L7360.ContractID) Then
                W7360 = D7360
                Call DELETE_PFK7360(W7360)
            End If

        Catch ex As Exception
            Call MsgBoxP("38", "DATA_DELETE")
        End Try

    End Sub
    Private Function DATA_LINE_DELETE(xrow As Integer) As Boolean
        DATA_LINE_DELETE = False

        Try
            If READ_PFK7361(getData(Vs1, getColumIndex(Vs1, "KEY_ContractID"), xrow),
                            getData(Vs1, getColumIndex(Vs1, "KEY_MaterialCode"), xrow),
                            getData(Vs1, getColumIndex(Vs1, "KEY_ColorName"), xrow)) = True Then

                W7361 = D7361

                If DELETE_PFK7361(W7361) = True Then
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
            SQL = "SELECT MAX(CAST(K7360_ContractID AS DECIMAL)) AS MAX_MCODE FROM PFK7360 "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                W7360.ContractID = "000001"
            Else
                W7360.ContractID = Format(CIntp(rd!MAX_MCODE + 1), "000000")
            End If

            rd.Close()

            txt_ContractID.Data = W7360.ContractID
            L7360.ContractID = W7360.ContractID

            L7361.ContractID = W7360.ContractID
            W7361.ContractID = W7360.ContractID

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub

    Private Sub KEY_COUNT_7361()
        Dim YRNO As Integer
        YRNO = Mid(Pub.DAT, 3, 4)

        Try
            SQL = "SELECT MAX(CAST(K7361_ContractSeq AS DECIMAL)) AS MAX_MCODE FROM PFK7361 "
            SQL = SQL & " WHERE K7361_ContractID = '" & L7361.ContractID & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                W7361.ContractSeq = "1"
            Else
                W7361.ContractSeq = CIntp(rd!MAX_MCODE + 1)
            End If

            rd.Close()

            L7361.ContractSeq = W7361.ContractSeq
            W7361.ContractSeq = W7361.ContractSeq

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT_7361")
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
            If READ_PFK7360(L7360.ContractID) = True Then
                W7360 = D7360
                Select Case xStatus
                    Case "1"
                        W7360.CheckSupplierPrice = xStatus
                        W7360.DatePending1 = ""

                    Case "3"
                        W7360.CheckSupplierPrice = xStatus
                        W7360.DateApproved = Pub.DAT

                    Case "5"
                        W7360.CheckSupplierPrice = xStatus
                        W7360.DatePending2 = ""

                    Case "6"
                        W7360.CheckSupplierPrice = xStatus
                        W7360.DatePending2 = Pub.DAT

                End Select

                If REWRITE_PFK7360(W7360) = True Then
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
                If DataCheck(Me, "PFK7360") = False Then Exit Sub
                If Data_Check() = False Then Exit Sub
                Call KEY_COUNT()
                Call DATA_INSERT()

                wJOB = 3
                Call DATA_SEARCH_VS1()
                If rad_CheckType1.Checked = True Then
                    Vs1.ActiveSheet.Columns(getColumnIndex(Vs1, "FromSize")).Visible = True
                    Vs1.ActiveSheet.Columns(getColumnIndex(Vs1, "ToSize")).Visible = True
                    Vs1.ActiveSheet.Columns(getColumnIndex(Vs1, "CLLine")).Visible = False
                    Vs1.ActiveSheet.Columns(getColumnIndex(Vs1, "Line")).Visible = False
                    Vs1.ActiveSheet.Columns(getColumnIndex(Vs1, "CLArticle")).Visible = False
                    Vs1.ActiveSheet.Columns(getColumnIndex(Vs1, "Article")).Visible = False
                Else
                    Vs1.ActiveSheet.Columns(getColumnIndex(Vs1, "FromSize")).Visible = False
                    Vs1.ActiveSheet.Columns(getColumnIndex(Vs1, "ToSize")).Visible = False
                    Vs1.ActiveSheet.Columns(getColumnIndex(Vs1, "CLLine")).Visible = True
                    Vs1.ActiveSheet.Columns(getColumnIndex(Vs1, "Line")).Visible = True
                    Vs1.ActiveSheet.Columns(getColumnIndex(Vs1, "CLArticle")).Visible = True
                    Vs1.ActiveSheet.Columns(getColumnIndex(Vs1, "Article")).Visible = True
                End If
                Setfocus(txt_CustomerCode)

            Case 2
                Me.Dispose()
            Case 3
                If DataCheck(Me, "PFK7360") = False Then Exit Sub
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

        Dim xCOL As Integer
        Dim xROW As Integer

        xROW = e.Row
        xCOL = e.Column

        Select Case xCOL
            'Case getColumIndex(Vs1, "cLMaterialCode")
            '    HLP7231C.ShowDialog()
            '    If hlp0000SeVaTt = "" Then Exit Sub

            '    Call READ_PFK7231(hlp0000SeVaTt)
            '    Call SetData_Material(Vs1, xROW)


            Case getColumIndex(Vs1, "CLLine")
                HLP7103A.Link_HLP7103A("001", 1)
                If hlp0000SeVaTt1 = "" Then Exit Sub
                Call READ_PFK7103_CdTypeCode(hlp0000SeVaTt1, "001")
                setData(Vs1, getColumIndex(Vs1, "Line"), Vs1.ActiveSheet.ActiveRowIndex, D7103.TypeName)


            Case getColumIndex(Vs1, "CLArticle")
                HLP7103A.Link_HLP7103A("002", 1)
                If hlp0000SeVaTt1 = "" Then Exit Sub
                Call READ_PFK7103_CdTypeCode(hlp0000SeVaTt1, "002")
                setData(Vs1, getColumIndex(Vs1, "Article"), Vs1.ActiveSheet.ActiveRowIndex, D7103.TypeName)

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
        ListColumn.Add(getColumIndex(Vs1, "PriceMaterialVND_7361"))

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

            PriceMaterialVND = getData(Vs1, getColumIndex(Vs1, "PriceMaterialVND_7361"), xROW)

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

                W7361.ContractID = getData(Vs1, getColumIndex(Vs1, "KEY_ContractID"), xROW)
                W7361.MaterialCode = getData(Vs1, getColumIndex(Vs1, "KEY_MaterialCode"), xROW)
                W7361.ColorName = getData(Vs1, getColumIndex(Vs1, "KEY_ColorName"), xROW)

                If READ_PFK7361(W7361.ContractID, W7361.MaterialCode, W7361.ColorName) = True Then

                    If DELETE_PFK7361(W7361) Then

                    End If

                End If

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

    Private Sub rad_CheckType2_CheckedChanged(sender As Object, e As EventArgs) Handles rad_CheckType2.CheckedChanged

        If rad_CheckType1.Checked = True Then
            Vs1.ActiveSheet.Columns(getColumnIndex(Vs1, "FromSize")).Visible = True
            Vs1.ActiveSheet.Columns(getColumnIndex(Vs1, "ToSize")).Visible = True
            Vs1.ActiveSheet.Columns(getColumnIndex(Vs1, "CLLine")).Visible = False
            Vs1.ActiveSheet.Columns(getColumnIndex(Vs1, "Line")).Visible = False
            Vs1.ActiveSheet.Columns(getColumnIndex(Vs1, "CLArticle")).Visible = False
            Vs1.ActiveSheet.Columns(getColumnIndex(Vs1, "Article")).Visible = False
        Else
            Vs1.ActiveSheet.Columns(getColumnIndex(Vs1, "FromSize")).Visible = False
            Vs1.ActiveSheet.Columns(getColumnIndex(Vs1, "ToSize")).Visible = False
            Vs1.ActiveSheet.Columns(getColumnIndex(Vs1, "CLLine")).Visible = True
            Vs1.ActiveSheet.Columns(getColumnIndex(Vs1, "Line")).Visible = True
            Vs1.ActiveSheet.Columns(getColumnIndex(Vs1, "CLArticle")).Visible = True
            Vs1.ActiveSheet.Columns(getColumnIndex(Vs1, "Article")).Visible = True
        End If

    End Sub


#End Region

   
End Class
