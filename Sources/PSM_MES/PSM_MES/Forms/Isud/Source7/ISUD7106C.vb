Imports System.IO
Imports System.Net


Public Class ISUD7106C
    Private formA As Boolean

    Private checkisud As Boolean
    Private Form_T As New Form

    Private CHK(0 To 5) As String
    Private cdSpecState As String

    Public Function Link_ISUD7106C(job As Integer, ByRef _cdSpecState As String) As Boolean
        Link_ISUD7106C = False

        cdSpecState = ""
        Me.ShowDialog()

        _cdSpecState = cdSpecState
        Link_ISUD7106C = isudCHK
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        isudCHK = False
        Me.Dispose()
    End Sub

    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        cdSpecState = txt_cdSpecState.Code
        cdSpecState = FormatCut(cdSpecState)

        If READ_PFK7171(ListCode("SpecState"), cdSpecState) Then
            isudCHK = True
        End If

        Me.Dispose()

    End Sub


End Class