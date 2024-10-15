Public Class PFP34600

#Region "Variable"
    Private Dsu01 As Long     'Data Su
    Private wGCODE As String
    Protected prg As E_PRG

    Private W2351 As T2351_AREA
    Private Form_Close As Boolean
#End Region

#Region "Form_load"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False)

        Call Cms_additem(Cms_2, _
                        "INVOICE REQUEST - " & WordConv("INPUT") & "(F5)", _
                        "INVOICE REQUEST - " & WordConv("SEARCH") & "(F6)", _
                        "INVOICE REQUEST - " & WordConv("UPDATE") & "(F7)", _
                        "INVOICE REQUEST - " & WordConv("DELETE") & "(F8)",
                        "-",
                        "INVOICE REQUEST - " & WordConv("UN-COMPLETE") & "(F9)")

        Vs10.ContextMenuStrip = Cms_2

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
        txt_InchargeInsert.Enabled = False


    End Sub
#End Region

#Region "Data_search"
    Private Function DATA_SEARCH_VS10(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS10 = False

        Vs10.Enabled = False

        Vs11.ActiveSheet.RowCount = 0
        DS1 = PrcDS("USP_PFP34600_SEARCH_VS10", cn, SdateEdate.text1,
                                                    SdateEdate.text2,
                                                    txt_cdDepartment.Code,
                                                    txt_FactOrderNo.Data,
                                                    txt_SupplierCode.Code,
                                                    txt_cdSeason.Code, _
                                                    txt_CustomerCode.Code, _
                                                    chk_CheckMarketType0.CheckState,
                                                    chk_CheckMarketType1.CheckState,
                                                    Pub.SAW)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(Vs10, DS1, "USP_PFP34600_SEARCH_VS10", "vS10")

            Vs10.ActiveSheet.RowCount = 0
            Vs10.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(Vs10, DS1, "USP_PFP34600_SEARCH_VS10", "vS10")
        DATA_SEARCH_VS10 = True

        Vs10.Enabled = True

    End Function

    Private Function DATA_SEARCH_VS11(FactOrderNo As String) As Boolean


        DATA_SEARCH_VS11 = False

        Vs10.Enabled = False
        DS1 = PrcDS("USP_PFP34600_SEARCH_VS11", cn, FactOrderNo)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(Vs11, DS1, "USP_PFP34600_SEARCH_VS11", "vS11")
            Vs10.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(Vs11, DS1, "USP_PFP34600_SEARCH_VS11", "vS11")

        DATA_SEARCH_VS11 = True

        Vs10.Enabled = True

    End Function

    Private Function DATA_SEARCH_VS11_01(MaterialInBoundNo As String, MaterialInBoundSeq As String) As Boolean

        DATA_SEARCH_VS11_01 = False

        Vs10.Enabled = False

        DS1 = PrcDS("USP_PFP34600_SEARCH_VS11_01", cn, MaterialInBoundNo, MaterialInBoundSeq)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(Vs11, DS1, "USP_PFP34600_SEARCH_VS11_01", "vS11")
            Vs10.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(Vs11, DS1, "USP_PFP34600_SEARCH_VS11_01", "vS11")

        DATA_SEARCH_VS11_01 = True

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
        Dim CheckTypePayable As Integer
        Try

            If ISUD3460A.Link_ISUD3460A(1, "000000000", Me.Name) = False Then Exit Sub

        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB01!", vbCritical)
        End Try

    End Sub

    Private Sub MAIN_JOB02()
        Try

            If getData(Vs10, getColumIndex(Vs10, "KEY_InvoiceNo"), Vs10.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

            If ISUD3460A.Link_ISUD3460A(2, getData(Vs10, getColumIndex(Vs10, "KEY_InvoiceNo"), Vs10.ActiveSheet.ActiveRowIndex), Me.Name) = False Then Exit Sub


        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB02!", vbCritical)
        End Try

    End Sub

    Private Sub MAIN_JOB03()
        Try

            If ISUD3460A.Link_ISUD3460A(3, getData(Vs10, getColumIndex(Vs10, "KEY_InvoiceNo"), Vs10.ActiveSheet.ActiveRowIndex), Me.Name) = False Then Exit Sub
            Call LINE_MOVE_DISPLAY01()


        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB03!", vbCritical)
        End Try
    End Sub

    Private Sub MAIN_JOB04()
        Try
            If ISUD3460A.Link_ISUD3460A(4, getData(Vs10, getColumIndex(Vs10, "KEY_InvoiceNo"), Vs10.ActiveSheet.ActiveRowIndex), Me.Name) = False Then Exit Sub
            Call LINE_MOVE_DISPLAY01()

        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB04!", vbCritical)
        End Try
    End Sub

    Private Sub MAIN_JOB05()
        Try
            Try
                Dim StrMsg As String

                StrMsg = MsgBox("Do you want to UN-COMPLETE BOM?", vbYesNo)

                If StrMsg <> vbYes Then Exit Sub

                Dim InvoiceNo As String
                InvoiceNo = getData(Vs10, getColumIndex(Vs10, "InvoiceNo"), Vs10.ActiveSheet.ActiveRowIndex)

                If MsgBoxPPW("Please type the password to uncompete!", const_pwPay) = False Then Exit Sub

                If READ_PFK3428(InvoiceNo) Then
                    D3428.CheckComplete = "2"
                    D3428.DateUpdate = Pub.DAT
                    D3428.InchargeUpdate = Pub.SAW
                    Call REWRITE_PFK3428(D3428)
                End If

            Catch ex As Exception

            End Try

        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB05!", vbCritical)
        End Try

    End Sub

#End Region

#Region "Event"
    Private Sub tst_1_Click(sender As Object, e As EventArgs) Handles tst_1.Click, tst_2.Click, tst_3.Click, tst_4.Click, tst_5.Click, tst_6.Click
        If sender.Equals(tst_1) Then
            MAIN_JOB01()
        End If
        If sender.Equals(tst_2) Then
            MAIN_JOB02()
        End If
        If sender.Equals(tst_3) Then
            MAIN_JOB03()
        End If
        If sender.Equals(tst_4) Then
            MAIN_JOB04()
        End If

    End Sub
    Private Sub vS10_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs10.CellClick
        If e.ColumnHeader = True Then Exit Sub
        If e.Column = getColumIndex(Vs10, "DCHK") Then Exit Sub

        Vs10.ActiveSheet.ActiveColumnIndex = e.Column
        Vs10.ActiveSheet.ActiveRowIndex = e.Row
        Vs10.ActiveSheet.AddSelection(e.Row, e.Column, 1, 1)
    End Sub

    Private Sub vS10_GotFocus(sender As Object, e As EventArgs) Handles Vs10.GotFocus

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, False, False, False, False, False)

        chk_FSEL.CheckState = 0
        chk_FSEL.BackColor = clrUncheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("OPEN")
        ssp_WHERE.Visible = False

    End Sub
    Private Sub vS10_LostFocus(sender As Object, e As EventArgs) Handles Vs10.LostFocus

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, False, False, False, False, False)

    End Sub

    Private Sub txt_GNAME_KeyDown(sender As Object, e As KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.Enter : cmd_SEARCH.Focus()
        End Select
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
    Private Sub Cms_1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles Cms_1.ItemClicked
        If Cms_1.Items(0).Selected = True Then
            Cms_1.Hide()
            MAIN_JOB01()
        End If

    End Sub

    Private Sub Cms_2_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles Cms_2.ItemClicked

        If Cms_2.Items(0).Selected = True Then
            Cms_2.Hide()
            MAIN_JOB01()

        ElseIf Cms_2.Items(1).Selected = True Then
            Cms_2.Hide()
            MAIN_JOB02()

        ElseIf Cms_2.Items(2).Selected = True Then
            Cms_2.Hide()
            MAIN_JOB03()

        ElseIf Cms_2.Items(3).Selected = True Then
            Cms_2.Hide()
            MAIN_JOB04()

        ElseIf Cms_2.Items(5).Selected = True Then
            Cms_2.Hide()
            MAIN_JOB05()
        End If

    End Sub



    Private Sub Vs10_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs10.CellDoubleClick
        If e.ColumnHeader = True Then Exit Sub
        'If e.Column = getColumIndex(Vs10, "DCHK") Then Exit Sub

        Dim InvoiceNo As String

        InvoiceNo = getData(Vs10, getColumIndex(Vs10, "KEY_InvoiceNo"), Vs10.ActiveSheet.ActiveRowIndex)

        Try

            Call DATA_SEARCH_VS11(InvoiceNo)

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