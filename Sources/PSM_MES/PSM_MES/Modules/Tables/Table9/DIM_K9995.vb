'=========================================================================================================================================================
'   TABLE : (PFK9995)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K9995

    Structure T9995_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public SEQ As String  '			char(4)		*
        Public PROG As String  '			varchar(30)
        Public NAME As String  '			nchar(100)
        Public NAME1 As String  '			nchar(100)
        Public NAME2 As String  '			nchar(100)
        Public REMARK As String  '			nchar(200)
        '=========================================================================================================================================================
    End Structure

    Public D9995 As T9995_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK9995(SEQ As String) As Boolean
        READ_PFK9995 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK9995 "
            SQL = SQL & " WHERE K9995_SEQ		 = '" & SEQ & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D9995_CLEAR() : GoTo SKIP_READ_PFK9995

            Call K9995_MOVE(rd)
            READ_PFK9995 = True

SKIP_READ_PFK9995:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK9995", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK9995(SEQ As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK9995 "
            SQL = SQL & " WHERE K9995_SEQ		 = '" & SEQ & "' "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK9995", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK9995(z9995 As T9995_AREA) As Boolean
        WRITE_PFK9995 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z9995)

            SQL = " INSERT INTO PFK9995 "
            SQL = SQL & " ( "
            SQL = SQL & " K9995_SEQ,"
            SQL = SQL & " K9995_PROG,"
            SQL = SQL & " K9995_NAME,"
            SQL = SQL & " K9995_NAME1,"
            SQL = SQL & " K9995_NAME2,"
            SQL = SQL & " K9995_REMARK "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  '" & z9995.SEQ & "', "
            SQL = SQL & "  '" & z9995.PROG & "', "
            SQL = SQL & "  '" & z9995.NAME & "', "
            SQL = SQL & "  '" & z9995.NAME1 & "', "
            SQL = SQL & "  '" & z9995.NAME2 & "', "
            SQL = SQL & "  '" & z9995.REMARK & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK9995 = True
            Exit Function
        Catch ex As Exception
            'Call MsgBoxP("WRITE_PFK9995",vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK9995(z9995 As T9995_AREA) As Boolean
        REWRITE_PFK9995 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z9995)

            SQL = " UPDATE PFK9995 SET "
            SQL = SQL & "    K9995_PROG      = '" & z9995.PROG & "', "
            SQL = SQL & "    K9995_NAME      = '" & z9995.NAME & "', "
            SQL = SQL & "    K9995_NAME1      = '" & z9995.NAME1 & "', "
            SQL = SQL & "    K9995_NAME2      = '" & z9995.NAME2 & "', "
            SQL = SQL & "    K9995_REMARK      = '" & z9995.REMARK & "'  "
            SQL = SQL & " WHERE K9995_SEQ		 = '" & z9995.SEQ & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK9995 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK9995", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK9995(z9995 As T9995_AREA) As Boolean
        DELETE_PFK9995 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK9995 "
            SQL = SQL & " WHERE K9995_SEQ		 = '" & z9995.SEQ & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK9995 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK9995", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D9995_CLEAR()
        Try

            D9995.SEQ = ""
            D9995.PROG = ""
            D9995.NAME = ""
            D9995.NAME1 = ""
            D9995.NAME2 = ""
            D9995.REMARK = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D9995_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x9995 As T9995_AREA)
        Try

            x9995.SEQ = trim$(x9995.SEQ)
            x9995.PROG = trim$(x9995.PROG)
            x9995.NAME = trim$(x9995.NAME)
            x9995.NAME1 = Trim$(x9995.NAME1)
            x9995.NAME2 = Trim$(x9995.NAME2)
            x9995.REMARK = Trim$(x9995.REMARK)

            If trim$(x9995.SEQ) = "" Then x9995.SEQ = Space(1)
            If trim$(x9995.PROG) = "" Then x9995.PROG = Space(1)
            If trim$(x9995.NAME) = "" Then x9995.NAME = Space(1)
            If trim$(x9995.REMARK) = "" Then x9995.REMARK = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K9995_MOVE(rs9995 As SqlClient.SqlDataReader)
        Try

            Call D9995_CLEAR()

            If IsdbNull(rs9995!K9995_SEQ) = False Then D9995.SEQ = Trim$(rs9995!K9995_SEQ)
            If IsdbNull(rs9995!K9995_PROG) = False Then D9995.PROG = Trim$(rs9995!K9995_PROG)
            If IsdbNull(rs9995!K9995_NAME) = False Then D9995.NAME = Trim$(rs9995!K9995_NAME)
            If IsDBNull(rs9995!K9995_NAME1) = False Then D9995.NAME1 = Trim$(rs9995!K9995_NAME1)
            If IsDBNull(rs9995!K9995_NAME2) = False Then D9995.NAME2 = Trim$(rs9995!K9995_NAME2)
            If IsDBNull(rs9995!K9995_REMARK) = False Then D9995.REMARK = Trim$(rs9995!K9995_REMARK)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K9995_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K9995_MOVE(rs9995 As DataRow)
        Try

            Call D9995_CLEAR()

            If IsdbNull(rs9995!K9995_SEQ) = False Then D9995.SEQ = Trim$(rs9995!K9995_SEQ)
            If IsdbNull(rs9995!K9995_PROG) = False Then D9995.PROG = Trim$(rs9995!K9995_PROG)
            If IsdbNull(rs9995!K9995_NAME) = False Then D9995.NAME = Trim$(rs9995!K9995_NAME)
            If IsDBNull(rs9995!K9995_NAME1) = False Then D9995.NAME1 = Trim$(rs9995!K9995_NAME1)
            If IsDBNull(rs9995!K9995_NAME2) = False Then D9995.NAME2 = Trim$(rs9995!K9995_NAME2)
            If IsDBNull(rs9995!K9995_REMARK) = False Then D9995.REMARK = Trim$(rs9995!K9995_REMARK)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K9995_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K9995_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z9995 As T9995_AREA, SEQ As String) As Boolean

        K9995_MOVE = False

        Try
            If READ_PFK9995(SEQ) = True Then
                z9995 = D9995
                K9995_MOVE = True
            Else
                z9995 = Nothing
            End If

            If getColumIndex(spr, "SEQ") > -1 Then z9995.SEQ = getDataM(spr, getColumIndex(spr, "SEQ"), xRow)
            If getColumIndex(spr, "PROG") > -1 Then z9995.PROG = getDataM(spr, getColumIndex(spr, "PROG"), xRow)
            If getColumIndex(spr, "NAME") > -1 Then z9995.NAME = getDataM(spr, getColumIndex(spr, "NAME"), xRow)
            If getColumIndex(spr, "NAME1") > -1 Then z9995.NAME1 = getDataM(spr, getColumIndex(spr, "NAME1"), xRow)
            If getColumIndex(spr, "NAME2") > -1 Then z9995.NAME2 = getDataM(spr, getColumIndex(spr, "NAME2"), xRow)
            If getColumIndex(spr, "REMARK") > -1 Then z9995.REMARK = getDataM(spr, getColumIndex(spr, "REMARK"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K9995_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K9995_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z9995 As T9995_AREA, Job As String, SEQ As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K9995_MOVE = False

        Try
            If READ_PFK9995(SEQ) = True Then
                z9995 = D9995
                K9995_MOVE = True
            Else
                z9995 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK9995")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "SEQ" : z9995.SEQ = Children(i).Code
                                Case "PROG" : z9995.PROG = Children(i).Code
                                Case "NAME" : z9995.NAME = Children(i).Code
                                Case "NAME1" : z9995.NAME1 = Children(i).Code
                                Case "NAME2" : z9995.NAME2 = Children(i).Code
                                Case "REMARK" : z9995.REMARK = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "SEQ" : z9995.SEQ = Children(i).Data
                                Case "PROG" : z9995.PROG = Children(i).Data
                                Case "NAME" : z9995.NAME = Children(i).Data
                                Case "NAME1" : z9995.NAME1 = Children(i).Data
                                Case "NAME2" : z9995.NAME2 = Children(i).Data
                                Case "REMARK" : z9995.REMARK = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K9995_MOVE", vbCritical)
        End Try
    End Function

End Module
