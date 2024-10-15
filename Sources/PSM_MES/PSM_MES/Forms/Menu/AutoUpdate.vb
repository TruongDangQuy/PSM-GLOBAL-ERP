Imports System.IO
Imports System.Net

Public Class AutoUpdate

#Region "Variable"
    Private blnEventAccess As Boolean = False

#End Region

#Region "Form_Load"
    Private Sub F_MAIN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Methods"
    
    Private Function VersionChk() As Boolean

        Version.Text = ""

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
                Version.Text = "최신 버젼프로그램이 아닙니다."
            Else
                Version.Text = "최신 버젼"
            End If

            Return True

        Catch ex As Exception


            Return False

        End Try



    End Function
    
#End Region

#Region "Events"
    Private Sub Version_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If UCase(Version.Text.Trim) <> PASSWORDCHECK Then Version.Text = "" : Exit Sub
        Version.Text = ""
        MdiMenu.Show()
        Me.Hide()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim str As String = MsgBoxP("Do you want to exit the program ?", vbYesNo)
        If str = vbYes Then Application.Exit()
    End Sub
#End Region

End Class