Public Class HLP7155A

#Region "Variable"
    Protected prg As E_PRG
    Private Form_Close As Boolean
    Private formA As Boolean

#End Region

#Region "Formload"
    Public Function Link_HLP7155A(MachineType As String, Optional ByVal TAG As String = "") As Boolean
        Link_HLP7155A = False
        Me.Tag = TAG
        txt_MachineType.Code = MachineType

        If READ_PFK7171(Const_MachineType, MachineType) = True Then
            txt_MachineType.Data = D7171.BasicName
            txt_MachineName.Enabled = False
        Else
            Exit Function
        End If

        Try
            formA = False

            Me.ShowDialog()
            Link_HLP7155A = isudCHK

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

    Private Sub PFP17811_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Call INTERRUPT_TOGGLE(e.KeyCode)
    End Sub



    Private Sub DATA_INIT()

    End Sub

#End Region

#Region "PFP_SEARCH"
    Private Function DATA_SEARCH01() As Boolean
        DATA_SEARCH01 = False

        If txt_MachineName.Data.Trim = "" Then txt_MachineName.Data = "" : txt_MachineName.Code = ""
        Vs1.Enabled = False

        DS1 = PrcDS("USP_HLP7155A_SEARCH_VS1", cn, txt_MachineType.Code, txt_MachineName.Data)
        If GetDsRc(DS1) = 0 Then
            Vs1.Enabled = True
            Vs1.ActiveSheet.RowCount = 0
            Exit Function
        End If
        SPR_SET(Vs1, , , , OperationMode.Normal)
        SPR_PRO(Vs1, DS1, "USP_HLP7155A_SEARCH_VS1", "Vs1")

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

    Private Sub VS1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Vs1.KeyPress
        Select Case e.KeyChar
            Case ChrW(Keys.Enter) : cmd_OK.PerformClick()
            Case ChrW(Keys.Escape) : cmd_Cancel.PerformClick()
        End Select
    End Sub
    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        If getData(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex) IsNot Nothing Then
            If getData(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex) <> "" Then
                hlp0000SeVa = getData(Vs1, getColumIndex(Vs1, "MachineName"), Vs1.ActiveSheet.ActiveRowIndex)
                hlp0000SeVaTt = getData(Vs1, getColumIndex(Vs1, "MachineCode"), Vs1.ActiveSheet.ActiveRowIndex)
                hlp0000SeVaTt1 = getData(Vs1, getColumIndex(Vs1, "MachineCode"), Vs1.ActiveSheet.ActiveRowIndex)
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

    Private Sub cmd_New_Click(sender As Object, e As EventArgs) Handles cmd_New.Click
        If ISUD7155A.Link_ISUD7155A(1, "000000", "PFP71550") = True Then
            DATA_SEARCH01()
        End If
    End Sub
#End Region

    
End Class