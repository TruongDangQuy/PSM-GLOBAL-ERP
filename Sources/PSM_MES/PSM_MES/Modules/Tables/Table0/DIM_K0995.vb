'=========================================================================================================================================================
'   TABLE : (PFK0995)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K0995

    Structure T0995_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public Key As Double  '			decimal		*
        Public Id As String  '			varchar(30)
        Public PartKey As String  '			char(8)
        Public DateChat As String  '			char(8)
        Public TimeChat As String  '			varchar(30)
        Public Content As String  '			nchar(100)
        Public Remark As String  '			nchar(100)
        '=========================================================================================================================================================
    End Structure

    Public D0995 As T0995_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK0995(KEY As Double) As Boolean
        READ_PFK0995 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK0995 "
            SQL = SQL & " WHERE K0995_Key		 =  " & Key & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D0995_CLEAR() : GoTo SKIP_READ_PFK0995

            Call K0995_MOVE(rd)
            READ_PFK0995 = True

SKIP_READ_PFK0995:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK0995", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK0995(KEY As Double, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK0995 "
            SQL = SQL & " WHERE K0995_Key		 =  " & Key & "  "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK0995", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK0995(z0995 As T0995_AREA) As Boolean
        WRITE_PFK0995 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z0995)

            SQL = " INSERT INTO PFK0995 "
            SQL = SQL & " ( "
            SQL = SQL & " K0995_Id,"
            SQL = SQL & " K0995_PartKey,"
            SQL = SQL & " K0995_DateChat,"
            SQL = SQL & " K0995_TimeChat,"
            SQL = SQL & " K0995_Content,"
            SQL = SQL & " K0995_Remark "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  '" & z0995.Id & "', "
            SQL = SQL & "  '" & z0995.PartKey & "', "
            SQL = SQL & "  '" & z0995.DateChat & "', "
            SQL = SQL & "  '" & z0995.TimeChat & "', "
            SQL = SQL & "  N'" & z0995.Content & "', "
            SQL = SQL & "  '" & z0995.Remark & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK0995 = True
            Exit Function
        Catch ex As Exception
            'Call MsgBoxP("WRITE_PFK0995", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK0995(z0995 As T0995_AREA) As Boolean
        REWRITE_PFK0995 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z0995)

            SQL = " UPDATE PFK0995 SET "
            SQL = SQL & "    K0995_Id      = '" & z0995.Id & "', "
            SQL = SQL & "    K0995_PartKey      = '" & z0995.PartKey & "', "
            SQL = SQL & "    K0995_DateChat      = '" & z0995.DateChat & "', "
            SQL = SQL & "    K0995_TimeChat      = '" & z0995.TimeChat & "', "
            SQL = SQL & "    K0995_Content      = N'" & z0995.Content & "', "
            SQL = SQL & "    K0995_Remark      = '" & z0995.Remark & "'  "
            SQL = SQL & " WHERE K0995_Key		 =  " & z0995.Key & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK0995 = True

            Exit Function
        Catch ex As Exception
            ' Call MsgBoxP("REWRITE_PFK0995", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK0995(z0995 As T0995_AREA) As Boolean
        DELETE_PFK0995 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK0995 "
            SQL = SQL & " WHERE K0995_Key		 =  " & z0995.Key & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK0995 = True
            Exit Function
        Catch ex As Exception
            '  Call MsgBoxP("DELETE_PFK0995", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D0995_CLEAR()
        Try

            D0995.Key = 0
            D0995.Id = ""
            D0995.PartKey = ""
            D0995.DateChat = ""
            D0995.TimeChat = ""
            D0995.Content = ""
            D0995.Remark = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D0995_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x0995 As T0995_AREA)
        Try

            x0995.Key = trim$(x0995.Key)
            x0995.Id = trim$(x0995.Id)
            x0995.PartKey = trim$(x0995.PartKey)
            x0995.DateChat = trim$(x0995.DateChat)
            x0995.TimeChat = trim$(x0995.TimeChat)
            x0995.Content = trim$(x0995.Content)
            x0995.Remark = trim$(x0995.Remark)

            If trim$(x0995.Key) = "" Then x0995.Key = 0
            If trim$(x0995.Id) = "" Then x0995.Id = Space(1)
            If trim$(x0995.PartKey) = "" Then x0995.PartKey = Space(1)
            If trim$(x0995.DateChat) = "" Then x0995.DateChat = Space(1)
            If trim$(x0995.TimeChat) = "" Then x0995.TimeChat = Space(1)
            If trim$(x0995.Content) = "" Then x0995.Content = Space(1)
            If trim$(x0995.Remark) = "" Then x0995.Remark = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K0995_MOVE(rs0995 As SqlClient.SqlDataReader)
        Try

            Call D0995_CLEAR()

            If IsdbNull(rs0995!K0995_Key) = False Then D0995.Key = Trim$(rs0995!K0995_Key)
            If IsdbNull(rs0995!K0995_Id) = False Then D0995.Id = Trim$(rs0995!K0995_Id)
            If IsdbNull(rs0995!K0995_PartKey) = False Then D0995.PartKey = Trim$(rs0995!K0995_PartKey)
            If IsdbNull(rs0995!K0995_DateChat) = False Then D0995.DateChat = Trim$(rs0995!K0995_DateChat)
            If IsdbNull(rs0995!K0995_TimeChat) = False Then D0995.TimeChat = Trim$(rs0995!K0995_TimeChat)
            If IsdbNull(rs0995!K0995_Content) = False Then D0995.Content = Trim$(rs0995!K0995_Content)
            If IsdbNull(rs0995!K0995_Remark) = False Then D0995.Remark = Trim$(rs0995!K0995_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K0995_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K0995_MOVE(rs0995 As DataRow)
        Try

            Call D0995_CLEAR()

            If IsdbNull(rs0995!K0995_Key) = False Then D0995.Key = Trim$(rs0995!K0995_Key)
            If IsdbNull(rs0995!K0995_Id) = False Then D0995.Id = Trim$(rs0995!K0995_Id)
            If IsdbNull(rs0995!K0995_PartKey) = False Then D0995.PartKey = Trim$(rs0995!K0995_PartKey)
            If IsdbNull(rs0995!K0995_DateChat) = False Then D0995.DateChat = Trim$(rs0995!K0995_DateChat)
            If IsdbNull(rs0995!K0995_TimeChat) = False Then D0995.TimeChat = Trim$(rs0995!K0995_TimeChat)
            If IsdbNull(rs0995!K0995_Content) = False Then D0995.Content = Trim$(rs0995!K0995_Content)
            If IsdbNull(rs0995!K0995_Remark) = False Then D0995.Remark = Trim$(rs0995!K0995_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K0995_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K0995_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z0995 As T0995_AREA, KEY As Double) As Boolean

        K0995_MOVE = False

        Try
            If READ_PFK0995(KEY) = True Then
                z0995 = D0995
                K0995_MOVE = True
            Else
                z0995 = Nothing
            End If

            If getColumIndex(spr, "Key") > -1 Then z0995.Key = getDataM(spr, getColumIndex(spr, "Key"), xRow)
            If getColumIndex(spr, "Id") > -1 Then z0995.Id = getDataM(spr, getColumIndex(spr, "Id"), xRow)
            If getColumIndex(spr, "PartKey") > -1 Then z0995.PartKey = getDataM(spr, getColumIndex(spr, "PartKey"), xRow)
            If getColumIndex(spr, "DateChat") > -1 Then z0995.DateChat = getDataM(spr, getColumIndex(spr, "DateChat"), xRow)
            If getColumIndex(spr, "TimeChat") > -1 Then z0995.TimeChat = getDataM(spr, getColumIndex(spr, "TimeChat"), xRow)
            If getColumIndex(spr, "Content") > -1 Then z0995.Content = getDataM(spr, getColumIndex(spr, "Content"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z0995.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K0995_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K0995_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z0995 As T0995_AREA, Job As String, KEY As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K0995_MOVE = False

        Try
            If READ_PFK0995(KEY) = True Then
                z0995 = D0995
                K0995_MOVE = True
            Else
                z0995 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK0995")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "Key" : z0995.Key = Children(i).Code
                                Case "Id" : z0995.Id = Children(i).Code
                                Case "PartKey" : z0995.PartKey = Children(i).Code
                                Case "DateChat" : z0995.DateChat = Children(i).Code
                                Case "TimeChat" : z0995.TimeChat = Children(i).Code
                                Case "Content" : z0995.Content = Children(i).Code
                                Case "Remark" : z0995.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "Key" : z0995.Key = Children(i).Data
                                Case "Id" : z0995.Id = Children(i).Data
                                Case "PartKey" : z0995.PartKey = Children(i).Data
                                Case "DateChat" : z0995.DateChat = Children(i).Data
                                Case "TimeChat" : z0995.TimeChat = Children(i).Data
                                Case "Content" : z0995.Content = Children(i).Data
                                Case "Remark" : z0995.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K0995_MOVE", vbCritical)
        End Try
    End Function

End Module
