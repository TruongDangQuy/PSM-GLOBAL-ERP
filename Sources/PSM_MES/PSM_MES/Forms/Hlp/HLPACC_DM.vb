Public Class HLPACC_DM

#Region "Variable"
    Private Dsu01 As Long
    Private W1_Head As Integer = 2
    Private wGCHK As String

    Private Type As String
    Private Sort As String

    Private vschkbx As New FarPoint.Win.Spread.CellType.CheckBoxCellType
    Private WCHK As String
#End Region

#Region "Form_Load"
    Public Function Link_HLPACC_DM(_Type As String, _Data As String, _Sort As String) As Boolean

        txt_Name.Data = _Data
        Type = _Type
        Sort = _Sort

        Me.ShowDialog()

        Link_HLPACC_DM = hlpCHK
    End Function

    Private Sub HLPACC_DM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            DS1 = PrcDS("USP_GET_ACC_HLPSLK", cn, Type, "*" + txt_Name.Data, Sort)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(VS1, DS1, "USP_GET_ACC_HLPSLK", "Vs1")
                VS1.Enabled = True
                Exit Function
            End If
            SPR_PRO_NEW(VS1, DS1, "USP_GET_ACC_HLPSLK", "Vs1")
            DATA_SEARCH01 = True

            Me.Show()
            Application.DoEvents()
            VS1.Select()

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
        hlpCHK = False
        Me.Close()
    End Sub

    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        DATA_SEARCH01()
    End Sub

    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        If getData(VS1, getColumIndex(VS1, "Code"), VS1.ActiveSheet.ActiveRowIndex) Is Nothing Then
            MsgBoxP("NO VALUE !")
            hlpCHK = False
            Exit Sub
        Else
            hlp0000SeVa = getData(VS1, getColumIndex(VS1, "Name"), VS1.ActiveSheet.ActiveRowIndex)
            hlp0000SeVaTt = getData(VS1, getColumIndex(VS1, "Code"), VS1.ActiveSheet.ActiveRowIndex)
            hlpCHK = True
        End If
        Me.Close()
    End Sub

    Private Sub VS1_CellClick(sender As Object, e As CellClickEventArgs) Handles VS1.CellClick
        If e.Row < 0 Then Exit Sub
        VS1.ActiveSheet.ActiveRowIndex = e.Row
        VS1.ActiveSheet.ActiveColumnIndex = e.Column
    End Sub

    Private Sub VS1_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles VS1.CellDoubleClick
        If getData(VS1, getColumIndex(VS1, "Code"), VS1.ActiveSheet.ActiveRowIndex) Is Nothing Then
            MsgBoxP("NO VALUE !")
            hlpCHK = False
            Exit Sub
        Else
            hlp0000SeVa = getData(VS1, getColumIndex(VS1, "Name"), VS1.ActiveSheet.ActiveRowIndex)
            hlp0000SeVaTt = getData(VS1, getColumIndex(VS1, "Code"), VS1.ActiveSheet.ActiveRowIndex)
            hlpCHK = True
        End If
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