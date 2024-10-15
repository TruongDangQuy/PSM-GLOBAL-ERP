Imports System.Data.SqlClient
Module M_ServerConfigDate

#Region "Server"
    Public Sub SQLSERVER_DATE()
        Try
            SQL = " SELECT CONVERT(varchar(8),sysdatetime(),112) AS str_DATE "
            cmd = New SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()
            Pub.DAT = rd("str_DATE").ToString
            Pub.TIM = rd("str_DATE").ToString

            Pub.Year = Strings.Left(Pub.DAT, 4)
            Pub.Month = Strings.Mid(Pub.DAT, 5, 2)
            rd.Close()

        Catch ex As Exception

        End Try
       

    End Sub
    Public Sub system_as_date()

        '½Ã½ºÅÛ ÀÏÀÚ
        SQL = " SELECT CONVERT(varchar(8),sysdatetime(),112) AS str_DATE "
        cmd = New SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()
        Pub.DAT = rd("str_DATE").ToString
        Pub.TIM = rd("str_DATE").ToString
        rd.Close()

    End Sub

    Public Sub MDBSERVER_DATE()
        '½Ã½ºÅÛ ÀÏÀÚ
        'Pub.DAT = Format(DATE, "yyyymmdd")

        '    '½Ã½ºÅÛ ½Ã°£
        '    Pub.TIM = Format(TIME, "HH:MM:SS")
    End Sub
    Public Function JOB_Date() As String
        Dim dr As SqlClient.SqlDataReader
        Dim ServerDATE As String
        Dim INT_str As Integer
        Dim Tmp_Date As String = ""
        Dim xDAY As String

        JOB_Date = ""

        SQL = " select K9902_JDATE from pfk9902 "
        cmd = New SqlCommand(SQL, cn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = False Then
            dr.Close()
            Exit Function
        Else
            JOBDATE = dr("K9902_JDATE")
        End If

        dr.Close()

        ServerDATE = System_Date_8()

        Call System_Datetime()
        Pub.TIM = System_Date_time()
        If Mid(Pub.TIM, 1, 4) >= "0600" And Mid(Pub.TIM, 1, 2) <= "23" Then
            JOBDATE = ServerDATE
        Else
            If Mid(ServerDATE, 7, 2) = "01" Then    ''1ÀÏÀÌ¸é
                If Mid(ServerDATE, 5, 2) = "01" Then ''1¿ù´ÞÀÌ¸é
                    JOBDATE = Format(Int(Mid(ServerDATE, 1, 4)) - 1, "0000" & "1231")
                Else
                    xDAY = DateAdd("d", -1, Format(ServerDATE, "####/##/##"))
                    JOBDATE = Mid(xDAY, 1, 4) & Mid(xDAY, 6, 2) & Mid(xDAY, 9, 2)
                End If
            Else
                INT_str = Int(Mid(ServerDATE, 7, 2)) - 1
                JOBDATE = Mid(ServerDATE, 1, 6) & Format(CInt(INT_str), "00")
            End If
        End If
        Pub.DAT = JOBDATE

        If JOBDATE = "" Then Pub.DAT = ServerDATE

        If Mid(Pub.TIM, 1, 4) >= "0600" And Mid(Pub.TIM, 1, 4) <= "1800" Then
            Pub.JUY = "1"
        Else
            Pub.JUY = "2"
        End If
    End Function
    Public Function System_Time() As String
        Dim dr As SqlClient.SqlDataReader

        System_Time = ""
        If Pub.SETCS = "1" Then
            SQL = " select getdate( ) as System_Time "
            cmd.CommandText = SQL
            cmd.CommandType = CommandType.Text
            cmd.Connection = cn
            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If
            dr = cmd.ExecuteReader
            dr.Read()

            'System_Time = dr("[System_Time]".ToString("hhmmss"))
            'Pub.TIM = dr("[System_Time]".ToString("hhmmss"))

            dr.Close()
        End If

        If Pub.SETCS = "2" Then
            SQL = " select to_char (sysdate,'HH24MISS') as system_time from dual "
            cmd.CommandText = SQL
            cmd.CommandType = CommandType.Text
            cmd.Connection = cn
            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If
            dr = cmd.ExecuteReader
            dr.Read()
            System_Time = dr("[System_Time]")
            Pub.TIM = dr("[System_Time]")
            dr.Close()
        End If

    End Function
    Public Function System_Date() As String
        Dim dr As SqlClient.SqlDataReader

        System_Date = ""
        If Pub.SETCS = "1" Then
            SQL = " select getdate() as System_Date "
            cmd.CommandText = SQL
            cmd.CommandType = CommandType.Text
            cmd.Connection = cn
            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If
            dr = cmd.ExecuteReader
            dr.Read()
            System_Date = dr("[System_Date]")

            pubDATE_FULL = dr("[System_Date]")

            System_Date = Mid(System_Date, 1, 4) & Mid(System_Date, 6, 2) & Mid(System_Date, 9, 2)
            dr.Close()
        End If
        If Pub.SETCS = "2" Then
            SQL = " select to_char (sysdate,'yyyymmdd') as system_date from dual "
            cmd.CommandText = SQL
            cmd.CommandType = CommandType.Text
            cmd.Connection = cn
            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If
            dr = cmd.ExecuteReader
            dr.Read()
            System_Date = dr("[System_Date]")
            dr.Close()
        End If
        pubDATE = System_Date
        Pub.DAT = System_Date
    End Function
    Public Function System_Date_Add(Optional ByVal mon As Integer = 0, Optional ByVal day As Integer = 0) As String
        System_Date_Add = ""
        Try
            'SQL = " SELECT CONVERT(char(8),dateadd(month," + mon.ToString + ",dateadd(day," + day.ToString + ",sysdatetime())),112) AS SYSTEM_DATE "
            'cmd = New SqlCommand(SQL, cn)
            'rd = cmd.ExecuteReader
            'rd.Read()
            'System_Date_Add = rd("SYSTEM_DATE")
            'rd.Close()
            Dim Sdate As Date

            Sdate = CDate(FSDate(Pub.DAT))
            System_Date_Add = Sdate.AddMonths(mon).AddDays(day).ToShortDateString.Replace("-", "").Replace("/", "")
            Sdate = Sdate.AddMonths(mon).AddDays(day)
            System_Date_Add = Sdate.Year.ToString("0000") & Sdate.Month.ToString("00") & Sdate.Day.ToString("00")
        Catch ex As Exception
            System_Date_8()
        End Try
    End Function

    Public Function Function_Date_Add(ByVal Sdate As Date, Optional ByVal mon As Integer = 0, Optional ByVal day As Integer = 0) As String
        Function_Date_Add = ""
        Try
            Function_Date_Add = Sdate.AddMonths(mon).AddDays(day).ToShortDateString.Replace("-", "").Replace("/", "")
            Sdate = Sdate.AddMonths(mon).AddDays(day)
            Function_Date_Add = Sdate.Year.ToString("0000") & Sdate.Month.ToString("00") & Sdate.Day.ToString("00")
        Catch ex As Exception
            System_Date_8()
        End Try
    End Function
    Public Function System_Datetime() As DateTime
        System_Datetime = Nothing
        Try
            Dim cmd As SqlCommand
            Dim dr As SqlDataReader

            SQL = " SELECT CONVERT(varchar(10),sysdatetime(),120) AS SYSTEM_DATE "
            cmd = New SqlCommand(SQL, cn)
            dr = cmd.ExecuteReader
            dr.Read()
            System_Datetime = dr("SYSTEM_DATE")
            dr.Close()

        Catch ex As Exception

        End Try
    End Function
    Public Function System_Date_time() As String
        Dim dr As SqlDataReader

        System_Date_time = "20140101010101"
        Try
            SQL = " SELECT CONVERT(char(19),sysdatetime(),121) AS SYSTEM_DATE "
            cmd = New SqlCommand(SQL, cn)
            dr = cmd.ExecuteReader
            dr.Read()
            System_Date_time = dr("SYSTEM_DATE").ToString.Replace("-", "").Replace(" ", "").Replace(":", "")
            Pub.TIME = System_Date_time
            If Pub.TIME.Length > 8 Then Pub.DAT = Strings.Left(Pub.TIME, 8)

            dr.Close()
        Catch ex As Exception

        End Try
    End Function
    Public Function System_Date_8() As String
        System_Date_8 = ""
        Try
            SQL = " SELECT CONVERT(char(8),sysdatetime(),112) AS SYSTEM_DATE "
            cmd = New SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()
            System_Date_8 = rd("SYSTEM_DATE")
            rd.Close()

        Catch ex As Exception

        End Try
    End Function
    Public Function System_Date_6() As String
        System_Date_6 = ""
        Try
            SQL = " SELECT CONVERT(char(8),sysdatetime(),112) AS SYSTEM_DATE "
            cmd = New SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()
            System_Date_6 = Strings.Left(rd("SYSTEM_DATE").ToString, 6)
            rd.Close()

        Catch ex As Exception

        End Try
    End Function

    Public Function System_Date_4() As String
        System_Date_4 = ""
        Try
            SQL = " SELECT SUBSTRING(CONVERT(char(8),sysdatetime(),112),3,4) AS SYSTEM_DATE "
            cmd = New SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()
            System_Date_4 = rd("SYSTEM_DATE").ToString
            rd.Close()

        Catch ex As Exception

        End Try
    End Function
#End Region

#Region "Source"
    Public Function FormatCut(tmpdatetime As String) As String
        If tmpdatetime = "" Then Return ""
        FormatCut = tmpdatetime.ToString.Replace("/", "").Replace(":", "").Replace("-", "").Replace(" ", "").Replace("'", "''").Replace(".", "").Replace(Chr(13), "").Replace(Chr(10), "")
    End Function

    Public Function FormatCutAll(tmpdatetime As String) As String
        If tmpdatetime = "" Then Return ""
        FormatCutAll = tmpdatetime.ToString.Replace("_", "").Replace("/", "").Replace(":", "").Replace("-", "").Replace(" ", "").Replace("'", "''").Replace(".", "").Replace(Chr(13), "").Replace(Chr(10), "")
    End Function

    Public Function FormatCutAllSize(tmpdatetime As String) As String
        Try
            tmpdatetime = tmpdatetime.Replace("_", ".")

            If Len(tmpdatetime) > 0 Then tmpdatetime = Strings.Left(tmpdatetime, Len(tmpdatetime) - 1)

            If tmpdatetime = "" Then Return ""
            FormatCutAllSize = tmpdatetime.ToString.Replace("_", "").Replace("/", "").Replace(":", "").Replace("-", "").Replace(" ", "").Replace("'", "''").Replace(Chr(13), "").Replace(Chr(10), "")

        Catch ex As Exception

        End Try
      End Function
    'Public Function FSDate(tmpdate As String) As String
    '    Try
    '        If tmpdate.Trim = "" Then FSDate = "" : Exit Function
    '        If tmpdate.Length < 8 Or tmpdate.Length > 8 Then FSDate = "" : Exit Function
    '        FSDate = Left(tmpdate, 4) & "/" & Mid(tmpdate, 5, 2) & "/" & Right(tmpdate, 2)
    '    Catch ex As Exception
    '        Return Nothing
    '    End Try
    'End Function
    Public Function FSDate(tmpdate As String) As String
        Try
            If tmpdate = "" Then FSDate = "" : Exit Function
            tmpdate = FormatCut(tmpdate)
            If tmpdate.Length = 8 Then
                FSDate = Left(tmpdate, 4) & "/" & Mid(tmpdate, 5, 2) & "/" & Right(tmpdate, 2)
            ElseIf tmpdate.Length = 14 Then
                FSDate = FSDateTime(tmpdate)
            Else
                FSDate = ""
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function FSDateHour(tmpdate As String) As String
        Try
            If tmpdate = "" Then FSDateHour = "" : Exit Function
            FSDateHour = Left(tmpdate, 4) & "/" & Mid(tmpdate, 5, 2) & "/" & Mid(tmpdate, 7, 2) & "-" & Mid(tmpdate, 9, 2) & ":" & Mid(tmpdate, 11, 2)


        Catch ex As Exception
            Return Nothing
        End Try
    End Function


    Public Function FormatDateP(tmpdate As Date) As String
        Try
          
            FormatDateP = tmpdate.Year.ToString("0000") & tmpdate.Month.ToString("00") & tmpdate.Day.ToString("00")

        Catch ex As Exception
            FormatDateP = Pub.DAT
        End Try
    End Function

    Public Function FSDateVN(tmpdate As String) As String
        Try
            If tmpdate = "" Then FSDateVN = "" : Exit Function
            tmpdate = FormatCut(tmpdate)
            If tmpdate.Length = 8 Then
                FSDateVN = Right(tmpdate, 2) & "/" & Mid(tmpdate, 5, 2) & "/" & Left(tmpdate, 4)
            Else
                FSDateVN = ""
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function FSDateTime(tmpdatetime As Object) As String
        If tmpdatetime = "" Then FSDateTime = "" : Exit Function
        FSDateTime = Left(tmpdatetime, 4) & "/" & Mid(tmpdatetime, 5, 2) & "/" & Mid(tmpdatetime, 7, 2) & "-" & Mid(tmpdatetime, 9, 2) & ":" & Mid(tmpdatetime, 11, 2) & ":" & Right(tmpdatetime, 2)
    End Function

    Public Function datecd(str As String) As String
        If str.Trim = "" Then datecd = "" : Exit Function
        datecd = Mid(str, 1, 4) & Mid(str, 6, 2) & Mid(str, 9, 2)
        Return datecd
    End Function
    Public Function FormatFileno(str As String) As String
        If str.Trim = "" Then FormatFileno = "" : Exit Function
        FormatFileno = Mid(str, 1, 6) & "-" & Mid(str, 7, 3) & "-" & Right(str, 2)
        Return FormatFileno
    End Function

    Public Function FormatUserDecimal(str As String, Optional xDecimal As Integer = 0) As String
        If IsNumeric(str) Then Return FormatNumber(str, xDecimal) Else Return Nothing
    End Function

    Public Function Format0(str As String) As String
        Return FormatNumber(str, 0)
    End Function

    Public Function Format1(str As String) As String
        Return FormatNumber(str, 1)
    End Function
    Public Function Format2(str As String) As String
        Return FormatNumber(str, 2)
    End Function
    Public Function Format3(str As String) As String
        Return FormatNumber(str, 3)
    End Function
    Public Function Format4(str As String) As String
        Return FormatNumber(str, 4)
    End Function

#End Region

End Module
