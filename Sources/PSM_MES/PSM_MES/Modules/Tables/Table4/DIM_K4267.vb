'=========================================================================================================================================================
'   TABLE : (PFK4267)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K4267

Structure T4267_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	JobCard	 AS String	'			char(9)		*
Public 	Szno	 AS String	'			char(2)		*
Public 	ProdDate	 AS String	'			char(8)		*
Public 	cdSubProcess	 AS String	'			char(3)		*
Public 	cdFactory	 AS String	'			char(3)		*
Public 	cdLineProd	 AS String	'			char(3)		*
Public 	OrderNo	 AS String	'			char(9)
Public 	OrderNoSeq	 AS String	'			char(3)
Public 	QtyProduction	 AS Double	'			decimal
Public 	QtyProductionA	 AS Double	'			decimal
Public 	QtyProductionX	 AS Double	'			decimal
Public 	QtyProductionXP	 AS Double	'			decimal
Public 	QtyProductionXR	 AS Double	'			decimal
Public 	QtyProductionL	 AS Double	'			decimal
Public 	QtyProductionLA	 AS Double	'			decimal
Public 	QtyProductionLX	 AS Double	'			decimal
Public 	QtyProductionLXP	 AS Double	'			decimal
Public 	QtyProductionLXR	 AS Double	'			decimal
Public 	QtyProductionR	 AS Double	'			decimal
Public 	QtyProductionRA	 AS Double	'			decimal
Public 	QtyProductionRX	 AS Double	'			decimal
Public 	QtyProductionRXP	 AS Double	'			decimal
Public 	QtyProductionRXR	 AS Double	'			decimal

'=========================================================================================================================================================
End structure

Public D4267 As T4267_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK4267(JOBCARD AS String, SZNO AS String, PRODDATE AS String, CDSUBPROCESS AS String, CDFACTORY AS String, CDLINEPROD AS String) As Boolean
    READ_PFK4267 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK4267 "
    SQL = SQL & " WHERE K4267_JobCard		 = '" & JobCard & "' " 
    SQL = SQL & "   AND K4267_Szno		 = '" & Szno & "' " 
    SQL = SQL & "   AND K4267_ProdDate		 = '" & ProdDate & "' " 
    SQL = SQL & "   AND K4267_cdSubProcess		 = '" & cdSubProcess & "' " 
    SQL = SQL & "   AND K4267_cdFactory		 = '" & cdFactory & "' " 
    SQL = SQL & "   AND K4267_cdLineProd		 = '" & cdLineProd & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D4267_CLEAR: GoTo SKIP_READ_PFK4267
                
    Call K4267_MOVE(rd)
    READ_PFK4267 = True

SKIP_READ_PFK4267:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK4267",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK4267(JOBCARD AS String, SZNO AS String, PRODDATE AS String, CDSUBPROCESS AS String, CDFACTORY AS String, CDLINEPROD AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK4267 "
    SQL = SQL & " WHERE K4267_JobCard		 = '" & JobCard & "' " 
    SQL = SQL & "   AND K4267_Szno		 = '" & Szno & "' " 
    SQL = SQL & "   AND K4267_ProdDate		 = '" & ProdDate & "' " 
    SQL = SQL & "   AND K4267_cdSubProcess		 = '" & cdSubProcess & "' " 
    SQL = SQL & "   AND K4267_cdFactory		 = '" & cdFactory & "' " 
    SQL = SQL & "   AND K4267_cdLineProd		 = '" & cdLineProd & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK4267",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK4267(z4267 As T4267_AREA) As Boolean
    WRITE_PFK4267 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z4267)
 
    SQL = " INSERT INTO PFK4267 "
    SQL = SQL & " ( "
    SQL = SQL & " K4267_JobCard," 
    SQL = SQL & " K4267_Szno," 
    SQL = SQL & " K4267_ProdDate," 
    SQL = SQL & " K4267_cdSubProcess," 
    SQL = SQL & " K4267_cdFactory," 
    SQL = SQL & " K4267_cdLineProd," 
    SQL = SQL & " K4267_OrderNo," 
    SQL = SQL & " K4267_OrderNoSeq," 
    SQL = SQL & " K4267_QtyProduction," 
    SQL = SQL & " K4267_QtyProductionA," 
    SQL = SQL & " K4267_QtyProductionX," 
    SQL = SQL & " K4267_QtyProductionXP," 
    SQL = SQL & " K4267_QtyProductionXR," 
    SQL = SQL & " K4267_QtyProductionL," 
    SQL = SQL & " K4267_QtyProductionLA," 
    SQL = SQL & " K4267_QtyProductionLX," 
    SQL = SQL & " K4267_QtyProductionLXP," 
    SQL = SQL & " K4267_QtyProductionLXR," 
    SQL = SQL & " K4267_QtyProductionR," 
    SQL = SQL & " K4267_QtyProductionRA," 
    SQL = SQL & " K4267_QtyProductionRX," 
    SQL = SQL & " K4267_QtyProductionRXP," 
    SQL = SQL & " K4267_QtyProductionRXR," 
            SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z4267.JobCard) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4267.Szno) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4267.ProdDate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4267.cdSubProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4267.cdFactory) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4267.cdLineProd) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4267.OrderNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4267.OrderNoSeq) & "', "  
    SQL = SQL & "   " & FormatSQL(z4267.QtyProduction) & ", "  
    SQL = SQL & "   " & FormatSQL(z4267.QtyProductionA) & ", "  
    SQL = SQL & "   " & FormatSQL(z4267.QtyProductionX) & ", "  
    SQL = SQL & "   " & FormatSQL(z4267.QtyProductionXP) & ", "  
    SQL = SQL & "   " & FormatSQL(z4267.QtyProductionXR) & ", "  
    SQL = SQL & "   " & FormatSQL(z4267.QtyProductionL) & ", "  
    SQL = SQL & "   " & FormatSQL(z4267.QtyProductionLA) & ", "  
    SQL = SQL & "   " & FormatSQL(z4267.QtyProductionLX) & ", "  
    SQL = SQL & "   " & FormatSQL(z4267.QtyProductionLXP) & ", "  
    SQL = SQL & "   " & FormatSQL(z4267.QtyProductionLXR) & ", "  
    SQL = SQL & "   " & FormatSQL(z4267.QtyProductionR) & ", "  
    SQL = SQL & "   " & FormatSQL(z4267.QtyProductionRA) & ", "  
    SQL = SQL & "   " & FormatSQL(z4267.QtyProductionRX) & ", "  
    SQL = SQL & "   " & FormatSQL(z4267.QtyProductionRXP) & ", "  
    SQL = SQL & "   " & FormatSQL(z4267.QtyProductionRXR) & ", "  
            SQL = SQL & " ) "
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK4267 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK4267",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK4267(z4267 As T4267_AREA) As Boolean
    REWRITE_PFK4267 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z4267)
   
    SQL = " UPDATE PFK4267 SET "
    SQL = SQL & "    K4267_OrderNo      = N'" & FormatSQL(z4267.OrderNo) & "', " 
    SQL = SQL & "    K4267_OrderNoSeq      = N'" & FormatSQL(z4267.OrderNoSeq) & "', " 
    SQL = SQL & "    K4267_QtyProduction      =  " & FormatSQL(z4267.QtyProduction) & ", " 
    SQL = SQL & "    K4267_QtyProductionA      =  " & FormatSQL(z4267.QtyProductionA) & ", " 
    SQL = SQL & "    K4267_QtyProductionX      =  " & FormatSQL(z4267.QtyProductionX) & ", " 
    SQL = SQL & "    K4267_QtyProductionXP      =  " & FormatSQL(z4267.QtyProductionXP) & ", " 
    SQL = SQL & "    K4267_QtyProductionXR      =  " & FormatSQL(z4267.QtyProductionXR) & ", " 
    SQL = SQL & "    K4267_QtyProductionL      =  " & FormatSQL(z4267.QtyProductionL) & ", " 
    SQL = SQL & "    K4267_QtyProductionLA      =  " & FormatSQL(z4267.QtyProductionLA) & ", " 
    SQL = SQL & "    K4267_QtyProductionLX      =  " & FormatSQL(z4267.QtyProductionLX) & ", " 
    SQL = SQL & "    K4267_QtyProductionLXP      =  " & FormatSQL(z4267.QtyProductionLXP) & ", " 
    SQL = SQL & "    K4267_QtyProductionLXR      =  " & FormatSQL(z4267.QtyProductionLXR) & ", " 
    SQL = SQL & "    K4267_QtyProductionR      =  " & FormatSQL(z4267.QtyProductionR) & ", " 
    SQL = SQL & "    K4267_QtyProductionRA      =  " & FormatSQL(z4267.QtyProductionRA) & ", " 
    SQL = SQL & "    K4267_QtyProductionRX      =  " & FormatSQL(z4267.QtyProductionRX) & ", " 
    SQL = SQL & "    K4267_QtyProductionRXP      =  " & FormatSQL(z4267.QtyProductionRXP) & ", " 
    SQL = SQL & "    K4267_QtyProductionRXR      =  " & FormatSQL(z4267.QtyProductionRXR) & ", " 
            SQL = SQL & " WHERE K4267_JobCard		 = '" & z4267.JobCard & "' "
    SQL = SQL & "   AND K4267_Szno		 = '" & z4267.Szno & "' " 
    SQL = SQL & "   AND K4267_ProdDate		 = '" & z4267.ProdDate & "' " 
    SQL = SQL & "   AND K4267_cdSubProcess		 = '" & z4267.cdSubProcess & "' " 
    SQL = SQL & "   AND K4267_cdFactory		 = '" & z4267.cdFactory & "' " 
    SQL = SQL & "   AND K4267_cdLineProd		 = '" & z4267.cdLineProd & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK4267 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK4267",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK4267(z4267 As T4267_AREA) As Boolean
    DELETE_PFK4267 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK4267 "
    SQL = SQL & " WHERE K4267_JobCard		 = '" & z4267.JobCard & "' " 
    SQL = SQL & "   AND K4267_Szno		 = '" & z4267.Szno & "' " 
    SQL = SQL & "   AND K4267_ProdDate		 = '" & z4267.ProdDate & "' " 
    SQL = SQL & "   AND K4267_cdSubProcess		 = '" & z4267.cdSubProcess & "' " 
    SQL = SQL & "   AND K4267_cdFactory		 = '" & z4267.cdFactory & "' " 
    SQL = SQL & "   AND K4267_cdLineProd		 = '" & z4267.cdLineProd & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK4267 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK4267",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D4267_CLEAR()
Try
    
   D4267.JobCard = ""
   D4267.Szno = ""
   D4267.ProdDate = ""
   D4267.cdSubProcess = ""
   D4267.cdFactory = ""
   D4267.cdLineProd = ""
   D4267.OrderNo = ""
   D4267.OrderNoSeq = ""
    D4267.QtyProduction = 0 
    D4267.QtyProductionA = 0 
    D4267.QtyProductionX = 0 
    D4267.QtyProductionXP = 0 
    D4267.QtyProductionXR = 0 
    D4267.QtyProductionL = 0 
    D4267.QtyProductionLA = 0 
    D4267.QtyProductionLX = 0 
    D4267.QtyProductionLXP = 0 
    D4267.QtyProductionLXR = 0 
    D4267.QtyProductionR = 0 
    D4267.QtyProductionRA = 0 
    D4267.QtyProductionRX = 0 
    D4267.QtyProductionRXP = 0 
    D4267.QtyProductionRXR = 0 

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D4267_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x4267 As T4267_AREA)
Try
    
    x4267.JobCard = trim$(  x4267.JobCard)
    x4267.Szno = trim$(  x4267.Szno)
    x4267.ProdDate = trim$(  x4267.ProdDate)
    x4267.cdSubProcess = trim$(  x4267.cdSubProcess)
    x4267.cdFactory = trim$(  x4267.cdFactory)
    x4267.cdLineProd = trim$(  x4267.cdLineProd)
    x4267.OrderNo = trim$(  x4267.OrderNo)
    x4267.OrderNoSeq = trim$(  x4267.OrderNoSeq)
    x4267.QtyProduction = trim$(  x4267.QtyProduction)
    x4267.QtyProductionA = trim$(  x4267.QtyProductionA)
    x4267.QtyProductionX = trim$(  x4267.QtyProductionX)
    x4267.QtyProductionXP = trim$(  x4267.QtyProductionXP)
    x4267.QtyProductionXR = trim$(  x4267.QtyProductionXR)
    x4267.QtyProductionL = trim$(  x4267.QtyProductionL)
    x4267.QtyProductionLA = trim$(  x4267.QtyProductionLA)
    x4267.QtyProductionLX = trim$(  x4267.QtyProductionLX)
    x4267.QtyProductionLXP = trim$(  x4267.QtyProductionLXP)
    x4267.QtyProductionLXR = trim$(  x4267.QtyProductionLXR)
    x4267.QtyProductionR = trim$(  x4267.QtyProductionR)
    x4267.QtyProductionRA = trim$(  x4267.QtyProductionRA)
    x4267.QtyProductionRX = trim$(  x4267.QtyProductionRX)
    x4267.QtyProductionRXP = trim$(  x4267.QtyProductionRXP)
    x4267.QtyProductionRXR = trim$(  x4267.QtyProductionRXR)

    If trim$( x4267.JobCard ) = "" Then x4267.JobCard = Space(1) 
    If trim$( x4267.Szno ) = "" Then x4267.Szno = Space(1) 
    If trim$( x4267.ProdDate ) = "" Then x4267.ProdDate = Space(1) 
    If trim$( x4267.cdSubProcess ) = "" Then x4267.cdSubProcess = Space(1) 
    If trim$( x4267.cdFactory ) = "" Then x4267.cdFactory = Space(1) 
    If trim$( x4267.cdLineProd ) = "" Then x4267.cdLineProd = Space(1) 
    If trim$( x4267.OrderNo ) = "" Then x4267.OrderNo = Space(1) 
    If trim$( x4267.OrderNoSeq ) = "" Then x4267.OrderNoSeq = Space(1) 
    If trim$( x4267.QtyProduction ) = "" Then x4267.QtyProduction = 0 
    If trim$( x4267.QtyProductionA ) = "" Then x4267.QtyProductionA = 0 
    If trim$( x4267.QtyProductionX ) = "" Then x4267.QtyProductionX = 0 
    If trim$( x4267.QtyProductionXP ) = "" Then x4267.QtyProductionXP = 0 
    If trim$( x4267.QtyProductionXR ) = "" Then x4267.QtyProductionXR = 0 
    If trim$( x4267.QtyProductionL ) = "" Then x4267.QtyProductionL = 0 
    If trim$( x4267.QtyProductionLA ) = "" Then x4267.QtyProductionLA = 0 
    If trim$( x4267.QtyProductionLX ) = "" Then x4267.QtyProductionLX = 0 
    If trim$( x4267.QtyProductionLXP ) = "" Then x4267.QtyProductionLXP = 0 
    If trim$( x4267.QtyProductionLXR ) = "" Then x4267.QtyProductionLXR = 0 
    If trim$( x4267.QtyProductionR ) = "" Then x4267.QtyProductionR = 0 
    If trim$( x4267.QtyProductionRA ) = "" Then x4267.QtyProductionRA = 0 
    If trim$( x4267.QtyProductionRX ) = "" Then x4267.QtyProductionRX = 0 
    If trim$( x4267.QtyProductionRXP ) = "" Then x4267.QtyProductionRXP = 0 
    If trim$( x4267.QtyProductionRXR ) = "" Then x4267.QtyProductionRXR = 0 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K4267_MOVE(rs4267 As SqlClient.SqlDataReader)
Try

    call D4267_CLEAR()   

    If IsdbNull(rs4267!K4267_JobCard) = False Then D4267.JobCard = Trim$(rs4267!K4267_JobCard)
    If IsdbNull(rs4267!K4267_Szno) = False Then D4267.Szno = Trim$(rs4267!K4267_Szno)
    If IsdbNull(rs4267!K4267_ProdDate) = False Then D4267.ProdDate = Trim$(rs4267!K4267_ProdDate)
    If IsdbNull(rs4267!K4267_cdSubProcess) = False Then D4267.cdSubProcess = Trim$(rs4267!K4267_cdSubProcess)
    If IsdbNull(rs4267!K4267_cdFactory) = False Then D4267.cdFactory = Trim$(rs4267!K4267_cdFactory)
    If IsdbNull(rs4267!K4267_cdLineProd) = False Then D4267.cdLineProd = Trim$(rs4267!K4267_cdLineProd)
    If IsdbNull(rs4267!K4267_OrderNo) = False Then D4267.OrderNo = Trim$(rs4267!K4267_OrderNo)
    If IsdbNull(rs4267!K4267_OrderNoSeq) = False Then D4267.OrderNoSeq = Trim$(rs4267!K4267_OrderNoSeq)
    If IsdbNull(rs4267!K4267_QtyProduction) = False Then D4267.QtyProduction = Trim$(rs4267!K4267_QtyProduction)
    If IsdbNull(rs4267!K4267_QtyProductionA) = False Then D4267.QtyProductionA = Trim$(rs4267!K4267_QtyProductionA)
    If IsdbNull(rs4267!K4267_QtyProductionX) = False Then D4267.QtyProductionX = Trim$(rs4267!K4267_QtyProductionX)
    If IsdbNull(rs4267!K4267_QtyProductionXP) = False Then D4267.QtyProductionXP = Trim$(rs4267!K4267_QtyProductionXP)
    If IsdbNull(rs4267!K4267_QtyProductionXR) = False Then D4267.QtyProductionXR = Trim$(rs4267!K4267_QtyProductionXR)
    If IsdbNull(rs4267!K4267_QtyProductionL) = False Then D4267.QtyProductionL = Trim$(rs4267!K4267_QtyProductionL)
    If IsdbNull(rs4267!K4267_QtyProductionLA) = False Then D4267.QtyProductionLA = Trim$(rs4267!K4267_QtyProductionLA)
    If IsdbNull(rs4267!K4267_QtyProductionLX) = False Then D4267.QtyProductionLX = Trim$(rs4267!K4267_QtyProductionLX)
    If IsdbNull(rs4267!K4267_QtyProductionLXP) = False Then D4267.QtyProductionLXP = Trim$(rs4267!K4267_QtyProductionLXP)
    If IsdbNull(rs4267!K4267_QtyProductionLXR) = False Then D4267.QtyProductionLXR = Trim$(rs4267!K4267_QtyProductionLXR)
    If IsdbNull(rs4267!K4267_QtyProductionR) = False Then D4267.QtyProductionR = Trim$(rs4267!K4267_QtyProductionR)
    If IsdbNull(rs4267!K4267_QtyProductionRA) = False Then D4267.QtyProductionRA = Trim$(rs4267!K4267_QtyProductionRA)
    If IsdbNull(rs4267!K4267_QtyProductionRX) = False Then D4267.QtyProductionRX = Trim$(rs4267!K4267_QtyProductionRX)
    If IsdbNull(rs4267!K4267_QtyProductionRXP) = False Then D4267.QtyProductionRXP = Trim$(rs4267!K4267_QtyProductionRXP)
    If IsdbNull(rs4267!K4267_QtyProductionRXR) = False Then D4267.QtyProductionRXR = Trim$(rs4267!K4267_QtyProductionRXR)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K4267_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K4267_MOVE(rs4267 As DataRow)
Try

    call D4267_CLEAR()   

    If IsdbNull(rs4267!K4267_JobCard) = False Then D4267.JobCard = Trim$(rs4267!K4267_JobCard)
    If IsdbNull(rs4267!K4267_Szno) = False Then D4267.Szno = Trim$(rs4267!K4267_Szno)
    If IsdbNull(rs4267!K4267_ProdDate) = False Then D4267.ProdDate = Trim$(rs4267!K4267_ProdDate)
    If IsdbNull(rs4267!K4267_cdSubProcess) = False Then D4267.cdSubProcess = Trim$(rs4267!K4267_cdSubProcess)
    If IsdbNull(rs4267!K4267_cdFactory) = False Then D4267.cdFactory = Trim$(rs4267!K4267_cdFactory)
    If IsdbNull(rs4267!K4267_cdLineProd) = False Then D4267.cdLineProd = Trim$(rs4267!K4267_cdLineProd)
    If IsdbNull(rs4267!K4267_OrderNo) = False Then D4267.OrderNo = Trim$(rs4267!K4267_OrderNo)
    If IsdbNull(rs4267!K4267_OrderNoSeq) = False Then D4267.OrderNoSeq = Trim$(rs4267!K4267_OrderNoSeq)
    If IsdbNull(rs4267!K4267_QtyProduction) = False Then D4267.QtyProduction = Trim$(rs4267!K4267_QtyProduction)
    If IsdbNull(rs4267!K4267_QtyProductionA) = False Then D4267.QtyProductionA = Trim$(rs4267!K4267_QtyProductionA)
    If IsdbNull(rs4267!K4267_QtyProductionX) = False Then D4267.QtyProductionX = Trim$(rs4267!K4267_QtyProductionX)
    If IsdbNull(rs4267!K4267_QtyProductionXP) = False Then D4267.QtyProductionXP = Trim$(rs4267!K4267_QtyProductionXP)
    If IsdbNull(rs4267!K4267_QtyProductionXR) = False Then D4267.QtyProductionXR = Trim$(rs4267!K4267_QtyProductionXR)
    If IsdbNull(rs4267!K4267_QtyProductionL) = False Then D4267.QtyProductionL = Trim$(rs4267!K4267_QtyProductionL)
    If IsdbNull(rs4267!K4267_QtyProductionLA) = False Then D4267.QtyProductionLA = Trim$(rs4267!K4267_QtyProductionLA)
    If IsdbNull(rs4267!K4267_QtyProductionLX) = False Then D4267.QtyProductionLX = Trim$(rs4267!K4267_QtyProductionLX)
    If IsdbNull(rs4267!K4267_QtyProductionLXP) = False Then D4267.QtyProductionLXP = Trim$(rs4267!K4267_QtyProductionLXP)
    If IsdbNull(rs4267!K4267_QtyProductionLXR) = False Then D4267.QtyProductionLXR = Trim$(rs4267!K4267_QtyProductionLXR)
    If IsdbNull(rs4267!K4267_QtyProductionR) = False Then D4267.QtyProductionR = Trim$(rs4267!K4267_QtyProductionR)
    If IsdbNull(rs4267!K4267_QtyProductionRA) = False Then D4267.QtyProductionRA = Trim$(rs4267!K4267_QtyProductionRA)
    If IsdbNull(rs4267!K4267_QtyProductionRX) = False Then D4267.QtyProductionRX = Trim$(rs4267!K4267_QtyProductionRX)
    If IsdbNull(rs4267!K4267_QtyProductionRXP) = False Then D4267.QtyProductionRXP = Trim$(rs4267!K4267_QtyProductionRXP)
    If IsdbNull(rs4267!K4267_QtyProductionRXR) = False Then D4267.QtyProductionRXR = Trim$(rs4267!K4267_QtyProductionRXR)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K4267_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K4267_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z4267 As T4267_AREA, JOBCARD AS String, SZNO AS String, PRODDATE AS String, CDSUBPROCESS AS String, CDFACTORY AS String, CDLINEPROD AS String) as Boolean

K4267_MOVE = False

Try
    If READ_PFK4267(JOBCARD, SZNO, PRODDATE, CDSUBPROCESS, CDFACTORY, CDLINEPROD) = True Then
                z4267 = D4267
		K4267_MOVE = True
		else
	z4267 = nothing
     End If

     If  getColumIndex(spr,"JobCard") > -1 then z4267.JobCard = getDataM(spr, getColumIndex(spr,"JobCard"), xRow)
     If  getColumIndex(spr,"Szno") > -1 then z4267.Szno = getDataM(spr, getColumIndex(spr,"Szno"), xRow)
     If  getColumIndex(spr,"ProdDate") > -1 then z4267.ProdDate = getDataM(spr, getColumIndex(spr,"ProdDate"), xRow)
     If  getColumIndex(spr,"cdSubProcess") > -1 then z4267.cdSubProcess = getDataM(spr, getColumIndex(spr,"cdSubProcess"), xRow)
     If  getColumIndex(spr,"cdFactory") > -1 then z4267.cdFactory = getDataM(spr, getColumIndex(spr,"cdFactory"), xRow)
     If  getColumIndex(spr,"cdLineProd") > -1 then z4267.cdLineProd = getDataM(spr, getColumIndex(spr,"cdLineProd"), xRow)
     If  getColumIndex(spr,"OrderNo") > -1 then z4267.OrderNo = getDataM(spr, getColumIndex(spr,"OrderNo"), xRow)
     If  getColumIndex(spr,"OrderNoSeq") > -1 then z4267.OrderNoSeq = getDataM(spr, getColumIndex(spr,"OrderNoSeq"), xRow)
     If  getColumIndex(spr,"QtyProduction") > -1 then z4267.QtyProduction = getDataM(spr, getColumIndex(spr,"QtyProduction"), xRow)
     If  getColumIndex(spr,"QtyProductionA") > -1 then z4267.QtyProductionA = getDataM(spr, getColumIndex(spr,"QtyProductionA"), xRow)
     If  getColumIndex(spr,"QtyProductionX") > -1 then z4267.QtyProductionX = getDataM(spr, getColumIndex(spr,"QtyProductionX"), xRow)
     If  getColumIndex(spr,"QtyProductionXP") > -1 then z4267.QtyProductionXP = getDataM(spr, getColumIndex(spr,"QtyProductionXP"), xRow)
     If  getColumIndex(spr,"QtyProductionXR") > -1 then z4267.QtyProductionXR = getDataM(spr, getColumIndex(spr,"QtyProductionXR"), xRow)
     If  getColumIndex(spr,"QtyProductionL") > -1 then z4267.QtyProductionL = getDataM(spr, getColumIndex(spr,"QtyProductionL"), xRow)
     If  getColumIndex(spr,"QtyProductionLA") > -1 then z4267.QtyProductionLA = getDataM(spr, getColumIndex(spr,"QtyProductionLA"), xRow)
     If  getColumIndex(spr,"QtyProductionLX") > -1 then z4267.QtyProductionLX = getDataM(spr, getColumIndex(spr,"QtyProductionLX"), xRow)
     If  getColumIndex(spr,"QtyProductionLXP") > -1 then z4267.QtyProductionLXP = getDataM(spr, getColumIndex(spr,"QtyProductionLXP"), xRow)
     If  getColumIndex(spr,"QtyProductionLXR") > -1 then z4267.QtyProductionLXR = getDataM(spr, getColumIndex(spr,"QtyProductionLXR"), xRow)
     If  getColumIndex(spr,"QtyProductionR") > -1 then z4267.QtyProductionR = getDataM(spr, getColumIndex(spr,"QtyProductionR"), xRow)
     If  getColumIndex(spr,"QtyProductionRA") > -1 then z4267.QtyProductionRA = getDataM(spr, getColumIndex(spr,"QtyProductionRA"), xRow)
     If  getColumIndex(spr,"QtyProductionRX") > -1 then z4267.QtyProductionRX = getDataM(spr, getColumIndex(spr,"QtyProductionRX"), xRow)
     If  getColumIndex(spr,"QtyProductionRXP") > -1 then z4267.QtyProductionRXP = getDataM(spr, getColumIndex(spr,"QtyProductionRXP"), xRow)
     If  getColumIndex(spr,"QtyProductionRXR") > -1 then z4267.QtyProductionRXR = getDataM(spr, getColumIndex(spr,"QtyProductionRXR"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K4267_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K4267_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z4267 As T4267_AREA,CheckClear as Boolean,JOBCARD AS String, SZNO AS String, PRODDATE AS String, CDSUBPROCESS AS String, CDFACTORY AS String, CDLINEPROD AS String) as Boolean

K4267_MOVE = False

Try
    If READ_PFK4267(JOBCARD, SZNO, PRODDATE, CDSUBPROCESS, CDFACTORY, CDLINEPROD) = True Then
                z4267 = D4267
		K4267_MOVE = True
		else
	If CheckClear  = True then z4267 = nothing
     End If

     If  getColumIndex(spr,"JobCard") > -1 then z4267.JobCard = getDataM(spr, getColumIndex(spr,"JobCard"), xRow)
     If  getColumIndex(spr,"Szno") > -1 then z4267.Szno = getDataM(spr, getColumIndex(spr,"Szno"), xRow)
     If  getColumIndex(spr,"ProdDate") > -1 then z4267.ProdDate = getDataM(spr, getColumIndex(spr,"ProdDate"), xRow)
     If  getColumIndex(spr,"cdSubProcess") > -1 then z4267.cdSubProcess = getDataM(spr, getColumIndex(spr,"cdSubProcess"), xRow)
     If  getColumIndex(spr,"cdFactory") > -1 then z4267.cdFactory = getDataM(spr, getColumIndex(spr,"cdFactory"), xRow)
     If  getColumIndex(spr,"cdLineProd") > -1 then z4267.cdLineProd = getDataM(spr, getColumIndex(spr,"cdLineProd"), xRow)
     If  getColumIndex(spr,"OrderNo") > -1 then z4267.OrderNo = getDataM(spr, getColumIndex(spr,"OrderNo"), xRow)
     If  getColumIndex(spr,"OrderNoSeq") > -1 then z4267.OrderNoSeq = getDataM(spr, getColumIndex(spr,"OrderNoSeq"), xRow)
     If  getColumIndex(spr,"QtyProduction") > -1 then z4267.QtyProduction = getDataM(spr, getColumIndex(spr,"QtyProduction"), xRow)
     If  getColumIndex(spr,"QtyProductionA") > -1 then z4267.QtyProductionA = getDataM(spr, getColumIndex(spr,"QtyProductionA"), xRow)
     If  getColumIndex(spr,"QtyProductionX") > -1 then z4267.QtyProductionX = getDataM(spr, getColumIndex(spr,"QtyProductionX"), xRow)
     If  getColumIndex(spr,"QtyProductionXP") > -1 then z4267.QtyProductionXP = getDataM(spr, getColumIndex(spr,"QtyProductionXP"), xRow)
     If  getColumIndex(spr,"QtyProductionXR") > -1 then z4267.QtyProductionXR = getDataM(spr, getColumIndex(spr,"QtyProductionXR"), xRow)
     If  getColumIndex(spr,"QtyProductionL") > -1 then z4267.QtyProductionL = getDataM(spr, getColumIndex(spr,"QtyProductionL"), xRow)
     If  getColumIndex(spr,"QtyProductionLA") > -1 then z4267.QtyProductionLA = getDataM(spr, getColumIndex(spr,"QtyProductionLA"), xRow)
     If  getColumIndex(spr,"QtyProductionLX") > -1 then z4267.QtyProductionLX = getDataM(spr, getColumIndex(spr,"QtyProductionLX"), xRow)
     If  getColumIndex(spr,"QtyProductionLXP") > -1 then z4267.QtyProductionLXP = getDataM(spr, getColumIndex(spr,"QtyProductionLXP"), xRow)
     If  getColumIndex(spr,"QtyProductionLXR") > -1 then z4267.QtyProductionLXR = getDataM(spr, getColumIndex(spr,"QtyProductionLXR"), xRow)
     If  getColumIndex(spr,"QtyProductionR") > -1 then z4267.QtyProductionR = getDataM(spr, getColumIndex(spr,"QtyProductionR"), xRow)
     If  getColumIndex(spr,"QtyProductionRA") > -1 then z4267.QtyProductionRA = getDataM(spr, getColumIndex(spr,"QtyProductionRA"), xRow)
     If  getColumIndex(spr,"QtyProductionRX") > -1 then z4267.QtyProductionRX = getDataM(spr, getColumIndex(spr,"QtyProductionRX"), xRow)
     If  getColumIndex(spr,"QtyProductionRXP") > -1 then z4267.QtyProductionRXP = getDataM(spr, getColumIndex(spr,"QtyProductionRXP"), xRow)
     If  getColumIndex(spr,"QtyProductionRXR") > -1 then z4267.QtyProductionRXR = getDataM(spr, getColumIndex(spr,"QtyProductionRXR"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K4267_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K4267_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z4267 As T4267_AREA, Job as String, JOBCARD AS String, SZNO AS String, PRODDATE AS String, CDSUBPROCESS AS String, CDFACTORY AS String, CDLINEPROD AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K4267_MOVE = False

Try
    If READ_PFK4267(JOBCARD, SZNO, PRODDATE, CDSUBPROCESS, CDFACTORY, CDLINEPROD) = True Then
                z4267 = D4267
		K4267_MOVE = True
		else
	z4267 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4267")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "JOBCARD":z4267.JobCard = Children(i).Code
   Case "SZNO":z4267.Szno = Children(i).Code
   Case "PRODDATE":z4267.ProdDate = Children(i).Code
   Case "CDSUBPROCESS":z4267.cdSubProcess = Children(i).Code
   Case "CDFACTORY":z4267.cdFactory = Children(i).Code
   Case "CDLINEPROD":z4267.cdLineProd = Children(i).Code
   Case "ORDERNO":z4267.OrderNo = Children(i).Code
   Case "ORDERNOSEQ":z4267.OrderNoSeq = Children(i).Code
   Case "QTYPRODUCTION":z4267.QtyProduction = Children(i).Code
   Case "QTYPRODUCTIONA":z4267.QtyProductionA = Children(i).Code
   Case "QTYPRODUCTIONX":z4267.QtyProductionX = Children(i).Code
   Case "QTYPRODUCTIONXP":z4267.QtyProductionXP = Children(i).Code
   Case "QTYPRODUCTIONXR":z4267.QtyProductionXR = Children(i).Code
   Case "QTYPRODUCTIONL":z4267.QtyProductionL = Children(i).Code
   Case "QTYPRODUCTIONLA":z4267.QtyProductionLA = Children(i).Code
   Case "QTYPRODUCTIONLX":z4267.QtyProductionLX = Children(i).Code
   Case "QTYPRODUCTIONLXP":z4267.QtyProductionLXP = Children(i).Code
   Case "QTYPRODUCTIONLXR":z4267.QtyProductionLXR = Children(i).Code
   Case "QTYPRODUCTIONR":z4267.QtyProductionR = Children(i).Code
   Case "QTYPRODUCTIONRA":z4267.QtyProductionRA = Children(i).Code
   Case "QTYPRODUCTIONRX":z4267.QtyProductionRX = Children(i).Code
   Case "QTYPRODUCTIONRXP":z4267.QtyProductionRXP = Children(i).Code
   Case "QTYPRODUCTIONRXR":z4267.QtyProductionRXR = Children(i).Code
                            End Select
                Else
                  Select Case temp1
   Case "JOBCARD":z4267.JobCard = Children(i).Data
   Case "SZNO":z4267.Szno = Children(i).Data
   Case "PRODDATE":z4267.ProdDate = Children(i).Data
   Case "CDSUBPROCESS":z4267.cdSubProcess = Children(i).Data
   Case "CDFACTORY":z4267.cdFactory = Children(i).Data
   Case "CDLINEPROD":z4267.cdLineProd = Children(i).Data
   Case "ORDERNO":z4267.OrderNo = Children(i).Data
   Case "ORDERNOSEQ":z4267.OrderNoSeq = Children(i).Data
   Case "QTYPRODUCTION":z4267.QtyProduction = Children(i).Data
   Case "QTYPRODUCTIONA":z4267.QtyProductionA = Children(i).Data
   Case "QTYPRODUCTIONX":z4267.QtyProductionX = Children(i).Data
   Case "QTYPRODUCTIONXP":z4267.QtyProductionXP = Children(i).Data
   Case "QTYPRODUCTIONXR":z4267.QtyProductionXR = Children(i).Data
   Case "QTYPRODUCTIONL":z4267.QtyProductionL = Children(i).Data
   Case "QTYPRODUCTIONLA":z4267.QtyProductionLA = Children(i).Data
   Case "QTYPRODUCTIONLX":z4267.QtyProductionLX = Children(i).Data
   Case "QTYPRODUCTIONLXP":z4267.QtyProductionLXP = Children(i).Data
   Case "QTYPRODUCTIONLXR":z4267.QtyProductionLXR = Children(i).Data
   Case "QTYPRODUCTIONR":z4267.QtyProductionR = Children(i).Data
   Case "QTYPRODUCTIONRA":z4267.QtyProductionRA = Children(i).Data
   Case "QTYPRODUCTIONRX":z4267.QtyProductionRX = Children(i).Data
   Case "QTYPRODUCTIONRXP":z4267.QtyProductionRXP = Children(i).Data
   Case "QTYPRODUCTIONRXR":z4267.QtyProductionRXR = Children(i).Data
                            End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K4267_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K4267_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z4267 As T4267_AREA, Job as String, CheckClear as Boolean, JOBCARD AS String, SZNO AS String, PRODDATE AS String, CDSUBPROCESS AS String, CDFACTORY AS String, CDLINEPROD AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K4267_MOVE = False

Try
    If READ_PFK4267(JOBCARD, SZNO, PRODDATE, CDSUBPROCESS, CDFACTORY, CDLINEPROD) = True Then
                z4267 = D4267
		K4267_MOVE = True
		else
	If CheckClear  = True then z4267 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4267")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "JOBCARD":z4267.JobCard = Children(i).Code
   Case "SZNO":z4267.Szno = Children(i).Code
   Case "PRODDATE":z4267.ProdDate = Children(i).Code
   Case "CDSUBPROCESS":z4267.cdSubProcess = Children(i).Code
   Case "CDFACTORY":z4267.cdFactory = Children(i).Code
   Case "CDLINEPROD":z4267.cdLineProd = Children(i).Code
   Case "ORDERNO":z4267.OrderNo = Children(i).Code
   Case "ORDERNOSEQ":z4267.OrderNoSeq = Children(i).Code
   Case "QTYPRODUCTION":z4267.QtyProduction = Children(i).Code
   Case "QTYPRODUCTIONA":z4267.QtyProductionA = Children(i).Code
   Case "QTYPRODUCTIONX":z4267.QtyProductionX = Children(i).Code
   Case "QTYPRODUCTIONXP":z4267.QtyProductionXP = Children(i).Code
   Case "QTYPRODUCTIONXR":z4267.QtyProductionXR = Children(i).Code
   Case "QTYPRODUCTIONL":z4267.QtyProductionL = Children(i).Code
   Case "QTYPRODUCTIONLA":z4267.QtyProductionLA = Children(i).Code
   Case "QTYPRODUCTIONLX":z4267.QtyProductionLX = Children(i).Code
   Case "QTYPRODUCTIONLXP":z4267.QtyProductionLXP = Children(i).Code
   Case "QTYPRODUCTIONLXR":z4267.QtyProductionLXR = Children(i).Code
   Case "QTYPRODUCTIONR":z4267.QtyProductionR = Children(i).Code
   Case "QTYPRODUCTIONRA":z4267.QtyProductionRA = Children(i).Code
   Case "QTYPRODUCTIONRX":z4267.QtyProductionRX = Children(i).Code
   Case "QTYPRODUCTIONRXP":z4267.QtyProductionRXP = Children(i).Code
   Case "QTYPRODUCTIONRXR":z4267.QtyProductionRXR = Children(i).Code
                            End Select
                Else
                  Select Case temp1
   Case "JOBCARD":z4267.JobCard = Children(i).Data
   Case "SZNO":z4267.Szno = Children(i).Data
   Case "PRODDATE":z4267.ProdDate = Children(i).Data
   Case "CDSUBPROCESS":z4267.cdSubProcess = Children(i).Data
   Case "CDFACTORY":z4267.cdFactory = Children(i).Data
   Case "CDLINEPROD":z4267.cdLineProd = Children(i).Data
   Case "ORDERNO":z4267.OrderNo = Children(i).Data
   Case "ORDERNOSEQ":z4267.OrderNoSeq = Children(i).Data
   Case "QTYPRODUCTION":z4267.QtyProduction = Children(i).Data
   Case "QTYPRODUCTIONA":z4267.QtyProductionA = Children(i).Data
   Case "QTYPRODUCTIONX":z4267.QtyProductionX = Children(i).Data
   Case "QTYPRODUCTIONXP":z4267.QtyProductionXP = Children(i).Data
   Case "QTYPRODUCTIONXR":z4267.QtyProductionXR = Children(i).Data
   Case "QTYPRODUCTIONL":z4267.QtyProductionL = Children(i).Data
   Case "QTYPRODUCTIONLA":z4267.QtyProductionLA = Children(i).Data
   Case "QTYPRODUCTIONLX":z4267.QtyProductionLX = Children(i).Data
   Case "QTYPRODUCTIONLXP":z4267.QtyProductionLXP = Children(i).Data
   Case "QTYPRODUCTIONLXR":z4267.QtyProductionLXR = Children(i).Data
   Case "QTYPRODUCTIONR":z4267.QtyProductionR = Children(i).Data
   Case "QTYPRODUCTIONRA":z4267.QtyProductionRA = Children(i).Data
   Case "QTYPRODUCTIONRX":z4267.QtyProductionRX = Children(i).Data
   Case "QTYPRODUCTIONRXP":z4267.QtyProductionRXP = Children(i).Data
   Case "QTYPRODUCTIONRXR":z4267.QtyProductionRXR = Children(i).Data
                            End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K4267_MOVE",vbCritical)
End Try
End Function 
    
End Module 
