Imports System.Data.SqlClient
Imports System.Resources
Imports System.Object

Module M_Reader

#Region "Variable"
    Public language As ResourceManager

#End Region

#Region "Methods"
    'Public Function READ_PFK7171_KCHK10(KSEL As String, KCHK10 As String, KCHK1 As String, KCHK2 As String, Optional CHK As Boolean = True) As Boolean
    '    READ_PFK7171_KCHK10 = False
    '    Try
    '        SQL = " SELECT * FROM PFK7171 "
    '        SQL = SQL & " WHERE K7171_KSEL  = '" & KSEL & "'  "
    '        SQL = SQL & "   AND K7171_KCHK10 = '" & KCHK10 & "' "
    '        SQL = SQL & "   AND K7171_KCHK1 = '" & KCHK1 & "' "
    '        SQL = SQL & "   AND K7171_KCHK2 = '" & KCHK2 & "' "
    '        cmd = New SqlClient.SqlCommand(SQL, cn)
    '        rd = cmd.ExecuteReader
    '        rd.Read()
    '        If rd.HasRows = False Then Call D7171_CLEAR() : rd.Close() : Exit Function
    '        Call K7171_MOVE(rd, CHK)
    '        rd.Close()
    '    READ_PFK7171_KCHK10 = True
    '    Catch ex As Exception
    '        Call MsgBoxP("37", "READ_PFK7171_KCHK10")
    '    End Try

    'End Function
    Public Function READ_PFK4471N(Sel As String, NAME As String) As Boolean

        READ_PFK4471N = False

        SQL = " SELECT * FROM PFK4471 "
        SQL = SQL & " WHERE K4471_SEL  = '" & Sel & "'  "  '
        SQL = SQL & "   AND K4471_NAME = '" & NAME & "'  " '
        cmd = New SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = False Then Call D4471_CLEAR() : GoTo pass

        Call K4471_MOVE(rd)

        READ_PFK4471N = True
pass:
        rd.Close()

    End Function
    Public Function READ_PFK7101N(GNAME As String) As Boolean
        READ_PFK7101N = False
        Try

            SQL = " SELECT * FROM PFK7101 "
            SQL = SQL & "  WHERE K7101_GNAME = '" & GNAME & "'  " '
            cmd = New SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = True Then
                D7101_CLEAR()
                K7101_MOVE(rd)
                READ_PFK7101N = True
            End If
            D7101_CLEAR()
            rd.Close()
        Catch ex As Exception
            Call MsgBoxP("37", "READ_PFK7101N")
        End Try

    End Function
    Public Function READ_PFK7231N(Jname As String) As Boolean

        READ_PFK7231N = False

        SQL = " SELECT * FROM PFK7231 "
        SQL = SQL & " WHERE K7231_JNAME = '" & Jname & "'  " '
        cmd = New SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = False Then Call D7231_CLEAR() : rd.Close() : Exit Function

        Call K7231_MOVE(rd)

        READ_PFK7231N = True
        rd.Close()

    End Function
    Public Function READ_PFK7231S(CCKNO As String) As Boolean

        READ_PFK7231S = False

        If Trim$(CCKNO) = "" Then Exit Function

        SQL = " SELECT * FROM PFK7231 "
        SQL = SQL & " WHERE K7231_SAYANG03 = '" & CCKNO & "' "
        cmd = New SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If rd.HasRows = False Then Call D7231_CLEAR() : rd.Close() : Exit Function

        Call K7231_MOVE(rd)


        READ_PFK7231S = True

        rd.Close()

    End Function
    Public Function READ_PFK7231F(TNO As String) As Boolean

        READ_PFK7231F = False

        SQL = " SELECT * FROM PFK7231 "
        SQL = SQL & " WHERE ( K7231_SAYANG03 = '" & TNO & "' OR K7231_SAYANG04 = '" & TNO & "' ) "
        SQL = SQL & "   AND K7231_MSORT <> '001'"
        cmd = New SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If rd.HasRows = False Then Call D7231_CLEAR() : rd.Close() : Exit Function

        Call K7231_MOVE(rd)

        READ_PFK7231F = True
        rd.Close()

    End Function
    Public Function READ_PFK7231G(TNO As String) As Boolean

        READ_PFK7231G = False

        SQL = " SELECT * FROM PFK7231 "
        SQL = SQL & " WHERE K7231_SAYANG01 = '" & TNO & "'  " '
        SQL = SQL & "   AND K7231_MSORT = '001'"
        cmd = New SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If rd.HasRows = False Then Call D7231_CLEAR() : rd.Close() : Exit Function

        Call K7231_MOVE(rd)

        READ_PFK7231G = True
        rd.Close()

    End Function
    Public Function READ_PFK9992_IDNO_CHECK(SITE As String, IDNO As String, ID As String) As Boolean
        READ_PFK9992_IDNO_CHECK = False
        Try

            SQL = " SELECT * FROM PFK9992 "
            SQL = SQL & "  WHERE ltrim(K9992_ID) = '" & ID & "'  " '
            SQL = SQL & "   AND K9992_SITE <> '" & SITE & "'  " '
            SQL = SQL & "   AND K9992_SANO <> '" & IDNO & "'  " '
            cmd = New SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = True Then
                Call K9992_MOVE(rd)

                READ_PFK9992_IDNO_CHECK = True
            End If

            rd.Close()
        Catch ex As Exception
            Call MsgBoxP("37", "READ_PFK9992_IDNO_CHECK")
        End Try

    End Function
#End Region
    
End Module
