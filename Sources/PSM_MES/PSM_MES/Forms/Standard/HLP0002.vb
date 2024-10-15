Public Class HLP0002

    Private Dsu01 As Long
    Private W1_Head As Integer = 2
    Private wGCHK As String

    Private W7101 As T7101_AREA
    Private W7171 As T7171_AREA
    Private vschkbx As New FarPoint.Win.Spread.CellType.CheckBoxCellType

   
    Private Sub HLP0000_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hlp0000SeVa = ""
        hlp0000SeVaTt = ""
        SPR_CLEAR(VS1)
        SPR_SET(VS1, , , , OperationMode.SingleSelect, True)
        kndl()
        Me.Text = HLPNA
        If DATA_SEARCH01() = False Then
            Exit Sub
        End If
    End Sub

    Public Overridable Function DATA_SEARCH01() As Boolean
        VS1.Sheets(0).RowCount = 0
        Dim i As Integer
        DATA_SEARCH01 = False
        Try

            'If HLPNA = "" Then
            '    SQL = "SELECT K7411_IDNO,K7411_Name , K7411_IDCard FROM PFK7411"
            '    SQL = SQL + " WHERE  K7411_Name LIKE  N'%" + txt_Name.Data + "%'"

            'Else
            '    SQL = "SELECT K7411_IDNO,K7411_Name , K7411_IDCard FROM PFK7411"
            '    SQL = SQL + " WHERE K7411_cdInCharge        = '" + SELCON(HLPNA) + "'"
            '    If txt_Name.Data <> "" Then
            '        SQL = SQL + "   AND K7411_Name LIKE  N'%" + txt_Name.Data + "%'"
            '    End If

            'End If


            'cmd = New SqlClient.SqlCommand(SQL, cn)

            'da.SelectCommand = cmd
            'ds.Reset()
            'da.Fill(ds)
            'If GetDsRc(ds) = 0 Then
            '    Call MsgBoxP("150", "NO DATA FIELD")
            '    Exit Function
            'End If
            'VS1.Sheets(0).RowCount = ds.Tables(0).Rows.Count
            'VS1.Sheets(0).ColumnCount = ds.Tables(0).Columns.Count

            'For i = 0 To ds.Tables(0).Rows.Count - 1
            '    VS1.Sheets(0).Cells(i, 0).Value = ds.Tables(0).Rows(i).Item(0)
            '    VS1.Sheets(0).Cells(i, 1).Value = ds.Tables(0).Rows(i).Item(1)
            '    VS1.Sheets(0).Cells(i, 2).Value = ds.Tables(0).Rows(i).Item(2)
            'Next

            DS1 = PrcDS("USP_HLP7411A_SEARCH_VS1", cn, "*" & txt_Name.Data, SELCON(HLPNA))

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(VS1, DS1, "USP_HLP7411A_SEARCH_VS1", "Vs1")
                VS1.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(VS1, DS1, "USP_HLP7411A_SEARCH_VS1", "Vs1")
            DATA_SEARCH01 = True

            DATA_SEARCH01 = True
            VS1.Sheets(0).Visible = True
            cmd_OK.Enabled = True
            SPR_END(VS1)
            Me.Show()
            Application.DoEvents()
            VS1.Focus()
        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Function
    Private Sub SelectLabelSearch1_Load(sender As Object, e As KeyEventArgs) Handles txt_Name.txtTextKeyDown
        If e.KeyCode = Keys.Enter Then DATA_SEARCH01()
    End Sub

    Private Sub cmd_CANCEL_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        hlp0000SeVa = ""
        hlp0000SeVaTt = ""
        Me.Dispose()
    End Sub

    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        DATA_SEARCH01()
    End Sub


    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        If getData(VS1, 1, VS1.ActiveSheet.ActiveRowIndex) Is Nothing Then
            MsgBoxP("NO VALUE !")
            Exit Sub
        Else
            hlp0000SeVa = getData(VS1, 1, VS1.ActiveSheet.ActiveRowIndex)
            hlp0000SeVaTt = getData(VS1, 0, VS1.ActiveSheet.ActiveRowIndex)
        End If
        Me.Dispose()
    End Sub


    Private Sub VS1_CellClick(sender As Object, e As CellClickEventArgs) Handles VS1.CellClick
        If e.Row < 0 Then Exit Sub
        VS1.ActiveSheet.ActiveRowIndex = e.Row
        VS1.ActiveSheet.ActiveColumnIndex = e.Column
    End Sub

    Private Sub VS1_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles VS1.CellDoubleClick
        If getData(VS1, 1, VS1.ActiveSheet.ActiveRowIndex) Is Nothing Then
            MsgBoxP("NO VALUE !")
            Exit Sub
        Else
            hlp0000SeVa = getData(VS1, 1, VS1.ActiveSheet.ActiveRowIndex)
            hlp0000SeVaTt = getData(VS1, 0, VS1.ActiveSheet.ActiveRowIndex)
        End If
        Me.Close()
    End Sub

    Private Sub VS1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles VS1.KeyPress
        Select Case e.KeyChar
            Case ChrW(Keys.Enter), ChrW(Keys.Escape) : cmd_OK.PerformClick()

        End Select
    End Sub

  
End Class