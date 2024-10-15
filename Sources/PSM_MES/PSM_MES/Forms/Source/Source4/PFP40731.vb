Public Class PFP40731

#Region "Variable"

    Private Dsu01 As Long     'Data Su
    Private wGCODE As String
    Private Form_Close As Boolean
#End Region

#Region "Form_load"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call Cms_additem(Cms_1,
                        "LINE INFORMATION PROCCESING - " & WordConv("INPUT") & "(F5)",
                        "LINE INFORMATION PROCCESING - " & WordConv("SEARCH") & "(F6)",
                        "LINE INFORMATION PROCCESING - " & WordConv("UPDATE") & "(F7)",
                        "LINE INFORMATION PROCCESING - " & WordConv("DELETE") & "(F8)",
                        "LINE INFORMATION PROCCESING - " & WordConv("COPY") & "(F9)")

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False)

        Me.KeyPreview = True

        Call FORM_INIT()
        Call DATA_INIT()

        SdateEdate.text1 = Pub.DAT
        SdateEdate.text2 = Pub.DAT
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

        DS1 = PrcDS("USP_PFP40731_SEARCH_VS10", cn, SdateEdate.text1, SdateEdate.text2, txt_cdFactory.Code, txt_cdMainProcess.Code, txt_cdLineProd.Code)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(VS10, DS1, "USP_PFP40731_SEARCH_VS10", "VS10")
            VS10.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(VS10, DS1, "USP_PFP40731_SEARCH_VS10", "VS10")
        DATA_SEARCH_VS10 = True

        VS10.Enabled = True
    End Function

    Private Function DATA_SEARCH_VS11(cdFactory As String, cdMainProcess As String, DatePlan As String, cdLineProd As String, JobCard As String) As Boolean
        DATA_SEARCH_VS11 = False
        vS11.Enabled = False

        DS1 = PrcDS("USP_PFP40731_SEARCH_VS11", cn, cdFactory, cdMainProcess, DatePlan, cdLineProd, JobCard)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS11, DS1, "USP_PFP40731_SEARCH_VS11", "VS11")
            vS11.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS11, DS1, "USP_PFP40731_SEARCH_VS11", "VS11")
        DATA_SEARCH_VS11 = True

        vS11.Enabled = True
    End Function
    Private Function DATA_SEARCH_VS20(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS20 = False
        VS20.Enabled = False

        DS1 = PrcDS("USP_PFP40731_SEARCH_VS20", cn, SdateEdate.text1, SdateEdate.text2, txt_cdFactory.Code, txt_cdMainProcess.Code, txt_cdLineProd.Code)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS20, DS1, "USP_PFP40731_SEARCH_VS20", "VS20")
            vS20.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW_BARCODE(vS20, DS1, "USP_PFP40731_SEARCH_VS20", "VS20")
        DATA_SEARCH_VS20 = True

        vS20.Enabled = True
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
            DS1 = PrcDS("USP_PFP40731_SEARCH_VS10_LINE", cn, cdFactory, cdMainProcess, DatePlan, cdLineProd)

            If GetDsRc(DS1) = 0 Then
                VS10.Enabled = True
                Exit Function
            End If

            READ_SPREAD(VS10, DS1, "USP_PFP40731_SEARCH_VS10", "VS10", VS10.ActiveSheet.ActiveRowIndex)

            VS10.Enabled = True
            LINE_MOVE_DISPLAY01 = True
        Catch ex As Exception
            MsgBoxP("LINE_MOVE_DISPLAY01")
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
        If sender.Equals(tst_5) Then
            MAIN_JOB05()
        End If
    End Sub
    Private Sub VS10_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs10.CellClick
        If e.ColumnHeader = True Then Exit Sub
        VS10.ActiveSheet.ActiveColumnIndex = e.Column
        VS10.ActiveSheet.ActiveRowIndex = e.Row
        Vs10.ActiveSheet.AddSelection(e.Row, e.Column, 1, 1)

        If e.Column = getColumIndex(Vs10, "DCHK") Then
            Vs10.ActiveSheet.OperationMode = OperationMode.Normal
        Else
            Vs10.ActiveSheet.OperationMode = OperationMode.SingleSelect
        End If

    End Sub

    Private Sub VS10_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs10.CellDoubleClick
        Dim cdFactory As String
        Dim cdMainProcess As String
        Dim cdLineProd As String
        Dim DatePlan As String
        Dim JobCard As String

        cdFactory = txt_cdFactory.Code
        cdMainProcess = txt_cdMainProcess.Code
        DatePlan = SdateEdate.text1
        cdLineProd = getData(Vs10, getColumIndex(Vs10, "Key_cdLineProd"), Vs10.ActiveSheet.ActiveRowIndex)
        JobCard = getData(Vs10, getColumIndex(Vs10, "JobCard"), Vs10.ActiveSheet.ActiveRowIndex)

        If e.Column = getColumIndex(Vs10, "DCHK") Then Exit Sub

        Call DATA_SEARCH_VS11(cdFactory, cdMainProcess, DatePlan, cdLineProd, JobCard)

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

        If ItemMain.SelectedIndex = 0 Then Call DATA_SEARCH_VS10()
        If ItemMain.SelectedIndex = 1 Then Call DATA_SEARCH_VS20()

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
            MAIN_JOB05()

        End If

    End Sub


#End Region



End Class