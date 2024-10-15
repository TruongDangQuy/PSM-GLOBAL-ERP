Public Class HLP1311A


#Region "Variable"
    Protected prg As E_PRG
    Private Form_Close As Boolean
    Private formA As Boolean

#End Region

#Region "Formload"
    Public Function Link_HLP1311A(Optional ByVal TAG As String = "") As Boolean
        Link_HLP1311A = False
        Me.Tag = TAG
        Try
            formA = False

            Me.ShowDialog()
            Link_HLP1311A = isudCHK

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("YARN PROCESSING"))
        End Try
    End Function
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        hlp0000SeVa = ""
        hlp0000SeVaTt = ""
        hlp0000SeVaTt1 = ""
        Me.KeyPreview = True
        Call DATA_INIT()
        Call DATA_SEARCH01()
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

        If txt_OrderNo.Data.Trim = "" Then txt_OrderNo.Data = ""
        Vs1.Enabled = False

        DS1 = PrcDS("USP_HLP1311_SEARCH_VS1", cn, SdateEdate.text1, SdateEdate.text2, txt_OrderNo.Data)
        If GetDsRc(DS1) = 0 Then
            Vs1.Enabled = True
            Vs1.ActiveSheet.RowCount = 0
            Exit Function
        End If
        SPR_SET(Vs1, , , , OperationMode.Normal)
        SPR_PRO(Vs1, DS1, "USP_HLP1311_SEARCH_VS1", "Vs1")

        Vs1.Enabled = True
        DATA_SEARCH01 = True
    End Function


#End Region

#Region "EVENT"
    Private Sub Vs1_CellClick1(sender As Object, e As CellClickEventArgs) Handles Vs1.CellClick
        If e.ColumnHeader = True Then Exit Sub
        Vs1.ActiveSheet.ActiveRowIndex = e.Row
        Vs1.ActiveSheet.ActiveColumnIndex = e.Column
    End Sub

    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        If DATA_SEARCH01() = True Then

        End If
    End Sub

    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        If getData(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex) IsNot Nothing Then
            If getData(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex) <> "" Then
                hlp0000SeVa = getData(Vs1, getColumIndex(Vs1, "OrderNo"), Vs1.ActiveSheet.ActiveRowIndex)
                hlp0000SeVaTt = getData(Vs1, getColumIndex(Vs1, "Key_OrderNo"), Vs1.ActiveSheet.ActiveRowIndex)
                hlp0000SeVaTt1 = getData(Vs1, getColumIndex(Vs1, "Key_OrderNo"), Vs1.ActiveSheet.ActiveRowIndex)
                isudCHK = True
            End If
        Else
            isudCHK = False
            hlp0000SeVa = ""
            hlp0000SeVaTt = ""
            hlp0000SeVaTt1 = ""
        End If
        Me.Dispose()
    End Sub

    Private Sub cmd_Cancel_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        hlp0000SeVa = ""
        hlp0000SeVaTt = ""
        hlp0000SeVaTt1 = ""
        isudCHK = False
        Me.Dispose()
    End Sub

    Private Sub Vs1_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellDoubleClick
        cmd_OK.PerformClick()
    End Sub

#End Region

End Class