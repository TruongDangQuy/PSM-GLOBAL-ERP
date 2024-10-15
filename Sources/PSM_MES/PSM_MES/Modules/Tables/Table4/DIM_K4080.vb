'=========================================================================================================================================================
'   TABLE : (PFK4080)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K4080

Structure T4080_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	ProdDate	 AS String	'			char(8)		*
Public 	ProdSeq	 AS String	'			char(5)		*
Public 	JobCard	 AS String	'			char(9)
Public 	Szno	 AS String	'			char(2)
Public 	seMainProcess	 AS String	'			char(3)
Public 	cdMainProcess	 AS String	'			char(3)
Public 	seSubProcess	 AS String	'			char(3)
Public 	cdSubProcess	 AS String	'			char(3)
Public 	seFactory	 AS String	'			char(3)
Public 	cdFactory	 AS String	'			char(3)
Public 	seLineProd	 AS String	'			char(3)
Public 	cdLineProd	 AS String	'			char(3)
Public 	MachineCode	 AS String	'			char(6)
Public 	MachineTno	 AS String	'			char(2)
Public 	DateProduction	 AS String	'			char(8)
Public 	STimeProduction	 AS String	'			nvarchar(20)
Public 	ETimeProduction	 AS String	'			nvarchar(20)
Public 	InchargeProdution	 AS String	'			char(8)
Public 	seMachineType	 AS String	'			char(3)
Public 	cdMachineType	 AS String	'			char(3)
Public 	PartProduction	 AS String	'			char(1)
Public 	QtyBatch	 AS Double	'			decimal
Public 	QtyProduction	 AS Double	'			decimal
Public 	QtyProductionA	 AS Double	'			decimal
Public 	QtyProductionX	 AS Double	'			decimal
Public 	QtyProductionXP	 AS Double	'			decimal
Public 	QtyProductionXR	 AS Double	'			decimal
Public 	QtyBLOut	 AS Double	'			decimal
Public 	QtyBLIn	 AS Double	'			decimal
Public 	AmountProduction	 AS Double	'			decimal
Public 	AmountProductionReceipt	 AS Double	'			decimal
Public 	ISUD	 AS String	'			char(4)
Public 	CheckComplete	 AS String	'			char(1)
Public 	CheckTrigger	 AS String	'			nvarchar(10)
Public 	Remark	 AS String	'			nvarchar(100)
'=========================================================================================================================================================
End structure

Public D4080 As T4080_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK4080(PRODDATE AS String, PRODSEQ AS String) As Boolean
    READ_PFK4080 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK4080 "
    SQL = SQL & " WHERE K4080_ProdDate		 = '" & ProdDate & "' " 
    SQL = SQL & "   AND K4080_ProdSeq		 = '" & ProdSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D4080_CLEAR: GoTo SKIP_READ_PFK4080
                
    Call K4080_MOVE(rd)
    READ_PFK4080 = True

SKIP_READ_PFK4080:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK4080",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK4080(PRODDATE AS String, PRODSEQ AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK4080 "
    SQL = SQL & " WHERE K4080_ProdDate		 = '" & ProdDate & "' " 
    SQL = SQL & "   AND K4080_ProdSeq		 = '" & ProdSeq & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK4080",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK4080(z4080 As T4080_AREA) As Boolean
    WRITE_PFK4080 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z4080)
 
    SQL = " INSERT INTO PFK4080 "
    SQL = SQL & " ( "
    SQL = SQL & " K4080_ProdDate," 
    SQL = SQL & " K4080_ProdSeq," 
    SQL = SQL & " K4080_JobCard," 
    SQL = SQL & " K4080_Szno," 
    SQL = SQL & " K4080_seMainProcess," 
    SQL = SQL & " K4080_cdMainProcess," 
    SQL = SQL & " K4080_seSubProcess," 
    SQL = SQL & " K4080_cdSubProcess," 
    SQL = SQL & " K4080_seFactory," 
    SQL = SQL & " K4080_cdFactory," 
    SQL = SQL & " K4080_seLineProd," 
    SQL = SQL & " K4080_cdLineProd," 
    SQL = SQL & " K4080_MachineCode," 
    SQL = SQL & " K4080_MachineTno," 
    SQL = SQL & " K4080_DateProduction," 
    SQL = SQL & " K4080_STimeProduction," 
    SQL = SQL & " K4080_ETimeProduction," 
    SQL = SQL & " K4080_InchargeProdution," 
    SQL = SQL & " K4080_seMachineType," 
    SQL = SQL & " K4080_cdMachineType," 
    SQL = SQL & " K4080_PartProduction," 
    SQL = SQL & " K4080_QtyBatch," 
    SQL = SQL & " K4080_QtyProduction," 
    SQL = SQL & " K4080_QtyProductionA," 
    SQL = SQL & " K4080_QtyProductionX," 
    SQL = SQL & " K4080_QtyProductionXP," 
    SQL = SQL & " K4080_QtyProductionXR," 
    SQL = SQL & " K4080_QtyBLOut," 
    SQL = SQL & " K4080_QtyBLIn," 
    SQL = SQL & " K4080_AmountProduction," 
    SQL = SQL & " K4080_AmountProductionReceipt," 
    SQL = SQL & " K4080_ISUD," 
    SQL = SQL & " K4080_CheckComplete," 
    SQL = SQL & " K4080_CheckTrigger," 
    SQL = SQL & " K4080_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z4080.ProdDate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4080.ProdSeq) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4080.JobCard) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4080.Szno) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4080.seMainProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4080.cdMainProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4080.seSubProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4080.cdSubProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4080.seFactory) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4080.cdFactory) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4080.seLineProd) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4080.cdLineProd) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4080.MachineCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4080.MachineTno) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4080.DateProduction) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4080.STimeProduction) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4080.ETimeProduction) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4080.InchargeProdution) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4080.seMachineType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4080.cdMachineType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4080.PartProduction) & "', "  
    SQL = SQL & "   " & FormatSQL(z4080.QtyBatch) & ", "  
    SQL = SQL & "   " & FormatSQL(z4080.QtyProduction) & ", "  
    SQL = SQL & "   " & FormatSQL(z4080.QtyProductionA) & ", "  
    SQL = SQL & "   " & FormatSQL(z4080.QtyProductionX) & ", "  
    SQL = SQL & "   " & FormatSQL(z4080.QtyProductionXP) & ", "  
    SQL = SQL & "   " & FormatSQL(z4080.QtyProductionXR) & ", "  
    SQL = SQL & "   " & FormatSQL(z4080.QtyBLOut) & ", "  
    SQL = SQL & "   " & FormatSQL(z4080.QtyBLIn) & ", "  
    SQL = SQL & "   " & FormatSQL(z4080.AmountProduction) & ", "  
    SQL = SQL & "   " & FormatSQL(z4080.AmountProductionReceipt) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z4080.ISUD) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4080.CheckComplete) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4080.CheckTrigger) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4080.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK4080 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK4080",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK4080(z4080 As T4080_AREA) As Boolean
    REWRITE_PFK4080 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z4080)
   
    SQL = " UPDATE PFK4080 SET "
    SQL = SQL & "    K4080_JobCard      = N'" & FormatSQL(z4080.JobCard) & "', " 
    SQL = SQL & "    K4080_Szno      = N'" & FormatSQL(z4080.Szno) & "', " 
    SQL = SQL & "    K4080_seMainProcess      = N'" & FormatSQL(z4080.seMainProcess) & "', " 
    SQL = SQL & "    K4080_cdMainProcess      = N'" & FormatSQL(z4080.cdMainProcess) & "', " 
    SQL = SQL & "    K4080_seSubProcess      = N'" & FormatSQL(z4080.seSubProcess) & "', " 
    SQL = SQL & "    K4080_cdSubProcess      = N'" & FormatSQL(z4080.cdSubProcess) & "', " 
    SQL = SQL & "    K4080_seFactory      = N'" & FormatSQL(z4080.seFactory) & "', " 
    SQL = SQL & "    K4080_cdFactory      = N'" & FormatSQL(z4080.cdFactory) & "', " 
    SQL = SQL & "    K4080_seLineProd      = N'" & FormatSQL(z4080.seLineProd) & "', " 
    SQL = SQL & "    K4080_cdLineProd      = N'" & FormatSQL(z4080.cdLineProd) & "', " 
    SQL = SQL & "    K4080_MachineCode      = N'" & FormatSQL(z4080.MachineCode) & "', " 
    SQL = SQL & "    K4080_MachineTno      = N'" & FormatSQL(z4080.MachineTno) & "', " 
    SQL = SQL & "    K4080_DateProduction      = N'" & FormatSQL(z4080.DateProduction) & "', " 
    SQL = SQL & "    K4080_STimeProduction      = N'" & FormatSQL(z4080.STimeProduction) & "', " 
    SQL = SQL & "    K4080_ETimeProduction      = N'" & FormatSQL(z4080.ETimeProduction) & "', " 
    SQL = SQL & "    K4080_InchargeProdution      = N'" & FormatSQL(z4080.InchargeProdution) & "', " 
    SQL = SQL & "    K4080_seMachineType      = N'" & FormatSQL(z4080.seMachineType) & "', " 
    SQL = SQL & "    K4080_cdMachineType      = N'" & FormatSQL(z4080.cdMachineType) & "', " 
    SQL = SQL & "    K4080_PartProduction      = N'" & FormatSQL(z4080.PartProduction) & "', " 
    SQL = SQL & "    K4080_QtyBatch      =  " & FormatSQL(z4080.QtyBatch) & ", " 
    SQL = SQL & "    K4080_QtyProduction      =  " & FormatSQL(z4080.QtyProduction) & ", " 
    SQL = SQL & "    K4080_QtyProductionA      =  " & FormatSQL(z4080.QtyProductionA) & ", " 
    SQL = SQL & "    K4080_QtyProductionX      =  " & FormatSQL(z4080.QtyProductionX) & ", " 
    SQL = SQL & "    K4080_QtyProductionXP      =  " & FormatSQL(z4080.QtyProductionXP) & ", " 
    SQL = SQL & "    K4080_QtyProductionXR      =  " & FormatSQL(z4080.QtyProductionXR) & ", " 
    SQL = SQL & "    K4080_QtyBLOut      =  " & FormatSQL(z4080.QtyBLOut) & ", " 
    SQL = SQL & "    K4080_QtyBLIn      =  " & FormatSQL(z4080.QtyBLIn) & ", " 
    SQL = SQL & "    K4080_AmountProduction      =  " & FormatSQL(z4080.AmountProduction) & ", " 
    SQL = SQL & "    K4080_AmountProductionReceipt      =  " & FormatSQL(z4080.AmountProductionReceipt) & ", " 
    SQL = SQL & "    K4080_ISUD      = N'" & FormatSQL(z4080.ISUD) & "', " 
    SQL = SQL & "    K4080_CheckComplete      = N'" & FormatSQL(z4080.CheckComplete) & "', " 
    SQL = SQL & "    K4080_CheckTrigger      = N'" & FormatSQL(z4080.CheckTrigger) & "', " 
    SQL = SQL & "    K4080_Remark      = N'" & FormatSQL(z4080.Remark) & "'  " 
    SQL = SQL & " WHERE K4080_ProdDate		 = '" & z4080.ProdDate & "' " 
    SQL = SQL & "   AND K4080_ProdSeq		 = '" & z4080.ProdSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK4080 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK4080",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK4080(z4080 As T4080_AREA) As Boolean
    DELETE_PFK4080 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK4080 "
    SQL = SQL & " WHERE K4080_ProdDate		 = '" & z4080.ProdDate & "' " 
    SQL = SQL & "   AND K4080_ProdSeq		 = '" & z4080.ProdSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK4080 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK4080",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D4080_CLEAR()
Try
    
   D4080.ProdDate = ""
   D4080.ProdSeq = ""
   D4080.JobCard = ""
   D4080.Szno = ""
   D4080.seMainProcess = ""
   D4080.cdMainProcess = ""
   D4080.seSubProcess = ""
   D4080.cdSubProcess = ""
   D4080.seFactory = ""
   D4080.cdFactory = ""
   D4080.seLineProd = ""
   D4080.cdLineProd = ""
   D4080.MachineCode = ""
   D4080.MachineTno = ""
   D4080.DateProduction = ""
   D4080.STimeProduction = ""
   D4080.ETimeProduction = ""
   D4080.InchargeProdution = ""
   D4080.seMachineType = ""
   D4080.cdMachineType = ""
   D4080.PartProduction = ""
    D4080.QtyBatch = 0 
    D4080.QtyProduction = 0 
    D4080.QtyProductionA = 0 
    D4080.QtyProductionX = 0 
    D4080.QtyProductionXP = 0 
    D4080.QtyProductionXR = 0 
    D4080.QtyBLOut = 0 
    D4080.QtyBLIn = 0 
    D4080.AmountProduction = 0 
    D4080.AmountProductionReceipt = 0 
   D4080.ISUD = ""
   D4080.CheckComplete = ""
   D4080.CheckTrigger = ""
   D4080.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D4080_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x4080 As T4080_AREA)
Try
    
    x4080.ProdDate = trim$(  x4080.ProdDate)
    x4080.ProdSeq = trim$(  x4080.ProdSeq)
    x4080.JobCard = trim$(  x4080.JobCard)
    x4080.Szno = trim$(  x4080.Szno)
    x4080.seMainProcess = trim$(  x4080.seMainProcess)
    x4080.cdMainProcess = trim$(  x4080.cdMainProcess)
    x4080.seSubProcess = trim$(  x4080.seSubProcess)
    x4080.cdSubProcess = trim$(  x4080.cdSubProcess)
    x4080.seFactory = trim$(  x4080.seFactory)
    x4080.cdFactory = trim$(  x4080.cdFactory)
    x4080.seLineProd = trim$(  x4080.seLineProd)
    x4080.cdLineProd = trim$(  x4080.cdLineProd)
    x4080.MachineCode = trim$(  x4080.MachineCode)
    x4080.MachineTno = trim$(  x4080.MachineTno)
    x4080.DateProduction = trim$(  x4080.DateProduction)
    x4080.STimeProduction = trim$(  x4080.STimeProduction)
    x4080.ETimeProduction = trim$(  x4080.ETimeProduction)
    x4080.InchargeProdution = trim$(  x4080.InchargeProdution)
    x4080.seMachineType = trim$(  x4080.seMachineType)
    x4080.cdMachineType = trim$(  x4080.cdMachineType)
    x4080.PartProduction = trim$(  x4080.PartProduction)
    x4080.QtyBatch = trim$(  x4080.QtyBatch)
    x4080.QtyProduction = trim$(  x4080.QtyProduction)
    x4080.QtyProductionA = trim$(  x4080.QtyProductionA)
    x4080.QtyProductionX = trim$(  x4080.QtyProductionX)
    x4080.QtyProductionXP = trim$(  x4080.QtyProductionXP)
    x4080.QtyProductionXR = trim$(  x4080.QtyProductionXR)
    x4080.QtyBLOut = trim$(  x4080.QtyBLOut)
    x4080.QtyBLIn = trim$(  x4080.QtyBLIn)
    x4080.AmountProduction = trim$(  x4080.AmountProduction)
    x4080.AmountProductionReceipt = trim$(  x4080.AmountProductionReceipt)
    x4080.ISUD = trim$(  x4080.ISUD)
    x4080.CheckComplete = trim$(  x4080.CheckComplete)
    x4080.CheckTrigger = trim$(  x4080.CheckTrigger)
    x4080.Remark = trim$(  x4080.Remark)
     
    If trim$( x4080.ProdDate ) = "" Then x4080.ProdDate = Space(1) 
    If trim$( x4080.ProdSeq ) = "" Then x4080.ProdSeq = Space(1) 
    If trim$( x4080.JobCard ) = "" Then x4080.JobCard = Space(1) 
    If trim$( x4080.Szno ) = "" Then x4080.Szno = Space(1) 
    If trim$( x4080.seMainProcess ) = "" Then x4080.seMainProcess = Space(1) 
    If trim$( x4080.cdMainProcess ) = "" Then x4080.cdMainProcess = Space(1) 
    If trim$( x4080.seSubProcess ) = "" Then x4080.seSubProcess = Space(1) 
    If trim$( x4080.cdSubProcess ) = "" Then x4080.cdSubProcess = Space(1) 
    If trim$( x4080.seFactory ) = "" Then x4080.seFactory = Space(1) 
    If trim$( x4080.cdFactory ) = "" Then x4080.cdFactory = Space(1) 
    If trim$( x4080.seLineProd ) = "" Then x4080.seLineProd = Space(1) 
    If trim$( x4080.cdLineProd ) = "" Then x4080.cdLineProd = Space(1) 
    If trim$( x4080.MachineCode ) = "" Then x4080.MachineCode = Space(1) 
    If trim$( x4080.MachineTno ) = "" Then x4080.MachineTno = Space(1) 
    If trim$( x4080.DateProduction ) = "" Then x4080.DateProduction = Space(1) 
    If trim$( x4080.STimeProduction ) = "" Then x4080.STimeProduction = Space(1) 
    If trim$( x4080.ETimeProduction ) = "" Then x4080.ETimeProduction = Space(1) 
    If trim$( x4080.InchargeProdution ) = "" Then x4080.InchargeProdution = Space(1) 
    If trim$( x4080.seMachineType ) = "" Then x4080.seMachineType = Space(1) 
    If trim$( x4080.cdMachineType ) = "" Then x4080.cdMachineType = Space(1) 
    If trim$( x4080.PartProduction ) = "" Then x4080.PartProduction = Space(1) 
    If trim$( x4080.QtyBatch ) = "" Then x4080.QtyBatch = 0 
    If trim$( x4080.QtyProduction ) = "" Then x4080.QtyProduction = 0 
    If trim$( x4080.QtyProductionA ) = "" Then x4080.QtyProductionA = 0 
    If trim$( x4080.QtyProductionX ) = "" Then x4080.QtyProductionX = 0 
    If trim$( x4080.QtyProductionXP ) = "" Then x4080.QtyProductionXP = 0 
    If trim$( x4080.QtyProductionXR ) = "" Then x4080.QtyProductionXR = 0 
    If trim$( x4080.QtyBLOut ) = "" Then x4080.QtyBLOut = 0 
    If trim$( x4080.QtyBLIn ) = "" Then x4080.QtyBLIn = 0 
    If trim$( x4080.AmountProduction ) = "" Then x4080.AmountProduction = 0 
    If trim$( x4080.AmountProductionReceipt ) = "" Then x4080.AmountProductionReceipt = 0 
    If trim$( x4080.ISUD ) = "" Then x4080.ISUD = Space(1) 
    If trim$( x4080.CheckComplete ) = "" Then x4080.CheckComplete = Space(1) 
    If trim$( x4080.CheckTrigger ) = "" Then x4080.CheckTrigger = Space(1) 
    If trim$( x4080.Remark ) = "" Then x4080.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K4080_MOVE(rs4080 As SqlClient.SqlDataReader)
Try

    call D4080_CLEAR()   

    If IsdbNull(rs4080!K4080_ProdDate) = False Then D4080.ProdDate = Trim$(rs4080!K4080_ProdDate)
    If IsdbNull(rs4080!K4080_ProdSeq) = False Then D4080.ProdSeq = Trim$(rs4080!K4080_ProdSeq)
    If IsdbNull(rs4080!K4080_JobCard) = False Then D4080.JobCard = Trim$(rs4080!K4080_JobCard)
    If IsdbNull(rs4080!K4080_Szno) = False Then D4080.Szno = Trim$(rs4080!K4080_Szno)
    If IsdbNull(rs4080!K4080_seMainProcess) = False Then D4080.seMainProcess = Trim$(rs4080!K4080_seMainProcess)
    If IsdbNull(rs4080!K4080_cdMainProcess) = False Then D4080.cdMainProcess = Trim$(rs4080!K4080_cdMainProcess)
    If IsdbNull(rs4080!K4080_seSubProcess) = False Then D4080.seSubProcess = Trim$(rs4080!K4080_seSubProcess)
    If IsdbNull(rs4080!K4080_cdSubProcess) = False Then D4080.cdSubProcess = Trim$(rs4080!K4080_cdSubProcess)
    If IsdbNull(rs4080!K4080_seFactory) = False Then D4080.seFactory = Trim$(rs4080!K4080_seFactory)
    If IsdbNull(rs4080!K4080_cdFactory) = False Then D4080.cdFactory = Trim$(rs4080!K4080_cdFactory)
    If IsdbNull(rs4080!K4080_seLineProd) = False Then D4080.seLineProd = Trim$(rs4080!K4080_seLineProd)
    If IsdbNull(rs4080!K4080_cdLineProd) = False Then D4080.cdLineProd = Trim$(rs4080!K4080_cdLineProd)
    If IsdbNull(rs4080!K4080_MachineCode) = False Then D4080.MachineCode = Trim$(rs4080!K4080_MachineCode)
    If IsdbNull(rs4080!K4080_MachineTno) = False Then D4080.MachineTno = Trim$(rs4080!K4080_MachineTno)
    If IsdbNull(rs4080!K4080_DateProduction) = False Then D4080.DateProduction = Trim$(rs4080!K4080_DateProduction)
    If IsdbNull(rs4080!K4080_STimeProduction) = False Then D4080.STimeProduction = Trim$(rs4080!K4080_STimeProduction)
    If IsdbNull(rs4080!K4080_ETimeProduction) = False Then D4080.ETimeProduction = Trim$(rs4080!K4080_ETimeProduction)
    If IsdbNull(rs4080!K4080_InchargeProdution) = False Then D4080.InchargeProdution = Trim$(rs4080!K4080_InchargeProdution)
    If IsdbNull(rs4080!K4080_seMachineType) = False Then D4080.seMachineType = Trim$(rs4080!K4080_seMachineType)
    If IsdbNull(rs4080!K4080_cdMachineType) = False Then D4080.cdMachineType = Trim$(rs4080!K4080_cdMachineType)
    If IsdbNull(rs4080!K4080_PartProduction) = False Then D4080.PartProduction = Trim$(rs4080!K4080_PartProduction)
    If IsdbNull(rs4080!K4080_QtyBatch) = False Then D4080.QtyBatch = Trim$(rs4080!K4080_QtyBatch)
    If IsdbNull(rs4080!K4080_QtyProduction) = False Then D4080.QtyProduction = Trim$(rs4080!K4080_QtyProduction)
    If IsdbNull(rs4080!K4080_QtyProductionA) = False Then D4080.QtyProductionA = Trim$(rs4080!K4080_QtyProductionA)
    If IsdbNull(rs4080!K4080_QtyProductionX) = False Then D4080.QtyProductionX = Trim$(rs4080!K4080_QtyProductionX)
    If IsdbNull(rs4080!K4080_QtyProductionXP) = False Then D4080.QtyProductionXP = Trim$(rs4080!K4080_QtyProductionXP)
    If IsdbNull(rs4080!K4080_QtyProductionXR) = False Then D4080.QtyProductionXR = Trim$(rs4080!K4080_QtyProductionXR)
    If IsdbNull(rs4080!K4080_QtyBLOut) = False Then D4080.QtyBLOut = Trim$(rs4080!K4080_QtyBLOut)
    If IsdbNull(rs4080!K4080_QtyBLIn) = False Then D4080.QtyBLIn = Trim$(rs4080!K4080_QtyBLIn)
    If IsdbNull(rs4080!K4080_AmountProduction) = False Then D4080.AmountProduction = Trim$(rs4080!K4080_AmountProduction)
    If IsdbNull(rs4080!K4080_AmountProductionReceipt) = False Then D4080.AmountProductionReceipt = Trim$(rs4080!K4080_AmountProductionReceipt)
    If IsdbNull(rs4080!K4080_ISUD) = False Then D4080.ISUD = Trim$(rs4080!K4080_ISUD)
    If IsdbNull(rs4080!K4080_CheckComplete) = False Then D4080.CheckComplete = Trim$(rs4080!K4080_CheckComplete)
    If IsdbNull(rs4080!K4080_CheckTrigger) = False Then D4080.CheckTrigger = Trim$(rs4080!K4080_CheckTrigger)
    If IsdbNull(rs4080!K4080_Remark) = False Then D4080.Remark = Trim$(rs4080!K4080_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K4080_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K4080_MOVE(rs4080 As DataRow)
Try

    call D4080_CLEAR()   

    If IsdbNull(rs4080!K4080_ProdDate) = False Then D4080.ProdDate = Trim$(rs4080!K4080_ProdDate)
    If IsdbNull(rs4080!K4080_ProdSeq) = False Then D4080.ProdSeq = Trim$(rs4080!K4080_ProdSeq)
    If IsdbNull(rs4080!K4080_JobCard) = False Then D4080.JobCard = Trim$(rs4080!K4080_JobCard)
    If IsdbNull(rs4080!K4080_Szno) = False Then D4080.Szno = Trim$(rs4080!K4080_Szno)
    If IsdbNull(rs4080!K4080_seMainProcess) = False Then D4080.seMainProcess = Trim$(rs4080!K4080_seMainProcess)
    If IsdbNull(rs4080!K4080_cdMainProcess) = False Then D4080.cdMainProcess = Trim$(rs4080!K4080_cdMainProcess)
    If IsdbNull(rs4080!K4080_seSubProcess) = False Then D4080.seSubProcess = Trim$(rs4080!K4080_seSubProcess)
    If IsdbNull(rs4080!K4080_cdSubProcess) = False Then D4080.cdSubProcess = Trim$(rs4080!K4080_cdSubProcess)
    If IsdbNull(rs4080!K4080_seFactory) = False Then D4080.seFactory = Trim$(rs4080!K4080_seFactory)
    If IsdbNull(rs4080!K4080_cdFactory) = False Then D4080.cdFactory = Trim$(rs4080!K4080_cdFactory)
    If IsdbNull(rs4080!K4080_seLineProd) = False Then D4080.seLineProd = Trim$(rs4080!K4080_seLineProd)
    If IsdbNull(rs4080!K4080_cdLineProd) = False Then D4080.cdLineProd = Trim$(rs4080!K4080_cdLineProd)
    If IsdbNull(rs4080!K4080_MachineCode) = False Then D4080.MachineCode = Trim$(rs4080!K4080_MachineCode)
    If IsdbNull(rs4080!K4080_MachineTno) = False Then D4080.MachineTno = Trim$(rs4080!K4080_MachineTno)
    If IsdbNull(rs4080!K4080_DateProduction) = False Then D4080.DateProduction = Trim$(rs4080!K4080_DateProduction)
    If IsdbNull(rs4080!K4080_STimeProduction) = False Then D4080.STimeProduction = Trim$(rs4080!K4080_STimeProduction)
    If IsdbNull(rs4080!K4080_ETimeProduction) = False Then D4080.ETimeProduction = Trim$(rs4080!K4080_ETimeProduction)
    If IsdbNull(rs4080!K4080_InchargeProdution) = False Then D4080.InchargeProdution = Trim$(rs4080!K4080_InchargeProdution)
    If IsdbNull(rs4080!K4080_seMachineType) = False Then D4080.seMachineType = Trim$(rs4080!K4080_seMachineType)
    If IsdbNull(rs4080!K4080_cdMachineType) = False Then D4080.cdMachineType = Trim$(rs4080!K4080_cdMachineType)
    If IsdbNull(rs4080!K4080_PartProduction) = False Then D4080.PartProduction = Trim$(rs4080!K4080_PartProduction)
    If IsdbNull(rs4080!K4080_QtyBatch) = False Then D4080.QtyBatch = Trim$(rs4080!K4080_QtyBatch)
    If IsdbNull(rs4080!K4080_QtyProduction) = False Then D4080.QtyProduction = Trim$(rs4080!K4080_QtyProduction)
    If IsdbNull(rs4080!K4080_QtyProductionA) = False Then D4080.QtyProductionA = Trim$(rs4080!K4080_QtyProductionA)
    If IsdbNull(rs4080!K4080_QtyProductionX) = False Then D4080.QtyProductionX = Trim$(rs4080!K4080_QtyProductionX)
    If IsdbNull(rs4080!K4080_QtyProductionXP) = False Then D4080.QtyProductionXP = Trim$(rs4080!K4080_QtyProductionXP)
    If IsdbNull(rs4080!K4080_QtyProductionXR) = False Then D4080.QtyProductionXR = Trim$(rs4080!K4080_QtyProductionXR)
    If IsdbNull(rs4080!K4080_QtyBLOut) = False Then D4080.QtyBLOut = Trim$(rs4080!K4080_QtyBLOut)
    If IsdbNull(rs4080!K4080_QtyBLIn) = False Then D4080.QtyBLIn = Trim$(rs4080!K4080_QtyBLIn)
    If IsdbNull(rs4080!K4080_AmountProduction) = False Then D4080.AmountProduction = Trim$(rs4080!K4080_AmountProduction)
    If IsdbNull(rs4080!K4080_AmountProductionReceipt) = False Then D4080.AmountProductionReceipt = Trim$(rs4080!K4080_AmountProductionReceipt)
    If IsdbNull(rs4080!K4080_ISUD) = False Then D4080.ISUD = Trim$(rs4080!K4080_ISUD)
    If IsdbNull(rs4080!K4080_CheckComplete) = False Then D4080.CheckComplete = Trim$(rs4080!K4080_CheckComplete)
    If IsdbNull(rs4080!K4080_CheckTrigger) = False Then D4080.CheckTrigger = Trim$(rs4080!K4080_CheckTrigger)
    If IsdbNull(rs4080!K4080_Remark) = False Then D4080.Remark = Trim$(rs4080!K4080_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K4080_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K4080_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z4080 As T4080_AREA, PRODDATE AS String, PRODSEQ AS String) as Boolean

K4080_MOVE = False

Try
    If READ_PFK4080(PRODDATE, PRODSEQ) = True Then
                z4080 = D4080
		K4080_MOVE = True
		else
	z4080 = nothing
     End If

     If  getColumIndex(spr,"ProdDate") > -1 then z4080.ProdDate = getDataM(spr, getColumIndex(spr,"ProdDate"), xRow)
     If  getColumIndex(spr,"ProdSeq") > -1 then z4080.ProdSeq = getDataM(spr, getColumIndex(spr,"ProdSeq"), xRow)
     If  getColumIndex(spr,"JobCard") > -1 then z4080.JobCard = getDataM(spr, getColumIndex(spr,"JobCard"), xRow)
     If  getColumIndex(spr,"Szno") > -1 then z4080.Szno = getDataM(spr, getColumIndex(spr,"Szno"), xRow)
     If  getColumIndex(spr,"seMainProcess") > -1 then z4080.seMainProcess = getDataM(spr, getColumIndex(spr,"seMainProcess"), xRow)
     If  getColumIndex(spr,"cdMainProcess") > -1 then z4080.cdMainProcess = getDataM(spr, getColumIndex(spr,"cdMainProcess"), xRow)
     If  getColumIndex(spr,"seSubProcess") > -1 then z4080.seSubProcess = getDataM(spr, getColumIndex(spr,"seSubProcess"), xRow)
     If  getColumIndex(spr,"cdSubProcess") > -1 then z4080.cdSubProcess = getDataM(spr, getColumIndex(spr,"cdSubProcess"), xRow)
     If  getColumIndex(spr,"seFactory") > -1 then z4080.seFactory = getDataM(spr, getColumIndex(spr,"seFactory"), xRow)
     If  getColumIndex(spr,"cdFactory") > -1 then z4080.cdFactory = getDataM(spr, getColumIndex(spr,"cdFactory"), xRow)
     If  getColumIndex(spr,"seLineProd") > -1 then z4080.seLineProd = getDataM(spr, getColumIndex(spr,"seLineProd"), xRow)
     If  getColumIndex(spr,"cdLineProd") > -1 then z4080.cdLineProd = getDataM(spr, getColumIndex(spr,"cdLineProd"), xRow)
     If  getColumIndex(spr,"MachineCode") > -1 then z4080.MachineCode = getDataM(spr, getColumIndex(spr,"MachineCode"), xRow)
     If  getColumIndex(spr,"MachineTno") > -1 then z4080.MachineTno = getDataM(spr, getColumIndex(spr,"MachineTno"), xRow)
     If  getColumIndex(spr,"DateProduction") > -1 then z4080.DateProduction = getDataM(spr, getColumIndex(spr,"DateProduction"), xRow)
     If  getColumIndex(spr,"STimeProduction") > -1 then z4080.STimeProduction = getDataM(spr, getColumIndex(spr,"STimeProduction"), xRow)
     If  getColumIndex(spr,"ETimeProduction") > -1 then z4080.ETimeProduction = getDataM(spr, getColumIndex(spr,"ETimeProduction"), xRow)
     If  getColumIndex(spr,"InchargeProdution") > -1 then z4080.InchargeProdution = getDataM(spr, getColumIndex(spr,"InchargeProdution"), xRow)
     If  getColumIndex(spr,"seMachineType") > -1 then z4080.seMachineType = getDataM(spr, getColumIndex(spr,"seMachineType"), xRow)
     If  getColumIndex(spr,"cdMachineType") > -1 then z4080.cdMachineType = getDataM(spr, getColumIndex(spr,"cdMachineType"), xRow)
     If  getColumIndex(spr,"PartProduction") > -1 then z4080.PartProduction = getDataM(spr, getColumIndex(spr,"PartProduction"), xRow)
     If  getColumIndex(spr,"QtyBatch") > -1 then z4080.QtyBatch = getDataM(spr, getColumIndex(spr,"QtyBatch"), xRow)
     If  getColumIndex(spr,"QtyProduction") > -1 then z4080.QtyProduction = getDataM(spr, getColumIndex(spr,"QtyProduction"), xRow)
     If  getColumIndex(spr,"QtyProductionA") > -1 then z4080.QtyProductionA = getDataM(spr, getColumIndex(spr,"QtyProductionA"), xRow)
     If  getColumIndex(spr,"QtyProductionX") > -1 then z4080.QtyProductionX = getDataM(spr, getColumIndex(spr,"QtyProductionX"), xRow)
     If  getColumIndex(spr,"QtyProductionXP") > -1 then z4080.QtyProductionXP = getDataM(spr, getColumIndex(spr,"QtyProductionXP"), xRow)
     If  getColumIndex(spr,"QtyProductionXR") > -1 then z4080.QtyProductionXR = getDataM(spr, getColumIndex(spr,"QtyProductionXR"), xRow)
     If  getColumIndex(spr,"QtyBLOut") > -1 then z4080.QtyBLOut = getDataM(spr, getColumIndex(spr,"QtyBLOut"), xRow)
     If  getColumIndex(spr,"QtyBLIn") > -1 then z4080.QtyBLIn = getDataM(spr, getColumIndex(spr,"QtyBLIn"), xRow)
     If  getColumIndex(spr,"AmountProduction") > -1 then z4080.AmountProduction = getDataM(spr, getColumIndex(spr,"AmountProduction"), xRow)
     If  getColumIndex(spr,"AmountProductionReceipt") > -1 then z4080.AmountProductionReceipt = getDataM(spr, getColumIndex(spr,"AmountProductionReceipt"), xRow)
     If  getColumIndex(spr,"ISUD") > -1 then z4080.ISUD = getDataM(spr, getColumIndex(spr,"ISUD"), xRow)
     If  getColumIndex(spr,"CheckComplete") > -1 then z4080.CheckComplete = getDataM(spr, getColumIndex(spr,"CheckComplete"), xRow)
     If  getColumIndex(spr,"CheckTrigger") > -1 then z4080.CheckTrigger = getDataM(spr, getColumIndex(spr,"CheckTrigger"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z4080.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K4080_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K4080_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z4080 As T4080_AREA,CheckClear as Boolean,PRODDATE AS String, PRODSEQ AS String) as Boolean

K4080_MOVE = False

Try
    If READ_PFK4080(PRODDATE, PRODSEQ) = True Then
                z4080 = D4080
		K4080_MOVE = True
		else
	If CheckClear  = True then z4080 = nothing
     End If

     If  getColumIndex(spr,"ProdDate") > -1 then z4080.ProdDate = getDataM(spr, getColumIndex(spr,"ProdDate"), xRow)
     If  getColumIndex(spr,"ProdSeq") > -1 then z4080.ProdSeq = getDataM(spr, getColumIndex(spr,"ProdSeq"), xRow)
     If  getColumIndex(spr,"JobCard") > -1 then z4080.JobCard = getDataM(spr, getColumIndex(spr,"JobCard"), xRow)
     If  getColumIndex(spr,"Szno") > -1 then z4080.Szno = getDataM(spr, getColumIndex(spr,"Szno"), xRow)
     If  getColumIndex(spr,"seMainProcess") > -1 then z4080.seMainProcess = getDataM(spr, getColumIndex(spr,"seMainProcess"), xRow)
     If  getColumIndex(spr,"cdMainProcess") > -1 then z4080.cdMainProcess = getDataM(spr, getColumIndex(spr,"cdMainProcess"), xRow)
     If  getColumIndex(spr,"seSubProcess") > -1 then z4080.seSubProcess = getDataM(spr, getColumIndex(spr,"seSubProcess"), xRow)
     If  getColumIndex(spr,"cdSubProcess") > -1 then z4080.cdSubProcess = getDataM(spr, getColumIndex(spr,"cdSubProcess"), xRow)
     If  getColumIndex(spr,"seFactory") > -1 then z4080.seFactory = getDataM(spr, getColumIndex(spr,"seFactory"), xRow)
     If  getColumIndex(spr,"cdFactory") > -1 then z4080.cdFactory = getDataM(spr, getColumIndex(spr,"cdFactory"), xRow)
     If  getColumIndex(spr,"seLineProd") > -1 then z4080.seLineProd = getDataM(spr, getColumIndex(spr,"seLineProd"), xRow)
     If  getColumIndex(spr,"cdLineProd") > -1 then z4080.cdLineProd = getDataM(spr, getColumIndex(spr,"cdLineProd"), xRow)
     If  getColumIndex(spr,"MachineCode") > -1 then z4080.MachineCode = getDataM(spr, getColumIndex(spr,"MachineCode"), xRow)
     If  getColumIndex(spr,"MachineTno") > -1 then z4080.MachineTno = getDataM(spr, getColumIndex(spr,"MachineTno"), xRow)
     If  getColumIndex(spr,"DateProduction") > -1 then z4080.DateProduction = getDataM(spr, getColumIndex(spr,"DateProduction"), xRow)
     If  getColumIndex(spr,"STimeProduction") > -1 then z4080.STimeProduction = getDataM(spr, getColumIndex(spr,"STimeProduction"), xRow)
     If  getColumIndex(spr,"ETimeProduction") > -1 then z4080.ETimeProduction = getDataM(spr, getColumIndex(spr,"ETimeProduction"), xRow)
     If  getColumIndex(spr,"InchargeProdution") > -1 then z4080.InchargeProdution = getDataM(spr, getColumIndex(spr,"InchargeProdution"), xRow)
     If  getColumIndex(spr,"seMachineType") > -1 then z4080.seMachineType = getDataM(spr, getColumIndex(spr,"seMachineType"), xRow)
     If  getColumIndex(spr,"cdMachineType") > -1 then z4080.cdMachineType = getDataM(spr, getColumIndex(spr,"cdMachineType"), xRow)
     If  getColumIndex(spr,"PartProduction") > -1 then z4080.PartProduction = getDataM(spr, getColumIndex(spr,"PartProduction"), xRow)
     If  getColumIndex(spr,"QtyBatch") > -1 then z4080.QtyBatch = getDataM(spr, getColumIndex(spr,"QtyBatch"), xRow)
     If  getColumIndex(spr,"QtyProduction") > -1 then z4080.QtyProduction = getDataM(spr, getColumIndex(spr,"QtyProduction"), xRow)
     If  getColumIndex(spr,"QtyProductionA") > -1 then z4080.QtyProductionA = getDataM(spr, getColumIndex(spr,"QtyProductionA"), xRow)
     If  getColumIndex(spr,"QtyProductionX") > -1 then z4080.QtyProductionX = getDataM(spr, getColumIndex(spr,"QtyProductionX"), xRow)
     If  getColumIndex(spr,"QtyProductionXP") > -1 then z4080.QtyProductionXP = getDataM(spr, getColumIndex(spr,"QtyProductionXP"), xRow)
     If  getColumIndex(spr,"QtyProductionXR") > -1 then z4080.QtyProductionXR = getDataM(spr, getColumIndex(spr,"QtyProductionXR"), xRow)
     If  getColumIndex(spr,"QtyBLOut") > -1 then z4080.QtyBLOut = getDataM(spr, getColumIndex(spr,"QtyBLOut"), xRow)
     If  getColumIndex(spr,"QtyBLIn") > -1 then z4080.QtyBLIn = getDataM(spr, getColumIndex(spr,"QtyBLIn"), xRow)
     If  getColumIndex(spr,"AmountProduction") > -1 then z4080.AmountProduction = getDataM(spr, getColumIndex(spr,"AmountProduction"), xRow)
     If  getColumIndex(spr,"AmountProductionReceipt") > -1 then z4080.AmountProductionReceipt = getDataM(spr, getColumIndex(spr,"AmountProductionReceipt"), xRow)
     If  getColumIndex(spr,"ISUD") > -1 then z4080.ISUD = getDataM(spr, getColumIndex(spr,"ISUD"), xRow)
     If  getColumIndex(spr,"CheckComplete") > -1 then z4080.CheckComplete = getDataM(spr, getColumIndex(spr,"CheckComplete"), xRow)
     If  getColumIndex(spr,"CheckTrigger") > -1 then z4080.CheckTrigger = getDataM(spr, getColumIndex(spr,"CheckTrigger"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z4080.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K4080_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K4080_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z4080 As T4080_AREA, Job as String, PRODDATE AS String, PRODSEQ AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K4080_MOVE = False

Try
    If READ_PFK4080(PRODDATE, PRODSEQ) = True Then
                z4080 = D4080
		K4080_MOVE = True
		else
	z4080 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4080")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "PRODDATE":z4080.ProdDate = Children(i).Code
   Case "PRODSEQ":z4080.ProdSeq = Children(i).Code
   Case "JOBCARD":z4080.JobCard = Children(i).Code
   Case "SZNO":z4080.Szno = Children(i).Code
   Case "SEMAINPROCESS":z4080.seMainProcess = Children(i).Code
   Case "CDMAINPROCESS":z4080.cdMainProcess = Children(i).Code
   Case "SESUBPROCESS":z4080.seSubProcess = Children(i).Code
   Case "CDSUBPROCESS":z4080.cdSubProcess = Children(i).Code
   Case "SEFACTORY":z4080.seFactory = Children(i).Code
   Case "CDFACTORY":z4080.cdFactory = Children(i).Code
   Case "SELINEPROD":z4080.seLineProd = Children(i).Code
   Case "CDLINEPROD":z4080.cdLineProd = Children(i).Code
   Case "MACHINECODE":z4080.MachineCode = Children(i).Code
   Case "MACHINETNO":z4080.MachineTno = Children(i).Code
   Case "DATEPRODUCTION":z4080.DateProduction = Children(i).Code
   Case "STIMEPRODUCTION":z4080.STimeProduction = Children(i).Code
   Case "ETIMEPRODUCTION":z4080.ETimeProduction = Children(i).Code
   Case "INCHARGEPRODUTION":z4080.InchargeProdution = Children(i).Code
   Case "SEMACHINETYPE":z4080.seMachineType = Children(i).Code
   Case "CDMACHINETYPE":z4080.cdMachineType = Children(i).Code
   Case "PARTPRODUCTION":z4080.PartProduction = Children(i).Code
   Case "QTYBATCH":z4080.QtyBatch = Children(i).Code
   Case "QTYPRODUCTION":z4080.QtyProduction = Children(i).Code
   Case "QTYPRODUCTIONA":z4080.QtyProductionA = Children(i).Code
   Case "QTYPRODUCTIONX":z4080.QtyProductionX = Children(i).Code
   Case "QTYPRODUCTIONXP":z4080.QtyProductionXP = Children(i).Code
   Case "QTYPRODUCTIONXR":z4080.QtyProductionXR = Children(i).Code
   Case "QTYBLOUT":z4080.QtyBLOut = Children(i).Code
   Case "QTYBLIN":z4080.QtyBLIn = Children(i).Code
   Case "AMOUNTPRODUCTION":z4080.AmountProduction = Children(i).Code
   Case "AMOUNTPRODUCTIONRECEIPT":z4080.AmountProductionReceipt = Children(i).Code
   Case "ISUD":z4080.ISUD = Children(i).Code
   Case "CHECKCOMPLETE":z4080.CheckComplete = Children(i).Code
   Case "CHECKTRIGGER":z4080.CheckTrigger = Children(i).Code
   Case "REMARK":z4080.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "PRODDATE":z4080.ProdDate = Children(i).Data
   Case "PRODSEQ":z4080.ProdSeq = Children(i).Data
   Case "JOBCARD":z4080.JobCard = Children(i).Data
   Case "SZNO":z4080.Szno = Children(i).Data
   Case "SEMAINPROCESS":z4080.seMainProcess = Children(i).Data
   Case "CDMAINPROCESS":z4080.cdMainProcess = Children(i).Data
   Case "SESUBPROCESS":z4080.seSubProcess = Children(i).Data
   Case "CDSUBPROCESS":z4080.cdSubProcess = Children(i).Data
   Case "SEFACTORY":z4080.seFactory = Children(i).Data
   Case "CDFACTORY":z4080.cdFactory = Children(i).Data
   Case "SELINEPROD":z4080.seLineProd = Children(i).Data
   Case "CDLINEPROD":z4080.cdLineProd = Children(i).Data
   Case "MACHINECODE":z4080.MachineCode = Children(i).Data
   Case "MACHINETNO":z4080.MachineTno = Children(i).Data
   Case "DATEPRODUCTION":z4080.DateProduction = Children(i).Data
   Case "STIMEPRODUCTION":z4080.STimeProduction = Children(i).Data
   Case "ETIMEPRODUCTION":z4080.ETimeProduction = Children(i).Data
   Case "INCHARGEPRODUTION":z4080.InchargeProdution = Children(i).Data
   Case "SEMACHINETYPE":z4080.seMachineType = Children(i).Data
   Case "CDMACHINETYPE":z4080.cdMachineType = Children(i).Data
   Case "PARTPRODUCTION":z4080.PartProduction = Children(i).Data
   Case "QTYBATCH":z4080.QtyBatch = Children(i).Data
   Case "QTYPRODUCTION":z4080.QtyProduction = Children(i).Data
   Case "QTYPRODUCTIONA":z4080.QtyProductionA = Children(i).Data
   Case "QTYPRODUCTIONX":z4080.QtyProductionX = Children(i).Data
   Case "QTYPRODUCTIONXP":z4080.QtyProductionXP = Children(i).Data
   Case "QTYPRODUCTIONXR":z4080.QtyProductionXR = Children(i).Data
   Case "QTYBLOUT":z4080.QtyBLOut = Children(i).Data
   Case "QTYBLIN":z4080.QtyBLIn = Children(i).Data
   Case "AMOUNTPRODUCTION":z4080.AmountProduction = Children(i).Data
   Case "AMOUNTPRODUCTIONRECEIPT":z4080.AmountProductionReceipt = Children(i).Data
   Case "ISUD":z4080.ISUD = Children(i).Data
   Case "CHECKCOMPLETE":z4080.CheckComplete = Children(i).Data
   Case "CHECKTRIGGER":z4080.CheckTrigger = Children(i).Data
   Case "REMARK":z4080.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K4080_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K4080_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z4080 As T4080_AREA, Job as String, CheckClear as Boolean, PRODDATE AS String, PRODSEQ AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K4080_MOVE = False

Try
    If READ_PFK4080(PRODDATE, PRODSEQ) = True Then
                z4080 = D4080
		K4080_MOVE = True
		else
	If CheckClear  = True then z4080 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4080")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "PRODDATE":z4080.ProdDate = Children(i).Code
   Case "PRODSEQ":z4080.ProdSeq = Children(i).Code
   Case "JOBCARD":z4080.JobCard = Children(i).Code
   Case "SZNO":z4080.Szno = Children(i).Code
   Case "SEMAINPROCESS":z4080.seMainProcess = Children(i).Code
   Case "CDMAINPROCESS":z4080.cdMainProcess = Children(i).Code
   Case "SESUBPROCESS":z4080.seSubProcess = Children(i).Code
   Case "CDSUBPROCESS":z4080.cdSubProcess = Children(i).Code
   Case "SEFACTORY":z4080.seFactory = Children(i).Code
   Case "CDFACTORY":z4080.cdFactory = Children(i).Code
   Case "SELINEPROD":z4080.seLineProd = Children(i).Code
   Case "CDLINEPROD":z4080.cdLineProd = Children(i).Code
   Case "MACHINECODE":z4080.MachineCode = Children(i).Code
   Case "MACHINETNO":z4080.MachineTno = Children(i).Code
   Case "DATEPRODUCTION":z4080.DateProduction = Children(i).Code
   Case "STIMEPRODUCTION":z4080.STimeProduction = Children(i).Code
   Case "ETIMEPRODUCTION":z4080.ETimeProduction = Children(i).Code
   Case "INCHARGEPRODUTION":z4080.InchargeProdution = Children(i).Code
   Case "SEMACHINETYPE":z4080.seMachineType = Children(i).Code
   Case "CDMACHINETYPE":z4080.cdMachineType = Children(i).Code
   Case "PARTPRODUCTION":z4080.PartProduction = Children(i).Code
   Case "QTYBATCH":z4080.QtyBatch = Children(i).Code
   Case "QTYPRODUCTION":z4080.QtyProduction = Children(i).Code
   Case "QTYPRODUCTIONA":z4080.QtyProductionA = Children(i).Code
   Case "QTYPRODUCTIONX":z4080.QtyProductionX = Children(i).Code
   Case "QTYPRODUCTIONXP":z4080.QtyProductionXP = Children(i).Code
   Case "QTYPRODUCTIONXR":z4080.QtyProductionXR = Children(i).Code
   Case "QTYBLOUT":z4080.QtyBLOut = Children(i).Code
   Case "QTYBLIN":z4080.QtyBLIn = Children(i).Code
   Case "AMOUNTPRODUCTION":z4080.AmountProduction = Children(i).Code
   Case "AMOUNTPRODUCTIONRECEIPT":z4080.AmountProductionReceipt = Children(i).Code
   Case "ISUD":z4080.ISUD = Children(i).Code
   Case "CHECKCOMPLETE":z4080.CheckComplete = Children(i).Code
   Case "CHECKTRIGGER":z4080.CheckTrigger = Children(i).Code
   Case "REMARK":z4080.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "PRODDATE":z4080.ProdDate = Children(i).Data
   Case "PRODSEQ":z4080.ProdSeq = Children(i).Data
   Case "JOBCARD":z4080.JobCard = Children(i).Data
   Case "SZNO":z4080.Szno = Children(i).Data
   Case "SEMAINPROCESS":z4080.seMainProcess = Children(i).Data
   Case "CDMAINPROCESS":z4080.cdMainProcess = Children(i).Data
   Case "SESUBPROCESS":z4080.seSubProcess = Children(i).Data
   Case "CDSUBPROCESS":z4080.cdSubProcess = Children(i).Data
   Case "SEFACTORY":z4080.seFactory = Children(i).Data
   Case "CDFACTORY":z4080.cdFactory = Children(i).Data
   Case "SELINEPROD":z4080.seLineProd = Children(i).Data
   Case "CDLINEPROD":z4080.cdLineProd = Children(i).Data
   Case "MACHINECODE":z4080.MachineCode = Children(i).Data
   Case "MACHINETNO":z4080.MachineTno = Children(i).Data
   Case "DATEPRODUCTION":z4080.DateProduction = Children(i).Data
   Case "STIMEPRODUCTION":z4080.STimeProduction = Children(i).Data
   Case "ETIMEPRODUCTION":z4080.ETimeProduction = Children(i).Data
   Case "INCHARGEPRODUTION":z4080.InchargeProdution = Children(i).Data
   Case "SEMACHINETYPE":z4080.seMachineType = Children(i).Data
   Case "CDMACHINETYPE":z4080.cdMachineType = Children(i).Data
   Case "PARTPRODUCTION":z4080.PartProduction = Children(i).Data
   Case "QTYBATCH":z4080.QtyBatch = Children(i).Data
   Case "QTYPRODUCTION":z4080.QtyProduction = Children(i).Data
   Case "QTYPRODUCTIONA":z4080.QtyProductionA = Children(i).Data
   Case "QTYPRODUCTIONX":z4080.QtyProductionX = Children(i).Data
   Case "QTYPRODUCTIONXP":z4080.QtyProductionXP = Children(i).Data
   Case "QTYPRODUCTIONXR":z4080.QtyProductionXR = Children(i).Data
   Case "QTYBLOUT":z4080.QtyBLOut = Children(i).Data
   Case "QTYBLIN":z4080.QtyBLIn = Children(i).Data
   Case "AMOUNTPRODUCTION":z4080.AmountProduction = Children(i).Data
   Case "AMOUNTPRODUCTIONRECEIPT":z4080.AmountProductionReceipt = Children(i).Data
   Case "ISUD":z4080.ISUD = Children(i).Data
   Case "CHECKCOMPLETE":z4080.CheckComplete = Children(i).Data
   Case "CHECKTRIGGER":z4080.CheckTrigger = Children(i).Data
   Case "REMARK":z4080.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K4080_MOVE",vbCritical)
End Try
End Function 
    
End Module 
