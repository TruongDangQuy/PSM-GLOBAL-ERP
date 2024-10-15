Public Class PFP40735
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
                     "LINE PLANNING CONTROL - SEARCH " & "(F8)",
                     "LINE PLANNING CONTROL - UPDATE " & "(F9)",
                     "LINE PLANNING CONTROL - DELETE " & "(F10)",
                      "-",
                     "LINE PLANNING STATUS CONTROL " & "(F11)")

        Call Cms_additem(Cms_2,
                     "PACKING INPUT CONTROL - INSERT " & "(F7)",
                     "PACKING INPUT CONTROL - SEARCH " & "(F8)",
                     "PACKING INPUT CONTROL - UPDATE " & "(F9)",
                     "PACKING INPUT CONTROL - DELETE " & "(F10)",
                     "PACKING INPUT CONTROL - NO MATCHING " & "(F11)",
                     "PACKING INPUT CONTROL - AUTO " & "(F12)")


        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False)

        Me.KeyPreview = True
        Call FORM_INIT()
        Call DATA_INIT()

    End Sub
    Private Sub PFP40735_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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
        txt_DatePlan.Data = System_Date_8()
        txt_cdMainProcess.Code = "080"

        If READ_PFK7171(ListCode("MainProcess"), txt_cdMainProcess.Code) Then
            txt_cdMainProcess.Data = D7171.BasicName
        End If

    End Sub

    Private Sub DATA_INIT()
        Psc_1.Panel1Collapsed = True
        Psc_2.Panel1Collapsed = True
        Psc_3.Panel1Collapsed = True

        Psc_0.Panel2Collapsed = False
    End Sub

#End Region

#Region "Link"

    Private Sub MAIN_JOB01()
        Dim cdFactory As String
        Dim cdLineProd As String
        Dim LineTno As String

        cdFactory = txt_cdFactory.Code

        cdLineProd = getCellRH(vS1, 0, vS1.ActiveSheet.ActiveRowIndex)

        Dim cdMainProcess As String
        cdMainProcess = txt_cdMainProcess.Code
        LineTno = vS1.ActiveSheet.ColumnHeader.Cells(0, vS1.ActiveSheet.ActiveColumnIndex).Value

        If cdFactory = "" Or cdLineProd = "" Or LineTno = "" Then Exit Sub


    End Sub

    Private Sub MAIN_JOB02()
        Dim cdFactory As String
        Dim cdLineProd As String
        Dim LineTno As String

        cdFactory = txt_cdFactory.Code

        cdLineProd = getCellRH(vS1, 0, vS1.ActiveSheet.ActiveRowIndex)

        Dim cdMainProcess As String
        cdMainProcess = txt_cdMainProcess.Code
        LineTno = vS1.ActiveSheet.ColumnHeader.Cells(0, vS1.ActiveSheet.ActiveColumnIndex).Value

        If cdFactory = "" Or cdLineProd = "" Or LineTno = "" Then Exit Sub


    End Sub


    Private Sub MAIN_JOB03()
        Dim cdFactory As String
        Dim cdLineProd As String
        Dim LineTno As String

        cdFactory = txt_cdFactory.Code

        cdLineProd = getCellRH(vS1, 0, vS1.ActiveSheet.ActiveRowIndex)

        Dim cdMainProcess As String
        cdMainProcess = txt_cdMainProcess.Code
        LineTno = vS1.ActiveSheet.ColumnHeader.Cells(0, vS1.ActiveSheet.ActiveColumnIndex).Value

        If cdFactory = "" Or cdLineProd = "" Or LineTno = "" Then Exit Sub

    End Sub

    Private Sub MAIN_JOB04()
        Dim cdFactory As String
        Dim cdLineProd As String
        Dim LineTno As String

        cdFactory = txt_cdFactory.Code

        cdLineProd = getCellRH(vS1, 0, vS1.ActiveSheet.ActiveRowIndex)

        Dim cdMainProcess As String
        cdMainProcess = txt_cdMainProcess.Code
        LineTno = vS1.ActiveSheet.ColumnHeader.Cells(0, vS1.ActiveSheet.ActiveColumnIndex).Value

        If cdFactory = "" Or cdLineProd = "" Or LineTno = "" Then Exit Sub


    End Sub

    Private Sub MAIN_JOB05()
        Dim cdFactory As String
        Dim cdLineProd As String
        Dim LineTno As String

        cdFactory = txt_cdFactory.Code

        cdLineProd = getCellRH(vS1, 0, vS1.ActiveSheet.ActiveRowIndex)

        Dim cdMainProcess As String
        cdMainProcess = txt_cdMainProcess.Code
        LineTno = vS1.ActiveSheet.ColumnHeader.Cells(0, vS1.ActiveSheet.ActiveColumnIndex).Value

        If cdFactory = "" Or cdLineProd = "" Or LineTno = "" Then Exit Sub

    End Sub

    Private Sub MAIN_JOB06()
        If MsgBoxPPW("Please type the password to print barcode!", const_pwPO) = False Then Exit Sub

        Dim Starting As Object
        Starting = New DevExpress.Utils.WaitDialogForm("Loading data...", "PSM")

        Try
            Call PrcExeNoError("USP_PFK4015_GENERATE_BARCODE_ALL_JOB", cn)
        Catch ex As Exception

        Finally
            Starting.close()
        End Try

    End Sub

    Private Sub MAIN_JOB07()
        If Date_Check() = False Then Exit Sub

        Dim cdFactory As String
        Dim cdLineProd As String
        Dim LineTno As String
        Dim cdMainProcess As String
        cdMainProcess = txt_cdMainProcess.Code

        cdFactory = txt_cdFactory.Code
        cdLineProd = getCellRH(vS1, 0, vS1.ActiveSheet.ActiveRowIndex)
        LineTno = vS1.ActiveSheet.ColumnHeader.Cells(0, vS1.ActiveSheet.ActiveColumnIndex).Value

        If cdFactory = "" Or cdLineProd = "" Or LineTno = "" Then Exit Sub

        'Later    If ISUD8562A.Link_ISUD8562A(2, cdFactory,  cdLineProd, LineTno, Me.Name) = False Then Exit Sub

        Call LINE_MOVE_DISPLAY01(vS1, vS1.ActiveSheet.ActiveColumnIndex, vS1.ActiveSheet.ActiveRowIndex, cdLineProd)
    End Sub

    Private Sub MAIN_JOB08()
        If Date_Check() = False Then Exit Sub

        Dim cdFactory As String
        Dim cdLineProd As String
        Dim LineTno As String
        Dim cdMainProcess As String
        cdMainProcess = txt_cdMainProcess.Code

        cdFactory = txt_cdFactory.Code
        cdLineProd = getCellRH(vS1, 0, vS1.ActiveSheet.ActiveRowIndex)
        LineTno = vS1.ActiveSheet.ColumnHeader.Cells(0, vS1.ActiveSheet.ActiveColumnIndex).Value

        If cdFactory = "" Or cdLineProd = "" Or LineTno = "" Then Exit Sub


        'Later    If ISUD8562A.Link_ISUD8562A(3, cdFactory,  cdLineProd, LineTno, Me.Name) = False Then Exit Sub

        Call LINE_MOVE_DISPLAY01(vS1, vS1.ActiveSheet.ActiveColumnIndex, vS1.ActiveSheet.ActiveRowIndex, cdLineProd)
    End Sub

    Private Sub MAIN_JOB09()
        If Date_Check() = False Then Exit Sub

        Dim cdFactory As String
        Dim cdLineProd As String
        Dim LineTno As String
        Dim cdMainProcess As String
        cdMainProcess = txt_cdMainProcess.Code

        cdFactory = txt_cdFactory.Code
        cdLineProd = getCellRH(vS1, 0, vS1.ActiveSheet.ActiveRowIndex)
        LineTno = vS1.ActiveSheet.ColumnHeader.Cells(0, vS1.ActiveSheet.ActiveColumnIndex).Value

        If cdFactory = "" Or cdLineProd = "" Or LineTno = "" Then Exit Sub


        'Later    If ISUD8562A.Link_ISUD8562A(4, cdFactory,  cdLineProd, LineTno, Me.Name) = False Then Exit Sub

        Call LINE_MOVE_DISPLAY01(vS1, vS1.ActiveSheet.ActiveColumnIndex, vS1.ActiveSheet.ActiveRowIndex, cdLineProd)
    End Sub

    Private Sub MAIN_JOB11()
        If Date_Check() = False Then Exit Sub

        Dim cdFactory As String
        Dim cdLineProd As String
        Dim LineTno As String
        Dim cdMainProcess As String
        cdMainProcess = txt_cdMainProcess.Code

        cdFactory = txt_cdFactory.Code
        cdLineProd = getCellRH(vS1, 0, vS1.ActiveSheet.ActiveRowIndex)
        LineTno = vS1.ActiveSheet.ColumnHeader.Cells(0, vS1.ActiveSheet.ActiveColumnIndex).Value

        If cdFactory = "" Or cdLineProd = "" Or LineTno = "" Then Exit Sub


        'Later   If ISUD8563A.Link_ISUD8563A(1, cdFactory,  cdLineProd, LineTno, Me.Name) = False Then Exit Sub

        Call LINE_MOVE_DISPLAY01(vS1, vS1.ActiveSheet.ActiveColumnIndex, vS1.ActiveSheet.ActiveRowIndex, cdLineProd)
    End Sub

    Private Sub MAIN_JOB12()
        If Date_Check() = False Then Exit Sub

        Dim cdFactory As String
        Dim cdLineProd As String
        Dim LineTno As String
        Dim cdMainProcess As String
        cdMainProcess = txt_cdMainProcess.Code

        cdFactory = txt_cdFactory.Code
        cdLineProd = getCellRH(vS1, 0, vS1.ActiveSheet.ActiveRowIndex)
        LineTno = vS1.ActiveSheet.ColumnHeader.Cells(0, vS1.ActiveSheet.ActiveColumnIndex).Value

        If cdFactory = "" Or cdLineProd = "" Or LineTno = "" Then Exit Sub

        'Later  If ISUD8563A.Link_ISUD8563A(2, cdFactory,  cdLineProd, LineTno, Me.Name) = False Then Exit Sub

        Call LINE_MOVE_DISPLAY01(vS1, vS1.ActiveSheet.ActiveColumnIndex, vS1.ActiveSheet.ActiveRowIndex, cdLineProd)
    End Sub

    Private Sub MAIN_JOB13()
        If Date_Check() = False Then Exit Sub

        Dim cdFactory As String
        Dim cdLineProd As String
        Dim LineTno As String
        Dim cdMainProcess As String
        cdMainProcess = txt_cdMainProcess.Code

        cdFactory = txt_cdFactory.Code
        cdLineProd = getCellRH(vS1, 0, vS1.ActiveSheet.ActiveRowIndex)
        LineTno = vS1.ActiveSheet.ColumnHeader.Cells(0, vS1.ActiveSheet.ActiveColumnIndex).Value

        If cdFactory = "" Or cdLineProd = "" Or LineTno = "" Then Exit Sub

        'Later   If ISUD8563A.Link_ISUD8563A(3, cdFactory,  cdLineProd, LineTno, Me.Name) = False Then Exit Sub

        Call LINE_MOVE_DISPLAY01(vS1, vS1.ActiveSheet.ActiveColumnIndex, vS1.ActiveSheet.ActiveRowIndex, cdLineProd)
    End Sub

    Private Sub MAIN_JOB14()
        If Date_Check() = False Then Exit Sub

        Dim cdFactory As String
        Dim cdLineProd As String
        Dim LineTno As String
        Dim cdMainProcess As String
        cdMainProcess = txt_cdMainProcess.Code

        cdFactory = txt_cdFactory.Code
        cdLineProd = getCellRH(vS1, 0, vS1.ActiveSheet.ActiveRowIndex)
        LineTno = vS1.ActiveSheet.ColumnHeader.Cells(0, vS1.ActiveSheet.ActiveColumnIndex).Value

        If cdFactory = "" Or cdLineProd = "" Or LineTno = "" Then Exit Sub

        'Later    If ISUD8563A.Link_ISUD8563A(4, cdFactory,  cdLineProd, LineTno, Me.Name) = False Then Exit Sub

        Call LINE_MOVE_DISPLAY01(vS1, vS1.ActiveSheet.ActiveColumnIndex, vS1.ActiveSheet.ActiveRowIndex, cdLineProd)
    End Sub


    Private Sub MAIN_JOB02_1()
        If Date_Check() = False Then Exit Sub

        Dim cdFactory As String
        Dim cdLineProd As String
        Dim LineTno As String
        Dim cdMainProcess As String
        cdMainProcess = txt_cdMainProcess.Code

        cdFactory = getData(vS2, getColumIndex(vS2, "KEY_cdFactory"), vS2.ActiveSheet.ActiveRowIndex)
        cdLineProd = getData(vS2, getColumIndex(vS2, "KEY_cdLineProd"), vS2.ActiveSheet.ActiveRowIndex)
        LineTno = getData(vS2, getColumIndex(vS2, "KEY_LineTno"), vS2.ActiveSheet.ActiveRowIndex)

        If cdFactory = "" Or cdLineProd = "" Then Exit Sub

        'Later   If ISUD4073B.Link_ISUD4073B(2, cdFactory,  cdLineProd, LineTno, Me.Name) = False Then Exit Sub

    End Sub


    Private Sub MAIN_JOB03_1()
        If Date_Check() = False Then Exit Sub

        Dim cdFactory As String
        Dim cdLineProd As String
        Dim LineTno As String

        cdFactory = getData(vS2, getColumIndex(vS2, "KEY_cdFactory"), vS2.ActiveSheet.ActiveRowIndex)
        cdLineProd = getData(vS2, getColumIndex(vS2, "KEY_cdLineProd"), vS2.ActiveSheet.ActiveRowIndex)
        LineTno = getData(vS2, getColumIndex(vS2, "KEY_LineTno"), vS2.ActiveSheet.ActiveRowIndex)

        If cdFactory = "" Or cdLineProd = "" Then Exit Sub

        'Later    If ISUD4073B.Link_ISUD4073B(3, cdFactory,  cdLineProd, LineTno, Me.Name) = False Then Exit Sub

    End Sub

    Private Sub MAIN_JOB04_1()
        Dim cdFactory As String
        Dim cdLineProd As String
        Dim LineTno As String

        cdFactory = txt_cdFactory.Code

        cdLineProd = getCellRH(vS1, 0, vS1.ActiveSheet.ActiveRowIndex)

        Dim cdMainProcess As String
        cdMainProcess = txt_cdMainProcess.Code
        LineTno = vS1.ActiveSheet.ColumnHeader.Cells(0, vS1.ActiveSheet.ActiveColumnIndex).Value

        If cdFactory = "" Or cdLineProd = "" Or LineTno = "" Then Exit Sub

       
    End Sub

    Private Sub MAIN_JOB05_1()
       Dim cdFactory As String
        Dim cdLineProd As String
        Dim LineTno As String

        cdFactory = txt_cdFactory.Code

        cdLineProd = getCellRH(vS1, 0, vS1.ActiveSheet.ActiveRowIndex)

        Dim cdMainProcess As String
        cdMainProcess = txt_cdMainProcess.Code
        LineTno = vS1.ActiveSheet.ColumnHeader.Cells(0, vS1.ActiveSheet.ActiveColumnIndex).Value

        If cdFactory = "" Or cdLineProd = "" Or LineTno = "" Then Exit Sub

    End Sub

#End Region

#Region "search"
    Private Sub DATA_SEARCH_HEAD(spr As FarPoint.Win.Spread.FpSpread, Xcol As Integer, Xrow As Integer, Value As String)
        Try
            Dim cdFactory As String
            Dim cdMainProcess As String
            Dim cdLineProd As String
            Dim CheckPlan As String

            cdFactory = txt_cdFactory.Code
            cdMainProcess = txt_cdMainProcess.Code
            cdLineProd = Value

            If Value = "" Then cdLineProd = ""

            DS2 = PrcDS("USP_PFP40735_SEARCH_HEAD", cn, cdFactory,
                                                       cdMainProcess,
                                                       cdLineProd,
                                                       "01")

            If GetDsRc(DS2) = 0 Then
                setCell(spr, Xcol, Xrow, cdLineProd)
                SPR_BACKCOLORCELL(spr, Color.Empty, Xcol, Xrow)
                Exit Sub
            End If

            CheckPlan = GetDsData(DS2, 0, "CheckPlan")
            setCell(spr, Xcol, Xrow, cdLineProd)
            SPR_BACKCOLORCELL(spr, FUNCTION_OS_PLAN(CheckPlan), Xcol, Xrow)

        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_HEAD")
        End Try
    End Sub

    Public Function DATA_SEARCH01(ProcessType As String) As Boolean
        Dim cmd As New SqlClient.SqlCommand
        Dim i As Integer
        Dim rd_c As SqlClient.SqlDataReader = Nothing

        DATA_SEARCH01 = False

        If txt_cdFactory.Code = "" Then Exit Function

        vS1.ActiveSheet.RowCount = 0

        SPR_CLEAR(vS1)
        SPR_SET(vS1, , , , OperationMode.Normal, True)
        vS1.ActiveSheet.SelectionPolicy = Model.SelectionPolicy.Single
        vS1.RetainSelectionBlock = True

        Try

            DS1 = PrcDS("USP_PFP40735_SEARCH_VS1_HEAD", cn, ListCode("Factory"), txt_cdFactory.Code, ListCode("LineProd"))

            Dim cdLineProdName As String
            Dim cdLineProd As String

            If GetDsRc(DS1) = 0 Then vS1.ActiveSheet.RowCount = 0 : Exit Function

            vS1.ActiveSheet.RowCount = GetDsRc(DS1)

            vS1.ActiveSheet.ColumnCount = 31

            For i = 0 To 30
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

            DS2 = PrcDS("USP_PFP40735_SEARCH_VS1", cn, txt_DatePlan.Data, txt_cdFactory.Code, txt_cdMainProcess.Code)

            Dim Xcol As Integer
            Dim Xrow As Integer

            Dim SRow As Integer
            Dim ERow As Integer

            For i = 0 To GetDsRc(DS2) - 1
                Xcol = CIntp(GetDsData(DS2, i, "KEY_LineTno")) - 1
                Xrow = getRowIndex(vS1, GetDsData(DS2, i, "KEY_cdLineProd"))

                SRow = Xrow

                If Xcol < 0 Or Xrow < 0 Then GoTo next1
                If GetDsData(DS2, i, "Article").Trim <> "" Then
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

            For i = 0 To 30
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
            vS1.ActiveSheet.RowHeader.Columns(0).Width = 80
            vS1.ActiveSheet.RowHeader.Columns(0).Font = New Font("Tahoma", 9, FontStyle.Bold)

            ptc_1.SelectedIndex = 1

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

        cdFactory = txt_cdFactory.Code
        cdMainProcess = txt_cdMainProcess.Code
        cdLineProd = getCellRH(vS1, 0, vS1.ActiveSheet.ActiveRowIndex)
        LineTno = vS1.ActiveSheet.ColumnHeader.Cells(0, vS1.ActiveSheet.ActiveColumnIndex).Value

        If cdLineProd = "" Then Exit Function
        vS2.Enabled = False

        DS1 = PrcDS("USP_PFP40735_SEARCH_VS2_F1", cn, txt_DatePlan.Data,
                                                        cdFactory,
                                                    cdLineProd)

        If GetDsRc(DS1) = 0 Then
            vS2.Enabled = True
            Exit Function
        End If

        SPR_SET(vS2, , , , OperationMode.SingleSelect)
        SPR_PRO(vS2, DS1, "USP_PFP40735_SEARCH_VS2_F1", "vs2")

        'If READ_PFK4073(cdFactory, cdMainProcess, cdLineProd, LineTno) Then
        '    Call VsSizeRangeNew(vS2, "USP_VS_SIZERANGE_JOBBASE", "SizeQty01", D4073.JobCard)
        'End If

        'vS2.ActiveSheet.RowCount += 1
        'SPR_CHECKBOXROW(vS2, 1)

        'vS2.ActiveSheet.Rows(vS2.ActiveSheet.RowCount - 1).Locked = False

        DATA_SEARCH_VS2 = True

        vS2.Enabled = True
    End Function

    Private Function DATA_SEARCH_VS31(Optional ByVal xsort As String = "1") As Boolean
        Dim cdFactory As String
        Dim cdMainProcess As String
        Dim cdLineProd As String
        Dim LineTno As String

        DATA_SEARCH_VS31 = False

        cdFactory = txt_cdFactory.Code
        cdMainProcess = txt_cdMainProcess.Code
        cdLineProd = getCellRH(vS1, 0, vS1.ActiveSheet.ActiveRowIndex)
        LineTno = vS1.ActiveSheet.ColumnHeader.Cells(0, vS1.ActiveSheet.ActiveColumnIndex).Value

        If cdLineProd = "" Then Exit Function
        vS31.Enabled = False

        DS1 = PrcDS("USP_PFP40735_SEARCH_vS31", cn, cdFactory,
                                                    cdMainProcess,
                                                    cdLineProd,
                                                    LineTno)

        If GetDsRc(DS1) = 0 Then
            vS31.Enabled = True
            Exit Function
        End If

        SPR_SET(vS31, , , , OperationMode.SingleSelect)
        SPR_PRO(vS31, DS1, "USP_PFP40735_SEARCH_vS31", "vS31")

        DATA_SEARCH_VS31 = True

        vS31.Enabled = True
    End Function

    Private Function DATA_SEARCH_VS32(Optional ByVal xsort As String = "1") As Boolean
        'lATER
        Dim BatchGroup As String
        Dim SizeName As String
        Dim cdMainProcess As String
        Dim cdLineProd As String
        Dim LineTno As String
        Dim cdFactory As String

        cdFactory = txt_cdFactory.Code
        cdMainProcess = txt_cdMainProcess.Code
        cdLineProd = getCellRH(vS1, 0, vS1.ActiveSheet.ActiveRowIndex)
        LineTno = vS1.ActiveSheet.ColumnHeader.Cells(0, vS1.ActiveSheet.ActiveColumnIndex).Value

        If cdLineProd = "" Then Exit Function

        DATA_SEARCH_VS32 = True

        BatchGroup = getData(vS31, getColumIndex(vS31, "Key_BatchGroup"), vS31.ActiveSheet.ActiveRowIndex)
        SizeName = getData(vS31, getColumIndex(vS31, "SizeName"), vS31.ActiveSheet.ActiveRowIndex)

        Try

            DS1 = PrcDS("USP_PFP40735_SEARCH_vS32", cn, cdFactory,
                                                              cdMainProcess,
                                                              cdLineProd,
                                                              LineTno,
                                                              SizeName,
                                                             BatchGroup)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO(vS32, DS1, "USP_PFP40735_SEARCH_vS32", "vS32")

                Exit Function

            End If

            SPR_PRO(vS32, DS1, "USP_PFP40735_SEARCH_vS32", "vS32")

            Dim i As Integer

            For i = 0 To vS32.ActiveSheet.RowCount - 1
                If CIntp(getData(vS32, getColumIndex(vS32, "QtyProduction"), i)) > 0 Then
                    SPR_LOCK(vS32, i)
                    SPR_BACKCOLORCELL(vS32, Color.Red, getColumIndex(vS32, "Dchk"), i)
                End If
            Next

            ptc_1.SelectedIndex = 1

            DATA_SEARCH_VS32 = True

        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_VS1")
        End Try

        vS32.Enabled = True
    End Function

    Private Function LINE_MOVE_DISPLAY01(spr As FarPoint.Win.Spread.FpSpread, Xcol As Integer, Xrow As Integer,
                                       cdLineProd As String) As Boolean

        LINE_MOVE_DISPLAY01 = False
        Dim LineTno As String

        LineTno = (Xcol + 1).ToString("00")

        DS2 = PrcDS("USP_ISUD4073A_SEARCH_LINE_TNO", cn, txt_cdFactory.Code,
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
        ptc_1.SelectedIndex = 0
        vS2.ActiveSheet.RowCount = 0
        vS31.ActiveSheet.RowCount = 0
        Call DATA_SEARCH_VS2()
        Call DATA_SEARCH_vS31()
    End Sub

    Private Sub DATA_SEARCH_ALL()
        ptc_1.SelectedIndex = 0
        vS2.ActiveSheet.RowCount = 0
        vS31.ActiveSheet.RowCount = 0
        vS32.ActiveSheet.RowCount = 0

        Call DATA_SEARCH_VS2()
        'Call DATA_SEARCH_VS31()
    End Sub

    Public Function DATA_SEARCH_HEAD_vs_Season() As Boolean
        DATA_SEARCH_HEAD_vs_Season = True : Exit Function

    End Function

    Public Function DATA_SEARCH_HEAD_vS_Cus() As Boolean
        DATA_SEARCH_HEAD_vS_Cus = True : Exit Function

    End Function

    Public Function DATA_SEARCH_HEAD_vS_Line() As Boolean
        DATA_SEARCH_HEAD_vS_Line = True : Exit Function

    End Function


    Public Function DATA_SEARCH_HEAD_vs_Job() As Boolean
        DATA_SEARCH_HEAD_vs_Job = True : Exit Function

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
            MAIN_JOB06()
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

    Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs) Handles vS1.CellDoubleClick
        If e.ColumnHeader = True Or e.RowHeader = True Then Exit Sub
        If e.Button = Windows.Forms.MouseButtons.Left Then
            DATA_SEARCH_ALL()
            vS1.ActiveSheet.AddSelection(e.Row, e.Column, 1, 1)
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
            MAIN_JOB02_1() '1

        ElseIf Cms_1.Items(1).Selected = True Then
            Cms_1.Hide()
            MAIN_JOB03_1() '2

        ElseIf Cms_1.Items(2).Selected = True Then
            Cms_1.Hide()
            MAIN_JOB04_1() '3

        ElseIf Cms_1.Items(4).Selected = True Then
            Cms_1.Hide()
            MAIN_JOB05_1() 
        End If

    End Sub
    Private Sub Cms_2_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles Cms_2.ItemClicked
        If Cms_2.Items(0).Selected = True Then
            Cms_2.Hide()
            MAIN_JOB01() '0

        ElseIf Cms_2.Items(1).Selected = True Then
            Cms_2.Hide()
            MAIN_JOB02() '1

        ElseIf Cms_2.Items(2).Selected = True Then
            Cms_2.Hide()
            MAIN_JOB03() '2

        ElseIf Cms_2.Items(3).Selected = True Then
            Cms_2.Hide()
            MAIN_JOB04() '3

        ElseIf Cms_2.Items(4).Selected = True Then
            Cms_2.Hide()
            MAIN_JOB05() '4

        ElseIf Cms_2.Items(5).Selected = True Then
            Cms_2.Hide()
            MAIN_JOB05_1() '4

        ElseIf Cms_2.Items(6).Selected = True Then
            Cms_2.Hide()
            MAIN_JOB06()

        End If
    End Sub

    Private Sub PFP40735_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If SizeChk = False Then Exit Sub
        Try
            If Me.Width > 20 Then
                ptc_1.ItemSize = New Size((ptc_1.Width - 10) / 2, 30)
            Else
                Exit Sub
            End If

        Catch ex As Exception
            SizeChk = False
        End Try
    End Sub
    Private Sub btn_Closing_Click(sender As Object, e As EventArgs)
        If MsgBoxPPW("Please input password", const_pwPrintUpdate) = False Then Exit Sub

        Try
            If PrcExe("USP_PFP40735_ROW_NUMBER_CLOSSING", cn, txt_cdFactory.Code, txt_cdMainProcess.Code, Pub.DAT) = True Then

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
        Psc_0.Panel2Collapsed = chk_FullScreen.Checked
    End Sub


 

End Class