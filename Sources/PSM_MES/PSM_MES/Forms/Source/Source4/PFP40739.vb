Public Class PFP40739
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
                     "PRODUCTION INPUT - " & "(F11)")

        Call Cms_additem(Cms_2,
                     "LINE PLANNING CONTROL - INSERT " & "(F7)",
                     "LINE PLANNING CONTROL - SEARCH " & "(F8)",
                     "LINE PLANNING CONTROL - UPDATE " & "(F9)",
                     "LINE PLANNING CONTROL - DELETE " & "(F10)",
                      "-",
                      "PRODUCTION INPUT - " & "(F11)",
                      "GENERATE SETBALANCE BARCODE - " & "(F12)",
                      "UPDATE PRODUCTION PLAN")

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
                Case Keys.F5 : Call MAIN_JOB06()
                Case Keys.F6 : Call MAIN_JOB11()
            End Select
        Catch ex As Exception
        End Try
    End Sub
    Private Sub FORM_INIT()
       txt_DatePlan.Data = System_Date_8()
        txt_cdMainProcess.Code = "050"

        If READ_PFK7171(ListCode("MainProcess"), txt_cdMainProcess.Code) Then
            txt_cdMainProcess.Data = D7171.BasicName
        End If

        'Select Case Strings.Right(Me.PeaceFormType, 2).ToUpper
        '    Case "F1"

        '        If READ_PFK7171(ListCode("Factory"), "001") Then
        '            txt_cdFactory.Code = D7171.BasicCode
        '            txt_cdFactory.Data = D7171.BasicName
        '        End If
        '        txt_cdFactory.Enabled = False

        '    Case "F2"
        '        If READ_PFK7171(ListCode("Factory"), "002") Then
        '            txt_cdFactory.Code = D7171.BasicCode
        '            txt_cdFactory.Data = D7171.BasicName
        '        End If
        '        txt_cdFactory.Enabled = False

        '    Case "F3"
        '        If READ_PFK7171(ListCode("Factory"), "003") Then
        '            txt_cdFactory.Code = D7171.BasicCode
        '            txt_cdFactory.Data = D7171.BasicName
        '        End If
        '        txt_cdFactory.Enabled = False

        '    Case "OS"
        '        txt_cdFactory.Data = "Outsource"
        '        txt_cdFactory.Code = "051"
        '        txt_cdFactory.Enabled = False
        'End Select


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
        Dim cdLineProd As String
        Dim LineTno As String

        cdFactory = txt_cdFactory.Code

        cdLineProd = getCellRH(vS1, 0, vS1.ActiveSheet.ActiveRowIndex)

        Dim cdMainProcess As String
        cdMainProcess = txt_cdMainProcess.Code
        LineTno = vS1.ActiveSheet.ColumnHeader.Cells(0, vS1.ActiveSheet.ActiveColumnIndex).Value

        If cdFactory = "" Or cdLineProd = "" Or LineTno = "" Then Exit Sub

        If ISUD4073C_NC.Link_ISUD4073C(1, cdFactory, cdMainProcess, cdLineProd, LineTno, Me.Name) = False Then Exit Sub

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
            LineTno = vS1.ActiveSheet.ColumnHeader.Cells(0, vS1.ActiveSheet.ActiveColumnIndex).Value
        End If

        If ISUD4073C_NC.Link_ISUD4073C(2, cdFactory, cdMainProcess, cdLineProd, LineTno, Me.Name) = False Then Exit Sub

    End Sub


    Private Sub MAIN_JOB03()
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
            LineTno = vS1.ActiveSheet.ColumnHeader.Cells(0, vS1.ActiveSheet.ActiveColumnIndex).Value
        End If

        If ISUD4073C_NC.Link_ISUD4073C(3, cdFactory, cdMainProcess, cdLineProd, LineTno, Me.Name) = False Then Exit Sub

        Call LINE_MOVE_DISPLAY01(vS1, vS1.ActiveSheet.ActiveColumnIndex, vS1.ActiveSheet.ActiveRowIndex, cdLineProd)
    End Sub

    Private Sub MAIN_JOB04()
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

        If ISUD4073C_NC.Link_ISUD4073C(4, cdFactory, cdMainProcess, cdLineProd, LineTno, Me.Name) = False Then Exit Sub
        Call LINE_MOVE_DISPLAY01(vS1, vS1.ActiveSheet.ActiveColumnIndex, vS1.ActiveSheet.ActiveRowIndex, cdLineProd)
    End Sub

    Private Sub MAIN_JOB05()
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

        If ISUD4073P.Link_ISUD4073P(5, cdFactory, cdMainProcess, cdLineProd, LineTno, Me.Name) = False Then Exit Sub

        Call LINE_MOVE_DISPLAY01(vS1, vS1.ActiveSheet.ActiveColumnIndex, vS1.ActiveSheet.ActiveRowIndex, cdLineProd)


    End Sub

    Private Sub MAIN_JOB06()
        'If MsgBoxPPW("Please type the password to print barcode!", const_pwPO) = False Then Exit Sub
        Dim StrMsg As String = MsgBox("SetBalance2 Generate? ", vbYesNo)
        If StrMsg <> vbYes Then Exit Sub
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

        Dim Starting As Object
        Starting = New DevExpress.Utils.WaitDialogForm("Loading data...", "PSM")

        Try
            Call PrcExeNoError("USP_PFK4015_GENERATE_BARCODE_ALL_JOBCARD_SETBALANCE2", cn, cdFactory, cdMainProcess, cdLineProd, LineTno, txt_BatchSizeQ.Value)
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

        'Later   If ISUD4073B_NC.Link_ISUD4073B(2, cdFactory,  cdLineProd, LineTno, Me.Name) = False Then Exit Sub

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

        'Later    If ISUD4073B_NC.Link_ISUD4073B(3, cdFactory,  cdLineProd, LineTno, Me.Name) = False Then Exit Sub

    End Sub

    Private Sub MAIN_JOB04_1()
        If Date_Check() = False Then Exit Sub

        Dim cdFactory As String
        Dim cdLineProd As String
        Dim LineTno As String

        cdFactory = getData(vS2, getColumIndex(vS2, "KEY_cdFactory"), vS2.ActiveSheet.ActiveRowIndex)
        cdLineProd = getData(vS2, getColumIndex(vS2, "KEY_cdLineProd"), vS2.ActiveSheet.ActiveRowIndex)
        LineTno = getData(vS2, getColumIndex(vS2, "KEY_LineTno"), vS2.ActiveSheet.ActiveRowIndex)

        If cdFactory = "" Or cdLineProd = "" Then Exit Sub

        'Later    If ISUD4073B_NC.Link_ISUD4073B(4, cdFactory,  cdLineProd, LineTno, Me.Name) = False Then Exit Sub

    End Sub

    Private Sub MAIN_JOB15()
        If Date_Check() = False Then Exit Sub

        Dim cdFactory As String
        Dim cdLineProd As String
        Dim LineTno As String

        cdFactory = txt_cdFactory.Code

        cdLineProd = getCellRH(vS1, 0, vS1.ActiveSheet.ActiveRowIndex)

        Dim cdMainProcess As String
        cdMainProcess = txt_cdMainProcess.Code
        LineTno = vS1.ActiveSheet.ColumnHeader.Cells(0, vS1.ActiveSheet.ActiveColumnIndex).Value

        If cdFactory = "" Or cdLineProd = "" Or LineTno = "" Then Exit Sub

        If ISUD4073B_NC.Link_ISUD4073B(31, cdFactory, cdMainProcess, cdLineProd, LineTno, Me.Name) = False Then Exit Sub

        Call LINE_MOVE_DISPLAY01(vS1, vS1.ActiveSheet.ActiveColumnIndex, vS1.ActiveSheet.ActiveRowIndex, cdLineProd)
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

            DS2 = PrcDS("USP_PFP40730_SEARCH_HEAD", cn, cdFactory,
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

        vS1.ActiveSheet.ColumnCount = 0
        vS1.ActiveSheet.RowCount = 0

        SPR_CLEAR(vS1)
        SPR_SET(vS1, , , , OperationMode.Normal, True)
        vS1.ActiveSheet.SelectionPolicy = Model.SelectionPolicy.Single
        vS1.RetainSelectionBlock = True

        If txt_DatePlan.Data <> System_Date_8() Then Exit Function

        Try

            DS1 = PrcDS("USP_PFP40730_SEARCH_VS1_HEAD", cn, ListCode("Factory"), txt_cdFactory.Code, ListCode("LineProd"))

            Dim cdLineProdName As String
            Dim cdLineProd As String

            If GetDsRc(DS1) = 0 Then vS1.ActiveSheet.RowCount = 0 : Exit Function

            vS1.ActiveSheet.RowCount = GetDsRc(DS1)

            vS1.ActiveSheet.ColumnCount = 99

            For i = 0 To 98
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

                DS2 = PrcDS("USP_PFP40730_SEARCH_VS1_F1_NEWCONCEPT_FULL", cn, txt_cdFactory.Code, txt_cdMainProcess.Code, txt_cdSeason.Code)
                SPR_PRO(vS1, DS2, "USP_PFP40730_SEARCH_VS1_F1_NEWCONCEPT_FULL", "vS1")

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
                DS2 = PrcDS("USP_PFP40730_SEARCH_VS1_F1_NEWCONCEPT", cn, txt_cdFactory.Code, txt_cdMainProcess.Code, txt_cdSeason.Code)

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

                For i = 0 To 98
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

                ptc_1.SelectedIndex = 1

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

    Public Function DATA_SEARCH01_STATE(ProcessType As String) As Boolean
        DATA_SEARCH01_STATE = False

        Try

            vS1.Enabled = True

            Try
                DS1 = PrcDS("USP_PFP40730_SEARCH_VS1_STATE", cn, txt_cdFactory.Code, txt_cdMainProcess.Code, txt_cdSeason.Code)

                If GetDsRc(DS1) = 0 Then
                    SPR_PRO_NEW(vS1, DS1, "USP_PFP40730_SEARCH_VS1_STATE", "vS1")
                    vS1.Enabled = True
                    Exit Function
                End If

                SPR_PRO_NEW(vS1, DS1, "USP_PFP40730_SEARCH_VS1_STATE", "vS1")
                DATA_SEARCH01_STATE = True

                vS1.Enabled = True

            Catch ex As Exception

            End Try

            Dim DateSystem As String = FSDate(txt_DatePlan.Data)

            Dim int_Random As Integer
            Dim i As Integer
            Dim int_ColumnMax As Integer

            Dim int_ColFix As Integer
            Dim int_RandomRange As Integer
            int_ColumnMax = vS1.ActiveSheet.ColumnCount

            Dim int_DateIncrement As Integer = -1
            vS1.ActiveSheet.ColumnCount = vS1.ActiveSheet.ColumnCount + 100
            vS1.ActiveSheet.ColumnHeader.RowCount = 2

            For i = int_ColumnMax To int_ColumnMax + 99
                int_DateIncrement += 1
                setDataCH(vS1, i, 0, Strings.Right(FSDate(Function_Date_Add(DateSystem, 0, int_DateIncrement)), 5))
                setCellCH(vS1, i, 0, Function_Date_Add(DateSystem, 0, int_DateIncrement))

                vS1.ActiveSheet.ColumnHeader.Columns(i).Tag = Function_Date_Add(DateSystem, 0, int_DateIncrement)

                setDataCH(vS1, i, 1, Strings.Left(CDate(FSDate(Function_Date_Add(DateSystem, 0, int_DateIncrement))).DayOfWeek.ToString, 3).ToUpper)

                If CDate(FSDate(Function_Date_Add(DateSystem, 0, int_DateIncrement))).DayOfWeek = DayOfWeek.Sunday Then
                    vS1.ActiveSheet.ColumnHeader.Cells(1, i).BackColor = Color.PaleVioletRed
                    vS1.ActiveSheet.Columns(i).Visible = False
                End If

                SPR_NUMBERCOL(vS1, 0, i)
                vS1.ActiveSheet.Columns(i).Width = 45

                'Vs10.ActiveSheet.Columns(i).Locked = False

            Next

            int_ColFix = getColumIndex(vS1, "cdLineProdName")

            Dim Ran1 As Integer = 0
            Dim Ran2 As Integer = 0
            Dim Ran3 As Integer = 0
            Dim Ran4 As Integer = 0
            Dim int_rowIn As Integer

            Dim str_Autokey As String

            Dim int_ColFix1 As Integer = getColumIndex(vS1, "Key_cdLineProd")
            Dim int_ColFix2 As Integer = getColumIndex(vS1, "key_cdSubProcess")

            For i = 0 To vS1.ActiveSheet.RowCount - 1
                str_Autokey = getData(vS1, int_ColFix1, i)

                Dim RowIndex As Integer

                RowIndex = getData(vS1, getColumIndex(vS1, "RowIndex"), i)

next1:
                If RowIndex = 0 Then


                    DS2 = PrcDS("USP_PFP40730_SEARCH_VS1_STATE_LINE", cn, txt_cdFactory.Code, txt_cdMainProcess.Code, str_Autokey)

                    For xrow As Integer = 0 To GetDsRc(DS2) - 1


                        int_rowIn = i

                        Dim chkDate As Boolean = False
                        Dim NewDAte As String
                        Dim OldDAte As String

                        If xrow > 0 And (NewDAte >= GetDsData(DS2, xrow, "DateStart") Or NewDAte >= GetDsData(DS2, xrow, "DateFinish")) And 1 = 2 Then

                            MsgBox("Date Start must greather then " & NewDAte)

                            Dim JobCard As String
                            Dim xDate As String = GetDsData(DS2, xrow, "DateStart")
                            Dim xxdate As String = GetDsData(DS2, xrow, "DateFinish")
                            Dim xShoesCode As String = GetDsData(DS2, xrow, "ShoesCode")

                            JobCard = PrcExeNoError_Value("USP_PFP40730_SEARCH_VS1_STATE_LINE_SHOESCODE_JOBCARD", cn, txt_cdFactory.Code, txt_cdMainProcess.Code, str_Autokey, GetDsData(DS2, xrow, "ShoesCode"), GetDsData(DS2, xrow, "DateStart"))

                            If READ_PFK4010(JobCard) Then

                                If ISUD4010A.Link_ISUD4010A("3", JobCard, "PFP40010") = True Then
                                    If READ_PFK4010(JobCard) Then

                                        Call PrcExeNoError("USP_PFP40730_SEARCH_VS1_STATE_LINE_SHOESCODE_JOBCARD_UPDATE", cn, txt_cdFactory.Code, txt_cdMainProcess.Code, str_Autokey, xShoesCode, xDate, D4010.DatePlanStart, D4010.DatePlanFinish)

                                        GoTo next1
                                    End If

                                End If

                            End If

                        End If



                        If GetDsData(DS2, xrow, "DateStart") >= txt_DatePlan.Data Then


                            int_Random = getColumIndex(vS1, GetDsData(DS2, xrow, "DateStart"))  ' Lấy giá trị cột của DataStart

                            'If xrow > 0 And NewDAte < OldDAte Then
                            '    'int_Random = getColumIndex(vS1, OldDAte) + 1

                            'End If

                            If int_Random < 0 Then int_Random = getColumIndex(vS1, "QtyPlanBL") + 1 ' Nếu không có, cho mặc định cột 1

                            int_RandomRange = getColumIndex(vS1, GetDsData(DS2, xrow, "DateFinish")) ' Lấy giá trị cột của Data Finsih

                            If int_RandomRange > 0 Then ' Nếu có giá trị, thực thi

                                int_RandomRange = int_RandomRange - int_Random

                                If int_Random < 0 Then int_Random = getColumIndex(vS1, "QtyPlanBL") + 1

                                Ran1 = int_Random + int_RandomRange

                                'dòng thứ 1
                                SPR_TEXTBOX_S(vS1, int_Random, int_rowIn)
                                vS1.ActiveSheet.Cells(int_rowIn, int_Random).HorizontalAlignment = CellHorizontalAlignment.Left
                                vS1.ActiveSheet.Cells(int_rowIn, int_Random).ColumnSpan = int_RandomRange + 1
                                vS1.ActiveSheet.Cells(int_rowIn, int_Random).Value = GetDsData(DS2, xrow, "Article") & "/" & GetDsData(DS2, xrow, "PL_SOName")
                                vS1.ActiveSheet.Cells(int_rowIn, int_Random).Tag = GetDsData(DS2, xrow, "ShoesCode")

                                Dim str() As String = GetDsData(DS2, xrow, "Backcolor").Split("-")

                                If str.Length > 2 Then
                                    vS1.ActiveSheet.Cells(int_rowIn, int_Random, int_rowIn + 3, int_Random + int_RandomRange).BackColor = System.Drawing.Color.FromArgb(CInt(str(0)), CInt(str(1)), CInt(str(2)))
                                End If

                                If GetDsData(DS2, xrow, "Backcolor") = "255-255-255" Then
                                    vS1.ActiveSheet.Cells(int_rowIn, int_Random, int_rowIn + 3, int_Random + int_RandomRange).BackColor = SystemColors.Control
                                End If
                                ' dòng thứ 2
                                SPR_TEXTBOX_S(vS1, int_Random, int_rowIn + 1)
                                vS1.ActiveSheet.Cells(int_rowIn + 1, int_Random).HorizontalAlignment = CellHorizontalAlignment.Left
                                vS1.ActiveSheet.Cells(int_rowIn + 1, int_Random).Value = GetDsData(DS2, xrow, "PL_QtyName")
                                vS1.ActiveSheet.Cells(int_rowIn + 1, int_Random).ColumnSpan = int_RandomRange + 1

                                If GetDsData(DS2, xrow, "CheckDivided") = "2" Then
                                    vS1.ActiveSheet.Cells(int_rowIn + 2, int_Random, int_rowIn + 2, int_Random + int_RandomRange).Value = GetDsData(DS2, xrow, "QtyAvgDAy")

                                    For intx As Integer = int_Random To Ran1
                                        vS1.ActiveSheet.Cells(int_rowIn + 3, intx, int_rowIn + 3, intx).Value = PrcExeNoError_Value("USP_PFK4167_SEARCH_DATA", cn, GetDsData(DS2, xrow, "JobCard"), vS1.ActiveSheet.ColumnHeader.Columns(intx).Tag, txt_cdMainProcess.Code, txt_cdFactory.Code, GetDsData(DS2, xrow, "Key_cdLineProd"))
                                    Next

                                End If


                                'setCell(vS1, int_Random, int_rowIn, GetDsData(DS2, xrow, "KEY_AutoKey"))

                                'vS1.ActiveSheet.Cells(int_rowIn, int_Random, int_rowIn, int_Random + int_RandomRange).Tag = GetDsData(DS2, xrow, "KEY_AutoKey")

                            End If

                        End If

                        OldDAte = GetDsData(DS2, xrow, "DateStart")
                        NewDAte = GetDsData(DS2, xrow, "DateFinish")

                    Next

                End If

            Next

            DATA_SEARCH01_STATE = True
        Catch ex As Exception

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

        DS1 = PrcDS("USP_PFP40730_SEARCH_VS2_NEWCONCEPT", cn, cdFactory,
                                                    cdMainProcess,
                                                    cdLineProd,
                                                    LineTno)

        If GetDsRc(DS1) = 0 Then
            vS2.Enabled = True
            Exit Function
        End If

        SPR_SET(vS2, , , , OperationMode.SingleSelect)
        SPR_PRO(vS2, DS1, "USP_PFP40730_SEARCH_VS2", "vs2")

        If READ_PFK4073(cdFactory, cdMainProcess, cdLineProd, LineTno) Then
            Call VsSizeRangeNew(vS2, "USP_VS_SIZERANGE_JOBBASE", "SizeQTY01", D4073.JobCard)
        End If

        vS2.ActiveSheet.RowCount += 1
        SPR_CHECKBOXROW(vS2, 1)

        vS2.ActiveSheet.Rows(vS2.ActiveSheet.RowCount - 1).Locked = False

        DATA_SEARCH_VS2 = True

        vS2.Enabled = True
    End Function

    Private Function DATA_SEARCH_VS31(Optional ByVal xsort As String = "1") As Boolean
        Dim cdFactory As String
        Dim cdMainProcess As String
        Dim cdLineProd As String
        Dim LineTno As String

        DATA_SEARCH_VS31 = False


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
        vS31.Enabled = False

        DS1 = PrcDS("USP_PFP40730_SEARCH_vS31_NEWCONCEPT", cn, cdFactory,
                                                    cdMainProcess,
                                                    cdLineProd,
                                                    LineTno)

        If GetDsRc(DS1) = 0 Then
            vS31.Enabled = True
            Exit Function
        End If

        SPR_SET(vS31, , , , OperationMode.SingleSelect)
        SPR_PRO(vS31, DS1, "USP_PFP40730_SEARCH_vS31", "vS31")

        DATA_SEARCH_VS31 = True
        If ptc_1.Width > 30 Then ptc_1.ItemSize = New Size((ptc_1.Width - 10) / ptc_1.TabCount, 30)

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

            DS1 = PrcDS("USP_PFP40730_SEARCH_vS32_NEWCONCEPT", cn, cdFactory,
                                                              cdMainProcess,
                                                              cdLineProd,
                                                              LineTno,
                                                              SizeName,
                                                             BatchGroup)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO(vS32, DS1, "USP_PFP40730_SEARCH_vS32", "vS32")

                Exit Function

            End If

            SPR_PRO(vS32, DS1, "USP_PFP40730_SEARCH_vS32", "vS32")

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

    Private Function DATA_SEARCH_VS32_xrow(xrow As Integer) As Boolean
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

        DATA_SEARCH_VS32_xrow = True

        BatchGroup = getData(vS31, getColumIndex(vS31, "Key_BatchGroup"), xrow)
        SizeName = getData(vS31, getColumIndex(vS31, "SizeName"), xrow)

        Try

            DS1 = PrcDS("USP_PFP40730_SEARCH_vS32", cn, cdFactory,
                                                              cdMainProcess,
                                                              cdLineProd,
                                                              LineTno,
                                                              SizeName,
                                                             BatchGroup)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO(vS32, DS1, "USP_PFP40730_SEARCH_vS32", "vS32")

                Exit Function

            End If

            SPR_PRO(vS32, DS1, "USP_PFP40730_SEARCH_vS32", "vS32")

            ptc_1.SelectedIndex = 1

            DATA_SEARCH_VS32_xrow = True

        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_VS1")
        End Try

        vS32.Enabled = True
    End Function

    Private Function DATA_SEARCH_VS33(Optional ByVal xsort As String = "1") As Boolean
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

        cdMainProcess = "013" 'SETBALANCE 2

        If cdLineProd = "" Then Exit Function

        DATA_SEARCH_VS33 = True

        SizeName = getData(vS31, getColumIndex(vS31, "SizeName"), vS31.ActiveSheet.ActiveRowIndex)

        Try

            DS1 = PrcDS("USP_PFP40730_SEARCH_VS33", cn, cdFactory,
                                                              cdMainProcess,
                                                              cdLineProd,
                                                              LineTno,
                                                              SizeName)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO(vS33, DS1, "USP_PFP40730_SEARCH_VS33", "VS33")

                Exit Function

            End If

            SPR_PRO(vS33, DS1, "USP_PFP40730_SEARCH_VS33", "VS33")

            DATA_SEARCH_VS33 = True

        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_VS1")
        End Try

        vS33.Enabled = True
    End Function

    Private Function DATA_SEARCH_VS33_XROW(xrow As Integer) As Boolean
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

        cdMainProcess = "013" 'SETBALANCE 2

        If cdLineProd = "" Then Exit Function

        DATA_SEARCH_VS33_XROW = True

        SizeName = getData(vS31, getColumIndex(vS31, "SizeName"), xrow)

        Try

            DS1 = PrcDS("USP_PFP40730_SEARCH_VS33", cn, cdFactory,
                                                              cdMainProcess,
                                                              cdLineProd,
                                                              LineTno,
                                                              SizeName)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO(vS33, DS1, "USP_PFP40730_SEARCH_VS33", "VS33")

                Exit Function

            End If

            SPR_PRO(vS33, DS1, "USP_PFP40730_SEARCH_VS33", "VS33")

            DATA_SEARCH_VS33_XROW = True

        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_VS1")
        End Try

        vS33.Enabled = True
    End Function
    Private Function LINE_MOVE_DISPLAY01(spr As FarPoint.Win.Spread.FpSpread, Xcol As Integer, Xrow As Integer,
                                       cdLineProd As String) As Boolean

        LINE_MOVE_DISPLAY01 = False
        Dim LineTno As String

        LineTno = (Xcol + 1).ToString("00")

        DS2 = PrcDS("USP_ISUD4073A_SEARCH_LINE_TNO_NEWCONCEPT", cn, txt_cdFactory.Code,
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

            'setData(vS1, Xcol, Xrow, GetDsData(DS2, 0, "SpecNo") & vbLf &
            '            "L: " & FormatNumber(GetDsData(DS2, 0, "QtyPlan"), 0) & "/P: " & FormatNumber(GetDsData(DS2, 0, "QtyProd"), 0) & "/T: " & FormatNumber(GetDsData(DS2, 0, "QtyTotalOrder"), 0) & vbLf & GetDsData(DS2, 0, "Line") & vbLf & GetDsData(DS2, 0, "Article") & vbLf &
            '               GetDsData(DS2, 0, "ColorName"))

            'SPR_BACKCOLORCELL(vS1, FUNCTION_DYEING_PLAN_BACK(GetDsData(DS2, 0, "CheckComplete")), Xcol, Xrow)
            'SPR_FORECOLORCELL(vS1, FUNCTION_DYEING_PLAN_FORE(GetDsData(DS2, 0, "CheckComplete")), Xcol, Xrow)

        End If

        LINE_MOVE_DISPLAY01 = True
        vS1.Select()
        vS1.Focus()


    End Function

    'Private Function LINE_MOVE_DISPLAY01(spr As FarPoint.Win.Spread.FpSpread, Xcol As Integer, Xrow As Integer,
    '                                     cdFactory As String, cdMainProcess As String,
    '                                     cdLineProd As String, LineTno As String) As Boolean

    '    LINE_MOVE_DISPLAY01 = False

    '    DS2 = PrcDS("USP_ISUD4073A_SEARCH_LINE_TNO_NEWCONCEPT", cn, cdFactory,
    '                                                    cdMainProcess,
    '                                                    cdLineProd,
    '                                                    LineTno)

    '    If GetDsRc(DS2) = 0 Then
    '        setData(vS1, Xcol, Xrow, "")
    '        SPR_BACKCOLORCELL(vS1, Color.Empty, Xcol, Xrow)
    '        Exit Function
    '    End If

    '    If GetDsData(DS2, 0, "Article").Trim <> "" Then
    '        setData(vS1, Xcol, Xrow, GetDsData(DS2, 0, "SpecNo") & "-" & GetDsData(DS2, 0, "SpecNoSeq") & vbLf &
    '                    "Plan: " & FormatNumber(GetDsData(DS2, 0, "QtyPlan"), 0) & "/ Prod: " & FormatNumber(GetDsData(DS2, 0, "QtyProd"), 0) & vbLf & GetDsData(DS2, 0, "Line") & vbLf & GetDsData(DS2, 0, "Article") & vbLf &
    '                       GetDsData(DS2, 0, "ColorName"))

    '        SPR_BACKCOLORCELL(vS1, FUNCTION_DYEING_PLAN_BACK(GetDsData(DS2, 0, "CheckComplete")), Xcol, Xrow)
    '        SPR_FORECOLORCELL(vS1, FUNCTION_DYEING_PLAN_FORE(GetDsData(DS2, 0, "CheckComplete")), Xcol, Xrow)

    '    End If

    '    LINE_MOVE_DISPLAY01 = True

    '    Call_Data()
    'End Function

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
        Call DATA_SEARCH_VS31()
    End Sub

    Public Function DATA_SEARCH_HEAD_vs_Season() As Boolean
        DATA_SEARCH_HEAD_vs_Season = False

        Try
            DS1 = PrcDS("USP_PFP40730_SEARCH_VS_SEASON", cn, ListCode("Season"))
            SPR_PRO_NEW(vs_Season, DS1, "USP_PFP40730_SEARCH_VS_SEASON", "vs_Season")

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
            DS1 = PrcDS("USP_PFP40730_SEARCH_vS_Cus", cn, CustomerCode, cdSeason)
            SPR_PRO_NEW(vS_Cus, DS1, "USP_PFP40730_SEARCH_vS_Cus", "vS_Cus")

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
            DS1 = PrcDS("USP_PFP40730_SEARCH_vS_Line", cn, cdSeason, CustomerCode)
            SPR_PRO_NEW(vS_Line, DS1, "USP_PFP40730_SEARCH_vS_Line", "vS_Line")

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
            DS1 = PrcDS("USP_PFP40730_SEARCH_vs_Job", cn, cdSeason, CustomerCode, Line)
            SPR_PRO_NEW(vs_Job, DS1, "USP_PFP40730_SEARCH_vs_Job", "vs_Job")
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

            Dim StrMsgXX As String = MsgBox("Matching " & D4010.JobCard & " With Line " & cdLineProd & " ?", vbYesNo)
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
                Dim StrMsg As String = D4010.JobCard

                StrMsg = StrMsg.ToUpper

                If chk_Size.Checked = False Then
                    If PFK4073_CheckTest = False Then PrcExeNoError("USP_PFK4073_INSERT_AUTO_SlNoD_NEWCONCEPT", cn, txt_cdSeason.Code, cdFactory, cdMainProcess, cdLineProd, StrMsg)
                    If PFK4073_CheckTest = True Then PrcExeNoError("USP_PFK4073_INSERT_AUTO_SlNoD_NEWCONCEPT_CONCEPT1", cn, txt_cdSeason.Code, cdFactory, cdMainProcess, cdLineProd, StrMsg)

                    Call LINE_MOVE_DISPLAY01(vS1, vS1.ActiveSheet.ActiveColumnIndex, vS1.ActiveSheet.ActiveRowIndex, cdLineProd)

                    Me.Show()
                    Application.DoEvents()
                    vS1.Select()
                    vS1.ActiveSheet.ActiveRowIndex = xRow
                    vS1.ActiveSheet.ActiveColumnIndex = xCol

                ElseIf chk_Size.Checked = True Then
                    If PFK4073_CheckTest = False Then LineTno = PrcExeNoError_Value("USP_PFK4073_INSERT_AUTO_SlNoD_SizeCheck_NEWCONCEPT", cn, txt_cdSeason.Code, cdFactory, cdMainProcess, cdLineProd, StrMsg)
                    If PFK4073_CheckTest = True Then LineTno = PrcExeNoError_Value("USP_PFK4073_INSERT_AUTO_SlNoD_SizeCheck_NEWCONCEPT_CONCEPT1", cn, txt_cdSeason.Code, cdFactory, cdMainProcess, cdLineProd, StrMsg)

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
        If chk_State.Checked Then

        End If


        If e.ColumnHeader = True Or e.RowHeader = True Then Exit Sub
        If e.Button = Windows.Forms.MouseButtons.Left Then
            DATA_SEARCH_ALL()
            vS1.ActiveSheet.AddSelection(e.Row, e.Column, 1, 1)
        End If
    End Sub

    Private Sub vS31_CellClick(sender As Object, e As CellClickEventArgs) Handles vS31.CellClick
        If e.ColumnHeader = True Or e.RowHeader = True Then Exit Sub
        If e.Button = Windows.Forms.MouseButtons.Left Then
            vS31.ActiveSheet.AddSelection(e.Row, e.Column, 1, 1)
            DATA_SEARCH_VS32()
            DATA_SEARCH_VS33()
        End If

    End Sub
    Private Sub vS1_GotFocus(sender As Object, e As EventArgs) Handles vS1.GotFocus

        'Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False, WordConv("INPUT") & "(F5)", WordConv("SEARCH") & "(F6)", WordConv("CHANGE") & "(F7)", WordConv("DELETE") & "(F8)")

    End Sub
    Private Sub txt_GNAME_KeyDown(sender As Object, e As KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.Enter : cmd_SEARCH.Focus()
        End Select
    End Sub

    Private Sub vS1_KeyDown(sender As Object, e As KeyEventArgs) Handles vS1.KeyDown

        If chk_State.Checked Then
            If e.Control = True And e.KeyCode = Keys.F1 Then
                If ColorDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Msg_Result = MsgBoxP("Change color ?", vbYesNo)
                    If Msg_Result <> vbYes Then Exit Sub

                    If READ_PFK7106(getCell(vS1, vS1.ActiveSheet.ActiveColumnIndex, vS1.ActiveSheet.ActiveRowIndex)) Then
                        Call PrcExeNoError("USP_PFP40730_BACKCOLOR_UPDATE", cn, D7106.ShoesCode, ColorDialog.Color.R.ToString & "-" & ColorDialog.Color.G.ToString & "-" & ColorDialog.Color.B.ToString)
                        vS1.ActiveSheet.Cells(vS1.ActiveSheet.ActiveRowIndex, vS1.ActiveSheet.ActiveColumnIndex).BackColor = ColorDialog.Color
                    End If

                End If

            End If

        End If


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
                        If PFK4073_CheckTest = False Then PrcExeNoError("USP_PFK4073_INSERT_AUTO_SlNoD_NEWCONCEPT", cn, txt_cdSeason.Code, cdFactory, cdMainProcess, cdLineProd, StrMsg)
                        If PFK4073_CheckTest = True Then PrcExeNoError("USP_PFK4073_INSERT_AUTO_SlNoD_NEWCONCEPT_CONCEPT1", cn, txt_cdSeason.Code, cdFactory, cdMainProcess, cdLineProd, StrMsg)

                        Call LINE_MOVE_DISPLAY01(vS1, vS1.ActiveSheet.ActiveColumnIndex, vS1.ActiveSheet.ActiveRowIndex, cdLineProd)

                        Me.Show()
                        Application.DoEvents()
                        vS1.Select()
                        vS1.ActiveSheet.ActiveRowIndex = xRow
                        vS1.ActiveSheet.ActiveColumnIndex = xCol

                    ElseIf chk_Size.Checked = True Then
                        If PFK4073_CheckTest = False Then LineTno = PrcExeNoError_Value("USP_PFK4073_INSERT_AUTO_SlNoD_SizeCheck_NEWCONCEPT", cn, txt_cdSeason.Code, cdFactory, cdMainProcess, cdLineProd, StrMsg)
                        If PFK4073_CheckTest = True Then LineTno = PrcExeNoError_Value("USP_PFK4073_INSERT_AUTO_SlNoD_SizeCheck_NEWCONCEPT_CONCEPT1", cn, txt_cdSeason.Code, cdFactory, cdMainProcess, cdLineProd, StrMsg)

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


                Else
                    MsgBoxP("Wrong Sealno ! (Sai số seal)", vbInformation)

                End If
            End If

        End If
    End Sub
    Private Sub vS1_LostFocus(sender As Object, e As EventArgs) Handles vS1.LostFocus

        'Call TOOLBAR_CHECKSHOW(ToolStrip1, True, False, False, False, False, False, WordConv("INPUT") & "(F5)")

    End Sub

    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        Dim cdMachineType As String
        If chk_State.Checked = True Then
            Call DATA_SEARCH01_STATE(cdMachineType)
            Exit Sub
        End If


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

            'cdFactory = txt_cdFactory.Code
            'cdMainProcess = txt_cdMainProcess.Code
            'cdLineProd = getData(vS1, getColumIndex(vS1, "cdLineProd"), vS1.ActiveSheet.ActiveRowIndex)
            'LineTno = getData(vS1, getColumIndex(vS1, "LineTno"), vS1.ActiveSheet.ActiveRowIndex)


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

        ElseIf Cms_2.Items(1).Selected = True Then
            Cms_2.Hide()
            MAIN_JOB02() '1

        ElseIf Cms_2.Items(2).Selected = True Then
            Cms_2.Hide()
            MAIN_JOB03() '2

        ElseIf Cms_2.Items(3).Selected = True Then
            Cms_2.Hide()
            MAIN_JOB04() '3

        ElseIf Cms_2.Items(5).Selected = True Then
            Cms_2.Hide()
            MAIN_JOB05() '4

        ElseIf Cms_2.Items(6).Selected = True Then
            Cms_2.Hide()
            MAIN_JOB06() '4  approval control

        ElseIf Cms_2.Items(7).Selected = True Then
            Cms_2.Hide()
            MAIN_JOB15() '7  UPDATE PRODUCTION PLAN

        End If
    End Sub

    Private Sub PFP40730_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If SizeChk = False Then Exit Sub
        Try
            If Me.Width > 20 Then
                ptc_1.ItemSize = New Size((ptc_1.Width - 10) / ptc_1.TabCount, 30)

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

        Psc_0.Panel2Collapsed = True

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


    Private Sub vS32_CellClick(sender As Object, e As CellClickEventArgs) Handles vS32.CellClick

    End Sub

    Private cHKa4 As Boolean = False

    Private Sub vS32_KeyDown(sender As Object, e As KeyEventArgs) Handles vS32.KeyDown
        If chk_test.Checked = False Then

            If e.KeyCode = Keys.P Then
                Dim Msg_Result As String
                Dim i As Integer
                Dim j As Integer

                Dim Cnt As Integer
                Dim cdFactory As String
                Dim cdLineProd As String
                Dim LineTno As String

                cdFactory = txt_cdFactory.Code

                cdLineProd = getCellRH(vS1, 0, vS1.ActiveSheet.ActiveRowIndex)

                Dim cdMainProcess As String
                cdMainProcess = txt_cdMainProcess.Code
                LineTno = vS1.ActiveSheet.ColumnHeader.Cells(0, vS1.ActiveSheet.ActiveColumnIndex).Value

                If cdFactory = "" Or cdLineProd = "" Or LineTno = "" Then Exit Sub

                SLNoD = ""
                Article = ""
                Line = ""
                ColorName = ""

                Try
                    Msg_Result = MsgBoxP("TAG PRINT?", vbYesNo)
                    If Msg_Result = vbYes Then

                        DS2 = PrcDS("USP_ISUD4073B_SEARCH_HEAD", cn, txt_cdFactory.Code, txt_cdMainProcess.Code, cdLineProd, LineTno)

                        If GetDsRc(DS2) = 0 Then Exit Sub

                        SLNoD = GetDsData(DS2, 0, "SLNoD")
                        Article = GetDsData(DS2, 0, "Article")
                        Line = GetDsData(DS2, 0, "Line")
                        ColorName = GetDsData(DS2, 0, "ColorName")

                        For i = 0 To vS32.ActiveSheet.RowCount - 1 Step 4
                            If getDataM(vS32, getColumIndex(vS32, "DCHK"), i) = "1" Then

                                Call DATA_MOVE_BARCODE_01(getData(vS32, getColumIndex(vS32, "BatchNo"), i), getData(vS32, getColumIndex(vS32, "BatchNo"), i + 1))
                                Call DATA_MOVE_BARCODE_02(getData(vS32, getColumIndex(vS32, "BatchNo"), i + 2), getData(vS32, getColumIndex(vS32, "BatchNo"), i + 3))

                                Call DATA_MOVE_BARCODE()

                                STITCHINGPANEL1 = Nothing
                                STITCHINGPANEL2 = Nothing
                                STITCHINGPANEL3 = Nothing
                                STITCHINGPANEL4 = Nothing

                            End If
                        Next

                    End If
                Catch ex As Exception
                    MsgBoxP("DATA_MOVE_BARCODE")
                End Try

            ElseIf e.KeyCode = Keys.F Then
                Dim Msg_Result As String
                Dim i As Integer
                Dim j As Integer

                Dim Cnt As Integer
                Dim cdFactory As String
                Dim cdLineProd As String
                Dim LineTno As String

                cdFactory = txt_cdFactory.Code

                cdLineProd = getCellRH(vS1, 0, vS1.ActiveSheet.ActiveRowIndex)

                Dim cdMainProcess As String
                cdMainProcess = txt_cdMainProcess.Code
                LineTno = vS1.ActiveSheet.ColumnHeader.Cells(0, vS1.ActiveSheet.ActiveColumnIndex).Value

                If cdFactory = "" Or cdLineProd = "" Or LineTno = "" Then Exit Sub

                SLNoD = ""
                Article = ""
                Line = ""
                ColorName = ""

                Try
                    Msg_Result = MsgBoxP("TAG PRINT?", vbYesNo)
                    If Msg_Result = vbYes Then

                        Dim StrMsg = MsgBox("NO PRINT?", vbYesNo)
                        If StrMsg = vbYes Then Exit Sub

                        DS2 = PrcDS("USP_ISUD4073B_SEARCH_HEAD", cn, txt_cdFactory.Code, txt_cdMainProcess.Code, cdLineProd, LineTno)

                        If GetDsRc(DS2) = 0 Then Exit Sub

                        SLNoD = GetDsData(DS2, 0, "SLNoD")
                        Article = GetDsData(DS2, 0, "Article")
                        Line = GetDsData(DS2, 0, "Line")
                        ColorName = GetDsData(DS2, 0, "ColorName")

                        For j = 0 To vS31.ActiveSheet.RowCount - 1

                            Call DATA_SEARCH_VS32_xrow(j)

                            For i = 0 To vS32.ActiveSheet.RowCount - 1 Step 4

                                Call DATA_MOVE_BARCODE_01(getData(vS32, getColumIndex(vS32, "BatchNo"), i), getData(vS32, getColumIndex(vS32, "BatchNo"), i + 1))
                                Call DATA_MOVE_BARCODE_02(getData(vS32, getColumIndex(vS32, "BatchNo"), i + 2), getData(vS32, getColumIndex(vS32, "BatchNo"), i + 3))

                                Call DATA_MOVE_BARCODE()

                                STITCHINGPANEL1 = Nothing
                                STITCHINGPANEL2 = Nothing
                                STITCHINGPANEL3 = Nothing
                                STITCHINGPANEL4 = Nothing
                            Next

                        Next

                    End If
                Catch ex As Exception
                    MsgBoxP("DATA_MOVE_BARCODE")
                End Try


            ElseIf e.KeyCode = Keys.A And e.Alt = True Then
                Dim Msg_Result As String
                Dim i As Integer
                Dim j As Integer

                Dim Cnt As Integer
                Dim cdFactory As String
                Dim cdLineProd As String
                Dim LineTno As String

                cdFactory = txt_cdFactory.Code

                cdLineProd = getCellRH(vS1, 0, vS1.ActiveSheet.ActiveRowIndex)

                Dim cdMainProcess As String
                cdMainProcess = txt_cdMainProcess.Code
                LineTno = vS1.ActiveSheet.ColumnHeader.Cells(0, vS1.ActiveSheet.ActiveColumnIndex).Value

                If cdFactory = "" Or cdLineProd = "" Or LineTno = "" Then Exit Sub

                SLNoD = ""
                Article = ""
                Line = ""
                ColorName = ""

                Try
                    Msg_Result = MsgBoxP("TAG PRINT?", vbYesNo)
                    If Msg_Result = vbYes Then

                        Dim StrMsg = MsgBox("NO PRINT?", vbYesNo)
                        If StrMsg = vbYes Then Exit Sub

                        DS2 = PrcDS("USP_ISUD4073B_SEARCH_HEAD", cn, txt_cdFactory.Code, txt_cdMainProcess.Code, cdLineProd, LineTno)

                        If GetDsRc(DS2) = 0 Then Exit Sub

                        SLNoD = GetDsData(DS2, 0, "SLNoD")
                        Article = GetDsData(DS2, 0, "Article")
                        Line = GetDsData(DS2, 0, "Line")
                        ColorName = GetDsData(DS2, 0, "ColorName")

                        For j = 0 To vS31.ActiveSheet.RowCount - 1

                            Call DATA_SEARCH_VS32_xrow(j)

                            For i = 0 To vS32.ActiveSheet.RowCount - 1
                                If STITCHINGPANEL_LIST.Count = 64 Then
                                    cHKa4 = True
                                    Call DATA_MOVE_BARCODE_A4()
                                    STITCHINGPANEL_LIST.Clear()
                                End If


                                If STITCHINGPANEL_LIST.Count < 64 Then
                                    Call DATA_MOVE_BARCODE_A4_ONE(getData(vS32, getColumIndex(vS32, "BatchNo"), i))


                                End If


                            Next

                        Next

                        cHKa4 = True : Call DATA_MOVE_BARCODE_A4() : STITCHINGPANEL_LIST.Clear()

                    End If
                Catch ex As Exception
                    MsgBoxP("DATA_MOVE_BARCODE")
                End Try

            End If


        Else

            '''''' NEW CONCEPT WITH 1 BARCODE

            If e.KeyCode = Keys.P Then
                Dim Msg_Result As String
                Dim i As Integer
                Dim j As Integer

                Dim Cnt As Integer
                Dim cdFactory As String
                Dim cdLineProd As String
                Dim LineTno As String

                cdFactory = txt_cdFactory.Code

                cdLineProd = getCellRH(vS1, 0, vS1.ActiveSheet.ActiveRowIndex)

                Dim cdMainProcess As String
                cdMainProcess = txt_cdMainProcess.Code
                LineTno = vS1.ActiveSheet.ColumnHeader.Cells(0, vS1.ActiveSheet.ActiveColumnIndex).Value

                If cdFactory = "" Or cdLineProd = "" Or LineTno = "" Then Exit Sub

                SLNoD = ""
                Article = ""
                Line = ""
                ColorName = ""

                Try
                    Msg_Result = MsgBoxP("TAG PRINT?", vbYesNo)
                    If Msg_Result = vbYes Then

                        DS2 = PrcDS("USP_ISUD4073B_SEARCH_HEAD", cn, txt_cdFactory.Code, txt_cdMainProcess.Code, cdLineProd, LineTno)

                        If GetDsRc(DS2) = 0 Then Exit Sub

                        SLNoD = GetDsData(DS2, 0, "SLNoD")
                        Article = GetDsData(DS2, 0, "Article")
                        Line = GetDsData(DS2, 0, "Line")
                        ColorName = GetDsData(DS2, 0, "ColorName")

                        For i = 0 To vS32.ActiveSheet.RowCount - 1 Step 2
                            If getDataM(vS32, getColumIndex(vS32, "DCHK"), i) = "1" Then

                                Call DATA_MOVE_BARCODE_01_CONCEPT1(getData(vS32, getColumIndex(vS32, "BatchNo"), i), getData(vS32, getColumIndex(vS32, "BatchNo"), i))
                                Call DATA_MOVE_BARCODE_02_CONCEPT1(getData(vS32, getColumIndex(vS32, "BatchNo"), i + 1), getData(vS32, getColumIndex(vS32, "BatchNo"), i + 1))

                                Call DATA_MOVE_BARCODE()

                                STITCHINGPANEL1 = Nothing
                                STITCHINGPANEL2 = Nothing
                                STITCHINGPANEL3 = Nothing
                                STITCHINGPANEL4 = Nothing

                            End If
                        Next

                    End If
                Catch ex As Exception
                    MsgBoxP("DATA_MOVE_BARCODE")
                End Try

            ElseIf e.KeyCode = Keys.F Then
                Dim Msg_Result As String
                Dim i As Integer
                Dim j As Integer

                Dim Cnt As Integer
                Dim cdFactory As String
                Dim cdLineProd As String
                Dim LineTno As String

                cdFactory = txt_cdFactory.Code

                cdLineProd = getCellRH(vS1, 0, vS1.ActiveSheet.ActiveRowIndex)

                Dim cdMainProcess As String
                cdMainProcess = txt_cdMainProcess.Code
                LineTno = vS1.ActiveSheet.ColumnHeader.Cells(0, vS1.ActiveSheet.ActiveColumnIndex).Value

                If cdFactory = "" Or cdLineProd = "" Or LineTno = "" Then Exit Sub

                SLNoD = ""
                Article = ""
                Line = ""
                ColorName = ""

                Try
                    Msg_Result = MsgBoxP("TAG PRINT?", vbYesNo)
                    If Msg_Result = vbYes Then

                        Dim StrMsg = MsgBox("NO PRINT?", vbYesNo)
                        If StrMsg = vbYes Then Exit Sub

                        DS2 = PrcDS("USP_ISUD4073B_SEARCH_HEAD", cn, txt_cdFactory.Code, txt_cdMainProcess.Code, cdLineProd, LineTno)

                        If GetDsRc(DS2) = 0 Then Exit Sub

                        SLNoD = GetDsData(DS2, 0, "SLNoD")
                        Article = GetDsData(DS2, 0, "Article")
                        Line = GetDsData(DS2, 0, "Line")
                        ColorName = GetDsData(DS2, 0, "ColorName")

                        For j = 0 To vS31.ActiveSheet.RowCount - 1

                            Call DATA_SEARCH_VS32_xrow(j)

                            For i = 0 To vS32.ActiveSheet.RowCount - 1 Step 2

                                Call DATA_MOVE_BARCODE_01_CONCEPT1(getData(vS32, getColumIndex(vS32, "BatchNo"), i), getData(vS32, getColumIndex(vS32, "BatchNo"), i))
                                Call DATA_MOVE_BARCODE_02_CONCEPT1(getData(vS32, getColumIndex(vS32, "BatchNo"), i + 1), getData(vS32, getColumIndex(vS32, "BatchNo"), i + 1))

                                Call DATA_MOVE_BARCODE()

                                STITCHINGPANEL1 = Nothing
                                STITCHINGPANEL2 = Nothing
                                STITCHINGPANEL3 = Nothing
                                STITCHINGPANEL4 = Nothing
                            Next

                        Next

                    End If
                Catch ex As Exception
                    MsgBoxP("DATA_MOVE_BARCODE")
                End Try


            ElseIf e.KeyCode = Keys.A And e.Alt = True Then
                Dim Msg_Result As String
                Dim i As Integer
                Dim j As Integer

                Dim Cnt As Integer
                Dim cdFactory As String
                Dim cdLineProd As String
                Dim LineTno As String

                cdFactory = txt_cdFactory.Code

                cdLineProd = getCellRH(vS1, 0, vS1.ActiveSheet.ActiveRowIndex)

                Dim cdMainProcess As String
                cdMainProcess = txt_cdMainProcess.Code
                LineTno = vS1.ActiveSheet.ColumnHeader.Cells(0, vS1.ActiveSheet.ActiveColumnIndex).Value

                If cdFactory = "" Or cdLineProd = "" Or LineTno = "" Then Exit Sub

                SLNoD = ""
                Article = ""
                Line = ""
                ColorName = ""

                Try
                    Msg_Result = MsgBoxP("TAG PRINT?", vbYesNo)
                    If Msg_Result = vbYes Then

                        Dim StrMsg = MsgBox("NO PRINT?", vbYesNo)
                        If StrMsg = vbYes Then Exit Sub

                        DS2 = PrcDS("USP_ISUD4073B_SEARCH_HEAD", cn, txt_cdFactory.Code, txt_cdMainProcess.Code, cdLineProd, LineTno)

                        If GetDsRc(DS2) = 0 Then Exit Sub

                        SLNoD = GetDsData(DS2, 0, "SLNoD")
                        Article = GetDsData(DS2, 0, "Article")
                        Line = GetDsData(DS2, 0, "Line")
                        ColorName = GetDsData(DS2, 0, "ColorName")

                        For j = 0 To vS31.ActiveSheet.RowCount - 1

                            Call DATA_SEARCH_VS32_xrow(j)

                            For i = 0 To vS32.ActiveSheet.RowCount - 1
                                If STITCHINGPANEL_LIST.Count = 64 Then
                                    cHKa4 = True
                                    Call DATA_MOVE_BARCODE_A4()
                                    STITCHINGPANEL_LIST.Clear()
                                End If


                                If STITCHINGPANEL_LIST.Count < 64 Then
                                    Call DATA_MOVE_BARCODE_A4_ONE(getData(vS32, getColumIndex(vS32, "BatchNo"), i))


                                End If


                            Next

                        Next

                        cHKa4 = True : Call DATA_MOVE_BARCODE_A4() : STITCHINGPANEL_LIST.Clear()

                    End If
                Catch ex As Exception
                    MsgBoxP("DATA_MOVE_BARCODE")
                End Try

            End If


        End If



    End Sub
    Private Sub vS33_KeyDown(sender As Object, e As KeyEventArgs) Handles vS33.KeyDown
        If e.KeyCode = Keys.P Then
            Dim Msg_Result As String
            Dim i As Integer
            Dim j As Integer

            Dim Cnt As Integer
            Dim cdFactory As String
            Dim cdLineProd As String
            Dim LineTno As String

            cdFactory = txt_cdFactory.Code

            cdLineProd = getCellRH(vS1, 0, vS1.ActiveSheet.ActiveRowIndex)

            Dim cdMainProcess As String
            cdMainProcess = txt_cdMainProcess.Code
            LineTno = vS1.ActiveSheet.ColumnHeader.Cells(0, vS1.ActiveSheet.ActiveColumnIndex).Value

            If cdFactory = "" Or cdLineProd = "" Or LineTno = "" Then Exit Sub

            SLNoD = ""
            Article = ""
            Line = ""
            ColorName = ""

            Try
                Msg_Result = MsgBoxP("TAG PRINT?", vbYesNo)
                If Msg_Result = vbYes Then

                    DS2 = PrcDS("USP_ISUD4073B_SEARCH_HEAD", cn, txt_cdFactory.Code, txt_cdMainProcess.Code, cdLineProd, LineTno)

                    If GetDsRc(DS2) = 0 Then Exit Sub

                    SLNoD = GetDsData(DS2, 0, "SLNoD")
                    Article = GetDsData(DS2, 0, "Article")
                    Line = GetDsData(DS2, 0, "Line")
                    ColorName = GetDsData(DS2, 0, "ColorName")

                    For i = 0 To vS33.ActiveSheet.RowCount - 1 Step 4
                        If getDataM(vS33, getColumIndex(vS33, "DCHK"), i) = "1" Then

                            Call DATA_MOVE_BARCODE_01(getData(vS33, getColumIndex(vS33, "BatchNo"), i), getData(vS33, getColumIndex(vS33, "BatchNo"), i + 1))
                            Call DATA_MOVE_BARCODE_02(getData(vS33, getColumIndex(vS33, "BatchNo"), i + 2), getData(vS33, getColumIndex(vS33, "BatchNo"), i + 3))

                            Call DATA_MOVE_BARCODE()

                            STITCHINGPANEL1 = Nothing
                            STITCHINGPANEL2 = Nothing
                            STITCHINGPANEL3 = Nothing
                            STITCHINGPANEL4 = Nothing

                        End If
                    Next

                End If
            Catch ex As Exception
                MsgBoxP("DATA_MOVE_BARCODE")
            End Try

        End If
    End Sub
    Public Sub DATA_MOVE_BARCODE_01(BatchNo1 As String, BatchNo2 As String)
        If READ_PFK4075_BatchNo(BatchNo1) Then
            If D4075.DatePrint = "" Then
                D4075.DatePrint = Pub.DAT
                D4075.InchargePrint = Pub.SAW
                Call REWRITE_PFK4075_BATCHNO(D4075)
            Else
                D4075.Remark = Pub.DAT & Pub.SAW
                D4075.QtyBLIn = D4075.QtyBLIn + 1
                Call REWRITE_PFK4075_BATCHNO(D4075)
            End If

            STITCHINGPANEL1.cdFactory = D4075.cdFactory
            STITCHINGPANEL1.cdProdLine = D4075.cdLineProd

            STITCHINGPANEL1.QtyBatch = D4075.QtyBatch
            STITCHINGPANEL1.QtyProd = D4075.QtyProduction

            STITCHINGPANEL1.SizeName = D4075.SizeName

            STITCHINGPANEL1.JobCard = SLNoD
            STITCHINGPANEL1.BarcodeSeq = D4075.BatchNo

            STITCHINGPANEL1.Article = Article
            STITCHINGPANEL1.Line = Line

            If STITCHINGPANEL1.Line.Length > 10 Then STITCHINGPANEL1.Line = STITCHINGPANEL1.Line.Substring(1, 10)

            STITCHINGPANEL1.Color = ColorName

            STITCHINGPANEL1.DatePrint = Pub.DAT
            STITCHINGPANEL1.SealNo = SLNoD
            STITCHINGPANEL1.Barcode = D4075.BatchNo
            STITCHINGPANEL1.NumBer = D4075.Sno

            If (CIntp(D4075.Sno) Mod 2) = 0 Then STITCHINGPANEL1.Sno = CIntp(D4075.Sno) / 2
            If (CIntp(D4075.Sno) Mod 2) = 1 Then STITCHINGPANEL1.Sno = (CIntp(D4075.Sno) + 1) / 2

            If D4075.CheckL = "1" Then STITCHINGPANEL1.Position = "L" Else STITCHINGPANEL1.Position = "R"
        End If

        If READ_PFK4075_BatchNo(BatchNo2) Then
            If D4075.DatePrint = "" Then
                D4075.DatePrint = Pub.DAT
                D4075.InchargePrint = Pub.SAW
                Call REWRITE_PFK4075_BATCHNO(D4075)
            Else
                D4075.Remark = Pub.DAT & Pub.SAW
                D4075.QtyBLIn = D4075.QtyBLIn + 1
                Call REWRITE_PFK4075_BATCHNO(D4075)
            End If

            STITCHINGPANEL2.cdFactory = D4075.cdFactory
            STITCHINGPANEL2.cdProdLine = D4075.cdLineProd

            STITCHINGPANEL2.SizeName = D4075.SizeName
            STITCHINGPANEL2.QtyBatch = D4075.QtyBatch
            STITCHINGPANEL2.QtyProd = D4075.QtyProduction

            STITCHINGPANEL2.JobCard = SLNoD
            STITCHINGPANEL2.BarcodeSeq = D4075.BatchNo

            STITCHINGPANEL2.Article = Article
            STITCHINGPANEL2.Line = Line

            If STITCHINGPANEL2.Line.Length > 10 Then STITCHINGPANEL2.Line = STITCHINGPANEL2.Line.Substring(1, 10)

            STITCHINGPANEL2.Color = ColorName

            STITCHINGPANEL2.DatePrint = Pub.DAT
            STITCHINGPANEL2.SealNo = SLNoD
            STITCHINGPANEL2.Barcode = D4075.BatchNo
            STITCHINGPANEL2.NumBer = D4075.Sno

            If (CIntp(D4075.Sno) Mod 2) = 0 Then STITCHINGPANEL2.Sno = CIntp(D4075.Sno) / 2
            If (CIntp(D4075.Sno) Mod 2) = 1 Then STITCHINGPANEL2.Sno = (CIntp(D4075.Sno) + 1) / 2

            If D4075.CheckL = "1" Then STITCHINGPANEL2.Position = "L" Else STITCHINGPANEL2.Position = "R"
        End If

    End Sub


    Public Sub DATA_MOVE_BARCODE_01_CONCEPT1(BatchNo1 As String, BatchNo2 As String)
        If READ_PFK4075_BatchNo(BatchNo1) Then
            If D4075.DatePrint = "" Then
                D4075.DatePrint = Pub.DAT
                D4075.InchargePrint = Pub.SAW
                Call REWRITE_PFK4075_BATCHNO(D4075)
            Else
                D4075.Remark = Pub.DAT & Pub.SAW
                D4075.QtyBLIn = D4075.QtyBLIn + 1
                Call REWRITE_PFK4075_BATCHNO(D4075)
            End If

            STITCHINGPANEL1.cdFactory = D4075.cdFactory
            STITCHINGPANEL1.cdProdLine = D4075.cdLineProd

            STITCHINGPANEL1.QtyBatch = CIntp(D4075.Sno)
            STITCHINGPANEL1.QtyProd = D4075.QtyProduction

            STITCHINGPANEL1.SizeName = D4075.SizeName

            STITCHINGPANEL1.JobCard = SLNoD
            STITCHINGPANEL1.BarcodeSeq = D4075.BatchNo

            STITCHINGPANEL1.Article = Article
            STITCHINGPANEL1.Line = Line

            If STITCHINGPANEL1.Line.Length > 10 Then STITCHINGPANEL1.Line = STITCHINGPANEL1.Line.Substring(1, 10)

            STITCHINGPANEL1.Color = ColorName

            STITCHINGPANEL1.DatePrint = Pub.DAT
            STITCHINGPANEL1.SealNo = SLNoD
            STITCHINGPANEL1.Barcode = D4075.BatchNo
            STITCHINGPANEL1.NumBer = D4075.Sno

            If (CIntp(D4075.Sno) Mod 2) = 0 Then STITCHINGPANEL1.Sno = CIntp(D4075.Sno) / 2
            If (CIntp(D4075.Sno) Mod 2) = 1 Then STITCHINGPANEL1.Sno = (CIntp(D4075.Sno) + 1) / 2

            If D4075.CheckL = "1" Then STITCHINGPANEL1.Position = "L" Else STITCHINGPANEL1.Position = "R"
        End If

        If READ_PFK4075_BatchNo(BatchNo2) Then
            If D4075.DatePrint = "" Then
                D4075.DatePrint = Pub.DAT
                D4075.InchargePrint = Pub.SAW
                Call REWRITE_PFK4075_BATCHNO(D4075)
            Else
                D4075.Remark = Pub.DAT & Pub.SAW
                D4075.QtyBLIn = D4075.QtyBLIn + 1
                Call REWRITE_PFK4075_BATCHNO(D4075)
            End If

            STITCHINGPANEL2.cdFactory = D4075.cdFactory
            STITCHINGPANEL2.cdProdLine = D4075.cdLineProd

            STITCHINGPANEL2.SizeName = D4075.SizeName
            STITCHINGPANEL2.QtyBatch = CIntp(D4075.Sno)
            STITCHINGPANEL2.QtyProd = D4075.QtyProduction

            STITCHINGPANEL2.JobCard = SLNoD
            STITCHINGPANEL2.BarcodeSeq = D4075.BatchNo

            STITCHINGPANEL2.Article = Article
            STITCHINGPANEL2.Line = Line

            If STITCHINGPANEL2.Line.Length > 10 Then STITCHINGPANEL2.Line = STITCHINGPANEL2.Line.Substring(1, 10)

            STITCHINGPANEL2.Color = ColorName

            STITCHINGPANEL2.DatePrint = Pub.DAT
            STITCHINGPANEL2.SealNo = SLNoD
            STITCHINGPANEL2.Barcode = D4075.BatchNo
            STITCHINGPANEL2.NumBer = D4075.Sno

            If (CIntp(D4075.Sno) Mod 2) = 0 Then STITCHINGPANEL2.Sno = CIntp(D4075.Sno) / 2
            If (CIntp(D4075.Sno) Mod 2) = 1 Then STITCHINGPANEL2.Sno = (CIntp(D4075.Sno) + 1) / 2

            If D4075.CheckL = "1" Then STITCHINGPANEL2.Position = "L" Else STITCHINGPANEL2.Position = "R"
        End If

    End Sub


    Public Sub DATA_MOVE_BARCODE_A4_ONE(BatchNo1 As String)
        If READ_PFK4075_BatchNo(BatchNo1) Then
            If D4075.DatePrint = "" Then
                D4075.DatePrint = Pub.DAT
                D4075.InchargePrint = Pub.SAW
                Call REWRITE_PFK4075_BATCHNO(D4075)
            Else
                D4075.Remark = Pub.DAT & Pub.SAW
                D4075.QtyBLIn = D4075.QtyBLIn + 1
                Call REWRITE_PFK4075_BATCHNO(D4075)
            End If

            STITCHINGPANEL0 = Nothing

            STITCHINGPANEL0.cdFactory = D4075.cdFactory
            STITCHINGPANEL0.cdProdLine = D4075.cdLineProd

            STITCHINGPANEL0.QtyBatch = D4075.QtyBatch
            STITCHINGPANEL0.QtyProd = D4075.QtyProduction

            STITCHINGPANEL0.SizeName = D4075.SizeName

            STITCHINGPANEL0.JobCard = SLNoD
            STITCHINGPANEL0.BarcodeSeq = D4075.BatchNo

            STITCHINGPANEL0.Article = Article
            STITCHINGPANEL0.Line = Line

            If STITCHINGPANEL0.Line.Length > 10 Then STITCHINGPANEL0.Line = STITCHINGPANEL0.Line.Substring(1, 10)

            STITCHINGPANEL0.Color = ColorName

            STITCHINGPANEL0.DatePrint = Pub.DAT
            STITCHINGPANEL0.SealNo = SLNoD
            STITCHINGPANEL0.Barcode = D4075.BatchNo
            STITCHINGPANEL0.NumBer = D4075.Sno

            If (CIntp(D4075.Sno) Mod 2) = 0 Then STITCHINGPANEL0.Sno = CIntp(D4075.Sno) / 2
            If (CIntp(D4075.Sno) Mod 2) = 1 Then STITCHINGPANEL0.Sno = (CIntp(D4075.Sno) + 1) / 2

            If D4075.CheckL = "1" Then STITCHINGPANEL0.Position = "L" Else STITCHINGPANEL0.Position = "R"

            STITCHINGPANEL_LIST.Add(STITCHINGPANEL0)

        End If


    End Sub

    Public Sub DATA_MOVE_BARCODE_02(BatchNo3 As String, BatchNo4 As String)
        If READ_PFK4075_BatchNo(BatchNo3) Then
            If D4075.DatePrint = "" Then
                D4075.DatePrint = Pub.DAT
                D4075.InchargePrint = Pub.SAW
                Call REWRITE_PFK4075_BATCHNO(D4075)
            Else
                D4075.Remark = Pub.DAT & Pub.SAW
                D4075.QtyBLIn = D4075.QtyBLIn + 1
                Call REWRITE_PFK4075_BATCHNO(D4075)
            End If

            STITCHINGPANEL3.cdFactory = D4075.cdFactory
            STITCHINGPANEL3.cdProdLine = D4075.cdLineProd

            STITCHINGPANEL3.SizeName = D4075.SizeName
            STITCHINGPANEL3.QtyBatch = D4075.QtyBatch
            STITCHINGPANEL3.QtyProd = D4075.QtyProduction

            STITCHINGPANEL3.JobCard = SLNoD
            STITCHINGPANEL3.BarcodeSeq = D4075.BatchNo

            STITCHINGPANEL3.Article = Article
            STITCHINGPANEL3.Line = Line

            If STITCHINGPANEL3.Line.Length > 10 Then STITCHINGPANEL3.Line = STITCHINGPANEL3.Line.Substring(1, 10)

            STITCHINGPANEL3.Color = ColorName

            STITCHINGPANEL3.DatePrint = Pub.DAT
            STITCHINGPANEL3.SealNo = SLNoD
            STITCHINGPANEL3.Barcode = D4075.BatchNo
            STITCHINGPANEL3.NumBer = D4075.Sno
            'STITCHINGPANEL3.Sno = CIntp(CDecp(D4075.Sno) / 2)

            If (CIntp(D4075.Sno) Mod 2) = 0 Then STITCHINGPANEL3.Sno = CIntp(D4075.Sno) / 2
            If (CIntp(D4075.Sno) Mod 2) = 1 Then STITCHINGPANEL3.Sno = (CIntp(D4075.Sno) + 1) / 2

            If D4075.CheckL = "1" Then STITCHINGPANEL3.Position = "L" Else STITCHINGPANEL3.Position = "R"
        End If

        If READ_PFK4075_BatchNo(BatchNo4) Then
            If D4075.DatePrint = "" Then
                D4075.DatePrint = Pub.DAT
                D4075.InchargePrint = Pub.SAW
                Call REWRITE_PFK4075_BATCHNO(D4075)
            Else
                D4075.Remark = Pub.DAT & Pub.SAW
                D4075.QtyBLIn = D4075.QtyBLIn + 1
                Call REWRITE_PFK4075_BATCHNO(D4075)
            End If

            STITCHINGPANEL4.cdFactory = D4075.cdFactory
            STITCHINGPANEL4.cdProdLine = D4075.cdLineProd

            STITCHINGPANEL4.SizeName = D4075.SizeName
            STITCHINGPANEL4.QtyBatch = D4075.QtyBatch
            STITCHINGPANEL4.QtyProd = D4075.QtyProduction

            STITCHINGPANEL4.JobCard = SLNoD
            STITCHINGPANEL4.BarcodeSeq = D4075.BatchNo

            STITCHINGPANEL4.Article = Article
            STITCHINGPANEL4.Line = Line

            If STITCHINGPANEL4.Line.Length > 10 Then STITCHINGPANEL4.Line = STITCHINGPANEL4.Line.Substring(1, 10)

            STITCHINGPANEL4.Color = ColorName

            STITCHINGPANEL4.DatePrint = Pub.DAT
            STITCHINGPANEL4.SealNo = SLNoD
            STITCHINGPANEL4.Barcode = D4075.BatchNo
            STITCHINGPANEL4.NumBer = D4075.Sno

            'STITCHINGPANEL4.Sno = CIntp(CDecp(D4075.Sno) / 2)
            If (CIntp(D4075.Sno) Mod 2) = 0 Then STITCHINGPANEL4.Sno = CIntp(D4075.Sno) / 2
            If (CIntp(D4075.Sno) Mod 2) = 1 Then STITCHINGPANEL4.Sno = (CIntp(D4075.Sno) + 1) / 2

            If D4075.CheckL = "1" Then STITCHINGPANEL4.Position = "L" Else STITCHINGPANEL4.Position = "R"
        End If
    End Sub

    Public Sub DATA_MOVE_BARCODE_02_CONCEPT1(BatchNo3 As String, BatchNo4 As String)
        If READ_PFK4075_BatchNo(BatchNo3) Then
            If D4075.DatePrint = "" Then
                D4075.DatePrint = Pub.DAT
                D4075.InchargePrint = Pub.SAW
                Call REWRITE_PFK4075_BATCHNO(D4075)
            Else
                D4075.Remark = Pub.DAT & Pub.SAW
                D4075.QtyBLIn = D4075.QtyBLIn + 1
                Call REWRITE_PFK4075_BATCHNO(D4075)
            End If

            STITCHINGPANEL3.cdFactory = D4075.cdFactory
            STITCHINGPANEL3.cdProdLine = D4075.cdLineProd

            STITCHINGPANEL3.SizeName = D4075.SizeName
            STITCHINGPANEL3.QtyBatch = CIntp(D4075.Sno)
            STITCHINGPANEL3.QtyProd = D4075.QtyProduction

            STITCHINGPANEL3.JobCard = SLNoD
            STITCHINGPANEL3.BarcodeSeq = D4075.BatchNo

            STITCHINGPANEL3.Article = Article
            STITCHINGPANEL3.Line = Line

            If STITCHINGPANEL3.Line.Length > 10 Then STITCHINGPANEL3.Line = STITCHINGPANEL3.Line.Substring(1, 10)

            STITCHINGPANEL3.Color = ColorName

            STITCHINGPANEL3.DatePrint = Pub.DAT
            STITCHINGPANEL3.SealNo = SLNoD
            STITCHINGPANEL3.Barcode = D4075.BatchNo
            STITCHINGPANEL3.NumBer = D4075.Sno
            'STITCHINGPANEL3.Sno = CIntp(CDecp(D4075.Sno) / 2)

            If (CIntp(D4075.Sno) Mod 2) = 0 Then STITCHINGPANEL3.Sno = CIntp(D4075.Sno) / 2
            If (CIntp(D4075.Sno) Mod 2) = 1 Then STITCHINGPANEL3.Sno = (CIntp(D4075.Sno) + 1) / 2

            If D4075.CheckL = "1" Then STITCHINGPANEL3.Position = "L" Else STITCHINGPANEL3.Position = "R"
        End If

        If READ_PFK4075_BatchNo(BatchNo4) Then
            If D4075.DatePrint = "" Then
                D4075.DatePrint = Pub.DAT
                D4075.InchargePrint = Pub.SAW
                Call REWRITE_PFK4075_BATCHNO(D4075)
            Else
                D4075.Remark = Pub.DAT & Pub.SAW
                D4075.QtyBLIn = D4075.QtyBLIn + 1
                Call REWRITE_PFK4075_BATCHNO(D4075)
            End If

            STITCHINGPANEL4.cdFactory = D4075.cdFactory
            STITCHINGPANEL4.cdProdLine = D4075.cdLineProd

            STITCHINGPANEL4.SizeName = D4075.SizeName
            STITCHINGPANEL4.QtyBatch = CIntp(D4075.Sno)
            STITCHINGPANEL4.QtyProd = D4075.QtyProduction

            STITCHINGPANEL4.JobCard = SLNoD
            STITCHINGPANEL4.BarcodeSeq = D4075.BatchNo

            STITCHINGPANEL4.Article = Article
            STITCHINGPANEL4.Line = Line

            If STITCHINGPANEL4.Line.Length > 10 Then STITCHINGPANEL4.Line = STITCHINGPANEL4.Line.Substring(1, 10)

            STITCHINGPANEL4.Color = ColorName

            STITCHINGPANEL4.DatePrint = Pub.DAT
            STITCHINGPANEL4.SealNo = SLNoD
            STITCHINGPANEL4.Barcode = D4075.BatchNo
            STITCHINGPANEL4.NumBer = D4075.Sno

            'STITCHINGPANEL4.Sno = CIntp(CDecp(D4075.Sno) / 2)
            If (CIntp(D4075.Sno) Mod 2) = 0 Then STITCHINGPANEL4.Sno = CIntp(D4075.Sno) / 2
            If (CIntp(D4075.Sno) Mod 2) = 1 Then STITCHINGPANEL4.Sno = (CIntp(D4075.Sno) + 1) / 2

            If D4075.CheckL = "1" Then STITCHINGPANEL4.Position = "L" Else STITCHINGPANEL4.Position = "R"
        End If
    End Sub
    Public Sub DATA_MOVE_BARCODE_03(BatchNo5 As String, BatchNo6 As String)
        If READ_PFK4075_BatchNo(BatchNo5) Then
            STITCHINGPANEL5.cdFactory = D4075.cdFactory
            STITCHINGPANEL5.cdProdLine = D4075.cdLineProd

            STITCHINGPANEL5.SizeName = D4075.SizeName
            STITCHINGPANEL5.QtyBatch = D4075.QtyBatch
            STITCHINGPANEL5.QtyProd = D4075.QtyProduction

            STITCHINGPANEL5.JobCard = SLNoD
            STITCHINGPANEL5.BarcodeSeq = D4075.BatchNo

            STITCHINGPANEL5.Article = Article
            STITCHINGPANEL5.Line = Line

            If STITCHINGPANEL5.Line.Length > 10 Then STITCHINGPANEL5.Line = STITCHINGPANEL5.Line.Substring(1, 10)

            STITCHINGPANEL5.Color = ColorName

            STITCHINGPANEL5.DatePrint = Pub.DAT
            STITCHINGPANEL5.SealNo = SLNoD
            STITCHINGPANEL5.Barcode = D4075.BatchNo

            'STITCHINGPANEL5.Sno = CIntp(CDecp(D4075.Sno) / 2)

            If (CIntp(D4075.Sno) Mod 2) = 0 Then STITCHINGPANEL5.Sno = CIntp(D4075.Sno) / 2
            If (CIntp(D4075.Sno) Mod 2) = 1 Then STITCHINGPANEL5.Sno = (CIntp(D4075.Sno) + 1) / 2
        End If

        If READ_PFK4075_BatchNo(BatchNo6) Then
            STITCHINGPANEL6.cdFactory = D4075.cdFactory
            STITCHINGPANEL6.cdProdLine = D4075.cdLineProd

            STITCHINGPANEL6.SizeName = D4075.SizeName
            STITCHINGPANEL6.QtyBatch = D4075.QtyBatch
            STITCHINGPANEL6.QtyProd = D4075.QtyProduction

            STITCHINGPANEL6.JobCard = SLNoD
            STITCHINGPANEL6.BarcodeSeq = D4075.BatchNo

            STITCHINGPANEL6.Article = Article
            STITCHINGPANEL6.Line = Line

            If STITCHINGPANEL6.Line.Length > 10 Then STITCHINGPANEL6.Line = STITCHINGPANEL6.Line.Substring(1, 10)

            STITCHINGPANEL6.Color = ColorName

            STITCHINGPANEL6.DatePrint = Pub.DAT
            STITCHINGPANEL6.SealNo = SLNoD
            STITCHINGPANEL6.Barcode = D4075.BatchNo

            'STITCHINGPANEL6.Sno = CIntp(CDecp(D4075.Sno) / 2)
            If (CIntp(D4075.Sno) Mod 2) = 0 Then STITCHINGPANEL6.Sno = CIntp(D4075.Sno) / 2
            If (CIntp(D4075.Sno) Mod 2) = 1 Then STITCHINGPANEL6.Sno = (CIntp(D4075.Sno) + 1) / 2
        End If
    End Sub

    Public Sub DATA_MOVE_BARCODE_04(BatchNo3 As String, BatchNo4 As String)
        If READ_PFK4075_BatchNo(BatchNo3) Then
            STITCHINGPANEL7.cdFactory = D4075.cdFactory
            STITCHINGPANEL7.cdProdLine = D4075.cdLineProd

            STITCHINGPANEL7.SizeName = D4075.SizeName
            STITCHINGPANEL7.QtyBatch = D4075.QtyBatch
            STITCHINGPANEL7.QtyProd = D4075.QtyProduction

            STITCHINGPANEL7.JobCard = SLNoD
            STITCHINGPANEL7.BarcodeSeq = D4075.BatchNo

            STITCHINGPANEL7.Article = Article
            STITCHINGPANEL7.Line = Line

            If STITCHINGPANEL7.Line.Length > 10 Then STITCHINGPANEL7.Line = STITCHINGPANEL7.Line.Substring(1, 10)

            STITCHINGPANEL7.Color = ColorName

            STITCHINGPANEL7.DatePrint = Pub.DAT
            STITCHINGPANEL7.SealNo = SLNoD
            STITCHINGPANEL7.Barcode = D4075.BatchNo

            'STITCHINGPANEL7.Sno = CIntp(CDecp(D4075.Sno) / 2)

            If (CIntp(D4075.Sno) Mod 2) = 0 Then STITCHINGPANEL7.Sno = CIntp(D4075.Sno) / 2
            If (CIntp(D4075.Sno) Mod 2) = 1 Then STITCHINGPANEL7.Sno = (CIntp(D4075.Sno) + 1) / 2
        End If

        If READ_PFK4075_BatchNo(BatchNo4) Then
            STITCHINGPANEL8.cdFactory = D4075.cdFactory
            STITCHINGPANEL8.cdProdLine = D4075.cdLineProd

            STITCHINGPANEL8.SizeName = D4075.SizeName
            STITCHINGPANEL8.QtyBatch = D4075.QtyBatch
            STITCHINGPANEL8.QtyProd = D4075.QtyProduction

            STITCHINGPANEL8.JobCard = SLNoD
            STITCHINGPANEL8.BarcodeSeq = D4075.BatchNo

            STITCHINGPANEL8.Article = Article
            STITCHINGPANEL8.Line = Line

            If STITCHINGPANEL8.Line.Length > 10 Then STITCHINGPANEL8.Line = STITCHINGPANEL8.Line.Substring(1, 10)

            STITCHINGPANEL8.Color = ColorName

            STITCHINGPANEL8.DatePrint = Pub.DAT
            STITCHINGPANEL8.SealNo = SLNoD
            STITCHINGPANEL8.Barcode = D4075.BatchNo

            'STITCHINGPANEL8.Sno = CIntp(CDecp(D4075.Sno) / 2)
            If (CIntp(D4075.Sno) Mod 2) = 0 Then STITCHINGPANEL8.Sno = CIntp(D4075.Sno) / 2
            If (CIntp(D4075.Sno) Mod 2) = 1 Then STITCHINGPANEL8.Sno = (CIntp(D4075.Sno) + 1) / 2
        End If
    End Sub
    Private SLNoD As String
    Private Article As String
    Private Line As String
    Private ColorName As String

    Public Sub DATA_MOVE_BARCODE_12(BatchShoes As String)
        If READ_PFK4075_BatchShoes(BatchShoes, "1", "2") Then
            STITCHINGPANEL1.QtyBatch = D4075.QtyBatch
            STITCHINGPANEL1.QtyProd = D4075.QtyProduction

            STITCHINGPANEL1.SizeName = D4075.SizeName

            STITCHINGPANEL1.JobCard = SLNoD
            STITCHINGPANEL1.BarcodeSeq = D4075.BatchNo

            STITCHINGPANEL1.Article = Article
            STITCHINGPANEL1.Line = Line

            If STITCHINGPANEL1.Line.Length > 10 Then STITCHINGPANEL1.Line = STITCHINGPANEL1.Line.Substring(1, 10)

            STITCHINGPANEL1.Color = ColorName

            STITCHINGPANEL1.DatePrint = Pub.DAT
            STITCHINGPANEL1.SealNo = SLNoD
            STITCHINGPANEL1.Barcode = D4075.BatchNo

            If (CIntp(D4075.Sno) Mod 2) = 0 Then STITCHINGPANEL1.Sno = CIntp(D4075.Sno) / 2
            If (CIntp(D4075.Sno) Mod 2) = 1 Then STITCHINGPANEL1.Sno = (CIntp(D4075.Sno) + 1) / 2

        End If

        If READ_PFK4075_BatchShoes(BatchShoes, "2", "1") Then
            STITCHINGPANEL2.SizeName = D4075.SizeName
            STITCHINGPANEL2.QtyBatch = D4075.QtyBatch
            STITCHINGPANEL2.QtyProd = D4075.QtyProduction

            STITCHINGPANEL2.JobCard = SLNoD
            STITCHINGPANEL2.BarcodeSeq = D4075.BatchNo

            STITCHINGPANEL2.Article = Article
            STITCHINGPANEL2.Line = Line

            If STITCHINGPANEL2.Line.Length > 10 Then STITCHINGPANEL2.Line = STITCHINGPANEL2.Line.Substring(1, 10)

            STITCHINGPANEL2.Color = ColorName

            STITCHINGPANEL2.DatePrint = Pub.DAT
            STITCHINGPANEL2.SealNo = SLNoD
            STITCHINGPANEL2.Barcode = D4075.BatchNo


            If (CIntp(D4075.Sno) Mod 2) = 0 Then STITCHINGPANEL2.Sno = CIntp(D4075.Sno) / 2
            If (CIntp(D4075.Sno) Mod 2) = 1 Then STITCHINGPANEL2.Sno = (CIntp(D4075.Sno) + 1) / 2

        End If

    End Sub
    Public Sub DATA_MOVE_BARCODE_34(BatchShoes As String)
        If READ_PFK4075_BatchShoes(BatchShoes, "1", "2") Then
            STITCHINGPANEL3.SizeName = D4075.SizeName
            STITCHINGPANEL3.QtyBatch = D4075.QtyBatch
            STITCHINGPANEL3.QtyProd = D4075.QtyProduction

            STITCHINGPANEL3.JobCard = SLNoD
            STITCHINGPANEL3.BarcodeSeq = D4075.BatchNo

            STITCHINGPANEL3.Article = Article
            STITCHINGPANEL3.Line = Line

            If STITCHINGPANEL3.Line.Length > 10 Then STITCHINGPANEL3.Line = STITCHINGPANEL3.Line.Substring(1, 10)

            STITCHINGPANEL3.Color = ColorName

            STITCHINGPANEL3.DatePrint = Pub.DAT
            STITCHINGPANEL3.SealNo = SLNoD
            STITCHINGPANEL3.Barcode = D4075.BatchNo

            'STITCHINGPANEL3.Sno = CIntp(CDecp(D4075.Sno) / 2)

            If (CIntp(D4075.Sno) Mod 2) = 0 Then STITCHINGPANEL3.Sno = CIntp(D4075.Sno) / 2
            If (CIntp(D4075.Sno) Mod 2) = 1 Then STITCHINGPANEL3.Sno = (CIntp(D4075.Sno) + 1) / 2
        End If

        If READ_PFK4075_BatchShoes(BatchShoes, "2", "1") Then
            STITCHINGPANEL4.SizeName = D4075.SizeName
            STITCHINGPANEL4.QtyBatch = D4075.QtyBatch
            STITCHINGPANEL4.QtyProd = D4075.QtyProduction

            STITCHINGPANEL4.JobCard = SLNoD
            STITCHINGPANEL4.BarcodeSeq = D4075.BatchNo

            STITCHINGPANEL4.Article = Article
            STITCHINGPANEL4.Line = Line

            If STITCHINGPANEL4.Line.Length > 10 Then STITCHINGPANEL4.Line = STITCHINGPANEL4.Line.Substring(1, 10)

            STITCHINGPANEL4.Color = ColorName

            STITCHINGPANEL4.DatePrint = Pub.DAT
            STITCHINGPANEL4.SealNo = SLNoD
            STITCHINGPANEL4.Barcode = D4075.BatchNo

            'STITCHINGPANEL4.Sno = CIntp(CDecp(D4075.Sno) / 2)
            If (CIntp(D4075.Sno) Mod 2) = 0 Then STITCHINGPANEL4.Sno = CIntp(D4075.Sno) / 2
            If (CIntp(D4075.Sno) Mod 2) = 1 Then STITCHINGPANEL4.Sno = (CIntp(D4075.Sno) + 1) / 2
        End If
    End Sub

    Public Sub DATA_MOVE_BARCODE()

        Try
            PrintDocument1 = New Printing.PrintDocument
            PrintDocument1.Print()
        Catch ex As Exception
        End Try

    End Sub

    Public Sub DATA_MOVE_BARCODE_A4()

        Try
            PrintDocument1 = New Printing.PrintDocument
            PrintDocument1.Print()


        Catch ex As Exception
        End Try

    End Sub

    Public Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        gpp = e.Graphics

        If cHKa4 = True Then
            Call TAG_PRINT_STITCHING_PANEL_NEW_PROD_A4() : cHKa4 = False : Exit Sub
        End If


        If ptc_1.SelectedIndex = 1 Then Call TAG_PRINT_STITCHING_PANEL_NEW_PROD_NEWCONCEPT()
        If ptc_1.SelectedIndex = 2 Then Call TAG_PRINT_STITCHING_PANEL_NEW_PROD_SB2()

    End Sub

    Private Sub chk_test_CheckedChanged(sender As Object, e As EventArgs) Handles chk_test.CheckedChanged
        PFK4073_CheckTest = chk_test.Checked
    End Sub
End Class