Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel
Module M_Excel

#Region "Variable"

#End Region

#Region "Methods"
    Public Sub ChangeTitle(ByRef spd_Control As FarPoint.Win.Spread.FpSpread, FileLocation As String, ByVal Ix_CH1 As List(Of Integer), ByVal str_CH1() As List(Of String))
        Dim objExcel As Object = Nothing

        Dim objWorkbook As Object = Nothing
        Dim objWorksheet As Object = Nothing
        Dim objSpread As SheetView = Nothing
        Dim objActiveSheet As Object = Nothing

        objExcel = CreateObject("Excel.Application")
        objWorkbook = objExcel.Workbooks.Open(FileLocation)
        objWorksheet = objWorkbook.Sheets(1)

        Try
            Dim i, j As Integer
            Dim objCellType As CellType.NumberCellType = Nothing
            Dim DecimalCnt As Integer

            objWorkbook.Sheets(1).Cells(1, 1).Value = Pub.SITENAME
            objWorkbook.Sheets(1).Cells(2, 1).Value = "Print Date: " & FSDateTime(System_Date_time)
            objWorkbook.Sheets(1).Cells(3, 1).Value = "Incharge: " & Pub.NAM

            If Ix_CH1.Count > 0 Then
                For i = 1 To Ix_CH1.Count
                    For j = 1 To str_CH1.Length

                        Select Case TypeName(spd_Control.ActiveSheet.Columns(Ix_CH1(i - 1)).CellType)

                            Case "CurrencyCellType", "NumberCellType"
                                objCellType = spd_Control.ActiveSheet.Columns(Ix_CH1(i - 1)).CellType
                                DecimalCnt = objCellType.DecimalPlaces
                                If DecimalCnt = 0 Then objWorkbook.Sheets(1).range(objWorkbook.Sheets(1).cells(5 + str_CH1.Length, Ix_CH1(i - 1)), objWorkbook.Sheets(1).Cells(objWorkbook.Sheets(1).Rows.Count, Ix_CH1(i - 1))).NumberFormatLocal = "###,###,###,##0 "
                                If DecimalCnt = 1 Then objWorkbook.Sheets(1).range(objWorkbook.Sheets(1).cells(5 + str_CH1.Length, Ix_CH1(i - 1)), objWorkbook.Sheets(1).Cells(objWorkbook.Sheets(1).Rows.Count, Ix_CH1(i - 1))).NumberFormatLocal = "###,###,###,##0.0_ "
                                If DecimalCnt = 2 Then objWorkbook.Sheets(1).range(objWorkbook.Sheets(1).cells(5 + str_CH1.Length, Ix_CH1(i - 1)), objWorkbook.Sheets(1).Cells(objWorkbook.Sheets(1).Rows.Count, Ix_CH1(i - 1))).NumberFormatLocal = "###,###,###,##0.00_ "
                                If DecimalCnt = 3 Then objWorkbook.Sheets(1).range(objWorkbook.Sheets(1).cells(5 + str_CH1.Length, Ix_CH1(i - 1)), objWorkbook.Sheets(1).Cells(objWorkbook.Sheets(1).Rows.Count, Ix_CH1(i - 1))).NumberFormatLocal = "###,###,###,##0.000_ "
                                If DecimalCnt = 4 Then objWorkbook.Sheets(1).range(objWorkbook.Sheets(1).cells(5 + str_CH1.Length, Ix_CH1(i - 1)), objWorkbook.Sheets(1).Cells(objWorkbook.Sheets(1).Rows.Count, Ix_CH1(i - 1))).NumberFormatLocal = "###,###,###,##0.0000_ "
                                If DecimalCnt = 5 Then objWorkbook.Sheets(1).range(objWorkbook.Sheets(1).cells(5 + str_CH1.Length, Ix_CH1(i - 1)), objWorkbook.Sheets(1).Cells(objWorkbook.Sheets(1).Rows.Count, Ix_CH1(i - 1))).NumberFormatLocal = "###,###,###,##0.00000_ "

                                objWorkbook.Sheets(1).Columns(Ix_CH1(i - 1)).Autofit()
                        End Select

                        objWorkbook.Sheets(1).Cells(4 + j, Ix_CH1(i - 1) + 1).Value = str_CH1(j - 1)(i - 1)

                    Next

                Next
            End If

            objExcel.Visible = True

        Catch ex As Exception

        Finally

            My.Forms.MdiMenu.Cursor = Cursors.Default


            If Not (objSpread Is Nothing) Then

                objSpread = Nothing

            End If

            If Not (objActiveSheet Is Nothing) Then

                objActiveSheet = Nothing

            End If

            If Not (objWorksheet Is Nothing) Then

                objWorksheet = Nothing

            End If

            If Not (objWorkbook Is Nothing) Then

                objWorkbook = Nothing

            End If

            If Not (objExcel Is Nothing) Then
                objExcel = Nothing
            End If

        End Try



    End Sub
    Public Sub ExportExcel(ByRef spd_Control As FarPoint.Win.Spread.FpSpread, ByVal headTitle As String, ByVal FileLocation As String)
        Dim ConCat As New FarPoint.Win.Spread.FpSpread

        'Dim objExcel As Excel.Application
        'Dim objWorkbook As Excel.Workbook
        'Dim objWorksheet As Excel.Worksheet
        'Dim objSpread As SheetView = Nothing
        'Dim objActiveSheet As Object = Nothing

        Dim objExcel As Object = Nothing
        Dim objWorkbook As Object = Nothing
        Dim objWorksheet As Object = Nothing
        Dim objSpread As SheetView = Nothing
        Dim objActiveSheet As Object = Nothing

        Dim i As Integer
        Dim Xminues As Integer

        Try
            objExcel = New Excel.Application

            objExcel.DisplayAlerts = False
            objExcel.Visible = False
            objExcel.ScreenUpdating = False

            ConCat.Sheets.Add(Clone(spd_Control.ActiveSheet))
            ConCat.ActiveSheet.Protect = False
            ConCat.BackColor = Color.Empty
            ConCat.ActiveSheet.GrayAreaBackColor = Color.Empty

            ConCat.ActiveSheet.FrozenColumnCount = 0
            ConCat.ActiveSheet.FrozenRowCount = 0

            ConCat.ActiveSheet.ColumnHeader.Columns(-1).BackColor = Color.Empty
            ConCat.ActiveSheet.ColumnHeader.Columns(-1).ForeColor = Color.Black

            Dim cntCHColumn As Integer
            Dim cntCHRow As Integer

            cntCHColumn = ConCat.ActiveSheet.ColumnHeader.Columns.Count
            cntCHRow = ConCat.ActiveSheet.ColumnHeader.RowCount

            ConCat.SaveExcel(FileLocation, FarPoint.Excel.ExcelSaveFlags.SaveBothCustomRowAndColumnHeaders)

            objExcel = CreateObject("Excel.Application")
            objWorkbook = objExcel.Workbooks.Open(FileLocation)
            objWorksheet = objWorkbook.Sheets(1)
            objWorkbook.Sheets(1).Columns(1).Delete()

            Dim v As String

            i = 1


            Dim Col_Letter As String

            Dim vArr


            Do While i <= cntCHColumn 'objWorkbook.Sheets(1).Columns.count

                If objWorkbook.Sheets(1).Columns(i).Hidden = True Then
                    vArr = Split(objWorkbook.Sheets(1).Cells(1, i).Address(True, False), "$")
                    Col_Letter = vArr(0)

                    If objWorkbook.Sheets(1).Range(Col_Letter & "1").MergeCells = True And objWorkbook.Sheets(1).Range(Col_Letter & "2").MergeCells = True Then
                        objWorkbook.Sheets(1).Columns(i).Delete()
                    Else
                        v = objWorkbook.Sheets(1).Cells(1, i).Value
                        objWorkbook.Sheets(1).Columns(i).Delete()
                        objWorkbook.Sheets(1).Cells(1, i).Value = v
                    End If

                    Xminues += 1
                    GoTo next1
                End If
                i = i + 1
next1:
            Loop

            objWorkbook.Sheets(1).Rows(1).EntireRow.Insert()
            objWorkbook.Sheets(1).Rows(1).EntireRow.Insert()
            objWorkbook.Sheets(1).Range("A1") = Trim(headTitle)
            objWorkbook.Sheets(1).Range("A2") = "Print Date: " & FSDate(System_Date_time)


            Dim lngLstCol As Long, lngLstRow As Long

            lngLstRow = objWorkbook.Sheets(1).UsedRange.Rows.Count
            lngLstCol = objWorkbook.Sheets(1).UsedRange.Columns.Count

            With objWorkbook.Sheets(1).Range("A3:" & ColumnLetter(cntCHColumn - Xminues) & lngLstRow).Borders
                .LineStyle = Excel.XlLineStyle.xlContinuous
                .Weight = Excel.XlBorderWeight.xlThin
                .ColorIndex = 1
            End With

            objExcel.Visible = True

        Catch ex As Exception

            My.Forms.MdiMenu.Cursor = Cursors.Default

            If (ex.Message.Equals("ActiveX Problem!.")) Then

                MsgBoxP("Excel function to be revised!")

            Else

            End If

        Finally

            My.Forms.MdiMenu.Cursor = Cursors.Default

            If Not (ConCat Is Nothing) Then

                ConCat = Nothing

            End If

            If Not (objSpread Is Nothing) Then

                objSpread = Nothing

            End If

            If Not (objActiveSheet Is Nothing) Then

                objActiveSheet = Nothing

            End If

            If Not (objWorksheet Is Nothing) Then

                objWorksheet = Nothing

            End If

            If Not (objWorkbook Is Nothing) Then

                objWorkbook = Nothing

            End If

            If Not (objExcel Is Nothing) Then
                objExcel = Nothing
            End If

        End Try

    End Sub
    Function ColumnLetter(ColumnNumber As Long) As String
        Dim n As Long
        Dim c As Byte
        Dim s As String

        n = ColumnNumber
        Do
            c = ((n - 1) Mod 26)
            s = Chr(c + 65) & s
            n = (n - c) \ 26
        Loop While n > 0
        ColumnLetter = s
    End Function

    Private Function Clone(ByVal sheetView As SheetView) As SheetView
        Dim m As New MemoryStream
        Dim b As New BinaryFormatter
        sheetView.SheetName = "New"
        b.Serialize(m, sheetView)
        m.Position = 0

        Return b.Deserialize(m)
    End Function

    Public Sub ExportExcel(ByRef spd_Control As FarPoint.Win.Spread.FpSpread, ByVal headTitle As String, ByVal Lspace As String, ByVal Tspace As String)

        Dim objExcel As Object = Nothing
        Dim objWorkbook As Object = Nothing
        Dim objWorksheet As Object = Nothing
        Dim objSpread As SheetView = Nothing
        Dim objActiveSheet As Object = Nothing

        Try
            My.Forms.MdiMenu.Cursor = Cursors.WaitCursor

            Dim TTspace As Object = Nothing
            Dim i As Integer = 0
            Dim j As Integer = 0
            Dim k As Integer = 0
            Dim lng_a As Integer = 0

            Dim str_tmp As String = ""
            Dim str_tmp1 As String = ""
            Dim str_tmp2 As String = ""
            Dim str_tmp3 As String = ""
            Dim str_tmp4 As String = ""
            Dim DecimalCnt() As Double
            Dim HV() As String
            Dim mYarnge(,) As Object
            Dim cellbackcolor(,) As Object
            Dim cellforecolor(,) As Object

            Dim maxRows As Integer = 0
            Dim maxCols As Integer = 0
            Dim lng_ColHiddenCount As Integer = 0

            objExcel = CreateObject("Excel.Application")

            objSpread = spd_Control.ActiveSheet

            maxRows = objSpread.RowCount
            maxCols = objSpread.ColumnCount

            ReDim mYarnge(maxRows + objSpread.ColumnHeaderRowCount - 1, maxCols - 1)
            ReDim cellbackcolor(maxRows - 1, maxCols - 1)
            ReDim cellforecolor(maxRows - 1, maxCols - 1)
            ReDim DecimalCnt(0 To maxCols - 1)
            ReDim HV(0 To maxCols - 1)

            objWorkbook = objExcel.Workbooks.Add
            objWorksheet = objWorkbook.Worksheets.Add
            headTitle = headTitle

            If headTitle = "" Then headTitle = "No subject"
            'If headTitle.Length > 31 Then headTitle = Mid(headTitle, 1, 31)
            'objWorksheet.Name = FormatCut(headTitle)

            '헤더의 값을 뽑아냄
            For i = 1 To objSpread.ColumnHeaderRowCount

                lng_ColHiddenCount = 0

                For j = 1 To maxCols

                    If (objSpread.ColumnHeader.Columns(j - 1).Visible) Then

                        mYarnge(i - 1, j - lng_ColHiddenCount - 1) = objSpread.ColumnHeader.Cells(i - 1, j - 1).Text.Trim()

                    Else

                        lng_ColHiddenCount = lng_ColHiddenCount + 1

                    End If

                Next j

            Next i

            k = objSpread.ColumnHeaderRowCount - 1

            Dim strCellValue As String

            For i = 1 To maxRows

                lng_ColHiddenCount = 0

                For j = 1 To maxCols

                    If (objSpread.Columns(j - 1).Visible) Then

                        HV(j - 1) = "0"

                        Select Case TypeName(objSpread.Columns(j - 1).CellType)

                            Case "CurrencyCellType", "NumberCellType"

                                mYarnge(k + i, j - lng_ColHiddenCount - 1) = objSpread.Cells(i - 1, j - 1).Text.Trim()

                                Dim objCellType As CellType.NumberCellType = Nothing

                                objCellType = objSpread.Columns(j - 1).CellType
                                DecimalCnt(j - 1) = objCellType.DecimalPlaces

                            Case Else

                                strCellValue = objSpread.Cells(i - 1, j - 1).Text.Trim()

                                If (strCellValue.ToUpper().Equals("TRUE")) Then

                                    mYarnge(k + i, j - lng_ColHiddenCount - 1) = "'1"

                                ElseIf (strCellValue.ToUpper.Equals("FALSE")) Then

                                    mYarnge(k + i, j - lng_ColHiddenCount - 1) = "'0"

                                Else

                                    mYarnge(k + i, j - lng_ColHiddenCount - 1) = "'" & objSpread.Cells(i - 1, j - 1).Text.Trim()

                                End If

                                HV(j - 1) = objSpread.Cells(i - 1, j - 1).HorizontalAlignment

                        End Select

                    Else

                        lng_ColHiddenCount = lng_ColHiddenCount + 1

                    End If


                    cellforecolor(i - 1, j - 1) = objSpread.Cells(i - 1, j - 1).ForeColor
                    cellbackcolor(i - 1, j - 1) = objSpread.Cells(i - 1, j - 1).BackColor

                    If cellbackcolor(i - 1, j - 1).Name = "0" Then cellbackcolor(i - 1, j - 1) = Color.White

                Next j

            Next i


            lng_a = IIf((maxCols - lng_ColHiddenCount) Mod 26 = 0, (maxCols - lng_ColHiddenCount) \ 26 - 1, (maxCols - lng_ColHiddenCount) \ 26)


            If lng_a > 0 Then
                str_tmp = Chr(lng_a + 64)
            Else
                str_tmp = ""
            End If

            str_tmp = str_tmp & Chr(IIf((maxCols - lng_ColHiddenCount) Mod 26 = 0, 26, (maxCols - lng_ColHiddenCount) Mod 26) + 64)
            objWorksheet.Range("A1:" & str_tmp & maxRows + objSpread.ColumnHeaderRowCount) = mYarnge
            objWorksheet.Range("A1:" & str_tmp & maxRows + objSpread.ColumnHeaderRowCount).Font.Size = 9
            objWorksheet.Range("A1:" & str_tmp & objSpread.ColumnHeaderRowCount).Font.Size = 9
            objWorksheet.Range("A1:" & str_tmp & objSpread.ColumnHeaderRowCount).Font.Bold = True
            objWorksheet.Range("A1:" & str_tmp & objSpread.ColumnHeaderRowCount).HorizontalAlignment = 3
            objWorksheet.Range("A1:" & str_tmp & objSpread.ColumnHeaderRowCount).VerticalAlignment = 2
            objWorksheet.Range("A1:" & str_tmp & objSpread.ColumnHeaderRowCount).WrapText = True
            objWorksheet.Range("A1:" & str_tmp & objSpread.ColumnHeaderRowCount).AddIndent = False
            objWorksheet.Range("A1:" & str_tmp & maxRows + objSpread.ColumnHeaderRowCount).Borders.LineStyle = 1
            Try

                For j = 1 To maxCols

                    lng_a = IIf((j - lng_ColHiddenCount - 1) Mod 26 = 0, (j - lng_ColHiddenCount - 1) \ 26 - 1, (j - lng_ColHiddenCount - 1) \ 26)

                    If lng_a > 0 Then
                        str_tmp1 = Chr(lng_a + 64)
                    Else
                        str_tmp1 = ""
                    End If

                    str_tmp1 = str_tmp1 & Chr(IIf((j - lng_ColHiddenCount - 1) Mod 26 = 0, 26, (j - lng_ColHiddenCount - 1) Mod 26) + 64)


                    Select Case TypeName(objSpread.Columns(j - 1).CellType)

                        Case "CurrencyCellType", "NumberCellType"

                            If DecimalCnt(j - 1) = 1 Then objWorksheet.Range(str_tmp1 & ":" & str_tmp1).NumberFormatLocal = "###,###,###,##0.0_ "
                            If DecimalCnt(j - 1) = 2 Then objWorksheet.Range(str_tmp1 & ":" & str_tmp1).NumberFormatLocal = "###,###,###,##0.00_ "
                            If DecimalCnt(j - 1) = 3 Then objWorksheet.Range(str_tmp1 & ":" & str_tmp1).NumberFormatLocal = "###,###,###,##0.000_ "
                            If DecimalCnt(j - 1) = 4 Then objWorksheet.Range(str_tmp1 & ":" & str_tmp1).NumberFormatLocal = "###,###,###,##0.0000_ "
                            If DecimalCnt(j - 1) = 5 Then objWorksheet.Range(str_tmp1 & ":" & str_tmp1).NumberFormatLocal = "###,###,###,##0.00000_ "
                        Case Else
                            If HV(j - 1) = "2" Then objWorksheet.Range(str_tmp1 & ":" & str_tmp1).HorizontalAlignment = 3
                    End Select
                Next j

            Catch ex As Exception
                Error_Message("62", "maxCols ERROR")
            End Try
            objWorksheet.Range("A1:" & str_tmp & "3").Insert()

            If Trim$(Lspace) <> "" Then
                objWorksheet.Range("A1:" & str_tmp & Lspace).Insert()
            End If

            objWorksheet.Range("A1") = Trim(headTitle)

            objWorksheet.Range("A2") = "Print Date: " & FSDate(System_Date_time)

            If Trim$(Tspace) <> "" Then
                TTspace = Split(Tspace, ";")
                For i = 0 To UBound(TTspace)
                    If i = 4 Then Exit For

                    If i = 0 Then
                        objWorksheet.Range("A2") = TTspace(i)

                        With objWorksheet.Range("A2")
                            .Merge()
                            .Font.Bold = True
                            .Font.Size = 9
                            .Font.Name = "Tahoma"
                            .HorizontalAlignment = 2
                            .VerticalAlignment = 2
                        End With
                    End If

                    If i = 1 Then
                        objWorksheet.Range("A3") = TTspace(i)

                        With objWorksheet.Range("A3")
                            .Merge()
                            .Font.Bold = True
                            .Font.Size = 10
                            .Font.Name = "Tahoma"
                            .HorizontalAlignment = 2
                            .VerticalAlignment = 3
                        End With
                    End If

                    If i = 2 Then
                        objWorksheet.Range("A4") = TTspace(i)

                        With objWorksheet.Range("A4")
                            .Merge()
                            .Font.Bold = True
                            .Font.Size = 10
                            .Font.Name = "Tahoma"
                            .HorizontalAlignment = 2
                            .VerticalAlignment = 3
                        End With
                    End If

                    If i = 3 Then
                        objWorksheet.Range("A5") = TTspace(i)

                        With objWorksheet.Range("A5")
                            .Merge()
                            .Font.Bold = True
                            .Font.Size = 10
                            .Font.Name = "Tahoma"
                            .HorizontalAlignment = 2
                            .VerticalAlignment = 3
                        End With
                    End If
                Next i
            End If

            objExcel.Columns.Font.Name = "Tahoma"

            With objWorksheet.Range("A1:" & str_tmp & "1")
                .Merge()
                .Font.Underline = True
                .Font.Bold = True
                .Font.Size = 15
                .HorizontalAlignment = 3
                .VerticalAlignment = 3
            End With


            objActiveSheet = objExcel.ActiveSheet

            'objActiveSheet.PageSetup.Orientation = 1
            'objActiveSheet.PageSetup.Zoom = 90
            'objActiveSheet.PageSetup.draft = False
            'objActiveSheet.PageSetup.fittopageswide = 1
            'objActiveSheet.PageSetup.fittopagestall = 1

            Dim HHH As Double

            HHH = 4
            If IsNumeric(Lspace) = True Then HHH = HHH + CDec(Lspace)

            lng_ColHiddenCount = 0
            '헤더 칼럼들 병합
            For i = 1 To maxCols
                If objSpread.Columns(i - 1).Visible Then

                    For j = 0 To objSpread.ColumnHeaderRowCount - 1

                        Dim objRange As Model.CellRange = Nothing

                        objRange = objSpread.Models.ColumnHeaderSpan.Find(j, i - 1)

                        If Not (objRange Is Nothing) Then

                            If (objRange.ColumnCount > 1 Or objRange.RowCount > 1) Then

                                'str_tmp1 = Chr(objRange.Column + 65)

                                'If (objRange.ColumnCount > 1) Then

                                '    str_tmp3 = Chr(objRange.Column + objRange.ColumnCount - 1 + 65)

                                'Else

                                '    str_tmp3 = str_tmp1
                                'End If

                                str_tmp2 = objRange.Column + 1 - lng_ColHiddenCount
                                If str_tmp2 = 26 Then
                                    '  MsgBox("33")
                                    '  MsgBox((str_tmp2 \ 26) - 1)
                                End If
                                lng_a = IIf((str_tmp2 Mod 25) = 0, (str_tmp2) \ 25 - 1, (str_tmp2) \ 25)
                                If lng_a > 0 Then
                                    str_tmp1 = Chr(lng_a + 64)
                                    str_tmp2 = objRange.Column + 1 - 25 - lng_ColHiddenCount
                                Else
                                    str_tmp1 = ""
                                End If

                                str_tmp1 = str_tmp1 & Chr(IIf((str_tmp2 Mod 25) = 0, 65, (str_tmp2 Mod 25) + 64))


                                str_tmp4 = objRange.Column + objRange.ColumnCount - lng_ColHiddenCount

                                lng_a = IIf(((str_tmp4) Mod 25) = 0, (str_tmp4) \ 25 - 1, (str_tmp4) \ 25)
                                If lng_a > 0 Then
                                    str_tmp3 = Chr(lng_a + 64)
                                    str_tmp4 = objRange.Column + objRange.ColumnCount - 25 - lng_ColHiddenCount
                                Else
                                    str_tmp3 = ""

                                End If

                                str_tmp3 = str_tmp3 & Chr(IIf(((str_tmp4) Mod 25) = 0, 65, (str_tmp4 Mod 25) + 64))


                                objWorksheet.Range(str_tmp1 & objRange.Row + HHH & ":" & str_tmp3 & objRange.Row + HHH + objRange.RowCount - 1).Merge()
                                objWorksheet.Range(str_tmp1 & objRange.Row + HHH & ":" & str_tmp3 & objRange.Row + HHH + objRange.RowCount - 1).HorizontalAlignment = 3
                                objWorksheet.Range(str_tmp1 & objRange.Row + HHH & ":" & str_tmp3 & objRange.Row + HHH + objRange.RowCount - 1).VerticalAlignment = 2

                            End If

                        End If

                        objRange = Nothing

                    Next j
                Else
                    lng_ColHiddenCount = lng_ColHiddenCount + 1
                End If

            Next i

            HHH = HHH + objSpread.ColumnHeaderRowCount - 1
            lng_ColHiddenCount = 0
            For i = 1 To maxCols

                If objSpread.ColumnHeader.Columns(i - 1).Visible Then

                    For j = 0 To objSpread.ColumnHeaderRowCount - 1
                        Dim objRange As Model.CellRange = Nothing

                        'objRange = objSpread.GetSpanCell(j, i - 1)

                        objRange = objSpread.Models.RowHeaderSpan.Find(j, i - 1)

                        If Not (objRange Is Nothing) Then

                            If (objRange.ColumnCount > 1 Or objRange.RowCount > 1) Then

                                ''str_tmp1 = Chr(objRange.Column + 65)

                                ''If (objRange.ColumnCount > 1) Then

                                ''    str_tmp3 = Chr(objRange.Column + objRange.ColumnCount - 1 + 65)

                                ''Else

                                ''    str_tmp3 = str_tmp1
                                ''End If

                                str_tmp2 = objRange.Column + 1 - lng_ColHiddenCount

                                lng_a = IIf((str_tmp2 Mod 25) = 0, (str_tmp2) \ 25 - 1, (str_tmp2) \ 25)
                                If lng_a > 0 Then
                                    str_tmp1 = Chr(lng_a + 64)
                                    str_tmp2 = objRange.Column + 1 - 25 - lng_ColHiddenCount
                                Else
                                    str_tmp1 = ""
                                End If

                                str_tmp1 = str_tmp1 & Chr(IIf((str_tmp2 Mod 25) = 0, 65, (str_tmp2 Mod 25) + 64))


                                str_tmp4 = objRange.Column + objRange.ColumnCount - lng_ColHiddenCount

                                lng_a = IIf(((str_tmp4) Mod 25) = 0, (str_tmp4) \ 25 - 1, (str_tmp4) \ 25)
                                If lng_a > 0 Then
                                    str_tmp3 = Chr(lng_a + 64)
                                    str_tmp4 = objRange.Column + objRange.ColumnCount - 25 - lng_ColHiddenCount
                                Else
                                    str_tmp3 = ""

                                End If

                                str_tmp3 = str_tmp3 & Chr(IIf(((str_tmp4) Mod 25) = 0, 65, (str_tmp4 Mod 25) + 64))

                                objWorksheet.Range(str_tmp1 & objRange.Row + HHH & ":" & str_tmp3 & objRange.Row + HHH + objRange.RowCount - 1).Merge()
                                objWorksheet.Range(str_tmp1 & objRange.Row + HHH & ":" & str_tmp3 & objRange.Row + HHH + objRange.RowCount - 1).HorizontalAlignment = 3
                                objWorksheet.Range(str_tmp1 & objRange.Row + HHH & ":" & str_tmp3 & objRange.Row + HHH + objRange.RowCount - 1).VerticalAlignment = 2

                            End If

                        End If

                        objRange = Nothing

                    Next j
                Else
                    lng_ColHiddenCount = lng_ColHiddenCount + 1
                End If
            Next i

            objWorksheet.Columns.AutoFit()

            objExcel.Visible = True


        Catch ex As Exception

            My.Forms.MdiMenu.Cursor = Cursors.Default

            If (ex.Message.Equals("ActiveX Problem!.")) Then

                MsgBoxP("Excel function to be revised!")

            Else

            End If

        Finally

            My.Forms.MdiMenu.Cursor = Cursors.Default

            If Not (objSpread Is Nothing) Then

                objSpread = Nothing

            End If

            If Not (objActiveSheet Is Nothing) Then

                objActiveSheet = Nothing

            End If

            If Not (objWorksheet Is Nothing) Then

                objWorksheet = Nothing

            End If

            If Not (objWorkbook Is Nothing) Then

                objWorkbook = Nothing

            End If

            If Not (objExcel Is Nothing) Then
                objExcel = Nothing
            End If

        End Try

    End Sub
#End Region

    

End Module
