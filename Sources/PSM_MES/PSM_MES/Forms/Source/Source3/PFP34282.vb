Public Class PFP34282

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
        Vs10.ContextMenuStrip = Cms_1


        Me.KeyPreview = True

        Call FORM_INIT()
        Call DATA_INIT()

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
        SdateEdate.text1 = System_Date_6() & "01"
        SdateEdate.text2 = System_Date_8()

        txt_InchargeInsert.Data = Pub.NAM
        txt_InchargeInsert.Code = Pub.SAW

    End Sub
#End Region

#Region "Data_search"
    Private Function DATA_SEARCH_VS10(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS10 = False

        Vs10.Enabled = False
        Vs10.ActiveSheet.RowCount = 0
        Vs11.ActiveSheet.RowCount = 0

        DS1 = PrcDS("USP_PFP34282_SEARCH_VS10", cn, SdateEdate.text1,
                                                    SdateEdate.text2,
                                                    txt_cdDepartment.Code,
                                                    txt_FactOrderNo.Data,
                                                    txt_SupplierCode.Code,
                                                    txt_cdSite.Code, _
                                                    txt_CustomerCode.Code, _
                                                    chk_CheckMarketType0.CheckState,
                                                    chk_CheckMarketType1.CheckState,
                                                    chk_CheckMarketType2.CheckState,
                                                    Pub.SAW)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(Vs10, DS1, "USP_PFP34282_SEARCH_VS10", "vS10")
            Vs10.ActiveSheet.RowCount = 0
            Vs10.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(Vs10, DS1, "USP_PFP34282_SEARCH_VS10", "vS10")
        DATA_SEARCH_VS10 = True
        Vs10.Enabled = True

    End Function

    Private Function DATA_SEARCH_VS11(PayableNo As String) As Boolean
        DATA_SEARCH_VS11 = False
        Vs10.Enabled = False

        DS1 = PrcDS("USP_PFP34282_SEARCH_VS11", cn, PayableNo)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(Vs11, DS1, "USP_PFP34282_SEARCH_VS11", "vS11")
            Vs10.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(Vs11, DS1, "USP_PFP34282_SEARCH_VS11", "vS11")
        DATA_SEARCH_VS11 = True

        Vs10.Enabled = True
    End Function


    Private Function LINE_MOVE_DISPLAY01() As Boolean
        LINE_MOVE_DISPLAY01 = False

    End Function
    Private Function CustomerPurchasing_CHK() As String
        CustomerPurchasing_CHK = "1"
        Return CustomerPurchasing_CHK
    End Function

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

#Region "Event"
    Private Sub vS10_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs10.CellClick
        If e.ColumnHeader = True Then Exit Sub
        If e.Column = getColumIndex(Vs10, "DCHK") Then Exit Sub

        Vs10.ActiveSheet.ActiveColumnIndex = e.Column
        Vs10.ActiveSheet.ActiveRowIndex = e.Row
        Vs10.ActiveSheet.AddSelection(e.Row, e.Column, 1, 1)
    End Sub

    Private Sub vS10_GotFocus(sender As Object, e As EventArgs) Handles Vs10.GotFocus

        Call TOOLBAR_CHECKSHOW(ToolStrip1, False, False, False, False, False, False)

        chk_FSEL.CheckState = 0
        chk_FSEL.BackColor = clrUncheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("OPEN")
        ssp_WHERE.Visible = False
    End Sub
    Private Sub vS10_LostFocus(sender As Object, e As EventArgs) Handles Vs10.LostFocus

        Call TOOLBAR_CHECKSHOW(ToolStrip1, False, False, False, False, False, False)

    End Sub

    Private Sub txt_GNAME_KeyDown(sender As Object, e As KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.Enter : cmd_SEARCH.Focus()
        End Select
    End Sub


    Private Sub vS20_LostFocus(sender As Object, e As EventArgs)

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False)

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

        Call DATA_SEARCH_VS10()

    End Sub

    Private Sub Vs10_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs10.CellDoubleClick
        If e.ColumnHeader = True Then Exit Sub
        If e.Column = getColumIndex(Vs10, "DCHK") Then Exit Sub

        Dim PayableNo As String
  
        Try


            If getData(Vs10, getColumIndex(Vs10, "KEY_PayableNo"), Vs10.ActiveSheet.ActiveRowIndex) <> "" Then
                PayableNo = getData(Vs10, getColumIndex(Vs10, "KEY_PayableNo"), Vs10.ActiveSheet.ActiveRowIndex)
                DATA_SEARCH_VS11(PayableNo)
            End If


        Catch ex As Exception

            MsgBoxP("Error in Vs20_CellDoubleClick!", vbCritical)

        End Try


    End Sub

    Private Sub PFP17811_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Call INTERRUPT_TOGGLE(e.KeyCode)
        Call Function_Event(e.KeyValue)
    End Sub



#End Region

End Class