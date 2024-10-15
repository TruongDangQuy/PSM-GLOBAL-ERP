'=========================================================================================================================================================
'   TABLE : (PFK9900)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K9900

    Structure T9900_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public NotifySeting As String  '				char(8)	
        Public NotifySetingSeq As String  '				decimal(18, 0)	
        Public TimeStart As String  '				nvarchar(5)	
        Public TimeEnd As String  '				nvarchar(5)	
        Public TimeRefresh As String  '				nvarchar(50)	
        Public DashboardUse As String  '				nvarchar(500)	
        Public CheckUse As String  '				char(1)	
        Public DateCreate As String  '				char(8)	
        Public InchargeCreate As String  '				char(8)	
        Public DateUpdate As String  '				char(8)	
        Public InchargeUpdate As String  '				char(8)	
        '=========================================================================================================================================================
    End Structure

    Public D9900 As T9900_AREA

    '=========================================================================================================================================================
    ' DIRECT READ TOP 1
    '=========================================================================================================================================================
    Public Function READ_PFK9900() As Boolean
        READ_PFK9900 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT TOP 1 * FROM PFK9900 "
            
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D9900_CLEAR() : GoTo SKIP_READ_PFK9900

            Call K9900_MOVE(rd)
            READ_PFK9900 = True

SKIP_READ_PFK9900:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK9900", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK9900(NotifySeting As String, NotifySetingSeq As String) As Boolean
        READ_PFK9900 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK9900 "
            SQL = SQL & " WHERE K9900_NotifySeting		 = '" & NotifySeting & "' "
            SQL = SQL & " AND   K9900_NotifySetingSeq		 = '" & NotifySetingSeq & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D9900_CLEAR() : GoTo SKIP_READ_PFK9900

            Call K9900_MOVE(rd)
            READ_PFK9900 = True

SKIP_READ_PFK9900:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK9900", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK9900(NotifySeting As String, NotifySetingSeq As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK9900 "
            SQL = SQL & " WHERE K9900_NotifySeting		 = '" & NotifySeting & "' "
            SQL = SQL & " AND   K9900_NotifySetingSeq		 = '" & NotifySetingSeq & "' "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK9900", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK9900(z9900 As T9900_AREA) As Boolean
        WRITE_PFK9900 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z9900)

            SQL = " INSERT INTO PFK9900 "
            SQL = SQL & " ( "
            SQL = SQL & "   K9900_NotifySeting"
            SQL = SQL & " , K9900_NotifySetingSeq"
            SQL = SQL & " , K9900_TimeStart"
            SQL = SQL & " , K9900_TimeEnd"
            SQL = SQL & " , K9900_TimeRefresh"
            SQL = SQL & " , K9900_DashboardUse"
            SQL = SQL & " , K9900_CheckUse"
            SQL = SQL & " , K9900_DateCreate"
            SQL = SQL & " , K9900_InchargeCreate"
            SQL = SQL & " , K9900_DateUpdate"
            SQL = SQL & " , K9900_InchargeUpdate"
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z9900.NotifySeting) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9900.NotifySetingSeq) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9900.TimeStart) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9900.TimeEnd) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9900.TimeRefresh) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9900.DashboardUse) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9900.CheckUse) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9900.DateCreate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9900.InchargeCreate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9900.DateUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9900.InchargeUpdate) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK9900 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK9900", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK9900(z9900 As T9900_AREA) As Boolean
        REWRITE_PFK9900 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z9900)

            SQL = " UPDATE PFK9900 SET "
            SQL = SQL & " K9900_TimeStart = N'" & FormatSQL(z9900.TimeStart) & "', "
            SQL = SQL & " K9900_TimeEnd = N'" & FormatSQL(z9900.TimeEnd) & "', "
            SQL = SQL & " K9900_TimeRefresh = N'" & FormatSQL(z9900.TimeRefresh) & "', "
            SQL = SQL & " K9900_DashboardUse = N'" & FormatSQL(z9900.DashboardUse) & "', "
            SQL = SQL & " K9900_CheckUse = N'" & FormatSQL(z9900.CheckUse) & "', "
            SQL = SQL & " K9900_DateCreate = N'" & FormatSQL(z9900.DateCreate) & "', "
            SQL = SQL & " K9900_InchargeCreate = N'" & FormatSQL(z9900.InchargeCreate) & "', "
            SQL = SQL & " K9900_DateUpdate = N'" & FormatSQL(z9900.DateUpdate) & "', "
            SQL = SQL & " K9900_InchargeUpdate = N'" & FormatSQL(z9900.InchargeUpdate) & "' "
            SQL = SQL & " WHERE K9900_NotifySeting = N'" & FormatSQL(z9900.NotifySeting) & "' "
            SQL = SQL & " AND   K9900_NotifySetingSeq = N'" & FormatSQL(z9900.NotifySetingSeq) & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK9900 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK9900", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK9900(z9900 As T9900_AREA) As Boolean
        DELETE_PFK9900 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK9900 "
            SQL = SQL & " WHERE K9900_NotifySeting = N'" & FormatSQL(z9900.NotifySeting) & "', "
            SQL = SQL & " AND   K9900_NotifySetingSeq = N'" & FormatSQL(z9900.NotifySetingSeq) & "', "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK9900 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK9900", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D9900_CLEAR()
        Try

            D9900.NotifySeting = ""
            D9900.NotifySetingSeq = ""
            D9900.TimeStart = ""
            D9900.TimeEnd = ""
            D9900.TimeRefresh = ""
            D9900.DashboardUse = ""
            D9900.CheckUse = ""
            D9900.DateCreate = ""
            D9900.InchargeCreate = ""
            D9900.DateUpdate = ""
            D9900.InchargeUpdate = ""

            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D9900_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x9900 As T9900_AREA)
        Try


            x9900.NotifySeting = Trim$(x9900.NotifySeting)
            x9900.NotifySetingSeq = Trim$(x9900.NotifySetingSeq)
            x9900.TimeStart = Trim$(x9900.TimeStart)
            x9900.TimeEnd = Trim$(x9900.TimeEnd)
            x9900.TimeRefresh = Trim$(x9900.TimeRefresh)
            x9900.DashboardUse = Trim$(x9900.DashboardUse)
            x9900.CheckUse = Trim$(x9900.CheckUse)
            x9900.DateCreate = Trim$(x9900.DateCreate)
            x9900.InchargeCreate = Trim$(x9900.InchargeCreate)
            x9900.DateUpdate = Trim$(x9900.DateUpdate)
            x9900.InchargeUpdate = Trim$(x9900.InchargeUpdate)

            If Trim$(x9900.NotifySeting) = "" Then x9900.NotifySeting = Space(1)
            If Trim$(x9900.NotifySetingSeq) = "" Then x9900.NotifySetingSeq = Space(1)
            If Trim$(x9900.TimeStart) = "" Then x9900.TimeStart = Space(1)
            If Trim$(x9900.TimeEnd) = "" Then x9900.TimeEnd = Space(1)
            If Trim$(x9900.TimeRefresh) = "" Then x9900.TimeRefresh = Space(1)
            If Trim$(x9900.DashboardUse) = "" Then x9900.DashboardUse = Space(1)
            If Trim$(x9900.CheckUse) = "" Then x9900.CheckUse = Space(1)
            If Trim$(x9900.DateCreate) = "" Then x9900.DateCreate = Space(1)
            If Trim$(x9900.InchargeCreate) = "" Then x9900.InchargeCreate = Space(1)
            If Trim$(x9900.DateUpdate) = "" Then x9900.DateUpdate = Space(1)
            If Trim$(x9900.InchargeUpdate) = "" Then x9900.InchargeUpdate = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K9900_MOVE(rs9900 As SqlClient.SqlDataReader)
        Try

            Call D9900_CLEAR()

            If IsDBNull(rs9900!K9900_NotifySeting) = False Then D9900.NotifySeting = Trim$(rs9900!K9900_NotifySeting)
            If IsDBNull(rs9900!K9900_NotifySetingSeq) = False Then D9900.NotifySetingSeq = Trim$(rs9900!K9900_NotifySetingSeq)
            If IsDBNull(rs9900!K9900_TimeStart) = False Then D9900.TimeStart = Trim$(rs9900!K9900_TimeStart)
            If IsDBNull(rs9900!K9900_TimeEnd) = False Then D9900.TimeEnd = Trim$(rs9900!K9900_TimeEnd)
            If IsDBNull(rs9900!K9900_TimeRefresh) = False Then D9900.TimeRefresh = Trim$(rs9900!K9900_TimeRefresh)
            If IsDBNull(rs9900!K9900_DashboardUse) = False Then D9900.DashboardUse = Trim$(rs9900!K9900_DashboardUse)
            If IsDBNull(rs9900!K9900_CheckUse) = False Then D9900.CheckUse = Trim$(rs9900!K9900_CheckUse)
            If IsDBNull(rs9900!K9900_DateCreate) = False Then D9900.DateCreate = Trim$(rs9900!K9900_DateCreate)
            If IsDBNull(rs9900!K9900_InchargeCreate) = False Then D9900.InchargeCreate = Trim$(rs9900!K9900_InchargeCreate)
            If IsDBNull(rs9900!K9900_DateUpdate) = False Then D9900.DateUpdate = Trim$(rs9900!K9900_DateUpdate)
            If IsDBNull(rs9900!K9900_InchargeUpdate) = False Then D9900.InchargeUpdate = Trim$(rs9900!K9900_InchargeUpdate)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K9900_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K9900_MOVE(rs9900 As DataRow)
        Try

            Call D9900_CLEAR()

            If IsDBNull(rs9900!K9900_NotifySeting) = False Then D9900.NotifySeting = Trim$(rs9900!K9900_NotifySeting)
            If IsDBNull(rs9900!K9900_NotifySetingSeq) = False Then D9900.NotifySetingSeq = Trim$(rs9900!K9900_NotifySetingSeq)
            If IsDBNull(rs9900!K9900_TimeStart) = False Then D9900.TimeStart = Trim$(rs9900!K9900_TimeStart)
            If IsDBNull(rs9900!K9900_TimeEnd) = False Then D9900.TimeEnd = Trim$(rs9900!K9900_TimeEnd)
            If IsDBNull(rs9900!K9900_TimeRefresh) = False Then D9900.TimeRefresh = Trim$(rs9900!K9900_TimeRefresh)
            If IsDBNull(rs9900!K9900_DashboardUse) = False Then D9900.DashboardUse = Trim$(rs9900!K9900_DashboardUse)
            If IsDBNull(rs9900!K9900_CheckUse) = False Then D9900.CheckUse = Trim$(rs9900!K9900_CheckUse)
            If IsDBNull(rs9900!K9900_DateCreate) = False Then D9900.DateCreate = Trim$(rs9900!K9900_DateCreate)
            If IsDBNull(rs9900!K9900_InchargeCreate) = False Then D9900.InchargeCreate = Trim$(rs9900!K9900_InchargeCreate)
            If IsDBNull(rs9900!K9900_DateUpdate) = False Then D9900.DateUpdate = Trim$(rs9900!K9900_DateUpdate)
            If IsDBNull(rs9900!K9900_InchargeUpdate) = False Then D9900.InchargeUpdate = Trim$(rs9900!K9900_InchargeUpdate)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K9900_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K9900_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z9900 As T9900_AREA, NotifySeting As String, NotifySetingSeq As String) As Boolean

        K9900_MOVE = False

        Try
            If READ_PFK9900(NotifySeting, NotifySetingSeq) = True Then
                z9900 = D9900
                K9900_MOVE = True
            Else
                z9900 = Nothing
            End If

            If getColumIndex(spr, "NotifySeting") > -1 Then z9900.NotifySeting = getDataM(spr, getColumIndex(spr, "NotifySeting"), xRow)
            If getColumIndex(spr, "NotifySetingSeq") > -1 Then z9900.NotifySetingSeq = getDataM(spr, getColumIndex(spr, "NotifySetingSeq"), xRow)
            If getColumIndex(spr, "TimeStart") > -1 Then z9900.TimeStart = getDataM(spr, getColumIndex(spr, "TimeStart"), xRow)
            If getColumIndex(spr, "TimeEnd") > -1 Then z9900.TimeEnd = getDataM(spr, getColumIndex(spr, "TimeEnd"), xRow)
            If getColumIndex(spr, "TimeRefresh") > -1 Then z9900.TimeRefresh = getDataM(spr, getColumIndex(spr, "TimeRefresh"), xRow)
            If getColumIndex(spr, "DashboardUse") > -1 Then z9900.DashboardUse = getDataM(spr, getColumIndex(spr, "DashboardUse"), xRow)
            If getColumIndex(spr, "CheckUse") > -1 Then z9900.CheckUse = getDataM(spr, getColumIndex(spr, "CheckUse"), xRow)
            If getColumIndex(spr, "DateCreate") > -1 Then z9900.DateCreate = getDataM(spr, getColumIndex(spr, "DateCreate"), xRow)
            If getColumIndex(spr, "InchargeCreate") > -1 Then z9900.InchargeCreate = getDataM(spr, getColumIndex(spr, "InchargeCreate"), xRow)
            If getColumIndex(spr, "DateUpdate") > -1 Then z9900.DateUpdate = getDataM(spr, getColumIndex(spr, "DateUpdate"), xRow)
            If getColumIndex(spr, "InchargeUpdate") > -1 Then z9900.InchargeUpdate = getDataM(spr, getColumIndex(spr, "InchargeUpdate"), xRow)

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K9900_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K9900_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z9900 As T9900_AREA, CheckClear As Boolean, NotifySeting As String, NotifySetingSeq As String) As Boolean

        K9900_MOVE = False

        Try
            If READ_PFK9900(NotifySeting, NotifySetingSeq) = True Then
                z9900 = D9900
                K9900_MOVE = True
            Else
                If CheckClear = True Then z9900 = Nothing
            End If

            If getColumIndex(spr, "NotifySeting") > -1 Then z9900.NotifySeting = getDataM(spr, getColumIndex(spr, "NotifySeting"), xRow)
            If getColumIndex(spr, "NotifySetingSeq") > -1 Then z9900.NotifySetingSeq = getDataM(spr, getColumIndex(spr, "NotifySetingSeq"), xRow)
            If getColumIndex(spr, "TimeStart") > -1 Then z9900.TimeStart = getDataM(spr, getColumIndex(spr, "TimeStart"), xRow)
            If getColumIndex(spr, "TimeEnd") > -1 Then z9900.TimeEnd = getDataM(spr, getColumIndex(spr, "TimeEnd"), xRow)
            If getColumIndex(spr, "TimeRefresh") > -1 Then z9900.TimeRefresh = getDataM(spr, getColumIndex(spr, "TimeRefresh"), xRow)
            If getColumIndex(spr, "DashboardUse") > -1 Then z9900.DashboardUse = getDataM(spr, getColumIndex(spr, "DashboardUse"), xRow)
            If getColumIndex(spr, "CheckUse") > -1 Then z9900.CheckUse = getDataM(spr, getColumIndex(spr, "CheckUse"), xRow)
            If getColumIndex(spr, "DateCreate") > -1 Then z9900.DateCreate = getDataM(spr, getColumIndex(spr, "DateCreate"), xRow)
            If getColumIndex(spr, "InchargeCreate") > -1 Then z9900.InchargeCreate = getDataM(spr, getColumIndex(spr, "InchargeCreate"), xRow)
            If getColumIndex(spr, "DateUpdate") > -1 Then z9900.DateUpdate = getDataM(spr, getColumIndex(spr, "DateUpdate"), xRow)
            If getColumIndex(spr, "InchargeUpdate") > -1 Then z9900.InchargeUpdate = getDataM(spr, getColumIndex(spr, "InchargeUpdate"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K9900_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K9900_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z9900 As T9900_AREA, Job As String, NotifySeting As String, NotifySetingSeq As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K9900_MOVE = False

        Try
            If READ_PFK9900(NotifySeting, NotifySetingSeq) = True Then
                z9900 = D9900
                K9900_MOVE = True
            Else
                z9900 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK9900")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "NotifySeting" : z9900.NotifySeting = Children(i).Code
                                Case "NotifySetingSeq" : z9900.NotifySetingSeq = Children(i).Code
                                Case "TimeStart" : z9900.TimeStart = Children(i).Code
                                Case "TimeEnd" : z9900.TimeEnd = Children(i).Code
                                Case "TimeRefresh" : z9900.TimeRefresh = Children(i).Code
                                Case "DashboardUse" : z9900.DashboardUse = Children(i).Code
                                Case "CheckUse" : z9900.CheckUse = Children(i).Code
                                Case "DateCreate" : z9900.DateCreate = Children(i).Code
                                Case "InchargeCreate" : z9900.InchargeCreate = Children(i).Code
                                Case "DateUpdate" : z9900.DateUpdate = Children(i).Code
                                Case "InchargeUpdate" : z9900.InchargeUpdate = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "NotifySeting" : z9900.NotifySeting = Children(i).Data
                                Case "NotifySetingSeq" : z9900.NotifySetingSeq = Children(i).Data
                                Case "TimeStart" : z9900.TimeStart = Children(i).Data
                                Case "TimeEnd" : z9900.TimeEnd = Children(i).Data
                                Case "TimeRefresh" : z9900.TimeRefresh = Children(i).Data
                                Case "DashboardUse" : z9900.DashboardUse = Children(i).Data
                                Case "CheckUse" : z9900.CheckUse = Children(i).Data
                                Case "DateCreate" : z9900.DateCreate = Children(i).Data
                                Case "InchargeCreate" : z9900.InchargeCreate = Children(i).Data
                                Case "DateUpdate" : z9900.DateUpdate = Children(i).Data
                                Case "InchargeUpdate" : z9900.InchargeUpdate = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K9900_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K9900_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z9900 As T9900_AREA, Job As String, CheckClear As Boolean, NotifySeting As String, NotifySetingSeq As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K9900_MOVE = False

        Try
            If READ_PFK9900(NotifySeting, NotifySetingSeq) = True Then
                z9900 = D9900
                K9900_MOVE = True
            Else
                If CheckClear = True Then z9900 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK9900")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "NotifySeting" : z9900.NotifySeting = Children(i).Code
                                Case "NotifySetingSeq" : z9900.NotifySetingSeq = Children(i).Code
                                Case "TimeStart" : z9900.TimeStart = Children(i).Code
                                Case "TimeEnd" : z9900.TimeEnd = Children(i).Code
                                Case "TimeRefresh" : z9900.TimeRefresh = Children(i).Code
                                Case "DashboardUse" : z9900.DashboardUse = Children(i).Code
                                Case "CheckUse" : z9900.CheckUse = Children(i).Code
                                Case "DateCreate" : z9900.DateCreate = Children(i).Code
                                Case "InchargeCreate" : z9900.InchargeCreate = Children(i).Code
                                Case "DateUpdate" : z9900.DateUpdate = Children(i).Code
                                Case "InchargeUpdate" : z9900.InchargeUpdate = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "NotifySeting" : z9900.NotifySeting = Children(i).Data
                                Case "NotifySetingSeq" : z9900.NotifySetingSeq = Children(i).Data
                                Case "TimeStart" : z9900.TimeStart = Children(i).Data
                                Case "TimeEnd" : z9900.TimeEnd = Children(i).Data
                                Case "TimeRefresh" : z9900.TimeRefresh = Children(i).Data
                                Case "DashboardUse" : z9900.DashboardUse = Children(i).Data
                                Case "CheckUse" : z9900.CheckUse = Children(i).Data
                                Case "DateCreate" : z9900.DateCreate = Children(i).Data
                                Case "InchargeCreate" : z9900.InchargeCreate = Children(i).Data
                                Case "DateUpdate" : z9900.DateUpdate = Children(i).Data
                                Case "InchargeUpdate" : z9900.InchargeUpdate = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K9900_MOVE", vbCritical)
        End Try
    End Function

End Module
