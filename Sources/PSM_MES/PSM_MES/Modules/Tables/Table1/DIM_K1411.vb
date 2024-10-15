'=========================================================================================================================================================
'   TABLE : (PFK1411)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K1411

Structure T1411_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	OrderNo	 AS String	'			char(9)		*
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
Public 	seSeason	 AS String	'			char(3)
Public 	cdSeason	 AS String	'			char(3)
Public 	seShippingTerm	 AS String	'			char(3)
Public 	cdShippingTerm	 AS String	'			char(3)
Public 	cdDeliveryTerm	 AS String	'			char(3)
Public 	seDeliveryTerm	 AS String	'			char(3)
Public 	sePaymentTerm	 AS String	'			char(3)
Public 	cdPaymentTerm	 AS String	'			char(3)
Public 	sePaymentCondition	 AS String	'			char(3)
Public 	cdPaymentCondition	 AS String	'			char(3)
Public 	sePaymentTime	 AS String	'			char(3)
Public 	cdPaymentTime	 AS String	'			char(3)
Public 	sePaymentDay	 AS String	'			char(3)
Public 	cdPaymentDay	 AS String	'			char(3)
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

Public D1411 As T1411_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK1411(ORDERNO AS String) As Boolean
    READ_PFK1411 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK1411 "
    SQL = SQL & " WHERE K1411_OrderNo		 = '" & OrderNo & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D1411_CLEAR: GoTo SKIP_READ_PFK1411
                
    Call K1411_MOVE(rd)
    READ_PFK1411 = True

SKIP_READ_PFK1411:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK1411",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK1411(ORDERNO AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK1411 "
    SQL = SQL & " WHERE K1411_OrderNo		 = '" & OrderNo & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK1411",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK1411(z1411 As T1411_AREA) As Boolean
    WRITE_PFK1411 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z1411)
 
    SQL = " INSERT INTO PFK1411 "
    SQL = SQL & " ( "
    SQL = SQL & " K1411_OrderNo," 
    SQL = SQL & " K1411_CustomerCode," 
    SQL = SQL & " K1411_VendorCode," 
    SQL = SQL & " K1411_AgentCode," 
    SQL = SQL & " K1411_Buyer," 
    SQL = SQL & " K1411_seOrderGroup," 
    SQL = SQL & " K1411_cdOrderGroup," 
    SQL = SQL & " K1411_seOrderKind," 
    SQL = SQL & " K1411_cdOrderKind," 
    SQL = SQL & " K1411_seOrderType," 
    SQL = SQL & " K1411_cdOrderType," 
    SQL = SQL & " K1411_cdOrderWork," 
    SQL = SQL & " K1411_seOrderWork," 
    SQL = SQL & " K1411_seStateSample," 
    SQL = SQL & " K1411_cdStateSample," 
    SQL = SQL & " K1411_seStateOfficial," 
    SQL = SQL & " K1411_cdStateOfficial," 
    SQL = SQL & " K1411_StatusOrder," 
    SQL = SQL & " K1411_DateOrder," 
    SQL = SQL & " K1411_DateApproval," 
    SQL = SQL & " K1411_DateComplete," 
    SQL = SQL & " K1411_DateCancel," 
    SQL = SQL & " K1411_DatePending," 
    SQL = SQL & " K1411_seUnitPrice," 
    SQL = SQL & " K1411_cdUnitPrice," 
    SQL = SQL & " K1411_PriceExchange," 
    SQL = SQL & " K1411_DateExchange," 
    SQL = SQL & " K1411_DateTransfer," 
    SQL = SQL & " K1411_DateAccept," 
    SQL = SQL & " K1411_StatusTransfer," 
    SQL = SQL & " K1411_seSeason," 
    SQL = SQL & " K1411_cdSeason," 
    SQL = SQL & " K1411_seShippingTerm," 
    SQL = SQL & " K1411_cdShippingTerm," 
    SQL = SQL & " K1411_cdDeliveryTerm," 
    SQL = SQL & " K1411_seDeliveryTerm," 
    SQL = SQL & " K1411_sePaymentTerm," 
    SQL = SQL & " K1411_cdPaymentTerm," 
    SQL = SQL & " K1411_sePaymentCondition," 
    SQL = SQL & " K1411_cdPaymentCondition," 
    SQL = SQL & " K1411_sePaymentTime," 
    SQL = SQL & " K1411_cdPaymentTime," 
    SQL = SQL & " K1411_sePaymentDay," 
    SQL = SQL & " K1411_cdPaymentDay," 
    SQL = SQL & " K1411_seMarketType," 
    SQL = SQL & " K1411_cdMarketType," 
    SQL = SQL & " K1411_seDepartment," 
    SQL = SQL & " K1411_cdDepartment," 
    SQL = SQL & " K1411_seBrand," 
    SQL = SQL & " K1411_cdBrand," 
    SQL = SQL & " K1411_ContractIn," 
    SQL = SQL & " K1411_ContractOut," 
    SQL = SQL & " K1411_Destination," 
    SQL = SQL & " K1411_CustPoNo," 
    SQL = SQL & " K1411_InchargeSales," 
    SQL = SQL & " K1411_InchargePPC," 
    SQL = SQL & " K1411_DateInsert," 
    SQL = SQL & " K1411_DateUpdate," 
    SQL = SQL & " K1411_TimeInsert," 
    SQL = SQL & " K1411_TimeUpdate," 
    SQL = SQL & " K1411_TotalQty," 
    SQL = SQL & " K1411_TotalAmount," 
    SQL = SQL & " K1411_TotalCost," 
    SQL = SQL & " K1411_TotalProfit," 
    SQL = SQL & " K1411_AttachID," 
    SQL = SQL & " K1411_RemarkOrder," 
    SQL = SQL & " K1411_RemarkCustomer," 
    SQL = SQL & " K1411_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z1411.OrderNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1411.CustomerCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1411.VendorCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1411.AgentCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1411.Buyer) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1411.seOrderGroup) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1411.cdOrderGroup) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1411.seOrderKind) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1411.cdOrderKind) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1411.seOrderType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1411.cdOrderType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1411.cdOrderWork) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1411.seOrderWork) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1411.seStateSample) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1411.cdStateSample) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1411.seStateOfficial) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1411.cdStateOfficial) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1411.StatusOrder) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1411.DateOrder) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1411.DateApproval) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1411.DateComplete) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1411.DateCancel) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1411.DatePending) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1411.seUnitPrice) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1411.cdUnitPrice) & "', "  
    SQL = SQL & "   " & FormatSQL(z1411.PriceExchange) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z1411.DateExchange) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1411.DateTransfer) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1411.DateAccept) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1411.StatusTransfer) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1411.seSeason) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1411.cdSeason) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1411.seShippingTerm) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1411.cdShippingTerm) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1411.cdDeliveryTerm) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1411.seDeliveryTerm) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1411.sePaymentTerm) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1411.cdPaymentTerm) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1411.sePaymentCondition) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1411.cdPaymentCondition) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1411.sePaymentTime) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1411.cdPaymentTime) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1411.sePaymentDay) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1411.cdPaymentDay) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1411.seMarketType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1411.cdMarketType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1411.seDepartment) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1411.cdDepartment) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1411.seBrand) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1411.cdBrand) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1411.ContractIn) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1411.ContractOut) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1411.Destination) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1411.CustPoNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1411.InchargeSales) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1411.InchargePPC) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1411.DateInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1411.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1411.TimeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1411.TimeUpdate) & "', "  
    SQL = SQL & "   " & FormatSQL(z1411.TotalQty) & ", "  
    SQL = SQL & "   " & FormatSQL(z1411.TotalAmount) & ", "  
    SQL = SQL & "   " & FormatSQL(z1411.TotalCost) & ", "  
    SQL = SQL & "   " & FormatSQL(z1411.TotalProfit) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z1411.AttachID) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1411.RemarkOrder) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1411.RemarkCustomer) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1411.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK1411 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK1411",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK1411(z1411 As T1411_AREA) As Boolean
    REWRITE_PFK1411 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z1411)
   
    SQL = " UPDATE PFK1411 SET "
    SQL = SQL & "    K1411_CustomerCode      = N'" & FormatSQL(z1411.CustomerCode) & "', " 
    SQL = SQL & "    K1411_VendorCode      = N'" & FormatSQL(z1411.VendorCode) & "', " 
    SQL = SQL & "    K1411_AgentCode      = N'" & FormatSQL(z1411.AgentCode) & "', " 
    SQL = SQL & "    K1411_Buyer      = N'" & FormatSQL(z1411.Buyer) & "', " 
    SQL = SQL & "    K1411_seOrderGroup      = N'" & FormatSQL(z1411.seOrderGroup) & "', " 
    SQL = SQL & "    K1411_cdOrderGroup      = N'" & FormatSQL(z1411.cdOrderGroup) & "', " 
    SQL = SQL & "    K1411_seOrderKind      = N'" & FormatSQL(z1411.seOrderKind) & "', " 
    SQL = SQL & "    K1411_cdOrderKind      = N'" & FormatSQL(z1411.cdOrderKind) & "', " 
    SQL = SQL & "    K1411_seOrderType      = N'" & FormatSQL(z1411.seOrderType) & "', " 
    SQL = SQL & "    K1411_cdOrderType      = N'" & FormatSQL(z1411.cdOrderType) & "', " 
    SQL = SQL & "    K1411_cdOrderWork      = N'" & FormatSQL(z1411.cdOrderWork) & "', " 
    SQL = SQL & "    K1411_seOrderWork      = N'" & FormatSQL(z1411.seOrderWork) & "', " 
    SQL = SQL & "    K1411_seStateSample      = N'" & FormatSQL(z1411.seStateSample) & "', " 
    SQL = SQL & "    K1411_cdStateSample      = N'" & FormatSQL(z1411.cdStateSample) & "', " 
    SQL = SQL & "    K1411_seStateOfficial      = N'" & FormatSQL(z1411.seStateOfficial) & "', " 
    SQL = SQL & "    K1411_cdStateOfficial      = N'" & FormatSQL(z1411.cdStateOfficial) & "', " 
    SQL = SQL & "    K1411_StatusOrder      = N'" & FormatSQL(z1411.StatusOrder) & "', " 
    SQL = SQL & "    K1411_DateOrder      = N'" & FormatSQL(z1411.DateOrder) & "', " 
    SQL = SQL & "    K1411_DateApproval      = N'" & FormatSQL(z1411.DateApproval) & "', " 
    SQL = SQL & "    K1411_DateComplete      = N'" & FormatSQL(z1411.DateComplete) & "', " 
    SQL = SQL & "    K1411_DateCancel      = N'" & FormatSQL(z1411.DateCancel) & "', " 
    SQL = SQL & "    K1411_DatePending      = N'" & FormatSQL(z1411.DatePending) & "', " 
    SQL = SQL & "    K1411_seUnitPrice      = N'" & FormatSQL(z1411.seUnitPrice) & "', " 
    SQL = SQL & "    K1411_cdUnitPrice      = N'" & FormatSQL(z1411.cdUnitPrice) & "', " 
    SQL = SQL & "    K1411_PriceExchange      =  " & FormatSQL(z1411.PriceExchange) & ", " 
    SQL = SQL & "    K1411_DateExchange      = N'" & FormatSQL(z1411.DateExchange) & "', " 
    SQL = SQL & "    K1411_DateTransfer      = N'" & FormatSQL(z1411.DateTransfer) & "', " 
    SQL = SQL & "    K1411_DateAccept      = N'" & FormatSQL(z1411.DateAccept) & "', " 
    SQL = SQL & "    K1411_StatusTransfer      = N'" & FormatSQL(z1411.StatusTransfer) & "', " 
    SQL = SQL & "    K1411_seSeason      = N'" & FormatSQL(z1411.seSeason) & "', " 
    SQL = SQL & "    K1411_cdSeason      = N'" & FormatSQL(z1411.cdSeason) & "', " 
    SQL = SQL & "    K1411_seShippingTerm      = N'" & FormatSQL(z1411.seShippingTerm) & "', " 
    SQL = SQL & "    K1411_cdShippingTerm      = N'" & FormatSQL(z1411.cdShippingTerm) & "', " 
    SQL = SQL & "    K1411_cdDeliveryTerm      = N'" & FormatSQL(z1411.cdDeliveryTerm) & "', " 
    SQL = SQL & "    K1411_seDeliveryTerm      = N'" & FormatSQL(z1411.seDeliveryTerm) & "', " 
    SQL = SQL & "    K1411_sePaymentTerm      = N'" & FormatSQL(z1411.sePaymentTerm) & "', " 
    SQL = SQL & "    K1411_cdPaymentTerm      = N'" & FormatSQL(z1411.cdPaymentTerm) & "', " 
    SQL = SQL & "    K1411_sePaymentCondition      = N'" & FormatSQL(z1411.sePaymentCondition) & "', " 
    SQL = SQL & "    K1411_cdPaymentCondition      = N'" & FormatSQL(z1411.cdPaymentCondition) & "', " 
    SQL = SQL & "    K1411_sePaymentTime      = N'" & FormatSQL(z1411.sePaymentTime) & "', " 
    SQL = SQL & "    K1411_cdPaymentTime      = N'" & FormatSQL(z1411.cdPaymentTime) & "', " 
    SQL = SQL & "    K1411_sePaymentDay      = N'" & FormatSQL(z1411.sePaymentDay) & "', " 
    SQL = SQL & "    K1411_cdPaymentDay      = N'" & FormatSQL(z1411.cdPaymentDay) & "', " 
    SQL = SQL & "    K1411_seMarketType      = N'" & FormatSQL(z1411.seMarketType) & "', " 
    SQL = SQL & "    K1411_cdMarketType      = N'" & FormatSQL(z1411.cdMarketType) & "', " 
    SQL = SQL & "    K1411_seDepartment      = N'" & FormatSQL(z1411.seDepartment) & "', " 
    SQL = SQL & "    K1411_cdDepartment      = N'" & FormatSQL(z1411.cdDepartment) & "', " 
    SQL = SQL & "    K1411_seBrand      = N'" & FormatSQL(z1411.seBrand) & "', " 
    SQL = SQL & "    K1411_cdBrand      = N'" & FormatSQL(z1411.cdBrand) & "', " 
    SQL = SQL & "    K1411_ContractIn      = N'" & FormatSQL(z1411.ContractIn) & "', " 
    SQL = SQL & "    K1411_ContractOut      = N'" & FormatSQL(z1411.ContractOut) & "', " 
    SQL = SQL & "    K1411_Destination      = N'" & FormatSQL(z1411.Destination) & "', " 
    SQL = SQL & "    K1411_CustPoNo      = N'" & FormatSQL(z1411.CustPoNo) & "', " 
    SQL = SQL & "    K1411_InchargeSales      = N'" & FormatSQL(z1411.InchargeSales) & "', " 
    SQL = SQL & "    K1411_InchargePPC      = N'" & FormatSQL(z1411.InchargePPC) & "', " 
    SQL = SQL & "    K1411_DateInsert      = N'" & FormatSQL(z1411.DateInsert) & "', " 
    SQL = SQL & "    K1411_DateUpdate      = N'" & FormatSQL(z1411.DateUpdate) & "', " 
    SQL = SQL & "    K1411_TimeInsert      = N'" & FormatSQL(z1411.TimeInsert) & "', " 
    SQL = SQL & "    K1411_TimeUpdate      = N'" & FormatSQL(z1411.TimeUpdate) & "', " 
    SQL = SQL & "    K1411_TotalQty      =  " & FormatSQL(z1411.TotalQty) & ", " 
    SQL = SQL & "    K1411_TotalAmount      =  " & FormatSQL(z1411.TotalAmount) & ", " 
    SQL = SQL & "    K1411_TotalCost      =  " & FormatSQL(z1411.TotalCost) & ", " 
    SQL = SQL & "    K1411_TotalProfit      =  " & FormatSQL(z1411.TotalProfit) & ", " 
    SQL = SQL & "    K1411_AttachID      = N'" & FormatSQL(z1411.AttachID) & "', " 
    SQL = SQL & "    K1411_RemarkOrder      = N'" & FormatSQL(z1411.RemarkOrder) & "', " 
    SQL = SQL & "    K1411_RemarkCustomer      = N'" & FormatSQL(z1411.RemarkCustomer) & "', " 
    SQL = SQL & "    K1411_Remark      = N'" & FormatSQL(z1411.Remark) & "'  " 
    SQL = SQL & " WHERE K1411_OrderNo		 = '" & z1411.OrderNo & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK1411 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK1411",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK1411(z1411 As T1411_AREA) As Boolean
    DELETE_PFK1411 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK1411 "
    SQL = SQL & " WHERE K1411_OrderNo		 = '" & z1411.OrderNo & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK1411 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK1411",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D1411_CLEAR()
Try
    
   D1411.OrderNo = ""
   D1411.CustomerCode = ""
   D1411.VendorCode = ""
   D1411.AgentCode = ""
   D1411.Buyer = ""
   D1411.seOrderGroup = ""
   D1411.cdOrderGroup = ""
   D1411.seOrderKind = ""
   D1411.cdOrderKind = ""
   D1411.seOrderType = ""
   D1411.cdOrderType = ""
   D1411.cdOrderWork = ""
   D1411.seOrderWork = ""
   D1411.seStateSample = ""
   D1411.cdStateSample = ""
   D1411.seStateOfficial = ""
   D1411.cdStateOfficial = ""
   D1411.StatusOrder = ""
   D1411.DateOrder = ""
   D1411.DateApproval = ""
   D1411.DateComplete = ""
   D1411.DateCancel = ""
   D1411.DatePending = ""
   D1411.seUnitPrice = ""
   D1411.cdUnitPrice = ""
    D1411.PriceExchange = 0 
   D1411.DateExchange = ""
   D1411.DateTransfer = ""
   D1411.DateAccept = ""
   D1411.StatusTransfer = ""
   D1411.seSeason = ""
   D1411.cdSeason = ""
   D1411.seShippingTerm = ""
   D1411.cdShippingTerm = ""
   D1411.cdDeliveryTerm = ""
   D1411.seDeliveryTerm = ""
   D1411.sePaymentTerm = ""
   D1411.cdPaymentTerm = ""
   D1411.sePaymentCondition = ""
   D1411.cdPaymentCondition = ""
   D1411.sePaymentTime = ""
   D1411.cdPaymentTime = ""
   D1411.sePaymentDay = ""
   D1411.cdPaymentDay = ""
   D1411.seMarketType = ""
   D1411.cdMarketType = ""
   D1411.seDepartment = ""
   D1411.cdDepartment = ""
   D1411.seBrand = ""
   D1411.cdBrand = ""
   D1411.ContractIn = ""
   D1411.ContractOut = ""
   D1411.Destination = ""
   D1411.CustPoNo = ""
   D1411.InchargeSales = ""
   D1411.InchargePPC = ""
   D1411.DateInsert = ""
   D1411.DateUpdate = ""
   D1411.TimeInsert = ""
   D1411.TimeUpdate = ""
    D1411.TotalQty = 0 
    D1411.TotalAmount = 0 
    D1411.TotalCost = 0 
    D1411.TotalProfit = 0 
   D1411.AttachID = ""
   D1411.RemarkOrder = ""
   D1411.RemarkCustomer = ""
   D1411.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D1411_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x1411 As T1411_AREA)
Try
    
    x1411.OrderNo = trim$(  x1411.OrderNo)
    x1411.CustomerCode = trim$(  x1411.CustomerCode)
    x1411.VendorCode = trim$(  x1411.VendorCode)
    x1411.AgentCode = trim$(  x1411.AgentCode)
    x1411.Buyer = trim$(  x1411.Buyer)
    x1411.seOrderGroup = trim$(  x1411.seOrderGroup)
    x1411.cdOrderGroup = trim$(  x1411.cdOrderGroup)
    x1411.seOrderKind = trim$(  x1411.seOrderKind)
    x1411.cdOrderKind = trim$(  x1411.cdOrderKind)
    x1411.seOrderType = trim$(  x1411.seOrderType)
    x1411.cdOrderType = trim$(  x1411.cdOrderType)
    x1411.cdOrderWork = trim$(  x1411.cdOrderWork)
    x1411.seOrderWork = trim$(  x1411.seOrderWork)
    x1411.seStateSample = trim$(  x1411.seStateSample)
    x1411.cdStateSample = trim$(  x1411.cdStateSample)
    x1411.seStateOfficial = trim$(  x1411.seStateOfficial)
    x1411.cdStateOfficial = trim$(  x1411.cdStateOfficial)
    x1411.StatusOrder = trim$(  x1411.StatusOrder)
    x1411.DateOrder = trim$(  x1411.DateOrder)
    x1411.DateApproval = trim$(  x1411.DateApproval)
    x1411.DateComplete = trim$(  x1411.DateComplete)
    x1411.DateCancel = trim$(  x1411.DateCancel)
    x1411.DatePending = trim$(  x1411.DatePending)
    x1411.seUnitPrice = trim$(  x1411.seUnitPrice)
    x1411.cdUnitPrice = trim$(  x1411.cdUnitPrice)
    x1411.PriceExchange = trim$(  x1411.PriceExchange)
    x1411.DateExchange = trim$(  x1411.DateExchange)
    x1411.DateTransfer = trim$(  x1411.DateTransfer)
    x1411.DateAccept = trim$(  x1411.DateAccept)
    x1411.StatusTransfer = trim$(  x1411.StatusTransfer)
    x1411.seSeason = trim$(  x1411.seSeason)
    x1411.cdSeason = trim$(  x1411.cdSeason)
    x1411.seShippingTerm = trim$(  x1411.seShippingTerm)
    x1411.cdShippingTerm = trim$(  x1411.cdShippingTerm)
    x1411.cdDeliveryTerm = trim$(  x1411.cdDeliveryTerm)
    x1411.seDeliveryTerm = trim$(  x1411.seDeliveryTerm)
    x1411.sePaymentTerm = trim$(  x1411.sePaymentTerm)
    x1411.cdPaymentTerm = trim$(  x1411.cdPaymentTerm)
    x1411.sePaymentCondition = trim$(  x1411.sePaymentCondition)
    x1411.cdPaymentCondition = trim$(  x1411.cdPaymentCondition)
    x1411.sePaymentTime = trim$(  x1411.sePaymentTime)
    x1411.cdPaymentTime = trim$(  x1411.cdPaymentTime)
    x1411.sePaymentDay = trim$(  x1411.sePaymentDay)
    x1411.cdPaymentDay = trim$(  x1411.cdPaymentDay)
    x1411.seMarketType = trim$(  x1411.seMarketType)
    x1411.cdMarketType = trim$(  x1411.cdMarketType)
    x1411.seDepartment = trim$(  x1411.seDepartment)
    x1411.cdDepartment = trim$(  x1411.cdDepartment)
    x1411.seBrand = trim$(  x1411.seBrand)
    x1411.cdBrand = trim$(  x1411.cdBrand)
    x1411.ContractIn = trim$(  x1411.ContractIn)
    x1411.ContractOut = trim$(  x1411.ContractOut)
    x1411.Destination = trim$(  x1411.Destination)
    x1411.CustPoNo = trim$(  x1411.CustPoNo)
    x1411.InchargeSales = trim$(  x1411.InchargeSales)
    x1411.InchargePPC = trim$(  x1411.InchargePPC)
    x1411.DateInsert = trim$(  x1411.DateInsert)
    x1411.DateUpdate = trim$(  x1411.DateUpdate)
    x1411.TimeInsert = trim$(  x1411.TimeInsert)
    x1411.TimeUpdate = trim$(  x1411.TimeUpdate)
    x1411.TotalQty = trim$(  x1411.TotalQty)
    x1411.TotalAmount = trim$(  x1411.TotalAmount)
    x1411.TotalCost = trim$(  x1411.TotalCost)
    x1411.TotalProfit = trim$(  x1411.TotalProfit)
    x1411.AttachID = trim$(  x1411.AttachID)
    x1411.RemarkOrder = trim$(  x1411.RemarkOrder)
    x1411.RemarkCustomer = trim$(  x1411.RemarkCustomer)
    x1411.Remark = trim$(  x1411.Remark)
     
    If trim$( x1411.OrderNo ) = "" Then x1411.OrderNo = Space(1) 
    If trim$( x1411.CustomerCode ) = "" Then x1411.CustomerCode = Space(1) 
    If trim$( x1411.VendorCode ) = "" Then x1411.VendorCode = Space(1) 
    If trim$( x1411.AgentCode ) = "" Then x1411.AgentCode = Space(1) 
    If trim$( x1411.Buyer ) = "" Then x1411.Buyer = Space(1) 
    If trim$( x1411.seOrderGroup ) = "" Then x1411.seOrderGroup = Space(1) 
    If trim$( x1411.cdOrderGroup ) = "" Then x1411.cdOrderGroup = Space(1) 
    If trim$( x1411.seOrderKind ) = "" Then x1411.seOrderKind = Space(1) 
    If trim$( x1411.cdOrderKind ) = "" Then x1411.cdOrderKind = Space(1) 
    If trim$( x1411.seOrderType ) = "" Then x1411.seOrderType = Space(1) 
    If trim$( x1411.cdOrderType ) = "" Then x1411.cdOrderType = Space(1) 
    If trim$( x1411.cdOrderWork ) = "" Then x1411.cdOrderWork = Space(1) 
    If trim$( x1411.seOrderWork ) = "" Then x1411.seOrderWork = Space(1) 
    If trim$( x1411.seStateSample ) = "" Then x1411.seStateSample = Space(1) 
    If trim$( x1411.cdStateSample ) = "" Then x1411.cdStateSample = Space(1) 
    If trim$( x1411.seStateOfficial ) = "" Then x1411.seStateOfficial = Space(1) 
    If trim$( x1411.cdStateOfficial ) = "" Then x1411.cdStateOfficial = Space(1) 
    If trim$( x1411.StatusOrder ) = "" Then x1411.StatusOrder = Space(1) 
    If trim$( x1411.DateOrder ) = "" Then x1411.DateOrder = Space(1) 
    If trim$( x1411.DateApproval ) = "" Then x1411.DateApproval = Space(1) 
    If trim$( x1411.DateComplete ) = "" Then x1411.DateComplete = Space(1) 
    If trim$( x1411.DateCancel ) = "" Then x1411.DateCancel = Space(1) 
    If trim$( x1411.DatePending ) = "" Then x1411.DatePending = Space(1) 
    If trim$( x1411.seUnitPrice ) = "" Then x1411.seUnitPrice = Space(1) 
    If trim$( x1411.cdUnitPrice ) = "" Then x1411.cdUnitPrice = Space(1) 
    If trim$( x1411.PriceExchange ) = "" Then x1411.PriceExchange = 0 
    If trim$( x1411.DateExchange ) = "" Then x1411.DateExchange = Space(1) 
    If trim$( x1411.DateTransfer ) = "" Then x1411.DateTransfer = Space(1) 
    If trim$( x1411.DateAccept ) = "" Then x1411.DateAccept = Space(1) 
    If trim$( x1411.StatusTransfer ) = "" Then x1411.StatusTransfer = Space(1) 
    If trim$( x1411.seSeason ) = "" Then x1411.seSeason = Space(1) 
    If trim$( x1411.cdSeason ) = "" Then x1411.cdSeason = Space(1) 
    If trim$( x1411.seShippingTerm ) = "" Then x1411.seShippingTerm = Space(1) 
    If trim$( x1411.cdShippingTerm ) = "" Then x1411.cdShippingTerm = Space(1) 
    If trim$( x1411.cdDeliveryTerm ) = "" Then x1411.cdDeliveryTerm = Space(1) 
    If trim$( x1411.seDeliveryTerm ) = "" Then x1411.seDeliveryTerm = Space(1) 
    If trim$( x1411.sePaymentTerm ) = "" Then x1411.sePaymentTerm = Space(1) 
    If trim$( x1411.cdPaymentTerm ) = "" Then x1411.cdPaymentTerm = Space(1) 
    If trim$( x1411.sePaymentCondition ) = "" Then x1411.sePaymentCondition = Space(1) 
    If trim$( x1411.cdPaymentCondition ) = "" Then x1411.cdPaymentCondition = Space(1) 
    If trim$( x1411.sePaymentTime ) = "" Then x1411.sePaymentTime = Space(1) 
    If trim$( x1411.cdPaymentTime ) = "" Then x1411.cdPaymentTime = Space(1) 
    If trim$( x1411.sePaymentDay ) = "" Then x1411.sePaymentDay = Space(1) 
    If trim$( x1411.cdPaymentDay ) = "" Then x1411.cdPaymentDay = Space(1) 
    If trim$( x1411.seMarketType ) = "" Then x1411.seMarketType = Space(1) 
    If trim$( x1411.cdMarketType ) = "" Then x1411.cdMarketType = Space(1) 
    If trim$( x1411.seDepartment ) = "" Then x1411.seDepartment = Space(1) 
    If trim$( x1411.cdDepartment ) = "" Then x1411.cdDepartment = Space(1) 
    If trim$( x1411.seBrand ) = "" Then x1411.seBrand = Space(1) 
    If trim$( x1411.cdBrand ) = "" Then x1411.cdBrand = Space(1) 
    If trim$( x1411.ContractIn ) = "" Then x1411.ContractIn = Space(1) 
    If trim$( x1411.ContractOut ) = "" Then x1411.ContractOut = Space(1) 
    If trim$( x1411.Destination ) = "" Then x1411.Destination = Space(1) 
    If trim$( x1411.CustPoNo ) = "" Then x1411.CustPoNo = Space(1) 
    If trim$( x1411.InchargeSales ) = "" Then x1411.InchargeSales = Space(1) 
    If trim$( x1411.InchargePPC ) = "" Then x1411.InchargePPC = Space(1) 
    If trim$( x1411.DateInsert ) = "" Then x1411.DateInsert = Space(1) 
    If trim$( x1411.DateUpdate ) = "" Then x1411.DateUpdate = Space(1) 
    If trim$( x1411.TimeInsert ) = "" Then x1411.TimeInsert = Space(1) 
    If trim$( x1411.TimeUpdate ) = "" Then x1411.TimeUpdate = Space(1) 
    If trim$( x1411.TotalQty ) = "" Then x1411.TotalQty = 0 
    If trim$( x1411.TotalAmount ) = "" Then x1411.TotalAmount = 0 
    If trim$( x1411.TotalCost ) = "" Then x1411.TotalCost = 0 
    If trim$( x1411.TotalProfit ) = "" Then x1411.TotalProfit = 0 
    If trim$( x1411.AttachID ) = "" Then x1411.AttachID = Space(1) 
    If trim$( x1411.RemarkOrder ) = "" Then x1411.RemarkOrder = Space(1) 
    If trim$( x1411.RemarkCustomer ) = "" Then x1411.RemarkCustomer = Space(1) 
    If trim$( x1411.Remark ) = "" Then x1411.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K1411_MOVE(rs1411 As SqlClient.SqlDataReader)
Try

    call D1411_CLEAR()   

    If IsdbNull(rs1411!K1411_OrderNo) = False Then D1411.OrderNo = Trim$(rs1411!K1411_OrderNo)
    If IsdbNull(rs1411!K1411_CustomerCode) = False Then D1411.CustomerCode = Trim$(rs1411!K1411_CustomerCode)
    If IsdbNull(rs1411!K1411_VendorCode) = False Then D1411.VendorCode = Trim$(rs1411!K1411_VendorCode)
    If IsdbNull(rs1411!K1411_AgentCode) = False Then D1411.AgentCode = Trim$(rs1411!K1411_AgentCode)
    If IsdbNull(rs1411!K1411_Buyer) = False Then D1411.Buyer = Trim$(rs1411!K1411_Buyer)
    If IsdbNull(rs1411!K1411_seOrderGroup) = False Then D1411.seOrderGroup = Trim$(rs1411!K1411_seOrderGroup)
    If IsdbNull(rs1411!K1411_cdOrderGroup) = False Then D1411.cdOrderGroup = Trim$(rs1411!K1411_cdOrderGroup)
    If IsdbNull(rs1411!K1411_seOrderKind) = False Then D1411.seOrderKind = Trim$(rs1411!K1411_seOrderKind)
    If IsdbNull(rs1411!K1411_cdOrderKind) = False Then D1411.cdOrderKind = Trim$(rs1411!K1411_cdOrderKind)
    If IsdbNull(rs1411!K1411_seOrderType) = False Then D1411.seOrderType = Trim$(rs1411!K1411_seOrderType)
    If IsdbNull(rs1411!K1411_cdOrderType) = False Then D1411.cdOrderType = Trim$(rs1411!K1411_cdOrderType)
    If IsdbNull(rs1411!K1411_cdOrderWork) = False Then D1411.cdOrderWork = Trim$(rs1411!K1411_cdOrderWork)
    If IsdbNull(rs1411!K1411_seOrderWork) = False Then D1411.seOrderWork = Trim$(rs1411!K1411_seOrderWork)
    If IsdbNull(rs1411!K1411_seStateSample) = False Then D1411.seStateSample = Trim$(rs1411!K1411_seStateSample)
    If IsdbNull(rs1411!K1411_cdStateSample) = False Then D1411.cdStateSample = Trim$(rs1411!K1411_cdStateSample)
    If IsdbNull(rs1411!K1411_seStateOfficial) = False Then D1411.seStateOfficial = Trim$(rs1411!K1411_seStateOfficial)
    If IsdbNull(rs1411!K1411_cdStateOfficial) = False Then D1411.cdStateOfficial = Trim$(rs1411!K1411_cdStateOfficial)
    If IsdbNull(rs1411!K1411_StatusOrder) = False Then D1411.StatusOrder = Trim$(rs1411!K1411_StatusOrder)
    If IsdbNull(rs1411!K1411_DateOrder) = False Then D1411.DateOrder = Trim$(rs1411!K1411_DateOrder)
    If IsdbNull(rs1411!K1411_DateApproval) = False Then D1411.DateApproval = Trim$(rs1411!K1411_DateApproval)
    If IsdbNull(rs1411!K1411_DateComplete) = False Then D1411.DateComplete = Trim$(rs1411!K1411_DateComplete)
    If IsdbNull(rs1411!K1411_DateCancel) = False Then D1411.DateCancel = Trim$(rs1411!K1411_DateCancel)
    If IsdbNull(rs1411!K1411_DatePending) = False Then D1411.DatePending = Trim$(rs1411!K1411_DatePending)
    If IsdbNull(rs1411!K1411_seUnitPrice) = False Then D1411.seUnitPrice = Trim$(rs1411!K1411_seUnitPrice)
    If IsdbNull(rs1411!K1411_cdUnitPrice) = False Then D1411.cdUnitPrice = Trim$(rs1411!K1411_cdUnitPrice)
    If IsdbNull(rs1411!K1411_PriceExchange) = False Then D1411.PriceExchange = Trim$(rs1411!K1411_PriceExchange)
    If IsdbNull(rs1411!K1411_DateExchange) = False Then D1411.DateExchange = Trim$(rs1411!K1411_DateExchange)
    If IsdbNull(rs1411!K1411_DateTransfer) = False Then D1411.DateTransfer = Trim$(rs1411!K1411_DateTransfer)
    If IsdbNull(rs1411!K1411_DateAccept) = False Then D1411.DateAccept = Trim$(rs1411!K1411_DateAccept)
    If IsdbNull(rs1411!K1411_StatusTransfer) = False Then D1411.StatusTransfer = Trim$(rs1411!K1411_StatusTransfer)
    If IsdbNull(rs1411!K1411_seSeason) = False Then D1411.seSeason = Trim$(rs1411!K1411_seSeason)
    If IsdbNull(rs1411!K1411_cdSeason) = False Then D1411.cdSeason = Trim$(rs1411!K1411_cdSeason)
    If IsdbNull(rs1411!K1411_seShippingTerm) = False Then D1411.seShippingTerm = Trim$(rs1411!K1411_seShippingTerm)
    If IsdbNull(rs1411!K1411_cdShippingTerm) = False Then D1411.cdShippingTerm = Trim$(rs1411!K1411_cdShippingTerm)
    If IsdbNull(rs1411!K1411_cdDeliveryTerm) = False Then D1411.cdDeliveryTerm = Trim$(rs1411!K1411_cdDeliveryTerm)
    If IsdbNull(rs1411!K1411_seDeliveryTerm) = False Then D1411.seDeliveryTerm = Trim$(rs1411!K1411_seDeliveryTerm)
    If IsdbNull(rs1411!K1411_sePaymentTerm) = False Then D1411.sePaymentTerm = Trim$(rs1411!K1411_sePaymentTerm)
    If IsdbNull(rs1411!K1411_cdPaymentTerm) = False Then D1411.cdPaymentTerm = Trim$(rs1411!K1411_cdPaymentTerm)
    If IsdbNull(rs1411!K1411_sePaymentCondition) = False Then D1411.sePaymentCondition = Trim$(rs1411!K1411_sePaymentCondition)
    If IsdbNull(rs1411!K1411_cdPaymentCondition) = False Then D1411.cdPaymentCondition = Trim$(rs1411!K1411_cdPaymentCondition)
    If IsdbNull(rs1411!K1411_sePaymentTime) = False Then D1411.sePaymentTime = Trim$(rs1411!K1411_sePaymentTime)
    If IsdbNull(rs1411!K1411_cdPaymentTime) = False Then D1411.cdPaymentTime = Trim$(rs1411!K1411_cdPaymentTime)
    If IsdbNull(rs1411!K1411_sePaymentDay) = False Then D1411.sePaymentDay = Trim$(rs1411!K1411_sePaymentDay)
    If IsdbNull(rs1411!K1411_cdPaymentDay) = False Then D1411.cdPaymentDay = Trim$(rs1411!K1411_cdPaymentDay)
    If IsdbNull(rs1411!K1411_seMarketType) = False Then D1411.seMarketType = Trim$(rs1411!K1411_seMarketType)
    If IsdbNull(rs1411!K1411_cdMarketType) = False Then D1411.cdMarketType = Trim$(rs1411!K1411_cdMarketType)
    If IsdbNull(rs1411!K1411_seDepartment) = False Then D1411.seDepartment = Trim$(rs1411!K1411_seDepartment)
    If IsdbNull(rs1411!K1411_cdDepartment) = False Then D1411.cdDepartment = Trim$(rs1411!K1411_cdDepartment)
    If IsdbNull(rs1411!K1411_seBrand) = False Then D1411.seBrand = Trim$(rs1411!K1411_seBrand)
    If IsdbNull(rs1411!K1411_cdBrand) = False Then D1411.cdBrand = Trim$(rs1411!K1411_cdBrand)
    If IsdbNull(rs1411!K1411_ContractIn) = False Then D1411.ContractIn = Trim$(rs1411!K1411_ContractIn)
    If IsdbNull(rs1411!K1411_ContractOut) = False Then D1411.ContractOut = Trim$(rs1411!K1411_ContractOut)
    If IsdbNull(rs1411!K1411_Destination) = False Then D1411.Destination = Trim$(rs1411!K1411_Destination)
    If IsdbNull(rs1411!K1411_CustPoNo) = False Then D1411.CustPoNo = Trim$(rs1411!K1411_CustPoNo)
    If IsdbNull(rs1411!K1411_InchargeSales) = False Then D1411.InchargeSales = Trim$(rs1411!K1411_InchargeSales)
    If IsdbNull(rs1411!K1411_InchargePPC) = False Then D1411.InchargePPC = Trim$(rs1411!K1411_InchargePPC)
    If IsdbNull(rs1411!K1411_DateInsert) = False Then D1411.DateInsert = Trim$(rs1411!K1411_DateInsert)
    If IsdbNull(rs1411!K1411_DateUpdate) = False Then D1411.DateUpdate = Trim$(rs1411!K1411_DateUpdate)
    If IsdbNull(rs1411!K1411_TimeInsert) = False Then D1411.TimeInsert = Trim$(rs1411!K1411_TimeInsert)
    If IsdbNull(rs1411!K1411_TimeUpdate) = False Then D1411.TimeUpdate = Trim$(rs1411!K1411_TimeUpdate)
    If IsdbNull(rs1411!K1411_TotalQty) = False Then D1411.TotalQty = Trim$(rs1411!K1411_TotalQty)
    If IsdbNull(rs1411!K1411_TotalAmount) = False Then D1411.TotalAmount = Trim$(rs1411!K1411_TotalAmount)
    If IsdbNull(rs1411!K1411_TotalCost) = False Then D1411.TotalCost = Trim$(rs1411!K1411_TotalCost)
    If IsdbNull(rs1411!K1411_TotalProfit) = False Then D1411.TotalProfit = Trim$(rs1411!K1411_TotalProfit)
    If IsdbNull(rs1411!K1411_AttachID) = False Then D1411.AttachID = Trim$(rs1411!K1411_AttachID)
    If IsdbNull(rs1411!K1411_RemarkOrder) = False Then D1411.RemarkOrder = Trim$(rs1411!K1411_RemarkOrder)
    If IsdbNull(rs1411!K1411_RemarkCustomer) = False Then D1411.RemarkCustomer = Trim$(rs1411!K1411_RemarkCustomer)
    If IsdbNull(rs1411!K1411_Remark) = False Then D1411.Remark = Trim$(rs1411!K1411_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K1411_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K1411_MOVE(rs1411 As DataRow)
Try

    call D1411_CLEAR()   

    If IsdbNull(rs1411!K1411_OrderNo) = False Then D1411.OrderNo = Trim$(rs1411!K1411_OrderNo)
    If IsdbNull(rs1411!K1411_CustomerCode) = False Then D1411.CustomerCode = Trim$(rs1411!K1411_CustomerCode)
    If IsdbNull(rs1411!K1411_VendorCode) = False Then D1411.VendorCode = Trim$(rs1411!K1411_VendorCode)
    If IsdbNull(rs1411!K1411_AgentCode) = False Then D1411.AgentCode = Trim$(rs1411!K1411_AgentCode)
    If IsdbNull(rs1411!K1411_Buyer) = False Then D1411.Buyer = Trim$(rs1411!K1411_Buyer)
    If IsdbNull(rs1411!K1411_seOrderGroup) = False Then D1411.seOrderGroup = Trim$(rs1411!K1411_seOrderGroup)
    If IsdbNull(rs1411!K1411_cdOrderGroup) = False Then D1411.cdOrderGroup = Trim$(rs1411!K1411_cdOrderGroup)
    If IsdbNull(rs1411!K1411_seOrderKind) = False Then D1411.seOrderKind = Trim$(rs1411!K1411_seOrderKind)
    If IsdbNull(rs1411!K1411_cdOrderKind) = False Then D1411.cdOrderKind = Trim$(rs1411!K1411_cdOrderKind)
    If IsdbNull(rs1411!K1411_seOrderType) = False Then D1411.seOrderType = Trim$(rs1411!K1411_seOrderType)
    If IsdbNull(rs1411!K1411_cdOrderType) = False Then D1411.cdOrderType = Trim$(rs1411!K1411_cdOrderType)
    If IsdbNull(rs1411!K1411_cdOrderWork) = False Then D1411.cdOrderWork = Trim$(rs1411!K1411_cdOrderWork)
    If IsdbNull(rs1411!K1411_seOrderWork) = False Then D1411.seOrderWork = Trim$(rs1411!K1411_seOrderWork)
    If IsdbNull(rs1411!K1411_seStateSample) = False Then D1411.seStateSample = Trim$(rs1411!K1411_seStateSample)
    If IsdbNull(rs1411!K1411_cdStateSample) = False Then D1411.cdStateSample = Trim$(rs1411!K1411_cdStateSample)
    If IsdbNull(rs1411!K1411_seStateOfficial) = False Then D1411.seStateOfficial = Trim$(rs1411!K1411_seStateOfficial)
    If IsdbNull(rs1411!K1411_cdStateOfficial) = False Then D1411.cdStateOfficial = Trim$(rs1411!K1411_cdStateOfficial)
    If IsdbNull(rs1411!K1411_StatusOrder) = False Then D1411.StatusOrder = Trim$(rs1411!K1411_StatusOrder)
    If IsdbNull(rs1411!K1411_DateOrder) = False Then D1411.DateOrder = Trim$(rs1411!K1411_DateOrder)
    If IsdbNull(rs1411!K1411_DateApproval) = False Then D1411.DateApproval = Trim$(rs1411!K1411_DateApproval)
    If IsdbNull(rs1411!K1411_DateComplete) = False Then D1411.DateComplete = Trim$(rs1411!K1411_DateComplete)
    If IsdbNull(rs1411!K1411_DateCancel) = False Then D1411.DateCancel = Trim$(rs1411!K1411_DateCancel)
    If IsdbNull(rs1411!K1411_DatePending) = False Then D1411.DatePending = Trim$(rs1411!K1411_DatePending)
    If IsdbNull(rs1411!K1411_seUnitPrice) = False Then D1411.seUnitPrice = Trim$(rs1411!K1411_seUnitPrice)
    If IsdbNull(rs1411!K1411_cdUnitPrice) = False Then D1411.cdUnitPrice = Trim$(rs1411!K1411_cdUnitPrice)
    If IsdbNull(rs1411!K1411_PriceExchange) = False Then D1411.PriceExchange = Trim$(rs1411!K1411_PriceExchange)
    If IsdbNull(rs1411!K1411_DateExchange) = False Then D1411.DateExchange = Trim$(rs1411!K1411_DateExchange)
    If IsdbNull(rs1411!K1411_DateTransfer) = False Then D1411.DateTransfer = Trim$(rs1411!K1411_DateTransfer)
    If IsdbNull(rs1411!K1411_DateAccept) = False Then D1411.DateAccept = Trim$(rs1411!K1411_DateAccept)
    If IsdbNull(rs1411!K1411_StatusTransfer) = False Then D1411.StatusTransfer = Trim$(rs1411!K1411_StatusTransfer)
    If IsdbNull(rs1411!K1411_seSeason) = False Then D1411.seSeason = Trim$(rs1411!K1411_seSeason)
    If IsdbNull(rs1411!K1411_cdSeason) = False Then D1411.cdSeason = Trim$(rs1411!K1411_cdSeason)
    If IsdbNull(rs1411!K1411_seShippingTerm) = False Then D1411.seShippingTerm = Trim$(rs1411!K1411_seShippingTerm)
    If IsdbNull(rs1411!K1411_cdShippingTerm) = False Then D1411.cdShippingTerm = Trim$(rs1411!K1411_cdShippingTerm)
    If IsdbNull(rs1411!K1411_cdDeliveryTerm) = False Then D1411.cdDeliveryTerm = Trim$(rs1411!K1411_cdDeliveryTerm)
    If IsdbNull(rs1411!K1411_seDeliveryTerm) = False Then D1411.seDeliveryTerm = Trim$(rs1411!K1411_seDeliveryTerm)
    If IsdbNull(rs1411!K1411_sePaymentTerm) = False Then D1411.sePaymentTerm = Trim$(rs1411!K1411_sePaymentTerm)
    If IsdbNull(rs1411!K1411_cdPaymentTerm) = False Then D1411.cdPaymentTerm = Trim$(rs1411!K1411_cdPaymentTerm)
    If IsdbNull(rs1411!K1411_sePaymentCondition) = False Then D1411.sePaymentCondition = Trim$(rs1411!K1411_sePaymentCondition)
    If IsdbNull(rs1411!K1411_cdPaymentCondition) = False Then D1411.cdPaymentCondition = Trim$(rs1411!K1411_cdPaymentCondition)
    If IsdbNull(rs1411!K1411_sePaymentTime) = False Then D1411.sePaymentTime = Trim$(rs1411!K1411_sePaymentTime)
    If IsdbNull(rs1411!K1411_cdPaymentTime) = False Then D1411.cdPaymentTime = Trim$(rs1411!K1411_cdPaymentTime)
    If IsdbNull(rs1411!K1411_sePaymentDay) = False Then D1411.sePaymentDay = Trim$(rs1411!K1411_sePaymentDay)
    If IsdbNull(rs1411!K1411_cdPaymentDay) = False Then D1411.cdPaymentDay = Trim$(rs1411!K1411_cdPaymentDay)
    If IsdbNull(rs1411!K1411_seMarketType) = False Then D1411.seMarketType = Trim$(rs1411!K1411_seMarketType)
    If IsdbNull(rs1411!K1411_cdMarketType) = False Then D1411.cdMarketType = Trim$(rs1411!K1411_cdMarketType)
    If IsdbNull(rs1411!K1411_seDepartment) = False Then D1411.seDepartment = Trim$(rs1411!K1411_seDepartment)
    If IsdbNull(rs1411!K1411_cdDepartment) = False Then D1411.cdDepartment = Trim$(rs1411!K1411_cdDepartment)
    If IsdbNull(rs1411!K1411_seBrand) = False Then D1411.seBrand = Trim$(rs1411!K1411_seBrand)
    If IsdbNull(rs1411!K1411_cdBrand) = False Then D1411.cdBrand = Trim$(rs1411!K1411_cdBrand)
    If IsdbNull(rs1411!K1411_ContractIn) = False Then D1411.ContractIn = Trim$(rs1411!K1411_ContractIn)
    If IsdbNull(rs1411!K1411_ContractOut) = False Then D1411.ContractOut = Trim$(rs1411!K1411_ContractOut)
    If IsdbNull(rs1411!K1411_Destination) = False Then D1411.Destination = Trim$(rs1411!K1411_Destination)
    If IsdbNull(rs1411!K1411_CustPoNo) = False Then D1411.CustPoNo = Trim$(rs1411!K1411_CustPoNo)
    If IsdbNull(rs1411!K1411_InchargeSales) = False Then D1411.InchargeSales = Trim$(rs1411!K1411_InchargeSales)
    If IsdbNull(rs1411!K1411_InchargePPC) = False Then D1411.InchargePPC = Trim$(rs1411!K1411_InchargePPC)
    If IsdbNull(rs1411!K1411_DateInsert) = False Then D1411.DateInsert = Trim$(rs1411!K1411_DateInsert)
    If IsdbNull(rs1411!K1411_DateUpdate) = False Then D1411.DateUpdate = Trim$(rs1411!K1411_DateUpdate)
    If IsdbNull(rs1411!K1411_TimeInsert) = False Then D1411.TimeInsert = Trim$(rs1411!K1411_TimeInsert)
    If IsdbNull(rs1411!K1411_TimeUpdate) = False Then D1411.TimeUpdate = Trim$(rs1411!K1411_TimeUpdate)
    If IsdbNull(rs1411!K1411_TotalQty) = False Then D1411.TotalQty = Trim$(rs1411!K1411_TotalQty)
    If IsdbNull(rs1411!K1411_TotalAmount) = False Then D1411.TotalAmount = Trim$(rs1411!K1411_TotalAmount)
    If IsdbNull(rs1411!K1411_TotalCost) = False Then D1411.TotalCost = Trim$(rs1411!K1411_TotalCost)
    If IsdbNull(rs1411!K1411_TotalProfit) = False Then D1411.TotalProfit = Trim$(rs1411!K1411_TotalProfit)
    If IsdbNull(rs1411!K1411_AttachID) = False Then D1411.AttachID = Trim$(rs1411!K1411_AttachID)
    If IsdbNull(rs1411!K1411_RemarkOrder) = False Then D1411.RemarkOrder = Trim$(rs1411!K1411_RemarkOrder)
    If IsdbNull(rs1411!K1411_RemarkCustomer) = False Then D1411.RemarkCustomer = Trim$(rs1411!K1411_RemarkCustomer)
    If IsdbNull(rs1411!K1411_Remark) = False Then D1411.Remark = Trim$(rs1411!K1411_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K1411_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K1411_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z1411 As T1411_AREA, ORDERNO AS String) as Boolean

K1411_MOVE = False

Try
    If READ_PFK1411(ORDERNO) = True Then
                z1411 = D1411
		K1411_MOVE = True
		else
	z1411 = nothing
     End If

     If  getColumIndex(spr,"OrderNo") > -1 then z1411.OrderNo = getDataM(spr, getColumIndex(spr,"OrderNo"), xRow)
     If  getColumIndex(spr,"CustomerCode") > -1 then z1411.CustomerCode = getDataM(spr, getColumIndex(spr,"CustomerCode"), xRow)
     If  getColumIndex(spr,"VendorCode") > -1 then z1411.VendorCode = getDataM(spr, getColumIndex(spr,"VendorCode"), xRow)
     If  getColumIndex(spr,"AgentCode") > -1 then z1411.AgentCode = getDataM(spr, getColumIndex(spr,"AgentCode"), xRow)
     If  getColumIndex(spr,"Buyer") > -1 then z1411.Buyer = getDataM(spr, getColumIndex(spr,"Buyer"), xRow)
     If  getColumIndex(spr,"seOrderGroup") > -1 then z1411.seOrderGroup = getDataM(spr, getColumIndex(spr,"seOrderGroup"), xRow)
     If  getColumIndex(spr,"cdOrderGroup") > -1 then z1411.cdOrderGroup = getDataM(spr, getColumIndex(spr,"cdOrderGroup"), xRow)
     If  getColumIndex(spr,"seOrderKind") > -1 then z1411.seOrderKind = getDataM(spr, getColumIndex(spr,"seOrderKind"), xRow)
     If  getColumIndex(spr,"cdOrderKind") > -1 then z1411.cdOrderKind = getDataM(spr, getColumIndex(spr,"cdOrderKind"), xRow)
     If  getColumIndex(spr,"seOrderType") > -1 then z1411.seOrderType = getDataM(spr, getColumIndex(spr,"seOrderType"), xRow)
     If  getColumIndex(spr,"cdOrderType") > -1 then z1411.cdOrderType = getDataM(spr, getColumIndex(spr,"cdOrderType"), xRow)
     If  getColumIndex(spr,"cdOrderWork") > -1 then z1411.cdOrderWork = getDataM(spr, getColumIndex(spr,"cdOrderWork"), xRow)
     If  getColumIndex(spr,"seOrderWork") > -1 then z1411.seOrderWork = getDataM(spr, getColumIndex(spr,"seOrderWork"), xRow)
     If  getColumIndex(spr,"seStateSample") > -1 then z1411.seStateSample = getDataM(spr, getColumIndex(spr,"seStateSample"), xRow)
     If  getColumIndex(spr,"cdStateSample") > -1 then z1411.cdStateSample = getDataM(spr, getColumIndex(spr,"cdStateSample"), xRow)
     If  getColumIndex(spr,"seStateOfficial") > -1 then z1411.seStateOfficial = getDataM(spr, getColumIndex(spr,"seStateOfficial"), xRow)
     If  getColumIndex(spr,"cdStateOfficial") > -1 then z1411.cdStateOfficial = getDataM(spr, getColumIndex(spr,"cdStateOfficial"), xRow)
     If  getColumIndex(spr,"StatusOrder") > -1 then z1411.StatusOrder = getDataM(spr, getColumIndex(spr,"StatusOrder"), xRow)
     If  getColumIndex(spr,"DateOrder") > -1 then z1411.DateOrder = getDataM(spr, getColumIndex(spr,"DateOrder"), xRow)
     If  getColumIndex(spr,"DateApproval") > -1 then z1411.DateApproval = getDataM(spr, getColumIndex(spr,"DateApproval"), xRow)
     If  getColumIndex(spr,"DateComplete") > -1 then z1411.DateComplete = getDataM(spr, getColumIndex(spr,"DateComplete"), xRow)
     If  getColumIndex(spr,"DateCancel") > -1 then z1411.DateCancel = getDataM(spr, getColumIndex(spr,"DateCancel"), xRow)
     If  getColumIndex(spr,"DatePending") > -1 then z1411.DatePending = getDataM(spr, getColumIndex(spr,"DatePending"), xRow)
     If  getColumIndex(spr,"seUnitPrice") > -1 then z1411.seUnitPrice = getDataM(spr, getColumIndex(spr,"seUnitPrice"), xRow)
     If  getColumIndex(spr,"cdUnitPrice") > -1 then z1411.cdUnitPrice = getDataM(spr, getColumIndex(spr,"cdUnitPrice"), xRow)
     If  getColumIndex(spr,"PriceExchange") > -1 then z1411.PriceExchange = getDataM(spr, getColumIndex(spr,"PriceExchange"), xRow)
     If  getColumIndex(spr,"DateExchange") > -1 then z1411.DateExchange = getDataM(spr, getColumIndex(spr,"DateExchange"), xRow)
     If  getColumIndex(spr,"DateTransfer") > -1 then z1411.DateTransfer = getDataM(spr, getColumIndex(spr,"DateTransfer"), xRow)
     If  getColumIndex(spr,"DateAccept") > -1 then z1411.DateAccept = getDataM(spr, getColumIndex(spr,"DateAccept"), xRow)
     If  getColumIndex(spr,"StatusTransfer") > -1 then z1411.StatusTransfer = getDataM(spr, getColumIndex(spr,"StatusTransfer"), xRow)
     If  getColumIndex(spr,"seSeason") > -1 then z1411.seSeason = getDataM(spr, getColumIndex(spr,"seSeason"), xRow)
     If  getColumIndex(spr,"cdSeason") > -1 then z1411.cdSeason = getDataM(spr, getColumIndex(spr,"cdSeason"), xRow)
     If  getColumIndex(spr,"seShippingTerm") > -1 then z1411.seShippingTerm = getDataM(spr, getColumIndex(spr,"seShippingTerm"), xRow)
     If  getColumIndex(spr,"cdShippingTerm") > -1 then z1411.cdShippingTerm = getDataM(spr, getColumIndex(spr,"cdShippingTerm"), xRow)
     If  getColumIndex(spr,"cdDeliveryTerm") > -1 then z1411.cdDeliveryTerm = getDataM(spr, getColumIndex(spr,"cdDeliveryTerm"), xRow)
     If  getColumIndex(spr,"seDeliveryTerm") > -1 then z1411.seDeliveryTerm = getDataM(spr, getColumIndex(spr,"seDeliveryTerm"), xRow)
     If  getColumIndex(spr,"sePaymentTerm") > -1 then z1411.sePaymentTerm = getDataM(spr, getColumIndex(spr,"sePaymentTerm"), xRow)
     If  getColumIndex(spr,"cdPaymentTerm") > -1 then z1411.cdPaymentTerm = getDataM(spr, getColumIndex(spr,"cdPaymentTerm"), xRow)
     If  getColumIndex(spr,"sePaymentCondition") > -1 then z1411.sePaymentCondition = getDataM(spr, getColumIndex(spr,"sePaymentCondition"), xRow)
     If  getColumIndex(spr,"cdPaymentCondition") > -1 then z1411.cdPaymentCondition = getDataM(spr, getColumIndex(spr,"cdPaymentCondition"), xRow)
     If  getColumIndex(spr,"sePaymentTime") > -1 then z1411.sePaymentTime = getDataM(spr, getColumIndex(spr,"sePaymentTime"), xRow)
     If  getColumIndex(spr,"cdPaymentTime") > -1 then z1411.cdPaymentTime = getDataM(spr, getColumIndex(spr,"cdPaymentTime"), xRow)
     If  getColumIndex(spr,"sePaymentDay") > -1 then z1411.sePaymentDay = getDataM(spr, getColumIndex(spr,"sePaymentDay"), xRow)
     If  getColumIndex(spr,"cdPaymentDay") > -1 then z1411.cdPaymentDay = getDataM(spr, getColumIndex(spr,"cdPaymentDay"), xRow)
     If  getColumIndex(spr,"seMarketType") > -1 then z1411.seMarketType = getDataM(spr, getColumIndex(spr,"seMarketType"), xRow)
     If  getColumIndex(spr,"cdMarketType") > -1 then z1411.cdMarketType = getDataM(spr, getColumIndex(spr,"cdMarketType"), xRow)
     If  getColumIndex(spr,"seDepartment") > -1 then z1411.seDepartment = getDataM(spr, getColumIndex(spr,"seDepartment"), xRow)
     If  getColumIndex(spr,"cdDepartment") > -1 then z1411.cdDepartment = getDataM(spr, getColumIndex(spr,"cdDepartment"), xRow)
     If  getColumIndex(spr,"seBrand") > -1 then z1411.seBrand = getDataM(spr, getColumIndex(spr,"seBrand"), xRow)
     If  getColumIndex(spr,"cdBrand") > -1 then z1411.cdBrand = getDataM(spr, getColumIndex(spr,"cdBrand"), xRow)
     If  getColumIndex(spr,"ContractIn") > -1 then z1411.ContractIn = getDataM(spr, getColumIndex(spr,"ContractIn"), xRow)
     If  getColumIndex(spr,"ContractOut") > -1 then z1411.ContractOut = getDataM(spr, getColumIndex(spr,"ContractOut"), xRow)
     If  getColumIndex(spr,"Destination") > -1 then z1411.Destination = getDataM(spr, getColumIndex(spr,"Destination"), xRow)
     If  getColumIndex(spr,"CustPoNo") > -1 then z1411.CustPoNo = getDataM(spr, getColumIndex(spr,"CustPoNo"), xRow)
     If  getColumIndex(spr,"InchargeSales") > -1 then z1411.InchargeSales = getDataM(spr, getColumIndex(spr,"InchargeSales"), xRow)
     If  getColumIndex(spr,"InchargePPC") > -1 then z1411.InchargePPC = getDataM(spr, getColumIndex(spr,"InchargePPC"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z1411.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z1411.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"TimeInsert") > -1 then z1411.TimeInsert = getDataM(spr, getColumIndex(spr,"TimeInsert"), xRow)
     If  getColumIndex(spr,"TimeUpdate") > -1 then z1411.TimeUpdate = getDataM(spr, getColumIndex(spr,"TimeUpdate"), xRow)
     If  getColumIndex(spr,"TotalQty") > -1 then z1411.TotalQty = getDataM(spr, getColumIndex(spr,"TotalQty"), xRow)
     If  getColumIndex(spr,"TotalAmount") > -1 then z1411.TotalAmount = getDataM(spr, getColumIndex(spr,"TotalAmount"), xRow)
     If  getColumIndex(spr,"TotalCost") > -1 then z1411.TotalCost = getDataM(spr, getColumIndex(spr,"TotalCost"), xRow)
     If  getColumIndex(spr,"TotalProfit") > -1 then z1411.TotalProfit = getDataM(spr, getColumIndex(spr,"TotalProfit"), xRow)
     If  getColumIndex(spr,"AttachID") > -1 then z1411.AttachID = getDataM(spr, getColumIndex(spr,"AttachID"), xRow)
     If  getColumIndex(spr,"RemarkOrder") > -1 then z1411.RemarkOrder = getDataM(spr, getColumIndex(spr,"RemarkOrder"), xRow)
     If  getColumIndex(spr,"RemarkCustomer") > -1 then z1411.RemarkCustomer = getDataM(spr, getColumIndex(spr,"RemarkCustomer"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z1411.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K1411_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K1411_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z1411 As T1411_AREA,CheckClear as Boolean,ORDERNO AS String) as Boolean

K1411_MOVE = False

Try
    If READ_PFK1411(ORDERNO) = True Then
                z1411 = D1411
		K1411_MOVE = True
		else
	If CheckClear  = True then z1411 = nothing
     End If

     If  getColumIndex(spr,"OrderNo") > -1 then z1411.OrderNo = getDataM(spr, getColumIndex(spr,"OrderNo"), xRow)
     If  getColumIndex(spr,"CustomerCode") > -1 then z1411.CustomerCode = getDataM(spr, getColumIndex(spr,"CustomerCode"), xRow)
     If  getColumIndex(spr,"VendorCode") > -1 then z1411.VendorCode = getDataM(spr, getColumIndex(spr,"VendorCode"), xRow)
     If  getColumIndex(spr,"AgentCode") > -1 then z1411.AgentCode = getDataM(spr, getColumIndex(spr,"AgentCode"), xRow)
     If  getColumIndex(spr,"Buyer") > -1 then z1411.Buyer = getDataM(spr, getColumIndex(spr,"Buyer"), xRow)
     If  getColumIndex(spr,"seOrderGroup") > -1 then z1411.seOrderGroup = getDataM(spr, getColumIndex(spr,"seOrderGroup"), xRow)
     If  getColumIndex(spr,"cdOrderGroup") > -1 then z1411.cdOrderGroup = getDataM(spr, getColumIndex(spr,"cdOrderGroup"), xRow)
     If  getColumIndex(spr,"seOrderKind") > -1 then z1411.seOrderKind = getDataM(spr, getColumIndex(spr,"seOrderKind"), xRow)
     If  getColumIndex(spr,"cdOrderKind") > -1 then z1411.cdOrderKind = getDataM(spr, getColumIndex(spr,"cdOrderKind"), xRow)
     If  getColumIndex(spr,"seOrderType") > -1 then z1411.seOrderType = getDataM(spr, getColumIndex(spr,"seOrderType"), xRow)
     If  getColumIndex(spr,"cdOrderType") > -1 then z1411.cdOrderType = getDataM(spr, getColumIndex(spr,"cdOrderType"), xRow)
     If  getColumIndex(spr,"cdOrderWork") > -1 then z1411.cdOrderWork = getDataM(spr, getColumIndex(spr,"cdOrderWork"), xRow)
     If  getColumIndex(spr,"seOrderWork") > -1 then z1411.seOrderWork = getDataM(spr, getColumIndex(spr,"seOrderWork"), xRow)
     If  getColumIndex(spr,"seStateSample") > -1 then z1411.seStateSample = getDataM(spr, getColumIndex(spr,"seStateSample"), xRow)
     If  getColumIndex(spr,"cdStateSample") > -1 then z1411.cdStateSample = getDataM(spr, getColumIndex(spr,"cdStateSample"), xRow)
     If  getColumIndex(spr,"seStateOfficial") > -1 then z1411.seStateOfficial = getDataM(spr, getColumIndex(spr,"seStateOfficial"), xRow)
     If  getColumIndex(spr,"cdStateOfficial") > -1 then z1411.cdStateOfficial = getDataM(spr, getColumIndex(spr,"cdStateOfficial"), xRow)
     If  getColumIndex(spr,"StatusOrder") > -1 then z1411.StatusOrder = getDataM(spr, getColumIndex(spr,"StatusOrder"), xRow)
     If  getColumIndex(spr,"DateOrder") > -1 then z1411.DateOrder = getDataM(spr, getColumIndex(spr,"DateOrder"), xRow)
     If  getColumIndex(spr,"DateApproval") > -1 then z1411.DateApproval = getDataM(spr, getColumIndex(spr,"DateApproval"), xRow)
     If  getColumIndex(spr,"DateComplete") > -1 then z1411.DateComplete = getDataM(spr, getColumIndex(spr,"DateComplete"), xRow)
     If  getColumIndex(spr,"DateCancel") > -1 then z1411.DateCancel = getDataM(spr, getColumIndex(spr,"DateCancel"), xRow)
     If  getColumIndex(spr,"DatePending") > -1 then z1411.DatePending = getDataM(spr, getColumIndex(spr,"DatePending"), xRow)
     If  getColumIndex(spr,"seUnitPrice") > -1 then z1411.seUnitPrice = getDataM(spr, getColumIndex(spr,"seUnitPrice"), xRow)
     If  getColumIndex(spr,"cdUnitPrice") > -1 then z1411.cdUnitPrice = getDataM(spr, getColumIndex(spr,"cdUnitPrice"), xRow)
     If  getColumIndex(spr,"PriceExchange") > -1 then z1411.PriceExchange = getDataM(spr, getColumIndex(spr,"PriceExchange"), xRow)
     If  getColumIndex(spr,"DateExchange") > -1 then z1411.DateExchange = getDataM(spr, getColumIndex(spr,"DateExchange"), xRow)
     If  getColumIndex(spr,"DateTransfer") > -1 then z1411.DateTransfer = getDataM(spr, getColumIndex(spr,"DateTransfer"), xRow)
     If  getColumIndex(spr,"DateAccept") > -1 then z1411.DateAccept = getDataM(spr, getColumIndex(spr,"DateAccept"), xRow)
     If  getColumIndex(spr,"StatusTransfer") > -1 then z1411.StatusTransfer = getDataM(spr, getColumIndex(spr,"StatusTransfer"), xRow)
     If  getColumIndex(spr,"seSeason") > -1 then z1411.seSeason = getDataM(spr, getColumIndex(spr,"seSeason"), xRow)
     If  getColumIndex(spr,"cdSeason") > -1 then z1411.cdSeason = getDataM(spr, getColumIndex(spr,"cdSeason"), xRow)
     If  getColumIndex(spr,"seShippingTerm") > -1 then z1411.seShippingTerm = getDataM(spr, getColumIndex(spr,"seShippingTerm"), xRow)
     If  getColumIndex(spr,"cdShippingTerm") > -1 then z1411.cdShippingTerm = getDataM(spr, getColumIndex(spr,"cdShippingTerm"), xRow)
     If  getColumIndex(spr,"cdDeliveryTerm") > -1 then z1411.cdDeliveryTerm = getDataM(spr, getColumIndex(spr,"cdDeliveryTerm"), xRow)
     If  getColumIndex(spr,"seDeliveryTerm") > -1 then z1411.seDeliveryTerm = getDataM(spr, getColumIndex(spr,"seDeliveryTerm"), xRow)
     If  getColumIndex(spr,"sePaymentTerm") > -1 then z1411.sePaymentTerm = getDataM(spr, getColumIndex(spr,"sePaymentTerm"), xRow)
     If  getColumIndex(spr,"cdPaymentTerm") > -1 then z1411.cdPaymentTerm = getDataM(spr, getColumIndex(spr,"cdPaymentTerm"), xRow)
     If  getColumIndex(spr,"sePaymentCondition") > -1 then z1411.sePaymentCondition = getDataM(spr, getColumIndex(spr,"sePaymentCondition"), xRow)
     If  getColumIndex(spr,"cdPaymentCondition") > -1 then z1411.cdPaymentCondition = getDataM(spr, getColumIndex(spr,"cdPaymentCondition"), xRow)
     If  getColumIndex(spr,"sePaymentTime") > -1 then z1411.sePaymentTime = getDataM(spr, getColumIndex(spr,"sePaymentTime"), xRow)
     If  getColumIndex(spr,"cdPaymentTime") > -1 then z1411.cdPaymentTime = getDataM(spr, getColumIndex(spr,"cdPaymentTime"), xRow)
     If  getColumIndex(spr,"sePaymentDay") > -1 then z1411.sePaymentDay = getDataM(spr, getColumIndex(spr,"sePaymentDay"), xRow)
     If  getColumIndex(spr,"cdPaymentDay") > -1 then z1411.cdPaymentDay = getDataM(spr, getColumIndex(spr,"cdPaymentDay"), xRow)
     If  getColumIndex(spr,"seMarketType") > -1 then z1411.seMarketType = getDataM(spr, getColumIndex(spr,"seMarketType"), xRow)
     If  getColumIndex(spr,"cdMarketType") > -1 then z1411.cdMarketType = getDataM(spr, getColumIndex(spr,"cdMarketType"), xRow)
     If  getColumIndex(spr,"seDepartment") > -1 then z1411.seDepartment = getDataM(spr, getColumIndex(spr,"seDepartment"), xRow)
     If  getColumIndex(spr,"cdDepartment") > -1 then z1411.cdDepartment = getDataM(spr, getColumIndex(spr,"cdDepartment"), xRow)
     If  getColumIndex(spr,"seBrand") > -1 then z1411.seBrand = getDataM(spr, getColumIndex(spr,"seBrand"), xRow)
     If  getColumIndex(spr,"cdBrand") > -1 then z1411.cdBrand = getDataM(spr, getColumIndex(spr,"cdBrand"), xRow)
     If  getColumIndex(spr,"ContractIn") > -1 then z1411.ContractIn = getDataM(spr, getColumIndex(spr,"ContractIn"), xRow)
     If  getColumIndex(spr,"ContractOut") > -1 then z1411.ContractOut = getDataM(spr, getColumIndex(spr,"ContractOut"), xRow)
     If  getColumIndex(spr,"Destination") > -1 then z1411.Destination = getDataM(spr, getColumIndex(spr,"Destination"), xRow)
     If  getColumIndex(spr,"CustPoNo") > -1 then z1411.CustPoNo = getDataM(spr, getColumIndex(spr,"CustPoNo"), xRow)
     If  getColumIndex(spr,"InchargeSales") > -1 then z1411.InchargeSales = getDataM(spr, getColumIndex(spr,"InchargeSales"), xRow)
     If  getColumIndex(spr,"InchargePPC") > -1 then z1411.InchargePPC = getDataM(spr, getColumIndex(spr,"InchargePPC"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z1411.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z1411.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"TimeInsert") > -1 then z1411.TimeInsert = getDataM(spr, getColumIndex(spr,"TimeInsert"), xRow)
     If  getColumIndex(spr,"TimeUpdate") > -1 then z1411.TimeUpdate = getDataM(spr, getColumIndex(spr,"TimeUpdate"), xRow)
     If  getColumIndex(spr,"TotalQty") > -1 then z1411.TotalQty = getDataM(spr, getColumIndex(spr,"TotalQty"), xRow)
     If  getColumIndex(spr,"TotalAmount") > -1 then z1411.TotalAmount = getDataM(spr, getColumIndex(spr,"TotalAmount"), xRow)
     If  getColumIndex(spr,"TotalCost") > -1 then z1411.TotalCost = getDataM(spr, getColumIndex(spr,"TotalCost"), xRow)
     If  getColumIndex(spr,"TotalProfit") > -1 then z1411.TotalProfit = getDataM(spr, getColumIndex(spr,"TotalProfit"), xRow)
     If  getColumIndex(spr,"AttachID") > -1 then z1411.AttachID = getDataM(spr, getColumIndex(spr,"AttachID"), xRow)
     If  getColumIndex(spr,"RemarkOrder") > -1 then z1411.RemarkOrder = getDataM(spr, getColumIndex(spr,"RemarkOrder"), xRow)
     If  getColumIndex(spr,"RemarkCustomer") > -1 then z1411.RemarkCustomer = getDataM(spr, getColumIndex(spr,"RemarkCustomer"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z1411.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K1411_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K1411_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z1411 As T1411_AREA, Job as String, ORDERNO AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K1411_MOVE = False

Try
    If READ_PFK1411(ORDERNO) = True Then
                z1411 = D1411
		K1411_MOVE = True
		else
	z1411 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK1411")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "ORDERNO":z1411.OrderNo = Children(i).Code
   Case "CUSTOMERCODE":z1411.CustomerCode = Children(i).Code
   Case "VENDORCODE":z1411.VendorCode = Children(i).Code
   Case "AGENTCODE":z1411.AgentCode = Children(i).Code
   Case "BUYER":z1411.Buyer = Children(i).Code
   Case "SEORDERGROUP":z1411.seOrderGroup = Children(i).Code
   Case "CDORDERGROUP":z1411.cdOrderGroup = Children(i).Code
   Case "SEORDERKIND":z1411.seOrderKind = Children(i).Code
   Case "CDORDERKIND":z1411.cdOrderKind = Children(i).Code
   Case "SEORDERTYPE":z1411.seOrderType = Children(i).Code
   Case "CDORDERTYPE":z1411.cdOrderType = Children(i).Code
   Case "CDORDERWORK":z1411.cdOrderWork = Children(i).Code
   Case "SEORDERWORK":z1411.seOrderWork = Children(i).Code
   Case "SESTATESAMPLE":z1411.seStateSample = Children(i).Code
   Case "CDSTATESAMPLE":z1411.cdStateSample = Children(i).Code
   Case "SESTATEOFFICIAL":z1411.seStateOfficial = Children(i).Code
   Case "CDSTATEOFFICIAL":z1411.cdStateOfficial = Children(i).Code
   Case "STATUSORDER":z1411.StatusOrder = Children(i).Code
   Case "DATEORDER":z1411.DateOrder = Children(i).Code
   Case "DATEAPPROVAL":z1411.DateApproval = Children(i).Code
   Case "DATECOMPLETE":z1411.DateComplete = Children(i).Code
   Case "DATECANCEL":z1411.DateCancel = Children(i).Code
   Case "DATEPENDING":z1411.DatePending = Children(i).Code
   Case "SEUNITPRICE":z1411.seUnitPrice = Children(i).Code
   Case "CDUNITPRICE":z1411.cdUnitPrice = Children(i).Code
   Case "PRICEEXCHANGE":z1411.PriceExchange = Children(i).Code
   Case "DATEEXCHANGE":z1411.DateExchange = Children(i).Code
   Case "DATETRANSFER":z1411.DateTransfer = Children(i).Code
   Case "DATEACCEPT":z1411.DateAccept = Children(i).Code
   Case "STATUSTRANSFER":z1411.StatusTransfer = Children(i).Code
   Case "SESEASON":z1411.seSeason = Children(i).Code
   Case "CDSEASON":z1411.cdSeason = Children(i).Code
   Case "SESHIPPINGTERM":z1411.seShippingTerm = Children(i).Code
   Case "CDSHIPPINGTERM":z1411.cdShippingTerm = Children(i).Code
   Case "CDDELIVERYTERM":z1411.cdDeliveryTerm = Children(i).Code
   Case "SEDELIVERYTERM":z1411.seDeliveryTerm = Children(i).Code
   Case "SEPAYMENTTERM":z1411.sePaymentTerm = Children(i).Code
   Case "CDPAYMENTTERM":z1411.cdPaymentTerm = Children(i).Code
   Case "SEPAYMENTCONDITION":z1411.sePaymentCondition = Children(i).Code
   Case "CDPAYMENTCONDITION":z1411.cdPaymentCondition = Children(i).Code
   Case "SEPAYMENTTIME":z1411.sePaymentTime = Children(i).Code
   Case "CDPAYMENTTIME":z1411.cdPaymentTime = Children(i).Code
   Case "SEPAYMENTDAY":z1411.sePaymentDay = Children(i).Code
   Case "CDPAYMENTDAY":z1411.cdPaymentDay = Children(i).Code
   Case "SEMARKETTYPE":z1411.seMarketType = Children(i).Code
   Case "CDMARKETTYPE":z1411.cdMarketType = Children(i).Code
   Case "SEDEPARTMENT":z1411.seDepartment = Children(i).Code
   Case "CDDEPARTMENT":z1411.cdDepartment = Children(i).Code
   Case "SEBRAND":z1411.seBrand = Children(i).Code
   Case "CDBRAND":z1411.cdBrand = Children(i).Code
   Case "CONTRACTIN":z1411.ContractIn = Children(i).Code
   Case "CONTRACTOUT":z1411.ContractOut = Children(i).Code
   Case "DESTINATION":z1411.Destination = Children(i).Code
   Case "CUSTPONO":z1411.CustPoNo = Children(i).Code
   Case "INCHARGESALES":z1411.InchargeSales = Children(i).Code
   Case "INCHARGEPPC":z1411.InchargePPC = Children(i).Code
   Case "DATEINSERT":z1411.DateInsert = Children(i).Code
   Case "DATEUPDATE":z1411.DateUpdate = Children(i).Code
   Case "TIMEINSERT":z1411.TimeInsert = Children(i).Code
   Case "TIMEUPDATE":z1411.TimeUpdate = Children(i).Code
   Case "TOTALQTY":z1411.TotalQty = Children(i).Code
   Case "TOTALAMOUNT":z1411.TotalAmount = Children(i).Code
   Case "TOTALCOST":z1411.TotalCost = Children(i).Code
   Case "TOTALPROFIT":z1411.TotalProfit = Children(i).Code
   Case "ATTACHID":z1411.AttachID = Children(i).Code
   Case "REMARKORDER":z1411.RemarkOrder = Children(i).Code
   Case "REMARKCUSTOMER":z1411.RemarkCustomer = Children(i).Code
   Case "REMARK":z1411.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "ORDERNO":z1411.OrderNo = Children(i).Data
   Case "CUSTOMERCODE":z1411.CustomerCode = Children(i).Data
   Case "VENDORCODE":z1411.VendorCode = Children(i).Data
   Case "AGENTCODE":z1411.AgentCode = Children(i).Data
   Case "BUYER":z1411.Buyer = Children(i).Data
   Case "SEORDERGROUP":z1411.seOrderGroup = Children(i).Data
   Case "CDORDERGROUP":z1411.cdOrderGroup = Children(i).Data
   Case "SEORDERKIND":z1411.seOrderKind = Children(i).Data
   Case "CDORDERKIND":z1411.cdOrderKind = Children(i).Data
   Case "SEORDERTYPE":z1411.seOrderType = Children(i).Data
   Case "CDORDERTYPE":z1411.cdOrderType = Children(i).Data
   Case "CDORDERWORK":z1411.cdOrderWork = Children(i).Data
   Case "SEORDERWORK":z1411.seOrderWork = Children(i).Data
   Case "SESTATESAMPLE":z1411.seStateSample = Children(i).Data
   Case "CDSTATESAMPLE":z1411.cdStateSample = Children(i).Data
   Case "SESTATEOFFICIAL":z1411.seStateOfficial = Children(i).Data
   Case "CDSTATEOFFICIAL":z1411.cdStateOfficial = Children(i).Data
   Case "STATUSORDER":z1411.StatusOrder = Children(i).Data
   Case "DATEORDER":z1411.DateOrder = Children(i).Data
   Case "DATEAPPROVAL":z1411.DateApproval = Children(i).Data
   Case "DATECOMPLETE":z1411.DateComplete = Children(i).Data
   Case "DATECANCEL":z1411.DateCancel = Children(i).Data
   Case "DATEPENDING":z1411.DatePending = Children(i).Data
   Case "SEUNITPRICE":z1411.seUnitPrice = Children(i).Data
   Case "CDUNITPRICE":z1411.cdUnitPrice = Children(i).Data
   Case "PRICEEXCHANGE":z1411.PriceExchange = Children(i).Data
   Case "DATEEXCHANGE":z1411.DateExchange = Children(i).Data
   Case "DATETRANSFER":z1411.DateTransfer = Children(i).Data
   Case "DATEACCEPT":z1411.DateAccept = Children(i).Data
   Case "STATUSTRANSFER":z1411.StatusTransfer = Children(i).Data
   Case "SESEASON":z1411.seSeason = Children(i).Data
   Case "CDSEASON":z1411.cdSeason = Children(i).Data
   Case "SESHIPPINGTERM":z1411.seShippingTerm = Children(i).Data
   Case "CDSHIPPINGTERM":z1411.cdShippingTerm = Children(i).Data
   Case "CDDELIVERYTERM":z1411.cdDeliveryTerm = Children(i).Data
   Case "SEDELIVERYTERM":z1411.seDeliveryTerm = Children(i).Data
   Case "SEPAYMENTTERM":z1411.sePaymentTerm = Children(i).Data
   Case "CDPAYMENTTERM":z1411.cdPaymentTerm = Children(i).Data
   Case "SEPAYMENTCONDITION":z1411.sePaymentCondition = Children(i).Data
   Case "CDPAYMENTCONDITION":z1411.cdPaymentCondition = Children(i).Data
   Case "SEPAYMENTTIME":z1411.sePaymentTime = Children(i).Data
   Case "CDPAYMENTTIME":z1411.cdPaymentTime = Children(i).Data
   Case "SEPAYMENTDAY":z1411.sePaymentDay = Children(i).Data
   Case "CDPAYMENTDAY":z1411.cdPaymentDay = Children(i).Data
   Case "SEMARKETTYPE":z1411.seMarketType = Children(i).Data
   Case "CDMARKETTYPE":z1411.cdMarketType = Children(i).Data
   Case "SEDEPARTMENT":z1411.seDepartment = Children(i).Data
   Case "CDDEPARTMENT":z1411.cdDepartment = Children(i).Data
   Case "SEBRAND":z1411.seBrand = Children(i).Data
   Case "CDBRAND":z1411.cdBrand = Children(i).Data
   Case "CONTRACTIN":z1411.ContractIn = Children(i).Data
   Case "CONTRACTOUT":z1411.ContractOut = Children(i).Data
   Case "DESTINATION":z1411.Destination = Children(i).Data
   Case "CUSTPONO":z1411.CustPoNo = Children(i).Data
   Case "INCHARGESALES":z1411.InchargeSales = Children(i).Data
   Case "INCHARGEPPC":z1411.InchargePPC = Children(i).Data
   Case "DATEINSERT":z1411.DateInsert = Children(i).Data
   Case "DATEUPDATE":z1411.DateUpdate = Children(i).Data
   Case "TIMEINSERT":z1411.TimeInsert = Children(i).Data
   Case "TIMEUPDATE":z1411.TimeUpdate = Children(i).Data
   Case "TOTALQTY":z1411.TotalQty = Children(i).Data
   Case "TOTALAMOUNT":z1411.TotalAmount = Children(i).Data
   Case "TOTALCOST":z1411.TotalCost = Children(i).Data
   Case "TOTALPROFIT":z1411.TotalProfit = Children(i).Data
   Case "ATTACHID":z1411.AttachID = Children(i).Data
   Case "REMARKORDER":z1411.RemarkOrder = Children(i).Data
   Case "REMARKCUSTOMER":z1411.RemarkCustomer = Children(i).Data
   Case "REMARK":z1411.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K1411_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K1411_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z1411 As T1411_AREA, Job as String, CheckClear as Boolean, ORDERNO AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K1411_MOVE = False

Try
    If READ_PFK1411(ORDERNO) = True Then
                z1411 = D1411
		K1411_MOVE = True
		else
	If CheckClear  = True then z1411 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK1411")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "ORDERNO":z1411.OrderNo = Children(i).Code
   Case "CUSTOMERCODE":z1411.CustomerCode = Children(i).Code
   Case "VENDORCODE":z1411.VendorCode = Children(i).Code
   Case "AGENTCODE":z1411.AgentCode = Children(i).Code
   Case "BUYER":z1411.Buyer = Children(i).Code
   Case "SEORDERGROUP":z1411.seOrderGroup = Children(i).Code
   Case "CDORDERGROUP":z1411.cdOrderGroup = Children(i).Code
   Case "SEORDERKIND":z1411.seOrderKind = Children(i).Code
   Case "CDORDERKIND":z1411.cdOrderKind = Children(i).Code
   Case "SEORDERTYPE":z1411.seOrderType = Children(i).Code
   Case "CDORDERTYPE":z1411.cdOrderType = Children(i).Code
   Case "CDORDERWORK":z1411.cdOrderWork = Children(i).Code
   Case "SEORDERWORK":z1411.seOrderWork = Children(i).Code
   Case "SESTATESAMPLE":z1411.seStateSample = Children(i).Code
   Case "CDSTATESAMPLE":z1411.cdStateSample = Children(i).Code
   Case "SESTATEOFFICIAL":z1411.seStateOfficial = Children(i).Code
   Case "CDSTATEOFFICIAL":z1411.cdStateOfficial = Children(i).Code
   Case "STATUSORDER":z1411.StatusOrder = Children(i).Code
   Case "DATEORDER":z1411.DateOrder = Children(i).Code
   Case "DATEAPPROVAL":z1411.DateApproval = Children(i).Code
   Case "DATECOMPLETE":z1411.DateComplete = Children(i).Code
   Case "DATECANCEL":z1411.DateCancel = Children(i).Code
   Case "DATEPENDING":z1411.DatePending = Children(i).Code
   Case "SEUNITPRICE":z1411.seUnitPrice = Children(i).Code
   Case "CDUNITPRICE":z1411.cdUnitPrice = Children(i).Code
   Case "PRICEEXCHANGE":z1411.PriceExchange = Children(i).Code
   Case "DATEEXCHANGE":z1411.DateExchange = Children(i).Code
   Case "DATETRANSFER":z1411.DateTransfer = Children(i).Code
   Case "DATEACCEPT":z1411.DateAccept = Children(i).Code
   Case "STATUSTRANSFER":z1411.StatusTransfer = Children(i).Code
   Case "SESEASON":z1411.seSeason = Children(i).Code
   Case "CDSEASON":z1411.cdSeason = Children(i).Code
   Case "SESHIPPINGTERM":z1411.seShippingTerm = Children(i).Code
   Case "CDSHIPPINGTERM":z1411.cdShippingTerm = Children(i).Code
   Case "CDDELIVERYTERM":z1411.cdDeliveryTerm = Children(i).Code
   Case "SEDELIVERYTERM":z1411.seDeliveryTerm = Children(i).Code
   Case "SEPAYMENTTERM":z1411.sePaymentTerm = Children(i).Code
   Case "CDPAYMENTTERM":z1411.cdPaymentTerm = Children(i).Code
   Case "SEPAYMENTCONDITION":z1411.sePaymentCondition = Children(i).Code
   Case "CDPAYMENTCONDITION":z1411.cdPaymentCondition = Children(i).Code
   Case "SEPAYMENTTIME":z1411.sePaymentTime = Children(i).Code
   Case "CDPAYMENTTIME":z1411.cdPaymentTime = Children(i).Code
   Case "SEPAYMENTDAY":z1411.sePaymentDay = Children(i).Code
   Case "CDPAYMENTDAY":z1411.cdPaymentDay = Children(i).Code
   Case "SEMARKETTYPE":z1411.seMarketType = Children(i).Code
   Case "CDMARKETTYPE":z1411.cdMarketType = Children(i).Code
   Case "SEDEPARTMENT":z1411.seDepartment = Children(i).Code
   Case "CDDEPARTMENT":z1411.cdDepartment = Children(i).Code
   Case "SEBRAND":z1411.seBrand = Children(i).Code
   Case "CDBRAND":z1411.cdBrand = Children(i).Code
   Case "CONTRACTIN":z1411.ContractIn = Children(i).Code
   Case "CONTRACTOUT":z1411.ContractOut = Children(i).Code
   Case "DESTINATION":z1411.Destination = Children(i).Code
   Case "CUSTPONO":z1411.CustPoNo = Children(i).Code
   Case "INCHARGESALES":z1411.InchargeSales = Children(i).Code
   Case "INCHARGEPPC":z1411.InchargePPC = Children(i).Code
   Case "DATEINSERT":z1411.DateInsert = Children(i).Code
   Case "DATEUPDATE":z1411.DateUpdate = Children(i).Code
   Case "TIMEINSERT":z1411.TimeInsert = Children(i).Code
   Case "TIMEUPDATE":z1411.TimeUpdate = Children(i).Code
   Case "TOTALQTY":z1411.TotalQty = Children(i).Code
   Case "TOTALAMOUNT":z1411.TotalAmount = Children(i).Code
   Case "TOTALCOST":z1411.TotalCost = Children(i).Code
   Case "TOTALPROFIT":z1411.TotalProfit = Children(i).Code
   Case "ATTACHID":z1411.AttachID = Children(i).Code
   Case "REMARKORDER":z1411.RemarkOrder = Children(i).Code
   Case "REMARKCUSTOMER":z1411.RemarkCustomer = Children(i).Code
   Case "REMARK":z1411.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "ORDERNO":z1411.OrderNo = Children(i).Data
   Case "CUSTOMERCODE":z1411.CustomerCode = Children(i).Data
   Case "VENDORCODE":z1411.VendorCode = Children(i).Data
   Case "AGENTCODE":z1411.AgentCode = Children(i).Data
   Case "BUYER":z1411.Buyer = Children(i).Data
   Case "SEORDERGROUP":z1411.seOrderGroup = Children(i).Data
   Case "CDORDERGROUP":z1411.cdOrderGroup = Children(i).Data
   Case "SEORDERKIND":z1411.seOrderKind = Children(i).Data
   Case "CDORDERKIND":z1411.cdOrderKind = Children(i).Data
   Case "SEORDERTYPE":z1411.seOrderType = Children(i).Data
   Case "CDORDERTYPE":z1411.cdOrderType = Children(i).Data
   Case "CDORDERWORK":z1411.cdOrderWork = Children(i).Data
   Case "SEORDERWORK":z1411.seOrderWork = Children(i).Data
   Case "SESTATESAMPLE":z1411.seStateSample = Children(i).Data
   Case "CDSTATESAMPLE":z1411.cdStateSample = Children(i).Data
   Case "SESTATEOFFICIAL":z1411.seStateOfficial = Children(i).Data
   Case "CDSTATEOFFICIAL":z1411.cdStateOfficial = Children(i).Data
   Case "STATUSORDER":z1411.StatusOrder = Children(i).Data
   Case "DATEORDER":z1411.DateOrder = Children(i).Data
   Case "DATEAPPROVAL":z1411.DateApproval = Children(i).Data
   Case "DATECOMPLETE":z1411.DateComplete = Children(i).Data
   Case "DATECANCEL":z1411.DateCancel = Children(i).Data
   Case "DATEPENDING":z1411.DatePending = Children(i).Data
   Case "SEUNITPRICE":z1411.seUnitPrice = Children(i).Data
   Case "CDUNITPRICE":z1411.cdUnitPrice = Children(i).Data
   Case "PRICEEXCHANGE":z1411.PriceExchange = Children(i).Data
   Case "DATEEXCHANGE":z1411.DateExchange = Children(i).Data
   Case "DATETRANSFER":z1411.DateTransfer = Children(i).Data
   Case "DATEACCEPT":z1411.DateAccept = Children(i).Data
   Case "STATUSTRANSFER":z1411.StatusTransfer = Children(i).Data
   Case "SESEASON":z1411.seSeason = Children(i).Data
   Case "CDSEASON":z1411.cdSeason = Children(i).Data
   Case "SESHIPPINGTERM":z1411.seShippingTerm = Children(i).Data
   Case "CDSHIPPINGTERM":z1411.cdShippingTerm = Children(i).Data
   Case "CDDELIVERYTERM":z1411.cdDeliveryTerm = Children(i).Data
   Case "SEDELIVERYTERM":z1411.seDeliveryTerm = Children(i).Data
   Case "SEPAYMENTTERM":z1411.sePaymentTerm = Children(i).Data
   Case "CDPAYMENTTERM":z1411.cdPaymentTerm = Children(i).Data
   Case "SEPAYMENTCONDITION":z1411.sePaymentCondition = Children(i).Data
   Case "CDPAYMENTCONDITION":z1411.cdPaymentCondition = Children(i).Data
   Case "SEPAYMENTTIME":z1411.sePaymentTime = Children(i).Data
   Case "CDPAYMENTTIME":z1411.cdPaymentTime = Children(i).Data
   Case "SEPAYMENTDAY":z1411.sePaymentDay = Children(i).Data
   Case "CDPAYMENTDAY":z1411.cdPaymentDay = Children(i).Data
   Case "SEMARKETTYPE":z1411.seMarketType = Children(i).Data
   Case "CDMARKETTYPE":z1411.cdMarketType = Children(i).Data
   Case "SEDEPARTMENT":z1411.seDepartment = Children(i).Data
   Case "CDDEPARTMENT":z1411.cdDepartment = Children(i).Data
   Case "SEBRAND":z1411.seBrand = Children(i).Data
   Case "CDBRAND":z1411.cdBrand = Children(i).Data
   Case "CONTRACTIN":z1411.ContractIn = Children(i).Data
   Case "CONTRACTOUT":z1411.ContractOut = Children(i).Data
   Case "DESTINATION":z1411.Destination = Children(i).Data
   Case "CUSTPONO":z1411.CustPoNo = Children(i).Data
   Case "INCHARGESALES":z1411.InchargeSales = Children(i).Data
   Case "INCHARGEPPC":z1411.InchargePPC = Children(i).Data
   Case "DATEINSERT":z1411.DateInsert = Children(i).Data
   Case "DATEUPDATE":z1411.DateUpdate = Children(i).Data
   Case "TIMEINSERT":z1411.TimeInsert = Children(i).Data
   Case "TIMEUPDATE":z1411.TimeUpdate = Children(i).Data
   Case "TOTALQTY":z1411.TotalQty = Children(i).Data
   Case "TOTALAMOUNT":z1411.TotalAmount = Children(i).Data
   Case "TOTALCOST":z1411.TotalCost = Children(i).Data
   Case "TOTALPROFIT":z1411.TotalProfit = Children(i).Data
   Case "ATTACHID":z1411.AttachID = Children(i).Data
   Case "REMARKORDER":z1411.RemarkOrder = Children(i).Data
   Case "REMARKCUSTOMER":z1411.RemarkCustomer = Children(i).Data
   Case "REMARK":z1411.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K1411_MOVE",vbCritical)
End Try
End Function 
    
End Module 
