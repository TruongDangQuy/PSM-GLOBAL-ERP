Public Class FPassWord_Change

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
            txt_ID.Select()

            Link_PassWord = isudCHK


        Catch ex As Exception
            Call MsgBoxP("Link_PassWord")
        End Try
    End Function
#End Region

#Region "Events"
    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        SQL = " SELECT * FROM PFK9992 "
        SQL = SQL & " WHERE K9992_SITE = '" & Pub.SITE & "' "
        SQL = SQL & "   AND K9992_ID = '" & FormatSQL(txt_ID.Text) & "' "
        SQL = SQL & "   AND K9992_PW = '" & FormatSQL(txt_OldPW.Text) & "' "
        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = False Then
            rd.Close()
            Call MsgBoxP("Worng Pass!")
            txt_OldPW.Focus()
            Exit Sub
        End If
        rd.Close()

        If txt_NewPW1.Text <> txt_NewPW2.Text Then
            Call MsgBoxP("New Pass is wrong! No Same")
            Exit Sub
        End If

        SQL = " UPDATE PFK9992 "
        SQL = SQL & "   SET K9992_PW = '" & FormatSQL(txt_NewPW1.Text) & "' "
        SQL = SQL & " WHERE K9992_SITE = '" & Pub.SITE & "' "
        SQL = SQL & "   AND K9992_ID = '" & FormatSQL(txt_ID.Text) & "' "

        cmd = New SqlClient.SqlCommand(SQL, cn)
        cmd.ExecuteNonQuery()
        Call MsgBoxP("Upload Successfully!")

        isudCHK = True
        Me.Dispose()
    End Sub

    Private Sub cmd_Cancel_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        txt_NewPW1.Text = ""
        isudCHK = True
        Me.Dispose()
    End Sub

    Private Sub PASSWORDFORM_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Application.DoEvents()
        Me.Show()
        txt_ID.Select()
        txt_ID.Focus()
        txt_ID.BackColor = Color.White
    End Sub

    Private Sub TXT_PASSWORD_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_NewPW1.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            cmd_OK_Click(sender, e)
        End If
    End Sub
#End Region

End Class