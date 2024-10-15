'=========================================================================================================================================================
'   TABLE : (PFK2451)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K2451

Structure T2451_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	ProductInboundNo	 AS String	'			char(8)		*
Public 	ProductInboundSeq	 AS String	'			char(5)		*
Public 	CustomerCode	 AS String	'			char(6)
Public 	SupplierCode	 AS String	'			char(6)
Public 	Dseq	 AS Long	'			int
Public 	InvoiceNo	 AS String	'			nvarchar(20)
Public 	DateInbound	 AS String	'			char(8)
Public 	seFactory	 AS String	'			char(3)
Public 	cdFactory	 AS String	'			char(3)
Public 	seLineProd	 AS String	'			char(3)
Public 	cdLineProd	 AS String	'			char(3)
Public 	CheckProduct	 AS String	'			char(1)
Public 	CheckInBoundMaterial	 AS String	'			char(1)
Public 	CheckMaterialType	 AS String	'			char(1)
Public 	CheckMarketType	 AS String	'			char(1)
Public 	KindProduct	 AS String	'			char(1)
Public 	seUnitPrice	 AS String	'			char(3)
Public 	cdUnitPrice	 AS String	'			char(3)
Public 	seUnitMaterial	 AS String	'			char(3)
Public 	cdUnitMaterial	 AS String	'			char(3)
Public 	seUnitPacking	 AS String	'			char(3)
Public 	cdUnitPacking	 AS String	'			char(3)
Public 	InchargeInbound	 AS String	'			char(8)
Public 	DateExchange	 AS String	'			char(8)
Public 	PriceExchange	 AS Double	'			decimal
Public 	PriceProduct	 AS Double	'			decimal
Public 	PriceProductEX	 AS Double	'			decimal
Public 	PriceProductVND	 AS Double	'			decimal
Public 	AmountProductEX	 AS Double	'			decimal
Public 	AmountProductVND	 AS Double	'			decimal
Public 	QtyProductInbound	 AS Double	'			decimal
Public 	QtyProductOutbound	 AS Double	'			decimal
Public 	QtyProductInboundL	 AS Double	'			decimal
Public 	QtyProductOutboundL	 AS Double	'			decimal
Public 	QtyProductInboundR	 AS Double	'			decimal
Public 	QtyProductOutboundR	 AS Double	'			decimal
Public 	ShoesCode	 AS String	'			char(6)
Public 	BatchNo	 AS String	'			char(10)
Public 	OrderNo	 AS String	'			char(9)
Public 	OrderNoSeq	 AS String	'			char(3)
Public 	FactOrderNo	 AS String	'			char(9)
Public 	FactOrderSeq	 AS Double	'			decimal
Public 	CheckComplete	 AS String	'			char(1)
Public 	IsPosted	 AS String	'			char(1)
Public 	DatePosted	 AS String	'			char(8)
Public 	DateInsert	 AS String	'			char(8)
Public 	DateUpdate	 AS String	'			char(8)
Public 	InchargeInsert	 AS String	'			char(8)
Public 	InchargeUpdate	 AS String	'			char(8)
Public 	Remark	 AS String	'			nvarchar(100)
'=========================================================================================================================================================
End structure

Public D2451 As T2451_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK2451(PRODUCTINBOUNDNO AS String, PRODUCTINBOUNDSEQ AS String) As Boolean
    READ_PFK2451 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK2451 "
    SQL = SQL & " WHERE K2451_ProductInboundNo		 = '" & ProductInboundNo & "' " 
    SQL = SQL & "   AND K2451_ProductInboundSeq		 = '" & ProductInboundSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D2451_CLEAR: GoTo SKIP_READ_PFK2451
                
    Call K2451_MOVE(rd)
    READ_PFK2451 = True

SKIP_READ_PFK2451:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK2451",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK2451(PRODUCTINBOUNDNO AS String, PRODUCTINBOUNDSEQ AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK2451 "
    SQL = SQL & " WHERE K2451_ProductInboundNo		 = '" & ProductInboundNo & "' " 
    SQL = SQL & "   AND K2451_ProductInboundSeq		 = '" & ProductInboundSeq & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK2451",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK2451(z2451 As T2451_AREA) As Boolean
    WRITE_PFK2451 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z2451)
 
    SQL = " INSERT INTO PFK2451 "
    SQL = SQL & " ( "
    SQL = SQL & " K2451_ProductInboundNo," 
    SQL = SQL & " K2451_ProductInboundSeq," 
    SQL = SQL & " K2451_CustomerCode," 
    SQL = SQL & " K2451_SupplierCode," 
    SQL = SQL & " K2451_Dseq," 
    SQL = SQL & " K2451_InvoiceNo," 
    SQL = SQL & " K2451_DateInbound," 
    SQL = SQL & " K2451_seFactory," 
    SQL = SQL & " K2451_cdFactory," 
    SQL = SQL & " K2451_seLineProd," 
    SQL = SQL & " K2451_cdLineProd," 
    SQL = SQL & " K2451_CheckProduct," 
    SQL = SQL & " K2451_CheckInBoundMaterial," 
    SQL = SQL & " K2451_CheckMaterialType," 
    SQL = SQL & " K2451_CheckMarketType," 
    SQL = SQL & " K2451_KindProduct," 
    SQL = SQL & " K2451_seUnitPrice," 
    SQL = SQL & " K2451_cdUnitPrice," 
    SQL = SQL & " K2451_seUnitMaterial," 
    SQL = SQL & " K2451_cdUnitMaterial," 
    SQL = SQL & " K2451_seUnitPacking," 
    SQL = SQL & " K2451_cdUnitPacking," 
    SQL = SQL & " K2451_InchargeInbound," 
    SQL = SQL & " K2451_DateExchange," 
    SQL = SQL & " K2451_PriceExchange," 
    SQL = SQL & " K2451_PriceProduct," 
    SQL = SQL & " K2451_PriceProductEX," 
    SQL = SQL & " K2451_PriceProductVND," 
    SQL = SQL & " K2451_AmountProductEX," 
    SQL = SQL & " K2451_AmountProductVND," 
    SQL = SQL & " K2451_QtyProductInbound," 
    SQL = SQL & " K2451_QtyProductOutbound," 
    SQL = SQL & " K2451_QtyProductInboundL," 
    SQL = SQL & " K2451_QtyProductOutboundL," 
    SQL = SQL & " K2451_QtyProductInboundR," 
    SQL = SQL & " K2451_QtyProductOutboundR," 
    SQL = SQL & " K2451_ShoesCode," 
    SQL = SQL & " K2451_BatchNo," 
    SQL = SQL & " K2451_OrderNo," 
    SQL = SQL & " K2451_OrderNoSeq," 
    SQL = SQL & " K2451_FactOrderNo," 
    SQL = SQL & " K2451_FactOrderSeq," 
    SQL = SQL & " K2451_CheckComplete," 
    SQL = SQL & " K2451_IsPosted," 
    SQL = SQL & " K2451_DatePosted," 
    SQL = SQL & " K2451_DateInsert," 
    SQL = SQL & " K2451_DateUpdate," 
    SQL = SQL & " K2451_InchargeInsert," 
    SQL = SQL & " K2451_InchargeUpdate," 
    SQL = SQL & " K2451_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z2451.ProductInboundNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2451.ProductInboundSeq) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2451.CustomerCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2451.SupplierCode) & "', "  
    SQL = SQL & "   " & FormatSQL(z2451.Dseq) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z2451.InvoiceNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2451.DateInbound) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2451.seFactory) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2451.cdFactory) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2451.seLineProd) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2451.cdLineProd) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2451.CheckProduct) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2451.CheckInBoundMaterial) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2451.CheckMaterialType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2451.CheckMarketType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2451.KindProduct) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2451.seUnitPrice) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2451.cdUnitPrice) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2451.seUnitMaterial) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2451.cdUnitMaterial) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2451.seUnitPacking) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2451.cdUnitPacking) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2451.InchargeInbound) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2451.DateExchange) & "', "  
    SQL = SQL & "   " & FormatSQL(z2451.PriceExchange) & ", "  
    SQL = SQL & "   " & FormatSQL(z2451.PriceProduct) & ", "  
    SQL = SQL & "   " & FormatSQL(z2451.PriceProductEX) & ", "  
    SQL = SQL & "   " & FormatSQL(z2451.PriceProductVND) & ", "  
    SQL = SQL & "   " & FormatSQL(z2451.AmountProductEX) & ", "  
    SQL = SQL & "   " & FormatSQL(z2451.AmountProductVND) & ", "  
    SQL = SQL & "   " & FormatSQL(z2451.QtyProductInbound) & ", "  
    SQL = SQL & "   " & FormatSQL(z2451.QtyProductOutbound) & ", "  
    SQL = SQL & "   " & FormatSQL(z2451.QtyProductInboundL) & ", "  
    SQL = SQL & "   " & FormatSQL(z2451.QtyProductOutboundL) & ", "  
    SQL = SQL & "   " & FormatSQL(z2451.QtyProductInboundR) & ", "  
    SQL = SQL & "   " & FormatSQL(z2451.QtyProductOutboundR) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z2451.ShoesCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2451.BatchNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2451.OrderNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2451.OrderNoSeq) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2451.FactOrderNo) & "', "  
    SQL = SQL & "   " & FormatSQL(z2451.FactOrderSeq) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z2451.CheckComplete) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2451.IsPosted) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2451.DatePosted) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2451.DateInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2451.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2451.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2451.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2451.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK2451 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK2451",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK2451(z2451 As T2451_AREA) As Boolean
    REWRITE_PFK2451 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z2451)
   
    SQL = " UPDATE PFK2451 SET "
    SQL = SQL & "    K2451_CustomerCode      = N'" & FormatSQL(z2451.CustomerCode) & "', " 
    SQL = SQL & "    K2451_SupplierCode      = N'" & FormatSQL(z2451.SupplierCode) & "', " 
    SQL = SQL & "    K2451_Dseq      =  " & FormatSQL(z2451.Dseq) & ", " 
    SQL = SQL & "    K2451_InvoiceNo      = N'" & FormatSQL(z2451.InvoiceNo) & "', " 
    SQL = SQL & "    K2451_DateInbound      = N'" & FormatSQL(z2451.DateInbound) & "', " 
    SQL = SQL & "    K2451_seFactory      = N'" & FormatSQL(z2451.seFactory) & "', " 
    SQL = SQL & "    K2451_cdFactory      = N'" & FormatSQL(z2451.cdFactory) & "', " 
    SQL = SQL & "    K2451_seLineProd      = N'" & FormatSQL(z2451.seLineProd) & "', " 
    SQL = SQL & "    K2451_cdLineProd      = N'" & FormatSQL(z2451.cdLineProd) & "', " 
    SQL = SQL & "    K2451_CheckProduct      = N'" & FormatSQL(z2451.CheckProduct) & "', " 
    SQL = SQL & "    K2451_CheckInBoundMaterial      = N'" & FormatSQL(z2451.CheckInBoundMaterial) & "', " 
    SQL = SQL & "    K2451_CheckMaterialType      = N'" & FormatSQL(z2451.CheckMaterialType) & "', " 
    SQL = SQL & "    K2451_CheckMarketType      = N'" & FormatSQL(z2451.CheckMarketType) & "', " 
    SQL = SQL & "    K2451_KindProduct      = N'" & FormatSQL(z2451.KindProduct) & "', " 
    SQL = SQL & "    K2451_seUnitPrice      = N'" & FormatSQL(z2451.seUnitPrice) & "', " 
    SQL = SQL & "    K2451_cdUnitPrice      = N'" & FormatSQL(z2451.cdUnitPrice) & "', " 
    SQL = SQL & "    K2451_seUnitMaterial      = N'" & FormatSQL(z2451.seUnitMaterial) & "', " 
    SQL = SQL & "    K2451_cdUnitMaterial      = N'" & FormatSQL(z2451.cdUnitMaterial) & "', " 
    SQL = SQL & "    K2451_seUnitPacking      = N'" & FormatSQL(z2451.seUnitPacking) & "', " 
    SQL = SQL & "    K2451_cdUnitPacking      = N'" & FormatSQL(z2451.cdUnitPacking) & "', " 
    SQL = SQL & "    K2451_InchargeInbound      = N'" & FormatSQL(z2451.InchargeInbound) & "', " 
    SQL = SQL & "    K2451_DateExchange      = N'" & FormatSQL(z2451.DateExchange) & "', " 
    SQL = SQL & "    K2451_PriceExchange      =  " & FormatSQL(z2451.PriceExchange) & ", " 
    SQL = SQL & "    K2451_PriceProduct      =  " & FormatSQL(z2451.PriceProduct) & ", " 
    SQL = SQL & "    K2451_PriceProductEX      =  " & FormatSQL(z2451.PriceProductEX) & ", " 
    SQL = SQL & "    K2451_PriceProductVND      =  " & FormatSQL(z2451.PriceProductVND) & ", " 
    SQL = SQL & "    K2451_AmountProductEX      =  " & FormatSQL(z2451.AmountProductEX) & ", " 
    SQL = SQL & "    K2451_AmountProductVND      =  " & FormatSQL(z2451.AmountProductVND) & ", " 
    SQL = SQL & "    K2451_QtyProductInbound      =  " & FormatSQL(z2451.QtyProductInbound) & ", " 
    SQL = SQL & "    K2451_QtyProductOutbound      =  " & FormatSQL(z2451.QtyProductOutbound) & ", " 
    SQL = SQL & "    K2451_QtyProductInboundL      =  " & FormatSQL(z2451.QtyProductInboundL) & ", " 
    SQL = SQL & "    K2451_QtyProductOutboundL      =  " & FormatSQL(z2451.QtyProductOutboundL) & ", " 
    SQL = SQL & "    K2451_QtyProductInboundR      =  " & FormatSQL(z2451.QtyProductInboundR) & ", " 
    SQL = SQL & "    K2451_QtyProductOutboundR      =  " & FormatSQL(z2451.QtyProductOutboundR) & ", " 
    SQL = SQL & "    K2451_ShoesCode      = N'" & FormatSQL(z2451.ShoesCode) & "', " 
    SQL = SQL & "    K2451_BatchNo      = N'" & FormatSQL(z2451.BatchNo) & "', " 
    SQL = SQL & "    K2451_OrderNo      = N'" & FormatSQL(z2451.OrderNo) & "', " 
    SQL = SQL & "    K2451_OrderNoSeq      = N'" & FormatSQL(z2451.OrderNoSeq) & "', " 
    SQL = SQL & "    K2451_FactOrderNo      = N'" & FormatSQL(z2451.FactOrderNo) & "', " 
    SQL = SQL & "    K2451_FactOrderSeq      =  " & FormatSQL(z2451.FactOrderSeq) & ", " 
    SQL = SQL & "    K2451_CheckComplete      = N'" & FormatSQL(z2451.CheckComplete) & "', " 
    SQL = SQL & "    K2451_IsPosted      = N'" & FormatSQL(z2451.IsPosted) & "', " 
    SQL = SQL & "    K2451_DatePosted      = N'" & FormatSQL(z2451.DatePosted) & "', " 
    SQL = SQL & "    K2451_DateInsert      = N'" & FormatSQL(z2451.DateInsert) & "', " 
    SQL = SQL & "    K2451_DateUpdate      = N'" & FormatSQL(z2451.DateUpdate) & "', " 
    SQL = SQL & "    K2451_InchargeInsert      = N'" & FormatSQL(z2451.InchargeInsert) & "', " 
    SQL = SQL & "    K2451_InchargeUpdate      = N'" & FormatSQL(z2451.InchargeUpdate) & "', " 
    SQL = SQL & "    K2451_Remark      = N'" & FormatSQL(z2451.Remark) & "'  " 
    SQL = SQL & " WHERE K2451_ProductInboundNo		 = '" & z2451.ProductInboundNo & "' " 
    SQL = SQL & "   AND K2451_ProductInboundSeq		 = '" & z2451.ProductInboundSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK2451 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK2451",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK2451(z2451 As T2451_AREA) As Boolean
    DELETE_PFK2451 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK2451 "
    SQL = SQL & " WHERE K2451_ProductInboundNo		 = '" & z2451.ProductInboundNo & "' " 
    SQL = SQL & "   AND K2451_ProductInboundSeq		 = '" & z2451.ProductInboundSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK2451 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK2451",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D2451_CLEAR()
Try
    
   D2451.ProductInboundNo = ""
   D2451.ProductInboundSeq = ""
   D2451.CustomerCode = ""
   D2451.SupplierCode = ""
    D2451.Dseq = 0 
   D2451.InvoiceNo = ""
   D2451.DateInbound = ""
   D2451.seFactory = ""
   D2451.cdFactory = ""
   D2451.seLineProd = ""
   D2451.cdLineProd = ""
   D2451.CheckProduct = ""
   D2451.CheckInBoundMaterial = ""
   D2451.CheckMaterialType = ""
   D2451.CheckMarketType = ""
   D2451.KindProduct = ""
   D2451.seUnitPrice = ""
   D2451.cdUnitPrice = ""
   D2451.seUnitMaterial = ""
   D2451.cdUnitMaterial = ""
   D2451.seUnitPacking = ""
   D2451.cdUnitPacking = ""
   D2451.InchargeInbound = ""
   D2451.DateExchange = ""
    D2451.PriceExchange = 0 
    D2451.PriceProduct = 0 
    D2451.PriceProductEX = 0 
    D2451.PriceProductVND = 0 
    D2451.AmountProductEX = 0 
    D2451.AmountProductVND = 0 
    D2451.QtyProductInbound = 0 
    D2451.QtyProductOutbound = 0 
    D2451.QtyProductInboundL = 0 
    D2451.QtyProductOutboundL = 0 
    D2451.QtyProductInboundR = 0 
    D2451.QtyProductOutboundR = 0 
   D2451.ShoesCode = ""
   D2451.BatchNo = ""
   D2451.OrderNo = ""
   D2451.OrderNoSeq = ""
   D2451.FactOrderNo = ""
    D2451.FactOrderSeq = 0 
   D2451.CheckComplete = ""
   D2451.IsPosted = ""
   D2451.DatePosted = ""
   D2451.DateInsert = ""
   D2451.DateUpdate = ""
   D2451.InchargeInsert = ""
   D2451.InchargeUpdate = ""
   D2451.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D2451_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x2451 As T2451_AREA)
Try
    
    x2451.ProductInboundNo = trim$(  x2451.ProductInboundNo)
    x2451.ProductInboundSeq = trim$(  x2451.ProductInboundSeq)
    x2451.CustomerCode = trim$(  x2451.CustomerCode)
    x2451.SupplierCode = trim$(  x2451.SupplierCode)
    x2451.Dseq = trim$(  x2451.Dseq)
    x2451.InvoiceNo = trim$(  x2451.InvoiceNo)
    x2451.DateInbound = trim$(  x2451.DateInbound)
    x2451.seFactory = trim$(  x2451.seFactory)
    x2451.cdFactory = trim$(  x2451.cdFactory)
    x2451.seLineProd = trim$(  x2451.seLineProd)
    x2451.cdLineProd = trim$(  x2451.cdLineProd)
    x2451.CheckProduct = trim$(  x2451.CheckProduct)
    x2451.CheckInBoundMaterial = trim$(  x2451.CheckInBoundMaterial)
    x2451.CheckMaterialType = trim$(  x2451.CheckMaterialType)
    x2451.CheckMarketType = trim$(  x2451.CheckMarketType)
    x2451.KindProduct = trim$(  x2451.KindProduct)
    x2451.seUnitPrice = trim$(  x2451.seUnitPrice)
    x2451.cdUnitPrice = trim$(  x2451.cdUnitPrice)
    x2451.seUnitMaterial = trim$(  x2451.seUnitMaterial)
    x2451.cdUnitMaterial = trim$(  x2451.cdUnitMaterial)
    x2451.seUnitPacking = trim$(  x2451.seUnitPacking)
    x2451.cdUnitPacking = trim$(  x2451.cdUnitPacking)
    x2451.InchargeInbound = trim$(  x2451.InchargeInbound)
    x2451.DateExchange = trim$(  x2451.DateExchange)
    x2451.PriceExchange = trim$(  x2451.PriceExchange)
    x2451.PriceProduct = trim$(  x2451.PriceProduct)
    x2451.PriceProductEX = trim$(  x2451.PriceProductEX)
    x2451.PriceProductVND = trim$(  x2451.PriceProductVND)
    x2451.AmountProductEX = trim$(  x2451.AmountProductEX)
    x2451.AmountProductVND = trim$(  x2451.AmountProductVND)
    x2451.QtyProductInbound = trim$(  x2451.QtyProductInbound)
    x2451.QtyProductOutbound = trim$(  x2451.QtyProductOutbound)
    x2451.QtyProductInboundL = trim$(  x2451.QtyProductInboundL)
    x2451.QtyProductOutboundL = trim$(  x2451.QtyProductOutboundL)
    x2451.QtyProductInboundR = trim$(  x2451.QtyProductInboundR)
    x2451.QtyProductOutboundR = trim$(  x2451.QtyProductOutboundR)
    x2451.ShoesCode = trim$(  x2451.ShoesCode)
    x2451.BatchNo = trim$(  x2451.BatchNo)
    x2451.OrderNo = trim$(  x2451.OrderNo)
    x2451.OrderNoSeq = trim$(  x2451.OrderNoSeq)
    x2451.FactOrderNo = trim$(  x2451.FactOrderNo)
    x2451.FactOrderSeq = trim$(  x2451.FactOrderSeq)
    x2451.CheckComplete = trim$(  x2451.CheckComplete)
    x2451.IsPosted = trim$(  x2451.IsPosted)
    x2451.DatePosted = trim$(  x2451.DatePosted)
    x2451.DateInsert = trim$(  x2451.DateInsert)
    x2451.DateUpdate = trim$(  x2451.DateUpdate)
    x2451.InchargeInsert = trim$(  x2451.InchargeInsert)
    x2451.InchargeUpdate = trim$(  x2451.InchargeUpdate)
    x2451.Remark = trim$(  x2451.Remark)
     
    If trim$( x2451.ProductInboundNo ) = "" Then x2451.ProductInboundNo = Space(1) 
    If trim$( x2451.ProductInboundSeq ) = "" Then x2451.ProductInboundSeq = Space(1) 
    If trim$( x2451.CustomerCode ) = "" Then x2451.CustomerCode = Space(1) 
    If trim$( x2451.SupplierCode ) = "" Then x2451.SupplierCode = Space(1) 
    If trim$( x2451.Dseq ) = "" Then x2451.Dseq = 0 
    If trim$( x2451.InvoiceNo ) = "" Then x2451.InvoiceNo = Space(1) 
    If trim$( x2451.DateInbound ) = "" Then x2451.DateInbound = Space(1) 
    If trim$( x2451.seFactory ) = "" Then x2451.seFactory = Space(1) 
    If trim$( x2451.cdFactory ) = "" Then x2451.cdFactory = Space(1) 
    If trim$( x2451.seLineProd ) = "" Then x2451.seLineProd = Space(1) 
    If trim$( x2451.cdLineProd ) = "" Then x2451.cdLineProd = Space(1) 
    If trim$( x2451.CheckProduct ) = "" Then x2451.CheckProduct = Space(1) 
    If trim$( x2451.CheckInBoundMaterial ) = "" Then x2451.CheckInBoundMaterial = Space(1) 
    If trim$( x2451.CheckMaterialType ) = "" Then x2451.CheckMaterialType = Space(1) 
    If trim$( x2451.CheckMarketType ) = "" Then x2451.CheckMarketType = Space(1) 
    If trim$( x2451.KindProduct ) = "" Then x2451.KindProduct = Space(1) 
    If trim$( x2451.seUnitPrice ) = "" Then x2451.seUnitPrice = Space(1) 
    If trim$( x2451.cdUnitPrice ) = "" Then x2451.cdUnitPrice = Space(1) 
    If trim$( x2451.seUnitMaterial ) = "" Then x2451.seUnitMaterial = Space(1) 
    If trim$( x2451.cdUnitMaterial ) = "" Then x2451.cdUnitMaterial = Space(1) 
    If trim$( x2451.seUnitPacking ) = "" Then x2451.seUnitPacking = Space(1) 
    If trim$( x2451.cdUnitPacking ) = "" Then x2451.cdUnitPacking = Space(1) 
    If trim$( x2451.InchargeInbound ) = "" Then x2451.InchargeInbound = Space(1) 
    If trim$( x2451.DateExchange ) = "" Then x2451.DateExchange = Space(1) 
    If trim$( x2451.PriceExchange ) = "" Then x2451.PriceExchange = 0 
    If trim$( x2451.PriceProduct ) = "" Then x2451.PriceProduct = 0 
    If trim$( x2451.PriceProductEX ) = "" Then x2451.PriceProductEX = 0 
    If trim$( x2451.PriceProductVND ) = "" Then x2451.PriceProductVND = 0 
    If trim$( x2451.AmountProductEX ) = "" Then x2451.AmountProductEX = 0 
    If trim$( x2451.AmountProductVND ) = "" Then x2451.AmountProductVND = 0 
    If trim$( x2451.QtyProductInbound ) = "" Then x2451.QtyProductInbound = 0 
    If trim$( x2451.QtyProductOutbound ) = "" Then x2451.QtyProductOutbound = 0 
    If trim$( x2451.QtyProductInboundL ) = "" Then x2451.QtyProductInboundL = 0 
    If trim$( x2451.QtyProductOutboundL ) = "" Then x2451.QtyProductOutboundL = 0 
    If trim$( x2451.QtyProductInboundR ) = "" Then x2451.QtyProductInboundR = 0 
    If trim$( x2451.QtyProductOutboundR ) = "" Then x2451.QtyProductOutboundR = 0 
    If trim$( x2451.ShoesCode ) = "" Then x2451.ShoesCode = Space(1) 
    If trim$( x2451.BatchNo ) = "" Then x2451.BatchNo = Space(1) 
    If trim$( x2451.OrderNo ) = "" Then x2451.OrderNo = Space(1) 
    If trim$( x2451.OrderNoSeq ) = "" Then x2451.OrderNoSeq = Space(1) 
    If trim$( x2451.FactOrderNo ) = "" Then x2451.FactOrderNo = Space(1) 
    If trim$( x2451.FactOrderSeq ) = "" Then x2451.FactOrderSeq = 0 
    If trim$( x2451.CheckComplete ) = "" Then x2451.CheckComplete = Space(1) 
    If trim$( x2451.IsPosted ) = "" Then x2451.IsPosted = Space(1) 
    If trim$( x2451.DatePosted ) = "" Then x2451.DatePosted = Space(1) 
    If trim$( x2451.DateInsert ) = "" Then x2451.DateInsert = Space(1) 
    If trim$( x2451.DateUpdate ) = "" Then x2451.DateUpdate = Space(1) 
    If trim$( x2451.InchargeInsert ) = "" Then x2451.InchargeInsert = Space(1) 
    If trim$( x2451.InchargeUpdate ) = "" Then x2451.InchargeUpdate = Space(1) 
    If trim$( x2451.Remark ) = "" Then x2451.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K2451_MOVE(rs2451 As SqlClient.SqlDataReader)
Try

    call D2451_CLEAR()   

    If IsdbNull(rs2451!K2451_ProductInboundNo) = False Then D2451.ProductInboundNo = Trim$(rs2451!K2451_ProductInboundNo)
    If IsdbNull(rs2451!K2451_ProductInboundSeq) = False Then D2451.ProductInboundSeq = Trim$(rs2451!K2451_ProductInboundSeq)
    If IsdbNull(rs2451!K2451_CustomerCode) = False Then D2451.CustomerCode = Trim$(rs2451!K2451_CustomerCode)
    If IsdbNull(rs2451!K2451_SupplierCode) = False Then D2451.SupplierCode = Trim$(rs2451!K2451_SupplierCode)
    If IsdbNull(rs2451!K2451_Dseq) = False Then D2451.Dseq = Trim$(rs2451!K2451_Dseq)
    If IsdbNull(rs2451!K2451_InvoiceNo) = False Then D2451.InvoiceNo = Trim$(rs2451!K2451_InvoiceNo)
    If IsdbNull(rs2451!K2451_DateInbound) = False Then D2451.DateInbound = Trim$(rs2451!K2451_DateInbound)
    If IsdbNull(rs2451!K2451_seFactory) = False Then D2451.seFactory = Trim$(rs2451!K2451_seFactory)
    If IsdbNull(rs2451!K2451_cdFactory) = False Then D2451.cdFactory = Trim$(rs2451!K2451_cdFactory)
    If IsdbNull(rs2451!K2451_seLineProd) = False Then D2451.seLineProd = Trim$(rs2451!K2451_seLineProd)
    If IsdbNull(rs2451!K2451_cdLineProd) = False Then D2451.cdLineProd = Trim$(rs2451!K2451_cdLineProd)
    If IsdbNull(rs2451!K2451_CheckProduct) = False Then D2451.CheckProduct = Trim$(rs2451!K2451_CheckProduct)
    If IsdbNull(rs2451!K2451_CheckInBoundMaterial) = False Then D2451.CheckInBoundMaterial = Trim$(rs2451!K2451_CheckInBoundMaterial)
    If IsdbNull(rs2451!K2451_CheckMaterialType) = False Then D2451.CheckMaterialType = Trim$(rs2451!K2451_CheckMaterialType)
    If IsdbNull(rs2451!K2451_CheckMarketType) = False Then D2451.CheckMarketType = Trim$(rs2451!K2451_CheckMarketType)
    If IsdbNull(rs2451!K2451_KindProduct) = False Then D2451.KindProduct = Trim$(rs2451!K2451_KindProduct)
    If IsdbNull(rs2451!K2451_seUnitPrice) = False Then D2451.seUnitPrice = Trim$(rs2451!K2451_seUnitPrice)
    If IsdbNull(rs2451!K2451_cdUnitPrice) = False Then D2451.cdUnitPrice = Trim$(rs2451!K2451_cdUnitPrice)
    If IsdbNull(rs2451!K2451_seUnitMaterial) = False Then D2451.seUnitMaterial = Trim$(rs2451!K2451_seUnitMaterial)
    If IsdbNull(rs2451!K2451_cdUnitMaterial) = False Then D2451.cdUnitMaterial = Trim$(rs2451!K2451_cdUnitMaterial)
    If IsdbNull(rs2451!K2451_seUnitPacking) = False Then D2451.seUnitPacking = Trim$(rs2451!K2451_seUnitPacking)
    If IsdbNull(rs2451!K2451_cdUnitPacking) = False Then D2451.cdUnitPacking = Trim$(rs2451!K2451_cdUnitPacking)
    If IsdbNull(rs2451!K2451_InchargeInbound) = False Then D2451.InchargeInbound = Trim$(rs2451!K2451_InchargeInbound)
    If IsdbNull(rs2451!K2451_DateExchange) = False Then D2451.DateExchange = Trim$(rs2451!K2451_DateExchange)
    If IsdbNull(rs2451!K2451_PriceExchange) = False Then D2451.PriceExchange = Trim$(rs2451!K2451_PriceExchange)
    If IsdbNull(rs2451!K2451_PriceProduct) = False Then D2451.PriceProduct = Trim$(rs2451!K2451_PriceProduct)
    If IsdbNull(rs2451!K2451_PriceProductEX) = False Then D2451.PriceProductEX = Trim$(rs2451!K2451_PriceProductEX)
    If IsdbNull(rs2451!K2451_PriceProductVND) = False Then D2451.PriceProductVND = Trim$(rs2451!K2451_PriceProductVND)
    If IsdbNull(rs2451!K2451_AmountProductEX) = False Then D2451.AmountProductEX = Trim$(rs2451!K2451_AmountProductEX)
    If IsdbNull(rs2451!K2451_AmountProductVND) = False Then D2451.AmountProductVND = Trim$(rs2451!K2451_AmountProductVND)
    If IsdbNull(rs2451!K2451_QtyProductInbound) = False Then D2451.QtyProductInbound = Trim$(rs2451!K2451_QtyProductInbound)
    If IsdbNull(rs2451!K2451_QtyProductOutbound) = False Then D2451.QtyProductOutbound = Trim$(rs2451!K2451_QtyProductOutbound)
    If IsdbNull(rs2451!K2451_QtyProductInboundL) = False Then D2451.QtyProductInboundL = Trim$(rs2451!K2451_QtyProductInboundL)
    If IsdbNull(rs2451!K2451_QtyProductOutboundL) = False Then D2451.QtyProductOutboundL = Trim$(rs2451!K2451_QtyProductOutboundL)
    If IsdbNull(rs2451!K2451_QtyProductInboundR) = False Then D2451.QtyProductInboundR = Trim$(rs2451!K2451_QtyProductInboundR)
    If IsdbNull(rs2451!K2451_QtyProductOutboundR) = False Then D2451.QtyProductOutboundR = Trim$(rs2451!K2451_QtyProductOutboundR)
    If IsdbNull(rs2451!K2451_ShoesCode) = False Then D2451.ShoesCode = Trim$(rs2451!K2451_ShoesCode)
    If IsdbNull(rs2451!K2451_BatchNo) = False Then D2451.BatchNo = Trim$(rs2451!K2451_BatchNo)
    If IsdbNull(rs2451!K2451_OrderNo) = False Then D2451.OrderNo = Trim$(rs2451!K2451_OrderNo)
    If IsdbNull(rs2451!K2451_OrderNoSeq) = False Then D2451.OrderNoSeq = Trim$(rs2451!K2451_OrderNoSeq)
    If IsdbNull(rs2451!K2451_FactOrderNo) = False Then D2451.FactOrderNo = Trim$(rs2451!K2451_FactOrderNo)
    If IsdbNull(rs2451!K2451_FactOrderSeq) = False Then D2451.FactOrderSeq = Trim$(rs2451!K2451_FactOrderSeq)
    If IsdbNull(rs2451!K2451_CheckComplete) = False Then D2451.CheckComplete = Trim$(rs2451!K2451_CheckComplete)
    If IsdbNull(rs2451!K2451_IsPosted) = False Then D2451.IsPosted = Trim$(rs2451!K2451_IsPosted)
    If IsdbNull(rs2451!K2451_DatePosted) = False Then D2451.DatePosted = Trim$(rs2451!K2451_DatePosted)
    If IsdbNull(rs2451!K2451_DateInsert) = False Then D2451.DateInsert = Trim$(rs2451!K2451_DateInsert)
    If IsdbNull(rs2451!K2451_DateUpdate) = False Then D2451.DateUpdate = Trim$(rs2451!K2451_DateUpdate)
    If IsdbNull(rs2451!K2451_InchargeInsert) = False Then D2451.InchargeInsert = Trim$(rs2451!K2451_InchargeInsert)
    If IsdbNull(rs2451!K2451_InchargeUpdate) = False Then D2451.InchargeUpdate = Trim$(rs2451!K2451_InchargeUpdate)
    If IsdbNull(rs2451!K2451_Remark) = False Then D2451.Remark = Trim$(rs2451!K2451_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K2451_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K2451_MOVE(rs2451 As DataRow)
Try

    call D2451_CLEAR()   

    If IsdbNull(rs2451!K2451_ProductInboundNo) = False Then D2451.ProductInboundNo = Trim$(rs2451!K2451_ProductInboundNo)
    If IsdbNull(rs2451!K2451_ProductInboundSeq) = False Then D2451.ProductInboundSeq = Trim$(rs2451!K2451_ProductInboundSeq)
    If IsdbNull(rs2451!K2451_CustomerCode) = False Then D2451.CustomerCode = Trim$(rs2451!K2451_CustomerCode)
    If IsdbNull(rs2451!K2451_SupplierCode) = False Then D2451.SupplierCode = Trim$(rs2451!K2451_SupplierCode)
    If IsdbNull(rs2451!K2451_Dseq) = False Then D2451.Dseq = Trim$(rs2451!K2451_Dseq)
    If IsdbNull(rs2451!K2451_InvoiceNo) = False Then D2451.InvoiceNo = Trim$(rs2451!K2451_InvoiceNo)
    If IsdbNull(rs2451!K2451_DateInbound) = False Then D2451.DateInbound = Trim$(rs2451!K2451_DateInbound)
    If IsdbNull(rs2451!K2451_seFactory) = False Then D2451.seFactory = Trim$(rs2451!K2451_seFactory)
    If IsdbNull(rs2451!K2451_cdFactory) = False Then D2451.cdFactory = Trim$(rs2451!K2451_cdFactory)
    If IsdbNull(rs2451!K2451_seLineProd) = False Then D2451.seLineProd = Trim$(rs2451!K2451_seLineProd)
    If IsdbNull(rs2451!K2451_cdLineProd) = False Then D2451.cdLineProd = Trim$(rs2451!K2451_cdLineProd)
    If IsdbNull(rs2451!K2451_CheckProduct) = False Then D2451.CheckProduct = Trim$(rs2451!K2451_CheckProduct)
    If IsdbNull(rs2451!K2451_CheckInBoundMaterial) = False Then D2451.CheckInBoundMaterial = Trim$(rs2451!K2451_CheckInBoundMaterial)
    If IsdbNull(rs2451!K2451_CheckMaterialType) = False Then D2451.CheckMaterialType = Trim$(rs2451!K2451_CheckMaterialType)
    If IsdbNull(rs2451!K2451_CheckMarketType) = False Then D2451.CheckMarketType = Trim$(rs2451!K2451_CheckMarketType)
    If IsdbNull(rs2451!K2451_KindProduct) = False Then D2451.KindProduct = Trim$(rs2451!K2451_KindProduct)
    If IsdbNull(rs2451!K2451_seUnitPrice) = False Then D2451.seUnitPrice = Trim$(rs2451!K2451_seUnitPrice)
    If IsdbNull(rs2451!K2451_cdUnitPrice) = False Then D2451.cdUnitPrice = Trim$(rs2451!K2451_cdUnitPrice)
    If IsdbNull(rs2451!K2451_seUnitMaterial) = False Then D2451.seUnitMaterial = Trim$(rs2451!K2451_seUnitMaterial)
    If IsdbNull(rs2451!K2451_cdUnitMaterial) = False Then D2451.cdUnitMaterial = Trim$(rs2451!K2451_cdUnitMaterial)
    If IsdbNull(rs2451!K2451_seUnitPacking) = False Then D2451.seUnitPacking = Trim$(rs2451!K2451_seUnitPacking)
    If IsdbNull(rs2451!K2451_cdUnitPacking) = False Then D2451.cdUnitPacking = Trim$(rs2451!K2451_cdUnitPacking)
    If IsdbNull(rs2451!K2451_InchargeInbound) = False Then D2451.InchargeInbound = Trim$(rs2451!K2451_InchargeInbound)
    If IsdbNull(rs2451!K2451_DateExchange) = False Then D2451.DateExchange = Trim$(rs2451!K2451_DateExchange)
    If IsdbNull(rs2451!K2451_PriceExchange) = False Then D2451.PriceExchange = Trim$(rs2451!K2451_PriceExchange)
    If IsdbNull(rs2451!K2451_PriceProduct) = False Then D2451.PriceProduct = Trim$(rs2451!K2451_PriceProduct)
    If IsdbNull(rs2451!K2451_PriceProductEX) = False Then D2451.PriceProductEX = Trim$(rs2451!K2451_PriceProductEX)
    If IsdbNull(rs2451!K2451_PriceProductVND) = False Then D2451.PriceProductVND = Trim$(rs2451!K2451_PriceProductVND)
    If IsdbNull(rs2451!K2451_AmountProductEX) = False Then D2451.AmountProductEX = Trim$(rs2451!K2451_AmountProductEX)
    If IsdbNull(rs2451!K2451_AmountProductVND) = False Then D2451.AmountProductVND = Trim$(rs2451!K2451_AmountProductVND)
    If IsdbNull(rs2451!K2451_QtyProductInbound) = False Then D2451.QtyProductInbound = Trim$(rs2451!K2451_QtyProductInbound)
    If IsdbNull(rs2451!K2451_QtyProductOutbound) = False Then D2451.QtyProductOutbound = Trim$(rs2451!K2451_QtyProductOutbound)
    If IsdbNull(rs2451!K2451_QtyProductInboundL) = False Then D2451.QtyProductInboundL = Trim$(rs2451!K2451_QtyProductInboundL)
    If IsdbNull(rs2451!K2451_QtyProductOutboundL) = False Then D2451.QtyProductOutboundL = Trim$(rs2451!K2451_QtyProductOutboundL)
    If IsdbNull(rs2451!K2451_QtyProductInboundR) = False Then D2451.QtyProductInboundR = Trim$(rs2451!K2451_QtyProductInboundR)
    If IsdbNull(rs2451!K2451_QtyProductOutboundR) = False Then D2451.QtyProductOutboundR = Trim$(rs2451!K2451_QtyProductOutboundR)
    If IsdbNull(rs2451!K2451_ShoesCode) = False Then D2451.ShoesCode = Trim$(rs2451!K2451_ShoesCode)
    If IsdbNull(rs2451!K2451_BatchNo) = False Then D2451.BatchNo = Trim$(rs2451!K2451_BatchNo)
    If IsdbNull(rs2451!K2451_OrderNo) = False Then D2451.OrderNo = Trim$(rs2451!K2451_OrderNo)
    If IsdbNull(rs2451!K2451_OrderNoSeq) = False Then D2451.OrderNoSeq = Trim$(rs2451!K2451_OrderNoSeq)
    If IsdbNull(rs2451!K2451_FactOrderNo) = False Then D2451.FactOrderNo = Trim$(rs2451!K2451_FactOrderNo)
    If IsdbNull(rs2451!K2451_FactOrderSeq) = False Then D2451.FactOrderSeq = Trim$(rs2451!K2451_FactOrderSeq)
    If IsdbNull(rs2451!K2451_CheckComplete) = False Then D2451.CheckComplete = Trim$(rs2451!K2451_CheckComplete)
    If IsdbNull(rs2451!K2451_IsPosted) = False Then D2451.IsPosted = Trim$(rs2451!K2451_IsPosted)
    If IsdbNull(rs2451!K2451_DatePosted) = False Then D2451.DatePosted = Trim$(rs2451!K2451_DatePosted)
    If IsdbNull(rs2451!K2451_DateInsert) = False Then D2451.DateInsert = Trim$(rs2451!K2451_DateInsert)
    If IsdbNull(rs2451!K2451_DateUpdate) = False Then D2451.DateUpdate = Trim$(rs2451!K2451_DateUpdate)
    If IsdbNull(rs2451!K2451_InchargeInsert) = False Then D2451.InchargeInsert = Trim$(rs2451!K2451_InchargeInsert)
    If IsdbNull(rs2451!K2451_InchargeUpdate) = False Then D2451.InchargeUpdate = Trim$(rs2451!K2451_InchargeUpdate)
    If IsdbNull(rs2451!K2451_Remark) = False Then D2451.Remark = Trim$(rs2451!K2451_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K2451_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K2451_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z2451 As T2451_AREA, PRODUCTINBOUNDNO AS String, PRODUCTINBOUNDSEQ AS String) as Boolean

K2451_MOVE = False

Try
    If READ_PFK2451(PRODUCTINBOUNDNO, PRODUCTINBOUNDSEQ) = True Then
                z2451 = D2451
		K2451_MOVE = True
		else
	z2451 = nothing
     End If

     If  getColumIndex(spr,"ProductInboundNo") > -1 then z2451.ProductInboundNo = getDataM(spr, getColumIndex(spr,"ProductInboundNo"), xRow)
     If  getColumIndex(spr,"ProductInboundSeq") > -1 then z2451.ProductInboundSeq = getDataM(spr, getColumIndex(spr,"ProductInboundSeq"), xRow)
     If  getColumIndex(spr,"CustomerCode") > -1 then z2451.CustomerCode = getDataM(spr, getColumIndex(spr,"CustomerCode"), xRow)
     If  getColumIndex(spr,"SupplierCode") > -1 then z2451.SupplierCode = getDataM(spr, getColumIndex(spr,"SupplierCode"), xRow)
     If  getColumIndex(spr,"Dseq") > -1 then z2451.Dseq = getDataM(spr, getColumIndex(spr,"Dseq"), xRow)
     If  getColumIndex(spr,"InvoiceNo") > -1 then z2451.InvoiceNo = getDataM(spr, getColumIndex(spr,"InvoiceNo"), xRow)
     If  getColumIndex(spr,"DateInbound") > -1 then z2451.DateInbound = getDataM(spr, getColumIndex(spr,"DateInbound"), xRow)
     If  getColumIndex(spr,"seFactory") > -1 then z2451.seFactory = getDataM(spr, getColumIndex(spr,"seFactory"), xRow)
     If  getColumIndex(spr,"cdFactory") > -1 then z2451.cdFactory = getDataM(spr, getColumIndex(spr,"cdFactory"), xRow)
     If  getColumIndex(spr,"seLineProd") > -1 then z2451.seLineProd = getDataM(spr, getColumIndex(spr,"seLineProd"), xRow)
     If  getColumIndex(spr,"cdLineProd") > -1 then z2451.cdLineProd = getDataM(spr, getColumIndex(spr,"cdLineProd"), xRow)
     If  getColumIndex(spr,"CheckProduct") > -1 then z2451.CheckProduct = getDataM(spr, getColumIndex(spr,"CheckProduct"), xRow)
     If  getColumIndex(spr,"CheckInBoundMaterial") > -1 then z2451.CheckInBoundMaterial = getDataM(spr, getColumIndex(spr,"CheckInBoundMaterial"), xRow)
     If  getColumIndex(spr,"CheckMaterialType") > -1 then z2451.CheckMaterialType = getDataM(spr, getColumIndex(spr,"CheckMaterialType"), xRow)
     If  getColumIndex(spr,"CheckMarketType") > -1 then z2451.CheckMarketType = getDataM(spr, getColumIndex(spr,"CheckMarketType"), xRow)
     If  getColumIndex(spr,"KindProduct") > -1 then z2451.KindProduct = getDataM(spr, getColumIndex(spr,"KindProduct"), xRow)
     If  getColumIndex(spr,"seUnitPrice") > -1 then z2451.seUnitPrice = getDataM(spr, getColumIndex(spr,"seUnitPrice"), xRow)
     If  getColumIndex(spr,"cdUnitPrice") > -1 then z2451.cdUnitPrice = getDataM(spr, getColumIndex(spr,"cdUnitPrice"), xRow)
     If  getColumIndex(spr,"seUnitMaterial") > -1 then z2451.seUnitMaterial = getDataM(spr, getColumIndex(spr,"seUnitMaterial"), xRow)
     If  getColumIndex(spr,"cdUnitMaterial") > -1 then z2451.cdUnitMaterial = getDataM(spr, getColumIndex(spr,"cdUnitMaterial"), xRow)
     If  getColumIndex(spr,"seUnitPacking") > -1 then z2451.seUnitPacking = getDataM(spr, getColumIndex(spr,"seUnitPacking"), xRow)
     If  getColumIndex(spr,"cdUnitPacking") > -1 then z2451.cdUnitPacking = getDataM(spr, getColumIndex(spr,"cdUnitPacking"), xRow)
     If  getColumIndex(spr,"InchargeInbound") > -1 then z2451.InchargeInbound = getDataM(spr, getColumIndex(spr,"InchargeInbound"), xRow)
     If  getColumIndex(spr,"DateExchange") > -1 then z2451.DateExchange = getDataM(spr, getColumIndex(spr,"DateExchange"), xRow)
     If  getColumIndex(spr,"PriceExchange") > -1 then z2451.PriceExchange = getDataM(spr, getColumIndex(spr,"PriceExchange"), xRow)
     If  getColumIndex(spr,"PriceProduct") > -1 then z2451.PriceProduct = getDataM(spr, getColumIndex(spr,"PriceProduct"), xRow)
     If  getColumIndex(spr,"PriceProductEX") > -1 then z2451.PriceProductEX = getDataM(spr, getColumIndex(spr,"PriceProductEX"), xRow)
     If  getColumIndex(spr,"PriceProductVND") > -1 then z2451.PriceProductVND = getDataM(spr, getColumIndex(spr,"PriceProductVND"), xRow)
     If  getColumIndex(spr,"AmountProductEX") > -1 then z2451.AmountProductEX = getDataM(spr, getColumIndex(spr,"AmountProductEX"), xRow)
     If  getColumIndex(spr,"AmountProductVND") > -1 then z2451.AmountProductVND = getDataM(spr, getColumIndex(spr,"AmountProductVND"), xRow)
     If  getColumIndex(spr,"QtyProductInbound") > -1 then z2451.QtyProductInbound = getDataM(spr, getColumIndex(spr,"QtyProductInbound"), xRow)
     If  getColumIndex(spr,"QtyProductOutbound") > -1 then z2451.QtyProductOutbound = getDataM(spr, getColumIndex(spr,"QtyProductOutbound"), xRow)
     If  getColumIndex(spr,"QtyProductInboundL") > -1 then z2451.QtyProductInboundL = getDataM(spr, getColumIndex(spr,"QtyProductInboundL"), xRow)
     If  getColumIndex(spr,"QtyProductOutboundL") > -1 then z2451.QtyProductOutboundL = getDataM(spr, getColumIndex(spr,"QtyProductOutboundL"), xRow)
     If  getColumIndex(spr,"QtyProductInboundR") > -1 then z2451.QtyProductInboundR = getDataM(spr, getColumIndex(spr,"QtyProductInboundR"), xRow)
     If  getColumIndex(spr,"QtyProductOutboundR") > -1 then z2451.QtyProductOutboundR = getDataM(spr, getColumIndex(spr,"QtyProductOutboundR"), xRow)
     If  getColumIndex(spr,"ShoesCode") > -1 then z2451.ShoesCode = getDataM(spr, getColumIndex(spr,"ShoesCode"), xRow)
     If  getColumIndex(spr,"BatchNo") > -1 then z2451.BatchNo = getDataM(spr, getColumIndex(spr,"BatchNo"), xRow)
     If  getColumIndex(spr,"OrderNo") > -1 then z2451.OrderNo = getDataM(spr, getColumIndex(spr,"OrderNo"), xRow)
     If  getColumIndex(spr,"OrderNoSeq") > -1 then z2451.OrderNoSeq = getDataM(spr, getColumIndex(spr,"OrderNoSeq"), xRow)
     If  getColumIndex(spr,"FactOrderNo") > -1 then z2451.FactOrderNo = getDataM(spr, getColumIndex(spr,"FactOrderNo"), xRow)
     If  getColumIndex(spr,"FactOrderSeq") > -1 then z2451.FactOrderSeq = getDataM(spr, getColumIndex(spr,"FactOrderSeq"), xRow)
     If  getColumIndex(spr,"CheckComplete") > -1 then z2451.CheckComplete = getDataM(spr, getColumIndex(spr,"CheckComplete"), xRow)
     If  getColumIndex(spr,"IsPosted") > -1 then z2451.IsPosted = getDataM(spr, getColumIndex(spr,"IsPosted"), xRow)
     If  getColumIndex(spr,"DatePosted") > -1 then z2451.DatePosted = getDataM(spr, getColumIndex(spr,"DatePosted"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z2451.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z2451.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z2451.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z2451.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z2451.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K2451_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K2451_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z2451 As T2451_AREA,CheckClear as Boolean,PRODUCTINBOUNDNO AS String, PRODUCTINBOUNDSEQ AS String) as Boolean

K2451_MOVE = False

Try
    If READ_PFK2451(PRODUCTINBOUNDNO, PRODUCTINBOUNDSEQ) = True Then
                z2451 = D2451
		K2451_MOVE = True
		else
	If CheckClear  = True then z2451 = nothing
     End If

     If  getColumIndex(spr,"ProductInboundNo") > -1 then z2451.ProductInboundNo = getDataM(spr, getColumIndex(spr,"ProductInboundNo"), xRow)
     If  getColumIndex(spr,"ProductInboundSeq") > -1 then z2451.ProductInboundSeq = getDataM(spr, getColumIndex(spr,"ProductInboundSeq"), xRow)
     If  getColumIndex(spr,"CustomerCode") > -1 then z2451.CustomerCode = getDataM(spr, getColumIndex(spr,"CustomerCode"), xRow)
     If  getColumIndex(spr,"SupplierCode") > -1 then z2451.SupplierCode = getDataM(spr, getColumIndex(spr,"SupplierCode"), xRow)
     If  getColumIndex(spr,"Dseq") > -1 then z2451.Dseq = getDataM(spr, getColumIndex(spr,"Dseq"), xRow)
     If  getColumIndex(spr,"InvoiceNo") > -1 then z2451.InvoiceNo = getDataM(spr, getColumIndex(spr,"InvoiceNo"), xRow)
     If  getColumIndex(spr,"DateInbound") > -1 then z2451.DateInbound = getDataM(spr, getColumIndex(spr,"DateInbound"), xRow)
     If  getColumIndex(spr,"seFactory") > -1 then z2451.seFactory = getDataM(spr, getColumIndex(spr,"seFactory"), xRow)
     If  getColumIndex(spr,"cdFactory") > -1 then z2451.cdFactory = getDataM(spr, getColumIndex(spr,"cdFactory"), xRow)
     If  getColumIndex(spr,"seLineProd") > -1 then z2451.seLineProd = getDataM(spr, getColumIndex(spr,"seLineProd"), xRow)
     If  getColumIndex(spr,"cdLineProd") > -1 then z2451.cdLineProd = getDataM(spr, getColumIndex(spr,"cdLineProd"), xRow)
     If  getColumIndex(spr,"CheckProduct") > -1 then z2451.CheckProduct = getDataM(spr, getColumIndex(spr,"CheckProduct"), xRow)
     If  getColumIndex(spr,"CheckInBoundMaterial") > -1 then z2451.CheckInBoundMaterial = getDataM(spr, getColumIndex(spr,"CheckInBoundMaterial"), xRow)
     If  getColumIndex(spr,"CheckMaterialType") > -1 then z2451.CheckMaterialType = getDataM(spr, getColumIndex(spr,"CheckMaterialType"), xRow)
     If  getColumIndex(spr,"CheckMarketType") > -1 then z2451.CheckMarketType = getDataM(spr, getColumIndex(spr,"CheckMarketType"), xRow)
     If  getColumIndex(spr,"KindProduct") > -1 then z2451.KindProduct = getDataM(spr, getColumIndex(spr,"KindProduct"), xRow)
     If  getColumIndex(spr,"seUnitPrice") > -1 then z2451.seUnitPrice = getDataM(spr, getColumIndex(spr,"seUnitPrice"), xRow)
     If  getColumIndex(spr,"cdUnitPrice") > -1 then z2451.cdUnitPrice = getDataM(spr, getColumIndex(spr,"cdUnitPrice"), xRow)
     If  getColumIndex(spr,"seUnitMaterial") > -1 then z2451.seUnitMaterial = getDataM(spr, getColumIndex(spr,"seUnitMaterial"), xRow)
     If  getColumIndex(spr,"cdUnitMaterial") > -1 then z2451.cdUnitMaterial = getDataM(spr, getColumIndex(spr,"cdUnitMaterial"), xRow)
     If  getColumIndex(spr,"seUnitPacking") > -1 then z2451.seUnitPacking = getDataM(spr, getColumIndex(spr,"seUnitPacking"), xRow)
     If  getColumIndex(spr,"cdUnitPacking") > -1 then z2451.cdUnitPacking = getDataM(spr, getColumIndex(spr,"cdUnitPacking"), xRow)
     If  getColumIndex(spr,"InchargeInbound") > -1 then z2451.InchargeInbound = getDataM(spr, getColumIndex(spr,"InchargeInbound"), xRow)
     If  getColumIndex(spr,"DateExchange") > -1 then z2451.DateExchange = getDataM(spr, getColumIndex(spr,"DateExchange"), xRow)
     If  getColumIndex(spr,"PriceExchange") > -1 then z2451.PriceExchange = getDataM(spr, getColumIndex(spr,"PriceExchange"), xRow)
     If  getColumIndex(spr,"PriceProduct") > -1 then z2451.PriceProduct = getDataM(spr, getColumIndex(spr,"PriceProduct"), xRow)
     If  getColumIndex(spr,"PriceProductEX") > -1 then z2451.PriceProductEX = getDataM(spr, getColumIndex(spr,"PriceProductEX"), xRow)
     If  getColumIndex(spr,"PriceProductVND") > -1 then z2451.PriceProductVND = getDataM(spr, getColumIndex(spr,"PriceProductVND"), xRow)
     If  getColumIndex(spr,"AmountProductEX") > -1 then z2451.AmountProductEX = getDataM(spr, getColumIndex(spr,"AmountProductEX"), xRow)
     If  getColumIndex(spr,"AmountProductVND") > -1 then z2451.AmountProductVND = getDataM(spr, getColumIndex(spr,"AmountProductVND"), xRow)
     If  getColumIndex(spr,"QtyProductInbound") > -1 then z2451.QtyProductInbound = getDataM(spr, getColumIndex(spr,"QtyProductInbound"), xRow)
     If  getColumIndex(spr,"QtyProductOutbound") > -1 then z2451.QtyProductOutbound = getDataM(spr, getColumIndex(spr,"QtyProductOutbound"), xRow)
     If  getColumIndex(spr,"QtyProductInboundL") > -1 then z2451.QtyProductInboundL = getDataM(spr, getColumIndex(spr,"QtyProductInboundL"), xRow)
     If  getColumIndex(spr,"QtyProductOutboundL") > -1 then z2451.QtyProductOutboundL = getDataM(spr, getColumIndex(spr,"QtyProductOutboundL"), xRow)
     If  getColumIndex(spr,"QtyProductInboundR") > -1 then z2451.QtyProductInboundR = getDataM(spr, getColumIndex(spr,"QtyProductInboundR"), xRow)
     If  getColumIndex(spr,"QtyProductOutboundR") > -1 then z2451.QtyProductOutboundR = getDataM(spr, getColumIndex(spr,"QtyProductOutboundR"), xRow)
     If  getColumIndex(spr,"ShoesCode") > -1 then z2451.ShoesCode = getDataM(spr, getColumIndex(spr,"ShoesCode"), xRow)
     If  getColumIndex(spr,"BatchNo") > -1 then z2451.BatchNo = getDataM(spr, getColumIndex(spr,"BatchNo"), xRow)
     If  getColumIndex(spr,"OrderNo") > -1 then z2451.OrderNo = getDataM(spr, getColumIndex(spr,"OrderNo"), xRow)
     If  getColumIndex(spr,"OrderNoSeq") > -1 then z2451.OrderNoSeq = getDataM(spr, getColumIndex(spr,"OrderNoSeq"), xRow)
     If  getColumIndex(spr,"FactOrderNo") > -1 then z2451.FactOrderNo = getDataM(spr, getColumIndex(spr,"FactOrderNo"), xRow)
     If  getColumIndex(spr,"FactOrderSeq") > -1 then z2451.FactOrderSeq = getDataM(spr, getColumIndex(spr,"FactOrderSeq"), xRow)
     If  getColumIndex(spr,"CheckComplete") > -1 then z2451.CheckComplete = getDataM(spr, getColumIndex(spr,"CheckComplete"), xRow)
     If  getColumIndex(spr,"IsPosted") > -1 then z2451.IsPosted = getDataM(spr, getColumIndex(spr,"IsPosted"), xRow)
     If  getColumIndex(spr,"DatePosted") > -1 then z2451.DatePosted = getDataM(spr, getColumIndex(spr,"DatePosted"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z2451.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z2451.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z2451.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z2451.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z2451.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K2451_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K2451_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z2451 As T2451_AREA, Job as String, PRODUCTINBOUNDNO AS String, PRODUCTINBOUNDSEQ AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K2451_MOVE = False

Try
    If READ_PFK2451(PRODUCTINBOUNDNO, PRODUCTINBOUNDSEQ) = True Then
                z2451 = D2451
		K2451_MOVE = True
		else
	z2451 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK2451")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "PRODUCTINBOUNDNO":z2451.ProductInboundNo = Children(i).Code
   Case "PRODUCTINBOUNDSEQ":z2451.ProductInboundSeq = Children(i).Code
   Case "CUSTOMERCODE":z2451.CustomerCode = Children(i).Code
   Case "SUPPLIERCODE":z2451.SupplierCode = Children(i).Code
   Case "DSEQ":z2451.Dseq = Children(i).Code
   Case "INVOICENO":z2451.InvoiceNo = Children(i).Code
   Case "DATEINBOUND":z2451.DateInbound = Children(i).Code
   Case "SEFACTORY":z2451.seFactory = Children(i).Code
   Case "CDFACTORY":z2451.cdFactory = Children(i).Code
   Case "SELINEPROD":z2451.seLineProd = Children(i).Code
   Case "CDLINEPROD":z2451.cdLineProd = Children(i).Code
   Case "CHECKPRODUCT":z2451.CheckProduct = Children(i).Code
   Case "CHECKINBOUNDMATERIAL":z2451.CheckInBoundMaterial = Children(i).Code
   Case "CHECKMATERIALTYPE":z2451.CheckMaterialType = Children(i).Code
   Case "CHECKMARKETTYPE":z2451.CheckMarketType = Children(i).Code
   Case "KINDPRODUCT":z2451.KindProduct = Children(i).Code
   Case "SEUNITPRICE":z2451.seUnitPrice = Children(i).Code
   Case "CDUNITPRICE":z2451.cdUnitPrice = Children(i).Code
   Case "SEUNITMATERIAL":z2451.seUnitMaterial = Children(i).Code
   Case "CDUNITMATERIAL":z2451.cdUnitMaterial = Children(i).Code
   Case "SEUNITPACKING":z2451.seUnitPacking = Children(i).Code
   Case "CDUNITPACKING":z2451.cdUnitPacking = Children(i).Code
   Case "INCHARGEINBOUND":z2451.InchargeInbound = Children(i).Code
   Case "DATEEXCHANGE":z2451.DateExchange = Children(i).Code
   Case "PRICEEXCHANGE":z2451.PriceExchange = Children(i).Code
   Case "PRICEPRODUCT":z2451.PriceProduct = Children(i).Code
   Case "PRICEPRODUCTEX":z2451.PriceProductEX = Children(i).Code
   Case "PRICEPRODUCTVND":z2451.PriceProductVND = Children(i).Code
   Case "AMOUNTPRODUCTEX":z2451.AmountProductEX = Children(i).Code
   Case "AMOUNTPRODUCTVND":z2451.AmountProductVND = Children(i).Code
   Case "QTYPRODUCTINBOUND":z2451.QtyProductInbound = Children(i).Code
   Case "QTYPRODUCTOUTBOUND":z2451.QtyProductOutbound = Children(i).Code
   Case "QTYPRODUCTINBOUNDL":z2451.QtyProductInboundL = Children(i).Code
   Case "QTYPRODUCTOUTBOUNDL":z2451.QtyProductOutboundL = Children(i).Code
   Case "QTYPRODUCTINBOUNDR":z2451.QtyProductInboundR = Children(i).Code
   Case "QTYPRODUCTOUTBOUNDR":z2451.QtyProductOutboundR = Children(i).Code
   Case "SHOESCODE":z2451.ShoesCode = Children(i).Code
   Case "BATCHNO":z2451.BatchNo = Children(i).Code
   Case "ORDERNO":z2451.OrderNo = Children(i).Code
   Case "ORDERNOSEQ":z2451.OrderNoSeq = Children(i).Code
   Case "FACTORDERNO":z2451.FactOrderNo = Children(i).Code
   Case "FACTORDERSEQ":z2451.FactOrderSeq = Children(i).Code
   Case "CHECKCOMPLETE":z2451.CheckComplete = Children(i).Code
   Case "ISPOSTED":z2451.IsPosted = Children(i).Code
   Case "DATEPOSTED":z2451.DatePosted = Children(i).Code
   Case "DATEINSERT":z2451.DateInsert = Children(i).Code
   Case "DATEUPDATE":z2451.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z2451.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z2451.InchargeUpdate = Children(i).Code
   Case "REMARK":z2451.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "PRODUCTINBOUNDNO":z2451.ProductInboundNo = Children(i).Data
   Case "PRODUCTINBOUNDSEQ":z2451.ProductInboundSeq = Children(i).Data
   Case "CUSTOMERCODE":z2451.CustomerCode = Children(i).Data
   Case "SUPPLIERCODE":z2451.SupplierCode = Children(i).Data
   Case "DSEQ":z2451.Dseq = Children(i).Data
   Case "INVOICENO":z2451.InvoiceNo = Children(i).Data
   Case "DATEINBOUND":z2451.DateInbound = Children(i).Data
   Case "SEFACTORY":z2451.seFactory = Children(i).Data
   Case "CDFACTORY":z2451.cdFactory = Children(i).Data
   Case "SELINEPROD":z2451.seLineProd = Children(i).Data
   Case "CDLINEPROD":z2451.cdLineProd = Children(i).Data
   Case "CHECKPRODUCT":z2451.CheckProduct = Children(i).Data
   Case "CHECKINBOUNDMATERIAL":z2451.CheckInBoundMaterial = Children(i).Data
   Case "CHECKMATERIALTYPE":z2451.CheckMaterialType = Children(i).Data
   Case "CHECKMARKETTYPE":z2451.CheckMarketType = Children(i).Data
   Case "KINDPRODUCT":z2451.KindProduct = Children(i).Data
   Case "SEUNITPRICE":z2451.seUnitPrice = Children(i).Data
   Case "CDUNITPRICE":z2451.cdUnitPrice = Children(i).Data
   Case "SEUNITMATERIAL":z2451.seUnitMaterial = Children(i).Data
   Case "CDUNITMATERIAL":z2451.cdUnitMaterial = Children(i).Data
   Case "SEUNITPACKING":z2451.seUnitPacking = Children(i).Data
   Case "CDUNITPACKING":z2451.cdUnitPacking = Children(i).Data
   Case "INCHARGEINBOUND":z2451.InchargeInbound = Children(i).Data
   Case "DATEEXCHANGE":z2451.DateExchange = Children(i).Data
   Case "PRICEEXCHANGE":z2451.PriceExchange = Children(i).Data
   Case "PRICEPRODUCT":z2451.PriceProduct = Children(i).Data
   Case "PRICEPRODUCTEX":z2451.PriceProductEX = Children(i).Data
   Case "PRICEPRODUCTVND":z2451.PriceProductVND = Children(i).Data
   Case "AMOUNTPRODUCTEX":z2451.AmountProductEX = Children(i).Data
   Case "AMOUNTPRODUCTVND":z2451.AmountProductVND = Children(i).Data
   Case "QTYPRODUCTINBOUND":z2451.QtyProductInbound = Children(i).Data
   Case "QTYPRODUCTOUTBOUND":z2451.QtyProductOutbound = Children(i).Data
   Case "QTYPRODUCTINBOUNDL":z2451.QtyProductInboundL = Children(i).Data
   Case "QTYPRODUCTOUTBOUNDL":z2451.QtyProductOutboundL = Children(i).Data
   Case "QTYPRODUCTINBOUNDR":z2451.QtyProductInboundR = Children(i).Data
   Case "QTYPRODUCTOUTBOUNDR":z2451.QtyProductOutboundR = Children(i).Data
   Case "SHOESCODE":z2451.ShoesCode = Children(i).Data
   Case "BATCHNO":z2451.BatchNo = Children(i).Data
   Case "ORDERNO":z2451.OrderNo = Children(i).Data
   Case "ORDERNOSEQ":z2451.OrderNoSeq = Children(i).Data
   Case "FACTORDERNO":z2451.FactOrderNo = Children(i).Data
   Case "FACTORDERSEQ":z2451.FactOrderSeq = Children(i).Data
   Case "CHECKCOMPLETE":z2451.CheckComplete = Children(i).Data
   Case "ISPOSTED":z2451.IsPosted = Children(i).Data
   Case "DATEPOSTED":z2451.DatePosted = Children(i).Data
   Case "DATEINSERT":z2451.DateInsert = Children(i).Data
   Case "DATEUPDATE":z2451.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z2451.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z2451.InchargeUpdate = Children(i).Data
   Case "REMARK":z2451.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K2451_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K2451_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z2451 As T2451_AREA, Job as String, CheckClear as Boolean, PRODUCTINBOUNDNO AS String, PRODUCTINBOUNDSEQ AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K2451_MOVE = False

Try
    If READ_PFK2451(PRODUCTINBOUNDNO, PRODUCTINBOUNDSEQ) = True Then
                z2451 = D2451
		K2451_MOVE = True
		else
	If CheckClear  = True then z2451 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK2451")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "PRODUCTINBOUNDNO":z2451.ProductInboundNo = Children(i).Code
   Case "PRODUCTINBOUNDSEQ":z2451.ProductInboundSeq = Children(i).Code
   Case "CUSTOMERCODE":z2451.CustomerCode = Children(i).Code
   Case "SUPPLIERCODE":z2451.SupplierCode = Children(i).Code
   Case "DSEQ":z2451.Dseq = Children(i).Code
   Case "INVOICENO":z2451.InvoiceNo = Children(i).Code
   Case "DATEINBOUND":z2451.DateInbound = Children(i).Code
   Case "SEFACTORY":z2451.seFactory = Children(i).Code
   Case "CDFACTORY":z2451.cdFactory = Children(i).Code
   Case "SELINEPROD":z2451.seLineProd = Children(i).Code
   Case "CDLINEPROD":z2451.cdLineProd = Children(i).Code
   Case "CHECKPRODUCT":z2451.CheckProduct = Children(i).Code
   Case "CHECKINBOUNDMATERIAL":z2451.CheckInBoundMaterial = Children(i).Code
   Case "CHECKMATERIALTYPE":z2451.CheckMaterialType = Children(i).Code
   Case "CHECKMARKETTYPE":z2451.CheckMarketType = Children(i).Code
   Case "KINDPRODUCT":z2451.KindProduct = Children(i).Code
   Case "SEUNITPRICE":z2451.seUnitPrice = Children(i).Code
   Case "CDUNITPRICE":z2451.cdUnitPrice = Children(i).Code
   Case "SEUNITMATERIAL":z2451.seUnitMaterial = Children(i).Code
   Case "CDUNITMATERIAL":z2451.cdUnitMaterial = Children(i).Code
   Case "SEUNITPACKING":z2451.seUnitPacking = Children(i).Code
   Case "CDUNITPACKING":z2451.cdUnitPacking = Children(i).Code
   Case "INCHARGEINBOUND":z2451.InchargeInbound = Children(i).Code
   Case "DATEEXCHANGE":z2451.DateExchange = Children(i).Code
   Case "PRICEEXCHANGE":z2451.PriceExchange = Children(i).Code
   Case "PRICEPRODUCT":z2451.PriceProduct = Children(i).Code
   Case "PRICEPRODUCTEX":z2451.PriceProductEX = Children(i).Code
   Case "PRICEPRODUCTVND":z2451.PriceProductVND = Children(i).Code
   Case "AMOUNTPRODUCTEX":z2451.AmountProductEX = Children(i).Code
   Case "AMOUNTPRODUCTVND":z2451.AmountProductVND = Children(i).Code
   Case "QTYPRODUCTINBOUND":z2451.QtyProductInbound = Children(i).Code
   Case "QTYPRODUCTOUTBOUND":z2451.QtyProductOutbound = Children(i).Code
   Case "QTYPRODUCTINBOUNDL":z2451.QtyProductInboundL = Children(i).Code
   Case "QTYPRODUCTOUTBOUNDL":z2451.QtyProductOutboundL = Children(i).Code
   Case "QTYPRODUCTINBOUNDR":z2451.QtyProductInboundR = Children(i).Code
   Case "QTYPRODUCTOUTBOUNDR":z2451.QtyProductOutboundR = Children(i).Code
   Case "SHOESCODE":z2451.ShoesCode = Children(i).Code
   Case "BATCHNO":z2451.BatchNo = Children(i).Code
   Case "ORDERNO":z2451.OrderNo = Children(i).Code
   Case "ORDERNOSEQ":z2451.OrderNoSeq = Children(i).Code
   Case "FACTORDERNO":z2451.FactOrderNo = Children(i).Code
   Case "FACTORDERSEQ":z2451.FactOrderSeq = Children(i).Code
   Case "CHECKCOMPLETE":z2451.CheckComplete = Children(i).Code
   Case "ISPOSTED":z2451.IsPosted = Children(i).Code
   Case "DATEPOSTED":z2451.DatePosted = Children(i).Code
   Case "DATEINSERT":z2451.DateInsert = Children(i).Code
   Case "DATEUPDATE":z2451.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z2451.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z2451.InchargeUpdate = Children(i).Code
   Case "REMARK":z2451.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "PRODUCTINBOUNDNO":z2451.ProductInboundNo = Children(i).Data
   Case "PRODUCTINBOUNDSEQ":z2451.ProductInboundSeq = Children(i).Data
   Case "CUSTOMERCODE":z2451.CustomerCode = Children(i).Data
   Case "SUPPLIERCODE":z2451.SupplierCode = Children(i).Data
   Case "DSEQ":z2451.Dseq = Children(i).Data
   Case "INVOICENO":z2451.InvoiceNo = Children(i).Data
   Case "DATEINBOUND":z2451.DateInbound = Children(i).Data
   Case "SEFACTORY":z2451.seFactory = Children(i).Data
   Case "CDFACTORY":z2451.cdFactory = Children(i).Data
   Case "SELINEPROD":z2451.seLineProd = Children(i).Data
   Case "CDLINEPROD":z2451.cdLineProd = Children(i).Data
   Case "CHECKPRODUCT":z2451.CheckProduct = Children(i).Data
   Case "CHECKINBOUNDMATERIAL":z2451.CheckInBoundMaterial = Children(i).Data
   Case "CHECKMATERIALTYPE":z2451.CheckMaterialType = Children(i).Data
   Case "CHECKMARKETTYPE":z2451.CheckMarketType = Children(i).Data
   Case "KINDPRODUCT":z2451.KindProduct = Children(i).Data
   Case "SEUNITPRICE":z2451.seUnitPrice = Children(i).Data
   Case "CDUNITPRICE":z2451.cdUnitPrice = Children(i).Data
   Case "SEUNITMATERIAL":z2451.seUnitMaterial = Children(i).Data
   Case "CDUNITMATERIAL":z2451.cdUnitMaterial = Children(i).Data
   Case "SEUNITPACKING":z2451.seUnitPacking = Children(i).Data
   Case "CDUNITPACKING":z2451.cdUnitPacking = Children(i).Data
   Case "INCHARGEINBOUND":z2451.InchargeInbound = Children(i).Data
   Case "DATEEXCHANGE":z2451.DateExchange = Children(i).Data
   Case "PRICEEXCHANGE":z2451.PriceExchange = Children(i).Data
   Case "PRICEPRODUCT":z2451.PriceProduct = Children(i).Data
   Case "PRICEPRODUCTEX":z2451.PriceProductEX = Children(i).Data
   Case "PRICEPRODUCTVND":z2451.PriceProductVND = Children(i).Data
   Case "AMOUNTPRODUCTEX":z2451.AmountProductEX = Children(i).Data
   Case "AMOUNTPRODUCTVND":z2451.AmountProductVND = Children(i).Data
   Case "QTYPRODUCTINBOUND":z2451.QtyProductInbound = Children(i).Data
   Case "QTYPRODUCTOUTBOUND":z2451.QtyProductOutbound = Children(i).Data
   Case "QTYPRODUCTINBOUNDL":z2451.QtyProductInboundL = Children(i).Data
   Case "QTYPRODUCTOUTBOUNDL":z2451.QtyProductOutboundL = Children(i).Data
   Case "QTYPRODUCTINBOUNDR":z2451.QtyProductInboundR = Children(i).Data
   Case "QTYPRODUCTOUTBOUNDR":z2451.QtyProductOutboundR = Children(i).Data
   Case "SHOESCODE":z2451.ShoesCode = Children(i).Data
   Case "BATCHNO":z2451.BatchNo = Children(i).Data
   Case "ORDERNO":z2451.OrderNo = Children(i).Data
   Case "ORDERNOSEQ":z2451.OrderNoSeq = Children(i).Data
   Case "FACTORDERNO":z2451.FactOrderNo = Children(i).Data
   Case "FACTORDERSEQ":z2451.FactOrderSeq = Children(i).Data
   Case "CHECKCOMPLETE":z2451.CheckComplete = Children(i).Data
   Case "ISPOSTED":z2451.IsPosted = Children(i).Data
   Case "DATEPOSTED":z2451.DatePosted = Children(i).Data
   Case "DATEINSERT":z2451.DateInsert = Children(i).Data
   Case "DATEUPDATE":z2451.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z2451.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z2451.InchargeUpdate = Children(i).Data
   Case "REMARK":z2451.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K2451_MOVE",vbCritical)
End Try
End Function 
    
End Module 
