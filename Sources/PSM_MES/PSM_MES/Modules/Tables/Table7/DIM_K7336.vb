'=========================================================================================================================================================
'   TABLE : (PFK7336)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7336

Structure T7336_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	ProcessBOMCode	 AS String	'			nvarchar(6)		*
Public 	ProcessBOMSeq	 AS Double	'			decimal		*
Public 	GroupComponentBOM	 AS String	'			char(6)
Public 	GroupComponentSeq	 AS Double	'			decimal
Public 	Dseq	 AS Double	'			decimal
Public 	seMainProcess	 AS String	'			char(3)
Public 	cdMainProcess	 AS String	'			char(3)
Public 	seSubProcess	 AS String	'			char(3)
Public 	cdSubProcess	 AS String	'			char(3)
Public 	Description	 AS String	'			nvarchar(200)
Public 	Cost	 AS Double	'			decimal
Public 	Loss	 AS Double	'			decimal
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

Public D7336 As T7336_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK7336(PROCESSBOMCODE AS String, PROCESSBOMSEQ AS Double) As Boolean
    READ_PFK7336 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7336 "
    SQL = SQL & " WHERE K7336_ProcessBOMCode		 = '" & ProcessBOMCode & "' " 
    SQL = SQL & "   AND K7336_ProcessBOMSeq		 =  " & ProcessBOMSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D7336_CLEAR: GoTo SKIP_READ_PFK7336
                
    Call K7336_MOVE(rd)
    READ_PFK7336 = True

SKIP_READ_PFK7336:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK7336",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK7336(PROCESSBOMCODE AS String, PROCESSBOMSEQ AS Double, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7336 "
    SQL = SQL & " WHERE K7336_ProcessBOMCode		 = '" & ProcessBOMCode & "' " 
    SQL = SQL & "   AND K7336_ProcessBOMSeq		 =  " & ProcessBOMSeq & "  " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK7336",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK7336(z7336 As T7336_AREA) As Boolean
    WRITE_PFK7336 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z7336)
 
    SQL = " INSERT INTO PFK7336 "
    SQL = SQL & " ( "
    SQL = SQL & " K7336_ProcessBOMCode," 
    SQL = SQL & " K7336_ProcessBOMSeq," 
    SQL = SQL & " K7336_GroupComponentBOM," 
    SQL = SQL & " K7336_GroupComponentSeq," 
    SQL = SQL & " K7336_Dseq," 
    SQL = SQL & " K7336_seMainProcess," 
    SQL = SQL & " K7336_cdMainProcess," 
    SQL = SQL & " K7336_seSubProcess," 
    SQL = SQL & " K7336_cdSubProcess," 
    SQL = SQL & " K7336_Description," 
    SQL = SQL & " K7336_Cost," 
    SQL = SQL & " K7336_Loss," 
    SQL = SQL & " K7336_seShoesStatus," 
    SQL = SQL & " K7336_cdShoesStatus," 
    SQL = SQL & " K7336_SupplierCode," 
    SQL = SQL & " K7336_CheckPresscript," 
    SQL = SQL & " K7336_CheckInside," 
    SQL = SQL & " K7336_CheckOutSide," 
    SQL = SQL & " K7336_CheckPurchase," 
    SQL = SQL & " K7336_CheckQuatity," 
    SQL = SQL & " K7336_CheckPrice," 
    SQL = SQL & " K7336_CheckLoss," 
    SQL = SQL & " K7336_CheckTime," 
    SQL = SQL & " K7336_CheckMachine," 
    SQL = SQL & " K7336_seMachineType," 
    SQL = SQL & " K7336_cdMachineType," 
    SQL = SQL & " K7336_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z7336.ProcessBOMCode) & "', "  
    SQL = SQL & "   " & FormatSQL(z7336.ProcessBOMSeq) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z7336.GroupComponentBOM) & "', "  
    SQL = SQL & "   " & FormatSQL(z7336.GroupComponentSeq) & ", "  
    SQL = SQL & "   " & FormatSQL(z7336.Dseq) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z7336.seMainProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7336.cdMainProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7336.seSubProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7336.cdSubProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7336.Description) & "', "  
    SQL = SQL & "   " & FormatSQL(z7336.Cost) & ", "  
    SQL = SQL & "   " & FormatSQL(z7336.Loss) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z7336.seShoesStatus) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7336.cdShoesStatus) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7336.SupplierCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7336.CheckPresscript) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7336.CheckInside) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7336.CheckOutSide) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7336.CheckPurchase) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7336.CheckQuatity) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7336.CheckPrice) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7336.CheckLoss) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7336.CheckTime) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7336.CheckMachine) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7336.seMachineType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7336.cdMachineType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7336.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK7336 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK7336",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK7336(z7336 As T7336_AREA) As Boolean
    REWRITE_PFK7336 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7336)
   
    SQL = " UPDATE PFK7336 SET "
    SQL = SQL & "    K7336_GroupComponentBOM      = N'" & FormatSQL(z7336.GroupComponentBOM) & "', " 
    SQL = SQL & "    K7336_GroupComponentSeq      =  " & FormatSQL(z7336.GroupComponentSeq) & ", " 
    SQL = SQL & "    K7336_Dseq      =  " & FormatSQL(z7336.Dseq) & ", " 
    SQL = SQL & "    K7336_seMainProcess      = N'" & FormatSQL(z7336.seMainProcess) & "', " 
    SQL = SQL & "    K7336_cdMainProcess      = N'" & FormatSQL(z7336.cdMainProcess) & "', " 
    SQL = SQL & "    K7336_seSubProcess      = N'" & FormatSQL(z7336.seSubProcess) & "', " 
    SQL = SQL & "    K7336_cdSubProcess      = N'" & FormatSQL(z7336.cdSubProcess) & "', " 
    SQL = SQL & "    K7336_Description      = N'" & FormatSQL(z7336.Description) & "', " 
    SQL = SQL & "    K7336_Cost      =  " & FormatSQL(z7336.Cost) & ", " 
    SQL = SQL & "    K7336_Loss      =  " & FormatSQL(z7336.Loss) & ", " 
    SQL = SQL & "    K7336_seShoesStatus      = N'" & FormatSQL(z7336.seShoesStatus) & "', " 
    SQL = SQL & "    K7336_cdShoesStatus      = N'" & FormatSQL(z7336.cdShoesStatus) & "', " 
    SQL = SQL & "    K7336_SupplierCode      = N'" & FormatSQL(z7336.SupplierCode) & "', " 
    SQL = SQL & "    K7336_CheckPresscript      = N'" & FormatSQL(z7336.CheckPresscript) & "', " 
    SQL = SQL & "    K7336_CheckInside      = N'" & FormatSQL(z7336.CheckInside) & "', " 
    SQL = SQL & "    K7336_CheckOutSide      = N'" & FormatSQL(z7336.CheckOutSide) & "', " 
    SQL = SQL & "    K7336_CheckPurchase      = N'" & FormatSQL(z7336.CheckPurchase) & "', " 
    SQL = SQL & "    K7336_CheckQuatity      = N'" & FormatSQL(z7336.CheckQuatity) & "', " 
    SQL = SQL & "    K7336_CheckPrice      = N'" & FormatSQL(z7336.CheckPrice) & "', " 
    SQL = SQL & "    K7336_CheckLoss      = N'" & FormatSQL(z7336.CheckLoss) & "', " 
    SQL = SQL & "    K7336_CheckTime      = N'" & FormatSQL(z7336.CheckTime) & "', " 
    SQL = SQL & "    K7336_CheckMachine      = N'" & FormatSQL(z7336.CheckMachine) & "', " 
    SQL = SQL & "    K7336_seMachineType      = N'" & FormatSQL(z7336.seMachineType) & "', " 
    SQL = SQL & "    K7336_cdMachineType      = N'" & FormatSQL(z7336.cdMachineType) & "', " 
    SQL = SQL & "    K7336_Remark      = N'" & FormatSQL(z7336.Remark) & "'  " 
    SQL = SQL & " WHERE K7336_ProcessBOMCode		 = '" & z7336.ProcessBOMCode & "' " 
    SQL = SQL & "   AND K7336_ProcessBOMSeq		 =  " & z7336.ProcessBOMSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK7336 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK7336",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK7336(z7336 As T7336_AREA) As Boolean
    DELETE_PFK7336 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK7336 "
    SQL = SQL & " WHERE K7336_ProcessBOMCode		 = '" & z7336.ProcessBOMCode & "' " 
    SQL = SQL & "   AND K7336_ProcessBOMSeq		 =  " & z7336.ProcessBOMSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK7336 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK7336",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D7336_CLEAR()
Try
    
   D7336.ProcessBOMCode = ""
    D7336.ProcessBOMSeq = 0 
   D7336.GroupComponentBOM = ""
    D7336.GroupComponentSeq = 0 
    D7336.Dseq = 0 
   D7336.seMainProcess = ""
   D7336.cdMainProcess = ""
   D7336.seSubProcess = ""
   D7336.cdSubProcess = ""
   D7336.Description = ""
    D7336.Cost = 0 
    D7336.Loss = 0 
   D7336.seShoesStatus = ""
   D7336.cdShoesStatus = ""
   D7336.SupplierCode = ""
   D7336.CheckPresscript = ""
   D7336.CheckInside = ""
   D7336.CheckOutSide = ""
   D7336.CheckPurchase = ""
   D7336.CheckQuatity = ""
   D7336.CheckPrice = ""
   D7336.CheckLoss = ""
   D7336.CheckTime = ""
   D7336.CheckMachine = ""
   D7336.seMachineType = ""
   D7336.cdMachineType = ""
   D7336.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D7336_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x7336 As T7336_AREA)
Try
    
    x7336.ProcessBOMCode = trim$(  x7336.ProcessBOMCode)
    x7336.ProcessBOMSeq = trim$(  x7336.ProcessBOMSeq)
    x7336.GroupComponentBOM = trim$(  x7336.GroupComponentBOM)
    x7336.GroupComponentSeq = trim$(  x7336.GroupComponentSeq)
    x7336.Dseq = trim$(  x7336.Dseq)
    x7336.seMainProcess = trim$(  x7336.seMainProcess)
    x7336.cdMainProcess = trim$(  x7336.cdMainProcess)
    x7336.seSubProcess = trim$(  x7336.seSubProcess)
    x7336.cdSubProcess = trim$(  x7336.cdSubProcess)
    x7336.Description = trim$(  x7336.Description)
    x7336.Cost = trim$(  x7336.Cost)
    x7336.Loss = trim$(  x7336.Loss)
    x7336.seShoesStatus = trim$(  x7336.seShoesStatus)
    x7336.cdShoesStatus = trim$(  x7336.cdShoesStatus)
    x7336.SupplierCode = trim$(  x7336.SupplierCode)
    x7336.CheckPresscript = trim$(  x7336.CheckPresscript)
    x7336.CheckInside = trim$(  x7336.CheckInside)
    x7336.CheckOutSide = trim$(  x7336.CheckOutSide)
    x7336.CheckPurchase = trim$(  x7336.CheckPurchase)
    x7336.CheckQuatity = trim$(  x7336.CheckQuatity)
    x7336.CheckPrice = trim$(  x7336.CheckPrice)
    x7336.CheckLoss = trim$(  x7336.CheckLoss)
    x7336.CheckTime = trim$(  x7336.CheckTime)
    x7336.CheckMachine = trim$(  x7336.CheckMachine)
    x7336.seMachineType = trim$(  x7336.seMachineType)
    x7336.cdMachineType = trim$(  x7336.cdMachineType)
    x7336.Remark = trim$(  x7336.Remark)
     
    If trim$( x7336.ProcessBOMCode ) = "" Then x7336.ProcessBOMCode = Space(1) 
    If trim$( x7336.ProcessBOMSeq ) = "" Then x7336.ProcessBOMSeq = 0 
    If trim$( x7336.GroupComponentBOM ) = "" Then x7336.GroupComponentBOM = Space(1) 
    If trim$( x7336.GroupComponentSeq ) = "" Then x7336.GroupComponentSeq = 0 
    If trim$( x7336.Dseq ) = "" Then x7336.Dseq = 0 
    If trim$( x7336.seMainProcess ) = "" Then x7336.seMainProcess = Space(1) 
    If trim$( x7336.cdMainProcess ) = "" Then x7336.cdMainProcess = Space(1) 
    If trim$( x7336.seSubProcess ) = "" Then x7336.seSubProcess = Space(1) 
    If trim$( x7336.cdSubProcess ) = "" Then x7336.cdSubProcess = Space(1) 
    If trim$( x7336.Description ) = "" Then x7336.Description = Space(1) 
    If trim$( x7336.Cost ) = "" Then x7336.Cost = 0 
    If trim$( x7336.Loss ) = "" Then x7336.Loss = 0 
    If trim$( x7336.seShoesStatus ) = "" Then x7336.seShoesStatus = Space(1) 
    If trim$( x7336.cdShoesStatus ) = "" Then x7336.cdShoesStatus = Space(1) 
    If trim$( x7336.SupplierCode ) = "" Then x7336.SupplierCode = Space(1) 
    If trim$( x7336.CheckPresscript ) = "" Then x7336.CheckPresscript = Space(1) 
    If trim$( x7336.CheckInside ) = "" Then x7336.CheckInside = Space(1) 
    If trim$( x7336.CheckOutSide ) = "" Then x7336.CheckOutSide = Space(1) 
    If trim$( x7336.CheckPurchase ) = "" Then x7336.CheckPurchase = Space(1) 
    If trim$( x7336.CheckQuatity ) = "" Then x7336.CheckQuatity = Space(1) 
    If trim$( x7336.CheckPrice ) = "" Then x7336.CheckPrice = Space(1) 
    If trim$( x7336.CheckLoss ) = "" Then x7336.CheckLoss = Space(1) 
    If trim$( x7336.CheckTime ) = "" Then x7336.CheckTime = Space(1) 
    If trim$( x7336.CheckMachine ) = "" Then x7336.CheckMachine = Space(1) 
    If trim$( x7336.seMachineType ) = "" Then x7336.seMachineType = Space(1) 
    If trim$( x7336.cdMachineType ) = "" Then x7336.cdMachineType = Space(1) 
    If trim$( x7336.Remark ) = "" Then x7336.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K7336_MOVE(rs7336 As SqlClient.SqlDataReader)
Try

    call D7336_CLEAR()   

    If IsdbNull(rs7336!K7336_ProcessBOMCode) = False Then D7336.ProcessBOMCode = Trim$(rs7336!K7336_ProcessBOMCode)
    If IsdbNull(rs7336!K7336_ProcessBOMSeq) = False Then D7336.ProcessBOMSeq = Trim$(rs7336!K7336_ProcessBOMSeq)
    If IsdbNull(rs7336!K7336_GroupComponentBOM) = False Then D7336.GroupComponentBOM = Trim$(rs7336!K7336_GroupComponentBOM)
    If IsdbNull(rs7336!K7336_GroupComponentSeq) = False Then D7336.GroupComponentSeq = Trim$(rs7336!K7336_GroupComponentSeq)
    If IsdbNull(rs7336!K7336_Dseq) = False Then D7336.Dseq = Trim$(rs7336!K7336_Dseq)
    If IsdbNull(rs7336!K7336_seMainProcess) = False Then D7336.seMainProcess = Trim$(rs7336!K7336_seMainProcess)
    If IsdbNull(rs7336!K7336_cdMainProcess) = False Then D7336.cdMainProcess = Trim$(rs7336!K7336_cdMainProcess)
    If IsdbNull(rs7336!K7336_seSubProcess) = False Then D7336.seSubProcess = Trim$(rs7336!K7336_seSubProcess)
    If IsdbNull(rs7336!K7336_cdSubProcess) = False Then D7336.cdSubProcess = Trim$(rs7336!K7336_cdSubProcess)
    If IsdbNull(rs7336!K7336_Description) = False Then D7336.Description = Trim$(rs7336!K7336_Description)
    If IsdbNull(rs7336!K7336_Cost) = False Then D7336.Cost = Trim$(rs7336!K7336_Cost)
    If IsdbNull(rs7336!K7336_Loss) = False Then D7336.Loss = Trim$(rs7336!K7336_Loss)
    If IsdbNull(rs7336!K7336_seShoesStatus) = False Then D7336.seShoesStatus = Trim$(rs7336!K7336_seShoesStatus)
    If IsdbNull(rs7336!K7336_cdShoesStatus) = False Then D7336.cdShoesStatus = Trim$(rs7336!K7336_cdShoesStatus)
    If IsdbNull(rs7336!K7336_SupplierCode) = False Then D7336.SupplierCode = Trim$(rs7336!K7336_SupplierCode)
    If IsdbNull(rs7336!K7336_CheckPresscript) = False Then D7336.CheckPresscript = Trim$(rs7336!K7336_CheckPresscript)
    If IsdbNull(rs7336!K7336_CheckInside) = False Then D7336.CheckInside = Trim$(rs7336!K7336_CheckInside)
    If IsdbNull(rs7336!K7336_CheckOutSide) = False Then D7336.CheckOutSide = Trim$(rs7336!K7336_CheckOutSide)
    If IsdbNull(rs7336!K7336_CheckPurchase) = False Then D7336.CheckPurchase = Trim$(rs7336!K7336_CheckPurchase)
    If IsdbNull(rs7336!K7336_CheckQuatity) = False Then D7336.CheckQuatity = Trim$(rs7336!K7336_CheckQuatity)
    If IsdbNull(rs7336!K7336_CheckPrice) = False Then D7336.CheckPrice = Trim$(rs7336!K7336_CheckPrice)
    If IsdbNull(rs7336!K7336_CheckLoss) = False Then D7336.CheckLoss = Trim$(rs7336!K7336_CheckLoss)
    If IsdbNull(rs7336!K7336_CheckTime) = False Then D7336.CheckTime = Trim$(rs7336!K7336_CheckTime)
    If IsdbNull(rs7336!K7336_CheckMachine) = False Then D7336.CheckMachine = Trim$(rs7336!K7336_CheckMachine)
    If IsdbNull(rs7336!K7336_seMachineType) = False Then D7336.seMachineType = Trim$(rs7336!K7336_seMachineType)
    If IsdbNull(rs7336!K7336_cdMachineType) = False Then D7336.cdMachineType = Trim$(rs7336!K7336_cdMachineType)
    If IsdbNull(rs7336!K7336_Remark) = False Then D7336.Remark = Trim$(rs7336!K7336_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7336_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K7336_MOVE(rs7336 As DataRow)
Try

    call D7336_CLEAR()   

    If IsdbNull(rs7336!K7336_ProcessBOMCode) = False Then D7336.ProcessBOMCode = Trim$(rs7336!K7336_ProcessBOMCode)
    If IsdbNull(rs7336!K7336_ProcessBOMSeq) = False Then D7336.ProcessBOMSeq = Trim$(rs7336!K7336_ProcessBOMSeq)
    If IsdbNull(rs7336!K7336_GroupComponentBOM) = False Then D7336.GroupComponentBOM = Trim$(rs7336!K7336_GroupComponentBOM)
    If IsdbNull(rs7336!K7336_GroupComponentSeq) = False Then D7336.GroupComponentSeq = Trim$(rs7336!K7336_GroupComponentSeq)
    If IsdbNull(rs7336!K7336_Dseq) = False Then D7336.Dseq = Trim$(rs7336!K7336_Dseq)
    If IsdbNull(rs7336!K7336_seMainProcess) = False Then D7336.seMainProcess = Trim$(rs7336!K7336_seMainProcess)
    If IsdbNull(rs7336!K7336_cdMainProcess) = False Then D7336.cdMainProcess = Trim$(rs7336!K7336_cdMainProcess)
    If IsdbNull(rs7336!K7336_seSubProcess) = False Then D7336.seSubProcess = Trim$(rs7336!K7336_seSubProcess)
    If IsdbNull(rs7336!K7336_cdSubProcess) = False Then D7336.cdSubProcess = Trim$(rs7336!K7336_cdSubProcess)
    If IsdbNull(rs7336!K7336_Description) = False Then D7336.Description = Trim$(rs7336!K7336_Description)
    If IsdbNull(rs7336!K7336_Cost) = False Then D7336.Cost = Trim$(rs7336!K7336_Cost)
    If IsdbNull(rs7336!K7336_Loss) = False Then D7336.Loss = Trim$(rs7336!K7336_Loss)
    If IsdbNull(rs7336!K7336_seShoesStatus) = False Then D7336.seShoesStatus = Trim$(rs7336!K7336_seShoesStatus)
    If IsdbNull(rs7336!K7336_cdShoesStatus) = False Then D7336.cdShoesStatus = Trim$(rs7336!K7336_cdShoesStatus)
    If IsdbNull(rs7336!K7336_SupplierCode) = False Then D7336.SupplierCode = Trim$(rs7336!K7336_SupplierCode)
    If IsdbNull(rs7336!K7336_CheckPresscript) = False Then D7336.CheckPresscript = Trim$(rs7336!K7336_CheckPresscript)
    If IsdbNull(rs7336!K7336_CheckInside) = False Then D7336.CheckInside = Trim$(rs7336!K7336_CheckInside)
    If IsdbNull(rs7336!K7336_CheckOutSide) = False Then D7336.CheckOutSide = Trim$(rs7336!K7336_CheckOutSide)
    If IsdbNull(rs7336!K7336_CheckPurchase) = False Then D7336.CheckPurchase = Trim$(rs7336!K7336_CheckPurchase)
    If IsdbNull(rs7336!K7336_CheckQuatity) = False Then D7336.CheckQuatity = Trim$(rs7336!K7336_CheckQuatity)
    If IsdbNull(rs7336!K7336_CheckPrice) = False Then D7336.CheckPrice = Trim$(rs7336!K7336_CheckPrice)
    If IsdbNull(rs7336!K7336_CheckLoss) = False Then D7336.CheckLoss = Trim$(rs7336!K7336_CheckLoss)
    If IsdbNull(rs7336!K7336_CheckTime) = False Then D7336.CheckTime = Trim$(rs7336!K7336_CheckTime)
    If IsdbNull(rs7336!K7336_CheckMachine) = False Then D7336.CheckMachine = Trim$(rs7336!K7336_CheckMachine)
    If IsdbNull(rs7336!K7336_seMachineType) = False Then D7336.seMachineType = Trim$(rs7336!K7336_seMachineType)
    If IsdbNull(rs7336!K7336_cdMachineType) = False Then D7336.cdMachineType = Trim$(rs7336!K7336_cdMachineType)
    If IsdbNull(rs7336!K7336_Remark) = False Then D7336.Remark = Trim$(rs7336!K7336_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7336_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K7336_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7336 As T7336_AREA, PROCESSBOMCODE AS String, PROCESSBOMSEQ AS Double) as Boolean

K7336_MOVE = False

Try
    If READ_PFK7336(PROCESSBOMCODE, PROCESSBOMSEQ) = True Then
                z7336 = D7336
		K7336_MOVE = True
		else
	z7336 = nothing
     End If

     If  getColumIndex(spr,"ProcessBOMCode") > -1 then z7336.ProcessBOMCode = getDataM(spr, getColumIndex(spr,"ProcessBOMCode"), xRow)
     If  getColumIndex(spr,"ProcessBOMSeq") > -1 then z7336.ProcessBOMSeq = getDataM(spr, getColumIndex(spr,"ProcessBOMSeq"), xRow)
     If  getColumIndex(spr,"GroupComponentBOM") > -1 then z7336.GroupComponentBOM = getDataM(spr, getColumIndex(spr,"GroupComponentBOM"), xRow)
     If  getColumIndex(spr,"GroupComponentSeq") > -1 then z7336.GroupComponentSeq = getDataM(spr, getColumIndex(spr,"GroupComponentSeq"), xRow)
     If  getColumIndex(spr,"Dseq") > -1 then z7336.Dseq = getDataM(spr, getColumIndex(spr,"Dseq"), xRow)
     If  getColumIndex(spr,"seMainProcess") > -1 then z7336.seMainProcess = getDataM(spr, getColumIndex(spr,"seMainProcess"), xRow)
     If  getColumIndex(spr,"cdMainProcess") > -1 then z7336.cdMainProcess = getDataM(spr, getColumIndex(spr,"cdMainProcess"), xRow)
     If  getColumIndex(spr,"seSubProcess") > -1 then z7336.seSubProcess = getDataM(spr, getColumIndex(spr,"seSubProcess"), xRow)
     If  getColumIndex(spr,"cdSubProcess") > -1 then z7336.cdSubProcess = getDataM(spr, getColumIndex(spr,"cdSubProcess"), xRow)
     If  getColumIndex(spr,"Description") > -1 then z7336.Description = getDataM(spr, getColumIndex(spr,"Description"), xRow)
     If  getColumIndex(spr,"Cost") > -1 then z7336.Cost = getDataM(spr, getColumIndex(spr,"Cost"), xRow)
     If  getColumIndex(spr,"Loss") > -1 then z7336.Loss = getDataM(spr, getColumIndex(spr,"Loss"), xRow)
     If  getColumIndex(spr,"seShoesStatus") > -1 then z7336.seShoesStatus = getDataM(spr, getColumIndex(spr,"seShoesStatus"), xRow)
     If  getColumIndex(spr,"cdShoesStatus") > -1 then z7336.cdShoesStatus = getDataM(spr, getColumIndex(spr,"cdShoesStatus"), xRow)
     If  getColumIndex(spr,"SupplierCode") > -1 then z7336.SupplierCode = getDataM(spr, getColumIndex(spr,"SupplierCode"), xRow)
     If  getColumIndex(spr,"CheckPresscript") > -1 then z7336.CheckPresscript = getDataM(spr, getColumIndex(spr,"CheckPresscript"), xRow)
     If  getColumIndex(spr,"CheckInside") > -1 then z7336.CheckInside = getDataM(spr, getColumIndex(spr,"CheckInside"), xRow)
     If  getColumIndex(spr,"CheckOutSide") > -1 then z7336.CheckOutSide = getDataM(spr, getColumIndex(spr,"CheckOutSide"), xRow)
     If  getColumIndex(spr,"CheckPurchase") > -1 then z7336.CheckPurchase = getDataM(spr, getColumIndex(spr,"CheckPurchase"), xRow)
     If  getColumIndex(spr,"CheckQuatity") > -1 then z7336.CheckQuatity = getDataM(spr, getColumIndex(spr,"CheckQuatity"), xRow)
     If  getColumIndex(spr,"CheckPrice") > -1 then z7336.CheckPrice = getDataM(spr, getColumIndex(spr,"CheckPrice"), xRow)
     If  getColumIndex(spr,"CheckLoss") > -1 then z7336.CheckLoss = getDataM(spr, getColumIndex(spr,"CheckLoss"), xRow)
     If  getColumIndex(spr,"CheckTime") > -1 then z7336.CheckTime = getDataM(spr, getColumIndex(spr,"CheckTime"), xRow)
     If  getColumIndex(spr,"CheckMachine") > -1 then z7336.CheckMachine = getDataM(spr, getColumIndex(spr,"CheckMachine"), xRow)
     If  getColumIndex(spr,"seMachineType") > -1 then z7336.seMachineType = getDataM(spr, getColumIndex(spr,"seMachineType"), xRow)
     If  getColumIndex(spr,"cdMachineType") > -1 then z7336.cdMachineType = getDataM(spr, getColumIndex(spr,"cdMachineType"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7336.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7336_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K7336_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7336 As T7336_AREA,CheckClear as Boolean,PROCESSBOMCODE AS String, PROCESSBOMSEQ AS Double) as Boolean

K7336_MOVE = False

Try
    If READ_PFK7336(PROCESSBOMCODE, PROCESSBOMSEQ) = True Then
                z7336 = D7336
		K7336_MOVE = True
		else
	If CheckClear  = True then z7336 = nothing
     End If

     If  getColumIndex(spr,"ProcessBOMCode") > -1 then z7336.ProcessBOMCode = getDataM(spr, getColumIndex(spr,"ProcessBOMCode"), xRow)
     If  getColumIndex(spr,"ProcessBOMSeq") > -1 then z7336.ProcessBOMSeq = getDataM(spr, getColumIndex(spr,"ProcessBOMSeq"), xRow)
     If  getColumIndex(spr,"GroupComponentBOM") > -1 then z7336.GroupComponentBOM = getDataM(spr, getColumIndex(spr,"GroupComponentBOM"), xRow)
     If  getColumIndex(spr,"GroupComponentSeq") > -1 then z7336.GroupComponentSeq = getDataM(spr, getColumIndex(spr,"GroupComponentSeq"), xRow)
     If  getColumIndex(spr,"Dseq") > -1 then z7336.Dseq = getDataM(spr, getColumIndex(spr,"Dseq"), xRow)
     If  getColumIndex(spr,"seMainProcess") > -1 then z7336.seMainProcess = getDataM(spr, getColumIndex(spr,"seMainProcess"), xRow)
     If  getColumIndex(spr,"cdMainProcess") > -1 then z7336.cdMainProcess = getDataM(spr, getColumIndex(spr,"cdMainProcess"), xRow)
     If  getColumIndex(spr,"seSubProcess") > -1 then z7336.seSubProcess = getDataM(spr, getColumIndex(spr,"seSubProcess"), xRow)
     If  getColumIndex(spr,"cdSubProcess") > -1 then z7336.cdSubProcess = getDataM(spr, getColumIndex(spr,"cdSubProcess"), xRow)
     If  getColumIndex(spr,"Description") > -1 then z7336.Description = getDataM(spr, getColumIndex(spr,"Description"), xRow)
     If  getColumIndex(spr,"Cost") > -1 then z7336.Cost = getDataM(spr, getColumIndex(spr,"Cost"), xRow)
     If  getColumIndex(spr,"Loss") > -1 then z7336.Loss = getDataM(spr, getColumIndex(spr,"Loss"), xRow)
     If  getColumIndex(spr,"seShoesStatus") > -1 then z7336.seShoesStatus = getDataM(spr, getColumIndex(spr,"seShoesStatus"), xRow)
     If  getColumIndex(spr,"cdShoesStatus") > -1 then z7336.cdShoesStatus = getDataM(spr, getColumIndex(spr,"cdShoesStatus"), xRow)
     If  getColumIndex(spr,"SupplierCode") > -1 then z7336.SupplierCode = getDataM(spr, getColumIndex(spr,"SupplierCode"), xRow)
     If  getColumIndex(spr,"CheckPresscript") > -1 then z7336.CheckPresscript = getDataM(spr, getColumIndex(spr,"CheckPresscript"), xRow)
     If  getColumIndex(spr,"CheckInside") > -1 then z7336.CheckInside = getDataM(spr, getColumIndex(spr,"CheckInside"), xRow)
     If  getColumIndex(spr,"CheckOutSide") > -1 then z7336.CheckOutSide = getDataM(spr, getColumIndex(spr,"CheckOutSide"), xRow)
     If  getColumIndex(spr,"CheckPurchase") > -1 then z7336.CheckPurchase = getDataM(spr, getColumIndex(spr,"CheckPurchase"), xRow)
     If  getColumIndex(spr,"CheckQuatity") > -1 then z7336.CheckQuatity = getDataM(spr, getColumIndex(spr,"CheckQuatity"), xRow)
     If  getColumIndex(spr,"CheckPrice") > -1 then z7336.CheckPrice = getDataM(spr, getColumIndex(spr,"CheckPrice"), xRow)
     If  getColumIndex(spr,"CheckLoss") > -1 then z7336.CheckLoss = getDataM(spr, getColumIndex(spr,"CheckLoss"), xRow)
     If  getColumIndex(spr,"CheckTime") > -1 then z7336.CheckTime = getDataM(spr, getColumIndex(spr,"CheckTime"), xRow)
     If  getColumIndex(spr,"CheckMachine") > -1 then z7336.CheckMachine = getDataM(spr, getColumIndex(spr,"CheckMachine"), xRow)
     If  getColumIndex(spr,"seMachineType") > -1 then z7336.seMachineType = getDataM(spr, getColumIndex(spr,"seMachineType"), xRow)
     If  getColumIndex(spr,"cdMachineType") > -1 then z7336.cdMachineType = getDataM(spr, getColumIndex(spr,"cdMachineType"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7336.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7336_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K7336_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7336 As T7336_AREA, Job as String, PROCESSBOMCODE AS String, PROCESSBOMSEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7336_MOVE = False

Try
    If READ_PFK7336(PROCESSBOMCODE, PROCESSBOMSEQ) = True Then
                z7336 = D7336
		K7336_MOVE = True
		else
	z7336 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7336")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "PROCESSBOMCODE":z7336.ProcessBOMCode = Children(i).Code
   Case "PROCESSBOMSEQ":z7336.ProcessBOMSeq = Children(i).Code
   Case "GROUPCOMPONENTBOM":z7336.GroupComponentBOM = Children(i).Code
   Case "GROUPCOMPONENTSEQ":z7336.GroupComponentSeq = Children(i).Code
   Case "DSEQ":z7336.Dseq = Children(i).Code
   Case "SEMAINPROCESS":z7336.seMainProcess = Children(i).Code
   Case "CDMAINPROCESS":z7336.cdMainProcess = Children(i).Code
   Case "SESUBPROCESS":z7336.seSubProcess = Children(i).Code
   Case "CDSUBPROCESS":z7336.cdSubProcess = Children(i).Code
   Case "DESCRIPTION":z7336.Description = Children(i).Code
   Case "COST":z7336.Cost = Children(i).Code
   Case "LOSS":z7336.Loss = Children(i).Code
   Case "SESHOESSTATUS":z7336.seShoesStatus = Children(i).Code
   Case "CDSHOESSTATUS":z7336.cdShoesStatus = Children(i).Code
   Case "SUPPLIERCODE":z7336.SupplierCode = Children(i).Code
   Case "CHECKPRESSCRIPT":z7336.CheckPresscript = Children(i).Code
   Case "CHECKINSIDE":z7336.CheckInside = Children(i).Code
   Case "CHECKOUTSIDE":z7336.CheckOutSide = Children(i).Code
   Case "CHECKPURCHASE":z7336.CheckPurchase = Children(i).Code
   Case "CHECKQUATITY":z7336.CheckQuatity = Children(i).Code
   Case "CHECKPRICE":z7336.CheckPrice = Children(i).Code
   Case "CHECKLOSS":z7336.CheckLoss = Children(i).Code
   Case "CHECKTIME":z7336.CheckTime = Children(i).Code
   Case "CHECKMACHINE":z7336.CheckMachine = Children(i).Code
   Case "SEMACHINETYPE":z7336.seMachineType = Children(i).Code
   Case "CDMACHINETYPE":z7336.cdMachineType = Children(i).Code
   Case "REMARK":z7336.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "PROCESSBOMCODE":z7336.ProcessBOMCode = Children(i).Data
   Case "PROCESSBOMSEQ":z7336.ProcessBOMSeq = Children(i).Data
   Case "GROUPCOMPONENTBOM":z7336.GroupComponentBOM = Children(i).Data
   Case "GROUPCOMPONENTSEQ":z7336.GroupComponentSeq = Children(i).Data
   Case "DSEQ":z7336.Dseq = Children(i).Data
   Case "SEMAINPROCESS":z7336.seMainProcess = Children(i).Data
   Case "CDMAINPROCESS":z7336.cdMainProcess = Children(i).Data
   Case "SESUBPROCESS":z7336.seSubProcess = Children(i).Data
   Case "CDSUBPROCESS":z7336.cdSubProcess = Children(i).Data
   Case "DESCRIPTION":z7336.Description = Children(i).Data
   Case "COST":z7336.Cost = Children(i).Data
   Case "LOSS":z7336.Loss = Children(i).Data
   Case "SESHOESSTATUS":z7336.seShoesStatus = Children(i).Data
   Case "CDSHOESSTATUS":z7336.cdShoesStatus = Children(i).Data
   Case "SUPPLIERCODE":z7336.SupplierCode = Children(i).Data
   Case "CHECKPRESSCRIPT":z7336.CheckPresscript = Children(i).Data
   Case "CHECKINSIDE":z7336.CheckInside = Children(i).Data
   Case "CHECKOUTSIDE":z7336.CheckOutSide = Children(i).Data
   Case "CHECKPURCHASE":z7336.CheckPurchase = Children(i).Data
   Case "CHECKQUATITY":z7336.CheckQuatity = Children(i).Data
   Case "CHECKPRICE":z7336.CheckPrice = Children(i).Data
   Case "CHECKLOSS":z7336.CheckLoss = Children(i).Data
   Case "CHECKTIME":z7336.CheckTime = Children(i).Data
   Case "CHECKMACHINE":z7336.CheckMachine = Children(i).Data
   Case "SEMACHINETYPE":z7336.seMachineType = Children(i).Data
   Case "CDMACHINETYPE":z7336.cdMachineType = Children(i).Data
   Case "REMARK":z7336.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7336_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K7336_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7336 As T7336_AREA, Job as String, CheckClear as Boolean, PROCESSBOMCODE AS String, PROCESSBOMSEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7336_MOVE = False

Try
    If READ_PFK7336(PROCESSBOMCODE, PROCESSBOMSEQ) = True Then
                z7336 = D7336
		K7336_MOVE = True
		else
	If CheckClear  = True then z7336 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7336")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "PROCESSBOMCODE":z7336.ProcessBOMCode = Children(i).Code
   Case "PROCESSBOMSEQ":z7336.ProcessBOMSeq = Children(i).Code
   Case "GROUPCOMPONENTBOM":z7336.GroupComponentBOM = Children(i).Code
   Case "GROUPCOMPONENTSEQ":z7336.GroupComponentSeq = Children(i).Code
   Case "DSEQ":z7336.Dseq = Children(i).Code
   Case "SEMAINPROCESS":z7336.seMainProcess = Children(i).Code
   Case "CDMAINPROCESS":z7336.cdMainProcess = Children(i).Code
   Case "SESUBPROCESS":z7336.seSubProcess = Children(i).Code
   Case "CDSUBPROCESS":z7336.cdSubProcess = Children(i).Code
   Case "DESCRIPTION":z7336.Description = Children(i).Code
   Case "COST":z7336.Cost = Children(i).Code
   Case "LOSS":z7336.Loss = Children(i).Code
   Case "SESHOESSTATUS":z7336.seShoesStatus = Children(i).Code
   Case "CDSHOESSTATUS":z7336.cdShoesStatus = Children(i).Code
   Case "SUPPLIERCODE":z7336.SupplierCode = Children(i).Code
   Case "CHECKPRESSCRIPT":z7336.CheckPresscript = Children(i).Code
   Case "CHECKINSIDE":z7336.CheckInside = Children(i).Code
   Case "CHECKOUTSIDE":z7336.CheckOutSide = Children(i).Code
   Case "CHECKPURCHASE":z7336.CheckPurchase = Children(i).Code
   Case "CHECKQUATITY":z7336.CheckQuatity = Children(i).Code
   Case "CHECKPRICE":z7336.CheckPrice = Children(i).Code
   Case "CHECKLOSS":z7336.CheckLoss = Children(i).Code
   Case "CHECKTIME":z7336.CheckTime = Children(i).Code
   Case "CHECKMACHINE":z7336.CheckMachine = Children(i).Code
   Case "SEMACHINETYPE":z7336.seMachineType = Children(i).Code
   Case "CDMACHINETYPE":z7336.cdMachineType = Children(i).Code
   Case "REMARK":z7336.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "PROCESSBOMCODE":z7336.ProcessBOMCode = Children(i).Data
   Case "PROCESSBOMSEQ":z7336.ProcessBOMSeq = Children(i).Data
   Case "GROUPCOMPONENTBOM":z7336.GroupComponentBOM = Children(i).Data
   Case "GROUPCOMPONENTSEQ":z7336.GroupComponentSeq = Children(i).Data
   Case "DSEQ":z7336.Dseq = Children(i).Data
   Case "SEMAINPROCESS":z7336.seMainProcess = Children(i).Data
   Case "CDMAINPROCESS":z7336.cdMainProcess = Children(i).Data
   Case "SESUBPROCESS":z7336.seSubProcess = Children(i).Data
   Case "CDSUBPROCESS":z7336.cdSubProcess = Children(i).Data
   Case "DESCRIPTION":z7336.Description = Children(i).Data
   Case "COST":z7336.Cost = Children(i).Data
   Case "LOSS":z7336.Loss = Children(i).Data
   Case "SESHOESSTATUS":z7336.seShoesStatus = Children(i).Data
   Case "CDSHOESSTATUS":z7336.cdShoesStatus = Children(i).Data
   Case "SUPPLIERCODE":z7336.SupplierCode = Children(i).Data
   Case "CHECKPRESSCRIPT":z7336.CheckPresscript = Children(i).Data
   Case "CHECKINSIDE":z7336.CheckInside = Children(i).Data
   Case "CHECKOUTSIDE":z7336.CheckOutSide = Children(i).Data
   Case "CHECKPURCHASE":z7336.CheckPurchase = Children(i).Data
   Case "CHECKQUATITY":z7336.CheckQuatity = Children(i).Data
   Case "CHECKPRICE":z7336.CheckPrice = Children(i).Data
   Case "CHECKLOSS":z7336.CheckLoss = Children(i).Data
   Case "CHECKTIME":z7336.CheckTime = Children(i).Data
   Case "CHECKMACHINE":z7336.CheckMachine = Children(i).Data
   Case "SEMACHINETYPE":z7336.seMachineType = Children(i).Data
   Case "CDMACHINETYPE":z7336.cdMachineType = Children(i).Data
   Case "REMARK":z7336.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7336_MOVE",vbCritical)
End Try
End Function 
    
End Module 
