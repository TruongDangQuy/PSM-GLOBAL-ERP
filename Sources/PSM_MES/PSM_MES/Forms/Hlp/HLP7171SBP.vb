Public Class HLP7171SBP

#Region "Variable"
    Private Dsu01 As Long
    Private W1_Head As Integer = 2
    Private wGCHK As String
#End Region

#Region "Form_Load"
    Private Sub HLP0000_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hlp0000SeVa = ""
        hlp0000SeVaTt = ""
        SPR_CLEAR(VS1)
        SPR_SET(VS1, , , , OperationMode.SingleSelect, True)
        If DATA_SEARCH01() = False Then
            Exit Sub
        End If

    End Sub
#End Region

#Region "Methods"
    Public Overridable Function DATA_SEARCH01() As Boolean
        DATA_SEARCH01 = False
        VS1.Sheets(0).RowCount = 0

        Try
            If SELCON(HLPNA).ToUpper = "BTN_PONO" Then
                DS1 = PrcDS("USP_HLP7171A_SEARCH_PONO", cn, txt_Name.Data)

                If GetDsRc(DS1) = 0 Then
                    SPR_SET(VS1, , , , OperationMode.SingleSelect)
                    SPR_PRO(VS1, DS1, "USP_HLP7171A_SEARCH_PONO", "Vs1")
                    Exit Function
                End If
                SPR_SET(VS1, , , , OperationMode.SingleSelect)
                SPR_PRO(VS1, DS1, "USP_HLP7171A_SEARCH_PONO", "Vs1")

                DATA_SEARCH01 = True

            ElseIf SELCON(HLPNA).ToUpper = "BTN_STYLE" Then
                DS1 = PrcDS("USP_HLP7171A_SEARCH_STYLE", cn, txt_Name.Data)

                If GetDsRc(DS1) = 0 Then
                    SPR_SET(VS1, , , , OperationMode.SingleSelect)
                    SPR_PRO(VS1, DS1, "USP_HLP7171A_SEARCH_STYLE", "Vs1")
                    Exit Function
                End If
                SPR_SET(VS1, , , , OperationMode.SingleSelect)
                SPR_PRO(VS1, DS1, "USP_HLP7171A_SEARCH_STYLE", "Vs1")

                DATA_SEARCH01 = True

            ElseIf SELCON(HLPNA).ToUpper = "BTN_BUYER" Then
                DS1 = PrcDS("USP_HLP7171A_SEARCH_BUYER", cn, txt_Name.Data)

                If GetDsRc(DS1) = 0 Then
                    SPR_SET(VS1, , , , OperationMode.SingleSelect)
                    SPR_PRO(VS1, DS1, "USP_HLP7171A_SEARCH_BUYER", "Vs1")
                    Exit Function
                End If
                SPR_SET(VS1, , , , OperationMode.SingleSelect)
                SPR_PRO(VS1, DS1, "USP_HLP7171A_SEARCH_BUYER", "Vs1")

                DATA_SEARCH01 = True
            End If
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
        Me.close()
    End Sub

    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        DATA_SEARCH01()
    End Sub


    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        If getData(VS1, 0, VS1.ActiveSheet.ActiveRowIndex) Is Nothing Then
            MsgBoxP("NO VALUE !")
            Exit Sub
        Else
            hlp0000SeVa = getData(VS1, 0, VS1.ActiveSheet.ActiveRowIndex)
            hlp0000SeVaTt = getData(VS1, 0, VS1.ActiveSheet.ActiveRowIndex)
        End If
        Me.close()
    End Sub


    Private Sub VS1_CellClick(sender As Object, e As CellClickEventArgs) Handles VS1.CellClick
        If e.Row < 0 Then Exit Sub
        VS1.ActiveSheet.ActiveRowIndex = e.Row
        VS1.ActiveSheet.ActiveColumnIndex = e.Column
    End Sub

    Private Sub VS1_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles VS1.CellDoubleClick
        If getData(VS1, 0, VS1.ActiveSheet.ActiveRowIndex) Is Nothing Then
            MsgBoxP("NO VALUE !")
            Exit Sub
        Else
            hlp0000SeVa = getData(VS1, 0, VS1.ActiveSheet.ActiveRowIndex)
            hlp0000SeVaTt = getData(VS1, 0, VS1.ActiveSheet.ActiveRowIndex)
        End If
        Me.close()
    End Sub

    Private Sub VS1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles VS1.KeyPress
        Select Case e.KeyChar
            Case ChrW(Keys.Enter) : cmd_OK.PerformClick()
            Case ChrW(Keys.Escape) : cmd_Cancel.PerformClick()
        End Select
    End Sub
#End Region

End Class