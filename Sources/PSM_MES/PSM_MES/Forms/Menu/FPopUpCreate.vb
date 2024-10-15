Public Class FPopUpCreate

#Region "Variable"
    Private aMessage As String

    Private formA As Boolean
    Private isudCHK As Boolean

    Private strxFormName As String

#End Region

#Region "Form_Load"

#End Region

#Region "Methods"
    Public Function Link_FPopUpCreate(xFormName As String) As Boolean
        Link_FPopUpCreate = False
        Try
            formA = False
            strxFormName = xFormName

            If READ_PFK9950_ProgramNo(xFormName) Then
                txt_Message.Text = D9950.Content
            End If

            Me.ShowDialog()

            Link_FPopUpCreate = isudCHK

        Catch ex As Exception
            Call MsgBoxP("Link_FPopUpCreate")
        End Try
    End Function
#End Region

#Region "Events"


    Private Sub cmd_CLOSE_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        isudCHK = False
        If READ_PFK9950_ProgramNo(strxFormName) Then
            D9950.Content = txt_Message.Text

            Call REWRITE_PFK9950(D9950)
        End If

        Me.Dispose()
    End Sub

    Private Sub cmd_New_Click(sender As Object, e As EventArgs) Handles cmd_New.Click
        D9950.Content = txt_Message.Text
        D9950.ProgramNo = strxFormName


        Call WRITE_PFK9950(D9950)

        Me.Dispose()

    End Sub

#End Region





   
End Class