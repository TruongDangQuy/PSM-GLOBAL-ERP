'=========================================================================================================================================================
'   TABLE : (PFK3421)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K3421

Structure T3421_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	FactOrderNo	 AS String	'			char(9)		*
Public 	FactOrderName	 AS String	'			nvarchar(20)
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
Public 	seOrigin	 AS String	'			char(3)
Public 	cdOrigin	 AS String	'			char(3)
Public 	seCommercialTerm	 AS String	'			char(3)
Public 	cdCommercialTerm	 AS String	'			char(3)
Public 	seDeliveryTerm	 AS String	'			char(3)
Public 	cdDeliveryTerm	 AS String	'			char(3)
Public 	sePaymentTerm	 AS String	'			char(3)
Public 	cdPaymentTerm	 AS String	'			char(3)
Public 	sePaymentCondition	 AS String	'			char(3)
Public 	cdPaymentCondition	 AS String	'			char(3)
Public 	sePaymentTime	 AS String	'			char(3)
Public 	cdPaymentTime	 AS String	'			char(3)
Public 	sePaymentDay	 AS String	'			char(3)
Public 	cdPaymentDay	 AS String	'			char(3)
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
Public 	AmountExpenseUSD	 AS Double	'			decimal
Public 	AmountExpenseVND	 AS Double	'			decimal
Public 	AmountTotalEX	 AS Double	'			decimal
Public 	AmountTotalVND	 AS Double	'			decimal
Public 	DateStart	 AS String	'			char(8)
Public 	DateEstimate	 AS String	'			char(8)
Public 	DateDelivery	 AS String	'			char(8)
Public 	DateInsert	 AS String	'			char(8)
Public 	DateUpdate	 AS String	'			char(8)
Public 	InchargeInsert	 AS String	'			char(8)
Public 	InchargeUpdate	 AS String	'			char(8)
Public 	CheckComplete	 AS String	'			char(1)
Public 	PurchasingOrderNo	 AS String	'			char(9)
Public 	SalesOrderNo	 AS String	'			char(9)
Public 	SalesOrderSeq	 AS String	'			char(2)
Public 	SalesOrderSno	 AS String	'			char(2)
Public 	Remark	 AS String	'			nvarchar(50)
Public 	ComponentList	 AS String	'			nvarchar(500)
Public 	seSite	 AS String	'			char(3)
Public 	cdSite	 AS String	'			char(3)
'=========================================================================================================================================================
End structure

Public D3421 As T3421_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK3421(FACTORDERNO AS String) As Boolean
    READ_PFK3421 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK3421 "
    SQL = SQL & " WHERE K3421_FactOrderNo		 = '" & FactOrderNo & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D3421_CLEAR: GoTo SKIP_READ_PFK3421
                
    Call K3421_MOVE(rd)
    READ_PFK3421 = True

SKIP_READ_PFK3421:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK3421",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK3421(FACTORDERNO AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK3421 "
    SQL = SQL & " WHERE K3421_FactOrderNo		 = '" & FactOrderNo & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK3421",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK3421(z3421 As T3421_AREA) As Boolean
    WRITE_PFK3421 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z3421)
 
    SQL = " INSERT INTO PFK3421 "
    SQL = SQL & " ( "
    SQL = SQL & " K3421_FactOrderNo," 
    SQL = SQL & " K3421_FactOrderName," 
    SQL = SQL & " K3421_seSeason," 
    SQL = SQL & " K3421_cdSeason," 
    SQL = SQL & " K3421_CustomerCode," 
    SQL = SQL & " K3421_DateAccept," 
    SQL = SQL & " K3421_CheckInPurchasingOrder," 
    SQL = SQL & " K3421_CheckOutPurchasingOrder," 
    SQL = SQL & " K3421_CheckProcessType," 
    SQL = SQL & " K3421_CheckIOType," 
    SQL = SQL & " K3421_CheckMaterialType," 
    SQL = SQL & " K3421_CheckMarketType," 
    SQL = SQL & " K3421_CheckRelationType," 
    SQL = SQL & " K3421_SupplierCode," 
    SQL = SQL & " K3421_selUnitPrice," 
    SQL = SQL & " K3421_cdUnitPrice," 
    SQL = SQL & " K3421_PriceExchange," 
    SQL = SQL & " K3421_DateExchange," 
    SQL = SQL & " K3421_seOrigin," 
    SQL = SQL & " K3421_cdOrigin," 
    SQL = SQL & " K3421_seCommercialTerm," 
    SQL = SQL & " K3421_cdCommercialTerm," 
    SQL = SQL & " K3421_seDeliveryTerm," 
    SQL = SQL & " K3421_cdDeliveryTerm," 
    SQL = SQL & " K3421_sePaymentTerm," 
    SQL = SQL & " K3421_cdPaymentTerm," 
    SQL = SQL & " K3421_sePaymentCondition," 
    SQL = SQL & " K3421_cdPaymentCondition," 
    SQL = SQL & " K3421_sePaymentTime," 
    SQL = SQL & " K3421_cdPaymentTime," 
    SQL = SQL & " K3421_sePaymentDay," 
    SQL = SQL & " K3421_cdPaymentDay," 
    SQL = SQL & " K3421_seBuyingType," 
    SQL = SQL & " K3421_cdBuyingType," 
    SQL = SQL & " K3421_QualityRequest," 
    SQL = SQL & " K3421_ContractNo," 
    SQL = SQL & " K3421_Tolerance," 
    SQL = SQL & " K3421_Destination," 
    SQL = SQL & " K3421_InchargePurchasing," 
    SQL = SQL & " K3421_AmountPurchasingEX," 
    SQL = SQL & " K3421_AmountPurchasingVND," 
    SQL = SQL & " K3421_AmountTaxEX," 
    SQL = SQL & " K3421_AmountTaxVND," 
    SQL = SQL & " K3421_AmountExpenseUSD," 
    SQL = SQL & " K3421_AmountExpenseVND," 
    SQL = SQL & " K3421_AmountTotalEX," 
    SQL = SQL & " K3421_AmountTotalVND," 
    SQL = SQL & " K3421_DateStart," 
    SQL = SQL & " K3421_DateEstimate," 
    SQL = SQL & " K3421_DateDelivery," 
    SQL = SQL & " K3421_DateInsert," 
    SQL = SQL & " K3421_DateUpdate," 
    SQL = SQL & " K3421_InchargeInsert," 
    SQL = SQL & " K3421_InchargeUpdate," 
    SQL = SQL & " K3421_CheckComplete," 
    SQL = SQL & " K3421_PurchasingOrderNo," 
    SQL = SQL & " K3421_SalesOrderNo," 
    SQL = SQL & " K3421_SalesOrderSeq," 
    SQL = SQL & " K3421_SalesOrderSno," 
    SQL = SQL & " K3421_Remark," 
    SQL = SQL & " K3421_ComponentList," 
    SQL = SQL & " K3421_seSite," 
    SQL = SQL & " K3421_cdSite " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z3421.FactOrderNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3421.FactOrderName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3421.seSeason) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3421.cdSeason) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3421.CustomerCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3421.DateAccept) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3421.CheckInPurchasingOrder) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3421.CheckOutPurchasingOrder) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3421.CheckProcessType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3421.CheckIOType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3421.CheckMaterialType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3421.CheckMarketType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3421.CheckRelationType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3421.SupplierCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3421.selUnitPrice) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3421.cdUnitPrice) & "', "  
    SQL = SQL & "   " & FormatSQL(z3421.PriceExchange) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z3421.DateExchange) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3421.seOrigin) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3421.cdOrigin) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3421.seCommercialTerm) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3421.cdCommercialTerm) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3421.seDeliveryTerm) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3421.cdDeliveryTerm) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3421.sePaymentTerm) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3421.cdPaymentTerm) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3421.sePaymentCondition) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3421.cdPaymentCondition) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3421.sePaymentTime) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3421.cdPaymentTime) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3421.sePaymentDay) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3421.cdPaymentDay) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3421.seBuyingType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3421.cdBuyingType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3421.QualityRequest) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3421.ContractNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3421.Tolerance) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3421.Destination) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3421.InchargePurchasing) & "', "  
    SQL = SQL & "   " & FormatSQL(z3421.AmountPurchasingEX) & ", "  
    SQL = SQL & "   " & FormatSQL(z3421.AmountPurchasingVND) & ", "  
    SQL = SQL & "   " & FormatSQL(z3421.AmountTaxEX) & ", "  
    SQL = SQL & "   " & FormatSQL(z3421.AmountTaxVND) & ", "  
    SQL = SQL & "   " & FormatSQL(z3421.AmountExpenseUSD) & ", "  
    SQL = SQL & "   " & FormatSQL(z3421.AmountExpenseVND) & ", "  
    SQL = SQL & "   " & FormatSQL(z3421.AmountTotalEX) & ", "  
    SQL = SQL & "   " & FormatSQL(z3421.AmountTotalVND) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z3421.DateStart) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3421.DateEstimate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3421.DateDelivery) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3421.DateInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3421.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3421.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3421.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3421.CheckComplete) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3421.PurchasingOrderNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3421.SalesOrderNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3421.SalesOrderSeq) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3421.SalesOrderSno) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3421.Remark) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3421.ComponentList) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3421.seSite) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3421.cdSite) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK3421 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK3421",vbCritical)
Finally
        Call GetFullInformation("PFK3421", "I", SQL)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK3421(z3421 As T3421_AREA) As Boolean
    REWRITE_PFK3421 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z3421)
   
    SQL = " UPDATE PFK3421 SET "
    SQL = SQL & "    K3421_FactOrderName      = N'" & FormatSQL(z3421.FactOrderName) & "', " 
    SQL = SQL & "    K3421_seSeason      = N'" & FormatSQL(z3421.seSeason) & "', " 
    SQL = SQL & "    K3421_cdSeason      = N'" & FormatSQL(z3421.cdSeason) & "', " 
    SQL = SQL & "    K3421_CustomerCode      = N'" & FormatSQL(z3421.CustomerCode) & "', " 
    SQL = SQL & "    K3421_DateAccept      = N'" & FormatSQL(z3421.DateAccept) & "', " 
    SQL = SQL & "    K3421_CheckInPurchasingOrder      = N'" & FormatSQL(z3421.CheckInPurchasingOrder) & "', " 
    SQL = SQL & "    K3421_CheckOutPurchasingOrder      = N'" & FormatSQL(z3421.CheckOutPurchasingOrder) & "', " 
    SQL = SQL & "    K3421_CheckProcessType      = N'" & FormatSQL(z3421.CheckProcessType) & "', " 
    SQL = SQL & "    K3421_CheckIOType      = N'" & FormatSQL(z3421.CheckIOType) & "', " 
    SQL = SQL & "    K3421_CheckMaterialType      = N'" & FormatSQL(z3421.CheckMaterialType) & "', " 
    SQL = SQL & "    K3421_CheckMarketType      = N'" & FormatSQL(z3421.CheckMarketType) & "', " 
    SQL = SQL & "    K3421_CheckRelationType      = N'" & FormatSQL(z3421.CheckRelationType) & "', " 
    SQL = SQL & "    K3421_SupplierCode      = N'" & FormatSQL(z3421.SupplierCode) & "', " 
    SQL = SQL & "    K3421_selUnitPrice      = N'" & FormatSQL(z3421.selUnitPrice) & "', " 
    SQL = SQL & "    K3421_cdUnitPrice      = N'" & FormatSQL(z3421.cdUnitPrice) & "', " 
    SQL = SQL & "    K3421_PriceExchange      =  " & FormatSQL(z3421.PriceExchange) & ", " 
    SQL = SQL & "    K3421_DateExchange      = N'" & FormatSQL(z3421.DateExchange) & "', " 
    SQL = SQL & "    K3421_seOrigin      = N'" & FormatSQL(z3421.seOrigin) & "', " 
    SQL = SQL & "    K3421_cdOrigin      = N'" & FormatSQL(z3421.cdOrigin) & "', " 
    SQL = SQL & "    K3421_seCommercialTerm      = N'" & FormatSQL(z3421.seCommercialTerm) & "', " 
    SQL = SQL & "    K3421_cdCommercialTerm      = N'" & FormatSQL(z3421.cdCommercialTerm) & "', " 
    SQL = SQL & "    K3421_seDeliveryTerm      = N'" & FormatSQL(z3421.seDeliveryTerm) & "', " 
    SQL = SQL & "    K3421_cdDeliveryTerm      = N'" & FormatSQL(z3421.cdDeliveryTerm) & "', " 
    SQL = SQL & "    K3421_sePaymentTerm      = N'" & FormatSQL(z3421.sePaymentTerm) & "', " 
    SQL = SQL & "    K3421_cdPaymentTerm      = N'" & FormatSQL(z3421.cdPaymentTerm) & "', " 
    SQL = SQL & "    K3421_sePaymentCondition      = N'" & FormatSQL(z3421.sePaymentCondition) & "', " 
    SQL = SQL & "    K3421_cdPaymentCondition      = N'" & FormatSQL(z3421.cdPaymentCondition) & "', " 
    SQL = SQL & "    K3421_sePaymentTime      = N'" & FormatSQL(z3421.sePaymentTime) & "', " 
    SQL = SQL & "    K3421_cdPaymentTime      = N'" & FormatSQL(z3421.cdPaymentTime) & "', " 
    SQL = SQL & "    K3421_sePaymentDay      = N'" & FormatSQL(z3421.sePaymentDay) & "', " 
    SQL = SQL & "    K3421_cdPaymentDay      = N'" & FormatSQL(z3421.cdPaymentDay) & "', " 
    SQL = SQL & "    K3421_seBuyingType      = N'" & FormatSQL(z3421.seBuyingType) & "', " 
    SQL = SQL & "    K3421_cdBuyingType      = N'" & FormatSQL(z3421.cdBuyingType) & "', " 
    SQL = SQL & "    K3421_QualityRequest      = N'" & FormatSQL(z3421.QualityRequest) & "', " 
    SQL = SQL & "    K3421_ContractNo      = N'" & FormatSQL(z3421.ContractNo) & "', " 
    SQL = SQL & "    K3421_Tolerance      = N'" & FormatSQL(z3421.Tolerance) & "', " 
    SQL = SQL & "    K3421_Destination      = N'" & FormatSQL(z3421.Destination) & "', " 
    SQL = SQL & "    K3421_InchargePurchasing      = N'" & FormatSQL(z3421.InchargePurchasing) & "', " 
    SQL = SQL & "    K3421_AmountPurchasingEX      =  " & FormatSQL(z3421.AmountPurchasingEX) & ", " 
    SQL = SQL & "    K3421_AmountPurchasingVND      =  " & FormatSQL(z3421.AmountPurchasingVND) & ", " 
    SQL = SQL & "    K3421_AmountTaxEX      =  " & FormatSQL(z3421.AmountTaxEX) & ", " 
    SQL = SQL & "    K3421_AmountTaxVND      =  " & FormatSQL(z3421.AmountTaxVND) & ", " 
    SQL = SQL & "    K3421_AmountExpenseUSD      =  " & FormatSQL(z3421.AmountExpenseUSD) & ", " 
    SQL = SQL & "    K3421_AmountExpenseVND      =  " & FormatSQL(z3421.AmountExpenseVND) & ", " 
    SQL = SQL & "    K3421_AmountTotalEX      =  " & FormatSQL(z3421.AmountTotalEX) & ", " 
    SQL = SQL & "    K3421_AmountTotalVND      =  " & FormatSQL(z3421.AmountTotalVND) & ", " 
    SQL = SQL & "    K3421_DateStart      = N'" & FormatSQL(z3421.DateStart) & "', " 
    SQL = SQL & "    K3421_DateEstimate      = N'" & FormatSQL(z3421.DateEstimate) & "', " 
    SQL = SQL & "    K3421_DateDelivery      = N'" & FormatSQL(z3421.DateDelivery) & "', " 
    SQL = SQL & "    K3421_DateInsert      = N'" & FormatSQL(z3421.DateInsert) & "', " 
    SQL = SQL & "    K3421_DateUpdate      = N'" & FormatSQL(z3421.DateUpdate) & "', " 
    SQL = SQL & "    K3421_InchargeInsert      = N'" & FormatSQL(z3421.InchargeInsert) & "', " 
    SQL = SQL & "    K3421_InchargeUpdate      = N'" & FormatSQL(z3421.InchargeUpdate) & "', " 
    SQL = SQL & "    K3421_CheckComplete      = N'" & FormatSQL(z3421.CheckComplete) & "', " 
    SQL = SQL & "    K3421_PurchasingOrderNo      = N'" & FormatSQL(z3421.PurchasingOrderNo) & "', " 
    SQL = SQL & "    K3421_SalesOrderNo      = N'" & FormatSQL(z3421.SalesOrderNo) & "', " 
    SQL = SQL & "    K3421_SalesOrderSeq      = N'" & FormatSQL(z3421.SalesOrderSeq) & "', " 
    SQL = SQL & "    K3421_SalesOrderSno      = N'" & FormatSQL(z3421.SalesOrderSno) & "', " 
    SQL = SQL & "    K3421_Remark      = N'" & FormatSQL(z3421.Remark) & "', " 
    SQL = SQL & "    K3421_ComponentList      = N'" & FormatSQL(z3421.ComponentList) & "', " 
    SQL = SQL & "    K3421_seSite      = N'" & FormatSQL(z3421.seSite) & "', " 
    SQL = SQL & "    K3421_cdSite      = N'" & FormatSQL(z3421.cdSite) & "'  " 
    SQL = SQL & " WHERE K3421_FactOrderNo		 = '" & z3421.FactOrderNo & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
	REWRITE_PFK3421 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK3421",vbCritical)
Finally
        Call GetFullInformation("PFK3421", "U", SQL)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK3421(z3421 As T3421_AREA) As Boolean
    DELETE_PFK3421 = False

   Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z3421)
      
        SQL = " DELETE FROM PFK3421  "
    SQL = SQL & " WHERE K3421_FactOrderNo		 = '" & z3421.FactOrderNo & "' " 

    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK3421 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK3421",vbCritical)
Finally
        Call GetFullInformation("PFK3421", "U", SQL)
  End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D3421_CLEAR()
Try
    
   D3421.FactOrderNo = ""
   D3421.FactOrderName = ""
   D3421.seSeason = ""
   D3421.cdSeason = ""
   D3421.CustomerCode = ""
   D3421.DateAccept = ""
   D3421.CheckInPurchasingOrder = ""
   D3421.CheckOutPurchasingOrder = ""
   D3421.CheckProcessType = ""
   D3421.CheckIOType = ""
   D3421.CheckMaterialType = ""
   D3421.CheckMarketType = ""
   D3421.CheckRelationType = ""
   D3421.SupplierCode = ""
   D3421.selUnitPrice = ""
   D3421.cdUnitPrice = ""
    D3421.PriceExchange = 0 
   D3421.DateExchange = ""
   D3421.seOrigin = ""
   D3421.cdOrigin = ""
   D3421.seCommercialTerm = ""
   D3421.cdCommercialTerm = ""
   D3421.seDeliveryTerm = ""
   D3421.cdDeliveryTerm = ""
   D3421.sePaymentTerm = ""
   D3421.cdPaymentTerm = ""
   D3421.sePaymentCondition = ""
   D3421.cdPaymentCondition = ""
   D3421.sePaymentTime = ""
   D3421.cdPaymentTime = ""
   D3421.sePaymentDay = ""
   D3421.cdPaymentDay = ""
   D3421.seBuyingType = ""
   D3421.cdBuyingType = ""
   D3421.QualityRequest = ""
   D3421.ContractNo = ""
   D3421.Tolerance = ""
   D3421.Destination = ""
   D3421.InchargePurchasing = ""
    D3421.AmountPurchasingEX = 0 
    D3421.AmountPurchasingVND = 0 
    D3421.AmountTaxEX = 0 
    D3421.AmountTaxVND = 0 
    D3421.AmountExpenseUSD = 0 
    D3421.AmountExpenseVND = 0 
    D3421.AmountTotalEX = 0 
    D3421.AmountTotalVND = 0 
   D3421.DateStart = ""
   D3421.DateEstimate = ""
   D3421.DateDelivery = ""
   D3421.DateInsert = ""
   D3421.DateUpdate = ""
   D3421.InchargeInsert = ""
   D3421.InchargeUpdate = ""
   D3421.CheckComplete = ""
   D3421.PurchasingOrderNo = ""
   D3421.SalesOrderNo = ""
   D3421.SalesOrderSeq = ""
   D3421.SalesOrderSno = ""
   D3421.Remark = ""
   D3421.ComponentList = ""
   D3421.seSite = ""
   D3421.cdSite = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D3421_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x3421 As T3421_AREA)
Try
    
    x3421.FactOrderNo = trim$(  x3421.FactOrderNo)
    x3421.FactOrderName = trim$(  x3421.FactOrderName)
    x3421.seSeason = trim$(  x3421.seSeason)
    x3421.cdSeason = trim$(  x3421.cdSeason)
    x3421.CustomerCode = trim$(  x3421.CustomerCode)
    x3421.DateAccept = trim$(  x3421.DateAccept)
    x3421.CheckInPurchasingOrder = trim$(  x3421.CheckInPurchasingOrder)
    x3421.CheckOutPurchasingOrder = trim$(  x3421.CheckOutPurchasingOrder)
    x3421.CheckProcessType = trim$(  x3421.CheckProcessType)
    x3421.CheckIOType = trim$(  x3421.CheckIOType)
    x3421.CheckMaterialType = trim$(  x3421.CheckMaterialType)
    x3421.CheckMarketType = trim$(  x3421.CheckMarketType)
    x3421.CheckRelationType = trim$(  x3421.CheckRelationType)
    x3421.SupplierCode = trim$(  x3421.SupplierCode)
    x3421.selUnitPrice = trim$(  x3421.selUnitPrice)
    x3421.cdUnitPrice = trim$(  x3421.cdUnitPrice)
    x3421.PriceExchange = trim$(  x3421.PriceExchange)
    x3421.DateExchange = trim$(  x3421.DateExchange)
    x3421.seOrigin = trim$(  x3421.seOrigin)
    x3421.cdOrigin = trim$(  x3421.cdOrigin)
    x3421.seCommercialTerm = trim$(  x3421.seCommercialTerm)
    x3421.cdCommercialTerm = trim$(  x3421.cdCommercialTerm)
    x3421.seDeliveryTerm = trim$(  x3421.seDeliveryTerm)
    x3421.cdDeliveryTerm = trim$(  x3421.cdDeliveryTerm)
    x3421.sePaymentTerm = trim$(  x3421.sePaymentTerm)
    x3421.cdPaymentTerm = trim$(  x3421.cdPaymentTerm)
    x3421.sePaymentCondition = trim$(  x3421.sePaymentCondition)
    x3421.cdPaymentCondition = trim$(  x3421.cdPaymentCondition)
    x3421.sePaymentTime = trim$(  x3421.sePaymentTime)
    x3421.cdPaymentTime = trim$(  x3421.cdPaymentTime)
    x3421.sePaymentDay = trim$(  x3421.sePaymentDay)
    x3421.cdPaymentDay = trim$(  x3421.cdPaymentDay)
    x3421.seBuyingType = trim$(  x3421.seBuyingType)
    x3421.cdBuyingType = trim$(  x3421.cdBuyingType)
    x3421.QualityRequest = trim$(  x3421.QualityRequest)
    x3421.ContractNo = trim$(  x3421.ContractNo)
    x3421.Tolerance = trim$(  x3421.Tolerance)
    x3421.Destination = trim$(  x3421.Destination)
    x3421.InchargePurchasing = trim$(  x3421.InchargePurchasing)
    x3421.AmountPurchasingEX = trim$(  x3421.AmountPurchasingEX)
    x3421.AmountPurchasingVND = trim$(  x3421.AmountPurchasingVND)
    x3421.AmountTaxEX = trim$(  x3421.AmountTaxEX)
    x3421.AmountTaxVND = trim$(  x3421.AmountTaxVND)
    x3421.AmountExpenseUSD = trim$(  x3421.AmountExpenseUSD)
    x3421.AmountExpenseVND = trim$(  x3421.AmountExpenseVND)
    x3421.AmountTotalEX = trim$(  x3421.AmountTotalEX)
    x3421.AmountTotalVND = trim$(  x3421.AmountTotalVND)
    x3421.DateStart = trim$(  x3421.DateStart)
    x3421.DateEstimate = trim$(  x3421.DateEstimate)
    x3421.DateDelivery = trim$(  x3421.DateDelivery)
    x3421.DateInsert = trim$(  x3421.DateInsert)
    x3421.DateUpdate = trim$(  x3421.DateUpdate)
    x3421.InchargeInsert = trim$(  x3421.InchargeInsert)
    x3421.InchargeUpdate = trim$(  x3421.InchargeUpdate)
    x3421.CheckComplete = trim$(  x3421.CheckComplete)
    x3421.PurchasingOrderNo = trim$(  x3421.PurchasingOrderNo)
    x3421.SalesOrderNo = trim$(  x3421.SalesOrderNo)
    x3421.SalesOrderSeq = trim$(  x3421.SalesOrderSeq)
    x3421.SalesOrderSno = trim$(  x3421.SalesOrderSno)
    x3421.Remark = trim$(  x3421.Remark)
    x3421.ComponentList = trim$(  x3421.ComponentList)
    x3421.seSite = trim$(  x3421.seSite)
    x3421.cdSite = trim$(  x3421.cdSite)
     
    If trim$( x3421.FactOrderNo ) = "" Then x3421.FactOrderNo = Space(1) 
    If trim$( x3421.FactOrderName ) = "" Then x3421.FactOrderName = Space(1) 
    If trim$( x3421.seSeason ) = "" Then x3421.seSeason = Space(1) 
    If trim$( x3421.cdSeason ) = "" Then x3421.cdSeason = Space(1) 
    If trim$( x3421.CustomerCode ) = "" Then x3421.CustomerCode = Space(1) 
    If trim$( x3421.DateAccept ) = "" Then x3421.DateAccept = Space(1) 
    If trim$( x3421.CheckInPurchasingOrder ) = "" Then x3421.CheckInPurchasingOrder = Space(1) 
    If trim$( x3421.CheckOutPurchasingOrder ) = "" Then x3421.CheckOutPurchasingOrder = Space(1) 
    If trim$( x3421.CheckProcessType ) = "" Then x3421.CheckProcessType = Space(1) 
    If trim$( x3421.CheckIOType ) = "" Then x3421.CheckIOType = Space(1) 
    If trim$( x3421.CheckMaterialType ) = "" Then x3421.CheckMaterialType = Space(1) 
    If trim$( x3421.CheckMarketType ) = "" Then x3421.CheckMarketType = Space(1) 
    If trim$( x3421.CheckRelationType ) = "" Then x3421.CheckRelationType = Space(1) 
    If trim$( x3421.SupplierCode ) = "" Then x3421.SupplierCode = Space(1) 
    If trim$( x3421.selUnitPrice ) = "" Then x3421.selUnitPrice = Space(1) 
    If trim$( x3421.cdUnitPrice ) = "" Then x3421.cdUnitPrice = Space(1) 
    If trim$( x3421.PriceExchange ) = "" Then x3421.PriceExchange = 0 
    If trim$( x3421.DateExchange ) = "" Then x3421.DateExchange = Space(1) 
    If trim$( x3421.seOrigin ) = "" Then x3421.seOrigin = Space(1) 
    If trim$( x3421.cdOrigin ) = "" Then x3421.cdOrigin = Space(1) 
    If trim$( x3421.seCommercialTerm ) = "" Then x3421.seCommercialTerm = Space(1) 
    If trim$( x3421.cdCommercialTerm ) = "" Then x3421.cdCommercialTerm = Space(1) 
    If trim$( x3421.seDeliveryTerm ) = "" Then x3421.seDeliveryTerm = Space(1) 
    If trim$( x3421.cdDeliveryTerm ) = "" Then x3421.cdDeliveryTerm = Space(1) 
    If trim$( x3421.sePaymentTerm ) = "" Then x3421.sePaymentTerm = Space(1) 
    If trim$( x3421.cdPaymentTerm ) = "" Then x3421.cdPaymentTerm = Space(1) 
    If trim$( x3421.sePaymentCondition ) = "" Then x3421.sePaymentCondition = Space(1) 
    If trim$( x3421.cdPaymentCondition ) = "" Then x3421.cdPaymentCondition = Space(1) 
    If trim$( x3421.sePaymentTime ) = "" Then x3421.sePaymentTime = Space(1) 
    If trim$( x3421.cdPaymentTime ) = "" Then x3421.cdPaymentTime = Space(1) 
    If trim$( x3421.sePaymentDay ) = "" Then x3421.sePaymentDay = Space(1) 
    If trim$( x3421.cdPaymentDay ) = "" Then x3421.cdPaymentDay = Space(1) 
    If trim$( x3421.seBuyingType ) = "" Then x3421.seBuyingType = Space(1) 
    If trim$( x3421.cdBuyingType ) = "" Then x3421.cdBuyingType = Space(1) 
    If trim$( x3421.QualityRequest ) = "" Then x3421.QualityRequest = Space(1) 
    If trim$( x3421.ContractNo ) = "" Then x3421.ContractNo = Space(1) 
    If trim$( x3421.Tolerance ) = "" Then x3421.Tolerance = Space(1) 
    If trim$( x3421.Destination ) = "" Then x3421.Destination = Space(1) 
    If trim$( x3421.InchargePurchasing ) = "" Then x3421.InchargePurchasing = Space(1) 
    If trim$( x3421.AmountPurchasingEX ) = "" Then x3421.AmountPurchasingEX = 0 
    If trim$( x3421.AmountPurchasingVND ) = "" Then x3421.AmountPurchasingVND = 0 
    If trim$( x3421.AmountTaxEX ) = "" Then x3421.AmountTaxEX = 0 
    If trim$( x3421.AmountTaxVND ) = "" Then x3421.AmountTaxVND = 0 
    If trim$( x3421.AmountExpenseUSD ) = "" Then x3421.AmountExpenseUSD = 0 
    If trim$( x3421.AmountExpenseVND ) = "" Then x3421.AmountExpenseVND = 0 
    If trim$( x3421.AmountTotalEX ) = "" Then x3421.AmountTotalEX = 0 
    If trim$( x3421.AmountTotalVND ) = "" Then x3421.AmountTotalVND = 0 
    If trim$( x3421.DateStart ) = "" Then x3421.DateStart = Space(1) 
    If trim$( x3421.DateEstimate ) = "" Then x3421.DateEstimate = Space(1) 
    If trim$( x3421.DateDelivery ) = "" Then x3421.DateDelivery = Space(1) 
    If trim$( x3421.DateInsert ) = "" Then x3421.DateInsert = Space(1) 
    If trim$( x3421.DateUpdate ) = "" Then x3421.DateUpdate = Space(1) 
    If trim$( x3421.InchargeInsert ) = "" Then x3421.InchargeInsert = Space(1) 
    If trim$( x3421.InchargeUpdate ) = "" Then x3421.InchargeUpdate = Space(1) 
    If trim$( x3421.CheckComplete ) = "" Then x3421.CheckComplete = Space(1) 
    If trim$( x3421.PurchasingOrderNo ) = "" Then x3421.PurchasingOrderNo = Space(1) 
    If trim$( x3421.SalesOrderNo ) = "" Then x3421.SalesOrderNo = Space(1) 
    If trim$( x3421.SalesOrderSeq ) = "" Then x3421.SalesOrderSeq = Space(1) 
    If trim$( x3421.SalesOrderSno ) = "" Then x3421.SalesOrderSno = Space(1) 
    If trim$( x3421.Remark ) = "" Then x3421.Remark = Space(1) 
    If trim$( x3421.ComponentList ) = "" Then x3421.ComponentList = Space(1) 
    If trim$( x3421.seSite ) = "" Then x3421.seSite = Space(1) 
    If trim$( x3421.cdSite ) = "" Then x3421.cdSite = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K3421_MOVE(rs3421 As SqlClient.SqlDataReader)
Try

    call D3421_CLEAR()   

    If IsdbNull(rs3421!K3421_FactOrderNo) = False Then D3421.FactOrderNo = Trim$(rs3421!K3421_FactOrderNo)
    If IsdbNull(rs3421!K3421_FactOrderName) = False Then D3421.FactOrderName = Trim$(rs3421!K3421_FactOrderName)
    If IsdbNull(rs3421!K3421_seSeason) = False Then D3421.seSeason = Trim$(rs3421!K3421_seSeason)
    If IsdbNull(rs3421!K3421_cdSeason) = False Then D3421.cdSeason = Trim$(rs3421!K3421_cdSeason)
    If IsdbNull(rs3421!K3421_CustomerCode) = False Then D3421.CustomerCode = Trim$(rs3421!K3421_CustomerCode)
    If IsdbNull(rs3421!K3421_DateAccept) = False Then D3421.DateAccept = Trim$(rs3421!K3421_DateAccept)
    If IsdbNull(rs3421!K3421_CheckInPurchasingOrder) = False Then D3421.CheckInPurchasingOrder = Trim$(rs3421!K3421_CheckInPurchasingOrder)
    If IsdbNull(rs3421!K3421_CheckOutPurchasingOrder) = False Then D3421.CheckOutPurchasingOrder = Trim$(rs3421!K3421_CheckOutPurchasingOrder)
    If IsdbNull(rs3421!K3421_CheckProcessType) = False Then D3421.CheckProcessType = Trim$(rs3421!K3421_CheckProcessType)
    If IsdbNull(rs3421!K3421_CheckIOType) = False Then D3421.CheckIOType = Trim$(rs3421!K3421_CheckIOType)
    If IsdbNull(rs3421!K3421_CheckMaterialType) = False Then D3421.CheckMaterialType = Trim$(rs3421!K3421_CheckMaterialType)
    If IsdbNull(rs3421!K3421_CheckMarketType) = False Then D3421.CheckMarketType = Trim$(rs3421!K3421_CheckMarketType)
    If IsdbNull(rs3421!K3421_CheckRelationType) = False Then D3421.CheckRelationType = Trim$(rs3421!K3421_CheckRelationType)
    If IsdbNull(rs3421!K3421_SupplierCode) = False Then D3421.SupplierCode = Trim$(rs3421!K3421_SupplierCode)
    If IsdbNull(rs3421!K3421_selUnitPrice) = False Then D3421.selUnitPrice = Trim$(rs3421!K3421_selUnitPrice)
    If IsdbNull(rs3421!K3421_cdUnitPrice) = False Then D3421.cdUnitPrice = Trim$(rs3421!K3421_cdUnitPrice)
    If IsdbNull(rs3421!K3421_PriceExchange) = False Then D3421.PriceExchange = Trim$(rs3421!K3421_PriceExchange)
    If IsdbNull(rs3421!K3421_DateExchange) = False Then D3421.DateExchange = Trim$(rs3421!K3421_DateExchange)
    If IsdbNull(rs3421!K3421_seOrigin) = False Then D3421.seOrigin = Trim$(rs3421!K3421_seOrigin)
    If IsdbNull(rs3421!K3421_cdOrigin) = False Then D3421.cdOrigin = Trim$(rs3421!K3421_cdOrigin)
    If IsdbNull(rs3421!K3421_seCommercialTerm) = False Then D3421.seCommercialTerm = Trim$(rs3421!K3421_seCommercialTerm)
    If IsdbNull(rs3421!K3421_cdCommercialTerm) = False Then D3421.cdCommercialTerm = Trim$(rs3421!K3421_cdCommercialTerm)
    If IsdbNull(rs3421!K3421_seDeliveryTerm) = False Then D3421.seDeliveryTerm = Trim$(rs3421!K3421_seDeliveryTerm)
    If IsdbNull(rs3421!K3421_cdDeliveryTerm) = False Then D3421.cdDeliveryTerm = Trim$(rs3421!K3421_cdDeliveryTerm)
    If IsdbNull(rs3421!K3421_sePaymentTerm) = False Then D3421.sePaymentTerm = Trim$(rs3421!K3421_sePaymentTerm)
    If IsdbNull(rs3421!K3421_cdPaymentTerm) = False Then D3421.cdPaymentTerm = Trim$(rs3421!K3421_cdPaymentTerm)
    If IsdbNull(rs3421!K3421_sePaymentCondition) = False Then D3421.sePaymentCondition = Trim$(rs3421!K3421_sePaymentCondition)
    If IsdbNull(rs3421!K3421_cdPaymentCondition) = False Then D3421.cdPaymentCondition = Trim$(rs3421!K3421_cdPaymentCondition)
    If IsdbNull(rs3421!K3421_sePaymentTime) = False Then D3421.sePaymentTime = Trim$(rs3421!K3421_sePaymentTime)
    If IsdbNull(rs3421!K3421_cdPaymentTime) = False Then D3421.cdPaymentTime = Trim$(rs3421!K3421_cdPaymentTime)
    If IsdbNull(rs3421!K3421_sePaymentDay) = False Then D3421.sePaymentDay = Trim$(rs3421!K3421_sePaymentDay)
    If IsdbNull(rs3421!K3421_cdPaymentDay) = False Then D3421.cdPaymentDay = Trim$(rs3421!K3421_cdPaymentDay)
    If IsdbNull(rs3421!K3421_seBuyingType) = False Then D3421.seBuyingType = Trim$(rs3421!K3421_seBuyingType)
    If IsdbNull(rs3421!K3421_cdBuyingType) = False Then D3421.cdBuyingType = Trim$(rs3421!K3421_cdBuyingType)
    If IsdbNull(rs3421!K3421_QualityRequest) = False Then D3421.QualityRequest = Trim$(rs3421!K3421_QualityRequest)
    If IsdbNull(rs3421!K3421_ContractNo) = False Then D3421.ContractNo = Trim$(rs3421!K3421_ContractNo)
    If IsdbNull(rs3421!K3421_Tolerance) = False Then D3421.Tolerance = Trim$(rs3421!K3421_Tolerance)
    If IsdbNull(rs3421!K3421_Destination) = False Then D3421.Destination = Trim$(rs3421!K3421_Destination)
    If IsdbNull(rs3421!K3421_InchargePurchasing) = False Then D3421.InchargePurchasing = Trim$(rs3421!K3421_InchargePurchasing)
    If IsdbNull(rs3421!K3421_AmountPurchasingEX) = False Then D3421.AmountPurchasingEX = Trim$(rs3421!K3421_AmountPurchasingEX)
    If IsdbNull(rs3421!K3421_AmountPurchasingVND) = False Then D3421.AmountPurchasingVND = Trim$(rs3421!K3421_AmountPurchasingVND)
    If IsdbNull(rs3421!K3421_AmountTaxEX) = False Then D3421.AmountTaxEX = Trim$(rs3421!K3421_AmountTaxEX)
    If IsdbNull(rs3421!K3421_AmountTaxVND) = False Then D3421.AmountTaxVND = Trim$(rs3421!K3421_AmountTaxVND)
    If IsdbNull(rs3421!K3421_AmountExpenseUSD) = False Then D3421.AmountExpenseUSD = Trim$(rs3421!K3421_AmountExpenseUSD)
    If IsdbNull(rs3421!K3421_AmountExpenseVND) = False Then D3421.AmountExpenseVND = Trim$(rs3421!K3421_AmountExpenseVND)
    If IsdbNull(rs3421!K3421_AmountTotalEX) = False Then D3421.AmountTotalEX = Trim$(rs3421!K3421_AmountTotalEX)
    If IsdbNull(rs3421!K3421_AmountTotalVND) = False Then D3421.AmountTotalVND = Trim$(rs3421!K3421_AmountTotalVND)
    If IsdbNull(rs3421!K3421_DateStart) = False Then D3421.DateStart = Trim$(rs3421!K3421_DateStart)
    If IsdbNull(rs3421!K3421_DateEstimate) = False Then D3421.DateEstimate = Trim$(rs3421!K3421_DateEstimate)
    If IsdbNull(rs3421!K3421_DateDelivery) = False Then D3421.DateDelivery = Trim$(rs3421!K3421_DateDelivery)
    If IsdbNull(rs3421!K3421_DateInsert) = False Then D3421.DateInsert = Trim$(rs3421!K3421_DateInsert)
    If IsdbNull(rs3421!K3421_DateUpdate) = False Then D3421.DateUpdate = Trim$(rs3421!K3421_DateUpdate)
    If IsdbNull(rs3421!K3421_InchargeInsert) = False Then D3421.InchargeInsert = Trim$(rs3421!K3421_InchargeInsert)
    If IsdbNull(rs3421!K3421_InchargeUpdate) = False Then D3421.InchargeUpdate = Trim$(rs3421!K3421_InchargeUpdate)
    If IsdbNull(rs3421!K3421_CheckComplete) = False Then D3421.CheckComplete = Trim$(rs3421!K3421_CheckComplete)
    If IsdbNull(rs3421!K3421_PurchasingOrderNo) = False Then D3421.PurchasingOrderNo = Trim$(rs3421!K3421_PurchasingOrderNo)
    If IsdbNull(rs3421!K3421_SalesOrderNo) = False Then D3421.SalesOrderNo = Trim$(rs3421!K3421_SalesOrderNo)
    If IsdbNull(rs3421!K3421_SalesOrderSeq) = False Then D3421.SalesOrderSeq = Trim$(rs3421!K3421_SalesOrderSeq)
    If IsdbNull(rs3421!K3421_SalesOrderSno) = False Then D3421.SalesOrderSno = Trim$(rs3421!K3421_SalesOrderSno)
    If IsdbNull(rs3421!K3421_Remark) = False Then D3421.Remark = Trim$(rs3421!K3421_Remark)
    If IsdbNull(rs3421!K3421_ComponentList) = False Then D3421.ComponentList = Trim$(rs3421!K3421_ComponentList)
    If IsdbNull(rs3421!K3421_seSite) = False Then D3421.seSite = Trim$(rs3421!K3421_seSite)
    If IsdbNull(rs3421!K3421_cdSite) = False Then D3421.cdSite = Trim$(rs3421!K3421_cdSite)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K3421_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K3421_MOVE(rs3421 As DataRow)
Try

    call D3421_CLEAR()   

    If IsdbNull(rs3421!K3421_FactOrderNo) = False Then D3421.FactOrderNo = Trim$(rs3421!K3421_FactOrderNo)
    If IsdbNull(rs3421!K3421_FactOrderName) = False Then D3421.FactOrderName = Trim$(rs3421!K3421_FactOrderName)
    If IsdbNull(rs3421!K3421_seSeason) = False Then D3421.seSeason = Trim$(rs3421!K3421_seSeason)
    If IsdbNull(rs3421!K3421_cdSeason) = False Then D3421.cdSeason = Trim$(rs3421!K3421_cdSeason)
    If IsdbNull(rs3421!K3421_CustomerCode) = False Then D3421.CustomerCode = Trim$(rs3421!K3421_CustomerCode)
    If IsdbNull(rs3421!K3421_DateAccept) = False Then D3421.DateAccept = Trim$(rs3421!K3421_DateAccept)
    If IsdbNull(rs3421!K3421_CheckInPurchasingOrder) = False Then D3421.CheckInPurchasingOrder = Trim$(rs3421!K3421_CheckInPurchasingOrder)
    If IsdbNull(rs3421!K3421_CheckOutPurchasingOrder) = False Then D3421.CheckOutPurchasingOrder = Trim$(rs3421!K3421_CheckOutPurchasingOrder)
    If IsdbNull(rs3421!K3421_CheckProcessType) = False Then D3421.CheckProcessType = Trim$(rs3421!K3421_CheckProcessType)
    If IsdbNull(rs3421!K3421_CheckIOType) = False Then D3421.CheckIOType = Trim$(rs3421!K3421_CheckIOType)
    If IsdbNull(rs3421!K3421_CheckMaterialType) = False Then D3421.CheckMaterialType = Trim$(rs3421!K3421_CheckMaterialType)
    If IsdbNull(rs3421!K3421_CheckMarketType) = False Then D3421.CheckMarketType = Trim$(rs3421!K3421_CheckMarketType)
    If IsdbNull(rs3421!K3421_CheckRelationType) = False Then D3421.CheckRelationType = Trim$(rs3421!K3421_CheckRelationType)
    If IsdbNull(rs3421!K3421_SupplierCode) = False Then D3421.SupplierCode = Trim$(rs3421!K3421_SupplierCode)
    If IsdbNull(rs3421!K3421_selUnitPrice) = False Then D3421.selUnitPrice = Trim$(rs3421!K3421_selUnitPrice)
    If IsdbNull(rs3421!K3421_cdUnitPrice) = False Then D3421.cdUnitPrice = Trim$(rs3421!K3421_cdUnitPrice)
    If IsdbNull(rs3421!K3421_PriceExchange) = False Then D3421.PriceExchange = Trim$(rs3421!K3421_PriceExchange)
    If IsdbNull(rs3421!K3421_DateExchange) = False Then D3421.DateExchange = Trim$(rs3421!K3421_DateExchange)
    If IsdbNull(rs3421!K3421_seOrigin) = False Then D3421.seOrigin = Trim$(rs3421!K3421_seOrigin)
    If IsdbNull(rs3421!K3421_cdOrigin) = False Then D3421.cdOrigin = Trim$(rs3421!K3421_cdOrigin)
    If IsdbNull(rs3421!K3421_seCommercialTerm) = False Then D3421.seCommercialTerm = Trim$(rs3421!K3421_seCommercialTerm)
    If IsdbNull(rs3421!K3421_cdCommercialTerm) = False Then D3421.cdCommercialTerm = Trim$(rs3421!K3421_cdCommercialTerm)
    If IsdbNull(rs3421!K3421_seDeliveryTerm) = False Then D3421.seDeliveryTerm = Trim$(rs3421!K3421_seDeliveryTerm)
    If IsdbNull(rs3421!K3421_cdDeliveryTerm) = False Then D3421.cdDeliveryTerm = Trim$(rs3421!K3421_cdDeliveryTerm)
    If IsdbNull(rs3421!K3421_sePaymentTerm) = False Then D3421.sePaymentTerm = Trim$(rs3421!K3421_sePaymentTerm)
    If IsdbNull(rs3421!K3421_cdPaymentTerm) = False Then D3421.cdPaymentTerm = Trim$(rs3421!K3421_cdPaymentTerm)
    If IsdbNull(rs3421!K3421_sePaymentCondition) = False Then D3421.sePaymentCondition = Trim$(rs3421!K3421_sePaymentCondition)
    If IsdbNull(rs3421!K3421_cdPaymentCondition) = False Then D3421.cdPaymentCondition = Trim$(rs3421!K3421_cdPaymentCondition)
    If IsdbNull(rs3421!K3421_sePaymentTime) = False Then D3421.sePaymentTime = Trim$(rs3421!K3421_sePaymentTime)
    If IsdbNull(rs3421!K3421_cdPaymentTime) = False Then D3421.cdPaymentTime = Trim$(rs3421!K3421_cdPaymentTime)
    If IsdbNull(rs3421!K3421_sePaymentDay) = False Then D3421.sePaymentDay = Trim$(rs3421!K3421_sePaymentDay)
    If IsdbNull(rs3421!K3421_cdPaymentDay) = False Then D3421.cdPaymentDay = Trim$(rs3421!K3421_cdPaymentDay)
    If IsdbNull(rs3421!K3421_seBuyingType) = False Then D3421.seBuyingType = Trim$(rs3421!K3421_seBuyingType)
    If IsdbNull(rs3421!K3421_cdBuyingType) = False Then D3421.cdBuyingType = Trim$(rs3421!K3421_cdBuyingType)
    If IsdbNull(rs3421!K3421_QualityRequest) = False Then D3421.QualityRequest = Trim$(rs3421!K3421_QualityRequest)
    If IsdbNull(rs3421!K3421_ContractNo) = False Then D3421.ContractNo = Trim$(rs3421!K3421_ContractNo)
    If IsdbNull(rs3421!K3421_Tolerance) = False Then D3421.Tolerance = Trim$(rs3421!K3421_Tolerance)
    If IsdbNull(rs3421!K3421_Destination) = False Then D3421.Destination = Trim$(rs3421!K3421_Destination)
    If IsdbNull(rs3421!K3421_InchargePurchasing) = False Then D3421.InchargePurchasing = Trim$(rs3421!K3421_InchargePurchasing)
    If IsdbNull(rs3421!K3421_AmountPurchasingEX) = False Then D3421.AmountPurchasingEX = Trim$(rs3421!K3421_AmountPurchasingEX)
    If IsdbNull(rs3421!K3421_AmountPurchasingVND) = False Then D3421.AmountPurchasingVND = Trim$(rs3421!K3421_AmountPurchasingVND)
    If IsdbNull(rs3421!K3421_AmountTaxEX) = False Then D3421.AmountTaxEX = Trim$(rs3421!K3421_AmountTaxEX)
    If IsdbNull(rs3421!K3421_AmountTaxVND) = False Then D3421.AmountTaxVND = Trim$(rs3421!K3421_AmountTaxVND)
    If IsdbNull(rs3421!K3421_AmountExpenseUSD) = False Then D3421.AmountExpenseUSD = Trim$(rs3421!K3421_AmountExpenseUSD)
    If IsdbNull(rs3421!K3421_AmountExpenseVND) = False Then D3421.AmountExpenseVND = Trim$(rs3421!K3421_AmountExpenseVND)
    If IsdbNull(rs3421!K3421_AmountTotalEX) = False Then D3421.AmountTotalEX = Trim$(rs3421!K3421_AmountTotalEX)
    If IsdbNull(rs3421!K3421_AmountTotalVND) = False Then D3421.AmountTotalVND = Trim$(rs3421!K3421_AmountTotalVND)
    If IsdbNull(rs3421!K3421_DateStart) = False Then D3421.DateStart = Trim$(rs3421!K3421_DateStart)
    If IsdbNull(rs3421!K3421_DateEstimate) = False Then D3421.DateEstimate = Trim$(rs3421!K3421_DateEstimate)
    If IsdbNull(rs3421!K3421_DateDelivery) = False Then D3421.DateDelivery = Trim$(rs3421!K3421_DateDelivery)
    If IsdbNull(rs3421!K3421_DateInsert) = False Then D3421.DateInsert = Trim$(rs3421!K3421_DateInsert)
    If IsdbNull(rs3421!K3421_DateUpdate) = False Then D3421.DateUpdate = Trim$(rs3421!K3421_DateUpdate)
    If IsdbNull(rs3421!K3421_InchargeInsert) = False Then D3421.InchargeInsert = Trim$(rs3421!K3421_InchargeInsert)
    If IsdbNull(rs3421!K3421_InchargeUpdate) = False Then D3421.InchargeUpdate = Trim$(rs3421!K3421_InchargeUpdate)
    If IsdbNull(rs3421!K3421_CheckComplete) = False Then D3421.CheckComplete = Trim$(rs3421!K3421_CheckComplete)
    If IsdbNull(rs3421!K3421_PurchasingOrderNo) = False Then D3421.PurchasingOrderNo = Trim$(rs3421!K3421_PurchasingOrderNo)
    If IsdbNull(rs3421!K3421_SalesOrderNo) = False Then D3421.SalesOrderNo = Trim$(rs3421!K3421_SalesOrderNo)
    If IsdbNull(rs3421!K3421_SalesOrderSeq) = False Then D3421.SalesOrderSeq = Trim$(rs3421!K3421_SalesOrderSeq)
    If IsdbNull(rs3421!K3421_SalesOrderSno) = False Then D3421.SalesOrderSno = Trim$(rs3421!K3421_SalesOrderSno)
    If IsdbNull(rs3421!K3421_Remark) = False Then D3421.Remark = Trim$(rs3421!K3421_Remark)
    If IsdbNull(rs3421!K3421_ComponentList) = False Then D3421.ComponentList = Trim$(rs3421!K3421_ComponentList)
    If IsdbNull(rs3421!K3421_seSite) = False Then D3421.seSite = Trim$(rs3421!K3421_seSite)
    If IsdbNull(rs3421!K3421_cdSite) = False Then D3421.cdSite = Trim$(rs3421!K3421_cdSite)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K3421_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K3421_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z3421 As T3421_AREA, FACTORDERNO AS String) as Boolean

K3421_MOVE = False

Try
    If READ_PFK3421(FACTORDERNO) = True Then
                z3421 = D3421
		K3421_MOVE = True
		else
	z3421 = nothing
     End If

     If  getColumnIndex(spr,"FactOrderNo") > -1 then z3421.FactOrderNo = getDataM(spr, getColumnIndex(spr,"FactOrderNo"), xRow)
     If  getColumnIndex(spr,"FactOrderName") > -1 then z3421.FactOrderName = getDataM(spr, getColumnIndex(spr,"FactOrderName"), xRow)
     If  getColumnIndex(spr,"seSeason") > -1 then z3421.seSeason = getDataM(spr, getColumnIndex(spr,"seSeason"), xRow)
     If  getColumnIndex(spr,"cdSeason") > -1 then z3421.cdSeason = getDataM(spr, getColumnIndex(spr,"cdSeason"), xRow)
     If  getColumnIndex(spr,"CustomerCode") > -1 then z3421.CustomerCode = getDataM(spr, getColumnIndex(spr,"CustomerCode"), xRow)
     If  getColumnIndex(spr,"DateAccept") > -1 then z3421.DateAccept = getDataM(spr, getColumnIndex(spr,"DateAccept"), xRow)
     If  getColumnIndex(spr,"CheckInPurchasingOrder") > -1 then z3421.CheckInPurchasingOrder = getDataM(spr, getColumnIndex(spr,"CheckInPurchasingOrder"), xRow)
     If  getColumnIndex(spr,"CheckOutPurchasingOrder") > -1 then z3421.CheckOutPurchasingOrder = getDataM(spr, getColumnIndex(spr,"CheckOutPurchasingOrder"), xRow)
     If  getColumnIndex(spr,"CheckProcessType") > -1 then z3421.CheckProcessType = getDataM(spr, getColumnIndex(spr,"CheckProcessType"), xRow)
     If  getColumnIndex(spr,"CheckIOType") > -1 then z3421.CheckIOType = getDataM(spr, getColumnIndex(spr,"CheckIOType"), xRow)
     If  getColumnIndex(spr,"CheckMaterialType") > -1 then z3421.CheckMaterialType = getDataM(spr, getColumnIndex(spr,"CheckMaterialType"), xRow)
     If  getColumnIndex(spr,"CheckMarketType") > -1 then z3421.CheckMarketType = getDataM(spr, getColumnIndex(spr,"CheckMarketType"), xRow)
     If  getColumnIndex(spr,"CheckRelationType") > -1 then z3421.CheckRelationType = getDataM(spr, getColumnIndex(spr,"CheckRelationType"), xRow)
     If  getColumnIndex(spr,"SupplierCode") > -1 then z3421.SupplierCode = getDataM(spr, getColumnIndex(spr,"SupplierCode"), xRow)
     If  getColumnIndex(spr,"selUnitPrice") > -1 then z3421.selUnitPrice = getDataM(spr, getColumnIndex(spr,"selUnitPrice"), xRow)
     If  getColumnIndex(spr,"cdUnitPrice") > -1 then z3421.cdUnitPrice = getDataM(spr, getColumnIndex(spr,"cdUnitPrice"), xRow)
     If  getColumnIndex(spr,"PriceExchange") > -1 then z3421.PriceExchange = getDataM(spr, getColumnIndex(spr,"PriceExchange"), xRow)
     If  getColumnIndex(spr,"DateExchange") > -1 then z3421.DateExchange = getDataM(spr, getColumnIndex(spr,"DateExchange"), xRow)
     If  getColumnIndex(spr,"seOrigin") > -1 then z3421.seOrigin = getDataM(spr, getColumnIndex(spr,"seOrigin"), xRow)
     If  getColumnIndex(spr,"cdOrigin") > -1 then z3421.cdOrigin = getDataM(spr, getColumnIndex(spr,"cdOrigin"), xRow)
     If  getColumnIndex(spr,"seCommercialTerm") > -1 then z3421.seCommercialTerm = getDataM(spr, getColumnIndex(spr,"seCommercialTerm"), xRow)
     If  getColumnIndex(spr,"cdCommercialTerm") > -1 then z3421.cdCommercialTerm = getDataM(spr, getColumnIndex(spr,"cdCommercialTerm"), xRow)
     If  getColumnIndex(spr,"seDeliveryTerm") > -1 then z3421.seDeliveryTerm = getDataM(spr, getColumnIndex(spr,"seDeliveryTerm"), xRow)
     If  getColumnIndex(spr,"cdDeliveryTerm") > -1 then z3421.cdDeliveryTerm = getDataM(spr, getColumnIndex(spr,"cdDeliveryTerm"), xRow)
     If  getColumnIndex(spr,"sePaymentTerm") > -1 then z3421.sePaymentTerm = getDataM(spr, getColumnIndex(spr,"sePaymentTerm"), xRow)
     If  getColumnIndex(spr,"cdPaymentTerm") > -1 then z3421.cdPaymentTerm = getDataM(spr, getColumnIndex(spr,"cdPaymentTerm"), xRow)
     If  getColumnIndex(spr,"sePaymentCondition") > -1 then z3421.sePaymentCondition = getDataM(spr, getColumnIndex(spr,"sePaymentCondition"), xRow)
     If  getColumnIndex(spr,"cdPaymentCondition") > -1 then z3421.cdPaymentCondition = getDataM(spr, getColumnIndex(spr,"cdPaymentCondition"), xRow)
     If  getColumnIndex(spr,"sePaymentTime") > -1 then z3421.sePaymentTime = getDataM(spr, getColumnIndex(spr,"sePaymentTime"), xRow)
     If  getColumnIndex(spr,"cdPaymentTime") > -1 then z3421.cdPaymentTime = getDataM(spr, getColumnIndex(spr,"cdPaymentTime"), xRow)
     If  getColumnIndex(spr,"sePaymentDay") > -1 then z3421.sePaymentDay = getDataM(spr, getColumnIndex(spr,"sePaymentDay"), xRow)
     If  getColumnIndex(spr,"cdPaymentDay") > -1 then z3421.cdPaymentDay = getDataM(spr, getColumnIndex(spr,"cdPaymentDay"), xRow)
     If  getColumnIndex(spr,"seBuyingType") > -1 then z3421.seBuyingType = getDataM(spr, getColumnIndex(spr,"seBuyingType"), xRow)
     If  getColumnIndex(spr,"cdBuyingType") > -1 then z3421.cdBuyingType = getDataM(spr, getColumnIndex(spr,"cdBuyingType"), xRow)
     If  getColumnIndex(spr,"QualityRequest") > -1 then z3421.QualityRequest = getDataM(spr, getColumnIndex(spr,"QualityRequest"), xRow)
     If  getColumnIndex(spr,"ContractNo") > -1 then z3421.ContractNo = getDataM(spr, getColumnIndex(spr,"ContractNo"), xRow)
     If  getColumnIndex(spr,"Tolerance") > -1 then z3421.Tolerance = getDataM(spr, getColumnIndex(spr,"Tolerance"), xRow)
     If  getColumnIndex(spr,"Destination") > -1 then z3421.Destination = getDataM(spr, getColumnIndex(spr,"Destination"), xRow)
     If  getColumnIndex(spr,"InchargePurchasing") > -1 then z3421.InchargePurchasing = getDataM(spr, getColumnIndex(spr,"InchargePurchasing"), xRow)
     If  getColumnIndex(spr,"AmountPurchasingEX") > -1 then z3421.AmountPurchasingEX = getDataM(spr, getColumnIndex(spr,"AmountPurchasingEX"), xRow)
     If  getColumnIndex(spr,"AmountPurchasingVND") > -1 then z3421.AmountPurchasingVND = getDataM(spr, getColumnIndex(spr,"AmountPurchasingVND"), xRow)
     If  getColumnIndex(spr,"AmountTaxEX") > -1 then z3421.AmountTaxEX = getDataM(spr, getColumnIndex(spr,"AmountTaxEX"), xRow)
     If  getColumnIndex(spr,"AmountTaxVND") > -1 then z3421.AmountTaxVND = getDataM(spr, getColumnIndex(spr,"AmountTaxVND"), xRow)
     If  getColumnIndex(spr,"AmountExpenseUSD") > -1 then z3421.AmountExpenseUSD = getDataM(spr, getColumnIndex(spr,"AmountExpenseUSD"), xRow)
     If  getColumnIndex(spr,"AmountExpenseVND") > -1 then z3421.AmountExpenseVND = getDataM(spr, getColumnIndex(spr,"AmountExpenseVND"), xRow)
     If  getColumnIndex(spr,"AmountTotalEX") > -1 then z3421.AmountTotalEX = getDataM(spr, getColumnIndex(spr,"AmountTotalEX"), xRow)
     If  getColumnIndex(spr,"AmountTotalVND") > -1 then z3421.AmountTotalVND = getDataM(spr, getColumnIndex(spr,"AmountTotalVND"), xRow)
     If  getColumnIndex(spr,"DateStart") > -1 then z3421.DateStart = getDataM(spr, getColumnIndex(spr,"DateStart"), xRow)
     If  getColumnIndex(spr,"DateEstimate") > -1 then z3421.DateEstimate = getDataM(spr, getColumnIndex(spr,"DateEstimate"), xRow)
     If  getColumnIndex(spr,"DateDelivery") > -1 then z3421.DateDelivery = getDataM(spr, getColumnIndex(spr,"DateDelivery"), xRow)
     If  getColumnIndex(spr,"DateInsert") > -1 then z3421.DateInsert = getDataM(spr, getColumnIndex(spr,"DateInsert"), xRow)
     If  getColumnIndex(spr,"DateUpdate") > -1 then z3421.DateUpdate = getDataM(spr, getColumnIndex(spr,"DateUpdate"), xRow)
     If  getColumnIndex(spr,"InchargeInsert") > -1 then z3421.InchargeInsert = getDataM(spr, getColumnIndex(spr,"InchargeInsert"), xRow)
     If  getColumnIndex(spr,"InchargeUpdate") > -1 then z3421.InchargeUpdate = getDataM(spr, getColumnIndex(spr,"InchargeUpdate"), xRow)
     If  getColumnIndex(spr,"CheckComplete") > -1 then z3421.CheckComplete = getDataM(spr, getColumnIndex(spr,"CheckComplete"), xRow)
     If  getColumnIndex(spr,"PurchasingOrderNo") > -1 then z3421.PurchasingOrderNo = getDataM(spr, getColumnIndex(spr,"PurchasingOrderNo"), xRow)
     If  getColumnIndex(spr,"SalesOrderNo") > -1 then z3421.SalesOrderNo = getDataM(spr, getColumnIndex(spr,"SalesOrderNo"), xRow)
     If  getColumnIndex(spr,"SalesOrderSeq") > -1 then z3421.SalesOrderSeq = getDataM(spr, getColumnIndex(spr,"SalesOrderSeq"), xRow)
     If  getColumnIndex(spr,"SalesOrderSno") > -1 then z3421.SalesOrderSno = getDataM(spr, getColumnIndex(spr,"SalesOrderSno"), xRow)
     If  getColumnIndex(spr,"Remark") > -1 then z3421.Remark = getDataM(spr, getColumnIndex(spr,"Remark"), xRow)
     If  getColumnIndex(spr,"ComponentList") > -1 then z3421.ComponentList = getDataM(spr, getColumnIndex(spr,"ComponentList"), xRow)
     If  getColumnIndex(spr,"seSite") > -1 then z3421.seSite = getDataM(spr, getColumnIndex(spr,"seSite"), xRow)
     If  getColumnIndex(spr,"cdSite") > -1 then z3421.cdSite = getDataM(spr, getColumnIndex(spr,"cdSite"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K3421_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K3421_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z3421 As T3421_AREA,CheckClear as Boolean,FACTORDERNO AS String) as Boolean

K3421_MOVE = False

Try
    If READ_PFK3421(FACTORDERNO) = True Then
                z3421 = D3421
		K3421_MOVE = True
		else
	If CheckClear  = True then z3421 = nothing
     End If

     If  getColumnIndex(spr,"FactOrderNo") > -1 then z3421.FactOrderNo = getDataM(spr, getColumnIndex(spr,"FactOrderNo"), xRow)
     If  getColumnIndex(spr,"FactOrderName") > -1 then z3421.FactOrderName = getDataM(spr, getColumnIndex(spr,"FactOrderName"), xRow)
     If  getColumnIndex(spr,"seSeason") > -1 then z3421.seSeason = getDataM(spr, getColumnIndex(spr,"seSeason"), xRow)
     If  getColumnIndex(spr,"cdSeason") > -1 then z3421.cdSeason = getDataM(spr, getColumnIndex(spr,"cdSeason"), xRow)
     If  getColumnIndex(spr,"CustomerCode") > -1 then z3421.CustomerCode = getDataM(spr, getColumnIndex(spr,"CustomerCode"), xRow)
     If  getColumnIndex(spr,"DateAccept") > -1 then z3421.DateAccept = getDataM(spr, getColumnIndex(spr,"DateAccept"), xRow)
     If  getColumnIndex(spr,"CheckInPurchasingOrder") > -1 then z3421.CheckInPurchasingOrder = getDataM(spr, getColumnIndex(spr,"CheckInPurchasingOrder"), xRow)
     If  getColumnIndex(spr,"CheckOutPurchasingOrder") > -1 then z3421.CheckOutPurchasingOrder = getDataM(spr, getColumnIndex(spr,"CheckOutPurchasingOrder"), xRow)
     If  getColumnIndex(spr,"CheckProcessType") > -1 then z3421.CheckProcessType = getDataM(spr, getColumnIndex(spr,"CheckProcessType"), xRow)
     If  getColumnIndex(spr,"CheckIOType") > -1 then z3421.CheckIOType = getDataM(spr, getColumnIndex(spr,"CheckIOType"), xRow)
     If  getColumnIndex(spr,"CheckMaterialType") > -1 then z3421.CheckMaterialType = getDataM(spr, getColumnIndex(spr,"CheckMaterialType"), xRow)
     If  getColumnIndex(spr,"CheckMarketType") > -1 then z3421.CheckMarketType = getDataM(spr, getColumnIndex(spr,"CheckMarketType"), xRow)
     If  getColumnIndex(spr,"CheckRelationType") > -1 then z3421.CheckRelationType = getDataM(spr, getColumnIndex(spr,"CheckRelationType"), xRow)
     If  getColumnIndex(spr,"SupplierCode") > -1 then z3421.SupplierCode = getDataM(spr, getColumnIndex(spr,"SupplierCode"), xRow)
     If  getColumnIndex(spr,"selUnitPrice") > -1 then z3421.selUnitPrice = getDataM(spr, getColumnIndex(spr,"selUnitPrice"), xRow)
     If  getColumnIndex(spr,"cdUnitPrice") > -1 then z3421.cdUnitPrice = getDataM(spr, getColumnIndex(spr,"cdUnitPrice"), xRow)
     If  getColumnIndex(spr,"PriceExchange") > -1 then z3421.PriceExchange = getDataM(spr, getColumnIndex(spr,"PriceExchange"), xRow)
     If  getColumnIndex(spr,"DateExchange") > -1 then z3421.DateExchange = getDataM(spr, getColumnIndex(spr,"DateExchange"), xRow)
     If  getColumnIndex(spr,"seOrigin") > -1 then z3421.seOrigin = getDataM(spr, getColumnIndex(spr,"seOrigin"), xRow)
     If  getColumnIndex(spr,"cdOrigin") > -1 then z3421.cdOrigin = getDataM(spr, getColumnIndex(spr,"cdOrigin"), xRow)
     If  getColumnIndex(spr,"seCommercialTerm") > -1 then z3421.seCommercialTerm = getDataM(spr, getColumnIndex(spr,"seCommercialTerm"), xRow)
     If  getColumnIndex(spr,"cdCommercialTerm") > -1 then z3421.cdCommercialTerm = getDataM(spr, getColumnIndex(spr,"cdCommercialTerm"), xRow)
     If  getColumnIndex(spr,"seDeliveryTerm") > -1 then z3421.seDeliveryTerm = getDataM(spr, getColumnIndex(spr,"seDeliveryTerm"), xRow)
     If  getColumnIndex(spr,"cdDeliveryTerm") > -1 then z3421.cdDeliveryTerm = getDataM(spr, getColumnIndex(spr,"cdDeliveryTerm"), xRow)
     If  getColumnIndex(spr,"sePaymentTerm") > -1 then z3421.sePaymentTerm = getDataM(spr, getColumnIndex(spr,"sePaymentTerm"), xRow)
     If  getColumnIndex(spr,"cdPaymentTerm") > -1 then z3421.cdPaymentTerm = getDataM(spr, getColumnIndex(spr,"cdPaymentTerm"), xRow)
     If  getColumnIndex(spr,"sePaymentCondition") > -1 then z3421.sePaymentCondition = getDataM(spr, getColumnIndex(spr,"sePaymentCondition"), xRow)
     If  getColumnIndex(spr,"cdPaymentCondition") > -1 then z3421.cdPaymentCondition = getDataM(spr, getColumnIndex(spr,"cdPaymentCondition"), xRow)
     If  getColumnIndex(spr,"sePaymentTime") > -1 then z3421.sePaymentTime = getDataM(spr, getColumnIndex(spr,"sePaymentTime"), xRow)
     If  getColumnIndex(spr,"cdPaymentTime") > -1 then z3421.cdPaymentTime = getDataM(spr, getColumnIndex(spr,"cdPaymentTime"), xRow)
     If  getColumnIndex(spr,"sePaymentDay") > -1 then z3421.sePaymentDay = getDataM(spr, getColumnIndex(spr,"sePaymentDay"), xRow)
     If  getColumnIndex(spr,"cdPaymentDay") > -1 then z3421.cdPaymentDay = getDataM(spr, getColumnIndex(spr,"cdPaymentDay"), xRow)
     If  getColumnIndex(spr,"seBuyingType") > -1 then z3421.seBuyingType = getDataM(spr, getColumnIndex(spr,"seBuyingType"), xRow)
     If  getColumnIndex(spr,"cdBuyingType") > -1 then z3421.cdBuyingType = getDataM(spr, getColumnIndex(spr,"cdBuyingType"), xRow)
     If  getColumnIndex(spr,"QualityRequest") > -1 then z3421.QualityRequest = getDataM(spr, getColumnIndex(spr,"QualityRequest"), xRow)
     If  getColumnIndex(spr,"ContractNo") > -1 then z3421.ContractNo = getDataM(spr, getColumnIndex(spr,"ContractNo"), xRow)
     If  getColumnIndex(spr,"Tolerance") > -1 then z3421.Tolerance = getDataM(spr, getColumnIndex(spr,"Tolerance"), xRow)
     If  getColumnIndex(spr,"Destination") > -1 then z3421.Destination = getDataM(spr, getColumnIndex(spr,"Destination"), xRow)
     If  getColumnIndex(spr,"InchargePurchasing") > -1 then z3421.InchargePurchasing = getDataM(spr, getColumnIndex(spr,"InchargePurchasing"), xRow)
     If  getColumnIndex(spr,"AmountPurchasingEX") > -1 then z3421.AmountPurchasingEX = getDataM(spr, getColumnIndex(spr,"AmountPurchasingEX"), xRow)
     If  getColumnIndex(spr,"AmountPurchasingVND") > -1 then z3421.AmountPurchasingVND = getDataM(spr, getColumnIndex(spr,"AmountPurchasingVND"), xRow)
     If  getColumnIndex(spr,"AmountTaxEX") > -1 then z3421.AmountTaxEX = getDataM(spr, getColumnIndex(spr,"AmountTaxEX"), xRow)
     If  getColumnIndex(spr,"AmountTaxVND") > -1 then z3421.AmountTaxVND = getDataM(spr, getColumnIndex(spr,"AmountTaxVND"), xRow)
     If  getColumnIndex(spr,"AmountExpenseUSD") > -1 then z3421.AmountExpenseUSD = getDataM(spr, getColumnIndex(spr,"AmountExpenseUSD"), xRow)
     If  getColumnIndex(spr,"AmountExpenseVND") > -1 then z3421.AmountExpenseVND = getDataM(spr, getColumnIndex(spr,"AmountExpenseVND"), xRow)
     If  getColumnIndex(spr,"AmountTotalEX") > -1 then z3421.AmountTotalEX = getDataM(spr, getColumnIndex(spr,"AmountTotalEX"), xRow)
     If  getColumnIndex(spr,"AmountTotalVND") > -1 then z3421.AmountTotalVND = getDataM(spr, getColumnIndex(spr,"AmountTotalVND"), xRow)
     If  getColumnIndex(spr,"DateStart") > -1 then z3421.DateStart = getDataM(spr, getColumnIndex(spr,"DateStart"), xRow)
     If  getColumnIndex(spr,"DateEstimate") > -1 then z3421.DateEstimate = getDataM(spr, getColumnIndex(spr,"DateEstimate"), xRow)
     If  getColumnIndex(spr,"DateDelivery") > -1 then z3421.DateDelivery = getDataM(spr, getColumnIndex(spr,"DateDelivery"), xRow)
     If  getColumnIndex(spr,"DateInsert") > -1 then z3421.DateInsert = getDataM(spr, getColumnIndex(spr,"DateInsert"), xRow)
     If  getColumnIndex(spr,"DateUpdate") > -1 then z3421.DateUpdate = getDataM(spr, getColumnIndex(spr,"DateUpdate"), xRow)
     If  getColumnIndex(spr,"InchargeInsert") > -1 then z3421.InchargeInsert = getDataM(spr, getColumnIndex(spr,"InchargeInsert"), xRow)
     If  getColumnIndex(spr,"InchargeUpdate") > -1 then z3421.InchargeUpdate = getDataM(spr, getColumnIndex(spr,"InchargeUpdate"), xRow)
     If  getColumnIndex(spr,"CheckComplete") > -1 then z3421.CheckComplete = getDataM(spr, getColumnIndex(spr,"CheckComplete"), xRow)
     If  getColumnIndex(spr,"PurchasingOrderNo") > -1 then z3421.PurchasingOrderNo = getDataM(spr, getColumnIndex(spr,"PurchasingOrderNo"), xRow)
     If  getColumnIndex(spr,"SalesOrderNo") > -1 then z3421.SalesOrderNo = getDataM(spr, getColumnIndex(spr,"SalesOrderNo"), xRow)
     If  getColumnIndex(spr,"SalesOrderSeq") > -1 then z3421.SalesOrderSeq = getDataM(spr, getColumnIndex(spr,"SalesOrderSeq"), xRow)
     If  getColumnIndex(spr,"SalesOrderSno") > -1 then z3421.SalesOrderSno = getDataM(spr, getColumnIndex(spr,"SalesOrderSno"), xRow)
     If  getColumnIndex(spr,"Remark") > -1 then z3421.Remark = getDataM(spr, getColumnIndex(spr,"Remark"), xRow)
     If  getColumnIndex(spr,"ComponentList") > -1 then z3421.ComponentList = getDataM(spr, getColumnIndex(spr,"ComponentList"), xRow)
     If  getColumnIndex(spr,"seSite") > -1 then z3421.seSite = getDataM(spr, getColumnIndex(spr,"seSite"), xRow)
     If  getColumnIndex(spr,"cdSite") > -1 then z3421.cdSite = getDataM(spr, getColumnIndex(spr,"cdSite"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K3421_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K3421_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z3421 As T3421_AREA, Job as String, FACTORDERNO AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K3421_MOVE = False

Try
    If READ_PFK3421(FACTORDERNO) = True Then
                z3421 = D3421
		K3421_MOVE = True
		else
	z3421 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3421")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "FACTORDERNO":z3421.FactOrderNo = Children(i).Code
   Case "FACTORDERNAME":z3421.FactOrderName = Children(i).Code
   Case "SESEASON":z3421.seSeason = Children(i).Code
   Case "CDSEASON":z3421.cdSeason = Children(i).Code
   Case "CUSTOMERCODE":z3421.CustomerCode = Children(i).Code
   Case "DATEACCEPT":z3421.DateAccept = Children(i).Code
   Case "CHECKINPURCHASINGORDER":z3421.CheckInPurchasingOrder = Children(i).Code
   Case "CHECKOUTPURCHASINGORDER":z3421.CheckOutPurchasingOrder = Children(i).Code
   Case "CHECKPROCESSTYPE":z3421.CheckProcessType = Children(i).Code
   Case "CHECKIOTYPE":z3421.CheckIOType = Children(i).Code
   Case "CHECKMATERIALTYPE":z3421.CheckMaterialType = Children(i).Code
   Case "CHECKMARKETTYPE":z3421.CheckMarketType = Children(i).Code
   Case "CHECKRELATIONTYPE":z3421.CheckRelationType = Children(i).Code
   Case "SUPPLIERCODE":z3421.SupplierCode = Children(i).Code
   Case "SELUNITPRICE":z3421.selUnitPrice = Children(i).Code
   Case "CDUNITPRICE":z3421.cdUnitPrice = Children(i).Code
   Case "PRICEEXCHANGE":z3421.PriceExchange = Children(i).Code
   Case "DATEEXCHANGE":z3421.DateExchange = Children(i).Code
   Case "SEORIGIN":z3421.seOrigin = Children(i).Code
   Case "CDORIGIN":z3421.cdOrigin = Children(i).Code
   Case "SECOMMERCIALTERM":z3421.seCommercialTerm = Children(i).Code
   Case "CDCOMMERCIALTERM":z3421.cdCommercialTerm = Children(i).Code
   Case "SEDELIVERYTERM":z3421.seDeliveryTerm = Children(i).Code
   Case "CDDELIVERYTERM":z3421.cdDeliveryTerm = Children(i).Code
   Case "SEPAYMENTTERM":z3421.sePaymentTerm = Children(i).Code
   Case "CDPAYMENTTERM":z3421.cdPaymentTerm = Children(i).Code
   Case "SEPAYMENTCONDITION":z3421.sePaymentCondition = Children(i).Code
   Case "CDPAYMENTCONDITION":z3421.cdPaymentCondition = Children(i).Code
   Case "SEPAYMENTTIME":z3421.sePaymentTime = Children(i).Code
   Case "CDPAYMENTTIME":z3421.cdPaymentTime = Children(i).Code
   Case "SEPAYMENTDAY":z3421.sePaymentDay = Children(i).Code
   Case "CDPAYMENTDAY":z3421.cdPaymentDay = Children(i).Code
   Case "SEBUYINGTYPE":z3421.seBuyingType = Children(i).Code
   Case "CDBUYINGTYPE":z3421.cdBuyingType = Children(i).Code
   Case "QUALITYREQUEST":z3421.QualityRequest = Children(i).Code
   Case "CONTRACTNO":z3421.ContractNo = Children(i).Code
   Case "TOLERANCE":z3421.Tolerance = Children(i).Code
   Case "DESTINATION":z3421.Destination = Children(i).Code
   Case "INCHARGEPURCHASING":z3421.InchargePurchasing = Children(i).Code
   Case "AMOUNTPURCHASINGEX":z3421.AmountPurchasingEX = Children(i).Code
   Case "AMOUNTPURCHASINGVND":z3421.AmountPurchasingVND = Children(i).Code
   Case "AMOUNTTAXEX":z3421.AmountTaxEX = Children(i).Code
   Case "AMOUNTTAXVND":z3421.AmountTaxVND = Children(i).Code
   Case "AMOUNTEXPENSEUSD":z3421.AmountExpenseUSD = Children(i).Code
   Case "AMOUNTEXPENSEVND":z3421.AmountExpenseVND = Children(i).Code
   Case "AMOUNTTOTALEX":z3421.AmountTotalEX = Children(i).Code
   Case "AMOUNTTOTALVND":z3421.AmountTotalVND = Children(i).Code
   Case "DATESTART":z3421.DateStart = Children(i).Code
   Case "DATEESTIMATE":z3421.DateEstimate = Children(i).Code
   Case "DATEDELIVERY":z3421.DateDelivery = Children(i).Code
   Case "DATEINSERT":z3421.DateInsert = Children(i).Code
   Case "DATEUPDATE":z3421.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z3421.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z3421.InchargeUpdate = Children(i).Code
   Case "CHECKCOMPLETE":z3421.CheckComplete = Children(i).Code
   Case "PURCHASINGORDERNO":z3421.PurchasingOrderNo = Children(i).Code
   Case "SALESORDERNO":z3421.SalesOrderNo = Children(i).Code
   Case "SALESORDERSEQ":z3421.SalesOrderSeq = Children(i).Code
   Case "SALESORDERSNO":z3421.SalesOrderSno = Children(i).Code
   Case "REMARK":z3421.Remark = Children(i).Code
   Case "COMPONENTLIST":z3421.ComponentList = Children(i).Code
   Case "SESITE":z3421.seSite = Children(i).Code
   Case "CDSITE":z3421.cdSite = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "FACTORDERNO":z3421.FactOrderNo = Children(i).Data
   Case "FACTORDERNAME":z3421.FactOrderName = Children(i).Data
   Case "SESEASON":z3421.seSeason = Children(i).Data
   Case "CDSEASON":z3421.cdSeason = Children(i).Data
   Case "CUSTOMERCODE":z3421.CustomerCode = Children(i).Data
   Case "DATEACCEPT":z3421.DateAccept = Children(i).Data
   Case "CHECKINPURCHASINGORDER":z3421.CheckInPurchasingOrder = Children(i).Data
   Case "CHECKOUTPURCHASINGORDER":z3421.CheckOutPurchasingOrder = Children(i).Data
   Case "CHECKPROCESSTYPE":z3421.CheckProcessType = Children(i).Data
   Case "CHECKIOTYPE":z3421.CheckIOType = Children(i).Data
   Case "CHECKMATERIALTYPE":z3421.CheckMaterialType = Children(i).Data
   Case "CHECKMARKETTYPE":z3421.CheckMarketType = Children(i).Data
   Case "CHECKRELATIONTYPE":z3421.CheckRelationType = Children(i).Data
   Case "SUPPLIERCODE":z3421.SupplierCode = Children(i).Data
   Case "SELUNITPRICE":z3421.selUnitPrice = Children(i).Data
   Case "CDUNITPRICE":z3421.cdUnitPrice = Children(i).Data
   Case "PRICEEXCHANGE":z3421.PriceExchange = Children(i).Data
   Case "DATEEXCHANGE":z3421.DateExchange = Children(i).Data
   Case "SEORIGIN":z3421.seOrigin = Children(i).Data
   Case "CDORIGIN":z3421.cdOrigin = Children(i).Data
   Case "SECOMMERCIALTERM":z3421.seCommercialTerm = Children(i).Data
   Case "CDCOMMERCIALTERM":z3421.cdCommercialTerm = Children(i).Data
   Case "SEDELIVERYTERM":z3421.seDeliveryTerm = Children(i).Data
   Case "CDDELIVERYTERM":z3421.cdDeliveryTerm = Children(i).Data
   Case "SEPAYMENTTERM":z3421.sePaymentTerm = Children(i).Data
   Case "CDPAYMENTTERM":z3421.cdPaymentTerm = Children(i).Data
   Case "SEPAYMENTCONDITION":z3421.sePaymentCondition = Children(i).Data
   Case "CDPAYMENTCONDITION":z3421.cdPaymentCondition = Children(i).Data
   Case "SEPAYMENTTIME":z3421.sePaymentTime = Children(i).Data
   Case "CDPAYMENTTIME":z3421.cdPaymentTime = Children(i).Data
   Case "SEPAYMENTDAY":z3421.sePaymentDay = Children(i).Data
   Case "CDPAYMENTDAY":z3421.cdPaymentDay = Children(i).Data
   Case "SEBUYINGTYPE":z3421.seBuyingType = Children(i).Data
   Case "CDBUYINGTYPE":z3421.cdBuyingType = Children(i).Data
   Case "QUALITYREQUEST":z3421.QualityRequest = Children(i).Data
   Case "CONTRACTNO":z3421.ContractNo = Children(i).Data
   Case "TOLERANCE":z3421.Tolerance = Children(i).Data
   Case "DESTINATION":z3421.Destination = Children(i).Data
   Case "INCHARGEPURCHASING":z3421.InchargePurchasing = Children(i).Data
   Case "AMOUNTPURCHASINGEX":z3421.AmountPurchasingEX = Children(i).Data
   Case "AMOUNTPURCHASINGVND":z3421.AmountPurchasingVND = Children(i).Data
   Case "AMOUNTTAXEX":z3421.AmountTaxEX = Children(i).Data
   Case "AMOUNTTAXVND":z3421.AmountTaxVND = Children(i).Data
   Case "AMOUNTEXPENSEUSD":z3421.AmountExpenseUSD = Children(i).Data
   Case "AMOUNTEXPENSEVND":z3421.AmountExpenseVND = Children(i).Data
   Case "AMOUNTTOTALEX":z3421.AmountTotalEX = Children(i).Data
   Case "AMOUNTTOTALVND":z3421.AmountTotalVND = Children(i).Data
   Case "DATESTART":z3421.DateStart = Children(i).Data
   Case "DATEESTIMATE":z3421.DateEstimate = Children(i).Data
   Case "DATEDELIVERY":z3421.DateDelivery = Children(i).Data
   Case "DATEINSERT":z3421.DateInsert = Children(i).Data
   Case "DATEUPDATE":z3421.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z3421.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z3421.InchargeUpdate = Children(i).Data
   Case "CHECKCOMPLETE":z3421.CheckComplete = Children(i).Data
   Case "PURCHASINGORDERNO":z3421.PurchasingOrderNo = Children(i).Data
   Case "SALESORDERNO":z3421.SalesOrderNo = Children(i).Data
   Case "SALESORDERSEQ":z3421.SalesOrderSeq = Children(i).Data
   Case "SALESORDERSNO":z3421.SalesOrderSno = Children(i).Data
   Case "REMARK":z3421.Remark = Children(i).Data
   Case "COMPONENTLIST":z3421.ComponentList = Children(i).Data
   Case "SESITE":z3421.seSite = Children(i).Data
   Case "CDSITE":z3421.cdSite = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K3421_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K3421_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z3421 As T3421_AREA, Job as String, CheckClear as Boolean, FACTORDERNO AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K3421_MOVE = False

Try
    If READ_PFK3421(FACTORDERNO) = True Then
                z3421 = D3421
		K3421_MOVE = True
		else
	If CheckClear  = True then z3421 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3421")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "FACTORDERNO":z3421.FactOrderNo = Children(i).Code
   Case "FACTORDERNAME":z3421.FactOrderName = Children(i).Code
   Case "SESEASON":z3421.seSeason = Children(i).Code
   Case "CDSEASON":z3421.cdSeason = Children(i).Code
   Case "CUSTOMERCODE":z3421.CustomerCode = Children(i).Code
   Case "DATEACCEPT":z3421.DateAccept = Children(i).Code
   Case "CHECKINPURCHASINGORDER":z3421.CheckInPurchasingOrder = Children(i).Code
   Case "CHECKOUTPURCHASINGORDER":z3421.CheckOutPurchasingOrder = Children(i).Code
   Case "CHECKPROCESSTYPE":z3421.CheckProcessType = Children(i).Code
   Case "CHECKIOTYPE":z3421.CheckIOType = Children(i).Code
   Case "CHECKMATERIALTYPE":z3421.CheckMaterialType = Children(i).Code
   Case "CHECKMARKETTYPE":z3421.CheckMarketType = Children(i).Code
   Case "CHECKRELATIONTYPE":z3421.CheckRelationType = Children(i).Code
   Case "SUPPLIERCODE":z3421.SupplierCode = Children(i).Code
   Case "SELUNITPRICE":z3421.selUnitPrice = Children(i).Code
   Case "CDUNITPRICE":z3421.cdUnitPrice = Children(i).Code
   Case "PRICEEXCHANGE":z3421.PriceExchange = Children(i).Code
   Case "DATEEXCHANGE":z3421.DateExchange = Children(i).Code
   Case "SEORIGIN":z3421.seOrigin = Children(i).Code
   Case "CDORIGIN":z3421.cdOrigin = Children(i).Code
   Case "SECOMMERCIALTERM":z3421.seCommercialTerm = Children(i).Code
   Case "CDCOMMERCIALTERM":z3421.cdCommercialTerm = Children(i).Code
   Case "SEDELIVERYTERM":z3421.seDeliveryTerm = Children(i).Code
   Case "CDDELIVERYTERM":z3421.cdDeliveryTerm = Children(i).Code
   Case "SEPAYMENTTERM":z3421.sePaymentTerm = Children(i).Code
   Case "CDPAYMENTTERM":z3421.cdPaymentTerm = Children(i).Code
   Case "SEPAYMENTCONDITION":z3421.sePaymentCondition = Children(i).Code
   Case "CDPAYMENTCONDITION":z3421.cdPaymentCondition = Children(i).Code
   Case "SEPAYMENTTIME":z3421.sePaymentTime = Children(i).Code
   Case "CDPAYMENTTIME":z3421.cdPaymentTime = Children(i).Code
   Case "SEPAYMENTDAY":z3421.sePaymentDay = Children(i).Code
   Case "CDPAYMENTDAY":z3421.cdPaymentDay = Children(i).Code
   Case "SEBUYINGTYPE":z3421.seBuyingType = Children(i).Code
   Case "CDBUYINGTYPE":z3421.cdBuyingType = Children(i).Code
   Case "QUALITYREQUEST":z3421.QualityRequest = Children(i).Code
   Case "CONTRACTNO":z3421.ContractNo = Children(i).Code
   Case "TOLERANCE":z3421.Tolerance = Children(i).Code
   Case "DESTINATION":z3421.Destination = Children(i).Code
   Case "INCHARGEPURCHASING":z3421.InchargePurchasing = Children(i).Code
   Case "AMOUNTPURCHASINGEX":z3421.AmountPurchasingEX = Children(i).Code
   Case "AMOUNTPURCHASINGVND":z3421.AmountPurchasingVND = Children(i).Code
   Case "AMOUNTTAXEX":z3421.AmountTaxEX = Children(i).Code
   Case "AMOUNTTAXVND":z3421.AmountTaxVND = Children(i).Code
   Case "AMOUNTEXPENSEUSD":z3421.AmountExpenseUSD = Children(i).Code
   Case "AMOUNTEXPENSEVND":z3421.AmountExpenseVND = Children(i).Code
   Case "AMOUNTTOTALEX":z3421.AmountTotalEX = Children(i).Code
   Case "AMOUNTTOTALVND":z3421.AmountTotalVND = Children(i).Code
   Case "DATESTART":z3421.DateStart = Children(i).Code
   Case "DATEESTIMATE":z3421.DateEstimate = Children(i).Code
   Case "DATEDELIVERY":z3421.DateDelivery = Children(i).Code
   Case "DATEINSERT":z3421.DateInsert = Children(i).Code
   Case "DATEUPDATE":z3421.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z3421.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z3421.InchargeUpdate = Children(i).Code
   Case "CHECKCOMPLETE":z3421.CheckComplete = Children(i).Code
   Case "PURCHASINGORDERNO":z3421.PurchasingOrderNo = Children(i).Code
   Case "SALESORDERNO":z3421.SalesOrderNo = Children(i).Code
   Case "SALESORDERSEQ":z3421.SalesOrderSeq = Children(i).Code
   Case "SALESORDERSNO":z3421.SalesOrderSno = Children(i).Code
   Case "REMARK":z3421.Remark = Children(i).Code
   Case "COMPONENTLIST":z3421.ComponentList = Children(i).Code
   Case "SESITE":z3421.seSite = Children(i).Code
   Case "CDSITE":z3421.cdSite = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "FACTORDERNO":z3421.FactOrderNo = Children(i).Data
   Case "FACTORDERNAME":z3421.FactOrderName = Children(i).Data
   Case "SESEASON":z3421.seSeason = Children(i).Data
   Case "CDSEASON":z3421.cdSeason = Children(i).Data
   Case "CUSTOMERCODE":z3421.CustomerCode = Children(i).Data
   Case "DATEACCEPT":z3421.DateAccept = Children(i).Data
   Case "CHECKINPURCHASINGORDER":z3421.CheckInPurchasingOrder = Children(i).Data
   Case "CHECKOUTPURCHASINGORDER":z3421.CheckOutPurchasingOrder = Children(i).Data
   Case "CHECKPROCESSTYPE":z3421.CheckProcessType = Children(i).Data
   Case "CHECKIOTYPE":z3421.CheckIOType = Children(i).Data
   Case "CHECKMATERIALTYPE":z3421.CheckMaterialType = Children(i).Data
   Case "CHECKMARKETTYPE":z3421.CheckMarketType = Children(i).Data
   Case "CHECKRELATIONTYPE":z3421.CheckRelationType = Children(i).Data
   Case "SUPPLIERCODE":z3421.SupplierCode = Children(i).Data
   Case "SELUNITPRICE":z3421.selUnitPrice = Children(i).Data
   Case "CDUNITPRICE":z3421.cdUnitPrice = Children(i).Data
   Case "PRICEEXCHANGE":z3421.PriceExchange = Children(i).Data
   Case "DATEEXCHANGE":z3421.DateExchange = Children(i).Data
   Case "SEORIGIN":z3421.seOrigin = Children(i).Data
   Case "CDORIGIN":z3421.cdOrigin = Children(i).Data
   Case "SECOMMERCIALTERM":z3421.seCommercialTerm = Children(i).Data
   Case "CDCOMMERCIALTERM":z3421.cdCommercialTerm = Children(i).Data
   Case "SEDELIVERYTERM":z3421.seDeliveryTerm = Children(i).Data
   Case "CDDELIVERYTERM":z3421.cdDeliveryTerm = Children(i).Data
   Case "SEPAYMENTTERM":z3421.sePaymentTerm = Children(i).Data
   Case "CDPAYMENTTERM":z3421.cdPaymentTerm = Children(i).Data
   Case "SEPAYMENTCONDITION":z3421.sePaymentCondition = Children(i).Data
   Case "CDPAYMENTCONDITION":z3421.cdPaymentCondition = Children(i).Data
   Case "SEPAYMENTTIME":z3421.sePaymentTime = Children(i).Data
   Case "CDPAYMENTTIME":z3421.cdPaymentTime = Children(i).Data
   Case "SEPAYMENTDAY":z3421.sePaymentDay = Children(i).Data
   Case "CDPAYMENTDAY":z3421.cdPaymentDay = Children(i).Data
   Case "SEBUYINGTYPE":z3421.seBuyingType = Children(i).Data
   Case "CDBUYINGTYPE":z3421.cdBuyingType = Children(i).Data
   Case "QUALITYREQUEST":z3421.QualityRequest = Children(i).Data
   Case "CONTRACTNO":z3421.ContractNo = Children(i).Data
   Case "TOLERANCE":z3421.Tolerance = Children(i).Data
   Case "DESTINATION":z3421.Destination = Children(i).Data
   Case "INCHARGEPURCHASING":z3421.InchargePurchasing = Children(i).Data
   Case "AMOUNTPURCHASINGEX":z3421.AmountPurchasingEX = Children(i).Data
   Case "AMOUNTPURCHASINGVND":z3421.AmountPurchasingVND = Children(i).Data
   Case "AMOUNTTAXEX":z3421.AmountTaxEX = Children(i).Data
   Case "AMOUNTTAXVND":z3421.AmountTaxVND = Children(i).Data
   Case "AMOUNTEXPENSEUSD":z3421.AmountExpenseUSD = Children(i).Data
   Case "AMOUNTEXPENSEVND":z3421.AmountExpenseVND = Children(i).Data
   Case "AMOUNTTOTALEX":z3421.AmountTotalEX = Children(i).Data
   Case "AMOUNTTOTALVND":z3421.AmountTotalVND = Children(i).Data
   Case "DATESTART":z3421.DateStart = Children(i).Data
   Case "DATEESTIMATE":z3421.DateEstimate = Children(i).Data
   Case "DATEDELIVERY":z3421.DateDelivery = Children(i).Data
   Case "DATEINSERT":z3421.DateInsert = Children(i).Data
   Case "DATEUPDATE":z3421.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z3421.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z3421.InchargeUpdate = Children(i).Data
   Case "CHECKCOMPLETE":z3421.CheckComplete = Children(i).Data
   Case "PURCHASINGORDERNO":z3421.PurchasingOrderNo = Children(i).Data
   Case "SALESORDERNO":z3421.SalesOrderNo = Children(i).Data
   Case "SALESORDERSEQ":z3421.SalesOrderSeq = Children(i).Data
   Case "SALESORDERSNO":z3421.SalesOrderSno = Children(i).Data
   Case "REMARK":z3421.Remark = Children(i).Data
   Case "COMPONENTLIST":z3421.ComponentList = Children(i).Data
   Case "SESITE":z3421.seSite = Children(i).Data
   Case "CDSITE":z3421.cdSite = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K3421_MOVE",vbCritical)
End Try
End Function 
    

'=========================================================================================================================================================
' DATA MOVE FORM NEW AREA
'=========================================================================================================================================================
Public Sub K3421_MOVE(ByRef a3421 As T3421_AREA, ByRef b3421 As T3421_AREA) 
Try
If trim$( a3421.FactOrderNo ) = "" Then b3421.FactOrderNo = ""  Else b3421.FactOrderNo=a3421.FactOrderNo
If trim$( a3421.FactOrderName ) = "" Then b3421.FactOrderName = ""  Else b3421.FactOrderName=a3421.FactOrderName
If trim$( a3421.seSeason ) = "" Then b3421.seSeason = ""  Else b3421.seSeason=a3421.seSeason
If trim$( a3421.cdSeason ) = "" Then b3421.cdSeason = ""  Else b3421.cdSeason=a3421.cdSeason
If trim$( a3421.CustomerCode ) = "" Then b3421.CustomerCode = ""  Else b3421.CustomerCode=a3421.CustomerCode
If trim$( a3421.DateAccept ) = "" Then b3421.DateAccept = ""  Else b3421.DateAccept=a3421.DateAccept
If trim$( a3421.CheckInPurchasingOrder ) = "" Then b3421.CheckInPurchasingOrder = ""  Else b3421.CheckInPurchasingOrder=a3421.CheckInPurchasingOrder
If trim$( a3421.CheckOutPurchasingOrder ) = "" Then b3421.CheckOutPurchasingOrder = ""  Else b3421.CheckOutPurchasingOrder=a3421.CheckOutPurchasingOrder
If trim$( a3421.CheckProcessType ) = "" Then b3421.CheckProcessType = ""  Else b3421.CheckProcessType=a3421.CheckProcessType
If trim$( a3421.CheckIOType ) = "" Then b3421.CheckIOType = ""  Else b3421.CheckIOType=a3421.CheckIOType
If trim$( a3421.CheckMaterialType ) = "" Then b3421.CheckMaterialType = ""  Else b3421.CheckMaterialType=a3421.CheckMaterialType
If trim$( a3421.CheckMarketType ) = "" Then b3421.CheckMarketType = ""  Else b3421.CheckMarketType=a3421.CheckMarketType
If trim$( a3421.CheckRelationType ) = "" Then b3421.CheckRelationType = ""  Else b3421.CheckRelationType=a3421.CheckRelationType
If trim$( a3421.SupplierCode ) = "" Then b3421.SupplierCode = ""  Else b3421.SupplierCode=a3421.SupplierCode
If trim$( a3421.selUnitPrice ) = "" Then b3421.selUnitPrice = ""  Else b3421.selUnitPrice=a3421.selUnitPrice
If trim$( a3421.cdUnitPrice ) = "" Then b3421.cdUnitPrice = ""  Else b3421.cdUnitPrice=a3421.cdUnitPrice
If trim$( a3421.PriceExchange ) = "" Then b3421.PriceExchange = ""  Else b3421.PriceExchange=a3421.PriceExchange
If trim$( a3421.DateExchange ) = "" Then b3421.DateExchange = ""  Else b3421.DateExchange=a3421.DateExchange
If trim$( a3421.seOrigin ) = "" Then b3421.seOrigin = ""  Else b3421.seOrigin=a3421.seOrigin
If trim$( a3421.cdOrigin ) = "" Then b3421.cdOrigin = ""  Else b3421.cdOrigin=a3421.cdOrigin
If trim$( a3421.seCommercialTerm ) = "" Then b3421.seCommercialTerm = ""  Else b3421.seCommercialTerm=a3421.seCommercialTerm
If trim$( a3421.cdCommercialTerm ) = "" Then b3421.cdCommercialTerm = ""  Else b3421.cdCommercialTerm=a3421.cdCommercialTerm
If trim$( a3421.seDeliveryTerm ) = "" Then b3421.seDeliveryTerm = ""  Else b3421.seDeliveryTerm=a3421.seDeliveryTerm
If trim$( a3421.cdDeliveryTerm ) = "" Then b3421.cdDeliveryTerm = ""  Else b3421.cdDeliveryTerm=a3421.cdDeliveryTerm
If trim$( a3421.sePaymentTerm ) = "" Then b3421.sePaymentTerm = ""  Else b3421.sePaymentTerm=a3421.sePaymentTerm
If trim$( a3421.cdPaymentTerm ) = "" Then b3421.cdPaymentTerm = ""  Else b3421.cdPaymentTerm=a3421.cdPaymentTerm
If trim$( a3421.sePaymentCondition ) = "" Then b3421.sePaymentCondition = ""  Else b3421.sePaymentCondition=a3421.sePaymentCondition
If trim$( a3421.cdPaymentCondition ) = "" Then b3421.cdPaymentCondition = ""  Else b3421.cdPaymentCondition=a3421.cdPaymentCondition
If trim$( a3421.sePaymentTime ) = "" Then b3421.sePaymentTime = ""  Else b3421.sePaymentTime=a3421.sePaymentTime
If trim$( a3421.cdPaymentTime ) = "" Then b3421.cdPaymentTime = ""  Else b3421.cdPaymentTime=a3421.cdPaymentTime
If trim$( a3421.sePaymentDay ) = "" Then b3421.sePaymentDay = ""  Else b3421.sePaymentDay=a3421.sePaymentDay
If trim$( a3421.cdPaymentDay ) = "" Then b3421.cdPaymentDay = ""  Else b3421.cdPaymentDay=a3421.cdPaymentDay
If trim$( a3421.seBuyingType ) = "" Then b3421.seBuyingType = ""  Else b3421.seBuyingType=a3421.seBuyingType
If trim$( a3421.cdBuyingType ) = "" Then b3421.cdBuyingType = ""  Else b3421.cdBuyingType=a3421.cdBuyingType
If trim$( a3421.QualityRequest ) = "" Then b3421.QualityRequest = ""  Else b3421.QualityRequest=a3421.QualityRequest
If trim$( a3421.ContractNo ) = "" Then b3421.ContractNo = ""  Else b3421.ContractNo=a3421.ContractNo
If trim$( a3421.Tolerance ) = "" Then b3421.Tolerance = ""  Else b3421.Tolerance=a3421.Tolerance
If trim$( a3421.Destination ) = "" Then b3421.Destination = ""  Else b3421.Destination=a3421.Destination
If trim$( a3421.InchargePurchasing ) = "" Then b3421.InchargePurchasing = ""  Else b3421.InchargePurchasing=a3421.InchargePurchasing
If trim$( a3421.AmountPurchasingEX ) = "" Then b3421.AmountPurchasingEX = ""  Else b3421.AmountPurchasingEX=a3421.AmountPurchasingEX
If trim$( a3421.AmountPurchasingVND ) = "" Then b3421.AmountPurchasingVND = ""  Else b3421.AmountPurchasingVND=a3421.AmountPurchasingVND
If trim$( a3421.AmountTaxEX ) = "" Then b3421.AmountTaxEX = ""  Else b3421.AmountTaxEX=a3421.AmountTaxEX
If trim$( a3421.AmountTaxVND ) = "" Then b3421.AmountTaxVND = ""  Else b3421.AmountTaxVND=a3421.AmountTaxVND
If trim$( a3421.AmountExpenseUSD ) = "" Then b3421.AmountExpenseUSD = ""  Else b3421.AmountExpenseUSD=a3421.AmountExpenseUSD
If trim$( a3421.AmountExpenseVND ) = "" Then b3421.AmountExpenseVND = ""  Else b3421.AmountExpenseVND=a3421.AmountExpenseVND
If trim$( a3421.AmountTotalEX ) = "" Then b3421.AmountTotalEX = ""  Else b3421.AmountTotalEX=a3421.AmountTotalEX
If trim$( a3421.AmountTotalVND ) = "" Then b3421.AmountTotalVND = ""  Else b3421.AmountTotalVND=a3421.AmountTotalVND
If trim$( a3421.DateStart ) = "" Then b3421.DateStart = ""  Else b3421.DateStart=a3421.DateStart
If trim$( a3421.DateEstimate ) = "" Then b3421.DateEstimate = ""  Else b3421.DateEstimate=a3421.DateEstimate
If trim$( a3421.DateDelivery ) = "" Then b3421.DateDelivery = ""  Else b3421.DateDelivery=a3421.DateDelivery
If trim$( a3421.DateInsert ) = "" Then b3421.DateInsert = ""  Else b3421.DateInsert=a3421.DateInsert
If trim$( a3421.DateUpdate ) = "" Then b3421.DateUpdate = ""  Else b3421.DateUpdate=a3421.DateUpdate
If trim$( a3421.InchargeInsert ) = "" Then b3421.InchargeInsert = ""  Else b3421.InchargeInsert=a3421.InchargeInsert
If trim$( a3421.InchargeUpdate ) = "" Then b3421.InchargeUpdate = ""  Else b3421.InchargeUpdate=a3421.InchargeUpdate
If trim$( a3421.CheckComplete ) = "" Then b3421.CheckComplete = ""  Else b3421.CheckComplete=a3421.CheckComplete
If trim$( a3421.PurchasingOrderNo ) = "" Then b3421.PurchasingOrderNo = ""  Else b3421.PurchasingOrderNo=a3421.PurchasingOrderNo
If trim$( a3421.SalesOrderNo ) = "" Then b3421.SalesOrderNo = ""  Else b3421.SalesOrderNo=a3421.SalesOrderNo
If trim$( a3421.SalesOrderSeq ) = "" Then b3421.SalesOrderSeq = ""  Else b3421.SalesOrderSeq=a3421.SalesOrderSeq
If trim$( a3421.SalesOrderSno ) = "" Then b3421.SalesOrderSno = ""  Else b3421.SalesOrderSno=a3421.SalesOrderSno
If trim$( a3421.Remark ) = "" Then b3421.Remark = ""  Else b3421.Remark=a3421.Remark
If trim$( a3421.ComponentList ) = "" Then b3421.ComponentList = ""  Else b3421.ComponentList=a3421.ComponentList
If trim$( a3421.seSite ) = "" Then b3421.seSite = ""  Else b3421.seSite=a3421.seSite
If trim$( a3421.cdSite ) = "" Then b3421.cdSite = ""  Else b3421.cdSite=a3421.cdSite
Catch ex As Exception
      Call MsgBoxP("K3421_MOVE",vbCritical)
End Try
End Sub 


End Module 
