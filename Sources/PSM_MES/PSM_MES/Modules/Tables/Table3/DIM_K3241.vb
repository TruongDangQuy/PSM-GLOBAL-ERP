'=========================================================================================================================================================
'   TABLE : (PFK3241)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K3241

Structure T3241_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	RequestSalesNo	 AS String	'			char(9)		*
Public 	PINo	 AS String	'			nvarchar(20)
Public 	DateAccept	 AS String	'			char(8)
Public 	CheckSalesType	 AS String	'			char(1)
Public 	CheckIOType	 AS String	'			char(1)
Public 	CheckFinalInbound	 AS String	'			char(1)
Public 	CheckFinalOutbound	 AS String	'			char(1)
Public 	CheckMaterialType	 AS String	'			char(1)
Public 	CheckMarketType	 AS String	'			char(1)
Public 	selPaymentCondition	 AS String	'			char(3)
Public 	cdPaymentCondition	 AS String	'			char(3)
Public 	InchargeRequestSales	 AS String	'			char(8)
Public 	SupplyCode	 AS String	'			char(6)
Public 	DateExchange	 AS String	'			char(8)
Public 	PriceExchange	 AS Double	'			decimal
Public 	AmtNetRequestSalesUSD	 AS Double	'			decimal
Public 	AmtNetRequestSalesVND	 AS Double	'			decimal
Public 	AmtTaxExportRequestSales	 AS Double	'			decimal
Public 	AmtTaxVatRequestSales	 AS Double	'			decimal
Public 	AmtGressRequestSalesUSD	 AS Double	'			decimal
Public 	AmtGressRequestSalesVND	 AS Double	'			decimal
Public 	DateDelivery	 AS String	'			char(8)
Public 	SalesOrderNo	 AS String	'			char(9)
Public 	CheckRequestSales	 AS String	'			char(1)
Public 	DateRequestSales	 AS String	'			char(8)
Public 	DateCompleteSales	 AS String	'			char(8)
Public 	DateApprovalSales	 AS String	'			char(8)
Public 	DateCancelSales	 AS String	'			char(8)
Public 	Remark	 AS String	'			nchar(200)
'=========================================================================================================================================================
End structure

Public D3241 As T3241_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK3241(REQUESTSALESNO AS String) As Boolean
    READ_PFK3241 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK3241 "
    SQL = SQL & " WHERE K3241_RequestSalesNo		 = '" & RequestSalesNo & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D3241_CLEAR: GoTo SKIP_READ_PFK3241
                
    Call K3241_MOVE(rd)
    READ_PFK3241 = True

SKIP_READ_PFK3241:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK3241",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK3241(REQUESTSALESNO AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK3241 "
    SQL = SQL & " WHERE K3241_RequestSalesNo		 = '" & RequestSalesNo & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK3241",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK3241(z3241 As T3241_AREA) As Boolean
    WRITE_PFK3241 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z3241)
 
    SQL = " INSERT INTO PFK3241 "
    SQL = SQL & " ( "
    SQL = SQL & " K3241_RequestSalesNo," 
    SQL = SQL & " K3241_PINo," 
    SQL = SQL & " K3241_DateAccept," 
    SQL = SQL & " K3241_CheckSalesType," 
    SQL = SQL & " K3241_CheckIOType," 
    SQL = SQL & " K3241_CheckFinalInbound," 
    SQL = SQL & " K3241_CheckFinalOutbound," 
    SQL = SQL & " K3241_CheckMaterialType," 
    SQL = SQL & " K3241_CheckMarketType," 
    SQL = SQL & " K3241_selPaymentCondition," 
    SQL = SQL & " K3241_cdPaymentCondition," 
    SQL = SQL & " K3241_InchargeRequestSales," 
    SQL = SQL & " K3241_SupplyCode," 
    SQL = SQL & " K3241_DateExchange," 
    SQL = SQL & " K3241_PriceExchange," 
    SQL = SQL & " K3241_AmtNetRequestSalesUSD," 
    SQL = SQL & " K3241_AmtNetRequestSalesVND," 
    SQL = SQL & " K3241_AmtTaxExportRequestSales," 
    SQL = SQL & " K3241_AmtTaxVatRequestSales," 
    SQL = SQL & " K3241_AmtGressRequestSalesUSD," 
    SQL = SQL & " K3241_AmtGressRequestSalesVND," 
    SQL = SQL & " K3241_DateDelivery," 
    SQL = SQL & " K3241_SalesOrderNo," 
    SQL = SQL & " K3241_CheckRequestSales," 
    SQL = SQL & " K3241_DateRequestSales," 
    SQL = SQL & " K3241_DateCompleteSales," 
    SQL = SQL & " K3241_DateApprovalSales," 
    SQL = SQL & " K3241_DateCancelSales," 
    SQL = SQL & " K3241_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z3241.RequestSalesNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3241.PINo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3241.DateAccept) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3241.CheckSalesType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3241.CheckIOType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3241.CheckFinalInbound) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3241.CheckFinalOutbound) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3241.CheckMaterialType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3241.CheckMarketType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3241.selPaymentCondition) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3241.cdPaymentCondition) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3241.InchargeRequestSales) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3241.SupplyCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3241.DateExchange) & "', "  
    SQL = SQL & "   " & FormatSQL(z3241.PriceExchange) & ", "  
    SQL = SQL & "   " & FormatSQL(z3241.AmtNetRequestSalesUSD) & ", "  
    SQL = SQL & "   " & FormatSQL(z3241.AmtNetRequestSalesVND) & ", "  
    SQL = SQL & "   " & FormatSQL(z3241.AmtTaxExportRequestSales) & ", "  
    SQL = SQL & "   " & FormatSQL(z3241.AmtTaxVatRequestSales) & ", "  
    SQL = SQL & "   " & FormatSQL(z3241.AmtGressRequestSalesUSD) & ", "  
    SQL = SQL & "   " & FormatSQL(z3241.AmtGressRequestSalesVND) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z3241.DateDelivery) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3241.SalesOrderNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3241.CheckRequestSales) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3241.DateRequestSales) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3241.DateCompleteSales) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3241.DateApprovalSales) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3241.DateCancelSales) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3241.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK3241 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK3241",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK3241(z3241 As T3241_AREA) As Boolean
    REWRITE_PFK3241 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z3241)
   
    SQL = " UPDATE PFK3241 SET "
    SQL = SQL & "    K3241_PINo      = N'" & FormatSQL(z3241.PINo) & "', " 
    SQL = SQL & "    K3241_DateAccept      = N'" & FormatSQL(z3241.DateAccept) & "', " 
    SQL = SQL & "    K3241_CheckSalesType      = N'" & FormatSQL(z3241.CheckSalesType) & "', " 
    SQL = SQL & "    K3241_CheckIOType      = N'" & FormatSQL(z3241.CheckIOType) & "', " 
    SQL = SQL & "    K3241_CheckFinalInbound      = N'" & FormatSQL(z3241.CheckFinalInbound) & "', " 
    SQL = SQL & "    K3241_CheckFinalOutbound      = N'" & FormatSQL(z3241.CheckFinalOutbound) & "', " 
    SQL = SQL & "    K3241_CheckMaterialType      = N'" & FormatSQL(z3241.CheckMaterialType) & "', " 
    SQL = SQL & "    K3241_CheckMarketType      = N'" & FormatSQL(z3241.CheckMarketType) & "', " 
    SQL = SQL & "    K3241_selPaymentCondition      = N'" & FormatSQL(z3241.selPaymentCondition) & "', " 
    SQL = SQL & "    K3241_cdPaymentCondition      = N'" & FormatSQL(z3241.cdPaymentCondition) & "', " 
    SQL = SQL & "    K3241_InchargeRequestSales      = N'" & FormatSQL(z3241.InchargeRequestSales) & "', " 
    SQL = SQL & "    K3241_SupplyCode      = N'" & FormatSQL(z3241.SupplyCode) & "', " 
    SQL = SQL & "    K3241_DateExchange      = N'" & FormatSQL(z3241.DateExchange) & "', " 
    SQL = SQL & "    K3241_PriceExchange      =  " & FormatSQL(z3241.PriceExchange) & ", " 
    SQL = SQL & "    K3241_AmtNetRequestSalesUSD      =  " & FormatSQL(z3241.AmtNetRequestSalesUSD) & ", " 
    SQL = SQL & "    K3241_AmtNetRequestSalesVND      =  " & FormatSQL(z3241.AmtNetRequestSalesVND) & ", " 
    SQL = SQL & "    K3241_AmtTaxExportRequestSales      =  " & FormatSQL(z3241.AmtTaxExportRequestSales) & ", " 
    SQL = SQL & "    K3241_AmtTaxVatRequestSales      =  " & FormatSQL(z3241.AmtTaxVatRequestSales) & ", " 
    SQL = SQL & "    K3241_AmtGressRequestSalesUSD      =  " & FormatSQL(z3241.AmtGressRequestSalesUSD) & ", " 
    SQL = SQL & "    K3241_AmtGressRequestSalesVND      =  " & FormatSQL(z3241.AmtGressRequestSalesVND) & ", " 
    SQL = SQL & "    K3241_DateDelivery      = N'" & FormatSQL(z3241.DateDelivery) & "', " 
    SQL = SQL & "    K3241_SalesOrderNo      = N'" & FormatSQL(z3241.SalesOrderNo) & "', " 
    SQL = SQL & "    K3241_CheckRequestSales      = N'" & FormatSQL(z3241.CheckRequestSales) & "', " 
    SQL = SQL & "    K3241_DateRequestSales      = N'" & FormatSQL(z3241.DateRequestSales) & "', " 
    SQL = SQL & "    K3241_DateCompleteSales      = N'" & FormatSQL(z3241.DateCompleteSales) & "', " 
    SQL = SQL & "    K3241_DateApprovalSales      = N'" & FormatSQL(z3241.DateApprovalSales) & "', " 
    SQL = SQL & "    K3241_DateCancelSales      = N'" & FormatSQL(z3241.DateCancelSales) & "', " 
    SQL = SQL & "    K3241_Remark      = N'" & FormatSQL(z3241.Remark) & "'  " 
    SQL = SQL & " WHERE K3241_RequestSalesNo		 = '" & z3241.RequestSalesNo & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK3241 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK3241",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK3241(z3241 As T3241_AREA) As Boolean
    DELETE_PFK3241 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK3241 "
    SQL = SQL & " WHERE K3241_RequestSalesNo		 = '" & z3241.RequestSalesNo & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK3241 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK3241",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D3241_CLEAR()
Try
    
   D3241.RequestSalesNo = ""
   D3241.PINo = ""
   D3241.DateAccept = ""
   D3241.CheckSalesType = ""
   D3241.CheckIOType = ""
   D3241.CheckFinalInbound = ""
   D3241.CheckFinalOutbound = ""
   D3241.CheckMaterialType = ""
   D3241.CheckMarketType = ""
   D3241.selPaymentCondition = ""
   D3241.cdPaymentCondition = ""
   D3241.InchargeRequestSales = ""
   D3241.SupplyCode = ""
   D3241.DateExchange = ""
    D3241.PriceExchange = 0 
    D3241.AmtNetRequestSalesUSD = 0 
    D3241.AmtNetRequestSalesVND = 0 
    D3241.AmtTaxExportRequestSales = 0 
    D3241.AmtTaxVatRequestSales = 0 
    D3241.AmtGressRequestSalesUSD = 0 
    D3241.AmtGressRequestSalesVND = 0 
   D3241.DateDelivery = ""
   D3241.SalesOrderNo = ""
   D3241.CheckRequestSales = ""
   D3241.DateRequestSales = ""
   D3241.DateCompleteSales = ""
   D3241.DateApprovalSales = ""
   D3241.DateCancelSales = ""
   D3241.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D3241_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x3241 As T3241_AREA)
Try
    
    x3241.RequestSalesNo = trim$(  x3241.RequestSalesNo)
    x3241.PINo = trim$(  x3241.PINo)
    x3241.DateAccept = trim$(  x3241.DateAccept)
    x3241.CheckSalesType = trim$(  x3241.CheckSalesType)
    x3241.CheckIOType = trim$(  x3241.CheckIOType)
    x3241.CheckFinalInbound = trim$(  x3241.CheckFinalInbound)
    x3241.CheckFinalOutbound = trim$(  x3241.CheckFinalOutbound)
    x3241.CheckMaterialType = trim$(  x3241.CheckMaterialType)
    x3241.CheckMarketType = trim$(  x3241.CheckMarketType)
    x3241.selPaymentCondition = trim$(  x3241.selPaymentCondition)
    x3241.cdPaymentCondition = trim$(  x3241.cdPaymentCondition)
    x3241.InchargeRequestSales = trim$(  x3241.InchargeRequestSales)
    x3241.SupplyCode = trim$(  x3241.SupplyCode)
    x3241.DateExchange = trim$(  x3241.DateExchange)
    x3241.PriceExchange = trim$(  x3241.PriceExchange)
    x3241.AmtNetRequestSalesUSD = trim$(  x3241.AmtNetRequestSalesUSD)
    x3241.AmtNetRequestSalesVND = trim$(  x3241.AmtNetRequestSalesVND)
    x3241.AmtTaxExportRequestSales = trim$(  x3241.AmtTaxExportRequestSales)
    x3241.AmtTaxVatRequestSales = trim$(  x3241.AmtTaxVatRequestSales)
    x3241.AmtGressRequestSalesUSD = trim$(  x3241.AmtGressRequestSalesUSD)
    x3241.AmtGressRequestSalesVND = trim$(  x3241.AmtGressRequestSalesVND)
    x3241.DateDelivery = trim$(  x3241.DateDelivery)
    x3241.SalesOrderNo = trim$(  x3241.SalesOrderNo)
    x3241.CheckRequestSales = trim$(  x3241.CheckRequestSales)
    x3241.DateRequestSales = trim$(  x3241.DateRequestSales)
    x3241.DateCompleteSales = trim$(  x3241.DateCompleteSales)
    x3241.DateApprovalSales = trim$(  x3241.DateApprovalSales)
    x3241.DateCancelSales = trim$(  x3241.DateCancelSales)
    x3241.Remark = trim$(  x3241.Remark)
     
    If trim$( x3241.RequestSalesNo ) = "" Then x3241.RequestSalesNo = Space(1) 
    If trim$( x3241.PINo ) = "" Then x3241.PINo = Space(1) 
    If trim$( x3241.DateAccept ) = "" Then x3241.DateAccept = Space(1) 
    If trim$( x3241.CheckSalesType ) = "" Then x3241.CheckSalesType = Space(1) 
    If trim$( x3241.CheckIOType ) = "" Then x3241.CheckIOType = Space(1) 
    If trim$( x3241.CheckFinalInbound ) = "" Then x3241.CheckFinalInbound = Space(1) 
    If trim$( x3241.CheckFinalOutbound ) = "" Then x3241.CheckFinalOutbound = Space(1) 
    If trim$( x3241.CheckMaterialType ) = "" Then x3241.CheckMaterialType = Space(1) 
    If trim$( x3241.CheckMarketType ) = "" Then x3241.CheckMarketType = Space(1) 
    If trim$( x3241.selPaymentCondition ) = "" Then x3241.selPaymentCondition = Space(1) 
    If trim$( x3241.cdPaymentCondition ) = "" Then x3241.cdPaymentCondition = Space(1) 
    If trim$( x3241.InchargeRequestSales ) = "" Then x3241.InchargeRequestSales = Space(1) 
    If trim$( x3241.SupplyCode ) = "" Then x3241.SupplyCode = Space(1) 
    If trim$( x3241.DateExchange ) = "" Then x3241.DateExchange = Space(1) 
    If trim$( x3241.PriceExchange ) = "" Then x3241.PriceExchange = 0 
    If trim$( x3241.AmtNetRequestSalesUSD ) = "" Then x3241.AmtNetRequestSalesUSD = 0 
    If trim$( x3241.AmtNetRequestSalesVND ) = "" Then x3241.AmtNetRequestSalesVND = 0 
    If trim$( x3241.AmtTaxExportRequestSales ) = "" Then x3241.AmtTaxExportRequestSales = 0 
    If trim$( x3241.AmtTaxVatRequestSales ) = "" Then x3241.AmtTaxVatRequestSales = 0 
    If trim$( x3241.AmtGressRequestSalesUSD ) = "" Then x3241.AmtGressRequestSalesUSD = 0 
    If trim$( x3241.AmtGressRequestSalesVND ) = "" Then x3241.AmtGressRequestSalesVND = 0 
    If trim$( x3241.DateDelivery ) = "" Then x3241.DateDelivery = Space(1) 
    If trim$( x3241.SalesOrderNo ) = "" Then x3241.SalesOrderNo = Space(1) 
    If trim$( x3241.CheckRequestSales ) = "" Then x3241.CheckRequestSales = Space(1) 
    If trim$( x3241.DateRequestSales ) = "" Then x3241.DateRequestSales = Space(1) 
    If trim$( x3241.DateCompleteSales ) = "" Then x3241.DateCompleteSales = Space(1) 
    If trim$( x3241.DateApprovalSales ) = "" Then x3241.DateApprovalSales = Space(1) 
    If trim$( x3241.DateCancelSales ) = "" Then x3241.DateCancelSales = Space(1) 
    If trim$( x3241.Remark ) = "" Then x3241.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K3241_MOVE(rs3241 As SqlClient.SqlDataReader)
Try

    call D3241_CLEAR()   

    If IsdbNull(rs3241!K3241_RequestSalesNo) = False Then D3241.RequestSalesNo = Trim$(rs3241!K3241_RequestSalesNo)
    If IsdbNull(rs3241!K3241_PINo) = False Then D3241.PINo = Trim$(rs3241!K3241_PINo)
    If IsdbNull(rs3241!K3241_DateAccept) = False Then D3241.DateAccept = Trim$(rs3241!K3241_DateAccept)
    If IsdbNull(rs3241!K3241_CheckSalesType) = False Then D3241.CheckSalesType = Trim$(rs3241!K3241_CheckSalesType)
    If IsdbNull(rs3241!K3241_CheckIOType) = False Then D3241.CheckIOType = Trim$(rs3241!K3241_CheckIOType)
    If IsdbNull(rs3241!K3241_CheckFinalInbound) = False Then D3241.CheckFinalInbound = Trim$(rs3241!K3241_CheckFinalInbound)
    If IsdbNull(rs3241!K3241_CheckFinalOutbound) = False Then D3241.CheckFinalOutbound = Trim$(rs3241!K3241_CheckFinalOutbound)
    If IsdbNull(rs3241!K3241_CheckMaterialType) = False Then D3241.CheckMaterialType = Trim$(rs3241!K3241_CheckMaterialType)
    If IsdbNull(rs3241!K3241_CheckMarketType) = False Then D3241.CheckMarketType = Trim$(rs3241!K3241_CheckMarketType)
    If IsdbNull(rs3241!K3241_selPaymentCondition) = False Then D3241.selPaymentCondition = Trim$(rs3241!K3241_selPaymentCondition)
    If IsdbNull(rs3241!K3241_cdPaymentCondition) = False Then D3241.cdPaymentCondition = Trim$(rs3241!K3241_cdPaymentCondition)
    If IsdbNull(rs3241!K3241_InchargeRequestSales) = False Then D3241.InchargeRequestSales = Trim$(rs3241!K3241_InchargeRequestSales)
    If IsdbNull(rs3241!K3241_SupplyCode) = False Then D3241.SupplyCode = Trim$(rs3241!K3241_SupplyCode)
    If IsdbNull(rs3241!K3241_DateExchange) = False Then D3241.DateExchange = Trim$(rs3241!K3241_DateExchange)
    If IsdbNull(rs3241!K3241_PriceExchange) = False Then D3241.PriceExchange = Trim$(rs3241!K3241_PriceExchange)
    If IsdbNull(rs3241!K3241_AmtNetRequestSalesUSD) = False Then D3241.AmtNetRequestSalesUSD = Trim$(rs3241!K3241_AmtNetRequestSalesUSD)
    If IsdbNull(rs3241!K3241_AmtNetRequestSalesVND) = False Then D3241.AmtNetRequestSalesVND = Trim$(rs3241!K3241_AmtNetRequestSalesVND)
    If IsdbNull(rs3241!K3241_AmtTaxExportRequestSales) = False Then D3241.AmtTaxExportRequestSales = Trim$(rs3241!K3241_AmtTaxExportRequestSales)
    If IsdbNull(rs3241!K3241_AmtTaxVatRequestSales) = False Then D3241.AmtTaxVatRequestSales = Trim$(rs3241!K3241_AmtTaxVatRequestSales)
    If IsdbNull(rs3241!K3241_AmtGressRequestSalesUSD) = False Then D3241.AmtGressRequestSalesUSD = Trim$(rs3241!K3241_AmtGressRequestSalesUSD)
    If IsdbNull(rs3241!K3241_AmtGressRequestSalesVND) = False Then D3241.AmtGressRequestSalesVND = Trim$(rs3241!K3241_AmtGressRequestSalesVND)
    If IsdbNull(rs3241!K3241_DateDelivery) = False Then D3241.DateDelivery = Trim$(rs3241!K3241_DateDelivery)
    If IsdbNull(rs3241!K3241_SalesOrderNo) = False Then D3241.SalesOrderNo = Trim$(rs3241!K3241_SalesOrderNo)
    If IsdbNull(rs3241!K3241_CheckRequestSales) = False Then D3241.CheckRequestSales = Trim$(rs3241!K3241_CheckRequestSales)
    If IsdbNull(rs3241!K3241_DateRequestSales) = False Then D3241.DateRequestSales = Trim$(rs3241!K3241_DateRequestSales)
    If IsdbNull(rs3241!K3241_DateCompleteSales) = False Then D3241.DateCompleteSales = Trim$(rs3241!K3241_DateCompleteSales)
    If IsdbNull(rs3241!K3241_DateApprovalSales) = False Then D3241.DateApprovalSales = Trim$(rs3241!K3241_DateApprovalSales)
    If IsdbNull(rs3241!K3241_DateCancelSales) = False Then D3241.DateCancelSales = Trim$(rs3241!K3241_DateCancelSales)
    If IsdbNull(rs3241!K3241_Remark) = False Then D3241.Remark = Trim$(rs3241!K3241_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K3241_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K3241_MOVE(rs3241 As DataRow)
Try

    call D3241_CLEAR()   

    If IsdbNull(rs3241!K3241_RequestSalesNo) = False Then D3241.RequestSalesNo = Trim$(rs3241!K3241_RequestSalesNo)
    If IsdbNull(rs3241!K3241_PINo) = False Then D3241.PINo = Trim$(rs3241!K3241_PINo)
    If IsdbNull(rs3241!K3241_DateAccept) = False Then D3241.DateAccept = Trim$(rs3241!K3241_DateAccept)
    If IsdbNull(rs3241!K3241_CheckSalesType) = False Then D3241.CheckSalesType = Trim$(rs3241!K3241_CheckSalesType)
    If IsdbNull(rs3241!K3241_CheckIOType) = False Then D3241.CheckIOType = Trim$(rs3241!K3241_CheckIOType)
    If IsdbNull(rs3241!K3241_CheckFinalInbound) = False Then D3241.CheckFinalInbound = Trim$(rs3241!K3241_CheckFinalInbound)
    If IsdbNull(rs3241!K3241_CheckFinalOutbound) = False Then D3241.CheckFinalOutbound = Trim$(rs3241!K3241_CheckFinalOutbound)
    If IsdbNull(rs3241!K3241_CheckMaterialType) = False Then D3241.CheckMaterialType = Trim$(rs3241!K3241_CheckMaterialType)
    If IsdbNull(rs3241!K3241_CheckMarketType) = False Then D3241.CheckMarketType = Trim$(rs3241!K3241_CheckMarketType)
    If IsdbNull(rs3241!K3241_selPaymentCondition) = False Then D3241.selPaymentCondition = Trim$(rs3241!K3241_selPaymentCondition)
    If IsdbNull(rs3241!K3241_cdPaymentCondition) = False Then D3241.cdPaymentCondition = Trim$(rs3241!K3241_cdPaymentCondition)
    If IsdbNull(rs3241!K3241_InchargeRequestSales) = False Then D3241.InchargeRequestSales = Trim$(rs3241!K3241_InchargeRequestSales)
    If IsdbNull(rs3241!K3241_SupplyCode) = False Then D3241.SupplyCode = Trim$(rs3241!K3241_SupplyCode)
    If IsdbNull(rs3241!K3241_DateExchange) = False Then D3241.DateExchange = Trim$(rs3241!K3241_DateExchange)
    If IsdbNull(rs3241!K3241_PriceExchange) = False Then D3241.PriceExchange = Trim$(rs3241!K3241_PriceExchange)
    If IsdbNull(rs3241!K3241_AmtNetRequestSalesUSD) = False Then D3241.AmtNetRequestSalesUSD = Trim$(rs3241!K3241_AmtNetRequestSalesUSD)
    If IsdbNull(rs3241!K3241_AmtNetRequestSalesVND) = False Then D3241.AmtNetRequestSalesVND = Trim$(rs3241!K3241_AmtNetRequestSalesVND)
    If IsdbNull(rs3241!K3241_AmtTaxExportRequestSales) = False Then D3241.AmtTaxExportRequestSales = Trim$(rs3241!K3241_AmtTaxExportRequestSales)
    If IsdbNull(rs3241!K3241_AmtTaxVatRequestSales) = False Then D3241.AmtTaxVatRequestSales = Trim$(rs3241!K3241_AmtTaxVatRequestSales)
    If IsdbNull(rs3241!K3241_AmtGressRequestSalesUSD) = False Then D3241.AmtGressRequestSalesUSD = Trim$(rs3241!K3241_AmtGressRequestSalesUSD)
    If IsdbNull(rs3241!K3241_AmtGressRequestSalesVND) = False Then D3241.AmtGressRequestSalesVND = Trim$(rs3241!K3241_AmtGressRequestSalesVND)
    If IsdbNull(rs3241!K3241_DateDelivery) = False Then D3241.DateDelivery = Trim$(rs3241!K3241_DateDelivery)
    If IsdbNull(rs3241!K3241_SalesOrderNo) = False Then D3241.SalesOrderNo = Trim$(rs3241!K3241_SalesOrderNo)
    If IsdbNull(rs3241!K3241_CheckRequestSales) = False Then D3241.CheckRequestSales = Trim$(rs3241!K3241_CheckRequestSales)
    If IsdbNull(rs3241!K3241_DateRequestSales) = False Then D3241.DateRequestSales = Trim$(rs3241!K3241_DateRequestSales)
    If IsdbNull(rs3241!K3241_DateCompleteSales) = False Then D3241.DateCompleteSales = Trim$(rs3241!K3241_DateCompleteSales)
    If IsdbNull(rs3241!K3241_DateApprovalSales) = False Then D3241.DateApprovalSales = Trim$(rs3241!K3241_DateApprovalSales)
    If IsdbNull(rs3241!K3241_DateCancelSales) = False Then D3241.DateCancelSales = Trim$(rs3241!K3241_DateCancelSales)
    If IsdbNull(rs3241!K3241_Remark) = False Then D3241.Remark = Trim$(rs3241!K3241_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K3241_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K3241_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z3241 As T3241_AREA, REQUESTSALESNO AS String) as Boolean

K3241_MOVE = False

Try
    If READ_PFK3241(REQUESTSALESNO) = True Then
                z3241 = D3241
		K3241_MOVE = True
		else
	z3241 = nothing
     End If

     If  getColumIndex(spr,"RequestSalesNo") > -1 then z3241.RequestSalesNo = getDataM(spr, getColumIndex(spr,"RequestSalesNo"), xRow)
     If  getColumIndex(spr,"PINo") > -1 then z3241.PINo = getDataM(spr, getColumIndex(spr,"PINo"), xRow)
     If  getColumIndex(spr,"DateAccept") > -1 then z3241.DateAccept = getDataM(spr, getColumIndex(spr,"DateAccept"), xRow)
     If  getColumIndex(spr,"CheckSalesType") > -1 then z3241.CheckSalesType = getDataM(spr, getColumIndex(spr,"CheckSalesType"), xRow)
     If  getColumIndex(spr,"CheckIOType") > -1 then z3241.CheckIOType = getDataM(spr, getColumIndex(spr,"CheckIOType"), xRow)
     If  getColumIndex(spr,"CheckFinalInbound") > -1 then z3241.CheckFinalInbound = getDataM(spr, getColumIndex(spr,"CheckFinalInbound"), xRow)
     If  getColumIndex(spr,"CheckFinalOutbound") > -1 then z3241.CheckFinalOutbound = getDataM(spr, getColumIndex(spr,"CheckFinalOutbound"), xRow)
     If  getColumIndex(spr,"CheckMaterialType") > -1 then z3241.CheckMaterialType = getDataM(spr, getColumIndex(spr,"CheckMaterialType"), xRow)
     If  getColumIndex(spr,"CheckMarketType") > -1 then z3241.CheckMarketType = getDataM(spr, getColumIndex(spr,"CheckMarketType"), xRow)
     If  getColumIndex(spr,"selPaymentCondition") > -1 then z3241.selPaymentCondition = getDataM(spr, getColumIndex(spr,"selPaymentCondition"), xRow)
     If  getColumIndex(spr,"cdPaymentCondition") > -1 then z3241.cdPaymentCondition = getDataM(spr, getColumIndex(spr,"cdPaymentCondition"), xRow)
     If  getColumIndex(spr,"InchargeRequestSales") > -1 then z3241.InchargeRequestSales = getDataM(spr, getColumIndex(spr,"InchargeRequestSales"), xRow)
     If  getColumIndex(spr,"SupplyCode") > -1 then z3241.SupplyCode = getDataM(spr, getColumIndex(spr,"SupplyCode"), xRow)
     If  getColumIndex(spr,"DateExchange") > -1 then z3241.DateExchange = getDataM(spr, getColumIndex(spr,"DateExchange"), xRow)
     If  getColumIndex(spr,"PriceExchange") > -1 then z3241.PriceExchange = getDataM(spr, getColumIndex(spr,"PriceExchange"), xRow)
     If  getColumIndex(spr,"AmtNetRequestSalesUSD") > -1 then z3241.AmtNetRequestSalesUSD = getDataM(spr, getColumIndex(spr,"AmtNetRequestSalesUSD"), xRow)
     If  getColumIndex(spr,"AmtNetRequestSalesVND") > -1 then z3241.AmtNetRequestSalesVND = getDataM(spr, getColumIndex(spr,"AmtNetRequestSalesVND"), xRow)
     If  getColumIndex(spr,"AmtTaxExportRequestSales") > -1 then z3241.AmtTaxExportRequestSales = getDataM(spr, getColumIndex(spr,"AmtTaxExportRequestSales"), xRow)
     If  getColumIndex(spr,"AmtTaxVatRequestSales") > -1 then z3241.AmtTaxVatRequestSales = getDataM(spr, getColumIndex(spr,"AmtTaxVatRequestSales"), xRow)
     If  getColumIndex(spr,"AmtGressRequestSalesUSD") > -1 then z3241.AmtGressRequestSalesUSD = getDataM(spr, getColumIndex(spr,"AmtGressRequestSalesUSD"), xRow)
     If  getColumIndex(spr,"AmtGressRequestSalesVND") > -1 then z3241.AmtGressRequestSalesVND = getDataM(spr, getColumIndex(spr,"AmtGressRequestSalesVND"), xRow)
     If  getColumIndex(spr,"DateDelivery") > -1 then z3241.DateDelivery = getDataM(spr, getColumIndex(spr,"DateDelivery"), xRow)
     If  getColumIndex(spr,"SalesOrderNo") > -1 then z3241.SalesOrderNo = getDataM(spr, getColumIndex(spr,"SalesOrderNo"), xRow)
     If  getColumIndex(spr,"CheckRequestSales") > -1 then z3241.CheckRequestSales = getDataM(spr, getColumIndex(spr,"CheckRequestSales"), xRow)
     If  getColumIndex(spr,"DateRequestSales") > -1 then z3241.DateRequestSales = getDataM(spr, getColumIndex(spr,"DateRequestSales"), xRow)
     If  getColumIndex(spr,"DateCompleteSales") > -1 then z3241.DateCompleteSales = getDataM(spr, getColumIndex(spr,"DateCompleteSales"), xRow)
     If  getColumIndex(spr,"DateApprovalSales") > -1 then z3241.DateApprovalSales = getDataM(spr, getColumIndex(spr,"DateApprovalSales"), xRow)
     If  getColumIndex(spr,"DateCancelSales") > -1 then z3241.DateCancelSales = getDataM(spr, getColumIndex(spr,"DateCancelSales"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z3241.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K3241_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K3241_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z3241 As T3241_AREA,CheckClear as Boolean,REQUESTSALESNO AS String) as Boolean

K3241_MOVE = False

Try
    If READ_PFK3241(REQUESTSALESNO) = True Then
                z3241 = D3241
		K3241_MOVE = True
		else
	If CheckClear  = True then z3241 = nothing
     End If

     If  getColumIndex(spr,"RequestSalesNo") > -1 then z3241.RequestSalesNo = getDataM(spr, getColumIndex(spr,"RequestSalesNo"), xRow)
     If  getColumIndex(spr,"PINo") > -1 then z3241.PINo = getDataM(spr, getColumIndex(spr,"PINo"), xRow)
     If  getColumIndex(spr,"DateAccept") > -1 then z3241.DateAccept = getDataM(spr, getColumIndex(spr,"DateAccept"), xRow)
     If  getColumIndex(spr,"CheckSalesType") > -1 then z3241.CheckSalesType = getDataM(spr, getColumIndex(spr,"CheckSalesType"), xRow)
     If  getColumIndex(spr,"CheckIOType") > -1 then z3241.CheckIOType = getDataM(spr, getColumIndex(spr,"CheckIOType"), xRow)
     If  getColumIndex(spr,"CheckFinalInbound") > -1 then z3241.CheckFinalInbound = getDataM(spr, getColumIndex(spr,"CheckFinalInbound"), xRow)
     If  getColumIndex(spr,"CheckFinalOutbound") > -1 then z3241.CheckFinalOutbound = getDataM(spr, getColumIndex(spr,"CheckFinalOutbound"), xRow)
     If  getColumIndex(spr,"CheckMaterialType") > -1 then z3241.CheckMaterialType = getDataM(spr, getColumIndex(spr,"CheckMaterialType"), xRow)
     If  getColumIndex(spr,"CheckMarketType") > -1 then z3241.CheckMarketType = getDataM(spr, getColumIndex(spr,"CheckMarketType"), xRow)
     If  getColumIndex(spr,"selPaymentCondition") > -1 then z3241.selPaymentCondition = getDataM(spr, getColumIndex(spr,"selPaymentCondition"), xRow)
     If  getColumIndex(spr,"cdPaymentCondition") > -1 then z3241.cdPaymentCondition = getDataM(spr, getColumIndex(spr,"cdPaymentCondition"), xRow)
     If  getColumIndex(spr,"InchargeRequestSales") > -1 then z3241.InchargeRequestSales = getDataM(spr, getColumIndex(spr,"InchargeRequestSales"), xRow)
     If  getColumIndex(spr,"SupplyCode") > -1 then z3241.SupplyCode = getDataM(spr, getColumIndex(spr,"SupplyCode"), xRow)
     If  getColumIndex(spr,"DateExchange") > -1 then z3241.DateExchange = getDataM(spr, getColumIndex(spr,"DateExchange"), xRow)
     If  getColumIndex(spr,"PriceExchange") > -1 then z3241.PriceExchange = getDataM(spr, getColumIndex(spr,"PriceExchange"), xRow)
     If  getColumIndex(spr,"AmtNetRequestSalesUSD") > -1 then z3241.AmtNetRequestSalesUSD = getDataM(spr, getColumIndex(spr,"AmtNetRequestSalesUSD"), xRow)
     If  getColumIndex(spr,"AmtNetRequestSalesVND") > -1 then z3241.AmtNetRequestSalesVND = getDataM(spr, getColumIndex(spr,"AmtNetRequestSalesVND"), xRow)
     If  getColumIndex(spr,"AmtTaxExportRequestSales") > -1 then z3241.AmtTaxExportRequestSales = getDataM(spr, getColumIndex(spr,"AmtTaxExportRequestSales"), xRow)
     If  getColumIndex(spr,"AmtTaxVatRequestSales") > -1 then z3241.AmtTaxVatRequestSales = getDataM(spr, getColumIndex(spr,"AmtTaxVatRequestSales"), xRow)
     If  getColumIndex(spr,"AmtGressRequestSalesUSD") > -1 then z3241.AmtGressRequestSalesUSD = getDataM(spr, getColumIndex(spr,"AmtGressRequestSalesUSD"), xRow)
     If  getColumIndex(spr,"AmtGressRequestSalesVND") > -1 then z3241.AmtGressRequestSalesVND = getDataM(spr, getColumIndex(spr,"AmtGressRequestSalesVND"), xRow)
     If  getColumIndex(spr,"DateDelivery") > -1 then z3241.DateDelivery = getDataM(spr, getColumIndex(spr,"DateDelivery"), xRow)
     If  getColumIndex(spr,"SalesOrderNo") > -1 then z3241.SalesOrderNo = getDataM(spr, getColumIndex(spr,"SalesOrderNo"), xRow)
     If  getColumIndex(spr,"CheckRequestSales") > -1 then z3241.CheckRequestSales = getDataM(spr, getColumIndex(spr,"CheckRequestSales"), xRow)
     If  getColumIndex(spr,"DateRequestSales") > -1 then z3241.DateRequestSales = getDataM(spr, getColumIndex(spr,"DateRequestSales"), xRow)
     If  getColumIndex(spr,"DateCompleteSales") > -1 then z3241.DateCompleteSales = getDataM(spr, getColumIndex(spr,"DateCompleteSales"), xRow)
     If  getColumIndex(spr,"DateApprovalSales") > -1 then z3241.DateApprovalSales = getDataM(spr, getColumIndex(spr,"DateApprovalSales"), xRow)
     If  getColumIndex(spr,"DateCancelSales") > -1 then z3241.DateCancelSales = getDataM(spr, getColumIndex(spr,"DateCancelSales"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z3241.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K3241_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K3241_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z3241 As T3241_AREA, Job as String, REQUESTSALESNO AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K3241_MOVE = False

Try
    If READ_PFK3241(REQUESTSALESNO) = True Then
                z3241 = D3241
		K3241_MOVE = True
		else
	z3241 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3241")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "REQUESTSALESNO":z3241.RequestSalesNo = Children(i).Code
   Case "PINO":z3241.PINo = Children(i).Code
   Case "DATEACCEPT":z3241.DateAccept = Children(i).Code
   Case "CHECKSALESTYPE":z3241.CheckSalesType = Children(i).Code
   Case "CHECKIOTYPE":z3241.CheckIOType = Children(i).Code
   Case "CHECKFINALINBOUND":z3241.CheckFinalInbound = Children(i).Code
   Case "CHECKFINALOUTBOUND":z3241.CheckFinalOutbound = Children(i).Code
   Case "CHECKMATERIALTYPE":z3241.CheckMaterialType = Children(i).Code
   Case "CHECKMARKETTYPE":z3241.CheckMarketType = Children(i).Code
   Case "SELPAYMENTCONDITION":z3241.selPaymentCondition = Children(i).Code
   Case "CDPAYMENTCONDITION":z3241.cdPaymentCondition = Children(i).Code
   Case "INCHARGEREQUESTSALES":z3241.InchargeRequestSales = Children(i).Code
   Case "SUPPLYCODE":z3241.SupplyCode = Children(i).Code
   Case "DATEEXCHANGE":z3241.DateExchange = Children(i).Code
   Case "PRICEEXCHANGE":z3241.PriceExchange = Children(i).Code
   Case "AMTNETREQUESTSALESUSD":z3241.AmtNetRequestSalesUSD = Children(i).Code
   Case "AMTNETREQUESTSALESVND":z3241.AmtNetRequestSalesVND = Children(i).Code
   Case "AMTTAXEXPORTREQUESTSALES":z3241.AmtTaxExportRequestSales = Children(i).Code
   Case "AMTTAXVATREQUESTSALES":z3241.AmtTaxVatRequestSales = Children(i).Code
   Case "AMTGRESSREQUESTSALESUSD":z3241.AmtGressRequestSalesUSD = Children(i).Code
   Case "AMTGRESSREQUESTSALESVND":z3241.AmtGressRequestSalesVND = Children(i).Code
   Case "DATEDELIVERY":z3241.DateDelivery = Children(i).Code
   Case "SALESORDERNO":z3241.SalesOrderNo = Children(i).Code
   Case "CHECKREQUESTSALES":z3241.CheckRequestSales = Children(i).Code
   Case "DATEREQUESTSALES":z3241.DateRequestSales = Children(i).Code
   Case "DATECOMPLETESALES":z3241.DateCompleteSales = Children(i).Code
   Case "DATEAPPROVALSALES":z3241.DateApprovalSales = Children(i).Code
   Case "DATECANCELSALES":z3241.DateCancelSales = Children(i).Code
   Case "REMARK":z3241.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "REQUESTSALESNO":z3241.RequestSalesNo = Children(i).Data
   Case "PINO":z3241.PINo = Children(i).Data
   Case "DATEACCEPT":z3241.DateAccept = Children(i).Data
   Case "CHECKSALESTYPE":z3241.CheckSalesType = Children(i).Data
   Case "CHECKIOTYPE":z3241.CheckIOType = Children(i).Data
   Case "CHECKFINALINBOUND":z3241.CheckFinalInbound = Children(i).Data
   Case "CHECKFINALOUTBOUND":z3241.CheckFinalOutbound = Children(i).Data
   Case "CHECKMATERIALTYPE":z3241.CheckMaterialType = Children(i).Data
   Case "CHECKMARKETTYPE":z3241.CheckMarketType = Children(i).Data
   Case "SELPAYMENTCONDITION":z3241.selPaymentCondition = Children(i).Data
   Case "CDPAYMENTCONDITION":z3241.cdPaymentCondition = Children(i).Data
   Case "INCHARGEREQUESTSALES":z3241.InchargeRequestSales = Children(i).Data
   Case "SUPPLYCODE":z3241.SupplyCode = Children(i).Data
   Case "DATEEXCHANGE":z3241.DateExchange = Children(i).Data
   Case "PRICEEXCHANGE":z3241.PriceExchange = Children(i).Data
   Case "AMTNETREQUESTSALESUSD":z3241.AmtNetRequestSalesUSD = Children(i).Data
   Case "AMTNETREQUESTSALESVND":z3241.AmtNetRequestSalesVND = Children(i).Data
   Case "AMTTAXEXPORTREQUESTSALES":z3241.AmtTaxExportRequestSales = Children(i).Data
   Case "AMTTAXVATREQUESTSALES":z3241.AmtTaxVatRequestSales = Children(i).Data
   Case "AMTGRESSREQUESTSALESUSD":z3241.AmtGressRequestSalesUSD = Children(i).Data
   Case "AMTGRESSREQUESTSALESVND":z3241.AmtGressRequestSalesVND = Children(i).Data
   Case "DATEDELIVERY":z3241.DateDelivery = Children(i).Data
   Case "SALESORDERNO":z3241.SalesOrderNo = Children(i).Data
   Case "CHECKREQUESTSALES":z3241.CheckRequestSales = Children(i).Data
   Case "DATEREQUESTSALES":z3241.DateRequestSales = Children(i).Data
   Case "DATECOMPLETESALES":z3241.DateCompleteSales = Children(i).Data
   Case "DATEAPPROVALSALES":z3241.DateApprovalSales = Children(i).Data
   Case "DATECANCELSALES":z3241.DateCancelSales = Children(i).Data
   Case "REMARK":z3241.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K3241_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K3241_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z3241 As T3241_AREA, Job as String, CheckClear as Boolean, REQUESTSALESNO AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K3241_MOVE = False

Try
    If READ_PFK3241(REQUESTSALESNO) = True Then
                z3241 = D3241
		K3241_MOVE = True
		else
	If CheckClear  = True then z3241 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3241")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "REQUESTSALESNO":z3241.RequestSalesNo = Children(i).Code
   Case "PINO":z3241.PINo = Children(i).Code
   Case "DATEACCEPT":z3241.DateAccept = Children(i).Code
   Case "CHECKSALESTYPE":z3241.CheckSalesType = Children(i).Code
   Case "CHECKIOTYPE":z3241.CheckIOType = Children(i).Code
   Case "CHECKFINALINBOUND":z3241.CheckFinalInbound = Children(i).Code
   Case "CHECKFINALOUTBOUND":z3241.CheckFinalOutbound = Children(i).Code
   Case "CHECKMATERIALTYPE":z3241.CheckMaterialType = Children(i).Code
   Case "CHECKMARKETTYPE":z3241.CheckMarketType = Children(i).Code
   Case "SELPAYMENTCONDITION":z3241.selPaymentCondition = Children(i).Code
   Case "CDPAYMENTCONDITION":z3241.cdPaymentCondition = Children(i).Code
   Case "INCHARGEREQUESTSALES":z3241.InchargeRequestSales = Children(i).Code
   Case "SUPPLYCODE":z3241.SupplyCode = Children(i).Code
   Case "DATEEXCHANGE":z3241.DateExchange = Children(i).Code
   Case "PRICEEXCHANGE":z3241.PriceExchange = Children(i).Code
   Case "AMTNETREQUESTSALESUSD":z3241.AmtNetRequestSalesUSD = Children(i).Code
   Case "AMTNETREQUESTSALESVND":z3241.AmtNetRequestSalesVND = Children(i).Code
   Case "AMTTAXEXPORTREQUESTSALES":z3241.AmtTaxExportRequestSales = Children(i).Code
   Case "AMTTAXVATREQUESTSALES":z3241.AmtTaxVatRequestSales = Children(i).Code
   Case "AMTGRESSREQUESTSALESUSD":z3241.AmtGressRequestSalesUSD = Children(i).Code
   Case "AMTGRESSREQUESTSALESVND":z3241.AmtGressRequestSalesVND = Children(i).Code
   Case "DATEDELIVERY":z3241.DateDelivery = Children(i).Code
   Case "SALESORDERNO":z3241.SalesOrderNo = Children(i).Code
   Case "CHECKREQUESTSALES":z3241.CheckRequestSales = Children(i).Code
   Case "DATEREQUESTSALES":z3241.DateRequestSales = Children(i).Code
   Case "DATECOMPLETESALES":z3241.DateCompleteSales = Children(i).Code
   Case "DATEAPPROVALSALES":z3241.DateApprovalSales = Children(i).Code
   Case "DATECANCELSALES":z3241.DateCancelSales = Children(i).Code
   Case "REMARK":z3241.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "REQUESTSALESNO":z3241.RequestSalesNo = Children(i).Data
   Case "PINO":z3241.PINo = Children(i).Data
   Case "DATEACCEPT":z3241.DateAccept = Children(i).Data
   Case "CHECKSALESTYPE":z3241.CheckSalesType = Children(i).Data
   Case "CHECKIOTYPE":z3241.CheckIOType = Children(i).Data
   Case "CHECKFINALINBOUND":z3241.CheckFinalInbound = Children(i).Data
   Case "CHECKFINALOUTBOUND":z3241.CheckFinalOutbound = Children(i).Data
   Case "CHECKMATERIALTYPE":z3241.CheckMaterialType = Children(i).Data
   Case "CHECKMARKETTYPE":z3241.CheckMarketType = Children(i).Data
   Case "SELPAYMENTCONDITION":z3241.selPaymentCondition = Children(i).Data
   Case "CDPAYMENTCONDITION":z3241.cdPaymentCondition = Children(i).Data
   Case "INCHARGEREQUESTSALES":z3241.InchargeRequestSales = Children(i).Data
   Case "SUPPLYCODE":z3241.SupplyCode = Children(i).Data
   Case "DATEEXCHANGE":z3241.DateExchange = Children(i).Data
   Case "PRICEEXCHANGE":z3241.PriceExchange = Children(i).Data
   Case "AMTNETREQUESTSALESUSD":z3241.AmtNetRequestSalesUSD = Children(i).Data
   Case "AMTNETREQUESTSALESVND":z3241.AmtNetRequestSalesVND = Children(i).Data
   Case "AMTTAXEXPORTREQUESTSALES":z3241.AmtTaxExportRequestSales = Children(i).Data
   Case "AMTTAXVATREQUESTSALES":z3241.AmtTaxVatRequestSales = Children(i).Data
   Case "AMTGRESSREQUESTSALESUSD":z3241.AmtGressRequestSalesUSD = Children(i).Data
   Case "AMTGRESSREQUESTSALESVND":z3241.AmtGressRequestSalesVND = Children(i).Data
   Case "DATEDELIVERY":z3241.DateDelivery = Children(i).Data
   Case "SALESORDERNO":z3241.SalesOrderNo = Children(i).Data
   Case "CHECKREQUESTSALES":z3241.CheckRequestSales = Children(i).Data
   Case "DATEREQUESTSALES":z3241.DateRequestSales = Children(i).Data
   Case "DATECOMPLETESALES":z3241.DateCompleteSales = Children(i).Data
   Case "DATEAPPROVALSALES":z3241.DateApprovalSales = Children(i).Data
   Case "DATECANCELSALES":z3241.DateCancelSales = Children(i).Data
   Case "REMARK":z3241.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K3241_MOVE",vbCritical)
End Try
End Function 
    
End Module 
