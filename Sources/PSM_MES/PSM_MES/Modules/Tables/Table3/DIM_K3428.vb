'=========================================================================================================================================================
'   TABLE : (PFK3428)
'
'      WORKER : PSM GLOBAL ., LTD
'       WORK DATE : 2019 NEW
'       DEVELOPER    : MRNLV
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K3428

Structure T3428_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	PayableNo	 AS String	'			char(9)		*
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
Public 	seDepartment	 AS String	'			char(3)
Public 	cdDepartment	 AS String	'			char(3)
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
Public 	TypeDiscount	 AS String	'			char(1)
Public 	PerDiscount	 AS Double	'			decimal
Public 	AmtDiscount	 AS Double	'			decimal
Public 	QualityRequest	 AS String	'			nvarchar(50)
Public 	ContractNo	 AS String	'			nvarchar(200)
Public 	Tolerance	 AS String	'			nvarchar(50)
Public 	Destination	 AS String	'			nvarchar(50)
Public 	InchargePurchasing	 AS String	'			char(8)
Public 	AmountPurchasingEX	 AS Double	'			decimal
Public 	AmountPurchasingVND	 AS Double	'			decimal
Public 	AmountTaxEX	 AS Double	'			decimal
Public 	AmountTaxVND	 AS Double	'			decimal
Public 	AmountExpenseEX	 AS Double	'			decimal
Public 	AmountExpenseUSD	 AS Double	'			decimal
Public 	AmountExpenseVND	 AS Double	'			decimal
Public 	DateStart	 AS String	'			char(8)
Public 	DateEstimate	 AS String	'			char(8)
Public 	DateDelivery	 AS String	'			char(8)
Public 	DateInsert	 AS String	'			char(8)
Public 	DateUpdate	 AS String	'			char(8)
Public 	InchargeInsert	 AS String	'			char(8)
Public 	InchargeUpdate	 AS String	'			char(8)
Public 	TimeInsert	 AS String	'			char(14)
Public 	TimeUpdate	 AS String	'			char(14)
Public 	CheckComplete	 AS String	'			char(1)
Public 	InchargeSync	 AS String	'			char(8)
Public 	DateSync	 AS String	'			char(8)
Public 	CheckSync	 AS String	'			char(1)
Public 	PurchasingOrderNo	 AS String	'			char(9)
Public 	SalesOrderNo	 AS String	'			char(9)
Public 	SalesOrderSeq	 AS String	'			char(2)
Public 	SalesOrderSno	 AS String	'			char(2)
Public 	Remark	 AS String	'			nvarchar(500)
Public 	seSite	 AS String	'			char(3)
Public 	cdSite	 AS String	'			char(3)
'=========================================================================================================================================================
End structure

Public D3428 As T3428_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK3428(PAYABLENO AS String) As Boolean
    READ_PFK3428 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK3428 "
    SQL = SQL & " WHERE K3428_PayableNo		 = '" & PayableNo & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D3428_CLEAR: GoTo SKIP_READ_PFK3428
                
    Call K3428_MOVE(rd)
    READ_PFK3428 = True

SKIP_READ_PFK3428:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK3428",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK3428(PAYABLENO AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK3428 "
    SQL = SQL & " WHERE K3428_PayableNo		 = '" & PayableNo & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK3428",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK3428(z3428 As T3428_AREA) As Boolean
    WRITE_PFK3428 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z3428)
 
    SQL = " INSERT INTO PFK3428 "
    SQL = SQL & " ( "
    SQL = SQL & " K3428_PayableNo," 
    SQL = SQL & " K3428_seSeason," 
    SQL = SQL & " K3428_cdSeason," 
    SQL = SQL & " K3428_CustomerCode," 
    SQL = SQL & " K3428_DateAccept," 
    SQL = SQL & " K3428_CheckInPurchasingOrder," 
    SQL = SQL & " K3428_CheckOutPurchasingOrder," 
    SQL = SQL & " K3428_CheckProcessType," 
    SQL = SQL & " K3428_CheckIOType," 
    SQL = SQL & " K3428_CheckMaterialType," 
    SQL = SQL & " K3428_CheckMarketType," 
    SQL = SQL & " K3428_CheckRelationType," 
    SQL = SQL & " K3428_SupplierCode," 
    SQL = SQL & " K3428_selUnitPrice," 
    SQL = SQL & " K3428_cdUnitPrice," 
    SQL = SQL & " K3428_PriceExchange," 
    SQL = SQL & " K3428_DateExchange," 
    SQL = SQL & " K3428_seOrigin," 
    SQL = SQL & " K3428_cdOrigin," 
    SQL = SQL & " K3428_seDepartment," 
    SQL = SQL & " K3428_cdDepartment," 
    SQL = SQL & " K3428_seCommercialTerm," 
    SQL = SQL & " K3428_cdCommercialTerm," 
    SQL = SQL & " K3428_seDeliveryTerm," 
    SQL = SQL & " K3428_cdDeliveryTerm," 
    SQL = SQL & " K3428_sePaymentTerm," 
    SQL = SQL & " K3428_cdPaymentTerm," 
    SQL = SQL & " K3428_sePaymentCondition," 
    SQL = SQL & " K3428_cdPaymentCondition," 
    SQL = SQL & " K3428_sePaymentTime," 
    SQL = SQL & " K3428_cdPaymentTime," 
    SQL = SQL & " K3428_sePaymentDay," 
    SQL = SQL & " K3428_cdPaymentDay," 
    SQL = SQL & " K3428_seBuyingType," 
    SQL = SQL & " K3428_cdBuyingType," 
    SQL = SQL & " K3428_TypeDiscount," 
    SQL = SQL & " K3428_PerDiscount," 
    SQL = SQL & " K3428_AmtDiscount," 
    SQL = SQL & " K3428_QualityRequest," 
    SQL = SQL & " K3428_ContractNo," 
    SQL = SQL & " K3428_Tolerance," 
    SQL = SQL & " K3428_Destination," 
    SQL = SQL & " K3428_InchargePurchasing," 
    SQL = SQL & " K3428_AmountPurchasingEX," 
    SQL = SQL & " K3428_AmountPurchasingVND," 
    SQL = SQL & " K3428_AmountTaxEX," 
    SQL = SQL & " K3428_AmountTaxVND," 
    SQL = SQL & " K3428_AmountExpenseEX," 
    SQL = SQL & " K3428_AmountExpenseUSD," 
    SQL = SQL & " K3428_AmountExpenseVND," 
    SQL = SQL & " K3428_DateStart," 
    SQL = SQL & " K3428_DateEstimate," 
    SQL = SQL & " K3428_DateDelivery," 
    SQL = SQL & " K3428_DateInsert," 
    SQL = SQL & " K3428_DateUpdate," 
    SQL = SQL & " K3428_InchargeInsert," 
    SQL = SQL & " K3428_InchargeUpdate," 
    SQL = SQL & " K3428_TimeInsert," 
    SQL = SQL & " K3428_TimeUpdate," 
    SQL = SQL & " K3428_CheckComplete," 
    SQL = SQL & " K3428_InchargeSync," 
    SQL = SQL & " K3428_DateSync," 
    SQL = SQL & " K3428_CheckSync," 
    SQL = SQL & " K3428_PurchasingOrderNo," 
    SQL = SQL & " K3428_SalesOrderNo," 
    SQL = SQL & " K3428_SalesOrderSeq," 
    SQL = SQL & " K3428_SalesOrderSno," 
    SQL = SQL & " K3428_Remark," 
    SQL = SQL & " K3428_seSite," 
    SQL = SQL & " K3428_cdSite " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z3428.PayableNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3428.seSeason) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3428.cdSeason) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3428.CustomerCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3428.DateAccept) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3428.CheckInPurchasingOrder) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3428.CheckOutPurchasingOrder) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3428.CheckProcessType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3428.CheckIOType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3428.CheckMaterialType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3428.CheckMarketType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3428.CheckRelationType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3428.SupplierCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3428.selUnitPrice) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3428.cdUnitPrice) & "', "  
    SQL = SQL & "   " & FormatSQL(z3428.PriceExchange) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z3428.DateExchange) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3428.seOrigin) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3428.cdOrigin) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3428.seDepartment) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3428.cdDepartment) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3428.seCommercialTerm) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3428.cdCommercialTerm) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3428.seDeliveryTerm) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3428.cdDeliveryTerm) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3428.sePaymentTerm) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3428.cdPaymentTerm) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3428.sePaymentCondition) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3428.cdPaymentCondition) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3428.sePaymentTime) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3428.cdPaymentTime) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3428.sePaymentDay) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3428.cdPaymentDay) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3428.seBuyingType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3428.cdBuyingType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3428.TypeDiscount) & "', "  
    SQL = SQL & "   " & FormatSQL(z3428.PerDiscount) & ", "  
    SQL = SQL & "   " & FormatSQL(z3428.AmtDiscount) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z3428.QualityRequest) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3428.ContractNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3428.Tolerance) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3428.Destination) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3428.InchargePurchasing) & "', "  
    SQL = SQL & "   " & FormatSQL(z3428.AmountPurchasingEX) & ", "  
    SQL = SQL & "   " & FormatSQL(z3428.AmountPurchasingVND) & ", "  
    SQL = SQL & "   " & FormatSQL(z3428.AmountTaxEX) & ", "  
    SQL = SQL & "   " & FormatSQL(z3428.AmountTaxVND) & ", "  
    SQL = SQL & "   " & FormatSQL(z3428.AmountExpenseEX) & ", "  
    SQL = SQL & "   " & FormatSQL(z3428.AmountExpenseUSD) & ", "  
    SQL = SQL & "   " & FormatSQL(z3428.AmountExpenseVND) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z3428.DateStart) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3428.DateEstimate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3428.DateDelivery) & "', "  
    SQL = SQL & "  N'" & FormatSQL(PUB.DAT) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3428.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(PUB.SAW) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3428.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(PUB.TIME) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3428.TimeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3428.CheckComplete) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3428.InchargeSync) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3428.DateSync) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3428.CheckSync) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3428.PurchasingOrderNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3428.SalesOrderNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3428.SalesOrderSeq) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3428.SalesOrderSno) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3428.Remark) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3428.seSite) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3428.cdSite) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK3428 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK3428",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK3428(z3428 As T3428_AREA) As Boolean
    REWRITE_PFK3428 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z3428)
   
    SQL = " UPDATE PFK3428 SET "
    SQL = SQL & "    K3428_seSeason      = N'" & FormatSQL(z3428.seSeason) & "', " 
    SQL = SQL & "    K3428_cdSeason      = N'" & FormatSQL(z3428.cdSeason) & "', " 
    SQL = SQL & "    K3428_CustomerCode      = N'" & FormatSQL(z3428.CustomerCode) & "', " 
    SQL = SQL & "    K3428_DateAccept      = N'" & FormatSQL(z3428.DateAccept) & "', " 
    SQL = SQL & "    K3428_CheckInPurchasingOrder      = N'" & FormatSQL(z3428.CheckInPurchasingOrder) & "', " 
    SQL = SQL & "    K3428_CheckOutPurchasingOrder      = N'" & FormatSQL(z3428.CheckOutPurchasingOrder) & "', " 
    SQL = SQL & "    K3428_CheckProcessType      = N'" & FormatSQL(z3428.CheckProcessType) & "', " 
    SQL = SQL & "    K3428_CheckIOType      = N'" & FormatSQL(z3428.CheckIOType) & "', " 
    SQL = SQL & "    K3428_CheckMaterialType      = N'" & FormatSQL(z3428.CheckMaterialType) & "', " 
    SQL = SQL & "    K3428_CheckMarketType      = N'" & FormatSQL(z3428.CheckMarketType) & "', " 
    SQL = SQL & "    K3428_CheckRelationType      = N'" & FormatSQL(z3428.CheckRelationType) & "', " 
    SQL = SQL & "    K3428_SupplierCode      = N'" & FormatSQL(z3428.SupplierCode) & "', " 
    SQL = SQL & "    K3428_selUnitPrice      = N'" & FormatSQL(z3428.selUnitPrice) & "', " 
    SQL = SQL & "    K3428_cdUnitPrice      = N'" & FormatSQL(z3428.cdUnitPrice) & "', " 
    SQL = SQL & "    K3428_PriceExchange      =  " & FormatSQL(z3428.PriceExchange) & ", " 
    SQL = SQL & "    K3428_DateExchange      = N'" & FormatSQL(z3428.DateExchange) & "', " 
    SQL = SQL & "    K3428_seOrigin      = N'" & FormatSQL(z3428.seOrigin) & "', " 
    SQL = SQL & "    K3428_cdOrigin      = N'" & FormatSQL(z3428.cdOrigin) & "', " 
    SQL = SQL & "    K3428_seDepartment      = N'" & FormatSQL(z3428.seDepartment) & "', " 
    SQL = SQL & "    K3428_cdDepartment      = N'" & FormatSQL(z3428.cdDepartment) & "', " 
    SQL = SQL & "    K3428_seCommercialTerm      = N'" & FormatSQL(z3428.seCommercialTerm) & "', " 
    SQL = SQL & "    K3428_cdCommercialTerm      = N'" & FormatSQL(z3428.cdCommercialTerm) & "', " 
    SQL = SQL & "    K3428_seDeliveryTerm      = N'" & FormatSQL(z3428.seDeliveryTerm) & "', " 
    SQL = SQL & "    K3428_cdDeliveryTerm      = N'" & FormatSQL(z3428.cdDeliveryTerm) & "', " 
    SQL = SQL & "    K3428_sePaymentTerm      = N'" & FormatSQL(z3428.sePaymentTerm) & "', " 
    SQL = SQL & "    K3428_cdPaymentTerm      = N'" & FormatSQL(z3428.cdPaymentTerm) & "', " 
    SQL = SQL & "    K3428_sePaymentCondition      = N'" & FormatSQL(z3428.sePaymentCondition) & "', " 
    SQL = SQL & "    K3428_cdPaymentCondition      = N'" & FormatSQL(z3428.cdPaymentCondition) & "', " 
    SQL = SQL & "    K3428_sePaymentTime      = N'" & FormatSQL(z3428.sePaymentTime) & "', " 
    SQL = SQL & "    K3428_cdPaymentTime      = N'" & FormatSQL(z3428.cdPaymentTime) & "', " 
    SQL = SQL & "    K3428_sePaymentDay      = N'" & FormatSQL(z3428.sePaymentDay) & "', " 
    SQL = SQL & "    K3428_cdPaymentDay      = N'" & FormatSQL(z3428.cdPaymentDay) & "', " 
    SQL = SQL & "    K3428_seBuyingType      = N'" & FormatSQL(z3428.seBuyingType) & "', " 
    SQL = SQL & "    K3428_cdBuyingType      = N'" & FormatSQL(z3428.cdBuyingType) & "', " 
    SQL = SQL & "    K3428_TypeDiscount      = N'" & FormatSQL(z3428.TypeDiscount) & "', " 
    SQL = SQL & "    K3428_PerDiscount      =  " & FormatSQL(z3428.PerDiscount) & ", " 
    SQL = SQL & "    K3428_AmtDiscount      =  " & FormatSQL(z3428.AmtDiscount) & ", " 
    SQL = SQL & "    K3428_QualityRequest      = N'" & FormatSQL(z3428.QualityRequest) & "', " 
    SQL = SQL & "    K3428_ContractNo      = N'" & FormatSQL(z3428.ContractNo) & "', " 
    SQL = SQL & "    K3428_Tolerance      = N'" & FormatSQL(z3428.Tolerance) & "', " 
    SQL = SQL & "    K3428_Destination      = N'" & FormatSQL(z3428.Destination) & "', " 
    SQL = SQL & "    K3428_InchargePurchasing      = N'" & FormatSQL(z3428.InchargePurchasing) & "', " 
    SQL = SQL & "    K3428_AmountPurchasingEX      =  " & FormatSQL(z3428.AmountPurchasingEX) & ", " 
    SQL = SQL & "    K3428_AmountPurchasingVND      =  " & FormatSQL(z3428.AmountPurchasingVND) & ", " 
    SQL = SQL & "    K3428_AmountTaxEX      =  " & FormatSQL(z3428.AmountTaxEX) & ", " 
    SQL = SQL & "    K3428_AmountTaxVND      =  " & FormatSQL(z3428.AmountTaxVND) & ", " 
    SQL = SQL & "    K3428_AmountExpenseEX      =  " & FormatSQL(z3428.AmountExpenseEX) & ", " 
    SQL = SQL & "    K3428_AmountExpenseUSD      =  " & FormatSQL(z3428.AmountExpenseUSD) & ", " 
    SQL = SQL & "    K3428_AmountExpenseVND      =  " & FormatSQL(z3428.AmountExpenseVND) & ", " 
    SQL = SQL & "    K3428_DateStart      = N'" & FormatSQL(z3428.DateStart) & "', " 
    SQL = SQL & "    K3428_DateEstimate      = N'" & FormatSQL(z3428.DateEstimate) & "', " 
    SQL = SQL & "    K3428_DateDelivery      = N'" & FormatSQL(z3428.DateDelivery) & "', " 
    SQL = SQL & "    K3428_DateInsert      = N'" & FormatSQL(z3428.DateInsert) & "', " 
    SQL = SQL & "    K3428_DateUpdate      = N'" & FormatSQL(PUB.DAT) & "', " 
    SQL = SQL & "    K3428_InchargeInsert      = N'" & FormatSQL(z3428.InchargeInsert) & "', " 
    SQL = SQL & "    K3428_InchargeUpdate      = N'" & FormatSQL(PUB.SAW) & "', " 
    SQL = SQL & "    K3428_TimeInsert      = N'" & FormatSQL(z3428.TimeInsert) & "', " 
    SQL = SQL & "    K3428_TimeUpdate      = N'" & FormatSQL(PUB.TIME) & "', " 
    SQL = SQL & "    K3428_CheckComplete      = N'" & FormatSQL(z3428.CheckComplete) & "', " 
    SQL = SQL & "    K3428_InchargeSync      = N'" & FormatSQL(z3428.InchargeSync) & "', " 
    SQL = SQL & "    K3428_DateSync      = N'" & FormatSQL(z3428.DateSync) & "', " 
    SQL = SQL & "    K3428_CheckSync      = N'" & FormatSQL(z3428.CheckSync) & "', " 
    SQL = SQL & "    K3428_PurchasingOrderNo      = N'" & FormatSQL(z3428.PurchasingOrderNo) & "', " 
    SQL = SQL & "    K3428_SalesOrderNo      = N'" & FormatSQL(z3428.SalesOrderNo) & "', " 
    SQL = SQL & "    K3428_SalesOrderSeq      = N'" & FormatSQL(z3428.SalesOrderSeq) & "', " 
    SQL = SQL & "    K3428_SalesOrderSno      = N'" & FormatSQL(z3428.SalesOrderSno) & "', " 
    SQL = SQL & "    K3428_Remark      = N'" & FormatSQL(z3428.Remark) & "', " 
    SQL = SQL & "    K3428_seSite      = N'" & FormatSQL(z3428.seSite) & "', " 
    SQL = SQL & "    K3428_cdSite      = N'" & FormatSQL(z3428.cdSite) & "'  " 
    SQL = SQL & " WHERE K3428_PayableNo		 = '" & z3428.PayableNo & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  

    REWRITE_PFK3428 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK3428",vbCritical)

  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK3428(z3428 As T3428_AREA) As Boolean
    DELETE_PFK3428 = False

   Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z3428)
      
        SQL = " DELETE FROM PFK3428  "
    SQL = SQL & " WHERE K3428_PayableNo		 = '" & z3428.PayableNo & "' " 

    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK3428 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK3428",vbCritical)
Finally
        Call GetFullInformation("PFK3428", "D", SQL)
  End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D3428_CLEAR()
Try
    
   D3428.PayableNo = ""
   D3428.seSeason = ""
   D3428.cdSeason = ""
   D3428.CustomerCode = ""
   D3428.DateAccept = ""
   D3428.CheckInPurchasingOrder = ""
   D3428.CheckOutPurchasingOrder = ""
   D3428.CheckProcessType = ""
   D3428.CheckIOType = ""
   D3428.CheckMaterialType = ""
   D3428.CheckMarketType = ""
   D3428.CheckRelationType = ""
   D3428.SupplierCode = ""
   D3428.selUnitPrice = ""
   D3428.cdUnitPrice = ""
    D3428.PriceExchange = 0 
   D3428.DateExchange = ""
   D3428.seOrigin = ""
   D3428.cdOrigin = ""
   D3428.seDepartment = ""
   D3428.cdDepartment = ""
   D3428.seCommercialTerm = ""
   D3428.cdCommercialTerm = ""
   D3428.seDeliveryTerm = ""
   D3428.cdDeliveryTerm = ""
   D3428.sePaymentTerm = ""
   D3428.cdPaymentTerm = ""
   D3428.sePaymentCondition = ""
   D3428.cdPaymentCondition = ""
   D3428.sePaymentTime = ""
   D3428.cdPaymentTime = ""
   D3428.sePaymentDay = ""
   D3428.cdPaymentDay = ""
   D3428.seBuyingType = ""
   D3428.cdBuyingType = ""
   D3428.TypeDiscount = ""
    D3428.PerDiscount = 0 
    D3428.AmtDiscount = 0 
   D3428.QualityRequest = ""
   D3428.ContractNo = ""
   D3428.Tolerance = ""
   D3428.Destination = ""
   D3428.InchargePurchasing = ""
    D3428.AmountPurchasingEX = 0 
    D3428.AmountPurchasingVND = 0 
    D3428.AmountTaxEX = 0 
    D3428.AmountTaxVND = 0 
    D3428.AmountExpenseEX = 0 
    D3428.AmountExpenseUSD = 0 
    D3428.AmountExpenseVND = 0 
   D3428.DateStart = ""
   D3428.DateEstimate = ""
   D3428.DateDelivery = ""
   D3428.DateInsert = ""
   D3428.DateUpdate = ""
   D3428.InchargeInsert = ""
   D3428.InchargeUpdate = ""
   D3428.TimeInsert = ""
   D3428.TimeUpdate = ""
   D3428.CheckComplete = ""
   D3428.InchargeSync = ""
   D3428.DateSync = ""
   D3428.CheckSync = ""
   D3428.PurchasingOrderNo = ""
   D3428.SalesOrderNo = ""
   D3428.SalesOrderSeq = ""
   D3428.SalesOrderSno = ""
   D3428.Remark = ""
   D3428.seSite = ""
   D3428.cdSite = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D3428_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x3428 As T3428_AREA)
Try
    
    x3428.PayableNo = trim$(  x3428.PayableNo)
    x3428.seSeason = trim$(  x3428.seSeason)
    x3428.cdSeason = trim$(  x3428.cdSeason)
    x3428.CustomerCode = trim$(  x3428.CustomerCode)
    x3428.DateAccept = trim$(  x3428.DateAccept)
    x3428.CheckInPurchasingOrder = trim$(  x3428.CheckInPurchasingOrder)
    x3428.CheckOutPurchasingOrder = trim$(  x3428.CheckOutPurchasingOrder)
    x3428.CheckProcessType = trim$(  x3428.CheckProcessType)
    x3428.CheckIOType = trim$(  x3428.CheckIOType)
    x3428.CheckMaterialType = trim$(  x3428.CheckMaterialType)
    x3428.CheckMarketType = trim$(  x3428.CheckMarketType)
    x3428.CheckRelationType = trim$(  x3428.CheckRelationType)
    x3428.SupplierCode = trim$(  x3428.SupplierCode)
    x3428.selUnitPrice = trim$(  x3428.selUnitPrice)
    x3428.cdUnitPrice = trim$(  x3428.cdUnitPrice)
    x3428.PriceExchange = trim$(  x3428.PriceExchange)
    x3428.DateExchange = trim$(  x3428.DateExchange)
    x3428.seOrigin = trim$(  x3428.seOrigin)
    x3428.cdOrigin = trim$(  x3428.cdOrigin)
    x3428.seDepartment = trim$(  x3428.seDepartment)
    x3428.cdDepartment = trim$(  x3428.cdDepartment)
    x3428.seCommercialTerm = trim$(  x3428.seCommercialTerm)
    x3428.cdCommercialTerm = trim$(  x3428.cdCommercialTerm)
    x3428.seDeliveryTerm = trim$(  x3428.seDeliveryTerm)
    x3428.cdDeliveryTerm = trim$(  x3428.cdDeliveryTerm)
    x3428.sePaymentTerm = trim$(  x3428.sePaymentTerm)
    x3428.cdPaymentTerm = trim$(  x3428.cdPaymentTerm)
    x3428.sePaymentCondition = trim$(  x3428.sePaymentCondition)
    x3428.cdPaymentCondition = trim$(  x3428.cdPaymentCondition)
    x3428.sePaymentTime = trim$(  x3428.sePaymentTime)
    x3428.cdPaymentTime = trim$(  x3428.cdPaymentTime)
    x3428.sePaymentDay = trim$(  x3428.sePaymentDay)
    x3428.cdPaymentDay = trim$(  x3428.cdPaymentDay)
    x3428.seBuyingType = trim$(  x3428.seBuyingType)
    x3428.cdBuyingType = trim$(  x3428.cdBuyingType)
    x3428.TypeDiscount = trim$(  x3428.TypeDiscount)
    x3428.PerDiscount = trim$(  x3428.PerDiscount)
    x3428.AmtDiscount = trim$(  x3428.AmtDiscount)
    x3428.QualityRequest = trim$(  x3428.QualityRequest)
    x3428.ContractNo = trim$(  x3428.ContractNo)
    x3428.Tolerance = trim$(  x3428.Tolerance)
    x3428.Destination = trim$(  x3428.Destination)
    x3428.InchargePurchasing = trim$(  x3428.InchargePurchasing)
    x3428.AmountPurchasingEX = trim$(  x3428.AmountPurchasingEX)
    x3428.AmountPurchasingVND = trim$(  x3428.AmountPurchasingVND)
    x3428.AmountTaxEX = trim$(  x3428.AmountTaxEX)
    x3428.AmountTaxVND = trim$(  x3428.AmountTaxVND)
    x3428.AmountExpenseEX = trim$(  x3428.AmountExpenseEX)
    x3428.AmountExpenseUSD = trim$(  x3428.AmountExpenseUSD)
    x3428.AmountExpenseVND = trim$(  x3428.AmountExpenseVND)
    x3428.DateStart = trim$(  x3428.DateStart)
    x3428.DateEstimate = trim$(  x3428.DateEstimate)
    x3428.DateDelivery = trim$(  x3428.DateDelivery)
    x3428.DateInsert = trim$(  x3428.DateInsert)
    x3428.DateUpdate = trim$(  x3428.DateUpdate)
    x3428.InchargeInsert = trim$(  x3428.InchargeInsert)
    x3428.InchargeUpdate = trim$(  x3428.InchargeUpdate)
    x3428.TimeInsert = trim$(  x3428.TimeInsert)
    x3428.TimeUpdate = trim$(  x3428.TimeUpdate)
    x3428.CheckComplete = trim$(  x3428.CheckComplete)
    x3428.InchargeSync = trim$(  x3428.InchargeSync)
    x3428.DateSync = trim$(  x3428.DateSync)
    x3428.CheckSync = trim$(  x3428.CheckSync)
    x3428.PurchasingOrderNo = trim$(  x3428.PurchasingOrderNo)
    x3428.SalesOrderNo = trim$(  x3428.SalesOrderNo)
    x3428.SalesOrderSeq = trim$(  x3428.SalesOrderSeq)
    x3428.SalesOrderSno = trim$(  x3428.SalesOrderSno)
    x3428.Remark = trim$(  x3428.Remark)
    x3428.seSite = trim$(  x3428.seSite)
    x3428.cdSite = trim$(  x3428.cdSite)
     
    If trim$( x3428.PayableNo ) = "" Then x3428.PayableNo = Space(1) 
    If trim$( x3428.seSeason ) = "" Then x3428.seSeason = Space(1) 
    If trim$( x3428.cdSeason ) = "" Then x3428.cdSeason = Space(1) 
    If trim$( x3428.CustomerCode ) = "" Then x3428.CustomerCode = Space(1) 
    If trim$( x3428.DateAccept ) = "" Then x3428.DateAccept = Space(1) 
    If trim$( x3428.CheckInPurchasingOrder ) = "" Then x3428.CheckInPurchasingOrder = Space(1) 
    If trim$( x3428.CheckOutPurchasingOrder ) = "" Then x3428.CheckOutPurchasingOrder = Space(1) 
    If trim$( x3428.CheckProcessType ) = "" Then x3428.CheckProcessType = Space(1) 
    If trim$( x3428.CheckIOType ) = "" Then x3428.CheckIOType = Space(1) 
    If trim$( x3428.CheckMaterialType ) = "" Then x3428.CheckMaterialType = Space(1) 
    If trim$( x3428.CheckMarketType ) = "" Then x3428.CheckMarketType = Space(1) 
    If trim$( x3428.CheckRelationType ) = "" Then x3428.CheckRelationType = Space(1) 
    If trim$( x3428.SupplierCode ) = "" Then x3428.SupplierCode = Space(1) 
    If trim$( x3428.selUnitPrice ) = "" Then x3428.selUnitPrice = Space(1) 
    If trim$( x3428.cdUnitPrice ) = "" Then x3428.cdUnitPrice = Space(1) 
    If trim$( x3428.PriceExchange ) = "" Then x3428.PriceExchange = 0 
    If trim$( x3428.DateExchange ) = "" Then x3428.DateExchange = Space(1) 
    If trim$( x3428.seOrigin ) = "" Then x3428.seOrigin = Space(1) 
    If trim$( x3428.cdOrigin ) = "" Then x3428.cdOrigin = Space(1) 
    If trim$( x3428.seDepartment ) = "" Then x3428.seDepartment = Space(1) 
    If trim$( x3428.cdDepartment ) = "" Then x3428.cdDepartment = Space(1) 
    If trim$( x3428.seCommercialTerm ) = "" Then x3428.seCommercialTerm = Space(1) 
    If trim$( x3428.cdCommercialTerm ) = "" Then x3428.cdCommercialTerm = Space(1) 
    If trim$( x3428.seDeliveryTerm ) = "" Then x3428.seDeliveryTerm = Space(1) 
    If trim$( x3428.cdDeliveryTerm ) = "" Then x3428.cdDeliveryTerm = Space(1) 
    If trim$( x3428.sePaymentTerm ) = "" Then x3428.sePaymentTerm = Space(1) 
    If trim$( x3428.cdPaymentTerm ) = "" Then x3428.cdPaymentTerm = Space(1) 
    If trim$( x3428.sePaymentCondition ) = "" Then x3428.sePaymentCondition = Space(1) 
    If trim$( x3428.cdPaymentCondition ) = "" Then x3428.cdPaymentCondition = Space(1) 
    If trim$( x3428.sePaymentTime ) = "" Then x3428.sePaymentTime = Space(1) 
    If trim$( x3428.cdPaymentTime ) = "" Then x3428.cdPaymentTime = Space(1) 
    If trim$( x3428.sePaymentDay ) = "" Then x3428.sePaymentDay = Space(1) 
    If trim$( x3428.cdPaymentDay ) = "" Then x3428.cdPaymentDay = Space(1) 
    If trim$( x3428.seBuyingType ) = "" Then x3428.seBuyingType = Space(1) 
    If trim$( x3428.cdBuyingType ) = "" Then x3428.cdBuyingType = Space(1) 
    If trim$( x3428.TypeDiscount ) = "" Then x3428.TypeDiscount = Space(1) 
    If trim$( x3428.PerDiscount ) = "" Then x3428.PerDiscount = 0 
    If trim$( x3428.AmtDiscount ) = "" Then x3428.AmtDiscount = 0 
    If trim$( x3428.QualityRequest ) = "" Then x3428.QualityRequest = Space(1) 
    If trim$( x3428.ContractNo ) = "" Then x3428.ContractNo = Space(1) 
    If trim$( x3428.Tolerance ) = "" Then x3428.Tolerance = Space(1) 
    If trim$( x3428.Destination ) = "" Then x3428.Destination = Space(1) 
    If trim$( x3428.InchargePurchasing ) = "" Then x3428.InchargePurchasing = Space(1) 
    If trim$( x3428.AmountPurchasingEX ) = "" Then x3428.AmountPurchasingEX = 0 
    If trim$( x3428.AmountPurchasingVND ) = "" Then x3428.AmountPurchasingVND = 0 
    If trim$( x3428.AmountTaxEX ) = "" Then x3428.AmountTaxEX = 0 
    If trim$( x3428.AmountTaxVND ) = "" Then x3428.AmountTaxVND = 0 
    If trim$( x3428.AmountExpenseEX ) = "" Then x3428.AmountExpenseEX = 0 
    If trim$( x3428.AmountExpenseUSD ) = "" Then x3428.AmountExpenseUSD = 0 
    If trim$( x3428.AmountExpenseVND ) = "" Then x3428.AmountExpenseVND = 0 
    If trim$( x3428.DateStart ) = "" Then x3428.DateStart = Space(1) 
    If trim$( x3428.DateEstimate ) = "" Then x3428.DateEstimate = Space(1) 
    If trim$( x3428.DateDelivery ) = "" Then x3428.DateDelivery = Space(1) 
    If trim$( x3428.DateInsert ) = "" Then x3428.DateInsert = Space(1) 
    If trim$( x3428.DateUpdate ) = "" Then x3428.DateUpdate = Space(1) 
    If trim$( x3428.InchargeInsert ) = "" Then x3428.InchargeInsert = Space(1) 
    If trim$( x3428.InchargeUpdate ) = "" Then x3428.InchargeUpdate = Space(1) 
    If trim$( x3428.TimeInsert ) = "" Then x3428.TimeInsert = Space(1) 
    If trim$( x3428.TimeUpdate ) = "" Then x3428.TimeUpdate = Space(1) 
    If trim$( x3428.CheckComplete ) = "" Then x3428.CheckComplete = Space(1) 
    If trim$( x3428.InchargeSync ) = "" Then x3428.InchargeSync = Space(1) 
    If trim$( x3428.DateSync ) = "" Then x3428.DateSync = Space(1) 
    If trim$( x3428.CheckSync ) = "" Then x3428.CheckSync = Space(1) 
    If trim$( x3428.PurchasingOrderNo ) = "" Then x3428.PurchasingOrderNo = Space(1) 
    If trim$( x3428.SalesOrderNo ) = "" Then x3428.SalesOrderNo = Space(1) 
    If trim$( x3428.SalesOrderSeq ) = "" Then x3428.SalesOrderSeq = Space(1) 
    If trim$( x3428.SalesOrderSno ) = "" Then x3428.SalesOrderSno = Space(1) 
    If trim$( x3428.Remark ) = "" Then x3428.Remark = Space(1) 
    If trim$( x3428.seSite ) = "" Then x3428.seSite = Space(1) 
    If trim$( x3428.cdSite ) = "" Then x3428.cdSite = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K3428_MOVE(rs3428 As SqlClient.SqlDataReader)
Try

    call D3428_CLEAR()   

    If IsdbNull(rs3428!K3428_PayableNo) = False Then D3428.PayableNo = Trim$(rs3428!K3428_PayableNo)
    If IsdbNull(rs3428!K3428_seSeason) = False Then D3428.seSeason = Trim$(rs3428!K3428_seSeason)
    If IsdbNull(rs3428!K3428_cdSeason) = False Then D3428.cdSeason = Trim$(rs3428!K3428_cdSeason)
    If IsdbNull(rs3428!K3428_CustomerCode) = False Then D3428.CustomerCode = Trim$(rs3428!K3428_CustomerCode)
    If IsdbNull(rs3428!K3428_DateAccept) = False Then D3428.DateAccept = Trim$(rs3428!K3428_DateAccept)
    If IsdbNull(rs3428!K3428_CheckInPurchasingOrder) = False Then D3428.CheckInPurchasingOrder = Trim$(rs3428!K3428_CheckInPurchasingOrder)
    If IsdbNull(rs3428!K3428_CheckOutPurchasingOrder) = False Then D3428.CheckOutPurchasingOrder = Trim$(rs3428!K3428_CheckOutPurchasingOrder)
    If IsdbNull(rs3428!K3428_CheckProcessType) = False Then D3428.CheckProcessType = Trim$(rs3428!K3428_CheckProcessType)
    If IsdbNull(rs3428!K3428_CheckIOType) = False Then D3428.CheckIOType = Trim$(rs3428!K3428_CheckIOType)
    If IsdbNull(rs3428!K3428_CheckMaterialType) = False Then D3428.CheckMaterialType = Trim$(rs3428!K3428_CheckMaterialType)
    If IsdbNull(rs3428!K3428_CheckMarketType) = False Then D3428.CheckMarketType = Trim$(rs3428!K3428_CheckMarketType)
    If IsdbNull(rs3428!K3428_CheckRelationType) = False Then D3428.CheckRelationType = Trim$(rs3428!K3428_CheckRelationType)
    If IsdbNull(rs3428!K3428_SupplierCode) = False Then D3428.SupplierCode = Trim$(rs3428!K3428_SupplierCode)
    If IsdbNull(rs3428!K3428_selUnitPrice) = False Then D3428.selUnitPrice = Trim$(rs3428!K3428_selUnitPrice)
    If IsdbNull(rs3428!K3428_cdUnitPrice) = False Then D3428.cdUnitPrice = Trim$(rs3428!K3428_cdUnitPrice)
    If IsdbNull(rs3428!K3428_PriceExchange) = False Then D3428.PriceExchange = Trim$(rs3428!K3428_PriceExchange)
    If IsdbNull(rs3428!K3428_DateExchange) = False Then D3428.DateExchange = Trim$(rs3428!K3428_DateExchange)
    If IsdbNull(rs3428!K3428_seOrigin) = False Then D3428.seOrigin = Trim$(rs3428!K3428_seOrigin)
    If IsdbNull(rs3428!K3428_cdOrigin) = False Then D3428.cdOrigin = Trim$(rs3428!K3428_cdOrigin)
    If IsdbNull(rs3428!K3428_seDepartment) = False Then D3428.seDepartment = Trim$(rs3428!K3428_seDepartment)
    If IsdbNull(rs3428!K3428_cdDepartment) = False Then D3428.cdDepartment = Trim$(rs3428!K3428_cdDepartment)
    If IsdbNull(rs3428!K3428_seCommercialTerm) = False Then D3428.seCommercialTerm = Trim$(rs3428!K3428_seCommercialTerm)
    If IsdbNull(rs3428!K3428_cdCommercialTerm) = False Then D3428.cdCommercialTerm = Trim$(rs3428!K3428_cdCommercialTerm)
    If IsdbNull(rs3428!K3428_seDeliveryTerm) = False Then D3428.seDeliveryTerm = Trim$(rs3428!K3428_seDeliveryTerm)
    If IsdbNull(rs3428!K3428_cdDeliveryTerm) = False Then D3428.cdDeliveryTerm = Trim$(rs3428!K3428_cdDeliveryTerm)
    If IsdbNull(rs3428!K3428_sePaymentTerm) = False Then D3428.sePaymentTerm = Trim$(rs3428!K3428_sePaymentTerm)
    If IsdbNull(rs3428!K3428_cdPaymentTerm) = False Then D3428.cdPaymentTerm = Trim$(rs3428!K3428_cdPaymentTerm)
    If IsdbNull(rs3428!K3428_sePaymentCondition) = False Then D3428.sePaymentCondition = Trim$(rs3428!K3428_sePaymentCondition)
    If IsdbNull(rs3428!K3428_cdPaymentCondition) = False Then D3428.cdPaymentCondition = Trim$(rs3428!K3428_cdPaymentCondition)
    If IsdbNull(rs3428!K3428_sePaymentTime) = False Then D3428.sePaymentTime = Trim$(rs3428!K3428_sePaymentTime)
    If IsdbNull(rs3428!K3428_cdPaymentTime) = False Then D3428.cdPaymentTime = Trim$(rs3428!K3428_cdPaymentTime)
    If IsdbNull(rs3428!K3428_sePaymentDay) = False Then D3428.sePaymentDay = Trim$(rs3428!K3428_sePaymentDay)
    If IsdbNull(rs3428!K3428_cdPaymentDay) = False Then D3428.cdPaymentDay = Trim$(rs3428!K3428_cdPaymentDay)
    If IsdbNull(rs3428!K3428_seBuyingType) = False Then D3428.seBuyingType = Trim$(rs3428!K3428_seBuyingType)
    If IsdbNull(rs3428!K3428_cdBuyingType) = False Then D3428.cdBuyingType = Trim$(rs3428!K3428_cdBuyingType)
    If IsdbNull(rs3428!K3428_TypeDiscount) = False Then D3428.TypeDiscount = Trim$(rs3428!K3428_TypeDiscount)
    If IsdbNull(rs3428!K3428_PerDiscount) = False Then D3428.PerDiscount = Trim$(rs3428!K3428_PerDiscount)
    If IsdbNull(rs3428!K3428_AmtDiscount) = False Then D3428.AmtDiscount = Trim$(rs3428!K3428_AmtDiscount)
    If IsdbNull(rs3428!K3428_QualityRequest) = False Then D3428.QualityRequest = Trim$(rs3428!K3428_QualityRequest)
    If IsdbNull(rs3428!K3428_ContractNo) = False Then D3428.ContractNo = Trim$(rs3428!K3428_ContractNo)
    If IsdbNull(rs3428!K3428_Tolerance) = False Then D3428.Tolerance = Trim$(rs3428!K3428_Tolerance)
    If IsdbNull(rs3428!K3428_Destination) = False Then D3428.Destination = Trim$(rs3428!K3428_Destination)
    If IsdbNull(rs3428!K3428_InchargePurchasing) = False Then D3428.InchargePurchasing = Trim$(rs3428!K3428_InchargePurchasing)
    If IsdbNull(rs3428!K3428_AmountPurchasingEX) = False Then D3428.AmountPurchasingEX = Trim$(rs3428!K3428_AmountPurchasingEX)
    If IsdbNull(rs3428!K3428_AmountPurchasingVND) = False Then D3428.AmountPurchasingVND = Trim$(rs3428!K3428_AmountPurchasingVND)
    If IsdbNull(rs3428!K3428_AmountTaxEX) = False Then D3428.AmountTaxEX = Trim$(rs3428!K3428_AmountTaxEX)
    If IsdbNull(rs3428!K3428_AmountTaxVND) = False Then D3428.AmountTaxVND = Trim$(rs3428!K3428_AmountTaxVND)
    If IsdbNull(rs3428!K3428_AmountExpenseEX) = False Then D3428.AmountExpenseEX = Trim$(rs3428!K3428_AmountExpenseEX)
    If IsdbNull(rs3428!K3428_AmountExpenseUSD) = False Then D3428.AmountExpenseUSD = Trim$(rs3428!K3428_AmountExpenseUSD)
    If IsdbNull(rs3428!K3428_AmountExpenseVND) = False Then D3428.AmountExpenseVND = Trim$(rs3428!K3428_AmountExpenseVND)
    If IsdbNull(rs3428!K3428_DateStart) = False Then D3428.DateStart = Trim$(rs3428!K3428_DateStart)
    If IsdbNull(rs3428!K3428_DateEstimate) = False Then D3428.DateEstimate = Trim$(rs3428!K3428_DateEstimate)
    If IsdbNull(rs3428!K3428_DateDelivery) = False Then D3428.DateDelivery = Trim$(rs3428!K3428_DateDelivery)
    If IsdbNull(rs3428!K3428_DateInsert) = False Then D3428.DateInsert = Trim$(rs3428!K3428_DateInsert)
    If IsdbNull(rs3428!K3428_DateUpdate) = False Then D3428.DateUpdate = Trim$(rs3428!K3428_DateUpdate)
    If IsdbNull(rs3428!K3428_InchargeInsert) = False Then D3428.InchargeInsert = Trim$(rs3428!K3428_InchargeInsert)
    If IsdbNull(rs3428!K3428_InchargeUpdate) = False Then D3428.InchargeUpdate = Trim$(rs3428!K3428_InchargeUpdate)
    If IsdbNull(rs3428!K3428_TimeInsert) = False Then D3428.TimeInsert = Trim$(rs3428!K3428_TimeInsert)
    If IsdbNull(rs3428!K3428_TimeUpdate) = False Then D3428.TimeUpdate = Trim$(rs3428!K3428_TimeUpdate)
    If IsdbNull(rs3428!K3428_CheckComplete) = False Then D3428.CheckComplete = Trim$(rs3428!K3428_CheckComplete)
    If IsdbNull(rs3428!K3428_InchargeSync) = False Then D3428.InchargeSync = Trim$(rs3428!K3428_InchargeSync)
    If IsdbNull(rs3428!K3428_DateSync) = False Then D3428.DateSync = Trim$(rs3428!K3428_DateSync)
    If IsdbNull(rs3428!K3428_CheckSync) = False Then D3428.CheckSync = Trim$(rs3428!K3428_CheckSync)
    If IsdbNull(rs3428!K3428_PurchasingOrderNo) = False Then D3428.PurchasingOrderNo = Trim$(rs3428!K3428_PurchasingOrderNo)
    If IsdbNull(rs3428!K3428_SalesOrderNo) = False Then D3428.SalesOrderNo = Trim$(rs3428!K3428_SalesOrderNo)
    If IsdbNull(rs3428!K3428_SalesOrderSeq) = False Then D3428.SalesOrderSeq = Trim$(rs3428!K3428_SalesOrderSeq)
    If IsdbNull(rs3428!K3428_SalesOrderSno) = False Then D3428.SalesOrderSno = Trim$(rs3428!K3428_SalesOrderSno)
    If IsdbNull(rs3428!K3428_Remark) = False Then D3428.Remark = Trim$(rs3428!K3428_Remark)
    If IsdbNull(rs3428!K3428_seSite) = False Then D3428.seSite = Trim$(rs3428!K3428_seSite)
    If IsdbNull(rs3428!K3428_cdSite) = False Then D3428.cdSite = Trim$(rs3428!K3428_cdSite)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K3428_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K3428_MOVE(rs3428 As DataRow)
Try

    call D3428_CLEAR()   

    If IsdbNull(rs3428!K3428_PayableNo) = False Then D3428.PayableNo = Trim$(rs3428!K3428_PayableNo)
    If IsdbNull(rs3428!K3428_seSeason) = False Then D3428.seSeason = Trim$(rs3428!K3428_seSeason)
    If IsdbNull(rs3428!K3428_cdSeason) = False Then D3428.cdSeason = Trim$(rs3428!K3428_cdSeason)
    If IsdbNull(rs3428!K3428_CustomerCode) = False Then D3428.CustomerCode = Trim$(rs3428!K3428_CustomerCode)
    If IsdbNull(rs3428!K3428_DateAccept) = False Then D3428.DateAccept = Trim$(rs3428!K3428_DateAccept)
    If IsdbNull(rs3428!K3428_CheckInPurchasingOrder) = False Then D3428.CheckInPurchasingOrder = Trim$(rs3428!K3428_CheckInPurchasingOrder)
    If IsdbNull(rs3428!K3428_CheckOutPurchasingOrder) = False Then D3428.CheckOutPurchasingOrder = Trim$(rs3428!K3428_CheckOutPurchasingOrder)
    If IsdbNull(rs3428!K3428_CheckProcessType) = False Then D3428.CheckProcessType = Trim$(rs3428!K3428_CheckProcessType)
    If IsdbNull(rs3428!K3428_CheckIOType) = False Then D3428.CheckIOType = Trim$(rs3428!K3428_CheckIOType)
    If IsdbNull(rs3428!K3428_CheckMaterialType) = False Then D3428.CheckMaterialType = Trim$(rs3428!K3428_CheckMaterialType)
    If IsdbNull(rs3428!K3428_CheckMarketType) = False Then D3428.CheckMarketType = Trim$(rs3428!K3428_CheckMarketType)
    If IsdbNull(rs3428!K3428_CheckRelationType) = False Then D3428.CheckRelationType = Trim$(rs3428!K3428_CheckRelationType)
    If IsdbNull(rs3428!K3428_SupplierCode) = False Then D3428.SupplierCode = Trim$(rs3428!K3428_SupplierCode)
    If IsdbNull(rs3428!K3428_selUnitPrice) = False Then D3428.selUnitPrice = Trim$(rs3428!K3428_selUnitPrice)
    If IsdbNull(rs3428!K3428_cdUnitPrice) = False Then D3428.cdUnitPrice = Trim$(rs3428!K3428_cdUnitPrice)
    If IsdbNull(rs3428!K3428_PriceExchange) = False Then D3428.PriceExchange = Trim$(rs3428!K3428_PriceExchange)
    If IsdbNull(rs3428!K3428_DateExchange) = False Then D3428.DateExchange = Trim$(rs3428!K3428_DateExchange)
    If IsdbNull(rs3428!K3428_seOrigin) = False Then D3428.seOrigin = Trim$(rs3428!K3428_seOrigin)
    If IsdbNull(rs3428!K3428_cdOrigin) = False Then D3428.cdOrigin = Trim$(rs3428!K3428_cdOrigin)
    If IsdbNull(rs3428!K3428_seDepartment) = False Then D3428.seDepartment = Trim$(rs3428!K3428_seDepartment)
    If IsdbNull(rs3428!K3428_cdDepartment) = False Then D3428.cdDepartment = Trim$(rs3428!K3428_cdDepartment)
    If IsdbNull(rs3428!K3428_seCommercialTerm) = False Then D3428.seCommercialTerm = Trim$(rs3428!K3428_seCommercialTerm)
    If IsdbNull(rs3428!K3428_cdCommercialTerm) = False Then D3428.cdCommercialTerm = Trim$(rs3428!K3428_cdCommercialTerm)
    If IsdbNull(rs3428!K3428_seDeliveryTerm) = False Then D3428.seDeliveryTerm = Trim$(rs3428!K3428_seDeliveryTerm)
    If IsdbNull(rs3428!K3428_cdDeliveryTerm) = False Then D3428.cdDeliveryTerm = Trim$(rs3428!K3428_cdDeliveryTerm)
    If IsdbNull(rs3428!K3428_sePaymentTerm) = False Then D3428.sePaymentTerm = Trim$(rs3428!K3428_sePaymentTerm)
    If IsdbNull(rs3428!K3428_cdPaymentTerm) = False Then D3428.cdPaymentTerm = Trim$(rs3428!K3428_cdPaymentTerm)
    If IsdbNull(rs3428!K3428_sePaymentCondition) = False Then D3428.sePaymentCondition = Trim$(rs3428!K3428_sePaymentCondition)
    If IsdbNull(rs3428!K3428_cdPaymentCondition) = False Then D3428.cdPaymentCondition = Trim$(rs3428!K3428_cdPaymentCondition)
    If IsdbNull(rs3428!K3428_sePaymentTime) = False Then D3428.sePaymentTime = Trim$(rs3428!K3428_sePaymentTime)
    If IsdbNull(rs3428!K3428_cdPaymentTime) = False Then D3428.cdPaymentTime = Trim$(rs3428!K3428_cdPaymentTime)
    If IsdbNull(rs3428!K3428_sePaymentDay) = False Then D3428.sePaymentDay = Trim$(rs3428!K3428_sePaymentDay)
    If IsdbNull(rs3428!K3428_cdPaymentDay) = False Then D3428.cdPaymentDay = Trim$(rs3428!K3428_cdPaymentDay)
    If IsdbNull(rs3428!K3428_seBuyingType) = False Then D3428.seBuyingType = Trim$(rs3428!K3428_seBuyingType)
    If IsdbNull(rs3428!K3428_cdBuyingType) = False Then D3428.cdBuyingType = Trim$(rs3428!K3428_cdBuyingType)
    If IsdbNull(rs3428!K3428_TypeDiscount) = False Then D3428.TypeDiscount = Trim$(rs3428!K3428_TypeDiscount)
    If IsdbNull(rs3428!K3428_PerDiscount) = False Then D3428.PerDiscount = Trim$(rs3428!K3428_PerDiscount)
    If IsdbNull(rs3428!K3428_AmtDiscount) = False Then D3428.AmtDiscount = Trim$(rs3428!K3428_AmtDiscount)
    If IsdbNull(rs3428!K3428_QualityRequest) = False Then D3428.QualityRequest = Trim$(rs3428!K3428_QualityRequest)
    If IsdbNull(rs3428!K3428_ContractNo) = False Then D3428.ContractNo = Trim$(rs3428!K3428_ContractNo)
    If IsdbNull(rs3428!K3428_Tolerance) = False Then D3428.Tolerance = Trim$(rs3428!K3428_Tolerance)
    If IsdbNull(rs3428!K3428_Destination) = False Then D3428.Destination = Trim$(rs3428!K3428_Destination)
    If IsdbNull(rs3428!K3428_InchargePurchasing) = False Then D3428.InchargePurchasing = Trim$(rs3428!K3428_InchargePurchasing)
    If IsdbNull(rs3428!K3428_AmountPurchasingEX) = False Then D3428.AmountPurchasingEX = Trim$(rs3428!K3428_AmountPurchasingEX)
    If IsdbNull(rs3428!K3428_AmountPurchasingVND) = False Then D3428.AmountPurchasingVND = Trim$(rs3428!K3428_AmountPurchasingVND)
    If IsdbNull(rs3428!K3428_AmountTaxEX) = False Then D3428.AmountTaxEX = Trim$(rs3428!K3428_AmountTaxEX)
    If IsdbNull(rs3428!K3428_AmountTaxVND) = False Then D3428.AmountTaxVND = Trim$(rs3428!K3428_AmountTaxVND)
    If IsdbNull(rs3428!K3428_AmountExpenseEX) = False Then D3428.AmountExpenseEX = Trim$(rs3428!K3428_AmountExpenseEX)
    If IsdbNull(rs3428!K3428_AmountExpenseUSD) = False Then D3428.AmountExpenseUSD = Trim$(rs3428!K3428_AmountExpenseUSD)
    If IsdbNull(rs3428!K3428_AmountExpenseVND) = False Then D3428.AmountExpenseVND = Trim$(rs3428!K3428_AmountExpenseVND)
    If IsdbNull(rs3428!K3428_DateStart) = False Then D3428.DateStart = Trim$(rs3428!K3428_DateStart)
    If IsdbNull(rs3428!K3428_DateEstimate) = False Then D3428.DateEstimate = Trim$(rs3428!K3428_DateEstimate)
    If IsdbNull(rs3428!K3428_DateDelivery) = False Then D3428.DateDelivery = Trim$(rs3428!K3428_DateDelivery)
    If IsdbNull(rs3428!K3428_DateInsert) = False Then D3428.DateInsert = Trim$(rs3428!K3428_DateInsert)
    If IsdbNull(rs3428!K3428_DateUpdate) = False Then D3428.DateUpdate = Trim$(rs3428!K3428_DateUpdate)
    If IsdbNull(rs3428!K3428_InchargeInsert) = False Then D3428.InchargeInsert = Trim$(rs3428!K3428_InchargeInsert)
    If IsdbNull(rs3428!K3428_InchargeUpdate) = False Then D3428.InchargeUpdate = Trim$(rs3428!K3428_InchargeUpdate)
    If IsdbNull(rs3428!K3428_TimeInsert) = False Then D3428.TimeInsert = Trim$(rs3428!K3428_TimeInsert)
    If IsdbNull(rs3428!K3428_TimeUpdate) = False Then D3428.TimeUpdate = Trim$(rs3428!K3428_TimeUpdate)
    If IsdbNull(rs3428!K3428_CheckComplete) = False Then D3428.CheckComplete = Trim$(rs3428!K3428_CheckComplete)
    If IsdbNull(rs3428!K3428_InchargeSync) = False Then D3428.InchargeSync = Trim$(rs3428!K3428_InchargeSync)
    If IsdbNull(rs3428!K3428_DateSync) = False Then D3428.DateSync = Trim$(rs3428!K3428_DateSync)
    If IsdbNull(rs3428!K3428_CheckSync) = False Then D3428.CheckSync = Trim$(rs3428!K3428_CheckSync)
    If IsdbNull(rs3428!K3428_PurchasingOrderNo) = False Then D3428.PurchasingOrderNo = Trim$(rs3428!K3428_PurchasingOrderNo)
    If IsdbNull(rs3428!K3428_SalesOrderNo) = False Then D3428.SalesOrderNo = Trim$(rs3428!K3428_SalesOrderNo)
    If IsdbNull(rs3428!K3428_SalesOrderSeq) = False Then D3428.SalesOrderSeq = Trim$(rs3428!K3428_SalesOrderSeq)
    If IsdbNull(rs3428!K3428_SalesOrderSno) = False Then D3428.SalesOrderSno = Trim$(rs3428!K3428_SalesOrderSno)
    If IsdbNull(rs3428!K3428_Remark) = False Then D3428.Remark = Trim$(rs3428!K3428_Remark)
    If IsdbNull(rs3428!K3428_seSite) = False Then D3428.seSite = Trim$(rs3428!K3428_seSite)
    If IsdbNull(rs3428!K3428_cdSite) = False Then D3428.cdSite = Trim$(rs3428!K3428_cdSite)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K3428_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K3428_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z3428 As T3428_AREA, PAYABLENO AS String) as Boolean

K3428_MOVE = False

Try
    If READ_PFK3428(PAYABLENO) = True Then
                z3428 = D3428
		K3428_MOVE = True
		else
	z3428 = nothing
     End If

     If  getColumnIndex(spr,"PayableNo") > -1 then z3428.PayableNo = getDataM(spr, getColumnIndex(spr,"PayableNo"), xRow)
     If  getColumnIndex(spr,"seSeason") > -1 then z3428.seSeason = getDataM(spr, getColumnIndex(spr,"seSeason"), xRow)
     If  getColumnIndex(spr,"cdSeason") > -1 then z3428.cdSeason = getDataM(spr, getColumnIndex(spr,"cdSeason"), xRow)
     If  getColumnIndex(spr,"CustomerCode") > -1 then z3428.CustomerCode = getDataM(spr, getColumnIndex(spr,"CustomerCode"), xRow)
     If  getColumnIndex(spr,"DateAccept") > -1 then z3428.DateAccept = getDataM(spr, getColumnIndex(spr,"DateAccept"), xRow)
     If  getColumnIndex(spr,"CheckInPurchasingOrder") > -1 then z3428.CheckInPurchasingOrder = getDataM(spr, getColumnIndex(spr,"CheckInPurchasingOrder"), xRow)
     If  getColumnIndex(spr,"CheckOutPurchasingOrder") > -1 then z3428.CheckOutPurchasingOrder = getDataM(spr, getColumnIndex(spr,"CheckOutPurchasingOrder"), xRow)
     If  getColumnIndex(spr,"CheckProcessType") > -1 then z3428.CheckProcessType = getDataM(spr, getColumnIndex(spr,"CheckProcessType"), xRow)
     If  getColumnIndex(spr,"CheckIOType") > -1 then z3428.CheckIOType = getDataM(spr, getColumnIndex(spr,"CheckIOType"), xRow)
     If  getColumnIndex(spr,"CheckMaterialType") > -1 then z3428.CheckMaterialType = getDataM(spr, getColumnIndex(spr,"CheckMaterialType"), xRow)
     If  getColumnIndex(spr,"CheckMarketType") > -1 then z3428.CheckMarketType = getDataM(spr, getColumnIndex(spr,"CheckMarketType"), xRow)
     If  getColumnIndex(spr,"CheckRelationType") > -1 then z3428.CheckRelationType = getDataM(spr, getColumnIndex(spr,"CheckRelationType"), xRow)
     If  getColumnIndex(spr,"SupplierCode") > -1 then z3428.SupplierCode = getDataM(spr, getColumnIndex(spr,"SupplierCode"), xRow)
     If  getColumnIndex(spr,"selUnitPrice") > -1 then z3428.selUnitPrice = getDataM(spr, getColumnIndex(spr,"selUnitPrice"), xRow)
     If  getColumnIndex(spr,"cdUnitPrice") > -1 then z3428.cdUnitPrice = getDataM(spr, getColumnIndex(spr,"cdUnitPrice"), xRow)
     If  getColumnIndex(spr,"PriceExchange") > -1 then z3428.PriceExchange = Cdecp(getDataM(spr, getColumnIndex(spr,"PriceExchange"), xRow))
     If  getColumnIndex(spr,"DateExchange") > -1 then z3428.DateExchange = getDataM(spr, getColumnIndex(spr,"DateExchange"), xRow)
     If  getColumnIndex(spr,"seOrigin") > -1 then z3428.seOrigin = getDataM(spr, getColumnIndex(spr,"seOrigin"), xRow)
     If  getColumnIndex(spr,"cdOrigin") > -1 then z3428.cdOrigin = getDataM(spr, getColumnIndex(spr,"cdOrigin"), xRow)
     If  getColumnIndex(spr,"seDepartment") > -1 then z3428.seDepartment = getDataM(spr, getColumnIndex(spr,"seDepartment"), xRow)
     If  getColumnIndex(spr,"cdDepartment") > -1 then z3428.cdDepartment = getDataM(spr, getColumnIndex(spr,"cdDepartment"), xRow)
     If  getColumnIndex(spr,"seCommercialTerm") > -1 then z3428.seCommercialTerm = getDataM(spr, getColumnIndex(spr,"seCommercialTerm"), xRow)
     If  getColumnIndex(spr,"cdCommercialTerm") > -1 then z3428.cdCommercialTerm = getDataM(spr, getColumnIndex(spr,"cdCommercialTerm"), xRow)
     If  getColumnIndex(spr,"seDeliveryTerm") > -1 then z3428.seDeliveryTerm = getDataM(spr, getColumnIndex(spr,"seDeliveryTerm"), xRow)
     If  getColumnIndex(spr,"cdDeliveryTerm") > -1 then z3428.cdDeliveryTerm = getDataM(spr, getColumnIndex(spr,"cdDeliveryTerm"), xRow)
     If  getColumnIndex(spr,"sePaymentTerm") > -1 then z3428.sePaymentTerm = getDataM(spr, getColumnIndex(spr,"sePaymentTerm"), xRow)
     If  getColumnIndex(spr,"cdPaymentTerm") > -1 then z3428.cdPaymentTerm = getDataM(spr, getColumnIndex(spr,"cdPaymentTerm"), xRow)
     If  getColumnIndex(spr,"sePaymentCondition") > -1 then z3428.sePaymentCondition = getDataM(spr, getColumnIndex(spr,"sePaymentCondition"), xRow)
     If  getColumnIndex(spr,"cdPaymentCondition") > -1 then z3428.cdPaymentCondition = getDataM(spr, getColumnIndex(spr,"cdPaymentCondition"), xRow)
     If  getColumnIndex(spr,"sePaymentTime") > -1 then z3428.sePaymentTime = getDataM(spr, getColumnIndex(spr,"sePaymentTime"), xRow)
     If  getColumnIndex(spr,"cdPaymentTime") > -1 then z3428.cdPaymentTime = getDataM(spr, getColumnIndex(spr,"cdPaymentTime"), xRow)
     If  getColumnIndex(spr,"sePaymentDay") > -1 then z3428.sePaymentDay = getDataM(spr, getColumnIndex(spr,"sePaymentDay"), xRow)
     If  getColumnIndex(spr,"cdPaymentDay") > -1 then z3428.cdPaymentDay = getDataM(spr, getColumnIndex(spr,"cdPaymentDay"), xRow)
     If  getColumnIndex(spr,"seBuyingType") > -1 then z3428.seBuyingType = getDataM(spr, getColumnIndex(spr,"seBuyingType"), xRow)
     If  getColumnIndex(spr,"cdBuyingType") > -1 then z3428.cdBuyingType = getDataM(spr, getColumnIndex(spr,"cdBuyingType"), xRow)
     If  getColumnIndex(spr,"TypeDiscount") > -1 then z3428.TypeDiscount = getDataM(spr, getColumnIndex(spr,"TypeDiscount"), xRow)
     If  getColumnIndex(spr,"PerDiscount") > -1 then z3428.PerDiscount = Cdecp(getDataM(spr, getColumnIndex(spr,"PerDiscount"), xRow))
     If  getColumnIndex(spr,"AmtDiscount") > -1 then z3428.AmtDiscount = Cdecp(getDataM(spr, getColumnIndex(spr,"AmtDiscount"), xRow))
     If  getColumnIndex(spr,"QualityRequest") > -1 then z3428.QualityRequest = getDataM(spr, getColumnIndex(spr,"QualityRequest"), xRow)
     If  getColumnIndex(spr,"ContractNo") > -1 then z3428.ContractNo = getDataM(spr, getColumnIndex(spr,"ContractNo"), xRow)
     If  getColumnIndex(spr,"Tolerance") > -1 then z3428.Tolerance = getDataM(spr, getColumnIndex(spr,"Tolerance"), xRow)
     If  getColumnIndex(spr,"Destination") > -1 then z3428.Destination = getDataM(spr, getColumnIndex(spr,"Destination"), xRow)
     If  getColumnIndex(spr,"InchargePurchasing") > -1 then z3428.InchargePurchasing = getDataM(spr, getColumnIndex(spr,"InchargePurchasing"), xRow)
     If  getColumnIndex(spr,"AmountPurchasingEX") > -1 then z3428.AmountPurchasingEX = Cdecp(getDataM(spr, getColumnIndex(spr,"AmountPurchasingEX"), xRow))
     If  getColumnIndex(spr,"AmountPurchasingVND") > -1 then z3428.AmountPurchasingVND = Cdecp(getDataM(spr, getColumnIndex(spr,"AmountPurchasingVND"), xRow))
     If  getColumnIndex(spr,"AmountTaxEX") > -1 then z3428.AmountTaxEX = Cdecp(getDataM(spr, getColumnIndex(spr,"AmountTaxEX"), xRow))
     If  getColumnIndex(spr,"AmountTaxVND") > -1 then z3428.AmountTaxVND = Cdecp(getDataM(spr, getColumnIndex(spr,"AmountTaxVND"), xRow))
     If  getColumnIndex(spr,"AmountExpenseEX") > -1 then z3428.AmountExpenseEX = Cdecp(getDataM(spr, getColumnIndex(spr,"AmountExpenseEX"), xRow))
     If  getColumnIndex(spr,"AmountExpenseUSD") > -1 then z3428.AmountExpenseUSD = Cdecp(getDataM(spr, getColumnIndex(spr,"AmountExpenseUSD"), xRow))
     If  getColumnIndex(spr,"AmountExpenseVND") > -1 then z3428.AmountExpenseVND = Cdecp(getDataM(spr, getColumnIndex(spr,"AmountExpenseVND"), xRow))
     If  getColumnIndex(spr,"DateStart") > -1 then z3428.DateStart = getDataM(spr, getColumnIndex(spr,"DateStart"), xRow)
     If  getColumnIndex(spr,"DateEstimate") > -1 then z3428.DateEstimate = getDataM(spr, getColumnIndex(spr,"DateEstimate"), xRow)
     If  getColumnIndex(spr,"DateDelivery") > -1 then z3428.DateDelivery = getDataM(spr, getColumnIndex(spr,"DateDelivery"), xRow)
     If  getColumnIndex(spr,"DateInsert") > -1 then z3428.DateInsert = getDataM(spr, getColumnIndex(spr,"DateInsert"), xRow)
     If  getColumnIndex(spr,"DateUpdate") > -1 then z3428.DateUpdate = getDataM(spr, getColumnIndex(spr,"DateUpdate"), xRow)
     If  getColumnIndex(spr,"InchargeInsert") > -1 then z3428.InchargeInsert = getDataM(spr, getColumnIndex(spr,"InchargeInsert"), xRow)
     If  getColumnIndex(spr,"InchargeUpdate") > -1 then z3428.InchargeUpdate = getDataM(spr, getColumnIndex(spr,"InchargeUpdate"), xRow)
     If  getColumnIndex(spr,"TimeInsert") > -1 then z3428.TimeInsert = getDataM(spr, getColumnIndex(spr,"TimeInsert"), xRow)
     If  getColumnIndex(spr,"TimeUpdate") > -1 then z3428.TimeUpdate = getDataM(spr, getColumnIndex(spr,"TimeUpdate"), xRow)
     If  getColumnIndex(spr,"CheckComplete") > -1 then z3428.CheckComplete = getDataM(spr, getColumnIndex(spr,"CheckComplete"), xRow)
     If  getColumnIndex(spr,"InchargeSync") > -1 then z3428.InchargeSync = getDataM(spr, getColumnIndex(spr,"InchargeSync"), xRow)
     If  getColumnIndex(spr,"DateSync") > -1 then z3428.DateSync = getDataM(spr, getColumnIndex(spr,"DateSync"), xRow)
     If  getColumnIndex(spr,"CheckSync") > -1 then z3428.CheckSync = getDataM(spr, getColumnIndex(spr,"CheckSync"), xRow)
     If  getColumnIndex(spr,"PurchasingOrderNo") > -1 then z3428.PurchasingOrderNo = getDataM(spr, getColumnIndex(spr,"PurchasingOrderNo"), xRow)
     If  getColumnIndex(spr,"SalesOrderNo") > -1 then z3428.SalesOrderNo = getDataM(spr, getColumnIndex(spr,"SalesOrderNo"), xRow)
     If  getColumnIndex(spr,"SalesOrderSeq") > -1 then z3428.SalesOrderSeq = getDataM(spr, getColumnIndex(spr,"SalesOrderSeq"), xRow)
     If  getColumnIndex(spr,"SalesOrderSno") > -1 then z3428.SalesOrderSno = getDataM(spr, getColumnIndex(spr,"SalesOrderSno"), xRow)
     If  getColumnIndex(spr,"Remark") > -1 then z3428.Remark = getDataM(spr, getColumnIndex(spr,"Remark"), xRow)
     If  getColumnIndex(spr,"seSite") > -1 then z3428.seSite = getDataM(spr, getColumnIndex(spr,"seSite"), xRow)
     If  getColumnIndex(spr,"cdSite") > -1 then z3428.cdSite = getDataM(spr, getColumnIndex(spr,"cdSite"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K3428_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K3428_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z3428 As T3428_AREA,CheckClear as Boolean,PAYABLENO AS String) as Boolean

K3428_MOVE = False

Try
    If READ_PFK3428(PAYABLENO) = True Then
                z3428 = D3428
		K3428_MOVE = True
		else
	If CheckClear  = True then z3428 = nothing
     End If

     If  getColumnIndex(spr,"PayableNo") > -1 then z3428.PayableNo = getDataM(spr, getColumnIndex(spr,"PayableNo"), xRow)
     If  getColumnIndex(spr,"seSeason") > -1 then z3428.seSeason = getDataM(spr, getColumnIndex(spr,"seSeason"), xRow)
     If  getColumnIndex(spr,"cdSeason") > -1 then z3428.cdSeason = getDataM(spr, getColumnIndex(spr,"cdSeason"), xRow)
     If  getColumnIndex(spr,"CustomerCode") > -1 then z3428.CustomerCode = getDataM(spr, getColumnIndex(spr,"CustomerCode"), xRow)
     If  getColumnIndex(spr,"DateAccept") > -1 then z3428.DateAccept = getDataM(spr, getColumnIndex(spr,"DateAccept"), xRow)
     If  getColumnIndex(spr,"CheckInPurchasingOrder") > -1 then z3428.CheckInPurchasingOrder = getDataM(spr, getColumnIndex(spr,"CheckInPurchasingOrder"), xRow)
     If  getColumnIndex(spr,"CheckOutPurchasingOrder") > -1 then z3428.CheckOutPurchasingOrder = getDataM(spr, getColumnIndex(spr,"CheckOutPurchasingOrder"), xRow)
     If  getColumnIndex(spr,"CheckProcessType") > -1 then z3428.CheckProcessType = getDataM(spr, getColumnIndex(spr,"CheckProcessType"), xRow)
     If  getColumnIndex(spr,"CheckIOType") > -1 then z3428.CheckIOType = getDataM(spr, getColumnIndex(spr,"CheckIOType"), xRow)
     If  getColumnIndex(spr,"CheckMaterialType") > -1 then z3428.CheckMaterialType = getDataM(spr, getColumnIndex(spr,"CheckMaterialType"), xRow)
     If  getColumnIndex(spr,"CheckMarketType") > -1 then z3428.CheckMarketType = getDataM(spr, getColumnIndex(spr,"CheckMarketType"), xRow)
     If  getColumnIndex(spr,"CheckRelationType") > -1 then z3428.CheckRelationType = getDataM(spr, getColumnIndex(spr,"CheckRelationType"), xRow)
     If  getColumnIndex(spr,"SupplierCode") > -1 then z3428.SupplierCode = getDataM(spr, getColumnIndex(spr,"SupplierCode"), xRow)
     If  getColumnIndex(spr,"selUnitPrice") > -1 then z3428.selUnitPrice = getDataM(spr, getColumnIndex(spr,"selUnitPrice"), xRow)
     If  getColumnIndex(spr,"cdUnitPrice") > -1 then z3428.cdUnitPrice = getDataM(spr, getColumnIndex(spr,"cdUnitPrice"), xRow)
     If  getColumnIndex(spr,"PriceExchange") > -1 then z3428.PriceExchange = Cdecp(getDataM(spr, getColumnIndex(spr,"PriceExchange"), xRow))
     If  getColumnIndex(spr,"DateExchange") > -1 then z3428.DateExchange = getDataM(spr, getColumnIndex(spr,"DateExchange"), xRow)
     If  getColumnIndex(spr,"seOrigin") > -1 then z3428.seOrigin = getDataM(spr, getColumnIndex(spr,"seOrigin"), xRow)
     If  getColumnIndex(spr,"cdOrigin") > -1 then z3428.cdOrigin = getDataM(spr, getColumnIndex(spr,"cdOrigin"), xRow)
     If  getColumnIndex(spr,"seDepartment") > -1 then z3428.seDepartment = getDataM(spr, getColumnIndex(spr,"seDepartment"), xRow)
     If  getColumnIndex(spr,"cdDepartment") > -1 then z3428.cdDepartment = getDataM(spr, getColumnIndex(spr,"cdDepartment"), xRow)
     If  getColumnIndex(spr,"seCommercialTerm") > -1 then z3428.seCommercialTerm = getDataM(spr, getColumnIndex(spr,"seCommercialTerm"), xRow)
     If  getColumnIndex(spr,"cdCommercialTerm") > -1 then z3428.cdCommercialTerm = getDataM(spr, getColumnIndex(spr,"cdCommercialTerm"), xRow)
     If  getColumnIndex(spr,"seDeliveryTerm") > -1 then z3428.seDeliveryTerm = getDataM(spr, getColumnIndex(spr,"seDeliveryTerm"), xRow)
     If  getColumnIndex(spr,"cdDeliveryTerm") > -1 then z3428.cdDeliveryTerm = getDataM(spr, getColumnIndex(spr,"cdDeliveryTerm"), xRow)
     If  getColumnIndex(spr,"sePaymentTerm") > -1 then z3428.sePaymentTerm = getDataM(spr, getColumnIndex(spr,"sePaymentTerm"), xRow)
     If  getColumnIndex(spr,"cdPaymentTerm") > -1 then z3428.cdPaymentTerm = getDataM(spr, getColumnIndex(spr,"cdPaymentTerm"), xRow)
     If  getColumnIndex(spr,"sePaymentCondition") > -1 then z3428.sePaymentCondition = getDataM(spr, getColumnIndex(spr,"sePaymentCondition"), xRow)
     If  getColumnIndex(spr,"cdPaymentCondition") > -1 then z3428.cdPaymentCondition = getDataM(spr, getColumnIndex(spr,"cdPaymentCondition"), xRow)
     If  getColumnIndex(spr,"sePaymentTime") > -1 then z3428.sePaymentTime = getDataM(spr, getColumnIndex(spr,"sePaymentTime"), xRow)
     If  getColumnIndex(spr,"cdPaymentTime") > -1 then z3428.cdPaymentTime = getDataM(spr, getColumnIndex(spr,"cdPaymentTime"), xRow)
     If  getColumnIndex(spr,"sePaymentDay") > -1 then z3428.sePaymentDay = getDataM(spr, getColumnIndex(spr,"sePaymentDay"), xRow)
     If  getColumnIndex(spr,"cdPaymentDay") > -1 then z3428.cdPaymentDay = getDataM(spr, getColumnIndex(spr,"cdPaymentDay"), xRow)
     If  getColumnIndex(spr,"seBuyingType") > -1 then z3428.seBuyingType = getDataM(spr, getColumnIndex(spr,"seBuyingType"), xRow)
     If  getColumnIndex(spr,"cdBuyingType") > -1 then z3428.cdBuyingType = getDataM(spr, getColumnIndex(spr,"cdBuyingType"), xRow)
     If  getColumnIndex(spr,"TypeDiscount") > -1 then z3428.TypeDiscount = getDataM(spr, getColumnIndex(spr,"TypeDiscount"), xRow)
     If  getColumnIndex(spr,"PerDiscount") > -1 then z3428.PerDiscount = Cdecp(getDataM(spr, getColumnIndex(spr,"PerDiscount"), xRow))
     If  getColumnIndex(spr,"AmtDiscount") > -1 then z3428.AmtDiscount = Cdecp(getDataM(spr, getColumnIndex(spr,"AmtDiscount"), xRow))
     If  getColumnIndex(spr,"QualityRequest") > -1 then z3428.QualityRequest = getDataM(spr, getColumnIndex(spr,"QualityRequest"), xRow)
     If  getColumnIndex(spr,"ContractNo") > -1 then z3428.ContractNo = getDataM(spr, getColumnIndex(spr,"ContractNo"), xRow)
     If  getColumnIndex(spr,"Tolerance") > -1 then z3428.Tolerance = getDataM(spr, getColumnIndex(spr,"Tolerance"), xRow)
     If  getColumnIndex(spr,"Destination") > -1 then z3428.Destination = getDataM(spr, getColumnIndex(spr,"Destination"), xRow)
     If  getColumnIndex(spr,"InchargePurchasing") > -1 then z3428.InchargePurchasing = getDataM(spr, getColumnIndex(spr,"InchargePurchasing"), xRow)
     If  getColumnIndex(spr,"AmountPurchasingEX") > -1 then z3428.AmountPurchasingEX = Cdecp(getDataM(spr, getColumnIndex(spr,"AmountPurchasingEX"), xRow))
     If  getColumnIndex(spr,"AmountPurchasingVND") > -1 then z3428.AmountPurchasingVND = Cdecp(getDataM(spr, getColumnIndex(spr,"AmountPurchasingVND"), xRow))
     If  getColumnIndex(spr,"AmountTaxEX") > -1 then z3428.AmountTaxEX = Cdecp(getDataM(spr, getColumnIndex(spr,"AmountTaxEX"), xRow))
     If  getColumnIndex(spr,"AmountTaxVND") > -1 then z3428.AmountTaxVND = Cdecp(getDataM(spr, getColumnIndex(spr,"AmountTaxVND"), xRow))
     If  getColumnIndex(spr,"AmountExpenseEX") > -1 then z3428.AmountExpenseEX = Cdecp(getDataM(spr, getColumnIndex(spr,"AmountExpenseEX"), xRow))
     If  getColumnIndex(spr,"AmountExpenseUSD") > -1 then z3428.AmountExpenseUSD = Cdecp(getDataM(spr, getColumnIndex(spr,"AmountExpenseUSD"), xRow))
     If  getColumnIndex(spr,"AmountExpenseVND") > -1 then z3428.AmountExpenseVND = Cdecp(getDataM(spr, getColumnIndex(spr,"AmountExpenseVND"), xRow))
     If  getColumnIndex(spr,"DateStart") > -1 then z3428.DateStart = getDataM(spr, getColumnIndex(spr,"DateStart"), xRow)
     If  getColumnIndex(spr,"DateEstimate") > -1 then z3428.DateEstimate = getDataM(spr, getColumnIndex(spr,"DateEstimate"), xRow)
     If  getColumnIndex(spr,"DateDelivery") > -1 then z3428.DateDelivery = getDataM(spr, getColumnIndex(spr,"DateDelivery"), xRow)
     If  getColumnIndex(spr,"DateInsert") > -1 then z3428.DateInsert = getDataM(spr, getColumnIndex(spr,"DateInsert"), xRow)
     If  getColumnIndex(spr,"DateUpdate") > -1 then z3428.DateUpdate = getDataM(spr, getColumnIndex(spr,"DateUpdate"), xRow)
     If  getColumnIndex(spr,"InchargeInsert") > -1 then z3428.InchargeInsert = getDataM(spr, getColumnIndex(spr,"InchargeInsert"), xRow)
     If  getColumnIndex(spr,"InchargeUpdate") > -1 then z3428.InchargeUpdate = getDataM(spr, getColumnIndex(spr,"InchargeUpdate"), xRow)
     If  getColumnIndex(spr,"TimeInsert") > -1 then z3428.TimeInsert = getDataM(spr, getColumnIndex(spr,"TimeInsert"), xRow)
     If  getColumnIndex(spr,"TimeUpdate") > -1 then z3428.TimeUpdate = getDataM(spr, getColumnIndex(spr,"TimeUpdate"), xRow)
     If  getColumnIndex(spr,"CheckComplete") > -1 then z3428.CheckComplete = getDataM(spr, getColumnIndex(spr,"CheckComplete"), xRow)
     If  getColumnIndex(spr,"InchargeSync") > -1 then z3428.InchargeSync = getDataM(spr, getColumnIndex(spr,"InchargeSync"), xRow)
     If  getColumnIndex(spr,"DateSync") > -1 then z3428.DateSync = getDataM(spr, getColumnIndex(spr,"DateSync"), xRow)
     If  getColumnIndex(spr,"CheckSync") > -1 then z3428.CheckSync = getDataM(spr, getColumnIndex(spr,"CheckSync"), xRow)
     If  getColumnIndex(spr,"PurchasingOrderNo") > -1 then z3428.PurchasingOrderNo = getDataM(spr, getColumnIndex(spr,"PurchasingOrderNo"), xRow)
     If  getColumnIndex(spr,"SalesOrderNo") > -1 then z3428.SalesOrderNo = getDataM(spr, getColumnIndex(spr,"SalesOrderNo"), xRow)
     If  getColumnIndex(spr,"SalesOrderSeq") > -1 then z3428.SalesOrderSeq = getDataM(spr, getColumnIndex(spr,"SalesOrderSeq"), xRow)
     If  getColumnIndex(spr,"SalesOrderSno") > -1 then z3428.SalesOrderSno = getDataM(spr, getColumnIndex(spr,"SalesOrderSno"), xRow)
     If  getColumnIndex(spr,"Remark") > -1 then z3428.Remark = getDataM(spr, getColumnIndex(spr,"Remark"), xRow)
     If  getColumnIndex(spr,"seSite") > -1 then z3428.seSite = getDataM(spr, getColumnIndex(spr,"seSite"), xRow)
     If  getColumnIndex(spr,"cdSite") > -1 then z3428.cdSite = getDataM(spr, getColumnIndex(spr,"cdSite"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K3428_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K3428_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z3428 As T3428_AREA, Job as String, PAYABLENO AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K3428_MOVE = False

Try
    If READ_PFK3428(PAYABLENO) = True Then
                z3428 = D3428
		K3428_MOVE = True
		else
	z3428 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3428")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "PAYABLENO":z3428.PayableNo = Children(i).Code
   Case "SESEASON":z3428.seSeason = Children(i).Code
   Case "CDSEASON":z3428.cdSeason = Children(i).Code
   Case "CUSTOMERCODE":z3428.CustomerCode = Children(i).Code
   Case "DATEACCEPT":z3428.DateAccept = Children(i).Code
   Case "CHECKINPURCHASINGORDER":z3428.CheckInPurchasingOrder = Children(i).Code
   Case "CHECKOUTPURCHASINGORDER":z3428.CheckOutPurchasingOrder = Children(i).Code
   Case "CHECKPROCESSTYPE":z3428.CheckProcessType = Children(i).Code
   Case "CHECKIOTYPE":z3428.CheckIOType = Children(i).Code
   Case "CHECKMATERIALTYPE":z3428.CheckMaterialType = Children(i).Code
   Case "CHECKMARKETTYPE":z3428.CheckMarketType = Children(i).Code
   Case "CHECKRELATIONTYPE":z3428.CheckRelationType = Children(i).Code
   Case "SUPPLIERCODE":z3428.SupplierCode = Children(i).Code
   Case "SELUNITPRICE":z3428.selUnitPrice = Children(i).Code
   Case "CDUNITPRICE":z3428.cdUnitPrice = Children(i).Code
   Case "PRICEEXCHANGE":z3428.PriceExchange = Children(i).Code
   Case "DATEEXCHANGE":z3428.DateExchange = Children(i).Code
   Case "SEORIGIN":z3428.seOrigin = Children(i).Code
   Case "CDORIGIN":z3428.cdOrigin = Children(i).Code
   Case "SEDEPARTMENT":z3428.seDepartment = Children(i).Code
   Case "CDDEPARTMENT":z3428.cdDepartment = Children(i).Code
   Case "SECOMMERCIALTERM":z3428.seCommercialTerm = Children(i).Code
   Case "CDCOMMERCIALTERM":z3428.cdCommercialTerm = Children(i).Code
   Case "SEDELIVERYTERM":z3428.seDeliveryTerm = Children(i).Code
   Case "CDDELIVERYTERM":z3428.cdDeliveryTerm = Children(i).Code
   Case "SEPAYMENTTERM":z3428.sePaymentTerm = Children(i).Code
   Case "CDPAYMENTTERM":z3428.cdPaymentTerm = Children(i).Code
   Case "SEPAYMENTCONDITION":z3428.sePaymentCondition = Children(i).Code
   Case "CDPAYMENTCONDITION":z3428.cdPaymentCondition = Children(i).Code
   Case "SEPAYMENTTIME":z3428.sePaymentTime = Children(i).Code
   Case "CDPAYMENTTIME":z3428.cdPaymentTime = Children(i).Code
   Case "SEPAYMENTDAY":z3428.sePaymentDay = Children(i).Code
   Case "CDPAYMENTDAY":z3428.cdPaymentDay = Children(i).Code
   Case "SEBUYINGTYPE":z3428.seBuyingType = Children(i).Code
   Case "CDBUYINGTYPE":z3428.cdBuyingType = Children(i).Code
   Case "TYPEDISCOUNT":z3428.TypeDiscount = Children(i).Code
   Case "PERDISCOUNT":z3428.PerDiscount = Children(i).Code
   Case "AMTDISCOUNT":z3428.AmtDiscount = Children(i).Code
   Case "QUALITYREQUEST":z3428.QualityRequest = Children(i).Code
   Case "CONTRACTNO":z3428.ContractNo = Children(i).Code
   Case "TOLERANCE":z3428.Tolerance = Children(i).Code
   Case "DESTINATION":z3428.Destination = Children(i).Code
   Case "INCHARGEPURCHASING":z3428.InchargePurchasing = Children(i).Code
   Case "AMOUNTPURCHASINGEX":z3428.AmountPurchasingEX = Children(i).Code
   Case "AMOUNTPURCHASINGVND":z3428.AmountPurchasingVND = Children(i).Code
   Case "AMOUNTTAXEX":z3428.AmountTaxEX = Children(i).Code
   Case "AMOUNTTAXVND":z3428.AmountTaxVND = Children(i).Code
   Case "AMOUNTEXPENSEEX":z3428.AmountExpenseEX = Children(i).Code
   Case "AMOUNTEXPENSEUSD":z3428.AmountExpenseUSD = Children(i).Code
   Case "AMOUNTEXPENSEVND":z3428.AmountExpenseVND = Children(i).Code
   Case "DATESTART":z3428.DateStart = Children(i).Code
   Case "DATEESTIMATE":z3428.DateEstimate = Children(i).Code
   Case "DATEDELIVERY":z3428.DateDelivery = Children(i).Code
   Case "DATEINSERT":z3428.DateInsert = Children(i).Code
   Case "DATEUPDATE":z3428.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z3428.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z3428.InchargeUpdate = Children(i).Code
   Case "TIMEINSERT":z3428.TimeInsert = Children(i).Code
   Case "TIMEUPDATE":z3428.TimeUpdate = Children(i).Code
   Case "CHECKCOMPLETE":z3428.CheckComplete = Children(i).Code
   Case "INCHARGESYNC":z3428.InchargeSync = Children(i).Code
   Case "DATESYNC":z3428.DateSync = Children(i).Code
   Case "CHECKSYNC":z3428.CheckSync = Children(i).Code
   Case "PURCHASINGORDERNO":z3428.PurchasingOrderNo = Children(i).Code
   Case "SALESORDERNO":z3428.SalesOrderNo = Children(i).Code
   Case "SALESORDERSEQ":z3428.SalesOrderSeq = Children(i).Code
   Case "SALESORDERSNO":z3428.SalesOrderSno = Children(i).Code
   Case "REMARK":z3428.Remark = Children(i).Code
   Case "SESITE":z3428.seSite = Children(i).Code
   Case "CDSITE":z3428.cdSite = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "PAYABLENO":z3428.PayableNo = Children(i).Data
   Case "SESEASON":z3428.seSeason = Children(i).Data
   Case "CDSEASON":z3428.cdSeason = Children(i).Data
   Case "CUSTOMERCODE":z3428.CustomerCode = Children(i).Data
   Case "DATEACCEPT":z3428.DateAccept = Children(i).Data
   Case "CHECKINPURCHASINGORDER":z3428.CheckInPurchasingOrder = Children(i).Data
   Case "CHECKOUTPURCHASINGORDER":z3428.CheckOutPurchasingOrder = Children(i).Data
   Case "CHECKPROCESSTYPE":z3428.CheckProcessType = Children(i).Data
   Case "CHECKIOTYPE":z3428.CheckIOType = Children(i).Data
   Case "CHECKMATERIALTYPE":z3428.CheckMaterialType = Children(i).Data
   Case "CHECKMARKETTYPE":z3428.CheckMarketType = Children(i).Data
   Case "CHECKRELATIONTYPE":z3428.CheckRelationType = Children(i).Data
   Case "SUPPLIERCODE":z3428.SupplierCode = Children(i).Data
   Case "SELUNITPRICE":z3428.selUnitPrice = Children(i).Data
   Case "CDUNITPRICE":z3428.cdUnitPrice = Children(i).Data
   Case "PRICEEXCHANGE":z3428.PriceExchange = Cdecp(Children(i).Data)
   Case "DATEEXCHANGE":z3428.DateExchange = Children(i).Data
   Case "SEORIGIN":z3428.seOrigin = Children(i).Data
   Case "CDORIGIN":z3428.cdOrigin = Children(i).Data
   Case "SEDEPARTMENT":z3428.seDepartment = Children(i).Data
   Case "CDDEPARTMENT":z3428.cdDepartment = Children(i).Data
   Case "SECOMMERCIALTERM":z3428.seCommercialTerm = Children(i).Data
   Case "CDCOMMERCIALTERM":z3428.cdCommercialTerm = Children(i).Data
   Case "SEDELIVERYTERM":z3428.seDeliveryTerm = Children(i).Data
   Case "CDDELIVERYTERM":z3428.cdDeliveryTerm = Children(i).Data
   Case "SEPAYMENTTERM":z3428.sePaymentTerm = Children(i).Data
   Case "CDPAYMENTTERM":z3428.cdPaymentTerm = Children(i).Data
   Case "SEPAYMENTCONDITION":z3428.sePaymentCondition = Children(i).Data
   Case "CDPAYMENTCONDITION":z3428.cdPaymentCondition = Children(i).Data
   Case "SEPAYMENTTIME":z3428.sePaymentTime = Children(i).Data
   Case "CDPAYMENTTIME":z3428.cdPaymentTime = Children(i).Data
   Case "SEPAYMENTDAY":z3428.sePaymentDay = Children(i).Data
   Case "CDPAYMENTDAY":z3428.cdPaymentDay = Children(i).Data
   Case "SEBUYINGTYPE":z3428.seBuyingType = Children(i).Data
   Case "CDBUYINGTYPE":z3428.cdBuyingType = Children(i).Data
   Case "TYPEDISCOUNT":z3428.TypeDiscount = Children(i).Data
   Case "PERDISCOUNT":z3428.PerDiscount = Cdecp(Children(i).Data)
   Case "AMTDISCOUNT":z3428.AmtDiscount = Cdecp(Children(i).Data)
   Case "QUALITYREQUEST":z3428.QualityRequest = Children(i).Data
   Case "CONTRACTNO":z3428.ContractNo = Children(i).Data
   Case "TOLERANCE":z3428.Tolerance = Children(i).Data
   Case "DESTINATION":z3428.Destination = Children(i).Data
   Case "INCHARGEPURCHASING":z3428.InchargePurchasing = Children(i).Data
   Case "AMOUNTPURCHASINGEX":z3428.AmountPurchasingEX = Cdecp(Children(i).Data)
   Case "AMOUNTPURCHASINGVND":z3428.AmountPurchasingVND = Cdecp(Children(i).Data)
   Case "AMOUNTTAXEX":z3428.AmountTaxEX = Cdecp(Children(i).Data)
   Case "AMOUNTTAXVND":z3428.AmountTaxVND = Cdecp(Children(i).Data)
   Case "AMOUNTEXPENSEEX":z3428.AmountExpenseEX = Cdecp(Children(i).Data)
   Case "AMOUNTEXPENSEUSD":z3428.AmountExpenseUSD = Cdecp(Children(i).Data)
   Case "AMOUNTEXPENSEVND":z3428.AmountExpenseVND = Cdecp(Children(i).Data)
   Case "DATESTART":z3428.DateStart = Children(i).Data
   Case "DATEESTIMATE":z3428.DateEstimate = Children(i).Data
   Case "DATEDELIVERY":z3428.DateDelivery = Children(i).Data
   Case "DATEINSERT":z3428.DateInsert = Children(i).Data
   Case "DATEUPDATE":z3428.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z3428.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z3428.InchargeUpdate = Children(i).Data
   Case "TIMEINSERT":z3428.TimeInsert = Children(i).Data
   Case "TIMEUPDATE":z3428.TimeUpdate = Children(i).Data
   Case "CHECKCOMPLETE":z3428.CheckComplete = Children(i).Data
   Case "INCHARGESYNC":z3428.InchargeSync = Children(i).Data
   Case "DATESYNC":z3428.DateSync = Children(i).Data
   Case "CHECKSYNC":z3428.CheckSync = Children(i).Data
   Case "PURCHASINGORDERNO":z3428.PurchasingOrderNo = Children(i).Data
   Case "SALESORDERNO":z3428.SalesOrderNo = Children(i).Data
   Case "SALESORDERSEQ":z3428.SalesOrderSeq = Children(i).Data
   Case "SALESORDERSNO":z3428.SalesOrderSno = Children(i).Data
   Case "REMARK":z3428.Remark = Children(i).Data
   Case "SESITE":z3428.seSite = Children(i).Data
   Case "CDSITE":z3428.cdSite = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K3428_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K3428_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z3428 As T3428_AREA, Job as String, CheckClear as Boolean, PAYABLENO AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K3428_MOVE = False

Try
    If READ_PFK3428(PAYABLENO) = True Then
                z3428 = D3428
		K3428_MOVE = True
		else
	If CheckClear  = True then z3428 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3428")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "PAYABLENO":z3428.PayableNo = Children(i).Code
   Case "SESEASON":z3428.seSeason = Children(i).Code
   Case "CDSEASON":z3428.cdSeason = Children(i).Code
   Case "CUSTOMERCODE":z3428.CustomerCode = Children(i).Code
   Case "DATEACCEPT":z3428.DateAccept = Children(i).Code
   Case "CHECKINPURCHASINGORDER":z3428.CheckInPurchasingOrder = Children(i).Code
   Case "CHECKOUTPURCHASINGORDER":z3428.CheckOutPurchasingOrder = Children(i).Code
   Case "CHECKPROCESSTYPE":z3428.CheckProcessType = Children(i).Code
   Case "CHECKIOTYPE":z3428.CheckIOType = Children(i).Code
   Case "CHECKMATERIALTYPE":z3428.CheckMaterialType = Children(i).Code
   Case "CHECKMARKETTYPE":z3428.CheckMarketType = Children(i).Code
   Case "CHECKRELATIONTYPE":z3428.CheckRelationType = Children(i).Code
   Case "SUPPLIERCODE":z3428.SupplierCode = Children(i).Code
   Case "SELUNITPRICE":z3428.selUnitPrice = Children(i).Code
   Case "CDUNITPRICE":z3428.cdUnitPrice = Children(i).Code
   Case "PRICEEXCHANGE":z3428.PriceExchange = Children(i).Code
   Case "DATEEXCHANGE":z3428.DateExchange = Children(i).Code
   Case "SEORIGIN":z3428.seOrigin = Children(i).Code
   Case "CDORIGIN":z3428.cdOrigin = Children(i).Code
   Case "SEDEPARTMENT":z3428.seDepartment = Children(i).Code
   Case "CDDEPARTMENT":z3428.cdDepartment = Children(i).Code
   Case "SECOMMERCIALTERM":z3428.seCommercialTerm = Children(i).Code
   Case "CDCOMMERCIALTERM":z3428.cdCommercialTerm = Children(i).Code
   Case "SEDELIVERYTERM":z3428.seDeliveryTerm = Children(i).Code
   Case "CDDELIVERYTERM":z3428.cdDeliveryTerm = Children(i).Code
   Case "SEPAYMENTTERM":z3428.sePaymentTerm = Children(i).Code
   Case "CDPAYMENTTERM":z3428.cdPaymentTerm = Children(i).Code
   Case "SEPAYMENTCONDITION":z3428.sePaymentCondition = Children(i).Code
   Case "CDPAYMENTCONDITION":z3428.cdPaymentCondition = Children(i).Code
   Case "SEPAYMENTTIME":z3428.sePaymentTime = Children(i).Code
   Case "CDPAYMENTTIME":z3428.cdPaymentTime = Children(i).Code
   Case "SEPAYMENTDAY":z3428.sePaymentDay = Children(i).Code
   Case "CDPAYMENTDAY":z3428.cdPaymentDay = Children(i).Code
   Case "SEBUYINGTYPE":z3428.seBuyingType = Children(i).Code
   Case "CDBUYINGTYPE":z3428.cdBuyingType = Children(i).Code
   Case "TYPEDISCOUNT":z3428.TypeDiscount = Children(i).Code
   Case "PERDISCOUNT":z3428.PerDiscount = Children(i).Code
   Case "AMTDISCOUNT":z3428.AmtDiscount = Children(i).Code
   Case "QUALITYREQUEST":z3428.QualityRequest = Children(i).Code
   Case "CONTRACTNO":z3428.ContractNo = Children(i).Code
   Case "TOLERANCE":z3428.Tolerance = Children(i).Code
   Case "DESTINATION":z3428.Destination = Children(i).Code
   Case "INCHARGEPURCHASING":z3428.InchargePurchasing = Children(i).Code
   Case "AMOUNTPURCHASINGEX":z3428.AmountPurchasingEX = Children(i).Code
   Case "AMOUNTPURCHASINGVND":z3428.AmountPurchasingVND = Children(i).Code
   Case "AMOUNTTAXEX":z3428.AmountTaxEX = Children(i).Code
   Case "AMOUNTTAXVND":z3428.AmountTaxVND = Children(i).Code
   Case "AMOUNTEXPENSEEX":z3428.AmountExpenseEX = Children(i).Code
   Case "AMOUNTEXPENSEUSD":z3428.AmountExpenseUSD = Children(i).Code
   Case "AMOUNTEXPENSEVND":z3428.AmountExpenseVND = Children(i).Code
   Case "DATESTART":z3428.DateStart = Children(i).Code
   Case "DATEESTIMATE":z3428.DateEstimate = Children(i).Code
   Case "DATEDELIVERY":z3428.DateDelivery = Children(i).Code
   Case "DATEINSERT":z3428.DateInsert = Children(i).Code
   Case "DATEUPDATE":z3428.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z3428.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z3428.InchargeUpdate = Children(i).Code
   Case "TIMEINSERT":z3428.TimeInsert = Children(i).Code
   Case "TIMEUPDATE":z3428.TimeUpdate = Children(i).Code
   Case "CHECKCOMPLETE":z3428.CheckComplete = Children(i).Code
   Case "INCHARGESYNC":z3428.InchargeSync = Children(i).Code
   Case "DATESYNC":z3428.DateSync = Children(i).Code
   Case "CHECKSYNC":z3428.CheckSync = Children(i).Code
   Case "PURCHASINGORDERNO":z3428.PurchasingOrderNo = Children(i).Code
   Case "SALESORDERNO":z3428.SalesOrderNo = Children(i).Code
   Case "SALESORDERSEQ":z3428.SalesOrderSeq = Children(i).Code
   Case "SALESORDERSNO":z3428.SalesOrderSno = Children(i).Code
   Case "REMARK":z3428.Remark = Children(i).Code
   Case "SESITE":z3428.seSite = Children(i).Code
   Case "CDSITE":z3428.cdSite = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "PAYABLENO":z3428.PayableNo = Children(i).Data
   Case "SESEASON":z3428.seSeason = Children(i).Data
   Case "CDSEASON":z3428.cdSeason = Children(i).Data
   Case "CUSTOMERCODE":z3428.CustomerCode = Children(i).Data
   Case "DATEACCEPT":z3428.DateAccept = Children(i).Data
   Case "CHECKINPURCHASINGORDER":z3428.CheckInPurchasingOrder = Children(i).Data
   Case "CHECKOUTPURCHASINGORDER":z3428.CheckOutPurchasingOrder = Children(i).Data
   Case "CHECKPROCESSTYPE":z3428.CheckProcessType = Children(i).Data
   Case "CHECKIOTYPE":z3428.CheckIOType = Children(i).Data
   Case "CHECKMATERIALTYPE":z3428.CheckMaterialType = Children(i).Data
   Case "CHECKMARKETTYPE":z3428.CheckMarketType = Children(i).Data
   Case "CHECKRELATIONTYPE":z3428.CheckRelationType = Children(i).Data
   Case "SUPPLIERCODE":z3428.SupplierCode = Children(i).Data
   Case "SELUNITPRICE":z3428.selUnitPrice = Children(i).Data
   Case "CDUNITPRICE":z3428.cdUnitPrice = Children(i).Data
   Case "PRICEEXCHANGE":z3428.PriceExchange = Cdecp(Children(i).Data)
   Case "DATEEXCHANGE":z3428.DateExchange = Children(i).Data
   Case "SEORIGIN":z3428.seOrigin = Children(i).Data
   Case "CDORIGIN":z3428.cdOrigin = Children(i).Data
   Case "SEDEPARTMENT":z3428.seDepartment = Children(i).Data
   Case "CDDEPARTMENT":z3428.cdDepartment = Children(i).Data
   Case "SECOMMERCIALTERM":z3428.seCommercialTerm = Children(i).Data
   Case "CDCOMMERCIALTERM":z3428.cdCommercialTerm = Children(i).Data
   Case "SEDELIVERYTERM":z3428.seDeliveryTerm = Children(i).Data
   Case "CDDELIVERYTERM":z3428.cdDeliveryTerm = Children(i).Data
   Case "SEPAYMENTTERM":z3428.sePaymentTerm = Children(i).Data
   Case "CDPAYMENTTERM":z3428.cdPaymentTerm = Children(i).Data
   Case "SEPAYMENTCONDITION":z3428.sePaymentCondition = Children(i).Data
   Case "CDPAYMENTCONDITION":z3428.cdPaymentCondition = Children(i).Data
   Case "SEPAYMENTTIME":z3428.sePaymentTime = Children(i).Data
   Case "CDPAYMENTTIME":z3428.cdPaymentTime = Children(i).Data
   Case "SEPAYMENTDAY":z3428.sePaymentDay = Children(i).Data
   Case "CDPAYMENTDAY":z3428.cdPaymentDay = Children(i).Data
   Case "SEBUYINGTYPE":z3428.seBuyingType = Children(i).Data
   Case "CDBUYINGTYPE":z3428.cdBuyingType = Children(i).Data
   Case "TYPEDISCOUNT":z3428.TypeDiscount = Children(i).Data
   Case "PERDISCOUNT":z3428.PerDiscount = Cdecp(Children(i).Data)
   Case "AMTDISCOUNT":z3428.AmtDiscount = Cdecp(Children(i).Data)
   Case "QUALITYREQUEST":z3428.QualityRequest = Children(i).Data
   Case "CONTRACTNO":z3428.ContractNo = Children(i).Data
   Case "TOLERANCE":z3428.Tolerance = Children(i).Data
   Case "DESTINATION":z3428.Destination = Children(i).Data
   Case "INCHARGEPURCHASING":z3428.InchargePurchasing = Children(i).Data
   Case "AMOUNTPURCHASINGEX":z3428.AmountPurchasingEX = Cdecp(Children(i).Data)
   Case "AMOUNTPURCHASINGVND":z3428.AmountPurchasingVND = Cdecp(Children(i).Data)
   Case "AMOUNTTAXEX":z3428.AmountTaxEX = Cdecp(Children(i).Data)
   Case "AMOUNTTAXVND":z3428.AmountTaxVND = Cdecp(Children(i).Data)
   Case "AMOUNTEXPENSEEX":z3428.AmountExpenseEX = Cdecp(Children(i).Data)
   Case "AMOUNTEXPENSEUSD":z3428.AmountExpenseUSD = Cdecp(Children(i).Data)
   Case "AMOUNTEXPENSEVND":z3428.AmountExpenseVND = Cdecp(Children(i).Data)
   Case "DATESTART":z3428.DateStart = Children(i).Data
   Case "DATEESTIMATE":z3428.DateEstimate = Children(i).Data
   Case "DATEDELIVERY":z3428.DateDelivery = Children(i).Data
   Case "DATEINSERT":z3428.DateInsert = Children(i).Data
   Case "DATEUPDATE":z3428.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z3428.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z3428.InchargeUpdate = Children(i).Data
   Case "TIMEINSERT":z3428.TimeInsert = Children(i).Data
   Case "TIMEUPDATE":z3428.TimeUpdate = Children(i).Data
   Case "CHECKCOMPLETE":z3428.CheckComplete = Children(i).Data
   Case "INCHARGESYNC":z3428.InchargeSync = Children(i).Data
   Case "DATESYNC":z3428.DateSync = Children(i).Data
   Case "CHECKSYNC":z3428.CheckSync = Children(i).Data
   Case "PURCHASINGORDERNO":z3428.PurchasingOrderNo = Children(i).Data
   Case "SALESORDERNO":z3428.SalesOrderNo = Children(i).Data
   Case "SALESORDERSEQ":z3428.SalesOrderSeq = Children(i).Data
   Case "SALESORDERSNO":z3428.SalesOrderSno = Children(i).Data
   Case "REMARK":z3428.Remark = Children(i).Data
   Case "SESITE":z3428.seSite = Children(i).Data
   Case "CDSITE":z3428.cdSite = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K3428_MOVE",vbCritical)
End Try
End Function 
    

'=========================================================================================================================================================
' DATA MOVE FORM NEW AREA
'=========================================================================================================================================================
Public Sub K3428_MOVE(ByRef a3428 As T3428_AREA, ByRef b3428 As T3428_AREA) 
Try
If trim$( a3428.PayableNo ) = "" Then b3428.PayableNo = ""  Else b3428.PayableNo=a3428.PayableNo
If trim$( a3428.seSeason ) = "" Then b3428.seSeason = ""  Else b3428.seSeason=a3428.seSeason
If trim$( a3428.cdSeason ) = "" Then b3428.cdSeason = ""  Else b3428.cdSeason=a3428.cdSeason
If trim$( a3428.CustomerCode ) = "" Then b3428.CustomerCode = ""  Else b3428.CustomerCode=a3428.CustomerCode
If trim$( a3428.DateAccept ) = "" Then b3428.DateAccept = ""  Else b3428.DateAccept=a3428.DateAccept
If trim$( a3428.CheckInPurchasingOrder ) = "" Then b3428.CheckInPurchasingOrder = ""  Else b3428.CheckInPurchasingOrder=a3428.CheckInPurchasingOrder
If trim$( a3428.CheckOutPurchasingOrder ) = "" Then b3428.CheckOutPurchasingOrder = ""  Else b3428.CheckOutPurchasingOrder=a3428.CheckOutPurchasingOrder
If trim$( a3428.CheckProcessType ) = "" Then b3428.CheckProcessType = ""  Else b3428.CheckProcessType=a3428.CheckProcessType
If trim$( a3428.CheckIOType ) = "" Then b3428.CheckIOType = ""  Else b3428.CheckIOType=a3428.CheckIOType
If trim$( a3428.CheckMaterialType ) = "" Then b3428.CheckMaterialType = ""  Else b3428.CheckMaterialType=a3428.CheckMaterialType
If trim$( a3428.CheckMarketType ) = "" Then b3428.CheckMarketType = ""  Else b3428.CheckMarketType=a3428.CheckMarketType
If trim$( a3428.CheckRelationType ) = "" Then b3428.CheckRelationType = ""  Else b3428.CheckRelationType=a3428.CheckRelationType
If trim$( a3428.SupplierCode ) = "" Then b3428.SupplierCode = ""  Else b3428.SupplierCode=a3428.SupplierCode
If trim$( a3428.selUnitPrice ) = "" Then b3428.selUnitPrice = ""  Else b3428.selUnitPrice=a3428.selUnitPrice
If trim$( a3428.cdUnitPrice ) = "" Then b3428.cdUnitPrice = ""  Else b3428.cdUnitPrice=a3428.cdUnitPrice
If trim$( a3428.PriceExchange ) = "" Then b3428.PriceExchange = ""  Else b3428.PriceExchange=a3428.PriceExchange
If trim$( a3428.DateExchange ) = "" Then b3428.DateExchange = ""  Else b3428.DateExchange=a3428.DateExchange
If trim$( a3428.seOrigin ) = "" Then b3428.seOrigin = ""  Else b3428.seOrigin=a3428.seOrigin
If trim$( a3428.cdOrigin ) = "" Then b3428.cdOrigin = ""  Else b3428.cdOrigin=a3428.cdOrigin
If trim$( a3428.seDepartment ) = "" Then b3428.seDepartment = ""  Else b3428.seDepartment=a3428.seDepartment
If trim$( a3428.cdDepartment ) = "" Then b3428.cdDepartment = ""  Else b3428.cdDepartment=a3428.cdDepartment
If trim$( a3428.seCommercialTerm ) = "" Then b3428.seCommercialTerm = ""  Else b3428.seCommercialTerm=a3428.seCommercialTerm
If trim$( a3428.cdCommercialTerm ) = "" Then b3428.cdCommercialTerm = ""  Else b3428.cdCommercialTerm=a3428.cdCommercialTerm
If trim$( a3428.seDeliveryTerm ) = "" Then b3428.seDeliveryTerm = ""  Else b3428.seDeliveryTerm=a3428.seDeliveryTerm
If trim$( a3428.cdDeliveryTerm ) = "" Then b3428.cdDeliveryTerm = ""  Else b3428.cdDeliveryTerm=a3428.cdDeliveryTerm
If trim$( a3428.sePaymentTerm ) = "" Then b3428.sePaymentTerm = ""  Else b3428.sePaymentTerm=a3428.sePaymentTerm
If trim$( a3428.cdPaymentTerm ) = "" Then b3428.cdPaymentTerm = ""  Else b3428.cdPaymentTerm=a3428.cdPaymentTerm
If trim$( a3428.sePaymentCondition ) = "" Then b3428.sePaymentCondition = ""  Else b3428.sePaymentCondition=a3428.sePaymentCondition
If trim$( a3428.cdPaymentCondition ) = "" Then b3428.cdPaymentCondition = ""  Else b3428.cdPaymentCondition=a3428.cdPaymentCondition
If trim$( a3428.sePaymentTime ) = "" Then b3428.sePaymentTime = ""  Else b3428.sePaymentTime=a3428.sePaymentTime
If trim$( a3428.cdPaymentTime ) = "" Then b3428.cdPaymentTime = ""  Else b3428.cdPaymentTime=a3428.cdPaymentTime
If trim$( a3428.sePaymentDay ) = "" Then b3428.sePaymentDay = ""  Else b3428.sePaymentDay=a3428.sePaymentDay
If trim$( a3428.cdPaymentDay ) = "" Then b3428.cdPaymentDay = ""  Else b3428.cdPaymentDay=a3428.cdPaymentDay
If trim$( a3428.seBuyingType ) = "" Then b3428.seBuyingType = ""  Else b3428.seBuyingType=a3428.seBuyingType
If trim$( a3428.cdBuyingType ) = "" Then b3428.cdBuyingType = ""  Else b3428.cdBuyingType=a3428.cdBuyingType
If trim$( a3428.TypeDiscount ) = "" Then b3428.TypeDiscount = ""  Else b3428.TypeDiscount=a3428.TypeDiscount
If trim$( a3428.PerDiscount ) = "" Then b3428.PerDiscount = ""  Else b3428.PerDiscount=a3428.PerDiscount
If trim$( a3428.AmtDiscount ) = "" Then b3428.AmtDiscount = ""  Else b3428.AmtDiscount=a3428.AmtDiscount
If trim$( a3428.QualityRequest ) = "" Then b3428.QualityRequest = ""  Else b3428.QualityRequest=a3428.QualityRequest
If trim$( a3428.ContractNo ) = "" Then b3428.ContractNo = ""  Else b3428.ContractNo=a3428.ContractNo
If trim$( a3428.Tolerance ) = "" Then b3428.Tolerance = ""  Else b3428.Tolerance=a3428.Tolerance
If trim$( a3428.Destination ) = "" Then b3428.Destination = ""  Else b3428.Destination=a3428.Destination
If trim$( a3428.InchargePurchasing ) = "" Then b3428.InchargePurchasing = ""  Else b3428.InchargePurchasing=a3428.InchargePurchasing
If trim$( a3428.AmountPurchasingEX ) = "" Then b3428.AmountPurchasingEX = ""  Else b3428.AmountPurchasingEX=a3428.AmountPurchasingEX
If trim$( a3428.AmountPurchasingVND ) = "" Then b3428.AmountPurchasingVND = ""  Else b3428.AmountPurchasingVND=a3428.AmountPurchasingVND
If trim$( a3428.AmountTaxEX ) = "" Then b3428.AmountTaxEX = ""  Else b3428.AmountTaxEX=a3428.AmountTaxEX
If trim$( a3428.AmountTaxVND ) = "" Then b3428.AmountTaxVND = ""  Else b3428.AmountTaxVND=a3428.AmountTaxVND
If trim$( a3428.AmountExpenseEX ) = "" Then b3428.AmountExpenseEX = ""  Else b3428.AmountExpenseEX=a3428.AmountExpenseEX
If trim$( a3428.AmountExpenseUSD ) = "" Then b3428.AmountExpenseUSD = ""  Else b3428.AmountExpenseUSD=a3428.AmountExpenseUSD
If trim$( a3428.AmountExpenseVND ) = "" Then b3428.AmountExpenseVND = ""  Else b3428.AmountExpenseVND=a3428.AmountExpenseVND
If trim$( a3428.DateStart ) = "" Then b3428.DateStart = ""  Else b3428.DateStart=a3428.DateStart
If trim$( a3428.DateEstimate ) = "" Then b3428.DateEstimate = ""  Else b3428.DateEstimate=a3428.DateEstimate
If trim$( a3428.DateDelivery ) = "" Then b3428.DateDelivery = ""  Else b3428.DateDelivery=a3428.DateDelivery
If trim$( a3428.DateInsert ) = "" Then b3428.DateInsert = ""  Else b3428.DateInsert=a3428.DateInsert
If trim$( a3428.DateUpdate ) = "" Then b3428.DateUpdate = ""  Else b3428.DateUpdate=a3428.DateUpdate
If trim$( a3428.InchargeInsert ) = "" Then b3428.InchargeInsert = ""  Else b3428.InchargeInsert=a3428.InchargeInsert
If trim$( a3428.InchargeUpdate ) = "" Then b3428.InchargeUpdate = ""  Else b3428.InchargeUpdate=a3428.InchargeUpdate
If trim$( a3428.TimeInsert ) = "" Then b3428.TimeInsert = ""  Else b3428.TimeInsert=a3428.TimeInsert
If trim$( a3428.TimeUpdate ) = "" Then b3428.TimeUpdate = ""  Else b3428.TimeUpdate=a3428.TimeUpdate
If trim$( a3428.CheckComplete ) = "" Then b3428.CheckComplete = ""  Else b3428.CheckComplete=a3428.CheckComplete
If trim$( a3428.InchargeSync ) = "" Then b3428.InchargeSync = ""  Else b3428.InchargeSync=a3428.InchargeSync
If trim$( a3428.DateSync ) = "" Then b3428.DateSync = ""  Else b3428.DateSync=a3428.DateSync
If trim$( a3428.CheckSync ) = "" Then b3428.CheckSync = ""  Else b3428.CheckSync=a3428.CheckSync
If trim$( a3428.PurchasingOrderNo ) = "" Then b3428.PurchasingOrderNo = ""  Else b3428.PurchasingOrderNo=a3428.PurchasingOrderNo
If trim$( a3428.SalesOrderNo ) = "" Then b3428.SalesOrderNo = ""  Else b3428.SalesOrderNo=a3428.SalesOrderNo
If trim$( a3428.SalesOrderSeq ) = "" Then b3428.SalesOrderSeq = ""  Else b3428.SalesOrderSeq=a3428.SalesOrderSeq
If trim$( a3428.SalesOrderSno ) = "" Then b3428.SalesOrderSno = ""  Else b3428.SalesOrderSno=a3428.SalesOrderSno
If trim$( a3428.Remark ) = "" Then b3428.Remark = ""  Else b3428.Remark=a3428.Remark
If trim$( a3428.seSite ) = "" Then b3428.seSite = ""  Else b3428.seSite=a3428.seSite
If trim$( a3428.cdSite ) = "" Then b3428.cdSite = ""  Else b3428.cdSite=a3428.cdSite
Catch ex As Exception
      Call MsgBoxP("K3428_MOVE",vbCritical)
End Try
End Sub 


End Module 
