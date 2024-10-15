Public Class FMessageBox

#Region "Variable"
    Private aMessage As String

    Private formA As Boolean
    Private isudCHK As Boolean
#End Region

#Region "Form_Load"

#End Region

#Region "Methods"
    Public Function Link_FMessageBox(xMessage As String) As Boolean
        Link_FMessageBox = False
        Try
            formA = False
            aMessage = xMessage

            txt_Message.Text = aMessage

            Me.ShowDialog()

            Link_FMessageBox = isudCHK

        Catch ex As Exception
            Call MsgBoxP("Link_FMessageBox")
        End Try
    End Function
#End Region

#Region "Events"

    Private Sub cmd_OK_Click(sender As Object, e As EventArgs)
        isudCHK = True

        Me.Dispose()
    End Sub

    Private Sub cmd_CLOSE_Click(sender As Object, e As EventArgs) Handles cmd_CLOSE.Click
        isudCHK = False

        Me.Dispose()
    End Sub

#End Region

    



End Class