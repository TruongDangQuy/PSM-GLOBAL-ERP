Imports System.Data.SqlClient
Imports System.Resources
Imports System.Object
Imports System.Net

Module M_CODE

#Region "Variable"
    Public App_Path = New System.IO.FileInfo(Application.ExecutablePath).DirectoryName
    Public Password As String = "NguyenKhanhHungVR"
    Public Salt As String = "JunCo18CM"
    Public DefaultsValue As String = ""
#End Region

#Region "Methods"

    Public Function GetConnect() As String
        GetConnect = ""
        Dim doc As New System.Xml.XmlDocument()
        doc.Load(App_Path & "\ConnectSQL.xml")
        Dim nodes As System.Xml.XmlNodeList = doc.DocumentElement.SelectNodes("/Table/Product")
        Dim sPort As Integer = 6847
        Dim sIPFormFile As String = ""
        Dim sIP As String = ""

        Dim ListIP As List(Of String) = New List(Of String)

        For Each node As System.Xml.XmlNode In nodes
            sIPFormFile = Decrypt(node.SelectSingleNode("Product_ser").InnerText, "JunCo", "GamCo")
            If ListIP.Any(Function(n) n = sIPFormFile) = False Then
                ListIP.Add(sIPFormFile)
            End If
        Next

        For Each _String As String In ListIP
            sIP = _String.Split(",")(0)
            sPort = CInt(_String.Split(",")(1))
            If ScanPort(sIP, sPort) Then
                GetConnect = String.Format("{0}:{1}", sIP, sPort.ToString)
                Exit Function
            End If
        Next


    End Function


    Public Function Decrypt(ByVal value As String, ByVal ipassword As String, ByVal isalt As String) As String
        Decrypt = ""
        Try
            If String.IsNullOrWhiteSpace(value) Then Exit Function
            Dim byteArray() As Byte = System.Convert.FromBase64String(value)
            Dim fullPassword As String = Password + Salt
            Dim sha256 As System.Security.Cryptography.SHA256 = System.Security.Cryptography.SHA256.Create()
            Dim key() As Byte = sha256.ComputeHash(System.Text.UnicodeEncoding.Unicode.GetBytes(fullPassword))
            Dim aes As System.Security.Cryptography.Aes = New System.Security.Cryptography.AesCryptoServiceProvider() : aes.KeySize = 256 : aes.Key = key
            If byteArray.Length < 16 Then Exit Function
            aes.IV = byteArray.Take(16).ToArray()

            Dim decryptor As System.Security.Cryptography.ICryptoTransform = aes.CreateDecryptor()
            Dim result() As Byte = Nothing
            Try
                result = decryptor.TransformFinalBlock(byteArray, 16, byteArray.Length - 16)
            Catch ex As Exception

            End Try
            Decrypt = System.Text.UnicodeEncoding.Unicode.GetString(result)

        Catch ex As Exception

        End Try
    End Function

    Private Function ScanPort(hostname As String, portno As Integer) As Boolean
        ScanPort = False
        Try
            'Dim hostname As String = "85.250.180.71"
            'Dim portno As Integer = 9081
            Dim ipa As IPAddress = DirectCast(Dns.GetHostAddresses(hostname)(0), IPAddress)
            Try

                'If My.Computer.Network.Ping(hostname) = False Then Exit Function

                Dim sock As New System.Net.Sockets.Socket(System.Net.Sockets.AddressFamily.InterNetwork, System.Net.Sockets.SocketType.Stream, System.Net.Sockets.ProtocolType.Tcp)
                sock.Connect(ipa, portno)
                If sock.Connected = True Then
                    ' Port is in use and connection is successful
                    'MessageBox.Show("Port is Closed")
                    ScanPort = True
                Else
                    ScanPort = False
                End If

                sock.Close()
            Catch ex As System.Net.Sockets.SocketException
                ScanPort = False
                'If ex.ErrorCode = 10061 Then
                '    ' Port is unused and could not establish connection 
                '    MessageBox.Show("Port is Open!")
                '    ScanPort = False
                'Else
                '    MessageBox.Show(ex.Message)
                'End If
            End Try

        Catch ex As Exception

        End Try
    End Function

#End Region

End Module
