Public Class PFP71210
#Region "Variable"
    Private Dsu01 As Long     'Data Su
    Private wGCODE As String
    Protected prg As E_PRG


    Private Form_Close As Boolean
#End Region

#Region "Form_load"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, False, False, False, False, False, WordConv("INPUT") & "(F5)")
        Me.KeyPreview = True

        Call Cms_additem(Cms_1, ISUD7121A.Text & "-" & WordConv("INPUT") & "(F5)",
                               ISUD7121A.Text & "-" & WordConv("SEARCH") & "(F6)",
                               ISUD7121A.Text & "-" & WordConv("UPDATE") & "(F7)",
                               ISUD7121A.Text & "-" & WordConv("DELETE") & "(F8)")

        Vs1.ContextMenuStrip = Cms_1

        Call FORM_INIT()
        Call DATA_INIT()

    End Sub
    Private Sub Me_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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
    End Sub
#End Region

#Region "Function"
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
            Call DATA_SEARCH01()
        End If
    End Sub
    Private Sub MAIN_JOB01()

        If ISUD7121A.Link_ISUD7121A(1, "000000", Me.Name) = False Then Exit Sub

        Call DATA_SEARCH01()

    End Sub
    Private Sub MAIN_JOB02()
        Dim ColorCode As String

        ColorCode = getData(Vs1, getColumIndex(Vs1, "Key_ColorCode"), Vs1.ActiveSheet.ActiveRowIndex)

        If ISUD7121A.Link_ISUD7121A(2, ColorCode, Me.Name) = False Then Exit Sub

    End Sub
    Private Sub MAIN_JOB03()
        Dim ColorCode As String

        ColorCode = getData(Vs1, getColumIndex(Vs1, "Key_ColorCode"), Vs1.ActiveSheet.ActiveRowIndex)

        If ISUD7121A.Link_ISUD7121A(3, ColorCode, Me.Name) = False Then Exit Sub

        Call LINE_MOVE_DISPLAY01()

    End Sub
    Private Sub MAIN_JOB04()
        Dim ColorCode As String

        ColorCode = getData(Vs1, getColumIndex(Vs1, "Key_ColorCode"), Vs1.ActiveSheet.ActiveRowIndex)

        If ISUD7121A.Link_ISUD7121A(4, ColorCode, Me.Name) = False Then Exit Sub

        Call LINE_MOVE_DISPLAY01()

    End Sub
    Private Sub MAIN_JOB05()
        If getData(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

    End Sub

    Private Sub MAIN_JOB11()

    End Sub


#End Region

#Region "Data_search"
    Private Function DATA_SEARCH01() As Boolean
        DATA_SEARCH01 = False
        Dim i As Integer
        Dim Clr As String
        Dim R, G, B As String
        Vs1.Enabled = False

        DS1 = PrcDS("USP_PFP71210_SEARCH_VS1", cn, "*" & txt_ColorName.Data, txt_cdColorBase.Code, txt_cdColorCategory.Code, txt_CustomerCode.Code, rad_CheckUse1.CheckState, rad_CheckUse2.CheckState)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(Vs1, DS1, "USP_PFP71210_SEARCH_VS1", "Vs1")
            Vs1.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(Vs1, DS1, "USP_PFP71210_SEARCH_VS1", "Vs1")

        'For i = 0 To Vs1.ActiveSheet.RowCount - 1
        '    Try
        '        Clr = getData(Vs1, getColumIndex(Vs1, "ColorPosition"), i)
        '        R = Split(Clr, ";")(0)
        '        B = Split(Clr, ";")(1)
        '        G = Split(Clr, ";")(2)
        '        SPR_BACKCOLORCELL(Vs1, Color.FromArgb(R, G, B), getColumIndex(Vs1, "ColorPosition"), i)
        '    Catch ex As Exception

        '    End Try
        'Next


        DATA_SEARCH01 = True

        Vs1.Enabled = True
    End Function
    Private Function LINE_MOVE_DISPLAY01() As Boolean
        Dim ColorCode As String
        Dim xrow As Integer
        LINE_MOVE_DISPLAY01 = False
        Try
            xrow = Vs1.ActiveSheet.ActiveRowIndex
            ColorCode = getData(Vs1, getColumIndex(Vs1, "KEY_ColorCode"), xrow)
            DS1 = PrcDS("USP_PFP71210_SEARCH_VS1_LINE", cn, ColorCode)

            If GetDsRc(DS1) = 0 Then
                Exit Function
            End If
            READ_SPREAD(Vs1, DS1, "USP_PFP71210_SEARCH_VS1", "Vs1", xrow)

            LINE_MOVE_DISPLAY01 = True
        Catch ex As Exception

        End Try
    End Function
#End Region

#Region "Event"
    Private Sub Vs1_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellDoubleClick
        If e.ColumnHeader = False Then
            Call MAIN_JOB02()
        End If
    End Sub

    Private Sub vS1_GotFocus(sender As Object, e As EventArgs) Handles Vs1.GotFocus

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False, WordConv("INPUT") & "(F5)", WordConv("SEARCH") & "(F6)", WordConv("MODIFY") & "(F7)", WordConv("DELETE") & "(F8)")

        chk_FSEL.CheckState = 0
        chk_FSEL.BackColor = clrUncheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("OPEN")
        ssp_WHERE.Visible = False
    End Sub
    Private Sub txt_GNAME_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_ColorName.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter : cmd_SEARCH.Focus()
        End Select
    End Sub
    Private Sub vS1_LostFocus(sender As Object, e As EventArgs) Handles Vs1.LostFocus

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False, WordConv("INPUT") & "(F5)", WordConv("SEARCH") & "(F6)", WordConv("MODIFY") & "(F7)", WordConv("DELETE") & "(F8)")

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

        Call DATA_SEARCH01()

    End Sub

    Private Sub Cms_1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles Cms_1.ItemClicked
        'If Cms_1.Items(0).Selected = True Then
        '    Cms_1.Hide()
        '    MAIN_JOB11()

        'End If

    End Sub

#End Region

End Class