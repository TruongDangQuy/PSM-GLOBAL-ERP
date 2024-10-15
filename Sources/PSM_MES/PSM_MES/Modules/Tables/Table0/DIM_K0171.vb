'=========================================================================================================================================================
'   TABLE : (PFK0171)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K0171

Structure T0171_AREA
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

Public D0171 As T0171_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK0171(CDFACTORY AS String, CDMAINPROCESS AS String, CDLINEPROD AS String, LINETNO AS String, SZNO AS String) As Boolean
    READ_PFK0171 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK0171 "
    SQL = SQL & " WHERE K0171_cdFactory		 = '" & cdFactory & "' " 
    SQL = SQL & "   AND K0171_cdMainProcess		 = '" & cdMainProcess & "' " 
    SQL = SQL & "   AND K0171_cdLineProd		 = '" & cdLineProd & "' " 
    SQL = SQL & "   AND K0171_LineTno		 = '" & LineTno & "' " 
    SQL = SQL & "   AND K0171_Szno		 = '" & Szno & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D0171_CLEAR: GoTo SKIP_READ_PFK0171
                
    Call K0171_MOVE(rd)
    READ_PFK0171 = True

SKIP_READ_PFK0171:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK0171",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK0171(CDFACTORY AS String, CDMAINPROCESS AS String, CDLINEPROD AS String, LINETNO AS String, SZNO AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK0171 "
    SQL = SQL & " WHERE K0171_cdFactory		 = '" & cdFactory & "' " 
    SQL = SQL & "   AND K0171_cdMainProcess		 = '" & cdMainProcess & "' " 
    SQL = SQL & "   AND K0171_cdLineProd		 = '" & cdLineProd & "' " 
    SQL = SQL & "   AND K0171_LineTno		 = '" & LineTno & "' " 
    SQL = SQL & "   AND K0171_Szno		 = '" & Szno & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK0171",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK0171(z0171 As T0171_AREA) As Boolean
    WRITE_PFK0171 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z0171)
 
    SQL = " INSERT INTO PFK0171 "
    SQL = SQL & " ( "
    SQL = SQL & " K0171_cdFactory," 
    SQL = SQL & " K0171_cdMainProcess," 
    SQL = SQL & " K0171_cdLineProd," 
    SQL = SQL & " K0171_LineTno," 
    SQL = SQL & " K0171_Szno," 
    SQL = SQL & " K0171_seMainProcess," 
    SQL = SQL & " K0171_seFactory," 
    SQL = SQL & " K0171_seLineProd," 
    SQL = SQL & " K0171_SpecNo," 
    SQL = SQL & " K0171_SpecNoSeq," 
    SQL = SQL & " K0171_DatePlan," 
    SQL = SQL & " K0171_DateProduction," 
    SQL = SQL & " K0171_PartProduction," 
    SQL = SQL & " K0171_STimeProduction," 
    SQL = SQL & " K0171_ETimeProduction," 
    SQL = SQL & " K0171_InchargePlan," 
    SQL = SQL & " K0171_InchargeProdution," 
    SQL = SQL & " K0171_QtyPlan," 
    SQL = SQL & " K0171_QtyProd," 
    SQL = SQL & " K0171_QtyNormal," 
    SQL = SQL & " K0171_QtyDefect," 
    SQL = SQL & " K0171_QtyDefectPass," 
    SQL = SQL & " K0171_QtyDefectReject," 
    SQL = SQL & " K0171_CheckComplete," 
    SQL = SQL & " K0171_CheckTrigger," 
    SQL = SQL & " K0171_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z0171.cdFactory) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0171.cdMainProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0171.cdLineProd) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0171.LineTno) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0171.Szno) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0171.seMainProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0171.seFactory) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0171.seLineProd) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0171.SpecNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0171.SpecNoSeq) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0171.DatePlan) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0171.DateProduction) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0171.PartProduction) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0171.STimeProduction) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0171.ETimeProduction) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0171.InchargePlan) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0171.InchargeProdution) & "', "  
    SQL = SQL & "   " & FormatSQL(z0171.QtyPlan) & ", "  
    SQL = SQL & "   " & FormatSQL(z0171.QtyProd) & ", "  
    SQL = SQL & "   " & FormatSQL(z0171.QtyNormal) & ", "  
    SQL = SQL & "   " & FormatSQL(z0171.QtyDefect) & ", "  
    SQL = SQL & "   " & FormatSQL(z0171.QtyDefectPass) & ", "  
    SQL = SQL & "   " & FormatSQL(z0171.QtyDefectReject) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z0171.CheckComplete) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0171.CheckTrigger) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0171.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK0171 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK0171",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK0171(z0171 As T0171_AREA) As Boolean
    REWRITE_PFK0171 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z0171)
   
    SQL = " UPDATE PFK0171 SET "
    SQL = SQL & "    K0171_seMainProcess      = N'" & FormatSQL(z0171.seMainProcess) & "', " 
    SQL = SQL & "    K0171_seFactory      = N'" & FormatSQL(z0171.seFactory) & "', " 
    SQL = SQL & "    K0171_seLineProd      = N'" & FormatSQL(z0171.seLineProd) & "', " 
    SQL = SQL & "    K0171_SpecNo      = N'" & FormatSQL(z0171.SpecNo) & "', " 
    SQL = SQL & "    K0171_SpecNoSeq      = N'" & FormatSQL(z0171.SpecNoSeq) & "', " 
    SQL = SQL & "    K0171_DatePlan      = N'" & FormatSQL(z0171.DatePlan) & "', " 
    SQL = SQL & "    K0171_DateProduction      = N'" & FormatSQL(z0171.DateProduction) & "', " 
    SQL = SQL & "    K0171_PartProduction      = N'" & FormatSQL(z0171.PartProduction) & "', " 
    SQL = SQL & "    K0171_STimeProduction      = N'" & FormatSQL(z0171.STimeProduction) & "', " 
    SQL = SQL & "    K0171_ETimeProduction      = N'" & FormatSQL(z0171.ETimeProduction) & "', " 
    SQL = SQL & "    K0171_InchargePlan      = N'" & FormatSQL(z0171.InchargePlan) & "', " 
    SQL = SQL & "    K0171_InchargeProdution      = N'" & FormatSQL(z0171.InchargeProdution) & "', " 
    SQL = SQL & "    K0171_QtyPlan      =  " & FormatSQL(z0171.QtyPlan) & ", " 
    SQL = SQL & "    K0171_QtyProd      =  " & FormatSQL(z0171.QtyProd) & ", " 
    SQL = SQL & "    K0171_QtyNormal      =  " & FormatSQL(z0171.QtyNormal) & ", " 
    SQL = SQL & "    K0171_QtyDefect      =  " & FormatSQL(z0171.QtyDefect) & ", " 
    SQL = SQL & "    K0171_QtyDefectPass      =  " & FormatSQL(z0171.QtyDefectPass) & ", " 
    SQL = SQL & "    K0171_QtyDefectReject      =  " & FormatSQL(z0171.QtyDefectReject) & ", " 
    SQL = SQL & "    K0171_CheckComplete      = N'" & FormatSQL(z0171.CheckComplete) & "', " 
    SQL = SQL & "    K0171_CheckTrigger      = N'" & FormatSQL(z0171.CheckTrigger) & "', " 
    SQL = SQL & "    K0171_Remark      = N'" & FormatSQL(z0171.Remark) & "'  " 
    SQL = SQL & " WHERE K0171_cdFactory		 = '" & z0171.cdFactory & "' " 
    SQL = SQL & "   AND K0171_cdMainProcess		 = '" & z0171.cdMainProcess & "' " 
    SQL = SQL & "   AND K0171_cdLineProd		 = '" & z0171.cdLineProd & "' " 
    SQL = SQL & "   AND K0171_LineTno		 = '" & z0171.LineTno & "' " 
    SQL = SQL & "   AND K0171_Szno		 = '" & z0171.Szno & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK0171 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK0171",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK0171(z0171 As T0171_AREA) As Boolean
    DELETE_PFK0171 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK0171 "
    SQL = SQL & " WHERE K0171_cdFactory		 = '" & z0171.cdFactory & "' " 
    SQL = SQL & "   AND K0171_cdMainProcess		 = '" & z0171.cdMainProcess & "' " 
    SQL = SQL & "   AND K0171_cdLineProd		 = '" & z0171.cdLineProd & "' " 
    SQL = SQL & "   AND K0171_LineTno		 = '" & z0171.LineTno & "' " 
    SQL = SQL & "   AND K0171_Szno		 = '" & z0171.Szno & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK0171 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK0171",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D0171_CLEAR()
Try
    
   D0171.cdFactory = ""
   D0171.cdMainProcess = ""
   D0171.cdLineProd = ""
   D0171.LineTno = ""
   D0171.Szno = ""
   D0171.seMainProcess = ""
   D0171.seFactory = ""
   D0171.seLineProd = ""
   D0171.SpecNo = ""
   D0171.SpecNoSeq = ""
   D0171.DatePlan = ""
   D0171.DateProduction = ""
   D0171.PartProduction = ""
   D0171.STimeProduction = ""
   D0171.ETimeProduction = ""
   D0171.InchargePlan = ""
   D0171.InchargeProdution = ""
    D0171.QtyPlan = 0 
    D0171.QtyProd = 0 
    D0171.QtyNormal = 0 
    D0171.QtyDefect = 0 
    D0171.QtyDefectPass = 0 
    D0171.QtyDefectReject = 0 
   D0171.CheckComplete = ""
   D0171.CheckTrigger = ""
   D0171.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D0171_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x0171 As T0171_AREA)
Try
    
    x0171.cdFactory = trim$(  x0171.cdFactory)
    x0171.cdMainProcess = trim$(  x0171.cdMainProcess)
    x0171.cdLineProd = trim$(  x0171.cdLineProd)
    x0171.LineTno = trim$(  x0171.LineTno)
    x0171.Szno = trim$(  x0171.Szno)
    x0171.seMainProcess = trim$(  x0171.seMainProcess)
    x0171.seFactory = trim$(  x0171.seFactory)
    x0171.seLineProd = trim$(  x0171.seLineProd)
    x0171.SpecNo = trim$(  x0171.SpecNo)
    x0171.SpecNoSeq = trim$(  x0171.SpecNoSeq)
    x0171.DatePlan = trim$(  x0171.DatePlan)
    x0171.DateProduction = trim$(  x0171.DateProduction)
    x0171.PartProduction = trim$(  x0171.PartProduction)
    x0171.STimeProduction = trim$(  x0171.STimeProduction)
    x0171.ETimeProduction = trim$(  x0171.ETimeProduction)
    x0171.InchargePlan = trim$(  x0171.InchargePlan)
    x0171.InchargeProdution = trim$(  x0171.InchargeProdution)
    x0171.QtyPlan = trim$(  x0171.QtyPlan)
    x0171.QtyProd = trim$(  x0171.QtyProd)
    x0171.QtyNormal = trim$(  x0171.QtyNormal)
    x0171.QtyDefect = trim$(  x0171.QtyDefect)
    x0171.QtyDefectPass = trim$(  x0171.QtyDefectPass)
    x0171.QtyDefectReject = trim$(  x0171.QtyDefectReject)
    x0171.CheckComplete = trim$(  x0171.CheckComplete)
    x0171.CheckTrigger = trim$(  x0171.CheckTrigger)
    x0171.Remark = trim$(  x0171.Remark)
     
    If trim$( x0171.cdFactory ) = "" Then x0171.cdFactory = Space(1) 
    If trim$( x0171.cdMainProcess ) = "" Then x0171.cdMainProcess = Space(1) 
    If trim$( x0171.cdLineProd ) = "" Then x0171.cdLineProd = Space(1) 
    If trim$( x0171.LineTno ) = "" Then x0171.LineTno = Space(1) 
    If trim$( x0171.Szno ) = "" Then x0171.Szno = Space(1) 
    If trim$( x0171.seMainProcess ) = "" Then x0171.seMainProcess = Space(1) 
    If trim$( x0171.seFactory ) = "" Then x0171.seFactory = Space(1) 
    If trim$( x0171.seLineProd ) = "" Then x0171.seLineProd = Space(1) 
    If trim$( x0171.SpecNo ) = "" Then x0171.SpecNo = Space(1) 
    If trim$( x0171.SpecNoSeq ) = "" Then x0171.SpecNoSeq = Space(1) 
    If trim$( x0171.DatePlan ) = "" Then x0171.DatePlan = Space(1) 
    If trim$( x0171.DateProduction ) = "" Then x0171.DateProduction = Space(1) 
    If trim$( x0171.PartProduction ) = "" Then x0171.PartProduction = Space(1) 
    If trim$( x0171.STimeProduction ) = "" Then x0171.STimeProduction = Space(1) 
    If trim$( x0171.ETimeProduction ) = "" Then x0171.ETimeProduction = Space(1) 
    If trim$( x0171.InchargePlan ) = "" Then x0171.InchargePlan = Space(1) 
    If trim$( x0171.InchargeProdution ) = "" Then x0171.InchargeProdution = Space(1) 
    If trim$( x0171.QtyPlan ) = "" Then x0171.QtyPlan = 0 
    If trim$( x0171.QtyProd ) = "" Then x0171.QtyProd = 0 
    If trim$( x0171.QtyNormal ) = "" Then x0171.QtyNormal = 0 
    If trim$( x0171.QtyDefect ) = "" Then x0171.QtyDefect = 0 
    If trim$( x0171.QtyDefectPass ) = "" Then x0171.QtyDefectPass = 0 
    If trim$( x0171.QtyDefectReject ) = "" Then x0171.QtyDefectReject = 0 
    If trim$( x0171.CheckComplete ) = "" Then x0171.CheckComplete = Space(1) 
    If trim$( x0171.CheckTrigger ) = "" Then x0171.CheckTrigger = Space(1) 
    If trim$( x0171.Remark ) = "" Then x0171.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K0171_MOVE(rs0171 As SqlClient.SqlDataReader)
Try

    call D0171_CLEAR()   

    If IsdbNull(rs0171!K0171_cdFactory) = False Then D0171.cdFactory = Trim$(rs0171!K0171_cdFactory)
    If IsdbNull(rs0171!K0171_cdMainProcess) = False Then D0171.cdMainProcess = Trim$(rs0171!K0171_cdMainProcess)
    If IsdbNull(rs0171!K0171_cdLineProd) = False Then D0171.cdLineProd = Trim$(rs0171!K0171_cdLineProd)
    If IsdbNull(rs0171!K0171_LineTno) = False Then D0171.LineTno = Trim$(rs0171!K0171_LineTno)
    If IsdbNull(rs0171!K0171_Szno) = False Then D0171.Szno = Trim$(rs0171!K0171_Szno)
    If IsdbNull(rs0171!K0171_seMainProcess) = False Then D0171.seMainProcess = Trim$(rs0171!K0171_seMainProcess)
    If IsdbNull(rs0171!K0171_seFactory) = False Then D0171.seFactory = Trim$(rs0171!K0171_seFactory)
    If IsdbNull(rs0171!K0171_seLineProd) = False Then D0171.seLineProd = Trim$(rs0171!K0171_seLineProd)
    If IsdbNull(rs0171!K0171_SpecNo) = False Then D0171.SpecNo = Trim$(rs0171!K0171_SpecNo)
    If IsdbNull(rs0171!K0171_SpecNoSeq) = False Then D0171.SpecNoSeq = Trim$(rs0171!K0171_SpecNoSeq)
    If IsdbNull(rs0171!K0171_DatePlan) = False Then D0171.DatePlan = Trim$(rs0171!K0171_DatePlan)
    If IsdbNull(rs0171!K0171_DateProduction) = False Then D0171.DateProduction = Trim$(rs0171!K0171_DateProduction)
    If IsdbNull(rs0171!K0171_PartProduction) = False Then D0171.PartProduction = Trim$(rs0171!K0171_PartProduction)
    If IsdbNull(rs0171!K0171_STimeProduction) = False Then D0171.STimeProduction = Trim$(rs0171!K0171_STimeProduction)
    If IsdbNull(rs0171!K0171_ETimeProduction) = False Then D0171.ETimeProduction = Trim$(rs0171!K0171_ETimeProduction)
    If IsdbNull(rs0171!K0171_InchargePlan) = False Then D0171.InchargePlan = Trim$(rs0171!K0171_InchargePlan)
    If IsdbNull(rs0171!K0171_InchargeProdution) = False Then D0171.InchargeProdution = Trim$(rs0171!K0171_InchargeProdution)
    If IsdbNull(rs0171!K0171_QtyPlan) = False Then D0171.QtyPlan = Trim$(rs0171!K0171_QtyPlan)
    If IsdbNull(rs0171!K0171_QtyProd) = False Then D0171.QtyProd = Trim$(rs0171!K0171_QtyProd)
    If IsdbNull(rs0171!K0171_QtyNormal) = False Then D0171.QtyNormal = Trim$(rs0171!K0171_QtyNormal)
    If IsdbNull(rs0171!K0171_QtyDefect) = False Then D0171.QtyDefect = Trim$(rs0171!K0171_QtyDefect)
    If IsdbNull(rs0171!K0171_QtyDefectPass) = False Then D0171.QtyDefectPass = Trim$(rs0171!K0171_QtyDefectPass)
    If IsdbNull(rs0171!K0171_QtyDefectReject) = False Then D0171.QtyDefectReject = Trim$(rs0171!K0171_QtyDefectReject)
    If IsdbNull(rs0171!K0171_CheckComplete) = False Then D0171.CheckComplete = Trim$(rs0171!K0171_CheckComplete)
    If IsdbNull(rs0171!K0171_CheckTrigger) = False Then D0171.CheckTrigger = Trim$(rs0171!K0171_CheckTrigger)
    If IsdbNull(rs0171!K0171_Remark) = False Then D0171.Remark = Trim$(rs0171!K0171_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K0171_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K0171_MOVE(rs0171 As DataRow)
Try

    call D0171_CLEAR()   

    If IsdbNull(rs0171!K0171_cdFactory) = False Then D0171.cdFactory = Trim$(rs0171!K0171_cdFactory)
    If IsdbNull(rs0171!K0171_cdMainProcess) = False Then D0171.cdMainProcess = Trim$(rs0171!K0171_cdMainProcess)
    If IsdbNull(rs0171!K0171_cdLineProd) = False Then D0171.cdLineProd = Trim$(rs0171!K0171_cdLineProd)
    If IsdbNull(rs0171!K0171_LineTno) = False Then D0171.LineTno = Trim$(rs0171!K0171_LineTno)
    If IsdbNull(rs0171!K0171_Szno) = False Then D0171.Szno = Trim$(rs0171!K0171_Szno)
    If IsdbNull(rs0171!K0171_seMainProcess) = False Then D0171.seMainProcess = Trim$(rs0171!K0171_seMainProcess)
    If IsdbNull(rs0171!K0171_seFactory) = False Then D0171.seFactory = Trim$(rs0171!K0171_seFactory)
    If IsdbNull(rs0171!K0171_seLineProd) = False Then D0171.seLineProd = Trim$(rs0171!K0171_seLineProd)
    If IsdbNull(rs0171!K0171_SpecNo) = False Then D0171.SpecNo = Trim$(rs0171!K0171_SpecNo)
    If IsdbNull(rs0171!K0171_SpecNoSeq) = False Then D0171.SpecNoSeq = Trim$(rs0171!K0171_SpecNoSeq)
    If IsdbNull(rs0171!K0171_DatePlan) = False Then D0171.DatePlan = Trim$(rs0171!K0171_DatePlan)
    If IsdbNull(rs0171!K0171_DateProduction) = False Then D0171.DateProduction = Trim$(rs0171!K0171_DateProduction)
    If IsdbNull(rs0171!K0171_PartProduction) = False Then D0171.PartProduction = Trim$(rs0171!K0171_PartProduction)
    If IsdbNull(rs0171!K0171_STimeProduction) = False Then D0171.STimeProduction = Trim$(rs0171!K0171_STimeProduction)
    If IsdbNull(rs0171!K0171_ETimeProduction) = False Then D0171.ETimeProduction = Trim$(rs0171!K0171_ETimeProduction)
    If IsdbNull(rs0171!K0171_InchargePlan) = False Then D0171.InchargePlan = Trim$(rs0171!K0171_InchargePlan)
    If IsdbNull(rs0171!K0171_InchargeProdution) = False Then D0171.InchargeProdution = Trim$(rs0171!K0171_InchargeProdution)
    If IsdbNull(rs0171!K0171_QtyPlan) = False Then D0171.QtyPlan = Trim$(rs0171!K0171_QtyPlan)
    If IsdbNull(rs0171!K0171_QtyProd) = False Then D0171.QtyProd = Trim$(rs0171!K0171_QtyProd)
    If IsdbNull(rs0171!K0171_QtyNormal) = False Then D0171.QtyNormal = Trim$(rs0171!K0171_QtyNormal)
    If IsdbNull(rs0171!K0171_QtyDefect) = False Then D0171.QtyDefect = Trim$(rs0171!K0171_QtyDefect)
    If IsdbNull(rs0171!K0171_QtyDefectPass) = False Then D0171.QtyDefectPass = Trim$(rs0171!K0171_QtyDefectPass)
    If IsdbNull(rs0171!K0171_QtyDefectReject) = False Then D0171.QtyDefectReject = Trim$(rs0171!K0171_QtyDefectReject)
    If IsdbNull(rs0171!K0171_CheckComplete) = False Then D0171.CheckComplete = Trim$(rs0171!K0171_CheckComplete)
    If IsdbNull(rs0171!K0171_CheckTrigger) = False Then D0171.CheckTrigger = Trim$(rs0171!K0171_CheckTrigger)
    If IsdbNull(rs0171!K0171_Remark) = False Then D0171.Remark = Trim$(rs0171!K0171_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K0171_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K0171_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z0171 As T0171_AREA, CDFACTORY AS String, CDMAINPROCESS AS String, CDLINEPROD AS String, LINETNO AS String, SZNO AS String) as Boolean

K0171_MOVE = False

Try
    If READ_PFK0171(CDFACTORY, CDMAINPROCESS, CDLINEPROD, LINETNO, SZNO) = True Then
                z0171 = D0171
		K0171_MOVE = True
		else
	z0171 = nothing
     End If

     If  getColumIndex(spr,"cdFactory") > -1 then z0171.cdFactory = getDataM(spr, getColumIndex(spr,"cdFactory"), xRow)
     If  getColumIndex(spr,"cdMainProcess") > -1 then z0171.cdMainProcess = getDataM(spr, getColumIndex(spr,"cdMainProcess"), xRow)
     If  getColumIndex(spr,"cdLineProd") > -1 then z0171.cdLineProd = getDataM(spr, getColumIndex(spr,"cdLineProd"), xRow)
     If  getColumIndex(spr,"LineTno") > -1 then z0171.LineTno = getDataM(spr, getColumIndex(spr,"LineTno"), xRow)
     If  getColumIndex(spr,"Szno") > -1 then z0171.Szno = getDataM(spr, getColumIndex(spr,"Szno"), xRow)
     If  getColumIndex(spr,"seMainProcess") > -1 then z0171.seMainProcess = getDataM(spr, getColumIndex(spr,"seMainProcess"), xRow)
     If  getColumIndex(spr,"seFactory") > -1 then z0171.seFactory = getDataM(spr, getColumIndex(spr,"seFactory"), xRow)
     If  getColumIndex(spr,"seLineProd") > -1 then z0171.seLineProd = getDataM(spr, getColumIndex(spr,"seLineProd"), xRow)
     If  getColumIndex(spr,"SpecNo") > -1 then z0171.SpecNo = getDataM(spr, getColumIndex(spr,"SpecNo"), xRow)
     If  getColumIndex(spr,"SpecNoSeq") > -1 then z0171.SpecNoSeq = getDataM(spr, getColumIndex(spr,"SpecNoSeq"), xRow)
     If  getColumIndex(spr,"DatePlan") > -1 then z0171.DatePlan = getDataM(spr, getColumIndex(spr,"DatePlan"), xRow)
     If  getColumIndex(spr,"DateProduction") > -1 then z0171.DateProduction = getDataM(spr, getColumIndex(spr,"DateProduction"), xRow)
     If  getColumIndex(spr,"PartProduction") > -1 then z0171.PartProduction = getDataM(spr, getColumIndex(spr,"PartProduction"), xRow)
     If  getColumIndex(spr,"STimeProduction") > -1 then z0171.STimeProduction = getDataM(spr, getColumIndex(spr,"STimeProduction"), xRow)
     If  getColumIndex(spr,"ETimeProduction") > -1 then z0171.ETimeProduction = getDataM(spr, getColumIndex(spr,"ETimeProduction"), xRow)
     If  getColumIndex(spr,"InchargePlan") > -1 then z0171.InchargePlan = getDataM(spr, getColumIndex(spr,"InchargePlan"), xRow)
     If  getColumIndex(spr,"InchargeProdution") > -1 then z0171.InchargeProdution = getDataM(spr, getColumIndex(spr,"InchargeProdution"), xRow)
     If  getColumIndex(spr,"QtyPlan") > -1 then z0171.QtyPlan = getDataM(spr, getColumIndex(spr,"QtyPlan"), xRow)
     If  getColumIndex(spr,"QtyProd") > -1 then z0171.QtyProd = getDataM(spr, getColumIndex(spr,"QtyProd"), xRow)
     If  getColumIndex(spr,"QtyNormal") > -1 then z0171.QtyNormal = getDataM(spr, getColumIndex(spr,"QtyNormal"), xRow)
     If  getColumIndex(spr,"QtyDefect") > -1 then z0171.QtyDefect = getDataM(spr, getColumIndex(spr,"QtyDefect"), xRow)
     If  getColumIndex(spr,"QtyDefectPass") > -1 then z0171.QtyDefectPass = getDataM(spr, getColumIndex(spr,"QtyDefectPass"), xRow)
     If  getColumIndex(spr,"QtyDefectReject") > -1 then z0171.QtyDefectReject = getDataM(spr, getColumIndex(spr,"QtyDefectReject"), xRow)
     If  getColumIndex(spr,"CheckComplete") > -1 then z0171.CheckComplete = getDataM(spr, getColumIndex(spr,"CheckComplete"), xRow)
     If  getColumIndex(spr,"CheckTrigger") > -1 then z0171.CheckTrigger = getDataM(spr, getColumIndex(spr,"CheckTrigger"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z0171.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K0171_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K0171_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z0171 As T0171_AREA,CheckClear as Boolean,CDFACTORY AS String, CDMAINPROCESS AS String, CDLINEPROD AS String, LINETNO AS String, SZNO AS String) as Boolean

K0171_MOVE = False

Try
    If READ_PFK0171(CDFACTORY, CDMAINPROCESS, CDLINEPROD, LINETNO, SZNO) = True Then
                z0171 = D0171
		K0171_MOVE = True
		else
	If CheckClear  = True then z0171 = nothing
     End If

     If  getColumIndex(spr,"cdFactory") > -1 then z0171.cdFactory = getDataM(spr, getColumIndex(spr,"cdFactory"), xRow)
     If  getColumIndex(spr,"cdMainProcess") > -1 then z0171.cdMainProcess = getDataM(spr, getColumIndex(spr,"cdMainProcess"), xRow)
     If  getColumIndex(spr,"cdLineProd") > -1 then z0171.cdLineProd = getDataM(spr, getColumIndex(spr,"cdLineProd"), xRow)
     If  getColumIndex(spr,"LineTno") > -1 then z0171.LineTno = getDataM(spr, getColumIndex(spr,"LineTno"), xRow)
     If  getColumIndex(spr,"Szno") > -1 then z0171.Szno = getDataM(spr, getColumIndex(spr,"Szno"), xRow)
     If  getColumIndex(spr,"seMainProcess") > -1 then z0171.seMainProcess = getDataM(spr, getColumIndex(spr,"seMainProcess"), xRow)
     If  getColumIndex(spr,"seFactory") > -1 then z0171.seFactory = getDataM(spr, getColumIndex(spr,"seFactory"), xRow)
     If  getColumIndex(spr,"seLineProd") > -1 then z0171.seLineProd = getDataM(spr, getColumIndex(spr,"seLineProd"), xRow)
     If  getColumIndex(spr,"SpecNo") > -1 then z0171.SpecNo = getDataM(spr, getColumIndex(spr,"SpecNo"), xRow)
     If  getColumIndex(spr,"SpecNoSeq") > -1 then z0171.SpecNoSeq = getDataM(spr, getColumIndex(spr,"SpecNoSeq"), xRow)
     If  getColumIndex(spr,"DatePlan") > -1 then z0171.DatePlan = getDataM(spr, getColumIndex(spr,"DatePlan"), xRow)
     If  getColumIndex(spr,"DateProduction") > -1 then z0171.DateProduction = getDataM(spr, getColumIndex(spr,"DateProduction"), xRow)
     If  getColumIndex(spr,"PartProduction") > -1 then z0171.PartProduction = getDataM(spr, getColumIndex(spr,"PartProduction"), xRow)
     If  getColumIndex(spr,"STimeProduction") > -1 then z0171.STimeProduction = getDataM(spr, getColumIndex(spr,"STimeProduction"), xRow)
     If  getColumIndex(spr,"ETimeProduction") > -1 then z0171.ETimeProduction = getDataM(spr, getColumIndex(spr,"ETimeProduction"), xRow)
     If  getColumIndex(spr,"InchargePlan") > -1 then z0171.InchargePlan = getDataM(spr, getColumIndex(spr,"InchargePlan"), xRow)
     If  getColumIndex(spr,"InchargeProdution") > -1 then z0171.InchargeProdution = getDataM(spr, getColumIndex(spr,"InchargeProdution"), xRow)
     If  getColumIndex(spr,"QtyPlan") > -1 then z0171.QtyPlan = getDataM(spr, getColumIndex(spr,"QtyPlan"), xRow)
     If  getColumIndex(spr,"QtyProd") > -1 then z0171.QtyProd = getDataM(spr, getColumIndex(spr,"QtyProd"), xRow)
     If  getColumIndex(spr,"QtyNormal") > -1 then z0171.QtyNormal = getDataM(spr, getColumIndex(spr,"QtyNormal"), xRow)
     If  getColumIndex(spr,"QtyDefect") > -1 then z0171.QtyDefect = getDataM(spr, getColumIndex(spr,"QtyDefect"), xRow)
     If  getColumIndex(spr,"QtyDefectPass") > -1 then z0171.QtyDefectPass = getDataM(spr, getColumIndex(spr,"QtyDefectPass"), xRow)
     If  getColumIndex(spr,"QtyDefectReject") > -1 then z0171.QtyDefectReject = getDataM(spr, getColumIndex(spr,"QtyDefectReject"), xRow)
     If  getColumIndex(spr,"CheckComplete") > -1 then z0171.CheckComplete = getDataM(spr, getColumIndex(spr,"CheckComplete"), xRow)
     If  getColumIndex(spr,"CheckTrigger") > -1 then z0171.CheckTrigger = getDataM(spr, getColumIndex(spr,"CheckTrigger"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z0171.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K0171_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K0171_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z0171 As T0171_AREA, Job as String, CDFACTORY AS String, CDMAINPROCESS AS String, CDLINEPROD AS String, LINETNO AS String, SZNO AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K0171_MOVE = False

Try
    If READ_PFK0171(CDFACTORY, CDMAINPROCESS, CDLINEPROD, LINETNO, SZNO) = True Then
                z0171 = D0171
		K0171_MOVE = True
		else
	z0171 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK0171")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "CDFACTORY":z0171.cdFactory = Children(i).Code
   Case "CDMAINPROCESS":z0171.cdMainProcess = Children(i).Code
   Case "CDLINEPROD":z0171.cdLineProd = Children(i).Code
   Case "LINETNO":z0171.LineTno = Children(i).Code
   Case "SZNO":z0171.Szno = Children(i).Code
   Case "SEMAINPROCESS":z0171.seMainProcess = Children(i).Code
   Case "SEFACTORY":z0171.seFactory = Children(i).Code
   Case "SELINEPROD":z0171.seLineProd = Children(i).Code
   Case "SPECNO":z0171.SpecNo = Children(i).Code
   Case "SPECNOSEQ":z0171.SpecNoSeq = Children(i).Code
   Case "DATEPLAN":z0171.DatePlan = Children(i).Code
   Case "DATEPRODUCTION":z0171.DateProduction = Children(i).Code
   Case "PARTPRODUCTION":z0171.PartProduction = Children(i).Code
   Case "STIMEPRODUCTION":z0171.STimeProduction = Children(i).Code
   Case "ETIMEPRODUCTION":z0171.ETimeProduction = Children(i).Code
   Case "INCHARGEPLAN":z0171.InchargePlan = Children(i).Code
   Case "INCHARGEPRODUTION":z0171.InchargeProdution = Children(i).Code
   Case "QTYPLAN":z0171.QtyPlan = Children(i).Code
   Case "QTYPROD":z0171.QtyProd = Children(i).Code
   Case "QTYNORMAL":z0171.QtyNormal = Children(i).Code
   Case "QTYDEFECT":z0171.QtyDefect = Children(i).Code
   Case "QTYDEFECTPASS":z0171.QtyDefectPass = Children(i).Code
   Case "QTYDEFECTREJECT":z0171.QtyDefectReject = Children(i).Code
   Case "CHECKCOMPLETE":z0171.CheckComplete = Children(i).Code
   Case "CHECKTRIGGER":z0171.CheckTrigger = Children(i).Code
   Case "REMARK":z0171.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "CDFACTORY":z0171.cdFactory = Children(i).Data
   Case "CDMAINPROCESS":z0171.cdMainProcess = Children(i).Data
   Case "CDLINEPROD":z0171.cdLineProd = Children(i).Data
   Case "LINETNO":z0171.LineTno = Children(i).Data
   Case "SZNO":z0171.Szno = Children(i).Data
   Case "SEMAINPROCESS":z0171.seMainProcess = Children(i).Data
   Case "SEFACTORY":z0171.seFactory = Children(i).Data
   Case "SELINEPROD":z0171.seLineProd = Children(i).Data
   Case "SPECNO":z0171.SpecNo = Children(i).Data
   Case "SPECNOSEQ":z0171.SpecNoSeq = Children(i).Data
   Case "DATEPLAN":z0171.DatePlan = Children(i).Data
   Case "DATEPRODUCTION":z0171.DateProduction = Children(i).Data
   Case "PARTPRODUCTION":z0171.PartProduction = Children(i).Data
   Case "STIMEPRODUCTION":z0171.STimeProduction = Children(i).Data
   Case "ETIMEPRODUCTION":z0171.ETimeProduction = Children(i).Data
   Case "INCHARGEPLAN":z0171.InchargePlan = Children(i).Data
   Case "INCHARGEPRODUTION":z0171.InchargeProdution = Children(i).Data
   Case "QTYPLAN":z0171.QtyPlan = Children(i).Data
   Case "QTYPROD":z0171.QtyProd = Children(i).Data
   Case "QTYNORMAL":z0171.QtyNormal = Children(i).Data
   Case "QTYDEFECT":z0171.QtyDefect = Children(i).Data
   Case "QTYDEFECTPASS":z0171.QtyDefectPass = Children(i).Data
   Case "QTYDEFECTREJECT":z0171.QtyDefectReject = Children(i).Data
   Case "CHECKCOMPLETE":z0171.CheckComplete = Children(i).Data
   Case "CHECKTRIGGER":z0171.CheckTrigger = Children(i).Data
   Case "REMARK":z0171.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K0171_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K0171_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z0171 As T0171_AREA, Job as String, CheckClear as Boolean, CDFACTORY AS String, CDMAINPROCESS AS String, CDLINEPROD AS String, LINETNO AS String, SZNO AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K0171_MOVE = False

Try
    If READ_PFK0171(CDFACTORY, CDMAINPROCESS, CDLINEPROD, LINETNO, SZNO) = True Then
                z0171 = D0171
		K0171_MOVE = True
		else
	If CheckClear  = True then z0171 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK0171")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "CDFACTORY":z0171.cdFactory = Children(i).Code
   Case "CDMAINPROCESS":z0171.cdMainProcess = Children(i).Code
   Case "CDLINEPROD":z0171.cdLineProd = Children(i).Code
   Case "LINETNO":z0171.LineTno = Children(i).Code
   Case "SZNO":z0171.Szno = Children(i).Code
   Case "SEMAINPROCESS":z0171.seMainProcess = Children(i).Code
   Case "SEFACTORY":z0171.seFactory = Children(i).Code
   Case "SELINEPROD":z0171.seLineProd = Children(i).Code
   Case "SPECNO":z0171.SpecNo = Children(i).Code
   Case "SPECNOSEQ":z0171.SpecNoSeq = Children(i).Code
   Case "DATEPLAN":z0171.DatePlan = Children(i).Code
   Case "DATEPRODUCTION":z0171.DateProduction = Children(i).Code
   Case "PARTPRODUCTION":z0171.PartProduction = Children(i).Code
   Case "STIMEPRODUCTION":z0171.STimeProduction = Children(i).Code
   Case "ETIMEPRODUCTION":z0171.ETimeProduction = Children(i).Code
   Case "INCHARGEPLAN":z0171.InchargePlan = Children(i).Code
   Case "INCHARGEPRODUTION":z0171.InchargeProdution = Children(i).Code
   Case "QTYPLAN":z0171.QtyPlan = Children(i).Code
   Case "QTYPROD":z0171.QtyProd = Children(i).Code
   Case "QTYNORMAL":z0171.QtyNormal = Children(i).Code
   Case "QTYDEFECT":z0171.QtyDefect = Children(i).Code
   Case "QTYDEFECTPASS":z0171.QtyDefectPass = Children(i).Code
   Case "QTYDEFECTREJECT":z0171.QtyDefectReject = Children(i).Code
   Case "CHECKCOMPLETE":z0171.CheckComplete = Children(i).Code
   Case "CHECKTRIGGER":z0171.CheckTrigger = Children(i).Code
   Case "REMARK":z0171.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "CDFACTORY":z0171.cdFactory = Children(i).Data
   Case "CDMAINPROCESS":z0171.cdMainProcess = Children(i).Data
   Case "CDLINEPROD":z0171.cdLineProd = Children(i).Data
   Case "LINETNO":z0171.LineTno = Children(i).Data
   Case "SZNO":z0171.Szno = Children(i).Data
   Case "SEMAINPROCESS":z0171.seMainProcess = Children(i).Data
   Case "SEFACTORY":z0171.seFactory = Children(i).Data
   Case "SELINEPROD":z0171.seLineProd = Children(i).Data
   Case "SPECNO":z0171.SpecNo = Children(i).Data
   Case "SPECNOSEQ":z0171.SpecNoSeq = Children(i).Data
   Case "DATEPLAN":z0171.DatePlan = Children(i).Data
   Case "DATEPRODUCTION":z0171.DateProduction = Children(i).Data
   Case "PARTPRODUCTION":z0171.PartProduction = Children(i).Data
   Case "STIMEPRODUCTION":z0171.STimeProduction = Children(i).Data
   Case "ETIMEPRODUCTION":z0171.ETimeProduction = Children(i).Data
   Case "INCHARGEPLAN":z0171.InchargePlan = Children(i).Data
   Case "INCHARGEPRODUTION":z0171.InchargeProdution = Children(i).Data
   Case "QTYPLAN":z0171.QtyPlan = Children(i).Data
   Case "QTYPROD":z0171.QtyProd = Children(i).Data
   Case "QTYNORMAL":z0171.QtyNormal = Children(i).Data
   Case "QTYDEFECT":z0171.QtyDefect = Children(i).Data
   Case "QTYDEFECTPASS":z0171.QtyDefectPass = Children(i).Data
   Case "QTYDEFECTREJECT":z0171.QtyDefectReject = Children(i).Data
   Case "CHECKCOMPLETE":z0171.CheckComplete = Children(i).Data
   Case "CHECKTRIGGER":z0171.CheckTrigger = Children(i).Data
   Case "REMARK":z0171.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K0171_MOVE",vbCritical)
End Try
End Function 
    
End Module 
