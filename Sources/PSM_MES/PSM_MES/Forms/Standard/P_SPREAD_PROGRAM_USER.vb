Public Class P_SPREAD_PROGRAM_USER
#Region "Variable"
    Private checkrn As Boolean = False
    Private a9911() As T9911_AREA
    Private L9911 As T9911_AREA

    Private a9912() As T9912_AREA
    Private L9912 As T9912_AREA

    Private a9913() As T9913_AREA
    Private L9913 As T9913_AREA

    Private fromIndex As Integer
    Private targetIndex As Integer
    Private dragIndex As Integer
    Private dragRect As Rectangle
    Private proname1, sheetname1 As String

    Private xcol As Integer
    Private textt As New FarPoint.Win.Spread.CellType.TextCellType
    Private numbt As New FarPoint.Win.Spread.CellType.NumberCellType
    Private buttt As New FarPoint.Win.Spread.CellType.ButtonCellType
    Private combt As New FarPoint.Win.Spread.CellType.ComboBoxCellType
    Private chkt As New FarPoint.Win.Spread.CellType.CheckBoxCellType
    Private cellick As Boolean = False
    Private item As New List(Of T9911_AREA)

    Private formA As Boolean

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
    Public Function Link_ISUD_P_SPREAD_PROGRAM_USER(job As Integer, _proname1 As String, _sheetname1 As String, Optional CheckName As String = "") As Boolean
        Me.Tag = CheckName
        proname1 = _proname1
        sheetname1 = _sheetname1

        proname2.Data = _proname1
        sheetname2.Text = _sheetname1

        Link_ISUD_P_SPREAD_PROGRAM_USER = False
       
        formA = False
        Me.ShowDialog()

        Link_ISUD_P_SPREAD_PROGRAM_USER = isudCHK
    End Function
    Private Sub SPREAD_SETUP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        form_int()
        data_int()
        ListBox1.Items.Clear()
        If DATA_SEARCH() = False Then DATA_SEARCH_VS2()
        refeshlist()
    End Sub
    Private Sub form_int()
        L9911 = D9911
        L9912 = D9912
    End Sub
    Private Sub data_int()

    End Sub
#End Region

#Region "DATA_SEARCH"
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
            SQL = SQL + "      ,K9911_FormType, [K9911_DataType],[K9911_DataSize]"
            SQL = SQL + "      ,[K9911_DataDecimal],[K9911_TextAlign]"
            SQL = SQL + "      ,[K9911_HorizontalAlignment] ,[K9911_VerticalAlignment]"
            SQL = SQL + "      ,[K9911_SizeWidth] ,[K9911_SizeHeight]"
            SQL = SQL + "      ,[K9911_BackColot] ,[K9911_ForeColor]"
            SQL = SQL + "      ,[K9911_FontName] ,[K9911_FontSize]"
            SQL = SQL + "      ,[K9911_FontBold],[K9911_REMK]"
            SQL = SQL + "      ,[K9911_CheckMerge] ,[K9911_CheckMergePolicy] ,[K9911_CheckHead] ,[K9911_CheckHeadType],[K9911_CheckDev],[K9911_CheckDevValue] "
            SQL = SQL + "       ,[K9912_Lock] AS [K9911_Lock] ,[K9912_Hidden] AS [K9911_Hidden]"
            SQL = SQL + "  FROM PFK9912 A"
            SQL = SQL + " INNER JOIN PFK9911 B "
            SQL = SQL + " ON A.K9912_ItemCode = B.K9911_ItemCode"
            SQL = SQL + " WHERE [K9912_ProgramNo] = '" + proname1 + "'"
            SQL = SQL + " AND [K9912_SheetName]  = '" + sheetname1 + "'"
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

    Private Function DATA_SEARCH() As Boolean
        DATA_SEARCH = False

        cellick = False
        Dim SQL As String
        Dim RS01 As DataRow = Nothing
        Dim i As Integer = 0
        Dim j As Integer = 0
        Try

            SQL = ""
            SQL = SQL + "SELECT K9911_ItemCode,[K9911_ItemName]"
            SQL = SQL + "      ,[K9911_ItemNameSimply],[K9911_ItemNameForeign1],[K9911_ItemNameForeign2],[K9911_ProdjectName]"
            SQL = SQL + "      , K9911_FormType, [K9911_DataType],[K9911_DataSize]"
            SQL = SQL + "      ,[K9911_DataDecimal],[K9911_TextAlign]"
            SQL = SQL + "      ,[K9911_HorizontalAlignment] ,[K9911_VerticalAlignment]"
            SQL = SQL + "      ,[K9911_SizeWidth] ,[K9911_SizeHeight]"
            SQL = SQL + "      ,[K9911_BackColot] ,[K9911_ForeColor]"
            SQL = SQL + "      ,[K9911_FontName] ,[K9911_FontSize]"
            SQL = SQL + "      ,[K9911_FontBold],[K9911_REMK]"
            SQL = SQL + "      ,[K9911_CheckMerge] ,[K9911_CheckMergePolicy] ,[K9911_CheckHead] ,[K9911_CheckHeadType],[K9911_CheckDev],K9911_CheckDevValue "
            SQL = SQL + "       ,[K9913_Lock] AS [K9911_Lock] ,[K9913_Hidden] AS [K9911_Hidden]"
            SQL = SQL + "  FROM PFK9913 A"
            SQL = SQL + " INNER JOIN PFK9911 B "
            SQL = SQL + " ON A.K9913_ItemCode = B.K9911_ItemCode"
            SQL = SQL + " WHERE [K9913_ProgramNo] = '" + proname1 + "'"
            SQL = SQL + " AND [K9913_SheetName]  = '" + sheetname1 + "'"
            SQL = SQL + " AND [K9913_Sano]  = '" + Pub.SAW + "'"

            cmd = New SqlClient.SqlCommand(SQL, cn)
            da.SelectCommand = cmd
            ds.Reset()
            da.Fill(ds)
            vS1.ActiveSheet.ColumnCount = 0
            If GetDsRc(ds) = 0 Then Exit Function

            For Each RS01 In ds.Tables(0).Rows
                vS1.ActiveSheet.ColumnCount = i + 1
                vS1.ActiveSheet.Cells(0, i).Value = "99999999"
                K9911_MOVE(RS01)
                L9911 = D9911
                ListBox1.Items.Add(L9911.ItemName & "-" & L9911.ItemCode & "-" & FUNCTION_BOOLEAN(L9911.Lock) & "-" & FUNCTION_BOOLEAN(L9911.Hidden))
                SPR_PRO(vS1, i, L9911)
                vS1.ActiveSheet.Columns(i).Visible = True
                If L9911.Hidden = "1" Then
                    vS1.ActiveSheet.Cells(1, i).Value = "Show"
                ElseIf L9911.Hidden = "0" Then
                    vS1.ActiveSheet.Cells(1, i).Value = "Hide"
                End If

                vS1.ActiveSheet.Columns(i).Locked = L9911.Lock
                i += 1
            Next

            DATA_SEARCH = True
        Catch ex As Exception

        End Try
    End Function
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
  
#End Region

#Region "SPREAD"

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

                'Check Develop or Not. If devlop cannot click!

                'If D9911.CheckDev = "1" Then setCell(vS2, 5, i, D9911.CheckDev) : SPR_BACKCOLORCELL(vS2, Color.Red, 5, i)

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
            Case Else : FUNCTION_DATATYPE = ""
        End Select
    End Function
  
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

    Private Function key_count_k9913(a As String, b As String, c As String, d As String) As String
        Dim SQL As String
        Dim rd As SqlClient.SqlDataReader

        SQL = "SELECT MAX(CAST(K9913_ProgramSeq AS DECIMAL)) AS MAX_CODE FROM PFK9913 "
        SQL = SQL + " WHERE [K9913_ProdjectName] = '" + a + "' "
        SQL = SQL + " AND [K9913_ProgramNo] = '" + b + "' "
        SQL = SQL + " AND [K9913_SheetName] = '" + c + "' "
        SQL = SQL + " AND [K9913_Sano] = '" + d + "' "
        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_CODE) Then
            key_count_k9913 = "000001"
        Else
            key_count_k9913 = Format(CInt(rd!MAX_CODE + 1), "000000")
        End If
        rd.Close()
    End Function

    Private Function data_check_k9912() As Boolean
        data_check_k9912 = False
        If Project.Text = "" Then Project.Focus() : Exit Function
        If proname2.Data = "" Then Setfocus(proname2) : Exit Function
        If sheetname2.Text = "" Then sheetname2.Focus() : Exit Function

        data_check_k9912 = True
    End Function
    
#End Region

#Region "Event"

    Private Sub tst_iSave_Click(sender As Object, e As EventArgs) Handles tst_iSave.Click
        Dim i As Integer

        Try
            If data_check_k9912() = False Then MsgBoxP("Please fulfill data...!!!") : Exit Sub
            If READ_PFK9913(Pub.SAW, Project.Text, proname2.Data, sheetname2.Text) = True Then
                L9913 = D9913
                If DELETE_PFK9913(L9913) = False Then Exit Sub
                For i = 0 To ListBox1.Items.Count - 1
                    Dim str() As String
                    str = Split(ListBox1.GetItemText(ListBox1.Items(i)), "-")
                    L9913.ItemCode = str(1)
                    L9913.Lock = FUNCTION_CBOOLEAN(str(2))
                    L9913.Hidden = FUNCTION_CBOOLEAN(str(3))
                    L9913.ProgramSeq = key_count_k9913(L9913.ProdjectName, L9913.ProgramNo, L9913.SheetName, Pub.SAW)

                    If READ_PFK9912_3("DMS", L9913.ProgramNo, L9913.SheetName, L9913.ItemCode) = True Then
                        L9913.SizeWidth = D9912.SizeWidth

                        If D9912.SizeWidth = 0 Then
                            If READ_PFK9911_ITEMCODE(L9913.ItemCode) Then
                                L9913.SizeWidth = D9911.SizeWidth
                            End If
                        End If

                        WRITE_PFK9913(L9913)

                    End If
                Next

                MsgBoxP("UPDATE SUCCESSFULLY!", vbInformation)
            Else
                L9913 = D9913
                For i = 0 To ListBox1.Items.Count - 1
                    Dim str() As String
                    str = Split(ListBox1.GetItemText(ListBox1.Items(i)), "-")
                    L9913.ItemCode = str(1)
                    L9913.Lock = FUNCTION_CBOOLEAN(str(2))
                    L9913.Hidden = FUNCTION_CBOOLEAN(str(3))
                    L9913.ProdjectName = Project.Text
                    L9913.ProgramNo = proname2.Data
                    L9913.SheetName = sheetname2.Text
                    L9913.ProgramSeq = key_count_k9913(L9913.ProdjectName, L9913.ProgramNo, L9913.SheetName, Pub.SAW)
                    L9913.Sano = Pub.SAW

                    If READ_PFK9912_3("DMS", L9913.ProgramNo, L9913.SheetName, L9913.ItemCode) = True Then
                        L9913.SizeWidth = D9912.SizeWidth

                        If D9912.SizeWidth = 0 Then
                            If READ_PFK9911_ITEMCODE(L9913.ItemCode) Then
                                L9913.SizeWidth = D9911.SizeWidth
                            End If
                        End If
                        WRITE_PFK9913(L9913)
                    End If

                Next

                MsgBoxP("INSERT SUCCESSFULLY!", vbInformation)
            End If
        Catch ex As Exception
        End Try
    End Sub


    'VS2 EVENT
    Private Sub vS2_CellClick(sender As Object, e As CellClickEventArgs) Handles vS2.CellClick
        Dim i As Integer
        Dim str1 As String
        Dim DevChk As String

        If e.ColumnHeader = True Or e.Row < 0 Then Exit Sub
    
        If e.Column = 5 Then
            str1 = getData(vS2, 5, e.Row)
            DevChk = getCell(vS2, 5, e.Row)

            If DevChk = "1" Then Exit Sub

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


 #End Region

    Private Sub tst_iClose_Click(sender As Object, e As EventArgs) Handles tst_iClose.Click
        Me.Dispose()
    End Sub

    Private Sub tst_iDelete_Click(sender As Object, e As EventArgs) Handles tst_iDelete.Click
        If READ_PFK9913(Pub.SAW, Project.Text, proname2.Data, sheetname2.Text) = True Then
            L9913 = D9913
            Call DELETE_PFK9913(L9913)
            Me.Dispose()
            Exit Sub

            form_int()
            data_int()
            ListBox1.Items.Clear()
            If DATA_SEARCH() = False Then DATA_SEARCH_VS2()
            refeshlist()
        End If
    End Sub
End Class