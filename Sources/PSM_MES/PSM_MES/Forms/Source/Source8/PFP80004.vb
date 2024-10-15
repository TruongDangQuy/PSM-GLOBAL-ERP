Imports System.Net
Imports System.IO
Imports FarPoint.Excel
Imports System.Threading
Imports System.Diagnostics
Imports Microsoft.Office.Interop.Excel

Public Class PFP80004
    Private filename As String
    Private MarginX As New PrintMargin
    Private ChkAdd As Boolean = False
    Private chuoi1 As String
    Private chuoi2 As String
    Private isudCHK As Boolean
    Private itemcode As String
    Private itemcodeno As String
    Private formA As Boolean = False
    Private Form_T As New Form
    Private DSReprt As New DataSet
    Private xThread As Thread
    Private Sub Data_Inti()
        cmb_Kind.SelectedIndex = 0
        cmb_Layout.SelectedIndex = 0
        cmb_Margin.SelectedIndex = 0

    End Sub
    Public Function Link_SheetReport(job As Integer, PROG As String, Optional ByRef FORM As Form = Nothing) As Boolean
        Dim SQL As String
        Dim cmd As New SqlClient.SqlCommand
        Link_SheetReport = False

        Form_T = New Form
        Form_T = FORM

        SheetReportName = ""

        SQL = ""
        SQL = " SELECT SHEETREPORT,SHEETTITLE,CHECKUSE FROM [CS_PRINT].[dbo].[A_SHEETPRINT_MATCHING] "
        SQL = SQL & " WHERE PROG = '" & PROG & "' "
        SQL = SQL & " ORDER BY DSEQ"
        cmd = New SqlClient.SqlCommand(SQL, cn)
        da.SelectCommand = cmd
        DSReprt.Reset()
        da.Fill(DSReprt)

        'Me.ShowDialog()

        Link_SheetReport = isudCHK
    End Function

    Public Function Link_PrintSheet(SheetFileName As String, ByVal chuoi11 As String, ByVal chuoi22 As String) As Boolean
        Link_PrintSheet = False
        filename = SheetFileName
        chuoi1 = chuoi11
        chuoi2 = chuoi22
        formA = False

        Data_Inti()
        Me.ShowDialog()
        Link_PrintSheet = isudCHK
    End Function

    Public Function Link_PrintSheet(SheetFileName As String, ByVal chuoi11 As String, ByVal chuoi22 As String, _itemcode As String, _itemcodeno As String) As Boolean
        Link_PrintSheet = False
        filename = SheetFileName
        chuoi1 = chuoi11
        chuoi2 = chuoi22
        itemcode = _itemcode
        itemcodeno = _itemcodeno
        Data_Inti()
        Me.ShowDialog()
        Link_PrintSheet = isudCHK
    End Function

    Private Sub cmd_Cancel_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        Me.Close()
    End Sub
    Private Sub ReportPrintData()

        Dim xPrintInfo As New PrintInfo
        Dim xPrintMargin As New PrintMargin
        Dim xPaperHeight As Double = 0
        Dim xPaperWidth As Double = 0
        Dim xGridLine As New FarPoint.Win.Spread.GridLine(FarPoint.Win.Spread.GridLines.None)
        Dim xPaperSize As Printing.PaperSize

        Dim xInch As Double = 39.3700787, xHeader As String = String.Empty

        Dim rules As New FarPoint.Win.Spread.SmartPrintRulesCollection
        Dim sc As New FarPoint.Win.Spread.ScaleRule(ResetOption.None, 1, 0.6, 0.3)

        Try
            With xPrintMargin
                .Left = 75
                .Top = 25
                .Right = 25
                .Bottom = 25
                .Header = 40
                .Footer = 40
            End With

            xPaperSize = New Printing.PaperSize("A4", 857, 1169)

            With xPrintInfo

                .PaperSize = xPaperSize
                .ShowColumnFooter = PrintHeader.Hide
                .ShowBorder = True
                .ShowColor = True
                .ShowGrid = True
                .ShowShadows = False
                .UseMax = False
                .ShowRowHeader = PrintHeader.Hide
                .BestFitRows = True
                .UseSmartPrint = True
                .SmartPrintPagesTall = 5
                .SmartPrintPagesWide = 5
                .SmartPrintRules = rules

                .Margin = xPrintMargin
                .Orientation = vSPrint.ActiveSheet.PrintInfo.Orientation
            End With

            xPrintInfo.ColStart = 0
            xPrintInfo.RowStart = 0
            xPrintInfo.ColEnd = 100
            xPrintInfo.RowEnd = 100
            xPrintInfo.PrintType = PrintType.CellRange

            xGridLine = New FarPoint.Win.Spread.GridLine(FarPoint.Win.Spread.GridLineType.Flat, Color.LightGray)
            vSPrint.ActiveSheet.HorizontalGridLine = xGridLine
            vSPrint.ActiveSheet.VerticalGridLine = xGridLine
            xGridLine = New FarPoint.Win.Spread.GridLine(GridLineType.Flat, Color.Black)
            vSPrint.ActiveSheet.ColumnHeader.VerticalGridLine = xGridLine
            vSPrint.ActiveSheet.ColumnHeader.HorizontalGridLine = xGridLine

            xPrintInfo.Preview = True

            vSPrint.ActiveSheet.PrintInfo = xPrintInfo
            vSPrint.PrintSheet(0)

        Catch ex As Exception

        Finally

        End Try

    End Sub
    Private Sub cmd_Prt_Click(sender As Object, e As EventArgs) Handles cmd_Prt.Click
        'Dim strFile As String = App_Path & "\Report\" & "\" & filename & System_Date_time() & ".xls"
        'vSPrint.SaveExcel(strFile, ExcelSaveFlags.UseOOXMLFormat)

        'Dim objProcess As New System.Diagnostics.ProcessStartInfo

        'With objProcess
        '    .FileName = strFile
        '    .CreateNoWindow = True
        '    .WindowStyle = ProcessWindowStyle.Hidden
        '    .Verb = "print"
        '    .UseShellExecute = True
        'End With
        'Try
        '    System.Diagnostics.Process.Start(objProcess)
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'Finally

        'End Try

        Dim PrintDialog1 As New PrintDialog

        If PrintDialog1.ShowDialog = DialogResult.OK Then


            Dim strFile As String = App_Path & "\Report" & "\" & filename & System_Date_time() & ".xls"

            vSPrint.SaveExcel(strFile, ExcelSaveFlags.UseOOXMLFormat)

            Try
                Dim excel As Application = New Application
                excel.Visible = False
                Dim w As Workbook = excel.Workbooks.Open(strFile)
                w.ActiveSheet.Printout(, , PrintDialog1.PrinterSettings.Copies, False, PrintDialog1.PrinterSettings.PrinterName)

                w.Close(SaveChanges:=False)
                excel.Quit()
                'Me.Dispose()
                'SheetReport.Dispose()
                Exit Sub

            Catch ex As Exception

            End Try

            Try

                Dim objProcess As New ProcessStartInfo

                With objProcess
                    .FileName = strFile
                    .CreateNoWindow = True
                    .WindowStyle = ProcessWindowStyle.Minimized
                    .Verb = "print"
                    .UseShellExecute = True
                End With
                System.Diagnostics.Process.Start(objProcess)

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally

            End Try
        End If

    End Sub


    Private Sub PeaceButton1_Click(sender As Object, e As EventArgs) Handles PeaceButton1.Click
        Dim p As New Process()
        Try
            Dim a As New SaveFileDialog
            Dim filelocation As String
            a.Filter = "Excel Files|*.xlsx"
            a.DefaultExt = "xlsx"
            a.FileName = vSPrint.ActiveSheet.SheetName & "-" & System_Date_time()
            If a.ShowDialog = DialogResult.OK Then
                filelocation = a.FileName
                vSPrint.SaveExcel(filelocation, FarPoint.Excel.ExcelSaveFlags.UseOOXMLFormat)
                Dim str = MsgBoxP("Finish. Would you like to open it?", vbYesNo)
                If str = MsgBoxResult.Yes Then
                    Process.Start(filelocation)
                End If
                Exit Sub
            End If

        Catch ex As Exception
            MsgBoxP("PDF problem!")
        End Try
    End Sub

    Private Sub PRINTSHEET_Loading_Except1()
        ' Name = ENG_WeavingInspectionReport

    End Sub
    Private Sub PRINTSHEET_Loading()
        Dim SoSheet As Integer
        Dim SQL As String = ""
        Dim solan, sovong As Integer

        Dim MAXROW, MAXCOL, IDCOL, IDROWBEGIN, IDROWEND As Integer
        Dim DSNN As New DataSet

        Dim i, j, k As Integer
        Dim SumI As Integer
        Dim da As New SqlClient.SqlDataAdapter
        Dim ChkList As String
        SumI = 0

        Me.WindowState = FormWindowState.Maximized

        Try
            vSPrint.Reset()
            vSPrint.Enabled = False
            vSPrint.Visible = False
            vSPrint.Sheets.Count = 0

            For SoSheet = 0 To DSReprt.Tables(0).Rows.Count - 1
                vSPrint.Sheets.Count += 1
                chuoi1 = ""
                chuoi2 = ""

                If GETCHUOI1(chuoi1, GetDsData(DSReprt, SoSheet, 0)) = False Then GoTo next1
                If GETCHUOI2_01(Form_T, chuoi2, GetDsData(DSReprt, SoSheet, 0), chuoi1) = False Then GoTo next1

                vSPrint.ActiveSheet = vSPrint.Sheets(SoSheet)

                Dim gdln As New FarPoint.Win.Spread.GridLine(FarPoint.Win.Spread.GridLineType.None)
                Dim str As String

                filename = GetDsData(DSReprt, SoSheet, 0)
                '-------------------------------------------------------------------------------------------------------------'
                Try
                    str = "http://192.168.0.3/SHV/Report/" & filename & ".xlsx"
                    str = "http://"
                    str += Pub.SER.Replace(",", ":")
                    str += "/SHV/Report/" & filename & ".xlsx"

                    Dim myWebClient As New WebClient()
                    myWebClient.DownloadFile(str, App_Path & "\Report\" & filename & ".xlsx")

                    If SoSheet = 0 Then
                        vSPrint.OpenExcel(App_Path & "\Report\" & "\" & filename & ".xlsx", True)
                    Else
                        vSPrint.Sheets(SoSheet).OpenExcel(App_Path & "\Report\" & "\" & filename & ".xlsx", 0)
                    End If

                Catch ex As Exception
                    Try
                        str = "http://192.168.0.3/SHV/Report/" & filename & ".xls"
                        str = "http://"
                        str += Pub.SER.Replace(",", ":")
                        str += "/SHV/Report/" & filename & ".xls"

                        Dim myWebClient As New WebClient()
                        myWebClient.DownloadFile(str, App_Path & "\Report\" & filename & ".xls")

                        If SoSheet = 0 Then
                            vSPrint.OpenExcel(App_Path & "\Report\" & "\" & filename & ".xls", True)
                        Else
                            vSPrint.Sheets(SoSheet).OpenExcel(App_Path & "\Report\" & "\" & filename & ".xls", 0)
                        End If

                    Catch exx As Exception

                    End Try
                End Try

                If SoSheet = 0 Then
                    vSPrint.OpenExcel(App_Path & "\Report\" & "\" & GetDsData(DSReprt, SoSheet, 0) & ".xlsx")
                Else
                    vSPrint.ActiveSheet.OpenExcel(App_Path & "\Report\" & "\" & GetDsData(DSReprt, SoSheet, 0) & ".xlsx", 0)
                End If
                ChkList = GetDsData(DSReprt, SoSheet, 2)

                vSPrint.ActiveSheet.SheetName = GetDsData(DSReprt, SoSheet, 1)

                vSPrint.ActiveSheet.HorizontalGridLine = gdln
                vSPrint.ActiveSheet.VerticalGridLine = gdln

                vSPrint.ActiveSheet.ColumnHeader.Visible = False
                vSPrint.ActiveSheet.RowHeader.Visible = False
                vSPrint.ActiveSheet.OperationMode = OperationMode.ReadOnly
                vSPrint.ClipboardOptions = ClipboardOptions.NoHeaders
                vSPrint.AutoClipboard = False

                vSPrint.ActiveSheet.ColumnFooterVisible = True
                vSPrint.ActiveSheet.RowCount = 500
                vSPrint.ActiveSheet.ColumnCount = 50

                SQL = ""
                SQL = "SELECT * "
                SQL = SQL + " FROM [CS_PRINT].[dbo].[A_SHEETPRINT_MAIN]"
                SQL = SQL + " WHERE [SHEETREPORT] = '" + filename + "'  "
                da.SelectCommand = New SqlClient.SqlCommand(SQL, cn)
                da.Fill(DSNN)

                If GetDsRc(DSNN) = 0 Then
                    vSPrint.ActiveSheet.RowCount = 1000
                    vSPrint.ActiveSheet.ColumnCount = 1000
                Else
                    MAXROW = CIntp(GetDsData(DSNN, i, "MAXROW"))
                    MAXCOL = CIntp(GetDsData(DSNN, i, "MAXCOL"))
                    IDCOL = CIntp(GetDsData(DSNN, i, "IDCOL"))
                    IDROWBEGIN = CIntp(GetDsData(DSNN, i, "IDROWBEGIN"))
                    IDROWEND = CIntp(GetDsData(DSNN, i, "IDROWEND"))

                    If MAXROW > 0 Then
                        vSPrint.ActiveSheet.RowCount = MAXROW + 1
                        vSPrint.ActiveSheet.ColumnCount = MAXCOL + 1
                    End If

                End If


                If vSPrint.ActiveSheet.SheetName <> "Inspection Report" Then
                    Dim DS1 As New DataSet

                    For solan = 0 To UBound(Split(chuoi1, ";"))
                        SQL = ""
                        For sovong = 0 To UBound(Split(Split(chuoi2, ";")(solan), ","))
                            If sovong = 0 Then
                                SQL = SQL + Split(Split(chuoi2, ";")(solan), ",")(sovong)
                            Else
                                SQL = SQL + "," + Split(Split(chuoi2, ";")(solan), ",")(sovong)
                            End If

                        Next
                        DS1 = PrcDS(Split(chuoi1, ";")(solan), cn, Split(SQL, ","))

                        Dim DS2 As New DataSet

                        SQL = ""
                        SQL = "SELECT [SHEETNAME],RIGHT([IDNAME],LEN([IDNAME])-1) AS IDNAME ,[IDSEQ],[IDCOL],[IDROW],[IDROWEND],[IDROWBEGIN] FROM [CS_PRINT].[dbo].[A_SHEETPRINT]"
                        SQL = SQL + "  WHERE [SHEETNAME] = '" + Split(chuoi1, ";")(solan) + "' "
                        SQL = SQL + " AND [SHEETREPORT] = '" + GetDsData(DSReprt, SoSheet, 0) + "'"
                        da.SelectCommand = New SqlClient.SqlCommand(SQL, cn)
                        da.Fill(DS2)

                        Dim xCol As Integer
                        Dim xRow As Integer
                        Dim xRowCount1 As Integer
                        Dim xColumnCount1 As Integer
                        Dim xRowCount2 As Integer
                        Dim xMod As Integer
                        Dim xHeight As Integer
                        Dim xColumnName As String
                        Dim xValue As Object

                        xRowCount1 = GetDsRc(DS1)
                        xColumnCount1 = GetDsCc(DS1)

                        xRowCount2 = GetDsRc(DS2)

                        For i = 0 To xRowCount2 - 1
                            For j = 0 To xColumnCount1 - 1
                                xColumnName = getColumName(DS1, j)
                                If xColumnName = GetDsData(DS2, i, "IDNAME") Then

                                    xCol = GetDsData(DS2, i, "IDCOL")
                                    xRow = GetDsData(DS2, i, "IDROW")
                                    xHeight = vSPrint.ActiveSheet.Rows(xRow).Height
                                    If (xRowCount1 > 18 And i = 0 And ChkList = 2) Then
                                        vSPrint.ActiveSheet.AddSelection(xRow + 1, 0, 1, vSPrint.ActiveSheet.ColumnCount)
                                        vSPrint.ActiveSheet.ClipboardCopy()
                                        vSPrint.ActiveSheet.AddRows(xRow + 1, xRowCount1 - 18)
                                        For xMod = 0 To xRowCount1 - 1
                                            vSPrint.ActiveSheet.SetActiveCell(xRow + 1 + xMod, 0)
                                            vSPrint.ActiveSheet.ClipboardPaste()
                                            vSPrint.ActiveSheet.Rows(xRow + 1 + xMod, xRow + 1 + xRowCount1 - 18 + xMod).Height = xHeight
                                        Next
                                        vSPrint.ActiveSheet.ClearSelection()
                                    End If

                                    For k = 0 To xRowCount1 - 1
                                        xValue = DS1.Tables(0).Rows(k).Item(j)
                                        If xColumnName.ToUpper.Contains("DATE") Or xColumnName.ToUpper.Contains("TIME") Then
                                            setData(vSPrint, xCol, xRow + k, FSDate(xValue))
                                        Else
                                            If READ_PFK9911(xColumnName) = True Then
                                                If D9911.DataType = "6" Then
                                                    Dim DataConvert() As String
                                                    DataConvert = Split(D9911.REMK, ";")
                                                    setTextConvert(vSPrint, xValue, DataConvert, xCol, xRow + k)
                                                Else
                                                    setData(vSPrint, xCol, xRow + k, xValue)
                                                End If
                                            Else
                                                setData(vSPrint, xCol, xRow + k, xValue)
                                            End If
                                        End If
                                    Next
                                End If

                            Next
                        Next

                    Next

                    If MAXROW > 0 Then

                        For i = IDROWBEGIN To IDROWEND
                            If getData(vSPrint, IDCOL, i) = "" Then
                                vSPrint.ActiveSheet.RemoveRows(i, IDROWEND + 1 - i)
                                Exit For
                            End If
                        Next

                    Else

                    End If

                    If filename = "RND_DAILY_STITCHING_REPORT" Then
                        SPR_MERGEALWAYS(vSPrint, 1)
                        SPR_MERGERESTRICT(vSPrint, 2, 3, 4, 5, 6)
                    End If


                Else

                    Dim DS1 As New DataSet

                    For solan = 0 To UBound(Split(chuoi1, ";"))
                        SQL = ""
                        For sovong = 0 To UBound(Split(Split(chuoi2, ";")(solan), ","))
                            If sovong = 0 Then
                                SQL = SQL + Split(Split(chuoi2, ";")(solan), ",")(sovong)
                            Else
                                SQL = SQL + "," + Split(Split(chuoi2, ";")(solan), ",")(sovong)
                            End If

                        Next
                        DS1 = PrcDS(Split(chuoi1, ";")(solan), cn, Split(SQL, ","))

                        Dim DS2 As New DataSet

                        SQL = ""
                        SQL = "SELECT [SHEETNAME],RIGHT([IDNAME],LEN([IDNAME])-1) AS IDNAME ,[IDSEQ],[IDCOL],[IDROW],[IDROWEND],[IDROWBEGIN] FROM [CS_PRINT].[dbo].[A_SHEETPRINT]"
                        SQL = SQL + "  WHERE [SHEETNAME] = '" + Split(chuoi1, ";")(solan) + "' "
                        SQL = SQL + " AND [SHEETREPORT] = '" + GetDsData(DSReprt, SoSheet, 0) + "'"
                        da.SelectCommand = New SqlClient.SqlCommand(SQL, cn)
                        da.Fill(DS2)

                        Dim xCol As Integer
                        Dim xRow As Integer
                        Dim xRowCount1 As Integer
                        Dim xColumnCount1 As Integer
                        Dim xRowCount2 As Integer
                        Dim xMod As Integer
                        Dim xHeight As Integer
                        Dim xColumnName As String
                        Dim xValue As Object

                        xRowCount1 = GetDsRc(DS1)
                        xColumnCount1 = GetDsCc(DS1)

                        xRowCount2 = GetDsRc(DS2)

                        For i = 0 To xRowCount2 - 1
                            For j = 0 To xColumnCount1 - 1
                                xColumnName = GetColumname(DS1, j)
                                If xColumnName = GetDsData(DS2, i, "IDNAME") Then

                                    xCol = GetDsData(DS2, i, "IDCOL")
                                    xRow = GetDsData(DS2, i, "IDROW")
                                    xHeight = vSPrint.ActiveSheet.Rows(xRow).Height
                                    If (xRowCount1 > 235 And i = 0 And ChkList = 2) Then
                                        vSPrint.ActiveSheet.AddSelection(xRow + 1, 0, 1, vSPrint.ActiveSheet.ColumnCount)
                                        vSPrint.ActiveSheet.ClipboardCopy()
                                        vSPrint.ActiveSheet.AddRows(xRow + 1, xRowCount1 - 235)
                                        For xMod = 0 To xRowCount1 - 1
                                            vSPrint.ActiveSheet.SetActiveCell(xRow + 1 + xMod, 0)
                                            vSPrint.ActiveSheet.ClipboardPaste()
                                            vSPrint.ActiveSheet.Rows(xRow + 1 + xMod, xRow + 1 + xRowCount1 - 235 + xMod).Height = xHeight
                                        Next
                                        vSPrint.ActiveSheet.ClearSelection()
                                    End If

                                    For k = 0 To xRowCount1 - 1
                                        xValue = DS1.Tables(0).Rows(k).Item(j)
                                        If xColumnName.ToUpper.Contains("DATE") Or xColumnName.ToUpper.Contains("TIME") Then
                                            setData(vSPrint, xCol, xRow + k, FSDate(xValue))
                                        Else
                                            If READ_PFK9911(xColumnName) = True Then
                                                If D9911.DataType = "6" Then
                                                    Dim DataConvert() As String
                                                    DataConvert = Split(D9911.REMK, ";")
                                                    setTextConvert(vSPrint, xValue, DataConvert, xCol, xRow + k)
                                                Else
                                                    setData(vSPrint, xCol, xRow + k, xValue)
                                                End If
                                            Else
                                                setData(vSPrint, xCol, xRow + k, xValue)
                                            End If
                                        End If
                                    Next
                                End If

                            Next
                        Next


                        If MAXROW > 0 Then

                            For i = IDROWBEGIN To IDROWEND
                                If getData(vSPrint, IDCOL, i) = "" Then
                                    vSPrint.ActiveSheet.RemoveRows(i, IDROWEND + 1 - i)
                                    Exit For
                                End If
                            Next

                        Else

                        End If



                    Next

                End If

                vSPrint.ActiveSheet.ZoomFactor = 1
next1:
            Next
            isudCHK = True
            formA = True
            Call ReportTitle()
            vSPrint.Enabled = True
            vSPrint.Visible = True
        Catch ex As Exception
            MsgBoxP("PRINTSHEET_Load")
            vSPrint.Enabled = True
            vSPrint.Visible = True
        End Try

    End Sub

    Private Sub NumericUpDown3_ValueChanged(sender As Object, e As EventArgs) Handles chk_Size.ValueChanged
        If formA = False Then Exit Sub
        If chk_Size.Created = True Then vSPrint.ActiveSheet.ZoomFactor = chk_Size.Value / 100
    End Sub

    Private Sub cmd_Enable_Click(sender As Object, e As EventArgs) Handles cmd_Enable.Click
        Dim tmpPW_CHK As String = ""
        If READ_PFK7171(Const_PASSWORD, "001") = True Then
            tmpPW_CHK = D7171.NameSimply
        Else
            Exit Sub
        End If
        Dim f As Form
        f = New FPassWord
        f.ShowDialog()
        If PASSWORDCHECK <> tmpPW_CHK Then MsgBoxP("WRONG PASS!") : Me.Close() : Exit Sub
        vSPrint.ActiveSheet.ColumnHeader.Visible = True
        vSPrint.ActiveSheet.RowHeader.Visible = True
        vSPrint.ActiveSheet.OperationMode = OperationMode.Normal
        vSPrint.ClipboardOptions = ClipboardOptions.AllHeaders
        vSPrint.AutoClipboard = True
        vSPrint.Enabled = True
    End Sub
    Private Sub ReportTitle()
        Try
            Dim i, j, k As Integer
            Dim Title As String
            For k = 0 To vSPrint.Sheets.Count - 1
                For i = 0 To 10
                    For j = 0 To vSPrint.Sheets(k).ColumnCount - 1
                        Title = vSPrint.Sheets(k).Cells(i, j).Value
                        If Title = "#Printdate" Then
                            vSPrint.Sheets(k).Cells(i, j).Value = FSDate(txt_SDATE.Data) ' setData(vSPrint, i, j, FSDate(System_Date_8))
                        End If

                        If Title = "#Incharge" Then
                            vSPrint.Sheets(k).Cells(i, j).Value = Pub.NAM 'setData(vSPrint, i, j, Pub.NAM)
                        End If

                        If Title = "#Reportdate" Then
                            vSPrint.Sheets(k).Cells(i, j).Value = FSDate(txt_SDATE.Data) 'setData(vSPrint, i, j, FSDate(txt_SDATE.Data))
                        End If

                    Next
                Next
            Next

            vSPrint.ActiveSheetIndex = 0
        Catch ex As Exception

        End Try
    End Sub
    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        Call Link_SheetReport(3, Me.Name, Me)
        Call PRINTSHEET_Loading()
    End Sub

    Private Sub PFP80001_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        txt_SDATE.Data = System_Date_Add(0, -1)
        formA = True
    End Sub


    Private Sub cmd_Back_Click(sender As Object, e As EventArgs) Handles cmd_Back.Click
        Try
            If vSPrint.Sheets.Count > 1 Then
                If vSPrint.ActiveSheetIndex = 0 Then vSPrint.ActiveSheetIndex = vSPrint.Sheets.Count - 1 : Exit Sub
                vSPrint.ActiveSheetIndex -= 1
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmd_Next_Click(sender As Object, e As EventArgs) Handles cmd_Next.Click
        If vSPrint.Sheets.Count > 1 Then
            If vSPrint.ActiveSheetIndex = vSPrint.Sheets.Count - 1 Then vSPrint.ActiveSheetIndex = 0 : Exit Sub
            vSPrint.ActiveSheetIndex += 1
        End If
    End Sub


    Private Sub Thread_Loading()
        Dim SoSheet As Integer
        Dim SQL As String = ""

        Dim SumI As Integer
        Dim da As New SqlClient.SqlDataAdapter

        SumI = 0

        Me.WindowState = FormWindowState.Maximized

        Try
            vSPrint.Reset()
            vSPrint.Enabled = False
            vSPrint.Visible = False
            vSPrint.Sheets.Count = 0

            For SoSheet = 0 To DSReprt.Tables(0).Rows.Count - 1
                vSPrint.Sheets.Count += 1
                If SoSheet = 0 Then
                    xThread = New Threading.Thread(AddressOf Thread_Children)
                    xThread.Start(SoSheet)
                End If


            Next
            isudCHK = True
            formA = True
            Call ReportTitle()
            vSPrint.Enabled = True
            vSPrint.Visible = True
        Catch ex As Exception
            MsgBoxP("PRINTSHEET_Load")
            vSPrint.Enabled = True
            vSPrint.Visible = True
        End Try

    End Sub

    Private Sub Thread_Children_Except1()


    End Sub
    Private Sub Thread_Children(SoSheet As Integer)
        Dim solan, sovong As Integer
        Dim ChkList As String
        Dim i, j, k As Integer

        Dim chuoi11, chuoi12 As String

        chuoi11 = ""
        chuoi12 = ""

        Try


            If GETCHUOI1(chuoi11, GetDsData(DSReprt, SoSheet, 0)) = False Then GoTo next1
            If GETCHUOI2_01(Form_T, chuoi12, GetDsData(DSReprt, SoSheet, 0), chuoi11) = False Then GoTo next1


            Dim gdln As New FarPoint.Win.Spread.GridLine(FarPoint.Win.Spread.GridLineType.None)
            Dim str As String
            '-------------------------------------------------------------------------------------------------------------'
            str = "http://192.168.0.3/DMSN/Report/" & GetDsData(DSReprt, SoSheet, 0) & ".xlsx"
            str = "http://"
            str += Pub.SER.Replace(",", ":")
            str += "/DMSN/Report/" & GetDsData(DSReprt, SoSheet, 0) & ".xlsx"

            Dim myWebClient As New WebClient()
            myWebClient.DownloadFile(str, App_Path & "\Report\" & GetDsData(DSReprt, SoSheet, 0) & ".xlsx")

            If SoSheet = 0 Then
                vSPrint.OpenExcel(App_Path & "\Report\" & "\" & GetDsData(DSReprt, SoSheet, 0) & ".xlsx", True)
            Else
                vSPrint.Sheets(SoSheet).OpenExcel(App_Path & "\Report\" & "\" & GetDsData(DSReprt, SoSheet, 0) & ".xlsx", 0)
            End If
            ChkList = GetDsData(DSReprt, SoSheet, 2)

            vSPrint.Sheets(SoSheet).SheetName = GetDsData(DSReprt, SoSheet, 1)

            vSPrint.Sheets(SoSheet).HorizontalGridLine = gdln
            vSPrint.Sheets(SoSheet).VerticalGridLine = gdln

            vSPrint.Sheets(SoSheet).ColumnHeader.Visible = False
            vSPrint.Sheets(SoSheet).RowHeader.Visible = False
            vSPrint.Sheets(SoSheet).OperationMode = OperationMode.ReadOnly
            vSPrint.ClipboardOptions = ClipboardOptions.NoHeaders
            vSPrint.AutoClipboard = False


            Dim DS1 As New DataSet

            For solan = 0 To UBound(Split(chuoi11, ";"))
                SQL = ""
                For sovong = 0 To UBound(Split(Split(chuoi12, ";")(solan), ","))
                    If sovong = 0 Then
                        SQL = SQL + Split(Split(chuoi12, ";")(solan), ",")(sovong)
                    Else
                        SQL = SQL + "," + Split(Split(chuoi12, ";")(solan), ",")(sovong)
                    End If

                Next
                DS1 = PrcDS(Split(chuoi11, ";")(solan), cn, Split(SQL, ","))

                Dim DS2 As New DataSet

                SQL = ""
                SQL = "SELECT [SHEETNAME],RIGHT([IDNAME],LEN([IDNAME])-1) AS IDNAME ,[IDSEQ],[IDCOL],[IDROW],[IDROWEND],[IDROWBEGIN] FROM [CS_PRINT].[dbo].[A_SHEETPRINT]"
                SQL = SQL + "  WHERE [SHEETNAME] = '" + Split(chuoi11, ";")(solan) + "' "
                SQL = SQL + " AND [SHEETREPORT] = '" + GetDsData(DSReprt, SoSheet, 0) + "'"
                da.SelectCommand = New SqlClient.SqlCommand(SQL, cn)
                da.Fill(DS2)

                Dim xCol As Integer
                Dim xRow As Integer
                Dim xRowCount1 As Integer
                Dim xColumnCount1 As Integer
                Dim xRowCount2 As Integer
                Dim xMod As Integer
                Dim xHeight As Integer
                Dim xColumnName As String
                Dim xValue As Object

                xRowCount1 = GetDsRc(DS1)
                xColumnCount1 = GetDsCc(DS1)

                xRowCount2 = GetDsRc(DS2)

                For i = 0 To xRowCount2 - 1
                    For j = 0 To xColumnCount1 - 1
                        xColumnName = GetColumname(DS1, j)
                        If xColumnName = GetDsData(DS2, i, "IDNAME") Then

                            xCol = GetDsData(DS2, i, "IDCOL")
                            xRow = GetDsData(DS2, i, "IDROW")
                            xHeight = vSPrint.Sheets(SoSheet).Rows(xRow).Height
                            If (xRowCount1 > 19 And i = 0 And ChkList = 2) Then
                                vSPrint.Sheets(SoSheet).AddSelection(xRow + 1, 0, 1, vSPrint.Sheets(SoSheet).ColumnCount)
                                vSPrint.Sheets(SoSheet).ClipboardCopy()
                                vSPrint.Sheets(SoSheet).AddRows(xRow + 1, xRowCount1 - 19)
                                For xMod = 0 To xRowCount1 - 1
                                    vSPrint.Sheets(SoSheet).SetActiveCell(xRow + 1 + xMod, 0)
                                    vSPrint.Sheets(SoSheet).ClipboardPaste()
                                    vSPrint.Sheets(SoSheet).Rows(xRow + 1 + xMod, xRow + 1 + xRowCount1 - 19 + xMod).Height = xHeight
                                Next
                                vSPrint.Sheets(SoSheet).ClearSelection()
                            End If

                            For k = 0 To xRowCount1 - 1
                                xValue = DS1.Tables(0).Rows(k).Item(j)
                                If xColumnName.ToUpper.Contains("DATE") Or xColumnName.ToUpper.Contains("TIME") Then
                                    setData(vSPrint, xCol, xRow + k, FSDate(xValue))
                                Else
                                    If READ_PFK9911(xColumnName) = True Then
                                        If D9911.DataType = "6" Then
                                            Dim DataConvert() As String
                                            DataConvert = Split(D9911.REMK, ";")
                                            setTextConvert(vSPrint, xValue, DataConvert, xCol, xRow + k)
                                        Else
                                            setData(vSPrint, xCol, xRow + k, xValue)
                                        End If
                                    Else
                                        setData(vSPrint, xCol, xRow + k, xValue)
                                    End If
                                End If
                            Next
                        End If

                    Next
                Next
            Next


            vSPrint.Sheets(SoSheet).ZoomFactor = 1
next1:
        Catch ex As Exception

        End Try
    End Sub

End Class