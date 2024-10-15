'=========================================================================================================================================================
'   TABLE : (PFK4073)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K4073

Structure T4073_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	cdFactory	 AS String	'			char(3)		*
Public 	cdMainProcess	 AS String	'			char(3)		*
Public 	cdLineProd	 AS String	'			char(3)		*
Public 	LineTno	 AS String	'			char(2)		*
Public 	seMainProcess	 AS String	'			char(3)
Public 	seFactory	 AS String	'			char(3)
Public 	seLineProd	 AS String	'			char(3)
Public 	JobCard	 AS String	'			char(9)
Public 	DatePlan	 AS String	'			char(8)
Public 	DateProduction	 AS String	'			char(8)
Public 	PartProduction	 AS String	'			char(1)
Public 	STimeProduction	 AS String	'			nvarchar(20)
Public 	ETimeProduction	 AS String	'			nvarchar(20)
Public 	InchargePlan	 AS String	'			char(8)
Public 	InchargeProdution	 AS String	'			char(8)
Public 	QtyPlan	 AS Double	'			decimal
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

Public D4073 As T4073_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK4073(CDFACTORY AS String, CDMAINPROCESS AS String, CDLINEPROD AS String, LINETNO AS String) As Boolean
    READ_PFK4073 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK4073 "
    SQL = SQL & " WHERE K4073_cdFactory		 = '" & cdFactory & "' " 
    SQL = SQL & "   AND K4073_cdMainProcess		 = '" & cdMainProcess & "' " 
    SQL = SQL & "   AND K4073_cdLineProd		 = '" & cdLineProd & "' " 
    SQL = SQL & "   AND K4073_LineTno		 = '" & LineTno & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D4073_CLEAR: GoTo SKIP_READ_PFK4073
                
    Call K4073_MOVE(rd)
    READ_PFK4073 = True

SKIP_READ_PFK4073:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK4073",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK4073(CDFACTORY AS String, CDMAINPROCESS AS String, CDLINEPROD AS String, LINETNO AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK4073 "
    SQL = SQL & " WHERE K4073_cdFactory		 = '" & cdFactory & "' " 
    SQL = SQL & "   AND K4073_cdMainProcess		 = '" & cdMainProcess & "' " 
    SQL = SQL & "   AND K4073_cdLineProd		 = '" & cdLineProd & "' " 
    SQL = SQL & "   AND K4073_LineTno		 = '" & LineTno & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK4073",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK4073(z4073 As T4073_AREA) As Boolean
    WRITE_PFK4073 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z4073)
 
    SQL = " INSERT INTO PFK4073 "
    SQL = SQL & " ( "
    SQL = SQL & " K4073_cdFactory," 
    SQL = SQL & " K4073_cdMainProcess," 
    SQL = SQL & " K4073_cdLineProd," 
    SQL = SQL & " K4073_LineTno," 
    SQL = SQL & " K4073_seMainProcess," 
    SQL = SQL & " K4073_seFactory," 
    SQL = SQL & " K4073_seLineProd," 
    SQL = SQL & " K4073_JobCard," 
    SQL = SQL & " K4073_DatePlan," 
    SQL = SQL & " K4073_DateProduction," 
    SQL = SQL & " K4073_PartProduction," 
    SQL = SQL & " K4073_STimeProduction," 
    SQL = SQL & " K4073_ETimeProduction," 
    SQL = SQL & " K4073_InchargePlan," 
    SQL = SQL & " K4073_InchargeProdution," 
    SQL = SQL & " K4073_QtyPlan," 
    SQL = SQL & " K4073_QtyProd," 
    SQL = SQL & " K4073_QtyNormal," 
    SQL = SQL & " K4073_QtyDefect," 
    SQL = SQL & " K4073_QtyDefectPass," 
    SQL = SQL & " K4073_QtyDefectReject," 
    SQL = SQL & " K4073_CheckComplete," 
    SQL = SQL & " K4073_CheckTrigger," 
    SQL = SQL & " K4073_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z4073.cdFactory) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4073.cdMainProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4073.cdLineProd) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4073.LineTno) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4073.seMainProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4073.seFactory) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4073.seLineProd) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4073.JobCard) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4073.DatePlan) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4073.DateProduction) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4073.PartProduction) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4073.STimeProduction) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4073.ETimeProduction) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4073.InchargePlan) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4073.InchargeProdution) & "', "  
    SQL = SQL & "   " & FormatSQL(z4073.QtyPlan) & ", "  
    SQL = SQL & "   " & FormatSQL(z4073.QtyProd) & ", "  
    SQL = SQL & "   " & FormatSQL(z4073.QtyNormal) & ", "  
    SQL = SQL & "   " & FormatSQL(z4073.QtyDefect) & ", "  
    SQL = SQL & "   " & FormatSQL(z4073.QtyDefectPass) & ", "  
    SQL = SQL & "   " & FormatSQL(z4073.QtyDefectReject) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z4073.CheckComplete) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4073.CheckTrigger) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4073.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK4073 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK4073",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK4073(z4073 As T4073_AREA) As Boolean
    REWRITE_PFK4073 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z4073)
   
    SQL = " UPDATE PFK4073 SET "
    SQL = SQL & "    K4073_seMainProcess      = N'" & FormatSQL(z4073.seMainProcess) & "', " 
    SQL = SQL & "    K4073_seFactory      = N'" & FormatSQL(z4073.seFactory) & "', " 
    SQL = SQL & "    K4073_seLineProd      = N'" & FormatSQL(z4073.seLineProd) & "', " 
    SQL = SQL & "    K4073_JobCard      = N'" & FormatSQL(z4073.JobCard) & "', " 
    SQL = SQL & "    K4073_DatePlan      = N'" & FormatSQL(z4073.DatePlan) & "', " 
    SQL = SQL & "    K4073_DateProduction      = N'" & FormatSQL(z4073.DateProduction) & "', " 
    SQL = SQL & "    K4073_PartProduction      = N'" & FormatSQL(z4073.PartProduction) & "', " 
    SQL = SQL & "    K4073_STimeProduction      = N'" & FormatSQL(z4073.STimeProduction) & "', " 
    SQL = SQL & "    K4073_ETimeProduction      = N'" & FormatSQL(z4073.ETimeProduction) & "', " 
    SQL = SQL & "    K4073_InchargePlan      = N'" & FormatSQL(z4073.InchargePlan) & "', " 
    SQL = SQL & "    K4073_InchargeProdution      = N'" & FormatSQL(z4073.InchargeProdution) & "', " 
    SQL = SQL & "    K4073_QtyPlan      =  " & FormatSQL(z4073.QtyPlan) & ", " 
    SQL = SQL & "    K4073_QtyProd      =  " & FormatSQL(z4073.QtyProd) & ", " 
    SQL = SQL & "    K4073_QtyNormal      =  " & FormatSQL(z4073.QtyNormal) & ", " 
    SQL = SQL & "    K4073_QtyDefect      =  " & FormatSQL(z4073.QtyDefect) & ", " 
    SQL = SQL & "    K4073_QtyDefectPass      =  " & FormatSQL(z4073.QtyDefectPass) & ", " 
    SQL = SQL & "    K4073_QtyDefectReject      =  " & FormatSQL(z4073.QtyDefectReject) & ", " 
    SQL = SQL & "    K4073_CheckComplete      = N'" & FormatSQL(z4073.CheckComplete) & "', " 
    SQL = SQL & "    K4073_CheckTrigger      = N'" & FormatSQL(z4073.CheckTrigger) & "', " 
    SQL = SQL & "    K4073_Remark      = N'" & FormatSQL(z4073.Remark) & "'  " 
    SQL = SQL & " WHERE K4073_cdFactory		 = '" & z4073.cdFactory & "' " 
    SQL = SQL & "   AND K4073_cdMainProcess		 = '" & z4073.cdMainProcess & "' " 
    SQL = SQL & "   AND K4073_cdLineProd		 = '" & z4073.cdLineProd & "' " 
    SQL = SQL & "   AND K4073_LineTno		 = '" & z4073.LineTno & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK4073 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK4073",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK4073(z4073 As T4073_AREA) As Boolean
    DELETE_PFK4073 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK4073 "
    SQL = SQL & " WHERE K4073_cdFactory		 = '" & z4073.cdFactory & "' " 
    SQL = SQL & "   AND K4073_cdMainProcess		 = '" & z4073.cdMainProcess & "' " 
    SQL = SQL & "   AND K4073_cdLineProd		 = '" & z4073.cdLineProd & "' " 
    SQL = SQL & "   AND K4073_LineTno		 = '" & z4073.LineTno & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK4073 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK4073",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D4073_CLEAR()
Try
    
   D4073.cdFactory = ""
   D4073.cdMainProcess = ""
   D4073.cdLineProd = ""
   D4073.LineTno = ""
   D4073.seMainProcess = ""
   D4073.seFactory = ""
   D4073.seLineProd = ""
   D4073.JobCard = ""
   D4073.DatePlan = ""
   D4073.DateProduction = ""
   D4073.PartProduction = ""
   D4073.STimeProduction = ""
   D4073.ETimeProduction = ""
   D4073.InchargePlan = ""
   D4073.InchargeProdution = ""
    D4073.QtyPlan = 0 
    D4073.QtyProd = 0 
    D4073.QtyNormal = 0 
    D4073.QtyDefect = 0 
    D4073.QtyDefectPass = 0 
    D4073.QtyDefectReject = 0 
   D4073.CheckComplete = ""
   D4073.CheckTrigger = ""
   D4073.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D4073_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x4073 As T4073_AREA)
Try
    
    x4073.cdFactory = trim$(  x4073.cdFactory)
    x4073.cdMainProcess = trim$(  x4073.cdMainProcess)
    x4073.cdLineProd = trim$(  x4073.cdLineProd)
    x4073.LineTno = trim$(  x4073.LineTno)
    x4073.seMainProcess = trim$(  x4073.seMainProcess)
    x4073.seFactory = trim$(  x4073.seFactory)
    x4073.seLineProd = trim$(  x4073.seLineProd)
    x4073.JobCard = trim$(  x4073.JobCard)
    x4073.DatePlan = trim$(  x4073.DatePlan)
    x4073.DateProduction = trim$(  x4073.DateProduction)
    x4073.PartProduction = trim$(  x4073.PartProduction)
    x4073.STimeProduction = trim$(  x4073.STimeProduction)
    x4073.ETimeProduction = trim$(  x4073.ETimeProduction)
    x4073.InchargePlan = trim$(  x4073.InchargePlan)
    x4073.InchargeProdution = trim$(  x4073.InchargeProdution)
    x4073.QtyPlan = trim$(  x4073.QtyPlan)
    x4073.QtyProd = trim$(  x4073.QtyProd)
    x4073.QtyNormal = trim$(  x4073.QtyNormal)
    x4073.QtyDefect = trim$(  x4073.QtyDefect)
    x4073.QtyDefectPass = trim$(  x4073.QtyDefectPass)
    x4073.QtyDefectReject = trim$(  x4073.QtyDefectReject)
    x4073.CheckComplete = trim$(  x4073.CheckComplete)
    x4073.CheckTrigger = trim$(  x4073.CheckTrigger)
    x4073.Remark = trim$(  x4073.Remark)
     
    If trim$( x4073.cdFactory ) = "" Then x4073.cdFactory = Space(1) 
    If trim$( x4073.cdMainProcess ) = "" Then x4073.cdMainProcess = Space(1) 
    If trim$( x4073.cdLineProd ) = "" Then x4073.cdLineProd = Space(1) 
    If trim$( x4073.LineTno ) = "" Then x4073.LineTno = Space(1) 
    If trim$( x4073.seMainProcess ) = "" Then x4073.seMainProcess = Space(1) 
    If trim$( x4073.seFactory ) = "" Then x4073.seFactory = Space(1) 
    If trim$( x4073.seLineProd ) = "" Then x4073.seLineProd = Space(1) 
    If trim$( x4073.JobCard ) = "" Then x4073.JobCard = Space(1) 
    If trim$( x4073.DatePlan ) = "" Then x4073.DatePlan = Space(1) 
    If trim$( x4073.DateProduction ) = "" Then x4073.DateProduction = Space(1) 
    If trim$( x4073.PartProduction ) = "" Then x4073.PartProduction = Space(1) 
    If trim$( x4073.STimeProduction ) = "" Then x4073.STimeProduction = Space(1) 
    If trim$( x4073.ETimeProduction ) = "" Then x4073.ETimeProduction = Space(1) 
    If trim$( x4073.InchargePlan ) = "" Then x4073.InchargePlan = Space(1) 
    If trim$( x4073.InchargeProdution ) = "" Then x4073.InchargeProdution = Space(1) 
    If trim$( x4073.QtyPlan ) = "" Then x4073.QtyPlan = 0 
    If trim$( x4073.QtyProd ) = "" Then x4073.QtyProd = 0 
    If trim$( x4073.QtyNormal ) = "" Then x4073.QtyNormal = 0 
    If trim$( x4073.QtyDefect ) = "" Then x4073.QtyDefect = 0 
    If trim$( x4073.QtyDefectPass ) = "" Then x4073.QtyDefectPass = 0 
    If trim$( x4073.QtyDefectReject ) = "" Then x4073.QtyDefectReject = 0 
    If trim$( x4073.CheckComplete ) = "" Then x4073.CheckComplete = Space(1) 
    If trim$( x4073.CheckTrigger ) = "" Then x4073.CheckTrigger = Space(1) 
    If trim$( x4073.Remark ) = "" Then x4073.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K4073_MOVE(rs4073 As SqlClient.SqlDataReader)
Try

    call D4073_CLEAR()   

    If IsdbNull(rs4073!K4073_cdFactory) = False Then D4073.cdFactory = Trim$(rs4073!K4073_cdFactory)
    If IsdbNull(rs4073!K4073_cdMainProcess) = False Then D4073.cdMainProcess = Trim$(rs4073!K4073_cdMainProcess)
    If IsdbNull(rs4073!K4073_cdLineProd) = False Then D4073.cdLineProd = Trim$(rs4073!K4073_cdLineProd)
    If IsdbNull(rs4073!K4073_LineTno) = False Then D4073.LineTno = Trim$(rs4073!K4073_LineTno)
    If IsdbNull(rs4073!K4073_seMainProcess) = False Then D4073.seMainProcess = Trim$(rs4073!K4073_seMainProcess)
    If IsdbNull(rs4073!K4073_seFactory) = False Then D4073.seFactory = Trim$(rs4073!K4073_seFactory)
    If IsdbNull(rs4073!K4073_seLineProd) = False Then D4073.seLineProd = Trim$(rs4073!K4073_seLineProd)
    If IsdbNull(rs4073!K4073_JobCard) = False Then D4073.JobCard = Trim$(rs4073!K4073_JobCard)
    If IsdbNull(rs4073!K4073_DatePlan) = False Then D4073.DatePlan = Trim$(rs4073!K4073_DatePlan)
    If IsdbNull(rs4073!K4073_DateProduction) = False Then D4073.DateProduction = Trim$(rs4073!K4073_DateProduction)
    If IsdbNull(rs4073!K4073_PartProduction) = False Then D4073.PartProduction = Trim$(rs4073!K4073_PartProduction)
    If IsdbNull(rs4073!K4073_STimeProduction) = False Then D4073.STimeProduction = Trim$(rs4073!K4073_STimeProduction)
    If IsdbNull(rs4073!K4073_ETimeProduction) = False Then D4073.ETimeProduction = Trim$(rs4073!K4073_ETimeProduction)
    If IsdbNull(rs4073!K4073_InchargePlan) = False Then D4073.InchargePlan = Trim$(rs4073!K4073_InchargePlan)
    If IsdbNull(rs4073!K4073_InchargeProdution) = False Then D4073.InchargeProdution = Trim$(rs4073!K4073_InchargeProdution)
    If IsdbNull(rs4073!K4073_QtyPlan) = False Then D4073.QtyPlan = Trim$(rs4073!K4073_QtyPlan)
    If IsdbNull(rs4073!K4073_QtyProd) = False Then D4073.QtyProd = Trim$(rs4073!K4073_QtyProd)
    If IsdbNull(rs4073!K4073_QtyNormal) = False Then D4073.QtyNormal = Trim$(rs4073!K4073_QtyNormal)
    If IsdbNull(rs4073!K4073_QtyDefect) = False Then D4073.QtyDefect = Trim$(rs4073!K4073_QtyDefect)
    If IsdbNull(rs4073!K4073_QtyDefectPass) = False Then D4073.QtyDefectPass = Trim$(rs4073!K4073_QtyDefectPass)
    If IsdbNull(rs4073!K4073_QtyDefectReject) = False Then D4073.QtyDefectReject = Trim$(rs4073!K4073_QtyDefectReject)
    If IsdbNull(rs4073!K4073_CheckComplete) = False Then D4073.CheckComplete = Trim$(rs4073!K4073_CheckComplete)
    If IsdbNull(rs4073!K4073_CheckTrigger) = False Then D4073.CheckTrigger = Trim$(rs4073!K4073_CheckTrigger)
    If IsdbNull(rs4073!K4073_Remark) = False Then D4073.Remark = Trim$(rs4073!K4073_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K4073_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K4073_MOVE(rs4073 As DataRow)
Try

    call D4073_CLEAR()   

    If IsdbNull(rs4073!K4073_cdFactory) = False Then D4073.cdFactory = Trim$(rs4073!K4073_cdFactory)
    If IsdbNull(rs4073!K4073_cdMainProcess) = False Then D4073.cdMainProcess = Trim$(rs4073!K4073_cdMainProcess)
    If IsdbNull(rs4073!K4073_cdLineProd) = False Then D4073.cdLineProd = Trim$(rs4073!K4073_cdLineProd)
    If IsdbNull(rs4073!K4073_LineTno) = False Then D4073.LineTno = Trim$(rs4073!K4073_LineTno)
    If IsdbNull(rs4073!K4073_seMainProcess) = False Then D4073.seMainProcess = Trim$(rs4073!K4073_seMainProcess)
    If IsdbNull(rs4073!K4073_seFactory) = False Then D4073.seFactory = Trim$(rs4073!K4073_seFactory)
    If IsdbNull(rs4073!K4073_seLineProd) = False Then D4073.seLineProd = Trim$(rs4073!K4073_seLineProd)
    If IsdbNull(rs4073!K4073_JobCard) = False Then D4073.JobCard = Trim$(rs4073!K4073_JobCard)
    If IsdbNull(rs4073!K4073_DatePlan) = False Then D4073.DatePlan = Trim$(rs4073!K4073_DatePlan)
    If IsdbNull(rs4073!K4073_DateProduction) = False Then D4073.DateProduction = Trim$(rs4073!K4073_DateProduction)
    If IsdbNull(rs4073!K4073_PartProduction) = False Then D4073.PartProduction = Trim$(rs4073!K4073_PartProduction)
    If IsdbNull(rs4073!K4073_STimeProduction) = False Then D4073.STimeProduction = Trim$(rs4073!K4073_STimeProduction)
    If IsdbNull(rs4073!K4073_ETimeProduction) = False Then D4073.ETimeProduction = Trim$(rs4073!K4073_ETimeProduction)
    If IsdbNull(rs4073!K4073_InchargePlan) = False Then D4073.InchargePlan = Trim$(rs4073!K4073_InchargePlan)
    If IsdbNull(rs4073!K4073_InchargeProdution) = False Then D4073.InchargeProdution = Trim$(rs4073!K4073_InchargeProdution)
    If IsdbNull(rs4073!K4073_QtyPlan) = False Then D4073.QtyPlan = Trim$(rs4073!K4073_QtyPlan)
    If IsdbNull(rs4073!K4073_QtyProd) = False Then D4073.QtyProd = Trim$(rs4073!K4073_QtyProd)
    If IsdbNull(rs4073!K4073_QtyNormal) = False Then D4073.QtyNormal = Trim$(rs4073!K4073_QtyNormal)
    If IsdbNull(rs4073!K4073_QtyDefect) = False Then D4073.QtyDefect = Trim$(rs4073!K4073_QtyDefect)
    If IsdbNull(rs4073!K4073_QtyDefectPass) = False Then D4073.QtyDefectPass = Trim$(rs4073!K4073_QtyDefectPass)
    If IsdbNull(rs4073!K4073_QtyDefectReject) = False Then D4073.QtyDefectReject = Trim$(rs4073!K4073_QtyDefectReject)
    If IsdbNull(rs4073!K4073_CheckComplete) = False Then D4073.CheckComplete = Trim$(rs4073!K4073_CheckComplete)
    If IsdbNull(rs4073!K4073_CheckTrigger) = False Then D4073.CheckTrigger = Trim$(rs4073!K4073_CheckTrigger)
    If IsdbNull(rs4073!K4073_Remark) = False Then D4073.Remark = Trim$(rs4073!K4073_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K4073_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K4073_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z4073 As T4073_AREA, CDFACTORY AS String, CDMAINPROCESS AS String, CDLINEPROD AS String, LINETNO AS String) as Boolean

K4073_MOVE = False

Try
    If READ_PFK4073(CDFACTORY, CDMAINPROCESS, CDLINEPROD, LINETNO) = True Then
                z4073 = D4073
		K4073_MOVE = True
		else
	z4073 = nothing
     End If

     If  getColumIndex(spr,"cdFactory") > -1 then z4073.cdFactory = getDataM(spr, getColumIndex(spr,"cdFactory"), xRow)
     If  getColumIndex(spr,"cdMainProcess") > -1 then z4073.cdMainProcess = getDataM(spr, getColumIndex(spr,"cdMainProcess"), xRow)
     If  getColumIndex(spr,"cdLineProd") > -1 then z4073.cdLineProd = getDataM(spr, getColumIndex(spr,"cdLineProd"), xRow)
     If  getColumIndex(spr,"LineTno") > -1 then z4073.LineTno = getDataM(spr, getColumIndex(spr,"LineTno"), xRow)
     If  getColumIndex(spr,"seMainProcess") > -1 then z4073.seMainProcess = getDataM(spr, getColumIndex(spr,"seMainProcess"), xRow)
     If  getColumIndex(spr,"seFactory") > -1 then z4073.seFactory = getDataM(spr, getColumIndex(spr,"seFactory"), xRow)
     If  getColumIndex(spr,"seLineProd") > -1 then z4073.seLineProd = getDataM(spr, getColumIndex(spr,"seLineProd"), xRow)
     If  getColumIndex(spr,"JobCard") > -1 then z4073.JobCard = getDataM(spr, getColumIndex(spr,"JobCard"), xRow)
     If  getColumIndex(spr,"DatePlan") > -1 then z4073.DatePlan = getDataM(spr, getColumIndex(spr,"DatePlan"), xRow)
     If  getColumIndex(spr,"DateProduction") > -1 then z4073.DateProduction = getDataM(spr, getColumIndex(spr,"DateProduction"), xRow)
     If  getColumIndex(spr,"PartProduction") > -1 then z4073.PartProduction = getDataM(spr, getColumIndex(spr,"PartProduction"), xRow)
     If  getColumIndex(spr,"STimeProduction") > -1 then z4073.STimeProduction = getDataM(spr, getColumIndex(spr,"STimeProduction"), xRow)
     If  getColumIndex(spr,"ETimeProduction") > -1 then z4073.ETimeProduction = getDataM(spr, getColumIndex(spr,"ETimeProduction"), xRow)
     If  getColumIndex(spr,"InchargePlan") > -1 then z4073.InchargePlan = getDataM(spr, getColumIndex(spr,"InchargePlan"), xRow)
     If  getColumIndex(spr,"InchargeProdution") > -1 then z4073.InchargeProdution = getDataM(spr, getColumIndex(spr,"InchargeProdution"), xRow)
     If  getColumIndex(spr,"QtyPlan") > -1 then z4073.QtyPlan = getDataM(spr, getColumIndex(spr,"QtyPlan"), xRow)
     If  getColumIndex(spr,"QtyProd") > -1 then z4073.QtyProd = getDataM(spr, getColumIndex(spr,"QtyProd"), xRow)
     If  getColumIndex(spr,"QtyNormal") > -1 then z4073.QtyNormal = getDataM(spr, getColumIndex(spr,"QtyNormal"), xRow)
     If  getColumIndex(spr,"QtyDefect") > -1 then z4073.QtyDefect = getDataM(spr, getColumIndex(spr,"QtyDefect"), xRow)
     If  getColumIndex(spr,"QtyDefectPass") > -1 then z4073.QtyDefectPass = getDataM(spr, getColumIndex(spr,"QtyDefectPass"), xRow)
     If  getColumIndex(spr,"QtyDefectReject") > -1 then z4073.QtyDefectReject = getDataM(spr, getColumIndex(spr,"QtyDefectReject"), xRow)
     If  getColumIndex(spr,"CheckComplete") > -1 then z4073.CheckComplete = getDataM(spr, getColumIndex(spr,"CheckComplete"), xRow)
     If  getColumIndex(spr,"CheckTrigger") > -1 then z4073.CheckTrigger = getDataM(spr, getColumIndex(spr,"CheckTrigger"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z4073.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K4073_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K4073_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z4073 As T4073_AREA,CheckClear as Boolean,CDFACTORY AS String, CDMAINPROCESS AS String, CDLINEPROD AS String, LINETNO AS String) as Boolean

K4073_MOVE = False

Try
    If READ_PFK4073(CDFACTORY, CDMAINPROCESS, CDLINEPROD, LINETNO) = True Then
                z4073 = D4073
		K4073_MOVE = True
		else
	If CheckClear  = True then z4073 = nothing
     End If

     If  getColumIndex(spr,"cdFactory") > -1 then z4073.cdFactory = getDataM(spr, getColumIndex(spr,"cdFactory"), xRow)
     If  getColumIndex(spr,"cdMainProcess") > -1 then z4073.cdMainProcess = getDataM(spr, getColumIndex(spr,"cdMainProcess"), xRow)
     If  getColumIndex(spr,"cdLineProd") > -1 then z4073.cdLineProd = getDataM(spr, getColumIndex(spr,"cdLineProd"), xRow)
     If  getColumIndex(spr,"LineTno") > -1 then z4073.LineTno = getDataM(spr, getColumIndex(spr,"LineTno"), xRow)
     If  getColumIndex(spr,"seMainProcess") > -1 then z4073.seMainProcess = getDataM(spr, getColumIndex(spr,"seMainProcess"), xRow)
     If  getColumIndex(spr,"seFactory") > -1 then z4073.seFactory = getDataM(spr, getColumIndex(spr,"seFactory"), xRow)
     If  getColumIndex(spr,"seLineProd") > -1 then z4073.seLineProd = getDataM(spr, getColumIndex(spr,"seLineProd"), xRow)
     If  getColumIndex(spr,"JobCard") > -1 then z4073.JobCard = getDataM(spr, getColumIndex(spr,"JobCard"), xRow)
     If  getColumIndex(spr,"DatePlan") > -1 then z4073.DatePlan = getDataM(spr, getColumIndex(spr,"DatePlan"), xRow)
     If  getColumIndex(spr,"DateProduction") > -1 then z4073.DateProduction = getDataM(spr, getColumIndex(spr,"DateProduction"), xRow)
     If  getColumIndex(spr,"PartProduction") > -1 then z4073.PartProduction = getDataM(spr, getColumIndex(spr,"PartProduction"), xRow)
     If  getColumIndex(spr,"STimeProduction") > -1 then z4073.STimeProduction = getDataM(spr, getColumIndex(spr,"STimeProduction"), xRow)
     If  getColumIndex(spr,"ETimeProduction") > -1 then z4073.ETimeProduction = getDataM(spr, getColumIndex(spr,"ETimeProduction"), xRow)
     If  getColumIndex(spr,"InchargePlan") > -1 then z4073.InchargePlan = getDataM(spr, getColumIndex(spr,"InchargePlan"), xRow)
     If  getColumIndex(spr,"InchargeProdution") > -1 then z4073.InchargeProdution = getDataM(spr, getColumIndex(spr,"InchargeProdution"), xRow)
     If  getColumIndex(spr,"QtyPlan") > -1 then z4073.QtyPlan = getDataM(spr, getColumIndex(spr,"QtyPlan"), xRow)
     If  getColumIndex(spr,"QtyProd") > -1 then z4073.QtyProd = getDataM(spr, getColumIndex(spr,"QtyProd"), xRow)
     If  getColumIndex(spr,"QtyNormal") > -1 then z4073.QtyNormal = getDataM(spr, getColumIndex(spr,"QtyNormal"), xRow)
     If  getColumIndex(spr,"QtyDefect") > -1 then z4073.QtyDefect = getDataM(spr, getColumIndex(spr,"QtyDefect"), xRow)
     If  getColumIndex(spr,"QtyDefectPass") > -1 then z4073.QtyDefectPass = getDataM(spr, getColumIndex(spr,"QtyDefectPass"), xRow)
     If  getColumIndex(spr,"QtyDefectReject") > -1 then z4073.QtyDefectReject = getDataM(spr, getColumIndex(spr,"QtyDefectReject"), xRow)
     If  getColumIndex(spr,"CheckComplete") > -1 then z4073.CheckComplete = getDataM(spr, getColumIndex(spr,"CheckComplete"), xRow)
     If  getColumIndex(spr,"CheckTrigger") > -1 then z4073.CheckTrigger = getDataM(spr, getColumIndex(spr,"CheckTrigger"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z4073.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K4073_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K4073_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z4073 As T4073_AREA, Job as String, CDFACTORY AS String, CDMAINPROCESS AS String, CDLINEPROD AS String, LINETNO AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K4073_MOVE = False

Try
    If READ_PFK4073(CDFACTORY, CDMAINPROCESS, CDLINEPROD, LINETNO) = True Then
                z4073 = D4073
		K4073_MOVE = True
		else
	z4073 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4073")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "CDFACTORY":z4073.cdFactory = Children(i).Code
   Case "CDMAINPROCESS":z4073.cdMainProcess = Children(i).Code
   Case "CDLINEPROD":z4073.cdLineProd = Children(i).Code
   Case "LINETNO":z4073.LineTno = Children(i).Code
   Case "SEMAINPROCESS":z4073.seMainProcess = Children(i).Code
   Case "SEFACTORY":z4073.seFactory = Children(i).Code
   Case "SELINEPROD":z4073.seLineProd = Children(i).Code
   Case "JOBCARD":z4073.JobCard = Children(i).Code
   Case "DATEPLAN":z4073.DatePlan = Children(i).Code
   Case "DATEPRODUCTION":z4073.DateProduction = Children(i).Code
   Case "PARTPRODUCTION":z4073.PartProduction = Children(i).Code
   Case "STIMEPRODUCTION":z4073.STimeProduction = Children(i).Code
   Case "ETIMEPRODUCTION":z4073.ETimeProduction = Children(i).Code
   Case "INCHARGEPLAN":z4073.InchargePlan = Children(i).Code
   Case "INCHARGEPRODUTION":z4073.InchargeProdution = Children(i).Code
   Case "QTYPLAN":z4073.QtyPlan = Children(i).Code
   Case "QTYPROD":z4073.QtyProd = Children(i).Code
   Case "QTYNORMAL":z4073.QtyNormal = Children(i).Code
   Case "QTYDEFECT":z4073.QtyDefect = Children(i).Code
   Case "QTYDEFECTPASS":z4073.QtyDefectPass = Children(i).Code
   Case "QTYDEFECTREJECT":z4073.QtyDefectReject = Children(i).Code
   Case "CHECKCOMPLETE":z4073.CheckComplete = Children(i).Code
   Case "CHECKTRIGGER":z4073.CheckTrigger = Children(i).Code
   Case "REMARK":z4073.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "CDFACTORY":z4073.cdFactory = Children(i).Data
   Case "CDMAINPROCESS":z4073.cdMainProcess = Children(i).Data
   Case "CDLINEPROD":z4073.cdLineProd = Children(i).Data
   Case "LINETNO":z4073.LineTno = Children(i).Data
   Case "SEMAINPROCESS":z4073.seMainProcess = Children(i).Data
   Case "SEFACTORY":z4073.seFactory = Children(i).Data
   Case "SELINEPROD":z4073.seLineProd = Children(i).Data
   Case "JOBCARD":z4073.JobCard = Children(i).Data
   Case "DATEPLAN":z4073.DatePlan = Children(i).Data
   Case "DATEPRODUCTION":z4073.DateProduction = Children(i).Data
   Case "PARTPRODUCTION":z4073.PartProduction = Children(i).Data
   Case "STIMEPRODUCTION":z4073.STimeProduction = Children(i).Data
   Case "ETIMEPRODUCTION":z4073.ETimeProduction = Children(i).Data
   Case "INCHARGEPLAN":z4073.InchargePlan = Children(i).Data
   Case "INCHARGEPRODUTION":z4073.InchargeProdution = Children(i).Data
   Case "QTYPLAN":z4073.QtyPlan = Children(i).Data
   Case "QTYPROD":z4073.QtyProd = Children(i).Data
   Case "QTYNORMAL":z4073.QtyNormal = Children(i).Data
   Case "QTYDEFECT":z4073.QtyDefect = Children(i).Data
   Case "QTYDEFECTPASS":z4073.QtyDefectPass = Children(i).Data
   Case "QTYDEFECTREJECT":z4073.QtyDefectReject = Children(i).Data
   Case "CHECKCOMPLETE":z4073.CheckComplete = Children(i).Data
   Case "CHECKTRIGGER":z4073.CheckTrigger = Children(i).Data
   Case "REMARK":z4073.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K4073_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K4073_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z4073 As T4073_AREA, Job as String, CheckClear as Boolean, CDFACTORY AS String, CDMAINPROCESS AS String, CDLINEPROD AS String, LINETNO AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K4073_MOVE = False

Try
    If READ_PFK4073(CDFACTORY, CDMAINPROCESS, CDLINEPROD, LINETNO) = True Then
                z4073 = D4073
		K4073_MOVE = True
		else
	If CheckClear  = True then z4073 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4073")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "CDFACTORY":z4073.cdFactory = Children(i).Code
   Case "CDMAINPROCESS":z4073.cdMainProcess = Children(i).Code
   Case "CDLINEPROD":z4073.cdLineProd = Children(i).Code
   Case "LINETNO":z4073.LineTno = Children(i).Code
   Case "SEMAINPROCESS":z4073.seMainProcess = Children(i).Code
   Case "SEFACTORY":z4073.seFactory = Children(i).Code
   Case "SELINEPROD":z4073.seLineProd = Children(i).Code
   Case "JOBCARD":z4073.JobCard = Children(i).Code
   Case "DATEPLAN":z4073.DatePlan = Children(i).Code
   Case "DATEPRODUCTION":z4073.DateProduction = Children(i).Code
   Case "PARTPRODUCTION":z4073.PartProduction = Children(i).Code
   Case "STIMEPRODUCTION":z4073.STimeProduction = Children(i).Code
   Case "ETIMEPRODUCTION":z4073.ETimeProduction = Children(i).Code
   Case "INCHARGEPLAN":z4073.InchargePlan = Children(i).Code
   Case "INCHARGEPRODUTION":z4073.InchargeProdution = Children(i).Code
   Case "QTYPLAN":z4073.QtyPlan = Children(i).Code
   Case "QTYPROD":z4073.QtyProd = Children(i).Code
   Case "QTYNORMAL":z4073.QtyNormal = Children(i).Code
   Case "QTYDEFECT":z4073.QtyDefect = Children(i).Code
   Case "QTYDEFECTPASS":z4073.QtyDefectPass = Children(i).Code
   Case "QTYDEFECTREJECT":z4073.QtyDefectReject = Children(i).Code
   Case "CHECKCOMPLETE":z4073.CheckComplete = Children(i).Code
   Case "CHECKTRIGGER":z4073.CheckTrigger = Children(i).Code
   Case "REMARK":z4073.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "CDFACTORY":z4073.cdFactory = Children(i).Data
   Case "CDMAINPROCESS":z4073.cdMainProcess = Children(i).Data
   Case "CDLINEPROD":z4073.cdLineProd = Children(i).Data
   Case "LINETNO":z4073.LineTno = Children(i).Data
   Case "SEMAINPROCESS":z4073.seMainProcess = Children(i).Data
   Case "SEFACTORY":z4073.seFactory = Children(i).Data
   Case "SELINEPROD":z4073.seLineProd = Children(i).Data
   Case "JOBCARD":z4073.JobCard = Children(i).Data
   Case "DATEPLAN":z4073.DatePlan = Children(i).Data
   Case "DATEPRODUCTION":z4073.DateProduction = Children(i).Data
   Case "PARTPRODUCTION":z4073.PartProduction = Children(i).Data
   Case "STIMEPRODUCTION":z4073.STimeProduction = Children(i).Data
   Case "ETIMEPRODUCTION":z4073.ETimeProduction = Children(i).Data
   Case "INCHARGEPLAN":z4073.InchargePlan = Children(i).Data
   Case "INCHARGEPRODUTION":z4073.InchargeProdution = Children(i).Data
   Case "QTYPLAN":z4073.QtyPlan = Children(i).Data
   Case "QTYPROD":z4073.QtyProd = Children(i).Data
   Case "QTYNORMAL":z4073.QtyNormal = Children(i).Data
   Case "QTYDEFECT":z4073.QtyDefect = Children(i).Data
   Case "QTYDEFECTPASS":z4073.QtyDefectPass = Children(i).Data
   Case "QTYDEFECTREJECT":z4073.QtyDefectReject = Children(i).Data
   Case "CHECKCOMPLETE":z4073.CheckComplete = Children(i).Data
   Case "CHECKTRIGGER":z4073.CheckTrigger = Children(i).Data
   Case "REMARK":z4073.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K4073_MOVE",vbCritical)
End Try
End Function 
    
End Module 
