Imports System.Data.SqlClient
Module M_ServerConfig

#Region "Variable"
    Public cn As SqlConnection
    Private adtMaster As SqlDataAdapter
    Private adtDetail As SqlDataAdapter

    Private dsMain As New DataSet
    Private dvDetail As New DataView
#End Region

#Region "Methods"
    Public Function TextCheck(WCHK As String, wStr As Object, msg As String) As Boolean
        TextCheck = False
        Select Case WCHK
            Case "1"
                If Trim(wStr) = "" Then
                    MsgBoxP("[" & msg & "]'s Format is wrong. You must Check.", vbInformation, "TextCheck")

                    '  wStr.SetFocus()
                    Exit Function
                End If
            Case "2"
                If Not IsNumeric(wStr) Then
                    MsgBoxP("[" & msg & "]'s Format is wrong. You must Check.", vbInformation, "TextCheck")

                    '                    wStr.SetFocus()
                    Exit Function
                End If
            Case "3"
                'If Not IsDate(Format(wStr, "####/##/##")) Then
                '    MsgBoxP("[" & msg & "]'s Format is wrong. You must Check.", vbInformation, "TextCheck")
                '    wStr.SetFocus()
                '    Exit Function
                'End If
        End Select
        TextCheck = True
    End Function
    Public Function DB_Connect() As Boolean
        DB_Connect = True
        Try
            If DbConnectCheck = True Then Exit Function

            Select Case Pub.SETCS
                Case "1"
                    If SQLServer_Connection() = False Then DB_Connect = False : Exit Function
                    '   Call R_SET()

                Case "2"
                    If OracleServer_Connection() = False Then DB_Connect = False : Exit Function
                    'Call R_SET()
                Case "3"
                    If MDB_Connection() = False Then DB_Connect = False
            End Select

            DbConnectCheck = True

        Catch ex As Exception
            MsgBoxP("[¿°»ö ¾÷¹«] Á¢¼Ó ¿¡·¯ ÀÔ´Ï´Ù. È®ÀÎ ¹Ù¶ø´Ï´Ù.", vbInformation, "DB Connect")
            DB_Connect = False
        End Try



    End Function
    Public Function SQLServer_Connection() As Boolean
        SQLServer_Connection = True

        Try
            'cn.ConnectionTimeout = 60
            'cn.Provider = "sqloledb"
            'cn.Properties("Data Source").Value = Pub.SER
            'cn.Properties("Initial Catalog").Value = Pub.DBS
            'cn.Properties("User ID").Value = Pub.IDS
            'cn.Properties("Password").Value = Pub.PWS
            'cn.Open()
            Dim str As String = "data Source=127.0.0.1;Initial Catalog=THANHCONG_MES;Integrated Security=True"
            'Integrated Security=True"
            ' cn = New SqlConnection(str)
        Catch ex As Exception
            MsgBoxP("[¾÷¹«] Á¢¼Ó ¿¡·¯ ÀÔ´Ï´Ù. È®ÀÎ ¹Ù¶ø´Ï´Ù.", vbInformation, "SQL Server Connection")

            SQLServer_Connection = False
        End Try

    End Function
    Public Function OracleServer_Connection() As Boolean
        OracleServer_Connection = True
        Try

            If Pub.pos = 1 Then
                'cn.CursorLocation = adUseClient
                'cn.Open("PROVIDER=MSDAORA; " & _
                '         "User ID=peace/peacesystem; " & _
                '         "DATA SOURCE=elca")
            End If

            If Pub.pos = 2 Then

            End If

        Catch ex As Exception
            MsgBoxP("[¿°»ö ¾÷¹«] Á¢¼Ó ¿¡·¯ ÀÔ´Ï´Ù. È®ÀÎ ¹Ù¶ø´Ï´Ù.", vbInformation, "Oracle Server Connection")

            OracleServer_Connection = False
        End Try

    End Function
    Public Function MDB_Connection() As Boolean
        MDB_Connection = True
    End Function

    Public Sub MDB_Close()

    End Sub

    Public Sub TimedOpen(conn As SqlConnection)
        Dim sw As Stopwatch = Stopwatch.StartNew()
        conn.Open()
        Console.WriteLine(sw.Elapsed)
    End Sub

    Public Function OpenConnection() As SqlConnection
        Try
            If cn Is Nothing Then
                Dim str As String = "data Source='" + Pub.SSER + "';Initial Catalog='" + Pub.DBS + "';User ID='" + Pub.IDS + "';Password='" + Pub.PWS + "';MultipleActiveResultSets=true;Connection Timeout=30"
                cn = New SqlConnection(str)
                cn.Open()
            Else
                cn.Close()
                Dim str As String = "data Source='" + Pub.SSER + "';Initial Catalog='" + Pub.DBS + "';User ID='" + Pub.IDS + "';Password='" + Pub.PWS + "';MultipleActiveResultSets=true;Connection Timeout=30"
                cn = New SqlConnection(str)
                cn.Open()
            End If

            Return cn
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Sub CloseConnection()
        Try
            If cn IsNot Nothing Then
                If cn.State = ConnectionState.Open Then
                    cn.Close()
                End If
            End If
        Catch ex As Exception
            MsgBoxP("Can not Close Connection", vbCritical)
        End Try
    End Sub
    Public Function kndl() As Boolean
        kndl = False
        Try
            If OpenConnection() IsNot Nothing Then
                Return True
            End If
        Catch ex As Exception
            ' Application.Exit()
        End Try
    End Function

    'Return SQL Server Name
    Public Function SQLServer_Name() As String

        Dim SQL As String
        Dim cmd As SqlCommand

        Try

            SQL = "SELECT SYSTEM_USER AS SQL_NAME"
            cmd = New SqlCommand(SQL, cn)

            Return cmd.ExecuteScalar

        Catch ex As Exception

            '           MsgLogBox(ex)

            Return Nothing

        End Try

    End Function

    Public Function SQLServer_Now() As String
        Dim SQL As String
        Dim cmd As SqlCommand

        Dim strTemp As String

        Try
            SQL = "SELECT GETDATE() AS SQL_DATE"
            cmd = New SqlCommand(SQL, cn)
            strTemp = cmd.ExecuteScalar

            strTemp = _
            Replace(FormatDateTime(strTemp, DateFormat.ShortDate), "-", "") & _
            Replace(FormatDateTime(strTemp, DateFormat.ShortTime), ":", "") & _
            Right(FormatDateTime(strTemp, DateFormat.LongTime), 2)

            Return strTemp

        Catch ex As Exception
            '        MsgLogBox(ex)
            Return Nothing
        End Try

    End Function

    Public Function SQLServer_Time() As String

        Dim SQL As String
        Dim cmd As SqlCommand

        Try

            SQL = " SELECT GETDATE() AS SQL_DATE "

            cmd = New SqlCommand(SQL, cn)

            Return Format(cmd.ExecuteScalar, "HHmmss")

        Catch ex As Exception

            '     MsgLogBox(ex)

            Return Nothing

        End Try

    End Function


    Public Sub LoadData(table As String, KeyTable As String, KeyTable2 As String, pID As String)
        Dim strM As String = (Convert.ToString("SELECT * FROM " & table & " WHERE " & KeyTable & " = '") & pID) + "'"
        Dim strD As String = (Convert.ToString("SELECT * FROM " & table & " WHERE " & KeyTable & " = '") & pID) + "'"

        Dim cboTemp As SqlCommandBuilder
        adtMaster.SelectCommand.Parameters.Clear()

        cboTemp = New SqlCommandBuilder(adtMaster)
        adtMaster.InsertCommand = cboTemp.GetInsertCommand()
        adtMaster.UpdateCommand = cboTemp.GetUpdateCommand()
        adtMaster.DeleteCommand = cboTemp.GetDeleteCommand()

        If dsMain.Tables.Contains("Master") Then
            dsMain.Tables("Master").Clear()
        End If
        adtMaster.Fill(dsMain, "Master")

        adtDetail.SelectCommand.Parameters.Clear()

        cboTemp = New SqlCommandBuilder(adtDetail)
        adtDetail.InsertCommand = cboTemp.GetInsertCommand()
        adtDetail.UpdateCommand = cboTemp.GetUpdateCommand()
        adtDetail.DeleteCommand = cboTemp.GetDeleteCommand()
        If dsMain.Tables.Contains("Detail") Then
            dsMain.Tables("Detail").Clear()
        End If
        adtDetail.Fill(dsMain, "Detail")
        dvDetail = New DataView(dsMain.Tables("Detail"))

    End Sub
#End Region

   


End Module
