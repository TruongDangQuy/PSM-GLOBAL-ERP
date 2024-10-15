Public Class HLP7173A

#Region "Variable"

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
        DATA_SEARCH01 = False
        Try
            VS1.Enabled = False

            DS1 = PrcDS("USP_HLP7173A_SEARCH_vS1", cn, "1121")

            If GetDsRc(DS1) = 0 Then
                SPR_SET(VS1, , , , OperationMode.SingleSelect)
                SPR_PRO(VS1, DS1, "USP_HLP7173A_SEARCH_vS1", "Vs1", False)
                VS1.Enabled = True
            Else
                SPR_SET(VS1, , , , OperationMode.SingleSelect)
                SPR_PRO(VS1, DS1, "USP_HLP7173A_SEARCH_vS1", "Vs1", False)
                DATA_SEARCH01 = True

                VS1.Enabled = True
            End If
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

        hlp0000SeVaTt = getData(VS1, getColumIndex(VS1, "AccountCode"), VS1.ActiveSheet.ActiveRowIndex)
        hlp0000SeVa = getData(VS1, getColumIndex(VS1, "AccountCode"), VS1.ActiveSheet.ActiveRowIndex)

        Me.Close()
    End Sub


    Private Sub VS1_CellClick(sender As Object, e As CellClickEventArgs) Handles VS1.CellClick
        If e.Row < 0 Then Exit Sub
        VS1.ActiveSheet.ActiveRowIndex = e.Row
        VS1.ActiveSheet.ActiveColumnIndex = e.Column
    End Sub

    Private Sub VS1_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles VS1.CellDoubleClick
        hlp0000SeVaTt = getData(VS1, getColumIndex(VS1, "AccountCode"), VS1.ActiveSheet.ActiveRowIndex)
        hlp0000SeVa = getData(VS1, getColumIndex(VS1, "AccountCode"), VS1.ActiveSheet.ActiveRowIndex)

        Me.Close()

    End Sub

    Private Sub VS1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles VS1.KeyPress
        Select Case e.KeyChar
            Case ChrW(Keys.Enter) : cmd_OK.PerformClick()
            Case ChrW(Keys.Escape) : cmd_Cancel.PerformClick()
        End Select
    End Sub
#End Region
    

    
    
End Class