Public Class HLP7121A

#Region "Variable"
    Private Dsu01 As Long
    Private W1_Head As Integer = 2
    Private wGCHK As String

    Private W7121 As T7121_AREA
    Private vschkbx As New FarPoint.Win.Spread.CellType.CheckBoxCellType
    Private WCHK As String
#End Region

#Region "Form_Load"
    Public Function Link_HLP7121A(Optional Value As String = "") As Boolean
        If Value = "1" Then Value = ""

        txt_Name.Data = Value

        Me.ShowDialog()

        Link_HLP7121A = hlpCHK

        If hlpCHK = False Then Call D7109_CLEAR()

    End Function

    Private Sub HLP7121A_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hlp0000SeVa = ""
        hlp0000SeVaTt = ""
        hlp0000SeVaTt1 = ""

        If txt_Name.Data = "" Then Setfocus(txt_Name) Else Call DATA_SEARCH01()

    End Sub
#End Region

#Region "Methods"
    Public Overridable Function DATA_SEARCH01() As Boolean
        DATA_SEARCH01 = False

        Try
            DS1 = PrcDS("USP_HLP7121A_SEARCH_vS1", cn, txt_cdColorBase.Code, txt_Name.Data)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(VS1, DS1, "USP_HLP7121A_SEARCH_vS1", "Vs1")
                VS1.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(VS1, DS1, "USP_HLP7121A_SEARCH_vS1", "Vs1")
            DATA_SEARCH01 = True

            Me.Show()
            Application.DoEvents()
            VS1.Focus()
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
        hlp0000SeVaTt1 = ""
        hlpCHK = False
        D7121_CLEAR()
        Me.close()
    End Sub

    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        DATA_SEARCH01()
    End Sub


    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        If getData(VS1, getColumIndex(VS1, "KEY_ColorCode"), VS1.ActiveSheet.ActiveRowIndex) Is Nothing Then
            MsgBoxP("NO VALUE !")
            D7121_CLEAR()
            Exit Sub
        Else
            hlp0000SeVaTt = getData(VS1, getColumIndex(VS1, "KEY_ColorCode"), VS1.ActiveSheet.ActiveRowIndex)
            hlp0000SeVaTt1 = getData(VS1, getColumIndex(VS1, "KEY_ColorCode"), VS1.ActiveSheet.ActiveRowIndex)
            hlp0000SeVa = getData(VS1, getColumIndex(VS1, "ColorName"), VS1.ActiveSheet.ActiveRowIndex)

            Call READ_PFK7121(hlp0000SeVaTt)
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
        If getData(VS1, getColumIndex(VS1, "KEY_ColorCode"), VS1.ActiveSheet.ActiveRowIndex) Is Nothing Then
            MsgBoxP("NO VALUE !")
            D7121_CLEAR()
            Exit Sub
        Else
            hlp0000SeVaTt = getData(VS1, getColumIndex(VS1, "KEY_ColorCode"), VS1.ActiveSheet.ActiveRowIndex)
            hlp0000SeVaTt1 = getData(VS1, getColumIndex(VS1, "KEY_ColorCode"), VS1.ActiveSheet.ActiveRowIndex)
            hlp0000SeVa = getData(VS1, getColumIndex(VS1, "ColorName"), VS1.ActiveSheet.ActiveRowIndex)

            Call READ_PFK7121(hlp0000SeVaTt)
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
        If ISUD7121A.Link_ISUD7121A(1, "000000", "PFP71210") = False Then Exit Sub
        Call DATA_SEARCH01()
    End Sub
#End Region

End Class