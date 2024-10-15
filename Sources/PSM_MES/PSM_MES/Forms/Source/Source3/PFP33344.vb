Public Class PFP33344
#Region "Variable"
    Private Dsu01 As Long     'Data Su
    Private wGCODE As String
    Protected prg As E_PRG

    Private W2351 As T2351_AREA
    Private Form_Close As Boolean
#End Region

#Region "Form_load"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call TOOLBAR_CHECKSHOW(ToolStrip1, False, False, False, False, False, False)

        Me.KeyPreview = True

        Call FORM_INIT()
        Call DATA_INIT()

        Call Cms_additem(Cms_1,
                     "WH CHECKLIST CONTROL PROCCESING - " & WordConv("SEARCH") & "(F5)")

        Vs10.ContextMenuStrip = Cms_1


    End Sub
    Private Sub PFP17811_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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
        'SdateEdate.text1 = Strings.Left(System_Date_8(), 6) & "01"
        'SdateEdate.text2 = System_Date_8()

        txt_DateOrder.Data = Pub.DAT

    End Sub
#End Region

#Region "Function"
    Private Sub MAIN_JOB01()
        Dim OrderNo As String
        Dim OrderNoSeq As String

        Try
            OrderNo = getData(Vs10, getColumIndex(Vs10, "KEY_OrderNo"), Vs10.ActiveSheet.ActiveRowIndex)
            OrderNoSeq = getData(Vs10, getColumIndex(Vs10, "KEY_OrderNoSeq"), Vs10.ActiveSheet.ActiveRowIndex)


            If READ_PFK1312(OrderNo, OrderNoSeq) Then

                If ISUD3011B.Link_ISUD3011B(2, OrderNo, OrderNoSeq, Me.Name) Then Exit Sub


            End If

        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB05!", vbCritical)
        End Try
    End Sub

    Private Sub MAIN_JOB02()


    End Sub

    Private Sub MAIN_JOB03()

    End Sub

    Private Sub MAIN_JOB04()

    End Sub

    Private Sub MAIN_JOB05()


    End Sub

    Private Sub MAIN_JOB31()


    End Sub

#End Region

#Region "Data_search"
    Private Function DATA_SEARCH_VS10(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS10 = False

        Vs10.Enabled = False

        DS1 = PrcDS("USP_PFP33344_SEARCH_VS10", cn, txt_DateOrder.Data, txt_DateOrder.Data, txt_cdSite.Code, txt_CustPONO.Data, txt_Article.Data, txt_TradingCode.Data)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(Vs10, DS1, "USP_PFP33344_SEARCH_VS10", "vS10")

            Vs10.ActiveSheet.RowCount = 0
            Vs10.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(Vs10, DS1, "USP_PFP33344_SEARCH_VS10", "vS10")
        DATA_SEARCH_VS10 = True

        Vs10.Enabled = True
    End Function
    Private Function DATA_SEARCH_VS20() As Boolean
        DATA_SEARCH_VS20 = False

        vS20.Enabled = False

        If txt_cdSite.Data = "" Then txt_cdSite.Code = ""

        DS1 = PrcDS("USP_PFP33344_SEARCH_vS20", cn, txt_DateOrder.Data, txt_DateOrder.Data, txt_cdSite.Code, txt_CustPONO.Data, txt_Article.Data, txt_TradingCode.Data)


        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS20, DS1, "USP_PFP33344_SEARCH_vS20", "vS20")
            vS20.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS20, DS1, "USP_PFP33344_SEARCH_vS20", "vS20")
        DATA_SEARCH_VS20 = True

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
    Private Sub tst_1_Click(sender As Object, e As EventArgs) Handles tst_1.Click, tst_2.Click, tst_3.Click, tst_4.Click, tst_5.Click, tst_6.Click

    End Sub
    Private Sub vS20_CellClick(sender As Object, e As CellClickEventArgs)
        If e.ColumnHeader = True Then Exit Sub
        vS20.ActiveSheet.ActiveColumnIndex = e.Column
        vS20.ActiveSheet.ActiveRowIndex = e.Row
        vS20.ActiveSheet.AddSelection(e.Row, e.Column, 1, 1)
    End Sub

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

        If ItemMain.SelectedIndex = 0 Then Call DATA_SEARCH_VS10()
        If ItemMain.SelectedIndex = 1 Then Call DATA_SEARCH_VS20()
    End Sub
    Private Sub Me_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.Width > 30 Then
            ItemMain.ItemSize = New Size((Me.Width - 30) / ItemMain.TabCount, 25)
        End If
    End Sub


    Private Sub Vs10_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs10.CellClick

    End Sub

    Private Sub Vs10_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs10.CellDoubleClick
       
    End Sub

    Private Sub Cms_1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles Cms_1.ItemClicked
        If Cms_1.Items(0).Selected = True Then
            Cms_1.Hide()
            MAIN_JOB01()
        End If
    End Sub

#End Region

End Class
