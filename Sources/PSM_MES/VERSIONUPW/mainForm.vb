Imports System.Net
Imports System.IO
Imports System.Threading
Imports System.Web

Public Class mainForm
    'Public Function MsgBox(ByVal Content As String, Optional ByVal ex As Microsoft.VisualBasic.MsgBoxStyle = MsgBoxStyle.Critical, Optional ByVal Title As String = Nothing) As Microsoft.VisualBasic.MsgBoxResult

    'End Function
#Region "Variable"
    Public App_Path = New System.IO.FileInfo(Application.ExecutablePath).DirectoryName
    Dim whereToSave As String 'Where the program save the file
    Dim _LineOrig As String = ""
    Dim _LineConv As String = ""
    Dim workerNo As Integer = 0
    Dim _DownloadLink As String = ""
    Dim CheckUpdate As String = ""

    Delegate Sub ChangeTextsSafe(ByVal length As Long, ByVal position As Integer, ByVal percent As Integer, ByVal speed As Double)
    Delegate Sub DownloadCompleteSafe(ByVal cancelled As Boolean)

    Public currentVer As String
    Public mostRecent As String

    Dim DownLogin As String
    Dim IPConSer As String
    Dim FilePath As String
#End Region

#Region "Form_Load"
    Private Sub btnDownload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Show()
        Try

            Dim DownPathIP As System.IO.StreamReader
            'DownPathIP = My.Computer.FileSystem.OpenTextFileReader(App_Path & "\Connect.txt")
            'IPConSer = DownPathIP.ReadToEnd() : DownPathIP.Close()

            IPConSer = GetConnect()

            Dim StreamerDownLogin As System.IO.StreamReader
            StreamerDownLogin = My.Computer.FileSystem.OpenTextFileReader(App_Path & "\DownLogin.txt")
            DownLogin = StreamerDownLogin.ReadToEnd() : StreamerDownLogin.Close()

            Call FormatCut(IPConSer, DownLogin)

            'If My.Computer.Network.Ping(IPConSer) = False Then
            '    Call DownloadOutside()
            '    Exit Sub
            '    Process.Start(App_Path & "\" & DownLogin)
            '    Application.Exit()
            '    Exit Sub
            'End If

            If Me.txtFileName.Text <> "" AndAlso Me.txtFileName.Text.StartsWith("http://") Then
                cmd_RUN.Enabled = False
                btnCancel.Enabled = False

                Dim DownPath As System.IO.StreamReader
                DownPath = My.Computer.FileSystem.OpenTextFileReader(App_Path & "\DownPath.txt")
                FilePath = DownPath.ReadToEnd() : DownPath.Close()

                Call FormatCut(IPConSer, FilePath)

                Me.txtFileName.Tag = FilePath

                If Strings.Right(FilePath, 1) = "/" Then
                    FilePath = Strings.Left(FilePath, Len(FilePath) - 1)
                End If

                Try

                    Dim sr As System.IO.StreamReader
                    sr = My.Computer.FileSystem.OpenTextFileReader(App_Path & "\version.txt")
                    currentVer = sr.ReadToEnd() : sr.Close()

                Catch ex As Exception
                    currentVer = 0
                End Try
                'Check to see if the file version currently of application is less than the most recent
                Dim sr1 As System.IO.StreamReader
                Dim client As WebClient = New WebClient()
                sr1 = New StreamReader(client.OpenRead(FilePath & "/version.txt"))

                mostRecent = sr1.ReadToEnd
                sr1.Close()
                If currentVer <> mostRecent Then
                    Call KillPro()

                    Dim LineOrig As String
                    Dim LineConv As String
                    Dim Line As String

                    sr1 = New StreamReader(client.OpenRead(FilePath & "/uplist.txt"))
                    workerNo = -1
                    Do While Not sr1.EndOfStream

                        Line = sr1.ReadLine
                        CheckUpdate = Strings.Left(Line, 1)
                        Line = Strings.Mid(Line, 2)

                        LineOrig = Split(Line, ";")(0)
                        LineConv = Split(Line, ";")(1)
                        _LineOrig = LineOrig
                        _LineConv = LineConv

                        If CheckUpdate = "1" And My.Computer.FileSystem.DirectoryExists(App_Path & "\" & LineConv) Then
                            GoTo Endline
                        End If

                        Try
                            My.Computer.FileSystem.DeleteFile(App_Path & "\" & LineOrig)

                        Catch ex As Exception
                            'My.Computer.FileSystem.RenameFile(App_Path & "\" & LineOrig, App_Path & "\" & LineOrig & "001")
                        End Try

                        Try
                            My.Computer.FileSystem.DeleteFile(App_Path & "\" & LineConv)
                        Catch ex As Exception
                            'My.Computer.FileSystem.RenameFile(App_Path & "\" & LineConv, App_Path & "\" & LineConv & "001")
                        End Try

                        Me.whereToSave = App_Path & "\" & LineOrig

                        Me.SaveFileDialog1.FileName = ""

                        Me.Label6.Text = "Save to: " & Me.whereToSave

                        Me.txtFileName.Enabled = False
                        Me.btnDownload.Enabled = False
                        Me.btnCancel.Enabled = True
                        Me.txtFileName.Text = Me.txtFileName.Tag & LineOrig
                        _DownloadLink = Me.txtFileName.Text
                        DownloadFile()
Endline:
                    Loop

                    sr1.Close()

                    Dim srw As System.IO.StreamWriter
                    srw = My.Computer.FileSystem.OpenTextFileWriter(App_Path & "\version.txt", False)
                    srw.Write(mostRecent)
                    srw.Close()

                    Process.Start(App_Path & "\" & DownLogin)
                    Application.Exit()

                Else
                    Dim srw As System.IO.StreamWriter
                    srw = My.Computer.FileSystem.OpenTextFileWriter(App_Path & "\version.txt", False)
                    srw.Write(mostRecent)
                    srw.Close()

                    GoTo Endline2

                    Dim cbao As String = MsgBox("No new version! Do you want to download again ?", vbYesNo)
                    If cbao = vbYes Then
                        Call KillPro()

                        Dim LineOrig As String
                        Dim LineConv As String
                        Dim Line As String

                        sr1 = New StreamReader(client.OpenRead(FilePath & "/uplist.txt"))
                        workerNo = -1
                        Do While Not sr1.EndOfStream

                            Line = sr1.ReadLine
                            CheckUpdate = Strings.Left(Line, 1)
                            Line = Strings.Mid(Line, 2)

                            LineOrig = Split(Line, ";")(0)
                            LineConv = Split(Line, ";")(1)
                            _LineOrig = LineOrig
                            _LineConv = LineConv


                            If CheckUpdate = "1" And My.Computer.FileSystem.FileExists(App_Path & "\" & LineConv) Then
                                GoTo Endline1
                            End If

                            Try
                                My.Computer.FileSystem.DeleteFile(App_Path & "\" & LineOrig)
                            Catch ex As Exception

                            End Try

                            Try
                                My.Computer.FileSystem.DeleteFile(App_Path & "\" & LineConv)
                            Catch ex As Exception

                            End Try

                            Me.whereToSave = App_Path & "\" & LineOrig

                            Me.SaveFileDialog1.FileName = ""

                            Me.Label6.Text = "Save to: " & Me.whereToSave

                            Me.txtFileName.Enabled = False
                            Me.btnDownload.Enabled = False
                            Me.btnCancel.Enabled = True
                            Me.txtFileName.Text = Me.txtFileName.Tag & LineOrig
                            _DownloadLink = Me.txtFileName.Text
                            DownloadFile()
Endline1:
                        Loop

                        sr1.Close()
                        Process.Start(App_Path & "\" & DownLogin)
                        Application.Exit()

                    Else
Endline2:
                        Process.Start(App_Path & "\" & DownLogin)
                        Application.Exit()
                    End If

                End If

            End If

        Catch ex As Exception
            Process.Start(App_Path & "\" & DownLogin)
            Application.Exit()
        End Try
    End Sub

    Private Sub mainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Label4.Text = ""
    End Sub
#End Region

#Region "Methods"
    Public Sub DownloadComplete(ByVal cancelled As Boolean)
        Me.txtFileName.Enabled = True
        Me.btnDownload.Enabled = True
        Me.btnCancel.Enabled = False

        If cancelled Then

            Me.Label4.Text = "Cancelled"

            MessageBox.Show("Download aborted", "Aborted", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Else
            Me.Label4.Text = "Successfully downloaded !"
            Try
                My.Computer.FileSystem.RenameFile(App_Path & "\" & _LineOrig, _LineConv)
            Catch ex As Exception

            End Try


        End If

        Me.ProgressBar1.Value = 0
        Me.Label5.Text = "Downloading: "
        Me.Label6.Text = "Save to: "
        Me.Label3.Text = "File size: "
        Me.Label2.Text = "Download speed: "
        Me.Label4.Text = ""

    End Sub

    Public Sub ChangeTexts(ByVal length As Long, ByVal position As Integer, ByVal percent As Integer, ByVal speed As Double)

        Me.Label3.Text = "File Size: " & Math.Round((length / 1024), 2) & " KB"

        Me.Label5.Text = "Downloading: " & Me.txtFileName.Text

        Me.Label4.Text = "Downloaded " & Math.Round((position / 1024), 2) & " KB of " & Math.Round((length / 1024), 2) & "KB (" & Me.ProgressBar1.Value & "%)"

        If speed = -1 Then
            Me.Label2.Text = "Speed: calculating..."
        Else
            Me.Label2.Text = "Speed: " & Math.Round((speed / 1024), 2) & " KB/s"
        End If

        If percent >= 0 Then
            Me.ProgressBar1.Value = percent
        End If



    End Sub

    Private Sub KillPro()
        Try
            For Each prog As Process In Process.GetProcesses
                If prog.ProcessName = "ERP_PSM" Then
                    prog.Kill()
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub
    Private Sub DownloadOutside()
        Exit Sub

        Try
            If Me.txtFileName.Text <> "" AndAlso Me.txtFileName.Text.StartsWith("http://") Then
                cmd_RUN.Enabled = False
                btnCancel.Enabled = False

                Dim FilePath As String
                Dim DownPath As System.IO.StreamReader
                DownPath = My.Computer.FileSystem.OpenTextFileReader(App_Path & "\DownPath1.txt")
                FilePath = DownPath.ReadToEnd() : DownPath.Close()

                Call FormatCut(IPConSer, FilePath)

                Me.txtFileName.Tag = FilePath
                If Strings.Right(FilePath, 1) = "/" Then
                    FilePath = Strings.Left(FilePath, Len(FilePath) - 1)
                End If
                Try

                    Dim sr As System.IO.StreamReader
                    sr = My.Computer.FileSystem.OpenTextFileReader(App_Path & "\version.txt")
                    currentVer = sr.ReadToEnd() : sr.Close()

                Catch ex As Exception
                    currentVer = 0
                End Try
                'Check to see if the file version currently of application is less than the most recent
                Dim sr1 As System.IO.StreamReader
                Dim client As WebClient = New WebClient()
                sr1 = New StreamReader(client.OpenRead("http://61.28.231.43/CS_WHM/version.txt"))
                mostRecent = sr1.ReadToEnd
                sr1.Close()
                If currentVer <> mostRecent Then
                    Dim cbao As String = vbYes ' MsgBox("Do you want to update new version ?", vbYesNo)
                    cbao = vbYes
                    If cbao = vbYes Then
                        Call KillPro()

                        Dim LineOrig As String
                        Dim LineConv As String
                        Dim Line As String

                        sr1 = New StreamReader(client.OpenRead("http://61.28.231.43:6847/CS_WHM/uplist.txt"))
                        workerNo = -1
                        Do While Not sr1.EndOfStream
                            Line = sr1.ReadLine
                            CheckUpdate = Strings.Left(Line, 1)
                            Line = Strings.Mid(Line, 2)

                            LineOrig = Split(Line, ";")(0)
                            LineConv = Split(Line, ";")(1)
                            _LineOrig = LineOrig
                            _LineConv = LineConv

                            If CheckUpdate = "1" And My.Computer.FileSystem.DirectoryExists(App_Path & "\" & LineConv) Then
                                GoTo Endline
                            End If

                            Try
                                My.Computer.FileSystem.DeleteFile(App_Path & "\" & LineOrig)

                            Catch ex As Exception
                                'My.Computer.FileSystem.RenameFile(App_Path & "\" & LineOrig, App_Path & "\" & LineOrig & "001")
                            End Try

                            Try
                                My.Computer.FileSystem.DeleteFile(App_Path & "\" & LineConv)
                            Catch ex As Exception
                                'My.Computer.FileSystem.RenameFile(App_Path & "\" & LineConv, App_Path & "\" & LineConv & "001")
                            End Try

                            Me.whereToSave = App_Path & "\" & LineOrig

                            Me.SaveFileDialog1.FileName = ""

                            Me.Label6.Text = "Save to: " & Me.whereToSave

                            Me.txtFileName.Enabled = False
                            Me.btnDownload.Enabled = False
                            Me.btnCancel.Enabled = True
                            Me.txtFileName.Text = Me.txtFileName.Tag & LineOrig
                            _DownloadLink = Me.txtFileName.Text
                            DownloadFile()
Endline:
                        Loop

                        sr1.Close()

                        Process.Start(App_Path & "\" & DownLogin)
                        Application.Exit()
                    Else
                        Process.Start(App_Path & "\" & DownLogin)
                        Application.Exit()
                    End If

                Else
                    Dim cbao As String = vbNo 'MsgBox("No new version! Do you want to download again ?", vbYesNo, "Alo!")
                    If cbao = vbYes Then
                        Call KillPro()

                        Dim LineOrig As String
                        Dim LineConv As String
                        Dim Line As String

                        sr1 = New StreamReader(client.OpenRead("http://61.28.231.43:6847/CS_WHM/uplist.txt"))
                        workerNo = -1
                        Do While Not sr1.EndOfStream

                            Line = sr1.ReadLine
                            CheckUpdate = Strings.Left(Line, 1)
                            Line = Strings.Mid(Line, 2)

                            LineOrig = Split(Line, ";")(0)
                            LineConv = Split(Line, ";")(1)
                            _LineOrig = LineOrig
                            _LineConv = LineConv


                            If CheckUpdate = "1" And My.Computer.FileSystem.FileExists(App_Path & "\" & LineConv) Then
                                GoTo Endline1
                            End If

                            Try
                                My.Computer.FileSystem.DeleteFile(App_Path & "\" & LineOrig)
                            Catch ex As Exception

                            End Try

                            Try
                                My.Computer.FileSystem.DeleteFile(App_Path & "\" & LineConv)
                            Catch ex As Exception

                            End Try

                            Me.whereToSave = App_Path & "\" & LineOrig

                            Me.SaveFileDialog1.FileName = ""

                            Me.Label6.Text = "Save to: " & Me.whereToSave

                            Me.txtFileName.Enabled = False
                            Me.btnDownload.Enabled = False
                            Me.btnCancel.Enabled = True
                            Me.txtFileName.Text = Me.txtFileName.Tag & LineOrig
                            _DownloadLink = Me.txtFileName.Text
                            'worker(workerNo).DownloadLink = Me.txtFileName.Tag & LineOrig

                            'worker(workerNo).WorkerReportsProgress = True

                            'worker(workerNo).RunWorkerAsync()

                            DownloadFile()
Endline1:
                        Loop

                        sr1.Close()
                        Process.Start(App_Path & "\" & DownLogin)
                        Application.Exit()

                    Else
                        Process.Start(App_Path & "\" & DownLogin)
                        Application.Exit()
                    End If

                End If

            End If

        Catch ex As Exception
            Process.Start(App_Path & "\" & DownLogin)
            Application.Exit()
        End Try
    End Sub

    Private Sub FormatCut(Rep As String, ByRef Value As String)
        Dim i As Integer
        Dim j As Integer
        Dim strRe As String

        i = Value.IndexOf("//")
        If i >= 5 Then
            j = Value.IndexOf("/", i + 2)
            strRe = Strings.Mid(Value, i + 3, j - i - 2)

            Value = Value.Replace(strRe, Rep)
        End If


    End Sub

    Public Shared Function GetFileSize(url As String) As Long
        Using obj As New WebClient()
            Using s As Stream = obj.OpenRead(url)
                Return Long.Parse(obj.ResponseHeaders("Content-Length").ToString())
            End Using
        End Using
    End Function

    Public Function MapPath(path As String) As String
        'Usage
        Dim instance As HttpServerUtility
        Dim path1 As String
        Dim returnValue As String

        returnValue = instance.MapPath(path1)

    End Function

    Private Sub DownloadFile()

        Dim theResponse As HttpWebResponse
        Dim theRequest As HttpWebRequest

        Try 'Checks if the file exist
            theRequest = HttpWebRequest.Create(_DownloadLink)
            theResponse = theRequest.GetResponse

        Catch ex As Exception

            MessageBox.Show("An error occurred while downloading file. Possibe causes:" & ControlChars.CrLf & _
                            "1) File doesn't exist" & ControlChars.CrLf & _
                            "2) Remote server error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Dim cancelDelegate As New DownloadCompleteSafe(AddressOf DownloadComplete)

            Me.Invoke(cancelDelegate, True)

            Exit Sub
        End Try
        Dim length As Long = theResponse.ContentLength


        Dim safedelegate As New ChangeTextsSafe(AddressOf ChangeTexts)
        Me.Invoke(safedelegate, length, 0, 0, 0)

        Dim writeStream As New IO.FileStream(Me.whereToSave, IO.FileMode.Create)

        Dim nRead As Integer

        Dim speedtimer As New Stopwatch
        Dim currentspeed As Double = -1
        Dim readings As Integer = 0

        Do
            Me.Show()
            Application.DoEvents()
            speedtimer.Start()

            Dim readBytes(4095) As Byte
            Dim bytesread As Integer = theResponse.GetResponseStream.Read(readBytes, 0, 4096)

            nRead += bytesread
            Dim percent As Short = (nRead * 100) / length

            Me.Invoke(safedelegate, length, nRead, percent, currentspeed)

            If bytesread = 0 Then Exit Do

            writeStream.Write(readBytes, 0, bytesread)

            speedtimer.Stop()

            readings += 1
            If readings >= 5 Then 'For increase precision, the speed it's calculated only every five cicles
                currentspeed = 20480 / (speedtimer.ElapsedMilliseconds / 1000)
                speedtimer.Reset()
                readings = 0
            End If
        Loop

        'Close the streams
        theResponse.GetResponseStream.Close()
        writeStream.Close()


        Dim completeDelegate As New DownloadCompleteSafe(AddressOf DownloadComplete)

        Me.Invoke(completeDelegate, False)


    End Sub

#End Region

#Region "Events"
    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BGW.DoWork

        'Creating the request and getting the response
        Dim theResponse As HttpWebResponse
        Dim theRequest As HttpWebRequest
        Try 'Checks if the file exist

            theRequest = WebRequest.Create(sender.DownloadLink)
            theResponse = theRequest.GetResponse()

        Catch ex As Exception

            MessageBox.Show("An error occurred while downloading file. Possibe causes:" & ControlChars.CrLf & _
                            "1) File doesn't exist" & ControlChars.CrLf & _
                            "2) Remote server error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Dim cancelDelegate As New DownloadCompleteSafe(AddressOf DownloadComplete)

            Me.Invoke(cancelDelegate, True)

            Exit Sub
        End Try
        Dim length As Long = theResponse.ContentLength 'Size of the response (in bytes)

        Dim safedelegate As New ChangeTextsSafe(AddressOf ChangeTexts)
        Me.Invoke(safedelegate, length, 0, 0, 0) 'Invoke the TreadsafeDelegate

        Dim writeStream As New IO.FileStream(Me.whereToSave, IO.FileMode.Create)

        'Replacement for Stream.Position (webResponse stream doesn't support seek)
        Dim nRead As Integer

        'To calculate the download speed
        Dim speedtimer As New Stopwatch
        Dim currentspeed As Double = -1
        Dim readings As Integer = 0

        Do

            If sender.CancellationPending Then 'If user abort download
                Exit Do
            End If

            speedtimer.Start()

            Dim readBytes(4095) As Byte
            Dim bytesread As Integer = theResponse.GetResponseStream.Read(readBytes, 0, 4096)

            nRead += bytesread
            Dim percent As Short = (nRead * 100) / length

            Me.Invoke(safedelegate, length, nRead, percent, currentspeed)

            If bytesread = 0 Then Exit Do

            writeStream.Write(readBytes, 0, bytesread)

            speedtimer.Stop()

            readings += 1
            If readings >= 5 Then 'For increase precision, the speed it's calculated only every five cicles
                currentspeed = 20480 / (speedtimer.ElapsedMilliseconds / 1000)
                speedtimer.Reset()
                readings = 0
            End If
        Loop

        'Close the streams
        theResponse.GetResponseStream.Close()
        writeStream.Close()

        If sender.CancellationPending Then

            IO.File.Delete(Me.whereToSave)

            Dim cancelDelegate As New DownloadCompleteSafe(AddressOf DownloadComplete)

            Me.Invoke(cancelDelegate, True)

            Exit Sub

        End If

        Dim completeDelegate As New DownloadCompleteSafe(AddressOf DownloadComplete)

        Me.Invoke(completeDelegate, sender, False)


    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        sender.CancelAsync() 'Send cancel request
        Dim wrt As System.IO.StreamWriter
        wrt = My.Computer.FileSystem.OpenTextFileWriter(App_Path & "\version.txt", False)
        wrt.Write(currentVer)
        wrt.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Application.Exit()
    End Sub

    Private Sub cmd_RUN_Click(sender As Object, e As EventArgs) Handles cmd_RUN.Click
        Process.Start(App_Path & "\" & DownLogin)
        Application.Exit()
    End Sub
#End Region

End Class
