Public Class HLP2356Y

#Region "Variable"
    Private Dsu01 As Long     'Data Su
    Private wGCODE As String
    Protected prg As E_PRG

    Private W2356 As T2356_AREA
    Private Form_Close As Boolean

    Private strDateOutbound As String
    Private strInvoiceNo As String

#End Region

#Region "Form_load"

    Public Function Link_ISUD2356B(job As Integer, DateOutbound As String, InvoiceNo As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG

        strDateOutbound = DateOutbound
        strInvoiceNo = InvoiceNo

        Link_ISUD2356B = False
        Try

            Me.ShowDialog()

            Link_ISUD2356B = isudCHK


        Catch ex As Exception
            '       Call MsgBoxP("61", WordConv("GroupComponentBOM"))
        End Try


    End Function

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False)

        Me.KeyPreview = True

        Call FORM_INIT()
        Call DATA_INIT()


    End Sub
    Private Sub PFP23516_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Call INTERRUPT_TOGGLE(e.KeyCode)

        Call Function_Event(e.KeyValue)
    End Sub
    Private Sub Function_Event(PressKey As Integer)
        Try
            Select Case PressKey
                Case Keys.F5 : Call MAIN_JOB01()
                Case Keys.F6 : Call MAIN_JOB02()
                Case Keys.F7 : Call MAIN_JOB03()
                Case Keys.F8 : Call MAIN_JOB04()
                Case Keys.F9 : Call MAIN_JOB05()
            End Select
        Catch ex As Exception
        End Try
    End Sub
    Private Sub FORM_INIT()
        chk_FSEL.CheckState = 1
        chk_FSEL.BackColor = clrCheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("CLOSE")
        ssp_WHERE.Visible = True
    End Sub

    Private Sub DATA_INIT()
        Call DATA_SEARCH_VS10()
        Call DATA_SEARCH_vS20()

    End Sub
#End Region

#Region "Function"
    Private Sub MAIN_JOB01()

    End Sub

    Private Sub MAIN_JOB02()

    End Sub

    Private Sub MAIN_JOB03()

    End Sub

    Private Sub MAIN_JOB04()

    End Sub

    Private Sub MAIN_JOB05()

    End Sub

#End Region

#Region "Data_search"
    Private Function DATA_SEARCH_VS10(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS10 = False

        vS10.Enabled = False

        DS1 = PrcDS("USP_HLP2356Y_SEARCH_vS10", cn, txt_cdSite.Code, txt_MaterialName.Data, txt_ColorName.Data, strDateOutbound, strInvoiceNo)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS10, DS1, "USP_HLP2356Y_SEARCH_vS10", "vS10")

            vS10.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS10, DS1, "USP_HLP2356Y_SEARCH_vS10", "vS10")
        DATA_SEARCH_VS10 = True

        vS10.Enabled = True
    End Function

    Private Function DATA_SEARCH_vS20(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_vS20 = False

        vS20.Enabled = False

        DS1 = PrcDS("USP_HLP2356Y_SEARCH_vS20", cn, txt_cdSite.Code, strDateOutbound, strInvoiceNo)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS20, DS1, "USP_HLP2356Y_SEARCH_vS20", "vS20")

            vS20.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS20, DS1, "USP_HLP2356Y_SEARCH_vS20", "vS20")
        DATA_SEARCH_vS20 = True

        vS20.Enabled = True
    End Function

    Private Function LINE_MOVE_DISPLAY01() As Boolean
        LINE_MOVE_DISPLAY01 = False

    End Function
    Private Function CustomerPurchasing_CHK() As String
        CustomerPurchasing_CHK = "1"
        Return CustomerPurchasing_CHK
    End Function


#End Region

#Region "Event"


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

        Call DATA_SEARCH_VS10()
    End Sub




    Private Sub vS10_CellDoubleClick(sender As Object, e As CellClickEventArgs)

    End Sub

    Private Sub vS10_ButtonClicked(sender As Object, e As EditorNotifyEventArgs)


        'vSChange(e.Row)
    End Sub


#End Region


    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click

        Msg_Result = MsgBox("This is important confirmation ! Please be careful to save ! Đây là thông tin cực kỳ quan trọng để quyết toán. Xin lưu ý ! Bấm Yes để tiếp tục !", vbYesNo)
        If Msg_Result <> vbYes Then Exit Sub


        Try
            Dim xCOL As Integer
            Dim xROW As Integer
            Dim i As Integer
            Dim Value1() As String
            Dim Value2(5) As String


            Dim QtyInBound As String
            Dim KEY_OrderNo As String
            Dim KEY_OrderNoSeq As String
            Dim KEY_QtyOrder As String
            Dim QtyInBoundAllocation As Decimal

            Call PrcExeNoError("USP_PFK2357_DELETE", cn, Pub.SITE, strDateOutbound, strInvoiceNo)

            For i = 0 To vS20.ActiveSheet.RowCount - 1


                KEY_OrderNo = getData(vS20, getColumIndex(vS20, "KEY_OrderNo"), i)
                KEY_OrderNoSeq = getData(vS20, getColumIndex(vS20, "KEY_OrderNoSeq"), i)
                KEY_QtyOrder = CDecp(getData(vS20, getColumIndex(vS20, "QtyOrder"), i))

                Call PrcExeNoError("USP_PFK2357_INSERT", cn, Pub.SITE, strDateOutbound, strInvoiceNo, KEY_OrderNo, KEY_OrderNoSeq, KEY_QtyOrder, Pub.SAW)


            Next

            Me.Dispose()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub vS10_CellClick(sender As Object, e As CellClickEventArgs) Handles vS10.CellDoubleClick
        If READ_PFK1312(getData(vS10, getColumIndex(vS10, "Key_OrderNo"), vS10.ActiveSheet.ActiveRowIndex), getData(vS10, getColumIndex(vS10, "Key_OrderNoSeq"), vS10.ActiveSheet.ActiveRowIndex)) Then
            If vS20.ActiveSheet.RowCount >= 1 And getData(vS20, getColumIndex(vS20, "Key_OrderNo"), vS20.ActiveSheet.RowCount - 1) <> "" Then vS20.ActiveSheet.RowCount += 1
            If vS20.ActiveSheet.RowCount = 0 Then vS20.ActiveSheet.RowCount = 1

            setData(vS20, getColumIndex(vS20, "Key_OrderNo"), vS20.ActiveSheet.RowCount - 1, D1312.OrderNo)
            setData(vS20, getColumIndex(vS20, "Key_OrderNoSeq"), vS20.ActiveSheet.RowCount - 1, D1312.OrderNoSeq)
            setData(vS20, getColumIndex(vS20, "QtyOrder"), vS20.ActiveSheet.RowCount - 1, D1312.QtyOrder)
            setData(vS20, getColumIndex(vS20, "QtyOrderSample"), vS20.ActiveSheet.RowCount - 1, D1312.QtyOrderSample)

            Call READ_PFK1311(D1312.OrderNo)
            setData(vS20, getColumIndex(vS20, "CustPoNo"), vS20.ActiveSheet.RowCount - 1, D1311.CustPoNo)

            If READ_PFK7106(D1312.ShoesCode) Then
                setData(vS20, getColumIndex(vS20, "Article"), vS20.ActiveSheet.RowCount - 1, D7106.Article)
                setData(vS20, getColumIndex(vS20, "PKO"), vS20.ActiveSheet.RowCount - 1, D1312.PKO)
                setData(vS20, getColumIndex(vS20, "PONO"), vS20.ActiveSheet.RowCount - 1, D1312.PONO)
                setData(vS20, getColumIndex(vS20, "DateLable"), vS20.ActiveSheet.RowCount - 1, D1312.DateLable)
                setData(vS20, getColumIndex(vS20, "Datedelivery"), vS20.ActiveSheet.RowCount - 1, D1312.Datedelivery)

            End If

        End If
    End Sub

    Private Sub vS20_KeyDown(sender As Object, e As KeyEventArgs) Handles vS20.KeyDown
        If e.KeyCode = Keys.Delete Then
            SPR_DEL(vS20, vS20.ActiveSheet.ActiveColumnIndex, vS20.ActiveSheet.ActiveRowIndex)
        End If
    End Sub

End Class