'=========================================================================================================================================================
'   TABLE : (PFK1003)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K1003

Structure T1003_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	OrderNo	 AS String	'			char(9)		*
Public 	OrderSeq	 AS Double	'			decimal		*
Public 	Dseq	 AS Double	'			decimal
Public 	MaterialCode	 AS String	'			char(6)
Public 	cdUnitPrice	 AS String	'			char(3)
Public 	PriceOrder	 AS Double	'			decimal
Public 	PriceOrderExchange	 AS Double	'			decimal
Public 	DateOrderExchange	 AS String	'			char(8)
Public 	PriceOrderUSD	 AS Double	'			decimal
Public 	PriceOrderVND	 AS Double	'			decimal
Public 	PriceQuotationOrder	 AS Double	'			decimal
Public 	PriceQuotationExchange	 AS Double	'			decimal
Public 	DateQuotationExchange	 AS String	'			char(8)
Public 	PriceQuotationUSD	 AS Double	'			decimal
Public 	PriceQuotationVND	 AS Double	'			decimal
Public 	PriceUSD	 AS Double	'			decimal
Public 	PriceVND	 AS Double	'			decimal
Public 	BoxOrder	 AS Double	'			decimal
Public 	QtyOrder	 AS Double	'			decimal
Public 	TaxExport	 AS Double	'			decimal
Public 	TaxEnvironment	 AS Double	'			decimal
Public 	TaxVat	 AS Double	'			decimal
Public 	AmountNetOrderUSD	 AS Double	'			decimal
Public 	AmountNetOrderVND	 AS Double	'			decimal
Public 	AmountTaxExport	 AS Double	'			decimal
Public 	AmountTaxEnvironment	 AS Double	'			decimal
Public 	AmountTaxVat	 AS Double	'			decimal
Public 	AmountOrderUSD	 AS Double	'			decimal
Public 	AmountOrderVND	 AS Double	'			decimal
Public 	AmountQuotationUSD	 AS Double	'			decimal
Public 	AmountQuotationVND	 AS Double	'			decimal
Public 	BoxOutbound	 AS Double	'			decimal
Public 	QtyOutbound	 AS Double	'			decimal
Public 	AmountOutboundUSD	 AS Double	'			decimal
Public 	AmountOutboundVND	 AS Double	'			decimal
Public 	CheckPromotion	 AS String	'			char(1)
Public 	CheckOrder	 AS String	'			char(1)
Public 	DateDelivery	 AS String	'			char(8)
Public 	DateRequestOrder	 AS String	'			char(8)
Public 	DateApprovalOrder	 AS String	'			char(8)
Public 	DateCancelOrder	 AS String	'			char(8)
Public 	DateCompleteOrder	 AS String	'			char(8)
Public 	QuotationNo	 AS String	'			char(9)
Public 	QuotationSeq	 AS Double	'			decimal
Public 	Remark	 AS String	'			nchar(200)
'=========================================================================================================================================================
End structure

Public D1003 As T1003_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK1003(ORDERNO AS String, ORDERSEQ AS Double) As Boolean
    READ_PFK1003 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK1003 "
    SQL = SQL & " WHERE K1003_OrderNo		 = '" & OrderNo & "' " 
    SQL = SQL & "   AND K1003_OrderSeq		 =  " & OrderSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D1003_CLEAR: GoTo SKIP_READ_PFK1003
                
    Call K1003_MOVE(rd)
    READ_PFK1003 = True

SKIP_READ_PFK1003:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK1003",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK1003(ORDERNO AS String, ORDERSEQ AS Double, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK1003 "
    SQL = SQL & " WHERE K1003_OrderNo		 = '" & OrderNo & "' " 
    SQL = SQL & "   AND K1003_OrderSeq		 =  " & OrderSeq & "  " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK1003",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK1003(z1003 As T1003_AREA) As Boolean
    WRITE_PFK1003 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z1003)
 
    SQL = " INSERT INTO PFK1003 "
    SQL = SQL & " ( "
    SQL = SQL & " K1003_OrderNo," 
    SQL = SQL & " K1003_OrderSeq," 
    SQL = SQL & " K1003_Dseq," 
    SQL = SQL & " K1003_MaterialCode," 
    SQL = SQL & " K1003_cdUnitPrice," 
    SQL = SQL & " K1003_PriceOrder," 
    SQL = SQL & " K1003_PriceOrderExchange," 
    SQL = SQL & " K1003_DateOrderExchange," 
    SQL = SQL & " K1003_PriceOrderUSD," 
    SQL = SQL & " K1003_PriceOrderVND," 
    SQL = SQL & " K1003_PriceQuotationOrder," 
    SQL = SQL & " K1003_PriceQuotationExchange," 
    SQL = SQL & " K1003_DateQuotationExchange," 
    SQL = SQL & " K1003_PriceQuotationUSD," 
    SQL = SQL & " K1003_PriceQuotationVND," 
    SQL = SQL & " K1003_PriceUSD," 
    SQL = SQL & " K1003_PriceVND," 
    SQL = SQL & " K1003_BoxOrder," 
    SQL = SQL & " K1003_QtyOrder," 
    SQL = SQL & " K1003_TaxExport," 
    SQL = SQL & " K1003_TaxEnvironment," 
    SQL = SQL & " K1003_TaxVat," 
    SQL = SQL & " K1003_AmountNetOrderUSD," 
    SQL = SQL & " K1003_AmountNetOrderVND," 
    SQL = SQL & " K1003_AmountTaxExport," 
    SQL = SQL & " K1003_AmountTaxEnvironment," 
    SQL = SQL & " K1003_AmountTaxVat," 
    SQL = SQL & " K1003_AmountOrderUSD," 
    SQL = SQL & " K1003_AmountOrderVND," 
    SQL = SQL & " K1003_AmountQuotationUSD," 
    SQL = SQL & " K1003_AmountQuotationVND," 
    SQL = SQL & " K1003_BoxOutbound," 
    SQL = SQL & " K1003_QtyOutbound," 
    SQL = SQL & " K1003_AmountOutboundUSD," 
    SQL = SQL & " K1003_AmountOutboundVND," 
    SQL = SQL & " K1003_CheckPromotion," 
    SQL = SQL & " K1003_CheckOrder," 
    SQL = SQL & " K1003_DateDelivery," 
    SQL = SQL & " K1003_DateRequestOrder," 
    SQL = SQL & " K1003_DateApprovalOrder," 
    SQL = SQL & " K1003_DateCancelOrder," 
    SQL = SQL & " K1003_DateCompleteOrder," 
    SQL = SQL & " K1003_QuotationNo," 
    SQL = SQL & " K1003_QuotationSeq," 
    SQL = SQL & " K1003_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & z1003.OrderNo & "', "  
    SQL = SQL & "   " & z1003.OrderSeq & ", "  
    SQL = SQL & "   " & z1003.Dseq & ", "  
    SQL = SQL & "  N'" & z1003.MaterialCode & "', "  
    SQL = SQL & "  N'" & z1003.cdUnitPrice & "', "  
    SQL = SQL & "   " & z1003.PriceOrder & ", "  
    SQL = SQL & "   " & z1003.PriceOrderExchange & ", "  
    SQL = SQL & "  N'" & z1003.DateOrderExchange & "', "  
    SQL = SQL & "   " & z1003.PriceOrderUSD & ", "  
    SQL = SQL & "   " & z1003.PriceOrderVND & ", "  
    SQL = SQL & "   " & z1003.PriceQuotationOrder & ", "  
    SQL = SQL & "   " & z1003.PriceQuotationExchange & ", "  
    SQL = SQL & "  N'" & z1003.DateQuotationExchange & "', "  
    SQL = SQL & "   " & z1003.PriceQuotationUSD & ", "  
    SQL = SQL & "   " & z1003.PriceQuotationVND & ", "  
    SQL = SQL & "   " & z1003.PriceUSD & ", "  
    SQL = SQL & "   " & z1003.PriceVND & ", "  
    SQL = SQL & "   " & z1003.BoxOrder & ", "  
    SQL = SQL & "   " & z1003.QtyOrder & ", "  
    SQL = SQL & "   " & z1003.TaxExport & ", "  
    SQL = SQL & "   " & z1003.TaxEnvironment & ", "  
    SQL = SQL & "   " & z1003.TaxVat & ", "  
    SQL = SQL & "   " & z1003.AmountNetOrderUSD & ", "  
    SQL = SQL & "   " & z1003.AmountNetOrderVND & ", "  
    SQL = SQL & "   " & z1003.AmountTaxExport & ", "  
    SQL = SQL & "   " & z1003.AmountTaxEnvironment & ", "  
    SQL = SQL & "   " & z1003.AmountTaxVat & ", "  
    SQL = SQL & "   " & z1003.AmountOrderUSD & ", "  
    SQL = SQL & "   " & z1003.AmountOrderVND & ", "  
    SQL = SQL & "   " & z1003.AmountQuotationUSD & ", "  
    SQL = SQL & "   " & z1003.AmountQuotationVND & ", "  
    SQL = SQL & "   " & z1003.BoxOutbound & ", "  
    SQL = SQL & "   " & z1003.QtyOutbound & ", "  
    SQL = SQL & "   " & z1003.AmountOutboundUSD & ", "  
    SQL = SQL & "   " & z1003.AmountOutboundVND & ", "  
    SQL = SQL & "  N'" & z1003.CheckPromotion & "', "  
    SQL = SQL & "  N'" & z1003.CheckOrder & "', "  
    SQL = SQL & "  N'" & z1003.DateDelivery & "', "  
    SQL = SQL & "  N'" & z1003.DateRequestOrder & "', "  
    SQL = SQL & "  N'" & z1003.DateApprovalOrder & "', "  
    SQL = SQL & "  N'" & z1003.DateCancelOrder & "', "  
    SQL = SQL & "  N'" & z1003.DateCompleteOrder & "', "  
    SQL = SQL & "  N'" & z1003.QuotationNo & "', "  
    SQL = SQL & "   " & z1003.QuotationSeq & ", "  
    SQL = SQL & "  N'" & z1003.Remark & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK1003 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK1003",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK1003(z1003 As T1003_AREA) As Boolean
    REWRITE_PFK1003 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z1003)
   
    SQL = " UPDATE PFK1003 SET "
    SQL = SQL & "    K1003_Dseq      =  " & z1003.Dseq & ", " 
    SQL = SQL & "    K1003_MaterialCode      = N'" & z1003.MaterialCode & "', " 
    SQL = SQL & "    K1003_cdUnitPrice      = N'" & z1003.cdUnitPrice & "', " 
    SQL = SQL & "    K1003_PriceOrder      =  " & z1003.PriceOrder & ", " 
    SQL = SQL & "    K1003_PriceOrderExchange      =  " & z1003.PriceOrderExchange & ", " 
    SQL = SQL & "    K1003_DateOrderExchange      = N'" & z1003.DateOrderExchange & "', " 
    SQL = SQL & "    K1003_PriceOrderUSD      =  " & z1003.PriceOrderUSD & ", " 
    SQL = SQL & "    K1003_PriceOrderVND      =  " & z1003.PriceOrderVND & ", " 
    SQL = SQL & "    K1003_PriceQuotationOrder      =  " & z1003.PriceQuotationOrder & ", " 
    SQL = SQL & "    K1003_PriceQuotationExchange      =  " & z1003.PriceQuotationExchange & ", " 
    SQL = SQL & "    K1003_DateQuotationExchange      = N'" & z1003.DateQuotationExchange & "', " 
    SQL = SQL & "    K1003_PriceQuotationUSD      =  " & z1003.PriceQuotationUSD & ", " 
    SQL = SQL & "    K1003_PriceQuotationVND      =  " & z1003.PriceQuotationVND & ", " 
    SQL = SQL & "    K1003_PriceUSD      =  " & z1003.PriceUSD & ", " 
    SQL = SQL & "    K1003_PriceVND      =  " & z1003.PriceVND & ", " 
    SQL = SQL & "    K1003_BoxOrder      =  " & z1003.BoxOrder & ", " 
    SQL = SQL & "    K1003_QtyOrder      =  " & z1003.QtyOrder & ", " 
    SQL = SQL & "    K1003_TaxExport      =  " & z1003.TaxExport & ", " 
    SQL = SQL & "    K1003_TaxEnvironment      =  " & z1003.TaxEnvironment & ", " 
    SQL = SQL & "    K1003_TaxVat      =  " & z1003.TaxVat & ", " 
    SQL = SQL & "    K1003_AmountNetOrderUSD      =  " & z1003.AmountNetOrderUSD & ", " 
    SQL = SQL & "    K1003_AmountNetOrderVND      =  " & z1003.AmountNetOrderVND & ", " 
    SQL = SQL & "    K1003_AmountTaxExport      =  " & z1003.AmountTaxExport & ", " 
    SQL = SQL & "    K1003_AmountTaxEnvironment      =  " & z1003.AmountTaxEnvironment & ", " 
    SQL = SQL & "    K1003_AmountTaxVat      =  " & z1003.AmountTaxVat & ", " 
    SQL = SQL & "    K1003_AmountOrderUSD      =  " & z1003.AmountOrderUSD & ", " 
    SQL = SQL & "    K1003_AmountOrderVND      =  " & z1003.AmountOrderVND & ", " 
    SQL = SQL & "    K1003_AmountQuotationUSD      =  " & z1003.AmountQuotationUSD & ", " 
    SQL = SQL & "    K1003_AmountQuotationVND      =  " & z1003.AmountQuotationVND & ", " 
    SQL = SQL & "    K1003_BoxOutbound      =  " & z1003.BoxOutbound & ", " 
    SQL = SQL & "    K1003_QtyOutbound      =  " & z1003.QtyOutbound & ", " 
    SQL = SQL & "    K1003_AmountOutboundUSD      =  " & z1003.AmountOutboundUSD & ", " 
    SQL = SQL & "    K1003_AmountOutboundVND      =  " & z1003.AmountOutboundVND & ", " 
    SQL = SQL & "    K1003_CheckPromotion      = N'" & z1003.CheckPromotion & "', " 
    SQL = SQL & "    K1003_CheckOrder      = N'" & z1003.CheckOrder & "', " 
    SQL = SQL & "    K1003_DateDelivery      = N'" & z1003.DateDelivery & "', " 
    SQL = SQL & "    K1003_DateRequestOrder      = N'" & z1003.DateRequestOrder & "', " 
    SQL = SQL & "    K1003_DateApprovalOrder      = N'" & z1003.DateApprovalOrder & "', " 
    SQL = SQL & "    K1003_DateCancelOrder      = N'" & z1003.DateCancelOrder & "', " 
    SQL = SQL & "    K1003_DateCompleteOrder      = N'" & z1003.DateCompleteOrder & "', " 
    SQL = SQL & "    K1003_QuotationNo      = N'" & z1003.QuotationNo & "', " 
    SQL = SQL & "    K1003_QuotationSeq      =  " & z1003.QuotationSeq & ", " 
    SQL = SQL & "    K1003_Remark      = N'" & z1003.Remark & "'  " 
    SQL = SQL & " WHERE K1003_OrderNo		 = '" & z1003.OrderNo & "' " 
    SQL = SQL & "   AND K1003_OrderSeq		 =  " & z1003.OrderSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK1003 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK1003",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK1003(z1003 As T1003_AREA) As Boolean
    DELETE_PFK1003 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK1003 "
    SQL = SQL & " WHERE K1003_OrderNo		 = '" & z1003.OrderNo & "' " 
    SQL = SQL & "   AND K1003_OrderSeq		 =  " & z1003.OrderSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK1003 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK1003",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D1003_CLEAR()
Try
    
   D1003.OrderNo = ""
    D1003.OrderSeq = 0 
    D1003.Dseq = 0 
   D1003.MaterialCode = ""
   D1003.cdUnitPrice = ""
    D1003.PriceOrder = 0 
    D1003.PriceOrderExchange = 0 
   D1003.DateOrderExchange = ""
    D1003.PriceOrderUSD = 0 
    D1003.PriceOrderVND = 0 
    D1003.PriceQuotationOrder = 0 
    D1003.PriceQuotationExchange = 0 
   D1003.DateQuotationExchange = ""
    D1003.PriceQuotationUSD = 0 
    D1003.PriceQuotationVND = 0 
    D1003.PriceUSD = 0 
    D1003.PriceVND = 0 
    D1003.BoxOrder = 0 
    D1003.QtyOrder = 0 
    D1003.TaxExport = 0 
    D1003.TaxEnvironment = 0 
    D1003.TaxVat = 0 
    D1003.AmountNetOrderUSD = 0 
    D1003.AmountNetOrderVND = 0 
    D1003.AmountTaxExport = 0 
    D1003.AmountTaxEnvironment = 0 
    D1003.AmountTaxVat = 0 
    D1003.AmountOrderUSD = 0 
    D1003.AmountOrderVND = 0 
    D1003.AmountQuotationUSD = 0 
    D1003.AmountQuotationVND = 0 
    D1003.BoxOutbound = 0 
    D1003.QtyOutbound = 0 
    D1003.AmountOutboundUSD = 0 
    D1003.AmountOutboundVND = 0 
   D1003.CheckPromotion = ""
   D1003.CheckOrder = ""
   D1003.DateDelivery = ""
   D1003.DateRequestOrder = ""
   D1003.DateApprovalOrder = ""
   D1003.DateCancelOrder = ""
   D1003.DateCompleteOrder = ""
   D1003.QuotationNo = ""
    D1003.QuotationSeq = 0 
   D1003.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D1003_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x1003 As T1003_AREA)
Try
    
    x1003.OrderNo = trim$(  x1003.OrderNo)
    x1003.OrderSeq = trim$(  x1003.OrderSeq)
    x1003.Dseq = trim$(  x1003.Dseq)
    x1003.MaterialCode = trim$(  x1003.MaterialCode)
    x1003.cdUnitPrice = trim$(  x1003.cdUnitPrice)
    x1003.PriceOrder = trim$(  x1003.PriceOrder)
    x1003.PriceOrderExchange = trim$(  x1003.PriceOrderExchange)
    x1003.DateOrderExchange = trim$(  x1003.DateOrderExchange)
    x1003.PriceOrderUSD = trim$(  x1003.PriceOrderUSD)
    x1003.PriceOrderVND = trim$(  x1003.PriceOrderVND)
    x1003.PriceQuotationOrder = trim$(  x1003.PriceQuotationOrder)
    x1003.PriceQuotationExchange = trim$(  x1003.PriceQuotationExchange)
    x1003.DateQuotationExchange = trim$(  x1003.DateQuotationExchange)
    x1003.PriceQuotationUSD = trim$(  x1003.PriceQuotationUSD)
    x1003.PriceQuotationVND = trim$(  x1003.PriceQuotationVND)
    x1003.PriceUSD = trim$(  x1003.PriceUSD)
    x1003.PriceVND = trim$(  x1003.PriceVND)
    x1003.BoxOrder = trim$(  x1003.BoxOrder)
    x1003.QtyOrder = trim$(  x1003.QtyOrder)
    x1003.TaxExport = trim$(  x1003.TaxExport)
    x1003.TaxEnvironment = trim$(  x1003.TaxEnvironment)
    x1003.TaxVat = trim$(  x1003.TaxVat)
    x1003.AmountNetOrderUSD = trim$(  x1003.AmountNetOrderUSD)
    x1003.AmountNetOrderVND = trim$(  x1003.AmountNetOrderVND)
    x1003.AmountTaxExport = trim$(  x1003.AmountTaxExport)
    x1003.AmountTaxEnvironment = trim$(  x1003.AmountTaxEnvironment)
    x1003.AmountTaxVat = trim$(  x1003.AmountTaxVat)
    x1003.AmountOrderUSD = trim$(  x1003.AmountOrderUSD)
    x1003.AmountOrderVND = trim$(  x1003.AmountOrderVND)
    x1003.AmountQuotationUSD = trim$(  x1003.AmountQuotationUSD)
    x1003.AmountQuotationVND = trim$(  x1003.AmountQuotationVND)
    x1003.BoxOutbound = trim$(  x1003.BoxOutbound)
    x1003.QtyOutbound = trim$(  x1003.QtyOutbound)
    x1003.AmountOutboundUSD = trim$(  x1003.AmountOutboundUSD)
    x1003.AmountOutboundVND = trim$(  x1003.AmountOutboundVND)
    x1003.CheckPromotion = trim$(  x1003.CheckPromotion)
    x1003.CheckOrder = trim$(  x1003.CheckOrder)
    x1003.DateDelivery = trim$(  x1003.DateDelivery)
    x1003.DateRequestOrder = trim$(  x1003.DateRequestOrder)
    x1003.DateApprovalOrder = trim$(  x1003.DateApprovalOrder)
    x1003.DateCancelOrder = trim$(  x1003.DateCancelOrder)
    x1003.DateCompleteOrder = trim$(  x1003.DateCompleteOrder)
    x1003.QuotationNo = trim$(  x1003.QuotationNo)
    x1003.QuotationSeq = trim$(  x1003.QuotationSeq)
    x1003.Remark = trim$(  x1003.Remark)
     
    If trim$( x1003.OrderNo ) = "" Then x1003.OrderNo = Space(1) 
    If trim$( x1003.OrderSeq ) = "" Then x1003.OrderSeq = 0 
    If trim$( x1003.Dseq ) = "" Then x1003.Dseq = 0 
    If trim$( x1003.MaterialCode ) = "" Then x1003.MaterialCode = Space(1) 
    If trim$( x1003.cdUnitPrice ) = "" Then x1003.cdUnitPrice = Space(1) 
    If trim$( x1003.PriceOrder ) = "" Then x1003.PriceOrder = 0 
    If trim$( x1003.PriceOrderExchange ) = "" Then x1003.PriceOrderExchange = 0 
    If trim$( x1003.DateOrderExchange ) = "" Then x1003.DateOrderExchange = Space(1) 
    If trim$( x1003.PriceOrderUSD ) = "" Then x1003.PriceOrderUSD = 0 
    If trim$( x1003.PriceOrderVND ) = "" Then x1003.PriceOrderVND = 0 
    If trim$( x1003.PriceQuotationOrder ) = "" Then x1003.PriceQuotationOrder = 0 
    If trim$( x1003.PriceQuotationExchange ) = "" Then x1003.PriceQuotationExchange = 0 
    If trim$( x1003.DateQuotationExchange ) = "" Then x1003.DateQuotationExchange = Space(1) 
    If trim$( x1003.PriceQuotationUSD ) = "" Then x1003.PriceQuotationUSD = 0 
    If trim$( x1003.PriceQuotationVND ) = "" Then x1003.PriceQuotationVND = 0 
    If trim$( x1003.PriceUSD ) = "" Then x1003.PriceUSD = 0 
    If trim$( x1003.PriceVND ) = "" Then x1003.PriceVND = 0 
    If trim$( x1003.BoxOrder ) = "" Then x1003.BoxOrder = 0 
    If trim$( x1003.QtyOrder ) = "" Then x1003.QtyOrder = 0 
    If trim$( x1003.TaxExport ) = "" Then x1003.TaxExport = 0 
    If trim$( x1003.TaxEnvironment ) = "" Then x1003.TaxEnvironment = 0 
    If trim$( x1003.TaxVat ) = "" Then x1003.TaxVat = 0 
    If trim$( x1003.AmountNetOrderUSD ) = "" Then x1003.AmountNetOrderUSD = 0 
    If trim$( x1003.AmountNetOrderVND ) = "" Then x1003.AmountNetOrderVND = 0 
    If trim$( x1003.AmountTaxExport ) = "" Then x1003.AmountTaxExport = 0 
    If trim$( x1003.AmountTaxEnvironment ) = "" Then x1003.AmountTaxEnvironment = 0 
    If trim$( x1003.AmountTaxVat ) = "" Then x1003.AmountTaxVat = 0 
    If trim$( x1003.AmountOrderUSD ) = "" Then x1003.AmountOrderUSD = 0 
    If trim$( x1003.AmountOrderVND ) = "" Then x1003.AmountOrderVND = 0 
    If trim$( x1003.AmountQuotationUSD ) = "" Then x1003.AmountQuotationUSD = 0 
    If trim$( x1003.AmountQuotationVND ) = "" Then x1003.AmountQuotationVND = 0 
    If trim$( x1003.BoxOutbound ) = "" Then x1003.BoxOutbound = 0 
    If trim$( x1003.QtyOutbound ) = "" Then x1003.QtyOutbound = 0 
    If trim$( x1003.AmountOutboundUSD ) = "" Then x1003.AmountOutboundUSD = 0 
    If trim$( x1003.AmountOutboundVND ) = "" Then x1003.AmountOutboundVND = 0 
    If trim$( x1003.CheckPromotion ) = "" Then x1003.CheckPromotion = Space(1) 
    If trim$( x1003.CheckOrder ) = "" Then x1003.CheckOrder = Space(1) 
    If trim$( x1003.DateDelivery ) = "" Then x1003.DateDelivery = Space(1) 
    If trim$( x1003.DateRequestOrder ) = "" Then x1003.DateRequestOrder = Space(1) 
    If trim$( x1003.DateApprovalOrder ) = "" Then x1003.DateApprovalOrder = Space(1) 
    If trim$( x1003.DateCancelOrder ) = "" Then x1003.DateCancelOrder = Space(1) 
    If trim$( x1003.DateCompleteOrder ) = "" Then x1003.DateCompleteOrder = Space(1) 
    If trim$( x1003.QuotationNo ) = "" Then x1003.QuotationNo = Space(1) 
    If trim$( x1003.QuotationSeq ) = "" Then x1003.QuotationSeq = 0 
    If trim$( x1003.Remark ) = "" Then x1003.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K1003_MOVE(rs1003 As SqlClient.SqlDataReader)
Try

    call D1003_CLEAR()   

    If IsdbNull(rs1003!K1003_OrderNo) = False Then D1003.OrderNo = Trim$(rs1003!K1003_OrderNo)
    If IsdbNull(rs1003!K1003_OrderSeq) = False Then D1003.OrderSeq = Trim$(rs1003!K1003_OrderSeq)
    If IsdbNull(rs1003!K1003_Dseq) = False Then D1003.Dseq = Trim$(rs1003!K1003_Dseq)
    If IsdbNull(rs1003!K1003_MaterialCode) = False Then D1003.MaterialCode = Trim$(rs1003!K1003_MaterialCode)
    If IsdbNull(rs1003!K1003_cdUnitPrice) = False Then D1003.cdUnitPrice = Trim$(rs1003!K1003_cdUnitPrice)
    If IsdbNull(rs1003!K1003_PriceOrder) = False Then D1003.PriceOrder = Trim$(rs1003!K1003_PriceOrder)
    If IsdbNull(rs1003!K1003_PriceOrderExchange) = False Then D1003.PriceOrderExchange = Trim$(rs1003!K1003_PriceOrderExchange)
    If IsdbNull(rs1003!K1003_DateOrderExchange) = False Then D1003.DateOrderExchange = Trim$(rs1003!K1003_DateOrderExchange)
    If IsdbNull(rs1003!K1003_PriceOrderUSD) = False Then D1003.PriceOrderUSD = Trim$(rs1003!K1003_PriceOrderUSD)
    If IsdbNull(rs1003!K1003_PriceOrderVND) = False Then D1003.PriceOrderVND = Trim$(rs1003!K1003_PriceOrderVND)
    If IsdbNull(rs1003!K1003_PriceQuotationOrder) = False Then D1003.PriceQuotationOrder = Trim$(rs1003!K1003_PriceQuotationOrder)
    If IsdbNull(rs1003!K1003_PriceQuotationExchange) = False Then D1003.PriceQuotationExchange = Trim$(rs1003!K1003_PriceQuotationExchange)
    If IsdbNull(rs1003!K1003_DateQuotationExchange) = False Then D1003.DateQuotationExchange = Trim$(rs1003!K1003_DateQuotationExchange)
    If IsdbNull(rs1003!K1003_PriceQuotationUSD) = False Then D1003.PriceQuotationUSD = Trim$(rs1003!K1003_PriceQuotationUSD)
    If IsdbNull(rs1003!K1003_PriceQuotationVND) = False Then D1003.PriceQuotationVND = Trim$(rs1003!K1003_PriceQuotationVND)
    If IsdbNull(rs1003!K1003_PriceUSD) = False Then D1003.PriceUSD = Trim$(rs1003!K1003_PriceUSD)
    If IsdbNull(rs1003!K1003_PriceVND) = False Then D1003.PriceVND = Trim$(rs1003!K1003_PriceVND)
    If IsdbNull(rs1003!K1003_BoxOrder) = False Then D1003.BoxOrder = Trim$(rs1003!K1003_BoxOrder)
    If IsdbNull(rs1003!K1003_QtyOrder) = False Then D1003.QtyOrder = Trim$(rs1003!K1003_QtyOrder)
    If IsdbNull(rs1003!K1003_TaxExport) = False Then D1003.TaxExport = Trim$(rs1003!K1003_TaxExport)
    If IsdbNull(rs1003!K1003_TaxEnvironment) = False Then D1003.TaxEnvironment = Trim$(rs1003!K1003_TaxEnvironment)
    If IsdbNull(rs1003!K1003_TaxVat) = False Then D1003.TaxVat = Trim$(rs1003!K1003_TaxVat)
    If IsdbNull(rs1003!K1003_AmountNetOrderUSD) = False Then D1003.AmountNetOrderUSD = Trim$(rs1003!K1003_AmountNetOrderUSD)
    If IsdbNull(rs1003!K1003_AmountNetOrderVND) = False Then D1003.AmountNetOrderVND = Trim$(rs1003!K1003_AmountNetOrderVND)
    If IsdbNull(rs1003!K1003_AmountTaxExport) = False Then D1003.AmountTaxExport = Trim$(rs1003!K1003_AmountTaxExport)
    If IsdbNull(rs1003!K1003_AmountTaxEnvironment) = False Then D1003.AmountTaxEnvironment = Trim$(rs1003!K1003_AmountTaxEnvironment)
    If IsdbNull(rs1003!K1003_AmountTaxVat) = False Then D1003.AmountTaxVat = Trim$(rs1003!K1003_AmountTaxVat)
    If IsdbNull(rs1003!K1003_AmountOrderUSD) = False Then D1003.AmountOrderUSD = Trim$(rs1003!K1003_AmountOrderUSD)
    If IsdbNull(rs1003!K1003_AmountOrderVND) = False Then D1003.AmountOrderVND = Trim$(rs1003!K1003_AmountOrderVND)
    If IsdbNull(rs1003!K1003_AmountQuotationUSD) = False Then D1003.AmountQuotationUSD = Trim$(rs1003!K1003_AmountQuotationUSD)
    If IsdbNull(rs1003!K1003_AmountQuotationVND) = False Then D1003.AmountQuotationVND = Trim$(rs1003!K1003_AmountQuotationVND)
    If IsdbNull(rs1003!K1003_BoxOutbound) = False Then D1003.BoxOutbound = Trim$(rs1003!K1003_BoxOutbound)
    If IsdbNull(rs1003!K1003_QtyOutbound) = False Then D1003.QtyOutbound = Trim$(rs1003!K1003_QtyOutbound)
    If IsdbNull(rs1003!K1003_AmountOutboundUSD) = False Then D1003.AmountOutboundUSD = Trim$(rs1003!K1003_AmountOutboundUSD)
    If IsdbNull(rs1003!K1003_AmountOutboundVND) = False Then D1003.AmountOutboundVND = Trim$(rs1003!K1003_AmountOutboundVND)
    If IsdbNull(rs1003!K1003_CheckPromotion) = False Then D1003.CheckPromotion = Trim$(rs1003!K1003_CheckPromotion)
    If IsdbNull(rs1003!K1003_CheckOrder) = False Then D1003.CheckOrder = Trim$(rs1003!K1003_CheckOrder)
    If IsdbNull(rs1003!K1003_DateDelivery) = False Then D1003.DateDelivery = Trim$(rs1003!K1003_DateDelivery)
    If IsdbNull(rs1003!K1003_DateRequestOrder) = False Then D1003.DateRequestOrder = Trim$(rs1003!K1003_DateRequestOrder)
    If IsdbNull(rs1003!K1003_DateApprovalOrder) = False Then D1003.DateApprovalOrder = Trim$(rs1003!K1003_DateApprovalOrder)
    If IsdbNull(rs1003!K1003_DateCancelOrder) = False Then D1003.DateCancelOrder = Trim$(rs1003!K1003_DateCancelOrder)
    If IsdbNull(rs1003!K1003_DateCompleteOrder) = False Then D1003.DateCompleteOrder = Trim$(rs1003!K1003_DateCompleteOrder)
    If IsdbNull(rs1003!K1003_QuotationNo) = False Then D1003.QuotationNo = Trim$(rs1003!K1003_QuotationNo)
    If IsdbNull(rs1003!K1003_QuotationSeq) = False Then D1003.QuotationSeq = Trim$(rs1003!K1003_QuotationSeq)
    If IsdbNull(rs1003!K1003_Remark) = False Then D1003.Remark = Trim$(rs1003!K1003_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K1003_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K1003_MOVE(rs1003 As DataRow)
Try

    call D1003_CLEAR()   

    If IsdbNull(rs1003!K1003_OrderNo) = False Then D1003.OrderNo = Trim$(rs1003!K1003_OrderNo)
    If IsdbNull(rs1003!K1003_OrderSeq) = False Then D1003.OrderSeq = Trim$(rs1003!K1003_OrderSeq)
    If IsdbNull(rs1003!K1003_Dseq) = False Then D1003.Dseq = Trim$(rs1003!K1003_Dseq)
    If IsdbNull(rs1003!K1003_MaterialCode) = False Then D1003.MaterialCode = Trim$(rs1003!K1003_MaterialCode)
    If IsdbNull(rs1003!K1003_cdUnitPrice) = False Then D1003.cdUnitPrice = Trim$(rs1003!K1003_cdUnitPrice)
    If IsdbNull(rs1003!K1003_PriceOrder) = False Then D1003.PriceOrder = Trim$(rs1003!K1003_PriceOrder)
    If IsdbNull(rs1003!K1003_PriceOrderExchange) = False Then D1003.PriceOrderExchange = Trim$(rs1003!K1003_PriceOrderExchange)
    If IsdbNull(rs1003!K1003_DateOrderExchange) = False Then D1003.DateOrderExchange = Trim$(rs1003!K1003_DateOrderExchange)
    If IsdbNull(rs1003!K1003_PriceOrderUSD) = False Then D1003.PriceOrderUSD = Trim$(rs1003!K1003_PriceOrderUSD)
    If IsdbNull(rs1003!K1003_PriceOrderVND) = False Then D1003.PriceOrderVND = Trim$(rs1003!K1003_PriceOrderVND)
    If IsdbNull(rs1003!K1003_PriceQuotationOrder) = False Then D1003.PriceQuotationOrder = Trim$(rs1003!K1003_PriceQuotationOrder)
    If IsdbNull(rs1003!K1003_PriceQuotationExchange) = False Then D1003.PriceQuotationExchange = Trim$(rs1003!K1003_PriceQuotationExchange)
    If IsdbNull(rs1003!K1003_DateQuotationExchange) = False Then D1003.DateQuotationExchange = Trim$(rs1003!K1003_DateQuotationExchange)
    If IsdbNull(rs1003!K1003_PriceQuotationUSD) = False Then D1003.PriceQuotationUSD = Trim$(rs1003!K1003_PriceQuotationUSD)
    If IsdbNull(rs1003!K1003_PriceQuotationVND) = False Then D1003.PriceQuotationVND = Trim$(rs1003!K1003_PriceQuotationVND)
    If IsdbNull(rs1003!K1003_PriceUSD) = False Then D1003.PriceUSD = Trim$(rs1003!K1003_PriceUSD)
    If IsdbNull(rs1003!K1003_PriceVND) = False Then D1003.PriceVND = Trim$(rs1003!K1003_PriceVND)
    If IsdbNull(rs1003!K1003_BoxOrder) = False Then D1003.BoxOrder = Trim$(rs1003!K1003_BoxOrder)
    If IsdbNull(rs1003!K1003_QtyOrder) = False Then D1003.QtyOrder = Trim$(rs1003!K1003_QtyOrder)
    If IsdbNull(rs1003!K1003_TaxExport) = False Then D1003.TaxExport = Trim$(rs1003!K1003_TaxExport)
    If IsdbNull(rs1003!K1003_TaxEnvironment) = False Then D1003.TaxEnvironment = Trim$(rs1003!K1003_TaxEnvironment)
    If IsdbNull(rs1003!K1003_TaxVat) = False Then D1003.TaxVat = Trim$(rs1003!K1003_TaxVat)
    If IsdbNull(rs1003!K1003_AmountNetOrderUSD) = False Then D1003.AmountNetOrderUSD = Trim$(rs1003!K1003_AmountNetOrderUSD)
    If IsdbNull(rs1003!K1003_AmountNetOrderVND) = False Then D1003.AmountNetOrderVND = Trim$(rs1003!K1003_AmountNetOrderVND)
    If IsdbNull(rs1003!K1003_AmountTaxExport) = False Then D1003.AmountTaxExport = Trim$(rs1003!K1003_AmountTaxExport)
    If IsdbNull(rs1003!K1003_AmountTaxEnvironment) = False Then D1003.AmountTaxEnvironment = Trim$(rs1003!K1003_AmountTaxEnvironment)
    If IsdbNull(rs1003!K1003_AmountTaxVat) = False Then D1003.AmountTaxVat = Trim$(rs1003!K1003_AmountTaxVat)
    If IsdbNull(rs1003!K1003_AmountOrderUSD) = False Then D1003.AmountOrderUSD = Trim$(rs1003!K1003_AmountOrderUSD)
    If IsdbNull(rs1003!K1003_AmountOrderVND) = False Then D1003.AmountOrderVND = Trim$(rs1003!K1003_AmountOrderVND)
    If IsdbNull(rs1003!K1003_AmountQuotationUSD) = False Then D1003.AmountQuotationUSD = Trim$(rs1003!K1003_AmountQuotationUSD)
    If IsdbNull(rs1003!K1003_AmountQuotationVND) = False Then D1003.AmountQuotationVND = Trim$(rs1003!K1003_AmountQuotationVND)
    If IsdbNull(rs1003!K1003_BoxOutbound) = False Then D1003.BoxOutbound = Trim$(rs1003!K1003_BoxOutbound)
    If IsdbNull(rs1003!K1003_QtyOutbound) = False Then D1003.QtyOutbound = Trim$(rs1003!K1003_QtyOutbound)
    If IsdbNull(rs1003!K1003_AmountOutboundUSD) = False Then D1003.AmountOutboundUSD = Trim$(rs1003!K1003_AmountOutboundUSD)
    If IsdbNull(rs1003!K1003_AmountOutboundVND) = False Then D1003.AmountOutboundVND = Trim$(rs1003!K1003_AmountOutboundVND)
    If IsdbNull(rs1003!K1003_CheckPromotion) = False Then D1003.CheckPromotion = Trim$(rs1003!K1003_CheckPromotion)
    If IsdbNull(rs1003!K1003_CheckOrder) = False Then D1003.CheckOrder = Trim$(rs1003!K1003_CheckOrder)
    If IsdbNull(rs1003!K1003_DateDelivery) = False Then D1003.DateDelivery = Trim$(rs1003!K1003_DateDelivery)
    If IsdbNull(rs1003!K1003_DateRequestOrder) = False Then D1003.DateRequestOrder = Trim$(rs1003!K1003_DateRequestOrder)
    If IsdbNull(rs1003!K1003_DateApprovalOrder) = False Then D1003.DateApprovalOrder = Trim$(rs1003!K1003_DateApprovalOrder)
    If IsdbNull(rs1003!K1003_DateCancelOrder) = False Then D1003.DateCancelOrder = Trim$(rs1003!K1003_DateCancelOrder)
    If IsdbNull(rs1003!K1003_DateCompleteOrder) = False Then D1003.DateCompleteOrder = Trim$(rs1003!K1003_DateCompleteOrder)
    If IsdbNull(rs1003!K1003_QuotationNo) = False Then D1003.QuotationNo = Trim$(rs1003!K1003_QuotationNo)
    If IsdbNull(rs1003!K1003_QuotationSeq) = False Then D1003.QuotationSeq = Trim$(rs1003!K1003_QuotationSeq)
    If IsdbNull(rs1003!K1003_Remark) = False Then D1003.Remark = Trim$(rs1003!K1003_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K1003_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K1003_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z1003 As T1003_AREA,ORDERNO AS String, ORDERSEQ AS Double) as Boolean

K1003_MOVE = False

Try
    If READ_PFK1003(ORDERNO, ORDERSEQ) = True Then
                z1003 = D1003
		K1003_MOVE = True
		else
		 z1003 = nothing
     End If

     If  getColumIndex(spr,"OrderNo") > -1 then z1003.OrderNo = getDataM(spr, getColumIndex(spr,"OrderNo"), xRow)
     If  getColumIndex(spr,"OrderSeq") > -1 then z1003.OrderSeq = getDataM(spr, getColumIndex(spr,"OrderSeq"), xRow)
            If getColumIndex(spr, "Dseq") > -1 Then z1003.Dseq = CDecp(getDataM(spr, getColumIndex(spr, "Dseq"), xRow))
     If  getColumIndex(spr,"MaterialCode") > -1 then z1003.MaterialCode = getDataM(spr, getColumIndex(spr,"MaterialCode"), xRow)
     If  getColumIndex(spr,"cdUnitPrice") > -1 then z1003.cdUnitPrice = getDataM(spr, getColumIndex(spr,"cdUnitPrice"), xRow)
     If  getColumIndex(spr,"PriceOrder") > -1 then z1003.PriceOrder = getDataM(spr, getColumIndex(spr,"PriceOrder"), xRow)
     If  getColumIndex(spr,"PriceOrderExchange") > -1 then z1003.PriceOrderExchange = getDataM(spr, getColumIndex(spr,"PriceOrderExchange"), xRow)
     If  getColumIndex(spr,"DateOrderExchange") > -1 then z1003.DateOrderExchange = getDataM(spr, getColumIndex(spr,"DateOrderExchange"), xRow)
     If  getColumIndex(spr,"PriceOrderUSD") > -1 then z1003.PriceOrderUSD = getDataM(spr, getColumIndex(spr,"PriceOrderUSD"), xRow)
     If  getColumIndex(spr,"PriceOrderVND") > -1 then z1003.PriceOrderVND = getDataM(spr, getColumIndex(spr,"PriceOrderVND"), xRow)
     If  getColumIndex(spr,"PriceQuotationOrder") > -1 then z1003.PriceQuotationOrder = getDataM(spr, getColumIndex(spr,"PriceQuotationOrder"), xRow)
     If  getColumIndex(spr,"PriceQuotationExchange") > -1 then z1003.PriceQuotationExchange = getDataM(spr, getColumIndex(spr,"PriceQuotationExchange"), xRow)
     If  getColumIndex(spr,"DateQuotationExchange") > -1 then z1003.DateQuotationExchange = getDataM(spr, getColumIndex(spr,"DateQuotationExchange"), xRow)
     If  getColumIndex(spr,"PriceQuotationUSD") > -1 then z1003.PriceQuotationUSD = getDataM(spr, getColumIndex(spr,"PriceQuotationUSD"), xRow)
     If  getColumIndex(spr,"PriceQuotationVND") > -1 then z1003.PriceQuotationVND = getDataM(spr, getColumIndex(spr,"PriceQuotationVND"), xRow)
     If  getColumIndex(spr,"PriceUSD") > -1 then z1003.PriceUSD = getDataM(spr, getColumIndex(spr,"PriceUSD"), xRow)
     If  getColumIndex(spr,"PriceVND") > -1 then z1003.PriceVND = getDataM(spr, getColumIndex(spr,"PriceVND"), xRow)
     If  getColumIndex(spr,"BoxOrder") > -1 then z1003.BoxOrder = getDataM(spr, getColumIndex(spr,"BoxOrder"), xRow)
     If  getColumIndex(spr,"QtyOrder") > -1 then z1003.QtyOrder = getDataM(spr, getColumIndex(spr,"QtyOrder"), xRow)
     If  getColumIndex(spr,"TaxExport") > -1 then z1003.TaxExport = getDataM(spr, getColumIndex(spr,"TaxExport"), xRow)
     If  getColumIndex(spr,"TaxEnvironment") > -1 then z1003.TaxEnvironment = getDataM(spr, getColumIndex(spr,"TaxEnvironment"), xRow)
     If  getColumIndex(spr,"TaxVat") > -1 then z1003.TaxVat = getDataM(spr, getColumIndex(spr,"TaxVat"), xRow)
     If  getColumIndex(spr,"AmountNetOrderUSD") > -1 then z1003.AmountNetOrderUSD = getDataM(spr, getColumIndex(spr,"AmountNetOrderUSD"), xRow)
     If  getColumIndex(spr,"AmountNetOrderVND") > -1 then z1003.AmountNetOrderVND = getDataM(spr, getColumIndex(spr,"AmountNetOrderVND"), xRow)
     If  getColumIndex(spr,"AmountTaxExport") > -1 then z1003.AmountTaxExport = getDataM(spr, getColumIndex(spr,"AmountTaxExport"), xRow)
     If  getColumIndex(spr,"AmountTaxEnvironment") > -1 then z1003.AmountTaxEnvironment = getDataM(spr, getColumIndex(spr,"AmountTaxEnvironment"), xRow)
     If  getColumIndex(spr,"AmountTaxVat") > -1 then z1003.AmountTaxVat = getDataM(spr, getColumIndex(spr,"AmountTaxVat"), xRow)
     If  getColumIndex(spr,"AmountOrderUSD") > -1 then z1003.AmountOrderUSD = getDataM(spr, getColumIndex(spr,"AmountOrderUSD"), xRow)
     If  getColumIndex(spr,"AmountOrderVND") > -1 then z1003.AmountOrderVND = getDataM(spr, getColumIndex(spr,"AmountOrderVND"), xRow)
     If  getColumIndex(spr,"AmountQuotationUSD") > -1 then z1003.AmountQuotationUSD = getDataM(spr, getColumIndex(spr,"AmountQuotationUSD"), xRow)
     If  getColumIndex(spr,"AmountQuotationVND") > -1 then z1003.AmountQuotationVND = getDataM(spr, getColumIndex(spr,"AmountQuotationVND"), xRow)
     If  getColumIndex(spr,"BoxOutbound") > -1 then z1003.BoxOutbound = getDataM(spr, getColumIndex(spr,"BoxOutbound"), xRow)
     If  getColumIndex(spr,"QtyOutbound") > -1 then z1003.QtyOutbound = getDataM(spr, getColumIndex(spr,"QtyOutbound"), xRow)
     If  getColumIndex(spr,"AmountOutboundUSD") > -1 then z1003.AmountOutboundUSD = getDataM(spr, getColumIndex(spr,"AmountOutboundUSD"), xRow)
     If  getColumIndex(spr,"AmountOutboundVND") > -1 then z1003.AmountOutboundVND = getDataM(spr, getColumIndex(spr,"AmountOutboundVND"), xRow)
     If  getColumIndex(spr,"CheckPromotion") > -1 then z1003.CheckPromotion = getDataM(spr, getColumIndex(spr,"CheckPromotion"), xRow)
     If  getColumIndex(spr,"CheckOrder") > -1 then z1003.CheckOrder = getDataM(spr, getColumIndex(spr,"CheckOrder"), xRow)
     If  getColumIndex(spr,"DateDelivery") > -1 then z1003.DateDelivery = getDataM(spr, getColumIndex(spr,"DateDelivery"), xRow)
     If  getColumIndex(spr,"DateRequestOrder") > -1 then z1003.DateRequestOrder = getDataM(spr, getColumIndex(spr,"DateRequestOrder"), xRow)
     If  getColumIndex(spr,"DateApprovalOrder") > -1 then z1003.DateApprovalOrder = getDataM(spr, getColumIndex(spr,"DateApprovalOrder"), xRow)
     If  getColumIndex(spr,"DateCancelOrder") > -1 then z1003.DateCancelOrder = getDataM(spr, getColumIndex(spr,"DateCancelOrder"), xRow)
     If  getColumIndex(spr,"DateCompleteOrder") > -1 then z1003.DateCompleteOrder = getDataM(spr, getColumIndex(spr,"DateCompleteOrder"), xRow)
     If  getColumIndex(spr,"QuotationNo") > -1 then z1003.QuotationNo = getDataM(spr, getColumIndex(spr,"QuotationNo"), xRow)
     If  getColumIndex(spr,"QuotationSeq") > -1 then z1003.QuotationSeq = getDataM(spr, getColumIndex(spr,"QuotationSeq"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z1003.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K1003_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K1003_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z1003 As T1003_AREA, Job as String,ORDERNO AS String, ORDERSEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K1003_MOVE = False

Try
    If READ_PFK1003(ORDERNO, ORDERSEQ) = True Then
                z1003 = D1003
		K1003_MOVE = True
		else
		 z1003 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK1003")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "OrderNo":z1003.OrderNo = Children(i).Code
   Case "OrderSeq":z1003.OrderSeq = Children(i).Code
   Case "Dseq":z1003.Dseq = Children(i).Code
   Case "MaterialCode":z1003.MaterialCode = Children(i).Code
   Case "cdUnitPrice":z1003.cdUnitPrice = Children(i).Code
   Case "PriceOrder":z1003.PriceOrder = Children(i).Code
   Case "PriceOrderExchange":z1003.PriceOrderExchange = Children(i).Code
   Case "DateOrderExchange":z1003.DateOrderExchange = Children(i).Code
   Case "PriceOrderUSD":z1003.PriceOrderUSD = Children(i).Code
   Case "PriceOrderVND":z1003.PriceOrderVND = Children(i).Code
   Case "PriceQuotationOrder":z1003.PriceQuotationOrder = Children(i).Code
   Case "PriceQuotationExchange":z1003.PriceQuotationExchange = Children(i).Code
   Case "DateQuotationExchange":z1003.DateQuotationExchange = Children(i).Code
   Case "PriceQuotationUSD":z1003.PriceQuotationUSD = Children(i).Code
   Case "PriceQuotationVND":z1003.PriceQuotationVND = Children(i).Code
   Case "PriceUSD":z1003.PriceUSD = Children(i).Code
   Case "PriceVND":z1003.PriceVND = Children(i).Code
   Case "BoxOrder":z1003.BoxOrder = Children(i).Code
   Case "QtyOrder":z1003.QtyOrder = Children(i).Code
   Case "TaxExport":z1003.TaxExport = Children(i).Code
   Case "TaxEnvironment":z1003.TaxEnvironment = Children(i).Code
   Case "TaxVat":z1003.TaxVat = Children(i).Code
   Case "AmountNetOrderUSD":z1003.AmountNetOrderUSD = Children(i).Code
   Case "AmountNetOrderVND":z1003.AmountNetOrderVND = Children(i).Code
   Case "AmountTaxExport":z1003.AmountTaxExport = Children(i).Code
   Case "AmountTaxEnvironment":z1003.AmountTaxEnvironment = Children(i).Code
   Case "AmountTaxVat":z1003.AmountTaxVat = Children(i).Code
   Case "AmountOrderUSD":z1003.AmountOrderUSD = Children(i).Code
   Case "AmountOrderVND":z1003.AmountOrderVND = Children(i).Code
   Case "AmountQuotationUSD":z1003.AmountQuotationUSD = Children(i).Code
   Case "AmountQuotationVND":z1003.AmountQuotationVND = Children(i).Code
   Case "BoxOutbound":z1003.BoxOutbound = Children(i).Code
   Case "QtyOutbound":z1003.QtyOutbound = Children(i).Code
   Case "AmountOutboundUSD":z1003.AmountOutboundUSD = Children(i).Code
   Case "AmountOutboundVND":z1003.AmountOutboundVND = Children(i).Code
   Case "CheckPromotion":z1003.CheckPromotion = Children(i).Code
   Case "CheckOrder":z1003.CheckOrder = Children(i).Code
   Case "DateDelivery":z1003.DateDelivery = Children(i).Code
   Case "DateRequestOrder":z1003.DateRequestOrder = Children(i).Code
   Case "DateApprovalOrder":z1003.DateApprovalOrder = Children(i).Code
   Case "DateCancelOrder":z1003.DateCancelOrder = Children(i).Code
   Case "DateCompleteOrder":z1003.DateCompleteOrder = Children(i).Code
   Case "QuotationNo":z1003.QuotationNo = Children(i).Code
   Case "QuotationSeq":z1003.QuotationSeq = Children(i).Code
   Case "Remark":z1003.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "OrderNo":z1003.OrderNo = Children(i).Data
   Case "OrderSeq":z1003.OrderSeq = Children(i).Data
   Case "Dseq":z1003.Dseq = Children(i).Data
   Case "MaterialCode":z1003.MaterialCode = Children(i).Data
   Case "cdUnitPrice":z1003.cdUnitPrice = Children(i).Data
   Case "PriceOrder":z1003.PriceOrder = Children(i).Data
   Case "PriceOrderExchange":z1003.PriceOrderExchange = Children(i).Data
   Case "DateOrderExchange":z1003.DateOrderExchange = Children(i).Data
   Case "PriceOrderUSD":z1003.PriceOrderUSD = Children(i).Data
   Case "PriceOrderVND":z1003.PriceOrderVND = Children(i).Data
   Case "PriceQuotationOrder":z1003.PriceQuotationOrder = Children(i).Data
   Case "PriceQuotationExchange":z1003.PriceQuotationExchange = Children(i).Data
   Case "DateQuotationExchange":z1003.DateQuotationExchange = Children(i).Data
   Case "PriceQuotationUSD":z1003.PriceQuotationUSD = Children(i).Data
   Case "PriceQuotationVND":z1003.PriceQuotationVND = Children(i).Data
   Case "PriceUSD":z1003.PriceUSD = Children(i).Data
   Case "PriceVND":z1003.PriceVND = Children(i).Data
   Case "BoxOrder":z1003.BoxOrder = Children(i).Data
   Case "QtyOrder":z1003.QtyOrder = Children(i).Data
   Case "TaxExport":z1003.TaxExport = Children(i).Data
   Case "TaxEnvironment":z1003.TaxEnvironment = Children(i).Data
   Case "TaxVat":z1003.TaxVat = Children(i).Data
   Case "AmountNetOrderUSD":z1003.AmountNetOrderUSD = Children(i).Data
   Case "AmountNetOrderVND":z1003.AmountNetOrderVND = Children(i).Data
   Case "AmountTaxExport":z1003.AmountTaxExport = Children(i).Data
   Case "AmountTaxEnvironment":z1003.AmountTaxEnvironment = Children(i).Data
   Case "AmountTaxVat":z1003.AmountTaxVat = Children(i).Data
   Case "AmountOrderUSD":z1003.AmountOrderUSD = Children(i).Data
   Case "AmountOrderVND":z1003.AmountOrderVND = Children(i).Data
   Case "AmountQuotationUSD":z1003.AmountQuotationUSD = Children(i).Data
   Case "AmountQuotationVND":z1003.AmountQuotationVND = Children(i).Data
   Case "BoxOutbound":z1003.BoxOutbound = Children(i).Data
   Case "QtyOutbound":z1003.QtyOutbound = Children(i).Data
   Case "AmountOutboundUSD":z1003.AmountOutboundUSD = Children(i).Data
   Case "AmountOutboundVND":z1003.AmountOutboundVND = Children(i).Data
   Case "CheckPromotion":z1003.CheckPromotion = Children(i).Data
   Case "CheckOrder":z1003.CheckOrder = Children(i).Data
   Case "DateDelivery":z1003.DateDelivery = Children(i).Data
   Case "DateRequestOrder":z1003.DateRequestOrder = Children(i).Data
   Case "DateApprovalOrder":z1003.DateApprovalOrder = Children(i).Data
   Case "DateCancelOrder":z1003.DateCancelOrder = Children(i).Data
   Case "DateCompleteOrder":z1003.DateCompleteOrder = Children(i).Data
   Case "QuotationNo":z1003.QuotationNo = Children(i).Data
   Case "QuotationSeq":z1003.QuotationSeq = Children(i).Data
   Case "Remark":z1003.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K1003_MOVE",vbCritical)
End Try
End Function 
    
End Module 
