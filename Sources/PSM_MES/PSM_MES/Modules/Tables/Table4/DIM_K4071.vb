'=========================================================================================================================================================
'   TABLE : (PFK4071)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K4071

Structure T4071_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	cdFactory	 AS String	'			char(3)		*
Public 	cdMainProcess	 AS String	'			char(3)		*
Public 	MachineCode	 AS String	'			char(6)		*
Public 	MachineTno	 AS String	'			char(2)		*
Public 	Szno	 AS String	'			char(2)		*
Public 	seMainProcess	 AS String	'			char(3)
Public 	seFactory	 AS String	'			char(3)
Public 	JobCard	 AS String	'			char(9)
Public 	WorkOrder	 AS String	'			char(9)
Public 	WorkOrderSeq	 AS String	'			char(3)
Public 	DatePlan	 AS String	'			char(8)
Public 	DateProduction	 AS String	'			char(8)
Public 	PartProduction	 AS String	'			char(1)
Public 	STimeProduction	 AS String	'			nvarchar(20)
Public 	ETimeProduction	 AS String	'			nvarchar(20)
Public 	InchargePlan	 AS String	'			char(8)
Public 	InchargeProdution	 AS String	'			char(8)
Public 	QtyBatch	 AS Double	'			decimal
Public 	QtyPlan	 AS Double	'			decimal
        Public QtyPlanBatch As Double  '			decimal
        Public QtyPlanBatch1 As Double  '			decimal
        Public QtyPlanBatch2 As Double  '			decimal

        Public QtyPlanBatch3 As Double  '			decimal
        Public QtyPlanBatch4 As Double  '			decimal
        Public QtyPlanBatch5 As Double  '			decimal

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

Public D4071 As T4071_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK4071(CDFACTORY AS String, CDMAINPROCESS AS String, MACHINECODE AS String, MACHINETNO AS String, SZNO AS String) As Boolean
    READ_PFK4071 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK4071 "
    SQL = SQL & " WHERE K4071_cdFactory		 = '" & cdFactory & "' " 
    SQL = SQL & "   AND K4071_cdMainProcess		 = '" & cdMainProcess & "' " 
    SQL = SQL & "   AND K4071_MachineCode		 = '" & MachineCode & "' " 
    SQL = SQL & "   AND K4071_MachineTno		 = '" & MachineTno & "' " 
    SQL = SQL & "   AND K4071_Szno		 = '" & Szno & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D4071_CLEAR: GoTo SKIP_READ_PFK4071
                
    Call K4071_MOVE(rd)
    READ_PFK4071 = True

SKIP_READ_PFK4071:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK4071",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK4071(CDFACTORY AS String, CDMAINPROCESS AS String, MACHINECODE AS String, MACHINETNO AS String, SZNO AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK4071 "
    SQL = SQL & " WHERE K4071_cdFactory		 = '" & cdFactory & "' " 
    SQL = SQL & "   AND K4071_cdMainProcess		 = '" & cdMainProcess & "' " 
    SQL = SQL & "   AND K4071_MachineCode		 = '" & MachineCode & "' " 
    SQL = SQL & "   AND K4071_MachineTno		 = '" & MachineTno & "' " 
    SQL = SQL & "   AND K4071_Szno		 = '" & Szno & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK4071",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK4071(z4071 As T4071_AREA) As Boolean
    WRITE_PFK4071 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z4071)
 
    SQL = " INSERT INTO PFK4071 "
    SQL = SQL & " ( "
    SQL = SQL & " K4071_cdFactory," 
    SQL = SQL & " K4071_cdMainProcess," 
    SQL = SQL & " K4071_MachineCode," 
    SQL = SQL & " K4071_MachineTno," 
    SQL = SQL & " K4071_Szno," 
    SQL = SQL & " K4071_seMainProcess," 
    SQL = SQL & " K4071_seFactory," 
    SQL = SQL & " K4071_JobCard," 
    SQL = SQL & " K4071_WorkOrder," 
    SQL = SQL & " K4071_WorkOrderSeq," 
    SQL = SQL & " K4071_DatePlan," 
    SQL = SQL & " K4071_DateProduction," 
    SQL = SQL & " K4071_PartProduction," 
    SQL = SQL & " K4071_STimeProduction," 
    SQL = SQL & " K4071_ETimeProduction," 
    SQL = SQL & " K4071_InchargePlan," 
    SQL = SQL & " K4071_InchargeProdution," 
    SQL = SQL & " K4071_QtyBatch," 
    SQL = SQL & " K4071_QtyPlan," 
            SQL = SQL & " K4071_QtyPlanBatch,"
            SQL = SQL & " K4071_QtyPlanBatch1,"
            SQL = SQL & " K4071_QtyPlanBatch2,"

            SQL = SQL & " K4071_QtyPlanBatch3,"
            SQL = SQL & " K4071_QtyPlanBatch4,"
            SQL = SQL & " K4071_QtyPlanBatch5,"

    SQL = SQL & " K4071_QtyProd," 
    SQL = SQL & " K4071_QtyNormal," 
    SQL = SQL & " K4071_QtyDefect," 
    SQL = SQL & " K4071_QtyDefectPass," 
    SQL = SQL & " K4071_QtyDefectReject," 
    SQL = SQL & " K4071_CheckComplete," 
    SQL = SQL & " K4071_CheckTrigger," 
    SQL = SQL & " K4071_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z4071.cdFactory) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4071.cdMainProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4071.MachineCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4071.MachineTno) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4071.Szno) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4071.seMainProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4071.seFactory) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4071.JobCard) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4071.WorkOrder) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4071.WorkOrderSeq) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4071.DatePlan) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4071.DateProduction) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4071.PartProduction) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4071.STimeProduction) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4071.ETimeProduction) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4071.InchargePlan) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4071.InchargeProdution) & "', "  
    SQL = SQL & "   " & FormatSQL(z4071.QtyBatch) & ", "  
    SQL = SQL & "   " & FormatSQL(z4071.QtyPlan) & ", "  
            SQL = SQL & "   " & FormatSQL(z4071.QtyPlanBatch) & ", "
            SQL = SQL & "   " & FormatSQL(z4071.QtyPlanBatch1) & ", "
            SQL = SQL & "   " & FormatSQL(z4071.QtyPlanBatch2) & ", "

            SQL = SQL & "   " & FormatSQL(z4071.QtyPlanBatch3) & ", "
            SQL = SQL & "   " & FormatSQL(z4071.QtyPlanBatch4) & ", "
            SQL = SQL & "   " & FormatSQL(z4071.QtyPlanBatch5) & ", "

    SQL = SQL & "   " & FormatSQL(z4071.QtyProd) & ", "  
    SQL = SQL & "   " & FormatSQL(z4071.QtyNormal) & ", "  
    SQL = SQL & "   " & FormatSQL(z4071.QtyDefect) & ", "  
    SQL = SQL & "   " & FormatSQL(z4071.QtyDefectPass) & ", "  
    SQL = SQL & "   " & FormatSQL(z4071.QtyDefectReject) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z4071.CheckComplete) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4071.CheckTrigger) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4071.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK4071 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK4071",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK4071(z4071 As T4071_AREA) As Boolean
    REWRITE_PFK4071 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z4071)
   
    SQL = " UPDATE PFK4071 SET "
    SQL = SQL & "    K4071_seMainProcess      = N'" & FormatSQL(z4071.seMainProcess) & "', " 
    SQL = SQL & "    K4071_seFactory      = N'" & FormatSQL(z4071.seFactory) & "', " 
    SQL = SQL & "    K4071_JobCard      = N'" & FormatSQL(z4071.JobCard) & "', " 
    SQL = SQL & "    K4071_WorkOrder      = N'" & FormatSQL(z4071.WorkOrder) & "', " 
    SQL = SQL & "    K4071_WorkOrderSeq      = N'" & FormatSQL(z4071.WorkOrderSeq) & "', " 
    SQL = SQL & "    K4071_DatePlan      = N'" & FormatSQL(z4071.DatePlan) & "', " 
    SQL = SQL & "    K4071_DateProduction      = N'" & FormatSQL(z4071.DateProduction) & "', " 
    SQL = SQL & "    K4071_PartProduction      = N'" & FormatSQL(z4071.PartProduction) & "', " 
    SQL = SQL & "    K4071_STimeProduction      = N'" & FormatSQL(z4071.STimeProduction) & "', " 
    SQL = SQL & "    K4071_ETimeProduction      = N'" & FormatSQL(z4071.ETimeProduction) & "', " 
    SQL = SQL & "    K4071_InchargePlan      = N'" & FormatSQL(z4071.InchargePlan) & "', " 
    SQL = SQL & "    K4071_InchargeProdution      = N'" & FormatSQL(z4071.InchargeProdution) & "', " 
    SQL = SQL & "    K4071_QtyBatch      =  " & FormatSQL(z4071.QtyBatch) & ", " 
    SQL = SQL & "    K4071_QtyPlan      =  " & FormatSQL(z4071.QtyPlan) & ", " 
            SQL = SQL & "    K4071_QtyPlanBatch      =  " & FormatSQL(z4071.QtyPlanBatch) & ", "
            SQL = SQL & "    K4071_QtyPlanBatch1      =  " & FormatSQL(z4071.QtyPlanBatch1) & ", "
            SQL = SQL & "    K4071_QtyPlanBatch2      =  " & FormatSQL(z4071.QtyPlanBatch2) & ", "

            SQL = SQL & "    K4071_QtyPlanBatch3      =  " & FormatSQL(z4071.QtyPlanBatch3) & ", "
            SQL = SQL & "    K4071_QtyPlanBatch4      =  " & FormatSQL(z4071.QtyPlanBatch4) & ", "
            SQL = SQL & "    K4071_QtyPlanBatch5      =  " & FormatSQL(z4071.QtyPlanBatch5) & ", "

    SQL = SQL & "    K4071_QtyProd      =  " & FormatSQL(z4071.QtyProd) & ", " 
    SQL = SQL & "    K4071_QtyNormal      =  " & FormatSQL(z4071.QtyNormal) & ", " 
    SQL = SQL & "    K4071_QtyDefect      =  " & FormatSQL(z4071.QtyDefect) & ", " 
    SQL = SQL & "    K4071_QtyDefectPass      =  " & FormatSQL(z4071.QtyDefectPass) & ", " 
    SQL = SQL & "    K4071_QtyDefectReject      =  " & FormatSQL(z4071.QtyDefectReject) & ", " 
    SQL = SQL & "    K4071_CheckComplete      = N'" & FormatSQL(z4071.CheckComplete) & "', " 
    SQL = SQL & "    K4071_CheckTrigger      = N'" & FormatSQL(z4071.CheckTrigger) & "', " 
    SQL = SQL & "    K4071_Remark      = N'" & FormatSQL(z4071.Remark) & "'  " 
    SQL = SQL & " WHERE K4071_cdFactory		 = '" & z4071.cdFactory & "' " 
    SQL = SQL & "   AND K4071_cdMainProcess		 = '" & z4071.cdMainProcess & "' " 
    SQL = SQL & "   AND K4071_MachineCode		 = '" & z4071.MachineCode & "' " 
    SQL = SQL & "   AND K4071_MachineTno		 = '" & z4071.MachineTno & "' " 
    SQL = SQL & "   AND K4071_Szno		 = '" & z4071.Szno & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK4071 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK4071",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK4071(z4071 As T4071_AREA) As Boolean
    DELETE_PFK4071 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK4071 "
    SQL = SQL & " WHERE K4071_cdFactory		 = '" & z4071.cdFactory & "' " 
    SQL = SQL & "   AND K4071_cdMainProcess		 = '" & z4071.cdMainProcess & "' " 
    SQL = SQL & "   AND K4071_MachineCode		 = '" & z4071.MachineCode & "' " 
    SQL = SQL & "   AND K4071_MachineTno		 = '" & z4071.MachineTno & "' " 
    SQL = SQL & "   AND K4071_Szno		 = '" & z4071.Szno & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK4071 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK4071",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D4071_CLEAR()
Try
    
   D4071.cdFactory = ""
   D4071.cdMainProcess = ""
   D4071.MachineCode = ""
   D4071.MachineTno = ""
   D4071.Szno = ""
   D4071.seMainProcess = ""
   D4071.seFactory = ""
   D4071.JobCard = ""
   D4071.WorkOrder = ""
   D4071.WorkOrderSeq = ""
   D4071.DatePlan = ""
   D4071.DateProduction = ""
   D4071.PartProduction = ""
   D4071.STimeProduction = ""
   D4071.ETimeProduction = ""
   D4071.InchargePlan = ""
   D4071.InchargeProdution = ""
    D4071.QtyBatch = 0 
    D4071.QtyPlan = 0 
            D4071.QtyPlanBatch = 0
            D4071.QtyPlanBatch1 = 0
            D4071.QtyPlanBatch2 = 0

            D4071.QtyPlanBatch3 = 0
            D4071.QtyPlanBatch4 = 0
            D4071.QtyPlanBatch5 = 0

    D4071.QtyProd = 0 
    D4071.QtyNormal = 0 
    D4071.QtyDefect = 0 
    D4071.QtyDefectPass = 0 
    D4071.QtyDefectReject = 0 
   D4071.CheckComplete = ""
   D4071.CheckTrigger = ""
   D4071.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D4071_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x4071 As T4071_AREA)
Try
    
    x4071.cdFactory = trim$(  x4071.cdFactory)
    x4071.cdMainProcess = trim$(  x4071.cdMainProcess)
    x4071.MachineCode = trim$(  x4071.MachineCode)
    x4071.MachineTno = trim$(  x4071.MachineTno)
    x4071.Szno = trim$(  x4071.Szno)
    x4071.seMainProcess = trim$(  x4071.seMainProcess)
    x4071.seFactory = trim$(  x4071.seFactory)
    x4071.JobCard = trim$(  x4071.JobCard)
    x4071.WorkOrder = trim$(  x4071.WorkOrder)
    x4071.WorkOrderSeq = trim$(  x4071.WorkOrderSeq)
    x4071.DatePlan = trim$(  x4071.DatePlan)
    x4071.DateProduction = trim$(  x4071.DateProduction)
    x4071.PartProduction = trim$(  x4071.PartProduction)
    x4071.STimeProduction = trim$(  x4071.STimeProduction)
    x4071.ETimeProduction = trim$(  x4071.ETimeProduction)
    x4071.InchargePlan = trim$(  x4071.InchargePlan)
    x4071.InchargeProdution = trim$(  x4071.InchargeProdution)
    x4071.QtyBatch = trim$(  x4071.QtyBatch)
    x4071.QtyPlan = trim$(  x4071.QtyPlan)
            x4071.QtyPlanBatch = Trim$(x4071.QtyPlanBatch)
            x4071.QtyPlanBatch1 = Trim$(x4071.QtyPlanBatch1)
            x4071.QtyPlanBatch2 = Trim$(x4071.QtyPlanBatch2)

            x4071.QtyPlanBatch3 = Trim$(x4071.QtyPlanBatch3)
            x4071.QtyPlanBatch4 = Trim$(x4071.QtyPlanBatch4)
            x4071.QtyPlanBatch5 = Trim$(x4071.QtyPlanBatch5)

    x4071.QtyProd = trim$(  x4071.QtyProd)
    x4071.QtyNormal = trim$(  x4071.QtyNormal)
    x4071.QtyDefect = trim$(  x4071.QtyDefect)
    x4071.QtyDefectPass = trim$(  x4071.QtyDefectPass)
    x4071.QtyDefectReject = trim$(  x4071.QtyDefectReject)
    x4071.CheckComplete = trim$(  x4071.CheckComplete)
    x4071.CheckTrigger = trim$(  x4071.CheckTrigger)
    x4071.Remark = trim$(  x4071.Remark)
     
    If trim$( x4071.cdFactory ) = "" Then x4071.cdFactory = Space(1) 
    If trim$( x4071.cdMainProcess ) = "" Then x4071.cdMainProcess = Space(1) 
    If trim$( x4071.MachineCode ) = "" Then x4071.MachineCode = Space(1) 
    If trim$( x4071.MachineTno ) = "" Then x4071.MachineTno = Space(1) 
    If trim$( x4071.Szno ) = "" Then x4071.Szno = Space(1) 
    If trim$( x4071.seMainProcess ) = "" Then x4071.seMainProcess = Space(1) 
    If trim$( x4071.seFactory ) = "" Then x4071.seFactory = Space(1) 
    If trim$( x4071.JobCard ) = "" Then x4071.JobCard = Space(1) 
    If trim$( x4071.WorkOrder ) = "" Then x4071.WorkOrder = Space(1) 
    If trim$( x4071.WorkOrderSeq ) = "" Then x4071.WorkOrderSeq = Space(1) 
    If trim$( x4071.DatePlan ) = "" Then x4071.DatePlan = Space(1) 
    If trim$( x4071.DateProduction ) = "" Then x4071.DateProduction = Space(1) 
    If trim$( x4071.PartProduction ) = "" Then x4071.PartProduction = Space(1) 
    If trim$( x4071.STimeProduction ) = "" Then x4071.STimeProduction = Space(1) 
    If trim$( x4071.ETimeProduction ) = "" Then x4071.ETimeProduction = Space(1) 
    If trim$( x4071.InchargePlan ) = "" Then x4071.InchargePlan = Space(1) 
    If trim$( x4071.InchargeProdution ) = "" Then x4071.InchargeProdution = Space(1) 
    If trim$( x4071.QtyBatch ) = "" Then x4071.QtyBatch = 0 
    If trim$( x4071.QtyPlan ) = "" Then x4071.QtyPlan = 0 
            If Trim$(x4071.QtyPlanBatch) = "" Then x4071.QtyPlanBatch = 0
            If Trim$(x4071.QtyPlanBatch1) = "" Then x4071.QtyPlanBatch1 = 0
            If Trim$(x4071.QtyPlanBatch2) = "" Then x4071.QtyPlanBatch2 = 0

            If Trim$(x4071.QtyPlanBatch3) = "" Then x4071.QtyPlanBatch3 = 0
            If Trim$(x4071.QtyPlanBatch4) = "" Then x4071.QtyPlanBatch4 = 0
            If Trim$(x4071.QtyPlanBatch5) = "" Then x4071.QtyPlanBatch5 = 0

    If trim$( x4071.QtyProd ) = "" Then x4071.QtyProd = 0 
    If trim$( x4071.QtyNormal ) = "" Then x4071.QtyNormal = 0 
    If trim$( x4071.QtyDefect ) = "" Then x4071.QtyDefect = 0 
    If trim$( x4071.QtyDefectPass ) = "" Then x4071.QtyDefectPass = 0 
    If trim$( x4071.QtyDefectReject ) = "" Then x4071.QtyDefectReject = 0 
    If trim$( x4071.CheckComplete ) = "" Then x4071.CheckComplete = Space(1) 
    If trim$( x4071.CheckTrigger ) = "" Then x4071.CheckTrigger = Space(1) 
    If trim$( x4071.Remark ) = "" Then x4071.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K4071_MOVE(rs4071 As SqlClient.SqlDataReader)
Try

    call D4071_CLEAR()   

    If IsdbNull(rs4071!K4071_cdFactory) = False Then D4071.cdFactory = Trim$(rs4071!K4071_cdFactory)
    If IsdbNull(rs4071!K4071_cdMainProcess) = False Then D4071.cdMainProcess = Trim$(rs4071!K4071_cdMainProcess)
    If IsdbNull(rs4071!K4071_MachineCode) = False Then D4071.MachineCode = Trim$(rs4071!K4071_MachineCode)
    If IsdbNull(rs4071!K4071_MachineTno) = False Then D4071.MachineTno = Trim$(rs4071!K4071_MachineTno)
    If IsdbNull(rs4071!K4071_Szno) = False Then D4071.Szno = Trim$(rs4071!K4071_Szno)
    If IsdbNull(rs4071!K4071_seMainProcess) = False Then D4071.seMainProcess = Trim$(rs4071!K4071_seMainProcess)
    If IsdbNull(rs4071!K4071_seFactory) = False Then D4071.seFactory = Trim$(rs4071!K4071_seFactory)
    If IsdbNull(rs4071!K4071_JobCard) = False Then D4071.JobCard = Trim$(rs4071!K4071_JobCard)
    If IsdbNull(rs4071!K4071_WorkOrder) = False Then D4071.WorkOrder = Trim$(rs4071!K4071_WorkOrder)
    If IsdbNull(rs4071!K4071_WorkOrderSeq) = False Then D4071.WorkOrderSeq = Trim$(rs4071!K4071_WorkOrderSeq)
    If IsdbNull(rs4071!K4071_DatePlan) = False Then D4071.DatePlan = Trim$(rs4071!K4071_DatePlan)
    If IsdbNull(rs4071!K4071_DateProduction) = False Then D4071.DateProduction = Trim$(rs4071!K4071_DateProduction)
    If IsdbNull(rs4071!K4071_PartProduction) = False Then D4071.PartProduction = Trim$(rs4071!K4071_PartProduction)
    If IsdbNull(rs4071!K4071_STimeProduction) = False Then D4071.STimeProduction = Trim$(rs4071!K4071_STimeProduction)
    If IsdbNull(rs4071!K4071_ETimeProduction) = False Then D4071.ETimeProduction = Trim$(rs4071!K4071_ETimeProduction)
    If IsdbNull(rs4071!K4071_InchargePlan) = False Then D4071.InchargePlan = Trim$(rs4071!K4071_InchargePlan)
    If IsdbNull(rs4071!K4071_InchargeProdution) = False Then D4071.InchargeProdution = Trim$(rs4071!K4071_InchargeProdution)
    If IsdbNull(rs4071!K4071_QtyBatch) = False Then D4071.QtyBatch = Trim$(rs4071!K4071_QtyBatch)
    If IsdbNull(rs4071!K4071_QtyPlan) = False Then D4071.QtyPlan = Trim$(rs4071!K4071_QtyPlan)
            If IsDBNull(rs4071!K4071_QtyPlanBatch) = False Then D4071.QtyPlanBatch = Trim$(rs4071!K4071_QtyPlanBatch)
            If IsDBNull(rs4071!K4071_QtyPlanBatch1) = False Then D4071.QtyPlanBatch1 = Trim$(rs4071!K4071_QtyPlanBatch1)
            If IsDBNull(rs4071!K4071_QtyPlanBatch2) = False Then D4071.QtyPlanBatch2 = Trim$(rs4071!K4071_QtyPlanBatch2)

            If IsDBNull(rs4071!K4071_QtyPlanBatch3) = False Then D4071.QtyPlanBatch3 = Trim$(rs4071!K4071_QtyPlanBatch3)
            If IsDBNull(rs4071!K4071_QtyPlanBatch4) = False Then D4071.QtyPlanBatch4 = Trim$(rs4071!K4071_QtyPlanBatch4)
            If IsDBNull(rs4071!K4071_QtyPlanBatch5) = False Then D4071.QtyPlanBatch5 = Trim$(rs4071!K4071_QtyPlanBatch5)

    If IsdbNull(rs4071!K4071_QtyProd) = False Then D4071.QtyProd = Trim$(rs4071!K4071_QtyProd)
    If IsdbNull(rs4071!K4071_QtyNormal) = False Then D4071.QtyNormal = Trim$(rs4071!K4071_QtyNormal)
    If IsdbNull(rs4071!K4071_QtyDefect) = False Then D4071.QtyDefect = Trim$(rs4071!K4071_QtyDefect)
    If IsdbNull(rs4071!K4071_QtyDefectPass) = False Then D4071.QtyDefectPass = Trim$(rs4071!K4071_QtyDefectPass)
    If IsdbNull(rs4071!K4071_QtyDefectReject) = False Then D4071.QtyDefectReject = Trim$(rs4071!K4071_QtyDefectReject)
    If IsdbNull(rs4071!K4071_CheckComplete) = False Then D4071.CheckComplete = Trim$(rs4071!K4071_CheckComplete)
    If IsdbNull(rs4071!K4071_CheckTrigger) = False Then D4071.CheckTrigger = Trim$(rs4071!K4071_CheckTrigger)
    If IsdbNull(rs4071!K4071_Remark) = False Then D4071.Remark = Trim$(rs4071!K4071_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K4071_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K4071_MOVE(rs4071 As DataRow)
Try

    call D4071_CLEAR()   

    If IsdbNull(rs4071!K4071_cdFactory) = False Then D4071.cdFactory = Trim$(rs4071!K4071_cdFactory)
    If IsdbNull(rs4071!K4071_cdMainProcess) = False Then D4071.cdMainProcess = Trim$(rs4071!K4071_cdMainProcess)
    If IsdbNull(rs4071!K4071_MachineCode) = False Then D4071.MachineCode = Trim$(rs4071!K4071_MachineCode)
    If IsdbNull(rs4071!K4071_MachineTno) = False Then D4071.MachineTno = Trim$(rs4071!K4071_MachineTno)
    If IsdbNull(rs4071!K4071_Szno) = False Then D4071.Szno = Trim$(rs4071!K4071_Szno)
    If IsdbNull(rs4071!K4071_seMainProcess) = False Then D4071.seMainProcess = Trim$(rs4071!K4071_seMainProcess)
    If IsdbNull(rs4071!K4071_seFactory) = False Then D4071.seFactory = Trim$(rs4071!K4071_seFactory)
    If IsdbNull(rs4071!K4071_JobCard) = False Then D4071.JobCard = Trim$(rs4071!K4071_JobCard)
    If IsdbNull(rs4071!K4071_WorkOrder) = False Then D4071.WorkOrder = Trim$(rs4071!K4071_WorkOrder)
    If IsdbNull(rs4071!K4071_WorkOrderSeq) = False Then D4071.WorkOrderSeq = Trim$(rs4071!K4071_WorkOrderSeq)
    If IsdbNull(rs4071!K4071_DatePlan) = False Then D4071.DatePlan = Trim$(rs4071!K4071_DatePlan)
    If IsdbNull(rs4071!K4071_DateProduction) = False Then D4071.DateProduction = Trim$(rs4071!K4071_DateProduction)
    If IsdbNull(rs4071!K4071_PartProduction) = False Then D4071.PartProduction = Trim$(rs4071!K4071_PartProduction)
    If IsdbNull(rs4071!K4071_STimeProduction) = False Then D4071.STimeProduction = Trim$(rs4071!K4071_STimeProduction)
    If IsdbNull(rs4071!K4071_ETimeProduction) = False Then D4071.ETimeProduction = Trim$(rs4071!K4071_ETimeProduction)
    If IsdbNull(rs4071!K4071_InchargePlan) = False Then D4071.InchargePlan = Trim$(rs4071!K4071_InchargePlan)
    If IsdbNull(rs4071!K4071_InchargeProdution) = False Then D4071.InchargeProdution = Trim$(rs4071!K4071_InchargeProdution)
    If IsdbNull(rs4071!K4071_QtyBatch) = False Then D4071.QtyBatch = Trim$(rs4071!K4071_QtyBatch)
    If IsdbNull(rs4071!K4071_QtyPlan) = False Then D4071.QtyPlan = Trim$(rs4071!K4071_QtyPlan)

            If IsDBNull(rs4071!K4071_QtyPlanBatch) = False Then D4071.QtyPlanBatch = Trim$(rs4071!K4071_QtyPlanBatch)
            If IsDBNull(rs4071!K4071_QtyPlanBatch1) = False Then D4071.QtyPlanBatch1 = Trim$(rs4071!K4071_QtyPlanBatch1)
            If IsDBNull(rs4071!K4071_QtyPlanBatch2) = False Then D4071.QtyPlanBatch2 = Trim$(rs4071!K4071_QtyPlanBatch2)

            If IsDBNull(rs4071!K4071_QtyPlanBatch3) = False Then D4071.QtyPlanBatch3 = Trim$(rs4071!K4071_QtyPlanBatch3)
            If IsDBNull(rs4071!K4071_QtyPlanBatch4) = False Then D4071.QtyPlanBatch4 = Trim$(rs4071!K4071_QtyPlanBatch4)
            If IsDBNull(rs4071!K4071_QtyPlanBatch5) = False Then D4071.QtyPlanBatch5 = Trim$(rs4071!K4071_QtyPlanBatch5)


    If IsdbNull(rs4071!K4071_QtyProd) = False Then D4071.QtyProd = Trim$(rs4071!K4071_QtyProd)
    If IsdbNull(rs4071!K4071_QtyNormal) = False Then D4071.QtyNormal = Trim$(rs4071!K4071_QtyNormal)
    If IsdbNull(rs4071!K4071_QtyDefect) = False Then D4071.QtyDefect = Trim$(rs4071!K4071_QtyDefect)
    If IsdbNull(rs4071!K4071_QtyDefectPass) = False Then D4071.QtyDefectPass = Trim$(rs4071!K4071_QtyDefectPass)
    If IsdbNull(rs4071!K4071_QtyDefectReject) = False Then D4071.QtyDefectReject = Trim$(rs4071!K4071_QtyDefectReject)
    If IsdbNull(rs4071!K4071_CheckComplete) = False Then D4071.CheckComplete = Trim$(rs4071!K4071_CheckComplete)
    If IsdbNull(rs4071!K4071_CheckTrigger) = False Then D4071.CheckTrigger = Trim$(rs4071!K4071_CheckTrigger)
    If IsdbNull(rs4071!K4071_Remark) = False Then D4071.Remark = Trim$(rs4071!K4071_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K4071_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K4071_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z4071 As T4071_AREA, CDFACTORY AS String, CDMAINPROCESS AS String, MACHINECODE AS String, MACHINETNO AS String, SZNO AS String) as Boolean

K4071_MOVE = False

Try
    If READ_PFK4071(CDFACTORY, CDMAINPROCESS, MACHINECODE, MACHINETNO, SZNO) = True Then
                z4071 = D4071
		K4071_MOVE = True
		else
	z4071 = nothing
     End If

     If  getColumIndex(spr,"cdFactory") > -1 then z4071.cdFactory = getDataM(spr, getColumIndex(spr,"cdFactory"), xRow)
     If  getColumIndex(spr,"cdMainProcess") > -1 then z4071.cdMainProcess = getDataM(spr, getColumIndex(spr,"cdMainProcess"), xRow)
     If  getColumIndex(spr,"MachineCode") > -1 then z4071.MachineCode = getDataM(spr, getColumIndex(spr,"MachineCode"), xRow)
     If  getColumIndex(spr,"MachineTno") > -1 then z4071.MachineTno = getDataM(spr, getColumIndex(spr,"MachineTno"), xRow)
     If  getColumIndex(spr,"Szno") > -1 then z4071.Szno = getDataM(spr, getColumIndex(spr,"Szno"), xRow)
     If  getColumIndex(spr,"seMainProcess") > -1 then z4071.seMainProcess = getDataM(spr, getColumIndex(spr,"seMainProcess"), xRow)
     If  getColumIndex(spr,"seFactory") > -1 then z4071.seFactory = getDataM(spr, getColumIndex(spr,"seFactory"), xRow)
     If  getColumIndex(spr,"JobCard") > -1 then z4071.JobCard = getDataM(spr, getColumIndex(spr,"JobCard"), xRow)
     If  getColumIndex(spr,"WorkOrder") > -1 then z4071.WorkOrder = getDataM(spr, getColumIndex(spr,"WorkOrder"), xRow)
     If  getColumIndex(spr,"WorkOrderSeq") > -1 then z4071.WorkOrderSeq = getDataM(spr, getColumIndex(spr,"WorkOrderSeq"), xRow)
     If  getColumIndex(spr,"DatePlan") > -1 then z4071.DatePlan = getDataM(spr, getColumIndex(spr,"DatePlan"), xRow)
     If  getColumIndex(spr,"DateProduction") > -1 then z4071.DateProduction = getDataM(spr, getColumIndex(spr,"DateProduction"), xRow)
     If  getColumIndex(spr,"PartProduction") > -1 then z4071.PartProduction = getDataM(spr, getColumIndex(spr,"PartProduction"), xRow)
     If  getColumIndex(spr,"STimeProduction") > -1 then z4071.STimeProduction = getDataM(spr, getColumIndex(spr,"STimeProduction"), xRow)
     If  getColumIndex(spr,"ETimeProduction") > -1 then z4071.ETimeProduction = getDataM(spr, getColumIndex(spr,"ETimeProduction"), xRow)
     If  getColumIndex(spr,"InchargePlan") > -1 then z4071.InchargePlan = getDataM(spr, getColumIndex(spr,"InchargePlan"), xRow)
     If  getColumIndex(spr,"InchargeProdution") > -1 then z4071.InchargeProdution = getDataM(spr, getColumIndex(spr,"InchargeProdution"), xRow)
     If  getColumIndex(spr,"QtyBatch") > -1 then z4071.QtyBatch = getDataM(spr, getColumIndex(spr,"QtyBatch"), xRow)
     If  getColumIndex(spr,"QtyPlan") > -1 then z4071.QtyPlan = getDataM(spr, getColumIndex(spr,"QtyPlan"), xRow)

            If getColumIndex(spr, "QtyPlanBatch") > -1 Then z4071.QtyPlanBatch = getDataM(spr, getColumIndex(spr, "QtyPlanBatch"), xRow)
            If getColumIndex(spr, "QtyPlanBatch1") > -1 Then z4071.QtyPlanBatch1 = getDataM(spr, getColumIndex(spr, "QtyPlanBatch1"), xRow)
            If getColumIndex(spr, "QtyPlanBatch2") > -1 Then z4071.QtyPlanBatch2 = getDataM(spr, getColumIndex(spr, "QtyPlanBatch2"), xRow)

            If getColumIndex(spr, "QtyPlanBatch3") > -1 Then z4071.QtyPlanBatch3 = getDataM(spr, getColumIndex(spr, "QtyPlanBatch3"), xRow)
            If getColumIndex(spr, "QtyPlanBatch4") > -1 Then z4071.QtyPlanBatch4 = getDataM(spr, getColumIndex(spr, "QtyPlanBatch4"), xRow)
            If getColumIndex(spr, "QtyPlanBatch5") > -1 Then z4071.QtyPlanBatch5 = getDataM(spr, getColumIndex(spr, "QtyPlanBatch5"), xRow)

     If  getColumIndex(spr,"QtyProd") > -1 then z4071.QtyProd = getDataM(spr, getColumIndex(spr,"QtyProd"), xRow)
     If  getColumIndex(spr,"QtyNormal") > -1 then z4071.QtyNormal = getDataM(spr, getColumIndex(spr,"QtyNormal"), xRow)
     If  getColumIndex(spr,"QtyDefect") > -1 then z4071.QtyDefect = getDataM(spr, getColumIndex(spr,"QtyDefect"), xRow)
     If  getColumIndex(spr,"QtyDefectPass") > -1 then z4071.QtyDefectPass = getDataM(spr, getColumIndex(spr,"QtyDefectPass"), xRow)
     If  getColumIndex(spr,"QtyDefectReject") > -1 then z4071.QtyDefectReject = getDataM(spr, getColumIndex(spr,"QtyDefectReject"), xRow)
     If  getColumIndex(spr,"CheckComplete") > -1 then z4071.CheckComplete = getDataM(spr, getColumIndex(spr,"CheckComplete"), xRow)
     If  getColumIndex(spr,"CheckTrigger") > -1 then z4071.CheckTrigger = getDataM(spr, getColumIndex(spr,"CheckTrigger"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z4071.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K4071_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K4071_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z4071 As T4071_AREA,CheckClear as Boolean,CDFACTORY AS String, CDMAINPROCESS AS String, MACHINECODE AS String, MACHINETNO AS String, SZNO AS String) as Boolean

K4071_MOVE = False

Try
    If READ_PFK4071(CDFACTORY, CDMAINPROCESS, MACHINECODE, MACHINETNO, SZNO) = True Then
                z4071 = D4071
		K4071_MOVE = True
		else
	If CheckClear  = True then z4071 = nothing
     End If

     If  getColumIndex(spr,"cdFactory") > -1 then z4071.cdFactory = getDataM(spr, getColumIndex(spr,"cdFactory"), xRow)
     If  getColumIndex(spr,"cdMainProcess") > -1 then z4071.cdMainProcess = getDataM(spr, getColumIndex(spr,"cdMainProcess"), xRow)
     If  getColumIndex(spr,"MachineCode") > -1 then z4071.MachineCode = getDataM(spr, getColumIndex(spr,"MachineCode"), xRow)
     If  getColumIndex(spr,"MachineTno") > -1 then z4071.MachineTno = getDataM(spr, getColumIndex(spr,"MachineTno"), xRow)
     If  getColumIndex(spr,"Szno") > -1 then z4071.Szno = getDataM(spr, getColumIndex(spr,"Szno"), xRow)
     If  getColumIndex(spr,"seMainProcess") > -1 then z4071.seMainProcess = getDataM(spr, getColumIndex(spr,"seMainProcess"), xRow)
     If  getColumIndex(spr,"seFactory") > -1 then z4071.seFactory = getDataM(spr, getColumIndex(spr,"seFactory"), xRow)
     If  getColumIndex(spr,"JobCard") > -1 then z4071.JobCard = getDataM(spr, getColumIndex(spr,"JobCard"), xRow)
     If  getColumIndex(spr,"WorkOrder") > -1 then z4071.WorkOrder = getDataM(spr, getColumIndex(spr,"WorkOrder"), xRow)
     If  getColumIndex(spr,"WorkOrderSeq") > -1 then z4071.WorkOrderSeq = getDataM(spr, getColumIndex(spr,"WorkOrderSeq"), xRow)
     If  getColumIndex(spr,"DatePlan") > -1 then z4071.DatePlan = getDataM(spr, getColumIndex(spr,"DatePlan"), xRow)
     If  getColumIndex(spr,"DateProduction") > -1 then z4071.DateProduction = getDataM(spr, getColumIndex(spr,"DateProduction"), xRow)
     If  getColumIndex(spr,"PartProduction") > -1 then z4071.PartProduction = getDataM(spr, getColumIndex(spr,"PartProduction"), xRow)
     If  getColumIndex(spr,"STimeProduction") > -1 then z4071.STimeProduction = getDataM(spr, getColumIndex(spr,"STimeProduction"), xRow)
     If  getColumIndex(spr,"ETimeProduction") > -1 then z4071.ETimeProduction = getDataM(spr, getColumIndex(spr,"ETimeProduction"), xRow)
     If  getColumIndex(spr,"InchargePlan") > -1 then z4071.InchargePlan = getDataM(spr, getColumIndex(spr,"InchargePlan"), xRow)
     If  getColumIndex(spr,"InchargeProdution") > -1 then z4071.InchargeProdution = getDataM(spr, getColumIndex(spr,"InchargeProdution"), xRow)
     If  getColumIndex(spr,"QtyBatch") > -1 then z4071.QtyBatch = getDataM(spr, getColumIndex(spr,"QtyBatch"), xRow)
     If  getColumIndex(spr,"QtyPlan") > -1 then z4071.QtyPlan = getDataM(spr, getColumIndex(spr,"QtyPlan"), xRow)

            If getColumIndex(spr, "QtyPlanBatch") > -1 Then z4071.QtyPlanBatch = getDataM(spr, getColumIndex(spr, "QtyPlanBatch"), xRow)
            If getColumIndex(spr, "QtyPlanBatch1") > -1 Then z4071.QtyPlanBatch1 = getDataM(spr, getColumIndex(spr, "QtyPlanBatch1"), xRow)
            If getColumIndex(spr, "QtyPlanBatch2") > -1 Then z4071.QtyPlanBatch2 = getDataM(spr, getColumIndex(spr, "QtyPlanBatch2"), xRow)

            If getColumIndex(spr, "QtyPlanBatch3") > -1 Then z4071.QtyPlanBatch3 = getDataM(spr, getColumIndex(spr, "QtyPlanBatch3"), xRow)
            If getColumIndex(spr, "QtyPlanBatch4") > -1 Then z4071.QtyPlanBatch4 = getDataM(spr, getColumIndex(spr, "QtyPlanBatch4"), xRow)
            If getColumIndex(spr, "QtyPlanBatch5") > -1 Then z4071.QtyPlanBatch5 = getDataM(spr, getColumIndex(spr, "QtyPlanBatch5"), xRow)

     If  getColumIndex(spr,"QtyProd") > -1 then z4071.QtyProd = getDataM(spr, getColumIndex(spr,"QtyProd"), xRow)
     If  getColumIndex(spr,"QtyNormal") > -1 then z4071.QtyNormal = getDataM(spr, getColumIndex(spr,"QtyNormal"), xRow)
     If  getColumIndex(spr,"QtyDefect") > -1 then z4071.QtyDefect = getDataM(spr, getColumIndex(spr,"QtyDefect"), xRow)
     If  getColumIndex(spr,"QtyDefectPass") > -1 then z4071.QtyDefectPass = getDataM(spr, getColumIndex(spr,"QtyDefectPass"), xRow)
     If  getColumIndex(spr,"QtyDefectReject") > -1 then z4071.QtyDefectReject = getDataM(spr, getColumIndex(spr,"QtyDefectReject"), xRow)
     If  getColumIndex(spr,"CheckComplete") > -1 then z4071.CheckComplete = getDataM(spr, getColumIndex(spr,"CheckComplete"), xRow)
     If  getColumIndex(spr,"CheckTrigger") > -1 then z4071.CheckTrigger = getDataM(spr, getColumIndex(spr,"CheckTrigger"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z4071.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K4071_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K4071_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z4071 As T4071_AREA, Job as String, CDFACTORY AS String, CDMAINPROCESS AS String, MACHINECODE AS String, MACHINETNO AS String, SZNO AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K4071_MOVE = False

Try
    If READ_PFK4071(CDFACTORY, CDMAINPROCESS, MACHINECODE, MACHINETNO, SZNO) = True Then
                z4071 = D4071
		K4071_MOVE = True
		else
	z4071 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4071")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "CDFACTORY":z4071.cdFactory = Children(i).Code
   Case "CDMAINPROCESS":z4071.cdMainProcess = Children(i).Code
   Case "MACHINECODE":z4071.MachineCode = Children(i).Code
   Case "MACHINETNO":z4071.MachineTno = Children(i).Code
   Case "SZNO":z4071.Szno = Children(i).Code
   Case "SEMAINPROCESS":z4071.seMainProcess = Children(i).Code
   Case "SEFACTORY":z4071.seFactory = Children(i).Code
   Case "JOBCARD":z4071.JobCard = Children(i).Code
   Case "WORKORDER":z4071.WorkOrder = Children(i).Code
   Case "WORKORDERSEQ":z4071.WorkOrderSeq = Children(i).Code
   Case "DATEPLAN":z4071.DatePlan = Children(i).Code
   Case "DATEPRODUCTION":z4071.DateProduction = Children(i).Code
   Case "PARTPRODUCTION":z4071.PartProduction = Children(i).Code
   Case "STIMEPRODUCTION":z4071.STimeProduction = Children(i).Code
   Case "ETIMEPRODUCTION":z4071.ETimeProduction = Children(i).Code
   Case "INCHARGEPLAN":z4071.InchargePlan = Children(i).Code
   Case "INCHARGEPRODUTION":z4071.InchargeProdution = Children(i).Code
   Case "QTYBATCH":z4071.QtyBatch = Children(i).Code
   Case "QTYPLAN":z4071.QtyPlan = Children(i).Code
                                Case "QTYPLANBATCH" : z4071.QtyPlanBatch = Children(i).Code
                                Case "QTYPLANBATCH1" : z4071.QtyPlanBatch1 = Children(i).Code
                                Case "QTYPLANBATCH2" : z4071.QtyPlanBatch2 = Children(i).Code

                                Case "QTYPLANBATCH3" : z4071.QtyPlanBatch3 = Children(i).Code
                                Case "QTYPLANBATCH4" : z4071.QtyPlanBatch4 = Children(i).Code
                                Case "QTYPLANBATCH5" : z4071.QtyPlanBatch5 = Children(i).Code

   Case "QTYPROD":z4071.QtyProd = Children(i).Code
   Case "QTYNORMAL":z4071.QtyNormal = Children(i).Code
   Case "QTYDEFECT":z4071.QtyDefect = Children(i).Code
   Case "QTYDEFECTPASS":z4071.QtyDefectPass = Children(i).Code
   Case "QTYDEFECTREJECT":z4071.QtyDefectReject = Children(i).Code
   Case "CHECKCOMPLETE":z4071.CheckComplete = Children(i).Code
   Case "CHECKTRIGGER":z4071.CheckTrigger = Children(i).Code
   Case "REMARK":z4071.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "CDFACTORY":z4071.cdFactory = Children(i).Data
   Case "CDMAINPROCESS":z4071.cdMainProcess = Children(i).Data
   Case "MACHINECODE":z4071.MachineCode = Children(i).Data
   Case "MACHINETNO":z4071.MachineTno = Children(i).Data
   Case "SZNO":z4071.Szno = Children(i).Data
   Case "SEMAINPROCESS":z4071.seMainProcess = Children(i).Data
   Case "SEFACTORY":z4071.seFactory = Children(i).Data
   Case "JOBCARD":z4071.JobCard = Children(i).Data
   Case "WORKORDER":z4071.WorkOrder = Children(i).Data
   Case "WORKORDERSEQ":z4071.WorkOrderSeq = Children(i).Data
   Case "DATEPLAN":z4071.DatePlan = Children(i).Data
   Case "DATEPRODUCTION":z4071.DateProduction = Children(i).Data
   Case "PARTPRODUCTION":z4071.PartProduction = Children(i).Data
   Case "STIMEPRODUCTION":z4071.STimeProduction = Children(i).Data
   Case "ETIMEPRODUCTION":z4071.ETimeProduction = Children(i).Data
   Case "INCHARGEPLAN":z4071.InchargePlan = Children(i).Data
   Case "INCHARGEPRODUTION":z4071.InchargeProdution = Children(i).Data
   Case "QTYBATCH":z4071.QtyBatch = Children(i).Data
   Case "QTYPLAN":z4071.QtyPlan = Children(i).Data
                                Case "QTYPLANBATCH" : z4071.QtyPlanBatch = Children(i).Data
                                Case "QTYPLANBATCH1" : z4071.QtyPlanBatch1 = Children(i).Data
                                Case "QTYPLANBATCH2" : z4071.QtyPlanBatch2 = Children(i).Data

                                Case "QTYPLANBATCH3" : z4071.QtyPlanBatch3 = Children(i).Data
                                Case "QTYPLANBATCH4" : z4071.QtyPlanBatch4 = Children(i).Data
                                Case "QTYPLANBATCH5" : z4071.QtyPlanBatch5 = Children(i).Data

   Case "QTYPROD":z4071.QtyProd = Children(i).Data
   Case "QTYNORMAL":z4071.QtyNormal = Children(i).Data
   Case "QTYDEFECT":z4071.QtyDefect = Children(i).Data
   Case "QTYDEFECTPASS":z4071.QtyDefectPass = Children(i).Data
   Case "QTYDEFECTREJECT":z4071.QtyDefectReject = Children(i).Data
   Case "CHECKCOMPLETE":z4071.CheckComplete = Children(i).Data
   Case "CHECKTRIGGER":z4071.CheckTrigger = Children(i).Data
   Case "REMARK":z4071.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K4071_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K4071_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z4071 As T4071_AREA, Job as String, CheckClear as Boolean, CDFACTORY AS String, CDMAINPROCESS AS String, MACHINECODE AS String, MACHINETNO AS String, SZNO AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K4071_MOVE = False

Try
    If READ_PFK4071(CDFACTORY, CDMAINPROCESS, MACHINECODE, MACHINETNO, SZNO) = True Then
                z4071 = D4071
		K4071_MOVE = True
		else
	If CheckClear  = True then z4071 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4071")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "CDFACTORY":z4071.cdFactory = Children(i).Code
   Case "CDMAINPROCESS":z4071.cdMainProcess = Children(i).Code
   Case "MACHINECODE":z4071.MachineCode = Children(i).Code
   Case "MACHINETNO":z4071.MachineTno = Children(i).Code
   Case "SZNO":z4071.Szno = Children(i).Code
   Case "SEMAINPROCESS":z4071.seMainProcess = Children(i).Code
   Case "SEFACTORY":z4071.seFactory = Children(i).Code
   Case "JOBCARD":z4071.JobCard = Children(i).Code
   Case "WORKORDER":z4071.WorkOrder = Children(i).Code
   Case "WORKORDERSEQ":z4071.WorkOrderSeq = Children(i).Code
   Case "DATEPLAN":z4071.DatePlan = Children(i).Code
   Case "DATEPRODUCTION":z4071.DateProduction = Children(i).Code
   Case "PARTPRODUCTION":z4071.PartProduction = Children(i).Code
   Case "STIMEPRODUCTION":z4071.STimeProduction = Children(i).Code
   Case "ETIMEPRODUCTION":z4071.ETimeProduction = Children(i).Code
   Case "INCHARGEPLAN":z4071.InchargePlan = Children(i).Code
   Case "INCHARGEPRODUTION":z4071.InchargeProdution = Children(i).Code
   Case "QTYBATCH":z4071.QtyBatch = Children(i).Code
   Case "QTYPLAN":z4071.QtyPlan = Children(i).Code
                                Case "QTYPLANBATCH" : z4071.QtyPlanBatch = Children(i).Code
                                Case "QTYPLANBATCH1" : z4071.QtyPlanBatch1 = Children(i).Code
                                Case "QTYPLANBATCH2" : z4071.QtyPlanBatch2 = Children(i).Code

                                Case "QTYPLANBATCH3" : z4071.QtyPlanBatch3 = Children(i).Code
                                Case "QTYPLANBATCH4" : z4071.QtyPlanBatch4 = Children(i).Code
                                Case "QTYPLANBATCH5" : z4071.QtyPlanBatch5 = Children(i).Code

   Case "QTYPROD":z4071.QtyProd = Children(i).Code
   Case "QTYNORMAL":z4071.QtyNormal = Children(i).Code
   Case "QTYDEFECT":z4071.QtyDefect = Children(i).Code
   Case "QTYDEFECTPASS":z4071.QtyDefectPass = Children(i).Code
   Case "QTYDEFECTREJECT":z4071.QtyDefectReject = Children(i).Code
   Case "CHECKCOMPLETE":z4071.CheckComplete = Children(i).Code
   Case "CHECKTRIGGER":z4071.CheckTrigger = Children(i).Code
   Case "REMARK":z4071.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "CDFACTORY":z4071.cdFactory = Children(i).Data
   Case "CDMAINPROCESS":z4071.cdMainProcess = Children(i).Data
   Case "MACHINECODE":z4071.MachineCode = Children(i).Data
   Case "MACHINETNO":z4071.MachineTno = Children(i).Data
   Case "SZNO":z4071.Szno = Children(i).Data
   Case "SEMAINPROCESS":z4071.seMainProcess = Children(i).Data
   Case "SEFACTORY":z4071.seFactory = Children(i).Data
   Case "JOBCARD":z4071.JobCard = Children(i).Data
   Case "WORKORDER":z4071.WorkOrder = Children(i).Data
   Case "WORKORDERSEQ":z4071.WorkOrderSeq = Children(i).Data
   Case "DATEPLAN":z4071.DatePlan = Children(i).Data
   Case "DATEPRODUCTION":z4071.DateProduction = Children(i).Data
   Case "PARTPRODUCTION":z4071.PartProduction = Children(i).Data
   Case "STIMEPRODUCTION":z4071.STimeProduction = Children(i).Data
   Case "ETIMEPRODUCTION":z4071.ETimeProduction = Children(i).Data
   Case "INCHARGEPLAN":z4071.InchargePlan = Children(i).Data
   Case "INCHARGEPRODUTION":z4071.InchargeProdution = Children(i).Data
   Case "QTYBATCH":z4071.QtyBatch = Children(i).Data
   Case "QTYPLAN":z4071.QtyPlan = Children(i).Data
                                Case "QTYPLANBATCH" : z4071.QtyPlanBatch = Children(i).Data
                                Case "QTYPLANBATCH1" : z4071.QtyPlanBatch1 = Children(i).Data
                                Case "QTYPLANBATCH2" : z4071.QtyPlanBatch2 = Children(i).Data

                                Case "QTYPLANBATCH3" : z4071.QtyPlanBatch3 = Children(i).Data
                                Case "QTYPLANBATCH4" : z4071.QtyPlanBatch4 = Children(i).Data
                                Case "QTYPLANBATCH5" : z4071.QtyPlanBatch5 = Children(i).Data

   Case "QTYPROD":z4071.QtyProd = Children(i).Data
   Case "QTYNORMAL":z4071.QtyNormal = Children(i).Data
   Case "QTYDEFECT":z4071.QtyDefect = Children(i).Data
   Case "QTYDEFECTPASS":z4071.QtyDefectPass = Children(i).Data
   Case "QTYDEFECTREJECT":z4071.QtyDefectReject = Children(i).Data
   Case "CHECKCOMPLETE":z4071.CheckComplete = Children(i).Data
   Case "CHECKTRIGGER":z4071.CheckTrigger = Children(i).Data
   Case "REMARK":z4071.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K4071_MOVE",vbCritical)
End Try
End Function 
    
End Module 
