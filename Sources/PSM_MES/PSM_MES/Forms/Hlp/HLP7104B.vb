Public Class HLP7104B

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
        If txt_cdProcessPrescription.Data = "" Then txt_cdProcessPrescription.Code = ""
        Vs1.Enabled = False

        DS1 = PrcDS("USP_HLP7104A_SEARCH_VS1", cn, "2", "1", txt_cdProcessPrescription.Code, Const_ProcessProduction)
        If GetDsRc(DS1) = 0 Then
            Vs1.Enabled = True
            Vs1.ActiveSheet.RowCount = 0
            Exit Function
        End If
        SPR_SET(Vs1, , , , OperationMode.SingleSelect)
        SPR_PRO(Vs1, DS1, "USP_HLP7104A_SEARCH_VS1", "Vs1")

        Vs1.Enabled = True
        DATA_SEARCH01 = True
    End Function

    Private Function DATA_SEARCH02(KSEL As String, Optional KNAME As String = Nothing) As Boolean
        Dim DSNEW As New DataSet

        DATA_SEARCH02 = False

        Try
            DSNEW = PrcDS("USP_HLP7104A_SEARCH_VS2", cn, KSEL, Const_UnitPrescription)

            If GetDsRc(DSNEW) = 0 Then
                Vs2.ActiveSheet.RowCount = 0
                Exit Function
            End If
            SPR_SET(Vs2, , , , OperationMode.Normal)
            SPR_PRO(Vs2, DSNEW, "USP_HLP7104A_SEARCH_VS2", "Vs2")
            Vs2.ActiveSheet.SetColumnMerge(-1, Model.MergePolicy.Always)
            DATA_SEARCH02 = True
        Catch ex As Exception

        End Try
    End Function

#End Region

#Region "EVENT"

    Private Sub Vs1_CellClick1(sender As Object, e As CellClickEventArgs) Handles Vs1.CellClick
        If e.ColumnHeader = True Then Exit Sub
        Vs1.ActiveSheet.ActiveRowIndex = e.Row
        Vs1.ActiveSheet.ActiveColumnIndex = e.Column
    End Sub
    Private Sub Vs2_CellClick1(sender As Object, e As CellClickEventArgs) Handles Vs2.CellClick
        If e.ColumnHeader = True Then Exit Sub
        Vs2.ActiveSheet.ActiveRowIndex = e.Row
        Vs2.ActiveSheet.ActiveColumnIndex = e.Column
    End Sub
    Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellDoubleClick
        If e.ColumnHeader = True Then Exit Sub
        If getData(Vs1, 1, Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub
        Vs1.Enabled = False
        Dim str As String
        str = getData(Vs1, 1, e.Row)
        DATA_SEARCH02(str)
        Vs1.Enabled = True
    End Sub

    Private Sub Vs1_KeyUp(sender As Object, e As KeyEventArgs) Handles Vs1.KeyUp
        Select Case e.KeyCode
            Case Keys.Down, Keys.Up, Keys.PageDown, Keys.PageUp
                Call vS1_Click(Vs1.ActiveSheet.ActiveColumnIndex, Vs1.ActiveSheet.ActiveRowIndex)
        End Select
    End Sub

    Private Sub vS1_Click(ByVal Col As Long, ByVal Row As Long)
        If Row < 0 Then Exit Sub
        If getData(Vs1, 12, Row) = "" Then Exit Sub
        Call DATA_SEARCH02(getData(Vs1, 0, Row), getData(Vs1, 1, Row))
    End Sub

    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        If DATA_SEARCH01() = True Then

        End If
    End Sub

    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        If getData(Vs2, 0, Vs2.ActiveSheet.ActiveRowIndex) IsNot Nothing Then
            If getData(Vs2, 0, Vs2.ActiveSheet.ActiveRowIndex) <> "" Then
                hlp0000SeVa = getData(Vs2, 1, Vs2.ActiveSheet.ActiveRowIndex)
                hlp0000SeVaTt = getData(Vs2, 0, Vs2.ActiveSheet.ActiveRowIndex)
                hlp0000SeVaTt1 = getData(Vs1, 2, Vs1.ActiveSheet.ActiveRowIndex)
            End If
        Else
            hlp0000SeVa = ""
            hlp0000SeVaTt = ""
            hlp0000SeVaTt1 = ""
        End If
        Me.Close()
    End Sub

    Private Sub cmd_Cancel_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        hlp0000SeVa = ""
        hlp0000SeVaTt = ""
        hlp0000SeVaTt1 = ""
        Me.Close()
    End Sub
#End Region

End Class