'=========================================================================================================================================================
'   TABLE : (PFK7743)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7743

    Structure T7743_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public cdFactory As String  '			char(3)		*
        Public cdSubProcess As String  '			char(3)		*
        Public DatePlan As String  '			char(8)		*
        Public cdLineProd As String  '			char(3)		*
        Public SeqJob As String  '			char(3)		*
        Public seSubProcess As String  '			char(3)
        Public seMainProcess As String  '			char(3)
        Public cdMainProcess As String  '			char(3)
        Public InchargeJob As String  '			char(8)
        Public InchargeTeam As String  '			char(3)
        Public seJobProcess As String  '			char(3)
        Public cdJobProcess As String  '			char(3)
        Public MachineCode As String  '			char(6)
        Public InchargeSelect As String  '			char(1)
        Public Grade As String  '			char(1)
        Public Food As String  '			char(1)
        Public chkWorker As String  '			char(1)
        Public WorkTime As String  '			char(4)
        Public chkTeam As String  '			char(4)

        Public QtyTargetDay As Double  '			decimal
        Public QtyTargetHour As Double  '			decimal
        Public QtyRateSecondJob As Double  '			decimal
        Public QtyDateProdNormal As Double  '			decimal
        Public QtyDateProdDefect As Double  '			decimal
        Public QtyDateDefectPass As Double  '			decimal
        Public QtyDateDefectReject As Double  '			decimal
        Public CheckUse As String  '			char(1)
        '=========================================================================================================================================================
    End Structure

    Public D7743 As T7743_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK7743(CDFACTORY As String, CDSUBPROCESS As String, DATEPLAN As String, CDLINEPROD As String, SEQJOB As String) As Boolean
        READ_PFK7743 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7743 "
            SQL = SQL & " WHERE K7743_cdFactory		 = '" & cdFactory & "' "
            SQL = SQL & "   AND K7743_cdSubProcess		 = '" & cdSubProcess & "' "
            SQL = SQL & "   AND K7743_DatePlan		 = '" & DatePlan & "' "
            SQL = SQL & "   AND K7743_cdLineProd		 = '" & cdLineProd & "' "
            SQL = SQL & "   AND K7743_SeqJob		 = '" & SeqJob & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7743_CLEAR() : GoTo SKIP_READ_PFK7743

            Call K7743_MOVE(rd)
            READ_PFK7743 = True

SKIP_READ_PFK7743:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7743", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK7743(CDFACTORY As String, CDSUBPROCESS As String, DATEPLAN As String, CDLINEPROD As String, SEQJOB As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7743 "
            SQL = SQL & " WHERE K7743_cdFactory		 = '" & cdFactory & "' "
            SQL = SQL & "   AND K7743_cdSubProcess		 = '" & cdSubProcess & "' "
            SQL = SQL & "   AND K7743_DatePlan		 = '" & DatePlan & "' "
            SQL = SQL & "   AND K7743_cdLineProd		 = '" & cdLineProd & "' "
            SQL = SQL & "   AND K7743_SeqJob		 = '" & SeqJob & "' "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK7743", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK7743(z7743 As T7743_AREA) As Boolean
        WRITE_PFK7743 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z7743)

            SQL = " INSERT INTO PFK7743 "
            SQL = SQL & " ( "
            SQL = SQL & " K7743_cdFactory,"
            SQL = SQL & " K7743_cdSubProcess,"
            SQL = SQL & " K7743_DatePlan,"
            SQL = SQL & " K7743_cdLineProd,"
            SQL = SQL & " K7743_SeqJob,"
            SQL = SQL & " K7743_seSubProcess,"
            SQL = SQL & " K7743_seMainProcess,"
            SQL = SQL & " K7743_cdMainProcess,"
            SQL = SQL & " K7743_InchargeJob,"
            SQL = SQL & " K7743_InchargeTeam,"
            SQL = SQL & " K7743_seJobProcess,"
            SQL = SQL & " K7743_cdJobProcess,"
            SQL = SQL & " K7743_MachineCode,"
            SQL = SQL & " K7743_InchargeSelect,"
            SQL = SQL & " K7743_Grade,"
            SQL = SQL & " K7743_Food,"
            SQL = SQL & " K7743_chkWorker,"
            SQL = SQL & " K7743_chkTeam,"
            SQL = SQL & " K7743_WorkTime,"
            SQL = SQL & " K7743_QtyTargetDay,"
            SQL = SQL & " K7743_QtyTargetHour,"
            SQL = SQL & " K7743_QtyRateSecondJob,"
            SQL = SQL & " K7743_QtyDateProdNormal,"
            SQL = SQL & " K7743_QtyDateProdDefect,"
            SQL = SQL & " K7743_QtyDateDefectPass,"
            SQL = SQL & " K7743_QtyDateDefectReject,"
            SQL = SQL & " K7743_CheckUse "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z7743.cdFactory) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7743.cdSubProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7743.DatePlan) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7743.cdLineProd) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7743.SeqJob) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7743.seSubProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7743.seMainProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7743.cdMainProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7743.InchargeJob) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7743.InchargeTeam) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7743.seJobProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7743.cdJobProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7743.MachineCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7743.InchargeSelect) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7743.Grade) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7743.Food) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7743.chkWorker) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7743.chkTeam) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7743.WorkTime) & "', "
            SQL = SQL & "   " & FormatSQL(z7743.QtyTargetDay) & ", "
            SQL = SQL & "   " & FormatSQL(z7743.QtyTargetHour) & ", "
            SQL = SQL & "   " & FormatSQL(z7743.QtyRateSecondJob) & ", "
            SQL = SQL & "   " & FormatSQL(z7743.QtyDateProdNormal) & ", "
            SQL = SQL & "   " & FormatSQL(z7743.QtyDateProdDefect) & ", "
            SQL = SQL & "   " & FormatSQL(z7743.QtyDateDefectPass) & ", "
            SQL = SQL & "   " & FormatSQL(z7743.QtyDateDefectReject) & ", "
            SQL = SQL & "  N'" & FormatSQL(z7743.CheckUse) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK7743 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK7743", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK7743(z7743 As T7743_AREA) As Boolean
        REWRITE_PFK7743 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z7743)

            SQL = " UPDATE PFK7743 SET "
            SQL = SQL & "    K7743_seSubProcess      = N'" & FormatSQL(z7743.seSubProcess) & "', "
            SQL = SQL & "    K7743_seMainProcess      = N'" & FormatSQL(z7743.seMainProcess) & "', "
            SQL = SQL & "    K7743_cdMainProcess      = N'" & FormatSQL(z7743.cdMainProcess) & "', "
            SQL = SQL & "    K7743_InchargeJob      = N'" & FormatSQL(z7743.InchargeJob) & "', "
            SQL = SQL & "    K7743_InchargeTeam      = N'" & FormatSQL(z7743.InchargeTeam) & "', "
            SQL = SQL & "    K7743_seJobProcess      = N'" & FormatSQL(z7743.seJobProcess) & "', "
            SQL = SQL & "    K7743_cdJobProcess      = N'" & FormatSQL(z7743.cdJobProcess) & "', "
            SQL = SQL & "    K7743_MachineCode      = N'" & FormatSQL(z7743.MachineCode) & "', "
            SQL = SQL & "    K7743_InchargeSelect      = N'" & FormatSQL(z7743.InchargeSelect) & "', "
            SQL = SQL & "    K7743_Grade      = N'" & FormatSQL(z7743.Grade) & "', "
            SQL = SQL & "    K7743_Food      = N'" & FormatSQL(z7743.Food) & "', "
            SQL = SQL & "    K7743_chkWorker      = N'" & FormatSQL(z7743.chkWorker) & "', "
            SQL = SQL & "    K7743_chkTeam      = N'" & FormatSQL(z7743.chkTeam) & "', "
            SQL = SQL & "    K7743_WorkTime      = N'" & FormatSQL(z7743.WorkTime) & "', "
            SQL = SQL & "    K7743_QtyTargetDay      =  " & FormatSQL(z7743.QtyTargetDay) & ", "
            SQL = SQL & "    K7743_QtyTargetHour      =  " & FormatSQL(z7743.QtyTargetHour) & ", "
            SQL = SQL & "    K7743_QtyRateSecondJob      =  " & FormatSQL(z7743.QtyRateSecondJob) & ", "
            SQL = SQL & "    K7743_QtyDateProdNormal      =  " & FormatSQL(z7743.QtyDateProdNormal) & ", "
            SQL = SQL & "    K7743_QtyDateProdDefect      =  " & FormatSQL(z7743.QtyDateProdDefect) & ", "
            SQL = SQL & "    K7743_QtyDateDefectPass      =  " & FormatSQL(z7743.QtyDateDefectPass) & ", "
            SQL = SQL & "    K7743_QtyDateDefectReject      =  " & FormatSQL(z7743.QtyDateDefectReject) & ", "
            SQL = SQL & "    K7743_CheckUse      = N'" & FormatSQL(z7743.CheckUse) & "'  "
            SQL = SQL & " WHERE K7743_cdFactory		 = '" & z7743.cdFactory & "' "
            SQL = SQL & "   AND K7743_cdSubProcess		 = '" & z7743.cdSubProcess & "' "
            SQL = SQL & "   AND K7743_DatePlan		 = '" & z7743.DatePlan & "' "
            SQL = SQL & "   AND K7743_cdLineProd		 = '" & z7743.cdLineProd & "' "
            SQL = SQL & "   AND K7743_SeqJob		 = '" & z7743.SeqJob & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK7743 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK7743", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK7743(z7743 As T7743_AREA) As Boolean
        DELETE_PFK7743 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK7743 "
            SQL = SQL & " WHERE K7743_cdFactory		 = '" & z7743.cdFactory & "' "
            SQL = SQL & "   AND K7743_cdSubProcess		 = '" & z7743.cdSubProcess & "' "
            SQL = SQL & "   AND K7743_DatePlan		 = '" & z7743.DatePlan & "' "
            SQL = SQL & "   AND K7743_cdLineProd		 = '" & z7743.cdLineProd & "' "
            SQL = SQL & "   AND K7743_SeqJob		 = '" & z7743.SeqJob & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK7743 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK7743", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D7743_CLEAR()
        Try

            D7743.cdFactory = ""
            D7743.cdSubProcess = ""
            D7743.DatePlan = ""
            D7743.cdLineProd = ""
            D7743.SeqJob = ""
            D7743.seSubProcess = ""
            D7743.seMainProcess = ""
            D7743.cdMainProcess = ""
            D7743.InchargeJob = ""
            D7743.InchargeTeam = ""
            D7743.seJobProcess = ""
            D7743.cdJobProcess = ""
            D7743.MachineCode = ""
            D7743.InchargeSelect = ""
            D7743.Grade = ""
            D7743.Food = ""
            D7743.chkWorker = ""
            D7743.chkTeam = ""
            D7743.WorkTime = ""
            D7743.QtyTargetDay = 0
            D7743.QtyTargetHour = 0
            D7743.QtyRateSecondJob = 0
            D7743.QtyDateProdNormal = 0
            D7743.QtyDateProdDefect = 0
            D7743.QtyDateDefectPass = 0
            D7743.QtyDateDefectReject = 0
            D7743.CheckUse = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D7743_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x7743 As T7743_AREA)
        Try

            x7743.cdFactory = trim$(x7743.cdFactory)
            x7743.cdSubProcess = trim$(x7743.cdSubProcess)
            x7743.DatePlan = trim$(x7743.DatePlan)
            x7743.cdLineProd = trim$(x7743.cdLineProd)
            x7743.SeqJob = trim$(x7743.SeqJob)
            x7743.seSubProcess = trim$(x7743.seSubProcess)
            x7743.seMainProcess = trim$(x7743.seMainProcess)
            x7743.cdMainProcess = trim$(x7743.cdMainProcess)
            x7743.InchargeJob = trim$(x7743.InchargeJob)
            x7743.InchargeTeam = trim$(x7743.InchargeTeam)
            x7743.seJobProcess = trim$(x7743.seJobProcess)
            x7743.cdJobProcess = trim$(x7743.cdJobProcess)
            x7743.MachineCode = trim$(x7743.MachineCode)
            x7743.InchargeSelect = trim$(x7743.InchargeSelect)
            x7743.Grade = trim$(x7743.Grade)
            x7743.Food = trim$(x7743.Food)
            x7743.chkWorker = Trim$(x7743.chkWorker)
            x7743.chkTeam = Trim$(x7743.chkTeam)
            x7743.WorkTime = trim$(x7743.WorkTime)
            x7743.QtyTargetDay = trim$(x7743.QtyTargetDay)
            x7743.QtyTargetHour = trim$(x7743.QtyTargetHour)
            x7743.QtyRateSecondJob = trim$(x7743.QtyRateSecondJob)
            x7743.QtyDateProdNormal = trim$(x7743.QtyDateProdNormal)
            x7743.QtyDateProdDefect = trim$(x7743.QtyDateProdDefect)
            x7743.QtyDateDefectPass = trim$(x7743.QtyDateDefectPass)
            x7743.QtyDateDefectReject = trim$(x7743.QtyDateDefectReject)
            x7743.CheckUse = trim$(x7743.CheckUse)

            If trim$(x7743.cdFactory) = "" Then x7743.cdFactory = Space(1)
            If trim$(x7743.cdSubProcess) = "" Then x7743.cdSubProcess = Space(1)
            If trim$(x7743.DatePlan) = "" Then x7743.DatePlan = Space(1)
            If trim$(x7743.cdLineProd) = "" Then x7743.cdLineProd = Space(1)
            If trim$(x7743.SeqJob) = "" Then x7743.SeqJob = Space(1)
            If trim$(x7743.seSubProcess) = "" Then x7743.seSubProcess = Space(1)
            If trim$(x7743.seMainProcess) = "" Then x7743.seMainProcess = Space(1)
            If trim$(x7743.cdMainProcess) = "" Then x7743.cdMainProcess = Space(1)
            If trim$(x7743.InchargeJob) = "" Then x7743.InchargeJob = Space(1)
            If trim$(x7743.InchargeTeam) = "" Then x7743.InchargeTeam = Space(1)
            If trim$(x7743.seJobProcess) = "" Then x7743.seJobProcess = Space(1)
            If trim$(x7743.cdJobProcess) = "" Then x7743.cdJobProcess = Space(1)
            If trim$(x7743.MachineCode) = "" Then x7743.MachineCode = Space(1)
            If trim$(x7743.InchargeSelect) = "" Then x7743.InchargeSelect = Space(1)
            If trim$(x7743.Grade) = "" Then x7743.Grade = Space(1)
            If trim$(x7743.Food) = "" Then x7743.Food = Space(1)
            If Trim$(x7743.chkWorker) = "" Then x7743.chkWorker = Space(1)
            If Trim$(x7743.chkTeam) = "" Then x7743.chkTeam = Space(1)
            If trim$(x7743.WorkTime) = "" Then x7743.WorkTime = Space(1)
            If trim$(x7743.QtyTargetDay) = "" Then x7743.QtyTargetDay = 0
            If trim$(x7743.QtyTargetHour) = "" Then x7743.QtyTargetHour = 0
            If trim$(x7743.QtyRateSecondJob) = "" Then x7743.QtyRateSecondJob = 0
            If trim$(x7743.QtyDateProdNormal) = "" Then x7743.QtyDateProdNormal = 0
            If trim$(x7743.QtyDateProdDefect) = "" Then x7743.QtyDateProdDefect = 0
            If trim$(x7743.QtyDateDefectPass) = "" Then x7743.QtyDateDefectPass = 0
            If trim$(x7743.QtyDateDefectReject) = "" Then x7743.QtyDateDefectReject = 0
            If trim$(x7743.CheckUse) = "" Then x7743.CheckUse = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K7743_MOVE(rs7743 As SqlClient.SqlDataReader)
        Try

            Call D7743_CLEAR()

            If IsdbNull(rs7743!K7743_cdFactory) = False Then D7743.cdFactory = Trim$(rs7743!K7743_cdFactory)
            If IsdbNull(rs7743!K7743_cdSubProcess) = False Then D7743.cdSubProcess = Trim$(rs7743!K7743_cdSubProcess)
            If IsdbNull(rs7743!K7743_DatePlan) = False Then D7743.DatePlan = Trim$(rs7743!K7743_DatePlan)
            If IsdbNull(rs7743!K7743_cdLineProd) = False Then D7743.cdLineProd = Trim$(rs7743!K7743_cdLineProd)
            If IsdbNull(rs7743!K7743_SeqJob) = False Then D7743.SeqJob = Trim$(rs7743!K7743_SeqJob)
            If IsdbNull(rs7743!K7743_seSubProcess) = False Then D7743.seSubProcess = Trim$(rs7743!K7743_seSubProcess)
            If IsdbNull(rs7743!K7743_seMainProcess) = False Then D7743.seMainProcess = Trim$(rs7743!K7743_seMainProcess)
            If IsdbNull(rs7743!K7743_cdMainProcess) = False Then D7743.cdMainProcess = Trim$(rs7743!K7743_cdMainProcess)
            If IsdbNull(rs7743!K7743_InchargeJob) = False Then D7743.InchargeJob = Trim$(rs7743!K7743_InchargeJob)
            If IsdbNull(rs7743!K7743_InchargeTeam) = False Then D7743.InchargeTeam = Trim$(rs7743!K7743_InchargeTeam)
            If IsdbNull(rs7743!K7743_seJobProcess) = False Then D7743.seJobProcess = Trim$(rs7743!K7743_seJobProcess)
            If IsdbNull(rs7743!K7743_cdJobProcess) = False Then D7743.cdJobProcess = Trim$(rs7743!K7743_cdJobProcess)
            If IsdbNull(rs7743!K7743_MachineCode) = False Then D7743.MachineCode = Trim$(rs7743!K7743_MachineCode)
            If IsdbNull(rs7743!K7743_InchargeSelect) = False Then D7743.InchargeSelect = Trim$(rs7743!K7743_InchargeSelect)
            If IsdbNull(rs7743!K7743_Grade) = False Then D7743.Grade = Trim$(rs7743!K7743_Grade)
            If IsdbNull(rs7743!K7743_Food) = False Then D7743.Food = Trim$(rs7743!K7743_Food)
            If IsDBNull(rs7743!K7743_chkWorker) = False Then D7743.chkWorker = Trim$(rs7743!K7743_chkWorker)
            If IsDBNull(rs7743!K7743_chkTeam) = False Then D7743.chkTeam = Trim$(rs7743!K7743_chkTeam)
            If IsdbNull(rs7743!K7743_WorkTime) = False Then D7743.WorkTime = Trim$(rs7743!K7743_WorkTime)
            If IsdbNull(rs7743!K7743_QtyTargetDay) = False Then D7743.QtyTargetDay = Trim$(rs7743!K7743_QtyTargetDay)
            If IsdbNull(rs7743!K7743_QtyTargetHour) = False Then D7743.QtyTargetHour = Trim$(rs7743!K7743_QtyTargetHour)
            If IsdbNull(rs7743!K7743_QtyRateSecondJob) = False Then D7743.QtyRateSecondJob = Trim$(rs7743!K7743_QtyRateSecondJob)
            If IsdbNull(rs7743!K7743_QtyDateProdNormal) = False Then D7743.QtyDateProdNormal = Trim$(rs7743!K7743_QtyDateProdNormal)
            If IsdbNull(rs7743!K7743_QtyDateProdDefect) = False Then D7743.QtyDateProdDefect = Trim$(rs7743!K7743_QtyDateProdDefect)
            If IsdbNull(rs7743!K7743_QtyDateDefectPass) = False Then D7743.QtyDateDefectPass = Trim$(rs7743!K7743_QtyDateDefectPass)
            If IsdbNull(rs7743!K7743_QtyDateDefectReject) = False Then D7743.QtyDateDefectReject = Trim$(rs7743!K7743_QtyDateDefectReject)
            If IsdbNull(rs7743!K7743_CheckUse) = False Then D7743.CheckUse = Trim$(rs7743!K7743_CheckUse)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K7743_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K7743_MOVE(rs7743 As DataRow)
        Try

            Call D7743_CLEAR()

            If IsdbNull(rs7743!K7743_cdFactory) = False Then D7743.cdFactory = Trim$(rs7743!K7743_cdFactory)
            If IsdbNull(rs7743!K7743_cdSubProcess) = False Then D7743.cdSubProcess = Trim$(rs7743!K7743_cdSubProcess)
            If IsdbNull(rs7743!K7743_DatePlan) = False Then D7743.DatePlan = Trim$(rs7743!K7743_DatePlan)
            If IsdbNull(rs7743!K7743_cdLineProd) = False Then D7743.cdLineProd = Trim$(rs7743!K7743_cdLineProd)
            If IsdbNull(rs7743!K7743_SeqJob) = False Then D7743.SeqJob = Trim$(rs7743!K7743_SeqJob)
            If IsdbNull(rs7743!K7743_seSubProcess) = False Then D7743.seSubProcess = Trim$(rs7743!K7743_seSubProcess)
            If IsdbNull(rs7743!K7743_seMainProcess) = False Then D7743.seMainProcess = Trim$(rs7743!K7743_seMainProcess)
            If IsdbNull(rs7743!K7743_cdMainProcess) = False Then D7743.cdMainProcess = Trim$(rs7743!K7743_cdMainProcess)
            If IsdbNull(rs7743!K7743_InchargeJob) = False Then D7743.InchargeJob = Trim$(rs7743!K7743_InchargeJob)
            If IsdbNull(rs7743!K7743_InchargeTeam) = False Then D7743.InchargeTeam = Trim$(rs7743!K7743_InchargeTeam)
            If IsdbNull(rs7743!K7743_seJobProcess) = False Then D7743.seJobProcess = Trim$(rs7743!K7743_seJobProcess)
            If IsdbNull(rs7743!K7743_cdJobProcess) = False Then D7743.cdJobProcess = Trim$(rs7743!K7743_cdJobProcess)
            If IsdbNull(rs7743!K7743_MachineCode) = False Then D7743.MachineCode = Trim$(rs7743!K7743_MachineCode)
            If IsdbNull(rs7743!K7743_InchargeSelect) = False Then D7743.InchargeSelect = Trim$(rs7743!K7743_InchargeSelect)
            If IsdbNull(rs7743!K7743_Grade) = False Then D7743.Grade = Trim$(rs7743!K7743_Grade)
            If IsdbNull(rs7743!K7743_Food) = False Then D7743.Food = Trim$(rs7743!K7743_Food)
            If IsDBNull(rs7743!K7743_chkWorker) = False Then D7743.chkWorker = Trim$(rs7743!K7743_chkWorker)
            If IsDBNull(rs7743!K7743_chkTeam) = False Then D7743.chkTeam = Trim$(rs7743!K7743_chkTeam)
            If IsdbNull(rs7743!K7743_WorkTime) = False Then D7743.WorkTime = Trim$(rs7743!K7743_WorkTime)
            If IsdbNull(rs7743!K7743_QtyTargetDay) = False Then D7743.QtyTargetDay = Trim$(rs7743!K7743_QtyTargetDay)
            If IsdbNull(rs7743!K7743_QtyTargetHour) = False Then D7743.QtyTargetHour = Trim$(rs7743!K7743_QtyTargetHour)
            If IsdbNull(rs7743!K7743_QtyRateSecondJob) = False Then D7743.QtyRateSecondJob = Trim$(rs7743!K7743_QtyRateSecondJob)
            If IsdbNull(rs7743!K7743_QtyDateProdNormal) = False Then D7743.QtyDateProdNormal = Trim$(rs7743!K7743_QtyDateProdNormal)
            If IsdbNull(rs7743!K7743_QtyDateProdDefect) = False Then D7743.QtyDateProdDefect = Trim$(rs7743!K7743_QtyDateProdDefect)
            If IsdbNull(rs7743!K7743_QtyDateDefectPass) = False Then D7743.QtyDateDefectPass = Trim$(rs7743!K7743_QtyDateDefectPass)
            If IsdbNull(rs7743!K7743_QtyDateDefectReject) = False Then D7743.QtyDateDefectReject = Trim$(rs7743!K7743_QtyDateDefectReject)
            If IsdbNull(rs7743!K7743_CheckUse) = False Then D7743.CheckUse = Trim$(rs7743!K7743_CheckUse)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K7743_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K7743_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z7743 As T7743_AREA, CDFACTORY As String, CDSUBPROCESS As String, DATEPLAN As String, CDLINEPROD As String, SEQJOB As String) As Boolean

        K7743_MOVE = False

        Try
            If READ_PFK7743(CDFACTORY, CDSUBPROCESS, DATEPLAN, CDLINEPROD, SEQJOB) = True Then
                z7743 = D7743
                K7743_MOVE = True
            Else
                z7743 = Nothing
            End If

            If getColumIndex(spr, "cdFactory") > -1 Then z7743.cdFactory = getDataM(spr, getColumIndex(spr, "cdFactory"), xRow)
            If getColumIndex(spr, "cdSubProcess") > -1 Then z7743.cdSubProcess = getDataM(spr, getColumIndex(spr, "cdSubProcess"), xRow)
            If getColumIndex(spr, "DatePlan") > -1 Then z7743.DatePlan = getDataM(spr, getColumIndex(spr, "DatePlan"), xRow)
            If getColumIndex(spr, "cdLineProd") > -1 Then z7743.cdLineProd = getDataM(spr, getColumIndex(spr, "cdLineProd"), xRow)
            If getColumIndex(spr, "SeqJob") > -1 Then z7743.SeqJob = getDataM(spr, getColumIndex(spr, "SeqJob"), xRow)
            If getColumIndex(spr, "seSubProcess") > -1 Then z7743.seSubProcess = getDataM(spr, getColumIndex(spr, "seSubProcess"), xRow)
            If getColumIndex(spr, "seMainProcess") > -1 Then z7743.seMainProcess = getDataM(spr, getColumIndex(spr, "seMainProcess"), xRow)
            If getColumIndex(spr, "cdMainProcess") > -1 Then z7743.cdMainProcess = getDataM(spr, getColumIndex(spr, "cdMainProcess"), xRow)
            If getColumIndex(spr, "InchargeJob") > -1 Then z7743.InchargeJob = getDataM(spr, getColumIndex(spr, "InchargeJob"), xRow)
            If getColumIndex(spr, "InchargeTeam") > -1 Then z7743.InchargeTeam = getDataM(spr, getColumIndex(spr, "InchargeTeam"), xRow)
            If getColumIndex(spr, "seJobProcess") > -1 Then z7743.seJobProcess = getDataM(spr, getColumIndex(spr, "seJobProcess"), xRow)
            If getColumIndex(spr, "cdJobProcess") > -1 Then z7743.cdJobProcess = getDataM(spr, getColumIndex(spr, "cdJobProcess"), xRow)
            If getColumIndex(spr, "MachineCode") > -1 Then z7743.MachineCode = getDataM(spr, getColumIndex(spr, "MachineCode"), xRow)
            If getColumIndex(spr, "InchargeSelect") > -1 Then z7743.InchargeSelect = getDataM(spr, getColumIndex(spr, "InchargeSelect"), xRow)
            If getColumIndex(spr, "Grade") > -1 Then z7743.Grade = getDataM(spr, getColumIndex(spr, "Grade"), xRow)
            If getColumIndex(spr, "Food") > -1 Then z7743.Food = getDataM(spr, getColumIndex(spr, "Food"), xRow)
            If getColumIndex(spr, "chkWorker") > -1 Then z7743.chkWorker = getDataM(spr, getColumIndex(spr, "chkWorker"), xRow)
            If getColumIndex(spr, "chkTeam") > -1 Then z7743.chkTeam = getDataM(spr, getColumIndex(spr, "chkTeam"), xRow)
            If getColumIndex(spr, "WorkTime") > -1 Then z7743.WorkTime = getDataM(spr, getColumIndex(spr, "WorkTime"), xRow)
            If getColumIndex(spr, "QtyTargetDay") > -1 Then z7743.QtyTargetDay = getDataM(spr, getColumIndex(spr, "QtyTargetDay"), xRow)
            If getColumIndex(spr, "QtyTargetHour") > -1 Then z7743.QtyTargetHour = getDataM(spr, getColumIndex(spr, "QtyTargetHour"), xRow)
            If getColumIndex(spr, "QtyRateSecondJob") > -1 Then z7743.QtyRateSecondJob = getDataM(spr, getColumIndex(spr, "QtyRateSecondJob"), xRow)
            If getColumIndex(spr, "QtyDateProdNormal") > -1 Then z7743.QtyDateProdNormal = getDataM(spr, getColumIndex(spr, "QtyDateProdNormal"), xRow)
            If getColumIndex(spr, "QtyDateProdDefect") > -1 Then z7743.QtyDateProdDefect = getDataM(spr, getColumIndex(spr, "QtyDateProdDefect"), xRow)
            If getColumIndex(spr, "QtyDateDefectPass") > -1 Then z7743.QtyDateDefectPass = getDataM(spr, getColumIndex(spr, "QtyDateDefectPass"), xRow)
            If getColumIndex(spr, "QtyDateDefectReject") > -1 Then z7743.QtyDateDefectReject = getDataM(spr, getColumIndex(spr, "QtyDateDefectReject"), xRow)
            If getColumIndex(spr, "CheckUse") > -1 Then z7743.CheckUse = getDataM(spr, getColumIndex(spr, "CheckUse"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7743_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K7743_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z7743 As T7743_AREA, CheckClear As Boolean, CDFACTORY As String, CDSUBPROCESS As String, DATEPLAN As String, CDLINEPROD As String, SEQJOB As String) As Boolean

        K7743_MOVE = False

        Try
            If READ_PFK7743(CDFACTORY, CDSUBPROCESS, DATEPLAN, CDLINEPROD, SEQJOB) = True Then
                z7743 = D7743
                K7743_MOVE = True
            Else
                If CheckClear = True Then z7743 = Nothing
            End If

            If getColumIndex(spr, "cdFactory") > -1 Then z7743.cdFactory = getDataM(spr, getColumIndex(spr, "cdFactory"), xRow)
            If getColumIndex(spr, "cdSubProcess") > -1 Then z7743.cdSubProcess = getDataM(spr, getColumIndex(spr, "cdSubProcess"), xRow)
            If getColumIndex(spr, "DatePlan") > -1 Then z7743.DatePlan = getDataM(spr, getColumIndex(spr, "DatePlan"), xRow)
            If getColumIndex(spr, "cdLineProd") > -1 Then z7743.cdLineProd = getDataM(spr, getColumIndex(spr, "cdLineProd"), xRow)
            If getColumIndex(spr, "SeqJob") > -1 Then z7743.SeqJob = getDataM(spr, getColumIndex(spr, "SeqJob"), xRow)
            If getColumIndex(spr, "seSubProcess") > -1 Then z7743.seSubProcess = getDataM(spr, getColumIndex(spr, "seSubProcess"), xRow)
            If getColumIndex(spr, "seMainProcess") > -1 Then z7743.seMainProcess = getDataM(spr, getColumIndex(spr, "seMainProcess"), xRow)
            If getColumIndex(spr, "cdMainProcess") > -1 Then z7743.cdMainProcess = getDataM(spr, getColumIndex(spr, "cdMainProcess"), xRow)
            If getColumIndex(spr, "InchargeJob") > -1 Then z7743.InchargeJob = getDataM(spr, getColumIndex(spr, "InchargeJob"), xRow)
            If getColumIndex(spr, "InchargeTeam") > -1 Then z7743.InchargeTeam = getDataM(spr, getColumIndex(spr, "InchargeTeam"), xRow)
            If getColumIndex(spr, "seJobProcess") > -1 Then z7743.seJobProcess = getDataM(spr, getColumIndex(spr, "seJobProcess"), xRow)
            If getColumIndex(spr, "cdJobProcess") > -1 Then z7743.cdJobProcess = getDataM(spr, getColumIndex(spr, "cdJobProcess"), xRow)
            If getColumIndex(spr, "MachineCode") > -1 Then z7743.MachineCode = getDataM(spr, getColumIndex(spr, "MachineCode"), xRow)
            If getColumIndex(spr, "InchargeSelect") > -1 Then z7743.InchargeSelect = getDataM(spr, getColumIndex(spr, "InchargeSelect"), xRow)
            If getColumIndex(spr, "Grade") > -1 Then z7743.Grade = getDataM(spr, getColumIndex(spr, "Grade"), xRow)
            If getColumIndex(spr, "Food") > -1 Then z7743.Food = getDataM(spr, getColumIndex(spr, "Food"), xRow)
            If getColumIndex(spr, "chkWorker") > -1 Then z7743.chkWorker = getDataM(spr, getColumIndex(spr, "chkWorker"), xRow)
            If getColumIndex(spr, "chkTeam") > -1 Then z7743.chkTeam = getDataM(spr, getColumIndex(spr, "chkTeam"), xRow)
            If getColumIndex(spr, "WorkTime") > -1 Then z7743.WorkTime = getDataM(spr, getColumIndex(spr, "WorkTime"), xRow)
            If getColumIndex(spr, "QtyTargetDay") > -1 Then z7743.QtyTargetDay = getDataM(spr, getColumIndex(spr, "QtyTargetDay"), xRow)
            If getColumIndex(spr, "QtyTargetHour") > -1 Then z7743.QtyTargetHour = getDataM(spr, getColumIndex(spr, "QtyTargetHour"), xRow)
            If getColumIndex(spr, "QtyRateSecondJob") > -1 Then z7743.QtyRateSecondJob = getDataM(spr, getColumIndex(spr, "QtyRateSecondJob"), xRow)
            If getColumIndex(spr, "QtyDateProdNormal") > -1 Then z7743.QtyDateProdNormal = getDataM(spr, getColumIndex(spr, "QtyDateProdNormal"), xRow)
            If getColumIndex(spr, "QtyDateProdDefect") > -1 Then z7743.QtyDateProdDefect = getDataM(spr, getColumIndex(spr, "QtyDateProdDefect"), xRow)
            If getColumIndex(spr, "QtyDateDefectPass") > -1 Then z7743.QtyDateDefectPass = getDataM(spr, getColumIndex(spr, "QtyDateDefectPass"), xRow)
            If getColumIndex(spr, "QtyDateDefectReject") > -1 Then z7743.QtyDateDefectReject = getDataM(spr, getColumIndex(spr, "QtyDateDefectReject"), xRow)
            If getColumIndex(spr, "CheckUse") > -1 Then z7743.CheckUse = getDataM(spr, getColumIndex(spr, "CheckUse"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7743_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K7743_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z7743 As T7743_AREA, Job As String, CDFACTORY As String, CDSUBPROCESS As String, DATEPLAN As String, CDLINEPROD As String, SEQJOB As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K7743_MOVE = False

        Try
            If READ_PFK7743(CDFACTORY, CDSUBPROCESS, DATEPLAN, CDLINEPROD, SEQJOB) = True Then
                z7743 = D7743
                K7743_MOVE = True
            Else
                z7743 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7743")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "CDFACTORY" : z7743.cdFactory = Children(i).Code
                                Case "CDSUBPROCESS" : z7743.cdSubProcess = Children(i).Code
                                Case "DATEPLAN" : z7743.DatePlan = Children(i).Code
                                Case "CDLINEPROD" : z7743.cdLineProd = Children(i).Code
                                Case "SEQJOB" : z7743.SeqJob = Children(i).Code
                                Case "SESUBPROCESS" : z7743.seSubProcess = Children(i).Code
                                Case "SEMAINPROCESS" : z7743.seMainProcess = Children(i).Code
                                Case "CDMAINPROCESS" : z7743.cdMainProcess = Children(i).Code
                                Case "INCHARGEJOB" : z7743.InchargeJob = Children(i).Code
                                Case "INCHARGETEAM" : z7743.InchargeTeam = Children(i).Code
                                Case "SEJOBPROCESS" : z7743.seJobProcess = Children(i).Code
                                Case "CDJOBPROCESS" : z7743.cdJobProcess = Children(i).Code
                                Case "MACHINECODE" : z7743.MachineCode = Children(i).Code
                                Case "INCHARGESELECT" : z7743.InchargeSelect = Children(i).Code
                                Case "GRADE" : z7743.Grade = Children(i).Code
                                Case "FOOD" : z7743.Food = Children(i).Code
                                Case "CHKWORKER" : z7743.chkWorker = Children(i).Code
                                Case "chkTeam" : z7743.chkTeam = Children(i).Code
                                Case "WORKTIME" : z7743.WorkTime = Children(i).Code
                                Case "QTYTARGETDAY" : z7743.QtyTargetDay = Children(i).Code
                                Case "QTYTARGETHOUR" : z7743.QtyTargetHour = Children(i).Code
                                Case "QTYRATESECONDJOB" : z7743.QtyRateSecondJob = Children(i).Code
                                Case "QTYDATEPRODNORMAL" : z7743.QtyDateProdNormal = Children(i).Code
                                Case "QTYDATEPRODDEFECT" : z7743.QtyDateProdDefect = Children(i).Code
                                Case "QTYDATEDEFECTPASS" : z7743.QtyDateDefectPass = Children(i).Code
                                Case "QTYDATEDEFECTREJECT" : z7743.QtyDateDefectReject = Children(i).Code
                                Case "CHECKUSE" : z7743.CheckUse = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "CDFACTORY" : z7743.cdFactory = Children(i).Data
                                Case "CDSUBPROCESS" : z7743.cdSubProcess = Children(i).Data
                                Case "DATEPLAN" : z7743.DatePlan = Children(i).Data
                                Case "CDLINEPROD" : z7743.cdLineProd = Children(i).Data
                                Case "SEQJOB" : z7743.SeqJob = Children(i).Data
                                Case "SESUBPROCESS" : z7743.seSubProcess = Children(i).Data
                                Case "SEMAINPROCESS" : z7743.seMainProcess = Children(i).Data
                                Case "CDMAINPROCESS" : z7743.cdMainProcess = Children(i).Data
                                Case "INCHARGEJOB" : z7743.InchargeJob = Children(i).Data
                                Case "INCHARGETEAM" : z7743.InchargeTeam = Children(i).Data
                                Case "SEJOBPROCESS" : z7743.seJobProcess = Children(i).Data
                                Case "CDJOBPROCESS" : z7743.cdJobProcess = Children(i).Data
                                Case "MACHINECODE" : z7743.MachineCode = Children(i).Data
                                Case "INCHARGESELECT" : z7743.InchargeSelect = Children(i).Data
                                Case "GRADE" : z7743.Grade = Children(i).Data
                                Case "FOOD" : z7743.Food = Children(i).Data
                                Case "CHKWORKER" : z7743.chkWorker = Children(i).Data
                                Case "chkTeam" : z7743.chkTeam = Children(i).Data
                                Case "WORKTIME" : z7743.WorkTime = Children(i).Data
                                Case "QTYTARGETDAY" : z7743.QtyTargetDay = Children(i).Data
                                Case "QTYTARGETHOUR" : z7743.QtyTargetHour = Children(i).Data
                                Case "QTYRATESECONDJOB" : z7743.QtyRateSecondJob = Children(i).Data
                                Case "QTYDATEPRODNORMAL" : z7743.QtyDateProdNormal = Children(i).Data
                                Case "QTYDATEPRODDEFECT" : z7743.QtyDateProdDefect = Children(i).Data
                                Case "QTYDATEDEFECTPASS" : z7743.QtyDateDefectPass = Children(i).Data
                                Case "QTYDATEDEFECTREJECT" : z7743.QtyDateDefectReject = Children(i).Data
                                Case "CHECKUSE" : z7743.CheckUse = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7743_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K7743_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z7743 As T7743_AREA, Job As String, CheckClear As Boolean, CDFACTORY As String, CDSUBPROCESS As String, DATEPLAN As String, CDLINEPROD As String, SEQJOB As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K7743_MOVE = False

        Try
            If READ_PFK7743(CDFACTORY, CDSUBPROCESS, DATEPLAN, CDLINEPROD, SEQJOB) = True Then
                z7743 = D7743
                K7743_MOVE = True
            Else
                If CheckClear = True Then z7743 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7743")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "CDFACTORY" : z7743.cdFactory = Children(i).Code
                                Case "CDSUBPROCESS" : z7743.cdSubProcess = Children(i).Code
                                Case "DATEPLAN" : z7743.DatePlan = Children(i).Code
                                Case "CDLINEPROD" : z7743.cdLineProd = Children(i).Code
                                Case "SEQJOB" : z7743.SeqJob = Children(i).Code
                                Case "SESUBPROCESS" : z7743.seSubProcess = Children(i).Code
                                Case "SEMAINPROCESS" : z7743.seMainProcess = Children(i).Code
                                Case "CDMAINPROCESS" : z7743.cdMainProcess = Children(i).Code
                                Case "INCHARGEJOB" : z7743.InchargeJob = Children(i).Code
                                Case "INCHARGETEAM" : z7743.InchargeTeam = Children(i).Code
                                Case "SEJOBPROCESS" : z7743.seJobProcess = Children(i).Code
                                Case "CDJOBPROCESS" : z7743.cdJobProcess = Children(i).Code
                                Case "MACHINECODE" : z7743.MachineCode = Children(i).Code
                                Case "INCHARGESELECT" : z7743.InchargeSelect = Children(i).Code
                                Case "GRADE" : z7743.Grade = Children(i).Code
                                Case "FOOD" : z7743.Food = Children(i).Code
                                Case "CHKWORKER" : z7743.chkWorker = Children(i).Code
                                Case "chkTeam" : z7743.chkTeam = Children(i).Code
                                Case "WORKTIME" : z7743.WorkTime = Children(i).Code
                                Case "QTYTARGETDAY" : z7743.QtyTargetDay = Children(i).Code
                                Case "QTYTARGETHOUR" : z7743.QtyTargetHour = Children(i).Code
                                Case "QTYRATESECONDJOB" : z7743.QtyRateSecondJob = Children(i).Code
                                Case "QTYDATEPRODNORMAL" : z7743.QtyDateProdNormal = Children(i).Code
                                Case "QTYDATEPRODDEFECT" : z7743.QtyDateProdDefect = Children(i).Code
                                Case "QTYDATEDEFECTPASS" : z7743.QtyDateDefectPass = Children(i).Code
                                Case "QTYDATEDEFECTREJECT" : z7743.QtyDateDefectReject = Children(i).Code
                                Case "CHECKUSE" : z7743.CheckUse = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "CDFACTORY" : z7743.cdFactory = Children(i).Data
                                Case "CDSUBPROCESS" : z7743.cdSubProcess = Children(i).Data
                                Case "DATEPLAN" : z7743.DatePlan = Children(i).Data
                                Case "CDLINEPROD" : z7743.cdLineProd = Children(i).Data
                                Case "SEQJOB" : z7743.SeqJob = Children(i).Data
                                Case "SESUBPROCESS" : z7743.seSubProcess = Children(i).Data
                                Case "SEMAINPROCESS" : z7743.seMainProcess = Children(i).Data
                                Case "CDMAINPROCESS" : z7743.cdMainProcess = Children(i).Data
                                Case "INCHARGEJOB" : z7743.InchargeJob = Children(i).Data
                                Case "INCHARGETEAM" : z7743.InchargeTeam = Children(i).Data
                                Case "SEJOBPROCESS" : z7743.seJobProcess = Children(i).Data
                                Case "CDJOBPROCESS" : z7743.cdJobProcess = Children(i).Data
                                Case "MACHINECODE" : z7743.MachineCode = Children(i).Data
                                Case "INCHARGESELECT" : z7743.InchargeSelect = Children(i).Data
                                Case "GRADE" : z7743.Grade = Children(i).Data
                                Case "FOOD" : z7743.Food = Children(i).Data
                                Case "CHKWORKER" : z7743.chkWorker = Children(i).Data
                                Case "chkTeam" : z7743.chkTeam = Children(i).Data
                                Case "WORKTIME" : z7743.WorkTime = Children(i).Data
                                Case "QTYTARGETDAY" : z7743.QtyTargetDay = Children(i).Data
                                Case "QTYTARGETHOUR" : z7743.QtyTargetHour = Children(i).Data
                                Case "QTYRATESECONDJOB" : z7743.QtyRateSecondJob = Children(i).Data
                                Case "QTYDATEPRODNORMAL" : z7743.QtyDateProdNormal = Children(i).Data
                                Case "QTYDATEPRODDEFECT" : z7743.QtyDateProdDefect = Children(i).Data
                                Case "QTYDATEDEFECTPASS" : z7743.QtyDateDefectPass = Children(i).Data
                                Case "QTYDATEDEFECTREJECT" : z7743.QtyDateDefectReject = Children(i).Data
                                Case "CHECKUSE" : z7743.CheckUse = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7743_MOVE", vbCritical)
        End Try
    End Function

End Module
