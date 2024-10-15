'=========================================================================================================================================================
'   TABLE : (PFK3451)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K3451

Structure T3451_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	FactOrderNo	 AS String	'			char(9)		*
Public 	PurchaseInvoice1	 AS String	'			nvarchar(50)
Public 	PurchaseInvoice2	 AS String	'			nvarchar(50)
Public 	seSeason	 AS String	'			char(3)
Public 	cdSeason	 AS String	'			char(3)
Public 	CustomerCode	 AS String	'			char(6)
Public 	DateAccept	 AS String	'			char(8)
Public 	CheckInPurchasingOrder	 AS String	'			char(1)
Public 	CheckOutPurchasingOrder	 AS String	'			char(1)
Public 	CheckProcessType	 AS String	'			char(1)
Public 	CheckIOType	 AS String	'			char(1)
Public 	CheckMaterialType	 AS String	'			char(1)
Public 	CheckMarketType	 AS String	'			char(1)
Public 	CheckRelationType	 AS String	'			char(1)
Public 	SupplierCode	 AS String	'			char(6)
Public 	selUnitPrice	 AS String	'			char(3)
Public 	cdUnitPrice	 AS String	'			char(3)
Public 	PriceExchange	 AS Double	'			decimal
Public 	DateExchange	 AS String	'			char(8)
Public 	seDeliveryTerm	 AS String	'			char(3)
Public 	cdDeliveryTerm	 AS String	'			char(3)
Public 	sePaymentTerm	 AS String	'			char(3)
Public 	cdPaymentTerm	 AS String	'			char(3)
Public 	sePaymentTime	 AS String	'			char(3)
Public 	cdPaymentTime	 AS String	'			char(3)
Public 	sePaymentDay	 AS String	'			char(3)
Public 	cdPaymentDay	 AS String	'			char(3)
Public 	seOrigin	 AS String	'			char(3)
Public 	cdOrigin	 AS String	'			char(3)
Public 	seCommercialTerm	 AS String	'			char(3)
Public 	cdCommercialTerm	 AS String	'			char(3)
Public 	sePaymentCondition	 AS String	'			char(3)
Public 	cdPaymentCondition	 AS String	'			char(3)
Public 	seBuyingType	 AS String	'			char(3)
Public 	cdBuyingType	 AS String	'			char(3)
Public 	QualityRequest	 AS String	'			nvarchar(50)
Public 	ContractNo	 AS String	'			nvarchar(50)
Public 	Tolerance	 AS String	'			nvarchar(50)
Public 	Destination	 AS String	'			nvarchar(50)
Public 	InchargePurchasing	 AS String	'			char(8)
Public 	AmountPurchasingEX	 AS Double	'			decimal
Public 	AmountPurchasingVND	 AS Double	'			decimal
Public 	AmountTaxEX	 AS Double	'			decimal
Public 	AmountTaxVND	 AS Double	'			decimal
Public 	DateStart	 AS String	'			char(8)
Public 	DateEstimate	 AS String	'			char(8)
Public 	DateDelivery	 AS String	'			char(8)
Public 	DateInsert	 AS String	'			char(8)
Public 	DateUpdate	 AS String	'			char(8)
Public 	InchargeInsert	 AS String	'			char(6)
Public 	InchargeUpdate	 AS String	'			char(6)
Public 	CheckComplete	 AS String	'			char(1)
Public 	PurchasingOrderNo	 AS String	'			char(9)
Public 	Remark	 AS String	'			nvarchar(500)
'=========================================================================================================================================================
End structure

Public D3451 As T3451_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK3451(FACTORDERNO AS String) As Boolean
    READ_PFK3451 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK3451 "
    SQL = SQL & " WHERE K3451_FactOrderNo		 = '" & FactOrderNo & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D3451_CLEAR: GoTo SKIP_READ_PFK3451
                
    Call K3451_MOVE(rd)
    READ_PFK3451 = True

SKIP_READ_PFK3451:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK3451",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK3451(FACTORDERNO AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK3451 "
    SQL = SQL & " WHERE K3451_FactOrderNo		 = '" & FactOrderNo & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK3451",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK3451(z3451 As T3451_AREA) As Boolean
    WRITE_PFK3451 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z3451)
 
    SQL = " INSERT INTO PFK3451 "
    SQL = SQL & " ( "
    SQL = SQL & " K3451_FactOrderNo," 
    SQL = SQL & " K3451_PurchaseInvoice1," 
    SQL = SQL & " K3451_PurchaseInvoice2," 
    SQL = SQL & " K3451_seSeason," 
    SQL = SQL & " K3451_cdSeason," 
    SQL = SQL & " K3451_CustomerCode," 
    SQL = SQL & " K3451_DateAccept," 
    SQL = SQL & " K3451_CheckInPurchasingOrder," 
    SQL = SQL & " K3451_CheckOutPurchasingOrder," 
    SQL = SQL & " K3451_CheckProcessType," 
    SQL = SQL & " K3451_CheckIOType," 
    SQL = SQL & " K3451_CheckMaterialType," 
    SQL = SQL & " K3451_CheckMarketType," 
    SQL = SQL & " K3451_CheckRelationType," 
    SQL = SQL & " K3451_SupplierCode," 
    SQL = SQL & " K3451_selUnitPrice," 
    SQL = SQL & " K3451_cdUnitPrice," 
    SQL = SQL & " K3451_PriceExchange," 
    SQL = SQL & " K3451_DateExchange," 
    SQL = SQL & " K3451_seDeliveryTerm," 
    SQL = SQL & " K3451_cdDeliveryTerm," 
    SQL = SQL & " K3451_sePaymentTerm," 
    SQL = SQL & " K3451_cdPaymentTerm," 
    SQL = SQL & " K3451_sePaymentTime," 
    SQL = SQL & " K3451_cdPaymentTime," 
    SQL = SQL & " K3451_sePaymentDay," 
    SQL = SQL & " K3451_cdPaymentDay," 
    SQL = SQL & " K3451_seOrigin," 
    SQL = SQL & " K3451_cdOrigin," 
    SQL = SQL & " K3451_seCommercialTerm," 
    SQL = SQL & " K3451_cdCommercialTerm," 
    SQL = SQL & " K3451_sePaymentCondition," 
    SQL = SQL & " K3451_cdPaymentCondition," 
    SQL = SQL & " K3451_seBuyingType," 
    SQL = SQL & " K3451_cdBuyingType," 
    SQL = SQL & " K3451_QualityRequest," 
    SQL = SQL & " K3451_ContractNo," 
    SQL = SQL & " K3451_Tolerance," 
    SQL = SQL & " K3451_Destination," 
    SQL = SQL & " K3451_InchargePurchasing," 
    SQL = SQL & " K3451_AmountPurchasingEX," 
    SQL = SQL & " K3451_AmountPurchasingVND," 
    SQL = SQL & " K3451_AmountTaxEX," 
    SQL = SQL & " K3451_AmountTaxVND," 
    SQL = SQL & " K3451_DateStart," 
    SQL = SQL & " K3451_DateEstimate," 
    SQL = SQL & " K3451_DateDelivery," 
    SQL = SQL & " K3451_DateInsert," 
    SQL = SQL & " K3451_DateUpdate," 
    SQL = SQL & " K3451_InchargeInsert," 
    SQL = SQL & " K3451_InchargeUpdate," 
    SQL = SQL & " K3451_CheckComplete," 
    SQL = SQL & " K3451_PurchasingOrderNo," 
    SQL = SQL & " K3451_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z3451.FactOrderNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3451.PurchaseInvoice1) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3451.PurchaseInvoice2) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3451.seSeason) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3451.cdSeason) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3451.CustomerCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3451.DateAccept) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3451.CheckInPurchasingOrder) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3451.CheckOutPurchasingOrder) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3451.CheckProcessType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3451.CheckIOType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3451.CheckMaterialType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3451.CheckMarketType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3451.CheckRelationType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3451.SupplierCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3451.selUnitPrice) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3451.cdUnitPrice) & "', "  
    SQL = SQL & "   " & FormatSQL(z3451.PriceExchange) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z3451.DateExchange) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3451.seDeliveryTerm) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3451.cdDeliveryTerm) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3451.sePaymentTerm) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3451.cdPaymentTerm) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3451.sePaymentTime) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3451.cdPaymentTime) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3451.sePaymentDay) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3451.cdPaymentDay) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3451.seOrigin) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3451.cdOrigin) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3451.seCommercialTerm) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3451.cdCommercialTerm) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3451.sePaymentCondition) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3451.cdPaymentCondition) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3451.seBuyingType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3451.cdBuyingType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3451.QualityRequest) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3451.ContractNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3451.Tolerance) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3451.Destination) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3451.InchargePurchasing) & "', "  
    SQL = SQL & "   " & FormatSQL(z3451.AmountPurchasingEX) & ", "  
    SQL = SQL & "   " & FormatSQL(z3451.AmountPurchasingVND) & ", "  
    SQL = SQL & "   " & FormatSQL(z3451.AmountTaxEX) & ", "  
    SQL = SQL & "   " & FormatSQL(z3451.AmountTaxVND) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z3451.DateStart) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3451.DateEstimate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3451.DateDelivery) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3451.DateInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3451.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3451.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3451.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3451.CheckComplete) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3451.PurchasingOrderNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3451.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK3451 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK3451",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK3451(z3451 As T3451_AREA) As Boolean
    REWRITE_PFK3451 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z3451)
   
    SQL = " UPDATE PFK3451 SET "
    SQL = SQL & "    K3451_PurchaseInvoice1      = N'" & FormatSQL(z3451.PurchaseInvoice1) & "', " 
    SQL = SQL & "    K3451_PurchaseInvoice2      = N'" & FormatSQL(z3451.PurchaseInvoice2) & "', " 
    SQL = SQL & "    K3451_seSeason      = N'" & FormatSQL(z3451.seSeason) & "', " 
    SQL = SQL & "    K3451_cdSeason      = N'" & FormatSQL(z3451.cdSeason) & "', " 
    SQL = SQL & "    K3451_CustomerCode      = N'" & FormatSQL(z3451.CustomerCode) & "', " 
    SQL = SQL & "    K3451_DateAccept      = N'" & FormatSQL(z3451.DateAccept) & "', " 
    SQL = SQL & "    K3451_CheckInPurchasingOrder      = N'" & FormatSQL(z3451.CheckInPurchasingOrder) & "', " 
    SQL = SQL & "    K3451_CheckOutPurchasingOrder      = N'" & FormatSQL(z3451.CheckOutPurchasingOrder) & "', " 
    SQL = SQL & "    K3451_CheckProcessType      = N'" & FormatSQL(z3451.CheckProcessType) & "', " 
    SQL = SQL & "    K3451_CheckIOType      = N'" & FormatSQL(z3451.CheckIOType) & "', " 
    SQL = SQL & "    K3451_CheckMaterialType      = N'" & FormatSQL(z3451.CheckMaterialType) & "', " 
    SQL = SQL & "    K3451_CheckMarketType      = N'" & FormatSQL(z3451.CheckMarketType) & "', " 
    SQL = SQL & "    K3451_CheckRelationType      = N'" & FormatSQL(z3451.CheckRelationType) & "', " 
    SQL = SQL & "    K3451_SupplierCode      = N'" & FormatSQL(z3451.SupplierCode) & "', " 
    SQL = SQL & "    K3451_selUnitPrice      = N'" & FormatSQL(z3451.selUnitPrice) & "', " 
    SQL = SQL & "    K3451_cdUnitPrice      = N'" & FormatSQL(z3451.cdUnitPrice) & "', " 
    SQL = SQL & "    K3451_PriceExchange      =  " & FormatSQL(z3451.PriceExchange) & ", " 
    SQL = SQL & "    K3451_DateExchange      = N'" & FormatSQL(z3451.DateExchange) & "', " 
    SQL = SQL & "    K3451_seDeliveryTerm      = N'" & FormatSQL(z3451.seDeliveryTerm) & "', " 
    SQL = SQL & "    K3451_cdDeliveryTerm      = N'" & FormatSQL(z3451.cdDeliveryTerm) & "', " 
    SQL = SQL & "    K3451_sePaymentTerm      = N'" & FormatSQL(z3451.sePaymentTerm) & "', " 
    SQL = SQL & "    K3451_cdPaymentTerm      = N'" & FormatSQL(z3451.cdPaymentTerm) & "', " 
    SQL = SQL & "    K3451_sePaymentTime      = N'" & FormatSQL(z3451.sePaymentTime) & "', " 
    SQL = SQL & "    K3451_cdPaymentTime      = N'" & FormatSQL(z3451.cdPaymentTime) & "', " 
    SQL = SQL & "    K3451_sePaymentDay      = N'" & FormatSQL(z3451.sePaymentDay) & "', " 
    SQL = SQL & "    K3451_cdPaymentDay      = N'" & FormatSQL(z3451.cdPaymentDay) & "', " 
    SQL = SQL & "    K3451_seOrigin      = N'" & FormatSQL(z3451.seOrigin) & "', " 
    SQL = SQL & "    K3451_cdOrigin      = N'" & FormatSQL(z3451.cdOrigin) & "', " 
    SQL = SQL & "    K3451_seCommercialTerm      = N'" & FormatSQL(z3451.seCommercialTerm) & "', " 
    SQL = SQL & "    K3451_cdCommercialTerm      = N'" & FormatSQL(z3451.cdCommercialTerm) & "', " 
    SQL = SQL & "    K3451_sePaymentCondition      = N'" & FormatSQL(z3451.sePaymentCondition) & "', " 
    SQL = SQL & "    K3451_cdPaymentCondition      = N'" & FormatSQL(z3451.cdPaymentCondition) & "', " 
    SQL = SQL & "    K3451_seBuyingType      = N'" & FormatSQL(z3451.seBuyingType) & "', " 
    SQL = SQL & "    K3451_cdBuyingType      = N'" & FormatSQL(z3451.cdBuyingType) & "', " 
    SQL = SQL & "    K3451_QualityRequest      = N'" & FormatSQL(z3451.QualityRequest) & "', " 
    SQL = SQL & "    K3451_ContractNo      = N'" & FormatSQL(z3451.ContractNo) & "', " 
    SQL = SQL & "    K3451_Tolerance      = N'" & FormatSQL(z3451.Tolerance) & "', " 
    SQL = SQL & "    K3451_Destination      = N'" & FormatSQL(z3451.Destination) & "', " 
    SQL = SQL & "    K3451_InchargePurchasing      = N'" & FormatSQL(z3451.InchargePurchasing) & "', " 
    SQL = SQL & "    K3451_AmountPurchasingEX      =  " & FormatSQL(z3451.AmountPurchasingEX) & ", " 
    SQL = SQL & "    K3451_AmountPurchasingVND      =  " & FormatSQL(z3451.AmountPurchasingVND) & ", " 
    SQL = SQL & "    K3451_AmountTaxEX      =  " & FormatSQL(z3451.AmountTaxEX) & ", " 
    SQL = SQL & "    K3451_AmountTaxVND      =  " & FormatSQL(z3451.AmountTaxVND) & ", " 
    SQL = SQL & "    K3451_DateStart      = N'" & FormatSQL(z3451.DateStart) & "', " 
    SQL = SQL & "    K3451_DateEstimate      = N'" & FormatSQL(z3451.DateEstimate) & "', " 
    SQL = SQL & "    K3451_DateDelivery      = N'" & FormatSQL(z3451.DateDelivery) & "', " 
    SQL = SQL & "    K3451_DateInsert      = N'" & FormatSQL(z3451.DateInsert) & "', " 
    SQL = SQL & "    K3451_DateUpdate      = N'" & FormatSQL(z3451.DateUpdate) & "', " 
    SQL = SQL & "    K3451_InchargeInsert      = N'" & FormatSQL(z3451.InchargeInsert) & "', " 
    SQL = SQL & "    K3451_InchargeUpdate      = N'" & FormatSQL(z3451.InchargeUpdate) & "', " 
    SQL = SQL & "    K3451_CheckComplete      = N'" & FormatSQL(z3451.CheckComplete) & "', " 
    SQL = SQL & "    K3451_PurchasingOrderNo      = N'" & FormatSQL(z3451.PurchasingOrderNo) & "', " 
    SQL = SQL & "    K3451_Remark      = N'" & FormatSQL(z3451.Remark) & "'  " 
    SQL = SQL & " WHERE K3451_FactOrderNo		 = '" & z3451.FactOrderNo & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK3451 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK3451",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK3451(z3451 As T3451_AREA) As Boolean
    DELETE_PFK3451 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK3451 "
    SQL = SQL & " WHERE K3451_FactOrderNo		 = '" & z3451.FactOrderNo & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK3451 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK3451",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D3451_CLEAR()
Try
    
   D3451.FactOrderNo = ""
   D3451.PurchaseInvoice1 = ""
   D3451.PurchaseInvoice2 = ""
   D3451.seSeason = ""
   D3451.cdSeason = ""
   D3451.CustomerCode = ""
   D3451.DateAccept = ""
   D3451.CheckInPurchasingOrder = ""
   D3451.CheckOutPurchasingOrder = ""
   D3451.CheckProcessType = ""
   D3451.CheckIOType = ""
   D3451.CheckMaterialType = ""
   D3451.CheckMarketType = ""
   D3451.CheckRelationType = ""
   D3451.SupplierCode = ""
   D3451.selUnitPrice = ""
   D3451.cdUnitPrice = ""
    D3451.PriceExchange = 0 
   D3451.DateExchange = ""
   D3451.seDeliveryTerm = ""
   D3451.cdDeliveryTerm = ""
   D3451.sePaymentTerm = ""
   D3451.cdPaymentTerm = ""
   D3451.sePaymentTime = ""
   D3451.cdPaymentTime = ""
   D3451.sePaymentDay = ""
   D3451.cdPaymentDay = ""
   D3451.seOrigin = ""
   D3451.cdOrigin = ""
   D3451.seCommercialTerm = ""
   D3451.cdCommercialTerm = ""
   D3451.sePaymentCondition = ""
   D3451.cdPaymentCondition = ""
   D3451.seBuyingType = ""
   D3451.cdBuyingType = ""
   D3451.QualityRequest = ""
   D3451.ContractNo = ""
   D3451.Tolerance = ""
   D3451.Destination = ""
   D3451.InchargePurchasing = ""
    D3451.AmountPurchasingEX = 0 
    D3451.AmountPurchasingVND = 0 
    D3451.AmountTaxEX = 0 
    D3451.AmountTaxVND = 0 
   D3451.DateStart = ""
   D3451.DateEstimate = ""
   D3451.DateDelivery = ""
   D3451.DateInsert = ""
   D3451.DateUpdate = ""
   D3451.InchargeInsert = ""
   D3451.InchargeUpdate = ""
   D3451.CheckComplete = ""
   D3451.PurchasingOrderNo = ""
   D3451.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D3451_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x3451 As T3451_AREA)
Try
    
    x3451.FactOrderNo = trim$(  x3451.FactOrderNo)
    x3451.PurchaseInvoice1 = trim$(  x3451.PurchaseInvoice1)
    x3451.PurchaseInvoice2 = trim$(  x3451.PurchaseInvoice2)
    x3451.seSeason = trim$(  x3451.seSeason)
    x3451.cdSeason = trim$(  x3451.cdSeason)
    x3451.CustomerCode = trim$(  x3451.CustomerCode)
    x3451.DateAccept = trim$(  x3451.DateAccept)
    x3451.CheckInPurchasingOrder = trim$(  x3451.CheckInPurchasingOrder)
    x3451.CheckOutPurchasingOrder = trim$(  x3451.CheckOutPurchasingOrder)
    x3451.CheckProcessType = trim$(  x3451.CheckProcessType)
    x3451.CheckIOType = trim$(  x3451.CheckIOType)
    x3451.CheckMaterialType = trim$(  x3451.CheckMaterialType)
    x3451.CheckMarketType = trim$(  x3451.CheckMarketType)
    x3451.CheckRelationType = trim$(  x3451.CheckRelationType)
    x3451.SupplierCode = trim$(  x3451.SupplierCode)
    x3451.selUnitPrice = trim$(  x3451.selUnitPrice)
    x3451.cdUnitPrice = trim$(  x3451.cdUnitPrice)
    x3451.PriceExchange = trim$(  x3451.PriceExchange)
    x3451.DateExchange = trim$(  x3451.DateExchange)
    x3451.seDeliveryTerm = trim$(  x3451.seDeliveryTerm)
    x3451.cdDeliveryTerm = trim$(  x3451.cdDeliveryTerm)
    x3451.sePaymentTerm = trim$(  x3451.sePaymentTerm)
    x3451.cdPaymentTerm = trim$(  x3451.cdPaymentTerm)
    x3451.sePaymentTime = trim$(  x3451.sePaymentTime)
    x3451.cdPaymentTime = trim$(  x3451.cdPaymentTime)
    x3451.sePaymentDay = trim$(  x3451.sePaymentDay)
    x3451.cdPaymentDay = trim$(  x3451.cdPaymentDay)
    x3451.seOrigin = trim$(  x3451.seOrigin)
    x3451.cdOrigin = trim$(  x3451.cdOrigin)
    x3451.seCommercialTerm = trim$(  x3451.seCommercialTerm)
    x3451.cdCommercialTerm = trim$(  x3451.cdCommercialTerm)
    x3451.sePaymentCondition = trim$(  x3451.sePaymentCondition)
    x3451.cdPaymentCondition = trim$(  x3451.cdPaymentCondition)
    x3451.seBuyingType = trim$(  x3451.seBuyingType)
    x3451.cdBuyingType = trim$(  x3451.cdBuyingType)
    x3451.QualityRequest = trim$(  x3451.QualityRequest)
    x3451.ContractNo = trim$(  x3451.ContractNo)
    x3451.Tolerance = trim$(  x3451.Tolerance)
    x3451.Destination = trim$(  x3451.Destination)
    x3451.InchargePurchasing = trim$(  x3451.InchargePurchasing)
    x3451.AmountPurchasingEX = trim$(  x3451.AmountPurchasingEX)
    x3451.AmountPurchasingVND = trim$(  x3451.AmountPurchasingVND)
    x3451.AmountTaxEX = trim$(  x3451.AmountTaxEX)
    x3451.AmountTaxVND = trim$(  x3451.AmountTaxVND)
    x3451.DateStart = trim$(  x3451.DateStart)
    x3451.DateEstimate = trim$(  x3451.DateEstimate)
    x3451.DateDelivery = trim$(  x3451.DateDelivery)
    x3451.DateInsert = trim$(  x3451.DateInsert)
    x3451.DateUpdate = trim$(  x3451.DateUpdate)
    x3451.InchargeInsert = trim$(  x3451.InchargeInsert)
    x3451.InchargeUpdate = trim$(  x3451.InchargeUpdate)
    x3451.CheckComplete = trim$(  x3451.CheckComplete)
    x3451.PurchasingOrderNo = trim$(  x3451.PurchasingOrderNo)
    x3451.Remark = trim$(  x3451.Remark)
     
    If trim$( x3451.FactOrderNo ) = "" Then x3451.FactOrderNo = Space(1) 
    If trim$( x3451.PurchaseInvoice1 ) = "" Then x3451.PurchaseInvoice1 = Space(1) 
    If trim$( x3451.PurchaseInvoice2 ) = "" Then x3451.PurchaseInvoice2 = Space(1) 
    If trim$( x3451.seSeason ) = "" Then x3451.seSeason = Space(1) 
    If trim$( x3451.cdSeason ) = "" Then x3451.cdSeason = Space(1) 
    If trim$( x3451.CustomerCode ) = "" Then x3451.CustomerCode = Space(1) 
    If trim$( x3451.DateAccept ) = "" Then x3451.DateAccept = Space(1) 
    If trim$( x3451.CheckInPurchasingOrder ) = "" Then x3451.CheckInPurchasingOrder = Space(1) 
    If trim$( x3451.CheckOutPurchasingOrder ) = "" Then x3451.CheckOutPurchasingOrder = Space(1) 
    If trim$( x3451.CheckProcessType ) = "" Then x3451.CheckProcessType = Space(1) 
    If trim$( x3451.CheckIOType ) = "" Then x3451.CheckIOType = Space(1) 
    If trim$( x3451.CheckMaterialType ) = "" Then x3451.CheckMaterialType = Space(1) 
    If trim$( x3451.CheckMarketType ) = "" Then x3451.CheckMarketType = Space(1) 
    If trim$( x3451.CheckRelationType ) = "" Then x3451.CheckRelationType = Space(1) 
    If trim$( x3451.SupplierCode ) = "" Then x3451.SupplierCode = Space(1) 
    If trim$( x3451.selUnitPrice ) = "" Then x3451.selUnitPrice = Space(1) 
    If trim$( x3451.cdUnitPrice ) = "" Then x3451.cdUnitPrice = Space(1) 
    If trim$( x3451.PriceExchange ) = "" Then x3451.PriceExchange = 0 
    If trim$( x3451.DateExchange ) = "" Then x3451.DateExchange = Space(1) 
    If trim$( x3451.seDeliveryTerm ) = "" Then x3451.seDeliveryTerm = Space(1) 
    If trim$( x3451.cdDeliveryTerm ) = "" Then x3451.cdDeliveryTerm = Space(1) 
    If trim$( x3451.sePaymentTerm ) = "" Then x3451.sePaymentTerm = Space(1) 
    If trim$( x3451.cdPaymentTerm ) = "" Then x3451.cdPaymentTerm = Space(1) 
    If trim$( x3451.sePaymentTime ) = "" Then x3451.sePaymentTime = Space(1) 
    If trim$( x3451.cdPaymentTime ) = "" Then x3451.cdPaymentTime = Space(1) 
    If trim$( x3451.sePaymentDay ) = "" Then x3451.sePaymentDay = Space(1) 
    If trim$( x3451.cdPaymentDay ) = "" Then x3451.cdPaymentDay = Space(1) 
    If trim$( x3451.seOrigin ) = "" Then x3451.seOrigin = Space(1) 
    If trim$( x3451.cdOrigin ) = "" Then x3451.cdOrigin = Space(1) 
    If trim$( x3451.seCommercialTerm ) = "" Then x3451.seCommercialTerm = Space(1) 
    If trim$( x3451.cdCommercialTerm ) = "" Then x3451.cdCommercialTerm = Space(1) 
    If trim$( x3451.sePaymentCondition ) = "" Then x3451.sePaymentCondition = Space(1) 
    If trim$( x3451.cdPaymentCondition ) = "" Then x3451.cdPaymentCondition = Space(1) 
    If trim$( x3451.seBuyingType ) = "" Then x3451.seBuyingType = Space(1) 
    If trim$( x3451.cdBuyingType ) = "" Then x3451.cdBuyingType = Space(1) 
    If trim$( x3451.QualityRequest ) = "" Then x3451.QualityRequest = Space(1) 
    If trim$( x3451.ContractNo ) = "" Then x3451.ContractNo = Space(1) 
    If trim$( x3451.Tolerance ) = "" Then x3451.Tolerance = Space(1) 
    If trim$( x3451.Destination ) = "" Then x3451.Destination = Space(1) 
    If trim$( x3451.InchargePurchasing ) = "" Then x3451.InchargePurchasing = Space(1) 
    If trim$( x3451.AmountPurchasingEX ) = "" Then x3451.AmountPurchasingEX = 0 
    If trim$( x3451.AmountPurchasingVND ) = "" Then x3451.AmountPurchasingVND = 0 
    If trim$( x3451.AmountTaxEX ) = "" Then x3451.AmountTaxEX = 0 
    If trim$( x3451.AmountTaxVND ) = "" Then x3451.AmountTaxVND = 0 
    If trim$( x3451.DateStart ) = "" Then x3451.DateStart = Space(1) 
    If trim$( x3451.DateEstimate ) = "" Then x3451.DateEstimate = Space(1) 
    If trim$( x3451.DateDelivery ) = "" Then x3451.DateDelivery = Space(1) 
    If trim$( x3451.DateInsert ) = "" Then x3451.DateInsert = Space(1) 
    If trim$( x3451.DateUpdate ) = "" Then x3451.DateUpdate = Space(1) 
    If trim$( x3451.InchargeInsert ) = "" Then x3451.InchargeInsert = Space(1) 
    If trim$( x3451.InchargeUpdate ) = "" Then x3451.InchargeUpdate = Space(1) 
    If trim$( x3451.CheckComplete ) = "" Then x3451.CheckComplete = Space(1) 
    If trim$( x3451.PurchasingOrderNo ) = "" Then x3451.PurchasingOrderNo = Space(1) 
    If trim$( x3451.Remark ) = "" Then x3451.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K3451_MOVE(rs3451 As SqlClient.SqlDataReader)
Try

    call D3451_CLEAR()   

    If IsdbNull(rs3451!K3451_FactOrderNo) = False Then D3451.FactOrderNo = Trim$(rs3451!K3451_FactOrderNo)
    If IsdbNull(rs3451!K3451_PurchaseInvoice1) = False Then D3451.PurchaseInvoice1 = Trim$(rs3451!K3451_PurchaseInvoice1)
    If IsdbNull(rs3451!K3451_PurchaseInvoice2) = False Then D3451.PurchaseInvoice2 = Trim$(rs3451!K3451_PurchaseInvoice2)
    If IsdbNull(rs3451!K3451_seSeason) = False Then D3451.seSeason = Trim$(rs3451!K3451_seSeason)
    If IsdbNull(rs3451!K3451_cdSeason) = False Then D3451.cdSeason = Trim$(rs3451!K3451_cdSeason)
    If IsdbNull(rs3451!K3451_CustomerCode) = False Then D3451.CustomerCode = Trim$(rs3451!K3451_CustomerCode)
    If IsdbNull(rs3451!K3451_DateAccept) = False Then D3451.DateAccept = Trim$(rs3451!K3451_DateAccept)
    If IsdbNull(rs3451!K3451_CheckInPurchasingOrder) = False Then D3451.CheckInPurchasingOrder = Trim$(rs3451!K3451_CheckInPurchasingOrder)
    If IsdbNull(rs3451!K3451_CheckOutPurchasingOrder) = False Then D3451.CheckOutPurchasingOrder = Trim$(rs3451!K3451_CheckOutPurchasingOrder)
    If IsdbNull(rs3451!K3451_CheckProcessType) = False Then D3451.CheckProcessType = Trim$(rs3451!K3451_CheckProcessType)
    If IsdbNull(rs3451!K3451_CheckIOType) = False Then D3451.CheckIOType = Trim$(rs3451!K3451_CheckIOType)
    If IsdbNull(rs3451!K3451_CheckMaterialType) = False Then D3451.CheckMaterialType = Trim$(rs3451!K3451_CheckMaterialType)
    If IsdbNull(rs3451!K3451_CheckMarketType) = False Then D3451.CheckMarketType = Trim$(rs3451!K3451_CheckMarketType)
    If IsdbNull(rs3451!K3451_CheckRelationType) = False Then D3451.CheckRelationType = Trim$(rs3451!K3451_CheckRelationType)
    If IsdbNull(rs3451!K3451_SupplierCode) = False Then D3451.SupplierCode = Trim$(rs3451!K3451_SupplierCode)
    If IsdbNull(rs3451!K3451_selUnitPrice) = False Then D3451.selUnitPrice = Trim$(rs3451!K3451_selUnitPrice)
    If IsdbNull(rs3451!K3451_cdUnitPrice) = False Then D3451.cdUnitPrice = Trim$(rs3451!K3451_cdUnitPrice)
    If IsdbNull(rs3451!K3451_PriceExchange) = False Then D3451.PriceExchange = Trim$(rs3451!K3451_PriceExchange)
    If IsdbNull(rs3451!K3451_DateExchange) = False Then D3451.DateExchange = Trim$(rs3451!K3451_DateExchange)
    If IsdbNull(rs3451!K3451_seDeliveryTerm) = False Then D3451.seDeliveryTerm = Trim$(rs3451!K3451_seDeliveryTerm)
    If IsdbNull(rs3451!K3451_cdDeliveryTerm) = False Then D3451.cdDeliveryTerm = Trim$(rs3451!K3451_cdDeliveryTerm)
    If IsdbNull(rs3451!K3451_sePaymentTerm) = False Then D3451.sePaymentTerm = Trim$(rs3451!K3451_sePaymentTerm)
    If IsdbNull(rs3451!K3451_cdPaymentTerm) = False Then D3451.cdPaymentTerm = Trim$(rs3451!K3451_cdPaymentTerm)
    If IsdbNull(rs3451!K3451_sePaymentTime) = False Then D3451.sePaymentTime = Trim$(rs3451!K3451_sePaymentTime)
    If IsdbNull(rs3451!K3451_cdPaymentTime) = False Then D3451.cdPaymentTime = Trim$(rs3451!K3451_cdPaymentTime)
    If IsdbNull(rs3451!K3451_sePaymentDay) = False Then D3451.sePaymentDay = Trim$(rs3451!K3451_sePaymentDay)
    If IsdbNull(rs3451!K3451_cdPaymentDay) = False Then D3451.cdPaymentDay = Trim$(rs3451!K3451_cdPaymentDay)
    If IsdbNull(rs3451!K3451_seOrigin) = False Then D3451.seOrigin = Trim$(rs3451!K3451_seOrigin)
    If IsdbNull(rs3451!K3451_cdOrigin) = False Then D3451.cdOrigin = Trim$(rs3451!K3451_cdOrigin)
    If IsdbNull(rs3451!K3451_seCommercialTerm) = False Then D3451.seCommercialTerm = Trim$(rs3451!K3451_seCommercialTerm)
    If IsdbNull(rs3451!K3451_cdCommercialTerm) = False Then D3451.cdCommercialTerm = Trim$(rs3451!K3451_cdCommercialTerm)
    If IsdbNull(rs3451!K3451_sePaymentCondition) = False Then D3451.sePaymentCondition = Trim$(rs3451!K3451_sePaymentCondition)
    If IsdbNull(rs3451!K3451_cdPaymentCondition) = False Then D3451.cdPaymentCondition = Trim$(rs3451!K3451_cdPaymentCondition)
    If IsdbNull(rs3451!K3451_seBuyingType) = False Then D3451.seBuyingType = Trim$(rs3451!K3451_seBuyingType)
    If IsdbNull(rs3451!K3451_cdBuyingType) = False Then D3451.cdBuyingType = Trim$(rs3451!K3451_cdBuyingType)
    If IsdbNull(rs3451!K3451_QualityRequest) = False Then D3451.QualityRequest = Trim$(rs3451!K3451_QualityRequest)
    If IsdbNull(rs3451!K3451_ContractNo) = False Then D3451.ContractNo = Trim$(rs3451!K3451_ContractNo)
    If IsdbNull(rs3451!K3451_Tolerance) = False Then D3451.Tolerance = Trim$(rs3451!K3451_Tolerance)
    If IsdbNull(rs3451!K3451_Destination) = False Then D3451.Destination = Trim$(rs3451!K3451_Destination)
    If IsdbNull(rs3451!K3451_InchargePurchasing) = False Then D3451.InchargePurchasing = Trim$(rs3451!K3451_InchargePurchasing)
    If IsdbNull(rs3451!K3451_AmountPurchasingEX) = False Then D3451.AmountPurchasingEX = Trim$(rs3451!K3451_AmountPurchasingEX)
    If IsdbNull(rs3451!K3451_AmountPurchasingVND) = False Then D3451.AmountPurchasingVND = Trim$(rs3451!K3451_AmountPurchasingVND)
    If IsdbNull(rs3451!K3451_AmountTaxEX) = False Then D3451.AmountTaxEX = Trim$(rs3451!K3451_AmountTaxEX)
    If IsdbNull(rs3451!K3451_AmountTaxVND) = False Then D3451.AmountTaxVND = Trim$(rs3451!K3451_AmountTaxVND)
    If IsdbNull(rs3451!K3451_DateStart) = False Then D3451.DateStart = Trim$(rs3451!K3451_DateStart)
    If IsdbNull(rs3451!K3451_DateEstimate) = False Then D3451.DateEstimate = Trim$(rs3451!K3451_DateEstimate)
    If IsdbNull(rs3451!K3451_DateDelivery) = False Then D3451.DateDelivery = Trim$(rs3451!K3451_DateDelivery)
    If IsdbNull(rs3451!K3451_DateInsert) = False Then D3451.DateInsert = Trim$(rs3451!K3451_DateInsert)
    If IsdbNull(rs3451!K3451_DateUpdate) = False Then D3451.DateUpdate = Trim$(rs3451!K3451_DateUpdate)
    If IsdbNull(rs3451!K3451_InchargeInsert) = False Then D3451.InchargeInsert = Trim$(rs3451!K3451_InchargeInsert)
    If IsdbNull(rs3451!K3451_InchargeUpdate) = False Then D3451.InchargeUpdate = Trim$(rs3451!K3451_InchargeUpdate)
    If IsdbNull(rs3451!K3451_CheckComplete) = False Then D3451.CheckComplete = Trim$(rs3451!K3451_CheckComplete)
    If IsdbNull(rs3451!K3451_PurchasingOrderNo) = False Then D3451.PurchasingOrderNo = Trim$(rs3451!K3451_PurchasingOrderNo)
    If IsdbNull(rs3451!K3451_Remark) = False Then D3451.Remark = Trim$(rs3451!K3451_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K3451_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K3451_MOVE(rs3451 As DataRow)
Try

    call D3451_CLEAR()   

    If IsdbNull(rs3451!K3451_FactOrderNo) = False Then D3451.FactOrderNo = Trim$(rs3451!K3451_FactOrderNo)
    If IsdbNull(rs3451!K3451_PurchaseInvoice1) = False Then D3451.PurchaseInvoice1 = Trim$(rs3451!K3451_PurchaseInvoice1)
    If IsdbNull(rs3451!K3451_PurchaseInvoice2) = False Then D3451.PurchaseInvoice2 = Trim$(rs3451!K3451_PurchaseInvoice2)
    If IsdbNull(rs3451!K3451_seSeason) = False Then D3451.seSeason = Trim$(rs3451!K3451_seSeason)
    If IsdbNull(rs3451!K3451_cdSeason) = False Then D3451.cdSeason = Trim$(rs3451!K3451_cdSeason)
    If IsdbNull(rs3451!K3451_CustomerCode) = False Then D3451.CustomerCode = Trim$(rs3451!K3451_CustomerCode)
    If IsdbNull(rs3451!K3451_DateAccept) = False Then D3451.DateAccept = Trim$(rs3451!K3451_DateAccept)
    If IsdbNull(rs3451!K3451_CheckInPurchasingOrder) = False Then D3451.CheckInPurchasingOrder = Trim$(rs3451!K3451_CheckInPurchasingOrder)
    If IsdbNull(rs3451!K3451_CheckOutPurchasingOrder) = False Then D3451.CheckOutPurchasingOrder = Trim$(rs3451!K3451_CheckOutPurchasingOrder)
    If IsdbNull(rs3451!K3451_CheckProcessType) = False Then D3451.CheckProcessType = Trim$(rs3451!K3451_CheckProcessType)
    If IsdbNull(rs3451!K3451_CheckIOType) = False Then D3451.CheckIOType = Trim$(rs3451!K3451_CheckIOType)
    If IsdbNull(rs3451!K3451_CheckMaterialType) = False Then D3451.CheckMaterialType = Trim$(rs3451!K3451_CheckMaterialType)
    If IsdbNull(rs3451!K3451_CheckMarketType) = False Then D3451.CheckMarketType = Trim$(rs3451!K3451_CheckMarketType)
    If IsdbNull(rs3451!K3451_CheckRelationType) = False Then D3451.CheckRelationType = Trim$(rs3451!K3451_CheckRelationType)
    If IsdbNull(rs3451!K3451_SupplierCode) = False Then D3451.SupplierCode = Trim$(rs3451!K3451_SupplierCode)
    If IsdbNull(rs3451!K3451_selUnitPrice) = False Then D3451.selUnitPrice = Trim$(rs3451!K3451_selUnitPrice)
    If IsdbNull(rs3451!K3451_cdUnitPrice) = False Then D3451.cdUnitPrice = Trim$(rs3451!K3451_cdUnitPrice)
    If IsdbNull(rs3451!K3451_PriceExchange) = False Then D3451.PriceExchange = Trim$(rs3451!K3451_PriceExchange)
    If IsdbNull(rs3451!K3451_DateExchange) = False Then D3451.DateExchange = Trim$(rs3451!K3451_DateExchange)
    If IsdbNull(rs3451!K3451_seDeliveryTerm) = False Then D3451.seDeliveryTerm = Trim$(rs3451!K3451_seDeliveryTerm)
    If IsdbNull(rs3451!K3451_cdDeliveryTerm) = False Then D3451.cdDeliveryTerm = Trim$(rs3451!K3451_cdDeliveryTerm)
    If IsdbNull(rs3451!K3451_sePaymentTerm) = False Then D3451.sePaymentTerm = Trim$(rs3451!K3451_sePaymentTerm)
    If IsdbNull(rs3451!K3451_cdPaymentTerm) = False Then D3451.cdPaymentTerm = Trim$(rs3451!K3451_cdPaymentTerm)
    If IsdbNull(rs3451!K3451_sePaymentTime) = False Then D3451.sePaymentTime = Trim$(rs3451!K3451_sePaymentTime)
    If IsdbNull(rs3451!K3451_cdPaymentTime) = False Then D3451.cdPaymentTime = Trim$(rs3451!K3451_cdPaymentTime)
    If IsdbNull(rs3451!K3451_sePaymentDay) = False Then D3451.sePaymentDay = Trim$(rs3451!K3451_sePaymentDay)
    If IsdbNull(rs3451!K3451_cdPaymentDay) = False Then D3451.cdPaymentDay = Trim$(rs3451!K3451_cdPaymentDay)
    If IsdbNull(rs3451!K3451_seOrigin) = False Then D3451.seOrigin = Trim$(rs3451!K3451_seOrigin)
    If IsdbNull(rs3451!K3451_cdOrigin) = False Then D3451.cdOrigin = Trim$(rs3451!K3451_cdOrigin)
    If IsdbNull(rs3451!K3451_seCommercialTerm) = False Then D3451.seCommercialTerm = Trim$(rs3451!K3451_seCommercialTerm)
    If IsdbNull(rs3451!K3451_cdCommercialTerm) = False Then D3451.cdCommercialTerm = Trim$(rs3451!K3451_cdCommercialTerm)
    If IsdbNull(rs3451!K3451_sePaymentCondition) = False Then D3451.sePaymentCondition = Trim$(rs3451!K3451_sePaymentCondition)
    If IsdbNull(rs3451!K3451_cdPaymentCondition) = False Then D3451.cdPaymentCondition = Trim$(rs3451!K3451_cdPaymentCondition)
    If IsdbNull(rs3451!K3451_seBuyingType) = False Then D3451.seBuyingType = Trim$(rs3451!K3451_seBuyingType)
    If IsdbNull(rs3451!K3451_cdBuyingType) = False Then D3451.cdBuyingType = Trim$(rs3451!K3451_cdBuyingType)
    If IsdbNull(rs3451!K3451_QualityRequest) = False Then D3451.QualityRequest = Trim$(rs3451!K3451_QualityRequest)
    If IsdbNull(rs3451!K3451_ContractNo) = False Then D3451.ContractNo = Trim$(rs3451!K3451_ContractNo)
    If IsdbNull(rs3451!K3451_Tolerance) = False Then D3451.Tolerance = Trim$(rs3451!K3451_Tolerance)
    If IsdbNull(rs3451!K3451_Destination) = False Then D3451.Destination = Trim$(rs3451!K3451_Destination)
    If IsdbNull(rs3451!K3451_InchargePurchasing) = False Then D3451.InchargePurchasing = Trim$(rs3451!K3451_InchargePurchasing)
    If IsdbNull(rs3451!K3451_AmountPurchasingEX) = False Then D3451.AmountPurchasingEX = Trim$(rs3451!K3451_AmountPurchasingEX)
    If IsdbNull(rs3451!K3451_AmountPurchasingVND) = False Then D3451.AmountPurchasingVND = Trim$(rs3451!K3451_AmountPurchasingVND)
    If IsdbNull(rs3451!K3451_AmountTaxEX) = False Then D3451.AmountTaxEX = Trim$(rs3451!K3451_AmountTaxEX)
    If IsdbNull(rs3451!K3451_AmountTaxVND) = False Then D3451.AmountTaxVND = Trim$(rs3451!K3451_AmountTaxVND)
    If IsdbNull(rs3451!K3451_DateStart) = False Then D3451.DateStart = Trim$(rs3451!K3451_DateStart)
    If IsdbNull(rs3451!K3451_DateEstimate) = False Then D3451.DateEstimate = Trim$(rs3451!K3451_DateEstimate)
    If IsdbNull(rs3451!K3451_DateDelivery) = False Then D3451.DateDelivery = Trim$(rs3451!K3451_DateDelivery)
    If IsdbNull(rs3451!K3451_DateInsert) = False Then D3451.DateInsert = Trim$(rs3451!K3451_DateInsert)
    If IsdbNull(rs3451!K3451_DateUpdate) = False Then D3451.DateUpdate = Trim$(rs3451!K3451_DateUpdate)
    If IsdbNull(rs3451!K3451_InchargeInsert) = False Then D3451.InchargeInsert = Trim$(rs3451!K3451_InchargeInsert)
    If IsdbNull(rs3451!K3451_InchargeUpdate) = False Then D3451.InchargeUpdate = Trim$(rs3451!K3451_InchargeUpdate)
    If IsdbNull(rs3451!K3451_CheckComplete) = False Then D3451.CheckComplete = Trim$(rs3451!K3451_CheckComplete)
    If IsdbNull(rs3451!K3451_PurchasingOrderNo) = False Then D3451.PurchasingOrderNo = Trim$(rs3451!K3451_PurchasingOrderNo)
    If IsdbNull(rs3451!K3451_Remark) = False Then D3451.Remark = Trim$(rs3451!K3451_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K3451_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K3451_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z3451 As T3451_AREA, FACTORDERNO AS String) as Boolean

K3451_MOVE = False

Try
    If READ_PFK3451(FACTORDERNO) = True Then
                z3451 = D3451
		K3451_MOVE = True
		else
	z3451 = nothing
     End If

     If  getColumIndex(spr,"FactOrderNo") > -1 then z3451.FactOrderNo = getDataM(spr, getColumIndex(spr,"FactOrderNo"), xRow)
     If  getColumIndex(spr,"PurchaseInvoice1") > -1 then z3451.PurchaseInvoice1 = getDataM(spr, getColumIndex(spr,"PurchaseInvoice1"), xRow)
     If  getColumIndex(spr,"PurchaseInvoice2") > -1 then z3451.PurchaseInvoice2 = getDataM(spr, getColumIndex(spr,"PurchaseInvoice2"), xRow)
     If  getColumIndex(spr,"seSeason") > -1 then z3451.seSeason = getDataM(spr, getColumIndex(spr,"seSeason"), xRow)
     If  getColumIndex(spr,"cdSeason") > -1 then z3451.cdSeason = getDataM(spr, getColumIndex(spr,"cdSeason"), xRow)
     If  getColumIndex(spr,"CustomerCode") > -1 then z3451.CustomerCode = getDataM(spr, getColumIndex(spr,"CustomerCode"), xRow)
     If  getColumIndex(spr,"DateAccept") > -1 then z3451.DateAccept = getDataM(spr, getColumIndex(spr,"DateAccept"), xRow)
     If  getColumIndex(spr,"CheckInPurchasingOrder") > -1 then z3451.CheckInPurchasingOrder = getDataM(spr, getColumIndex(spr,"CheckInPurchasingOrder"), xRow)
     If  getColumIndex(spr,"CheckOutPurchasingOrder") > -1 then z3451.CheckOutPurchasingOrder = getDataM(spr, getColumIndex(spr,"CheckOutPurchasingOrder"), xRow)
     If  getColumIndex(spr,"CheckProcessType") > -1 then z3451.CheckProcessType = getDataM(spr, getColumIndex(spr,"CheckProcessType"), xRow)
     If  getColumIndex(spr,"CheckIOType") > -1 then z3451.CheckIOType = getDataM(spr, getColumIndex(spr,"CheckIOType"), xRow)
     If  getColumIndex(spr,"CheckMaterialType") > -1 then z3451.CheckMaterialType = getDataM(spr, getColumIndex(spr,"CheckMaterialType"), xRow)
     If  getColumIndex(spr,"CheckMarketType") > -1 then z3451.CheckMarketType = getDataM(spr, getColumIndex(spr,"CheckMarketType"), xRow)
     If  getColumIndex(spr,"CheckRelationType") > -1 then z3451.CheckRelationType = getDataM(spr, getColumIndex(spr,"CheckRelationType"), xRow)
     If  getColumIndex(spr,"SupplierCode") > -1 then z3451.SupplierCode = getDataM(spr, getColumIndex(spr,"SupplierCode"), xRow)
     If  getColumIndex(spr,"selUnitPrice") > -1 then z3451.selUnitPrice = getDataM(spr, getColumIndex(spr,"selUnitPrice"), xRow)
     If  getColumIndex(spr,"cdUnitPrice") > -1 then z3451.cdUnitPrice = getDataM(spr, getColumIndex(spr,"cdUnitPrice"), xRow)
     If  getColumIndex(spr,"PriceExchange") > -1 then z3451.PriceExchange = getDataM(spr, getColumIndex(spr,"PriceExchange"), xRow)
     If  getColumIndex(spr,"DateExchange") > -1 then z3451.DateExchange = getDataM(spr, getColumIndex(spr,"DateExchange"), xRow)
     If  getColumIndex(spr,"seDeliveryTerm") > -1 then z3451.seDeliveryTerm = getDataM(spr, getColumIndex(spr,"seDeliveryTerm"), xRow)
     If  getColumIndex(spr,"cdDeliveryTerm") > -1 then z3451.cdDeliveryTerm = getDataM(spr, getColumIndex(spr,"cdDeliveryTerm"), xRow)
     If  getColumIndex(spr,"sePaymentTerm") > -1 then z3451.sePaymentTerm = getDataM(spr, getColumIndex(spr,"sePaymentTerm"), xRow)
     If  getColumIndex(spr,"cdPaymentTerm") > -1 then z3451.cdPaymentTerm = getDataM(spr, getColumIndex(spr,"cdPaymentTerm"), xRow)
     If  getColumIndex(spr,"sePaymentTime") > -1 then z3451.sePaymentTime = getDataM(spr, getColumIndex(spr,"sePaymentTime"), xRow)
     If  getColumIndex(spr,"cdPaymentTime") > -1 then z3451.cdPaymentTime = getDataM(spr, getColumIndex(spr,"cdPaymentTime"), xRow)
     If  getColumIndex(spr,"sePaymentDay") > -1 then z3451.sePaymentDay = getDataM(spr, getColumIndex(spr,"sePaymentDay"), xRow)
     If  getColumIndex(spr,"cdPaymentDay") > -1 then z3451.cdPaymentDay = getDataM(spr, getColumIndex(spr,"cdPaymentDay"), xRow)
     If  getColumIndex(spr,"seOrigin") > -1 then z3451.seOrigin = getDataM(spr, getColumIndex(spr,"seOrigin"), xRow)
     If  getColumIndex(spr,"cdOrigin") > -1 then z3451.cdOrigin = getDataM(spr, getColumIndex(spr,"cdOrigin"), xRow)
     If  getColumIndex(spr,"seCommercialTerm") > -1 then z3451.seCommercialTerm = getDataM(spr, getColumIndex(spr,"seCommercialTerm"), xRow)
     If  getColumIndex(spr,"cdCommercialTerm") > -1 then z3451.cdCommercialTerm = getDataM(spr, getColumIndex(spr,"cdCommercialTerm"), xRow)
     If  getColumIndex(spr,"sePaymentCondition") > -1 then z3451.sePaymentCondition = getDataM(spr, getColumIndex(spr,"sePaymentCondition"), xRow)
     If  getColumIndex(spr,"cdPaymentCondition") > -1 then z3451.cdPaymentCondition = getDataM(spr, getColumIndex(spr,"cdPaymentCondition"), xRow)
     If  getColumIndex(spr,"seBuyingType") > -1 then z3451.seBuyingType = getDataM(spr, getColumIndex(spr,"seBuyingType"), xRow)
     If  getColumIndex(spr,"cdBuyingType") > -1 then z3451.cdBuyingType = getDataM(spr, getColumIndex(spr,"cdBuyingType"), xRow)
     If  getColumIndex(spr,"QualityRequest") > -1 then z3451.QualityRequest = getDataM(spr, getColumIndex(spr,"QualityRequest"), xRow)
     If  getColumIndex(spr,"ContractNo") > -1 then z3451.ContractNo = getDataM(spr, getColumIndex(spr,"ContractNo"), xRow)
     If  getColumIndex(spr,"Tolerance") > -1 then z3451.Tolerance = getDataM(spr, getColumIndex(spr,"Tolerance"), xRow)
     If  getColumIndex(spr,"Destination") > -1 then z3451.Destination = getDataM(spr, getColumIndex(spr,"Destination"), xRow)
     If  getColumIndex(spr,"InchargePurchasing") > -1 then z3451.InchargePurchasing = getDataM(spr, getColumIndex(spr,"InchargePurchasing"), xRow)
     If  getColumIndex(spr,"AmountPurchasingEX") > -1 then z3451.AmountPurchasingEX = getDataM(spr, getColumIndex(spr,"AmountPurchasingEX"), xRow)
     If  getColumIndex(spr,"AmountPurchasingVND") > -1 then z3451.AmountPurchasingVND = getDataM(spr, getColumIndex(spr,"AmountPurchasingVND"), xRow)
     If  getColumIndex(spr,"AmountTaxEX") > -1 then z3451.AmountTaxEX = getDataM(spr, getColumIndex(spr,"AmountTaxEX"), xRow)
     If  getColumIndex(spr,"AmountTaxVND") > -1 then z3451.AmountTaxVND = getDataM(spr, getColumIndex(spr,"AmountTaxVND"), xRow)
     If  getColumIndex(spr,"DateStart") > -1 then z3451.DateStart = getDataM(spr, getColumIndex(spr,"DateStart"), xRow)
     If  getColumIndex(spr,"DateEstimate") > -1 then z3451.DateEstimate = getDataM(spr, getColumIndex(spr,"DateEstimate"), xRow)
     If  getColumIndex(spr,"DateDelivery") > -1 then z3451.DateDelivery = getDataM(spr, getColumIndex(spr,"DateDelivery"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z3451.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z3451.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z3451.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z3451.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"CheckComplete") > -1 then z3451.CheckComplete = getDataM(spr, getColumIndex(spr,"CheckComplete"), xRow)
     If  getColumIndex(spr,"PurchasingOrderNo") > -1 then z3451.PurchasingOrderNo = getDataM(spr, getColumIndex(spr,"PurchasingOrderNo"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z3451.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K3451_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K3451_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z3451 As T3451_AREA,CheckClear as Boolean,FACTORDERNO AS String) as Boolean

K3451_MOVE = False

Try
    If READ_PFK3451(FACTORDERNO) = True Then
                z3451 = D3451
		K3451_MOVE = True
		else
	If CheckClear  = True then z3451 = nothing
     End If

     If  getColumIndex(spr,"FactOrderNo") > -1 then z3451.FactOrderNo = getDataM(spr, getColumIndex(spr,"FactOrderNo"), xRow)
     If  getColumIndex(spr,"PurchaseInvoice1") > -1 then z3451.PurchaseInvoice1 = getDataM(spr, getColumIndex(spr,"PurchaseInvoice1"), xRow)
     If  getColumIndex(spr,"PurchaseInvoice2") > -1 then z3451.PurchaseInvoice2 = getDataM(spr, getColumIndex(spr,"PurchaseInvoice2"), xRow)
     If  getColumIndex(spr,"seSeason") > -1 then z3451.seSeason = getDataM(spr, getColumIndex(spr,"seSeason"), xRow)
     If  getColumIndex(spr,"cdSeason") > -1 then z3451.cdSeason = getDataM(spr, getColumIndex(spr,"cdSeason"), xRow)
     If  getColumIndex(spr,"CustomerCode") > -1 then z3451.CustomerCode = getDataM(spr, getColumIndex(spr,"CustomerCode"), xRow)
     If  getColumIndex(spr,"DateAccept") > -1 then z3451.DateAccept = getDataM(spr, getColumIndex(spr,"DateAccept"), xRow)
     If  getColumIndex(spr,"CheckInPurchasingOrder") > -1 then z3451.CheckInPurchasingOrder = getDataM(spr, getColumIndex(spr,"CheckInPurchasingOrder"), xRow)
     If  getColumIndex(spr,"CheckOutPurchasingOrder") > -1 then z3451.CheckOutPurchasingOrder = getDataM(spr, getColumIndex(spr,"CheckOutPurchasingOrder"), xRow)
     If  getColumIndex(spr,"CheckProcessType") > -1 then z3451.CheckProcessType = getDataM(spr, getColumIndex(spr,"CheckProcessType"), xRow)
     If  getColumIndex(spr,"CheckIOType") > -1 then z3451.CheckIOType = getDataM(spr, getColumIndex(spr,"CheckIOType"), xRow)
     If  getColumIndex(spr,"CheckMaterialType") > -1 then z3451.CheckMaterialType = getDataM(spr, getColumIndex(spr,"CheckMaterialType"), xRow)
     If  getColumIndex(spr,"CheckMarketType") > -1 then z3451.CheckMarketType = getDataM(spr, getColumIndex(spr,"CheckMarketType"), xRow)
     If  getColumIndex(spr,"CheckRelationType") > -1 then z3451.CheckRelationType = getDataM(spr, getColumIndex(spr,"CheckRelationType"), xRow)
     If  getColumIndex(spr,"SupplierCode") > -1 then z3451.SupplierCode = getDataM(spr, getColumIndex(spr,"SupplierCode"), xRow)
     If  getColumIndex(spr,"selUnitPrice") > -1 then z3451.selUnitPrice = getDataM(spr, getColumIndex(spr,"selUnitPrice"), xRow)
     If  getColumIndex(spr,"cdUnitPrice") > -1 then z3451.cdUnitPrice = getDataM(spr, getColumIndex(spr,"cdUnitPrice"), xRow)
     If  getColumIndex(spr,"PriceExchange") > -1 then z3451.PriceExchange = getDataM(spr, getColumIndex(spr,"PriceExchange"), xRow)
     If  getColumIndex(spr,"DateExchange") > -1 then z3451.DateExchange = getDataM(spr, getColumIndex(spr,"DateExchange"), xRow)
     If  getColumIndex(spr,"seDeliveryTerm") > -1 then z3451.seDeliveryTerm = getDataM(spr, getColumIndex(spr,"seDeliveryTerm"), xRow)
     If  getColumIndex(spr,"cdDeliveryTerm") > -1 then z3451.cdDeliveryTerm = getDataM(spr, getColumIndex(spr,"cdDeliveryTerm"), xRow)
     If  getColumIndex(spr,"sePaymentTerm") > -1 then z3451.sePaymentTerm = getDataM(spr, getColumIndex(spr,"sePaymentTerm"), xRow)
     If  getColumIndex(spr,"cdPaymentTerm") > -1 then z3451.cdPaymentTerm = getDataM(spr, getColumIndex(spr,"cdPaymentTerm"), xRow)
     If  getColumIndex(spr,"sePaymentTime") > -1 then z3451.sePaymentTime = getDataM(spr, getColumIndex(spr,"sePaymentTime"), xRow)
     If  getColumIndex(spr,"cdPaymentTime") > -1 then z3451.cdPaymentTime = getDataM(spr, getColumIndex(spr,"cdPaymentTime"), xRow)
     If  getColumIndex(spr,"sePaymentDay") > -1 then z3451.sePaymentDay = getDataM(spr, getColumIndex(spr,"sePaymentDay"), xRow)
     If  getColumIndex(spr,"cdPaymentDay") > -1 then z3451.cdPaymentDay = getDataM(spr, getColumIndex(spr,"cdPaymentDay"), xRow)
     If  getColumIndex(spr,"seOrigin") > -1 then z3451.seOrigin = getDataM(spr, getColumIndex(spr,"seOrigin"), xRow)
     If  getColumIndex(spr,"cdOrigin") > -1 then z3451.cdOrigin = getDataM(spr, getColumIndex(spr,"cdOrigin"), xRow)
     If  getColumIndex(spr,"seCommercialTerm") > -1 then z3451.seCommercialTerm = getDataM(spr, getColumIndex(spr,"seCommercialTerm"), xRow)
     If  getColumIndex(spr,"cdCommercialTerm") > -1 then z3451.cdCommercialTerm = getDataM(spr, getColumIndex(spr,"cdCommercialTerm"), xRow)
     If  getColumIndex(spr,"sePaymentCondition") > -1 then z3451.sePaymentCondition = getDataM(spr, getColumIndex(spr,"sePaymentCondition"), xRow)
     If  getColumIndex(spr,"cdPaymentCondition") > -1 then z3451.cdPaymentCondition = getDataM(spr, getColumIndex(spr,"cdPaymentCondition"), xRow)
     If  getColumIndex(spr,"seBuyingType") > -1 then z3451.seBuyingType = getDataM(spr, getColumIndex(spr,"seBuyingType"), xRow)
     If  getColumIndex(spr,"cdBuyingType") > -1 then z3451.cdBuyingType = getDataM(spr, getColumIndex(spr,"cdBuyingType"), xRow)
     If  getColumIndex(spr,"QualityRequest") > -1 then z3451.QualityRequest = getDataM(spr, getColumIndex(spr,"QualityRequest"), xRow)
     If  getColumIndex(spr,"ContractNo") > -1 then z3451.ContractNo = getDataM(spr, getColumIndex(spr,"ContractNo"), xRow)
     If  getColumIndex(spr,"Tolerance") > -1 then z3451.Tolerance = getDataM(spr, getColumIndex(spr,"Tolerance"), xRow)
     If  getColumIndex(spr,"Destination") > -1 then z3451.Destination = getDataM(spr, getColumIndex(spr,"Destination"), xRow)
     If  getColumIndex(spr,"InchargePurchasing") > -1 then z3451.InchargePurchasing = getDataM(spr, getColumIndex(spr,"InchargePurchasing"), xRow)
     If  getColumIndex(spr,"AmountPurchasingEX") > -1 then z3451.AmountPurchasingEX = getDataM(spr, getColumIndex(spr,"AmountPurchasingEX"), xRow)
     If  getColumIndex(spr,"AmountPurchasingVND") > -1 then z3451.AmountPurchasingVND = getDataM(spr, getColumIndex(spr,"AmountPurchasingVND"), xRow)
     If  getColumIndex(spr,"AmountTaxEX") > -1 then z3451.AmountTaxEX = getDataM(spr, getColumIndex(spr,"AmountTaxEX"), xRow)
     If  getColumIndex(spr,"AmountTaxVND") > -1 then z3451.AmountTaxVND = getDataM(spr, getColumIndex(spr,"AmountTaxVND"), xRow)
     If  getColumIndex(spr,"DateStart") > -1 then z3451.DateStart = getDataM(spr, getColumIndex(spr,"DateStart"), xRow)
     If  getColumIndex(spr,"DateEstimate") > -1 then z3451.DateEstimate = getDataM(spr, getColumIndex(spr,"DateEstimate"), xRow)
     If  getColumIndex(spr,"DateDelivery") > -1 then z3451.DateDelivery = getDataM(spr, getColumIndex(spr,"DateDelivery"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z3451.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z3451.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z3451.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z3451.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"CheckComplete") > -1 then z3451.CheckComplete = getDataM(spr, getColumIndex(spr,"CheckComplete"), xRow)
     If  getColumIndex(spr,"PurchasingOrderNo") > -1 then z3451.PurchasingOrderNo = getDataM(spr, getColumIndex(spr,"PurchasingOrderNo"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z3451.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K3451_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K3451_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z3451 As T3451_AREA, Job as String, FACTORDERNO AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K3451_MOVE = False

Try
    If READ_PFK3451(FACTORDERNO) = True Then
                z3451 = D3451
		K3451_MOVE = True
		else
	z3451 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3451")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "FACTORDERNO":z3451.FactOrderNo = Children(i).Code
   Case "PURCHASEINVOICE1":z3451.PurchaseInvoice1 = Children(i).Code
   Case "PURCHASEINVOICE2":z3451.PurchaseInvoice2 = Children(i).Code
   Case "SESEASON":z3451.seSeason = Children(i).Code
   Case "CDSEASON":z3451.cdSeason = Children(i).Code
   Case "CUSTOMERCODE":z3451.CustomerCode = Children(i).Code
   Case "DATEACCEPT":z3451.DateAccept = Children(i).Code
   Case "CHECKINPURCHASINGORDER":z3451.CheckInPurchasingOrder = Children(i).Code
   Case "CHECKOUTPURCHASINGORDER":z3451.CheckOutPurchasingOrder = Children(i).Code
   Case "CHECKPROCESSTYPE":z3451.CheckProcessType = Children(i).Code
   Case "CHECKIOTYPE":z3451.CheckIOType = Children(i).Code
   Case "CHECKMATERIALTYPE":z3451.CheckMaterialType = Children(i).Code
   Case "CHECKMARKETTYPE":z3451.CheckMarketType = Children(i).Code
   Case "CHECKRELATIONTYPE":z3451.CheckRelationType = Children(i).Code
   Case "SUPPLIERCODE":z3451.SupplierCode = Children(i).Code
   Case "SELUNITPRICE":z3451.selUnitPrice = Children(i).Code
   Case "CDUNITPRICE":z3451.cdUnitPrice = Children(i).Code
   Case "PRICEEXCHANGE":z3451.PriceExchange = Children(i).Code
   Case "DATEEXCHANGE":z3451.DateExchange = Children(i).Code
   Case "SEDELIVERYTERM":z3451.seDeliveryTerm = Children(i).Code
   Case "CDDELIVERYTERM":z3451.cdDeliveryTerm = Children(i).Code
   Case "SEPAYMENTTERM":z3451.sePaymentTerm = Children(i).Code
   Case "CDPAYMENTTERM":z3451.cdPaymentTerm = Children(i).Code
   Case "SEPAYMENTTIME":z3451.sePaymentTime = Children(i).Code
   Case "CDPAYMENTTIME":z3451.cdPaymentTime = Children(i).Code
   Case "SEPAYMENTDAY":z3451.sePaymentDay = Children(i).Code
   Case "CDPAYMENTDAY":z3451.cdPaymentDay = Children(i).Code
   Case "SEORIGIN":z3451.seOrigin = Children(i).Code
   Case "CDORIGIN":z3451.cdOrigin = Children(i).Code
   Case "SECOMMERCIALTERM":z3451.seCommercialTerm = Children(i).Code
   Case "CDCOMMERCIALTERM":z3451.cdCommercialTerm = Children(i).Code
   Case "SEPAYMENTCONDITION":z3451.sePaymentCondition = Children(i).Code
   Case "CDPAYMENTCONDITION":z3451.cdPaymentCondition = Children(i).Code
   Case "SEBUYINGTYPE":z3451.seBuyingType = Children(i).Code
   Case "CDBUYINGTYPE":z3451.cdBuyingType = Children(i).Code
   Case "QUALITYREQUEST":z3451.QualityRequest = Children(i).Code
   Case "CONTRACTNO":z3451.ContractNo = Children(i).Code
   Case "TOLERANCE":z3451.Tolerance = Children(i).Code
   Case "DESTINATION":z3451.Destination = Children(i).Code
   Case "INCHARGEPURCHASING":z3451.InchargePurchasing = Children(i).Code
   Case "AMOUNTPURCHASINGEX":z3451.AmountPurchasingEX = Children(i).Code
   Case "AMOUNTPURCHASINGVND":z3451.AmountPurchasingVND = Children(i).Code
   Case "AMOUNTTAXEX":z3451.AmountTaxEX = Children(i).Code
   Case "AMOUNTTAXVND":z3451.AmountTaxVND = Children(i).Code
   Case "DATESTART":z3451.DateStart = Children(i).Code
   Case "DATEESTIMATE":z3451.DateEstimate = Children(i).Code
   Case "DATEDELIVERY":z3451.DateDelivery = Children(i).Code
   Case "DATEINSERT":z3451.DateInsert = Children(i).Code
   Case "DATEUPDATE":z3451.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z3451.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z3451.InchargeUpdate = Children(i).Code
   Case "CHECKCOMPLETE":z3451.CheckComplete = Children(i).Code
   Case "PURCHASINGORDERNO":z3451.PurchasingOrderNo = Children(i).Code
   Case "REMARK":z3451.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "FACTORDERNO":z3451.FactOrderNo = Children(i).Data
   Case "PURCHASEINVOICE1":z3451.PurchaseInvoice1 = Children(i).Data
   Case "PURCHASEINVOICE2":z3451.PurchaseInvoice2 = Children(i).Data
   Case "SESEASON":z3451.seSeason = Children(i).Data
   Case "CDSEASON":z3451.cdSeason = Children(i).Data
   Case "CUSTOMERCODE":z3451.CustomerCode = Children(i).Data
   Case "DATEACCEPT":z3451.DateAccept = Children(i).Data
   Case "CHECKINPURCHASINGORDER":z3451.CheckInPurchasingOrder = Children(i).Data
   Case "CHECKOUTPURCHASINGORDER":z3451.CheckOutPurchasingOrder = Children(i).Data
   Case "CHECKPROCESSTYPE":z3451.CheckProcessType = Children(i).Data
   Case "CHECKIOTYPE":z3451.CheckIOType = Children(i).Data
   Case "CHECKMATERIALTYPE":z3451.CheckMaterialType = Children(i).Data
   Case "CHECKMARKETTYPE":z3451.CheckMarketType = Children(i).Data
   Case "CHECKRELATIONTYPE":z3451.CheckRelationType = Children(i).Data
   Case "SUPPLIERCODE":z3451.SupplierCode = Children(i).Data
   Case "SELUNITPRICE":z3451.selUnitPrice = Children(i).Data
   Case "CDUNITPRICE":z3451.cdUnitPrice = Children(i).Data
   Case "PRICEEXCHANGE":z3451.PriceExchange = Children(i).Data
   Case "DATEEXCHANGE":z3451.DateExchange = Children(i).Data
   Case "SEDELIVERYTERM":z3451.seDeliveryTerm = Children(i).Data
   Case "CDDELIVERYTERM":z3451.cdDeliveryTerm = Children(i).Data
   Case "SEPAYMENTTERM":z3451.sePaymentTerm = Children(i).Data
   Case "CDPAYMENTTERM":z3451.cdPaymentTerm = Children(i).Data
   Case "SEPAYMENTTIME":z3451.sePaymentTime = Children(i).Data
   Case "CDPAYMENTTIME":z3451.cdPaymentTime = Children(i).Data
   Case "SEPAYMENTDAY":z3451.sePaymentDay = Children(i).Data
   Case "CDPAYMENTDAY":z3451.cdPaymentDay = Children(i).Data
   Case "SEORIGIN":z3451.seOrigin = Children(i).Data
   Case "CDORIGIN":z3451.cdOrigin = Children(i).Data
   Case "SECOMMERCIALTERM":z3451.seCommercialTerm = Children(i).Data
   Case "CDCOMMERCIALTERM":z3451.cdCommercialTerm = Children(i).Data
   Case "SEPAYMENTCONDITION":z3451.sePaymentCondition = Children(i).Data
   Case "CDPAYMENTCONDITION":z3451.cdPaymentCondition = Children(i).Data
   Case "SEBUYINGTYPE":z3451.seBuyingType = Children(i).Data
   Case "CDBUYINGTYPE":z3451.cdBuyingType = Children(i).Data
   Case "QUALITYREQUEST":z3451.QualityRequest = Children(i).Data
   Case "CONTRACTNO":z3451.ContractNo = Children(i).Data
   Case "TOLERANCE":z3451.Tolerance = Children(i).Data
   Case "DESTINATION":z3451.Destination = Children(i).Data
   Case "INCHARGEPURCHASING":z3451.InchargePurchasing = Children(i).Data
   Case "AMOUNTPURCHASINGEX":z3451.AmountPurchasingEX = Children(i).Data
   Case "AMOUNTPURCHASINGVND":z3451.AmountPurchasingVND = Children(i).Data
   Case "AMOUNTTAXEX":z3451.AmountTaxEX = Children(i).Data
   Case "AMOUNTTAXVND":z3451.AmountTaxVND = Children(i).Data
   Case "DATESTART":z3451.DateStart = Children(i).Data
   Case "DATEESTIMATE":z3451.DateEstimate = Children(i).Data
   Case "DATEDELIVERY":z3451.DateDelivery = Children(i).Data
   Case "DATEINSERT":z3451.DateInsert = Children(i).Data
   Case "DATEUPDATE":z3451.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z3451.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z3451.InchargeUpdate = Children(i).Data
   Case "CHECKCOMPLETE":z3451.CheckComplete = Children(i).Data
   Case "PURCHASINGORDERNO":z3451.PurchasingOrderNo = Children(i).Data
   Case "REMARK":z3451.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K3451_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K3451_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z3451 As T3451_AREA, Job as String, CheckClear as Boolean, FACTORDERNO AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K3451_MOVE = False

Try
    If READ_PFK3451(FACTORDERNO) = True Then
                z3451 = D3451
		K3451_MOVE = True
		else
	If CheckClear  = True then z3451 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3451")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "FACTORDERNO":z3451.FactOrderNo = Children(i).Code
   Case "PURCHASEINVOICE1":z3451.PurchaseInvoice1 = Children(i).Code
   Case "PURCHASEINVOICE2":z3451.PurchaseInvoice2 = Children(i).Code
   Case "SESEASON":z3451.seSeason = Children(i).Code
   Case "CDSEASON":z3451.cdSeason = Children(i).Code
   Case "CUSTOMERCODE":z3451.CustomerCode = Children(i).Code
   Case "DATEACCEPT":z3451.DateAccept = Children(i).Code
   Case "CHECKINPURCHASINGORDER":z3451.CheckInPurchasingOrder = Children(i).Code
   Case "CHECKOUTPURCHASINGORDER":z3451.CheckOutPurchasingOrder = Children(i).Code
   Case "CHECKPROCESSTYPE":z3451.CheckProcessType = Children(i).Code
   Case "CHECKIOTYPE":z3451.CheckIOType = Children(i).Code
   Case "CHECKMATERIALTYPE":z3451.CheckMaterialType = Children(i).Code
   Case "CHECKMARKETTYPE":z3451.CheckMarketType = Children(i).Code
   Case "CHECKRELATIONTYPE":z3451.CheckRelationType = Children(i).Code
   Case "SUPPLIERCODE":z3451.SupplierCode = Children(i).Code
   Case "SELUNITPRICE":z3451.selUnitPrice = Children(i).Code
   Case "CDUNITPRICE":z3451.cdUnitPrice = Children(i).Code
   Case "PRICEEXCHANGE":z3451.PriceExchange = Children(i).Code
   Case "DATEEXCHANGE":z3451.DateExchange = Children(i).Code
   Case "SEDELIVERYTERM":z3451.seDeliveryTerm = Children(i).Code
   Case "CDDELIVERYTERM":z3451.cdDeliveryTerm = Children(i).Code
   Case "SEPAYMENTTERM":z3451.sePaymentTerm = Children(i).Code
   Case "CDPAYMENTTERM":z3451.cdPaymentTerm = Children(i).Code
   Case "SEPAYMENTTIME":z3451.sePaymentTime = Children(i).Code
   Case "CDPAYMENTTIME":z3451.cdPaymentTime = Children(i).Code
   Case "SEPAYMENTDAY":z3451.sePaymentDay = Children(i).Code
   Case "CDPAYMENTDAY":z3451.cdPaymentDay = Children(i).Code
   Case "SEORIGIN":z3451.seOrigin = Children(i).Code
   Case "CDORIGIN":z3451.cdOrigin = Children(i).Code
   Case "SECOMMERCIALTERM":z3451.seCommercialTerm = Children(i).Code
   Case "CDCOMMERCIALTERM":z3451.cdCommercialTerm = Children(i).Code
   Case "SEPAYMENTCONDITION":z3451.sePaymentCondition = Children(i).Code
   Case "CDPAYMENTCONDITION":z3451.cdPaymentCondition = Children(i).Code
   Case "SEBUYINGTYPE":z3451.seBuyingType = Children(i).Code
   Case "CDBUYINGTYPE":z3451.cdBuyingType = Children(i).Code
   Case "QUALITYREQUEST":z3451.QualityRequest = Children(i).Code
   Case "CONTRACTNO":z3451.ContractNo = Children(i).Code
   Case "TOLERANCE":z3451.Tolerance = Children(i).Code
   Case "DESTINATION":z3451.Destination = Children(i).Code
   Case "INCHARGEPURCHASING":z3451.InchargePurchasing = Children(i).Code
   Case "AMOUNTPURCHASINGEX":z3451.AmountPurchasingEX = Children(i).Code
   Case "AMOUNTPURCHASINGVND":z3451.AmountPurchasingVND = Children(i).Code
   Case "AMOUNTTAXEX":z3451.AmountTaxEX = Children(i).Code
   Case "AMOUNTTAXVND":z3451.AmountTaxVND = Children(i).Code
   Case "DATESTART":z3451.DateStart = Children(i).Code
   Case "DATEESTIMATE":z3451.DateEstimate = Children(i).Code
   Case "DATEDELIVERY":z3451.DateDelivery = Children(i).Code
   Case "DATEINSERT":z3451.DateInsert = Children(i).Code
   Case "DATEUPDATE":z3451.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z3451.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z3451.InchargeUpdate = Children(i).Code
   Case "CHECKCOMPLETE":z3451.CheckComplete = Children(i).Code
   Case "PURCHASINGORDERNO":z3451.PurchasingOrderNo = Children(i).Code
   Case "REMARK":z3451.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "FACTORDERNO":z3451.FactOrderNo = Children(i).Data
   Case "PURCHASEINVOICE1":z3451.PurchaseInvoice1 = Children(i).Data
   Case "PURCHASEINVOICE2":z3451.PurchaseInvoice2 = Children(i).Data
   Case "SESEASON":z3451.seSeason = Children(i).Data
   Case "CDSEASON":z3451.cdSeason = Children(i).Data
   Case "CUSTOMERCODE":z3451.CustomerCode = Children(i).Data
   Case "DATEACCEPT":z3451.DateAccept = Children(i).Data
   Case "CHECKINPURCHASINGORDER":z3451.CheckInPurchasingOrder = Children(i).Data
   Case "CHECKOUTPURCHASINGORDER":z3451.CheckOutPurchasingOrder = Children(i).Data
   Case "CHECKPROCESSTYPE":z3451.CheckProcessType = Children(i).Data
   Case "CHECKIOTYPE":z3451.CheckIOType = Children(i).Data
   Case "CHECKMATERIALTYPE":z3451.CheckMaterialType = Children(i).Data
   Case "CHECKMARKETTYPE":z3451.CheckMarketType = Children(i).Data
   Case "CHECKRELATIONTYPE":z3451.CheckRelationType = Children(i).Data
   Case "SUPPLIERCODE":z3451.SupplierCode = Children(i).Data
   Case "SELUNITPRICE":z3451.selUnitPrice = Children(i).Data
   Case "CDUNITPRICE":z3451.cdUnitPrice = Children(i).Data
   Case "PRICEEXCHANGE":z3451.PriceExchange = Children(i).Data
   Case "DATEEXCHANGE":z3451.DateExchange = Children(i).Data
   Case "SEDELIVERYTERM":z3451.seDeliveryTerm = Children(i).Data
   Case "CDDELIVERYTERM":z3451.cdDeliveryTerm = Children(i).Data
   Case "SEPAYMENTTERM":z3451.sePaymentTerm = Children(i).Data
   Case "CDPAYMENTTERM":z3451.cdPaymentTerm = Children(i).Data
   Case "SEPAYMENTTIME":z3451.sePaymentTime = Children(i).Data
   Case "CDPAYMENTTIME":z3451.cdPaymentTime = Children(i).Data
   Case "SEPAYMENTDAY":z3451.sePaymentDay = Children(i).Data
   Case "CDPAYMENTDAY":z3451.cdPaymentDay = Children(i).Data
   Case "SEORIGIN":z3451.seOrigin = Children(i).Data
   Case "CDORIGIN":z3451.cdOrigin = Children(i).Data
   Case "SECOMMERCIALTERM":z3451.seCommercialTerm = Children(i).Data
   Case "CDCOMMERCIALTERM":z3451.cdCommercialTerm = Children(i).Data
   Case "SEPAYMENTCONDITION":z3451.sePaymentCondition = Children(i).Data
   Case "CDPAYMENTCONDITION":z3451.cdPaymentCondition = Children(i).Data
   Case "SEBUYINGTYPE":z3451.seBuyingType = Children(i).Data
   Case "CDBUYINGTYPE":z3451.cdBuyingType = Children(i).Data
   Case "QUALITYREQUEST":z3451.QualityRequest = Children(i).Data
   Case "CONTRACTNO":z3451.ContractNo = Children(i).Data
   Case "TOLERANCE":z3451.Tolerance = Children(i).Data
   Case "DESTINATION":z3451.Destination = Children(i).Data
   Case "INCHARGEPURCHASING":z3451.InchargePurchasing = Children(i).Data
   Case "AMOUNTPURCHASINGEX":z3451.AmountPurchasingEX = Children(i).Data
   Case "AMOUNTPURCHASINGVND":z3451.AmountPurchasingVND = Children(i).Data
   Case "AMOUNTTAXEX":z3451.AmountTaxEX = Children(i).Data
   Case "AMOUNTTAXVND":z3451.AmountTaxVND = Children(i).Data
   Case "DATESTART":z3451.DateStart = Children(i).Data
   Case "DATEESTIMATE":z3451.DateEstimate = Children(i).Data
   Case "DATEDELIVERY":z3451.DateDelivery = Children(i).Data
   Case "DATEINSERT":z3451.DateInsert = Children(i).Data
   Case "DATEUPDATE":z3451.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z3451.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z3451.InchargeUpdate = Children(i).Data
   Case "CHECKCOMPLETE":z3451.CheckComplete = Children(i).Data
   Case "PURCHASINGORDERNO":z3451.PurchasingOrderNo = Children(i).Data
   Case "REMARK":z3451.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K3451_MOVE",vbCritical)
End Try
End Function 
    
End Module 
