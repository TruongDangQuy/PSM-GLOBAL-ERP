Public Class PFP01018
#Region "Variable"
    Private Dsu01 As Long
    Private wGCODE As String
    Private Form_Close As Boolean
    Private SizeChk As Boolean = False
#End Region

#Region "load"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call TOOLBAR_CHECKSHOW(ToolStrip1, False, False, False, False, False, False)

        Call Cms_additem(Cms_1, _
                   "CHECK COMPLETE - " & WordConv("INPUT") & "(F5)")


        vs_Job.ContextMenuStrip = Cms_1

        Me.KeyPreview = True
        Call FORM_INIT()
        Call DATA_INIT()

    End Sub
    Private Sub PFP01018_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Call INTERRUPT_TOGGLE(e.KeyCode)
        Call Function_Event(e.KeyValue)
    End Sub
    Private Sub Function_Event(PressKey As Integer)
        Try
            Select Case PressKey
                Case Keys.F5 : Call MAIN_JOB06()
                Case Keys.F6 : Call MAIN_JOB11()
            End Select
        Catch ex As Exception
        End Try
    End Sub
    Private Sub FORM_INIT()
    End Sub

    Private Sub DATA_INIT()

    End Sub

#End Region

#Region "Link"

    Private Sub MAIN_JOB01()
        Dim sTRmSG As String

        sTRmSG = MsgBox("Do you want to check complete?", vbYesNoCancel)

        If sTRmSG = vbCancel Then Exit Sub

        If READ_PFK0102(getData(vs_Job, getColumIndex(vs_Job, "KEY_SpecNo"), vs_Job.ActiveSheet.ActiveRowIndex),
                        getData(vs_Job, getColumIndex(vs_Job, "KEY_SpecNoSEQ"), vs_Job.ActiveSheet.ActiveRowIndex)) Then

            If sTRmSG = vbYes Then D0102.CheckComplete = "1"
            If sTRmSG = vbNo Then D0102.CheckComplete = "2"

            Call REWRITE_PFK0102(D0102)

        End If
    End Sub

    Private Sub MAIN_JOB02()

    End Sub


    Private Sub MAIN_JOB03()

    End Sub

    Private Sub MAIN_JOB04()

    End Sub

    Private Sub MAIN_JOB05()

    End Sub

    Private Sub MAIN_JOB06()

    End Sub


    Private Sub MAIN_JOB11()

    End Sub

    Private Sub MAIN_JOB12()

    End Sub

    Private Sub MAIN_JOB13()

    End Sub

    Private Sub MAIN_JOB14()

    End Sub


    Private Sub MAIN_JOB02_1()

    End Sub


    Private Sub MAIN_JOB03_1()

    End Sub

    Private Sub MAIN_JOB04_1()

    End Sub


#End Region

#Region "search"

    Public Function DATA_SEARCH_HEAD_vs_Season() As Boolean
        DATA_SEARCH_HEAD_vs_Season = False

        Try
            DS1 = PrcDS("USP_PFP01018_SEARCH_VS_SEASON", cn, ListCode("Season"))
            SPR_PRO_NEW(vs_Season, DS1, "USP_PFP01018_SEARCH_VS_SEASON", "vs_Season")

            DS1 = Nothing
            DATA_SEARCH_HEAD_vs_Season = True

        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Function

    Public Function DATA_SEARCH_HEAD_vS_Cus() As Boolean
        DATA_SEARCH_HEAD_vS_Cus = False

        Dim cdSeason As String
        cdSeason = getData(vs_Season, getColumIndex(vs_Season, "BasicCode"), vs_Season.ActiveSheet.ActiveRowIndex)

        Dim CustomerCode As String
        CustomerCode = getData(vS_Cus, getColumIndex(vS_Cus, "CustomerCode"), vS_Cus.ActiveSheet.ActiveRowIndex)


        Try
            DS1 = PrcDS("USP_PFP01018_SEARCH_vS_Cus", cn, CustomerCode, cdSeason)
            SPR_PRO_NEW(vS_Cus, DS1, "USP_PFP01018_SEARCH_vS_Cus", "vS_Cus")

            Psc_3.SplitterDistance = SPR_SHEETWIDHT(vS_Cus) + cSprWidthSize

            DS1 = Nothing
            DATA_SEARCH_HEAD_vS_Cus = True

        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Function

    Public Function DATA_SEARCH_HEAD_vS_Line() As Boolean
        DATA_SEARCH_HEAD_vS_Line = False

        Try
            DS1 = PrcDS("USP_PFP01018_SEARCH_vS_Line", cn, ListCode("SpecState"))
            SPR_PRO_NEW(vS_Line, DS1, "USP_PFP01018_SEARCH_vS_Line", "vS_Line")

            Psc_2.SplitterDistance = SPR_SHEETWIDHT(vS_Cus) + SPR_SHEETWIDHT(vS_Line) + cSprWidthSize + cSprWidthSize
            Psc_3.SplitterDistance = SPR_SHEETWIDHT(vS_Cus) + cSprWidthSize

            DS1 = Nothing
            DATA_SEARCH_HEAD_vS_Line = True

        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Function


    Public Function DATA_SEARCH_HEAD_vs_Job() As Boolean
        DATA_SEARCH_HEAD_vs_Job = False
        Dim cdSeason As String
        Dim CustomerCode As String
        Dim cdSpecState As String
        Dim Line As String

        cdSeason = getData(vs_Season, getColumIndex(vs_Season, "BasicCode"), vs_Season.ActiveSheet.ActiveRowIndex)
        CustomerCode = getData(vS_Cus, getColumIndex(vS_Cus, "CustomerCode"), vS_Cus.ActiveSheet.ActiveRowIndex)
        cdSpecState = getData(vS_Line, getColumIndex(vS_Line, "BasicCode"), vS_Line.ActiveSheet.ActiveRowIndex)

        Try
            DS1 = PrcDS("USP_PFP01018_SEARCH_vs_Job", cn, cdSeason, CustomerCode, cdSpecState)
            SPR_PRO_NEW_BARCODE(vs_Job, DS1, "USP_PFP01018_SEARCH_vs_Job", "vs_Job")
            'SplitContainer2.SplitterDistance = SPR_SHEETWIDHT(vs_Job) + cSprWidthSize

            Dim i As Integer

            For i = 0 To vs_Job.ActiveSheet.RowCount - 1
                If getData(vs_Job, getColumIndex(vs_Job, "SealNo_Barcode"), i).ToString.Contains("*") Then
                    vs_Job.ActiveSheet.Cells(i, getColumIndex(vs_Job, "SealNo_Barcode")).Font = New Font("Code39(2:3)", 20)
                    vs_Job.ActiveSheet.Cells(i, getColumIndex(vs_Job, "Barcode_C39")).Font = New Font("Tahoma", 20)
                Else
                    vs_Job.ActiveSheet.Cells(i, getColumIndex(vs_Job, "Barcode_C39")).Font = New Font("Code39(2:3)", 20)
                    vs_Job.ActiveSheet.Cells(i, getColumIndex(vs_Job, "SealNo_Barcode")).Font = New Font("Tahoma", 20)
                End If

            Next

            DS1 = Nothing
            DATA_SEARCH_HEAD_vs_Job = True

        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Function


    Private Sub vs_Season_CellClick(sender As Object, e As CellClickEventArgs) Handles vs_Season.CellClick

        vS_Cus.ActiveSheet.RowCount = 0
        vS_Line.ActiveSheet.RowCount = 0
        vs_Job.ActiveSheet.RowCount = 0

        Call DATA_SEARCH_HEAD_vS_Cus()

    End Sub
    Private Sub vS_Cus_CellClick(sender As Object, e As CellClickEventArgs) Handles vS_Cus.CellClick

        vS_Line.ActiveSheet.RowCount = 0
        vs_Job.ActiveSheet.RowCount = 0

        Call DATA_SEARCH_HEAD_vS_Line()

    End Sub
    Private Sub vS_Line_CellClick(sender As Object, e As CellClickEventArgs) Handles vS_Line.CellClick

        vs_Job.ActiveSheet.RowCount = 0

        Call DATA_SEARCH_HEAD_vs_Job()
    End Sub

    Private Sub vS_Job_CellClick(sender As Object, e As CellClickEventArgs) Handles vs_Job.CellDoubleClick
        Dim SpecNo As String
        Dim SpecNoseq As String

        SpecNo = getData(sender, getColumIndex(sender, "KEY_SpecNo"), e.Row)
        SpecNoseq = getData(sender, getColumIndex(sender, "KEY_SpecNoseq"), e.Row)

    End Sub


#End Region

#Region "Function"
    Private Function Date_Check() As Boolean
        Date_Check = False
    End Function

    Private Function CustomerPurchasing_CHK() As String
        CustomerPurchasing_CHK = "1"
        Return CustomerPurchasing_CHK
    End Function

#End Region

#Region "Event"
    Private Sub Cms_1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles Cms_1.ItemClicked
        If Cms_1.Items(0).Selected = True Then
            Cms_1.Hide()
            MAIN_JOB01()
        End If
    End Sub

    Private Sub tst_1_Click(sender As Object, e As EventArgs) Handles tst_1.Click, tst_2.Click, tst_3.Click, tst_4.Click, tst_5.Click, tst_6.Click
        If sender.Equals(tst_1) Then
            MAIN_JOB01()
        End If
        If sender.Equals(tst_2) Then
            MAIN_JOB11()
        End If
        If sender.Equals(tst_3) Then
            MAIN_JOB02()
        End If
        If sender.Equals(tst_4) Then
            MAIN_JOB02()
        End If

    End Sub

    Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs)
        If e.ColumnHeader = True Or e.RowHeader = True Then Exit Sub
    End Sub

    Private Sub vS1_GotFocus(sender As Object, e As EventArgs)

        'Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False, WordConv("INPUT") & "(F5)", WordConv("SEARCH") & "(F6)", WordConv("CHANGE") & "(F7)", WordConv("DELETE") & "(F8)")

    End Sub
    Private Sub txt_GNAME_KeyDown(sender As Object, e As KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.Enter : cmd_SEARCH.Focus()
        End Select
    End Sub
    Private Sub vS1_LostFocus(sender As Object, e As EventArgs)

        'Call TOOLBAR_CHECKSHOW(ToolStrip1, True, False, False, False, False, False, WordConv("INPUT") & "(F5)")

    End Sub

    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click

        Call DATA_SEARCH_HEAD_vs_Season()
        Call DATA_SEARCH_HEAD_vS_Cus()
        Call DATA_SEARCH_HEAD_vS_Line()
        Call DATA_SEARCH_HEAD_vs_Job()

    End Sub


#End Region




   
End Class