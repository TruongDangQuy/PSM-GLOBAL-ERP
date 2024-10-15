'=========================================================================================================================================================
'   TABLE : (PFK9222)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K9222

    Structure T9222_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public Autokey As Double  '			decimal		*
        Public Dseq As Double  '			decimal
        Public Content As String  '			nvarchar(200)
        Public DatePlan As String  '			char(8)
        Public InchargePlan As String  '			char(8)
        Public seUrgentCode As String  '			char(3)
        Public cdUrgentCode As String  '			char(3)
        Public seImportantCode As String  '			char(3)
        Public cdImportantCode As String  '			char(3)
        Public seProjectCode As String  '			char(3)
        Public cdProjectCode As String  '			char(3)
        Public seModuleCode As String  '			char(3)
        Public cdModuleCode As String  '			char(3)
        Public seFunctionCode As String  '			char(3)
        Public cdFunctionCode As String  '			char(3)
        Public Description As String  '			nvarchar(500)
        Public seInchargeCustomer As String  '			char(3)
        Public cdInchargeCustomer As String  '			char(3)
        Public seInchargePSM As String  '			char(3)
        Public cdInchargePSM As String  '			char(3)
        Public seInchargePSMSP As String  '			char(3)
        Public cdInchargePSMSP As String  '			char(3)
        Public DateTimeStart As String
        Public DateTimeFinish As String
        Public DateTimeDeadline As String
        Public CheckPlan As String  '			char(1)
        Public CheckResult As String  '			char(1)
        Public CheckComplete As String  '			char(1)
        Public Remark As String  '			nvarchar(200)
        Public ComputerName As String  '			nvarchar(200)
        Public AccountWin As String  '			nvarchar(50)
        Public UserCode As String  '			char(8)
        Public IPWan As String  '			varchar(30)
        Public MACAddress As String  '			varchar(40)
        Public HDDSerialNo As String  '			varchar(50)
        Public DeviceName As String  '			nvarchar(500)
        Public Active As String  '			char(1)
        '=========================================================================================================================================================
    End Structure

    Public D9222 As T9222_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK9222(AUTOKEY As Double) As Boolean
        READ_PFK9222 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK9222 "
            SQL = SQL & " WHERE K9222_Autokey		 =  " & Autokey & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D9222_CLEAR() : GoTo SKIP_READ_PFK9222

            Call K9222_MOVE(rd)
            READ_PFK9222 = True

SKIP_READ_PFK9222:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK9222", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK9222(AUTOKEY As Double, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK9222 "
            SQL = SQL & " WHERE K9222_Autokey		 =  " & Autokey & "  "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK9222", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK9222(z9222 As T9222_AREA) As Boolean
        WRITE_PFK9222 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z9222)

            SQL = " INSERT INTO PFK9222 "
            SQL = SQL & " ( "
            SQL = SQL & " K9222_Autokey,"
            SQL = SQL & " K9222_Dseq,"
            SQL = SQL & " K9222_Content,"
            SQL = SQL & " K9222_DatePlan,"
            SQL = SQL & " K9222_InchargePlan,"
            SQL = SQL & " K9222_seUrgentCode,"
            SQL = SQL & " K9222_cdUrgentCode,"
            SQL = SQL & " K9222_seImportantCode,"
            SQL = SQL & " K9222_cdImportantCode,"
            SQL = SQL & " K9222_seProjectCode,"
            SQL = SQL & " K9222_cdProjectCode,"
            SQL = SQL & " K9222_seModuleCode,"
            SQL = SQL & " K9222_cdModuleCode,"
            SQL = SQL & " K9222_seFunctionCode,"
            SQL = SQL & " K9222_cdFunctionCode,"
            SQL = SQL & " K9222_Description,"
            SQL = SQL & " K9222_seInchargeCustomer,"
            SQL = SQL & " K9222_cdInchargeCustomer,"
            SQL = SQL & " K9222_seInchargePSM,"
            SQL = SQL & " K9222_cdInchargePSM,"
            SQL = SQL & " K9222_seInchargePSMSP,"
            SQL = SQL & " K9222_cdInchargePSMSP,"
            SQL = SQL & " K9222_DateTimeStart,"
            SQL = SQL & " K9222_DateTimeFinish,"
            SQL = SQL & " K9222_DateTimeDeadline,"
            SQL = SQL & " K9222_CheckPlan,"
            SQL = SQL & " K9222_CheckResult,"
            SQL = SQL & " K9222_CheckComplete,"
            SQL = SQL & " K9222_Remark,"
            SQL = SQL & " K9222_ComputerName,"
            SQL = SQL & " K9222_AccountWin,"
            SQL = SQL & " K9222_UserCode,"
            SQL = SQL & " K9222_IPWan,"
            SQL = SQL & " K9222_MACAddress,"
            SQL = SQL & " K9222_HDDSerialNo,"
            SQL = SQL & " K9222_DeviceName,"
            SQL = SQL & " K9222_Active "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "   " & FormatSQL(z9222.Autokey) & ", "
            SQL = SQL & "   " & FormatSQL(z9222.Dseq) & ", "
            SQL = SQL & "  N'" & FormatSQL(z9222.Content) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9222.DatePlan) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9222.InchargePlan) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9222.seUrgentCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9222.cdUrgentCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9222.seImportantCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9222.cdImportantCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9222.seProjectCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9222.cdProjectCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9222.seModuleCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9222.cdModuleCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9222.seFunctionCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9222.cdFunctionCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9222.Description) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9222.seInchargeCustomer) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9222.cdInchargeCustomer) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9222.seInchargePSM) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9222.cdInchargePSM) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9222.seInchargePSMSP) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9222.cdInchargePSMSP) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9222.DateTimeStart) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9222.DateTimeFinish) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9222.DateTimeDeadline) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9222.CheckPlan) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9222.CheckResult) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9222.CheckComplete) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9222.Remark) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9222.ComputerName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9222.AccountWin) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9222.UserCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9222.IPWan) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9222.MACAddress) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9222.HDDSerialNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9222.DeviceName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9222.Active) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK9222 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK9222", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK9222(z9222 As T9222_AREA) As Boolean
        REWRITE_PFK9222 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z9222)

            SQL = " UPDATE PFK9222 SET "
            SQL = SQL & "    K9222_Dseq      =  " & FormatSQL(z9222.Dseq) & ", "
            SQL = SQL & "    K9222_Content      = N'" & FormatSQL(z9222.Content) & "', "
            SQL = SQL & "    K9222_DatePlan      = N'" & FormatSQL(z9222.DatePlan) & "', "
            SQL = SQL & "    K9222_InchargePlan      = N'" & FormatSQL(z9222.InchargePlan) & "', "
            SQL = SQL & "    K9222_seUrgentCode      = N'" & FormatSQL(z9222.seUrgentCode) & "', "
            SQL = SQL & "    K9222_cdUrgentCode      = N'" & FormatSQL(z9222.cdUrgentCode) & "', "
            SQL = SQL & "    K9222_seImportantCode      = N'" & FormatSQL(z9222.seImportantCode) & "', "
            SQL = SQL & "    K9222_cdImportantCode      = N'" & FormatSQL(z9222.cdImportantCode) & "', "
            SQL = SQL & "    K9222_seProjectCode      = N'" & FormatSQL(z9222.seProjectCode) & "', "
            SQL = SQL & "    K9222_cdProjectCode      = N'" & FormatSQL(z9222.cdProjectCode) & "', "
            SQL = SQL & "    K9222_seModuleCode      = N'" & FormatSQL(z9222.seModuleCode) & "', "
            SQL = SQL & "    K9222_cdModuleCode      = N'" & FormatSQL(z9222.cdModuleCode) & "', "
            SQL = SQL & "    K9222_seFunctionCode      = N'" & FormatSQL(z9222.seFunctionCode) & "', "
            SQL = SQL & "    K9222_cdFunctionCode      = N'" & FormatSQL(z9222.cdFunctionCode) & "', "
            SQL = SQL & "    K9222_Description      = N'" & FormatSQL(z9222.Description) & "', "
            SQL = SQL & "    K9222_seInchargeCustomer      = N'" & FormatSQL(z9222.seInchargeCustomer) & "', "
            SQL = SQL & "    K9222_cdInchargeCustomer      = N'" & FormatSQL(z9222.cdInchargeCustomer) & "', "
            SQL = SQL & "    K9222_seInchargePSM      = N'" & FormatSQL(z9222.seInchargePSM) & "', "
            SQL = SQL & "    K9222_cdInchargePSM      = N'" & FormatSQL(z9222.cdInchargePSM) & "', "
            SQL = SQL & "    K9222_seInchargePSMSP      = N'" & FormatSQL(z9222.seInchargePSMSP) & "', "
            SQL = SQL & "    K9222_cdInchargePSMSP      = N'" & FormatSQL(z9222.cdInchargePSMSP) & "', "
            SQL = SQL & "    K9222_DateTimeStart      = N'" & FormatSQL(z9222.DateTimeStart) & "', "
            SQL = SQL & "    K9222_DateTimeFinish      = N'" & FormatSQL(z9222.DateTimeFinish) & "', "
            SQL = SQL & "    K9222_DateTimeDeadline      = N'" & FormatSQL(z9222.DateTimeDeadline) & "', "
            SQL = SQL & "    K9222_CheckPlan      = N'" & FormatSQL(z9222.CheckPlan) & "', "
            SQL = SQL & "    K9222_CheckResult      = N'" & FormatSQL(z9222.CheckResult) & "', "
            SQL = SQL & "    K9222_CheckComplete      = N'" & FormatSQL(z9222.CheckComplete) & "', "
            SQL = SQL & "    K9222_Remark      = N'" & FormatSQL(z9222.Remark) & "', "
            SQL = SQL & "    K9222_ComputerName      = N'" & FormatSQL(z9222.ComputerName) & "', "
            SQL = SQL & "    K9222_AccountWin      = N'" & FormatSQL(z9222.AccountWin) & "', "
            SQL = SQL & "    K9222_UserCode      = N'" & FormatSQL(z9222.UserCode) & "', "
            SQL = SQL & "    K9222_IPWan      = N'" & FormatSQL(z9222.IPWan) & "', "
            SQL = SQL & "    K9222_MACAddress      = N'" & FormatSQL(z9222.MACAddress) & "', "
            SQL = SQL & "    K9222_HDDSerialNo      = N'" & FormatSQL(z9222.HDDSerialNo) & "', "
            SQL = SQL & "    K9222_DeviceName      = N'" & FormatSQL(z9222.DeviceName) & "', "
            SQL = SQL & "    K9222_Active      = N'" & FormatSQL(z9222.Active) & "'  "
            SQL = SQL & " WHERE K9222_Autokey		 =  " & z9222.Autokey & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK9222 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK9222", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK9222(z9222 As T9222_AREA) As Boolean
        DELETE_PFK9222 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK9222 "
            SQL = SQL & " WHERE K9222_Autokey		 =  " & z9222.Autokey & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK9222 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK9222", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D9222_CLEAR()
        Try

            D9222.Autokey = 0
            D9222.Dseq = 0
            D9222.Content = ""
            D9222.DatePlan = ""
            D9222.InchargePlan = ""
            D9222.seUrgentCode = ""
            D9222.cdUrgentCode = ""
            D9222.seImportantCode = ""
            D9222.cdImportantCode = ""
            D9222.seProjectCode = ""
            D9222.cdProjectCode = ""
            D9222.seModuleCode = ""
            D9222.cdModuleCode = ""
            D9222.seFunctionCode = ""
            D9222.cdFunctionCode = ""
            D9222.Description = ""
            D9222.seInchargeCustomer = ""
            D9222.cdInchargeCustomer = ""
            D9222.seInchargePSM = ""
            D9222.cdInchargePSM = ""
            D9222.seInchargePSMSP = ""
            D9222.cdInchargePSMSP = ""
            D9222.DateTimeStart = ""
            D9222.DateTimeFinish = ""
            D9222.DateTimeDeadline = ""
            D9222.CheckPlan = ""
            D9222.CheckResult = ""
            D9222.CheckComplete = ""
            D9222.Remark = ""
            D9222.ComputerName = ""
            D9222.AccountWin = ""
            D9222.UserCode = ""
            D9222.IPWan = ""
            D9222.MACAddress = ""
            D9222.HDDSerialNo = ""
            D9222.DeviceName = ""
            D9222.Active = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D9222_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x9222 As T9222_AREA)
        Try

            x9222.Autokey = trim$(x9222.Autokey)
            x9222.Dseq = trim$(x9222.Dseq)
            x9222.Content = trim$(x9222.Content)
            x9222.DatePlan = trim$(x9222.DatePlan)
            x9222.InchargePlan = trim$(x9222.InchargePlan)
            x9222.seUrgentCode = trim$(x9222.seUrgentCode)
            x9222.cdUrgentCode = trim$(x9222.cdUrgentCode)
            x9222.seImportantCode = trim$(x9222.seImportantCode)
            x9222.cdImportantCode = trim$(x9222.cdImportantCode)
            x9222.seProjectCode = Trim$(x9222.seProjectCode)
            x9222.cdProjectCode = trim$(x9222.cdProjectCode)
            x9222.seModuleCode = trim$(x9222.seModuleCode)
            x9222.cdModuleCode = trim$(x9222.cdModuleCode)
            x9222.seFunctionCode = trim$(x9222.seFunctionCode)
            x9222.cdFunctionCode = trim$(x9222.cdFunctionCode)
            x9222.Description = trim$(x9222.Description)
            x9222.seInchargeCustomer = trim$(x9222.seInchargeCustomer)
            x9222.cdInchargeCustomer = trim$(x9222.cdInchargeCustomer)
            x9222.seInchargePSM = trim$(x9222.seInchargePSM)
            x9222.cdInchargePSM = trim$(x9222.cdInchargePSM)
            x9222.seInchargePSMSP = trim$(x9222.seInchargePSMSP)
            x9222.cdInchargePSMSP = trim$(x9222.cdInchargePSMSP)
            x9222.DateTimeStart = trim$(x9222.DateTimeStart)
            x9222.DateTimeFinish = trim$(x9222.DateTimeFinish)
            x9222.DateTimeDeadline = trim$(x9222.DateTimeDeadline)
            x9222.CheckPlan = trim$(x9222.CheckPlan)
            x9222.CheckResult = trim$(x9222.CheckResult)
            x9222.CheckComplete = trim$(x9222.CheckComplete)
            x9222.Remark = trim$(x9222.Remark)
            x9222.ComputerName = trim$(x9222.ComputerName)
            x9222.AccountWin = trim$(x9222.AccountWin)
            x9222.UserCode = trim$(x9222.UserCode)
            x9222.IPWan = trim$(x9222.IPWan)
            x9222.MACAddress = trim$(x9222.MACAddress)
            x9222.HDDSerialNo = trim$(x9222.HDDSerialNo)
            x9222.DeviceName = trim$(x9222.DeviceName)
            x9222.Active = trim$(x9222.Active)

            If trim$(x9222.Autokey) = "" Then x9222.Autokey = 0
            If trim$(x9222.Dseq) = "" Then x9222.Dseq = 0
            If trim$(x9222.Content) = "" Then x9222.Content = Space(1)
            If trim$(x9222.DatePlan) = "" Then x9222.DatePlan = Space(1)
            If trim$(x9222.InchargePlan) = "" Then x9222.InchargePlan = Space(1)
            If trim$(x9222.seUrgentCode) = "" Then x9222.seUrgentCode = Space(1)
            If trim$(x9222.cdUrgentCode) = "" Then x9222.cdUrgentCode = Space(1)
            If trim$(x9222.seImportantCode) = "" Then x9222.seImportantCode = Space(1)
            If trim$(x9222.cdImportantCode) = "" Then x9222.cdImportantCode = Space(1)
            If Trim$(x9222.seProjectCode) = "" Then x9222.seProjectCode = Space(1)
            If trim$(x9222.cdProjectCode) = "" Then x9222.cdProjectCode = Space(1)
            If trim$(x9222.seModuleCode) = "" Then x9222.seModuleCode = Space(1)
            If trim$(x9222.cdModuleCode) = "" Then x9222.cdModuleCode = Space(1)
            If trim$(x9222.seFunctionCode) = "" Then x9222.seFunctionCode = Space(1)
            If trim$(x9222.cdFunctionCode) = "" Then x9222.cdFunctionCode = Space(1)
            If trim$(x9222.Description) = "" Then x9222.Description = Space(1)
            If trim$(x9222.seInchargeCustomer) = "" Then x9222.seInchargeCustomer = Space(1)
            If trim$(x9222.cdInchargeCustomer) = "" Then x9222.cdInchargeCustomer = Space(1)
            If trim$(x9222.seInchargePSM) = "" Then x9222.seInchargePSM = Space(1)
            If trim$(x9222.cdInchargePSM) = "" Then x9222.cdInchargePSM = Space(1)
            If trim$(x9222.seInchargePSMSP) = "" Then x9222.seInchargePSMSP = Space(1)
            If trim$(x9222.cdInchargePSMSP) = "" Then x9222.cdInchargePSMSP = Space(1)
            If trim$(x9222.DateTimeStart) = "" Then x9222.DateTimeStart = Space(1)
            If trim$(x9222.DateTimeFinish) = "" Then x9222.DateTimeFinish = Space(1)
            If trim$(x9222.DateTimeDeadline) = "" Then x9222.DateTimeDeadline = Space(1)
            If trim$(x9222.CheckPlan) = "" Then x9222.CheckPlan = Space(1)
            If trim$(x9222.CheckResult) = "" Then x9222.CheckResult = Space(1)
            If trim$(x9222.CheckComplete) = "" Then x9222.CheckComplete = Space(1)
            If trim$(x9222.Remark) = "" Then x9222.Remark = Space(1)
            If trim$(x9222.ComputerName) = "" Then x9222.ComputerName = Space(1)
            If trim$(x9222.AccountWin) = "" Then x9222.AccountWin = Space(1)
            If trim$(x9222.UserCode) = "" Then x9222.UserCode = Space(1)
            If trim$(x9222.IPWan) = "" Then x9222.IPWan = Space(1)
            If trim$(x9222.MACAddress) = "" Then x9222.MACAddress = Space(1)
            If trim$(x9222.HDDSerialNo) = "" Then x9222.HDDSerialNo = Space(1)
            If trim$(x9222.DeviceName) = "" Then x9222.DeviceName = Space(1)
            If trim$(x9222.Active) = "" Then x9222.Active = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K9222_MOVE(rs9222 As SqlClient.SqlDataReader)
        Try

            Call D9222_CLEAR()

            If IsdbNull(rs9222!K9222_Autokey) = False Then D9222.Autokey = Trim$(rs9222!K9222_Autokey)
            If IsdbNull(rs9222!K9222_Dseq) = False Then D9222.Dseq = Trim$(rs9222!K9222_Dseq)
            If IsdbNull(rs9222!K9222_Content) = False Then D9222.Content = Trim$(rs9222!K9222_Content)
            If IsdbNull(rs9222!K9222_DatePlan) = False Then D9222.DatePlan = Trim$(rs9222!K9222_DatePlan)
            If IsdbNull(rs9222!K9222_InchargePlan) = False Then D9222.InchargePlan = Trim$(rs9222!K9222_InchargePlan)
            If IsdbNull(rs9222!K9222_seUrgentCode) = False Then D9222.seUrgentCode = Trim$(rs9222!K9222_seUrgentCode)
            If IsdbNull(rs9222!K9222_cdUrgentCode) = False Then D9222.cdUrgentCode = Trim$(rs9222!K9222_cdUrgentCode)
            If IsdbNull(rs9222!K9222_seImportantCode) = False Then D9222.seImportantCode = Trim$(rs9222!K9222_seImportantCode)
            If IsdbNull(rs9222!K9222_cdImportantCode) = False Then D9222.cdImportantCode = Trim$(rs9222!K9222_cdImportantCode)
            If IsDBNull(rs9222!K9222_seProjectCode) = False Then D9222.seProjectCode = Trim$(rs9222!K9222_seProjectCode)
            If IsdbNull(rs9222!K9222_cdProjectCode) = False Then D9222.cdProjectCode = Trim$(rs9222!K9222_cdProjectCode)
            If IsdbNull(rs9222!K9222_seModuleCode) = False Then D9222.seModuleCode = Trim$(rs9222!K9222_seModuleCode)
            If IsdbNull(rs9222!K9222_cdModuleCode) = False Then D9222.cdModuleCode = Trim$(rs9222!K9222_cdModuleCode)
            If IsdbNull(rs9222!K9222_seFunctionCode) = False Then D9222.seFunctionCode = Trim$(rs9222!K9222_seFunctionCode)
            If IsdbNull(rs9222!K9222_cdFunctionCode) = False Then D9222.cdFunctionCode = Trim$(rs9222!K9222_cdFunctionCode)
            If IsdbNull(rs9222!K9222_Description) = False Then D9222.Description = Trim$(rs9222!K9222_Description)
            If IsdbNull(rs9222!K9222_seInchargeCustomer) = False Then D9222.seInchargeCustomer = Trim$(rs9222!K9222_seInchargeCustomer)
            If IsdbNull(rs9222!K9222_cdInchargeCustomer) = False Then D9222.cdInchargeCustomer = Trim$(rs9222!K9222_cdInchargeCustomer)
            If IsdbNull(rs9222!K9222_seInchargePSM) = False Then D9222.seInchargePSM = Trim$(rs9222!K9222_seInchargePSM)
            If IsdbNull(rs9222!K9222_cdInchargePSM) = False Then D9222.cdInchargePSM = Trim$(rs9222!K9222_cdInchargePSM)
            If IsdbNull(rs9222!K9222_seInchargePSMSP) = False Then D9222.seInchargePSMSP = Trim$(rs9222!K9222_seInchargePSMSP)
            If IsdbNull(rs9222!K9222_cdInchargePSMSP) = False Then D9222.cdInchargePSMSP = Trim$(rs9222!K9222_cdInchargePSMSP)
            If IsdbNull(rs9222!K9222_DateTimeStart) = False Then D9222.DateTimeStart = Trim$(rs9222!K9222_DateTimeStart)
            If IsdbNull(rs9222!K9222_DateTimeFinish) = False Then D9222.DateTimeFinish = Trim$(rs9222!K9222_DateTimeFinish)
            If IsdbNull(rs9222!K9222_DateTimeDeadline) = False Then D9222.DateTimeDeadline = Trim$(rs9222!K9222_DateTimeDeadline)
            If IsdbNull(rs9222!K9222_CheckPlan) = False Then D9222.CheckPlan = Trim$(rs9222!K9222_CheckPlan)
            If IsdbNull(rs9222!K9222_CheckResult) = False Then D9222.CheckResult = Trim$(rs9222!K9222_CheckResult)
            If IsdbNull(rs9222!K9222_CheckComplete) = False Then D9222.CheckComplete = Trim$(rs9222!K9222_CheckComplete)
            If IsdbNull(rs9222!K9222_Remark) = False Then D9222.Remark = Trim$(rs9222!K9222_Remark)
            If IsdbNull(rs9222!K9222_ComputerName) = False Then D9222.ComputerName = Trim$(rs9222!K9222_ComputerName)
            If IsdbNull(rs9222!K9222_AccountWin) = False Then D9222.AccountWin = Trim$(rs9222!K9222_AccountWin)
            If IsdbNull(rs9222!K9222_UserCode) = False Then D9222.UserCode = Trim$(rs9222!K9222_UserCode)
            If IsdbNull(rs9222!K9222_IPWan) = False Then D9222.IPWan = Trim$(rs9222!K9222_IPWan)
            If IsdbNull(rs9222!K9222_MACAddress) = False Then D9222.MACAddress = Trim$(rs9222!K9222_MACAddress)
            If IsdbNull(rs9222!K9222_HDDSerialNo) = False Then D9222.HDDSerialNo = Trim$(rs9222!K9222_HDDSerialNo)
            If IsdbNull(rs9222!K9222_DeviceName) = False Then D9222.DeviceName = Trim$(rs9222!K9222_DeviceName)
            If IsdbNull(rs9222!K9222_Active) = False Then D9222.Active = Trim$(rs9222!K9222_Active)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K9222_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K9222_MOVE(rs9222 As DataRow)
        Try

            Call D9222_CLEAR()

            If IsdbNull(rs9222!K9222_Autokey) = False Then D9222.Autokey = Trim$(rs9222!K9222_Autokey)
            If IsdbNull(rs9222!K9222_Dseq) = False Then D9222.Dseq = Trim$(rs9222!K9222_Dseq)
            If IsdbNull(rs9222!K9222_Content) = False Then D9222.Content = Trim$(rs9222!K9222_Content)
            If IsdbNull(rs9222!K9222_DatePlan) = False Then D9222.DatePlan = Trim$(rs9222!K9222_DatePlan)
            If IsdbNull(rs9222!K9222_InchargePlan) = False Then D9222.InchargePlan = Trim$(rs9222!K9222_InchargePlan)
            If IsdbNull(rs9222!K9222_seUrgentCode) = False Then D9222.seUrgentCode = Trim$(rs9222!K9222_seUrgentCode)
            If IsdbNull(rs9222!K9222_cdUrgentCode) = False Then D9222.cdUrgentCode = Trim$(rs9222!K9222_cdUrgentCode)
            If IsdbNull(rs9222!K9222_seImportantCode) = False Then D9222.seImportantCode = Trim$(rs9222!K9222_seImportantCode)
            If IsdbNull(rs9222!K9222_cdImportantCode) = False Then D9222.cdImportantCode = Trim$(rs9222!K9222_cdImportantCode)
            If IsDBNull(rs9222!K9222_seProjectCode) = False Then D9222.seProjectCode = Trim$(rs9222!K9222_seProjectCode)
            If IsdbNull(rs9222!K9222_cdProjectCode) = False Then D9222.cdProjectCode = Trim$(rs9222!K9222_cdProjectCode)
            If IsdbNull(rs9222!K9222_seModuleCode) = False Then D9222.seModuleCode = Trim$(rs9222!K9222_seModuleCode)
            If IsdbNull(rs9222!K9222_cdModuleCode) = False Then D9222.cdModuleCode = Trim$(rs9222!K9222_cdModuleCode)
            If IsdbNull(rs9222!K9222_seFunctionCode) = False Then D9222.seFunctionCode = Trim$(rs9222!K9222_seFunctionCode)
            If IsdbNull(rs9222!K9222_cdFunctionCode) = False Then D9222.cdFunctionCode = Trim$(rs9222!K9222_cdFunctionCode)
            If IsdbNull(rs9222!K9222_Description) = False Then D9222.Description = Trim$(rs9222!K9222_Description)
            If IsdbNull(rs9222!K9222_seInchargeCustomer) = False Then D9222.seInchargeCustomer = Trim$(rs9222!K9222_seInchargeCustomer)
            If IsdbNull(rs9222!K9222_cdInchargeCustomer) = False Then D9222.cdInchargeCustomer = Trim$(rs9222!K9222_cdInchargeCustomer)
            If IsdbNull(rs9222!K9222_seInchargePSM) = False Then D9222.seInchargePSM = Trim$(rs9222!K9222_seInchargePSM)
            If IsdbNull(rs9222!K9222_cdInchargePSM) = False Then D9222.cdInchargePSM = Trim$(rs9222!K9222_cdInchargePSM)
            If IsdbNull(rs9222!K9222_seInchargePSMSP) = False Then D9222.seInchargePSMSP = Trim$(rs9222!K9222_seInchargePSMSP)
            If IsdbNull(rs9222!K9222_cdInchargePSMSP) = False Then D9222.cdInchargePSMSP = Trim$(rs9222!K9222_cdInchargePSMSP)
            If IsdbNull(rs9222!K9222_DateTimeStart) = False Then D9222.DateTimeStart = Trim$(rs9222!K9222_DateTimeStart)
            If IsdbNull(rs9222!K9222_DateTimeFinish) = False Then D9222.DateTimeFinish = Trim$(rs9222!K9222_DateTimeFinish)
            If IsdbNull(rs9222!K9222_DateTimeDeadline) = False Then D9222.DateTimeDeadline = Trim$(rs9222!K9222_DateTimeDeadline)
            If IsdbNull(rs9222!K9222_CheckPlan) = False Then D9222.CheckPlan = Trim$(rs9222!K9222_CheckPlan)
            If IsdbNull(rs9222!K9222_CheckResult) = False Then D9222.CheckResult = Trim$(rs9222!K9222_CheckResult)
            If IsdbNull(rs9222!K9222_CheckComplete) = False Then D9222.CheckComplete = Trim$(rs9222!K9222_CheckComplete)
            If IsdbNull(rs9222!K9222_Remark) = False Then D9222.Remark = Trim$(rs9222!K9222_Remark)
            If IsdbNull(rs9222!K9222_ComputerName) = False Then D9222.ComputerName = Trim$(rs9222!K9222_ComputerName)
            If IsdbNull(rs9222!K9222_AccountWin) = False Then D9222.AccountWin = Trim$(rs9222!K9222_AccountWin)
            If IsdbNull(rs9222!K9222_UserCode) = False Then D9222.UserCode = Trim$(rs9222!K9222_UserCode)
            If IsdbNull(rs9222!K9222_IPWan) = False Then D9222.IPWan = Trim$(rs9222!K9222_IPWan)
            If IsdbNull(rs9222!K9222_MACAddress) = False Then D9222.MACAddress = Trim$(rs9222!K9222_MACAddress)
            If IsdbNull(rs9222!K9222_HDDSerialNo) = False Then D9222.HDDSerialNo = Trim$(rs9222!K9222_HDDSerialNo)
            If IsdbNull(rs9222!K9222_DeviceName) = False Then D9222.DeviceName = Trim$(rs9222!K9222_DeviceName)
            If IsdbNull(rs9222!K9222_Active) = False Then D9222.Active = Trim$(rs9222!K9222_Active)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K9222_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K9222_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z9222 As T9222_AREA, AUTOKEY As Double) As Boolean

        K9222_MOVE = False

        Try
            If READ_PFK9222(AUTOKEY) = True Then
                z9222 = D9222
                K9222_MOVE = True
            Else
                z9222 = Nothing
            End If

            If getColumIndex(spr, "Autokey") > -1 Then z9222.Autokey = getDataM(spr, getColumIndex(spr, "Autokey"), xRow)
            If getColumIndex(spr, "Dseq") > -1 Then z9222.Dseq = getDataM(spr, getColumIndex(spr, "Dseq"), xRow)
            If getColumIndex(spr, "Content") > -1 Then z9222.Content = getDataM(spr, getColumIndex(spr, "Content"), xRow)
            If getColumIndex(spr, "DatePlan") > -1 Then z9222.DatePlan = getDataM(spr, getColumIndex(spr, "DatePlan"), xRow)
            If getColumIndex(spr, "InchargePlan") > -1 Then z9222.InchargePlan = getDataM(spr, getColumIndex(spr, "InchargePlan"), xRow)
            If getColumIndex(spr, "seUrgentCode") > -1 Then z9222.seUrgentCode = getDataM(spr, getColumIndex(spr, "seUrgentCode"), xRow)
            If getColumIndex(spr, "cdUrgentCode") > -1 Then z9222.cdUrgentCode = getDataM(spr, getColumIndex(spr, "cdUrgentCode"), xRow)
            If getColumIndex(spr, "seImportantCode") > -1 Then z9222.seImportantCode = getDataM(spr, getColumIndex(spr, "seImportantCode"), xRow)
            If getColumIndex(spr, "cdImportantCode") > -1 Then z9222.cdImportantCode = getDataM(spr, getColumIndex(spr, "cdImportantCode"), xRow)
            If getColumIndex(spr, "seProjectCode") > -1 Then z9222.seProjectCode = getDataM(spr, getColumIndex(spr, "seProjectCode"), xRow)
            If getColumIndex(spr, "cdProjectCode") > -1 Then z9222.cdProjectCode = getDataM(spr, getColumIndex(spr, "cdProjectCode"), xRow)
            If getColumIndex(spr, "seModuleCode") > -1 Then z9222.seModuleCode = getDataM(spr, getColumIndex(spr, "seModuleCode"), xRow)
            If getColumIndex(spr, "cdModuleCode") > -1 Then z9222.cdModuleCode = getDataM(spr, getColumIndex(spr, "cdModuleCode"), xRow)
            If getColumIndex(spr, "seFunctionCode") > -1 Then z9222.seFunctionCode = getDataM(spr, getColumIndex(spr, "seFunctionCode"), xRow)
            If getColumIndex(spr, "cdFunctionCode") > -1 Then z9222.cdFunctionCode = getDataM(spr, getColumIndex(spr, "cdFunctionCode"), xRow)
            If getColumIndex(spr, "Description") > -1 Then z9222.Description = getDataM(spr, getColumIndex(spr, "Description"), xRow)
            If getColumIndex(spr, "seInchargeCustomer") > -1 Then z9222.seInchargeCustomer = getDataM(spr, getColumIndex(spr, "seInchargeCustomer"), xRow)
            If getColumIndex(spr, "cdInchargeCustomer") > -1 Then z9222.cdInchargeCustomer = getDataM(spr, getColumIndex(spr, "cdInchargeCustomer"), xRow)
            If getColumIndex(spr, "seInchargePSM") > -1 Then z9222.seInchargePSM = getDataM(spr, getColumIndex(spr, "seInchargePSM"), xRow)
            If getColumIndex(spr, "cdInchargePSM") > -1 Then z9222.cdInchargePSM = getDataM(spr, getColumIndex(spr, "cdInchargePSM"), xRow)
            If getColumIndex(spr, "seInchargePSMSP") > -1 Then z9222.seInchargePSMSP = getDataM(spr, getColumIndex(spr, "seInchargePSMSP"), xRow)
            If getColumIndex(spr, "cdInchargePSMSP") > -1 Then z9222.cdInchargePSMSP = getDataM(spr, getColumIndex(spr, "cdInchargePSMSP"), xRow)
            If getColumIndex(spr, "DateTimeStart") > -1 Then z9222.DateTimeStart = getDataM(spr, getColumIndex(spr, "DateTimeStart"), xRow)
            If getColumIndex(spr, "DateTimeFinish") > -1 Then z9222.DateTimeFinish = getDataM(spr, getColumIndex(spr, "DateTimeFinish"), xRow)
            If getColumIndex(spr, "DateTimeDeadline") > -1 Then z9222.DateTimeDeadline = getDataM(spr, getColumIndex(spr, "DateTimeDeadline"), xRow)
            If getColumIndex(spr, "CheckPlan") > -1 Then z9222.CheckPlan = getDataM(spr, getColumIndex(spr, "CheckPlan"), xRow)
            If getColumIndex(spr, "CheckResult") > -1 Then z9222.CheckResult = getDataM(spr, getColumIndex(spr, "CheckResult"), xRow)
            If getColumIndex(spr, "CheckComplete") > -1 Then z9222.CheckComplete = getDataM(spr, getColumIndex(spr, "CheckComplete"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z9222.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)
            If getColumIndex(spr, "ComputerName") > -1 Then z9222.ComputerName = getDataM(spr, getColumIndex(spr, "ComputerName"), xRow)
            If getColumIndex(spr, "AccountWin") > -1 Then z9222.AccountWin = getDataM(spr, getColumIndex(spr, "AccountWin"), xRow)
            If getColumIndex(spr, "UserCode") > -1 Then z9222.UserCode = getDataM(spr, getColumIndex(spr, "UserCode"), xRow)
            If getColumIndex(spr, "IPWan") > -1 Then z9222.IPWan = getDataM(spr, getColumIndex(spr, "IPWan"), xRow)
            If getColumIndex(spr, "MACAddress") > -1 Then z9222.MACAddress = getDataM(spr, getColumIndex(spr, "MACAddress"), xRow)
            If getColumIndex(spr, "HDDSerialNo") > -1 Then z9222.HDDSerialNo = getDataM(spr, getColumIndex(spr, "HDDSerialNo"), xRow)
            If getColumIndex(spr, "DeviceName") > -1 Then z9222.DeviceName = getDataM(spr, getColumIndex(spr, "DeviceName"), xRow)
            If getColumIndex(spr, "Active") > -1 Then z9222.Active = getDataM(spr, getColumIndex(spr, "Active"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K9222_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K9222_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z9222 As T9222_AREA, CheckClear As Boolean, AUTOKEY As Double) As Boolean

        K9222_MOVE = False

        Try
            If READ_PFK9222(AUTOKEY) = True Then
                z9222 = D9222
                K9222_MOVE = True
            Else
                If CheckClear = True Then z9222 = Nothing
            End If

            If getColumIndex(spr, "Autokey") > -1 Then z9222.Autokey = getDataM(spr, getColumIndex(spr, "Autokey"), xRow)
            If getColumIndex(spr, "Dseq") > -1 Then z9222.Dseq = getDataM(spr, getColumIndex(spr, "Dseq"), xRow)
            If getColumIndex(spr, "Content") > -1 Then z9222.Content = getDataM(spr, getColumIndex(spr, "Content"), xRow)
            If getColumIndex(spr, "DatePlan") > -1 Then z9222.DatePlan = getDataM(spr, getColumIndex(spr, "DatePlan"), xRow)
            If getColumIndex(spr, "InchargePlan") > -1 Then z9222.InchargePlan = getDataM(spr, getColumIndex(spr, "InchargePlan"), xRow)
            If getColumIndex(spr, "seUrgentCode") > -1 Then z9222.seUrgentCode = getDataM(spr, getColumIndex(spr, "seUrgentCode"), xRow)
            If getColumIndex(spr, "cdUrgentCode") > -1 Then z9222.cdUrgentCode = getDataM(spr, getColumIndex(spr, "cdUrgentCode"), xRow)
            If getColumIndex(spr, "seImportantCode") > -1 Then z9222.seImportantCode = getDataM(spr, getColumIndex(spr, "seImportantCode"), xRow)
            If getColumIndex(spr, "cdImportantCode") > -1 Then z9222.cdImportantCode = getDataM(spr, getColumIndex(spr, "cdImportantCode"), xRow)
            If getColumIndex(spr, "seProjectCode") > -1 Then z9222.seProjectCode = getDataM(spr, getColumIndex(spr, "seProjectCode"), xRow)
            If getColumIndex(spr, "cdProjectCode") > -1 Then z9222.cdProjectCode = getDataM(spr, getColumIndex(spr, "cdProjectCode"), xRow)
            If getColumIndex(spr, "seModuleCode") > -1 Then z9222.seModuleCode = getDataM(spr, getColumIndex(spr, "seModuleCode"), xRow)
            If getColumIndex(spr, "cdModuleCode") > -1 Then z9222.cdModuleCode = getDataM(spr, getColumIndex(spr, "cdModuleCode"), xRow)
            If getColumIndex(spr, "seFunctionCode") > -1 Then z9222.seFunctionCode = getDataM(spr, getColumIndex(spr, "seFunctionCode"), xRow)
            If getColumIndex(spr, "cdFunctionCode") > -1 Then z9222.cdFunctionCode = getDataM(spr, getColumIndex(spr, "cdFunctionCode"), xRow)
            If getColumIndex(spr, "Description") > -1 Then z9222.Description = getDataM(spr, getColumIndex(spr, "Description"), xRow)
            If getColumIndex(spr, "seInchargeCustomer") > -1 Then z9222.seInchargeCustomer = getDataM(spr, getColumIndex(spr, "seInchargeCustomer"), xRow)
            If getColumIndex(spr, "cdInchargeCustomer") > -1 Then z9222.cdInchargeCustomer = getDataM(spr, getColumIndex(spr, "cdInchargeCustomer"), xRow)
            If getColumIndex(spr, "seInchargePSM") > -1 Then z9222.seInchargePSM = getDataM(spr, getColumIndex(spr, "seInchargePSM"), xRow)
            If getColumIndex(spr, "cdInchargePSM") > -1 Then z9222.cdInchargePSM = getDataM(spr, getColumIndex(spr, "cdInchargePSM"), xRow)
            If getColumIndex(spr, "seInchargePSMSP") > -1 Then z9222.seInchargePSMSP = getDataM(spr, getColumIndex(spr, "seInchargePSMSP"), xRow)
            If getColumIndex(spr, "cdInchargePSMSP") > -1 Then z9222.cdInchargePSMSP = getDataM(spr, getColumIndex(spr, "cdInchargePSMSP"), xRow)
            If getColumIndex(spr, "DateTimeStart") > -1 Then z9222.DateTimeStart = getDataM(spr, getColumIndex(spr, "DateTimeStart"), xRow)
            If getColumIndex(spr, "DateTimeFinish") > -1 Then z9222.DateTimeFinish = getDataM(spr, getColumIndex(spr, "DateTimeFinish"), xRow)
            If getColumIndex(spr, "DateTimeDeadline") > -1 Then z9222.DateTimeDeadline = getDataM(spr, getColumIndex(spr, "DateTimeDeadline"), xRow)
            If getColumIndex(spr, "CheckPlan") > -1 Then z9222.CheckPlan = getDataM(spr, getColumIndex(spr, "CheckPlan"), xRow)
            If getColumIndex(spr, "CheckResult") > -1 Then z9222.CheckResult = getDataM(spr, getColumIndex(spr, "CheckResult"), xRow)
            If getColumIndex(spr, "CheckComplete") > -1 Then z9222.CheckComplete = getDataM(spr, getColumIndex(spr, "CheckComplete"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z9222.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)
            If getColumIndex(spr, "ComputerName") > -1 Then z9222.ComputerName = getDataM(spr, getColumIndex(spr, "ComputerName"), xRow)
            If getColumIndex(spr, "AccountWin") > -1 Then z9222.AccountWin = getDataM(spr, getColumIndex(spr, "AccountWin"), xRow)
            If getColumIndex(spr, "UserCode") > -1 Then z9222.UserCode = getDataM(spr, getColumIndex(spr, "UserCode"), xRow)
            If getColumIndex(spr, "IPWan") > -1 Then z9222.IPWan = getDataM(spr, getColumIndex(spr, "IPWan"), xRow)
            If getColumIndex(spr, "MACAddress") > -1 Then z9222.MACAddress = getDataM(spr, getColumIndex(spr, "MACAddress"), xRow)
            If getColumIndex(spr, "HDDSerialNo") > -1 Then z9222.HDDSerialNo = getDataM(spr, getColumIndex(spr, "HDDSerialNo"), xRow)
            If getColumIndex(spr, "DeviceName") > -1 Then z9222.DeviceName = getDataM(spr, getColumIndex(spr, "DeviceName"), xRow)
            If getColumIndex(spr, "Active") > -1 Then z9222.Active = getDataM(spr, getColumIndex(spr, "Active"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K9222_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K9222_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z9222 As T9222_AREA, Job As String, AUTOKEY As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K9222_MOVE = False

        Try
            If READ_PFK9222(AUTOKEY) = True Then
                z9222 = D9222
                K9222_MOVE = True
            Else
                z9222 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK9222")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "AUTOKEY" : z9222.Autokey = Children(i).Code
                                Case "DSEQ" : z9222.Dseq = Children(i).Code
                                Case "CONTENT" : z9222.Content = Children(i).Code
                                Case "DATEPLAN" : z9222.DatePlan = Children(i).Code
                                Case "INCHARGEPLAN" : z9222.InchargePlan = Children(i).Code
                                Case "SEURGENTCODE" : z9222.seUrgentCode = Children(i).Code
                                Case "CDURGENTCODE" : z9222.cdUrgentCode = Children(i).Code
                                Case "SEIMPORTANTCODE" : z9222.seImportantCode = Children(i).Code
                                Case "CDIMPORTANTCODE" : z9222.cdImportantCode = Children(i).Code
                                Case "SEPROJECTCODE" : z9222.seProjectCode = Children(i).Code
                                Case "CDPROJECTCODE" : z9222.cdProjectCode = Children(i).Code
                                Case "SEMODULECODE" : z9222.seModuleCode = Children(i).Code
                                Case "CDMODULECODE" : z9222.cdModuleCode = Children(i).Code
                                Case "SEFUNCTIONCODE" : z9222.seFunctionCode = Children(i).Code
                                Case "CDFUNCTIONCODE" : z9222.cdFunctionCode = Children(i).Code
                                Case "DESCRIPTION" : z9222.Description = Children(i).Code
                                Case "SEINCHARGECUSTOMER" : z9222.seInchargeCustomer = Children(i).Code
                                Case "CDINCHARGECUSTOMER" : z9222.cdInchargeCustomer = Children(i).Code
                                Case "SEINCHARGEPSM" : z9222.seInchargePSM = Children(i).Code
                                Case "CDINCHARGEPSM" : z9222.cdInchargePSM = Children(i).Code
                                Case "SEINCHARGEPSMSP" : z9222.seInchargePSMSP = Children(i).Code
                                Case "CDINCHARGEPSMSP" : z9222.cdInchargePSMSP = Children(i).Code
                                Case "DATETIMESTART" : z9222.DateTimeStart = Children(i).Code
                                Case "DATETIMEFINISH" : z9222.DateTimeFinish = Children(i).Code
                                Case "DATETIMEDEADLINE" : z9222.DateTimeDeadline = Children(i).Code
                                Case "CHECKPLAN" : z9222.CheckPlan = Children(i).Code
                                Case "CHECKRESULT" : z9222.CheckResult = Children(i).Code
                                Case "CHECKCOMPLETE" : z9222.CheckComplete = Children(i).Code
                                Case "REMARK" : z9222.Remark = Children(i).Code
                                Case "COMPUTERNAME" : z9222.ComputerName = Children(i).Code
                                Case "ACCOUNTWIN" : z9222.AccountWin = Children(i).Code
                                Case "USERCODE" : z9222.UserCode = Children(i).Code
                                Case "IPWAN" : z9222.IPWan = Children(i).Code
                                Case "MACADDRESS" : z9222.MACAddress = Children(i).Code
                                Case "HDDSERIALNO" : z9222.HDDSerialNo = Children(i).Code
                                Case "DEVICENAME" : z9222.DeviceName = Children(i).Code
                                Case "ACTIVE" : z9222.Active = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "AUTOKEY" : z9222.Autokey = Children(i).Data
                                Case "DSEQ" : z9222.Dseq = Children(i).Data
                                Case "CONTENT" : z9222.Content = Children(i).Data
                                Case "DATEPLAN" : z9222.DatePlan = Children(i).Data
                                Case "INCHARGEPLAN" : z9222.InchargePlan = Children(i).Data
                                Case "SEURGENTCODE" : z9222.seUrgentCode = Children(i).Data
                                Case "CDURGENTCODE" : z9222.cdUrgentCode = Children(i).Data
                                Case "SEIMPORTANTCODE" : z9222.seImportantCode = Children(i).Data
                                Case "CDIMPORTANTCODE" : z9222.cdImportantCode = Children(i).Data
                                Case "SEPROJECTCODE" : z9222.seProjectCode = Children(i).Data
                                Case "CDPROJECTCODE" : z9222.cdProjectCode = Children(i).Data
                                Case "SEMODULECODE" : z9222.seModuleCode = Children(i).Data
                                Case "CDMODULECODE" : z9222.cdModuleCode = Children(i).Data
                                Case "SEFUNCTIONCODE" : z9222.seFunctionCode = Children(i).Data
                                Case "CDFUNCTIONCODE" : z9222.cdFunctionCode = Children(i).Data
                                Case "DESCRIPTION" : z9222.Description = Children(i).Data
                                Case "SEINCHARGECUSTOMER" : z9222.seInchargeCustomer = Children(i).Data
                                Case "CDINCHARGECUSTOMER" : z9222.cdInchargeCustomer = Children(i).Data
                                Case "SEINCHARGEPSM" : z9222.seInchargePSM = Children(i).Data
                                Case "CDINCHARGEPSM" : z9222.cdInchargePSM = Children(i).Data
                                Case "SEINCHARGEPSMSP" : z9222.seInchargePSMSP = Children(i).Data
                                Case "CDINCHARGEPSMSP" : z9222.cdInchargePSMSP = Children(i).Data
                                Case "DATETIMESTART" : z9222.DateTimeStart = Children(i).Data
                                Case "DATETIMEFINISH" : z9222.DateTimeFinish = Children(i).Data
                                Case "DATETIMEDEADLINE" : z9222.DateTimeDeadline = Children(i).Data
                                Case "CHECKPLAN" : z9222.CheckPlan = Children(i).Data
                                Case "CHECKRESULT" : z9222.CheckResult = Children(i).Data
                                Case "CHECKCOMPLETE" : z9222.CheckComplete = Children(i).Data
                                Case "REMARK" : z9222.Remark = Children(i).Data
                                Case "COMPUTERNAME" : z9222.ComputerName = Children(i).Data
                                Case "ACCOUNTWIN" : z9222.AccountWin = Children(i).Data
                                Case "USERCODE" : z9222.UserCode = Children(i).Data
                                Case "IPWAN" : z9222.IPWan = Children(i).Data
                                Case "MACADDRESS" : z9222.MACAddress = Children(i).Data
                                Case "HDDSERIALNO" : z9222.HDDSerialNo = Children(i).Data
                                Case "DEVICENAME" : z9222.DeviceName = Children(i).Data
                                Case "ACTIVE" : z9222.Active = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K9222_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K9222_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z9222 As T9222_AREA, Job As String, CheckClear As Boolean, AUTOKEY As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K9222_MOVE = False

        Try
            If READ_PFK9222(AUTOKEY) = True Then
                z9222 = D9222
                K9222_MOVE = True
            Else
                If CheckClear = True Then z9222 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK9222")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "AUTOKEY" : z9222.Autokey = Children(i).Code
                                Case "DSEQ" : z9222.Dseq = Children(i).Code
                                Case "CONTENT" : z9222.Content = Children(i).Code
                                Case "DATEPLAN" : z9222.DatePlan = Children(i).Code
                                Case "INCHARGEPLAN" : z9222.InchargePlan = Children(i).Code
                                Case "SEURGENTCODE" : z9222.seUrgentCode = Children(i).Code
                                Case "CDURGENTCODE" : z9222.cdUrgentCode = Children(i).Code
                                Case "SEIMPORTANTCODE" : z9222.seImportantCode = Children(i).Code
                                Case "CDIMPORTANTCODE" : z9222.cdImportantCode = Children(i).Code
                                Case "SEPROJECTCODE" : z9222.seProjectCode = Children(i).Code
                                Case "CDPROJECTCODE" : z9222.cdProjectCode = Children(i).Code
                                Case "SEMODULECODE" : z9222.seModuleCode = Children(i).Code
                                Case "CDMODULECODE" : z9222.cdModuleCode = Children(i).Code
                                Case "SEFUNCTIONCODE" : z9222.seFunctionCode = Children(i).Code
                                Case "CDFUNCTIONCODE" : z9222.cdFunctionCode = Children(i).Code
                                Case "DESCRIPTION" : z9222.Description = Children(i).Code
                                Case "SEINCHARGECUSTOMER" : z9222.seInchargeCustomer = Children(i).Code
                                Case "CDINCHARGECUSTOMER" : z9222.cdInchargeCustomer = Children(i).Code
                                Case "SEINCHARGEPSM" : z9222.seInchargePSM = Children(i).Code
                                Case "CDINCHARGEPSM" : z9222.cdInchargePSM = Children(i).Code
                                Case "SEINCHARGEPSMSP" : z9222.seInchargePSMSP = Children(i).Code
                                Case "CDINCHARGEPSMSP" : z9222.cdInchargePSMSP = Children(i).Code
                                Case "DATETIMESTART" : z9222.DateTimeStart = Children(i).Code
                                Case "DATETIMEFINISH" : z9222.DateTimeFinish = Children(i).Code
                                Case "DATETIMEDEADLINE" : z9222.DateTimeDeadline = Children(i).Code
                                Case "CHECKPLAN" : z9222.CheckPlan = Children(i).Code
                                Case "CHECKRESULT" : z9222.CheckResult = Children(i).Code
                                Case "CHECKCOMPLETE" : z9222.CheckComplete = Children(i).Code
                                Case "REMARK" : z9222.Remark = Children(i).Code
                                Case "COMPUTERNAME" : z9222.ComputerName = Children(i).Code
                                Case "ACCOUNTWIN" : z9222.AccountWin = Children(i).Code
                                Case "USERCODE" : z9222.UserCode = Children(i).Code
                                Case "IPWAN" : z9222.IPWan = Children(i).Code
                                Case "MACADDRESS" : z9222.MACAddress = Children(i).Code
                                Case "HDDSERIALNO" : z9222.HDDSerialNo = Children(i).Code
                                Case "DEVICENAME" : z9222.DeviceName = Children(i).Code
                                Case "ACTIVE" : z9222.Active = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "AUTOKEY" : z9222.Autokey = Children(i).Data
                                Case "DSEQ" : z9222.Dseq = Children(i).Data
                                Case "CONTENT" : z9222.Content = Children(i).Data
                                Case "DATEPLAN" : z9222.DatePlan = Children(i).Data
                                Case "INCHARGEPLAN" : z9222.InchargePlan = Children(i).Data
                                Case "SEURGENTCODE" : z9222.seUrgentCode = Children(i).Data
                                Case "CDURGENTCODE" : z9222.cdUrgentCode = Children(i).Data
                                Case "SEIMPORTANTCODE" : z9222.seImportantCode = Children(i).Data
                                Case "CDIMPORTANTCODE" : z9222.cdImportantCode = Children(i).Data
                                Case "SEPROJECTCODE" : z9222.seProjectCode = Children(i).Data
                                Case "CDPROJECTCODE" : z9222.cdProjectCode = Children(i).Data
                                Case "SEMODULECODE" : z9222.seModuleCode = Children(i).Data
                                Case "CDMODULECODE" : z9222.cdModuleCode = Children(i).Data
                                Case "SEFUNCTIONCODE" : z9222.seFunctionCode = Children(i).Data
                                Case "CDFUNCTIONCODE" : z9222.cdFunctionCode = Children(i).Data
                                Case "DESCRIPTION" : z9222.Description = Children(i).Data
                                Case "SEINCHARGECUSTOMER" : z9222.seInchargeCustomer = Children(i).Data
                                Case "CDINCHARGECUSTOMER" : z9222.cdInchargeCustomer = Children(i).Data
                                Case "SEINCHARGEPSM" : z9222.seInchargePSM = Children(i).Data
                                Case "CDINCHARGEPSM" : z9222.cdInchargePSM = Children(i).Data
                                Case "SEINCHARGEPSMSP" : z9222.seInchargePSMSP = Children(i).Data
                                Case "CDINCHARGEPSMSP" : z9222.cdInchargePSMSP = Children(i).Data
                                Case "DATETIMESTART" : z9222.DateTimeStart = Children(i).Data
                                Case "DATETIMEFINISH" : z9222.DateTimeFinish = Children(i).Data
                                Case "DATETIMEDEADLINE" : z9222.DateTimeDeadline = Children(i).Data
                                Case "CHECKPLAN" : z9222.CheckPlan = Children(i).Data
                                Case "CHECKRESULT" : z9222.CheckResult = Children(i).Data
                                Case "CHECKCOMPLETE" : z9222.CheckComplete = Children(i).Data
                                Case "REMARK" : z9222.Remark = Children(i).Data
                                Case "COMPUTERNAME" : z9222.ComputerName = Children(i).Data
                                Case "ACCOUNTWIN" : z9222.AccountWin = Children(i).Data
                                Case "USERCODE" : z9222.UserCode = Children(i).Data
                                Case "IPWAN" : z9222.IPWan = Children(i).Data
                                Case "MACADDRESS" : z9222.MACAddress = Children(i).Data
                                Case "HDDSERIALNO" : z9222.HDDSerialNo = Children(i).Data
                                Case "DEVICENAME" : z9222.DeviceName = Children(i).Data
                                Case "ACTIVE" : z9222.Active = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K9222_MOVE", vbCritical)
        End Try
    End Function

End Module
