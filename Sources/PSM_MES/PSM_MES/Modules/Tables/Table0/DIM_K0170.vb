'=========================================================================================================================================================
'   TABLE : (PFK0170)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K0170

Structure T0170_AREA
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

Public D0170 As T0170_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK0170(CDFACTORY AS String, CDMAINPROCESS AS String, CDLINEPROD AS String, LINETNO AS String) As Boolean
    READ_PFK0170 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK0170 "
    SQL = SQL & " WHERE K0170_cdFactory		 = '" & cdFactory & "' " 
    SQL = SQL & "   AND K0170_cdMainProcess		 = '" & cdMainProcess & "' " 
    SQL = SQL & "   AND K0170_cdLineProd		 = '" & cdLineProd & "' " 
    SQL = SQL & "   AND K0170_LineTno		 = '" & LineTno & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D0170_CLEAR: GoTo SKIP_READ_PFK0170
                
    Call K0170_MOVE(rd)
    READ_PFK0170 = True

SKIP_READ_PFK0170:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK0170",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK0170(CDFACTORY AS String, CDMAINPROCESS AS String, CDLINEPROD AS String, LINETNO AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK0170 "
    SQL = SQL & " WHERE K0170_cdFactory		 = '" & cdFactory & "' " 
    SQL = SQL & "   AND K0170_cdMainProcess		 = '" & cdMainProcess & "' " 
    SQL = SQL & "   AND K0170_cdLineProd		 = '" & cdLineProd & "' " 
    SQL = SQL & "   AND K0170_LineTno		 = '" & LineTno & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK0170",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK0170(z0170 As T0170_AREA) As Boolean
    WRITE_PFK0170 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z0170)
 
    SQL = " INSERT INTO PFK0170 "
    SQL = SQL & " ( "
    SQL = SQL & " K0170_cdFactory," 
    SQL = SQL & " K0170_cdMainProcess," 
    SQL = SQL & " K0170_cdLineProd," 
    SQL = SQL & " K0170_LineTno," 
    SQL = SQL & " K0170_seMainProcess," 
    SQL = SQL & " K0170_seFactory," 
    SQL = SQL & " K0170_seLineProd," 
    SQL = SQL & " K0170_SpecNo," 
    SQL = SQL & " K0170_SpecNoSeq," 
    SQL = SQL & " K0170_DatePlan," 
    SQL = SQL & " K0170_DateProduction," 
    SQL = SQL & " K0170_PartProduction," 
    SQL = SQL & " K0170_STimeProduction," 
    SQL = SQL & " K0170_ETimeProduction," 
    SQL = SQL & " K0170_InchargePlan," 
    SQL = SQL & " K0170_InchargeProdution," 
    SQL = SQL & " K0170_QtyPlan," 
    SQL = SQL & " K0170_QtyProd," 
    SQL = SQL & " K0170_QtyNormal," 
    SQL = SQL & " K0170_QtyDefect," 
    SQL = SQL & " K0170_QtyDefectPass," 
    SQL = SQL & " K0170_QtyDefectReject," 
    SQL = SQL & " K0170_CheckComplete," 
    SQL = SQL & " K0170_CheckTrigger," 
    SQL = SQL & " K0170_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z0170.cdFactory) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0170.cdMainProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0170.cdLineProd) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0170.LineTno) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0170.seMainProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0170.seFactory) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0170.seLineProd) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0170.SpecNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0170.SpecNoSeq) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0170.DatePlan) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0170.DateProduction) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0170.PartProduction) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0170.STimeProduction) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0170.ETimeProduction) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0170.InchargePlan) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0170.InchargeProdution) & "', "  
    SQL = SQL & "   " & FormatSQL(z0170.QtyPlan) & ", "  
    SQL = SQL & "   " & FormatSQL(z0170.QtyProd) & ", "  
    SQL = SQL & "   " & FormatSQL(z0170.QtyNormal) & ", "  
    SQL = SQL & "   " & FormatSQL(z0170.QtyDefect) & ", "  
    SQL = SQL & "   " & FormatSQL(z0170.QtyDefectPass) & ", "  
    SQL = SQL & "   " & FormatSQL(z0170.QtyDefectReject) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z0170.CheckComplete) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0170.CheckTrigger) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0170.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK0170 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK0170",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK0170(z0170 As T0170_AREA) As Boolean
    REWRITE_PFK0170 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z0170)
   
    SQL = " UPDATE PFK0170 SET "
    SQL = SQL & "    K0170_seMainProcess      = N'" & FormatSQL(z0170.seMainProcess) & "', " 
    SQL = SQL & "    K0170_seFactory      = N'" & FormatSQL(z0170.seFactory) & "', " 
    SQL = SQL & "    K0170_seLineProd      = N'" & FormatSQL(z0170.seLineProd) & "', " 
    SQL = SQL & "    K0170_SpecNo      = N'" & FormatSQL(z0170.SpecNo) & "', " 
    SQL = SQL & "    K0170_SpecNoSeq      = N'" & FormatSQL(z0170.SpecNoSeq) & "', " 
    SQL = SQL & "    K0170_DatePlan      = N'" & FormatSQL(z0170.DatePlan) & "', " 
    SQL = SQL & "    K0170_DateProduction      = N'" & FormatSQL(z0170.DateProduction) & "', " 
    SQL = SQL & "    K0170_PartProduction      = N'" & FormatSQL(z0170.PartProduction) & "', " 
    SQL = SQL & "    K0170_STimeProduction      = N'" & FormatSQL(z0170.STimeProduction) & "', " 
    SQL = SQL & "    K0170_ETimeProduction      = N'" & FormatSQL(z0170.ETimeProduction) & "', " 
    SQL = SQL & "    K0170_InchargePlan      = N'" & FormatSQL(z0170.InchargePlan) & "', " 
    SQL = SQL & "    K0170_InchargeProdution      = N'" & FormatSQL(z0170.InchargeProdution) & "', " 
    SQL = SQL & "    K0170_QtyPlan      =  " & FormatSQL(z0170.QtyPlan) & ", " 
    SQL = SQL & "    K0170_QtyProd      =  " & FormatSQL(z0170.QtyProd) & ", " 
    SQL = SQL & "    K0170_QtyNormal      =  " & FormatSQL(z0170.QtyNormal) & ", " 
    SQL = SQL & "    K0170_QtyDefect      =  " & FormatSQL(z0170.QtyDefect) & ", " 
    SQL = SQL & "    K0170_QtyDefectPass      =  " & FormatSQL(z0170.QtyDefectPass) & ", " 
    SQL = SQL & "    K0170_QtyDefectReject      =  " & FormatSQL(z0170.QtyDefectReject) & ", " 
    SQL = SQL & "    K0170_CheckComplete      = N'" & FormatSQL(z0170.CheckComplete) & "', " 
    SQL = SQL & "    K0170_CheckTrigger      = N'" & FormatSQL(z0170.CheckTrigger) & "', " 
    SQL = SQL & "    K0170_Remark      = N'" & FormatSQL(z0170.Remark) & "'  " 
    SQL = SQL & " WHERE K0170_cdFactory		 = '" & z0170.cdFactory & "' " 
    SQL = SQL & "   AND K0170_cdMainProcess		 = '" & z0170.cdMainProcess & "' " 
    SQL = SQL & "   AND K0170_cdLineProd		 = '" & z0170.cdLineProd & "' " 
    SQL = SQL & "   AND K0170_LineTno		 = '" & z0170.LineTno & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK0170 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK0170",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK0170(z0170 As T0170_AREA) As Boolean
    DELETE_PFK0170 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK0170 "
    SQL = SQL & " WHERE K0170_cdFactory		 = '" & z0170.cdFactory & "' " 
    SQL = SQL & "   AND K0170_cdMainProcess		 = '" & z0170.cdMainProcess & "' " 
    SQL = SQL & "   AND K0170_cdLineProd		 = '" & z0170.cdLineProd & "' " 
    SQL = SQL & "   AND K0170_LineTno		 = '" & z0170.LineTno & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK0170 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK0170",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D0170_CLEAR()
Try
    
   D0170.cdFactory = ""
   D0170.cdMainProcess = ""
   D0170.cdLineProd = ""
   D0170.LineTno = ""
   D0170.seMainProcess = ""
   D0170.seFactory = ""
   D0170.seLineProd = ""
   D0170.SpecNo = ""
   D0170.SpecNoSeq = ""
   D0170.DatePlan = ""
   D0170.DateProduction = ""
   D0170.PartProduction = ""
   D0170.STimeProduction = ""
   D0170.ETimeProduction = ""
   D0170.InchargePlan = ""
   D0170.InchargeProdution = ""
    D0170.QtyPlan = 0 
    D0170.QtyProd = 0 
    D0170.QtyNormal = 0 
    D0170.QtyDefect = 0 
    D0170.QtyDefectPass = 0 
    D0170.QtyDefectReject = 0 
   D0170.CheckComplete = ""
   D0170.CheckTrigger = ""
   D0170.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D0170_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x0170 As T0170_AREA)
Try
    
    x0170.cdFactory = trim$(  x0170.cdFactory)
    x0170.cdMainProcess = trim$(  x0170.cdMainProcess)
    x0170.cdLineProd = trim$(  x0170.cdLineProd)
    x0170.LineTno = trim$(  x0170.LineTno)
    x0170.seMainProcess = trim$(  x0170.seMainProcess)
    x0170.seFactory = trim$(  x0170.seFactory)
    x0170.seLineProd = trim$(  x0170.seLineProd)
    x0170.SpecNo = trim$(  x0170.SpecNo)
    x0170.SpecNoSeq = trim$(  x0170.SpecNoSeq)
    x0170.DatePlan = trim$(  x0170.DatePlan)
    x0170.DateProduction = trim$(  x0170.DateProduction)
    x0170.PartProduction = trim$(  x0170.PartProduction)
    x0170.STimeProduction = trim$(  x0170.STimeProduction)
    x0170.ETimeProduction = trim$(  x0170.ETimeProduction)
    x0170.InchargePlan = trim$(  x0170.InchargePlan)
    x0170.InchargeProdution = trim$(  x0170.InchargeProdution)
    x0170.QtyPlan = trim$(  x0170.QtyPlan)
    x0170.QtyProd = trim$(  x0170.QtyProd)
    x0170.QtyNormal = trim$(  x0170.QtyNormal)
    x0170.QtyDefect = trim$(  x0170.QtyDefect)
    x0170.QtyDefectPass = trim$(  x0170.QtyDefectPass)
    x0170.QtyDefectReject = trim$(  x0170.QtyDefectReject)
    x0170.CheckComplete = trim$(  x0170.CheckComplete)
    x0170.CheckTrigger = trim$(  x0170.CheckTrigger)
    x0170.Remark = trim$(  x0170.Remark)
     
    If trim$( x0170.cdFactory ) = "" Then x0170.cdFactory = Space(1) 
    If trim$( x0170.cdMainProcess ) = "" Then x0170.cdMainProcess = Space(1) 
    If trim$( x0170.cdLineProd ) = "" Then x0170.cdLineProd = Space(1) 
    If trim$( x0170.LineTno ) = "" Then x0170.LineTno = Space(1) 
    If trim$( x0170.seMainProcess ) = "" Then x0170.seMainProcess = Space(1) 
    If trim$( x0170.seFactory ) = "" Then x0170.seFactory = Space(1) 
    If trim$( x0170.seLineProd ) = "" Then x0170.seLineProd = Space(1) 
    If trim$( x0170.SpecNo ) = "" Then x0170.SpecNo = Space(1) 
    If trim$( x0170.SpecNoSeq ) = "" Then x0170.SpecNoSeq = Space(1) 
    If trim$( x0170.DatePlan ) = "" Then x0170.DatePlan = Space(1) 
    If trim$( x0170.DateProduction ) = "" Then x0170.DateProduction = Space(1) 
    If trim$( x0170.PartProduction ) = "" Then x0170.PartProduction = Space(1) 
    If trim$( x0170.STimeProduction ) = "" Then x0170.STimeProduction = Space(1) 
    If trim$( x0170.ETimeProduction ) = "" Then x0170.ETimeProduction = Space(1) 
    If trim$( x0170.InchargePlan ) = "" Then x0170.InchargePlan = Space(1) 
    If trim$( x0170.InchargeProdution ) = "" Then x0170.InchargeProdution = Space(1) 
    If trim$( x0170.QtyPlan ) = "" Then x0170.QtyPlan = 0 
    If trim$( x0170.QtyProd ) = "" Then x0170.QtyProd = 0 
    If trim$( x0170.QtyNormal ) = "" Then x0170.QtyNormal = 0 
    If trim$( x0170.QtyDefect ) = "" Then x0170.QtyDefect = 0 
    If trim$( x0170.QtyDefectPass ) = "" Then x0170.QtyDefectPass = 0 
    If trim$( x0170.QtyDefectReject ) = "" Then x0170.QtyDefectReject = 0 
    If trim$( x0170.CheckComplete ) = "" Then x0170.CheckComplete = Space(1) 
    If trim$( x0170.CheckTrigger ) = "" Then x0170.CheckTrigger = Space(1) 
    If trim$( x0170.Remark ) = "" Then x0170.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K0170_MOVE(rs0170 As SqlClient.SqlDataReader)
Try

    call D0170_CLEAR()   

    If IsdbNull(rs0170!K0170_cdFactory) = False Then D0170.cdFactory = Trim$(rs0170!K0170_cdFactory)
    If IsdbNull(rs0170!K0170_cdMainProcess) = False Then D0170.cdMainProcess = Trim$(rs0170!K0170_cdMainProcess)
    If IsdbNull(rs0170!K0170_cdLineProd) = False Then D0170.cdLineProd = Trim$(rs0170!K0170_cdLineProd)
    If IsdbNull(rs0170!K0170_LineTno) = False Then D0170.LineTno = Trim$(rs0170!K0170_LineTno)
    If IsdbNull(rs0170!K0170_seMainProcess) = False Then D0170.seMainProcess = Trim$(rs0170!K0170_seMainProcess)
    If IsdbNull(rs0170!K0170_seFactory) = False Then D0170.seFactory = Trim$(rs0170!K0170_seFactory)
    If IsdbNull(rs0170!K0170_seLineProd) = False Then D0170.seLineProd = Trim$(rs0170!K0170_seLineProd)
    If IsdbNull(rs0170!K0170_SpecNo) = False Then D0170.SpecNo = Trim$(rs0170!K0170_SpecNo)
    If IsdbNull(rs0170!K0170_SpecNoSeq) = False Then D0170.SpecNoSeq = Trim$(rs0170!K0170_SpecNoSeq)
    If IsdbNull(rs0170!K0170_DatePlan) = False Then D0170.DatePlan = Trim$(rs0170!K0170_DatePlan)
    If IsdbNull(rs0170!K0170_DateProduction) = False Then D0170.DateProduction = Trim$(rs0170!K0170_DateProduction)
    If IsdbNull(rs0170!K0170_PartProduction) = False Then D0170.PartProduction = Trim$(rs0170!K0170_PartProduction)
    If IsdbNull(rs0170!K0170_STimeProduction) = False Then D0170.STimeProduction = Trim$(rs0170!K0170_STimeProduction)
    If IsdbNull(rs0170!K0170_ETimeProduction) = False Then D0170.ETimeProduction = Trim$(rs0170!K0170_ETimeProduction)
    If IsdbNull(rs0170!K0170_InchargePlan) = False Then D0170.InchargePlan = Trim$(rs0170!K0170_InchargePlan)
    If IsdbNull(rs0170!K0170_InchargeProdution) = False Then D0170.InchargeProdution = Trim$(rs0170!K0170_InchargeProdution)
    If IsdbNull(rs0170!K0170_QtyPlan) = False Then D0170.QtyPlan = Trim$(rs0170!K0170_QtyPlan)
    If IsdbNull(rs0170!K0170_QtyProd) = False Then D0170.QtyProd = Trim$(rs0170!K0170_QtyProd)
    If IsdbNull(rs0170!K0170_QtyNormal) = False Then D0170.QtyNormal = Trim$(rs0170!K0170_QtyNormal)
    If IsdbNull(rs0170!K0170_QtyDefect) = False Then D0170.QtyDefect = Trim$(rs0170!K0170_QtyDefect)
    If IsdbNull(rs0170!K0170_QtyDefectPass) = False Then D0170.QtyDefectPass = Trim$(rs0170!K0170_QtyDefectPass)
    If IsdbNull(rs0170!K0170_QtyDefectReject) = False Then D0170.QtyDefectReject = Trim$(rs0170!K0170_QtyDefectReject)
    If IsdbNull(rs0170!K0170_CheckComplete) = False Then D0170.CheckComplete = Trim$(rs0170!K0170_CheckComplete)
    If IsdbNull(rs0170!K0170_CheckTrigger) = False Then D0170.CheckTrigger = Trim$(rs0170!K0170_CheckTrigger)
    If IsdbNull(rs0170!K0170_Remark) = False Then D0170.Remark = Trim$(rs0170!K0170_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K0170_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K0170_MOVE(rs0170 As DataRow)
Try

    call D0170_CLEAR()   

    If IsdbNull(rs0170!K0170_cdFactory) = False Then D0170.cdFactory = Trim$(rs0170!K0170_cdFactory)
    If IsdbNull(rs0170!K0170_cdMainProcess) = False Then D0170.cdMainProcess = Trim$(rs0170!K0170_cdMainProcess)
    If IsdbNull(rs0170!K0170_cdLineProd) = False Then D0170.cdLineProd = Trim$(rs0170!K0170_cdLineProd)
    If IsdbNull(rs0170!K0170_LineTno) = False Then D0170.LineTno = Trim$(rs0170!K0170_LineTno)
    If IsdbNull(rs0170!K0170_seMainProcess) = False Then D0170.seMainProcess = Trim$(rs0170!K0170_seMainProcess)
    If IsdbNull(rs0170!K0170_seFactory) = False Then D0170.seFactory = Trim$(rs0170!K0170_seFactory)
    If IsdbNull(rs0170!K0170_seLineProd) = False Then D0170.seLineProd = Trim$(rs0170!K0170_seLineProd)
    If IsdbNull(rs0170!K0170_SpecNo) = False Then D0170.SpecNo = Trim$(rs0170!K0170_SpecNo)
    If IsdbNull(rs0170!K0170_SpecNoSeq) = False Then D0170.SpecNoSeq = Trim$(rs0170!K0170_SpecNoSeq)
    If IsdbNull(rs0170!K0170_DatePlan) = False Then D0170.DatePlan = Trim$(rs0170!K0170_DatePlan)
    If IsdbNull(rs0170!K0170_DateProduction) = False Then D0170.DateProduction = Trim$(rs0170!K0170_DateProduction)
    If IsdbNull(rs0170!K0170_PartProduction) = False Then D0170.PartProduction = Trim$(rs0170!K0170_PartProduction)
    If IsdbNull(rs0170!K0170_STimeProduction) = False Then D0170.STimeProduction = Trim$(rs0170!K0170_STimeProduction)
    If IsdbNull(rs0170!K0170_ETimeProduction) = False Then D0170.ETimeProduction = Trim$(rs0170!K0170_ETimeProduction)
    If IsdbNull(rs0170!K0170_InchargePlan) = False Then D0170.InchargePlan = Trim$(rs0170!K0170_InchargePlan)
    If IsdbNull(rs0170!K0170_InchargeProdution) = False Then D0170.InchargeProdution = Trim$(rs0170!K0170_InchargeProdution)
    If IsdbNull(rs0170!K0170_QtyPlan) = False Then D0170.QtyPlan = Trim$(rs0170!K0170_QtyPlan)
    If IsdbNull(rs0170!K0170_QtyProd) = False Then D0170.QtyProd = Trim$(rs0170!K0170_QtyProd)
    If IsdbNull(rs0170!K0170_QtyNormal) = False Then D0170.QtyNormal = Trim$(rs0170!K0170_QtyNormal)
    If IsdbNull(rs0170!K0170_QtyDefect) = False Then D0170.QtyDefect = Trim$(rs0170!K0170_QtyDefect)
    If IsdbNull(rs0170!K0170_QtyDefectPass) = False Then D0170.QtyDefectPass = Trim$(rs0170!K0170_QtyDefectPass)
    If IsdbNull(rs0170!K0170_QtyDefectReject) = False Then D0170.QtyDefectReject = Trim$(rs0170!K0170_QtyDefectReject)
    If IsdbNull(rs0170!K0170_CheckComplete) = False Then D0170.CheckComplete = Trim$(rs0170!K0170_CheckComplete)
    If IsdbNull(rs0170!K0170_CheckTrigger) = False Then D0170.CheckTrigger = Trim$(rs0170!K0170_CheckTrigger)
    If IsdbNull(rs0170!K0170_Remark) = False Then D0170.Remark = Trim$(rs0170!K0170_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K0170_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K0170_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z0170 As T0170_AREA, CDFACTORY AS String, CDMAINPROCESS AS String, CDLINEPROD AS String, LINETNO AS String) as Boolean

K0170_MOVE = False

Try
    If READ_PFK0170(CDFACTORY, CDMAINPROCESS, CDLINEPROD, LINETNO) = True Then
                z0170 = D0170
		K0170_MOVE = True
		else
	z0170 = nothing
     End If

     If  getColumIndex(spr,"cdFactory") > -1 then z0170.cdFactory = getDataM(spr, getColumIndex(spr,"cdFactory"), xRow)
     If  getColumIndex(spr,"cdMainProcess") > -1 then z0170.cdMainProcess = getDataM(spr, getColumIndex(spr,"cdMainProcess"), xRow)
     If  getColumIndex(spr,"cdLineProd") > -1 then z0170.cdLineProd = getDataM(spr, getColumIndex(spr,"cdLineProd"), xRow)
     If  getColumIndex(spr,"LineTno") > -1 then z0170.LineTno = getDataM(spr, getColumIndex(spr,"LineTno"), xRow)
     If  getColumIndex(spr,"seMainProcess") > -1 then z0170.seMainProcess = getDataM(spr, getColumIndex(spr,"seMainProcess"), xRow)
     If  getColumIndex(spr,"seFactory") > -1 then z0170.seFactory = getDataM(spr, getColumIndex(spr,"seFactory"), xRow)
     If  getColumIndex(spr,"seLineProd") > -1 then z0170.seLineProd = getDataM(spr, getColumIndex(spr,"seLineProd"), xRow)
     If  getColumIndex(spr,"SpecNo") > -1 then z0170.SpecNo = getDataM(spr, getColumIndex(spr,"SpecNo"), xRow)
     If  getColumIndex(spr,"SpecNoSeq") > -1 then z0170.SpecNoSeq = getDataM(spr, getColumIndex(spr,"SpecNoSeq"), xRow)
     If  getColumIndex(spr,"DatePlan") > -1 then z0170.DatePlan = getDataM(spr, getColumIndex(spr,"DatePlan"), xRow)
     If  getColumIndex(spr,"DateProduction") > -1 then z0170.DateProduction = getDataM(spr, getColumIndex(spr,"DateProduction"), xRow)
     If  getColumIndex(spr,"PartProduction") > -1 then z0170.PartProduction = getDataM(spr, getColumIndex(spr,"PartProduction"), xRow)
     If  getColumIndex(spr,"STimeProduction") > -1 then z0170.STimeProduction = getDataM(spr, getColumIndex(spr,"STimeProduction"), xRow)
     If  getColumIndex(spr,"ETimeProduction") > -1 then z0170.ETimeProduction = getDataM(spr, getColumIndex(spr,"ETimeProduction"), xRow)
     If  getColumIndex(spr,"InchargePlan") > -1 then z0170.InchargePlan = getDataM(spr, getColumIndex(spr,"InchargePlan"), xRow)
     If  getColumIndex(spr,"InchargeProdution") > -1 then z0170.InchargeProdution = getDataM(spr, getColumIndex(spr,"InchargeProdution"), xRow)
     If  getColumIndex(spr,"QtyPlan") > -1 then z0170.QtyPlan = getDataM(spr, getColumIndex(spr,"QtyPlan"), xRow)
     If  getColumIndex(spr,"QtyProd") > -1 then z0170.QtyProd = getDataM(spr, getColumIndex(spr,"QtyProd"), xRow)
     If  getColumIndex(spr,"QtyNormal") > -1 then z0170.QtyNormal = getDataM(spr, getColumIndex(spr,"QtyNormal"), xRow)
     If  getColumIndex(spr,"QtyDefect") > -1 then z0170.QtyDefect = getDataM(spr, getColumIndex(spr,"QtyDefect"), xRow)
     If  getColumIndex(spr,"QtyDefectPass") > -1 then z0170.QtyDefectPass = getDataM(spr, getColumIndex(spr,"QtyDefectPass"), xRow)
     If  getColumIndex(spr,"QtyDefectReject") > -1 then z0170.QtyDefectReject = getDataM(spr, getColumIndex(spr,"QtyDefectReject"), xRow)
     If  getColumIndex(spr,"CheckComplete") > -1 then z0170.CheckComplete = getDataM(spr, getColumIndex(spr,"CheckComplete"), xRow)
     If  getColumIndex(spr,"CheckTrigger") > -1 then z0170.CheckTrigger = getDataM(spr, getColumIndex(spr,"CheckTrigger"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z0170.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K0170_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K0170_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z0170 As T0170_AREA,CheckClear as Boolean,CDFACTORY AS String, CDMAINPROCESS AS String, CDLINEPROD AS String, LINETNO AS String) as Boolean

K0170_MOVE = False

Try
    If READ_PFK0170(CDFACTORY, CDMAINPROCESS, CDLINEPROD, LINETNO) = True Then
                z0170 = D0170
		K0170_MOVE = True
		else
	If CheckClear  = True then z0170 = nothing
     End If

     If  getColumIndex(spr,"cdFactory") > -1 then z0170.cdFactory = getDataM(spr, getColumIndex(spr,"cdFactory"), xRow)
     If  getColumIndex(spr,"cdMainProcess") > -1 then z0170.cdMainProcess = getDataM(spr, getColumIndex(spr,"cdMainProcess"), xRow)
     If  getColumIndex(spr,"cdLineProd") > -1 then z0170.cdLineProd = getDataM(spr, getColumIndex(spr,"cdLineProd"), xRow)
     If  getColumIndex(spr,"LineTno") > -1 then z0170.LineTno = getDataM(spr, getColumIndex(spr,"LineTno"), xRow)
     If  getColumIndex(spr,"seMainProcess") > -1 then z0170.seMainProcess = getDataM(spr, getColumIndex(spr,"seMainProcess"), xRow)
     If  getColumIndex(spr,"seFactory") > -1 then z0170.seFactory = getDataM(spr, getColumIndex(spr,"seFactory"), xRow)
     If  getColumIndex(spr,"seLineProd") > -1 then z0170.seLineProd = getDataM(spr, getColumIndex(spr,"seLineProd"), xRow)
     If  getColumIndex(spr,"SpecNo") > -1 then z0170.SpecNo = getDataM(spr, getColumIndex(spr,"SpecNo"), xRow)
     If  getColumIndex(spr,"SpecNoSeq") > -1 then z0170.SpecNoSeq = getDataM(spr, getColumIndex(spr,"SpecNoSeq"), xRow)
     If  getColumIndex(spr,"DatePlan") > -1 then z0170.DatePlan = getDataM(spr, getColumIndex(spr,"DatePlan"), xRow)
     If  getColumIndex(spr,"DateProduction") > -1 then z0170.DateProduction = getDataM(spr, getColumIndex(spr,"DateProduction"), xRow)
     If  getColumIndex(spr,"PartProduction") > -1 then z0170.PartProduction = getDataM(spr, getColumIndex(spr,"PartProduction"), xRow)
     If  getColumIndex(spr,"STimeProduction") > -1 then z0170.STimeProduction = getDataM(spr, getColumIndex(spr,"STimeProduction"), xRow)
     If  getColumIndex(spr,"ETimeProduction") > -1 then z0170.ETimeProduction = getDataM(spr, getColumIndex(spr,"ETimeProduction"), xRow)
     If  getColumIndex(spr,"InchargePlan") > -1 then z0170.InchargePlan = getDataM(spr, getColumIndex(spr,"InchargePlan"), xRow)
     If  getColumIndex(spr,"InchargeProdution") > -1 then z0170.InchargeProdution = getDataM(spr, getColumIndex(spr,"InchargeProdution"), xRow)
     If  getColumIndex(spr,"QtyPlan") > -1 then z0170.QtyPlan = getDataM(spr, getColumIndex(spr,"QtyPlan"), xRow)
     If  getColumIndex(spr,"QtyProd") > -1 then z0170.QtyProd = getDataM(spr, getColumIndex(spr,"QtyProd"), xRow)
     If  getColumIndex(spr,"QtyNormal") > -1 then z0170.QtyNormal = getDataM(spr, getColumIndex(spr,"QtyNormal"), xRow)
     If  getColumIndex(spr,"QtyDefect") > -1 then z0170.QtyDefect = getDataM(spr, getColumIndex(spr,"QtyDefect"), xRow)
     If  getColumIndex(spr,"QtyDefectPass") > -1 then z0170.QtyDefectPass = getDataM(spr, getColumIndex(spr,"QtyDefectPass"), xRow)
     If  getColumIndex(spr,"QtyDefectReject") > -1 then z0170.QtyDefectReject = getDataM(spr, getColumIndex(spr,"QtyDefectReject"), xRow)
     If  getColumIndex(spr,"CheckComplete") > -1 then z0170.CheckComplete = getDataM(spr, getColumIndex(spr,"CheckComplete"), xRow)
     If  getColumIndex(spr,"CheckTrigger") > -1 then z0170.CheckTrigger = getDataM(spr, getColumIndex(spr,"CheckTrigger"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z0170.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K0170_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K0170_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z0170 As T0170_AREA, Job as String, CDFACTORY AS String, CDMAINPROCESS AS String, CDLINEPROD AS String, LINETNO AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K0170_MOVE = False

Try
    If READ_PFK0170(CDFACTORY, CDMAINPROCESS, CDLINEPROD, LINETNO) = True Then
                z0170 = D0170
		K0170_MOVE = True
		else
	z0170 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK0170")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "CDFACTORY":z0170.cdFactory = Children(i).Code
   Case "CDMAINPROCESS":z0170.cdMainProcess = Children(i).Code
   Case "CDLINEPROD":z0170.cdLineProd = Children(i).Code
   Case "LINETNO":z0170.LineTno = Children(i).Code
   Case "SEMAINPROCESS":z0170.seMainProcess = Children(i).Code
   Case "SEFACTORY":z0170.seFactory = Children(i).Code
   Case "SELINEPROD":z0170.seLineProd = Children(i).Code
   Case "SPECNO":z0170.SpecNo = Children(i).Code
   Case "SPECNOSEQ":z0170.SpecNoSeq = Children(i).Code
   Case "DATEPLAN":z0170.DatePlan = Children(i).Code
   Case "DATEPRODUCTION":z0170.DateProduction = Children(i).Code
   Case "PARTPRODUCTION":z0170.PartProduction = Children(i).Code
   Case "STIMEPRODUCTION":z0170.STimeProduction = Children(i).Code
   Case "ETIMEPRODUCTION":z0170.ETimeProduction = Children(i).Code
   Case "INCHARGEPLAN":z0170.InchargePlan = Children(i).Code
   Case "INCHARGEPRODUTION":z0170.InchargeProdution = Children(i).Code
   Case "QTYPLAN":z0170.QtyPlan = Children(i).Code
   Case "QTYPROD":z0170.QtyProd = Children(i).Code
   Case "QTYNORMAL":z0170.QtyNormal = Children(i).Code
   Case "QTYDEFECT":z0170.QtyDefect = Children(i).Code
   Case "QTYDEFECTPASS":z0170.QtyDefectPass = Children(i).Code
   Case "QTYDEFECTREJECT":z0170.QtyDefectReject = Children(i).Code
   Case "CHECKCOMPLETE":z0170.CheckComplete = Children(i).Code
   Case "CHECKTRIGGER":z0170.CheckTrigger = Children(i).Code
   Case "REMARK":z0170.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "CDFACTORY":z0170.cdFactory = Children(i).Data
   Case "CDMAINPROCESS":z0170.cdMainProcess = Children(i).Data
   Case "CDLINEPROD":z0170.cdLineProd = Children(i).Data
   Case "LINETNO":z0170.LineTno = Children(i).Data
   Case "SEMAINPROCESS":z0170.seMainProcess = Children(i).Data
   Case "SEFACTORY":z0170.seFactory = Children(i).Data
   Case "SELINEPROD":z0170.seLineProd = Children(i).Data
   Case "SPECNO":z0170.SpecNo = Children(i).Data
   Case "SPECNOSEQ":z0170.SpecNoSeq = Children(i).Data
   Case "DATEPLAN":z0170.DatePlan = Children(i).Data
   Case "DATEPRODUCTION":z0170.DateProduction = Children(i).Data
   Case "PARTPRODUCTION":z0170.PartProduction = Children(i).Data
   Case "STIMEPRODUCTION":z0170.STimeProduction = Children(i).Data
   Case "ETIMEPRODUCTION":z0170.ETimeProduction = Children(i).Data
   Case "INCHARGEPLAN":z0170.InchargePlan = Children(i).Data
   Case "INCHARGEPRODUTION":z0170.InchargeProdution = Children(i).Data
   Case "QTYPLAN":z0170.QtyPlan = Children(i).Data
   Case "QTYPROD":z0170.QtyProd = Children(i).Data
   Case "QTYNORMAL":z0170.QtyNormal = Children(i).Data
   Case "QTYDEFECT":z0170.QtyDefect = Children(i).Data
   Case "QTYDEFECTPASS":z0170.QtyDefectPass = Children(i).Data
   Case "QTYDEFECTREJECT":z0170.QtyDefectReject = Children(i).Data
   Case "CHECKCOMPLETE":z0170.CheckComplete = Children(i).Data
   Case "CHECKTRIGGER":z0170.CheckTrigger = Children(i).Data
   Case "REMARK":z0170.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K0170_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K0170_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z0170 As T0170_AREA, Job as String, CheckClear as Boolean, CDFACTORY AS String, CDMAINPROCESS AS String, CDLINEPROD AS String, LINETNO AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K0170_MOVE = False

Try
    If READ_PFK0170(CDFACTORY, CDMAINPROCESS, CDLINEPROD, LINETNO) = True Then
                z0170 = D0170
		K0170_MOVE = True
		else
	If CheckClear  = True then z0170 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK0170")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "CDFACTORY":z0170.cdFactory = Children(i).Code
   Case "CDMAINPROCESS":z0170.cdMainProcess = Children(i).Code
   Case "CDLINEPROD":z0170.cdLineProd = Children(i).Code
   Case "LINETNO":z0170.LineTno = Children(i).Code
   Case "SEMAINPROCESS":z0170.seMainProcess = Children(i).Code
   Case "SEFACTORY":z0170.seFactory = Children(i).Code
   Case "SELINEPROD":z0170.seLineProd = Children(i).Code
   Case "SPECNO":z0170.SpecNo = Children(i).Code
   Case "SPECNOSEQ":z0170.SpecNoSeq = Children(i).Code
   Case "DATEPLAN":z0170.DatePlan = Children(i).Code
   Case "DATEPRODUCTION":z0170.DateProduction = Children(i).Code
   Case "PARTPRODUCTION":z0170.PartProduction = Children(i).Code
   Case "STIMEPRODUCTION":z0170.STimeProduction = Children(i).Code
   Case "ETIMEPRODUCTION":z0170.ETimeProduction = Children(i).Code
   Case "INCHARGEPLAN":z0170.InchargePlan = Children(i).Code
   Case "INCHARGEPRODUTION":z0170.InchargeProdution = Children(i).Code
   Case "QTYPLAN":z0170.QtyPlan = Children(i).Code
   Case "QTYPROD":z0170.QtyProd = Children(i).Code
   Case "QTYNORMAL":z0170.QtyNormal = Children(i).Code
   Case "QTYDEFECT":z0170.QtyDefect = Children(i).Code
   Case "QTYDEFECTPASS":z0170.QtyDefectPass = Children(i).Code
   Case "QTYDEFECTREJECT":z0170.QtyDefectReject = Children(i).Code
   Case "CHECKCOMPLETE":z0170.CheckComplete = Children(i).Code
   Case "CHECKTRIGGER":z0170.CheckTrigger = Children(i).Code
   Case "REMARK":z0170.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "CDFACTORY":z0170.cdFactory = Children(i).Data
   Case "CDMAINPROCESS":z0170.cdMainProcess = Children(i).Data
   Case "CDLINEPROD":z0170.cdLineProd = Children(i).Data
   Case "LINETNO":z0170.LineTno = Children(i).Data
   Case "SEMAINPROCESS":z0170.seMainProcess = Children(i).Data
   Case "SEFACTORY":z0170.seFactory = Children(i).Data
   Case "SELINEPROD":z0170.seLineProd = Children(i).Data
   Case "SPECNO":z0170.SpecNo = Children(i).Data
   Case "SPECNOSEQ":z0170.SpecNoSeq = Children(i).Data
   Case "DATEPLAN":z0170.DatePlan = Children(i).Data
   Case "DATEPRODUCTION":z0170.DateProduction = Children(i).Data
   Case "PARTPRODUCTION":z0170.PartProduction = Children(i).Data
   Case "STIMEPRODUCTION":z0170.STimeProduction = Children(i).Data
   Case "ETIMEPRODUCTION":z0170.ETimeProduction = Children(i).Data
   Case "INCHARGEPLAN":z0170.InchargePlan = Children(i).Data
   Case "INCHARGEPRODUTION":z0170.InchargeProdution = Children(i).Data
   Case "QTYPLAN":z0170.QtyPlan = Children(i).Data
   Case "QTYPROD":z0170.QtyProd = Children(i).Data
   Case "QTYNORMAL":z0170.QtyNormal = Children(i).Data
   Case "QTYDEFECT":z0170.QtyDefect = Children(i).Data
   Case "QTYDEFECTPASS":z0170.QtyDefectPass = Children(i).Data
   Case "QTYDEFECTREJECT":z0170.QtyDefectReject = Children(i).Data
   Case "CHECKCOMPLETE":z0170.CheckComplete = Children(i).Data
   Case "CHECKTRIGGER":z0170.CheckTrigger = Children(i).Data
   Case "REMARK":z0170.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K0170_MOVE",vbCritical)
End Try
End Function 
    
End Module 
