Public Class PFP14123

#Region "Variable"
    Private Dsu01 As Long
    Private wGCODE As String
    Protected prg As E_PRG

    Private W1411 As T1411_AREA
    Private Form_Close As Boolean
#End Region

#Region "Form_load"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False)

        Call Cms_additem(Cms_1, _
                                "ORDER PROCESSING - " & WordConv("INPUT") & "(F5)",
                                "ORDER PROCESSING - " & WordConv("SEARCH") & "(F6)",
                                "ORDER PROCESSING - " & WordConv("UPDATE") & "(F7)",
                                "ORDER PROCESSING - " & WordConv("DELETE") & "(F8)",
                                "-",
                                "-",
                                "ORDER PROCESSING - " & WordConv("APPROVAL - ALL") & "(F10)")


        Vs1.ContextMenuStrip = Cms_1

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False)

        Me.KeyPreview = True

        Call FORM_INIT()
        Call DATA_INIT()

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
                Case Keys.F9 : Call MAIN_JOB05()
                Case Keys.F10 : Call MAIN_JOB06()
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

        SplitContainer1.Panel1Collapsed = Not chk_Total.Checked
        SplitContainer2.Panel1Collapsed = Not chk_Total.Checked

    End Sub

    Private Sub DATA_INIT()
        ssp_WHERE.txt_SdateEdate.text1 = System_Date_Add(-1)
        ssp_WHERE.txt_SdateEdate.text2 = System_Date_8()

        Call Gadget_Load(ssp_WHERE, Me.Name)

        Call DATA_SEARCH_HEAD_vs_Season()
        Call DATA_SEARCH_HEAD_vS_Line()

    End Sub
#End Region

#Region "Function"
    Private Sub MAIN_JOB01()
        Try
            If ISUD1411A.Link_ISUD1411A(1, "000000000", Me.Name) = False Then Exit Sub
            Call DATA_SEARCH_VS1()
        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB01!", vbCritical)
        End Try

    End Sub

    Private Sub MAIN_JOB02()
        Dim OrderNo As String
        Try
            If getData(Vs1, getColumIndex(Vs1, "KEY_OrderNo"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

            OrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNo"), Vs1.ActiveSheet.ActiveRowIndex)

            If ISUD1411A.Link_ISUD1411A(2, OrderNo, Me.Name) = False Then Exit Sub

        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB02!", vbCritical)
        End Try
    End Sub

    Private Sub MAIN_JOB03()
        Dim OrderNo As String
        Try
            If getData(Vs1, getColumIndex(Vs1, "KEY_OrderNo"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub
            OrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNo"), Vs1.ActiveSheet.ActiveRowIndex)

            If ISUD1411A.Link_ISUD1411A(3, OrderNo, Me.Name) = False Then Exit Sub
            Call DATA_SEARCH_VS1()
        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB03!", vbCritical)
        End Try
    End Sub

    Private Sub MAIN_JOB04()
        Dim OrderNo As String
        Try
            If getData(Vs1, getColumIndex(Vs1, "KEY_OrderNo"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub
            OrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNo"), Vs1.ActiveSheet.ActiveRowIndex)

            If ISUD1411A.Link_ISUD1411A(4, OrderNo, Me.Name) = False Then Exit Sub
            Call DATA_SEARCH_VS1()
        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB04!", vbCritical)
        End Try
    End Sub


    Private Sub KEY_COUNT()

        Dim YRNO As Integer
        YRNO = Mid(System_Date_8(), 3, 4)

        Try
            SQL = "SELECT MAX(CAST(SUBSTRING(K1411_OrderNo,7,3) AS DECIMAL)) AS MAX_MCODE FROM PFK1411 "
            SQL = SQL & " WHERE SUBSTRING(K1411_OrderNo,3,4) = '" & YRNO.ToString & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                W1411.OrderNo = "SO" & YRNO & "001"
            Else
                W1411.OrderNo = "SO" & YRNO & FormatP(CInt(rd!MAX_MCODE + 1), "000")
            End If

            rd.Close()
        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub

    Private Sub MAIN_JOB05()
        Dim OrderNo As String
        Dim OrderNoSeq As String
        Try
            If getData(Vs1, getColumIndex(Vs1, "KEY_OrderNo"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub
            If getData(Vs1, getColumIndex(Vs1, "KEY_OrderNoSeq"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub
            OrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNo"), Vs1.ActiveSheet.ActiveRowIndex)
            OrderNoSeq = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNoSeq"), Vs1.ActiveSheet.ActiveRowIndex)

            If READ_PFK1412(OrderNo, OrderNoSeq) = False Then Exit Sub
            If D1412.OrderDetailStatus = "3" Then MsgBoxEx("Approved!") : Exit Sub
            If D1412.OrderDetailStatus = "2" Then MsgBoxEx("Compelte!") : Exit Sub

            If ISUD1411P.Link_ISUD1411P(3, OrderNo, OrderNoSeq, Me.Name) = False Then Exit Sub
            Call DATA_SEARCH_VS1()
        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB05!", vbCritical)
        End Try
    End Sub

    Private Sub MAIN_JOB06()
        Dim OrderNo As String
        Dim OrderNoSeq As String
        Try
            If getData(Vs1, getColumIndex(Vs1, "KEY_OrderNo"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub
            If getData(Vs1, getColumIndex(Vs1, "KEY_OrderNoSeq"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub
            OrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNo"), Vs1.ActiveSheet.ActiveRowIndex)
            OrderNoSeq = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNoSeq"), Vs1.ActiveSheet.ActiveRowIndex)

            If ISUD1411P.Link_ISUD1411P(4, OrderNo, OrderNoSeq, Me.Name) = False Then Exit Sub
            Call DATA_SEARCH_VS1()
        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB06!", vbCritical)
        End Try

    End Sub

    Private Sub MAIN_JOB08()
        Dim OrderNo As String
        Dim OrderNoSeq As String
        Dim OrderNoNew As String

        Try
            If getData(Vs1, getColumIndex(Vs1, "KEY_OrderNo"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub
            If getData(Vs1, getColumIndex(Vs1, "KEY_OrderNoSeq"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub
            OrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNo"), Vs1.ActiveSheet.ActiveRowIndex)
            OrderNoSeq = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNoSeq"), Vs1.ActiveSheet.ActiveRowIndex)

            Call KEY_COUNT()
            OrderNoNew = W1411.OrderNo

            Dim StrMsg As String = MsgBox("Do you want to make a COPY of ORDERS?", vbYesNo)
            If StrMsg <> vbYes Then Exit Sub
            Dim Starting = New DevExpress.Utils.WaitDialogForm("Loading confirm process!", "PSM")

            If PrcExe("USP_PFK1411_COPY_ITEM_MASTER", cn, OrderNoNew, OrderNo) Then
                Starting.close()

                If ISUD1411A.Link_ISUD1411A(3, OrderNoNew, Me.Name) = False Then Exit Sub
                Call DATA_SEARCH_VS1()

            End If

        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB05!", vbCritical)
        End Try
    End Sub

    Private Sub MAIN_JOB09()
        Dim OrderNo As String
        Dim OrderNoSeq As String
        Dim OrderNoNew As String

        Try
            If getData(Vs1, getColumIndex(Vs1, "KEY_OrderNo"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub
            If getData(Vs1, getColumIndex(Vs1, "KEY_OrderNoSeq"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub
            OrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNo"), Vs1.ActiveSheet.ActiveRowIndex)
            OrderNoSeq = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNoSeq"), Vs1.ActiveSheet.ActiveRowIndex)

            Call KEY_COUNT()
            OrderNoNew = W1411.OrderNo

            Dim StrMsg As String = MsgBox("Do you want to make a COPY of 1 ORDER-LINE?", vbYesNo)
            If StrMsg <> vbYes Then Exit Sub
            Dim Starting = New DevExpress.Utils.WaitDialogForm("Loading confirm process!", "PSM")

            If PrcExe("USP_PFK1411_COPY_ITEM_MASTER_LINE", cn, OrderNoNew, OrderNo, OrderNoSeq) Then
                Starting.close()

                If ISUD1411A.Link_ISUD1411A(3, OrderNoNew, Me.Name) = False Then Exit Sub
                Call DATA_SEARCH_VS1()

            End If

        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB05!", vbCritical)
        End Try
    End Sub

    Private Sub MAIN_JOB10()
        Dim OrderNo As String
        Dim OrderNoSeq As String

        Try
            If getData(Vs1, getColumIndex(Vs1, "KEY_OrderNo"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub
            If getData(Vs1, getColumIndex(Vs1, "KEY_OrderNoSeq"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

            OrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNo"), Vs1.ActiveSheet.ActiveRowIndex)
            OrderNoSeq = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNoSeq"), Vs1.ActiveSheet.ActiveRowIndex)

      

        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB05!", vbCritical)
        End Try
    End Sub
#End Region

#Region "Data_search"
    Public Function DATA_SEARCH_HEAD_vs_Season() As Boolean
        DATA_SEARCH_HEAD_vs_Season = False
        Exit Function

        Try
            DS1 = PrcDS("USP_PFP14123_SEARCH_VS_SEASON", cn, ListCode("Season"))
            SPR_PRO_NEW(vs_Season, DS1, "USP_PFP14123_SEARCH_VS_SEASON", "vs_Season")

            DS1 = Nothing
            DATA_SEARCH_HEAD_vs_Season = True

        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Function

    Public Function DATA_SEARCH_HEAD_vS_Line() As Boolean
        DATA_SEARCH_HEAD_vS_Line = False
        Exit Function

        Dim cdSeason As String

        cdSeason = getData(vs_Season, getColumIndex(vs_Season, "KEY_cdSeason"), vs_Season.ActiveSheet.ActiveRowIndex)

        Try
            DS1 = PrcDS("USP_PFP14123_SEARCH_VS_LINE", cn, cdSeason, ssp_WHERE.gData_CustomerName, ssp_WHERE.gData_SDate,
                                                       ssp_WHERE.gData_EDate, ssp_WHERE.gData_CheckRequest)
            SPR_PRO_NEW(vS_Line, DS1, "USP_PFP14123_SEARCH_VS_LINE", "vS_Line")

            DATA_SEARCH_HEAD_vS_Line = True

        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Function

    Private Function DATA_SEARCH_VS1(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS1 = False

        Vs1.Enabled = False

        Dim cdSeasonName As String
        Dim CustomerName As String
        Dim Line As String
        Dim cdSpecStateName As String

        cdSeasonName = getData(vS_Line, getColumIndex(vS_Line, "cdSeasonName"), vS_Line.ActiveSheet.ActiveRowIndex)
        CustomerName = getData(vS_Line, getColumIndex(vS_Line, "CustomerName"), vS_Line.ActiveSheet.ActiveRowIndex)
        Line = getData(vS_Line, getColumIndex(vS_Line, "Line"), vS_Line.ActiveSheet.ActiveRowIndex)
        cdSpecStateName = getData(vS_Line, getColumIndex(vS_Line, "cdSpecStateName"), vS_Line.ActiveSheet.ActiveRowIndex)

        If cdSeasonName <> "" Then ssp_WHERE.gData_Season = cdSeasonName
        If CustomerName <> "" Then ssp_WHERE.gData_CustomerName = CustomerName
        If Line <> "" Then ssp_WHERE.gData_Line = Line
        If cdSpecStateName <> "" Then ssp_WHERE.gData_SpecState = cdSpecStateName

        Try
            If chk_Total.Checked Then
                DS1 = PrcDS("USP_PFP14123_SEARCH_VS1_GROUPBASE", cn, ssp_WHERE.gData_SDate,
                                                      ssp_WHERE.gData_EDate,
                                                      ssp_WHERE.gData_chkGCodeCheck,
                                                      ssp_WHERE.gData_chkGCodeSQL,
                                                      ssp_WHERE.gData_CustomerName,
                                                      ssp_WHERE.gData_Season,
                                                      ssp_WHERE.gData_SpecNoRef,
                                                      ssp_WHERE.gData_SpecStatus,
                                                      ssp_WHERE.gData_SpecState,
                                                      ssp_WHERE.gData_SpecKind,
                                                      ssp_WHERE.gData_SizeRange,
                                                      ssp_WHERE.gData_Article,
                                                      ssp_WHERE.gData_Line,
                                                      ssp_WHERE.gData_MaterialName,
                                                      ssp_WHERE.gData_ColorName,
                                                      ssp_WHERE.gData_MoldName,
                                                      ssp_WHERE.gData_LastName,
                                                      ssp_WHERE.gData_Incharge,
                                                      ssp_WHERE.gData_CheckRequest,
                                                      ssp_WHERE.gData_CheckUse0,
                                                      ssp_WHERE.gData_CheckUse1)

                If GetDsRc(DS1) = 0 Then
                    SPR_PRO_NEW(Vs1, DS1, "USP_PFP14123_SEARCH_VS1_GROUPBASE", "Vs1")
                    Vs1.ActiveSheet.RowCount = 0
                    Vs1.Enabled = True
                    Exit Function
                End If

                SPR_PRO_NEW(Vs1, DS1, "USP_PFP14123_SEARCH_VS1_GROUPBASE", "Vs1")
                DATA_SEARCH_VS1 = True

                Vs1.Enabled = True

            Else
                DS1 = PrcDS("USP_PFP14123_SEARCH_VS1", cn, ssp_WHERE.gData_SDate,
                                                           ssp_WHERE.gData_EDate,
                                                           ssp_WHERE.gData_chkGCodeCheck,
                                                           ssp_WHERE.gData_chkGCodeSQL,
                                                           ssp_WHERE.gData_CustomerName,
                                                           ssp_WHERE.gData_Season,
                                                           ssp_WHERE.gData_SpecNoRef,
                                                           ssp_WHERE.gData_SpecStatus,
                                                           ssp_WHERE.gData_SpecState,
                                                           ssp_WHERE.gData_SpecKind,
                                                           ssp_WHERE.gData_SizeRange,
                                                           ssp_WHERE.gData_Article,
                                                           ssp_WHERE.gData_Line,
                                                           ssp_WHERE.gData_MaterialName,
                                                           ssp_WHERE.gData_ColorName,
                                                           ssp_WHERE.gData_MoldName,
                                                           ssp_WHERE.gData_LastName,
                                                           ssp_WHERE.gData_Incharge,
                                                           ssp_WHERE.gData_CheckRequest,
                                                           ssp_WHERE.gData_CheckUse0,
                                                           ssp_WHERE.gData_CheckUse1)


                If GetDsRc(DS1) = 0 Then
                    SPR_PRO_NEW(Vs1, DS1, "USP_PFP14123_SEARCH_VS1", "Vs1")
                    Vs1.ActiveSheet.RowCount = 0
                    Vs1.Enabled = True
                    Exit Function
                End If

                SPR_PRO_NEW(Vs1, DS1, "USP_PFP14123_SEARCH_VS1", "Vs1")
                DATA_SEARCH_VS1 = True

                Vs1.Enabled = True

            End If



        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_VS1")
        End Try

    End Function

    Private Function DATA_SEARCH_vS2(ByVal OrderNo As String) As Boolean
        DATA_SEARCH_vS2 = False
        vS2.Enabled = False

        If chk_MaterialList.Checked = True Then Call DATA_SEARCH_VS2_MATERIAL() : Exit Function

        Try
            DS1 = PrcDS("USP_PFP14123_SEARCH_vS2", cn, OrderNo)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS2, DS1, "USP_PFP14123_SEARCH_vS2", "vS2")
                vS2.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS2, DS1, "USP_PFP14123_SEARCH_vS2", "vS2")
            Call VsSizeRange(vS2, "USP_ISU1411A_SEARCH_VS20_HEAD", OrderNo)

            DATA_SEARCH_vS2 = True

            vS2.Enabled = True

        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_vS2")
        End Try

    End Function

    Private Function DATA_SEARCH_VS2_MATERIAL() As Boolean
        DATA_SEARCH_VS2_MATERIAL = False
        vS2.Enabled = False
        Dim ShoesCode As String

        ShoesCode = getData(Vs1, getColumIndex(Vs1, "ShoesCode"), Vs1.ActiveSheet.ActiveRowIndex)

        Try
            DS1 = PrcDS("USP_PFP14123_SEARCH_vS2_SPECNO_SPECSEQ_F1", cn, ShoesCode)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS2, DS1, "USP_PFP14123_SEARCH_vS2_SPECNO_SPECSEQ_F1", "vS2")
                vS2.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS2, DS1, "USP_PFP14123_SEARCH_vS2_SPECNO_SPECSEQ_F1", "vS2")

            DATA_SEARCH_VS2_MATERIAL = True

            vS2.Enabled = True

        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_vS2")
        End Try

    End Function

    '    Private Function DATA_SEARCH_VS2_MATERIAL(ByVal OrderNo As String) As Boolean
    '        DATA_SEARCH_VS2_MATERIAL = False
    '        Dim i As Integer

    '        Dim SCol As Integer
    '        Dim Value() As String
    '        Dim SpecNoList As String

    '        For i = 0 To Vs1.ActiveSheet.RowCount - 1
    '            If getDataM(Vs1, getColumIndex(Vs1, "CheckUse"), i) <> "1" Then GoTo next1
    '            SpecNoList = SpecNoList & "''" & C
    '            SpecNoList = SpecNoList & "!" & getData(Vs1, getColumIndex(Vs1, "KEY_SpecNoSeq"), i) & "''"
    '            SpecNoList = SpecNoList & ","
    'next1:
    '        Next

    '        If SpecNoList = "" Then Exit Function

    '        SpecNoList = Strings.Left(SpecNoList, Len(SpecNoList) - 1)
    '        Vs1.Enabled = False

    '        Try
    '            DS1 = PrcDS("USP_PFP14123_SEARCH_vS2_MATERIAL", cn, SpecNoList)

    '            If GetDsRc(DS1) = 0 Then
    '                SPR_PRO_NEW(vS2, DS1, "USP_PFP14123_SEARCH_vS2_MATERIAL", "vS2")
    '                vS2.Enabled = True
    '                Exit Function
    '            End If

    '            SPR_PRO_NEW_NO_PFK9911(vS2, DS1, "USP_PFP14123_SEARCH_vS2_MATERIAL", "vS2")

    '            SCol = getColumIndex(vS2, "cdUnitMaterialName") + 1

    '            SPR_NUMBERCOLUMN(vS2, 4, SCol, GetDsCc(DS1) - 1)
    '            SPR_TOTALHEAD(vS2, SCol, GetDsCc(DS1) - 1)
    '            SPR_WIDTHCOLRANGE(vS2, 100, SCol, GetDsCc(DS1) - 1)

    '            vS2.ActiveSheet.ColumnHeader.RowCount += 5

    '            For i = 0 To SCol - 1
    '                vS2.ActiveSheet.ColumnHeader.Cells(0, i).RowSpan = 6
    '            Next

    '            For i = SCol To GetDsCc(DS1) - 1
    '                Value = vS2.ActiveSheet.ColumnHeader.Columns(i).Label.Split("!")
    '                If Value.Length = 2 Then
    '                    If READ_PFK0101(Value(0)) Then
    '                        If READ_PFK1312(D0101.OrderNo, D0101.OrderNoSeq) Then
    '                            If READ_PFK7106(D1312.ShoesCode) Then
    '                                Call READ_PFK7101(D7106.Customercode)
    '                                setDataCH(vS2, i, 1, D7101.CustomerName)
    '                                setDataCH(vS2, i, 2, D7106.Article)
    '                                setDataCH(vS2, i, 3, D7106.Line)
    '                            End If
    '                        End If
    '                    End If

    '                    If READ_PFK0102(Value(0), Value(1)) Then
    '                        setDataCH(vS2, i, 0, D0102.SpecNo + Chr(13) + Chr(9) + D0102.SpecNoSeq)

    '                        setDataCH(vS2, i, 4, D0102.TotalQty)
    '                        setDataCH(vS2, i, 5, D0102.Color)

    '                    End If
    '                End If

    '            Next

    '            SPR_TEXTBOXWARP(vS2, getColumIndex(vS2, "MaterialName"))
    '            DATA_SEARCH_VS2_MATERIAL = True

    '            vS2.Enabled = True

    '        Catch ex As Exception

    '        End Try

    '    End Function
#End Region

#Region "Event"
    Private Sub vs_Season_CellClick(sender As Object, e As CellClickEventArgs) Handles vs_Season.CellClick
        ssp_WHERE.gData_CustomerName = ""
        ssp_WHERE.gData_Line = ""
        ssp_WHERE.gData_SpecState = ""

        Call DATA_SEARCH_HEAD_vS_Line()
        Vs1.ActiveSheet.RowCount = 0
        vS2.ActiveSheet.RowCount = 0
    End Sub
    Private Sub vS_Line_CellClick(sender As Object, e As CellClickEventArgs) Handles vS_Line.CellClick
        Call DATA_SEARCH_VS1()
        If Vs1.ActiveSheet.RowCount > 1 Then Call DATA_SEARCH_vS2(getData(Vs1, getColumIndex(Vs1, "KEY_OrderNo"), 1))
    End Sub

    Private Sub Vs1_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellDoubleClick
        Dim OrderNo As String

        OrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNo"), Vs1.ActiveSheet.ActiveRowIndex)
        Call DATA_SEARCH_vS2(OrderNo)
    End Sub

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

            'Call DATA_SEARCH_HEAD_vs_Season()
            'Call DATA_SEARCH_HEAD_vS_Line()
            Call DATA_SEARCH_VS1()
            vS2.ActiveSheet.RowCount = 0
            'If vS2.ActiveSheet.RowCount > 1 Then Call DATA_SEARCH_vS2(getData(Vs1, getColumIndex(Vs1, "KEY_OrderNo"), 1))

        Catch ex As Exception
            Call MsgBoxP("35", "cmd_SEARCH_Click")
        End Try
    End Sub
    Private Sub Cms_1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles Cms_1.ItemClicked
        Try

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
            ElseIf Cms_1.Items(6).Selected = True Then
                Cms_1.Hide()
                MAIN_JOB06()

            ElseIf Cms_1.Items(8).Selected = True Then
                Cms_1.Hide()
                MAIN_JOB08()

            ElseIf Cms_1.Items(9).Selected = True Then
                Cms_1.Hide()
                MAIN_JOB09()

            End If

        Catch ex As Exception
            Call MsgBoxP("35", "cmd_SEARCH_Click")
        End Try

    End Sub

    Private Sub vs_GotFocus(sender As Object, e As EventArgs) Handles vs_Season.GotFocus, vS_Line.GotFocus, Vs1.GotFocus
        chk_FSEL.CheckState = 0
        chk_FSEL.BackColor = clrUncheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("OPEN")
        ssp_WHERE.Visible = False
    End Sub

    Private Sub chk_Total_CheckedChanged(sender As Object, e As EventArgs) Handles chk_Total.CheckedChanged
        SplitContainer1.Panel1Collapsed = Not chk_Total.Checked
        SplitContainer2.Panel1Collapsed = Not chk_Total.Checked

        'If chk_Total.Checked = True Then
        '    SplitContainer1.Panel1Collapsed = True
        '    SplitContainer2.Panel1Collapsed = True
        'ElseIf chk_Total.Checked = False Then
        '    SplitContainer1.Panel1Collapsed = False
        '    SplitContainer2.Panel1Collapsed = False
        'End If

    End Sub
#End Region

End Class