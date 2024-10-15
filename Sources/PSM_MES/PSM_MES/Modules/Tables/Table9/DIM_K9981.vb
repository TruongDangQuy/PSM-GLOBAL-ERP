'=========================================================================================================================================================
'   TABLE : (PFK9981)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K9981

    Structure T9981_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public SITE As String  '			char(3)		*
        Public SEL As String  '			char(1)		*
        Public PROG As String  '			varchar(200)		*
        Public NAME As String  '			nchar(200)
        Public NAME1 As String  '			nchar(200)
        Public NAME2 As String  '			nchar(200)
        Public REMARK As String  '			nchar(200)
        '=========================================================================================================================================================
    End Structure

    Public D9981 As T9981_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK9981(SITE As String, SEL As String, PROG As String) As Boolean
        READ_PFK9981 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK9981 "
            SQL = SQL & " WHERE K9981_SITE		 = '" & SITE & "' "
            SQL = SQL & "   AND K9981_SEL		 = '" & SEL & "' "
            SQL = SQL & "   AND K9981_PROG		 = '" & PROG & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D9981_CLEAR() : GoTo SKIP_READ_PFK9981

            Call K9981_MOVE(rd)
            READ_PFK9981 = True

SKIP_READ_PFK9981:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK9981", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK9981(SITE As String, SEL As String, PROG As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK9981 "
            SQL = SQL & " WHERE K9981_SITE		 = '" & SITE & "' "
            SQL = SQL & "   AND K9981_SEL		 = '" & SEL & "' "
            SQL = SQL & "   AND K9981_PROG		 = '" & PROG & "' "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK9981", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK9981(z9981 As T9981_AREA) As Boolean
        WRITE_PFK9981 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z9981)

            SQL = " INSERT INTO PFK9981 "
            SQL = SQL & " ( "
            SQL = SQL & " K9981_SITE,"
            SQL = SQL & " K9981_SEL,"
            SQL = SQL & " K9981_PROG,"
            SQL = SQL & " K9981_NAME,"
            SQL = SQL & " K9981_NAME1,"
            SQL = SQL & " K9981_NAME2,"
            SQL = SQL & " K9981_REMARK "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z9981.SITE) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9981.SEL) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9981.PROG) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9981.NAME) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9981.NAME1) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9981.NAME2) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9981.REMARK) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK9981 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK9981", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK9981(z9981 As T9981_AREA) As Boolean
        REWRITE_PFK9981 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z9981)

            SQL = " UPDATE PFK9981 SET "
            SQL = SQL & "    K9981_NAME      = N'" & FormatSQL(z9981.NAME) & "', "
            SQL = SQL & "    K9981_NAME1      = N'" & FormatSQL(z9981.NAME1) & "', "
            SQL = SQL & "    K9981_NAME2      = N'" & FormatSQL(z9981.NAME2) & "', "
            SQL = SQL & "    K9981_REMARK      = N'" & FormatSQL(z9981.REMARK) & "'  "
            SQL = SQL & " WHERE K9981_SITE		 = '" & z9981.SITE & "' "
            SQL = SQL & "   AND K9981_SEL		 = '" & z9981.SEL & "' "
            SQL = SQL & "   AND K9981_PROG		 = '" & z9981.PROG & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK9981 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK9981", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK9981(z9981 As T9981_AREA) As Boolean
        DELETE_PFK9981 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK9981 "
            SQL = SQL & " WHERE K9981_SITE		 = '" & z9981.SITE & "' "
            SQL = SQL & "   AND K9981_SEL		 = '" & z9981.SEL & "' "
            SQL = SQL & "   AND K9981_PROG		 = '" & z9981.PROG & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK9981 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK9981", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D9981_CLEAR()
        Try

            D9981.SITE = ""
            D9981.SEL = ""
            D9981.PROG = ""
            D9981.NAME = ""
            D9981.NAME1 = ""
            D9981.NAME2 = ""
            D9981.REMARK = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D9981_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x9981 As T9981_AREA)
        Try

            x9981.SITE = trim$(x9981.SITE)
            x9981.SEL = trim$(x9981.SEL)
            x9981.PROG = trim$(x9981.PROG)
            x9981.NAME = trim$(x9981.NAME)
            x9981.NAME1 = trim$(x9981.NAME1)
            x9981.NAME2 = trim$(x9981.NAME2)
            x9981.REMARK = trim$(x9981.REMARK)

            If trim$(x9981.SITE) = "" Then x9981.SITE = Space(1)
            If trim$(x9981.SEL) = "" Then x9981.SEL = Space(1)
            If trim$(x9981.PROG) = "" Then x9981.PROG = Space(1)
            If trim$(x9981.NAME) = "" Then x9981.NAME = Space(1)
            If trim$(x9981.NAME1) = "" Then x9981.NAME1 = Space(1)
            If trim$(x9981.NAME2) = "" Then x9981.NAME2 = Space(1)
            If trim$(x9981.REMARK) = "" Then x9981.REMARK = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K9981_MOVE(rs9981 As SqlClient.SqlDataReader)
        Try

            Call D9981_CLEAR()

            If IsdbNull(rs9981!K9981_SITE) = False Then D9981.SITE = Trim$(rs9981!K9981_SITE)
            If IsdbNull(rs9981!K9981_SEL) = False Then D9981.SEL = Trim$(rs9981!K9981_SEL)
            If IsdbNull(rs9981!K9981_PROG) = False Then D9981.PROG = Trim$(rs9981!K9981_PROG)
            If IsdbNull(rs9981!K9981_NAME) = False Then D9981.NAME = Trim$(rs9981!K9981_NAME)
            If IsdbNull(rs9981!K9981_NAME1) = False Then D9981.NAME1 = Trim$(rs9981!K9981_NAME1)
            If IsdbNull(rs9981!K9981_NAME2) = False Then D9981.NAME2 = Trim$(rs9981!K9981_NAME2)
            If IsdbNull(rs9981!K9981_REMARK) = False Then D9981.REMARK = Trim$(rs9981!K9981_REMARK)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K9981_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K9981_MOVE(rs9981 As DataRow)
        Try

            Call D9981_CLEAR()

            If IsdbNull(rs9981!K9981_SITE) = False Then D9981.SITE = Trim$(rs9981!K9981_SITE)
            If IsdbNull(rs9981!K9981_SEL) = False Then D9981.SEL = Trim$(rs9981!K9981_SEL)
            If IsdbNull(rs9981!K9981_PROG) = False Then D9981.PROG = Trim$(rs9981!K9981_PROG)
            If IsdbNull(rs9981!K9981_NAME) = False Then D9981.NAME = Trim$(rs9981!K9981_NAME)
            If IsdbNull(rs9981!K9981_NAME1) = False Then D9981.NAME1 = Trim$(rs9981!K9981_NAME1)
            If IsdbNull(rs9981!K9981_NAME2) = False Then D9981.NAME2 = Trim$(rs9981!K9981_NAME2)
            If IsdbNull(rs9981!K9981_REMARK) = False Then D9981.REMARK = Trim$(rs9981!K9981_REMARK)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K9981_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K9981_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z9981 As T9981_AREA, SITE As String, SEL As String, PROG As String) As Boolean

        K9981_MOVE = False

        Try
            If READ_PFK9981(SITE, SEL, PROG) = True Then
                z9981 = D9981
                K9981_MOVE = True
            Else
                z9981 = Nothing
            End If

            If getColumIndex(spr, "SITE") > -1 Then z9981.SITE = getDataM(spr, getColumIndex(spr, "SITE"), xRow)
            If getColumIndex(spr, "SEL") > -1 Then z9981.SEL = getDataM(spr, getColumIndex(spr, "SEL"), xRow)
            If getColumIndex(spr, "PROG") > -1 Then z9981.PROG = getDataM(spr, getColumIndex(spr, "PROG"), xRow)
            If getColumIndex(spr, "NAME") > -1 Then z9981.NAME = getDataM(spr, getColumIndex(spr, "NAME"), xRow)
            If getColumIndex(spr, "NAME1") > -1 Then z9981.NAME1 = getDataM(spr, getColumIndex(spr, "NAME1"), xRow)
            If getColumIndex(spr, "NAME2") > -1 Then z9981.NAME2 = getDataM(spr, getColumIndex(spr, "NAME2"), xRow)
            If getColumIndex(spr, "REMARK") > -1 Then z9981.REMARK = getDataM(spr, getColumIndex(spr, "REMARK"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K9981_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K9981_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z9981 As T9981_AREA, CheckClear As Boolean, SITE As String, SEL As String, PROG As String) As Boolean

        K9981_MOVE = False

        Try
            If READ_PFK9981(SITE, SEL, PROG) = True Then
                z9981 = D9981
                K9981_MOVE = True
            Else
                If CheckClear = True Then z9981 = Nothing
            End If

            If getColumIndex(spr, "SITE") > -1 Then z9981.SITE = getDataM(spr, getColumIndex(spr, "SITE"), xRow)
            If getColumIndex(spr, "SEL") > -1 Then z9981.SEL = getDataM(spr, getColumIndex(spr, "SEL"), xRow)
            If getColumIndex(spr, "PROG") > -1 Then z9981.PROG = getDataM(spr, getColumIndex(spr, "PROG"), xRow)
            If getColumIndex(spr, "NAME") > -1 Then z9981.NAME = getDataM(spr, getColumIndex(spr, "NAME"), xRow)
            If getColumIndex(spr, "NAME1") > -1 Then z9981.NAME1 = getDataM(spr, getColumIndex(spr, "NAME1"), xRow)
            If getColumIndex(spr, "NAME2") > -1 Then z9981.NAME2 = getDataM(spr, getColumIndex(spr, "NAME2"), xRow)
            If getColumIndex(spr, "REMARK") > -1 Then z9981.REMARK = getDataM(spr, getColumIndex(spr, "REMARK"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K9981_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K9981_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z9981 As T9981_AREA, Job As String, SITE As String, SEL As String, PROG As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K9981_MOVE = False

        Try
            If READ_PFK9981(SITE, SEL, PROG) = True Then
                z9981 = D9981
                K9981_MOVE = True
            Else
                z9981 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK9981")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "SITE" : z9981.SITE = Children(i).Code
                                Case "SEL" : z9981.SEL = Children(i).Code
                                Case "PROG" : z9981.PROG = Children(i).Code
                                Case "NAME" : z9981.NAME = Children(i).Code
                                Case "NAME1" : z9981.NAME1 = Children(i).Code
                                Case "NAME2" : z9981.NAME2 = Children(i).Code
                                Case "REMARK" : z9981.REMARK = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "SITE" : z9981.SITE = Children(i).Data
                                Case "SEL" : z9981.SEL = Children(i).Data
                                Case "PROG" : z9981.PROG = Children(i).Data
                                Case "NAME" : z9981.NAME = Children(i).Data
                                Case "NAME1" : z9981.NAME1 = Children(i).Data
                                Case "NAME2" : z9981.NAME2 = Children(i).Data
                                Case "REMARK" : z9981.REMARK = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K9981_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K9981_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z9981 As T9981_AREA, Job As String, CheckClear As Boolean, SITE As String, SEL As String, PROG As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K9981_MOVE = False

        Try
            If READ_PFK9981(SITE, SEL, PROG) = True Then
                z9981 = D9981
                K9981_MOVE = True
            Else
                If CheckClear = True Then z9981 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK9981")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "SITE" : z9981.SITE = Children(i).Code
                                Case "SEL" : z9981.SEL = Children(i).Code
                                Case "PROG" : z9981.PROG = Children(i).Code
                                Case "NAME" : z9981.NAME = Children(i).Code
                                Case "NAME1" : z9981.NAME1 = Children(i).Code
                                Case "NAME2" : z9981.NAME2 = Children(i).Code
                                Case "REMARK" : z9981.REMARK = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "SITE" : z9981.SITE = Children(i).Data
                                Case "SEL" : z9981.SEL = Children(i).Data
                                Case "PROG" : z9981.PROG = Children(i).Data
                                Case "NAME" : z9981.NAME = Children(i).Data
                                Case "NAME1" : z9981.NAME1 = Children(i).Data
                                Case "NAME2" : z9981.NAME2 = Children(i).Data
                                Case "REMARK" : z9981.REMARK = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K9981_MOVE", vbCritical)
        End Try
    End Function

End Module
