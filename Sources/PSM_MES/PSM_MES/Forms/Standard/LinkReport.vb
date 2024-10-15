Imports System.IO
Imports System.Net


Public Class LinkReport
    Private formA As Boolean

    Private checkisud As Boolean
    Private Form_T As New Form

    Private CHK(0 To 5) As String

    Public Function Link_LinkReport(job As Integer, PROG As String, Optional ByRef FORM As Form = Nothing) As Boolean
        Dim i As Integer
        LinkReportName = ""
        Link_LinkReport = False

        Form_T = New Form
        Form_T = FORM

        cmb_LinkReport.Items.Clear()
        If PROG.Split(",").Length = 0 Then Exit Function

        For i = 0 To PROG.Split(",").Length - 1
            cmb_LinkReport.Items.Add(PROG.Split(",")(i))
        Next

        cmb_LinkReport.SelectedIndex = 0
        Me.ShowDialog()

        Link_LinkReport = isudCHK

    End Function



    Private Sub LinkReport_Load(sender As Object, e As EventArgs) Handles Me.Load
        If cmb_LinkReport.Items.Count = 1 Then
            cmd_OK.PerformClick()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        isudCHK = False
        Me.Dispose()
    End Sub

    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        If cmb_LinkReport.Text = "" Then
            isudCHK = False
        Else
            LinkReportName = cmb_LinkReport.Text
            isudCHK = True
        End If
        Me.Dispose()
    End Sub



    Private Sub cmb_LinkReport_KeyDown(sender As Object, e As KeyEventArgs) Handles cmb_LinkReport.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmd_OK.PerformClick()
        End If
    End Sub
End Class