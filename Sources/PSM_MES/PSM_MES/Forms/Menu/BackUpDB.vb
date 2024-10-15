Imports System.IO
Imports System.Net

Public Class BackUpDB

#Region "Variable"
    Private blnEventAccess As Boolean = False

#End Region

#Region "Form_Load"
    Private Sub F_MAIN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            txt_FileName.Data = App_Path & "\"

        Catch ex As Exception


        End Try

    End Sub
#End Region

#Region "Methods"
    
    Private Function VersionChk() As Boolean

        txt_FileName.Text = ""

        Dim FileNumber As Integer = 0
        Dim ServerText As String = ""
        Dim ClientText As String = ""

        Try
            If System.IO.File.Exists(Application.StartupPath & "\serverversion.txt") = True Then
                My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\serverversion.txt")
            End If

            'Select Case Pub.POS
            '    Case "1"
            '        My.Computer.Network.DownloadFile("\\192.168.0.100\PeaceTMS.NET\version.txt", _
            '                                                    Application.StartupPath & "\serverversion.txt")
            '    Case "2"
            '        My.Computer.Network.DownloadFile("\\211.254.5.221\PeaceTMS.NET\version.txt", _
            '                                                    Application.StartupPath & "\serverversion.txt")
            '    Case Else
            'End Select

            My.Computer.Network.DownloadFile("\\192.168.0.100\PeaceTMS.NET\version.txt", _
                                                                Application.StartupPath & "\serverversion.txt")
            ServerText = READ_TO_STR(Application.StartupPath & "\serverversion.txt")

            ClientText = READ_TO_STR(Application.StartupPath & "\version.txt")
            If ClientText = "" Then ClientText = "1"
            If Int(ClientText) <> Int(ServerText) Then
                txt_FileName.Text = "최신 버젼프로그램이 아닙니다."
            Else
                txt_FileName.Text = "최신 버젼"
            End If

            Return True

        Catch ex As Exception


            Return False

        End Try



    End Function
    
#End Region

#Region "Events"
    Private Sub Version_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Dim str As String = MsgBoxP("Do you want to backup the program ?", vbYesNo)
        If str <> vbYes Then Exit Sub

        Dim cmd As New SqlClient.SqlCommand

        Try

            SQL = ""
            SQL = SQL + " BACKUP DATABASE SHINKWANG_MES "
            SQL = SQL + " TO DISK = '" & txt_FileName.Data & "SHINKWANG_MES_" & System_Date_time() & ".BAK'"

            SQL = SQL + " BACKUP DATABASE CS_PRINT "
            SQL = SQL + " TO DISK = '" & txt_FileName.Data & "CS_PRINT_" & System_Date_time() & ".BAK'"

            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()
            MdiMenu.Cursor = Cursors.WaitCursor

            MsgBoxP("Backup Sucessfully!", vbInformation)

            MdiMenu.Cursor = Cursors.Default
            Me.Dispose()
        Catch ex As Exception
            MsgBoxP("Backup Error. Check the path!")
            MdiMenu.Cursor = Cursors.Default
        End Try

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim str As String = MsgBoxP("Do you want to close the backup ?", vbYesNo)
        If str = vbYes Then Me.Dispose()
    End Sub
    Private Sub cmd_Path_Click(sender As Object, e As EventArgs) Handles cmd_Path.Click
        SaveFileDialog1.DefaultExt = ".bak"
        SaveFileDialog1.FileName = System_Date_time()
        SaveFileDialog1.Filter = "Backup Files|*.bak"

        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            txt_FileName.Data = SaveFileDialog1.InitialDirectory
        End If
    End Sub
#End Region

End Class