Public Class HLP7105C

#Region "Variable"

    Protected prg As E_PRG
    Private Dsu01 As Long
    Private Dsu02 As Long
    Private Dsu03 As Long
    Private a7105() As T7105_AREA
    Private b7105() As T7105_AREA
    Private L7105 As T7105_AREA
    Private w7101 As T7101_AREA
    Private Form_Close As Boolean

#End Region

#Region "Formload"

    Friend Function Link_HLP7105C(Optional CustomerCode As String = "") As Boolean
        hlp0000SeVa = ""
        hlp0000SeVaTt = ""
        hlp0000SeVaTt1 = ""

        Link_HLP7105C = False

        If Trim$(CustomerCode) <> "" Then
            L7105.CustomerCode = CustomerCode
            If READ_PFK7101(L7105.CustomerCode) = True Then
                w7101 = D7101

                txt_CustomerCode.Code = w7101.CustomerCode
                txt_CustomerCode.Data = w7101.CustomerName

            End If
        End If

        Try
            Me.ShowDialog()

            Link_HLP7105C = isudCHK

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("Link_HLP7105C"))
        End Try


    End Function

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
        Try
            If Trim$(txt_CustomerCode.Code) <> "" Then
                DATA_SEARCH_VS1()
                DATA_SEARCH_VS2(txt_CustomerCode.Code)
            End If
        Catch ex As Exception

        End Try
    End Sub

#End Region

#Region "PFP_SEARCH"
    Private Function DATA_SEARCH_VS1() As Boolean
        DATA_SEARCH_VS1 = False
        If txt_CustomerCode.Data = "" Then txt_CustomerCode.Code = ""
        Vs2.Enabled = False
        Try
            DS1 = PrcDS("USP_HLP7105A_SEARCH_VS1", cn, txt_CustomerCode.Code)
            If GetDsRc(DS1) = 0 Then
                Vs1.Enabled = True
                Vs1.ActiveSheet.RowCount = 0
                Exit Function
            End If

            SPR_PRO_NEW(Vs1, DS1, "USP_HLP7105A_SEARCH_VS1", "Vs1")

            Vs1.Enabled = True
            DATA_SEARCH_VS1 = True

        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_VS1")
        End Try
    End Function

    Private Function DATA_SEARCH_VS2(CODE As String, Optional KNAME As String = Nothing) As Boolean
        Dim DSNEW As New DataSet
        DATA_SEARCH_VS2 = False
        Try
            DSNEW = PrcDS("USP_HLP7105A_SEARCH_VS2", cn, CODE)
            Vs2.Enabled = True
            If GetDsRc(DSNEW) = 0 Then
                Vs2.ActiveSheet.RowCount = 0
                Exit Function
            End If

            SPR_PRO_NEW(Vs2, DSNEW, "USP_HLP7105A_SEARCH_VS2", "Vs2")

            DATA_SEARCH_VS2 = True
            Vs2.Enabled = True
        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_VS2")
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
        If getData(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub
        Vs2.Enabled = False
        Dim CustomerCode As String
        Try

            CustomerCode = getData(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex)
            DATA_SEARCH_VS2(CustomerCode)
            Vs2.Enabled = True

        Catch ex As Exception
            MsgBoxP("Vs1_CellClick")
        End Try
    End Sub

    Private Sub Vs1_KeyUp(sender As Object, e As KeyEventArgs) Handles Vs1.KeyUp
        Select Case e.KeyCode
            Case Keys.Down, Keys.Up, Keys.PageDown, Keys.PageUp
        End Select
    End Sub

    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        Try
            DATA_SEARCH_VS1()
        Catch ex As Exception
            MsgBoxP("cmd_SEARCH_Click")
        End Try
    End Sub

    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Try

            If getData(Vs2, getColumIndex(Vs2, "KEY_SizeRangeTool"), Vs2.ActiveSheet.ActiveRowIndex) IsNot Nothing Then
                If getData(Vs2, getColumIndex(Vs2, "KEY_SizeRangeTool"), Vs2.ActiveSheet.ActiveRowIndex) <> "" Then
                    hlp0000SeVa = getData(Vs2, getColumIndex(Vs2, "SizeRangeToolName"), Vs2.ActiveSheet.ActiveRowIndex)
                    hlp0000SeVaTt = getData(Vs2, getColumIndex(Vs2, "KEY_SizeRangeTool"), Vs2.ActiveSheet.ActiveRowIndex)
                    hlp0000SeVaTt1 = getData(Vs2, getColumIndex(Vs2, "KEY_SizeRangeTool"), Vs2.ActiveSheet.ActiveRowIndex)
                End If
            Else
                hlp0000SeVa = ""
                hlp0000SeVaTt = ""
                hlp0000SeVaTt1 = ""
            End If
            Me.Dispose()

        Catch ex As Exception
            MsgBoxP("cmd_OK_Click")
        End Try
    End Sub

    Private Sub cmd_Cancel_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        hlp0000SeVa = ""
        hlp0000SeVaTt = ""
        hlp0000SeVaTt1 = ""
        Me.Dispose()
    End Sub
#End Region

End Class