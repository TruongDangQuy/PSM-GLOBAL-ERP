Public Class PFP40746
#Region "Variable"
    Private Dsu01 As Long     'Data Su
    Private wGCODE As String
    Protected prg As E_PRG

    Private W4073 As New T4073_AREA

    Private Form_Close As Boolean
    Private SizeChk As Boolean = False
#End Region

#Region "load"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call Cms_additem(Cms_1,
                     "PRODUCTION INPUT")

        Call Cms_additem(Cms_2,
                      "PRODUCTION PLAN - DELETE" & "(F5)",
                       "PRODUCTION PLAN - UPDATE STATUS" & "(F6)")

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False)

        Me.KeyPreview = True
        Call FORM_INIT()
        Call DATA_INIT()

    End Sub

    Private Sub PFP40730_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Call INTERRUPT_TOGGLE(e.KeyCode)
        Call Function_Event(e.KeyValue)
    End Sub

    Private Sub Function_Event(PressKey As Integer)
        Try
            Select Case PressKey
                Case Keys.F5 : Call MAIN_JOB01()
                Case Keys.F6 : Call MAIN_JOB02()
            End Select
        Catch ex As Exception
        End Try
    End Sub

    Private Sub FORM_INIT()
        txt_DatePlan.Data = System_Date_8()
        txt_cdMainProcess.Code = "070"

        If READ_PFK7171(ListCode("MainProcess"), txt_cdMainProcess.Code) Then
            txt_cdMainProcess.Data = D7171.BasicName
        End If

       

    End Sub

    Private Sub DATA_INIT()
        Psc_1.Panel1Collapsed = True
        Psc_2.Panel1Collapsed = True
        Psc_3.Panel1Collapsed = True

        Psc_0.Panel2Collapsed = True
    End Sub

#End Region

#Region "Link"

    Private Sub MAIN_JOB01()
        If Date_Check() = False Then Exit Sub
        Dim cdFactory As String
        Dim cdMainProcess As String
        Dim cdLineProd As String
        Dim LineTno As String


        If chk_FullScreen.Checked Then
            cdFactory = txt_cdFactory.Code
            cdMainProcess = txt_cdMainProcess.Code
            cdLineProd = getData(vS1, getColumIndex(vS1, "Key_cdLineProd"), vS1.ActiveSheet.ActiveRowIndex)
            LineTno = getData(vS1, getColumIndex(vS1, "Key_LineTno"), vS1.ActiveSheet.ActiveRowIndex)
        Else
            cdFactory = txt_cdFactory.Code
            cdMainProcess = txt_cdMainProcess.Code
            cdLineProd = getCellRH(vS1, 0, vS1.ActiveSheet.ActiveRowIndex)
            LineTno = (vS1.ActiveSheet.ActiveColumnIndex + 1).ToString("00")
            LineTno = CIntp(LineTno).ToString("00")
        End If


        If cdFactory = "" Or cdMainProcess = "" Or cdLineProd = "" Then Exit Sub

        If ISUD4073H.Link_ISUD4073H(4, cdFactory, cdMainProcess, cdLineProd, LineTno, Me.Name) = False Then Exit Sub

        Call LINE_MOVE_DISPLAY01(vS1, vS1.ActiveSheet.ActiveColumnIndex, vS1.ActiveSheet.ActiveRowIndex, cdLineProd)

    End Sub

    Private Sub MAIN_JOB02()
        If Date_Check() = False Then Exit Sub
        Dim cdFactory As String
        Dim cdMainProcess As String
        Dim cdLineProd As String
        Dim LineTno As String


        If chk_FullScreen.Checked Then
            cdFactory = txt_cdFactory.Code
            cdMainProcess = txt_cdMainProcess.Code
            cdLineProd = getData(vS1, getColumIndex(vS1, "Key_cdLineProd"), vS1.ActiveSheet.ActiveRowIndex)
            LineTno = getData(vS1, getColumIndex(vS1, "Key_LineTno"), vS1.ActiveSheet.ActiveRowIndex)
        Else
            cdFactory = txt_cdFactory.Code
            cdMainProcess = txt_cdMainProcess.Code
            cdLineProd = getCellRH(vS1, 0, vS1.ActiveSheet.ActiveRowIndex)
            LineTno = (vS1.ActiveSheet.ActiveColumnIndex + 1).ToString("00")
            LineTno = CIntp(LineTno).ToString("00")
        End If


        If cdFactory = "" Or cdMainProcess = "" Or cdLineProd = "" Then Exit Sub

        If ISUD4073H.Link_ISUD4073H(5, cdFactory, cdMainProcess, cdLineProd, LineTno, Me.Name) = False Then Exit Sub

        Call LINE_MOVE_DISPLAY01(vS1, vS1.ActiveSheet.ActiveColumnIndex, vS1.ActiveSheet.ActiveRowIndex, cdLineProd)

    End Sub

#End Region

#Region "search"
    
    Public Function DATA_SEARCH01(ProcessType As String) As Boolean
        Dim cmd As New SqlClient.SqlCommand
        Dim i As Integer
        Dim rd_c As SqlClient.SqlDataReader = Nothing

        DATA_SEARCH01 = False

        If txt_cdFactory.Code = "" Then Exit Function

        vS1.ActiveSheet.ColumnCount = 0
        vS1.ActiveSheet.RowCount = 0

        SPR_CLEAR(vS1)
        SPR_SET(vS1, , , , OperationMode.Normal, True)
        vS1.ActiveSheet.SelectionPolicy = Model.SelectionPolicy.Single
        vS1.RetainSelectionBlock = True

        If txt_DatePlan.Data <> System_Date_8() Then Exit Function

        Try

            DS1 = PrcDS("USP_PFP40746_SEARCH_VS1_HEAD", cn, ListCode("Factory"), txt_cdFactory.Code, ListCode("LineProd"))

            Dim cdLineProdName As String
            Dim cdLineProd As String

            If GetDsRc(DS1) = 0 Then vS1.ActiveSheet.RowCount = 0 : Exit Function

            vS1.ActiveSheet.RowCount = GetDsRc(DS1)

            vS1.ActiveSheet.ColumnCount = 101

            For i = 0 To 100
                setDataCH(vS1, i, 0, (i + 1).ToString("00"))
            Next

            For i = 0 To GetDsRc(DS1) - 1
                cdLineProdName = GetDsData(DS1, i, "cdLineProdName")
                setDataRH(vS1, 0, i, cdLineProdName)

                cdLineProd = GetDsData(DS1, i, "cdLineProd")
                setCellRH(vS1, 0, i, cdLineProd)

                vS1.ActiveSheet.Rows(i).Tag = cdLineProd
                vS1.ActiveSheet.Rows(i).Height = 120

            Next

            If chk_FullScreen.Checked Then

                DS2 = PrcDS("USP_PFP40746_SEARCH_VS1_F1_NEWCONCEPT_FULL", cn, txt_cdFactory.Code, txt_cdMainProcess.Code, txt_cdSeason.Code)
                SPR_PRO(vS1, DS2, "USP_PFP40746_SEARCH_VS1_F1_NEWCONCEPT_FULL", "vS1")

                vS1.ActiveSheet.AutoFilterMode = AutoFilterMode.EnhancedContextMenu
                vS1.ActiveSheet.Columns(getColumIndex(vS1, "CheckComplete_Sel")).AllowAutoFilter = True
                vS1.ActiveSheet.Columns(getColumIndex(vS1, "CheckComplete_Sel")).AllowAutoSort = True
                vS1.ActiveSheet.Columns(getColumIndex(vS1, "CheckComplete_Sel")).ShowSortIndicator = True

                Dim int_ycol As Integer = getColumIndex(vS1, "CheckComplete")
                Dim int_ycolfix As Integer = getColumIndex(vS1, "CheckComplete_sel")

                For int_yrow As Integer = 0 To vS1.ActiveSheet.RowCount - 1
                    SPR_BACKCOLORCELL(vS1, FUNCTION_DYEING_PLAN_BACK(getData(vS1, int_ycol, int_yrow)), int_ycolfix, int_yrow)
                    SPR_FORECOLORCELL(vS1, FUNCTION_DYEING_PLAN_FORE(getData(vS1, int_ycol, int_yrow)), int_ycolfix, int_yrow)
                Next

            Else
                DS2 = PrcDS("USP_PFP40746_SEARCH_VS1_F1_NEWCONCEPT", cn, txt_cdFactory.Code, txt_cdMainProcess.Code, txt_cdSeason.Code)

                Dim Xcol As Integer
                Dim Xrow As Integer

                Dim SRow As Integer
                Dim ERow As Integer

                For i = 0 To GetDsRc(DS2) - 1
                    Xcol = CIntp(GetDsData(DS2, i, "KEY_LineTno")) - 1
                    Xrow = getRowIndex(vS1, GetDsData(DS2, i, "KEY_cdLineProd"))

                    SRow = Xrow

                    If Xcol < 0 Or Xrow < 0 Then GoTo next1
                    If GetDsData(DS2, i, "Sealno").Trim <> "" Then
                        setData(vS1, Xcol, Xrow, GetDsData(DS2, i, "Sealno") & vbLf &
                                    "B: " & FormatNumber(GetDsData(DS2, i, "QtyPlan"), 0) & "/ BP: " & FormatNumber(GetDsData(DS2, i, "QtyProduction"), 0) & "/BD: " & FormatNumber(GetDsData(DS2, i, "QtyProd"), 0) & vbLf & GetDsData(DS2, i, "Line") & vbLf & GetDsData(DS2, i, "Article") & vbLf &
                                       GetDsData(DS2, i, "ColorName"))

                        If SRow <> ERow Or SRow = 0 And i = 0 Then
                            setDataRH(vS1, 0, SRow, getDataRH(vS1, 0, Xrow) & vbLf & "T: " & FormatNumber(GetDsData(DS2, i, "QtyTargetDay"), 0) & vbLf & "A: " & FormatNumber(GetDsData(DS2, i, "QtyDateProd"), 0))
                        End If

                        SPR_BACKCOLORCELL(vS1, FUNCTION_DYEING_PLAN_BACK(GetDsData(DS2, i, "CheckComplete")), Xcol, Xrow)
                        SPR_FORECOLORCELL(vS1, FUNCTION_DYEING_PLAN_FORE(GetDsData(DS2, i, "CheckComplete")), Xcol, Xrow)

                    End If


next1:
                    ERow = Xrow
                Next

                For i = 0 To 100
                    vS1.ActiveSheet.Columns(i).Width = 220
                    vS1.ActiveSheet.Columns(i).VerticalAlignment = CellVerticalAlignment.Center
                    vS1.ActiveSheet.Columns(i).HorizontalAlignment = CellHorizontalAlignment.Left
                    vS1.ActiveSheet.Columns(i).Font = New Font("Tahoma", 12, FontStyle.Bold)
                    vS1.ActiveSheet.RowHeader.Columns(0).Width = vS1.ActiveSheet.RowHeader.Columns(0).GetPreferredWidth
                Next

                SizeChk = True

                Dim nc As New FarPoint.Win.Spread.CellType.TextCellType
                nc.Multiline = True
                vS1.ActiveSheet.RowHeader.Columns(0).CellType = nc
                vS1.ActiveSheet.RowHeader.Columns(0).Width = 50
                vS1.ActiveSheet.RowHeader.Columns(0).Font = New Font("Tahoma", 9, FontStyle.Bold)

            End If

        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")

        Finally
            If rd_c IsNot Nothing Then
                If rd_c.IsClosed = False Then
                    rd_c.Close()
                End If
            End If
        End Try

    End Function

    Private Function DATA_SEARCH_VS2(Optional ByVal xsort As String = "1") As Boolean
        Dim cdFactory As String
        Dim cdMainProcess As String
        Dim cdLineProd As String
        Dim LineTno As String

        DATA_SEARCH_VS2 = False

        If chk_FullScreen.Checked Then
            cdFactory = txt_cdFactory.Code
            cdMainProcess = txt_cdMainProcess.Code
            cdLineProd = getData(vS1, getColumIndex(vS1, "Key_cdLineProd"), vS1.ActiveSheet.ActiveRowIndex)
            LineTno = getData(vS1, getColumIndex(vS1, "Key_LineTno"), vS1.ActiveSheet.ActiveRowIndex)
        Else
            cdFactory = txt_cdFactory.Code
            cdMainProcess = txt_cdMainProcess.Code
            cdLineProd = getCellRH(vS1, 0, vS1.ActiveSheet.ActiveRowIndex)
            LineTno = vS1.ActiveSheet.ColumnHeader.Cells(0, vS1.ActiveSheet.ActiveColumnIndex).Value
        End If


        If cdLineProd = "" Then Exit Function
        vS2.Enabled = False

        DS1 = PrcDS("USP_PFP40746_SEARCH_VS2_NEWCONCEPT", cn, cdFactory,
                                                    cdMainProcess,
                                                    cdLineProd,
                                                    LineTno)

        If GetDsRc(DS1) = 0 Then
            vS2.Enabled = True
            Exit Function
        End If

        SPR_SET(vS2, , , , OperationMode.SingleSelect)
        SPR_PRO(vS2, DS1, "USP_PFP40746_SEARCH_VS2_NEWCONCEPT", "vs2")

        If READ_PFK4073(cdFactory, cdMainProcess, cdLineProd, LineTno) Then
            Call VsSizeRangeNew(vS2, "USP_VS_SIZERANGE_JOBBASE", "SizeQTY01", D4073.JobCard)
        End If

        vS2.ActiveSheet.RowCount += 1
        SPR_CHECKBOXROW(vS2, 1)

        vS2.ActiveSheet.Rows(vS2.ActiveSheet.RowCount - 1).Locked = False

        DATA_SEARCH_VS2 = True

        vS2.Enabled = True
    End Function

    Private Function DATA_SEARCH_VS3(Optional ByVal xsort As String = "1") As Boolean
        Dim cdFactory As String
        Dim cdMainProcess As String
        Dim cdLineProd As String
        Dim LineTno As String
        Dim ProdDate As String

        DATA_SEARCH_VS3 = False


        If chk_FullScreen.Checked Then
            cdFactory = txt_cdFactory.Code
            cdMainProcess = txt_cdMainProcess.Code
            cdLineProd = getData(vS1, getColumIndex(vS1, "Key_cdLineProd"), vS1.ActiveSheet.ActiveRowIndex)
            LineTno = getData(vS1, getColumIndex(vS1, "Key_LineTno"), vS1.ActiveSheet.ActiveRowIndex)
            ProdDate = txt_DatePlan.Data
        Else
            cdFactory = txt_cdFactory.Code
            cdMainProcess = txt_cdMainProcess.Code
            cdLineProd = getCellRH(vS1, 0, vS1.ActiveSheet.ActiveRowIndex)
            LineTno = vS1.ActiveSheet.ColumnHeader.Cells(0, vS1.ActiveSheet.ActiveColumnIndex).Value
            ProdDate = txt_DatePlan.Data

        End If

        If cdLineProd = "" Then Exit Function
        vS3.Enabled = False

        DS1 = PrcDS("USP_PFP40746_SEARCH_vS3", cn, cdFactory,
                                                    cdMainProcess,
                                                    cdLineProd,
                                                    LineTno,
                                                    ProdDate)

        If GetDsRc(DS1) = 0 Then
            vS3.Enabled = True
            Exit Function
        End If

        SPR_SET(vS3, , , , OperationMode.SingleSelect)
        SPR_PRO(vS3, DS1, "USP_PFP40746_SEARCH_vS3", "vS3")

        DATA_SEARCH_VS3 = True
        vS3.Enabled = True
    End Function


    Private Function LINE_MOVE_DISPLAY01(spr As FarPoint.Win.Spread.FpSpread, Xcol As Integer, Xrow As Integer,
                                       cdLineProd As String) As Boolean

        LINE_MOVE_DISPLAY01 = False
        Dim LineTno As String

        LineTno = (Xcol + 1).ToString("00")

        DS2 = PrcDS("USP_PFP40746_SEARCH_LINE_TNO_NEWCONCEPT", cn, txt_cdFactory.Code,
                                                        txt_cdMainProcess.Code,
                                                        cdLineProd,
                                                        LineTno)

        If GetDsRc(DS2) = 0 Then
            setData(vS1, Xcol, Xrow, "")
            SPR_BACKCOLORCELL(vS1, Color.Empty, Xcol, Xrow)
            Exit Function
        End If

        If GetDsData(DS2, 0, "SealNo").Trim <> "" Then


            setData(vS1, Xcol, Xrow, GetDsData(DS2, 0, "Sealno") & vbLf &
                               "Plan: " & FormatNumber(GetDsData(DS2, 0, "QtyPlan"), 0) & "/ Prod: " & FormatNumber(GetDsData(DS2, 0, "QtyProd"), 0) & vbLf & GetDsData(DS2, 0, "Line") & vbLf & GetDsData(DS2, 0, "Article") & vbLf &
                                  GetDsData(DS2, 0, "ColorName"))

            SPR_BACKCOLORCELL(vS1, FUNCTION_DYEING_PLAN_BACK(GetDsData(DS2, 0, "CheckComplete")), Xcol, Xrow)
            SPR_FORECOLORCELL(vS1, FUNCTION_DYEING_PLAN_FORE(GetDsData(DS2, 0, "CheckComplete")), Xcol, Xrow)

        End If

        LINE_MOVE_DISPLAY01 = True
        vS1.Select()
        vS1.Focus()


    End Function

    Private Sub Call_Data()

        vS2.ActiveSheet.RowCount = 0
        vS3.ActiveSheet.RowCount = 0
        Call DATA_SEARCH_VS2()
        Call DATA_SEARCH_VS3()
    End Sub

    Private Sub DATA_SEARCH_ALL()

        vS2.ActiveSheet.RowCount = 0
        vS3.ActiveSheet.RowCount = 0

        Call DATA_SEARCH_VS2()
        Call DATA_SEARCH_VS3()
    End Sub

    Public Function DATA_SEARCH_HEAD_vs_Season() As Boolean
        DATA_SEARCH_HEAD_vs_Season = False

        Try
            DS1 = PrcDS("USP_PFP40746_SEARCH_VS_SEASON", cn, ListCode("Season"))
            SPR_PRO_NEW(vs_Season, DS1, "USP_PFP40746_SEARCH_VS_SEASON", "vs_Season")

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
            DS1 = PrcDS("USP_PFP40746_SEARCH_vS_Cus", cn, CustomerCode, cdSeason)
            SPR_PRO_NEW(vS_Cus, DS1, "USP_PFP40746_SEARCH_vS_Cus", "vS_Cus")

            'SplitContainer1.SplitterDistance = SPR_SHEETWIDHT(vS_Cus) + cSprWidthSize

            DS1 = Nothing
            DATA_SEARCH_HEAD_vS_Cus = True

        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Function

    Public Function DATA_SEARCH_HEAD_vS_Line() As Boolean
        DATA_SEARCH_HEAD_vS_Line = False
        Dim cdSeason As String
        Dim CustomerCode As String

        cdSeason = getData(vs_Season, getColumIndex(vs_Season, "BasicCode"), vs_Season.ActiveSheet.ActiveRowIndex)
        CustomerCode = getData(vS_Cus, getColumIndex(vS_Cus, "CustomerCode"), vS_Cus.ActiveSheet.ActiveRowIndex)


        Try
            DS1 = PrcDS("USP_PFP40746_SEARCH_vS_Line", cn, cdSeason, CustomerCode)
            SPR_PRO_NEW(vS_Line, DS1, "USP_PFP40746_SEARCH_vS_Line", "vS_Line")

            'SplitContainer2.SplitterDistance = SPR_SHEETWIDHT(vS_Line) + cSprWidthSize

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
        Dim Line As String

        cdSeason = getData(vs_Season, getColumIndex(vs_Season, "BasicCode"), vs_Season.ActiveSheet.ActiveRowIndex)
        CustomerCode = getData(vS_Cus, getColumIndex(vS_Cus, "CustomerCode"), vS_Cus.ActiveSheet.ActiveRowIndex)
        Line = getData(vS_Line, getColumIndex(vS_Line, "Line"), vS_Line.ActiveSheet.ActiveRowIndex)

        Try
            DS1 = PrcDS("USP_PFP40746_SEARCH_vs_Job", cn, cdSeason, CustomerCode, Line)
            SPR_PRO_NEW(vs_Job, DS1, "USP_PFP40746_SEARCH_vs_Job", "vs_Job")
            'SplitContainer2.SplitterDistance = SPR_SHEETWIDHT(vs_Job) + cSprWidthSize

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
        Dim JobCard As String

        JobCard = getData(sender, getColumIndex(sender, "JobCard"), e.Row)

        If READ_PFK4010(JobCard) Then
            Dim cdFactory As String
            Dim cdLineProd As String
            Dim LineTno As String

            cdFactory = txt_cdFactory.Code

            cdLineProd = getCellRH(vS1, 0, vS1.ActiveSheet.ActiveRowIndex)

            Dim StrMsgXX As String = MsgBox("Matching " & D4010.SlNoD & " With Line " & cdLineProd & " ?", vbYesNo)
            If StrMsgXX <> vbYes Then Exit Sub

            Dim xRow As Integer
            Dim xCol As Integer

            xRow = vS1.ActiveSheet.ActiveRowIndex
            xCol = vS1.ActiveSheet.ActiveColumnIndex

            cdFactory = txt_cdFactory.Code

            cdLineProd = getCellRH(vS1, 0, vS1.ActiveSheet.ActiveRowIndex)

            Dim cdMainProcess As String
            cdMainProcess = txt_cdMainProcess.Code
            LineTno = vS1.ActiveSheet.ColumnHeader.Cells(0, vS1.ActiveSheet.ActiveColumnIndex).Value

            Call READ_PFK1312(D4010.WorkOrder, D4010.WorkOrderSeq)
            Call READ_PFK7106(D1312.ShoesCode)

            txt_cdSeason.Code = D7106.cdSeason

            If READ_PFK4073(cdFactory, cdMainProcess, cdLineProd, LineTno) = False Then
                Dim StrMsg As String = D4010.SlNoD

                StrMsg = StrMsg.ToUpper

                If chk_Size.Checked = False Then
                    PrcExeNoError("USP_PFK4073_INSERT_AUTO_SlNoD_NEWCONCEPT", cn, txt_cdSeason.Code, cdFactory, cdMainProcess, cdLineProd, StrMsg)
                   
                    Call LINE_MOVE_DISPLAY01(vS1, vS1.ActiveSheet.ActiveColumnIndex, vS1.ActiveSheet.ActiveRowIndex, cdLineProd)

                    Me.Show()
                    Application.DoEvents()
                    vS1.Select()
                    vS1.ActiveSheet.ActiveRowIndex = xRow
                    vS1.ActiveSheet.ActiveColumnIndex = xCol

                ElseIf chk_Size.Checked = True Then
                    LineTno = PrcExeNoError_Value("USP_PFK4073_INSERT_AUTO_SlNoD_SizeCheck_NEWCONCEPT", cn, txt_cdSeason.Code, cdFactory, cdMainProcess, cdLineProd, StrMsg)
                 
                    If LineTno = "" Then Exit Sub

                    vS1.ActiveSheet.ActiveColumnIndex = CIntp(LineTno) - 1

                    If ISUD4073C_NC.Link_ISUD4073C(1, cdFactory, cdMainProcess, cdLineProd, LineTno, "PFP40730") Then


                        Me.Show()
                        Application.DoEvents()
                        vS1.Select()
                        vS1.ActiveSheet.ActiveRowIndex = xRow
                        vS1.ActiveSheet.ActiveColumnIndex = xCol

                    End If

                    Call LINE_MOVE_DISPLAY01(vS1, vS1.ActiveSheet.ActiveColumnIndex, vS1.ActiveSheet.ActiveRowIndex, cdLineProd)

                End If


            End If


        End If
    End Sub


#End Region

#Region "Function"
    Private Function Date_Check() As Boolean
        Date_Check = False
        If txt_DatePlan.Data = System_Date_8() Then
            Date_Check = True
        End If
    End Function

    Private Function CustomerPurchasing_CHK() As String
        CustomerPurchasing_CHK = "1"
        Return CustomerPurchasing_CHK
    End Function

    Private Function GetLineTno(cdFactory As String, cdMainProcess As String, cdLineProd As String) As String
        GetLineTno = ""

        Try
            SQL = "SELECT TOP 1     K4073_LineTno "
            SQL = SQL & "   FROM        PFK4073 "
            SQL = SQL & "   WHERE       K4073_cdFactory    =   '" & cdFactory & "' "
            SQL = SQL & "       AND     K4073_cdMainProcess       =   '" & cdMainProcess & "' "
            SQL = SQL & "       AND     K4073_cdLineProd       =   '" & cdLineProd & "' "
            SQL = SQL & "       AND     K4073_CheckComplete  <>  '2'"
            SQL = SQL & "   ORDER	BY	K4073_LineTno "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then
                GetLineTno = "00"
            Else
                GetLineTno = rd!K4073_LineTno
            End If

            rd.Close()
        Catch ex As Exception
            MsgBoxP("GetLineTno")
        End Try
    End Function


    Private Function KEY_TSEQ(cdFactory As String, cdLineProd As String) As String
        KEY_TSEQ = ""
        Dim YRNO As Integer
        YRNO = Mid(System_Date_8(), 3, 4)

        Try
            SQL = "SELECT MAX(CAST(K4073_LineTno AS DECIMAL)) AS MAX_MCODE FROM PFK4073 "
            SQL = SQL & " WHERE K4073_cdFactory = '" & cdFactory & "' "
            SQL = SQL & " AND K4073_cdLineProd = '" & cdLineProd & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                rd.Close()
                Exit Function
            Else
                KEY_TSEQ = Format(CInt(rd!MAX_MCODE), "00")
            End If

            rd.Close()
        Catch ex As Exception
            Call MsgBoxP("35", "KEY_TSEQ")
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

    Private Sub txt_GNAME_KeyDown(sender As Object, e As KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.Enter : cmd_SEARCH.Focus()
        End Select
    End Sub

    Private Sub vS1_KeyDown(sender As Object, e As KeyEventArgs) Handles vS1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_cdSeason.Code = "" Then MsgBoxP("Season Pls!", vbInformation) : Setfocus(txt_cdSeason) : Exit Sub

            Dim cdFactory As String
            Dim cdLineProd As String
            Dim LineTno As String
            Dim xRow As Integer
            Dim xCol As Integer

            xRow = vS1.ActiveSheet.ActiveRowIndex
            xCol = vS1.ActiveSheet.ActiveColumnIndex

            cdFactory = txt_cdFactory.Code

            cdLineProd = getCellRH(vS1, 0, vS1.ActiveSheet.ActiveRowIndex)

            Dim cdMainProcess As String
            cdMainProcess = txt_cdMainProcess.Code
            LineTno = vS1.ActiveSheet.ColumnHeader.Cells(0, vS1.ActiveSheet.ActiveColumnIndex).Value

            If READ_PFK4073(cdFactory, cdMainProcess, cdLineProd, LineTno) = False Then
                Dim StrMsg As String = InputBox("SealNo Input! (Nhập số seal)")

                StrMsg = StrMsg.ToUpper

                If READ_PFK4010_SlnoD(StrMsg) And FormatCut(StrMsg) <> "" Then
                    If chk_Size.Checked = False Then
                        PrcExeNoError("USP_PFK4073_INSERT_AUTO_SlNoD_NEWCONCEPT", cn, txt_cdSeason.Code, cdFactory, cdMainProcess, cdLineProd, StrMsg)


                        Call LINE_MOVE_DISPLAY01(vS1, vS1.ActiveSheet.ActiveColumnIndex, vS1.ActiveSheet.ActiveRowIndex, cdLineProd)

                        Me.Show()
                        Application.DoEvents()
                        vS1.Select()
                        vS1.ActiveSheet.ActiveRowIndex = xRow
                        vS1.ActiveSheet.ActiveColumnIndex = xCol

                    ElseIf chk_Size.Checked = True Then
                        LineTno = PrcExeNoError_Value("USP_PFK4073_INSERT_AUTO_SlNoD_SizeCheck_NEWCONCEPT", cn, txt_cdSeason.Code, cdFactory, cdMainProcess, cdLineProd, StrMsg)
                        
                        If LineTno = "" Then Exit Sub

                        vS1.ActiveSheet.ActiveColumnIndex = CIntp(LineTno) - 1

                        If ISUD4073C_NC.Link_ISUD4073C(1, cdFactory, cdMainProcess, cdLineProd, LineTno, "PFP40746") Then

                            Me.Show()
                            Application.DoEvents()
                            vS1.Select()
                            vS1.ActiveSheet.ActiveRowIndex = xRow
                            vS1.ActiveSheet.ActiveColumnIndex = xCol

                        End If

                        Call LINE_MOVE_DISPLAY01(vS1, vS1.ActiveSheet.ActiveColumnIndex, vS1.ActiveSheet.ActiveRowIndex, cdLineProd)

                    End If


                Else
                    MsgBoxP("Wrong Sealno ! (Sai số seal)", vbInformation)

                End If
            End If

        End If
    End Sub


    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        Dim cdMachineType As String

        If chk_Total.Checked = False Then
            If READ_PFK7171(ListCode("MainProcess"), txt_cdMainProcess.Code) Then
                If READ_PFK7171(ListCode("MachineType"), D7171.CheckName6) Then
                    cdMachineType = D7171.BasicCode
                End If
            End If

            Call DATA_SEARCH01(cdMachineType)
        Else
            Call DATA_SEARCH_HEAD_vs_Season()
            Call DATA_SEARCH_HEAD_vS_Cus()
            Call DATA_SEARCH_HEAD_vS_Line()
            Call DATA_SEARCH_HEAD_vs_Job()
            If READ_PFK7171(ListCode("MainProcess"), txt_cdMainProcess.Code) Then
                If READ_PFK7171(ListCode("MachineType"), D7171.CheckName6) Then
                    cdMachineType = D7171.BasicCode
                End If
            End If

            Call DATA_SEARCH01(cdMachineType)
        End If
    End Sub

    Private Sub Cms_1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles Cms_1.ItemClicked
        If Cms_1.Items(0).Selected = True Then
            Cms_1.Hide()

            Dim cdFactory As String
            Dim cdMainProcess As String
            Dim cdLineProd As String
            Dim LineTno As String

            If chk_FullScreen.Checked Then
                cdFactory = txt_cdFactory.Code
                cdMainProcess = txt_cdMainProcess.Code
                cdLineProd = getData(vS1, getColumIndex(vS1, "Key_cdLineProd"), vS1.ActiveSheet.ActiveRowIndex)
                LineTno = getData(vS1, getColumIndex(vS1, "Key_LineTno"), vS1.ActiveSheet.ActiveRowIndex)
            Else
                cdFactory = txt_cdFactory.Code
                cdMainProcess = txt_cdMainProcess.Code
                cdLineProd = getCellRH(vS1, 0, vS1.ActiveSheet.ActiveRowIndex)
                LineTno = vS1.ActiveSheet.ColumnHeader.Cells(0, vS1.ActiveSheet.ActiveColumnIndex).Value
            End If


            If cdFactory = "" Or cdMainProcess = "" Or cdLineProd = "" Then Exit Sub

            If ISUD4073P.Link_ISUD4073P(5, cdFactory, cdMainProcess, cdLineProd, LineTno, Me.Name) = False Then Exit Sub

        End If

    End Sub

    Private Sub Cms_2_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles Cms_2.ItemClicked
        If Cms_2.Items(0).Selected = True Then
            Cms_2.Hide()
            MAIN_JOB01() '0
        End If
        If Cms_2.Items(1).Selected = True Then
            Cms_2.Hide()
            MAIN_JOB02() '1
        End If
    End Sub

    Private Sub btn_Closing_Click(sender As Object, e As EventArgs)
        If MsgBoxPPW("Please input password", const_pwPrintUpdate) = False Then Exit Sub

        Try
            If PrcExe("USP_PFP40730_ROW_NUMBER_CLOSSING", cn, txt_cdFactory.Code, txt_cdMainProcess.Code, Pub.DAT) = True Then

                MsgBoxP("Closing Successfully!", vbInformation)

                txt_DatePlan.Data = System_Date_8()

                Call DATA_SEARCH01(txt_cdMainProcess.Code)

            Else
                MsgBoxP("Closing Unsuccessfully! Pleace check!")

            End If
        Catch ex As Exception
            MsgBoxP("Closing Unsuccessfully!")
        End Try

    End Sub

    Private Sub chk_Total_CheckedChanged(sender As Object, e As EventArgs) Handles chk_Total.CheckedChanged
        Psc_1.Panel1Collapsed = Not chk_Total.Checked
        Psc_2.Panel1Collapsed = Not chk_Total.Checked
        Psc_3.Panel1Collapsed = Not chk_Total.Checked

        Psc_0.Panel2Collapsed = chk_Total.Checked

    End Sub
#End Region

    Private Sub chk_FullScreen_CheckedChanged(sender As Object, e As EventArgs) Handles chk_FullScreen.CheckedChanged
        If chk_FullScreen.Checked = False Then
            vS1.ContextMenuStrip = Cms_2
            cmd_SEARCH.PerformClick()

        ElseIf chk_FullScreen.Checked = True Then
            vS1.ContextMenuStrip = Cms_1

            cmd_SEARCH.PerformClick()
        End If
    End Sub


End Class