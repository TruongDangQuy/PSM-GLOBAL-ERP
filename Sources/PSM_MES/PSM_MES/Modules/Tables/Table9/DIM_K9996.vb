'=========================================================================================================================================================
'   TABLE : (PFK9996)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K9996

    Structure T9996_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public SITE As String  '			char(3)		*
        Public SANO As String  '			char(8)		*
        Public SEQ As Double  '			decimal		*
        Public CustomerCode As String  '			varchar(6)
        Public CHK01 As String  '			char(1)
        Public CHK02 As String  '			char(1)
        Public CHK03 As String  '			char(1)
        Public CHK04 As String  '			char(1)
        Public CHK05 As String  '			char(1)
        Public REMARK As String  '			nvarchar(200)
        '=========================================================================================================================================================
    End Structure

    Public D9996 As T9996_AREA
    Public LIST_D9996 As New List(Of T9996_AREA)

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================

    Public Function READ_PFK9996(SITE As String, SANO As String, SEQ As Double) As Boolean
        READ_PFK9996 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK9996 "
            SQL = SQL & " WHERE K9996_SITE		 = '" & SITE & "' "
            SQL = SQL & "   AND K9996_SANO		 = '" & SANO & "' "
            SQL = SQL & "   AND K9996_SEQ		 =  " & SEQ & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D9996_CLEAR() : GoTo SKIP_READ_PFK9996

            Call K9996_MOVE(rd)
            READ_PFK9996 = True

SKIP_READ_PFK9996:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK9996", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK9996(SITE As String, SANO As String, SEQ As Double, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK9996 "
            SQL = SQL & " WHERE K9996_SITE		 = '" & SITE & "' "
            SQL = SQL & "   AND K9996_SANO		 = '" & SANO & "' "
            SQL = SQL & "   AND K9996_SEQ		 =  " & SEQ & "  "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK9996", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK9996(z9996 As T9996_AREA) As Boolean
        WRITE_PFK9996 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z9996)

            SQL = " INSERT INTO PFK9996 "
            SQL = SQL & " ( "
            SQL = SQL & " K9996_SITE,"
            SQL = SQL & " K9996_SANO,"
            SQL = SQL & " K9996_SEQ,"
            SQL = SQL & " K9996_CustomerCode,"
            SQL = SQL & " K9996_CHK01,"
            SQL = SQL & " K9996_CHK02,"
            SQL = SQL & " K9996_CHK03,"
            SQL = SQL & " K9996_CHK04,"
            SQL = SQL & " K9996_CHK05,"
            SQL = SQL & " K9996_REMARK "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z9996.SITE) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9996.SANO) & "', "
            SQL = SQL & "   " & FormatSQL(z9996.SEQ) & ", "
            SQL = SQL & "  N'" & FormatSQL(z9996.CustomerCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9996.CHK01) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9996.CHK02) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9996.CHK03) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9996.CHK04) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9996.CHK05) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9996.REMARK) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK9996 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK9996", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK9996(z9996 As T9996_AREA) As Boolean
        REWRITE_PFK9996 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z9996)

            SQL = " UPDATE PFK9996 SET "
            SQL = SQL & "    K9996_CustomerCode      = N'" & FormatSQL(z9996.CustomerCode) & "', "
            SQL = SQL & "    K9996_CHK01      = N'" & FormatSQL(z9996.CHK01) & "', "
            SQL = SQL & "    K9996_CHK02      = N'" & FormatSQL(z9996.CHK02) & "', "
            SQL = SQL & "    K9996_CHK03      = N'" & FormatSQL(z9996.CHK03) & "', "
            SQL = SQL & "    K9996_CHK04      = N'" & FormatSQL(z9996.CHK04) & "', "
            SQL = SQL & "    K9996_CHK05      = N'" & FormatSQL(z9996.CHK05) & "', "
            SQL = SQL & "    K9996_REMARK      = N'" & FormatSQL(z9996.REMARK) & "'  "
            SQL = SQL & " WHERE K9996_SITE		 = '" & z9996.SITE & "' "
            SQL = SQL & "   AND K9996_SANO		 = '" & z9996.SANO & "' "
            SQL = SQL & "   AND K9996_SEQ		 =  " & z9996.SEQ & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK9996 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK9996", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK9996(z9996 As T9996_AREA) As Boolean
        DELETE_PFK9996 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK9996 "
            SQL = SQL & " WHERE K9996_SITE		 = '" & z9996.SITE & "' "
            SQL = SQL & "   AND K9996_SANO		 = '" & z9996.SANO & "' "
            SQL = SQL & "   AND K9996_SEQ		 =  " & z9996.SEQ & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK9996 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK9996", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D9996_CLEAR()
        Try

            D9996.SITE = ""
            D9996.SANO = ""
            D9996.SEQ = 0
            D9996.CustomerCode = ""
            D9996.CHK01 = ""
            D9996.CHK02 = ""
            D9996.CHK03 = ""
            D9996.CHK04 = ""
            D9996.CHK05 = ""
            D9996.REMARK = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D9996_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x9996 As T9996_AREA)
        Try

            x9996.SITE = trim$(x9996.SITE)
            x9996.SANO = trim$(x9996.SANO)
            x9996.SEQ = trim$(x9996.SEQ)
            x9996.CustomerCode = trim$(x9996.CustomerCode)
            x9996.CHK01 = trim$(x9996.CHK01)
            x9996.CHK02 = trim$(x9996.CHK02)
            x9996.CHK03 = trim$(x9996.CHK03)
            x9996.CHK04 = trim$(x9996.CHK04)
            x9996.CHK05 = trim$(x9996.CHK05)
            x9996.REMARK = trim$(x9996.REMARK)

            If trim$(x9996.SITE) = "" Then x9996.SITE = Space(1)
            If trim$(x9996.SANO) = "" Then x9996.SANO = Space(1)
            If trim$(x9996.SEQ) = "" Then x9996.SEQ = 0
            If trim$(x9996.CustomerCode) = "" Then x9996.CustomerCode = Space(1)
            If trim$(x9996.CHK01) = "" Then x9996.CHK01 = Space(1)
            If trim$(x9996.CHK02) = "" Then x9996.CHK02 = Space(1)
            If trim$(x9996.CHK03) = "" Then x9996.CHK03 = Space(1)
            If trim$(x9996.CHK04) = "" Then x9996.CHK04 = Space(1)
            If trim$(x9996.CHK05) = "" Then x9996.CHK05 = Space(1)
            If trim$(x9996.REMARK) = "" Then x9996.REMARK = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K9996_MOVE(rs9996 As SqlClient.SqlDataReader)
        Try

            Call D9996_CLEAR()

            If IsdbNull(rs9996!K9996_SITE) = False Then D9996.SITE = Trim$(rs9996!K9996_SITE)
            If IsdbNull(rs9996!K9996_SANO) = False Then D9996.SANO = Trim$(rs9996!K9996_SANO)
            If IsdbNull(rs9996!K9996_SEQ) = False Then D9996.SEQ = Trim$(rs9996!K9996_SEQ)
            If IsdbNull(rs9996!K9996_CustomerCode) = False Then D9996.CustomerCode = Trim$(rs9996!K9996_CustomerCode)
            If IsdbNull(rs9996!K9996_CHK01) = False Then D9996.CHK01 = Trim$(rs9996!K9996_CHK01)
            If IsdbNull(rs9996!K9996_CHK02) = False Then D9996.CHK02 = Trim$(rs9996!K9996_CHK02)
            If IsdbNull(rs9996!K9996_CHK03) = False Then D9996.CHK03 = Trim$(rs9996!K9996_CHK03)
            If IsdbNull(rs9996!K9996_CHK04) = False Then D9996.CHK04 = Trim$(rs9996!K9996_CHK04)
            If IsdbNull(rs9996!K9996_CHK05) = False Then D9996.CHK05 = Trim$(rs9996!K9996_CHK05)
            If IsdbNull(rs9996!K9996_REMARK) = False Then D9996.REMARK = Trim$(rs9996!K9996_REMARK)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K9996_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K9996_MOVE(rs9996 As DataRow)
        Try

            Call D9996_CLEAR()

            If IsdbNull(rs9996!K9996_SITE) = False Then D9996.SITE = Trim$(rs9996!K9996_SITE)
            If IsdbNull(rs9996!K9996_SANO) = False Then D9996.SANO = Trim$(rs9996!K9996_SANO)
            If IsdbNull(rs9996!K9996_SEQ) = False Then D9996.SEQ = Trim$(rs9996!K9996_SEQ)
            If IsdbNull(rs9996!K9996_CustomerCode) = False Then D9996.CustomerCode = Trim$(rs9996!K9996_CustomerCode)
            If IsdbNull(rs9996!K9996_CHK01) = False Then D9996.CHK01 = Trim$(rs9996!K9996_CHK01)
            If IsdbNull(rs9996!K9996_CHK02) = False Then D9996.CHK02 = Trim$(rs9996!K9996_CHK02)
            If IsdbNull(rs9996!K9996_CHK03) = False Then D9996.CHK03 = Trim$(rs9996!K9996_CHK03)
            If IsdbNull(rs9996!K9996_CHK04) = False Then D9996.CHK04 = Trim$(rs9996!K9996_CHK04)
            If IsdbNull(rs9996!K9996_CHK05) = False Then D9996.CHK05 = Trim$(rs9996!K9996_CHK05)
            If IsdbNull(rs9996!K9996_REMARK) = False Then D9996.REMARK = Trim$(rs9996!K9996_REMARK)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K9996_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K9996_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z9996 As T9996_AREA, SITE As String, SANO As String, SEQ As Double) As Boolean

        K9996_MOVE = False

        Try
            If READ_PFK9996(SITE, SANO, SEQ) = True Then
                z9996 = D9996
                K9996_MOVE = True
            Else
                z9996 = Nothing
            End If

            If getColumIndex(spr, "SITE") > -1 Then z9996.SITE = getDataM(spr, getColumIndex(spr, "SITE"), xRow)
            If getColumIndex(spr, "SANO") > -1 Then z9996.SANO = getDataM(spr, getColumIndex(spr, "SANO"), xRow)
            If getColumIndex(spr, "SEQ") > -1 Then z9996.SEQ = getDataM(spr, getColumIndex(spr, "SEQ"), xRow)
            If getColumIndex(spr, "CustomerCode") > -1 Then z9996.CustomerCode = getDataM(spr, getColumIndex(spr, "CustomerCode"), xRow)
            If getColumIndex(spr, "CHK01") > -1 Then z9996.CHK01 = getDataM(spr, getColumIndex(spr, "CHK01"), xRow)
            If getColumIndex(spr, "CHK02") > -1 Then z9996.CHK02 = getDataM(spr, getColumIndex(spr, "CHK02"), xRow)
            If getColumIndex(spr, "CHK03") > -1 Then z9996.CHK03 = getDataM(spr, getColumIndex(spr, "CHK03"), xRow)
            If getColumIndex(spr, "CHK04") > -1 Then z9996.CHK04 = getDataM(spr, getColumIndex(spr, "CHK04"), xRow)
            If getColumIndex(spr, "CHK05") > -1 Then z9996.CHK05 = getDataM(spr, getColumIndex(spr, "CHK05"), xRow)
            If getColumIndex(spr, "REMARK") > -1 Then z9996.REMARK = getDataM(spr, getColumIndex(spr, "REMARK"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K9996_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K9996_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z9996 As T9996_AREA, CheckClear As Boolean, SITE As String, SANO As String, SEQ As Double) As Boolean

        K9996_MOVE = False

        Try
            If READ_PFK9996(SITE, SANO, SEQ) = True Then
                z9996 = D9996
                K9996_MOVE = True
            Else
                If CheckClear = True Then z9996 = Nothing
            End If

            If getColumIndex(spr, "SITE") > -1 Then z9996.SITE = getDataM(spr, getColumIndex(spr, "SITE"), xRow)
            If getColumIndex(spr, "SANO") > -1 Then z9996.SANO = getDataM(spr, getColumIndex(spr, "SANO"), xRow)
            If getColumIndex(spr, "SEQ") > -1 Then z9996.SEQ = getDataM(spr, getColumIndex(spr, "SEQ"), xRow)
            If getColumIndex(spr, "CustomerCode") > -1 Then z9996.CustomerCode = getDataM(spr, getColumIndex(spr, "CustomerCode"), xRow)
            If getColumIndex(spr, "CHK01") > -1 Then z9996.CHK01 = getDataM(spr, getColumIndex(spr, "CHK01"), xRow)
            If getColumIndex(spr, "CHK02") > -1 Then z9996.CHK02 = getDataM(spr, getColumIndex(spr, "CHK02"), xRow)
            If getColumIndex(spr, "CHK03") > -1 Then z9996.CHK03 = getDataM(spr, getColumIndex(spr, "CHK03"), xRow)
            If getColumIndex(spr, "CHK04") > -1 Then z9996.CHK04 = getDataM(spr, getColumIndex(spr, "CHK04"), xRow)
            If getColumIndex(spr, "CHK05") > -1 Then z9996.CHK05 = getDataM(spr, getColumIndex(spr, "CHK05"), xRow)
            If getColumIndex(spr, "REMARK") > -1 Then z9996.REMARK = getDataM(spr, getColumIndex(spr, "REMARK"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K9996_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K9996_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z9996 As T9996_AREA, Job As String, SITE As String, SANO As String, SEQ As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K9996_MOVE = False

        Try
            If READ_PFK9996(SITE, SANO, SEQ) = True Then
                z9996 = D9996
                K9996_MOVE = True
            Else
                z9996 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK9996")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "SITE" : z9996.SITE = Children(i).Code
                                Case "SANO" : z9996.SANO = Children(i).Code
                                Case "SEQ" : z9996.SEQ = Children(i).Code
                                Case "CUSTOMERCODE" : z9996.CustomerCode = Children(i).Code
                                Case "CHK01" : z9996.CHK01 = Children(i).Code
                                Case "CHK02" : z9996.CHK02 = Children(i).Code
                                Case "CHK03" : z9996.CHK03 = Children(i).Code
                                Case "CHK04" : z9996.CHK04 = Children(i).Code
                                Case "CHK05" : z9996.CHK05 = Children(i).Code
                                Case "REMARK" : z9996.REMARK = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "SITE" : z9996.SITE = Children(i).Data
                                Case "SANO" : z9996.SANO = Children(i).Data
                                Case "SEQ" : z9996.SEQ = Children(i).Data
                                Case "CUSTOMERCODE" : z9996.CustomerCode = Children(i).Data
                                Case "CHK01" : z9996.CHK01 = Children(i).Data
                                Case "CHK02" : z9996.CHK02 = Children(i).Data
                                Case "CHK03" : z9996.CHK03 = Children(i).Data
                                Case "CHK04" : z9996.CHK04 = Children(i).Data
                                Case "CHK05" : z9996.CHK05 = Children(i).Data
                                Case "REMARK" : z9996.REMARK = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K9996_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K9996_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z9996 As T9996_AREA, Job As String, CheckClear As Boolean, SITE As String, SANO As String, SEQ As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K9996_MOVE = False

        Try
            If READ_PFK9996(SITE, SANO, SEQ) = True Then
                z9996 = D9996
                K9996_MOVE = True
            Else
                If CheckClear = True Then z9996 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK9996")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "SITE" : z9996.SITE = Children(i).Code
                                Case "SANO" : z9996.SANO = Children(i).Code
                                Case "SEQ" : z9996.SEQ = Children(i).Code
                                Case "CUSTOMERCODE" : z9996.CustomerCode = Children(i).Code
                                Case "CHK01" : z9996.CHK01 = Children(i).Code
                                Case "CHK02" : z9996.CHK02 = Children(i).Code
                                Case "CHK03" : z9996.CHK03 = Children(i).Code
                                Case "CHK04" : z9996.CHK04 = Children(i).Code
                                Case "CHK05" : z9996.CHK05 = Children(i).Code
                                Case "REMARK" : z9996.REMARK = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "SITE" : z9996.SITE = Children(i).Data
                                Case "SANO" : z9996.SANO = Children(i).Data
                                Case "SEQ" : z9996.SEQ = Children(i).Data
                                Case "CUSTOMERCODE" : z9996.CustomerCode = Children(i).Data
                                Case "CHK01" : z9996.CHK01 = Children(i).Data
                                Case "CHK02" : z9996.CHK02 = Children(i).Data
                                Case "CHK03" : z9996.CHK03 = Children(i).Data
                                Case "CHK04" : z9996.CHK04 = Children(i).Data
                                Case "CHK05" : z9996.CHK05 = Children(i).Data
                                Case "REMARK" : z9996.REMARK = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K9996_MOVE", vbCritical)
        End Try
    End Function

End Module
