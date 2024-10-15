Public Class HLP7411A

#Region "Variable"
    Public W1_Head As Integer

    Private W7411 As T7411_AREA
#End Region

#Region "Form_Load"
    Public Function Link_HLP7411A(Name As String) As Boolean
        W7411.Name = Name
        txt_Name.Data = Name
        hlpCHK = False

        Me.ShowDialog()

        Link_HLP7411A = hlpCHK
    End Function

    Public Overridable Sub HLP0001_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hlp0000SeVaTt = ""
        hlp0000SeVa = ""

        Me.Show()
        Application.DoEvents()
        Setfocus(txt_Name)
    End Sub
#End Region

#Region "Methods"
    Public Function DATA_SEARCH01(Head_No As Long) As Boolean
        DATA_SEARCH01 = False
        hlp0000SeVaTt = ""
        hlp0000SeVa = ""

        Try

            DS1 = PrcDS("USP_HLP7411A_SEARCH_VS1_MinhDuy", cn, "*" & txt_Name.Data.Trim())

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs1, DS1, "USP_HLP7411A_SEARCH_VS1_MinhDuy", "Vs1")
                Vs1.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(Vs1, DS1, "USP_HLP7411A_SEARCH_VS1_MinhDuy", "Vs1")
            DATA_SEARCH01 = True

            Me.Show()
            Application.DoEvents()
            Vs1.Focus()

        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Function
#End Region

#Region "Events"
    Private Sub cmd_CANCEL_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        Me.Close()
    End Sub

    Private Sub SelectLabelSearch1_KeyDown(sender As Object, e As KeyPressEventArgs) Handles txt_Name.txtTextKeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            cmd_SEARCH.PerformClick()
        End If
    End Sub

    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        DATA_SEARCH01(W1_Head)
    End Sub

    Public Overridable Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        If getData(Vs1, getColumIndex(Vs1, "KEY_IDNO"), Vs1.ActiveSheet.ActiveRowIndex) Is Nothing Then
            MsgBoxP("NO VALUE !")
            hlpCHK = False
            Exit Sub
        Else
            hlp0000SeVaTt = getData(Vs1, getColumIndex(Vs1, "KEY_IDNO"), Vs1.ActiveSheet.ActiveRowIndex)
            hlp0000SeVa = getData(Vs1, getColumIndex(Vs1, "Name"), Vs1.ActiveSheet.ActiveRowIndex)
            hlpCHK = True
        End If
        Me.Close()
    End Sub

    Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellClick
        If e.Row < 0 Then Exit Sub
        Vs1.ActiveSheet.ActiveRowIndex = e.Row
        Vs1.ActiveSheet.ActiveColumnIndex = e.Column
    End Sub

    Private Sub Vs1_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellDoubleClick
        If getData(Vs1, getColumIndex(Vs1, "KEY_IDNO"), Vs1.ActiveSheet.ActiveRowIndex) Is Nothing Then
            MsgBoxP("NO VALUE !")
            hlpCHK = False
            Exit Sub
        Else
            hlp0000SeVaTt = getData(Vs1, getColumIndex(Vs1, "KEY_IDNO"), Vs1.ActiveSheet.ActiveRowIndex)
            hlp0000SeVa = getData(Vs1, getColumIndex(Vs1, "Name"), Vs1.ActiveSheet.ActiveRowIndex)
            hlpCHK = True
        End If
        Me.Close()
    End Sub

    Private Sub Vs1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Vs1.KeyPress
        Select Case e.KeyChar
            Case ChrW(Keys.Enter), ChrW(Keys.Escape) : cmd_OK.PerformClick()

        End Select
    End Sub

    Private Sub cmd_Cancel_Click_1(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        hlp0000SeVa = ""
        hlp0000SeVaTt = ""
        hlpCHK = False
        Me.Close()
    End Sub
#End Region

End Class