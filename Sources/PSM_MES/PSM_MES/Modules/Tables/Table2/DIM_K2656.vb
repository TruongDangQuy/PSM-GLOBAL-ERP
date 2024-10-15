'=========================================================================================================================================================
'   TABLE : (PFK2656)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K2656

Structure T2656_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	ProductOutboundNo	 AS String	'			char(8)		*
Public 	ProductOutboundSeq	 AS String	'			char(5)		*
Public 	CustomerCode	 AS String	'			char(6)
Public 	SupplierCode	 AS String	'			char(6)
Public 	seFactory	 AS String	'			char(3)
Public 	cdFactory	 AS String	'			char(3)
Public 	ShoesCode	 AS String	'			char(6)
Public 	SizeRange	 AS String	'			char(6)
Public 	CheckOutBoundMaterial	 AS String	'			char(1)
Public 	CheckMaterialType	 AS String	'			char(1)
Public 	CheckMarketType	 AS String	'			char(1)
Public 	InvoiceNo	 AS String	'			nvarchar(20)
Public 	seUnitPrice	 AS String	'			char(3)
Public 	cdUnitPrice	 AS String	'			char(3)
Public 	DateExchange	 AS String	'			char(8)
Public 	PriceExchange	 AS Double	'			decimal
Public 	ProductInboundNo	 AS String	'			char(8)
Public 	ProductInboundSeq	 AS String	'			char(5)
Public 	DateOutbound	 AS String	'			char(8)
Public 	InchargeOutbound	 AS String	'			char(8)
Public 	FactOrderNo	 AS String	'			char(9)
Public 	FactOrderSeq	 AS Double	'			decimal
Public 	OrderNo	 AS String	'			char(9)
Public 	OrderNoSeq	 AS String	'			char(3)
Public 	PalletNo	 AS String	'			nvarchar(50)
Public 	StockNo	 AS String	'			nvarchar(50)
Public 	BarcodeInnerBox	 AS String	'			nvarchar(50)
Public 	BarcodePacking	 AS String	'			nvarchar(50)
Public 	BatchNo	 AS String	'			char(10)
Public 	CheckComplete	 AS String	'			char(1)
Public 	PriceShipping	 AS Double	'			decimal
Public 	PriceShippingVND	 AS Double	'			decimal
Public 	AmountShipping	 AS Double	'			decimal
Public 	AmountShippingVND	 AS Double	'			decimal
Public 	QtyProductOutbound	 AS Double	'			decimal
Public 	IsPosted	 AS String	'			char(1)
Public 	DatePosted	 AS String	'			char(8)
Public 	DateInsert	 AS String	'			char(8)
Public 	DateUpdate	 AS String	'			char(8)
Public 	InchargeInsert	 AS String	'			char(8)
Public 	InchargeUpdate	 AS String	'			char(8)
Public 	Remark	 AS String	'			nvarchar(100)
'=========================================================================================================================================================
End structure

Public D2656 As T2656_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK2656(PRODUCTOUTBOUNDNO AS String, PRODUCTOUTBOUNDSEQ AS String) As Boolean
    READ_PFK2656 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK2656 "
    SQL = SQL & " WHERE K2656_ProductOutboundNo		 = '" & ProductOutboundNo & "' " 
    SQL = SQL & "   AND K2656_ProductOutboundSeq		 = '" & ProductOutboundSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D2656_CLEAR: GoTo SKIP_READ_PFK2656
                
    Call K2656_MOVE(rd)
    READ_PFK2656 = True

SKIP_READ_PFK2656:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK2656",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK2656(PRODUCTOUTBOUNDNO AS String, PRODUCTOUTBOUNDSEQ AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK2656 "
    SQL = SQL & " WHERE K2656_ProductOutboundNo		 = '" & ProductOutboundNo & "' " 
    SQL = SQL & "   AND K2656_ProductOutboundSeq		 = '" & ProductOutboundSeq & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK2656",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK2656(z2656 As T2656_AREA) As Boolean
    WRITE_PFK2656 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z2656)
 
    SQL = " INSERT INTO PFK2656 "
    SQL = SQL & " ( "
    SQL = SQL & " K2656_ProductOutboundNo," 
    SQL = SQL & " K2656_ProductOutboundSeq," 
    SQL = SQL & " K2656_CustomerCode," 
    SQL = SQL & " K2656_SupplierCode," 
    SQL = SQL & " K2656_seFactory," 
    SQL = SQL & " K2656_cdFactory," 
    SQL = SQL & " K2656_ShoesCode," 
    SQL = SQL & " K2656_SizeRange," 
    SQL = SQL & " K2656_CheckOutBoundMaterial," 
    SQL = SQL & " K2656_CheckMaterialType," 
    SQL = SQL & " K2656_CheckMarketType," 
    SQL = SQL & " K2656_InvoiceNo," 
    SQL = SQL & " K2656_seUnitPrice," 
    SQL = SQL & " K2656_cdUnitPrice," 
    SQL = SQL & " K2656_DateExchange," 
    SQL = SQL & " K2656_PriceExchange," 
    SQL = SQL & " K2656_ProductInboundNo," 
    SQL = SQL & " K2656_ProductInboundSeq," 
    SQL = SQL & " K2656_DateOutbound," 
    SQL = SQL & " K2656_InchargeOutbound," 
    SQL = SQL & " K2656_FactOrderNo," 
    SQL = SQL & " K2656_FactOrderSeq," 
    SQL = SQL & " K2656_OrderNo," 
    SQL = SQL & " K2656_OrderNoSeq," 
    SQL = SQL & " K2656_PalletNo," 
    SQL = SQL & " K2656_StockNo," 
    SQL = SQL & " K2656_BarcodeInnerBox," 
    SQL = SQL & " K2656_BarcodePacking," 
    SQL = SQL & " K2656_BatchNo," 
    SQL = SQL & " K2656_CheckComplete," 
    SQL = SQL & " K2656_PriceShipping," 
    SQL = SQL & " K2656_PriceShippingVND," 
    SQL = SQL & " K2656_AmountShipping," 
    SQL = SQL & " K2656_AmountShippingVND," 
    SQL = SQL & " K2656_QtyProductOutbound," 
    SQL = SQL & " K2656_IsPosted," 
    SQL = SQL & " K2656_DatePosted," 
    SQL = SQL & " K2656_DateInsert," 
    SQL = SQL & " K2656_DateUpdate," 
    SQL = SQL & " K2656_InchargeInsert," 
    SQL = SQL & " K2656_InchargeUpdate," 
    SQL = SQL & " K2656_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z2656.ProductOutboundNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2656.ProductOutboundSeq) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2656.CustomerCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2656.SupplierCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2656.seFactory) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2656.cdFactory) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2656.ShoesCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2656.SizeRange) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2656.CheckOutBoundMaterial) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2656.CheckMaterialType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2656.CheckMarketType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2656.InvoiceNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2656.seUnitPrice) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2656.cdUnitPrice) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2656.DateExchange) & "', "  
    SQL = SQL & "   " & FormatSQL(z2656.PriceExchange) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z2656.ProductInboundNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2656.ProductInboundSeq) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2656.DateOutbound) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2656.InchargeOutbound) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2656.FactOrderNo) & "', "  
    SQL = SQL & "   " & FormatSQL(z2656.FactOrderSeq) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z2656.OrderNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2656.OrderNoSeq) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2656.PalletNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2656.StockNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2656.BarcodeInnerBox) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2656.BarcodePacking) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2656.BatchNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2656.CheckComplete) & "', "  
    SQL = SQL & "   " & FormatSQL(z2656.PriceShipping) & ", "  
    SQL = SQL & "   " & FormatSQL(z2656.PriceShippingVND) & ", "  
    SQL = SQL & "   " & FormatSQL(z2656.AmountShipping) & ", "  
    SQL = SQL & "   " & FormatSQL(z2656.AmountShippingVND) & ", "  
    SQL = SQL & "   " & FormatSQL(z2656.QtyProductOutbound) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z2656.IsPosted) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2656.DatePosted) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2656.DateInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2656.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2656.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2656.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2656.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK2656 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK2656",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK2656(z2656 As T2656_AREA) As Boolean
    REWRITE_PFK2656 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z2656)
   
    SQL = " UPDATE PFK2656 SET "
    SQL = SQL & "    K2656_CustomerCode      = N'" & FormatSQL(z2656.CustomerCode) & "', " 
    SQL = SQL & "    K2656_SupplierCode      = N'" & FormatSQL(z2656.SupplierCode) & "', " 
    SQL = SQL & "    K2656_seFactory      = N'" & FormatSQL(z2656.seFactory) & "', " 
    SQL = SQL & "    K2656_cdFactory      = N'" & FormatSQL(z2656.cdFactory) & "', " 
    SQL = SQL & "    K2656_ShoesCode      = N'" & FormatSQL(z2656.ShoesCode) & "', " 
    SQL = SQL & "    K2656_SizeRange      = N'" & FormatSQL(z2656.SizeRange) & "', " 
    SQL = SQL & "    K2656_CheckOutBoundMaterial      = N'" & FormatSQL(z2656.CheckOutBoundMaterial) & "', " 
    SQL = SQL & "    K2656_CheckMaterialType      = N'" & FormatSQL(z2656.CheckMaterialType) & "', " 
    SQL = SQL & "    K2656_CheckMarketType      = N'" & FormatSQL(z2656.CheckMarketType) & "', " 
    SQL = SQL & "    K2656_InvoiceNo      = N'" & FormatSQL(z2656.InvoiceNo) & "', " 
    SQL = SQL & "    K2656_seUnitPrice      = N'" & FormatSQL(z2656.seUnitPrice) & "', " 
    SQL = SQL & "    K2656_cdUnitPrice      = N'" & FormatSQL(z2656.cdUnitPrice) & "', " 
    SQL = SQL & "    K2656_DateExchange      = N'" & FormatSQL(z2656.DateExchange) & "', " 
    SQL = SQL & "    K2656_PriceExchange      =  " & FormatSQL(z2656.PriceExchange) & ", " 
    SQL = SQL & "    K2656_ProductInboundNo      = N'" & FormatSQL(z2656.ProductInboundNo) & "', " 
    SQL = SQL & "    K2656_ProductInboundSeq      = N'" & FormatSQL(z2656.ProductInboundSeq) & "', " 
    SQL = SQL & "    K2656_DateOutbound      = N'" & FormatSQL(z2656.DateOutbound) & "', " 
    SQL = SQL & "    K2656_InchargeOutbound      = N'" & FormatSQL(z2656.InchargeOutbound) & "', " 
    SQL = SQL & "    K2656_FactOrderNo      = N'" & FormatSQL(z2656.FactOrderNo) & "', " 
    SQL = SQL & "    K2656_FactOrderSeq      =  " & FormatSQL(z2656.FactOrderSeq) & ", " 
    SQL = SQL & "    K2656_OrderNo      = N'" & FormatSQL(z2656.OrderNo) & "', " 
    SQL = SQL & "    K2656_OrderNoSeq      = N'" & FormatSQL(z2656.OrderNoSeq) & "', " 
    SQL = SQL & "    K2656_PalletNo      = N'" & FormatSQL(z2656.PalletNo) & "', " 
    SQL = SQL & "    K2656_StockNo      = N'" & FormatSQL(z2656.StockNo) & "', " 
    SQL = SQL & "    K2656_BarcodeInnerBox      = N'" & FormatSQL(z2656.BarcodeInnerBox) & "', " 
    SQL = SQL & "    K2656_BarcodePacking      = N'" & FormatSQL(z2656.BarcodePacking) & "', " 
    SQL = SQL & "    K2656_BatchNo      = N'" & FormatSQL(z2656.BatchNo) & "', " 
    SQL = SQL & "    K2656_CheckComplete      = N'" & FormatSQL(z2656.CheckComplete) & "', " 
    SQL = SQL & "    K2656_PriceShipping      =  " & FormatSQL(z2656.PriceShipping) & ", " 
    SQL = SQL & "    K2656_PriceShippingVND      =  " & FormatSQL(z2656.PriceShippingVND) & ", " 
    SQL = SQL & "    K2656_AmountShipping      =  " & FormatSQL(z2656.AmountShipping) & ", " 
    SQL = SQL & "    K2656_AmountShippingVND      =  " & FormatSQL(z2656.AmountShippingVND) & ", " 
    SQL = SQL & "    K2656_QtyProductOutbound      =  " & FormatSQL(z2656.QtyProductOutbound) & ", " 
    SQL = SQL & "    K2656_IsPosted      = N'" & FormatSQL(z2656.IsPosted) & "', " 
    SQL = SQL & "    K2656_DatePosted      = N'" & FormatSQL(z2656.DatePosted) & "', " 
    SQL = SQL & "    K2656_DateInsert      = N'" & FormatSQL(z2656.DateInsert) & "', " 
    SQL = SQL & "    K2656_DateUpdate      = N'" & FormatSQL(z2656.DateUpdate) & "', " 
    SQL = SQL & "    K2656_InchargeInsert      = N'" & FormatSQL(z2656.InchargeInsert) & "', " 
    SQL = SQL & "    K2656_InchargeUpdate      = N'" & FormatSQL(z2656.InchargeUpdate) & "', " 
    SQL = SQL & "    K2656_Remark      = N'" & FormatSQL(z2656.Remark) & "'  " 
    SQL = SQL & " WHERE K2656_ProductOutboundNo		 = '" & z2656.ProductOutboundNo & "' " 
    SQL = SQL & "   AND K2656_ProductOutboundSeq		 = '" & z2656.ProductOutboundSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK2656 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK2656",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK2656(z2656 As T2656_AREA) As Boolean
    DELETE_PFK2656 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK2656 "
    SQL = SQL & " WHERE K2656_ProductOutboundNo		 = '" & z2656.ProductOutboundNo & "' " 
    SQL = SQL & "   AND K2656_ProductOutboundSeq		 = '" & z2656.ProductOutboundSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK2656 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK2656",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D2656_CLEAR()
Try
    
   D2656.ProductOutboundNo = ""
   D2656.ProductOutboundSeq = ""
   D2656.CustomerCode = ""
   D2656.SupplierCode = ""
   D2656.seFactory = ""
   D2656.cdFactory = ""
   D2656.ShoesCode = ""
   D2656.SizeRange = ""
   D2656.CheckOutBoundMaterial = ""
   D2656.CheckMaterialType = ""
   D2656.CheckMarketType = ""
   D2656.InvoiceNo = ""
   D2656.seUnitPrice = ""
   D2656.cdUnitPrice = ""
   D2656.DateExchange = ""
    D2656.PriceExchange = 0 
   D2656.ProductInboundNo = ""
   D2656.ProductInboundSeq = ""
   D2656.DateOutbound = ""
   D2656.InchargeOutbound = ""
   D2656.FactOrderNo = ""
    D2656.FactOrderSeq = 0 
   D2656.OrderNo = ""
   D2656.OrderNoSeq = ""
   D2656.PalletNo = ""
   D2656.StockNo = ""
   D2656.BarcodeInnerBox = ""
   D2656.BarcodePacking = ""
   D2656.BatchNo = ""
   D2656.CheckComplete = ""
    D2656.PriceShipping = 0 
    D2656.PriceShippingVND = 0 
    D2656.AmountShipping = 0 
    D2656.AmountShippingVND = 0 
    D2656.QtyProductOutbound = 0 
   D2656.IsPosted = ""
   D2656.DatePosted = ""
   D2656.DateInsert = ""
   D2656.DateUpdate = ""
   D2656.InchargeInsert = ""
   D2656.InchargeUpdate = ""
   D2656.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D2656_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x2656 As T2656_AREA)
Try
    
    x2656.ProductOutboundNo = trim$(  x2656.ProductOutboundNo)
    x2656.ProductOutboundSeq = trim$(  x2656.ProductOutboundSeq)
    x2656.CustomerCode = trim$(  x2656.CustomerCode)
    x2656.SupplierCode = trim$(  x2656.SupplierCode)
    x2656.seFactory = trim$(  x2656.seFactory)
    x2656.cdFactory = trim$(  x2656.cdFactory)
    x2656.ShoesCode = trim$(  x2656.ShoesCode)
    x2656.SizeRange = trim$(  x2656.SizeRange)
    x2656.CheckOutBoundMaterial = trim$(  x2656.CheckOutBoundMaterial)
    x2656.CheckMaterialType = trim$(  x2656.CheckMaterialType)
    x2656.CheckMarketType = trim$(  x2656.CheckMarketType)
    x2656.InvoiceNo = trim$(  x2656.InvoiceNo)
    x2656.seUnitPrice = trim$(  x2656.seUnitPrice)
    x2656.cdUnitPrice = trim$(  x2656.cdUnitPrice)
    x2656.DateExchange = trim$(  x2656.DateExchange)
    x2656.PriceExchange = trim$(  x2656.PriceExchange)
    x2656.ProductInboundNo = trim$(  x2656.ProductInboundNo)
    x2656.ProductInboundSeq = trim$(  x2656.ProductInboundSeq)
    x2656.DateOutbound = trim$(  x2656.DateOutbound)
    x2656.InchargeOutbound = trim$(  x2656.InchargeOutbound)
    x2656.FactOrderNo = trim$(  x2656.FactOrderNo)
    x2656.FactOrderSeq = trim$(  x2656.FactOrderSeq)
    x2656.OrderNo = trim$(  x2656.OrderNo)
    x2656.OrderNoSeq = trim$(  x2656.OrderNoSeq)
    x2656.PalletNo = trim$(  x2656.PalletNo)
    x2656.StockNo = trim$(  x2656.StockNo)
    x2656.BarcodeInnerBox = trim$(  x2656.BarcodeInnerBox)
    x2656.BarcodePacking = trim$(  x2656.BarcodePacking)
    x2656.BatchNo = trim$(  x2656.BatchNo)
    x2656.CheckComplete = trim$(  x2656.CheckComplete)
    x2656.PriceShipping = trim$(  x2656.PriceShipping)
    x2656.PriceShippingVND = trim$(  x2656.PriceShippingVND)
    x2656.AmountShipping = trim$(  x2656.AmountShipping)
    x2656.AmountShippingVND = trim$(  x2656.AmountShippingVND)
    x2656.QtyProductOutbound = trim$(  x2656.QtyProductOutbound)
    x2656.IsPosted = trim$(  x2656.IsPosted)
    x2656.DatePosted = trim$(  x2656.DatePosted)
    x2656.DateInsert = trim$(  x2656.DateInsert)
    x2656.DateUpdate = trim$(  x2656.DateUpdate)
    x2656.InchargeInsert = trim$(  x2656.InchargeInsert)
    x2656.InchargeUpdate = trim$(  x2656.InchargeUpdate)
    x2656.Remark = trim$(  x2656.Remark)
     
    If trim$( x2656.ProductOutboundNo ) = "" Then x2656.ProductOutboundNo = Space(1) 
    If trim$( x2656.ProductOutboundSeq ) = "" Then x2656.ProductOutboundSeq = Space(1) 
    If trim$( x2656.CustomerCode ) = "" Then x2656.CustomerCode = Space(1) 
    If trim$( x2656.SupplierCode ) = "" Then x2656.SupplierCode = Space(1) 
    If trim$( x2656.seFactory ) = "" Then x2656.seFactory = Space(1) 
    If trim$( x2656.cdFactory ) = "" Then x2656.cdFactory = Space(1) 
    If trim$( x2656.ShoesCode ) = "" Then x2656.ShoesCode = Space(1) 
    If trim$( x2656.SizeRange ) = "" Then x2656.SizeRange = Space(1) 
    If trim$( x2656.CheckOutBoundMaterial ) = "" Then x2656.CheckOutBoundMaterial = Space(1) 
    If trim$( x2656.CheckMaterialType ) = "" Then x2656.CheckMaterialType = Space(1) 
    If trim$( x2656.CheckMarketType ) = "" Then x2656.CheckMarketType = Space(1) 
    If trim$( x2656.InvoiceNo ) = "" Then x2656.InvoiceNo = Space(1) 
    If trim$( x2656.seUnitPrice ) = "" Then x2656.seUnitPrice = Space(1) 
    If trim$( x2656.cdUnitPrice ) = "" Then x2656.cdUnitPrice = Space(1) 
    If trim$( x2656.DateExchange ) = "" Then x2656.DateExchange = Space(1) 
    If trim$( x2656.PriceExchange ) = "" Then x2656.PriceExchange = 0 
    If trim$( x2656.ProductInboundNo ) = "" Then x2656.ProductInboundNo = Space(1) 
    If trim$( x2656.ProductInboundSeq ) = "" Then x2656.ProductInboundSeq = Space(1) 
    If trim$( x2656.DateOutbound ) = "" Then x2656.DateOutbound = Space(1) 
    If trim$( x2656.InchargeOutbound ) = "" Then x2656.InchargeOutbound = Space(1) 
    If trim$( x2656.FactOrderNo ) = "" Then x2656.FactOrderNo = Space(1) 
    If trim$( x2656.FactOrderSeq ) = "" Then x2656.FactOrderSeq = 0 
    If trim$( x2656.OrderNo ) = "" Then x2656.OrderNo = Space(1) 
    If trim$( x2656.OrderNoSeq ) = "" Then x2656.OrderNoSeq = Space(1) 
    If trim$( x2656.PalletNo ) = "" Then x2656.PalletNo = Space(1) 
    If trim$( x2656.StockNo ) = "" Then x2656.StockNo = Space(1) 
    If trim$( x2656.BarcodeInnerBox ) = "" Then x2656.BarcodeInnerBox = Space(1) 
    If trim$( x2656.BarcodePacking ) = "" Then x2656.BarcodePacking = Space(1) 
    If trim$( x2656.BatchNo ) = "" Then x2656.BatchNo = Space(1) 
    If trim$( x2656.CheckComplete ) = "" Then x2656.CheckComplete = Space(1) 
    If trim$( x2656.PriceShipping ) = "" Then x2656.PriceShipping = 0 
    If trim$( x2656.PriceShippingVND ) = "" Then x2656.PriceShippingVND = 0 
    If trim$( x2656.AmountShipping ) = "" Then x2656.AmountShipping = 0 
    If trim$( x2656.AmountShippingVND ) = "" Then x2656.AmountShippingVND = 0 
    If trim$( x2656.QtyProductOutbound ) = "" Then x2656.QtyProductOutbound = 0 
    If trim$( x2656.IsPosted ) = "" Then x2656.IsPosted = Space(1) 
    If trim$( x2656.DatePosted ) = "" Then x2656.DatePosted = Space(1) 
    If trim$( x2656.DateInsert ) = "" Then x2656.DateInsert = Space(1) 
    If trim$( x2656.DateUpdate ) = "" Then x2656.DateUpdate = Space(1) 
    If trim$( x2656.InchargeInsert ) = "" Then x2656.InchargeInsert = Space(1) 
    If trim$( x2656.InchargeUpdate ) = "" Then x2656.InchargeUpdate = Space(1) 
    If trim$( x2656.Remark ) = "" Then x2656.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K2656_MOVE(rs2656 As SqlClient.SqlDataReader)
Try

    call D2656_CLEAR()   

    If IsdbNull(rs2656!K2656_ProductOutboundNo) = False Then D2656.ProductOutboundNo = Trim$(rs2656!K2656_ProductOutboundNo)
    If IsdbNull(rs2656!K2656_ProductOutboundSeq) = False Then D2656.ProductOutboundSeq = Trim$(rs2656!K2656_ProductOutboundSeq)
    If IsdbNull(rs2656!K2656_CustomerCode) = False Then D2656.CustomerCode = Trim$(rs2656!K2656_CustomerCode)
    If IsdbNull(rs2656!K2656_SupplierCode) = False Then D2656.SupplierCode = Trim$(rs2656!K2656_SupplierCode)
    If IsdbNull(rs2656!K2656_seFactory) = False Then D2656.seFactory = Trim$(rs2656!K2656_seFactory)
    If IsdbNull(rs2656!K2656_cdFactory) = False Then D2656.cdFactory = Trim$(rs2656!K2656_cdFactory)
    If IsdbNull(rs2656!K2656_ShoesCode) = False Then D2656.ShoesCode = Trim$(rs2656!K2656_ShoesCode)
    If IsdbNull(rs2656!K2656_SizeRange) = False Then D2656.SizeRange = Trim$(rs2656!K2656_SizeRange)
    If IsdbNull(rs2656!K2656_CheckOutBoundMaterial) = False Then D2656.CheckOutBoundMaterial = Trim$(rs2656!K2656_CheckOutBoundMaterial)
    If IsdbNull(rs2656!K2656_CheckMaterialType) = False Then D2656.CheckMaterialType = Trim$(rs2656!K2656_CheckMaterialType)
    If IsdbNull(rs2656!K2656_CheckMarketType) = False Then D2656.CheckMarketType = Trim$(rs2656!K2656_CheckMarketType)
    If IsdbNull(rs2656!K2656_InvoiceNo) = False Then D2656.InvoiceNo = Trim$(rs2656!K2656_InvoiceNo)
    If IsdbNull(rs2656!K2656_seUnitPrice) = False Then D2656.seUnitPrice = Trim$(rs2656!K2656_seUnitPrice)
    If IsdbNull(rs2656!K2656_cdUnitPrice) = False Then D2656.cdUnitPrice = Trim$(rs2656!K2656_cdUnitPrice)
    If IsdbNull(rs2656!K2656_DateExchange) = False Then D2656.DateExchange = Trim$(rs2656!K2656_DateExchange)
    If IsdbNull(rs2656!K2656_PriceExchange) = False Then D2656.PriceExchange = Trim$(rs2656!K2656_PriceExchange)
    If IsdbNull(rs2656!K2656_ProductInboundNo) = False Then D2656.ProductInboundNo = Trim$(rs2656!K2656_ProductInboundNo)
    If IsdbNull(rs2656!K2656_ProductInboundSeq) = False Then D2656.ProductInboundSeq = Trim$(rs2656!K2656_ProductInboundSeq)
    If IsdbNull(rs2656!K2656_DateOutbound) = False Then D2656.DateOutbound = Trim$(rs2656!K2656_DateOutbound)
    If IsdbNull(rs2656!K2656_InchargeOutbound) = False Then D2656.InchargeOutbound = Trim$(rs2656!K2656_InchargeOutbound)
    If IsdbNull(rs2656!K2656_FactOrderNo) = False Then D2656.FactOrderNo = Trim$(rs2656!K2656_FactOrderNo)
    If IsdbNull(rs2656!K2656_FactOrderSeq) = False Then D2656.FactOrderSeq = Trim$(rs2656!K2656_FactOrderSeq)
    If IsdbNull(rs2656!K2656_OrderNo) = False Then D2656.OrderNo = Trim$(rs2656!K2656_OrderNo)
    If IsdbNull(rs2656!K2656_OrderNoSeq) = False Then D2656.OrderNoSeq = Trim$(rs2656!K2656_OrderNoSeq)
    If IsdbNull(rs2656!K2656_PalletNo) = False Then D2656.PalletNo = Trim$(rs2656!K2656_PalletNo)
    If IsdbNull(rs2656!K2656_StockNo) = False Then D2656.StockNo = Trim$(rs2656!K2656_StockNo)
    If IsdbNull(rs2656!K2656_BarcodeInnerBox) = False Then D2656.BarcodeInnerBox = Trim$(rs2656!K2656_BarcodeInnerBox)
    If IsdbNull(rs2656!K2656_BarcodePacking) = False Then D2656.BarcodePacking = Trim$(rs2656!K2656_BarcodePacking)
    If IsdbNull(rs2656!K2656_BatchNo) = False Then D2656.BatchNo = Trim$(rs2656!K2656_BatchNo)
    If IsdbNull(rs2656!K2656_CheckComplete) = False Then D2656.CheckComplete = Trim$(rs2656!K2656_CheckComplete)
    If IsdbNull(rs2656!K2656_PriceShipping) = False Then D2656.PriceShipping = Trim$(rs2656!K2656_PriceShipping)
    If IsdbNull(rs2656!K2656_PriceShippingVND) = False Then D2656.PriceShippingVND = Trim$(rs2656!K2656_PriceShippingVND)
    If IsdbNull(rs2656!K2656_AmountShipping) = False Then D2656.AmountShipping = Trim$(rs2656!K2656_AmountShipping)
    If IsdbNull(rs2656!K2656_AmountShippingVND) = False Then D2656.AmountShippingVND = Trim$(rs2656!K2656_AmountShippingVND)
    If IsdbNull(rs2656!K2656_QtyProductOutbound) = False Then D2656.QtyProductOutbound = Trim$(rs2656!K2656_QtyProductOutbound)
    If IsdbNull(rs2656!K2656_IsPosted) = False Then D2656.IsPosted = Trim$(rs2656!K2656_IsPosted)
    If IsdbNull(rs2656!K2656_DatePosted) = False Then D2656.DatePosted = Trim$(rs2656!K2656_DatePosted)
    If IsdbNull(rs2656!K2656_DateInsert) = False Then D2656.DateInsert = Trim$(rs2656!K2656_DateInsert)
    If IsdbNull(rs2656!K2656_DateUpdate) = False Then D2656.DateUpdate = Trim$(rs2656!K2656_DateUpdate)
    If IsdbNull(rs2656!K2656_InchargeInsert) = False Then D2656.InchargeInsert = Trim$(rs2656!K2656_InchargeInsert)
    If IsdbNull(rs2656!K2656_InchargeUpdate) = False Then D2656.InchargeUpdate = Trim$(rs2656!K2656_InchargeUpdate)
    If IsdbNull(rs2656!K2656_Remark) = False Then D2656.Remark = Trim$(rs2656!K2656_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K2656_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K2656_MOVE(rs2656 As DataRow)
Try

    call D2656_CLEAR()   

    If IsdbNull(rs2656!K2656_ProductOutboundNo) = False Then D2656.ProductOutboundNo = Trim$(rs2656!K2656_ProductOutboundNo)
    If IsdbNull(rs2656!K2656_ProductOutboundSeq) = False Then D2656.ProductOutboundSeq = Trim$(rs2656!K2656_ProductOutboundSeq)
    If IsdbNull(rs2656!K2656_CustomerCode) = False Then D2656.CustomerCode = Trim$(rs2656!K2656_CustomerCode)
    If IsdbNull(rs2656!K2656_SupplierCode) = False Then D2656.SupplierCode = Trim$(rs2656!K2656_SupplierCode)
    If IsdbNull(rs2656!K2656_seFactory) = False Then D2656.seFactory = Trim$(rs2656!K2656_seFactory)
    If IsdbNull(rs2656!K2656_cdFactory) = False Then D2656.cdFactory = Trim$(rs2656!K2656_cdFactory)
    If IsdbNull(rs2656!K2656_ShoesCode) = False Then D2656.ShoesCode = Trim$(rs2656!K2656_ShoesCode)
    If IsdbNull(rs2656!K2656_SizeRange) = False Then D2656.SizeRange = Trim$(rs2656!K2656_SizeRange)
    If IsdbNull(rs2656!K2656_CheckOutBoundMaterial) = False Then D2656.CheckOutBoundMaterial = Trim$(rs2656!K2656_CheckOutBoundMaterial)
    If IsdbNull(rs2656!K2656_CheckMaterialType) = False Then D2656.CheckMaterialType = Trim$(rs2656!K2656_CheckMaterialType)
    If IsdbNull(rs2656!K2656_CheckMarketType) = False Then D2656.CheckMarketType = Trim$(rs2656!K2656_CheckMarketType)
    If IsdbNull(rs2656!K2656_InvoiceNo) = False Then D2656.InvoiceNo = Trim$(rs2656!K2656_InvoiceNo)
    If IsdbNull(rs2656!K2656_seUnitPrice) = False Then D2656.seUnitPrice = Trim$(rs2656!K2656_seUnitPrice)
    If IsdbNull(rs2656!K2656_cdUnitPrice) = False Then D2656.cdUnitPrice = Trim$(rs2656!K2656_cdUnitPrice)
    If IsdbNull(rs2656!K2656_DateExchange) = False Then D2656.DateExchange = Trim$(rs2656!K2656_DateExchange)
    If IsdbNull(rs2656!K2656_PriceExchange) = False Then D2656.PriceExchange = Trim$(rs2656!K2656_PriceExchange)
    If IsdbNull(rs2656!K2656_ProductInboundNo) = False Then D2656.ProductInboundNo = Trim$(rs2656!K2656_ProductInboundNo)
    If IsdbNull(rs2656!K2656_ProductInboundSeq) = False Then D2656.ProductInboundSeq = Trim$(rs2656!K2656_ProductInboundSeq)
    If IsdbNull(rs2656!K2656_DateOutbound) = False Then D2656.DateOutbound = Trim$(rs2656!K2656_DateOutbound)
    If IsdbNull(rs2656!K2656_InchargeOutbound) = False Then D2656.InchargeOutbound = Trim$(rs2656!K2656_InchargeOutbound)
    If IsdbNull(rs2656!K2656_FactOrderNo) = False Then D2656.FactOrderNo = Trim$(rs2656!K2656_FactOrderNo)
    If IsdbNull(rs2656!K2656_FactOrderSeq) = False Then D2656.FactOrderSeq = Trim$(rs2656!K2656_FactOrderSeq)
    If IsdbNull(rs2656!K2656_OrderNo) = False Then D2656.OrderNo = Trim$(rs2656!K2656_OrderNo)
    If IsdbNull(rs2656!K2656_OrderNoSeq) = False Then D2656.OrderNoSeq = Trim$(rs2656!K2656_OrderNoSeq)
    If IsdbNull(rs2656!K2656_PalletNo) = False Then D2656.PalletNo = Trim$(rs2656!K2656_PalletNo)
    If IsdbNull(rs2656!K2656_StockNo) = False Then D2656.StockNo = Trim$(rs2656!K2656_StockNo)
    If IsdbNull(rs2656!K2656_BarcodeInnerBox) = False Then D2656.BarcodeInnerBox = Trim$(rs2656!K2656_BarcodeInnerBox)
    If IsdbNull(rs2656!K2656_BarcodePacking) = False Then D2656.BarcodePacking = Trim$(rs2656!K2656_BarcodePacking)
    If IsdbNull(rs2656!K2656_BatchNo) = False Then D2656.BatchNo = Trim$(rs2656!K2656_BatchNo)
    If IsdbNull(rs2656!K2656_CheckComplete) = False Then D2656.CheckComplete = Trim$(rs2656!K2656_CheckComplete)
    If IsdbNull(rs2656!K2656_PriceShipping) = False Then D2656.PriceShipping = Trim$(rs2656!K2656_PriceShipping)
    If IsdbNull(rs2656!K2656_PriceShippingVND) = False Then D2656.PriceShippingVND = Trim$(rs2656!K2656_PriceShippingVND)
    If IsdbNull(rs2656!K2656_AmountShipping) = False Then D2656.AmountShipping = Trim$(rs2656!K2656_AmountShipping)
    If IsdbNull(rs2656!K2656_AmountShippingVND) = False Then D2656.AmountShippingVND = Trim$(rs2656!K2656_AmountShippingVND)
    If IsdbNull(rs2656!K2656_QtyProductOutbound) = False Then D2656.QtyProductOutbound = Trim$(rs2656!K2656_QtyProductOutbound)
    If IsdbNull(rs2656!K2656_IsPosted) = False Then D2656.IsPosted = Trim$(rs2656!K2656_IsPosted)
    If IsdbNull(rs2656!K2656_DatePosted) = False Then D2656.DatePosted = Trim$(rs2656!K2656_DatePosted)
    If IsdbNull(rs2656!K2656_DateInsert) = False Then D2656.DateInsert = Trim$(rs2656!K2656_DateInsert)
    If IsdbNull(rs2656!K2656_DateUpdate) = False Then D2656.DateUpdate = Trim$(rs2656!K2656_DateUpdate)
    If IsdbNull(rs2656!K2656_InchargeInsert) = False Then D2656.InchargeInsert = Trim$(rs2656!K2656_InchargeInsert)
    If IsdbNull(rs2656!K2656_InchargeUpdate) = False Then D2656.InchargeUpdate = Trim$(rs2656!K2656_InchargeUpdate)
    If IsdbNull(rs2656!K2656_Remark) = False Then D2656.Remark = Trim$(rs2656!K2656_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K2656_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K2656_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z2656 As T2656_AREA, PRODUCTOUTBOUNDNO AS String, PRODUCTOUTBOUNDSEQ AS String) as Boolean

K2656_MOVE = False

Try
    If READ_PFK2656(PRODUCTOUTBOUNDNO, PRODUCTOUTBOUNDSEQ) = True Then
                z2656 = D2656
		K2656_MOVE = True
		else
	z2656 = nothing
     End If

     If  getColumIndex(spr,"ProductOutboundNo") > -1 then z2656.ProductOutboundNo = getDataM(spr, getColumIndex(spr,"ProductOutboundNo"), xRow)
     If  getColumIndex(spr,"ProductOutboundSeq") > -1 then z2656.ProductOutboundSeq = getDataM(spr, getColumIndex(spr,"ProductOutboundSeq"), xRow)
     If  getColumIndex(spr,"CustomerCode") > -1 then z2656.CustomerCode = getDataM(spr, getColumIndex(spr,"CustomerCode"), xRow)
     If  getColumIndex(spr,"SupplierCode") > -1 then z2656.SupplierCode = getDataM(spr, getColumIndex(spr,"SupplierCode"), xRow)
     If  getColumIndex(spr,"seFactory") > -1 then z2656.seFactory = getDataM(spr, getColumIndex(spr,"seFactory"), xRow)
     If  getColumIndex(spr,"cdFactory") > -1 then z2656.cdFactory = getDataM(spr, getColumIndex(spr,"cdFactory"), xRow)
     If  getColumIndex(spr,"ShoesCode") > -1 then z2656.ShoesCode = getDataM(spr, getColumIndex(spr,"ShoesCode"), xRow)
     If  getColumIndex(spr,"SizeRange") > -1 then z2656.SizeRange = getDataM(spr, getColumIndex(spr,"SizeRange"), xRow)
     If  getColumIndex(spr,"CheckOutBoundMaterial") > -1 then z2656.CheckOutBoundMaterial = getDataM(spr, getColumIndex(spr,"CheckOutBoundMaterial"), xRow)
     If  getColumIndex(spr,"CheckMaterialType") > -1 then z2656.CheckMaterialType = getDataM(spr, getColumIndex(spr,"CheckMaterialType"), xRow)
     If  getColumIndex(spr,"CheckMarketType") > -1 then z2656.CheckMarketType = getDataM(spr, getColumIndex(spr,"CheckMarketType"), xRow)
     If  getColumIndex(spr,"InvoiceNo") > -1 then z2656.InvoiceNo = getDataM(spr, getColumIndex(spr,"InvoiceNo"), xRow)
     If  getColumIndex(spr,"seUnitPrice") > -1 then z2656.seUnitPrice = getDataM(spr, getColumIndex(spr,"seUnitPrice"), xRow)
     If  getColumIndex(spr,"cdUnitPrice") > -1 then z2656.cdUnitPrice = getDataM(spr, getColumIndex(spr,"cdUnitPrice"), xRow)
     If  getColumIndex(spr,"DateExchange") > -1 then z2656.DateExchange = getDataM(spr, getColumIndex(spr,"DateExchange"), xRow)
     If  getColumIndex(spr,"PriceExchange") > -1 then z2656.PriceExchange = getDataM(spr, getColumIndex(spr,"PriceExchange"), xRow)
     If  getColumIndex(spr,"ProductInboundNo") > -1 then z2656.ProductInboundNo = getDataM(spr, getColumIndex(spr,"ProductInboundNo"), xRow)
     If  getColumIndex(spr,"ProductInboundSeq") > -1 then z2656.ProductInboundSeq = getDataM(spr, getColumIndex(spr,"ProductInboundSeq"), xRow)
     If  getColumIndex(spr,"DateOutbound") > -1 then z2656.DateOutbound = getDataM(spr, getColumIndex(spr,"DateOutbound"), xRow)
     If  getColumIndex(spr,"InchargeOutbound") > -1 then z2656.InchargeOutbound = getDataM(spr, getColumIndex(spr,"InchargeOutbound"), xRow)
     If  getColumIndex(spr,"FactOrderNo") > -1 then z2656.FactOrderNo = getDataM(spr, getColumIndex(spr,"FactOrderNo"), xRow)
     If  getColumIndex(spr,"FactOrderSeq") > -1 then z2656.FactOrderSeq = getDataM(spr, getColumIndex(spr,"FactOrderSeq"), xRow)
     If  getColumIndex(spr,"OrderNo") > -1 then z2656.OrderNo = getDataM(spr, getColumIndex(spr,"OrderNo"), xRow)
     If  getColumIndex(spr,"OrderNoSeq") > -1 then z2656.OrderNoSeq = getDataM(spr, getColumIndex(spr,"OrderNoSeq"), xRow)
     If  getColumIndex(spr,"PalletNo") > -1 then z2656.PalletNo = getDataM(spr, getColumIndex(spr,"PalletNo"), xRow)
     If  getColumIndex(spr,"StockNo") > -1 then z2656.StockNo = getDataM(spr, getColumIndex(spr,"StockNo"), xRow)
     If  getColumIndex(spr,"BarcodeInnerBox") > -1 then z2656.BarcodeInnerBox = getDataM(spr, getColumIndex(spr,"BarcodeInnerBox"), xRow)
     If  getColumIndex(spr,"BarcodePacking") > -1 then z2656.BarcodePacking = getDataM(spr, getColumIndex(spr,"BarcodePacking"), xRow)
     If  getColumIndex(spr,"BatchNo") > -1 then z2656.BatchNo = getDataM(spr, getColumIndex(spr,"BatchNo"), xRow)
     If  getColumIndex(spr,"CheckComplete") > -1 then z2656.CheckComplete = getDataM(spr, getColumIndex(spr,"CheckComplete"), xRow)
     If  getColumIndex(spr,"PriceShipping") > -1 then z2656.PriceShipping = getDataM(spr, getColumIndex(spr,"PriceShipping"), xRow)
     If  getColumIndex(spr,"PriceShippingVND") > -1 then z2656.PriceShippingVND = getDataM(spr, getColumIndex(spr,"PriceShippingVND"), xRow)
     If  getColumIndex(spr,"AmountShipping") > -1 then z2656.AmountShipping = getDataM(spr, getColumIndex(spr,"AmountShipping"), xRow)
     If  getColumIndex(spr,"AmountShippingVND") > -1 then z2656.AmountShippingVND = getDataM(spr, getColumIndex(spr,"AmountShippingVND"), xRow)
     If  getColumIndex(spr,"QtyProductOutbound") > -1 then z2656.QtyProductOutbound = getDataM(spr, getColumIndex(spr,"QtyProductOutbound"), xRow)
     If  getColumIndex(spr,"IsPosted") > -1 then z2656.IsPosted = getDataM(spr, getColumIndex(spr,"IsPosted"), xRow)
     If  getColumIndex(spr,"DatePosted") > -1 then z2656.DatePosted = getDataM(spr, getColumIndex(spr,"DatePosted"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z2656.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z2656.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z2656.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z2656.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z2656.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K2656_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K2656_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z2656 As T2656_AREA,CheckClear as Boolean,PRODUCTOUTBOUNDNO AS String, PRODUCTOUTBOUNDSEQ AS String) as Boolean

K2656_MOVE = False

Try
    If READ_PFK2656(PRODUCTOUTBOUNDNO, PRODUCTOUTBOUNDSEQ) = True Then
                z2656 = D2656
		K2656_MOVE = True
		else
	If CheckClear  = True then z2656 = nothing
     End If

     If  getColumIndex(spr,"ProductOutboundNo") > -1 then z2656.ProductOutboundNo = getDataM(spr, getColumIndex(spr,"ProductOutboundNo"), xRow)
     If  getColumIndex(spr,"ProductOutboundSeq") > -1 then z2656.ProductOutboundSeq = getDataM(spr, getColumIndex(spr,"ProductOutboundSeq"), xRow)
     If  getColumIndex(spr,"CustomerCode") > -1 then z2656.CustomerCode = getDataM(spr, getColumIndex(spr,"CustomerCode"), xRow)
     If  getColumIndex(spr,"SupplierCode") > -1 then z2656.SupplierCode = getDataM(spr, getColumIndex(spr,"SupplierCode"), xRow)
     If  getColumIndex(spr,"seFactory") > -1 then z2656.seFactory = getDataM(spr, getColumIndex(spr,"seFactory"), xRow)
     If  getColumIndex(spr,"cdFactory") > -1 then z2656.cdFactory = getDataM(spr, getColumIndex(spr,"cdFactory"), xRow)
     If  getColumIndex(spr,"ShoesCode") > -1 then z2656.ShoesCode = getDataM(spr, getColumIndex(spr,"ShoesCode"), xRow)
     If  getColumIndex(spr,"SizeRange") > -1 then z2656.SizeRange = getDataM(spr, getColumIndex(spr,"SizeRange"), xRow)
     If  getColumIndex(spr,"CheckOutBoundMaterial") > -1 then z2656.CheckOutBoundMaterial = getDataM(spr, getColumIndex(spr,"CheckOutBoundMaterial"), xRow)
     If  getColumIndex(spr,"CheckMaterialType") > -1 then z2656.CheckMaterialType = getDataM(spr, getColumIndex(spr,"CheckMaterialType"), xRow)
     If  getColumIndex(spr,"CheckMarketType") > -1 then z2656.CheckMarketType = getDataM(spr, getColumIndex(spr,"CheckMarketType"), xRow)
     If  getColumIndex(spr,"InvoiceNo") > -1 then z2656.InvoiceNo = getDataM(spr, getColumIndex(spr,"InvoiceNo"), xRow)
     If  getColumIndex(spr,"seUnitPrice") > -1 then z2656.seUnitPrice = getDataM(spr, getColumIndex(spr,"seUnitPrice"), xRow)
     If  getColumIndex(spr,"cdUnitPrice") > -1 then z2656.cdUnitPrice = getDataM(spr, getColumIndex(spr,"cdUnitPrice"), xRow)
     If  getColumIndex(spr,"DateExchange") > -1 then z2656.DateExchange = getDataM(spr, getColumIndex(spr,"DateExchange"), xRow)
     If  getColumIndex(spr,"PriceExchange") > -1 then z2656.PriceExchange = getDataM(spr, getColumIndex(spr,"PriceExchange"), xRow)
     If  getColumIndex(spr,"ProductInboundNo") > -1 then z2656.ProductInboundNo = getDataM(spr, getColumIndex(spr,"ProductInboundNo"), xRow)
     If  getColumIndex(spr,"ProductInboundSeq") > -1 then z2656.ProductInboundSeq = getDataM(spr, getColumIndex(spr,"ProductInboundSeq"), xRow)
     If  getColumIndex(spr,"DateOutbound") > -1 then z2656.DateOutbound = getDataM(spr, getColumIndex(spr,"DateOutbound"), xRow)
     If  getColumIndex(spr,"InchargeOutbound") > -1 then z2656.InchargeOutbound = getDataM(spr, getColumIndex(spr,"InchargeOutbound"), xRow)
     If  getColumIndex(spr,"FactOrderNo") > -1 then z2656.FactOrderNo = getDataM(spr, getColumIndex(spr,"FactOrderNo"), xRow)
     If  getColumIndex(spr,"FactOrderSeq") > -1 then z2656.FactOrderSeq = getDataM(spr, getColumIndex(spr,"FactOrderSeq"), xRow)
     If  getColumIndex(spr,"OrderNo") > -1 then z2656.OrderNo = getDataM(spr, getColumIndex(spr,"OrderNo"), xRow)
     If  getColumIndex(spr,"OrderNoSeq") > -1 then z2656.OrderNoSeq = getDataM(spr, getColumIndex(spr,"OrderNoSeq"), xRow)
     If  getColumIndex(spr,"PalletNo") > -1 then z2656.PalletNo = getDataM(spr, getColumIndex(spr,"PalletNo"), xRow)
     If  getColumIndex(spr,"StockNo") > -1 then z2656.StockNo = getDataM(spr, getColumIndex(spr,"StockNo"), xRow)
     If  getColumIndex(spr,"BarcodeInnerBox") > -1 then z2656.BarcodeInnerBox = getDataM(spr, getColumIndex(spr,"BarcodeInnerBox"), xRow)
     If  getColumIndex(spr,"BarcodePacking") > -1 then z2656.BarcodePacking = getDataM(spr, getColumIndex(spr,"BarcodePacking"), xRow)
     If  getColumIndex(spr,"BatchNo") > -1 then z2656.BatchNo = getDataM(spr, getColumIndex(spr,"BatchNo"), xRow)
     If  getColumIndex(spr,"CheckComplete") > -1 then z2656.CheckComplete = getDataM(spr, getColumIndex(spr,"CheckComplete"), xRow)
     If  getColumIndex(spr,"PriceShipping") > -1 then z2656.PriceShipping = getDataM(spr, getColumIndex(spr,"PriceShipping"), xRow)
     If  getColumIndex(spr,"PriceShippingVND") > -1 then z2656.PriceShippingVND = getDataM(spr, getColumIndex(spr,"PriceShippingVND"), xRow)
     If  getColumIndex(spr,"AmountShipping") > -1 then z2656.AmountShipping = getDataM(spr, getColumIndex(spr,"AmountShipping"), xRow)
     If  getColumIndex(spr,"AmountShippingVND") > -1 then z2656.AmountShippingVND = getDataM(spr, getColumIndex(spr,"AmountShippingVND"), xRow)
     If  getColumIndex(spr,"QtyProductOutbound") > -1 then z2656.QtyProductOutbound = getDataM(spr, getColumIndex(spr,"QtyProductOutbound"), xRow)
     If  getColumIndex(spr,"IsPosted") > -1 then z2656.IsPosted = getDataM(spr, getColumIndex(spr,"IsPosted"), xRow)
     If  getColumIndex(spr,"DatePosted") > -1 then z2656.DatePosted = getDataM(spr, getColumIndex(spr,"DatePosted"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z2656.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z2656.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z2656.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z2656.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z2656.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K2656_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K2656_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z2656 As T2656_AREA, Job as String, PRODUCTOUTBOUNDNO AS String, PRODUCTOUTBOUNDSEQ AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K2656_MOVE = False

Try
    If READ_PFK2656(PRODUCTOUTBOUNDNO, PRODUCTOUTBOUNDSEQ) = True Then
                z2656 = D2656
		K2656_MOVE = True
		else
	z2656 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK2656")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "PRODUCTOUTBOUNDNO":z2656.ProductOutboundNo = Children(i).Code
   Case "PRODUCTOUTBOUNDSEQ":z2656.ProductOutboundSeq = Children(i).Code
   Case "CUSTOMERCODE":z2656.CustomerCode = Children(i).Code
   Case "SUPPLIERCODE":z2656.SupplierCode = Children(i).Code
   Case "SEFACTORY":z2656.seFactory = Children(i).Code
   Case "CDFACTORY":z2656.cdFactory = Children(i).Code
   Case "SHOESCODE":z2656.ShoesCode = Children(i).Code
   Case "SIZERANGE":z2656.SizeRange = Children(i).Code
   Case "CHECKOUTBOUNDMATERIAL":z2656.CheckOutBoundMaterial = Children(i).Code
   Case "CHECKMATERIALTYPE":z2656.CheckMaterialType = Children(i).Code
   Case "CHECKMARKETTYPE":z2656.CheckMarketType = Children(i).Code
   Case "INVOICENO":z2656.InvoiceNo = Children(i).Code
   Case "SEUNITPRICE":z2656.seUnitPrice = Children(i).Code
   Case "CDUNITPRICE":z2656.cdUnitPrice = Children(i).Code
   Case "DATEEXCHANGE":z2656.DateExchange = Children(i).Code
   Case "PRICEEXCHANGE":z2656.PriceExchange = Children(i).Code
   Case "PRODUCTINBOUNDNO":z2656.ProductInboundNo = Children(i).Code
   Case "PRODUCTINBOUNDSEQ":z2656.ProductInboundSeq = Children(i).Code
   Case "DATEOUTBOUND":z2656.DateOutbound = Children(i).Code
   Case "INCHARGEOUTBOUND":z2656.InchargeOutbound = Children(i).Code
   Case "FACTORDERNO":z2656.FactOrderNo = Children(i).Code
   Case "FACTORDERSEQ":z2656.FactOrderSeq = Children(i).Code
   Case "ORDERNO":z2656.OrderNo = Children(i).Code
   Case "ORDERNOSEQ":z2656.OrderNoSeq = Children(i).Code
   Case "PALLETNO":z2656.PalletNo = Children(i).Code
   Case "STOCKNO":z2656.StockNo = Children(i).Code
   Case "BARCODEINNERBOX":z2656.BarcodeInnerBox = Children(i).Code
   Case "BARCODEPACKING":z2656.BarcodePacking = Children(i).Code
   Case "BATCHNO":z2656.BatchNo = Children(i).Code
   Case "CHECKCOMPLETE":z2656.CheckComplete = Children(i).Code
   Case "PRICESHIPPING":z2656.PriceShipping = Children(i).Code
   Case "PRICESHIPPINGVND":z2656.PriceShippingVND = Children(i).Code
   Case "AMOUNTSHIPPING":z2656.AmountShipping = Children(i).Code
   Case "AMOUNTSHIPPINGVND":z2656.AmountShippingVND = Children(i).Code
   Case "QTYPRODUCTOUTBOUND":z2656.QtyProductOutbound = Children(i).Code
   Case "ISPOSTED":z2656.IsPosted = Children(i).Code
   Case "DATEPOSTED":z2656.DatePosted = Children(i).Code
   Case "DATEINSERT":z2656.DateInsert = Children(i).Code
   Case "DATEUPDATE":z2656.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z2656.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z2656.InchargeUpdate = Children(i).Code
   Case "REMARK":z2656.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "PRODUCTOUTBOUNDNO":z2656.ProductOutboundNo = Children(i).Data
   Case "PRODUCTOUTBOUNDSEQ":z2656.ProductOutboundSeq = Children(i).Data
   Case "CUSTOMERCODE":z2656.CustomerCode = Children(i).Data
   Case "SUPPLIERCODE":z2656.SupplierCode = Children(i).Data
   Case "SEFACTORY":z2656.seFactory = Children(i).Data
   Case "CDFACTORY":z2656.cdFactory = Children(i).Data
   Case "SHOESCODE":z2656.ShoesCode = Children(i).Data
   Case "SIZERANGE":z2656.SizeRange = Children(i).Data
   Case "CHECKOUTBOUNDMATERIAL":z2656.CheckOutBoundMaterial = Children(i).Data
   Case "CHECKMATERIALTYPE":z2656.CheckMaterialType = Children(i).Data
   Case "CHECKMARKETTYPE":z2656.CheckMarketType = Children(i).Data
   Case "INVOICENO":z2656.InvoiceNo = Children(i).Data
   Case "SEUNITPRICE":z2656.seUnitPrice = Children(i).Data
   Case "CDUNITPRICE":z2656.cdUnitPrice = Children(i).Data
   Case "DATEEXCHANGE":z2656.DateExchange = Children(i).Data
   Case "PRICEEXCHANGE":z2656.PriceExchange = Children(i).Data
   Case "PRODUCTINBOUNDNO":z2656.ProductInboundNo = Children(i).Data
   Case "PRODUCTINBOUNDSEQ":z2656.ProductInboundSeq = Children(i).Data
   Case "DATEOUTBOUND":z2656.DateOutbound = Children(i).Data
   Case "INCHARGEOUTBOUND":z2656.InchargeOutbound = Children(i).Data
   Case "FACTORDERNO":z2656.FactOrderNo = Children(i).Data
   Case "FACTORDERSEQ":z2656.FactOrderSeq = Children(i).Data
   Case "ORDERNO":z2656.OrderNo = Children(i).Data
   Case "ORDERNOSEQ":z2656.OrderNoSeq = Children(i).Data
   Case "PALLETNO":z2656.PalletNo = Children(i).Data
   Case "STOCKNO":z2656.StockNo = Children(i).Data
   Case "BARCODEINNERBOX":z2656.BarcodeInnerBox = Children(i).Data
   Case "BARCODEPACKING":z2656.BarcodePacking = Children(i).Data
   Case "BATCHNO":z2656.BatchNo = Children(i).Data
   Case "CHECKCOMPLETE":z2656.CheckComplete = Children(i).Data
   Case "PRICESHIPPING":z2656.PriceShipping = Children(i).Data
   Case "PRICESHIPPINGVND":z2656.PriceShippingVND = Children(i).Data
   Case "AMOUNTSHIPPING":z2656.AmountShipping = Children(i).Data
   Case "AMOUNTSHIPPINGVND":z2656.AmountShippingVND = Children(i).Data
   Case "QTYPRODUCTOUTBOUND":z2656.QtyProductOutbound = Children(i).Data
   Case "ISPOSTED":z2656.IsPosted = Children(i).Data
   Case "DATEPOSTED":z2656.DatePosted = Children(i).Data
   Case "DATEINSERT":z2656.DateInsert = Children(i).Data
   Case "DATEUPDATE":z2656.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z2656.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z2656.InchargeUpdate = Children(i).Data
   Case "REMARK":z2656.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K2656_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K2656_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z2656 As T2656_AREA, Job as String, CheckClear as Boolean, PRODUCTOUTBOUNDNO AS String, PRODUCTOUTBOUNDSEQ AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K2656_MOVE = False

Try
    If READ_PFK2656(PRODUCTOUTBOUNDNO, PRODUCTOUTBOUNDSEQ) = True Then
                z2656 = D2656
		K2656_MOVE = True
		else
	If CheckClear  = True then z2656 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK2656")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "PRODUCTOUTBOUNDNO":z2656.ProductOutboundNo = Children(i).Code
   Case "PRODUCTOUTBOUNDSEQ":z2656.ProductOutboundSeq = Children(i).Code
   Case "CUSTOMERCODE":z2656.CustomerCode = Children(i).Code
   Case "SUPPLIERCODE":z2656.SupplierCode = Children(i).Code
   Case "SEFACTORY":z2656.seFactory = Children(i).Code
   Case "CDFACTORY":z2656.cdFactory = Children(i).Code
   Case "SHOESCODE":z2656.ShoesCode = Children(i).Code
   Case "SIZERANGE":z2656.SizeRange = Children(i).Code
   Case "CHECKOUTBOUNDMATERIAL":z2656.CheckOutBoundMaterial = Children(i).Code
   Case "CHECKMATERIALTYPE":z2656.CheckMaterialType = Children(i).Code
   Case "CHECKMARKETTYPE":z2656.CheckMarketType = Children(i).Code
   Case "INVOICENO":z2656.InvoiceNo = Children(i).Code
   Case "SEUNITPRICE":z2656.seUnitPrice = Children(i).Code
   Case "CDUNITPRICE":z2656.cdUnitPrice = Children(i).Code
   Case "DATEEXCHANGE":z2656.DateExchange = Children(i).Code
   Case "PRICEEXCHANGE":z2656.PriceExchange = Children(i).Code
   Case "PRODUCTINBOUNDNO":z2656.ProductInboundNo = Children(i).Code
   Case "PRODUCTINBOUNDSEQ":z2656.ProductInboundSeq = Children(i).Code
   Case "DATEOUTBOUND":z2656.DateOutbound = Children(i).Code
   Case "INCHARGEOUTBOUND":z2656.InchargeOutbound = Children(i).Code
   Case "FACTORDERNO":z2656.FactOrderNo = Children(i).Code
   Case "FACTORDERSEQ":z2656.FactOrderSeq = Children(i).Code
   Case "ORDERNO":z2656.OrderNo = Children(i).Code
   Case "ORDERNOSEQ":z2656.OrderNoSeq = Children(i).Code
   Case "PALLETNO":z2656.PalletNo = Children(i).Code
   Case "STOCKNO":z2656.StockNo = Children(i).Code
   Case "BARCODEINNERBOX":z2656.BarcodeInnerBox = Children(i).Code
   Case "BARCODEPACKING":z2656.BarcodePacking = Children(i).Code
   Case "BATCHNO":z2656.BatchNo = Children(i).Code
   Case "CHECKCOMPLETE":z2656.CheckComplete = Children(i).Code
   Case "PRICESHIPPING":z2656.PriceShipping = Children(i).Code
   Case "PRICESHIPPINGVND":z2656.PriceShippingVND = Children(i).Code
   Case "AMOUNTSHIPPING":z2656.AmountShipping = Children(i).Code
   Case "AMOUNTSHIPPINGVND":z2656.AmountShippingVND = Children(i).Code
   Case "QTYPRODUCTOUTBOUND":z2656.QtyProductOutbound = Children(i).Code
   Case "ISPOSTED":z2656.IsPosted = Children(i).Code
   Case "DATEPOSTED":z2656.DatePosted = Children(i).Code
   Case "DATEINSERT":z2656.DateInsert = Children(i).Code
   Case "DATEUPDATE":z2656.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z2656.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z2656.InchargeUpdate = Children(i).Code
   Case "REMARK":z2656.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "PRODUCTOUTBOUNDNO":z2656.ProductOutboundNo = Children(i).Data
   Case "PRODUCTOUTBOUNDSEQ":z2656.ProductOutboundSeq = Children(i).Data
   Case "CUSTOMERCODE":z2656.CustomerCode = Children(i).Data
   Case "SUPPLIERCODE":z2656.SupplierCode = Children(i).Data
   Case "SEFACTORY":z2656.seFactory = Children(i).Data
   Case "CDFACTORY":z2656.cdFactory = Children(i).Data
   Case "SHOESCODE":z2656.ShoesCode = Children(i).Data
   Case "SIZERANGE":z2656.SizeRange = Children(i).Data
   Case "CHECKOUTBOUNDMATERIAL":z2656.CheckOutBoundMaterial = Children(i).Data
   Case "CHECKMATERIALTYPE":z2656.CheckMaterialType = Children(i).Data
   Case "CHECKMARKETTYPE":z2656.CheckMarketType = Children(i).Data
   Case "INVOICENO":z2656.InvoiceNo = Children(i).Data
   Case "SEUNITPRICE":z2656.seUnitPrice = Children(i).Data
   Case "CDUNITPRICE":z2656.cdUnitPrice = Children(i).Data
   Case "DATEEXCHANGE":z2656.DateExchange = Children(i).Data
   Case "PRICEEXCHANGE":z2656.PriceExchange = Children(i).Data
   Case "PRODUCTINBOUNDNO":z2656.ProductInboundNo = Children(i).Data
   Case "PRODUCTINBOUNDSEQ":z2656.ProductInboundSeq = Children(i).Data
   Case "DATEOUTBOUND":z2656.DateOutbound = Children(i).Data
   Case "INCHARGEOUTBOUND":z2656.InchargeOutbound = Children(i).Data
   Case "FACTORDERNO":z2656.FactOrderNo = Children(i).Data
   Case "FACTORDERSEQ":z2656.FactOrderSeq = Children(i).Data
   Case "ORDERNO":z2656.OrderNo = Children(i).Data
   Case "ORDERNOSEQ":z2656.OrderNoSeq = Children(i).Data
   Case "PALLETNO":z2656.PalletNo = Children(i).Data
   Case "STOCKNO":z2656.StockNo = Children(i).Data
   Case "BARCODEINNERBOX":z2656.BarcodeInnerBox = Children(i).Data
   Case "BARCODEPACKING":z2656.BarcodePacking = Children(i).Data
   Case "BATCHNO":z2656.BatchNo = Children(i).Data
   Case "CHECKCOMPLETE":z2656.CheckComplete = Children(i).Data
   Case "PRICESHIPPING":z2656.PriceShipping = Children(i).Data
   Case "PRICESHIPPINGVND":z2656.PriceShippingVND = Children(i).Data
   Case "AMOUNTSHIPPING":z2656.AmountShipping = Children(i).Data
   Case "AMOUNTSHIPPINGVND":z2656.AmountShippingVND = Children(i).Data
   Case "QTYPRODUCTOUTBOUND":z2656.QtyProductOutbound = Children(i).Data
   Case "ISPOSTED":z2656.IsPosted = Children(i).Data
   Case "DATEPOSTED":z2656.DatePosted = Children(i).Data
   Case "DATEINSERT":z2656.DateInsert = Children(i).Data
   Case "DATEUPDATE":z2656.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z2656.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z2656.InchargeUpdate = Children(i).Data
   Case "REMARK":z2656.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K2656_MOVE",vbCritical)
End Try
End Function 
    
End Module 
