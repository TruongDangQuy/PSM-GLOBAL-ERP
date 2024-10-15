'=========================================================================================================================================================
'   TABLE : (PFK0125)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K0125

Structure T0125_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	SpecNo	 AS String	'			char(9)		*
Public 	SpecNoSeq	 AS String	'			char(3)		*
Public 	ProcessSeq	 AS String	'			char(3)		*
Public 	MatchingSeq	 AS Double	'			decimal		*
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
Public 	MaterialSpec	 AS String	'			char(9)
Public 	seUnitMaterial	 AS String	'			char(3)
Public 	cdUnitMaterial	 AS String	'			char(3)
Public 	seMaterialStatus	 AS String	'			char(3)
Public 	cdMaterialStatus	 AS String	'			char(3)
Public 	sePurchaseDept	 AS String	'			char(3)
Public 	cdPurchaseDept	 AS String	'			char(3)
Public 	SupplierCode	 AS String	'			char(6)
Public 	MaterialPrice	 AS Double	'			decimal
Public 	Qty	 AS Double	'			decimal
Public 	Consumption	 AS Double	'			decimal
Public 	Loss	 AS Double	'			decimal
Public 	GrossUsage	 AS Double	'			decimal
Public 	AMTMaterial	 AS Double	'			decimal
Public 	InsertDate	 AS String	'			char(8)
Public 	InchargeInsert	 AS String	'			char(6)
Public 	UpdateDate	 AS String	'			char(8)
Public 	InchargeUpdate	 AS String	'			char(6)
Public 	AttachID	 AS String	'			char(6)
Public 	RemarkOrder	 AS String	'			nvarchar(500)
Public 	RemarkCustomer	 AS String	'			nvarchar(500)
Public 	Remark	 AS String	'			nvarchar(500)
'=========================================================================================================================================================
End structure

Public D0125 As T0125_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK0125(SPECNO AS String, SPECNOSEQ AS String, PROCESSSEQ AS String, MATCHINGSEQ AS Double) As Boolean
    READ_PFK0125 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK0125 "
    SQL = SQL & " WHERE K0125_SpecNo		 = '" & SpecNo & "' " 
    SQL = SQL & "   AND K0125_SpecNoSeq		 = '" & SpecNoSeq & "' " 
    SQL = SQL & "   AND K0125_ProcessSeq		 = '" & ProcessSeq & "' " 
    SQL = SQL & "   AND K0125_MatchingSeq		 =  " & MatchingSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D0125_CLEAR: GoTo SKIP_READ_PFK0125
                
    Call K0125_MOVE(rd)
    READ_PFK0125 = True

SKIP_READ_PFK0125:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK0125",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK0125(SPECNO AS String, SPECNOSEQ AS String, PROCESSSEQ AS String, MATCHINGSEQ AS Double, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK0125 "
    SQL = SQL & " WHERE K0125_SpecNo		 = '" & SpecNo & "' " 
    SQL = SQL & "   AND K0125_SpecNoSeq		 = '" & SpecNoSeq & "' " 
    SQL = SQL & "   AND K0125_ProcessSeq		 = '" & ProcessSeq & "' " 
    SQL = SQL & "   AND K0125_MatchingSeq		 =  " & MatchingSeq & "  " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK0125",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK0125(z0125 As T0125_AREA) As Boolean
    WRITE_PFK0125 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z0125)
 
    SQL = " INSERT INTO PFK0125 "
    SQL = SQL & " ( "
    SQL = SQL & " K0125_SpecNo," 
    SQL = SQL & " K0125_SpecNoSeq," 
    SQL = SQL & " K0125_ProcessSeq," 
    SQL = SQL & " K0125_MatchingSeq," 
    SQL = SQL & " K0125_Status," 
    SQL = SQL & " K0125_seMainProcess," 
    SQL = SQL & " K0125_cdMainProcess," 
    SQL = SQL & " K0125_seSubProcess," 
    SQL = SQL & " K0125_cdSubProcess," 
    SQL = SQL & " K0125_Description," 
    SQL = SQL & " K0125_seGroupComponent," 
    SQL = SQL & " K0125_cdGroupComponent," 
    SQL = SQL & " K0125_seComponent," 
    SQL = SQL & " K0125_cdComponent," 
    SQL = SQL & " K0125_MaterialCode," 
    SQL = SQL & " K0125_MaterialDescription," 
    SQL = SQL & " K0125_ColorCode," 
    SQL = SQL & " K0125_MaterialSpec," 
    SQL = SQL & " K0125_seUnitMaterial," 
    SQL = SQL & " K0125_cdUnitMaterial," 
    SQL = SQL & " K0125_seMaterialStatus," 
    SQL = SQL & " K0125_cdMaterialStatus," 
    SQL = SQL & " K0125_sePurchaseDept," 
    SQL = SQL & " K0125_cdPurchaseDept," 
    SQL = SQL & " K0125_SupplierCode," 
    SQL = SQL & " K0125_MaterialPrice," 
    SQL = SQL & " K0125_Qty," 
    SQL = SQL & " K0125_Consumption," 
    SQL = SQL & " K0125_Loss," 
    SQL = SQL & " K0125_GrossUsage," 
    SQL = SQL & " K0125_AMTMaterial," 
    SQL = SQL & " K0125_InsertDate," 
    SQL = SQL & " K0125_InchargeInsert," 
    SQL = SQL & " K0125_UpdateDate," 
    SQL = SQL & " K0125_InchargeUpdate," 
    SQL = SQL & " K0125_AttachID," 
    SQL = SQL & " K0125_RemarkOrder," 
    SQL = SQL & " K0125_RemarkCustomer," 
    SQL = SQL & " K0125_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z0125.SpecNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0125.SpecNoSeq) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0125.ProcessSeq) & "', "  
    SQL = SQL & "   " & FormatSQL(z0125.MatchingSeq) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z0125.Status) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0125.seMainProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0125.cdMainProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0125.seSubProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0125.cdSubProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0125.Description) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0125.seGroupComponent) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0125.cdGroupComponent) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0125.seComponent) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0125.cdComponent) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0125.MaterialCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0125.MaterialDescription) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0125.ColorCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0125.MaterialSpec) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0125.seUnitMaterial) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0125.cdUnitMaterial) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0125.seMaterialStatus) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0125.cdMaterialStatus) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0125.sePurchaseDept) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0125.cdPurchaseDept) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0125.SupplierCode) & "', "  
    SQL = SQL & "   " & FormatSQL(z0125.MaterialPrice) & ", "  
    SQL = SQL & "   " & FormatSQL(z0125.Qty) & ", "  
    SQL = SQL & "   " & FormatSQL(z0125.Consumption) & ", "  
    SQL = SQL & "   " & FormatSQL(z0125.Loss) & ", "  
    SQL = SQL & "   " & FormatSQL(z0125.GrossUsage) & ", "  
    SQL = SQL & "   " & FormatSQL(z0125.AMTMaterial) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z0125.InsertDate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0125.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0125.UpdateDate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0125.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0125.AttachID) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0125.RemarkOrder) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0125.RemarkCustomer) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0125.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK0125 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK0125",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK0125(z0125 As T0125_AREA) As Boolean
    REWRITE_PFK0125 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z0125)
   
    SQL = " UPDATE PFK0125 SET "
    SQL = SQL & "    K0125_Status      = N'" & FormatSQL(z0125.Status) & "', " 
    SQL = SQL & "    K0125_seMainProcess      = N'" & FormatSQL(z0125.seMainProcess) & "', " 
    SQL = SQL & "    K0125_cdMainProcess      = N'" & FormatSQL(z0125.cdMainProcess) & "', " 
    SQL = SQL & "    K0125_seSubProcess      = N'" & FormatSQL(z0125.seSubProcess) & "', " 
    SQL = SQL & "    K0125_cdSubProcess      = N'" & FormatSQL(z0125.cdSubProcess) & "', " 
    SQL = SQL & "    K0125_Description      = N'" & FormatSQL(z0125.Description) & "', " 
    SQL = SQL & "    K0125_seGroupComponent      = N'" & FormatSQL(z0125.seGroupComponent) & "', " 
    SQL = SQL & "    K0125_cdGroupComponent      = N'" & FormatSQL(z0125.cdGroupComponent) & "', " 
    SQL = SQL & "    K0125_seComponent      = N'" & FormatSQL(z0125.seComponent) & "', " 
    SQL = SQL & "    K0125_cdComponent      = N'" & FormatSQL(z0125.cdComponent) & "', " 
    SQL = SQL & "    K0125_MaterialCode      = N'" & FormatSQL(z0125.MaterialCode) & "', " 
    SQL = SQL & "    K0125_MaterialDescription      = N'" & FormatSQL(z0125.MaterialDescription) & "', " 
    SQL = SQL & "    K0125_ColorCode      = N'" & FormatSQL(z0125.ColorCode) & "', " 
    SQL = SQL & "    K0125_MaterialSpec      = N'" & FormatSQL(z0125.MaterialSpec) & "', " 
    SQL = SQL & "    K0125_seUnitMaterial      = N'" & FormatSQL(z0125.seUnitMaterial) & "', " 
    SQL = SQL & "    K0125_cdUnitMaterial      = N'" & FormatSQL(z0125.cdUnitMaterial) & "', " 
    SQL = SQL & "    K0125_seMaterialStatus      = N'" & FormatSQL(z0125.seMaterialStatus) & "', " 
    SQL = SQL & "    K0125_cdMaterialStatus      = N'" & FormatSQL(z0125.cdMaterialStatus) & "', " 
    SQL = SQL & "    K0125_sePurchaseDept      = N'" & FormatSQL(z0125.sePurchaseDept) & "', " 
    SQL = SQL & "    K0125_cdPurchaseDept      = N'" & FormatSQL(z0125.cdPurchaseDept) & "', " 
    SQL = SQL & "    K0125_SupplierCode      = N'" & FormatSQL(z0125.SupplierCode) & "', " 
    SQL = SQL & "    K0125_MaterialPrice      =  " & FormatSQL(z0125.MaterialPrice) & ", " 
    SQL = SQL & "    K0125_Qty      =  " & FormatSQL(z0125.Qty) & ", " 
    SQL = SQL & "    K0125_Consumption      =  " & FormatSQL(z0125.Consumption) & ", " 
    SQL = SQL & "    K0125_Loss      =  " & FormatSQL(z0125.Loss) & ", " 
    SQL = SQL & "    K0125_GrossUsage      =  " & FormatSQL(z0125.GrossUsage) & ", " 
    SQL = SQL & "    K0125_AMTMaterial      =  " & FormatSQL(z0125.AMTMaterial) & ", " 
    SQL = SQL & "    K0125_InsertDate      = N'" & FormatSQL(z0125.InsertDate) & "', " 
    SQL = SQL & "    K0125_InchargeInsert      = N'" & FormatSQL(z0125.InchargeInsert) & "', " 
    SQL = SQL & "    K0125_UpdateDate      = N'" & FormatSQL(z0125.UpdateDate) & "', " 
    SQL = SQL & "    K0125_InchargeUpdate      = N'" & FormatSQL(z0125.InchargeUpdate) & "', " 
    SQL = SQL & "    K0125_AttachID      = N'" & FormatSQL(z0125.AttachID) & "', " 
    SQL = SQL & "    K0125_RemarkOrder      = N'" & FormatSQL(z0125.RemarkOrder) & "', " 
    SQL = SQL & "    K0125_RemarkCustomer      = N'" & FormatSQL(z0125.RemarkCustomer) & "', " 
    SQL = SQL & "    K0125_Remark      = N'" & FormatSQL(z0125.Remark) & "'  " 
    SQL = SQL & " WHERE K0125_SpecNo		 = '" & z0125.SpecNo & "' " 
    SQL = SQL & "   AND K0125_SpecNoSeq		 = '" & z0125.SpecNoSeq & "' " 
    SQL = SQL & "   AND K0125_ProcessSeq		 = '" & z0125.ProcessSeq & "' " 
    SQL = SQL & "   AND K0125_MatchingSeq		 =  " & z0125.MatchingSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK0125 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK0125",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK0125(z0125 As T0125_AREA) As Boolean
    DELETE_PFK0125 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK0125 "
    SQL = SQL & " WHERE K0125_SpecNo		 = '" & z0125.SpecNo & "' " 
    SQL = SQL & "   AND K0125_SpecNoSeq		 = '" & z0125.SpecNoSeq & "' " 
    SQL = SQL & "   AND K0125_ProcessSeq		 = '" & z0125.ProcessSeq & "' " 
    SQL = SQL & "   AND K0125_MatchingSeq		 =  " & z0125.MatchingSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK0125 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK0125",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D0125_CLEAR()
Try
    
   D0125.SpecNo = ""
   D0125.SpecNoSeq = ""
   D0125.ProcessSeq = ""
    D0125.MatchingSeq = 0 
   D0125.Status = ""
   D0125.seMainProcess = ""
   D0125.cdMainProcess = ""
   D0125.seSubProcess = ""
   D0125.cdSubProcess = ""
   D0125.Description = ""
   D0125.seGroupComponent = ""
   D0125.cdGroupComponent = ""
   D0125.seComponent = ""
   D0125.cdComponent = ""
   D0125.MaterialCode = ""
   D0125.MaterialDescription = ""
   D0125.ColorCode = ""
   D0125.MaterialSpec = ""
   D0125.seUnitMaterial = ""
   D0125.cdUnitMaterial = ""
   D0125.seMaterialStatus = ""
   D0125.cdMaterialStatus = ""
   D0125.sePurchaseDept = ""
   D0125.cdPurchaseDept = ""
   D0125.SupplierCode = ""
    D0125.MaterialPrice = 0 
    D0125.Qty = 0 
    D0125.Consumption = 0 
    D0125.Loss = 0 
    D0125.GrossUsage = 0 
    D0125.AMTMaterial = 0 
   D0125.InsertDate = ""
   D0125.InchargeInsert = ""
   D0125.UpdateDate = ""
   D0125.InchargeUpdate = ""
   D0125.AttachID = ""
   D0125.RemarkOrder = ""
   D0125.RemarkCustomer = ""
   D0125.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D0125_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x0125 As T0125_AREA)
Try
    
    x0125.SpecNo = trim$(  x0125.SpecNo)
    x0125.SpecNoSeq = trim$(  x0125.SpecNoSeq)
    x0125.ProcessSeq = trim$(  x0125.ProcessSeq)
    x0125.MatchingSeq = trim$(  x0125.MatchingSeq)
    x0125.Status = trim$(  x0125.Status)
    x0125.seMainProcess = trim$(  x0125.seMainProcess)
    x0125.cdMainProcess = trim$(  x0125.cdMainProcess)
    x0125.seSubProcess = trim$(  x0125.seSubProcess)
    x0125.cdSubProcess = trim$(  x0125.cdSubProcess)
    x0125.Description = trim$(  x0125.Description)
    x0125.seGroupComponent = trim$(  x0125.seGroupComponent)
    x0125.cdGroupComponent = trim$(  x0125.cdGroupComponent)
    x0125.seComponent = trim$(  x0125.seComponent)
    x0125.cdComponent = trim$(  x0125.cdComponent)
    x0125.MaterialCode = trim$(  x0125.MaterialCode)
    x0125.MaterialDescription = trim$(  x0125.MaterialDescription)
    x0125.ColorCode = trim$(  x0125.ColorCode)
    x0125.MaterialSpec = trim$(  x0125.MaterialSpec)
    x0125.seUnitMaterial = trim$(  x0125.seUnitMaterial)
    x0125.cdUnitMaterial = trim$(  x0125.cdUnitMaterial)
    x0125.seMaterialStatus = trim$(  x0125.seMaterialStatus)
    x0125.cdMaterialStatus = trim$(  x0125.cdMaterialStatus)
    x0125.sePurchaseDept = trim$(  x0125.sePurchaseDept)
    x0125.cdPurchaseDept = trim$(  x0125.cdPurchaseDept)
    x0125.SupplierCode = trim$(  x0125.SupplierCode)
    x0125.MaterialPrice = trim$(  x0125.MaterialPrice)
    x0125.Qty = trim$(  x0125.Qty)
    x0125.Consumption = trim$(  x0125.Consumption)
    x0125.Loss = trim$(  x0125.Loss)
    x0125.GrossUsage = trim$(  x0125.GrossUsage)
    x0125.AMTMaterial = trim$(  x0125.AMTMaterial)
    x0125.InsertDate = trim$(  x0125.InsertDate)
    x0125.InchargeInsert = trim$(  x0125.InchargeInsert)
    x0125.UpdateDate = trim$(  x0125.UpdateDate)
    x0125.InchargeUpdate = trim$(  x0125.InchargeUpdate)
    x0125.AttachID = trim$(  x0125.AttachID)
    x0125.RemarkOrder = trim$(  x0125.RemarkOrder)
    x0125.RemarkCustomer = trim$(  x0125.RemarkCustomer)
    x0125.Remark = trim$(  x0125.Remark)
     
    If trim$( x0125.SpecNo ) = "" Then x0125.SpecNo = Space(1) 
    If trim$( x0125.SpecNoSeq ) = "" Then x0125.SpecNoSeq = Space(1) 
    If trim$( x0125.ProcessSeq ) = "" Then x0125.ProcessSeq = Space(1) 
    If trim$( x0125.MatchingSeq ) = "" Then x0125.MatchingSeq = 0 
    If trim$( x0125.Status ) = "" Then x0125.Status = Space(1) 
    If trim$( x0125.seMainProcess ) = "" Then x0125.seMainProcess = Space(1) 
    If trim$( x0125.cdMainProcess ) = "" Then x0125.cdMainProcess = Space(1) 
    If trim$( x0125.seSubProcess ) = "" Then x0125.seSubProcess = Space(1) 
    If trim$( x0125.cdSubProcess ) = "" Then x0125.cdSubProcess = Space(1) 
    If trim$( x0125.Description ) = "" Then x0125.Description = Space(1) 
    If trim$( x0125.seGroupComponent ) = "" Then x0125.seGroupComponent = Space(1) 
    If trim$( x0125.cdGroupComponent ) = "" Then x0125.cdGroupComponent = Space(1) 
    If trim$( x0125.seComponent ) = "" Then x0125.seComponent = Space(1) 
    If trim$( x0125.cdComponent ) = "" Then x0125.cdComponent = Space(1) 
    If trim$( x0125.MaterialCode ) = "" Then x0125.MaterialCode = Space(1) 
    If trim$( x0125.MaterialDescription ) = "" Then x0125.MaterialDescription = Space(1) 
    If trim$( x0125.ColorCode ) = "" Then x0125.ColorCode = Space(1) 
    If trim$( x0125.MaterialSpec ) = "" Then x0125.MaterialSpec = Space(1) 
    If trim$( x0125.seUnitMaterial ) = "" Then x0125.seUnitMaterial = Space(1) 
    If trim$( x0125.cdUnitMaterial ) = "" Then x0125.cdUnitMaterial = Space(1) 
    If trim$( x0125.seMaterialStatus ) = "" Then x0125.seMaterialStatus = Space(1) 
    If trim$( x0125.cdMaterialStatus ) = "" Then x0125.cdMaterialStatus = Space(1) 
    If trim$( x0125.sePurchaseDept ) = "" Then x0125.sePurchaseDept = Space(1) 
    If trim$( x0125.cdPurchaseDept ) = "" Then x0125.cdPurchaseDept = Space(1) 
    If trim$( x0125.SupplierCode ) = "" Then x0125.SupplierCode = Space(1) 
    If trim$( x0125.MaterialPrice ) = "" Then x0125.MaterialPrice = 0 
    If trim$( x0125.Qty ) = "" Then x0125.Qty = 0 
    If trim$( x0125.Consumption ) = "" Then x0125.Consumption = 0 
    If trim$( x0125.Loss ) = "" Then x0125.Loss = 0 
    If trim$( x0125.GrossUsage ) = "" Then x0125.GrossUsage = 0 
    If trim$( x0125.AMTMaterial ) = "" Then x0125.AMTMaterial = 0 
    If trim$( x0125.InsertDate ) = "" Then x0125.InsertDate = Space(1) 
    If trim$( x0125.InchargeInsert ) = "" Then x0125.InchargeInsert = Space(1) 
    If trim$( x0125.UpdateDate ) = "" Then x0125.UpdateDate = Space(1) 
    If trim$( x0125.InchargeUpdate ) = "" Then x0125.InchargeUpdate = Space(1) 
    If trim$( x0125.AttachID ) = "" Then x0125.AttachID = Space(1) 
    If trim$( x0125.RemarkOrder ) = "" Then x0125.RemarkOrder = Space(1) 
    If trim$( x0125.RemarkCustomer ) = "" Then x0125.RemarkCustomer = Space(1) 
    If trim$( x0125.Remark ) = "" Then x0125.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K0125_MOVE(rs0125 As SqlClient.SqlDataReader)
Try

    call D0125_CLEAR()   

    If IsdbNull(rs0125!K0125_SpecNo) = False Then D0125.SpecNo = Trim$(rs0125!K0125_SpecNo)
    If IsdbNull(rs0125!K0125_SpecNoSeq) = False Then D0125.SpecNoSeq = Trim$(rs0125!K0125_SpecNoSeq)
    If IsdbNull(rs0125!K0125_ProcessSeq) = False Then D0125.ProcessSeq = Trim$(rs0125!K0125_ProcessSeq)
    If IsdbNull(rs0125!K0125_MatchingSeq) = False Then D0125.MatchingSeq = Trim$(rs0125!K0125_MatchingSeq)
    If IsdbNull(rs0125!K0125_Status) = False Then D0125.Status = Trim$(rs0125!K0125_Status)
    If IsdbNull(rs0125!K0125_seMainProcess) = False Then D0125.seMainProcess = Trim$(rs0125!K0125_seMainProcess)
    If IsdbNull(rs0125!K0125_cdMainProcess) = False Then D0125.cdMainProcess = Trim$(rs0125!K0125_cdMainProcess)
    If IsdbNull(rs0125!K0125_seSubProcess) = False Then D0125.seSubProcess = Trim$(rs0125!K0125_seSubProcess)
    If IsdbNull(rs0125!K0125_cdSubProcess) = False Then D0125.cdSubProcess = Trim$(rs0125!K0125_cdSubProcess)
    If IsdbNull(rs0125!K0125_Description) = False Then D0125.Description = Trim$(rs0125!K0125_Description)
    If IsdbNull(rs0125!K0125_seGroupComponent) = False Then D0125.seGroupComponent = Trim$(rs0125!K0125_seGroupComponent)
    If IsdbNull(rs0125!K0125_cdGroupComponent) = False Then D0125.cdGroupComponent = Trim$(rs0125!K0125_cdGroupComponent)
    If IsdbNull(rs0125!K0125_seComponent) = False Then D0125.seComponent = Trim$(rs0125!K0125_seComponent)
    If IsdbNull(rs0125!K0125_cdComponent) = False Then D0125.cdComponent = Trim$(rs0125!K0125_cdComponent)
    If IsdbNull(rs0125!K0125_MaterialCode) = False Then D0125.MaterialCode = Trim$(rs0125!K0125_MaterialCode)
    If IsdbNull(rs0125!K0125_MaterialDescription) = False Then D0125.MaterialDescription = Trim$(rs0125!K0125_MaterialDescription)
    If IsdbNull(rs0125!K0125_ColorCode) = False Then D0125.ColorCode = Trim$(rs0125!K0125_ColorCode)
    If IsdbNull(rs0125!K0125_MaterialSpec) = False Then D0125.MaterialSpec = Trim$(rs0125!K0125_MaterialSpec)
    If IsdbNull(rs0125!K0125_seUnitMaterial) = False Then D0125.seUnitMaterial = Trim$(rs0125!K0125_seUnitMaterial)
    If IsdbNull(rs0125!K0125_cdUnitMaterial) = False Then D0125.cdUnitMaterial = Trim$(rs0125!K0125_cdUnitMaterial)
    If IsdbNull(rs0125!K0125_seMaterialStatus) = False Then D0125.seMaterialStatus = Trim$(rs0125!K0125_seMaterialStatus)
    If IsdbNull(rs0125!K0125_cdMaterialStatus) = False Then D0125.cdMaterialStatus = Trim$(rs0125!K0125_cdMaterialStatus)
    If IsdbNull(rs0125!K0125_sePurchaseDept) = False Then D0125.sePurchaseDept = Trim$(rs0125!K0125_sePurchaseDept)
    If IsdbNull(rs0125!K0125_cdPurchaseDept) = False Then D0125.cdPurchaseDept = Trim$(rs0125!K0125_cdPurchaseDept)
    If IsdbNull(rs0125!K0125_SupplierCode) = False Then D0125.SupplierCode = Trim$(rs0125!K0125_SupplierCode)
    If IsdbNull(rs0125!K0125_MaterialPrice) = False Then D0125.MaterialPrice = Trim$(rs0125!K0125_MaterialPrice)
    If IsdbNull(rs0125!K0125_Qty) = False Then D0125.Qty = Trim$(rs0125!K0125_Qty)
    If IsdbNull(rs0125!K0125_Consumption) = False Then D0125.Consumption = Trim$(rs0125!K0125_Consumption)
    If IsdbNull(rs0125!K0125_Loss) = False Then D0125.Loss = Trim$(rs0125!K0125_Loss)
    If IsdbNull(rs0125!K0125_GrossUsage) = False Then D0125.GrossUsage = Trim$(rs0125!K0125_GrossUsage)
    If IsdbNull(rs0125!K0125_AMTMaterial) = False Then D0125.AMTMaterial = Trim$(rs0125!K0125_AMTMaterial)
    If IsdbNull(rs0125!K0125_InsertDate) = False Then D0125.InsertDate = Trim$(rs0125!K0125_InsertDate)
    If IsdbNull(rs0125!K0125_InchargeInsert) = False Then D0125.InchargeInsert = Trim$(rs0125!K0125_InchargeInsert)
    If IsdbNull(rs0125!K0125_UpdateDate) = False Then D0125.UpdateDate = Trim$(rs0125!K0125_UpdateDate)
    If IsdbNull(rs0125!K0125_InchargeUpdate) = False Then D0125.InchargeUpdate = Trim$(rs0125!K0125_InchargeUpdate)
    If IsdbNull(rs0125!K0125_AttachID) = False Then D0125.AttachID = Trim$(rs0125!K0125_AttachID)
    If IsdbNull(rs0125!K0125_RemarkOrder) = False Then D0125.RemarkOrder = Trim$(rs0125!K0125_RemarkOrder)
    If IsdbNull(rs0125!K0125_RemarkCustomer) = False Then D0125.RemarkCustomer = Trim$(rs0125!K0125_RemarkCustomer)
    If IsdbNull(rs0125!K0125_Remark) = False Then D0125.Remark = Trim$(rs0125!K0125_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K0125_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K0125_MOVE(rs0125 As DataRow)
Try

    call D0125_CLEAR()   

    If IsdbNull(rs0125!K0125_SpecNo) = False Then D0125.SpecNo = Trim$(rs0125!K0125_SpecNo)
    If IsdbNull(rs0125!K0125_SpecNoSeq) = False Then D0125.SpecNoSeq = Trim$(rs0125!K0125_SpecNoSeq)
    If IsdbNull(rs0125!K0125_ProcessSeq) = False Then D0125.ProcessSeq = Trim$(rs0125!K0125_ProcessSeq)
    If IsdbNull(rs0125!K0125_MatchingSeq) = False Then D0125.MatchingSeq = Trim$(rs0125!K0125_MatchingSeq)
    If IsdbNull(rs0125!K0125_Status) = False Then D0125.Status = Trim$(rs0125!K0125_Status)
    If IsdbNull(rs0125!K0125_seMainProcess) = False Then D0125.seMainProcess = Trim$(rs0125!K0125_seMainProcess)
    If IsdbNull(rs0125!K0125_cdMainProcess) = False Then D0125.cdMainProcess = Trim$(rs0125!K0125_cdMainProcess)
    If IsdbNull(rs0125!K0125_seSubProcess) = False Then D0125.seSubProcess = Trim$(rs0125!K0125_seSubProcess)
    If IsdbNull(rs0125!K0125_cdSubProcess) = False Then D0125.cdSubProcess = Trim$(rs0125!K0125_cdSubProcess)
    If IsdbNull(rs0125!K0125_Description) = False Then D0125.Description = Trim$(rs0125!K0125_Description)
    If IsdbNull(rs0125!K0125_seGroupComponent) = False Then D0125.seGroupComponent = Trim$(rs0125!K0125_seGroupComponent)
    If IsdbNull(rs0125!K0125_cdGroupComponent) = False Then D0125.cdGroupComponent = Trim$(rs0125!K0125_cdGroupComponent)
    If IsdbNull(rs0125!K0125_seComponent) = False Then D0125.seComponent = Trim$(rs0125!K0125_seComponent)
    If IsdbNull(rs0125!K0125_cdComponent) = False Then D0125.cdComponent = Trim$(rs0125!K0125_cdComponent)
    If IsdbNull(rs0125!K0125_MaterialCode) = False Then D0125.MaterialCode = Trim$(rs0125!K0125_MaterialCode)
    If IsdbNull(rs0125!K0125_MaterialDescription) = False Then D0125.MaterialDescription = Trim$(rs0125!K0125_MaterialDescription)
    If IsdbNull(rs0125!K0125_ColorCode) = False Then D0125.ColorCode = Trim$(rs0125!K0125_ColorCode)
    If IsdbNull(rs0125!K0125_MaterialSpec) = False Then D0125.MaterialSpec = Trim$(rs0125!K0125_MaterialSpec)
    If IsdbNull(rs0125!K0125_seUnitMaterial) = False Then D0125.seUnitMaterial = Trim$(rs0125!K0125_seUnitMaterial)
    If IsdbNull(rs0125!K0125_cdUnitMaterial) = False Then D0125.cdUnitMaterial = Trim$(rs0125!K0125_cdUnitMaterial)
    If IsdbNull(rs0125!K0125_seMaterialStatus) = False Then D0125.seMaterialStatus = Trim$(rs0125!K0125_seMaterialStatus)
    If IsdbNull(rs0125!K0125_cdMaterialStatus) = False Then D0125.cdMaterialStatus = Trim$(rs0125!K0125_cdMaterialStatus)
    If IsdbNull(rs0125!K0125_sePurchaseDept) = False Then D0125.sePurchaseDept = Trim$(rs0125!K0125_sePurchaseDept)
    If IsdbNull(rs0125!K0125_cdPurchaseDept) = False Then D0125.cdPurchaseDept = Trim$(rs0125!K0125_cdPurchaseDept)
    If IsdbNull(rs0125!K0125_SupplierCode) = False Then D0125.SupplierCode = Trim$(rs0125!K0125_SupplierCode)
    If IsdbNull(rs0125!K0125_MaterialPrice) = False Then D0125.MaterialPrice = Trim$(rs0125!K0125_MaterialPrice)
    If IsdbNull(rs0125!K0125_Qty) = False Then D0125.Qty = Trim$(rs0125!K0125_Qty)
    If IsdbNull(rs0125!K0125_Consumption) = False Then D0125.Consumption = Trim$(rs0125!K0125_Consumption)
    If IsdbNull(rs0125!K0125_Loss) = False Then D0125.Loss = Trim$(rs0125!K0125_Loss)
    If IsdbNull(rs0125!K0125_GrossUsage) = False Then D0125.GrossUsage = Trim$(rs0125!K0125_GrossUsage)
    If IsdbNull(rs0125!K0125_AMTMaterial) = False Then D0125.AMTMaterial = Trim$(rs0125!K0125_AMTMaterial)
    If IsdbNull(rs0125!K0125_InsertDate) = False Then D0125.InsertDate = Trim$(rs0125!K0125_InsertDate)
    If IsdbNull(rs0125!K0125_InchargeInsert) = False Then D0125.InchargeInsert = Trim$(rs0125!K0125_InchargeInsert)
    If IsdbNull(rs0125!K0125_UpdateDate) = False Then D0125.UpdateDate = Trim$(rs0125!K0125_UpdateDate)
    If IsdbNull(rs0125!K0125_InchargeUpdate) = False Then D0125.InchargeUpdate = Trim$(rs0125!K0125_InchargeUpdate)
    If IsdbNull(rs0125!K0125_AttachID) = False Then D0125.AttachID = Trim$(rs0125!K0125_AttachID)
    If IsdbNull(rs0125!K0125_RemarkOrder) = False Then D0125.RemarkOrder = Trim$(rs0125!K0125_RemarkOrder)
    If IsdbNull(rs0125!K0125_RemarkCustomer) = False Then D0125.RemarkCustomer = Trim$(rs0125!K0125_RemarkCustomer)
    If IsdbNull(rs0125!K0125_Remark) = False Then D0125.Remark = Trim$(rs0125!K0125_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K0125_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K0125_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z0125 As T0125_AREA, SPECNO AS String, SPECNOSEQ AS String, PROCESSSEQ AS String, MATCHINGSEQ AS Double) as Boolean

K0125_MOVE = False

Try
    If READ_PFK0125(SPECNO, SPECNOSEQ, PROCESSSEQ, MATCHINGSEQ) = True Then
                z0125 = D0125
		K0125_MOVE = True
		else
	z0125 = nothing
     End If

     If  getColumIndex(spr,"SpecNo") > -1 then z0125.SpecNo = getDataM(spr, getColumIndex(spr,"SpecNo"), xRow)
     If  getColumIndex(spr,"SpecNoSeq") > -1 then z0125.SpecNoSeq = getDataM(spr, getColumIndex(spr,"SpecNoSeq"), xRow)
     If  getColumIndex(spr,"ProcessSeq") > -1 then z0125.ProcessSeq = getDataM(spr, getColumIndex(spr,"ProcessSeq"), xRow)
     If  getColumIndex(spr,"MatchingSeq") > -1 then z0125.MatchingSeq = getDataM(spr, getColumIndex(spr,"MatchingSeq"), xRow)
     If  getColumIndex(spr,"Status") > -1 then z0125.Status = getDataM(spr, getColumIndex(spr,"Status"), xRow)
     If  getColumIndex(spr,"seMainProcess") > -1 then z0125.seMainProcess = getDataM(spr, getColumIndex(spr,"seMainProcess"), xRow)
     If  getColumIndex(spr,"cdMainProcess") > -1 then z0125.cdMainProcess = getDataM(spr, getColumIndex(spr,"cdMainProcess"), xRow)
     If  getColumIndex(spr,"seSubProcess") > -1 then z0125.seSubProcess = getDataM(spr, getColumIndex(spr,"seSubProcess"), xRow)
     If  getColumIndex(spr,"cdSubProcess") > -1 then z0125.cdSubProcess = getDataM(spr, getColumIndex(spr,"cdSubProcess"), xRow)
     If  getColumIndex(spr,"Description") > -1 then z0125.Description = getDataM(spr, getColumIndex(spr,"Description"), xRow)
     If  getColumIndex(spr,"seGroupComponent") > -1 then z0125.seGroupComponent = getDataM(spr, getColumIndex(spr,"seGroupComponent"), xRow)
     If  getColumIndex(spr,"cdGroupComponent") > -1 then z0125.cdGroupComponent = getDataM(spr, getColumIndex(spr,"cdGroupComponent"), xRow)
     If  getColumIndex(spr,"seComponent") > -1 then z0125.seComponent = getDataM(spr, getColumIndex(spr,"seComponent"), xRow)
     If  getColumIndex(spr,"cdComponent") > -1 then z0125.cdComponent = getDataM(spr, getColumIndex(spr,"cdComponent"), xRow)
     If  getColumIndex(spr,"MaterialCode") > -1 then z0125.MaterialCode = getDataM(spr, getColumIndex(spr,"MaterialCode"), xRow)
     If  getColumIndex(spr,"MaterialDescription") > -1 then z0125.MaterialDescription = getDataM(spr, getColumIndex(spr,"MaterialDescription"), xRow)
     If  getColumIndex(spr,"ColorCode") > -1 then z0125.ColorCode = getDataM(spr, getColumIndex(spr,"ColorCode"), xRow)
     If  getColumIndex(spr,"MaterialSpec") > -1 then z0125.MaterialSpec = getDataM(spr, getColumIndex(spr,"MaterialSpec"), xRow)
     If  getColumIndex(spr,"seUnitMaterial") > -1 then z0125.seUnitMaterial = getDataM(spr, getColumIndex(spr,"seUnitMaterial"), xRow)
     If  getColumIndex(spr,"cdUnitMaterial") > -1 then z0125.cdUnitMaterial = getDataM(spr, getColumIndex(spr,"cdUnitMaterial"), xRow)
     If  getColumIndex(spr,"seMaterialStatus") > -1 then z0125.seMaterialStatus = getDataM(spr, getColumIndex(spr,"seMaterialStatus"), xRow)
     If  getColumIndex(spr,"cdMaterialStatus") > -1 then z0125.cdMaterialStatus = getDataM(spr, getColumIndex(spr,"cdMaterialStatus"), xRow)
     If  getColumIndex(spr,"sePurchaseDept") > -1 then z0125.sePurchaseDept = getDataM(spr, getColumIndex(spr,"sePurchaseDept"), xRow)
     If  getColumIndex(spr,"cdPurchaseDept") > -1 then z0125.cdPurchaseDept = getDataM(spr, getColumIndex(spr,"cdPurchaseDept"), xRow)
     If  getColumIndex(spr,"SupplierCode") > -1 then z0125.SupplierCode = getDataM(spr, getColumIndex(spr,"SupplierCode"), xRow)
     If  getColumIndex(spr,"MaterialPrice") > -1 then z0125.MaterialPrice = getDataM(spr, getColumIndex(spr,"MaterialPrice"), xRow)
     If  getColumIndex(spr,"Qty") > -1 then z0125.Qty = getDataM(spr, getColumIndex(spr,"Qty"), xRow)
     If  getColumIndex(spr,"Consumption") > -1 then z0125.Consumption = getDataM(spr, getColumIndex(spr,"Consumption"), xRow)
     If  getColumIndex(spr,"Loss") > -1 then z0125.Loss = getDataM(spr, getColumIndex(spr,"Loss"), xRow)
     If  getColumIndex(spr,"GrossUsage") > -1 then z0125.GrossUsage = getDataM(spr, getColumIndex(spr,"GrossUsage"), xRow)
     If  getColumIndex(spr,"AMTMaterial") > -1 then z0125.AMTMaterial = getDataM(spr, getColumIndex(spr,"AMTMaterial"), xRow)
     If  getColumIndex(spr,"InsertDate") > -1 then z0125.InsertDate = getDataM(spr, getColumIndex(spr,"InsertDate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z0125.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"UpdateDate") > -1 then z0125.UpdateDate = getDataM(spr, getColumIndex(spr,"UpdateDate"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z0125.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"AttachID") > -1 then z0125.AttachID = getDataM(spr, getColumIndex(spr,"AttachID"), xRow)
     If  getColumIndex(spr,"RemarkOrder") > -1 then z0125.RemarkOrder = getDataM(spr, getColumIndex(spr,"RemarkOrder"), xRow)
     If  getColumIndex(spr,"RemarkCustomer") > -1 then z0125.RemarkCustomer = getDataM(spr, getColumIndex(spr,"RemarkCustomer"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z0125.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K0125_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K0125_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z0125 As T0125_AREA,CheckClear as Boolean,SPECNO AS String, SPECNOSEQ AS String, PROCESSSEQ AS String, MATCHINGSEQ AS Double) as Boolean

K0125_MOVE = False

Try
    If READ_PFK0125(SPECNO, SPECNOSEQ, PROCESSSEQ, MATCHINGSEQ) = True Then
                z0125 = D0125
		K0125_MOVE = True
		else
	If CheckClear  = True then z0125 = nothing
     End If

     If  getColumIndex(spr,"SpecNo") > -1 then z0125.SpecNo = getDataM(spr, getColumIndex(spr,"SpecNo"), xRow)
     If  getColumIndex(spr,"SpecNoSeq") > -1 then z0125.SpecNoSeq = getDataM(spr, getColumIndex(spr,"SpecNoSeq"), xRow)
     If  getColumIndex(spr,"ProcessSeq") > -1 then z0125.ProcessSeq = getDataM(spr, getColumIndex(spr,"ProcessSeq"), xRow)
     If  getColumIndex(spr,"MatchingSeq") > -1 then z0125.MatchingSeq = getDataM(spr, getColumIndex(spr,"MatchingSeq"), xRow)
     If  getColumIndex(spr,"Status") > -1 then z0125.Status = getDataM(spr, getColumIndex(spr,"Status"), xRow)
     If  getColumIndex(spr,"seMainProcess") > -1 then z0125.seMainProcess = getDataM(spr, getColumIndex(spr,"seMainProcess"), xRow)
     If  getColumIndex(spr,"cdMainProcess") > -1 then z0125.cdMainProcess = getDataM(spr, getColumIndex(spr,"cdMainProcess"), xRow)
     If  getColumIndex(spr,"seSubProcess") > -1 then z0125.seSubProcess = getDataM(spr, getColumIndex(spr,"seSubProcess"), xRow)
     If  getColumIndex(spr,"cdSubProcess") > -1 then z0125.cdSubProcess = getDataM(spr, getColumIndex(spr,"cdSubProcess"), xRow)
     If  getColumIndex(spr,"Description") > -1 then z0125.Description = getDataM(spr, getColumIndex(spr,"Description"), xRow)
     If  getColumIndex(spr,"seGroupComponent") > -1 then z0125.seGroupComponent = getDataM(spr, getColumIndex(spr,"seGroupComponent"), xRow)
     If  getColumIndex(spr,"cdGroupComponent") > -1 then z0125.cdGroupComponent = getDataM(spr, getColumIndex(spr,"cdGroupComponent"), xRow)
     If  getColumIndex(spr,"seComponent") > -1 then z0125.seComponent = getDataM(spr, getColumIndex(spr,"seComponent"), xRow)
     If  getColumIndex(spr,"cdComponent") > -1 then z0125.cdComponent = getDataM(spr, getColumIndex(spr,"cdComponent"), xRow)
     If  getColumIndex(spr,"MaterialCode") > -1 then z0125.MaterialCode = getDataM(spr, getColumIndex(spr,"MaterialCode"), xRow)
     If  getColumIndex(spr,"MaterialDescription") > -1 then z0125.MaterialDescription = getDataM(spr, getColumIndex(spr,"MaterialDescription"), xRow)
     If  getColumIndex(spr,"ColorCode") > -1 then z0125.ColorCode = getDataM(spr, getColumIndex(spr,"ColorCode"), xRow)
     If  getColumIndex(spr,"MaterialSpec") > -1 then z0125.MaterialSpec = getDataM(spr, getColumIndex(spr,"MaterialSpec"), xRow)
     If  getColumIndex(spr,"seUnitMaterial") > -1 then z0125.seUnitMaterial = getDataM(spr, getColumIndex(spr,"seUnitMaterial"), xRow)
     If  getColumIndex(spr,"cdUnitMaterial") > -1 then z0125.cdUnitMaterial = getDataM(spr, getColumIndex(spr,"cdUnitMaterial"), xRow)
     If  getColumIndex(spr,"seMaterialStatus") > -1 then z0125.seMaterialStatus = getDataM(spr, getColumIndex(spr,"seMaterialStatus"), xRow)
     If  getColumIndex(spr,"cdMaterialStatus") > -1 then z0125.cdMaterialStatus = getDataM(spr, getColumIndex(spr,"cdMaterialStatus"), xRow)
     If  getColumIndex(spr,"sePurchaseDept") > -1 then z0125.sePurchaseDept = getDataM(spr, getColumIndex(spr,"sePurchaseDept"), xRow)
     If  getColumIndex(spr,"cdPurchaseDept") > -1 then z0125.cdPurchaseDept = getDataM(spr, getColumIndex(spr,"cdPurchaseDept"), xRow)
     If  getColumIndex(spr,"SupplierCode") > -1 then z0125.SupplierCode = getDataM(spr, getColumIndex(spr,"SupplierCode"), xRow)
     If  getColumIndex(spr,"MaterialPrice") > -1 then z0125.MaterialPrice = getDataM(spr, getColumIndex(spr,"MaterialPrice"), xRow)
     If  getColumIndex(spr,"Qty") > -1 then z0125.Qty = getDataM(spr, getColumIndex(spr,"Qty"), xRow)
     If  getColumIndex(spr,"Consumption") > -1 then z0125.Consumption = getDataM(spr, getColumIndex(spr,"Consumption"), xRow)
     If  getColumIndex(spr,"Loss") > -1 then z0125.Loss = getDataM(spr, getColumIndex(spr,"Loss"), xRow)
     If  getColumIndex(spr,"GrossUsage") > -1 then z0125.GrossUsage = getDataM(spr, getColumIndex(spr,"GrossUsage"), xRow)
     If  getColumIndex(spr,"AMTMaterial") > -1 then z0125.AMTMaterial = getDataM(spr, getColumIndex(spr,"AMTMaterial"), xRow)
     If  getColumIndex(spr,"InsertDate") > -1 then z0125.InsertDate = getDataM(spr, getColumIndex(spr,"InsertDate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z0125.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"UpdateDate") > -1 then z0125.UpdateDate = getDataM(spr, getColumIndex(spr,"UpdateDate"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z0125.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"AttachID") > -1 then z0125.AttachID = getDataM(spr, getColumIndex(spr,"AttachID"), xRow)
     If  getColumIndex(spr,"RemarkOrder") > -1 then z0125.RemarkOrder = getDataM(spr, getColumIndex(spr,"RemarkOrder"), xRow)
     If  getColumIndex(spr,"RemarkCustomer") > -1 then z0125.RemarkCustomer = getDataM(spr, getColumIndex(spr,"RemarkCustomer"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z0125.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K0125_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K0125_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z0125 As T0125_AREA, Job as String, SPECNO AS String, SPECNOSEQ AS String, PROCESSSEQ AS String, MATCHINGSEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K0125_MOVE = False

Try
    If READ_PFK0125(SPECNO, SPECNOSEQ, PROCESSSEQ, MATCHINGSEQ) = True Then
                z0125 = D0125
		K0125_MOVE = True
		else
	z0125 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK0125")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "SPECNO":z0125.SpecNo = Children(i).Code
   Case "SPECNOSEQ":z0125.SpecNoSeq = Children(i).Code
   Case "PROCESSSEQ":z0125.ProcessSeq = Children(i).Code
   Case "MATCHINGSEQ":z0125.MatchingSeq = Children(i).Code
   Case "STATUS":z0125.Status = Children(i).Code
   Case "SEMAINPROCESS":z0125.seMainProcess = Children(i).Code
   Case "CDMAINPROCESS":z0125.cdMainProcess = Children(i).Code
   Case "SESUBPROCESS":z0125.seSubProcess = Children(i).Code
   Case "CDSUBPROCESS":z0125.cdSubProcess = Children(i).Code
   Case "DESCRIPTION":z0125.Description = Children(i).Code
   Case "SEGROUPCOMPONENT":z0125.seGroupComponent = Children(i).Code
   Case "CDGROUPCOMPONENT":z0125.cdGroupComponent = Children(i).Code
   Case "SECOMPONENT":z0125.seComponent = Children(i).Code
   Case "CDCOMPONENT":z0125.cdComponent = Children(i).Code
   Case "MATERIALCODE":z0125.MaterialCode = Children(i).Code
   Case "MATERIALDESCRIPTION":z0125.MaterialDescription = Children(i).Code
   Case "COLORCODE":z0125.ColorCode = Children(i).Code
   Case "MATERIALSPEC":z0125.MaterialSpec = Children(i).Code
   Case "SEUNITMATERIAL":z0125.seUnitMaterial = Children(i).Code
   Case "CDUNITMATERIAL":z0125.cdUnitMaterial = Children(i).Code
   Case "SEMATERIALSTATUS":z0125.seMaterialStatus = Children(i).Code
   Case "CDMATERIALSTATUS":z0125.cdMaterialStatus = Children(i).Code
   Case "SEPURCHASEDEPT":z0125.sePurchaseDept = Children(i).Code
   Case "CDPURCHASEDEPT":z0125.cdPurchaseDept = Children(i).Code
   Case "SUPPLIERCODE":z0125.SupplierCode = Children(i).Code
   Case "MATERIALPRICE":z0125.MaterialPrice = Children(i).Code
   Case "QTY":z0125.Qty = Children(i).Code
   Case "CONSUMPTION":z0125.Consumption = Children(i).Code
   Case "LOSS":z0125.Loss = Children(i).Code
   Case "GROSSUSAGE":z0125.GrossUsage = Children(i).Code
   Case "AMTMATERIAL":z0125.AMTMaterial = Children(i).Code
   Case "INSERTDATE":z0125.InsertDate = Children(i).Code
   Case "INCHARGEINSERT":z0125.InchargeInsert = Children(i).Code
   Case "UPDATEDATE":z0125.UpdateDate = Children(i).Code
   Case "INCHARGEUPDATE":z0125.InchargeUpdate = Children(i).Code
   Case "ATTACHID":z0125.AttachID = Children(i).Code
   Case "REMARKORDER":z0125.RemarkOrder = Children(i).Code
   Case "REMARKCUSTOMER":z0125.RemarkCustomer = Children(i).Code
   Case "REMARK":z0125.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "SPECNO":z0125.SpecNo = Children(i).Data
   Case "SPECNOSEQ":z0125.SpecNoSeq = Children(i).Data
   Case "PROCESSSEQ":z0125.ProcessSeq = Children(i).Data
   Case "MATCHINGSEQ":z0125.MatchingSeq = Children(i).Data
   Case "STATUS":z0125.Status = Children(i).Data
   Case "SEMAINPROCESS":z0125.seMainProcess = Children(i).Data
   Case "CDMAINPROCESS":z0125.cdMainProcess = Children(i).Data
   Case "SESUBPROCESS":z0125.seSubProcess = Children(i).Data
   Case "CDSUBPROCESS":z0125.cdSubProcess = Children(i).Data
   Case "DESCRIPTION":z0125.Description = Children(i).Data
   Case "SEGROUPCOMPONENT":z0125.seGroupComponent = Children(i).Data
   Case "CDGROUPCOMPONENT":z0125.cdGroupComponent = Children(i).Data
   Case "SECOMPONENT":z0125.seComponent = Children(i).Data
   Case "CDCOMPONENT":z0125.cdComponent = Children(i).Data
   Case "MATERIALCODE":z0125.MaterialCode = Children(i).Data
   Case "MATERIALDESCRIPTION":z0125.MaterialDescription = Children(i).Data
   Case "COLORCODE":z0125.ColorCode = Children(i).Data
   Case "MATERIALSPEC":z0125.MaterialSpec = Children(i).Data
   Case "SEUNITMATERIAL":z0125.seUnitMaterial = Children(i).Data
   Case "CDUNITMATERIAL":z0125.cdUnitMaterial = Children(i).Data
   Case "SEMATERIALSTATUS":z0125.seMaterialStatus = Children(i).Data
   Case "CDMATERIALSTATUS":z0125.cdMaterialStatus = Children(i).Data
   Case "SEPURCHASEDEPT":z0125.sePurchaseDept = Children(i).Data
   Case "CDPURCHASEDEPT":z0125.cdPurchaseDept = Children(i).Data
   Case "SUPPLIERCODE":z0125.SupplierCode = Children(i).Data
   Case "MATERIALPRICE":z0125.MaterialPrice = Children(i).Data
   Case "QTY":z0125.Qty = Children(i).Data
   Case "CONSUMPTION":z0125.Consumption = Children(i).Data
   Case "LOSS":z0125.Loss = Children(i).Data
   Case "GROSSUSAGE":z0125.GrossUsage = Children(i).Data
   Case "AMTMATERIAL":z0125.AMTMaterial = Children(i).Data
   Case "INSERTDATE":z0125.InsertDate = Children(i).Data
   Case "INCHARGEINSERT":z0125.InchargeInsert = Children(i).Data
   Case "UPDATEDATE":z0125.UpdateDate = Children(i).Data
   Case "INCHARGEUPDATE":z0125.InchargeUpdate = Children(i).Data
   Case "ATTACHID":z0125.AttachID = Children(i).Data
   Case "REMARKORDER":z0125.RemarkOrder = Children(i).Data
   Case "REMARKCUSTOMER":z0125.RemarkCustomer = Children(i).Data
   Case "REMARK":z0125.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K0125_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K0125_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z0125 As T0125_AREA, Job as String, CheckClear as Boolean, SPECNO AS String, SPECNOSEQ AS String, PROCESSSEQ AS String, MATCHINGSEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K0125_MOVE = False

Try
    If READ_PFK0125(SPECNO, SPECNOSEQ, PROCESSSEQ, MATCHINGSEQ) = True Then
                z0125 = D0125
		K0125_MOVE = True
		else
	If CheckClear  = True then z0125 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK0125")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "SPECNO":z0125.SpecNo = Children(i).Code
   Case "SPECNOSEQ":z0125.SpecNoSeq = Children(i).Code
   Case "PROCESSSEQ":z0125.ProcessSeq = Children(i).Code
   Case "MATCHINGSEQ":z0125.MatchingSeq = Children(i).Code
   Case "STATUS":z0125.Status = Children(i).Code
   Case "SEMAINPROCESS":z0125.seMainProcess = Children(i).Code
   Case "CDMAINPROCESS":z0125.cdMainProcess = Children(i).Code
   Case "SESUBPROCESS":z0125.seSubProcess = Children(i).Code
   Case "CDSUBPROCESS":z0125.cdSubProcess = Children(i).Code
   Case "DESCRIPTION":z0125.Description = Children(i).Code
   Case "SEGROUPCOMPONENT":z0125.seGroupComponent = Children(i).Code
   Case "CDGROUPCOMPONENT":z0125.cdGroupComponent = Children(i).Code
   Case "SECOMPONENT":z0125.seComponent = Children(i).Code
   Case "CDCOMPONENT":z0125.cdComponent = Children(i).Code
   Case "MATERIALCODE":z0125.MaterialCode = Children(i).Code
   Case "MATERIALDESCRIPTION":z0125.MaterialDescription = Children(i).Code
   Case "COLORCODE":z0125.ColorCode = Children(i).Code
   Case "MATERIALSPEC":z0125.MaterialSpec = Children(i).Code
   Case "SEUNITMATERIAL":z0125.seUnitMaterial = Children(i).Code
   Case "CDUNITMATERIAL":z0125.cdUnitMaterial = Children(i).Code
   Case "SEMATERIALSTATUS":z0125.seMaterialStatus = Children(i).Code
   Case "CDMATERIALSTATUS":z0125.cdMaterialStatus = Children(i).Code
   Case "SEPURCHASEDEPT":z0125.sePurchaseDept = Children(i).Code
   Case "CDPURCHASEDEPT":z0125.cdPurchaseDept = Children(i).Code
   Case "SUPPLIERCODE":z0125.SupplierCode = Children(i).Code
   Case "MATERIALPRICE":z0125.MaterialPrice = Children(i).Code
   Case "QTY":z0125.Qty = Children(i).Code
   Case "CONSUMPTION":z0125.Consumption = Children(i).Code
   Case "LOSS":z0125.Loss = Children(i).Code
   Case "GROSSUSAGE":z0125.GrossUsage = Children(i).Code
   Case "AMTMATERIAL":z0125.AMTMaterial = Children(i).Code
   Case "INSERTDATE":z0125.InsertDate = Children(i).Code
   Case "INCHARGEINSERT":z0125.InchargeInsert = Children(i).Code
   Case "UPDATEDATE":z0125.UpdateDate = Children(i).Code
   Case "INCHARGEUPDATE":z0125.InchargeUpdate = Children(i).Code
   Case "ATTACHID":z0125.AttachID = Children(i).Code
   Case "REMARKORDER":z0125.RemarkOrder = Children(i).Code
   Case "REMARKCUSTOMER":z0125.RemarkCustomer = Children(i).Code
   Case "REMARK":z0125.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "SPECNO":z0125.SpecNo = Children(i).Data
   Case "SPECNOSEQ":z0125.SpecNoSeq = Children(i).Data
   Case "PROCESSSEQ":z0125.ProcessSeq = Children(i).Data
   Case "MATCHINGSEQ":z0125.MatchingSeq = Children(i).Data
   Case "STATUS":z0125.Status = Children(i).Data
   Case "SEMAINPROCESS":z0125.seMainProcess = Children(i).Data
   Case "CDMAINPROCESS":z0125.cdMainProcess = Children(i).Data
   Case "SESUBPROCESS":z0125.seSubProcess = Children(i).Data
   Case "CDSUBPROCESS":z0125.cdSubProcess = Children(i).Data
   Case "DESCRIPTION":z0125.Description = Children(i).Data
   Case "SEGROUPCOMPONENT":z0125.seGroupComponent = Children(i).Data
   Case "CDGROUPCOMPONENT":z0125.cdGroupComponent = Children(i).Data
   Case "SECOMPONENT":z0125.seComponent = Children(i).Data
   Case "CDCOMPONENT":z0125.cdComponent = Children(i).Data
   Case "MATERIALCODE":z0125.MaterialCode = Children(i).Data
   Case "MATERIALDESCRIPTION":z0125.MaterialDescription = Children(i).Data
   Case "COLORCODE":z0125.ColorCode = Children(i).Data
   Case "MATERIALSPEC":z0125.MaterialSpec = Children(i).Data
   Case "SEUNITMATERIAL":z0125.seUnitMaterial = Children(i).Data
   Case "CDUNITMATERIAL":z0125.cdUnitMaterial = Children(i).Data
   Case "SEMATERIALSTATUS":z0125.seMaterialStatus = Children(i).Data
   Case "CDMATERIALSTATUS":z0125.cdMaterialStatus = Children(i).Data
   Case "SEPURCHASEDEPT":z0125.sePurchaseDept = Children(i).Data
   Case "CDPURCHASEDEPT":z0125.cdPurchaseDept = Children(i).Data
   Case "SUPPLIERCODE":z0125.SupplierCode = Children(i).Data
   Case "MATERIALPRICE":z0125.MaterialPrice = Children(i).Data
   Case "QTY":z0125.Qty = Children(i).Data
   Case "CONSUMPTION":z0125.Consumption = Children(i).Data
   Case "LOSS":z0125.Loss = Children(i).Data
   Case "GROSSUSAGE":z0125.GrossUsage = Children(i).Data
   Case "AMTMATERIAL":z0125.AMTMaterial = Children(i).Data
   Case "INSERTDATE":z0125.InsertDate = Children(i).Data
   Case "INCHARGEINSERT":z0125.InchargeInsert = Children(i).Data
   Case "UPDATEDATE":z0125.UpdateDate = Children(i).Data
   Case "INCHARGEUPDATE":z0125.InchargeUpdate = Children(i).Data
   Case "ATTACHID":z0125.AttachID = Children(i).Data
   Case "REMARKORDER":z0125.RemarkOrder = Children(i).Data
   Case "REMARKCUSTOMER":z0125.RemarkCustomer = Children(i).Data
   Case "REMARK":z0125.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K0125_MOVE",vbCritical)
End Try
End Function 
    
End Module 
