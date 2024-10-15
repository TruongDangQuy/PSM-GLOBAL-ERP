Public Class PFP34229

#Region "Variable"

    Private Dsu01 As Long     'Data Su
    Private wGCODE As String
    Private Form_Close As Boolean

    Private W1312 As New T1312_AREA
    Private L1312 As New T1312_AREA

    Private W1322 As New T1322_AREA
    Private L1322 As New T1322_AREA

    Private priCheckPurchasingOrder As String
    Private priCheckIOType As String

#End Region

#Region "Form_load"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim xISUD3421F As String = ISUD3421F.Text
        Dim xISUD1311A As String = ISUD1311A.Text
        Dim xISUD7110K As String = ISUD7110K.Text
        Dim xISUD7106A As String = ISUD7106A.Text

        Call Cms_additem(Cms_1, xISUD3421F & " - " & WordConv("InSide By Order Base") & "- " & WordConv("INSERT") & "(F5)",
                                xISUD1311A & " - " & WordConv("SEARCH") & "(F6)",
                                xISUD7110K & " - " & WordConv("SEARCH") & "(F7)",
                                xISUD7106A & " - " & WordConv("SEARCH") & "(F8)")
        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False)

        Me.KeyPreview = True


        Vs10.ContextMenuStrip = Cms_1

        Call Cms_additem(Cms_2, "-",
                                xISUD3421F & "- " & WordConv("InSide By Order Base") & "- " & WordConv("SEARCH") & "(F6)",
                                xISUD3421F & "- " & WordConv("InSide By Order Base") & "- " & WordConv("UPDATE") & "(F7)",
                                xISUD3421F & "- " & WordConv("InSide By Order Base") & "- " & WordConv("DELETE") & "(F8)",
                                xISUD3421F & "- " & WordConv("InSide By Order Base") & "- " & WordConv("APPROVAL") & "(F9)")

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

        chk_FSEL.Text = WordConv("CLOSE")
        ssp_WHERE.Visible = True
    End Sub

    Private Sub DATA_INIT()
        priCheckPurchasingOrder = "1"
        priCheckIOType = "2"

    End Sub
#End Region

#Region "Function"

    Private Sub MAIN_JOB01()
        Dim JobCard As String
        Dim OrderNo As String
        Dim OrderNoSeq As String

        Try

            JobCard = getData(Vs10, getColumIndex(Vs10, "JobCard"), Vs10.ActiveSheet.ActiveRowIndex)
            OrderNo = getData(Vs10, getColumIndex(Vs10, "KEY_OrderNo"), Vs10.ActiveSheet.ActiveRowIndex)
            OrderNoSeq = getData(Vs10, getColumIndex(Vs10, "KEY_OrderNoSeq"), Vs10.ActiveSheet.ActiveRowIndex)

            If chk_CheckUse1.Checked = True Then JobCard = ""

            If ISUD3421F.Link_ISUD3421F_AUTO(1, JobCard, OrderNo, OrderNoSeq, priCheckIOType, priCheckPurchasingOrder, txt_cdDepartment.Code, Me.Name) = False Then Exit Sub

        Catch ex As Exception
            MsgBox("cmd_OK_Click!", vbCritical)
        End Try

    End Sub
    Private Sub MAIN_JOB02()
        If ptc_1.SelectedIndex = 0 Then
            Dim OrderNo As String
            If getData(Vs10, getColumIndex(Vs10, "KEY_OrderNo"), Vs10.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

            OrderNo = getData(Vs10, getColumIndex(Vs10, "KEY_OrderNo"), Vs10.ActiveSheet.ActiveRowIndex)

            If ISUD1311A.Link_ISUD1311A(2, OrderNo, Me.Name) = False Then Exit Sub
        End If

    End Sub

    Private Sub MAIN_JOB03()
        If ptc_1.SelectedIndex = 0 Then
            Dim ShoesCode As String
            ShoesCode = getData(Vs10, getColumIndex(Vs10, "ShoesCode"), Vs10.ActiveSheet.ActiveRowIndex)

            If READ_PFK7106(ShoesCode) Then
                If ISUD7110K.Link_ISUD7110K(2, D7106.ShoesParent, Me.Name) = False Then Exit Sub

            End If
        End If

    End Sub

    Private Sub MAIN_JOB04()
        If ptc_1.SelectedIndex = 0 Then
            Dim ShoesCode As String
            ShoesCode = getData(Vs10, getColumIndex(Vs10, "ShoesCode"), Vs10.ActiveSheet.ActiveRowIndex)

            If ISUD7106A.Link_ISUD7106A(2, ShoesCode, Me.Name) = False Then Exit Sub
        End If

    End Sub


    Private Sub MAIN_JOB12()
        If getData(Vs20, getColumIndex(Vs20, "KEY_FactOrderNo"), Vs20.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

        Dim FactOrderNo As String

        FactOrderNo = getData(Vs20, getColumIndex(Vs20, "KEY_FactOrderNo"), Vs20.ActiveSheet.ActiveRowIndex)

        If ISUD3421F.Link_ISUD3421F(2, FactOrderNo, priCheckIOType, priCheckPurchasingOrder, Me.Name) = False Then Exit Sub

    End Sub

    Private Sub MAIN_JOB13()
        If getData(Vs20, getColumIndex(Vs20, "KEY_FactOrderNo"), Vs20.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

        Dim FactOrderNo As String

        FactOrderNo = getData(Vs20, getColumIndex(Vs20, "KEY_FactOrderNo"), Vs20.ActiveSheet.ActiveRowIndex)

        If ISUD3421F.Link_ISUD3421F(3, FactOrderNo, priCheckIOType, priCheckPurchasingOrder, Me.Name) = False Then Exit Sub


    End Sub

    Private Sub MAIN_JOB14()
        If getData(Vs20, getColumIndex(Vs20, "KEY_FactOrderNo"), Vs20.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

        Dim FactOrderNo As String

        FactOrderNo = getData(Vs20, getColumIndex(Vs20, "KEY_FactOrderNo"), Vs20.ActiveSheet.ActiveRowIndex)

        If ISUD3421F.Link_ISUD3421F(4, FactOrderNo, priCheckIOType, priCheckPurchasingOrder, Me.Name) = False Then Exit Sub
    End Sub

    Private Sub MAIN_JOB05()

        If getData(Vs20, getColumIndex(Vs20, "KEY_FactOrderNo"), Vs20.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub
        Dim KEY_FactOrderNo As String

        KEY_FactOrderNo = getData(Vs20, getColumIndex(Vs20, "KEY_FactOrderNo"), Vs20.ActiveSheet.ActiveRowIndex)


        If ISUD3421P.Link_ISUD3421P(4, KEY_FactOrderNo,
                                    getData(Vs20, getColumIndex(Vs20, "KEY_FactOrderSeq"), Vs20.ActiveSheet.ActiveRowIndex), Me.Name) = False Then Exit Sub

        'If LINE_MOVE_DISPLAY01() = False Then
        '    SPR_CLEAR(Vs20, Vs20.ActiveSheet.ActiveRowIndex, 0, Vs20.ActiveSheet.ActiveRowIndex, Vs20.ActiveSheet.ColumnCount - 1)
        '    setData(Vs20, getColumIndex(Vs20, "DateRequestMaterial"), Vs20.ActiveSheet.ActiveRowIndex, "[DELETED]", Color.Red)
        'End If

    End Sub


#End Region

#Region "Data_search"
    Private Function DATA_SEARCH_VS10(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS10 = False
        Try

            Vs10.Enabled = False

            If chk_CheckUse1.Checked = True Then
                DS1 = PrcDS("USP_PFP34219_SEARCH_VS10", cn, txt_CustomerCode.Code, txt_cdSeason.Code, txt_Line.Data, txt_Article.Data, txt_ColorName.Data, txt_Slno.Data, "1")
            Else
                DS1 = PrcDS("USP_PFP34219_SEARCH_VS10", cn, txt_CustomerCode.Code, txt_cdSeason.Code, txt_Line.Data, txt_Article.Data, txt_ColorName.Data, txt_Slno.Data, "2")
            End If

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs10, DS1, "USP_PFP34219_SEARCH_VS10", "VS10")
                Vs10.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(Vs10, DS1, "USP_PFP34219_SEARCH_VS10", "VS10")
            DATA_SEARCH_VS10 = True

            Vs10.Enabled = True
        Catch ex As Exception
            MsgBox("DATA_SEARCH_VS10")
        Finally
            Vs10.Enabled = True
        End Try
    End Function

    Private Function DATA_SEARCH_VS11(JobCard As String, OrderNo As String, OrderNoSeq As String) As Boolean
        DATA_SEARCH_VS11 = False
        Try
            vS11.Enabled = False

            If chk_CheckUse1.Checked = True Then
                DS1 = PrcDS("USP_PFP34219_SEARCH_VS11", cn, JobCard, OrderNo, OrderNoSeq)
            Else
                DS1 = PrcDS("USP_PFP34219_SEARCH_VS11", cn, JobCard, OrderNo, OrderNoSeq)
            End If

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS11, DS1, "USP_PFP34219_SEARCH_VS11", "VS11")
                vS11.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS11, DS1, "USP_PFP34219_SEARCH_VS11", "VS11")
            DATA_SEARCH_VS11 = True

            vS11.Enabled = True
        Catch ex As Exception
            MsgBox("DATA_SEARCH_VS11")
        Finally
            vS11.Enabled = True
        End Try
    End Function
    Private Function DATA_SEARCH_VS20(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS20 = False
        Try

            Vs20.Enabled = False

            Dim CheckRequest1 As String = "0"
            Dim CheckRequest2 As String = "0"
            Dim CheckRequest3 As String = "0"
            Dim CheckRequest4 As String = "0"
            Dim CheckRequest5 As String = "0"
            Dim CheckRequest9 As String = "0"
            If rbt_CheckRequest1.Checked = True Then CheckRequest1 = "1"
            If rbt_CheckRequest2.Checked = True Then CheckRequest2 = "1"
            If rbt_CheckRequest3.Checked = True Then CheckRequest3 = "1"
            If rbt_CheckRequest4.Checked = True Then CheckRequest4 = "1"
            If rbt_CheckRequest5.Checked = True Then CheckRequest5 = "1"
            If rbt_CheckRequest9.Checked = True Then CheckRequest9 = "1"

            If chk_CheckUse1.Checked = True Then
                DS1 = PrcDS("USP_PFP34219_SEARCH_VS20_F1", cn, txt_CustomerCode.Code, txt_cdSeason.Code, txt_Line.Data, txt_Article.Data, txt_ColorName.Data, txt_Slno.Data, txt_cdSubProcess.Code, txt_InchargeMR.Code, "1", CheckRequest1, CheckRequest2, CheckRequest3, CheckRequest4, CheckRequest5, CheckRequest9)
            Else
                DS1 = PrcDS("USP_PFP34219_SEARCH_VS20_F1", cn, txt_CustomerCode.Code, txt_cdSeason.Code, txt_Line.Data, txt_Article.Data, txt_ColorName.Data, txt_Slno.Data, txt_cdSubProcess.Code, txt_InchargeMR.Code, "2", CheckRequest1, CheckRequest2, CheckRequest3, CheckRequest4, CheckRequest5, CheckRequest9)
            End If
            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs20, DS1, "USP_PFP34219_SEARCH_VS20_F1", "VS20")
                Vs20.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(Vs20, DS1, "USP_PFP34219_SEARCH_VS20_F1", "VS20")
            DATA_SEARCH_VS20 = True

            Vs20.Enabled = True
        Catch ex As Exception
            MsgBox("DATA_SEARCH_VS20")
        Finally
            Vs20.Enabled = True
        End Try
    End Function

    Private Function DATA_SEARCH_VS21(cdSubProcess As String, JobCard As String, OrderNo As String, OrderNoSeq As String) As Boolean
        DATA_SEARCH_VS21 = False
        Dim FactOrderNo, FactOrderSeq As String

        FactOrderNo = getData(Vs20, getColumIndex(Vs20, "FactOrderNo"), Vs20.ActiveSheet.ActiveRowIndex)
        FactOrderSeq = getData(Vs20, getColumIndex(Vs20, "FactOrderSeq"), Vs20.ActiveSheet.ActiveRowIndex)

        Try
            Vs21.Enabled = False

            DS1 = PrcDS("USP_PFP34219_SEARCH_VS21_F1", cn, FactOrderNo, FactOrderSeq)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs21, DS1, "USP_PFP34219_SEARCH_VS21", "VS21")
                Vs21.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(Vs21, DS1, "USP_PFP34219_SEARCH_VS21", "VS21")
            DATA_SEARCH_VS21 = True

            Vs21.Enabled = True
        Catch ex As Exception
            MsgBox("DATA_SEARCH_VS21")
        Finally
            Vs21.Enabled = True
        End Try
    End Function
    Private Function LINE_MOVE_DISPLAY01() As Boolean
        LINE_MOVE_DISPLAY01 = False

        Dim cdFactory As String
        Dim cdMainProcess As String
        Dim cdLineProd As String
        Dim DatePlan As String

        Try
            cdFactory = getData(Vs10, getColumIndex(Vs10, "KEY_cdFactory"), Vs10.ActiveSheet.ActiveRowIndex)
            cdMainProcess = getData(Vs10, getColumIndex(Vs10, "KEY_cdMainProcess"), Vs10.ActiveSheet.ActiveRowIndex)
            DatePlan = getData(Vs10, getColumIndex(Vs10, "KEY_DatePlan"), Vs10.ActiveSheet.ActiveRowIndex)
            cdLineProd = getData(Vs10, getColumIndex(Vs10, "KEY_cdLineProd"), Vs10.ActiveSheet.ActiveRowIndex)

            DS1 = PrcDS("USP_PFP40799_SEARCH_VS10_LINE", cn, cdFactory, cdMainProcess, DatePlan, cdLineProd)

            If GetDsRc(DS1) = 0 Then
                Vs10.Enabled = True
                Exit Function
            End If

            READ_SPREAD(Vs10, DS1, "USP_PFP40799_SEARCH_VS10", "VS10", Vs10.ActiveSheet.ActiveRowIndex)

            Vs10.Enabled = True
            LINE_MOVE_DISPLAY01 = True
        Catch ex As Exception
            MsgBoxP("LINE_MOVE_DISPLAY01")
        Finally
            Vs10.Enabled = True
        End Try
    End Function

#End Region

#Region "Function"
    Private Sub KEY_COUNT_K1322()
        Dim SQL As String
        Dim rd As SqlClient.SqlDataReader

        SQL = "SELECT MAX(CAST(K1322_MatchingAutoKey AS DECIMAL)) AS MAX_CODE FROM PFK1322 "
        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_CODE) Then
            L1322.MatchingAutoKey = "00000001"
        Else
            L1322.MatchingAutoKey = Format(CInt(rd!MAX_CODE + 1), "00000000")
        End If

        W1322.MatchingAutoKey = L1322.MatchingAutoKey

        rd.Close()

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
        If sender.Equals(tst_5) Then
            MAIN_JOB05()
        End If
    End Sub
    Private Sub VS10_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs10.CellClick
        If e.ColumnHeader = True Then Exit Sub
        Vs10.ActiveSheet.ActiveColumnIndex = e.Column
        Vs10.ActiveSheet.ActiveRowIndex = e.Row
        Vs10.ActiveSheet.AddSelection(e.Row, e.Column, 1, 1)

        If e.Column = getColumIndex(Vs10, "DCHK") Then
            Vs10.ActiveSheet.OperationMode = OperationMode.Normal
        Else
            Vs10.ActiveSheet.OperationMode = OperationMode.SingleSelect
        End If

    End Sub

    Private Sub VS10_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs10.CellDoubleClick
        If e.ColumnHeader = True Then Exit Sub
        Vs10.ActiveSheet.ActiveColumnIndex = e.Column
        Vs10.ActiveSheet.ActiveRowIndex = e.Row
        Vs10.ActiveSheet.AddSelection(e.Row, e.Column, 1, 1)

        If e.Column = getColumIndex(Vs10, "DCHK") Then
            Vs10.ActiveSheet.OperationMode = OperationMode.Normal
            Exit Sub
        Else
            Vs10.ActiveSheet.OperationMode = OperationMode.SingleSelect
        End If

        Dim JobCard As String = ""
        Dim OrderNo As String = ""
        Dim OrderNoSeq As String = ""

        JobCard = getData(Vs10, getColumIndex(Vs10, "JobCard"), Vs10.ActiveSheet.ActiveRowIndex)
        OrderNo = getData(Vs10, getColumIndex(Vs10, "KEY_OrderNo"), Vs10.ActiveSheet.ActiveRowIndex)
        OrderNoSeq = getData(Vs10, getColumIndex(Vs10, "KEY_OrderNoSeq"), Vs10.ActiveSheet.ActiveRowIndex)

        Call DATA_SEARCH_VS11(JobCard, OrderNo, OrderNoSeq)

    End Sub

    Private Sub VS20_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs20.CellDoubleClick
        Dim JobCard As String
        Dim OrderNo As String
        Dim OrderNoSeq As String
        Dim cdSubProcess As String

        cdSubProcess = getData(Vs20, getColumIndex(Vs20, "cdSubProcess"), Vs20.ActiveSheet.ActiveRowIndex)
        JobCard = getData(Vs20, getColumIndex(Vs20, "JobCard"), Vs20.ActiveSheet.ActiveRowIndex)
        OrderNo = getData(Vs20, getColumIndex(Vs20, "KEY_OrderNo"), Vs20.ActiveSheet.ActiveRowIndex)
        OrderNoSeq = getData(Vs20, getColumIndex(Vs20, "KEY_OrderNoSeq"), Vs20.ActiveSheet.ActiveRowIndex)

        Call DATA_SEARCH_VS21(cdSubProcess, JobCard, OrderNo, OrderNoSeq)

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
    Private Sub Cms_1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles Cms_1.ItemClicked
        If Cms_1.Items(0).Selected = True Then
            Cms_1.Hide()
            MAIN_JOB01()

        ElseIf Cms_1.Items(1).Selected = True Then
            Cms_1.Hide()
            MAIN_JOB02()

        ElseIf Cms_1.Items(2).Selected = True Then
            Cms_1.Hide()
            MAIN_JOB03()

        ElseIf Cms_1.Items(3).Selected = True Then
            Cms_1.Hide()
            MAIN_JOB04()

        ElseIf Cms_1.Items(4).Selected = True Then
            Cms_1.Hide()
            'MAIN_JOB05()

        End If

    End Sub

    Private Sub Cms_2_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles Cms_2.ItemClicked
        If Cms_2.Items(0).Selected = True Then
            Cms_2.Hide()

        ElseIf Cms_2.Items(1).Selected = True Then
            Cms_2.Hide()
            MAIN_JOB12()

        ElseIf Cms_2.Items(2).Selected = True Then
            Cms_2.Hide()
            MAIN_JOB13()

        ElseIf Cms_2.Items(3).Selected = True Then
            Cms_2.Hide()
            MAIN_JOB14()

        ElseIf Cms_2.Items(4).Selected = True Then
            Cms_2.Hide()
            MAIN_JOB05()

        End If

    End Sub

    Private Sub Me_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.Width > 20 Then
            ptc_1.ItemSize = New Size((Me.Width - 20) / 2, 30)
        End If
    End Sub

#End Region

End Class