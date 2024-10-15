Imports System.IO
Imports System.Net


Public Class ISUD4010C
    Private formA As Boolean

    Private checkisud As Boolean
    Private Form_T As New Form

    Private CHK(0 To 5) As String
    Private cdJobState As String

    Public Function Link_ISUD4010C(job As Integer, ByRef _cdJobState As String) As Boolean
        Link_ISUD4010C = False

        cdJobState = ""
        Me.ShowDialog()

        _cdJobState = cdJobState
        Link_ISUD4010C = isudCHK
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        isudCHK = False
        Me.Dispose()
    End Sub

    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        cdJobState = txt_cdJobState.Code
        cdJobState = FormatCut(cdJobState)

        If READ_PFK7171(ListCode("SpecState"), cdJobState) Then
            isudCHK = True
        End If

        Me.Dispose()

    End Sub


End Class