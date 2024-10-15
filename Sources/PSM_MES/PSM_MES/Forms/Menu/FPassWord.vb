Public Class FPassWord

#Region "Variable"
    Private formA As Boolean

#End Region

#Region "Form_Load"

#End Region

#Region "Methods"
    Public Function Link_PassWord() As Boolean
        Link_PassWord = False
        Try
            formA = False

            Me.ShowDialog()
            TXT_PASSWORD.Select()

            Link_PassWord = isudCHK


        Catch ex As Exception
            Call MsgBoxP("Link_PassWord")
        End Try
    End Function
#End Region

#Region "Events"
    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        PASSWORDCHECK = Trim(TXT_PASSWORD.Text)
        TXT_PASSWORD.Text = ""
        isudCHK = True
        Me.Dispose()
    End Sub

    Private Sub cmd_Cancel_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        TXT_PASSWORD.Text = ""
        isudCHK = True
        Me.Dispose()
    End Sub

    Private Sub PASSWORDFORM_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Application.DoEvents()
        Me.Show()
        TXT_PASSWORD.Select()
        TXT_PASSWORD.Focus()
        TXT_PASSWORD.BackColor = Color.White
    End Sub

    Private Sub TXT_PASSWORD_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_PASSWORD.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            cmd_OK_Click(sender, e)
        End If
    End Sub
#End Region

    
   

End Class