Public Class PFP13300

#Region "Variable"
    Private Dsu01 As Long
    Private wGCODE As String
    Protected prg As E_PRG

    Private W1311 As T1311_AREA
    Private Form_Close As Boolean
#End Region

#Region "Form_load"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False)


        vS10.ContextMenuStrip = Cms_2
        Call Cms_additem(Cms_2, _
                             "IMPORT CONTROL" & " - " & WordConv("INPUT") & "(F5)",
                             "IMPORT CONTROL" & " - " & WordConv("DELETE") & "(F6)")


        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False)

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
        Dim ItemCodeFIN As String
        Dim OrderNo As String
        Dim OrderNoSeq As String

        If ptc_001.SelectedIndex <> 0 Then Exit Sub


        Try
            Call PrcExeNoError_ValueVN("USP_PFK3440_INSERT_INVOICENO", cn, Pub.SITE, Pub.SAW)
            Call DATA_SEARCH_vS10()

        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB05!", vbCritical)
        End Try

    End Sub

    Private Sub MAIN_JOB02()
        Dim OrderNo As String
        Try
            Msg_Result = MsgBoxP("Do you want to delete?", vbYesNo)

            If Msg_Result <> vbYes Then Exit Sub

            Dim InvoiceNo As String = getData(vS10, getColumIndex(vS10, "KEY_InvoiceNo"), vS10.ActiveSheet.ActiveRowIndex)
            Dim strMsg As String

            strMsg = PrcExeNoError_ValueVN("USP_PFK3440_DELETE_INVOICENO", cn, InvoiceNo)

            If strMsg <> "" Then
                Call MsgBoxP(strMsg)
                Exit Sub
            End If


            SPR_DEL(vS10, 0, vS10.ActiveSheet.ActiveRowIndex)
            vS10.Focus()

        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB04!", vbCritical)
        End Try
    End Sub
    Private Sub MAIN_JOB05()

    End Sub


#End Region

#Region "Data_search"


    Private Function DATA_SEARCH_vS10(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_vS10 = False

        vS10.Enabled = False


        Try
            DS1 = PrcDS("USP_PFP13300_SEARCH_vS10", cn, txt_cdSite.Code, txt_Article.Data, txt_CustPONO.Data, txt_InvoiceNo.Data)


            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS10, DS1, "USP_PFP13300_SEARCH_vS10", "vS10")

                vS10.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS10, DS1, "USP_PFP13300_SEARCH_vS10", "vS10")

            vS10.ActiveSheet.ClearConditionalFormatings()

            Dim text As New FarPoint.Win.Spread.TextConditionalFormattingRule(FarPoint.Win.Spread.TextConditionOperator.BeginsWith, " ")
            text.Operator = FarPoint.Win.Spread.TextConditionOperator.BeginsWith
            text.BackColor = Color.LightBlue
            vS10.ActiveSheet.SetConditionalFormatting(-1, -1, text)

            DATA_SEARCH_vS10 = True

            vS10.Enabled = True
        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_vS10")
        End Try

    End Function

    Private Function DATA_SEARCH_vS20(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_vS20 = False

        vS20.Enabled = False


        Try
            DS1 = PrcDS("USP_PFP13300_SEARCH_vS20", cn, txt_cdSite.Code, txt_Article.Data, txt_CustPONO.Data)


            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS20, DS1, "USP_PFP13300_SEARCH_vS20", "vS20")

                vS20.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS20, DS1, "USP_PFP13300_SEARCH_vS20", "vS20")
            DATA_SEARCH_vS20 = True


            vS20.ActiveSheet.ClearConditionalFormatings()

            Dim text As New FarPoint.Win.Spread.TextConditionalFormattingRule(FarPoint.Win.Spread.TextConditionOperator.BeginsWith, " ")
            text.Operator = FarPoint.Win.Spread.TextConditionOperator.BeginsWith
            text.BackColor = Color.LightBlue
            vS20.ActiveSheet.SetConditionalFormatting(-1, -1, text)


            vS20.Enabled = True
        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_vS20")
        End Try

    End Function


    Private Function DATA_SEARCH_vS30(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_vS30 = False

        vS30.Enabled = False


        Try
            DS1 = PrcDS("USP_PFP13300_SEARCH_vS30", cn, txt_cdSite.Code, txt_Article.Data, txt_CustPONO.Data)


            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS30, DS1, "USP_PFP13300_SEARCH_vS30", "vS30")

                vS30.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS30, DS1, "USP_PFP13300_SEARCH_vS30", "vS30")
            DATA_SEARCH_vS30 = True

            vS30.Enabled = True
        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_vS30")
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

            If ptc_001.SelectedIndex = 0 Then Call DATA_SEARCH_vS10()
            If ptc_001.SelectedIndex = 1 Then Call DATA_SEARCH_vS20()
            If ptc_001.SelectedIndex = 2 Then Call DATA_SEARCH_vS30()

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
            If Cms_1.Items(1).Selected = True Then
                Cms_1.Hide()
                MAIN_JOB05()

            End If


        Catch ex As Exception
            Call MsgBoxP("35", "cmd_SEARCH_Click")
        End Try

    End Sub


    Private Sub vs_GotFocus(sender As Object, e As EventArgs)
        chk_FSEL.CheckState = 0
        chk_FSEL.BackColor = clrUncheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("OPEN")
        ssp_WHERE.Visible = False
    End Sub

    Private Sub chk_Total_CheckedChanged(sender As Object, e As EventArgs)


    End Sub
#End Region


    Private Sub vSChange(xROW As Integer)
        Try
            If chk_AutoSave.Checked = False Then Exit Sub

            Dim lstr_Para As New List(Of String)
            Dim i, j As Integer


            lstr_Para.Clear()
            i = vS10.ActiveSheet.ActiveRowIndex

            For j = 0 To vS10.ActiveSheet.ColumnCount - 1
                If IsNumeric(vS10.ActiveSheet.Cells(i, j).Value) = True Then

                    lstr_Para.Add(CDecp(getData(vS10, j, i)))
                Else
                    lstr_Para.Add(FormatSQL(getData(vS10, j, i)))
                End If


            Next

            Application.DoEvents()
            Dim StrValue As String
            StrValue = PrcExeNoError_Value("USP_PFK3440_UPDATE_INVOICENO", cn, lstr_Para.ToArray)

            setData(vS10, getColumIndex(vS10, "Result"), xROW, StrValue)

     


        Catch ex As Exception

        End Try
    End Sub
    Private Sub vS10_Change(sender As Object, e As ChangeEventArgs) Handles vS10.Change
        Try
            Dim xROW As Integer

            xROW = e.Row

            vSChange(xROW)

            If getData(vS10, xROW, e.Column) <> "" Then
                SPR_BACKCOLORCELL(vS10, Color.Aqua, e.Column, e.Row)

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub vS10_KeyDown(sender As Object, e As KeyEventArgs) Handles vS10.KeyDown
        Try
            Dim xROW As Integer
            If e.KeyCode = Keys.Enter Then

                xROW = vS10.ActiveSheet.ActiveRowIndex

                vSChange(xROW)
            End If
        Catch ex As Exception

        End Try
    End Sub




    Private Sub vS2Change(xROW As Integer)
        Try
            If chk_AutoSave.Checked = False Then Exit Sub

            Dim lstr_Para As New List(Of String)
            Dim i, j As Integer


            lstr_Para.Clear()
            i = vS20.ActiveSheet.ActiveRowIndex

            For j = 0 To vS20.ActiveSheet.ColumnCount - 1
                If IsNumeric(vS20.ActiveSheet.Cells(i, j).Value) = True Then

                    lstr_Para.Add(CDecp(getData(vS20, j, i)))
                Else
                    lstr_Para.Add(FormatSQL(getData(vS20, j, i)))
                End If


            Next

            Application.DoEvents()
            Dim StrValue As String
            StrValue = PrcExeNoError_Value("USP_PFK3440_UPDATE_INVOICENO", cn, lstr_Para.ToArray)

            setData(vS20, getColumIndex(vS20, "Result"), xROW, StrValue)




        Catch ex As Exception

        End Try
    End Sub
    Private Sub vS2Change(sender As Object, e As ChangeEventArgs) Handles vS20.Change
        Try
            Dim xROW As Integer

            xROW = e.Row

            vS2Change(xROW)

            If getData(vS20, xROW, e.Column) <> "" Then
                SPR_BACKCOLORCELL(vS20, Color.Aqua, e.Column, e.Row)

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub vS2Change(sender As Object, e As KeyEventArgs) Handles vS20.KeyDown
        Try
            Dim xROW As Integer
            If e.KeyCode = Keys.Enter Then

                xROW = vS20.ActiveSheet.ActiveRowIndex

                vS2Change(xROW)
            End If
        Catch ex As Exception

        End Try
    End Sub

End Class