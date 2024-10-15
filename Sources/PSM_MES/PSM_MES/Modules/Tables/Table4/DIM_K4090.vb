'=========================================================================================================================================================
'   TABLE : (PFK4090)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K4090

Structure T4090_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	ProdDate	 AS String	'			char(8)		*
Public 	ProdSeq	 AS String	'			char(5)		*
Public 	JobCard	 AS String	'			char(9)
Public 	Szno	 AS String	'			char(2)
Public 	Sno	 AS String	'			char(5)
Public 	BatchNo	 AS String	'			char(10)
Public 	seMainProcess	 AS String	'			char(3)
Public 	cdMainProcess	 AS String	'			char(3)
Public 	seSubProcess	 AS String	'			char(3)
Public 	cdSubProcess	 AS String	'			char(3)
Public 	seFactory	 AS String	'			char(3)
Public 	cdFactory	 AS String	'			char(3)
Public 	seLineProd	 AS String	'			char(3)
Public 	cdLineProd	 AS String	'			char(3)
Public 	DateProduction	 AS String	'			char(8)
Public 	STimeProduction	 AS String	'			nvarchar(20)
Public 	ETimeProduction	 AS String	'			nvarchar(20)
Public 	InchargeProdution	 AS String	'			char(8)
Public 	seMachineType	 AS String	'			char(3)
Public 	cdMachineType	 AS String	'			char(3)
Public 	MachineCode	 AS String	'			char(6)
Public 	PartProduction	 AS String	'			char(1)
Public 	QtyProduction	 AS Double	'			decimal
Public 	QtyProductionA	 AS Double	'			decimal
Public 	QtyProductionX	 AS Double	'			decimal
Public 	Remark	 AS String	'			nvarchar(100)
'=========================================================================================================================================================
End structure

Public D4090 As T4090_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK4090(PRODDATE AS String, PRODSEQ AS String) As Boolean
    READ_PFK4090 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK4090 "
    SQL = SQL & " WHERE K4090_ProdDate		 = '" & ProdDate & "' " 
    SQL = SQL & "   AND K4090_ProdSeq		 = '" & ProdSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D4090_CLEAR: GoTo SKIP_READ_PFK4090
                
    Call K4090_MOVE(rd)
    READ_PFK4090 = True

SKIP_READ_PFK4090:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK4090",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK4090(PRODDATE AS String, PRODSEQ AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK4090 "
    SQL = SQL & " WHERE K4090_ProdDate		 = '" & ProdDate & "' " 
    SQL = SQL & "   AND K4090_ProdSeq		 = '" & ProdSeq & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK4090",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK4090(z4090 As T4090_AREA) As Boolean
    WRITE_PFK4090 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z4090)
 
    SQL = " INSERT INTO PFK4090 "
    SQL = SQL & " ( "
    SQL = SQL & " K4090_ProdDate," 
    SQL = SQL & " K4090_ProdSeq," 
    SQL = SQL & " K4090_JobCard," 
    SQL = SQL & " K4090_Szno," 
    SQL = SQL & " K4090_Sno," 
    SQL = SQL & " K4090_BatchNo," 
    SQL = SQL & " K4090_seMainProcess," 
    SQL = SQL & " K4090_cdMainProcess," 
    SQL = SQL & " K4090_seSubProcess," 
    SQL = SQL & " K4090_cdSubProcess," 
    SQL = SQL & " K4090_seFactory," 
    SQL = SQL & " K4090_cdFactory," 
    SQL = SQL & " K4090_seLineProd," 
    SQL = SQL & " K4090_cdLineProd," 
    SQL = SQL & " K4090_DateProduction," 
    SQL = SQL & " K4090_STimeProduction," 
    SQL = SQL & " K4090_ETimeProduction," 
    SQL = SQL & " K4090_InchargeProdution," 
    SQL = SQL & " K4090_seMachineType," 
    SQL = SQL & " K4090_cdMachineType," 
    SQL = SQL & " K4090_MachineCode," 
    SQL = SQL & " K4090_PartProduction," 
    SQL = SQL & " K4090_QtyProduction," 
    SQL = SQL & " K4090_QtyProductionA," 
    SQL = SQL & " K4090_QtyProductionX," 
    SQL = SQL & " K4090_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z4090.ProdDate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4090.ProdSeq) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4090.JobCard) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4090.Szno) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4090.Sno) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4090.BatchNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4090.seMainProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4090.cdMainProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4090.seSubProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4090.cdSubProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4090.seFactory) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4090.cdFactory) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4090.seLineProd) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4090.cdLineProd) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4090.DateProduction) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4090.STimeProduction) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4090.ETimeProduction) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4090.InchargeProdution) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4090.seMachineType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4090.cdMachineType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4090.MachineCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4090.PartProduction) & "', "  
    SQL = SQL & "   " & FormatSQL(z4090.QtyProduction) & ", "  
    SQL = SQL & "   " & FormatSQL(z4090.QtyProductionA) & ", "  
    SQL = SQL & "   " & FormatSQL(z4090.QtyProductionX) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z4090.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK4090 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK4090",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK4090(z4090 As T4090_AREA) As Boolean
    REWRITE_PFK4090 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z4090)
   
    SQL = " UPDATE PFK4090 SET "
    SQL = SQL & "    K4090_JobCard      = N'" & FormatSQL(z4090.JobCard) & "', " 
    SQL = SQL & "    K4090_Szno      = N'" & FormatSQL(z4090.Szno) & "', " 
    SQL = SQL & "    K4090_Sno      = N'" & FormatSQL(z4090.Sno) & "', " 
    SQL = SQL & "    K4090_BatchNo      = N'" & FormatSQL(z4090.BatchNo) & "', " 
    SQL = SQL & "    K4090_seMainProcess      = N'" & FormatSQL(z4090.seMainProcess) & "', " 
    SQL = SQL & "    K4090_cdMainProcess      = N'" & FormatSQL(z4090.cdMainProcess) & "', " 
    SQL = SQL & "    K4090_seSubProcess      = N'" & FormatSQL(z4090.seSubProcess) & "', " 
    SQL = SQL & "    K4090_cdSubProcess      = N'" & FormatSQL(z4090.cdSubProcess) & "', " 
    SQL = SQL & "    K4090_seFactory      = N'" & FormatSQL(z4090.seFactory) & "', " 
    SQL = SQL & "    K4090_cdFactory      = N'" & FormatSQL(z4090.cdFactory) & "', " 
    SQL = SQL & "    K4090_seLineProd      = N'" & FormatSQL(z4090.seLineProd) & "', " 
    SQL = SQL & "    K4090_cdLineProd      = N'" & FormatSQL(z4090.cdLineProd) & "', " 
    SQL = SQL & "    K4090_DateProduction      = N'" & FormatSQL(z4090.DateProduction) & "', " 
    SQL = SQL & "    K4090_STimeProduction      = N'" & FormatSQL(z4090.STimeProduction) & "', " 
    SQL = SQL & "    K4090_ETimeProduction      = N'" & FormatSQL(z4090.ETimeProduction) & "', " 
    SQL = SQL & "    K4090_InchargeProdution      = N'" & FormatSQL(z4090.InchargeProdution) & "', " 
    SQL = SQL & "    K4090_seMachineType      = N'" & FormatSQL(z4090.seMachineType) & "', " 
    SQL = SQL & "    K4090_cdMachineType      = N'" & FormatSQL(z4090.cdMachineType) & "', " 
    SQL = SQL & "    K4090_MachineCode      = N'" & FormatSQL(z4090.MachineCode) & "', " 
    SQL = SQL & "    K4090_PartProduction      = N'" & FormatSQL(z4090.PartProduction) & "', " 
    SQL = SQL & "    K4090_QtyProduction      =  " & FormatSQL(z4090.QtyProduction) & ", " 
    SQL = SQL & "    K4090_QtyProductionA      =  " & FormatSQL(z4090.QtyProductionA) & ", " 
    SQL = SQL & "    K4090_QtyProductionX      =  " & FormatSQL(z4090.QtyProductionX) & ", " 
    SQL = SQL & "    K4090_Remark      = N'" & FormatSQL(z4090.Remark) & "'  " 
    SQL = SQL & " WHERE K4090_ProdDate		 = '" & z4090.ProdDate & "' " 
    SQL = SQL & "   AND K4090_ProdSeq		 = '" & z4090.ProdSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK4090 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK4090",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK4090(z4090 As T4090_AREA) As Boolean
    DELETE_PFK4090 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK4090 "
    SQL = SQL & " WHERE K4090_ProdDate		 = '" & z4090.ProdDate & "' " 
    SQL = SQL & "   AND K4090_ProdSeq		 = '" & z4090.ProdSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK4090 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK4090",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D4090_CLEAR()
Try
    
   D4090.ProdDate = ""
   D4090.ProdSeq = ""
   D4090.JobCard = ""
   D4090.Szno = ""
   D4090.Sno = ""
   D4090.BatchNo = ""
   D4090.seMainProcess = ""
   D4090.cdMainProcess = ""
   D4090.seSubProcess = ""
   D4090.cdSubProcess = ""
   D4090.seFactory = ""
   D4090.cdFactory = ""
   D4090.seLineProd = ""
   D4090.cdLineProd = ""
   D4090.DateProduction = ""
   D4090.STimeProduction = ""
   D4090.ETimeProduction = ""
   D4090.InchargeProdution = ""
   D4090.seMachineType = ""
   D4090.cdMachineType = ""
   D4090.MachineCode = ""
   D4090.PartProduction = ""
    D4090.QtyProduction = 0 
    D4090.QtyProductionA = 0 
    D4090.QtyProductionX = 0 
   D4090.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D4090_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x4090 As T4090_AREA)
Try
    
    x4090.ProdDate = trim$(  x4090.ProdDate)
    x4090.ProdSeq = trim$(  x4090.ProdSeq)
    x4090.JobCard = trim$(  x4090.JobCard)
    x4090.Szno = trim$(  x4090.Szno)
    x4090.Sno = trim$(  x4090.Sno)
    x4090.BatchNo = trim$(  x4090.BatchNo)
    x4090.seMainProcess = trim$(  x4090.seMainProcess)
    x4090.cdMainProcess = trim$(  x4090.cdMainProcess)
    x4090.seSubProcess = trim$(  x4090.seSubProcess)
    x4090.cdSubProcess = trim$(  x4090.cdSubProcess)
    x4090.seFactory = trim$(  x4090.seFactory)
    x4090.cdFactory = trim$(  x4090.cdFactory)
    x4090.seLineProd = trim$(  x4090.seLineProd)
    x4090.cdLineProd = trim$(  x4090.cdLineProd)
    x4090.DateProduction = trim$(  x4090.DateProduction)
    x4090.STimeProduction = trim$(  x4090.STimeProduction)
    x4090.ETimeProduction = trim$(  x4090.ETimeProduction)
    x4090.InchargeProdution = trim$(  x4090.InchargeProdution)
    x4090.seMachineType = trim$(  x4090.seMachineType)
    x4090.cdMachineType = trim$(  x4090.cdMachineType)
    x4090.MachineCode = trim$(  x4090.MachineCode)
    x4090.PartProduction = trim$(  x4090.PartProduction)
    x4090.QtyProduction = trim$(  x4090.QtyProduction)
    x4090.QtyProductionA = trim$(  x4090.QtyProductionA)
    x4090.QtyProductionX = trim$(  x4090.QtyProductionX)
    x4090.Remark = trim$(  x4090.Remark)
     
    If trim$( x4090.ProdDate ) = "" Then x4090.ProdDate = Space(1) 
    If trim$( x4090.ProdSeq ) = "" Then x4090.ProdSeq = Space(1) 
    If trim$( x4090.JobCard ) = "" Then x4090.JobCard = Space(1) 
    If trim$( x4090.Szno ) = "" Then x4090.Szno = Space(1) 
    If trim$( x4090.Sno ) = "" Then x4090.Sno = Space(1) 
    If trim$( x4090.BatchNo ) = "" Then x4090.BatchNo = Space(1) 
    If trim$( x4090.seMainProcess ) = "" Then x4090.seMainProcess = Space(1) 
    If trim$( x4090.cdMainProcess ) = "" Then x4090.cdMainProcess = Space(1) 
    If trim$( x4090.seSubProcess ) = "" Then x4090.seSubProcess = Space(1) 
    If trim$( x4090.cdSubProcess ) = "" Then x4090.cdSubProcess = Space(1) 
    If trim$( x4090.seFactory ) = "" Then x4090.seFactory = Space(1) 
    If trim$( x4090.cdFactory ) = "" Then x4090.cdFactory = Space(1) 
    If trim$( x4090.seLineProd ) = "" Then x4090.seLineProd = Space(1) 
    If trim$( x4090.cdLineProd ) = "" Then x4090.cdLineProd = Space(1) 
    If trim$( x4090.DateProduction ) = "" Then x4090.DateProduction = Space(1) 
    If trim$( x4090.STimeProduction ) = "" Then x4090.STimeProduction = Space(1) 
    If trim$( x4090.ETimeProduction ) = "" Then x4090.ETimeProduction = Space(1) 
    If trim$( x4090.InchargeProdution ) = "" Then x4090.InchargeProdution = Space(1) 
    If trim$( x4090.seMachineType ) = "" Then x4090.seMachineType = Space(1) 
    If trim$( x4090.cdMachineType ) = "" Then x4090.cdMachineType = Space(1) 
    If trim$( x4090.MachineCode ) = "" Then x4090.MachineCode = Space(1) 
    If trim$( x4090.PartProduction ) = "" Then x4090.PartProduction = Space(1) 
    If trim$( x4090.QtyProduction ) = "" Then x4090.QtyProduction = 0 
    If trim$( x4090.QtyProductionA ) = "" Then x4090.QtyProductionA = 0 
    If trim$( x4090.QtyProductionX ) = "" Then x4090.QtyProductionX = 0 
    If trim$( x4090.Remark ) = "" Then x4090.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K4090_MOVE(rs4090 As SqlClient.SqlDataReader)
Try

    call D4090_CLEAR()   

    If IsdbNull(rs4090!K4090_ProdDate) = False Then D4090.ProdDate = Trim$(rs4090!K4090_ProdDate)
    If IsdbNull(rs4090!K4090_ProdSeq) = False Then D4090.ProdSeq = Trim$(rs4090!K4090_ProdSeq)
    If IsdbNull(rs4090!K4090_JobCard) = False Then D4090.JobCard = Trim$(rs4090!K4090_JobCard)
    If IsdbNull(rs4090!K4090_Szno) = False Then D4090.Szno = Trim$(rs4090!K4090_Szno)
    If IsdbNull(rs4090!K4090_Sno) = False Then D4090.Sno = Trim$(rs4090!K4090_Sno)
    If IsdbNull(rs4090!K4090_BatchNo) = False Then D4090.BatchNo = Trim$(rs4090!K4090_BatchNo)
    If IsdbNull(rs4090!K4090_seMainProcess) = False Then D4090.seMainProcess = Trim$(rs4090!K4090_seMainProcess)
    If IsdbNull(rs4090!K4090_cdMainProcess) = False Then D4090.cdMainProcess = Trim$(rs4090!K4090_cdMainProcess)
    If IsdbNull(rs4090!K4090_seSubProcess) = False Then D4090.seSubProcess = Trim$(rs4090!K4090_seSubProcess)
    If IsdbNull(rs4090!K4090_cdSubProcess) = False Then D4090.cdSubProcess = Trim$(rs4090!K4090_cdSubProcess)
    If IsdbNull(rs4090!K4090_seFactory) = False Then D4090.seFactory = Trim$(rs4090!K4090_seFactory)
    If IsdbNull(rs4090!K4090_cdFactory) = False Then D4090.cdFactory = Trim$(rs4090!K4090_cdFactory)
    If IsdbNull(rs4090!K4090_seLineProd) = False Then D4090.seLineProd = Trim$(rs4090!K4090_seLineProd)
    If IsdbNull(rs4090!K4090_cdLineProd) = False Then D4090.cdLineProd = Trim$(rs4090!K4090_cdLineProd)
    If IsdbNull(rs4090!K4090_DateProduction) = False Then D4090.DateProduction = Trim$(rs4090!K4090_DateProduction)
    If IsdbNull(rs4090!K4090_STimeProduction) = False Then D4090.STimeProduction = Trim$(rs4090!K4090_STimeProduction)
    If IsdbNull(rs4090!K4090_ETimeProduction) = False Then D4090.ETimeProduction = Trim$(rs4090!K4090_ETimeProduction)
    If IsdbNull(rs4090!K4090_InchargeProdution) = False Then D4090.InchargeProdution = Trim$(rs4090!K4090_InchargeProdution)
    If IsdbNull(rs4090!K4090_seMachineType) = False Then D4090.seMachineType = Trim$(rs4090!K4090_seMachineType)
    If IsdbNull(rs4090!K4090_cdMachineType) = False Then D4090.cdMachineType = Trim$(rs4090!K4090_cdMachineType)
    If IsdbNull(rs4090!K4090_MachineCode) = False Then D4090.MachineCode = Trim$(rs4090!K4090_MachineCode)
    If IsdbNull(rs4090!K4090_PartProduction) = False Then D4090.PartProduction = Trim$(rs4090!K4090_PartProduction)
    If IsdbNull(rs4090!K4090_QtyProduction) = False Then D4090.QtyProduction = Trim$(rs4090!K4090_QtyProduction)
    If IsdbNull(rs4090!K4090_QtyProductionA) = False Then D4090.QtyProductionA = Trim$(rs4090!K4090_QtyProductionA)
    If IsdbNull(rs4090!K4090_QtyProductionX) = False Then D4090.QtyProductionX = Trim$(rs4090!K4090_QtyProductionX)
    If IsdbNull(rs4090!K4090_Remark) = False Then D4090.Remark = Trim$(rs4090!K4090_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K4090_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K4090_MOVE(rs4090 As DataRow)
Try

    call D4090_CLEAR()   

    If IsdbNull(rs4090!K4090_ProdDate) = False Then D4090.ProdDate = Trim$(rs4090!K4090_ProdDate)
    If IsdbNull(rs4090!K4090_ProdSeq) = False Then D4090.ProdSeq = Trim$(rs4090!K4090_ProdSeq)
    If IsdbNull(rs4090!K4090_JobCard) = False Then D4090.JobCard = Trim$(rs4090!K4090_JobCard)
    If IsdbNull(rs4090!K4090_Szno) = False Then D4090.Szno = Trim$(rs4090!K4090_Szno)
    If IsdbNull(rs4090!K4090_Sno) = False Then D4090.Sno = Trim$(rs4090!K4090_Sno)
    If IsdbNull(rs4090!K4090_BatchNo) = False Then D4090.BatchNo = Trim$(rs4090!K4090_BatchNo)
    If IsdbNull(rs4090!K4090_seMainProcess) = False Then D4090.seMainProcess = Trim$(rs4090!K4090_seMainProcess)
    If IsdbNull(rs4090!K4090_cdMainProcess) = False Then D4090.cdMainProcess = Trim$(rs4090!K4090_cdMainProcess)
    If IsdbNull(rs4090!K4090_seSubProcess) = False Then D4090.seSubProcess = Trim$(rs4090!K4090_seSubProcess)
    If IsdbNull(rs4090!K4090_cdSubProcess) = False Then D4090.cdSubProcess = Trim$(rs4090!K4090_cdSubProcess)
    If IsdbNull(rs4090!K4090_seFactory) = False Then D4090.seFactory = Trim$(rs4090!K4090_seFactory)
    If IsdbNull(rs4090!K4090_cdFactory) = False Then D4090.cdFactory = Trim$(rs4090!K4090_cdFactory)
    If IsdbNull(rs4090!K4090_seLineProd) = False Then D4090.seLineProd = Trim$(rs4090!K4090_seLineProd)
    If IsdbNull(rs4090!K4090_cdLineProd) = False Then D4090.cdLineProd = Trim$(rs4090!K4090_cdLineProd)
    If IsdbNull(rs4090!K4090_DateProduction) = False Then D4090.DateProduction = Trim$(rs4090!K4090_DateProduction)
    If IsdbNull(rs4090!K4090_STimeProduction) = False Then D4090.STimeProduction = Trim$(rs4090!K4090_STimeProduction)
    If IsdbNull(rs4090!K4090_ETimeProduction) = False Then D4090.ETimeProduction = Trim$(rs4090!K4090_ETimeProduction)
    If IsdbNull(rs4090!K4090_InchargeProdution) = False Then D4090.InchargeProdution = Trim$(rs4090!K4090_InchargeProdution)
    If IsdbNull(rs4090!K4090_seMachineType) = False Then D4090.seMachineType = Trim$(rs4090!K4090_seMachineType)
    If IsdbNull(rs4090!K4090_cdMachineType) = False Then D4090.cdMachineType = Trim$(rs4090!K4090_cdMachineType)
    If IsdbNull(rs4090!K4090_MachineCode) = False Then D4090.MachineCode = Trim$(rs4090!K4090_MachineCode)
    If IsdbNull(rs4090!K4090_PartProduction) = False Then D4090.PartProduction = Trim$(rs4090!K4090_PartProduction)
    If IsdbNull(rs4090!K4090_QtyProduction) = False Then D4090.QtyProduction = Trim$(rs4090!K4090_QtyProduction)
    If IsdbNull(rs4090!K4090_QtyProductionA) = False Then D4090.QtyProductionA = Trim$(rs4090!K4090_QtyProductionA)
    If IsdbNull(rs4090!K4090_QtyProductionX) = False Then D4090.QtyProductionX = Trim$(rs4090!K4090_QtyProductionX)
    If IsdbNull(rs4090!K4090_Remark) = False Then D4090.Remark = Trim$(rs4090!K4090_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K4090_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K4090_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z4090 As T4090_AREA, PRODDATE AS String, PRODSEQ AS String) as Boolean

K4090_MOVE = False

Try
    If READ_PFK4090(PRODDATE, PRODSEQ) = True Then
                z4090 = D4090
		K4090_MOVE = True
		else
	z4090 = nothing
     End If

     If  getColumIndex(spr,"ProdDate") > -1 then z4090.ProdDate = getDataM(spr, getColumIndex(spr,"ProdDate"), xRow)
     If  getColumIndex(spr,"ProdSeq") > -1 then z4090.ProdSeq = getDataM(spr, getColumIndex(spr,"ProdSeq"), xRow)
     If  getColumIndex(spr,"JobCard") > -1 then z4090.JobCard = getDataM(spr, getColumIndex(spr,"JobCard"), xRow)
     If  getColumIndex(spr,"Szno") > -1 then z4090.Szno = getDataM(spr, getColumIndex(spr,"Szno"), xRow)
     If  getColumIndex(spr,"Sno") > -1 then z4090.Sno = getDataM(spr, getColumIndex(spr,"Sno"), xRow)
     If  getColumIndex(spr,"BatchNo") > -1 then z4090.BatchNo = getDataM(spr, getColumIndex(spr,"BatchNo"), xRow)
     If  getColumIndex(spr,"seMainProcess") > -1 then z4090.seMainProcess = getDataM(spr, getColumIndex(spr,"seMainProcess"), xRow)
     If  getColumIndex(spr,"cdMainProcess") > -1 then z4090.cdMainProcess = getDataM(spr, getColumIndex(spr,"cdMainProcess"), xRow)
     If  getColumIndex(spr,"seSubProcess") > -1 then z4090.seSubProcess = getDataM(spr, getColumIndex(spr,"seSubProcess"), xRow)
     If  getColumIndex(spr,"cdSubProcess") > -1 then z4090.cdSubProcess = getDataM(spr, getColumIndex(spr,"cdSubProcess"), xRow)
     If  getColumIndex(spr,"seFactory") > -1 then z4090.seFactory = getDataM(spr, getColumIndex(spr,"seFactory"), xRow)
     If  getColumIndex(spr,"cdFactory") > -1 then z4090.cdFactory = getDataM(spr, getColumIndex(spr,"cdFactory"), xRow)
     If  getColumIndex(spr,"seLineProd") > -1 then z4090.seLineProd = getDataM(spr, getColumIndex(spr,"seLineProd"), xRow)
     If  getColumIndex(spr,"cdLineProd") > -1 then z4090.cdLineProd = getDataM(spr, getColumIndex(spr,"cdLineProd"), xRow)
     If  getColumIndex(spr,"DateProduction") > -1 then z4090.DateProduction = getDataM(spr, getColumIndex(spr,"DateProduction"), xRow)
     If  getColumIndex(spr,"STimeProduction") > -1 then z4090.STimeProduction = getDataM(spr, getColumIndex(spr,"STimeProduction"), xRow)
     If  getColumIndex(spr,"ETimeProduction") > -1 then z4090.ETimeProduction = getDataM(spr, getColumIndex(spr,"ETimeProduction"), xRow)
     If  getColumIndex(spr,"InchargeProdution") > -1 then z4090.InchargeProdution = getDataM(spr, getColumIndex(spr,"InchargeProdution"), xRow)
     If  getColumIndex(spr,"seMachineType") > -1 then z4090.seMachineType = getDataM(spr, getColumIndex(spr,"seMachineType"), xRow)
     If  getColumIndex(spr,"cdMachineType") > -1 then z4090.cdMachineType = getDataM(spr, getColumIndex(spr,"cdMachineType"), xRow)
     If  getColumIndex(spr,"MachineCode") > -1 then z4090.MachineCode = getDataM(spr, getColumIndex(spr,"MachineCode"), xRow)
     If  getColumIndex(spr,"PartProduction") > -1 then z4090.PartProduction = getDataM(spr, getColumIndex(spr,"PartProduction"), xRow)
     If  getColumIndex(spr,"QtyProduction") > -1 then z4090.QtyProduction = getDataM(spr, getColumIndex(spr,"QtyProduction"), xRow)
     If  getColumIndex(spr,"QtyProductionA") > -1 then z4090.QtyProductionA = getDataM(spr, getColumIndex(spr,"QtyProductionA"), xRow)
     If  getColumIndex(spr,"QtyProductionX") > -1 then z4090.QtyProductionX = getDataM(spr, getColumIndex(spr,"QtyProductionX"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z4090.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K4090_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K4090_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z4090 As T4090_AREA,CheckClear as Boolean,PRODDATE AS String, PRODSEQ AS String) as Boolean

K4090_MOVE = False

Try
    If READ_PFK4090(PRODDATE, PRODSEQ) = True Then
                z4090 = D4090
		K4090_MOVE = True
		else
	If CheckClear  = True then z4090 = nothing
     End If

     If  getColumIndex(spr,"ProdDate") > -1 then z4090.ProdDate = getDataM(spr, getColumIndex(spr,"ProdDate"), xRow)
     If  getColumIndex(spr,"ProdSeq") > -1 then z4090.ProdSeq = getDataM(spr, getColumIndex(spr,"ProdSeq"), xRow)
     If  getColumIndex(spr,"JobCard") > -1 then z4090.JobCard = getDataM(spr, getColumIndex(spr,"JobCard"), xRow)
     If  getColumIndex(spr,"Szno") > -1 then z4090.Szno = getDataM(spr, getColumIndex(spr,"Szno"), xRow)
     If  getColumIndex(spr,"Sno") > -1 then z4090.Sno = getDataM(spr, getColumIndex(spr,"Sno"), xRow)
     If  getColumIndex(spr,"BatchNo") > -1 then z4090.BatchNo = getDataM(spr, getColumIndex(spr,"BatchNo"), xRow)
     If  getColumIndex(spr,"seMainProcess") > -1 then z4090.seMainProcess = getDataM(spr, getColumIndex(spr,"seMainProcess"), xRow)
     If  getColumIndex(spr,"cdMainProcess") > -1 then z4090.cdMainProcess = getDataM(spr, getColumIndex(spr,"cdMainProcess"), xRow)
     If  getColumIndex(spr,"seSubProcess") > -1 then z4090.seSubProcess = getDataM(spr, getColumIndex(spr,"seSubProcess"), xRow)
     If  getColumIndex(spr,"cdSubProcess") > -1 then z4090.cdSubProcess = getDataM(spr, getColumIndex(spr,"cdSubProcess"), xRow)
     If  getColumIndex(spr,"seFactory") > -1 then z4090.seFactory = getDataM(spr, getColumIndex(spr,"seFactory"), xRow)
     If  getColumIndex(spr,"cdFactory") > -1 then z4090.cdFactory = getDataM(spr, getColumIndex(spr,"cdFactory"), xRow)
     If  getColumIndex(spr,"seLineProd") > -1 then z4090.seLineProd = getDataM(spr, getColumIndex(spr,"seLineProd"), xRow)
     If  getColumIndex(spr,"cdLineProd") > -1 then z4090.cdLineProd = getDataM(spr, getColumIndex(spr,"cdLineProd"), xRow)
     If  getColumIndex(spr,"DateProduction") > -1 then z4090.DateProduction = getDataM(spr, getColumIndex(spr,"DateProduction"), xRow)
     If  getColumIndex(spr,"STimeProduction") > -1 then z4090.STimeProduction = getDataM(spr, getColumIndex(spr,"STimeProduction"), xRow)
     If  getColumIndex(spr,"ETimeProduction") > -1 then z4090.ETimeProduction = getDataM(spr, getColumIndex(spr,"ETimeProduction"), xRow)
     If  getColumIndex(spr,"InchargeProdution") > -1 then z4090.InchargeProdution = getDataM(spr, getColumIndex(spr,"InchargeProdution"), xRow)
     If  getColumIndex(spr,"seMachineType") > -1 then z4090.seMachineType = getDataM(spr, getColumIndex(spr,"seMachineType"), xRow)
     If  getColumIndex(spr,"cdMachineType") > -1 then z4090.cdMachineType = getDataM(spr, getColumIndex(spr,"cdMachineType"), xRow)
     If  getColumIndex(spr,"MachineCode") > -1 then z4090.MachineCode = getDataM(spr, getColumIndex(spr,"MachineCode"), xRow)
     If  getColumIndex(spr,"PartProduction") > -1 then z4090.PartProduction = getDataM(spr, getColumIndex(spr,"PartProduction"), xRow)
     If  getColumIndex(spr,"QtyProduction") > -1 then z4090.QtyProduction = getDataM(spr, getColumIndex(spr,"QtyProduction"), xRow)
     If  getColumIndex(spr,"QtyProductionA") > -1 then z4090.QtyProductionA = getDataM(spr, getColumIndex(spr,"QtyProductionA"), xRow)
     If  getColumIndex(spr,"QtyProductionX") > -1 then z4090.QtyProductionX = getDataM(spr, getColumIndex(spr,"QtyProductionX"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z4090.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K4090_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K4090_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z4090 As T4090_AREA, Job as String, PRODDATE AS String, PRODSEQ AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K4090_MOVE = False

Try
    If READ_PFK4090(PRODDATE, PRODSEQ) = True Then
                z4090 = D4090
		K4090_MOVE = True
		else
	z4090 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4090")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "PRODDATE":z4090.ProdDate = Children(i).Code
   Case "PRODSEQ":z4090.ProdSeq = Children(i).Code
   Case "JOBCARD":z4090.JobCard = Children(i).Code
   Case "SZNO":z4090.Szno = Children(i).Code
   Case "SNO":z4090.Sno = Children(i).Code
   Case "BATCHNO":z4090.BatchNo = Children(i).Code
   Case "SEMAINPROCESS":z4090.seMainProcess = Children(i).Code
   Case "CDMAINPROCESS":z4090.cdMainProcess = Children(i).Code
   Case "SESUBPROCESS":z4090.seSubProcess = Children(i).Code
   Case "CDSUBPROCESS":z4090.cdSubProcess = Children(i).Code
   Case "SEFACTORY":z4090.seFactory = Children(i).Code
   Case "CDFACTORY":z4090.cdFactory = Children(i).Code
   Case "SELINEPROD":z4090.seLineProd = Children(i).Code
   Case "CDLINEPROD":z4090.cdLineProd = Children(i).Code
   Case "DATEPRODUCTION":z4090.DateProduction = Children(i).Code
   Case "STIMEPRODUCTION":z4090.STimeProduction = Children(i).Code
   Case "ETIMEPRODUCTION":z4090.ETimeProduction = Children(i).Code
   Case "INCHARGEPRODUTION":z4090.InchargeProdution = Children(i).Code
   Case "SEMACHINETYPE":z4090.seMachineType = Children(i).Code
   Case "CDMACHINETYPE":z4090.cdMachineType = Children(i).Code
   Case "MACHINECODE":z4090.MachineCode = Children(i).Code
   Case "PARTPRODUCTION":z4090.PartProduction = Children(i).Code
   Case "QTYPRODUCTION":z4090.QtyProduction = Children(i).Code
   Case "QTYPRODUCTIONA":z4090.QtyProductionA = Children(i).Code
   Case "QTYPRODUCTIONX":z4090.QtyProductionX = Children(i).Code
   Case "REMARK":z4090.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "PRODDATE":z4090.ProdDate = Children(i).Data
   Case "PRODSEQ":z4090.ProdSeq = Children(i).Data
   Case "JOBCARD":z4090.JobCard = Children(i).Data
   Case "SZNO":z4090.Szno = Children(i).Data
   Case "SNO":z4090.Sno = Children(i).Data
   Case "BATCHNO":z4090.BatchNo = Children(i).Data
   Case "SEMAINPROCESS":z4090.seMainProcess = Children(i).Data
   Case "CDMAINPROCESS":z4090.cdMainProcess = Children(i).Data
   Case "SESUBPROCESS":z4090.seSubProcess = Children(i).Data
   Case "CDSUBPROCESS":z4090.cdSubProcess = Children(i).Data
   Case "SEFACTORY":z4090.seFactory = Children(i).Data
   Case "CDFACTORY":z4090.cdFactory = Children(i).Data
   Case "SELINEPROD":z4090.seLineProd = Children(i).Data
   Case "CDLINEPROD":z4090.cdLineProd = Children(i).Data
   Case "DATEPRODUCTION":z4090.DateProduction = Children(i).Data
   Case "STIMEPRODUCTION":z4090.STimeProduction = Children(i).Data
   Case "ETIMEPRODUCTION":z4090.ETimeProduction = Children(i).Data
   Case "INCHARGEPRODUTION":z4090.InchargeProdution = Children(i).Data
   Case "SEMACHINETYPE":z4090.seMachineType = Children(i).Data
   Case "CDMACHINETYPE":z4090.cdMachineType = Children(i).Data
   Case "MACHINECODE":z4090.MachineCode = Children(i).Data
   Case "PARTPRODUCTION":z4090.PartProduction = Children(i).Data
   Case "QTYPRODUCTION":z4090.QtyProduction = Children(i).Data
   Case "QTYPRODUCTIONA":z4090.QtyProductionA = Children(i).Data
   Case "QTYPRODUCTIONX":z4090.QtyProductionX = Children(i).Data
   Case "REMARK":z4090.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K4090_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K4090_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z4090 As T4090_AREA, Job as String, CheckClear as Boolean, PRODDATE AS String, PRODSEQ AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K4090_MOVE = False

Try
    If READ_PFK4090(PRODDATE, PRODSEQ) = True Then
                z4090 = D4090
		K4090_MOVE = True
		else
	If CheckClear  = True then z4090 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4090")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "PRODDATE":z4090.ProdDate = Children(i).Code
   Case "PRODSEQ":z4090.ProdSeq = Children(i).Code
   Case "JOBCARD":z4090.JobCard = Children(i).Code
   Case "SZNO":z4090.Szno = Children(i).Code
   Case "SNO":z4090.Sno = Children(i).Code
   Case "BATCHNO":z4090.BatchNo = Children(i).Code
   Case "SEMAINPROCESS":z4090.seMainProcess = Children(i).Code
   Case "CDMAINPROCESS":z4090.cdMainProcess = Children(i).Code
   Case "SESUBPROCESS":z4090.seSubProcess = Children(i).Code
   Case "CDSUBPROCESS":z4090.cdSubProcess = Children(i).Code
   Case "SEFACTORY":z4090.seFactory = Children(i).Code
   Case "CDFACTORY":z4090.cdFactory = Children(i).Code
   Case "SELINEPROD":z4090.seLineProd = Children(i).Code
   Case "CDLINEPROD":z4090.cdLineProd = Children(i).Code
   Case "DATEPRODUCTION":z4090.DateProduction = Children(i).Code
   Case "STIMEPRODUCTION":z4090.STimeProduction = Children(i).Code
   Case "ETIMEPRODUCTION":z4090.ETimeProduction = Children(i).Code
   Case "INCHARGEPRODUTION":z4090.InchargeProdution = Children(i).Code
   Case "SEMACHINETYPE":z4090.seMachineType = Children(i).Code
   Case "CDMACHINETYPE":z4090.cdMachineType = Children(i).Code
   Case "MACHINECODE":z4090.MachineCode = Children(i).Code
   Case "PARTPRODUCTION":z4090.PartProduction = Children(i).Code
   Case "QTYPRODUCTION":z4090.QtyProduction = Children(i).Code
   Case "QTYPRODUCTIONA":z4090.QtyProductionA = Children(i).Code
   Case "QTYPRODUCTIONX":z4090.QtyProductionX = Children(i).Code
   Case "REMARK":z4090.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "PRODDATE":z4090.ProdDate = Children(i).Data
   Case "PRODSEQ":z4090.ProdSeq = Children(i).Data
   Case "JOBCARD":z4090.JobCard = Children(i).Data
   Case "SZNO":z4090.Szno = Children(i).Data
   Case "SNO":z4090.Sno = Children(i).Data
   Case "BATCHNO":z4090.BatchNo = Children(i).Data
   Case "SEMAINPROCESS":z4090.seMainProcess = Children(i).Data
   Case "CDMAINPROCESS":z4090.cdMainProcess = Children(i).Data
   Case "SESUBPROCESS":z4090.seSubProcess = Children(i).Data
   Case "CDSUBPROCESS":z4090.cdSubProcess = Children(i).Data
   Case "SEFACTORY":z4090.seFactory = Children(i).Data
   Case "CDFACTORY":z4090.cdFactory = Children(i).Data
   Case "SELINEPROD":z4090.seLineProd = Children(i).Data
   Case "CDLINEPROD":z4090.cdLineProd = Children(i).Data
   Case "DATEPRODUCTION":z4090.DateProduction = Children(i).Data
   Case "STIMEPRODUCTION":z4090.STimeProduction = Children(i).Data
   Case "ETIMEPRODUCTION":z4090.ETimeProduction = Children(i).Data
   Case "INCHARGEPRODUTION":z4090.InchargeProdution = Children(i).Data
   Case "SEMACHINETYPE":z4090.seMachineType = Children(i).Data
   Case "CDMACHINETYPE":z4090.cdMachineType = Children(i).Data
   Case "MACHINECODE":z4090.MachineCode = Children(i).Data
   Case "PARTPRODUCTION":z4090.PartProduction = Children(i).Data
   Case "QTYPRODUCTION":z4090.QtyProduction = Children(i).Data
   Case "QTYPRODUCTIONA":z4090.QtyProductionA = Children(i).Data
   Case "QTYPRODUCTIONX":z4090.QtyProductionX = Children(i).Data
   Case "REMARK":z4090.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K4090_MOVE",vbCritical)
End Try
End Function 
    
End Module 
