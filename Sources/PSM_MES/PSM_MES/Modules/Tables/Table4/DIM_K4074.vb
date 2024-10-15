'=========================================================================================================================================================
'   TABLE : (PFK4074)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K4074

Structure T4074_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	cdFactory	 AS String	'			char(3)		*
Public 	cdMainProcess	 AS String	'			char(3)		*
Public 	cdLineProd	 AS String	'			char(3)		*
Public 	LineTno	 AS String	'			char(2)		*
Public 	Szno	 AS String	'			char(2)		*
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

Public D4074 As T4074_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK4074(CDFACTORY AS String, CDMAINPROCESS AS String, CDLINEPROD AS String, LINETNO AS String, SZNO AS String) As Boolean
    READ_PFK4074 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK4074 "
    SQL = SQL & " WHERE K4074_cdFactory		 = '" & cdFactory & "' " 
    SQL = SQL & "   AND K4074_cdMainProcess		 = '" & cdMainProcess & "' " 
    SQL = SQL & "   AND K4074_cdLineProd		 = '" & cdLineProd & "' " 
    SQL = SQL & "   AND K4074_LineTno		 = '" & LineTno & "' " 
    SQL = SQL & "   AND K4074_Szno		 = '" & Szno & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D4074_CLEAR: GoTo SKIP_READ_PFK4074
                
    Call K4074_MOVE(rd)
    READ_PFK4074 = True

SKIP_READ_PFK4074:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK4074",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK4074(CDFACTORY AS String, CDMAINPROCESS AS String, CDLINEPROD AS String, LINETNO AS String, SZNO AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK4074 "
    SQL = SQL & " WHERE K4074_cdFactory		 = '" & cdFactory & "' " 
    SQL = SQL & "   AND K4074_cdMainProcess		 = '" & cdMainProcess & "' " 
    SQL = SQL & "   AND K4074_cdLineProd		 = '" & cdLineProd & "' " 
    SQL = SQL & "   AND K4074_LineTno		 = '" & LineTno & "' " 
    SQL = SQL & "   AND K4074_Szno		 = '" & Szno & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK4074",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK4074(z4074 As T4074_AREA) As Boolean
    WRITE_PFK4074 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z4074)
 
    SQL = " INSERT INTO PFK4074 "
    SQL = SQL & " ( "
    SQL = SQL & " K4074_cdFactory," 
    SQL = SQL & " K4074_cdMainProcess," 
    SQL = SQL & " K4074_cdLineProd," 
    SQL = SQL & " K4074_LineTno," 
    SQL = SQL & " K4074_Szno," 
    SQL = SQL & " K4074_seMainProcess," 
    SQL = SQL & " K4074_seFactory," 
    SQL = SQL & " K4074_seLineProd," 
    SQL = SQL & " K4074_JobCard," 
    SQL = SQL & " K4074_DatePlan," 
    SQL = SQL & " K4074_DateProduction," 
    SQL = SQL & " K4074_PartProduction," 
    SQL = SQL & " K4074_STimeProduction," 
    SQL = SQL & " K4074_ETimeProduction," 
    SQL = SQL & " K4074_InchargePlan," 
    SQL = SQL & " K4074_InchargeProdution," 
    SQL = SQL & " K4074_QtyPlan," 
    SQL = SQL & " K4074_QtyProd," 
    SQL = SQL & " K4074_QtyNormal," 
    SQL = SQL & " K4074_QtyDefect," 
    SQL = SQL & " K4074_QtyDefectPass," 
    SQL = SQL & " K4074_QtyDefectReject," 
    SQL = SQL & " K4074_CheckComplete," 
    SQL = SQL & " K4074_CheckTrigger," 
    SQL = SQL & " K4074_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z4074.cdFactory) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4074.cdMainProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4074.cdLineProd) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4074.LineTno) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4074.Szno) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4074.seMainProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4074.seFactory) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4074.seLineProd) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4074.JobCard) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4074.DatePlan) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4074.DateProduction) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4074.PartProduction) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4074.STimeProduction) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4074.ETimeProduction) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4074.InchargePlan) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4074.InchargeProdution) & "', "  
    SQL = SQL & "   " & FormatSQL(z4074.QtyPlan) & ", "  
    SQL = SQL & "   " & FormatSQL(z4074.QtyProd) & ", "  
    SQL = SQL & "   " & FormatSQL(z4074.QtyNormal) & ", "  
    SQL = SQL & "   " & FormatSQL(z4074.QtyDefect) & ", "  
    SQL = SQL & "   " & FormatSQL(z4074.QtyDefectPass) & ", "  
    SQL = SQL & "   " & FormatSQL(z4074.QtyDefectReject) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z4074.CheckComplete) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4074.CheckTrigger) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4074.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK4074 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK4074",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK4074(z4074 As T4074_AREA) As Boolean
    REWRITE_PFK4074 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z4074)
   
    SQL = " UPDATE PFK4074 SET "
    SQL = SQL & "    K4074_seMainProcess      = N'" & FormatSQL(z4074.seMainProcess) & "', " 
    SQL = SQL & "    K4074_seFactory      = N'" & FormatSQL(z4074.seFactory) & "', " 
    SQL = SQL & "    K4074_seLineProd      = N'" & FormatSQL(z4074.seLineProd) & "', " 
    SQL = SQL & "    K4074_JobCard      = N'" & FormatSQL(z4074.JobCard) & "', " 
    SQL = SQL & "    K4074_DatePlan      = N'" & FormatSQL(z4074.DatePlan) & "', " 
    SQL = SQL & "    K4074_DateProduction      = N'" & FormatSQL(z4074.DateProduction) & "', " 
    SQL = SQL & "    K4074_PartProduction      = N'" & FormatSQL(z4074.PartProduction) & "', " 
    SQL = SQL & "    K4074_STimeProduction      = N'" & FormatSQL(z4074.STimeProduction) & "', " 
    SQL = SQL & "    K4074_ETimeProduction      = N'" & FormatSQL(z4074.ETimeProduction) & "', " 
    SQL = SQL & "    K4074_InchargePlan      = N'" & FormatSQL(z4074.InchargePlan) & "', " 
    SQL = SQL & "    K4074_InchargeProdution      = N'" & FormatSQL(z4074.InchargeProdution) & "', " 
    SQL = SQL & "    K4074_QtyPlan      =  " & FormatSQL(z4074.QtyPlan) & ", " 
    SQL = SQL & "    K4074_QtyProd      =  " & FormatSQL(z4074.QtyProd) & ", " 
    SQL = SQL & "    K4074_QtyNormal      =  " & FormatSQL(z4074.QtyNormal) & ", " 
    SQL = SQL & "    K4074_QtyDefect      =  " & FormatSQL(z4074.QtyDefect) & ", " 
    SQL = SQL & "    K4074_QtyDefectPass      =  " & FormatSQL(z4074.QtyDefectPass) & ", " 
    SQL = SQL & "    K4074_QtyDefectReject      =  " & FormatSQL(z4074.QtyDefectReject) & ", " 
    SQL = SQL & "    K4074_CheckComplete      = N'" & FormatSQL(z4074.CheckComplete) & "', " 
    SQL = SQL & "    K4074_CheckTrigger      = N'" & FormatSQL(z4074.CheckTrigger) & "', " 
    SQL = SQL & "    K4074_Remark      = N'" & FormatSQL(z4074.Remark) & "'  " 
    SQL = SQL & " WHERE K4074_cdFactory		 = '" & z4074.cdFactory & "' " 
    SQL = SQL & "   AND K4074_cdMainProcess		 = '" & z4074.cdMainProcess & "' " 
    SQL = SQL & "   AND K4074_cdLineProd		 = '" & z4074.cdLineProd & "' " 
    SQL = SQL & "   AND K4074_LineTno		 = '" & z4074.LineTno & "' " 
    SQL = SQL & "   AND K4074_Szno		 = '" & z4074.Szno & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK4074 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK4074",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK4074(z4074 As T4074_AREA) As Boolean
    DELETE_PFK4074 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK4074 "
    SQL = SQL & " WHERE K4074_cdFactory		 = '" & z4074.cdFactory & "' " 
    SQL = SQL & "   AND K4074_cdMainProcess		 = '" & z4074.cdMainProcess & "' " 
    SQL = SQL & "   AND K4074_cdLineProd		 = '" & z4074.cdLineProd & "' " 
    SQL = SQL & "   AND K4074_LineTno		 = '" & z4074.LineTno & "' " 
    SQL = SQL & "   AND K4074_Szno		 = '" & z4074.Szno & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK4074 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK4074",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D4074_CLEAR()
Try
    
   D4074.cdFactory = ""
   D4074.cdMainProcess = ""
   D4074.cdLineProd = ""
   D4074.LineTno = ""
   D4074.Szno = ""
   D4074.seMainProcess = ""
   D4074.seFactory = ""
   D4074.seLineProd = ""
   D4074.JobCard = ""
   D4074.DatePlan = ""
   D4074.DateProduction = ""
   D4074.PartProduction = ""
   D4074.STimeProduction = ""
   D4074.ETimeProduction = ""
   D4074.InchargePlan = ""
   D4074.InchargeProdution = ""
    D4074.QtyPlan = 0 
    D4074.QtyProd = 0 
    D4074.QtyNormal = 0 
    D4074.QtyDefect = 0 
    D4074.QtyDefectPass = 0 
    D4074.QtyDefectReject = 0 
   D4074.CheckComplete = ""
   D4074.CheckTrigger = ""
   D4074.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D4074_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x4074 As T4074_AREA)
Try
    
    x4074.cdFactory = trim$(  x4074.cdFactory)
    x4074.cdMainProcess = trim$(  x4074.cdMainProcess)
    x4074.cdLineProd = trim$(  x4074.cdLineProd)
    x4074.LineTno = trim$(  x4074.LineTno)
    x4074.Szno = trim$(  x4074.Szno)
    x4074.seMainProcess = trim$(  x4074.seMainProcess)
    x4074.seFactory = trim$(  x4074.seFactory)
    x4074.seLineProd = trim$(  x4074.seLineProd)
    x4074.JobCard = trim$(  x4074.JobCard)
    x4074.DatePlan = trim$(  x4074.DatePlan)
    x4074.DateProduction = trim$(  x4074.DateProduction)
    x4074.PartProduction = trim$(  x4074.PartProduction)
    x4074.STimeProduction = trim$(  x4074.STimeProduction)
    x4074.ETimeProduction = trim$(  x4074.ETimeProduction)
    x4074.InchargePlan = trim$(  x4074.InchargePlan)
    x4074.InchargeProdution = trim$(  x4074.InchargeProdution)
    x4074.QtyPlan = trim$(  x4074.QtyPlan)
    x4074.QtyProd = trim$(  x4074.QtyProd)
    x4074.QtyNormal = trim$(  x4074.QtyNormal)
    x4074.QtyDefect = trim$(  x4074.QtyDefect)
    x4074.QtyDefectPass = trim$(  x4074.QtyDefectPass)
    x4074.QtyDefectReject = trim$(  x4074.QtyDefectReject)
    x4074.CheckComplete = trim$(  x4074.CheckComplete)
    x4074.CheckTrigger = trim$(  x4074.CheckTrigger)
    x4074.Remark = trim$(  x4074.Remark)
     
    If trim$( x4074.cdFactory ) = "" Then x4074.cdFactory = Space(1) 
    If trim$( x4074.cdMainProcess ) = "" Then x4074.cdMainProcess = Space(1) 
    If trim$( x4074.cdLineProd ) = "" Then x4074.cdLineProd = Space(1) 
    If trim$( x4074.LineTno ) = "" Then x4074.LineTno = Space(1) 
    If trim$( x4074.Szno ) = "" Then x4074.Szno = Space(1) 
    If trim$( x4074.seMainProcess ) = "" Then x4074.seMainProcess = Space(1) 
    If trim$( x4074.seFactory ) = "" Then x4074.seFactory = Space(1) 
    If trim$( x4074.seLineProd ) = "" Then x4074.seLineProd = Space(1) 
    If trim$( x4074.JobCard ) = "" Then x4074.JobCard = Space(1) 
    If trim$( x4074.DatePlan ) = "" Then x4074.DatePlan = Space(1) 
    If trim$( x4074.DateProduction ) = "" Then x4074.DateProduction = Space(1) 
    If trim$( x4074.PartProduction ) = "" Then x4074.PartProduction = Space(1) 
    If trim$( x4074.STimeProduction ) = "" Then x4074.STimeProduction = Space(1) 
    If trim$( x4074.ETimeProduction ) = "" Then x4074.ETimeProduction = Space(1) 
    If trim$( x4074.InchargePlan ) = "" Then x4074.InchargePlan = Space(1) 
    If trim$( x4074.InchargeProdution ) = "" Then x4074.InchargeProdution = Space(1) 
    If trim$( x4074.QtyPlan ) = "" Then x4074.QtyPlan = 0 
    If trim$( x4074.QtyProd ) = "" Then x4074.QtyProd = 0 
    If trim$( x4074.QtyNormal ) = "" Then x4074.QtyNormal = 0 
    If trim$( x4074.QtyDefect ) = "" Then x4074.QtyDefect = 0 
    If trim$( x4074.QtyDefectPass ) = "" Then x4074.QtyDefectPass = 0 
    If trim$( x4074.QtyDefectReject ) = "" Then x4074.QtyDefectReject = 0 
    If trim$( x4074.CheckComplete ) = "" Then x4074.CheckComplete = Space(1) 
    If trim$( x4074.CheckTrigger ) = "" Then x4074.CheckTrigger = Space(1) 
    If trim$( x4074.Remark ) = "" Then x4074.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K4074_MOVE(rs4074 As SqlClient.SqlDataReader)
Try

    call D4074_CLEAR()   

    If IsdbNull(rs4074!K4074_cdFactory) = False Then D4074.cdFactory = Trim$(rs4074!K4074_cdFactory)
    If IsdbNull(rs4074!K4074_cdMainProcess) = False Then D4074.cdMainProcess = Trim$(rs4074!K4074_cdMainProcess)
    If IsdbNull(rs4074!K4074_cdLineProd) = False Then D4074.cdLineProd = Trim$(rs4074!K4074_cdLineProd)
    If IsdbNull(rs4074!K4074_LineTno) = False Then D4074.LineTno = Trim$(rs4074!K4074_LineTno)
    If IsdbNull(rs4074!K4074_Szno) = False Then D4074.Szno = Trim$(rs4074!K4074_Szno)
    If IsdbNull(rs4074!K4074_seMainProcess) = False Then D4074.seMainProcess = Trim$(rs4074!K4074_seMainProcess)
    If IsdbNull(rs4074!K4074_seFactory) = False Then D4074.seFactory = Trim$(rs4074!K4074_seFactory)
    If IsdbNull(rs4074!K4074_seLineProd) = False Then D4074.seLineProd = Trim$(rs4074!K4074_seLineProd)
    If IsdbNull(rs4074!K4074_JobCard) = False Then D4074.JobCard = Trim$(rs4074!K4074_JobCard)
    If IsdbNull(rs4074!K4074_DatePlan) = False Then D4074.DatePlan = Trim$(rs4074!K4074_DatePlan)
    If IsdbNull(rs4074!K4074_DateProduction) = False Then D4074.DateProduction = Trim$(rs4074!K4074_DateProduction)
    If IsdbNull(rs4074!K4074_PartProduction) = False Then D4074.PartProduction = Trim$(rs4074!K4074_PartProduction)
    If IsdbNull(rs4074!K4074_STimeProduction) = False Then D4074.STimeProduction = Trim$(rs4074!K4074_STimeProduction)
    If IsdbNull(rs4074!K4074_ETimeProduction) = False Then D4074.ETimeProduction = Trim$(rs4074!K4074_ETimeProduction)
    If IsdbNull(rs4074!K4074_InchargePlan) = False Then D4074.InchargePlan = Trim$(rs4074!K4074_InchargePlan)
    If IsdbNull(rs4074!K4074_InchargeProdution) = False Then D4074.InchargeProdution = Trim$(rs4074!K4074_InchargeProdution)
    If IsdbNull(rs4074!K4074_QtyPlan) = False Then D4074.QtyPlan = Trim$(rs4074!K4074_QtyPlan)
    If IsdbNull(rs4074!K4074_QtyProd) = False Then D4074.QtyProd = Trim$(rs4074!K4074_QtyProd)
    If IsdbNull(rs4074!K4074_QtyNormal) = False Then D4074.QtyNormal = Trim$(rs4074!K4074_QtyNormal)
    If IsdbNull(rs4074!K4074_QtyDefect) = False Then D4074.QtyDefect = Trim$(rs4074!K4074_QtyDefect)
    If IsdbNull(rs4074!K4074_QtyDefectPass) = False Then D4074.QtyDefectPass = Trim$(rs4074!K4074_QtyDefectPass)
    If IsdbNull(rs4074!K4074_QtyDefectReject) = False Then D4074.QtyDefectReject = Trim$(rs4074!K4074_QtyDefectReject)
    If IsdbNull(rs4074!K4074_CheckComplete) = False Then D4074.CheckComplete = Trim$(rs4074!K4074_CheckComplete)
    If IsdbNull(rs4074!K4074_CheckTrigger) = False Then D4074.CheckTrigger = Trim$(rs4074!K4074_CheckTrigger)
    If IsdbNull(rs4074!K4074_Remark) = False Then D4074.Remark = Trim$(rs4074!K4074_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K4074_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K4074_MOVE(rs4074 As DataRow)
Try

    call D4074_CLEAR()   

    If IsdbNull(rs4074!K4074_cdFactory) = False Then D4074.cdFactory = Trim$(rs4074!K4074_cdFactory)
    If IsdbNull(rs4074!K4074_cdMainProcess) = False Then D4074.cdMainProcess = Trim$(rs4074!K4074_cdMainProcess)
    If IsdbNull(rs4074!K4074_cdLineProd) = False Then D4074.cdLineProd = Trim$(rs4074!K4074_cdLineProd)
    If IsdbNull(rs4074!K4074_LineTno) = False Then D4074.LineTno = Trim$(rs4074!K4074_LineTno)
    If IsdbNull(rs4074!K4074_Szno) = False Then D4074.Szno = Trim$(rs4074!K4074_Szno)
    If IsdbNull(rs4074!K4074_seMainProcess) = False Then D4074.seMainProcess = Trim$(rs4074!K4074_seMainProcess)
    If IsdbNull(rs4074!K4074_seFactory) = False Then D4074.seFactory = Trim$(rs4074!K4074_seFactory)
    If IsdbNull(rs4074!K4074_seLineProd) = False Then D4074.seLineProd = Trim$(rs4074!K4074_seLineProd)
    If IsdbNull(rs4074!K4074_JobCard) = False Then D4074.JobCard = Trim$(rs4074!K4074_JobCard)
    If IsdbNull(rs4074!K4074_DatePlan) = False Then D4074.DatePlan = Trim$(rs4074!K4074_DatePlan)
    If IsdbNull(rs4074!K4074_DateProduction) = False Then D4074.DateProduction = Trim$(rs4074!K4074_DateProduction)
    If IsdbNull(rs4074!K4074_PartProduction) = False Then D4074.PartProduction = Trim$(rs4074!K4074_PartProduction)
    If IsdbNull(rs4074!K4074_STimeProduction) = False Then D4074.STimeProduction = Trim$(rs4074!K4074_STimeProduction)
    If IsdbNull(rs4074!K4074_ETimeProduction) = False Then D4074.ETimeProduction = Trim$(rs4074!K4074_ETimeProduction)
    If IsdbNull(rs4074!K4074_InchargePlan) = False Then D4074.InchargePlan = Trim$(rs4074!K4074_InchargePlan)
    If IsdbNull(rs4074!K4074_InchargeProdution) = False Then D4074.InchargeProdution = Trim$(rs4074!K4074_InchargeProdution)
    If IsdbNull(rs4074!K4074_QtyPlan) = False Then D4074.QtyPlan = Trim$(rs4074!K4074_QtyPlan)
    If IsdbNull(rs4074!K4074_QtyProd) = False Then D4074.QtyProd = Trim$(rs4074!K4074_QtyProd)
    If IsdbNull(rs4074!K4074_QtyNormal) = False Then D4074.QtyNormal = Trim$(rs4074!K4074_QtyNormal)
    If IsdbNull(rs4074!K4074_QtyDefect) = False Then D4074.QtyDefect = Trim$(rs4074!K4074_QtyDefect)
    If IsdbNull(rs4074!K4074_QtyDefectPass) = False Then D4074.QtyDefectPass = Trim$(rs4074!K4074_QtyDefectPass)
    If IsdbNull(rs4074!K4074_QtyDefectReject) = False Then D4074.QtyDefectReject = Trim$(rs4074!K4074_QtyDefectReject)
    If IsdbNull(rs4074!K4074_CheckComplete) = False Then D4074.CheckComplete = Trim$(rs4074!K4074_CheckComplete)
    If IsdbNull(rs4074!K4074_CheckTrigger) = False Then D4074.CheckTrigger = Trim$(rs4074!K4074_CheckTrigger)
    If IsdbNull(rs4074!K4074_Remark) = False Then D4074.Remark = Trim$(rs4074!K4074_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K4074_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K4074_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z4074 As T4074_AREA, CDFACTORY AS String, CDMAINPROCESS AS String, CDLINEPROD AS String, LINETNO AS String, SZNO AS String) as Boolean

K4074_MOVE = False

Try
    If READ_PFK4074(CDFACTORY, CDMAINPROCESS, CDLINEPROD, LINETNO, SZNO) = True Then
                z4074 = D4074
		K4074_MOVE = True
		else
	z4074 = nothing
     End If

     If  getColumIndex(spr,"cdFactory") > -1 then z4074.cdFactory = getDataM(spr, getColumIndex(spr,"cdFactory"), xRow)
     If  getColumIndex(spr,"cdMainProcess") > -1 then z4074.cdMainProcess = getDataM(spr, getColumIndex(spr,"cdMainProcess"), xRow)
     If  getColumIndex(spr,"cdLineProd") > -1 then z4074.cdLineProd = getDataM(spr, getColumIndex(spr,"cdLineProd"), xRow)
     If  getColumIndex(spr,"LineTno") > -1 then z4074.LineTno = getDataM(spr, getColumIndex(spr,"LineTno"), xRow)
     If  getColumIndex(spr,"Szno") > -1 then z4074.Szno = getDataM(spr, getColumIndex(spr,"Szno"), xRow)
     If  getColumIndex(spr,"seMainProcess") > -1 then z4074.seMainProcess = getDataM(spr, getColumIndex(spr,"seMainProcess"), xRow)
     If  getColumIndex(spr,"seFactory") > -1 then z4074.seFactory = getDataM(spr, getColumIndex(spr,"seFactory"), xRow)
     If  getColumIndex(spr,"seLineProd") > -1 then z4074.seLineProd = getDataM(spr, getColumIndex(spr,"seLineProd"), xRow)
     If  getColumIndex(spr,"JobCard") > -1 then z4074.JobCard = getDataM(spr, getColumIndex(spr,"JobCard"), xRow)
     If  getColumIndex(spr,"DatePlan") > -1 then z4074.DatePlan = getDataM(spr, getColumIndex(spr,"DatePlan"), xRow)
     If  getColumIndex(spr,"DateProduction") > -1 then z4074.DateProduction = getDataM(spr, getColumIndex(spr,"DateProduction"), xRow)
     If  getColumIndex(spr,"PartProduction") > -1 then z4074.PartProduction = getDataM(spr, getColumIndex(spr,"PartProduction"), xRow)
     If  getColumIndex(spr,"STimeProduction") > -1 then z4074.STimeProduction = getDataM(spr, getColumIndex(spr,"STimeProduction"), xRow)
     If  getColumIndex(spr,"ETimeProduction") > -1 then z4074.ETimeProduction = getDataM(spr, getColumIndex(spr,"ETimeProduction"), xRow)
     If  getColumIndex(spr,"InchargePlan") > -1 then z4074.InchargePlan = getDataM(spr, getColumIndex(spr,"InchargePlan"), xRow)
     If  getColumIndex(spr,"InchargeProdution") > -1 then z4074.InchargeProdution = getDataM(spr, getColumIndex(spr,"InchargeProdution"), xRow)
     If  getColumIndex(spr,"QtyPlan") > -1 then z4074.QtyPlan = getDataM(spr, getColumIndex(spr,"QtyPlan"), xRow)
     If  getColumIndex(spr,"QtyProd") > -1 then z4074.QtyProd = getDataM(spr, getColumIndex(spr,"QtyProd"), xRow)
     If  getColumIndex(spr,"QtyNormal") > -1 then z4074.QtyNormal = getDataM(spr, getColumIndex(spr,"QtyNormal"), xRow)
     If  getColumIndex(spr,"QtyDefect") > -1 then z4074.QtyDefect = getDataM(spr, getColumIndex(spr,"QtyDefect"), xRow)
     If  getColumIndex(spr,"QtyDefectPass") > -1 then z4074.QtyDefectPass = getDataM(spr, getColumIndex(spr,"QtyDefectPass"), xRow)
     If  getColumIndex(spr,"QtyDefectReject") > -1 then z4074.QtyDefectReject = getDataM(spr, getColumIndex(spr,"QtyDefectReject"), xRow)
     If  getColumIndex(spr,"CheckComplete") > -1 then z4074.CheckComplete = getDataM(spr, getColumIndex(spr,"CheckComplete"), xRow)
     If  getColumIndex(spr,"CheckTrigger") > -1 then z4074.CheckTrigger = getDataM(spr, getColumIndex(spr,"CheckTrigger"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z4074.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K4074_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K4074_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z4074 As T4074_AREA,CheckClear as Boolean,CDFACTORY AS String, CDMAINPROCESS AS String, CDLINEPROD AS String, LINETNO AS String, SZNO AS String) as Boolean

K4074_MOVE = False

Try
    If READ_PFK4074(CDFACTORY, CDMAINPROCESS, CDLINEPROD, LINETNO, SZNO) = True Then
                z4074 = D4074
		K4074_MOVE = True
		else
	If CheckClear  = True then z4074 = nothing
     End If

     If  getColumIndex(spr,"cdFactory") > -1 then z4074.cdFactory = getDataM(spr, getColumIndex(spr,"cdFactory"), xRow)
     If  getColumIndex(spr,"cdMainProcess") > -1 then z4074.cdMainProcess = getDataM(spr, getColumIndex(spr,"cdMainProcess"), xRow)
     If  getColumIndex(spr,"cdLineProd") > -1 then z4074.cdLineProd = getDataM(spr, getColumIndex(spr,"cdLineProd"), xRow)
     If  getColumIndex(spr,"LineTno") > -1 then z4074.LineTno = getDataM(spr, getColumIndex(spr,"LineTno"), xRow)
     If  getColumIndex(spr,"Szno") > -1 then z4074.Szno = getDataM(spr, getColumIndex(spr,"Szno"), xRow)
     If  getColumIndex(spr,"seMainProcess") > -1 then z4074.seMainProcess = getDataM(spr, getColumIndex(spr,"seMainProcess"), xRow)
     If  getColumIndex(spr,"seFactory") > -1 then z4074.seFactory = getDataM(spr, getColumIndex(spr,"seFactory"), xRow)
     If  getColumIndex(spr,"seLineProd") > -1 then z4074.seLineProd = getDataM(spr, getColumIndex(spr,"seLineProd"), xRow)
     If  getColumIndex(spr,"JobCard") > -1 then z4074.JobCard = getDataM(spr, getColumIndex(spr,"JobCard"), xRow)
     If  getColumIndex(spr,"DatePlan") > -1 then z4074.DatePlan = getDataM(spr, getColumIndex(spr,"DatePlan"), xRow)
     If  getColumIndex(spr,"DateProduction") > -1 then z4074.DateProduction = getDataM(spr, getColumIndex(spr,"DateProduction"), xRow)
     If  getColumIndex(spr,"PartProduction") > -1 then z4074.PartProduction = getDataM(spr, getColumIndex(spr,"PartProduction"), xRow)
     If  getColumIndex(spr,"STimeProduction") > -1 then z4074.STimeProduction = getDataM(spr, getColumIndex(spr,"STimeProduction"), xRow)
     If  getColumIndex(spr,"ETimeProduction") > -1 then z4074.ETimeProduction = getDataM(spr, getColumIndex(spr,"ETimeProduction"), xRow)
     If  getColumIndex(spr,"InchargePlan") > -1 then z4074.InchargePlan = getDataM(spr, getColumIndex(spr,"InchargePlan"), xRow)
     If  getColumIndex(spr,"InchargeProdution") > -1 then z4074.InchargeProdution = getDataM(spr, getColumIndex(spr,"InchargeProdution"), xRow)
     If  getColumIndex(spr,"QtyPlan") > -1 then z4074.QtyPlan = getDataM(spr, getColumIndex(spr,"QtyPlan"), xRow)
     If  getColumIndex(spr,"QtyProd") > -1 then z4074.QtyProd = getDataM(spr, getColumIndex(spr,"QtyProd"), xRow)
     If  getColumIndex(spr,"QtyNormal") > -1 then z4074.QtyNormal = getDataM(spr, getColumIndex(spr,"QtyNormal"), xRow)
     If  getColumIndex(spr,"QtyDefect") > -1 then z4074.QtyDefect = getDataM(spr, getColumIndex(spr,"QtyDefect"), xRow)
     If  getColumIndex(spr,"QtyDefectPass") > -1 then z4074.QtyDefectPass = getDataM(spr, getColumIndex(spr,"QtyDefectPass"), xRow)
     If  getColumIndex(spr,"QtyDefectReject") > -1 then z4074.QtyDefectReject = getDataM(spr, getColumIndex(spr,"QtyDefectReject"), xRow)
     If  getColumIndex(spr,"CheckComplete") > -1 then z4074.CheckComplete = getDataM(spr, getColumIndex(spr,"CheckComplete"), xRow)
     If  getColumIndex(spr,"CheckTrigger") > -1 then z4074.CheckTrigger = getDataM(spr, getColumIndex(spr,"CheckTrigger"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z4074.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K4074_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K4074_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z4074 As T4074_AREA, Job as String, CDFACTORY AS String, CDMAINPROCESS AS String, CDLINEPROD AS String, LINETNO AS String, SZNO AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K4074_MOVE = False

Try
    If READ_PFK4074(CDFACTORY, CDMAINPROCESS, CDLINEPROD, LINETNO, SZNO) = True Then
                z4074 = D4074
		K4074_MOVE = True
		else
	z4074 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4074")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "CDFACTORY":z4074.cdFactory = Children(i).Code
   Case "CDMAINPROCESS":z4074.cdMainProcess = Children(i).Code
   Case "CDLINEPROD":z4074.cdLineProd = Children(i).Code
   Case "LINETNO":z4074.LineTno = Children(i).Code
   Case "SZNO":z4074.Szno = Children(i).Code
   Case "SEMAINPROCESS":z4074.seMainProcess = Children(i).Code
   Case "SEFACTORY":z4074.seFactory = Children(i).Code
   Case "SELINEPROD":z4074.seLineProd = Children(i).Code
   Case "JOBCARD":z4074.JobCard = Children(i).Code
   Case "DATEPLAN":z4074.DatePlan = Children(i).Code
   Case "DATEPRODUCTION":z4074.DateProduction = Children(i).Code
   Case "PARTPRODUCTION":z4074.PartProduction = Children(i).Code
   Case "STIMEPRODUCTION":z4074.STimeProduction = Children(i).Code
   Case "ETIMEPRODUCTION":z4074.ETimeProduction = Children(i).Code
   Case "INCHARGEPLAN":z4074.InchargePlan = Children(i).Code
   Case "INCHARGEPRODUTION":z4074.InchargeProdution = Children(i).Code
   Case "QTYPLAN":z4074.QtyPlan = Children(i).Code
   Case "QTYPROD":z4074.QtyProd = Children(i).Code
   Case "QTYNORMAL":z4074.QtyNormal = Children(i).Code
   Case "QTYDEFECT":z4074.QtyDefect = Children(i).Code
   Case "QTYDEFECTPASS":z4074.QtyDefectPass = Children(i).Code
   Case "QTYDEFECTREJECT":z4074.QtyDefectReject = Children(i).Code
   Case "CHECKCOMPLETE":z4074.CheckComplete = Children(i).Code
   Case "CHECKTRIGGER":z4074.CheckTrigger = Children(i).Code
   Case "REMARK":z4074.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "CDFACTORY":z4074.cdFactory = Children(i).Data
   Case "CDMAINPROCESS":z4074.cdMainProcess = Children(i).Data
   Case "CDLINEPROD":z4074.cdLineProd = Children(i).Data
   Case "LINETNO":z4074.LineTno = Children(i).Data
   Case "SZNO":z4074.Szno = Children(i).Data
   Case "SEMAINPROCESS":z4074.seMainProcess = Children(i).Data
   Case "SEFACTORY":z4074.seFactory = Children(i).Data
   Case "SELINEPROD":z4074.seLineProd = Children(i).Data
   Case "JOBCARD":z4074.JobCard = Children(i).Data
   Case "DATEPLAN":z4074.DatePlan = Children(i).Data
   Case "DATEPRODUCTION":z4074.DateProduction = Children(i).Data
   Case "PARTPRODUCTION":z4074.PartProduction = Children(i).Data
   Case "STIMEPRODUCTION":z4074.STimeProduction = Children(i).Data
   Case "ETIMEPRODUCTION":z4074.ETimeProduction = Children(i).Data
   Case "INCHARGEPLAN":z4074.InchargePlan = Children(i).Data
   Case "INCHARGEPRODUTION":z4074.InchargeProdution = Children(i).Data
   Case "QTYPLAN":z4074.QtyPlan = Children(i).Data
   Case "QTYPROD":z4074.QtyProd = Children(i).Data
   Case "QTYNORMAL":z4074.QtyNormal = Children(i).Data
   Case "QTYDEFECT":z4074.QtyDefect = Children(i).Data
   Case "QTYDEFECTPASS":z4074.QtyDefectPass = Children(i).Data
   Case "QTYDEFECTREJECT":z4074.QtyDefectReject = Children(i).Data
   Case "CHECKCOMPLETE":z4074.CheckComplete = Children(i).Data
   Case "CHECKTRIGGER":z4074.CheckTrigger = Children(i).Data
   Case "REMARK":z4074.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K4074_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K4074_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z4074 As T4074_AREA, Job as String, CheckClear as Boolean, CDFACTORY AS String, CDMAINPROCESS AS String, CDLINEPROD AS String, LINETNO AS String, SZNO AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K4074_MOVE = False

Try
    If READ_PFK4074(CDFACTORY, CDMAINPROCESS, CDLINEPROD, LINETNO, SZNO) = True Then
                z4074 = D4074
		K4074_MOVE = True
		else
	If CheckClear  = True then z4074 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4074")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "CDFACTORY":z4074.cdFactory = Children(i).Code
   Case "CDMAINPROCESS":z4074.cdMainProcess = Children(i).Code
   Case "CDLINEPROD":z4074.cdLineProd = Children(i).Code
   Case "LINETNO":z4074.LineTno = Children(i).Code
   Case "SZNO":z4074.Szno = Children(i).Code
   Case "SEMAINPROCESS":z4074.seMainProcess = Children(i).Code
   Case "SEFACTORY":z4074.seFactory = Children(i).Code
   Case "SELINEPROD":z4074.seLineProd = Children(i).Code
   Case "JOBCARD":z4074.JobCard = Children(i).Code
   Case "DATEPLAN":z4074.DatePlan = Children(i).Code
   Case "DATEPRODUCTION":z4074.DateProduction = Children(i).Code
   Case "PARTPRODUCTION":z4074.PartProduction = Children(i).Code
   Case "STIMEPRODUCTION":z4074.STimeProduction = Children(i).Code
   Case "ETIMEPRODUCTION":z4074.ETimeProduction = Children(i).Code
   Case "INCHARGEPLAN":z4074.InchargePlan = Children(i).Code
   Case "INCHARGEPRODUTION":z4074.InchargeProdution = Children(i).Code
   Case "QTYPLAN":z4074.QtyPlan = Children(i).Code
   Case "QTYPROD":z4074.QtyProd = Children(i).Code
   Case "QTYNORMAL":z4074.QtyNormal = Children(i).Code
   Case "QTYDEFECT":z4074.QtyDefect = Children(i).Code
   Case "QTYDEFECTPASS":z4074.QtyDefectPass = Children(i).Code
   Case "QTYDEFECTREJECT":z4074.QtyDefectReject = Children(i).Code
   Case "CHECKCOMPLETE":z4074.CheckComplete = Children(i).Code
   Case "CHECKTRIGGER":z4074.CheckTrigger = Children(i).Code
   Case "REMARK":z4074.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "CDFACTORY":z4074.cdFactory = Children(i).Data
   Case "CDMAINPROCESS":z4074.cdMainProcess = Children(i).Data
   Case "CDLINEPROD":z4074.cdLineProd = Children(i).Data
   Case "LINETNO":z4074.LineTno = Children(i).Data
   Case "SZNO":z4074.Szno = Children(i).Data
   Case "SEMAINPROCESS":z4074.seMainProcess = Children(i).Data
   Case "SEFACTORY":z4074.seFactory = Children(i).Data
   Case "SELINEPROD":z4074.seLineProd = Children(i).Data
   Case "JOBCARD":z4074.JobCard = Children(i).Data
   Case "DATEPLAN":z4074.DatePlan = Children(i).Data
   Case "DATEPRODUCTION":z4074.DateProduction = Children(i).Data
   Case "PARTPRODUCTION":z4074.PartProduction = Children(i).Data
   Case "STIMEPRODUCTION":z4074.STimeProduction = Children(i).Data
   Case "ETIMEPRODUCTION":z4074.ETimeProduction = Children(i).Data
   Case "INCHARGEPLAN":z4074.InchargePlan = Children(i).Data
   Case "INCHARGEPRODUTION":z4074.InchargeProdution = Children(i).Data
   Case "QTYPLAN":z4074.QtyPlan = Children(i).Data
   Case "QTYPROD":z4074.QtyProd = Children(i).Data
   Case "QTYNORMAL":z4074.QtyNormal = Children(i).Data
   Case "QTYDEFECT":z4074.QtyDefect = Children(i).Data
   Case "QTYDEFECTPASS":z4074.QtyDefectPass = Children(i).Data
   Case "QTYDEFECTREJECT":z4074.QtyDefectReject = Children(i).Data
   Case "CHECKCOMPLETE":z4074.CheckComplete = Children(i).Data
   Case "CHECKTRIGGER":z4074.CheckTrigger = Children(i).Data
   Case "REMARK":z4074.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K4074_MOVE",vbCritical)
End Try
End Function 
    
End Module 
