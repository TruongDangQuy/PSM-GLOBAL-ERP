Public Class ISUD3411B

#Region "Variable"
    Private wJOB As Integer

    Private W3411 As New T3411_AREA
    Private L3411 As New T3411_AREA

    Private W3412 As New T3412_AREA
    Private L3412 As New T3412_AREA

    Private W3413 As New T3413_AREA
    Private L3413 As New T3413_AREA

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

    Private strSupplierCode As String
    Private strInvoiceNo As String
    Private strDateInvoice As String

#End Region

#Region "Link"
    Public Function Link_ISUD3411B(job As Integer, PurchasingOrderNo As String, SupplierCode As String, InvoiceNo As String, DateInvoice As String, Optional ByVal TAG As String = "") As Boolean
        Link_ISUD3411B = False

        Try
            Me.Tag = TAG

            strSupplierCode = SupplierCode
            strInvoiceNo = InvoiceNo
            strDateInvoice = DateInvoice

            txt_InvoiceNo.Data = strInvoiceNo

            D3411.PurchasingOrderNo = PurchasingOrderNo
            D3412.PurchasingOrderNo = PurchasingOrderNo

            wJOB = job : L3411 = D3411 : L3412 = D3412



            Select Case job
                Case 1
                Case Else
                    If READ_PFK3411(L3411.PurchasingOrderNo) = False Then
                        MsgBox("Error ==>> Try your actions again Data!")

                        Me.Dispose()
                        Exit Function
                    Else
                        L3411 = D3411
                    End If

                    pri_CustomerCode = L3411.CustomerCode

                    txt_DateAccept.Enabled = False
            End Select


            formA = False
            Me.ShowDialog()

            Link_ISUD3411B = isudCHK
        Catch ex As Exception
            Call MsgBoxP("61", WordConv("Request Order Processing"))
        End Try
    End Function


    Public Function Link_ISUD3411B_AUTO(job As Integer, cdSeason As String, CustomerCode As String, SupplierCode As String, _Line As String, _cdLargeGroupMaterial As String, _cdSemiGroupMaterial As String, _checkSample As String, PurchasingOrderNo As String, Optional ByVal TAG As String = "") As Boolean
        Link_ISUD3411B_AUTO = False

        Try
            Me.Tag = TAG
            Chk_AutoLink = True

            D3411.SupplierCode = SupplierCode
            D3411.cdSeason = cdSeason
            D3411.PurchasingOrderNo = PurchasingOrderNo

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

            wJOB = job : L3411 = D3411

            Select Case job
                Case 1
                Case Else
                    If READ_PFK3411(L3411.PurchasingOrderNo) = False Then
                        MsgBox("Error ==>> Try your actions again Data!")

                        Me.Dispose()
                        Exit Function
                    Else
                        L3411 = D3411
                    End If
                    txt_DateAccept.Enabled = False
            End Select

            pri_CustomerCode = L3411.CustomerCode

            formA = False
            Me.ShowDialog()

            Link_ISUD3411B_AUTO = isudCHK
        Catch ex As Exception
            '          Call MsgBoxP("61", WordConv("Request Order Processing"))
        End Try
    End Function

    Public Function Link_ISUD3411B_AUTO_NEW(job As Integer, PRNO As String, Value As String, Optional ByVal TAG As String = "") As Boolean
        Link_ISUD3411B_AUTO_NEW = False
        Try
            Me.Tag = TAG
            Chk_AutoLink = True

            Call READ_PFK3011_1(PRNO)

            If READ_PFK7101(D3011.SupplierCode) Then
                txt_SupplierCode.Code = D7101.CustomerCode
                txt_SupplierCode.Data = D7101.CustomerNameSimply
            End If

            wJOB = job : L3411 = D3411

            Select Case job
                Case 1
                Case Else
                    If READ_PFK3411(L3411.PurchasingOrderNo) = False Then
                        Call MsgBoxP("3", "LINK_ISUD")

                        Me.Dispose()
                        Exit Function
                    Else
                        L3411 = D3411
                    End If
                    txt_DateAccept.Enabled = False

            End Select
            pri_CustomerCode = L3411.CustomerCode

            formA = False
            Me.ShowDialog()

            Link_ISUD3411B_AUTO_NEW = isudCHK
        Catch ex As Exception
            '            Call MsgBoxP("61", WordConv("Request Order Processing"))
        End Try


    End Function

    Public Function Link_ISUD3411B_INSERT_MULTI(job As Integer, Value As String, Optional ByVal TAG As String = "") As Boolean
        Link_ISUD3411B_INSERT_MULTI = False
        Try
            List_AutoKey = Value


            Me.Tag = TAG

            wJOB = job : L3411 = D3411

            Select Case job
                Case 11


            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD3411B_INSERT_MULTI = isudCHK
        Catch ex As Exception

        End Try


    End Function

#End Region

#Region "Form"
    Private Sub Form_Activate(Vs1 As Object, e As EventArgs) Handles Me.Load
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

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS1()
                Call DATA_SEARCH_VS2()
                Call DATA_SEARCH_VS0()
                Call HideColumn()

                '-------------------------------------------------------------------------------------------------- Start
                ' Data Check ==>> Customer, Department
                'If CheckData_Customer(Me.FindForm.FindCode("CustomerCode").Code(), wJOB) = False Then
                '    isudCHK = False
                '    formA = True
                '    MsgBoxP("No Correct Customer !")
                '    Exit Sub
                'End If

                'If CheckData_Department(Me.FindForm.FindCode("cdDepartment").Code(), wJOB) = False Then
                '    isudCHK = False
                '    formA = True
                '    MsgBoxP("No Correct Department !")
                '    Exit Sub
                'End If
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

                txt_PurchasingOrderNo.Enabled = False
                tst_iDelete.Visible = False
                tst_iSave.Visible = True


                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS1()
                Call DATA_SEARCH_VS2()
                Call DATA_SEARCH_VS0()
                Call HideColumn()

                '-------------------------------------------------------------------------------------------------- Start
                ' Data Check ==>> Customer, Department

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

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS1()
                Call DATA_SEARCH_VS2()
                Call DATA_SEARCH_VS0()
                Call HideColumn()
                '-------------------------------------------------------------------------------------------------- Start
                ' Data Check ==>> Customer, Department

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
                txt_PurchasingOrderNo.Enabled = False


                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS1()
                Call DATA_SEARCH_VS0()
                Call HideColumn()

                '-------------------------------------------------------------------------------------------------- Start
                ' Data Check ==>> Customer, Department
                'If CheckData_Customer(Me.FindForm.FindCode("CustomerCode").Code(), wJOB) = False Then
                '    isudCHK = False
                '    formA = True
                '    MsgBoxP("No Correct Customer !")
                '    Exit Sub
                'End If

                'If CheckData_Department(Me.FindForm.FindCode("cdDepartment").Code(), wJOB) = False Then
                '    isudCHK = False
                '    formA = True
                '    MsgBoxP("No Correct Department !")
                '    Exit Sub
                'End If
                '-------------------------------------------------------------------------------------------------- End

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


        End Select

        If wJOB = 1 Then txt_DateExchange.Data = Pub.DAT

        formA = True
    End Sub
#End Region

#Region "Search"
    Private Function DATA_SEARCH01() As Boolean
        DATA_SEARCH01 = False

        DS1 = PrcDS("USP_ISUD3411B_SEARCH_HEAD", cn, L3411.PurchasingOrderNo)

        If GetDsRc(DS1) = 0 Then
            Exit Function
            isudCHK = False
        End If

        Call STORE_MOVE(Me, DS1)

        txt_PriceExchange.Data = FormatNumber(CDecp(txt_PriceExchange.Data), 2)

        DATA_SEARCH01 = True

    End Function

    Private Function DATA_SEARCH_VS0() As Boolean
        DATA_SEARCH_VS0 = False

        If SplitContainer1.Panel1Collapsed = True Then Exit Function

        DS1 = PrcDS("USP_ISUD3411B_SEARCH_VS0", cn, L3411.PurchasingOrderNo)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS0, DS1, "USP_ISUD3411B_SEARCH_VS0", "VS0")
            vS0.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS0, DS1, "USP_ISUD3411B_SEARCH_VS0", "VS0")


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

            DS1 = PrcDS("USP_ISUD3411B_SEARCH_VS1_INSERT_MULTI", cn, List_AutoKey)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs1, DS1, "USP_ISUD3411B_SEARCH_VS1", "Vs1")
                Vs1.ActiveSheet.RowCount = 1
                Vs1.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(Vs1, DS1, "USP_ISUD3411B_SEARCH_VS1", "Vs1")

            DS2 = PrcDS("USP_PFP71011_SEARCH_VS1_LINE", cn, txt_SupplierCode.Code)
            If GetDsRc(DS2) = 0 Then Exit Function

            Call STORE_MOVE(Me, DS2)


            DATA_SEARCH_VS1_INSERT = True

        Catch ex As Exception

        End Try
    End Function

    Private Function DATA_SEARCH_VS1() As Boolean
        DATA_SEARCH_VS1 = False
        Try
            Dim i As Integer

            DS1 = PrcDS("USP_ISUD3411B_SEARCH_VS1", cn, L3411.PurchasingOrderNo, strInvoiceNo, strSupplierCode, strDateInvoice)
            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs1, DS1, "USP_ISUD3411B_SEARCH_VS1", "Vs1")
                Vs1.ActiveSheet.RowCount = 1
                Vs1.Enabled = True
                Exit Function
            End If


            For i = 0 To Vs1.ActiveSheet.RowCount - 1

            Next

            SPR_PRO_NEW(Vs1, DS1, "USP_ISUD3411B_SEARCH_VS1", "Vs1")

            DATA_SEARCH_VS1 = True

        Catch ex As Exception

        End Try
    End Function
#End Region

#Region "Function"

    Private Sub DATA_MOVE_DEFAULT()

    End Sub

    Private Sub DATA_MOVE_WRITE01()

        Dim intRow As Integer
        Dim j As Integer
        j = 0

        If READ_PFK3411(L3411.PurchasingOrderNo) Then
            W3411 = D3411
            W3411.DateDelivery = txt_DateDelivery.Data
            W3411.DateStart = txt_DateStart.Data

            Call REWRITE_PFK3411(W3411)
        End If

        For intRow = 0 To Vs1.ActiveSheet.RowCount - 1

            If READ_PFK3412(getData(Vs1, getColumIndex(Vs1, "KEY_PurchasingOrderNo"), intRow), getData(Vs1, getColumIndex(Vs1, "KEY_PurchasingOrderSeq"), intRow)) Then
                W3412 = D3412
                W3412.DateDelivery = FormatCut(getData(Vs1, getColumIndex(Vs1, "DateDelivery"), intRow))
                W3412.DateStart = FormatCut(getData(Vs1, getColumIndex(Vs1, "DateStart"), intRow))

                W3412.PricePurchasing = CDecp(getData(Vs1, getColumIndex(Vs1, "PricePurchasing"), intRow))


                If txt_InvoiceNo.Data = W3412.InvoiceNo1 Then
                    W3412.QtyAArrive1 = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyAArrive1"), intRow))

                ElseIf txt_InvoiceNo.Data = W3412.InvoiceNo2 Then
                    W3412.QtyAArrive2 = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyAArrive2"), intRow))

                ElseIf txt_InvoiceNo.Data = W3412.InvoiceNo3 Then
                    W3412.QtyAArrive3 = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyAArrive3"), intRow))

                ElseIf txt_InvoiceNo.Data = W3412.InvoiceNo4 Then
                    W3412.QtyAArrive4 = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyAArrive4"), intRow))

                ElseIf txt_InvoiceNo.Data = W3412.InvoiceNo5 Then
                    W3412.QtyAArrive5 = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyAArrive5"), intRow))

                End If


                W3412.QtyATotal = W3412.QtyAArrive1 + W3412.QtyAArrive2 + W3412.QtyAArrive3 + W3412.QtyAArrive4 + W3412.QtyAArrive5

                W3412.AmtATotal = W3412.QtyATotal * W3412.PricePurchasing

                W3412.InchargeInvoice = Pub.SAW

                D3412.AInvoice = D3412.InvoiceNo1 + IIf(D3412.InvoiceNo2 <> "", "," + D3412.InvoiceNo2, "")
                D3412.AInvoice += IIf(D3412.InvoiceNo3 <> "", "," + D3412.InvoiceNo3, "")
                D3412.AInvoice += IIf(D3412.InvoiceNo4 <> "", "," + D3412.InvoiceNo4, "")
                D3412.AInvoice += IIf(D3412.InvoiceNo5 <> "", "," + D3412.InvoiceNo5, "")


                Call REWRITE_PFK3412(W3412)



            End If


        Next



    End Sub


    Private Sub DATA_INSERT()

        Try
            Call DATA_MOVE_WRITE01()
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_UPDATE")
        End Try

    End Sub

    Private Sub DATA_UPDATE()
        Try
            Call DATA_MOVE_WRITE01()

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_UPDATE")
        End Try
    End Sub

    Private Sub DATA_CLOSE()
        Try
            Call PrcExeNoError("EXP_CLOSSING_PFK3412_INVOICE", cn, txt_PurchasingOrderNo.Data)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub DATA_UPDATE_AFTER()

    End Sub
    Private Sub DATA_DELETE()
        Dim i As Integer

        Try
            If ptc_Main.SelectedIndex = 0 Then
                For i = 0 To Vs1.ActiveSheet.RowCount - 1
                    Call DATA_LINE_DELETE(i)
                Next

            End If
        Catch ex As Exception
            Call MsgBoxP("38", "DATA_DELETE")
        End Try

    End Sub

    Private Sub Vs1_Change(sender As Object, e As ChangeEventArgs) Handles Vs1.Change
        If wJOB = 2 And wJOB = 5 Then Exit Sub
        Dim xCOL As Long
        Dim xROW As Long
        Dim i As Integer
        Dim Value1() As String
        Dim Value2(5) As String

        xCOL = Vs1.ActiveSheet.ActiveColumnIndex
        xROW = Vs1.ActiveSheet.ActiveRowIndex


        Try
            Dim decTotalQty As Decimal
            Dim decRowQty As Decimal
            Dim decRemQty As Decimal
            Dim Key_Sequence As String

            decTotalQty = CDecp(getData(Vs1, xCOL, xROW))
            decRemQty = CDecp(getData(Vs1, xCOL, xROW))


            Key_Sequence = getData(Vs1, getColumIndex(Vs1, "KEY_Sequence"), xROW)

            'If decTotalQty = 0 Then Exit Sub
            If xROW > 0 Or CDecp(getData(Vs1, xCOL, xROW - 1)) = 0 Then
                For i = xROW To Vs1.ActiveSheet.RowCount - 1
                    setData(Vs1, xCOL, i, 0)
                    If Key_Sequence <> getData(Vs1, getColumIndex(Vs1, "KEY_Sequence"), i) Then
                        setData(Vs1, xCOL, i, decTotalQty)
                        Exit For
                    End If


                Next

                For i = xROW To Vs1.ActiveSheet.RowCount - 1

                    If Key_Sequence <> getData(Vs1, getColumIndex(Vs1, "KEY_Sequence"), i) Then

                        If decRemQty > 0 Then
                            setData(Vs1, xCOL, i - 1, decRemQty + CDecp(getData(Vs1, getColumIndex(Vs1, "QtyPurchasing"), i - 1)))
                        End If

                        Exit For


                    End If

                    decRowQty = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyPurchasing"), i))

                    If decRowQty = 0 Then
                        setData(Vs1, xCOL, i - 1, decRemQty + CDecp(getData(Vs1, xCOL, i - 1)))
                        Exit For
                    End If

                    If decRemQty <= decRowQty Then
                        setData(Vs1, xCOL, i, decRemQty)
                        Exit For

                    ElseIf decRemQty > decRowQty Then
                        setData(Vs1, xCOL, i, decRowQty)


                    End If

                    decRemQty = decRemQty - decRowQty


                Next

                'setData(Vs1, xCOL, i, decTotalQty)

            End If

        Catch ex As Exception

        End Try
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

                Dim str As String = MsgBoxP("Do you want to delete it?", vbYesNo)

                If str <> vbYes Then Exit Sub

                Call DATA_LINE_DELETE(xROW)
                SPR_DEL(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex)
                Vs1.Focus()

            Case Keys.Enter
                Dim decTotalQty As Decimal
                Dim decRowQty As Decimal
                Dim decRemQty As Decimal
                Dim Key_Sequence As String

                decTotalQty = CDecp(getData(Vs1, xCOL, xROW))
                decRemQty = CDecp(getData(Vs1, xCOL, xROW))


                Key_Sequence = getData(Vs1, getColumIndex(Vs1, "KEY_Sequence"), xROW)

                'If decTotalQty = 0 Then Exit Sub
                If xROW > 0 Or CDecp(getData(Vs1, xCOL, xROW - 1)) = 0 Then
                    For i = xROW To Vs1.ActiveSheet.RowCount - 1
                        setData(Vs1, xCOL, i, 0)
                        If Key_Sequence <> getData(Vs1, getColumIndex(Vs1, "KEY_Sequence"), i) Then
                            setData(Vs1, xCOL, i, decTotalQty)
                            Exit For
                        End If


                    Next

                    For i = xROW To Vs1.ActiveSheet.RowCount - 1

                        If Key_Sequence <> getData(Vs1, getColumIndex(Vs1, "KEY_Sequence"), i) Then

                            If decRemQty > 0 Then
                                setData(Vs1, xCOL, i - 1, decRemQty + CDecp(getData(Vs1, getColumIndex(Vs1, "QtyPurchasing"), i - 1)))
                            End If

                            Exit For


                        End If

                        decRowQty = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyPurchasing"), i))

                        If decRowQty = 0 Then
                            setData(Vs1, xCOL, i - 1, decRemQty + CDecp(getData(Vs1, xCOL, i - 1)))
                            Exit For
                        End If

                        If decRemQty <= decRowQty Then
                            setData(Vs1, xCOL, i, decRemQty)
                            Exit For

                        ElseIf decRemQty > decRowQty Then
                            setData(Vs1, xCOL, i, decRowQty)


                        End If

                        decRemQty = decRemQty - decRowQty


                    Next

                    'setData(Vs1, xCOL, i, decTotalQty)

                End If

        End Select

    End Sub
    Private Function DATA_LINE_DELETE(intRow As Integer) As Boolean
        DATA_LINE_DELETE = False

        Try


            If READ_PFK3412(getData(Vs1, getColumIndex(Vs1, "KEY_PurchasingOrderNo"), intRow), getData(Vs1, getColumIndex(Vs1, "KEY_PurchasingOrderSeq"), intRow)) Then
                W3412 = D3412
                W3412.DateDelivery = FormatCut(getData(Vs1, getColumIndex(Vs1, "DateDelivery"), intRow))
                W3412.DateStart = FormatCut(getData(Vs1, getColumIndex(Vs1, "DateStart"), intRow))

                W3412.PricePurchasing = CDecp(getData(Vs1, getColumIndex(Vs1, "PricePurchasing"), intRow))


                If txt_InvoiceNo.Data = W3412.InvoiceNo1 Then
                    W3412.QtyAArrive1 = 0
                    W3412.DateArrive1 = ""
                    W3412.InvoiceNo1 = ""

                ElseIf txt_InvoiceNo.Data = W3412.InvoiceNo2 Then
                    W3412.QtyAArrive2 = 0
                    W3412.DateArrive2 = ""
                    W3412.InvoiceNo2 = ""

                ElseIf txt_InvoiceNo.Data = W3412.InvoiceNo3 Then
                    W3412.QtyAArrive3 = 0
                    W3412.DateArrive3 = ""
                    W3412.InvoiceNo3 = ""

                ElseIf txt_InvoiceNo.Data = W3412.InvoiceNo4 Then
                    W3412.QtyAArrive4 = 0
                    W3412.DateArrive4 = ""
                    W3412.InvoiceNo4 = ""

                ElseIf txt_InvoiceNo.Data = W3412.InvoiceNo5 Then
                    W3412.QtyAArrive5 = 0
                    W3412.DateArrive5 = ""
                    W3412.InvoiceNo5 = ""

                End If


                W3412.QtyATotal = W3412.QtyAArrive1 + W3412.QtyAArrive2 + W3412.QtyAArrive3 + W3412.QtyAArrive4 + W3412.QtyAArrive5

                W3412.AmtATotal = W3412.QtyATotal * W3412.PricePurchasing

                W3412.InchargeInvoice = Pub.SAW
                D3412.AInvoice = D3412.InvoiceNo1 + IIf(D3412.InvoiceNo2 <> "", "," + D3412.InvoiceNo2, "")
                D3412.AInvoice += IIf(D3412.InvoiceNo3 <> "", "," + D3412.InvoiceNo3, "")
                D3412.AInvoice += IIf(D3412.InvoiceNo4 <> "", "," + D3412.InvoiceNo4, "")
                D3412.AInvoice += IIf(D3412.InvoiceNo5 <> "", "," + D3412.InvoiceNo5, "")



                Call REWRITE_PFK3412(W3412)



            End If



            DATA_LINE_DELETE = True
        Catch ex As Exception
            Call MsgBoxP("38", "DATA_DELETE")
        End Try

    End Function


    Private Sub FORM_INIT()
        SplitContainer1.Panel1Collapsed = True


    End Sub

    Private Sub DATA_INIT()
        Try


            txt_PriceExchange.Data = 1


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


            Data_Check = True
        Catch ex As Exception

        End Try
    End Function
    Private Sub HideColumn()

    End Sub

#End Region

#Region "Event"
    Private Sub tst_iSave_Click(Vs1 As Object, e As EventArgs) Handles tst_iSave.Click
        Select Case wJOB
            Case 1, 11


                'If DataCheck(Me, "PFK3411") = False Then Exit Sub
                'If Data_Check() = False Then Exit Sub
                Call DATA_INSERT()
                Call DATA_CLOSE()
                Chk_AutoLink = False

                wJOB = 3
                Call DATA_SEARCH_VS1()
                Call DATA_SEARCH_VS2()
                Call DATA_SEARCH_VS0()
                Call HideColumn()

                MsgBoxP("Insert Successfylly !", vbInformation)

            Case 2
                Me.Dispose()
            Case 3
                'If CheckData_Incharge(Me.FindForm.FindCode("InchargePurchasing").Code(), wJOB) = False Then
                '    MsgBox("No Correct InchargePurchasing !")
                '    Exit Sub
                'End If

                'If READ_PFK3429_FactOrder(txt_PurchasingOrderNo.Data, "") = True Then
                '    MsgBox("Already make Payable can't modify !")
                '    Exit Sub
                'End If


                'If DataCheck(Me, "PFK3411") = False Then Exit Sub
                'If Data_Check() = False Then Exit Sub
                Call DATA_UPDATE()
                Call DATA_CLOSE()
                Call DATA_SEARCH_VS1()
                'Call DATA_SEARCH_VS2()
                'Call DATA_SEARCH_VS0()
                Chk_AutoLink = False
                Call HideColumn()

                MsgBoxP("Update Successfylly !", vbInformation)

            Case 4
                'If CheckData_Incharge(Me.FindForm.FindCode("InchargePurchasing").Code(), wJOB) = False Then
                '    MsgBox("No Correct InchargePurchasing !")
                '    Exit Sub
                'End If

                'If READ_PFK3429_FactOrder(txt_PurchasingOrderNo.Data, "") = True Then
                '    MsgBox("Already make Payable can't modify !")
                '    Exit Sub
                'End If


                Call DATA_DELETE()

            Case 5

                If Data_Check() = False Then Exit Sub

                Call DATA_UPDATE_AFTER()
                Call DATA_CLOSE()
                Call DATA_SEARCH_VS1()
                Call DATA_SEARCH_VS2()
                Call DATA_SEARCH_VS0()

                MsgBoxP("Update Successfylly !", vbInformation)

                Chk_AutoLink = False
        End Select
    End Sub

    Private Sub tst_iClose_Click(Vs1 As Object, e As EventArgs) Handles tst_iClose.Click
        If WRITE_CHK = "*" Then
            isudCHK = True
        Else
            isudCHK = False
        End If

        Me.Dispose()
    End Sub
    Private Sub txt_DateDelivery_txtTextKeyDown(sender As Object, e As KeyEventArgs) Handles txt_DateDelivery.txtTextKeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                If READ_PFK7101(txt_SupplierCode.Code) Then
                    If D7101.cdSupplierGroup = "001" Then txt_DateStart.Data = Function_Date_Add(CDate(FSDate(txt_DateDelivery.Data)), 0, 7)
                    If D7101.cdSupplierGroup = "002" Then txt_DateStart.Data = Function_Date_Add(CDate(FSDate(txt_DateDelivery.Data)), 0, 12)
                End If


            Catch ex As Exception

            End Try
        End If
    End Sub
    Private Sub tst_iDelete_Click(Vs1 As Object, e As EventArgs) Handles tst_iDelete.Click
        'If CheckData_Incharge(Me.FindForm.FindCode("InchargePurchasing").Code(), wJOB) = False Then
        '    MsgBox("No Correct InchargePurchasing !")
        '    Exit Sub
        'End If

        Dim str As String = MsgBoxP("Do you want to delete it?", vbYesNo)

        If str <> vbYes Then Exit Sub

        Call DATA_DELETE()

        Me.Dispose()
    End Sub

#End Region

    Private Sub txt_DateDelivery_Load(sender As Object, e As EventArgs) Handles txt_DateDelivery.Load

    End Sub
End Class
