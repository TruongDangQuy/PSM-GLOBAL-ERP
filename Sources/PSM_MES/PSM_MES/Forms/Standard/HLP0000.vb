Public Class HLP0000
    Private Dsu01 As Long
    Private W1_Head As Integer = 2
    Private wGCHK As String

    Private W7101 As T7101_AREA
    Private W7171 As T7171_AREA
    Private vschkbx As New FarPoint.Win.Spread.CellType.CheckBoxCellType

    Private Sub HLP0000_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Text = ""

    End Sub
    Public Overridable Sub HLP0000_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SPR_SET(VS1, , , , OperationMode.SingleSelect, False)
        Me.Text = HLPNA
        DATA_SEARCH01(W1_Head)
    End Sub
    Public Overridable Function DATA_SEARCH01(Head_No As String) As Boolean
        DATA_SEARCH01 = False
        Try
            Dim i, xrow, xcol As Integer
            Dim da As New SqlClient.SqlDataAdapter
            cmd_OK.Enabled = False
            SPR_CLEAR(VS1)
            Dim SWORD As String
            Dim EWORD As String
            SWORD = "" : EWORD = ""
            If charac <> "" Then
                SelectLabelSearch1.PeaceTextbox1.Text = ""
                SWORD = charac
            End If
            HLPSEARCH(HLPNA, SelectLabelSearch1.PeaceTextbox1.Text.Trim, charac, SWORD, EWORD, Head_No)
            charac = ""
            da.SelectCommand = cmd
            ds.Reset()
            da.Fill(ds)
            xrow = ds.Tables(0).Rows.Count
            xcol = ds.Tables(0).Columns.Count
            If xrow = 0 Then
                Call MsgBoxP("150", "NO DATA FIELD")
                Exit Function
            End If
            SPR_SET(VS1, , , xrow, OperationMode.SingleSelect, True)

            If xcol = 1 Or HLPNA = "ODNO" Then
                VS1.Sheets(0).Columns(0).Visible = False
                VS1.Sheets(0).Columns(1).Width = 445
                For i = 0 To xrow - 1
                    ' VS1.Sheets(0).Cells(i, 0).Value = ds.Tables(0).Rows(i).Item("GCODE")
                    '    VS1.Sheets(0).Cells(i, 0).Value = ds.Tables(0).Rows(i).Item(0)
                    setData(VS1, 1, i, ds.Tables(0).Rows(i).Item(0))
                    setCell(VS1, 1, i, ds.Tables(0).Rows(i).Item(0))
                Next
            ElseIf HLPNA = "btn_WProcess" Then
                For i = 0 To xrow - 1
                    setData(VS1, 0, i, ds.Tables(0).Rows(i).Item("K8780_GNAME"))
                    setCell(VS1, 0, i, ds.Tables(0).Rows(i).Item("K8780_GJCD"))
                    setData(VS1, 1, i, ds.Tables(0).Rows(i).Item("GJNAME"))
                Next
            Else
                VS1.Sheets(0).Columns(0).Visible = True
                For i = 0 To xrow - 1
                    setData(VS1, 0, i, ds.Tables(0).Rows(i).Item(0))
                    setData(VS1, 1, i, ds.Tables(0).Rows(i).Item(1))
                Next
            End If
            DATA_SEARCH01 = True
            VS1.Sheets(0).Visible = True
            cmd_OK.Enabled = True
            SPR_END(VS1)
        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Function
    Private Sub cmd_CANCEL_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        DATA_SEARCH01(W1_Head)
    End Sub
    Private Sub VS2_CellClick(sender As Object, e As FarPoint.Win.Spread.CellClickEventArgs) Handles VS2.CellClick
        charac = VS2.Sheets(0).Cells(e.Row, e.Column).Value
        DATA_SEARCH01(W1_Head)
    End Sub


    Public Overridable Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        If HLPNA = "btn_WProcess" Then
            hlp0000SeVa = getData(VS1, 1, VS1.ActiveSheet.ActiveRowIndex)
            hlp0000SeVaTt1 = getData(VS1, 0, VS1.ActiveSheet.ActiveRowIndex)
            hlp0000SeVaTt = getCell(VS1, 0, VS1.ActiveSheet.ActiveRowIndex)
        End If
        If getData(VS1, 1, VS1.ActiveSheet.ActiveRowIndex) IsNot Nothing Then
            hlp0000SeVa = getData(VS1, 1, VS1.ActiveSheet.ActiveRowIndex)
            Me.Close()
        ElseIf getData(VS1, 0, VS1.ActiveSheet.ActiveRowIndex) IsNot Nothing Then
            hlp0000SeVa = getData(VS1, 0, VS1.ActiveSheet.ActiveRowIndex)
            Me.Close()
        Else
            MsgBoxP("NO VALUE !")
            Exit Sub
        End If
        Me.Close()
    End Sub

    Private Sub VS1_CellClick1(sender As Object, e As CellClickEventArgs) Handles VS1.CellClick
        If e.Row < 0 Then Exit Sub
        VS1.ActiveSheet.ActiveRowIndex = e.Row
        VS1.ActiveSheet.ActiveColumnIndex = e.Column
    End Sub


    Public Overridable Sub VS1_CellClick(sender As Object, e As CellClickEventArgs) Handles VS1.CellDoubleClick
        If HLPNA = "btn_WProcess" Then
            hlp0000SeVa = getData(VS1, 1, e.Row)
            hlp0000SeVaTt1 = getData(VS1, 0, e.Row)
            hlp0000SeVaTt = getCell(VS1, 0, e.Row)
        End If
        If getData(VS1, 1, e.Row) IsNot Nothing Then
            hlp0000SeVa = getData(VS1, 1, e.Row)
            Me.Close()
        ElseIf getData(VS1, 0, e.Row) IsNot Nothing Then
            hlp0000SeVa = getData(VS1, 0, e.Row)
            Me.Close()
        Else
            MsgBoxP("NO VALUE !")
            Exit Sub
        End If
        Me.Close()
    End Sub

    Private Sub VS1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles VS1.KeyPress
        Select Case e.KeyChar
            Case ChrW(Keys.Enter), ChrW(Keys.Escape) : cmd_OK.PerformClick()
        End Select
    End Sub
End Class