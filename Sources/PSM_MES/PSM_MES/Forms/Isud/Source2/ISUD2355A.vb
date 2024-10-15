Public Class ISUD2355A

#Region "Variable"
    Private wJOB As Integer

    Private W2352 As New T2352_AREA
    Private L2352 As New T2352_AREA


    Private WRITE_CHK As String

    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Form"
    Public Function Link_ISUD2355A(job As Integer, MaterialInboundNo As String, MaterialInBoundSeq As String, MaterialInBoundSno As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG

        D2352.MaterialInBoundNo = MaterialInboundNo
        D2352.MaterialInBoundSeq = MaterialInBoundSeq
        D2352.MaterialInBoundSno = MaterialInBoundSno

        txt_Barcode.Data = FormatCut(MaterialInboundNo + MaterialInBoundSeq + MaterialInBoundSno)

        wJOB = job : L2352 = D2352

        If READ_PFK2352(L2352.MaterialInBoundNo, L2352.MaterialInBoundSeq, L2352.MaterialInBoundSno) Then
            txt_QtyInbound.Data = Format2(CDecp(D2352.QtyInBound))

        End If

        If READ_PFK2351(L2352.MaterialInBoundNo, L2352.MaterialInBoundSeq) Then
            txt_MaterialCode.Code = D2351.MaterialCode

            If READ_PFK7231(D2351.MaterialCode) Then
                txt_MaterialCode.Data = D7231.MaterialName
            End If


        End If

        If READ_PFK7411(Pub.SAW) Then
            txt_InchargeReceipt.Data = D7411.Name
            txt_InchargeReceipt.Code = D7411.IDNO
            txt_InchargeReceipt.Enabled = False
        End If

        Link_ISUD2355A = False
        Try

            Select Case job
                Case 1

                Case Else
                    txt_Barcode.Enabled = True
            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD2355A = isudCHK

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("Replacement PROCESSING"))
        End Try

    End Function

    Private Sub Form_Activate(sender As Object, e As EventArgs) Handles Me.Load
        Control.CheckForIllegalCrossThreadCalls = False
        If formA = True Then Exit Sub

        WRITE_CHK = ""
        Me.Form_KeyDown()

        Call DATA_INIT()

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

                Me.Show()

                Call KEY_COUNT()
                Call KEY_COUNT_SNO()

                Call DATA_SEARCH_VS2()

                Application.DoEvents()

                tst_iDelete.Visible = False

                Setfocus(txt_Barcode)

                tst_iSave.Visible = True
            Case 2
                Me.Text = Me.Text & " - SEARCH"

                If CHK(2) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCH_HEAD_INSERT()
                Call DATA_SEARCH_VS2()

                tst_iDelete.Visible = False
                tst_iSave.Visible = True
            Case 3
                Me.Text = Me.Text & " - UPDATE"

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
                        Call MsgBoxP("Only Search !") : tst_iSave.Visible = False
                    End If
                End If

                If DATA_SEARCH_HEAD_INSERT() = True Then

                    Call KEY_COUNT_SNO()
                    Call DATA_SEARCH_VS2()

                    txt_Barcode.Enabled = True
                End If

                tst_iSave.Visible = True
                tst_iDelete.Visible = True
            Case 4
                Me.Text = Me.Text & " - DELETE"

                If CHK(4) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCH_HEAD_INSERT()
                Call DATA_SEARCH_VS2()

                tst_iDelete.Visible = True

                tst_iSave.Visible = False
            Case 11
                Me.Text = Me.Text & " - INTERFACE"

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
                        Call MsgBoxP("Only Search !") : tst_iSave.Visible = False
                    End If
                End If

                If DATA_SEARCH_HEAD_INSERT() = True Then
                    Call DATA_SEARCH_VS2()

                    Call KEY_COUNT()
                    Call KEY_COUNT_SNO()

                    txt_Barcode.TextEnabled = True
                    txt_Barcode.Enabled = True

                End If
                tst_iSave.Visible = False
                tst_iDelete.Visible = False

        End Select

        formA = True
    End Sub

#End Region

#Region "Search"

    Private Function DATA_SEARCH_HEAD_INSERT() As Boolean
        DATA_SEARCH_HEAD_INSERT = False
        DATA_SEARCH_HEAD_INSERT = True
        Exit Function

        Try
            DATA_SEARCH_HEAD_INSERT = True

        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_HEAD_INSERT")
        End Try

    End Function

    Private Function DATA_SEARCH_HEAD_MaterialFullNo() As Boolean
        DATA_SEARCH_HEAD_MaterialFullNo = False
    End Function

    Private Function DATA_SEARCH_VS1(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS1 = False
        Vs1.Enabled = False

        DS1 = PrcDS("USP_ISUD2355A_SEARCH_VS1", cn, SdateEdate.text1,
                                                        SdateEdate.text2,
                                                        txt_PRName.Data,
                                                        txt_cdSeason.Code,
                                                        txt_Customer.Code,
                                                        txt_SupplierCode.Code,
                                                        txt_Article.Data,
                                                        txt_Line.Data,
                                                        txt_MaterialCode.Data,
                                                        txt_cdLargeGroupMaterial.Code,
                                                        txt_cdSemiGroupMaterial.Code,
                                                        txt_cdDetailGroupMaterial.Code,
                                                        chk_CheckSample.CheckState, txt_Barcode.Data)
        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS1, DS1, "USP_ISUD2355A_SEARCH_VS1", "Vs1")
            Vs1.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS1, DS1, "USP_ISUD2355A_SEARCH_VS1", "Vs1")
        DATA_SEARCH_VS1 = True

        Vs1.Enabled = True


    End Function
    Private Function DATA_SEARCH_VS2() As Boolean
        DATA_SEARCH_VS2 = False

        Try
            DS1 = PrcDS("USP_ISUD2355A_SEARCH_VS2", cn, txt_Barcode.Data)


            If GetDsRc(DS1) = 0 Then
                SPR_SET(vS2, , , , OperationMode.Normal)
                SPR_PRO(vS2, DS1, "USP_ISUD2355A_SEARCH_VS2", "VS2")
                vS2.ActiveSheet.RowCount = 1
                vS2.Enabled = True

                Exit Function
            End If

            SPR_PRO(vS2, DS1, "USP_ISUD2355A_SEARCH_VS2", "VS2")

            DATA_SEARCH_VS2 = True

        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_VS2")
        End Try
    End Function
    Private Function DATA_SEARCH_VS1_LINE() As Boolean
        DATA_SEARCH_VS1_LINE = False


    End Function


#End Region

#Region "Function"

    Private Function DATA_MOVE_K2355() As Boolean
        DATA_MOVE_K2355 = False

        Try
            Dim i As Integer
            Dim QtyInbound As Decimal
            Dim AutoKey_3011 As Decimal

            For i = 0 To vS2.ActiveSheet.RowCount - 1
                QtyInbound = CDecp(getData(vS2, getColumIndex(vS2, "QtyInbound"), i))
                AutoKey_3011 = CDecp(getData(vS2, getColumIndex(vS2, "KEY_AutoKey"), i))

                Call PrcExeNoError("USP_PFK2355_INSERT_PFK3011", cn, AutoKey_3011, L2352.MaterialInBoundNo, L2352.MaterialInBoundSeq, L2352.MaterialInBoundSno, QtyInbound, Pub.SAW)

            Next
        Catch ex As Exception

        End Try
    End Function

    Private Function DATA_CHECK() As Boolean
        DATA_CHECK = False

        Try
            Dim i As Integer
            Dim QtyInbound As Decimal
            Dim AutoKey_3011 As Decimal

            For i = 0 To vS2.ActiveSheet.RowCount - 1
                QtyInbound += CDecp(getData(vS2, getColumIndex(vS2, "QtyInbound"), i))
                AutoKey_3011 = CDecp(getData(vS2, getColumIndex(vS2, "AutoKey_3011"), i))

            Next

            If QtyInbound > CDecp(txt_QtyInbound.Data) Then
                DATA_CHECK = False
                Exit Function
            End If

            DATA_CHECK = True
        Catch ex As Exception

        End Try
    End Function

    Private Sub DATA_DELETE()
        Dim i As Integer

        Try
            For i = 0 To vS1.ActiveSheet.RowCount - 1
                If getDataM(vS1, getColumIndex(vS1, "CheckDsel"), i) = "1" Then
                    DATA_LINE_DELETE(i)
                End If
            Next

            Call DATA_SEARCH_VS1()

        Catch ex As Exception
            Call MsgBoxP("38", "DATA_DELETE")
        End Try

    End Sub
    Private Sub DATA_LINE_DELETE(xrow As Integer)

    End Sub

    Private Sub FORM_INIT()
        chk_FSEL.CheckState = 1
        chk_FSEL.BackColor = clrCheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("CLOSE")
        ssp_WHERE.Visible = True
    End Sub
    Private Sub DATA_INIT()
        Try

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INIT")
        End Try

    End Sub
    Private Sub KEY_COUNT()


    End Sub

    Private Sub KEY_COUNT_SNO()


    End Sub
    Private Sub CheckOutBoundMaterial(Process As String)

    End Sub

    Private Sub vS1_GotFocus(sender As Object, e As EventArgs) Handles vS1.GotFocus
        chk_FSEL.CheckState = 0
        chk_FSEL.BackColor = clrUncheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("OPEN")
        ssp_WHERE.Visible = False
    End Sub

    Private Function Check_OutBound() As String

        Check_OutBound = "1"

        Return Check_OutBound
    End Function

#End Region

#Region "Event"

    Private Sub tst_iSave_Click(sender As Object, e As EventArgs) Handles tst_iSave.Click
        If DATA_CHECK() = False Then MsgBoxP("Wrong action ! PHân bổ sai !") : Exit Sub

        Call DATA_MOVE_K2355()
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

        Dim str As String = MsgBoxP("Do you want to delete all roll?", vbYesNo)

        If str <> vbYes Then Exit Sub


        Call DATA_DELETE()
    End Sub


    Private Function CheckBalance() As Boolean
        CheckBalance = False
        Try
            Dim StrMsg As String
         
            CheckBalance = True
        Catch ex As Exception

        End Try

    End Function
    Private Sub txt_GreyFullNo_txtTextKeyDown(sender As Object, e As KeyEventArgs) Handles txt_Barcode.txtTextKeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True

            If txt_Barcode.Data = "" Then Exit Sub
            If CheckBalance() = False Then Exit Sub

            txt_Barcode.Code = FormatCut(txt_Barcode.Data)

            If Len(txt_Barcode.Code) < 13 Then Exit Sub

            L2352.MaterialInBoundNo = Strings.Left(txt_Barcode.Code, 9)
            L2352.MaterialInBoundSeq = Strings.Mid(txt_Barcode.Code, 10, 3)
            L2352.MaterialInBoundSno = Strings.Mid(txt_Barcode.Code, 13)

           
        End If



    End Sub



#End Region
    Private Sub chk_FSEL_Click(sender As Object, e As EventArgs) Handles chk_FSEL.CheckedChanged
        If chk_FSEL.CheckState = 0 Then                  '
            chk_FSEL.BackColor = clrUncheck
            chk_FSEL.ForeColor = Color.Black

            chk_FSEL.Text = WordConv("OPEN")
            ssp_WHERE.Visible = False
        Else                                        '
            chk_FSEL.BackColor = clrCheck
            chk_FSEL.ForeColor = Color.Black

            chk_FSEL.Text = WordConv("CLOSE")
            ssp_WHERE.Visible = True
        End If
    End Sub

    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click

        chk_FSEL.CheckState = 0
        chk_FSEL.BackColor = clrUncheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("OPEN")
        ssp_WHERE.Visible = False

       Call DATA_SEARCH_VS1()

    End Sub

    Private Sub vS1_CellClick(sender As Object, e As CellClickEventArgs) Handles vS1.CellDoubleClick
        Try
            Dim KEY_Autokey As Decimal
            KEY_Autokey = CDecp(getData(vS1, getColumIndex(vS1, "KEY_Autokey"), vS1.ActiveSheet.ActiveRowIndex))

            If READ_PFK3011(KEY_Autokey) Then
                If vS2.ActiveSheet.RowCount >= 1 And getData(vS2, getColumIndex(vS2, "MaterialName"), vS2.ActiveSheet.RowCount - 1) <> "" <> 0 Then vS2.ActiveSheet.RowCount += 1

                setData(vS2, getColumIndex(vS2, "KEY_AutoKey_3011"), vS2.ActiveSheet.RowCount - 1, D3011.Autokey)
                setData(vS2, getColumIndex(vS2, "Autokey"), vS2.ActiveSheet.RowCount - 1, D3011.Autokey)
                setData(vS2, getColumIndex(vS2, "KEY_Autokey"), vS2.ActiveSheet.RowCount - 1, D3011.Autokey)

                setData(vS2, getColumIndex(vS2, "MaterialInBoundNo"), vS2.ActiveSheet.RowCount - 1, L2352.MaterialInBoundNo)
                setData(vS2, getColumIndex(vS2, "MaterialInBoundSeq"), vS2.ActiveSheet.RowCount - 1, L2352.MaterialInBoundSeq)
                setData(vS2, getColumIndex(vS2, "MaterialInBoundSno"), vS2.ActiveSheet.RowCount - 1, L2352.MaterialInBoundSno)

                setData(vS2, getColumIndex(vS2, "ColorName"), vS2.ActiveSheet.RowCount - 1, D3011.ColorName)

                setData(vS2, getColumIndex(vS2, "QtyRequest"), vS2.ActiveSheet.RowCount - 1, D3011.QtyRequest)
                setData(vS2, getColumIndex(vS2, "QtyInbound"), vS2.ActiveSheet.RowCount - 1, D3011.QtyRequest)

                If READ_PFK7231(D3011.Materialcode) Then
                    setData(vS2, getColumIndex(vS2, "MaterialSimple"), vS2.ActiveSheet.RowCount - 1, D7231.MaterialSimple)
                    setData(vS2, getColumIndex(vS2, "MaterialName"), vS2.ActiveSheet.RowCount - 1, D7231.MaterialName)

                End If

                If READ_PFK1311(D3011.OrderNo) Then
                    setData(vS2, getColumIndex(vS2, "CustPoNo"), vS2.ActiveSheet.RowCount - 1, D1311.CustPoNo)
                End If

                If READ_PFK3411(D3011.PurchasingOrderNo) Then
                    setData(vS2, getColumIndex(vS2, "PurchasingOrderName"), vS2.ActiveSheet.RowCount - 1, D3411.PurchasingOrderName)
                End If

                If READ_PFK1312(D3011.OrderNo, D3011.OrderNoSeq) Then
                    setData(vS2, getColumIndex(vS2, "PONO"), vS2.ActiveSheet.RowCount - 1, D1312.PONO)
                    setData(vS2, getColumIndex(vS2, "ShoesCode"), vS2.ActiveSheet.RowCount - 1, D1312.ShoesCode)

                    If READ_PFK7106(D1312.ShoesCode) Then
                        setData(vS2, getColumIndex(vS2, "Article"), vS2.ActiveSheet.RowCount - 1, D7106.Article)
                        setData(vS2, getColumIndex(vS2, "ProductCode"), vS2.ActiveSheet.RowCount - 1, D7106.ProductCode)

                    End If
                End If

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub vS2_KeyDown(sender As Object, e As KeyEventArgs) Handles vS2.KeyDown
        If e.KeyCode = Keys.Delete Then
            SPR_DEL(vS2, vS2.ActiveSheet.ActiveColumnIndex, vS2.ActiveSheet.ActiveRowIndex)
        End If
    End Sub

End Class