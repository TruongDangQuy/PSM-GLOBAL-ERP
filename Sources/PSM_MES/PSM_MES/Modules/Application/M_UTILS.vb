Imports System.Management
Module M_UTILS

#Region "Variable"
    Public W9700 As T9700_AREA
    Private ChkSystem As Boolean = False
#End Region

#Region "Methods"
    Public Function GetComputerName() As String
        GetComputerName = ""

        Try
            Dim mc As New ManagementClass("Win32_ComputerSystem")
            Dim moc As ManagementObjectCollection = mc.GetInstances()
            Dim info As String = String.Empty
            For Each mo As ManagementObject In moc
                info = DirectCast(mo("Name"), String)
            Next
            Return info
        Catch ex As Exception

        End Try

    End Function
    Function GetAccountWin() As String
        GetAccountWin = ""

        Try
            If TypeOf My.User.CurrentPrincipal Is Security.Principal.WindowsPrincipal Then
                Dim parts() As String = Split(My.User.Name, "\")
                Dim username As String = parts(1)
                Return username
            Else
                Return My.User.Name
            End If
        Catch ex As Exception

        End Try

    End Function
    Public Function GetHDDSerialNo() As String
        GetHDDSerialNo = ""

        Try
            Dim mangnmt As New ManagementClass("Win32_LogicalDisk")
            Dim mcol As ManagementObjectCollection = mangnmt.GetInstances()
            Dim result As String = String.Empty
            For Each strt As ManagementObject In mcol
                result += Convert.ToString(strt("VolumeSerialNumber"))
            Next
            Return result
        Catch ex As Exception

        End Try
    End Function
    Public Function GetIPv4Address() As String
        GetIPv4Address = String.Empty
        Try
            Dim strHostName As String = System.Net.Dns.GetHostName()
            Dim iphe As System.Net.IPHostEntry = System.Net.Dns.GetHostEntry(strHostName)

            For Each ipheal As System.Net.IPAddress In iphe.AddressList
                If ipheal.AddressFamily = System.Net.Sockets.AddressFamily.InterNetwork Then
                    GetIPv4Address = ipheal.ToString()
                End If
            Next
        Catch ex As Exception
            GetIPv4Address = String.Empty
        End Try
    End Function


    Public Sub GetFullInformation(FormName As String, Optional ActionName As String = "", Optional Reference As String = "", Optional Description As String = "")
        Dim searcher As Object
        Dim objects As IEnumerable(Of ManagementObject)
        Try


            If ChkSystem = False Then
                Try
                    searcher = New ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapterConfiguration where IPEnabled=true")
                    objects = searcher.Get().Cast(Of ManagementObject)()

                    W9700.DeviceName = TryCast((From o In objects Order By o("IPConnectionMetric") Select o("Description")).FirstOrDefault().ToString, String)
                    W9700.MACAddress = TryCast((From o In objects Order By o("IPConnectionMetric") Select o("MACAddress")).FirstOrDefault().ToString, String)
                    W9700.IPv4Address = TryCast((From o In objects Order By o("IPConnectionMetric") Select o("IPAddress")).FirstOrDefault()(0), String)


                Catch ex As Exception

                End Try


                'Dim searcher As New ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapterConfiguration where IPEnabled=true")
                'Dim objects As IEnumerable(Of ManagementObject) = searcher.Get().Cast(Of ManagementObject)()

                W9700.UserCode = Pub.SAW

                Try
                    W9700.IPv4Address = TryCast(GetIPv4Address(), String)
                Catch ex As Exception

                End Try

                Try
                    W9700.ComputerName = TryCast(GetComputerName(), String)
                Catch ex As Exception

                End Try

                Try
                    W9700.AccountWin = TryCast(GetAccountWin(), String)
                Catch ex As Exception

                End Try

                'W9700.DHCPServer = TryCast((From o In objects Order By o("IPConnectionMetric") Select o("DefaultIPGateway")).FirstOrDefault()(0), String)
                Try
                    W9700.IPWan = TryCast(GetIPWan(), String)
                Catch ex As Exception

                End Try


                'W9700.DNSdomain = TryCast((From o In objects Order By o("IPConnectionMetric") Select o("DNSDomain")).FirstOrDefault().ToString, String)
                'W9700.DHCPServer = TryCast((From o In objects Order By o("IPConnectionMetric") Select o("DHCPServer")).FirstOrDefault().ToString, String)

                Try
                    W9700.HDDSerialNo = TryCast(GetHDDSerialNo(), String)
                Catch ex As Exception

                End Try

                W9700.DateCreate = System_Date_8()
                ChkSystem = True
            End If

            W9700.DateCreate = Pub.DAT
            W9700.DateTimeCreate = System_Date_time()
            W9700.FormName = FormName ' ten form thao tac
            W9700.ActionName = ActionName ' ten hanh dong search, update, insert...
            W9700.Reference = Reference ' ten proc or sql string
            W9700.Description = Description ' Mo ta neu co
            W9700.Active = "1"

            Call WRITE_PFK9700(W9700)
        Catch ex As Exception

        End Try
    End Sub
    Public Sub TRANSFER_R9700()
        Try
            Dim searcher As Object
            Dim objects As IEnumerable(Of ManagementObject)
            R9700.UserCode = Pub.SAW


            Try
                searcher = New ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapterConfiguration WHERE IPEnabled=TRUE")
                objects = searcher.Get().Cast(Of ManagementObject)()

                W9700.DeviceName = TryCast((From o In objects Order By o("IPConnectionMetric") Select o("Description")).FirstOrDefault().ToString, String)
                W9700.MACAddress = TryCast((From o In objects Order By o("IPConnectionMetric") Select o("MACAddress")).FirstOrDefault().ToString, String)
                W9700.IPv4Address = TryCast((From o In objects Order By o("IPConnectionMetric") Select o("IPAddress")).FirstOrDefault()(0), String)


            Catch ex As Exception

            End Try

            Try
                R9700.HDDSerialNo = GetHDDSerialNo()
            Catch ex As Exception

            End Try

            Try
                R9700.ComputerName = GetComputerName()
            Catch ex As Exception

            End Try

            Try
                R9700.AccountWin = GetAccountWin()
            Catch ex As Exception

            End Try

            Try
                R9700.DNSdomain = (From o In objects Order By o("IPConnectionMetric") Select o("DNSDomain")).FirstOrDefault().ToString
            Catch ex As Exception

            End Try

            Try
                R9700.DHCPServer = (From o In objects Order By o("IPConnectionMetric") Select o("DefaultIPGateway")).FirstOrDefault()(0)
            Catch ex As Exception

            End Try



        Catch ex As Exception

        End Try
    End Sub
    Public Function GetIPWan() As String
        Dim IPWan As String = String.Empty
        Return IPWan
    End Function
#End Region

End Module
