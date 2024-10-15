'=========================================================================================================================================================
'   TABLE : (PFK1336)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K1336

Structure T1336_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	OrderNo	 AS String	'			char(9)		*
Public 	OrderNoSeq	 AS String	'			char(3)		*
Public 	ProcessSeq	 AS String	'			char(3)		*
Public 	Status	 AS String	'			char(1)
Public 	seMainProcess	 AS String	'			char(3)
Public 	cdMainProcess	 AS String	'			char(3)
Public 	seSubProcess	 AS String	'			char(3)
Public 	cdSubProcess	 AS String	'			char(3)
Public 	Description	 AS String	'			nvarchar(500)
Public 	seGroupComponent	 AS String	'			char(3)
Public 	cdGroupComponent	 AS String	'			char(3)
Public 	seComponent	 AS String	'			char(3)
Public 	cdComponent	 AS String	'			char(3)
Public 	MaterialCode	 AS String	'			char(6)
Public 	MaterialDescription	 AS String	'			nvarchar(500)
Public 	ColorCode	 AS String	'			nvarchar(50)
Public 	SpecMaterial	 AS String	'			char(9)
Public 	seUnitMaterial	 AS String	'			char(3)
Public 	cdUnitMaterial	 AS String	'			char(3)
Public 	seMaterialStatus	 AS String	'			char(3)
Public 	cdMaterialStatus	 AS String	'			char(3)
Public 	sePurchaseDept	 AS String	'			char(3)
Public 	cdPutchaseDept	 AS String	'			char(3)
Public 	SupplierCode	 AS String	'			char(6)
Public 	MaterialPrice	 AS Double	'			decimal
Public 	Qty	 AS Double	'			decimal
Public 	Consumption	 AS Double	'			decimal
Public 	Loss	 AS Double	'			decimal
Public 	GrossUsage	 AS Double	'			decimal
Public 	InsertDate	 AS String	'			char(8)
Public 	InchargeInsert	 AS String	'			char(8)
Public 	UpdateDate	 AS String	'			char(8)
Public 	InchargeUpdate	 AS String	'			char(8)
Public 	AttachID	 AS String	'			char(6)
Public 	RemarkOrder	 AS String	'			nvarchar(500)
Public 	RemarkCustomer	 AS String	'			nvarchar(500)
Public 	Remark	 AS String	'			nvarchar(500)
'=========================================================================================================================================================
End structure

Public D1336 As T1336_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK1336(ORDERNO AS String, ORDERNOSEQ AS String, PROCESSSEQ AS String) As Boolean
    READ_PFK1336 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK1336 "
    SQL = SQL & " WHERE K1336_OrderNo		 = '" & OrderNo & "' " 
    SQL = SQL & "   AND K1336_OrderNoSeq		 = '" & OrderNoSeq & "' " 
    SQL = SQL & "   AND K1336_ProcessSeq		 = '" & ProcessSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D1336_CLEAR: GoTo SKIP_READ_PFK1336
                
    Call K1336_MOVE(rd)
    READ_PFK1336 = True

SKIP_READ_PFK1336:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK1336",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK1336(ORDERNO AS String, ORDERNOSEQ AS String, PROCESSSEQ AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK1336 "
    SQL = SQL & " WHERE K1336_OrderNo		 = '" & OrderNo & "' " 
    SQL = SQL & "   AND K1336_OrderNoSeq		 = '" & OrderNoSeq & "' " 
    SQL = SQL & "   AND K1336_ProcessSeq		 = '" & ProcessSeq & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK1336",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK1336(z1336 As T1336_AREA) As Boolean
    WRITE_PFK1336 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z1336)
 
    SQL = " INSERT INTO PFK1336 "
    SQL = SQL & " ( "
    SQL = SQL & " K1336_OrderNo," 
    SQL = SQL & " K1336_OrderNoSeq," 
    SQL = SQL & " K1336_ProcessSeq," 
    SQL = SQL & " K1336_Status," 
    SQL = SQL & " K1336_seMainProcess," 
    SQL = SQL & " K1336_cdMainProcess," 
    SQL = SQL & " K1336_seSubProcess," 
    SQL = SQL & " K1336_cdSubProcess," 
    SQL = SQL & " K1336_Description," 
    SQL = SQL & " K1336_seGroupComponent," 
    SQL = SQL & " K1336_cdGroupComponent," 
    SQL = SQL & " K1336_seComponent," 
    SQL = SQL & " K1336_cdComponent," 
    SQL = SQL & " K1336_MaterialCode," 
    SQL = SQL & " K1336_MaterialDescription," 
    SQL = SQL & " K1336_ColorCode," 
    SQL = SQL & " K1336_SpecMaterial," 
    SQL = SQL & " K1336_seUnitMaterial," 
    SQL = SQL & " K1336_cdUnitMaterial," 
    SQL = SQL & " K1336_seMaterialStatus," 
    SQL = SQL & " K1336_cdMaterialStatus," 
    SQL = SQL & " K1336_sePurchaseDept," 
    SQL = SQL & " K1336_cdPutchaseDept," 
    SQL = SQL & " K1336_SupplierCode," 
    SQL = SQL & " K1336_MaterialPrice," 
    SQL = SQL & " K1336_Qty," 
    SQL = SQL & " K1336_Consumption," 
    SQL = SQL & " K1336_Loss," 
    SQL = SQL & " K1336_GrossUsage," 
    SQL = SQL & " K1336_InsertDate," 
    SQL = SQL & " K1336_InchargeInsert," 
    SQL = SQL & " K1336_UpdateDate," 
    SQL = SQL & " K1336_InchargeUpdate," 
    SQL = SQL & " K1336_AttachID," 
    SQL = SQL & " K1336_RemarkOrder," 
    SQL = SQL & " K1336_RemarkCustomer," 
    SQL = SQL & " K1336_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z1336.OrderNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1336.OrderNoSeq) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1336.ProcessSeq) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1336.Status) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1336.seMainProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1336.cdMainProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1336.seSubProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1336.cdSubProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1336.Description) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1336.seGroupComponent) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1336.cdGroupComponent) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1336.seComponent) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1336.cdComponent) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1336.MaterialCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1336.MaterialDescription) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1336.ColorCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1336.SpecMaterial) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1336.seUnitMaterial) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1336.cdUnitMaterial) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1336.seMaterialStatus) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1336.cdMaterialStatus) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1336.sePurchaseDept) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1336.cdPutchaseDept) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1336.SupplierCode) & "', "  
    SQL = SQL & "   " & FormatSQL(z1336.MaterialPrice) & ", "  
    SQL = SQL & "   " & FormatSQL(z1336.Qty) & ", "  
    SQL = SQL & "   " & FormatSQL(z1336.Consumption) & ", "  
    SQL = SQL & "   " & FormatSQL(z1336.Loss) & ", "  
    SQL = SQL & "   " & FormatSQL(z1336.GrossUsage) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z1336.InsertDate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1336.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1336.UpdateDate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1336.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1336.AttachID) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1336.RemarkOrder) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1336.RemarkCustomer) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1336.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK1336 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK1336",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK1336(z1336 As T1336_AREA) As Boolean
    REWRITE_PFK1336 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z1336)
   
    SQL = " UPDATE PFK1336 SET "
    SQL = SQL & "    K1336_Status      = N'" & FormatSQL(z1336.Status) & "', " 
    SQL = SQL & "    K1336_seMainProcess      = N'" & FormatSQL(z1336.seMainProcess) & "', " 
    SQL = SQL & "    K1336_cdMainProcess      = N'" & FormatSQL(z1336.cdMainProcess) & "', " 
    SQL = SQL & "    K1336_seSubProcess      = N'" & FormatSQL(z1336.seSubProcess) & "', " 
    SQL = SQL & "    K1336_cdSubProcess      = N'" & FormatSQL(z1336.cdSubProcess) & "', " 
    SQL = SQL & "    K1336_Description      = N'" & FormatSQL(z1336.Description) & "', " 
    SQL = SQL & "    K1336_seGroupComponent      = N'" & FormatSQL(z1336.seGroupComponent) & "', " 
    SQL = SQL & "    K1336_cdGroupComponent      = N'" & FormatSQL(z1336.cdGroupComponent) & "', " 
    SQL = SQL & "    K1336_seComponent      = N'" & FormatSQL(z1336.seComponent) & "', " 
    SQL = SQL & "    K1336_cdComponent      = N'" & FormatSQL(z1336.cdComponent) & "', " 
    SQL = SQL & "    K1336_MaterialCode      = N'" & FormatSQL(z1336.MaterialCode) & "', " 
    SQL = SQL & "    K1336_MaterialDescription      = N'" & FormatSQL(z1336.MaterialDescription) & "', " 
    SQL = SQL & "    K1336_ColorCode      = N'" & FormatSQL(z1336.ColorCode) & "', " 
    SQL = SQL & "    K1336_SpecMaterial      = N'" & FormatSQL(z1336.SpecMaterial) & "', " 
    SQL = SQL & "    K1336_seUnitMaterial      = N'" & FormatSQL(z1336.seUnitMaterial) & "', " 
    SQL = SQL & "    K1336_cdUnitMaterial      = N'" & FormatSQL(z1336.cdUnitMaterial) & "', " 
    SQL = SQL & "    K1336_seMaterialStatus      = N'" & FormatSQL(z1336.seMaterialStatus) & "', " 
    SQL = SQL & "    K1336_cdMaterialStatus      = N'" & FormatSQL(z1336.cdMaterialStatus) & "', " 
    SQL = SQL & "    K1336_sePurchaseDept      = N'" & FormatSQL(z1336.sePurchaseDept) & "', " 
    SQL = SQL & "    K1336_cdPutchaseDept      = N'" & FormatSQL(z1336.cdPutchaseDept) & "', " 
    SQL = SQL & "    K1336_SupplierCode      = N'" & FormatSQL(z1336.SupplierCode) & "', " 
    SQL = SQL & "    K1336_MaterialPrice      =  " & FormatSQL(z1336.MaterialPrice) & ", " 
    SQL = SQL & "    K1336_Qty      =  " & FormatSQL(z1336.Qty) & ", " 
    SQL = SQL & "    K1336_Consumption      =  " & FormatSQL(z1336.Consumption) & ", " 
    SQL = SQL & "    K1336_Loss      =  " & FormatSQL(z1336.Loss) & ", " 
    SQL = SQL & "    K1336_GrossUsage      =  " & FormatSQL(z1336.GrossUsage) & ", " 
    SQL = SQL & "    K1336_InsertDate      = N'" & FormatSQL(z1336.InsertDate) & "', " 
    SQL = SQL & "    K1336_InchargeInsert      = N'" & FormatSQL(z1336.InchargeInsert) & "', " 
    SQL = SQL & "    K1336_UpdateDate      = N'" & FormatSQL(z1336.UpdateDate) & "', " 
    SQL = SQL & "    K1336_InchargeUpdate      = N'" & FormatSQL(z1336.InchargeUpdate) & "', " 
    SQL = SQL & "    K1336_AttachID      = N'" & FormatSQL(z1336.AttachID) & "', " 
    SQL = SQL & "    K1336_RemarkOrder      = N'" & FormatSQL(z1336.RemarkOrder) & "', " 
    SQL = SQL & "    K1336_RemarkCustomer      = N'" & FormatSQL(z1336.RemarkCustomer) & "', " 
    SQL = SQL & "    K1336_Remark      = N'" & FormatSQL(z1336.Remark) & "'  " 
    SQL = SQL & " WHERE K1336_OrderNo		 = '" & z1336.OrderNo & "' " 
    SQL = SQL & "   AND K1336_OrderNoSeq		 = '" & z1336.OrderNoSeq & "' " 
    SQL = SQL & "   AND K1336_ProcessSeq		 = '" & z1336.ProcessSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK1336 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK1336",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK1336(z1336 As T1336_AREA) As Boolean
    DELETE_PFK1336 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK1336 "
    SQL = SQL & " WHERE K1336_OrderNo		 = '" & z1336.OrderNo & "' " 
    SQL = SQL & "   AND K1336_OrderNoSeq		 = '" & z1336.OrderNoSeq & "' " 
    SQL = SQL & "   AND K1336_ProcessSeq		 = '" & z1336.ProcessSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK1336 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK1336",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D1336_CLEAR()
Try
    
   D1336.OrderNo = ""
   D1336.OrderNoSeq = ""
   D1336.ProcessSeq = ""
   D1336.Status = ""
   D1336.seMainProcess = ""
   D1336.cdMainProcess = ""
   D1336.seSubProcess = ""
   D1336.cdSubProcess = ""
   D1336.Description = ""
   D1336.seGroupComponent = ""
   D1336.cdGroupComponent = ""
   D1336.seComponent = ""
   D1336.cdComponent = ""
   D1336.MaterialCode = ""
   D1336.MaterialDescription = ""
   D1336.ColorCode = ""
   D1336.SpecMaterial = ""
   D1336.seUnitMaterial = ""
   D1336.cdUnitMaterial = ""
   D1336.seMaterialStatus = ""
   D1336.cdMaterialStatus = ""
   D1336.sePurchaseDept = ""
   D1336.cdPutchaseDept = ""
   D1336.SupplierCode = ""
    D1336.MaterialPrice = 0 
    D1336.Qty = 0 
    D1336.Consumption = 0 
    D1336.Loss = 0 
    D1336.GrossUsage = 0 
   D1336.InsertDate = ""
   D1336.InchargeInsert = ""
   D1336.UpdateDate = ""
   D1336.InchargeUpdate = ""
   D1336.AttachID = ""
   D1336.RemarkOrder = ""
   D1336.RemarkCustomer = ""
   D1336.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D1336_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x1336 As T1336_AREA)
Try
    
    x1336.OrderNo = trim$(  x1336.OrderNo)
    x1336.OrderNoSeq = trim$(  x1336.OrderNoSeq)
    x1336.ProcessSeq = trim$(  x1336.ProcessSeq)
    x1336.Status = trim$(  x1336.Status)
    x1336.seMainProcess = trim$(  x1336.seMainProcess)
    x1336.cdMainProcess = trim$(  x1336.cdMainProcess)
    x1336.seSubProcess = trim$(  x1336.seSubProcess)
    x1336.cdSubProcess = trim$(  x1336.cdSubProcess)
    x1336.Description = trim$(  x1336.Description)
    x1336.seGroupComponent = trim$(  x1336.seGroupComponent)
    x1336.cdGroupComponent = trim$(  x1336.cdGroupComponent)
    x1336.seComponent = trim$(  x1336.seComponent)
    x1336.cdComponent = trim$(  x1336.cdComponent)
    x1336.MaterialCode = trim$(  x1336.MaterialCode)
    x1336.MaterialDescription = trim$(  x1336.MaterialDescription)
    x1336.ColorCode = trim$(  x1336.ColorCode)
    x1336.SpecMaterial = trim$(  x1336.SpecMaterial)
    x1336.seUnitMaterial = trim$(  x1336.seUnitMaterial)
    x1336.cdUnitMaterial = trim$(  x1336.cdUnitMaterial)
    x1336.seMaterialStatus = trim$(  x1336.seMaterialStatus)
    x1336.cdMaterialStatus = trim$(  x1336.cdMaterialStatus)
    x1336.sePurchaseDept = trim$(  x1336.sePurchaseDept)
    x1336.cdPutchaseDept = trim$(  x1336.cdPutchaseDept)
    x1336.SupplierCode = trim$(  x1336.SupplierCode)
    x1336.MaterialPrice = trim$(  x1336.MaterialPrice)
    x1336.Qty = trim$(  x1336.Qty)
    x1336.Consumption = trim$(  x1336.Consumption)
    x1336.Loss = trim$(  x1336.Loss)
    x1336.GrossUsage = trim$(  x1336.GrossUsage)
    x1336.InsertDate = trim$(  x1336.InsertDate)
    x1336.InchargeInsert = trim$(  x1336.InchargeInsert)
    x1336.UpdateDate = trim$(  x1336.UpdateDate)
    x1336.InchargeUpdate = trim$(  x1336.InchargeUpdate)
    x1336.AttachID = trim$(  x1336.AttachID)
    x1336.RemarkOrder = trim$(  x1336.RemarkOrder)
    x1336.RemarkCustomer = trim$(  x1336.RemarkCustomer)
    x1336.Remark = trim$(  x1336.Remark)
     
    If trim$( x1336.OrderNo ) = "" Then x1336.OrderNo = Space(1) 
    If trim$( x1336.OrderNoSeq ) = "" Then x1336.OrderNoSeq = Space(1) 
    If trim$( x1336.ProcessSeq ) = "" Then x1336.ProcessSeq = Space(1) 
    If trim$( x1336.Status ) = "" Then x1336.Status = Space(1) 
    If trim$( x1336.seMainProcess ) = "" Then x1336.seMainProcess = Space(1) 
    If trim$( x1336.cdMainProcess ) = "" Then x1336.cdMainProcess = Space(1) 
    If trim$( x1336.seSubProcess ) = "" Then x1336.seSubProcess = Space(1) 
    If trim$( x1336.cdSubProcess ) = "" Then x1336.cdSubProcess = Space(1) 
    If trim$( x1336.Description ) = "" Then x1336.Description = Space(1) 
    If trim$( x1336.seGroupComponent ) = "" Then x1336.seGroupComponent = Space(1) 
    If trim$( x1336.cdGroupComponent ) = "" Then x1336.cdGroupComponent = Space(1) 
    If trim$( x1336.seComponent ) = "" Then x1336.seComponent = Space(1) 
    If trim$( x1336.cdComponent ) = "" Then x1336.cdComponent = Space(1) 
    If trim$( x1336.MaterialCode ) = "" Then x1336.MaterialCode = Space(1) 
    If trim$( x1336.MaterialDescription ) = "" Then x1336.MaterialDescription = Space(1) 
    If trim$( x1336.ColorCode ) = "" Then x1336.ColorCode = Space(1) 
    If trim$( x1336.SpecMaterial ) = "" Then x1336.SpecMaterial = Space(1) 
    If trim$( x1336.seUnitMaterial ) = "" Then x1336.seUnitMaterial = Space(1) 
    If trim$( x1336.cdUnitMaterial ) = "" Then x1336.cdUnitMaterial = Space(1) 
    If trim$( x1336.seMaterialStatus ) = "" Then x1336.seMaterialStatus = Space(1) 
    If trim$( x1336.cdMaterialStatus ) = "" Then x1336.cdMaterialStatus = Space(1) 
    If trim$( x1336.sePurchaseDept ) = "" Then x1336.sePurchaseDept = Space(1) 
    If trim$( x1336.cdPutchaseDept ) = "" Then x1336.cdPutchaseDept = Space(1) 
    If trim$( x1336.SupplierCode ) = "" Then x1336.SupplierCode = Space(1) 
    If trim$( x1336.MaterialPrice ) = "" Then x1336.MaterialPrice = 0 
    If trim$( x1336.Qty ) = "" Then x1336.Qty = 0 
    If trim$( x1336.Consumption ) = "" Then x1336.Consumption = 0 
    If trim$( x1336.Loss ) = "" Then x1336.Loss = 0 
    If trim$( x1336.GrossUsage ) = "" Then x1336.GrossUsage = 0 
    If trim$( x1336.InsertDate ) = "" Then x1336.InsertDate = Space(1) 
    If trim$( x1336.InchargeInsert ) = "" Then x1336.InchargeInsert = Space(1) 
    If trim$( x1336.UpdateDate ) = "" Then x1336.UpdateDate = Space(1) 
    If trim$( x1336.InchargeUpdate ) = "" Then x1336.InchargeUpdate = Space(1) 
    If trim$( x1336.AttachID ) = "" Then x1336.AttachID = Space(1) 
    If trim$( x1336.RemarkOrder ) = "" Then x1336.RemarkOrder = Space(1) 
    If trim$( x1336.RemarkCustomer ) = "" Then x1336.RemarkCustomer = Space(1) 
    If trim$( x1336.Remark ) = "" Then x1336.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K1336_MOVE(rs1336 As SqlClient.SqlDataReader)
Try

    call D1336_CLEAR()   

    If IsdbNull(rs1336!K1336_OrderNo) = False Then D1336.OrderNo = Trim$(rs1336!K1336_OrderNo)
    If IsdbNull(rs1336!K1336_OrderNoSeq) = False Then D1336.OrderNoSeq = Trim$(rs1336!K1336_OrderNoSeq)
    If IsdbNull(rs1336!K1336_ProcessSeq) = False Then D1336.ProcessSeq = Trim$(rs1336!K1336_ProcessSeq)
    If IsdbNull(rs1336!K1336_Status) = False Then D1336.Status = Trim$(rs1336!K1336_Status)
    If IsdbNull(rs1336!K1336_seMainProcess) = False Then D1336.seMainProcess = Trim$(rs1336!K1336_seMainProcess)
    If IsdbNull(rs1336!K1336_cdMainProcess) = False Then D1336.cdMainProcess = Trim$(rs1336!K1336_cdMainProcess)
    If IsdbNull(rs1336!K1336_seSubProcess) = False Then D1336.seSubProcess = Trim$(rs1336!K1336_seSubProcess)
    If IsdbNull(rs1336!K1336_cdSubProcess) = False Then D1336.cdSubProcess = Trim$(rs1336!K1336_cdSubProcess)
    If IsdbNull(rs1336!K1336_Description) = False Then D1336.Description = Trim$(rs1336!K1336_Description)
    If IsdbNull(rs1336!K1336_seGroupComponent) = False Then D1336.seGroupComponent = Trim$(rs1336!K1336_seGroupComponent)
    If IsdbNull(rs1336!K1336_cdGroupComponent) = False Then D1336.cdGroupComponent = Trim$(rs1336!K1336_cdGroupComponent)
    If IsdbNull(rs1336!K1336_seComponent) = False Then D1336.seComponent = Trim$(rs1336!K1336_seComponent)
    If IsdbNull(rs1336!K1336_cdComponent) = False Then D1336.cdComponent = Trim$(rs1336!K1336_cdComponent)
    If IsdbNull(rs1336!K1336_MaterialCode) = False Then D1336.MaterialCode = Trim$(rs1336!K1336_MaterialCode)
    If IsdbNull(rs1336!K1336_MaterialDescription) = False Then D1336.MaterialDescription = Trim$(rs1336!K1336_MaterialDescription)
    If IsdbNull(rs1336!K1336_ColorCode) = False Then D1336.ColorCode = Trim$(rs1336!K1336_ColorCode)
    If IsdbNull(rs1336!K1336_SpecMaterial) = False Then D1336.SpecMaterial = Trim$(rs1336!K1336_SpecMaterial)
    If IsdbNull(rs1336!K1336_seUnitMaterial) = False Then D1336.seUnitMaterial = Trim$(rs1336!K1336_seUnitMaterial)
    If IsdbNull(rs1336!K1336_cdUnitMaterial) = False Then D1336.cdUnitMaterial = Trim$(rs1336!K1336_cdUnitMaterial)
    If IsdbNull(rs1336!K1336_seMaterialStatus) = False Then D1336.seMaterialStatus = Trim$(rs1336!K1336_seMaterialStatus)
    If IsdbNull(rs1336!K1336_cdMaterialStatus) = False Then D1336.cdMaterialStatus = Trim$(rs1336!K1336_cdMaterialStatus)
    If IsdbNull(rs1336!K1336_sePurchaseDept) = False Then D1336.sePurchaseDept = Trim$(rs1336!K1336_sePurchaseDept)
    If IsdbNull(rs1336!K1336_cdPutchaseDept) = False Then D1336.cdPutchaseDept = Trim$(rs1336!K1336_cdPutchaseDept)
    If IsdbNull(rs1336!K1336_SupplierCode) = False Then D1336.SupplierCode = Trim$(rs1336!K1336_SupplierCode)
    If IsdbNull(rs1336!K1336_MaterialPrice) = False Then D1336.MaterialPrice = Trim$(rs1336!K1336_MaterialPrice)
    If IsdbNull(rs1336!K1336_Qty) = False Then D1336.Qty = Trim$(rs1336!K1336_Qty)
    If IsdbNull(rs1336!K1336_Consumption) = False Then D1336.Consumption = Trim$(rs1336!K1336_Consumption)
    If IsdbNull(rs1336!K1336_Loss) = False Then D1336.Loss = Trim$(rs1336!K1336_Loss)
    If IsdbNull(rs1336!K1336_GrossUsage) = False Then D1336.GrossUsage = Trim$(rs1336!K1336_GrossUsage)
    If IsdbNull(rs1336!K1336_InsertDate) = False Then D1336.InsertDate = Trim$(rs1336!K1336_InsertDate)
    If IsdbNull(rs1336!K1336_InchargeInsert) = False Then D1336.InchargeInsert = Trim$(rs1336!K1336_InchargeInsert)
    If IsdbNull(rs1336!K1336_UpdateDate) = False Then D1336.UpdateDate = Trim$(rs1336!K1336_UpdateDate)
    If IsdbNull(rs1336!K1336_InchargeUpdate) = False Then D1336.InchargeUpdate = Trim$(rs1336!K1336_InchargeUpdate)
    If IsdbNull(rs1336!K1336_AttachID) = False Then D1336.AttachID = Trim$(rs1336!K1336_AttachID)
    If IsdbNull(rs1336!K1336_RemarkOrder) = False Then D1336.RemarkOrder = Trim$(rs1336!K1336_RemarkOrder)
    If IsdbNull(rs1336!K1336_RemarkCustomer) = False Then D1336.RemarkCustomer = Trim$(rs1336!K1336_RemarkCustomer)
    If IsdbNull(rs1336!K1336_Remark) = False Then D1336.Remark = Trim$(rs1336!K1336_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K1336_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K1336_MOVE(rs1336 As DataRow)
Try

    call D1336_CLEAR()   

    If IsdbNull(rs1336!K1336_OrderNo) = False Then D1336.OrderNo = Trim$(rs1336!K1336_OrderNo)
    If IsdbNull(rs1336!K1336_OrderNoSeq) = False Then D1336.OrderNoSeq = Trim$(rs1336!K1336_OrderNoSeq)
    If IsdbNull(rs1336!K1336_ProcessSeq) = False Then D1336.ProcessSeq = Trim$(rs1336!K1336_ProcessSeq)
    If IsdbNull(rs1336!K1336_Status) = False Then D1336.Status = Trim$(rs1336!K1336_Status)
    If IsdbNull(rs1336!K1336_seMainProcess) = False Then D1336.seMainProcess = Trim$(rs1336!K1336_seMainProcess)
    If IsdbNull(rs1336!K1336_cdMainProcess) = False Then D1336.cdMainProcess = Trim$(rs1336!K1336_cdMainProcess)
    If IsdbNull(rs1336!K1336_seSubProcess) = False Then D1336.seSubProcess = Trim$(rs1336!K1336_seSubProcess)
    If IsdbNull(rs1336!K1336_cdSubProcess) = False Then D1336.cdSubProcess = Trim$(rs1336!K1336_cdSubProcess)
    If IsdbNull(rs1336!K1336_Description) = False Then D1336.Description = Trim$(rs1336!K1336_Description)
    If IsdbNull(rs1336!K1336_seGroupComponent) = False Then D1336.seGroupComponent = Trim$(rs1336!K1336_seGroupComponent)
    If IsdbNull(rs1336!K1336_cdGroupComponent) = False Then D1336.cdGroupComponent = Trim$(rs1336!K1336_cdGroupComponent)
    If IsdbNull(rs1336!K1336_seComponent) = False Then D1336.seComponent = Trim$(rs1336!K1336_seComponent)
    If IsdbNull(rs1336!K1336_cdComponent) = False Then D1336.cdComponent = Trim$(rs1336!K1336_cdComponent)
    If IsdbNull(rs1336!K1336_MaterialCode) = False Then D1336.MaterialCode = Trim$(rs1336!K1336_MaterialCode)
    If IsdbNull(rs1336!K1336_MaterialDescription) = False Then D1336.MaterialDescription = Trim$(rs1336!K1336_MaterialDescription)
    If IsdbNull(rs1336!K1336_ColorCode) = False Then D1336.ColorCode = Trim$(rs1336!K1336_ColorCode)
    If IsdbNull(rs1336!K1336_SpecMaterial) = False Then D1336.SpecMaterial = Trim$(rs1336!K1336_SpecMaterial)
    If IsdbNull(rs1336!K1336_seUnitMaterial) = False Then D1336.seUnitMaterial = Trim$(rs1336!K1336_seUnitMaterial)
    If IsdbNull(rs1336!K1336_cdUnitMaterial) = False Then D1336.cdUnitMaterial = Trim$(rs1336!K1336_cdUnitMaterial)
    If IsdbNull(rs1336!K1336_seMaterialStatus) = False Then D1336.seMaterialStatus = Trim$(rs1336!K1336_seMaterialStatus)
    If IsdbNull(rs1336!K1336_cdMaterialStatus) = False Then D1336.cdMaterialStatus = Trim$(rs1336!K1336_cdMaterialStatus)
    If IsdbNull(rs1336!K1336_sePurchaseDept) = False Then D1336.sePurchaseDept = Trim$(rs1336!K1336_sePurchaseDept)
    If IsdbNull(rs1336!K1336_cdPutchaseDept) = False Then D1336.cdPutchaseDept = Trim$(rs1336!K1336_cdPutchaseDept)
    If IsdbNull(rs1336!K1336_SupplierCode) = False Then D1336.SupplierCode = Trim$(rs1336!K1336_SupplierCode)
    If IsdbNull(rs1336!K1336_MaterialPrice) = False Then D1336.MaterialPrice = Trim$(rs1336!K1336_MaterialPrice)
    If IsdbNull(rs1336!K1336_Qty) = False Then D1336.Qty = Trim$(rs1336!K1336_Qty)
    If IsdbNull(rs1336!K1336_Consumption) = False Then D1336.Consumption = Trim$(rs1336!K1336_Consumption)
    If IsdbNull(rs1336!K1336_Loss) = False Then D1336.Loss = Trim$(rs1336!K1336_Loss)
    If IsdbNull(rs1336!K1336_GrossUsage) = False Then D1336.GrossUsage = Trim$(rs1336!K1336_GrossUsage)
    If IsdbNull(rs1336!K1336_InsertDate) = False Then D1336.InsertDate = Trim$(rs1336!K1336_InsertDate)
    If IsdbNull(rs1336!K1336_InchargeInsert) = False Then D1336.InchargeInsert = Trim$(rs1336!K1336_InchargeInsert)
    If IsdbNull(rs1336!K1336_UpdateDate) = False Then D1336.UpdateDate = Trim$(rs1336!K1336_UpdateDate)
    If IsdbNull(rs1336!K1336_InchargeUpdate) = False Then D1336.InchargeUpdate = Trim$(rs1336!K1336_InchargeUpdate)
    If IsdbNull(rs1336!K1336_AttachID) = False Then D1336.AttachID = Trim$(rs1336!K1336_AttachID)
    If IsdbNull(rs1336!K1336_RemarkOrder) = False Then D1336.RemarkOrder = Trim$(rs1336!K1336_RemarkOrder)
    If IsdbNull(rs1336!K1336_RemarkCustomer) = False Then D1336.RemarkCustomer = Trim$(rs1336!K1336_RemarkCustomer)
    If IsdbNull(rs1336!K1336_Remark) = False Then D1336.Remark = Trim$(rs1336!K1336_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K1336_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K1336_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z1336 As T1336_AREA, ORDERNO AS String, ORDERNOSEQ AS String, PROCESSSEQ AS String) as Boolean

K1336_MOVE = False

Try
    If READ_PFK1336(ORDERNO, ORDERNOSEQ, PROCESSSEQ) = True Then
                z1336 = D1336
		K1336_MOVE = True
		else
	z1336 = nothing
     End If

     If  getColumIndex(spr,"OrderNo") > -1 then z1336.OrderNo = getDataM(spr, getColumIndex(spr,"OrderNo"), xRow)
     If  getColumIndex(spr,"OrderNoSeq") > -1 then z1336.OrderNoSeq = getDataM(spr, getColumIndex(spr,"OrderNoSeq"), xRow)
     If  getColumIndex(spr,"ProcessSeq") > -1 then z1336.ProcessSeq = getDataM(spr, getColumIndex(spr,"ProcessSeq"), xRow)
     If  getColumIndex(spr,"Status") > -1 then z1336.Status = getDataM(spr, getColumIndex(spr,"Status"), xRow)
     If  getColumIndex(spr,"seMainProcess") > -1 then z1336.seMainProcess = getDataM(spr, getColumIndex(spr,"seMainProcess"), xRow)
     If  getColumIndex(spr,"cdMainProcess") > -1 then z1336.cdMainProcess = getDataM(spr, getColumIndex(spr,"cdMainProcess"), xRow)
     If  getColumIndex(spr,"seSubProcess") > -1 then z1336.seSubProcess = getDataM(spr, getColumIndex(spr,"seSubProcess"), xRow)
     If  getColumIndex(spr,"cdSubProcess") > -1 then z1336.cdSubProcess = getDataM(spr, getColumIndex(spr,"cdSubProcess"), xRow)
     If  getColumIndex(spr,"Description") > -1 then z1336.Description = getDataM(spr, getColumIndex(spr,"Description"), xRow)
     If  getColumIndex(spr,"seGroupComponent") > -1 then z1336.seGroupComponent = getDataM(spr, getColumIndex(spr,"seGroupComponent"), xRow)
     If  getColumIndex(spr,"cdGroupComponent") > -1 then z1336.cdGroupComponent = getDataM(spr, getColumIndex(spr,"cdGroupComponent"), xRow)
     If  getColumIndex(spr,"seComponent") > -1 then z1336.seComponent = getDataM(spr, getColumIndex(spr,"seComponent"), xRow)
     If  getColumIndex(spr,"cdComponent") > -1 then z1336.cdComponent = getDataM(spr, getColumIndex(spr,"cdComponent"), xRow)
     If  getColumIndex(spr,"MaterialCode") > -1 then z1336.MaterialCode = getDataM(spr, getColumIndex(spr,"MaterialCode"), xRow)
     If  getColumIndex(spr,"MaterialDescription") > -1 then z1336.MaterialDescription = getDataM(spr, getColumIndex(spr,"MaterialDescription"), xRow)
     If  getColumIndex(spr,"ColorCode") > -1 then z1336.ColorCode = getDataM(spr, getColumIndex(spr,"ColorCode"), xRow)
     If  getColumIndex(spr,"SpecMaterial") > -1 then z1336.SpecMaterial = getDataM(spr, getColumIndex(spr,"SpecMaterial"), xRow)
     If  getColumIndex(spr,"seUnitMaterial") > -1 then z1336.seUnitMaterial = getDataM(spr, getColumIndex(spr,"seUnitMaterial"), xRow)
     If  getColumIndex(spr,"cdUnitMaterial") > -1 then z1336.cdUnitMaterial = getDataM(spr, getColumIndex(spr,"cdUnitMaterial"), xRow)
     If  getColumIndex(spr,"seMaterialStatus") > -1 then z1336.seMaterialStatus = getDataM(spr, getColumIndex(spr,"seMaterialStatus"), xRow)
     If  getColumIndex(spr,"cdMaterialStatus") > -1 then z1336.cdMaterialStatus = getDataM(spr, getColumIndex(spr,"cdMaterialStatus"), xRow)
     If  getColumIndex(spr,"sePurchaseDept") > -1 then z1336.sePurchaseDept = getDataM(spr, getColumIndex(spr,"sePurchaseDept"), xRow)
     If  getColumIndex(spr,"cdPutchaseDept") > -1 then z1336.cdPutchaseDept = getDataM(spr, getColumIndex(spr,"cdPutchaseDept"), xRow)
     If  getColumIndex(spr,"SupplierCode") > -1 then z1336.SupplierCode = getDataM(spr, getColumIndex(spr,"SupplierCode"), xRow)
     If  getColumIndex(spr,"MaterialPrice") > -1 then z1336.MaterialPrice = getDataM(spr, getColumIndex(spr,"MaterialPrice"), xRow)
     If  getColumIndex(spr,"Qty") > -1 then z1336.Qty = getDataM(spr, getColumIndex(spr,"Qty"), xRow)
     If  getColumIndex(spr,"Consumption") > -1 then z1336.Consumption = getDataM(spr, getColumIndex(spr,"Consumption"), xRow)
     If  getColumIndex(spr,"Loss") > -1 then z1336.Loss = getDataM(spr, getColumIndex(spr,"Loss"), xRow)
     If  getColumIndex(spr,"GrossUsage") > -1 then z1336.GrossUsage = getDataM(spr, getColumIndex(spr,"GrossUsage"), xRow)
     If  getColumIndex(spr,"InsertDate") > -1 then z1336.InsertDate = getDataM(spr, getColumIndex(spr,"InsertDate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z1336.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"UpdateDate") > -1 then z1336.UpdateDate = getDataM(spr, getColumIndex(spr,"UpdateDate"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z1336.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"AttachID") > -1 then z1336.AttachID = getDataM(spr, getColumIndex(spr,"AttachID"), xRow)
     If  getColumIndex(spr,"RemarkOrder") > -1 then z1336.RemarkOrder = getDataM(spr, getColumIndex(spr,"RemarkOrder"), xRow)
     If  getColumIndex(spr,"RemarkCustomer") > -1 then z1336.RemarkCustomer = getDataM(spr, getColumIndex(spr,"RemarkCustomer"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z1336.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K1336_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K1336_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z1336 As T1336_AREA,CheckClear as Boolean,ORDERNO AS String, ORDERNOSEQ AS String, PROCESSSEQ AS String) as Boolean

K1336_MOVE = False

Try
    If READ_PFK1336(ORDERNO, ORDERNOSEQ, PROCESSSEQ) = True Then
                z1336 = D1336
		K1336_MOVE = True
		else
	If CheckClear  = True then z1336 = nothing
     End If

     If  getColumIndex(spr,"OrderNo") > -1 then z1336.OrderNo = getDataM(spr, getColumIndex(spr,"OrderNo"), xRow)
     If  getColumIndex(spr,"OrderNoSeq") > -1 then z1336.OrderNoSeq = getDataM(spr, getColumIndex(spr,"OrderNoSeq"), xRow)
     If  getColumIndex(spr,"ProcessSeq") > -1 then z1336.ProcessSeq = getDataM(spr, getColumIndex(spr,"ProcessSeq"), xRow)
     If  getColumIndex(spr,"Status") > -1 then z1336.Status = getDataM(spr, getColumIndex(spr,"Status"), xRow)
     If  getColumIndex(spr,"seMainProcess") > -1 then z1336.seMainProcess = getDataM(spr, getColumIndex(spr,"seMainProcess"), xRow)
     If  getColumIndex(spr,"cdMainProcess") > -1 then z1336.cdMainProcess = getDataM(spr, getColumIndex(spr,"cdMainProcess"), xRow)
     If  getColumIndex(spr,"seSubProcess") > -1 then z1336.seSubProcess = getDataM(spr, getColumIndex(spr,"seSubProcess"), xRow)
     If  getColumIndex(spr,"cdSubProcess") > -1 then z1336.cdSubProcess = getDataM(spr, getColumIndex(spr,"cdSubProcess"), xRow)
     If  getColumIndex(spr,"Description") > -1 then z1336.Description = getDataM(spr, getColumIndex(spr,"Description"), xRow)
     If  getColumIndex(spr,"seGroupComponent") > -1 then z1336.seGroupComponent = getDataM(spr, getColumIndex(spr,"seGroupComponent"), xRow)
     If  getColumIndex(spr,"cdGroupComponent") > -1 then z1336.cdGroupComponent = getDataM(spr, getColumIndex(spr,"cdGroupComponent"), xRow)
     If  getColumIndex(spr,"seComponent") > -1 then z1336.seComponent = getDataM(spr, getColumIndex(spr,"seComponent"), xRow)
     If  getColumIndex(spr,"cdComponent") > -1 then z1336.cdComponent = getDataM(spr, getColumIndex(spr,"cdComponent"), xRow)
     If  getColumIndex(spr,"MaterialCode") > -1 then z1336.MaterialCode = getDataM(spr, getColumIndex(spr,"MaterialCode"), xRow)
     If  getColumIndex(spr,"MaterialDescription") > -1 then z1336.MaterialDescription = getDataM(spr, getColumIndex(spr,"MaterialDescription"), xRow)
     If  getColumIndex(spr,"ColorCode") > -1 then z1336.ColorCode = getDataM(spr, getColumIndex(spr,"ColorCode"), xRow)
     If  getColumIndex(spr,"SpecMaterial") > -1 then z1336.SpecMaterial = getDataM(spr, getColumIndex(spr,"SpecMaterial"), xRow)
     If  getColumIndex(spr,"seUnitMaterial") > -1 then z1336.seUnitMaterial = getDataM(spr, getColumIndex(spr,"seUnitMaterial"), xRow)
     If  getColumIndex(spr,"cdUnitMaterial") > -1 then z1336.cdUnitMaterial = getDataM(spr, getColumIndex(spr,"cdUnitMaterial"), xRow)
     If  getColumIndex(spr,"seMaterialStatus") > -1 then z1336.seMaterialStatus = getDataM(spr, getColumIndex(spr,"seMaterialStatus"), xRow)
     If  getColumIndex(spr,"cdMaterialStatus") > -1 then z1336.cdMaterialStatus = getDataM(spr, getColumIndex(spr,"cdMaterialStatus"), xRow)
     If  getColumIndex(spr,"sePurchaseDept") > -1 then z1336.sePurchaseDept = getDataM(spr, getColumIndex(spr,"sePurchaseDept"), xRow)
     If  getColumIndex(spr,"cdPutchaseDept") > -1 then z1336.cdPutchaseDept = getDataM(spr, getColumIndex(spr,"cdPutchaseDept"), xRow)
     If  getColumIndex(spr,"SupplierCode") > -1 then z1336.SupplierCode = getDataM(spr, getColumIndex(spr,"SupplierCode"), xRow)
     If  getColumIndex(spr,"MaterialPrice") > -1 then z1336.MaterialPrice = getDataM(spr, getColumIndex(spr,"MaterialPrice"), xRow)
     If  getColumIndex(spr,"Qty") > -1 then z1336.Qty = getDataM(spr, getColumIndex(spr,"Qty"), xRow)
     If  getColumIndex(spr,"Consumption") > -1 then z1336.Consumption = getDataM(spr, getColumIndex(spr,"Consumption"), xRow)
     If  getColumIndex(spr,"Loss") > -1 then z1336.Loss = getDataM(spr, getColumIndex(spr,"Loss"), xRow)
     If  getColumIndex(spr,"GrossUsage") > -1 then z1336.GrossUsage = getDataM(spr, getColumIndex(spr,"GrossUsage"), xRow)
     If  getColumIndex(spr,"InsertDate") > -1 then z1336.InsertDate = getDataM(spr, getColumIndex(spr,"InsertDate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z1336.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"UpdateDate") > -1 then z1336.UpdateDate = getDataM(spr, getColumIndex(spr,"UpdateDate"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z1336.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"AttachID") > -1 then z1336.AttachID = getDataM(spr, getColumIndex(spr,"AttachID"), xRow)
     If  getColumIndex(spr,"RemarkOrder") > -1 then z1336.RemarkOrder = getDataM(spr, getColumIndex(spr,"RemarkOrder"), xRow)
     If  getColumIndex(spr,"RemarkCustomer") > -1 then z1336.RemarkCustomer = getDataM(spr, getColumIndex(spr,"RemarkCustomer"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z1336.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K1336_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K1336_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z1336 As T1336_AREA, Job as String, ORDERNO AS String, ORDERNOSEQ AS String, PROCESSSEQ AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K1336_MOVE = False

Try
    If READ_PFK1336(ORDERNO, ORDERNOSEQ, PROCESSSEQ) = True Then
                z1336 = D1336
		K1336_MOVE = True
		else
	z1336 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK1336")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "ORDERNO":z1336.OrderNo = Children(i).Code
   Case "ORDERNOSEQ":z1336.OrderNoSeq = Children(i).Code
   Case "PROCESSSEQ":z1336.ProcessSeq = Children(i).Code
   Case "STATUS":z1336.Status = Children(i).Code
   Case "SEMAINPROCESS":z1336.seMainProcess = Children(i).Code
   Case "CDMAINPROCESS":z1336.cdMainProcess = Children(i).Code
   Case "SESUBPROCESS":z1336.seSubProcess = Children(i).Code
   Case "CDSUBPROCESS":z1336.cdSubProcess = Children(i).Code
   Case "DESCRIPTION":z1336.Description = Children(i).Code
   Case "SEGROUPCOMPONENT":z1336.seGroupComponent = Children(i).Code
   Case "CDGROUPCOMPONENT":z1336.cdGroupComponent = Children(i).Code
   Case "SECOMPONENT":z1336.seComponent = Children(i).Code
   Case "CDCOMPONENT":z1336.cdComponent = Children(i).Code
   Case "MATERIALCODE":z1336.MaterialCode = Children(i).Code
   Case "MATERIALDESCRIPTION":z1336.MaterialDescription = Children(i).Code
   Case "COLORCODE":z1336.ColorCode = Children(i).Code
   Case "SPECMATERIAL":z1336.SpecMaterial = Children(i).Code
   Case "SEUNITMATERIAL":z1336.seUnitMaterial = Children(i).Code
   Case "CDUNITMATERIAL":z1336.cdUnitMaterial = Children(i).Code
   Case "SEMATERIALSTATUS":z1336.seMaterialStatus = Children(i).Code
   Case "CDMATERIALSTATUS":z1336.cdMaterialStatus = Children(i).Code
   Case "SEPURCHASEDEPT":z1336.sePurchaseDept = Children(i).Code
   Case "CDPUTCHASEDEPT":z1336.cdPutchaseDept = Children(i).Code
   Case "SUPPLIERCODE":z1336.SupplierCode = Children(i).Code
   Case "MATERIALPRICE":z1336.MaterialPrice = Children(i).Code
   Case "QTY":z1336.Qty = Children(i).Code
   Case "CONSUMPTION":z1336.Consumption = Children(i).Code
   Case "LOSS":z1336.Loss = Children(i).Code
   Case "GROSSUSAGE":z1336.GrossUsage = Children(i).Code
   Case "INSERTDATE":z1336.InsertDate = Children(i).Code
   Case "INCHARGEINSERT":z1336.InchargeInsert = Children(i).Code
   Case "UPDATEDATE":z1336.UpdateDate = Children(i).Code
   Case "INCHARGEUPDATE":z1336.InchargeUpdate = Children(i).Code
   Case "ATTACHID":z1336.AttachID = Children(i).Code
   Case "REMARKORDER":z1336.RemarkOrder = Children(i).Code
   Case "REMARKCUSTOMER":z1336.RemarkCustomer = Children(i).Code
   Case "REMARK":z1336.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "ORDERNO":z1336.OrderNo = Children(i).Data
   Case "ORDERNOSEQ":z1336.OrderNoSeq = Children(i).Data
   Case "PROCESSSEQ":z1336.ProcessSeq = Children(i).Data
   Case "STATUS":z1336.Status = Children(i).Data
   Case "SEMAINPROCESS":z1336.seMainProcess = Children(i).Data
   Case "CDMAINPROCESS":z1336.cdMainProcess = Children(i).Data
   Case "SESUBPROCESS":z1336.seSubProcess = Children(i).Data
   Case "CDSUBPROCESS":z1336.cdSubProcess = Children(i).Data
   Case "DESCRIPTION":z1336.Description = Children(i).Data
   Case "SEGROUPCOMPONENT":z1336.seGroupComponent = Children(i).Data
   Case "CDGROUPCOMPONENT":z1336.cdGroupComponent = Children(i).Data
   Case "SECOMPONENT":z1336.seComponent = Children(i).Data
   Case "CDCOMPONENT":z1336.cdComponent = Children(i).Data
   Case "MATERIALCODE":z1336.MaterialCode = Children(i).Data
   Case "MATERIALDESCRIPTION":z1336.MaterialDescription = Children(i).Data
   Case "COLORCODE":z1336.ColorCode = Children(i).Data
   Case "SPECMATERIAL":z1336.SpecMaterial = Children(i).Data
   Case "SEUNITMATERIAL":z1336.seUnitMaterial = Children(i).Data
   Case "CDUNITMATERIAL":z1336.cdUnitMaterial = Children(i).Data
   Case "SEMATERIALSTATUS":z1336.seMaterialStatus = Children(i).Data
   Case "CDMATERIALSTATUS":z1336.cdMaterialStatus = Children(i).Data
   Case "SEPURCHASEDEPT":z1336.sePurchaseDept = Children(i).Data
   Case "CDPUTCHASEDEPT":z1336.cdPutchaseDept = Children(i).Data
   Case "SUPPLIERCODE":z1336.SupplierCode = Children(i).Data
   Case "MATERIALPRICE":z1336.MaterialPrice = Children(i).Data
   Case "QTY":z1336.Qty = Children(i).Data
   Case "CONSUMPTION":z1336.Consumption = Children(i).Data
   Case "LOSS":z1336.Loss = Children(i).Data
   Case "GROSSUSAGE":z1336.GrossUsage = Children(i).Data
   Case "INSERTDATE":z1336.InsertDate = Children(i).Data
   Case "INCHARGEINSERT":z1336.InchargeInsert = Children(i).Data
   Case "UPDATEDATE":z1336.UpdateDate = Children(i).Data
   Case "INCHARGEUPDATE":z1336.InchargeUpdate = Children(i).Data
   Case "ATTACHID":z1336.AttachID = Children(i).Data
   Case "REMARKORDER":z1336.RemarkOrder = Children(i).Data
   Case "REMARKCUSTOMER":z1336.RemarkCustomer = Children(i).Data
   Case "REMARK":z1336.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K1336_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K1336_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z1336 As T1336_AREA, Job as String, CheckClear as Boolean, ORDERNO AS String, ORDERNOSEQ AS String, PROCESSSEQ AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K1336_MOVE = False

Try
    If READ_PFK1336(ORDERNO, ORDERNOSEQ, PROCESSSEQ) = True Then
                z1336 = D1336
		K1336_MOVE = True
		else
	If CheckClear  = True then z1336 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK1336")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "ORDERNO":z1336.OrderNo = Children(i).Code
   Case "ORDERNOSEQ":z1336.OrderNoSeq = Children(i).Code
   Case "PROCESSSEQ":z1336.ProcessSeq = Children(i).Code
   Case "STATUS":z1336.Status = Children(i).Code
   Case "SEMAINPROCESS":z1336.seMainProcess = Children(i).Code
   Case "CDMAINPROCESS":z1336.cdMainProcess = Children(i).Code
   Case "SESUBPROCESS":z1336.seSubProcess = Children(i).Code
   Case "CDSUBPROCESS":z1336.cdSubProcess = Children(i).Code
   Case "DESCRIPTION":z1336.Description = Children(i).Code
   Case "SEGROUPCOMPONENT":z1336.seGroupComponent = Children(i).Code
   Case "CDGROUPCOMPONENT":z1336.cdGroupComponent = Children(i).Code
   Case "SECOMPONENT":z1336.seComponent = Children(i).Code
   Case "CDCOMPONENT":z1336.cdComponent = Children(i).Code
   Case "MATERIALCODE":z1336.MaterialCode = Children(i).Code
   Case "MATERIALDESCRIPTION":z1336.MaterialDescription = Children(i).Code
   Case "COLORCODE":z1336.ColorCode = Children(i).Code
   Case "SPECMATERIAL":z1336.SpecMaterial = Children(i).Code
   Case "SEUNITMATERIAL":z1336.seUnitMaterial = Children(i).Code
   Case "CDUNITMATERIAL":z1336.cdUnitMaterial = Children(i).Code
   Case "SEMATERIALSTATUS":z1336.seMaterialStatus = Children(i).Code
   Case "CDMATERIALSTATUS":z1336.cdMaterialStatus = Children(i).Code
   Case "SEPURCHASEDEPT":z1336.sePurchaseDept = Children(i).Code
   Case "CDPUTCHASEDEPT":z1336.cdPutchaseDept = Children(i).Code
   Case "SUPPLIERCODE":z1336.SupplierCode = Children(i).Code
   Case "MATERIALPRICE":z1336.MaterialPrice = Children(i).Code
   Case "QTY":z1336.Qty = Children(i).Code
   Case "CONSUMPTION":z1336.Consumption = Children(i).Code
   Case "LOSS":z1336.Loss = Children(i).Code
   Case "GROSSUSAGE":z1336.GrossUsage = Children(i).Code
   Case "INSERTDATE":z1336.InsertDate = Children(i).Code
   Case "INCHARGEINSERT":z1336.InchargeInsert = Children(i).Code
   Case "UPDATEDATE":z1336.UpdateDate = Children(i).Code
   Case "INCHARGEUPDATE":z1336.InchargeUpdate = Children(i).Code
   Case "ATTACHID":z1336.AttachID = Children(i).Code
   Case "REMARKORDER":z1336.RemarkOrder = Children(i).Code
   Case "REMARKCUSTOMER":z1336.RemarkCustomer = Children(i).Code
   Case "REMARK":z1336.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "ORDERNO":z1336.OrderNo = Children(i).Data
   Case "ORDERNOSEQ":z1336.OrderNoSeq = Children(i).Data
   Case "PROCESSSEQ":z1336.ProcessSeq = Children(i).Data
   Case "STATUS":z1336.Status = Children(i).Data
   Case "SEMAINPROCESS":z1336.seMainProcess = Children(i).Data
   Case "CDMAINPROCESS":z1336.cdMainProcess = Children(i).Data
   Case "SESUBPROCESS":z1336.seSubProcess = Children(i).Data
   Case "CDSUBPROCESS":z1336.cdSubProcess = Children(i).Data
   Case "DESCRIPTION":z1336.Description = Children(i).Data
   Case "SEGROUPCOMPONENT":z1336.seGroupComponent = Children(i).Data
   Case "CDGROUPCOMPONENT":z1336.cdGroupComponent = Children(i).Data
   Case "SECOMPONENT":z1336.seComponent = Children(i).Data
   Case "CDCOMPONENT":z1336.cdComponent = Children(i).Data
   Case "MATERIALCODE":z1336.MaterialCode = Children(i).Data
   Case "MATERIALDESCRIPTION":z1336.MaterialDescription = Children(i).Data
   Case "COLORCODE":z1336.ColorCode = Children(i).Data
   Case "SPECMATERIAL":z1336.SpecMaterial = Children(i).Data
   Case "SEUNITMATERIAL":z1336.seUnitMaterial = Children(i).Data
   Case "CDUNITMATERIAL":z1336.cdUnitMaterial = Children(i).Data
   Case "SEMATERIALSTATUS":z1336.seMaterialStatus = Children(i).Data
   Case "CDMATERIALSTATUS":z1336.cdMaterialStatus = Children(i).Data
   Case "SEPURCHASEDEPT":z1336.sePurchaseDept = Children(i).Data
   Case "CDPUTCHASEDEPT":z1336.cdPutchaseDept = Children(i).Data
   Case "SUPPLIERCODE":z1336.SupplierCode = Children(i).Data
   Case "MATERIALPRICE":z1336.MaterialPrice = Children(i).Data
   Case "QTY":z1336.Qty = Children(i).Data
   Case "CONSUMPTION":z1336.Consumption = Children(i).Data
   Case "LOSS":z1336.Loss = Children(i).Data
   Case "GROSSUSAGE":z1336.GrossUsage = Children(i).Data
   Case "INSERTDATE":z1336.InsertDate = Children(i).Data
   Case "INCHARGEINSERT":z1336.InchargeInsert = Children(i).Data
   Case "UPDATEDATE":z1336.UpdateDate = Children(i).Data
   Case "INCHARGEUPDATE":z1336.InchargeUpdate = Children(i).Data
   Case "ATTACHID":z1336.AttachID = Children(i).Data
   Case "REMARKORDER":z1336.RemarkOrder = Children(i).Data
   Case "REMARKCUSTOMER":z1336.RemarkCustomer = Children(i).Data
   Case "REMARK":z1336.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K1336_MOVE",vbCritical)
End Try
End Function 
    
End Module 
