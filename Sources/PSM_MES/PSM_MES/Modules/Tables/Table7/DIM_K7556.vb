'=========================================================================================================================================================
'   TABLE : (PFK7556)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7556

    Structure T7556_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public TABLE As String  '			nvarchar(20)		*
        Public PAREMETER As String  '			nvarchar(50)		*
        Public SEQ As Double  '			decimal		*
        Public FileName As String  '			nvarchar(200)
        Public ImageData As Object
        Public FileType As String  '			nvarchar(10)
        Public AttachDate As String  '			char(8)
        Public AttachIncharge As String  '			char(8)
        Public Time As String  '			nvarchar(20)
        '=========================================================================================================================================================
    End Structure

    Public D7556 As T7556_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK7556(TABLE As String, PAREMETER As String, SEQ As Double) As Boolean
        READ_PFK7556 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7556 "
            SQL = SQL & " WHERE K7556_TABLE		 = '" & TABLE & "' "
            SQL = SQL & "   AND K7556_PAREMETER		 = '" & PAREMETER & "' "
            SQL = SQL & "   AND K7556_SEQ		 =  " & SEQ & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7556_CLEAR() : GoTo SKIP_READ_PFK7556

            READ_PFK7556 = True

SKIP_READ_PFK7556:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7556", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK7556(TABLE As String, PAREMETER As String, SEQ As Double, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7556 "
            SQL = SQL & " WHERE K7556_TABLE		 = '" & TABLE & "' "
            SQL = SQL & "   AND K7556_PAREMETER		 = '" & PAREMETER & "' "
            SQL = SQL & "   AND K7556_SEQ		 =  " & SEQ & "  "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK7556", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK7556(z7556 As T7556_AREA) As Boolean
        WRITE_PFK7556 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z7556)

            SQL = " INSERT INTO PFK7556 "
            SQL = SQL & " ( "
            SQL = SQL & " K7556_TABLE,"
            SQL = SQL & " K7556_PAREMETER,"
            SQL = SQL & " K7556_SEQ,"
            SQL = SQL & " K7556_FileName,"
            SQL = SQL & " K7556_ImageData,"
            SQL = SQL & " K7556_FileType,"
            SQL = SQL & " K7556_AttachDate,"
            SQL = SQL & " K7556_AttachIncharge,"
            SQL = SQL & " K7556_Time "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z7556.TABLE) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7556.PAREMETER) & "', "
            SQL = SQL & "   " & FormatSQL(z7556.SEQ) & ", "
            SQL = SQL & "  N'" & FormatSQL(z7556.FileName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7556.ImageData) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7556.FileType) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7556.AttachDate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7556.AttachIncharge) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7556.Time) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK7556 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK7556", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK7556(z7556 As T7556_AREA) As Boolean
        REWRITE_PFK7556 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z7556)

            SQL = " UPDATE PFK7556 SET "
            SQL = SQL & "    K7556_FileName      = N'" & FormatSQL(z7556.FileName) & "', "
            SQL = SQL & "    K7556_ImageData      = N'" & FormatSQL(z7556.ImageData) & "', "
            SQL = SQL & "    K7556_FileType      = N'" & FormatSQL(z7556.FileType) & "', "
            SQL = SQL & "    K7556_AttachDate      = N'" & FormatSQL(z7556.AttachDate) & "', "
            SQL = SQL & "    K7556_AttachIncharge      = N'" & FormatSQL(z7556.AttachIncharge) & "', "
            SQL = SQL & "    K7556_Time      = N'" & FormatSQL(z7556.Time) & "'  "
            SQL = SQL & " WHERE K7556_TABLE		 = '" & z7556.TABLE & "' "
            SQL = SQL & "   AND K7556_PAREMETER		 = '" & z7556.PAREMETER & "' "
            SQL = SQL & "   AND K7556_SEQ		 =  " & z7556.SEQ & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK7556 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK7556", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK7556(z7556 As T7556_AREA) As Boolean
        DELETE_PFK7556 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK7556 "
            SQL = SQL & " WHERE K7556_TABLE		 = '" & z7556.TABLE & "' "
            SQL = SQL & "   AND K7556_PAREMETER		 = '" & z7556.PAREMETER & "' "
            SQL = SQL & "   AND K7556_SEQ		 =  " & z7556.SEQ & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK7556 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK7556", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D7556_CLEAR()
        Try

            D7556.TABLE = ""
            D7556.PAREMETER = ""
            D7556.SEQ = 0
            D7556.FileName = ""
            D7556.ImageData = Nothing
            D7556.FileType = ""
            D7556.AttachDate = ""
            D7556.AttachIncharge = ""
            D7556.Time = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D7556_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x7556 As T7556_AREA)
        Try

            x7556.TABLE = trim$(x7556.TABLE)
            x7556.PAREMETER = trim$(x7556.PAREMETER)
            x7556.SEQ = trim$(x7556.SEQ)
            x7556.FileName = trim$(x7556.FileName)
            x7556.ImageData = trim$(x7556.ImageData)
            x7556.FileType = trim$(x7556.FileType)
            x7556.AttachDate = trim$(x7556.AttachDate)
            x7556.AttachIncharge = trim$(x7556.AttachIncharge)
            x7556.Time = trim$(x7556.Time)

            If trim$(x7556.TABLE) = "" Then x7556.TABLE = Space(1)
            If trim$(x7556.PAREMETER) = "" Then x7556.PAREMETER = Space(1)
            If trim$(x7556.SEQ) = "" Then x7556.SEQ = 0
            If trim$(x7556.FileName) = "" Then x7556.FileName = Space(1)
            If trim$(x7556.ImageData) = "" Then x7556.ImageData = Space(1)
            If trim$(x7556.FileType) = "" Then x7556.FileType = Space(1)
            If trim$(x7556.AttachDate) = "" Then x7556.AttachDate = Space(1)
            If trim$(x7556.AttachIncharge) = "" Then x7556.AttachIncharge = Space(1)
            If trim$(x7556.Time) = "" Then x7556.Time = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K7556_MOVE(rs7556 As SqlClient.SqlDataReader)
        Try

            Call D7556_CLEAR()

            If IsdbNull(rs7556!K7556_TABLE) = False Then D7556.TABLE = Trim$(rs7556!K7556_TABLE)
            If IsdbNull(rs7556!K7556_PAREMETER) = False Then D7556.PAREMETER = Trim$(rs7556!K7556_PAREMETER)
            If IsdbNull(rs7556!K7556_SEQ) = False Then D7556.SEQ = Trim$(rs7556!K7556_SEQ)
            If IsdbNull(rs7556!K7556_FileName) = False Then D7556.FileName = Trim$(rs7556!K7556_FileName)
            If IsdbNull(rs7556!K7556_ImageData) = False Then D7556.ImageData = Trim$(rs7556!K7556_ImageData)
            If IsdbNull(rs7556!K7556_FileType) = False Then D7556.FileType = Trim$(rs7556!K7556_FileType)
            If IsdbNull(rs7556!K7556_AttachDate) = False Then D7556.AttachDate = Trim$(rs7556!K7556_AttachDate)
            If IsdbNull(rs7556!K7556_AttachIncharge) = False Then D7556.AttachIncharge = Trim$(rs7556!K7556_AttachIncharge)
            If IsdbNull(rs7556!K7556_Time) = False Then D7556.Time = Trim$(rs7556!K7556_Time)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K7556_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K7556_MOVE(rs7556 As DataRow)
        Try

            Call D7556_CLEAR()

            If IsdbNull(rs7556!K7556_TABLE) = False Then D7556.TABLE = Trim$(rs7556!K7556_TABLE)
            If IsdbNull(rs7556!K7556_PAREMETER) = False Then D7556.PAREMETER = Trim$(rs7556!K7556_PAREMETER)
            If IsdbNull(rs7556!K7556_SEQ) = False Then D7556.SEQ = Trim$(rs7556!K7556_SEQ)
            If IsdbNull(rs7556!K7556_FileName) = False Then D7556.FileName = Trim$(rs7556!K7556_FileName)
            If IsdbNull(rs7556!K7556_ImageData) = False Then D7556.ImageData = Trim$(rs7556!K7556_ImageData)
            If IsdbNull(rs7556!K7556_FileType) = False Then D7556.FileType = Trim$(rs7556!K7556_FileType)
            If IsdbNull(rs7556!K7556_AttachDate) = False Then D7556.AttachDate = Trim$(rs7556!K7556_AttachDate)
            If IsdbNull(rs7556!K7556_AttachIncharge) = False Then D7556.AttachIncharge = Trim$(rs7556!K7556_AttachIncharge)
            If IsdbNull(rs7556!K7556_Time) = False Then D7556.Time = Trim$(rs7556!K7556_Time)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K7556_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K7556_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z7556 As T7556_AREA, TABLE As String, PAREMETER As String, SEQ As Double) As Boolean

        K7556_MOVE = False

        Try
            If READ_PFK7556(TABLE, PAREMETER, SEQ) = True Then
                z7556 = D7556
                K7556_MOVE = True
            Else
                z7556 = Nothing
            End If

            If getColumIndex(spr, "TABLE") > -1 Then z7556.TABLE = getDataM(spr, getColumIndex(spr, "TABLE"), xRow)
            If getColumIndex(spr, "PAREMETER") > -1 Then z7556.PAREMETER = getDataM(spr, getColumIndex(spr, "PAREMETER"), xRow)
            If getColumIndex(spr, "SEQ") > -1 Then z7556.SEQ = getDataM(spr, getColumIndex(spr, "SEQ"), xRow)
            If getColumIndex(spr, "FileName") > -1 Then z7556.FileName = getDataM(spr, getColumIndex(spr, "FileName"), xRow)
            If getColumIndex(spr, "ImageData") > -1 Then z7556.ImageData = getDataM(spr, getColumIndex(spr, "ImageData"), xRow)
            If getColumIndex(spr, "FileType") > -1 Then z7556.FileType = getDataM(spr, getColumIndex(spr, "FileType"), xRow)
            If getColumIndex(spr, "AttachDate") > -1 Then z7556.AttachDate = getDataM(spr, getColumIndex(spr, "AttachDate"), xRow)
            If getColumIndex(spr, "AttachIncharge") > -1 Then z7556.AttachIncharge = getDataM(spr, getColumIndex(spr, "AttachIncharge"), xRow)
            If getColumIndex(spr, "Time") > -1 Then z7556.Time = getDataM(spr, getColumIndex(spr, "Time"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7556_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K7556_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z7556 As T7556_AREA, CheckClear As Boolean, TABLE As String, PAREMETER As String, SEQ As Double) As Boolean

        K7556_MOVE = False

        Try
            If READ_PFK7556(TABLE, PAREMETER, SEQ) = True Then
                z7556 = D7556
                K7556_MOVE = True
            Else
                If CheckClear = True Then z7556 = Nothing
            End If

            If getColumIndex(spr, "TABLE") > -1 Then z7556.TABLE = getDataM(spr, getColumIndex(spr, "TABLE"), xRow)
            If getColumIndex(spr, "PAREMETER") > -1 Then z7556.PAREMETER = getDataM(spr, getColumIndex(spr, "PAREMETER"), xRow)
            If getColumIndex(spr, "SEQ") > -1 Then z7556.SEQ = getDataM(spr, getColumIndex(spr, "SEQ"), xRow)
            If getColumIndex(spr, "FileName") > -1 Then z7556.FileName = getDataM(spr, getColumIndex(spr, "FileName"), xRow)
            If getColumIndex(spr, "ImageData") > -1 Then z7556.ImageData = getDataM(spr, getColumIndex(spr, "ImageData"), xRow)
            If getColumIndex(spr, "FileType") > -1 Then z7556.FileType = getDataM(spr, getColumIndex(spr, "FileType"), xRow)
            If getColumIndex(spr, "AttachDate") > -1 Then z7556.AttachDate = getDataM(spr, getColumIndex(spr, "AttachDate"), xRow)
            If getColumIndex(spr, "AttachIncharge") > -1 Then z7556.AttachIncharge = getDataM(spr, getColumIndex(spr, "AttachIncharge"), xRow)
            If getColumIndex(spr, "Time") > -1 Then z7556.Time = getDataM(spr, getColumIndex(spr, "Time"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7556_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K7556_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z7556 As T7556_AREA, Job As String, TABLE As String, PAREMETER As String, SEQ As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K7556_MOVE = False

        Try
            If READ_PFK7556(TABLE, PAREMETER, SEQ) = True Then
                z7556 = D7556
                K7556_MOVE = True
            Else
                z7556 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7556")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "TABLE" : z7556.TABLE = Children(i).Code
                                Case "PAREMETER" : z7556.PAREMETER = Children(i).Code
                                Case "SEQ" : z7556.SEQ = Children(i).Code
                                Case "FILENAME" : z7556.FileName = Children(i).Code
                                Case "IMAGEDATA" : z7556.ImageData = Children(i).Code
                                Case "FILETYPE" : z7556.FileType = Children(i).Code
                                Case "ATTACHDATE" : z7556.AttachDate = Children(i).Code
                                Case "ATTACHINCHARGE" : z7556.AttachIncharge = Children(i).Code
                                Case "TIME" : z7556.Time = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "TABLE" : z7556.TABLE = Children(i).Data
                                Case "PAREMETER" : z7556.PAREMETER = Children(i).Data
                                Case "SEQ" : z7556.SEQ = Children(i).Data
                                Case "FILENAME" : z7556.FileName = Children(i).Data
                                Case "IMAGEDATA" : z7556.ImageData = Children(i).Data
                                Case "FILETYPE" : z7556.FileType = Children(i).Data
                                Case "ATTACHDATE" : z7556.AttachDate = Children(i).Data
                                Case "ATTACHINCHARGE" : z7556.AttachIncharge = Children(i).Data
                                Case "TIME" : z7556.Time = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7556_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K7556_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z7556 As T7556_AREA, Job As String, CheckClear As Boolean, TABLE As String, PAREMETER As String, SEQ As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K7556_MOVE = False

        Try
            If READ_PFK7556(TABLE, PAREMETER, SEQ) = True Then
                z7556 = D7556
                K7556_MOVE = True
            Else
                If CheckClear = True Then z7556 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7556")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "TABLE" : z7556.TABLE = Children(i).Code
                                Case "PAREMETER" : z7556.PAREMETER = Children(i).Code
                                Case "SEQ" : z7556.SEQ = Children(i).Code
                                Case "FILENAME" : z7556.FileName = Children(i).Code
                                Case "IMAGEDATA" : z7556.ImageData = Children(i).Code
                                Case "FILETYPE" : z7556.FileType = Children(i).Code
                                Case "ATTACHDATE" : z7556.AttachDate = Children(i).Code
                                Case "ATTACHINCHARGE" : z7556.AttachIncharge = Children(i).Code
                                Case "TIME" : z7556.Time = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "TABLE" : z7556.TABLE = Children(i).Data
                                Case "PAREMETER" : z7556.PAREMETER = Children(i).Data
                                Case "SEQ" : z7556.SEQ = Children(i).Data
                                Case "FILENAME" : z7556.FileName = Children(i).Data
                                Case "IMAGEDATA" : z7556.ImageData = Children(i).Data
                                Case "FILETYPE" : z7556.FileType = Children(i).Data
                                Case "ATTACHDATE" : z7556.AttachDate = Children(i).Data
                                Case "ATTACHINCHARGE" : z7556.AttachIncharge = Children(i).Data
                                Case "TIME" : z7556.Time = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7556_MOVE", vbCritical)
        End Try
    End Function

End Module
