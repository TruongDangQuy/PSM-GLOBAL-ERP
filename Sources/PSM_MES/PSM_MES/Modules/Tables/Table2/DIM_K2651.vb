'=========================================================================================================================================================
'   TABLE : (PFK2651)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K2651

Structure T2651_AREA
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
Public 	BarcodeInnerBox	 AS String	'			nvarchar(50)
Public 	BarcodePacking	 AS String	'			nvarchar(50)
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
Public 	STimeProduction	 AS String	'			nvarchar(20)
Public 	Remark	 AS String	'			nvarchar(100)
'=========================================================================================================================================================
End structure

Public D2651 As T2651_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK2651(PRODUCTINBOUNDNO AS String, PRODUCTINBOUNDSEQ AS String) As Boolean
    READ_PFK2651 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK2651 "
    SQL = SQL & " WHERE K2651_ProductInboundNo		 = '" & ProductInboundNo & "' " 
    SQL = SQL & "   AND K2651_ProductInboundSeq		 = '" & ProductInboundSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D2651_CLEAR: GoTo SKIP_READ_PFK2651
                
    Call K2651_MOVE(rd)
    READ_PFK2651 = True

SKIP_READ_PFK2651:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK2651",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK2651(PRODUCTINBOUNDNO AS String, PRODUCTINBOUNDSEQ AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK2651 "
    SQL = SQL & " WHERE K2651_ProductInboundNo		 = '" & ProductInboundNo & "' " 
    SQL = SQL & "   AND K2651_ProductInboundSeq		 = '" & ProductInboundSeq & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK2651",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK2651(z2651 As T2651_AREA) As Boolean
    WRITE_PFK2651 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z2651)
 
    SQL = " INSERT INTO PFK2651 "
    SQL = SQL & " ( "
    SQL = SQL & " K2651_ProductInboundNo," 
    SQL = SQL & " K2651_ProductInboundSeq," 
    SQL = SQL & " K2651_CustomerCode," 
    SQL = SQL & " K2651_SupplierCode," 
    SQL = SQL & " K2651_Dseq," 
    SQL = SQL & " K2651_InvoiceNo," 
    SQL = SQL & " K2651_DateInbound," 
    SQL = SQL & " K2651_seFactory," 
    SQL = SQL & " K2651_cdFactory," 
    SQL = SQL & " K2651_seLineProd," 
    SQL = SQL & " K2651_cdLineProd," 
    SQL = SQL & " K2651_CheckProduct," 
    SQL = SQL & " K2651_CheckInBoundMaterial," 
    SQL = SQL & " K2651_CheckMaterialType," 
    SQL = SQL & " K2651_CheckMarketType," 
    SQL = SQL & " K2651_KindProduct," 
    SQL = SQL & " K2651_seUnitPrice," 
    SQL = SQL & " K2651_cdUnitPrice," 
    SQL = SQL & " K2651_seUnitMaterial," 
    SQL = SQL & " K2651_cdUnitMaterial," 
    SQL = SQL & " K2651_seUnitPacking," 
    SQL = SQL & " K2651_cdUnitPacking," 
    SQL = SQL & " K2651_InchargeInbound," 
    SQL = SQL & " K2651_DateExchange," 
    SQL = SQL & " K2651_PriceExchange," 
    SQL = SQL & " K2651_PriceProduct," 
    SQL = SQL & " K2651_PriceProductEX," 
    SQL = SQL & " K2651_PriceProductVND," 
    SQL = SQL & " K2651_AmountProductEX," 
    SQL = SQL & " K2651_AmountProductVND," 
    SQL = SQL & " K2651_QtyProductInbound," 
    SQL = SQL & " K2651_QtyProductOutbound," 
    SQL = SQL & " K2651_QtyProductInboundL," 
    SQL = SQL & " K2651_QtyProductOutboundL," 
    SQL = SQL & " K2651_QtyProductInboundR," 
    SQL = SQL & " K2651_QtyProductOutboundR," 
    SQL = SQL & " K2651_ShoesCode," 
    SQL = SQL & " K2651_BatchNo," 
    SQL = SQL & " K2651_BarcodeInnerBox," 
    SQL = SQL & " K2651_BarcodePacking," 
    SQL = SQL & " K2651_OrderNo," 
    SQL = SQL & " K2651_OrderNoSeq," 
    SQL = SQL & " K2651_FactOrderNo," 
    SQL = SQL & " K2651_FactOrderSeq," 
    SQL = SQL & " K2651_CheckComplete," 
    SQL = SQL & " K2651_IsPosted," 
    SQL = SQL & " K2651_DatePosted," 
    SQL = SQL & " K2651_DateInsert," 
    SQL = SQL & " K2651_DateUpdate," 
    SQL = SQL & " K2651_InchargeInsert," 
    SQL = SQL & " K2651_InchargeUpdate," 
    SQL = SQL & " K2651_STimeProduction," 
    SQL = SQL & " K2651_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z2651.ProductInboundNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2651.ProductInboundSeq) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2651.CustomerCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2651.SupplierCode) & "', "  
    SQL = SQL & "   " & FormatSQL(z2651.Dseq) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z2651.InvoiceNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2651.DateInbound) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2651.seFactory) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2651.cdFactory) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2651.seLineProd) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2651.cdLineProd) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2651.CheckProduct) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2651.CheckInBoundMaterial) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2651.CheckMaterialType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2651.CheckMarketType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2651.KindProduct) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2651.seUnitPrice) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2651.cdUnitPrice) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2651.seUnitMaterial) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2651.cdUnitMaterial) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2651.seUnitPacking) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2651.cdUnitPacking) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2651.InchargeInbound) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2651.DateExchange) & "', "  
    SQL = SQL & "   " & FormatSQL(z2651.PriceExchange) & ", "  
    SQL = SQL & "   " & FormatSQL(z2651.PriceProduct) & ", "  
    SQL = SQL & "   " & FormatSQL(z2651.PriceProductEX) & ", "  
    SQL = SQL & "   " & FormatSQL(z2651.PriceProductVND) & ", "  
    SQL = SQL & "   " & FormatSQL(z2651.AmountProductEX) & ", "  
    SQL = SQL & "   " & FormatSQL(z2651.AmountProductVND) & ", "  
    SQL = SQL & "   " & FormatSQL(z2651.QtyProductInbound) & ", "  
    SQL = SQL & "   " & FormatSQL(z2651.QtyProductOutbound) & ", "  
    SQL = SQL & "   " & FormatSQL(z2651.QtyProductInboundL) & ", "  
    SQL = SQL & "   " & FormatSQL(z2651.QtyProductOutboundL) & ", "  
    SQL = SQL & "   " & FormatSQL(z2651.QtyProductInboundR) & ", "  
    SQL = SQL & "   " & FormatSQL(z2651.QtyProductOutboundR) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z2651.ShoesCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2651.BatchNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2651.BarcodeInnerBox) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2651.BarcodePacking) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2651.OrderNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2651.OrderNoSeq) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2651.FactOrderNo) & "', "  
    SQL = SQL & "   " & FormatSQL(z2651.FactOrderSeq) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z2651.CheckComplete) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2651.IsPosted) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2651.DatePosted) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2651.DateInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2651.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2651.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2651.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2651.STimeProduction) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2651.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK2651 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK2651",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK2651(z2651 As T2651_AREA) As Boolean
    REWRITE_PFK2651 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z2651)
   
    SQL = " UPDATE PFK2651 SET "
    SQL = SQL & "    K2651_CustomerCode      = N'" & FormatSQL(z2651.CustomerCode) & "', " 
    SQL = SQL & "    K2651_SupplierCode      = N'" & FormatSQL(z2651.SupplierCode) & "', " 
    SQL = SQL & "    K2651_Dseq      =  " & FormatSQL(z2651.Dseq) & ", " 
    SQL = SQL & "    K2651_InvoiceNo      = N'" & FormatSQL(z2651.InvoiceNo) & "', " 
    SQL = SQL & "    K2651_DateInbound      = N'" & FormatSQL(z2651.DateInbound) & "', " 
    SQL = SQL & "    K2651_seFactory      = N'" & FormatSQL(z2651.seFactory) & "', " 
    SQL = SQL & "    K2651_cdFactory      = N'" & FormatSQL(z2651.cdFactory) & "', " 
    SQL = SQL & "    K2651_seLineProd      = N'" & FormatSQL(z2651.seLineProd) & "', " 
    SQL = SQL & "    K2651_cdLineProd      = N'" & FormatSQL(z2651.cdLineProd) & "', " 
    SQL = SQL & "    K2651_CheckProduct      = N'" & FormatSQL(z2651.CheckProduct) & "', " 
    SQL = SQL & "    K2651_CheckInBoundMaterial      = N'" & FormatSQL(z2651.CheckInBoundMaterial) & "', " 
    SQL = SQL & "    K2651_CheckMaterialType      = N'" & FormatSQL(z2651.CheckMaterialType) & "', " 
    SQL = SQL & "    K2651_CheckMarketType      = N'" & FormatSQL(z2651.CheckMarketType) & "', " 
    SQL = SQL & "    K2651_KindProduct      = N'" & FormatSQL(z2651.KindProduct) & "', " 
    SQL = SQL & "    K2651_seUnitPrice      = N'" & FormatSQL(z2651.seUnitPrice) & "', " 
    SQL = SQL & "    K2651_cdUnitPrice      = N'" & FormatSQL(z2651.cdUnitPrice) & "', " 
    SQL = SQL & "    K2651_seUnitMaterial      = N'" & FormatSQL(z2651.seUnitMaterial) & "', " 
    SQL = SQL & "    K2651_cdUnitMaterial      = N'" & FormatSQL(z2651.cdUnitMaterial) & "', " 
    SQL = SQL & "    K2651_seUnitPacking      = N'" & FormatSQL(z2651.seUnitPacking) & "', " 
    SQL = SQL & "    K2651_cdUnitPacking      = N'" & FormatSQL(z2651.cdUnitPacking) & "', " 
    SQL = SQL & "    K2651_InchargeInbound      = N'" & FormatSQL(z2651.InchargeInbound) & "', " 
    SQL = SQL & "    K2651_DateExchange      = N'" & FormatSQL(z2651.DateExchange) & "', " 
    SQL = SQL & "    K2651_PriceExchange      =  " & FormatSQL(z2651.PriceExchange) & ", " 
    SQL = SQL & "    K2651_PriceProduct      =  " & FormatSQL(z2651.PriceProduct) & ", " 
    SQL = SQL & "    K2651_PriceProductEX      =  " & FormatSQL(z2651.PriceProductEX) & ", " 
    SQL = SQL & "    K2651_PriceProductVND      =  " & FormatSQL(z2651.PriceProductVND) & ", " 
    SQL = SQL & "    K2651_AmountProductEX      =  " & FormatSQL(z2651.AmountProductEX) & ", " 
    SQL = SQL & "    K2651_AmountProductVND      =  " & FormatSQL(z2651.AmountProductVND) & ", " 
    SQL = SQL & "    K2651_QtyProductInbound      =  " & FormatSQL(z2651.QtyProductInbound) & ", " 
    SQL = SQL & "    K2651_QtyProductOutbound      =  " & FormatSQL(z2651.QtyProductOutbound) & ", " 
    SQL = SQL & "    K2651_QtyProductInboundL      =  " & FormatSQL(z2651.QtyProductInboundL) & ", " 
    SQL = SQL & "    K2651_QtyProductOutboundL      =  " & FormatSQL(z2651.QtyProductOutboundL) & ", " 
    SQL = SQL & "    K2651_QtyProductInboundR      =  " & FormatSQL(z2651.QtyProductInboundR) & ", " 
    SQL = SQL & "    K2651_QtyProductOutboundR      =  " & FormatSQL(z2651.QtyProductOutboundR) & ", " 
    SQL = SQL & "    K2651_ShoesCode      = N'" & FormatSQL(z2651.ShoesCode) & "', " 
    SQL = SQL & "    K2651_BatchNo      = N'" & FormatSQL(z2651.BatchNo) & "', " 
    SQL = SQL & "    K2651_BarcodeInnerBox      = N'" & FormatSQL(z2651.BarcodeInnerBox) & "', " 
    SQL = SQL & "    K2651_BarcodePacking      = N'" & FormatSQL(z2651.BarcodePacking) & "', " 
    SQL = SQL & "    K2651_OrderNo      = N'" & FormatSQL(z2651.OrderNo) & "', " 
    SQL = SQL & "    K2651_OrderNoSeq      = N'" & FormatSQL(z2651.OrderNoSeq) & "', " 
    SQL = SQL & "    K2651_FactOrderNo      = N'" & FormatSQL(z2651.FactOrderNo) & "', " 
    SQL = SQL & "    K2651_FactOrderSeq      =  " & FormatSQL(z2651.FactOrderSeq) & ", " 
    SQL = SQL & "    K2651_CheckComplete      = N'" & FormatSQL(z2651.CheckComplete) & "', " 
    SQL = SQL & "    K2651_IsPosted      = N'" & FormatSQL(z2651.IsPosted) & "', " 
    SQL = SQL & "    K2651_DatePosted      = N'" & FormatSQL(z2651.DatePosted) & "', " 
    SQL = SQL & "    K2651_DateInsert      = N'" & FormatSQL(z2651.DateInsert) & "', " 
    SQL = SQL & "    K2651_DateUpdate      = N'" & FormatSQL(z2651.DateUpdate) & "', " 
    SQL = SQL & "    K2651_InchargeInsert      = N'" & FormatSQL(z2651.InchargeInsert) & "', " 
    SQL = SQL & "    K2651_InchargeUpdate      = N'" & FormatSQL(z2651.InchargeUpdate) & "', " 
    SQL = SQL & "    K2651_STimeProduction      = N'" & FormatSQL(z2651.STimeProduction) & "', " 
    SQL = SQL & "    K2651_Remark      = N'" & FormatSQL(z2651.Remark) & "'  " 
    SQL = SQL & " WHERE K2651_ProductInboundNo		 = '" & z2651.ProductInboundNo & "' " 
    SQL = SQL & "   AND K2651_ProductInboundSeq		 = '" & z2651.ProductInboundSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK2651 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK2651",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK2651(z2651 As T2651_AREA) As Boolean
    DELETE_PFK2651 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK2651 "
    SQL = SQL & " WHERE K2651_ProductInboundNo		 = '" & z2651.ProductInboundNo & "' " 
    SQL = SQL & "   AND K2651_ProductInboundSeq		 = '" & z2651.ProductInboundSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK2651 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK2651",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D2651_CLEAR()
Try
    
   D2651.ProductInboundNo = ""
   D2651.ProductInboundSeq = ""
   D2651.CustomerCode = ""
   D2651.SupplierCode = ""
    D2651.Dseq = 0 
   D2651.InvoiceNo = ""
   D2651.DateInbound = ""
   D2651.seFactory = ""
   D2651.cdFactory = ""
   D2651.seLineProd = ""
   D2651.cdLineProd = ""
   D2651.CheckProduct = ""
   D2651.CheckInBoundMaterial = ""
   D2651.CheckMaterialType = ""
   D2651.CheckMarketType = ""
   D2651.KindProduct = ""
   D2651.seUnitPrice = ""
   D2651.cdUnitPrice = ""
   D2651.seUnitMaterial = ""
   D2651.cdUnitMaterial = ""
   D2651.seUnitPacking = ""
   D2651.cdUnitPacking = ""
   D2651.InchargeInbound = ""
   D2651.DateExchange = ""
    D2651.PriceExchange = 0 
    D2651.PriceProduct = 0 
    D2651.PriceProductEX = 0 
    D2651.PriceProductVND = 0 
    D2651.AmountProductEX = 0 
    D2651.AmountProductVND = 0 
    D2651.QtyProductInbound = 0 
    D2651.QtyProductOutbound = 0 
    D2651.QtyProductInboundL = 0 
    D2651.QtyProductOutboundL = 0 
    D2651.QtyProductInboundR = 0 
    D2651.QtyProductOutboundR = 0 
   D2651.ShoesCode = ""
   D2651.BatchNo = ""
   D2651.BarcodeInnerBox = ""
   D2651.BarcodePacking = ""
   D2651.OrderNo = ""
   D2651.OrderNoSeq = ""
   D2651.FactOrderNo = ""
    D2651.FactOrderSeq = 0 
   D2651.CheckComplete = ""
   D2651.IsPosted = ""
   D2651.DatePosted = ""
   D2651.DateInsert = ""
   D2651.DateUpdate = ""
   D2651.InchargeInsert = ""
   D2651.InchargeUpdate = ""
   D2651.STimeProduction = ""
   D2651.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D2651_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x2651 As T2651_AREA)
Try
    
    x2651.ProductInboundNo = trim$(  x2651.ProductInboundNo)
    x2651.ProductInboundSeq = trim$(  x2651.ProductInboundSeq)
    x2651.CustomerCode = trim$(  x2651.CustomerCode)
    x2651.SupplierCode = trim$(  x2651.SupplierCode)
    x2651.Dseq = trim$(  x2651.Dseq)
    x2651.InvoiceNo = trim$(  x2651.InvoiceNo)
    x2651.DateInbound = trim$(  x2651.DateInbound)
    x2651.seFactory = trim$(  x2651.seFactory)
    x2651.cdFactory = trim$(  x2651.cdFactory)
    x2651.seLineProd = trim$(  x2651.seLineProd)
    x2651.cdLineProd = trim$(  x2651.cdLineProd)
    x2651.CheckProduct = trim$(  x2651.CheckProduct)
    x2651.CheckInBoundMaterial = trim$(  x2651.CheckInBoundMaterial)
    x2651.CheckMaterialType = trim$(  x2651.CheckMaterialType)
    x2651.CheckMarketType = trim$(  x2651.CheckMarketType)
    x2651.KindProduct = trim$(  x2651.KindProduct)
    x2651.seUnitPrice = trim$(  x2651.seUnitPrice)
    x2651.cdUnitPrice = trim$(  x2651.cdUnitPrice)
    x2651.seUnitMaterial = trim$(  x2651.seUnitMaterial)
    x2651.cdUnitMaterial = trim$(  x2651.cdUnitMaterial)
    x2651.seUnitPacking = trim$(  x2651.seUnitPacking)
    x2651.cdUnitPacking = trim$(  x2651.cdUnitPacking)
    x2651.InchargeInbound = trim$(  x2651.InchargeInbound)
    x2651.DateExchange = trim$(  x2651.DateExchange)
    x2651.PriceExchange = trim$(  x2651.PriceExchange)
    x2651.PriceProduct = trim$(  x2651.PriceProduct)
    x2651.PriceProductEX = trim$(  x2651.PriceProductEX)
    x2651.PriceProductVND = trim$(  x2651.PriceProductVND)
    x2651.AmountProductEX = trim$(  x2651.AmountProductEX)
    x2651.AmountProductVND = trim$(  x2651.AmountProductVND)
    x2651.QtyProductInbound = trim$(  x2651.QtyProductInbound)
    x2651.QtyProductOutbound = trim$(  x2651.QtyProductOutbound)
    x2651.QtyProductInboundL = trim$(  x2651.QtyProductInboundL)
    x2651.QtyProductOutboundL = trim$(  x2651.QtyProductOutboundL)
    x2651.QtyProductInboundR = trim$(  x2651.QtyProductInboundR)
    x2651.QtyProductOutboundR = trim$(  x2651.QtyProductOutboundR)
    x2651.ShoesCode = trim$(  x2651.ShoesCode)
    x2651.BatchNo = trim$(  x2651.BatchNo)
    x2651.BarcodeInnerBox = trim$(  x2651.BarcodeInnerBox)
    x2651.BarcodePacking = trim$(  x2651.BarcodePacking)
    x2651.OrderNo = trim$(  x2651.OrderNo)
    x2651.OrderNoSeq = trim$(  x2651.OrderNoSeq)
    x2651.FactOrderNo = trim$(  x2651.FactOrderNo)
    x2651.FactOrderSeq = trim$(  x2651.FactOrderSeq)
    x2651.CheckComplete = trim$(  x2651.CheckComplete)
    x2651.IsPosted = trim$(  x2651.IsPosted)
    x2651.DatePosted = trim$(  x2651.DatePosted)
    x2651.DateInsert = trim$(  x2651.DateInsert)
    x2651.DateUpdate = trim$(  x2651.DateUpdate)
    x2651.InchargeInsert = trim$(  x2651.InchargeInsert)
    x2651.InchargeUpdate = trim$(  x2651.InchargeUpdate)
    x2651.STimeProduction = trim$(  x2651.STimeProduction)
    x2651.Remark = trim$(  x2651.Remark)
     
    If trim$( x2651.ProductInboundNo ) = "" Then x2651.ProductInboundNo = Space(1) 
    If trim$( x2651.ProductInboundSeq ) = "" Then x2651.ProductInboundSeq = Space(1) 
    If trim$( x2651.CustomerCode ) = "" Then x2651.CustomerCode = Space(1) 
    If trim$( x2651.SupplierCode ) = "" Then x2651.SupplierCode = Space(1) 
    If trim$( x2651.Dseq ) = "" Then x2651.Dseq = 0 
    If trim$( x2651.InvoiceNo ) = "" Then x2651.InvoiceNo = Space(1) 
    If trim$( x2651.DateInbound ) = "" Then x2651.DateInbound = Space(1) 
    If trim$( x2651.seFactory ) = "" Then x2651.seFactory = Space(1) 
    If trim$( x2651.cdFactory ) = "" Then x2651.cdFactory = Space(1) 
    If trim$( x2651.seLineProd ) = "" Then x2651.seLineProd = Space(1) 
    If trim$( x2651.cdLineProd ) = "" Then x2651.cdLineProd = Space(1) 
    If trim$( x2651.CheckProduct ) = "" Then x2651.CheckProduct = Space(1) 
    If trim$( x2651.CheckInBoundMaterial ) = "" Then x2651.CheckInBoundMaterial = Space(1) 
    If trim$( x2651.CheckMaterialType ) = "" Then x2651.CheckMaterialType = Space(1) 
    If trim$( x2651.CheckMarketType ) = "" Then x2651.CheckMarketType = Space(1) 
    If trim$( x2651.KindProduct ) = "" Then x2651.KindProduct = Space(1) 
    If trim$( x2651.seUnitPrice ) = "" Then x2651.seUnitPrice = Space(1) 
    If trim$( x2651.cdUnitPrice ) = "" Then x2651.cdUnitPrice = Space(1) 
    If trim$( x2651.seUnitMaterial ) = "" Then x2651.seUnitMaterial = Space(1) 
    If trim$( x2651.cdUnitMaterial ) = "" Then x2651.cdUnitMaterial = Space(1) 
    If trim$( x2651.seUnitPacking ) = "" Then x2651.seUnitPacking = Space(1) 
    If trim$( x2651.cdUnitPacking ) = "" Then x2651.cdUnitPacking = Space(1) 
    If trim$( x2651.InchargeInbound ) = "" Then x2651.InchargeInbound = Space(1) 
    If trim$( x2651.DateExchange ) = "" Then x2651.DateExchange = Space(1) 
    If trim$( x2651.PriceExchange ) = "" Then x2651.PriceExchange = 0 
    If trim$( x2651.PriceProduct ) = "" Then x2651.PriceProduct = 0 
    If trim$( x2651.PriceProductEX ) = "" Then x2651.PriceProductEX = 0 
    If trim$( x2651.PriceProductVND ) = "" Then x2651.PriceProductVND = 0 
    If trim$( x2651.AmountProductEX ) = "" Then x2651.AmountProductEX = 0 
    If trim$( x2651.AmountProductVND ) = "" Then x2651.AmountProductVND = 0 
    If trim$( x2651.QtyProductInbound ) = "" Then x2651.QtyProductInbound = 0 
    If trim$( x2651.QtyProductOutbound ) = "" Then x2651.QtyProductOutbound = 0 
    If trim$( x2651.QtyProductInboundL ) = "" Then x2651.QtyProductInboundL = 0 
    If trim$( x2651.QtyProductOutboundL ) = "" Then x2651.QtyProductOutboundL = 0 
    If trim$( x2651.QtyProductInboundR ) = "" Then x2651.QtyProductInboundR = 0 
    If trim$( x2651.QtyProductOutboundR ) = "" Then x2651.QtyProductOutboundR = 0 
    If trim$( x2651.ShoesCode ) = "" Then x2651.ShoesCode = Space(1) 
    If trim$( x2651.BatchNo ) = "" Then x2651.BatchNo = Space(1) 
    If trim$( x2651.BarcodeInnerBox ) = "" Then x2651.BarcodeInnerBox = Space(1) 
    If trim$( x2651.BarcodePacking ) = "" Then x2651.BarcodePacking = Space(1) 
    If trim$( x2651.OrderNo ) = "" Then x2651.OrderNo = Space(1) 
    If trim$( x2651.OrderNoSeq ) = "" Then x2651.OrderNoSeq = Space(1) 
    If trim$( x2651.FactOrderNo ) = "" Then x2651.FactOrderNo = Space(1) 
    If trim$( x2651.FactOrderSeq ) = "" Then x2651.FactOrderSeq = 0 
    If trim$( x2651.CheckComplete ) = "" Then x2651.CheckComplete = Space(1) 
    If trim$( x2651.IsPosted ) = "" Then x2651.IsPosted = Space(1) 
    If trim$( x2651.DatePosted ) = "" Then x2651.DatePosted = Space(1) 
    If trim$( x2651.DateInsert ) = "" Then x2651.DateInsert = Space(1) 
    If trim$( x2651.DateUpdate ) = "" Then x2651.DateUpdate = Space(1) 
    If trim$( x2651.InchargeInsert ) = "" Then x2651.InchargeInsert = Space(1) 
    If trim$( x2651.InchargeUpdate ) = "" Then x2651.InchargeUpdate = Space(1) 
    If trim$( x2651.STimeProduction ) = "" Then x2651.STimeProduction = Space(1) 
    If trim$( x2651.Remark ) = "" Then x2651.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K2651_MOVE(rs2651 As SqlClient.SqlDataReader)
Try

    call D2651_CLEAR()   

    If IsdbNull(rs2651!K2651_ProductInboundNo) = False Then D2651.ProductInboundNo = Trim$(rs2651!K2651_ProductInboundNo)
    If IsdbNull(rs2651!K2651_ProductInboundSeq) = False Then D2651.ProductInboundSeq = Trim$(rs2651!K2651_ProductInboundSeq)
    If IsdbNull(rs2651!K2651_CustomerCode) = False Then D2651.CustomerCode = Trim$(rs2651!K2651_CustomerCode)
    If IsdbNull(rs2651!K2651_SupplierCode) = False Then D2651.SupplierCode = Trim$(rs2651!K2651_SupplierCode)
    If IsdbNull(rs2651!K2651_Dseq) = False Then D2651.Dseq = Trim$(rs2651!K2651_Dseq)
    If IsdbNull(rs2651!K2651_InvoiceNo) = False Then D2651.InvoiceNo = Trim$(rs2651!K2651_InvoiceNo)
    If IsdbNull(rs2651!K2651_DateInbound) = False Then D2651.DateInbound = Trim$(rs2651!K2651_DateInbound)
    If IsdbNull(rs2651!K2651_seFactory) = False Then D2651.seFactory = Trim$(rs2651!K2651_seFactory)
    If IsdbNull(rs2651!K2651_cdFactory) = False Then D2651.cdFactory = Trim$(rs2651!K2651_cdFactory)
    If IsdbNull(rs2651!K2651_seLineProd) = False Then D2651.seLineProd = Trim$(rs2651!K2651_seLineProd)
    If IsdbNull(rs2651!K2651_cdLineProd) = False Then D2651.cdLineProd = Trim$(rs2651!K2651_cdLineProd)
    If IsdbNull(rs2651!K2651_CheckProduct) = False Then D2651.CheckProduct = Trim$(rs2651!K2651_CheckProduct)
    If IsdbNull(rs2651!K2651_CheckInBoundMaterial) = False Then D2651.CheckInBoundMaterial = Trim$(rs2651!K2651_CheckInBoundMaterial)
    If IsdbNull(rs2651!K2651_CheckMaterialType) = False Then D2651.CheckMaterialType = Trim$(rs2651!K2651_CheckMaterialType)
    If IsdbNull(rs2651!K2651_CheckMarketType) = False Then D2651.CheckMarketType = Trim$(rs2651!K2651_CheckMarketType)
    If IsdbNull(rs2651!K2651_KindProduct) = False Then D2651.KindProduct = Trim$(rs2651!K2651_KindProduct)
    If IsdbNull(rs2651!K2651_seUnitPrice) = False Then D2651.seUnitPrice = Trim$(rs2651!K2651_seUnitPrice)
    If IsdbNull(rs2651!K2651_cdUnitPrice) = False Then D2651.cdUnitPrice = Trim$(rs2651!K2651_cdUnitPrice)
    If IsdbNull(rs2651!K2651_seUnitMaterial) = False Then D2651.seUnitMaterial = Trim$(rs2651!K2651_seUnitMaterial)
    If IsdbNull(rs2651!K2651_cdUnitMaterial) = False Then D2651.cdUnitMaterial = Trim$(rs2651!K2651_cdUnitMaterial)
    If IsdbNull(rs2651!K2651_seUnitPacking) = False Then D2651.seUnitPacking = Trim$(rs2651!K2651_seUnitPacking)
    If IsdbNull(rs2651!K2651_cdUnitPacking) = False Then D2651.cdUnitPacking = Trim$(rs2651!K2651_cdUnitPacking)
    If IsdbNull(rs2651!K2651_InchargeInbound) = False Then D2651.InchargeInbound = Trim$(rs2651!K2651_InchargeInbound)
    If IsdbNull(rs2651!K2651_DateExchange) = False Then D2651.DateExchange = Trim$(rs2651!K2651_DateExchange)
    If IsdbNull(rs2651!K2651_PriceExchange) = False Then D2651.PriceExchange = Trim$(rs2651!K2651_PriceExchange)
    If IsdbNull(rs2651!K2651_PriceProduct) = False Then D2651.PriceProduct = Trim$(rs2651!K2651_PriceProduct)
    If IsdbNull(rs2651!K2651_PriceProductEX) = False Then D2651.PriceProductEX = Trim$(rs2651!K2651_PriceProductEX)
    If IsdbNull(rs2651!K2651_PriceProductVND) = False Then D2651.PriceProductVND = Trim$(rs2651!K2651_PriceProductVND)
    If IsdbNull(rs2651!K2651_AmountProductEX) = False Then D2651.AmountProductEX = Trim$(rs2651!K2651_AmountProductEX)
    If IsdbNull(rs2651!K2651_AmountProductVND) = False Then D2651.AmountProductVND = Trim$(rs2651!K2651_AmountProductVND)
    If IsdbNull(rs2651!K2651_QtyProductInbound) = False Then D2651.QtyProductInbound = Trim$(rs2651!K2651_QtyProductInbound)
    If IsdbNull(rs2651!K2651_QtyProductOutbound) = False Then D2651.QtyProductOutbound = Trim$(rs2651!K2651_QtyProductOutbound)
    If IsdbNull(rs2651!K2651_QtyProductInboundL) = False Then D2651.QtyProductInboundL = Trim$(rs2651!K2651_QtyProductInboundL)
    If IsdbNull(rs2651!K2651_QtyProductOutboundL) = False Then D2651.QtyProductOutboundL = Trim$(rs2651!K2651_QtyProductOutboundL)
    If IsdbNull(rs2651!K2651_QtyProductInboundR) = False Then D2651.QtyProductInboundR = Trim$(rs2651!K2651_QtyProductInboundR)
    If IsdbNull(rs2651!K2651_QtyProductOutboundR) = False Then D2651.QtyProductOutboundR = Trim$(rs2651!K2651_QtyProductOutboundR)
    If IsdbNull(rs2651!K2651_ShoesCode) = False Then D2651.ShoesCode = Trim$(rs2651!K2651_ShoesCode)
    If IsdbNull(rs2651!K2651_BatchNo) = False Then D2651.BatchNo = Trim$(rs2651!K2651_BatchNo)
    If IsdbNull(rs2651!K2651_BarcodeInnerBox) = False Then D2651.BarcodeInnerBox = Trim$(rs2651!K2651_BarcodeInnerBox)
    If IsdbNull(rs2651!K2651_BarcodePacking) = False Then D2651.BarcodePacking = Trim$(rs2651!K2651_BarcodePacking)
    If IsdbNull(rs2651!K2651_OrderNo) = False Then D2651.OrderNo = Trim$(rs2651!K2651_OrderNo)
    If IsdbNull(rs2651!K2651_OrderNoSeq) = False Then D2651.OrderNoSeq = Trim$(rs2651!K2651_OrderNoSeq)
    If IsdbNull(rs2651!K2651_FactOrderNo) = False Then D2651.FactOrderNo = Trim$(rs2651!K2651_FactOrderNo)
    If IsdbNull(rs2651!K2651_FactOrderSeq) = False Then D2651.FactOrderSeq = Trim$(rs2651!K2651_FactOrderSeq)
    If IsdbNull(rs2651!K2651_CheckComplete) = False Then D2651.CheckComplete = Trim$(rs2651!K2651_CheckComplete)
    If IsdbNull(rs2651!K2651_IsPosted) = False Then D2651.IsPosted = Trim$(rs2651!K2651_IsPosted)
    If IsdbNull(rs2651!K2651_DatePosted) = False Then D2651.DatePosted = Trim$(rs2651!K2651_DatePosted)
    If IsdbNull(rs2651!K2651_DateInsert) = False Then D2651.DateInsert = Trim$(rs2651!K2651_DateInsert)
    If IsdbNull(rs2651!K2651_DateUpdate) = False Then D2651.DateUpdate = Trim$(rs2651!K2651_DateUpdate)
    If IsdbNull(rs2651!K2651_InchargeInsert) = False Then D2651.InchargeInsert = Trim$(rs2651!K2651_InchargeInsert)
    If IsdbNull(rs2651!K2651_InchargeUpdate) = False Then D2651.InchargeUpdate = Trim$(rs2651!K2651_InchargeUpdate)
    If IsdbNull(rs2651!K2651_STimeProduction) = False Then D2651.STimeProduction = Trim$(rs2651!K2651_STimeProduction)
    If IsdbNull(rs2651!K2651_Remark) = False Then D2651.Remark = Trim$(rs2651!K2651_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K2651_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K2651_MOVE(rs2651 As DataRow)
Try

    call D2651_CLEAR()   

    If IsdbNull(rs2651!K2651_ProductInboundNo) = False Then D2651.ProductInboundNo = Trim$(rs2651!K2651_ProductInboundNo)
    If IsdbNull(rs2651!K2651_ProductInboundSeq) = False Then D2651.ProductInboundSeq = Trim$(rs2651!K2651_ProductInboundSeq)
    If IsdbNull(rs2651!K2651_CustomerCode) = False Then D2651.CustomerCode = Trim$(rs2651!K2651_CustomerCode)
    If IsdbNull(rs2651!K2651_SupplierCode) = False Then D2651.SupplierCode = Trim$(rs2651!K2651_SupplierCode)
    If IsdbNull(rs2651!K2651_Dseq) = False Then D2651.Dseq = Trim$(rs2651!K2651_Dseq)
    If IsdbNull(rs2651!K2651_InvoiceNo) = False Then D2651.InvoiceNo = Trim$(rs2651!K2651_InvoiceNo)
    If IsdbNull(rs2651!K2651_DateInbound) = False Then D2651.DateInbound = Trim$(rs2651!K2651_DateInbound)
    If IsdbNull(rs2651!K2651_seFactory) = False Then D2651.seFactory = Trim$(rs2651!K2651_seFactory)
    If IsdbNull(rs2651!K2651_cdFactory) = False Then D2651.cdFactory = Trim$(rs2651!K2651_cdFactory)
    If IsdbNull(rs2651!K2651_seLineProd) = False Then D2651.seLineProd = Trim$(rs2651!K2651_seLineProd)
    If IsdbNull(rs2651!K2651_cdLineProd) = False Then D2651.cdLineProd = Trim$(rs2651!K2651_cdLineProd)
    If IsdbNull(rs2651!K2651_CheckProduct) = False Then D2651.CheckProduct = Trim$(rs2651!K2651_CheckProduct)
    If IsdbNull(rs2651!K2651_CheckInBoundMaterial) = False Then D2651.CheckInBoundMaterial = Trim$(rs2651!K2651_CheckInBoundMaterial)
    If IsdbNull(rs2651!K2651_CheckMaterialType) = False Then D2651.CheckMaterialType = Trim$(rs2651!K2651_CheckMaterialType)
    If IsdbNull(rs2651!K2651_CheckMarketType) = False Then D2651.CheckMarketType = Trim$(rs2651!K2651_CheckMarketType)
    If IsdbNull(rs2651!K2651_KindProduct) = False Then D2651.KindProduct = Trim$(rs2651!K2651_KindProduct)
    If IsdbNull(rs2651!K2651_seUnitPrice) = False Then D2651.seUnitPrice = Trim$(rs2651!K2651_seUnitPrice)
    If IsdbNull(rs2651!K2651_cdUnitPrice) = False Then D2651.cdUnitPrice = Trim$(rs2651!K2651_cdUnitPrice)
    If IsdbNull(rs2651!K2651_seUnitMaterial) = False Then D2651.seUnitMaterial = Trim$(rs2651!K2651_seUnitMaterial)
    If IsdbNull(rs2651!K2651_cdUnitMaterial) = False Then D2651.cdUnitMaterial = Trim$(rs2651!K2651_cdUnitMaterial)
    If IsdbNull(rs2651!K2651_seUnitPacking) = False Then D2651.seUnitPacking = Trim$(rs2651!K2651_seUnitPacking)
    If IsdbNull(rs2651!K2651_cdUnitPacking) = False Then D2651.cdUnitPacking = Trim$(rs2651!K2651_cdUnitPacking)
    If IsdbNull(rs2651!K2651_InchargeInbound) = False Then D2651.InchargeInbound = Trim$(rs2651!K2651_InchargeInbound)
    If IsdbNull(rs2651!K2651_DateExchange) = False Then D2651.DateExchange = Trim$(rs2651!K2651_DateExchange)
    If IsdbNull(rs2651!K2651_PriceExchange) = False Then D2651.PriceExchange = Trim$(rs2651!K2651_PriceExchange)
    If IsdbNull(rs2651!K2651_PriceProduct) = False Then D2651.PriceProduct = Trim$(rs2651!K2651_PriceProduct)
    If IsdbNull(rs2651!K2651_PriceProductEX) = False Then D2651.PriceProductEX = Trim$(rs2651!K2651_PriceProductEX)
    If IsdbNull(rs2651!K2651_PriceProductVND) = False Then D2651.PriceProductVND = Trim$(rs2651!K2651_PriceProductVND)
    If IsdbNull(rs2651!K2651_AmountProductEX) = False Then D2651.AmountProductEX = Trim$(rs2651!K2651_AmountProductEX)
    If IsdbNull(rs2651!K2651_AmountProductVND) = False Then D2651.AmountProductVND = Trim$(rs2651!K2651_AmountProductVND)
    If IsdbNull(rs2651!K2651_QtyProductInbound) = False Then D2651.QtyProductInbound = Trim$(rs2651!K2651_QtyProductInbound)
    If IsdbNull(rs2651!K2651_QtyProductOutbound) = False Then D2651.QtyProductOutbound = Trim$(rs2651!K2651_QtyProductOutbound)
    If IsdbNull(rs2651!K2651_QtyProductInboundL) = False Then D2651.QtyProductInboundL = Trim$(rs2651!K2651_QtyProductInboundL)
    If IsdbNull(rs2651!K2651_QtyProductOutboundL) = False Then D2651.QtyProductOutboundL = Trim$(rs2651!K2651_QtyProductOutboundL)
    If IsdbNull(rs2651!K2651_QtyProductInboundR) = False Then D2651.QtyProductInboundR = Trim$(rs2651!K2651_QtyProductInboundR)
    If IsdbNull(rs2651!K2651_QtyProductOutboundR) = False Then D2651.QtyProductOutboundR = Trim$(rs2651!K2651_QtyProductOutboundR)
    If IsdbNull(rs2651!K2651_ShoesCode) = False Then D2651.ShoesCode = Trim$(rs2651!K2651_ShoesCode)
    If IsdbNull(rs2651!K2651_BatchNo) = False Then D2651.BatchNo = Trim$(rs2651!K2651_BatchNo)
    If IsdbNull(rs2651!K2651_BarcodeInnerBox) = False Then D2651.BarcodeInnerBox = Trim$(rs2651!K2651_BarcodeInnerBox)
    If IsdbNull(rs2651!K2651_BarcodePacking) = False Then D2651.BarcodePacking = Trim$(rs2651!K2651_BarcodePacking)
    If IsdbNull(rs2651!K2651_OrderNo) = False Then D2651.OrderNo = Trim$(rs2651!K2651_OrderNo)
    If IsdbNull(rs2651!K2651_OrderNoSeq) = False Then D2651.OrderNoSeq = Trim$(rs2651!K2651_OrderNoSeq)
    If IsdbNull(rs2651!K2651_FactOrderNo) = False Then D2651.FactOrderNo = Trim$(rs2651!K2651_FactOrderNo)
    If IsdbNull(rs2651!K2651_FactOrderSeq) = False Then D2651.FactOrderSeq = Trim$(rs2651!K2651_FactOrderSeq)
    If IsdbNull(rs2651!K2651_CheckComplete) = False Then D2651.CheckComplete = Trim$(rs2651!K2651_CheckComplete)
    If IsdbNull(rs2651!K2651_IsPosted) = False Then D2651.IsPosted = Trim$(rs2651!K2651_IsPosted)
    If IsdbNull(rs2651!K2651_DatePosted) = False Then D2651.DatePosted = Trim$(rs2651!K2651_DatePosted)
    If IsdbNull(rs2651!K2651_DateInsert) = False Then D2651.DateInsert = Trim$(rs2651!K2651_DateInsert)
    If IsdbNull(rs2651!K2651_DateUpdate) = False Then D2651.DateUpdate = Trim$(rs2651!K2651_DateUpdate)
    If IsdbNull(rs2651!K2651_InchargeInsert) = False Then D2651.InchargeInsert = Trim$(rs2651!K2651_InchargeInsert)
    If IsdbNull(rs2651!K2651_InchargeUpdate) = False Then D2651.InchargeUpdate = Trim$(rs2651!K2651_InchargeUpdate)
    If IsdbNull(rs2651!K2651_STimeProduction) = False Then D2651.STimeProduction = Trim$(rs2651!K2651_STimeProduction)
    If IsdbNull(rs2651!K2651_Remark) = False Then D2651.Remark = Trim$(rs2651!K2651_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K2651_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K2651_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z2651 As T2651_AREA, PRODUCTINBOUNDNO AS String, PRODUCTINBOUNDSEQ AS String) as Boolean

K2651_MOVE = False

Try
    If READ_PFK2651(PRODUCTINBOUNDNO, PRODUCTINBOUNDSEQ) = True Then
                z2651 = D2651
		K2651_MOVE = True
		else
	z2651 = nothing
     End If

     If  getColumIndex(spr,"ProductInboundNo") > -1 then z2651.ProductInboundNo = getDataM(spr, getColumIndex(spr,"ProductInboundNo"), xRow)
     If  getColumIndex(spr,"ProductInboundSeq") > -1 then z2651.ProductInboundSeq = getDataM(spr, getColumIndex(spr,"ProductInboundSeq"), xRow)
     If  getColumIndex(spr,"CustomerCode") > -1 then z2651.CustomerCode = getDataM(spr, getColumIndex(spr,"CustomerCode"), xRow)
     If  getColumIndex(spr,"SupplierCode") > -1 then z2651.SupplierCode = getDataM(spr, getColumIndex(spr,"SupplierCode"), xRow)
     If  getColumIndex(spr,"Dseq") > -1 then z2651.Dseq = getDataM(spr, getColumIndex(spr,"Dseq"), xRow)
     If  getColumIndex(spr,"InvoiceNo") > -1 then z2651.InvoiceNo = getDataM(spr, getColumIndex(spr,"InvoiceNo"), xRow)
     If  getColumIndex(spr,"DateInbound") > -1 then z2651.DateInbound = getDataM(spr, getColumIndex(spr,"DateInbound"), xRow)
     If  getColumIndex(spr,"seFactory") > -1 then z2651.seFactory = getDataM(spr, getColumIndex(spr,"seFactory"), xRow)
     If  getColumIndex(spr,"cdFactory") > -1 then z2651.cdFactory = getDataM(spr, getColumIndex(spr,"cdFactory"), xRow)
     If  getColumIndex(spr,"seLineProd") > -1 then z2651.seLineProd = getDataM(spr, getColumIndex(spr,"seLineProd"), xRow)
     If  getColumIndex(spr,"cdLineProd") > -1 then z2651.cdLineProd = getDataM(spr, getColumIndex(spr,"cdLineProd"), xRow)
     If  getColumIndex(spr,"CheckProduct") > -1 then z2651.CheckProduct = getDataM(spr, getColumIndex(spr,"CheckProduct"), xRow)
     If  getColumIndex(spr,"CheckInBoundMaterial") > -1 then z2651.CheckInBoundMaterial = getDataM(spr, getColumIndex(spr,"CheckInBoundMaterial"), xRow)
     If  getColumIndex(spr,"CheckMaterialType") > -1 then z2651.CheckMaterialType = getDataM(spr, getColumIndex(spr,"CheckMaterialType"), xRow)
     If  getColumIndex(spr,"CheckMarketType") > -1 then z2651.CheckMarketType = getDataM(spr, getColumIndex(spr,"CheckMarketType"), xRow)
     If  getColumIndex(spr,"KindProduct") > -1 then z2651.KindProduct = getDataM(spr, getColumIndex(spr,"KindProduct"), xRow)
     If  getColumIndex(spr,"seUnitPrice") > -1 then z2651.seUnitPrice = getDataM(spr, getColumIndex(spr,"seUnitPrice"), xRow)
     If  getColumIndex(spr,"cdUnitPrice") > -1 then z2651.cdUnitPrice = getDataM(spr, getColumIndex(spr,"cdUnitPrice"), xRow)
     If  getColumIndex(spr,"seUnitMaterial") > -1 then z2651.seUnitMaterial = getDataM(spr, getColumIndex(spr,"seUnitMaterial"), xRow)
     If  getColumIndex(spr,"cdUnitMaterial") > -1 then z2651.cdUnitMaterial = getDataM(spr, getColumIndex(spr,"cdUnitMaterial"), xRow)
     If  getColumIndex(spr,"seUnitPacking") > -1 then z2651.seUnitPacking = getDataM(spr, getColumIndex(spr,"seUnitPacking"), xRow)
     If  getColumIndex(spr,"cdUnitPacking") > -1 then z2651.cdUnitPacking = getDataM(spr, getColumIndex(spr,"cdUnitPacking"), xRow)
     If  getColumIndex(spr,"InchargeInbound") > -1 then z2651.InchargeInbound = getDataM(spr, getColumIndex(spr,"InchargeInbound"), xRow)
     If  getColumIndex(spr,"DateExchange") > -1 then z2651.DateExchange = getDataM(spr, getColumIndex(spr,"DateExchange"), xRow)
     If  getColumIndex(spr,"PriceExchange") > -1 then z2651.PriceExchange = getDataM(spr, getColumIndex(spr,"PriceExchange"), xRow)
     If  getColumIndex(spr,"PriceProduct") > -1 then z2651.PriceProduct = getDataM(spr, getColumIndex(spr,"PriceProduct"), xRow)
     If  getColumIndex(spr,"PriceProductEX") > -1 then z2651.PriceProductEX = getDataM(spr, getColumIndex(spr,"PriceProductEX"), xRow)
     If  getColumIndex(spr,"PriceProductVND") > -1 then z2651.PriceProductVND = getDataM(spr, getColumIndex(spr,"PriceProductVND"), xRow)
     If  getColumIndex(spr,"AmountProductEX") > -1 then z2651.AmountProductEX = getDataM(spr, getColumIndex(spr,"AmountProductEX"), xRow)
     If  getColumIndex(spr,"AmountProductVND") > -1 then z2651.AmountProductVND = getDataM(spr, getColumIndex(spr,"AmountProductVND"), xRow)
     If  getColumIndex(spr,"QtyProductInbound") > -1 then z2651.QtyProductInbound = getDataM(spr, getColumIndex(spr,"QtyProductInbound"), xRow)
     If  getColumIndex(spr,"QtyProductOutbound") > -1 then z2651.QtyProductOutbound = getDataM(spr, getColumIndex(spr,"QtyProductOutbound"), xRow)
     If  getColumIndex(spr,"QtyProductInboundL") > -1 then z2651.QtyProductInboundL = getDataM(spr, getColumIndex(spr,"QtyProductInboundL"), xRow)
     If  getColumIndex(spr,"QtyProductOutboundL") > -1 then z2651.QtyProductOutboundL = getDataM(spr, getColumIndex(spr,"QtyProductOutboundL"), xRow)
     If  getColumIndex(spr,"QtyProductInboundR") > -1 then z2651.QtyProductInboundR = getDataM(spr, getColumIndex(spr,"QtyProductInboundR"), xRow)
     If  getColumIndex(spr,"QtyProductOutboundR") > -1 then z2651.QtyProductOutboundR = getDataM(spr, getColumIndex(spr,"QtyProductOutboundR"), xRow)
     If  getColumIndex(spr,"ShoesCode") > -1 then z2651.ShoesCode = getDataM(spr, getColumIndex(spr,"ShoesCode"), xRow)
     If  getColumIndex(spr,"BatchNo") > -1 then z2651.BatchNo = getDataM(spr, getColumIndex(spr,"BatchNo"), xRow)
     If  getColumIndex(spr,"BarcodeInnerBox") > -1 then z2651.BarcodeInnerBox = getDataM(spr, getColumIndex(spr,"BarcodeInnerBox"), xRow)
     If  getColumIndex(spr,"BarcodePacking") > -1 then z2651.BarcodePacking = getDataM(spr, getColumIndex(spr,"BarcodePacking"), xRow)
     If  getColumIndex(spr,"OrderNo") > -1 then z2651.OrderNo = getDataM(spr, getColumIndex(spr,"OrderNo"), xRow)
     If  getColumIndex(spr,"OrderNoSeq") > -1 then z2651.OrderNoSeq = getDataM(spr, getColumIndex(spr,"OrderNoSeq"), xRow)
     If  getColumIndex(spr,"FactOrderNo") > -1 then z2651.FactOrderNo = getDataM(spr, getColumIndex(spr,"FactOrderNo"), xRow)
     If  getColumIndex(spr,"FactOrderSeq") > -1 then z2651.FactOrderSeq = getDataM(spr, getColumIndex(spr,"FactOrderSeq"), xRow)
     If  getColumIndex(spr,"CheckComplete") > -1 then z2651.CheckComplete = getDataM(spr, getColumIndex(spr,"CheckComplete"), xRow)
     If  getColumIndex(spr,"IsPosted") > -1 then z2651.IsPosted = getDataM(spr, getColumIndex(spr,"IsPosted"), xRow)
     If  getColumIndex(spr,"DatePosted") > -1 then z2651.DatePosted = getDataM(spr, getColumIndex(spr,"DatePosted"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z2651.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z2651.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z2651.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z2651.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"STimeProduction") > -1 then z2651.STimeProduction = getDataM(spr, getColumIndex(spr,"STimeProduction"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z2651.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K2651_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K2651_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z2651 As T2651_AREA,CheckClear as Boolean,PRODUCTINBOUNDNO AS String, PRODUCTINBOUNDSEQ AS String) as Boolean

K2651_MOVE = False

Try
    If READ_PFK2651(PRODUCTINBOUNDNO, PRODUCTINBOUNDSEQ) = True Then
                z2651 = D2651
		K2651_MOVE = True
		else
	If CheckClear  = True then z2651 = nothing
     End If

     If  getColumIndex(spr,"ProductInboundNo") > -1 then z2651.ProductInboundNo = getDataM(spr, getColumIndex(spr,"ProductInboundNo"), xRow)
     If  getColumIndex(spr,"ProductInboundSeq") > -1 then z2651.ProductInboundSeq = getDataM(spr, getColumIndex(spr,"ProductInboundSeq"), xRow)
     If  getColumIndex(spr,"CustomerCode") > -1 then z2651.CustomerCode = getDataM(spr, getColumIndex(spr,"CustomerCode"), xRow)
     If  getColumIndex(spr,"SupplierCode") > -1 then z2651.SupplierCode = getDataM(spr, getColumIndex(spr,"SupplierCode"), xRow)
     If  getColumIndex(spr,"Dseq") > -1 then z2651.Dseq = getDataM(spr, getColumIndex(spr,"Dseq"), xRow)
     If  getColumIndex(spr,"InvoiceNo") > -1 then z2651.InvoiceNo = getDataM(spr, getColumIndex(spr,"InvoiceNo"), xRow)
     If  getColumIndex(spr,"DateInbound") > -1 then z2651.DateInbound = getDataM(spr, getColumIndex(spr,"DateInbound"), xRow)
     If  getColumIndex(spr,"seFactory") > -1 then z2651.seFactory = getDataM(spr, getColumIndex(spr,"seFactory"), xRow)
     If  getColumIndex(spr,"cdFactory") > -1 then z2651.cdFactory = getDataM(spr, getColumIndex(spr,"cdFactory"), xRow)
     If  getColumIndex(spr,"seLineProd") > -1 then z2651.seLineProd = getDataM(spr, getColumIndex(spr,"seLineProd"), xRow)
     If  getColumIndex(spr,"cdLineProd") > -1 then z2651.cdLineProd = getDataM(spr, getColumIndex(spr,"cdLineProd"), xRow)
     If  getColumIndex(spr,"CheckProduct") > -1 then z2651.CheckProduct = getDataM(spr, getColumIndex(spr,"CheckProduct"), xRow)
     If  getColumIndex(spr,"CheckInBoundMaterial") > -1 then z2651.CheckInBoundMaterial = getDataM(spr, getColumIndex(spr,"CheckInBoundMaterial"), xRow)
     If  getColumIndex(spr,"CheckMaterialType") > -1 then z2651.CheckMaterialType = getDataM(spr, getColumIndex(spr,"CheckMaterialType"), xRow)
     If  getColumIndex(spr,"CheckMarketType") > -1 then z2651.CheckMarketType = getDataM(spr, getColumIndex(spr,"CheckMarketType"), xRow)
     If  getColumIndex(spr,"KindProduct") > -1 then z2651.KindProduct = getDataM(spr, getColumIndex(spr,"KindProduct"), xRow)
     If  getColumIndex(spr,"seUnitPrice") > -1 then z2651.seUnitPrice = getDataM(spr, getColumIndex(spr,"seUnitPrice"), xRow)
     If  getColumIndex(spr,"cdUnitPrice") > -1 then z2651.cdUnitPrice = getDataM(spr, getColumIndex(spr,"cdUnitPrice"), xRow)
     If  getColumIndex(spr,"seUnitMaterial") > -1 then z2651.seUnitMaterial = getDataM(spr, getColumIndex(spr,"seUnitMaterial"), xRow)
     If  getColumIndex(spr,"cdUnitMaterial") > -1 then z2651.cdUnitMaterial = getDataM(spr, getColumIndex(spr,"cdUnitMaterial"), xRow)
     If  getColumIndex(spr,"seUnitPacking") > -1 then z2651.seUnitPacking = getDataM(spr, getColumIndex(spr,"seUnitPacking"), xRow)
     If  getColumIndex(spr,"cdUnitPacking") > -1 then z2651.cdUnitPacking = getDataM(spr, getColumIndex(spr,"cdUnitPacking"), xRow)
     If  getColumIndex(spr,"InchargeInbound") > -1 then z2651.InchargeInbound = getDataM(spr, getColumIndex(spr,"InchargeInbound"), xRow)
     If  getColumIndex(spr,"DateExchange") > -1 then z2651.DateExchange = getDataM(spr, getColumIndex(spr,"DateExchange"), xRow)
     If  getColumIndex(spr,"PriceExchange") > -1 then z2651.PriceExchange = getDataM(spr, getColumIndex(spr,"PriceExchange"), xRow)
     If  getColumIndex(spr,"PriceProduct") > -1 then z2651.PriceProduct = getDataM(spr, getColumIndex(spr,"PriceProduct"), xRow)
     If  getColumIndex(spr,"PriceProductEX") > -1 then z2651.PriceProductEX = getDataM(spr, getColumIndex(spr,"PriceProductEX"), xRow)
     If  getColumIndex(spr,"PriceProductVND") > -1 then z2651.PriceProductVND = getDataM(spr, getColumIndex(spr,"PriceProductVND"), xRow)
     If  getColumIndex(spr,"AmountProductEX") > -1 then z2651.AmountProductEX = getDataM(spr, getColumIndex(spr,"AmountProductEX"), xRow)
     If  getColumIndex(spr,"AmountProductVND") > -1 then z2651.AmountProductVND = getDataM(spr, getColumIndex(spr,"AmountProductVND"), xRow)
     If  getColumIndex(spr,"QtyProductInbound") > -1 then z2651.QtyProductInbound = getDataM(spr, getColumIndex(spr,"QtyProductInbound"), xRow)
     If  getColumIndex(spr,"QtyProductOutbound") > -1 then z2651.QtyProductOutbound = getDataM(spr, getColumIndex(spr,"QtyProductOutbound"), xRow)
     If  getColumIndex(spr,"QtyProductInboundL") > -1 then z2651.QtyProductInboundL = getDataM(spr, getColumIndex(spr,"QtyProductInboundL"), xRow)
     If  getColumIndex(spr,"QtyProductOutboundL") > -1 then z2651.QtyProductOutboundL = getDataM(spr, getColumIndex(spr,"QtyProductOutboundL"), xRow)
     If  getColumIndex(spr,"QtyProductInboundR") > -1 then z2651.QtyProductInboundR = getDataM(spr, getColumIndex(spr,"QtyProductInboundR"), xRow)
     If  getColumIndex(spr,"QtyProductOutboundR") > -1 then z2651.QtyProductOutboundR = getDataM(spr, getColumIndex(spr,"QtyProductOutboundR"), xRow)
     If  getColumIndex(spr,"ShoesCode") > -1 then z2651.ShoesCode = getDataM(spr, getColumIndex(spr,"ShoesCode"), xRow)
     If  getColumIndex(spr,"BatchNo") > -1 then z2651.BatchNo = getDataM(spr, getColumIndex(spr,"BatchNo"), xRow)
     If  getColumIndex(spr,"BarcodeInnerBox") > -1 then z2651.BarcodeInnerBox = getDataM(spr, getColumIndex(spr,"BarcodeInnerBox"), xRow)
     If  getColumIndex(spr,"BarcodePacking") > -1 then z2651.BarcodePacking = getDataM(spr, getColumIndex(spr,"BarcodePacking"), xRow)
     If  getColumIndex(spr,"OrderNo") > -1 then z2651.OrderNo = getDataM(spr, getColumIndex(spr,"OrderNo"), xRow)
     If  getColumIndex(spr,"OrderNoSeq") > -1 then z2651.OrderNoSeq = getDataM(spr, getColumIndex(spr,"OrderNoSeq"), xRow)
     If  getColumIndex(spr,"FactOrderNo") > -1 then z2651.FactOrderNo = getDataM(spr, getColumIndex(spr,"FactOrderNo"), xRow)
     If  getColumIndex(spr,"FactOrderSeq") > -1 then z2651.FactOrderSeq = getDataM(spr, getColumIndex(spr,"FactOrderSeq"), xRow)
     If  getColumIndex(spr,"CheckComplete") > -1 then z2651.CheckComplete = getDataM(spr, getColumIndex(spr,"CheckComplete"), xRow)
     If  getColumIndex(spr,"IsPosted") > -1 then z2651.IsPosted = getDataM(spr, getColumIndex(spr,"IsPosted"), xRow)
     If  getColumIndex(spr,"DatePosted") > -1 then z2651.DatePosted = getDataM(spr, getColumIndex(spr,"DatePosted"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z2651.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z2651.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z2651.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z2651.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"STimeProduction") > -1 then z2651.STimeProduction = getDataM(spr, getColumIndex(spr,"STimeProduction"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z2651.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K2651_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K2651_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z2651 As T2651_AREA, Job as String, PRODUCTINBOUNDNO AS String, PRODUCTINBOUNDSEQ AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K2651_MOVE = False

Try
    If READ_PFK2651(PRODUCTINBOUNDNO, PRODUCTINBOUNDSEQ) = True Then
                z2651 = D2651
		K2651_MOVE = True
		else
	z2651 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK2651")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "PRODUCTINBOUNDNO":z2651.ProductInboundNo = Children(i).Code
   Case "PRODUCTINBOUNDSEQ":z2651.ProductInboundSeq = Children(i).Code
   Case "CUSTOMERCODE":z2651.CustomerCode = Children(i).Code
   Case "SUPPLIERCODE":z2651.SupplierCode = Children(i).Code
   Case "DSEQ":z2651.Dseq = Children(i).Code
   Case "INVOICENO":z2651.InvoiceNo = Children(i).Code
   Case "DATEINBOUND":z2651.DateInbound = Children(i).Code
   Case "SEFACTORY":z2651.seFactory = Children(i).Code
   Case "CDFACTORY":z2651.cdFactory = Children(i).Code
   Case "SELINEPROD":z2651.seLineProd = Children(i).Code
   Case "CDLINEPROD":z2651.cdLineProd = Children(i).Code
   Case "CHECKPRODUCT":z2651.CheckProduct = Children(i).Code
   Case "CHECKINBOUNDMATERIAL":z2651.CheckInBoundMaterial = Children(i).Code
   Case "CHECKMATERIALTYPE":z2651.CheckMaterialType = Children(i).Code
   Case "CHECKMARKETTYPE":z2651.CheckMarketType = Children(i).Code
   Case "KINDPRODUCT":z2651.KindProduct = Children(i).Code
   Case "SEUNITPRICE":z2651.seUnitPrice = Children(i).Code
   Case "CDUNITPRICE":z2651.cdUnitPrice = Children(i).Code
   Case "SEUNITMATERIAL":z2651.seUnitMaterial = Children(i).Code
   Case "CDUNITMATERIAL":z2651.cdUnitMaterial = Children(i).Code
   Case "SEUNITPACKING":z2651.seUnitPacking = Children(i).Code
   Case "CDUNITPACKING":z2651.cdUnitPacking = Children(i).Code
   Case "INCHARGEINBOUND":z2651.InchargeInbound = Children(i).Code
   Case "DATEEXCHANGE":z2651.DateExchange = Children(i).Code
   Case "PRICEEXCHANGE":z2651.PriceExchange = Children(i).Code
   Case "PRICEPRODUCT":z2651.PriceProduct = Children(i).Code
   Case "PRICEPRODUCTEX":z2651.PriceProductEX = Children(i).Code
   Case "PRICEPRODUCTVND":z2651.PriceProductVND = Children(i).Code
   Case "AMOUNTPRODUCTEX":z2651.AmountProductEX = Children(i).Code
   Case "AMOUNTPRODUCTVND":z2651.AmountProductVND = Children(i).Code
   Case "QTYPRODUCTINBOUND":z2651.QtyProductInbound = Children(i).Code
   Case "QTYPRODUCTOUTBOUND":z2651.QtyProductOutbound = Children(i).Code
   Case "QTYPRODUCTINBOUNDL":z2651.QtyProductInboundL = Children(i).Code
   Case "QTYPRODUCTOUTBOUNDL":z2651.QtyProductOutboundL = Children(i).Code
   Case "QTYPRODUCTINBOUNDR":z2651.QtyProductInboundR = Children(i).Code
   Case "QTYPRODUCTOUTBOUNDR":z2651.QtyProductOutboundR = Children(i).Code
   Case "SHOESCODE":z2651.ShoesCode = Children(i).Code
   Case "BATCHNO":z2651.BatchNo = Children(i).Code
   Case "BARCODEINNERBOX":z2651.BarcodeInnerBox = Children(i).Code
   Case "BARCODEPACKING":z2651.BarcodePacking = Children(i).Code
   Case "ORDERNO":z2651.OrderNo = Children(i).Code
   Case "ORDERNOSEQ":z2651.OrderNoSeq = Children(i).Code
   Case "FACTORDERNO":z2651.FactOrderNo = Children(i).Code
   Case "FACTORDERSEQ":z2651.FactOrderSeq = Children(i).Code
   Case "CHECKCOMPLETE":z2651.CheckComplete = Children(i).Code
   Case "ISPOSTED":z2651.IsPosted = Children(i).Code
   Case "DATEPOSTED":z2651.DatePosted = Children(i).Code
   Case "DATEINSERT":z2651.DateInsert = Children(i).Code
   Case "DATEUPDATE":z2651.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z2651.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z2651.InchargeUpdate = Children(i).Code
   Case "STIMEPRODUCTION":z2651.STimeProduction = Children(i).Code
   Case "REMARK":z2651.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "PRODUCTINBOUNDNO":z2651.ProductInboundNo = Children(i).Data
   Case "PRODUCTINBOUNDSEQ":z2651.ProductInboundSeq = Children(i).Data
   Case "CUSTOMERCODE":z2651.CustomerCode = Children(i).Data
   Case "SUPPLIERCODE":z2651.SupplierCode = Children(i).Data
   Case "DSEQ":z2651.Dseq = Children(i).Data
   Case "INVOICENO":z2651.InvoiceNo = Children(i).Data
   Case "DATEINBOUND":z2651.DateInbound = Children(i).Data
   Case "SEFACTORY":z2651.seFactory = Children(i).Data
   Case "CDFACTORY":z2651.cdFactory = Children(i).Data
   Case "SELINEPROD":z2651.seLineProd = Children(i).Data
   Case "CDLINEPROD":z2651.cdLineProd = Children(i).Data
   Case "CHECKPRODUCT":z2651.CheckProduct = Children(i).Data
   Case "CHECKINBOUNDMATERIAL":z2651.CheckInBoundMaterial = Children(i).Data
   Case "CHECKMATERIALTYPE":z2651.CheckMaterialType = Children(i).Data
   Case "CHECKMARKETTYPE":z2651.CheckMarketType = Children(i).Data
   Case "KINDPRODUCT":z2651.KindProduct = Children(i).Data
   Case "SEUNITPRICE":z2651.seUnitPrice = Children(i).Data
   Case "CDUNITPRICE":z2651.cdUnitPrice = Children(i).Data
   Case "SEUNITMATERIAL":z2651.seUnitMaterial = Children(i).Data
   Case "CDUNITMATERIAL":z2651.cdUnitMaterial = Children(i).Data
   Case "SEUNITPACKING":z2651.seUnitPacking = Children(i).Data
   Case "CDUNITPACKING":z2651.cdUnitPacking = Children(i).Data
   Case "INCHARGEINBOUND":z2651.InchargeInbound = Children(i).Data
   Case "DATEEXCHANGE":z2651.DateExchange = Children(i).Data
   Case "PRICEEXCHANGE":z2651.PriceExchange = Children(i).Data
   Case "PRICEPRODUCT":z2651.PriceProduct = Children(i).Data
   Case "PRICEPRODUCTEX":z2651.PriceProductEX = Children(i).Data
   Case "PRICEPRODUCTVND":z2651.PriceProductVND = Children(i).Data
   Case "AMOUNTPRODUCTEX":z2651.AmountProductEX = Children(i).Data
   Case "AMOUNTPRODUCTVND":z2651.AmountProductVND = Children(i).Data
   Case "QTYPRODUCTINBOUND":z2651.QtyProductInbound = Children(i).Data
   Case "QTYPRODUCTOUTBOUND":z2651.QtyProductOutbound = Children(i).Data
   Case "QTYPRODUCTINBOUNDL":z2651.QtyProductInboundL = Children(i).Data
   Case "QTYPRODUCTOUTBOUNDL":z2651.QtyProductOutboundL = Children(i).Data
   Case "QTYPRODUCTINBOUNDR":z2651.QtyProductInboundR = Children(i).Data
   Case "QTYPRODUCTOUTBOUNDR":z2651.QtyProductOutboundR = Children(i).Data
   Case "SHOESCODE":z2651.ShoesCode = Children(i).Data
   Case "BATCHNO":z2651.BatchNo = Children(i).Data
   Case "BARCODEINNERBOX":z2651.BarcodeInnerBox = Children(i).Data
   Case "BARCODEPACKING":z2651.BarcodePacking = Children(i).Data
   Case "ORDERNO":z2651.OrderNo = Children(i).Data
   Case "ORDERNOSEQ":z2651.OrderNoSeq = Children(i).Data
   Case "FACTORDERNO":z2651.FactOrderNo = Children(i).Data
   Case "FACTORDERSEQ":z2651.FactOrderSeq = Children(i).Data
   Case "CHECKCOMPLETE":z2651.CheckComplete = Children(i).Data
   Case "ISPOSTED":z2651.IsPosted = Children(i).Data
   Case "DATEPOSTED":z2651.DatePosted = Children(i).Data
   Case "DATEINSERT":z2651.DateInsert = Children(i).Data
   Case "DATEUPDATE":z2651.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z2651.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z2651.InchargeUpdate = Children(i).Data
   Case "STIMEPRODUCTION":z2651.STimeProduction = Children(i).Data
   Case "REMARK":z2651.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K2651_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K2651_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z2651 As T2651_AREA, Job as String, CheckClear as Boolean, PRODUCTINBOUNDNO AS String, PRODUCTINBOUNDSEQ AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K2651_MOVE = False

Try
    If READ_PFK2651(PRODUCTINBOUNDNO, PRODUCTINBOUNDSEQ) = True Then
                z2651 = D2651
		K2651_MOVE = True
		else
	If CheckClear  = True then z2651 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK2651")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "PRODUCTINBOUNDNO":z2651.ProductInboundNo = Children(i).Code
   Case "PRODUCTINBOUNDSEQ":z2651.ProductInboundSeq = Children(i).Code
   Case "CUSTOMERCODE":z2651.CustomerCode = Children(i).Code
   Case "SUPPLIERCODE":z2651.SupplierCode = Children(i).Code
   Case "DSEQ":z2651.Dseq = Children(i).Code
   Case "INVOICENO":z2651.InvoiceNo = Children(i).Code
   Case "DATEINBOUND":z2651.DateInbound = Children(i).Code
   Case "SEFACTORY":z2651.seFactory = Children(i).Code
   Case "CDFACTORY":z2651.cdFactory = Children(i).Code
   Case "SELINEPROD":z2651.seLineProd = Children(i).Code
   Case "CDLINEPROD":z2651.cdLineProd = Children(i).Code
   Case "CHECKPRODUCT":z2651.CheckProduct = Children(i).Code
   Case "CHECKINBOUNDMATERIAL":z2651.CheckInBoundMaterial = Children(i).Code
   Case "CHECKMATERIALTYPE":z2651.CheckMaterialType = Children(i).Code
   Case "CHECKMARKETTYPE":z2651.CheckMarketType = Children(i).Code
   Case "KINDPRODUCT":z2651.KindProduct = Children(i).Code
   Case "SEUNITPRICE":z2651.seUnitPrice = Children(i).Code
   Case "CDUNITPRICE":z2651.cdUnitPrice = Children(i).Code
   Case "SEUNITMATERIAL":z2651.seUnitMaterial = Children(i).Code
   Case "CDUNITMATERIAL":z2651.cdUnitMaterial = Children(i).Code
   Case "SEUNITPACKING":z2651.seUnitPacking = Children(i).Code
   Case "CDUNITPACKING":z2651.cdUnitPacking = Children(i).Code
   Case "INCHARGEINBOUND":z2651.InchargeInbound = Children(i).Code
   Case "DATEEXCHANGE":z2651.DateExchange = Children(i).Code
   Case "PRICEEXCHANGE":z2651.PriceExchange = Children(i).Code
   Case "PRICEPRODUCT":z2651.PriceProduct = Children(i).Code
   Case "PRICEPRODUCTEX":z2651.PriceProductEX = Children(i).Code
   Case "PRICEPRODUCTVND":z2651.PriceProductVND = Children(i).Code
   Case "AMOUNTPRODUCTEX":z2651.AmountProductEX = Children(i).Code
   Case "AMOUNTPRODUCTVND":z2651.AmountProductVND = Children(i).Code
   Case "QTYPRODUCTINBOUND":z2651.QtyProductInbound = Children(i).Code
   Case "QTYPRODUCTOUTBOUND":z2651.QtyProductOutbound = Children(i).Code
   Case "QTYPRODUCTINBOUNDL":z2651.QtyProductInboundL = Children(i).Code
   Case "QTYPRODUCTOUTBOUNDL":z2651.QtyProductOutboundL = Children(i).Code
   Case "QTYPRODUCTINBOUNDR":z2651.QtyProductInboundR = Children(i).Code
   Case "QTYPRODUCTOUTBOUNDR":z2651.QtyProductOutboundR = Children(i).Code
   Case "SHOESCODE":z2651.ShoesCode = Children(i).Code
   Case "BATCHNO":z2651.BatchNo = Children(i).Code
   Case "BARCODEINNERBOX":z2651.BarcodeInnerBox = Children(i).Code
   Case "BARCODEPACKING":z2651.BarcodePacking = Children(i).Code
   Case "ORDERNO":z2651.OrderNo = Children(i).Code
   Case "ORDERNOSEQ":z2651.OrderNoSeq = Children(i).Code
   Case "FACTORDERNO":z2651.FactOrderNo = Children(i).Code
   Case "FACTORDERSEQ":z2651.FactOrderSeq = Children(i).Code
   Case "CHECKCOMPLETE":z2651.CheckComplete = Children(i).Code
   Case "ISPOSTED":z2651.IsPosted = Children(i).Code
   Case "DATEPOSTED":z2651.DatePosted = Children(i).Code
   Case "DATEINSERT":z2651.DateInsert = Children(i).Code
   Case "DATEUPDATE":z2651.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z2651.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z2651.InchargeUpdate = Children(i).Code
   Case "STIMEPRODUCTION":z2651.STimeProduction = Children(i).Code
   Case "REMARK":z2651.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "PRODUCTINBOUNDNO":z2651.ProductInboundNo = Children(i).Data
   Case "PRODUCTINBOUNDSEQ":z2651.ProductInboundSeq = Children(i).Data
   Case "CUSTOMERCODE":z2651.CustomerCode = Children(i).Data
   Case "SUPPLIERCODE":z2651.SupplierCode = Children(i).Data
   Case "DSEQ":z2651.Dseq = Children(i).Data
   Case "INVOICENO":z2651.InvoiceNo = Children(i).Data
   Case "DATEINBOUND":z2651.DateInbound = Children(i).Data
   Case "SEFACTORY":z2651.seFactory = Children(i).Data
   Case "CDFACTORY":z2651.cdFactory = Children(i).Data
   Case "SELINEPROD":z2651.seLineProd = Children(i).Data
   Case "CDLINEPROD":z2651.cdLineProd = Children(i).Data
   Case "CHECKPRODUCT":z2651.CheckProduct = Children(i).Data
   Case "CHECKINBOUNDMATERIAL":z2651.CheckInBoundMaterial = Children(i).Data
   Case "CHECKMATERIALTYPE":z2651.CheckMaterialType = Children(i).Data
   Case "CHECKMARKETTYPE":z2651.CheckMarketType = Children(i).Data
   Case "KINDPRODUCT":z2651.KindProduct = Children(i).Data
   Case "SEUNITPRICE":z2651.seUnitPrice = Children(i).Data
   Case "CDUNITPRICE":z2651.cdUnitPrice = Children(i).Data
   Case "SEUNITMATERIAL":z2651.seUnitMaterial = Children(i).Data
   Case "CDUNITMATERIAL":z2651.cdUnitMaterial = Children(i).Data
   Case "SEUNITPACKING":z2651.seUnitPacking = Children(i).Data
   Case "CDUNITPACKING":z2651.cdUnitPacking = Children(i).Data
   Case "INCHARGEINBOUND":z2651.InchargeInbound = Children(i).Data
   Case "DATEEXCHANGE":z2651.DateExchange = Children(i).Data
   Case "PRICEEXCHANGE":z2651.PriceExchange = Children(i).Data
   Case "PRICEPRODUCT":z2651.PriceProduct = Children(i).Data
   Case "PRICEPRODUCTEX":z2651.PriceProductEX = Children(i).Data
   Case "PRICEPRODUCTVND":z2651.PriceProductVND = Children(i).Data
   Case "AMOUNTPRODUCTEX":z2651.AmountProductEX = Children(i).Data
   Case "AMOUNTPRODUCTVND":z2651.AmountProductVND = Children(i).Data
   Case "QTYPRODUCTINBOUND":z2651.QtyProductInbound = Children(i).Data
   Case "QTYPRODUCTOUTBOUND":z2651.QtyProductOutbound = Children(i).Data
   Case "QTYPRODUCTINBOUNDL":z2651.QtyProductInboundL = Children(i).Data
   Case "QTYPRODUCTOUTBOUNDL":z2651.QtyProductOutboundL = Children(i).Data
   Case "QTYPRODUCTINBOUNDR":z2651.QtyProductInboundR = Children(i).Data
   Case "QTYPRODUCTOUTBOUNDR":z2651.QtyProductOutboundR = Children(i).Data
   Case "SHOESCODE":z2651.ShoesCode = Children(i).Data
   Case "BATCHNO":z2651.BatchNo = Children(i).Data
   Case "BARCODEINNERBOX":z2651.BarcodeInnerBox = Children(i).Data
   Case "BARCODEPACKING":z2651.BarcodePacking = Children(i).Data
   Case "ORDERNO":z2651.OrderNo = Children(i).Data
   Case "ORDERNOSEQ":z2651.OrderNoSeq = Children(i).Data
   Case "FACTORDERNO":z2651.FactOrderNo = Children(i).Data
   Case "FACTORDERSEQ":z2651.FactOrderSeq = Children(i).Data
   Case "CHECKCOMPLETE":z2651.CheckComplete = Children(i).Data
   Case "ISPOSTED":z2651.IsPosted = Children(i).Data
   Case "DATEPOSTED":z2651.DatePosted = Children(i).Data
   Case "DATEINSERT":z2651.DateInsert = Children(i).Data
   Case "DATEUPDATE":z2651.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z2651.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z2651.InchargeUpdate = Children(i).Data
   Case "STIMEPRODUCTION":z2651.STimeProduction = Children(i).Data
   Case "REMARK":z2651.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K2651_MOVE",vbCritical)
End Try
End Function 
    
End Module 
