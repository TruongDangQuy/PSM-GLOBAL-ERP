Imports Spire.Barcode
Imports System.Net
Imports System.IO
Imports FarPoint.Excel
Imports System.Diagnostics
Imports Microsoft.Office.Interop.Excel

Public Class PRINTSHEET_MULTI

#Region "Variables"

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

    Private pform As New Form

#End Region

#Region "Link_Init_Load"


    Private Sub PRINTSHEET_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim DSNN As New DataSet
        Dim SQL As String = ""
        Dim solan, sovong As Integer
        Dim i, j, k, z As Integer
        Dim MAXROW, MAXCOL, IDCOL, IDROWBEGIN, IDROWEND As Integer
        Dim SumI As Integer
        Dim da As New SqlClient.SqlDataAdapter
        SumI = 0

        Dim qrc As String = ""
        Dim settings As BarcodeSettings = New BarcodeSettings()
        BarcodeSettings.ApplyKey("0H8YP-M0FO1-9O9ZJ-441BF-WJ1NA")

        Me.WindowState = FormWindowState.Maximized
        '---------------------------------------------------------------------------------------------------------------------------------------------------------------------

        Try
            Dim gdln As New FarPoint.Win.Spread.GridLine(FarPoint.Win.Spread.GridLineType.None)
            Dim str As String

            Try
                ' str = "http://115.78.15.151:6846/Report/" & filename & ".xlsx"
                str = "http://"
                str += Pub.SER.Replace(",", ":")
                str += "/CS_WHM/Report/" & filename & ".xlsx"

                Dim myWebClient As New WebClient()
                myWebClient.DownloadFile(str, App_Path & "\Report\" & filename & ".xlsx")
                vSPrint.Reset()
                vSPrint.OpenExcel(App_Path & "\Report\" & "\" & filename & ".xlsx", True)

            Catch ex As Exception
                Try
                    'str = "http://115.78.15.151:6846/Report/" & filename & ".xls"

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
            '---------------------------------------------------------------------------------------------------------------------------------------------------------------------

            vSPrint.ClipboardOptions = ClipboardOptions.NoHeaders
            vSPrint.AutoClipboard = False
            vSPrint.Enabled = True

            Dim dsnew As New DataSet

            dsnew = GET_A_SHEETPRINT_MAIN_MULTI(filename, cn)

            If GetDsRc(dsnew) > 0 Then
                vSPrint.Sheets.Count = GetDsRc(dsnew)
                For z = 0 To GetDsRc(dsnew) - 1

                    vSPrint.Sheets(z).HorizontalGridLine = gdln
                    vSPrint.Sheets(z).VerticalGridLine = gdln
                    vSPrint.Sheets(z).ColumnHeader.Visible = False
                    vSPrint.Sheets(z).RowHeader.Visible = False
                    vSPrint.Sheets(z).ColumnHeader.Visible = True
                    vSPrint.Sheets(z).RowHeader.Visible = True
                    vSPrint.Sheets(z).OperationMode = OperationMode.ReadOnly

                    '---------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    SQL = ""
                    SQL = "SELECT * "
                    SQL = SQL + " FROM [CS_PRINT].[dbo].[A_SHEETPRINT_MAIN_MULTI]"
                    SQL = SQL + " WHERE [SHEETREPORT]   = '" + filename + "'  "
                    SQL = SQL + "   AND [SHEETSEQ]      = '" + GetDsData(dsnew, z, "SHEETSEQ") + "'  "
                    da.SelectCommand = New SqlClient.SqlCommand(SQL, cn)
                    da.Fill(DSNN)

                    '---------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    If GetDsRc(DSNN) = 0 Then
                        vSPrint.Sheets(z).RowCount = 1000
                        vSPrint.Sheets(z).ColumnCount = 1000
                    Else
                        MAXROW = CIntp(GetDsData(DSNN, z, "MAXROW"))
                        MAXCOL = CIntp(GetDsData(DSNN, z, "MAXCOL"))
                        IDCOL = CIntp(GetDsData(DSNN, z, "IDCOL"))
                        IDROWBEGIN = CIntp(GetDsData(DSNN, z, "IDROWBEGIN"))
                        IDROWEND = CIntp(GetDsData(DSNN, z, "IDROWEND"))

                        If MAXROW > 0 Then
                            vSPrint.Sheets(z).RowCount = MAXROW + 1
                            vSPrint.Sheets(z).ColumnCount = MAXCOL + 1
                        End If

                    End If

                    '---------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    ChuoiValue1 = ""
                    ChuoiValue2 = ""

                    If GETCHUOI1_MULTI(ChuoiValue1, SheetReportName, GetDsData(dsnew, z, "SHEETSEQ")) = False Then Exit Sub

                    If GETCHUOI2_MULTI(pform, ChuoiValue2, SheetReportName, ChuoiValue1, GetDsData(dsnew, z, "SHEETSEQ")) = False Then Exit Sub

                    chuoi1 = ChuoiValue1

                    chuoi2 = ChuoiValue2
                    '---------------------------------------------------------------------------------------------------------------------------------------------------------------------

                    For solan = 0 To UBound(Split(chuoi1, ";"))
                        SQL = ""
                        For sovong = 0 To UBound(Split(Split(chuoi2, ";")(solan), ","))
                            If sovong = 0 Then
                                SQL = SQL + Split(Split(chuoi2, ";")(solan), ",")(sovong)
                            Else
                                SQL = SQL + "," + Split(Split(chuoi2, ";")(solan), ",")(sovong)
                            End If
                        Next
                        DS1 = PrcDS_NoError(Split(chuoi1, ";")(solan), cn, Split(SQL, ","))

                        Dim DS2 As New DataSet

                        SQL = ""
                        SQL = "SELECT [SHEETNAME],[SHEETSEQ],RIGHT([IDNAME],LEN([IDNAME])-1) AS IDNAME ,[IDSEQ],[IDCOL],[IDROW],[IDROWEND],[IDROWBEGIN] FROM [CS_PRINT].[dbo].[A_SHEETPRINT_MULTI]"
                        SQL = SQL + "  WHERE    [SHEETNAME]     = '" + Split(chuoi1, ";")(solan) + "' "
                        SQL = SQL + "       AND [SHEETREPORT]   = '" + filename + "'"
                        SQL = SQL + "       AND [SHEETSEQ]      = '" + GetDsData(dsnew, z, "SHEETSEQ") + "'  "
                        da.SelectCommand = New SqlClient.SqlCommand(SQL, cn)
                        da.Fill(DS2)

                        For i = 0 To GetDsRc(DS2) - 1
                            For j = 0 To GetDsCc(DS1) - 1
                                If getColumName(DS1, j) = GetDsData(DS2, i, "IDNAME") Then

                                    For k = 0 To GetDsRc(DS1) - 1
                                        'If k = 0 And GetDsRc(DS1) > 1 Then
                                        '    vSPrint.Sheets(CIntp(GetDsData(DS2, i, "SHEETSEQ"))).Rows.Add(CIntp(GetDsData(DS2, i, "IDROW")), GetDsRc(DS1) - 1)
                                        'End If

                                        If GetDsData(DS2, i, "IDROW") + k > GetDsData(DS2, i, "IDROWEND") Then
                                            If getColumName(DS1, j).ToUpper.Contains("DATE") Or getColumName(DS1, j).ToUpper.Contains("TIME") Then
                                                setData_SheetName(vSPrint, GetDsData(dsnew, z, "SHEETSEQ"), GetDsData(DS2, i, "IDCOL"), GetDsData(DS2, i, "IDROW") + k, FSDate(DS1.Tables(0).Rows(k).Item(j)))
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

                                                Dim thumbn As Size = New Size(Height_Qrcode, Width_Qrcode)
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
                                                If READ_PFK9911(getColumName(DS1, j)) = True Then
                                                    If D9911.DataType = "6" Then
                                                        Dim DataConvert() As String
                                                        DataConvert = Split(D9911.REMK, ";")
                                                        setTextConvert(vSPrint, DS1.Tables(0).Rows(k).Item(j), DataConvert, GetDsData(DS2, i, "IDCOL"), GetDsData(DS2, i, "IDROW") + k)
                                                    Else
                                                        setData_SheetName(vSPrint, GetDsData(dsnew, z, "SHEETSEQ"), GetDsData(DS2, i, "IDCOL"), GetDsData(DS2, i, "IDROW") + k, DS1.Tables(0).Rows(k).Item(j))
                                                    End If
                                                Else
                                                    setData_SheetName(vSPrint, GetDsData(dsnew, z, "SHEETSEQ"), GetDsData(DS2, i, "IDCOL"), GetDsData(DS2, i, "IDROW") + k, DS1.Tables(0).Rows(k).Item(j))
                                                End If
                                            End If
                                        Else
                                            If getColumName(DS1, j).ToUpper.Contains("DATE") Or getColumName(DS1, j).ToUpper.Contains("TIME") Then
                                                setData_SheetName(vSPrint, GetDsData(dsnew, z, "SHEETSEQ"), GetDsData(DS2, i, "IDCOL"), GetDsData(DS2, i, "IDROW") + k, FSDate(DS1.Tables(0).Rows(k).Item(j)))
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

                                                Dim thumbn As Size = New Size(Height_Qrcode, Width_Qrcode)
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
                                                If READ_PFK9911(getColumName(DS1, j)) = True Then
                                                    If D9911.DataType = "6" Then
                                                        Dim DataConvert() As String
                                                        DataConvert = Split(D9911.REMK, ";")
                                                        setTextConvert(vSPrint, DS1.Tables(0).Rows(k).Item(j), DataConvert, GetDsData(DS2, i, "IDCOL"), GetDsData(DS2, i, "IDROW") + k)
                                                    Else
                                                        setData_SheetName(vSPrint, GetDsData(dsnew, z, "SHEETSEQ"), GetDsData(DS2, i, "IDCOL"), GetDsData(DS2, i, "IDROW") + k, DS1.Tables(0).Rows(k).Item(j))
                                                    End If
                                                Else
                                                    setData_SheetName(vSPrint, GetDsData(dsnew, z, "SHEETSEQ"), GetDsData(DS2, i, "IDCOL"), GetDsData(DS2, i, "IDROW") + k, DS1.Tables(0).Rows(k).Item(j))
                                                End If
                                            End If

                                        End If
                                    Next
                                End If

                            Next
                            If GetDsData(DS2, i, "IDNAME").Length > 4 Then
                                If Strings.Left(GetDsData(DS2, i, "IDNAME"), 3) = "um@" Then
                                    For SumI = CIntp(GetDsData(DS2, i, "IDROWBEGIN")) To CIntp(GetDsData(DS2, i, "IDROWEND"))

                                        vSPrint.Sheets(z).Cells(GetDsData(DS2, i, "IDROW"), GetDsData(DS2, i, "IDCOL")).Value += getData_SheetName(vSPrint, GetDsData(dsnew, z, "SHEETSEQ"), GetDsData(DS2, i, "IDCOL"), SumI)
                                        Dim so As Double

                                        so = CDblp(vSPrint.Sheets(z).Cells(GetDsData(DS2, i, "IDROW"), GetDsData(DS2, i, "IDCOL")).Value)
                                    Next
                                End If
                            End If
                        Next

                    Next

                   

                    vSPrint.ActiveSheet.FrozenColumnCount = 0
                    vSPrint.ActiveSheet.FrozenRowCount = 0
                    vSPrint.ActiveSheet.ZoomFactor = 1

                    isudCHK = True
                    formA = True


                    If MAXROW > 0 Then

                        For i = IDROWBEGIN To IDROWEND
                            If vSPrint.Sheets(z).Cells(i, IDCOL).Value = "" Then
                                vSPrint.Sheets(z).RemoveRows(i, IDROWEND + 1 - i)
                                Exit For
                            End If
                        Next

                    Else

                    End If

                Next

               

            End If

            

            If MdiMenu.PREVIEWCHK.Checked = True Then Exit Sub

            cmd_Prt.PerformClick()

            Me.Dispose()

        Catch ex As Exception
            MsgBoxP("PRINTSHEET_Load")
        End Try

    End Sub

    Private Sub Data_Inti()
        cmb_Kind.SelectedIndex = 0
        cmb_Layout.SelectedIndex = 0
        cmb_Margin.SelectedIndex = 0
    End Sub

    Public Function Link_PrintSheet(SheetFileName As String, ByVal chuoi11 As String, ByVal chuoi22 As String, StartingContainer As Form) As Boolean

        Link_PrintSheet = False

        filename = SheetFileName
        chuoi1 = chuoi11
        chuoi2 = chuoi22
        pform = StartingContainer

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

    Public Function Link_PrintSheet(SheetFileName As String, ByVal Check As Boolean, ByVal chuoi11 As String, StartingContainer As Form) As Boolean

        Link_PrintSheet = False
        filename = SheetFileName
        chuoi1 = chuoi11
        pform = StartingContainer
        Data_Inti()
        Me.ShowDialog()
        Link_PrintSheet = isudCHK

    End Function

#End Region

#Region "Functions"

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

    Public Function GET_A_SHEETPRINT_MAIN_MULTI(filename As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = ""
            SQL = "SELECT * "
            SQL = SQL + " FROM [CS_PRINT].[dbo].[A_SHEETPRINT_MAIN_MULTI]"
            SQL = SQL + " WHERE [SHEETREPORT] = '" + filename + "'  "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, cn)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("GET_A_SHEETPRINT_MAIN_MULTI", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    Public Function GETCHUOI1_MULTI(ByRef chuoi1 As String, sheetname As String, sheetseq As String) As Boolean
        GETCHUOI1_MULTI = False

        Dim ds As New DataSet
        Dim dsbackup As New DataSet
        Dim cmd As New SqlClient.SqlCommand
        Dim SQL As String
        Dim i As Integer

        Try
            chuoi1 = ""

            SQL = "SELECT SHEETNAME,SHEETSEQ FROM [CS_PRINT].[dbo].[A_SHEETPRINT_MULTI]"
            SQL = SQL + " WHERE SHEETREPORT = '" + sheetname + "'"
            SQL = SQL + "   AND SHEETSEQ    = '" + sheetseq + "'"
            SQL = SQL + " GROUP BY  SHEETNAME,SHEETSEQ "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            da.SelectCommand = cmd
            da.Fill(ds)

            For i = 0 To GetDsRc(ds) - 1
                If i = GetDsRc(ds) - 1 Then chuoi1 += GetDsData(ds, i, 0) : Exit For
                chuoi1 += GetDsData(ds, i, 0) + ";"
            Next

            GETCHUOI1_MULTI = True

        Catch ex As Exception
            MsgBoxP("GETCHUOI1_MULTI")
        End Try
    End Function

    Public Function GETCHUOI2_MULTI(StartingContainer As PeaceForm, ByRef chuoi2 As String, sheetname As String, chuoi1 As String, sheetseq As String) As Boolean
        GETCHUOI2_MULTI = False
        Dim cmd As New SqlClient.SqlCommand
        Dim SQL As String
        Dim i, j As Integer
        Dim StoreNo As Integer
        Dim AllType As List(Of Object)

        StoreNo = Split(chuoi1, ";").Length
        AllType = StartingContainer.FindAllType

        Try
            chuoi2 = ""
            For i = 0 To StoreNo - 1

                Dim ds As New DataSet
                SQL = "SELECT REPLACE([PARANAME],'@','') AS PARANAME  FROM [CS_PRINT].[dbo].[A_SHEETNAME_PARA_MULTI] "
                SQL = SQL + " WHERE SHEETREPORT = '" + sheetname + "'"
                SQL = SQL + "   AND SHEETSEQ    = '" + sheetseq + "'"
                SQL = SQL + "   AND SHEETNAME   = '" + Split(chuoi1, ";")(i) + "'"

                cmd = New SqlClient.SqlCommand(SQL, cn)
                da.SelectCommand = cmd
                da.Fill(ds)

                For j = 0 To GetDsRc(ds) - 1
                    Dim Value As String
                    Value = GetDsData(ds, j, 0)
                    If j = GetDsRc(ds) - 1 Then
                        If Value.Contains("Const") Then
                            chuoi2 += SELCON(GetDsData(ds, j, 0))
                        Else
                            chuoi2 += FindTypeValue(AllType, Value)
                            'chuoi2 += Value
                        End If
                    Else
                        If Value.Contains("Const") Then
                            chuoi2 += SELCON(GetDsData(ds, j, 0)) + ","
                        Else
                            chuoi2 += FindTypeValue(AllType, Value) + ","
                        End If
                    End If
                Next

                If i = StoreNo - 1 Then Exit For
                chuoi2 += ";"
            Next

            GETCHUOI2_MULTI = True
        Catch ex As Exception
            MsgBoxP("GETCHUOI2_MULTI")
        End Try
    End Function

    Public Sub setData_SheetName(ByVal fpsA As FarPoint.Win.Spread.FpSpread, ByVal Sheet As Integer, ByVal Col As Integer, ByVal Row As Integer, ByVal Value As Object, Optional ByVal Style As String = "", Optional ByVal UseCheck As Boolean = False)
        Try

            If UseCheck = False Then

                If IsDBNull(Value) = True Then
                    Value = ""
                End If

                If IsNumeric(Value) And Style <> "" Then
                    Value = Format(CDbl(Value), Style)
                ElseIf CStr(Value) <> "" And Style <> "" Then
                    Value = Format(CStr(Value), Style)
                End If

            Else

                Dim cel As New FarPoint.Win.Spread.CellType.CheckBoxCellType

                cel.Picture.False = My.Resources.riB_NO
                cel.Picture.FalseDisabled = My.Resources.riB_NO
                cel.Picture.FalsePressed = My.Resources.riB_NO
                cel.Picture.True = My.Resources.riB_YES
                cel.Picture.TrueDisabled = My.Resources.riB_YES
                cel.Picture.TruePressed = My.Resources.riB_YES

                fpsA.Sheets(Sheet).Cells(Row, Col).CellType = cel

                If CDblp(Value) = 0 Or CDblp(Value) = 2 Then Value = False
                If CDblp(Value) = 1 Then Value = True

            End If

            If Value.ToString.Contains("#Enter#") = True Then
                Value = Value.Trim.ToString.Replace("#Enter#", "")

                For j As Integer = 0 To Value.trim.ToString.Split(Chr(13)).Length - 1
                    fpsA.Sheets(Sheet).SetValue(Row + j, Col, Value.Trim.ToString.Split(ChrW(Keys.Enter))(j))

                Next


            Else
                fpsA.Sheets(Sheet).SetValue(Row, Col, Value)
            End If


        Catch ex As Exception

        End Try
    End Sub

    Public Function getData_SheetName(ByVal fpsA As FarPoint.Win.Spread.FpSpread, ByVal sheets As Integer, ByVal Col As Integer, ByVal Row As Integer) As Object
        Try
            Return fpsA.Sheets(sheets).GetValue(Row, Col)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Sub PRINTSHEET_PRINT()
        Dim DSNN As New DataSet
        Dim SQL As String = ""
        Dim solan, sovong As Integer
        Dim i, j, k As Integer
        Dim MAXROW, MAXCOL, IDCOL, IDROWBEGIN, IDROWEND As Integer
        Dim SumI As Integer
        Dim da As New SqlClient.SqlDataAdapter
        SumI = 0

        Dim qrc As String = ""
        Dim settings As BarcodeSettings = New BarcodeSettings()
        BarcodeSettings.ApplyKey("0H8YP-M0FO1-9O9ZJ-441BF-WJ1NA")


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
            SQL = SQL + " FROM [CS_PRINT].[dbo].[A_SHEETPRINT_MAIN_MULTI]"
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
                            DS4 = PrcDS_NoError("USP_ISUD1114A_SEARCH_VS1_SENDING_TYPE", cn, Split(SQL, ","))

                        ElseIf i = 1 Then
                            SQL = SQL + "," + "B"
                            DS4 = PrcDS_NoError("USP_ISUD1114A_SEARCH_VS1_SENDING_TYPE", cn, Split(SQL, ","))
                        ElseIf i = 2 Then
                            SQL = SQL + "," + "C"
                            DS4 = PrcDS_NoError("USP_ISUD1114A_SEARCH_VS1_SENDING_TYPE", cn, Split(SQL, ","))

                        ElseIf i = 3 Then
                            SQL = SQL + "," + "D"
                            DS4 = PrcDS_NoError("USP_ISUD1114A_SEARCH_VS1_SENDING_TYPE", cn, Split(SQL, ","))
                        End If

                        SQL = Strings.Left(SQL, Len(SQL) - 2)
                        Dim LineValue As String = ""

                        For j = 0 To GetDsRc(DS4) - 1
                            LineValue += GetDsData(DS4, j, "cdUnitPrescriptionName") + vbLf
                        Next

                        setData(vSPrint, 1 + 12 * i, 22 + 15 * sovong, LineValue)

                        If sovong = 0 And i = 0 Then
                            DS3 = PrcDS_NoError("USP_ISUD1111A_SEARCH_HEAD", cn, GetDsData(DS4, 0, "WDATE"), GetDsData(DS4, 0, "WSEQ"), "", "")
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
                        DS3 = PrcDS_NoError("USP_ISUD1111A_SEARCH_HEAD", cn, GetDsData(DS4, 0, "WDATE"), GetDsData(DS4, 0, "WSEQ"), "", "")
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

                    DS4 = PrcDS_NoError("USP_ISUD1114A_SEARCH_HEAD", cn, Split(SQL, ","))

                    setData(vSPrint, 5, 18 + 15 * sovong, GetDsData(DS4, 0, "ColorName"))
                    setData(vSPrint, 17, 18 + 15 * sovong, GetDsData(DS4, 0, "BTNO_CNO_AGAIN"))
                    setData(vSPrint, 29, 18 + 15 * sovong, GetDsData(DS4, 0, "DateSending"))
                    setData(vSPrint, 41, 18 + 15 * sovong, GetDsData(DS4, 0, "ColorQuantity"))

                    If sovong = 0 Then
                        DS3 = PrcDS_NoError("USP_ISUD1111A_SEARCH_HEAD", cn, GetDsData(DS4, 0, "WDATE"), GetDsData(DS4, 0, "WSEQ"), "", "")
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
                DS3 = PrcDS_NoError("USP_ISUD1111A_SEARCH_VS1", cn, itemcode, itemcodeno, "")
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
                    DS3 = PrcDS_NoError("USP_ISUD1111A_SEARCH_HEAD", cn, itemcode, itemcodeno, "", """")
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
                DS3 = PrcDS_NoError("USP_ISUD7822A_SEARCH_VS3", cn, itemcode, itemcodeno)
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
                DS1 = PrcDS_NoError(Split(chuoi1, ";")(solan), cn, Split(SQL, ","))

                Dim DS2 As New DataSet

                SQL = ""
                SQL = "SELECT [SHEETNAME],RIGHT([IDNAME],LEN([IDNAME])-1) AS IDNAME ,[IDSEQ],[IDCOL],[IDROW],[IDROWEND],[IDROWBEGIN] FROM [CS_PRINT].[dbo].[A_SHEETPRINT]"
                SQL = SQL + "  WHERE    [SHEETNAME]     = '" + Split(chuoi1, ";")(solan) + "' "
                SQL = SQL + "   AND     [SHEETREPORT]   = '" + filename + "'"
                da.SelectCommand = New SqlClient.SqlCommand(SQL, cn)
                da.Fill(DS2)

                'For i = 0 To GetDsRc(DS2) - 1
                '    For j = 0 To GetDsCc(DS1) - 1
                '        If getColumName(DS1, j) = GetDsData(DS2, i, "IDNAME") Then
                '            For k = 0 To GetDsRc(DS1) - 1
                '                If GetDsData(DS2, i, "IDROW") + k > GetDsData(DS2, i, "IDROWEND") Then
                '                    If getColumName(DS1, j).ToUpper.Contains("DATE") Or getColumName(DS1, j).ToUpper.Contains("TIME") Then
                '                        setData(vSPrint, GetDsData(DS2, i, "IDCOL"), GetDsData(DS2, i, "IDROW") + k, FSDate(DS1.Tables(0).Rows(k).Item(j)))
                '                    Else
                '                        If READ_PFK9911(getColumName(DS1, j)) = True Then
                '                            If D9911.DataType = "6" Then
                '                                Dim DataConvert() As String
                '                                DataConvert = Split(D9911.REMK, ";")
                '                                setTextConvert(vSPrint, DS1.Tables(0).Rows(k).Item(j), DataConvert, GetDsData(DS2, i, "IDCOL"), GetDsData(DS2, i, "IDROW") + k)
                '                            Else
                '                                setData(vSPrint, GetDsData(DS2, i, "IDCOL"), GetDsData(DS2, i, "IDROW") + k, DS1.Tables(0).Rows(k).Item(j))
                '                            End If
                '                        Else
                '                            setData(vSPrint, GetDsData(DS2, i, "IDCOL"), GetDsData(DS2, i, "IDROW") + k, DS1.Tables(0).Rows(k).Item(j))
                '                        End If
                '                    End If
                '                Else
                '                    If getColumName(DS1, j).ToUpper.Contains("DATE") Or getColumName(DS1, j).ToUpper.Contains("TIME") Then
                '                        setData(vSPrint, GetDsData(DS2, i, "IDCOL"), GetDsData(DS2, i, "IDROW") + k, FSDate(DS1.Tables(0).Rows(k).Item(j)))
                '                    Else
                '                        If READ_PFK9911(getColumName(DS1, j)) = True Then
                '                            If D9911.DataType = "6" Then
                '                                Dim DataConvert() As String
                '                                DataConvert = Split(D9911.REMK, ";")
                '                                setTextConvert(vSPrint, DS1.Tables(0).Rows(k).Item(j), DataConvert, GetDsData(DS2, i, "IDCOL"), GetDsData(DS2, i, "IDROW") + k)
                '                            Else
                '                                setData(vSPrint, GetDsData(DS2, i, "IDCOL"), GetDsData(DS2, i, "IDROW") + k, DS1.Tables(0).Rows(k).Item(j))
                '                            End If
                '                        Else
                '                            setData(vSPrint, GetDsData(DS2, i, "IDCOL"), GetDsData(DS2, i, "IDROW") + k, DS1.Tables(0).Rows(k).Item(j))
                '                        End If
                '                    End If

                '                End If
                '            Next
                '        End If

                '    Next
                '    If GetDsData(DS2, i, "IDNAME").Length > 4 Then
                '        If Strings.Left(GetDsData(DS2, i, "IDNAME"), 3) = "um@" Then
                '            For SumI = CIntp(GetDsData(DS2, i, "IDROWBEGIN")) To CIntp(GetDsData(DS2, i, "IDROWEND"))
                '                vSPrint.ActiveSheet.Cells(GetDsData(DS2, i, "IDROW"), GetDsData(DS2, i, "IDCOL")).Value += getData(vSPrint, GetDsData(DS2, i, "IDCOL"), SumI)
                '                Dim so As Double
                '                so = CDblp(vSPrint.ActiveSheet.Cells(GetDsData(DS2, i, "IDROW"), GetDsData(DS2, i, "IDCOL")).Value)
                '            Next
                '        End If
                '    End If
                'Next

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

                                                Dim thumbn As Size = New Size(Height_Qrcode, Width_Qrcode)
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
                                    If getColumName(DS1, j).ToUpper.Contains("DATE") Or getColumName(DS1, j).ToUpper.Contains("TIME") Then
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

                                        Dim thumbn As Size = New Size(Height_Qrcode, Width_Qrcode)
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

            If MAXROW > 0 Then

                For i = IDROWBEGIN To IDROWEND
                    If getData(vSPrint, IDCOL, i) = "" Then
                        vSPrint.ActiveSheet.RemoveRows(i, IDROWEND + 1 - i)
                        Exit For
                    End If
                Next
            End If

            vSPrint.ActiveSheet.FrozenColumnCount = 0
            vSPrint.ActiveSheet.FrozenRowCount = 0
            vSPrint.ActiveSheet.ZoomFactor = 1

            isudCHK = True
            formA = True

            Call Auto_Print()

        Catch ex As Exception
            MsgBoxP("PRINTSHEET_Load")
        End Try

    End Sub

#End Region

#Region "Events"

    Private Sub cmd_Cancel_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        Me.Close()
    End Sub

    Private Sub cmd_Prt_Click(sender As Object, e As EventArgs) Handles cmd_Prt.Click
        Dim PrintDialog1 As New PrintDialog

        If PrintDialog1.ShowDialog = DialogResult.OK Then

            Dim strFile As String = App_Path & "\Report" & "\" & filename & System_Date_time() & ".xls"

            'vSPrint.SaveExcel(strFile, ExcelSaveFlags.UseOOXMLFormat)
            vSPrint.SaveExcel(strFile, ExcelSaveFlags.SaveBothCustomRowAndColumnHeaders)

            Try
                Dim excel As Application = New Application
                excel.Visible = False
                Dim w As Workbook = excel.Workbooks.Open(strFile)
                w.ActiveSheet.Printout(, , PrintDialog1.PrinterSettings.Copies, False, PrintDialog1.PrinterSettings.PrinterName)

                w.Close(SaveChanges:=False)
                excel.Quit()
                Me.Dispose()
                SheetReport.Dispose()
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
            a.Filter = "Excel Files 2007 |*.xlsx | Excel Files 2003|*.xlsx "
            a.DefaultExt = "xlsx"

            If a.ShowDialog = DialogResult.OK Then
                filelocation = a.FileName
                vSPrint.ActiveSheet.Protect = False


                vSPrint.SaveExcel(filelocation, FarPoint.Excel.ExcelSaveFlags.UseOOXMLFormat Or FarPoint.Excel.ExcelSaveFlags.DocumentCaching)

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

    Private Sub NumericUpDown3_ValueChanged(sender As Object, e As EventArgs) Handles chk_Size.ValueChanged
        If formA = False Then Exit Sub
        If chk_Size.Created = True Then vSPrint.ActiveSheet.ZoomFactor = chk_Size.Value / 100
    End Sub

    Private Sub cmd_Enable_Click(sender As Object, e As EventArgs) Handles cmd_Enable.Click
        Dim tmpPW_CHK As String = ""
        tmpPW_CHK = "12341234"

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

#End Region

End Class