Imports System.Data.SqlClient
Module DIM_K9902
    Public Structure T9902_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Dim NotifyCate As String '			char(8)	
        Dim NotifyCateSeq As Decimal  '		decimal(18, 0)	
        Dim Notify As String  '				char(8)	
        Dim NotifySeq As Decimal '			decimal(18, 0)	
        Dim DSeq As Decimal      '			decimal(18, 0)	
        Dim cdFactory As String '			char(30)	
        Dim DoucmentName As String  '		nvarchar(200)	
        Dim FileName As String      '		nvarchar(200)	
        Dim ImageData As String  '			varbinary(MAX)	
        Dim FileType As String     '		nvarchar(10)	
        Dim CheckMain As String '			char(1)	
        Dim CheckType As String '			char(1)	
        Dim AttachDate As String '		    char(8)	
        Dim AttachIncharge As String ' 		char(8)	
        Dim Time As String     '			nvarchar(20)	
        Dim IsInsert As String     '		char(1)	
        Dim DateInsert As String '			char(8)	
        Dim DateUpdate As String '		    char(8)	
        '=========================================================================================================================================================
    End Structure

    Public D9902 As T9902_AREA

    '=========================================================================================================================================================
    ' DIRECT READ
    '=========================================================================================================================================================
    Public Function READ_PFK9902(NotifyCate As String, NotifyCateSeq As Decimal, Notify As String, NotifySeq As Decimal) As Boolean

        READ_PFK9902 = False

        Try

            SQL = " SELECT * FROM PFK9902 "
            SQL = SQL & " WHERE K9902_NotifyCate                  = '" & NotifyCate & "' "
            SQL = SQL & "   AND K9902_NotifyCateSeq               = '" & NotifyCateSeq & "' "
            SQL = SQL & "   AND K9902_Notify               = '" & Notify & "' "
            SQL = SQL & "   AND K9902_NotifySeq               = '" & NotifySeq & "' "
            cmd.CommandText = SQL
            cmd.CommandType = CommandType.Text
            cmd.Connection = cn
            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = True Then
                K9902_MOVE(rd)
                READ_PFK9902 = True
                rd.Close()
            Else
                Call D9902_CLEAR()
            End If
        Catch ex As Exception
            Call MsgBoxP("37", "READ_PFK9902")
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA WRITE
    '=========================================================================================================================================================
    Public Function WRITE_PFK9902(z9902 As T9902_AREA) As Boolean
        WRITE_PFK9902 = False
        Try

            Call NULL_ZERO(z9902)

            'SQL = " INSERT INTO PFK9902 "
            'SQL = SQL & " ( "
            'SQL = SQL & " K9902_JDATE,"
            'SQL = SQL & " K9902_JCHK,"
            'SQL = SQL & " K9902_REMK "
            'SQL = SQL & " ) VALUES ( "
            'SQL = SQL & "  '" & z9902.JDATE & "', "
            'SQL = SQL & "  '" & z9902.JCHK & "', "
            'SQL = SQL & "  '" & z9902.REMK & "'  "
            'SQL = SQL & " ) "
            'cmd.CommandText = SQL
            'cmd.CommandType = CommandType.Text
            'cmd.Connection = cn
            'If cn.State = ConnectionState.Closed Then
            '    cn.Open()
            'End If
            'rd = cmd.ExecuteReader
            'rd.Close()
            WRITE_PFK9902 = True

        Catch ex As Exception
            Call MsgBoxP("35", "WRITE_PFK9902")
        End Try


    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE
    '=========================================================================================================================================================
    Public Function REWRITE_PFK9902(z9902 As T9902_AREA) As Boolean
        REWRITE_PFK9902 = False
        Try

            Call NULL_ZERO(z9902)

            'SQL = " UPDATE PFK9902 SET "
            'SQL = SQL & "    K9902_REMK      = '" & z9902.REMK & "'  "
            'SQL = SQL & "   WHERE K9902_JDATE              = '" & z9902.JDATE & "' "
            'SQL = SQL & "   AND K9902_JCHK               = '" & z9902.JCHK & "' "
            'cmd.CommandText = SQL
            'cmd.CommandType = CommandType.Text
            'cmd.Connection = cn
            'If cn.State = ConnectionState.Closed Then
            '    cn.Open()
            'End If
            'rd = cmd.ExecuteReader
            'rd.Close()
            REWRITE_PFK9902 = True

        Catch ex As Exception
            Call MsgBoxP("36", "REWRITE_PFK9902")
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA DELETE
    '=========================================================================================================================================================
    Public Function DELETE_PFK9902(z9902 As T9902_AREA) As Boolean
        DELETE_PFK9902 = False
        Try

            'SQL = " DELETE FROM PFK9902 "
            'SQL = SQL & " WHERE K9902_JDATE              = '" & z9902.JDATE & "' "
            'SQL = SQL & "   AND K9902_JCHK               = '" & z9902.JCHK & "' "
            'cmd.CommandText = SQL
            'cmd.CommandType = CommandType.Text
            'cmd.Connection = cn
            'If cn.State = ConnectionState.Closed Then
            '    cn.Open()
            'End If
            'rd = cmd.ExecuteReader
            'rd.Close()
            DELETE_PFK9902 = True

        Catch ex As Exception
            Call MsgBoxP("38", "DELETE_PFK9902")
        End Try

    End Function

    '=========================================================================================================================================================
    ' CLEAR
    '=========================================================================================================================================================
    Public Sub D9902_CLEAR()
        Try

            'D9902.JDATE = ""
            'D9902.JCHK = ""
            'D9902.REMK = ""

        Catch ex As Exception
            Call MsgBoxP("39", "D9902_CLEAR")
        End Try

    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(x9902 As T9902_AREA)
        Try

            'x9902.JDATE = Trim(x9902.JDATE)
            'x9902.JCHK = Trim(x9902.JCHK)
            'x9902.REMK = Trim(x9902.REMK)

            'If Trim(x9902.JDATE) = "" Then x9902.JDATE = Space(1)
            'If Trim(x9902.JCHK) = "" Then x9902.JCHK = Space(1)
            'If Trim(x9902.REMK) = "" Then x9902.REMK = Space(1)

        Catch ex As Exception
            Call MsgBoxP("40", "NULL_ZERO")
        End Try

    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE
    '=========================================================================================================================================================
    Public Sub K9902_MOVE(rs9902 As SqlDataReader)
        Try

            Call D9902_CLEAR()

            'If IsDBNull(rs9902("K9902_JDATE")) = False Then D9902.JDATE = Trim(rs9902("K9902_JDATE"))
            'If IsDBNull(rs9902("K9902_JCHK")) = False Then D9902.JCHK = Trim(rs9902("K9902_JCHK"))
            'If IsDBNull(rs9902("K9902_REMK")) = False Then D9902.REMK = Trim(rs9902("K9902_REMK"))

        Catch ex As Exception
            Call MsgBoxP("41", "K9902_MOVE")
        End Try

    End Sub


End Module
