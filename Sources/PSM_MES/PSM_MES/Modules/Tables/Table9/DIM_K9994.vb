'=========================================================================================================================================================
'   TABLE : (PFK9994)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K9994

    Structure T9994_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public SITE As String  '			char(3)		*
        Public GROUP As String  '			char(3)		*
        Public PROG As String  '			varchar(30)		*

        Public PROGRAMNAME As String  '		varchar(200)		*
        Public PROGRAMNAME1 As String  '	varchar(200)		*
        Public PROGRAMNAME2 As String  '	varchar(200)		*
        Public AFTERPROG As String  '		varchar(30)		*

        Public PCHK As String  '			char(1)
        '=========================================================================================================================================================
    End Structure

    Public D9994 As T9994_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK9994(SITE As String, GROUP As String, PROG As String) As Boolean
        READ_PFK9994 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK9994 "
            SQL = SQL & " WHERE K9994_SITE		 = '" & SITE & "' "
            SQL = SQL & "   AND K9994_GROUP		 = '" & GROUP & "' "
            SQL = SQL & "   AND K9994_PROG		 = '" & PROG & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D9994_CLEAR() : GoTo SKIP_READ_PFK9994

            Call K9994_MOVE(rd)
            READ_PFK9994 = True

SKIP_READ_PFK9994:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK9994", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK9994(SITE As String, GROUP As String, PROG As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK9994 "
            SQL = SQL & " WHERE K9994_SITE		 = '" & SITE & "' "
            SQL = SQL & "   AND K9994_GROUP		 = '" & GROUP & "' "
            SQL = SQL & "   AND K9994_PROG		 = '" & PROG & "' "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK9994", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK9994(z9994 As T9994_AREA) As Boolean
        WRITE_PFK9994 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z9994)

            SQL = " INSERT INTO PFK9994 "
            SQL = SQL & " ( "
            SQL = SQL & " K9994_SITE,"
            SQL = SQL & " K9994_GROUP,"
            SQL = SQL & " K9994_PROG,"
            SQL = SQL & " K9994_ProgramName,"
            SQL = SQL & " K9994_ProgramName1,"
            SQL = SQL & " K9994_ProgramName2,"

            SQL = SQL & " K9994_AFTERPROG,"
            SQL = SQL & " K9994_PCHK "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  '" & z9994.SITE & "', "
            SQL = SQL & "  '" & z9994.GROUP & "', "
            SQL = SQL & "  '" & z9994.PROG & "', "
            SQL = SQL & "  '" & z9994.ProgramName & "', "
            SQL = SQL & "  '" & z9994.ProgramName1 & "', "
            SQL = SQL & "  '" & z9994.ProgramName2 & "', "
            SQL = SQL & "  '" & z9994.AFTERPROG & "', "
            SQL = SQL & "  '" & z9994.PCHK & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK9994 = True
            Exit Function
        Catch ex As Exception
            'Call MsgBoxP("WRITE_PFK9994",vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK9994(z9994 As T9994_AREA) As Boolean
        REWRITE_PFK9994 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z9994)

            SQL = " UPDATE PFK9994 SET "
            SQL = SQL & "    K9994_ProgramName      = '" & z9994.ProgramName & "',  "
            SQL = SQL & "    K9994_ProgramName1     = '" & z9994.ProgramName1 & "',  "
            SQL = SQL & "    K9994_ProgramName2     = '" & z9994.ProgramName2 & "',  "
            SQL = SQL & "    K9994_PCHK      = '" & z9994.PCHK & "',  "
            SQL = SQL & "    K9994_AFTERPROG      = '" & z9994.AFTERPROG & "'  "

            SQL = SQL & " WHERE K9994_SITE		 = '" & z9994.SITE & "' "
            SQL = SQL & "   AND K9994_GROUP		 = '" & z9994.GROUP & "' "
            SQL = SQL & "   AND K9994_PROG		 = '" & z9994.PROG & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK9994 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK9994", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK9994(z9994 As T9994_AREA) As Boolean
        DELETE_PFK9994 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK9994 "
            SQL = SQL & " WHERE K9994_SITE		 = '" & z9994.SITE & "' "
            SQL = SQL & "   AND K9994_GROUP		 = '" & z9994.GROUP & "' "
            SQL = SQL & "   AND K9994_PROG		 = '" & z9994.PROG & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK9994 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK9994", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D9994_CLEAR()
        Try

            D9994.SITE = ""
            D9994.GROUP = ""
            D9994.PROG = ""
            D9994.ProgramName = ""
            D9994.ProgramName1 = ""
            D9994.ProgramName2 = ""
            D9994.PCHK = ""
            D9994.AFTERPROG = ""

            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D9994_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x9994 As T9994_AREA)
        Try

            x9994.SITE = trim$(x9994.SITE)
            x9994.GROUP = trim$(x9994.GROUP)
            x9994.PROG = trim$(x9994.PROG)
            x9994.ProgramName = Trim$(x9994.ProgramName)
            x9994.ProgramName1 = Trim$(x9994.ProgramName1)
            x9994.ProgramName2 = Trim$(x9994.ProgramName2)
            x9994.PCHK = Trim$(x9994.PCHK)
            x9994.AFTERPROG = Trim$(x9994.AFTERPROG)

            If trim$(x9994.SITE) = "" Then x9994.SITE = Space(1)
            If trim$(x9994.GROUP) = "" Then x9994.GROUP = Space(1)
            If trim$(x9994.PROG) = "" Then x9994.PROG = Space(1)
            If Trim$(x9994.ProgramName) = "" Then x9994.ProgramName = Space(1)
            If Trim$(x9994.ProgramName1) = "" Then x9994.ProgramName1 = Space(1)
            If Trim$(x9994.ProgramName2) = "" Then x9994.ProgramName2 = Space(1)
            If Trim$(x9994.PCHK) = "" Then x9994.PCHK = Space(1)
            If Trim$(x9994.AFTERPROG) = "" Then x9994.AFTERPROG = Space(1)

            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K9994_MOVE(rs9994 As SqlClient.SqlDataReader)
        Try

            Call D9994_CLEAR()

            If IsdbNull(rs9994!K9994_SITE) = False Then D9994.SITE = Trim$(rs9994!K9994_SITE)
            If IsdbNull(rs9994!K9994_GROUP) = False Then D9994.GROUP = Trim$(rs9994!K9994_GROUP)
            If IsdbNull(rs9994!K9994_PROG) = False Then D9994.PROG = Trim$(rs9994!K9994_PROG)
            If IsDBNull(rs9994!K9994_ProgramName) = False Then D9994.ProgramName = Trim$(rs9994!K9994_ProgramName)
            If IsDBNull(rs9994!K9994_ProgramName1) = False Then D9994.ProgramName1 = Trim$(rs9994!K9994_ProgramName1)
            If IsDBNull(rs9994!K9994_ProgramName2) = False Then D9994.ProgramName2 = Trim$(rs9994!K9994_ProgramName2)
            If IsDBNull(rs9994!K9994_PCHK) = False Then D9994.PCHK = Trim$(rs9994!K9994_PCHK)

            If IsDBNull(rs9994!K9994_AFTERPROG) = False Then D9994.AFTERPROG = Trim$(rs9994!K9994_AFTERPROG)

            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K9994_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K9994_MOVE(rs9994 As DataRow)
        Try

            Call D9994_CLEAR()

            If IsdbNull(rs9994!K9994_SITE) = False Then D9994.SITE = Trim$(rs9994!K9994_SITE)
            If IsdbNull(rs9994!K9994_GROUP) = False Then D9994.GROUP = Trim$(rs9994!K9994_GROUP)
            If IsdbNull(rs9994!K9994_PROG) = False Then D9994.PROG = Trim$(rs9994!K9994_PROG)
            If IsDBNull(rs9994!K9994_ProgramName) = False Then D9994.PROGRAMNAME = Trim$(rs9994!K9994_ProgramName)
            If IsDBNull(rs9994!K9994_ProgramName1) = False Then D9994.ProgramName1 = Trim$(rs9994!K9994_ProgramName1)
            If IsDBNull(rs9994!K9994_ProgramName2) = False Then D9994.ProgramName2 = Trim$(rs9994!K9994_ProgramName2)
            If IsDBNull(rs9994!K9994_PCHK) = False Then D9994.PCHK = Trim$(rs9994!K9994_PCHK)

            If IsDBNull(rs9994!K9994_AFTERPROG) = False Then D9994.AFTERPROG = Trim$(rs9994!K9994_AFTERPROG)
            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K9994_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K9994_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z9994 As T9994_AREA, SITE As String, GROUP As String, PROG As String) As Boolean

        K9994_MOVE = False

        Try
            If READ_PFK9994(SITE, GROUP, PROG) = True Then
                z9994 = D9994
                K9994_MOVE = True
            End If

            z9994.SITE = getDataM(spr, getColumIndex(spr, "SITE"), xRow)
            z9994.GROUP = getDataM(spr, getColumIndex(spr, "GROUP"), xRow)
            z9994.PROG = getDataM(spr, getColumIndex(spr, "PROG"), xRow)
            z9994.PROGRAMNAME = getDataM(spr, getColumIndex(spr, "PROGRAMNAME"), xRow)
            z9994.PROGRAMNAME1 = getDataM(spr, getColumIndex(spr, "PROGRAMNAME1"), xRow)
            z9994.PROGRAMNAME2 = getDataM(spr, getColumIndex(spr, "PROGRAMNAME2"), xRow)

            z9994.PCHK = getDataM(spr, getColumIndex(spr, "PCHK"), xRow)
            z9994.AFTERPROG = getDataM(spr, getColumIndex(spr, "AFTERPROG"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K9994_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K9994_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z9994 As T9994_AREA, Job As String, SITE As String, GROUP As String, PROG As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K9994_MOVE = False

        Try
            If READ_PFK9994(SITE, GROUP, PROG) = True Then
                z9994 = D9994
                K9994_MOVE = True

            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK9994")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "SITE" : z9994.SITE = Children(i).Code
                                Case "GROUP" : z9994.GROUP = Children(i).Code
                                Case "PROG" : z9994.PROG = Children(i).Code
                                Case "PROGRAMNAME" : z9994.PROGRAMNAME = Children(i).Code
                                Case "PROGRAMNAME1" : z9994.PROGRAMNAME1 = Children(i).Code
                                Case "PROGRAMNAME2" : z9994.PROGRAMNAME2 = Children(i).Code
                                Case "PCHK" : z9994.PCHK = Children(i).Code
                                Case "AFTERPROG" : z9994.AFTERPROG = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "SITE" : z9994.SITE = Children(i).Data
                                Case "GROUP" : z9994.GROUP = Children(i).Data
                                Case "PROG" : z9994.PROG = Children(i).Data
                                Case "PROGRAMNAME" : z9994.PROGRAMNAME = Children(i).Data
                                Case "PROGRAMNAME1" : z9994.PROGRAMNAME1 = Children(i).Data
                                Case "PROGRAMNAME2" : z9994.PROGRAMNAME2 = Children(i).Data
                                Case "PCHK" : z9994.PCHK = Children(i).Data
                                Case "AFTERPROG" : z9994.AFTERPROG = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K9994_MOVE", vbCritical)
        End Try
    End Function

End Module
