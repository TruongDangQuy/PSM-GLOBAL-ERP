Imports System.Data.SqlClient
Module DIM_K9901
    Public Structure T9901_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Dim NotifyCate As String        '       char(8)	
        Dim NotifyCateSeq As Decimal    '       decimal(18, 0)	
        Dim DSeq As Decimal             '       decimal(18, 0)	
        Dim Name As String              '       nvarchar(20)	
        Dim CheckUse As String          '       char(1)	
        Dim DateCreate As String        '       char(8)	
        Dim InchargeCreate As String    '       char(8)	
        Dim DateUpdate As String        '       char(8)	
        Dim InchargeUpdate As String    '       char(8)	
        '=========================================================================================================================================================
    End Structure

    Public D9901 As T9901_AREA

    '=========================================================================================================================================================
    ' DIRECT READ
    '=========================================================================================================================================================
    Public Function READ_PFK9901(NotifyCate As String, NotifyCateSeq As String) As Boolean

        READ_PFK9901 = False

        Try

            SQL = " SELECT * FROM PFK9901 "
            SQL = SQL & " WHERE K9901_NotifyCate              = '" & NotifyCate & "' "
            SQL = SQL & "   AND K9901_NotifyCateSeq               = '" & NotifyCateSeq & "' "
            cmd.CommandText = SQL
            cmd.CommandType = CommandType.Text
            cmd.Connection = cn
            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = True Then
                K9901_MOVE(rd)
                READ_PFK9901 = True
                rd.Close()
            Else
                Call D9901_CLEAR()
            End If
        Catch ex As Exception
            Call MsgBoxP("37", "READ_PFK9901")
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA WRITE
    '=========================================================================================================================================================
    Public Function WRITE_PFK9901(z9901 As T9901_AREA) As Boolean
        WRITE_PFK9901 = False
        Try

            Call NULL_ZERO(z9901)

            SQL = " INSERT INTO PFK9901 "
            SQL = SQL & " ( "
            SQL = SQL & " K9901_NotifyCate,"
            SQL = SQL & " K9901_NotifyCateSeq,"
            SQL = SQL & " K9901_DSeq,"
            SQL = SQL & " K9901_Name,"
            SQL = SQL & " K9901_CheckUse,"
            SQL = SQL & " K9901_DateCreate,"
            SQL = SQL & " K9901_InchargeCreate,"
            SQL = SQL & " K9901_DateUpdate,"
            SQL = SQL & " K9901_InchargeUpdate "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  '" & z9901.NotifyCate & "', "
            SQL = SQL & "  '" & z9901.NotifyCateSeq & "', "
            SQL = SQL & "  '" & z9901.DSeq & "', "
            SQL = SQL & "  '" & z9901.Name & "', "
            SQL = SQL & "  '" & z9901.CheckUse & "', "
            SQL = SQL & "  '" & z9901.DateCreate & "', "
            SQL = SQL & "  '" & z9901.InchargeCreate & "', "
            SQL = SQL & "  '" & z9901.DateUpdate & "', "
            SQL = SQL & "  '" & z9901.InchargeUpdate & "'  "
            SQL = SQL & " ) "
            cmd.CommandText = SQL
            cmd.CommandType = CommandType.Text
            cmd.Connection = cn
            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If
            rd = cmd.ExecuteReader
            rd.Close()
            WRITE_PFK9901 = True

        Catch ex As Exception
            Call MsgBoxP("35", "WRITE_PFK9901")
        End Try


    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE
    '=========================================================================================================================================================
    Public Function REWRITE_PFK9901(z9901 As T9901_AREA) As Boolean
        REWRITE_PFK9901 = False
        Try

            Call NULL_ZERO(z9901)

            SQL = " UPDATE PFK9901 SET "
            SQL = SQL & "	   K9901_DSeq					= '" & z9901.DSeq & "'  "
            SQL = SQL & "     ,K9901_Name					= '" & z9901.Name & "'  "
            SQL = SQL & "     ,K9901_CheckUse				= '" & z9901.CheckUse & "'  "
            SQL = SQL & "     ,K9901_DateCreate			    = '" & z9901.DateCreate & "'  "
            SQL = SQL & "     ,K9901_InchargeCreate		    = '" & z9901.InchargeCreate & "'  "
            SQL = SQL & "     ,K9901_DateUpdate			    = '" & z9901.DateUpdate & "'  "
            SQL = SQL & "     ,K9901_InchargeUpdate		    = '" & z9901.InchargeUpdate & "'  "

            SQL = SQL & " WHERE K9901_NotifyCate              = '" & z9901.NotifyCate & "' "
            SQL = SQL & "   AND K9901_NotifyCateSeq               = '" & z9901.NotifyCateSeq & "' "
            cmd.CommandText = SQL
            cmd.CommandType = CommandType.Text
            cmd.Connection = cn
            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If
            rd = cmd.ExecuteReader
            rd.Close()
            REWRITE_PFK9901 = True

        Catch ex As Exception
            Call MsgBoxP("36", "REWRITE_PFK9901")
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA DELETE
    '=========================================================================================================================================================
    Public Function DELETE_PFK9901(z9901 As T9901_AREA) As Boolean
        DELETE_PFK9901 = False
        Try

            SQL = " DELETE FROM PFK9901 "
            SQL = SQL & " WHERE K9901_NotifyCate              = '" & z9901.NotifyCate & "' "
            SQL = SQL & "   AND K9901_NotifyCateSeq               = '" & z9901.NotifyCateSeq & "' "
            cmd.CommandText = SQL
            cmd.CommandType = CommandType.Text
            cmd.Connection = cn
            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If
            rd = cmd.ExecuteReader
            rd.Close()
            DELETE_PFK9901 = True

        Catch ex As Exception
            Call MsgBoxP("38", "DELETE_PFK9901")
        End Try

    End Function

    '=========================================================================================================================================================
    ' CLEAR
    '=========================================================================================================================================================
    Public Sub D9901_CLEAR()
        Try

            D9901.NotifyCate = ""
            D9901.NotifyCateSeq = 0
            D9901.DSeq = 0
            D9901.Name = ""
            D9901.CheckUse = ""
            D9901.DateCreate = ""
            D9901.InchargeCreate = ""
            D9901.DateUpdate = ""
            D9901.InchargeUpdate = ""

        Catch ex As Exception
            Call MsgBoxP("39", "D9901_CLEAR")
        End Try

    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(x9901 As T9901_AREA)
        Try

            x9901.NotifyCate = Trim(x9901.NotifyCate)
            x9901.NotifyCateSeq = Trim(x9901.NotifyCateSeq)
            x9901.DSeq = Trim(x9901.DSeq)
            x9901.Name = Trim(x9901.Name)
            x9901.CheckUse = Trim(x9901.CheckUse)
            x9901.DateCreate = Trim(x9901.DateCreate)
            x9901.InchargeCreate = Trim(x9901.InchargeCreate)
            x9901.DateUpdate = Trim(x9901.DateUpdate)
            x9901.InchargeUpdate = Trim(x9901.InchargeUpdate)

            If Trim(x9901.NotifyCate) = "" Then x9901.NotifyCate = Space(1)
            If Trim(x9901.NotifyCateSeq) = "" Then x9901.NotifyCateSeq = Space(1)
            If Trim(x9901.DSeq) = "" Then x9901.DSeq = Space(1)
            If Trim(x9901.Name) = "" Then x9901.Name = Space(1)
            If Trim(x9901.CheckUse) = "" Then x9901.CheckUse = Space(1)
            If Trim(x9901.DateCreate) = "" Then x9901.DateCreate = Space(1)
            If Trim(x9901.InchargeCreate) = "" Then x9901.InchargeCreate = Space(1)
            If Trim(x9901.DateUpdate) = "" Then x9901.DateUpdate = Space(1)
            If Trim(x9901.InchargeUpdate) = "" Then x9901.InchargeUpdate = Space(1)

        Catch ex As Exception
            Call MsgBoxP("40", "NULL_ZERO")
        End Try

    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE
    '=========================================================================================================================================================
    Public Sub K9901_MOVE(rs9901 As SqlDataReader)
        Try

            Call D9901_CLEAR()

            If IsDBNull(rs9901("K9901_NotifyCate")) = False Then D9901.NotifyCate = Trim(rs9901("K9901_NotifyCate"))
            If IsDBNull(rs9901("K9901_NotifyCateSeq")) = False Then D9901.NotifyCateSeq = Trim(rs9901("K9901_NotifyCateSeq"))
            If IsDBNull(rs9901("K9901_DSeq")) = False Then D9901.DSeq = Trim(rs9901("K9901_DSeq"))
            If IsDBNull(rs9901("K9901_Name")) = False Then D9901.Name = Trim(rs9901("K9901_Name"))
            If IsDBNull(rs9901("K9901_CheckUse")) = False Then D9901.CheckUse = Trim(rs9901("K9901_CheckUse"))
            If IsDBNull(rs9901("K9901_DateCreate")) = False Then D9901.DateCreate = Trim(rs9901("K9901_DateCreate"))
            If IsDBNull(rs9901("K9901_InchargeCreate")) = False Then D9901.InchargeCreate = Trim(rs9901("K9901_InchargeCreate"))
            If IsDBNull(rs9901("K9901_DateUpdate")) = False Then D9901.DateUpdate = Trim(rs9901("K9901_DateUpdate"))
            If IsDBNull(rs9901("K9901_InchargeUpdate")) = False Then D9901.InchargeUpdate = Trim(rs9901("K9901_InchargeUpdate"))

        Catch ex As Exception
            Call MsgBoxP("41", "K9901_MOVE")
        End Try

    End Sub
End Module
