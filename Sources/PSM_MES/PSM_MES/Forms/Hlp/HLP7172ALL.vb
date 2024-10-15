Public Class HLP7172ALL

#Region "Variable"
    Private Dsu01 As Long
    Private W1_Head As Integer = 2
    Private wGCHK As String

    Private W7171 As T7171_AREA
    Private vschkbx As New FarPoint.Win.Spread.CellType.CheckBoxCellType
#End Region

#Region "Form_Load"
    Private Sub HLP0000_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hlp0000SeVa = ""
        hlp0000SeVaTt = ""
        SPR_CLEAR(VS1)
        SPR_SET(VS1, , , , OperationMode.SingleSelect, True)
        If DATA_SEARCH01() = False Then
            Exit Sub
        End If

    End Sub
#End Region

#Region "Methods"
    Public Overridable Function DATA_SEARCH01() As Boolean
        Dim i As Integer

        DATA_SEARCH01 = False
        VS1.Sheets(0).RowCount = 0

        Try
            If HLPNA = "Const_AccCode;7" Or HLPNA = "Const_AccCode;1" Then
                ds = PrcDS("USP_HLP7501A_ACCOUNTCODE_CHECK", cn, txt_Name.Data, "", "1", "", "", "", "", "", "", "", "", "")

            ElseIf HLPNA = "Const_AccCode;8" Or HLPNA = "Const_AccCode;2" Then
                ds = PrcDS("USP_HLP7501A_ACCOUNTCODE_CHECK", cn, txt_Name.Data, "", "", "1", "", "", "", "", "", "", "", "")

            Else
                ds = PrcDS("USP_HLP7501A_ACCOUNTCODE_CHECK", cn, txt_Name.Data, "", "", "", "", "", "", "", "", "", "", "")

            End If

            If ds.Tables(0).Rows.Count = 0 Then
                Exit Function
            End If
            VS1.Sheets(0).RowCount = ds.Tables(0).Rows.Count

            For i = 0 To ds.Tables(0).Rows.Count - 1
                VS1.Sheets(0).Cells(i, 0).Value = ds.Tables(0).Rows(i).Item(0)
                VS1.Sheets(0).Cells(i, 1).Value = ds.Tables(0).Rows(i).Item(1)
            Next

            DATA_SEARCH01 = True
            VS1.Sheets(0).Visible = True
            SPR_END(VS1)
            cmd_OK.Enabled = True

            Me.Show()
            Application.DoEvents()
            VS1.Focus()
        Catch ex As Exception

            Call MsgBoxP("DATA_SEARCH01", vbCritical)
        End Try
    End Function
#End Region

#Region "Events"
    Private Sub SelectLabelSearch1_Load(sender As Object, e As KeyEventArgs) Handles txt_Name.txtTextKeyDown
        If e.KeyCode = Keys.Enter Then DATA_SEARCH01()
    End Sub
    Private Sub cmd_CANCEL_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        hlp0000SeVa = ""
        hlp0000SeVaTt = ""
        Me.close()
    End Sub

    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        Call DATA_SEARCH01()
    End Sub


    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        If getData(VS1, 1, VS1.ActiveSheet.ActiveRowIndex) Is Nothing Then
            MsgBoxP("NO VALUE !")
            Exit Sub
        Else
            hlp0000SeVaTt = getData(VS1, 0, VS1.ActiveSheet.ActiveRowIndex)
            hlp0000SeVa = hlp0000SeVaTt & "-" & getData(VS1, 1, VS1.ActiveSheet.ActiveRowIndex)

        End If
        Me.close()
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
            hlp0000SeVaTt = getData(VS1, 0, VS1.ActiveSheet.ActiveRowIndex)
            hlp0000SeVa = hlp0000SeVaTt & "-" & getData(VS1, 1, VS1.ActiveSheet.ActiveRowIndex)
        End If
        Me.close()
    End Sub

    Private Sub VS1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles VS1.KeyPress
        Select Case e.KeyChar
            Case ChrW(Keys.Enter) : cmd_OK.PerformClick()
            Case ChrW(Keys.Escape) : cmd_Cancel.PerformClick()
        End Select
    End Sub
#End Region

End Class