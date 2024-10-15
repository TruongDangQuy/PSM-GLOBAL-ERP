Public Class P_SPREAD_SETUP
#Region "Variable"
    Private checkrn As Boolean = False
    Private a9911() As T9911_AREA
    Private L9911 As T9911_AREA
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

#Region "Function"
    Private Sub DATA_SEARCH()
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
            SQL = SQL + "       ,[K9911_Lock],[K9911_Hidden]"
            SQL = SQL + "      ,[K9911_FontBold],[K9911_REMK]"
            SQL = SQL + "  FROM PFK9911"
            If txt_NAME.Data.Trim <> "" Then SQL = SQL + "   WHERE [K9911_ItemName] Like '%" + txt_NAME.Data.Trim + "%'"
            cmd = New SqlClient.SqlCommand(SQL, cn)
            da.SelectCommand = cmd
            ds.Reset()
            da.Fill(ds)
            Vs1.ActiveSheet.ColumnCount = 0
            ReDim a9911(0 To GetDsRc(ds) - 1)

            For Each RS01 In ds.Tables(0).Rows
                Vs1.ActiveSheet.ColumnCount = i + 1
                K9911_MOVE(RS01)
                a9911(i) = D9911
                Vs1.ActiveSheet.Cells(0, i).Value = "9999999"
                Vs1.ActiveSheet.ColumnHeader.Columns(i).Label = D9911.ItemNameSimply
                Vs1.ActiveSheet.ColumnHeader.Columns(i).Tag = D9911.ItemCode & D9911.ItemName
                Select Case D9911.DataType
                    Case 0
                        textt.MaxLength = D9911.DataSize
                        Vs1.ActiveSheet.ColumnHeader.Columns(i).CellType = textt
                    Case 1
                        numbt.DecimalPlaces = D9911.DataDecimal
                        numbt.ShowSeparator = True
                        SPR_NUMBERCELL(Vs1, D9911.DataDecimal, i)
                    Case 2
                        SPR_BUTTON(Vs1, i)
                    Case 3
                        SPR_COMBOBOX(Vs1, i)
                    Case 4
                        SPR_CHECKBOX(Vs1, i)
                End Select
                Vs1.ActiveSheet.ColumnHeader.Columns(i).Width = D9911.SizeWidth
                Dim str() As String
                str = Split(D9911.BackColot, "-")
                Vs1.ActiveSheet.Columns(i).BackColor = System.Drawing.Color.FromArgb(CInt(str(0)), CInt(str(1)), CInt(str(2)))
                Dim str1() As String
                str1 = Split(D9911.ForeColor, "-")
                Vs1.ActiveSheet.Columns(i).ForeColor = System.Drawing.Color.FromArgb(CInt(str1(0)), CInt(str1(1)), CInt(str1(2)))

                Dim newfont As Font
                If D9911.FontBold = 0 Then
                    newfont = New Font(D9911.FontName, CSng(D9911.FontSize), Drawing.FontStyle.Regular)
                Else
                    newfont = New Font(D9911.FontName, CSng(D9911.FontSize), Drawing.FontStyle.Bold)
                End If
                Vs1.ActiveSheet.ColumnHeader.Columns(i).Font = newfont
                Vs1.ActiveSheet.Columns(i).VerticalAlignment = D9911.VerticalAlignment
                Vs1.ActiveSheet.Columns(i).HorizontalAlignment = D9911.HorizontalAlignment

                Vs1.ActiveSheet.Columns(i).Locked = D9911.Lock
                If D9911.Hidden = "1" Then
                    Vs1.ActiveSheet.Cells(1, i).Value = "Show"
                ElseIf D9911.Hidden = "0" Then
                    Vs1.ActiveSheet.Cells(1, i).Value = "Hide"
                End If

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
        L9911.ItemCode = Itemcode.Data
        L9911.ItemNameSimply = Itemnamesimple.Data
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
            Vs1.ActiveSheet.Cells(0, xcol).Value = "9999999"
            If D9911.Hidden = "1" Then
                DataHide.SelectedIndex = D9911.Hidden
                Vs1.ActiveSheet.Cells(1, xcol).Value = "Show"
            ElseIf D9911.Hidden = "0" Then
                DataHide.SelectedIndex = D9911.Hidden
                Vs1.ActiveSheet.Cells(1, xcol).Value = "Hide"
            End If

            Vs1.ActiveSheet.Columns(e.Column).Locked = D9911.Lock

            DataLock.SelectedIndex = D9911.Lock
            Vs1.ActiveSheet.ColumnHeader.Columns(e.Column).Label = D9911.ItemNameSimply
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
            Vs1.ActiveSheet.Cells(0, e.Column).Value = "9999999"
            Vs1.ActiveSheet.Cells(1, e.Column).Value = "Show"
            Vs1.ActiveSheet.Columns(e.Column).Locked = True
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
            DataLock.SelectedIndex = 1
            DataHide.SelectedIndex = 1
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
            If data_check() = False Then MsgBoxP("25", "DATAEROOR") : Exit Sub
            DATA_LINK()
            If READ_PFK9911(Itemcode.Data, Itemname.Data) = True Then
                REWRITE_PFK9911(L9911)
                MsgBoxP("UPDATE SUCCESSFULLY!")
            Else
                WRITE_PFK9911(L9911)
                MsgBoxP("INSERT SUCCESSFULLY!")
            End If
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
End Class