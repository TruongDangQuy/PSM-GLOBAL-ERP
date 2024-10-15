'=========================================================================================================================================================
'   TABLE : (PFK0121)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K0121

Structure T0121_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	SpecNo	 AS String	'			char(9)		*
Public 	SpecNoSeq	 AS String	'			char(3)		*
Public 	ProcessSeq	 AS String	'			char(3)		*
Public 	Dseq	 AS Double	'			decimal
Public 	seMainProcess	 AS String	'			char(3)
Public 	cdMainProcess	 AS String	'			char(3)
Public 	seSubProcess	 AS String	'			char(3)
Public 	cdSubProcess	 AS String	'			char(3)
Public 	Description	 AS String	'			nvarchar(200)
Public 	Cost	 AS Double	'			decimal
Public 	Loss	 AS Double	'			decimal
Public 	ProcessAMT	 AS Double	'			decimal
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
Public 	Remark	 AS String	'			nvarchar(50)
'=========================================================================================================================================================
End structure

Public D0121 As T0121_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK0121(SPECNO AS String, SPECNOSEQ AS String, PROCESSSEQ AS String) As Boolean
    READ_PFK0121 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK0121 "
    SQL = SQL & " WHERE K0121_SpecNo		 = '" & SpecNo & "' " 
    SQL = SQL & "   AND K0121_SpecNoSeq		 = '" & SpecNoSeq & "' " 
    SQL = SQL & "   AND K0121_ProcessSeq		 = '" & ProcessSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D0121_CLEAR: GoTo SKIP_READ_PFK0121
                
    Call K0121_MOVE(rd)
    READ_PFK0121 = True

SKIP_READ_PFK0121:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK0121",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK0121(SPECNO AS String, SPECNOSEQ AS String, PROCESSSEQ AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK0121 "
    SQL = SQL & " WHERE K0121_SpecNo		 = '" & SpecNo & "' " 
    SQL = SQL & "   AND K0121_SpecNoSeq		 = '" & SpecNoSeq & "' " 
    SQL = SQL & "   AND K0121_ProcessSeq		 = '" & ProcessSeq & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK0121",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK0121(z0121 As T0121_AREA) As Boolean
    WRITE_PFK0121 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z0121)
 
    SQL = " INSERT INTO PFK0121 "
    SQL = SQL & " ( "
    SQL = SQL & " K0121_SpecNo," 
    SQL = SQL & " K0121_SpecNoSeq," 
    SQL = SQL & " K0121_ProcessSeq," 
    SQL = SQL & " K0121_Dseq," 
    SQL = SQL & " K0121_seMainProcess," 
    SQL = SQL & " K0121_cdMainProcess," 
    SQL = SQL & " K0121_seSubProcess," 
    SQL = SQL & " K0121_cdSubProcess," 
    SQL = SQL & " K0121_Description," 
    SQL = SQL & " K0121_Cost," 
    SQL = SQL & " K0121_Loss," 
    SQL = SQL & " K0121_ProcessAMT," 
    SQL = SQL & " K0121_seShoesStatus," 
    SQL = SQL & " K0121_cdShoesStatus," 
    SQL = SQL & " K0121_SupplierCode," 
    SQL = SQL & " K0121_CheckPresscript," 
    SQL = SQL & " K0121_CheckInside," 
    SQL = SQL & " K0121_CheckOutSide," 
    SQL = SQL & " K0121_CheckPurchase," 
    SQL = SQL & " K0121_CheckQuatity," 
    SQL = SQL & " K0121_CheckPrice," 
    SQL = SQL & " K0121_CheckLoss," 
    SQL = SQL & " K0121_CheckTime," 
    SQL = SQL & " K0121_CheckJob," 
    SQL = SQL & " K0121_CheckMachine," 
    SQL = SQL & " K0121_seMachineType," 
    SQL = SQL & " K0121_cdMachineType," 
    SQL = SQL & " K0121_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z0121.SpecNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0121.SpecNoSeq) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0121.ProcessSeq) & "', "  
    SQL = SQL & "   " & FormatSQL(z0121.Dseq) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z0121.seMainProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0121.cdMainProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0121.seSubProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0121.cdSubProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0121.Description) & "', "  
    SQL = SQL & "   " & FormatSQL(z0121.Cost) & ", "  
    SQL = SQL & "   " & FormatSQL(z0121.Loss) & ", "  
    SQL = SQL & "   " & FormatSQL(z0121.ProcessAMT) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z0121.seShoesStatus) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0121.cdShoesStatus) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0121.SupplierCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0121.CheckPresscript) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0121.CheckInside) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0121.CheckOutSide) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0121.CheckPurchase) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0121.CheckQuatity) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0121.CheckPrice) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0121.CheckLoss) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0121.CheckTime) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0121.CheckJob) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0121.CheckMachine) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0121.seMachineType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0121.cdMachineType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0121.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK0121 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK0121",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK0121(z0121 As T0121_AREA) As Boolean
    REWRITE_PFK0121 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z0121)
   
    SQL = " UPDATE PFK0121 SET "
    SQL = SQL & "    K0121_Dseq      =  " & FormatSQL(z0121.Dseq) & ", " 
    SQL = SQL & "    K0121_seMainProcess      = N'" & FormatSQL(z0121.seMainProcess) & "', " 
    SQL = SQL & "    K0121_cdMainProcess      = N'" & FormatSQL(z0121.cdMainProcess) & "', " 
    SQL = SQL & "    K0121_seSubProcess      = N'" & FormatSQL(z0121.seSubProcess) & "', " 
    SQL = SQL & "    K0121_cdSubProcess      = N'" & FormatSQL(z0121.cdSubProcess) & "', " 
    SQL = SQL & "    K0121_Description      = N'" & FormatSQL(z0121.Description) & "', " 
    SQL = SQL & "    K0121_Cost      =  " & FormatSQL(z0121.Cost) & ", " 
    SQL = SQL & "    K0121_Loss      =  " & FormatSQL(z0121.Loss) & ", " 
    SQL = SQL & "    K0121_ProcessAMT      =  " & FormatSQL(z0121.ProcessAMT) & ", " 
    SQL = SQL & "    K0121_seShoesStatus      = N'" & FormatSQL(z0121.seShoesStatus) & "', " 
    SQL = SQL & "    K0121_cdShoesStatus      = N'" & FormatSQL(z0121.cdShoesStatus) & "', " 
    SQL = SQL & "    K0121_SupplierCode      = N'" & FormatSQL(z0121.SupplierCode) & "', " 
    SQL = SQL & "    K0121_CheckPresscript      = N'" & FormatSQL(z0121.CheckPresscript) & "', " 
    SQL = SQL & "    K0121_CheckInside      = N'" & FormatSQL(z0121.CheckInside) & "', " 
    SQL = SQL & "    K0121_CheckOutSide      = N'" & FormatSQL(z0121.CheckOutSide) & "', " 
    SQL = SQL & "    K0121_CheckPurchase      = N'" & FormatSQL(z0121.CheckPurchase) & "', " 
    SQL = SQL & "    K0121_CheckQuatity      = N'" & FormatSQL(z0121.CheckQuatity) & "', " 
    SQL = SQL & "    K0121_CheckPrice      = N'" & FormatSQL(z0121.CheckPrice) & "', " 
    SQL = SQL & "    K0121_CheckLoss      = N'" & FormatSQL(z0121.CheckLoss) & "', " 
    SQL = SQL & "    K0121_CheckTime      = N'" & FormatSQL(z0121.CheckTime) & "', " 
    SQL = SQL & "    K0121_CheckJob      = N'" & FormatSQL(z0121.CheckJob) & "', " 
    SQL = SQL & "    K0121_CheckMachine      = N'" & FormatSQL(z0121.CheckMachine) & "', " 
    SQL = SQL & "    K0121_seMachineType      = N'" & FormatSQL(z0121.seMachineType) & "', " 
    SQL = SQL & "    K0121_cdMachineType      = N'" & FormatSQL(z0121.cdMachineType) & "', " 
    SQL = SQL & "    K0121_Remark      = N'" & FormatSQL(z0121.Remark) & "'  " 
    SQL = SQL & " WHERE K0121_SpecNo		 = '" & z0121.SpecNo & "' " 
    SQL = SQL & "   AND K0121_SpecNoSeq		 = '" & z0121.SpecNoSeq & "' " 
    SQL = SQL & "   AND K0121_ProcessSeq		 = '" & z0121.ProcessSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK0121 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK0121",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK0121(z0121 As T0121_AREA) As Boolean
    DELETE_PFK0121 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK0121 "
    SQL = SQL & " WHERE K0121_SpecNo		 = '" & z0121.SpecNo & "' " 
    SQL = SQL & "   AND K0121_SpecNoSeq		 = '" & z0121.SpecNoSeq & "' " 
    SQL = SQL & "   AND K0121_ProcessSeq		 = '" & z0121.ProcessSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK0121 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK0121",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D0121_CLEAR()
Try
    
   D0121.SpecNo = ""
   D0121.SpecNoSeq = ""
   D0121.ProcessSeq = ""
    D0121.Dseq = 0 
   D0121.seMainProcess = ""
   D0121.cdMainProcess = ""
   D0121.seSubProcess = ""
   D0121.cdSubProcess = ""
   D0121.Description = ""
    D0121.Cost = 0 
    D0121.Loss = 0 
    D0121.ProcessAMT = 0 
   D0121.seShoesStatus = ""
   D0121.cdShoesStatus = ""
   D0121.SupplierCode = ""
   D0121.CheckPresscript = ""
   D0121.CheckInside = ""
   D0121.CheckOutSide = ""
   D0121.CheckPurchase = ""
   D0121.CheckQuatity = ""
   D0121.CheckPrice = ""
   D0121.CheckLoss = ""
   D0121.CheckTime = ""
   D0121.CheckJob = ""
   D0121.CheckMachine = ""
   D0121.seMachineType = ""
   D0121.cdMachineType = ""
   D0121.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D0121_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x0121 As T0121_AREA)
Try
    
    x0121.SpecNo = trim$(  x0121.SpecNo)
    x0121.SpecNoSeq = trim$(  x0121.SpecNoSeq)
    x0121.ProcessSeq = trim$(  x0121.ProcessSeq)
    x0121.Dseq = trim$(  x0121.Dseq)
    x0121.seMainProcess = trim$(  x0121.seMainProcess)
    x0121.cdMainProcess = trim$(  x0121.cdMainProcess)
    x0121.seSubProcess = trim$(  x0121.seSubProcess)
    x0121.cdSubProcess = trim$(  x0121.cdSubProcess)
    x0121.Description = trim$(  x0121.Description)
    x0121.Cost = trim$(  x0121.Cost)
    x0121.Loss = trim$(  x0121.Loss)
    x0121.ProcessAMT = trim$(  x0121.ProcessAMT)
    x0121.seShoesStatus = trim$(  x0121.seShoesStatus)
    x0121.cdShoesStatus = trim$(  x0121.cdShoesStatus)
    x0121.SupplierCode = trim$(  x0121.SupplierCode)
    x0121.CheckPresscript = trim$(  x0121.CheckPresscript)
    x0121.CheckInside = trim$(  x0121.CheckInside)
    x0121.CheckOutSide = trim$(  x0121.CheckOutSide)
    x0121.CheckPurchase = trim$(  x0121.CheckPurchase)
    x0121.CheckQuatity = trim$(  x0121.CheckQuatity)
    x0121.CheckPrice = trim$(  x0121.CheckPrice)
    x0121.CheckLoss = trim$(  x0121.CheckLoss)
    x0121.CheckTime = trim$(  x0121.CheckTime)
    x0121.CheckJob = trim$(  x0121.CheckJob)
    x0121.CheckMachine = trim$(  x0121.CheckMachine)
    x0121.seMachineType = trim$(  x0121.seMachineType)
    x0121.cdMachineType = trim$(  x0121.cdMachineType)
    x0121.Remark = trim$(  x0121.Remark)
     
    If trim$( x0121.SpecNo ) = "" Then x0121.SpecNo = Space(1) 
    If trim$( x0121.SpecNoSeq ) = "" Then x0121.SpecNoSeq = Space(1) 
    If trim$( x0121.ProcessSeq ) = "" Then x0121.ProcessSeq = Space(1) 
    If trim$( x0121.Dseq ) = "" Then x0121.Dseq = 0 
    If trim$( x0121.seMainProcess ) = "" Then x0121.seMainProcess = Space(1) 
    If trim$( x0121.cdMainProcess ) = "" Then x0121.cdMainProcess = Space(1) 
    If trim$( x0121.seSubProcess ) = "" Then x0121.seSubProcess = Space(1) 
    If trim$( x0121.cdSubProcess ) = "" Then x0121.cdSubProcess = Space(1) 
    If trim$( x0121.Description ) = "" Then x0121.Description = Space(1) 
    If trim$( x0121.Cost ) = "" Then x0121.Cost = 0 
    If trim$( x0121.Loss ) = "" Then x0121.Loss = 0 
    If trim$( x0121.ProcessAMT ) = "" Then x0121.ProcessAMT = 0 
    If trim$( x0121.seShoesStatus ) = "" Then x0121.seShoesStatus = Space(1) 
    If trim$( x0121.cdShoesStatus ) = "" Then x0121.cdShoesStatus = Space(1) 
    If trim$( x0121.SupplierCode ) = "" Then x0121.SupplierCode = Space(1) 
    If trim$( x0121.CheckPresscript ) = "" Then x0121.CheckPresscript = Space(1) 
    If trim$( x0121.CheckInside ) = "" Then x0121.CheckInside = Space(1) 
    If trim$( x0121.CheckOutSide ) = "" Then x0121.CheckOutSide = Space(1) 
    If trim$( x0121.CheckPurchase ) = "" Then x0121.CheckPurchase = Space(1) 
    If trim$( x0121.CheckQuatity ) = "" Then x0121.CheckQuatity = Space(1) 
    If trim$( x0121.CheckPrice ) = "" Then x0121.CheckPrice = Space(1) 
    If trim$( x0121.CheckLoss ) = "" Then x0121.CheckLoss = Space(1) 
    If trim$( x0121.CheckTime ) = "" Then x0121.CheckTime = Space(1) 
    If trim$( x0121.CheckJob ) = "" Then x0121.CheckJob = Space(1) 
    If trim$( x0121.CheckMachine ) = "" Then x0121.CheckMachine = Space(1) 
    If trim$( x0121.seMachineType ) = "" Then x0121.seMachineType = Space(1) 
    If trim$( x0121.cdMachineType ) = "" Then x0121.cdMachineType = Space(1) 
    If trim$( x0121.Remark ) = "" Then x0121.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K0121_MOVE(rs0121 As SqlClient.SqlDataReader)
Try

    call D0121_CLEAR()   

    If IsdbNull(rs0121!K0121_SpecNo) = False Then D0121.SpecNo = Trim$(rs0121!K0121_SpecNo)
    If IsdbNull(rs0121!K0121_SpecNoSeq) = False Then D0121.SpecNoSeq = Trim$(rs0121!K0121_SpecNoSeq)
    If IsdbNull(rs0121!K0121_ProcessSeq) = False Then D0121.ProcessSeq = Trim$(rs0121!K0121_ProcessSeq)
    If IsdbNull(rs0121!K0121_Dseq) = False Then D0121.Dseq = Trim$(rs0121!K0121_Dseq)
    If IsdbNull(rs0121!K0121_seMainProcess) = False Then D0121.seMainProcess = Trim$(rs0121!K0121_seMainProcess)
    If IsdbNull(rs0121!K0121_cdMainProcess) = False Then D0121.cdMainProcess = Trim$(rs0121!K0121_cdMainProcess)
    If IsdbNull(rs0121!K0121_seSubProcess) = False Then D0121.seSubProcess = Trim$(rs0121!K0121_seSubProcess)
    If IsdbNull(rs0121!K0121_cdSubProcess) = False Then D0121.cdSubProcess = Trim$(rs0121!K0121_cdSubProcess)
    If IsdbNull(rs0121!K0121_Description) = False Then D0121.Description = Trim$(rs0121!K0121_Description)
    If IsdbNull(rs0121!K0121_Cost) = False Then D0121.Cost = Trim$(rs0121!K0121_Cost)
    If IsdbNull(rs0121!K0121_Loss) = False Then D0121.Loss = Trim$(rs0121!K0121_Loss)
    If IsdbNull(rs0121!K0121_ProcessAMT) = False Then D0121.ProcessAMT = Trim$(rs0121!K0121_ProcessAMT)
    If IsdbNull(rs0121!K0121_seShoesStatus) = False Then D0121.seShoesStatus = Trim$(rs0121!K0121_seShoesStatus)
    If IsdbNull(rs0121!K0121_cdShoesStatus) = False Then D0121.cdShoesStatus = Trim$(rs0121!K0121_cdShoesStatus)
    If IsdbNull(rs0121!K0121_SupplierCode) = False Then D0121.SupplierCode = Trim$(rs0121!K0121_SupplierCode)
    If IsdbNull(rs0121!K0121_CheckPresscript) = False Then D0121.CheckPresscript = Trim$(rs0121!K0121_CheckPresscript)
    If IsdbNull(rs0121!K0121_CheckInside) = False Then D0121.CheckInside = Trim$(rs0121!K0121_CheckInside)
    If IsdbNull(rs0121!K0121_CheckOutSide) = False Then D0121.CheckOutSide = Trim$(rs0121!K0121_CheckOutSide)
    If IsdbNull(rs0121!K0121_CheckPurchase) = False Then D0121.CheckPurchase = Trim$(rs0121!K0121_CheckPurchase)
    If IsdbNull(rs0121!K0121_CheckQuatity) = False Then D0121.CheckQuatity = Trim$(rs0121!K0121_CheckQuatity)
    If IsdbNull(rs0121!K0121_CheckPrice) = False Then D0121.CheckPrice = Trim$(rs0121!K0121_CheckPrice)
    If IsdbNull(rs0121!K0121_CheckLoss) = False Then D0121.CheckLoss = Trim$(rs0121!K0121_CheckLoss)
    If IsdbNull(rs0121!K0121_CheckTime) = False Then D0121.CheckTime = Trim$(rs0121!K0121_CheckTime)
    If IsdbNull(rs0121!K0121_CheckJob) = False Then D0121.CheckJob = Trim$(rs0121!K0121_CheckJob)
    If IsdbNull(rs0121!K0121_CheckMachine) = False Then D0121.CheckMachine = Trim$(rs0121!K0121_CheckMachine)
    If IsdbNull(rs0121!K0121_seMachineType) = False Then D0121.seMachineType = Trim$(rs0121!K0121_seMachineType)
    If IsdbNull(rs0121!K0121_cdMachineType) = False Then D0121.cdMachineType = Trim$(rs0121!K0121_cdMachineType)
    If IsdbNull(rs0121!K0121_Remark) = False Then D0121.Remark = Trim$(rs0121!K0121_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K0121_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K0121_MOVE(rs0121 As DataRow)
Try

    call D0121_CLEAR()   

    If IsdbNull(rs0121!K0121_SpecNo) = False Then D0121.SpecNo = Trim$(rs0121!K0121_SpecNo)
    If IsdbNull(rs0121!K0121_SpecNoSeq) = False Then D0121.SpecNoSeq = Trim$(rs0121!K0121_SpecNoSeq)
    If IsdbNull(rs0121!K0121_ProcessSeq) = False Then D0121.ProcessSeq = Trim$(rs0121!K0121_ProcessSeq)
    If IsdbNull(rs0121!K0121_Dseq) = False Then D0121.Dseq = Trim$(rs0121!K0121_Dseq)
    If IsdbNull(rs0121!K0121_seMainProcess) = False Then D0121.seMainProcess = Trim$(rs0121!K0121_seMainProcess)
    If IsdbNull(rs0121!K0121_cdMainProcess) = False Then D0121.cdMainProcess = Trim$(rs0121!K0121_cdMainProcess)
    If IsdbNull(rs0121!K0121_seSubProcess) = False Then D0121.seSubProcess = Trim$(rs0121!K0121_seSubProcess)
    If IsdbNull(rs0121!K0121_cdSubProcess) = False Then D0121.cdSubProcess = Trim$(rs0121!K0121_cdSubProcess)
    If IsdbNull(rs0121!K0121_Description) = False Then D0121.Description = Trim$(rs0121!K0121_Description)
    If IsdbNull(rs0121!K0121_Cost) = False Then D0121.Cost = Trim$(rs0121!K0121_Cost)
    If IsdbNull(rs0121!K0121_Loss) = False Then D0121.Loss = Trim$(rs0121!K0121_Loss)
    If IsdbNull(rs0121!K0121_ProcessAMT) = False Then D0121.ProcessAMT = Trim$(rs0121!K0121_ProcessAMT)
    If IsdbNull(rs0121!K0121_seShoesStatus) = False Then D0121.seShoesStatus = Trim$(rs0121!K0121_seShoesStatus)
    If IsdbNull(rs0121!K0121_cdShoesStatus) = False Then D0121.cdShoesStatus = Trim$(rs0121!K0121_cdShoesStatus)
    If IsdbNull(rs0121!K0121_SupplierCode) = False Then D0121.SupplierCode = Trim$(rs0121!K0121_SupplierCode)
    If IsdbNull(rs0121!K0121_CheckPresscript) = False Then D0121.CheckPresscript = Trim$(rs0121!K0121_CheckPresscript)
    If IsdbNull(rs0121!K0121_CheckInside) = False Then D0121.CheckInside = Trim$(rs0121!K0121_CheckInside)
    If IsdbNull(rs0121!K0121_CheckOutSide) = False Then D0121.CheckOutSide = Trim$(rs0121!K0121_CheckOutSide)
    If IsdbNull(rs0121!K0121_CheckPurchase) = False Then D0121.CheckPurchase = Trim$(rs0121!K0121_CheckPurchase)
    If IsdbNull(rs0121!K0121_CheckQuatity) = False Then D0121.CheckQuatity = Trim$(rs0121!K0121_CheckQuatity)
    If IsdbNull(rs0121!K0121_CheckPrice) = False Then D0121.CheckPrice = Trim$(rs0121!K0121_CheckPrice)
    If IsdbNull(rs0121!K0121_CheckLoss) = False Then D0121.CheckLoss = Trim$(rs0121!K0121_CheckLoss)
    If IsdbNull(rs0121!K0121_CheckTime) = False Then D0121.CheckTime = Trim$(rs0121!K0121_CheckTime)
    If IsdbNull(rs0121!K0121_CheckJob) = False Then D0121.CheckJob = Trim$(rs0121!K0121_CheckJob)
    If IsdbNull(rs0121!K0121_CheckMachine) = False Then D0121.CheckMachine = Trim$(rs0121!K0121_CheckMachine)
    If IsdbNull(rs0121!K0121_seMachineType) = False Then D0121.seMachineType = Trim$(rs0121!K0121_seMachineType)
    If IsdbNull(rs0121!K0121_cdMachineType) = False Then D0121.cdMachineType = Trim$(rs0121!K0121_cdMachineType)
    If IsdbNull(rs0121!K0121_Remark) = False Then D0121.Remark = Trim$(rs0121!K0121_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K0121_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K0121_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z0121 As T0121_AREA, SPECNO AS String, SPECNOSEQ AS String, PROCESSSEQ AS String) as Boolean

K0121_MOVE = False

Try
    If READ_PFK0121(SPECNO, SPECNOSEQ, PROCESSSEQ) = True Then
                z0121 = D0121
		K0121_MOVE = True
		else
	z0121 = nothing
     End If

     If  getColumIndex(spr,"SpecNo") > -1 then z0121.SpecNo = getDataM(spr, getColumIndex(spr,"SpecNo"), xRow)
     If  getColumIndex(spr,"SpecNoSeq") > -1 then z0121.SpecNoSeq = getDataM(spr, getColumIndex(spr,"SpecNoSeq"), xRow)
     If  getColumIndex(spr,"ProcessSeq") > -1 then z0121.ProcessSeq = getDataM(spr, getColumIndex(spr,"ProcessSeq"), xRow)
     If  getColumIndex(spr,"Dseq") > -1 then z0121.Dseq = getDataM(spr, getColumIndex(spr,"Dseq"), xRow)
     If  getColumIndex(spr,"seMainProcess") > -1 then z0121.seMainProcess = getDataM(spr, getColumIndex(spr,"seMainProcess"), xRow)
     If  getColumIndex(spr,"cdMainProcess") > -1 then z0121.cdMainProcess = getDataM(spr, getColumIndex(spr,"cdMainProcess"), xRow)
     If  getColumIndex(spr,"seSubProcess") > -1 then z0121.seSubProcess = getDataM(spr, getColumIndex(spr,"seSubProcess"), xRow)
     If  getColumIndex(spr,"cdSubProcess") > -1 then z0121.cdSubProcess = getDataM(spr, getColumIndex(spr,"cdSubProcess"), xRow)
     If  getColumIndex(spr,"Description") > -1 then z0121.Description = getDataM(spr, getColumIndex(spr,"Description"), xRow)
     If  getColumIndex(spr,"Cost") > -1 then z0121.Cost = getDataM(spr, getColumIndex(spr,"Cost"), xRow)
     If  getColumIndex(spr,"Loss") > -1 then z0121.Loss = getDataM(spr, getColumIndex(spr,"Loss"), xRow)
     If  getColumIndex(spr,"ProcessAMT") > -1 then z0121.ProcessAMT = getDataM(spr, getColumIndex(spr,"ProcessAMT"), xRow)
     If  getColumIndex(spr,"seShoesStatus") > -1 then z0121.seShoesStatus = getDataM(spr, getColumIndex(spr,"seShoesStatus"), xRow)
     If  getColumIndex(spr,"cdShoesStatus") > -1 then z0121.cdShoesStatus = getDataM(spr, getColumIndex(spr,"cdShoesStatus"), xRow)
     If  getColumIndex(spr,"SupplierCode") > -1 then z0121.SupplierCode = getDataM(spr, getColumIndex(spr,"SupplierCode"), xRow)
     If  getColumIndex(spr,"CheckPresscript") > -1 then z0121.CheckPresscript = getDataM(spr, getColumIndex(spr,"CheckPresscript"), xRow)
     If  getColumIndex(spr,"CheckInside") > -1 then z0121.CheckInside = getDataM(spr, getColumIndex(spr,"CheckInside"), xRow)
     If  getColumIndex(spr,"CheckOutSide") > -1 then z0121.CheckOutSide = getDataM(spr, getColumIndex(spr,"CheckOutSide"), xRow)
     If  getColumIndex(spr,"CheckPurchase") > -1 then z0121.CheckPurchase = getDataM(spr, getColumIndex(spr,"CheckPurchase"), xRow)
     If  getColumIndex(spr,"CheckQuatity") > -1 then z0121.CheckQuatity = getDataM(spr, getColumIndex(spr,"CheckQuatity"), xRow)
     If  getColumIndex(spr,"CheckPrice") > -1 then z0121.CheckPrice = getDataM(spr, getColumIndex(spr,"CheckPrice"), xRow)
     If  getColumIndex(spr,"CheckLoss") > -1 then z0121.CheckLoss = getDataM(spr, getColumIndex(spr,"CheckLoss"), xRow)
     If  getColumIndex(spr,"CheckTime") > -1 then z0121.CheckTime = getDataM(spr, getColumIndex(spr,"CheckTime"), xRow)
     If  getColumIndex(spr,"CheckJob") > -1 then z0121.CheckJob = getDataM(spr, getColumIndex(spr,"CheckJob"), xRow)
     If  getColumIndex(spr,"CheckMachine") > -1 then z0121.CheckMachine = getDataM(spr, getColumIndex(spr,"CheckMachine"), xRow)
     If  getColumIndex(spr,"seMachineType") > -1 then z0121.seMachineType = getDataM(spr, getColumIndex(spr,"seMachineType"), xRow)
     If  getColumIndex(spr,"cdMachineType") > -1 then z0121.cdMachineType = getDataM(spr, getColumIndex(spr,"cdMachineType"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z0121.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K0121_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K0121_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z0121 As T0121_AREA,CheckClear as Boolean,SPECNO AS String, SPECNOSEQ AS String, PROCESSSEQ AS String) as Boolean

K0121_MOVE = False

Try
    If READ_PFK0121(SPECNO, SPECNOSEQ, PROCESSSEQ) = True Then
                z0121 = D0121
		K0121_MOVE = True
		else
	If CheckClear  = True then z0121 = nothing
     End If

     If  getColumIndex(spr,"SpecNo") > -1 then z0121.SpecNo = getDataM(spr, getColumIndex(spr,"SpecNo"), xRow)
     If  getColumIndex(spr,"SpecNoSeq") > -1 then z0121.SpecNoSeq = getDataM(spr, getColumIndex(spr,"SpecNoSeq"), xRow)
     If  getColumIndex(spr,"ProcessSeq") > -1 then z0121.ProcessSeq = getDataM(spr, getColumIndex(spr,"ProcessSeq"), xRow)
     If  getColumIndex(spr,"Dseq") > -1 then z0121.Dseq = getDataM(spr, getColumIndex(spr,"Dseq"), xRow)
     If  getColumIndex(spr,"seMainProcess") > -1 then z0121.seMainProcess = getDataM(spr, getColumIndex(spr,"seMainProcess"), xRow)
     If  getColumIndex(spr,"cdMainProcess") > -1 then z0121.cdMainProcess = getDataM(spr, getColumIndex(spr,"cdMainProcess"), xRow)
     If  getColumIndex(spr,"seSubProcess") > -1 then z0121.seSubProcess = getDataM(spr, getColumIndex(spr,"seSubProcess"), xRow)
     If  getColumIndex(spr,"cdSubProcess") > -1 then z0121.cdSubProcess = getDataM(spr, getColumIndex(spr,"cdSubProcess"), xRow)
     If  getColumIndex(spr,"Description") > -1 then z0121.Description = getDataM(spr, getColumIndex(spr,"Description"), xRow)
     If  getColumIndex(spr,"Cost") > -1 then z0121.Cost = getDataM(spr, getColumIndex(spr,"Cost"), xRow)
     If  getColumIndex(spr,"Loss") > -1 then z0121.Loss = getDataM(spr, getColumIndex(spr,"Loss"), xRow)
     If  getColumIndex(spr,"ProcessAMT") > -1 then z0121.ProcessAMT = getDataM(spr, getColumIndex(spr,"ProcessAMT"), xRow)
     If  getColumIndex(spr,"seShoesStatus") > -1 then z0121.seShoesStatus = getDataM(spr, getColumIndex(spr,"seShoesStatus"), xRow)
     If  getColumIndex(spr,"cdShoesStatus") > -1 then z0121.cdShoesStatus = getDataM(spr, getColumIndex(spr,"cdShoesStatus"), xRow)
     If  getColumIndex(spr,"SupplierCode") > -1 then z0121.SupplierCode = getDataM(spr, getColumIndex(spr,"SupplierCode"), xRow)
     If  getColumIndex(spr,"CheckPresscript") > -1 then z0121.CheckPresscript = getDataM(spr, getColumIndex(spr,"CheckPresscript"), xRow)
     If  getColumIndex(spr,"CheckInside") > -1 then z0121.CheckInside = getDataM(spr, getColumIndex(spr,"CheckInside"), xRow)
     If  getColumIndex(spr,"CheckOutSide") > -1 then z0121.CheckOutSide = getDataM(spr, getColumIndex(spr,"CheckOutSide"), xRow)
     If  getColumIndex(spr,"CheckPurchase") > -1 then z0121.CheckPurchase = getDataM(spr, getColumIndex(spr,"CheckPurchase"), xRow)
     If  getColumIndex(spr,"CheckQuatity") > -1 then z0121.CheckQuatity = getDataM(spr, getColumIndex(spr,"CheckQuatity"), xRow)
     If  getColumIndex(spr,"CheckPrice") > -1 then z0121.CheckPrice = getDataM(spr, getColumIndex(spr,"CheckPrice"), xRow)
     If  getColumIndex(spr,"CheckLoss") > -1 then z0121.CheckLoss = getDataM(spr, getColumIndex(spr,"CheckLoss"), xRow)
     If  getColumIndex(spr,"CheckTime") > -1 then z0121.CheckTime = getDataM(spr, getColumIndex(spr,"CheckTime"), xRow)
     If  getColumIndex(spr,"CheckJob") > -1 then z0121.CheckJob = getDataM(spr, getColumIndex(spr,"CheckJob"), xRow)
     If  getColumIndex(spr,"CheckMachine") > -1 then z0121.CheckMachine = getDataM(spr, getColumIndex(spr,"CheckMachine"), xRow)
     If  getColumIndex(spr,"seMachineType") > -1 then z0121.seMachineType = getDataM(spr, getColumIndex(spr,"seMachineType"), xRow)
     If  getColumIndex(spr,"cdMachineType") > -1 then z0121.cdMachineType = getDataM(spr, getColumIndex(spr,"cdMachineType"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z0121.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K0121_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K0121_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z0121 As T0121_AREA, Job as String, SPECNO AS String, SPECNOSEQ AS String, PROCESSSEQ AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K0121_MOVE = False

Try
    If READ_PFK0121(SPECNO, SPECNOSEQ, PROCESSSEQ) = True Then
                z0121 = D0121
		K0121_MOVE = True
		else
	z0121 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK0121")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "SPECNO":z0121.SpecNo = Children(i).Code
   Case "SPECNOSEQ":z0121.SpecNoSeq = Children(i).Code
   Case "PROCESSSEQ":z0121.ProcessSeq = Children(i).Code
   Case "DSEQ":z0121.Dseq = Children(i).Code
   Case "SEMAINPROCESS":z0121.seMainProcess = Children(i).Code
   Case "CDMAINPROCESS":z0121.cdMainProcess = Children(i).Code
   Case "SESUBPROCESS":z0121.seSubProcess = Children(i).Code
   Case "CDSUBPROCESS":z0121.cdSubProcess = Children(i).Code
   Case "DESCRIPTION":z0121.Description = Children(i).Code
   Case "COST":z0121.Cost = Children(i).Code
   Case "LOSS":z0121.Loss = Children(i).Code
   Case "PROCESSAMT":z0121.ProcessAMT = Children(i).Code
   Case "SESHOESSTATUS":z0121.seShoesStatus = Children(i).Code
   Case "CDSHOESSTATUS":z0121.cdShoesStatus = Children(i).Code
   Case "SUPPLIERCODE":z0121.SupplierCode = Children(i).Code
   Case "CHECKPRESSCRIPT":z0121.CheckPresscript = Children(i).Code
   Case "CHECKINSIDE":z0121.CheckInside = Children(i).Code
   Case "CHECKOUTSIDE":z0121.CheckOutSide = Children(i).Code
   Case "CHECKPURCHASE":z0121.CheckPurchase = Children(i).Code
   Case "CHECKQUATITY":z0121.CheckQuatity = Children(i).Code
   Case "CHECKPRICE":z0121.CheckPrice = Children(i).Code
   Case "CHECKLOSS":z0121.CheckLoss = Children(i).Code
   Case "CHECKTIME":z0121.CheckTime = Children(i).Code
   Case "CHECKJOB":z0121.CheckJob = Children(i).Code
   Case "CHECKMACHINE":z0121.CheckMachine = Children(i).Code
   Case "SEMACHINETYPE":z0121.seMachineType = Children(i).Code
   Case "CDMACHINETYPE":z0121.cdMachineType = Children(i).Code
   Case "REMARK":z0121.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "SPECNO":z0121.SpecNo = Children(i).Data
   Case "SPECNOSEQ":z0121.SpecNoSeq = Children(i).Data
   Case "PROCESSSEQ":z0121.ProcessSeq = Children(i).Data
   Case "DSEQ":z0121.Dseq = Children(i).Data
   Case "SEMAINPROCESS":z0121.seMainProcess = Children(i).Data
   Case "CDMAINPROCESS":z0121.cdMainProcess = Children(i).Data
   Case "SESUBPROCESS":z0121.seSubProcess = Children(i).Data
   Case "CDSUBPROCESS":z0121.cdSubProcess = Children(i).Data
   Case "DESCRIPTION":z0121.Description = Children(i).Data
   Case "COST":z0121.Cost = Children(i).Data
   Case "LOSS":z0121.Loss = Children(i).Data
   Case "PROCESSAMT":z0121.ProcessAMT = Children(i).Data
   Case "SESHOESSTATUS":z0121.seShoesStatus = Children(i).Data
   Case "CDSHOESSTATUS":z0121.cdShoesStatus = Children(i).Data
   Case "SUPPLIERCODE":z0121.SupplierCode = Children(i).Data
   Case "CHECKPRESSCRIPT":z0121.CheckPresscript = Children(i).Data
   Case "CHECKINSIDE":z0121.CheckInside = Children(i).Data
   Case "CHECKOUTSIDE":z0121.CheckOutSide = Children(i).Data
   Case "CHECKPURCHASE":z0121.CheckPurchase = Children(i).Data
   Case "CHECKQUATITY":z0121.CheckQuatity = Children(i).Data
   Case "CHECKPRICE":z0121.CheckPrice = Children(i).Data
   Case "CHECKLOSS":z0121.CheckLoss = Children(i).Data
   Case "CHECKTIME":z0121.CheckTime = Children(i).Data
   Case "CHECKJOB":z0121.CheckJob = Children(i).Data
   Case "CHECKMACHINE":z0121.CheckMachine = Children(i).Data
   Case "SEMACHINETYPE":z0121.seMachineType = Children(i).Data
   Case "CDMACHINETYPE":z0121.cdMachineType = Children(i).Data
   Case "REMARK":z0121.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K0121_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K0121_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z0121 As T0121_AREA, Job as String, CheckClear as Boolean, SPECNO AS String, SPECNOSEQ AS String, PROCESSSEQ AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K0121_MOVE = False

Try
    If READ_PFK0121(SPECNO, SPECNOSEQ, PROCESSSEQ) = True Then
                z0121 = D0121
		K0121_MOVE = True
		else
	If CheckClear  = True then z0121 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK0121")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "SPECNO":z0121.SpecNo = Children(i).Code
   Case "SPECNOSEQ":z0121.SpecNoSeq = Children(i).Code
   Case "PROCESSSEQ":z0121.ProcessSeq = Children(i).Code
   Case "DSEQ":z0121.Dseq = Children(i).Code
   Case "SEMAINPROCESS":z0121.seMainProcess = Children(i).Code
   Case "CDMAINPROCESS":z0121.cdMainProcess = Children(i).Code
   Case "SESUBPROCESS":z0121.seSubProcess = Children(i).Code
   Case "CDSUBPROCESS":z0121.cdSubProcess = Children(i).Code
   Case "DESCRIPTION":z0121.Description = Children(i).Code
   Case "COST":z0121.Cost = Children(i).Code
   Case "LOSS":z0121.Loss = Children(i).Code
   Case "PROCESSAMT":z0121.ProcessAMT = Children(i).Code
   Case "SESHOESSTATUS":z0121.seShoesStatus = Children(i).Code
   Case "CDSHOESSTATUS":z0121.cdShoesStatus = Children(i).Code
   Case "SUPPLIERCODE":z0121.SupplierCode = Children(i).Code
   Case "CHECKPRESSCRIPT":z0121.CheckPresscript = Children(i).Code
   Case "CHECKINSIDE":z0121.CheckInside = Children(i).Code
   Case "CHECKOUTSIDE":z0121.CheckOutSide = Children(i).Code
   Case "CHECKPURCHASE":z0121.CheckPurchase = Children(i).Code
   Case "CHECKQUATITY":z0121.CheckQuatity = Children(i).Code
   Case "CHECKPRICE":z0121.CheckPrice = Children(i).Code
   Case "CHECKLOSS":z0121.CheckLoss = Children(i).Code
   Case "CHECKTIME":z0121.CheckTime = Children(i).Code
   Case "CHECKJOB":z0121.CheckJob = Children(i).Code
   Case "CHECKMACHINE":z0121.CheckMachine = Children(i).Code
   Case "SEMACHINETYPE":z0121.seMachineType = Children(i).Code
   Case "CDMACHINETYPE":z0121.cdMachineType = Children(i).Code
   Case "REMARK":z0121.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "SPECNO":z0121.SpecNo = Children(i).Data
   Case "SPECNOSEQ":z0121.SpecNoSeq = Children(i).Data
   Case "PROCESSSEQ":z0121.ProcessSeq = Children(i).Data
   Case "DSEQ":z0121.Dseq = Children(i).Data
   Case "SEMAINPROCESS":z0121.seMainProcess = Children(i).Data
   Case "CDMAINPROCESS":z0121.cdMainProcess = Children(i).Data
   Case "SESUBPROCESS":z0121.seSubProcess = Children(i).Data
   Case "CDSUBPROCESS":z0121.cdSubProcess = Children(i).Data
   Case "DESCRIPTION":z0121.Description = Children(i).Data
   Case "COST":z0121.Cost = Children(i).Data
   Case "LOSS":z0121.Loss = Children(i).Data
   Case "PROCESSAMT":z0121.ProcessAMT = Children(i).Data
   Case "SESHOESSTATUS":z0121.seShoesStatus = Children(i).Data
   Case "CDSHOESSTATUS":z0121.cdShoesStatus = Children(i).Data
   Case "SUPPLIERCODE":z0121.SupplierCode = Children(i).Data
   Case "CHECKPRESSCRIPT":z0121.CheckPresscript = Children(i).Data
   Case "CHECKINSIDE":z0121.CheckInside = Children(i).Data
   Case "CHECKOUTSIDE":z0121.CheckOutSide = Children(i).Data
   Case "CHECKPURCHASE":z0121.CheckPurchase = Children(i).Data
   Case "CHECKQUATITY":z0121.CheckQuatity = Children(i).Data
   Case "CHECKPRICE":z0121.CheckPrice = Children(i).Data
   Case "CHECKLOSS":z0121.CheckLoss = Children(i).Data
   Case "CHECKTIME":z0121.CheckTime = Children(i).Data
   Case "CHECKJOB":z0121.CheckJob = Children(i).Data
   Case "CHECKMACHINE":z0121.CheckMachine = Children(i).Data
   Case "SEMACHINETYPE":z0121.seMachineType = Children(i).Data
   Case "CDMACHINETYPE":z0121.cdMachineType = Children(i).Data
   Case "REMARK":z0121.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K0121_MOVE",vbCritical)
End Try
End Function 
    
End Module 
