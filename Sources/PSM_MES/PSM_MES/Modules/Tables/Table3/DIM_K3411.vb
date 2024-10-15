'=========================================================================================================================================================
'   TABLE : (PFK3411)
'
'      WORKER : PSM GLOBAL ., LTD
'       WORK DATE : 2019 NEW
'       DEVELOPER    : MRNLV
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K3411

Structure T3411_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	PurchasingOrderNo	 AS String	'			char(9)		*
Public 	PurchasingOrderName	 AS String	'			nvarchar(20)
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
Public 	seOrigin	 AS String	'			char(3)
Public 	cdOrigin	 AS String	'			char(3)
Public 	seCommercialTerm	 AS String	'			char(3)
Public 	cdCommercialTerm	 AS String	'			char(3)
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
Public 	AmountTax1EX	 AS Double	'			decimal
Public 	AmountTax2EX	 AS Double	'			decimal
Public 	AmountTax3EX	 AS Double	'			decimal
Public 	AmountTax1VND	 AS Double	'			decimal
Public 	AmountTax2VND	 AS Double	'			decimal
Public 	AmountTax3VND	 AS Double	'			decimal
Public 	AmountTaxEX	 AS Double	'			decimal
Public 	AmountTaxVND	 AS Double	'			decimal
Public 	AmountNoVATEX	 AS Double	'			decimal
Public 	AmountNoVATVND	 AS Double	'			decimal
Public 	AmountExpenseUSD	 AS Double	'			decimal
Public 	AmountExpenseVND	 AS Double	'			decimal
Public 	AmountTotalEX	 AS Double	'			decimal
Public 	AmountTotalVND	 AS Double	'			decimal
Public 	DateStart	 AS String	'			char(8)
Public 	DateEstimate	 AS String	'			char(8)
Public 	DateDelivery	 AS String	'			char(8)
Public 	TimeInsert	 AS String	'			char(14)
Public 	TimeUpdate	 AS String	'			char(14)
Public 	DateInsert	 AS String	'			char(8)
Public 	DateUpdate	 AS String	'			char(8)
Public 	InchargeInsert	 AS String	'			char(8)
Public 	InchargeUpdate	 AS String	'			char(8)
Public 	CheckComplete	 AS String	'			char(1)
Public 	Remark	 AS String	'			nvarchar(500)
Public 	Remark01	 AS String	'			nvarchar(500)
Public 	Remark02	 AS String	'			nvarchar(500)
Public 	Remark03	 AS String	'			nvarchar(500)
Public 	Remark04	 AS String	'			nvarchar(500)
Public 	Remark05	 AS String	'			nvarchar(500)
Public 	seSite	 AS String	'			char(3)
Public 	cdSite	 AS String	'			char(3)
'=========================================================================================================================================================
End structure

Public D3411 As T3411_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK3411(PURCHASINGORDERNO AS String) As Boolean
    READ_PFK3411 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK3411 "
    SQL = SQL & " WHERE K3411_PurchasingOrderNo		 = '" & PurchasingOrderNo & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D3411_CLEAR: GoTo SKIP_READ_PFK3411
                
    Call K3411_MOVE(rd)
    READ_PFK3411 = True

SKIP_READ_PFK3411:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK3411",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK3411(PURCHASINGORDERNO AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK3411 "
    SQL = SQL & " WHERE K3411_PurchasingOrderNo		 = '" & PurchasingOrderNo & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK3411",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK3411(z3411 As T3411_AREA) As Boolean
    WRITE_PFK3411 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z3411)
 
    SQL = " INSERT INTO PFK3411 "
    SQL = SQL & " ( "
    SQL = SQL & " K3411_PurchasingOrderNo," 
    SQL = SQL & " K3411_PurchasingOrderName," 
    SQL = SQL & " K3411_seSeason," 
    SQL = SQL & " K3411_cdSeason," 
    SQL = SQL & " K3411_CustomerCode," 
    SQL = SQL & " K3411_DateAccept," 
    SQL = SQL & " K3411_CheckInPurchasingOrder," 
    SQL = SQL & " K3411_CheckOutPurchasingOrder," 
    SQL = SQL & " K3411_CheckProcessType," 
    SQL = SQL & " K3411_CheckIOType," 
    SQL = SQL & " K3411_CheckMaterialType," 
    SQL = SQL & " K3411_CheckMarketType," 
    SQL = SQL & " K3411_CheckRelationType," 
    SQL = SQL & " K3411_SupplierCode," 
    SQL = SQL & " K3411_selUnitPrice," 
    SQL = SQL & " K3411_cdUnitPrice," 
    SQL = SQL & " K3411_PriceExchange," 
    SQL = SQL & " K3411_DateExchange," 
    SQL = SQL & " K3411_seDeliveryTerm," 
    SQL = SQL & " K3411_cdDeliveryTerm," 
    SQL = SQL & " K3411_seOrigin," 
    SQL = SQL & " K3411_cdOrigin," 
    SQL = SQL & " K3411_seCommercialTerm," 
    SQL = SQL & " K3411_cdCommercialTerm," 
    SQL = SQL & " K3411_sePaymentTerm," 
    SQL = SQL & " K3411_cdPaymentTerm," 
    SQL = SQL & " K3411_sePaymentCondition," 
    SQL = SQL & " K3411_cdPaymentCondition," 
    SQL = SQL & " K3411_sePaymentTime," 
    SQL = SQL & " K3411_cdPaymentTime," 
    SQL = SQL & " K3411_sePaymentDay," 
    SQL = SQL & " K3411_cdPaymentDay," 
    SQL = SQL & " K3411_seBuyingType," 
    SQL = SQL & " K3411_cdBuyingType," 
    SQL = SQL & " K3411_QualityRequest," 
    SQL = SQL & " K3411_ContractNo," 
    SQL = SQL & " K3411_Tolerance," 
    SQL = SQL & " K3411_Destination," 
    SQL = SQL & " K3411_InchargePurchasing," 
    SQL = SQL & " K3411_AmountPurchasingEX," 
    SQL = SQL & " K3411_AmountPurchasingVND," 
    SQL = SQL & " K3411_AmountTax1EX," 
    SQL = SQL & " K3411_AmountTax2EX," 
    SQL = SQL & " K3411_AmountTax3EX," 
    SQL = SQL & " K3411_AmountTax1VND," 
    SQL = SQL & " K3411_AmountTax2VND," 
    SQL = SQL & " K3411_AmountTax3VND," 
    SQL = SQL & " K3411_AmountTaxEX," 
    SQL = SQL & " K3411_AmountTaxVND," 
    SQL = SQL & " K3411_AmountNoVATEX," 
    SQL = SQL & " K3411_AmountNoVATVND," 
    SQL = SQL & " K3411_AmountExpenseUSD," 
    SQL = SQL & " K3411_AmountExpenseVND," 
    SQL = SQL & " K3411_AmountTotalEX," 
    SQL = SQL & " K3411_AmountTotalVND," 
    SQL = SQL & " K3411_DateStart," 
    SQL = SQL & " K3411_DateEstimate," 
    SQL = SQL & " K3411_DateDelivery," 
    SQL = SQL & " K3411_TimeInsert," 
    SQL = SQL & " K3411_TimeUpdate," 
    SQL = SQL & " K3411_DateInsert," 
    SQL = SQL & " K3411_DateUpdate," 
    SQL = SQL & " K3411_InchargeInsert," 
    SQL = SQL & " K3411_InchargeUpdate," 
    SQL = SQL & " K3411_CheckComplete," 
    SQL = SQL & " K3411_Remark," 
    SQL = SQL & " K3411_Remark01," 
    SQL = SQL & " K3411_Remark02," 
    SQL = SQL & " K3411_Remark03," 
    SQL = SQL & " K3411_Remark04," 
    SQL = SQL & " K3411_Remark05," 
    SQL = SQL & " K3411_seSite," 
    SQL = SQL & " K3411_cdSite " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z3411.PurchasingOrderNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3411.PurchasingOrderName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3411.seSeason) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3411.cdSeason) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3411.CustomerCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3411.DateAccept) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3411.CheckInPurchasingOrder) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3411.CheckOutPurchasingOrder) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3411.CheckProcessType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3411.CheckIOType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3411.CheckMaterialType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3411.CheckMarketType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3411.CheckRelationType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3411.SupplierCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3411.selUnitPrice) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3411.cdUnitPrice) & "', "  
    SQL = SQL & "   " & FormatSQL(z3411.PriceExchange) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z3411.DateExchange) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3411.seDeliveryTerm) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3411.cdDeliveryTerm) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3411.seOrigin) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3411.cdOrigin) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3411.seCommercialTerm) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3411.cdCommercialTerm) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3411.sePaymentTerm) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3411.cdPaymentTerm) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3411.sePaymentCondition) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3411.cdPaymentCondition) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3411.sePaymentTime) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3411.cdPaymentTime) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3411.sePaymentDay) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3411.cdPaymentDay) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3411.seBuyingType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3411.cdBuyingType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3411.QualityRequest) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3411.ContractNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3411.Tolerance) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3411.Destination) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3411.InchargePurchasing) & "', "  
    SQL = SQL & "   " & FormatSQL(z3411.AmountPurchasingEX) & ", "  
    SQL = SQL & "   " & FormatSQL(z3411.AmountPurchasingVND) & ", "  
    SQL = SQL & "   " & FormatSQL(z3411.AmountTax1EX) & ", "  
    SQL = SQL & "   " & FormatSQL(z3411.AmountTax2EX) & ", "  
    SQL = SQL & "   " & FormatSQL(z3411.AmountTax3EX) & ", "  
    SQL = SQL & "   " & FormatSQL(z3411.AmountTax1VND) & ", "  
    SQL = SQL & "   " & FormatSQL(z3411.AmountTax2VND) & ", "  
    SQL = SQL & "   " & FormatSQL(z3411.AmountTax3VND) & ", "  
    SQL = SQL & "   " & FormatSQL(z3411.AmountTaxEX) & ", "  
    SQL = SQL & "   " & FormatSQL(z3411.AmountTaxVND) & ", "  
    SQL = SQL & "   " & FormatSQL(z3411.AmountNoVATEX) & ", "  
    SQL = SQL & "   " & FormatSQL(z3411.AmountNoVATVND) & ", "  
    SQL = SQL & "   " & FormatSQL(z3411.AmountExpenseUSD) & ", "  
    SQL = SQL & "   " & FormatSQL(z3411.AmountExpenseVND) & ", "  
    SQL = SQL & "   " & FormatSQL(z3411.AmountTotalEX) & ", "  
    SQL = SQL & "   " & FormatSQL(z3411.AmountTotalVND) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z3411.DateStart) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3411.DateEstimate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3411.DateDelivery) & "', "  
    SQL = SQL & "  N'" & FormatSQL(PUB.TIME) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3411.TimeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(PUB.DAT) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3411.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(PUB.SAW) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3411.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3411.CheckComplete) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3411.Remark) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3411.Remark01) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3411.Remark02) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3411.Remark03) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3411.Remark04) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3411.Remark05) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3411.seSite) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3411.cdSite) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK3411 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK3411",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK3411(z3411 As T3411_AREA) As Boolean
    REWRITE_PFK3411 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z3411)
   
    SQL = " UPDATE PFK3411 SET "
    SQL = SQL & "    K3411_PurchasingOrderName      = N'" & FormatSQL(z3411.PurchasingOrderName) & "', " 
    SQL = SQL & "    K3411_seSeason      = N'" & FormatSQL(z3411.seSeason) & "', " 
    SQL = SQL & "    K3411_cdSeason      = N'" & FormatSQL(z3411.cdSeason) & "', " 
    SQL = SQL & "    K3411_CustomerCode      = N'" & FormatSQL(z3411.CustomerCode) & "', " 
    SQL = SQL & "    K3411_DateAccept      = N'" & FormatSQL(z3411.DateAccept) & "', " 
    SQL = SQL & "    K3411_CheckInPurchasingOrder      = N'" & FormatSQL(z3411.CheckInPurchasingOrder) & "', " 
    SQL = SQL & "    K3411_CheckOutPurchasingOrder      = N'" & FormatSQL(z3411.CheckOutPurchasingOrder) & "', " 
    SQL = SQL & "    K3411_CheckProcessType      = N'" & FormatSQL(z3411.CheckProcessType) & "', " 
    SQL = SQL & "    K3411_CheckIOType      = N'" & FormatSQL(z3411.CheckIOType) & "', " 
    SQL = SQL & "    K3411_CheckMaterialType      = N'" & FormatSQL(z3411.CheckMaterialType) & "', " 
    SQL = SQL & "    K3411_CheckMarketType      = N'" & FormatSQL(z3411.CheckMarketType) & "', " 
    SQL = SQL & "    K3411_CheckRelationType      = N'" & FormatSQL(z3411.CheckRelationType) & "', " 
    SQL = SQL & "    K3411_SupplierCode      = N'" & FormatSQL(z3411.SupplierCode) & "', " 
    SQL = SQL & "    K3411_selUnitPrice      = N'" & FormatSQL(z3411.selUnitPrice) & "', " 
    SQL = SQL & "    K3411_cdUnitPrice      = N'" & FormatSQL(z3411.cdUnitPrice) & "', " 
    SQL = SQL & "    K3411_PriceExchange      =  " & FormatSQL(z3411.PriceExchange) & ", " 
    SQL = SQL & "    K3411_DateExchange      = N'" & FormatSQL(z3411.DateExchange) & "', " 
    SQL = SQL & "    K3411_seDeliveryTerm      = N'" & FormatSQL(z3411.seDeliveryTerm) & "', " 
    SQL = SQL & "    K3411_cdDeliveryTerm      = N'" & FormatSQL(z3411.cdDeliveryTerm) & "', " 
    SQL = SQL & "    K3411_seOrigin      = N'" & FormatSQL(z3411.seOrigin) & "', " 
    SQL = SQL & "    K3411_cdOrigin      = N'" & FormatSQL(z3411.cdOrigin) & "', " 
    SQL = SQL & "    K3411_seCommercialTerm      = N'" & FormatSQL(z3411.seCommercialTerm) & "', " 
    SQL = SQL & "    K3411_cdCommercialTerm      = N'" & FormatSQL(z3411.cdCommercialTerm) & "', " 
    SQL = SQL & "    K3411_sePaymentTerm      = N'" & FormatSQL(z3411.sePaymentTerm) & "', " 
    SQL = SQL & "    K3411_cdPaymentTerm      = N'" & FormatSQL(z3411.cdPaymentTerm) & "', " 
    SQL = SQL & "    K3411_sePaymentCondition      = N'" & FormatSQL(z3411.sePaymentCondition) & "', " 
    SQL = SQL & "    K3411_cdPaymentCondition      = N'" & FormatSQL(z3411.cdPaymentCondition) & "', " 
    SQL = SQL & "    K3411_sePaymentTime      = N'" & FormatSQL(z3411.sePaymentTime) & "', " 
    SQL = SQL & "    K3411_cdPaymentTime      = N'" & FormatSQL(z3411.cdPaymentTime) & "', " 
    SQL = SQL & "    K3411_sePaymentDay      = N'" & FormatSQL(z3411.sePaymentDay) & "', " 
    SQL = SQL & "    K3411_cdPaymentDay      = N'" & FormatSQL(z3411.cdPaymentDay) & "', " 
    SQL = SQL & "    K3411_seBuyingType      = N'" & FormatSQL(z3411.seBuyingType) & "', " 
    SQL = SQL & "    K3411_cdBuyingType      = N'" & FormatSQL(z3411.cdBuyingType) & "', " 
    SQL = SQL & "    K3411_QualityRequest      = N'" & FormatSQL(z3411.QualityRequest) & "', " 
    SQL = SQL & "    K3411_ContractNo      = N'" & FormatSQL(z3411.ContractNo) & "', " 
    SQL = SQL & "    K3411_Tolerance      = N'" & FormatSQL(z3411.Tolerance) & "', " 
    SQL = SQL & "    K3411_Destination      = N'" & FormatSQL(z3411.Destination) & "', " 
    SQL = SQL & "    K3411_InchargePurchasing      = N'" & FormatSQL(z3411.InchargePurchasing) & "', " 
    SQL = SQL & "    K3411_AmountPurchasingEX      =  " & FormatSQL(z3411.AmountPurchasingEX) & ", " 
    SQL = SQL & "    K3411_AmountPurchasingVND      =  " & FormatSQL(z3411.AmountPurchasingVND) & ", " 
    SQL = SQL & "    K3411_AmountTax1EX      =  " & FormatSQL(z3411.AmountTax1EX) & ", " 
    SQL = SQL & "    K3411_AmountTax2EX      =  " & FormatSQL(z3411.AmountTax2EX) & ", " 
    SQL = SQL & "    K3411_AmountTax3EX      =  " & FormatSQL(z3411.AmountTax3EX) & ", " 
    SQL = SQL & "    K3411_AmountTax1VND      =  " & FormatSQL(z3411.AmountTax1VND) & ", " 
    SQL = SQL & "    K3411_AmountTax2VND      =  " & FormatSQL(z3411.AmountTax2VND) & ", " 
    SQL = SQL & "    K3411_AmountTax3VND      =  " & FormatSQL(z3411.AmountTax3VND) & ", " 
    SQL = SQL & "    K3411_AmountTaxEX      =  " & FormatSQL(z3411.AmountTaxEX) & ", " 
    SQL = SQL & "    K3411_AmountTaxVND      =  " & FormatSQL(z3411.AmountTaxVND) & ", " 
    SQL = SQL & "    K3411_AmountNoVATEX      =  " & FormatSQL(z3411.AmountNoVATEX) & ", " 
    SQL = SQL & "    K3411_AmountNoVATVND      =  " & FormatSQL(z3411.AmountNoVATVND) & ", " 
    SQL = SQL & "    K3411_AmountExpenseUSD      =  " & FormatSQL(z3411.AmountExpenseUSD) & ", " 
    SQL = SQL & "    K3411_AmountExpenseVND      =  " & FormatSQL(z3411.AmountExpenseVND) & ", " 
    SQL = SQL & "    K3411_AmountTotalEX      =  " & FormatSQL(z3411.AmountTotalEX) & ", " 
    SQL = SQL & "    K3411_AmountTotalVND      =  " & FormatSQL(z3411.AmountTotalVND) & ", " 
    SQL = SQL & "    K3411_DateStart      = N'" & FormatSQL(z3411.DateStart) & "', " 
    SQL = SQL & "    K3411_DateEstimate      = N'" & FormatSQL(z3411.DateEstimate) & "', " 
    SQL = SQL & "    K3411_DateDelivery      = N'" & FormatSQL(z3411.DateDelivery) & "', " 
    SQL = SQL & "    K3411_TimeInsert      = N'" & FormatSQL(z3411.TimeInsert) & "', " 
    SQL = SQL & "    K3411_TimeUpdate      = N'" & FormatSQL(PUB.TIME) & "', " 
    SQL = SQL & "    K3411_DateInsert      = N'" & FormatSQL(z3411.DateInsert) & "', " 
    SQL = SQL & "    K3411_DateUpdate      = N'" & FormatSQL(PUB.DAT) & "', " 
    SQL = SQL & "    K3411_InchargeInsert      = N'" & FormatSQL(z3411.InchargeInsert) & "', " 
    SQL = SQL & "    K3411_InchargeUpdate      = N'" & FormatSQL(PUB.SAW) & "', " 
    SQL = SQL & "    K3411_CheckComplete      = N'" & FormatSQL(z3411.CheckComplete) & "', " 
    SQL = SQL & "    K3411_Remark      = N'" & FormatSQL(z3411.Remark) & "', " 
    SQL = SQL & "    K3411_Remark01      = N'" & FormatSQL(z3411.Remark01) & "', " 
    SQL = SQL & "    K3411_Remark02      = N'" & FormatSQL(z3411.Remark02) & "', " 
    SQL = SQL & "    K3411_Remark03      = N'" & FormatSQL(z3411.Remark03) & "', " 
    SQL = SQL & "    K3411_Remark04      = N'" & FormatSQL(z3411.Remark04) & "', " 
    SQL = SQL & "    K3411_Remark05      = N'" & FormatSQL(z3411.Remark05) & "', " 
    SQL = SQL & "    K3411_seSite      = N'" & FormatSQL(z3411.seSite) & "', " 
    SQL = SQL & "    K3411_cdSite      = N'" & FormatSQL(z3411.cdSite) & "'  " 
    SQL = SQL & " WHERE K3411_PurchasingOrderNo		 = '" & z3411.PurchasingOrderNo & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  

    REWRITE_PFK3411 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK3411",vbCritical)

  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK3411(z3411 As T3411_AREA) As Boolean
    DELETE_PFK3411 = False

   Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z3411)
      
        SQL = " DELETE FROM PFK3411  "
    SQL = SQL & " WHERE K3411_PurchasingOrderNo		 = '" & z3411.PurchasingOrderNo & "' " 

    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK3411 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK3411",vbCritical)
Finally
        Call GetFullInformation("PFK3411", "D", SQL)
  End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D3411_CLEAR()
Try
    
   D3411.PurchasingOrderNo = ""
   D3411.PurchasingOrderName = ""
   D3411.seSeason = ""
   D3411.cdSeason = ""
   D3411.CustomerCode = ""
   D3411.DateAccept = ""
   D3411.CheckInPurchasingOrder = ""
   D3411.CheckOutPurchasingOrder = ""
   D3411.CheckProcessType = ""
   D3411.CheckIOType = ""
   D3411.CheckMaterialType = ""
   D3411.CheckMarketType = ""
   D3411.CheckRelationType = ""
   D3411.SupplierCode = ""
   D3411.selUnitPrice = ""
   D3411.cdUnitPrice = ""
    D3411.PriceExchange = 0 
   D3411.DateExchange = ""
   D3411.seDeliveryTerm = ""
   D3411.cdDeliveryTerm = ""
   D3411.seOrigin = ""
   D3411.cdOrigin = ""
   D3411.seCommercialTerm = ""
   D3411.cdCommercialTerm = ""
   D3411.sePaymentTerm = ""
   D3411.cdPaymentTerm = ""
   D3411.sePaymentCondition = ""
   D3411.cdPaymentCondition = ""
   D3411.sePaymentTime = ""
   D3411.cdPaymentTime = ""
   D3411.sePaymentDay = ""
   D3411.cdPaymentDay = ""
   D3411.seBuyingType = ""
   D3411.cdBuyingType = ""
   D3411.QualityRequest = ""
   D3411.ContractNo = ""
   D3411.Tolerance = ""
   D3411.Destination = ""
   D3411.InchargePurchasing = ""
    D3411.AmountPurchasingEX = 0 
    D3411.AmountPurchasingVND = 0 
    D3411.AmountTax1EX = 0 
    D3411.AmountTax2EX = 0 
    D3411.AmountTax3EX = 0 
    D3411.AmountTax1VND = 0 
    D3411.AmountTax2VND = 0 
    D3411.AmountTax3VND = 0 
    D3411.AmountTaxEX = 0 
    D3411.AmountTaxVND = 0 
    D3411.AmountNoVATEX = 0 
    D3411.AmountNoVATVND = 0 
    D3411.AmountExpenseUSD = 0 
    D3411.AmountExpenseVND = 0 
    D3411.AmountTotalEX = 0 
    D3411.AmountTotalVND = 0 
   D3411.DateStart = ""
   D3411.DateEstimate = ""
   D3411.DateDelivery = ""
   D3411.TimeInsert = ""
   D3411.TimeUpdate = ""
   D3411.DateInsert = ""
   D3411.DateUpdate = ""
   D3411.InchargeInsert = ""
   D3411.InchargeUpdate = ""
   D3411.CheckComplete = ""
   D3411.Remark = ""
   D3411.Remark01 = ""
   D3411.Remark02 = ""
   D3411.Remark03 = ""
   D3411.Remark04 = ""
   D3411.Remark05 = ""
   D3411.seSite = ""
   D3411.cdSite = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D3411_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x3411 As T3411_AREA)
Try
    
    x3411.PurchasingOrderNo = trim$(  x3411.PurchasingOrderNo)
    x3411.PurchasingOrderName = trim$(  x3411.PurchasingOrderName)
    x3411.seSeason = trim$(  x3411.seSeason)
    x3411.cdSeason = trim$(  x3411.cdSeason)
    x3411.CustomerCode = trim$(  x3411.CustomerCode)
    x3411.DateAccept = trim$(  x3411.DateAccept)
    x3411.CheckInPurchasingOrder = trim$(  x3411.CheckInPurchasingOrder)
    x3411.CheckOutPurchasingOrder = trim$(  x3411.CheckOutPurchasingOrder)
    x3411.CheckProcessType = trim$(  x3411.CheckProcessType)
    x3411.CheckIOType = trim$(  x3411.CheckIOType)
    x3411.CheckMaterialType = trim$(  x3411.CheckMaterialType)
    x3411.CheckMarketType = trim$(  x3411.CheckMarketType)
    x3411.CheckRelationType = trim$(  x3411.CheckRelationType)
    x3411.SupplierCode = trim$(  x3411.SupplierCode)
    x3411.selUnitPrice = trim$(  x3411.selUnitPrice)
    x3411.cdUnitPrice = trim$(  x3411.cdUnitPrice)
    x3411.PriceExchange = trim$(  x3411.PriceExchange)
    x3411.DateExchange = trim$(  x3411.DateExchange)
    x3411.seDeliveryTerm = trim$(  x3411.seDeliveryTerm)
    x3411.cdDeliveryTerm = trim$(  x3411.cdDeliveryTerm)
    x3411.seOrigin = trim$(  x3411.seOrigin)
    x3411.cdOrigin = trim$(  x3411.cdOrigin)
    x3411.seCommercialTerm = trim$(  x3411.seCommercialTerm)
    x3411.cdCommercialTerm = trim$(  x3411.cdCommercialTerm)
    x3411.sePaymentTerm = trim$(  x3411.sePaymentTerm)
    x3411.cdPaymentTerm = trim$(  x3411.cdPaymentTerm)
    x3411.sePaymentCondition = trim$(  x3411.sePaymentCondition)
    x3411.cdPaymentCondition = trim$(  x3411.cdPaymentCondition)
    x3411.sePaymentTime = trim$(  x3411.sePaymentTime)
    x3411.cdPaymentTime = trim$(  x3411.cdPaymentTime)
    x3411.sePaymentDay = trim$(  x3411.sePaymentDay)
    x3411.cdPaymentDay = trim$(  x3411.cdPaymentDay)
    x3411.seBuyingType = trim$(  x3411.seBuyingType)
    x3411.cdBuyingType = trim$(  x3411.cdBuyingType)
    x3411.QualityRequest = trim$(  x3411.QualityRequest)
    x3411.ContractNo = trim$(  x3411.ContractNo)
    x3411.Tolerance = trim$(  x3411.Tolerance)
    x3411.Destination = trim$(  x3411.Destination)
    x3411.InchargePurchasing = trim$(  x3411.InchargePurchasing)
    x3411.AmountPurchasingEX = trim$(  x3411.AmountPurchasingEX)
    x3411.AmountPurchasingVND = trim$(  x3411.AmountPurchasingVND)
    x3411.AmountTax1EX = trim$(  x3411.AmountTax1EX)
    x3411.AmountTax2EX = trim$(  x3411.AmountTax2EX)
    x3411.AmountTax3EX = trim$(  x3411.AmountTax3EX)
    x3411.AmountTax1VND = trim$(  x3411.AmountTax1VND)
    x3411.AmountTax2VND = trim$(  x3411.AmountTax2VND)
    x3411.AmountTax3VND = trim$(  x3411.AmountTax3VND)
    x3411.AmountTaxEX = trim$(  x3411.AmountTaxEX)
    x3411.AmountTaxVND = trim$(  x3411.AmountTaxVND)
    x3411.AmountNoVATEX = trim$(  x3411.AmountNoVATEX)
    x3411.AmountNoVATVND = trim$(  x3411.AmountNoVATVND)
    x3411.AmountExpenseUSD = trim$(  x3411.AmountExpenseUSD)
    x3411.AmountExpenseVND = trim$(  x3411.AmountExpenseVND)
    x3411.AmountTotalEX = trim$(  x3411.AmountTotalEX)
    x3411.AmountTotalVND = trim$(  x3411.AmountTotalVND)
    x3411.DateStart = trim$(  x3411.DateStart)
    x3411.DateEstimate = trim$(  x3411.DateEstimate)
    x3411.DateDelivery = trim$(  x3411.DateDelivery)
    x3411.TimeInsert = trim$(  x3411.TimeInsert)
    x3411.TimeUpdate = trim$(  x3411.TimeUpdate)
    x3411.DateInsert = trim$(  x3411.DateInsert)
    x3411.DateUpdate = trim$(  x3411.DateUpdate)
    x3411.InchargeInsert = trim$(  x3411.InchargeInsert)
    x3411.InchargeUpdate = trim$(  x3411.InchargeUpdate)
    x3411.CheckComplete = trim$(  x3411.CheckComplete)
    x3411.Remark = trim$(  x3411.Remark)
    x3411.Remark01 = trim$(  x3411.Remark01)
    x3411.Remark02 = trim$(  x3411.Remark02)
    x3411.Remark03 = trim$(  x3411.Remark03)
    x3411.Remark04 = trim$(  x3411.Remark04)
    x3411.Remark05 = trim$(  x3411.Remark05)
    x3411.seSite = trim$(  x3411.seSite)
    x3411.cdSite = trim$(  x3411.cdSite)
     
    If trim$( x3411.PurchasingOrderNo ) = "" Then x3411.PurchasingOrderNo = Space(1) 
    If trim$( x3411.PurchasingOrderName ) = "" Then x3411.PurchasingOrderName = Space(1) 
    If trim$( x3411.seSeason ) = "" Then x3411.seSeason = Space(1) 
    If trim$( x3411.cdSeason ) = "" Then x3411.cdSeason = Space(1) 
    If trim$( x3411.CustomerCode ) = "" Then x3411.CustomerCode = Space(1) 
    If trim$( x3411.DateAccept ) = "" Then x3411.DateAccept = Space(1) 
    If trim$( x3411.CheckInPurchasingOrder ) = "" Then x3411.CheckInPurchasingOrder = Space(1) 
    If trim$( x3411.CheckOutPurchasingOrder ) = "" Then x3411.CheckOutPurchasingOrder = Space(1) 
    If trim$( x3411.CheckProcessType ) = "" Then x3411.CheckProcessType = Space(1) 
    If trim$( x3411.CheckIOType ) = "" Then x3411.CheckIOType = Space(1) 
    If trim$( x3411.CheckMaterialType ) = "" Then x3411.CheckMaterialType = Space(1) 
    If trim$( x3411.CheckMarketType ) = "" Then x3411.CheckMarketType = Space(1) 
    If trim$( x3411.CheckRelationType ) = "" Then x3411.CheckRelationType = Space(1) 
    If trim$( x3411.SupplierCode ) = "" Then x3411.SupplierCode = Space(1) 
    If trim$( x3411.selUnitPrice ) = "" Then x3411.selUnitPrice = Space(1) 
    If trim$( x3411.cdUnitPrice ) = "" Then x3411.cdUnitPrice = Space(1) 
    If trim$( x3411.PriceExchange ) = "" Then x3411.PriceExchange = 0 
    If trim$( x3411.DateExchange ) = "" Then x3411.DateExchange = Space(1) 
    If trim$( x3411.seDeliveryTerm ) = "" Then x3411.seDeliveryTerm = Space(1) 
    If trim$( x3411.cdDeliveryTerm ) = "" Then x3411.cdDeliveryTerm = Space(1) 
    If trim$( x3411.seOrigin ) = "" Then x3411.seOrigin = Space(1) 
    If trim$( x3411.cdOrigin ) = "" Then x3411.cdOrigin = Space(1) 
    If trim$( x3411.seCommercialTerm ) = "" Then x3411.seCommercialTerm = Space(1) 
    If trim$( x3411.cdCommercialTerm ) = "" Then x3411.cdCommercialTerm = Space(1) 
    If trim$( x3411.sePaymentTerm ) = "" Then x3411.sePaymentTerm = Space(1) 
    If trim$( x3411.cdPaymentTerm ) = "" Then x3411.cdPaymentTerm = Space(1) 
    If trim$( x3411.sePaymentCondition ) = "" Then x3411.sePaymentCondition = Space(1) 
    If trim$( x3411.cdPaymentCondition ) = "" Then x3411.cdPaymentCondition = Space(1) 
    If trim$( x3411.sePaymentTime ) = "" Then x3411.sePaymentTime = Space(1) 
    If trim$( x3411.cdPaymentTime ) = "" Then x3411.cdPaymentTime = Space(1) 
    If trim$( x3411.sePaymentDay ) = "" Then x3411.sePaymentDay = Space(1) 
    If trim$( x3411.cdPaymentDay ) = "" Then x3411.cdPaymentDay = Space(1) 
    If trim$( x3411.seBuyingType ) = "" Then x3411.seBuyingType = Space(1) 
    If trim$( x3411.cdBuyingType ) = "" Then x3411.cdBuyingType = Space(1) 
    If trim$( x3411.QualityRequest ) = "" Then x3411.QualityRequest = Space(1) 
    If trim$( x3411.ContractNo ) = "" Then x3411.ContractNo = Space(1) 
    If trim$( x3411.Tolerance ) = "" Then x3411.Tolerance = Space(1) 
    If trim$( x3411.Destination ) = "" Then x3411.Destination = Space(1) 
    If trim$( x3411.InchargePurchasing ) = "" Then x3411.InchargePurchasing = Space(1) 
    If trim$( x3411.AmountPurchasingEX ) = "" Then x3411.AmountPurchasingEX = 0 
    If trim$( x3411.AmountPurchasingVND ) = "" Then x3411.AmountPurchasingVND = 0 
    If trim$( x3411.AmountTax1EX ) = "" Then x3411.AmountTax1EX = 0 
    If trim$( x3411.AmountTax2EX ) = "" Then x3411.AmountTax2EX = 0 
    If trim$( x3411.AmountTax3EX ) = "" Then x3411.AmountTax3EX = 0 
    If trim$( x3411.AmountTax1VND ) = "" Then x3411.AmountTax1VND = 0 
    If trim$( x3411.AmountTax2VND ) = "" Then x3411.AmountTax2VND = 0 
    If trim$( x3411.AmountTax3VND ) = "" Then x3411.AmountTax3VND = 0 
    If trim$( x3411.AmountTaxEX ) = "" Then x3411.AmountTaxEX = 0 
    If trim$( x3411.AmountTaxVND ) = "" Then x3411.AmountTaxVND = 0 
    If trim$( x3411.AmountNoVATEX ) = "" Then x3411.AmountNoVATEX = 0 
    If trim$( x3411.AmountNoVATVND ) = "" Then x3411.AmountNoVATVND = 0 
    If trim$( x3411.AmountExpenseUSD ) = "" Then x3411.AmountExpenseUSD = 0 
    If trim$( x3411.AmountExpenseVND ) = "" Then x3411.AmountExpenseVND = 0 
    If trim$( x3411.AmountTotalEX ) = "" Then x3411.AmountTotalEX = 0 
    If trim$( x3411.AmountTotalVND ) = "" Then x3411.AmountTotalVND = 0 
    If trim$( x3411.DateStart ) = "" Then x3411.DateStart = Space(1) 
    If trim$( x3411.DateEstimate ) = "" Then x3411.DateEstimate = Space(1) 
    If trim$( x3411.DateDelivery ) = "" Then x3411.DateDelivery = Space(1) 
    If trim$( x3411.TimeInsert ) = "" Then x3411.TimeInsert = Space(1) 
    If trim$( x3411.TimeUpdate ) = "" Then x3411.TimeUpdate = Space(1) 
    If trim$( x3411.DateInsert ) = "" Then x3411.DateInsert = Space(1) 
    If trim$( x3411.DateUpdate ) = "" Then x3411.DateUpdate = Space(1) 
    If trim$( x3411.InchargeInsert ) = "" Then x3411.InchargeInsert = Space(1) 
    If trim$( x3411.InchargeUpdate ) = "" Then x3411.InchargeUpdate = Space(1) 
    If trim$( x3411.CheckComplete ) = "" Then x3411.CheckComplete = Space(1) 
    If trim$( x3411.Remark ) = "" Then x3411.Remark = Space(1) 
    If trim$( x3411.Remark01 ) = "" Then x3411.Remark01 = Space(1) 
    If trim$( x3411.Remark02 ) = "" Then x3411.Remark02 = Space(1) 
    If trim$( x3411.Remark03 ) = "" Then x3411.Remark03 = Space(1) 
    If trim$( x3411.Remark04 ) = "" Then x3411.Remark04 = Space(1) 
    If trim$( x3411.Remark05 ) = "" Then x3411.Remark05 = Space(1) 
    If trim$( x3411.seSite ) = "" Then x3411.seSite = Space(1) 
    If trim$( x3411.cdSite ) = "" Then x3411.cdSite = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K3411_MOVE(rs3411 As SqlClient.SqlDataReader)
Try

    call D3411_CLEAR()   

    If IsdbNull(rs3411!K3411_PurchasingOrderNo) = False Then D3411.PurchasingOrderNo = Trim$(rs3411!K3411_PurchasingOrderNo)
    If IsdbNull(rs3411!K3411_PurchasingOrderName) = False Then D3411.PurchasingOrderName = Trim$(rs3411!K3411_PurchasingOrderName)
    If IsdbNull(rs3411!K3411_seSeason) = False Then D3411.seSeason = Trim$(rs3411!K3411_seSeason)
    If IsdbNull(rs3411!K3411_cdSeason) = False Then D3411.cdSeason = Trim$(rs3411!K3411_cdSeason)
    If IsdbNull(rs3411!K3411_CustomerCode) = False Then D3411.CustomerCode = Trim$(rs3411!K3411_CustomerCode)
    If IsdbNull(rs3411!K3411_DateAccept) = False Then D3411.DateAccept = Trim$(rs3411!K3411_DateAccept)
    If IsdbNull(rs3411!K3411_CheckInPurchasingOrder) = False Then D3411.CheckInPurchasingOrder = Trim$(rs3411!K3411_CheckInPurchasingOrder)
    If IsdbNull(rs3411!K3411_CheckOutPurchasingOrder) = False Then D3411.CheckOutPurchasingOrder = Trim$(rs3411!K3411_CheckOutPurchasingOrder)
    If IsdbNull(rs3411!K3411_CheckProcessType) = False Then D3411.CheckProcessType = Trim$(rs3411!K3411_CheckProcessType)
    If IsdbNull(rs3411!K3411_CheckIOType) = False Then D3411.CheckIOType = Trim$(rs3411!K3411_CheckIOType)
    If IsdbNull(rs3411!K3411_CheckMaterialType) = False Then D3411.CheckMaterialType = Trim$(rs3411!K3411_CheckMaterialType)
    If IsdbNull(rs3411!K3411_CheckMarketType) = False Then D3411.CheckMarketType = Trim$(rs3411!K3411_CheckMarketType)
    If IsdbNull(rs3411!K3411_CheckRelationType) = False Then D3411.CheckRelationType = Trim$(rs3411!K3411_CheckRelationType)
    If IsdbNull(rs3411!K3411_SupplierCode) = False Then D3411.SupplierCode = Trim$(rs3411!K3411_SupplierCode)
    If IsdbNull(rs3411!K3411_selUnitPrice) = False Then D3411.selUnitPrice = Trim$(rs3411!K3411_selUnitPrice)
    If IsdbNull(rs3411!K3411_cdUnitPrice) = False Then D3411.cdUnitPrice = Trim$(rs3411!K3411_cdUnitPrice)
    If IsdbNull(rs3411!K3411_PriceExchange) = False Then D3411.PriceExchange = Trim$(rs3411!K3411_PriceExchange)
    If IsdbNull(rs3411!K3411_DateExchange) = False Then D3411.DateExchange = Trim$(rs3411!K3411_DateExchange)
    If IsdbNull(rs3411!K3411_seDeliveryTerm) = False Then D3411.seDeliveryTerm = Trim$(rs3411!K3411_seDeliveryTerm)
    If IsdbNull(rs3411!K3411_cdDeliveryTerm) = False Then D3411.cdDeliveryTerm = Trim$(rs3411!K3411_cdDeliveryTerm)
    If IsdbNull(rs3411!K3411_seOrigin) = False Then D3411.seOrigin = Trim$(rs3411!K3411_seOrigin)
    If IsdbNull(rs3411!K3411_cdOrigin) = False Then D3411.cdOrigin = Trim$(rs3411!K3411_cdOrigin)
    If IsdbNull(rs3411!K3411_seCommercialTerm) = False Then D3411.seCommercialTerm = Trim$(rs3411!K3411_seCommercialTerm)
    If IsdbNull(rs3411!K3411_cdCommercialTerm) = False Then D3411.cdCommercialTerm = Trim$(rs3411!K3411_cdCommercialTerm)
    If IsdbNull(rs3411!K3411_sePaymentTerm) = False Then D3411.sePaymentTerm = Trim$(rs3411!K3411_sePaymentTerm)
    If IsdbNull(rs3411!K3411_cdPaymentTerm) = False Then D3411.cdPaymentTerm = Trim$(rs3411!K3411_cdPaymentTerm)
    If IsdbNull(rs3411!K3411_sePaymentCondition) = False Then D3411.sePaymentCondition = Trim$(rs3411!K3411_sePaymentCondition)
    If IsdbNull(rs3411!K3411_cdPaymentCondition) = False Then D3411.cdPaymentCondition = Trim$(rs3411!K3411_cdPaymentCondition)
    If IsdbNull(rs3411!K3411_sePaymentTime) = False Then D3411.sePaymentTime = Trim$(rs3411!K3411_sePaymentTime)
    If IsdbNull(rs3411!K3411_cdPaymentTime) = False Then D3411.cdPaymentTime = Trim$(rs3411!K3411_cdPaymentTime)
    If IsdbNull(rs3411!K3411_sePaymentDay) = False Then D3411.sePaymentDay = Trim$(rs3411!K3411_sePaymentDay)
    If IsdbNull(rs3411!K3411_cdPaymentDay) = False Then D3411.cdPaymentDay = Trim$(rs3411!K3411_cdPaymentDay)
    If IsdbNull(rs3411!K3411_seBuyingType) = False Then D3411.seBuyingType = Trim$(rs3411!K3411_seBuyingType)
    If IsdbNull(rs3411!K3411_cdBuyingType) = False Then D3411.cdBuyingType = Trim$(rs3411!K3411_cdBuyingType)
    If IsdbNull(rs3411!K3411_QualityRequest) = False Then D3411.QualityRequest = Trim$(rs3411!K3411_QualityRequest)
    If IsdbNull(rs3411!K3411_ContractNo) = False Then D3411.ContractNo = Trim$(rs3411!K3411_ContractNo)
    If IsdbNull(rs3411!K3411_Tolerance) = False Then D3411.Tolerance = Trim$(rs3411!K3411_Tolerance)
    If IsdbNull(rs3411!K3411_Destination) = False Then D3411.Destination = Trim$(rs3411!K3411_Destination)
    If IsdbNull(rs3411!K3411_InchargePurchasing) = False Then D3411.InchargePurchasing = Trim$(rs3411!K3411_InchargePurchasing)
    If IsdbNull(rs3411!K3411_AmountPurchasingEX) = False Then D3411.AmountPurchasingEX = Trim$(rs3411!K3411_AmountPurchasingEX)
    If IsdbNull(rs3411!K3411_AmountPurchasingVND) = False Then D3411.AmountPurchasingVND = Trim$(rs3411!K3411_AmountPurchasingVND)
    If IsdbNull(rs3411!K3411_AmountTax1EX) = False Then D3411.AmountTax1EX = Trim$(rs3411!K3411_AmountTax1EX)
    If IsdbNull(rs3411!K3411_AmountTax2EX) = False Then D3411.AmountTax2EX = Trim$(rs3411!K3411_AmountTax2EX)
    If IsdbNull(rs3411!K3411_AmountTax3EX) = False Then D3411.AmountTax3EX = Trim$(rs3411!K3411_AmountTax3EX)
    If IsdbNull(rs3411!K3411_AmountTax1VND) = False Then D3411.AmountTax1VND = Trim$(rs3411!K3411_AmountTax1VND)
    If IsdbNull(rs3411!K3411_AmountTax2VND) = False Then D3411.AmountTax2VND = Trim$(rs3411!K3411_AmountTax2VND)
    If IsdbNull(rs3411!K3411_AmountTax3VND) = False Then D3411.AmountTax3VND = Trim$(rs3411!K3411_AmountTax3VND)
    If IsdbNull(rs3411!K3411_AmountTaxEX) = False Then D3411.AmountTaxEX = Trim$(rs3411!K3411_AmountTaxEX)
    If IsdbNull(rs3411!K3411_AmountTaxVND) = False Then D3411.AmountTaxVND = Trim$(rs3411!K3411_AmountTaxVND)
    If IsdbNull(rs3411!K3411_AmountNoVATEX) = False Then D3411.AmountNoVATEX = Trim$(rs3411!K3411_AmountNoVATEX)
    If IsdbNull(rs3411!K3411_AmountNoVATVND) = False Then D3411.AmountNoVATVND = Trim$(rs3411!K3411_AmountNoVATVND)
    If IsdbNull(rs3411!K3411_AmountExpenseUSD) = False Then D3411.AmountExpenseUSD = Trim$(rs3411!K3411_AmountExpenseUSD)
    If IsdbNull(rs3411!K3411_AmountExpenseVND) = False Then D3411.AmountExpenseVND = Trim$(rs3411!K3411_AmountExpenseVND)
    If IsdbNull(rs3411!K3411_AmountTotalEX) = False Then D3411.AmountTotalEX = Trim$(rs3411!K3411_AmountTotalEX)
    If IsdbNull(rs3411!K3411_AmountTotalVND) = False Then D3411.AmountTotalVND = Trim$(rs3411!K3411_AmountTotalVND)
    If IsdbNull(rs3411!K3411_DateStart) = False Then D3411.DateStart = Trim$(rs3411!K3411_DateStart)
    If IsdbNull(rs3411!K3411_DateEstimate) = False Then D3411.DateEstimate = Trim$(rs3411!K3411_DateEstimate)
    If IsdbNull(rs3411!K3411_DateDelivery) = False Then D3411.DateDelivery = Trim$(rs3411!K3411_DateDelivery)
    If IsdbNull(rs3411!K3411_TimeInsert) = False Then D3411.TimeInsert = Trim$(rs3411!K3411_TimeInsert)
    If IsdbNull(rs3411!K3411_TimeUpdate) = False Then D3411.TimeUpdate = Trim$(rs3411!K3411_TimeUpdate)
    If IsdbNull(rs3411!K3411_DateInsert) = False Then D3411.DateInsert = Trim$(rs3411!K3411_DateInsert)
    If IsdbNull(rs3411!K3411_DateUpdate) = False Then D3411.DateUpdate = Trim$(rs3411!K3411_DateUpdate)
    If IsdbNull(rs3411!K3411_InchargeInsert) = False Then D3411.InchargeInsert = Trim$(rs3411!K3411_InchargeInsert)
    If IsdbNull(rs3411!K3411_InchargeUpdate) = False Then D3411.InchargeUpdate = Trim$(rs3411!K3411_InchargeUpdate)
    If IsdbNull(rs3411!K3411_CheckComplete) = False Then D3411.CheckComplete = Trim$(rs3411!K3411_CheckComplete)
    If IsdbNull(rs3411!K3411_Remark) = False Then D3411.Remark = Trim$(rs3411!K3411_Remark)
    If IsdbNull(rs3411!K3411_Remark01) = False Then D3411.Remark01 = Trim$(rs3411!K3411_Remark01)
    If IsdbNull(rs3411!K3411_Remark02) = False Then D3411.Remark02 = Trim$(rs3411!K3411_Remark02)
    If IsdbNull(rs3411!K3411_Remark03) = False Then D3411.Remark03 = Trim$(rs3411!K3411_Remark03)
    If IsdbNull(rs3411!K3411_Remark04) = False Then D3411.Remark04 = Trim$(rs3411!K3411_Remark04)
    If IsdbNull(rs3411!K3411_Remark05) = False Then D3411.Remark05 = Trim$(rs3411!K3411_Remark05)
    If IsdbNull(rs3411!K3411_seSite) = False Then D3411.seSite = Trim$(rs3411!K3411_seSite)
    If IsdbNull(rs3411!K3411_cdSite) = False Then D3411.cdSite = Trim$(rs3411!K3411_cdSite)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K3411_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K3411_MOVE(rs3411 As DataRow)
Try

    call D3411_CLEAR()   

    If IsdbNull(rs3411!K3411_PurchasingOrderNo) = False Then D3411.PurchasingOrderNo = Trim$(rs3411!K3411_PurchasingOrderNo)
    If IsdbNull(rs3411!K3411_PurchasingOrderName) = False Then D3411.PurchasingOrderName = Trim$(rs3411!K3411_PurchasingOrderName)
    If IsdbNull(rs3411!K3411_seSeason) = False Then D3411.seSeason = Trim$(rs3411!K3411_seSeason)
    If IsdbNull(rs3411!K3411_cdSeason) = False Then D3411.cdSeason = Trim$(rs3411!K3411_cdSeason)
    If IsdbNull(rs3411!K3411_CustomerCode) = False Then D3411.CustomerCode = Trim$(rs3411!K3411_CustomerCode)
    If IsdbNull(rs3411!K3411_DateAccept) = False Then D3411.DateAccept = Trim$(rs3411!K3411_DateAccept)
    If IsdbNull(rs3411!K3411_CheckInPurchasingOrder) = False Then D3411.CheckInPurchasingOrder = Trim$(rs3411!K3411_CheckInPurchasingOrder)
    If IsdbNull(rs3411!K3411_CheckOutPurchasingOrder) = False Then D3411.CheckOutPurchasingOrder = Trim$(rs3411!K3411_CheckOutPurchasingOrder)
    If IsdbNull(rs3411!K3411_CheckProcessType) = False Then D3411.CheckProcessType = Trim$(rs3411!K3411_CheckProcessType)
    If IsdbNull(rs3411!K3411_CheckIOType) = False Then D3411.CheckIOType = Trim$(rs3411!K3411_CheckIOType)
    If IsdbNull(rs3411!K3411_CheckMaterialType) = False Then D3411.CheckMaterialType = Trim$(rs3411!K3411_CheckMaterialType)
    If IsdbNull(rs3411!K3411_CheckMarketType) = False Then D3411.CheckMarketType = Trim$(rs3411!K3411_CheckMarketType)
    If IsdbNull(rs3411!K3411_CheckRelationType) = False Then D3411.CheckRelationType = Trim$(rs3411!K3411_CheckRelationType)
    If IsdbNull(rs3411!K3411_SupplierCode) = False Then D3411.SupplierCode = Trim$(rs3411!K3411_SupplierCode)
    If IsdbNull(rs3411!K3411_selUnitPrice) = False Then D3411.selUnitPrice = Trim$(rs3411!K3411_selUnitPrice)
    If IsdbNull(rs3411!K3411_cdUnitPrice) = False Then D3411.cdUnitPrice = Trim$(rs3411!K3411_cdUnitPrice)
    If IsdbNull(rs3411!K3411_PriceExchange) = False Then D3411.PriceExchange = Trim$(rs3411!K3411_PriceExchange)
    If IsdbNull(rs3411!K3411_DateExchange) = False Then D3411.DateExchange = Trim$(rs3411!K3411_DateExchange)
    If IsdbNull(rs3411!K3411_seDeliveryTerm) = False Then D3411.seDeliveryTerm = Trim$(rs3411!K3411_seDeliveryTerm)
    If IsdbNull(rs3411!K3411_cdDeliveryTerm) = False Then D3411.cdDeliveryTerm = Trim$(rs3411!K3411_cdDeliveryTerm)
    If IsdbNull(rs3411!K3411_seOrigin) = False Then D3411.seOrigin = Trim$(rs3411!K3411_seOrigin)
    If IsdbNull(rs3411!K3411_cdOrigin) = False Then D3411.cdOrigin = Trim$(rs3411!K3411_cdOrigin)
    If IsdbNull(rs3411!K3411_seCommercialTerm) = False Then D3411.seCommercialTerm = Trim$(rs3411!K3411_seCommercialTerm)
    If IsdbNull(rs3411!K3411_cdCommercialTerm) = False Then D3411.cdCommercialTerm = Trim$(rs3411!K3411_cdCommercialTerm)
    If IsdbNull(rs3411!K3411_sePaymentTerm) = False Then D3411.sePaymentTerm = Trim$(rs3411!K3411_sePaymentTerm)
    If IsdbNull(rs3411!K3411_cdPaymentTerm) = False Then D3411.cdPaymentTerm = Trim$(rs3411!K3411_cdPaymentTerm)
    If IsdbNull(rs3411!K3411_sePaymentCondition) = False Then D3411.sePaymentCondition = Trim$(rs3411!K3411_sePaymentCondition)
    If IsdbNull(rs3411!K3411_cdPaymentCondition) = False Then D3411.cdPaymentCondition = Trim$(rs3411!K3411_cdPaymentCondition)
    If IsdbNull(rs3411!K3411_sePaymentTime) = False Then D3411.sePaymentTime = Trim$(rs3411!K3411_sePaymentTime)
    If IsdbNull(rs3411!K3411_cdPaymentTime) = False Then D3411.cdPaymentTime = Trim$(rs3411!K3411_cdPaymentTime)
    If IsdbNull(rs3411!K3411_sePaymentDay) = False Then D3411.sePaymentDay = Trim$(rs3411!K3411_sePaymentDay)
    If IsdbNull(rs3411!K3411_cdPaymentDay) = False Then D3411.cdPaymentDay = Trim$(rs3411!K3411_cdPaymentDay)
    If IsdbNull(rs3411!K3411_seBuyingType) = False Then D3411.seBuyingType = Trim$(rs3411!K3411_seBuyingType)
    If IsdbNull(rs3411!K3411_cdBuyingType) = False Then D3411.cdBuyingType = Trim$(rs3411!K3411_cdBuyingType)
    If IsdbNull(rs3411!K3411_QualityRequest) = False Then D3411.QualityRequest = Trim$(rs3411!K3411_QualityRequest)
    If IsdbNull(rs3411!K3411_ContractNo) = False Then D3411.ContractNo = Trim$(rs3411!K3411_ContractNo)
    If IsdbNull(rs3411!K3411_Tolerance) = False Then D3411.Tolerance = Trim$(rs3411!K3411_Tolerance)
    If IsdbNull(rs3411!K3411_Destination) = False Then D3411.Destination = Trim$(rs3411!K3411_Destination)
    If IsdbNull(rs3411!K3411_InchargePurchasing) = False Then D3411.InchargePurchasing = Trim$(rs3411!K3411_InchargePurchasing)
    If IsdbNull(rs3411!K3411_AmountPurchasingEX) = False Then D3411.AmountPurchasingEX = Trim$(rs3411!K3411_AmountPurchasingEX)
    If IsdbNull(rs3411!K3411_AmountPurchasingVND) = False Then D3411.AmountPurchasingVND = Trim$(rs3411!K3411_AmountPurchasingVND)
    If IsdbNull(rs3411!K3411_AmountTax1EX) = False Then D3411.AmountTax1EX = Trim$(rs3411!K3411_AmountTax1EX)
    If IsdbNull(rs3411!K3411_AmountTax2EX) = False Then D3411.AmountTax2EX = Trim$(rs3411!K3411_AmountTax2EX)
    If IsdbNull(rs3411!K3411_AmountTax3EX) = False Then D3411.AmountTax3EX = Trim$(rs3411!K3411_AmountTax3EX)
    If IsdbNull(rs3411!K3411_AmountTax1VND) = False Then D3411.AmountTax1VND = Trim$(rs3411!K3411_AmountTax1VND)
    If IsdbNull(rs3411!K3411_AmountTax2VND) = False Then D3411.AmountTax2VND = Trim$(rs3411!K3411_AmountTax2VND)
    If IsdbNull(rs3411!K3411_AmountTax3VND) = False Then D3411.AmountTax3VND = Trim$(rs3411!K3411_AmountTax3VND)
    If IsdbNull(rs3411!K3411_AmountTaxEX) = False Then D3411.AmountTaxEX = Trim$(rs3411!K3411_AmountTaxEX)
    If IsdbNull(rs3411!K3411_AmountTaxVND) = False Then D3411.AmountTaxVND = Trim$(rs3411!K3411_AmountTaxVND)
    If IsdbNull(rs3411!K3411_AmountNoVATEX) = False Then D3411.AmountNoVATEX = Trim$(rs3411!K3411_AmountNoVATEX)
    If IsdbNull(rs3411!K3411_AmountNoVATVND) = False Then D3411.AmountNoVATVND = Trim$(rs3411!K3411_AmountNoVATVND)
    If IsdbNull(rs3411!K3411_AmountExpenseUSD) = False Then D3411.AmountExpenseUSD = Trim$(rs3411!K3411_AmountExpenseUSD)
    If IsdbNull(rs3411!K3411_AmountExpenseVND) = False Then D3411.AmountExpenseVND = Trim$(rs3411!K3411_AmountExpenseVND)
    If IsdbNull(rs3411!K3411_AmountTotalEX) = False Then D3411.AmountTotalEX = Trim$(rs3411!K3411_AmountTotalEX)
    If IsdbNull(rs3411!K3411_AmountTotalVND) = False Then D3411.AmountTotalVND = Trim$(rs3411!K3411_AmountTotalVND)
    If IsdbNull(rs3411!K3411_DateStart) = False Then D3411.DateStart = Trim$(rs3411!K3411_DateStart)
    If IsdbNull(rs3411!K3411_DateEstimate) = False Then D3411.DateEstimate = Trim$(rs3411!K3411_DateEstimate)
    If IsdbNull(rs3411!K3411_DateDelivery) = False Then D3411.DateDelivery = Trim$(rs3411!K3411_DateDelivery)
    If IsdbNull(rs3411!K3411_TimeInsert) = False Then D3411.TimeInsert = Trim$(rs3411!K3411_TimeInsert)
    If IsdbNull(rs3411!K3411_TimeUpdate) = False Then D3411.TimeUpdate = Trim$(rs3411!K3411_TimeUpdate)
    If IsdbNull(rs3411!K3411_DateInsert) = False Then D3411.DateInsert = Trim$(rs3411!K3411_DateInsert)
    If IsdbNull(rs3411!K3411_DateUpdate) = False Then D3411.DateUpdate = Trim$(rs3411!K3411_DateUpdate)
    If IsdbNull(rs3411!K3411_InchargeInsert) = False Then D3411.InchargeInsert = Trim$(rs3411!K3411_InchargeInsert)
    If IsdbNull(rs3411!K3411_InchargeUpdate) = False Then D3411.InchargeUpdate = Trim$(rs3411!K3411_InchargeUpdate)
    If IsdbNull(rs3411!K3411_CheckComplete) = False Then D3411.CheckComplete = Trim$(rs3411!K3411_CheckComplete)
    If IsdbNull(rs3411!K3411_Remark) = False Then D3411.Remark = Trim$(rs3411!K3411_Remark)
    If IsdbNull(rs3411!K3411_Remark01) = False Then D3411.Remark01 = Trim$(rs3411!K3411_Remark01)
    If IsdbNull(rs3411!K3411_Remark02) = False Then D3411.Remark02 = Trim$(rs3411!K3411_Remark02)
    If IsdbNull(rs3411!K3411_Remark03) = False Then D3411.Remark03 = Trim$(rs3411!K3411_Remark03)
    If IsdbNull(rs3411!K3411_Remark04) = False Then D3411.Remark04 = Trim$(rs3411!K3411_Remark04)
    If IsdbNull(rs3411!K3411_Remark05) = False Then D3411.Remark05 = Trim$(rs3411!K3411_Remark05)
    If IsdbNull(rs3411!K3411_seSite) = False Then D3411.seSite = Trim$(rs3411!K3411_seSite)
    If IsdbNull(rs3411!K3411_cdSite) = False Then D3411.cdSite = Trim$(rs3411!K3411_cdSite)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K3411_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K3411_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z3411 As T3411_AREA, Job as String, PURCHASINGORDERNO AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K3411_MOVE = False

Try
    If READ_PFK3411(PURCHASINGORDERNO) = True Then
                z3411 = D3411
		K3411_MOVE = True
		else
	z3411 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3411")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "PURCHASINGORDERNO":z3411.PurchasingOrderNo = Children(i).Code
   Case "PURCHASINGORDERNAME":z3411.PurchasingOrderName = Children(i).Code
   Case "SESEASON":z3411.seSeason = Children(i).Code
   Case "CDSEASON":z3411.cdSeason = Children(i).Code
   Case "CUSTOMERCODE":z3411.CustomerCode = Children(i).Code
   Case "DATEACCEPT":z3411.DateAccept = Children(i).Code
   Case "CHECKINPURCHASINGORDER":z3411.CheckInPurchasingOrder = Children(i).Code
   Case "CHECKOUTPURCHASINGORDER":z3411.CheckOutPurchasingOrder = Children(i).Code
   Case "CHECKPROCESSTYPE":z3411.CheckProcessType = Children(i).Code
   Case "CHECKIOTYPE":z3411.CheckIOType = Children(i).Code
   Case "CHECKMATERIALTYPE":z3411.CheckMaterialType = Children(i).Code
   Case "CHECKMARKETTYPE":z3411.CheckMarketType = Children(i).Code
   Case "CHECKRELATIONTYPE":z3411.CheckRelationType = Children(i).Code
   Case "SUPPLIERCODE":z3411.SupplierCode = Children(i).Code
   Case "SELUNITPRICE":z3411.selUnitPrice = Children(i).Code
   Case "CDUNITPRICE":z3411.cdUnitPrice = Children(i).Code
   Case "PRICEEXCHANGE":z3411.PriceExchange = Children(i).Code
   Case "DATEEXCHANGE":z3411.DateExchange = Children(i).Code
   Case "SEDELIVERYTERM":z3411.seDeliveryTerm = Children(i).Code
   Case "CDDELIVERYTERM":z3411.cdDeliveryTerm = Children(i).Code
   Case "SEORIGIN":z3411.seOrigin = Children(i).Code
   Case "CDORIGIN":z3411.cdOrigin = Children(i).Code
   Case "SECOMMERCIALTERM":z3411.seCommercialTerm = Children(i).Code
   Case "CDCOMMERCIALTERM":z3411.cdCommercialTerm = Children(i).Code
   Case "SEPAYMENTTERM":z3411.sePaymentTerm = Children(i).Code
   Case "CDPAYMENTTERM":z3411.cdPaymentTerm = Children(i).Code
   Case "SEPAYMENTCONDITION":z3411.sePaymentCondition = Children(i).Code
   Case "CDPAYMENTCONDITION":z3411.cdPaymentCondition = Children(i).Code
   Case "SEPAYMENTTIME":z3411.sePaymentTime = Children(i).Code
   Case "CDPAYMENTTIME":z3411.cdPaymentTime = Children(i).Code
   Case "SEPAYMENTDAY":z3411.sePaymentDay = Children(i).Code
   Case "CDPAYMENTDAY":z3411.cdPaymentDay = Children(i).Code
   Case "SEBUYINGTYPE":z3411.seBuyingType = Children(i).Code
   Case "CDBUYINGTYPE":z3411.cdBuyingType = Children(i).Code
   Case "QUALITYREQUEST":z3411.QualityRequest = Children(i).Code
   Case "CONTRACTNO":z3411.ContractNo = Children(i).Code
   Case "TOLERANCE":z3411.Tolerance = Children(i).Code
   Case "DESTINATION":z3411.Destination = Children(i).Code
   Case "INCHARGEPURCHASING":z3411.InchargePurchasing = Children(i).Code
   Case "AMOUNTPURCHASINGEX":z3411.AmountPurchasingEX = Children(i).Code
   Case "AMOUNTPURCHASINGVND":z3411.AmountPurchasingVND = Children(i).Code
   Case "AMOUNTTAX1EX":z3411.AmountTax1EX = Children(i).Code
   Case "AMOUNTTAX2EX":z3411.AmountTax2EX = Children(i).Code
   Case "AMOUNTTAX3EX":z3411.AmountTax3EX = Children(i).Code
   Case "AMOUNTTAX1VND":z3411.AmountTax1VND = Children(i).Code
   Case "AMOUNTTAX2VND":z3411.AmountTax2VND = Children(i).Code
   Case "AMOUNTTAX3VND":z3411.AmountTax3VND = Children(i).Code
   Case "AMOUNTTAXEX":z3411.AmountTaxEX = Children(i).Code
   Case "AMOUNTTAXVND":z3411.AmountTaxVND = Children(i).Code
   Case "AMOUNTNOVATEX":z3411.AmountNoVATEX = Children(i).Code
   Case "AMOUNTNOVATVND":z3411.AmountNoVATVND = Children(i).Code
   Case "AMOUNTEXPENSEUSD":z3411.AmountExpenseUSD = Children(i).Code
   Case "AMOUNTEXPENSEVND":z3411.AmountExpenseVND = Children(i).Code
   Case "AMOUNTTOTALEX":z3411.AmountTotalEX = Children(i).Code
   Case "AMOUNTTOTALVND":z3411.AmountTotalVND = Children(i).Code
   Case "DATESTART":z3411.DateStart = Children(i).Code
   Case "DATEESTIMATE":z3411.DateEstimate = Children(i).Code
   Case "DATEDELIVERY":z3411.DateDelivery = Children(i).Code
   Case "TIMEINSERT":z3411.TimeInsert = Children(i).Code
   Case "TIMEUPDATE":z3411.TimeUpdate = Children(i).Code
   Case "DATEINSERT":z3411.DateInsert = Children(i).Code
   Case "DATEUPDATE":z3411.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z3411.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z3411.InchargeUpdate = Children(i).Code
   Case "CHECKCOMPLETE":z3411.CheckComplete = Children(i).Code
   Case "REMARK":z3411.Remark = Children(i).Code
   Case "REMARK01":z3411.Remark01 = Children(i).Code
   Case "REMARK02":z3411.Remark02 = Children(i).Code
   Case "REMARK03":z3411.Remark03 = Children(i).Code
   Case "REMARK04":z3411.Remark04 = Children(i).Code
   Case "REMARK05":z3411.Remark05 = Children(i).Code
   Case "SESITE":z3411.seSite = Children(i).Code
   Case "CDSITE":z3411.cdSite = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "PURCHASINGORDERNO":z3411.PurchasingOrderNo = Children(i).Data
   Case "PURCHASINGORDERNAME":z3411.PurchasingOrderName = Children(i).Data
   Case "SESEASON":z3411.seSeason = Children(i).Data
   Case "CDSEASON":z3411.cdSeason = Children(i).Data
   Case "CUSTOMERCODE":z3411.CustomerCode = Children(i).Data
   Case "DATEACCEPT":z3411.DateAccept = Children(i).Data
   Case "CHECKINPURCHASINGORDER":z3411.CheckInPurchasingOrder = Children(i).Data
   Case "CHECKOUTPURCHASINGORDER":z3411.CheckOutPurchasingOrder = Children(i).Data
   Case "CHECKPROCESSTYPE":z3411.CheckProcessType = Children(i).Data
   Case "CHECKIOTYPE":z3411.CheckIOType = Children(i).Data
   Case "CHECKMATERIALTYPE":z3411.CheckMaterialType = Children(i).Data
   Case "CHECKMARKETTYPE":z3411.CheckMarketType = Children(i).Data
   Case "CHECKRELATIONTYPE":z3411.CheckRelationType = Children(i).Data
   Case "SUPPLIERCODE":z3411.SupplierCode = Children(i).Data
   Case "SELUNITPRICE":z3411.selUnitPrice = Children(i).Data
   Case "CDUNITPRICE":z3411.cdUnitPrice = Children(i).Data
   Case "PRICEEXCHANGE":z3411.PriceExchange = Cdecp(Children(i).Data)
   Case "DATEEXCHANGE":z3411.DateExchange = Children(i).Data
   Case "SEDELIVERYTERM":z3411.seDeliveryTerm = Children(i).Data
   Case "CDDELIVERYTERM":z3411.cdDeliveryTerm = Children(i).Data
   Case "SEORIGIN":z3411.seOrigin = Children(i).Data
   Case "CDORIGIN":z3411.cdOrigin = Children(i).Data
   Case "SECOMMERCIALTERM":z3411.seCommercialTerm = Children(i).Data
   Case "CDCOMMERCIALTERM":z3411.cdCommercialTerm = Children(i).Data
   Case "SEPAYMENTTERM":z3411.sePaymentTerm = Children(i).Data
   Case "CDPAYMENTTERM":z3411.cdPaymentTerm = Children(i).Data
   Case "SEPAYMENTCONDITION":z3411.sePaymentCondition = Children(i).Data
   Case "CDPAYMENTCONDITION":z3411.cdPaymentCondition = Children(i).Data
   Case "SEPAYMENTTIME":z3411.sePaymentTime = Children(i).Data
   Case "CDPAYMENTTIME":z3411.cdPaymentTime = Children(i).Data
   Case "SEPAYMENTDAY":z3411.sePaymentDay = Children(i).Data
   Case "CDPAYMENTDAY":z3411.cdPaymentDay = Children(i).Data
   Case "SEBUYINGTYPE":z3411.seBuyingType = Children(i).Data
   Case "CDBUYINGTYPE":z3411.cdBuyingType = Children(i).Data
   Case "QUALITYREQUEST":z3411.QualityRequest = Children(i).Data
   Case "CONTRACTNO":z3411.ContractNo = Children(i).Data
   Case "TOLERANCE":z3411.Tolerance = Children(i).Data
   Case "DESTINATION":z3411.Destination = Children(i).Data
   Case "INCHARGEPURCHASING":z3411.InchargePurchasing = Children(i).Data
   Case "AMOUNTPURCHASINGEX":z3411.AmountPurchasingEX = Cdecp(Children(i).Data)
   Case "AMOUNTPURCHASINGVND":z3411.AmountPurchasingVND = Cdecp(Children(i).Data)
   Case "AMOUNTTAX1EX":z3411.AmountTax1EX = Cdecp(Children(i).Data)
   Case "AMOUNTTAX2EX":z3411.AmountTax2EX = Cdecp(Children(i).Data)
   Case "AMOUNTTAX3EX":z3411.AmountTax3EX = Cdecp(Children(i).Data)
   Case "AMOUNTTAX1VND":z3411.AmountTax1VND = Cdecp(Children(i).Data)
   Case "AMOUNTTAX2VND":z3411.AmountTax2VND = Cdecp(Children(i).Data)
   Case "AMOUNTTAX3VND":z3411.AmountTax3VND = Cdecp(Children(i).Data)
   Case "AMOUNTTAXEX":z3411.AmountTaxEX = Cdecp(Children(i).Data)
   Case "AMOUNTTAXVND":z3411.AmountTaxVND = Cdecp(Children(i).Data)
   Case "AMOUNTNOVATEX":z3411.AmountNoVATEX = Cdecp(Children(i).Data)
   Case "AMOUNTNOVATVND":z3411.AmountNoVATVND = Cdecp(Children(i).Data)
   Case "AMOUNTEXPENSEUSD":z3411.AmountExpenseUSD = Cdecp(Children(i).Data)
   Case "AMOUNTEXPENSEVND":z3411.AmountExpenseVND = Cdecp(Children(i).Data)
   Case "AMOUNTTOTALEX":z3411.AmountTotalEX = Cdecp(Children(i).Data)
   Case "AMOUNTTOTALVND":z3411.AmountTotalVND = Cdecp(Children(i).Data)
   Case "DATESTART":z3411.DateStart = Children(i).Data
   Case "DATEESTIMATE":z3411.DateEstimate = Children(i).Data
   Case "DATEDELIVERY":z3411.DateDelivery = Children(i).Data
   Case "TIMEINSERT":z3411.TimeInsert = Children(i).Data
   Case "TIMEUPDATE":z3411.TimeUpdate = Children(i).Data
   Case "DATEINSERT":z3411.DateInsert = Children(i).Data
   Case "DATEUPDATE":z3411.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z3411.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z3411.InchargeUpdate = Children(i).Data
   Case "CHECKCOMPLETE":z3411.CheckComplete = Children(i).Data
   Case "REMARK":z3411.Remark = Children(i).Data
   Case "REMARK01":z3411.Remark01 = Children(i).Data
   Case "REMARK02":z3411.Remark02 = Children(i).Data
   Case "REMARK03":z3411.Remark03 = Children(i).Data
   Case "REMARK04":z3411.Remark04 = Children(i).Data
   Case "REMARK05":z3411.Remark05 = Children(i).Data
   Case "SESITE":z3411.seSite = Children(i).Data
   Case "CDSITE":z3411.cdSite = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K3411_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K3411_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z3411 As T3411_AREA, Job as String, CheckClear as Boolean, PURCHASINGORDERNO AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K3411_MOVE = False

Try
    If READ_PFK3411(PURCHASINGORDERNO) = True Then
                z3411 = D3411
		K3411_MOVE = True
		else
	If CheckClear  = True then z3411 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3411")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "PURCHASINGORDERNO":z3411.PurchasingOrderNo = Children(i).Code
   Case "PURCHASINGORDERNAME":z3411.PurchasingOrderName = Children(i).Code
   Case "SESEASON":z3411.seSeason = Children(i).Code
   Case "CDSEASON":z3411.cdSeason = Children(i).Code
   Case "CUSTOMERCODE":z3411.CustomerCode = Children(i).Code
   Case "DATEACCEPT":z3411.DateAccept = Children(i).Code
   Case "CHECKINPURCHASINGORDER":z3411.CheckInPurchasingOrder = Children(i).Code
   Case "CHECKOUTPURCHASINGORDER":z3411.CheckOutPurchasingOrder = Children(i).Code
   Case "CHECKPROCESSTYPE":z3411.CheckProcessType = Children(i).Code
   Case "CHECKIOTYPE":z3411.CheckIOType = Children(i).Code
   Case "CHECKMATERIALTYPE":z3411.CheckMaterialType = Children(i).Code
   Case "CHECKMARKETTYPE":z3411.CheckMarketType = Children(i).Code
   Case "CHECKRELATIONTYPE":z3411.CheckRelationType = Children(i).Code
   Case "SUPPLIERCODE":z3411.SupplierCode = Children(i).Code
   Case "SELUNITPRICE":z3411.selUnitPrice = Children(i).Code
   Case "CDUNITPRICE":z3411.cdUnitPrice = Children(i).Code
   Case "PRICEEXCHANGE":z3411.PriceExchange = Children(i).Code
   Case "DATEEXCHANGE":z3411.DateExchange = Children(i).Code
   Case "SEDELIVERYTERM":z3411.seDeliveryTerm = Children(i).Code
   Case "CDDELIVERYTERM":z3411.cdDeliveryTerm = Children(i).Code
   Case "SEORIGIN":z3411.seOrigin = Children(i).Code
   Case "CDORIGIN":z3411.cdOrigin = Children(i).Code
   Case "SECOMMERCIALTERM":z3411.seCommercialTerm = Children(i).Code
   Case "CDCOMMERCIALTERM":z3411.cdCommercialTerm = Children(i).Code
   Case "SEPAYMENTTERM":z3411.sePaymentTerm = Children(i).Code
   Case "CDPAYMENTTERM":z3411.cdPaymentTerm = Children(i).Code
   Case "SEPAYMENTCONDITION":z3411.sePaymentCondition = Children(i).Code
   Case "CDPAYMENTCONDITION":z3411.cdPaymentCondition = Children(i).Code
   Case "SEPAYMENTTIME":z3411.sePaymentTime = Children(i).Code
   Case "CDPAYMENTTIME":z3411.cdPaymentTime = Children(i).Code
   Case "SEPAYMENTDAY":z3411.sePaymentDay = Children(i).Code
   Case "CDPAYMENTDAY":z3411.cdPaymentDay = Children(i).Code
   Case "SEBUYINGTYPE":z3411.seBuyingType = Children(i).Code
   Case "CDBUYINGTYPE":z3411.cdBuyingType = Children(i).Code
   Case "QUALITYREQUEST":z3411.QualityRequest = Children(i).Code
   Case "CONTRACTNO":z3411.ContractNo = Children(i).Code
   Case "TOLERANCE":z3411.Tolerance = Children(i).Code
   Case "DESTINATION":z3411.Destination = Children(i).Code
   Case "INCHARGEPURCHASING":z3411.InchargePurchasing = Children(i).Code
   Case "AMOUNTPURCHASINGEX":z3411.AmountPurchasingEX = Children(i).Code
   Case "AMOUNTPURCHASINGVND":z3411.AmountPurchasingVND = Children(i).Code
   Case "AMOUNTTAX1EX":z3411.AmountTax1EX = Children(i).Code
   Case "AMOUNTTAX2EX":z3411.AmountTax2EX = Children(i).Code
   Case "AMOUNTTAX3EX":z3411.AmountTax3EX = Children(i).Code
   Case "AMOUNTTAX1VND":z3411.AmountTax1VND = Children(i).Code
   Case "AMOUNTTAX2VND":z3411.AmountTax2VND = Children(i).Code
   Case "AMOUNTTAX3VND":z3411.AmountTax3VND = Children(i).Code
   Case "AMOUNTTAXEX":z3411.AmountTaxEX = Children(i).Code
   Case "AMOUNTTAXVND":z3411.AmountTaxVND = Children(i).Code
   Case "AMOUNTNOVATEX":z3411.AmountNoVATEX = Children(i).Code
   Case "AMOUNTNOVATVND":z3411.AmountNoVATVND = Children(i).Code
   Case "AMOUNTEXPENSEUSD":z3411.AmountExpenseUSD = Children(i).Code
   Case "AMOUNTEXPENSEVND":z3411.AmountExpenseVND = Children(i).Code
   Case "AMOUNTTOTALEX":z3411.AmountTotalEX = Children(i).Code
   Case "AMOUNTTOTALVND":z3411.AmountTotalVND = Children(i).Code
   Case "DATESTART":z3411.DateStart = Children(i).Code
   Case "DATEESTIMATE":z3411.DateEstimate = Children(i).Code
   Case "DATEDELIVERY":z3411.DateDelivery = Children(i).Code
   Case "TIMEINSERT":z3411.TimeInsert = Children(i).Code
   Case "TIMEUPDATE":z3411.TimeUpdate = Children(i).Code
   Case "DATEINSERT":z3411.DateInsert = Children(i).Code
   Case "DATEUPDATE":z3411.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z3411.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z3411.InchargeUpdate = Children(i).Code
   Case "CHECKCOMPLETE":z3411.CheckComplete = Children(i).Code
   Case "REMARK":z3411.Remark = Children(i).Code
   Case "REMARK01":z3411.Remark01 = Children(i).Code
   Case "REMARK02":z3411.Remark02 = Children(i).Code
   Case "REMARK03":z3411.Remark03 = Children(i).Code
   Case "REMARK04":z3411.Remark04 = Children(i).Code
   Case "REMARK05":z3411.Remark05 = Children(i).Code
   Case "SESITE":z3411.seSite = Children(i).Code
   Case "CDSITE":z3411.cdSite = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "PURCHASINGORDERNO":z3411.PurchasingOrderNo = Children(i).Data
   Case "PURCHASINGORDERNAME":z3411.PurchasingOrderName = Children(i).Data
   Case "SESEASON":z3411.seSeason = Children(i).Data
   Case "CDSEASON":z3411.cdSeason = Children(i).Data
   Case "CUSTOMERCODE":z3411.CustomerCode = Children(i).Data
   Case "DATEACCEPT":z3411.DateAccept = Children(i).Data
   Case "CHECKINPURCHASINGORDER":z3411.CheckInPurchasingOrder = Children(i).Data
   Case "CHECKOUTPURCHASINGORDER":z3411.CheckOutPurchasingOrder = Children(i).Data
   Case "CHECKPROCESSTYPE":z3411.CheckProcessType = Children(i).Data
   Case "CHECKIOTYPE":z3411.CheckIOType = Children(i).Data
   Case "CHECKMATERIALTYPE":z3411.CheckMaterialType = Children(i).Data
   Case "CHECKMARKETTYPE":z3411.CheckMarketType = Children(i).Data
   Case "CHECKRELATIONTYPE":z3411.CheckRelationType = Children(i).Data
   Case "SUPPLIERCODE":z3411.SupplierCode = Children(i).Data
   Case "SELUNITPRICE":z3411.selUnitPrice = Children(i).Data
   Case "CDUNITPRICE":z3411.cdUnitPrice = Children(i).Data
   Case "PRICEEXCHANGE":z3411.PriceExchange = Cdecp(Children(i).Data)
   Case "DATEEXCHANGE":z3411.DateExchange = Children(i).Data
   Case "SEDELIVERYTERM":z3411.seDeliveryTerm = Children(i).Data
   Case "CDDELIVERYTERM":z3411.cdDeliveryTerm = Children(i).Data
   Case "SEORIGIN":z3411.seOrigin = Children(i).Data
   Case "CDORIGIN":z3411.cdOrigin = Children(i).Data
   Case "SECOMMERCIALTERM":z3411.seCommercialTerm = Children(i).Data
   Case "CDCOMMERCIALTERM":z3411.cdCommercialTerm = Children(i).Data
   Case "SEPAYMENTTERM":z3411.sePaymentTerm = Children(i).Data
   Case "CDPAYMENTTERM":z3411.cdPaymentTerm = Children(i).Data
   Case "SEPAYMENTCONDITION":z3411.sePaymentCondition = Children(i).Data
   Case "CDPAYMENTCONDITION":z3411.cdPaymentCondition = Children(i).Data
   Case "SEPAYMENTTIME":z3411.sePaymentTime = Children(i).Data
   Case "CDPAYMENTTIME":z3411.cdPaymentTime = Children(i).Data
   Case "SEPAYMENTDAY":z3411.sePaymentDay = Children(i).Data
   Case "CDPAYMENTDAY":z3411.cdPaymentDay = Children(i).Data
   Case "SEBUYINGTYPE":z3411.seBuyingType = Children(i).Data
   Case "CDBUYINGTYPE":z3411.cdBuyingType = Children(i).Data
   Case "QUALITYREQUEST":z3411.QualityRequest = Children(i).Data
   Case "CONTRACTNO":z3411.ContractNo = Children(i).Data
   Case "TOLERANCE":z3411.Tolerance = Children(i).Data
   Case "DESTINATION":z3411.Destination = Children(i).Data
   Case "INCHARGEPURCHASING":z3411.InchargePurchasing = Children(i).Data
   Case "AMOUNTPURCHASINGEX":z3411.AmountPurchasingEX = Cdecp(Children(i).Data)
   Case "AMOUNTPURCHASINGVND":z3411.AmountPurchasingVND = Cdecp(Children(i).Data)
   Case "AMOUNTTAX1EX":z3411.AmountTax1EX = Cdecp(Children(i).Data)
   Case "AMOUNTTAX2EX":z3411.AmountTax2EX = Cdecp(Children(i).Data)
   Case "AMOUNTTAX3EX":z3411.AmountTax3EX = Cdecp(Children(i).Data)
   Case "AMOUNTTAX1VND":z3411.AmountTax1VND = Cdecp(Children(i).Data)
   Case "AMOUNTTAX2VND":z3411.AmountTax2VND = Cdecp(Children(i).Data)
   Case "AMOUNTTAX3VND":z3411.AmountTax3VND = Cdecp(Children(i).Data)
   Case "AMOUNTTAXEX":z3411.AmountTaxEX = Cdecp(Children(i).Data)
   Case "AMOUNTTAXVND":z3411.AmountTaxVND = Cdecp(Children(i).Data)
   Case "AMOUNTNOVATEX":z3411.AmountNoVATEX = Cdecp(Children(i).Data)
   Case "AMOUNTNOVATVND":z3411.AmountNoVATVND = Cdecp(Children(i).Data)
   Case "AMOUNTEXPENSEUSD":z3411.AmountExpenseUSD = Cdecp(Children(i).Data)
   Case "AMOUNTEXPENSEVND":z3411.AmountExpenseVND = Cdecp(Children(i).Data)
   Case "AMOUNTTOTALEX":z3411.AmountTotalEX = Cdecp(Children(i).Data)
   Case "AMOUNTTOTALVND":z3411.AmountTotalVND = Cdecp(Children(i).Data)
   Case "DATESTART":z3411.DateStart = Children(i).Data
   Case "DATEESTIMATE":z3411.DateEstimate = Children(i).Data
   Case "DATEDELIVERY":z3411.DateDelivery = Children(i).Data
   Case "TIMEINSERT":z3411.TimeInsert = Children(i).Data
   Case "TIMEUPDATE":z3411.TimeUpdate = Children(i).Data
   Case "DATEINSERT":z3411.DateInsert = Children(i).Data
   Case "DATEUPDATE":z3411.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z3411.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z3411.InchargeUpdate = Children(i).Data
   Case "CHECKCOMPLETE":z3411.CheckComplete = Children(i).Data
   Case "REMARK":z3411.Remark = Children(i).Data
   Case "REMARK01":z3411.Remark01 = Children(i).Data
   Case "REMARK02":z3411.Remark02 = Children(i).Data
   Case "REMARK03":z3411.Remark03 = Children(i).Data
   Case "REMARK04":z3411.Remark04 = Children(i).Data
   Case "REMARK05":z3411.Remark05 = Children(i).Data
   Case "SESITE":z3411.seSite = Children(i).Data
   Case "CDSITE":z3411.cdSite = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K3411_MOVE",vbCritical)
End Try
End Function 
    

'=========================================================================================================================================================
' DATA MOVE FORM NEW AREA
'=========================================================================================================================================================
Public Sub K3411_MOVE(ByRef a3411 As T3411_AREA, ByRef b3411 As T3411_AREA) 
Try
If trim$( a3411.PurchasingOrderNo ) = "" Then b3411.PurchasingOrderNo = ""  Else b3411.PurchasingOrderNo=a3411.PurchasingOrderNo
If trim$( a3411.PurchasingOrderName ) = "" Then b3411.PurchasingOrderName = ""  Else b3411.PurchasingOrderName=a3411.PurchasingOrderName
If trim$( a3411.seSeason ) = "" Then b3411.seSeason = ""  Else b3411.seSeason=a3411.seSeason
If trim$( a3411.cdSeason ) = "" Then b3411.cdSeason = ""  Else b3411.cdSeason=a3411.cdSeason
If trim$( a3411.CustomerCode ) = "" Then b3411.CustomerCode = ""  Else b3411.CustomerCode=a3411.CustomerCode
If trim$( a3411.DateAccept ) = "" Then b3411.DateAccept = ""  Else b3411.DateAccept=a3411.DateAccept
If trim$( a3411.CheckInPurchasingOrder ) = "" Then b3411.CheckInPurchasingOrder = ""  Else b3411.CheckInPurchasingOrder=a3411.CheckInPurchasingOrder
If trim$( a3411.CheckOutPurchasingOrder ) = "" Then b3411.CheckOutPurchasingOrder = ""  Else b3411.CheckOutPurchasingOrder=a3411.CheckOutPurchasingOrder
If trim$( a3411.CheckProcessType ) = "" Then b3411.CheckProcessType = ""  Else b3411.CheckProcessType=a3411.CheckProcessType
If trim$( a3411.CheckIOType ) = "" Then b3411.CheckIOType = ""  Else b3411.CheckIOType=a3411.CheckIOType
If trim$( a3411.CheckMaterialType ) = "" Then b3411.CheckMaterialType = ""  Else b3411.CheckMaterialType=a3411.CheckMaterialType
If trim$( a3411.CheckMarketType ) = "" Then b3411.CheckMarketType = ""  Else b3411.CheckMarketType=a3411.CheckMarketType
If trim$( a3411.CheckRelationType ) = "" Then b3411.CheckRelationType = ""  Else b3411.CheckRelationType=a3411.CheckRelationType
If trim$( a3411.SupplierCode ) = "" Then b3411.SupplierCode = ""  Else b3411.SupplierCode=a3411.SupplierCode
If trim$( a3411.selUnitPrice ) = "" Then b3411.selUnitPrice = ""  Else b3411.selUnitPrice=a3411.selUnitPrice
If trim$( a3411.cdUnitPrice ) = "" Then b3411.cdUnitPrice = ""  Else b3411.cdUnitPrice=a3411.cdUnitPrice
If trim$( a3411.PriceExchange ) = "" Then b3411.PriceExchange = ""  Else b3411.PriceExchange=a3411.PriceExchange
If trim$( a3411.DateExchange ) = "" Then b3411.DateExchange = ""  Else b3411.DateExchange=a3411.DateExchange
If trim$( a3411.seDeliveryTerm ) = "" Then b3411.seDeliveryTerm = ""  Else b3411.seDeliveryTerm=a3411.seDeliveryTerm
If trim$( a3411.cdDeliveryTerm ) = "" Then b3411.cdDeliveryTerm = ""  Else b3411.cdDeliveryTerm=a3411.cdDeliveryTerm
If trim$( a3411.seOrigin ) = "" Then b3411.seOrigin = ""  Else b3411.seOrigin=a3411.seOrigin
If trim$( a3411.cdOrigin ) = "" Then b3411.cdOrigin = ""  Else b3411.cdOrigin=a3411.cdOrigin
If trim$( a3411.seCommercialTerm ) = "" Then b3411.seCommercialTerm = ""  Else b3411.seCommercialTerm=a3411.seCommercialTerm
If trim$( a3411.cdCommercialTerm ) = "" Then b3411.cdCommercialTerm = ""  Else b3411.cdCommercialTerm=a3411.cdCommercialTerm
If trim$( a3411.sePaymentTerm ) = "" Then b3411.sePaymentTerm = ""  Else b3411.sePaymentTerm=a3411.sePaymentTerm
If trim$( a3411.cdPaymentTerm ) = "" Then b3411.cdPaymentTerm = ""  Else b3411.cdPaymentTerm=a3411.cdPaymentTerm
If trim$( a3411.sePaymentCondition ) = "" Then b3411.sePaymentCondition = ""  Else b3411.sePaymentCondition=a3411.sePaymentCondition
If trim$( a3411.cdPaymentCondition ) = "" Then b3411.cdPaymentCondition = ""  Else b3411.cdPaymentCondition=a3411.cdPaymentCondition
If trim$( a3411.sePaymentTime ) = "" Then b3411.sePaymentTime = ""  Else b3411.sePaymentTime=a3411.sePaymentTime
If trim$( a3411.cdPaymentTime ) = "" Then b3411.cdPaymentTime = ""  Else b3411.cdPaymentTime=a3411.cdPaymentTime
If trim$( a3411.sePaymentDay ) = "" Then b3411.sePaymentDay = ""  Else b3411.sePaymentDay=a3411.sePaymentDay
If trim$( a3411.cdPaymentDay ) = "" Then b3411.cdPaymentDay = ""  Else b3411.cdPaymentDay=a3411.cdPaymentDay
If trim$( a3411.seBuyingType ) = "" Then b3411.seBuyingType = ""  Else b3411.seBuyingType=a3411.seBuyingType
If trim$( a3411.cdBuyingType ) = "" Then b3411.cdBuyingType = ""  Else b3411.cdBuyingType=a3411.cdBuyingType
If trim$( a3411.QualityRequest ) = "" Then b3411.QualityRequest = ""  Else b3411.QualityRequest=a3411.QualityRequest
If trim$( a3411.ContractNo ) = "" Then b3411.ContractNo = ""  Else b3411.ContractNo=a3411.ContractNo
If trim$( a3411.Tolerance ) = "" Then b3411.Tolerance = ""  Else b3411.Tolerance=a3411.Tolerance
If trim$( a3411.Destination ) = "" Then b3411.Destination = ""  Else b3411.Destination=a3411.Destination
If trim$( a3411.InchargePurchasing ) = "" Then b3411.InchargePurchasing = ""  Else b3411.InchargePurchasing=a3411.InchargePurchasing
If trim$( a3411.AmountPurchasingEX ) = "" Then b3411.AmountPurchasingEX = ""  Else b3411.AmountPurchasingEX=a3411.AmountPurchasingEX
If trim$( a3411.AmountPurchasingVND ) = "" Then b3411.AmountPurchasingVND = ""  Else b3411.AmountPurchasingVND=a3411.AmountPurchasingVND
If trim$( a3411.AmountTax1EX ) = "" Then b3411.AmountTax1EX = ""  Else b3411.AmountTax1EX=a3411.AmountTax1EX
If trim$( a3411.AmountTax2EX ) = "" Then b3411.AmountTax2EX = ""  Else b3411.AmountTax2EX=a3411.AmountTax2EX
If trim$( a3411.AmountTax3EX ) = "" Then b3411.AmountTax3EX = ""  Else b3411.AmountTax3EX=a3411.AmountTax3EX
If trim$( a3411.AmountTax1VND ) = "" Then b3411.AmountTax1VND = ""  Else b3411.AmountTax1VND=a3411.AmountTax1VND
If trim$( a3411.AmountTax2VND ) = "" Then b3411.AmountTax2VND = ""  Else b3411.AmountTax2VND=a3411.AmountTax2VND
If trim$( a3411.AmountTax3VND ) = "" Then b3411.AmountTax3VND = ""  Else b3411.AmountTax3VND=a3411.AmountTax3VND
If trim$( a3411.AmountTaxEX ) = "" Then b3411.AmountTaxEX = ""  Else b3411.AmountTaxEX=a3411.AmountTaxEX
If trim$( a3411.AmountTaxVND ) = "" Then b3411.AmountTaxVND = ""  Else b3411.AmountTaxVND=a3411.AmountTaxVND
If trim$( a3411.AmountNoVATEX ) = "" Then b3411.AmountNoVATEX = ""  Else b3411.AmountNoVATEX=a3411.AmountNoVATEX
If trim$( a3411.AmountNoVATVND ) = "" Then b3411.AmountNoVATVND = ""  Else b3411.AmountNoVATVND=a3411.AmountNoVATVND
If trim$( a3411.AmountExpenseUSD ) = "" Then b3411.AmountExpenseUSD = ""  Else b3411.AmountExpenseUSD=a3411.AmountExpenseUSD
If trim$( a3411.AmountExpenseVND ) = "" Then b3411.AmountExpenseVND = ""  Else b3411.AmountExpenseVND=a3411.AmountExpenseVND
If trim$( a3411.AmountTotalEX ) = "" Then b3411.AmountTotalEX = ""  Else b3411.AmountTotalEX=a3411.AmountTotalEX
If trim$( a3411.AmountTotalVND ) = "" Then b3411.AmountTotalVND = ""  Else b3411.AmountTotalVND=a3411.AmountTotalVND
If trim$( a3411.DateStart ) = "" Then b3411.DateStart = ""  Else b3411.DateStart=a3411.DateStart
If trim$( a3411.DateEstimate ) = "" Then b3411.DateEstimate = ""  Else b3411.DateEstimate=a3411.DateEstimate
If trim$( a3411.DateDelivery ) = "" Then b3411.DateDelivery = ""  Else b3411.DateDelivery=a3411.DateDelivery
If trim$( a3411.TimeInsert ) = "" Then b3411.TimeInsert = ""  Else b3411.TimeInsert=a3411.TimeInsert
If trim$( a3411.TimeUpdate ) = "" Then b3411.TimeUpdate = ""  Else b3411.TimeUpdate=a3411.TimeUpdate
If trim$( a3411.DateInsert ) = "" Then b3411.DateInsert = ""  Else b3411.DateInsert=a3411.DateInsert
If trim$( a3411.DateUpdate ) = "" Then b3411.DateUpdate = ""  Else b3411.DateUpdate=a3411.DateUpdate
If trim$( a3411.InchargeInsert ) = "" Then b3411.InchargeInsert = ""  Else b3411.InchargeInsert=a3411.InchargeInsert
If trim$( a3411.InchargeUpdate ) = "" Then b3411.InchargeUpdate = ""  Else b3411.InchargeUpdate=a3411.InchargeUpdate
If trim$( a3411.CheckComplete ) = "" Then b3411.CheckComplete = ""  Else b3411.CheckComplete=a3411.CheckComplete
If trim$( a3411.Remark ) = "" Then b3411.Remark = ""  Else b3411.Remark=a3411.Remark
If trim$( a3411.Remark01 ) = "" Then b3411.Remark01 = ""  Else b3411.Remark01=a3411.Remark01
If trim$( a3411.Remark02 ) = "" Then b3411.Remark02 = ""  Else b3411.Remark02=a3411.Remark02
If trim$( a3411.Remark03 ) = "" Then b3411.Remark03 = ""  Else b3411.Remark03=a3411.Remark03
If trim$( a3411.Remark04 ) = "" Then b3411.Remark04 = ""  Else b3411.Remark04=a3411.Remark04
If trim$( a3411.Remark05 ) = "" Then b3411.Remark05 = ""  Else b3411.Remark05=a3411.Remark05
If trim$( a3411.seSite ) = "" Then b3411.seSite = ""  Else b3411.seSite=a3411.seSite
If trim$( a3411.cdSite ) = "" Then b3411.cdSite = ""  Else b3411.cdSite=a3411.cdSite
Catch ex As Exception
      Call MsgBoxP("K3411_MOVE",vbCritical)
End Try
End Sub 


End Module 
