Public Class HLP7141B

#Region "Variable"
    Public W1_Head As Integer
#End Region

#Region "Form_Load"
    Public Overridable Sub HLP0001_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hlp0000SeVaTt = ""
        hlp0000SeVa = ""
        DATA_SEARCH01(W1_Head)
    End Sub
#End Region

#Region "Methods"
    Public Function DATA_SEARCH01(Head_No As Long) As Boolean
        DATA_SEARCH01 = False

        Try


            DS1 = PrcDS("USP_HLP7141A_SEARCH_VS1", cn, txt_Name.Data, Const_cdYarnStructure, Const_cdRawMaterial, _
                                                            rad_CheckTwist1.CheckState, rad_CheckTwist2.CheckState,
                                                          rad_CheckUseKnitting1.CheckState, rad_CheckUseKnitting2.CheckState, _
                                                          rad_CheckUseWeaving1.CheckState, rad_CheckUseWeaving2.CheckState)
            If GetDsRc(DS1) = 0 Then
                SPR_SET(Vs1, , , , OperationMode.Normal)
                SPR_PRO(Vs1, DS1, "USP_HLP7141A_SEARCH_VS1", "Vs1")
                Vs1.ActiveSheet.RowCount = 10
                Vs1.Enabled = True
                Exit Function
            End If
            SPR_SET(Vs1, 2, , , OperationMode.SingleSelect)
            SPR_PRO(Vs1, DS1, "USP_HLP7141A_SEARCH_VS1", "Vs1")
            Me.Show()
            Application.DoEvents()
            Vs1.Focus()
        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Function
#End Region

#Region "Events"
    Private Sub SelectLabelSearch1_Load(sender As Object, e As KeyEventArgs) Handles txt_Name.txtTextKeyDown
        If e.KeyCode = Keys.Enter Then DATA_SEARCH01(W1_Head)
    End Sub

    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        DATA_SEARCH01(W1_Head)
    End Sub

    Public Overridable Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        If getData(Vs1, 1, Vs1.ActiveSheet.ActiveRowIndex) Is Nothing Then
            MsgBoxP("NO VALUE !")
            Exit Sub
        Else
            hlp0000SeVaTt = getData(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex)
            hlp0000SeVa = getData(Vs1, 1, Vs1.ActiveSheet.ActiveRowIndex)
        End If
        Me.Close()
    End Sub

    Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs)
        If e.Row < 0 Then Exit Sub
        Vs1.ActiveSheet.ActiveRowIndex = e.Row
        Vs1.ActiveSheet.ActiveColumnIndex = e.Column
    End Sub

    Private Sub Vs1_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellDoubleClick
        If getData(Vs1, 1, Vs1.ActiveSheet.ActiveRowIndex) Is Nothing Then
            MsgBoxP("NO VALUE !")
            Exit Sub
        Else
            hlp0000SeVaTt = getData(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex)
            hlp0000SeVa = getData(Vs1, 1, Vs1.ActiveSheet.ActiveRowIndex)
        End If
        Me.Close()
    End Sub
    Private Sub VS1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Vs1.KeyPress
        Select Case e.KeyChar
            Case ChrW(Keys.Enter), ChrW(Keys.Escape) : cmd_OK.PerformClick()

        End Select
    End Sub
#End Region

End Class