'=========================================================================================================================================================
'   TABLE : (PFK0175)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K0175

Structure T0175_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	SpecNo	 AS String	'			char(9)		*
Public 	SpecNoSeq	 AS String	'			char(3)		*
Public 	Szno	 AS String	'			char(2)		*
Public 	cdMainProcess	 AS String	'			char(3)		*
Public 	Sno	 AS String	'			char(5)		*
Public 	SizeName	 AS String	'			nvarchar(10)
Public 	MaterialSeq	 AS Double	'			decimal
Public 	BatchNo	 AS String	'			char(10)
Public 	BatchGroup	 AS String	'			char(10)
Public 	BatchShoes	 AS String	'			char(10)
Public 	TypeBatch	 AS String	'			char(1)
Public 	cdFactory	 AS String	'			char(3)
Public 	MachineCode	 AS String	'			char(6)
Public 	MachineTno	 AS String	'			char(2)
Public 	cdLineProd	 AS String	'			char(3)
Public 	LineTno	 AS String	'			char(2)
Public 	DatePrint	 AS String	'			char(8)
Public 	DateBatch	 AS String	'			char(8)
Public 	InchargeBatch	 AS String	'			char(8)
Public 	InchargePrint	 AS String	'			char(8)
Public 	QtyBatch	 AS Double	'			decimal
Public 	CheckL	 AS String	'			char(1)
Public 	CheckR	 AS String	'			char(1)
Public 	QtyProduction	 AS Double	'			decimal
Public 	QtyProductionA	 AS Double	'			decimal
Public 	QtyProductionX	 AS Double	'			decimal
Public 	QtyProductionXP	 AS Double	'			decimal
Public 	QtyProductionXR	 AS Double	'			decimal
Public 	QtyBLOut	 AS Double	'			decimal
Public 	QtyBLIn	 AS Double	'			decimal
Public 	DateInsert	 AS String	'			char(8)
Public 	InchargeInsert	 AS String	'			char(6)
Public 	DateUpdate	 AS String	'			char(8)
Public 	InchargeUpdate	 AS String	'			char(8)
Public 	CheckComplete	 AS String	'			char(1)
Public 	Remark	 AS String	'			nvarchar(50)
'=========================================================================================================================================================
End structure

Public D0175 As T0175_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK0175(SPECNO AS String, SPECNOSEQ AS String, SZNO AS String, CDMAINPROCESS AS String, SNO AS String) As Boolean
    READ_PFK0175 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK0175 "
    SQL = SQL & " WHERE K0175_SpecNo		 = '" & SpecNo & "' " 
    SQL = SQL & "   AND K0175_SpecNoSeq		 = '" & SpecNoSeq & "' " 
    SQL = SQL & "   AND K0175_Szno		 = '" & Szno & "' " 
    SQL = SQL & "   AND K0175_cdMainProcess		 = '" & cdMainProcess & "' " 
    SQL = SQL & "   AND K0175_Sno		 = '" & Sno & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D0175_CLEAR: GoTo SKIP_READ_PFK0175
                
    Call K0175_MOVE(rd)
    READ_PFK0175 = True

SKIP_READ_PFK0175:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK0175",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK0175(SPECNO AS String, SPECNOSEQ AS String, SZNO AS String, CDMAINPROCESS AS String, SNO AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK0175 "
    SQL = SQL & " WHERE K0175_SpecNo		 = '" & SpecNo & "' " 
    SQL = SQL & "   AND K0175_SpecNoSeq		 = '" & SpecNoSeq & "' " 
    SQL = SQL & "   AND K0175_Szno		 = '" & Szno & "' " 
    SQL = SQL & "   AND K0175_cdMainProcess		 = '" & cdMainProcess & "' " 
    SQL = SQL & "   AND K0175_Sno		 = '" & Sno & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK0175",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK0175(z0175 As T0175_AREA) As Boolean
    WRITE_PFK0175 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z0175)
 
    SQL = " INSERT INTO PFK0175 "
    SQL = SQL & " ( "
    SQL = SQL & " K0175_SpecNo," 
    SQL = SQL & " K0175_SpecNoSeq," 
    SQL = SQL & " K0175_Szno," 
    SQL = SQL & " K0175_cdMainProcess," 
    SQL = SQL & " K0175_Sno," 
    SQL = SQL & " K0175_SizeName," 
    SQL = SQL & " K0175_MaterialSeq," 
    SQL = SQL & " K0175_BatchNo," 
    SQL = SQL & " K0175_BatchGroup," 
    SQL = SQL & " K0175_BatchShoes," 
    SQL = SQL & " K0175_TypeBatch," 
    SQL = SQL & " K0175_cdFactory," 
    SQL = SQL & " K0175_MachineCode," 
    SQL = SQL & " K0175_MachineTno," 
    SQL = SQL & " K0175_cdLineProd," 
    SQL = SQL & " K0175_LineTno," 
    SQL = SQL & " K0175_DatePrint," 
    SQL = SQL & " K0175_DateBatch," 
    SQL = SQL & " K0175_InchargeBatch," 
    SQL = SQL & " K0175_InchargePrint," 
    SQL = SQL & " K0175_QtyBatch," 
    SQL = SQL & " K0175_CheckL," 
    SQL = SQL & " K0175_CheckR," 
    SQL = SQL & " K0175_QtyProduction," 
    SQL = SQL & " K0175_QtyProductionA," 
    SQL = SQL & " K0175_QtyProductionX," 
    SQL = SQL & " K0175_QtyProductionXP," 
    SQL = SQL & " K0175_QtyProductionXR," 
    SQL = SQL & " K0175_QtyBLOut," 
    SQL = SQL & " K0175_QtyBLIn," 
    SQL = SQL & " K0175_DateInsert," 
    SQL = SQL & " K0175_InchargeInsert," 
    SQL = SQL & " K0175_DateUpdate," 
    SQL = SQL & " K0175_InchargeUpdate," 
    SQL = SQL & " K0175_CheckComplete," 
    SQL = SQL & " K0175_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z0175.SpecNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0175.SpecNoSeq) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0175.Szno) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0175.cdMainProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0175.Sno) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0175.SizeName) & "', "  
    SQL = SQL & "   " & FormatSQL(z0175.MaterialSeq) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z0175.BatchNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0175.BatchGroup) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0175.BatchShoes) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0175.TypeBatch) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0175.cdFactory) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0175.MachineCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0175.MachineTno) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0175.cdLineProd) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0175.LineTno) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0175.DatePrint) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0175.DateBatch) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0175.InchargeBatch) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0175.InchargePrint) & "', "  
    SQL = SQL & "   " & FormatSQL(z0175.QtyBatch) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z0175.CheckL) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0175.CheckR) & "', "  
    SQL = SQL & "   " & FormatSQL(z0175.QtyProduction) & ", "  
    SQL = SQL & "   " & FormatSQL(z0175.QtyProductionA) & ", "  
    SQL = SQL & "   " & FormatSQL(z0175.QtyProductionX) & ", "  
    SQL = SQL & "   " & FormatSQL(z0175.QtyProductionXP) & ", "  
    SQL = SQL & "   " & FormatSQL(z0175.QtyProductionXR) & ", "  
    SQL = SQL & "   " & FormatSQL(z0175.QtyBLOut) & ", "  
    SQL = SQL & "   " & FormatSQL(z0175.QtyBLIn) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z0175.DateInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0175.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0175.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0175.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0175.CheckComplete) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0175.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK0175 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK0175",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK0175(z0175 As T0175_AREA) As Boolean
    REWRITE_PFK0175 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z0175)
   
    SQL = " UPDATE PFK0175 SET "
    SQL = SQL & "    K0175_SizeName      = N'" & FormatSQL(z0175.SizeName) & "', " 
    SQL = SQL & "    K0175_MaterialSeq      =  " & FormatSQL(z0175.MaterialSeq) & ", " 
    SQL = SQL & "    K0175_BatchNo      = N'" & FormatSQL(z0175.BatchNo) & "', " 
    SQL = SQL & "    K0175_BatchGroup      = N'" & FormatSQL(z0175.BatchGroup) & "', " 
    SQL = SQL & "    K0175_BatchShoes      = N'" & FormatSQL(z0175.BatchShoes) & "', " 
    SQL = SQL & "    K0175_TypeBatch      = N'" & FormatSQL(z0175.TypeBatch) & "', " 
    SQL = SQL & "    K0175_cdFactory      = N'" & FormatSQL(z0175.cdFactory) & "', " 
    SQL = SQL & "    K0175_MachineCode      = N'" & FormatSQL(z0175.MachineCode) & "', " 
    SQL = SQL & "    K0175_MachineTno      = N'" & FormatSQL(z0175.MachineTno) & "', " 
    SQL = SQL & "    K0175_cdLineProd      = N'" & FormatSQL(z0175.cdLineProd) & "', " 
    SQL = SQL & "    K0175_LineTno      = N'" & FormatSQL(z0175.LineTno) & "', " 
    SQL = SQL & "    K0175_DatePrint      = N'" & FormatSQL(z0175.DatePrint) & "', " 
    SQL = SQL & "    K0175_DateBatch      = N'" & FormatSQL(z0175.DateBatch) & "', " 
    SQL = SQL & "    K0175_InchargeBatch      = N'" & FormatSQL(z0175.InchargeBatch) & "', " 
    SQL = SQL & "    K0175_InchargePrint      = N'" & FormatSQL(z0175.InchargePrint) & "', " 
    SQL = SQL & "    K0175_QtyBatch      =  " & FormatSQL(z0175.QtyBatch) & ", " 
    SQL = SQL & "    K0175_CheckL      = N'" & FormatSQL(z0175.CheckL) & "', " 
    SQL = SQL & "    K0175_CheckR      = N'" & FormatSQL(z0175.CheckR) & "', " 
    SQL = SQL & "    K0175_QtyProduction      =  " & FormatSQL(z0175.QtyProduction) & ", " 
    SQL = SQL & "    K0175_QtyProductionA      =  " & FormatSQL(z0175.QtyProductionA) & ", " 
    SQL = SQL & "    K0175_QtyProductionX      =  " & FormatSQL(z0175.QtyProductionX) & ", " 
    SQL = SQL & "    K0175_QtyProductionXP      =  " & FormatSQL(z0175.QtyProductionXP) & ", " 
    SQL = SQL & "    K0175_QtyProductionXR      =  " & FormatSQL(z0175.QtyProductionXR) & ", " 
    SQL = SQL & "    K0175_QtyBLOut      =  " & FormatSQL(z0175.QtyBLOut) & ", " 
    SQL = SQL & "    K0175_QtyBLIn      =  " & FormatSQL(z0175.QtyBLIn) & ", " 
    SQL = SQL & "    K0175_DateInsert      = N'" & FormatSQL(z0175.DateInsert) & "', " 
    SQL = SQL & "    K0175_InchargeInsert      = N'" & FormatSQL(z0175.InchargeInsert) & "', " 
    SQL = SQL & "    K0175_DateUpdate      = N'" & FormatSQL(z0175.DateUpdate) & "', " 
    SQL = SQL & "    K0175_InchargeUpdate      = N'" & FormatSQL(z0175.InchargeUpdate) & "', " 
    SQL = SQL & "    K0175_CheckComplete      = N'" & FormatSQL(z0175.CheckComplete) & "', " 
    SQL = SQL & "    K0175_Remark      = N'" & FormatSQL(z0175.Remark) & "'  " 
    SQL = SQL & " WHERE K0175_SpecNo		 = '" & z0175.SpecNo & "' " 
    SQL = SQL & "   AND K0175_SpecNoSeq		 = '" & z0175.SpecNoSeq & "' " 
    SQL = SQL & "   AND K0175_Szno		 = '" & z0175.Szno & "' " 
    SQL = SQL & "   AND K0175_cdMainProcess		 = '" & z0175.cdMainProcess & "' " 
    SQL = SQL & "   AND K0175_Sno		 = '" & z0175.Sno & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK0175 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK0175",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK0175(z0175 As T0175_AREA) As Boolean
    DELETE_PFK0175 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK0175 "
    SQL = SQL & " WHERE K0175_SpecNo		 = '" & z0175.SpecNo & "' " 
    SQL = SQL & "   AND K0175_SpecNoSeq		 = '" & z0175.SpecNoSeq & "' " 
    SQL = SQL & "   AND K0175_Szno		 = '" & z0175.Szno & "' " 
    SQL = SQL & "   AND K0175_cdMainProcess		 = '" & z0175.cdMainProcess & "' " 
    SQL = SQL & "   AND K0175_Sno		 = '" & z0175.Sno & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK0175 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK0175",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D0175_CLEAR()
Try
    
   D0175.SpecNo = ""
   D0175.SpecNoSeq = ""
   D0175.Szno = ""
   D0175.cdMainProcess = ""
   D0175.Sno = ""
   D0175.SizeName = ""
    D0175.MaterialSeq = 0 
   D0175.BatchNo = ""
   D0175.BatchGroup = ""
   D0175.BatchShoes = ""
   D0175.TypeBatch = ""
   D0175.cdFactory = ""
   D0175.MachineCode = ""
   D0175.MachineTno = ""
   D0175.cdLineProd = ""
   D0175.LineTno = ""
   D0175.DatePrint = ""
   D0175.DateBatch = ""
   D0175.InchargeBatch = ""
   D0175.InchargePrint = ""
    D0175.QtyBatch = 0 
   D0175.CheckL = ""
   D0175.CheckR = ""
    D0175.QtyProduction = 0 
    D0175.QtyProductionA = 0 
    D0175.QtyProductionX = 0 
    D0175.QtyProductionXP = 0 
    D0175.QtyProductionXR = 0 
    D0175.QtyBLOut = 0 
    D0175.QtyBLIn = 0 
   D0175.DateInsert = ""
   D0175.InchargeInsert = ""
   D0175.DateUpdate = ""
   D0175.InchargeUpdate = ""
   D0175.CheckComplete = ""
   D0175.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D0175_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x0175 As T0175_AREA)
Try
    
    x0175.SpecNo = trim$(  x0175.SpecNo)
    x0175.SpecNoSeq = trim$(  x0175.SpecNoSeq)
    x0175.Szno = trim$(  x0175.Szno)
    x0175.cdMainProcess = trim$(  x0175.cdMainProcess)
    x0175.Sno = trim$(  x0175.Sno)
    x0175.SizeName = trim$(  x0175.SizeName)
    x0175.MaterialSeq = trim$(  x0175.MaterialSeq)
    x0175.BatchNo = trim$(  x0175.BatchNo)
    x0175.BatchGroup = trim$(  x0175.BatchGroup)
    x0175.BatchShoes = trim$(  x0175.BatchShoes)
    x0175.TypeBatch = trim$(  x0175.TypeBatch)
    x0175.cdFactory = trim$(  x0175.cdFactory)
    x0175.MachineCode = trim$(  x0175.MachineCode)
    x0175.MachineTno = trim$(  x0175.MachineTno)
    x0175.cdLineProd = trim$(  x0175.cdLineProd)
    x0175.LineTno = trim$(  x0175.LineTno)
    x0175.DatePrint = trim$(  x0175.DatePrint)
    x0175.DateBatch = trim$(  x0175.DateBatch)
    x0175.InchargeBatch = trim$(  x0175.InchargeBatch)
    x0175.InchargePrint = trim$(  x0175.InchargePrint)
    x0175.QtyBatch = trim$(  x0175.QtyBatch)
    x0175.CheckL = trim$(  x0175.CheckL)
    x0175.CheckR = trim$(  x0175.CheckR)
    x0175.QtyProduction = trim$(  x0175.QtyProduction)
    x0175.QtyProductionA = trim$(  x0175.QtyProductionA)
    x0175.QtyProductionX = trim$(  x0175.QtyProductionX)
    x0175.QtyProductionXP = trim$(  x0175.QtyProductionXP)
    x0175.QtyProductionXR = trim$(  x0175.QtyProductionXR)
    x0175.QtyBLOut = trim$(  x0175.QtyBLOut)
    x0175.QtyBLIn = trim$(  x0175.QtyBLIn)
    x0175.DateInsert = trim$(  x0175.DateInsert)
    x0175.InchargeInsert = trim$(  x0175.InchargeInsert)
    x0175.DateUpdate = trim$(  x0175.DateUpdate)
    x0175.InchargeUpdate = trim$(  x0175.InchargeUpdate)
    x0175.CheckComplete = trim$(  x0175.CheckComplete)
    x0175.Remark = trim$(  x0175.Remark)
     
    If trim$( x0175.SpecNo ) = "" Then x0175.SpecNo = Space(1) 
    If trim$( x0175.SpecNoSeq ) = "" Then x0175.SpecNoSeq = Space(1) 
    If trim$( x0175.Szno ) = "" Then x0175.Szno = Space(1) 
    If trim$( x0175.cdMainProcess ) = "" Then x0175.cdMainProcess = Space(1) 
    If trim$( x0175.Sno ) = "" Then x0175.Sno = Space(1) 
    If trim$( x0175.SizeName ) = "" Then x0175.SizeName = Space(1) 
    If trim$( x0175.MaterialSeq ) = "" Then x0175.MaterialSeq = 0 
    If trim$( x0175.BatchNo ) = "" Then x0175.BatchNo = Space(1) 
    If trim$( x0175.BatchGroup ) = "" Then x0175.BatchGroup = Space(1) 
    If trim$( x0175.BatchShoes ) = "" Then x0175.BatchShoes = Space(1) 
    If trim$( x0175.TypeBatch ) = "" Then x0175.TypeBatch = Space(1) 
    If trim$( x0175.cdFactory ) = "" Then x0175.cdFactory = Space(1) 
    If trim$( x0175.MachineCode ) = "" Then x0175.MachineCode = Space(1) 
    If trim$( x0175.MachineTno ) = "" Then x0175.MachineTno = Space(1) 
    If trim$( x0175.cdLineProd ) = "" Then x0175.cdLineProd = Space(1) 
    If trim$( x0175.LineTno ) = "" Then x0175.LineTno = Space(1) 
    If trim$( x0175.DatePrint ) = "" Then x0175.DatePrint = Space(1) 
    If trim$( x0175.DateBatch ) = "" Then x0175.DateBatch = Space(1) 
    If trim$( x0175.InchargeBatch ) = "" Then x0175.InchargeBatch = Space(1) 
    If trim$( x0175.InchargePrint ) = "" Then x0175.InchargePrint = Space(1) 
    If trim$( x0175.QtyBatch ) = "" Then x0175.QtyBatch = 0 
    If trim$( x0175.CheckL ) = "" Then x0175.CheckL = Space(1) 
    If trim$( x0175.CheckR ) = "" Then x0175.CheckR = Space(1) 
    If trim$( x0175.QtyProduction ) = "" Then x0175.QtyProduction = 0 
    If trim$( x0175.QtyProductionA ) = "" Then x0175.QtyProductionA = 0 
    If trim$( x0175.QtyProductionX ) = "" Then x0175.QtyProductionX = 0 
    If trim$( x0175.QtyProductionXP ) = "" Then x0175.QtyProductionXP = 0 
    If trim$( x0175.QtyProductionXR ) = "" Then x0175.QtyProductionXR = 0 
    If trim$( x0175.QtyBLOut ) = "" Then x0175.QtyBLOut = 0 
    If trim$( x0175.QtyBLIn ) = "" Then x0175.QtyBLIn = 0 
    If trim$( x0175.DateInsert ) = "" Then x0175.DateInsert = Space(1) 
    If trim$( x0175.InchargeInsert ) = "" Then x0175.InchargeInsert = Space(1) 
    If trim$( x0175.DateUpdate ) = "" Then x0175.DateUpdate = Space(1) 
    If trim$( x0175.InchargeUpdate ) = "" Then x0175.InchargeUpdate = Space(1) 
    If trim$( x0175.CheckComplete ) = "" Then x0175.CheckComplete = Space(1) 
    If trim$( x0175.Remark ) = "" Then x0175.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K0175_MOVE(rs0175 As SqlClient.SqlDataReader)
Try

    call D0175_CLEAR()   

    If IsdbNull(rs0175!K0175_SpecNo) = False Then D0175.SpecNo = Trim$(rs0175!K0175_SpecNo)
    If IsdbNull(rs0175!K0175_SpecNoSeq) = False Then D0175.SpecNoSeq = Trim$(rs0175!K0175_SpecNoSeq)
    If IsdbNull(rs0175!K0175_Szno) = False Then D0175.Szno = Trim$(rs0175!K0175_Szno)
    If IsdbNull(rs0175!K0175_cdMainProcess) = False Then D0175.cdMainProcess = Trim$(rs0175!K0175_cdMainProcess)
    If IsdbNull(rs0175!K0175_Sno) = False Then D0175.Sno = Trim$(rs0175!K0175_Sno)
    If IsdbNull(rs0175!K0175_SizeName) = False Then D0175.SizeName = Trim$(rs0175!K0175_SizeName)
    If IsdbNull(rs0175!K0175_MaterialSeq) = False Then D0175.MaterialSeq = Trim$(rs0175!K0175_MaterialSeq)
    If IsdbNull(rs0175!K0175_BatchNo) = False Then D0175.BatchNo = Trim$(rs0175!K0175_BatchNo)
    If IsdbNull(rs0175!K0175_BatchGroup) = False Then D0175.BatchGroup = Trim$(rs0175!K0175_BatchGroup)
    If IsdbNull(rs0175!K0175_BatchShoes) = False Then D0175.BatchShoes = Trim$(rs0175!K0175_BatchShoes)
    If IsdbNull(rs0175!K0175_TypeBatch) = False Then D0175.TypeBatch = Trim$(rs0175!K0175_TypeBatch)
    If IsdbNull(rs0175!K0175_cdFactory) = False Then D0175.cdFactory = Trim$(rs0175!K0175_cdFactory)
    If IsdbNull(rs0175!K0175_MachineCode) = False Then D0175.MachineCode = Trim$(rs0175!K0175_MachineCode)
    If IsdbNull(rs0175!K0175_MachineTno) = False Then D0175.MachineTno = Trim$(rs0175!K0175_MachineTno)
    If IsdbNull(rs0175!K0175_cdLineProd) = False Then D0175.cdLineProd = Trim$(rs0175!K0175_cdLineProd)
    If IsdbNull(rs0175!K0175_LineTno) = False Then D0175.LineTno = Trim$(rs0175!K0175_LineTno)
    If IsdbNull(rs0175!K0175_DatePrint) = False Then D0175.DatePrint = Trim$(rs0175!K0175_DatePrint)
    If IsdbNull(rs0175!K0175_DateBatch) = False Then D0175.DateBatch = Trim$(rs0175!K0175_DateBatch)
    If IsdbNull(rs0175!K0175_InchargeBatch) = False Then D0175.InchargeBatch = Trim$(rs0175!K0175_InchargeBatch)
    If IsdbNull(rs0175!K0175_InchargePrint) = False Then D0175.InchargePrint = Trim$(rs0175!K0175_InchargePrint)
    If IsdbNull(rs0175!K0175_QtyBatch) = False Then D0175.QtyBatch = Trim$(rs0175!K0175_QtyBatch)
    If IsdbNull(rs0175!K0175_CheckL) = False Then D0175.CheckL = Trim$(rs0175!K0175_CheckL)
    If IsdbNull(rs0175!K0175_CheckR) = False Then D0175.CheckR = Trim$(rs0175!K0175_CheckR)
    If IsdbNull(rs0175!K0175_QtyProduction) = False Then D0175.QtyProduction = Trim$(rs0175!K0175_QtyProduction)
    If IsdbNull(rs0175!K0175_QtyProductionA) = False Then D0175.QtyProductionA = Trim$(rs0175!K0175_QtyProductionA)
    If IsdbNull(rs0175!K0175_QtyProductionX) = False Then D0175.QtyProductionX = Trim$(rs0175!K0175_QtyProductionX)
    If IsdbNull(rs0175!K0175_QtyProductionXP) = False Then D0175.QtyProductionXP = Trim$(rs0175!K0175_QtyProductionXP)
    If IsdbNull(rs0175!K0175_QtyProductionXR) = False Then D0175.QtyProductionXR = Trim$(rs0175!K0175_QtyProductionXR)
    If IsdbNull(rs0175!K0175_QtyBLOut) = False Then D0175.QtyBLOut = Trim$(rs0175!K0175_QtyBLOut)
    If IsdbNull(rs0175!K0175_QtyBLIn) = False Then D0175.QtyBLIn = Trim$(rs0175!K0175_QtyBLIn)
    If IsdbNull(rs0175!K0175_DateInsert) = False Then D0175.DateInsert = Trim$(rs0175!K0175_DateInsert)
    If IsdbNull(rs0175!K0175_InchargeInsert) = False Then D0175.InchargeInsert = Trim$(rs0175!K0175_InchargeInsert)
    If IsdbNull(rs0175!K0175_DateUpdate) = False Then D0175.DateUpdate = Trim$(rs0175!K0175_DateUpdate)
    If IsdbNull(rs0175!K0175_InchargeUpdate) = False Then D0175.InchargeUpdate = Trim$(rs0175!K0175_InchargeUpdate)
    If IsdbNull(rs0175!K0175_CheckComplete) = False Then D0175.CheckComplete = Trim$(rs0175!K0175_CheckComplete)
    If IsdbNull(rs0175!K0175_Remark) = False Then D0175.Remark = Trim$(rs0175!K0175_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K0175_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K0175_MOVE(rs0175 As DataRow)
Try

    call D0175_CLEAR()   

    If IsdbNull(rs0175!K0175_SpecNo) = False Then D0175.SpecNo = Trim$(rs0175!K0175_SpecNo)
    If IsdbNull(rs0175!K0175_SpecNoSeq) = False Then D0175.SpecNoSeq = Trim$(rs0175!K0175_SpecNoSeq)
    If IsdbNull(rs0175!K0175_Szno) = False Then D0175.Szno = Trim$(rs0175!K0175_Szno)
    If IsdbNull(rs0175!K0175_cdMainProcess) = False Then D0175.cdMainProcess = Trim$(rs0175!K0175_cdMainProcess)
    If IsdbNull(rs0175!K0175_Sno) = False Then D0175.Sno = Trim$(rs0175!K0175_Sno)
    If IsdbNull(rs0175!K0175_SizeName) = False Then D0175.SizeName = Trim$(rs0175!K0175_SizeName)
    If IsdbNull(rs0175!K0175_MaterialSeq) = False Then D0175.MaterialSeq = Trim$(rs0175!K0175_MaterialSeq)
    If IsdbNull(rs0175!K0175_BatchNo) = False Then D0175.BatchNo = Trim$(rs0175!K0175_BatchNo)
    If IsdbNull(rs0175!K0175_BatchGroup) = False Then D0175.BatchGroup = Trim$(rs0175!K0175_BatchGroup)
    If IsdbNull(rs0175!K0175_BatchShoes) = False Then D0175.BatchShoes = Trim$(rs0175!K0175_BatchShoes)
    If IsdbNull(rs0175!K0175_TypeBatch) = False Then D0175.TypeBatch = Trim$(rs0175!K0175_TypeBatch)
    If IsdbNull(rs0175!K0175_cdFactory) = False Then D0175.cdFactory = Trim$(rs0175!K0175_cdFactory)
    If IsdbNull(rs0175!K0175_MachineCode) = False Then D0175.MachineCode = Trim$(rs0175!K0175_MachineCode)
    If IsdbNull(rs0175!K0175_MachineTno) = False Then D0175.MachineTno = Trim$(rs0175!K0175_MachineTno)
    If IsdbNull(rs0175!K0175_cdLineProd) = False Then D0175.cdLineProd = Trim$(rs0175!K0175_cdLineProd)
    If IsdbNull(rs0175!K0175_LineTno) = False Then D0175.LineTno = Trim$(rs0175!K0175_LineTno)
    If IsdbNull(rs0175!K0175_DatePrint) = False Then D0175.DatePrint = Trim$(rs0175!K0175_DatePrint)
    If IsdbNull(rs0175!K0175_DateBatch) = False Then D0175.DateBatch = Trim$(rs0175!K0175_DateBatch)
    If IsdbNull(rs0175!K0175_InchargeBatch) = False Then D0175.InchargeBatch = Trim$(rs0175!K0175_InchargeBatch)
    If IsdbNull(rs0175!K0175_InchargePrint) = False Then D0175.InchargePrint = Trim$(rs0175!K0175_InchargePrint)
    If IsdbNull(rs0175!K0175_QtyBatch) = False Then D0175.QtyBatch = Trim$(rs0175!K0175_QtyBatch)
    If IsdbNull(rs0175!K0175_CheckL) = False Then D0175.CheckL = Trim$(rs0175!K0175_CheckL)
    If IsdbNull(rs0175!K0175_CheckR) = False Then D0175.CheckR = Trim$(rs0175!K0175_CheckR)
    If IsdbNull(rs0175!K0175_QtyProduction) = False Then D0175.QtyProduction = Trim$(rs0175!K0175_QtyProduction)
    If IsdbNull(rs0175!K0175_QtyProductionA) = False Then D0175.QtyProductionA = Trim$(rs0175!K0175_QtyProductionA)
    If IsdbNull(rs0175!K0175_QtyProductionX) = False Then D0175.QtyProductionX = Trim$(rs0175!K0175_QtyProductionX)
    If IsdbNull(rs0175!K0175_QtyProductionXP) = False Then D0175.QtyProductionXP = Trim$(rs0175!K0175_QtyProductionXP)
    If IsdbNull(rs0175!K0175_QtyProductionXR) = False Then D0175.QtyProductionXR = Trim$(rs0175!K0175_QtyProductionXR)
    If IsdbNull(rs0175!K0175_QtyBLOut) = False Then D0175.QtyBLOut = Trim$(rs0175!K0175_QtyBLOut)
    If IsdbNull(rs0175!K0175_QtyBLIn) = False Then D0175.QtyBLIn = Trim$(rs0175!K0175_QtyBLIn)
    If IsdbNull(rs0175!K0175_DateInsert) = False Then D0175.DateInsert = Trim$(rs0175!K0175_DateInsert)
    If IsdbNull(rs0175!K0175_InchargeInsert) = False Then D0175.InchargeInsert = Trim$(rs0175!K0175_InchargeInsert)
    If IsdbNull(rs0175!K0175_DateUpdate) = False Then D0175.DateUpdate = Trim$(rs0175!K0175_DateUpdate)
    If IsdbNull(rs0175!K0175_InchargeUpdate) = False Then D0175.InchargeUpdate = Trim$(rs0175!K0175_InchargeUpdate)
    If IsdbNull(rs0175!K0175_CheckComplete) = False Then D0175.CheckComplete = Trim$(rs0175!K0175_CheckComplete)
    If IsdbNull(rs0175!K0175_Remark) = False Then D0175.Remark = Trim$(rs0175!K0175_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K0175_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K0175_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z0175 As T0175_AREA, SPECNO AS String, SPECNOSEQ AS String, SZNO AS String, CDMAINPROCESS AS String, SNO AS String) as Boolean

K0175_MOVE = False

Try
    If READ_PFK0175(SPECNO, SPECNOSEQ, SZNO, CDMAINPROCESS, SNO) = True Then
                z0175 = D0175
		K0175_MOVE = True
		else
	z0175 = nothing
     End If

     If  getColumIndex(spr,"SpecNo") > -1 then z0175.SpecNo = getDataM(spr, getColumIndex(spr,"SpecNo"), xRow)
     If  getColumIndex(spr,"SpecNoSeq") > -1 then z0175.SpecNoSeq = getDataM(spr, getColumIndex(spr,"SpecNoSeq"), xRow)
     If  getColumIndex(spr,"Szno") > -1 then z0175.Szno = getDataM(spr, getColumIndex(spr,"Szno"), xRow)
     If  getColumIndex(spr,"cdMainProcess") > -1 then z0175.cdMainProcess = getDataM(spr, getColumIndex(spr,"cdMainProcess"), xRow)
     If  getColumIndex(spr,"Sno") > -1 then z0175.Sno = getDataM(spr, getColumIndex(spr,"Sno"), xRow)
     If  getColumIndex(spr,"SizeName") > -1 then z0175.SizeName = getDataM(spr, getColumIndex(spr,"SizeName"), xRow)
     If  getColumIndex(spr,"MaterialSeq") > -1 then z0175.MaterialSeq = getDataM(spr, getColumIndex(spr,"MaterialSeq"), xRow)
     If  getColumIndex(spr,"BatchNo") > -1 then z0175.BatchNo = getDataM(spr, getColumIndex(spr,"BatchNo"), xRow)
     If  getColumIndex(spr,"BatchGroup") > -1 then z0175.BatchGroup = getDataM(spr, getColumIndex(spr,"BatchGroup"), xRow)
     If  getColumIndex(spr,"BatchShoes") > -1 then z0175.BatchShoes = getDataM(spr, getColumIndex(spr,"BatchShoes"), xRow)
     If  getColumIndex(spr,"TypeBatch") > -1 then z0175.TypeBatch = getDataM(spr, getColumIndex(spr,"TypeBatch"), xRow)
     If  getColumIndex(spr,"cdFactory") > -1 then z0175.cdFactory = getDataM(spr, getColumIndex(spr,"cdFactory"), xRow)
     If  getColumIndex(spr,"MachineCode") > -1 then z0175.MachineCode = getDataM(spr, getColumIndex(spr,"MachineCode"), xRow)
     If  getColumIndex(spr,"MachineTno") > -1 then z0175.MachineTno = getDataM(spr, getColumIndex(spr,"MachineTno"), xRow)
     If  getColumIndex(spr,"cdLineProd") > -1 then z0175.cdLineProd = getDataM(spr, getColumIndex(spr,"cdLineProd"), xRow)
     If  getColumIndex(spr,"LineTno") > -1 then z0175.LineTno = getDataM(spr, getColumIndex(spr,"LineTno"), xRow)
     If  getColumIndex(spr,"DatePrint") > -1 then z0175.DatePrint = getDataM(spr, getColumIndex(spr,"DatePrint"), xRow)
     If  getColumIndex(spr,"DateBatch") > -1 then z0175.DateBatch = getDataM(spr, getColumIndex(spr,"DateBatch"), xRow)
     If  getColumIndex(spr,"InchargeBatch") > -1 then z0175.InchargeBatch = getDataM(spr, getColumIndex(spr,"InchargeBatch"), xRow)
     If  getColumIndex(spr,"InchargePrint") > -1 then z0175.InchargePrint = getDataM(spr, getColumIndex(spr,"InchargePrint"), xRow)
     If  getColumIndex(spr,"QtyBatch") > -1 then z0175.QtyBatch = getDataM(spr, getColumIndex(spr,"QtyBatch"), xRow)
     If  getColumIndex(spr,"CheckL") > -1 then z0175.CheckL = getDataM(spr, getColumIndex(spr,"CheckL"), xRow)
     If  getColumIndex(spr,"CheckR") > -1 then z0175.CheckR = getDataM(spr, getColumIndex(spr,"CheckR"), xRow)
     If  getColumIndex(spr,"QtyProduction") > -1 then z0175.QtyProduction = getDataM(spr, getColumIndex(spr,"QtyProduction"), xRow)
     If  getColumIndex(spr,"QtyProductionA") > -1 then z0175.QtyProductionA = getDataM(spr, getColumIndex(spr,"QtyProductionA"), xRow)
     If  getColumIndex(spr,"QtyProductionX") > -1 then z0175.QtyProductionX = getDataM(spr, getColumIndex(spr,"QtyProductionX"), xRow)
     If  getColumIndex(spr,"QtyProductionXP") > -1 then z0175.QtyProductionXP = getDataM(spr, getColumIndex(spr,"QtyProductionXP"), xRow)
     If  getColumIndex(spr,"QtyProductionXR") > -1 then z0175.QtyProductionXR = getDataM(spr, getColumIndex(spr,"QtyProductionXR"), xRow)
     If  getColumIndex(spr,"QtyBLOut") > -1 then z0175.QtyBLOut = getDataM(spr, getColumIndex(spr,"QtyBLOut"), xRow)
     If  getColumIndex(spr,"QtyBLIn") > -1 then z0175.QtyBLIn = getDataM(spr, getColumIndex(spr,"QtyBLIn"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z0175.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z0175.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z0175.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z0175.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"CheckComplete") > -1 then z0175.CheckComplete = getDataM(spr, getColumIndex(spr,"CheckComplete"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z0175.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K0175_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K0175_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z0175 As T0175_AREA,CheckClear as Boolean,SPECNO AS String, SPECNOSEQ AS String, SZNO AS String, CDMAINPROCESS AS String, SNO AS String) as Boolean

K0175_MOVE = False

Try
    If READ_PFK0175(SPECNO, SPECNOSEQ, SZNO, CDMAINPROCESS, SNO) = True Then
                z0175 = D0175
		K0175_MOVE = True
		else
	If CheckClear  = True then z0175 = nothing
     End If

     If  getColumIndex(spr,"SpecNo") > -1 then z0175.SpecNo = getDataM(spr, getColumIndex(spr,"SpecNo"), xRow)
     If  getColumIndex(spr,"SpecNoSeq") > -1 then z0175.SpecNoSeq = getDataM(spr, getColumIndex(spr,"SpecNoSeq"), xRow)
     If  getColumIndex(spr,"Szno") > -1 then z0175.Szno = getDataM(spr, getColumIndex(spr,"Szno"), xRow)
     If  getColumIndex(spr,"cdMainProcess") > -1 then z0175.cdMainProcess = getDataM(spr, getColumIndex(spr,"cdMainProcess"), xRow)
     If  getColumIndex(spr,"Sno") > -1 then z0175.Sno = getDataM(spr, getColumIndex(spr,"Sno"), xRow)
     If  getColumIndex(spr,"SizeName") > -1 then z0175.SizeName = getDataM(spr, getColumIndex(spr,"SizeName"), xRow)
     If  getColumIndex(spr,"MaterialSeq") > -1 then z0175.MaterialSeq = getDataM(spr, getColumIndex(spr,"MaterialSeq"), xRow)
     If  getColumIndex(spr,"BatchNo") > -1 then z0175.BatchNo = getDataM(spr, getColumIndex(spr,"BatchNo"), xRow)
     If  getColumIndex(spr,"BatchGroup") > -1 then z0175.BatchGroup = getDataM(spr, getColumIndex(spr,"BatchGroup"), xRow)
     If  getColumIndex(spr,"BatchShoes") > -1 then z0175.BatchShoes = getDataM(spr, getColumIndex(spr,"BatchShoes"), xRow)
     If  getColumIndex(spr,"TypeBatch") > -1 then z0175.TypeBatch = getDataM(spr, getColumIndex(spr,"TypeBatch"), xRow)
     If  getColumIndex(spr,"cdFactory") > -1 then z0175.cdFactory = getDataM(spr, getColumIndex(spr,"cdFactory"), xRow)
     If  getColumIndex(spr,"MachineCode") > -1 then z0175.MachineCode = getDataM(spr, getColumIndex(spr,"MachineCode"), xRow)
     If  getColumIndex(spr,"MachineTno") > -1 then z0175.MachineTno = getDataM(spr, getColumIndex(spr,"MachineTno"), xRow)
     If  getColumIndex(spr,"cdLineProd") > -1 then z0175.cdLineProd = getDataM(spr, getColumIndex(spr,"cdLineProd"), xRow)
     If  getColumIndex(spr,"LineTno") > -1 then z0175.LineTno = getDataM(spr, getColumIndex(spr,"LineTno"), xRow)
     If  getColumIndex(spr,"DatePrint") > -1 then z0175.DatePrint = getDataM(spr, getColumIndex(spr,"DatePrint"), xRow)
     If  getColumIndex(spr,"DateBatch") > -1 then z0175.DateBatch = getDataM(spr, getColumIndex(spr,"DateBatch"), xRow)
     If  getColumIndex(spr,"InchargeBatch") > -1 then z0175.InchargeBatch = getDataM(spr, getColumIndex(spr,"InchargeBatch"), xRow)
     If  getColumIndex(spr,"InchargePrint") > -1 then z0175.InchargePrint = getDataM(spr, getColumIndex(spr,"InchargePrint"), xRow)
     If  getColumIndex(spr,"QtyBatch") > -1 then z0175.QtyBatch = getDataM(spr, getColumIndex(spr,"QtyBatch"), xRow)
     If  getColumIndex(spr,"CheckL") > -1 then z0175.CheckL = getDataM(spr, getColumIndex(spr,"CheckL"), xRow)
     If  getColumIndex(spr,"CheckR") > -1 then z0175.CheckR = getDataM(spr, getColumIndex(spr,"CheckR"), xRow)
     If  getColumIndex(spr,"QtyProduction") > -1 then z0175.QtyProduction = getDataM(spr, getColumIndex(spr,"QtyProduction"), xRow)
     If  getColumIndex(spr,"QtyProductionA") > -1 then z0175.QtyProductionA = getDataM(spr, getColumIndex(spr,"QtyProductionA"), xRow)
     If  getColumIndex(spr,"QtyProductionX") > -1 then z0175.QtyProductionX = getDataM(spr, getColumIndex(spr,"QtyProductionX"), xRow)
     If  getColumIndex(spr,"QtyProductionXP") > -1 then z0175.QtyProductionXP = getDataM(spr, getColumIndex(spr,"QtyProductionXP"), xRow)
     If  getColumIndex(spr,"QtyProductionXR") > -1 then z0175.QtyProductionXR = getDataM(spr, getColumIndex(spr,"QtyProductionXR"), xRow)
     If  getColumIndex(spr,"QtyBLOut") > -1 then z0175.QtyBLOut = getDataM(spr, getColumIndex(spr,"QtyBLOut"), xRow)
     If  getColumIndex(spr,"QtyBLIn") > -1 then z0175.QtyBLIn = getDataM(spr, getColumIndex(spr,"QtyBLIn"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z0175.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z0175.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z0175.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z0175.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"CheckComplete") > -1 then z0175.CheckComplete = getDataM(spr, getColumIndex(spr,"CheckComplete"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z0175.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K0175_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K0175_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z0175 As T0175_AREA, Job as String, SPECNO AS String, SPECNOSEQ AS String, SZNO AS String, CDMAINPROCESS AS String, SNO AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K0175_MOVE = False

Try
    If READ_PFK0175(SPECNO, SPECNOSEQ, SZNO, CDMAINPROCESS, SNO) = True Then
                z0175 = D0175
		K0175_MOVE = True
		else
	z0175 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK0175")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "SPECNO":z0175.SpecNo = Children(i).Code
   Case "SPECNOSEQ":z0175.SpecNoSeq = Children(i).Code
   Case "SZNO":z0175.Szno = Children(i).Code
   Case "CDMAINPROCESS":z0175.cdMainProcess = Children(i).Code
   Case "SNO":z0175.Sno = Children(i).Code
   Case "SIZENAME":z0175.SizeName = Children(i).Code
   Case "MATERIALSEQ":z0175.MaterialSeq = Children(i).Code
   Case "BATCHNO":z0175.BatchNo = Children(i).Code
   Case "BATCHGROUP":z0175.BatchGroup = Children(i).Code
   Case "BATCHSHOES":z0175.BatchShoes = Children(i).Code
   Case "TYPEBATCH":z0175.TypeBatch = Children(i).Code
   Case "CDFACTORY":z0175.cdFactory = Children(i).Code
   Case "MACHINECODE":z0175.MachineCode = Children(i).Code
   Case "MACHINETNO":z0175.MachineTno = Children(i).Code
   Case "CDLINEPROD":z0175.cdLineProd = Children(i).Code
   Case "LINETNO":z0175.LineTno = Children(i).Code
   Case "DATEPRINT":z0175.DatePrint = Children(i).Code
   Case "DATEBATCH":z0175.DateBatch = Children(i).Code
   Case "INCHARGEBATCH":z0175.InchargeBatch = Children(i).Code
   Case "INCHARGEPRINT":z0175.InchargePrint = Children(i).Code
   Case "QTYBATCH":z0175.QtyBatch = Children(i).Code
   Case "CHECKL":z0175.CheckL = Children(i).Code
   Case "CHECKR":z0175.CheckR = Children(i).Code
   Case "QTYPRODUCTION":z0175.QtyProduction = Children(i).Code
   Case "QTYPRODUCTIONA":z0175.QtyProductionA = Children(i).Code
   Case "QTYPRODUCTIONX":z0175.QtyProductionX = Children(i).Code
   Case "QTYPRODUCTIONXP":z0175.QtyProductionXP = Children(i).Code
   Case "QTYPRODUCTIONXR":z0175.QtyProductionXR = Children(i).Code
   Case "QTYBLOUT":z0175.QtyBLOut = Children(i).Code
   Case "QTYBLIN":z0175.QtyBLIn = Children(i).Code
   Case "DATEINSERT":z0175.DateInsert = Children(i).Code
   Case "INCHARGEINSERT":z0175.InchargeInsert = Children(i).Code
   Case "DATEUPDATE":z0175.DateUpdate = Children(i).Code
   Case "INCHARGEUPDATE":z0175.InchargeUpdate = Children(i).Code
   Case "CHECKCOMPLETE":z0175.CheckComplete = Children(i).Code
   Case "REMARK":z0175.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "SPECNO":z0175.SpecNo = Children(i).Data
   Case "SPECNOSEQ":z0175.SpecNoSeq = Children(i).Data
   Case "SZNO":z0175.Szno = Children(i).Data
   Case "CDMAINPROCESS":z0175.cdMainProcess = Children(i).Data
   Case "SNO":z0175.Sno = Children(i).Data
   Case "SIZENAME":z0175.SizeName = Children(i).Data
   Case "MATERIALSEQ":z0175.MaterialSeq = Children(i).Data
   Case "BATCHNO":z0175.BatchNo = Children(i).Data
   Case "BATCHGROUP":z0175.BatchGroup = Children(i).Data
   Case "BATCHSHOES":z0175.BatchShoes = Children(i).Data
   Case "TYPEBATCH":z0175.TypeBatch = Children(i).Data
   Case "CDFACTORY":z0175.cdFactory = Children(i).Data
   Case "MACHINECODE":z0175.MachineCode = Children(i).Data
   Case "MACHINETNO":z0175.MachineTno = Children(i).Data
   Case "CDLINEPROD":z0175.cdLineProd = Children(i).Data
   Case "LINETNO":z0175.LineTno = Children(i).Data
   Case "DATEPRINT":z0175.DatePrint = Children(i).Data
   Case "DATEBATCH":z0175.DateBatch = Children(i).Data
   Case "INCHARGEBATCH":z0175.InchargeBatch = Children(i).Data
   Case "INCHARGEPRINT":z0175.InchargePrint = Children(i).Data
   Case "QTYBATCH":z0175.QtyBatch = Children(i).Data
   Case "CHECKL":z0175.CheckL = Children(i).Data
   Case "CHECKR":z0175.CheckR = Children(i).Data
   Case "QTYPRODUCTION":z0175.QtyProduction = Children(i).Data
   Case "QTYPRODUCTIONA":z0175.QtyProductionA = Children(i).Data
   Case "QTYPRODUCTIONX":z0175.QtyProductionX = Children(i).Data
   Case "QTYPRODUCTIONXP":z0175.QtyProductionXP = Children(i).Data
   Case "QTYPRODUCTIONXR":z0175.QtyProductionXR = Children(i).Data
   Case "QTYBLOUT":z0175.QtyBLOut = Children(i).Data
   Case "QTYBLIN":z0175.QtyBLIn = Children(i).Data
   Case "DATEINSERT":z0175.DateInsert = Children(i).Data
   Case "INCHARGEINSERT":z0175.InchargeInsert = Children(i).Data
   Case "DATEUPDATE":z0175.DateUpdate = Children(i).Data
   Case "INCHARGEUPDATE":z0175.InchargeUpdate = Children(i).Data
   Case "CHECKCOMPLETE":z0175.CheckComplete = Children(i).Data
   Case "REMARK":z0175.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K0175_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K0175_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z0175 As T0175_AREA, Job as String, CheckClear as Boolean, SPECNO AS String, SPECNOSEQ AS String, SZNO AS String, CDMAINPROCESS AS String, SNO AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K0175_MOVE = False

Try
    If READ_PFK0175(SPECNO, SPECNOSEQ, SZNO, CDMAINPROCESS, SNO) = True Then
                z0175 = D0175
		K0175_MOVE = True
		else
	If CheckClear  = True then z0175 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK0175")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "SPECNO":z0175.SpecNo = Children(i).Code
   Case "SPECNOSEQ":z0175.SpecNoSeq = Children(i).Code
   Case "SZNO":z0175.Szno = Children(i).Code
   Case "CDMAINPROCESS":z0175.cdMainProcess = Children(i).Code
   Case "SNO":z0175.Sno = Children(i).Code
   Case "SIZENAME":z0175.SizeName = Children(i).Code
   Case "MATERIALSEQ":z0175.MaterialSeq = Children(i).Code
   Case "BATCHNO":z0175.BatchNo = Children(i).Code
   Case "BATCHGROUP":z0175.BatchGroup = Children(i).Code
   Case "BATCHSHOES":z0175.BatchShoes = Children(i).Code
   Case "TYPEBATCH":z0175.TypeBatch = Children(i).Code
   Case "CDFACTORY":z0175.cdFactory = Children(i).Code
   Case "MACHINECODE":z0175.MachineCode = Children(i).Code
   Case "MACHINETNO":z0175.MachineTno = Children(i).Code
   Case "CDLINEPROD":z0175.cdLineProd = Children(i).Code
   Case "LINETNO":z0175.LineTno = Children(i).Code
   Case "DATEPRINT":z0175.DatePrint = Children(i).Code
   Case "DATEBATCH":z0175.DateBatch = Children(i).Code
   Case "INCHARGEBATCH":z0175.InchargeBatch = Children(i).Code
   Case "INCHARGEPRINT":z0175.InchargePrint = Children(i).Code
   Case "QTYBATCH":z0175.QtyBatch = Children(i).Code
   Case "CHECKL":z0175.CheckL = Children(i).Code
   Case "CHECKR":z0175.CheckR = Children(i).Code
   Case "QTYPRODUCTION":z0175.QtyProduction = Children(i).Code
   Case "QTYPRODUCTIONA":z0175.QtyProductionA = Children(i).Code
   Case "QTYPRODUCTIONX":z0175.QtyProductionX = Children(i).Code
   Case "QTYPRODUCTIONXP":z0175.QtyProductionXP = Children(i).Code
   Case "QTYPRODUCTIONXR":z0175.QtyProductionXR = Children(i).Code
   Case "QTYBLOUT":z0175.QtyBLOut = Children(i).Code
   Case "QTYBLIN":z0175.QtyBLIn = Children(i).Code
   Case "DATEINSERT":z0175.DateInsert = Children(i).Code
   Case "INCHARGEINSERT":z0175.InchargeInsert = Children(i).Code
   Case "DATEUPDATE":z0175.DateUpdate = Children(i).Code
   Case "INCHARGEUPDATE":z0175.InchargeUpdate = Children(i).Code
   Case "CHECKCOMPLETE":z0175.CheckComplete = Children(i).Code
   Case "REMARK":z0175.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "SPECNO":z0175.SpecNo = Children(i).Data
   Case "SPECNOSEQ":z0175.SpecNoSeq = Children(i).Data
   Case "SZNO":z0175.Szno = Children(i).Data
   Case "CDMAINPROCESS":z0175.cdMainProcess = Children(i).Data
   Case "SNO":z0175.Sno = Children(i).Data
   Case "SIZENAME":z0175.SizeName = Children(i).Data
   Case "MATERIALSEQ":z0175.MaterialSeq = Children(i).Data
   Case "BATCHNO":z0175.BatchNo = Children(i).Data
   Case "BATCHGROUP":z0175.BatchGroup = Children(i).Data
   Case "BATCHSHOES":z0175.BatchShoes = Children(i).Data
   Case "TYPEBATCH":z0175.TypeBatch = Children(i).Data
   Case "CDFACTORY":z0175.cdFactory = Children(i).Data
   Case "MACHINECODE":z0175.MachineCode = Children(i).Data
   Case "MACHINETNO":z0175.MachineTno = Children(i).Data
   Case "CDLINEPROD":z0175.cdLineProd = Children(i).Data
   Case "LINETNO":z0175.LineTno = Children(i).Data
   Case "DATEPRINT":z0175.DatePrint = Children(i).Data
   Case "DATEBATCH":z0175.DateBatch = Children(i).Data
   Case "INCHARGEBATCH":z0175.InchargeBatch = Children(i).Data
   Case "INCHARGEPRINT":z0175.InchargePrint = Children(i).Data
   Case "QTYBATCH":z0175.QtyBatch = Children(i).Data
   Case "CHECKL":z0175.CheckL = Children(i).Data
   Case "CHECKR":z0175.CheckR = Children(i).Data
   Case "QTYPRODUCTION":z0175.QtyProduction = Children(i).Data
   Case "QTYPRODUCTIONA":z0175.QtyProductionA = Children(i).Data
   Case "QTYPRODUCTIONX":z0175.QtyProductionX = Children(i).Data
   Case "QTYPRODUCTIONXP":z0175.QtyProductionXP = Children(i).Data
   Case "QTYPRODUCTIONXR":z0175.QtyProductionXR = Children(i).Data
   Case "QTYBLOUT":z0175.QtyBLOut = Children(i).Data
   Case "QTYBLIN":z0175.QtyBLIn = Children(i).Data
   Case "DATEINSERT":z0175.DateInsert = Children(i).Data
   Case "INCHARGEINSERT":z0175.InchargeInsert = Children(i).Data
   Case "DATEUPDATE":z0175.DateUpdate = Children(i).Data
   Case "INCHARGEUPDATE":z0175.InchargeUpdate = Children(i).Data
   Case "CHECKCOMPLETE":z0175.CheckComplete = Children(i).Data
   Case "REMARK":z0175.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K0175_MOVE",vbCritical)
End Try
End Function 
    
End Module 
