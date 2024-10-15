Public Class PFP71093

#Region "Variable"

    Private Dsu01 As Long     'Data Su
    Private wGCODE As String
    Private Form_Close As Boolean
#End Region

#Region "Form_load"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call Cms_additem(Cms_1,
                        "LINE INFORMATION PROCCESING - " & WordConv("INPUT") & "(F5)",
                       "LINE INFORMATION PROCCESING - " & WordConv("DELETE") & "(F6)")
                       



        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, False, False, False, False, WordConv("INPUT") & "(F5)", WordConv("DELETE") & "(F6)")

        Me.KeyPreview = True

        Call FORM_INIT()
        Call DATA_INIT()

        SdateEdate.text1 = System_Date_Add(0, -1)
        SdateEdate.text2 = System_Date_8()
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

        Me.chk_FormEnterkey = False

    End Sub

    Private Sub DATA_INIT()

    End Sub
#End Region

#Region "Function"
    Private Sub MAIN_JOB01()
        Dim cdSite As String
        Dim ProdDate As String
        Dim ProdDateSeq As String
        Dim ShoesCode As String
        Dim JobCard As String
        Dim QtyMan As String
        Dim QtyHour As String
        Dim PriceOrder As String
        Dim QtyTarget As String
        Dim str As String

        cdSite = getData(Vs10, getColumIndex(Vs10, "KEY_cdSite"), Vs10.ActiveSheet.ActiveRowIndex)
        ProdDate = getData(Vs10, getColumIndex(Vs10, "KEY_ProdDate"), Vs10.ActiveSheet.ActiveRowIndex)
        ProdDateSeq = getData(Vs10, getColumIndex(Vs10, "KEY_ProdDateSeq"), Vs10.ActiveSheet.ActiveRowIndex)
        ShoesCode = getData(Vs10, getColumIndex(Vs10, "KEY_ShoesCode"), Vs10.ActiveSheet.ActiveRowIndex)
        JobCard = getData(Vs10, getColumIndex(Vs10, "KEY_JobCard"), Vs10.ActiveSheet.ActiveRowIndex)

        QtyMan = CDecp(getData(Vs10, getColumIndex(Vs10, "QtyMan"), Vs10.ActiveSheet.ActiveRowIndex))
        QtyTarget = CDecp(getData(Vs10, getColumIndex(Vs10, "QtyTarget"), Vs10.ActiveSheet.ActiveRowIndex))


        If READ_PFK7106(ShoesCode) Then
            If QtyTarget > 0 Then
                str = MsgBoxP("Do you want to revise qty target?" & QtyTarget, vbYesNo)
                If str <> vbYes Then Exit Sub

                QtyTarget = InputBox("Input Qty target?")
                QtyMan = InputBox("Input Qty Man? ")
                QtyHour = InputBox("Input Qty Hour? ")
                PriceOrder = InputBox("Input Price Order? ")

                Call PrcExeNoError("USP_PHR7745_UPDATE_LINE", cn, cdSite, ProdDate, ProdDateSeq, JobCard, QtyTarget, QtyMan, QtyHour, PriceOrder)

                setData(Vs10, getColumIndex(Vs10, "QtyTarget"), Vs10.ActiveSheet.ActiveRowIndex, QtyTarget)
                setData(Vs10, getColumIndex(Vs10, "QtyMan"), Vs10.ActiveSheet.ActiveRowIndex, QtyMan)
                setData(Vs10, getColumIndex(Vs10, "QtyHour"), Vs10.ActiveSheet.ActiveRowIndex, QtyHour)
                setData(Vs10, getColumIndex(Vs10, "PriceOrder"), Vs10.ActiveSheet.ActiveRowIndex, PriceOrder)

                Exit Sub

            Else
                QtyTarget = InputBox("Input Qty target?")
                QtyMan = InputBox("Input Qty Man? ")
                QtyHour = InputBox("Input Qty Hour? ")
                PriceOrder = InputBox("Input Price Order? ")

                Call PrcExeNoError("USP_PHR7745_UPDATE_LINE", cn, cdSite, ProdDate, ProdDateSeq, JobCard, QtyTarget, QtyMan, QtyHour, PriceOrder)

                setData(Vs10, getColumIndex(Vs10, "QtyTarget"), Vs10.ActiveSheet.ActiveRowIndex, QtyTarget)
                setData(Vs10, getColumIndex(Vs10, "QtyMan"), Vs10.ActiveSheet.ActiveRowIndex, QtyMan)
                setData(Vs10, getColumIndex(Vs10, "QtyHour"), Vs10.ActiveSheet.ActiveRowIndex, QtyHour)
                setData(Vs10, getColumIndex(Vs10, "PriceOrder"), Vs10.ActiveSheet.ActiveRowIndex, PriceOrder)

                Exit Sub

            End If
        End If


        str = MsgBoxP("Do you want to insert line?", vbYesNo)

        If str <> vbYes Then Exit Sub

        If HLP3011A_OS_4010.Link_HLP3011Material("", "") = False Then
            If hlp0000SeVa = "" Then Exit Sub

            Call PrcExeNoError("USP_PHR7745_INSERT_LINE", cn, cdSite, ProdDate, ProdDateSeq, hlp0000SeVa)
            Call DATA_SEARCH_VS10()
        End If


    End Sub

    Private Sub MAIN_JOB02()
        Dim cdSite As String
        Dim ProdDate As String
        Dim ProdDateSeq As String
        Dim JobCard As String

        cdSite = getData(Vs10, getColumIndex(Vs10, "KEY_cdSite"), Vs10.ActiveSheet.ActiveRowIndex)
        ProdDate = getData(Vs10, getColumIndex(Vs10, "KEY_ProdDate"), Vs10.ActiveSheet.ActiveRowIndex)
        ProdDateSeq = getData(Vs10, getColumIndex(Vs10, "KEY_ProdDateSeq"), Vs10.ActiveSheet.ActiveRowIndex)
        JobCard = getData(Vs10, getColumIndex(Vs10, "KEY_JobCard"), Vs10.ActiveSheet.ActiveRowIndex)

        Dim str As String = MsgBoxP("Do you want to delete it?", vbYesNo)

        If str <> vbYes Then Exit Sub

        Call PrcExeNoError("USP_PHR7745_DELETE_LINE", cn, cdSite, ProdDate, ProdDateSeq, JobCard)



        Call DATA_SEARCH_VS10()


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

        DS1 = PrcDS("USP_PFP71093_SEARCH_VS10", cn, SdateEdate.text1, SdateEdate.text2, txt_cdFactory.Code, txt_cdSubProcess.Code, txt_cdLineProd.Code)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(VS10, DS1, "USP_PFP71093_SEARCH_VS10", "VS10")
            VS10.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(VS10, DS1, "USP_PFP71093_SEARCH_VS10", "VS10")
        DATA_SEARCH_VS10 = True

        VS10.Enabled = True
    End Function

    Private Function DATA_SEARCH_VS11(cdFactory As String, cdSubProcess As String, DatePlan As String, cdLineProd As String) As Boolean
        DATA_SEARCH_VS11 = False
        vS11.Enabled = False

        DS1 = PrcDS("USP_PFP71093_SEARCH_VS11", cn, cdFactory, cdSubProcess, DatePlan, "*" & cdLineProd)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS11, DS1, "USP_PFP71093_SEARCH_VS11", "VS11")
            vS11.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS11, DS1, "USP_PFP71093_SEARCH_VS11", "VS11")
        DATA_SEARCH_VS11 = True

        vS11.Enabled = True
    End Function
    Private Function DATA_SEARCH_VS20(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS20 = False
        VS20.Enabled = False

        DS1 = PrcDS("USP_PFP71093_SEARCH_VS20", cn, SdateEdate.text1, SdateEdate.text2, txt_cdFactory.Data, txt_cdSubProcess.Code, txt_cdLineProd.Code)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(VS20, DS1, "USP_PFP71093_SEARCH_VS20", "VS20")
            vS20.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS20, DS1, "USP_PFP71093_SEARCH_VS20", "VS20")
        DATA_SEARCH_VS20 = True

        vS20.Enabled = True
    End Function
    Private Function LINE_MOVE_DISPLAY01() As Boolean
        LINE_MOVE_DISPLAY01 = False

        Dim cdFactory As String
        Dim cdSubProcess As String
        Dim cdLineProd As String
        Dim DatePlan As String

        cdFactory = getData(VS10, getColumIndex(VS10, "KEY_cdFactory"), VS10.ActiveSheet.ActiveRowIndex)
        cdSubProcess = getData(VS10, getColumIndex(VS10, "KEY_cdSubProcess"), VS10.ActiveSheet.ActiveRowIndex)
        DatePlan = getData(VS10, getColumIndex(VS10, "KEY_DatePlan"), VS10.ActiveSheet.ActiveRowIndex)
        cdLineProd = getData(VS10, getColumIndex(VS10, "KEY_cdLineProd"), VS10.ActiveSheet.ActiveRowIndex)

        Try
            DS1 = PrcDS("USP_PFP71093_SEARCH_VS10_LINE", cn, cdFactory, cdSubProcess, DatePlan, cdLineProd)

            If GetDsRc(DS1) = 0 Then
                VS10.Enabled = True
                Exit Function
            End If

            READ_SPREAD(VS10, DS1, "USP_PFP71093_SEARCH_VS10", "VS10", VS10.ActiveSheet.ActiveRowIndex)

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
    'Private Sub VS10_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs10.CellClick
    '    If e.ColumnHeader = True Then Exit Sub
    '    VS10.ActiveSheet.ActiveColumnIndex = e.Column
    '    VS10.ActiveSheet.ActiveRowIndex = e.Row
    '    Vs10.ActiveSheet.AddSelection(e.Row, e.Column, 1, 1)

    '    If e.Column = getColumIndex(Vs10, "DCHK") Then
    '        Vs10.ActiveSheet.OperationMode = OperationMode.Normal
    '    Else
    '        Vs10.ActiveSheet.OperationMode = OperationMode.SingleSelect
    '    End If

    'End Sub

    Private Sub VS10_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs10.CellDoubleClick
        Dim cdFactory As String
        Dim cdSubProcess As String
        Dim cdLineProd As String
        Dim DatePlan As String

        cdFactory = getData(VS10, getColumIndex(VS10, "KEY_cdFactory"), VS10.ActiveSheet.ActiveRowIndex)
        cdSubProcess = getData(VS10, getColumIndex(VS10, "KEY_cdSubProcess"), VS10.ActiveSheet.ActiveRowIndex)
        DatePlan = getData(VS10, getColumIndex(VS10, "KEY_DatePlan"), VS10.ActiveSheet.ActiveRowIndex)
        cdLineProd = getData(VS10, getColumIndex(VS10, "KEY_cdLineProd"), VS10.ActiveSheet.ActiveRowIndex)

        If e.Column = getColumIndex(Vs10, "DCHK") Then Exit Sub

        Call DATA_SEARCH_VS11(cdFactory, cdSubProcess, DatePlan, cdLineProd)

    End Sub

    Private Sub VS10_GotFocus(sender As Object, e As EventArgs) Handles Vs10.GotFocus

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, False, False, False, False)

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

    Private Sub Vs10_KeyDown(sender As Object, e As KeyEventArgs) Handles Vs10.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim cdSite As String
            Dim ProdDate As String
            Dim ProdDateSeq As String
            Dim ShoesCode As String
            Dim JobCard As String
            Dim QtyMan As String
            Dim QtyHour As String
            Dim PriceOrder As String
            Dim QtyTarget As String
            Dim str As String

            cdSite = getData(Vs10, getColumIndex(Vs10, "KEY_cdSite"), Vs10.ActiveSheet.ActiveRowIndex)
            ProdDate = getData(Vs10, getColumIndex(Vs10, "KEY_ProdDate"), Vs10.ActiveSheet.ActiveRowIndex)
            ProdDateSeq = getData(Vs10, getColumIndex(Vs10, "KEY_ProdDateSeq"), Vs10.ActiveSheet.ActiveRowIndex)
            ShoesCode = getData(Vs10, getColumIndex(Vs10, "KEY_ShoesCode"), Vs10.ActiveSheet.ActiveRowIndex)
            JobCard = getData(Vs10, getColumIndex(Vs10, "KEY_JobCard"), Vs10.ActiveSheet.ActiveRowIndex)

            QtyMan = CDecp(getData(Vs10, getColumIndex(Vs10, "QtyMan"), Vs10.ActiveSheet.ActiveRowIndex))
            QtyTarget = CDecp(getData(Vs10, getColumIndex(Vs10, "QtyTarget"), Vs10.ActiveSheet.ActiveRowIndex))

            QtyHour = CDecp(getData(Vs10, getColumIndex(Vs10, "QtyHour"), Vs10.ActiveSheet.ActiveRowIndex))
            PriceOrder = CDecp(getData(Vs10, getColumIndex(Vs10, "PriceOrder"), Vs10.ActiveSheet.ActiveRowIndex))

            Call PrcExeNoError("USP_PHR7745_UPDATE_LINE", cn, cdSite, ProdDate, ProdDateSeq, JobCard, QtyTarget, QtyMan, QtyHour, PriceOrder)




        End If
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

        ElseIf Cms_1.Items(5).Selected = True Then
            Cms_1.Hide()
            MAIN_JOB05()

        End If

    End Sub


#End Region



End Class