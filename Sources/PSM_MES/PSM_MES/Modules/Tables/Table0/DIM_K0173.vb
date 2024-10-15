'=========================================================================================================================================================
'   TABLE : (PFK0173)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K0173

Structure T0173_AREA
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

Public D0173 As T0173_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK0173(AUTOKEY AS Double) As Boolean
    READ_PFK0173 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK0173 "
    SQL = SQL & " WHERE K0173_AUTOKEY		 =  " & AUTOKEY & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D0173_CLEAR: GoTo SKIP_READ_PFK0173
                
    Call K0173_MOVE(rd)
    READ_PFK0173 = True

SKIP_READ_PFK0173:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK0173",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK0173(AUTOKEY AS Double, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK0173 "
    SQL = SQL & " WHERE K0173_AUTOKEY		 =  " & AUTOKEY & "  " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK0173",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK0173(z0173 As T0173_AREA) As Boolean
    WRITE_PFK0173 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z0173)
 
    SQL = " INSERT INTO PFK0173 "
    SQL = SQL & " ( "
    SQL = SQL & " K0173_AUTOKEY," 
    SQL = SQL & " K0173_DateBackup," 
    SQL = SQL & " K0173_TimeBackup," 
    SQL = SQL & " K0173_cdFactory," 
    SQL = SQL & " K0173_cdMainProcess," 
    SQL = SQL & " K0173_cdLineProd," 
    SQL = SQL & " K0173_seMainProcess," 
    SQL = SQL & " K0173_seFactory," 
    SQL = SQL & " K0173_seLineProd," 
    SQL = SQL & " K0173_LineTno," 
    SQL = SQL & " K0173_SpecNo," 
    SQL = SQL & " K0173_SpecNoSeq," 
    SQL = SQL & " K0173_DatePlan," 
    SQL = SQL & " K0173_DateProduction," 
    SQL = SQL & " K0173_PartProduction," 
    SQL = SQL & " K0173_STimeProduction," 
    SQL = SQL & " K0173_ETimeProduction," 
    SQL = SQL & " K0173_InchargePlan," 
    SQL = SQL & " K0173_InchargeProdution," 
    SQL = SQL & " K0173_QtyPlan," 
    SQL = SQL & " K0173_QtyProd," 
    SQL = SQL & " K0173_QtyNormal," 
    SQL = SQL & " K0173_QtyDefect," 
    SQL = SQL & " K0173_QtyDefectPass," 
    SQL = SQL & " K0173_QtyDefectReject," 
    SQL = SQL & " K0173_CheckComplete," 
    SQL = SQL & " K0173_CheckTrigger," 
    SQL = SQL & " K0173_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "   " & FormatSQL(z0173.AUTOKEY) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z0173.DateBackup) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0173.TimeBackup) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0173.cdFactory) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0173.cdMainProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0173.cdLineProd) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0173.seMainProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0173.seFactory) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0173.seLineProd) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0173.LineTno) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0173.SpecNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0173.SpecNoSeq) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0173.DatePlan) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0173.DateProduction) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0173.PartProduction) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0173.STimeProduction) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0173.ETimeProduction) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0173.InchargePlan) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0173.InchargeProdution) & "', "  
    SQL = SQL & "   " & FormatSQL(z0173.QtyPlan) & ", "  
    SQL = SQL & "   " & FormatSQL(z0173.QtyProd) & ", "  
    SQL = SQL & "   " & FormatSQL(z0173.QtyNormal) & ", "  
    SQL = SQL & "   " & FormatSQL(z0173.QtyDefect) & ", "  
    SQL = SQL & "   " & FormatSQL(z0173.QtyDefectPass) & ", "  
    SQL = SQL & "   " & FormatSQL(z0173.QtyDefectReject) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z0173.CheckComplete) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0173.CheckTrigger) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0173.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK0173 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK0173",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK0173(z0173 As T0173_AREA) As Boolean
    REWRITE_PFK0173 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z0173)
   
    SQL = " UPDATE PFK0173 SET "
    SQL = SQL & "    K0173_DateBackup      = N'" & FormatSQL(z0173.DateBackup) & "', " 
    SQL = SQL & "    K0173_TimeBackup      = N'" & FormatSQL(z0173.TimeBackup) & "', " 
    SQL = SQL & "    K0173_cdFactory      = N'" & FormatSQL(z0173.cdFactory) & "', " 
    SQL = SQL & "    K0173_cdMainProcess      = N'" & FormatSQL(z0173.cdMainProcess) & "', " 
    SQL = SQL & "    K0173_cdLineProd      = N'" & FormatSQL(z0173.cdLineProd) & "', " 
    SQL = SQL & "    K0173_seMainProcess      = N'" & FormatSQL(z0173.seMainProcess) & "', " 
    SQL = SQL & "    K0173_seFactory      = N'" & FormatSQL(z0173.seFactory) & "', " 
    SQL = SQL & "    K0173_seLineProd      = N'" & FormatSQL(z0173.seLineProd) & "', " 
    SQL = SQL & "    K0173_LineTno      = N'" & FormatSQL(z0173.LineTno) & "', " 
    SQL = SQL & "    K0173_SpecNo      = N'" & FormatSQL(z0173.SpecNo) & "', " 
    SQL = SQL & "    K0173_SpecNoSeq      = N'" & FormatSQL(z0173.SpecNoSeq) & "', " 
    SQL = SQL & "    K0173_DatePlan      = N'" & FormatSQL(z0173.DatePlan) & "', " 
    SQL = SQL & "    K0173_DateProduction      = N'" & FormatSQL(z0173.DateProduction) & "', " 
    SQL = SQL & "    K0173_PartProduction      = N'" & FormatSQL(z0173.PartProduction) & "', " 
    SQL = SQL & "    K0173_STimeProduction      = N'" & FormatSQL(z0173.STimeProduction) & "', " 
    SQL = SQL & "    K0173_ETimeProduction      = N'" & FormatSQL(z0173.ETimeProduction) & "', " 
    SQL = SQL & "    K0173_InchargePlan      = N'" & FormatSQL(z0173.InchargePlan) & "', " 
    SQL = SQL & "    K0173_InchargeProdution      = N'" & FormatSQL(z0173.InchargeProdution) & "', " 
    SQL = SQL & "    K0173_QtyPlan      =  " & FormatSQL(z0173.QtyPlan) & ", " 
    SQL = SQL & "    K0173_QtyProd      =  " & FormatSQL(z0173.QtyProd) & ", " 
    SQL = SQL & "    K0173_QtyNormal      =  " & FormatSQL(z0173.QtyNormal) & ", " 
    SQL = SQL & "    K0173_QtyDefect      =  " & FormatSQL(z0173.QtyDefect) & ", " 
    SQL = SQL & "    K0173_QtyDefectPass      =  " & FormatSQL(z0173.QtyDefectPass) & ", " 
    SQL = SQL & "    K0173_QtyDefectReject      =  " & FormatSQL(z0173.QtyDefectReject) & ", " 
    SQL = SQL & "    K0173_CheckComplete      = N'" & FormatSQL(z0173.CheckComplete) & "', " 
    SQL = SQL & "    K0173_CheckTrigger      = N'" & FormatSQL(z0173.CheckTrigger) & "', " 
    SQL = SQL & "    K0173_Remark      = N'" & FormatSQL(z0173.Remark) & "'  " 
    SQL = SQL & " WHERE K0173_AUTOKEY		 =  " & z0173.AUTOKEY & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK0173 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK0173",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK0173(z0173 As T0173_AREA) As Boolean
    DELETE_PFK0173 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK0173 "
    SQL = SQL & " WHERE K0173_AUTOKEY		 =  " & z0173.AUTOKEY & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK0173 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK0173",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D0173_CLEAR()
Try
    
    D0173.AUTOKEY = 0 
   D0173.DateBackup = ""
   D0173.TimeBackup = ""
   D0173.cdFactory = ""
   D0173.cdMainProcess = ""
   D0173.cdLineProd = ""
   D0173.seMainProcess = ""
   D0173.seFactory = ""
   D0173.seLineProd = ""
   D0173.LineTno = ""
   D0173.SpecNo = ""
   D0173.SpecNoSeq = ""
   D0173.DatePlan = ""
   D0173.DateProduction = ""
   D0173.PartProduction = ""
   D0173.STimeProduction = ""
   D0173.ETimeProduction = ""
   D0173.InchargePlan = ""
   D0173.InchargeProdution = ""
    D0173.QtyPlan = 0 
    D0173.QtyProd = 0 
    D0173.QtyNormal = 0 
    D0173.QtyDefect = 0 
    D0173.QtyDefectPass = 0 
    D0173.QtyDefectReject = 0 
   D0173.CheckComplete = ""
   D0173.CheckTrigger = ""
   D0173.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D0173_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x0173 As T0173_AREA)
Try
    
    x0173.AUTOKEY = trim$(  x0173.AUTOKEY)
    x0173.DateBackup = trim$(  x0173.DateBackup)
    x0173.TimeBackup = trim$(  x0173.TimeBackup)
    x0173.cdFactory = trim$(  x0173.cdFactory)
    x0173.cdMainProcess = trim$(  x0173.cdMainProcess)
    x0173.cdLineProd = trim$(  x0173.cdLineProd)
    x0173.seMainProcess = trim$(  x0173.seMainProcess)
    x0173.seFactory = trim$(  x0173.seFactory)
    x0173.seLineProd = trim$(  x0173.seLineProd)
    x0173.LineTno = trim$(  x0173.LineTno)
    x0173.SpecNo = trim$(  x0173.SpecNo)
    x0173.SpecNoSeq = trim$(  x0173.SpecNoSeq)
    x0173.DatePlan = trim$(  x0173.DatePlan)
    x0173.DateProduction = trim$(  x0173.DateProduction)
    x0173.PartProduction = trim$(  x0173.PartProduction)
    x0173.STimeProduction = trim$(  x0173.STimeProduction)
    x0173.ETimeProduction = trim$(  x0173.ETimeProduction)
    x0173.InchargePlan = trim$(  x0173.InchargePlan)
    x0173.InchargeProdution = trim$(  x0173.InchargeProdution)
    x0173.QtyPlan = trim$(  x0173.QtyPlan)
    x0173.QtyProd = trim$(  x0173.QtyProd)
    x0173.QtyNormal = trim$(  x0173.QtyNormal)
    x0173.QtyDefect = trim$(  x0173.QtyDefect)
    x0173.QtyDefectPass = trim$(  x0173.QtyDefectPass)
    x0173.QtyDefectReject = trim$(  x0173.QtyDefectReject)
    x0173.CheckComplete = trim$(  x0173.CheckComplete)
    x0173.CheckTrigger = trim$(  x0173.CheckTrigger)
    x0173.Remark = trim$(  x0173.Remark)
     
    If trim$( x0173.AUTOKEY ) = "" Then x0173.AUTOKEY = 0 
    If trim$( x0173.DateBackup ) = "" Then x0173.DateBackup = Space(1) 
    If trim$( x0173.TimeBackup ) = "" Then x0173.TimeBackup = Space(1) 
    If trim$( x0173.cdFactory ) = "" Then x0173.cdFactory = Space(1) 
    If trim$( x0173.cdMainProcess ) = "" Then x0173.cdMainProcess = Space(1) 
    If trim$( x0173.cdLineProd ) = "" Then x0173.cdLineProd = Space(1) 
    If trim$( x0173.seMainProcess ) = "" Then x0173.seMainProcess = Space(1) 
    If trim$( x0173.seFactory ) = "" Then x0173.seFactory = Space(1) 
    If trim$( x0173.seLineProd ) = "" Then x0173.seLineProd = Space(1) 
    If trim$( x0173.LineTno ) = "" Then x0173.LineTno = Space(1) 
    If trim$( x0173.SpecNo ) = "" Then x0173.SpecNo = Space(1) 
    If trim$( x0173.SpecNoSeq ) = "" Then x0173.SpecNoSeq = Space(1) 
    If trim$( x0173.DatePlan ) = "" Then x0173.DatePlan = Space(1) 
    If trim$( x0173.DateProduction ) = "" Then x0173.DateProduction = Space(1) 
    If trim$( x0173.PartProduction ) = "" Then x0173.PartProduction = Space(1) 
    If trim$( x0173.STimeProduction ) = "" Then x0173.STimeProduction = Space(1) 
    If trim$( x0173.ETimeProduction ) = "" Then x0173.ETimeProduction = Space(1) 
    If trim$( x0173.InchargePlan ) = "" Then x0173.InchargePlan = Space(1) 
    If trim$( x0173.InchargeProdution ) = "" Then x0173.InchargeProdution = Space(1) 
    If trim$( x0173.QtyPlan ) = "" Then x0173.QtyPlan = 0 
    If trim$( x0173.QtyProd ) = "" Then x0173.QtyProd = 0 
    If trim$( x0173.QtyNormal ) = "" Then x0173.QtyNormal = 0 
    If trim$( x0173.QtyDefect ) = "" Then x0173.QtyDefect = 0 
    If trim$( x0173.QtyDefectPass ) = "" Then x0173.QtyDefectPass = 0 
    If trim$( x0173.QtyDefectReject ) = "" Then x0173.QtyDefectReject = 0 
    If trim$( x0173.CheckComplete ) = "" Then x0173.CheckComplete = Space(1) 
    If trim$( x0173.CheckTrigger ) = "" Then x0173.CheckTrigger = Space(1) 
    If trim$( x0173.Remark ) = "" Then x0173.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K0173_MOVE(rs0173 As SqlClient.SqlDataReader)
Try

    call D0173_CLEAR()   

    If IsdbNull(rs0173!K0173_AUTOKEY) = False Then D0173.AUTOKEY = Trim$(rs0173!K0173_AUTOKEY)
    If IsdbNull(rs0173!K0173_DateBackup) = False Then D0173.DateBackup = Trim$(rs0173!K0173_DateBackup)
    If IsdbNull(rs0173!K0173_TimeBackup) = False Then D0173.TimeBackup = Trim$(rs0173!K0173_TimeBackup)
    If IsdbNull(rs0173!K0173_cdFactory) = False Then D0173.cdFactory = Trim$(rs0173!K0173_cdFactory)
    If IsdbNull(rs0173!K0173_cdMainProcess) = False Then D0173.cdMainProcess = Trim$(rs0173!K0173_cdMainProcess)
    If IsdbNull(rs0173!K0173_cdLineProd) = False Then D0173.cdLineProd = Trim$(rs0173!K0173_cdLineProd)
    If IsdbNull(rs0173!K0173_seMainProcess) = False Then D0173.seMainProcess = Trim$(rs0173!K0173_seMainProcess)
    If IsdbNull(rs0173!K0173_seFactory) = False Then D0173.seFactory = Trim$(rs0173!K0173_seFactory)
    If IsdbNull(rs0173!K0173_seLineProd) = False Then D0173.seLineProd = Trim$(rs0173!K0173_seLineProd)
    If IsdbNull(rs0173!K0173_LineTno) = False Then D0173.LineTno = Trim$(rs0173!K0173_LineTno)
    If IsdbNull(rs0173!K0173_SpecNo) = False Then D0173.SpecNo = Trim$(rs0173!K0173_SpecNo)
    If IsdbNull(rs0173!K0173_SpecNoSeq) = False Then D0173.SpecNoSeq = Trim$(rs0173!K0173_SpecNoSeq)
    If IsdbNull(rs0173!K0173_DatePlan) = False Then D0173.DatePlan = Trim$(rs0173!K0173_DatePlan)
    If IsdbNull(rs0173!K0173_DateProduction) = False Then D0173.DateProduction = Trim$(rs0173!K0173_DateProduction)
    If IsdbNull(rs0173!K0173_PartProduction) = False Then D0173.PartProduction = Trim$(rs0173!K0173_PartProduction)
    If IsdbNull(rs0173!K0173_STimeProduction) = False Then D0173.STimeProduction = Trim$(rs0173!K0173_STimeProduction)
    If IsdbNull(rs0173!K0173_ETimeProduction) = False Then D0173.ETimeProduction = Trim$(rs0173!K0173_ETimeProduction)
    If IsdbNull(rs0173!K0173_InchargePlan) = False Then D0173.InchargePlan = Trim$(rs0173!K0173_InchargePlan)
    If IsdbNull(rs0173!K0173_InchargeProdution) = False Then D0173.InchargeProdution = Trim$(rs0173!K0173_InchargeProdution)
    If IsdbNull(rs0173!K0173_QtyPlan) = False Then D0173.QtyPlan = Trim$(rs0173!K0173_QtyPlan)
    If IsdbNull(rs0173!K0173_QtyProd) = False Then D0173.QtyProd = Trim$(rs0173!K0173_QtyProd)
    If IsdbNull(rs0173!K0173_QtyNormal) = False Then D0173.QtyNormal = Trim$(rs0173!K0173_QtyNormal)
    If IsdbNull(rs0173!K0173_QtyDefect) = False Then D0173.QtyDefect = Trim$(rs0173!K0173_QtyDefect)
    If IsdbNull(rs0173!K0173_QtyDefectPass) = False Then D0173.QtyDefectPass = Trim$(rs0173!K0173_QtyDefectPass)
    If IsdbNull(rs0173!K0173_QtyDefectReject) = False Then D0173.QtyDefectReject = Trim$(rs0173!K0173_QtyDefectReject)
    If IsdbNull(rs0173!K0173_CheckComplete) = False Then D0173.CheckComplete = Trim$(rs0173!K0173_CheckComplete)
    If IsdbNull(rs0173!K0173_CheckTrigger) = False Then D0173.CheckTrigger = Trim$(rs0173!K0173_CheckTrigger)
    If IsdbNull(rs0173!K0173_Remark) = False Then D0173.Remark = Trim$(rs0173!K0173_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K0173_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K0173_MOVE(rs0173 As DataRow)
Try

    call D0173_CLEAR()   

    If IsdbNull(rs0173!K0173_AUTOKEY) = False Then D0173.AUTOKEY = Trim$(rs0173!K0173_AUTOKEY)
    If IsdbNull(rs0173!K0173_DateBackup) = False Then D0173.DateBackup = Trim$(rs0173!K0173_DateBackup)
    If IsdbNull(rs0173!K0173_TimeBackup) = False Then D0173.TimeBackup = Trim$(rs0173!K0173_TimeBackup)
    If IsdbNull(rs0173!K0173_cdFactory) = False Then D0173.cdFactory = Trim$(rs0173!K0173_cdFactory)
    If IsdbNull(rs0173!K0173_cdMainProcess) = False Then D0173.cdMainProcess = Trim$(rs0173!K0173_cdMainProcess)
    If IsdbNull(rs0173!K0173_cdLineProd) = False Then D0173.cdLineProd = Trim$(rs0173!K0173_cdLineProd)
    If IsdbNull(rs0173!K0173_seMainProcess) = False Then D0173.seMainProcess = Trim$(rs0173!K0173_seMainProcess)
    If IsdbNull(rs0173!K0173_seFactory) = False Then D0173.seFactory = Trim$(rs0173!K0173_seFactory)
    If IsdbNull(rs0173!K0173_seLineProd) = False Then D0173.seLineProd = Trim$(rs0173!K0173_seLineProd)
    If IsdbNull(rs0173!K0173_LineTno) = False Then D0173.LineTno = Trim$(rs0173!K0173_LineTno)
    If IsdbNull(rs0173!K0173_SpecNo) = False Then D0173.SpecNo = Trim$(rs0173!K0173_SpecNo)
    If IsdbNull(rs0173!K0173_SpecNoSeq) = False Then D0173.SpecNoSeq = Trim$(rs0173!K0173_SpecNoSeq)
    If IsdbNull(rs0173!K0173_DatePlan) = False Then D0173.DatePlan = Trim$(rs0173!K0173_DatePlan)
    If IsdbNull(rs0173!K0173_DateProduction) = False Then D0173.DateProduction = Trim$(rs0173!K0173_DateProduction)
    If IsdbNull(rs0173!K0173_PartProduction) = False Then D0173.PartProduction = Trim$(rs0173!K0173_PartProduction)
    If IsdbNull(rs0173!K0173_STimeProduction) = False Then D0173.STimeProduction = Trim$(rs0173!K0173_STimeProduction)
    If IsdbNull(rs0173!K0173_ETimeProduction) = False Then D0173.ETimeProduction = Trim$(rs0173!K0173_ETimeProduction)
    If IsdbNull(rs0173!K0173_InchargePlan) = False Then D0173.InchargePlan = Trim$(rs0173!K0173_InchargePlan)
    If IsdbNull(rs0173!K0173_InchargeProdution) = False Then D0173.InchargeProdution = Trim$(rs0173!K0173_InchargeProdution)
    If IsdbNull(rs0173!K0173_QtyPlan) = False Then D0173.QtyPlan = Trim$(rs0173!K0173_QtyPlan)
    If IsdbNull(rs0173!K0173_QtyProd) = False Then D0173.QtyProd = Trim$(rs0173!K0173_QtyProd)
    If IsdbNull(rs0173!K0173_QtyNormal) = False Then D0173.QtyNormal = Trim$(rs0173!K0173_QtyNormal)
    If IsdbNull(rs0173!K0173_QtyDefect) = False Then D0173.QtyDefect = Trim$(rs0173!K0173_QtyDefect)
    If IsdbNull(rs0173!K0173_QtyDefectPass) = False Then D0173.QtyDefectPass = Trim$(rs0173!K0173_QtyDefectPass)
    If IsdbNull(rs0173!K0173_QtyDefectReject) = False Then D0173.QtyDefectReject = Trim$(rs0173!K0173_QtyDefectReject)
    If IsdbNull(rs0173!K0173_CheckComplete) = False Then D0173.CheckComplete = Trim$(rs0173!K0173_CheckComplete)
    If IsdbNull(rs0173!K0173_CheckTrigger) = False Then D0173.CheckTrigger = Trim$(rs0173!K0173_CheckTrigger)
    If IsdbNull(rs0173!K0173_Remark) = False Then D0173.Remark = Trim$(rs0173!K0173_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K0173_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K0173_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z0173 As T0173_AREA, AUTOKEY AS Double) as Boolean

K0173_MOVE = False

Try
    If READ_PFK0173(AUTOKEY) = True Then
                z0173 = D0173
		K0173_MOVE = True
		else
	z0173 = nothing
     End If

     If  getColumIndex(spr,"AUTOKEY") > -1 then z0173.AUTOKEY = getDataM(spr, getColumIndex(spr,"AUTOKEY"), xRow)
     If  getColumIndex(spr,"DateBackup") > -1 then z0173.DateBackup = getDataM(spr, getColumIndex(spr,"DateBackup"), xRow)
     If  getColumIndex(spr,"TimeBackup") > -1 then z0173.TimeBackup = getDataM(spr, getColumIndex(spr,"TimeBackup"), xRow)
     If  getColumIndex(spr,"cdFactory") > -1 then z0173.cdFactory = getDataM(spr, getColumIndex(spr,"cdFactory"), xRow)
     If  getColumIndex(spr,"cdMainProcess") > -1 then z0173.cdMainProcess = getDataM(spr, getColumIndex(spr,"cdMainProcess"), xRow)
     If  getColumIndex(spr,"cdLineProd") > -1 then z0173.cdLineProd = getDataM(spr, getColumIndex(spr,"cdLineProd"), xRow)
     If  getColumIndex(spr,"seMainProcess") > -1 then z0173.seMainProcess = getDataM(spr, getColumIndex(spr,"seMainProcess"), xRow)
     If  getColumIndex(spr,"seFactory") > -1 then z0173.seFactory = getDataM(spr, getColumIndex(spr,"seFactory"), xRow)
     If  getColumIndex(spr,"seLineProd") > -1 then z0173.seLineProd = getDataM(spr, getColumIndex(spr,"seLineProd"), xRow)
     If  getColumIndex(spr,"LineTno") > -1 then z0173.LineTno = getDataM(spr, getColumIndex(spr,"LineTno"), xRow)
     If  getColumIndex(spr,"SpecNo") > -1 then z0173.SpecNo = getDataM(spr, getColumIndex(spr,"SpecNo"), xRow)
     If  getColumIndex(spr,"SpecNoSeq") > -1 then z0173.SpecNoSeq = getDataM(spr, getColumIndex(spr,"SpecNoSeq"), xRow)
     If  getColumIndex(spr,"DatePlan") > -1 then z0173.DatePlan = getDataM(spr, getColumIndex(spr,"DatePlan"), xRow)
     If  getColumIndex(spr,"DateProduction") > -1 then z0173.DateProduction = getDataM(spr, getColumIndex(spr,"DateProduction"), xRow)
     If  getColumIndex(spr,"PartProduction") > -1 then z0173.PartProduction = getDataM(spr, getColumIndex(spr,"PartProduction"), xRow)
     If  getColumIndex(spr,"STimeProduction") > -1 then z0173.STimeProduction = getDataM(spr, getColumIndex(spr,"STimeProduction"), xRow)
     If  getColumIndex(spr,"ETimeProduction") > -1 then z0173.ETimeProduction = getDataM(spr, getColumIndex(spr,"ETimeProduction"), xRow)
     If  getColumIndex(spr,"InchargePlan") > -1 then z0173.InchargePlan = getDataM(spr, getColumIndex(spr,"InchargePlan"), xRow)
     If  getColumIndex(spr,"InchargeProdution") > -1 then z0173.InchargeProdution = getDataM(spr, getColumIndex(spr,"InchargeProdution"), xRow)
     If  getColumIndex(spr,"QtyPlan") > -1 then z0173.QtyPlan = getDataM(spr, getColumIndex(spr,"QtyPlan"), xRow)
     If  getColumIndex(spr,"QtyProd") > -1 then z0173.QtyProd = getDataM(spr, getColumIndex(spr,"QtyProd"), xRow)
     If  getColumIndex(spr,"QtyNormal") > -1 then z0173.QtyNormal = getDataM(spr, getColumIndex(spr,"QtyNormal"), xRow)
     If  getColumIndex(spr,"QtyDefect") > -1 then z0173.QtyDefect = getDataM(spr, getColumIndex(spr,"QtyDefect"), xRow)
     If  getColumIndex(spr,"QtyDefectPass") > -1 then z0173.QtyDefectPass = getDataM(spr, getColumIndex(spr,"QtyDefectPass"), xRow)
     If  getColumIndex(spr,"QtyDefectReject") > -1 then z0173.QtyDefectReject = getDataM(spr, getColumIndex(spr,"QtyDefectReject"), xRow)
     If  getColumIndex(spr,"CheckComplete") > -1 then z0173.CheckComplete = getDataM(spr, getColumIndex(spr,"CheckComplete"), xRow)
     If  getColumIndex(spr,"CheckTrigger") > -1 then z0173.CheckTrigger = getDataM(spr, getColumIndex(spr,"CheckTrigger"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z0173.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K0173_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K0173_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z0173 As T0173_AREA,CheckClear as Boolean,AUTOKEY AS Double) as Boolean

K0173_MOVE = False

Try
    If READ_PFK0173(AUTOKEY) = True Then
                z0173 = D0173
		K0173_MOVE = True
		else
	If CheckClear  = True then z0173 = nothing
     End If

     If  getColumIndex(spr,"AUTOKEY") > -1 then z0173.AUTOKEY = getDataM(spr, getColumIndex(spr,"AUTOKEY"), xRow)
     If  getColumIndex(spr,"DateBackup") > -1 then z0173.DateBackup = getDataM(spr, getColumIndex(spr,"DateBackup"), xRow)
     If  getColumIndex(spr,"TimeBackup") > -1 then z0173.TimeBackup = getDataM(spr, getColumIndex(spr,"TimeBackup"), xRow)
     If  getColumIndex(spr,"cdFactory") > -1 then z0173.cdFactory = getDataM(spr, getColumIndex(spr,"cdFactory"), xRow)
     If  getColumIndex(spr,"cdMainProcess") > -1 then z0173.cdMainProcess = getDataM(spr, getColumIndex(spr,"cdMainProcess"), xRow)
     If  getColumIndex(spr,"cdLineProd") > -1 then z0173.cdLineProd = getDataM(spr, getColumIndex(spr,"cdLineProd"), xRow)
     If  getColumIndex(spr,"seMainProcess") > -1 then z0173.seMainProcess = getDataM(spr, getColumIndex(spr,"seMainProcess"), xRow)
     If  getColumIndex(spr,"seFactory") > -1 then z0173.seFactory = getDataM(spr, getColumIndex(spr,"seFactory"), xRow)
     If  getColumIndex(spr,"seLineProd") > -1 then z0173.seLineProd = getDataM(spr, getColumIndex(spr,"seLineProd"), xRow)
     If  getColumIndex(spr,"LineTno") > -1 then z0173.LineTno = getDataM(spr, getColumIndex(spr,"LineTno"), xRow)
     If  getColumIndex(spr,"SpecNo") > -1 then z0173.SpecNo = getDataM(spr, getColumIndex(spr,"SpecNo"), xRow)
     If  getColumIndex(spr,"SpecNoSeq") > -1 then z0173.SpecNoSeq = getDataM(spr, getColumIndex(spr,"SpecNoSeq"), xRow)
     If  getColumIndex(spr,"DatePlan") > -1 then z0173.DatePlan = getDataM(spr, getColumIndex(spr,"DatePlan"), xRow)
     If  getColumIndex(spr,"DateProduction") > -1 then z0173.DateProduction = getDataM(spr, getColumIndex(spr,"DateProduction"), xRow)
     If  getColumIndex(spr,"PartProduction") > -1 then z0173.PartProduction = getDataM(spr, getColumIndex(spr,"PartProduction"), xRow)
     If  getColumIndex(spr,"STimeProduction") > -1 then z0173.STimeProduction = getDataM(spr, getColumIndex(spr,"STimeProduction"), xRow)
     If  getColumIndex(spr,"ETimeProduction") > -1 then z0173.ETimeProduction = getDataM(spr, getColumIndex(spr,"ETimeProduction"), xRow)
     If  getColumIndex(spr,"InchargePlan") > -1 then z0173.InchargePlan = getDataM(spr, getColumIndex(spr,"InchargePlan"), xRow)
     If  getColumIndex(spr,"InchargeProdution") > -1 then z0173.InchargeProdution = getDataM(spr, getColumIndex(spr,"InchargeProdution"), xRow)
     If  getColumIndex(spr,"QtyPlan") > -1 then z0173.QtyPlan = getDataM(spr, getColumIndex(spr,"QtyPlan"), xRow)
     If  getColumIndex(spr,"QtyProd") > -1 then z0173.QtyProd = getDataM(spr, getColumIndex(spr,"QtyProd"), xRow)
     If  getColumIndex(spr,"QtyNormal") > -1 then z0173.QtyNormal = getDataM(spr, getColumIndex(spr,"QtyNormal"), xRow)
     If  getColumIndex(spr,"QtyDefect") > -1 then z0173.QtyDefect = getDataM(spr, getColumIndex(spr,"QtyDefect"), xRow)
     If  getColumIndex(spr,"QtyDefectPass") > -1 then z0173.QtyDefectPass = getDataM(spr, getColumIndex(spr,"QtyDefectPass"), xRow)
     If  getColumIndex(spr,"QtyDefectReject") > -1 then z0173.QtyDefectReject = getDataM(spr, getColumIndex(spr,"QtyDefectReject"), xRow)
     If  getColumIndex(spr,"CheckComplete") > -1 then z0173.CheckComplete = getDataM(spr, getColumIndex(spr,"CheckComplete"), xRow)
     If  getColumIndex(spr,"CheckTrigger") > -1 then z0173.CheckTrigger = getDataM(spr, getColumIndex(spr,"CheckTrigger"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z0173.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K0173_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K0173_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z0173 As T0173_AREA, Job as String, AUTOKEY AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K0173_MOVE = False

Try
    If READ_PFK0173(AUTOKEY) = True Then
                z0173 = D0173
		K0173_MOVE = True
		else
	z0173 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK0173")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "AUTOKEY":z0173.AUTOKEY = Children(i).Code
   Case "DATEBACKUP":z0173.DateBackup = Children(i).Code
   Case "TIMEBACKUP":z0173.TimeBackup = Children(i).Code
   Case "CDFACTORY":z0173.cdFactory = Children(i).Code
   Case "CDMAINPROCESS":z0173.cdMainProcess = Children(i).Code
   Case "CDLINEPROD":z0173.cdLineProd = Children(i).Code
   Case "SEMAINPROCESS":z0173.seMainProcess = Children(i).Code
   Case "SEFACTORY":z0173.seFactory = Children(i).Code
   Case "SELINEPROD":z0173.seLineProd = Children(i).Code
   Case "LINETNO":z0173.LineTno = Children(i).Code
   Case "SPECNO":z0173.SpecNo = Children(i).Code
   Case "SPECNOSEQ":z0173.SpecNoSeq = Children(i).Code
   Case "DATEPLAN":z0173.DatePlan = Children(i).Code
   Case "DATEPRODUCTION":z0173.DateProduction = Children(i).Code
   Case "PARTPRODUCTION":z0173.PartProduction = Children(i).Code
   Case "STIMEPRODUCTION":z0173.STimeProduction = Children(i).Code
   Case "ETIMEPRODUCTION":z0173.ETimeProduction = Children(i).Code
   Case "INCHARGEPLAN":z0173.InchargePlan = Children(i).Code
   Case "INCHARGEPRODUTION":z0173.InchargeProdution = Children(i).Code
   Case "QTYPLAN":z0173.QtyPlan = Children(i).Code
   Case "QTYPROD":z0173.QtyProd = Children(i).Code
   Case "QTYNORMAL":z0173.QtyNormal = Children(i).Code
   Case "QTYDEFECT":z0173.QtyDefect = Children(i).Code
   Case "QTYDEFECTPASS":z0173.QtyDefectPass = Children(i).Code
   Case "QTYDEFECTREJECT":z0173.QtyDefectReject = Children(i).Code
   Case "CHECKCOMPLETE":z0173.CheckComplete = Children(i).Code
   Case "CHECKTRIGGER":z0173.CheckTrigger = Children(i).Code
   Case "REMARK":z0173.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "AUTOKEY":z0173.AUTOKEY = Children(i).Data
   Case "DATEBACKUP":z0173.DateBackup = Children(i).Data
   Case "TIMEBACKUP":z0173.TimeBackup = Children(i).Data
   Case "CDFACTORY":z0173.cdFactory = Children(i).Data
   Case "CDMAINPROCESS":z0173.cdMainProcess = Children(i).Data
   Case "CDLINEPROD":z0173.cdLineProd = Children(i).Data
   Case "SEMAINPROCESS":z0173.seMainProcess = Children(i).Data
   Case "SEFACTORY":z0173.seFactory = Children(i).Data
   Case "SELINEPROD":z0173.seLineProd = Children(i).Data
   Case "LINETNO":z0173.LineTno = Children(i).Data
   Case "SPECNO":z0173.SpecNo = Children(i).Data
   Case "SPECNOSEQ":z0173.SpecNoSeq = Children(i).Data
   Case "DATEPLAN":z0173.DatePlan = Children(i).Data
   Case "DATEPRODUCTION":z0173.DateProduction = Children(i).Data
   Case "PARTPRODUCTION":z0173.PartProduction = Children(i).Data
   Case "STIMEPRODUCTION":z0173.STimeProduction = Children(i).Data
   Case "ETIMEPRODUCTION":z0173.ETimeProduction = Children(i).Data
   Case "INCHARGEPLAN":z0173.InchargePlan = Children(i).Data
   Case "INCHARGEPRODUTION":z0173.InchargeProdution = Children(i).Data
   Case "QTYPLAN":z0173.QtyPlan = Children(i).Data
   Case "QTYPROD":z0173.QtyProd = Children(i).Data
   Case "QTYNORMAL":z0173.QtyNormal = Children(i).Data
   Case "QTYDEFECT":z0173.QtyDefect = Children(i).Data
   Case "QTYDEFECTPASS":z0173.QtyDefectPass = Children(i).Data
   Case "QTYDEFECTREJECT":z0173.QtyDefectReject = Children(i).Data
   Case "CHECKCOMPLETE":z0173.CheckComplete = Children(i).Data
   Case "CHECKTRIGGER":z0173.CheckTrigger = Children(i).Data
   Case "REMARK":z0173.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K0173_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K0173_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z0173 As T0173_AREA, Job as String, CheckClear as Boolean, AUTOKEY AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K0173_MOVE = False

Try
    If READ_PFK0173(AUTOKEY) = True Then
                z0173 = D0173
		K0173_MOVE = True
		else
	If CheckClear  = True then z0173 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK0173")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "AUTOKEY":z0173.AUTOKEY = Children(i).Code
   Case "DATEBACKUP":z0173.DateBackup = Children(i).Code
   Case "TIMEBACKUP":z0173.TimeBackup = Children(i).Code
   Case "CDFACTORY":z0173.cdFactory = Children(i).Code
   Case "CDMAINPROCESS":z0173.cdMainProcess = Children(i).Code
   Case "CDLINEPROD":z0173.cdLineProd = Children(i).Code
   Case "SEMAINPROCESS":z0173.seMainProcess = Children(i).Code
   Case "SEFACTORY":z0173.seFactory = Children(i).Code
   Case "SELINEPROD":z0173.seLineProd = Children(i).Code
   Case "LINETNO":z0173.LineTno = Children(i).Code
   Case "SPECNO":z0173.SpecNo = Children(i).Code
   Case "SPECNOSEQ":z0173.SpecNoSeq = Children(i).Code
   Case "DATEPLAN":z0173.DatePlan = Children(i).Code
   Case "DATEPRODUCTION":z0173.DateProduction = Children(i).Code
   Case "PARTPRODUCTION":z0173.PartProduction = Children(i).Code
   Case "STIMEPRODUCTION":z0173.STimeProduction = Children(i).Code
   Case "ETIMEPRODUCTION":z0173.ETimeProduction = Children(i).Code
   Case "INCHARGEPLAN":z0173.InchargePlan = Children(i).Code
   Case "INCHARGEPRODUTION":z0173.InchargeProdution = Children(i).Code
   Case "QTYPLAN":z0173.QtyPlan = Children(i).Code
   Case "QTYPROD":z0173.QtyProd = Children(i).Code
   Case "QTYNORMAL":z0173.QtyNormal = Children(i).Code
   Case "QTYDEFECT":z0173.QtyDefect = Children(i).Code
   Case "QTYDEFECTPASS":z0173.QtyDefectPass = Children(i).Code
   Case "QTYDEFECTREJECT":z0173.QtyDefectReject = Children(i).Code
   Case "CHECKCOMPLETE":z0173.CheckComplete = Children(i).Code
   Case "CHECKTRIGGER":z0173.CheckTrigger = Children(i).Code
   Case "REMARK":z0173.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "AUTOKEY":z0173.AUTOKEY = Children(i).Data
   Case "DATEBACKUP":z0173.DateBackup = Children(i).Data
   Case "TIMEBACKUP":z0173.TimeBackup = Children(i).Data
   Case "CDFACTORY":z0173.cdFactory = Children(i).Data
   Case "CDMAINPROCESS":z0173.cdMainProcess = Children(i).Data
   Case "CDLINEPROD":z0173.cdLineProd = Children(i).Data
   Case "SEMAINPROCESS":z0173.seMainProcess = Children(i).Data
   Case "SEFACTORY":z0173.seFactory = Children(i).Data
   Case "SELINEPROD":z0173.seLineProd = Children(i).Data
   Case "LINETNO":z0173.LineTno = Children(i).Data
   Case "SPECNO":z0173.SpecNo = Children(i).Data
   Case "SPECNOSEQ":z0173.SpecNoSeq = Children(i).Data
   Case "DATEPLAN":z0173.DatePlan = Children(i).Data
   Case "DATEPRODUCTION":z0173.DateProduction = Children(i).Data
   Case "PARTPRODUCTION":z0173.PartProduction = Children(i).Data
   Case "STIMEPRODUCTION":z0173.STimeProduction = Children(i).Data
   Case "ETIMEPRODUCTION":z0173.ETimeProduction = Children(i).Data
   Case "INCHARGEPLAN":z0173.InchargePlan = Children(i).Data
   Case "INCHARGEPRODUTION":z0173.InchargeProdution = Children(i).Data
   Case "QTYPLAN":z0173.QtyPlan = Children(i).Data
   Case "QTYPROD":z0173.QtyProd = Children(i).Data
   Case "QTYNORMAL":z0173.QtyNormal = Children(i).Data
   Case "QTYDEFECT":z0173.QtyDefect = Children(i).Data
   Case "QTYDEFECTPASS":z0173.QtyDefectPass = Children(i).Data
   Case "QTYDEFECTREJECT":z0173.QtyDefectReject = Children(i).Data
   Case "CHECKCOMPLETE":z0173.CheckComplete = Children(i).Data
   Case "CHECKTRIGGER":z0173.CheckTrigger = Children(i).Data
   Case "REMARK":z0173.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K0173_MOVE",vbCritical)
End Try
End Function 
    
End Module 
