Public Class PFP30119

#Region "Variable"

    Private Dsu01 As Long     'Data Su
    Private wGCODE As String
    Private Form_Close As Boolean

#End Region

#Region "Form_load"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.KeyPreview = True
        Call FORM_INIT()
        Call DATA_INIT()
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
        txt_DateRevise.Data = Pub.DAT

        chk_FSEL.Text = WordConv("CLOSE")
        ssp_WHERE.Visible = True
    End Sub

    Private Sub DATA_INIT()

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
        VS10.Enabled = False

        DS1 = PrcDS("USP_PFP30119_SEARCH_VS10", cn, txt_DateRevise.Data, txt_CustomerCode.Code, txt_cdSite.Code, txt_Line.Data, txt_Article.Data)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(Vs10, DS1, "USP_PFP30119_SEARCH_VS10", "VS10")
            VS10.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(Vs10, DS1, "USP_PFP30119_SEARCH_VS10", "VS10")
        DATA_SEARCH_VS10 = True

        VS10.Enabled = True
    End Function

    Private Function DATA_SEARCH_VS11(ShoesCode As String, OrderNo As String, OrderNoSeq As String) As Boolean
        DATA_SEARCH_VS11 = False
        vS11.Enabled = False

        DS1 = PrcDS("USP_PFP30119_SEARCH_VS11", cn, ShoesCode, OrderNo, OrderNoSeq)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS11, DS1, "USP_PFP30119_SEARCH_VS11", "VS11")
            vS11.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS11, DS1, "USP_PFP30119_SEARCH_VS11", "VS11")
        DATA_SEARCH_VS11 = True

        vS11.Enabled = True
    End Function
    Private Function DATA_SEARCH_VS20(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS20 = False
        VS20.Enabled = False

        DS1 = PrcDS("USP_PFP30119_SEARCH_VS20", cn, txt_DateRevise.Data, txt_CustomerCode.Code, txt_cdSite.Code, txt_Line.Data, txt_Article.Data)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(Vs20, DS1, "USP_PFP30119_SEARCH_VS20", "VS20")
            vS20.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(Vs20, DS1, "USP_PFP30119_SEARCH_VS20", "VS20")
        DATA_SEARCH_VS20 = True

        vS20.Enabled = True
    End Function

    Private Function DATA_SEARCH_VS21(ShoesCode As String, OrderNo As String, OrderNoSeq As String) As Boolean
        DATA_SEARCH_VS21 = False
        VS21.Enabled = False

        DS1 = PrcDS("USP_PFP30119_SEARCH_VS21", cn, ShoesCode, OrderNo, OrderNoSeq)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(Vs21, DS1, "USP_PFP30119_SEARCH_VS21", "VS21")
            VS21.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(Vs21, DS1, "USP_PFP30119_SEARCH_VS21", "VS21")
        DATA_SEARCH_VS21 = True

        VS21.Enabled = True
    End Function
    Private Function LINE_MOVE_DISPLAY01() As Boolean
        LINE_MOVE_DISPLAY01 = False

        Dim cdFactory As String
        Dim cdMainProcess As String
        Dim cdLineProd As String
        Dim DatePlan As String

        cdFactory = getData(VS10, getColumIndex(VS10, "KEY_cdFactory"), VS10.ActiveSheet.ActiveRowIndex)
        cdMainProcess = getData(VS10, getColumIndex(VS10, "KEY_cdMainProcess"), VS10.ActiveSheet.ActiveRowIndex)
        DatePlan = getData(VS10, getColumIndex(VS10, "KEY_DatePlan"), VS10.ActiveSheet.ActiveRowIndex)
        cdLineProd = getData(VS10, getColumIndex(VS10, "KEY_cdLineProd"), VS10.ActiveSheet.ActiveRowIndex)

        Try
            DS1 = PrcDS("USP_PFP40799_SEARCH_VS10_LINE", cn, cdFactory, cdMainProcess, DatePlan, cdLineProd)

            If GetDsRc(DS1) = 0 Then
                VS10.Enabled = True
                Exit Function
            End If

            READ_SPREAD(VS10, DS1, "USP_PFP40799_SEARCH_VS10", "VS10", VS10.ActiveSheet.ActiveRowIndex)

            VS10.Enabled = True
            LINE_MOVE_DISPLAY01 = True
        Catch ex As Exception
            MsgBoxP("LINE_MOVE_DISPLAY01")
        End Try
    End Function

#End Region

#Region "Event"
    Private Sub tst_1_Click(sender As Object, e As EventArgs) Handles tst_1.Click, tst_2.Click, tst_3.Click, tst_4.Click, tst_5.Click, tst_6.Click

    End Sub

    Private Sub VS10_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs10.CellDoubleClick
        If e.ColumnHeader = True Then Exit Sub
        Vs10.ActiveSheet.ActiveColumnIndex = e.Column
        Vs10.ActiveSheet.ActiveRowIndex = e.Row
        Vs10.ActiveSheet.AddSelection(e.Row, e.Column, 1, 1)

        Dim ShoesCode As String
        Dim OrderNo As String
        Dim OrderNoSeq As String

        ShoesCode = getData(Vs10, getColumIndex(Vs10, "ShoesCode"), Vs10.ActiveSheet.ActiveRowIndex)
        OrderNo = getData(Vs10, getColumIndex(Vs10, "KEY_OrderNo"), Vs10.ActiveSheet.ActiveRowIndex)
        OrderNoSeq = getData(Vs10, getColumIndex(Vs10, "KEY_OrderNoSeq"), Vs10.ActiveSheet.ActiveRowIndex)

        Call DATA_SEARCH_VS11(ShoesCode, OrderNo, OrderNoSeq)

    End Sub

    Private Sub VS20_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs20.CellDoubleClick
        Dim ShoesCode As String
        Dim OrderNo As String
        Dim OrderNoSeq As String

        ShoesCode = getData(Vs20, getColumIndex(Vs20, "ShoesCode"), Vs20.ActiveSheet.ActiveRowIndex)
        OrderNo = getData(Vs20, getColumIndex(Vs20, "KEY_OrderNo"), Vs20.ActiveSheet.ActiveRowIndex)
        OrderNoSeq = getData(Vs20, getColumIndex(Vs20, "KEY_OrderNoSeq"), Vs20.ActiveSheet.ActiveRowIndex)

        Call DATA_SEARCH_VS21(ShoesCode, OrderNo, OrderNoSeq)

    End Sub

    Private Sub VS10_GotFocus(sender As Object, e As EventArgs) Handles Vs10.GotFocus

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False)

        chk_FSEL.CheckState = 0
        chk_FSEL.BackColor = clrUncheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("OPEN")
        ssp_WHERE.Visible = False
    End Sub
    Private Sub txt_GNAME_KeyDown(sender As Object, e As KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.Enter : cmd_SEARCH.Focus()
        End Select
    End Sub
    Private Sub VS10_LostFocus(sender As Object, e As EventArgs) Handles Vs10.LostFocus

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, False, False, False, False, False)

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

        If ptc_1.SelectedIndex = 0 Then Call DATA_SEARCH_VS10()
        If ptc_1.SelectedIndex = 1 Then Call DATA_SEARCH_VS20()

    End Sub


    Private Sub Me_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.Width > 20 Then
            ptc_1.ItemSize = New Size((Me.Width - 20) / 2, 30)
        End If
    End Sub

#End Region



End Class