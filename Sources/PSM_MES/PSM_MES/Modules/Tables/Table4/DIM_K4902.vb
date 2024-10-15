'=========================================================================================================================================================
'   TABLE : (PFK4902)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K4902

Structure T4902_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	ShippingWorkOrder	 AS String	'			char(9)		*
Public 	ShippingWorkOrderSeq	 AS String	'			char(3)		*
Public 	JobCard	 AS String	'			char(9)
Public 	CustomerCode	 AS String	'			char(6)
Public 	OrderNo	 AS String	'			char(9)
Public 	OrderNoSeq	 AS String	'			char(3)
Public 	PKO	 AS String	'			char(10)
Public 	Destination	 AS String	'			nvarchar(50)
Public 	Note1	 AS String	'			nvarchar(100)
Public 	Note2	 AS String	'			nvarchar(100)
Public 	Note3	 AS String	'			nvarchar(100)
Public 	Note4	 AS String	'			nvarchar(100)
Public 	Note5	 AS String	'			nvarchar(100)
Public 	ShippingWorkOrderStatus	 AS String	'			char(1)
Public 	DateApproval	 AS String	'			char(8)
Public 	DateCancel	 AS String	'			char(8)
Public 	DateComplete	 AS String	'			char(8)
Public 	DatePending	 AS String	'			char(8)
Public 	DateExchangePrice	 AS String	'			char(8)
Public 	PriceOrder	 AS Double	'			decimal
Public 	seUnitPrice	 AS String	'			char(3)
Public 	cdUnitPrice	 AS String	'			char(3)
Public 	DateExchange	 AS String	'			char(8)
Public 	PriceExchange	 AS Double	'			decimal
Public 	PriceOrderEX	 AS Double	'			decimal
Public 	PriceOrderVND	 AS Double	'			decimal
Public 	Datedelivery	 AS String	'			char(8)
Public 	DateTransfer	 AS String	'			char(8)
Public 	AcceptedOrder	 AS String	'			char(1)
Public 	MaterialStatus	 AS String	'			char(1)
Public 	DateShipping	 AS String	'			char(8)
Public 	seUnitMaterial	 AS String	'			char(3)
Public 	cdUnitMaterial	 AS String	'			char(3)
Public 	seUnitPacking	 AS String	'			char(3)
Public 	cdUnitPacking	 AS String	'			char(3)
Public 	QtyOrder	 AS Double	'			decimal
Public 	QtyShipping	 AS Double	'			decimal
Public 	QtyInbound	 AS Double	'			decimal
Public 	QtyOutbound	 AS Double	'			decimal
Public 	DateInsert	 AS String	'			char(8)
Public 	InchargeInsert	 AS String	'			char(8)
Public 	DateUpdate	 AS String	'			char(8)
Public 	InchargeUpdate	 AS String	'			char(8)
Public 	InchargeShipping	 AS String	'			char(8)
Public 	TotalQty	 AS Double	'			decimal
Public 	TotalAMT	 AS Double	'			decimal
Public 	TotalCost	 AS Double	'			decimal
Public 	TotalProfit	 AS Double	'			decimal
Public 	TotalAMTEX	 AS Double	'			decimal
Public 	TotalCostEX	 AS Double	'			decimal
Public 	TotalProfitEX	 AS Double	'			decimal
Public 	TotalAMTVND	 AS Double	'			decimal
Public 	TotalCostVND	 AS Double	'			decimal
Public 	TotalProfitVND	 AS Double	'			decimal
Public 	AttachID	 AS String	'			char(6)
Public 	Remark	 AS String	'			nvarchar(500)
'=========================================================================================================================================================
End structure

Public D4902 As T4902_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK4902(SHIPPINGWORKORDER AS String, SHIPPINGWORKORDERSEQ AS String) As Boolean
    READ_PFK4902 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK4902 "
    SQL = SQL & " WHERE K4902_ShippingWorkOrder		 = '" & ShippingWorkOrder & "' " 
    SQL = SQL & "   AND K4902_ShippingWorkOrderSeq		 = '" & ShippingWorkOrderSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D4902_CLEAR: GoTo SKIP_READ_PFK4902
                
    Call K4902_MOVE(rd)
    READ_PFK4902 = True

SKIP_READ_PFK4902:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK4902",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK4902(SHIPPINGWORKORDER AS String, SHIPPINGWORKORDERSEQ AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK4902 "
    SQL = SQL & " WHERE K4902_ShippingWorkOrder		 = '" & ShippingWorkOrder & "' " 
    SQL = SQL & "   AND K4902_ShippingWorkOrderSeq		 = '" & ShippingWorkOrderSeq & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK4902",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK4902(z4902 As T4902_AREA) As Boolean
    WRITE_PFK4902 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z4902)
 
    SQL = " INSERT INTO PFK4902 "
    SQL = SQL & " ( "
    SQL = SQL & " K4902_ShippingWorkOrder," 
    SQL = SQL & " K4902_ShippingWorkOrderSeq," 
    SQL = SQL & " K4902_JobCard," 
    SQL = SQL & " K4902_CustomerCode," 
    SQL = SQL & " K4902_OrderNo," 
    SQL = SQL & " K4902_OrderNoSeq," 
    SQL = SQL & " K4902_PKO," 
    SQL = SQL & " K4902_Destination," 
    SQL = SQL & " K4902_Note1," 
    SQL = SQL & " K4902_Note2," 
    SQL = SQL & " K4902_Note3," 
    SQL = SQL & " K4902_Note4," 
    SQL = SQL & " K4902_Note5," 
    SQL = SQL & " K4902_ShippingWorkOrderStatus," 
    SQL = SQL & " K4902_DateApproval," 
    SQL = SQL & " K4902_DateCancel," 
    SQL = SQL & " K4902_DateComplete," 
    SQL = SQL & " K4902_DatePending," 
    SQL = SQL & " K4902_DateExchangePrice," 
    SQL = SQL & " K4902_PriceOrder," 
    SQL = SQL & " K4902_seUnitPrice," 
    SQL = SQL & " K4902_cdUnitPrice," 
    SQL = SQL & " K4902_DateExchange," 
    SQL = SQL & " K4902_PriceExchange," 
    SQL = SQL & " K4902_PriceOrderEX," 
    SQL = SQL & " K4902_PriceOrderVND," 
    SQL = SQL & " K4902_Datedelivery," 
    SQL = SQL & " K4902_DateTransfer," 
    SQL = SQL & " K4902_AcceptedOrder," 
    SQL = SQL & " K4902_MaterialStatus," 
    SQL = SQL & " K4902_DateShipping," 
    SQL = SQL & " K4902_seUnitMaterial," 
    SQL = SQL & " K4902_cdUnitMaterial," 
    SQL = SQL & " K4902_seUnitPacking," 
    SQL = SQL & " K4902_cdUnitPacking," 
    SQL = SQL & " K4902_QtyOrder," 
    SQL = SQL & " K4902_QtyShipping," 
    SQL = SQL & " K4902_QtyInbound," 
    SQL = SQL & " K4902_QtyOutbound," 
    SQL = SQL & " K4902_DateInsert," 
    SQL = SQL & " K4902_InchargeInsert," 
    SQL = SQL & " K4902_DateUpdate," 
    SQL = SQL & " K4902_InchargeUpdate," 
    SQL = SQL & " K4902_InchargeShipping," 
    SQL = SQL & " K4902_TotalQty," 
    SQL = SQL & " K4902_TotalAMT," 
    SQL = SQL & " K4902_TotalCost," 
    SQL = SQL & " K4902_TotalProfit," 
    SQL = SQL & " K4902_TotalAMTEX," 
    SQL = SQL & " K4902_TotalCostEX," 
    SQL = SQL & " K4902_TotalProfitEX," 
    SQL = SQL & " K4902_TotalAMTVND," 
    SQL = SQL & " K4902_TotalCostVND," 
    SQL = SQL & " K4902_TotalProfitVND," 
    SQL = SQL & " K4902_AttachID," 
    SQL = SQL & " K4902_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z4902.ShippingWorkOrder) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4902.ShippingWorkOrderSeq) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4902.JobCard) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4902.CustomerCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4902.OrderNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4902.OrderNoSeq) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4902.PKO) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4902.Destination) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4902.Note1) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4902.Note2) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4902.Note3) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4902.Note4) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4902.Note5) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4902.ShippingWorkOrderStatus) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4902.DateApproval) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4902.DateCancel) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4902.DateComplete) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4902.DatePending) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4902.DateExchangePrice) & "', "  
    SQL = SQL & "   " & FormatSQL(z4902.PriceOrder) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z4902.seUnitPrice) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4902.cdUnitPrice) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4902.DateExchange) & "', "  
    SQL = SQL & "   " & FormatSQL(z4902.PriceExchange) & ", "  
    SQL = SQL & "   " & FormatSQL(z4902.PriceOrderEX) & ", "  
    SQL = SQL & "   " & FormatSQL(z4902.PriceOrderVND) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z4902.Datedelivery) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4902.DateTransfer) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4902.AcceptedOrder) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4902.MaterialStatus) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4902.DateShipping) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4902.seUnitMaterial) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4902.cdUnitMaterial) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4902.seUnitPacking) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4902.cdUnitPacking) & "', "  
    SQL = SQL & "   " & FormatSQL(z4902.QtyOrder) & ", "  
    SQL = SQL & "   " & FormatSQL(z4902.QtyShipping) & ", "  
    SQL = SQL & "   " & FormatSQL(z4902.QtyInbound) & ", "  
    SQL = SQL & "   " & FormatSQL(z4902.QtyOutbound) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z4902.DateInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4902.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4902.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4902.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4902.InchargeShipping) & "', "  
    SQL = SQL & "   " & FormatSQL(z4902.TotalQty) & ", "  
    SQL = SQL & "   " & FormatSQL(z4902.TotalAMT) & ", "  
    SQL = SQL & "   " & FormatSQL(z4902.TotalCost) & ", "  
    SQL = SQL & "   " & FormatSQL(z4902.TotalProfit) & ", "  
    SQL = SQL & "   " & FormatSQL(z4902.TotalAMTEX) & ", "  
    SQL = SQL & "   " & FormatSQL(z4902.TotalCostEX) & ", "  
    SQL = SQL & "   " & FormatSQL(z4902.TotalProfitEX) & ", "  
    SQL = SQL & "   " & FormatSQL(z4902.TotalAMTVND) & ", "  
    SQL = SQL & "   " & FormatSQL(z4902.TotalCostVND) & ", "  
    SQL = SQL & "   " & FormatSQL(z4902.TotalProfitVND) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z4902.AttachID) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4902.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK4902 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK4902",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK4902(z4902 As T4902_AREA) As Boolean
    REWRITE_PFK4902 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z4902)
   
    SQL = " UPDATE PFK4902 SET "
    SQL = SQL & "    K4902_JobCard      = N'" & FormatSQL(z4902.JobCard) & "', " 
    SQL = SQL & "    K4902_CustomerCode      = N'" & FormatSQL(z4902.CustomerCode) & "', " 
    SQL = SQL & "    K4902_OrderNo      = N'" & FormatSQL(z4902.OrderNo) & "', " 
    SQL = SQL & "    K4902_OrderNoSeq      = N'" & FormatSQL(z4902.OrderNoSeq) & "', " 
    SQL = SQL & "    K4902_PKO      = N'" & FormatSQL(z4902.PKO) & "', " 
    SQL = SQL & "    K4902_Destination      = N'" & FormatSQL(z4902.Destination) & "', " 
    SQL = SQL & "    K4902_Note1      = N'" & FormatSQL(z4902.Note1) & "', " 
    SQL = SQL & "    K4902_Note2      = N'" & FormatSQL(z4902.Note2) & "', " 
    SQL = SQL & "    K4902_Note3      = N'" & FormatSQL(z4902.Note3) & "', " 
    SQL = SQL & "    K4902_Note4      = N'" & FormatSQL(z4902.Note4) & "', " 
    SQL = SQL & "    K4902_Note5      = N'" & FormatSQL(z4902.Note5) & "', " 
    SQL = SQL & "    K4902_ShippingWorkOrderStatus      = N'" & FormatSQL(z4902.ShippingWorkOrderStatus) & "', " 
    SQL = SQL & "    K4902_DateApproval      = N'" & FormatSQL(z4902.DateApproval) & "', " 
    SQL = SQL & "    K4902_DateCancel      = N'" & FormatSQL(z4902.DateCancel) & "', " 
    SQL = SQL & "    K4902_DateComplete      = N'" & FormatSQL(z4902.DateComplete) & "', " 
    SQL = SQL & "    K4902_DatePending      = N'" & FormatSQL(z4902.DatePending) & "', " 
    SQL = SQL & "    K4902_DateExchangePrice      = N'" & FormatSQL(z4902.DateExchangePrice) & "', " 
    SQL = SQL & "    K4902_PriceOrder      =  " & FormatSQL(z4902.PriceOrder) & ", " 
    SQL = SQL & "    K4902_seUnitPrice      = N'" & FormatSQL(z4902.seUnitPrice) & "', " 
    SQL = SQL & "    K4902_cdUnitPrice      = N'" & FormatSQL(z4902.cdUnitPrice) & "', " 
    SQL = SQL & "    K4902_DateExchange      = N'" & FormatSQL(z4902.DateExchange) & "', " 
    SQL = SQL & "    K4902_PriceExchange      =  " & FormatSQL(z4902.PriceExchange) & ", " 
    SQL = SQL & "    K4902_PriceOrderEX      =  " & FormatSQL(z4902.PriceOrderEX) & ", " 
    SQL = SQL & "    K4902_PriceOrderVND      =  " & FormatSQL(z4902.PriceOrderVND) & ", " 
    SQL = SQL & "    K4902_Datedelivery      = N'" & FormatSQL(z4902.Datedelivery) & "', " 
    SQL = SQL & "    K4902_DateTransfer      = N'" & FormatSQL(z4902.DateTransfer) & "', " 
    SQL = SQL & "    K4902_AcceptedOrder      = N'" & FormatSQL(z4902.AcceptedOrder) & "', " 
    SQL = SQL & "    K4902_MaterialStatus      = N'" & FormatSQL(z4902.MaterialStatus) & "', " 
    SQL = SQL & "    K4902_DateShipping      = N'" & FormatSQL(z4902.DateShipping) & "', " 
    SQL = SQL & "    K4902_seUnitMaterial      = N'" & FormatSQL(z4902.seUnitMaterial) & "', " 
    SQL = SQL & "    K4902_cdUnitMaterial      = N'" & FormatSQL(z4902.cdUnitMaterial) & "', " 
    SQL = SQL & "    K4902_seUnitPacking      = N'" & FormatSQL(z4902.seUnitPacking) & "', " 
    SQL = SQL & "    K4902_cdUnitPacking      = N'" & FormatSQL(z4902.cdUnitPacking) & "', " 
    SQL = SQL & "    K4902_QtyOrder      =  " & FormatSQL(z4902.QtyOrder) & ", " 
    SQL = SQL & "    K4902_QtyShipping      =  " & FormatSQL(z4902.QtyShipping) & ", " 
    SQL = SQL & "    K4902_QtyInbound      =  " & FormatSQL(z4902.QtyInbound) & ", " 
    SQL = SQL & "    K4902_QtyOutbound      =  " & FormatSQL(z4902.QtyOutbound) & ", " 
    SQL = SQL & "    K4902_DateInsert      = N'" & FormatSQL(z4902.DateInsert) & "', " 
    SQL = SQL & "    K4902_InchargeInsert      = N'" & FormatSQL(z4902.InchargeInsert) & "', " 
    SQL = SQL & "    K4902_DateUpdate      = N'" & FormatSQL(z4902.DateUpdate) & "', " 
    SQL = SQL & "    K4902_InchargeUpdate      = N'" & FormatSQL(z4902.InchargeUpdate) & "', " 
    SQL = SQL & "    K4902_InchargeShipping      = N'" & FormatSQL(z4902.InchargeShipping) & "', " 
    SQL = SQL & "    K4902_TotalQty      =  " & FormatSQL(z4902.TotalQty) & ", " 
    SQL = SQL & "    K4902_TotalAMT      =  " & FormatSQL(z4902.TotalAMT) & ", " 
    SQL = SQL & "    K4902_TotalCost      =  " & FormatSQL(z4902.TotalCost) & ", " 
    SQL = SQL & "    K4902_TotalProfit      =  " & FormatSQL(z4902.TotalProfit) & ", " 
    SQL = SQL & "    K4902_TotalAMTEX      =  " & FormatSQL(z4902.TotalAMTEX) & ", " 
    SQL = SQL & "    K4902_TotalCostEX      =  " & FormatSQL(z4902.TotalCostEX) & ", " 
    SQL = SQL & "    K4902_TotalProfitEX      =  " & FormatSQL(z4902.TotalProfitEX) & ", " 
    SQL = SQL & "    K4902_TotalAMTVND      =  " & FormatSQL(z4902.TotalAMTVND) & ", " 
    SQL = SQL & "    K4902_TotalCostVND      =  " & FormatSQL(z4902.TotalCostVND) & ", " 
    SQL = SQL & "    K4902_TotalProfitVND      =  " & FormatSQL(z4902.TotalProfitVND) & ", " 
    SQL = SQL & "    K4902_AttachID      = N'" & FormatSQL(z4902.AttachID) & "', " 
    SQL = SQL & "    K4902_Remark      = N'" & FormatSQL(z4902.Remark) & "'  " 
    SQL = SQL & " WHERE K4902_ShippingWorkOrder		 = '" & z4902.ShippingWorkOrder & "' " 
    SQL = SQL & "   AND K4902_ShippingWorkOrderSeq		 = '" & z4902.ShippingWorkOrderSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK4902 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK4902",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK4902(z4902 As T4902_AREA) As Boolean
    DELETE_PFK4902 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK4902 "
    SQL = SQL & " WHERE K4902_ShippingWorkOrder		 = '" & z4902.ShippingWorkOrder & "' " 
    SQL = SQL & "   AND K4902_ShippingWorkOrderSeq		 = '" & z4902.ShippingWorkOrderSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK4902 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK4902",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D4902_CLEAR()
Try
    
   D4902.ShippingWorkOrder = ""
   D4902.ShippingWorkOrderSeq = ""
   D4902.JobCard = ""
   D4902.CustomerCode = ""
   D4902.OrderNo = ""
   D4902.OrderNoSeq = ""
   D4902.PKO = ""
   D4902.Destination = ""
   D4902.Note1 = ""
   D4902.Note2 = ""
   D4902.Note3 = ""
   D4902.Note4 = ""
   D4902.Note5 = ""
   D4902.ShippingWorkOrderStatus = ""
   D4902.DateApproval = ""
   D4902.DateCancel = ""
   D4902.DateComplete = ""
   D4902.DatePending = ""
   D4902.DateExchangePrice = ""
    D4902.PriceOrder = 0 
   D4902.seUnitPrice = ""
   D4902.cdUnitPrice = ""
   D4902.DateExchange = ""
    D4902.PriceExchange = 0 
    D4902.PriceOrderEX = 0 
    D4902.PriceOrderVND = 0 
   D4902.Datedelivery = ""
   D4902.DateTransfer = ""
   D4902.AcceptedOrder = ""
   D4902.MaterialStatus = ""
   D4902.DateShipping = ""
   D4902.seUnitMaterial = ""
   D4902.cdUnitMaterial = ""
   D4902.seUnitPacking = ""
   D4902.cdUnitPacking = ""
    D4902.QtyOrder = 0 
    D4902.QtyShipping = 0 
    D4902.QtyInbound = 0 
    D4902.QtyOutbound = 0 
   D4902.DateInsert = ""
   D4902.InchargeInsert = ""
   D4902.DateUpdate = ""
   D4902.InchargeUpdate = ""
   D4902.InchargeShipping = ""
    D4902.TotalQty = 0 
    D4902.TotalAMT = 0 
    D4902.TotalCost = 0 
    D4902.TotalProfit = 0 
    D4902.TotalAMTEX = 0 
    D4902.TotalCostEX = 0 
    D4902.TotalProfitEX = 0 
    D4902.TotalAMTVND = 0 
    D4902.TotalCostVND = 0 
    D4902.TotalProfitVND = 0 
   D4902.AttachID = ""
   D4902.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D4902_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x4902 As T4902_AREA)
Try
    
    x4902.ShippingWorkOrder = trim$(  x4902.ShippingWorkOrder)
    x4902.ShippingWorkOrderSeq = trim$(  x4902.ShippingWorkOrderSeq)
    x4902.JobCard = trim$(  x4902.JobCard)
    x4902.CustomerCode = trim$(  x4902.CustomerCode)
    x4902.OrderNo = trim$(  x4902.OrderNo)
    x4902.OrderNoSeq = trim$(  x4902.OrderNoSeq)
    x4902.PKO = trim$(  x4902.PKO)
    x4902.Destination = trim$(  x4902.Destination)
    x4902.Note1 = trim$(  x4902.Note1)
    x4902.Note2 = trim$(  x4902.Note2)
    x4902.Note3 = trim$(  x4902.Note3)
    x4902.Note4 = trim$(  x4902.Note4)
    x4902.Note5 = trim$(  x4902.Note5)
    x4902.ShippingWorkOrderStatus = trim$(  x4902.ShippingWorkOrderStatus)
    x4902.DateApproval = trim$(  x4902.DateApproval)
    x4902.DateCancel = trim$(  x4902.DateCancel)
    x4902.DateComplete = trim$(  x4902.DateComplete)
    x4902.DatePending = trim$(  x4902.DatePending)
    x4902.DateExchangePrice = trim$(  x4902.DateExchangePrice)
    x4902.PriceOrder = trim$(  x4902.PriceOrder)
    x4902.seUnitPrice = trim$(  x4902.seUnitPrice)
    x4902.cdUnitPrice = trim$(  x4902.cdUnitPrice)
    x4902.DateExchange = trim$(  x4902.DateExchange)
    x4902.PriceExchange = trim$(  x4902.PriceExchange)
    x4902.PriceOrderEX = trim$(  x4902.PriceOrderEX)
    x4902.PriceOrderVND = trim$(  x4902.PriceOrderVND)
    x4902.Datedelivery = trim$(  x4902.Datedelivery)
    x4902.DateTransfer = trim$(  x4902.DateTransfer)
    x4902.AcceptedOrder = trim$(  x4902.AcceptedOrder)
    x4902.MaterialStatus = trim$(  x4902.MaterialStatus)
    x4902.DateShipping = trim$(  x4902.DateShipping)
    x4902.seUnitMaterial = trim$(  x4902.seUnitMaterial)
    x4902.cdUnitMaterial = trim$(  x4902.cdUnitMaterial)
    x4902.seUnitPacking = trim$(  x4902.seUnitPacking)
    x4902.cdUnitPacking = trim$(  x4902.cdUnitPacking)
    x4902.QtyOrder = trim$(  x4902.QtyOrder)
    x4902.QtyShipping = trim$(  x4902.QtyShipping)
    x4902.QtyInbound = trim$(  x4902.QtyInbound)
    x4902.QtyOutbound = trim$(  x4902.QtyOutbound)
    x4902.DateInsert = trim$(  x4902.DateInsert)
    x4902.InchargeInsert = trim$(  x4902.InchargeInsert)
    x4902.DateUpdate = trim$(  x4902.DateUpdate)
    x4902.InchargeUpdate = trim$(  x4902.InchargeUpdate)
    x4902.InchargeShipping = trim$(  x4902.InchargeShipping)
    x4902.TotalQty = trim$(  x4902.TotalQty)
    x4902.TotalAMT = trim$(  x4902.TotalAMT)
    x4902.TotalCost = trim$(  x4902.TotalCost)
    x4902.TotalProfit = trim$(  x4902.TotalProfit)
    x4902.TotalAMTEX = trim$(  x4902.TotalAMTEX)
    x4902.TotalCostEX = trim$(  x4902.TotalCostEX)
    x4902.TotalProfitEX = trim$(  x4902.TotalProfitEX)
    x4902.TotalAMTVND = trim$(  x4902.TotalAMTVND)
    x4902.TotalCostVND = trim$(  x4902.TotalCostVND)
    x4902.TotalProfitVND = trim$(  x4902.TotalProfitVND)
    x4902.AttachID = trim$(  x4902.AttachID)
    x4902.Remark = trim$(  x4902.Remark)
     
    If trim$( x4902.ShippingWorkOrder ) = "" Then x4902.ShippingWorkOrder = Space(1) 
    If trim$( x4902.ShippingWorkOrderSeq ) = "" Then x4902.ShippingWorkOrderSeq = Space(1) 
    If trim$( x4902.JobCard ) = "" Then x4902.JobCard = Space(1) 
    If trim$( x4902.CustomerCode ) = "" Then x4902.CustomerCode = Space(1) 
    If trim$( x4902.OrderNo ) = "" Then x4902.OrderNo = Space(1) 
    If trim$( x4902.OrderNoSeq ) = "" Then x4902.OrderNoSeq = Space(1) 
    If trim$( x4902.PKO ) = "" Then x4902.PKO = Space(1) 
    If trim$( x4902.Destination ) = "" Then x4902.Destination = Space(1) 
    If trim$( x4902.Note1 ) = "" Then x4902.Note1 = Space(1) 
    If trim$( x4902.Note2 ) = "" Then x4902.Note2 = Space(1) 
    If trim$( x4902.Note3 ) = "" Then x4902.Note3 = Space(1) 
    If trim$( x4902.Note4 ) = "" Then x4902.Note4 = Space(1) 
    If trim$( x4902.Note5 ) = "" Then x4902.Note5 = Space(1) 
    If trim$( x4902.ShippingWorkOrderStatus ) = "" Then x4902.ShippingWorkOrderStatus = Space(1) 
    If trim$( x4902.DateApproval ) = "" Then x4902.DateApproval = Space(1) 
    If trim$( x4902.DateCancel ) = "" Then x4902.DateCancel = Space(1) 
    If trim$( x4902.DateComplete ) = "" Then x4902.DateComplete = Space(1) 
    If trim$( x4902.DatePending ) = "" Then x4902.DatePending = Space(1) 
    If trim$( x4902.DateExchangePrice ) = "" Then x4902.DateExchangePrice = Space(1) 
    If trim$( x4902.PriceOrder ) = "" Then x4902.PriceOrder = 0 
    If trim$( x4902.seUnitPrice ) = "" Then x4902.seUnitPrice = Space(1) 
    If trim$( x4902.cdUnitPrice ) = "" Then x4902.cdUnitPrice = Space(1) 
    If trim$( x4902.DateExchange ) = "" Then x4902.DateExchange = Space(1) 
    If trim$( x4902.PriceExchange ) = "" Then x4902.PriceExchange = 0 
    If trim$( x4902.PriceOrderEX ) = "" Then x4902.PriceOrderEX = 0 
    If trim$( x4902.PriceOrderVND ) = "" Then x4902.PriceOrderVND = 0 
    If trim$( x4902.Datedelivery ) = "" Then x4902.Datedelivery = Space(1) 
    If trim$( x4902.DateTransfer ) = "" Then x4902.DateTransfer = Space(1) 
    If trim$( x4902.AcceptedOrder ) = "" Then x4902.AcceptedOrder = Space(1) 
    If trim$( x4902.MaterialStatus ) = "" Then x4902.MaterialStatus = Space(1) 
    If trim$( x4902.DateShipping ) = "" Then x4902.DateShipping = Space(1) 
    If trim$( x4902.seUnitMaterial ) = "" Then x4902.seUnitMaterial = Space(1) 
    If trim$( x4902.cdUnitMaterial ) = "" Then x4902.cdUnitMaterial = Space(1) 
    If trim$( x4902.seUnitPacking ) = "" Then x4902.seUnitPacking = Space(1) 
    If trim$( x4902.cdUnitPacking ) = "" Then x4902.cdUnitPacking = Space(1) 
    If trim$( x4902.QtyOrder ) = "" Then x4902.QtyOrder = 0 
    If trim$( x4902.QtyShipping ) = "" Then x4902.QtyShipping = 0 
    If trim$( x4902.QtyInbound ) = "" Then x4902.QtyInbound = 0 
    If trim$( x4902.QtyOutbound ) = "" Then x4902.QtyOutbound = 0 
    If trim$( x4902.DateInsert ) = "" Then x4902.DateInsert = Space(1) 
    If trim$( x4902.InchargeInsert ) = "" Then x4902.InchargeInsert = Space(1) 
    If trim$( x4902.DateUpdate ) = "" Then x4902.DateUpdate = Space(1) 
    If trim$( x4902.InchargeUpdate ) = "" Then x4902.InchargeUpdate = Space(1) 
    If trim$( x4902.InchargeShipping ) = "" Then x4902.InchargeShipping = Space(1) 
    If trim$( x4902.TotalQty ) = "" Then x4902.TotalQty = 0 
    If trim$( x4902.TotalAMT ) = "" Then x4902.TotalAMT = 0 
    If trim$( x4902.TotalCost ) = "" Then x4902.TotalCost = 0 
    If trim$( x4902.TotalProfit ) = "" Then x4902.TotalProfit = 0 
    If trim$( x4902.TotalAMTEX ) = "" Then x4902.TotalAMTEX = 0 
    If trim$( x4902.TotalCostEX ) = "" Then x4902.TotalCostEX = 0 
    If trim$( x4902.TotalProfitEX ) = "" Then x4902.TotalProfitEX = 0 
    If trim$( x4902.TotalAMTVND ) = "" Then x4902.TotalAMTVND = 0 
    If trim$( x4902.TotalCostVND ) = "" Then x4902.TotalCostVND = 0 
    If trim$( x4902.TotalProfitVND ) = "" Then x4902.TotalProfitVND = 0 
    If trim$( x4902.AttachID ) = "" Then x4902.AttachID = Space(1) 
    If trim$( x4902.Remark ) = "" Then x4902.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K4902_MOVE(rs4902 As SqlClient.SqlDataReader)
Try

    call D4902_CLEAR()   

    If IsdbNull(rs4902!K4902_ShippingWorkOrder) = False Then D4902.ShippingWorkOrder = Trim$(rs4902!K4902_ShippingWorkOrder)
    If IsdbNull(rs4902!K4902_ShippingWorkOrderSeq) = False Then D4902.ShippingWorkOrderSeq = Trim$(rs4902!K4902_ShippingWorkOrderSeq)
    If IsdbNull(rs4902!K4902_JobCard) = False Then D4902.JobCard = Trim$(rs4902!K4902_JobCard)
    If IsdbNull(rs4902!K4902_CustomerCode) = False Then D4902.CustomerCode = Trim$(rs4902!K4902_CustomerCode)
    If IsdbNull(rs4902!K4902_OrderNo) = False Then D4902.OrderNo = Trim$(rs4902!K4902_OrderNo)
    If IsdbNull(rs4902!K4902_OrderNoSeq) = False Then D4902.OrderNoSeq = Trim$(rs4902!K4902_OrderNoSeq)
    If IsdbNull(rs4902!K4902_PKO) = False Then D4902.PKO = Trim$(rs4902!K4902_PKO)
    If IsdbNull(rs4902!K4902_Destination) = False Then D4902.Destination = Trim$(rs4902!K4902_Destination)
    If IsdbNull(rs4902!K4902_Note1) = False Then D4902.Note1 = Trim$(rs4902!K4902_Note1)
    If IsdbNull(rs4902!K4902_Note2) = False Then D4902.Note2 = Trim$(rs4902!K4902_Note2)
    If IsdbNull(rs4902!K4902_Note3) = False Then D4902.Note3 = Trim$(rs4902!K4902_Note3)
    If IsdbNull(rs4902!K4902_Note4) = False Then D4902.Note4 = Trim$(rs4902!K4902_Note4)
    If IsdbNull(rs4902!K4902_Note5) = False Then D4902.Note5 = Trim$(rs4902!K4902_Note5)
    If IsdbNull(rs4902!K4902_ShippingWorkOrderStatus) = False Then D4902.ShippingWorkOrderStatus = Trim$(rs4902!K4902_ShippingWorkOrderStatus)
    If IsdbNull(rs4902!K4902_DateApproval) = False Then D4902.DateApproval = Trim$(rs4902!K4902_DateApproval)
    If IsdbNull(rs4902!K4902_DateCancel) = False Then D4902.DateCancel = Trim$(rs4902!K4902_DateCancel)
    If IsdbNull(rs4902!K4902_DateComplete) = False Then D4902.DateComplete = Trim$(rs4902!K4902_DateComplete)
    If IsdbNull(rs4902!K4902_DatePending) = False Then D4902.DatePending = Trim$(rs4902!K4902_DatePending)
    If IsdbNull(rs4902!K4902_DateExchangePrice) = False Then D4902.DateExchangePrice = Trim$(rs4902!K4902_DateExchangePrice)
    If IsdbNull(rs4902!K4902_PriceOrder) = False Then D4902.PriceOrder = Trim$(rs4902!K4902_PriceOrder)
    If IsdbNull(rs4902!K4902_seUnitPrice) = False Then D4902.seUnitPrice = Trim$(rs4902!K4902_seUnitPrice)
    If IsdbNull(rs4902!K4902_cdUnitPrice) = False Then D4902.cdUnitPrice = Trim$(rs4902!K4902_cdUnitPrice)
    If IsdbNull(rs4902!K4902_DateExchange) = False Then D4902.DateExchange = Trim$(rs4902!K4902_DateExchange)
    If IsdbNull(rs4902!K4902_PriceExchange) = False Then D4902.PriceExchange = Trim$(rs4902!K4902_PriceExchange)
    If IsdbNull(rs4902!K4902_PriceOrderEX) = False Then D4902.PriceOrderEX = Trim$(rs4902!K4902_PriceOrderEX)
    If IsdbNull(rs4902!K4902_PriceOrderVND) = False Then D4902.PriceOrderVND = Trim$(rs4902!K4902_PriceOrderVND)
    If IsdbNull(rs4902!K4902_Datedelivery) = False Then D4902.Datedelivery = Trim$(rs4902!K4902_Datedelivery)
    If IsdbNull(rs4902!K4902_DateTransfer) = False Then D4902.DateTransfer = Trim$(rs4902!K4902_DateTransfer)
    If IsdbNull(rs4902!K4902_AcceptedOrder) = False Then D4902.AcceptedOrder = Trim$(rs4902!K4902_AcceptedOrder)
    If IsdbNull(rs4902!K4902_MaterialStatus) = False Then D4902.MaterialStatus = Trim$(rs4902!K4902_MaterialStatus)
    If IsdbNull(rs4902!K4902_DateShipping) = False Then D4902.DateShipping = Trim$(rs4902!K4902_DateShipping)
    If IsdbNull(rs4902!K4902_seUnitMaterial) = False Then D4902.seUnitMaterial = Trim$(rs4902!K4902_seUnitMaterial)
    If IsdbNull(rs4902!K4902_cdUnitMaterial) = False Then D4902.cdUnitMaterial = Trim$(rs4902!K4902_cdUnitMaterial)
    If IsdbNull(rs4902!K4902_seUnitPacking) = False Then D4902.seUnitPacking = Trim$(rs4902!K4902_seUnitPacking)
    If IsdbNull(rs4902!K4902_cdUnitPacking) = False Then D4902.cdUnitPacking = Trim$(rs4902!K4902_cdUnitPacking)
    If IsdbNull(rs4902!K4902_QtyOrder) = False Then D4902.QtyOrder = Trim$(rs4902!K4902_QtyOrder)
    If IsdbNull(rs4902!K4902_QtyShipping) = False Then D4902.QtyShipping = Trim$(rs4902!K4902_QtyShipping)
    If IsdbNull(rs4902!K4902_QtyInbound) = False Then D4902.QtyInbound = Trim$(rs4902!K4902_QtyInbound)
    If IsdbNull(rs4902!K4902_QtyOutbound) = False Then D4902.QtyOutbound = Trim$(rs4902!K4902_QtyOutbound)
    If IsdbNull(rs4902!K4902_DateInsert) = False Then D4902.DateInsert = Trim$(rs4902!K4902_DateInsert)
    If IsdbNull(rs4902!K4902_InchargeInsert) = False Then D4902.InchargeInsert = Trim$(rs4902!K4902_InchargeInsert)
    If IsdbNull(rs4902!K4902_DateUpdate) = False Then D4902.DateUpdate = Trim$(rs4902!K4902_DateUpdate)
    If IsdbNull(rs4902!K4902_InchargeUpdate) = False Then D4902.InchargeUpdate = Trim$(rs4902!K4902_InchargeUpdate)
    If IsdbNull(rs4902!K4902_InchargeShipping) = False Then D4902.InchargeShipping = Trim$(rs4902!K4902_InchargeShipping)
    If IsdbNull(rs4902!K4902_TotalQty) = False Then D4902.TotalQty = Trim$(rs4902!K4902_TotalQty)
    If IsdbNull(rs4902!K4902_TotalAMT) = False Then D4902.TotalAMT = Trim$(rs4902!K4902_TotalAMT)
    If IsdbNull(rs4902!K4902_TotalCost) = False Then D4902.TotalCost = Trim$(rs4902!K4902_TotalCost)
    If IsdbNull(rs4902!K4902_TotalProfit) = False Then D4902.TotalProfit = Trim$(rs4902!K4902_TotalProfit)
    If IsdbNull(rs4902!K4902_TotalAMTEX) = False Then D4902.TotalAMTEX = Trim$(rs4902!K4902_TotalAMTEX)
    If IsdbNull(rs4902!K4902_TotalCostEX) = False Then D4902.TotalCostEX = Trim$(rs4902!K4902_TotalCostEX)
    If IsdbNull(rs4902!K4902_TotalProfitEX) = False Then D4902.TotalProfitEX = Trim$(rs4902!K4902_TotalProfitEX)
    If IsdbNull(rs4902!K4902_TotalAMTVND) = False Then D4902.TotalAMTVND = Trim$(rs4902!K4902_TotalAMTVND)
    If IsdbNull(rs4902!K4902_TotalCostVND) = False Then D4902.TotalCostVND = Trim$(rs4902!K4902_TotalCostVND)
    If IsdbNull(rs4902!K4902_TotalProfitVND) = False Then D4902.TotalProfitVND = Trim$(rs4902!K4902_TotalProfitVND)
    If IsdbNull(rs4902!K4902_AttachID) = False Then D4902.AttachID = Trim$(rs4902!K4902_AttachID)
    If IsdbNull(rs4902!K4902_Remark) = False Then D4902.Remark = Trim$(rs4902!K4902_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K4902_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K4902_MOVE(rs4902 As DataRow)
Try

    call D4902_CLEAR()   

    If IsdbNull(rs4902!K4902_ShippingWorkOrder) = False Then D4902.ShippingWorkOrder = Trim$(rs4902!K4902_ShippingWorkOrder)
    If IsdbNull(rs4902!K4902_ShippingWorkOrderSeq) = False Then D4902.ShippingWorkOrderSeq = Trim$(rs4902!K4902_ShippingWorkOrderSeq)
    If IsdbNull(rs4902!K4902_JobCard) = False Then D4902.JobCard = Trim$(rs4902!K4902_JobCard)
    If IsdbNull(rs4902!K4902_CustomerCode) = False Then D4902.CustomerCode = Trim$(rs4902!K4902_CustomerCode)
    If IsdbNull(rs4902!K4902_OrderNo) = False Then D4902.OrderNo = Trim$(rs4902!K4902_OrderNo)
    If IsdbNull(rs4902!K4902_OrderNoSeq) = False Then D4902.OrderNoSeq = Trim$(rs4902!K4902_OrderNoSeq)
    If IsdbNull(rs4902!K4902_PKO) = False Then D4902.PKO = Trim$(rs4902!K4902_PKO)
    If IsdbNull(rs4902!K4902_Destination) = False Then D4902.Destination = Trim$(rs4902!K4902_Destination)
    If IsdbNull(rs4902!K4902_Note1) = False Then D4902.Note1 = Trim$(rs4902!K4902_Note1)
    If IsdbNull(rs4902!K4902_Note2) = False Then D4902.Note2 = Trim$(rs4902!K4902_Note2)
    If IsdbNull(rs4902!K4902_Note3) = False Then D4902.Note3 = Trim$(rs4902!K4902_Note3)
    If IsdbNull(rs4902!K4902_Note4) = False Then D4902.Note4 = Trim$(rs4902!K4902_Note4)
    If IsdbNull(rs4902!K4902_Note5) = False Then D4902.Note5 = Trim$(rs4902!K4902_Note5)
    If IsdbNull(rs4902!K4902_ShippingWorkOrderStatus) = False Then D4902.ShippingWorkOrderStatus = Trim$(rs4902!K4902_ShippingWorkOrderStatus)
    If IsdbNull(rs4902!K4902_DateApproval) = False Then D4902.DateApproval = Trim$(rs4902!K4902_DateApproval)
    If IsdbNull(rs4902!K4902_DateCancel) = False Then D4902.DateCancel = Trim$(rs4902!K4902_DateCancel)
    If IsdbNull(rs4902!K4902_DateComplete) = False Then D4902.DateComplete = Trim$(rs4902!K4902_DateComplete)
    If IsdbNull(rs4902!K4902_DatePending) = False Then D4902.DatePending = Trim$(rs4902!K4902_DatePending)
    If IsdbNull(rs4902!K4902_DateExchangePrice) = False Then D4902.DateExchangePrice = Trim$(rs4902!K4902_DateExchangePrice)
    If IsdbNull(rs4902!K4902_PriceOrder) = False Then D4902.PriceOrder = Trim$(rs4902!K4902_PriceOrder)
    If IsdbNull(rs4902!K4902_seUnitPrice) = False Then D4902.seUnitPrice = Trim$(rs4902!K4902_seUnitPrice)
    If IsdbNull(rs4902!K4902_cdUnitPrice) = False Then D4902.cdUnitPrice = Trim$(rs4902!K4902_cdUnitPrice)
    If IsdbNull(rs4902!K4902_DateExchange) = False Then D4902.DateExchange = Trim$(rs4902!K4902_DateExchange)
    If IsdbNull(rs4902!K4902_PriceExchange) = False Then D4902.PriceExchange = Trim$(rs4902!K4902_PriceExchange)
    If IsdbNull(rs4902!K4902_PriceOrderEX) = False Then D4902.PriceOrderEX = Trim$(rs4902!K4902_PriceOrderEX)
    If IsdbNull(rs4902!K4902_PriceOrderVND) = False Then D4902.PriceOrderVND = Trim$(rs4902!K4902_PriceOrderVND)
    If IsdbNull(rs4902!K4902_Datedelivery) = False Then D4902.Datedelivery = Trim$(rs4902!K4902_Datedelivery)
    If IsdbNull(rs4902!K4902_DateTransfer) = False Then D4902.DateTransfer = Trim$(rs4902!K4902_DateTransfer)
    If IsdbNull(rs4902!K4902_AcceptedOrder) = False Then D4902.AcceptedOrder = Trim$(rs4902!K4902_AcceptedOrder)
    If IsdbNull(rs4902!K4902_MaterialStatus) = False Then D4902.MaterialStatus = Trim$(rs4902!K4902_MaterialStatus)
    If IsdbNull(rs4902!K4902_DateShipping) = False Then D4902.DateShipping = Trim$(rs4902!K4902_DateShipping)
    If IsdbNull(rs4902!K4902_seUnitMaterial) = False Then D4902.seUnitMaterial = Trim$(rs4902!K4902_seUnitMaterial)
    If IsdbNull(rs4902!K4902_cdUnitMaterial) = False Then D4902.cdUnitMaterial = Trim$(rs4902!K4902_cdUnitMaterial)
    If IsdbNull(rs4902!K4902_seUnitPacking) = False Then D4902.seUnitPacking = Trim$(rs4902!K4902_seUnitPacking)
    If IsdbNull(rs4902!K4902_cdUnitPacking) = False Then D4902.cdUnitPacking = Trim$(rs4902!K4902_cdUnitPacking)
    If IsdbNull(rs4902!K4902_QtyOrder) = False Then D4902.QtyOrder = Trim$(rs4902!K4902_QtyOrder)
    If IsdbNull(rs4902!K4902_QtyShipping) = False Then D4902.QtyShipping = Trim$(rs4902!K4902_QtyShipping)
    If IsdbNull(rs4902!K4902_QtyInbound) = False Then D4902.QtyInbound = Trim$(rs4902!K4902_QtyInbound)
    If IsdbNull(rs4902!K4902_QtyOutbound) = False Then D4902.QtyOutbound = Trim$(rs4902!K4902_QtyOutbound)
    If IsdbNull(rs4902!K4902_DateInsert) = False Then D4902.DateInsert = Trim$(rs4902!K4902_DateInsert)
    If IsdbNull(rs4902!K4902_InchargeInsert) = False Then D4902.InchargeInsert = Trim$(rs4902!K4902_InchargeInsert)
    If IsdbNull(rs4902!K4902_DateUpdate) = False Then D4902.DateUpdate = Trim$(rs4902!K4902_DateUpdate)
    If IsdbNull(rs4902!K4902_InchargeUpdate) = False Then D4902.InchargeUpdate = Trim$(rs4902!K4902_InchargeUpdate)
    If IsdbNull(rs4902!K4902_InchargeShipping) = False Then D4902.InchargeShipping = Trim$(rs4902!K4902_InchargeShipping)
    If IsdbNull(rs4902!K4902_TotalQty) = False Then D4902.TotalQty = Trim$(rs4902!K4902_TotalQty)
    If IsdbNull(rs4902!K4902_TotalAMT) = False Then D4902.TotalAMT = Trim$(rs4902!K4902_TotalAMT)
    If IsdbNull(rs4902!K4902_TotalCost) = False Then D4902.TotalCost = Trim$(rs4902!K4902_TotalCost)
    If IsdbNull(rs4902!K4902_TotalProfit) = False Then D4902.TotalProfit = Trim$(rs4902!K4902_TotalProfit)
    If IsdbNull(rs4902!K4902_TotalAMTEX) = False Then D4902.TotalAMTEX = Trim$(rs4902!K4902_TotalAMTEX)
    If IsdbNull(rs4902!K4902_TotalCostEX) = False Then D4902.TotalCostEX = Trim$(rs4902!K4902_TotalCostEX)
    If IsdbNull(rs4902!K4902_TotalProfitEX) = False Then D4902.TotalProfitEX = Trim$(rs4902!K4902_TotalProfitEX)
    If IsdbNull(rs4902!K4902_TotalAMTVND) = False Then D4902.TotalAMTVND = Trim$(rs4902!K4902_TotalAMTVND)
    If IsdbNull(rs4902!K4902_TotalCostVND) = False Then D4902.TotalCostVND = Trim$(rs4902!K4902_TotalCostVND)
    If IsdbNull(rs4902!K4902_TotalProfitVND) = False Then D4902.TotalProfitVND = Trim$(rs4902!K4902_TotalProfitVND)
    If IsdbNull(rs4902!K4902_AttachID) = False Then D4902.AttachID = Trim$(rs4902!K4902_AttachID)
    If IsdbNull(rs4902!K4902_Remark) = False Then D4902.Remark = Trim$(rs4902!K4902_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K4902_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K4902_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z4902 As T4902_AREA, SHIPPINGWORKORDER AS String, SHIPPINGWORKORDERSEQ AS String) as Boolean

K4902_MOVE = False

Try
    If READ_PFK4902(SHIPPINGWORKORDER, SHIPPINGWORKORDERSEQ) = True Then
                z4902 = D4902
		K4902_MOVE = True
		else
	z4902 = nothing
     End If

     If  getColumIndex(spr,"ShippingWorkOrder") > -1 then z4902.ShippingWorkOrder = getDataM(spr, getColumIndex(spr,"ShippingWorkOrder"), xRow)
     If  getColumIndex(spr,"ShippingWorkOrderSeq") > -1 then z4902.ShippingWorkOrderSeq = getDataM(spr, getColumIndex(spr,"ShippingWorkOrderSeq"), xRow)
     If  getColumIndex(spr,"JobCard") > -1 then z4902.JobCard = getDataM(spr, getColumIndex(spr,"JobCard"), xRow)
     If  getColumIndex(spr,"CustomerCode") > -1 then z4902.CustomerCode = getDataM(spr, getColumIndex(spr,"CustomerCode"), xRow)
     If  getColumIndex(spr,"OrderNo") > -1 then z4902.OrderNo = getDataM(spr, getColumIndex(spr,"OrderNo"), xRow)
     If  getColumIndex(spr,"OrderNoSeq") > -1 then z4902.OrderNoSeq = getDataM(spr, getColumIndex(spr,"OrderNoSeq"), xRow)
     If  getColumIndex(spr,"PKO") > -1 then z4902.PKO = getDataM(spr, getColumIndex(spr,"PKO"), xRow)
     If  getColumIndex(spr,"Destination") > -1 then z4902.Destination = getDataM(spr, getColumIndex(spr,"Destination"), xRow)
     If  getColumIndex(spr,"Note1") > -1 then z4902.Note1 = getDataM(spr, getColumIndex(spr,"Note1"), xRow)
     If  getColumIndex(spr,"Note2") > -1 then z4902.Note2 = getDataM(spr, getColumIndex(spr,"Note2"), xRow)
     If  getColumIndex(spr,"Note3") > -1 then z4902.Note3 = getDataM(spr, getColumIndex(spr,"Note3"), xRow)
     If  getColumIndex(spr,"Note4") > -1 then z4902.Note4 = getDataM(spr, getColumIndex(spr,"Note4"), xRow)
     If  getColumIndex(spr,"Note5") > -1 then z4902.Note5 = getDataM(spr, getColumIndex(spr,"Note5"), xRow)
     If  getColumIndex(spr,"ShippingWorkOrderStatus") > -1 then z4902.ShippingWorkOrderStatus = getDataM(spr, getColumIndex(spr,"ShippingWorkOrderStatus"), xRow)
     If  getColumIndex(spr,"DateApproval") > -1 then z4902.DateApproval = getDataM(spr, getColumIndex(spr,"DateApproval"), xRow)
     If  getColumIndex(spr,"DateCancel") > -1 then z4902.DateCancel = getDataM(spr, getColumIndex(spr,"DateCancel"), xRow)
     If  getColumIndex(spr,"DateComplete") > -1 then z4902.DateComplete = getDataM(spr, getColumIndex(spr,"DateComplete"), xRow)
     If  getColumIndex(spr,"DatePending") > -1 then z4902.DatePending = getDataM(spr, getColumIndex(spr,"DatePending"), xRow)
     If  getColumIndex(spr,"DateExchangePrice") > -1 then z4902.DateExchangePrice = getDataM(spr, getColumIndex(spr,"DateExchangePrice"), xRow)
     If  getColumIndex(spr,"PriceOrder") > -1 then z4902.PriceOrder = getDataM(spr, getColumIndex(spr,"PriceOrder"), xRow)
     If  getColumIndex(spr,"seUnitPrice") > -1 then z4902.seUnitPrice = getDataM(spr, getColumIndex(spr,"seUnitPrice"), xRow)
     If  getColumIndex(spr,"cdUnitPrice") > -1 then z4902.cdUnitPrice = getDataM(spr, getColumIndex(spr,"cdUnitPrice"), xRow)
     If  getColumIndex(spr,"DateExchange") > -1 then z4902.DateExchange = getDataM(spr, getColumIndex(spr,"DateExchange"), xRow)
     If  getColumIndex(spr,"PriceExchange") > -1 then z4902.PriceExchange = getDataM(spr, getColumIndex(spr,"PriceExchange"), xRow)
     If  getColumIndex(spr,"PriceOrderEX") > -1 then z4902.PriceOrderEX = getDataM(spr, getColumIndex(spr,"PriceOrderEX"), xRow)
     If  getColumIndex(spr,"PriceOrderVND") > -1 then z4902.PriceOrderVND = getDataM(spr, getColumIndex(spr,"PriceOrderVND"), xRow)
     If  getColumIndex(spr,"Datedelivery") > -1 then z4902.Datedelivery = getDataM(spr, getColumIndex(spr,"Datedelivery"), xRow)
     If  getColumIndex(spr,"DateTransfer") > -1 then z4902.DateTransfer = getDataM(spr, getColumIndex(spr,"DateTransfer"), xRow)
     If  getColumIndex(spr,"AcceptedOrder") > -1 then z4902.AcceptedOrder = getDataM(spr, getColumIndex(spr,"AcceptedOrder"), xRow)
     If  getColumIndex(spr,"MaterialStatus") > -1 then z4902.MaterialStatus = getDataM(spr, getColumIndex(spr,"MaterialStatus"), xRow)
     If  getColumIndex(spr,"DateShipping") > -1 then z4902.DateShipping = getDataM(spr, getColumIndex(spr,"DateShipping"), xRow)
     If  getColumIndex(spr,"seUnitMaterial") > -1 then z4902.seUnitMaterial = getDataM(spr, getColumIndex(spr,"seUnitMaterial"), xRow)
     If  getColumIndex(spr,"cdUnitMaterial") > -1 then z4902.cdUnitMaterial = getDataM(spr, getColumIndex(spr,"cdUnitMaterial"), xRow)
     If  getColumIndex(spr,"seUnitPacking") > -1 then z4902.seUnitPacking = getDataM(spr, getColumIndex(spr,"seUnitPacking"), xRow)
     If  getColumIndex(spr,"cdUnitPacking") > -1 then z4902.cdUnitPacking = getDataM(spr, getColumIndex(spr,"cdUnitPacking"), xRow)
     If  getColumIndex(spr,"QtyOrder") > -1 then z4902.QtyOrder = getDataM(spr, getColumIndex(spr,"QtyOrder"), xRow)
     If  getColumIndex(spr,"QtyShipping") > -1 then z4902.QtyShipping = getDataM(spr, getColumIndex(spr,"QtyShipping"), xRow)
     If  getColumIndex(spr,"QtyInbound") > -1 then z4902.QtyInbound = getDataM(spr, getColumIndex(spr,"QtyInbound"), xRow)
     If  getColumIndex(spr,"QtyOutbound") > -1 then z4902.QtyOutbound = getDataM(spr, getColumIndex(spr,"QtyOutbound"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z4902.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z4902.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z4902.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z4902.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"InchargeShipping") > -1 then z4902.InchargeShipping = getDataM(spr, getColumIndex(spr,"InchargeShipping"), xRow)
     If  getColumIndex(spr,"TotalQty") > -1 then z4902.TotalQty = getDataM(spr, getColumIndex(spr,"TotalQty"), xRow)
     If  getColumIndex(spr,"TotalAMT") > -1 then z4902.TotalAMT = getDataM(spr, getColumIndex(spr,"TotalAMT"), xRow)
     If  getColumIndex(spr,"TotalCost") > -1 then z4902.TotalCost = getDataM(spr, getColumIndex(spr,"TotalCost"), xRow)
     If  getColumIndex(spr,"TotalProfit") > -1 then z4902.TotalProfit = getDataM(spr, getColumIndex(spr,"TotalProfit"), xRow)
     If  getColumIndex(spr,"TotalAMTEX") > -1 then z4902.TotalAMTEX = getDataM(spr, getColumIndex(spr,"TotalAMTEX"), xRow)
     If  getColumIndex(spr,"TotalCostEX") > -1 then z4902.TotalCostEX = getDataM(spr, getColumIndex(spr,"TotalCostEX"), xRow)
     If  getColumIndex(spr,"TotalProfitEX") > -1 then z4902.TotalProfitEX = getDataM(spr, getColumIndex(spr,"TotalProfitEX"), xRow)
     If  getColumIndex(spr,"TotalAMTVND") > -1 then z4902.TotalAMTVND = getDataM(spr, getColumIndex(spr,"TotalAMTVND"), xRow)
     If  getColumIndex(spr,"TotalCostVND") > -1 then z4902.TotalCostVND = getDataM(spr, getColumIndex(spr,"TotalCostVND"), xRow)
     If  getColumIndex(spr,"TotalProfitVND") > -1 then z4902.TotalProfitVND = getDataM(spr, getColumIndex(spr,"TotalProfitVND"), xRow)
     If  getColumIndex(spr,"AttachID") > -1 then z4902.AttachID = getDataM(spr, getColumIndex(spr,"AttachID"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z4902.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K4902_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K4902_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z4902 As T4902_AREA,CheckClear as Boolean,SHIPPINGWORKORDER AS String, SHIPPINGWORKORDERSEQ AS String) as Boolean

K4902_MOVE = False

Try
    If READ_PFK4902(SHIPPINGWORKORDER, SHIPPINGWORKORDERSEQ) = True Then
                z4902 = D4902
		K4902_MOVE = True
		else
	If CheckClear  = True then z4902 = nothing
     End If

     If  getColumIndex(spr,"ShippingWorkOrder") > -1 then z4902.ShippingWorkOrder = getDataM(spr, getColumIndex(spr,"ShippingWorkOrder"), xRow)
     If  getColumIndex(spr,"ShippingWorkOrderSeq") > -1 then z4902.ShippingWorkOrderSeq = getDataM(spr, getColumIndex(spr,"ShippingWorkOrderSeq"), xRow)
     If  getColumIndex(spr,"JobCard") > -1 then z4902.JobCard = getDataM(spr, getColumIndex(spr,"JobCard"), xRow)
     If  getColumIndex(spr,"CustomerCode") > -1 then z4902.CustomerCode = getDataM(spr, getColumIndex(spr,"CustomerCode"), xRow)
     If  getColumIndex(spr,"OrderNo") > -1 then z4902.OrderNo = getDataM(spr, getColumIndex(spr,"OrderNo"), xRow)
     If  getColumIndex(spr,"OrderNoSeq") > -1 then z4902.OrderNoSeq = getDataM(spr, getColumIndex(spr,"OrderNoSeq"), xRow)
     If  getColumIndex(spr,"PKO") > -1 then z4902.PKO = getDataM(spr, getColumIndex(spr,"PKO"), xRow)
     If  getColumIndex(spr,"Destination") > -1 then z4902.Destination = getDataM(spr, getColumIndex(spr,"Destination"), xRow)
     If  getColumIndex(spr,"Note1") > -1 then z4902.Note1 = getDataM(spr, getColumIndex(spr,"Note1"), xRow)
     If  getColumIndex(spr,"Note2") > -1 then z4902.Note2 = getDataM(spr, getColumIndex(spr,"Note2"), xRow)
     If  getColumIndex(spr,"Note3") > -1 then z4902.Note3 = getDataM(spr, getColumIndex(spr,"Note3"), xRow)
     If  getColumIndex(spr,"Note4") > -1 then z4902.Note4 = getDataM(spr, getColumIndex(spr,"Note4"), xRow)
     If  getColumIndex(spr,"Note5") > -1 then z4902.Note5 = getDataM(spr, getColumIndex(spr,"Note5"), xRow)
     If  getColumIndex(spr,"ShippingWorkOrderStatus") > -1 then z4902.ShippingWorkOrderStatus = getDataM(spr, getColumIndex(spr,"ShippingWorkOrderStatus"), xRow)
     If  getColumIndex(spr,"DateApproval") > -1 then z4902.DateApproval = getDataM(spr, getColumIndex(spr,"DateApproval"), xRow)
     If  getColumIndex(spr,"DateCancel") > -1 then z4902.DateCancel = getDataM(spr, getColumIndex(spr,"DateCancel"), xRow)
     If  getColumIndex(spr,"DateComplete") > -1 then z4902.DateComplete = getDataM(spr, getColumIndex(spr,"DateComplete"), xRow)
     If  getColumIndex(spr,"DatePending") > -1 then z4902.DatePending = getDataM(spr, getColumIndex(spr,"DatePending"), xRow)
     If  getColumIndex(spr,"DateExchangePrice") > -1 then z4902.DateExchangePrice = getDataM(spr, getColumIndex(spr,"DateExchangePrice"), xRow)
     If  getColumIndex(spr,"PriceOrder") > -1 then z4902.PriceOrder = getDataM(spr, getColumIndex(spr,"PriceOrder"), xRow)
     If  getColumIndex(spr,"seUnitPrice") > -1 then z4902.seUnitPrice = getDataM(spr, getColumIndex(spr,"seUnitPrice"), xRow)
     If  getColumIndex(spr,"cdUnitPrice") > -1 then z4902.cdUnitPrice = getDataM(spr, getColumIndex(spr,"cdUnitPrice"), xRow)
     If  getColumIndex(spr,"DateExchange") > -1 then z4902.DateExchange = getDataM(spr, getColumIndex(spr,"DateExchange"), xRow)
     If  getColumIndex(spr,"PriceExchange") > -1 then z4902.PriceExchange = getDataM(spr, getColumIndex(spr,"PriceExchange"), xRow)
     If  getColumIndex(spr,"PriceOrderEX") > -1 then z4902.PriceOrderEX = getDataM(spr, getColumIndex(spr,"PriceOrderEX"), xRow)
     If  getColumIndex(spr,"PriceOrderVND") > -1 then z4902.PriceOrderVND = getDataM(spr, getColumIndex(spr,"PriceOrderVND"), xRow)
     If  getColumIndex(spr,"Datedelivery") > -1 then z4902.Datedelivery = getDataM(spr, getColumIndex(spr,"Datedelivery"), xRow)
     If  getColumIndex(spr,"DateTransfer") > -1 then z4902.DateTransfer = getDataM(spr, getColumIndex(spr,"DateTransfer"), xRow)
     If  getColumIndex(spr,"AcceptedOrder") > -1 then z4902.AcceptedOrder = getDataM(spr, getColumIndex(spr,"AcceptedOrder"), xRow)
     If  getColumIndex(spr,"MaterialStatus") > -1 then z4902.MaterialStatus = getDataM(spr, getColumIndex(spr,"MaterialStatus"), xRow)
     If  getColumIndex(spr,"DateShipping") > -1 then z4902.DateShipping = getDataM(spr, getColumIndex(spr,"DateShipping"), xRow)
     If  getColumIndex(spr,"seUnitMaterial") > -1 then z4902.seUnitMaterial = getDataM(spr, getColumIndex(spr,"seUnitMaterial"), xRow)
     If  getColumIndex(spr,"cdUnitMaterial") > -1 then z4902.cdUnitMaterial = getDataM(spr, getColumIndex(spr,"cdUnitMaterial"), xRow)
     If  getColumIndex(spr,"seUnitPacking") > -1 then z4902.seUnitPacking = getDataM(spr, getColumIndex(spr,"seUnitPacking"), xRow)
     If  getColumIndex(spr,"cdUnitPacking") > -1 then z4902.cdUnitPacking = getDataM(spr, getColumIndex(spr,"cdUnitPacking"), xRow)
     If  getColumIndex(spr,"QtyOrder") > -1 then z4902.QtyOrder = getDataM(spr, getColumIndex(spr,"QtyOrder"), xRow)
     If  getColumIndex(spr,"QtyShipping") > -1 then z4902.QtyShipping = getDataM(spr, getColumIndex(spr,"QtyShipping"), xRow)
     If  getColumIndex(spr,"QtyInbound") > -1 then z4902.QtyInbound = getDataM(spr, getColumIndex(spr,"QtyInbound"), xRow)
     If  getColumIndex(spr,"QtyOutbound") > -1 then z4902.QtyOutbound = getDataM(spr, getColumIndex(spr,"QtyOutbound"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z4902.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z4902.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z4902.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z4902.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"InchargeShipping") > -1 then z4902.InchargeShipping = getDataM(spr, getColumIndex(spr,"InchargeShipping"), xRow)
     If  getColumIndex(spr,"TotalQty") > -1 then z4902.TotalQty = getDataM(spr, getColumIndex(spr,"TotalQty"), xRow)
     If  getColumIndex(spr,"TotalAMT") > -1 then z4902.TotalAMT = getDataM(spr, getColumIndex(spr,"TotalAMT"), xRow)
     If  getColumIndex(spr,"TotalCost") > -1 then z4902.TotalCost = getDataM(spr, getColumIndex(spr,"TotalCost"), xRow)
     If  getColumIndex(spr,"TotalProfit") > -1 then z4902.TotalProfit = getDataM(spr, getColumIndex(spr,"TotalProfit"), xRow)
     If  getColumIndex(spr,"TotalAMTEX") > -1 then z4902.TotalAMTEX = getDataM(spr, getColumIndex(spr,"TotalAMTEX"), xRow)
     If  getColumIndex(spr,"TotalCostEX") > -1 then z4902.TotalCostEX = getDataM(spr, getColumIndex(spr,"TotalCostEX"), xRow)
     If  getColumIndex(spr,"TotalProfitEX") > -1 then z4902.TotalProfitEX = getDataM(spr, getColumIndex(spr,"TotalProfitEX"), xRow)
     If  getColumIndex(spr,"TotalAMTVND") > -1 then z4902.TotalAMTVND = getDataM(spr, getColumIndex(spr,"TotalAMTVND"), xRow)
     If  getColumIndex(spr,"TotalCostVND") > -1 then z4902.TotalCostVND = getDataM(spr, getColumIndex(spr,"TotalCostVND"), xRow)
     If  getColumIndex(spr,"TotalProfitVND") > -1 then z4902.TotalProfitVND = getDataM(spr, getColumIndex(spr,"TotalProfitVND"), xRow)
     If  getColumIndex(spr,"AttachID") > -1 then z4902.AttachID = getDataM(spr, getColumIndex(spr,"AttachID"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z4902.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K4902_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K4902_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z4902 As T4902_AREA, Job as String, SHIPPINGWORKORDER AS String, SHIPPINGWORKORDERSEQ AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K4902_MOVE = False

Try
    If READ_PFK4902(SHIPPINGWORKORDER, SHIPPINGWORKORDERSEQ) = True Then
                z4902 = D4902
		K4902_MOVE = True
		else
	z4902 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4902")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "SHIPPINGWORKORDER":z4902.ShippingWorkOrder = Children(i).Code
   Case "SHIPPINGWORKORDERSEQ":z4902.ShippingWorkOrderSeq = Children(i).Code
   Case "JOBCARD":z4902.JobCard = Children(i).Code
   Case "CUSTOMERCODE":z4902.CustomerCode = Children(i).Code
   Case "ORDERNO":z4902.OrderNo = Children(i).Code
   Case "ORDERNOSEQ":z4902.OrderNoSeq = Children(i).Code
   Case "PKO":z4902.PKO = Children(i).Code
   Case "DESTINATION":z4902.Destination = Children(i).Code
   Case "NOTE1":z4902.Note1 = Children(i).Code
   Case "NOTE2":z4902.Note2 = Children(i).Code
   Case "NOTE3":z4902.Note3 = Children(i).Code
   Case "NOTE4":z4902.Note4 = Children(i).Code
   Case "NOTE5":z4902.Note5 = Children(i).Code
   Case "SHIPPINGWORKORDERSTATUS":z4902.ShippingWorkOrderStatus = Children(i).Code
   Case "DATEAPPROVAL":z4902.DateApproval = Children(i).Code
   Case "DATECANCEL":z4902.DateCancel = Children(i).Code
   Case "DATECOMPLETE":z4902.DateComplete = Children(i).Code
   Case "DATEPENDING":z4902.DatePending = Children(i).Code
   Case "DATEEXCHANGEPRICE":z4902.DateExchangePrice = Children(i).Code
   Case "PRICEORDER":z4902.PriceOrder = Children(i).Code
   Case "SEUNITPRICE":z4902.seUnitPrice = Children(i).Code
   Case "CDUNITPRICE":z4902.cdUnitPrice = Children(i).Code
   Case "DATEEXCHANGE":z4902.DateExchange = Children(i).Code
   Case "PRICEEXCHANGE":z4902.PriceExchange = Children(i).Code
   Case "PRICEORDEREX":z4902.PriceOrderEX = Children(i).Code
   Case "PRICEORDERVND":z4902.PriceOrderVND = Children(i).Code
   Case "DATEDELIVERY":z4902.Datedelivery = Children(i).Code
   Case "DATETRANSFER":z4902.DateTransfer = Children(i).Code
   Case "ACCEPTEDORDER":z4902.AcceptedOrder = Children(i).Code
   Case "MATERIALSTATUS":z4902.MaterialStatus = Children(i).Code
   Case "DATESHIPPING":z4902.DateShipping = Children(i).Code
   Case "SEUNITMATERIAL":z4902.seUnitMaterial = Children(i).Code
   Case "CDUNITMATERIAL":z4902.cdUnitMaterial = Children(i).Code
   Case "SEUNITPACKING":z4902.seUnitPacking = Children(i).Code
   Case "CDUNITPACKING":z4902.cdUnitPacking = Children(i).Code
   Case "QTYORDER":z4902.QtyOrder = Children(i).Code
   Case "QTYSHIPPING":z4902.QtyShipping = Children(i).Code
   Case "QTYINBOUND":z4902.QtyInbound = Children(i).Code
   Case "QTYOUTBOUND":z4902.QtyOutbound = Children(i).Code
   Case "DATEINSERT":z4902.DateInsert = Children(i).Code
   Case "INCHARGEINSERT":z4902.InchargeInsert = Children(i).Code
   Case "DATEUPDATE":z4902.DateUpdate = Children(i).Code
   Case "INCHARGEUPDATE":z4902.InchargeUpdate = Children(i).Code
   Case "INCHARGESHIPPING":z4902.InchargeShipping = Children(i).Code
   Case "TOTALQTY":z4902.TotalQty = Children(i).Code
   Case "TOTALAMT":z4902.TotalAMT = Children(i).Code
   Case "TOTALCOST":z4902.TotalCost = Children(i).Code
   Case "TOTALPROFIT":z4902.TotalProfit = Children(i).Code
   Case "TOTALAMTEX":z4902.TotalAMTEX = Children(i).Code
   Case "TOTALCOSTEX":z4902.TotalCostEX = Children(i).Code
   Case "TOTALPROFITEX":z4902.TotalProfitEX = Children(i).Code
   Case "TOTALAMTVND":z4902.TotalAMTVND = Children(i).Code
   Case "TOTALCOSTVND":z4902.TotalCostVND = Children(i).Code
   Case "TOTALPROFITVND":z4902.TotalProfitVND = Children(i).Code
   Case "ATTACHID":z4902.AttachID = Children(i).Code
   Case "REMARK":z4902.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "SHIPPINGWORKORDER":z4902.ShippingWorkOrder = Children(i).Data
   Case "SHIPPINGWORKORDERSEQ":z4902.ShippingWorkOrderSeq = Children(i).Data
   Case "JOBCARD":z4902.JobCard = Children(i).Data
   Case "CUSTOMERCODE":z4902.CustomerCode = Children(i).Data
   Case "ORDERNO":z4902.OrderNo = Children(i).Data
   Case "ORDERNOSEQ":z4902.OrderNoSeq = Children(i).Data
   Case "PKO":z4902.PKO = Children(i).Data
   Case "DESTINATION":z4902.Destination = Children(i).Data
   Case "NOTE1":z4902.Note1 = Children(i).Data
   Case "NOTE2":z4902.Note2 = Children(i).Data
   Case "NOTE3":z4902.Note3 = Children(i).Data
   Case "NOTE4":z4902.Note4 = Children(i).Data
   Case "NOTE5":z4902.Note5 = Children(i).Data
   Case "SHIPPINGWORKORDERSTATUS":z4902.ShippingWorkOrderStatus = Children(i).Data
   Case "DATEAPPROVAL":z4902.DateApproval = Children(i).Data
   Case "DATECANCEL":z4902.DateCancel = Children(i).Data
   Case "DATECOMPLETE":z4902.DateComplete = Children(i).Data
   Case "DATEPENDING":z4902.DatePending = Children(i).Data
   Case "DATEEXCHANGEPRICE":z4902.DateExchangePrice = Children(i).Data
   Case "PRICEORDER":z4902.PriceOrder = Children(i).Data
   Case "SEUNITPRICE":z4902.seUnitPrice = Children(i).Data
   Case "CDUNITPRICE":z4902.cdUnitPrice = Children(i).Data
   Case "DATEEXCHANGE":z4902.DateExchange = Children(i).Data
   Case "PRICEEXCHANGE":z4902.PriceExchange = Children(i).Data
   Case "PRICEORDEREX":z4902.PriceOrderEX = Children(i).Data
   Case "PRICEORDERVND":z4902.PriceOrderVND = Children(i).Data
   Case "DATEDELIVERY":z4902.Datedelivery = Children(i).Data
   Case "DATETRANSFER":z4902.DateTransfer = Children(i).Data
   Case "ACCEPTEDORDER":z4902.AcceptedOrder = Children(i).Data
   Case "MATERIALSTATUS":z4902.MaterialStatus = Children(i).Data
   Case "DATESHIPPING":z4902.DateShipping = Children(i).Data
   Case "SEUNITMATERIAL":z4902.seUnitMaterial = Children(i).Data
   Case "CDUNITMATERIAL":z4902.cdUnitMaterial = Children(i).Data
   Case "SEUNITPACKING":z4902.seUnitPacking = Children(i).Data
   Case "CDUNITPACKING":z4902.cdUnitPacking = Children(i).Data
   Case "QTYORDER":z4902.QtyOrder = Children(i).Data
   Case "QTYSHIPPING":z4902.QtyShipping = Children(i).Data
   Case "QTYINBOUND":z4902.QtyInbound = Children(i).Data
   Case "QTYOUTBOUND":z4902.QtyOutbound = Children(i).Data
   Case "DATEINSERT":z4902.DateInsert = Children(i).Data
   Case "INCHARGEINSERT":z4902.InchargeInsert = Children(i).Data
   Case "DATEUPDATE":z4902.DateUpdate = Children(i).Data
   Case "INCHARGEUPDATE":z4902.InchargeUpdate = Children(i).Data
   Case "INCHARGESHIPPING":z4902.InchargeShipping = Children(i).Data
   Case "TOTALQTY":z4902.TotalQty = Children(i).Data
   Case "TOTALAMT":z4902.TotalAMT = Children(i).Data
   Case "TOTALCOST":z4902.TotalCost = Children(i).Data
   Case "TOTALPROFIT":z4902.TotalProfit = Children(i).Data
   Case "TOTALAMTEX":z4902.TotalAMTEX = Children(i).Data
   Case "TOTALCOSTEX":z4902.TotalCostEX = Children(i).Data
   Case "TOTALPROFITEX":z4902.TotalProfitEX = Children(i).Data
   Case "TOTALAMTVND":z4902.TotalAMTVND = Children(i).Data
   Case "TOTALCOSTVND":z4902.TotalCostVND = Children(i).Data
   Case "TOTALPROFITVND":z4902.TotalProfitVND = Children(i).Data
   Case "ATTACHID":z4902.AttachID = Children(i).Data
   Case "REMARK":z4902.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K4902_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K4902_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z4902 As T4902_AREA, Job as String, CheckClear as Boolean, SHIPPINGWORKORDER AS String, SHIPPINGWORKORDERSEQ AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K4902_MOVE = False

Try
    If READ_PFK4902(SHIPPINGWORKORDER, SHIPPINGWORKORDERSEQ) = True Then
                z4902 = D4902
		K4902_MOVE = True
		else
	If CheckClear  = True then z4902 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4902")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "SHIPPINGWORKORDER":z4902.ShippingWorkOrder = Children(i).Code
   Case "SHIPPINGWORKORDERSEQ":z4902.ShippingWorkOrderSeq = Children(i).Code
   Case "JOBCARD":z4902.JobCard = Children(i).Code
   Case "CUSTOMERCODE":z4902.CustomerCode = Children(i).Code
   Case "ORDERNO":z4902.OrderNo = Children(i).Code
   Case "ORDERNOSEQ":z4902.OrderNoSeq = Children(i).Code
   Case "PKO":z4902.PKO = Children(i).Code
   Case "DESTINATION":z4902.Destination = Children(i).Code
   Case "NOTE1":z4902.Note1 = Children(i).Code
   Case "NOTE2":z4902.Note2 = Children(i).Code
   Case "NOTE3":z4902.Note3 = Children(i).Code
   Case "NOTE4":z4902.Note4 = Children(i).Code
   Case "NOTE5":z4902.Note5 = Children(i).Code
   Case "SHIPPINGWORKORDERSTATUS":z4902.ShippingWorkOrderStatus = Children(i).Code
   Case "DATEAPPROVAL":z4902.DateApproval = Children(i).Code
   Case "DATECANCEL":z4902.DateCancel = Children(i).Code
   Case "DATECOMPLETE":z4902.DateComplete = Children(i).Code
   Case "DATEPENDING":z4902.DatePending = Children(i).Code
   Case "DATEEXCHANGEPRICE":z4902.DateExchangePrice = Children(i).Code
   Case "PRICEORDER":z4902.PriceOrder = Children(i).Code
   Case "SEUNITPRICE":z4902.seUnitPrice = Children(i).Code
   Case "CDUNITPRICE":z4902.cdUnitPrice = Children(i).Code
   Case "DATEEXCHANGE":z4902.DateExchange = Children(i).Code
   Case "PRICEEXCHANGE":z4902.PriceExchange = Children(i).Code
   Case "PRICEORDEREX":z4902.PriceOrderEX = Children(i).Code
   Case "PRICEORDERVND":z4902.PriceOrderVND = Children(i).Code
   Case "DATEDELIVERY":z4902.Datedelivery = Children(i).Code
   Case "DATETRANSFER":z4902.DateTransfer = Children(i).Code
   Case "ACCEPTEDORDER":z4902.AcceptedOrder = Children(i).Code
   Case "MATERIALSTATUS":z4902.MaterialStatus = Children(i).Code
   Case "DATESHIPPING":z4902.DateShipping = Children(i).Code
   Case "SEUNITMATERIAL":z4902.seUnitMaterial = Children(i).Code
   Case "CDUNITMATERIAL":z4902.cdUnitMaterial = Children(i).Code
   Case "SEUNITPACKING":z4902.seUnitPacking = Children(i).Code
   Case "CDUNITPACKING":z4902.cdUnitPacking = Children(i).Code
   Case "QTYORDER":z4902.QtyOrder = Children(i).Code
   Case "QTYSHIPPING":z4902.QtyShipping = Children(i).Code
   Case "QTYINBOUND":z4902.QtyInbound = Children(i).Code
   Case "QTYOUTBOUND":z4902.QtyOutbound = Children(i).Code
   Case "DATEINSERT":z4902.DateInsert = Children(i).Code
   Case "INCHARGEINSERT":z4902.InchargeInsert = Children(i).Code
   Case "DATEUPDATE":z4902.DateUpdate = Children(i).Code
   Case "INCHARGEUPDATE":z4902.InchargeUpdate = Children(i).Code
   Case "INCHARGESHIPPING":z4902.InchargeShipping = Children(i).Code
   Case "TOTALQTY":z4902.TotalQty = Children(i).Code
   Case "TOTALAMT":z4902.TotalAMT = Children(i).Code
   Case "TOTALCOST":z4902.TotalCost = Children(i).Code
   Case "TOTALPROFIT":z4902.TotalProfit = Children(i).Code
   Case "TOTALAMTEX":z4902.TotalAMTEX = Children(i).Code
   Case "TOTALCOSTEX":z4902.TotalCostEX = Children(i).Code
   Case "TOTALPROFITEX":z4902.TotalProfitEX = Children(i).Code
   Case "TOTALAMTVND":z4902.TotalAMTVND = Children(i).Code
   Case "TOTALCOSTVND":z4902.TotalCostVND = Children(i).Code
   Case "TOTALPROFITVND":z4902.TotalProfitVND = Children(i).Code
   Case "ATTACHID":z4902.AttachID = Children(i).Code
   Case "REMARK":z4902.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "SHIPPINGWORKORDER":z4902.ShippingWorkOrder = Children(i).Data
   Case "SHIPPINGWORKORDERSEQ":z4902.ShippingWorkOrderSeq = Children(i).Data
   Case "JOBCARD":z4902.JobCard = Children(i).Data
   Case "CUSTOMERCODE":z4902.CustomerCode = Children(i).Data
   Case "ORDERNO":z4902.OrderNo = Children(i).Data
   Case "ORDERNOSEQ":z4902.OrderNoSeq = Children(i).Data
   Case "PKO":z4902.PKO = Children(i).Data
   Case "DESTINATION":z4902.Destination = Children(i).Data
   Case "NOTE1":z4902.Note1 = Children(i).Data
   Case "NOTE2":z4902.Note2 = Children(i).Data
   Case "NOTE3":z4902.Note3 = Children(i).Data
   Case "NOTE4":z4902.Note4 = Children(i).Data
   Case "NOTE5":z4902.Note5 = Children(i).Data
   Case "SHIPPINGWORKORDERSTATUS":z4902.ShippingWorkOrderStatus = Children(i).Data
   Case "DATEAPPROVAL":z4902.DateApproval = Children(i).Data
   Case "DATECANCEL":z4902.DateCancel = Children(i).Data
   Case "DATECOMPLETE":z4902.DateComplete = Children(i).Data
   Case "DATEPENDING":z4902.DatePending = Children(i).Data
   Case "DATEEXCHANGEPRICE":z4902.DateExchangePrice = Children(i).Data
   Case "PRICEORDER":z4902.PriceOrder = Children(i).Data
   Case "SEUNITPRICE":z4902.seUnitPrice = Children(i).Data
   Case "CDUNITPRICE":z4902.cdUnitPrice = Children(i).Data
   Case "DATEEXCHANGE":z4902.DateExchange = Children(i).Data
   Case "PRICEEXCHANGE":z4902.PriceExchange = Children(i).Data
   Case "PRICEORDEREX":z4902.PriceOrderEX = Children(i).Data
   Case "PRICEORDERVND":z4902.PriceOrderVND = Children(i).Data
   Case "DATEDELIVERY":z4902.Datedelivery = Children(i).Data
   Case "DATETRANSFER":z4902.DateTransfer = Children(i).Data
   Case "ACCEPTEDORDER":z4902.AcceptedOrder = Children(i).Data
   Case "MATERIALSTATUS":z4902.MaterialStatus = Children(i).Data
   Case "DATESHIPPING":z4902.DateShipping = Children(i).Data
   Case "SEUNITMATERIAL":z4902.seUnitMaterial = Children(i).Data
   Case "CDUNITMATERIAL":z4902.cdUnitMaterial = Children(i).Data
   Case "SEUNITPACKING":z4902.seUnitPacking = Children(i).Data
   Case "CDUNITPACKING":z4902.cdUnitPacking = Children(i).Data
   Case "QTYORDER":z4902.QtyOrder = Children(i).Data
   Case "QTYSHIPPING":z4902.QtyShipping = Children(i).Data
   Case "QTYINBOUND":z4902.QtyInbound = Children(i).Data
   Case "QTYOUTBOUND":z4902.QtyOutbound = Children(i).Data
   Case "DATEINSERT":z4902.DateInsert = Children(i).Data
   Case "INCHARGEINSERT":z4902.InchargeInsert = Children(i).Data
   Case "DATEUPDATE":z4902.DateUpdate = Children(i).Data
   Case "INCHARGEUPDATE":z4902.InchargeUpdate = Children(i).Data
   Case "INCHARGESHIPPING":z4902.InchargeShipping = Children(i).Data
   Case "TOTALQTY":z4902.TotalQty = Children(i).Data
   Case "TOTALAMT":z4902.TotalAMT = Children(i).Data
   Case "TOTALCOST":z4902.TotalCost = Children(i).Data
   Case "TOTALPROFIT":z4902.TotalProfit = Children(i).Data
   Case "TOTALAMTEX":z4902.TotalAMTEX = Children(i).Data
   Case "TOTALCOSTEX":z4902.TotalCostEX = Children(i).Data
   Case "TOTALPROFITEX":z4902.TotalProfitEX = Children(i).Data
   Case "TOTALAMTVND":z4902.TotalAMTVND = Children(i).Data
   Case "TOTALCOSTVND":z4902.TotalCostVND = Children(i).Data
   Case "TOTALPROFITVND":z4902.TotalProfitVND = Children(i).Data
   Case "ATTACHID":z4902.AttachID = Children(i).Data
   Case "REMARK":z4902.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K4902_MOVE",vbCritical)
End Try
End Function 
    
End Module 
