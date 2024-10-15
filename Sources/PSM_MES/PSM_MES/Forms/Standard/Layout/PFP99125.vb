Public Class PFP99125

    Public Sub Link_OPENLAYOUT(FormName As String)

        Layout_GroupUser = ""
        Layout_FormName = ""

        Layout_FormName = FormName
        Me.ShowDialog()

    End Sub

    Private Sub OPENLAYOUT_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txt_FormName.Data = Layout_FormName
        txt_GroupUser.Data = Layout_GroupUser
    End Sub

    Private Sub OPENLAYOUT_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

    Private Sub cmd_OK_Click_1(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Layout_FormName = txt_FormName.Data
        Layout_GroupUser = txt_GroupUser.Data

        Me.Dispose()
    End Sub

End Class