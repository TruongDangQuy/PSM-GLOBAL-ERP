'=========================================================================================================================================================
'   TABLE : (PFK4901)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K4901

Structure T4901_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	ShippingWorkOrder	 AS String	'			char(9)		*
Public 	ShippingWorkOrderName	 AS String	'			nvarchar(100)
Public 	Status	 AS String	'			char(1)
Public 	CustomerCode	 AS String	'			char(6)
Public 	VendorCode	 AS String	'			char(6)
Public 	AgentCode	 AS String	'			char(6)
Public 	Buyer	 AS String	'			nvarchar(50)
Public 	seOrderGroup	 AS String	'			char(3)
Public 	cdOrderGroup	 AS String	'			char(3)
Public 	seOrderKind	 AS String	'			char(3)
Public 	cdOrderKind	 AS String	'			char(3)
Public 	seOrderType	 AS String	'			char(3)
Public 	cdOrderType	 AS String	'			char(3)
Public 	cdOrderWork	 AS String	'			char(3)
Public 	seOrderWork	 AS String	'			char(3)
Public 	seStateSample	 AS String	'			char(3)
Public 	cdStateSample	 AS String	'			char(3)
Public 	seStateOfficial	 AS String	'			char(3)
Public 	cdStateOfficial	 AS String	'			char(3)
Public 	StatusOrder	 AS String	'			char(1)
Public 	DateOrder	 AS String	'			char(8)
Public 	DateApproval	 AS String	'			char(8)
Public 	DateComplete	 AS String	'			char(8)
Public 	DateCancel	 AS String	'			char(8)
Public 	DatePending	 AS String	'			char(8)
Public 	seUnitPrice	 AS String	'			char(3)
Public 	cdUnitPrice	 AS String	'			char(3)
Public 	PriceExchange	 AS Double	'			decimal
Public 	DateExchange	 AS String	'			char(8)
Public 	DateTransfer	 AS String	'			char(8)
Public 	DateAccept	 AS String	'			char(8)
Public 	StatusTransfer	 AS String	'			char(1)
Public 	ShippingWorkOrderStatus	 AS String	'			char(1)
Public 	seSeason	 AS String	'			char(3)
Public 	cdSeason	 AS String	'			char(3)
Public 	sePaymentTerm	 AS String	'			char(3)
Public 	cdPaymentTerm	 AS String	'			char(3)
Public 	seDeliveryTerm	 AS String	'			char(3)
Public 	cdDeliveryTerm	 AS String	'			char(3)
Public 	seShippingTerm	 AS String	'			char(3)
Public 	cdShippingTerm	 AS String	'			char(3)
Public 	seMarketType	 AS String	'			char(3)
Public 	cdMarketType	 AS String	'			char(3)
Public 	seDepartment	 AS String	'			char(3)
Public 	cdDepartment	 AS String	'			char(3)
Public 	seBrand	 AS String	'			char(3)
Public 	cdBrand	 AS String	'			char(3)
Public 	ContractIn	 AS String	'			nvarchar(100)
Public 	ContractOut	 AS String	'			nvarchar(100)
Public 	Destination	 AS String	'			nvarchar(100)
Public 	CustPoNo	 AS String	'			nvarchar(100)
Public 	InchargeSales	 AS String	'			char(8)
Public 	InchargePPC	 AS String	'			char(8)
Public 	DateInsert	 AS String	'			char(8)
Public 	DateUpdate	 AS String	'			char(8)
Public 	TimeInsert	 AS String	'			char(14)
Public 	TimeUpdate	 AS String	'			char(14)
Public 	TotalQty	 AS Double	'			decimal
Public 	TotalAmount	 AS Double	'			decimal
Public 	TotalCost	 AS Double	'			decimal
Public 	TotalProfit	 AS Double	'			decimal
Public 	AttachID	 AS String	'			char(9)
Public 	RemarkOrder	 AS String	'			nvarchar(1000)
Public 	RemarkCustomer	 AS String	'			nvarchar(1000)
Public 	Remark	 AS String	'			nvarchar(1000)
'=========================================================================================================================================================
End structure

Public D4901 As T4901_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK4901(SHIPPINGWORKORDER AS String) As Boolean
    READ_PFK4901 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK4901 "
    SQL = SQL & " WHERE K4901_ShippingWorkOrder		 = '" & ShippingWorkOrder & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D4901_CLEAR: GoTo SKIP_READ_PFK4901
                
    Call K4901_MOVE(rd)
    READ_PFK4901 = True

SKIP_READ_PFK4901:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK4901",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK4901(SHIPPINGWORKORDER AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK4901 "
    SQL = SQL & " WHERE K4901_ShippingWorkOrder		 = '" & ShippingWorkOrder & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK4901",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK4901(z4901 As T4901_AREA) As Boolean
    WRITE_PFK4901 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z4901)
 
    SQL = " INSERT INTO PFK4901 "
    SQL = SQL & " ( "
    SQL = SQL & " K4901_ShippingWorkOrder," 
    SQL = SQL & " K4901_ShippingWorkOrderName," 
    SQL = SQL & " K4901_Status," 
    SQL = SQL & " K4901_CustomerCode," 
    SQL = SQL & " K4901_VendorCode," 
    SQL = SQL & " K4901_AgentCode," 
    SQL = SQL & " K4901_Buyer," 
    SQL = SQL & " K4901_seOrderGroup," 
    SQL = SQL & " K4901_cdOrderGroup," 
    SQL = SQL & " K4901_seOrderKind," 
    SQL = SQL & " K4901_cdOrderKind," 
    SQL = SQL & " K4901_seOrderType," 
    SQL = SQL & " K4901_cdOrderType," 
    SQL = SQL & " K4901_cdOrderWork," 
    SQL = SQL & " K4901_seOrderWork," 
    SQL = SQL & " K4901_seStateSample," 
    SQL = SQL & " K4901_cdStateSample," 
    SQL = SQL & " K4901_seStateOfficial," 
    SQL = SQL & " K4901_cdStateOfficial," 
    SQL = SQL & " K4901_StatusOrder," 
    SQL = SQL & " K4901_DateOrder," 
    SQL = SQL & " K4901_DateApproval," 
    SQL = SQL & " K4901_DateComplete," 
    SQL = SQL & " K4901_DateCancel," 
    SQL = SQL & " K4901_DatePending," 
    SQL = SQL & " K4901_seUnitPrice," 
    SQL = SQL & " K4901_cdUnitPrice," 
    SQL = SQL & " K4901_PriceExchange," 
    SQL = SQL & " K4901_DateExchange," 
    SQL = SQL & " K4901_DateTransfer," 
    SQL = SQL & " K4901_DateAccept," 
    SQL = SQL & " K4901_StatusTransfer," 
    SQL = SQL & " K4901_ShippingWorkOrderStatus," 
    SQL = SQL & " K4901_seSeason," 
    SQL = SQL & " K4901_cdSeason," 
    SQL = SQL & " K4901_sePaymentTerm," 
    SQL = SQL & " K4901_cdPaymentTerm," 
    SQL = SQL & " K4901_seDeliveryTerm," 
    SQL = SQL & " K4901_cdDeliveryTerm," 
    SQL = SQL & " K4901_seShippingTerm," 
    SQL = SQL & " K4901_cdShippingTerm," 
    SQL = SQL & " K4901_seMarketType," 
    SQL = SQL & " K4901_cdMarketType," 
    SQL = SQL & " K4901_seDepartment," 
    SQL = SQL & " K4901_cdDepartment," 
    SQL = SQL & " K4901_seBrand," 
    SQL = SQL & " K4901_cdBrand," 
    SQL = SQL & " K4901_ContractIn," 
    SQL = SQL & " K4901_ContractOut," 
    SQL = SQL & " K4901_Destination," 
    SQL = SQL & " K4901_CustPoNo," 
    SQL = SQL & " K4901_InchargeSales," 
    SQL = SQL & " K4901_InchargePPC," 
    SQL = SQL & " K4901_DateInsert," 
    SQL = SQL & " K4901_DateUpdate," 
    SQL = SQL & " K4901_TimeInsert," 
    SQL = SQL & " K4901_TimeUpdate," 
    SQL = SQL & " K4901_TotalQty," 
    SQL = SQL & " K4901_TotalAmount," 
    SQL = SQL & " K4901_TotalCost," 
    SQL = SQL & " K4901_TotalProfit," 
    SQL = SQL & " K4901_AttachID," 
    SQL = SQL & " K4901_RemarkOrder," 
    SQL = SQL & " K4901_RemarkCustomer," 
    SQL = SQL & " K4901_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z4901.ShippingWorkOrder) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4901.ShippingWorkOrderName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4901.Status) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4901.CustomerCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4901.VendorCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4901.AgentCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4901.Buyer) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4901.seOrderGroup) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4901.cdOrderGroup) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4901.seOrderKind) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4901.cdOrderKind) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4901.seOrderType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4901.cdOrderType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4901.cdOrderWork) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4901.seOrderWork) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4901.seStateSample) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4901.cdStateSample) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4901.seStateOfficial) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4901.cdStateOfficial) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4901.StatusOrder) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4901.DateOrder) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4901.DateApproval) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4901.DateComplete) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4901.DateCancel) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4901.DatePending) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4901.seUnitPrice) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4901.cdUnitPrice) & "', "  
    SQL = SQL & "   " & FormatSQL(z4901.PriceExchange) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z4901.DateExchange) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4901.DateTransfer) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4901.DateAccept) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4901.StatusTransfer) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4901.ShippingWorkOrderStatus) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4901.seSeason) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4901.cdSeason) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4901.sePaymentTerm) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4901.cdPaymentTerm) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4901.seDeliveryTerm) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4901.cdDeliveryTerm) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4901.seShippingTerm) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4901.cdShippingTerm) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4901.seMarketType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4901.cdMarketType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4901.seDepartment) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4901.cdDepartment) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4901.seBrand) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4901.cdBrand) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4901.ContractIn) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4901.ContractOut) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4901.Destination) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4901.CustPoNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4901.InchargeSales) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4901.InchargePPC) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4901.DateInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4901.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4901.TimeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4901.TimeUpdate) & "', "  
    SQL = SQL & "   " & FormatSQL(z4901.TotalQty) & ", "  
    SQL = SQL & "   " & FormatSQL(z4901.TotalAmount) & ", "  
    SQL = SQL & "   " & FormatSQL(z4901.TotalCost) & ", "  
    SQL = SQL & "   " & FormatSQL(z4901.TotalProfit) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z4901.AttachID) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4901.RemarkOrder) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4901.RemarkCustomer) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4901.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK4901 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK4901",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK4901(z4901 As T4901_AREA) As Boolean
    REWRITE_PFK4901 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z4901)
   
    SQL = " UPDATE PFK4901 SET "
    SQL = SQL & "    K4901_ShippingWorkOrderName      = N'" & FormatSQL(z4901.ShippingWorkOrderName) & "', " 
    SQL = SQL & "    K4901_Status      = N'" & FormatSQL(z4901.Status) & "', " 
    SQL = SQL & "    K4901_CustomerCode      = N'" & FormatSQL(z4901.CustomerCode) & "', " 
    SQL = SQL & "    K4901_VendorCode      = N'" & FormatSQL(z4901.VendorCode) & "', " 
    SQL = SQL & "    K4901_AgentCode      = N'" & FormatSQL(z4901.AgentCode) & "', " 
    SQL = SQL & "    K4901_Buyer      = N'" & FormatSQL(z4901.Buyer) & "', " 
    SQL = SQL & "    K4901_seOrderGroup      = N'" & FormatSQL(z4901.seOrderGroup) & "', " 
    SQL = SQL & "    K4901_cdOrderGroup      = N'" & FormatSQL(z4901.cdOrderGroup) & "', " 
    SQL = SQL & "    K4901_seOrderKind      = N'" & FormatSQL(z4901.seOrderKind) & "', " 
    SQL = SQL & "    K4901_cdOrderKind      = N'" & FormatSQL(z4901.cdOrderKind) & "', " 
    SQL = SQL & "    K4901_seOrderType      = N'" & FormatSQL(z4901.seOrderType) & "', " 
    SQL = SQL & "    K4901_cdOrderType      = N'" & FormatSQL(z4901.cdOrderType) & "', " 
    SQL = SQL & "    K4901_cdOrderWork      = N'" & FormatSQL(z4901.cdOrderWork) & "', " 
    SQL = SQL & "    K4901_seOrderWork      = N'" & FormatSQL(z4901.seOrderWork) & "', " 
    SQL = SQL & "    K4901_seStateSample      = N'" & FormatSQL(z4901.seStateSample) & "', " 
    SQL = SQL & "    K4901_cdStateSample      = N'" & FormatSQL(z4901.cdStateSample) & "', " 
    SQL = SQL & "    K4901_seStateOfficial      = N'" & FormatSQL(z4901.seStateOfficial) & "', " 
    SQL = SQL & "    K4901_cdStateOfficial      = N'" & FormatSQL(z4901.cdStateOfficial) & "', " 
    SQL = SQL & "    K4901_StatusOrder      = N'" & FormatSQL(z4901.StatusOrder) & "', " 
    SQL = SQL & "    K4901_DateOrder      = N'" & FormatSQL(z4901.DateOrder) & "', " 
    SQL = SQL & "    K4901_DateApproval      = N'" & FormatSQL(z4901.DateApproval) & "', " 
    SQL = SQL & "    K4901_DateComplete      = N'" & FormatSQL(z4901.DateComplete) & "', " 
    SQL = SQL & "    K4901_DateCancel      = N'" & FormatSQL(z4901.DateCancel) & "', " 
    SQL = SQL & "    K4901_DatePending      = N'" & FormatSQL(z4901.DatePending) & "', " 
    SQL = SQL & "    K4901_seUnitPrice      = N'" & FormatSQL(z4901.seUnitPrice) & "', " 
    SQL = SQL & "    K4901_cdUnitPrice      = N'" & FormatSQL(z4901.cdUnitPrice) & "', " 
    SQL = SQL & "    K4901_PriceExchange      =  " & FormatSQL(z4901.PriceExchange) & ", " 
    SQL = SQL & "    K4901_DateExchange      = N'" & FormatSQL(z4901.DateExchange) & "', " 
    SQL = SQL & "    K4901_DateTransfer      = N'" & FormatSQL(z4901.DateTransfer) & "', " 
    SQL = SQL & "    K4901_DateAccept      = N'" & FormatSQL(z4901.DateAccept) & "', " 
    SQL = SQL & "    K4901_StatusTransfer      = N'" & FormatSQL(z4901.StatusTransfer) & "', " 
    SQL = SQL & "    K4901_ShippingWorkOrderStatus      = N'" & FormatSQL(z4901.ShippingWorkOrderStatus) & "', " 
    SQL = SQL & "    K4901_seSeason      = N'" & FormatSQL(z4901.seSeason) & "', " 
    SQL = SQL & "    K4901_cdSeason      = N'" & FormatSQL(z4901.cdSeason) & "', " 
    SQL = SQL & "    K4901_sePaymentTerm      = N'" & FormatSQL(z4901.sePaymentTerm) & "', " 
    SQL = SQL & "    K4901_cdPaymentTerm      = N'" & FormatSQL(z4901.cdPaymentTerm) & "', " 
    SQL = SQL & "    K4901_seDeliveryTerm      = N'" & FormatSQL(z4901.seDeliveryTerm) & "', " 
    SQL = SQL & "    K4901_cdDeliveryTerm      = N'" & FormatSQL(z4901.cdDeliveryTerm) & "', " 
    SQL = SQL & "    K4901_seShippingTerm      = N'" & FormatSQL(z4901.seShippingTerm) & "', " 
    SQL = SQL & "    K4901_cdShippingTerm      = N'" & FormatSQL(z4901.cdShippingTerm) & "', " 
    SQL = SQL & "    K4901_seMarketType      = N'" & FormatSQL(z4901.seMarketType) & "', " 
    SQL = SQL & "    K4901_cdMarketType      = N'" & FormatSQL(z4901.cdMarketType) & "', " 
    SQL = SQL & "    K4901_seDepartment      = N'" & FormatSQL(z4901.seDepartment) & "', " 
    SQL = SQL & "    K4901_cdDepartment      = N'" & FormatSQL(z4901.cdDepartment) & "', " 
    SQL = SQL & "    K4901_seBrand      = N'" & FormatSQL(z4901.seBrand) & "', " 
    SQL = SQL & "    K4901_cdBrand      = N'" & FormatSQL(z4901.cdBrand) & "', " 
    SQL = SQL & "    K4901_ContractIn      = N'" & FormatSQL(z4901.ContractIn) & "', " 
    SQL = SQL & "    K4901_ContractOut      = N'" & FormatSQL(z4901.ContractOut) & "', " 
    SQL = SQL & "    K4901_Destination      = N'" & FormatSQL(z4901.Destination) & "', " 
    SQL = SQL & "    K4901_CustPoNo      = N'" & FormatSQL(z4901.CustPoNo) & "', " 
    SQL = SQL & "    K4901_InchargeSales      = N'" & FormatSQL(z4901.InchargeSales) & "', " 
    SQL = SQL & "    K4901_InchargePPC      = N'" & FormatSQL(z4901.InchargePPC) & "', " 
    SQL = SQL & "    K4901_DateInsert      = N'" & FormatSQL(z4901.DateInsert) & "', " 
    SQL = SQL & "    K4901_DateUpdate      = N'" & FormatSQL(z4901.DateUpdate) & "', " 
    SQL = SQL & "    K4901_TimeInsert      = N'" & FormatSQL(z4901.TimeInsert) & "', " 
    SQL = SQL & "    K4901_TimeUpdate      = N'" & FormatSQL(z4901.TimeUpdate) & "', " 
    SQL = SQL & "    K4901_TotalQty      =  " & FormatSQL(z4901.TotalQty) & ", " 
    SQL = SQL & "    K4901_TotalAmount      =  " & FormatSQL(z4901.TotalAmount) & ", " 
    SQL = SQL & "    K4901_TotalCost      =  " & FormatSQL(z4901.TotalCost) & ", " 
    SQL = SQL & "    K4901_TotalProfit      =  " & FormatSQL(z4901.TotalProfit) & ", " 
    SQL = SQL & "    K4901_AttachID      = N'" & FormatSQL(z4901.AttachID) & "', " 
    SQL = SQL & "    K4901_RemarkOrder      = N'" & FormatSQL(z4901.RemarkOrder) & "', " 
    SQL = SQL & "    K4901_RemarkCustomer      = N'" & FormatSQL(z4901.RemarkCustomer) & "', " 
    SQL = SQL & "    K4901_Remark      = N'" & FormatSQL(z4901.Remark) & "'  " 
    SQL = SQL & " WHERE K4901_ShippingWorkOrder		 = '" & z4901.ShippingWorkOrder & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK4901 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK4901",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK4901(z4901 As T4901_AREA) As Boolean
    DELETE_PFK4901 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK4901 "
    SQL = SQL & " WHERE K4901_ShippingWorkOrder		 = '" & z4901.ShippingWorkOrder & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK4901 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK4901",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D4901_CLEAR()
Try
    
   D4901.ShippingWorkOrder = ""
   D4901.ShippingWorkOrderName = ""
   D4901.Status = ""
   D4901.CustomerCode = ""
   D4901.VendorCode = ""
   D4901.AgentCode = ""
   D4901.Buyer = ""
   D4901.seOrderGroup = ""
   D4901.cdOrderGroup = ""
   D4901.seOrderKind = ""
   D4901.cdOrderKind = ""
   D4901.seOrderType = ""
   D4901.cdOrderType = ""
   D4901.cdOrderWork = ""
   D4901.seOrderWork = ""
   D4901.seStateSample = ""
   D4901.cdStateSample = ""
   D4901.seStateOfficial = ""
   D4901.cdStateOfficial = ""
   D4901.StatusOrder = ""
   D4901.DateOrder = ""
   D4901.DateApproval = ""
   D4901.DateComplete = ""
   D4901.DateCancel = ""
   D4901.DatePending = ""
   D4901.seUnitPrice = ""
   D4901.cdUnitPrice = ""
    D4901.PriceExchange = 0 
   D4901.DateExchange = ""
   D4901.DateTransfer = ""
   D4901.DateAccept = ""
   D4901.StatusTransfer = ""
   D4901.ShippingWorkOrderStatus = ""
   D4901.seSeason = ""
   D4901.cdSeason = ""
   D4901.sePaymentTerm = ""
   D4901.cdPaymentTerm = ""
   D4901.seDeliveryTerm = ""
   D4901.cdDeliveryTerm = ""
   D4901.seShippingTerm = ""
   D4901.cdShippingTerm = ""
   D4901.seMarketType = ""
   D4901.cdMarketType = ""
   D4901.seDepartment = ""
   D4901.cdDepartment = ""
   D4901.seBrand = ""
   D4901.cdBrand = ""
   D4901.ContractIn = ""
   D4901.ContractOut = ""
   D4901.Destination = ""
   D4901.CustPoNo = ""
   D4901.InchargeSales = ""
   D4901.InchargePPC = ""
   D4901.DateInsert = ""
   D4901.DateUpdate = ""
   D4901.TimeInsert = ""
   D4901.TimeUpdate = ""
    D4901.TotalQty = 0 
    D4901.TotalAmount = 0 
    D4901.TotalCost = 0 
    D4901.TotalProfit = 0 
   D4901.AttachID = ""
   D4901.RemarkOrder = ""
   D4901.RemarkCustomer = ""
   D4901.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D4901_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x4901 As T4901_AREA)
Try
    
    x4901.ShippingWorkOrder = trim$(  x4901.ShippingWorkOrder)
    x4901.ShippingWorkOrderName = trim$(  x4901.ShippingWorkOrderName)
    x4901.Status = trim$(  x4901.Status)
    x4901.CustomerCode = trim$(  x4901.CustomerCode)
    x4901.VendorCode = trim$(  x4901.VendorCode)
    x4901.AgentCode = trim$(  x4901.AgentCode)
    x4901.Buyer = trim$(  x4901.Buyer)
    x4901.seOrderGroup = trim$(  x4901.seOrderGroup)
    x4901.cdOrderGroup = trim$(  x4901.cdOrderGroup)
    x4901.seOrderKind = trim$(  x4901.seOrderKind)
    x4901.cdOrderKind = trim$(  x4901.cdOrderKind)
    x4901.seOrderType = trim$(  x4901.seOrderType)
    x4901.cdOrderType = trim$(  x4901.cdOrderType)
    x4901.cdOrderWork = trim$(  x4901.cdOrderWork)
    x4901.seOrderWork = trim$(  x4901.seOrderWork)
    x4901.seStateSample = trim$(  x4901.seStateSample)
    x4901.cdStateSample = trim$(  x4901.cdStateSample)
    x4901.seStateOfficial = trim$(  x4901.seStateOfficial)
    x4901.cdStateOfficial = trim$(  x4901.cdStateOfficial)
    x4901.StatusOrder = trim$(  x4901.StatusOrder)
    x4901.DateOrder = trim$(  x4901.DateOrder)
    x4901.DateApproval = trim$(  x4901.DateApproval)
    x4901.DateComplete = trim$(  x4901.DateComplete)
    x4901.DateCancel = trim$(  x4901.DateCancel)
    x4901.DatePending = trim$(  x4901.DatePending)
    x4901.seUnitPrice = trim$(  x4901.seUnitPrice)
    x4901.cdUnitPrice = trim$(  x4901.cdUnitPrice)
    x4901.PriceExchange = trim$(  x4901.PriceExchange)
    x4901.DateExchange = trim$(  x4901.DateExchange)
    x4901.DateTransfer = trim$(  x4901.DateTransfer)
    x4901.DateAccept = trim$(  x4901.DateAccept)
    x4901.StatusTransfer = trim$(  x4901.StatusTransfer)
    x4901.ShippingWorkOrderStatus = trim$(  x4901.ShippingWorkOrderStatus)
    x4901.seSeason = trim$(  x4901.seSeason)
    x4901.cdSeason = trim$(  x4901.cdSeason)
    x4901.sePaymentTerm = trim$(  x4901.sePaymentTerm)
    x4901.cdPaymentTerm = trim$(  x4901.cdPaymentTerm)
    x4901.seDeliveryTerm = trim$(  x4901.seDeliveryTerm)
    x4901.cdDeliveryTerm = trim$(  x4901.cdDeliveryTerm)
    x4901.seShippingTerm = trim$(  x4901.seShippingTerm)
    x4901.cdShippingTerm = trim$(  x4901.cdShippingTerm)
    x4901.seMarketType = trim$(  x4901.seMarketType)
    x4901.cdMarketType = trim$(  x4901.cdMarketType)
    x4901.seDepartment = trim$(  x4901.seDepartment)
    x4901.cdDepartment = trim$(  x4901.cdDepartment)
    x4901.seBrand = trim$(  x4901.seBrand)
    x4901.cdBrand = trim$(  x4901.cdBrand)
    x4901.ContractIn = trim$(  x4901.ContractIn)
    x4901.ContractOut = trim$(  x4901.ContractOut)
    x4901.Destination = trim$(  x4901.Destination)
    x4901.CustPoNo = trim$(  x4901.CustPoNo)
    x4901.InchargeSales = trim$(  x4901.InchargeSales)
    x4901.InchargePPC = trim$(  x4901.InchargePPC)
    x4901.DateInsert = trim$(  x4901.DateInsert)
    x4901.DateUpdate = trim$(  x4901.DateUpdate)
    x4901.TimeInsert = trim$(  x4901.TimeInsert)
    x4901.TimeUpdate = trim$(  x4901.TimeUpdate)
    x4901.TotalQty = trim$(  x4901.TotalQty)
    x4901.TotalAmount = trim$(  x4901.TotalAmount)
    x4901.TotalCost = trim$(  x4901.TotalCost)
    x4901.TotalProfit = trim$(  x4901.TotalProfit)
    x4901.AttachID = trim$(  x4901.AttachID)
    x4901.RemarkOrder = trim$(  x4901.RemarkOrder)
    x4901.RemarkCustomer = trim$(  x4901.RemarkCustomer)
    x4901.Remark = trim$(  x4901.Remark)
     
    If trim$( x4901.ShippingWorkOrder ) = "" Then x4901.ShippingWorkOrder = Space(1) 
    If trim$( x4901.ShippingWorkOrderName ) = "" Then x4901.ShippingWorkOrderName = Space(1) 
    If trim$( x4901.Status ) = "" Then x4901.Status = Space(1) 
    If trim$( x4901.CustomerCode ) = "" Then x4901.CustomerCode = Space(1) 
    If trim$( x4901.VendorCode ) = "" Then x4901.VendorCode = Space(1) 
    If trim$( x4901.AgentCode ) = "" Then x4901.AgentCode = Space(1) 
    If trim$( x4901.Buyer ) = "" Then x4901.Buyer = Space(1) 
    If trim$( x4901.seOrderGroup ) = "" Then x4901.seOrderGroup = Space(1) 
    If trim$( x4901.cdOrderGroup ) = "" Then x4901.cdOrderGroup = Space(1) 
    If trim$( x4901.seOrderKind ) = "" Then x4901.seOrderKind = Space(1) 
    If trim$( x4901.cdOrderKind ) = "" Then x4901.cdOrderKind = Space(1) 
    If trim$( x4901.seOrderType ) = "" Then x4901.seOrderType = Space(1) 
    If trim$( x4901.cdOrderType ) = "" Then x4901.cdOrderType = Space(1) 
    If trim$( x4901.cdOrderWork ) = "" Then x4901.cdOrderWork = Space(1) 
    If trim$( x4901.seOrderWork ) = "" Then x4901.seOrderWork = Space(1) 
    If trim$( x4901.seStateSample ) = "" Then x4901.seStateSample = Space(1) 
    If trim$( x4901.cdStateSample ) = "" Then x4901.cdStateSample = Space(1) 
    If trim$( x4901.seStateOfficial ) = "" Then x4901.seStateOfficial = Space(1) 
    If trim$( x4901.cdStateOfficial ) = "" Then x4901.cdStateOfficial = Space(1) 
    If trim$( x4901.StatusOrder ) = "" Then x4901.StatusOrder = Space(1) 
    If trim$( x4901.DateOrder ) = "" Then x4901.DateOrder = Space(1) 
    If trim$( x4901.DateApproval ) = "" Then x4901.DateApproval = Space(1) 
    If trim$( x4901.DateComplete ) = "" Then x4901.DateComplete = Space(1) 
    If trim$( x4901.DateCancel ) = "" Then x4901.DateCancel = Space(1) 
    If trim$( x4901.DatePending ) = "" Then x4901.DatePending = Space(1) 
    If trim$( x4901.seUnitPrice ) = "" Then x4901.seUnitPrice = Space(1) 
    If trim$( x4901.cdUnitPrice ) = "" Then x4901.cdUnitPrice = Space(1) 
    If trim$( x4901.PriceExchange ) = "" Then x4901.PriceExchange = 0 
    If trim$( x4901.DateExchange ) = "" Then x4901.DateExchange = Space(1) 
    If trim$( x4901.DateTransfer ) = "" Then x4901.DateTransfer = Space(1) 
    If trim$( x4901.DateAccept ) = "" Then x4901.DateAccept = Space(1) 
    If trim$( x4901.StatusTransfer ) = "" Then x4901.StatusTransfer = Space(1) 
    If trim$( x4901.ShippingWorkOrderStatus ) = "" Then x4901.ShippingWorkOrderStatus = Space(1) 
    If trim$( x4901.seSeason ) = "" Then x4901.seSeason = Space(1) 
    If trim$( x4901.cdSeason ) = "" Then x4901.cdSeason = Space(1) 
    If trim$( x4901.sePaymentTerm ) = "" Then x4901.sePaymentTerm = Space(1) 
    If trim$( x4901.cdPaymentTerm ) = "" Then x4901.cdPaymentTerm = Space(1) 
    If trim$( x4901.seDeliveryTerm ) = "" Then x4901.seDeliveryTerm = Space(1) 
    If trim$( x4901.cdDeliveryTerm ) = "" Then x4901.cdDeliveryTerm = Space(1) 
    If trim$( x4901.seShippingTerm ) = "" Then x4901.seShippingTerm = Space(1) 
    If trim$( x4901.cdShippingTerm ) = "" Then x4901.cdShippingTerm = Space(1) 
    If trim$( x4901.seMarketType ) = "" Then x4901.seMarketType = Space(1) 
    If trim$( x4901.cdMarketType ) = "" Then x4901.cdMarketType = Space(1) 
    If trim$( x4901.seDepartment ) = "" Then x4901.seDepartment = Space(1) 
    If trim$( x4901.cdDepartment ) = "" Then x4901.cdDepartment = Space(1) 
    If trim$( x4901.seBrand ) = "" Then x4901.seBrand = Space(1) 
    If trim$( x4901.cdBrand ) = "" Then x4901.cdBrand = Space(1) 
    If trim$( x4901.ContractIn ) = "" Then x4901.ContractIn = Space(1) 
    If trim$( x4901.ContractOut ) = "" Then x4901.ContractOut = Space(1) 
    If trim$( x4901.Destination ) = "" Then x4901.Destination = Space(1) 
    If trim$( x4901.CustPoNo ) = "" Then x4901.CustPoNo = Space(1) 
    If trim$( x4901.InchargeSales ) = "" Then x4901.InchargeSales = Space(1) 
    If trim$( x4901.InchargePPC ) = "" Then x4901.InchargePPC = Space(1) 
    If trim$( x4901.DateInsert ) = "" Then x4901.DateInsert = Space(1) 
    If trim$( x4901.DateUpdate ) = "" Then x4901.DateUpdate = Space(1) 
    If trim$( x4901.TimeInsert ) = "" Then x4901.TimeInsert = Space(1) 
    If trim$( x4901.TimeUpdate ) = "" Then x4901.TimeUpdate = Space(1) 
    If trim$( x4901.TotalQty ) = "" Then x4901.TotalQty = 0 
    If trim$( x4901.TotalAmount ) = "" Then x4901.TotalAmount = 0 
    If trim$( x4901.TotalCost ) = "" Then x4901.TotalCost = 0 
    If trim$( x4901.TotalProfit ) = "" Then x4901.TotalProfit = 0 
    If trim$( x4901.AttachID ) = "" Then x4901.AttachID = Space(1) 
    If trim$( x4901.RemarkOrder ) = "" Then x4901.RemarkOrder = Space(1) 
    If trim$( x4901.RemarkCustomer ) = "" Then x4901.RemarkCustomer = Space(1) 
    If trim$( x4901.Remark ) = "" Then x4901.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K4901_MOVE(rs4901 As SqlClient.SqlDataReader)
Try

    call D4901_CLEAR()   

    If IsdbNull(rs4901!K4901_ShippingWorkOrder) = False Then D4901.ShippingWorkOrder = Trim$(rs4901!K4901_ShippingWorkOrder)
    If IsdbNull(rs4901!K4901_ShippingWorkOrderName) = False Then D4901.ShippingWorkOrderName = Trim$(rs4901!K4901_ShippingWorkOrderName)
    If IsdbNull(rs4901!K4901_Status) = False Then D4901.Status = Trim$(rs4901!K4901_Status)
    If IsdbNull(rs4901!K4901_CustomerCode) = False Then D4901.CustomerCode = Trim$(rs4901!K4901_CustomerCode)
    If IsdbNull(rs4901!K4901_VendorCode) = False Then D4901.VendorCode = Trim$(rs4901!K4901_VendorCode)
    If IsdbNull(rs4901!K4901_AgentCode) = False Then D4901.AgentCode = Trim$(rs4901!K4901_AgentCode)
    If IsdbNull(rs4901!K4901_Buyer) = False Then D4901.Buyer = Trim$(rs4901!K4901_Buyer)
    If IsdbNull(rs4901!K4901_seOrderGroup) = False Then D4901.seOrderGroup = Trim$(rs4901!K4901_seOrderGroup)
    If IsdbNull(rs4901!K4901_cdOrderGroup) = False Then D4901.cdOrderGroup = Trim$(rs4901!K4901_cdOrderGroup)
    If IsdbNull(rs4901!K4901_seOrderKind) = False Then D4901.seOrderKind = Trim$(rs4901!K4901_seOrderKind)
    If IsdbNull(rs4901!K4901_cdOrderKind) = False Then D4901.cdOrderKind = Trim$(rs4901!K4901_cdOrderKind)
    If IsdbNull(rs4901!K4901_seOrderType) = False Then D4901.seOrderType = Trim$(rs4901!K4901_seOrderType)
    If IsdbNull(rs4901!K4901_cdOrderType) = False Then D4901.cdOrderType = Trim$(rs4901!K4901_cdOrderType)
    If IsdbNull(rs4901!K4901_cdOrderWork) = False Then D4901.cdOrderWork = Trim$(rs4901!K4901_cdOrderWork)
    If IsdbNull(rs4901!K4901_seOrderWork) = False Then D4901.seOrderWork = Trim$(rs4901!K4901_seOrderWork)
    If IsdbNull(rs4901!K4901_seStateSample) = False Then D4901.seStateSample = Trim$(rs4901!K4901_seStateSample)
    If IsdbNull(rs4901!K4901_cdStateSample) = False Then D4901.cdStateSample = Trim$(rs4901!K4901_cdStateSample)
    If IsdbNull(rs4901!K4901_seStateOfficial) = False Then D4901.seStateOfficial = Trim$(rs4901!K4901_seStateOfficial)
    If IsdbNull(rs4901!K4901_cdStateOfficial) = False Then D4901.cdStateOfficial = Trim$(rs4901!K4901_cdStateOfficial)
    If IsdbNull(rs4901!K4901_StatusOrder) = False Then D4901.StatusOrder = Trim$(rs4901!K4901_StatusOrder)
    If IsdbNull(rs4901!K4901_DateOrder) = False Then D4901.DateOrder = Trim$(rs4901!K4901_DateOrder)
    If IsdbNull(rs4901!K4901_DateApproval) = False Then D4901.DateApproval = Trim$(rs4901!K4901_DateApproval)
    If IsdbNull(rs4901!K4901_DateComplete) = False Then D4901.DateComplete = Trim$(rs4901!K4901_DateComplete)
    If IsdbNull(rs4901!K4901_DateCancel) = False Then D4901.DateCancel = Trim$(rs4901!K4901_DateCancel)
    If IsdbNull(rs4901!K4901_DatePending) = False Then D4901.DatePending = Trim$(rs4901!K4901_DatePending)
    If IsdbNull(rs4901!K4901_seUnitPrice) = False Then D4901.seUnitPrice = Trim$(rs4901!K4901_seUnitPrice)
    If IsdbNull(rs4901!K4901_cdUnitPrice) = False Then D4901.cdUnitPrice = Trim$(rs4901!K4901_cdUnitPrice)
    If IsdbNull(rs4901!K4901_PriceExchange) = False Then D4901.PriceExchange = Trim$(rs4901!K4901_PriceExchange)
    If IsdbNull(rs4901!K4901_DateExchange) = False Then D4901.DateExchange = Trim$(rs4901!K4901_DateExchange)
    If IsdbNull(rs4901!K4901_DateTransfer) = False Then D4901.DateTransfer = Trim$(rs4901!K4901_DateTransfer)
    If IsdbNull(rs4901!K4901_DateAccept) = False Then D4901.DateAccept = Trim$(rs4901!K4901_DateAccept)
    If IsdbNull(rs4901!K4901_StatusTransfer) = False Then D4901.StatusTransfer = Trim$(rs4901!K4901_StatusTransfer)
    If IsdbNull(rs4901!K4901_ShippingWorkOrderStatus) = False Then D4901.ShippingWorkOrderStatus = Trim$(rs4901!K4901_ShippingWorkOrderStatus)
    If IsdbNull(rs4901!K4901_seSeason) = False Then D4901.seSeason = Trim$(rs4901!K4901_seSeason)
    If IsdbNull(rs4901!K4901_cdSeason) = False Then D4901.cdSeason = Trim$(rs4901!K4901_cdSeason)
    If IsdbNull(rs4901!K4901_sePaymentTerm) = False Then D4901.sePaymentTerm = Trim$(rs4901!K4901_sePaymentTerm)
    If IsdbNull(rs4901!K4901_cdPaymentTerm) = False Then D4901.cdPaymentTerm = Trim$(rs4901!K4901_cdPaymentTerm)
    If IsdbNull(rs4901!K4901_seDeliveryTerm) = False Then D4901.seDeliveryTerm = Trim$(rs4901!K4901_seDeliveryTerm)
    If IsdbNull(rs4901!K4901_cdDeliveryTerm) = False Then D4901.cdDeliveryTerm = Trim$(rs4901!K4901_cdDeliveryTerm)
    If IsdbNull(rs4901!K4901_seShippingTerm) = False Then D4901.seShippingTerm = Trim$(rs4901!K4901_seShippingTerm)
    If IsdbNull(rs4901!K4901_cdShippingTerm) = False Then D4901.cdShippingTerm = Trim$(rs4901!K4901_cdShippingTerm)
    If IsdbNull(rs4901!K4901_seMarketType) = False Then D4901.seMarketType = Trim$(rs4901!K4901_seMarketType)
    If IsdbNull(rs4901!K4901_cdMarketType) = False Then D4901.cdMarketType = Trim$(rs4901!K4901_cdMarketType)
    If IsdbNull(rs4901!K4901_seDepartment) = False Then D4901.seDepartment = Trim$(rs4901!K4901_seDepartment)
    If IsdbNull(rs4901!K4901_cdDepartment) = False Then D4901.cdDepartment = Trim$(rs4901!K4901_cdDepartment)
    If IsdbNull(rs4901!K4901_seBrand) = False Then D4901.seBrand = Trim$(rs4901!K4901_seBrand)
    If IsdbNull(rs4901!K4901_cdBrand) = False Then D4901.cdBrand = Trim$(rs4901!K4901_cdBrand)
    If IsdbNull(rs4901!K4901_ContractIn) = False Then D4901.ContractIn = Trim$(rs4901!K4901_ContractIn)
    If IsdbNull(rs4901!K4901_ContractOut) = False Then D4901.ContractOut = Trim$(rs4901!K4901_ContractOut)
    If IsdbNull(rs4901!K4901_Destination) = False Then D4901.Destination = Trim$(rs4901!K4901_Destination)
    If IsdbNull(rs4901!K4901_CustPoNo) = False Then D4901.CustPoNo = Trim$(rs4901!K4901_CustPoNo)
    If IsdbNull(rs4901!K4901_InchargeSales) = False Then D4901.InchargeSales = Trim$(rs4901!K4901_InchargeSales)
    If IsdbNull(rs4901!K4901_InchargePPC) = False Then D4901.InchargePPC = Trim$(rs4901!K4901_InchargePPC)
    If IsdbNull(rs4901!K4901_DateInsert) = False Then D4901.DateInsert = Trim$(rs4901!K4901_DateInsert)
    If IsdbNull(rs4901!K4901_DateUpdate) = False Then D4901.DateUpdate = Trim$(rs4901!K4901_DateUpdate)
    If IsdbNull(rs4901!K4901_TimeInsert) = False Then D4901.TimeInsert = Trim$(rs4901!K4901_TimeInsert)
    If IsdbNull(rs4901!K4901_TimeUpdate) = False Then D4901.TimeUpdate = Trim$(rs4901!K4901_TimeUpdate)
    If IsdbNull(rs4901!K4901_TotalQty) = False Then D4901.TotalQty = Trim$(rs4901!K4901_TotalQty)
    If IsdbNull(rs4901!K4901_TotalAmount) = False Then D4901.TotalAmount = Trim$(rs4901!K4901_TotalAmount)
    If IsdbNull(rs4901!K4901_TotalCost) = False Then D4901.TotalCost = Trim$(rs4901!K4901_TotalCost)
    If IsdbNull(rs4901!K4901_TotalProfit) = False Then D4901.TotalProfit = Trim$(rs4901!K4901_TotalProfit)
    If IsdbNull(rs4901!K4901_AttachID) = False Then D4901.AttachID = Trim$(rs4901!K4901_AttachID)
    If IsdbNull(rs4901!K4901_RemarkOrder) = False Then D4901.RemarkOrder = Trim$(rs4901!K4901_RemarkOrder)
    If IsdbNull(rs4901!K4901_RemarkCustomer) = False Then D4901.RemarkCustomer = Trim$(rs4901!K4901_RemarkCustomer)
    If IsdbNull(rs4901!K4901_Remark) = False Then D4901.Remark = Trim$(rs4901!K4901_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K4901_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K4901_MOVE(rs4901 As DataRow)
Try

    call D4901_CLEAR()   

    If IsdbNull(rs4901!K4901_ShippingWorkOrder) = False Then D4901.ShippingWorkOrder = Trim$(rs4901!K4901_ShippingWorkOrder)
    If IsdbNull(rs4901!K4901_ShippingWorkOrderName) = False Then D4901.ShippingWorkOrderName = Trim$(rs4901!K4901_ShippingWorkOrderName)
    If IsdbNull(rs4901!K4901_Status) = False Then D4901.Status = Trim$(rs4901!K4901_Status)
    If IsdbNull(rs4901!K4901_CustomerCode) = False Then D4901.CustomerCode = Trim$(rs4901!K4901_CustomerCode)
    If IsdbNull(rs4901!K4901_VendorCode) = False Then D4901.VendorCode = Trim$(rs4901!K4901_VendorCode)
    If IsdbNull(rs4901!K4901_AgentCode) = False Then D4901.AgentCode = Trim$(rs4901!K4901_AgentCode)
    If IsdbNull(rs4901!K4901_Buyer) = False Then D4901.Buyer = Trim$(rs4901!K4901_Buyer)
    If IsdbNull(rs4901!K4901_seOrderGroup) = False Then D4901.seOrderGroup = Trim$(rs4901!K4901_seOrderGroup)
    If IsdbNull(rs4901!K4901_cdOrderGroup) = False Then D4901.cdOrderGroup = Trim$(rs4901!K4901_cdOrderGroup)
    If IsdbNull(rs4901!K4901_seOrderKind) = False Then D4901.seOrderKind = Trim$(rs4901!K4901_seOrderKind)
    If IsdbNull(rs4901!K4901_cdOrderKind) = False Then D4901.cdOrderKind = Trim$(rs4901!K4901_cdOrderKind)
    If IsdbNull(rs4901!K4901_seOrderType) = False Then D4901.seOrderType = Trim$(rs4901!K4901_seOrderType)
    If IsdbNull(rs4901!K4901_cdOrderType) = False Then D4901.cdOrderType = Trim$(rs4901!K4901_cdOrderType)
    If IsdbNull(rs4901!K4901_cdOrderWork) = False Then D4901.cdOrderWork = Trim$(rs4901!K4901_cdOrderWork)
    If IsdbNull(rs4901!K4901_seOrderWork) = False Then D4901.seOrderWork = Trim$(rs4901!K4901_seOrderWork)
    If IsdbNull(rs4901!K4901_seStateSample) = False Then D4901.seStateSample = Trim$(rs4901!K4901_seStateSample)
    If IsdbNull(rs4901!K4901_cdStateSample) = False Then D4901.cdStateSample = Trim$(rs4901!K4901_cdStateSample)
    If IsdbNull(rs4901!K4901_seStateOfficial) = False Then D4901.seStateOfficial = Trim$(rs4901!K4901_seStateOfficial)
    If IsdbNull(rs4901!K4901_cdStateOfficial) = False Then D4901.cdStateOfficial = Trim$(rs4901!K4901_cdStateOfficial)
    If IsdbNull(rs4901!K4901_StatusOrder) = False Then D4901.StatusOrder = Trim$(rs4901!K4901_StatusOrder)
    If IsdbNull(rs4901!K4901_DateOrder) = False Then D4901.DateOrder = Trim$(rs4901!K4901_DateOrder)
    If IsdbNull(rs4901!K4901_DateApproval) = False Then D4901.DateApproval = Trim$(rs4901!K4901_DateApproval)
    If IsdbNull(rs4901!K4901_DateComplete) = False Then D4901.DateComplete = Trim$(rs4901!K4901_DateComplete)
    If IsdbNull(rs4901!K4901_DateCancel) = False Then D4901.DateCancel = Trim$(rs4901!K4901_DateCancel)
    If IsdbNull(rs4901!K4901_DatePending) = False Then D4901.DatePending = Trim$(rs4901!K4901_DatePending)
    If IsdbNull(rs4901!K4901_seUnitPrice) = False Then D4901.seUnitPrice = Trim$(rs4901!K4901_seUnitPrice)
    If IsdbNull(rs4901!K4901_cdUnitPrice) = False Then D4901.cdUnitPrice = Trim$(rs4901!K4901_cdUnitPrice)
    If IsdbNull(rs4901!K4901_PriceExchange) = False Then D4901.PriceExchange = Trim$(rs4901!K4901_PriceExchange)
    If IsdbNull(rs4901!K4901_DateExchange) = False Then D4901.DateExchange = Trim$(rs4901!K4901_DateExchange)
    If IsdbNull(rs4901!K4901_DateTransfer) = False Then D4901.DateTransfer = Trim$(rs4901!K4901_DateTransfer)
    If IsdbNull(rs4901!K4901_DateAccept) = False Then D4901.DateAccept = Trim$(rs4901!K4901_DateAccept)
    If IsdbNull(rs4901!K4901_StatusTransfer) = False Then D4901.StatusTransfer = Trim$(rs4901!K4901_StatusTransfer)
    If IsdbNull(rs4901!K4901_ShippingWorkOrderStatus) = False Then D4901.ShippingWorkOrderStatus = Trim$(rs4901!K4901_ShippingWorkOrderStatus)
    If IsdbNull(rs4901!K4901_seSeason) = False Then D4901.seSeason = Trim$(rs4901!K4901_seSeason)
    If IsdbNull(rs4901!K4901_cdSeason) = False Then D4901.cdSeason = Trim$(rs4901!K4901_cdSeason)
    If IsdbNull(rs4901!K4901_sePaymentTerm) = False Then D4901.sePaymentTerm = Trim$(rs4901!K4901_sePaymentTerm)
    If IsdbNull(rs4901!K4901_cdPaymentTerm) = False Then D4901.cdPaymentTerm = Trim$(rs4901!K4901_cdPaymentTerm)
    If IsdbNull(rs4901!K4901_seDeliveryTerm) = False Then D4901.seDeliveryTerm = Trim$(rs4901!K4901_seDeliveryTerm)
    If IsdbNull(rs4901!K4901_cdDeliveryTerm) = False Then D4901.cdDeliveryTerm = Trim$(rs4901!K4901_cdDeliveryTerm)
    If IsdbNull(rs4901!K4901_seShippingTerm) = False Then D4901.seShippingTerm = Trim$(rs4901!K4901_seShippingTerm)
    If IsdbNull(rs4901!K4901_cdShippingTerm) = False Then D4901.cdShippingTerm = Trim$(rs4901!K4901_cdShippingTerm)
    If IsdbNull(rs4901!K4901_seMarketType) = False Then D4901.seMarketType = Trim$(rs4901!K4901_seMarketType)
    If IsdbNull(rs4901!K4901_cdMarketType) = False Then D4901.cdMarketType = Trim$(rs4901!K4901_cdMarketType)
    If IsdbNull(rs4901!K4901_seDepartment) = False Then D4901.seDepartment = Trim$(rs4901!K4901_seDepartment)
    If IsdbNull(rs4901!K4901_cdDepartment) = False Then D4901.cdDepartment = Trim$(rs4901!K4901_cdDepartment)
    If IsdbNull(rs4901!K4901_seBrand) = False Then D4901.seBrand = Trim$(rs4901!K4901_seBrand)
    If IsdbNull(rs4901!K4901_cdBrand) = False Then D4901.cdBrand = Trim$(rs4901!K4901_cdBrand)
    If IsdbNull(rs4901!K4901_ContractIn) = False Then D4901.ContractIn = Trim$(rs4901!K4901_ContractIn)
    If IsdbNull(rs4901!K4901_ContractOut) = False Then D4901.ContractOut = Trim$(rs4901!K4901_ContractOut)
    If IsdbNull(rs4901!K4901_Destination) = False Then D4901.Destination = Trim$(rs4901!K4901_Destination)
    If IsdbNull(rs4901!K4901_CustPoNo) = False Then D4901.CustPoNo = Trim$(rs4901!K4901_CustPoNo)
    If IsdbNull(rs4901!K4901_InchargeSales) = False Then D4901.InchargeSales = Trim$(rs4901!K4901_InchargeSales)
    If IsdbNull(rs4901!K4901_InchargePPC) = False Then D4901.InchargePPC = Trim$(rs4901!K4901_InchargePPC)
    If IsdbNull(rs4901!K4901_DateInsert) = False Then D4901.DateInsert = Trim$(rs4901!K4901_DateInsert)
    If IsdbNull(rs4901!K4901_DateUpdate) = False Then D4901.DateUpdate = Trim$(rs4901!K4901_DateUpdate)
    If IsdbNull(rs4901!K4901_TimeInsert) = False Then D4901.TimeInsert = Trim$(rs4901!K4901_TimeInsert)
    If IsdbNull(rs4901!K4901_TimeUpdate) = False Then D4901.TimeUpdate = Trim$(rs4901!K4901_TimeUpdate)
    If IsdbNull(rs4901!K4901_TotalQty) = False Then D4901.TotalQty = Trim$(rs4901!K4901_TotalQty)
    If IsdbNull(rs4901!K4901_TotalAmount) = False Then D4901.TotalAmount = Trim$(rs4901!K4901_TotalAmount)
    If IsdbNull(rs4901!K4901_TotalCost) = False Then D4901.TotalCost = Trim$(rs4901!K4901_TotalCost)
    If IsdbNull(rs4901!K4901_TotalProfit) = False Then D4901.TotalProfit = Trim$(rs4901!K4901_TotalProfit)
    If IsdbNull(rs4901!K4901_AttachID) = False Then D4901.AttachID = Trim$(rs4901!K4901_AttachID)
    If IsdbNull(rs4901!K4901_RemarkOrder) = False Then D4901.RemarkOrder = Trim$(rs4901!K4901_RemarkOrder)
    If IsdbNull(rs4901!K4901_RemarkCustomer) = False Then D4901.RemarkCustomer = Trim$(rs4901!K4901_RemarkCustomer)
    If IsdbNull(rs4901!K4901_Remark) = False Then D4901.Remark = Trim$(rs4901!K4901_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K4901_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K4901_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z4901 As T4901_AREA, SHIPPINGWORKORDER AS String) as Boolean

K4901_MOVE = False

Try
    If READ_PFK4901(SHIPPINGWORKORDER) = True Then
                z4901 = D4901
		K4901_MOVE = True
		else
	z4901 = nothing
     End If

     If  getColumIndex(spr,"ShippingWorkOrder") > -1 then z4901.ShippingWorkOrder = getDataM(spr, getColumIndex(spr,"ShippingWorkOrder"), xRow)
     If  getColumIndex(spr,"ShippingWorkOrderName") > -1 then z4901.ShippingWorkOrderName = getDataM(spr, getColumIndex(spr,"ShippingWorkOrderName"), xRow)
     If  getColumIndex(spr,"Status") > -1 then z4901.Status = getDataM(spr, getColumIndex(spr,"Status"), xRow)
     If  getColumIndex(spr,"CustomerCode") > -1 then z4901.CustomerCode = getDataM(spr, getColumIndex(spr,"CustomerCode"), xRow)
     If  getColumIndex(spr,"VendorCode") > -1 then z4901.VendorCode = getDataM(spr, getColumIndex(spr,"VendorCode"), xRow)
     If  getColumIndex(spr,"AgentCode") > -1 then z4901.AgentCode = getDataM(spr, getColumIndex(spr,"AgentCode"), xRow)
     If  getColumIndex(spr,"Buyer") > -1 then z4901.Buyer = getDataM(spr, getColumIndex(spr,"Buyer"), xRow)
     If  getColumIndex(spr,"seOrderGroup") > -1 then z4901.seOrderGroup = getDataM(spr, getColumIndex(spr,"seOrderGroup"), xRow)
     If  getColumIndex(spr,"cdOrderGroup") > -1 then z4901.cdOrderGroup = getDataM(spr, getColumIndex(spr,"cdOrderGroup"), xRow)
     If  getColumIndex(spr,"seOrderKind") > -1 then z4901.seOrderKind = getDataM(spr, getColumIndex(spr,"seOrderKind"), xRow)
     If  getColumIndex(spr,"cdOrderKind") > -1 then z4901.cdOrderKind = getDataM(spr, getColumIndex(spr,"cdOrderKind"), xRow)
     If  getColumIndex(spr,"seOrderType") > -1 then z4901.seOrderType = getDataM(spr, getColumIndex(spr,"seOrderType"), xRow)
     If  getColumIndex(spr,"cdOrderType") > -1 then z4901.cdOrderType = getDataM(spr, getColumIndex(spr,"cdOrderType"), xRow)
     If  getColumIndex(spr,"cdOrderWork") > -1 then z4901.cdOrderWork = getDataM(spr, getColumIndex(spr,"cdOrderWork"), xRow)
     If  getColumIndex(spr,"seOrderWork") > -1 then z4901.seOrderWork = getDataM(spr, getColumIndex(spr,"seOrderWork"), xRow)
     If  getColumIndex(spr,"seStateSample") > -1 then z4901.seStateSample = getDataM(spr, getColumIndex(spr,"seStateSample"), xRow)
     If  getColumIndex(spr,"cdStateSample") > -1 then z4901.cdStateSample = getDataM(spr, getColumIndex(spr,"cdStateSample"), xRow)
     If  getColumIndex(spr,"seStateOfficial") > -1 then z4901.seStateOfficial = getDataM(spr, getColumIndex(spr,"seStateOfficial"), xRow)
     If  getColumIndex(spr,"cdStateOfficial") > -1 then z4901.cdStateOfficial = getDataM(spr, getColumIndex(spr,"cdStateOfficial"), xRow)
     If  getColumIndex(spr,"StatusOrder") > -1 then z4901.StatusOrder = getDataM(spr, getColumIndex(spr,"StatusOrder"), xRow)
     If  getColumIndex(spr,"DateOrder") > -1 then z4901.DateOrder = getDataM(spr, getColumIndex(spr,"DateOrder"), xRow)
     If  getColumIndex(spr,"DateApproval") > -1 then z4901.DateApproval = getDataM(spr, getColumIndex(spr,"DateApproval"), xRow)
     If  getColumIndex(spr,"DateComplete") > -1 then z4901.DateComplete = getDataM(spr, getColumIndex(spr,"DateComplete"), xRow)
     If  getColumIndex(spr,"DateCancel") > -1 then z4901.DateCancel = getDataM(spr, getColumIndex(spr,"DateCancel"), xRow)
     If  getColumIndex(spr,"DatePending") > -1 then z4901.DatePending = getDataM(spr, getColumIndex(spr,"DatePending"), xRow)
     If  getColumIndex(spr,"seUnitPrice") > -1 then z4901.seUnitPrice = getDataM(spr, getColumIndex(spr,"seUnitPrice"), xRow)
     If  getColumIndex(spr,"cdUnitPrice") > -1 then z4901.cdUnitPrice = getDataM(spr, getColumIndex(spr,"cdUnitPrice"), xRow)
     If  getColumIndex(spr,"PriceExchange") > -1 then z4901.PriceExchange = getDataM(spr, getColumIndex(spr,"PriceExchange"), xRow)
     If  getColumIndex(spr,"DateExchange") > -1 then z4901.DateExchange = getDataM(spr, getColumIndex(spr,"DateExchange"), xRow)
     If  getColumIndex(spr,"DateTransfer") > -1 then z4901.DateTransfer = getDataM(spr, getColumIndex(spr,"DateTransfer"), xRow)
     If  getColumIndex(spr,"DateAccept") > -1 then z4901.DateAccept = getDataM(spr, getColumIndex(spr,"DateAccept"), xRow)
     If  getColumIndex(spr,"StatusTransfer") > -1 then z4901.StatusTransfer = getDataM(spr, getColumIndex(spr,"StatusTransfer"), xRow)
     If  getColumIndex(spr,"ShippingWorkOrderStatus") > -1 then z4901.ShippingWorkOrderStatus = getDataM(spr, getColumIndex(spr,"ShippingWorkOrderStatus"), xRow)
     If  getColumIndex(spr,"seSeason") > -1 then z4901.seSeason = getDataM(spr, getColumIndex(spr,"seSeason"), xRow)
     If  getColumIndex(spr,"cdSeason") > -1 then z4901.cdSeason = getDataM(spr, getColumIndex(spr,"cdSeason"), xRow)
     If  getColumIndex(spr,"sePaymentTerm") > -1 then z4901.sePaymentTerm = getDataM(spr, getColumIndex(spr,"sePaymentTerm"), xRow)
     If  getColumIndex(spr,"cdPaymentTerm") > -1 then z4901.cdPaymentTerm = getDataM(spr, getColumIndex(spr,"cdPaymentTerm"), xRow)
     If  getColumIndex(spr,"seDeliveryTerm") > -1 then z4901.seDeliveryTerm = getDataM(spr, getColumIndex(spr,"seDeliveryTerm"), xRow)
     If  getColumIndex(spr,"cdDeliveryTerm") > -1 then z4901.cdDeliveryTerm = getDataM(spr, getColumIndex(spr,"cdDeliveryTerm"), xRow)
     If  getColumIndex(spr,"seShippingTerm") > -1 then z4901.seShippingTerm = getDataM(spr, getColumIndex(spr,"seShippingTerm"), xRow)
     If  getColumIndex(spr,"cdShippingTerm") > -1 then z4901.cdShippingTerm = getDataM(spr, getColumIndex(spr,"cdShippingTerm"), xRow)
     If  getColumIndex(spr,"seMarketType") > -1 then z4901.seMarketType = getDataM(spr, getColumIndex(spr,"seMarketType"), xRow)
     If  getColumIndex(spr,"cdMarketType") > -1 then z4901.cdMarketType = getDataM(spr, getColumIndex(spr,"cdMarketType"), xRow)
     If  getColumIndex(spr,"seDepartment") > -1 then z4901.seDepartment = getDataM(spr, getColumIndex(spr,"seDepartment"), xRow)
     If  getColumIndex(spr,"cdDepartment") > -1 then z4901.cdDepartment = getDataM(spr, getColumIndex(spr,"cdDepartment"), xRow)
     If  getColumIndex(spr,"seBrand") > -1 then z4901.seBrand = getDataM(spr, getColumIndex(spr,"seBrand"), xRow)
     If  getColumIndex(spr,"cdBrand") > -1 then z4901.cdBrand = getDataM(spr, getColumIndex(spr,"cdBrand"), xRow)
     If  getColumIndex(spr,"ContractIn") > -1 then z4901.ContractIn = getDataM(spr, getColumIndex(spr,"ContractIn"), xRow)
     If  getColumIndex(spr,"ContractOut") > -1 then z4901.ContractOut = getDataM(spr, getColumIndex(spr,"ContractOut"), xRow)
     If  getColumIndex(spr,"Destination") > -1 then z4901.Destination = getDataM(spr, getColumIndex(spr,"Destination"), xRow)
     If  getColumIndex(spr,"CustPoNo") > -1 then z4901.CustPoNo = getDataM(spr, getColumIndex(spr,"CustPoNo"), xRow)
     If  getColumIndex(spr,"InchargeSales") > -1 then z4901.InchargeSales = getDataM(spr, getColumIndex(spr,"InchargeSales"), xRow)
     If  getColumIndex(spr,"InchargePPC") > -1 then z4901.InchargePPC = getDataM(spr, getColumIndex(spr,"InchargePPC"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z4901.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z4901.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"TimeInsert") > -1 then z4901.TimeInsert = getDataM(spr, getColumIndex(spr,"TimeInsert"), xRow)
     If  getColumIndex(spr,"TimeUpdate") > -1 then z4901.TimeUpdate = getDataM(spr, getColumIndex(spr,"TimeUpdate"), xRow)
     If  getColumIndex(spr,"TotalQty") > -1 then z4901.TotalQty = getDataM(spr, getColumIndex(spr,"TotalQty"), xRow)
     If  getColumIndex(spr,"TotalAmount") > -1 then z4901.TotalAmount = getDataM(spr, getColumIndex(spr,"TotalAmount"), xRow)
     If  getColumIndex(spr,"TotalCost") > -1 then z4901.TotalCost = getDataM(spr, getColumIndex(spr,"TotalCost"), xRow)
     If  getColumIndex(spr,"TotalProfit") > -1 then z4901.TotalProfit = getDataM(spr, getColumIndex(spr,"TotalProfit"), xRow)
     If  getColumIndex(spr,"AttachID") > -1 then z4901.AttachID = getDataM(spr, getColumIndex(spr,"AttachID"), xRow)
     If  getColumIndex(spr,"RemarkOrder") > -1 then z4901.RemarkOrder = getDataM(spr, getColumIndex(spr,"RemarkOrder"), xRow)
     If  getColumIndex(spr,"RemarkCustomer") > -1 then z4901.RemarkCustomer = getDataM(spr, getColumIndex(spr,"RemarkCustomer"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z4901.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K4901_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K4901_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z4901 As T4901_AREA,CheckClear as Boolean,SHIPPINGWORKORDER AS String) as Boolean

K4901_MOVE = False

Try
    If READ_PFK4901(SHIPPINGWORKORDER) = True Then
                z4901 = D4901
		K4901_MOVE = True
		else
	If CheckClear  = True then z4901 = nothing
     End If

     If  getColumIndex(spr,"ShippingWorkOrder") > -1 then z4901.ShippingWorkOrder = getDataM(spr, getColumIndex(spr,"ShippingWorkOrder"), xRow)
     If  getColumIndex(spr,"ShippingWorkOrderName") > -1 then z4901.ShippingWorkOrderName = getDataM(spr, getColumIndex(spr,"ShippingWorkOrderName"), xRow)
     If  getColumIndex(spr,"Status") > -1 then z4901.Status = getDataM(spr, getColumIndex(spr,"Status"), xRow)
     If  getColumIndex(spr,"CustomerCode") > -1 then z4901.CustomerCode = getDataM(spr, getColumIndex(spr,"CustomerCode"), xRow)
     If  getColumIndex(spr,"VendorCode") > -1 then z4901.VendorCode = getDataM(spr, getColumIndex(spr,"VendorCode"), xRow)
     If  getColumIndex(spr,"AgentCode") > -1 then z4901.AgentCode = getDataM(spr, getColumIndex(spr,"AgentCode"), xRow)
     If  getColumIndex(spr,"Buyer") > -1 then z4901.Buyer = getDataM(spr, getColumIndex(spr,"Buyer"), xRow)
     If  getColumIndex(spr,"seOrderGroup") > -1 then z4901.seOrderGroup = getDataM(spr, getColumIndex(spr,"seOrderGroup"), xRow)
     If  getColumIndex(spr,"cdOrderGroup") > -1 then z4901.cdOrderGroup = getDataM(spr, getColumIndex(spr,"cdOrderGroup"), xRow)
     If  getColumIndex(spr,"seOrderKind") > -1 then z4901.seOrderKind = getDataM(spr, getColumIndex(spr,"seOrderKind"), xRow)
     If  getColumIndex(spr,"cdOrderKind") > -1 then z4901.cdOrderKind = getDataM(spr, getColumIndex(spr,"cdOrderKind"), xRow)
     If  getColumIndex(spr,"seOrderType") > -1 then z4901.seOrderType = getDataM(spr, getColumIndex(spr,"seOrderType"), xRow)
     If  getColumIndex(spr,"cdOrderType") > -1 then z4901.cdOrderType = getDataM(spr, getColumIndex(spr,"cdOrderType"), xRow)
     If  getColumIndex(spr,"cdOrderWork") > -1 then z4901.cdOrderWork = getDataM(spr, getColumIndex(spr,"cdOrderWork"), xRow)
     If  getColumIndex(spr,"seOrderWork") > -1 then z4901.seOrderWork = getDataM(spr, getColumIndex(spr,"seOrderWork"), xRow)
     If  getColumIndex(spr,"seStateSample") > -1 then z4901.seStateSample = getDataM(spr, getColumIndex(spr,"seStateSample"), xRow)
     If  getColumIndex(spr,"cdStateSample") > -1 then z4901.cdStateSample = getDataM(spr, getColumIndex(spr,"cdStateSample"), xRow)
     If  getColumIndex(spr,"seStateOfficial") > -1 then z4901.seStateOfficial = getDataM(spr, getColumIndex(spr,"seStateOfficial"), xRow)
     If  getColumIndex(spr,"cdStateOfficial") > -1 then z4901.cdStateOfficial = getDataM(spr, getColumIndex(spr,"cdStateOfficial"), xRow)
     If  getColumIndex(spr,"StatusOrder") > -1 then z4901.StatusOrder = getDataM(spr, getColumIndex(spr,"StatusOrder"), xRow)
     If  getColumIndex(spr,"DateOrder") > -1 then z4901.DateOrder = getDataM(spr, getColumIndex(spr,"DateOrder"), xRow)
     If  getColumIndex(spr,"DateApproval") > -1 then z4901.DateApproval = getDataM(spr, getColumIndex(spr,"DateApproval"), xRow)
     If  getColumIndex(spr,"DateComplete") > -1 then z4901.DateComplete = getDataM(spr, getColumIndex(spr,"DateComplete"), xRow)
     If  getColumIndex(spr,"DateCancel") > -1 then z4901.DateCancel = getDataM(spr, getColumIndex(spr,"DateCancel"), xRow)
     If  getColumIndex(spr,"DatePending") > -1 then z4901.DatePending = getDataM(spr, getColumIndex(spr,"DatePending"), xRow)
     If  getColumIndex(spr,"seUnitPrice") > -1 then z4901.seUnitPrice = getDataM(spr, getColumIndex(spr,"seUnitPrice"), xRow)
     If  getColumIndex(spr,"cdUnitPrice") > -1 then z4901.cdUnitPrice = getDataM(spr, getColumIndex(spr,"cdUnitPrice"), xRow)
     If  getColumIndex(spr,"PriceExchange") > -1 then z4901.PriceExchange = getDataM(spr, getColumIndex(spr,"PriceExchange"), xRow)
     If  getColumIndex(spr,"DateExchange") > -1 then z4901.DateExchange = getDataM(spr, getColumIndex(spr,"DateExchange"), xRow)
     If  getColumIndex(spr,"DateTransfer") > -1 then z4901.DateTransfer = getDataM(spr, getColumIndex(spr,"DateTransfer"), xRow)
     If  getColumIndex(spr,"DateAccept") > -1 then z4901.DateAccept = getDataM(spr, getColumIndex(spr,"DateAccept"), xRow)
     If  getColumIndex(spr,"StatusTransfer") > -1 then z4901.StatusTransfer = getDataM(spr, getColumIndex(spr,"StatusTransfer"), xRow)
     If  getColumIndex(spr,"ShippingWorkOrderStatus") > -1 then z4901.ShippingWorkOrderStatus = getDataM(spr, getColumIndex(spr,"ShippingWorkOrderStatus"), xRow)
     If  getColumIndex(spr,"seSeason") > -1 then z4901.seSeason = getDataM(spr, getColumIndex(spr,"seSeason"), xRow)
     If  getColumIndex(spr,"cdSeason") > -1 then z4901.cdSeason = getDataM(spr, getColumIndex(spr,"cdSeason"), xRow)
     If  getColumIndex(spr,"sePaymentTerm") > -1 then z4901.sePaymentTerm = getDataM(spr, getColumIndex(spr,"sePaymentTerm"), xRow)
     If  getColumIndex(spr,"cdPaymentTerm") > -1 then z4901.cdPaymentTerm = getDataM(spr, getColumIndex(spr,"cdPaymentTerm"), xRow)
     If  getColumIndex(spr,"seDeliveryTerm") > -1 then z4901.seDeliveryTerm = getDataM(spr, getColumIndex(spr,"seDeliveryTerm"), xRow)
     If  getColumIndex(spr,"cdDeliveryTerm") > -1 then z4901.cdDeliveryTerm = getDataM(spr, getColumIndex(spr,"cdDeliveryTerm"), xRow)
     If  getColumIndex(spr,"seShippingTerm") > -1 then z4901.seShippingTerm = getDataM(spr, getColumIndex(spr,"seShippingTerm"), xRow)
     If  getColumIndex(spr,"cdShippingTerm") > -1 then z4901.cdShippingTerm = getDataM(spr, getColumIndex(spr,"cdShippingTerm"), xRow)
     If  getColumIndex(spr,"seMarketType") > -1 then z4901.seMarketType = getDataM(spr, getColumIndex(spr,"seMarketType"), xRow)
     If  getColumIndex(spr,"cdMarketType") > -1 then z4901.cdMarketType = getDataM(spr, getColumIndex(spr,"cdMarketType"), xRow)
     If  getColumIndex(spr,"seDepartment") > -1 then z4901.seDepartment = getDataM(spr, getColumIndex(spr,"seDepartment"), xRow)
     If  getColumIndex(spr,"cdDepartment") > -1 then z4901.cdDepartment = getDataM(spr, getColumIndex(spr,"cdDepartment"), xRow)
     If  getColumIndex(spr,"seBrand") > -1 then z4901.seBrand = getDataM(spr, getColumIndex(spr,"seBrand"), xRow)
     If  getColumIndex(spr,"cdBrand") > -1 then z4901.cdBrand = getDataM(spr, getColumIndex(spr,"cdBrand"), xRow)
     If  getColumIndex(spr,"ContractIn") > -1 then z4901.ContractIn = getDataM(spr, getColumIndex(spr,"ContractIn"), xRow)
     If  getColumIndex(spr,"ContractOut") > -1 then z4901.ContractOut = getDataM(spr, getColumIndex(spr,"ContractOut"), xRow)
     If  getColumIndex(spr,"Destination") > -1 then z4901.Destination = getDataM(spr, getColumIndex(spr,"Destination"), xRow)
     If  getColumIndex(spr,"CustPoNo") > -1 then z4901.CustPoNo = getDataM(spr, getColumIndex(spr,"CustPoNo"), xRow)
     If  getColumIndex(spr,"InchargeSales") > -1 then z4901.InchargeSales = getDataM(spr, getColumIndex(spr,"InchargeSales"), xRow)
     If  getColumIndex(spr,"InchargePPC") > -1 then z4901.InchargePPC = getDataM(spr, getColumIndex(spr,"InchargePPC"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z4901.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z4901.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"TimeInsert") > -1 then z4901.TimeInsert = getDataM(spr, getColumIndex(spr,"TimeInsert"), xRow)
     If  getColumIndex(spr,"TimeUpdate") > -1 then z4901.TimeUpdate = getDataM(spr, getColumIndex(spr,"TimeUpdate"), xRow)
     If  getColumIndex(spr,"TotalQty") > -1 then z4901.TotalQty = getDataM(spr, getColumIndex(spr,"TotalQty"), xRow)
     If  getColumIndex(spr,"TotalAmount") > -1 then z4901.TotalAmount = getDataM(spr, getColumIndex(spr,"TotalAmount"), xRow)
     If  getColumIndex(spr,"TotalCost") > -1 then z4901.TotalCost = getDataM(spr, getColumIndex(spr,"TotalCost"), xRow)
     If  getColumIndex(spr,"TotalProfit") > -1 then z4901.TotalProfit = getDataM(spr, getColumIndex(spr,"TotalProfit"), xRow)
     If  getColumIndex(spr,"AttachID") > -1 then z4901.AttachID = getDataM(spr, getColumIndex(spr,"AttachID"), xRow)
     If  getColumIndex(spr,"RemarkOrder") > -1 then z4901.RemarkOrder = getDataM(spr, getColumIndex(spr,"RemarkOrder"), xRow)
     If  getColumIndex(spr,"RemarkCustomer") > -1 then z4901.RemarkCustomer = getDataM(spr, getColumIndex(spr,"RemarkCustomer"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z4901.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K4901_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K4901_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z4901 As T4901_AREA, Job as String, SHIPPINGWORKORDER AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K4901_MOVE = False

Try
    If READ_PFK4901(SHIPPINGWORKORDER) = True Then
                z4901 = D4901
		K4901_MOVE = True
		else
	z4901 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4901")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "SHIPPINGWORKORDER":z4901.ShippingWorkOrder = Children(i).Code
   Case "SHIPPINGWORKORDERNAME":z4901.ShippingWorkOrderName = Children(i).Code
   Case "STATUS":z4901.Status = Children(i).Code
   Case "CUSTOMERCODE":z4901.CustomerCode = Children(i).Code
   Case "VENDORCODE":z4901.VendorCode = Children(i).Code
   Case "AGENTCODE":z4901.AgentCode = Children(i).Code
   Case "BUYER":z4901.Buyer = Children(i).Code
   Case "SEORDERGROUP":z4901.seOrderGroup = Children(i).Code
   Case "CDORDERGROUP":z4901.cdOrderGroup = Children(i).Code
   Case "SEORDERKIND":z4901.seOrderKind = Children(i).Code
   Case "CDORDERKIND":z4901.cdOrderKind = Children(i).Code
   Case "SEORDERTYPE":z4901.seOrderType = Children(i).Code
   Case "CDORDERTYPE":z4901.cdOrderType = Children(i).Code
   Case "CDORDERWORK":z4901.cdOrderWork = Children(i).Code
   Case "SEORDERWORK":z4901.seOrderWork = Children(i).Code
   Case "SESTATESAMPLE":z4901.seStateSample = Children(i).Code
   Case "CDSTATESAMPLE":z4901.cdStateSample = Children(i).Code
   Case "SESTATEOFFICIAL":z4901.seStateOfficial = Children(i).Code
   Case "CDSTATEOFFICIAL":z4901.cdStateOfficial = Children(i).Code
   Case "STATUSORDER":z4901.StatusOrder = Children(i).Code
   Case "DATEORDER":z4901.DateOrder = Children(i).Code
   Case "DATEAPPROVAL":z4901.DateApproval = Children(i).Code
   Case "DATECOMPLETE":z4901.DateComplete = Children(i).Code
   Case "DATECANCEL":z4901.DateCancel = Children(i).Code
   Case "DATEPENDING":z4901.DatePending = Children(i).Code
   Case "SEUNITPRICE":z4901.seUnitPrice = Children(i).Code
   Case "CDUNITPRICE":z4901.cdUnitPrice = Children(i).Code
   Case "PRICEEXCHANGE":z4901.PriceExchange = Children(i).Code
   Case "DATEEXCHANGE":z4901.DateExchange = Children(i).Code
   Case "DATETRANSFER":z4901.DateTransfer = Children(i).Code
   Case "DATEACCEPT":z4901.DateAccept = Children(i).Code
   Case "STATUSTRANSFER":z4901.StatusTransfer = Children(i).Code
   Case "SHIPPINGWORKORDERSTATUS":z4901.ShippingWorkOrderStatus = Children(i).Code
   Case "SESEASON":z4901.seSeason = Children(i).Code
   Case "CDSEASON":z4901.cdSeason = Children(i).Code
   Case "SEPAYMENTTERM":z4901.sePaymentTerm = Children(i).Code
   Case "CDPAYMENTTERM":z4901.cdPaymentTerm = Children(i).Code
   Case "SEDELIVERYTERM":z4901.seDeliveryTerm = Children(i).Code
   Case "CDDELIVERYTERM":z4901.cdDeliveryTerm = Children(i).Code
   Case "SESHIPPINGTERM":z4901.seShippingTerm = Children(i).Code
   Case "CDSHIPPINGTERM":z4901.cdShippingTerm = Children(i).Code
   Case "SEMARKETTYPE":z4901.seMarketType = Children(i).Code
   Case "CDMARKETTYPE":z4901.cdMarketType = Children(i).Code
   Case "SEDEPARTMENT":z4901.seDepartment = Children(i).Code
   Case "CDDEPARTMENT":z4901.cdDepartment = Children(i).Code
   Case "SEBRAND":z4901.seBrand = Children(i).Code
   Case "CDBRAND":z4901.cdBrand = Children(i).Code
   Case "CONTRACTIN":z4901.ContractIn = Children(i).Code
   Case "CONTRACTOUT":z4901.ContractOut = Children(i).Code
   Case "DESTINATION":z4901.Destination = Children(i).Code
   Case "CUSTPONO":z4901.CustPoNo = Children(i).Code
   Case "INCHARGESALES":z4901.InchargeSales = Children(i).Code
   Case "INCHARGEPPC":z4901.InchargePPC = Children(i).Code
   Case "DATEINSERT":z4901.DateInsert = Children(i).Code
   Case "DATEUPDATE":z4901.DateUpdate = Children(i).Code
   Case "TIMEINSERT":z4901.TimeInsert = Children(i).Code
   Case "TIMEUPDATE":z4901.TimeUpdate = Children(i).Code
   Case "TOTALQTY":z4901.TotalQty = Children(i).Code
   Case "TOTALAMOUNT":z4901.TotalAmount = Children(i).Code
   Case "TOTALCOST":z4901.TotalCost = Children(i).Code
   Case "TOTALPROFIT":z4901.TotalProfit = Children(i).Code
   Case "ATTACHID":z4901.AttachID = Children(i).Code
   Case "REMARKORDER":z4901.RemarkOrder = Children(i).Code
   Case "REMARKCUSTOMER":z4901.RemarkCustomer = Children(i).Code
   Case "REMARK":z4901.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "SHIPPINGWORKORDER":z4901.ShippingWorkOrder = Children(i).Data
   Case "SHIPPINGWORKORDERNAME":z4901.ShippingWorkOrderName = Children(i).Data
   Case "STATUS":z4901.Status = Children(i).Data
   Case "CUSTOMERCODE":z4901.CustomerCode = Children(i).Data
   Case "VENDORCODE":z4901.VendorCode = Children(i).Data
   Case "AGENTCODE":z4901.AgentCode = Children(i).Data
   Case "BUYER":z4901.Buyer = Children(i).Data
   Case "SEORDERGROUP":z4901.seOrderGroup = Children(i).Data
   Case "CDORDERGROUP":z4901.cdOrderGroup = Children(i).Data
   Case "SEORDERKIND":z4901.seOrderKind = Children(i).Data
   Case "CDORDERKIND":z4901.cdOrderKind = Children(i).Data
   Case "SEORDERTYPE":z4901.seOrderType = Children(i).Data
   Case "CDORDERTYPE":z4901.cdOrderType = Children(i).Data
   Case "CDORDERWORK":z4901.cdOrderWork = Children(i).Data
   Case "SEORDERWORK":z4901.seOrderWork = Children(i).Data
   Case "SESTATESAMPLE":z4901.seStateSample = Children(i).Data
   Case "CDSTATESAMPLE":z4901.cdStateSample = Children(i).Data
   Case "SESTATEOFFICIAL":z4901.seStateOfficial = Children(i).Data
   Case "CDSTATEOFFICIAL":z4901.cdStateOfficial = Children(i).Data
   Case "STATUSORDER":z4901.StatusOrder = Children(i).Data
   Case "DATEORDER":z4901.DateOrder = Children(i).Data
   Case "DATEAPPROVAL":z4901.DateApproval = Children(i).Data
   Case "DATECOMPLETE":z4901.DateComplete = Children(i).Data
   Case "DATECANCEL":z4901.DateCancel = Children(i).Data
   Case "DATEPENDING":z4901.DatePending = Children(i).Data
   Case "SEUNITPRICE":z4901.seUnitPrice = Children(i).Data
   Case "CDUNITPRICE":z4901.cdUnitPrice = Children(i).Data
   Case "PRICEEXCHANGE":z4901.PriceExchange = Children(i).Data
   Case "DATEEXCHANGE":z4901.DateExchange = Children(i).Data
   Case "DATETRANSFER":z4901.DateTransfer = Children(i).Data
   Case "DATEACCEPT":z4901.DateAccept = Children(i).Data
   Case "STATUSTRANSFER":z4901.StatusTransfer = Children(i).Data
   Case "SHIPPINGWORKORDERSTATUS":z4901.ShippingWorkOrderStatus = Children(i).Data
   Case "SESEASON":z4901.seSeason = Children(i).Data
   Case "CDSEASON":z4901.cdSeason = Children(i).Data
   Case "SEPAYMENTTERM":z4901.sePaymentTerm = Children(i).Data
   Case "CDPAYMENTTERM":z4901.cdPaymentTerm = Children(i).Data
   Case "SEDELIVERYTERM":z4901.seDeliveryTerm = Children(i).Data
   Case "CDDELIVERYTERM":z4901.cdDeliveryTerm = Children(i).Data
   Case "SESHIPPINGTERM":z4901.seShippingTerm = Children(i).Data
   Case "CDSHIPPINGTERM":z4901.cdShippingTerm = Children(i).Data
   Case "SEMARKETTYPE":z4901.seMarketType = Children(i).Data
   Case "CDMARKETTYPE":z4901.cdMarketType = Children(i).Data
   Case "SEDEPARTMENT":z4901.seDepartment = Children(i).Data
   Case "CDDEPARTMENT":z4901.cdDepartment = Children(i).Data
   Case "SEBRAND":z4901.seBrand = Children(i).Data
   Case "CDBRAND":z4901.cdBrand = Children(i).Data
   Case "CONTRACTIN":z4901.ContractIn = Children(i).Data
   Case "CONTRACTOUT":z4901.ContractOut = Children(i).Data
   Case "DESTINATION":z4901.Destination = Children(i).Data
   Case "CUSTPONO":z4901.CustPoNo = Children(i).Data
   Case "INCHARGESALES":z4901.InchargeSales = Children(i).Data
   Case "INCHARGEPPC":z4901.InchargePPC = Children(i).Data
   Case "DATEINSERT":z4901.DateInsert = Children(i).Data
   Case "DATEUPDATE":z4901.DateUpdate = Children(i).Data
   Case "TIMEINSERT":z4901.TimeInsert = Children(i).Data
   Case "TIMEUPDATE":z4901.TimeUpdate = Children(i).Data
   Case "TOTALQTY":z4901.TotalQty = Children(i).Data
   Case "TOTALAMOUNT":z4901.TotalAmount = Children(i).Data
   Case "TOTALCOST":z4901.TotalCost = Children(i).Data
   Case "TOTALPROFIT":z4901.TotalProfit = Children(i).Data
   Case "ATTACHID":z4901.AttachID = Children(i).Data
   Case "REMARKORDER":z4901.RemarkOrder = Children(i).Data
   Case "REMARKCUSTOMER":z4901.RemarkCustomer = Children(i).Data
   Case "REMARK":z4901.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K4901_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K4901_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z4901 As T4901_AREA, Job as String, CheckClear as Boolean, SHIPPINGWORKORDER AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K4901_MOVE = False

Try
    If READ_PFK4901(SHIPPINGWORKORDER) = True Then
                z4901 = D4901
		K4901_MOVE = True
		else
	If CheckClear  = True then z4901 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4901")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "SHIPPINGWORKORDER":z4901.ShippingWorkOrder = Children(i).Code
   Case "SHIPPINGWORKORDERNAME":z4901.ShippingWorkOrderName = Children(i).Code
   Case "STATUS":z4901.Status = Children(i).Code
   Case "CUSTOMERCODE":z4901.CustomerCode = Children(i).Code
   Case "VENDORCODE":z4901.VendorCode = Children(i).Code
   Case "AGENTCODE":z4901.AgentCode = Children(i).Code
   Case "BUYER":z4901.Buyer = Children(i).Code
   Case "SEORDERGROUP":z4901.seOrderGroup = Children(i).Code
   Case "CDORDERGROUP":z4901.cdOrderGroup = Children(i).Code
   Case "SEORDERKIND":z4901.seOrderKind = Children(i).Code
   Case "CDORDERKIND":z4901.cdOrderKind = Children(i).Code
   Case "SEORDERTYPE":z4901.seOrderType = Children(i).Code
   Case "CDORDERTYPE":z4901.cdOrderType = Children(i).Code
   Case "CDORDERWORK":z4901.cdOrderWork = Children(i).Code
   Case "SEORDERWORK":z4901.seOrderWork = Children(i).Code
   Case "SESTATESAMPLE":z4901.seStateSample = Children(i).Code
   Case "CDSTATESAMPLE":z4901.cdStateSample = Children(i).Code
   Case "SESTATEOFFICIAL":z4901.seStateOfficial = Children(i).Code
   Case "CDSTATEOFFICIAL":z4901.cdStateOfficial = Children(i).Code
   Case "STATUSORDER":z4901.StatusOrder = Children(i).Code
   Case "DATEORDER":z4901.DateOrder = Children(i).Code
   Case "DATEAPPROVAL":z4901.DateApproval = Children(i).Code
   Case "DATECOMPLETE":z4901.DateComplete = Children(i).Code
   Case "DATECANCEL":z4901.DateCancel = Children(i).Code
   Case "DATEPENDING":z4901.DatePending = Children(i).Code
   Case "SEUNITPRICE":z4901.seUnitPrice = Children(i).Code
   Case "CDUNITPRICE":z4901.cdUnitPrice = Children(i).Code
   Case "PRICEEXCHANGE":z4901.PriceExchange = Children(i).Code
   Case "DATEEXCHANGE":z4901.DateExchange = Children(i).Code
   Case "DATETRANSFER":z4901.DateTransfer = Children(i).Code
   Case "DATEACCEPT":z4901.DateAccept = Children(i).Code
   Case "STATUSTRANSFER":z4901.StatusTransfer = Children(i).Code
   Case "SHIPPINGWORKORDERSTATUS":z4901.ShippingWorkOrderStatus = Children(i).Code
   Case "SESEASON":z4901.seSeason = Children(i).Code
   Case "CDSEASON":z4901.cdSeason = Children(i).Code
   Case "SEPAYMENTTERM":z4901.sePaymentTerm = Children(i).Code
   Case "CDPAYMENTTERM":z4901.cdPaymentTerm = Children(i).Code
   Case "SEDELIVERYTERM":z4901.seDeliveryTerm = Children(i).Code
   Case "CDDELIVERYTERM":z4901.cdDeliveryTerm = Children(i).Code
   Case "SESHIPPINGTERM":z4901.seShippingTerm = Children(i).Code
   Case "CDSHIPPINGTERM":z4901.cdShippingTerm = Children(i).Code
   Case "SEMARKETTYPE":z4901.seMarketType = Children(i).Code
   Case "CDMARKETTYPE":z4901.cdMarketType = Children(i).Code
   Case "SEDEPARTMENT":z4901.seDepartment = Children(i).Code
   Case "CDDEPARTMENT":z4901.cdDepartment = Children(i).Code
   Case "SEBRAND":z4901.seBrand = Children(i).Code
   Case "CDBRAND":z4901.cdBrand = Children(i).Code
   Case "CONTRACTIN":z4901.ContractIn = Children(i).Code
   Case "CONTRACTOUT":z4901.ContractOut = Children(i).Code
   Case "DESTINATION":z4901.Destination = Children(i).Code
   Case "CUSTPONO":z4901.CustPoNo = Children(i).Code
   Case "INCHARGESALES":z4901.InchargeSales = Children(i).Code
   Case "INCHARGEPPC":z4901.InchargePPC = Children(i).Code
   Case "DATEINSERT":z4901.DateInsert = Children(i).Code
   Case "DATEUPDATE":z4901.DateUpdate = Children(i).Code
   Case "TIMEINSERT":z4901.TimeInsert = Children(i).Code
   Case "TIMEUPDATE":z4901.TimeUpdate = Children(i).Code
   Case "TOTALQTY":z4901.TotalQty = Children(i).Code
   Case "TOTALAMOUNT":z4901.TotalAmount = Children(i).Code
   Case "TOTALCOST":z4901.TotalCost = Children(i).Code
   Case "TOTALPROFIT":z4901.TotalProfit = Children(i).Code
   Case "ATTACHID":z4901.AttachID = Children(i).Code
   Case "REMARKORDER":z4901.RemarkOrder = Children(i).Code
   Case "REMARKCUSTOMER":z4901.RemarkCustomer = Children(i).Code
   Case "REMARK":z4901.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "SHIPPINGWORKORDER":z4901.ShippingWorkOrder = Children(i).Data
   Case "SHIPPINGWORKORDERNAME":z4901.ShippingWorkOrderName = Children(i).Data
   Case "STATUS":z4901.Status = Children(i).Data
   Case "CUSTOMERCODE":z4901.CustomerCode = Children(i).Data
   Case "VENDORCODE":z4901.VendorCode = Children(i).Data
   Case "AGENTCODE":z4901.AgentCode = Children(i).Data
   Case "BUYER":z4901.Buyer = Children(i).Data
   Case "SEORDERGROUP":z4901.seOrderGroup = Children(i).Data
   Case "CDORDERGROUP":z4901.cdOrderGroup = Children(i).Data
   Case "SEORDERKIND":z4901.seOrderKind = Children(i).Data
   Case "CDORDERKIND":z4901.cdOrderKind = Children(i).Data
   Case "SEORDERTYPE":z4901.seOrderType = Children(i).Data
   Case "CDORDERTYPE":z4901.cdOrderType = Children(i).Data
   Case "CDORDERWORK":z4901.cdOrderWork = Children(i).Data
   Case "SEORDERWORK":z4901.seOrderWork = Children(i).Data
   Case "SESTATESAMPLE":z4901.seStateSample = Children(i).Data
   Case "CDSTATESAMPLE":z4901.cdStateSample = Children(i).Data
   Case "SESTATEOFFICIAL":z4901.seStateOfficial = Children(i).Data
   Case "CDSTATEOFFICIAL":z4901.cdStateOfficial = Children(i).Data
   Case "STATUSORDER":z4901.StatusOrder = Children(i).Data
   Case "DATEORDER":z4901.DateOrder = Children(i).Data
   Case "DATEAPPROVAL":z4901.DateApproval = Children(i).Data
   Case "DATECOMPLETE":z4901.DateComplete = Children(i).Data
   Case "DATECANCEL":z4901.DateCancel = Children(i).Data
   Case "DATEPENDING":z4901.DatePending = Children(i).Data
   Case "SEUNITPRICE":z4901.seUnitPrice = Children(i).Data
   Case "CDUNITPRICE":z4901.cdUnitPrice = Children(i).Data
   Case "PRICEEXCHANGE":z4901.PriceExchange = Children(i).Data
   Case "DATEEXCHANGE":z4901.DateExchange = Children(i).Data
   Case "DATETRANSFER":z4901.DateTransfer = Children(i).Data
   Case "DATEACCEPT":z4901.DateAccept = Children(i).Data
   Case "STATUSTRANSFER":z4901.StatusTransfer = Children(i).Data
   Case "SHIPPINGWORKORDERSTATUS":z4901.ShippingWorkOrderStatus = Children(i).Data
   Case "SESEASON":z4901.seSeason = Children(i).Data
   Case "CDSEASON":z4901.cdSeason = Children(i).Data
   Case "SEPAYMENTTERM":z4901.sePaymentTerm = Children(i).Data
   Case "CDPAYMENTTERM":z4901.cdPaymentTerm = Children(i).Data
   Case "SEDELIVERYTERM":z4901.seDeliveryTerm = Children(i).Data
   Case "CDDELIVERYTERM":z4901.cdDeliveryTerm = Children(i).Data
   Case "SESHIPPINGTERM":z4901.seShippingTerm = Children(i).Data
   Case "CDSHIPPINGTERM":z4901.cdShippingTerm = Children(i).Data
   Case "SEMARKETTYPE":z4901.seMarketType = Children(i).Data
   Case "CDMARKETTYPE":z4901.cdMarketType = Children(i).Data
   Case "SEDEPARTMENT":z4901.seDepartment = Children(i).Data
   Case "CDDEPARTMENT":z4901.cdDepartment = Children(i).Data
   Case "SEBRAND":z4901.seBrand = Children(i).Data
   Case "CDBRAND":z4901.cdBrand = Children(i).Data
   Case "CONTRACTIN":z4901.ContractIn = Children(i).Data
   Case "CONTRACTOUT":z4901.ContractOut = Children(i).Data
   Case "DESTINATION":z4901.Destination = Children(i).Data
   Case "CUSTPONO":z4901.CustPoNo = Children(i).Data
   Case "INCHARGESALES":z4901.InchargeSales = Children(i).Data
   Case "INCHARGEPPC":z4901.InchargePPC = Children(i).Data
   Case "DATEINSERT":z4901.DateInsert = Children(i).Data
   Case "DATEUPDATE":z4901.DateUpdate = Children(i).Data
   Case "TIMEINSERT":z4901.TimeInsert = Children(i).Data
   Case "TIMEUPDATE":z4901.TimeUpdate = Children(i).Data
   Case "TOTALQTY":z4901.TotalQty = Children(i).Data
   Case "TOTALAMOUNT":z4901.TotalAmount = Children(i).Data
   Case "TOTALCOST":z4901.TotalCost = Children(i).Data
   Case "TOTALPROFIT":z4901.TotalProfit = Children(i).Data
   Case "ATTACHID":z4901.AttachID = Children(i).Data
   Case "REMARKORDER":z4901.RemarkOrder = Children(i).Data
   Case "REMARKCUSTOMER":z4901.RemarkCustomer = Children(i).Data
   Case "REMARK":z4901.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K4901_MOVE",vbCritical)
End Try
End Function 
    
End Module 
