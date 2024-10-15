'=========================================================================================================================================================
'   TABLE : (PFK2345)
'
'      WORKER : PSM GLOBAL ., LTD
'       WORK DATE : 2019 NEW
'       DEVELOPER    : MRNLV
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K2345

Structure T2345_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	FactOrderNo	 AS String	'			char(9)		*
Public 	FactOrderName	 AS String	'			nvarchar(200)
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
Public 	TimeInsert	 AS String	'			char(14)
Public 	TimeUpdate	 AS String	'			char(14)
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

Public D2345 As T2345_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK2345(FACTORDERNO AS String) As Boolean
    READ_PFK2345 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK2345 "
    SQL = SQL & " WHERE K2345_FactOrderNo		 = '" & FactOrderNo & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D2345_CLEAR: GoTo SKIP_READ_PFK2345
                
    Call K2345_MOVE(rd)
    READ_PFK2345 = True

SKIP_READ_PFK2345:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK2345",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK2345(FACTORDERNO AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK2345 "
    SQL = SQL & " WHERE K2345_FactOrderNo		 = '" & FactOrderNo & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK2345",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK2345(z2345 As T2345_AREA) As Boolean
    WRITE_PFK2345 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z2345)
 
    SQL = " INSERT INTO PFK2345 "
    SQL = SQL & " ( "
    SQL = SQL & " K2345_FactOrderNo," 
    SQL = SQL & " K2345_FactOrderName," 
    SQL = SQL & " K2345_seSeason," 
    SQL = SQL & " K2345_cdSeason," 
    SQL = SQL & " K2345_CustomerCode," 
    SQL = SQL & " K2345_DateAccept," 
    SQL = SQL & " K2345_CheckInPurchasingOrder," 
    SQL = SQL & " K2345_CheckOutPurchasingOrder," 
    SQL = SQL & " K2345_CheckProcessType," 
    SQL = SQL & " K2345_CheckIOType," 
    SQL = SQL & " K2345_CheckMaterialType," 
    SQL = SQL & " K2345_CheckMarketType," 
    SQL = SQL & " K2345_CheckRelationType," 
    SQL = SQL & " K2345_SupplierCode," 
    SQL = SQL & " K2345_selUnitPrice," 
    SQL = SQL & " K2345_cdUnitPrice," 
    SQL = SQL & " K2345_PriceExchange," 
    SQL = SQL & " K2345_DateExchange," 
    SQL = SQL & " K2345_seOrigin," 
    SQL = SQL & " K2345_cdOrigin," 
    SQL = SQL & " K2345_seCommercialTerm," 
    SQL = SQL & " K2345_cdCommercialTerm," 
    SQL = SQL & " K2345_seDeliveryTerm," 
    SQL = SQL & " K2345_cdDeliveryTerm," 
    SQL = SQL & " K2345_sePaymentTerm," 
    SQL = SQL & " K2345_cdPaymentTerm," 
    SQL = SQL & " K2345_sePaymentCondition," 
    SQL = SQL & " K2345_cdPaymentCondition," 
    SQL = SQL & " K2345_sePaymentTime," 
    SQL = SQL & " K2345_cdPaymentTime," 
    SQL = SQL & " K2345_sePaymentDay," 
    SQL = SQL & " K2345_cdPaymentDay," 
    SQL = SQL & " K2345_seBuyingType," 
    SQL = SQL & " K2345_cdBuyingType," 
    SQL = SQL & " K2345_QualityRequest," 
    SQL = SQL & " K2345_ContractNo," 
    SQL = SQL & " K2345_Tolerance," 
    SQL = SQL & " K2345_Destination," 
    SQL = SQL & " K2345_InchargePurchasing," 
    SQL = SQL & " K2345_AmountPurchasingEX," 
    SQL = SQL & " K2345_AmountPurchasingVND," 
    SQL = SQL & " K2345_AmountTaxEX," 
    SQL = SQL & " K2345_AmountTaxVND," 
    SQL = SQL & " K2345_AmountExpenseUSD," 
    SQL = SQL & " K2345_AmountExpenseVND," 
    SQL = SQL & " K2345_AmountTotalEX," 
    SQL = SQL & " K2345_AmountTotalVND," 
    SQL = SQL & " K2345_DateStart," 
    SQL = SQL & " K2345_DateEstimate," 
    SQL = SQL & " K2345_DateDelivery," 
    SQL = SQL & " K2345_TimeInsert," 
    SQL = SQL & " K2345_TimeUpdate," 
    SQL = SQL & " K2345_DateInsert," 
    SQL = SQL & " K2345_DateUpdate," 
    SQL = SQL & " K2345_InchargeInsert," 
    SQL = SQL & " K2345_InchargeUpdate," 
    SQL = SQL & " K2345_CheckComplete," 
    SQL = SQL & " K2345_PurchasingOrderNo," 
    SQL = SQL & " K2345_SalesOrderNo," 
    SQL = SQL & " K2345_SalesOrderSeq," 
    SQL = SQL & " K2345_SalesOrderSno," 
    SQL = SQL & " K2345_Remark," 
    SQL = SQL & " K2345_ComponentList," 
    SQL = SQL & " K2345_seSite," 
    SQL = SQL & " K2345_cdSite " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z2345.FactOrderNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2345.FactOrderName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2345.seSeason) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2345.cdSeason) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2345.CustomerCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2345.DateAccept) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2345.CheckInPurchasingOrder) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2345.CheckOutPurchasingOrder) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2345.CheckProcessType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2345.CheckIOType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2345.CheckMaterialType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2345.CheckMarketType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2345.CheckRelationType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2345.SupplierCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2345.selUnitPrice) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2345.cdUnitPrice) & "', "  
    SQL = SQL & "   " & FormatSQL(z2345.PriceExchange) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z2345.DateExchange) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2345.seOrigin) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2345.cdOrigin) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2345.seCommercialTerm) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2345.cdCommercialTerm) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2345.seDeliveryTerm) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2345.cdDeliveryTerm) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2345.sePaymentTerm) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2345.cdPaymentTerm) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2345.sePaymentCondition) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2345.cdPaymentCondition) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2345.sePaymentTime) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2345.cdPaymentTime) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2345.sePaymentDay) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2345.cdPaymentDay) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2345.seBuyingType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2345.cdBuyingType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2345.QualityRequest) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2345.ContractNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2345.Tolerance) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2345.Destination) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2345.InchargePurchasing) & "', "  
    SQL = SQL & "   " & FormatSQL(z2345.AmountPurchasingEX) & ", "  
    SQL = SQL & "   " & FormatSQL(z2345.AmountPurchasingVND) & ", "  
    SQL = SQL & "   " & FormatSQL(z2345.AmountTaxEX) & ", "  
    SQL = SQL & "   " & FormatSQL(z2345.AmountTaxVND) & ", "  
    SQL = SQL & "   " & FormatSQL(z2345.AmountExpenseUSD) & ", "  
    SQL = SQL & "   " & FormatSQL(z2345.AmountExpenseVND) & ", "  
    SQL = SQL & "   " & FormatSQL(z2345.AmountTotalEX) & ", "  
    SQL = SQL & "   " & FormatSQL(z2345.AmountTotalVND) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z2345.DateStart) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2345.DateEstimate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2345.DateDelivery) & "', "  
    SQL = SQL & "  N'" & FormatSQL(PUB.TIME) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2345.TimeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(PUB.DAT) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2345.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(PUB.SAW) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2345.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2345.CheckComplete) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2345.PurchasingOrderNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2345.SalesOrderNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2345.SalesOrderSeq) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2345.SalesOrderSno) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2345.Remark) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2345.ComponentList) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2345.seSite) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2345.cdSite) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK2345 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK2345",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK2345(z2345 As T2345_AREA) As Boolean
    REWRITE_PFK2345 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z2345)
   
    SQL = " UPDATE PFK2345 SET "
    SQL = SQL & "    K2345_FactOrderName      = N'" & FormatSQL(z2345.FactOrderName) & "', " 
    SQL = SQL & "    K2345_seSeason      = N'" & FormatSQL(z2345.seSeason) & "', " 
    SQL = SQL & "    K2345_cdSeason      = N'" & FormatSQL(z2345.cdSeason) & "', " 
    SQL = SQL & "    K2345_CustomerCode      = N'" & FormatSQL(z2345.CustomerCode) & "', " 
    SQL = SQL & "    K2345_DateAccept      = N'" & FormatSQL(z2345.DateAccept) & "', " 
    SQL = SQL & "    K2345_CheckInPurchasingOrder      = N'" & FormatSQL(z2345.CheckInPurchasingOrder) & "', " 
    SQL = SQL & "    K2345_CheckOutPurchasingOrder      = N'" & FormatSQL(z2345.CheckOutPurchasingOrder) & "', " 
    SQL = SQL & "    K2345_CheckProcessType      = N'" & FormatSQL(z2345.CheckProcessType) & "', " 
    SQL = SQL & "    K2345_CheckIOType      = N'" & FormatSQL(z2345.CheckIOType) & "', " 
    SQL = SQL & "    K2345_CheckMaterialType      = N'" & FormatSQL(z2345.CheckMaterialType) & "', " 
    SQL = SQL & "    K2345_CheckMarketType      = N'" & FormatSQL(z2345.CheckMarketType) & "', " 
    SQL = SQL & "    K2345_CheckRelationType      = N'" & FormatSQL(z2345.CheckRelationType) & "', " 
    SQL = SQL & "    K2345_SupplierCode      = N'" & FormatSQL(z2345.SupplierCode) & "', " 
    SQL = SQL & "    K2345_selUnitPrice      = N'" & FormatSQL(z2345.selUnitPrice) & "', " 
    SQL = SQL & "    K2345_cdUnitPrice      = N'" & FormatSQL(z2345.cdUnitPrice) & "', " 
    SQL = SQL & "    K2345_PriceExchange      =  " & FormatSQL(z2345.PriceExchange) & ", " 
    SQL = SQL & "    K2345_DateExchange      = N'" & FormatSQL(z2345.DateExchange) & "', " 
    SQL = SQL & "    K2345_seOrigin      = N'" & FormatSQL(z2345.seOrigin) & "', " 
    SQL = SQL & "    K2345_cdOrigin      = N'" & FormatSQL(z2345.cdOrigin) & "', " 
    SQL = SQL & "    K2345_seCommercialTerm      = N'" & FormatSQL(z2345.seCommercialTerm) & "', " 
    SQL = SQL & "    K2345_cdCommercialTerm      = N'" & FormatSQL(z2345.cdCommercialTerm) & "', " 
    SQL = SQL & "    K2345_seDeliveryTerm      = N'" & FormatSQL(z2345.seDeliveryTerm) & "', " 
    SQL = SQL & "    K2345_cdDeliveryTerm      = N'" & FormatSQL(z2345.cdDeliveryTerm) & "', " 
    SQL = SQL & "    K2345_sePaymentTerm      = N'" & FormatSQL(z2345.sePaymentTerm) & "', " 
    SQL = SQL & "    K2345_cdPaymentTerm      = N'" & FormatSQL(z2345.cdPaymentTerm) & "', " 
    SQL = SQL & "    K2345_sePaymentCondition      = N'" & FormatSQL(z2345.sePaymentCondition) & "', " 
    SQL = SQL & "    K2345_cdPaymentCondition      = N'" & FormatSQL(z2345.cdPaymentCondition) & "', " 
    SQL = SQL & "    K2345_sePaymentTime      = N'" & FormatSQL(z2345.sePaymentTime) & "', " 
    SQL = SQL & "    K2345_cdPaymentTime      = N'" & FormatSQL(z2345.cdPaymentTime) & "', " 
    SQL = SQL & "    K2345_sePaymentDay      = N'" & FormatSQL(z2345.sePaymentDay) & "', " 
    SQL = SQL & "    K2345_cdPaymentDay      = N'" & FormatSQL(z2345.cdPaymentDay) & "', " 
    SQL = SQL & "    K2345_seBuyingType      = N'" & FormatSQL(z2345.seBuyingType) & "', " 
    SQL = SQL & "    K2345_cdBuyingType      = N'" & FormatSQL(z2345.cdBuyingType) & "', " 
    SQL = SQL & "    K2345_QualityRequest      = N'" & FormatSQL(z2345.QualityRequest) & "', " 
    SQL = SQL & "    K2345_ContractNo      = N'" & FormatSQL(z2345.ContractNo) & "', " 
    SQL = SQL & "    K2345_Tolerance      = N'" & FormatSQL(z2345.Tolerance) & "', " 
    SQL = SQL & "    K2345_Destination      = N'" & FormatSQL(z2345.Destination) & "', " 
    SQL = SQL & "    K2345_InchargePurchasing      = N'" & FormatSQL(z2345.InchargePurchasing) & "', " 
    SQL = SQL & "    K2345_AmountPurchasingEX      =  " & FormatSQL(z2345.AmountPurchasingEX) & ", " 
    SQL = SQL & "    K2345_AmountPurchasingVND      =  " & FormatSQL(z2345.AmountPurchasingVND) & ", " 
    SQL = SQL & "    K2345_AmountTaxEX      =  " & FormatSQL(z2345.AmountTaxEX) & ", " 
    SQL = SQL & "    K2345_AmountTaxVND      =  " & FormatSQL(z2345.AmountTaxVND) & ", " 
    SQL = SQL & "    K2345_AmountExpenseUSD      =  " & FormatSQL(z2345.AmountExpenseUSD) & ", " 
    SQL = SQL & "    K2345_AmountExpenseVND      =  " & FormatSQL(z2345.AmountExpenseVND) & ", " 
    SQL = SQL & "    K2345_AmountTotalEX      =  " & FormatSQL(z2345.AmountTotalEX) & ", " 
    SQL = SQL & "    K2345_AmountTotalVND      =  " & FormatSQL(z2345.AmountTotalVND) & ", " 
    SQL = SQL & "    K2345_DateStart      = N'" & FormatSQL(z2345.DateStart) & "', " 
    SQL = SQL & "    K2345_DateEstimate      = N'" & FormatSQL(z2345.DateEstimate) & "', " 
    SQL = SQL & "    K2345_DateDelivery      = N'" & FormatSQL(z2345.DateDelivery) & "', " 
    SQL = SQL & "    K2345_TimeInsert      = N'" & FormatSQL(z2345.TimeInsert) & "', " 
    SQL = SQL & "    K2345_TimeUpdate      = N'" & FormatSQL(PUB.TIME) & "', " 
    SQL = SQL & "    K2345_DateInsert      = N'" & FormatSQL(z2345.DateInsert) & "', " 
    SQL = SQL & "    K2345_DateUpdate      = N'" & FormatSQL(PUB.DAT) & "', " 
    SQL = SQL & "    K2345_InchargeInsert      = N'" & FormatSQL(z2345.InchargeInsert) & "', " 
    SQL = SQL & "    K2345_InchargeUpdate      = N'" & FormatSQL(PUB.SAW) & "', " 
    SQL = SQL & "    K2345_CheckComplete      = N'" & FormatSQL(z2345.CheckComplete) & "', " 
    SQL = SQL & "    K2345_PurchasingOrderNo      = N'" & FormatSQL(z2345.PurchasingOrderNo) & "', " 
    SQL = SQL & "    K2345_SalesOrderNo      = N'" & FormatSQL(z2345.SalesOrderNo) & "', " 
    SQL = SQL & "    K2345_SalesOrderSeq      = N'" & FormatSQL(z2345.SalesOrderSeq) & "', " 
    SQL = SQL & "    K2345_SalesOrderSno      = N'" & FormatSQL(z2345.SalesOrderSno) & "', " 
    SQL = SQL & "    K2345_Remark      = N'" & FormatSQL(z2345.Remark) & "', " 
    SQL = SQL & "    K2345_ComponentList      = N'" & FormatSQL(z2345.ComponentList) & "', " 
    SQL = SQL & "    K2345_seSite      = N'" & FormatSQL(z2345.seSite) & "', " 
    SQL = SQL & "    K2345_cdSite      = N'" & FormatSQL(z2345.cdSite) & "'  " 
    SQL = SQL & " WHERE K2345_FactOrderNo		 = '" & z2345.FactOrderNo & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  

    REWRITE_PFK2345 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK2345",vbCritical)

  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK2345(z2345 As T2345_AREA) As Boolean
    DELETE_PFK2345 = False

   Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z2345)
      
        SQL = " DELETE FROM PFK2345  "
    SQL = SQL & " WHERE K2345_FactOrderNo		 = '" & z2345.FactOrderNo & "' " 

    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK2345 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK2345",vbCritical)
Finally
        Call GetFullInformation("PFK2345", "D", SQL)
  End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D2345_CLEAR()
Try
    
   D2345.FactOrderNo = ""
   D2345.FactOrderName = ""
   D2345.seSeason = ""
   D2345.cdSeason = ""
   D2345.CustomerCode = ""
   D2345.DateAccept = ""
   D2345.CheckInPurchasingOrder = ""
   D2345.CheckOutPurchasingOrder = ""
   D2345.CheckProcessType = ""
   D2345.CheckIOType = ""
   D2345.CheckMaterialType = ""
   D2345.CheckMarketType = ""
   D2345.CheckRelationType = ""
   D2345.SupplierCode = ""
   D2345.selUnitPrice = ""
   D2345.cdUnitPrice = ""
    D2345.PriceExchange = 0 
   D2345.DateExchange = ""
   D2345.seOrigin = ""
   D2345.cdOrigin = ""
   D2345.seCommercialTerm = ""
   D2345.cdCommercialTerm = ""
   D2345.seDeliveryTerm = ""
   D2345.cdDeliveryTerm = ""
   D2345.sePaymentTerm = ""
   D2345.cdPaymentTerm = ""
   D2345.sePaymentCondition = ""
   D2345.cdPaymentCondition = ""
   D2345.sePaymentTime = ""
   D2345.cdPaymentTime = ""
   D2345.sePaymentDay = ""
   D2345.cdPaymentDay = ""
   D2345.seBuyingType = ""
   D2345.cdBuyingType = ""
   D2345.QualityRequest = ""
   D2345.ContractNo = ""
   D2345.Tolerance = ""
   D2345.Destination = ""
   D2345.InchargePurchasing = ""
    D2345.AmountPurchasingEX = 0 
    D2345.AmountPurchasingVND = 0 
    D2345.AmountTaxEX = 0 
    D2345.AmountTaxVND = 0 
    D2345.AmountExpenseUSD = 0 
    D2345.AmountExpenseVND = 0 
    D2345.AmountTotalEX = 0 
    D2345.AmountTotalVND = 0 
   D2345.DateStart = ""
   D2345.DateEstimate = ""
   D2345.DateDelivery = ""
   D2345.TimeInsert = ""
   D2345.TimeUpdate = ""
   D2345.DateInsert = ""
   D2345.DateUpdate = ""
   D2345.InchargeInsert = ""
   D2345.InchargeUpdate = ""
   D2345.CheckComplete = ""
   D2345.PurchasingOrderNo = ""
   D2345.SalesOrderNo = ""
   D2345.SalesOrderSeq = ""
   D2345.SalesOrderSno = ""
   D2345.Remark = ""
   D2345.ComponentList = ""
   D2345.seSite = ""
   D2345.cdSite = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D2345_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x2345 As T2345_AREA)
Try
    
    x2345.FactOrderNo = trim$(  x2345.FactOrderNo)
    x2345.FactOrderName = trim$(  x2345.FactOrderName)
    x2345.seSeason = trim$(  x2345.seSeason)
    x2345.cdSeason = trim$(  x2345.cdSeason)
    x2345.CustomerCode = trim$(  x2345.CustomerCode)
    x2345.DateAccept = trim$(  x2345.DateAccept)
    x2345.CheckInPurchasingOrder = trim$(  x2345.CheckInPurchasingOrder)
    x2345.CheckOutPurchasingOrder = trim$(  x2345.CheckOutPurchasingOrder)
    x2345.CheckProcessType = trim$(  x2345.CheckProcessType)
    x2345.CheckIOType = trim$(  x2345.CheckIOType)
    x2345.CheckMaterialType = trim$(  x2345.CheckMaterialType)
    x2345.CheckMarketType = trim$(  x2345.CheckMarketType)
    x2345.CheckRelationType = trim$(  x2345.CheckRelationType)
    x2345.SupplierCode = trim$(  x2345.SupplierCode)
    x2345.selUnitPrice = trim$(  x2345.selUnitPrice)
    x2345.cdUnitPrice = trim$(  x2345.cdUnitPrice)
    x2345.PriceExchange = trim$(  x2345.PriceExchange)
    x2345.DateExchange = trim$(  x2345.DateExchange)
    x2345.seOrigin = trim$(  x2345.seOrigin)
    x2345.cdOrigin = trim$(  x2345.cdOrigin)
    x2345.seCommercialTerm = trim$(  x2345.seCommercialTerm)
    x2345.cdCommercialTerm = trim$(  x2345.cdCommercialTerm)
    x2345.seDeliveryTerm = trim$(  x2345.seDeliveryTerm)
    x2345.cdDeliveryTerm = trim$(  x2345.cdDeliveryTerm)
    x2345.sePaymentTerm = trim$(  x2345.sePaymentTerm)
    x2345.cdPaymentTerm = trim$(  x2345.cdPaymentTerm)
    x2345.sePaymentCondition = trim$(  x2345.sePaymentCondition)
    x2345.cdPaymentCondition = trim$(  x2345.cdPaymentCondition)
    x2345.sePaymentTime = trim$(  x2345.sePaymentTime)
    x2345.cdPaymentTime = trim$(  x2345.cdPaymentTime)
    x2345.sePaymentDay = trim$(  x2345.sePaymentDay)
    x2345.cdPaymentDay = trim$(  x2345.cdPaymentDay)
    x2345.seBuyingType = trim$(  x2345.seBuyingType)
    x2345.cdBuyingType = trim$(  x2345.cdBuyingType)
    x2345.QualityRequest = trim$(  x2345.QualityRequest)
    x2345.ContractNo = trim$(  x2345.ContractNo)
    x2345.Tolerance = trim$(  x2345.Tolerance)
    x2345.Destination = trim$(  x2345.Destination)
    x2345.InchargePurchasing = trim$(  x2345.InchargePurchasing)
    x2345.AmountPurchasingEX = trim$(  x2345.AmountPurchasingEX)
    x2345.AmountPurchasingVND = trim$(  x2345.AmountPurchasingVND)
    x2345.AmountTaxEX = trim$(  x2345.AmountTaxEX)
    x2345.AmountTaxVND = trim$(  x2345.AmountTaxVND)
    x2345.AmountExpenseUSD = trim$(  x2345.AmountExpenseUSD)
    x2345.AmountExpenseVND = trim$(  x2345.AmountExpenseVND)
    x2345.AmountTotalEX = trim$(  x2345.AmountTotalEX)
    x2345.AmountTotalVND = trim$(  x2345.AmountTotalVND)
    x2345.DateStart = trim$(  x2345.DateStart)
    x2345.DateEstimate = trim$(  x2345.DateEstimate)
    x2345.DateDelivery = trim$(  x2345.DateDelivery)
    x2345.TimeInsert = trim$(  x2345.TimeInsert)
    x2345.TimeUpdate = trim$(  x2345.TimeUpdate)
    x2345.DateInsert = trim$(  x2345.DateInsert)
    x2345.DateUpdate = trim$(  x2345.DateUpdate)
    x2345.InchargeInsert = trim$(  x2345.InchargeInsert)
    x2345.InchargeUpdate = trim$(  x2345.InchargeUpdate)
    x2345.CheckComplete = trim$(  x2345.CheckComplete)
    x2345.PurchasingOrderNo = trim$(  x2345.PurchasingOrderNo)
    x2345.SalesOrderNo = trim$(  x2345.SalesOrderNo)
    x2345.SalesOrderSeq = trim$(  x2345.SalesOrderSeq)
    x2345.SalesOrderSno = trim$(  x2345.SalesOrderSno)
    x2345.Remark = trim$(  x2345.Remark)
    x2345.ComponentList = trim$(  x2345.ComponentList)
    x2345.seSite = trim$(  x2345.seSite)
    x2345.cdSite = trim$(  x2345.cdSite)
     
    If trim$( x2345.FactOrderNo ) = "" Then x2345.FactOrderNo = Space(1) 
    If trim$( x2345.FactOrderName ) = "" Then x2345.FactOrderName = Space(1) 
    If trim$( x2345.seSeason ) = "" Then x2345.seSeason = Space(1) 
    If trim$( x2345.cdSeason ) = "" Then x2345.cdSeason = Space(1) 
    If trim$( x2345.CustomerCode ) = "" Then x2345.CustomerCode = Space(1) 
    If trim$( x2345.DateAccept ) = "" Then x2345.DateAccept = Space(1) 
    If trim$( x2345.CheckInPurchasingOrder ) = "" Then x2345.CheckInPurchasingOrder = Space(1) 
    If trim$( x2345.CheckOutPurchasingOrder ) = "" Then x2345.CheckOutPurchasingOrder = Space(1) 
    If trim$( x2345.CheckProcessType ) = "" Then x2345.CheckProcessType = Space(1) 
    If trim$( x2345.CheckIOType ) = "" Then x2345.CheckIOType = Space(1) 
    If trim$( x2345.CheckMaterialType ) = "" Then x2345.CheckMaterialType = Space(1) 
    If trim$( x2345.CheckMarketType ) = "" Then x2345.CheckMarketType = Space(1) 
    If trim$( x2345.CheckRelationType ) = "" Then x2345.CheckRelationType = Space(1) 
    If trim$( x2345.SupplierCode ) = "" Then x2345.SupplierCode = Space(1) 
    If trim$( x2345.selUnitPrice ) = "" Then x2345.selUnitPrice = Space(1) 
    If trim$( x2345.cdUnitPrice ) = "" Then x2345.cdUnitPrice = Space(1) 
    If trim$( x2345.PriceExchange ) = "" Then x2345.PriceExchange = 0 
    If trim$( x2345.DateExchange ) = "" Then x2345.DateExchange = Space(1) 
    If trim$( x2345.seOrigin ) = "" Then x2345.seOrigin = Space(1) 
    If trim$( x2345.cdOrigin ) = "" Then x2345.cdOrigin = Space(1) 
    If trim$( x2345.seCommercialTerm ) = "" Then x2345.seCommercialTerm = Space(1) 
    If trim$( x2345.cdCommercialTerm ) = "" Then x2345.cdCommercialTerm = Space(1) 
    If trim$( x2345.seDeliveryTerm ) = "" Then x2345.seDeliveryTerm = Space(1) 
    If trim$( x2345.cdDeliveryTerm ) = "" Then x2345.cdDeliveryTerm = Space(1) 
    If trim$( x2345.sePaymentTerm ) = "" Then x2345.sePaymentTerm = Space(1) 
    If trim$( x2345.cdPaymentTerm ) = "" Then x2345.cdPaymentTerm = Space(1) 
    If trim$( x2345.sePaymentCondition ) = "" Then x2345.sePaymentCondition = Space(1) 
    If trim$( x2345.cdPaymentCondition ) = "" Then x2345.cdPaymentCondition = Space(1) 
    If trim$( x2345.sePaymentTime ) = "" Then x2345.sePaymentTime = Space(1) 
    If trim$( x2345.cdPaymentTime ) = "" Then x2345.cdPaymentTime = Space(1) 
    If trim$( x2345.sePaymentDay ) = "" Then x2345.sePaymentDay = Space(1) 
    If trim$( x2345.cdPaymentDay ) = "" Then x2345.cdPaymentDay = Space(1) 
    If trim$( x2345.seBuyingType ) = "" Then x2345.seBuyingType = Space(1) 
    If trim$( x2345.cdBuyingType ) = "" Then x2345.cdBuyingType = Space(1) 
    If trim$( x2345.QualityRequest ) = "" Then x2345.QualityRequest = Space(1) 
    If trim$( x2345.ContractNo ) = "" Then x2345.ContractNo = Space(1) 
    If trim$( x2345.Tolerance ) = "" Then x2345.Tolerance = Space(1) 
    If trim$( x2345.Destination ) = "" Then x2345.Destination = Space(1) 
    If trim$( x2345.InchargePurchasing ) = "" Then x2345.InchargePurchasing = Space(1) 
    If trim$( x2345.AmountPurchasingEX ) = "" Then x2345.AmountPurchasingEX = 0 
    If trim$( x2345.AmountPurchasingVND ) = "" Then x2345.AmountPurchasingVND = 0 
    If trim$( x2345.AmountTaxEX ) = "" Then x2345.AmountTaxEX = 0 
    If trim$( x2345.AmountTaxVND ) = "" Then x2345.AmountTaxVND = 0 
    If trim$( x2345.AmountExpenseUSD ) = "" Then x2345.AmountExpenseUSD = 0 
    If trim$( x2345.AmountExpenseVND ) = "" Then x2345.AmountExpenseVND = 0 
    If trim$( x2345.AmountTotalEX ) = "" Then x2345.AmountTotalEX = 0 
    If trim$( x2345.AmountTotalVND ) = "" Then x2345.AmountTotalVND = 0 
    If trim$( x2345.DateStart ) = "" Then x2345.DateStart = Space(1) 
    If trim$( x2345.DateEstimate ) = "" Then x2345.DateEstimate = Space(1) 
    If trim$( x2345.DateDelivery ) = "" Then x2345.DateDelivery = Space(1) 
    If trim$( x2345.TimeInsert ) = "" Then x2345.TimeInsert = Space(1) 
    If trim$( x2345.TimeUpdate ) = "" Then x2345.TimeUpdate = Space(1) 
    If trim$( x2345.DateInsert ) = "" Then x2345.DateInsert = Space(1) 
    If trim$( x2345.DateUpdate ) = "" Then x2345.DateUpdate = Space(1) 
    If trim$( x2345.InchargeInsert ) = "" Then x2345.InchargeInsert = Space(1) 
    If trim$( x2345.InchargeUpdate ) = "" Then x2345.InchargeUpdate = Space(1) 
    If trim$( x2345.CheckComplete ) = "" Then x2345.CheckComplete = Space(1) 
    If trim$( x2345.PurchasingOrderNo ) = "" Then x2345.PurchasingOrderNo = Space(1) 
    If trim$( x2345.SalesOrderNo ) = "" Then x2345.SalesOrderNo = Space(1) 
    If trim$( x2345.SalesOrderSeq ) = "" Then x2345.SalesOrderSeq = Space(1) 
    If trim$( x2345.SalesOrderSno ) = "" Then x2345.SalesOrderSno = Space(1) 
    If trim$( x2345.Remark ) = "" Then x2345.Remark = Space(1) 
    If trim$( x2345.ComponentList ) = "" Then x2345.ComponentList = Space(1) 
    If trim$( x2345.seSite ) = "" Then x2345.seSite = Space(1) 
    If trim$( x2345.cdSite ) = "" Then x2345.cdSite = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K2345_MOVE(rs2345 As SqlClient.SqlDataReader)
Try

    call D2345_CLEAR()   

    If IsdbNull(rs2345!K2345_FactOrderNo) = False Then D2345.FactOrderNo = Trim$(rs2345!K2345_FactOrderNo)
    If IsdbNull(rs2345!K2345_FactOrderName) = False Then D2345.FactOrderName = Trim$(rs2345!K2345_FactOrderName)
    If IsdbNull(rs2345!K2345_seSeason) = False Then D2345.seSeason = Trim$(rs2345!K2345_seSeason)
    If IsdbNull(rs2345!K2345_cdSeason) = False Then D2345.cdSeason = Trim$(rs2345!K2345_cdSeason)
    If IsdbNull(rs2345!K2345_CustomerCode) = False Then D2345.CustomerCode = Trim$(rs2345!K2345_CustomerCode)
    If IsdbNull(rs2345!K2345_DateAccept) = False Then D2345.DateAccept = Trim$(rs2345!K2345_DateAccept)
    If IsdbNull(rs2345!K2345_CheckInPurchasingOrder) = False Then D2345.CheckInPurchasingOrder = Trim$(rs2345!K2345_CheckInPurchasingOrder)
    If IsdbNull(rs2345!K2345_CheckOutPurchasingOrder) = False Then D2345.CheckOutPurchasingOrder = Trim$(rs2345!K2345_CheckOutPurchasingOrder)
    If IsdbNull(rs2345!K2345_CheckProcessType) = False Then D2345.CheckProcessType = Trim$(rs2345!K2345_CheckProcessType)
    If IsdbNull(rs2345!K2345_CheckIOType) = False Then D2345.CheckIOType = Trim$(rs2345!K2345_CheckIOType)
    If IsdbNull(rs2345!K2345_CheckMaterialType) = False Then D2345.CheckMaterialType = Trim$(rs2345!K2345_CheckMaterialType)
    If IsdbNull(rs2345!K2345_CheckMarketType) = False Then D2345.CheckMarketType = Trim$(rs2345!K2345_CheckMarketType)
    If IsdbNull(rs2345!K2345_CheckRelationType) = False Then D2345.CheckRelationType = Trim$(rs2345!K2345_CheckRelationType)
    If IsdbNull(rs2345!K2345_SupplierCode) = False Then D2345.SupplierCode = Trim$(rs2345!K2345_SupplierCode)
    If IsdbNull(rs2345!K2345_selUnitPrice) = False Then D2345.selUnitPrice = Trim$(rs2345!K2345_selUnitPrice)
    If IsdbNull(rs2345!K2345_cdUnitPrice) = False Then D2345.cdUnitPrice = Trim$(rs2345!K2345_cdUnitPrice)
    If IsdbNull(rs2345!K2345_PriceExchange) = False Then D2345.PriceExchange = Trim$(rs2345!K2345_PriceExchange)
    If IsdbNull(rs2345!K2345_DateExchange) = False Then D2345.DateExchange = Trim$(rs2345!K2345_DateExchange)
    If IsdbNull(rs2345!K2345_seOrigin) = False Then D2345.seOrigin = Trim$(rs2345!K2345_seOrigin)
    If IsdbNull(rs2345!K2345_cdOrigin) = False Then D2345.cdOrigin = Trim$(rs2345!K2345_cdOrigin)
    If IsdbNull(rs2345!K2345_seCommercialTerm) = False Then D2345.seCommercialTerm = Trim$(rs2345!K2345_seCommercialTerm)
    If IsdbNull(rs2345!K2345_cdCommercialTerm) = False Then D2345.cdCommercialTerm = Trim$(rs2345!K2345_cdCommercialTerm)
    If IsdbNull(rs2345!K2345_seDeliveryTerm) = False Then D2345.seDeliveryTerm = Trim$(rs2345!K2345_seDeliveryTerm)
    If IsdbNull(rs2345!K2345_cdDeliveryTerm) = False Then D2345.cdDeliveryTerm = Trim$(rs2345!K2345_cdDeliveryTerm)
    If IsdbNull(rs2345!K2345_sePaymentTerm) = False Then D2345.sePaymentTerm = Trim$(rs2345!K2345_sePaymentTerm)
    If IsdbNull(rs2345!K2345_cdPaymentTerm) = False Then D2345.cdPaymentTerm = Trim$(rs2345!K2345_cdPaymentTerm)
    If IsdbNull(rs2345!K2345_sePaymentCondition) = False Then D2345.sePaymentCondition = Trim$(rs2345!K2345_sePaymentCondition)
    If IsdbNull(rs2345!K2345_cdPaymentCondition) = False Then D2345.cdPaymentCondition = Trim$(rs2345!K2345_cdPaymentCondition)
    If IsdbNull(rs2345!K2345_sePaymentTime) = False Then D2345.sePaymentTime = Trim$(rs2345!K2345_sePaymentTime)
    If IsdbNull(rs2345!K2345_cdPaymentTime) = False Then D2345.cdPaymentTime = Trim$(rs2345!K2345_cdPaymentTime)
    If IsdbNull(rs2345!K2345_sePaymentDay) = False Then D2345.sePaymentDay = Trim$(rs2345!K2345_sePaymentDay)
    If IsdbNull(rs2345!K2345_cdPaymentDay) = False Then D2345.cdPaymentDay = Trim$(rs2345!K2345_cdPaymentDay)
    If IsdbNull(rs2345!K2345_seBuyingType) = False Then D2345.seBuyingType = Trim$(rs2345!K2345_seBuyingType)
    If IsdbNull(rs2345!K2345_cdBuyingType) = False Then D2345.cdBuyingType = Trim$(rs2345!K2345_cdBuyingType)
    If IsdbNull(rs2345!K2345_QualityRequest) = False Then D2345.QualityRequest = Trim$(rs2345!K2345_QualityRequest)
    If IsdbNull(rs2345!K2345_ContractNo) = False Then D2345.ContractNo = Trim$(rs2345!K2345_ContractNo)
    If IsdbNull(rs2345!K2345_Tolerance) = False Then D2345.Tolerance = Trim$(rs2345!K2345_Tolerance)
    If IsdbNull(rs2345!K2345_Destination) = False Then D2345.Destination = Trim$(rs2345!K2345_Destination)
    If IsdbNull(rs2345!K2345_InchargePurchasing) = False Then D2345.InchargePurchasing = Trim$(rs2345!K2345_InchargePurchasing)
    If IsdbNull(rs2345!K2345_AmountPurchasingEX) = False Then D2345.AmountPurchasingEX = Trim$(rs2345!K2345_AmountPurchasingEX)
    If IsdbNull(rs2345!K2345_AmountPurchasingVND) = False Then D2345.AmountPurchasingVND = Trim$(rs2345!K2345_AmountPurchasingVND)
    If IsdbNull(rs2345!K2345_AmountTaxEX) = False Then D2345.AmountTaxEX = Trim$(rs2345!K2345_AmountTaxEX)
    If IsdbNull(rs2345!K2345_AmountTaxVND) = False Then D2345.AmountTaxVND = Trim$(rs2345!K2345_AmountTaxVND)
    If IsdbNull(rs2345!K2345_AmountExpenseUSD) = False Then D2345.AmountExpenseUSD = Trim$(rs2345!K2345_AmountExpenseUSD)
    If IsdbNull(rs2345!K2345_AmountExpenseVND) = False Then D2345.AmountExpenseVND = Trim$(rs2345!K2345_AmountExpenseVND)
    If IsdbNull(rs2345!K2345_AmountTotalEX) = False Then D2345.AmountTotalEX = Trim$(rs2345!K2345_AmountTotalEX)
    If IsdbNull(rs2345!K2345_AmountTotalVND) = False Then D2345.AmountTotalVND = Trim$(rs2345!K2345_AmountTotalVND)
    If IsdbNull(rs2345!K2345_DateStart) = False Then D2345.DateStart = Trim$(rs2345!K2345_DateStart)
    If IsdbNull(rs2345!K2345_DateEstimate) = False Then D2345.DateEstimate = Trim$(rs2345!K2345_DateEstimate)
    If IsdbNull(rs2345!K2345_DateDelivery) = False Then D2345.DateDelivery = Trim$(rs2345!K2345_DateDelivery)
    If IsdbNull(rs2345!K2345_TimeInsert) = False Then D2345.TimeInsert = Trim$(rs2345!K2345_TimeInsert)
    If IsdbNull(rs2345!K2345_TimeUpdate) = False Then D2345.TimeUpdate = Trim$(rs2345!K2345_TimeUpdate)
    If IsdbNull(rs2345!K2345_DateInsert) = False Then D2345.DateInsert = Trim$(rs2345!K2345_DateInsert)
    If IsdbNull(rs2345!K2345_DateUpdate) = False Then D2345.DateUpdate = Trim$(rs2345!K2345_DateUpdate)
    If IsdbNull(rs2345!K2345_InchargeInsert) = False Then D2345.InchargeInsert = Trim$(rs2345!K2345_InchargeInsert)
    If IsdbNull(rs2345!K2345_InchargeUpdate) = False Then D2345.InchargeUpdate = Trim$(rs2345!K2345_InchargeUpdate)
    If IsdbNull(rs2345!K2345_CheckComplete) = False Then D2345.CheckComplete = Trim$(rs2345!K2345_CheckComplete)
    If IsdbNull(rs2345!K2345_PurchasingOrderNo) = False Then D2345.PurchasingOrderNo = Trim$(rs2345!K2345_PurchasingOrderNo)
    If IsdbNull(rs2345!K2345_SalesOrderNo) = False Then D2345.SalesOrderNo = Trim$(rs2345!K2345_SalesOrderNo)
    If IsdbNull(rs2345!K2345_SalesOrderSeq) = False Then D2345.SalesOrderSeq = Trim$(rs2345!K2345_SalesOrderSeq)
    If IsdbNull(rs2345!K2345_SalesOrderSno) = False Then D2345.SalesOrderSno = Trim$(rs2345!K2345_SalesOrderSno)
    If IsdbNull(rs2345!K2345_Remark) = False Then D2345.Remark = Trim$(rs2345!K2345_Remark)
    If IsdbNull(rs2345!K2345_ComponentList) = False Then D2345.ComponentList = Trim$(rs2345!K2345_ComponentList)
    If IsdbNull(rs2345!K2345_seSite) = False Then D2345.seSite = Trim$(rs2345!K2345_seSite)
    If IsdbNull(rs2345!K2345_cdSite) = False Then D2345.cdSite = Trim$(rs2345!K2345_cdSite)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K2345_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K2345_MOVE(rs2345 As DataRow)
Try

    call D2345_CLEAR()   

    If IsdbNull(rs2345!K2345_FactOrderNo) = False Then D2345.FactOrderNo = Trim$(rs2345!K2345_FactOrderNo)
    If IsdbNull(rs2345!K2345_FactOrderName) = False Then D2345.FactOrderName = Trim$(rs2345!K2345_FactOrderName)
    If IsdbNull(rs2345!K2345_seSeason) = False Then D2345.seSeason = Trim$(rs2345!K2345_seSeason)
    If IsdbNull(rs2345!K2345_cdSeason) = False Then D2345.cdSeason = Trim$(rs2345!K2345_cdSeason)
    If IsdbNull(rs2345!K2345_CustomerCode) = False Then D2345.CustomerCode = Trim$(rs2345!K2345_CustomerCode)
    If IsdbNull(rs2345!K2345_DateAccept) = False Then D2345.DateAccept = Trim$(rs2345!K2345_DateAccept)
    If IsdbNull(rs2345!K2345_CheckInPurchasingOrder) = False Then D2345.CheckInPurchasingOrder = Trim$(rs2345!K2345_CheckInPurchasingOrder)
    If IsdbNull(rs2345!K2345_CheckOutPurchasingOrder) = False Then D2345.CheckOutPurchasingOrder = Trim$(rs2345!K2345_CheckOutPurchasingOrder)
    If IsdbNull(rs2345!K2345_CheckProcessType) = False Then D2345.CheckProcessType = Trim$(rs2345!K2345_CheckProcessType)
    If IsdbNull(rs2345!K2345_CheckIOType) = False Then D2345.CheckIOType = Trim$(rs2345!K2345_CheckIOType)
    If IsdbNull(rs2345!K2345_CheckMaterialType) = False Then D2345.CheckMaterialType = Trim$(rs2345!K2345_CheckMaterialType)
    If IsdbNull(rs2345!K2345_CheckMarketType) = False Then D2345.CheckMarketType = Trim$(rs2345!K2345_CheckMarketType)
    If IsdbNull(rs2345!K2345_CheckRelationType) = False Then D2345.CheckRelationType = Trim$(rs2345!K2345_CheckRelationType)
    If IsdbNull(rs2345!K2345_SupplierCode) = False Then D2345.SupplierCode = Trim$(rs2345!K2345_SupplierCode)
    If IsdbNull(rs2345!K2345_selUnitPrice) = False Then D2345.selUnitPrice = Trim$(rs2345!K2345_selUnitPrice)
    If IsdbNull(rs2345!K2345_cdUnitPrice) = False Then D2345.cdUnitPrice = Trim$(rs2345!K2345_cdUnitPrice)
    If IsdbNull(rs2345!K2345_PriceExchange) = False Then D2345.PriceExchange = Trim$(rs2345!K2345_PriceExchange)
    If IsdbNull(rs2345!K2345_DateExchange) = False Then D2345.DateExchange = Trim$(rs2345!K2345_DateExchange)
    If IsdbNull(rs2345!K2345_seOrigin) = False Then D2345.seOrigin = Trim$(rs2345!K2345_seOrigin)
    If IsdbNull(rs2345!K2345_cdOrigin) = False Then D2345.cdOrigin = Trim$(rs2345!K2345_cdOrigin)
    If IsdbNull(rs2345!K2345_seCommercialTerm) = False Then D2345.seCommercialTerm = Trim$(rs2345!K2345_seCommercialTerm)
    If IsdbNull(rs2345!K2345_cdCommercialTerm) = False Then D2345.cdCommercialTerm = Trim$(rs2345!K2345_cdCommercialTerm)
    If IsdbNull(rs2345!K2345_seDeliveryTerm) = False Then D2345.seDeliveryTerm = Trim$(rs2345!K2345_seDeliveryTerm)
    If IsdbNull(rs2345!K2345_cdDeliveryTerm) = False Then D2345.cdDeliveryTerm = Trim$(rs2345!K2345_cdDeliveryTerm)
    If IsdbNull(rs2345!K2345_sePaymentTerm) = False Then D2345.sePaymentTerm = Trim$(rs2345!K2345_sePaymentTerm)
    If IsdbNull(rs2345!K2345_cdPaymentTerm) = False Then D2345.cdPaymentTerm = Trim$(rs2345!K2345_cdPaymentTerm)
    If IsdbNull(rs2345!K2345_sePaymentCondition) = False Then D2345.sePaymentCondition = Trim$(rs2345!K2345_sePaymentCondition)
    If IsdbNull(rs2345!K2345_cdPaymentCondition) = False Then D2345.cdPaymentCondition = Trim$(rs2345!K2345_cdPaymentCondition)
    If IsdbNull(rs2345!K2345_sePaymentTime) = False Then D2345.sePaymentTime = Trim$(rs2345!K2345_sePaymentTime)
    If IsdbNull(rs2345!K2345_cdPaymentTime) = False Then D2345.cdPaymentTime = Trim$(rs2345!K2345_cdPaymentTime)
    If IsdbNull(rs2345!K2345_sePaymentDay) = False Then D2345.sePaymentDay = Trim$(rs2345!K2345_sePaymentDay)
    If IsdbNull(rs2345!K2345_cdPaymentDay) = False Then D2345.cdPaymentDay = Trim$(rs2345!K2345_cdPaymentDay)
    If IsdbNull(rs2345!K2345_seBuyingType) = False Then D2345.seBuyingType = Trim$(rs2345!K2345_seBuyingType)
    If IsdbNull(rs2345!K2345_cdBuyingType) = False Then D2345.cdBuyingType = Trim$(rs2345!K2345_cdBuyingType)
    If IsdbNull(rs2345!K2345_QualityRequest) = False Then D2345.QualityRequest = Trim$(rs2345!K2345_QualityRequest)
    If IsdbNull(rs2345!K2345_ContractNo) = False Then D2345.ContractNo = Trim$(rs2345!K2345_ContractNo)
    If IsdbNull(rs2345!K2345_Tolerance) = False Then D2345.Tolerance = Trim$(rs2345!K2345_Tolerance)
    If IsdbNull(rs2345!K2345_Destination) = False Then D2345.Destination = Trim$(rs2345!K2345_Destination)
    If IsdbNull(rs2345!K2345_InchargePurchasing) = False Then D2345.InchargePurchasing = Trim$(rs2345!K2345_InchargePurchasing)
    If IsdbNull(rs2345!K2345_AmountPurchasingEX) = False Then D2345.AmountPurchasingEX = Trim$(rs2345!K2345_AmountPurchasingEX)
    If IsdbNull(rs2345!K2345_AmountPurchasingVND) = False Then D2345.AmountPurchasingVND = Trim$(rs2345!K2345_AmountPurchasingVND)
    If IsdbNull(rs2345!K2345_AmountTaxEX) = False Then D2345.AmountTaxEX = Trim$(rs2345!K2345_AmountTaxEX)
    If IsdbNull(rs2345!K2345_AmountTaxVND) = False Then D2345.AmountTaxVND = Trim$(rs2345!K2345_AmountTaxVND)
    If IsdbNull(rs2345!K2345_AmountExpenseUSD) = False Then D2345.AmountExpenseUSD = Trim$(rs2345!K2345_AmountExpenseUSD)
    If IsdbNull(rs2345!K2345_AmountExpenseVND) = False Then D2345.AmountExpenseVND = Trim$(rs2345!K2345_AmountExpenseVND)
    If IsdbNull(rs2345!K2345_AmountTotalEX) = False Then D2345.AmountTotalEX = Trim$(rs2345!K2345_AmountTotalEX)
    If IsdbNull(rs2345!K2345_AmountTotalVND) = False Then D2345.AmountTotalVND = Trim$(rs2345!K2345_AmountTotalVND)
    If IsdbNull(rs2345!K2345_DateStart) = False Then D2345.DateStart = Trim$(rs2345!K2345_DateStart)
    If IsdbNull(rs2345!K2345_DateEstimate) = False Then D2345.DateEstimate = Trim$(rs2345!K2345_DateEstimate)
    If IsdbNull(rs2345!K2345_DateDelivery) = False Then D2345.DateDelivery = Trim$(rs2345!K2345_DateDelivery)
    If IsdbNull(rs2345!K2345_TimeInsert) = False Then D2345.TimeInsert = Trim$(rs2345!K2345_TimeInsert)
    If IsdbNull(rs2345!K2345_TimeUpdate) = False Then D2345.TimeUpdate = Trim$(rs2345!K2345_TimeUpdate)
    If IsdbNull(rs2345!K2345_DateInsert) = False Then D2345.DateInsert = Trim$(rs2345!K2345_DateInsert)
    If IsdbNull(rs2345!K2345_DateUpdate) = False Then D2345.DateUpdate = Trim$(rs2345!K2345_DateUpdate)
    If IsdbNull(rs2345!K2345_InchargeInsert) = False Then D2345.InchargeInsert = Trim$(rs2345!K2345_InchargeInsert)
    If IsdbNull(rs2345!K2345_InchargeUpdate) = False Then D2345.InchargeUpdate = Trim$(rs2345!K2345_InchargeUpdate)
    If IsdbNull(rs2345!K2345_CheckComplete) = False Then D2345.CheckComplete = Trim$(rs2345!K2345_CheckComplete)
    If IsdbNull(rs2345!K2345_PurchasingOrderNo) = False Then D2345.PurchasingOrderNo = Trim$(rs2345!K2345_PurchasingOrderNo)
    If IsdbNull(rs2345!K2345_SalesOrderNo) = False Then D2345.SalesOrderNo = Trim$(rs2345!K2345_SalesOrderNo)
    If IsdbNull(rs2345!K2345_SalesOrderSeq) = False Then D2345.SalesOrderSeq = Trim$(rs2345!K2345_SalesOrderSeq)
    If IsdbNull(rs2345!K2345_SalesOrderSno) = False Then D2345.SalesOrderSno = Trim$(rs2345!K2345_SalesOrderSno)
    If IsdbNull(rs2345!K2345_Remark) = False Then D2345.Remark = Trim$(rs2345!K2345_Remark)
    If IsdbNull(rs2345!K2345_ComponentList) = False Then D2345.ComponentList = Trim$(rs2345!K2345_ComponentList)
    If IsdbNull(rs2345!K2345_seSite) = False Then D2345.seSite = Trim$(rs2345!K2345_seSite)
    If IsdbNull(rs2345!K2345_cdSite) = False Then D2345.cdSite = Trim$(rs2345!K2345_cdSite)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K2345_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K2345_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z2345 As T2345_AREA, FACTORDERNO AS String) as Boolean

K2345_MOVE = False

Try
    If READ_PFK2345(FACTORDERNO) = True Then
                z2345 = D2345
		K2345_MOVE = True
		else
	z2345 = nothing
     End If

     If  getColumnIndex(spr,"FactOrderNo") > -1 then z2345.FactOrderNo = getDataM(spr, getColumnIndex(spr,"FactOrderNo"), xRow)
     If  getColumnIndex(spr,"FactOrderName") > -1 then z2345.FactOrderName = getDataM(spr, getColumnIndex(spr,"FactOrderName"), xRow)
     If  getColumnIndex(spr,"seSeason") > -1 then z2345.seSeason = getDataM(spr, getColumnIndex(spr,"seSeason"), xRow)
     If  getColumnIndex(spr,"cdSeason") > -1 then z2345.cdSeason = getDataM(spr, getColumnIndex(spr,"cdSeason"), xRow)
     If  getColumnIndex(spr,"CustomerCode") > -1 then z2345.CustomerCode = getDataM(spr, getColumnIndex(spr,"CustomerCode"), xRow)
     If  getColumnIndex(spr,"DateAccept") > -1 then z2345.DateAccept = getDataM(spr, getColumnIndex(spr,"DateAccept"), xRow)
     If  getColumnIndex(spr,"CheckInPurchasingOrder") > -1 then z2345.CheckInPurchasingOrder = getDataM(spr, getColumnIndex(spr,"CheckInPurchasingOrder"), xRow)
     If  getColumnIndex(spr,"CheckOutPurchasingOrder") > -1 then z2345.CheckOutPurchasingOrder = getDataM(spr, getColumnIndex(spr,"CheckOutPurchasingOrder"), xRow)
     If  getColumnIndex(spr,"CheckProcessType") > -1 then z2345.CheckProcessType = getDataM(spr, getColumnIndex(spr,"CheckProcessType"), xRow)
     If  getColumnIndex(spr,"CheckIOType") > -1 then z2345.CheckIOType = getDataM(spr, getColumnIndex(spr,"CheckIOType"), xRow)
     If  getColumnIndex(spr,"CheckMaterialType") > -1 then z2345.CheckMaterialType = getDataM(spr, getColumnIndex(spr,"CheckMaterialType"), xRow)
     If  getColumnIndex(spr,"CheckMarketType") > -1 then z2345.CheckMarketType = getDataM(spr, getColumnIndex(spr,"CheckMarketType"), xRow)
     If  getColumnIndex(spr,"CheckRelationType") > -1 then z2345.CheckRelationType = getDataM(spr, getColumnIndex(spr,"CheckRelationType"), xRow)
     If  getColumnIndex(spr,"SupplierCode") > -1 then z2345.SupplierCode = getDataM(spr, getColumnIndex(spr,"SupplierCode"), xRow)
     If  getColumnIndex(spr,"selUnitPrice") > -1 then z2345.selUnitPrice = getDataM(spr, getColumnIndex(spr,"selUnitPrice"), xRow)
     If  getColumnIndex(spr,"cdUnitPrice") > -1 then z2345.cdUnitPrice = getDataM(spr, getColumnIndex(spr,"cdUnitPrice"), xRow)
     If  getColumnIndex(spr,"PriceExchange") > -1 then z2345.PriceExchange = Cdecp(getDataM(spr, getColumnIndex(spr,"PriceExchange"), xRow))
     If  getColumnIndex(spr,"DateExchange") > -1 then z2345.DateExchange = getDataM(spr, getColumnIndex(spr,"DateExchange"), xRow)
     If  getColumnIndex(spr,"seOrigin") > -1 then z2345.seOrigin = getDataM(spr, getColumnIndex(spr,"seOrigin"), xRow)
     If  getColumnIndex(spr,"cdOrigin") > -1 then z2345.cdOrigin = getDataM(spr, getColumnIndex(spr,"cdOrigin"), xRow)
     If  getColumnIndex(spr,"seCommercialTerm") > -1 then z2345.seCommercialTerm = getDataM(spr, getColumnIndex(spr,"seCommercialTerm"), xRow)
     If  getColumnIndex(spr,"cdCommercialTerm") > -1 then z2345.cdCommercialTerm = getDataM(spr, getColumnIndex(spr,"cdCommercialTerm"), xRow)
     If  getColumnIndex(spr,"seDeliveryTerm") > -1 then z2345.seDeliveryTerm = getDataM(spr, getColumnIndex(spr,"seDeliveryTerm"), xRow)
     If  getColumnIndex(spr,"cdDeliveryTerm") > -1 then z2345.cdDeliveryTerm = getDataM(spr, getColumnIndex(spr,"cdDeliveryTerm"), xRow)
     If  getColumnIndex(spr,"sePaymentTerm") > -1 then z2345.sePaymentTerm = getDataM(spr, getColumnIndex(spr,"sePaymentTerm"), xRow)
     If  getColumnIndex(spr,"cdPaymentTerm") > -1 then z2345.cdPaymentTerm = getDataM(spr, getColumnIndex(spr,"cdPaymentTerm"), xRow)
     If  getColumnIndex(spr,"sePaymentCondition") > -1 then z2345.sePaymentCondition = getDataM(spr, getColumnIndex(spr,"sePaymentCondition"), xRow)
     If  getColumnIndex(spr,"cdPaymentCondition") > -1 then z2345.cdPaymentCondition = getDataM(spr, getColumnIndex(spr,"cdPaymentCondition"), xRow)
     If  getColumnIndex(spr,"sePaymentTime") > -1 then z2345.sePaymentTime = getDataM(spr, getColumnIndex(spr,"sePaymentTime"), xRow)
     If  getColumnIndex(spr,"cdPaymentTime") > -1 then z2345.cdPaymentTime = getDataM(spr, getColumnIndex(spr,"cdPaymentTime"), xRow)
     If  getColumnIndex(spr,"sePaymentDay") > -1 then z2345.sePaymentDay = getDataM(spr, getColumnIndex(spr,"sePaymentDay"), xRow)
     If  getColumnIndex(spr,"cdPaymentDay") > -1 then z2345.cdPaymentDay = getDataM(spr, getColumnIndex(spr,"cdPaymentDay"), xRow)
     If  getColumnIndex(spr,"seBuyingType") > -1 then z2345.seBuyingType = getDataM(spr, getColumnIndex(spr,"seBuyingType"), xRow)
     If  getColumnIndex(spr,"cdBuyingType") > -1 then z2345.cdBuyingType = getDataM(spr, getColumnIndex(spr,"cdBuyingType"), xRow)
     If  getColumnIndex(spr,"QualityRequest") > -1 then z2345.QualityRequest = getDataM(spr, getColumnIndex(spr,"QualityRequest"), xRow)
     If  getColumnIndex(spr,"ContractNo") > -1 then z2345.ContractNo = getDataM(spr, getColumnIndex(spr,"ContractNo"), xRow)
     If  getColumnIndex(spr,"Tolerance") > -1 then z2345.Tolerance = getDataM(spr, getColumnIndex(spr,"Tolerance"), xRow)
     If  getColumnIndex(spr,"Destination") > -1 then z2345.Destination = getDataM(spr, getColumnIndex(spr,"Destination"), xRow)
     If  getColumnIndex(spr,"InchargePurchasing") > -1 then z2345.InchargePurchasing = getDataM(spr, getColumnIndex(spr,"InchargePurchasing"), xRow)
     If  getColumnIndex(spr,"AmountPurchasingEX") > -1 then z2345.AmountPurchasingEX = Cdecp(getDataM(spr, getColumnIndex(spr,"AmountPurchasingEX"), xRow))
     If  getColumnIndex(spr,"AmountPurchasingVND") > -1 then z2345.AmountPurchasingVND = Cdecp(getDataM(spr, getColumnIndex(spr,"AmountPurchasingVND"), xRow))
     If  getColumnIndex(spr,"AmountTaxEX") > -1 then z2345.AmountTaxEX = Cdecp(getDataM(spr, getColumnIndex(spr,"AmountTaxEX"), xRow))
     If  getColumnIndex(spr,"AmountTaxVND") > -1 then z2345.AmountTaxVND = Cdecp(getDataM(spr, getColumnIndex(spr,"AmountTaxVND"), xRow))
     If  getColumnIndex(spr,"AmountExpenseUSD") > -1 then z2345.AmountExpenseUSD = Cdecp(getDataM(spr, getColumnIndex(spr,"AmountExpenseUSD"), xRow))
     If  getColumnIndex(spr,"AmountExpenseVND") > -1 then z2345.AmountExpenseVND = Cdecp(getDataM(spr, getColumnIndex(spr,"AmountExpenseVND"), xRow))
     If  getColumnIndex(spr,"AmountTotalEX") > -1 then z2345.AmountTotalEX = Cdecp(getDataM(spr, getColumnIndex(spr,"AmountTotalEX"), xRow))
     If  getColumnIndex(spr,"AmountTotalVND") > -1 then z2345.AmountTotalVND = Cdecp(getDataM(spr, getColumnIndex(spr,"AmountTotalVND"), xRow))
     If  getColumnIndex(spr,"DateStart") > -1 then z2345.DateStart = getDataM(spr, getColumnIndex(spr,"DateStart"), xRow)
     If  getColumnIndex(spr,"DateEstimate") > -1 then z2345.DateEstimate = getDataM(spr, getColumnIndex(spr,"DateEstimate"), xRow)
     If  getColumnIndex(spr,"DateDelivery") > -1 then z2345.DateDelivery = getDataM(spr, getColumnIndex(spr,"DateDelivery"), xRow)
     If  getColumnIndex(spr,"TimeInsert") > -1 then z2345.TimeInsert = getDataM(spr, getColumnIndex(spr,"TimeInsert"), xRow)
     If  getColumnIndex(spr,"TimeUpdate") > -1 then z2345.TimeUpdate = getDataM(spr, getColumnIndex(spr,"TimeUpdate"), xRow)
     If  getColumnIndex(spr,"DateInsert") > -1 then z2345.DateInsert = getDataM(spr, getColumnIndex(spr,"DateInsert"), xRow)
     If  getColumnIndex(spr,"DateUpdate") > -1 then z2345.DateUpdate = getDataM(spr, getColumnIndex(spr,"DateUpdate"), xRow)
     If  getColumnIndex(spr,"InchargeInsert") > -1 then z2345.InchargeInsert = getDataM(spr, getColumnIndex(spr,"InchargeInsert"), xRow)
     If  getColumnIndex(spr,"InchargeUpdate") > -1 then z2345.InchargeUpdate = getDataM(spr, getColumnIndex(spr,"InchargeUpdate"), xRow)
     If  getColumnIndex(spr,"CheckComplete") > -1 then z2345.CheckComplete = getDataM(spr, getColumnIndex(spr,"CheckComplete"), xRow)
     If  getColumnIndex(spr,"PurchasingOrderNo") > -1 then z2345.PurchasingOrderNo = getDataM(spr, getColumnIndex(spr,"PurchasingOrderNo"), xRow)
     If  getColumnIndex(spr,"SalesOrderNo") > -1 then z2345.SalesOrderNo = getDataM(spr, getColumnIndex(spr,"SalesOrderNo"), xRow)
     If  getColumnIndex(spr,"SalesOrderSeq") > -1 then z2345.SalesOrderSeq = getDataM(spr, getColumnIndex(spr,"SalesOrderSeq"), xRow)
     If  getColumnIndex(spr,"SalesOrderSno") > -1 then z2345.SalesOrderSno = getDataM(spr, getColumnIndex(spr,"SalesOrderSno"), xRow)
     If  getColumnIndex(spr,"Remark") > -1 then z2345.Remark = getDataM(spr, getColumnIndex(spr,"Remark"), xRow)
     If  getColumnIndex(spr,"ComponentList") > -1 then z2345.ComponentList = getDataM(spr, getColumnIndex(spr,"ComponentList"), xRow)
     If  getColumnIndex(spr,"seSite") > -1 then z2345.seSite = getDataM(spr, getColumnIndex(spr,"seSite"), xRow)
     If  getColumnIndex(spr,"cdSite") > -1 then z2345.cdSite = getDataM(spr, getColumnIndex(spr,"cdSite"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K2345_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K2345_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z2345 As T2345_AREA,CheckClear as Boolean,FACTORDERNO AS String) as Boolean

K2345_MOVE = False

Try
    If READ_PFK2345(FACTORDERNO) = True Then
                z2345 = D2345
		K2345_MOVE = True
		else
	If CheckClear  = True then z2345 = nothing
     End If

     If  getColumnIndex(spr,"FactOrderNo") > -1 then z2345.FactOrderNo = getDataM(spr, getColumnIndex(spr,"FactOrderNo"), xRow)
     If  getColumnIndex(spr,"FactOrderName") > -1 then z2345.FactOrderName = getDataM(spr, getColumnIndex(spr,"FactOrderName"), xRow)
     If  getColumnIndex(spr,"seSeason") > -1 then z2345.seSeason = getDataM(spr, getColumnIndex(spr,"seSeason"), xRow)
     If  getColumnIndex(spr,"cdSeason") > -1 then z2345.cdSeason = getDataM(spr, getColumnIndex(spr,"cdSeason"), xRow)
     If  getColumnIndex(spr,"CustomerCode") > -1 then z2345.CustomerCode = getDataM(spr, getColumnIndex(spr,"CustomerCode"), xRow)
     If  getColumnIndex(spr,"DateAccept") > -1 then z2345.DateAccept = getDataM(spr, getColumnIndex(spr,"DateAccept"), xRow)
     If  getColumnIndex(spr,"CheckInPurchasingOrder") > -1 then z2345.CheckInPurchasingOrder = getDataM(spr, getColumnIndex(spr,"CheckInPurchasingOrder"), xRow)
     If  getColumnIndex(spr,"CheckOutPurchasingOrder") > -1 then z2345.CheckOutPurchasingOrder = getDataM(spr, getColumnIndex(spr,"CheckOutPurchasingOrder"), xRow)
     If  getColumnIndex(spr,"CheckProcessType") > -1 then z2345.CheckProcessType = getDataM(spr, getColumnIndex(spr,"CheckProcessType"), xRow)
     If  getColumnIndex(spr,"CheckIOType") > -1 then z2345.CheckIOType = getDataM(spr, getColumnIndex(spr,"CheckIOType"), xRow)
     If  getColumnIndex(spr,"CheckMaterialType") > -1 then z2345.CheckMaterialType = getDataM(spr, getColumnIndex(spr,"CheckMaterialType"), xRow)
     If  getColumnIndex(spr,"CheckMarketType") > -1 then z2345.CheckMarketType = getDataM(spr, getColumnIndex(spr,"CheckMarketType"), xRow)
     If  getColumnIndex(spr,"CheckRelationType") > -1 then z2345.CheckRelationType = getDataM(spr, getColumnIndex(spr,"CheckRelationType"), xRow)
     If  getColumnIndex(spr,"SupplierCode") > -1 then z2345.SupplierCode = getDataM(spr, getColumnIndex(spr,"SupplierCode"), xRow)
     If  getColumnIndex(spr,"selUnitPrice") > -1 then z2345.selUnitPrice = getDataM(spr, getColumnIndex(spr,"selUnitPrice"), xRow)
     If  getColumnIndex(spr,"cdUnitPrice") > -1 then z2345.cdUnitPrice = getDataM(spr, getColumnIndex(spr,"cdUnitPrice"), xRow)
     If  getColumnIndex(spr,"PriceExchange") > -1 then z2345.PriceExchange = Cdecp(getDataM(spr, getColumnIndex(spr,"PriceExchange"), xRow))
     If  getColumnIndex(spr,"DateExchange") > -1 then z2345.DateExchange = getDataM(spr, getColumnIndex(spr,"DateExchange"), xRow)
     If  getColumnIndex(spr,"seOrigin") > -1 then z2345.seOrigin = getDataM(spr, getColumnIndex(spr,"seOrigin"), xRow)
     If  getColumnIndex(spr,"cdOrigin") > -1 then z2345.cdOrigin = getDataM(spr, getColumnIndex(spr,"cdOrigin"), xRow)
     If  getColumnIndex(spr,"seCommercialTerm") > -1 then z2345.seCommercialTerm = getDataM(spr, getColumnIndex(spr,"seCommercialTerm"), xRow)
     If  getColumnIndex(spr,"cdCommercialTerm") > -1 then z2345.cdCommercialTerm = getDataM(spr, getColumnIndex(spr,"cdCommercialTerm"), xRow)
     If  getColumnIndex(spr,"seDeliveryTerm") > -1 then z2345.seDeliveryTerm = getDataM(spr, getColumnIndex(spr,"seDeliveryTerm"), xRow)
     If  getColumnIndex(spr,"cdDeliveryTerm") > -1 then z2345.cdDeliveryTerm = getDataM(spr, getColumnIndex(spr,"cdDeliveryTerm"), xRow)
     If  getColumnIndex(spr,"sePaymentTerm") > -1 then z2345.sePaymentTerm = getDataM(spr, getColumnIndex(spr,"sePaymentTerm"), xRow)
     If  getColumnIndex(spr,"cdPaymentTerm") > -1 then z2345.cdPaymentTerm = getDataM(spr, getColumnIndex(spr,"cdPaymentTerm"), xRow)
     If  getColumnIndex(spr,"sePaymentCondition") > -1 then z2345.sePaymentCondition = getDataM(spr, getColumnIndex(spr,"sePaymentCondition"), xRow)
     If  getColumnIndex(spr,"cdPaymentCondition") > -1 then z2345.cdPaymentCondition = getDataM(spr, getColumnIndex(spr,"cdPaymentCondition"), xRow)
     If  getColumnIndex(spr,"sePaymentTime") > -1 then z2345.sePaymentTime = getDataM(spr, getColumnIndex(spr,"sePaymentTime"), xRow)
     If  getColumnIndex(spr,"cdPaymentTime") > -1 then z2345.cdPaymentTime = getDataM(spr, getColumnIndex(spr,"cdPaymentTime"), xRow)
     If  getColumnIndex(spr,"sePaymentDay") > -1 then z2345.sePaymentDay = getDataM(spr, getColumnIndex(spr,"sePaymentDay"), xRow)
     If  getColumnIndex(spr,"cdPaymentDay") > -1 then z2345.cdPaymentDay = getDataM(spr, getColumnIndex(spr,"cdPaymentDay"), xRow)
     If  getColumnIndex(spr,"seBuyingType") > -1 then z2345.seBuyingType = getDataM(spr, getColumnIndex(spr,"seBuyingType"), xRow)
     If  getColumnIndex(spr,"cdBuyingType") > -1 then z2345.cdBuyingType = getDataM(spr, getColumnIndex(spr,"cdBuyingType"), xRow)
     If  getColumnIndex(spr,"QualityRequest") > -1 then z2345.QualityRequest = getDataM(spr, getColumnIndex(spr,"QualityRequest"), xRow)
     If  getColumnIndex(spr,"ContractNo") > -1 then z2345.ContractNo = getDataM(spr, getColumnIndex(spr,"ContractNo"), xRow)
     If  getColumnIndex(spr,"Tolerance") > -1 then z2345.Tolerance = getDataM(spr, getColumnIndex(spr,"Tolerance"), xRow)
     If  getColumnIndex(spr,"Destination") > -1 then z2345.Destination = getDataM(spr, getColumnIndex(spr,"Destination"), xRow)
     If  getColumnIndex(spr,"InchargePurchasing") > -1 then z2345.InchargePurchasing = getDataM(spr, getColumnIndex(spr,"InchargePurchasing"), xRow)
     If  getColumnIndex(spr,"AmountPurchasingEX") > -1 then z2345.AmountPurchasingEX = Cdecp(getDataM(spr, getColumnIndex(spr,"AmountPurchasingEX"), xRow))
     If  getColumnIndex(spr,"AmountPurchasingVND") > -1 then z2345.AmountPurchasingVND = Cdecp(getDataM(spr, getColumnIndex(spr,"AmountPurchasingVND"), xRow))
     If  getColumnIndex(spr,"AmountTaxEX") > -1 then z2345.AmountTaxEX = Cdecp(getDataM(spr, getColumnIndex(spr,"AmountTaxEX"), xRow))
     If  getColumnIndex(spr,"AmountTaxVND") > -1 then z2345.AmountTaxVND = Cdecp(getDataM(spr, getColumnIndex(spr,"AmountTaxVND"), xRow))
     If  getColumnIndex(spr,"AmountExpenseUSD") > -1 then z2345.AmountExpenseUSD = Cdecp(getDataM(spr, getColumnIndex(spr,"AmountExpenseUSD"), xRow))
     If  getColumnIndex(spr,"AmountExpenseVND") > -1 then z2345.AmountExpenseVND = Cdecp(getDataM(spr, getColumnIndex(spr,"AmountExpenseVND"), xRow))
     If  getColumnIndex(spr,"AmountTotalEX") > -1 then z2345.AmountTotalEX = Cdecp(getDataM(spr, getColumnIndex(spr,"AmountTotalEX"), xRow))
     If  getColumnIndex(spr,"AmountTotalVND") > -1 then z2345.AmountTotalVND = Cdecp(getDataM(spr, getColumnIndex(spr,"AmountTotalVND"), xRow))
     If  getColumnIndex(spr,"DateStart") > -1 then z2345.DateStart = getDataM(spr, getColumnIndex(spr,"DateStart"), xRow)
     If  getColumnIndex(spr,"DateEstimate") > -1 then z2345.DateEstimate = getDataM(spr, getColumnIndex(spr,"DateEstimate"), xRow)
     If  getColumnIndex(spr,"DateDelivery") > -1 then z2345.DateDelivery = getDataM(spr, getColumnIndex(spr,"DateDelivery"), xRow)
     If  getColumnIndex(spr,"TimeInsert") > -1 then z2345.TimeInsert = getDataM(spr, getColumnIndex(spr,"TimeInsert"), xRow)
     If  getColumnIndex(spr,"TimeUpdate") > -1 then z2345.TimeUpdate = getDataM(spr, getColumnIndex(spr,"TimeUpdate"), xRow)
     If  getColumnIndex(spr,"DateInsert") > -1 then z2345.DateInsert = getDataM(spr, getColumnIndex(spr,"DateInsert"), xRow)
     If  getColumnIndex(spr,"DateUpdate") > -1 then z2345.DateUpdate = getDataM(spr, getColumnIndex(spr,"DateUpdate"), xRow)
     If  getColumnIndex(spr,"InchargeInsert") > -1 then z2345.InchargeInsert = getDataM(spr, getColumnIndex(spr,"InchargeInsert"), xRow)
     If  getColumnIndex(spr,"InchargeUpdate") > -1 then z2345.InchargeUpdate = getDataM(spr, getColumnIndex(spr,"InchargeUpdate"), xRow)
     If  getColumnIndex(spr,"CheckComplete") > -1 then z2345.CheckComplete = getDataM(spr, getColumnIndex(spr,"CheckComplete"), xRow)
     If  getColumnIndex(spr,"PurchasingOrderNo") > -1 then z2345.PurchasingOrderNo = getDataM(spr, getColumnIndex(spr,"PurchasingOrderNo"), xRow)
     If  getColumnIndex(spr,"SalesOrderNo") > -1 then z2345.SalesOrderNo = getDataM(spr, getColumnIndex(spr,"SalesOrderNo"), xRow)
     If  getColumnIndex(spr,"SalesOrderSeq") > -1 then z2345.SalesOrderSeq = getDataM(spr, getColumnIndex(spr,"SalesOrderSeq"), xRow)
     If  getColumnIndex(spr,"SalesOrderSno") > -1 then z2345.SalesOrderSno = getDataM(spr, getColumnIndex(spr,"SalesOrderSno"), xRow)
     If  getColumnIndex(spr,"Remark") > -1 then z2345.Remark = getDataM(spr, getColumnIndex(spr,"Remark"), xRow)
     If  getColumnIndex(spr,"ComponentList") > -1 then z2345.ComponentList = getDataM(spr, getColumnIndex(spr,"ComponentList"), xRow)
     If  getColumnIndex(spr,"seSite") > -1 then z2345.seSite = getDataM(spr, getColumnIndex(spr,"seSite"), xRow)
     If  getColumnIndex(spr,"cdSite") > -1 then z2345.cdSite = getDataM(spr, getColumnIndex(spr,"cdSite"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K2345_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K2345_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z2345 As T2345_AREA, Job as String, FACTORDERNO AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K2345_MOVE = False

Try
    If READ_PFK2345(FACTORDERNO) = True Then
                z2345 = D2345
		K2345_MOVE = True
		else
	z2345 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK2345")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "FACTORDERNO":z2345.FactOrderNo = Children(i).Code
   Case "FACTORDERNAME":z2345.FactOrderName = Children(i).Code
   Case "SESEASON":z2345.seSeason = Children(i).Code
   Case "CDSEASON":z2345.cdSeason = Children(i).Code
   Case "CUSTOMERCODE":z2345.CustomerCode = Children(i).Code
   Case "DATEACCEPT":z2345.DateAccept = Children(i).Code
   Case "CHECKINPURCHASINGORDER":z2345.CheckInPurchasingOrder = Children(i).Code
   Case "CHECKOUTPURCHASINGORDER":z2345.CheckOutPurchasingOrder = Children(i).Code
   Case "CHECKPROCESSTYPE":z2345.CheckProcessType = Children(i).Code
   Case "CHECKIOTYPE":z2345.CheckIOType = Children(i).Code
   Case "CHECKMATERIALTYPE":z2345.CheckMaterialType = Children(i).Code
   Case "CHECKMARKETTYPE":z2345.CheckMarketType = Children(i).Code
   Case "CHECKRELATIONTYPE":z2345.CheckRelationType = Children(i).Code
   Case "SUPPLIERCODE":z2345.SupplierCode = Children(i).Code
   Case "SELUNITPRICE":z2345.selUnitPrice = Children(i).Code
   Case "CDUNITPRICE":z2345.cdUnitPrice = Children(i).Code
   Case "PRICEEXCHANGE":z2345.PriceExchange = Children(i).Code
   Case "DATEEXCHANGE":z2345.DateExchange = Children(i).Code
   Case "SEORIGIN":z2345.seOrigin = Children(i).Code
   Case "CDORIGIN":z2345.cdOrigin = Children(i).Code
   Case "SECOMMERCIALTERM":z2345.seCommercialTerm = Children(i).Code
   Case "CDCOMMERCIALTERM":z2345.cdCommercialTerm = Children(i).Code
   Case "SEDELIVERYTERM":z2345.seDeliveryTerm = Children(i).Code
   Case "CDDELIVERYTERM":z2345.cdDeliveryTerm = Children(i).Code
   Case "SEPAYMENTTERM":z2345.sePaymentTerm = Children(i).Code
   Case "CDPAYMENTTERM":z2345.cdPaymentTerm = Children(i).Code
   Case "SEPAYMENTCONDITION":z2345.sePaymentCondition = Children(i).Code
   Case "CDPAYMENTCONDITION":z2345.cdPaymentCondition = Children(i).Code
   Case "SEPAYMENTTIME":z2345.sePaymentTime = Children(i).Code
   Case "CDPAYMENTTIME":z2345.cdPaymentTime = Children(i).Code
   Case "SEPAYMENTDAY":z2345.sePaymentDay = Children(i).Code
   Case "CDPAYMENTDAY":z2345.cdPaymentDay = Children(i).Code
   Case "SEBUYINGTYPE":z2345.seBuyingType = Children(i).Code
   Case "CDBUYINGTYPE":z2345.cdBuyingType = Children(i).Code
   Case "QUALITYREQUEST":z2345.QualityRequest = Children(i).Code
   Case "CONTRACTNO":z2345.ContractNo = Children(i).Code
   Case "TOLERANCE":z2345.Tolerance = Children(i).Code
   Case "DESTINATION":z2345.Destination = Children(i).Code
   Case "INCHARGEPURCHASING":z2345.InchargePurchasing = Children(i).Code
   Case "AMOUNTPURCHASINGEX":z2345.AmountPurchasingEX = Children(i).Code
   Case "AMOUNTPURCHASINGVND":z2345.AmountPurchasingVND = Children(i).Code
   Case "AMOUNTTAXEX":z2345.AmountTaxEX = Children(i).Code
   Case "AMOUNTTAXVND":z2345.AmountTaxVND = Children(i).Code
   Case "AMOUNTEXPENSEUSD":z2345.AmountExpenseUSD = Children(i).Code
   Case "AMOUNTEXPENSEVND":z2345.AmountExpenseVND = Children(i).Code
   Case "AMOUNTTOTALEX":z2345.AmountTotalEX = Children(i).Code
   Case "AMOUNTTOTALVND":z2345.AmountTotalVND = Children(i).Code
   Case "DATESTART":z2345.DateStart = Children(i).Code
   Case "DATEESTIMATE":z2345.DateEstimate = Children(i).Code
   Case "DATEDELIVERY":z2345.DateDelivery = Children(i).Code
   Case "TIMEINSERT":z2345.TimeInsert = Children(i).Code
   Case "TIMEUPDATE":z2345.TimeUpdate = Children(i).Code
   Case "DATEINSERT":z2345.DateInsert = Children(i).Code
   Case "DATEUPDATE":z2345.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z2345.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z2345.InchargeUpdate = Children(i).Code
   Case "CHECKCOMPLETE":z2345.CheckComplete = Children(i).Code
   Case "PURCHASINGORDERNO":z2345.PurchasingOrderNo = Children(i).Code
   Case "SALESORDERNO":z2345.SalesOrderNo = Children(i).Code
   Case "SALESORDERSEQ":z2345.SalesOrderSeq = Children(i).Code
   Case "SALESORDERSNO":z2345.SalesOrderSno = Children(i).Code
   Case "REMARK":z2345.Remark = Children(i).Code
   Case "COMPONENTLIST":z2345.ComponentList = Children(i).Code
   Case "SESITE":z2345.seSite = Children(i).Code
   Case "CDSITE":z2345.cdSite = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "FACTORDERNO":z2345.FactOrderNo = Children(i).Data
   Case "FACTORDERNAME":z2345.FactOrderName = Children(i).Data
   Case "SESEASON":z2345.seSeason = Children(i).Data
   Case "CDSEASON":z2345.cdSeason = Children(i).Data
   Case "CUSTOMERCODE":z2345.CustomerCode = Children(i).Data
   Case "DATEACCEPT":z2345.DateAccept = Children(i).Data
   Case "CHECKINPURCHASINGORDER":z2345.CheckInPurchasingOrder = Children(i).Data
   Case "CHECKOUTPURCHASINGORDER":z2345.CheckOutPurchasingOrder = Children(i).Data
   Case "CHECKPROCESSTYPE":z2345.CheckProcessType = Children(i).Data
   Case "CHECKIOTYPE":z2345.CheckIOType = Children(i).Data
   Case "CHECKMATERIALTYPE":z2345.CheckMaterialType = Children(i).Data
   Case "CHECKMARKETTYPE":z2345.CheckMarketType = Children(i).Data
   Case "CHECKRELATIONTYPE":z2345.CheckRelationType = Children(i).Data
   Case "SUPPLIERCODE":z2345.SupplierCode = Children(i).Data
   Case "SELUNITPRICE":z2345.selUnitPrice = Children(i).Data
   Case "CDUNITPRICE":z2345.cdUnitPrice = Children(i).Data
   Case "PRICEEXCHANGE":z2345.PriceExchange = Cdecp(Children(i).Data)
   Case "DATEEXCHANGE":z2345.DateExchange = Children(i).Data
   Case "SEORIGIN":z2345.seOrigin = Children(i).Data
   Case "CDORIGIN":z2345.cdOrigin = Children(i).Data
   Case "SECOMMERCIALTERM":z2345.seCommercialTerm = Children(i).Data
   Case "CDCOMMERCIALTERM":z2345.cdCommercialTerm = Children(i).Data
   Case "SEDELIVERYTERM":z2345.seDeliveryTerm = Children(i).Data
   Case "CDDELIVERYTERM":z2345.cdDeliveryTerm = Children(i).Data
   Case "SEPAYMENTTERM":z2345.sePaymentTerm = Children(i).Data
   Case "CDPAYMENTTERM":z2345.cdPaymentTerm = Children(i).Data
   Case "SEPAYMENTCONDITION":z2345.sePaymentCondition = Children(i).Data
   Case "CDPAYMENTCONDITION":z2345.cdPaymentCondition = Children(i).Data
   Case "SEPAYMENTTIME":z2345.sePaymentTime = Children(i).Data
   Case "CDPAYMENTTIME":z2345.cdPaymentTime = Children(i).Data
   Case "SEPAYMENTDAY":z2345.sePaymentDay = Children(i).Data
   Case "CDPAYMENTDAY":z2345.cdPaymentDay = Children(i).Data
   Case "SEBUYINGTYPE":z2345.seBuyingType = Children(i).Data
   Case "CDBUYINGTYPE":z2345.cdBuyingType = Children(i).Data
   Case "QUALITYREQUEST":z2345.QualityRequest = Children(i).Data
   Case "CONTRACTNO":z2345.ContractNo = Children(i).Data
   Case "TOLERANCE":z2345.Tolerance = Children(i).Data
   Case "DESTINATION":z2345.Destination = Children(i).Data
   Case "INCHARGEPURCHASING":z2345.InchargePurchasing = Children(i).Data
   Case "AMOUNTPURCHASINGEX":z2345.AmountPurchasingEX = Cdecp(Children(i).Data)
   Case "AMOUNTPURCHASINGVND":z2345.AmountPurchasingVND = Cdecp(Children(i).Data)
   Case "AMOUNTTAXEX":z2345.AmountTaxEX = Cdecp(Children(i).Data)
   Case "AMOUNTTAXVND":z2345.AmountTaxVND = Cdecp(Children(i).Data)
   Case "AMOUNTEXPENSEUSD":z2345.AmountExpenseUSD = Cdecp(Children(i).Data)
   Case "AMOUNTEXPENSEVND":z2345.AmountExpenseVND = Cdecp(Children(i).Data)
   Case "AMOUNTTOTALEX":z2345.AmountTotalEX = Cdecp(Children(i).Data)
   Case "AMOUNTTOTALVND":z2345.AmountTotalVND = Cdecp(Children(i).Data)
   Case "DATESTART":z2345.DateStart = Children(i).Data
   Case "DATEESTIMATE":z2345.DateEstimate = Children(i).Data
   Case "DATEDELIVERY":z2345.DateDelivery = Children(i).Data
   Case "TIMEINSERT":z2345.TimeInsert = Children(i).Data
   Case "TIMEUPDATE":z2345.TimeUpdate = Children(i).Data
   Case "DATEINSERT":z2345.DateInsert = Children(i).Data
   Case "DATEUPDATE":z2345.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z2345.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z2345.InchargeUpdate = Children(i).Data
   Case "CHECKCOMPLETE":z2345.CheckComplete = Children(i).Data
   Case "PURCHASINGORDERNO":z2345.PurchasingOrderNo = Children(i).Data
   Case "SALESORDERNO":z2345.SalesOrderNo = Children(i).Data
   Case "SALESORDERSEQ":z2345.SalesOrderSeq = Children(i).Data
   Case "SALESORDERSNO":z2345.SalesOrderSno = Children(i).Data
   Case "REMARK":z2345.Remark = Children(i).Data
   Case "COMPONENTLIST":z2345.ComponentList = Children(i).Data
   Case "SESITE":z2345.seSite = Children(i).Data
   Case "CDSITE":z2345.cdSite = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K2345_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K2345_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z2345 As T2345_AREA, Job as String, CheckClear as Boolean, FACTORDERNO AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K2345_MOVE = False

Try
    If READ_PFK2345(FACTORDERNO) = True Then
                z2345 = D2345
		K2345_MOVE = True
		else
	If CheckClear  = True then z2345 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK2345")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "FACTORDERNO":z2345.FactOrderNo = Children(i).Code
   Case "FACTORDERNAME":z2345.FactOrderName = Children(i).Code
   Case "SESEASON":z2345.seSeason = Children(i).Code
   Case "CDSEASON":z2345.cdSeason = Children(i).Code
   Case "CUSTOMERCODE":z2345.CustomerCode = Children(i).Code
   Case "DATEACCEPT":z2345.DateAccept = Children(i).Code
   Case "CHECKINPURCHASINGORDER":z2345.CheckInPurchasingOrder = Children(i).Code
   Case "CHECKOUTPURCHASINGORDER":z2345.CheckOutPurchasingOrder = Children(i).Code
   Case "CHECKPROCESSTYPE":z2345.CheckProcessType = Children(i).Code
   Case "CHECKIOTYPE":z2345.CheckIOType = Children(i).Code
   Case "CHECKMATERIALTYPE":z2345.CheckMaterialType = Children(i).Code
   Case "CHECKMARKETTYPE":z2345.CheckMarketType = Children(i).Code
   Case "CHECKRELATIONTYPE":z2345.CheckRelationType = Children(i).Code
   Case "SUPPLIERCODE":z2345.SupplierCode = Children(i).Code
   Case "SELUNITPRICE":z2345.selUnitPrice = Children(i).Code
   Case "CDUNITPRICE":z2345.cdUnitPrice = Children(i).Code
   Case "PRICEEXCHANGE":z2345.PriceExchange = Children(i).Code
   Case "DATEEXCHANGE":z2345.DateExchange = Children(i).Code
   Case "SEORIGIN":z2345.seOrigin = Children(i).Code
   Case "CDORIGIN":z2345.cdOrigin = Children(i).Code
   Case "SECOMMERCIALTERM":z2345.seCommercialTerm = Children(i).Code
   Case "CDCOMMERCIALTERM":z2345.cdCommercialTerm = Children(i).Code
   Case "SEDELIVERYTERM":z2345.seDeliveryTerm = Children(i).Code
   Case "CDDELIVERYTERM":z2345.cdDeliveryTerm = Children(i).Code
   Case "SEPAYMENTTERM":z2345.sePaymentTerm = Children(i).Code
   Case "CDPAYMENTTERM":z2345.cdPaymentTerm = Children(i).Code
   Case "SEPAYMENTCONDITION":z2345.sePaymentCondition = Children(i).Code
   Case "CDPAYMENTCONDITION":z2345.cdPaymentCondition = Children(i).Code
   Case "SEPAYMENTTIME":z2345.sePaymentTime = Children(i).Code
   Case "CDPAYMENTTIME":z2345.cdPaymentTime = Children(i).Code
   Case "SEPAYMENTDAY":z2345.sePaymentDay = Children(i).Code
   Case "CDPAYMENTDAY":z2345.cdPaymentDay = Children(i).Code
   Case "SEBUYINGTYPE":z2345.seBuyingType = Children(i).Code
   Case "CDBUYINGTYPE":z2345.cdBuyingType = Children(i).Code
   Case "QUALITYREQUEST":z2345.QualityRequest = Children(i).Code
   Case "CONTRACTNO":z2345.ContractNo = Children(i).Code
   Case "TOLERANCE":z2345.Tolerance = Children(i).Code
   Case "DESTINATION":z2345.Destination = Children(i).Code
   Case "INCHARGEPURCHASING":z2345.InchargePurchasing = Children(i).Code
   Case "AMOUNTPURCHASINGEX":z2345.AmountPurchasingEX = Children(i).Code
   Case "AMOUNTPURCHASINGVND":z2345.AmountPurchasingVND = Children(i).Code
   Case "AMOUNTTAXEX":z2345.AmountTaxEX = Children(i).Code
   Case "AMOUNTTAXVND":z2345.AmountTaxVND = Children(i).Code
   Case "AMOUNTEXPENSEUSD":z2345.AmountExpenseUSD = Children(i).Code
   Case "AMOUNTEXPENSEVND":z2345.AmountExpenseVND = Children(i).Code
   Case "AMOUNTTOTALEX":z2345.AmountTotalEX = Children(i).Code
   Case "AMOUNTTOTALVND":z2345.AmountTotalVND = Children(i).Code
   Case "DATESTART":z2345.DateStart = Children(i).Code
   Case "DATEESTIMATE":z2345.DateEstimate = Children(i).Code
   Case "DATEDELIVERY":z2345.DateDelivery = Children(i).Code
   Case "TIMEINSERT":z2345.TimeInsert = Children(i).Code
   Case "TIMEUPDATE":z2345.TimeUpdate = Children(i).Code
   Case "DATEINSERT":z2345.DateInsert = Children(i).Code
   Case "DATEUPDATE":z2345.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z2345.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z2345.InchargeUpdate = Children(i).Code
   Case "CHECKCOMPLETE":z2345.CheckComplete = Children(i).Code
   Case "PURCHASINGORDERNO":z2345.PurchasingOrderNo = Children(i).Code
   Case "SALESORDERNO":z2345.SalesOrderNo = Children(i).Code
   Case "SALESORDERSEQ":z2345.SalesOrderSeq = Children(i).Code
   Case "SALESORDERSNO":z2345.SalesOrderSno = Children(i).Code
   Case "REMARK":z2345.Remark = Children(i).Code
   Case "COMPONENTLIST":z2345.ComponentList = Children(i).Code
   Case "SESITE":z2345.seSite = Children(i).Code
   Case "CDSITE":z2345.cdSite = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "FACTORDERNO":z2345.FactOrderNo = Children(i).Data
   Case "FACTORDERNAME":z2345.FactOrderName = Children(i).Data
   Case "SESEASON":z2345.seSeason = Children(i).Data
   Case "CDSEASON":z2345.cdSeason = Children(i).Data
   Case "CUSTOMERCODE":z2345.CustomerCode = Children(i).Data
   Case "DATEACCEPT":z2345.DateAccept = Children(i).Data
   Case "CHECKINPURCHASINGORDER":z2345.CheckInPurchasingOrder = Children(i).Data
   Case "CHECKOUTPURCHASINGORDER":z2345.CheckOutPurchasingOrder = Children(i).Data
   Case "CHECKPROCESSTYPE":z2345.CheckProcessType = Children(i).Data
   Case "CHECKIOTYPE":z2345.CheckIOType = Children(i).Data
   Case "CHECKMATERIALTYPE":z2345.CheckMaterialType = Children(i).Data
   Case "CHECKMARKETTYPE":z2345.CheckMarketType = Children(i).Data
   Case "CHECKRELATIONTYPE":z2345.CheckRelationType = Children(i).Data
   Case "SUPPLIERCODE":z2345.SupplierCode = Children(i).Data
   Case "SELUNITPRICE":z2345.selUnitPrice = Children(i).Data
   Case "CDUNITPRICE":z2345.cdUnitPrice = Children(i).Data
   Case "PRICEEXCHANGE":z2345.PriceExchange = Cdecp(Children(i).Data)
   Case "DATEEXCHANGE":z2345.DateExchange = Children(i).Data
   Case "SEORIGIN":z2345.seOrigin = Children(i).Data
   Case "CDORIGIN":z2345.cdOrigin = Children(i).Data
   Case "SECOMMERCIALTERM":z2345.seCommercialTerm = Children(i).Data
   Case "CDCOMMERCIALTERM":z2345.cdCommercialTerm = Children(i).Data
   Case "SEDELIVERYTERM":z2345.seDeliveryTerm = Children(i).Data
   Case "CDDELIVERYTERM":z2345.cdDeliveryTerm = Children(i).Data
   Case "SEPAYMENTTERM":z2345.sePaymentTerm = Children(i).Data
   Case "CDPAYMENTTERM":z2345.cdPaymentTerm = Children(i).Data
   Case "SEPAYMENTCONDITION":z2345.sePaymentCondition = Children(i).Data
   Case "CDPAYMENTCONDITION":z2345.cdPaymentCondition = Children(i).Data
   Case "SEPAYMENTTIME":z2345.sePaymentTime = Children(i).Data
   Case "CDPAYMENTTIME":z2345.cdPaymentTime = Children(i).Data
   Case "SEPAYMENTDAY":z2345.sePaymentDay = Children(i).Data
   Case "CDPAYMENTDAY":z2345.cdPaymentDay = Children(i).Data
   Case "SEBUYINGTYPE":z2345.seBuyingType = Children(i).Data
   Case "CDBUYINGTYPE":z2345.cdBuyingType = Children(i).Data
   Case "QUALITYREQUEST":z2345.QualityRequest = Children(i).Data
   Case "CONTRACTNO":z2345.ContractNo = Children(i).Data
   Case "TOLERANCE":z2345.Tolerance = Children(i).Data
   Case "DESTINATION":z2345.Destination = Children(i).Data
   Case "INCHARGEPURCHASING":z2345.InchargePurchasing = Children(i).Data
   Case "AMOUNTPURCHASINGEX":z2345.AmountPurchasingEX = Cdecp(Children(i).Data)
   Case "AMOUNTPURCHASINGVND":z2345.AmountPurchasingVND = Cdecp(Children(i).Data)
   Case "AMOUNTTAXEX":z2345.AmountTaxEX = Cdecp(Children(i).Data)
   Case "AMOUNTTAXVND":z2345.AmountTaxVND = Cdecp(Children(i).Data)
   Case "AMOUNTEXPENSEUSD":z2345.AmountExpenseUSD = Cdecp(Children(i).Data)
   Case "AMOUNTEXPENSEVND":z2345.AmountExpenseVND = Cdecp(Children(i).Data)
   Case "AMOUNTTOTALEX":z2345.AmountTotalEX = Cdecp(Children(i).Data)
   Case "AMOUNTTOTALVND":z2345.AmountTotalVND = Cdecp(Children(i).Data)
   Case "DATESTART":z2345.DateStart = Children(i).Data
   Case "DATEESTIMATE":z2345.DateEstimate = Children(i).Data
   Case "DATEDELIVERY":z2345.DateDelivery = Children(i).Data
   Case "TIMEINSERT":z2345.TimeInsert = Children(i).Data
   Case "TIMEUPDATE":z2345.TimeUpdate = Children(i).Data
   Case "DATEINSERT":z2345.DateInsert = Children(i).Data
   Case "DATEUPDATE":z2345.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z2345.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z2345.InchargeUpdate = Children(i).Data
   Case "CHECKCOMPLETE":z2345.CheckComplete = Children(i).Data
   Case "PURCHASINGORDERNO":z2345.PurchasingOrderNo = Children(i).Data
   Case "SALESORDERNO":z2345.SalesOrderNo = Children(i).Data
   Case "SALESORDERSEQ":z2345.SalesOrderSeq = Children(i).Data
   Case "SALESORDERSNO":z2345.SalesOrderSno = Children(i).Data
   Case "REMARK":z2345.Remark = Children(i).Data
   Case "COMPONENTLIST":z2345.ComponentList = Children(i).Data
   Case "SESITE":z2345.seSite = Children(i).Data
   Case "CDSITE":z2345.cdSite = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K2345_MOVE",vbCritical)
End Try
End Function 
    

'=========================================================================================================================================================
' DATA MOVE FORM NEW AREA
'=========================================================================================================================================================
Public Sub K2345_MOVE(ByRef a2345 As T2345_AREA, ByRef b2345 As T2345_AREA) 
Try
If trim$( a2345.FactOrderNo ) = "" Then b2345.FactOrderNo = ""  Else b2345.FactOrderNo=a2345.FactOrderNo
If trim$( a2345.FactOrderName ) = "" Then b2345.FactOrderName = ""  Else b2345.FactOrderName=a2345.FactOrderName
If trim$( a2345.seSeason ) = "" Then b2345.seSeason = ""  Else b2345.seSeason=a2345.seSeason
If trim$( a2345.cdSeason ) = "" Then b2345.cdSeason = ""  Else b2345.cdSeason=a2345.cdSeason
If trim$( a2345.CustomerCode ) = "" Then b2345.CustomerCode = ""  Else b2345.CustomerCode=a2345.CustomerCode
If trim$( a2345.DateAccept ) = "" Then b2345.DateAccept = ""  Else b2345.DateAccept=a2345.DateAccept
If trim$( a2345.CheckInPurchasingOrder ) = "" Then b2345.CheckInPurchasingOrder = ""  Else b2345.CheckInPurchasingOrder=a2345.CheckInPurchasingOrder
If trim$( a2345.CheckOutPurchasingOrder ) = "" Then b2345.CheckOutPurchasingOrder = ""  Else b2345.CheckOutPurchasingOrder=a2345.CheckOutPurchasingOrder
If trim$( a2345.CheckProcessType ) = "" Then b2345.CheckProcessType = ""  Else b2345.CheckProcessType=a2345.CheckProcessType
If trim$( a2345.CheckIOType ) = "" Then b2345.CheckIOType = ""  Else b2345.CheckIOType=a2345.CheckIOType
If trim$( a2345.CheckMaterialType ) = "" Then b2345.CheckMaterialType = ""  Else b2345.CheckMaterialType=a2345.CheckMaterialType
If trim$( a2345.CheckMarketType ) = "" Then b2345.CheckMarketType = ""  Else b2345.CheckMarketType=a2345.CheckMarketType
If trim$( a2345.CheckRelationType ) = "" Then b2345.CheckRelationType = ""  Else b2345.CheckRelationType=a2345.CheckRelationType
If trim$( a2345.SupplierCode ) = "" Then b2345.SupplierCode = ""  Else b2345.SupplierCode=a2345.SupplierCode
If trim$( a2345.selUnitPrice ) = "" Then b2345.selUnitPrice = ""  Else b2345.selUnitPrice=a2345.selUnitPrice
If trim$( a2345.cdUnitPrice ) = "" Then b2345.cdUnitPrice = ""  Else b2345.cdUnitPrice=a2345.cdUnitPrice
If trim$( a2345.PriceExchange ) = "" Then b2345.PriceExchange = ""  Else b2345.PriceExchange=a2345.PriceExchange
If trim$( a2345.DateExchange ) = "" Then b2345.DateExchange = ""  Else b2345.DateExchange=a2345.DateExchange
If trim$( a2345.seOrigin ) = "" Then b2345.seOrigin = ""  Else b2345.seOrigin=a2345.seOrigin
If trim$( a2345.cdOrigin ) = "" Then b2345.cdOrigin = ""  Else b2345.cdOrigin=a2345.cdOrigin
If trim$( a2345.seCommercialTerm ) = "" Then b2345.seCommercialTerm = ""  Else b2345.seCommercialTerm=a2345.seCommercialTerm
If trim$( a2345.cdCommercialTerm ) = "" Then b2345.cdCommercialTerm = ""  Else b2345.cdCommercialTerm=a2345.cdCommercialTerm
If trim$( a2345.seDeliveryTerm ) = "" Then b2345.seDeliveryTerm = ""  Else b2345.seDeliveryTerm=a2345.seDeliveryTerm
If trim$( a2345.cdDeliveryTerm ) = "" Then b2345.cdDeliveryTerm = ""  Else b2345.cdDeliveryTerm=a2345.cdDeliveryTerm
If trim$( a2345.sePaymentTerm ) = "" Then b2345.sePaymentTerm = ""  Else b2345.sePaymentTerm=a2345.sePaymentTerm
If trim$( a2345.cdPaymentTerm ) = "" Then b2345.cdPaymentTerm = ""  Else b2345.cdPaymentTerm=a2345.cdPaymentTerm
If trim$( a2345.sePaymentCondition ) = "" Then b2345.sePaymentCondition = ""  Else b2345.sePaymentCondition=a2345.sePaymentCondition
If trim$( a2345.cdPaymentCondition ) = "" Then b2345.cdPaymentCondition = ""  Else b2345.cdPaymentCondition=a2345.cdPaymentCondition
If trim$( a2345.sePaymentTime ) = "" Then b2345.sePaymentTime = ""  Else b2345.sePaymentTime=a2345.sePaymentTime
If trim$( a2345.cdPaymentTime ) = "" Then b2345.cdPaymentTime = ""  Else b2345.cdPaymentTime=a2345.cdPaymentTime
If trim$( a2345.sePaymentDay ) = "" Then b2345.sePaymentDay = ""  Else b2345.sePaymentDay=a2345.sePaymentDay
If trim$( a2345.cdPaymentDay ) = "" Then b2345.cdPaymentDay = ""  Else b2345.cdPaymentDay=a2345.cdPaymentDay
If trim$( a2345.seBuyingType ) = "" Then b2345.seBuyingType = ""  Else b2345.seBuyingType=a2345.seBuyingType
If trim$( a2345.cdBuyingType ) = "" Then b2345.cdBuyingType = ""  Else b2345.cdBuyingType=a2345.cdBuyingType
If trim$( a2345.QualityRequest ) = "" Then b2345.QualityRequest = ""  Else b2345.QualityRequest=a2345.QualityRequest
If trim$( a2345.ContractNo ) = "" Then b2345.ContractNo = ""  Else b2345.ContractNo=a2345.ContractNo
If trim$( a2345.Tolerance ) = "" Then b2345.Tolerance = ""  Else b2345.Tolerance=a2345.Tolerance
If trim$( a2345.Destination ) = "" Then b2345.Destination = ""  Else b2345.Destination=a2345.Destination
If trim$( a2345.InchargePurchasing ) = "" Then b2345.InchargePurchasing = ""  Else b2345.InchargePurchasing=a2345.InchargePurchasing
If trim$( a2345.AmountPurchasingEX ) = "" Then b2345.AmountPurchasingEX = ""  Else b2345.AmountPurchasingEX=a2345.AmountPurchasingEX
If trim$( a2345.AmountPurchasingVND ) = "" Then b2345.AmountPurchasingVND = ""  Else b2345.AmountPurchasingVND=a2345.AmountPurchasingVND
If trim$( a2345.AmountTaxEX ) = "" Then b2345.AmountTaxEX = ""  Else b2345.AmountTaxEX=a2345.AmountTaxEX
If trim$( a2345.AmountTaxVND ) = "" Then b2345.AmountTaxVND = ""  Else b2345.AmountTaxVND=a2345.AmountTaxVND
If trim$( a2345.AmountExpenseUSD ) = "" Then b2345.AmountExpenseUSD = ""  Else b2345.AmountExpenseUSD=a2345.AmountExpenseUSD
If trim$( a2345.AmountExpenseVND ) = "" Then b2345.AmountExpenseVND = ""  Else b2345.AmountExpenseVND=a2345.AmountExpenseVND
If trim$( a2345.AmountTotalEX ) = "" Then b2345.AmountTotalEX = ""  Else b2345.AmountTotalEX=a2345.AmountTotalEX
If trim$( a2345.AmountTotalVND ) = "" Then b2345.AmountTotalVND = ""  Else b2345.AmountTotalVND=a2345.AmountTotalVND
If trim$( a2345.DateStart ) = "" Then b2345.DateStart = ""  Else b2345.DateStart=a2345.DateStart
If trim$( a2345.DateEstimate ) = "" Then b2345.DateEstimate = ""  Else b2345.DateEstimate=a2345.DateEstimate
If trim$( a2345.DateDelivery ) = "" Then b2345.DateDelivery = ""  Else b2345.DateDelivery=a2345.DateDelivery
If trim$( a2345.TimeInsert ) = "" Then b2345.TimeInsert = ""  Else b2345.TimeInsert=a2345.TimeInsert
If trim$( a2345.TimeUpdate ) = "" Then b2345.TimeUpdate = ""  Else b2345.TimeUpdate=a2345.TimeUpdate
If trim$( a2345.DateInsert ) = "" Then b2345.DateInsert = ""  Else b2345.DateInsert=a2345.DateInsert
If trim$( a2345.DateUpdate ) = "" Then b2345.DateUpdate = ""  Else b2345.DateUpdate=a2345.DateUpdate
If trim$( a2345.InchargeInsert ) = "" Then b2345.InchargeInsert = ""  Else b2345.InchargeInsert=a2345.InchargeInsert
If trim$( a2345.InchargeUpdate ) = "" Then b2345.InchargeUpdate = ""  Else b2345.InchargeUpdate=a2345.InchargeUpdate
If trim$( a2345.CheckComplete ) = "" Then b2345.CheckComplete = ""  Else b2345.CheckComplete=a2345.CheckComplete
If trim$( a2345.PurchasingOrderNo ) = "" Then b2345.PurchasingOrderNo = ""  Else b2345.PurchasingOrderNo=a2345.PurchasingOrderNo
If trim$( a2345.SalesOrderNo ) = "" Then b2345.SalesOrderNo = ""  Else b2345.SalesOrderNo=a2345.SalesOrderNo
If trim$( a2345.SalesOrderSeq ) = "" Then b2345.SalesOrderSeq = ""  Else b2345.SalesOrderSeq=a2345.SalesOrderSeq
If trim$( a2345.SalesOrderSno ) = "" Then b2345.SalesOrderSno = ""  Else b2345.SalesOrderSno=a2345.SalesOrderSno
If trim$( a2345.Remark ) = "" Then b2345.Remark = ""  Else b2345.Remark=a2345.Remark
If trim$( a2345.ComponentList ) = "" Then b2345.ComponentList = ""  Else b2345.ComponentList=a2345.ComponentList
If trim$( a2345.seSite ) = "" Then b2345.seSite = ""  Else b2345.seSite=a2345.seSite
If trim$( a2345.cdSite ) = "" Then b2345.cdSite = ""  Else b2345.cdSite=a2345.cdSite
Catch ex As Exception
      Call MsgBoxP("K2345_MOVE",vbCritical)
End Try
End Sub 


End Module 
