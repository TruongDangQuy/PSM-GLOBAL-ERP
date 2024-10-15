Public Class HLP7156A

#Region "Variable"
    Private Dsu01 As Long
    Private W1_Head As Integer = 2
    Private wGCHK As String

    Private W7156 As T7156_AREA
    Private vschkbx As New FarPoint.Win.Spread.CellType.CheckBoxCellType
    Private WCHK As String
#End Region

#Region "Form_Load"
    Public Function Link_HLP7156A(KSEL As String, Optional CHK1 As String = "") As Boolean

        W7156.cdToolGroup = KSEL

        If READ_PFK7171(ListCode("ToolGroup"), KSEL) Then
            txt_cdToolGroup.Data = D7171.BasicName
            txt_cdToolGroup.Code = D7171.BasicCode
            txt_cdToolGroup.Enabled = False
        End If

        If CHK1 <> "" Then WCHK = CHK1

        Me.ShowDialog()

        Link_HLP7156A = hlpCHK

        If hlpCHK = False Then Call D7109_CLEAR()

    End Function

    Private Sub HLP7156A_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hlp0000SeVa = ""
        hlp0000SeVaTt = ""
        hlp0000SeVaTt1 = ""
        If DATA_SEARCH01() = False Then
            Exit Sub
        End If

    End Sub
#End Region

#Region "Methods"
    Public Overridable Function DATA_SEARCH01() As Boolean
        'Dim i As Integer

        DATA_SEARCH01 = False
        'VS1.Sheets(0).RowCount = 0

        Try
            VS1.Enabled = False

            DS1 = PrcDS("USP_HLP7156A_SEARCH_VS1", cn, txt_cdToolGroup.Code, txt_TypeName.Data, "")

            If GetDsRc(DS1) = 0 Then
                VS1.Enabled = True
                SPR_PRO_NEW(VS1, DS1, "USP_HLP7156A_SEARCH_VS1", "Vs1")
                Exit Function
            End If

            SPR_PRO_NEW(VS1, DS1, "USP_HLP7156A_SEARCH_VS1", "Vs1")

            VS1.Enabled = True
            DATA_SEARCH01 = True

            'Dim SQL As String
            'Dim cmd As SqlClient.SqlCommand
            'Dim da As New SqlClient.SqlDataAdapter


            'SQL = "SELECT [K7156_cdToolGroup],[K7156_ToolGroup], [K7156_TypeName] FROM PFK7156"
            'SQL = SQL + " WHERE [K7156_cdToolGroup]        = '" + txt_cdToolGroup.Code + "'"
            'SQL = SQL + "   AND [K7156_TypeName] LIKE  N'%" + txt_TypeName.Data + "%'"
            ''SQL = SQL + " AND K7156_CheckUse = '1' "

            'cmd = New SqlClient.SqlCommand(SQL, cn)
            'da.SelectCommand = cmd
            'ds.Reset()
            'da.Fill(ds)
            'If ds.Tables(0).Rows.Count = 0 Then

            '    Exit Function
            'End If
            'VS1.Sheets(0).RowCount = ds.Tables(0).Rows.Count

            'For i = 0 To ds.Tables(0).Rows.Count - 1
            '    VS1.Sheets(0).Cells(i, 0).Value = ds.Tables(0).Rows(i).Item(0)
            '    VS1.Sheets(0).Cells(i, 1).Value = ds.Tables(0).Rows(i).Item(1)
            '    VS1.Sheets(0).Cells(i, 2).Value = ds.Tables(0).Rows(i).Item(2)
            'Next

            'DATA_SEARCH01 = True
            'VS1.Sheets(0).Visible = True
            'SPR_END(VS1)
            'cmd_OK.Enabled = True

            'Me.Show()
            'Application.DoEvents()
            'VS1.Focus()
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
        D7156_CLEAR()
        Me.close()
    End Sub

    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        DATA_SEARCH01()
    End Sub


    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        If getData(VS1, getColumIndex(VS1, "Key_ToolCode"), VS1.ActiveSheet.ActiveRowIndex) Is Nothing Then
            MsgBoxP("NO VALUE !")
            D7156_CLEAR()
            Exit Sub
        Else
            hlp0000SeVaTt = getData(VS1, getColumIndex(VS1, "Key_ToolCode"), VS1.ActiveSheet.ActiveRowIndex)
            hlp0000SeVaTt1 = hlp0000SeVaTt
            hlp0000SeVa = hlp0000SeVa
            Call READ_PFK7156(hlp0000SeVaTt)
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
            D7156_CLEAR()
            Exit Sub
        Else
            hlp0000SeVaTt = getData(VS1, getColumIndex(VS1, "Key_ToolCode"), VS1.ActiveSheet.ActiveRowIndex)
            hlp0000SeVaTt1 = hlp0000SeVaTt
            hlp0000SeVa = hlp0000SeVa
            Call READ_PFK7156(hlp0000SeVaTt)
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
        If ISUD7156A.Link_ISUD7156A(1, txt_cdToolGroup.Code, "PFP71560") = False Then Exit Sub
        Call DATA_SEARCH01()
    End Sub
#End Region
 
End Class