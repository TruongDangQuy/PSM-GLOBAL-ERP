'=========================================================================================================================================================
'   TABLE : (PFK4070)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K4070

Structure T4070_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	cdFactory	 AS String	'			char(3)		*
Public 	cdMainProcess	 AS String	'			char(3)		*
Public 	MachineCode	 AS String	'			char(6)		*
Public 	MachineTno	 AS String	'			char(2)		*
Public 	seMainProcess	 AS String	'			char(3)
Public 	seFactory	 AS String	'			char(3)
Public 	JobCard	 AS String	'			char(9)
Public 	WorkOrder	 AS String	'			char(9)
Public 	WorkOrderSeq	 AS String	'			char(3)
Public 	DatePlan	 AS String	'			char(8)
Public 	DateStart	 AS String	'			char(8)
Public 	DateFinish	 AS String	'			char(8)
Public 	DateProduction	 AS String	'			char(8)
Public 	PartProduction	 AS String	'			char(1)
Public 	STimeProduction	 AS String	'			nvarchar(20)
Public 	ETimeProduction	 AS String	'			nvarchar(20)
Public 	InchargePlan	 AS String	'			char(8)
Public 	InchargeProdution	 AS String	'			char(8)
Public 	QtyPlan	 AS Double	'			decimal
Public 	QtyPlanBatch	 AS Double	'			decimal
Public 	QtyProd	 AS Double	'			decimal
Public 	QtyNormal	 AS Double	'			decimal
Public 	QtyDefect	 AS Double	'			decimal
Public 	QtyDefectPass	 AS Double	'			decimal
Public 	QtyDefectReject	 AS Double	'			decimal
Public 	CheckComplete	 AS String	'			char(1)
Public 	CheckTrigger	 AS String	'			nvarchar(10)
Public 	Remark	 AS String	'			nvarchar(200)
'=========================================================================================================================================================
End structure

Public D4070 As T4070_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK4070(CDFACTORY AS String, CDMAINPROCESS AS String, MACHINECODE AS String, MACHINETNO AS String) As Boolean
    READ_PFK4070 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK4070 "
    SQL = SQL & " WHERE K4070_cdFactory		 = '" & cdFactory & "' " 
    SQL = SQL & "   AND K4070_cdMainProcess		 = '" & cdMainProcess & "' " 
    SQL = SQL & "   AND K4070_MachineCode		 = '" & MachineCode & "' " 
    SQL = SQL & "   AND K4070_MachineTno		 = '" & MachineTno & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D4070_CLEAR: GoTo SKIP_READ_PFK4070
                
    Call K4070_MOVE(rd)
    READ_PFK4070 = True

SKIP_READ_PFK4070:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK4070",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK4070(CDFACTORY AS String, CDMAINPROCESS AS String, MACHINECODE AS String, MACHINETNO AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK4070 "
    SQL = SQL & " WHERE K4070_cdFactory		 = '" & cdFactory & "' " 
    SQL = SQL & "   AND K4070_cdMainProcess		 = '" & cdMainProcess & "' " 
    SQL = SQL & "   AND K4070_MachineCode		 = '" & MachineCode & "' " 
    SQL = SQL & "   AND K4070_MachineTno		 = '" & MachineTno & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK4070",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK4070(z4070 As T4070_AREA) As Boolean
    WRITE_PFK4070 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z4070)
 
    SQL = " INSERT INTO PFK4070 "
    SQL = SQL & " ( "
    SQL = SQL & " K4070_cdFactory," 
    SQL = SQL & " K4070_cdMainProcess," 
    SQL = SQL & " K4070_MachineCode," 
    SQL = SQL & " K4070_MachineTno," 
    SQL = SQL & " K4070_seMainProcess," 
    SQL = SQL & " K4070_seFactory," 
    SQL = SQL & " K4070_JobCard," 
    SQL = SQL & " K4070_WorkOrder," 
    SQL = SQL & " K4070_WorkOrderSeq," 
    SQL = SQL & " K4070_DatePlan," 
    SQL = SQL & " K4070_DateStart," 
    SQL = SQL & " K4070_DateFinish," 
    SQL = SQL & " K4070_DateProduction," 
    SQL = SQL & " K4070_PartProduction," 
    SQL = SQL & " K4070_STimeProduction," 
    SQL = SQL & " K4070_ETimeProduction," 
    SQL = SQL & " K4070_InchargePlan," 
    SQL = SQL & " K4070_InchargeProdution," 
    SQL = SQL & " K4070_QtyPlan," 
    SQL = SQL & " K4070_QtyPlanBatch," 
    SQL = SQL & " K4070_QtyProd," 
    SQL = SQL & " K4070_QtyNormal," 
    SQL = SQL & " K4070_QtyDefect," 
    SQL = SQL & " K4070_QtyDefectPass," 
    SQL = SQL & " K4070_QtyDefectReject," 
    SQL = SQL & " K4070_CheckComplete," 
    SQL = SQL & " K4070_CheckTrigger," 
    SQL = SQL & " K4070_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z4070.cdFactory) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4070.cdMainProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4070.MachineCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4070.MachineTno) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4070.seMainProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4070.seFactory) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4070.JobCard) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4070.WorkOrder) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4070.WorkOrderSeq) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4070.DatePlan) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4070.DateStart) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4070.DateFinish) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4070.DateProduction) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4070.PartProduction) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4070.STimeProduction) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4070.ETimeProduction) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4070.InchargePlan) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4070.InchargeProdution) & "', "  
    SQL = SQL & "   " & FormatSQL(z4070.QtyPlan) & ", "  
    SQL = SQL & "   " & FormatSQL(z4070.QtyPlanBatch) & ", "  
    SQL = SQL & "   " & FormatSQL(z4070.QtyProd) & ", "  
    SQL = SQL & "   " & FormatSQL(z4070.QtyNormal) & ", "  
    SQL = SQL & "   " & FormatSQL(z4070.QtyDefect) & ", "  
    SQL = SQL & "   " & FormatSQL(z4070.QtyDefectPass) & ", "  
    SQL = SQL & "   " & FormatSQL(z4070.QtyDefectReject) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z4070.CheckComplete) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4070.CheckTrigger) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4070.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK4070 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK4070",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK4070(z4070 As T4070_AREA) As Boolean
    REWRITE_PFK4070 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z4070)
   
    SQL = " UPDATE PFK4070 SET "
    SQL = SQL & "    K4070_seMainProcess      = N'" & FormatSQL(z4070.seMainProcess) & "', " 
    SQL = SQL & "    K4070_seFactory      = N'" & FormatSQL(z4070.seFactory) & "', " 
    SQL = SQL & "    K4070_JobCard      = N'" & FormatSQL(z4070.JobCard) & "', " 
    SQL = SQL & "    K4070_WorkOrder      = N'" & FormatSQL(z4070.WorkOrder) & "', " 
    SQL = SQL & "    K4070_WorkOrderSeq      = N'" & FormatSQL(z4070.WorkOrderSeq) & "', " 
    SQL = SQL & "    K4070_DatePlan      = N'" & FormatSQL(z4070.DatePlan) & "', " 
    SQL = SQL & "    K4070_DateStart      = N'" & FormatSQL(z4070.DateStart) & "', " 
    SQL = SQL & "    K4070_DateFinish      = N'" & FormatSQL(z4070.DateFinish) & "', " 
    SQL = SQL & "    K4070_DateProduction      = N'" & FormatSQL(z4070.DateProduction) & "', " 
    SQL = SQL & "    K4070_PartProduction      = N'" & FormatSQL(z4070.PartProduction) & "', " 
    SQL = SQL & "    K4070_STimeProduction      = N'" & FormatSQL(z4070.STimeProduction) & "', " 
    SQL = SQL & "    K4070_ETimeProduction      = N'" & FormatSQL(z4070.ETimeProduction) & "', " 
    SQL = SQL & "    K4070_InchargePlan      = N'" & FormatSQL(z4070.InchargePlan) & "', " 
    SQL = SQL & "    K4070_InchargeProdution      = N'" & FormatSQL(z4070.InchargeProdution) & "', " 
    SQL = SQL & "    K4070_QtyPlan      =  " & FormatSQL(z4070.QtyPlan) & ", " 
    SQL = SQL & "    K4070_QtyPlanBatch      =  " & FormatSQL(z4070.QtyPlanBatch) & ", " 
    SQL = SQL & "    K4070_QtyProd      =  " & FormatSQL(z4070.QtyProd) & ", " 
    SQL = SQL & "    K4070_QtyNormal      =  " & FormatSQL(z4070.QtyNormal) & ", " 
    SQL = SQL & "    K4070_QtyDefect      =  " & FormatSQL(z4070.QtyDefect) & ", " 
    SQL = SQL & "    K4070_QtyDefectPass      =  " & FormatSQL(z4070.QtyDefectPass) & ", " 
    SQL = SQL & "    K4070_QtyDefectReject      =  " & FormatSQL(z4070.QtyDefectReject) & ", " 
    SQL = SQL & "    K4070_CheckComplete      = N'" & FormatSQL(z4070.CheckComplete) & "', " 
    SQL = SQL & "    K4070_CheckTrigger      = N'" & FormatSQL(z4070.CheckTrigger) & "', " 
    SQL = SQL & "    K4070_Remark      = N'" & FormatSQL(z4070.Remark) & "'  " 
    SQL = SQL & " WHERE K4070_cdFactory		 = '" & z4070.cdFactory & "' " 
    SQL = SQL & "   AND K4070_cdMainProcess		 = '" & z4070.cdMainProcess & "' " 
    SQL = SQL & "   AND K4070_MachineCode		 = '" & z4070.MachineCode & "' " 
    SQL = SQL & "   AND K4070_MachineTno		 = '" & z4070.MachineTno & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK4070 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK4070",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK4070(z4070 As T4070_AREA) As Boolean
    DELETE_PFK4070 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK4070 "
    SQL = SQL & " WHERE K4070_cdFactory		 = '" & z4070.cdFactory & "' " 
    SQL = SQL & "   AND K4070_cdMainProcess		 = '" & z4070.cdMainProcess & "' " 
    SQL = SQL & "   AND K4070_MachineCode		 = '" & z4070.MachineCode & "' " 
    SQL = SQL & "   AND K4070_MachineTno		 = '" & z4070.MachineTno & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK4070 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK4070",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D4070_CLEAR()
Try
    
   D4070.cdFactory = ""
   D4070.cdMainProcess = ""
   D4070.MachineCode = ""
   D4070.MachineTno = ""
   D4070.seMainProcess = ""
   D4070.seFactory = ""
   D4070.JobCard = ""
   D4070.WorkOrder = ""
   D4070.WorkOrderSeq = ""
   D4070.DatePlan = ""
   D4070.DateStart = ""
   D4070.DateFinish = ""
   D4070.DateProduction = ""
   D4070.PartProduction = ""
   D4070.STimeProduction = ""
   D4070.ETimeProduction = ""
   D4070.InchargePlan = ""
   D4070.InchargeProdution = ""
    D4070.QtyPlan = 0 
    D4070.QtyPlanBatch = 0 
    D4070.QtyProd = 0 
    D4070.QtyNormal = 0 
    D4070.QtyDefect = 0 
    D4070.QtyDefectPass = 0 
    D4070.QtyDefectReject = 0 
   D4070.CheckComplete = ""
   D4070.CheckTrigger = ""
   D4070.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D4070_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x4070 As T4070_AREA)
Try
    
    x4070.cdFactory = trim$(  x4070.cdFactory)
    x4070.cdMainProcess = trim$(  x4070.cdMainProcess)
    x4070.MachineCode = trim$(  x4070.MachineCode)
    x4070.MachineTno = trim$(  x4070.MachineTno)
    x4070.seMainProcess = trim$(  x4070.seMainProcess)
    x4070.seFactory = trim$(  x4070.seFactory)
    x4070.JobCard = trim$(  x4070.JobCard)
    x4070.WorkOrder = trim$(  x4070.WorkOrder)
    x4070.WorkOrderSeq = trim$(  x4070.WorkOrderSeq)
    x4070.DatePlan = trim$(  x4070.DatePlan)
    x4070.DateStart = trim$(  x4070.DateStart)
    x4070.DateFinish = trim$(  x4070.DateFinish)
    x4070.DateProduction = trim$(  x4070.DateProduction)
    x4070.PartProduction = trim$(  x4070.PartProduction)
    x4070.STimeProduction = trim$(  x4070.STimeProduction)
    x4070.ETimeProduction = trim$(  x4070.ETimeProduction)
    x4070.InchargePlan = trim$(  x4070.InchargePlan)
    x4070.InchargeProdution = trim$(  x4070.InchargeProdution)
    x4070.QtyPlan = trim$(  x4070.QtyPlan)
    x4070.QtyPlanBatch = trim$(  x4070.QtyPlanBatch)
    x4070.QtyProd = trim$(  x4070.QtyProd)
    x4070.QtyNormal = trim$(  x4070.QtyNormal)
    x4070.QtyDefect = trim$(  x4070.QtyDefect)
    x4070.QtyDefectPass = trim$(  x4070.QtyDefectPass)
    x4070.QtyDefectReject = trim$(  x4070.QtyDefectReject)
    x4070.CheckComplete = trim$(  x4070.CheckComplete)
    x4070.CheckTrigger = trim$(  x4070.CheckTrigger)
    x4070.Remark = trim$(  x4070.Remark)
     
    If trim$( x4070.cdFactory ) = "" Then x4070.cdFactory = Space(1) 
    If trim$( x4070.cdMainProcess ) = "" Then x4070.cdMainProcess = Space(1) 
    If trim$( x4070.MachineCode ) = "" Then x4070.MachineCode = Space(1) 
    If trim$( x4070.MachineTno ) = "" Then x4070.MachineTno = Space(1) 
    If trim$( x4070.seMainProcess ) = "" Then x4070.seMainProcess = Space(1) 
    If trim$( x4070.seFactory ) = "" Then x4070.seFactory = Space(1) 
    If trim$( x4070.JobCard ) = "" Then x4070.JobCard = Space(1) 
    If trim$( x4070.WorkOrder ) = "" Then x4070.WorkOrder = Space(1) 
    If trim$( x4070.WorkOrderSeq ) = "" Then x4070.WorkOrderSeq = Space(1) 
    If trim$( x4070.DatePlan ) = "" Then x4070.DatePlan = Space(1) 
    If trim$( x4070.DateStart ) = "" Then x4070.DateStart = Space(1) 
    If trim$( x4070.DateFinish ) = "" Then x4070.DateFinish = Space(1) 
    If trim$( x4070.DateProduction ) = "" Then x4070.DateProduction = Space(1) 
    If trim$( x4070.PartProduction ) = "" Then x4070.PartProduction = Space(1) 
    If trim$( x4070.STimeProduction ) = "" Then x4070.STimeProduction = Space(1) 
    If trim$( x4070.ETimeProduction ) = "" Then x4070.ETimeProduction = Space(1) 
    If trim$( x4070.InchargePlan ) = "" Then x4070.InchargePlan = Space(1) 
    If trim$( x4070.InchargeProdution ) = "" Then x4070.InchargeProdution = Space(1) 
    If trim$( x4070.QtyPlan ) = "" Then x4070.QtyPlan = 0 
    If trim$( x4070.QtyPlanBatch ) = "" Then x4070.QtyPlanBatch = 0 
    If trim$( x4070.QtyProd ) = "" Then x4070.QtyProd = 0 
    If trim$( x4070.QtyNormal ) = "" Then x4070.QtyNormal = 0 
    If trim$( x4070.QtyDefect ) = "" Then x4070.QtyDefect = 0 
    If trim$( x4070.QtyDefectPass ) = "" Then x4070.QtyDefectPass = 0 
    If trim$( x4070.QtyDefectReject ) = "" Then x4070.QtyDefectReject = 0 
    If trim$( x4070.CheckComplete ) = "" Then x4070.CheckComplete = Space(1) 
    If trim$( x4070.CheckTrigger ) = "" Then x4070.CheckTrigger = Space(1) 
    If trim$( x4070.Remark ) = "" Then x4070.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K4070_MOVE(rs4070 As SqlClient.SqlDataReader)
Try

    call D4070_CLEAR()   

    If IsdbNull(rs4070!K4070_cdFactory) = False Then D4070.cdFactory = Trim$(rs4070!K4070_cdFactory)
    If IsdbNull(rs4070!K4070_cdMainProcess) = False Then D4070.cdMainProcess = Trim$(rs4070!K4070_cdMainProcess)
    If IsdbNull(rs4070!K4070_MachineCode) = False Then D4070.MachineCode = Trim$(rs4070!K4070_MachineCode)
    If IsdbNull(rs4070!K4070_MachineTno) = False Then D4070.MachineTno = Trim$(rs4070!K4070_MachineTno)
    If IsdbNull(rs4070!K4070_seMainProcess) = False Then D4070.seMainProcess = Trim$(rs4070!K4070_seMainProcess)
    If IsdbNull(rs4070!K4070_seFactory) = False Then D4070.seFactory = Trim$(rs4070!K4070_seFactory)
    If IsdbNull(rs4070!K4070_JobCard) = False Then D4070.JobCard = Trim$(rs4070!K4070_JobCard)
    If IsdbNull(rs4070!K4070_WorkOrder) = False Then D4070.WorkOrder = Trim$(rs4070!K4070_WorkOrder)
    If IsdbNull(rs4070!K4070_WorkOrderSeq) = False Then D4070.WorkOrderSeq = Trim$(rs4070!K4070_WorkOrderSeq)
    If IsdbNull(rs4070!K4070_DatePlan) = False Then D4070.DatePlan = Trim$(rs4070!K4070_DatePlan)
    If IsdbNull(rs4070!K4070_DateStart) = False Then D4070.DateStart = Trim$(rs4070!K4070_DateStart)
    If IsdbNull(rs4070!K4070_DateFinish) = False Then D4070.DateFinish = Trim$(rs4070!K4070_DateFinish)
    If IsdbNull(rs4070!K4070_DateProduction) = False Then D4070.DateProduction = Trim$(rs4070!K4070_DateProduction)
    If IsdbNull(rs4070!K4070_PartProduction) = False Then D4070.PartProduction = Trim$(rs4070!K4070_PartProduction)
    If IsdbNull(rs4070!K4070_STimeProduction) = False Then D4070.STimeProduction = Trim$(rs4070!K4070_STimeProduction)
    If IsdbNull(rs4070!K4070_ETimeProduction) = False Then D4070.ETimeProduction = Trim$(rs4070!K4070_ETimeProduction)
    If IsdbNull(rs4070!K4070_InchargePlan) = False Then D4070.InchargePlan = Trim$(rs4070!K4070_InchargePlan)
    If IsdbNull(rs4070!K4070_InchargeProdution) = False Then D4070.InchargeProdution = Trim$(rs4070!K4070_InchargeProdution)
    If IsdbNull(rs4070!K4070_QtyPlan) = False Then D4070.QtyPlan = Trim$(rs4070!K4070_QtyPlan)
    If IsdbNull(rs4070!K4070_QtyPlanBatch) = False Then D4070.QtyPlanBatch = Trim$(rs4070!K4070_QtyPlanBatch)
    If IsdbNull(rs4070!K4070_QtyProd) = False Then D4070.QtyProd = Trim$(rs4070!K4070_QtyProd)
    If IsdbNull(rs4070!K4070_QtyNormal) = False Then D4070.QtyNormal = Trim$(rs4070!K4070_QtyNormal)
    If IsdbNull(rs4070!K4070_QtyDefect) = False Then D4070.QtyDefect = Trim$(rs4070!K4070_QtyDefect)
    If IsdbNull(rs4070!K4070_QtyDefectPass) = False Then D4070.QtyDefectPass = Trim$(rs4070!K4070_QtyDefectPass)
    If IsdbNull(rs4070!K4070_QtyDefectReject) = False Then D4070.QtyDefectReject = Trim$(rs4070!K4070_QtyDefectReject)
    If IsdbNull(rs4070!K4070_CheckComplete) = False Then D4070.CheckComplete = Trim$(rs4070!K4070_CheckComplete)
    If IsdbNull(rs4070!K4070_CheckTrigger) = False Then D4070.CheckTrigger = Trim$(rs4070!K4070_CheckTrigger)
    If IsdbNull(rs4070!K4070_Remark) = False Then D4070.Remark = Trim$(rs4070!K4070_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K4070_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K4070_MOVE(rs4070 As DataRow)
Try

    call D4070_CLEAR()   

    If IsdbNull(rs4070!K4070_cdFactory) = False Then D4070.cdFactory = Trim$(rs4070!K4070_cdFactory)
    If IsdbNull(rs4070!K4070_cdMainProcess) = False Then D4070.cdMainProcess = Trim$(rs4070!K4070_cdMainProcess)
    If IsdbNull(rs4070!K4070_MachineCode) = False Then D4070.MachineCode = Trim$(rs4070!K4070_MachineCode)
    If IsdbNull(rs4070!K4070_MachineTno) = False Then D4070.MachineTno = Trim$(rs4070!K4070_MachineTno)
    If IsdbNull(rs4070!K4070_seMainProcess) = False Then D4070.seMainProcess = Trim$(rs4070!K4070_seMainProcess)
    If IsdbNull(rs4070!K4070_seFactory) = False Then D4070.seFactory = Trim$(rs4070!K4070_seFactory)
    If IsdbNull(rs4070!K4070_JobCard) = False Then D4070.JobCard = Trim$(rs4070!K4070_JobCard)
    If IsdbNull(rs4070!K4070_WorkOrder) = False Then D4070.WorkOrder = Trim$(rs4070!K4070_WorkOrder)
    If IsdbNull(rs4070!K4070_WorkOrderSeq) = False Then D4070.WorkOrderSeq = Trim$(rs4070!K4070_WorkOrderSeq)
    If IsdbNull(rs4070!K4070_DatePlan) = False Then D4070.DatePlan = Trim$(rs4070!K4070_DatePlan)
    If IsdbNull(rs4070!K4070_DateStart) = False Then D4070.DateStart = Trim$(rs4070!K4070_DateStart)
    If IsdbNull(rs4070!K4070_DateFinish) = False Then D4070.DateFinish = Trim$(rs4070!K4070_DateFinish)
    If IsdbNull(rs4070!K4070_DateProduction) = False Then D4070.DateProduction = Trim$(rs4070!K4070_DateProduction)
    If IsdbNull(rs4070!K4070_PartProduction) = False Then D4070.PartProduction = Trim$(rs4070!K4070_PartProduction)
    If IsdbNull(rs4070!K4070_STimeProduction) = False Then D4070.STimeProduction = Trim$(rs4070!K4070_STimeProduction)
    If IsdbNull(rs4070!K4070_ETimeProduction) = False Then D4070.ETimeProduction = Trim$(rs4070!K4070_ETimeProduction)
    If IsdbNull(rs4070!K4070_InchargePlan) = False Then D4070.InchargePlan = Trim$(rs4070!K4070_InchargePlan)
    If IsdbNull(rs4070!K4070_InchargeProdution) = False Then D4070.InchargeProdution = Trim$(rs4070!K4070_InchargeProdution)
    If IsdbNull(rs4070!K4070_QtyPlan) = False Then D4070.QtyPlan = Trim$(rs4070!K4070_QtyPlan)
    If IsdbNull(rs4070!K4070_QtyPlanBatch) = False Then D4070.QtyPlanBatch = Trim$(rs4070!K4070_QtyPlanBatch)
    If IsdbNull(rs4070!K4070_QtyProd) = False Then D4070.QtyProd = Trim$(rs4070!K4070_QtyProd)
    If IsdbNull(rs4070!K4070_QtyNormal) = False Then D4070.QtyNormal = Trim$(rs4070!K4070_QtyNormal)
    If IsdbNull(rs4070!K4070_QtyDefect) = False Then D4070.QtyDefect = Trim$(rs4070!K4070_QtyDefect)
    If IsdbNull(rs4070!K4070_QtyDefectPass) = False Then D4070.QtyDefectPass = Trim$(rs4070!K4070_QtyDefectPass)
    If IsdbNull(rs4070!K4070_QtyDefectReject) = False Then D4070.QtyDefectReject = Trim$(rs4070!K4070_QtyDefectReject)
    If IsdbNull(rs4070!K4070_CheckComplete) = False Then D4070.CheckComplete = Trim$(rs4070!K4070_CheckComplete)
    If IsdbNull(rs4070!K4070_CheckTrigger) = False Then D4070.CheckTrigger = Trim$(rs4070!K4070_CheckTrigger)
    If IsdbNull(rs4070!K4070_Remark) = False Then D4070.Remark = Trim$(rs4070!K4070_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K4070_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K4070_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z4070 As T4070_AREA, CDFACTORY AS String, CDMAINPROCESS AS String, MACHINECODE AS String, MACHINETNO AS String) as Boolean

K4070_MOVE = False

Try
    If READ_PFK4070(CDFACTORY, CDMAINPROCESS, MACHINECODE, MACHINETNO) = True Then
                z4070 = D4070
		K4070_MOVE = True
		else
	z4070 = nothing
     End If

     If  getColumIndex(spr,"cdFactory") > -1 then z4070.cdFactory = getDataM(spr, getColumIndex(spr,"cdFactory"), xRow)
     If  getColumIndex(spr,"cdMainProcess") > -1 then z4070.cdMainProcess = getDataM(spr, getColumIndex(spr,"cdMainProcess"), xRow)
     If  getColumIndex(spr,"MachineCode") > -1 then z4070.MachineCode = getDataM(spr, getColumIndex(spr,"MachineCode"), xRow)
     If  getColumIndex(spr,"MachineTno") > -1 then z4070.MachineTno = getDataM(spr, getColumIndex(spr,"MachineTno"), xRow)
     If  getColumIndex(spr,"seMainProcess") > -1 then z4070.seMainProcess = getDataM(spr, getColumIndex(spr,"seMainProcess"), xRow)
     If  getColumIndex(spr,"seFactory") > -1 then z4070.seFactory = getDataM(spr, getColumIndex(spr,"seFactory"), xRow)
     If  getColumIndex(spr,"JobCard") > -1 then z4070.JobCard = getDataM(spr, getColumIndex(spr,"JobCard"), xRow)
     If  getColumIndex(spr,"WorkOrder") > -1 then z4070.WorkOrder = getDataM(spr, getColumIndex(spr,"WorkOrder"), xRow)
     If  getColumIndex(spr,"WorkOrderSeq") > -1 then z4070.WorkOrderSeq = getDataM(spr, getColumIndex(spr,"WorkOrderSeq"), xRow)
     If  getColumIndex(spr,"DatePlan") > -1 then z4070.DatePlan = getDataM(spr, getColumIndex(spr,"DatePlan"), xRow)
     If  getColumIndex(spr,"DateStart") > -1 then z4070.DateStart = getDataM(spr, getColumIndex(spr,"DateStart"), xRow)
     If  getColumIndex(spr,"DateFinish") > -1 then z4070.DateFinish = getDataM(spr, getColumIndex(spr,"DateFinish"), xRow)
     If  getColumIndex(spr,"DateProduction") > -1 then z4070.DateProduction = getDataM(spr, getColumIndex(spr,"DateProduction"), xRow)
     If  getColumIndex(spr,"PartProduction") > -1 then z4070.PartProduction = getDataM(spr, getColumIndex(spr,"PartProduction"), xRow)
     If  getColumIndex(spr,"STimeProduction") > -1 then z4070.STimeProduction = getDataM(spr, getColumIndex(spr,"STimeProduction"), xRow)
     If  getColumIndex(spr,"ETimeProduction") > -1 then z4070.ETimeProduction = getDataM(spr, getColumIndex(spr,"ETimeProduction"), xRow)
     If  getColumIndex(spr,"InchargePlan") > -1 then z4070.InchargePlan = getDataM(spr, getColumIndex(spr,"InchargePlan"), xRow)
     If  getColumIndex(spr,"InchargeProdution") > -1 then z4070.InchargeProdution = getDataM(spr, getColumIndex(spr,"InchargeProdution"), xRow)
     If  getColumIndex(spr,"QtyPlan") > -1 then z4070.QtyPlan = getDataM(spr, getColumIndex(spr,"QtyPlan"), xRow)
     If  getColumIndex(spr,"QtyPlanBatch") > -1 then z4070.QtyPlanBatch = getDataM(spr, getColumIndex(spr,"QtyPlanBatch"), xRow)
     If  getColumIndex(spr,"QtyProd") > -1 then z4070.QtyProd = getDataM(spr, getColumIndex(spr,"QtyProd"), xRow)
     If  getColumIndex(spr,"QtyNormal") > -1 then z4070.QtyNormal = getDataM(spr, getColumIndex(spr,"QtyNormal"), xRow)
     If  getColumIndex(spr,"QtyDefect") > -1 then z4070.QtyDefect = getDataM(spr, getColumIndex(spr,"QtyDefect"), xRow)
     If  getColumIndex(spr,"QtyDefectPass") > -1 then z4070.QtyDefectPass = getDataM(spr, getColumIndex(spr,"QtyDefectPass"), xRow)
     If  getColumIndex(spr,"QtyDefectReject") > -1 then z4070.QtyDefectReject = getDataM(spr, getColumIndex(spr,"QtyDefectReject"), xRow)
     If  getColumIndex(spr,"CheckComplete") > -1 then z4070.CheckComplete = getDataM(spr, getColumIndex(spr,"CheckComplete"), xRow)
     If  getColumIndex(spr,"CheckTrigger") > -1 then z4070.CheckTrigger = getDataM(spr, getColumIndex(spr,"CheckTrigger"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z4070.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K4070_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K4070_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z4070 As T4070_AREA,CheckClear as Boolean,CDFACTORY AS String, CDMAINPROCESS AS String, MACHINECODE AS String, MACHINETNO AS String) as Boolean

K4070_MOVE = False

Try
    If READ_PFK4070(CDFACTORY, CDMAINPROCESS, MACHINECODE, MACHINETNO) = True Then
                z4070 = D4070
		K4070_MOVE = True
		else
	If CheckClear  = True then z4070 = nothing
     End If

     If  getColumIndex(spr,"cdFactory") > -1 then z4070.cdFactory = getDataM(spr, getColumIndex(spr,"cdFactory"), xRow)
     If  getColumIndex(spr,"cdMainProcess") > -1 then z4070.cdMainProcess = getDataM(spr, getColumIndex(spr,"cdMainProcess"), xRow)
     If  getColumIndex(spr,"MachineCode") > -1 then z4070.MachineCode = getDataM(spr, getColumIndex(spr,"MachineCode"), xRow)
     If  getColumIndex(spr,"MachineTno") > -1 then z4070.MachineTno = getDataM(spr, getColumIndex(spr,"MachineTno"), xRow)
     If  getColumIndex(spr,"seMainProcess") > -1 then z4070.seMainProcess = getDataM(spr, getColumIndex(spr,"seMainProcess"), xRow)
     If  getColumIndex(spr,"seFactory") > -1 then z4070.seFactory = getDataM(spr, getColumIndex(spr,"seFactory"), xRow)
     If  getColumIndex(spr,"JobCard") > -1 then z4070.JobCard = getDataM(spr, getColumIndex(spr,"JobCard"), xRow)
     If  getColumIndex(spr,"WorkOrder") > -1 then z4070.WorkOrder = getDataM(spr, getColumIndex(spr,"WorkOrder"), xRow)
     If  getColumIndex(spr,"WorkOrderSeq") > -1 then z4070.WorkOrderSeq = getDataM(spr, getColumIndex(spr,"WorkOrderSeq"), xRow)
     If  getColumIndex(spr,"DatePlan") > -1 then z4070.DatePlan = getDataM(spr, getColumIndex(spr,"DatePlan"), xRow)
     If  getColumIndex(spr,"DateStart") > -1 then z4070.DateStart = getDataM(spr, getColumIndex(spr,"DateStart"), xRow)
     If  getColumIndex(spr,"DateFinish") > -1 then z4070.DateFinish = getDataM(spr, getColumIndex(spr,"DateFinish"), xRow)
     If  getColumIndex(spr,"DateProduction") > -1 then z4070.DateProduction = getDataM(spr, getColumIndex(spr,"DateProduction"), xRow)
     If  getColumIndex(spr,"PartProduction") > -1 then z4070.PartProduction = getDataM(spr, getColumIndex(spr,"PartProduction"), xRow)
     If  getColumIndex(spr,"STimeProduction") > -1 then z4070.STimeProduction = getDataM(spr, getColumIndex(spr,"STimeProduction"), xRow)
     If  getColumIndex(spr,"ETimeProduction") > -1 then z4070.ETimeProduction = getDataM(spr, getColumIndex(spr,"ETimeProduction"), xRow)
     If  getColumIndex(spr,"InchargePlan") > -1 then z4070.InchargePlan = getDataM(spr, getColumIndex(spr,"InchargePlan"), xRow)
     If  getColumIndex(spr,"InchargeProdution") > -1 then z4070.InchargeProdution = getDataM(spr, getColumIndex(spr,"InchargeProdution"), xRow)
     If  getColumIndex(spr,"QtyPlan") > -1 then z4070.QtyPlan = getDataM(spr, getColumIndex(spr,"QtyPlan"), xRow)
     If  getColumIndex(spr,"QtyPlanBatch") > -1 then z4070.QtyPlanBatch = getDataM(spr, getColumIndex(spr,"QtyPlanBatch"), xRow)
     If  getColumIndex(spr,"QtyProd") > -1 then z4070.QtyProd = getDataM(spr, getColumIndex(spr,"QtyProd"), xRow)
     If  getColumIndex(spr,"QtyNormal") > -1 then z4070.QtyNormal = getDataM(spr, getColumIndex(spr,"QtyNormal"), xRow)
     If  getColumIndex(spr,"QtyDefect") > -1 then z4070.QtyDefect = getDataM(spr, getColumIndex(spr,"QtyDefect"), xRow)
     If  getColumIndex(spr,"QtyDefectPass") > -1 then z4070.QtyDefectPass = getDataM(spr, getColumIndex(spr,"QtyDefectPass"), xRow)
     If  getColumIndex(spr,"QtyDefectReject") > -1 then z4070.QtyDefectReject = getDataM(spr, getColumIndex(spr,"QtyDefectReject"), xRow)
     If  getColumIndex(spr,"CheckComplete") > -1 then z4070.CheckComplete = getDataM(spr, getColumIndex(spr,"CheckComplete"), xRow)
     If  getColumIndex(spr,"CheckTrigger") > -1 then z4070.CheckTrigger = getDataM(spr, getColumIndex(spr,"CheckTrigger"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z4070.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K4070_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K4070_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z4070 As T4070_AREA, Job as String, CDFACTORY AS String, CDMAINPROCESS AS String, MACHINECODE AS String, MACHINETNO AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K4070_MOVE = False

Try
    If READ_PFK4070(CDFACTORY, CDMAINPROCESS, MACHINECODE, MACHINETNO) = True Then
                z4070 = D4070
		K4070_MOVE = True
		else
	z4070 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4070")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "CDFACTORY":z4070.cdFactory = Children(i).Code
   Case "CDMAINPROCESS":z4070.cdMainProcess = Children(i).Code
   Case "MACHINECODE":z4070.MachineCode = Children(i).Code
   Case "MACHINETNO":z4070.MachineTno = Children(i).Code
   Case "SEMAINPROCESS":z4070.seMainProcess = Children(i).Code
   Case "SEFACTORY":z4070.seFactory = Children(i).Code
   Case "JOBCARD":z4070.JobCard = Children(i).Code
   Case "WORKORDER":z4070.WorkOrder = Children(i).Code
   Case "WORKORDERSEQ":z4070.WorkOrderSeq = Children(i).Code
   Case "DATEPLAN":z4070.DatePlan = Children(i).Code
   Case "DATESTART":z4070.DateStart = Children(i).Code
   Case "DATEFINISH":z4070.DateFinish = Children(i).Code
   Case "DATEPRODUCTION":z4070.DateProduction = Children(i).Code
   Case "PARTPRODUCTION":z4070.PartProduction = Children(i).Code
   Case "STIMEPRODUCTION":z4070.STimeProduction = Children(i).Code
   Case "ETIMEPRODUCTION":z4070.ETimeProduction = Children(i).Code
   Case "INCHARGEPLAN":z4070.InchargePlan = Children(i).Code
   Case "INCHARGEPRODUTION":z4070.InchargeProdution = Children(i).Code
   Case "QTYPLAN":z4070.QtyPlan = Children(i).Code
   Case "QTYPLANBATCH":z4070.QtyPlanBatch = Children(i).Code
   Case "QTYPROD":z4070.QtyProd = Children(i).Code
   Case "QTYNORMAL":z4070.QtyNormal = Children(i).Code
   Case "QTYDEFECT":z4070.QtyDefect = Children(i).Code
   Case "QTYDEFECTPASS":z4070.QtyDefectPass = Children(i).Code
   Case "QTYDEFECTREJECT":z4070.QtyDefectReject = Children(i).Code
   Case "CHECKCOMPLETE":z4070.CheckComplete = Children(i).Code
   Case "CHECKTRIGGER":z4070.CheckTrigger = Children(i).Code
   Case "REMARK":z4070.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "CDFACTORY":z4070.cdFactory = Children(i).Data
   Case "CDMAINPROCESS":z4070.cdMainProcess = Children(i).Data
   Case "MACHINECODE":z4070.MachineCode = Children(i).Data
   Case "MACHINETNO":z4070.MachineTno = Children(i).Data
   Case "SEMAINPROCESS":z4070.seMainProcess = Children(i).Data
   Case "SEFACTORY":z4070.seFactory = Children(i).Data
   Case "JOBCARD":z4070.JobCard = Children(i).Data
   Case "WORKORDER":z4070.WorkOrder = Children(i).Data
   Case "WORKORDERSEQ":z4070.WorkOrderSeq = Children(i).Data
   Case "DATEPLAN":z4070.DatePlan = Children(i).Data
   Case "DATESTART":z4070.DateStart = Children(i).Data
   Case "DATEFINISH":z4070.DateFinish = Children(i).Data
   Case "DATEPRODUCTION":z4070.DateProduction = Children(i).Data
   Case "PARTPRODUCTION":z4070.PartProduction = Children(i).Data
   Case "STIMEPRODUCTION":z4070.STimeProduction = Children(i).Data
   Case "ETIMEPRODUCTION":z4070.ETimeProduction = Children(i).Data
   Case "INCHARGEPLAN":z4070.InchargePlan = Children(i).Data
   Case "INCHARGEPRODUTION":z4070.InchargeProdution = Children(i).Data
   Case "QTYPLAN":z4070.QtyPlan = Children(i).Data
   Case "QTYPLANBATCH":z4070.QtyPlanBatch = Children(i).Data
   Case "QTYPROD":z4070.QtyProd = Children(i).Data
   Case "QTYNORMAL":z4070.QtyNormal = Children(i).Data
   Case "QTYDEFECT":z4070.QtyDefect = Children(i).Data
   Case "QTYDEFECTPASS":z4070.QtyDefectPass = Children(i).Data
   Case "QTYDEFECTREJECT":z4070.QtyDefectReject = Children(i).Data
   Case "CHECKCOMPLETE":z4070.CheckComplete = Children(i).Data
   Case "CHECKTRIGGER":z4070.CheckTrigger = Children(i).Data
   Case "REMARK":z4070.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K4070_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K4070_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z4070 As T4070_AREA, Job as String, CheckClear as Boolean, CDFACTORY AS String, CDMAINPROCESS AS String, MACHINECODE AS String, MACHINETNO AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K4070_MOVE = False

Try
    If READ_PFK4070(CDFACTORY, CDMAINPROCESS, MACHINECODE, MACHINETNO) = True Then
                z4070 = D4070
		K4070_MOVE = True
		else
	If CheckClear  = True then z4070 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4070")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "CDFACTORY":z4070.cdFactory = Children(i).Code
   Case "CDMAINPROCESS":z4070.cdMainProcess = Children(i).Code
   Case "MACHINECODE":z4070.MachineCode = Children(i).Code
   Case "MACHINETNO":z4070.MachineTno = Children(i).Code
   Case "SEMAINPROCESS":z4070.seMainProcess = Children(i).Code
   Case "SEFACTORY":z4070.seFactory = Children(i).Code
   Case "JOBCARD":z4070.JobCard = Children(i).Code
   Case "WORKORDER":z4070.WorkOrder = Children(i).Code
   Case "WORKORDERSEQ":z4070.WorkOrderSeq = Children(i).Code
   Case "DATEPLAN":z4070.DatePlan = Children(i).Code
   Case "DATESTART":z4070.DateStart = Children(i).Code
   Case "DATEFINISH":z4070.DateFinish = Children(i).Code
   Case "DATEPRODUCTION":z4070.DateProduction = Children(i).Code
   Case "PARTPRODUCTION":z4070.PartProduction = Children(i).Code
   Case "STIMEPRODUCTION":z4070.STimeProduction = Children(i).Code
   Case "ETIMEPRODUCTION":z4070.ETimeProduction = Children(i).Code
   Case "INCHARGEPLAN":z4070.InchargePlan = Children(i).Code
   Case "INCHARGEPRODUTION":z4070.InchargeProdution = Children(i).Code
   Case "QTYPLAN":z4070.QtyPlan = Children(i).Code
   Case "QTYPLANBATCH":z4070.QtyPlanBatch = Children(i).Code
   Case "QTYPROD":z4070.QtyProd = Children(i).Code
   Case "QTYNORMAL":z4070.QtyNormal = Children(i).Code
   Case "QTYDEFECT":z4070.QtyDefect = Children(i).Code
   Case "QTYDEFECTPASS":z4070.QtyDefectPass = Children(i).Code
   Case "QTYDEFECTREJECT":z4070.QtyDefectReject = Children(i).Code
   Case "CHECKCOMPLETE":z4070.CheckComplete = Children(i).Code
   Case "CHECKTRIGGER":z4070.CheckTrigger = Children(i).Code
   Case "REMARK":z4070.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "CDFACTORY":z4070.cdFactory = Children(i).Data
   Case "CDMAINPROCESS":z4070.cdMainProcess = Children(i).Data
   Case "MACHINECODE":z4070.MachineCode = Children(i).Data
   Case "MACHINETNO":z4070.MachineTno = Children(i).Data
   Case "SEMAINPROCESS":z4070.seMainProcess = Children(i).Data
   Case "SEFACTORY":z4070.seFactory = Children(i).Data
   Case "JOBCARD":z4070.JobCard = Children(i).Data
   Case "WORKORDER":z4070.WorkOrder = Children(i).Data
   Case "WORKORDERSEQ":z4070.WorkOrderSeq = Children(i).Data
   Case "DATEPLAN":z4070.DatePlan = Children(i).Data
   Case "DATESTART":z4070.DateStart = Children(i).Data
   Case "DATEFINISH":z4070.DateFinish = Children(i).Data
   Case "DATEPRODUCTION":z4070.DateProduction = Children(i).Data
   Case "PARTPRODUCTION":z4070.PartProduction = Children(i).Data
   Case "STIMEPRODUCTION":z4070.STimeProduction = Children(i).Data
   Case "ETIMEPRODUCTION":z4070.ETimeProduction = Children(i).Data
   Case "INCHARGEPLAN":z4070.InchargePlan = Children(i).Data
   Case "INCHARGEPRODUTION":z4070.InchargeProdution = Children(i).Data
   Case "QTYPLAN":z4070.QtyPlan = Children(i).Data
   Case "QTYPLANBATCH":z4070.QtyPlanBatch = Children(i).Data
   Case "QTYPROD":z4070.QtyProd = Children(i).Data
   Case "QTYNORMAL":z4070.QtyNormal = Children(i).Data
   Case "QTYDEFECT":z4070.QtyDefect = Children(i).Data
   Case "QTYDEFECTPASS":z4070.QtyDefectPass = Children(i).Data
   Case "QTYDEFECTREJECT":z4070.QtyDefectReject = Children(i).Data
   Case "CHECKCOMPLETE":z4070.CheckComplete = Children(i).Data
   Case "CHECKTRIGGER":z4070.CheckTrigger = Children(i).Data
   Case "REMARK":z4070.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K4070_MOVE",vbCritical)
End Try
End Function 
    
End Module 
