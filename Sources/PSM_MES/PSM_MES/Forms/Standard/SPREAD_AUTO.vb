Public Class P_SPREAD_AUTO
#Region "Variable"
    Private checkrn As Boolean = False
    Private a9911() As T9911_AREA
    Private L9911 As T9911_AREA

    Private a9912() As T9912_AREA
    Private L9912 As T9912_AREA

    Private xcol As Integer
    Private textt As New FarPoint.Win.Spread.CellType.TextCellType
    Private numbt As New FarPoint.Win.Spread.CellType.NumberCellType
    Private buttt As New FarPoint.Win.Spread.CellType.ButtonCellType
    Private combt As New FarPoint.Win.Spread.CellType.ComboBoxCellType
    Private chkt As New FarPoint.Win.Spread.CellType.CheckBoxCellType
    Private cellick As Boolean = False

    Enum colvS1
        ItemCode = 0
        ItemName = 1
        ItemNameSimply = 2
        ProdjectName = 3
        DataType = 4
        DataSize = 5
        DataDecimal = 6
        TextAlign = 7
        HorizontalAlignment = 8
        VerticalAlignment = 9
        SizeWidth = 10
        SizeHeight = 11
        BackColot = 12
        ForeColor = 13
        FontName = 14
        FontSize = 15
        FontBold = 16
        REMK = 17
    End Enum

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
        Itemcode.Data = ""
        Itemname.Data = ""
        Itemnamesimple.Data = ""
        Projectname.Data = ""
        Datatype.SelectedIndex = 0
        Datasize.Data = 100
        Datadecimal.Data = 2
        TextAlign.SelectedIndex = 0
        HorizonAlign.SelectedIndex = 0
        VerticalAlign.SelectedIndex = 0
        DataLock.SelectedIndex = 1
        DataHide.SelectedIndex = 1
        Sizewidth.Data = 111
        Sizeheight.Data = 20
        Backcolor_.Data = "255-255-255"
        Forecolor_.Data = "0-0-0"
        Backcolor_.TextboxBackColor = Color.White
        Forecolor_.TextboxBackColor = Color.Black
        Fontname.Data = "Tahoma"
        Fontsize.Data = "9"
        Fontbold.Data = "0"
    End Sub
#End Region

#Region "Function"
    Public Sub SPR_PRO(ByRef spr As FarPoint.Win.Spread.FpSpread, datatr As DataSet, program As String, sheetname As String)
        Dim DATAreader As SqlClient.SqlDataReader
        Dim str11 As String
        Dim i, j As Integer
        Dim str(), str1() As String

        spr.ActiveSheet.ColumnHeader.RowCount = 1
        spr.ActiveSheet.ColumnCount = GetDsCc(datatr)

        spr.DataSource = datatr.Tables(0)

        For i = 0 To GetDsCc(datatr) - 1
            str11 = GetColumname(datatr, i)
            DATAreader = PrcDR("USP_SPREAD_PROGRAM_SEARCH_ITEMNAME", cn, program, sheetname, GetColumname(datatr, i))

            DATAreader.Read()
            spr.ActiveSheet.ColumnHeader.Columns(i).Label = DATAreader("K9911_ItemNameSimply")
            spr.ActiveSheet.ColumnHeader.Columns(i).Tag = DATAreader("K9911_ItemName")
            Select Case DATAreader("K9911_DataType")
                Case 0
                    SPR_TEXTBOX(spr, i, DATAreader("K9911_DataSize"))
                Case 1
                    SPR_NUMBERCELL(spr, DATAreader("K9911_DataDecimal"), CInt(DATAreader("K9911_DataSize")), i)
                Case 2
                    SPR_BUTTON(spr, i)
                Case 3
                    SPR_COMBOBOX(spr, i)

                Case 4
                    SPR_CHECKBOX(spr, i)
                    For j = 0 To GetDsRc(datatr) - 1
                        setDatachk(spr, i, j, getData(spr, i, j))
                    Next
            End Select
            spr.ActiveSheet.ColumnHeader.Columns(i).Width = DATAreader("K9911_SizeWidth")

            str = Split(DATAreader("K9911_BackColot"), "-")
            spr.ActiveSheet.Columns(i).BackColor = System.Drawing.Color.FromArgb(CInt(str(0)), CInt(str(1)), CInt(str(2)))

            str1 = Split(DATAreader("K9911_ForeColor"), "-")
            spr.ActiveSheet.Columns(i).ForeColor = System.Drawing.Color.FromArgb(CInt(str1(0)), CInt(str1(1)), CInt(str1(2)))

            Dim newfont As Font
            If DATAreader("K9911_FontBold") = 0 Then
                newfont = New Font(DATAreader("K9911_FontName").ToString, CSng(DATAreader("K9911_FontSize")), Drawing.FontStyle.Regular)
            Else
                newfont = New Font(DATAreader("K9911_FontName").ToString, CSng(DATAreader("K9911_FontSize")), Drawing.FontStyle.Bold)
            End If
            spr.ActiveSheet.ColumnHeader.Columns(i).Font = newfont
            spr.ActiveSheet.Columns(i).VerticalAlignment = DATAreader("K9911_VerticalAlignment")
            spr.ActiveSheet.Columns(i).HorizontalAlignment = DATAreader("K9911_HorizontalAlignment")
            If DATAreader("K9911_Lock") = 1 Then spr.ActiveSheet.Columns(i).Locked = True Else spr.ActiveSheet.Columns(i).Locked = False
            If DATAreader("K9911_Hidden") = 1 Then spr.ActiveSheet.Columns(i).Visible = True Else spr.ActiveSheet.Columns(i).Visible = False
            DATAreader.Close()
        Next

    End Sub
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
                vS0.ActiveSheet.RowCount = i + 1
                setData(vS0, 0, i, GetDsData(ds, i, "ID"))
                setData(vS0, 1, i, GetDsData(ds, i, "QTY"))
                i += 1
            Next
        Catch ex As Exception

        End Try
    End Sub
    Private Sub DATA_MOVE(zzz As T9911_AREA)
        Itemcode.Data = zzz.ItemCode
        Itemname.Data = zzz.ItemName
        Itemnamesimple.Data = zzz.ItemNameSimply
        Projectname.Data = zzz.ProdjectName
        Datatype.SelectedIndex = zzz.DataType
        Datasize.Data = zzz.DataSize
        Datadecimal.Data = zzz.DataDecimal
        TextAlign.SelectedIndex = zzz.TextAlign
        HorizonAlign.SelectedIndex = zzz.HorizontalAlignment
        VerticalAlign.SelectedIndex = zzz.VerticalAlignment
        Sizewidth.Data = zzz.SizeWidth
        Sizeheight.Data = zzz.SizeHeight
        Backcolor_.Data = zzz.BackColot
        Forecolor_.Data = zzz.ForeColor
        Fontname.Data = zzz.FontName
        Fontsize.Data = zzz.FontSize
        Fontbold.Data = zzz.FontBold
        DataLock.SelectedIndex = zzz.Lock
        DataHide.SelectedIndex = zzz.Hidden


        If zzz.CheckHead = "1" Then chk_CheckHead.Checked = True Else chk_CheckHead.Checked = False
        If zzz.CheckMerge = "1" Then chk_CheckMerge.Checked = True Else chk_CheckMerge.Checked = False
        If zzz.CheckDev = "1" Then chk_CheckDev.Checked = True Else chk_CheckDev.Checked = False

        chk_CheckHeadType.SelectedIndex = CIntp(zzz.CheckHeadType)
        chk_CheckMergePolicy.SelectedIndex = CIntp(zzz.CheckMergePolicy)

    End Sub
    Private Function key_count() As String
        Dim SQL As String
        Dim rd As SqlClient.SqlDataReader

        SQL = "SELECT MAX(CAST(K9911_ItemCode AS DECIMAL)) AS MAX_CODE FROM PFK9911 "

        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_CODE) Then
            key_count = "000001"
        Else
            key_count = Format(CInt(rd!MAX_CODE + 1), "000000")
        End If
        rd.Close()
    End Function
    Private Function data_check() As Boolean
        data_check = False
        If IsNumeric(Sizewidth.Data) = False Then Exit Function
        If IsNumeric(Sizewidth.Height) = False Then Exit Function
        If Datadecimal.Data.Trim = "" Then Exit Function

        data_check = True
    End Function
    Private Sub DATA_LINK()
        L9911.ItemName = Itemname.Data
        L9911.ItemCode = key_count()
        L9911.ItemNameSimply = Itemnamesimple.Data
        L9911.ProdjectName = Project.Text
        L9911.DataType = Datatype.SelectedIndex
        L9911.DataSize = Datasize.Data
        L9911.DataDecimal = Datadecimal.Data
        L9911.TextAlign = TextAlign.SelectedIndex
        L9911.HorizontalAlignment = HorizonAlign.SelectedIndex
        L9911.VerticalAlignment = VerticalAlign.SelectedIndex
        L9911.SizeWidth = Sizewidth.Data
        L9911.SizeHeight = Sizeheight.Data
        L9911.BackColot = Backcolor_.Data
        L9911.ForeColor = Forecolor_.Data
        L9911.FontName = Fontname.Data
        L9911.FontSize = Fontsize.Data
        L9911.FontBold = Fontbold.Data
        L9911.Lock = DataLock.SelectedIndex
        L9911.Hidden = DataHide.SelectedIndex

        L9911.CheckMerge = chk_CheckMerge.CheckState
        L9911.CheckMergePolicy = chk_CheckMergePolicy.SelectedIndex
        L9911.CheckHead = chk_CheckHead.CheckState
        L9911.CheckHeadType = chk_CheckHeadType.SelectedIndex
        L9911.CheckDev = chk_CheckDev.CheckState

        If Strings.Left(L9911.ItemName, 4).ToUpper = "KEY_" Then L9911.Hidden = "0"
        L9911.REMK = ""
    End Sub
    ' Liên quan đến Spread_M
    Private Sub DATA_LINK(col As Integer)
        L9911.ItemName = Vs1.ActiveSheet.ColumnHeader.Columns(col).Label
        L9911.ItemCode = key_count()
        L9911.ItemNameSimply = Vs1.ActiveSheet.ColumnHeader.Columns(col).Label
        L9911.ProdjectName = Project.Text
        L9911.DataType = Datatype.SelectedIndex
        L9911.DataSize = Datasize.Data
        L9911.DataDecimal = Datadecimal.Data
        L9911.TextAlign = TextAlign.SelectedIndex
        L9911.HorizontalAlignment = HorizonAlign.SelectedIndex
        L9911.VerticalAlignment = VerticalAlign.SelectedIndex
        L9911.SizeWidth = Sizewidth.Data
        L9911.SizeHeight = Sizeheight.Data
        L9911.BackColot = Backcolor_.Data
        L9911.ForeColor = Forecolor_.Data
        L9911.FontName = Fontname.Data
        L9911.FontSize = Fontsize.Data
        L9911.FontBold = Fontbold.Data
        L9911.Lock = DataLock.SelectedIndex
        L9911.Hidden = DataHide.SelectedIndex
        If Strings.Left(L9911.ItemName, 4).ToUpper = "KEY_" Then L9911.Hidden = "0"
        If L9911.ItemName.Contains("Amount") Or L9911.ItemName.Contains("amount") _
          Or L9911.ItemName.Contains("Price") _
         Or L9911.ItemName.Contains("price") _
          Or L9911.ItemName.Contains("quantity") _
           Or L9911.ItemName.Contains("Quantity") Then
            L9911.DataType = 1
            L9911.HorizontalAlignment = 3
        End If
        If L9911.ItemName.Contains("date") Or L9911.ItemName.Contains("Date") Then
            L9911.DataType = 5
        End If
        L9911.REMK = ""
    End Sub
#End Region

#Region "Event"
    Private Sub ChangeValue(sender As Object, e As EventArgs) Handles Sizewidth.txtTextChanged, Sizeheight.txtTextChanged, Projectname.txtTextChanged, Itemnamesimple.txtTextChanged, _
        Itemname.txtTextChanged, Forecolor_.txtTextChanged, Fontsize.txtTextChanged, Fontname.txtTextChanged, Fontbold.txtTextChanged, Backcolor_.txtTextChanged
        If data_check() = False Then Exit Sub
        If cellick = False Then Exit Sub
        Vs1.ActiveSheet.ColumnHeader.Columns(xcol).Label = Itemnamesimple.Data
        Vs1.ActiveSheet.ColumnHeader.Columns(xcol).Tag = Itemcode.Data & Itemname.Data

        Vs1.ActiveSheet.ColumnHeader.Columns(xcol).Width = CDbl(Sizewidth.Data)
        Dim newfont As Font
        If Fontbold.Data = "0" Then
            newfont = New Font(Fontname.Data, CSng(Fontsize.Data), Drawing.FontStyle.Regular)
        Else
            newfont = New Font(Fontname.Data, CSng(Fontsize.Data), Drawing.FontStyle.Bold)
        End If
        Vs1.ActiveSheet.ColumnHeader.Columns(xcol).Font = newfont

    End Sub

    Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellClick
    End Sub
    Private Sub Fontstyle_Load(sender As Object, e As EventArgs) Handles Fontstyle.btnTitleClick
        FontDialog1.ShowDialog()
        Fontname.Data = FontDialog1.Font.Name
        Fontsize.Data = FontDialog1.Font.Size
        If FontDialog1.Font.Bold = True Then
            Fontbold.Data = "1"
        End If
    End Sub
    Private Sub Backcolor__Load(sender As Object, e As EventArgs) Handles Backcolor_.btnTitleClick
        ColorDialog1.ShowDialog()
        Backcolor_.TextboxBackColor = ColorDialog1.Color
        Backcolor_.Data = ColorDialog1.Color.R & "-" & ColorDialog1.Color.G & "-" & ColorDialog1.Color.B
        Backcolor_.Code = ColorDialog1.Color.R & "-" & ColorDialog1.Color.G & "-" & ColorDialog1.Color.B
        Vs1.ActiveSheet.Columns(xcol).BackColor = ColorDialog1.Color
    End Sub
    Private Sub Forecolor__Load(sender As Object, e As EventArgs) Handles Forecolor_.btnTitleClick
        ColorDialog1.ShowDialog()
        Forecolor_.TextboxBackColor = ColorDialog1.Color
        Forecolor_.Data = ColorDialog1.Color.R & "-" & ColorDialog1.Color.G & "-" & ColorDialog1.Color.B
        Vs1.ActiveSheet.Columns(xcol).ForeColor = ColorDialog1.Color
    End Sub
    Private Sub SelectIndexChange(sender As Object, e As EventArgs) Handles HorizonAlign.SelectedIndexChanged, VerticalAlign.SelectedIndexChanged, _
        DataLock.SelectedIndexChanged, DataHide.SelectedIndexChanged
        Try
            Vs1.ActiveSheet.Columns(xcol).VerticalAlignment = VerticalAlign.SelectedIndex
            Vs1.ActiveSheet.Columns(xcol).HorizontalAlignment = HorizonAlign.SelectedIndex
            ' Vs1.ActiveSheet.Columns(xcol).Visible = DataHide.SelectedIndex
            If DataHide.SelectedIndex = 1 Then
                Vs1.ActiveSheet.Cells(1, xcol).Value = "Show"
            ElseIf DataHide.SelectedIndex = 0 Then
                Vs1.ActiveSheet.Cells(1, xcol).Value = "Hide"
            End If
            Vs1.ActiveSheet.Columns(xcol).Locked = HorizonAlign.SelectedIndex
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmd_Cancel_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        Me.Close()
    End Sub

    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Try
            Dim i As Integer = 0
            If data_check() = False Then MsgBoxP("25", "DATA ERROR") : Exit Sub
            L9912.ItemCode = Itemcode.Data
            L9912.Lock = "1"
            L9912.Hidden = "1"
            L9912.ProdjectName = Project.Text
            L9912.ProgramNo = Projectname.Data
            L9912.SheetName = sheetname2.Text
            If DELETE_PFK9912(L9912) = False Then Exit Sub
            For i = 0 To Vs1.ActiveSheet.ColumnCount - 1
                If READ_PFK9911(Vs1.ActiveSheet.ColumnHeader.Columns(i).Label) = True Then
                    L9911 = D9911
                    REWRITE_PFK9911(L9911)
                    L9912.ItemCode = L9911.ItemCode
                    L9912.Lock = "1"
                    L9912.Hidden = "1"
                    If Strings.Left(L9911.ItemName, 4).ToUpper = "KEY_" Then L9912.Hidden = "0"
                    L9912.ProdjectName = Project.Text
                    L9912.ProgramNo = Projectname.Data
                    L9912.SheetName = sheetname2.Text
                    L9912.ProgramSeq = key_count_k9912(L9912.ProdjectName, L9912.ProgramNo, L9912.SheetName)
                    WRITE_PFK9912(L9912)
                    '  MsgBoxP("UPDATE SUCCESSFULLY!")
                Else
                    L9911 = D9911
                    DATA_LINK(i)
                    WRITE_PFK9911(L9911)
                    L9912.ItemCode = L9911.ItemCode
                    L9912.Lock = "1"
                    L9912.Hidden = "1"
                    If Strings.Left(L9911.ItemName, 4).ToUpper = "KEY_" Then L9912.Hidden = "0"
                    L9912.ProdjectName = Project.Text
                    L9912.ProgramNo = Projectname.Data
                    L9912.SheetName = sheetname2.Text
                    L9912.ProgramSeq = key_count_k9912(L9912.ProdjectName, L9912.ProgramNo, L9912.SheetName)
                    WRITE_PFK9912(L9912)
                    '  MsgBoxP("INSERT SUCCESSFULLY!")
                End If
            Next
            MsgBoxP("Successfully!", vbInformation)
        Catch ex As Exception
        End Try
    End Sub
    Private Function key_count_k9912(a As String, b As String, c As String) As String
        Dim SQL As String
        Dim rd As SqlClient.SqlDataReader

        SQL = "SELECT MAX(CAST(K9912_ProgramSeq AS DECIMAL)) AS MAX_CODE FROM PFK9912 "
        SQL = SQL + " WHERE [K9912_ProdjectName] = '" + a + "' "
        SQL = SQL + " AND [K9912_ProgramNo] = '" + b + "' "
        SQL = SQL + " AND [K9912_SheetName] = '" + c + "' "
        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_CODE) Then
            key_count_k9912 = "000001"
        Else
            key_count_k9912 = Format(CInt(rd!MAX_CODE + 1), "000000")
        End If
        rd.Close()
    End Function

    Private Sub cmd_DEL_Click(sender As Object, e As EventArgs) Handles cmd_DEL.Click
        Try
            If data_check() = False Then MsgBoxP("25", "DATAEROOR") : Exit Sub
            Dim str As String = MsgBoxP("Do you want to delete?", vbYesNo)
            If str = vbYes Then
                DATA_LINK()
                If READ_PFK9911(Itemcode.Data, Itemname.Data) = True Then
                    DELETE_PFK9911(L9911)
                End If
                DATA_SEARCH()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Datatype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Datatype.SelectedIndexChanged
        Try
            Select Case Datatype.SelectedIndex
                Case 0
                    Vs1.ActiveSheet.Columns(xcol).CellType = textt
                Case 1
                    SPR_NUMBERCELL(Vs1, CInt(Datadecimal.Data), xcol)
                    HorizonAlign.SelectedIndex = 3
                Case 2
                    SPR_BUTTON(Vs1, xcol)
                Case 3
                    SPR_COMBOBOX(Vs1, xcol)
                Case 4
                    SPR_CHECKBOX(Vs1, xcol)
                Case 5
                    SPR_DATEVALUE(Vs1, xcol)
            End Select
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Datadecimal_Load(sender As Object, e As EventArgs) Handles Datadecimal.txtTextChanged
        If Datatype.SelectedIndex <> 1 Then Exit Sub
        If IsNumeric(Datadecimal.Data) = False Then Exit Sub
        SPR_NUMBERCELL(Vs1, CInt(Datadecimal.Data), xcol)
    End Sub





    Private Sub PeaceButton2_Click(sender As Object, e As EventArgs) Handles PeaceButton2.Click
        DATA_SEARCH()
        'form_int()
        'data_int()
    End Sub

    Private Sub Vs1_ColumnWidthChanged(sender As Object, e As FarPoint.Win.Spread.ColumnWidthChangedEventArgs) Handles Vs1.ColumnWidthChanged
        If e.ColumnList.Count > 1 Then Exit Sub
        Try
            Sizewidth.Data = Vs1.ActiveSheet.Columns(xcol).Width
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
#End Region

    Private Sub txt_NAME_Load(sender As Object, e As KeyEventArgs) Handles txt_NAME.txtTextKeyDown
        If e.KeyCode = Keys.Enter Then
            DATA_SEARCH()
        End If
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

    Private Sub vS0_CellClick_1(sender As Object, e As CellClickEventArgs) Handles vS0.CellDoubleClick
        DATA_SEARCH_VO1(getData(vS0, 0, vS0.ActiveSheet.ActiveRowIndex))
        DATA_SEARCH_V2(DatanewSH(getData(vS0, 0, vS0.ActiveSheet.ActiveRowIndex), getData(vS0, 1, vS0.ActiveSheet.ActiveRowIndex)))
    End Sub
    Private Sub DATA_SEARCH_V2(dss As DataSet)
        Dim RS01 As DataRow = Nothing
        Dim i As Integer = 0
        Dim j As Integer = 0
        Try
            For i = 0 To GetDsCc(dss) - 1
                Vs1.ActiveSheet.ColumnCount = GetDsCc(dss)
                Vs1.ActiveSheet.ColumnHeader.Columns(i).Label = dss.Tables(0).Columns(i).ColumnName
                Vs1.ActiveSheet.Cells(0, i).Value = "Show"
                Vs1.ActiveSheet.Columns(i).Locked = True
                Itemcode.Data = key_count()
                Itemname.Data = dss.Tables(0).Columns(i).ColumnName
                Itemnamesimple.Data = dss.Tables(0).Columns(i).ColumnName
                Projectname.Data = getData(vS0, 0, vS0.ActiveSheet.ActiveRowIndex)
                Datatype.SelectedIndex = 0
                Datasize.Data = 100
                Datadecimal.Data = 2
                TextAlign.SelectedIndex = 2
                HorizonAlign.SelectedIndex = 2
                VerticalAlign.SelectedIndex = 2
                DataLock.SelectedIndex = 1
                DataHide.SelectedIndex = 1
                Vs1.ActiveSheet.Columns(i).VerticalAlignment = CellVerticalAlignment.Center
                Vs1.ActiveSheet.Columns(i).HorizontalAlignment = CellHorizontalAlignment.Center
                Sizewidth.Data = 100
                Vs1.ActiveSheet.Columns(i).Width = 100
                Sizeheight.Data = 20
                Backcolor_.Data = "255-255-255"
                Forecolor_.Data = "0-0-0"
                Backcolor_.TextboxBackColor = Color.White
                Forecolor_.TextboxBackColor = Color.Black
                Vs1.ActiveSheet.Columns(i).BackColor = Color.White
                Vs1.ActiveSheet.Columns(i).ForeColor = Color.Black
                Fontname.Data = "Tahoma"
                Fontsize.Data = "9"
                Vs1.ActiveSheet.ColumnHeader.Columns(i).Font = New Font("Tahoma", 9, Drawing.FontStyle.Bold)
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

            For Each RS01 In ds.Tables(0).Rows
                vs0_1.ActiveSheet.RowCount = i + 1
                setData(vs0_1, 0, i, GetDsData(ds, i, "ID"))
                setData(vs0_1, 1, i, GetDsData(ds, i, "IDNAME"))
                setData(vs0_1, 2, i, GetDsData(ds, i, "IDTYPE"))
                i += 1
            Next
        Catch ex As Exception

        End Try
    End Sub




    Private Sub vS0_CellClick_2(sender As Object, e As CellClickEventArgs) Handles vS0.CellClick
        vS0.ActiveSheet.ActiveRowIndex = e.Row
        vS0.ActiveSheet.ActiveColumnIndex = e.Column
    End Sub
End Class