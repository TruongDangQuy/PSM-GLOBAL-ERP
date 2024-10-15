'=========================================================================================================================================================
'   TABLE : (PFK1000)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K1000

Structure T1000_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	OrderNo	 AS String	'			char(9)		*
Public 	OrderNoBefore	 AS String	'			char(9)
Public 	InvoiceNo	 AS String	'			nvarchar(20)
Public 	CheckProcessOrder	 AS String	'			char(1)
Public 	CheckMarketType	 AS String	'			char(1)
Public 	cdPaymentCondition	 AS String	'			char(3)
Public 	InchargeOrder	 AS String	'			char(8)
Public 	SupplyCode	 AS String	'			char(6)
Public 	CheckRequestOrder	 AS String	'			nchar(10)
Public 	DateRequestOrder	 AS String	'			char(8)
Public 	DateApprovalOrder	 AS String	'			char(8)
Public 	DateCancelOrder	 AS String	'			char(8)
Public 	DateCompleteOrder	 AS String	'			char(8)
Public 	DateDeliveryOrder	 AS String	'			char(8)
Public 	AmountOrderUSD	 AS Double	'			decimal
Public 	AmountOrderVND	 AS Double	'			decimal
Public 	AmountQuotationUSD	 AS Double	'			decimal
Public 	AmountQuotationVND	 AS Double	'			decimal
Public 	BoxOutbound	 AS Double	'			decimal
Public 	QtyOutbound	 AS Double	'			decimal
Public 	AmountOutboundUSD	 AS Double	'			decimal
Public 	AmountOutboundVND	 AS Double	'			decimal
Public 	QuotationNo	 AS String	'			char(9)
Public 	Remark	 AS String	'			nchar(200)
'=========================================================================================================================================================
End structure

Public D1000 As T1000_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK1000(ORDERNO AS String) As Boolean
    READ_PFK1000 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK1000 "
    SQL = SQL & " WHERE K1000_OrderNo		 = '" & OrderNo & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D1000_CLEAR: GoTo SKIP_READ_PFK1000
                
    Call K1000_MOVE(rd)
    READ_PFK1000 = True

SKIP_READ_PFK1000:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK1000",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK1000(ORDERNO AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK1000 "
    SQL = SQL & " WHERE K1000_OrderNo		 = '" & OrderNo & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK1000",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK1000(z1000 As T1000_AREA) As Boolean
    WRITE_PFK1000 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z1000)
 
    SQL = " INSERT INTO PFK1000 "
    SQL = SQL & " ( "
    SQL = SQL & " K1000_OrderNo," 
    SQL = SQL & " K1000_OrderNoBefore," 
    SQL = SQL & " K1000_InvoiceNo," 
    SQL = SQL & " K1000_CheckProcessOrder," 
    SQL = SQL & " K1000_CheckMarketType," 
    SQL = SQL & " K1000_cdPaymentCondition," 
    SQL = SQL & " K1000_InchargeOrder," 
    SQL = SQL & " K1000_SupplyCode," 
    SQL = SQL & " K1000_CheckRequestOrder," 
    SQL = SQL & " K1000_DateRequestOrder," 
    SQL = SQL & " K1000_DateApprovalOrder," 
    SQL = SQL & " K1000_DateCancelOrder," 
    SQL = SQL & " K1000_DateCompleteOrder," 
    SQL = SQL & " K1000_DateDeliveryOrder," 
    SQL = SQL & " K1000_AmountOrderUSD," 
    SQL = SQL & " K1000_AmountOrderVND," 
    SQL = SQL & " K1000_AmountQuotationUSD," 
    SQL = SQL & " K1000_AmountQuotationVND," 
    SQL = SQL & " K1000_BoxOutbound," 
    SQL = SQL & " K1000_QtyOutbound," 
    SQL = SQL & " K1000_AmountOutboundUSD," 
    SQL = SQL & " K1000_AmountOutboundVND," 
    SQL = SQL & " K1000_QuotationNo," 
    SQL = SQL & " K1000_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & z1000.OrderNo & "', "  
    SQL = SQL & "  N'" & z1000.OrderNoBefore & "', "  
    SQL = SQL & "  N'" & z1000.InvoiceNo & "', "  
    SQL = SQL & "  N'" & z1000.CheckProcessOrder & "', "  
    SQL = SQL & "  N'" & z1000.CheckMarketType & "', "  
    SQL = SQL & "  N'" & z1000.cdPaymentCondition & "', "  
    SQL = SQL & "  N'" & z1000.InchargeOrder & "', "  
    SQL = SQL & "  N'" & z1000.SupplyCode & "', "  
    SQL = SQL & "  N'" & z1000.CheckRequestOrder & "', "  
    SQL = SQL & "  N'" & z1000.DateRequestOrder & "', "  
    SQL = SQL & "  N'" & z1000.DateApprovalOrder & "', "  
    SQL = SQL & "  N'" & z1000.DateCancelOrder & "', "  
    SQL = SQL & "  N'" & z1000.DateCompleteOrder & "', "  
    SQL = SQL & "  N'" & z1000.DateDeliveryOrder & "', "  
    SQL = SQL & "   " & z1000.AmountOrderUSD & ", "  
    SQL = SQL & "   " & z1000.AmountOrderVND & ", "  
    SQL = SQL & "   " & z1000.AmountQuotationUSD & ", "  
    SQL = SQL & "   " & z1000.AmountQuotationVND & ", "  
    SQL = SQL & "   " & z1000.BoxOutbound & ", "  
    SQL = SQL & "   " & z1000.QtyOutbound & ", "  
    SQL = SQL & "   " & z1000.AmountOutboundUSD & ", "  
    SQL = SQL & "   " & z1000.AmountOutboundVND & ", "  
    SQL = SQL & "  N'" & z1000.QuotationNo & "', "  
    SQL = SQL & "  N'" & z1000.Remark & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK1000 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK1000",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK1000(z1000 As T1000_AREA) As Boolean
    REWRITE_PFK1000 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z1000)
   
    SQL = " UPDATE PFK1000 SET "
    SQL = SQL & "    K1000_OrderNoBefore      = N'" & z1000.OrderNoBefore & "', " 
    SQL = SQL & "    K1000_InvoiceNo      = N'" & z1000.InvoiceNo & "', " 
    SQL = SQL & "    K1000_CheckProcessOrder      = N'" & z1000.CheckProcessOrder & "', " 
    SQL = SQL & "    K1000_CheckMarketType      = N'" & z1000.CheckMarketType & "', " 
    SQL = SQL & "    K1000_cdPaymentCondition      = N'" & z1000.cdPaymentCondition & "', " 
    SQL = SQL & "    K1000_InchargeOrder      = N'" & z1000.InchargeOrder & "', " 
    SQL = SQL & "    K1000_SupplyCode      = N'" & z1000.SupplyCode & "', " 
    SQL = SQL & "    K1000_CheckRequestOrder      = N'" & z1000.CheckRequestOrder & "', " 
    SQL = SQL & "    K1000_DateRequestOrder      = N'" & z1000.DateRequestOrder & "', " 
    SQL = SQL & "    K1000_DateApprovalOrder      = N'" & z1000.DateApprovalOrder & "', " 
    SQL = SQL & "    K1000_DateCancelOrder      = N'" & z1000.DateCancelOrder & "', " 
    SQL = SQL & "    K1000_DateCompleteOrder      = N'" & z1000.DateCompleteOrder & "', " 
    SQL = SQL & "    K1000_DateDeliveryOrder      = N'" & z1000.DateDeliveryOrder & "', " 
    SQL = SQL & "    K1000_AmountOrderUSD      =  " & z1000.AmountOrderUSD & ", " 
    SQL = SQL & "    K1000_AmountOrderVND      =  " & z1000.AmountOrderVND & ", " 
    SQL = SQL & "    K1000_AmountQuotationUSD      =  " & z1000.AmountQuotationUSD & ", " 
    SQL = SQL & "    K1000_AmountQuotationVND      =  " & z1000.AmountQuotationVND & ", " 
    SQL = SQL & "    K1000_BoxOutbound      =  " & z1000.BoxOutbound & ", " 
    SQL = SQL & "    K1000_QtyOutbound      =  " & z1000.QtyOutbound & ", " 
    SQL = SQL & "    K1000_AmountOutboundUSD      =  " & z1000.AmountOutboundUSD & ", " 
    SQL = SQL & "    K1000_AmountOutboundVND      =  " & z1000.AmountOutboundVND & ", " 
    SQL = SQL & "    K1000_QuotationNo      = N'" & z1000.QuotationNo & "', " 
    SQL = SQL & "    K1000_Remark      = N'" & z1000.Remark & "'  " 
    SQL = SQL & " WHERE K1000_OrderNo		 = '" & z1000.OrderNo & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK1000 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK1000",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK1000(z1000 As T1000_AREA) As Boolean
    DELETE_PFK1000 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK1000 "
    SQL = SQL & " WHERE K1000_OrderNo		 = '" & z1000.OrderNo & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK1000 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK1000",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D1000_CLEAR()
Try
    
   D1000.OrderNo = ""
   D1000.OrderNoBefore = ""
   D1000.InvoiceNo = ""
   D1000.CheckProcessOrder = ""
   D1000.CheckMarketType = ""
   D1000.cdPaymentCondition = ""
   D1000.InchargeOrder = ""
   D1000.SupplyCode = ""
   D1000.CheckRequestOrder = ""
   D1000.DateRequestOrder = ""
   D1000.DateApprovalOrder = ""
   D1000.DateCancelOrder = ""
   D1000.DateCompleteOrder = ""
   D1000.DateDeliveryOrder = ""
    D1000.AmountOrderUSD = 0 
    D1000.AmountOrderVND = 0 
    D1000.AmountQuotationUSD = 0 
    D1000.AmountQuotationVND = 0 
    D1000.BoxOutbound = 0 
    D1000.QtyOutbound = 0 
    D1000.AmountOutboundUSD = 0 
    D1000.AmountOutboundVND = 0 
   D1000.QuotationNo = ""
   D1000.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D1000_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x1000 As T1000_AREA)
Try
    
    x1000.OrderNo = trim$(  x1000.OrderNo)
    x1000.OrderNoBefore = trim$(  x1000.OrderNoBefore)
    x1000.InvoiceNo = trim$(  x1000.InvoiceNo)
    x1000.CheckProcessOrder = trim$(  x1000.CheckProcessOrder)
    x1000.CheckMarketType = trim$(  x1000.CheckMarketType)
    x1000.cdPaymentCondition = trim$(  x1000.cdPaymentCondition)
    x1000.InchargeOrder = trim$(  x1000.InchargeOrder)
    x1000.SupplyCode = trim$(  x1000.SupplyCode)
    x1000.CheckRequestOrder = trim$(  x1000.CheckRequestOrder)
    x1000.DateRequestOrder = trim$(  x1000.DateRequestOrder)
    x1000.DateApprovalOrder = trim$(  x1000.DateApprovalOrder)
    x1000.DateCancelOrder = trim$(  x1000.DateCancelOrder)
    x1000.DateCompleteOrder = trim$(  x1000.DateCompleteOrder)
    x1000.DateDeliveryOrder = trim$(  x1000.DateDeliveryOrder)
    x1000.AmountOrderUSD = trim$(  x1000.AmountOrderUSD)
    x1000.AmountOrderVND = trim$(  x1000.AmountOrderVND)
    x1000.AmountQuotationUSD = trim$(  x1000.AmountQuotationUSD)
    x1000.AmountQuotationVND = trim$(  x1000.AmountQuotationVND)
    x1000.BoxOutbound = trim$(  x1000.BoxOutbound)
    x1000.QtyOutbound = trim$(  x1000.QtyOutbound)
    x1000.AmountOutboundUSD = trim$(  x1000.AmountOutboundUSD)
    x1000.AmountOutboundVND = trim$(  x1000.AmountOutboundVND)
    x1000.QuotationNo = trim$(  x1000.QuotationNo)
    x1000.Remark = trim$(  x1000.Remark)
     
    If trim$( x1000.OrderNo ) = "" Then x1000.OrderNo = Space(1) 
    If trim$( x1000.OrderNoBefore ) = "" Then x1000.OrderNoBefore = Space(1) 
    If trim$( x1000.InvoiceNo ) = "" Then x1000.InvoiceNo = Space(1) 
    If trim$( x1000.CheckProcessOrder ) = "" Then x1000.CheckProcessOrder = Space(1) 
    If trim$( x1000.CheckMarketType ) = "" Then x1000.CheckMarketType = Space(1) 
    If trim$( x1000.cdPaymentCondition ) = "" Then x1000.cdPaymentCondition = Space(1) 
    If trim$( x1000.InchargeOrder ) = "" Then x1000.InchargeOrder = Space(1) 
    If trim$( x1000.SupplyCode ) = "" Then x1000.SupplyCode = Space(1) 
    If trim$( x1000.CheckRequestOrder ) = "" Then x1000.CheckRequestOrder = Space(1) 
    If trim$( x1000.DateRequestOrder ) = "" Then x1000.DateRequestOrder = Space(1) 
    If trim$( x1000.DateApprovalOrder ) = "" Then x1000.DateApprovalOrder = Space(1) 
    If trim$( x1000.DateCancelOrder ) = "" Then x1000.DateCancelOrder = Space(1) 
    If trim$( x1000.DateCompleteOrder ) = "" Then x1000.DateCompleteOrder = Space(1) 
    If trim$( x1000.DateDeliveryOrder ) = "" Then x1000.DateDeliveryOrder = Space(1) 
    If trim$( x1000.AmountOrderUSD ) = "" Then x1000.AmountOrderUSD = 0 
    If trim$( x1000.AmountOrderVND ) = "" Then x1000.AmountOrderVND = 0 
    If trim$( x1000.AmountQuotationUSD ) = "" Then x1000.AmountQuotationUSD = 0 
    If trim$( x1000.AmountQuotationVND ) = "" Then x1000.AmountQuotationVND = 0 
    If trim$( x1000.BoxOutbound ) = "" Then x1000.BoxOutbound = 0 
    If trim$( x1000.QtyOutbound ) = "" Then x1000.QtyOutbound = 0 
    If trim$( x1000.AmountOutboundUSD ) = "" Then x1000.AmountOutboundUSD = 0 
    If trim$( x1000.AmountOutboundVND ) = "" Then x1000.AmountOutboundVND = 0 
    If trim$( x1000.QuotationNo ) = "" Then x1000.QuotationNo = Space(1) 
    If trim$( x1000.Remark ) = "" Then x1000.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K1000_MOVE(rs1000 As SqlClient.SqlDataReader)
Try

    call D1000_CLEAR()   

    If IsdbNull(rs1000!K1000_OrderNo) = False Then D1000.OrderNo = Trim$(rs1000!K1000_OrderNo)
    If IsdbNull(rs1000!K1000_OrderNoBefore) = False Then D1000.OrderNoBefore = Trim$(rs1000!K1000_OrderNoBefore)
    If IsdbNull(rs1000!K1000_InvoiceNo) = False Then D1000.InvoiceNo = Trim$(rs1000!K1000_InvoiceNo)
    If IsdbNull(rs1000!K1000_CheckProcessOrder) = False Then D1000.CheckProcessOrder = Trim$(rs1000!K1000_CheckProcessOrder)
    If IsdbNull(rs1000!K1000_CheckMarketType) = False Then D1000.CheckMarketType = Trim$(rs1000!K1000_CheckMarketType)
    If IsdbNull(rs1000!K1000_cdPaymentCondition) = False Then D1000.cdPaymentCondition = Trim$(rs1000!K1000_cdPaymentCondition)
    If IsdbNull(rs1000!K1000_InchargeOrder) = False Then D1000.InchargeOrder = Trim$(rs1000!K1000_InchargeOrder)
    If IsdbNull(rs1000!K1000_SupplyCode) = False Then D1000.SupplyCode = Trim$(rs1000!K1000_SupplyCode)
    If IsdbNull(rs1000!K1000_CheckRequestOrder) = False Then D1000.CheckRequestOrder = Trim$(rs1000!K1000_CheckRequestOrder)
    If IsdbNull(rs1000!K1000_DateRequestOrder) = False Then D1000.DateRequestOrder = Trim$(rs1000!K1000_DateRequestOrder)
    If IsdbNull(rs1000!K1000_DateApprovalOrder) = False Then D1000.DateApprovalOrder = Trim$(rs1000!K1000_DateApprovalOrder)
    If IsdbNull(rs1000!K1000_DateCancelOrder) = False Then D1000.DateCancelOrder = Trim$(rs1000!K1000_DateCancelOrder)
    If IsdbNull(rs1000!K1000_DateCompleteOrder) = False Then D1000.DateCompleteOrder = Trim$(rs1000!K1000_DateCompleteOrder)
    If IsdbNull(rs1000!K1000_DateDeliveryOrder) = False Then D1000.DateDeliveryOrder = Trim$(rs1000!K1000_DateDeliveryOrder)
    If IsdbNull(rs1000!K1000_AmountOrderUSD) = False Then D1000.AmountOrderUSD = Trim$(rs1000!K1000_AmountOrderUSD)
    If IsdbNull(rs1000!K1000_AmountOrderVND) = False Then D1000.AmountOrderVND = Trim$(rs1000!K1000_AmountOrderVND)
    If IsdbNull(rs1000!K1000_AmountQuotationUSD) = False Then D1000.AmountQuotationUSD = Trim$(rs1000!K1000_AmountQuotationUSD)
    If IsdbNull(rs1000!K1000_AmountQuotationVND) = False Then D1000.AmountQuotationVND = Trim$(rs1000!K1000_AmountQuotationVND)
    If IsdbNull(rs1000!K1000_BoxOutbound) = False Then D1000.BoxOutbound = Trim$(rs1000!K1000_BoxOutbound)
    If IsdbNull(rs1000!K1000_QtyOutbound) = False Then D1000.QtyOutbound = Trim$(rs1000!K1000_QtyOutbound)
    If IsdbNull(rs1000!K1000_AmountOutboundUSD) = False Then D1000.AmountOutboundUSD = Trim$(rs1000!K1000_AmountOutboundUSD)
    If IsdbNull(rs1000!K1000_AmountOutboundVND) = False Then D1000.AmountOutboundVND = Trim$(rs1000!K1000_AmountOutboundVND)
    If IsdbNull(rs1000!K1000_QuotationNo) = False Then D1000.QuotationNo = Trim$(rs1000!K1000_QuotationNo)
    If IsdbNull(rs1000!K1000_Remark) = False Then D1000.Remark = Trim$(rs1000!K1000_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K1000_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K1000_MOVE(rs1000 As DataRow)
Try

    call D1000_CLEAR()   

    If IsdbNull(rs1000!K1000_OrderNo) = False Then D1000.OrderNo = Trim$(rs1000!K1000_OrderNo)
    If IsdbNull(rs1000!K1000_OrderNoBefore) = False Then D1000.OrderNoBefore = Trim$(rs1000!K1000_OrderNoBefore)
    If IsdbNull(rs1000!K1000_InvoiceNo) = False Then D1000.InvoiceNo = Trim$(rs1000!K1000_InvoiceNo)
    If IsdbNull(rs1000!K1000_CheckProcessOrder) = False Then D1000.CheckProcessOrder = Trim$(rs1000!K1000_CheckProcessOrder)
    If IsdbNull(rs1000!K1000_CheckMarketType) = False Then D1000.CheckMarketType = Trim$(rs1000!K1000_CheckMarketType)
    If IsdbNull(rs1000!K1000_cdPaymentCondition) = False Then D1000.cdPaymentCondition = Trim$(rs1000!K1000_cdPaymentCondition)
    If IsdbNull(rs1000!K1000_InchargeOrder) = False Then D1000.InchargeOrder = Trim$(rs1000!K1000_InchargeOrder)
    If IsdbNull(rs1000!K1000_SupplyCode) = False Then D1000.SupplyCode = Trim$(rs1000!K1000_SupplyCode)
    If IsdbNull(rs1000!K1000_CheckRequestOrder) = False Then D1000.CheckRequestOrder = Trim$(rs1000!K1000_CheckRequestOrder)
    If IsdbNull(rs1000!K1000_DateRequestOrder) = False Then D1000.DateRequestOrder = Trim$(rs1000!K1000_DateRequestOrder)
    If IsdbNull(rs1000!K1000_DateApprovalOrder) = False Then D1000.DateApprovalOrder = Trim$(rs1000!K1000_DateApprovalOrder)
    If IsdbNull(rs1000!K1000_DateCancelOrder) = False Then D1000.DateCancelOrder = Trim$(rs1000!K1000_DateCancelOrder)
    If IsdbNull(rs1000!K1000_DateCompleteOrder) = False Then D1000.DateCompleteOrder = Trim$(rs1000!K1000_DateCompleteOrder)
    If IsdbNull(rs1000!K1000_DateDeliveryOrder) = False Then D1000.DateDeliveryOrder = Trim$(rs1000!K1000_DateDeliveryOrder)
    If IsdbNull(rs1000!K1000_AmountOrderUSD) = False Then D1000.AmountOrderUSD = Trim$(rs1000!K1000_AmountOrderUSD)
    If IsdbNull(rs1000!K1000_AmountOrderVND) = False Then D1000.AmountOrderVND = Trim$(rs1000!K1000_AmountOrderVND)
    If IsdbNull(rs1000!K1000_AmountQuotationUSD) = False Then D1000.AmountQuotationUSD = Trim$(rs1000!K1000_AmountQuotationUSD)
    If IsdbNull(rs1000!K1000_AmountQuotationVND) = False Then D1000.AmountQuotationVND = Trim$(rs1000!K1000_AmountQuotationVND)
    If IsdbNull(rs1000!K1000_BoxOutbound) = False Then D1000.BoxOutbound = Trim$(rs1000!K1000_BoxOutbound)
    If IsdbNull(rs1000!K1000_QtyOutbound) = False Then D1000.QtyOutbound = Trim$(rs1000!K1000_QtyOutbound)
    If IsdbNull(rs1000!K1000_AmountOutboundUSD) = False Then D1000.AmountOutboundUSD = Trim$(rs1000!K1000_AmountOutboundUSD)
    If IsdbNull(rs1000!K1000_AmountOutboundVND) = False Then D1000.AmountOutboundVND = Trim$(rs1000!K1000_AmountOutboundVND)
    If IsdbNull(rs1000!K1000_QuotationNo) = False Then D1000.QuotationNo = Trim$(rs1000!K1000_QuotationNo)
    If IsdbNull(rs1000!K1000_Remark) = False Then D1000.Remark = Trim$(rs1000!K1000_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K1000_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K1000_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z1000 As T1000_AREA,ORDERNO AS String) as Boolean

K1000_MOVE = False

Try
    If READ_PFK1000(ORDERNO) = True Then
                z1000 = D1000
		K1000_MOVE = True
		else
		 z1000 = nothing
     End If

     If  getColumIndex(spr,"OrderNo") > -1 then z1000.OrderNo = getDataM(spr, getColumIndex(spr,"OrderNo"), xRow)
     If  getColumIndex(spr,"OrderNoBefore") > -1 then z1000.OrderNoBefore = getDataM(spr, getColumIndex(spr,"OrderNoBefore"), xRow)
     If  getColumIndex(spr,"InvoiceNo") > -1 then z1000.InvoiceNo = getDataM(spr, getColumIndex(spr,"InvoiceNo"), xRow)
     If  getColumIndex(spr,"CheckProcessOrder") > -1 then z1000.CheckProcessOrder = getDataM(spr, getColumIndex(spr,"CheckProcessOrder"), xRow)
     If  getColumIndex(spr,"CheckMarketType") > -1 then z1000.CheckMarketType = getDataM(spr, getColumIndex(spr,"CheckMarketType"), xRow)
     If  getColumIndex(spr,"cdPaymentCondition") > -1 then z1000.cdPaymentCondition = getDataM(spr, getColumIndex(spr,"cdPaymentCondition"), xRow)
     If  getColumIndex(spr,"InchargeOrder") > -1 then z1000.InchargeOrder = getDataM(spr, getColumIndex(spr,"InchargeOrder"), xRow)
     If  getColumIndex(spr,"SupplyCode") > -1 then z1000.SupplyCode = getDataM(spr, getColumIndex(spr,"SupplyCode"), xRow)
     If  getColumIndex(spr,"CheckRequestOrder") > -1 then z1000.CheckRequestOrder = getDataM(spr, getColumIndex(spr,"CheckRequestOrder"), xRow)
     If  getColumIndex(spr,"DateRequestOrder") > -1 then z1000.DateRequestOrder = getDataM(spr, getColumIndex(spr,"DateRequestOrder"), xRow)
     If  getColumIndex(spr,"DateApprovalOrder") > -1 then z1000.DateApprovalOrder = getDataM(spr, getColumIndex(spr,"DateApprovalOrder"), xRow)
     If  getColumIndex(spr,"DateCancelOrder") > -1 then z1000.DateCancelOrder = getDataM(spr, getColumIndex(spr,"DateCancelOrder"), xRow)
     If  getColumIndex(spr,"DateCompleteOrder") > -1 then z1000.DateCompleteOrder = getDataM(spr, getColumIndex(spr,"DateCompleteOrder"), xRow)
     If  getColumIndex(spr,"DateDeliveryOrder") > -1 then z1000.DateDeliveryOrder = getDataM(spr, getColumIndex(spr,"DateDeliveryOrder"), xRow)
     If  getColumIndex(spr,"AmountOrderUSD") > -1 then z1000.AmountOrderUSD = getDataM(spr, getColumIndex(spr,"AmountOrderUSD"), xRow)
     If  getColumIndex(spr,"AmountOrderVND") > -1 then z1000.AmountOrderVND = getDataM(spr, getColumIndex(spr,"AmountOrderVND"), xRow)
     If  getColumIndex(spr,"AmountQuotationUSD") > -1 then z1000.AmountQuotationUSD = getDataM(spr, getColumIndex(spr,"AmountQuotationUSD"), xRow)
     If  getColumIndex(spr,"AmountQuotationVND") > -1 then z1000.AmountQuotationVND = getDataM(spr, getColumIndex(spr,"AmountQuotationVND"), xRow)
     If  getColumIndex(spr,"BoxOutbound") > -1 then z1000.BoxOutbound = getDataM(spr, getColumIndex(spr,"BoxOutbound"), xRow)
     If  getColumIndex(spr,"QtyOutbound") > -1 then z1000.QtyOutbound = getDataM(spr, getColumIndex(spr,"QtyOutbound"), xRow)
     If  getColumIndex(spr,"AmountOutboundUSD") > -1 then z1000.AmountOutboundUSD = getDataM(spr, getColumIndex(spr,"AmountOutboundUSD"), xRow)
     If  getColumIndex(spr,"AmountOutboundVND") > -1 then z1000.AmountOutboundVND = getDataM(spr, getColumIndex(spr,"AmountOutboundVND"), xRow)
     If  getColumIndex(spr,"QuotationNo") > -1 then z1000.QuotationNo = getDataM(spr, getColumIndex(spr,"QuotationNo"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z1000.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K1000_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K1000_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z1000 As T1000_AREA, Job as String,ORDERNO AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K1000_MOVE = False

Try
    If READ_PFK1000(ORDERNO) = True Then
                z1000 = D1000
		K1000_MOVE = True
		else
		 z1000 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK1000")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "OrderNo":z1000.OrderNo = Children(i).Code
   Case "OrderNoBefore":z1000.OrderNoBefore = Children(i).Code
   Case "InvoiceNo":z1000.InvoiceNo = Children(i).Code
   Case "CheckProcessOrder":z1000.CheckProcessOrder = Children(i).Code
   Case "CheckMarketType":z1000.CheckMarketType = Children(i).Code
   Case "cdPaymentCondition":z1000.cdPaymentCondition = Children(i).Code
   Case "InchargeOrder":z1000.InchargeOrder = Children(i).Code
   Case "SupplyCode":z1000.SupplyCode = Children(i).Code
   Case "CheckRequestOrder":z1000.CheckRequestOrder = Children(i).Code
   Case "DateRequestOrder":z1000.DateRequestOrder = Children(i).Code
   Case "DateApprovalOrder":z1000.DateApprovalOrder = Children(i).Code
   Case "DateCancelOrder":z1000.DateCancelOrder = Children(i).Code
   Case "DateCompleteOrder":z1000.DateCompleteOrder = Children(i).Code
   Case "DateDeliveryOrder":z1000.DateDeliveryOrder = Children(i).Code
   Case "AmountOrderUSD":z1000.AmountOrderUSD = Children(i).Code
   Case "AmountOrderVND":z1000.AmountOrderVND = Children(i).Code
   Case "AmountQuotationUSD":z1000.AmountQuotationUSD = Children(i).Code
   Case "AmountQuotationVND":z1000.AmountQuotationVND = Children(i).Code
   Case "BoxOutbound":z1000.BoxOutbound = Children(i).Code
   Case "QtyOutbound":z1000.QtyOutbound = Children(i).Code
   Case "AmountOutboundUSD":z1000.AmountOutboundUSD = Children(i).Code
   Case "AmountOutboundVND":z1000.AmountOutboundVND = Children(i).Code
   Case "QuotationNo":z1000.QuotationNo = Children(i).Code
   Case "Remark":z1000.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "OrderNo":z1000.OrderNo = Children(i).Data
   Case "OrderNoBefore":z1000.OrderNoBefore = Children(i).Data
   Case "InvoiceNo":z1000.InvoiceNo = Children(i).Data
   Case "CheckProcessOrder":z1000.CheckProcessOrder = Children(i).Data
   Case "CheckMarketType":z1000.CheckMarketType = Children(i).Data
   Case "cdPaymentCondition":z1000.cdPaymentCondition = Children(i).Data
   Case "InchargeOrder":z1000.InchargeOrder = Children(i).Data
   Case "SupplyCode":z1000.SupplyCode = Children(i).Data
   Case "CheckRequestOrder":z1000.CheckRequestOrder = Children(i).Data
   Case "DateRequestOrder":z1000.DateRequestOrder = Children(i).Data
   Case "DateApprovalOrder":z1000.DateApprovalOrder = Children(i).Data
   Case "DateCancelOrder":z1000.DateCancelOrder = Children(i).Data
   Case "DateCompleteOrder":z1000.DateCompleteOrder = Children(i).Data
   Case "DateDeliveryOrder":z1000.DateDeliveryOrder = Children(i).Data
   Case "AmountOrderUSD":z1000.AmountOrderUSD = Children(i).Data
   Case "AmountOrderVND":z1000.AmountOrderVND = Children(i).Data
   Case "AmountQuotationUSD":z1000.AmountQuotationUSD = Children(i).Data
   Case "AmountQuotationVND":z1000.AmountQuotationVND = Children(i).Data
   Case "BoxOutbound":z1000.BoxOutbound = Children(i).Data
   Case "QtyOutbound":z1000.QtyOutbound = Children(i).Data
   Case "AmountOutboundUSD":z1000.AmountOutboundUSD = Children(i).Data
   Case "AmountOutboundVND":z1000.AmountOutboundVND = Children(i).Data
   Case "QuotationNo":z1000.QuotationNo = Children(i).Data
   Case "Remark":z1000.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K1000_MOVE",vbCritical)
End Try
End Function 
    
End Module 
