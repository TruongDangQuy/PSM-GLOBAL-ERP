Public Class SPREAD_PROGRAM
#Region "Variable"
    Private checkrn As Boolean = False
    Private a9911() As T9911_AREA
    Private L9911 As T9911_AREA

    Private a9912() As T9912_AREA
    Private L9912 As T9912_AREA

    Private fromIndex As Integer
    Private targetIndex As Integer
    Private dragIndex As Integer
    Private dragRect As Rectangle

    Private xcol As Integer
    Private textt As New FarPoint.Win.Spread.CellType.TextCellType
    Private numbt As New FarPoint.Win.Spread.CellType.NumberCellType
    Private buttt As New FarPoint.Win.Spread.CellType.ButtonCellType
    Private combt As New FarPoint.Win.Spread.CellType.ComboBoxCellType
    Private chkt As New FarPoint.Win.Spread.CellType.CheckBoxCellType
    Private cellick As Boolean = False
    Private formA As Boolean = False
    Private item As New List(Of T9911_AREA)

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
    Public Function Link_ISUD_P_SPREAD_PROGRAM(job As Integer, _proname1 As String, _sheetname1 As String, Optional CheckName As String = "") As Boolean
        Me.Tag = CheckName
        wJOB = job
        Project.Text = "DMS"
        proname1.Data = _proname1
        sheetname1.Text = _sheetname1

        proname2.Data = _proname1
        sheetname2.Text = _sheetname1

        Link_ISUD_P_SPREAD_PROGRAM = False

        formA = False
        Me.ShowDialog()

        Link_ISUD_P_SPREAD_PROGRAM = isudCHK
    End Function

    Private Sub P_SPREAD_PROGRAM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub
    Private Sub SPREAD_SETUP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If wJOB = 3 Then
            cmd_Search.PerformClick()
            Exit Sub
        End If
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
        Sizewidth.Data = 30
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

#Region "DATA_SEARCH"


#Region "COMBO_SEARCH"
    Private Function DATA_SEARCH_SHEETNAME2() As Boolean
        DATA_SEARCH_SHEETNAME2 = False
        sheetname2.Items.Clear()

        Dim SQL As String
        Dim i As Integer

        Try
            SQL = " SELECT K9912_SheetName  FROM PFK9912 "
            SQL = SQL + "  WHERE K9912_ProgramNo = '" + proname2.Data.Trim + "'"
            SQL = SQL + " GROUP BY K9912_SheetName"
            cmd = New SqlClient.SqlCommand(SQL, cn)
            da.SelectCommand = cmd
            ds.Reset()
            da.Fill(ds)
            If GetDsRc(ds) = 0 Then Exit Function
            For i = 0 To GetDsRc(ds) - 1
                sheetname2.Items.Add(GetDsData(ds, i, "K9912_SheetName"))
            Next
            sheetname2.SelectedIndex = 0
            DATA_SEARCH_SHEETNAME2 = True

        Catch ex As Exception

        End Try

    End Function
    Private Function DATA_SEARCH_SHEETNAME1() As Boolean
        DATA_SEARCH_SHEETNAME1 = False
        sheetname1.Items.Clear()

        Dim SQL As String
        Dim i As Integer

        Try
            SQL = " SELECT K9912_SheetName  FROM PFK9912 "
            SQL = SQL + "  WHERE K9912_ProgramNo = '" + proname1.Data.Trim + "'"
            SQL = SQL + " GROUP BY K9912_SheetName"
            cmd = New SqlClient.SqlCommand(SQL, cn)
            da.SelectCommand = cmd
            ds.Reset()
            da.Fill(ds)
            If GetDsRc(ds) = 0 Then Exit Function
            For i = 0 To GetDsRc(ds) - 1
                sheetname1.Items.Add(GetDsData(ds, i, "K9912_SheetName"))
            Next
            sheetname1.SelectedIndex = 0
            DATA_SEARCH_SHEETNAME1 = True

        Catch ex As Exception

        End Try

    End Function
#End Region

#Region "SPREAD"
    Private Sub DATA_SEARCH_VS2()
        cellick = False
        Dim SQL As String
        Dim RS01 As DataRow = Nothing
        Dim i As Integer = 0
        Dim j As Integer = 0
        Try

            SQL = ""
            SQL = SQL + "SELECT K9911_ItemCode,[K9911_ItemName]"
            SQL = SQL + "      ,[K9911_ItemNameSimply],[K9911_ItemNameForeign1],[K9911_ItemNameForeign2],[K9911_ProdjectName]"
            SQL = SQL + "      ,[K9911_DataType],[K9911_DataSize]"
            SQL = SQL + "      ,[K9911_DataDecimal],[K9911_TextAlign]"
            SQL = SQL + "      ,[K9911_HorizontalAlignment] ,[K9911_VerticalAlignment]"
            SQL = SQL + "      ,[K9911_SizeWidth] ,[K9911_SizeHeight]"
            SQL = SQL + "      ,[K9911_BackColot] ,[K9911_ForeColor]"
            SQL = SQL + "      ,[K9911_FontName] ,[K9911_FontSize]"
            SQL = SQL + "      ,[K9911_FontBold],[K9911_REMK]"
            SQL = SQL + "      ,[K9911_CheckMerge] ,[K9911_CheckMergePolicy] ,[K9911_CheckHead] ,[K9911_CheckHeadType],[K9911_CheckDev] "
            SQL = SQL + "       ,[K9912_Lock] AS [K9911_Lock] ,[K9912_Hidden] AS [K9911_Hidden]"
            SQL = SQL + "  FROM PFK9912 A"
            SQL = SQL + " INNER JOIN PFK9911 B "
            SQL = SQL + " ON A.K9912_ItemCode = B.K9911_ItemCode"
            SQL = SQL + " WHERE [K9912_ProgramNo] = '" + proname1.Data + "'"
            SQL = SQL + " AND [K9912_SheetName]  = '" + sheetname1.Text + "'"
            cmd = New SqlClient.SqlCommand(SQL, cn)
            da.SelectCommand = cmd
            ds.Reset()
            da.Fill(ds)
            Vs1.ActiveSheet.ColumnCount = 0
            If GetDsRc(ds) = 0 Then Exit Sub
            For Each RS01 In ds.Tables(0).Rows
                Vs1.ActiveSheet.ColumnCount = i + 1
                Vs1.ActiveSheet.Cells(0, i).Value = "99999999"
                K9911_MOVE(RS01)
                L9911 = D9911
                ListBox1.Items.Add(L9911.ItemName & "-" & L9911.ItemCode & "-" & FUNCTION_BOOLEAN(L9911.Lock) & "-" & FUNCTION_BOOLEAN(L9911.Hidden))
                SPR_PRO(Vs1, i, L9911)
                Vs1.ActiveSheet.Columns(i).Visible = True
                If L9911.Hidden = "1" Then
                    Vs1.ActiveSheet.Cells(1, i).Value = "Show"
                ElseIf L9911.Hidden = "0" Then
                    Vs1.ActiveSheet.Cells(1, i).Value = "Hide"
                End If

                Vs1.ActiveSheet.Columns(i).Locked = L9911.Lock
                i += 1
            Next
        Catch ex As Exception

        End Try
    End Sub

#End Region

    Private Sub DATA_SEARCH_VS1()
        cellick = False
        Dim SQL As String
        Dim RS01 As DataRow = Nothing
        Dim i As Integer = 0
        Dim j As Integer = 0
        Try

            SQL = ""
            SQL = SQL + "SELECT [K9911_ItemCode],[K9911_ItemName]"
            SQL = SQL + "      ,[K9911_ItemNameSimply],[K9911_ItemNameForeign1],[K9911_ItemNameForeign2],[K9911_ProdjectName]"
            SQL = SQL + "      ,[K9911_DataType],[K9911_DataSize]"
            SQL = SQL + "      ,[K9911_DataDecimal],[K9911_TextAlign]"
            SQL = SQL + "      ,[K9911_HorizontalAlignment] ,[K9911_VerticalAlignment]"
            SQL = SQL + "      ,[K9911_SizeWidth] ,[K9911_SizeHeight]"
            SQL = SQL + "      ,[K9911_BackColot] ,[K9911_ForeColor]"
            SQL = SQL + "      ,[K9911_FontName] ,[K9911_FontSize]"
            SQL = SQL + "      ,[K9911_CheckMerge] ,[K9911_CheckMergePolicy] ,[K9911_CheckHead] ,[K9911_CheckHeadType],[K9911_CheckDev] "
            SQL = SQL + "       ,[K9911_Lock],[K9911_Hidden]"
            SQL = SQL + "      ,[K9911_FontBold],[K9911_REMK]"
            SQL = SQL + "  FROM PFK9911"

            If txt_NAME.Data.Trim <> "" Then SQL = SQL + "   WHERE [K9911_ItemName] like '%" + txt_NAME.Data.Trim + "%'"
            cmd = New SqlClient.SqlCommand(SQL, cn)
            da.SelectCommand = cmd
            ds.Reset()
            da.Fill(ds)
            vS2.ActiveSheet.RowCount = 0
            ReDim a9911(0 To GetDsRc(ds) - 1)

            For Each RS01 In ds.Tables(0).Rows
                vS2.ActiveSheet.RowCount = i + 1
                K9911_MOVE(RS01)
                a9911(i) = D9911
                setData(vS2, 0, i, 0, , True)

                setData(vS2, 4, i, D9911.Lock, , True)
                setData(vS2, 5, i, D9911.Hidden, , True)

                setData(vS2, 1, i, D9911.ItemName)
                setCell(vS2, 1, i, D9911.ItemCode)
                setData(vS2, 2, i, D9911.ItemNameSimply)
                setData(vS2, 3, i, FUNCTION_DATATYPE(D9911.DataType))


                i += 1

            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DATA_SEARCH_VS1_2()
        cellick = False
        Dim RS01 As DataRow = Nothing
        Dim i As Integer = 0
        Dim j As Integer = 0
        Try
            Vs1.ActiveSheet.ColumnCount = 0

            For i = 0 To ListBox1.Items.Count - 1
                Vs1.ActiveSheet.ColumnCount = i + 1
                Dim stra() As String
                Vs1.ActiveSheet.Cells(0, i).Value = "99999999"
                stra = Split(ListBox1.GetItemText(ListBox1.Items(i)), "-")
                If READ_PFK9911(stra(1), stra(0)) = False Then Exit Sub
                L9911 = D9911
                SPR_PRO(Vs1, i, L9911)
                Vs1.ActiveSheet.Columns(i).Visible = True
                If L9911.Hidden = "1" Then
                    Vs1.ActiveSheet.Cells(1, i).Value = "Show"
                ElseIf L9911.Hidden = "0" Then
                    Vs1.ActiveSheet.Cells(1, i).Value = "Hide"
                End If

                Vs1.ActiveSheet.Columns(i).Locked = L9911.Lock
            Next
        Catch ex As Exception

        End Try
    End Sub
    'rEFRESH VS1 BASE ON COMBOBOX
    Private Sub refeshlist()
        Dim RS01 As DataRow = Nothing
        Dim i As Integer = 0
        Dim j As Integer = 0
        Try
            vS2.ActiveSheet.RowCount = 0

            For i = 0 To ListBox1.Items.Count - 1
                vS2.ActiveSheet.RowCount = i + 1
                Dim stra() As String
                stra = Split(ListBox1.GetItemText(ListBox1.Items(i)), "-")
                If READ_PFK9911(stra(1), stra(0)) = False Then Exit Sub
                setData(vS2, 0, i, 1, , True)

                'setData(vS2, 4, i, CBool(stra(2)), , True)
                'setData(vS2, 5, i, CBool(stra(3)), , True)
                If stra(2) = True Then setData(vS2, 4, i, "1", , True) Else setData(vS2, 4, i, "0", , True)
                If stra(3) = True Then setData(vS2, 5, i, "1", , True) Else setData(vS2, 5, i, "0", , True)
                'setData(vS2, 5, i, stra(3), , True)

                setData(vS2, 1, i, D9911.ItemName)
                setCell(vS2, 1, i, D9911.ItemCode)
                setData(vS2, 2, i, D9911.ItemNameSimply)
                setData(vS2, 3, i, FUNCTION_DATATYPE(D9911.DataType))
            Next


        Catch ex As Exception

        End Try
    End Sub

#End Region

#Region "Function"
    Private Function FUNCTION_DATATYPE(data As String) As String
        FUNCTION_DATATYPE = ""
        Select Case data
            Case 0 : FUNCTION_DATATYPE = "Text"
            Case 1 : FUNCTION_DATATYPE = "Number"
            Case 2 : FUNCTION_DATATYPE = "Button"
            Case 3 : FUNCTION_DATATYPE = "Combo"
            Case 4 : FUNCTION_DATATYPE = "Checkbox"
            Case 5 : FUNCTION_DATATYPE = "Date"
            Case 6 : FUNCTION_DATATYPE = "TextConvert"
            Case 7 : FUNCTION_DATATYPE = "Percent"
            Case Else : FUNCTION_DATATYPE = ""
        End Select
    End Function
    Private Sub DATA_MOVE(zzz As T9911_AREA)
        Itemcode.Data = zzz.ItemCode
        Itemname.Data = zzz.ItemName
        Itemnamesimple.Data = zzz.ItemNameSimply
        ItemnameForeign1.Data = zzz.ItemNameForeign1
        ItemnameForeign2.Data = zzz.ItemNameForeign2
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

        If zzz.CheckHead = "1" Then chk_CheckHead.Checked = True Else chk_CheckHead.Checked = False
        If zzz.CheckMerge = "1" Then chk_CheckMerge.Checked = True Else chk_CheckMerge.Checked = False
        If zzz.CheckDev = "1" Then chk_CheckDev.Checked = True Else chk_CheckDev.Checked = False

        chk_CheckHeadType.SelectedIndex = CIntp(zzz.CheckHeadType)
        chk_CheckMergePolicy.SelectedIndex = CIntp(zzz.CheckMergePolicy)

        Remark.Data = zzz.REMK
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

    Private Function data_check() As Boolean
        data_check = False
        If IsNumeric(Sizewidth.Data) = False Then Exit Function
        If IsNumeric(Sizewidth.Height) = False Then Exit Function
        If Datadecimal.Data.Trim = "" Then Exit Function

        data_check = True
    End Function
    Private Function data_check_k9912() As Boolean
        data_check_k9912 = False
        If Project.Text = "" Then Project.Focus() : Exit Function
        If proname2.Data = "" Then Setfocus(proname2) : Exit Function
        If sheetname2.Text = "" Then sheetname2.Focus() : Exit Function

        data_check_k9912 = True
    End Function
    Private Sub DATA_LINK()
        L9911.ItemName = Itemname.Data
        L9911.ItemCode = Itemcode.Data
        L9911.ItemNameSimply = Itemnamesimple.Data

        If ItemnameForeign1.Data.Trim <> "" Then L9911.ItemNameForeign1 = ItemnameForeign1.Data Else L9911.ItemNameForeign1 = Itemnamesimple.Data
        If ItemnameForeign2.Data.Trim <> "" Then L9911.ItemNameForeign2 = ItemnameForeign2.Data Else L9911.ItemNameForeign2 = Itemnamesimple.Data


        L9911.ProdjectName = Projectname.Data
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

        L9911.REMK = Remark.Data


    End Sub
    Private Sub CLEAR_ALL()
        Dim i As Integer
        ListBox1.Items.Clear()
        vS2.ActiveSheet.RowCount = 0
        Vs1.ActiveSheet.ColumnCount = 0
        Project.Text = ""
        sheetname2.Items.Clear()
        sheetname1.Items.Clear()
        sheetname1.Text = ""
        sheetname2.Text = ""
        proname1.Data = ""
        proname2.Data = ""
        For i = 0 To vS2.ActiveSheet.RowCount - 1
            setData(vS2, 0, i, 0, , True)
            setData(vS2, 4, i, 1, , True)
            setData(vS2, 5, i, 1, , True)
        Next
    End Sub
#End Region

#Region "Event"

    Private Sub ChangeValue(sender As Object, e As EventArgs) Handles Sizewidth.txtTextChanged, Sizeheight.txtTextChanged, Projectname.txtTextChanged, Itemnamesimple.txtTextChanged, Itemname.txtTextChanged, Forecolor_.txtTextChanged, Fontsize.txtTextChanged, Fontname.txtTextChanged, Fontbold.txtTextChanged, Backcolor_.txtTextChanged
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


    Private Sub Fontstyle_Load(sender As Object, e As EventArgs) Handles FontStyle.btnTitleClick
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
            If data_check() = False Then MsgBoxP("25", "DATAEROOR") : Exit Sub
            DATA_LINK()
            If READ_PFK9911(Itemcode.Data, Itemname.Data) = True Then
                REWRITE_PFK9911(L9911)
                MsgBoxP("UPDATE SUCCESSFULLY!")
            Else
                WRITE_PFK9911(L9911)
                MsgBoxP("INSERT SUCCESSFULLY!")
            End If
            '    DATA_SEARCH_VS1_2()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmd_DEL_Click(sender As Object, e As EventArgs) Handles cmd_DEL.Click
        Try
            If data_check() = False Then MsgBoxP("25", "DATAEROOR") : Exit Sub
            Dim str As String = MsgBoxP("Do you want to delete?", vbYesNo)
            If str = vbYes Then
                DATA_LINK()
                If READ_PFK9911(Itemcode.Data, Itemname.Data) = True Then
                    DELETE_PFK9911(L9911)
                End If
                DATA_SEARCH_VS1()
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

    Private Sub cmd_K9912_Click(sender As Object, e As EventArgs) Handles cmd_SAVE.Click
        Dim i As Integer

        Try
            If data_check_k9912() = False Then MsgBoxP("Please fulfill data...!!!") : Exit Sub
            If READ_PFK9912(Project.Text, proname2.Data, sheetname2.Text) = True Then
                L9912 = D9912
                If DELETE_PFK9912(L9912) = False Then Exit Sub
                For i = 0 To ListBox1.Items.Count - 1
                    Dim str() As String
                    str = Split(ListBox1.GetItemText(ListBox1.Items(i)), "-")
                    L9912.ItemCode = str(1)
                    L9912.Lock = FUNCTION_CBOOLEAN(str(2))
                    L9912.Hidden = FUNCTION_CBOOLEAN(str(3))
                    L9912.ProgramSeq = key_count_k9912(L9912.ProdjectName, L9912.ProgramNo, L9912.SheetName)
                    WRITE_PFK9912(L9912)
                Next
                MsgBoxP("UPDATE SUCCESSFULLY!", vbInformation)
            Else
                L9912 = D9912
                For i = 0 To ListBox1.Items.Count - 1
                    Dim str() As String
                    str = Split(ListBox1.GetItemText(ListBox1.Items(i)), "-")
                    L9912.ItemCode = str(1)
                    L9912.Lock = FUNCTION_CBOOLEAN(str(2))
                    L9912.Hidden = FUNCTION_CBOOLEAN(str(3))
                    L9912.ProdjectName = Project.Text
                    L9912.ProgramNo = proname2.Data
                    L9912.SheetName = sheetname2.Text
                    L9912.ProgramSeq = key_count_k9912(L9912.ProdjectName, L9912.ProgramNo, L9912.SheetName)
                    WRITE_PFK9912(L9912)

                Next
                MsgBoxP("INSERT SUCCESSFULLY!", vbInformation)
            End If
        Catch ex As Exception
        End Try
    End Sub


    Private Sub PeaceButton2_Click(sender As Object, e As EventArgs) Handles cmd_codeview.Click
        DATA_SEARCH_VS1()
    End Sub
    'VS1 EVENT
    Private Sub Vs1_ColumnWidthChanged(sender As Object, e As FarPoint.Win.Spread.ColumnWidthChangedEventArgs) Handles Vs1.ColumnWidthChanged
        If e.ColumnList.Count > 1 Then Exit Sub
        Try
            Sizewidth.Data = Vs1.ActiveSheet.Columns(xcol).Width
        Catch ex As Exception

        End Try
    End Sub

    Sub PeaceFarpoint_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellClick
        Vs1.ActiveSheet.ActiveColumnIndex = e.Column
        xcol = e.Column
        Dim itemname1 As String
        Dim itemcode1 As String
        itemcode1 = Strings.Left(Vs1.ActiveSheet.ColumnHeader.Columns(e.Column).Tag, 6)
        If itemcode1 = "" Then
            itemname1 = ""
        Else
            itemname1 = Strings.Right(Vs1.ActiveSheet.ColumnHeader.Columns(e.Column).Tag, Len(Vs1.ActiveSheet.ColumnHeader.Columns(e.Column).Tag) - 6)
        End If


        If READ_PFK9911(itemcode1, itemname1) = True Then
            Vs1.ActiveSheet.Cells(0, xcol).Value = "99999999"
            If D9911.Hidden = "1" Then
                DataHide.SelectedIndex = D9911.Hidden
                Vs1.ActiveSheet.Cells(1, xcol).Value = "Show"
            ElseIf D9911.Hidden = "0" Then
                DataHide.SelectedIndex = D9911.Hidden
                Vs1.ActiveSheet.Cells(1, xcol).Value = "Hide"
            End If


            DataLock.SelectedIndex = CIntp(D9911.Lock)
            Vs1.ActiveSheet.Columns(e.Column).Locked = CIntp(D9911.Lock)
            If MdiMenu.M20001.Checked = True Then Vs1.ActiveSheet.ColumnHeader.Columns(e.Column).Label = D9911.ItemNameSimply
            If MdiMenu.M20002.Checked = True Then Vs1.ActiveSheet.ColumnHeader.Columns(e.Column).Label = D9911.ItemNameForeign1

            Vs1.ActiveSheet.ColumnHeader.Columns(e.Column).Tag = D9911.ItemCode & D9911.ItemName

            Vs1.ActiveSheet.ColumnHeader.Columns(e.Column).Width = D9911.SizeWidth
            'Vs1.ActiveSheet.ColumnHeader.Rows(e.Column).Height = D9911.SizeHeight
            Dim newfont As Font
            If D9911.FontBold = 0 Then
                newfont = New Font(D9911.FontName, CSng(D9911.FontSize), Drawing.FontStyle.Regular)
            Else
                newfont = New Font(D9911.FontName, CSng(D9911.FontSize), Drawing.FontStyle.Bold)
            End If
            Vs1.ActiveSheet.ColumnHeader.Columns(e.Column).Font = newfont

            Vs1.ActiveSheet.Columns(e.Column).VerticalAlignment = D9911.VerticalAlignment
            Vs1.ActiveSheet.Columns(e.Column).HorizontalAlignment = D9911.HorizontalAlignment
            Dim str() As String
            str = Split(D9911.BackColot, "-")
            Vs1.ActiveSheet.Columns(e.Column).BackColor = System.Drawing.Color.FromArgb(CInt(str(0)), CInt(str(1)), CInt(str(2)))
            Dim str1() As String
            str1 = Split(D9911.ForeColor, "-")
            Vs1.ActiveSheet.Columns(e.Column).ForeColor = System.Drawing.Color.FromArgb(CInt(str1(0)), CInt(str1(1)), CInt(str1(2)))
            DATA_MOVE(D9911)

        Else
            Vs1.ActiveSheet.Cells(0, xcol).Value = "99999999"
            Vs1.ActiveSheet.Cells(1, e.Column).Value = "Show"
            Vs1.ActiveSheet.Columns(e.Column).Locked = True
            DataLock.SelectedIndex = 1
            DataHide.SelectedIndex = 1
            Itemcode.Data = key_count()
            Itemname.Data = "TEST"
            Itemnamesimple.Data = "TEST"
            Projectname.Data = Pub.SITE
            Datatype.SelectedIndex = 0
            Datasize.Data = 100
            Datadecimal.Data = 2
            TextAlign.SelectedIndex = 2
            HorizonAlign.SelectedIndex = 2
            VerticalAlign.SelectedIndex = 2
            Vs1.ActiveSheet.Columns(e.Column).VerticalAlignment = CellVerticalAlignment.Center
            Vs1.ActiveSheet.Columns(e.Column).HorizontalAlignment = CellHorizontalAlignment.Center
            Sizewidth.Data = 100
            Vs1.ActiveSheet.Columns(e.Column).Width = 100
            Sizeheight.Data = 20
            Backcolor_.Data = "255-255-255"
            Forecolor_.Data = "0-0-0"
            Backcolor_.TextboxBackColor = Color.White
            Forecolor_.TextboxBackColor = Color.Black
            Vs1.ActiveSheet.Columns(e.Column).BackColor = Color.White
            Vs1.ActiveSheet.Columns(e.Column).ForeColor = Color.Black
            If Vs1.ActiveSheet.ColumnHeader.Columns(e.Column).Font Is Nothing Then
                Fontname.Data = "Tahoma"
                Fontsize.Data = "9"
                Fontbold.Data = "0"
            Else
                Fontname.Data = Vs1.ActiveSheet.ColumnHeader.Columns(e.Column).Font.Name
                Fontsize.Data = Vs1.ActiveSheet.ColumnHeader.Columns(e.Column).Font.Size
                If Vs1.ActiveSheet.ColumnHeader.Columns(e.Column).Font.Bold = True Then
                    Fontbold.Data = "1"
                Else
                    Fontbold.Data = "0"
                End If

            End If
        End If
        cellick = True
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
            DATA_SEARCH_VS1()
        End If
    End Sub
    'VS2 EVENT
    Private Sub vS2_CellClick(sender As Object, e As CellClickEventArgs) Handles vS2.CellClick
        Dim i As Integer
        Dim str As String
        Dim str1 As String
        If e.ColumnHeader = True Or e.Row < 0 Then Exit Sub
        If e.Column = 0 Then
            str = getData(vS2, 0, e.Row)
            If str = True Then
                setData(vS2, 0, e.Row, 0, , True)
            Else
                setData(vS2, 0, e.Row, 1, , True)
            End If
            Dim a As String
            a = getData(vS2, 1, e.Row) & "-" & getCell(vS2, 1, e.Row) & "-" & getData(vS2, 4, e.Row) & "-" & getData(vS2, 5, e.Row)
            If getData(vS2, 0, e.Row) = True Then
                If READ_PFK9911(getCell(vS2, 1, e.Row), getData(vS2, 1, e.Row)) = True Then
                    For i = 0 To ListBox1.Items.Count - 1
                        If ListBox1.GetItemText(ListBox1.Items(i)) = a Then MsgBoxP("Inserted Already !!!") : refeshlist() : Exit Sub
                    Next
                    L9911 = D9911
                    ListBox1.Items.Add(a)
                End If
            Else
                For i = 0 To ListBox1.Items.Count - 1
                    If ListBox1.GetItemText(ListBox1.Items(i)) = a Then
                        ListBox1.Items.RemoveAt(i)
                        Exit For
                    End If
                Next
            End If
            ListBox1.SelectedIndex = ListBox1.Items.Count - 1
        End If
        If e.Column = 4 Then
            str = getData(vS2, 4, e.Row)
            If str = True Then
                setData(vS2, 4, e.Row, 0, , True)
            Else
                setData(vS2, 4, e.Row, 1, , True)
            End If
            Dim a, b As String
            a = getData(vS2, 1, e.Row) & "-" & getCell(vS2, 1, e.Row) & "-" & str & "-" & getData(vS2, 5, e.Row)
            b = getData(vS2, 1, e.Row) & "-" & getCell(vS2, 1, e.Row) & "-" & getData(vS2, 4, e.Row) & "-" & getData(vS2, 5, e.Row)
            If getData(vS2, 0, e.Row) = True Then
                For i = 0 To ListBox1.Items.Count - 1
                    If ListBox1.GetItemText(ListBox1.Items(i)) = a Then
                        ListBox1.Items.RemoveAt(i)
                        ListBox1.Items.Insert(i, b)
                        Exit Sub
                    End If
                Next
            End If
        End If
        If e.Column = 5 Then
            str1 = getData(vS2, 5, e.Row)
            If str1 = True Then
                setData(vS2, 5, e.Row, 0, , True)
            Else
                setData(vS2, 5, e.Row, 1, , True)
            End If
            Dim a, b As String
            a = getData(vS2, 1, e.Row) & "-" & getCell(vS2, 1, e.Row) & "-" & getData(vS2, 4, e.Row) & "-" & str1
            b = getData(vS2, 1, e.Row) & "-" & getCell(vS2, 1, e.Row) & "-" & getData(vS2, 4, e.Row) & "-" & getData(vS2, 5, e.Row)
            If getData(vS2, 0, e.Row) = True Then
                For i = 0 To ListBox1.Items.Count - 1
                    If ListBox1.GetItemText(ListBox1.Items(i)) = a Then
                        ListBox1.Items.RemoveAt(i)
                        ListBox1.Items.Insert(i, b)
                        Exit Sub
                    End If
                Next
            End If
        End If
    End Sub

    'Event Drop and Drap for Listbox
    Private Sub ListBox1_DragDrop(sender As Object, e As DragEventArgs) Handles ListBox1.DragDrop
        Dim p As Point = ListBox1.PointToClient(New Point(e.X, e.Y))
        dragIndex = ListBox1.IndexFromPoint(p.X, p.Y)
        If dragIndex < 0 Then dragIndex = ListBox1.Items.Count - 1
        If e.Effect = DragDropEffects.Move Then
            Dim dragtext As Object = ListBox1.Items(fromIndex)
            ListBox1.Items.RemoveAt(fromIndex)
            ListBox1.Items.Insert(dragIndex, dragtext)
        End If
        DATA_SEARCH_VS1_2()
    End Sub
    Private Sub ListBox1_DragOver(sender As Object, e As DragEventArgs) Handles ListBox1.DragOver
        e.Effect = DragDropEffects.Move
    End Sub

    Private Sub ListBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles ListBox1.KeyDown
        If e.KeyCode = Keys.Delete And ListBox1.SelectedIndex >= 0 Then
            e.Handled = True
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
        End If
    End Sub
    Private Sub ListBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles ListBox1.MouseDown
        fromIndex = ListBox1.SelectedIndex
        If fromIndex > -1 Then
            Dim dragSize As Size = SystemInformation.DragSize
            dragRect = New Rectangle(New Point(e.X - (dragSize.Width / 2), _
                                               e.Y - (dragSize.Height / 2)), _
                                     dragSize)
        Else
            dragRect = Rectangle.Empty
        End If
    End Sub
    Private Sub ListBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles ListBox1.MouseMove
        If (e.Button And MouseButtons.Left) = MouseButtons.Left Then
            If (dragRect <> Rectangle.Empty _
            AndAlso Not dragRect.Contains(e.X, e.Y)) Then
                ListBox1.DoDragDrop(ListBox1.Items(fromIndex), _
                                         DragDropEffects.Move)
            End If
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.Items.Count > 0 Then DATA_SEARCH_VS1_2()
    End Sub
    Private Sub PeaceButton6_Click(sender As Object, e As EventArgs) Handles cmd_CLR.Click
        CLEAR_ALL()
    End Sub

    Private Sub PeaceCombobox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles sheetname1.DropDown
        If proname1.Data.Trim = "" Then sheetname1.Items.Clear() : Exit Sub
        If DATA_SEARCH_SHEETNAME1() = False Then Exit Sub
    End Sub
    Private Sub PeaceCombobox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles sheetname2.DropDown
        If proname2.Data.Trim = "" Then sheetname2.Items.Clear() : Exit Sub
        If DATA_SEARCH_SHEETNAME2() = False Then Exit Sub
    End Sub

    Private Sub cmd_Search_Click(sender As Object, e As EventArgs) Handles cmd_Search.Click
        ListBox1.Items.Clear()
        DATA_SEARCH_VS2()
        refeshlist()
    End Sub

    Private Sub PeaceButton9_Click(sender As Object, e As EventArgs) Handles cmd_refresh.Click
        refeshlist()
    End Sub


    Private Sub cmd_TRAN_Click(sender As Object, e As EventArgs) Handles cmd_TRAN.Click
        Project.Text = PeaceCombobox1.Text
        proname2.Data = proname1.Data
        sheetname2.Text = sheetname1.Text
    End Sub
#End Region

    Private Sub cmd_Rearragement_Click(sender As Object, e As EventArgs) Handles cmd_RE.Click
        Dim SQL As String
        Dim RS01 As DataRow = Nothing
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim RowCnt As Integer
        Dim VariCnt As Integer
        Dim EndRow As Integer
        Dim Chkk As Boolean = False

        For i = 0 To ListBox1.Items.Count - 1
            If i > ListBox1.Items.Count - 1 Then Exit For
            For j = 0 To ListBox1.Items.Count - 1
                If j > ListBox1.Items.Count - 1 Then Exit For

                If i <> j And ListBox1.Items(i).ToString = ListBox1.Items(j).ToString Then
                    ListBox1.Items.RemoveAt(j)
                    j -= 1
                End If
            Next
        Next

        Try
            SQL = ""
            SQL = SQL + "SELECT A.name as ID"
            SQL = SQL + "      ,count(A.object_id) AS QTY"
            SQL = SQL + "      FROM sys.procedures A"
            SQL = SQL + "      INNER JOIN sys.parameters B"
            SQL = SQL + "       ON A.object_id = B.object_id"
            SQL = SQL + "   WHERE A.name = '" + proname1.Data.Trim + "' GROUP BY A.name "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then rd.Close() : MsgBoxP("Spread by user! No database!") : Exit Sub

            VariCnt = CIntp(rd("QTY"))
            rd.Close()

            EndRow = ListBox1.Items.Count - 1
            DS1 = DatanewSH(proname1.Data, VariCnt)

            RowCnt = GetDsCc(DS1)
            For i = 0 To RowCnt - 1
                For j = 0 To ListBox1.Items.Count - 1
                    Dim stra() As String
                    stra = Split(ListBox1.GetItemText(ListBox1.Items(j)), "-")
                    If DS1.Tables(0).Columns(i).ColumnName.ToUpper = stra(0).ToUpper Then
                        Dim dragtext As Object = ListBox1.Items(j)
                        ListBox1.Items.RemoveAt(j)
                        ListBox1.Items.Insert(EndRow, dragtext)
                    End If
                Next
            Next

            For i = 0 To ListBox1.Items.Count - 1
                Dim stra() As String
                stra = Split(ListBox1.GetItemText(ListBox1.Items(i)), "-")

                For j = 0 To RowCnt - 1
                    If DS1.Tables(0).Columns(j).ColumnName.ToUpper = stra(0).ToUpper Then
                        Chkk = True
                        Exit For
                    End If
                Next

                If Chkk = False Then
                    ListBox1.Items.RemoveAt(i)
                    If i > 0 Then i -= 1
                End If

                Chkk = False
            Next

        Catch ex As Exception

        End Try
    End Sub
    Private Function DatanewSH(a As String, b As Integer) As DataSet
        DatanewSH = Nothing
        Dim i As Integer
        Dim chuoi() As String
        ReDim chuoi(b - 1)
        For i = 0 To b - 1
            chuoi(i) = ""
        Next
        DatanewSH = PrcDS(a, cn, chuoi)
    End Function
End Class