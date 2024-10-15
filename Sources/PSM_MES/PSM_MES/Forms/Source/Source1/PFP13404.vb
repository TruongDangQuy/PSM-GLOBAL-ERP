Public Class PFP13404

#Region "Variable"
    Private Dsu01 As Long
    Private wGCODE As String
    Protected prg As E_PRG

    Private W1311 As T1311_AREA
    Private Form_Close As Boolean
#End Region

#Region "Form_load"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call TOOLBAR_CHECKSHOW(ToolStrip1, False, False, False, False, False, False)

        Me.KeyPreview = True

        Call FORM_INIT()
        Call DATA_INIT()

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

        End If

    End Sub

    Private Sub PFP17811_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Call INTERRUPT_TOGGLE(e.KeyCode)
        Call Function_Event(e.KeyValue)
    End Sub
    Overrides Sub Function_Event(PressKey As Integer)
        Try
            Select Case PressKey
                Case Keys.F5 : Call MAIN_JOB01()
                Case Keys.F6 : Call MAIN_JOB02()
                Case Keys.F7 : Call MAIN_JOB03()
                Case Keys.F8 : Call MAIN_JOB04()
            End Select
        Catch ex As Exception
        End Try
    End Sub
    Private Sub FORM_INIT()
        chk_FSEL.CheckState = 1
        chk_FSEL.BackColor = clrCheck
        chk_FSEL.ForeColor = Color.Black
        Me.chk_FormEnterkey = False

        chk_FSEL.Text = WordConv("CLOSE")
        ssp_WHERE.Visible = True

    End Sub

    Private Sub DATA_INIT()
        Call Gadget_Load(ssp_WHERE, Me.Name)


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
#End Region

#Region "Data_search"

    Private Function DATA_SEARCH_Vs10(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_Vs10 = False

        Vs10.Enabled = False
        Try
            DS1 = PrcDS("USP_PFP13404_SEARCH_Vs10", cn, txt_cdSite.Code, txt_Year.Value, txt_Declare.Data, txt_Article.Data, txt_TradingCode.Data)


            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS10, DS1, "USP_PFP13404_SEARCH_Vs10", "Vs10")

                vS10.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS10, DS1, "USP_PFP13404_SEARCH_Vs10", "Vs10")
            DATA_SEARCH_Vs10 = True

            vS10.Enabled = True

        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_Vs10")
        End Try

    End Function

    Private Function DATA_SEARCH_Vs11(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_Vs11 = False
        Dim ExportDeclare As String
        Dim TradingCode As String

        ExportDeclare = getData(vS10, getColumIndex(vS10, "SOTK"), vS10.ActiveSheet.ActiveRowIndex)
        TradingCode = getData(vS10, getColumIndex(vS10, "TradingCode"), vS10.ActiveSheet.ActiveRowIndex)

        vS11.Enabled = False
        Try
            DS1 = PrcDS("USP_PFP13404_SEARCH_Vs11", cn, txt_cdSite.Code, ExportDeclare, TradingCode)


            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS11, DS1, "USP_PFP13404_SEARCH_Vs11", "Vs11")

                vS11.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS11, DS1, "USP_PFP13404_SEARCH_Vs11", "Vs11")
            DATA_SEARCH_Vs11 = True

            vS11.Enabled = True

        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_Vs11")
        End Try

    End Function

    Private Function DATA_SEARCH_Vs12(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_Vs12 = False
        Dim ExportDeclare As String
        Dim TradingCode As String

        ExportDeclare = getData(vS10, getColumIndex(vS10, "SOTK"), vS10.ActiveSheet.ActiveRowIndex)
        TradingCode = getData(vS10, getColumIndex(vS10, "TradingCode"), vS10.ActiveSheet.ActiveRowIndex)


        Vs12.Enabled = False
        Try
            DS1 = PrcDS("USP_PFP13404_SEARCH_Vs12", cn, txt_cdSite.Code, ExportDeclare, TradingCode)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs12, DS1, "USP_PFP13404_SEARCH_Vs12", "Vs12")

                Vs12.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(Vs12, DS1, "USP_PFP13404_SEARCH_Vs12", "Vs12")
            DATA_SEARCH_Vs12 = True

            vS12.Enabled = True

        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_vS12")
        End Try

    End Function

    Private Function DATA_SEARCH_Vs12_NEW(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_Vs12_NEW = False
        Dim SOTK As String
        Dim InvoiceNo As String
        Dim TradingCode As String
        Dim InvoiceSeq As String
        Dim ExportDeclare As String

        SOTK = getData(vS10, getColumIndex(vS10, "SOTK"), vS10.ActiveSheet.ActiveRowIndex)
        TradingCode = getData(vS10, getColumIndex(vS10, "TradingCode"), vS10.ActiveSheet.ActiveRowIndex)

        InvoiceNo = getData(vS10, getColumIndex(vS10, "KEY_InvoiceNo"), vS10.ActiveSheet.ActiveRowIndex)
        InvoiceSeq = getData(vS10, getColumIndex(vS10, "KEY_InvoiceSeq"), vS10.ActiveSheet.ActiveRowIndex)

        ExportDeclare = getData(vS11, getColumIndex(vS11, "InvoiceNo"), vS11.ActiveSheet.ActiveRowIndex)

        If READ_PFK3461(InvoiceNo, InvoiceSeq) Then
            Msg_Result = MsgBox("Do you want to match this invoice with transfer vouhcer ?", vbYesNo)

            If Msg_Result = MsgBoxResult.No Then Exit Function

            str = PrcExeNoError_Value("USP_PFI9017_INSERT", cn, txt_cdSite.Code, InvoiceNo, InvoiceSeq, ExportDeclare)
            Call DATA_SEARCH_Vs12()
        Else
            Exit Function

        End If



    End Function


    Private Function DATA_SEARCH_Vs20(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_Vs20 = False

        Vs20.Enabled = False


        Try
            DS1 = PrcDS("USP_PFP13404_SEARCH_Vs20", cn, txt_cdSite.Code, txt_Year.Value, txt_Declare.Data, txt_Article.Data, txt_TradingCode.Data)


            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs20, DS1, "USP_PFP13404_SEARCH_Vs20", "Vs20")

                Vs20.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS20, DS1, "USP_PFP13404_SEARCH_Vs20", "Vs20")


            DATA_SEARCH_Vs20 = True

            Vs20.Enabled = True
        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_Vs20")
        End Try

    End Function

    

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
        Try

            chk_FSEL.CheckState = 0
            chk_FSEL.BackColor = clrUncheck
            chk_FSEL.ForeColor = Color.Black

            chk_FSEL.Text = WordConv("OPEN")
            ssp_WHERE.Visible = False
            If ptc_001.SelectedIndex = 0 Then Call DATA_SEARCH_Vs10()
            If ptc_001.SelectedIndex = 1 Then Call DATA_SEARCH_Vs20()

        Catch ex As Exception
            Call MsgBoxP("35", "cmd_SEARCH_Click")
        End Try
    End Sub
    Private Sub Cms_1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles Cms_1.ItemClicked
        Try

            If Cms_1.Items(0).Selected = True Then
                Cms_1.Hide()
                MAIN_JOB01()

            End If

        Catch ex As Exception
            Call MsgBoxP("35", "cmd_SEARCH_Click")
        End Try

    End Sub

    Private Sub vS10_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles vS10.CellDoubleClick
        Try
            Call DATA_SEARCH_Vs11()
            Call DATA_SEARCH_Vs12()

        Catch ex As Exception

        End Try
    End Sub


    Private Sub vs_GotFocus(sender As Object, e As EventArgs) Handles vS10.GotFocus
        chk_FSEL.CheckState = 0
        chk_FSEL.BackColor = clrUncheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("OPEN")
        ssp_WHERE.Visible = False
    End Sub


#End Region



    Private Sub vS11_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles vS11.CellDoubleClick
        Call DATA_SEARCH_Vs12_new()
    End Sub

    Private Sub chk_OpenSOWI_CheckedChanged(sender As Object, e As EventArgs) Handles chk_ImportDeclare.CheckedChanged
        Try
            If chk_ImportDeclare.Checked = True Then SplitContainer2.Panel1Collapsed = False
            If chk_ImportDeclare.Checked = False Then SplitContainer2.Panel1Collapsed = True
        Catch ex As Exception

        End Try
    End Sub

  End Class