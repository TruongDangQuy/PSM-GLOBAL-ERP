Public Class PFP01604

#Region "Variable"
    Private Dsu01 As Long
    Private wGCODE As String
    Private Form_Close As Boolean
#End Region

#Region "Form_load"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load

        Call TOOLBAR_CHECKSHOW(ToolStrip1, False, False, False, False, False, False)

        Me.KeyPreview = True

        Call FORM_INIT()
        Call DATA_INIT()

    End Sub
    Private Sub PFP17811_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Call INTERRUPT_TOGGLE(e.KeyCode)
        Call Function_Event(e.KeyValue)
    End Sub
    Overrides Sub Function_Event(PressKey As Integer)
        Try
            Select Case PressKey

            End Select
        Catch ex As Exception
        End Try
    End Sub
    Private Sub FORM_INIT()

    End Sub

    Private Sub DATA_INIT()
        SdateEdate.text1 = Pub.DAT
        SdateEdate.text2 = Pub.DAT
    End Sub
#End Region

#Region "Function"

#End Region

#Region "Data_search"
    Private Sub vs_GotFocus(sender As Object, e As EventArgs) Handles Vs10.GotFocus, vS11.GotFocus, vS20.GotFocus, vS30.GotFocus
        chk_FSEL.CheckState = 0
        chk_FSEL.BackColor = clrUncheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("OPEN")
        ssp_WHERE.Visible = False
    End Sub


    Private Function DATA_SEARCH_VS10(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS10 = False

        Vs10.Enabled = False
        Try
            DS1 = PrcDS("USP_PFP01604_SEARCH_VS10", cn, SdateEdate.text1, SdateEdate.text2)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs10, DS1, "USP_PFP01604_SEARCH_VS10", "vS10")
                Vs10.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(Vs10, DS1, "USP_PFP01604_SEARCH_VS10", "vS10")
            DATA_SEARCH_VS10 = True

            Vs10.Enabled = True

        Catch ex As Exception

        End Try

    End Function

    Private Function DATA_SEARCH_VS11(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS11 = False
        Dim OrderNo As String
        Dim OrderNoSeq As String

        OrderNo = getData(Vs10, getColumIndex(Vs10, "OrderNo"), Vs10.ActiveSheet.ActiveRowIndex)
        OrderNoSeq = getData(Vs10, getColumIndex(Vs10, "OrderNoSeq"), Vs10.ActiveSheet.ActiveRowIndex)

        vS11.Enabled = False
        Try
            DS1 = PrcDS("USP_PFP01604_SEARCH_VS11", cn, OrderNo, OrderNoSeq, SdateEdate.text1, SdateEdate.text2)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS11, DS1, "USP_PFP01604_SEARCH_VS11", "VS11")
                vS11.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS11, DS1, "USP_PFP01604_SEARCH_VS11", "VS11")

            Call VsSizeRange(vS11, "USP_PFP01604_SEARCH_VS11_HEAD", getData(vS11, getColumIndex(vS11, "OrderNo"), 0), getData(vS11, getColumIndex(vS11, "OrderNoSeq"), 0))


            DATA_SEARCH_VS11 = True

            vS11.Enabled = True

        Catch ex As Exception

        End Try

    End Function

    Private Function DATA_SEARCH_VS20(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS20 = False

        vS20.Enabled = False
        Try
            DS1 = PrcDS("USP_PFP01604_SEARCH_VS20", cn, SdateEdate.text1, SdateEdate.text2, "003")

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS20, DS1, "USP_PFP01604_SEARCH_VS20", "VS20")
                vS20.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS20, DS1, "USP_PFP01604_SEARCH_VS20", "VS20")
            DATA_SEARCH_VS20 = True

            vS20.Enabled = True

        Catch ex As Exception

        End Try

    End Function

    Private Function DATA_SEARCH_VS30(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS30 = False

        vS30.Enabled = False
        Try
            DS1 = PrcDS("USP_PFP01604_SEARCH_VS30", cn, SdateEdate.text1, SdateEdate.text2)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS30, DS1, "USP_PFP01604_SEARCH_VS30", "VS30")
                vS30.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS30, DS1, "USP_PFP01604_SEARCH_VS30", "VS30")
            DATA_SEARCH_VS30 = True

            vS30.Enabled = True

        Catch ex As Exception

        End Try

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

    Private Sub ptc_Main_DoubleClick(sender As Object, e As EventArgs) Handles ptc_1.DoubleClick
        If ptc_1.SelectedIndex = -1 Then Exit Sub


        Select Case ptc_1.SelectedIndex
            Case 0 : Call DATA_SEARCH_VS10()
            Case 1 : Call DATA_SEARCH_VS20()
            Case 2 : Call DATA_SEARCH_VS30()
        End Select

    End Sub


    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        chk_FSEL.CheckState = 0
        chk_FSEL.BackColor = clrUncheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("OPEN")
        ssp_WHERE.Visible = False

        If ptc_1.SelectedIndex = 0 Then Call DATA_SEARCH_VS10()
        If ptc_1.SelectedIndex = 1 Then Call DATA_SEARCH_VS20()
        If ptc_1.SelectedIndex = 2 Then Call DATA_SEARCH_VS30()
    End Sub

    Private Sub HLP8986A_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If ptc_1.TabCount < 1 Then Exit Sub
        If Me.Width > 30 Then
            ptc_1.ItemSize = New Size((Me.Width - 30) / ptc_1.TabCount, 25)
        End If
    End Sub

    Private Sub txt_SDATE_m_Textchange(sender As Object, e As EventArgs)
        Call cmd_SEARCH.PerformClick()
    End Sub

#End Region




    Private Sub Vs10_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs10.CellClick
        Call DATA_SEARCH_VS11()
    End Sub

    Private Sub cmd_Closing_Click(sender As Object, e As EventArgs) Handles cmd_Closing.Click
        Msg_Result = MsgBoxP("Do you want to closing all date?", vbYesNo)

        If Msg_Result <> vbYes Then Exit Sub


        Dim Starting As Object
        Starting = New DevExpress.Utils.WaitDialogForm("Loading data...", "PSM")


        Try
            Call PrcExeNoError("CLOSING_ALL_SUB_PROCESS_PRODUCTION_DATE", cn, Pub.DAT)
        Catch ex As Exception

        Finally
            Starting.close()
        End Try
    End Sub

    Private Sub chk_FSEL_CheckedChanged(sender As Object, e As EventArgs) Handles chk_FSEL.CheckedChanged
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
End Class