'=========================================================================================================================================================
'   TABLE : (PFK7306)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7306

Structure T7306_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	ProcessBOMCode	 AS String	'			nvarchar(6)		*
Public 	ProcessBOMSeq	 AS Double	'			decimal		*
Public 	Dseq	 AS Double	'			decimal
Public 	seMainProcess	 AS String	'			char(3)
Public 	cdMainProcess	 AS String	'			char(3)
Public 	seSubProcess	 AS String	'			char(3)
Public 	cdSubProcess	 AS String	'			char(3)
Public 	Description	 AS String	'			nvarchar(200)
Public 	Cost	 AS Double	'			decimal
Public 	Loss	 AS Double	'			decimal
Public 	AMTProcess	 AS Double	'			decimal
Public 	seShoesStatus	 AS String	'			char(3)
Public 	cdShoesStatus	 AS String	'			char(3)
Public 	SupplierCode	 AS String	'			char(6)
Public 	CheckPresscript	 AS String	'			char(1)
Public 	CheckInside	 AS String	'			char(1)
Public 	CheckOutSide	 AS String	'			char(1)
Public 	CheckPurchase	 AS String	'			char(1)
Public 	CheckQuatity	 AS String	'			char(1)
Public 	CheckPrice	 AS String	'			char(1)
Public 	CheckLoss	 AS String	'			char(1)
Public 	CheckTime	 AS String	'			char(1)
Public 	CheckMachine	 AS String	'			char(1)
Public 	seMachineType	 AS String	'			char(3)
Public 	cdMachineType	 AS String	'			char(3)
Public 	Remark	 AS String	'			nvarchar(100)
'=========================================================================================================================================================
End structure

Public D7306 As T7306_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK7306(PROCESSBOMCODE AS String, PROCESSBOMSEQ AS Double) As Boolean
    READ_PFK7306 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7306 "
    SQL = SQL & " WHERE K7306_ProcessBOMCode		 = '" & ProcessBOMCode & "' " 
    SQL = SQL & "   AND K7306_ProcessBOMSeq		 =  " & ProcessBOMSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D7306_CLEAR: GoTo SKIP_READ_PFK7306
                
    Call K7306_MOVE(rd)
    READ_PFK7306 = True

SKIP_READ_PFK7306:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK7306",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK7306(PROCESSBOMCODE AS String, PROCESSBOMSEQ AS Double, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7306 "
    SQL = SQL & " WHERE K7306_ProcessBOMCode		 = '" & ProcessBOMCode & "' " 
    SQL = SQL & "   AND K7306_ProcessBOMSeq		 =  " & ProcessBOMSeq & "  " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK7306",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK7306(z7306 As T7306_AREA) As Boolean
    WRITE_PFK7306 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z7306)
 
    SQL = " INSERT INTO PFK7306 "
    SQL = SQL & " ( "
    SQL = SQL & " K7306_ProcessBOMCode," 
    SQL = SQL & " K7306_ProcessBOMSeq," 
    SQL = SQL & " K7306_Dseq," 
    SQL = SQL & " K7306_seMainProcess," 
    SQL = SQL & " K7306_cdMainProcess," 
    SQL = SQL & " K7306_seSubProcess," 
    SQL = SQL & " K7306_cdSubProcess," 
    SQL = SQL & " K7306_Description," 
    SQL = SQL & " K7306_Cost," 
    SQL = SQL & " K7306_Loss," 
    SQL = SQL & " K7306_AMTProcess," 
    SQL = SQL & " K7306_seShoesStatus," 
    SQL = SQL & " K7306_cdShoesStatus," 
    SQL = SQL & " K7306_SupplierCode," 
    SQL = SQL & " K7306_CheckPresscript," 
    SQL = SQL & " K7306_CheckInside," 
    SQL = SQL & " K7306_CheckOutSide," 
    SQL = SQL & " K7306_CheckPurchase," 
    SQL = SQL & " K7306_CheckQuatity," 
    SQL = SQL & " K7306_CheckPrice," 
    SQL = SQL & " K7306_CheckLoss," 
    SQL = SQL & " K7306_CheckTime," 
    SQL = SQL & " K7306_CheckMachine," 
    SQL = SQL & " K7306_seMachineType," 
    SQL = SQL & " K7306_cdMachineType," 
    SQL = SQL & " K7306_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z7306.ProcessBOMCode) & "', "  
    SQL = SQL & "   " & FormatSQL(z7306.ProcessBOMSeq) & ", "  
    SQL = SQL & "   " & FormatSQL(z7306.Dseq) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z7306.seMainProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7306.cdMainProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7306.seSubProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7306.cdSubProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7306.Description) & "', "  
    SQL = SQL & "   " & FormatSQL(z7306.Cost) & ", "  
    SQL = SQL & "   " & FormatSQL(z7306.Loss) & ", "  
    SQL = SQL & "   " & FormatSQL(z7306.AMTProcess) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z7306.seShoesStatus) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7306.cdShoesStatus) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7306.SupplierCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7306.CheckPresscript) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7306.CheckInside) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7306.CheckOutSide) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7306.CheckPurchase) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7306.CheckQuatity) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7306.CheckPrice) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7306.CheckLoss) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7306.CheckTime) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7306.CheckMachine) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7306.seMachineType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7306.cdMachineType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7306.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK7306 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK7306",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK7306(z7306 As T7306_AREA) As Boolean
    REWRITE_PFK7306 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7306)
   
    SQL = " UPDATE PFK7306 SET "
    SQL = SQL & "    K7306_Dseq      =  " & FormatSQL(z7306.Dseq) & ", " 
    SQL = SQL & "    K7306_seMainProcess      = N'" & FormatSQL(z7306.seMainProcess) & "', " 
    SQL = SQL & "    K7306_cdMainProcess      = N'" & FormatSQL(z7306.cdMainProcess) & "', " 
    SQL = SQL & "    K7306_seSubProcess      = N'" & FormatSQL(z7306.seSubProcess) & "', " 
    SQL = SQL & "    K7306_cdSubProcess      = N'" & FormatSQL(z7306.cdSubProcess) & "', " 
    SQL = SQL & "    K7306_Description      = N'" & FormatSQL(z7306.Description) & "', " 
    SQL = SQL & "    K7306_Cost      =  " & FormatSQL(z7306.Cost) & ", " 
    SQL = SQL & "    K7306_Loss      =  " & FormatSQL(z7306.Loss) & ", " 
    SQL = SQL & "    K7306_AMTProcess      =  " & FormatSQL(z7306.AMTProcess) & ", " 
    SQL = SQL & "    K7306_seShoesStatus      = N'" & FormatSQL(z7306.seShoesStatus) & "', " 
    SQL = SQL & "    K7306_cdShoesStatus      = N'" & FormatSQL(z7306.cdShoesStatus) & "', " 
    SQL = SQL & "    K7306_SupplierCode      = N'" & FormatSQL(z7306.SupplierCode) & "', " 
    SQL = SQL & "    K7306_CheckPresscript      = N'" & FormatSQL(z7306.CheckPresscript) & "', " 
    SQL = SQL & "    K7306_CheckInside      = N'" & FormatSQL(z7306.CheckInside) & "', " 
    SQL = SQL & "    K7306_CheckOutSide      = N'" & FormatSQL(z7306.CheckOutSide) & "', " 
    SQL = SQL & "    K7306_CheckPurchase      = N'" & FormatSQL(z7306.CheckPurchase) & "', " 
    SQL = SQL & "    K7306_CheckQuatity      = N'" & FormatSQL(z7306.CheckQuatity) & "', " 
    SQL = SQL & "    K7306_CheckPrice      = N'" & FormatSQL(z7306.CheckPrice) & "', " 
    SQL = SQL & "    K7306_CheckLoss      = N'" & FormatSQL(z7306.CheckLoss) & "', " 
    SQL = SQL & "    K7306_CheckTime      = N'" & FormatSQL(z7306.CheckTime) & "', " 
    SQL = SQL & "    K7306_CheckMachine      = N'" & FormatSQL(z7306.CheckMachine) & "', " 
    SQL = SQL & "    K7306_seMachineType      = N'" & FormatSQL(z7306.seMachineType) & "', " 
    SQL = SQL & "    K7306_cdMachineType      = N'" & FormatSQL(z7306.cdMachineType) & "', " 
    SQL = SQL & "    K7306_Remark      = N'" & FormatSQL(z7306.Remark) & "'  " 
    SQL = SQL & " WHERE K7306_ProcessBOMCode		 = '" & z7306.ProcessBOMCode & "' " 
    SQL = SQL & "   AND K7306_ProcessBOMSeq		 =  " & z7306.ProcessBOMSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK7306 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK7306",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK7306(z7306 As T7306_AREA) As Boolean
    DELETE_PFK7306 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK7306 "
    SQL = SQL & " WHERE K7306_ProcessBOMCode		 = '" & z7306.ProcessBOMCode & "' " 
    SQL = SQL & "   AND K7306_ProcessBOMSeq		 =  " & z7306.ProcessBOMSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK7306 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK7306",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D7306_CLEAR()
Try
    
   D7306.ProcessBOMCode = ""
    D7306.ProcessBOMSeq = 0 
    D7306.Dseq = 0 
   D7306.seMainProcess = ""
   D7306.cdMainProcess = ""
   D7306.seSubProcess = ""
   D7306.cdSubProcess = ""
   D7306.Description = ""
    D7306.Cost = 0 
    D7306.Loss = 0 
    D7306.AMTProcess = 0 
   D7306.seShoesStatus = ""
   D7306.cdShoesStatus = ""
   D7306.SupplierCode = ""
   D7306.CheckPresscript = ""
   D7306.CheckInside = ""
   D7306.CheckOutSide = ""
   D7306.CheckPurchase = ""
   D7306.CheckQuatity = ""
   D7306.CheckPrice = ""
   D7306.CheckLoss = ""
   D7306.CheckTime = ""
   D7306.CheckMachine = ""
   D7306.seMachineType = ""
   D7306.cdMachineType = ""
   D7306.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D7306_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x7306 As T7306_AREA)
Try
    
    x7306.ProcessBOMCode = trim$(  x7306.ProcessBOMCode)
    x7306.ProcessBOMSeq = trim$(  x7306.ProcessBOMSeq)
    x7306.Dseq = trim$(  x7306.Dseq)
    x7306.seMainProcess = trim$(  x7306.seMainProcess)
    x7306.cdMainProcess = trim$(  x7306.cdMainProcess)
    x7306.seSubProcess = trim$(  x7306.seSubProcess)
    x7306.cdSubProcess = trim$(  x7306.cdSubProcess)
    x7306.Description = trim$(  x7306.Description)
    x7306.Cost = trim$(  x7306.Cost)
    x7306.Loss = trim$(  x7306.Loss)
    x7306.AMTProcess = trim$(  x7306.AMTProcess)
    x7306.seShoesStatus = trim$(  x7306.seShoesStatus)
    x7306.cdShoesStatus = trim$(  x7306.cdShoesStatus)
    x7306.SupplierCode = trim$(  x7306.SupplierCode)
    x7306.CheckPresscript = trim$(  x7306.CheckPresscript)
    x7306.CheckInside = trim$(  x7306.CheckInside)
    x7306.CheckOutSide = trim$(  x7306.CheckOutSide)
    x7306.CheckPurchase = trim$(  x7306.CheckPurchase)
    x7306.CheckQuatity = trim$(  x7306.CheckQuatity)
    x7306.CheckPrice = trim$(  x7306.CheckPrice)
    x7306.CheckLoss = trim$(  x7306.CheckLoss)
    x7306.CheckTime = trim$(  x7306.CheckTime)
    x7306.CheckMachine = trim$(  x7306.CheckMachine)
    x7306.seMachineType = trim$(  x7306.seMachineType)
    x7306.cdMachineType = trim$(  x7306.cdMachineType)
    x7306.Remark = trim$(  x7306.Remark)
     
    If trim$( x7306.ProcessBOMCode ) = "" Then x7306.ProcessBOMCode = Space(1) 
    If trim$( x7306.ProcessBOMSeq ) = "" Then x7306.ProcessBOMSeq = 0 
    If trim$( x7306.Dseq ) = "" Then x7306.Dseq = 0 
    If trim$( x7306.seMainProcess ) = "" Then x7306.seMainProcess = Space(1) 
    If trim$( x7306.cdMainProcess ) = "" Then x7306.cdMainProcess = Space(1) 
    If trim$( x7306.seSubProcess ) = "" Then x7306.seSubProcess = Space(1) 
    If trim$( x7306.cdSubProcess ) = "" Then x7306.cdSubProcess = Space(1) 
    If trim$( x7306.Description ) = "" Then x7306.Description = Space(1) 
    If trim$( x7306.Cost ) = "" Then x7306.Cost = 0 
    If trim$( x7306.Loss ) = "" Then x7306.Loss = 0 
    If trim$( x7306.AMTProcess ) = "" Then x7306.AMTProcess = 0 
    If trim$( x7306.seShoesStatus ) = "" Then x7306.seShoesStatus = Space(1) 
    If trim$( x7306.cdShoesStatus ) = "" Then x7306.cdShoesStatus = Space(1) 
    If trim$( x7306.SupplierCode ) = "" Then x7306.SupplierCode = Space(1) 
    If trim$( x7306.CheckPresscript ) = "" Then x7306.CheckPresscript = Space(1) 
    If trim$( x7306.CheckInside ) = "" Then x7306.CheckInside = Space(1) 
    If trim$( x7306.CheckOutSide ) = "" Then x7306.CheckOutSide = Space(1) 
    If trim$( x7306.CheckPurchase ) = "" Then x7306.CheckPurchase = Space(1) 
    If trim$( x7306.CheckQuatity ) = "" Then x7306.CheckQuatity = Space(1) 
    If trim$( x7306.CheckPrice ) = "" Then x7306.CheckPrice = Space(1) 
    If trim$( x7306.CheckLoss ) = "" Then x7306.CheckLoss = Space(1) 
    If trim$( x7306.CheckTime ) = "" Then x7306.CheckTime = Space(1) 
    If trim$( x7306.CheckMachine ) = "" Then x7306.CheckMachine = Space(1) 
    If trim$( x7306.seMachineType ) = "" Then x7306.seMachineType = Space(1) 
    If trim$( x7306.cdMachineType ) = "" Then x7306.cdMachineType = Space(1) 
    If trim$( x7306.Remark ) = "" Then x7306.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K7306_MOVE(rs7306 As SqlClient.SqlDataReader)
Try

    call D7306_CLEAR()   

    If IsdbNull(rs7306!K7306_ProcessBOMCode) = False Then D7306.ProcessBOMCode = Trim$(rs7306!K7306_ProcessBOMCode)
    If IsdbNull(rs7306!K7306_ProcessBOMSeq) = False Then D7306.ProcessBOMSeq = Trim$(rs7306!K7306_ProcessBOMSeq)
    If IsdbNull(rs7306!K7306_Dseq) = False Then D7306.Dseq = Trim$(rs7306!K7306_Dseq)
    If IsdbNull(rs7306!K7306_seMainProcess) = False Then D7306.seMainProcess = Trim$(rs7306!K7306_seMainProcess)
    If IsdbNull(rs7306!K7306_cdMainProcess) = False Then D7306.cdMainProcess = Trim$(rs7306!K7306_cdMainProcess)
    If IsdbNull(rs7306!K7306_seSubProcess) = False Then D7306.seSubProcess = Trim$(rs7306!K7306_seSubProcess)
    If IsdbNull(rs7306!K7306_cdSubProcess) = False Then D7306.cdSubProcess = Trim$(rs7306!K7306_cdSubProcess)
    If IsdbNull(rs7306!K7306_Description) = False Then D7306.Description = Trim$(rs7306!K7306_Description)
    If IsdbNull(rs7306!K7306_Cost) = False Then D7306.Cost = Trim$(rs7306!K7306_Cost)
    If IsdbNull(rs7306!K7306_Loss) = False Then D7306.Loss = Trim$(rs7306!K7306_Loss)
    If IsdbNull(rs7306!K7306_AMTProcess) = False Then D7306.AMTProcess = Trim$(rs7306!K7306_AMTProcess)
    If IsdbNull(rs7306!K7306_seShoesStatus) = False Then D7306.seShoesStatus = Trim$(rs7306!K7306_seShoesStatus)
    If IsdbNull(rs7306!K7306_cdShoesStatus) = False Then D7306.cdShoesStatus = Trim$(rs7306!K7306_cdShoesStatus)
    If IsdbNull(rs7306!K7306_SupplierCode) = False Then D7306.SupplierCode = Trim$(rs7306!K7306_SupplierCode)
    If IsdbNull(rs7306!K7306_CheckPresscript) = False Then D7306.CheckPresscript = Trim$(rs7306!K7306_CheckPresscript)
    If IsdbNull(rs7306!K7306_CheckInside) = False Then D7306.CheckInside = Trim$(rs7306!K7306_CheckInside)
    If IsdbNull(rs7306!K7306_CheckOutSide) = False Then D7306.CheckOutSide = Trim$(rs7306!K7306_CheckOutSide)
    If IsdbNull(rs7306!K7306_CheckPurchase) = False Then D7306.CheckPurchase = Trim$(rs7306!K7306_CheckPurchase)
    If IsdbNull(rs7306!K7306_CheckQuatity) = False Then D7306.CheckQuatity = Trim$(rs7306!K7306_CheckQuatity)
    If IsdbNull(rs7306!K7306_CheckPrice) = False Then D7306.CheckPrice = Trim$(rs7306!K7306_CheckPrice)
    If IsdbNull(rs7306!K7306_CheckLoss) = False Then D7306.CheckLoss = Trim$(rs7306!K7306_CheckLoss)
    If IsdbNull(rs7306!K7306_CheckTime) = False Then D7306.CheckTime = Trim$(rs7306!K7306_CheckTime)
    If IsdbNull(rs7306!K7306_CheckMachine) = False Then D7306.CheckMachine = Trim$(rs7306!K7306_CheckMachine)
    If IsdbNull(rs7306!K7306_seMachineType) = False Then D7306.seMachineType = Trim$(rs7306!K7306_seMachineType)
    If IsdbNull(rs7306!K7306_cdMachineType) = False Then D7306.cdMachineType = Trim$(rs7306!K7306_cdMachineType)
    If IsdbNull(rs7306!K7306_Remark) = False Then D7306.Remark = Trim$(rs7306!K7306_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7306_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K7306_MOVE(rs7306 As DataRow)
Try

    call D7306_CLEAR()   

    If IsdbNull(rs7306!K7306_ProcessBOMCode) = False Then D7306.ProcessBOMCode = Trim$(rs7306!K7306_ProcessBOMCode)
    If IsdbNull(rs7306!K7306_ProcessBOMSeq) = False Then D7306.ProcessBOMSeq = Trim$(rs7306!K7306_ProcessBOMSeq)
    If IsdbNull(rs7306!K7306_Dseq) = False Then D7306.Dseq = Trim$(rs7306!K7306_Dseq)
    If IsdbNull(rs7306!K7306_seMainProcess) = False Then D7306.seMainProcess = Trim$(rs7306!K7306_seMainProcess)
    If IsdbNull(rs7306!K7306_cdMainProcess) = False Then D7306.cdMainProcess = Trim$(rs7306!K7306_cdMainProcess)
    If IsdbNull(rs7306!K7306_seSubProcess) = False Then D7306.seSubProcess = Trim$(rs7306!K7306_seSubProcess)
    If IsdbNull(rs7306!K7306_cdSubProcess) = False Then D7306.cdSubProcess = Trim$(rs7306!K7306_cdSubProcess)
    If IsdbNull(rs7306!K7306_Description) = False Then D7306.Description = Trim$(rs7306!K7306_Description)
    If IsdbNull(rs7306!K7306_Cost) = False Then D7306.Cost = Trim$(rs7306!K7306_Cost)
    If IsdbNull(rs7306!K7306_Loss) = False Then D7306.Loss = Trim$(rs7306!K7306_Loss)
    If IsdbNull(rs7306!K7306_AMTProcess) = False Then D7306.AMTProcess = Trim$(rs7306!K7306_AMTProcess)
    If IsdbNull(rs7306!K7306_seShoesStatus) = False Then D7306.seShoesStatus = Trim$(rs7306!K7306_seShoesStatus)
    If IsdbNull(rs7306!K7306_cdShoesStatus) = False Then D7306.cdShoesStatus = Trim$(rs7306!K7306_cdShoesStatus)
    If IsdbNull(rs7306!K7306_SupplierCode) = False Then D7306.SupplierCode = Trim$(rs7306!K7306_SupplierCode)
    If IsdbNull(rs7306!K7306_CheckPresscript) = False Then D7306.CheckPresscript = Trim$(rs7306!K7306_CheckPresscript)
    If IsdbNull(rs7306!K7306_CheckInside) = False Then D7306.CheckInside = Trim$(rs7306!K7306_CheckInside)
    If IsdbNull(rs7306!K7306_CheckOutSide) = False Then D7306.CheckOutSide = Trim$(rs7306!K7306_CheckOutSide)
    If IsdbNull(rs7306!K7306_CheckPurchase) = False Then D7306.CheckPurchase = Trim$(rs7306!K7306_CheckPurchase)
    If IsdbNull(rs7306!K7306_CheckQuatity) = False Then D7306.CheckQuatity = Trim$(rs7306!K7306_CheckQuatity)
    If IsdbNull(rs7306!K7306_CheckPrice) = False Then D7306.CheckPrice = Trim$(rs7306!K7306_CheckPrice)
    If IsdbNull(rs7306!K7306_CheckLoss) = False Then D7306.CheckLoss = Trim$(rs7306!K7306_CheckLoss)
    If IsdbNull(rs7306!K7306_CheckTime) = False Then D7306.CheckTime = Trim$(rs7306!K7306_CheckTime)
    If IsdbNull(rs7306!K7306_CheckMachine) = False Then D7306.CheckMachine = Trim$(rs7306!K7306_CheckMachine)
    If IsdbNull(rs7306!K7306_seMachineType) = False Then D7306.seMachineType = Trim$(rs7306!K7306_seMachineType)
    If IsdbNull(rs7306!K7306_cdMachineType) = False Then D7306.cdMachineType = Trim$(rs7306!K7306_cdMachineType)
    If IsdbNull(rs7306!K7306_Remark) = False Then D7306.Remark = Trim$(rs7306!K7306_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7306_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K7306_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7306 As T7306_AREA, PROCESSBOMCODE AS String, PROCESSBOMSEQ AS Double) as Boolean

K7306_MOVE = False

Try
    If READ_PFK7306(PROCESSBOMCODE, PROCESSBOMSEQ) = True Then
                z7306 = D7306
		K7306_MOVE = True
		else
	z7306 = nothing
     End If

     If  getColumIndex(spr,"ProcessBOMCode") > -1 then z7306.ProcessBOMCode = getDataM(spr, getColumIndex(spr,"ProcessBOMCode"), xRow)
     If  getColumIndex(spr,"ProcessBOMSeq") > -1 then z7306.ProcessBOMSeq = getDataM(spr, getColumIndex(spr,"ProcessBOMSeq"), xRow)
     If  getColumIndex(spr,"Dseq") > -1 then z7306.Dseq = getDataM(spr, getColumIndex(spr,"Dseq"), xRow)
     If  getColumIndex(spr,"seMainProcess") > -1 then z7306.seMainProcess = getDataM(spr, getColumIndex(spr,"seMainProcess"), xRow)
     If  getColumIndex(spr,"cdMainProcess") > -1 then z7306.cdMainProcess = getDataM(spr, getColumIndex(spr,"cdMainProcess"), xRow)
     If  getColumIndex(spr,"seSubProcess") > -1 then z7306.seSubProcess = getDataM(spr, getColumIndex(spr,"seSubProcess"), xRow)
     If  getColumIndex(spr,"cdSubProcess") > -1 then z7306.cdSubProcess = getDataM(spr, getColumIndex(spr,"cdSubProcess"), xRow)
     If  getColumIndex(spr,"Description") > -1 then z7306.Description = getDataM(spr, getColumIndex(spr,"Description"), xRow)
     If  getColumIndex(spr,"Cost") > -1 then z7306.Cost = getDataM(spr, getColumIndex(spr,"Cost"), xRow)
     If  getColumIndex(spr,"Loss") > -1 then z7306.Loss = getDataM(spr, getColumIndex(spr,"Loss"), xRow)
     If  getColumIndex(spr,"AMTProcess") > -1 then z7306.AMTProcess = getDataM(spr, getColumIndex(spr,"AMTProcess"), xRow)
     If  getColumIndex(spr,"seShoesStatus") > -1 then z7306.seShoesStatus = getDataM(spr, getColumIndex(spr,"seShoesStatus"), xRow)
     If  getColumIndex(spr,"cdShoesStatus") > -1 then z7306.cdShoesStatus = getDataM(spr, getColumIndex(spr,"cdShoesStatus"), xRow)
     If  getColumIndex(spr,"SupplierCode") > -1 then z7306.SupplierCode = getDataM(spr, getColumIndex(spr,"SupplierCode"), xRow)
     If  getColumIndex(spr,"CheckPresscript") > -1 then z7306.CheckPresscript = getDataM(spr, getColumIndex(spr,"CheckPresscript"), xRow)
     If  getColumIndex(spr,"CheckInside") > -1 then z7306.CheckInside = getDataM(spr, getColumIndex(spr,"CheckInside"), xRow)
     If  getColumIndex(spr,"CheckOutSide") > -1 then z7306.CheckOutSide = getDataM(spr, getColumIndex(spr,"CheckOutSide"), xRow)
     If  getColumIndex(spr,"CheckPurchase") > -1 then z7306.CheckPurchase = getDataM(spr, getColumIndex(spr,"CheckPurchase"), xRow)
     If  getColumIndex(spr,"CheckQuatity") > -1 then z7306.CheckQuatity = getDataM(spr, getColumIndex(spr,"CheckQuatity"), xRow)
     If  getColumIndex(spr,"CheckPrice") > -1 then z7306.CheckPrice = getDataM(spr, getColumIndex(spr,"CheckPrice"), xRow)
     If  getColumIndex(spr,"CheckLoss") > -1 then z7306.CheckLoss = getDataM(spr, getColumIndex(spr,"CheckLoss"), xRow)
     If  getColumIndex(spr,"CheckTime") > -1 then z7306.CheckTime = getDataM(spr, getColumIndex(spr,"CheckTime"), xRow)
     If  getColumIndex(spr,"CheckMachine") > -1 then z7306.CheckMachine = getDataM(spr, getColumIndex(spr,"CheckMachine"), xRow)
     If  getColumIndex(spr,"seMachineType") > -1 then z7306.seMachineType = getDataM(spr, getColumIndex(spr,"seMachineType"), xRow)
     If  getColumIndex(spr,"cdMachineType") > -1 then z7306.cdMachineType = getDataM(spr, getColumIndex(spr,"cdMachineType"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7306.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7306_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K7306_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7306 As T7306_AREA,CheckClear as Boolean,PROCESSBOMCODE AS String, PROCESSBOMSEQ AS Double) as Boolean

K7306_MOVE = False

Try
    If READ_PFK7306(PROCESSBOMCODE, PROCESSBOMSEQ) = True Then
                z7306 = D7306
		K7306_MOVE = True
		else
	If CheckClear  = True then z7306 = nothing
     End If

     If  getColumIndex(spr,"ProcessBOMCode") > -1 then z7306.ProcessBOMCode = getDataM(spr, getColumIndex(spr,"ProcessBOMCode"), xRow)
     If  getColumIndex(spr,"ProcessBOMSeq") > -1 then z7306.ProcessBOMSeq = getDataM(spr, getColumIndex(spr,"ProcessBOMSeq"), xRow)
     If  getColumIndex(spr,"Dseq") > -1 then z7306.Dseq = getDataM(spr, getColumIndex(spr,"Dseq"), xRow)
     If  getColumIndex(spr,"seMainProcess") > -1 then z7306.seMainProcess = getDataM(spr, getColumIndex(spr,"seMainProcess"), xRow)
     If  getColumIndex(spr,"cdMainProcess") > -1 then z7306.cdMainProcess = getDataM(spr, getColumIndex(spr,"cdMainProcess"), xRow)
     If  getColumIndex(spr,"seSubProcess") > -1 then z7306.seSubProcess = getDataM(spr, getColumIndex(spr,"seSubProcess"), xRow)
     If  getColumIndex(spr,"cdSubProcess") > -1 then z7306.cdSubProcess = getDataM(spr, getColumIndex(spr,"cdSubProcess"), xRow)
     If  getColumIndex(spr,"Description") > -1 then z7306.Description = getDataM(spr, getColumIndex(spr,"Description"), xRow)
     If  getColumIndex(spr,"Cost") > -1 then z7306.Cost = getDataM(spr, getColumIndex(spr,"Cost"), xRow)
     If  getColumIndex(spr,"Loss") > -1 then z7306.Loss = getDataM(spr, getColumIndex(spr,"Loss"), xRow)
     If  getColumIndex(spr,"AMTProcess") > -1 then z7306.AMTProcess = getDataM(spr, getColumIndex(spr,"AMTProcess"), xRow)
     If  getColumIndex(spr,"seShoesStatus") > -1 then z7306.seShoesStatus = getDataM(spr, getColumIndex(spr,"seShoesStatus"), xRow)
     If  getColumIndex(spr,"cdShoesStatus") > -1 then z7306.cdShoesStatus = getDataM(spr, getColumIndex(spr,"cdShoesStatus"), xRow)
     If  getColumIndex(spr,"SupplierCode") > -1 then z7306.SupplierCode = getDataM(spr, getColumIndex(spr,"SupplierCode"), xRow)
     If  getColumIndex(spr,"CheckPresscript") > -1 then z7306.CheckPresscript = getDataM(spr, getColumIndex(spr,"CheckPresscript"), xRow)
     If  getColumIndex(spr,"CheckInside") > -1 then z7306.CheckInside = getDataM(spr, getColumIndex(spr,"CheckInside"), xRow)
     If  getColumIndex(spr,"CheckOutSide") > -1 then z7306.CheckOutSide = getDataM(spr, getColumIndex(spr,"CheckOutSide"), xRow)
     If  getColumIndex(spr,"CheckPurchase") > -1 then z7306.CheckPurchase = getDataM(spr, getColumIndex(spr,"CheckPurchase"), xRow)
     If  getColumIndex(spr,"CheckQuatity") > -1 then z7306.CheckQuatity = getDataM(spr, getColumIndex(spr,"CheckQuatity"), xRow)
     If  getColumIndex(spr,"CheckPrice") > -1 then z7306.CheckPrice = getDataM(spr, getColumIndex(spr,"CheckPrice"), xRow)
     If  getColumIndex(spr,"CheckLoss") > -1 then z7306.CheckLoss = getDataM(spr, getColumIndex(spr,"CheckLoss"), xRow)
     If  getColumIndex(spr,"CheckTime") > -1 then z7306.CheckTime = getDataM(spr, getColumIndex(spr,"CheckTime"), xRow)
     If  getColumIndex(spr,"CheckMachine") > -1 then z7306.CheckMachine = getDataM(spr, getColumIndex(spr,"CheckMachine"), xRow)
     If  getColumIndex(spr,"seMachineType") > -1 then z7306.seMachineType = getDataM(spr, getColumIndex(spr,"seMachineType"), xRow)
     If  getColumIndex(spr,"cdMachineType") > -1 then z7306.cdMachineType = getDataM(spr, getColumIndex(spr,"cdMachineType"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7306.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7306_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K7306_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7306 As T7306_AREA, Job as String, PROCESSBOMCODE AS String, PROCESSBOMSEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7306_MOVE = False

Try
    If READ_PFK7306(PROCESSBOMCODE, PROCESSBOMSEQ) = True Then
                z7306 = D7306
		K7306_MOVE = True
		else
	z7306 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7306")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "PROCESSBOMCODE":z7306.ProcessBOMCode = Children(i).Code
   Case "PROCESSBOMSEQ":z7306.ProcessBOMSeq = Children(i).Code
   Case "DSEQ":z7306.Dseq = Children(i).Code
   Case "SEMAINPROCESS":z7306.seMainProcess = Children(i).Code
   Case "CDMAINPROCESS":z7306.cdMainProcess = Children(i).Code
   Case "SESUBPROCESS":z7306.seSubProcess = Children(i).Code
   Case "CDSUBPROCESS":z7306.cdSubProcess = Children(i).Code
   Case "DESCRIPTION":z7306.Description = Children(i).Code
   Case "COST":z7306.Cost = Children(i).Code
   Case "LOSS":z7306.Loss = Children(i).Code
   Case "AMTPROCESS":z7306.AMTProcess = Children(i).Code
   Case "SESHOESSTATUS":z7306.seShoesStatus = Children(i).Code
   Case "CDSHOESSTATUS":z7306.cdShoesStatus = Children(i).Code
   Case "SUPPLIERCODE":z7306.SupplierCode = Children(i).Code
   Case "CHECKPRESSCRIPT":z7306.CheckPresscript = Children(i).Code
   Case "CHECKINSIDE":z7306.CheckInside = Children(i).Code
   Case "CHECKOUTSIDE":z7306.CheckOutSide = Children(i).Code
   Case "CHECKPURCHASE":z7306.CheckPurchase = Children(i).Code
   Case "CHECKQUATITY":z7306.CheckQuatity = Children(i).Code
   Case "CHECKPRICE":z7306.CheckPrice = Children(i).Code
   Case "CHECKLOSS":z7306.CheckLoss = Children(i).Code
   Case "CHECKTIME":z7306.CheckTime = Children(i).Code
   Case "CHECKMACHINE":z7306.CheckMachine = Children(i).Code
   Case "SEMACHINETYPE":z7306.seMachineType = Children(i).Code
   Case "CDMACHINETYPE":z7306.cdMachineType = Children(i).Code
   Case "REMARK":z7306.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "PROCESSBOMCODE":z7306.ProcessBOMCode = Children(i).Data
   Case "PROCESSBOMSEQ":z7306.ProcessBOMSeq = Children(i).Data
   Case "DSEQ":z7306.Dseq = Children(i).Data
   Case "SEMAINPROCESS":z7306.seMainProcess = Children(i).Data
   Case "CDMAINPROCESS":z7306.cdMainProcess = Children(i).Data
   Case "SESUBPROCESS":z7306.seSubProcess = Children(i).Data
   Case "CDSUBPROCESS":z7306.cdSubProcess = Children(i).Data
   Case "DESCRIPTION":z7306.Description = Children(i).Data
   Case "COST":z7306.Cost = Children(i).Data
   Case "LOSS":z7306.Loss = Children(i).Data
   Case "AMTPROCESS":z7306.AMTProcess = Children(i).Data
   Case "SESHOESSTATUS":z7306.seShoesStatus = Children(i).Data
   Case "CDSHOESSTATUS":z7306.cdShoesStatus = Children(i).Data
   Case "SUPPLIERCODE":z7306.SupplierCode = Children(i).Data
   Case "CHECKPRESSCRIPT":z7306.CheckPresscript = Children(i).Data
   Case "CHECKINSIDE":z7306.CheckInside = Children(i).Data
   Case "CHECKOUTSIDE":z7306.CheckOutSide = Children(i).Data
   Case "CHECKPURCHASE":z7306.CheckPurchase = Children(i).Data
   Case "CHECKQUATITY":z7306.CheckQuatity = Children(i).Data
   Case "CHECKPRICE":z7306.CheckPrice = Children(i).Data
   Case "CHECKLOSS":z7306.CheckLoss = Children(i).Data
   Case "CHECKTIME":z7306.CheckTime = Children(i).Data
   Case "CHECKMACHINE":z7306.CheckMachine = Children(i).Data
   Case "SEMACHINETYPE":z7306.seMachineType = Children(i).Data
   Case "CDMACHINETYPE":z7306.cdMachineType = Children(i).Data
   Case "REMARK":z7306.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7306_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K7306_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7306 As T7306_AREA, Job as String, CheckClear as Boolean, PROCESSBOMCODE AS String, PROCESSBOMSEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7306_MOVE = False

Try
    If READ_PFK7306(PROCESSBOMCODE, PROCESSBOMSEQ) = True Then
                z7306 = D7306
		K7306_MOVE = True
		else
	If CheckClear  = True then z7306 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7306")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "PROCESSBOMCODE":z7306.ProcessBOMCode = Children(i).Code
   Case "PROCESSBOMSEQ":z7306.ProcessBOMSeq = Children(i).Code
   Case "DSEQ":z7306.Dseq = Children(i).Code
   Case "SEMAINPROCESS":z7306.seMainProcess = Children(i).Code
   Case "CDMAINPROCESS":z7306.cdMainProcess = Children(i).Code
   Case "SESUBPROCESS":z7306.seSubProcess = Children(i).Code
   Case "CDSUBPROCESS":z7306.cdSubProcess = Children(i).Code
   Case "DESCRIPTION":z7306.Description = Children(i).Code
   Case "COST":z7306.Cost = Children(i).Code
   Case "LOSS":z7306.Loss = Children(i).Code
   Case "AMTPROCESS":z7306.AMTProcess = Children(i).Code
   Case "SESHOESSTATUS":z7306.seShoesStatus = Children(i).Code
   Case "CDSHOESSTATUS":z7306.cdShoesStatus = Children(i).Code
   Case "SUPPLIERCODE":z7306.SupplierCode = Children(i).Code
   Case "CHECKPRESSCRIPT":z7306.CheckPresscript = Children(i).Code
   Case "CHECKINSIDE":z7306.CheckInside = Children(i).Code
   Case "CHECKOUTSIDE":z7306.CheckOutSide = Children(i).Code
   Case "CHECKPURCHASE":z7306.CheckPurchase = Children(i).Code
   Case "CHECKQUATITY":z7306.CheckQuatity = Children(i).Code
   Case "CHECKPRICE":z7306.CheckPrice = Children(i).Code
   Case "CHECKLOSS":z7306.CheckLoss = Children(i).Code
   Case "CHECKTIME":z7306.CheckTime = Children(i).Code
   Case "CHECKMACHINE":z7306.CheckMachine = Children(i).Code
   Case "SEMACHINETYPE":z7306.seMachineType = Children(i).Code
   Case "CDMACHINETYPE":z7306.cdMachineType = Children(i).Code
   Case "REMARK":z7306.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "PROCESSBOMCODE":z7306.ProcessBOMCode = Children(i).Data
   Case "PROCESSBOMSEQ":z7306.ProcessBOMSeq = Children(i).Data
   Case "DSEQ":z7306.Dseq = Children(i).Data
   Case "SEMAINPROCESS":z7306.seMainProcess = Children(i).Data
   Case "CDMAINPROCESS":z7306.cdMainProcess = Children(i).Data
   Case "SESUBPROCESS":z7306.seSubProcess = Children(i).Data
   Case "CDSUBPROCESS":z7306.cdSubProcess = Children(i).Data
   Case "DESCRIPTION":z7306.Description = Children(i).Data
   Case "COST":z7306.Cost = Children(i).Data
   Case "LOSS":z7306.Loss = Children(i).Data
   Case "AMTPROCESS":z7306.AMTProcess = Children(i).Data
   Case "SESHOESSTATUS":z7306.seShoesStatus = Children(i).Data
   Case "CDSHOESSTATUS":z7306.cdShoesStatus = Children(i).Data
   Case "SUPPLIERCODE":z7306.SupplierCode = Children(i).Data
   Case "CHECKPRESSCRIPT":z7306.CheckPresscript = Children(i).Data
   Case "CHECKINSIDE":z7306.CheckInside = Children(i).Data
   Case "CHECKOUTSIDE":z7306.CheckOutSide = Children(i).Data
   Case "CHECKPURCHASE":z7306.CheckPurchase = Children(i).Data
   Case "CHECKQUATITY":z7306.CheckQuatity = Children(i).Data
   Case "CHECKPRICE":z7306.CheckPrice = Children(i).Data
   Case "CHECKLOSS":z7306.CheckLoss = Children(i).Data
   Case "CHECKTIME":z7306.CheckTime = Children(i).Data
   Case "CHECKMACHINE":z7306.CheckMachine = Children(i).Data
   Case "SEMACHINETYPE":z7306.seMachineType = Children(i).Data
   Case "CDMACHINETYPE":z7306.cdMachineType = Children(i).Data
   Case "REMARK":z7306.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7306_MOVE",vbCritical)
End Try
End Function 
    
End Module 
