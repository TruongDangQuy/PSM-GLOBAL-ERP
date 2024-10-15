Public Class HLP7262A

#Region "Variable"

    Protected prg As E_PRG
    Private Dsu01 As Long
    Private Dsu02 As Long
    Private Dsu03 As Long

    Private a7104() As T7104_AREA
    Private b7104() As T7104_AREA
    Private L7104 As T7104_AREA
    Private w7101 As T7101_AREA

    Private w7262 As T7262_AREA

    Private Form_Close As Boolean
    Private CheckMaterialType As String

#End Region

#Region "Formload"

    Friend Function Link_HLP7262A(MaterialCode As String, Optional _CheckMaterialType As String = "2") As Boolean
        hlp0000SeVa = ""
        hlp0000SeVaTt = ""
        hlp0000SeVaTt1 = ""

        Link_HLP7262A = False

        If READ_PFK7231(MaterialCode) = True Then
            txt_MaterialCode.Code = D7231.MaterialCode
            txt_MaterialCode.Data = D7231.MaterialName
        End If

        CheckMaterialType = _CheckMaterialType

        Try
            Me.ShowDialog()

            Link_HLP7262A = isudCHK

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("Link_HLP7262A"))
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
            If Trim$(txt_MaterialCode.Code) <> "" Then
                DATA_SEARCH_VS1()
            End If
        Catch ex As Exception
            MsgBoxP("DATA_INIT")
        End Try
    End Sub

#End Region

#Region "PFP_SEARCH"
    Private Function DATA_SEARCH_VS1() As Boolean
        DATA_SEARCH_VS1 = False
        If txt_CustomerCode.Data = "" Then txt_CustomerCode.Code = ""

        Try
            ' HUNG CHANGE ALL FROM 2018/03/14

            DS1 = PrcDS("USP_HLP7262A_SEARCH_VS1_ALL", cn, txt_CustomerCode.Code, txt_MaterialCode.Code, chk_Rnd.CheckState, chk_Material.CheckState)
            If GetDsRc(DS1) = 0 Then
                Vs1.Enabled = True
                Vs1.ActiveSheet.RowCount = 0
                Exit Function
            End If

            SPR_PRO_NEW(Vs1, DS1, "USP_HLP7262A_SEARCH_VS1_ALL", "Vs1")

            Vs1.Enabled = True
            DATA_SEARCH_VS1 = True

        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_VS1")
        End Try

    End Function



#End Region

#Region "EVENT"
    Private Sub Vs1_CellClick1(sender As Object, e As CellClickEventArgs) Handles Vs1.CellClick
        If e.ColumnHeader = True Then Exit Sub
        Vs1.ActiveSheet.ActiveRowIndex = e.Row
        Vs1.ActiveSheet.ActiveColumnIndex = e.Column
    End Sub

    Private Sub Vs1_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellDoubleClick
        cmd_OK.PerformClick()
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

            If READ_PFK7263(getData(Vs1, getColumIndex(Vs1, "KEY_ContractID"), Vs1.ActiveSheet.ActiveRowIndex),
                            getData(Vs1, getColumIndex(Vs1, "KEY_ContracSeq"), Vs1.ActiveSheet.ActiveRowIndex)) Then
                isudCHK = True
            Else
                D7263_CLEAR()
            End If

            Me.Dispose()

        Catch ex As Exception
            MsgBoxP("cmd_OK_Click")
        End Try
    End Sub

    Private Sub cmd_Cancel_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        D7263_CLEAR()


        Me.Dispose()
    End Sub

    Private Sub txt_Add_Click(sender As Object, e As EventArgs) Handles txt_Add.Click
        w7262.CustomerCode = txt_CustomerCode.Code

        If txt_MaterialCode.Code <> "" Then
            If ISUD7262A.Link_ISUD7262A_MaterialCode(1, txt_CustomerCode.Code, txt_MaterialCode.Code, "PFP72620RnD") = False Then Exit Sub
            Call DATA_SEARCH_VS1()
        Else
            If ISUD7262A.Link_ISUD7262A(1, w7262.CustomerCode, "PFP72620RnD") = False Then Exit Sub
            Call DATA_SEARCH_VS1()
        End If

    End Sub
    Private Sub cmd_Update_Click(sender As Object, e As EventArgs) Handles cmd_Update.Click

        w7262.ContractID = getData(Vs1, getColumIndex(Vs1, "KEY_ContractID"), Vs1.ActiveSheet.ActiveRowIndex)
        w7262.CustomerCode = getData(Vs1, getColumIndex(Vs1, "KEY_CustomerCode"), Vs1.ActiveSheet.ActiveRowIndex)

        If ISUD7262A.Link_ISUD7262A_MaterialCode(3, w7262.ContractID, "", "PFP72620RnD") = False Then Exit Sub

        Call DATA_SEARCH_VS1()
    End Sub

#End Region

    Private Sub cmd_Copy_Click(sender As Object, e As EventArgs) Handles cmd_Copy.Click

        w7262.ContractID = getData(Vs1, getColumIndex(Vs1, "KEY_ContractID"), Vs1.ActiveSheet.ActiveRowIndex)
        w7262.CustomerCode = getData(Vs1, getColumIndex(Vs1, "KEY_CustomerCode"), Vs1.ActiveSheet.ActiveRowIndex)

        If ISUD7262A.Link_ISUD7262A_MaterialCode(5, w7262.ContractID, "", "PFP72620RnD") = False Then Exit Sub

        Call DATA_SEARCH_VS1()
    End Sub
End Class