'=========================================================================================================================================================
'   TABLE : (PFK4025)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K4025

Structure T4025_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	WorkOrder	 AS String	'			char(9)		*
Public 	WorkOrderSeq	 AS String	'			char(3)		*
Public 	ProcessSeq	 AS String	'			char(3)		*
Public 	Dseq	 AS Double	'			decimal
Public 	seMainProcess	 AS String	'			char(3)
Public 	cdMainProcess	 AS String	'			char(3)
Public 	seSubProcess	 AS String	'			char(3)
Public 	cdSubProcess	 AS String	'			char(3)
Public 	Description	 AS String	'			nvarchar(500)
Public 	Price	 AS Double	'			decimal
Public 	Loss	 AS Double	'			decimal
Public 	ProcessAMT	 AS Double	'			decimal
Public 	TotalQty	 AS Double	'			decimal
Public 	TotalProcessAMT	 AS Double	'			decimal
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
Public 	CheckJob	 AS String	'			char(1)
Public 	CheckMachine	 AS String	'			char(1)
Public 	seMachineType	 AS String	'			char(3)
Public 	cdMachineType	 AS String	'			char(3)
Public 	CheckStatus	 AS String	'			char(1)
Public 	DateStatus	 AS String	'			char(8)
Public 	InchargeStatus	 AS String	'			char(8)
Public 	WorkingNo	 AS String	'			char(9)
Public 	Remark	 AS String	'			nvarchar(50)
'=========================================================================================================================================================
End structure

Public D4025 As T4025_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK4025(WORKORDER AS String, WORKORDERSEQ AS String, PROCESSSEQ AS String) As Boolean
    READ_PFK4025 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK4025 "
    SQL = SQL & " WHERE K4025_WorkOrder		 = '" & WorkOrder & "' " 
    SQL = SQL & "   AND K4025_WorkOrderSeq		 = '" & WorkOrderSeq & "' " 
    SQL = SQL & "   AND K4025_ProcessSeq		 = '" & ProcessSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D4025_CLEAR: GoTo SKIP_READ_PFK4025
                
    Call K4025_MOVE(rd)
    READ_PFK4025 = True

SKIP_READ_PFK4025:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK4025",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK4025(WORKORDER AS String, WORKORDERSEQ AS String, PROCESSSEQ AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK4025 "
    SQL = SQL & " WHERE K4025_WorkOrder		 = '" & WorkOrder & "' " 
    SQL = SQL & "   AND K4025_WorkOrderSeq		 = '" & WorkOrderSeq & "' " 
    SQL = SQL & "   AND K4025_ProcessSeq		 = '" & ProcessSeq & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK4025",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK4025(z4025 As T4025_AREA) As Boolean
    WRITE_PFK4025 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z4025)
 
    SQL = " INSERT INTO PFK4025 "
    SQL = SQL & " ( "
    SQL = SQL & " K4025_WorkOrder," 
    SQL = SQL & " K4025_WorkOrderSeq," 
    SQL = SQL & " K4025_ProcessSeq," 
    SQL = SQL & " K4025_Dseq," 
    SQL = SQL & " K4025_seMainProcess," 
    SQL = SQL & " K4025_cdMainProcess," 
    SQL = SQL & " K4025_seSubProcess," 
    SQL = SQL & " K4025_cdSubProcess," 
    SQL = SQL & " K4025_Description," 
    SQL = SQL & " K4025_Price," 
    SQL = SQL & " K4025_Loss," 
    SQL = SQL & " K4025_ProcessAMT," 
    SQL = SQL & " K4025_TotalQty," 
    SQL = SQL & " K4025_TotalProcessAMT," 
    SQL = SQL & " K4025_seShoesStatus," 
    SQL = SQL & " K4025_cdShoesStatus," 
    SQL = SQL & " K4025_SupplierCode," 
    SQL = SQL & " K4025_CheckPresscript," 
    SQL = SQL & " K4025_CheckInside," 
    SQL = SQL & " K4025_CheckOutSide," 
    SQL = SQL & " K4025_CheckPurchase," 
    SQL = SQL & " K4025_CheckQuatity," 
    SQL = SQL & " K4025_CheckPrice," 
    SQL = SQL & " K4025_CheckLoss," 
    SQL = SQL & " K4025_CheckTime," 
    SQL = SQL & " K4025_CheckJob," 
    SQL = SQL & " K4025_CheckMachine," 
    SQL = SQL & " K4025_seMachineType," 
    SQL = SQL & " K4025_cdMachineType," 
    SQL = SQL & " K4025_CheckStatus," 
    SQL = SQL & " K4025_DateStatus," 
    SQL = SQL & " K4025_InchargeStatus," 
    SQL = SQL & " K4025_WorkingNo," 
    SQL = SQL & " K4025_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z4025.WorkOrder) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4025.WorkOrderSeq) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4025.ProcessSeq) & "', "  
    SQL = SQL & "   " & FormatSQL(z4025.Dseq) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z4025.seMainProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4025.cdMainProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4025.seSubProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4025.cdSubProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4025.Description) & "', "  
    SQL = SQL & "   " & FormatSQL(z4025.Price) & ", "  
    SQL = SQL & "   " & FormatSQL(z4025.Loss) & ", "  
    SQL = SQL & "   " & FormatSQL(z4025.ProcessAMT) & ", "  
    SQL = SQL & "   " & FormatSQL(z4025.TotalQty) & ", "  
    SQL = SQL & "   " & FormatSQL(z4025.TotalProcessAMT) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z4025.seShoesStatus) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4025.cdShoesStatus) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4025.SupplierCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4025.CheckPresscript) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4025.CheckInside) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4025.CheckOutSide) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4025.CheckPurchase) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4025.CheckQuatity) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4025.CheckPrice) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4025.CheckLoss) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4025.CheckTime) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4025.CheckJob) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4025.CheckMachine) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4025.seMachineType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4025.cdMachineType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4025.CheckStatus) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4025.DateStatus) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4025.InchargeStatus) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4025.WorkingNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4025.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK4025 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK4025",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK4025(z4025 As T4025_AREA) As Boolean
    REWRITE_PFK4025 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z4025)
   
    SQL = " UPDATE PFK4025 SET "
    SQL = SQL & "    K4025_Dseq      =  " & FormatSQL(z4025.Dseq) & ", " 
    SQL = SQL & "    K4025_seMainProcess      = N'" & FormatSQL(z4025.seMainProcess) & "', " 
    SQL = SQL & "    K4025_cdMainProcess      = N'" & FormatSQL(z4025.cdMainProcess) & "', " 
    SQL = SQL & "    K4025_seSubProcess      = N'" & FormatSQL(z4025.seSubProcess) & "', " 
    SQL = SQL & "    K4025_cdSubProcess      = N'" & FormatSQL(z4025.cdSubProcess) & "', " 
    SQL = SQL & "    K4025_Description      = N'" & FormatSQL(z4025.Description) & "', " 
    SQL = SQL & "    K4025_Price      =  " & FormatSQL(z4025.Price) & ", " 
    SQL = SQL & "    K4025_Loss      =  " & FormatSQL(z4025.Loss) & ", " 
    SQL = SQL & "    K4025_ProcessAMT      =  " & FormatSQL(z4025.ProcessAMT) & ", " 
    SQL = SQL & "    K4025_TotalQty      =  " & FormatSQL(z4025.TotalQty) & ", " 
    SQL = SQL & "    K4025_TotalProcessAMT      =  " & FormatSQL(z4025.TotalProcessAMT) & ", " 
    SQL = SQL & "    K4025_seShoesStatus      = N'" & FormatSQL(z4025.seShoesStatus) & "', " 
    SQL = SQL & "    K4025_cdShoesStatus      = N'" & FormatSQL(z4025.cdShoesStatus) & "', " 
    SQL = SQL & "    K4025_SupplierCode      = N'" & FormatSQL(z4025.SupplierCode) & "', " 
    SQL = SQL & "    K4025_CheckPresscript      = N'" & FormatSQL(z4025.CheckPresscript) & "', " 
    SQL = SQL & "    K4025_CheckInside      = N'" & FormatSQL(z4025.CheckInside) & "', " 
    SQL = SQL & "    K4025_CheckOutSide      = N'" & FormatSQL(z4025.CheckOutSide) & "', " 
    SQL = SQL & "    K4025_CheckPurchase      = N'" & FormatSQL(z4025.CheckPurchase) & "', " 
    SQL = SQL & "    K4025_CheckQuatity      = N'" & FormatSQL(z4025.CheckQuatity) & "', " 
    SQL = SQL & "    K4025_CheckPrice      = N'" & FormatSQL(z4025.CheckPrice) & "', " 
    SQL = SQL & "    K4025_CheckLoss      = N'" & FormatSQL(z4025.CheckLoss) & "', " 
    SQL = SQL & "    K4025_CheckTime      = N'" & FormatSQL(z4025.CheckTime) & "', " 
    SQL = SQL & "    K4025_CheckJob      = N'" & FormatSQL(z4025.CheckJob) & "', " 
    SQL = SQL & "    K4025_CheckMachine      = N'" & FormatSQL(z4025.CheckMachine) & "', " 
    SQL = SQL & "    K4025_seMachineType      = N'" & FormatSQL(z4025.seMachineType) & "', " 
    SQL = SQL & "    K4025_cdMachineType      = N'" & FormatSQL(z4025.cdMachineType) & "', " 
    SQL = SQL & "    K4025_CheckStatus      = N'" & FormatSQL(z4025.CheckStatus) & "', " 
    SQL = SQL & "    K4025_DateStatus      = N'" & FormatSQL(z4025.DateStatus) & "', " 
    SQL = SQL & "    K4025_InchargeStatus      = N'" & FormatSQL(z4025.InchargeStatus) & "', " 
    SQL = SQL & "    K4025_WorkingNo      = N'" & FormatSQL(z4025.WorkingNo) & "', " 
    SQL = SQL & "    K4025_Remark      = N'" & FormatSQL(z4025.Remark) & "'  " 
    SQL = SQL & " WHERE K4025_WorkOrder		 = '" & z4025.WorkOrder & "' " 
    SQL = SQL & "   AND K4025_WorkOrderSeq		 = '" & z4025.WorkOrderSeq & "' " 
    SQL = SQL & "   AND K4025_ProcessSeq		 = '" & z4025.ProcessSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK4025 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK4025",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK4025(z4025 As T4025_AREA) As Boolean
    DELETE_PFK4025 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK4025 "
    SQL = SQL & " WHERE K4025_WorkOrder		 = '" & z4025.WorkOrder & "' " 
    SQL = SQL & "   AND K4025_WorkOrderSeq		 = '" & z4025.WorkOrderSeq & "' " 
    SQL = SQL & "   AND K4025_ProcessSeq		 = '" & z4025.ProcessSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK4025 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK4025",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D4025_CLEAR()
Try
    
   D4025.WorkOrder = ""
   D4025.WorkOrderSeq = ""
   D4025.ProcessSeq = ""
    D4025.Dseq = 0 
   D4025.seMainProcess = ""
   D4025.cdMainProcess = ""
   D4025.seSubProcess = ""
   D4025.cdSubProcess = ""
   D4025.Description = ""
    D4025.Price = 0 
    D4025.Loss = 0 
    D4025.ProcessAMT = 0 
    D4025.TotalQty = 0 
    D4025.TotalProcessAMT = 0 
   D4025.seShoesStatus = ""
   D4025.cdShoesStatus = ""
   D4025.SupplierCode = ""
   D4025.CheckPresscript = ""
   D4025.CheckInside = ""
   D4025.CheckOutSide = ""
   D4025.CheckPurchase = ""
   D4025.CheckQuatity = ""
   D4025.CheckPrice = ""
   D4025.CheckLoss = ""
   D4025.CheckTime = ""
   D4025.CheckJob = ""
   D4025.CheckMachine = ""
   D4025.seMachineType = ""
   D4025.cdMachineType = ""
   D4025.CheckStatus = ""
   D4025.DateStatus = ""
   D4025.InchargeStatus = ""
   D4025.WorkingNo = ""
   D4025.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D4025_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x4025 As T4025_AREA)
Try
    
    x4025.WorkOrder = trim$(  x4025.WorkOrder)
    x4025.WorkOrderSeq = trim$(  x4025.WorkOrderSeq)
    x4025.ProcessSeq = trim$(  x4025.ProcessSeq)
    x4025.Dseq = trim$(  x4025.Dseq)
    x4025.seMainProcess = trim$(  x4025.seMainProcess)
    x4025.cdMainProcess = trim$(  x4025.cdMainProcess)
    x4025.seSubProcess = trim$(  x4025.seSubProcess)
    x4025.cdSubProcess = trim$(  x4025.cdSubProcess)
    x4025.Description = trim$(  x4025.Description)
    x4025.Price = trim$(  x4025.Price)
    x4025.Loss = trim$(  x4025.Loss)
    x4025.ProcessAMT = trim$(  x4025.ProcessAMT)
    x4025.TotalQty = trim$(  x4025.TotalQty)
    x4025.TotalProcessAMT = trim$(  x4025.TotalProcessAMT)
    x4025.seShoesStatus = trim$(  x4025.seShoesStatus)
    x4025.cdShoesStatus = trim$(  x4025.cdShoesStatus)
    x4025.SupplierCode = trim$(  x4025.SupplierCode)
    x4025.CheckPresscript = trim$(  x4025.CheckPresscript)
    x4025.CheckInside = trim$(  x4025.CheckInside)
    x4025.CheckOutSide = trim$(  x4025.CheckOutSide)
    x4025.CheckPurchase = trim$(  x4025.CheckPurchase)
    x4025.CheckQuatity = trim$(  x4025.CheckQuatity)
    x4025.CheckPrice = trim$(  x4025.CheckPrice)
    x4025.CheckLoss = trim$(  x4025.CheckLoss)
    x4025.CheckTime = trim$(  x4025.CheckTime)
    x4025.CheckJob = trim$(  x4025.CheckJob)
    x4025.CheckMachine = trim$(  x4025.CheckMachine)
    x4025.seMachineType = trim$(  x4025.seMachineType)
    x4025.cdMachineType = trim$(  x4025.cdMachineType)
    x4025.CheckStatus = trim$(  x4025.CheckStatus)
    x4025.DateStatus = trim$(  x4025.DateStatus)
    x4025.InchargeStatus = trim$(  x4025.InchargeStatus)
    x4025.WorkingNo = trim$(  x4025.WorkingNo)
    x4025.Remark = trim$(  x4025.Remark)
     
    If trim$( x4025.WorkOrder ) = "" Then x4025.WorkOrder = Space(1) 
    If trim$( x4025.WorkOrderSeq ) = "" Then x4025.WorkOrderSeq = Space(1) 
    If trim$( x4025.ProcessSeq ) = "" Then x4025.ProcessSeq = Space(1) 
    If trim$( x4025.Dseq ) = "" Then x4025.Dseq = 0 
    If trim$( x4025.seMainProcess ) = "" Then x4025.seMainProcess = Space(1) 
    If trim$( x4025.cdMainProcess ) = "" Then x4025.cdMainProcess = Space(1) 
    If trim$( x4025.seSubProcess ) = "" Then x4025.seSubProcess = Space(1) 
    If trim$( x4025.cdSubProcess ) = "" Then x4025.cdSubProcess = Space(1) 
    If trim$( x4025.Description ) = "" Then x4025.Description = Space(1) 
    If trim$( x4025.Price ) = "" Then x4025.Price = 0 
    If trim$( x4025.Loss ) = "" Then x4025.Loss = 0 
    If trim$( x4025.ProcessAMT ) = "" Then x4025.ProcessAMT = 0 
    If trim$( x4025.TotalQty ) = "" Then x4025.TotalQty = 0 
    If trim$( x4025.TotalProcessAMT ) = "" Then x4025.TotalProcessAMT = 0 
    If trim$( x4025.seShoesStatus ) = "" Then x4025.seShoesStatus = Space(1) 
    If trim$( x4025.cdShoesStatus ) = "" Then x4025.cdShoesStatus = Space(1) 
    If trim$( x4025.SupplierCode ) = "" Then x4025.SupplierCode = Space(1) 
    If trim$( x4025.CheckPresscript ) = "" Then x4025.CheckPresscript = Space(1) 
    If trim$( x4025.CheckInside ) = "" Then x4025.CheckInside = Space(1) 
    If trim$( x4025.CheckOutSide ) = "" Then x4025.CheckOutSide = Space(1) 
    If trim$( x4025.CheckPurchase ) = "" Then x4025.CheckPurchase = Space(1) 
    If trim$( x4025.CheckQuatity ) = "" Then x4025.CheckQuatity = Space(1) 
    If trim$( x4025.CheckPrice ) = "" Then x4025.CheckPrice = Space(1) 
    If trim$( x4025.CheckLoss ) = "" Then x4025.CheckLoss = Space(1) 
    If trim$( x4025.CheckTime ) = "" Then x4025.CheckTime = Space(1) 
    If trim$( x4025.CheckJob ) = "" Then x4025.CheckJob = Space(1) 
    If trim$( x4025.CheckMachine ) = "" Then x4025.CheckMachine = Space(1) 
    If trim$( x4025.seMachineType ) = "" Then x4025.seMachineType = Space(1) 
    If trim$( x4025.cdMachineType ) = "" Then x4025.cdMachineType = Space(1) 
    If trim$( x4025.CheckStatus ) = "" Then x4025.CheckStatus = Space(1) 
    If trim$( x4025.DateStatus ) = "" Then x4025.DateStatus = Space(1) 
    If trim$( x4025.InchargeStatus ) = "" Then x4025.InchargeStatus = Space(1) 
    If trim$( x4025.WorkingNo ) = "" Then x4025.WorkingNo = Space(1) 
    If trim$( x4025.Remark ) = "" Then x4025.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K4025_MOVE(rs4025 As SqlClient.SqlDataReader)
Try

    call D4025_CLEAR()   

    If IsdbNull(rs4025!K4025_WorkOrder) = False Then D4025.WorkOrder = Trim$(rs4025!K4025_WorkOrder)
    If IsdbNull(rs4025!K4025_WorkOrderSeq) = False Then D4025.WorkOrderSeq = Trim$(rs4025!K4025_WorkOrderSeq)
    If IsdbNull(rs4025!K4025_ProcessSeq) = False Then D4025.ProcessSeq = Trim$(rs4025!K4025_ProcessSeq)
    If IsdbNull(rs4025!K4025_Dseq) = False Then D4025.Dseq = Trim$(rs4025!K4025_Dseq)
    If IsdbNull(rs4025!K4025_seMainProcess) = False Then D4025.seMainProcess = Trim$(rs4025!K4025_seMainProcess)
    If IsdbNull(rs4025!K4025_cdMainProcess) = False Then D4025.cdMainProcess = Trim$(rs4025!K4025_cdMainProcess)
    If IsdbNull(rs4025!K4025_seSubProcess) = False Then D4025.seSubProcess = Trim$(rs4025!K4025_seSubProcess)
    If IsdbNull(rs4025!K4025_cdSubProcess) = False Then D4025.cdSubProcess = Trim$(rs4025!K4025_cdSubProcess)
    If IsdbNull(rs4025!K4025_Description) = False Then D4025.Description = Trim$(rs4025!K4025_Description)
    If IsdbNull(rs4025!K4025_Price) = False Then D4025.Price = Trim$(rs4025!K4025_Price)
    If IsdbNull(rs4025!K4025_Loss) = False Then D4025.Loss = Trim$(rs4025!K4025_Loss)
    If IsdbNull(rs4025!K4025_ProcessAMT) = False Then D4025.ProcessAMT = Trim$(rs4025!K4025_ProcessAMT)
    If IsdbNull(rs4025!K4025_TotalQty) = False Then D4025.TotalQty = Trim$(rs4025!K4025_TotalQty)
    If IsdbNull(rs4025!K4025_TotalProcessAMT) = False Then D4025.TotalProcessAMT = Trim$(rs4025!K4025_TotalProcessAMT)
    If IsdbNull(rs4025!K4025_seShoesStatus) = False Then D4025.seShoesStatus = Trim$(rs4025!K4025_seShoesStatus)
    If IsdbNull(rs4025!K4025_cdShoesStatus) = False Then D4025.cdShoesStatus = Trim$(rs4025!K4025_cdShoesStatus)
    If IsdbNull(rs4025!K4025_SupplierCode) = False Then D4025.SupplierCode = Trim$(rs4025!K4025_SupplierCode)
    If IsdbNull(rs4025!K4025_CheckPresscript) = False Then D4025.CheckPresscript = Trim$(rs4025!K4025_CheckPresscript)
    If IsdbNull(rs4025!K4025_CheckInside) = False Then D4025.CheckInside = Trim$(rs4025!K4025_CheckInside)
    If IsdbNull(rs4025!K4025_CheckOutSide) = False Then D4025.CheckOutSide = Trim$(rs4025!K4025_CheckOutSide)
    If IsdbNull(rs4025!K4025_CheckPurchase) = False Then D4025.CheckPurchase = Trim$(rs4025!K4025_CheckPurchase)
    If IsdbNull(rs4025!K4025_CheckQuatity) = False Then D4025.CheckQuatity = Trim$(rs4025!K4025_CheckQuatity)
    If IsdbNull(rs4025!K4025_CheckPrice) = False Then D4025.CheckPrice = Trim$(rs4025!K4025_CheckPrice)
    If IsdbNull(rs4025!K4025_CheckLoss) = False Then D4025.CheckLoss = Trim$(rs4025!K4025_CheckLoss)
    If IsdbNull(rs4025!K4025_CheckTime) = False Then D4025.CheckTime = Trim$(rs4025!K4025_CheckTime)
    If IsdbNull(rs4025!K4025_CheckJob) = False Then D4025.CheckJob = Trim$(rs4025!K4025_CheckJob)
    If IsdbNull(rs4025!K4025_CheckMachine) = False Then D4025.CheckMachine = Trim$(rs4025!K4025_CheckMachine)
    If IsdbNull(rs4025!K4025_seMachineType) = False Then D4025.seMachineType = Trim$(rs4025!K4025_seMachineType)
    If IsdbNull(rs4025!K4025_cdMachineType) = False Then D4025.cdMachineType = Trim$(rs4025!K4025_cdMachineType)
    If IsdbNull(rs4025!K4025_CheckStatus) = False Then D4025.CheckStatus = Trim$(rs4025!K4025_CheckStatus)
    If IsdbNull(rs4025!K4025_DateStatus) = False Then D4025.DateStatus = Trim$(rs4025!K4025_DateStatus)
    If IsdbNull(rs4025!K4025_InchargeStatus) = False Then D4025.InchargeStatus = Trim$(rs4025!K4025_InchargeStatus)
    If IsdbNull(rs4025!K4025_WorkingNo) = False Then D4025.WorkingNo = Trim$(rs4025!K4025_WorkingNo)
    If IsdbNull(rs4025!K4025_Remark) = False Then D4025.Remark = Trim$(rs4025!K4025_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K4025_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K4025_MOVE(rs4025 As DataRow)
Try

    call D4025_CLEAR()   

    If IsdbNull(rs4025!K4025_WorkOrder) = False Then D4025.WorkOrder = Trim$(rs4025!K4025_WorkOrder)
    If IsdbNull(rs4025!K4025_WorkOrderSeq) = False Then D4025.WorkOrderSeq = Trim$(rs4025!K4025_WorkOrderSeq)
    If IsdbNull(rs4025!K4025_ProcessSeq) = False Then D4025.ProcessSeq = Trim$(rs4025!K4025_ProcessSeq)
    If IsdbNull(rs4025!K4025_Dseq) = False Then D4025.Dseq = Trim$(rs4025!K4025_Dseq)
    If IsdbNull(rs4025!K4025_seMainProcess) = False Then D4025.seMainProcess = Trim$(rs4025!K4025_seMainProcess)
    If IsdbNull(rs4025!K4025_cdMainProcess) = False Then D4025.cdMainProcess = Trim$(rs4025!K4025_cdMainProcess)
    If IsdbNull(rs4025!K4025_seSubProcess) = False Then D4025.seSubProcess = Trim$(rs4025!K4025_seSubProcess)
    If IsdbNull(rs4025!K4025_cdSubProcess) = False Then D4025.cdSubProcess = Trim$(rs4025!K4025_cdSubProcess)
    If IsdbNull(rs4025!K4025_Description) = False Then D4025.Description = Trim$(rs4025!K4025_Description)
    If IsdbNull(rs4025!K4025_Price) = False Then D4025.Price = Trim$(rs4025!K4025_Price)
    If IsdbNull(rs4025!K4025_Loss) = False Then D4025.Loss = Trim$(rs4025!K4025_Loss)
    If IsdbNull(rs4025!K4025_ProcessAMT) = False Then D4025.ProcessAMT = Trim$(rs4025!K4025_ProcessAMT)
    If IsdbNull(rs4025!K4025_TotalQty) = False Then D4025.TotalQty = Trim$(rs4025!K4025_TotalQty)
    If IsdbNull(rs4025!K4025_TotalProcessAMT) = False Then D4025.TotalProcessAMT = Trim$(rs4025!K4025_TotalProcessAMT)
    If IsdbNull(rs4025!K4025_seShoesStatus) = False Then D4025.seShoesStatus = Trim$(rs4025!K4025_seShoesStatus)
    If IsdbNull(rs4025!K4025_cdShoesStatus) = False Then D4025.cdShoesStatus = Trim$(rs4025!K4025_cdShoesStatus)
    If IsdbNull(rs4025!K4025_SupplierCode) = False Then D4025.SupplierCode = Trim$(rs4025!K4025_SupplierCode)
    If IsdbNull(rs4025!K4025_CheckPresscript) = False Then D4025.CheckPresscript = Trim$(rs4025!K4025_CheckPresscript)
    If IsdbNull(rs4025!K4025_CheckInside) = False Then D4025.CheckInside = Trim$(rs4025!K4025_CheckInside)
    If IsdbNull(rs4025!K4025_CheckOutSide) = False Then D4025.CheckOutSide = Trim$(rs4025!K4025_CheckOutSide)
    If IsdbNull(rs4025!K4025_CheckPurchase) = False Then D4025.CheckPurchase = Trim$(rs4025!K4025_CheckPurchase)
    If IsdbNull(rs4025!K4025_CheckQuatity) = False Then D4025.CheckQuatity = Trim$(rs4025!K4025_CheckQuatity)
    If IsdbNull(rs4025!K4025_CheckPrice) = False Then D4025.CheckPrice = Trim$(rs4025!K4025_CheckPrice)
    If IsdbNull(rs4025!K4025_CheckLoss) = False Then D4025.CheckLoss = Trim$(rs4025!K4025_CheckLoss)
    If IsdbNull(rs4025!K4025_CheckTime) = False Then D4025.CheckTime = Trim$(rs4025!K4025_CheckTime)
    If IsdbNull(rs4025!K4025_CheckJob) = False Then D4025.CheckJob = Trim$(rs4025!K4025_CheckJob)
    If IsdbNull(rs4025!K4025_CheckMachine) = False Then D4025.CheckMachine = Trim$(rs4025!K4025_CheckMachine)
    If IsdbNull(rs4025!K4025_seMachineType) = False Then D4025.seMachineType = Trim$(rs4025!K4025_seMachineType)
    If IsdbNull(rs4025!K4025_cdMachineType) = False Then D4025.cdMachineType = Trim$(rs4025!K4025_cdMachineType)
    If IsdbNull(rs4025!K4025_CheckStatus) = False Then D4025.CheckStatus = Trim$(rs4025!K4025_CheckStatus)
    If IsdbNull(rs4025!K4025_DateStatus) = False Then D4025.DateStatus = Trim$(rs4025!K4025_DateStatus)
    If IsdbNull(rs4025!K4025_InchargeStatus) = False Then D4025.InchargeStatus = Trim$(rs4025!K4025_InchargeStatus)
    If IsdbNull(rs4025!K4025_WorkingNo) = False Then D4025.WorkingNo = Trim$(rs4025!K4025_WorkingNo)
    If IsdbNull(rs4025!K4025_Remark) = False Then D4025.Remark = Trim$(rs4025!K4025_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K4025_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K4025_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z4025 As T4025_AREA, WORKORDER AS String, WORKORDERSEQ AS String, PROCESSSEQ AS String) as Boolean

K4025_MOVE = False

Try
    If READ_PFK4025(WORKORDER, WORKORDERSEQ, PROCESSSEQ) = True Then
                z4025 = D4025
		K4025_MOVE = True
		else
	z4025 = nothing
     End If

     If  getColumIndex(spr,"WorkOrder") > -1 then z4025.WorkOrder = getDataM(spr, getColumIndex(spr,"WorkOrder"), xRow)
     If  getColumIndex(spr,"WorkOrderSeq") > -1 then z4025.WorkOrderSeq = getDataM(spr, getColumIndex(spr,"WorkOrderSeq"), xRow)
     If  getColumIndex(spr,"ProcessSeq") > -1 then z4025.ProcessSeq = getDataM(spr, getColumIndex(spr,"ProcessSeq"), xRow)
     If  getColumIndex(spr,"Dseq") > -1 then z4025.Dseq = getDataM(spr, getColumIndex(spr,"Dseq"), xRow)
     If  getColumIndex(spr,"seMainProcess") > -1 then z4025.seMainProcess = getDataM(spr, getColumIndex(spr,"seMainProcess"), xRow)
     If  getColumIndex(spr,"cdMainProcess") > -1 then z4025.cdMainProcess = getDataM(spr, getColumIndex(spr,"cdMainProcess"), xRow)
     If  getColumIndex(spr,"seSubProcess") > -1 then z4025.seSubProcess = getDataM(spr, getColumIndex(spr,"seSubProcess"), xRow)
     If  getColumIndex(spr,"cdSubProcess") > -1 then z4025.cdSubProcess = getDataM(spr, getColumIndex(spr,"cdSubProcess"), xRow)
     If  getColumIndex(spr,"Description") > -1 then z4025.Description = getDataM(spr, getColumIndex(spr,"Description"), xRow)
     If  getColumIndex(spr,"Price") > -1 then z4025.Price = getDataM(spr, getColumIndex(spr,"Price"), xRow)
     If  getColumIndex(spr,"Loss") > -1 then z4025.Loss = getDataM(spr, getColumIndex(spr,"Loss"), xRow)
     If  getColumIndex(spr,"ProcessAMT") > -1 then z4025.ProcessAMT = getDataM(spr, getColumIndex(spr,"ProcessAMT"), xRow)
     If  getColumIndex(spr,"TotalQty") > -1 then z4025.TotalQty = getDataM(spr, getColumIndex(spr,"TotalQty"), xRow)
     If  getColumIndex(spr,"TotalProcessAMT") > -1 then z4025.TotalProcessAMT = getDataM(spr, getColumIndex(spr,"TotalProcessAMT"), xRow)
     If  getColumIndex(spr,"seShoesStatus") > -1 then z4025.seShoesStatus = getDataM(spr, getColumIndex(spr,"seShoesStatus"), xRow)
     If  getColumIndex(spr,"cdShoesStatus") > -1 then z4025.cdShoesStatus = getDataM(spr, getColumIndex(spr,"cdShoesStatus"), xRow)
     If  getColumIndex(spr,"SupplierCode") > -1 then z4025.SupplierCode = getDataM(spr, getColumIndex(spr,"SupplierCode"), xRow)
     If  getColumIndex(spr,"CheckPresscript") > -1 then z4025.CheckPresscript = getDataM(spr, getColumIndex(spr,"CheckPresscript"), xRow)
     If  getColumIndex(spr,"CheckInside") > -1 then z4025.CheckInside = getDataM(spr, getColumIndex(spr,"CheckInside"), xRow)
     If  getColumIndex(spr,"CheckOutSide") > -1 then z4025.CheckOutSide = getDataM(spr, getColumIndex(spr,"CheckOutSide"), xRow)
     If  getColumIndex(spr,"CheckPurchase") > -1 then z4025.CheckPurchase = getDataM(spr, getColumIndex(spr,"CheckPurchase"), xRow)
     If  getColumIndex(spr,"CheckQuatity") > -1 then z4025.CheckQuatity = getDataM(spr, getColumIndex(spr,"CheckQuatity"), xRow)
     If  getColumIndex(spr,"CheckPrice") > -1 then z4025.CheckPrice = getDataM(spr, getColumIndex(spr,"CheckPrice"), xRow)
     If  getColumIndex(spr,"CheckLoss") > -1 then z4025.CheckLoss = getDataM(spr, getColumIndex(spr,"CheckLoss"), xRow)
     If  getColumIndex(spr,"CheckTime") > -1 then z4025.CheckTime = getDataM(spr, getColumIndex(spr,"CheckTime"), xRow)
     If  getColumIndex(spr,"CheckJob") > -1 then z4025.CheckJob = getDataM(spr, getColumIndex(spr,"CheckJob"), xRow)
     If  getColumIndex(spr,"CheckMachine") > -1 then z4025.CheckMachine = getDataM(spr, getColumIndex(spr,"CheckMachine"), xRow)
     If  getColumIndex(spr,"seMachineType") > -1 then z4025.seMachineType = getDataM(spr, getColumIndex(spr,"seMachineType"), xRow)
     If  getColumIndex(spr,"cdMachineType") > -1 then z4025.cdMachineType = getDataM(spr, getColumIndex(spr,"cdMachineType"), xRow)
     If  getColumIndex(spr,"CheckStatus") > -1 then z4025.CheckStatus = getDataM(spr, getColumIndex(spr,"CheckStatus"), xRow)
     If  getColumIndex(spr,"DateStatus") > -1 then z4025.DateStatus = getDataM(spr, getColumIndex(spr,"DateStatus"), xRow)
     If  getColumIndex(spr,"InchargeStatus") > -1 then z4025.InchargeStatus = getDataM(spr, getColumIndex(spr,"InchargeStatus"), xRow)
     If  getColumIndex(spr,"WorkingNo") > -1 then z4025.WorkingNo = getDataM(spr, getColumIndex(spr,"WorkingNo"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z4025.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K4025_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K4025_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z4025 As T4025_AREA,CheckClear as Boolean,WORKORDER AS String, WORKORDERSEQ AS String, PROCESSSEQ AS String) as Boolean

K4025_MOVE = False

Try
    If READ_PFK4025(WORKORDER, WORKORDERSEQ, PROCESSSEQ) = True Then
                z4025 = D4025
		K4025_MOVE = True
		else
	If CheckClear  = True then z4025 = nothing
     End If

     If  getColumIndex(spr,"WorkOrder") > -1 then z4025.WorkOrder = getDataM(spr, getColumIndex(spr,"WorkOrder"), xRow)
     If  getColumIndex(spr,"WorkOrderSeq") > -1 then z4025.WorkOrderSeq = getDataM(spr, getColumIndex(spr,"WorkOrderSeq"), xRow)
     If  getColumIndex(spr,"ProcessSeq") > -1 then z4025.ProcessSeq = getDataM(spr, getColumIndex(spr,"ProcessSeq"), xRow)
     If  getColumIndex(spr,"Dseq") > -1 then z4025.Dseq = getDataM(spr, getColumIndex(spr,"Dseq"), xRow)
     If  getColumIndex(spr,"seMainProcess") > -1 then z4025.seMainProcess = getDataM(spr, getColumIndex(spr,"seMainProcess"), xRow)
     If  getColumIndex(spr,"cdMainProcess") > -1 then z4025.cdMainProcess = getDataM(spr, getColumIndex(spr,"cdMainProcess"), xRow)
     If  getColumIndex(spr,"seSubProcess") > -1 then z4025.seSubProcess = getDataM(spr, getColumIndex(spr,"seSubProcess"), xRow)
     If  getColumIndex(spr,"cdSubProcess") > -1 then z4025.cdSubProcess = getDataM(spr, getColumIndex(spr,"cdSubProcess"), xRow)
     If  getColumIndex(spr,"Description") > -1 then z4025.Description = getDataM(spr, getColumIndex(spr,"Description"), xRow)
     If  getColumIndex(spr,"Price") > -1 then z4025.Price = getDataM(spr, getColumIndex(spr,"Price"), xRow)
     If  getColumIndex(spr,"Loss") > -1 then z4025.Loss = getDataM(spr, getColumIndex(spr,"Loss"), xRow)
     If  getColumIndex(spr,"ProcessAMT") > -1 then z4025.ProcessAMT = getDataM(spr, getColumIndex(spr,"ProcessAMT"), xRow)
     If  getColumIndex(spr,"TotalQty") > -1 then z4025.TotalQty = getDataM(spr, getColumIndex(spr,"TotalQty"), xRow)
     If  getColumIndex(spr,"TotalProcessAMT") > -1 then z4025.TotalProcessAMT = getDataM(spr, getColumIndex(spr,"TotalProcessAMT"), xRow)
     If  getColumIndex(spr,"seShoesStatus") > -1 then z4025.seShoesStatus = getDataM(spr, getColumIndex(spr,"seShoesStatus"), xRow)
     If  getColumIndex(spr,"cdShoesStatus") > -1 then z4025.cdShoesStatus = getDataM(spr, getColumIndex(spr,"cdShoesStatus"), xRow)
     If  getColumIndex(spr,"SupplierCode") > -1 then z4025.SupplierCode = getDataM(spr, getColumIndex(spr,"SupplierCode"), xRow)
     If  getColumIndex(spr,"CheckPresscript") > -1 then z4025.CheckPresscript = getDataM(spr, getColumIndex(spr,"CheckPresscript"), xRow)
     If  getColumIndex(spr,"CheckInside") > -1 then z4025.CheckInside = getDataM(spr, getColumIndex(spr,"CheckInside"), xRow)
     If  getColumIndex(spr,"CheckOutSide") > -1 then z4025.CheckOutSide = getDataM(spr, getColumIndex(spr,"CheckOutSide"), xRow)
     If  getColumIndex(spr,"CheckPurchase") > -1 then z4025.CheckPurchase = getDataM(spr, getColumIndex(spr,"CheckPurchase"), xRow)
     If  getColumIndex(spr,"CheckQuatity") > -1 then z4025.CheckQuatity = getDataM(spr, getColumIndex(spr,"CheckQuatity"), xRow)
     If  getColumIndex(spr,"CheckPrice") > -1 then z4025.CheckPrice = getDataM(spr, getColumIndex(spr,"CheckPrice"), xRow)
     If  getColumIndex(spr,"CheckLoss") > -1 then z4025.CheckLoss = getDataM(spr, getColumIndex(spr,"CheckLoss"), xRow)
     If  getColumIndex(spr,"CheckTime") > -1 then z4025.CheckTime = getDataM(spr, getColumIndex(spr,"CheckTime"), xRow)
     If  getColumIndex(spr,"CheckJob") > -1 then z4025.CheckJob = getDataM(spr, getColumIndex(spr,"CheckJob"), xRow)
     If  getColumIndex(spr,"CheckMachine") > -1 then z4025.CheckMachine = getDataM(spr, getColumIndex(spr,"CheckMachine"), xRow)
     If  getColumIndex(spr,"seMachineType") > -1 then z4025.seMachineType = getDataM(spr, getColumIndex(spr,"seMachineType"), xRow)
     If  getColumIndex(spr,"cdMachineType") > -1 then z4025.cdMachineType = getDataM(spr, getColumIndex(spr,"cdMachineType"), xRow)
     If  getColumIndex(spr,"CheckStatus") > -1 then z4025.CheckStatus = getDataM(spr, getColumIndex(spr,"CheckStatus"), xRow)
     If  getColumIndex(spr,"DateStatus") > -1 then z4025.DateStatus = getDataM(spr, getColumIndex(spr,"DateStatus"), xRow)
     If  getColumIndex(spr,"InchargeStatus") > -1 then z4025.InchargeStatus = getDataM(spr, getColumIndex(spr,"InchargeStatus"), xRow)
     If  getColumIndex(spr,"WorkingNo") > -1 then z4025.WorkingNo = getDataM(spr, getColumIndex(spr,"WorkingNo"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z4025.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K4025_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K4025_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z4025 As T4025_AREA, Job as String, WORKORDER AS String, WORKORDERSEQ AS String, PROCESSSEQ AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K4025_MOVE = False

Try
    If READ_PFK4025(WORKORDER, WORKORDERSEQ, PROCESSSEQ) = True Then
                z4025 = D4025
		K4025_MOVE = True
		else
	z4025 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4025")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "WORKORDER":z4025.WorkOrder = Children(i).Code
   Case "WORKORDERSEQ":z4025.WorkOrderSeq = Children(i).Code
   Case "PROCESSSEQ":z4025.ProcessSeq = Children(i).Code
   Case "DSEQ":z4025.Dseq = Children(i).Code
   Case "SEMAINPROCESS":z4025.seMainProcess = Children(i).Code
   Case "CDMAINPROCESS":z4025.cdMainProcess = Children(i).Code
   Case "SESUBPROCESS":z4025.seSubProcess = Children(i).Code
   Case "CDSUBPROCESS":z4025.cdSubProcess = Children(i).Code
   Case "DESCRIPTION":z4025.Description = Children(i).Code
   Case "PRICE":z4025.Price = Children(i).Code
   Case "LOSS":z4025.Loss = Children(i).Code
   Case "PROCESSAMT":z4025.ProcessAMT = Children(i).Code
   Case "TOTALQTY":z4025.TotalQty = Children(i).Code
   Case "TOTALPROCESSAMT":z4025.TotalProcessAMT = Children(i).Code
   Case "SESHOESSTATUS":z4025.seShoesStatus = Children(i).Code
   Case "CDSHOESSTATUS":z4025.cdShoesStatus = Children(i).Code
   Case "SUPPLIERCODE":z4025.SupplierCode = Children(i).Code
   Case "CHECKPRESSCRIPT":z4025.CheckPresscript = Children(i).Code
   Case "CHECKINSIDE":z4025.CheckInside = Children(i).Code
   Case "CHECKOUTSIDE":z4025.CheckOutSide = Children(i).Code
   Case "CHECKPURCHASE":z4025.CheckPurchase = Children(i).Code
   Case "CHECKQUATITY":z4025.CheckQuatity = Children(i).Code
   Case "CHECKPRICE":z4025.CheckPrice = Children(i).Code
   Case "CHECKLOSS":z4025.CheckLoss = Children(i).Code
   Case "CHECKTIME":z4025.CheckTime = Children(i).Code
   Case "CHECKJOB":z4025.CheckJob = Children(i).Code
   Case "CHECKMACHINE":z4025.CheckMachine = Children(i).Code
   Case "SEMACHINETYPE":z4025.seMachineType = Children(i).Code
   Case "CDMACHINETYPE":z4025.cdMachineType = Children(i).Code
   Case "CHECKSTATUS":z4025.CheckStatus = Children(i).Code
   Case "DATESTATUS":z4025.DateStatus = Children(i).Code
   Case "INCHARGESTATUS":z4025.InchargeStatus = Children(i).Code
   Case "WORKINGNO":z4025.WorkingNo = Children(i).Code
   Case "REMARK":z4025.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "WORKORDER":z4025.WorkOrder = Children(i).Data
   Case "WORKORDERSEQ":z4025.WorkOrderSeq = Children(i).Data
   Case "PROCESSSEQ":z4025.ProcessSeq = Children(i).Data
   Case "DSEQ":z4025.Dseq = Children(i).Data
   Case "SEMAINPROCESS":z4025.seMainProcess = Children(i).Data
   Case "CDMAINPROCESS":z4025.cdMainProcess = Children(i).Data
   Case "SESUBPROCESS":z4025.seSubProcess = Children(i).Data
   Case "CDSUBPROCESS":z4025.cdSubProcess = Children(i).Data
   Case "DESCRIPTION":z4025.Description = Children(i).Data
   Case "PRICE":z4025.Price = Children(i).Data
   Case "LOSS":z4025.Loss = Children(i).Data
   Case "PROCESSAMT":z4025.ProcessAMT = Children(i).Data
   Case "TOTALQTY":z4025.TotalQty = Children(i).Data
   Case "TOTALPROCESSAMT":z4025.TotalProcessAMT = Children(i).Data
   Case "SESHOESSTATUS":z4025.seShoesStatus = Children(i).Data
   Case "CDSHOESSTATUS":z4025.cdShoesStatus = Children(i).Data
   Case "SUPPLIERCODE":z4025.SupplierCode = Children(i).Data
   Case "CHECKPRESSCRIPT":z4025.CheckPresscript = Children(i).Data
   Case "CHECKINSIDE":z4025.CheckInside = Children(i).Data
   Case "CHECKOUTSIDE":z4025.CheckOutSide = Children(i).Data
   Case "CHECKPURCHASE":z4025.CheckPurchase = Children(i).Data
   Case "CHECKQUATITY":z4025.CheckQuatity = Children(i).Data
   Case "CHECKPRICE":z4025.CheckPrice = Children(i).Data
   Case "CHECKLOSS":z4025.CheckLoss = Children(i).Data
   Case "CHECKTIME":z4025.CheckTime = Children(i).Data
   Case "CHECKJOB":z4025.CheckJob = Children(i).Data
   Case "CHECKMACHINE":z4025.CheckMachine = Children(i).Data
   Case "SEMACHINETYPE":z4025.seMachineType = Children(i).Data
   Case "CDMACHINETYPE":z4025.cdMachineType = Children(i).Data
   Case "CHECKSTATUS":z4025.CheckStatus = Children(i).Data
   Case "DATESTATUS":z4025.DateStatus = Children(i).Data
   Case "INCHARGESTATUS":z4025.InchargeStatus = Children(i).Data
   Case "WORKINGNO":z4025.WorkingNo = Children(i).Data
   Case "REMARK":z4025.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K4025_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K4025_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z4025 As T4025_AREA, Job as String, CheckClear as Boolean, WORKORDER AS String, WORKORDERSEQ AS String, PROCESSSEQ AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K4025_MOVE = False

Try
    If READ_PFK4025(WORKORDER, WORKORDERSEQ, PROCESSSEQ) = True Then
                z4025 = D4025
		K4025_MOVE = True
		else
	If CheckClear  = True then z4025 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4025")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "WORKORDER":z4025.WorkOrder = Children(i).Code
   Case "WORKORDERSEQ":z4025.WorkOrderSeq = Children(i).Code
   Case "PROCESSSEQ":z4025.ProcessSeq = Children(i).Code
   Case "DSEQ":z4025.Dseq = Children(i).Code
   Case "SEMAINPROCESS":z4025.seMainProcess = Children(i).Code
   Case "CDMAINPROCESS":z4025.cdMainProcess = Children(i).Code
   Case "SESUBPROCESS":z4025.seSubProcess = Children(i).Code
   Case "CDSUBPROCESS":z4025.cdSubProcess = Children(i).Code
   Case "DESCRIPTION":z4025.Description = Children(i).Code
   Case "PRICE":z4025.Price = Children(i).Code
   Case "LOSS":z4025.Loss = Children(i).Code
   Case "PROCESSAMT":z4025.ProcessAMT = Children(i).Code
   Case "TOTALQTY":z4025.TotalQty = Children(i).Code
   Case "TOTALPROCESSAMT":z4025.TotalProcessAMT = Children(i).Code
   Case "SESHOESSTATUS":z4025.seShoesStatus = Children(i).Code
   Case "CDSHOESSTATUS":z4025.cdShoesStatus = Children(i).Code
   Case "SUPPLIERCODE":z4025.SupplierCode = Children(i).Code
   Case "CHECKPRESSCRIPT":z4025.CheckPresscript = Children(i).Code
   Case "CHECKINSIDE":z4025.CheckInside = Children(i).Code
   Case "CHECKOUTSIDE":z4025.CheckOutSide = Children(i).Code
   Case "CHECKPURCHASE":z4025.CheckPurchase = Children(i).Code
   Case "CHECKQUATITY":z4025.CheckQuatity = Children(i).Code
   Case "CHECKPRICE":z4025.CheckPrice = Children(i).Code
   Case "CHECKLOSS":z4025.CheckLoss = Children(i).Code
   Case "CHECKTIME":z4025.CheckTime = Children(i).Code
   Case "CHECKJOB":z4025.CheckJob = Children(i).Code
   Case "CHECKMACHINE":z4025.CheckMachine = Children(i).Code
   Case "SEMACHINETYPE":z4025.seMachineType = Children(i).Code
   Case "CDMACHINETYPE":z4025.cdMachineType = Children(i).Code
   Case "CHECKSTATUS":z4025.CheckStatus = Children(i).Code
   Case "DATESTATUS":z4025.DateStatus = Children(i).Code
   Case "INCHARGESTATUS":z4025.InchargeStatus = Children(i).Code
   Case "WORKINGNO":z4025.WorkingNo = Children(i).Code
   Case "REMARK":z4025.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "WORKORDER":z4025.WorkOrder = Children(i).Data
   Case "WORKORDERSEQ":z4025.WorkOrderSeq = Children(i).Data
   Case "PROCESSSEQ":z4025.ProcessSeq = Children(i).Data
   Case "DSEQ":z4025.Dseq = Children(i).Data
   Case "SEMAINPROCESS":z4025.seMainProcess = Children(i).Data
   Case "CDMAINPROCESS":z4025.cdMainProcess = Children(i).Data
   Case "SESUBPROCESS":z4025.seSubProcess = Children(i).Data
   Case "CDSUBPROCESS":z4025.cdSubProcess = Children(i).Data
   Case "DESCRIPTION":z4025.Description = Children(i).Data
   Case "PRICE":z4025.Price = Children(i).Data
   Case "LOSS":z4025.Loss = Children(i).Data
   Case "PROCESSAMT":z4025.ProcessAMT = Children(i).Data
   Case "TOTALQTY":z4025.TotalQty = Children(i).Data
   Case "TOTALPROCESSAMT":z4025.TotalProcessAMT = Children(i).Data
   Case "SESHOESSTATUS":z4025.seShoesStatus = Children(i).Data
   Case "CDSHOESSTATUS":z4025.cdShoesStatus = Children(i).Data
   Case "SUPPLIERCODE":z4025.SupplierCode = Children(i).Data
   Case "CHECKPRESSCRIPT":z4025.CheckPresscript = Children(i).Data
   Case "CHECKINSIDE":z4025.CheckInside = Children(i).Data
   Case "CHECKOUTSIDE":z4025.CheckOutSide = Children(i).Data
   Case "CHECKPURCHASE":z4025.CheckPurchase = Children(i).Data
   Case "CHECKQUATITY":z4025.CheckQuatity = Children(i).Data
   Case "CHECKPRICE":z4025.CheckPrice = Children(i).Data
   Case "CHECKLOSS":z4025.CheckLoss = Children(i).Data
   Case "CHECKTIME":z4025.CheckTime = Children(i).Data
   Case "CHECKJOB":z4025.CheckJob = Children(i).Data
   Case "CHECKMACHINE":z4025.CheckMachine = Children(i).Data
   Case "SEMACHINETYPE":z4025.seMachineType = Children(i).Data
   Case "CDMACHINETYPE":z4025.cdMachineType = Children(i).Data
   Case "CHECKSTATUS":z4025.CheckStatus = Children(i).Data
   Case "DATESTATUS":z4025.DateStatus = Children(i).Data
   Case "INCHARGESTATUS":z4025.InchargeStatus = Children(i).Data
   Case "WORKINGNO":z4025.WorkingNo = Children(i).Data
   Case "REMARK":z4025.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K4025_MOVE",vbCritical)
End Try
End Function 
    
End Module 
