Imports Spire.Barcode
Imports System.Net
Imports System.IO
Imports FarPoint.Excel
Imports System.Diagnostics
Imports Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Interop
Public Class PRINTSHEET
    Dim xlapp As Application
    Dim xlwbk As Workbook
    Dim xlwksht As Worksheet

    Private filename As String
    Private MarginX As New PrintMargin
    Private ChkAdd As Boolean = False
    Private chuoi1 As String
    Private chuoi2 As String
    Private isudCHK As Boolean
    Private itemcode As String
    Private itemcodeno As String
    Private formA As Boolean

    Private form_Merge As Boolean = False

    Private FormName As String
    Private Parameter As String
    Private Sub Data_Inti()
        vSPrint.chk_NoUseKey = True

        cmb_Kind.SelectedIndex = 0
        cmb_Layout.SelectedIndex = 0
        cmb_Margin.SelectedIndex = 0
    End Sub
    Public Function Link_PrintSheet2019(SheetFileName As String, _FormName As String, Value As String, ByVal chuoi11 As String, ByVal chuoi22 As String) As Boolean
        Link_PrintSheet2019 = False
        filename = SheetFileName
        chuoi1 = chuoi11
        chuoi2 = chuoi22
        formA = False

        FormName = _FormName
        Parameter = Value

        FormName = "PFK" + Strings.Mid(_FormName, 5, 4)

        Data_Inti()

        If MdiMenu.PREVIEWCHK.Checked = True Then
            Me.ShowDialog()
        Else
            Call PRINTSHEET_PRINT()
        End If

        Link_PrintSheet2019 = isudCHK
    End Function
    Public Function Link_PrintSheet(SheetFileName As String, ByVal chuoi11 As String, ByVal chuoi22 As String) As Boolean
        Link_PrintSheet = False
        filename = SheetFileName
        chuoi1 = chuoi11
        chuoi2 = chuoi22
        formA = False

        Data_Inti()

        If MdiMenu.PREVIEWCHK.Checked = True Then
            Me.ShowDialog()
        Else
            Call PRINTSHEET_PRINT()
        End If

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
        If MdiMenu.PREVIEWCHK.Checked = True Then
            Me.ShowDialog()
        Else
            Call PRINTSHEET_PRINT()
        End If

        Link_PrintSheet = isudCHK
    End Function

    Public Function Link_PrintSheet(SheetFileName As String, ByVal Check As Boolean, ByVal chuoi11 As String) As Boolean
        Link_PrintSheet = False
        filename = SheetFileName
        chuoi1 = chuoi11
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

            xPrintInfo.PageStart = 1
            xPrintInfo.PageEnd = 1

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
        If chk_Preview.Checked = True Then

            Dim StrMsg As String

            If cmb_Layout.SelectedIndex = 0 Then StrMsg = vbYes

            If cmb_Layout.SelectedIndex = 1 Then StrMsg = vbNo

            Call Sheet_Print_New(vSPrint, Me.Text, StrMsg)
            Exit Sub
        End If

        Dim PrintDialog1 As New PrintDialog

        If PrintDialog1.ShowDialog = DialogResult.OK Then


            Dim strFile As String = App_Path & "\Report" & "\" & filename & System_Date_time() & ".xls"

            'vSPrint.SaveExcel(strFile, ExcelSaveFlags.UseOOXMLFormat)

            If form_Merge = False Then
                vSPrint.SaveExcel(strFile, ExcelSaveFlags.UseOOXMLFormat)
            Else
                vSPrint.SaveExcel(strFile, ExcelSaveFlags.SaveAsViewed)
            End If

            Try
                Dim excel As Application = New Application
                excel.Visible = False
                Dim w As Workbook = excel.Workbooks.Open(strFile)
                w.ActiveSheet.Printout(, , PrintDialog1.PrinterSettings.Copies, False, PrintDialog1.PrinterSettings.PrinterName)

                w.Close(SaveChanges:=False)
                excel.Quit()
                Me.Dispose()
                SheetReport.Dispose()

                D7558_CLEAR()
                D7558.TableName = FormName
                D7558.Parameter = Parameter
                D7558.FileName = "PRINT FROM MES SYSTEM"
                D7558.FileType = filename
                D7558.TimeInsert = System_Date_time()
                D7558.DateInsert = Pub.DAT
                D7558.InchargeInsert = Pub.DAT

                Call WRITE_PFK7558(D7558)

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

    Private Sub Auto_Print()

        Dim strFile As String = App_Path & "\Report" & "\" & filename & System_Date_time() & ".xls"

        vSPrint.SaveExcel(strFile, ExcelSaveFlags.UseOOXMLFormat)

        Try
            Dim excel As Application = New Application
            excel.Visible = False
            Dim w As Workbook = excel.Workbooks.Open(strFile)
            w.ActiveSheet.Printout(, , 1)

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

    End Sub

    Private Sub PeaceButton1_Click(sender As Object, e As EventArgs) Handles PeaceButton1.Click
        Dim p As New Process()
        Dim pi As New FarPoint.Win.Spread.PrintInfo()
        Try
            ''''''''''new demo
            Dim a As New SaveFileDialog
            Dim filelocation As String
            a.Filter = "Excel Files 2007 |*.xlsx | Excel Files 2003|*.xlsx "
            a.DefaultExt = "xlsx"
            If a.ShowDialog = DialogResult.OK Then
                filelocation = a.FileName
                vSPrint.ActiveSheet.Protect = False


                'vSPrint.SaveExcel(a.FileName, ExcelSaveFlags.UseOOXMLFormat)
                'vSPrint.SaveExcel(filelocation, FarPoint.Excel.ExcelSaveFlags.SaveBothCustomRowAndColumnHeaders)

                If form_Merge = True Then
                    vSPrint.SaveExcel(filelocation, ExcelSaveFlags.SaveAsViewed)
                Else
                    'vSPrint.SaveExcel(filelocation, FarPoint.Excel.ExcelSaveFlags.SaveBothCustomRowAndColumnHeaders)
                    'vSPrint.SaveExcel(filelocation, FarPoint.Excel.ExcelSaveFlags.UseOOXMLFormat)' Or FarPoint.Excel.ExcelSaveFlags.DocumentCaching)
                    vSPrint.SaveExcel(filelocation, FarPoint.Excel.ExcelSaveFlags.UseOOXMLFormat Or FarPoint.Excel.ExcelSaveFlags.DocumentCaching)
                End If


                D7558_CLEAR()
                D7558.TableName = FormName
                D7558.Parameter = Parameter
                D7558.FileName = "SAVE EXCEL FROM MES SYSTEM"
                D7558.FileType = filename
                D7558.TimeInsert = System_Date_time()
                D7558.DateInsert = Pub.DAT
                D7558.InchargeInsert = Pub.DAT

                Call WRITE_PFK7558(D7558)

                'Call ExportExcel(vSPrint, a.FileName, "", "")
                Dim str = MsgBoxP("Finish. Would you like to open it?", vbYesNo)
                If str = MsgBoxResult.Yes Then
                    Process.Start(filelocation)
                End If

                Exit Sub
            End If
            'end demo''''''''''''''''''''''''''''''''''''


            'Dim a As New SaveFileDialog
            'a.Title = "Save Spread to PDF Format"
            'a.Filter = "Pdf File |*.pdf"
            'a.DefaultExt = "pdf"
            'a.FileName = vSPrint.ActiveSheet.SheetName & "_" & System_Date_8()
            'If a.ShowDialog = DialogResult.OK Then

            '    p.StartInfo.UseShellExecute = True
            '    p.StartInfo.WindowStyle = ProcessWindowStyle.Maximized
            '    ' p.StartInfo.FileName = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\" + filename + ".pdf"
            '    p.StartInfo.FileName = a.FileName

            '    'pi.PdfFileName = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\" + filename + ".pdf"
            '    pi.PdfFileName = a.FileName
            '    pi.PdfWriteMode = PdfWriteMode.New
            '    pi.PdfWriteTo = PdfWriteTo.File
            '    pi.ShowColor = True
            '    pi.Orientation = cmb_Layout.SelectedIndex + 1
            '    If cmb_Layout.SelectedIndex = 0 Then
            '        pi.PaperSize = New Printing.PaperSize("A4", 827, 1169)
            '    Else
            '        pi.PaperSize = New Printing.PaperSize("A4", 827, 1169)
            '    End If
            '    If cmb_Margin.SelectedIndex = 0 Then
            '        pi.Margin = New PrintMargin(75, 25, 25, 25, 30, 30)
            '    ElseIf cmb_Margin.SelectedIndex = 1 Then
            '        pi.Margin = New PrintMargin(100, 100, 100, 100, 50, 50)
            '    ElseIf cmb_Margin.SelectedIndex = 2 Then
            '        pi.Margin = New PrintMargin(25, 75, 25, 75, 75, 75)
            '    ElseIf cmb_Margin.SelectedIndex = 3 Then
            '        pi.Margin = New PrintMargin(txt_Left.Value, txt_Top.Value, txt_Right.Value, txt_Buttom.Value, txt_Header.Value, txt_Footer.Value)
            '    End If
            '    pi.ShowRowHeader = PrintHeader.Hide
            '    pi.ShowColumnHeader = PrintHeader.Hide
            '    pi.PrintToPdf = True
            '    pi.ShowBorder = False

            '    'If chk_Sp.Checked = True Then pi.UseSmartPrint = True

            '    vSPrint.SetPrintInfo(pi, vSPrint.ActiveSheetIndex)
            '    vSPrint.SafePrint(vSPrint, vSPrint.ActiveSheetIndex)
            '    p.Start()
            'End If
        Catch ex As Exception
            MsgBoxP("PDF problem!")
        End Try
    End Sub
    Private Sub PRINTSHEET_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim DSNN As New DataSet
        Dim SQL As String = ""
        Dim solan, sovong As Integer
        Dim i, j, k As Integer
        Dim MAXROW, MAXCOL, IDCOL, IDROWBEGIN, IDROWEND As Integer
        Dim CHECKFIT As String = "2"

        Dim qrc As String = ""
        Dim settings As BarcodeSettings = New BarcodeSettings()
        BarcodeSettings.ApplyKey("0H8YP-M0FO1-9O9ZJ-441BF-WJ1NA")

        Dim SumI As Integer
        Dim da As New SqlClient.SqlDataAdapter
        SumI = 0

        Me.WindowState = FormWindowState.Maximized

        Try
            Dim gdln As New FarPoint.Win.Spread.GridLine(FarPoint.Win.Spread.GridLineType.None)
            Dim str As String

            Try
                str = "http://115.78.15.151:6847/CS_WHM/Report/" & filename & ".xlsx"
                str = "http://"
                str += Pub.SER.Replace(",", ":")
                str += "/CS_WHM/Report/" & filename & ".xlsx"
                'str = "http://115.78.15.151:6847/CS_WHM/Report/" & filename & ".xlsx"

                Dim myWebClient As New WebClient()
                myWebClient.DownloadFile(str, App_Path & "\Report\" & filename & ".xlsx")
                vSPrint.Reset()
                vSPrint.OpenExcel(App_Path & "\Report\" & "\" & filename & ".xlsx", True)

            Catch ex As Exception
                Try
                    str = "http://115.78.15.151:6847/CS_WHM/Report/" & filename & ".xls"
                    str = "http://"
                    str += Pub.SER.Replace(",", ":")
                    str += "/CS_WHM/Report/" & filename & ".xls"
                    'str = "http://115.78.15.151:6847/CS_WHM/Report/" & filename & ".xls"

                    Dim myWebClient As New WebClient()
                    myWebClient.DownloadFile(str, App_Path & "\Report\" & filename & ".xls")
                    vSPrint.Reset()
                    vSPrint.OpenExcel(App_Path & "\Report\" & "\" & filename & ".xls", True)
                Catch exx As Exception

                    Try
                        If My.Computer.FileSystem.DirectoryExists(App_Path & "\Template") = False Then
                            System.IO.Directory.CreateDirectory(App_Path & "\Template")
                        End If

                        vSPrint.OpenExcel(App_Path & "\Template\" & filename & ".xlsx", True)

                    Catch exxx As Exception

                    End Try


                End Try
            End Try

            vSPrint.ActiveSheet.HorizontalGridLine = gdln
            vSPrint.ActiveSheet.VerticalGridLine = gdln

            vSPrint.ActiveSheet.ColumnHeader.Visible = False
            vSPrint.ActiveSheet.RowHeader.Visible = False


            vSPrint.ActiveSheet.ColumnHeader.Visible = True
            vSPrint.ActiveSheet.RowHeader.Visible = True

            vSPrint.ActiveSheet.OperationMode = OperationMode.ReadOnly
            vSPrint.ClipboardOptions = ClipboardOptions.NoHeaders
            vSPrint.AutoClipboard = False
            vSPrint.Enabled = True

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

                CHECKFIT = GetDsData(DSNN, i, "CHECKFIT")

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
                SQL = SQL + " AND [SHEETREPORT] = '" + filename + "'"
                da.SelectCommand = New SqlClient.SqlCommand(SQL, cn)
                da.Fill(DS2)

                For i = 0 To GetDsRc(DS2) - 1
                    For j = 0 To GetDsCc(DS1) - 1
                        If GetColumname(DS1, j) = GetDsData(DS2, i, "IDNAME") Then
                            For k = 0 To GetDsRc(DS1) - 1
                                If GetDsData(DS2, i, "IDROW") + k > GetDsData(DS2, i, "IDROWEND") Then
                                    If GetColumname(DS1, j).ToUpper.Contains("DATE") Or GetColumname(DS1, j).ToUpper.Contains("TIME") Then
                                        setData(vSPrint, GetDsData(DS2, i, "IDCOL"), GetDsData(DS2, i, "IDROW") + k, FSDate(DS1.Tables(0).Rows(k).Item(j)))
                                    Else
                                        If READ_PFK9911(getColumName(DS1, j)) = True Then
                                            If D9911.DataType = "6" Then
                                                Dim DataConvert() As String
                                                DataConvert = Split(D9911.REMK, ";")
                                                setTextConvert(vSPrint, DS1.Tables(0).Rows(k).Item(j), DataConvert, GetDsData(DS2, i, "IDCOL"), GetDsData(DS2, i, "IDROW") + k)

                                            ElseIf GetDsData(DS2, i, "IDNAME").ToString().Contains("QRCODE") Then

                                                Dim barc As New FarPoint.Win.Spread.CellType.BarCodeCellType
                                                Dim xcol As Integer = CIntp(GetDsData(DS2, i, "IDCOL"))
                                                Dim xrow As Integer = CIntp(GetDsData(DS2, i, "IDROW") + k)
                                                Dim Height_Qrcode As Integer = vSPrint.ActiveSheet.Cells(xrow, xcol).Row.Height
                                                Dim Width_Qrcode As Integer = vSPrint.ActiveSheet.Cells(xrow, xcol).Column.Width
                                                qrc = DS1.Tables(0).Rows(k).Item(j)

                                                settings.Type = BarCodeType.QRCode
                                                settings.Unit = GraphicsUnit.Pixel
                                                settings.ShowText = False
                                                settings.ResolutionType = ResolutionType.UseDpi
                                                settings.Data = qrc

                                                settings.ForeColor = Color.Black
                                                settings.BackColor = Color.White
                                                settings.QRCodeECL = QRCodeECL.L
                                                settings.LeftMargin = 10
                                                settings.RightMargin = 10
                                                settings.BottomMargin = 10
                                                settings.TopMargin = 10
                                                settings.X = 10
                                                settings.BarHeight = Height_Qrcode
                                                settings.ResolutionType = ResolutionType.UseDpi
                                                settings.DpiX = 96
                                                settings.DpiY = 96

                                                Dim generator As BarCodeGenerator = New BarCodeGenerator(settings)
                                                Dim QRbarcode As Image = generator.GenerateImage
                                                Dim pic_QRCode As New System.Windows.Forms.PictureBox
                                                pic_QRCode.Image = QRbarcode

                                                Dim bm As Bitmap
                                                bm = New Bitmap(Height_Qrcode, Width_Qrcode)

                                                'Dim d As System.Drawing.Image.GetThumbnailImageAbort
                                                Dim thumbn As Size = New Size(Height_Qrcode, Width_Qrcode)

                                                'bm = pic_QRCode.Image.GetThumbnailImage(thumbn.Width, thumbn.Height, d, IntPtr.Zero)
                                                bm = pic_QRCode.Image

                                                Dim cel As New FarPoint.Win.Spread.CellType.ImageCellType
                                                cel.Style = FarPoint.Win.RenderStyle.StretchAndScale

                                                vSPrint.ActiveSheet.Cells(xrow, xcol).CellType = cel
                                                vSPrint.ActiveSheet.Cells(xrow, xcol).Value = bm
                                            ElseIf GetDsData(DS2, i, "IDNAME").ToString().Contains("IMAGEDATA") Then
                                                Dim xcol As Integer = CIntp(GetDsData(DS2, i, "IDCOL"))
                                                Dim xrow As Integer = CIntp(GetDsData(DS2, i, "IDROW") + k)

                                                Dim cel As New FarPoint.Win.Spread.CellType.ImageCellType
                                                cel.Style = FarPoint.Win.RenderStyle.StretchAndScale

                                                vSPrint.ActiveSheet.Cells(xrow, xcol).CellType = cel
                                                vSPrint.ActiveSheet.Cells(xrow, xcol).Value = DS1.Tables(0).Rows(k).Item(j)
                                                vSPrint.ActiveSheet.Cells(xrow, xcol).VerticalAlignment = CellVerticalAlignment.Center
                                                vSPrint.ActiveSheet.Cells(xrow, xcol).HorizontalAlignment = CellHorizontalAlignment.Center
                                                vSPrint.ActiveSheet.Cells(xrow, xcol).Locked = True
                                            Else
                                                setData(vSPrint, GetDsData(DS2, i, "IDCOL"), GetDsData(DS2, i, "IDROW") + k, DS1.Tables(0).Rows(k).Item(j))
                                            End If
                                        Else
                                            setData(vSPrint, GetDsData(DS2, i, "IDCOL"), GetDsData(DS2, i, "IDROW") + k, DS1.Tables(0).Rows(k).Item(j))
                                        End If
                                    End If
                                Else
                                    If GetColumname(DS1, j).ToUpper.Contains("DATE") Or GetColumname(DS1, j).ToUpper.Contains("TIME") Then
                                        setData(vSPrint, GetDsData(DS2, i, "IDCOL"), GetDsData(DS2, i, "IDROW") + k, FSDate(DS1.Tables(0).Rows(k).Item(j)))
                                    ElseIf GetDsData(DS2, i, "IDNAME").ToString().Contains("QRCODE") Then

                                        Dim barc As New FarPoint.Win.Spread.CellType.BarCodeCellType
                                        Dim xcol As Integer = CIntp(GetDsData(DS2, i, "IDCOL"))
                                        Dim xrow As Integer = CIntp(GetDsData(DS2, i, "IDROW") + k)
                                        Dim Height_Qrcode As Integer = vSPrint.ActiveSheet.Cells(xrow, xcol).Row.Height
                                        Dim Width_Qrcode As Integer = vSPrint.ActiveSheet.Cells(xrow, xcol).Column.Width
                                        qrc = DS1.Tables(0).Rows(k).Item(j)

                                        settings.Type = BarCodeType.QRCode
                                        settings.Unit = GraphicsUnit.Pixel
                                        settings.ShowText = False
                                        settings.ResolutionType = ResolutionType.UseDpi
                                        settings.Data = qrc

                                        settings.ForeColor = Color.Black
                                        settings.BackColor = Color.White
                                        settings.QRCodeECL = QRCodeECL.L

                                        settings.LeftMargin = 10
                                        settings.RightMargin = 10
                                        settings.BottomMargin = 10
                                        settings.TopMargin = 10
                                        settings.X = 10

                                        settings.BarHeight = Height_Qrcode
                                        settings.ResolutionType = ResolutionType.UseDpi

                                        settings.DpiX = 96
                                        settings.DpiY = 96

                                        Dim generator As BarCodeGenerator = New BarCodeGenerator(settings)
                                        Dim QRbarcode As Image = generator.GenerateImage
                                        Dim pic_QRCode As New System.Windows.Forms.PictureBox
                                        pic_QRCode.Image = QRbarcode

                                        Dim bm As Bitmap
                                        bm = New Bitmap(Height_Qrcode, Width_Qrcode)

                                        'NAMNV 20190502 START EDIT
                                        'Dim d As System.Drawing.Image.GetThumbnailImageAbort

                                        Dim thumbn As Size = New Size(Height_Qrcode, Width_Qrcode)

                                        'bm = pic_QRCode.Image.GetThumbnailImage(thumbn.Width, thumbn.Height, d, IntPtr.Zero)

                                        bm = pic_QRCode.Image
                                        'NAMNV 20190502 END EDIT

                                        Dim cel As New FarPoint.Win.Spread.CellType.ImageCellType
                                        cel.Style = FarPoint.Win.RenderStyle.StretchAndScale

                                        vSPrint.ActiveSheet.Cells(xrow, xcol).CellType = cel
                                        vSPrint.ActiveSheet.Cells(xrow, xcol).Value = bm

                                    ElseIf GetDsData(DS2, i, "IDNAME").ToString().Contains("IMAGEDATA") Then

                                        Dim xcol As Integer = CIntp(GetDsData(DS2, i, "IDCOL"))
                                        Dim xrow As Integer = CIntp(GetDsData(DS2, i, "IDROW") + k)

                                        Dim cel As New FarPoint.Win.Spread.CellType.ImageCellType
                                        cel.Style = FarPoint.Win.RenderStyle.StretchAndScale

                                        vSPrint.ActiveSheet.Cells(xrow, xcol).CellType = cel
                                        vSPrint.ActiveSheet.Cells(xrow, xcol).Value = DS1.Tables(0).Rows(k).Item(j)
                                        vSPrint.ActiveSheet.Cells(xrow, xcol).VerticalAlignment = CellVerticalAlignment.Center
                                        vSPrint.ActiveSheet.Cells(xrow, xcol).HorizontalAlignment = CellHorizontalAlignment.Center
                                        vSPrint.ActiveSheet.Cells(xrow, xcol).Locked = True

                                    ElseIf READ_PFK9911(getColumName(DS1, j)) = True Then
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

            If CHECKFIT = "1" Then

                For i = IDROWBEGIN To IDROWEND
                    vSPrint.ActiveSheet.Rows(i).Height = vSPrint.ActiveSheet.Rows(i).GetPreferredHeight
                Next
            End If
           

            If filename.Contains("JOBCARD_CUTTINGCSPT") Then
                Dim xTotalCon As Decimal
                Dim xTotalQty As Decimal
                Dim NewRow As Boolean = True

                For i = IDROWBEGIN To IDROWEND
                    If FormatCut(getData(vSPrint, 3, i)) = "" And NewRow = False Then
                        NewRow = True
                        vSPrint.ActiveSheet.Cells(i, 10).Value = xTotalCon
                        vSPrint.ActiveSheet.Cells(i, 11).Value = xTotalQty
                        xTotalCon = 0
                        xTotalQty = 0
                        GoTo nextx
                    End If

                    xTotalCon += CDecp(getData(vSPrint, 10, i))
                    xTotalQty += CDecp(getData(vSPrint, 11, i))

nextx:
                    NewRow = False
                Next

                If FormatCut(getData(vSPrint, 3, i)) = "" And NewRow = False Then
                    vSPrint.ActiveSheet.Cells(i, 10).Value = xTotalCon
                    vSPrint.ActiveSheet.Cells(i, 11).Value = xTotalQty
                End If

            End If

            If MAXROW > 0 Then

                If filename.Contains("CBD") Or filename.Contains("DINHMUCLAMVIEC") Then
                    For i = IDROWBEGIN To IDROWEND
                        If getData(vSPrint, IDCOL, i) = "" Then
                            vSPrint.ActiveSheet.Rows(i).Visible = False
                        End If
                    Next
                Else
                    For i = IDROWBEGIN To IDROWEND
                        If IsNumeric(getData(vSPrint, IDCOL, i)) = False Then
                            If getData(vSPrint, IDCOL, i) = "" Then
                                vSPrint.ActiveSheet.RemoveRows(i, IDROWEND + 1 - i)

                                Exit For
                            End If
                        Else
                            If getData(vSPrint, IDCOL, i) Is Nothing Then
                                vSPrint.ActiveSheet.RemoveRows(i, IDROWEND + 1 - i)

                                Exit For
                            End If
                        End If
                      
                    Next

                End If
            Else

            End If




            Dim DS2_new As New DataSet

            SQL = " "
            SQL = " SELECT [M_SHEETREPORT],[M_IDCOL],[M_IDROWBEGIN],[M_IDROWEND],[M_VERSION]  FROM [CS_PRINT].[dbo].[A_SHEETPRINT_MERGE] "
            SQL = SQL + " WHERE [M_SHEETREPORT]   = '" + filename + "'"
            da.SelectCommand = New SqlClient.SqlCommand(SQL, cn)
            da.Fill(DS2_new)

            Dim icol, smrow, emrow As Integer

            For xxx As Integer = 0 To GetDsRc(DS2_new) - 1
                icol = GetDsData(DS2_new, xxx, "M_IDCOL")
                smrow = GetDsData(DS2_new, xxx, "M_IDROWBEGIN")
                emrow = GetDsData(DS2_new, xxx, "M_IDROWEND")
                SPR_MERGEALWAYS_COLUMN(icol, vSPrint)
                form_Merge = True
            Next

            vSPrint.ActiveSheet.FrozenColumnCount = 0
            vSPrint.ActiveSheet.FrozenRowCount = 0


            If filename <> "LIQUIDATION_TRACKING_FORM" Then
                vSPrint.ActiveSheet.ZoomFactor = 1
            End If
            isudCHK = True
            formA = True



            If MdiMenu.PREVIEWCHK.Checked = True Then Exit Sub

            cmd_Prt.PerformClick()

            Me.Dispose()

        Catch ex As Exception
            MsgBoxP("PRINTSHEET_Load")
        End Try

    End Sub


    Private Sub PRINTSHEET_PRINT()
        Dim DSNN As New DataSet
        Dim SQL As String = ""
        Dim solan, sovong As Integer
        Dim i, j, k As Integer
        Dim MAXROW, MAXCOL, IDCOL, IDROWBEGIN, IDROWEND As Integer
        Dim SumI As Integer
        Dim da As New SqlClient.SqlDataAdapter
        SumI = 0

        Try
            Dim gdln As New FarPoint.Win.Spread.GridLine(FarPoint.Win.Spread.GridLineType.None)
            Dim str As String

            Try
                str = "http://115.78.15.151:6847/CS_WHM/Report/" & filename & ".xlsx"
                str = "http://"
                str += Pub.SER.Replace(",", ":")
                str += "/CS_WHM/Report/" & filename & ".xlsx"

                Dim myWebClient As New WebClient()
                myWebClient.DownloadFile(str, App_Path & "\Report\" & filename & ".xlsx")
                vSPrint.Reset()
                vSPrint.OpenExcel(App_Path & "\Report\" & "\" & filename & ".xlsx", True)

            Catch ex As Exception
                Try
                    str = "http://115.78.15.151:6847/CS_WHM/Report/" & filename & ".xls"
                    str = "http://"
                    str += Pub.SER.Replace(",", ":")
                    str += "/CS_WHM/Report/" & filename & ".xls"

                    Dim myWebClient As New WebClient()
                    myWebClient.DownloadFile(str, App_Path & "\Report\" & filename & ".xls")
                    vSPrint.Reset()
                    vSPrint.OpenExcel(App_Path & "\Report\" & "\" & filename & ".xls", True)
                Catch exx As Exception

                End Try
            End Try

            vSPrint.ActiveSheet.HorizontalGridLine = gdln
            vSPrint.ActiveSheet.VerticalGridLine = gdln

            vSPrint.ActiveSheet.ColumnHeader.Visible = False
            vSPrint.ActiveSheet.RowHeader.Visible = False


            vSPrint.ActiveSheet.ColumnHeader.Visible = True
            vSPrint.ActiveSheet.RowHeader.Visible = True

            vSPrint.ActiveSheet.OperationMode = OperationMode.ReadOnly
            vSPrint.ClipboardOptions = ClipboardOptions.NoHeaders
            vSPrint.AutoClipboard = False
            vSPrint.Enabled = True

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

            If filename = "ENG_BeakerCard" Then
                Dim DS4 As New DataSet

                SQL = ""
                For sovong = 0 To UBound(Split(chuoi1, ";"))

                    SQL = SQL + Split(chuoi1, ";")(sovong)

                    If SQL.Trim = "" Or sovong > 3 Then GoTo next3

                    For i = 0 To 3

                        'DS4.Reset()
                        If i = 0 Then
                            SQL = SQL + "," + "A"
                            DS4 = PrcDS("USP_ISUD1114A_SEARCH_VS1_SENDING_TYPE", cn, Split(SQL, ","))

                        ElseIf i = 1 Then
                            SQL = SQL + "," + "B"
                            DS4 = PrcDS("USP_ISUD1114A_SEARCH_VS1_SENDING_TYPE", cn, Split(SQL, ","))
                        ElseIf i = 2 Then
                            SQL = SQL + "," + "C"
                            DS4 = PrcDS("USP_ISUD1114A_SEARCH_VS1_SENDING_TYPE", cn, Split(SQL, ","))

                        ElseIf i = 3 Then
                            SQL = SQL + "," + "D"
                            DS4 = PrcDS("USP_ISUD1114A_SEARCH_VS1_SENDING_TYPE", cn, Split(SQL, ","))
                        End If

                        SQL = Strings.Left(SQL, Len(SQL) - 2)
                        Dim LineValue As String = ""

                        For j = 0 To GetDsRc(DS4) - 1
                            LineValue += GetDsData(DS4, j, "cdUnitPrescriptionName") + vbLf
                        Next

                        setData(vSPrint, 1 + 12 * i, 22 + 15 * sovong, LineValue)

                        If sovong = 0 And i = 0 Then
                            DS3 = PrcDS("USP_ISUD1111A_SEARCH_HEAD", cn, GetDsData(DS4, 0, "WDATE"), GetDsData(DS4, 0, "WSEQ"), Const_cdSunLight, Const_cdColorBase)
                            If GetDsRc(DS3) = 0 Then
                                isudCHK = False
                            Else
                                setData(vSPrint, 4, 9, FSDate(System_Date_8))
                                setData(vSPrint, 18, 9, GetDsData(DS3, 0, "InchargeLaboratoryName"))
                                setData(vSPrint, 1, 11, GetDsData(DS3, 0, "ItemName"))
                                setData(vSPrint, 19, 11, GetDsData(DS3, 0, "CustomerName"))
                                setData(vSPrint, 19, 14, GetDsData(DS3, 0, "Buyer"))
                                setData(vSPrint, 31, 13, GetDsData(DS3, 0, "Style"))
                            End If
                        End If

                    Next

                    If sovong = 0 Then
                        DS3 = PrcDS("USP_ISUD1111A_SEARCH_HEAD", cn, GetDsData(DS4, 0, "WDATE"), GetDsData(DS4, 0, "WSEQ"), Const_cdSunLight, Const_cdColorBase)
                        If GetDsRc(DS3) = 0 Then
                            isudCHK = False
                        Else
                            setData(vSPrint, 4, 9, FSDate(System_Date_8))
                            setData(vSPrint, 18, 9, GetDsData(DS3, 0, "InchargeLaboratoryName"))
                            setData(vSPrint, 1, 11, GetDsData(DS3, 0, "ItemName"))
                            setData(vSPrint, 19, 11, GetDsData(DS3, 0, "CustomerName"))
                            setData(vSPrint, 19, 14, GetDsData(DS3, 0, "Buyer"))
                            setData(vSPrint, 31, 13, GetDsData(DS3, 0, "Style"))
                        End If
                    End If
next3:
                    SQL = ""
                Next

                vSPrint.ActiveSheet.FrozenColumnCount = 0
                vSPrint.ActiveSheet.FrozenRowCount = 0
                vSPrint.ActiveSheet.ZoomFactor = 1

                Exit Sub

            End If

            If filename = "ENG_LabCard" Then
                Dim DS4 As New DataSet

                SQL = ""
                For sovong = 0 To UBound(Split(chuoi1, ";"))

                    SQL = SQL + Split(chuoi1, ";")(sovong)

                    If SQL.Trim = "" Or sovong > 3 Then GoTo next2

                    DS4 = PrcDS("USP_ISUD1114A_SEARCH_HEAD", cn, Split(SQL, ","))

                    setData(vSPrint, 5, 18 + 15 * sovong, GetDsData(DS4, 0, "ColorName"))
                    setData(vSPrint, 17, 18 + 15 * sovong, GetDsData(DS4, 0, "BTNO_CNO_AGAIN"))
                    setData(vSPrint, 29, 18 + 15 * sovong, GetDsData(DS4, 0, "DateSending"))
                    setData(vSPrint, 41, 18 + 15 * sovong, GetDsData(DS4, 0, "ColorQuantity"))

                    If sovong = 0 Then
                        DS3 = PrcDS("USP_ISUD1111A_SEARCH_HEAD", cn, GetDsData(DS4, 0, "WDATE"), GetDsData(DS4, 0, "WSEQ"), Const_cdSunLight, Const_cdColorBase)
                        If GetDsRc(DS3) = 0 Then
                            isudCHK = False
                        Else
                            setData(vSPrint, 4, 9, FSDate(System_Date_8))
                            setData(vSPrint, 18, 9, GetDsData(DS3, 0, "InchargeLaboratoryName"))
                            setData(vSPrint, 1, 11, GetDsData(DS3, 0, "ItemName"))
                            setData(vSPrint, 19, 11, GetDsData(DS3, 0, "CustomerName"))
                            setData(vSPrint, 19, 14, GetDsData(DS3, 0, "Buyer"))
                            setData(vSPrint, 31, 13, GetDsData(DS3, 0, "Style"))
                        End If
                    End If
next2:
                    SQL = ""
                Next

                vSPrint.ActiveSheet.FrozenColumnCount = 0
                vSPrint.ActiveSheet.FrozenRowCount = 0
                vSPrint.ActiveSheet.ZoomFactor = 1

                Exit Sub

            End If


            If filename = "ENG_LabRequest" Then
                Dim DS3 As New DataSet
                DS3 = PrcDS("USP_ISUD1111A_SEARCH_VS1", cn, itemcode, itemcodeno, Const_cdColorBase)
                If GetDsRc(DS3) = 0 Then
                    isudCHK = False
                Else
                    For i = 0 To GetDsRc(DS3) - 1
                        If i < 4 Then
                            setData(vSPrint, 4, 16 + 14 * i, GetDsData(DS3, i, "BTNO_CNO_AGAIN"))
                            setData(vSPrint, 7, 19 + 14 * i, GetDsData(DS3, i, "ColorName"))
                            setData(vSPrint, 7, 21 + 14 * i, GetDsData(DS3, i, "cdColorBaseName"))
                            setData(vSPrint, 7, 23 + 14 * i, GetDsData(DS3, i, "ColorQuantity"))
                            setData(vSPrint, 7, 25 + 14 * i, FSDate(GetDsData(DS3, i, "DateStart")))
                            setData(vSPrint, 7, 27 + 14 * i, FSDate(GetDsData(DS3, i, "DateFinish")))
                        Else
                            setData(vSPrint, 28, 16 + 14 * (i - 4), GetDsData(DS3, i, "BTNO_CNO_AGAIN"))
                            setData(vSPrint, 31, 19 + 14 * (i - 4), GetDsData(DS3, i, "ColorName"))
                            setData(vSPrint, 31, 21 + 14 * (i - 4), GetDsData(DS3, i, "cdColorBaseName"))
                            setData(vSPrint, 31, 23 + 14 * (i - 4), GetDsData(DS3, i, "ColorQuantity"))
                            setData(vSPrint, 31, 25 + 14 * (i - 4), FSDate(GetDsData(DS3, i, "DateStart")))
                            setData(vSPrint, 31, 27 + 14 * (i - 4), FSDate(GetDsData(DS3, i, "DateFinish")))
                        End If
                    Next
                    DS3.Reset()
                    DS3 = PrcDS("USP_ISUD1111A_SEARCH_HEAD", cn, itemcode, itemcodeno, Const_cdSunLight, Const_cdColorBase)
                    If GetDsRc(DS3) = 0 Then
                        isudCHK = False
                    Else
                        setData(vSPrint, 4, 9, FSDate(GetDsData(DS3, 0, "DateRequestOrder")))
                        setData(vSPrint, 18, 9, GetDsData(DS3, 0, "InchargeLaboratoryName"))
                        setData(vSPrint, 1, 11, GetDsData(DS3, 0, "ItemName"))
                        setData(vSPrint, 19, 11, GetDsData(DS3, 0, "CustomerName"))
                        setData(vSPrint, 31, 11, GetDsData(DS3, 0, "Style"))
                        setData(vSPrint, 19, 13, GetDsData(DS3, 0, "Buyer"))
                        setData(vSPrint, 31, 13, GetDsData(DS3, 0, "Style"))
                        setData(vSPrint, 11, 43, GetDsData(DS3, 0, "CheckMarketTypeSale"))
                    End If

                    If READ_PFK9911("CheckMarketTypeSale") = True Then
                        If D9911.DataType = "6" Then
                            Dim DataConvert() As String
                            DataConvert = Split(D9911.REMK, ";")
                            setTextConvert(vSPrint, GetDsData(DS3, 0, "CheckMarketTypeSale"), DataConvert, 43, 11)
                        End If
                    End If
                    vSPrint.ActiveSheet.FrozenColumnCount = 0
                    vSPrint.ActiveSheet.FrozenRowCount = 0
                    vSPrint.ActiveSheet.ZoomFactor = 1

                    Exit Sub
                End If
            End If
            If filename = "Item2" Or filename = "VN_Item2" Then
                Dim DS3 As New DataSet
                DS3 = PrcDS("USP_ISUD7822A_SEARCH_VS3", cn, itemcode, itemcodeno)
                If GetDsRc(DS3) = 0 Then
                    isudCHK = False
                Else
                    For i = 0 To GetDsRc(DS3) - 1
                        setData(vSPrint, CInt(GetDsData(DS3, i, "ArrayalSeq")) + 22, 0 + 50, GetDsData(DS3, i, "Warp1"))
                        setData(vSPrint, CInt(GetDsData(DS3, i, "ArrayalSeq")) + 22, 1 + 50, GetDsData(DS3, i, "Warp2"))
                        setData(vSPrint, CInt(GetDsData(DS3, i, "ArrayalSeq")) + 22, 2 + 50, GetDsData(DS3, i, "Warp3"))
                        setData(vSPrint, CInt(GetDsData(DS3, i, "ArrayalSeq")) + 22, 3 + 50, GetDsData(DS3, i, "Warp4"))
                        setData(vSPrint, CInt(GetDsData(DS3, i, "ArrayalSeq")) + 22, 4 + 50, GetDsData(DS3, i, "Warp5"))
                        setData(vSPrint, CInt(GetDsData(DS3, i, "ArrayalSeq")) + 22, 5 + 50, GetDsData(DS3, i, "Warp6"))
                        setData(vSPrint, CInt(GetDsData(DS3, i, "ArrayalSeq")) + 22, 6 + 50, GetDsData(DS3, i, "Warp7"))
                        setData(vSPrint, CInt(GetDsData(DS3, i, "ArrayalSeq")) + 22, 7 + 50, GetDsData(DS3, i, "Warp8"))
                        setData(vSPrint, CInt(GetDsData(DS3, i, "ArrayalSeq")) + 22, 8 + 50, GetDsData(DS3, i, "Warp9"))
                        setData(vSPrint, CInt(GetDsData(DS3, i, "ArrayalSeq")) + 22, 9 + 50, GetDsData(DS3, i, "Warp10"))
                        setData(vSPrint, CInt(GetDsData(DS3, i, "ArrayalSeq")) + 22, 10 + 50, GetDsData(DS3, i, "Warp11"))
                        setData(vSPrint, CInt(GetDsData(DS3, i, "ArrayalSeq")) + 22, 11 + 50, GetDsData(DS3, i, "Warp12"))
                        setData(vSPrint, CInt(GetDsData(DS3, i, "ArrayalSeq")) + 22, 12 + 50, GetDsData(DS3, i, "Warp13"))
                        setData(vSPrint, CInt(GetDsData(DS3, i, "ArrayalSeq")) + 22, 13 + 50, GetDsData(DS3, i, "Warp14"))
                        setData(vSPrint, CInt(GetDsData(DS3, i, "ArrayalSeq")) + 22, 14 + 50, GetDsData(DS3, i, "Warp15"))
                        setData(vSPrint, CInt(GetDsData(DS3, i, "ArrayalSeq")) + 22, 15 + 50, GetDsData(DS3, i, "Warp16"))
                        setData(vSPrint, CInt(GetDsData(DS3, i, "ArrayalSeq")) + 22, 16 + 50, GetDsData(DS3, i, "Warp17"))
                        setData(vSPrint, CInt(GetDsData(DS3, i, "ArrayalSeq")) + 22, 17 + 50, GetDsData(DS3, i, "Warp18"))
                        setData(vSPrint, CInt(GetDsData(DS3, i, "ArrayalSeq")) + 22, 18 + 50, GetDsData(DS3, i, "Warp19"))
                        setData(vSPrint, CInt(GetDsData(DS3, i, "ArrayalSeq")) + 22, 19 + 50, GetDsData(DS3, i, "Warp20"))
                    Next
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
                SQL = SQL + " AND [SHEETREPORT] = '" + filename + "'"
                da.SelectCommand = New SqlClient.SqlCommand(SQL, cn)
                da.Fill(DS2)

                For i = 0 To GetDsRc(DS2) - 1
                    For j = 0 To GetDsCc(DS1) - 1
                        If GetColumname(DS1, j) = GetDsData(DS2, i, "IDNAME") Then
                            For k = 0 To GetDsRc(DS1) - 1
                                If GetDsData(DS2, i, "IDROW") + k > GetDsData(DS2, i, "IDROWEND") Then
                                    If GetColumname(DS1, j).ToUpper.Contains("DATE") Or GetColumname(DS1, j).ToUpper.Contains("TIME") Then
                                        setData(vSPrint, GetDsData(DS2, i, "IDCOL"), GetDsData(DS2, i, "IDROW") + k, FSDate(DS1.Tables(0).Rows(k).Item(j)))
                                    Else
                                        If READ_PFK9911(GetColumname(DS1, j)) = True Then
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
                                    If GetColumname(DS1, j).ToUpper.Contains("DATE") Or GetColumname(DS1, j).ToUpper.Contains("TIME") Then
                                        setData(vSPrint, GetDsData(DS2, i, "IDCOL"), GetDsData(DS2, i, "IDROW") + k, FSDate(DS1.Tables(0).Rows(k).Item(j)))
                                    Else
                                        If READ_PFK9911(GetColumname(DS1, j)) = True Then
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

            Else
                If filename = "ENG_PurchasingOrder" Then
                    For i = 14 To 213
                        If getData(vSPrint, 4, i) = "" Then
                            vSPrint.ActiveSheet.RemoveRows(i, 214 - i)
                            Exit For
                        End If
                    Next
                End If

                If filename = "SP_QuatationSumary" Then
                    For i = 8 To 106
                        If getData(vSPrint, 3, i) = "" Then
                            vSPrint.ActiveSheet.RemoveRows(i, 107 - i)
                            Exit For
                        End If
                    Next
                End If

                If filename = "SP_YeuCauXuatKho" Then
                    For i = 7 To 506
                        If getData(vSPrint, 3, i) = "" Then
                            vSPrint.ActiveSheet.RemoveRows(i, 507 - i)
                            Exit For
                        End If
                    Next
                End If

                If filename = "SP_PurchasingRequest" Then
                    For i = 13 To 510
                        If getData(vSPrint, 3, i) = "" Then
                            vSPrint.ActiveSheet.RemoveRows(i, 511 - i)
                            Exit For
                        End If
                    Next
                End If
            End If

            Dim DS2_new As New DataSet

            SQL = " "
            SQL = " SELECT [M_SHEETREPORT],[M_IDCOL],[M_IDROWBEGIN],[M_IDROWEND],[M_VERSION]  FROM [CS_PRINT].[dbo].[A_SHEETPRINT_MERGE] "
            SQL = SQL + " WHERE [M_SHEETREPORT]   = '" + filename + "'"
            da.SelectCommand = New SqlClient.SqlCommand(SQL, cn)
            da.Fill(DS2_new)

            Dim icol, smrow, emrow As Integer

            For xxx As Integer = 0 To GetDsRc(DS2_new) - 1
                icol = GetDsData(DS2_new, xxx, "M_IDCOL")
                smrow = GetDsData(DS2_new, xxx, "M_IDROWBEGIN")
                emrow = GetDsData(DS2_new, xxx, "M_IDROWEND")

                SPR_MERGEALWAYS_COLUMN(icol, vSPrint)
                form_Merge = True
            Next

            vSPrint.ActiveSheet.FrozenColumnCount = 0
            vSPrint.ActiveSheet.FrozenRowCount = 0
            vSPrint.ActiveSheet.ZoomFactor = 1


            isudCHK = True
            formA = True

            Call auto_Print()

        Catch ex As Exception
            MsgBoxP("PRINTSHEET_Load")
        End Try

    End Sub
    Private Sub NumericUpDown3_ValueChanged(sender As Object, e As EventArgs) Handles chk_Size.ValueChanged
        If formA = False Then Exit Sub
        If chk_Size.Created = True Then vSPrint.ActiveSheet.ZoomFactor = chk_Size.Value / 100
    End Sub

    'Private Sub cmd_Enable_Click(sender As Object, e As EventArgs) Handles cmd_Enable.Click
    '    Dim tmpPW_CHK As String = ""
    '    tmpPW_CHK = "12341234"

    '    Dim f As Form
    '    f = New FPassWord
    '    f.ShowDialog()
    '    If PASSWORDCHECK <> tmpPW_CHK Then MsgBoxP("WRONG PASS!") : Me.Close() : Exit Sub
    '    vSPrint.ActiveSheet.ColumnHeader.Visible = True
    '    vSPrint.ActiveSheet.RowHeader.Visible = True
    '    vSPrint.ActiveSheet.OperationMode = OperationMode.Normal
    '    vSPrint.ClipboardOptions = ClipboardOptions.AllHeaders
    '    vSPrint.AutoClipboard = True
    '    vSPrint.Enabled = True
    'End Sub


    Private Sub cmd_Mail_Click(sender As Object, e As EventArgs) Handles cmd_Mail.Click
        Try
            Dim Outlook As Outlook.Application
            Dim Mail As Outlook.MailItem
            Dim Acc As Outlook.Account

            Outlook = New Outlook.Application()
            Mail = Outlook.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem)
            Mail.To = ""
            Mail.Subject = ""

            'If you have multiple accounts you could change it in sender:
            For Each Acc In Outlook.Session.Accounts
                'Select first pop3 for instance.
                If Acc.AccountType = Microsoft.Office.Interop.Outlook.OlAccountType.olPop3 Then
                    Mail.Sender = Acc
                End If
            Next

            'Take default account if no sender...
            Try
                If Not sender Is Nothing Then Mail.Sender = sender.CurrentUser.AddressEntry
            Catch ex As Exception

            End Try


            'Attach files
            If (Not System.IO.Directory.Exists(App_Path & "\Report")) Then
                System.IO.Directory.CreateDirectory(App_Path & "\Report")
            End If


            Dim strFile As String = App_Path & "\Report" & "\" & filename & ".xls"
            Try
                My.Computer.FileSystem.DeleteFile(strFile)
            Catch ex As Exception

            End Try

            vSPrint.SaveExcel(strFile, ExcelSaveFlags.UseOOXMLFormat)
            Mail.Attachments.Add(strFile)

            Mail.HTMLBody &= "Please refer to attacted file for your information !"

            Mail.Display()

        Catch ex As Exception
            MsgBoxP("Please check your Outlook Mail configuration ! We can not send your file ! ")

        End Try
    End Sub



   
    Private Sub cmd_Enable_Click(sender As Object, e As EventArgs) Handles cmd_Enable.Click
        vSPrint.CopyPasteChk = True
        vSPrint.AutoClipboard = True
        vSPrint.ClipboardOptions = ClipboardOptions.AllHeaders
    End Sub
End Class