Public Class PFP80021
#Region "Variable"
    Private Dsu01 As Long
    Private wGCODE As String
    Private Form_Close As Boolean
    Private SizeChk As Boolean = False

    Private SQL_SeaSon As String

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
    Private Sub PFP80021_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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
            DS1 = PrcDS("USP_PFP80021_SEARCH_VS_SEASON", cn, ListCode("Season"))
            SPR_PRO_NEW(vs_Season, DS1, "USP_PFP80021_SEARCH_VS_SEASON", "vs_Season")

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

            Call DATA_SEARCH_MulSQL_SEASON()

            DS1 = PrcDS("USP_PFP80021_SEARCH_vS_Cus", cn, CustomerCode, cdSeason, SQL_SeaSon)
            SPR_PRO_NEW(vS_Cus, DS1, "USP_PFP80021_SEARCH_vS_Cus", "vS_Cus")

            Psc_3.SplitterDistance = SPR_SHEETWIDHT(vS_Cus) + cSprWidthSize

            DS1 = Nothing
            DATA_SEARCH_HEAD_vS_Cus = True

        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Function

    Public Function DATA_SEARCH_HEAD_vS_Line() As Boolean
        DATA_SEARCH_HEAD_vS_Line = False
        Dim CustomerCode As String
        Dim cdSeason As String

        CustomerCode = getData(vS_Cus, getColumIndex(vS_Cus, "CustomerCode"), vS_Cus.ActiveSheet.ActiveRowIndex)
        cdSeason = getData(vs_Season, getColumIndex(vs_Season, "BasicCode"), vs_Season.ActiveSheet.ActiveRowIndex)

        Try
            Call DATA_SEARCH_MulSQL_SEASON()

            DS1 = PrcDS("USP_PFP80021_SEARCH_vS_Line_f1", cn, SQL_SeaSon, CustomerCode, ListCode("SpecState"))
            SPR_PRO_NEW(vS_Line, DS1, "USP_PFP80021_SEARCH_vS_Line", "vS_Line")

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
        Dim ChkMaster As String = "1"

        Try

            Call DATA_SEARCH_MulSQL_SEASON()

            DS1 = PrcDS("USP_PFP80021_SEARCH_vs_Job", cn, txt_cdSite.Code, txt_CustPONO.Data, txt_Article.Data)
            SPR_PRO_NEW(vs_Job, DS1, "USP_PFP80021_SEARCH_vs_Job", "vs_Job")

            DATA_SEARCH_HEAD_vs_Job = True

        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Function

    Public Function DATA_SEARCH_MulSQL_SEASON() As Boolean
        DATA_SEARCH_MulSQL_SEASON = False

        Try
            Dim i As Integer
            Dim icnt As Integer

            Dim strTemp1 As String
            Dim strTemp2 As String
            Dim seSeason As String
            Dim cdSeason As String

            SQL_SeaSon = ""

            For i = 0 To vs_Season.ActiveSheet.RowCount - 1
                If getDataM(vs_Season, getColumIndex(vs_Season, "MDCHK"), i) = "1" Then
                    icnt = icnt + 1
                End If

            Next

            If icnt = 0 Then
                seSeason = getData(vs_Season, getColumIndex(vs_Season, "KEY_seSeason"), vs_Season.ActiveSheet.ActiveRowIndex)
                cdSeason = getData(vs_Season, getColumIndex(vs_Season, "KEY_cdSeason"), vs_Season.ActiveSheet.ActiveRowIndex)

                If READ_PFK7171(seSeason, cdSeason) = True Then
                    SQL_SeaSon = " AND " & "(" & "K7106_cdSeason" & " = ''" & D7171.BasicCode & "'' " & ")"
                End If

                DATA_SEARCH_MulSQL_SEASON = True
                Exit Function
            End If

            If icnt > 1 Then
                For i = 0 To vs_Season.ActiveSheet.RowCount - 1
                    seSeason = getData(vs_Season, getColumIndex(vs_Season, "KEY_seSeason"), i)
                    cdSeason = getData(vs_Season, getColumIndex(vs_Season, "KEY_cdSeason"), i)

                    If getDataM(vs_Season, getColumIndex(vs_Season, "MDCHK"), i) = "1" Then

                        If READ_PFK7171(seSeason, cdSeason) = True Then
                            If i = 1 Then
                                strTemp1 = " AND " & "(" & "K7106_cdSeason" & "=''" & D7171.BasicCode & "'' "

                            Else
                                strTemp2 = strTemp2 & " OR " & "K7106_cdSeason" & " = ''" & D7171.BasicCode & "'' "
                            End If
                        End If
                    End If
                Next

                SQL_SeaSon = strTemp1 & strTemp2 & ")"

            Else
                For i = 0 To vs_Season.ActiveSheet.RowCount - 1
                    seSeason = getData(vs_Season, getColumIndex(vs_Season, "KEY_seSeason"), i)
                    cdSeason = getData(vs_Season, getColumIndex(vs_Season, "KEY_cdSeason"), i)

                    If getDataM(vs_Season, getColumIndex(vs_Season, "MDCHK"), i) = "1" Then

                        If READ_PFK7171(seSeason, cdSeason) = True Then
                            SQL_SeaSon = " AND " & "(" & "K7106_cdSeason" & " = ''" & D7171.BasicCode & "'' " & ")"
                        End If
                    End If

                    DATA_SEARCH_MulSQL_SEASON = True
                    Exit Function
                Next

            End If

            DATA_SEARCH_MulSQL_SEASON = True
        Catch ex As Exception
            Call MsgBoxP("1", "DATA_SEARCH_MulSQL_SEASON")
        End Try
    End Function

    Private Sub vs_Season_CellClick(sender As Object, e As CellClickEventArgs) Handles vs_Season.CellDoubleClick

        vS_Cus.ActiveSheet.RowCount = 0
        vS_Line.ActiveSheet.RowCount = 0
        vs_Job.ActiveSheet.RowCount = 0

        Dim xCol As Long
        xCol = vs_Season.ActiveSheet.ActiveColumnIndex

        If xCol <> getColumIndex(vs_Season, "MDCHK") Then
            Call DATA_SEARCH_HEAD_vS_Cus()
        End If

    End Sub
    Private Sub vS_Cus_CellClick(sender As Object, e As CellClickEventArgs) Handles vS_Cus.CellDoubleClick

        vS_Line.ActiveSheet.RowCount = 0
        vs_Job.ActiveSheet.RowCount = 0

        Call DATA_SEARCH_HEAD_vS_Line()

    End Sub
    Private Sub vS_Line_CellClick(sender As Object, e As CellClickEventArgs) Handles vS_Line.CellDoubleClick

        vs_Job.ActiveSheet.RowCount = 0

        Call DATA_SEARCH_HEAD_vs_Job()
    End Sub

    Private int_lnCol As Integer
    Private int_lnRow As Integer

    Private Sub vs_Job_CellClick1(sender As Object, e As CellClickEventArgs) Handles vs_Job.CellClick
        Try
            vs_Job.ActiveSheet.Cells(int_lnRow, int_lnCol).Note = ""
            vs_Job.ActiveSheet.Cells(int_lnRow, int_lnCol).NoteStyle = NoteStyle.Hidden

            DS1 = PrcDS("USP_PFP80021_SEARCH_HLP", cn, vs_Job.ActiveSheet.Columns(e.Column).Tag)

            If GetDsRc(DS1) = 0 Then Exit Sub

            Select Case GetDsData(DS1, 0, 0)

            End Select

            int_lnRow = e.Row
            int_lnCol = e.Column
            vs_Job.ActiveSheet.Cells(e.Row, e.Column).Note = "D.Click to view"
            vs_Job.ActiveSheet.Cells(e.Row, e.Column).NoteStyle = NoteStyle.StickyNote
        Catch ex As Exception

        End Try
        

    End Sub

    Private Sub vS_Job_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles vs_Job.CellDoubleClick
        Try

    
        'DS1 = PrcDS("USP_PFP80021_SEARCH_HLP", cn, getColumName(vs_Job, e.Column))

        DS1 = PrcDS("USP_PFP80021_SEARCH_HLP", cn, vs_Job.ActiveSheet.Columns(e.Column).Tag)

        If GetDsRc(DS1) = 0 Then Exit Sub

        Select Case GetDsData(DS1, 0, 0)

            Case "OrderNo"
                Call ISUD1311A.Link_ISUD1311A(2, getData(vs_Job, getColumIndex(vs_Job, "KEY_OrderNo"), e.Row), "PFP13120")


            Case "ShoesCode"
                Dim menuItems() As MenuItem = New MenuItem() _
                        {New MenuItem("ITEM CODE - Information"), _
                        New MenuItem("Spec Information - Information"), _
                         New MenuItem("CBD Information - Information"), _
                         New MenuItem("Image"), _
                          New MenuItem("Doc"), _
                        New MenuItem("Exit")}

                Dim buttonMenu As New ContextMenu(menuItems)
                'buttonMenu.Show(sender, New System.Drawing.Point(Me.Location.X / 2, Me.Location.Y / 2))

                buttonMenu.Show(sender, New System.Drawing.Point(MousePosition.X / 8, MousePosition.Y / 2))

                For Each Objecta As MenuItem In menuItems
                    Objecta.Tag = getData(vs_Job, e.Column, e.Row)
                    AddHandler Objecta.Click, AddressOf MenuClick
                Next

            Case "StitchingProduction"

                If READ_PFK4073_TOPJOBCARD(GetDsData(DS1, 1, 0), getData(vs_Job, getColumIndex(vs_Job, "JobCard"), e.Row)) Then
                    Call ISUD4073B.Link_ISUD4073B(2, D4073.cdFactory, D4073.cdMainProcess, D4073.cdLineProd, D4073.LineTno)
                End If

                Case "Production"
                    Dim f As New HLP4070B

                    Call f.Link_HLP4070B(getData(vs_Job, getColumIndex(vs_Job, "KEY_OrderNo"), e.Row) + getData(vs_Job, getColumIndex(vs_Job, "KEY_OrderNosEQ"), e.Row), GetDsData(DS1, 0, 1))





            End Select

        Catch ex As Exception

        End Try


    End Sub


    Private Sub MenuClick(sender As Object, e As EventArgs)
        Dim MenuAt As MenuItem
        MenuAt = CType(sender, MenuItem)
        If MenuAt.Text = "ITEM CODE - Information" Then
            Dim f As New ISUD7106A
            Call f.Link_ISUD7106A("2", MenuAt.Tag, "PFP71060")

        ElseIf MenuAt.Text = "Spec Information - Information" Then
            Dim f As New ISUD7110K
            If READ_PFK7106(MenuAt.Tag) Then
                If f.Link_ISUD7110K(2, D7106.ShoesParent, "PFP71085") = False Then Exit Sub
            End If


        ElseIf MenuAt.Text = "CBD Information - Information" Then
            Dim f As New ISUD7110D
            If READ_PFK7106(MenuAt.Tag) Then
                If f.Link_ISUD7110D(2, D7106.ShoesParent, "PFP71086") = False Then Exit Sub
            End If

        ElseIf MenuAt.Text = "Image" Then
            Call downLoadFile(MenuAt.Tag, "1")

        ElseIf MenuAt.Text = "Doc" Then
            Call downLoadFile(MenuAt.Tag, "2")

        ElseIf MenuAt.Text = "Exit" Then

        End If
    End Sub


    Private Sub downLoadFile(strShoeSode As String, checkType As String)
        Dim sFileName As String
        Dim strSql As String

        Try
            strSql = "Select TOP 1 * from [PFK7107] "
            strSql = strSql & " WHERE [K7107_ShoesCode]= '" & strShoeSode & "' AND [K7107_CheckType] = '" & checkType & "' "

            Dim sqlCmd As New SqlClient.SqlCommand(strSql, cn)
            DS1 = PrcDS(sqlCmd, cn)

            If GetDsRc(DS1) > 0 Then
                sFileName = GetDsData(DS1, 0, "K7107_FileName")
                sFileName &= "." & GetDsData(DS1, 0, "K7107_FileType")

                Dim fileData As Object = GetDsData(DS1, 0, "K7107_ImageData")

                Dim sTempFileName As String = System.IO.Path.GetTempPath & sFileName

                If Not fileData Is Nothing Then

                    Using fs As New IO.FileStream(sTempFileName, IO.FileMode.OpenOrCreate, IO.FileAccess.Write)
                        fs.Write(fileData, 0, fileData.Length)
                        fs.Flush()
                        fs.Close()
                    End Using

                    Process.Start(sTempFileName)

                End If
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

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

    End Sub
    Private Sub txt_GNAME_KeyDown(sender As Object, e As KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.Enter : cmd_SEARCH.Focus()
        End Select
    End Sub
    Private Sub vS1_LostFocus(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click


        Call DATA_SEARCH_HEAD_vs_Job()

    End Sub


#End Region


End Class