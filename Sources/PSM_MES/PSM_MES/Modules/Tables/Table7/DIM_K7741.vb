'=========================================================================================================================================================
'   TABLE : (PFK7741)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7741

Structure T7741_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	cdFactory	 AS String	'			char(3)		*
Public 	cdSubProcess	 AS String	'			char(3)		*
Public 	DatePlan	 AS String	'			char(8)		*
Public 	cdLineProd	 AS String	'			char(3)		*
Public 	seMainProcess	 AS String	'			char(3)
Public 	cdMainProcess	 AS String	'			char(3)
Public 	seFactory	 AS String	'			char(3)
Public 	seSubProcess	 AS String	'			char(3)
Public 	seLineProd	 AS String	'			char(3)
Public 	Dseq	 AS Double	'			decimal
Public 	TimeJob	 AS String	'			nvarchar(16)
Public 	InchargePlan	 AS String	'			char(8)
Public 	QtyTargetDay	 AS Double	'			decimal
Public 	QtyTargetHour	 AS Double	'			decimal
Public 	QtyRateSecond	 AS Double	'			decimal
Public 	PersonPresent	 AS Double	'			decimal
Public 	QtyDateProd	 AS Double	'			decimal
Public 	QtyDateProdNormal	 AS Double	'			decimal
Public 	QtyDateProdDefect	 AS Double	'			decimal
Public 	QtyDateDefectPass	 AS Double	'			decimal
Public 	QtyDateDefectReject	 AS Double	'			decimal
Public 	Team	 AS String	'			nvarchar(12)
Public 	CheckUse	 AS String	'			char(1)
'=========================================================================================================================================================
End structure

Public D7741 As T7741_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK7741(CDFACTORY AS String, CDSUBPROCESS AS String, DATEPLAN AS String, CDLINEPROD AS String) As Boolean
    READ_PFK7741 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7741 "
    SQL = SQL & " WHERE K7741_cdFactory		 = '" & cdFactory & "' " 
    SQL = SQL & "   AND K7741_cdSubProcess		 = '" & cdSubProcess & "' " 
    SQL = SQL & "   AND K7741_DatePlan		 = '" & DatePlan & "' " 
    SQL = SQL & "   AND K7741_cdLineProd		 = '" & cdLineProd & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D7741_CLEAR: GoTo SKIP_READ_PFK7741
                
    Call K7741_MOVE(rd)
    READ_PFK7741 = True

SKIP_READ_PFK7741:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK7741",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK7741(CDFACTORY AS String, CDSUBPROCESS AS String, DATEPLAN AS String, CDLINEPROD AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7741 "
    SQL = SQL & " WHERE K7741_cdFactory		 = '" & cdFactory & "' " 
    SQL = SQL & "   AND K7741_cdSubProcess		 = '" & cdSubProcess & "' " 
    SQL = SQL & "   AND K7741_DatePlan		 = '" & DatePlan & "' " 
    SQL = SQL & "   AND K7741_cdLineProd		 = '" & cdLineProd & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK7741",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK7741(z7741 As T7741_AREA) As Boolean
    WRITE_PFK7741 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z7741)
 
    SQL = " INSERT INTO PFK7741 "
    SQL = SQL & " ( "
    SQL = SQL & " K7741_cdFactory," 
    SQL = SQL & " K7741_cdSubProcess," 
    SQL = SQL & " K7741_DatePlan," 
    SQL = SQL & " K7741_cdLineProd," 
    SQL = SQL & " K7741_seMainProcess," 
    SQL = SQL & " K7741_cdMainProcess," 
    SQL = SQL & " K7741_seFactory," 
    SQL = SQL & " K7741_seSubProcess," 
    SQL = SQL & " K7741_seLineProd," 
    SQL = SQL & " K7741_Dseq," 
    SQL = SQL & " K7741_TimeJob," 
    SQL = SQL & " K7741_InchargePlan," 
    SQL = SQL & " K7741_QtyTargetDay," 
    SQL = SQL & " K7741_QtyTargetHour," 
    SQL = SQL & " K7741_QtyRateSecond," 
    SQL = SQL & " K7741_PersonPresent," 
    SQL = SQL & " K7741_QtyDateProd," 
    SQL = SQL & " K7741_QtyDateProdNormal," 
    SQL = SQL & " K7741_QtyDateProdDefect," 
    SQL = SQL & " K7741_QtyDateDefectPass," 
    SQL = SQL & " K7741_QtyDateDefectReject," 
    SQL = SQL & " K7741_Team," 
    SQL = SQL & " K7741_CheckUse " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z7741.cdFactory) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7741.cdSubProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7741.DatePlan) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7741.cdLineProd) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7741.seMainProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7741.cdMainProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7741.seFactory) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7741.seSubProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7741.seLineProd) & "', "  
    SQL = SQL & "   " & FormatSQL(z7741.Dseq) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z7741.TimeJob) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7741.InchargePlan) & "', "  
    SQL = SQL & "   " & FormatSQL(z7741.QtyTargetDay) & ", "  
    SQL = SQL & "   " & FormatSQL(z7741.QtyTargetHour) & ", "  
    SQL = SQL & "   " & FormatSQL(z7741.QtyRateSecond) & ", "  
    SQL = SQL & "   " & FormatSQL(z7741.PersonPresent) & ", "  
    SQL = SQL & "   " & FormatSQL(z7741.QtyDateProd) & ", "  
    SQL = SQL & "   " & FormatSQL(z7741.QtyDateProdNormal) & ", "  
    SQL = SQL & "   " & FormatSQL(z7741.QtyDateProdDefect) & ", "  
    SQL = SQL & "   " & FormatSQL(z7741.QtyDateDefectPass) & ", "  
    SQL = SQL & "   " & FormatSQL(z7741.QtyDateDefectReject) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z7741.Team) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7741.CheckUse) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK7741 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK7741",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK7741(z7741 As T7741_AREA) As Boolean
    REWRITE_PFK7741 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7741)
   
    SQL = " UPDATE PFK7741 SET "
    SQL = SQL & "    K7741_seMainProcess      = N'" & FormatSQL(z7741.seMainProcess) & "', " 
    SQL = SQL & "    K7741_cdMainProcess      = N'" & FormatSQL(z7741.cdMainProcess) & "', " 
    SQL = SQL & "    K7741_seFactory      = N'" & FormatSQL(z7741.seFactory) & "', " 
    SQL = SQL & "    K7741_seSubProcess      = N'" & FormatSQL(z7741.seSubProcess) & "', " 
    SQL = SQL & "    K7741_seLineProd      = N'" & FormatSQL(z7741.seLineProd) & "', " 
    SQL = SQL & "    K7741_Dseq      =  " & FormatSQL(z7741.Dseq) & ", " 
    SQL = SQL & "    K7741_TimeJob      = N'" & FormatSQL(z7741.TimeJob) & "', " 
    SQL = SQL & "    K7741_InchargePlan      = N'" & FormatSQL(z7741.InchargePlan) & "', " 
    SQL = SQL & "    K7741_QtyTargetDay      =  " & FormatSQL(z7741.QtyTargetDay) & ", " 
    SQL = SQL & "    K7741_QtyTargetHour      =  " & FormatSQL(z7741.QtyTargetHour) & ", " 
    SQL = SQL & "    K7741_QtyRateSecond      =  " & FormatSQL(z7741.QtyRateSecond) & ", " 
    SQL = SQL & "    K7741_PersonPresent      =  " & FormatSQL(z7741.PersonPresent) & ", " 
    SQL = SQL & "    K7741_QtyDateProd      =  " & FormatSQL(z7741.QtyDateProd) & ", " 
    SQL = SQL & "    K7741_QtyDateProdNormal      =  " & FormatSQL(z7741.QtyDateProdNormal) & ", " 
    SQL = SQL & "    K7741_QtyDateProdDefect      =  " & FormatSQL(z7741.QtyDateProdDefect) & ", " 
    SQL = SQL & "    K7741_QtyDateDefectPass      =  " & FormatSQL(z7741.QtyDateDefectPass) & ", " 
    SQL = SQL & "    K7741_QtyDateDefectReject      =  " & FormatSQL(z7741.QtyDateDefectReject) & ", " 
    SQL = SQL & "    K7741_Team      = N'" & FormatSQL(z7741.Team) & "', " 
    SQL = SQL & "    K7741_CheckUse      = N'" & FormatSQL(z7741.CheckUse) & "'  " 
    SQL = SQL & " WHERE K7741_cdFactory		 = '" & z7741.cdFactory & "' " 
    SQL = SQL & "   AND K7741_cdSubProcess		 = '" & z7741.cdSubProcess & "' " 
    SQL = SQL & "   AND K7741_DatePlan		 = '" & z7741.DatePlan & "' " 
    SQL = SQL & "   AND K7741_cdLineProd		 = '" & z7741.cdLineProd & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK7741 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK7741",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK7741(z7741 As T7741_AREA) As Boolean
    DELETE_PFK7741 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK7741 "
    SQL = SQL & " WHERE K7741_cdFactory		 = '" & z7741.cdFactory & "' " 
    SQL = SQL & "   AND K7741_cdSubProcess		 = '" & z7741.cdSubProcess & "' " 
    SQL = SQL & "   AND K7741_DatePlan		 = '" & z7741.DatePlan & "' " 
    SQL = SQL & "   AND K7741_cdLineProd		 = '" & z7741.cdLineProd & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK7741 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK7741",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D7741_CLEAR()
Try
    
   D7741.cdFactory = ""
   D7741.cdSubProcess = ""
   D7741.DatePlan = ""
   D7741.cdLineProd = ""
   D7741.seMainProcess = ""
   D7741.cdMainProcess = ""
   D7741.seFactory = ""
   D7741.seSubProcess = ""
   D7741.seLineProd = ""
    D7741.Dseq = 0 
   D7741.TimeJob = ""
   D7741.InchargePlan = ""
    D7741.QtyTargetDay = 0 
    D7741.QtyTargetHour = 0 
    D7741.QtyRateSecond = 0 
    D7741.PersonPresent = 0 
    D7741.QtyDateProd = 0 
    D7741.QtyDateProdNormal = 0 
    D7741.QtyDateProdDefect = 0 
    D7741.QtyDateDefectPass = 0 
    D7741.QtyDateDefectReject = 0 
   D7741.Team = ""
   D7741.CheckUse = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D7741_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x7741 As T7741_AREA)
Try
    
    x7741.cdFactory = trim$(  x7741.cdFactory)
    x7741.cdSubProcess = trim$(  x7741.cdSubProcess)
    x7741.DatePlan = trim$(  x7741.DatePlan)
    x7741.cdLineProd = trim$(  x7741.cdLineProd)
    x7741.seMainProcess = trim$(  x7741.seMainProcess)
    x7741.cdMainProcess = trim$(  x7741.cdMainProcess)
    x7741.seFactory = trim$(  x7741.seFactory)
    x7741.seSubProcess = trim$(  x7741.seSubProcess)
    x7741.seLineProd = trim$(  x7741.seLineProd)
    x7741.Dseq = trim$(  x7741.Dseq)
    x7741.TimeJob = trim$(  x7741.TimeJob)
    x7741.InchargePlan = trim$(  x7741.InchargePlan)
    x7741.QtyTargetDay = trim$(  x7741.QtyTargetDay)
    x7741.QtyTargetHour = trim$(  x7741.QtyTargetHour)
    x7741.QtyRateSecond = trim$(  x7741.QtyRateSecond)
    x7741.PersonPresent = trim$(  x7741.PersonPresent)
    x7741.QtyDateProd = trim$(  x7741.QtyDateProd)
    x7741.QtyDateProdNormal = trim$(  x7741.QtyDateProdNormal)
    x7741.QtyDateProdDefect = trim$(  x7741.QtyDateProdDefect)
    x7741.QtyDateDefectPass = trim$(  x7741.QtyDateDefectPass)
    x7741.QtyDateDefectReject = trim$(  x7741.QtyDateDefectReject)
    x7741.Team = trim$(  x7741.Team)
    x7741.CheckUse = trim$(  x7741.CheckUse)
     
    If trim$( x7741.cdFactory ) = "" Then x7741.cdFactory = Space(1) 
    If trim$( x7741.cdSubProcess ) = "" Then x7741.cdSubProcess = Space(1) 
    If trim$( x7741.DatePlan ) = "" Then x7741.DatePlan = Space(1) 
    If trim$( x7741.cdLineProd ) = "" Then x7741.cdLineProd = Space(1) 
    If trim$( x7741.seMainProcess ) = "" Then x7741.seMainProcess = Space(1) 
    If trim$( x7741.cdMainProcess ) = "" Then x7741.cdMainProcess = Space(1) 
    If trim$( x7741.seFactory ) = "" Then x7741.seFactory = Space(1) 
    If trim$( x7741.seSubProcess ) = "" Then x7741.seSubProcess = Space(1) 
    If trim$( x7741.seLineProd ) = "" Then x7741.seLineProd = Space(1) 
    If trim$( x7741.Dseq ) = "" Then x7741.Dseq = 0 
    If trim$( x7741.TimeJob ) = "" Then x7741.TimeJob = Space(1) 
    If trim$( x7741.InchargePlan ) = "" Then x7741.InchargePlan = Space(1) 
    If trim$( x7741.QtyTargetDay ) = "" Then x7741.QtyTargetDay = 0 
    If trim$( x7741.QtyTargetHour ) = "" Then x7741.QtyTargetHour = 0 
    If trim$( x7741.QtyRateSecond ) = "" Then x7741.QtyRateSecond = 0 
    If trim$( x7741.PersonPresent ) = "" Then x7741.PersonPresent = 0 
    If trim$( x7741.QtyDateProd ) = "" Then x7741.QtyDateProd = 0 
    If trim$( x7741.QtyDateProdNormal ) = "" Then x7741.QtyDateProdNormal = 0 
    If trim$( x7741.QtyDateProdDefect ) = "" Then x7741.QtyDateProdDefect = 0 
    If trim$( x7741.QtyDateDefectPass ) = "" Then x7741.QtyDateDefectPass = 0 
    If trim$( x7741.QtyDateDefectReject ) = "" Then x7741.QtyDateDefectReject = 0 
    If trim$( x7741.Team ) = "" Then x7741.Team = Space(1) 
    If trim$( x7741.CheckUse ) = "" Then x7741.CheckUse = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K7741_MOVE(rs7741 As SqlClient.SqlDataReader)
Try

    call D7741_CLEAR()   

    If IsdbNull(rs7741!K7741_cdFactory) = False Then D7741.cdFactory = Trim$(rs7741!K7741_cdFactory)
    If IsdbNull(rs7741!K7741_cdSubProcess) = False Then D7741.cdSubProcess = Trim$(rs7741!K7741_cdSubProcess)
    If IsdbNull(rs7741!K7741_DatePlan) = False Then D7741.DatePlan = Trim$(rs7741!K7741_DatePlan)
    If IsdbNull(rs7741!K7741_cdLineProd) = False Then D7741.cdLineProd = Trim$(rs7741!K7741_cdLineProd)
    If IsdbNull(rs7741!K7741_seMainProcess) = False Then D7741.seMainProcess = Trim$(rs7741!K7741_seMainProcess)
    If IsdbNull(rs7741!K7741_cdMainProcess) = False Then D7741.cdMainProcess = Trim$(rs7741!K7741_cdMainProcess)
    If IsdbNull(rs7741!K7741_seFactory) = False Then D7741.seFactory = Trim$(rs7741!K7741_seFactory)
    If IsdbNull(rs7741!K7741_seSubProcess) = False Then D7741.seSubProcess = Trim$(rs7741!K7741_seSubProcess)
    If IsdbNull(rs7741!K7741_seLineProd) = False Then D7741.seLineProd = Trim$(rs7741!K7741_seLineProd)
    If IsdbNull(rs7741!K7741_Dseq) = False Then D7741.Dseq = Trim$(rs7741!K7741_Dseq)
    If IsdbNull(rs7741!K7741_TimeJob) = False Then D7741.TimeJob = Trim$(rs7741!K7741_TimeJob)
    If IsdbNull(rs7741!K7741_InchargePlan) = False Then D7741.InchargePlan = Trim$(rs7741!K7741_InchargePlan)
    If IsdbNull(rs7741!K7741_QtyTargetDay) = False Then D7741.QtyTargetDay = Trim$(rs7741!K7741_QtyTargetDay)
    If IsdbNull(rs7741!K7741_QtyTargetHour) = False Then D7741.QtyTargetHour = Trim$(rs7741!K7741_QtyTargetHour)
    If IsdbNull(rs7741!K7741_QtyRateSecond) = False Then D7741.QtyRateSecond = Trim$(rs7741!K7741_QtyRateSecond)
    If IsdbNull(rs7741!K7741_PersonPresent) = False Then D7741.PersonPresent = Trim$(rs7741!K7741_PersonPresent)
    If IsdbNull(rs7741!K7741_QtyDateProd) = False Then D7741.QtyDateProd = Trim$(rs7741!K7741_QtyDateProd)
    If IsdbNull(rs7741!K7741_QtyDateProdNormal) = False Then D7741.QtyDateProdNormal = Trim$(rs7741!K7741_QtyDateProdNormal)
    If IsdbNull(rs7741!K7741_QtyDateProdDefect) = False Then D7741.QtyDateProdDefect = Trim$(rs7741!K7741_QtyDateProdDefect)
    If IsdbNull(rs7741!K7741_QtyDateDefectPass) = False Then D7741.QtyDateDefectPass = Trim$(rs7741!K7741_QtyDateDefectPass)
    If IsdbNull(rs7741!K7741_QtyDateDefectReject) = False Then D7741.QtyDateDefectReject = Trim$(rs7741!K7741_QtyDateDefectReject)
    If IsdbNull(rs7741!K7741_Team) = False Then D7741.Team = Trim$(rs7741!K7741_Team)
    If IsdbNull(rs7741!K7741_CheckUse) = False Then D7741.CheckUse = Trim$(rs7741!K7741_CheckUse)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7741_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K7741_MOVE(rs7741 As DataRow)
Try

    call D7741_CLEAR()   

    If IsdbNull(rs7741!K7741_cdFactory) = False Then D7741.cdFactory = Trim$(rs7741!K7741_cdFactory)
    If IsdbNull(rs7741!K7741_cdSubProcess) = False Then D7741.cdSubProcess = Trim$(rs7741!K7741_cdSubProcess)
    If IsdbNull(rs7741!K7741_DatePlan) = False Then D7741.DatePlan = Trim$(rs7741!K7741_DatePlan)
    If IsdbNull(rs7741!K7741_cdLineProd) = False Then D7741.cdLineProd = Trim$(rs7741!K7741_cdLineProd)
    If IsdbNull(rs7741!K7741_seMainProcess) = False Then D7741.seMainProcess = Trim$(rs7741!K7741_seMainProcess)
    If IsdbNull(rs7741!K7741_cdMainProcess) = False Then D7741.cdMainProcess = Trim$(rs7741!K7741_cdMainProcess)
    If IsdbNull(rs7741!K7741_seFactory) = False Then D7741.seFactory = Trim$(rs7741!K7741_seFactory)
    If IsdbNull(rs7741!K7741_seSubProcess) = False Then D7741.seSubProcess = Trim$(rs7741!K7741_seSubProcess)
    If IsdbNull(rs7741!K7741_seLineProd) = False Then D7741.seLineProd = Trim$(rs7741!K7741_seLineProd)
    If IsdbNull(rs7741!K7741_Dseq) = False Then D7741.Dseq = Trim$(rs7741!K7741_Dseq)
    If IsdbNull(rs7741!K7741_TimeJob) = False Then D7741.TimeJob = Trim$(rs7741!K7741_TimeJob)
    If IsdbNull(rs7741!K7741_InchargePlan) = False Then D7741.InchargePlan = Trim$(rs7741!K7741_InchargePlan)
    If IsdbNull(rs7741!K7741_QtyTargetDay) = False Then D7741.QtyTargetDay = Trim$(rs7741!K7741_QtyTargetDay)
    If IsdbNull(rs7741!K7741_QtyTargetHour) = False Then D7741.QtyTargetHour = Trim$(rs7741!K7741_QtyTargetHour)
    If IsdbNull(rs7741!K7741_QtyRateSecond) = False Then D7741.QtyRateSecond = Trim$(rs7741!K7741_QtyRateSecond)
    If IsdbNull(rs7741!K7741_PersonPresent) = False Then D7741.PersonPresent = Trim$(rs7741!K7741_PersonPresent)
    If IsdbNull(rs7741!K7741_QtyDateProd) = False Then D7741.QtyDateProd = Trim$(rs7741!K7741_QtyDateProd)
    If IsdbNull(rs7741!K7741_QtyDateProdNormal) = False Then D7741.QtyDateProdNormal = Trim$(rs7741!K7741_QtyDateProdNormal)
    If IsdbNull(rs7741!K7741_QtyDateProdDefect) = False Then D7741.QtyDateProdDefect = Trim$(rs7741!K7741_QtyDateProdDefect)
    If IsdbNull(rs7741!K7741_QtyDateDefectPass) = False Then D7741.QtyDateDefectPass = Trim$(rs7741!K7741_QtyDateDefectPass)
    If IsdbNull(rs7741!K7741_QtyDateDefectReject) = False Then D7741.QtyDateDefectReject = Trim$(rs7741!K7741_QtyDateDefectReject)
    If IsdbNull(rs7741!K7741_Team) = False Then D7741.Team = Trim$(rs7741!K7741_Team)
    If IsdbNull(rs7741!K7741_CheckUse) = False Then D7741.CheckUse = Trim$(rs7741!K7741_CheckUse)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7741_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K7741_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7741 As T7741_AREA, CDFACTORY AS String, CDSUBPROCESS AS String, DATEPLAN AS String, CDLINEPROD AS String) as Boolean

K7741_MOVE = False

Try
    If READ_PFK7741(CDFACTORY, CDSUBPROCESS, DATEPLAN, CDLINEPROD) = True Then
                z7741 = D7741
		K7741_MOVE = True
		else
	z7741 = nothing
     End If

     If  getColumIndex(spr,"cdFactory") > -1 then z7741.cdFactory = getDataM(spr, getColumIndex(spr,"cdFactory"), xRow)
     If  getColumIndex(spr,"cdSubProcess") > -1 then z7741.cdSubProcess = getDataM(spr, getColumIndex(spr,"cdSubProcess"), xRow)
     If  getColumIndex(spr,"DatePlan") > -1 then z7741.DatePlan = getDataM(spr, getColumIndex(spr,"DatePlan"), xRow)
     If  getColumIndex(spr,"cdLineProd") > -1 then z7741.cdLineProd = getDataM(spr, getColumIndex(spr,"cdLineProd"), xRow)
     If  getColumIndex(spr,"seMainProcess") > -1 then z7741.seMainProcess = getDataM(spr, getColumIndex(spr,"seMainProcess"), xRow)
     If  getColumIndex(spr,"cdMainProcess") > -1 then z7741.cdMainProcess = getDataM(spr, getColumIndex(spr,"cdMainProcess"), xRow)
     If  getColumIndex(spr,"seFactory") > -1 then z7741.seFactory = getDataM(spr, getColumIndex(spr,"seFactory"), xRow)
     If  getColumIndex(spr,"seSubProcess") > -1 then z7741.seSubProcess = getDataM(spr, getColumIndex(spr,"seSubProcess"), xRow)
     If  getColumIndex(spr,"seLineProd") > -1 then z7741.seLineProd = getDataM(spr, getColumIndex(spr,"seLineProd"), xRow)
     If  getColumIndex(spr,"Dseq") > -1 then z7741.Dseq = getDataM(spr, getColumIndex(spr,"Dseq"), xRow)
     If  getColumIndex(spr,"TimeJob") > -1 then z7741.TimeJob = getDataM(spr, getColumIndex(spr,"TimeJob"), xRow)
     If  getColumIndex(spr,"InchargePlan") > -1 then z7741.InchargePlan = getDataM(spr, getColumIndex(spr,"InchargePlan"), xRow)
     If  getColumIndex(spr,"QtyTargetDay") > -1 then z7741.QtyTargetDay = getDataM(spr, getColumIndex(spr,"QtyTargetDay"), xRow)
     If  getColumIndex(spr,"QtyTargetHour") > -1 then z7741.QtyTargetHour = getDataM(spr, getColumIndex(spr,"QtyTargetHour"), xRow)
     If  getColumIndex(spr,"QtyRateSecond") > -1 then z7741.QtyRateSecond = getDataM(spr, getColumIndex(spr,"QtyRateSecond"), xRow)
     If  getColumIndex(spr,"PersonPresent") > -1 then z7741.PersonPresent = getDataM(spr, getColumIndex(spr,"PersonPresent"), xRow)
     If  getColumIndex(spr,"QtyDateProd") > -1 then z7741.QtyDateProd = getDataM(spr, getColumIndex(spr,"QtyDateProd"), xRow)
     If  getColumIndex(spr,"QtyDateProdNormal") > -1 then z7741.QtyDateProdNormal = getDataM(spr, getColumIndex(spr,"QtyDateProdNormal"), xRow)
     If  getColumIndex(spr,"QtyDateProdDefect") > -1 then z7741.QtyDateProdDefect = getDataM(spr, getColumIndex(spr,"QtyDateProdDefect"), xRow)
     If  getColumIndex(spr,"QtyDateDefectPass") > -1 then z7741.QtyDateDefectPass = getDataM(spr, getColumIndex(spr,"QtyDateDefectPass"), xRow)
     If  getColumIndex(spr,"QtyDateDefectReject") > -1 then z7741.QtyDateDefectReject = getDataM(spr, getColumIndex(spr,"QtyDateDefectReject"), xRow)
     If  getColumIndex(spr,"Team") > -1 then z7741.Team = getDataM(spr, getColumIndex(spr,"Team"), xRow)
     If  getColumIndex(spr,"CheckUse") > -1 then z7741.CheckUse = getDataM(spr, getColumIndex(spr,"CheckUse"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7741_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K7741_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7741 As T7741_AREA,CheckClear as Boolean,CDFACTORY AS String, CDSUBPROCESS AS String, DATEPLAN AS String, CDLINEPROD AS String) as Boolean

K7741_MOVE = False

Try
    If READ_PFK7741(CDFACTORY, CDSUBPROCESS, DATEPLAN, CDLINEPROD) = True Then
                z7741 = D7741
		K7741_MOVE = True
		else
	If CheckClear  = True then z7741 = nothing
     End If

     If  getColumIndex(spr,"cdFactory") > -1 then z7741.cdFactory = getDataM(spr, getColumIndex(spr,"cdFactory"), xRow)
     If  getColumIndex(spr,"cdSubProcess") > -1 then z7741.cdSubProcess = getDataM(spr, getColumIndex(spr,"cdSubProcess"), xRow)
     If  getColumIndex(spr,"DatePlan") > -1 then z7741.DatePlan = getDataM(spr, getColumIndex(spr,"DatePlan"), xRow)
     If  getColumIndex(spr,"cdLineProd") > -1 then z7741.cdLineProd = getDataM(spr, getColumIndex(spr,"cdLineProd"), xRow)
     If  getColumIndex(spr,"seMainProcess") > -1 then z7741.seMainProcess = getDataM(spr, getColumIndex(spr,"seMainProcess"), xRow)
     If  getColumIndex(spr,"cdMainProcess") > -1 then z7741.cdMainProcess = getDataM(spr, getColumIndex(spr,"cdMainProcess"), xRow)
     If  getColumIndex(spr,"seFactory") > -1 then z7741.seFactory = getDataM(spr, getColumIndex(spr,"seFactory"), xRow)
     If  getColumIndex(spr,"seSubProcess") > -1 then z7741.seSubProcess = getDataM(spr, getColumIndex(spr,"seSubProcess"), xRow)
     If  getColumIndex(spr,"seLineProd") > -1 then z7741.seLineProd = getDataM(spr, getColumIndex(spr,"seLineProd"), xRow)
     If  getColumIndex(spr,"Dseq") > -1 then z7741.Dseq = getDataM(spr, getColumIndex(spr,"Dseq"), xRow)
     If  getColumIndex(spr,"TimeJob") > -1 then z7741.TimeJob = getDataM(spr, getColumIndex(spr,"TimeJob"), xRow)
     If  getColumIndex(spr,"InchargePlan") > -1 then z7741.InchargePlan = getDataM(spr, getColumIndex(spr,"InchargePlan"), xRow)
     If  getColumIndex(spr,"QtyTargetDay") > -1 then z7741.QtyTargetDay = getDataM(spr, getColumIndex(spr,"QtyTargetDay"), xRow)
     If  getColumIndex(spr,"QtyTargetHour") > -1 then z7741.QtyTargetHour = getDataM(spr, getColumIndex(spr,"QtyTargetHour"), xRow)
     If  getColumIndex(spr,"QtyRateSecond") > -1 then z7741.QtyRateSecond = getDataM(spr, getColumIndex(spr,"QtyRateSecond"), xRow)
     If  getColumIndex(spr,"PersonPresent") > -1 then z7741.PersonPresent = getDataM(spr, getColumIndex(spr,"PersonPresent"), xRow)
     If  getColumIndex(spr,"QtyDateProd") > -1 then z7741.QtyDateProd = getDataM(spr, getColumIndex(spr,"QtyDateProd"), xRow)
     If  getColumIndex(spr,"QtyDateProdNormal") > -1 then z7741.QtyDateProdNormal = getDataM(spr, getColumIndex(spr,"QtyDateProdNormal"), xRow)
     If  getColumIndex(spr,"QtyDateProdDefect") > -1 then z7741.QtyDateProdDefect = getDataM(spr, getColumIndex(spr,"QtyDateProdDefect"), xRow)
     If  getColumIndex(spr,"QtyDateDefectPass") > -1 then z7741.QtyDateDefectPass = getDataM(spr, getColumIndex(spr,"QtyDateDefectPass"), xRow)
     If  getColumIndex(spr,"QtyDateDefectReject") > -1 then z7741.QtyDateDefectReject = getDataM(spr, getColumIndex(spr,"QtyDateDefectReject"), xRow)
     If  getColumIndex(spr,"Team") > -1 then z7741.Team = getDataM(spr, getColumIndex(spr,"Team"), xRow)
     If  getColumIndex(spr,"CheckUse") > -1 then z7741.CheckUse = getDataM(spr, getColumIndex(spr,"CheckUse"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7741_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K7741_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7741 As T7741_AREA, Job as String, CDFACTORY AS String, CDSUBPROCESS AS String, DATEPLAN AS String, CDLINEPROD AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7741_MOVE = False

Try
    If READ_PFK7741(CDFACTORY, CDSUBPROCESS, DATEPLAN, CDLINEPROD) = True Then
                z7741 = D7741
		K7741_MOVE = True
		else
	z7741 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7741")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "CDFACTORY":z7741.cdFactory = Children(i).Code
   Case "CDSUBPROCESS":z7741.cdSubProcess = Children(i).Code
   Case "DATEPLAN":z7741.DatePlan = Children(i).Code
   Case "CDLINEPROD":z7741.cdLineProd = Children(i).Code
   Case "SEMAINPROCESS":z7741.seMainProcess = Children(i).Code
   Case "CDMAINPROCESS":z7741.cdMainProcess = Children(i).Code
   Case "SEFACTORY":z7741.seFactory = Children(i).Code
   Case "SESUBPROCESS":z7741.seSubProcess = Children(i).Code
   Case "SELINEPROD":z7741.seLineProd = Children(i).Code
   Case "DSEQ":z7741.Dseq = Children(i).Code
   Case "TIMEJOB":z7741.TimeJob = Children(i).Code
   Case "INCHARGEPLAN":z7741.InchargePlan = Children(i).Code
   Case "QTYTARGETDAY":z7741.QtyTargetDay = Children(i).Code
   Case "QTYTARGETHOUR":z7741.QtyTargetHour = Children(i).Code
   Case "QTYRATESECOND":z7741.QtyRateSecond = Children(i).Code
   Case "PERSONPRESENT":z7741.PersonPresent = Children(i).Code
   Case "QTYDATEPROD":z7741.QtyDateProd = Children(i).Code
   Case "QTYDATEPRODNORMAL":z7741.QtyDateProdNormal = Children(i).Code
   Case "QTYDATEPRODDEFECT":z7741.QtyDateProdDefect = Children(i).Code
   Case "QTYDATEDEFECTPASS":z7741.QtyDateDefectPass = Children(i).Code
   Case "QTYDATEDEFECTREJECT":z7741.QtyDateDefectReject = Children(i).Code
   Case "TEAM":z7741.Team = Children(i).Code
   Case "CHECKUSE":z7741.CheckUse = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "CDFACTORY":z7741.cdFactory = Children(i).Data
   Case "CDSUBPROCESS":z7741.cdSubProcess = Children(i).Data
   Case "DATEPLAN":z7741.DatePlan = Children(i).Data
   Case "CDLINEPROD":z7741.cdLineProd = Children(i).Data
   Case "SEMAINPROCESS":z7741.seMainProcess = Children(i).Data
   Case "CDMAINPROCESS":z7741.cdMainProcess = Children(i).Data
   Case "SEFACTORY":z7741.seFactory = Children(i).Data
   Case "SESUBPROCESS":z7741.seSubProcess = Children(i).Data
   Case "SELINEPROD":z7741.seLineProd = Children(i).Data
   Case "DSEQ":z7741.Dseq = Children(i).Data
   Case "TIMEJOB":z7741.TimeJob = Children(i).Data
   Case "INCHARGEPLAN":z7741.InchargePlan = Children(i).Data
   Case "QTYTARGETDAY":z7741.QtyTargetDay = Children(i).Data
   Case "QTYTARGETHOUR":z7741.QtyTargetHour = Children(i).Data
   Case "QTYRATESECOND":z7741.QtyRateSecond = Children(i).Data
   Case "PERSONPRESENT":z7741.PersonPresent = Children(i).Data
   Case "QTYDATEPROD":z7741.QtyDateProd = Children(i).Data
   Case "QTYDATEPRODNORMAL":z7741.QtyDateProdNormal = Children(i).Data
   Case "QTYDATEPRODDEFECT":z7741.QtyDateProdDefect = Children(i).Data
   Case "QTYDATEDEFECTPASS":z7741.QtyDateDefectPass = Children(i).Data
   Case "QTYDATEDEFECTREJECT":z7741.QtyDateDefectReject = Children(i).Data
   Case "TEAM":z7741.Team = Children(i).Data
   Case "CHECKUSE":z7741.CheckUse = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7741_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K7741_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7741 As T7741_AREA, Job as String, CheckClear as Boolean, CDFACTORY AS String, CDSUBPROCESS AS String, DATEPLAN AS String, CDLINEPROD AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7741_MOVE = False

Try
    If READ_PFK7741(CDFACTORY, CDSUBPROCESS, DATEPLAN, CDLINEPROD) = True Then
                z7741 = D7741
		K7741_MOVE = True
		else
	If CheckClear  = True then z7741 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7741")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "CDFACTORY":z7741.cdFactory = Children(i).Code
   Case "CDSUBPROCESS":z7741.cdSubProcess = Children(i).Code
   Case "DATEPLAN":z7741.DatePlan = Children(i).Code
   Case "CDLINEPROD":z7741.cdLineProd = Children(i).Code
   Case "SEMAINPROCESS":z7741.seMainProcess = Children(i).Code
   Case "CDMAINPROCESS":z7741.cdMainProcess = Children(i).Code
   Case "SEFACTORY":z7741.seFactory = Children(i).Code
   Case "SESUBPROCESS":z7741.seSubProcess = Children(i).Code
   Case "SELINEPROD":z7741.seLineProd = Children(i).Code
   Case "DSEQ":z7741.Dseq = Children(i).Code
   Case "TIMEJOB":z7741.TimeJob = Children(i).Code
   Case "INCHARGEPLAN":z7741.InchargePlan = Children(i).Code
   Case "QTYTARGETDAY":z7741.QtyTargetDay = Children(i).Code
   Case "QTYTARGETHOUR":z7741.QtyTargetHour = Children(i).Code
   Case "QTYRATESECOND":z7741.QtyRateSecond = Children(i).Code
   Case "PERSONPRESENT":z7741.PersonPresent = Children(i).Code
   Case "QTYDATEPROD":z7741.QtyDateProd = Children(i).Code
   Case "QTYDATEPRODNORMAL":z7741.QtyDateProdNormal = Children(i).Code
   Case "QTYDATEPRODDEFECT":z7741.QtyDateProdDefect = Children(i).Code
   Case "QTYDATEDEFECTPASS":z7741.QtyDateDefectPass = Children(i).Code
   Case "QTYDATEDEFECTREJECT":z7741.QtyDateDefectReject = Children(i).Code
   Case "TEAM":z7741.Team = Children(i).Code
   Case "CHECKUSE":z7741.CheckUse = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "CDFACTORY":z7741.cdFactory = Children(i).Data
   Case "CDSUBPROCESS":z7741.cdSubProcess = Children(i).Data
   Case "DATEPLAN":z7741.DatePlan = Children(i).Data
   Case "CDLINEPROD":z7741.cdLineProd = Children(i).Data
   Case "SEMAINPROCESS":z7741.seMainProcess = Children(i).Data
   Case "CDMAINPROCESS":z7741.cdMainProcess = Children(i).Data
   Case "SEFACTORY":z7741.seFactory = Children(i).Data
   Case "SESUBPROCESS":z7741.seSubProcess = Children(i).Data
   Case "SELINEPROD":z7741.seLineProd = Children(i).Data
   Case "DSEQ":z7741.Dseq = Children(i).Data
   Case "TIMEJOB":z7741.TimeJob = Children(i).Data
   Case "INCHARGEPLAN":z7741.InchargePlan = Children(i).Data
   Case "QTYTARGETDAY":z7741.QtyTargetDay = Children(i).Data
   Case "QTYTARGETHOUR":z7741.QtyTargetHour = Children(i).Data
   Case "QTYRATESECOND":z7741.QtyRateSecond = Children(i).Data
   Case "PERSONPRESENT":z7741.PersonPresent = Children(i).Data
   Case "QTYDATEPROD":z7741.QtyDateProd = Children(i).Data
   Case "QTYDATEPRODNORMAL":z7741.QtyDateProdNormal = Children(i).Data
   Case "QTYDATEPRODDEFECT":z7741.QtyDateProdDefect = Children(i).Data
   Case "QTYDATEDEFECTPASS":z7741.QtyDateDefectPass = Children(i).Data
   Case "QTYDATEDEFECTREJECT":z7741.QtyDateDefectReject = Children(i).Data
   Case "TEAM":z7741.Team = Children(i).Data
   Case "CHECKUSE":z7741.CheckUse = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7741_MOVE",vbCritical)
End Try
End Function 
    
End Module 
