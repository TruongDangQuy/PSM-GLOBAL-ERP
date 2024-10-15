Imports System.IO
Imports System.Net


Public Class ISUD7231U
    Private formA As Boolean

    Private checkisud As Boolean
    Private Form_T As New Form

    Private CHK(0 To 5) As String
    Private cdUnitMaterial As String

    Public Function Link_HLP7231C(job As Integer, ByRef _cdUnitMaterial As String) As Boolean
        Link_HLP7231C = False

        cdUnitMaterial = ""
        Me.ShowDialog()

        _cdUnitMaterial = cdUnitMaterial
        Link_HLP7231C = isudCHK
    End Function



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        isudCHK = False
        Me.Dispose()
    End Sub

    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        cdUnitMaterial = txt_cdUnitMaterial.Code
        cdUnitMaterial = FormatCut(cdUnitMaterial)

        If READ_PFK7171(ListCode("UnitMaterial"), cdUnitMaterial) Then
            isudCHK = True
        End If

        Me.Dispose()

    End Sub


End Class