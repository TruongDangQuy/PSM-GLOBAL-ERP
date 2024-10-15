Imports System.Data.SqlClient
Module DIM_K9991
    Public Structure T9991_AREA
        '=========================================================================================================================================================
        '       ÇÊµå¸í                      ¼³¸í(ÇÊµå¸í)        Å¸ÀÔ(±æÀÌ)      Å°      ºñ°í
        '=========================================================================================================================================================
        Dim SITE As String '¾÷¹«ºÐ·ù            CHAR(7)         *       "001":¿°»ö¹× ¸ÞÀÎ , "002": ÆíÁ÷ , "003", ºÀÁ¦ , "004"¹æÀû, "005"¹æÁ÷ : "006"¿ø°¡ ¹× °æ¿µ°ü¸®
        Dim PROG As String 'ÇÁ·Î±×·¥ÄÚµå       NVARCHAR(50)    *
        Dim PNAME As String 'ÇÁ·Î±×·¥¸í         NVARCHAR(100)
        '=========================================================================================================================================================
    End Structure

    Public D9991 As T9991_AREA  ' DB¿¡ °ü·ÃÇÏ º¯¼ö

    '=========================================================================================================================================================
    ' DIRECT READ : µ¥ÀÌÅ¸ Á¶È¸
    '=========================================================================================================================================================
    Public Function READ_PFK9991(SITE As String, PROG As String) As Boolean
        READ_PFK9991 = False
        Try

            SQL = " SELECT * FROM PFK9991 "
            SQL = SQL & " WHERE K9991_SITE  = '" & SITE & "' "
            SQL = SQL & "   AND K9991_PROG  = '" & PROG & "'  "
            cmd.CommandText = SQL
            cmd.CommandType = CommandType.Text
            cmd.Connection = cn
            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = True Then
                K9991_MOVE(rd)
                READ_PFK9991 = True
                rd.Close()
            Else
                Call D9991_CLEAR()
            End If
        Catch ex As Exception
            Call MsgBoxP("37", "WRITE_PFK9991")
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA WRITE : µ¥ÀÌÅ¸ÀúÀå
    '=========================================================================================================================================================
    Public Function WRITE_PFK9991(z9991 As T9991_AREA) As Boolean
        WRITE_PFK9991 = False
        Try

            Call NULL_ZERO(z9991)

            SQL = " INSERT INTO PFK9991 "
            SQL = SQL & " ( "
            SQL = SQL & " K9991_SITE,  "
            SQL = SQL & " K9991_PROG,  "
            SQL = SQL & " K9991_PNAME  "
            SQL = SQL & " ) VALUES (   "
            SQL = SQL & " '" & z9991.SITE & "', "
            SQL = SQL & " '" & z9991.PROG & "', "
            SQL = SQL & " '" & z9991.PNAME & "'  "
            SQL = SQL & "          ) "
            cmd.CommandText = SQL
            cmd.CommandType = CommandType.Text
            cmd.Connection = cn
            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If
            rd = cmd.ExecuteReader
            rd.Close()
            WRITE_PFK9991 = True

        Catch ex As Exception
            Call MsgBoxP("35", "WRITE_PFK9991")
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE : µ¥ÀÌÅ¸¼öÁ¤
    '=========================================================================================================================================================
    Public Function REWRITE_PFK9991(z9991 As T9991_AREA) As Boolean
        REWRITE_PFK9991 = False
        Try

            Call NULL_ZERO(z9991)


            SQL = " UPDATE PFK9991 SET "
            SQL = SQL & " K9991_PNAME = '" & z9991.PNAME & "' "
            SQL = SQL & " WHERE K9991_SITE  = '" & z9991.SITE & "'  "
            SQL = SQL & "   AND K9991_PROG  = '" & z9991.PROG & "'  "
            cmd.CommandText = SQL
            cmd.CommandType = CommandType.Text
            cmd.Connection = cn
            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If
            rd = cmd.ExecuteReader
            rd.Close()
            REWRITE_PFK9991 = True

        Catch ex As Exception
            Call MsgBoxP("36", "WRITE_PFK9991")
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA DELETE : µ¥ÀÌÅ¸»èÁ¦
    '=========================================================================================================================================================
    Public Function DELETE_PFK9991(z9991 As T9991_AREA) As Boolean
        DELETE_PFK9991 = False
        Try

            SQL = " DELETE FROM PFK9991 "
            SQL = SQL & " WHERE K9991_SITE  = '" & z9991.SITE & "'  "
            SQL = SQL & "   AND K9991_PROG  = '" & z9991.PROG & "'  "
            cmd.CommandText = SQL
            cmd.CommandType = CommandType.Text
            cmd.Connection = cn
            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If
            rd = cmd.ExecuteReader
            rd.Close()
            DELETE_PFK9991 = True

        Catch ex As Exception
            Call MsgBoxP("38", "DELETE_PFK9991")
        End Try

    End Function

    '=========================================================================================================================================================
    ' CLEAR : ¹è¿­º¯¼ö »èÁ¦
    '=========================================================================================================================================================
    Public Sub D9991_CLEAR()
        Try

            D9991.PNAME = ""

        Catch ex As Exception
            Call MsgBoxP("39", "D9991_CLEAR")
        End Try

    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(x9991 As T9991_AREA)
        Try

            x9991.PROG = Trim(x9991.PROG)
            x9991.PNAME = Trim(x9991.PNAME)

            If Trim(x9991.SITE) = "" Then x9991.SITE = Space(1)
            If Trim(x9991.PROG) = "" Then x9991.PROG = Space(1)
            If Trim(x9991.PNAME) = "" Then x9991.PNAME = Space(1)

        Catch ex As Exception
            Call MsgBoxP("40", "NULL_ZERO")
        End Try

    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE
    '=========================================================================================================================================================
    Public Sub K9991_MOVE(rs9991 As SqlDataReader, Optional CHK As Boolean = True)
        Try

            If IsDBNull(rs9991("K9991_SITE")) = False Then D9991.SITE = Trim(rs9991("K9991_SITE"))
            If IsDBNull(rs9991("K9991_PROG")) = False Then D9991.PROG = Trim(rs9991("K9991_PROG"))
            If IsDBNull(rs9991("K9991_PNAME")) = False Then D9991.PNAME = Trim(rs9991("K9991_PNAME"))

        Catch ex As Exception
            Call MsgBoxP("41", "K9991 MOVE")
        End Try

    End Sub

End Module
