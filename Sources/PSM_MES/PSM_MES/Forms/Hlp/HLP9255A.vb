Public Class HLP9255A

#Region "Variable"
    Protected prg As E_PRG
    Private Dsu01 As Long     'Data Su
    Private Dsu02 As Long     'Data Su
    Private Dsu03 As Long     'Data Su
    Private a7171() As T7171_AREA
    Private b7171() As T7171_AREA
    Private Form_Close As Boolean
#End Region

#Region "Formload"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        hlp0000SeVa = ""
        hlp0000SeVaTt = ""
        hlp0000SeVaTt1 = ""
        Me.KeyPreview = True
        Call DATA_INIT()
    End Sub

    Private Sub Me_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Call INTERRUPT_TOGGLE(e.KeyCode)
    End Sub



    Private Sub DATA_INIT()

    End Sub

#End Region

#Region "PFP_SEARCH"
    Private Function DATA_SEARCH01() As Boolean
        DATA_SEARCH01 = False
        Dim Sdate As String

        Sdate = Strings.Left(System_Date_8, 6)

        If txt_MaterialName.Data = "" Then txt_MaterialName.Code = ""
        Vs1.Enabled = False

        DS1 = PrcDS("USP_HLP9255_SEARCH_VS1", cn, Sdate, "*" & txt_MaterialName.Data)

        If GetDsRc(DS1) = 0 Then
            SPR_SET(Vs1, , , , OperationMode.SingleSelect)
            SPR_PRO(Vs1, DS1, "USP_HLP9255_SEARCH_VS1", "Vs1")
            Vs1.Enabled = True
            Exit Function
        End If
        SPR_SET(Vs1, , , , OperationMode.SingleSelect)
        SPR_PRO(Vs1, DS1, "USP_HLP9255_SEARCH_VS1", "Vs1")

        SPR_END(Vs1)
        Vs1.Enabled = True
        DATA_SEARCH01 = True
    End Function


#End Region

#Region "EVENT"
    Private Sub txt_Name_txtTextKeyDown(sender As Object, e As KeyEventArgs) Handles txt_MaterialName.txtTextKeyDown
        If e.KeyCode = Keys.Enter Then
            Call DATA_SEARCH01()
        End If
    End Sub
    Private Sub Vs1_CellClick1(sender As Object, e As CellClickEventArgs) Handles Vs1.CellClick
        If e.ColumnHeader = True Then Exit Sub
        Vs1.ActiveSheet.ActiveRowIndex = e.Row
        Vs1.ActiveSheet.ActiveColumnIndex = e.Column
    End Sub

    Private Sub Vs1_KeyDown(sender As Object, e As KeyEventArgs) Handles Vs1.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmd_OK.PerformClick()
        End If
    End Sub
    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        If DATA_SEARCH01() = True Then

        End If
    End Sub

    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        If getData(Vs1, getColumIndex(Vs1, "MaterialCode"), Vs1.ActiveSheet.ActiveRowIndex) IsNot Nothing Then
            If getData(Vs1, getColumIndex(Vs1, "MaterialCode"), Vs1.ActiveSheet.ActiveRowIndex) <> "" Then
                hlp0000SeVa = getData(Vs1, getColumIndex(Vs1, "MaterialName"), Vs1.ActiveSheet.ActiveRowIndex)
                hlp0000SeVaTt = getData(Vs1, getColumIndex(Vs1, "MaterialCode"), Vs1.ActiveSheet.ActiveRowIndex)
            End If
        Else
            hlp0000SeVa = ""
            hlp0000SeVaTt = ""
        End If
        Me.Dispose()
    End Sub

    Private Sub cmd_Cancel_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        hlp0000SeVa = ""
        hlp0000SeVaTt = ""
        Me.Dispose()
    End Sub
    Private Sub Vs1_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellDoubleClick
        cmd_OK.PerformClick()
    End Sub
#End Region

 

End Class