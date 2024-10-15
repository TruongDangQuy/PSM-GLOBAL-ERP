Imports System.Net
Imports System.IO
Public Class PFP99114

#Region "Variable"

    Private checkrn As Boolean = False
    Private a9911() As T9911_AREA
    Private L9911 As T9911_AREA

    Private a9912() As T9912_AREA
    Private L9912 As T9912_AREA

    Private FileUpload As String

    Private xcol As Integer
    Private textt As New FarPoint.Win.Spread.CellType.TextCellType
    Private numbt As New FarPoint.Win.Spread.CellType.NumberCellType
    Private buttt As New FarPoint.Win.Spread.CellType.ButtonCellType
    Private combt As New FarPoint.Win.Spread.CellType.ComboBoxCellType
    Private chkt As New FarPoint.Win.Spread.CellType.CheckBoxCellType
    Private cellick As Boolean = False

#End Region

#Region "Form_load"

    Private Sub SPREAD_SETUP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        form_int()
        data_int()
        '  DATA_SEARCH()
    End Sub

    Private Sub form_int()
        L9911 = D9911
        L9912 = D9912
    End Sub

    Private Sub data_int()

    End Sub

#End Region

#Region "Function"


    Private Sub DATA_SEARCH()
        cellick = False
        Dim SQL As String
        Dim RS01 As DataRow = Nothing
        Dim i As Integer = 0
        Dim j As Integer = 0
        Try
            SQL = ""
            SQL = SQL + "SELECT A.name as ID"
            SQL = SQL + "      ,count(A.object_id) AS QTY"
            SQL = SQL + "      FROM sys.procedures A"
            SQL = SQL + "      INNER JOIN sys.parameters B"
            SQL = SQL + "       ON A.object_id = B.object_id"
            If txt_NAME.Data.Trim <> "" Then SQL = SQL + "   WHERE A.name LIKE '%" + txt_NAME.Data.Trim + "%' "
            SQL = SQL + "      GROUP BY A.name"
            cmd = New SqlClient.SqlCommand(SQL, cn)
            da.SelectCommand = cmd
            ds.Reset()
            da.Fill(ds)
            i = 0

            For Each RS01 In ds.Tables(0).Rows
                vS2.ActiveSheet.RowCount = i + 1
                setData(vS2, 0, i, GetDsData(ds, i, "ID"))
                setData(vS2, 1, i, GetDsData(ds, i, "QTY"))
                i += 1
            Next
        Catch ex As Exception

        End Try
    End Sub


#End Region

#Region "Event"

    Private Sub cmd_Cancel_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        Me.Dispose()
    End Sub

    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Dim counti As Integer
        Dim i, j As Integer
        Dim SQL As String

        Try


            'DELETE A_SHEETPRINT_MAIN_MULTI
            '----------------------------------------------------------------------------------------------------'
            SQL = "DELETE FROM [CS_PRINT].[dbo].[A_SHEETPRINT_MAIN_MULTI]"
            SQL = SQL + " WHERE SHEETREPORT = '" + proname1.Data + "'"
            SQL = SQL + " AND SHEETSEQ = '" + Vs1.ActiveSheetIndex.ToString + "'"
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            'DELETE A_SHEETNAME_PARA_MULTI
            '----------------------------------------------------------------------------------------------------'
            SQL = "DELETE FROM [CS_PRINT].[dbo].[A_SHEETNAME_PARA_MULTI]"
            SQL = SQL + " WHERE SHEETNAME   = '" + getData(Vs1, 0, 0) + "'"
            SQL = SQL + "   AND SHEETREPORT = '" + proname1.Data + "'"
            SQL = SQL + "   AND SHEETSEQ    = '" + Vs1.ActiveSheetIndex.ToString + "'"

            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            For i = 0 To vS4.ActiveSheet.RowCount - 1
                SQL = "Insert into [CS_PRINT].[dbo].[A_SHEETNAME_PARA_MULTI] "
                SQL = SQL + " VALUES('" + proname1.Data + "','" + getData(Vs1, 0, 0) + "','" + Vs1.ActiveSheetIndex.ToString + "','" + (i + 1).ToString("00") + "','" + getData(vS4, 1, i) + "','','','','','','')"
                cmd = New SqlClient.SqlCommand(SQL, cn)
                cmd.ExecuteNonQuery()
            Next

            'DELETE A_SHEETPRINT_MULTI
            '----------------------------------------------------------------------------------------------------'
            SQL = "DELETE FROM [CS_PRINT].[dbo].[A_SHEETPRINT_MULTI]"
            SQL = SQL + " WHERE SHEETNAME   = '" + getData(Vs1, 0, 0) + "'"
            SQL = SQL + "   AND SHEETREPORT = '" + proname1.Data + "'"
            SQL = SQL + "   AND SHEETSEQ    = '" + Vs1.ActiveSheetIndex.ToString + "'"

            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            SQL = "Insert into [CS_PRINT].[dbo].[A_SHEETPRINT_MAIN_MULTI]"
            SQL = SQL + " VALUES('" + proname1.Data + "','" + Vs1.ActiveSheetIndex.ToString + "','" + CIntp(txt_MAXROW.Data).ToString + "','" + CIntp(txt_MAXCOL.Data).ToString + "','" + CIntp(txt_IDCOL.Data).ToString + "','" + CIntp(txt_IDROWBEGIN.Data).ToString + "','" + CIntp(txt_IDROWEND.Data).ToString + "')"
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            For i = 0 To 100
                For j = 0 To 1000
                    If Strings.Left(getData(Vs1, i, j), 1) = "@" Then
                        SQL = "Insert into [CS_PRINT].[dbo].[A_SHEETPRINT_MULTI]"
                        SQL = SQL + " VALUES('" + proname1.Data + "','" + getData(Vs1, 0, 0) + "','" + Vs1.ActiveSheetIndex.ToString + "','" + getData(Vs1, i, j) + "','" + counti.ToString + "','" + i.ToString + "','" + j.ToString + "','" + j.ToString + "','" + j.ToString + "')"
                        cmd = New SqlClient.SqlCommand(SQL, cn)
                        cmd.ExecuteNonQuery()
                        counti += 1
                    ElseIf Strings.Left(getData(Vs1, i, j), 4) = "Sum@" Then
                        SQL = "Insert into [CS_PRINT].[dbo].[A_SHEETPRINT_MULTI]"
                        SQL = SQL + " VALUES('" + proname1.Data + "','" + getData(Vs1, 0, 0) + "','" + Vs1.ActiveSheetIndex.ToString + "','" + getData(Vs1, i, j) + "','" + counti.ToString + "','" + i.ToString + "','" + j.ToString + "','" + getCell(Vs1, i, j).ToString + "','" + (j - 1).ToString + "')"
                        cmd = New SqlClient.SqlCommand(SQL, cn)
                        cmd.ExecuteNonQuery()
                        counti += 1
                    End If
                Next
            Next
            MsgBoxP("Save successfully!", vbInformation)
        Catch ex As Exception
            MsgBoxP("cmd_OK_Click")
        End Try
    End Sub

    Private Sub cmd_DEL_Click(sender As Object, e As EventArgs) Handles cmd_Read.Click
        Dim cmd As New SqlClient.SqlCommand
        Dim str As String
        Dim ycol, yrow As Integer
        ycol = vs3.ActiveSheet.ActiveColumnIndex
        yrow = vs3.ActiveSheet.ActiveRowIndex

        Try

            str = "http://"
            str += Pub.SER.Replace(",", ":")
            str += "/CS_WHM/Report/" & proname1.Data & ".xlsx"

            If (Not System.IO.Directory.Exists(App_Path & "\Report\")) Then
                System.IO.Directory.CreateDirectory(App_Path & "\Report\")
            End If

            Dim myWebClient As New WebClient()
            myWebClient.DownloadFile(str, App_Path & "\Report\" & proname1.Data & ".xlsx")
            Vs1.OpenExcel(App_Path & "\Report\" & "\" & proname1.Data & ".xlsx")

        Catch ex As Exception
            Try

                str = "http://"
                str += Pub.SER.Replace(",", ":")
                str += "/SHV/Report/" & proname1.Data & ".xlsx"


                If (Not System.IO.Directory.Exists(App_Path & "\Report\")) Then
                    System.IO.Directory.CreateDirectory(App_Path & "\Report\")
                End If

                Dim myWebClient As New WebClient()
                myWebClient.DownloadFile(str, App_Path & "\Report\" & proname1.Data & ".xls")
                Vs1.OpenExcel(App_Path & "\Report\" & "\" & proname1.Data & ".xls")

            Catch exx As Exception

            End Try

        End Try

    End Sub

    Private Sub PeaceButton2_Click(sender As Object, e As EventArgs) Handles btn_Search.Click
        Try
            DATA_SEARCH()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellClick
        Vs1.ActiveSheet.ActiveRowIndex = e.Row
        Vs1.ActiveSheet.ActiveColumnIndex = e.Column
    End Sub
    Private Sub vS1_RightClick(ByVal sender As Object, e As CellClickEventArgs) Handles Vs1.CellClick
        Vs1.Refresh()

        If e.Button <> Windows.Forms.MouseButtons.Right Then Exit Sub
        Vs1.ActiveSheet.ActiveColumnIndex = e.Column
        Vs1.ActiveSheet.ActiveRowIndex = e.Row

        Dim oMenu As ClassPOPUP_ELCA
        Dim SELECTid As Long

        oMenu = New ClassPOPUP_ELCA

        SELECTid = oMenu.PopupNew(sender, e.X, e.Y,
                               WordConv("MAX ROW - Total Sheet Rows"), _
                               WordConv("MAX COL - Total Sheet Columns"), _
                               WordConv("FIX COLUMN - Check Column"), _
                               WordConv("START ROW - First Value Row"), _
                               WordConv("END ROW - Last Value Row"))

        SELECTid = oMenu.Indexx

        Do Until SELECTid > -1
            Application.DoEvents()
            SELECTid = oMenu.Indexx
        Loop

        If SELECTid = 0 Then Exit Sub

        Select Case SELECTid
            Case 1
                txt_MAXROW.Data = CIntp(e.Row)
            Case 2
                txt_MAXCOL.Data = CIntp(e.Column)
            Case 3
                txt_IDCOL.Data = CIntp(e.Column)
            Case 4
                txt_IDROWBEGIN.Data = CIntp(e.Row)
            Case 5
                txt_IDROWEND.Data = CIntp(e.Row)
        End Select

    End Sub
    Private Sub Vs1_ColumnWidthChanged(sender As Object, e As FarPoint.Win.Spread.ColumnWidthChangedEventArgs) Handles Vs1.ColumnWidthChanged
        If e.ColumnList.Count > 1 Then Exit Sub
        Try

        Catch ex As Exception

        End Try
    End Sub


    Private Sub Vs1_KeyDown(sender As Object, e As KeyEventArgs) Handles Vs1.KeyDown
        Try
            If e.KeyCode = Keys.Insert Then
                Vs1.ActiveSheet.Columns.Add(xcol, 1)
            ElseIf e.KeyCode = Keys.Delete Then
                cmd_DEL_Click(sender, e)
            ElseIf e.Control = True And e.KeyCode = Keys.S Then
                cmd_OK_Click(sender, e)
            End If
        Catch ex As Exception

        End Try


    End Sub


    Private Sub txt_NAME_Load(sender As Object, e As KeyEventArgs) Handles txt_NAME.txtTextKeyDown
        If e.KeyCode = Keys.Enter Then
            DATA_SEARCH()
        End If
    End Sub

    Private Sub vS0_CellClick1(sender As Object, e As CellClickEventArgs) Handles vS2.CellClick
        If e.Row < 0 Then Exit Sub
        vS2.ActiveSheet.ActiveRowIndex = e.Row
        vS2.ActiveSheet.ActiveColumnIndex = e.Column
    End Sub

    Private Function DatanewSH(a As String, b As Integer) As DataSet
        DatanewSH = Nothing
        Dim i As Integer
        Dim DSNEW As New DataSet
        Dim chuoi() As String
        ReDim chuoi(b - 1)
        For i = 0 To b - 1
            chuoi(i) = ""
        Next
        DatanewSH = PrcDS(a, cn, chuoi)
    End Function

    Private Sub vS0_CellClick_1(sender As Object, e As CellClickEventArgs) Handles vS2.CellDoubleClick
        DATA_SEARCH_VO1(getData(vS2, 0, vS2.ActiveSheet.ActiveRowIndex))
        DATA_SEARCH_V2(DatanewSH(getData(vS2, 0, vS2.ActiveSheet.ActiveRowIndex), getData(vS2, 1, vS2.ActiveSheet.ActiveRowIndex)))
        DATA_SEARCH_PARAMETER(getData(vS2, 0, vS2.ActiveSheet.ActiveRowIndex))
    End Sub
    Private Sub DATA_SEARCH_V2(dss As DataSet)
        Dim RS01 As DataRow = Nothing
        Dim i As Integer = 0
        Dim j As Integer = 0
        Try
            For i = 0 To GetDsCc(dss) - 1
                vs3.ActiveSheet.RowCount = i + 1
                setData(vs3, 2, i, i + 1)
                setData(vs3, 0, i, getData(vS2, 0, vS2.ActiveSheet.ActiveRowIndex))
                setData(vs3, 1, i, "@" & dss.Tables(0).Columns(i).ColumnName)
            Next
        Catch ex As Exception

        End Try
    End Sub
    Private Sub DATA_SEARCH_VO1(name As String)
        cellick = False
        Dim SQL As String
        Dim RS01 As DataRow = Nothing
        Dim i As Integer = 0
        Dim j As Integer = 0
        Try
            SQL = ""
            SQL = SQL + "SELECT A.name as ID "
            SQL = SQL + "      ,B.name AS IDNAME "
            SQL = SQL + "     ,C.name AS IDTYPE "
            SQL = SQL + "      FROM [sys].[procedures] A   "
            SQL = SQL + "       INNER JOIN [sys].[parameters] B "
            SQL = SQL + "       ON A.object_id = B.object_id  "
            SQL = SQL + "       INNER JOIN [sys].[types] C"
            SQL = SQL + "       ON B.user_type_id = C.user_type_id"
            SQL = SQL + "      WHERE A.name = '" + name + "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            da.SelectCommand = cmd
            ds.Reset()
            da.Fill(ds)
            i = 0
        Catch ex As Exception

        End Try
    End Sub
    Private Sub PeaceButton6_Click(sender As Object, e As EventArgs) Handles PeaceButton6.Click
        Dim ofd As New OpenFileDialog()
        Dim filename As String
        ofd.Filter = "files (*.xls)|*.xlsx"
        ofd.FilterIndex = 2
        ofd.RestoreDirectory = True
        If ofd.ShowDialog() = DialogResult.OK Then
            filename = ofd.FileName
            FileUpload = filename
            Vs1.ActiveSheet.OpenExcel(filename, 0)
        End If
    End Sub

    Private Sub PeaceButton10_Click(sender As Object, e As EventArgs) Handles cmd_Upload.Click
        If sheetname2.Text.Trim = "" Then Exit Sub
        Dim str As String = MsgBoxP("Do you want to save all?", vbOKCancel)

        If str = vbOK Then
            Dim NetworkCre As New NetworkCredential("upload", "upload", "192.168.0.3")
            Vs1.SaveExcel("\\192.168.0.3\c$\inetpub\wwwroot\DMSN\Report\" & sheetname2.Text)
        End If
    End Sub
    Private Sub vs0_1_CellClick(sender As Object, e As CellClickEventArgs) Handles vs3.CellClick
        vs3.ActiveSheet.ActiveRowIndex = e.Row
        vs3.ActiveSheet.ActiveColumnIndex = e.Column
    End Sub
    Private Sub DATA_SEARCH_PARAMETER(name As String)
        cellick = False

        Dim ds As New DataSet
        Dim SQL As String
        Dim RS01 As DataRow = Nothing
        Dim i As Integer = 0
        Dim j As Integer = 0
        Try
            SQL = ""
            SQL = SQL + "SELECT A.name as ID "
            SQL = SQL + "      ,B.name AS IDNAME "
            SQL = SQL + "     ,C.name AS IDTYPE "
            SQL = SQL + "      FROM [sys].[procedures] A   "
            SQL = SQL + "       INNER JOIN [sys].[parameters] B "
            SQL = SQL + "       ON A.object_id = B.object_id  "
            SQL = SQL + "       INNER JOIN [sys].[types] C"
            SQL = SQL + "       ON B.user_type_id = C.user_type_id"
            SQL = SQL + "      WHERE A.name = '" + name + "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            da.SelectCommand = cmd
            da.Fill(ds)
            i = 0

            For Each RS01 In ds.Tables(0).Rows
                vS4.ActiveSheet.RowCount = i + 1
                setData(vS4, 0, i, GetDsData(ds, i, "ID"))
                setData(vS4, 1, i, GetDsData(ds, i, "IDNAME"))
                setData(vS4, 2, i, GetDsData(ds, i, "IDTYPE"))
                i += 1
            Next
        Catch ex As Exception

        End Try
    End Sub
    Private Sub vs0_1_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles vs3.CellDoubleClick
        Dim xcol, xrow As Integer
        Dim ycol, yrow As Integer
        If e.Row < 0 Then Exit Sub
        xcol = Vs1.ActiveSheet.ActiveColumnIndex
        xrow = Vs1.ActiveSheet.ActiveRowIndex

        ycol = vs3.ActiveSheet.ActiveColumnIndex
        yrow = vs3.ActiveSheet.ActiveRowIndex
        Select Case e.Column
            Case 0

            Case 1
                Vs1.ActiveSheet.Cells(0, 0).Value = vs3.ActiveSheet.Cells(0, 0).Value
                Vs1.ActiveSheet.Cells(xrow, xcol).Value = vs3.ActiveSheet.Cells(yrow, 1).Value
            Case 2
                Vs1.ActiveSheet.Cells(xrow, xcol).Value = "Sum" & vs3.ActiveSheet.Cells(yrow, 1).Value
                Dim RowBegin As String
                RowBegin = InputBox("The begin row is???")
                If IsNumeric(RowBegin) Then
                    Vs1.ActiveSheet.Cells(xrow, xcol).Tag = CIntp(RowBegin)
                End If
        End Select


    End Sub

    Private Sub proname1_Load(sender As Object, e As EventArgs) Handles proname1.txtTextChange
        Dim i As Integer = 0
        Dim SQL As String
        Dim cmd As New SqlClient.SqlCommand
        Dim DSN As New DataSet

        Dim DSNN As New DataSet

        Try

            Vs5.ActiveSheet.RowCount = 0

            SQL = ""
            SQL = "SELECT SHEETNAME,SHEETSEQ "
            SQL = SQL + " FROM [CS_PRINT].[dbo].[A_SHEETPRINT_MULTI]"
            SQL = SQL + " WHERE [SHEETREPORT] = '" + proname1.Data + "'  GROUP BY SHEETNAME,SHEETSEQ "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, cn)
            da.Fill(DSN)
            If GetDsRc(DSN) = 0 Then Exit Sub

            For i = 0 To GetDsRc(DSN) - 1
                Vs5.ActiveSheet.RowCount = i + 1
                setData(Vs5, 0, i, GetDsData(DSN, i, "SHEETNAME"))
                setData(Vs5, 1, i, GetDsData(DSN, i, "SHEETSEQ"))
            Next

            'DEFAULT
            SQL = ""
            SQL = "SELECT * "
            SQL = SQL + " FROM [CS_PRINT].[dbo].[A_SHEETPRINT_MAIN_MULTI]"
            SQL = SQL + " WHERE [SHEETREPORT] = '" + proname1.Data + "' "
            SQL = SQL + "   AND [SHEETSEQ] = '0' "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, cn)
            da.Fill(DSNN)
            If GetDsRc(DSNN) = 0 Then Exit Sub

            txt_MAXROW.Data = GetDsData(DSNN, 0, "MAXROW")
            txt_MAXCOL.Data = GetDsData(DSNN, 0, "MAXCOL")
            txt_IDCOL.Data = GetDsData(DSNN, 0, "IDCOL")
            txt_IDROWBEGIN.Data = GetDsData(DSNN, 0, "IDROWBEGIN")
            txt_IDROWEND.Data = GetDsData(DSNN, 0, "IDROWEND")

        Catch ex As Exception

        End Try

    End Sub


    Public Sub setDataSheet(ByVal fpsA As FarPoint.Win.Spread.FpSpread, ByVal Index As Integer, ByVal Col As Integer, ByVal Row As Integer, ByVal Value As Object, Optional ByVal Style As String = "", Optional ByVal UseCheck As Boolean = False)
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

                fpsA.Sheets(Index).Cells(Row, Col).CellType = cel

                If CDblp(Value) = 0 Or CDblp(Value) = 2 Then Value = False
                If CDblp(Value) = 1 Then Value = True

            End If

            fpsA.Sheets(Index).SetValue(Row, Col, Value)

        Catch ex As Exception

        End Try
    End Sub


    Private Sub Vs5CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs5.CellDoubleClick
        Dim SQL As String
        Dim cmd As New SqlClient.SqlCommand
        Dim DSN As New DataSet
        Dim i As Integer

        Dim Sheet_Index As String

        Dim ycol, yrow As Integer
        ycol = Vs5.ActiveSheet.ActiveColumnIndex
        yrow = Vs5.ActiveSheet.ActiveRowIndex

        Call cmd_Read.PerformClick()

        Sheet_Index = getData(Vs5, 1, yrow)

        Vs1.ActiveSheetIndex = CIntp(Sheet_Index)

        Try
            txt_NAME.Data = getData(Vs5, 0, yrow)
            Vs1.ActiveSheet.Cells(0, 0).Value = txt_NAME.Data
            SQL = ""
            SQL = "SELECT [IDNAME] ,[IDSEQ] ,[IDCOL] ,[IDROW],[IDROWBEGIN] ,[IDROWEND]  "
            SQL = SQL + " FROM [CS_PRINT].[dbo].[A_SHEETPRINT_MULTI]"
            SQL = SQL + "  WHERE [SHEETNAME] = '" + getData(Vs5, 0, yrow) + "' "
            SQL = SQL + " AND [SHEETREPORT] = '" + proname1.Data + "'"
            SQL = SQL + " AND [SHEETSEQ] = '" + Sheet_Index + "'"

            da.SelectCommand = New SqlClient.SqlCommand(SQL, cn)
            da.Fill(DSN)

            If GetDsRc(DSN) = 0 Then Exit Sub

            For i = 0 To GetDsRc(DSN) - 1
                setDataSheet(Vs1, CIntp(Sheet_Index), CIntp(GetDsData(DSN, i, "IDCOL")), CIntp(GetDsData(DSN, i, "IDROW")), GetDsData(DSN, i, "IDNAME"))

                setCellSheet(Vs1, CIntp(Sheet_Index), CIntp(GetDsData(DSN, i, "IDCOL")), CIntp(GetDsData(DSN, i, "IDROW")), GetDsData(DSN, i, "IDROWBEGIN"))

                If CIntp(GetDsData(DSN, i, "IDROWEND")) > 0 And CIntp(GetDsData(DSN, i, "IDROWEND")) > CIntp(GetDsData(DSN, i, "IDROW")) Then setData(Vs1, CIntp(GetDsData(DSN, i, "IDCOL")), CIntp(GetDsData(DSN, i, "IDROWEND")), GetDsData(DSN, i, "IDNAME"))
            Next

        Catch ex As Exception

        End Try
    End Sub

    Public Sub setCellSheet(ByVal fpsA As FarPoint.Win.Spread.FpSpread, ByVal Index As Integer, ByVal Col As Integer, ByVal Row As Integer, ByVal Value As Object)
        Try
            fpsA.Sheets(Index).Cells(Row, Col).Tag = Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Vs5_KeyDown(sender As Object, e As KeyEventArgs) Handles Vs5.KeyDown
        'If e.KeyCode = Keys.Delete Then
        '    SQL = "DELETE FROM [CS_PRINT].[dbo].[A_SHEETNAME_PARA]"
        '    SQL = SQL + " WHERE SHEETNAME = '" + getData(Vs5, Vs5.ActiveSheet.ActiveColumnIndex, Vs5.ActiveSheet.ActiveRowIndex) + "'"
        '    SQL = SQL + " AND SHEETREPORT = '" + proname1.Data + "'"

        '    cmd = New SqlClient.SqlCommand(SQL, cn)
        '    cmd.ExecuteNonQuery()

        '    'DELETE A_SHEETPRINT
        '    SQL = "DELETE FROM [CS_PRINT].[dbo].[A_SHEETPRINT]"
        '    SQL = SQL + " WHERE SHEETNAME = '" + getData(Vs5, Vs5.ActiveSheet.ActiveColumnIndex, Vs5.ActiveSheet.ActiveRowIndex) + "'"
        '    SQL = SQL + " AND SHEETREPORT = '" + proname1.Data + "'"

        '    cmd = New SqlClient.SqlCommand(SQL, cn)
        '    cmd.ExecuteNonQuery()

        '    Dim i As Integer = 0
        '    Dim DSN As New DataSet
        '    Vs5.ActiveSheet.RowCount = 0
        '    SQL = ""
        '    SQL = "SELECT SHEETNAME "
        '    SQL = SQL + " FROM [CS_PRINT].[dbo].[A_SHEETPRINT]"
        '    SQL = SQL + " WHERE [SHEETREPORT] = '" + proname1.Data + "'  GROUP BY SHEETNAME"
        '    da.SelectCommand = New SqlClient.SqlCommand(SQL, cn)
        '    da.Fill(DSN)
        '    If GetDsRc(DSN) = 0 Then Exit Sub

        '    For i = 0 To GetDsRc(DSN) - 1
        '        Vs5.ActiveSheet.RowCount = i + 1
        '        setData(Vs5, 0, i, GetDsData(DSN, i, "SHEETNAME"))
        '    Next

        'End If
    End Sub

#End Region

End Class