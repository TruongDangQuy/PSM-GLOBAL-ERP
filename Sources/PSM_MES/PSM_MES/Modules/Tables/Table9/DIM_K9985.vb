'=========================================================================================================================================================
'   TABLE : (PFK9985)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K9985

    Structure T9985_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public SITE As String  '			char(3)		*
        Public SANO As String  '			char(8)		*
        Public SEL As String  '			char(1)		*
        Public PROG As String  '			nvarchar(200)		*
        Public CHK01 As String  '			char(1)
        Public CHK02 As String  '			char(1)
        Public CHK03 As String  '			char(1)
        Public CHK04 As String  '			char(1)
        Public CHK05 As String  '			char(1)
        Public PCHK As String  '			char(1)
        '=========================================================================================================================================================
    End Structure

    Public D9985 As T9985_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK9985(SITE As String, SANO As String, SEL As String, PROG As String) As Boolean
        READ_PFK9985 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            'SQL = " SELECT * FROM PFK9985 "
            'SQL = SQL & " WHERE K9985_SITE		 = '" & SITE & "' "
            'SQL = SQL & "   AND K9985_SANO		 = '" & SANO & "' "
            'SQL = SQL & "   AND K9985_SEL		 = '" & SEL & "' "
            'SQL = SQL & "   AND K9985_PROG		 = '" & PROG & "' "

            SQL = " SELECT * FROM PFK9985 "
            SQL = SQL & " WHERE K9985_SANO		 = '" & SANO & "' "
            SQL = SQL & "   AND K9985_SEL		 = '" & SEL & "' "
            SQL = SQL & "   AND K9985_PROG		 = '" & PROG & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D9985_CLEAR() : GoTo SKIP_READ_PFK9985

            Call K9985_MOVE(rd)
            READ_PFK9985 = True

SKIP_READ_PFK9985:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK9985", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK9985(SITE As String, SANO As String, SEL As String, PROG As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK9985 "
            SQL = SQL & " WHERE K9985_SITE		 = '" & SITE & "' "
            SQL = SQL & "   AND K9985_SANO		 = '" & SANO & "' "
            SQL = SQL & "   AND K9985_SEL		 = '" & SEL & "' "
            SQL = SQL & "   AND K9985_PROG		 = '" & PROG & "' "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK9985", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK9985(z9985 As T9985_AREA) As Boolean
        WRITE_PFK9985 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z9985)

            SQL = " INSERT INTO PFK9985 "
            SQL = SQL & " ( "
            SQL = SQL & " K9985_SITE,"
            SQL = SQL & " K9985_SANO,"
            SQL = SQL & " K9985_SEL,"
            SQL = SQL & " K9985_PROG,"
            SQL = SQL & " K9985_CHK01,"
            SQL = SQL & " K9985_CHK02,"
            SQL = SQL & " K9985_CHK03,"
            SQL = SQL & " K9985_CHK04,"
            SQL = SQL & " K9985_CHK05,"
            SQL = SQL & " K9985_PCHK "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z9985.SITE) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9985.SANO) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9985.SEL) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9985.PROG) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9985.CHK01) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9985.CHK02) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9985.CHK03) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9985.CHK04) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9985.CHK05) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9985.PCHK) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK9985 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK9985", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK9985(z9985 As T9985_AREA) As Boolean
        REWRITE_PFK9985 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z9985)

            SQL = " UPDATE PFK9985 SET "
            SQL = SQL & "    K9985_CHK01      = N'" & FormatSQL(z9985.CHK01) & "', "
            SQL = SQL & "    K9985_CHK02      = N'" & FormatSQL(z9985.CHK02) & "', "
            SQL = SQL & "    K9985_CHK03      = N'" & FormatSQL(z9985.CHK03) & "', "
            SQL = SQL & "    K9985_CHK04      = N'" & FormatSQL(z9985.CHK04) & "', "
            SQL = SQL & "    K9985_CHK05      = N'" & FormatSQL(z9985.CHK05) & "', "
            SQL = SQL & "    K9985_PCHK      = N'" & FormatSQL(z9985.PCHK) & "'  "
            SQL = SQL & " WHERE K9985_SITE		 = '" & z9985.SITE & "' "
            SQL = SQL & "   AND K9985_SANO		 = '" & z9985.SANO & "' "
            SQL = SQL & "   AND K9985_SEL		 = '" & z9985.SEL & "' "
            SQL = SQL & "   AND K9985_PROG		 = '" & z9985.PROG & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK9985 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK9985", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK9985(z9985 As T9985_AREA) As Boolean
        DELETE_PFK9985 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK9985 "
            SQL = SQL & " WHERE K9985_SITE		 = '" & z9985.SITE & "' "
            SQL = SQL & "   AND K9985_SANO		 = '" & z9985.SANO & "' "
            SQL = SQL & "   AND K9985_SEL		 = '" & z9985.SEL & "' "
            SQL = SQL & "   AND K9985_PROG		 = '" & z9985.PROG & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK9985 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK9985", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D9985_CLEAR()
        Try

            D9985.SITE = ""
            D9985.SANO = ""
            D9985.SEL = ""
            D9985.PROG = ""
            D9985.CHK01 = ""
            D9985.CHK02 = ""
            D9985.CHK03 = ""
            D9985.CHK04 = ""
            D9985.CHK05 = ""
            D9985.PCHK = ""

            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D9985_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x9985 As T9985_AREA)
        Try

            x9985.SITE = trim$(x9985.SITE)
            x9985.SANO = trim$(x9985.SANO)
            x9985.SEL = trim$(x9985.SEL)
            x9985.PROG = trim$(x9985.PROG)
            x9985.CHK01 = trim$(x9985.CHK01)
            x9985.CHK02 = trim$(x9985.CHK02)
            x9985.CHK03 = trim$(x9985.CHK03)
            x9985.CHK04 = trim$(x9985.CHK04)
            x9985.CHK05 = trim$(x9985.CHK05)
            x9985.PCHK = trim$(x9985.PCHK)

            If trim$(x9985.SITE) = "" Then x9985.SITE = Space(1)
            If trim$(x9985.SANO) = "" Then x9985.SANO = Space(1)
            If trim$(x9985.SEL) = "" Then x9985.SEL = Space(1)
            If trim$(x9985.PROG) = "" Then x9985.PROG = Space(1)
            If trim$(x9985.CHK01) = "" Then x9985.CHK01 = Space(1)
            If trim$(x9985.CHK02) = "" Then x9985.CHK02 = Space(1)
            If trim$(x9985.CHK03) = "" Then x9985.CHK03 = Space(1)
            If trim$(x9985.CHK04) = "" Then x9985.CHK04 = Space(1)
            If trim$(x9985.CHK05) = "" Then x9985.CHK05 = Space(1)
            If trim$(x9985.PCHK) = "" Then x9985.PCHK = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K9985_MOVE(rs9985 As SqlClient.SqlDataReader)
        Try

            Call D9985_CLEAR()

            If IsdbNull(rs9985!K9985_SITE) = False Then D9985.SITE = Trim$(rs9985!K9985_SITE)
            If IsdbNull(rs9985!K9985_SANO) = False Then D9985.SANO = Trim$(rs9985!K9985_SANO)
            If IsdbNull(rs9985!K9985_SEL) = False Then D9985.SEL = Trim$(rs9985!K9985_SEL)
            If IsdbNull(rs9985!K9985_PROG) = False Then D9985.PROG = Trim$(rs9985!K9985_PROG)
            If IsdbNull(rs9985!K9985_CHK01) = False Then D9985.CHK01 = Trim$(rs9985!K9985_CHK01)
            If IsdbNull(rs9985!K9985_CHK02) = False Then D9985.CHK02 = Trim$(rs9985!K9985_CHK02)
            If IsdbNull(rs9985!K9985_CHK03) = False Then D9985.CHK03 = Trim$(rs9985!K9985_CHK03)
            If IsdbNull(rs9985!K9985_CHK04) = False Then D9985.CHK04 = Trim$(rs9985!K9985_CHK04)
            If IsdbNull(rs9985!K9985_CHK05) = False Then D9985.CHK05 = Trim$(rs9985!K9985_CHK05)
            If IsdbNull(rs9985!K9985_PCHK) = False Then D9985.PCHK = Trim$(rs9985!K9985_PCHK)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K9985_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K9985_MOVE(rs9985 As DataRow)
        Try

            Call D9985_CLEAR()

            If IsdbNull(rs9985!K9985_SITE) = False Then D9985.SITE = Trim$(rs9985!K9985_SITE)
            If IsdbNull(rs9985!K9985_SANO) = False Then D9985.SANO = Trim$(rs9985!K9985_SANO)
            If IsdbNull(rs9985!K9985_SEL) = False Then D9985.SEL = Trim$(rs9985!K9985_SEL)
            If IsdbNull(rs9985!K9985_PROG) = False Then D9985.PROG = Trim$(rs9985!K9985_PROG)
            If IsdbNull(rs9985!K9985_CHK01) = False Then D9985.CHK01 = Trim$(rs9985!K9985_CHK01)
            If IsdbNull(rs9985!K9985_CHK02) = False Then D9985.CHK02 = Trim$(rs9985!K9985_CHK02)
            If IsdbNull(rs9985!K9985_CHK03) = False Then D9985.CHK03 = Trim$(rs9985!K9985_CHK03)
            If IsdbNull(rs9985!K9985_CHK04) = False Then D9985.CHK04 = Trim$(rs9985!K9985_CHK04)
            If IsdbNull(rs9985!K9985_CHK05) = False Then D9985.CHK05 = Trim$(rs9985!K9985_CHK05)
            If IsdbNull(rs9985!K9985_PCHK) = False Then D9985.PCHK = Trim$(rs9985!K9985_PCHK)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K9985_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K9985_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z9985 As T9985_AREA, SITE As String, SANO As String, SEL As String, PROG As String) As Boolean

        K9985_MOVE = False

        Try
            If READ_PFK9985(SITE, SANO, SEL, PROG) = True Then
                z9985 = D9985
                K9985_MOVE = True
            Else
                z9985 = Nothing
            End If

            If getColumIndex(spr, "SITE") > -1 Then z9985.SITE = getDataM(spr, getColumIndex(spr, "SITE"), xRow)
            If getColumIndex(spr, "SANO") > -1 Then z9985.SANO = getDataM(spr, getColumIndex(spr, "SANO"), xRow)
            If getColumIndex(spr, "SEL") > -1 Then z9985.SEL = getDataM(spr, getColumIndex(spr, "SEL"), xRow)
            If getColumIndex(spr, "PROG") > -1 Then z9985.PROG = getDataM(spr, getColumIndex(spr, "PROG"), xRow)
            If getColumIndex(spr, "CHK01") > -1 Then z9985.CHK01 = getDataM(spr, getColumIndex(spr, "CHK01"), xRow)
            If getColumIndex(spr, "CHK02") > -1 Then z9985.CHK02 = getDataM(spr, getColumIndex(spr, "CHK02"), xRow)
            If getColumIndex(spr, "CHK03") > -1 Then z9985.CHK03 = getDataM(spr, getColumIndex(spr, "CHK03"), xRow)
            If getColumIndex(spr, "CHK04") > -1 Then z9985.CHK04 = getDataM(spr, getColumIndex(spr, "CHK04"), xRow)
            If getColumIndex(spr, "CHK05") > -1 Then z9985.CHK05 = getDataM(spr, getColumIndex(spr, "CHK05"), xRow)
            If getColumIndex(spr, "PCHK") > -1 Then z9985.PCHK = getDataM(spr, getColumIndex(spr, "PCHK"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K9985_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K9985_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z9985 As T9985_AREA, CheckClear As Boolean, SITE As String, SANO As String, SEL As String, PROG As String) As Boolean

        K9985_MOVE = False

        Try
            If READ_PFK9985(SITE, SANO, SEL, PROG) = True Then
                z9985 = D9985
                K9985_MOVE = True
            Else
                If CheckClear = True Then z9985 = Nothing
            End If

            If getColumIndex(spr, "SITE") > -1 Then z9985.SITE = getDataM(spr, getColumIndex(spr, "SITE"), xRow)
            If getColumIndex(spr, "SANO") > -1 Then z9985.SANO = getDataM(spr, getColumIndex(spr, "SANO"), xRow)
            If getColumIndex(spr, "SEL") > -1 Then z9985.SEL = getDataM(spr, getColumIndex(spr, "SEL"), xRow)
            If getColumIndex(spr, "PROG") > -1 Then z9985.PROG = getDataM(spr, getColumIndex(spr, "PROG"), xRow)
            If getColumIndex(spr, "CHK01") > -1 Then z9985.CHK01 = getDataM(spr, getColumIndex(spr, "CHK01"), xRow)
            If getColumIndex(spr, "CHK02") > -1 Then z9985.CHK02 = getDataM(spr, getColumIndex(spr, "CHK02"), xRow)
            If getColumIndex(spr, "CHK03") > -1 Then z9985.CHK03 = getDataM(spr, getColumIndex(spr, "CHK03"), xRow)
            If getColumIndex(spr, "CHK04") > -1 Then z9985.CHK04 = getDataM(spr, getColumIndex(spr, "CHK04"), xRow)
            If getColumIndex(spr, "CHK05") > -1 Then z9985.CHK05 = getDataM(spr, getColumIndex(spr, "CHK05"), xRow)
            If getColumIndex(spr, "PCHK") > -1 Then z9985.PCHK = getDataM(spr, getColumIndex(spr, "PCHK"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K9985_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K9985_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z9985 As T9985_AREA, Job As String, SITE As String, SANO As String, SEL As String, PROG As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K9985_MOVE = False

        Try
            If READ_PFK9985(SITE, SANO, SEL, PROG) = True Then
                z9985 = D9985
                K9985_MOVE = True
            Else
                z9985 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK9985")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "SITE" : z9985.SITE = Children(i).Code
                                Case "SANO" : z9985.SANO = Children(i).Code
                                Case "SEL" : z9985.SEL = Children(i).Code
                                Case "PROG" : z9985.PROG = Children(i).Code
                                Case "CHK01" : z9985.CHK01 = Children(i).Code
                                Case "CHK02" : z9985.CHK02 = Children(i).Code
                                Case "CHK03" : z9985.CHK03 = Children(i).Code
                                Case "CHK04" : z9985.CHK04 = Children(i).Code
                                Case "CHK05" : z9985.CHK05 = Children(i).Code
                                Case "PCHK" : z9985.PCHK = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "SITE" : z9985.SITE = Children(i).Data
                                Case "SANO" : z9985.SANO = Children(i).Data
                                Case "SEL" : z9985.SEL = Children(i).Data
                                Case "PROG" : z9985.PROG = Children(i).Data
                                Case "CHK01" : z9985.CHK01 = Children(i).Data
                                Case "CHK02" : z9985.CHK02 = Children(i).Data
                                Case "CHK03" : z9985.CHK03 = Children(i).Data
                                Case "CHK04" : z9985.CHK04 = Children(i).Data
                                Case "CHK05" : z9985.CHK05 = Children(i).Data
                                Case "PCHK" : z9985.PCHK = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K9985_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K9985_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z9985 As T9985_AREA, Job As String, CheckClear As Boolean, SITE As String, SANO As String, SEL As String, PROG As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K9985_MOVE = False

        Try
            If READ_PFK9985(SITE, SANO, SEL, PROG) = True Then
                z9985 = D9985
                K9985_MOVE = True
            Else
                If CheckClear = True Then z9985 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK9985")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "SITE" : z9985.SITE = Children(i).Code
                                Case "SANO" : z9985.SANO = Children(i).Code
                                Case "SEL" : z9985.SEL = Children(i).Code
                                Case "PROG" : z9985.PROG = Children(i).Code
                                Case "CHK01" : z9985.CHK01 = Children(i).Code
                                Case "CHK02" : z9985.CHK02 = Children(i).Code
                                Case "CHK03" : z9985.CHK03 = Children(i).Code
                                Case "CHK04" : z9985.CHK04 = Children(i).Code
                                Case "CHK05" : z9985.CHK05 = Children(i).Code
                                Case "PCHK" : z9985.PCHK = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "SITE" : z9985.SITE = Children(i).Data
                                Case "SANO" : z9985.SANO = Children(i).Data
                                Case "SEL" : z9985.SEL = Children(i).Data
                                Case "PROG" : z9985.PROG = Children(i).Data
                                Case "CHK01" : z9985.CHK01 = Children(i).Data
                                Case "CHK02" : z9985.CHK02 = Children(i).Data
                                Case "CHK03" : z9985.CHK03 = Children(i).Data
                                Case "CHK04" : z9985.CHK04 = Children(i).Data
                                Case "CHK05" : z9985.CHK05 = Children(i).Data
                                Case "PCHK" : z9985.PCHK = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K9985_MOVE", vbCritical)
        End Try
    End Function

End Module
