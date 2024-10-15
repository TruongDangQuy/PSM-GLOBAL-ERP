Imports System.Net
Imports System.IO
Imports FarPoint.Excel
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Excel
Public Class PRINTSHEET_NEW_F1
    Private filename As String
    Private MarginX As New PrintMargin
    Private ChkAdd As Boolean = False
    Private chuoi1 As String
    Private chuoi2 As String
    Private isudCHK As Boolean
    Private itemcode As String
    Private itemcodeno As String
    Private formA As Boolean
    Private Form_T As New Form
    Private DSReprt As New DataSet

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
        SQL = " SELECT SHEETREPORT FROM [CS_PRINT].[dbo].[A_SHEETPRINT_MATCHING] "
        SQL = SQL & " WHERE PROG = '" & PROG & "' "
        SQL = SQL & " GROUP BY SHEETREPORT"
        cmd = New SqlClient.SqlCommand(SQL, cn)
        da.SelectCommand = cmd
        DSReprt.Reset()
        da.Fill(DSReprt)

        Me.ShowDialog()

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
        Dim PrintDialog1 As New PrintDialog
        PrintDialog1.Document = PrintDocument1
        PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
        PrintDialog1.AllowSomePages = True
        If PrintDialog1.ShowDialog = DialogResult.OK Then
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings

            Dim strFile As String = App_Path & "\Report" & "\" & filename & System_Date_time() & ".xlsx"
            vSPrint.SaveExcel(strFile, ExcelSaveFlags.UseOOXMLFormat)

            Try
                Dim excel As Application = New Application
                excel.Visible = False

                If vSPrint.ActiveSheet.SheetName = "VND_Invoice" Then
                    excel.DecimalSeparator = ","
                    excel.ThousandsSeparator = "."
                    excel.UseSystemSeparators = False
                Else
                    excel.UseSystemSeparators = True
                End If

                Dim w As Workbook = excel.Workbooks.Open(strFile)

                'w.ActiveSheet.Printout(1, 1, PrintDialog1.PrinterSettings.Copies, False, PrintDialog1.PrinterSettings.PrinterName)
                w.ActiveSheet.Printout(, , PrintDialog1.PrinterSettings.Copies, False, PrintDialog1.PrinterSettings.PrinterName)
                w.Close(SaveChanges:=False)
                excel.Quit()
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
        Dim pi As New FarPoint.Win.Spread.PrintInfo()
        Try
            ''''''''''new demo
            Dim a As New SaveFileDialog
            Dim filelocation As String
            a.Filter = "Excel Files|*.xls"
            a.DefaultExt = ".xls"
            If a.ShowDialog = DialogResult.OK Then
                filelocation = a.FileName
                vSPrint.ActiveSheet.Protect = False
                'vSPrint.SaveExcel(filelocation, FarPoint.Excel.ExcelSaveFlags.UseOOXMLFormat)
                vSPrint.SaveExcel(filelocation, FarPoint.Excel.ExcelSaveFlags.SaveBothCustomRowAndColumnHeaders)
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

    Private Sub PRINTSHEET_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim SoSheet As Integer
        Dim SQL As String = ""
        Dim solan, sovong As Integer
        Dim i, j, k As Integer
        Dim SumI As Integer
        Dim da As New SqlClient.SqlDataAdapter
        SumI = 0
        Dim MAXROW, MAXCOL, IDCOL, IDROWBEGIN, IDROWEND As Integer

        Me.WindowState = FormWindowState.Maximized


        Try
            vSPrint.Reset()
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

                '-------------------------------------------------------------------------------------------------------------'
                str = "http://"
                str += Pub.SER
                str += "/CS_WHM/Report/" & GetDsData(DSReprt, SoSheet, 0) & ".xlsx"
                '-------------------------------------------------------------------------------------------------------------'

                Dim myWebClient As New WebClient()
                myWebClient.DownloadFile(str, App_Path & "\Report\" & GetDsData(DSReprt, SoSheet, 0) & ".xlsx")

                If SoSheet = 0 Then
                    vSPrint.OpenExcel(App_Path & "\Report" & "\" & GetDsData(DSReprt, SoSheet, 0) & ".xlsx", True)
                Else
                    vSPrint.ActiveSheet.OpenExcel(App_Path & "\Report" & "\" & GetDsData(DSReprt, SoSheet, 0) & ".xlsx", 0)
                End If

                vSPrint.ActiveSheet.SheetName = GetDsData(DSReprt, SoSheet, 0)


                vSPrint.ActiveSheet.HorizontalGridLine = gdln
                vSPrint.ActiveSheet.VerticalGridLine = gdln

                vSPrint.ActiveSheet.ColumnHeader.Visible = False
                vSPrint.ActiveSheet.RowHeader.Visible = False
                vSPrint.ActiveSheet.OperationMode = OperationMode.ReadOnly
                vSPrint.ClipboardOptions = ClipboardOptions.NoHeaders
                vSPrint.AutoClipboard = False
                vSPrint.Enabled = True

                Dim DSNN As New DataSet

                SQL = ""
                SQL = "SELECT * "
                SQL = SQL + " FROM [CS_PRINT].[dbo].[A_SHEETPRINT_MAIN]"
                SQL = SQL + " WHERE [SHEETREPORT] = '" + GetDsData(DSReprt, SoSheet, 0) + "'  "
                da.SelectCommand = New SqlClient.SqlCommand(SQL, cn)
                da.Fill(DSNN)

                If GetDsRc(DSNN) = 0 Then
                    vSPrint.ActiveSheet.RowCount = 1000
                    vSPrint.ActiveSheet.ColumnCount = 1000
                Else
                    MAXROW = CIntp(GetDsData(DSNN, 0, "MAXROW"))
                    MAXCOL = CIntp(GetDsData(DSNN, 0, "MAXCOL"))
                    IDCOL = CIntp(GetDsData(DSNN, 0, "IDCOL"))
                    IDROWBEGIN = CIntp(GetDsData(DSNN, 0, "IDROWBEGIN"))
                    IDROWEND = CIntp(GetDsData(DSNN, 0, "IDROWEND"))

                    If MAXROW > 0 Then
                        vSPrint.ActiveSheet.RowCount = MAXROW + 1
                        vSPrint.ActiveSheet.ColumnCount = MAXCOL + 1
                    End If

                End If


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

                    For i = 0 To GetDsRc(DS2) - 1
                        For j = 0 To GetDsCc(DS1) - 1
                            If getColumName(DS1, j) = GetDsData(DS2, i, "IDNAME") Then
                                For k = 0 To GetDsRc(DS1) - 1
                                    If GetDsData(DS2, i, "IDROW") + k > GetDsData(DS2, i, "IDROWEND") Then
                                        If getColumName(DS1, j).ToUpper.Contains("DATE") Or getColumName(DS1, j).ToUpper.Contains("TIME") Then
                                            setData(vSPrint, GetDsData(DS2, i, "IDCOL"), GetDsData(DS2, i, "IDROW") + k, FSDate(DS1.Tables(0).Rows(k).Item(j)))
                                        Else
                                            If READ_PFK9911(getColumName(DS1, j)) = True Then
                                                If D9911.DataType = "6" Then
                                                    Dim DataConvert() As String
                                                    DataConvert = Split(D9911.REMK, ";")
                                                    setTextConvert(vSPrint, DS1.Tables(0).Rows(k).Item(j), DataConvert, GetDsData(DS2, i, "IDCOL"), GetDsData(DS2, i, "IDROW") + k)
                                                Else
                                                    setData(vSPrint, GetDsData(DS2, i, "IDCOL"), GetDsData(DS2, i, "IDROW") + k, DS1.Tables(0).Rows(k).Item(j))
                                                End If
                                            Else
                                                setData(vSPrint, GetDsData(DS2, i, "IDCOL"), GetDsData(DS2, i, "IDROW") + k, DS1.Tables(0).Rows(k).Item(j))
                                            End If
                                        End If
                                    Else
                                        If getColumName(DS1, j).ToUpper.Contains("DATE") Or getColumName(DS1, j).ToUpper.Contains("TIME") Then
                                            setData(vSPrint, GetDsData(DS2, i, "IDCOL"), GetDsData(DS2, i, "IDROW") + k, FSDate(DS1.Tables(0).Rows(k).Item(j)))
                                        Else
                                            If READ_PFK9911(getColumName(DS1, j)) = True Then
                                                If D9911.DataType = "6" Then
                                                    Dim DataConvert() As String
                                                    DataConvert = Split(D9911.REMK, ";")
                                                    setTextConvert(vSPrint, DS1.Tables(0).Rows(k).Item(j), DataConvert, GetDsData(DS2, i, "IDCOL"), GetDsData(DS2, i, "IDROW") + k)
                                                Else
                                                    setData(vSPrint, GetDsData(DS2, i, "IDCOL"), GetDsData(DS2, i, "IDROW") + k, DS1.Tables(0).Rows(k).Item(j))
                                                End If
                                            Else
                                                setData(vSPrint, GetDsData(DS2, i, "IDCOL"), GetDsData(DS2, i, "IDROW") + k, DS1.Tables(0).Rows(k).Item(j))
                                            End If
                                        End If

                                    End If
                                Next
                            End If

                        Next
                        If GetDsData(DS2, i, "IDNAME").Length > 4 Then
                            If Strings.Left(GetDsData(DS2, i, "IDNAME"), 3) = "um@" Then
                                For SumI = CIntp(GetDsData(DS2, i, "IDROWBEGIN")) To CIntp(GetDsData(DS2, i, "IDROWEND"))
                                    vSPrint.ActiveSheet.Cells(GetDsData(DS2, i, "IDROW"), GetDsData(DS2, i, "IDCOL")).Value += getData(vSPrint, GetDsData(DS2, i, "IDCOL"), SumI)
                                    Dim so As Double
                                    so = CDblp(vSPrint.ActiveSheet.Cells(GetDsData(DS2, i, "IDROW"), GetDsData(DS2, i, "IDCOL")).Value)
                                Next
                            End If
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

                End If


                vSPrint.ActiveSheet.ZoomFactor = 1
next1:
            Next



            vSPrint.ActiveSheetIndex = 0
            isudCHK = True
            formA = True
        Catch ex As Exception
            MsgBoxP("PRINTSHEET_Load")
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

End Class