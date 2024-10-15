Public Class PFP99126

    Public Sub Link_SAVELAYOUT(FormName As String, GroupUser As String)

        Layout_Date = ""
        Layout_Version = ""
        Layout_Remark = ""
        Layout_FormName = ""
        Layout_GroupUser = GroupUser
        Layout_FormName = FormName
        Me.ShowDialog()

    End Sub

    Private Sub SAVELAYOUT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_Date.Data = System_Date_8()
        txt_FormName.Data = Layout_FormName
        txt_Remark.Data = ""
        txt_Version.Data = key_count()
    End Sub

    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Layout_Date = txt_Date.Data.Replace("/", "")
        Layout_Version = txt_Version.Data
        Layout_Remark = txt_Remark.Data
        Layout_FormName = txt_FormName.Data

        Me.Dispose()
    End Sub

    Private Sub SAVELAYOUT_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

    Private Function key_count() As String
        Dim SQL As String
        Dim rd As SqlClient.SqlDataReader

        SQL = "SELECT MAX(CAST(K9701_Version AS DECIMAL)) AS MAX_CODE FROM PFK9701 where K9701_FormName = '" & Layout_FormName & "' and  K9701_GroupUser = '" & Layout_GroupUser & "'"

        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_CODE) Then
            key_count = "1"
        Else
            key_count = CInt(rd!MAX_CODE + 1)
        End If
        rd.Close()
    End Function

End Class