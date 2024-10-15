'=========================================================================================================================================================
'   TABLE : (PFK1316)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K1316

    Structure T1316_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public ScheduleID As String  '			char(6)		*
        Public OrderNo As String  '			char(9)
        Public OrderNoSeq As String  '			char(3)
        Public Seq As Double  '			decimal
        Public seProcessType As String  '			char(3)
        Public cdProcessType As String  '			char(3)
        Public DateProcess As String  '			char(8)
        Public DateSent As String  '			char(8)
        Public DateReceived As String  '			char(8)
        Public DateResult As String  '			char(8)
        Public Result As String  '			char(1)
        Public Comment1 As String  '			nvarchar(500)
        Public Comment2 As String  '			nvarchar(500)
        Public Comment3 As String  '			nvarchar(500)
        Public Comment4 As String  '			nvarchar(500)
        Public Comment5 As String  '			nvarchar(500)
        Public PructionNote As String  '			nvarchar(500)
        Public Active As String  '			char(1)
        Public Remark As String  '			nvarchar(500)
        '=========================================================================================================================================================
    End Structure

    Public D1316 As T1316_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK1316(SCHEDULEID As String) As Boolean
        READ_PFK1316 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK1316 "
            SQL = SQL & " WHERE K1316_ScheduleID		 = '" & ScheduleID & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D1316_CLEAR() : GoTo SKIP_READ_PFK1316

            Call K1316_MOVE(rd)
            READ_PFK1316 = True

SKIP_READ_PFK1316:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK1316", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK1316(SCHEDULEID As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK1316 "
            SQL = SQL & " WHERE K1316_ScheduleID		 = '" & ScheduleID & "' "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK1316", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK1316(z1316 As T1316_AREA) As Boolean
        WRITE_PFK1316 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z1316)

            SQL = " INSERT INTO PFK1316 "
            SQL = SQL & " ( "
            SQL = SQL & " K1316_ScheduleID,"
            SQL = SQL & " K1316_OrderNo,"
            SQL = SQL & " K1316_OrderNoSeq,"
            SQL = SQL & " K1316_Seq,"
            SQL = SQL & " K1316_seProcessType,"
            SQL = SQL & " K1316_cdProcessType,"
            SQL = SQL & " K1316_DateProcess,"
            SQL = SQL & " K1316_DateSent,"
            SQL = SQL & " K1316_DateReceived,"
            SQL = SQL & " K1316_DateResult,"
            SQL = SQL & " K1316_Result,"
            SQL = SQL & " K1316_Comment1,"
            SQL = SQL & " K1316_Comment2,"
            SQL = SQL & " K1316_Comment3,"
            SQL = SQL & " K1316_Comment4,"
            SQL = SQL & " K1316_Comment5,"
            SQL = SQL & " K1316_PructionNote,"
            SQL = SQL & " K1316_Active,"
            SQL = SQL & " K1316_Remark "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z1316.ScheduleID) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1316.OrderNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1316.OrderNoSeq) & "', "
            SQL = SQL & "   " & FormatSQL(z1316.Seq) & ", "
            SQL = SQL & "  N'" & FormatSQL(z1316.seProcessType) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1316.cdProcessType) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1316.DateProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1316.DateSent) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1316.DateReceived) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1316.DateResult) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1316.Result) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1316.Comment1) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1316.Comment2) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1316.Comment3) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1316.Comment4) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1316.Comment5) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1316.PructionNote) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1316.Active) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1316.Remark) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK1316 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK1316", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK1316(z1316 As T1316_AREA) As Boolean
        REWRITE_PFK1316 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z1316)

            SQL = " UPDATE PFK1316 SET "
            SQL = SQL & "    K1316_OrderNo      = N'" & FormatSQL(z1316.OrderNo) & "', "
            SQL = SQL & "    K1316_OrderNoSeq      = N'" & FormatSQL(z1316.OrderNoSeq) & "', "
            SQL = SQL & "    K1316_Seq      =  " & FormatSQL(z1316.Seq) & ", "
            SQL = SQL & "    K1316_seProcessType      = N'" & FormatSQL(z1316.seProcessType) & "', "
            SQL = SQL & "    K1316_cdProcessType      = N'" & FormatSQL(z1316.cdProcessType) & "', "
            SQL = SQL & "    K1316_DateProcess      = N'" & FormatSQL(z1316.DateProcess) & "', "
            SQL = SQL & "    K1316_DateSent      = N'" & FormatSQL(z1316.DateSent) & "', "
            SQL = SQL & "    K1316_DateReceived      = N'" & FormatSQL(z1316.DateReceived) & "', "
            SQL = SQL & "    K1316_DateResult      = N'" & FormatSQL(z1316.DateResult) & "', "
            SQL = SQL & "    K1316_Result      = N'" & FormatSQL(z1316.Result) & "', "
            SQL = SQL & "    K1316_Comment1      = N'" & FormatSQL(z1316.Comment1) & "', "
            SQL = SQL & "    K1316_Comment2      = N'" & FormatSQL(z1316.Comment2) & "', "
            SQL = SQL & "    K1316_Comment3      = N'" & FormatSQL(z1316.Comment3) & "', "
            SQL = SQL & "    K1316_Comment4      = N'" & FormatSQL(z1316.Comment4) & "', "
            SQL = SQL & "    K1316_Comment5      = N'" & FormatSQL(z1316.Comment5) & "', "
            SQL = SQL & "    K1316_PructionNote      = N'" & FormatSQL(z1316.PructionNote) & "', "
            SQL = SQL & "    K1316_Active      = N'" & FormatSQL(z1316.Active) & "', "
            SQL = SQL & "    K1316_Remark      = N'" & FormatSQL(z1316.Remark) & "'  "
            SQL = SQL & " WHERE K1316_ScheduleID		 = '" & z1316.ScheduleID & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK1316 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK1316", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK1316(z1316 As T1316_AREA) As Boolean
        DELETE_PFK1316 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK1316 "
            SQL = SQL & " WHERE K1316_ScheduleID		 = '" & z1316.ScheduleID & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK1316 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK1316", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D1316_CLEAR()
        Try

            D1316.ScheduleID = ""
            D1316.OrderNo = ""
            D1316.OrderNoSeq = ""
            D1316.Seq = 0
            D1316.seProcessType = ""
            D1316.cdProcessType = ""
            D1316.DateProcess = ""
            D1316.DateSent = ""
            D1316.DateReceived = ""
            D1316.DateResult = ""
            D1316.Result = ""
            D1316.Comment1 = ""
            D1316.Comment2 = ""
            D1316.Comment3 = ""
            D1316.Comment4 = ""
            D1316.Comment5 = ""
            D1316.PructionNote = ""
            D1316.Active = ""
            D1316.Remark = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D1316_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x1316 As T1316_AREA)
        Try

            x1316.ScheduleID = trim$(x1316.ScheduleID)
            x1316.OrderNo = trim$(x1316.OrderNo)
            x1316.OrderNoSeq = trim$(x1316.OrderNoSeq)
            x1316.Seq = trim$(x1316.Seq)
            x1316.seProcessType = trim$(x1316.seProcessType)
            x1316.cdProcessType = trim$(x1316.cdProcessType)
            x1316.DateProcess = trim$(x1316.DateProcess)
            x1316.DateSent = trim$(x1316.DateSent)
            x1316.DateReceived = trim$(x1316.DateReceived)
            x1316.DateResult = trim$(x1316.DateResult)
            x1316.Result = trim$(x1316.Result)
            x1316.Comment1 = trim$(x1316.Comment1)
            x1316.Comment2 = trim$(x1316.Comment2)
            x1316.Comment3 = trim$(x1316.Comment3)
            x1316.Comment4 = trim$(x1316.Comment4)
            x1316.Comment5 = trim$(x1316.Comment5)
            x1316.PructionNote = trim$(x1316.PructionNote)
            x1316.Active = trim$(x1316.Active)
            x1316.Remark = trim$(x1316.Remark)

            If trim$(x1316.ScheduleID) = "" Then x1316.ScheduleID = Space(1)
            If trim$(x1316.OrderNo) = "" Then x1316.OrderNo = Space(1)
            If trim$(x1316.OrderNoSeq) = "" Then x1316.OrderNoSeq = Space(1)
            If trim$(x1316.Seq) = "" Then x1316.Seq = 0
            If trim$(x1316.seProcessType) = "" Then x1316.seProcessType = Space(1)
            If trim$(x1316.cdProcessType) = "" Then x1316.cdProcessType = Space(1)
            If trim$(x1316.DateProcess) = "" Then x1316.DateProcess = Space(1)
            If trim$(x1316.DateSent) = "" Then x1316.DateSent = Space(1)
            If trim$(x1316.DateReceived) = "" Then x1316.DateReceived = Space(1)
            If trim$(x1316.DateResult) = "" Then x1316.DateResult = Space(1)
            If trim$(x1316.Result) = "" Then x1316.Result = Space(1)
            If trim$(x1316.Comment1) = "" Then x1316.Comment1 = Space(1)
            If trim$(x1316.Comment2) = "" Then x1316.Comment2 = Space(1)
            If trim$(x1316.Comment3) = "" Then x1316.Comment3 = Space(1)
            If trim$(x1316.Comment4) = "" Then x1316.Comment4 = Space(1)
            If trim$(x1316.Comment5) = "" Then x1316.Comment5 = Space(1)
            If trim$(x1316.PructionNote) = "" Then x1316.PructionNote = Space(1)
            If trim$(x1316.Active) = "" Then x1316.Active = Space(1)
            If trim$(x1316.Remark) = "" Then x1316.Remark = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K1316_MOVE(rs1316 As SqlClient.SqlDataReader)
        Try

            Call D1316_CLEAR()

            If IsdbNull(rs1316!K1316_ScheduleID) = False Then D1316.ScheduleID = Trim$(rs1316!K1316_ScheduleID)
            If IsdbNull(rs1316!K1316_OrderNo) = False Then D1316.OrderNo = Trim$(rs1316!K1316_OrderNo)
            If IsdbNull(rs1316!K1316_OrderNoSeq) = False Then D1316.OrderNoSeq = Trim$(rs1316!K1316_OrderNoSeq)
            If IsdbNull(rs1316!K1316_Seq) = False Then D1316.Seq = Trim$(rs1316!K1316_Seq)
            If IsdbNull(rs1316!K1316_seProcessType) = False Then D1316.seProcessType = Trim$(rs1316!K1316_seProcessType)
            If IsdbNull(rs1316!K1316_cdProcessType) = False Then D1316.cdProcessType = Trim$(rs1316!K1316_cdProcessType)
            If IsdbNull(rs1316!K1316_DateProcess) = False Then D1316.DateProcess = Trim$(rs1316!K1316_DateProcess)
            If IsdbNull(rs1316!K1316_DateSent) = False Then D1316.DateSent = Trim$(rs1316!K1316_DateSent)
            If IsdbNull(rs1316!K1316_DateReceived) = False Then D1316.DateReceived = Trim$(rs1316!K1316_DateReceived)
            If IsdbNull(rs1316!K1316_DateResult) = False Then D1316.DateResult = Trim$(rs1316!K1316_DateResult)
            If IsdbNull(rs1316!K1316_Result) = False Then D1316.Result = Trim$(rs1316!K1316_Result)
            If IsdbNull(rs1316!K1316_Comment1) = False Then D1316.Comment1 = Trim$(rs1316!K1316_Comment1)
            If IsdbNull(rs1316!K1316_Comment2) = False Then D1316.Comment2 = Trim$(rs1316!K1316_Comment2)
            If IsdbNull(rs1316!K1316_Comment3) = False Then D1316.Comment3 = Trim$(rs1316!K1316_Comment3)
            If IsdbNull(rs1316!K1316_Comment4) = False Then D1316.Comment4 = Trim$(rs1316!K1316_Comment4)
            If IsdbNull(rs1316!K1316_Comment5) = False Then D1316.Comment5 = Trim$(rs1316!K1316_Comment5)
            If IsdbNull(rs1316!K1316_PructionNote) = False Then D1316.PructionNote = Trim$(rs1316!K1316_PructionNote)
            If IsdbNull(rs1316!K1316_Active) = False Then D1316.Active = Trim$(rs1316!K1316_Active)
            If IsdbNull(rs1316!K1316_Remark) = False Then D1316.Remark = Trim$(rs1316!K1316_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K1316_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K1316_MOVE(rs1316 As DataRow)
        Try

            Call D1316_CLEAR()

            If IsdbNull(rs1316!K1316_ScheduleID) = False Then D1316.ScheduleID = Trim$(rs1316!K1316_ScheduleID)
            If IsdbNull(rs1316!K1316_OrderNo) = False Then D1316.OrderNo = Trim$(rs1316!K1316_OrderNo)
            If IsdbNull(rs1316!K1316_OrderNoSeq) = False Then D1316.OrderNoSeq = Trim$(rs1316!K1316_OrderNoSeq)
            If IsdbNull(rs1316!K1316_Seq) = False Then D1316.Seq = Trim$(rs1316!K1316_Seq)
            If IsdbNull(rs1316!K1316_seProcessType) = False Then D1316.seProcessType = Trim$(rs1316!K1316_seProcessType)
            If IsdbNull(rs1316!K1316_cdProcessType) = False Then D1316.cdProcessType = Trim$(rs1316!K1316_cdProcessType)
            If IsdbNull(rs1316!K1316_DateProcess) = False Then D1316.DateProcess = Trim$(rs1316!K1316_DateProcess)
            If IsdbNull(rs1316!K1316_DateSent) = False Then D1316.DateSent = Trim$(rs1316!K1316_DateSent)
            If IsdbNull(rs1316!K1316_DateReceived) = False Then D1316.DateReceived = Trim$(rs1316!K1316_DateReceived)
            If IsdbNull(rs1316!K1316_DateResult) = False Then D1316.DateResult = Trim$(rs1316!K1316_DateResult)
            If IsdbNull(rs1316!K1316_Result) = False Then D1316.Result = Trim$(rs1316!K1316_Result)
            If IsdbNull(rs1316!K1316_Comment1) = False Then D1316.Comment1 = Trim$(rs1316!K1316_Comment1)
            If IsdbNull(rs1316!K1316_Comment2) = False Then D1316.Comment2 = Trim$(rs1316!K1316_Comment2)
            If IsdbNull(rs1316!K1316_Comment3) = False Then D1316.Comment3 = Trim$(rs1316!K1316_Comment3)
            If IsdbNull(rs1316!K1316_Comment4) = False Then D1316.Comment4 = Trim$(rs1316!K1316_Comment4)
            If IsdbNull(rs1316!K1316_Comment5) = False Then D1316.Comment5 = Trim$(rs1316!K1316_Comment5)
            If IsdbNull(rs1316!K1316_PructionNote) = False Then D1316.PructionNote = Trim$(rs1316!K1316_PructionNote)
            If IsdbNull(rs1316!K1316_Active) = False Then D1316.Active = Trim$(rs1316!K1316_Active)
            If IsdbNull(rs1316!K1316_Remark) = False Then D1316.Remark = Trim$(rs1316!K1316_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K1316_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K1316_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z1316 As T1316_AREA, SCHEDULEID As String) As Boolean

        K1316_MOVE = False

        Try
            If READ_PFK1316(SCHEDULEID) = True Then
                z1316 = D1316
                K1316_MOVE = True
            Else
                z1316 = Nothing
            End If

            If getColumIndex(spr, "ScheduleID") > -1 Then z1316.ScheduleID = getDataM(spr, getColumIndex(spr, "ScheduleID"), xRow)
            If getColumIndex(spr, "OrderNo") > -1 Then z1316.OrderNo = getDataM(spr, getColumIndex(spr, "OrderNo"), xRow)
            If getColumIndex(spr, "OrderNoSeq") > -1 Then z1316.OrderNoSeq = getDataM(spr, getColumIndex(spr, "OrderNoSeq"), xRow)
            If getColumIndex(spr, "Seq") > -1 Then z1316.Seq = getDataM(spr, getColumIndex(spr, "Seq"), xRow)
            If getColumIndex(spr, "seProcessType") > -1 Then z1316.seProcessType = getDataM(spr, getColumIndex(spr, "seProcessType"), xRow)
            If getColumIndex(spr, "cdProcessType") > -1 Then z1316.cdProcessType = getDataM(spr, getColumIndex(spr, "cdProcessType"), xRow)
            If getColumIndex(spr, "DateProcess") > -1 Then z1316.DateProcess = getDataM(spr, getColumIndex(spr, "DateProcess"), xRow)
            If getColumIndex(spr, "DateSent") > -1 Then z1316.DateSent = getDataM(spr, getColumIndex(spr, "DateSent"), xRow)
            If getColumIndex(spr, "DateReceived") > -1 Then z1316.DateReceived = getDataM(spr, getColumIndex(spr, "DateReceived"), xRow)
            If getColumIndex(spr, "DateResult") > -1 Then z1316.DateResult = getDataM(spr, getColumIndex(spr, "DateResult"), xRow)
            If getColumIndex(spr, "Result") > -1 Then z1316.Result = getDataM(spr, getColumIndex(spr, "Result"), xRow)
            If getColumIndex(spr, "Comment1") > -1 Then z1316.Comment1 = getDataM(spr, getColumIndex(spr, "Comment1"), xRow)
            If getColumIndex(spr, "Comment2") > -1 Then z1316.Comment2 = getDataM(spr, getColumIndex(spr, "Comment2"), xRow)
            If getColumIndex(spr, "Comment3") > -1 Then z1316.Comment3 = getDataM(spr, getColumIndex(spr, "Comment3"), xRow)
            If getColumIndex(spr, "Comment4") > -1 Then z1316.Comment4 = getDataM(spr, getColumIndex(spr, "Comment4"), xRow)
            If getColumIndex(spr, "Comment5") > -1 Then z1316.Comment5 = getDataM(spr, getColumIndex(spr, "Comment5"), xRow)
            If getColumIndex(spr, "PructionNote") > -1 Then z1316.PructionNote = getDataM(spr, getColumIndex(spr, "PructionNote"), xRow)
            If getColumIndex(spr, "Active") > -1 Then z1316.Active = getDataM(spr, getColumIndex(spr, "Active"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z1316.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K1316_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K1316_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z1316 As T1316_AREA, CheckClear As Boolean, SCHEDULEID As String) As Boolean

        K1316_MOVE = False

        Try
            If READ_PFK1316(SCHEDULEID) = True Then
                z1316 = D1316
                K1316_MOVE = True
            Else
                If CheckClear = True Then z1316 = Nothing
            End If

            If getColumIndex(spr, "ScheduleID") > -1 Then z1316.ScheduleID = getDataM(spr, getColumIndex(spr, "ScheduleID"), xRow)
            If getColumIndex(spr, "OrderNo") > -1 Then z1316.OrderNo = getDataM(spr, getColumIndex(spr, "OrderNo"), xRow)
            If getColumIndex(spr, "OrderNoSeq") > -1 Then z1316.OrderNoSeq = getDataM(spr, getColumIndex(spr, "OrderNoSeq"), xRow)
            If getColumIndex(spr, "Seq") > -1 Then z1316.Seq = getDataM(spr, getColumIndex(spr, "Seq"), xRow)
            If getColumIndex(spr, "seProcessType") > -1 Then z1316.seProcessType = getDataM(spr, getColumIndex(spr, "seProcessType"), xRow)
            If getColumIndex(spr, "cdProcessType") > -1 Then z1316.cdProcessType = getDataM(spr, getColumIndex(spr, "cdProcessType"), xRow)
            If getColumIndex(spr, "DateProcess") > -1 Then z1316.DateProcess = getDataM(spr, getColumIndex(spr, "DateProcess"), xRow)
            If getColumIndex(spr, "DateSent") > -1 Then z1316.DateSent = getDataM(spr, getColumIndex(spr, "DateSent"), xRow)
            If getColumIndex(spr, "DateReceived") > -1 Then z1316.DateReceived = getDataM(spr, getColumIndex(spr, "DateReceived"), xRow)
            If getColumIndex(spr, "DateResult") > -1 Then z1316.DateResult = getDataM(spr, getColumIndex(spr, "DateResult"), xRow)
            If getColumIndex(spr, "Result") > -1 Then z1316.Result = getDataM(spr, getColumIndex(spr, "Result"), xRow)
            If getColumIndex(spr, "Comment1") > -1 Then z1316.Comment1 = getDataM(spr, getColumIndex(spr, "Comment1"), xRow)
            If getColumIndex(spr, "Comment2") > -1 Then z1316.Comment2 = getDataM(spr, getColumIndex(spr, "Comment2"), xRow)
            If getColumIndex(spr, "Comment3") > -1 Then z1316.Comment3 = getDataM(spr, getColumIndex(spr, "Comment3"), xRow)
            If getColumIndex(spr, "Comment4") > -1 Then z1316.Comment4 = getDataM(spr, getColumIndex(spr, "Comment4"), xRow)
            If getColumIndex(spr, "Comment5") > -1 Then z1316.Comment5 = getDataM(spr, getColumIndex(spr, "Comment5"), xRow)
            If getColumIndex(spr, "PructionNote") > -1 Then z1316.PructionNote = getDataM(spr, getColumIndex(spr, "PructionNote"), xRow)
            If getColumIndex(spr, "Active") > -1 Then z1316.Active = getDataM(spr, getColumIndex(spr, "Active"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z1316.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K1316_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K1316_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z1316 As T1316_AREA, Job As String, SCHEDULEID As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K1316_MOVE = False

        Try
            If READ_PFK1316(SCHEDULEID) = True Then
                z1316 = D1316
                K1316_MOVE = True
            Else
                z1316 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK1316")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "SCHEDULEID" : z1316.ScheduleID = Children(i).Code
                                Case "ORDERNO" : z1316.OrderNo = Children(i).Code
                                Case "ORDERNOSEQ" : z1316.OrderNoSeq = Children(i).Code
                                Case "SEQ" : z1316.Seq = Children(i).Code
                                Case "SEPROCESSTYPE" : z1316.seProcessType = Children(i).Code
                                Case "CDPROCESSTYPE" : z1316.cdProcessType = Children(i).Code
                                Case "DATEPROCESS" : z1316.DateProcess = Children(i).Code
                                Case "DATESENT" : z1316.DateSent = Children(i).Code
                                Case "DATERECEIVED" : z1316.DateReceived = Children(i).Code
                                Case "DATERESULT" : z1316.DateResult = Children(i).Code
                                Case "RESULT" : z1316.Result = Children(i).Code
                                Case "COMMENT1" : z1316.Comment1 = Children(i).Code
                                Case "COMMENT2" : z1316.Comment2 = Children(i).Code
                                Case "COMMENT3" : z1316.Comment3 = Children(i).Code
                                Case "COMMENT4" : z1316.Comment4 = Children(i).Code
                                Case "COMMENT5" : z1316.Comment5 = Children(i).Code
                                Case "PRUCTIONNOTE" : z1316.PructionNote = Children(i).Code
                                Case "ACTIVE" : z1316.Active = Children(i).Code
                                Case "REMARK" : z1316.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "SCHEDULEID" : z1316.ScheduleID = Children(i).Data
                                Case "ORDERNO" : z1316.OrderNo = Children(i).Data
                                Case "ORDERNOSEQ" : z1316.OrderNoSeq = Children(i).Data
                                Case "SEQ" : z1316.Seq = Children(i).Data
                                Case "SEPROCESSTYPE" : z1316.seProcessType = Children(i).Data
                                Case "CDPROCESSTYPE" : z1316.cdProcessType = Children(i).Data
                                Case "DATEPROCESS" : z1316.DateProcess = Children(i).Data
                                Case "DATESENT" : z1316.DateSent = Children(i).Data
                                Case "DATERECEIVED" : z1316.DateReceived = Children(i).Data
                                Case "DATERESULT" : z1316.DateResult = Children(i).Data
                                Case "RESULT" : z1316.Result = Children(i).Data
                                Case "COMMENT1" : z1316.Comment1 = Children(i).Data
                                Case "COMMENT2" : z1316.Comment2 = Children(i).Data
                                Case "COMMENT3" : z1316.Comment3 = Children(i).Data
                                Case "COMMENT4" : z1316.Comment4 = Children(i).Data
                                Case "COMMENT5" : z1316.Comment5 = Children(i).Data
                                Case "PRUCTIONNOTE" : z1316.PructionNote = Children(i).Data
                                Case "ACTIVE" : z1316.Active = Children(i).Data
                                Case "REMARK" : z1316.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K1316_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K1316_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z1316 As T1316_AREA, Job As String, CheckClear As Boolean, SCHEDULEID As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K1316_MOVE = False

        Try
            If READ_PFK1316(SCHEDULEID) = True Then
                z1316 = D1316
                K1316_MOVE = True
            Else
                If CheckClear = True Then z1316 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK1316")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "SCHEDULEID" : z1316.ScheduleID = Children(i).Code
                                Case "ORDERNO" : z1316.OrderNo = Children(i).Code
                                Case "ORDERNOSEQ" : z1316.OrderNoSeq = Children(i).Code
                                Case "SEQ" : z1316.Seq = Children(i).Code
                                Case "SEPROCESSTYPE" : z1316.seProcessType = Children(i).Code
                                Case "CDPROCESSTYPE" : z1316.cdProcessType = Children(i).Code
                                Case "DATEPROCESS" : z1316.DateProcess = Children(i).Code
                                Case "DATESENT" : z1316.DateSent = Children(i).Code
                                Case "DATERECEIVED" : z1316.DateReceived = Children(i).Code
                                Case "DATERESULT" : z1316.DateResult = Children(i).Code
                                Case "RESULT" : z1316.Result = Children(i).Code
                                Case "COMMENT1" : z1316.Comment1 = Children(i).Code
                                Case "COMMENT2" : z1316.Comment2 = Children(i).Code
                                Case "COMMENT3" : z1316.Comment3 = Children(i).Code
                                Case "COMMENT4" : z1316.Comment4 = Children(i).Code
                                Case "COMMENT5" : z1316.Comment5 = Children(i).Code
                                Case "PRUCTIONNOTE" : z1316.PructionNote = Children(i).Code
                                Case "ACTIVE" : z1316.Active = Children(i).Code
                                Case "REMARK" : z1316.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "SCHEDULEID" : z1316.ScheduleID = Children(i).Data
                                Case "ORDERNO" : z1316.OrderNo = Children(i).Data
                                Case "ORDERNOSEQ" : z1316.OrderNoSeq = Children(i).Data
                                Case "SEQ" : z1316.Seq = Children(i).Data
                                Case "SEPROCESSTYPE" : z1316.seProcessType = Children(i).Data
                                Case "CDPROCESSTYPE" : z1316.cdProcessType = Children(i).Data
                                Case "DATEPROCESS" : z1316.DateProcess = Children(i).Data
                                Case "DATESENT" : z1316.DateSent = Children(i).Data
                                Case "DATERECEIVED" : z1316.DateReceived = Children(i).Data
                                Case "DATERESULT" : z1316.DateResult = Children(i).Data
                                Case "RESULT" : z1316.Result = Children(i).Data
                                Case "COMMENT1" : z1316.Comment1 = Children(i).Data
                                Case "COMMENT2" : z1316.Comment2 = Children(i).Data
                                Case "COMMENT3" : z1316.Comment3 = Children(i).Data
                                Case "COMMENT4" : z1316.Comment4 = Children(i).Data
                                Case "COMMENT5" : z1316.Comment5 = Children(i).Data
                                Case "PRUCTIONNOTE" : z1316.PructionNote = Children(i).Data
                                Case "ACTIVE" : z1316.Active = Children(i).Data
                                Case "REMARK" : z1316.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K1316_MOVE", vbCritical)
        End Try
    End Function

End Module
