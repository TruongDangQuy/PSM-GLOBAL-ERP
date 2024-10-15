Public Class HLP99011A
    Public Shared cdFactory As String = ""
    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        cdFactory = ""
        If chb_Factory1.Checked = True Then cdFactory += "001;"
        If chb_Factory2.Checked = True Then cdFactory += "002;"
        If chb_Factory3.Checked = True Then cdFactory += "003;"
        If chb_FactoryRnD.Checked = True Then cdFactory += "050;"
        If chb_FactoryOutsole.Checked = True Then cdFactory += "040;"
        hlp0000SeVa = cdFactory
        Me.Dispose()
    End Sub

    Private Sub cmd_Cancel_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        cdFactory = ""
        hlp0000SeVa = ""
        Me.Dispose()
    End Sub

End Class