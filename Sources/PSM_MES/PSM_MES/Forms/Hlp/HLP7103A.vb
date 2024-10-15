Public Class HLP7103A

#Region "Variable"
    Private Dsu01 As Long
    Private W1_Head As Integer = 2
    Private wGCHK As String

    Private W7103 As T7103_AREA
    Private vschkbx As New FarPoint.Win.Spread.CellType.CheckBoxCellType
    Private WCHK As String
#End Region

#Region "Form_Load"
    Public Function Link_HLP7103A(KSEL As String, Optional CHK1 As String = "") As Boolean

        W7103.cdTypeCode = KSEL


        If READ_PFK7171(ListCode("TypeCode"), KSEL) Then
            txt_cdTypeCode.Data = D7171.BasicName
            txt_cdTypeCode.Code = D7171.BasicCode
            txt_cdTypeCode.Enabled = True
        End If

        If CHK1 <> "" Then WCHK = CHK1

        Me.ShowDialog()

        Link_HLP7103A = hlpCHK

        If hlpCHK = False Then Call D7109_CLEAR()

    End Function

    Private Sub HLP7103A_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hlp0000SeVa = ""
        hlp0000SeVaTt = ""
        hlp0000SeVaTt1 = ""
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
            Dim SQL As String
            Dim cmd As SqlClient.SqlCommand
            Dim da As New SqlClient.SqlDataAdapter

            SQL = "SELECT [K7103_cdTypeCode],[K7103_TypeCode], [K7103_TypeName] FROM PFK7103"
            SQL = SQL + " WHERE [K7103_cdTypeCode]        = '" + txt_cdTypeCode.Code + "'"
            SQL = SQL + "   AND [K7103_TypeName] LIKE  N'%" + txt_TypeName.Data + "%'"
            'SQL = SQL + " AND K7103_CheckUse = '1' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            da.SelectCommand = cmd
            ds.Reset()
            da.Fill(ds)
            If ds.Tables(0).Rows.Count = 0 Then

                Exit Function
            End If
            VS1.Sheets(0).RowCount = ds.Tables(0).Rows.Count

            For i = 0 To ds.Tables(0).Rows.Count - 1
                VS1.Sheets(0).Cells(i, 0).Value = ds.Tables(0).Rows(i).Item(0)
                VS1.Sheets(0).Cells(i, 1).Value = ds.Tables(0).Rows(i).Item(1)
                VS1.Sheets(0).Cells(i, 2).Value = ds.Tables(0).Rows(i).Item(2)
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
    Private Sub SelectLabelSearch1_Load(sender As Object, e As KeyEventArgs) Handles txt_TypeName.txtTextKeyDown
        If e.KeyCode = Keys.Enter Then DATA_SEARCH01()
    End Sub
    Private Sub cmd_CANCEL_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        hlp0000SeVa = ""
        hlp0000SeVaTt = ""
        hlp0000SeVaTt1 = ""
        hlpCHK = False
        D7103_CLEAR()
        Me.close()
    End Sub

    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        DATA_SEARCH01()
    End Sub


    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        If getData(VS1, 0, VS1.ActiveSheet.ActiveRowIndex) Is Nothing Then
            MsgBoxP("NO VALUE !")
            D7103_CLEAR()
            Exit Sub
        Else
            hlp0000SeVaTt = getData(VS1, 0, VS1.ActiveSheet.ActiveRowIndex)
            hlp0000SeVaTt1 = getData(VS1, 1, VS1.ActiveSheet.ActiveRowIndex)
            hlp0000SeVa = getData(VS1, 2, VS1.ActiveSheet.ActiveRowIndex)

            Call READ_PFK7103_TYPECODE(W7103.cdTypeCode, hlp0000SeVaTt)
            hlpCHK = True
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
            D7103_CLEAR()
            Exit Sub
        Else
            hlp0000SeVaTt = getData(VS1, 0, VS1.ActiveSheet.ActiveRowIndex)
            hlp0000SeVaTt1 = getData(VS1, 1, VS1.ActiveSheet.ActiveRowIndex)
            hlp0000SeVa = getData(VS1, 2, VS1.ActiveSheet.ActiveRowIndex)
            Call READ_PFK7103_TYPECODE(W7103.cdTypeCode, hlp0000SeVaTt)
            hlpCHK = True
        End If
        Me.close()
    End Sub

    Private Sub VS1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles VS1.KeyPress
        Select Case e.KeyChar
            Case ChrW(Keys.Enter) : cmd_OK.PerformClick()
            Case ChrW(Keys.Escape) : cmd_Cancel.PerformClick()
        End Select
    End Sub

    Private Sub txt_Add_Click(sender As Object, e As EventArgs) Handles txt_Add.Click
        If ISUD7103A.Link_ISUD7103A(1, "0000", W7103.cdTypeCode, "000", "PFP71030") = False Then Exit Sub
        Call DATA_SEARCH01()
    End Sub
#End Region

    
End Class