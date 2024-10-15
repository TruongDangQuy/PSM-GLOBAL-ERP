Imports System.IO
Imports System.Net


Public Class ISUD7106E
    Private formA As Boolean

    Private checkisud As Boolean
    Private Form_T As New Form

    Private CHK(0 To 5) As String
    Private cdSubProcess As String

    Public Function Link_ISUD7106E(job As Integer, ByRef _cdSubProcess As String) As Boolean
        Link_ISUD7106E = False

        cdSubProcess = ""
        Me.ShowDialog()

        _cdSubProcess = cdSubProcess
        Link_ISUD7106E = isudCHK
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        isudCHK = False
        Me.Dispose()
    End Sub

    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        cdSubProcess = txt_cdLineProd.Code
        cdSubProcess = FormatCut(cdSubProcess)

        If READ_PFK7101(cdSubProcess) = True Then
            isudCHK = True
        End If

        Me.Dispose()

    End Sub


End Class