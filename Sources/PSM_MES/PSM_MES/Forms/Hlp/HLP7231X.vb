Public Class HLP7231X

#Region "Variable"
    Public W1_Head As Integer
#End Region

#Region "Form_Load"
    Public Function Link_HLP7231X(BasicName As String) As Boolean
        txt_Name.Data = BasicName
        hlpCHK = False

        Me.ShowDialog()

        Link_HLP7231X = hlpCHK
    End Function

    Public Overridable Sub HLP0001_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call DATA_SEARCH01(W1_Head)
    End Sub
#End Region

#Region "Methods"
    Public Function DATA_SEARCH01(Head_No As Long) As Boolean
        DATA_SEARCH01 = False

        Try
            DS1 = PrcDS("USP_HLP7231A_SEARCH_VS1", cn, txt_cdLargeGroupMaterial.Code, "*" & txt_Name.Data, txt_cdSemiGroupMaterial.Data, txt_cdDetailGroupMaterial.Data)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs1, DS1, "USP_HLP7231A_SEARCH_VS1", "Vs1")
                Vs1.ActiveSheet.RowCount = 0
                Vs1.Enabled = True
                Exit Function
            End If
            SPR_PRO_NEW(Vs1, DS1, "USP_HLP7231A_SEARCH_VS1", "Vs1")

            Me.Show()
            Application.DoEvents()
            Vs1.Focus()

        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Function
#End Region

#Region "Events"
    Private Sub HLP7231X_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        If getData(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex) Is Nothing Then
            MsgBoxP("NO VALUE !")
        Else
            hlp0000SeVaTt = getData(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex)
            hlp0000SeVa = getData(Vs1, 1, Vs1.ActiveSheet.ActiveRowIndex)
        End If
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
        If getData(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex) Is Nothing Then
            hlpCHK = False
            MsgBoxP("NO VALUE !")
            Exit Sub
        Else
            hlpCHK = True
            hlp0000SeVaTt = getData(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex)
            hlp0000SeVa = getData(Vs1, 1, Vs1.ActiveSheet.ActiveRowIndex)
            hlp0000SeVaTt1 = getData(Vs1, 8, Vs1.ActiveSheet.ActiveRowIndex)
        End If
        Me.Close()
    End Sub

    Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs)
        If e.Row < 0 Then Exit Sub
        Vs1.ActiveSheet.ActiveRowIndex = e.Row
        Vs1.ActiveSheet.ActiveColumnIndex = e.Column
    End Sub

    Private Sub Vs1_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellDoubleClick
        If getData(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex) Is Nothing Then
            hlpCHK = False
            MsgBoxP("NO VALUE !")
            Exit Sub
        Else
            hlpCHK = True
            hlp0000SeVaTt = getData(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex)
            hlp0000SeVa = getData(Vs1, 1, Vs1.ActiveSheet.ActiveRowIndex)
        End If
        Me.Close()
    End Sub

    Private Sub cmd_Cancel_Click_1(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        hlpCHK = False
        hlp0000SeVaTt = ""
        hlp0000SeVa = ""
        hlp0000SeVaTt1 = ""
        Me.Close()
    End Sub

    Private Sub Vs1_KeyDown(sender As Object, e As KeyEventArgs) Handles Vs1.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmd_OK.PerformClick()
        End If
    End Sub

    Private Sub txt_Add_Click(sender As Object, e As EventArgs) Handles txt_Add.Click
        If ISUD7231A.Link_ISUD7231A(1, getData(Vs1, getColumIndex(Vs1, "Key_MaterialCode"), Vs1.ActiveSheet.ActiveRowIndex), "PFP70231") = False Then Exit Sub

        Call DATA_SEARCH01(W1_Head)

    End Sub
#End Region

End Class