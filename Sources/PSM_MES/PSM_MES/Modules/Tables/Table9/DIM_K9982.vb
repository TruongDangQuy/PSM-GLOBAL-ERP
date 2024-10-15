'=========================================================================================================================================================
'   TABLE : (PFK9982)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K9982

    Structure T9982_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public SITE As String  '			char(3)		*
        Public SEL As String  '			char(1)		*
        Public SEQ As String  '			char(4)		*
        Public PROG As String  '			varchar(200)
        Public REMARK As String  '			nchar(200)
        '=========================================================================================================================================================
    End Structure

    Public D9982 As T9982_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK9982(SITE As String, SEL As String, SEQ As String) As Boolean
        READ_PFK9982 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK9982 "
            SQL = SQL & " WHERE K9982_SITE		 = '" & SITE & "' "
            SQL = SQL & "   AND K9982_SEL		 = '" & SEL & "' "
            SQL = SQL & "   AND K9982_SEQ		 = '" & SEQ & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D9982_CLEAR() : GoTo SKIP_READ_PFK9982

            Call K9982_MOVE(rd)
            READ_PFK9982 = True

SKIP_READ_PFK9982:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK9982", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK9982(SITE As String, SEL As String, SEQ As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK9982 "
            SQL = SQL & " WHERE K9982_SITE		 = '" & SITE & "' "
            SQL = SQL & "   AND K9982_SEL		 = '" & SEL & "' "
            SQL = SQL & "   AND K9982_SEQ		 = '" & SEQ & "' "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK9982", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK9982(z9982 As T9982_AREA) As Boolean
        WRITE_PFK9982 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z9982)

            SQL = " INSERT INTO PFK9982 "
            SQL = SQL & " ( "
            SQL = SQL & " K9982_SITE,"
            SQL = SQL & " K9982_SEL,"
            SQL = SQL & " K9982_SEQ,"
            SQL = SQL & " K9982_PROG,"
            SQL = SQL & " K9982_REMARK "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z9982.SITE) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9982.SEL) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9982.SEQ) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9982.PROG) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9982.REMARK) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK9982 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK9982", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK9982(z9982 As T9982_AREA) As Boolean
        REWRITE_PFK9982 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z9982)

            SQL = " UPDATE PFK9982 SET "
            SQL = SQL & "    K9982_PROG      = N'" & FormatSQL(z9982.PROG) & "', "
            SQL = SQL & "    K9982_REMARK      = N'" & FormatSQL(z9982.REMARK) & "'  "
            SQL = SQL & " WHERE K9982_SITE		 = '" & z9982.SITE & "' "
            SQL = SQL & "   AND K9982_SEL		 = '" & z9982.SEL & "' "
            SQL = SQL & "   AND K9982_SEQ		 = '" & z9982.SEQ & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK9982 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK9982", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK9982(z9982 As T9982_AREA) As Boolean
        DELETE_PFK9982 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK9982 "
            SQL = SQL & " WHERE K9982_SITE		 = '" & z9982.SITE & "' "
            SQL = SQL & "   AND K9982_SEL		 = '" & z9982.SEL & "' "
            SQL = SQL & "   AND K9982_SEQ		 = '" & z9982.SEQ & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK9982 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK9982", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D9982_CLEAR()
        Try

            D9982.SITE = ""
            D9982.SEL = ""
            D9982.SEQ = ""
            D9982.PROG = ""
            D9982.REMARK = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D9982_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x9982 As T9982_AREA)
        Try

            x9982.SITE = trim$(x9982.SITE)
            x9982.SEL = trim$(x9982.SEL)
            x9982.SEQ = trim$(x9982.SEQ)
            x9982.PROG = trim$(x9982.PROG)
            x9982.REMARK = trim$(x9982.REMARK)

            If trim$(x9982.SITE) = "" Then x9982.SITE = Space(1)
            If trim$(x9982.SEL) = "" Then x9982.SEL = Space(1)
            If trim$(x9982.SEQ) = "" Then x9982.SEQ = Space(1)
            If trim$(x9982.PROG) = "" Then x9982.PROG = Space(1)
            If trim$(x9982.REMARK) = "" Then x9982.REMARK = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K9982_MOVE(rs9982 As SqlClient.SqlDataReader)
        Try

            Call D9982_CLEAR()

            If IsdbNull(rs9982!K9982_SITE) = False Then D9982.SITE = Trim$(rs9982!K9982_SITE)
            If IsdbNull(rs9982!K9982_SEL) = False Then D9982.SEL = Trim$(rs9982!K9982_SEL)
            If IsdbNull(rs9982!K9982_SEQ) = False Then D9982.SEQ = Trim$(rs9982!K9982_SEQ)
            If IsdbNull(rs9982!K9982_PROG) = False Then D9982.PROG = Trim$(rs9982!K9982_PROG)
            If IsdbNull(rs9982!K9982_REMARK) = False Then D9982.REMARK = Trim$(rs9982!K9982_REMARK)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K9982_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K9982_MOVE(rs9982 As DataRow)
        Try

            Call D9982_CLEAR()

            If IsdbNull(rs9982!K9982_SITE) = False Then D9982.SITE = Trim$(rs9982!K9982_SITE)
            If IsdbNull(rs9982!K9982_SEL) = False Then D9982.SEL = Trim$(rs9982!K9982_SEL)
            If IsdbNull(rs9982!K9982_SEQ) = False Then D9982.SEQ = Trim$(rs9982!K9982_SEQ)
            If IsdbNull(rs9982!K9982_PROG) = False Then D9982.PROG = Trim$(rs9982!K9982_PROG)
            If IsdbNull(rs9982!K9982_REMARK) = False Then D9982.REMARK = Trim$(rs9982!K9982_REMARK)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K9982_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K9982_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z9982 As T9982_AREA, SITE As String, SEL As String, SEQ As String) As Boolean

        K9982_MOVE = False

        Try
            If READ_PFK9982(SITE, SEL, SEQ) = True Then
                z9982 = D9982
                K9982_MOVE = True
            Else
                z9982 = Nothing
            End If

            If getColumIndex(spr, "SITE") > -1 Then z9982.SITE = getDataM(spr, getColumIndex(spr, "SITE"), xRow)
            If getColumIndex(spr, "SEL") > -1 Then z9982.SEL = getDataM(spr, getColumIndex(spr, "SEL"), xRow)
            If getColumIndex(spr, "SEQ") > -1 Then z9982.SEQ = getDataM(spr, getColumIndex(spr, "SEQ"), xRow)
            If getColumIndex(spr, "PROG") > -1 Then z9982.PROG = getDataM(spr, getColumIndex(spr, "PROG"), xRow)
            If getColumIndex(spr, "REMARK") > -1 Then z9982.REMARK = getDataM(spr, getColumIndex(spr, "REMARK"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K9982_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K9982_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z9982 As T9982_AREA, CheckClear As Boolean, SITE As String, SEL As String, SEQ As String) As Boolean

        K9982_MOVE = False

        Try
            If READ_PFK9982(SITE, SEL, SEQ) = True Then
                z9982 = D9982
                K9982_MOVE = True
            Else
                If CheckClear = True Then z9982 = Nothing
            End If

            If getColumIndex(spr, "SITE") > -1 Then z9982.SITE = getDataM(spr, getColumIndex(spr, "SITE"), xRow)
            If getColumIndex(spr, "SEL") > -1 Then z9982.SEL = getDataM(spr, getColumIndex(spr, "SEL"), xRow)
            If getColumIndex(spr, "SEQ") > -1 Then z9982.SEQ = getDataM(spr, getColumIndex(spr, "SEQ"), xRow)
            If getColumIndex(spr, "PROG") > -1 Then z9982.PROG = getDataM(spr, getColumIndex(spr, "PROG"), xRow)
            If getColumIndex(spr, "REMARK") > -1 Then z9982.REMARK = getDataM(spr, getColumIndex(spr, "REMARK"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K9982_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K9982_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z9982 As T9982_AREA, Job As String, SITE As String, SEL As String, SEQ As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K9982_MOVE = False

        Try
            If READ_PFK9982(SITE, SEL, SEQ) = True Then
                z9982 = D9982
                K9982_MOVE = True
            Else
                z9982 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK9982")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "SITE" : z9982.SITE = Children(i).Code
                                Case "SEL" : z9982.SEL = Children(i).Code
                                Case "SEQ" : z9982.SEQ = Children(i).Code
                                Case "PROG" : z9982.PROG = Children(i).Code
                                Case "REMARK" : z9982.REMARK = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "SITE" : z9982.SITE = Children(i).Data
                                Case "SEL" : z9982.SEL = Children(i).Data
                                Case "SEQ" : z9982.SEQ = Children(i).Data
                                Case "PROG" : z9982.PROG = Children(i).Data
                                Case "REMARK" : z9982.REMARK = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K9982_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K9982_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z9982 As T9982_AREA, Job As String, CheckClear As Boolean, SITE As String, SEL As String, SEQ As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K9982_MOVE = False

        Try
            If READ_PFK9982(SITE, SEL, SEQ) = True Then
                z9982 = D9982
                K9982_MOVE = True
            Else
                If CheckClear = True Then z9982 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK9982")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "SITE" : z9982.SITE = Children(i).Code
                                Case "SEL" : z9982.SEL = Children(i).Code
                                Case "SEQ" : z9982.SEQ = Children(i).Code
                                Case "PROG" : z9982.PROG = Children(i).Code
                                Case "REMARK" : z9982.REMARK = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "SITE" : z9982.SITE = Children(i).Data
                                Case "SEL" : z9982.SEL = Children(i).Data
                                Case "SEQ" : z9982.SEQ = Children(i).Data
                                Case "PROG" : z9982.PROG = Children(i).Data
                                Case "REMARK" : z9982.REMARK = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K9982_MOVE", vbCritical)
        End Try
    End Function

End Module
