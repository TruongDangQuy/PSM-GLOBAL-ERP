'=========================================================================================================================================================
'   TABLE : (PFK0174)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K0174

Structure T0174_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	AUTOKEY	 AS Double	'			decimal		*
Public 	DateBackup	 AS String	'			char(8)
Public 	TimeBackup	 AS String	'			char(14)
Public 	cdFactory	 AS String	'			char(3)
Public 	cdMainProcess	 AS String	'			char(3)
Public 	cdLineProd	 AS String	'			char(3)
Public 	seMainProcess	 AS String	'			char(3)
Public 	seFactory	 AS String	'			char(3)
Public 	seLineProd	 AS String	'			char(3)
Public 	LineTno	 AS String	'			char(2)
Public 	Szno	 AS String	'			char(2)
Public 	SpecNo	 AS String	'			char(9)
Public 	SpecNoSeq	 AS String	'			char(3)
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

Public D0174 As T0174_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK0174(AUTOKEY AS Double) As Boolean
    READ_PFK0174 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK0174 "
    SQL = SQL & " WHERE K0174_AUTOKEY		 =  " & AUTOKEY & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D0174_CLEAR: GoTo SKIP_READ_PFK0174
                
    Call K0174_MOVE(rd)
    READ_PFK0174 = True

SKIP_READ_PFK0174:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK0174",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK0174(AUTOKEY AS Double, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK0174 "
    SQL = SQL & " WHERE K0174_AUTOKEY		 =  " & AUTOKEY & "  " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK0174",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK0174(z0174 As T0174_AREA) As Boolean
    WRITE_PFK0174 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z0174)
 
    SQL = " INSERT INTO PFK0174 "
    SQL = SQL & " ( "
    SQL = SQL & " K0174_AUTOKEY," 
    SQL = SQL & " K0174_DateBackup," 
    SQL = SQL & " K0174_TimeBackup," 
    SQL = SQL & " K0174_cdFactory," 
    SQL = SQL & " K0174_cdMainProcess," 
    SQL = SQL & " K0174_cdLineProd," 
    SQL = SQL & " K0174_seMainProcess," 
    SQL = SQL & " K0174_seFactory," 
    SQL = SQL & " K0174_seLineProd," 
    SQL = SQL & " K0174_LineTno," 
    SQL = SQL & " K0174_Szno," 
    SQL = SQL & " K0174_SpecNo," 
    SQL = SQL & " K0174_SpecNoSeq," 
    SQL = SQL & " K0174_DatePlan," 
    SQL = SQL & " K0174_DateProduction," 
    SQL = SQL & " K0174_PartProduction," 
    SQL = SQL & " K0174_STimeProduction," 
    SQL = SQL & " K0174_ETimeProduction," 
    SQL = SQL & " K0174_InchargePlan," 
    SQL = SQL & " K0174_InchargeProdution," 
    SQL = SQL & " K0174_QtyPlan," 
    SQL = SQL & " K0174_QtyProd," 
    SQL = SQL & " K0174_QtyNormal," 
    SQL = SQL & " K0174_QtyDefect," 
    SQL = SQL & " K0174_QtyDefectPass," 
    SQL = SQL & " K0174_QtyDefectReject," 
    SQL = SQL & " K0174_CheckComplete," 
    SQL = SQL & " K0174_CheckTrigger," 
    SQL = SQL & " K0174_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "   " & FormatSQL(z0174.AUTOKEY) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z0174.DateBackup) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0174.TimeBackup) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0174.cdFactory) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0174.cdMainProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0174.cdLineProd) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0174.seMainProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0174.seFactory) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0174.seLineProd) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0174.LineTno) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0174.Szno) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0174.SpecNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0174.SpecNoSeq) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0174.DatePlan) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0174.DateProduction) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0174.PartProduction) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0174.STimeProduction) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0174.ETimeProduction) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0174.InchargePlan) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0174.InchargeProdution) & "', "  
    SQL = SQL & "   " & FormatSQL(z0174.QtyPlan) & ", "  
    SQL = SQL & "   " & FormatSQL(z0174.QtyProd) & ", "  
    SQL = SQL & "   " & FormatSQL(z0174.QtyNormal) & ", "  
    SQL = SQL & "   " & FormatSQL(z0174.QtyDefect) & ", "  
    SQL = SQL & "   " & FormatSQL(z0174.QtyDefectPass) & ", "  
    SQL = SQL & "   " & FormatSQL(z0174.QtyDefectReject) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z0174.CheckComplete) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0174.CheckTrigger) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0174.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK0174 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK0174",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK0174(z0174 As T0174_AREA) As Boolean
    REWRITE_PFK0174 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z0174)
   
    SQL = " UPDATE PFK0174 SET "
    SQL = SQL & "    K0174_DateBackup      = N'" & FormatSQL(z0174.DateBackup) & "', " 
    SQL = SQL & "    K0174_TimeBackup      = N'" & FormatSQL(z0174.TimeBackup) & "', " 
    SQL = SQL & "    K0174_cdFactory      = N'" & FormatSQL(z0174.cdFactory) & "', " 
    SQL = SQL & "    K0174_cdMainProcess      = N'" & FormatSQL(z0174.cdMainProcess) & "', " 
    SQL = SQL & "    K0174_cdLineProd      = N'" & FormatSQL(z0174.cdLineProd) & "', " 
    SQL = SQL & "    K0174_seMainProcess      = N'" & FormatSQL(z0174.seMainProcess) & "', " 
    SQL = SQL & "    K0174_seFactory      = N'" & FormatSQL(z0174.seFactory) & "', " 
    SQL = SQL & "    K0174_seLineProd      = N'" & FormatSQL(z0174.seLineProd) & "', " 
    SQL = SQL & "    K0174_LineTno      = N'" & FormatSQL(z0174.LineTno) & "', " 
    SQL = SQL & "    K0174_Szno      = N'" & FormatSQL(z0174.Szno) & "', " 
    SQL = SQL & "    K0174_SpecNo      = N'" & FormatSQL(z0174.SpecNo) & "', " 
    SQL = SQL & "    K0174_SpecNoSeq      = N'" & FormatSQL(z0174.SpecNoSeq) & "', " 
    SQL = SQL & "    K0174_DatePlan      = N'" & FormatSQL(z0174.DatePlan) & "', " 
    SQL = SQL & "    K0174_DateProduction      = N'" & FormatSQL(z0174.DateProduction) & "', " 
    SQL = SQL & "    K0174_PartProduction      = N'" & FormatSQL(z0174.PartProduction) & "', " 
    SQL = SQL & "    K0174_STimeProduction      = N'" & FormatSQL(z0174.STimeProduction) & "', " 
    SQL = SQL & "    K0174_ETimeProduction      = N'" & FormatSQL(z0174.ETimeProduction) & "', " 
    SQL = SQL & "    K0174_InchargePlan      = N'" & FormatSQL(z0174.InchargePlan) & "', " 
    SQL = SQL & "    K0174_InchargeProdution      = N'" & FormatSQL(z0174.InchargeProdution) & "', " 
    SQL = SQL & "    K0174_QtyPlan      =  " & FormatSQL(z0174.QtyPlan) & ", " 
    SQL = SQL & "    K0174_QtyProd      =  " & FormatSQL(z0174.QtyProd) & ", " 
    SQL = SQL & "    K0174_QtyNormal      =  " & FormatSQL(z0174.QtyNormal) & ", " 
    SQL = SQL & "    K0174_QtyDefect      =  " & FormatSQL(z0174.QtyDefect) & ", " 
    SQL = SQL & "    K0174_QtyDefectPass      =  " & FormatSQL(z0174.QtyDefectPass) & ", " 
    SQL = SQL & "    K0174_QtyDefectReject      =  " & FormatSQL(z0174.QtyDefectReject) & ", " 
    SQL = SQL & "    K0174_CheckComplete      = N'" & FormatSQL(z0174.CheckComplete) & "', " 
    SQL = SQL & "    K0174_CheckTrigger      = N'" & FormatSQL(z0174.CheckTrigger) & "', " 
    SQL = SQL & "    K0174_Remark      = N'" & FormatSQL(z0174.Remark) & "'  " 
    SQL = SQL & " WHERE K0174_AUTOKEY		 =  " & z0174.AUTOKEY & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK0174 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK0174",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK0174(z0174 As T0174_AREA) As Boolean
    DELETE_PFK0174 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK0174 "
    SQL = SQL & " WHERE K0174_AUTOKEY		 =  " & z0174.AUTOKEY & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK0174 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK0174",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D0174_CLEAR()
Try
    
    D0174.AUTOKEY = 0 
   D0174.DateBackup = ""
   D0174.TimeBackup = ""
   D0174.cdFactory = ""
   D0174.cdMainProcess = ""
   D0174.cdLineProd = ""
   D0174.seMainProcess = ""
   D0174.seFactory = ""
   D0174.seLineProd = ""
   D0174.LineTno = ""
   D0174.Szno = ""
   D0174.SpecNo = ""
   D0174.SpecNoSeq = ""
   D0174.DatePlan = ""
   D0174.DateProduction = ""
   D0174.PartProduction = ""
   D0174.STimeProduction = ""
   D0174.ETimeProduction = ""
   D0174.InchargePlan = ""
   D0174.InchargeProdution = ""
    D0174.QtyPlan = 0 
    D0174.QtyProd = 0 
    D0174.QtyNormal = 0 
    D0174.QtyDefect = 0 
    D0174.QtyDefectPass = 0 
    D0174.QtyDefectReject = 0 
   D0174.CheckComplete = ""
   D0174.CheckTrigger = ""
   D0174.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D0174_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x0174 As T0174_AREA)
Try
    
    x0174.AUTOKEY = trim$(  x0174.AUTOKEY)
    x0174.DateBackup = trim$(  x0174.DateBackup)
    x0174.TimeBackup = trim$(  x0174.TimeBackup)
    x0174.cdFactory = trim$(  x0174.cdFactory)
    x0174.cdMainProcess = trim$(  x0174.cdMainProcess)
    x0174.cdLineProd = trim$(  x0174.cdLineProd)
    x0174.seMainProcess = trim$(  x0174.seMainProcess)
    x0174.seFactory = trim$(  x0174.seFactory)
    x0174.seLineProd = trim$(  x0174.seLineProd)
    x0174.LineTno = trim$(  x0174.LineTno)
    x0174.Szno = trim$(  x0174.Szno)
    x0174.SpecNo = trim$(  x0174.SpecNo)
    x0174.SpecNoSeq = trim$(  x0174.SpecNoSeq)
    x0174.DatePlan = trim$(  x0174.DatePlan)
    x0174.DateProduction = trim$(  x0174.DateProduction)
    x0174.PartProduction = trim$(  x0174.PartProduction)
    x0174.STimeProduction = trim$(  x0174.STimeProduction)
    x0174.ETimeProduction = trim$(  x0174.ETimeProduction)
    x0174.InchargePlan = trim$(  x0174.InchargePlan)
    x0174.InchargeProdution = trim$(  x0174.InchargeProdution)
    x0174.QtyPlan = trim$(  x0174.QtyPlan)
    x0174.QtyProd = trim$(  x0174.QtyProd)
    x0174.QtyNormal = trim$(  x0174.QtyNormal)
    x0174.QtyDefect = trim$(  x0174.QtyDefect)
    x0174.QtyDefectPass = trim$(  x0174.QtyDefectPass)
    x0174.QtyDefectReject = trim$(  x0174.QtyDefectReject)
    x0174.CheckComplete = trim$(  x0174.CheckComplete)
    x0174.CheckTrigger = trim$(  x0174.CheckTrigger)
    x0174.Remark = trim$(  x0174.Remark)
     
    If trim$( x0174.AUTOKEY ) = "" Then x0174.AUTOKEY = 0 
    If trim$( x0174.DateBackup ) = "" Then x0174.DateBackup = Space(1) 
    If trim$( x0174.TimeBackup ) = "" Then x0174.TimeBackup = Space(1) 
    If trim$( x0174.cdFactory ) = "" Then x0174.cdFactory = Space(1) 
    If trim$( x0174.cdMainProcess ) = "" Then x0174.cdMainProcess = Space(1) 
    If trim$( x0174.cdLineProd ) = "" Then x0174.cdLineProd = Space(1) 
    If trim$( x0174.seMainProcess ) = "" Then x0174.seMainProcess = Space(1) 
    If trim$( x0174.seFactory ) = "" Then x0174.seFactory = Space(1) 
    If trim$( x0174.seLineProd ) = "" Then x0174.seLineProd = Space(1) 
    If trim$( x0174.LineTno ) = "" Then x0174.LineTno = Space(1) 
    If trim$( x0174.Szno ) = "" Then x0174.Szno = Space(1) 
    If trim$( x0174.SpecNo ) = "" Then x0174.SpecNo = Space(1) 
    If trim$( x0174.SpecNoSeq ) = "" Then x0174.SpecNoSeq = Space(1) 
    If trim$( x0174.DatePlan ) = "" Then x0174.DatePlan = Space(1) 
    If trim$( x0174.DateProduction ) = "" Then x0174.DateProduction = Space(1) 
    If trim$( x0174.PartProduction ) = "" Then x0174.PartProduction = Space(1) 
    If trim$( x0174.STimeProduction ) = "" Then x0174.STimeProduction = Space(1) 
    If trim$( x0174.ETimeProduction ) = "" Then x0174.ETimeProduction = Space(1) 
    If trim$( x0174.InchargePlan ) = "" Then x0174.InchargePlan = Space(1) 
    If trim$( x0174.InchargeProdution ) = "" Then x0174.InchargeProdution = Space(1) 
    If trim$( x0174.QtyPlan ) = "" Then x0174.QtyPlan = 0 
    If trim$( x0174.QtyProd ) = "" Then x0174.QtyProd = 0 
    If trim$( x0174.QtyNormal ) = "" Then x0174.QtyNormal = 0 
    If trim$( x0174.QtyDefect ) = "" Then x0174.QtyDefect = 0 
    If trim$( x0174.QtyDefectPass ) = "" Then x0174.QtyDefectPass = 0 
    If trim$( x0174.QtyDefectReject ) = "" Then x0174.QtyDefectReject = 0 
    If trim$( x0174.CheckComplete ) = "" Then x0174.CheckComplete = Space(1) 
    If trim$( x0174.CheckTrigger ) = "" Then x0174.CheckTrigger = Space(1) 
    If trim$( x0174.Remark ) = "" Then x0174.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K0174_MOVE(rs0174 As SqlClient.SqlDataReader)
Try

    call D0174_CLEAR()   

    If IsdbNull(rs0174!K0174_AUTOKEY) = False Then D0174.AUTOKEY = Trim$(rs0174!K0174_AUTOKEY)
    If IsdbNull(rs0174!K0174_DateBackup) = False Then D0174.DateBackup = Trim$(rs0174!K0174_DateBackup)
    If IsdbNull(rs0174!K0174_TimeBackup) = False Then D0174.TimeBackup = Trim$(rs0174!K0174_TimeBackup)
    If IsdbNull(rs0174!K0174_cdFactory) = False Then D0174.cdFactory = Trim$(rs0174!K0174_cdFactory)
    If IsdbNull(rs0174!K0174_cdMainProcess) = False Then D0174.cdMainProcess = Trim$(rs0174!K0174_cdMainProcess)
    If IsdbNull(rs0174!K0174_cdLineProd) = False Then D0174.cdLineProd = Trim$(rs0174!K0174_cdLineProd)
    If IsdbNull(rs0174!K0174_seMainProcess) = False Then D0174.seMainProcess = Trim$(rs0174!K0174_seMainProcess)
    If IsdbNull(rs0174!K0174_seFactory) = False Then D0174.seFactory = Trim$(rs0174!K0174_seFactory)
    If IsdbNull(rs0174!K0174_seLineProd) = False Then D0174.seLineProd = Trim$(rs0174!K0174_seLineProd)
    If IsdbNull(rs0174!K0174_LineTno) = False Then D0174.LineTno = Trim$(rs0174!K0174_LineTno)
    If IsdbNull(rs0174!K0174_Szno) = False Then D0174.Szno = Trim$(rs0174!K0174_Szno)
    If IsdbNull(rs0174!K0174_SpecNo) = False Then D0174.SpecNo = Trim$(rs0174!K0174_SpecNo)
    If IsdbNull(rs0174!K0174_SpecNoSeq) = False Then D0174.SpecNoSeq = Trim$(rs0174!K0174_SpecNoSeq)
    If IsdbNull(rs0174!K0174_DatePlan) = False Then D0174.DatePlan = Trim$(rs0174!K0174_DatePlan)
    If IsdbNull(rs0174!K0174_DateProduction) = False Then D0174.DateProduction = Trim$(rs0174!K0174_DateProduction)
    If IsdbNull(rs0174!K0174_PartProduction) = False Then D0174.PartProduction = Trim$(rs0174!K0174_PartProduction)
    If IsdbNull(rs0174!K0174_STimeProduction) = False Then D0174.STimeProduction = Trim$(rs0174!K0174_STimeProduction)
    If IsdbNull(rs0174!K0174_ETimeProduction) = False Then D0174.ETimeProduction = Trim$(rs0174!K0174_ETimeProduction)
    If IsdbNull(rs0174!K0174_InchargePlan) = False Then D0174.InchargePlan = Trim$(rs0174!K0174_InchargePlan)
    If IsdbNull(rs0174!K0174_InchargeProdution) = False Then D0174.InchargeProdution = Trim$(rs0174!K0174_InchargeProdution)
    If IsdbNull(rs0174!K0174_QtyPlan) = False Then D0174.QtyPlan = Trim$(rs0174!K0174_QtyPlan)
    If IsdbNull(rs0174!K0174_QtyProd) = False Then D0174.QtyProd = Trim$(rs0174!K0174_QtyProd)
    If IsdbNull(rs0174!K0174_QtyNormal) = False Then D0174.QtyNormal = Trim$(rs0174!K0174_QtyNormal)
    If IsdbNull(rs0174!K0174_QtyDefect) = False Then D0174.QtyDefect = Trim$(rs0174!K0174_QtyDefect)
    If IsdbNull(rs0174!K0174_QtyDefectPass) = False Then D0174.QtyDefectPass = Trim$(rs0174!K0174_QtyDefectPass)
    If IsdbNull(rs0174!K0174_QtyDefectReject) = False Then D0174.QtyDefectReject = Trim$(rs0174!K0174_QtyDefectReject)
    If IsdbNull(rs0174!K0174_CheckComplete) = False Then D0174.CheckComplete = Trim$(rs0174!K0174_CheckComplete)
    If IsdbNull(rs0174!K0174_CheckTrigger) = False Then D0174.CheckTrigger = Trim$(rs0174!K0174_CheckTrigger)
    If IsdbNull(rs0174!K0174_Remark) = False Then D0174.Remark = Trim$(rs0174!K0174_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K0174_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K0174_MOVE(rs0174 As DataRow)
Try

    call D0174_CLEAR()   

    If IsdbNull(rs0174!K0174_AUTOKEY) = False Then D0174.AUTOKEY = Trim$(rs0174!K0174_AUTOKEY)
    If IsdbNull(rs0174!K0174_DateBackup) = False Then D0174.DateBackup = Trim$(rs0174!K0174_DateBackup)
    If IsdbNull(rs0174!K0174_TimeBackup) = False Then D0174.TimeBackup = Trim$(rs0174!K0174_TimeBackup)
    If IsdbNull(rs0174!K0174_cdFactory) = False Then D0174.cdFactory = Trim$(rs0174!K0174_cdFactory)
    If IsdbNull(rs0174!K0174_cdMainProcess) = False Then D0174.cdMainProcess = Trim$(rs0174!K0174_cdMainProcess)
    If IsdbNull(rs0174!K0174_cdLineProd) = False Then D0174.cdLineProd = Trim$(rs0174!K0174_cdLineProd)
    If IsdbNull(rs0174!K0174_seMainProcess) = False Then D0174.seMainProcess = Trim$(rs0174!K0174_seMainProcess)
    If IsdbNull(rs0174!K0174_seFactory) = False Then D0174.seFactory = Trim$(rs0174!K0174_seFactory)
    If IsdbNull(rs0174!K0174_seLineProd) = False Then D0174.seLineProd = Trim$(rs0174!K0174_seLineProd)
    If IsdbNull(rs0174!K0174_LineTno) = False Then D0174.LineTno = Trim$(rs0174!K0174_LineTno)
    If IsdbNull(rs0174!K0174_Szno) = False Then D0174.Szno = Trim$(rs0174!K0174_Szno)
    If IsdbNull(rs0174!K0174_SpecNo) = False Then D0174.SpecNo = Trim$(rs0174!K0174_SpecNo)
    If IsdbNull(rs0174!K0174_SpecNoSeq) = False Then D0174.SpecNoSeq = Trim$(rs0174!K0174_SpecNoSeq)
    If IsdbNull(rs0174!K0174_DatePlan) = False Then D0174.DatePlan = Trim$(rs0174!K0174_DatePlan)
    If IsdbNull(rs0174!K0174_DateProduction) = False Then D0174.DateProduction = Trim$(rs0174!K0174_DateProduction)
    If IsdbNull(rs0174!K0174_PartProduction) = False Then D0174.PartProduction = Trim$(rs0174!K0174_PartProduction)
    If IsdbNull(rs0174!K0174_STimeProduction) = False Then D0174.STimeProduction = Trim$(rs0174!K0174_STimeProduction)
    If IsdbNull(rs0174!K0174_ETimeProduction) = False Then D0174.ETimeProduction = Trim$(rs0174!K0174_ETimeProduction)
    If IsdbNull(rs0174!K0174_InchargePlan) = False Then D0174.InchargePlan = Trim$(rs0174!K0174_InchargePlan)
    If IsdbNull(rs0174!K0174_InchargeProdution) = False Then D0174.InchargeProdution = Trim$(rs0174!K0174_InchargeProdution)
    If IsdbNull(rs0174!K0174_QtyPlan) = False Then D0174.QtyPlan = Trim$(rs0174!K0174_QtyPlan)
    If IsdbNull(rs0174!K0174_QtyProd) = False Then D0174.QtyProd = Trim$(rs0174!K0174_QtyProd)
    If IsdbNull(rs0174!K0174_QtyNormal) = False Then D0174.QtyNormal = Trim$(rs0174!K0174_QtyNormal)
    If IsdbNull(rs0174!K0174_QtyDefect) = False Then D0174.QtyDefect = Trim$(rs0174!K0174_QtyDefect)
    If IsdbNull(rs0174!K0174_QtyDefectPass) = False Then D0174.QtyDefectPass = Trim$(rs0174!K0174_QtyDefectPass)
    If IsdbNull(rs0174!K0174_QtyDefectReject) = False Then D0174.QtyDefectReject = Trim$(rs0174!K0174_QtyDefectReject)
    If IsdbNull(rs0174!K0174_CheckComplete) = False Then D0174.CheckComplete = Trim$(rs0174!K0174_CheckComplete)
    If IsdbNull(rs0174!K0174_CheckTrigger) = False Then D0174.CheckTrigger = Trim$(rs0174!K0174_CheckTrigger)
    If IsdbNull(rs0174!K0174_Remark) = False Then D0174.Remark = Trim$(rs0174!K0174_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K0174_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K0174_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z0174 As T0174_AREA, AUTOKEY AS Double) as Boolean

K0174_MOVE = False

Try
    If READ_PFK0174(AUTOKEY) = True Then
                z0174 = D0174
		K0174_MOVE = True
		else
	z0174 = nothing
     End If

     If  getColumIndex(spr,"AUTOKEY") > -1 then z0174.AUTOKEY = getDataM(spr, getColumIndex(spr,"AUTOKEY"), xRow)
     If  getColumIndex(spr,"DateBackup") > -1 then z0174.DateBackup = getDataM(spr, getColumIndex(spr,"DateBackup"), xRow)
     If  getColumIndex(spr,"TimeBackup") > -1 then z0174.TimeBackup = getDataM(spr, getColumIndex(spr,"TimeBackup"), xRow)
     If  getColumIndex(spr,"cdFactory") > -1 then z0174.cdFactory = getDataM(spr, getColumIndex(spr,"cdFactory"), xRow)
     If  getColumIndex(spr,"cdMainProcess") > -1 then z0174.cdMainProcess = getDataM(spr, getColumIndex(spr,"cdMainProcess"), xRow)
     If  getColumIndex(spr,"cdLineProd") > -1 then z0174.cdLineProd = getDataM(spr, getColumIndex(spr,"cdLineProd"), xRow)
     If  getColumIndex(spr,"seMainProcess") > -1 then z0174.seMainProcess = getDataM(spr, getColumIndex(spr,"seMainProcess"), xRow)
     If  getColumIndex(spr,"seFactory") > -1 then z0174.seFactory = getDataM(spr, getColumIndex(spr,"seFactory"), xRow)
     If  getColumIndex(spr,"seLineProd") > -1 then z0174.seLineProd = getDataM(spr, getColumIndex(spr,"seLineProd"), xRow)
     If  getColumIndex(spr,"LineTno") > -1 then z0174.LineTno = getDataM(spr, getColumIndex(spr,"LineTno"), xRow)
     If  getColumIndex(spr,"Szno") > -1 then z0174.Szno = getDataM(spr, getColumIndex(spr,"Szno"), xRow)
     If  getColumIndex(spr,"SpecNo") > -1 then z0174.SpecNo = getDataM(spr, getColumIndex(spr,"SpecNo"), xRow)
     If  getColumIndex(spr,"SpecNoSeq") > -1 then z0174.SpecNoSeq = getDataM(spr, getColumIndex(spr,"SpecNoSeq"), xRow)
     If  getColumIndex(spr,"DatePlan") > -1 then z0174.DatePlan = getDataM(spr, getColumIndex(spr,"DatePlan"), xRow)
     If  getColumIndex(spr,"DateProduction") > -1 then z0174.DateProduction = getDataM(spr, getColumIndex(spr,"DateProduction"), xRow)
     If  getColumIndex(spr,"PartProduction") > -1 then z0174.PartProduction = getDataM(spr, getColumIndex(spr,"PartProduction"), xRow)
     If  getColumIndex(spr,"STimeProduction") > -1 then z0174.STimeProduction = getDataM(spr, getColumIndex(spr,"STimeProduction"), xRow)
     If  getColumIndex(spr,"ETimeProduction") > -1 then z0174.ETimeProduction = getDataM(spr, getColumIndex(spr,"ETimeProduction"), xRow)
     If  getColumIndex(spr,"InchargePlan") > -1 then z0174.InchargePlan = getDataM(spr, getColumIndex(spr,"InchargePlan"), xRow)
     If  getColumIndex(spr,"InchargeProdution") > -1 then z0174.InchargeProdution = getDataM(spr, getColumIndex(spr,"InchargeProdution"), xRow)
     If  getColumIndex(spr,"QtyPlan") > -1 then z0174.QtyPlan = getDataM(spr, getColumIndex(spr,"QtyPlan"), xRow)
     If  getColumIndex(spr,"QtyProd") > -1 then z0174.QtyProd = getDataM(spr, getColumIndex(spr,"QtyProd"), xRow)
     If  getColumIndex(spr,"QtyNormal") > -1 then z0174.QtyNormal = getDataM(spr, getColumIndex(spr,"QtyNormal"), xRow)
     If  getColumIndex(spr,"QtyDefect") > -1 then z0174.QtyDefect = getDataM(spr, getColumIndex(spr,"QtyDefect"), xRow)
     If  getColumIndex(spr,"QtyDefectPass") > -1 then z0174.QtyDefectPass = getDataM(spr, getColumIndex(spr,"QtyDefectPass"), xRow)
     If  getColumIndex(spr,"QtyDefectReject") > -1 then z0174.QtyDefectReject = getDataM(spr, getColumIndex(spr,"QtyDefectReject"), xRow)
     If  getColumIndex(spr,"CheckComplete") > -1 then z0174.CheckComplete = getDataM(spr, getColumIndex(spr,"CheckComplete"), xRow)
     If  getColumIndex(spr,"CheckTrigger") > -1 then z0174.CheckTrigger = getDataM(spr, getColumIndex(spr,"CheckTrigger"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z0174.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K0174_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K0174_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z0174 As T0174_AREA,CheckClear as Boolean,AUTOKEY AS Double) as Boolean

K0174_MOVE = False

Try
    If READ_PFK0174(AUTOKEY) = True Then
                z0174 = D0174
		K0174_MOVE = True
		else
	If CheckClear  = True then z0174 = nothing
     End If

     If  getColumIndex(spr,"AUTOKEY") > -1 then z0174.AUTOKEY = getDataM(spr, getColumIndex(spr,"AUTOKEY"), xRow)
     If  getColumIndex(spr,"DateBackup") > -1 then z0174.DateBackup = getDataM(spr, getColumIndex(spr,"DateBackup"), xRow)
     If  getColumIndex(spr,"TimeBackup") > -1 then z0174.TimeBackup = getDataM(spr, getColumIndex(spr,"TimeBackup"), xRow)
     If  getColumIndex(spr,"cdFactory") > -1 then z0174.cdFactory = getDataM(spr, getColumIndex(spr,"cdFactory"), xRow)
     If  getColumIndex(spr,"cdMainProcess") > -1 then z0174.cdMainProcess = getDataM(spr, getColumIndex(spr,"cdMainProcess"), xRow)
     If  getColumIndex(spr,"cdLineProd") > -1 then z0174.cdLineProd = getDataM(spr, getColumIndex(spr,"cdLineProd"), xRow)
     If  getColumIndex(spr,"seMainProcess") > -1 then z0174.seMainProcess = getDataM(spr, getColumIndex(spr,"seMainProcess"), xRow)
     If  getColumIndex(spr,"seFactory") > -1 then z0174.seFactory = getDataM(spr, getColumIndex(spr,"seFactory"), xRow)
     If  getColumIndex(spr,"seLineProd") > -1 then z0174.seLineProd = getDataM(spr, getColumIndex(spr,"seLineProd"), xRow)
     If  getColumIndex(spr,"LineTno") > -1 then z0174.LineTno = getDataM(spr, getColumIndex(spr,"LineTno"), xRow)
     If  getColumIndex(spr,"Szno") > -1 then z0174.Szno = getDataM(spr, getColumIndex(spr,"Szno"), xRow)
     If  getColumIndex(spr,"SpecNo") > -1 then z0174.SpecNo = getDataM(spr, getColumIndex(spr,"SpecNo"), xRow)
     If  getColumIndex(spr,"SpecNoSeq") > -1 then z0174.SpecNoSeq = getDataM(spr, getColumIndex(spr,"SpecNoSeq"), xRow)
     If  getColumIndex(spr,"DatePlan") > -1 then z0174.DatePlan = getDataM(spr, getColumIndex(spr,"DatePlan"), xRow)
     If  getColumIndex(spr,"DateProduction") > -1 then z0174.DateProduction = getDataM(spr, getColumIndex(spr,"DateProduction"), xRow)
     If  getColumIndex(spr,"PartProduction") > -1 then z0174.PartProduction = getDataM(spr, getColumIndex(spr,"PartProduction"), xRow)
     If  getColumIndex(spr,"STimeProduction") > -1 then z0174.STimeProduction = getDataM(spr, getColumIndex(spr,"STimeProduction"), xRow)
     If  getColumIndex(spr,"ETimeProduction") > -1 then z0174.ETimeProduction = getDataM(spr, getColumIndex(spr,"ETimeProduction"), xRow)
     If  getColumIndex(spr,"InchargePlan") > -1 then z0174.InchargePlan = getDataM(spr, getColumIndex(spr,"InchargePlan"), xRow)
     If  getColumIndex(spr,"InchargeProdution") > -1 then z0174.InchargeProdution = getDataM(spr, getColumIndex(spr,"InchargeProdution"), xRow)
     If  getColumIndex(spr,"QtyPlan") > -1 then z0174.QtyPlan = getDataM(spr, getColumIndex(spr,"QtyPlan"), xRow)
     If  getColumIndex(spr,"QtyProd") > -1 then z0174.QtyProd = getDataM(spr, getColumIndex(spr,"QtyProd"), xRow)
     If  getColumIndex(spr,"QtyNormal") > -1 then z0174.QtyNormal = getDataM(spr, getColumIndex(spr,"QtyNormal"), xRow)
     If  getColumIndex(spr,"QtyDefect") > -1 then z0174.QtyDefect = getDataM(spr, getColumIndex(spr,"QtyDefect"), xRow)
     If  getColumIndex(spr,"QtyDefectPass") > -1 then z0174.QtyDefectPass = getDataM(spr, getColumIndex(spr,"QtyDefectPass"), xRow)
     If  getColumIndex(spr,"QtyDefectReject") > -1 then z0174.QtyDefectReject = getDataM(spr, getColumIndex(spr,"QtyDefectReject"), xRow)
     If  getColumIndex(spr,"CheckComplete") > -1 then z0174.CheckComplete = getDataM(spr, getColumIndex(spr,"CheckComplete"), xRow)
     If  getColumIndex(spr,"CheckTrigger") > -1 then z0174.CheckTrigger = getDataM(spr, getColumIndex(spr,"CheckTrigger"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z0174.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K0174_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K0174_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z0174 As T0174_AREA, Job as String, AUTOKEY AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K0174_MOVE = False

Try
    If READ_PFK0174(AUTOKEY) = True Then
                z0174 = D0174
		K0174_MOVE = True
		else
	z0174 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK0174")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "AUTOKEY":z0174.AUTOKEY = Children(i).Code
   Case "DATEBACKUP":z0174.DateBackup = Children(i).Code
   Case "TIMEBACKUP":z0174.TimeBackup = Children(i).Code
   Case "CDFACTORY":z0174.cdFactory = Children(i).Code
   Case "CDMAINPROCESS":z0174.cdMainProcess = Children(i).Code
   Case "CDLINEPROD":z0174.cdLineProd = Children(i).Code
   Case "SEMAINPROCESS":z0174.seMainProcess = Children(i).Code
   Case "SEFACTORY":z0174.seFactory = Children(i).Code
   Case "SELINEPROD":z0174.seLineProd = Children(i).Code
   Case "LINETNO":z0174.LineTno = Children(i).Code
   Case "SZNO":z0174.Szno = Children(i).Code
   Case "SPECNO":z0174.SpecNo = Children(i).Code
   Case "SPECNOSEQ":z0174.SpecNoSeq = Children(i).Code
   Case "DATEPLAN":z0174.DatePlan = Children(i).Code
   Case "DATEPRODUCTION":z0174.DateProduction = Children(i).Code
   Case "PARTPRODUCTION":z0174.PartProduction = Children(i).Code
   Case "STIMEPRODUCTION":z0174.STimeProduction = Children(i).Code
   Case "ETIMEPRODUCTION":z0174.ETimeProduction = Children(i).Code
   Case "INCHARGEPLAN":z0174.InchargePlan = Children(i).Code
   Case "INCHARGEPRODUTION":z0174.InchargeProdution = Children(i).Code
   Case "QTYPLAN":z0174.QtyPlan = Children(i).Code
   Case "QTYPROD":z0174.QtyProd = Children(i).Code
   Case "QTYNORMAL":z0174.QtyNormal = Children(i).Code
   Case "QTYDEFECT":z0174.QtyDefect = Children(i).Code
   Case "QTYDEFECTPASS":z0174.QtyDefectPass = Children(i).Code
   Case "QTYDEFECTREJECT":z0174.QtyDefectReject = Children(i).Code
   Case "CHECKCOMPLETE":z0174.CheckComplete = Children(i).Code
   Case "CHECKTRIGGER":z0174.CheckTrigger = Children(i).Code
   Case "REMARK":z0174.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "AUTOKEY":z0174.AUTOKEY = Children(i).Data
   Case "DATEBACKUP":z0174.DateBackup = Children(i).Data
   Case "TIMEBACKUP":z0174.TimeBackup = Children(i).Data
   Case "CDFACTORY":z0174.cdFactory = Children(i).Data
   Case "CDMAINPROCESS":z0174.cdMainProcess = Children(i).Data
   Case "CDLINEPROD":z0174.cdLineProd = Children(i).Data
   Case "SEMAINPROCESS":z0174.seMainProcess = Children(i).Data
   Case "SEFACTORY":z0174.seFactory = Children(i).Data
   Case "SELINEPROD":z0174.seLineProd = Children(i).Data
   Case "LINETNO":z0174.LineTno = Children(i).Data
   Case "SZNO":z0174.Szno = Children(i).Data
   Case "SPECNO":z0174.SpecNo = Children(i).Data
   Case "SPECNOSEQ":z0174.SpecNoSeq = Children(i).Data
   Case "DATEPLAN":z0174.DatePlan = Children(i).Data
   Case "DATEPRODUCTION":z0174.DateProduction = Children(i).Data
   Case "PARTPRODUCTION":z0174.PartProduction = Children(i).Data
   Case "STIMEPRODUCTION":z0174.STimeProduction = Children(i).Data
   Case "ETIMEPRODUCTION":z0174.ETimeProduction = Children(i).Data
   Case "INCHARGEPLAN":z0174.InchargePlan = Children(i).Data
   Case "INCHARGEPRODUTION":z0174.InchargeProdution = Children(i).Data
   Case "QTYPLAN":z0174.QtyPlan = Children(i).Data
   Case "QTYPROD":z0174.QtyProd = Children(i).Data
   Case "QTYNORMAL":z0174.QtyNormal = Children(i).Data
   Case "QTYDEFECT":z0174.QtyDefect = Children(i).Data
   Case "QTYDEFECTPASS":z0174.QtyDefectPass = Children(i).Data
   Case "QTYDEFECTREJECT":z0174.QtyDefectReject = Children(i).Data
   Case "CHECKCOMPLETE":z0174.CheckComplete = Children(i).Data
   Case "CHECKTRIGGER":z0174.CheckTrigger = Children(i).Data
   Case "REMARK":z0174.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K0174_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K0174_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z0174 As T0174_AREA, Job as String, CheckClear as Boolean, AUTOKEY AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K0174_MOVE = False

Try
    If READ_PFK0174(AUTOKEY) = True Then
                z0174 = D0174
		K0174_MOVE = True
		else
	If CheckClear  = True then z0174 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK0174")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "AUTOKEY":z0174.AUTOKEY = Children(i).Code
   Case "DATEBACKUP":z0174.DateBackup = Children(i).Code
   Case "TIMEBACKUP":z0174.TimeBackup = Children(i).Code
   Case "CDFACTORY":z0174.cdFactory = Children(i).Code
   Case "CDMAINPROCESS":z0174.cdMainProcess = Children(i).Code
   Case "CDLINEPROD":z0174.cdLineProd = Children(i).Code
   Case "SEMAINPROCESS":z0174.seMainProcess = Children(i).Code
   Case "SEFACTORY":z0174.seFactory = Children(i).Code
   Case "SELINEPROD":z0174.seLineProd = Children(i).Code
   Case "LINETNO":z0174.LineTno = Children(i).Code
   Case "SZNO":z0174.Szno = Children(i).Code
   Case "SPECNO":z0174.SpecNo = Children(i).Code
   Case "SPECNOSEQ":z0174.SpecNoSeq = Children(i).Code
   Case "DATEPLAN":z0174.DatePlan = Children(i).Code
   Case "DATEPRODUCTION":z0174.DateProduction = Children(i).Code
   Case "PARTPRODUCTION":z0174.PartProduction = Children(i).Code
   Case "STIMEPRODUCTION":z0174.STimeProduction = Children(i).Code
   Case "ETIMEPRODUCTION":z0174.ETimeProduction = Children(i).Code
   Case "INCHARGEPLAN":z0174.InchargePlan = Children(i).Code
   Case "INCHARGEPRODUTION":z0174.InchargeProdution = Children(i).Code
   Case "QTYPLAN":z0174.QtyPlan = Children(i).Code
   Case "QTYPROD":z0174.QtyProd = Children(i).Code
   Case "QTYNORMAL":z0174.QtyNormal = Children(i).Code
   Case "QTYDEFECT":z0174.QtyDefect = Children(i).Code
   Case "QTYDEFECTPASS":z0174.QtyDefectPass = Children(i).Code
   Case "QTYDEFECTREJECT":z0174.QtyDefectReject = Children(i).Code
   Case "CHECKCOMPLETE":z0174.CheckComplete = Children(i).Code
   Case "CHECKTRIGGER":z0174.CheckTrigger = Children(i).Code
   Case "REMARK":z0174.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "AUTOKEY":z0174.AUTOKEY = Children(i).Data
   Case "DATEBACKUP":z0174.DateBackup = Children(i).Data
   Case "TIMEBACKUP":z0174.TimeBackup = Children(i).Data
   Case "CDFACTORY":z0174.cdFactory = Children(i).Data
   Case "CDMAINPROCESS":z0174.cdMainProcess = Children(i).Data
   Case "CDLINEPROD":z0174.cdLineProd = Children(i).Data
   Case "SEMAINPROCESS":z0174.seMainProcess = Children(i).Data
   Case "SEFACTORY":z0174.seFactory = Children(i).Data
   Case "SELINEPROD":z0174.seLineProd = Children(i).Data
   Case "LINETNO":z0174.LineTno = Children(i).Data
   Case "SZNO":z0174.Szno = Children(i).Data
   Case "SPECNO":z0174.SpecNo = Children(i).Data
   Case "SPECNOSEQ":z0174.SpecNoSeq = Children(i).Data
   Case "DATEPLAN":z0174.DatePlan = Children(i).Data
   Case "DATEPRODUCTION":z0174.DateProduction = Children(i).Data
   Case "PARTPRODUCTION":z0174.PartProduction = Children(i).Data
   Case "STIMEPRODUCTION":z0174.STimeProduction = Children(i).Data
   Case "ETIMEPRODUCTION":z0174.ETimeProduction = Children(i).Data
   Case "INCHARGEPLAN":z0174.InchargePlan = Children(i).Data
   Case "INCHARGEPRODUTION":z0174.InchargeProdution = Children(i).Data
   Case "QTYPLAN":z0174.QtyPlan = Children(i).Data
   Case "QTYPROD":z0174.QtyProd = Children(i).Data
   Case "QTYNORMAL":z0174.QtyNormal = Children(i).Data
   Case "QTYDEFECT":z0174.QtyDefect = Children(i).Data
   Case "QTYDEFECTPASS":z0174.QtyDefectPass = Children(i).Data
   Case "QTYDEFECTREJECT":z0174.QtyDefectReject = Children(i).Data
   Case "CHECKCOMPLETE":z0174.CheckComplete = Children(i).Data
   Case "CHECKTRIGGER":z0174.CheckTrigger = Children(i).Data
   Case "REMARK":z0174.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K0174_MOVE",vbCritical)
End Try
End Function 
    
End Module 
