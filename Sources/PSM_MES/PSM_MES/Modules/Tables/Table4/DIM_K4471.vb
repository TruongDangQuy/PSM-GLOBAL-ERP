Module DIM_K4471
    Public Structure T4471_AREA
        Dim Sel As String
        Dim CODE As String
        Dim NAME As String
        Dim AMT As Double
        Dim SEQ As String
        Dim CHK1 As String
        Dim CHK2 As String
        Dim CHK3 As String
        Dim CHK4 As String
        Dim CHK5 As String
    End Structure

    Public D4471 As T4471_AREA
    Public Function READ_PFK4471(Sel As String, CODE As String) As Boolean
        READ_PFK4471 = False
        Try
            SQL = " SELECT * FROM PFK4471 "
            SQL = SQL & " WHERE K4471_SEL        = '" & Sel & "'  " '
            SQL = SQL & "   AND K4471_CODE       = '" & CODE & "'  " '
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = True Then
                READ_PFK4471 = True
                K4471_MOVE(rd)
            Else
                D4471_CLEAR()
            End If
            rd.Close()
        Catch ex As Exception
            MsgBoxP("37", "READ_PFK4471")
        End Try
    End Function
    Public Sub D4471_CLEAR()
        Try
            D4471.NAME = ""
            D4471.AMT = 0
            D4471.SEQ = ""
            D4471.CHK1 = ""
            D4471.CHK2 = ""
            D4471.CHK3 = ""
            D4471.CHK4 = ""
            D4471.CHK5 = ""
        Catch ex As Exception
            MsgBoxP("39", "D4471_CLEAR")
        End Try
    End Sub
    Public Sub K4471_MOVE(rs4471 As SqlClient.SqlDataReader)
        Try
            If IsDBNull(rs4471("K4471_SEL")) = False Then D4471.Sel = Trim(rs4471("K4471_SEL"))
            If IsDBNull(rs4471("K4471_CODE")) = False Then D4471.CODE = Trim(rs4471("K4471_CODE"))
            If IsDBNull(rs4471("K4471_NAME")) = False Then D4471.NAME = Trim(rs4471("K4471_NAME"))
            If IsDBNull(rs4471("K4471_AMT")) = False Then D4471.AMT = Trim(rs4471("K4471_AMT"))
            If IsDBNull(rs4471("K4471_SEQ")) = False Then D4471.SEQ = Trim(rs4471("K4471_SEQ"))
            If IsDBNull(rs4471("K4471_CHK1")) = False Then D4471.CHK1 = Trim(rs4471("K4471_CHK1"))
            If IsDBNull(rs4471("K4471_CHK2")) = False Then D4471.CHK2 = Trim(rs4471("K4471_CHK2"))
            If IsDBNull(rs4471("K4471_CHK3")) = False Then D4471.CHK3 = Trim(rs4471("K4471_CHK3"))
            If IsDBNull(rs4471("K4471_CHK4")) = False Then D4471.CHK4 = Trim(rs4471("K4471_CHK4"))
            If IsDBNull(rs4471("K4471_CHK5")) = False Then D4471.CHK5 = Trim(rs4471("K4471_CHK5"))
        Catch ex As Exception
            MsgBoxP("41", "K4471_MOVE")
        End Try
    End Sub
    Public Sub K4471_MOVE(rs4471 As DataRow)
        Try
            If IsDBNull(rs4471("K4471_SEL")) = False Then D4471.Sel = Trim(rs4471("K4471_SEL"))
            If IsDBNull(rs4471("K4471_CODE")) = False Then D4471.CODE = Trim(rs4471("K4471_CODE"))
            If IsDBNull(rs4471("K4471_NAME")) = False Then D4471.NAME = Trim(rs4471("K4471_NAME"))
            If IsDBNull(rs4471("K4471_AMT")) = False Then D4471.AMT = Trim(rs4471("K4471_AMT"))
            If IsDBNull(rs4471("K4471_SEQ")) = False Then D4471.SEQ = Trim(rs4471("K4471_SEQ"))
            If IsDBNull(rs4471("K4471_CHK1")) = False Then D4471.CHK1 = Trim(rs4471("K4471_CHK1"))
            If IsDBNull(rs4471("K4471_CHK2")) = False Then D4471.CHK2 = Trim(rs4471("K4471_CHK2"))
            If IsDBNull(rs4471("K4471_CHK3")) = False Then D4471.CHK3 = Trim(rs4471("K4471_CHK3"))
            If IsDBNull(rs4471("K4471_CHK4")) = False Then D4471.CHK4 = Trim(rs4471("K4471_CHK4"))
            If IsDBNull(rs4471("K4471_CHK5")) = False Then D4471.CHK5 = Trim(rs4471("K4471_CHK5"))
        Catch ex As Exception
            MsgBoxP("41", "K4471_MOVE")
        End Try
    End Sub
    Public Function WRITE_PFK4471(z4471 As T4471_AREA) As Boolean
        WRITE_PFK4471 = False
        Try
            Call NULL_ZERO(z4471)
            SQL = " INSERT INTO PFK4471 "
            SQL = SQL & " ( "
            SQL = SQL & " K4471_SEL,"
            SQL = SQL & " K4471_CODE,"
            SQL = SQL & " K4471_NAME,"
            SQL = SQL & " K4471_AMT,"
            SQL = SQL & " K4471_SEQ,"
            SQL = SQL & " K4471_CHK1,"
            SQL = SQL & " K4471_CHK2,"
            SQL = SQL & " K4471_CHK3,"
            SQL = SQL & " K4471_CHK4,"
            SQL = SQL & " K4471_CHK5 "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  '" & z4471.Sel & "', "
            SQL = SQL & "  '" & z4471.CODE & "', "
            SQL = SQL & "  '" & z4471.NAME & "', "
            SQL = SQL & "   " & z4471.AMT & " , "
            SQL = SQL & "  '" & z4471.SEQ & "', "
            SQL = SQL & "  '" & z4471.CHK1 & "', "
            SQL = SQL & "  '" & z4471.CHK2 & "', "
            SQL = SQL & "  '" & z4471.CHK3 & "', "
            SQL = SQL & "  '" & z4471.CHK4 & "', "
            SQL = SQL & "  '" & z4471.CHK5 & "'  "
            SQL = SQL & "          ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()
            WRITE_PFK4471 = True

        Catch ex As Exception
            Call MsgBoxP("35", "WRITE_PFK4471")
        End Try
    End Function
    Public Function REWRITE_PFK4471(z4471 As T4471_AREA) As Boolean
        REWRITE_PFK4471 = False
        Try

            Call NULL_ZERO(z4471)
            SQL = " UPDATE PFK4471 SET "
            SQL = SQL & " K4471_NAME      = '" & z4471.NAME & "', "
            SQL = SQL & " K4471_AMT      =  " & z4471.AMT & " , "
            SQL = SQL & " K4471_SEQ      = '" & z4471.SEQ & "', "
            SQL = SQL & " K4471_CHK1      = '" & z4471.CHK1 & "', "
            SQL = SQL & " K4471_CHK2      = '" & z4471.CHK2 & "', "
            SQL = SQL & " K4471_CHK3      = '" & z4471.CHK3 & "', "
            SQL = SQL & " K4471_CHK4      = '" & z4471.CHK4 & "', "
            SQL = SQL & " K4471_CHK5      = '" & z4471.CHK5 & "'  "
            SQL = SQL & " WHERE K4471_SEL        = '" & z4471.Sel & "'  " '
            SQL = SQL & "   AND K4471_CODE       = '" & z4471.CODE & "'  " '
            'cn.Execute(SQL) : If Pub.SET = "2" Then cn.Commit()
            'Call HISTORY_DATA("4471", SQL, "u")
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()
            REWRITE_PFK4471 = True

        Catch ex As Exception
            Call MsgBoxP("36", "WRITE_PFK4471")
        End Try
    End Function
    Public Function DELETE_PFK4471(z4471 As T4471_AREA) As Boolean
        DELETE_PFK4471 = False
        Try
            SQL = " DELETE FROM PFK4471 "
            SQL = SQL & " WHERE K4471_SEL        = '" & z4471.Sel & "'  " '
            SQL = SQL & "   AND K4471_CODE       = '" & z4471.CODE & "'  " '
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()
            DELETE_PFK4471 = True
        Catch ex As Exception
            Call MsgBoxP("38", "DELETE_PFK4471")
        End Try
    End Function
    Private Sub NULL_ZERO(x4471 As T4471_AREA)
        Try
            x4471.Sel = Trim$(x4471.Sel)
            x4471.CODE = Trim$(x4471.CODE)
            x4471.NAME = Trim$(x4471.NAME)
            x4471.AMT = Trim$(x4471.AMT)
            x4471.SEQ = Trim$(x4471.SEQ)
            x4471.CHK1 = Trim$(x4471.CHK1)
            x4471.CHK2 = Trim$(x4471.CHK2)
            x4471.CHK3 = Trim$(x4471.CHK3)
            x4471.CHK4 = Trim$(x4471.CHK4)
            x4471.CHK5 = Trim$(x4471.CHK5)

            If Trim$(x4471.Sel) = "" Then x4471.Sel = Space(1)
            If Trim$(x4471.CODE) = "" Then x4471.CODE = Space(1)
            If Trim$(x4471.NAME) = "" Then x4471.NAME = Space(1)
            If Trim$(x4471.AMT) = "" Then x4471.AMT = 0
            If Trim$(x4471.SEQ) = "" Then x4471.SEQ = Space(1)
            If Trim$(x4471.CHK1) = "" Then x4471.CHK1 = Space(1)
            If Trim$(x4471.CHK2) = "" Then x4471.CHK2 = Space(1)
            If Trim$(x4471.CHK3) = "" Then x4471.CHK3 = Space(1)
            If Trim$(x4471.CHK4) = "" Then x4471.CHK4 = Space(1)
            If Trim$(x4471.CHK5) = "" Then x4471.CHK5 = Space(1)
        Catch ex As Exception
            Call MsgBoxP("40", "NULL_ZERO")
        End Try
    End Sub
End Module
