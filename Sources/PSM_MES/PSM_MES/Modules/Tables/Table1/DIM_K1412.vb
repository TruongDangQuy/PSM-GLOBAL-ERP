'=========================================================================================================================================================
'   TABLE : (PFK1412)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K1412

Structure T1412_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	OrderNo	 AS String	'			char(9)		*
Public 	OrderNoSeq	 AS String	'			char(3)		*
Public 	ShoesCode	 AS String	'			char(6)
Public 	FacPO	 AS String	'			nvarchar(50)
Public 	SLNoSys	 AS String	'			nvarchar(20)
Public 	SLNo	 AS String	'			nvarchar(20)
Public 	PONO	 AS String	'			nvarchar(50)
Public 	CPONO	 AS String	'			nvarchar(50)
Public 	CustomerCode	 AS String	'			char(6)
Public 	CustomerName	 AS String	'			nvarchar(50)
Public 	Country	 AS String	'			nvarchar(50)
Public 	Destination	 AS String	'			nvarchar(50)
Public 	FinalShop	 AS String	'			nvarchar(50)
Public 	PKO	 AS String	'			nvarchar(50)
Public 	DatePO	 AS String	'			char(8)
Public 	JbCard	 AS String	'			nvarchar(50)
Public 	sePackingCode	 AS String	'			char(3)
Public 	cdPackingCode	 AS String	'			char(3)
Public 	seSpecStatus	 AS String	'			char(3)
Public 	cdSpecStatus	 AS String	'			char(3)
Public 	SizeRange	 AS String	'			char(6)
Public 	SpeciticSize	 AS String	'			nvarchar(4)
Public 	DateSize	 AS String	'			char(8)
Public 	OrderDetailStatus	 AS String	'			char(1)
Public 	DateOrder	 AS String	'			char(8)
Public 	DateApproval	 AS String	'			char(8)
Public 	DateCancel	 AS String	'			char(8)
Public 	DateComplete	 AS String	'			char(8)
Public 	DatePending	 AS String	'			char(8)
Public 	DatePending2	 AS String	'			char(8)
Public 	DateExchangePrice	 AS String	'			char(8)
Public 	PriceExchange	 AS Double	'			decimal
Public 	PriceOrder	 AS Double	'			decimal
Public 	seUnitPrice	 AS String	'			char(3)
Public 	cdUnitPrice	 AS String	'			char(3)
Public 	UnitPrice	 AS String	'			char(3)
Public 	PriceOrderEX	 AS Double	'			decimal
Public 	PriceOrderVND	 AS Double	'			decimal
Public 	Datedelivery	 AS String	'			char(8)
Public 	DateTransfer	 AS String	'			char(8)
Public 	AcceptedOrder	 AS String	'			char(1)
Public 	MaterialStatus	 AS String	'			char(1)
Public 	SoleStatus	 AS String	'			char(1)
Public 	DateLable	 AS String	'			char(8)
Public 	DatePattern	 AS String	'			char(8)
Public 	DateMaterial	 AS String	'			char(8)
Public 	DatePlanning	 AS String	'			char(8)
Public 	DateRnD	 AS String	'			char(8)
Public 	DateFitting	 AS String	'			char(8)
Public 	InchargeFitting	 AS String	'			char(8)
Public 	CheckFitting	 AS String	'			char(1)
Public 	DateTesting	 AS String	'			char(8)
Public 	InchargeTesting	 AS String	'			char(8)
Public 	CheckTesting	 AS String	'			char(1)
Public 	CheckConfirm	 AS String	'			char(1)
Public 	DateConfirm	 AS String	'			char(8)
Public 	SpecNo	 AS String	'			char(9)
Public 	SpecNoSeq	 AS String	'			char(3)
Public 	DateSole	 AS String	'			char(8)
Public 	DateCutting	 AS String	'			char(8)
Public 	DateStitching	 AS String	'			char(8)
Public 	DateStockfit	 AS String	'			char(8)
Public 	DateAssmbly	 AS String	'			char(8)
Public 	DateShipping	 AS String	'			char(8)
Public 	seUnitMaterial	 AS String	'			char(3)
Public 	cdUnitMaterial	 AS String	'			char(3)
Public 	seUnitPacking	 AS String	'			char(3)
Public 	cdUnitPacking	 AS String	'			char(3)
Public 	QtyOrder	 AS Double	'			decimal
Public 	QtyJob	 AS Double	'			decimal
Public 	QtySole	 AS Double	'			decimal
Public 	QtyCutting	 AS Double	'			decimal
Public 	QtyStitching	 AS Double	'			decimal
Public 	QtyStockfit	 AS Double	'			decimal
Public 	QtyAssembly	 AS Double	'			decimal
Public 	QtyPacking	 AS Double	'			decimal
Public 	QtyInbound	 AS Double	'			decimal
Public 	QtyShipping	 AS Double	'			decimal
Public 	DateInsert	 AS String	'			char(8)
Public 	InchargeInsert	 AS String	'			char(8)
Public 	DateUpdate	 AS String	'			char(8)
Public 	InchargeUpdate	 AS String	'			char(8)
Public 	InchargeSales	 AS String	'			char(8)
Public 	InchargePPC	 AS String	'			char(8)
Public 	TotalQty	 AS Double	'			decimal
Public 	TotalAMT	 AS Double	'			decimal
Public 	TotalCost	 AS Double	'			decimal
Public 	TotalProfit	 AS Double	'			decimal
Public 	TotalAMTEX	 AS Double	'			decimal
Public 	TotalAMTVND	 AS Double	'			decimal
Public 	TotalCostEX	 AS Double	'			decimal
Public 	TotalCostVND	 AS Double	'			decimal
Public 	TotalProfitEX	 AS Double	'			decimal
Public 	TotalProfitVND	 AS Double	'			decimal
Public 	AttachID	 AS String	'			char(6)
Public 	OrderNoRef	 AS String	'			char(9)
Public 	OrderNoSeqRef	 AS String	'			char(3)
Public 	Remark	 AS String	'			nvarchar(50)
Public 	RemarkOrder	 AS String	'			nvarchar(50)
Public 	RemarkCustomer	 AS String	'			nvarchar(50)
Public 	RemarkOther	 AS String	'			nvarchar(50)
'=========================================================================================================================================================
End structure

Public D1412 As T1412_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK1412(ORDERNO AS String, ORDERNOSEQ AS String) As Boolean
    READ_PFK1412 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK1412 "
    SQL = SQL & " WHERE K1412_OrderNo		 = '" & OrderNo & "' " 
    SQL = SQL & "   AND K1412_OrderNoSeq		 = '" & OrderNoSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D1412_CLEAR: GoTo SKIP_READ_PFK1412
                
    Call K1412_MOVE(rd)
    READ_PFK1412 = True

SKIP_READ_PFK1412:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK1412",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK1412(ORDERNO AS String, ORDERNOSEQ AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK1412 "
    SQL = SQL & " WHERE K1412_OrderNo		 = '" & OrderNo & "' " 
    SQL = SQL & "   AND K1412_OrderNoSeq		 = '" & OrderNoSeq & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK1412",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK1412(z1412 As T1412_AREA) As Boolean
    WRITE_PFK1412 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z1412)
 
    SQL = " INSERT INTO PFK1412 "
    SQL = SQL & " ( "
    SQL = SQL & " K1412_OrderNo," 
    SQL = SQL & " K1412_OrderNoSeq," 
    SQL = SQL & " K1412_ShoesCode," 
    SQL = SQL & " K1412_FacPO," 
    SQL = SQL & " K1412_SLNoSys," 
    SQL = SQL & " K1412_SLNo," 
    SQL = SQL & " K1412_PONO," 
    SQL = SQL & " K1412_CPONO," 
    SQL = SQL & " K1412_CustomerCode," 
    SQL = SQL & " K1412_CustomerName," 
    SQL = SQL & " K1412_Country," 
    SQL = SQL & " K1412_Destination," 
    SQL = SQL & " K1412_FinalShop," 
    SQL = SQL & " K1412_PKO," 
    SQL = SQL & " K1412_DatePO," 
    SQL = SQL & " K1412_JbCard," 
    SQL = SQL & " K1412_sePackingCode," 
    SQL = SQL & " K1412_cdPackingCode," 
    SQL = SQL & " K1412_seSpecStatus," 
    SQL = SQL & " K1412_cdSpecStatus," 
    SQL = SQL & " K1412_SizeRange," 
    SQL = SQL & " K1412_SpeciticSize," 
    SQL = SQL & " K1412_DateSize," 
    SQL = SQL & " K1412_OrderDetailStatus," 
    SQL = SQL & " K1412_DateOrder," 
    SQL = SQL & " K1412_DateApproval," 
    SQL = SQL & " K1412_DateCancel," 
    SQL = SQL & " K1412_DateComplete," 
    SQL = SQL & " K1412_DatePending," 
    SQL = SQL & " K1412_DatePending2," 
    SQL = SQL & " K1412_DateExchangePrice," 
    SQL = SQL & " K1412_PriceExchange," 
    SQL = SQL & " K1412_PriceOrder," 
    SQL = SQL & " K1412_seUnitPrice," 
    SQL = SQL & " K1412_cdUnitPrice," 
    SQL = SQL & " K1412_UnitPrice," 
    SQL = SQL & " K1412_PriceOrderEX," 
    SQL = SQL & " K1412_PriceOrderVND," 
    SQL = SQL & " K1412_Datedelivery," 
    SQL = SQL & " K1412_DateTransfer," 
    SQL = SQL & " K1412_AcceptedOrder," 
    SQL = SQL & " K1412_MaterialStatus," 
    SQL = SQL & " K1412_SoleStatus," 
    SQL = SQL & " K1412_DateLable," 
    SQL = SQL & " K1412_DatePattern," 
    SQL = SQL & " K1412_DateMaterial," 
    SQL = SQL & " K1412_DatePlanning," 
    SQL = SQL & " K1412_DateRnD," 
    SQL = SQL & " K1412_DateFitting," 
    SQL = SQL & " K1412_InchargeFitting," 
    SQL = SQL & " K1412_CheckFitting," 
    SQL = SQL & " K1412_DateTesting," 
    SQL = SQL & " K1412_InchargeTesting," 
    SQL = SQL & " K1412_CheckTesting," 
    SQL = SQL & " K1412_CheckConfirm," 
    SQL = SQL & " K1412_DateConfirm," 
    SQL = SQL & " K1412_SpecNo," 
    SQL = SQL & " K1412_SpecNoSeq," 
    SQL = SQL & " K1412_DateSole," 
    SQL = SQL & " K1412_DateCutting," 
    SQL = SQL & " K1412_DateStitching," 
    SQL = SQL & " K1412_DateStockfit," 
    SQL = SQL & " K1412_DateAssmbly," 
    SQL = SQL & " K1412_DateShipping," 
    SQL = SQL & " K1412_seUnitMaterial," 
    SQL = SQL & " K1412_cdUnitMaterial," 
    SQL = SQL & " K1412_seUnitPacking," 
    SQL = SQL & " K1412_cdUnitPacking," 
    SQL = SQL & " K1412_QtyOrder," 
    SQL = SQL & " K1412_QtyJob," 
    SQL = SQL & " K1412_QtySole," 
    SQL = SQL & " K1412_QtyCutting," 
    SQL = SQL & " K1412_QtyStitching," 
    SQL = SQL & " K1412_QtyStockfit," 
    SQL = SQL & " K1412_QtyAssembly," 
    SQL = SQL & " K1412_QtyPacking," 
    SQL = SQL & " K1412_QtyInbound," 
    SQL = SQL & " K1412_QtyShipping," 
    SQL = SQL & " K1412_DateInsert," 
    SQL = SQL & " K1412_InchargeInsert," 
    SQL = SQL & " K1412_DateUpdate," 
    SQL = SQL & " K1412_InchargeUpdate," 
    SQL = SQL & " K1412_InchargeSales," 
    SQL = SQL & " K1412_InchargePPC," 
    SQL = SQL & " K1412_TotalQty," 
    SQL = SQL & " K1412_TotalAMT," 
    SQL = SQL & " K1412_TotalCost," 
    SQL = SQL & " K1412_TotalProfit," 
    SQL = SQL & " K1412_TotalAMTEX," 
    SQL = SQL & " K1412_TotalAMTVND," 
    SQL = SQL & " K1412_TotalCostEX," 
    SQL = SQL & " K1412_TotalCostVND," 
    SQL = SQL & " K1412_TotalProfitEX," 
    SQL = SQL & " K1412_TotalProfitVND," 
    SQL = SQL & " K1412_AttachID," 
    SQL = SQL & " K1412_OrderNoRef," 
    SQL = SQL & " K1412_OrderNoSeqRef," 
    SQL = SQL & " K1412_Remark," 
    SQL = SQL & " K1412_RemarkOrder," 
    SQL = SQL & " K1412_RemarkCustomer," 
    SQL = SQL & " K1412_RemarkOther " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z1412.OrderNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.OrderNoSeq) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.ShoesCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.FacPO) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.SLNoSys) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.SLNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.PONO) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.CPONO) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.CustomerCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.CustomerName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.Country) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.Destination) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.FinalShop) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.PKO) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.DatePO) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.JbCard) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.sePackingCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.cdPackingCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.seSpecStatus) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.cdSpecStatus) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.SizeRange) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.SpeciticSize) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.DateSize) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.OrderDetailStatus) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.DateOrder) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.DateApproval) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.DateCancel) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.DateComplete) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.DatePending) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.DatePending2) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.DateExchangePrice) & "', "  
    SQL = SQL & "   " & FormatSQL(z1412.PriceExchange) & ", "  
    SQL = SQL & "   " & FormatSQL(z1412.PriceOrder) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z1412.seUnitPrice) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.cdUnitPrice) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.UnitPrice) & "', "  
    SQL = SQL & "   " & FormatSQL(z1412.PriceOrderEX) & ", "  
    SQL = SQL & "   " & FormatSQL(z1412.PriceOrderVND) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z1412.Datedelivery) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.DateTransfer) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.AcceptedOrder) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.MaterialStatus) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.SoleStatus) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.DateLable) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.DatePattern) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.DateMaterial) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.DatePlanning) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.DateRnD) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.DateFitting) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.InchargeFitting) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.CheckFitting) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.DateTesting) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.InchargeTesting) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.CheckTesting) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.CheckConfirm) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.DateConfirm) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.SpecNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.SpecNoSeq) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.DateSole) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.DateCutting) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.DateStitching) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.DateStockfit) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.DateAssmbly) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.DateShipping) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.seUnitMaterial) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.cdUnitMaterial) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.seUnitPacking) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.cdUnitPacking) & "', "  
    SQL = SQL & "   " & FormatSQL(z1412.QtyOrder) & ", "  
    SQL = SQL & "   " & FormatSQL(z1412.QtyJob) & ", "  
    SQL = SQL & "   " & FormatSQL(z1412.QtySole) & ", "  
    SQL = SQL & "   " & FormatSQL(z1412.QtyCutting) & ", "  
    SQL = SQL & "   " & FormatSQL(z1412.QtyStitching) & ", "  
    SQL = SQL & "   " & FormatSQL(z1412.QtyStockfit) & ", "  
    SQL = SQL & "   " & FormatSQL(z1412.QtyAssembly) & ", "  
    SQL = SQL & "   " & FormatSQL(z1412.QtyPacking) & ", "  
    SQL = SQL & "   " & FormatSQL(z1412.QtyInbound) & ", "  
    SQL = SQL & "   " & FormatSQL(z1412.QtyShipping) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z1412.DateInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.InchargeSales) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.InchargePPC) & "', "  
    SQL = SQL & "   " & FormatSQL(z1412.TotalQty) & ", "  
    SQL = SQL & "   " & FormatSQL(z1412.TotalAMT) & ", "  
    SQL = SQL & "   " & FormatSQL(z1412.TotalCost) & ", "  
    SQL = SQL & "   " & FormatSQL(z1412.TotalProfit) & ", "  
    SQL = SQL & "   " & FormatSQL(z1412.TotalAMTEX) & ", "  
    SQL = SQL & "   " & FormatSQL(z1412.TotalAMTVND) & ", "  
    SQL = SQL & "   " & FormatSQL(z1412.TotalCostEX) & ", "  
    SQL = SQL & "   " & FormatSQL(z1412.TotalCostVND) & ", "  
    SQL = SQL & "   " & FormatSQL(z1412.TotalProfitEX) & ", "  
    SQL = SQL & "   " & FormatSQL(z1412.TotalProfitVND) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z1412.AttachID) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.OrderNoRef) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.OrderNoSeqRef) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.Remark) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.RemarkOrder) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.RemarkCustomer) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1412.RemarkOther) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK1412 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK1412",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK1412(z1412 As T1412_AREA) As Boolean
    REWRITE_PFK1412 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z1412)
   
    SQL = " UPDATE PFK1412 SET "
    SQL = SQL & "    K1412_ShoesCode      = N'" & FormatSQL(z1412.ShoesCode) & "', " 
    SQL = SQL & "    K1412_FacPO      = N'" & FormatSQL(z1412.FacPO) & "', " 
    SQL = SQL & "    K1412_SLNoSys      = N'" & FormatSQL(z1412.SLNoSys) & "', " 
    SQL = SQL & "    K1412_SLNo      = N'" & FormatSQL(z1412.SLNo) & "', " 
    SQL = SQL & "    K1412_PONO      = N'" & FormatSQL(z1412.PONO) & "', " 
    SQL = SQL & "    K1412_CPONO      = N'" & FormatSQL(z1412.CPONO) & "', " 
    SQL = SQL & "    K1412_CustomerCode      = N'" & FormatSQL(z1412.CustomerCode) & "', " 
    SQL = SQL & "    K1412_CustomerName      = N'" & FormatSQL(z1412.CustomerName) & "', " 
    SQL = SQL & "    K1412_Country      = N'" & FormatSQL(z1412.Country) & "', " 
    SQL = SQL & "    K1412_Destination      = N'" & FormatSQL(z1412.Destination) & "', " 
    SQL = SQL & "    K1412_FinalShop      = N'" & FormatSQL(z1412.FinalShop) & "', " 
    SQL = SQL & "    K1412_PKO      = N'" & FormatSQL(z1412.PKO) & "', " 
    SQL = SQL & "    K1412_DatePO      = N'" & FormatSQL(z1412.DatePO) & "', " 
    SQL = SQL & "    K1412_JbCard      = N'" & FormatSQL(z1412.JbCard) & "', " 
    SQL = SQL & "    K1412_sePackingCode      = N'" & FormatSQL(z1412.sePackingCode) & "', " 
    SQL = SQL & "    K1412_cdPackingCode      = N'" & FormatSQL(z1412.cdPackingCode) & "', " 
    SQL = SQL & "    K1412_seSpecStatus      = N'" & FormatSQL(z1412.seSpecStatus) & "', " 
    SQL = SQL & "    K1412_cdSpecStatus      = N'" & FormatSQL(z1412.cdSpecStatus) & "', " 
    SQL = SQL & "    K1412_SizeRange      = N'" & FormatSQL(z1412.SizeRange) & "', " 
    SQL = SQL & "    K1412_SpeciticSize      = N'" & FormatSQL(z1412.SpeciticSize) & "', " 
    SQL = SQL & "    K1412_DateSize      = N'" & FormatSQL(z1412.DateSize) & "', " 
    SQL = SQL & "    K1412_OrderDetailStatus      = N'" & FormatSQL(z1412.OrderDetailStatus) & "', " 
    SQL = SQL & "    K1412_DateOrder      = N'" & FormatSQL(z1412.DateOrder) & "', " 
    SQL = SQL & "    K1412_DateApproval      = N'" & FormatSQL(z1412.DateApproval) & "', " 
    SQL = SQL & "    K1412_DateCancel      = N'" & FormatSQL(z1412.DateCancel) & "', " 
    SQL = SQL & "    K1412_DateComplete      = N'" & FormatSQL(z1412.DateComplete) & "', " 
    SQL = SQL & "    K1412_DatePending      = N'" & FormatSQL(z1412.DatePending) & "', " 
    SQL = SQL & "    K1412_DatePending2      = N'" & FormatSQL(z1412.DatePending2) & "', " 
    SQL = SQL & "    K1412_DateExchangePrice      = N'" & FormatSQL(z1412.DateExchangePrice) & "', " 
    SQL = SQL & "    K1412_PriceExchange      =  " & FormatSQL(z1412.PriceExchange) & ", " 
    SQL = SQL & "    K1412_PriceOrder      =  " & FormatSQL(z1412.PriceOrder) & ", " 
    SQL = SQL & "    K1412_seUnitPrice      = N'" & FormatSQL(z1412.seUnitPrice) & "', " 
    SQL = SQL & "    K1412_cdUnitPrice      = N'" & FormatSQL(z1412.cdUnitPrice) & "', " 
    SQL = SQL & "    K1412_UnitPrice      = N'" & FormatSQL(z1412.UnitPrice) & "', " 
    SQL = SQL & "    K1412_PriceOrderEX      =  " & FormatSQL(z1412.PriceOrderEX) & ", " 
    SQL = SQL & "    K1412_PriceOrderVND      =  " & FormatSQL(z1412.PriceOrderVND) & ", " 
    SQL = SQL & "    K1412_Datedelivery      = N'" & FormatSQL(z1412.Datedelivery) & "', " 
    SQL = SQL & "    K1412_DateTransfer      = N'" & FormatSQL(z1412.DateTransfer) & "', " 
    SQL = SQL & "    K1412_AcceptedOrder      = N'" & FormatSQL(z1412.AcceptedOrder) & "', " 
    SQL = SQL & "    K1412_MaterialStatus      = N'" & FormatSQL(z1412.MaterialStatus) & "', " 
    SQL = SQL & "    K1412_SoleStatus      = N'" & FormatSQL(z1412.SoleStatus) & "', " 
    SQL = SQL & "    K1412_DateLable      = N'" & FormatSQL(z1412.DateLable) & "', " 
    SQL = SQL & "    K1412_DatePattern      = N'" & FormatSQL(z1412.DatePattern) & "', " 
    SQL = SQL & "    K1412_DateMaterial      = N'" & FormatSQL(z1412.DateMaterial) & "', " 
    SQL = SQL & "    K1412_DatePlanning      = N'" & FormatSQL(z1412.DatePlanning) & "', " 
    SQL = SQL & "    K1412_DateRnD      = N'" & FormatSQL(z1412.DateRnD) & "', " 
    SQL = SQL & "    K1412_DateFitting      = N'" & FormatSQL(z1412.DateFitting) & "', " 
    SQL = SQL & "    K1412_InchargeFitting      = N'" & FormatSQL(z1412.InchargeFitting) & "', " 
    SQL = SQL & "    K1412_CheckFitting      = N'" & FormatSQL(z1412.CheckFitting) & "', " 
    SQL = SQL & "    K1412_DateTesting      = N'" & FormatSQL(z1412.DateTesting) & "', " 
    SQL = SQL & "    K1412_InchargeTesting      = N'" & FormatSQL(z1412.InchargeTesting) & "', " 
    SQL = SQL & "    K1412_CheckTesting      = N'" & FormatSQL(z1412.CheckTesting) & "', " 
    SQL = SQL & "    K1412_CheckConfirm      = N'" & FormatSQL(z1412.CheckConfirm) & "', " 
    SQL = SQL & "    K1412_DateConfirm      = N'" & FormatSQL(z1412.DateConfirm) & "', " 
    SQL = SQL & "    K1412_SpecNo      = N'" & FormatSQL(z1412.SpecNo) & "', " 
    SQL = SQL & "    K1412_SpecNoSeq      = N'" & FormatSQL(z1412.SpecNoSeq) & "', " 
    SQL = SQL & "    K1412_DateSole      = N'" & FormatSQL(z1412.DateSole) & "', " 
    SQL = SQL & "    K1412_DateCutting      = N'" & FormatSQL(z1412.DateCutting) & "', " 
    SQL = SQL & "    K1412_DateStitching      = N'" & FormatSQL(z1412.DateStitching) & "', " 
    SQL = SQL & "    K1412_DateStockfit      = N'" & FormatSQL(z1412.DateStockfit) & "', " 
    SQL = SQL & "    K1412_DateAssmbly      = N'" & FormatSQL(z1412.DateAssmbly) & "', " 
    SQL = SQL & "    K1412_DateShipping      = N'" & FormatSQL(z1412.DateShipping) & "', " 
    SQL = SQL & "    K1412_seUnitMaterial      = N'" & FormatSQL(z1412.seUnitMaterial) & "', " 
    SQL = SQL & "    K1412_cdUnitMaterial      = N'" & FormatSQL(z1412.cdUnitMaterial) & "', " 
    SQL = SQL & "    K1412_seUnitPacking      = N'" & FormatSQL(z1412.seUnitPacking) & "', " 
    SQL = SQL & "    K1412_cdUnitPacking      = N'" & FormatSQL(z1412.cdUnitPacking) & "', " 
    SQL = SQL & "    K1412_QtyOrder      =  " & FormatSQL(z1412.QtyOrder) & ", " 
    SQL = SQL & "    K1412_QtyJob      =  " & FormatSQL(z1412.QtyJob) & ", " 
    SQL = SQL & "    K1412_QtySole      =  " & FormatSQL(z1412.QtySole) & ", " 
    SQL = SQL & "    K1412_QtyCutting      =  " & FormatSQL(z1412.QtyCutting) & ", " 
    SQL = SQL & "    K1412_QtyStitching      =  " & FormatSQL(z1412.QtyStitching) & ", " 
    SQL = SQL & "    K1412_QtyStockfit      =  " & FormatSQL(z1412.QtyStockfit) & ", " 
    SQL = SQL & "    K1412_QtyAssembly      =  " & FormatSQL(z1412.QtyAssembly) & ", " 
    SQL = SQL & "    K1412_QtyPacking      =  " & FormatSQL(z1412.QtyPacking) & ", " 
    SQL = SQL & "    K1412_QtyInbound      =  " & FormatSQL(z1412.QtyInbound) & ", " 
    SQL = SQL & "    K1412_QtyShipping      =  " & FormatSQL(z1412.QtyShipping) & ", " 
    SQL = SQL & "    K1412_DateInsert      = N'" & FormatSQL(z1412.DateInsert) & "', " 
    SQL = SQL & "    K1412_InchargeInsert      = N'" & FormatSQL(z1412.InchargeInsert) & "', " 
    SQL = SQL & "    K1412_DateUpdate      = N'" & FormatSQL(z1412.DateUpdate) & "', " 
    SQL = SQL & "    K1412_InchargeUpdate      = N'" & FormatSQL(z1412.InchargeUpdate) & "', " 
    SQL = SQL & "    K1412_InchargeSales      = N'" & FormatSQL(z1412.InchargeSales) & "', " 
    SQL = SQL & "    K1412_InchargePPC      = N'" & FormatSQL(z1412.InchargePPC) & "', " 
    SQL = SQL & "    K1412_TotalQty      =  " & FormatSQL(z1412.TotalQty) & ", " 
    SQL = SQL & "    K1412_TotalAMT      =  " & FormatSQL(z1412.TotalAMT) & ", " 
    SQL = SQL & "    K1412_TotalCost      =  " & FormatSQL(z1412.TotalCost) & ", " 
    SQL = SQL & "    K1412_TotalProfit      =  " & FormatSQL(z1412.TotalProfit) & ", " 
    SQL = SQL & "    K1412_TotalAMTEX      =  " & FormatSQL(z1412.TotalAMTEX) & ", " 
    SQL = SQL & "    K1412_TotalAMTVND      =  " & FormatSQL(z1412.TotalAMTVND) & ", " 
    SQL = SQL & "    K1412_TotalCostEX      =  " & FormatSQL(z1412.TotalCostEX) & ", " 
    SQL = SQL & "    K1412_TotalCostVND      =  " & FormatSQL(z1412.TotalCostVND) & ", " 
    SQL = SQL & "    K1412_TotalProfitEX      =  " & FormatSQL(z1412.TotalProfitEX) & ", " 
    SQL = SQL & "    K1412_TotalProfitVND      =  " & FormatSQL(z1412.TotalProfitVND) & ", " 
    SQL = SQL & "    K1412_AttachID      = N'" & FormatSQL(z1412.AttachID) & "', " 
    SQL = SQL & "    K1412_OrderNoRef      = N'" & FormatSQL(z1412.OrderNoRef) & "', " 
    SQL = SQL & "    K1412_OrderNoSeqRef      = N'" & FormatSQL(z1412.OrderNoSeqRef) & "', " 
    SQL = SQL & "    K1412_Remark      = N'" & FormatSQL(z1412.Remark) & "', " 
    SQL = SQL & "    K1412_RemarkOrder      = N'" & FormatSQL(z1412.RemarkOrder) & "', " 
    SQL = SQL & "    K1412_RemarkCustomer      = N'" & FormatSQL(z1412.RemarkCustomer) & "', " 
    SQL = SQL & "    K1412_RemarkOther      = N'" & FormatSQL(z1412.RemarkOther) & "'  " 
    SQL = SQL & " WHERE K1412_OrderNo		 = '" & z1412.OrderNo & "' " 
    SQL = SQL & "   AND K1412_OrderNoSeq		 = '" & z1412.OrderNoSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK1412 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK1412",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK1412(z1412 As T1412_AREA) As Boolean
    DELETE_PFK1412 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK1412 "
    SQL = SQL & " WHERE K1412_OrderNo		 = '" & z1412.OrderNo & "' " 
    SQL = SQL & "   AND K1412_OrderNoSeq		 = '" & z1412.OrderNoSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK1412 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK1412",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D1412_CLEAR()
Try
    
   D1412.OrderNo = ""
   D1412.OrderNoSeq = ""
   D1412.ShoesCode = ""
   D1412.FacPO = ""
   D1412.SLNoSys = ""
   D1412.SLNo = ""
   D1412.PONO = ""
   D1412.CPONO = ""
   D1412.CustomerCode = ""
   D1412.CustomerName = ""
   D1412.Country = ""
   D1412.Destination = ""
   D1412.FinalShop = ""
   D1412.PKO = ""
   D1412.DatePO = ""
   D1412.JbCard = ""
   D1412.sePackingCode = ""
   D1412.cdPackingCode = ""
   D1412.seSpecStatus = ""
   D1412.cdSpecStatus = ""
   D1412.SizeRange = ""
   D1412.SpeciticSize = ""
   D1412.DateSize = ""
   D1412.OrderDetailStatus = ""
   D1412.DateOrder = ""
   D1412.DateApproval = ""
   D1412.DateCancel = ""
   D1412.DateComplete = ""
   D1412.DatePending = ""
   D1412.DatePending2 = ""
   D1412.DateExchangePrice = ""
    D1412.PriceExchange = 0 
    D1412.PriceOrder = 0 
   D1412.seUnitPrice = ""
   D1412.cdUnitPrice = ""
   D1412.UnitPrice = ""
    D1412.PriceOrderEX = 0 
    D1412.PriceOrderVND = 0 
   D1412.Datedelivery = ""
   D1412.DateTransfer = ""
   D1412.AcceptedOrder = ""
   D1412.MaterialStatus = ""
   D1412.SoleStatus = ""
   D1412.DateLable = ""
   D1412.DatePattern = ""
   D1412.DateMaterial = ""
   D1412.DatePlanning = ""
   D1412.DateRnD = ""
   D1412.DateFitting = ""
   D1412.InchargeFitting = ""
   D1412.CheckFitting = ""
   D1412.DateTesting = ""
   D1412.InchargeTesting = ""
   D1412.CheckTesting = ""
   D1412.CheckConfirm = ""
   D1412.DateConfirm = ""
   D1412.SpecNo = ""
   D1412.SpecNoSeq = ""
   D1412.DateSole = ""
   D1412.DateCutting = ""
   D1412.DateStitching = ""
   D1412.DateStockfit = ""
   D1412.DateAssmbly = ""
   D1412.DateShipping = ""
   D1412.seUnitMaterial = ""
   D1412.cdUnitMaterial = ""
   D1412.seUnitPacking = ""
   D1412.cdUnitPacking = ""
    D1412.QtyOrder = 0 
    D1412.QtyJob = 0 
    D1412.QtySole = 0 
    D1412.QtyCutting = 0 
    D1412.QtyStitching = 0 
    D1412.QtyStockfit = 0 
    D1412.QtyAssembly = 0 
    D1412.QtyPacking = 0 
    D1412.QtyInbound = 0 
    D1412.QtyShipping = 0 
   D1412.DateInsert = ""
   D1412.InchargeInsert = ""
   D1412.DateUpdate = ""
   D1412.InchargeUpdate = ""
   D1412.InchargeSales = ""
   D1412.InchargePPC = ""
    D1412.TotalQty = 0 
    D1412.TotalAMT = 0 
    D1412.TotalCost = 0 
    D1412.TotalProfit = 0 
    D1412.TotalAMTEX = 0 
    D1412.TotalAMTVND = 0 
    D1412.TotalCostEX = 0 
    D1412.TotalCostVND = 0 
    D1412.TotalProfitEX = 0 
    D1412.TotalProfitVND = 0 
   D1412.AttachID = ""
   D1412.OrderNoRef = ""
   D1412.OrderNoSeqRef = ""
   D1412.Remark = ""
   D1412.RemarkOrder = ""
   D1412.RemarkCustomer = ""
   D1412.RemarkOther = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D1412_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x1412 As T1412_AREA)
Try
    
    x1412.OrderNo = trim$(  x1412.OrderNo)
    x1412.OrderNoSeq = trim$(  x1412.OrderNoSeq)
    x1412.ShoesCode = trim$(  x1412.ShoesCode)
    x1412.FacPO = trim$(  x1412.FacPO)
    x1412.SLNoSys = trim$(  x1412.SLNoSys)
    x1412.SLNo = trim$(  x1412.SLNo)
    x1412.PONO = trim$(  x1412.PONO)
    x1412.CPONO = trim$(  x1412.CPONO)
    x1412.CustomerCode = trim$(  x1412.CustomerCode)
    x1412.CustomerName = trim$(  x1412.CustomerName)
    x1412.Country = trim$(  x1412.Country)
    x1412.Destination = trim$(  x1412.Destination)
    x1412.FinalShop = trim$(  x1412.FinalShop)
    x1412.PKO = trim$(  x1412.PKO)
    x1412.DatePO = trim$(  x1412.DatePO)
    x1412.JbCard = trim$(  x1412.JbCard)
    x1412.sePackingCode = trim$(  x1412.sePackingCode)
    x1412.cdPackingCode = trim$(  x1412.cdPackingCode)
    x1412.seSpecStatus = trim$(  x1412.seSpecStatus)
    x1412.cdSpecStatus = trim$(  x1412.cdSpecStatus)
    x1412.SizeRange = trim$(  x1412.SizeRange)
    x1412.SpeciticSize = trim$(  x1412.SpeciticSize)
    x1412.DateSize = trim$(  x1412.DateSize)
    x1412.OrderDetailStatus = trim$(  x1412.OrderDetailStatus)
    x1412.DateOrder = trim$(  x1412.DateOrder)
    x1412.DateApproval = trim$(  x1412.DateApproval)
    x1412.DateCancel = trim$(  x1412.DateCancel)
    x1412.DateComplete = trim$(  x1412.DateComplete)
    x1412.DatePending = trim$(  x1412.DatePending)
    x1412.DatePending2 = trim$(  x1412.DatePending2)
    x1412.DateExchangePrice = trim$(  x1412.DateExchangePrice)
    x1412.PriceExchange = trim$(  x1412.PriceExchange)
    x1412.PriceOrder = trim$(  x1412.PriceOrder)
    x1412.seUnitPrice = trim$(  x1412.seUnitPrice)
    x1412.cdUnitPrice = trim$(  x1412.cdUnitPrice)
    x1412.UnitPrice = trim$(  x1412.UnitPrice)
    x1412.PriceOrderEX = trim$(  x1412.PriceOrderEX)
    x1412.PriceOrderVND = trim$(  x1412.PriceOrderVND)
    x1412.Datedelivery = trim$(  x1412.Datedelivery)
    x1412.DateTransfer = trim$(  x1412.DateTransfer)
    x1412.AcceptedOrder = trim$(  x1412.AcceptedOrder)
    x1412.MaterialStatus = trim$(  x1412.MaterialStatus)
    x1412.SoleStatus = trim$(  x1412.SoleStatus)
    x1412.DateLable = trim$(  x1412.DateLable)
    x1412.DatePattern = trim$(  x1412.DatePattern)
    x1412.DateMaterial = trim$(  x1412.DateMaterial)
    x1412.DatePlanning = trim$(  x1412.DatePlanning)
    x1412.DateRnD = trim$(  x1412.DateRnD)
    x1412.DateFitting = trim$(  x1412.DateFitting)
    x1412.InchargeFitting = trim$(  x1412.InchargeFitting)
    x1412.CheckFitting = trim$(  x1412.CheckFitting)
    x1412.DateTesting = trim$(  x1412.DateTesting)
    x1412.InchargeTesting = trim$(  x1412.InchargeTesting)
    x1412.CheckTesting = trim$(  x1412.CheckTesting)
    x1412.CheckConfirm = trim$(  x1412.CheckConfirm)
    x1412.DateConfirm = trim$(  x1412.DateConfirm)
    x1412.SpecNo = trim$(  x1412.SpecNo)
    x1412.SpecNoSeq = trim$(  x1412.SpecNoSeq)
    x1412.DateSole = trim$(  x1412.DateSole)
    x1412.DateCutting = trim$(  x1412.DateCutting)
    x1412.DateStitching = trim$(  x1412.DateStitching)
    x1412.DateStockfit = trim$(  x1412.DateStockfit)
    x1412.DateAssmbly = trim$(  x1412.DateAssmbly)
    x1412.DateShipping = trim$(  x1412.DateShipping)
    x1412.seUnitMaterial = trim$(  x1412.seUnitMaterial)
    x1412.cdUnitMaterial = trim$(  x1412.cdUnitMaterial)
    x1412.seUnitPacking = trim$(  x1412.seUnitPacking)
    x1412.cdUnitPacking = trim$(  x1412.cdUnitPacking)
    x1412.QtyOrder = trim$(  x1412.QtyOrder)
    x1412.QtyJob = trim$(  x1412.QtyJob)
    x1412.QtySole = trim$(  x1412.QtySole)
    x1412.QtyCutting = trim$(  x1412.QtyCutting)
    x1412.QtyStitching = trim$(  x1412.QtyStitching)
    x1412.QtyStockfit = trim$(  x1412.QtyStockfit)
    x1412.QtyAssembly = trim$(  x1412.QtyAssembly)
    x1412.QtyPacking = trim$(  x1412.QtyPacking)
    x1412.QtyInbound = trim$(  x1412.QtyInbound)
    x1412.QtyShipping = trim$(  x1412.QtyShipping)
    x1412.DateInsert = trim$(  x1412.DateInsert)
    x1412.InchargeInsert = trim$(  x1412.InchargeInsert)
    x1412.DateUpdate = trim$(  x1412.DateUpdate)
    x1412.InchargeUpdate = trim$(  x1412.InchargeUpdate)
    x1412.InchargeSales = trim$(  x1412.InchargeSales)
    x1412.InchargePPC = trim$(  x1412.InchargePPC)
    x1412.TotalQty = trim$(  x1412.TotalQty)
    x1412.TotalAMT = trim$(  x1412.TotalAMT)
    x1412.TotalCost = trim$(  x1412.TotalCost)
    x1412.TotalProfit = trim$(  x1412.TotalProfit)
    x1412.TotalAMTEX = trim$(  x1412.TotalAMTEX)
    x1412.TotalAMTVND = trim$(  x1412.TotalAMTVND)
    x1412.TotalCostEX = trim$(  x1412.TotalCostEX)
    x1412.TotalCostVND = trim$(  x1412.TotalCostVND)
    x1412.TotalProfitEX = trim$(  x1412.TotalProfitEX)
    x1412.TotalProfitVND = trim$(  x1412.TotalProfitVND)
    x1412.AttachID = trim$(  x1412.AttachID)
    x1412.OrderNoRef = trim$(  x1412.OrderNoRef)
    x1412.OrderNoSeqRef = trim$(  x1412.OrderNoSeqRef)
    x1412.Remark = trim$(  x1412.Remark)
    x1412.RemarkOrder = trim$(  x1412.RemarkOrder)
    x1412.RemarkCustomer = trim$(  x1412.RemarkCustomer)
    x1412.RemarkOther = trim$(  x1412.RemarkOther)
     
    If trim$( x1412.OrderNo ) = "" Then x1412.OrderNo = Space(1) 
    If trim$( x1412.OrderNoSeq ) = "" Then x1412.OrderNoSeq = Space(1) 
    If trim$( x1412.ShoesCode ) = "" Then x1412.ShoesCode = Space(1) 
    If trim$( x1412.FacPO ) = "" Then x1412.FacPO = Space(1) 
    If trim$( x1412.SLNoSys ) = "" Then x1412.SLNoSys = Space(1) 
    If trim$( x1412.SLNo ) = "" Then x1412.SLNo = Space(1) 
    If trim$( x1412.PONO ) = "" Then x1412.PONO = Space(1) 
    If trim$( x1412.CPONO ) = "" Then x1412.CPONO = Space(1) 
    If trim$( x1412.CustomerCode ) = "" Then x1412.CustomerCode = Space(1) 
    If trim$( x1412.CustomerName ) = "" Then x1412.CustomerName = Space(1) 
    If trim$( x1412.Country ) = "" Then x1412.Country = Space(1) 
    If trim$( x1412.Destination ) = "" Then x1412.Destination = Space(1) 
    If trim$( x1412.FinalShop ) = "" Then x1412.FinalShop = Space(1) 
    If trim$( x1412.PKO ) = "" Then x1412.PKO = Space(1) 
    If trim$( x1412.DatePO ) = "" Then x1412.DatePO = Space(1) 
    If trim$( x1412.JbCard ) = "" Then x1412.JbCard = Space(1) 
    If trim$( x1412.sePackingCode ) = "" Then x1412.sePackingCode = Space(1) 
    If trim$( x1412.cdPackingCode ) = "" Then x1412.cdPackingCode = Space(1) 
    If trim$( x1412.seSpecStatus ) = "" Then x1412.seSpecStatus = Space(1) 
    If trim$( x1412.cdSpecStatus ) = "" Then x1412.cdSpecStatus = Space(1) 
    If trim$( x1412.SizeRange ) = "" Then x1412.SizeRange = Space(1) 
    If trim$( x1412.SpeciticSize ) = "" Then x1412.SpeciticSize = Space(1) 
    If trim$( x1412.DateSize ) = "" Then x1412.DateSize = Space(1) 
    If trim$( x1412.OrderDetailStatus ) = "" Then x1412.OrderDetailStatus = Space(1) 
    If trim$( x1412.DateOrder ) = "" Then x1412.DateOrder = Space(1) 
    If trim$( x1412.DateApproval ) = "" Then x1412.DateApproval = Space(1) 
    If trim$( x1412.DateCancel ) = "" Then x1412.DateCancel = Space(1) 
    If trim$( x1412.DateComplete ) = "" Then x1412.DateComplete = Space(1) 
    If trim$( x1412.DatePending ) = "" Then x1412.DatePending = Space(1) 
    If trim$( x1412.DatePending2 ) = "" Then x1412.DatePending2 = Space(1) 
    If trim$( x1412.DateExchangePrice ) = "" Then x1412.DateExchangePrice = Space(1) 
    If trim$( x1412.PriceExchange ) = "" Then x1412.PriceExchange = 0 
    If trim$( x1412.PriceOrder ) = "" Then x1412.PriceOrder = 0 
    If trim$( x1412.seUnitPrice ) = "" Then x1412.seUnitPrice = Space(1) 
    If trim$( x1412.cdUnitPrice ) = "" Then x1412.cdUnitPrice = Space(1) 
    If trim$( x1412.UnitPrice ) = "" Then x1412.UnitPrice = Space(1) 
    If trim$( x1412.PriceOrderEX ) = "" Then x1412.PriceOrderEX = 0 
    If trim$( x1412.PriceOrderVND ) = "" Then x1412.PriceOrderVND = 0 
    If trim$( x1412.Datedelivery ) = "" Then x1412.Datedelivery = Space(1) 
    If trim$( x1412.DateTransfer ) = "" Then x1412.DateTransfer = Space(1) 
    If trim$( x1412.AcceptedOrder ) = "" Then x1412.AcceptedOrder = Space(1) 
    If trim$( x1412.MaterialStatus ) = "" Then x1412.MaterialStatus = Space(1) 
    If trim$( x1412.SoleStatus ) = "" Then x1412.SoleStatus = Space(1) 
    If trim$( x1412.DateLable ) = "" Then x1412.DateLable = Space(1) 
    If trim$( x1412.DatePattern ) = "" Then x1412.DatePattern = Space(1) 
    If trim$( x1412.DateMaterial ) = "" Then x1412.DateMaterial = Space(1) 
    If trim$( x1412.DatePlanning ) = "" Then x1412.DatePlanning = Space(1) 
    If trim$( x1412.DateRnD ) = "" Then x1412.DateRnD = Space(1) 
    If trim$( x1412.DateFitting ) = "" Then x1412.DateFitting = Space(1) 
    If trim$( x1412.InchargeFitting ) = "" Then x1412.InchargeFitting = Space(1) 
    If trim$( x1412.CheckFitting ) = "" Then x1412.CheckFitting = Space(1) 
    If trim$( x1412.DateTesting ) = "" Then x1412.DateTesting = Space(1) 
    If trim$( x1412.InchargeTesting ) = "" Then x1412.InchargeTesting = Space(1) 
    If trim$( x1412.CheckTesting ) = "" Then x1412.CheckTesting = Space(1) 
    If trim$( x1412.CheckConfirm ) = "" Then x1412.CheckConfirm = Space(1) 
    If trim$( x1412.DateConfirm ) = "" Then x1412.DateConfirm = Space(1) 
    If trim$( x1412.SpecNo ) = "" Then x1412.SpecNo = Space(1) 
    If trim$( x1412.SpecNoSeq ) = "" Then x1412.SpecNoSeq = Space(1) 
    If trim$( x1412.DateSole ) = "" Then x1412.DateSole = Space(1) 
    If trim$( x1412.DateCutting ) = "" Then x1412.DateCutting = Space(1) 
    If trim$( x1412.DateStitching ) = "" Then x1412.DateStitching = Space(1) 
    If trim$( x1412.DateStockfit ) = "" Then x1412.DateStockfit = Space(1) 
    If trim$( x1412.DateAssmbly ) = "" Then x1412.DateAssmbly = Space(1) 
    If trim$( x1412.DateShipping ) = "" Then x1412.DateShipping = Space(1) 
    If trim$( x1412.seUnitMaterial ) = "" Then x1412.seUnitMaterial = Space(1) 
    If trim$( x1412.cdUnitMaterial ) = "" Then x1412.cdUnitMaterial = Space(1) 
    If trim$( x1412.seUnitPacking ) = "" Then x1412.seUnitPacking = Space(1) 
    If trim$( x1412.cdUnitPacking ) = "" Then x1412.cdUnitPacking = Space(1) 
    If trim$( x1412.QtyOrder ) = "" Then x1412.QtyOrder = 0 
    If trim$( x1412.QtyJob ) = "" Then x1412.QtyJob = 0 
    If trim$( x1412.QtySole ) = "" Then x1412.QtySole = 0 
    If trim$( x1412.QtyCutting ) = "" Then x1412.QtyCutting = 0 
    If trim$( x1412.QtyStitching ) = "" Then x1412.QtyStitching = 0 
    If trim$( x1412.QtyStockfit ) = "" Then x1412.QtyStockfit = 0 
    If trim$( x1412.QtyAssembly ) = "" Then x1412.QtyAssembly = 0 
    If trim$( x1412.QtyPacking ) = "" Then x1412.QtyPacking = 0 
    If trim$( x1412.QtyInbound ) = "" Then x1412.QtyInbound = 0 
    If trim$( x1412.QtyShipping ) = "" Then x1412.QtyShipping = 0 
    If trim$( x1412.DateInsert ) = "" Then x1412.DateInsert = Space(1) 
    If trim$( x1412.InchargeInsert ) = "" Then x1412.InchargeInsert = Space(1) 
    If trim$( x1412.DateUpdate ) = "" Then x1412.DateUpdate = Space(1) 
    If trim$( x1412.InchargeUpdate ) = "" Then x1412.InchargeUpdate = Space(1) 
    If trim$( x1412.InchargeSales ) = "" Then x1412.InchargeSales = Space(1) 
    If trim$( x1412.InchargePPC ) = "" Then x1412.InchargePPC = Space(1) 
    If trim$( x1412.TotalQty ) = "" Then x1412.TotalQty = 0 
    If trim$( x1412.TotalAMT ) = "" Then x1412.TotalAMT = 0 
    If trim$( x1412.TotalCost ) = "" Then x1412.TotalCost = 0 
    If trim$( x1412.TotalProfit ) = "" Then x1412.TotalProfit = 0 
    If trim$( x1412.TotalAMTEX ) = "" Then x1412.TotalAMTEX = 0 
    If trim$( x1412.TotalAMTVND ) = "" Then x1412.TotalAMTVND = 0 
    If trim$( x1412.TotalCostEX ) = "" Then x1412.TotalCostEX = 0 
    If trim$( x1412.TotalCostVND ) = "" Then x1412.TotalCostVND = 0 
    If trim$( x1412.TotalProfitEX ) = "" Then x1412.TotalProfitEX = 0 
    If trim$( x1412.TotalProfitVND ) = "" Then x1412.TotalProfitVND = 0 
    If trim$( x1412.AttachID ) = "" Then x1412.AttachID = Space(1) 
    If trim$( x1412.OrderNoRef ) = "" Then x1412.OrderNoRef = Space(1) 
    If trim$( x1412.OrderNoSeqRef ) = "" Then x1412.OrderNoSeqRef = Space(1) 
    If trim$( x1412.Remark ) = "" Then x1412.Remark = Space(1) 
    If trim$( x1412.RemarkOrder ) = "" Then x1412.RemarkOrder = Space(1) 
    If trim$( x1412.RemarkCustomer ) = "" Then x1412.RemarkCustomer = Space(1) 
    If trim$( x1412.RemarkOther ) = "" Then x1412.RemarkOther = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K1412_MOVE(rs1412 As SqlClient.SqlDataReader)
Try

    call D1412_CLEAR()   

    If IsdbNull(rs1412!K1412_OrderNo) = False Then D1412.OrderNo = Trim$(rs1412!K1412_OrderNo)
    If IsdbNull(rs1412!K1412_OrderNoSeq) = False Then D1412.OrderNoSeq = Trim$(rs1412!K1412_OrderNoSeq)
    If IsdbNull(rs1412!K1412_ShoesCode) = False Then D1412.ShoesCode = Trim$(rs1412!K1412_ShoesCode)
    If IsdbNull(rs1412!K1412_FacPO) = False Then D1412.FacPO = Trim$(rs1412!K1412_FacPO)
    If IsdbNull(rs1412!K1412_SLNoSys) = False Then D1412.SLNoSys = Trim$(rs1412!K1412_SLNoSys)
    If IsdbNull(rs1412!K1412_SLNo) = False Then D1412.SLNo = Trim$(rs1412!K1412_SLNo)
    If IsdbNull(rs1412!K1412_PONO) = False Then D1412.PONO = Trim$(rs1412!K1412_PONO)
    If IsdbNull(rs1412!K1412_CPONO) = False Then D1412.CPONO = Trim$(rs1412!K1412_CPONO)
    If IsdbNull(rs1412!K1412_CustomerCode) = False Then D1412.CustomerCode = Trim$(rs1412!K1412_CustomerCode)
    If IsdbNull(rs1412!K1412_CustomerName) = False Then D1412.CustomerName = Trim$(rs1412!K1412_CustomerName)
    If IsdbNull(rs1412!K1412_Country) = False Then D1412.Country = Trim$(rs1412!K1412_Country)
    If IsdbNull(rs1412!K1412_Destination) = False Then D1412.Destination = Trim$(rs1412!K1412_Destination)
    If IsdbNull(rs1412!K1412_FinalShop) = False Then D1412.FinalShop = Trim$(rs1412!K1412_FinalShop)
    If IsdbNull(rs1412!K1412_PKO) = False Then D1412.PKO = Trim$(rs1412!K1412_PKO)
    If IsdbNull(rs1412!K1412_DatePO) = False Then D1412.DatePO = Trim$(rs1412!K1412_DatePO)
    If IsdbNull(rs1412!K1412_JbCard) = False Then D1412.JbCard = Trim$(rs1412!K1412_JbCard)
    If IsdbNull(rs1412!K1412_sePackingCode) = False Then D1412.sePackingCode = Trim$(rs1412!K1412_sePackingCode)
    If IsdbNull(rs1412!K1412_cdPackingCode) = False Then D1412.cdPackingCode = Trim$(rs1412!K1412_cdPackingCode)
    If IsdbNull(rs1412!K1412_seSpecStatus) = False Then D1412.seSpecStatus = Trim$(rs1412!K1412_seSpecStatus)
    If IsdbNull(rs1412!K1412_cdSpecStatus) = False Then D1412.cdSpecStatus = Trim$(rs1412!K1412_cdSpecStatus)
    If IsdbNull(rs1412!K1412_SizeRange) = False Then D1412.SizeRange = Trim$(rs1412!K1412_SizeRange)
    If IsdbNull(rs1412!K1412_SpeciticSize) = False Then D1412.SpeciticSize = Trim$(rs1412!K1412_SpeciticSize)
    If IsdbNull(rs1412!K1412_DateSize) = False Then D1412.DateSize = Trim$(rs1412!K1412_DateSize)
    If IsdbNull(rs1412!K1412_OrderDetailStatus) = False Then D1412.OrderDetailStatus = Trim$(rs1412!K1412_OrderDetailStatus)
    If IsdbNull(rs1412!K1412_DateOrder) = False Then D1412.DateOrder = Trim$(rs1412!K1412_DateOrder)
    If IsdbNull(rs1412!K1412_DateApproval) = False Then D1412.DateApproval = Trim$(rs1412!K1412_DateApproval)
    If IsdbNull(rs1412!K1412_DateCancel) = False Then D1412.DateCancel = Trim$(rs1412!K1412_DateCancel)
    If IsdbNull(rs1412!K1412_DateComplete) = False Then D1412.DateComplete = Trim$(rs1412!K1412_DateComplete)
    If IsdbNull(rs1412!K1412_DatePending) = False Then D1412.DatePending = Trim$(rs1412!K1412_DatePending)
    If IsdbNull(rs1412!K1412_DatePending2) = False Then D1412.DatePending2 = Trim$(rs1412!K1412_DatePending2)
    If IsdbNull(rs1412!K1412_DateExchangePrice) = False Then D1412.DateExchangePrice = Trim$(rs1412!K1412_DateExchangePrice)
    If IsdbNull(rs1412!K1412_PriceExchange) = False Then D1412.PriceExchange = Trim$(rs1412!K1412_PriceExchange)
    If IsdbNull(rs1412!K1412_PriceOrder) = False Then D1412.PriceOrder = Trim$(rs1412!K1412_PriceOrder)
    If IsdbNull(rs1412!K1412_seUnitPrice) = False Then D1412.seUnitPrice = Trim$(rs1412!K1412_seUnitPrice)
    If IsdbNull(rs1412!K1412_cdUnitPrice) = False Then D1412.cdUnitPrice = Trim$(rs1412!K1412_cdUnitPrice)
    If IsdbNull(rs1412!K1412_UnitPrice) = False Then D1412.UnitPrice = Trim$(rs1412!K1412_UnitPrice)
    If IsdbNull(rs1412!K1412_PriceOrderEX) = False Then D1412.PriceOrderEX = Trim$(rs1412!K1412_PriceOrderEX)
    If IsdbNull(rs1412!K1412_PriceOrderVND) = False Then D1412.PriceOrderVND = Trim$(rs1412!K1412_PriceOrderVND)
    If IsdbNull(rs1412!K1412_Datedelivery) = False Then D1412.Datedelivery = Trim$(rs1412!K1412_Datedelivery)
    If IsdbNull(rs1412!K1412_DateTransfer) = False Then D1412.DateTransfer = Trim$(rs1412!K1412_DateTransfer)
    If IsdbNull(rs1412!K1412_AcceptedOrder) = False Then D1412.AcceptedOrder = Trim$(rs1412!K1412_AcceptedOrder)
    If IsdbNull(rs1412!K1412_MaterialStatus) = False Then D1412.MaterialStatus = Trim$(rs1412!K1412_MaterialStatus)
    If IsdbNull(rs1412!K1412_SoleStatus) = False Then D1412.SoleStatus = Trim$(rs1412!K1412_SoleStatus)
    If IsdbNull(rs1412!K1412_DateLable) = False Then D1412.DateLable = Trim$(rs1412!K1412_DateLable)
    If IsdbNull(rs1412!K1412_DatePattern) = False Then D1412.DatePattern = Trim$(rs1412!K1412_DatePattern)
    If IsdbNull(rs1412!K1412_DateMaterial) = False Then D1412.DateMaterial = Trim$(rs1412!K1412_DateMaterial)
    If IsdbNull(rs1412!K1412_DatePlanning) = False Then D1412.DatePlanning = Trim$(rs1412!K1412_DatePlanning)
    If IsdbNull(rs1412!K1412_DateRnD) = False Then D1412.DateRnD = Trim$(rs1412!K1412_DateRnD)
    If IsdbNull(rs1412!K1412_DateFitting) = False Then D1412.DateFitting = Trim$(rs1412!K1412_DateFitting)
    If IsdbNull(rs1412!K1412_InchargeFitting) = False Then D1412.InchargeFitting = Trim$(rs1412!K1412_InchargeFitting)
    If IsdbNull(rs1412!K1412_CheckFitting) = False Then D1412.CheckFitting = Trim$(rs1412!K1412_CheckFitting)
    If IsdbNull(rs1412!K1412_DateTesting) = False Then D1412.DateTesting = Trim$(rs1412!K1412_DateTesting)
    If IsdbNull(rs1412!K1412_InchargeTesting) = False Then D1412.InchargeTesting = Trim$(rs1412!K1412_InchargeTesting)
    If IsdbNull(rs1412!K1412_CheckTesting) = False Then D1412.CheckTesting = Trim$(rs1412!K1412_CheckTesting)
    If IsdbNull(rs1412!K1412_CheckConfirm) = False Then D1412.CheckConfirm = Trim$(rs1412!K1412_CheckConfirm)
    If IsdbNull(rs1412!K1412_DateConfirm) = False Then D1412.DateConfirm = Trim$(rs1412!K1412_DateConfirm)
    If IsdbNull(rs1412!K1412_SpecNo) = False Then D1412.SpecNo = Trim$(rs1412!K1412_SpecNo)
    If IsdbNull(rs1412!K1412_SpecNoSeq) = False Then D1412.SpecNoSeq = Trim$(rs1412!K1412_SpecNoSeq)
    If IsdbNull(rs1412!K1412_DateSole) = False Then D1412.DateSole = Trim$(rs1412!K1412_DateSole)
    If IsdbNull(rs1412!K1412_DateCutting) = False Then D1412.DateCutting = Trim$(rs1412!K1412_DateCutting)
    If IsdbNull(rs1412!K1412_DateStitching) = False Then D1412.DateStitching = Trim$(rs1412!K1412_DateStitching)
    If IsdbNull(rs1412!K1412_DateStockfit) = False Then D1412.DateStockfit = Trim$(rs1412!K1412_DateStockfit)
    If IsdbNull(rs1412!K1412_DateAssmbly) = False Then D1412.DateAssmbly = Trim$(rs1412!K1412_DateAssmbly)
    If IsdbNull(rs1412!K1412_DateShipping) = False Then D1412.DateShipping = Trim$(rs1412!K1412_DateShipping)
    If IsdbNull(rs1412!K1412_seUnitMaterial) = False Then D1412.seUnitMaterial = Trim$(rs1412!K1412_seUnitMaterial)
    If IsdbNull(rs1412!K1412_cdUnitMaterial) = False Then D1412.cdUnitMaterial = Trim$(rs1412!K1412_cdUnitMaterial)
    If IsdbNull(rs1412!K1412_seUnitPacking) = False Then D1412.seUnitPacking = Trim$(rs1412!K1412_seUnitPacking)
    If IsdbNull(rs1412!K1412_cdUnitPacking) = False Then D1412.cdUnitPacking = Trim$(rs1412!K1412_cdUnitPacking)
    If IsdbNull(rs1412!K1412_QtyOrder) = False Then D1412.QtyOrder = Trim$(rs1412!K1412_QtyOrder)
    If IsdbNull(rs1412!K1412_QtyJob) = False Then D1412.QtyJob = Trim$(rs1412!K1412_QtyJob)
    If IsdbNull(rs1412!K1412_QtySole) = False Then D1412.QtySole = Trim$(rs1412!K1412_QtySole)
    If IsdbNull(rs1412!K1412_QtyCutting) = False Then D1412.QtyCutting = Trim$(rs1412!K1412_QtyCutting)
    If IsdbNull(rs1412!K1412_QtyStitching) = False Then D1412.QtyStitching = Trim$(rs1412!K1412_QtyStitching)
    If IsdbNull(rs1412!K1412_QtyStockfit) = False Then D1412.QtyStockfit = Trim$(rs1412!K1412_QtyStockfit)
    If IsdbNull(rs1412!K1412_QtyAssembly) = False Then D1412.QtyAssembly = Trim$(rs1412!K1412_QtyAssembly)
    If IsdbNull(rs1412!K1412_QtyPacking) = False Then D1412.QtyPacking = Trim$(rs1412!K1412_QtyPacking)
    If IsdbNull(rs1412!K1412_QtyInbound) = False Then D1412.QtyInbound = Trim$(rs1412!K1412_QtyInbound)
    If IsdbNull(rs1412!K1412_QtyShipping) = False Then D1412.QtyShipping = Trim$(rs1412!K1412_QtyShipping)
    If IsdbNull(rs1412!K1412_DateInsert) = False Then D1412.DateInsert = Trim$(rs1412!K1412_DateInsert)
    If IsdbNull(rs1412!K1412_InchargeInsert) = False Then D1412.InchargeInsert = Trim$(rs1412!K1412_InchargeInsert)
    If IsdbNull(rs1412!K1412_DateUpdate) = False Then D1412.DateUpdate = Trim$(rs1412!K1412_DateUpdate)
    If IsdbNull(rs1412!K1412_InchargeUpdate) = False Then D1412.InchargeUpdate = Trim$(rs1412!K1412_InchargeUpdate)
    If IsdbNull(rs1412!K1412_InchargeSales) = False Then D1412.InchargeSales = Trim$(rs1412!K1412_InchargeSales)
    If IsdbNull(rs1412!K1412_InchargePPC) = False Then D1412.InchargePPC = Trim$(rs1412!K1412_InchargePPC)
    If IsdbNull(rs1412!K1412_TotalQty) = False Then D1412.TotalQty = Trim$(rs1412!K1412_TotalQty)
    If IsdbNull(rs1412!K1412_TotalAMT) = False Then D1412.TotalAMT = Trim$(rs1412!K1412_TotalAMT)
    If IsdbNull(rs1412!K1412_TotalCost) = False Then D1412.TotalCost = Trim$(rs1412!K1412_TotalCost)
    If IsdbNull(rs1412!K1412_TotalProfit) = False Then D1412.TotalProfit = Trim$(rs1412!K1412_TotalProfit)
    If IsdbNull(rs1412!K1412_TotalAMTEX) = False Then D1412.TotalAMTEX = Trim$(rs1412!K1412_TotalAMTEX)
    If IsdbNull(rs1412!K1412_TotalAMTVND) = False Then D1412.TotalAMTVND = Trim$(rs1412!K1412_TotalAMTVND)
    If IsdbNull(rs1412!K1412_TotalCostEX) = False Then D1412.TotalCostEX = Trim$(rs1412!K1412_TotalCostEX)
    If IsdbNull(rs1412!K1412_TotalCostVND) = False Then D1412.TotalCostVND = Trim$(rs1412!K1412_TotalCostVND)
    If IsdbNull(rs1412!K1412_TotalProfitEX) = False Then D1412.TotalProfitEX = Trim$(rs1412!K1412_TotalProfitEX)
    If IsdbNull(rs1412!K1412_TotalProfitVND) = False Then D1412.TotalProfitVND = Trim$(rs1412!K1412_TotalProfitVND)
    If IsdbNull(rs1412!K1412_AttachID) = False Then D1412.AttachID = Trim$(rs1412!K1412_AttachID)
    If IsdbNull(rs1412!K1412_OrderNoRef) = False Then D1412.OrderNoRef = Trim$(rs1412!K1412_OrderNoRef)
    If IsdbNull(rs1412!K1412_OrderNoSeqRef) = False Then D1412.OrderNoSeqRef = Trim$(rs1412!K1412_OrderNoSeqRef)
    If IsdbNull(rs1412!K1412_Remark) = False Then D1412.Remark = Trim$(rs1412!K1412_Remark)
    If IsdbNull(rs1412!K1412_RemarkOrder) = False Then D1412.RemarkOrder = Trim$(rs1412!K1412_RemarkOrder)
    If IsdbNull(rs1412!K1412_RemarkCustomer) = False Then D1412.RemarkCustomer = Trim$(rs1412!K1412_RemarkCustomer)
    If IsdbNull(rs1412!K1412_RemarkOther) = False Then D1412.RemarkOther = Trim$(rs1412!K1412_RemarkOther)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K1412_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K1412_MOVE(rs1412 As DataRow)
Try

    call D1412_CLEAR()   

    If IsdbNull(rs1412!K1412_OrderNo) = False Then D1412.OrderNo = Trim$(rs1412!K1412_OrderNo)
    If IsdbNull(rs1412!K1412_OrderNoSeq) = False Then D1412.OrderNoSeq = Trim$(rs1412!K1412_OrderNoSeq)
    If IsdbNull(rs1412!K1412_ShoesCode) = False Then D1412.ShoesCode = Trim$(rs1412!K1412_ShoesCode)
    If IsdbNull(rs1412!K1412_FacPO) = False Then D1412.FacPO = Trim$(rs1412!K1412_FacPO)
    If IsdbNull(rs1412!K1412_SLNoSys) = False Then D1412.SLNoSys = Trim$(rs1412!K1412_SLNoSys)
    If IsdbNull(rs1412!K1412_SLNo) = False Then D1412.SLNo = Trim$(rs1412!K1412_SLNo)
    If IsdbNull(rs1412!K1412_PONO) = False Then D1412.PONO = Trim$(rs1412!K1412_PONO)
    If IsdbNull(rs1412!K1412_CPONO) = False Then D1412.CPONO = Trim$(rs1412!K1412_CPONO)
    If IsdbNull(rs1412!K1412_CustomerCode) = False Then D1412.CustomerCode = Trim$(rs1412!K1412_CustomerCode)
    If IsdbNull(rs1412!K1412_CustomerName) = False Then D1412.CustomerName = Trim$(rs1412!K1412_CustomerName)
    If IsdbNull(rs1412!K1412_Country) = False Then D1412.Country = Trim$(rs1412!K1412_Country)
    If IsdbNull(rs1412!K1412_Destination) = False Then D1412.Destination = Trim$(rs1412!K1412_Destination)
    If IsdbNull(rs1412!K1412_FinalShop) = False Then D1412.FinalShop = Trim$(rs1412!K1412_FinalShop)
    If IsdbNull(rs1412!K1412_PKO) = False Then D1412.PKO = Trim$(rs1412!K1412_PKO)
    If IsdbNull(rs1412!K1412_DatePO) = False Then D1412.DatePO = Trim$(rs1412!K1412_DatePO)
    If IsdbNull(rs1412!K1412_JbCard) = False Then D1412.JbCard = Trim$(rs1412!K1412_JbCard)
    If IsdbNull(rs1412!K1412_sePackingCode) = False Then D1412.sePackingCode = Trim$(rs1412!K1412_sePackingCode)
    If IsdbNull(rs1412!K1412_cdPackingCode) = False Then D1412.cdPackingCode = Trim$(rs1412!K1412_cdPackingCode)
    If IsdbNull(rs1412!K1412_seSpecStatus) = False Then D1412.seSpecStatus = Trim$(rs1412!K1412_seSpecStatus)
    If IsdbNull(rs1412!K1412_cdSpecStatus) = False Then D1412.cdSpecStatus = Trim$(rs1412!K1412_cdSpecStatus)
    If IsdbNull(rs1412!K1412_SizeRange) = False Then D1412.SizeRange = Trim$(rs1412!K1412_SizeRange)
    If IsdbNull(rs1412!K1412_SpeciticSize) = False Then D1412.SpeciticSize = Trim$(rs1412!K1412_SpeciticSize)
    If IsdbNull(rs1412!K1412_DateSize) = False Then D1412.DateSize = Trim$(rs1412!K1412_DateSize)
    If IsdbNull(rs1412!K1412_OrderDetailStatus) = False Then D1412.OrderDetailStatus = Trim$(rs1412!K1412_OrderDetailStatus)
    If IsdbNull(rs1412!K1412_DateOrder) = False Then D1412.DateOrder = Trim$(rs1412!K1412_DateOrder)
    If IsdbNull(rs1412!K1412_DateApproval) = False Then D1412.DateApproval = Trim$(rs1412!K1412_DateApproval)
    If IsdbNull(rs1412!K1412_DateCancel) = False Then D1412.DateCancel = Trim$(rs1412!K1412_DateCancel)
    If IsdbNull(rs1412!K1412_DateComplete) = False Then D1412.DateComplete = Trim$(rs1412!K1412_DateComplete)
    If IsdbNull(rs1412!K1412_DatePending) = False Then D1412.DatePending = Trim$(rs1412!K1412_DatePending)
    If IsdbNull(rs1412!K1412_DatePending2) = False Then D1412.DatePending2 = Trim$(rs1412!K1412_DatePending2)
    If IsdbNull(rs1412!K1412_DateExchangePrice) = False Then D1412.DateExchangePrice = Trim$(rs1412!K1412_DateExchangePrice)
    If IsdbNull(rs1412!K1412_PriceExchange) = False Then D1412.PriceExchange = Trim$(rs1412!K1412_PriceExchange)
    If IsdbNull(rs1412!K1412_PriceOrder) = False Then D1412.PriceOrder = Trim$(rs1412!K1412_PriceOrder)
    If IsdbNull(rs1412!K1412_seUnitPrice) = False Then D1412.seUnitPrice = Trim$(rs1412!K1412_seUnitPrice)
    If IsdbNull(rs1412!K1412_cdUnitPrice) = False Then D1412.cdUnitPrice = Trim$(rs1412!K1412_cdUnitPrice)
    If IsdbNull(rs1412!K1412_UnitPrice) = False Then D1412.UnitPrice = Trim$(rs1412!K1412_UnitPrice)
    If IsdbNull(rs1412!K1412_PriceOrderEX) = False Then D1412.PriceOrderEX = Trim$(rs1412!K1412_PriceOrderEX)
    If IsdbNull(rs1412!K1412_PriceOrderVND) = False Then D1412.PriceOrderVND = Trim$(rs1412!K1412_PriceOrderVND)
    If IsdbNull(rs1412!K1412_Datedelivery) = False Then D1412.Datedelivery = Trim$(rs1412!K1412_Datedelivery)
    If IsdbNull(rs1412!K1412_DateTransfer) = False Then D1412.DateTransfer = Trim$(rs1412!K1412_DateTransfer)
    If IsdbNull(rs1412!K1412_AcceptedOrder) = False Then D1412.AcceptedOrder = Trim$(rs1412!K1412_AcceptedOrder)
    If IsdbNull(rs1412!K1412_MaterialStatus) = False Then D1412.MaterialStatus = Trim$(rs1412!K1412_MaterialStatus)
    If IsdbNull(rs1412!K1412_SoleStatus) = False Then D1412.SoleStatus = Trim$(rs1412!K1412_SoleStatus)
    If IsdbNull(rs1412!K1412_DateLable) = False Then D1412.DateLable = Trim$(rs1412!K1412_DateLable)
    If IsdbNull(rs1412!K1412_DatePattern) = False Then D1412.DatePattern = Trim$(rs1412!K1412_DatePattern)
    If IsdbNull(rs1412!K1412_DateMaterial) = False Then D1412.DateMaterial = Trim$(rs1412!K1412_DateMaterial)
    If IsdbNull(rs1412!K1412_DatePlanning) = False Then D1412.DatePlanning = Trim$(rs1412!K1412_DatePlanning)
    If IsdbNull(rs1412!K1412_DateRnD) = False Then D1412.DateRnD = Trim$(rs1412!K1412_DateRnD)
    If IsdbNull(rs1412!K1412_DateFitting) = False Then D1412.DateFitting = Trim$(rs1412!K1412_DateFitting)
    If IsdbNull(rs1412!K1412_InchargeFitting) = False Then D1412.InchargeFitting = Trim$(rs1412!K1412_InchargeFitting)
    If IsdbNull(rs1412!K1412_CheckFitting) = False Then D1412.CheckFitting = Trim$(rs1412!K1412_CheckFitting)
    If IsdbNull(rs1412!K1412_DateTesting) = False Then D1412.DateTesting = Trim$(rs1412!K1412_DateTesting)
    If IsdbNull(rs1412!K1412_InchargeTesting) = False Then D1412.InchargeTesting = Trim$(rs1412!K1412_InchargeTesting)
    If IsdbNull(rs1412!K1412_CheckTesting) = False Then D1412.CheckTesting = Trim$(rs1412!K1412_CheckTesting)
    If IsdbNull(rs1412!K1412_CheckConfirm) = False Then D1412.CheckConfirm = Trim$(rs1412!K1412_CheckConfirm)
    If IsdbNull(rs1412!K1412_DateConfirm) = False Then D1412.DateConfirm = Trim$(rs1412!K1412_DateConfirm)
    If IsdbNull(rs1412!K1412_SpecNo) = False Then D1412.SpecNo = Trim$(rs1412!K1412_SpecNo)
    If IsdbNull(rs1412!K1412_SpecNoSeq) = False Then D1412.SpecNoSeq = Trim$(rs1412!K1412_SpecNoSeq)
    If IsdbNull(rs1412!K1412_DateSole) = False Then D1412.DateSole = Trim$(rs1412!K1412_DateSole)
    If IsdbNull(rs1412!K1412_DateCutting) = False Then D1412.DateCutting = Trim$(rs1412!K1412_DateCutting)
    If IsdbNull(rs1412!K1412_DateStitching) = False Then D1412.DateStitching = Trim$(rs1412!K1412_DateStitching)
    If IsdbNull(rs1412!K1412_DateStockfit) = False Then D1412.DateStockfit = Trim$(rs1412!K1412_DateStockfit)
    If IsdbNull(rs1412!K1412_DateAssmbly) = False Then D1412.DateAssmbly = Trim$(rs1412!K1412_DateAssmbly)
    If IsdbNull(rs1412!K1412_DateShipping) = False Then D1412.DateShipping = Trim$(rs1412!K1412_DateShipping)
    If IsdbNull(rs1412!K1412_seUnitMaterial) = False Then D1412.seUnitMaterial = Trim$(rs1412!K1412_seUnitMaterial)
    If IsdbNull(rs1412!K1412_cdUnitMaterial) = False Then D1412.cdUnitMaterial = Trim$(rs1412!K1412_cdUnitMaterial)
    If IsdbNull(rs1412!K1412_seUnitPacking) = False Then D1412.seUnitPacking = Trim$(rs1412!K1412_seUnitPacking)
    If IsdbNull(rs1412!K1412_cdUnitPacking) = False Then D1412.cdUnitPacking = Trim$(rs1412!K1412_cdUnitPacking)
    If IsdbNull(rs1412!K1412_QtyOrder) = False Then D1412.QtyOrder = Trim$(rs1412!K1412_QtyOrder)
    If IsdbNull(rs1412!K1412_QtyJob) = False Then D1412.QtyJob = Trim$(rs1412!K1412_QtyJob)
    If IsdbNull(rs1412!K1412_QtySole) = False Then D1412.QtySole = Trim$(rs1412!K1412_QtySole)
    If IsdbNull(rs1412!K1412_QtyCutting) = False Then D1412.QtyCutting = Trim$(rs1412!K1412_QtyCutting)
    If IsdbNull(rs1412!K1412_QtyStitching) = False Then D1412.QtyStitching = Trim$(rs1412!K1412_QtyStitching)
    If IsdbNull(rs1412!K1412_QtyStockfit) = False Then D1412.QtyStockfit = Trim$(rs1412!K1412_QtyStockfit)
    If IsdbNull(rs1412!K1412_QtyAssembly) = False Then D1412.QtyAssembly = Trim$(rs1412!K1412_QtyAssembly)
    If IsdbNull(rs1412!K1412_QtyPacking) = False Then D1412.QtyPacking = Trim$(rs1412!K1412_QtyPacking)
    If IsdbNull(rs1412!K1412_QtyInbound) = False Then D1412.QtyInbound = Trim$(rs1412!K1412_QtyInbound)
    If IsdbNull(rs1412!K1412_QtyShipping) = False Then D1412.QtyShipping = Trim$(rs1412!K1412_QtyShipping)
    If IsdbNull(rs1412!K1412_DateInsert) = False Then D1412.DateInsert = Trim$(rs1412!K1412_DateInsert)
    If IsdbNull(rs1412!K1412_InchargeInsert) = False Then D1412.InchargeInsert = Trim$(rs1412!K1412_InchargeInsert)
    If IsdbNull(rs1412!K1412_DateUpdate) = False Then D1412.DateUpdate = Trim$(rs1412!K1412_DateUpdate)
    If IsdbNull(rs1412!K1412_InchargeUpdate) = False Then D1412.InchargeUpdate = Trim$(rs1412!K1412_InchargeUpdate)
    If IsdbNull(rs1412!K1412_InchargeSales) = False Then D1412.InchargeSales = Trim$(rs1412!K1412_InchargeSales)
    If IsdbNull(rs1412!K1412_InchargePPC) = False Then D1412.InchargePPC = Trim$(rs1412!K1412_InchargePPC)
    If IsdbNull(rs1412!K1412_TotalQty) = False Then D1412.TotalQty = Trim$(rs1412!K1412_TotalQty)
    If IsdbNull(rs1412!K1412_TotalAMT) = False Then D1412.TotalAMT = Trim$(rs1412!K1412_TotalAMT)
    If IsdbNull(rs1412!K1412_TotalCost) = False Then D1412.TotalCost = Trim$(rs1412!K1412_TotalCost)
    If IsdbNull(rs1412!K1412_TotalProfit) = False Then D1412.TotalProfit = Trim$(rs1412!K1412_TotalProfit)
    If IsdbNull(rs1412!K1412_TotalAMTEX) = False Then D1412.TotalAMTEX = Trim$(rs1412!K1412_TotalAMTEX)
    If IsdbNull(rs1412!K1412_TotalAMTVND) = False Then D1412.TotalAMTVND = Trim$(rs1412!K1412_TotalAMTVND)
    If IsdbNull(rs1412!K1412_TotalCostEX) = False Then D1412.TotalCostEX = Trim$(rs1412!K1412_TotalCostEX)
    If IsdbNull(rs1412!K1412_TotalCostVND) = False Then D1412.TotalCostVND = Trim$(rs1412!K1412_TotalCostVND)
    If IsdbNull(rs1412!K1412_TotalProfitEX) = False Then D1412.TotalProfitEX = Trim$(rs1412!K1412_TotalProfitEX)
    If IsdbNull(rs1412!K1412_TotalProfitVND) = False Then D1412.TotalProfitVND = Trim$(rs1412!K1412_TotalProfitVND)
    If IsdbNull(rs1412!K1412_AttachID) = False Then D1412.AttachID = Trim$(rs1412!K1412_AttachID)
    If IsdbNull(rs1412!K1412_OrderNoRef) = False Then D1412.OrderNoRef = Trim$(rs1412!K1412_OrderNoRef)
    If IsdbNull(rs1412!K1412_OrderNoSeqRef) = False Then D1412.OrderNoSeqRef = Trim$(rs1412!K1412_OrderNoSeqRef)
    If IsdbNull(rs1412!K1412_Remark) = False Then D1412.Remark = Trim$(rs1412!K1412_Remark)
    If IsdbNull(rs1412!K1412_RemarkOrder) = False Then D1412.RemarkOrder = Trim$(rs1412!K1412_RemarkOrder)
    If IsdbNull(rs1412!K1412_RemarkCustomer) = False Then D1412.RemarkCustomer = Trim$(rs1412!K1412_RemarkCustomer)
    If IsdbNull(rs1412!K1412_RemarkOther) = False Then D1412.RemarkOther = Trim$(rs1412!K1412_RemarkOther)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K1412_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K1412_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z1412 As T1412_AREA, ORDERNO AS String, ORDERNOSEQ AS String) as Boolean

K1412_MOVE = False

Try
    If READ_PFK1412(ORDERNO, ORDERNOSEQ) = True Then
                z1412 = D1412
		K1412_MOVE = True
		else
	z1412 = nothing
     End If

     If  getColumIndex(spr,"OrderNo") > -1 then z1412.OrderNo = getDataM(spr, getColumIndex(spr,"OrderNo"), xRow)
     If  getColumIndex(spr,"OrderNoSeq") > -1 then z1412.OrderNoSeq = getDataM(spr, getColumIndex(spr,"OrderNoSeq"), xRow)
     If  getColumIndex(spr,"ShoesCode") > -1 then z1412.ShoesCode = getDataM(spr, getColumIndex(spr,"ShoesCode"), xRow)
     If  getColumIndex(spr,"FacPO") > -1 then z1412.FacPO = getDataM(spr, getColumIndex(spr,"FacPO"), xRow)
     If  getColumIndex(spr,"SLNoSys") > -1 then z1412.SLNoSys = getDataM(spr, getColumIndex(spr,"SLNoSys"), xRow)
     If  getColumIndex(spr,"SLNo") > -1 then z1412.SLNo = getDataM(spr, getColumIndex(spr,"SLNo"), xRow)
     If  getColumIndex(spr,"PONO") > -1 then z1412.PONO = getDataM(spr, getColumIndex(spr,"PONO"), xRow)
     If  getColumIndex(spr,"CPONO") > -1 then z1412.CPONO = getDataM(spr, getColumIndex(spr,"CPONO"), xRow)
     If  getColumIndex(spr,"CustomerCode") > -1 then z1412.CustomerCode = getDataM(spr, getColumIndex(spr,"CustomerCode"), xRow)
     If  getColumIndex(spr,"CustomerName") > -1 then z1412.CustomerName = getDataM(spr, getColumIndex(spr,"CustomerName"), xRow)
     If  getColumIndex(spr,"Country") > -1 then z1412.Country = getDataM(spr, getColumIndex(spr,"Country"), xRow)
     If  getColumIndex(spr,"Destination") > -1 then z1412.Destination = getDataM(spr, getColumIndex(spr,"Destination"), xRow)
     If  getColumIndex(spr,"FinalShop") > -1 then z1412.FinalShop = getDataM(spr, getColumIndex(spr,"FinalShop"), xRow)
     If  getColumIndex(spr,"PKO") > -1 then z1412.PKO = getDataM(spr, getColumIndex(spr,"PKO"), xRow)
     If  getColumIndex(spr,"DatePO") > -1 then z1412.DatePO = getDataM(spr, getColumIndex(spr,"DatePO"), xRow)
     If  getColumIndex(spr,"JbCard") > -1 then z1412.JbCard = getDataM(spr, getColumIndex(spr,"JbCard"), xRow)
     If  getColumIndex(spr,"sePackingCode") > -1 then z1412.sePackingCode = getDataM(spr, getColumIndex(spr,"sePackingCode"), xRow)
     If  getColumIndex(spr,"cdPackingCode") > -1 then z1412.cdPackingCode = getDataM(spr, getColumIndex(spr,"cdPackingCode"), xRow)
     If  getColumIndex(spr,"seSpecStatus") > -1 then z1412.seSpecStatus = getDataM(spr, getColumIndex(spr,"seSpecStatus"), xRow)
     If  getColumIndex(spr,"cdSpecStatus") > -1 then z1412.cdSpecStatus = getDataM(spr, getColumIndex(spr,"cdSpecStatus"), xRow)
     If  getColumIndex(spr,"SizeRange") > -1 then z1412.SizeRange = getDataM(spr, getColumIndex(spr,"SizeRange"), xRow)
     If  getColumIndex(spr,"SpeciticSize") > -1 then z1412.SpeciticSize = getDataM(spr, getColumIndex(spr,"SpeciticSize"), xRow)
     If  getColumIndex(spr,"DateSize") > -1 then z1412.DateSize = getDataM(spr, getColumIndex(spr,"DateSize"), xRow)
     If  getColumIndex(spr,"OrderDetailStatus") > -1 then z1412.OrderDetailStatus = getDataM(spr, getColumIndex(spr,"OrderDetailStatus"), xRow)
     If  getColumIndex(spr,"DateOrder") > -1 then z1412.DateOrder = getDataM(spr, getColumIndex(spr,"DateOrder"), xRow)
     If  getColumIndex(spr,"DateApproval") > -1 then z1412.DateApproval = getDataM(spr, getColumIndex(spr,"DateApproval"), xRow)
     If  getColumIndex(spr,"DateCancel") > -1 then z1412.DateCancel = getDataM(spr, getColumIndex(spr,"DateCancel"), xRow)
     If  getColumIndex(spr,"DateComplete") > -1 then z1412.DateComplete = getDataM(spr, getColumIndex(spr,"DateComplete"), xRow)
     If  getColumIndex(spr,"DatePending") > -1 then z1412.DatePending = getDataM(spr, getColumIndex(spr,"DatePending"), xRow)
     If  getColumIndex(spr,"DatePending2") > -1 then z1412.DatePending2 = getDataM(spr, getColumIndex(spr,"DatePending2"), xRow)
     If  getColumIndex(spr,"DateExchangePrice") > -1 then z1412.DateExchangePrice = getDataM(spr, getColumIndex(spr,"DateExchangePrice"), xRow)
     If  getColumIndex(spr,"PriceExchange") > -1 then z1412.PriceExchange = getDataM(spr, getColumIndex(spr,"PriceExchange"), xRow)
     If  getColumIndex(spr,"PriceOrder") > -1 then z1412.PriceOrder = getDataM(spr, getColumIndex(spr,"PriceOrder"), xRow)
     If  getColumIndex(spr,"seUnitPrice") > -1 then z1412.seUnitPrice = getDataM(spr, getColumIndex(spr,"seUnitPrice"), xRow)
     If  getColumIndex(spr,"cdUnitPrice") > -1 then z1412.cdUnitPrice = getDataM(spr, getColumIndex(spr,"cdUnitPrice"), xRow)
     If  getColumIndex(spr,"UnitPrice") > -1 then z1412.UnitPrice = getDataM(spr, getColumIndex(spr,"UnitPrice"), xRow)
     If  getColumIndex(spr,"PriceOrderEX") > -1 then z1412.PriceOrderEX = getDataM(spr, getColumIndex(spr,"PriceOrderEX"), xRow)
     If  getColumIndex(spr,"PriceOrderVND") > -1 then z1412.PriceOrderVND = getDataM(spr, getColumIndex(spr,"PriceOrderVND"), xRow)
     If  getColumIndex(spr,"Datedelivery") > -1 then z1412.Datedelivery = getDataM(spr, getColumIndex(spr,"Datedelivery"), xRow)
     If  getColumIndex(spr,"DateTransfer") > -1 then z1412.DateTransfer = getDataM(spr, getColumIndex(spr,"DateTransfer"), xRow)
     If  getColumIndex(spr,"AcceptedOrder") > -1 then z1412.AcceptedOrder = getDataM(spr, getColumIndex(spr,"AcceptedOrder"), xRow)
     If  getColumIndex(spr,"MaterialStatus") > -1 then z1412.MaterialStatus = getDataM(spr, getColumIndex(spr,"MaterialStatus"), xRow)
     If  getColumIndex(spr,"SoleStatus") > -1 then z1412.SoleStatus = getDataM(spr, getColumIndex(spr,"SoleStatus"), xRow)
     If  getColumIndex(spr,"DateLable") > -1 then z1412.DateLable = getDataM(spr, getColumIndex(spr,"DateLable"), xRow)
     If  getColumIndex(spr,"DatePattern") > -1 then z1412.DatePattern = getDataM(spr, getColumIndex(spr,"DatePattern"), xRow)
     If  getColumIndex(spr,"DateMaterial") > -1 then z1412.DateMaterial = getDataM(spr, getColumIndex(spr,"DateMaterial"), xRow)
     If  getColumIndex(spr,"DatePlanning") > -1 then z1412.DatePlanning = getDataM(spr, getColumIndex(spr,"DatePlanning"), xRow)
     If  getColumIndex(spr,"DateRnD") > -1 then z1412.DateRnD = getDataM(spr, getColumIndex(spr,"DateRnD"), xRow)
     If  getColumIndex(spr,"DateFitting") > -1 then z1412.DateFitting = getDataM(spr, getColumIndex(spr,"DateFitting"), xRow)
     If  getColumIndex(spr,"InchargeFitting") > -1 then z1412.InchargeFitting = getDataM(spr, getColumIndex(spr,"InchargeFitting"), xRow)
     If  getColumIndex(spr,"CheckFitting") > -1 then z1412.CheckFitting = getDataM(spr, getColumIndex(spr,"CheckFitting"), xRow)
     If  getColumIndex(spr,"DateTesting") > -1 then z1412.DateTesting = getDataM(spr, getColumIndex(spr,"DateTesting"), xRow)
     If  getColumIndex(spr,"InchargeTesting") > -1 then z1412.InchargeTesting = getDataM(spr, getColumIndex(spr,"InchargeTesting"), xRow)
     If  getColumIndex(spr,"CheckTesting") > -1 then z1412.CheckTesting = getDataM(spr, getColumIndex(spr,"CheckTesting"), xRow)
     If  getColumIndex(spr,"CheckConfirm") > -1 then z1412.CheckConfirm = getDataM(spr, getColumIndex(spr,"CheckConfirm"), xRow)
     If  getColumIndex(spr,"DateConfirm") > -1 then z1412.DateConfirm = getDataM(spr, getColumIndex(spr,"DateConfirm"), xRow)
     If  getColumIndex(spr,"SpecNo") > -1 then z1412.SpecNo = getDataM(spr, getColumIndex(spr,"SpecNo"), xRow)
     If  getColumIndex(spr,"SpecNoSeq") > -1 then z1412.SpecNoSeq = getDataM(spr, getColumIndex(spr,"SpecNoSeq"), xRow)
     If  getColumIndex(spr,"DateSole") > -1 then z1412.DateSole = getDataM(spr, getColumIndex(spr,"DateSole"), xRow)
     If  getColumIndex(spr,"DateCutting") > -1 then z1412.DateCutting = getDataM(spr, getColumIndex(spr,"DateCutting"), xRow)
     If  getColumIndex(spr,"DateStitching") > -1 then z1412.DateStitching = getDataM(spr, getColumIndex(spr,"DateStitching"), xRow)
     If  getColumIndex(spr,"DateStockfit") > -1 then z1412.DateStockfit = getDataM(spr, getColumIndex(spr,"DateStockfit"), xRow)
     If  getColumIndex(spr,"DateAssmbly") > -1 then z1412.DateAssmbly = getDataM(spr, getColumIndex(spr,"DateAssmbly"), xRow)
     If  getColumIndex(spr,"DateShipping") > -1 then z1412.DateShipping = getDataM(spr, getColumIndex(spr,"DateShipping"), xRow)
     If  getColumIndex(spr,"seUnitMaterial") > -1 then z1412.seUnitMaterial = getDataM(spr, getColumIndex(spr,"seUnitMaterial"), xRow)
     If  getColumIndex(spr,"cdUnitMaterial") > -1 then z1412.cdUnitMaterial = getDataM(spr, getColumIndex(spr,"cdUnitMaterial"), xRow)
     If  getColumIndex(spr,"seUnitPacking") > -1 then z1412.seUnitPacking = getDataM(spr, getColumIndex(spr,"seUnitPacking"), xRow)
     If  getColumIndex(spr,"cdUnitPacking") > -1 then z1412.cdUnitPacking = getDataM(spr, getColumIndex(spr,"cdUnitPacking"), xRow)
     If  getColumIndex(spr,"QtyOrder") > -1 then z1412.QtyOrder = getDataM(spr, getColumIndex(spr,"QtyOrder"), xRow)
     If  getColumIndex(spr,"QtyJob") > -1 then z1412.QtyJob = getDataM(spr, getColumIndex(spr,"QtyJob"), xRow)
     If  getColumIndex(spr,"QtySole") > -1 then z1412.QtySole = getDataM(spr, getColumIndex(spr,"QtySole"), xRow)
     If  getColumIndex(spr,"QtyCutting") > -1 then z1412.QtyCutting = getDataM(spr, getColumIndex(spr,"QtyCutting"), xRow)
     If  getColumIndex(spr,"QtyStitching") > -1 then z1412.QtyStitching = getDataM(spr, getColumIndex(spr,"QtyStitching"), xRow)
     If  getColumIndex(spr,"QtyStockfit") > -1 then z1412.QtyStockfit = getDataM(spr, getColumIndex(spr,"QtyStockfit"), xRow)
     If  getColumIndex(spr,"QtyAssembly") > -1 then z1412.QtyAssembly = getDataM(spr, getColumIndex(spr,"QtyAssembly"), xRow)
     If  getColumIndex(spr,"QtyPacking") > -1 then z1412.QtyPacking = getDataM(spr, getColumIndex(spr,"QtyPacking"), xRow)
     If  getColumIndex(spr,"QtyInbound") > -1 then z1412.QtyInbound = getDataM(spr, getColumIndex(spr,"QtyInbound"), xRow)
     If  getColumIndex(spr,"QtyShipping") > -1 then z1412.QtyShipping = getDataM(spr, getColumIndex(spr,"QtyShipping"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z1412.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z1412.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z1412.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z1412.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"InchargeSales") > -1 then z1412.InchargeSales = getDataM(spr, getColumIndex(spr,"InchargeSales"), xRow)
     If  getColumIndex(spr,"InchargePPC") > -1 then z1412.InchargePPC = getDataM(spr, getColumIndex(spr,"InchargePPC"), xRow)
     If  getColumIndex(spr,"TotalQty") > -1 then z1412.TotalQty = getDataM(spr, getColumIndex(spr,"TotalQty"), xRow)
     If  getColumIndex(spr,"TotalAMT") > -1 then z1412.TotalAMT = getDataM(spr, getColumIndex(spr,"TotalAMT"), xRow)
     If  getColumIndex(spr,"TotalCost") > -1 then z1412.TotalCost = getDataM(spr, getColumIndex(spr,"TotalCost"), xRow)
     If  getColumIndex(spr,"TotalProfit") > -1 then z1412.TotalProfit = getDataM(spr, getColumIndex(spr,"TotalProfit"), xRow)
     If  getColumIndex(spr,"TotalAMTEX") > -1 then z1412.TotalAMTEX = getDataM(spr, getColumIndex(spr,"TotalAMTEX"), xRow)
     If  getColumIndex(spr,"TotalAMTVND") > -1 then z1412.TotalAMTVND = getDataM(spr, getColumIndex(spr,"TotalAMTVND"), xRow)
     If  getColumIndex(spr,"TotalCostEX") > -1 then z1412.TotalCostEX = getDataM(spr, getColumIndex(spr,"TotalCostEX"), xRow)
     If  getColumIndex(spr,"TotalCostVND") > -1 then z1412.TotalCostVND = getDataM(spr, getColumIndex(spr,"TotalCostVND"), xRow)
     If  getColumIndex(spr,"TotalProfitEX") > -1 then z1412.TotalProfitEX = getDataM(spr, getColumIndex(spr,"TotalProfitEX"), xRow)
     If  getColumIndex(spr,"TotalProfitVND") > -1 then z1412.TotalProfitVND = getDataM(spr, getColumIndex(spr,"TotalProfitVND"), xRow)
     If  getColumIndex(spr,"AttachID") > -1 then z1412.AttachID = getDataM(spr, getColumIndex(spr,"AttachID"), xRow)
     If  getColumIndex(spr,"OrderNoRef") > -1 then z1412.OrderNoRef = getDataM(spr, getColumIndex(spr,"OrderNoRef"), xRow)
     If  getColumIndex(spr,"OrderNoSeqRef") > -1 then z1412.OrderNoSeqRef = getDataM(spr, getColumIndex(spr,"OrderNoSeqRef"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z1412.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)
     If  getColumIndex(spr,"RemarkOrder") > -1 then z1412.RemarkOrder = getDataM(spr, getColumIndex(spr,"RemarkOrder"), xRow)
     If  getColumIndex(spr,"RemarkCustomer") > -1 then z1412.RemarkCustomer = getDataM(spr, getColumIndex(spr,"RemarkCustomer"), xRow)
     If  getColumIndex(spr,"RemarkOther") > -1 then z1412.RemarkOther = getDataM(spr, getColumIndex(spr,"RemarkOther"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K1412_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K1412_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z1412 As T1412_AREA,CheckClear as Boolean,ORDERNO AS String, ORDERNOSEQ AS String) as Boolean

K1412_MOVE = False

Try
    If READ_PFK1412(ORDERNO, ORDERNOSEQ) = True Then
                z1412 = D1412
		K1412_MOVE = True
		else
	If CheckClear  = True then z1412 = nothing
     End If

     If  getColumIndex(spr,"OrderNo") > -1 then z1412.OrderNo = getDataM(spr, getColumIndex(spr,"OrderNo"), xRow)
     If  getColumIndex(spr,"OrderNoSeq") > -1 then z1412.OrderNoSeq = getDataM(spr, getColumIndex(spr,"OrderNoSeq"), xRow)
     If  getColumIndex(spr,"ShoesCode") > -1 then z1412.ShoesCode = getDataM(spr, getColumIndex(spr,"ShoesCode"), xRow)
     If  getColumIndex(spr,"FacPO") > -1 then z1412.FacPO = getDataM(spr, getColumIndex(spr,"FacPO"), xRow)
     If  getColumIndex(spr,"SLNoSys") > -1 then z1412.SLNoSys = getDataM(spr, getColumIndex(spr,"SLNoSys"), xRow)
     If  getColumIndex(spr,"SLNo") > -1 then z1412.SLNo = getDataM(spr, getColumIndex(spr,"SLNo"), xRow)
     If  getColumIndex(spr,"PONO") > -1 then z1412.PONO = getDataM(spr, getColumIndex(spr,"PONO"), xRow)
     If  getColumIndex(spr,"CPONO") > -1 then z1412.CPONO = getDataM(spr, getColumIndex(spr,"CPONO"), xRow)
     If  getColumIndex(spr,"CustomerCode") > -1 then z1412.CustomerCode = getDataM(spr, getColumIndex(spr,"CustomerCode"), xRow)
     If  getColumIndex(spr,"CustomerName") > -1 then z1412.CustomerName = getDataM(spr, getColumIndex(spr,"CustomerName"), xRow)
     If  getColumIndex(spr,"Country") > -1 then z1412.Country = getDataM(spr, getColumIndex(spr,"Country"), xRow)
     If  getColumIndex(spr,"Destination") > -1 then z1412.Destination = getDataM(spr, getColumIndex(spr,"Destination"), xRow)
     If  getColumIndex(spr,"FinalShop") > -1 then z1412.FinalShop = getDataM(spr, getColumIndex(spr,"FinalShop"), xRow)
     If  getColumIndex(spr,"PKO") > -1 then z1412.PKO = getDataM(spr, getColumIndex(spr,"PKO"), xRow)
     If  getColumIndex(spr,"DatePO") > -1 then z1412.DatePO = getDataM(spr, getColumIndex(spr,"DatePO"), xRow)
     If  getColumIndex(spr,"JbCard") > -1 then z1412.JbCard = getDataM(spr, getColumIndex(spr,"JbCard"), xRow)
     If  getColumIndex(spr,"sePackingCode") > -1 then z1412.sePackingCode = getDataM(spr, getColumIndex(spr,"sePackingCode"), xRow)
     If  getColumIndex(spr,"cdPackingCode") > -1 then z1412.cdPackingCode = getDataM(spr, getColumIndex(spr,"cdPackingCode"), xRow)
     If  getColumIndex(spr,"seSpecStatus") > -1 then z1412.seSpecStatus = getDataM(spr, getColumIndex(spr,"seSpecStatus"), xRow)
     If  getColumIndex(spr,"cdSpecStatus") > -1 then z1412.cdSpecStatus = getDataM(spr, getColumIndex(spr,"cdSpecStatus"), xRow)
     If  getColumIndex(spr,"SizeRange") > -1 then z1412.SizeRange = getDataM(spr, getColumIndex(spr,"SizeRange"), xRow)
     If  getColumIndex(spr,"SpeciticSize") > -1 then z1412.SpeciticSize = getDataM(spr, getColumIndex(spr,"SpeciticSize"), xRow)
     If  getColumIndex(spr,"DateSize") > -1 then z1412.DateSize = getDataM(spr, getColumIndex(spr,"DateSize"), xRow)
     If  getColumIndex(spr,"OrderDetailStatus") > -1 then z1412.OrderDetailStatus = getDataM(spr, getColumIndex(spr,"OrderDetailStatus"), xRow)
     If  getColumIndex(spr,"DateOrder") > -1 then z1412.DateOrder = getDataM(spr, getColumIndex(spr,"DateOrder"), xRow)
     If  getColumIndex(spr,"DateApproval") > -1 then z1412.DateApproval = getDataM(spr, getColumIndex(spr,"DateApproval"), xRow)
     If  getColumIndex(spr,"DateCancel") > -1 then z1412.DateCancel = getDataM(spr, getColumIndex(spr,"DateCancel"), xRow)
     If  getColumIndex(spr,"DateComplete") > -1 then z1412.DateComplete = getDataM(spr, getColumIndex(spr,"DateComplete"), xRow)
     If  getColumIndex(spr,"DatePending") > -1 then z1412.DatePending = getDataM(spr, getColumIndex(spr,"DatePending"), xRow)
     If  getColumIndex(spr,"DatePending2") > -1 then z1412.DatePending2 = getDataM(spr, getColumIndex(spr,"DatePending2"), xRow)
     If  getColumIndex(spr,"DateExchangePrice") > -1 then z1412.DateExchangePrice = getDataM(spr, getColumIndex(spr,"DateExchangePrice"), xRow)
     If  getColumIndex(spr,"PriceExchange") > -1 then z1412.PriceExchange = getDataM(spr, getColumIndex(spr,"PriceExchange"), xRow)
     If  getColumIndex(spr,"PriceOrder") > -1 then z1412.PriceOrder = getDataM(spr, getColumIndex(spr,"PriceOrder"), xRow)
     If  getColumIndex(spr,"seUnitPrice") > -1 then z1412.seUnitPrice = getDataM(spr, getColumIndex(spr,"seUnitPrice"), xRow)
     If  getColumIndex(spr,"cdUnitPrice") > -1 then z1412.cdUnitPrice = getDataM(spr, getColumIndex(spr,"cdUnitPrice"), xRow)
     If  getColumIndex(spr,"UnitPrice") > -1 then z1412.UnitPrice = getDataM(spr, getColumIndex(spr,"UnitPrice"), xRow)
     If  getColumIndex(spr,"PriceOrderEX") > -1 then z1412.PriceOrderEX = getDataM(spr, getColumIndex(spr,"PriceOrderEX"), xRow)
     If  getColumIndex(spr,"PriceOrderVND") > -1 then z1412.PriceOrderVND = getDataM(spr, getColumIndex(spr,"PriceOrderVND"), xRow)
     If  getColumIndex(spr,"Datedelivery") > -1 then z1412.Datedelivery = getDataM(spr, getColumIndex(spr,"Datedelivery"), xRow)
     If  getColumIndex(spr,"DateTransfer") > -1 then z1412.DateTransfer = getDataM(spr, getColumIndex(spr,"DateTransfer"), xRow)
     If  getColumIndex(spr,"AcceptedOrder") > -1 then z1412.AcceptedOrder = getDataM(spr, getColumIndex(spr,"AcceptedOrder"), xRow)
     If  getColumIndex(spr,"MaterialStatus") > -1 then z1412.MaterialStatus = getDataM(spr, getColumIndex(spr,"MaterialStatus"), xRow)
     If  getColumIndex(spr,"SoleStatus") > -1 then z1412.SoleStatus = getDataM(spr, getColumIndex(spr,"SoleStatus"), xRow)
     If  getColumIndex(spr,"DateLable") > -1 then z1412.DateLable = getDataM(spr, getColumIndex(spr,"DateLable"), xRow)
     If  getColumIndex(spr,"DatePattern") > -1 then z1412.DatePattern = getDataM(spr, getColumIndex(spr,"DatePattern"), xRow)
     If  getColumIndex(spr,"DateMaterial") > -1 then z1412.DateMaterial = getDataM(spr, getColumIndex(spr,"DateMaterial"), xRow)
     If  getColumIndex(spr,"DatePlanning") > -1 then z1412.DatePlanning = getDataM(spr, getColumIndex(spr,"DatePlanning"), xRow)
     If  getColumIndex(spr,"DateRnD") > -1 then z1412.DateRnD = getDataM(spr, getColumIndex(spr,"DateRnD"), xRow)
     If  getColumIndex(spr,"DateFitting") > -1 then z1412.DateFitting = getDataM(spr, getColumIndex(spr,"DateFitting"), xRow)
     If  getColumIndex(spr,"InchargeFitting") > -1 then z1412.InchargeFitting = getDataM(spr, getColumIndex(spr,"InchargeFitting"), xRow)
     If  getColumIndex(spr,"CheckFitting") > -1 then z1412.CheckFitting = getDataM(spr, getColumIndex(spr,"CheckFitting"), xRow)
     If  getColumIndex(spr,"DateTesting") > -1 then z1412.DateTesting = getDataM(spr, getColumIndex(spr,"DateTesting"), xRow)
     If  getColumIndex(spr,"InchargeTesting") > -1 then z1412.InchargeTesting = getDataM(spr, getColumIndex(spr,"InchargeTesting"), xRow)
     If  getColumIndex(spr,"CheckTesting") > -1 then z1412.CheckTesting = getDataM(spr, getColumIndex(spr,"CheckTesting"), xRow)
     If  getColumIndex(spr,"CheckConfirm") > -1 then z1412.CheckConfirm = getDataM(spr, getColumIndex(spr,"CheckConfirm"), xRow)
     If  getColumIndex(spr,"DateConfirm") > -1 then z1412.DateConfirm = getDataM(spr, getColumIndex(spr,"DateConfirm"), xRow)
     If  getColumIndex(spr,"SpecNo") > -1 then z1412.SpecNo = getDataM(spr, getColumIndex(spr,"SpecNo"), xRow)
     If  getColumIndex(spr,"SpecNoSeq") > -1 then z1412.SpecNoSeq = getDataM(spr, getColumIndex(spr,"SpecNoSeq"), xRow)
     If  getColumIndex(spr,"DateSole") > -1 then z1412.DateSole = getDataM(spr, getColumIndex(spr,"DateSole"), xRow)
     If  getColumIndex(spr,"DateCutting") > -1 then z1412.DateCutting = getDataM(spr, getColumIndex(spr,"DateCutting"), xRow)
     If  getColumIndex(spr,"DateStitching") > -1 then z1412.DateStitching = getDataM(spr, getColumIndex(spr,"DateStitching"), xRow)
     If  getColumIndex(spr,"DateStockfit") > -1 then z1412.DateStockfit = getDataM(spr, getColumIndex(spr,"DateStockfit"), xRow)
     If  getColumIndex(spr,"DateAssmbly") > -1 then z1412.DateAssmbly = getDataM(spr, getColumIndex(spr,"DateAssmbly"), xRow)
     If  getColumIndex(spr,"DateShipping") > -1 then z1412.DateShipping = getDataM(spr, getColumIndex(spr,"DateShipping"), xRow)
     If  getColumIndex(spr,"seUnitMaterial") > -1 then z1412.seUnitMaterial = getDataM(spr, getColumIndex(spr,"seUnitMaterial"), xRow)
     If  getColumIndex(spr,"cdUnitMaterial") > -1 then z1412.cdUnitMaterial = getDataM(spr, getColumIndex(spr,"cdUnitMaterial"), xRow)
     If  getColumIndex(spr,"seUnitPacking") > -1 then z1412.seUnitPacking = getDataM(spr, getColumIndex(spr,"seUnitPacking"), xRow)
     If  getColumIndex(spr,"cdUnitPacking") > -1 then z1412.cdUnitPacking = getDataM(spr, getColumIndex(spr,"cdUnitPacking"), xRow)
     If  getColumIndex(spr,"QtyOrder") > -1 then z1412.QtyOrder = getDataM(spr, getColumIndex(spr,"QtyOrder"), xRow)
     If  getColumIndex(spr,"QtyJob") > -1 then z1412.QtyJob = getDataM(spr, getColumIndex(spr,"QtyJob"), xRow)
     If  getColumIndex(spr,"QtySole") > -1 then z1412.QtySole = getDataM(spr, getColumIndex(spr,"QtySole"), xRow)
     If  getColumIndex(spr,"QtyCutting") > -1 then z1412.QtyCutting = getDataM(spr, getColumIndex(spr,"QtyCutting"), xRow)
     If  getColumIndex(spr,"QtyStitching") > -1 then z1412.QtyStitching = getDataM(spr, getColumIndex(spr,"QtyStitching"), xRow)
     If  getColumIndex(spr,"QtyStockfit") > -1 then z1412.QtyStockfit = getDataM(spr, getColumIndex(spr,"QtyStockfit"), xRow)
     If  getColumIndex(spr,"QtyAssembly") > -1 then z1412.QtyAssembly = getDataM(spr, getColumIndex(spr,"QtyAssembly"), xRow)
     If  getColumIndex(spr,"QtyPacking") > -1 then z1412.QtyPacking = getDataM(spr, getColumIndex(spr,"QtyPacking"), xRow)
     If  getColumIndex(spr,"QtyInbound") > -1 then z1412.QtyInbound = getDataM(spr, getColumIndex(spr,"QtyInbound"), xRow)
     If  getColumIndex(spr,"QtyShipping") > -1 then z1412.QtyShipping = getDataM(spr, getColumIndex(spr,"QtyShipping"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z1412.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z1412.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z1412.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z1412.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"InchargeSales") > -1 then z1412.InchargeSales = getDataM(spr, getColumIndex(spr,"InchargeSales"), xRow)
     If  getColumIndex(spr,"InchargePPC") > -1 then z1412.InchargePPC = getDataM(spr, getColumIndex(spr,"InchargePPC"), xRow)
     If  getColumIndex(spr,"TotalQty") > -1 then z1412.TotalQty = getDataM(spr, getColumIndex(spr,"TotalQty"), xRow)
     If  getColumIndex(spr,"TotalAMT") > -1 then z1412.TotalAMT = getDataM(spr, getColumIndex(spr,"TotalAMT"), xRow)
     If  getColumIndex(spr,"TotalCost") > -1 then z1412.TotalCost = getDataM(spr, getColumIndex(spr,"TotalCost"), xRow)
     If  getColumIndex(spr,"TotalProfit") > -1 then z1412.TotalProfit = getDataM(spr, getColumIndex(spr,"TotalProfit"), xRow)
     If  getColumIndex(spr,"TotalAMTEX") > -1 then z1412.TotalAMTEX = getDataM(spr, getColumIndex(spr,"TotalAMTEX"), xRow)
     If  getColumIndex(spr,"TotalAMTVND") > -1 then z1412.TotalAMTVND = getDataM(spr, getColumIndex(spr,"TotalAMTVND"), xRow)
     If  getColumIndex(spr,"TotalCostEX") > -1 then z1412.TotalCostEX = getDataM(spr, getColumIndex(spr,"TotalCostEX"), xRow)
     If  getColumIndex(spr,"TotalCostVND") > -1 then z1412.TotalCostVND = getDataM(spr, getColumIndex(spr,"TotalCostVND"), xRow)
     If  getColumIndex(spr,"TotalProfitEX") > -1 then z1412.TotalProfitEX = getDataM(spr, getColumIndex(spr,"TotalProfitEX"), xRow)
     If  getColumIndex(spr,"TotalProfitVND") > -1 then z1412.TotalProfitVND = getDataM(spr, getColumIndex(spr,"TotalProfitVND"), xRow)
     If  getColumIndex(spr,"AttachID") > -1 then z1412.AttachID = getDataM(spr, getColumIndex(spr,"AttachID"), xRow)
     If  getColumIndex(spr,"OrderNoRef") > -1 then z1412.OrderNoRef = getDataM(spr, getColumIndex(spr,"OrderNoRef"), xRow)
     If  getColumIndex(spr,"OrderNoSeqRef") > -1 then z1412.OrderNoSeqRef = getDataM(spr, getColumIndex(spr,"OrderNoSeqRef"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z1412.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)
     If  getColumIndex(spr,"RemarkOrder") > -1 then z1412.RemarkOrder = getDataM(spr, getColumIndex(spr,"RemarkOrder"), xRow)
     If  getColumIndex(spr,"RemarkCustomer") > -1 then z1412.RemarkCustomer = getDataM(spr, getColumIndex(spr,"RemarkCustomer"), xRow)
     If  getColumIndex(spr,"RemarkOther") > -1 then z1412.RemarkOther = getDataM(spr, getColumIndex(spr,"RemarkOther"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K1412_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K1412_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z1412 As T1412_AREA, Job as String, ORDERNO AS String, ORDERNOSEQ AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K1412_MOVE = False

Try
    If READ_PFK1412(ORDERNO, ORDERNOSEQ) = True Then
                z1412 = D1412
		K1412_MOVE = True
		else
	z1412 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK1412")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "ORDERNO":z1412.OrderNo = Children(i).Code
   Case "ORDERNOSEQ":z1412.OrderNoSeq = Children(i).Code
   Case "SHOESCODE":z1412.ShoesCode = Children(i).Code
   Case "FACPO":z1412.FacPO = Children(i).Code
   Case "SLNOSYS":z1412.SLNoSys = Children(i).Code
   Case "SLNO":z1412.SLNo = Children(i).Code
   Case "PONO":z1412.PONO = Children(i).Code
   Case "CPONO":z1412.CPONO = Children(i).Code
   Case "CUSTOMERCODE":z1412.CustomerCode = Children(i).Code
   Case "CUSTOMERNAME":z1412.CustomerName = Children(i).Code
   Case "COUNTRY":z1412.Country = Children(i).Code
   Case "DESTINATION":z1412.Destination = Children(i).Code
   Case "FINALSHOP":z1412.FinalShop = Children(i).Code
   Case "PKO":z1412.PKO = Children(i).Code
   Case "DATEPO":z1412.DatePO = Children(i).Code
   Case "JBCARD":z1412.JbCard = Children(i).Code
   Case "SEPACKINGCODE":z1412.sePackingCode = Children(i).Code
   Case "CDPACKINGCODE":z1412.cdPackingCode = Children(i).Code
   Case "SESPECSTATUS":z1412.seSpecStatus = Children(i).Code
   Case "CDSPECSTATUS":z1412.cdSpecStatus = Children(i).Code
   Case "SIZERANGE":z1412.SizeRange = Children(i).Code
   Case "SPECITICSIZE":z1412.SpeciticSize = Children(i).Code
   Case "DATESIZE":z1412.DateSize = Children(i).Code
   Case "ORDERDETAILSTATUS":z1412.OrderDetailStatus = Children(i).Code
   Case "DATEORDER":z1412.DateOrder = Children(i).Code
   Case "DATEAPPROVAL":z1412.DateApproval = Children(i).Code
   Case "DATECANCEL":z1412.DateCancel = Children(i).Code
   Case "DATECOMPLETE":z1412.DateComplete = Children(i).Code
   Case "DATEPENDING":z1412.DatePending = Children(i).Code
   Case "DATEPENDING2":z1412.DatePending2 = Children(i).Code
   Case "DATEEXCHANGEPRICE":z1412.DateExchangePrice = Children(i).Code
   Case "PRICEEXCHANGE":z1412.PriceExchange = Children(i).Code
   Case "PRICEORDER":z1412.PriceOrder = Children(i).Code
   Case "SEUNITPRICE":z1412.seUnitPrice = Children(i).Code
   Case "CDUNITPRICE":z1412.cdUnitPrice = Children(i).Code
   Case "UNITPRICE":z1412.UnitPrice = Children(i).Code
   Case "PRICEORDEREX":z1412.PriceOrderEX = Children(i).Code
   Case "PRICEORDERVND":z1412.PriceOrderVND = Children(i).Code
   Case "DATEDELIVERY":z1412.Datedelivery = Children(i).Code
   Case "DATETRANSFER":z1412.DateTransfer = Children(i).Code
   Case "ACCEPTEDORDER":z1412.AcceptedOrder = Children(i).Code
   Case "MATERIALSTATUS":z1412.MaterialStatus = Children(i).Code
   Case "SOLESTATUS":z1412.SoleStatus = Children(i).Code
   Case "DATELABLE":z1412.DateLable = Children(i).Code
   Case "DATEPATTERN":z1412.DatePattern = Children(i).Code
   Case "DATEMATERIAL":z1412.DateMaterial = Children(i).Code
   Case "DATEPLANNING":z1412.DatePlanning = Children(i).Code
   Case "DATERND":z1412.DateRnD = Children(i).Code
   Case "DATEFITTING":z1412.DateFitting = Children(i).Code
   Case "INCHARGEFITTING":z1412.InchargeFitting = Children(i).Code
   Case "CHECKFITTING":z1412.CheckFitting = Children(i).Code
   Case "DATETESTING":z1412.DateTesting = Children(i).Code
   Case "INCHARGETESTING":z1412.InchargeTesting = Children(i).Code
   Case "CHECKTESTING":z1412.CheckTesting = Children(i).Code
   Case "CHECKCONFIRM":z1412.CheckConfirm = Children(i).Code
   Case "DATECONFIRM":z1412.DateConfirm = Children(i).Code
   Case "SPECNO":z1412.SpecNo = Children(i).Code
   Case "SPECNOSEQ":z1412.SpecNoSeq = Children(i).Code
   Case "DATESOLE":z1412.DateSole = Children(i).Code
   Case "DATECUTTING":z1412.DateCutting = Children(i).Code
   Case "DATESTITCHING":z1412.DateStitching = Children(i).Code
   Case "DATESTOCKFIT":z1412.DateStockfit = Children(i).Code
   Case "DATEASSMBLY":z1412.DateAssmbly = Children(i).Code
   Case "DATESHIPPING":z1412.DateShipping = Children(i).Code
   Case "SEUNITMATERIAL":z1412.seUnitMaterial = Children(i).Code
   Case "CDUNITMATERIAL":z1412.cdUnitMaterial = Children(i).Code
   Case "SEUNITPACKING":z1412.seUnitPacking = Children(i).Code
   Case "CDUNITPACKING":z1412.cdUnitPacking = Children(i).Code
   Case "QTYORDER":z1412.QtyOrder = Children(i).Code
   Case "QTYJOB":z1412.QtyJob = Children(i).Code
   Case "QTYSOLE":z1412.QtySole = Children(i).Code
   Case "QTYCUTTING":z1412.QtyCutting = Children(i).Code
   Case "QTYSTITCHING":z1412.QtyStitching = Children(i).Code
   Case "QTYSTOCKFIT":z1412.QtyStockfit = Children(i).Code
   Case "QTYASSEMBLY":z1412.QtyAssembly = Children(i).Code
   Case "QTYPACKING":z1412.QtyPacking = Children(i).Code
   Case "QTYINBOUND":z1412.QtyInbound = Children(i).Code
   Case "QTYSHIPPING":z1412.QtyShipping = Children(i).Code
   Case "DATEINSERT":z1412.DateInsert = Children(i).Code
   Case "INCHARGEINSERT":z1412.InchargeInsert = Children(i).Code
   Case "DATEUPDATE":z1412.DateUpdate = Children(i).Code
   Case "INCHARGEUPDATE":z1412.InchargeUpdate = Children(i).Code
   Case "INCHARGESALES":z1412.InchargeSales = Children(i).Code
   Case "INCHARGEPPC":z1412.InchargePPC = Children(i).Code
   Case "TOTALQTY":z1412.TotalQty = Children(i).Code
   Case "TOTALAMT":z1412.TotalAMT = Children(i).Code
   Case "TOTALCOST":z1412.TotalCost = Children(i).Code
   Case "TOTALPROFIT":z1412.TotalProfit = Children(i).Code
   Case "TOTALAMTEX":z1412.TotalAMTEX = Children(i).Code
   Case "TOTALAMTVND":z1412.TotalAMTVND = Children(i).Code
   Case "TOTALCOSTEX":z1412.TotalCostEX = Children(i).Code
   Case "TOTALCOSTVND":z1412.TotalCostVND = Children(i).Code
   Case "TOTALPROFITEX":z1412.TotalProfitEX = Children(i).Code
   Case "TOTALPROFITVND":z1412.TotalProfitVND = Children(i).Code
   Case "ATTACHID":z1412.AttachID = Children(i).Code
   Case "ORDERNOREF":z1412.OrderNoRef = Children(i).Code
   Case "ORDERNOSEQREF":z1412.OrderNoSeqRef = Children(i).Code
   Case "REMARK":z1412.Remark = Children(i).Code
   Case "REMARKORDER":z1412.RemarkOrder = Children(i).Code
   Case "REMARKCUSTOMER":z1412.RemarkCustomer = Children(i).Code
   Case "REMARKOTHER":z1412.RemarkOther = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "ORDERNO":z1412.OrderNo = Children(i).Data
   Case "ORDERNOSEQ":z1412.OrderNoSeq = Children(i).Data
   Case "SHOESCODE":z1412.ShoesCode = Children(i).Data
   Case "FACPO":z1412.FacPO = Children(i).Data
   Case "SLNOSYS":z1412.SLNoSys = Children(i).Data
   Case "SLNO":z1412.SLNo = Children(i).Data
   Case "PONO":z1412.PONO = Children(i).Data
   Case "CPONO":z1412.CPONO = Children(i).Data
   Case "CUSTOMERCODE":z1412.CustomerCode = Children(i).Data
   Case "CUSTOMERNAME":z1412.CustomerName = Children(i).Data
   Case "COUNTRY":z1412.Country = Children(i).Data
   Case "DESTINATION":z1412.Destination = Children(i).Data
   Case "FINALSHOP":z1412.FinalShop = Children(i).Data
   Case "PKO":z1412.PKO = Children(i).Data
   Case "DATEPO":z1412.DatePO = Children(i).Data
   Case "JBCARD":z1412.JbCard = Children(i).Data
   Case "SEPACKINGCODE":z1412.sePackingCode = Children(i).Data
   Case "CDPACKINGCODE":z1412.cdPackingCode = Children(i).Data
   Case "SESPECSTATUS":z1412.seSpecStatus = Children(i).Data
   Case "CDSPECSTATUS":z1412.cdSpecStatus = Children(i).Data
   Case "SIZERANGE":z1412.SizeRange = Children(i).Data
   Case "SPECITICSIZE":z1412.SpeciticSize = Children(i).Data
   Case "DATESIZE":z1412.DateSize = Children(i).Data
   Case "ORDERDETAILSTATUS":z1412.OrderDetailStatus = Children(i).Data
   Case "DATEORDER":z1412.DateOrder = Children(i).Data
   Case "DATEAPPROVAL":z1412.DateApproval = Children(i).Data
   Case "DATECANCEL":z1412.DateCancel = Children(i).Data
   Case "DATECOMPLETE":z1412.DateComplete = Children(i).Data
   Case "DATEPENDING":z1412.DatePending = Children(i).Data
   Case "DATEPENDING2":z1412.DatePending2 = Children(i).Data
   Case "DATEEXCHANGEPRICE":z1412.DateExchangePrice = Children(i).Data
   Case "PRICEEXCHANGE":z1412.PriceExchange = Children(i).Data
   Case "PRICEORDER":z1412.PriceOrder = Children(i).Data
   Case "SEUNITPRICE":z1412.seUnitPrice = Children(i).Data
   Case "CDUNITPRICE":z1412.cdUnitPrice = Children(i).Data
   Case "UNITPRICE":z1412.UnitPrice = Children(i).Data
   Case "PRICEORDEREX":z1412.PriceOrderEX = Children(i).Data
   Case "PRICEORDERVND":z1412.PriceOrderVND = Children(i).Data
   Case "DATEDELIVERY":z1412.Datedelivery = Children(i).Data
   Case "DATETRANSFER":z1412.DateTransfer = Children(i).Data
   Case "ACCEPTEDORDER":z1412.AcceptedOrder = Children(i).Data
   Case "MATERIALSTATUS":z1412.MaterialStatus = Children(i).Data
   Case "SOLESTATUS":z1412.SoleStatus = Children(i).Data
   Case "DATELABLE":z1412.DateLable = Children(i).Data
   Case "DATEPATTERN":z1412.DatePattern = Children(i).Data
   Case "DATEMATERIAL":z1412.DateMaterial = Children(i).Data
   Case "DATEPLANNING":z1412.DatePlanning = Children(i).Data
   Case "DATERND":z1412.DateRnD = Children(i).Data
   Case "DATEFITTING":z1412.DateFitting = Children(i).Data
   Case "INCHARGEFITTING":z1412.InchargeFitting = Children(i).Data
   Case "CHECKFITTING":z1412.CheckFitting = Children(i).Data
   Case "DATETESTING":z1412.DateTesting = Children(i).Data
   Case "INCHARGETESTING":z1412.InchargeTesting = Children(i).Data
   Case "CHECKTESTING":z1412.CheckTesting = Children(i).Data
   Case "CHECKCONFIRM":z1412.CheckConfirm = Children(i).Data
   Case "DATECONFIRM":z1412.DateConfirm = Children(i).Data
   Case "SPECNO":z1412.SpecNo = Children(i).Data
   Case "SPECNOSEQ":z1412.SpecNoSeq = Children(i).Data
   Case "DATESOLE":z1412.DateSole = Children(i).Data
   Case "DATECUTTING":z1412.DateCutting = Children(i).Data
   Case "DATESTITCHING":z1412.DateStitching = Children(i).Data
   Case "DATESTOCKFIT":z1412.DateStockfit = Children(i).Data
   Case "DATEASSMBLY":z1412.DateAssmbly = Children(i).Data
   Case "DATESHIPPING":z1412.DateShipping = Children(i).Data
   Case "SEUNITMATERIAL":z1412.seUnitMaterial = Children(i).Data
   Case "CDUNITMATERIAL":z1412.cdUnitMaterial = Children(i).Data
   Case "SEUNITPACKING":z1412.seUnitPacking = Children(i).Data
   Case "CDUNITPACKING":z1412.cdUnitPacking = Children(i).Data
   Case "QTYORDER":z1412.QtyOrder = Children(i).Data
   Case "QTYJOB":z1412.QtyJob = Children(i).Data
   Case "QTYSOLE":z1412.QtySole = Children(i).Data
   Case "QTYCUTTING":z1412.QtyCutting = Children(i).Data
   Case "QTYSTITCHING":z1412.QtyStitching = Children(i).Data
   Case "QTYSTOCKFIT":z1412.QtyStockfit = Children(i).Data
   Case "QTYASSEMBLY":z1412.QtyAssembly = Children(i).Data
   Case "QTYPACKING":z1412.QtyPacking = Children(i).Data
   Case "QTYINBOUND":z1412.QtyInbound = Children(i).Data
   Case "QTYSHIPPING":z1412.QtyShipping = Children(i).Data
   Case "DATEINSERT":z1412.DateInsert = Children(i).Data
   Case "INCHARGEINSERT":z1412.InchargeInsert = Children(i).Data
   Case "DATEUPDATE":z1412.DateUpdate = Children(i).Data
   Case "INCHARGEUPDATE":z1412.InchargeUpdate = Children(i).Data
   Case "INCHARGESALES":z1412.InchargeSales = Children(i).Data
   Case "INCHARGEPPC":z1412.InchargePPC = Children(i).Data
   Case "TOTALQTY":z1412.TotalQty = Children(i).Data
   Case "TOTALAMT":z1412.TotalAMT = Children(i).Data
   Case "TOTALCOST":z1412.TotalCost = Children(i).Data
   Case "TOTALPROFIT":z1412.TotalProfit = Children(i).Data
   Case "TOTALAMTEX":z1412.TotalAMTEX = Children(i).Data
   Case "TOTALAMTVND":z1412.TotalAMTVND = Children(i).Data
   Case "TOTALCOSTEX":z1412.TotalCostEX = Children(i).Data
   Case "TOTALCOSTVND":z1412.TotalCostVND = Children(i).Data
   Case "TOTALPROFITEX":z1412.TotalProfitEX = Children(i).Data
   Case "TOTALPROFITVND":z1412.TotalProfitVND = Children(i).Data
   Case "ATTACHID":z1412.AttachID = Children(i).Data
   Case "ORDERNOREF":z1412.OrderNoRef = Children(i).Data
   Case "ORDERNOSEQREF":z1412.OrderNoSeqRef = Children(i).Data
   Case "REMARK":z1412.Remark = Children(i).Data
   Case "REMARKORDER":z1412.RemarkOrder = Children(i).Data
   Case "REMARKCUSTOMER":z1412.RemarkCustomer = Children(i).Data
   Case "REMARKOTHER":z1412.RemarkOther = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K1412_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K1412_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z1412 As T1412_AREA, Job as String, CheckClear as Boolean, ORDERNO AS String, ORDERNOSEQ AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K1412_MOVE = False

Try
    If READ_PFK1412(ORDERNO, ORDERNOSEQ) = True Then
                z1412 = D1412
		K1412_MOVE = True
		else
	If CheckClear  = True then z1412 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK1412")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "ORDERNO":z1412.OrderNo = Children(i).Code
   Case "ORDERNOSEQ":z1412.OrderNoSeq = Children(i).Code
   Case "SHOESCODE":z1412.ShoesCode = Children(i).Code
   Case "FACPO":z1412.FacPO = Children(i).Code
   Case "SLNOSYS":z1412.SLNoSys = Children(i).Code
   Case "SLNO":z1412.SLNo = Children(i).Code
   Case "PONO":z1412.PONO = Children(i).Code
   Case "CPONO":z1412.CPONO = Children(i).Code
   Case "CUSTOMERCODE":z1412.CustomerCode = Children(i).Code
   Case "CUSTOMERNAME":z1412.CustomerName = Children(i).Code
   Case "COUNTRY":z1412.Country = Children(i).Code
   Case "DESTINATION":z1412.Destination = Children(i).Code
   Case "FINALSHOP":z1412.FinalShop = Children(i).Code
   Case "PKO":z1412.PKO = Children(i).Code
   Case "DATEPO":z1412.DatePO = Children(i).Code
   Case "JBCARD":z1412.JbCard = Children(i).Code
   Case "SEPACKINGCODE":z1412.sePackingCode = Children(i).Code
   Case "CDPACKINGCODE":z1412.cdPackingCode = Children(i).Code
   Case "SESPECSTATUS":z1412.seSpecStatus = Children(i).Code
   Case "CDSPECSTATUS":z1412.cdSpecStatus = Children(i).Code
   Case "SIZERANGE":z1412.SizeRange = Children(i).Code
   Case "SPECITICSIZE":z1412.SpeciticSize = Children(i).Code
   Case "DATESIZE":z1412.DateSize = Children(i).Code
   Case "ORDERDETAILSTATUS":z1412.OrderDetailStatus = Children(i).Code
   Case "DATEORDER":z1412.DateOrder = Children(i).Code
   Case "DATEAPPROVAL":z1412.DateApproval = Children(i).Code
   Case "DATECANCEL":z1412.DateCancel = Children(i).Code
   Case "DATECOMPLETE":z1412.DateComplete = Children(i).Code
   Case "DATEPENDING":z1412.DatePending = Children(i).Code
   Case "DATEPENDING2":z1412.DatePending2 = Children(i).Code
   Case "DATEEXCHANGEPRICE":z1412.DateExchangePrice = Children(i).Code
   Case "PRICEEXCHANGE":z1412.PriceExchange = Children(i).Code
   Case "PRICEORDER":z1412.PriceOrder = Children(i).Code
   Case "SEUNITPRICE":z1412.seUnitPrice = Children(i).Code
   Case "CDUNITPRICE":z1412.cdUnitPrice = Children(i).Code
   Case "UNITPRICE":z1412.UnitPrice = Children(i).Code
   Case "PRICEORDEREX":z1412.PriceOrderEX = Children(i).Code
   Case "PRICEORDERVND":z1412.PriceOrderVND = Children(i).Code
   Case "DATEDELIVERY":z1412.Datedelivery = Children(i).Code
   Case "DATETRANSFER":z1412.DateTransfer = Children(i).Code
   Case "ACCEPTEDORDER":z1412.AcceptedOrder = Children(i).Code
   Case "MATERIALSTATUS":z1412.MaterialStatus = Children(i).Code
   Case "SOLESTATUS":z1412.SoleStatus = Children(i).Code
   Case "DATELABLE":z1412.DateLable = Children(i).Code
   Case "DATEPATTERN":z1412.DatePattern = Children(i).Code
   Case "DATEMATERIAL":z1412.DateMaterial = Children(i).Code
   Case "DATEPLANNING":z1412.DatePlanning = Children(i).Code
   Case "DATERND":z1412.DateRnD = Children(i).Code
   Case "DATEFITTING":z1412.DateFitting = Children(i).Code
   Case "INCHARGEFITTING":z1412.InchargeFitting = Children(i).Code
   Case "CHECKFITTING":z1412.CheckFitting = Children(i).Code
   Case "DATETESTING":z1412.DateTesting = Children(i).Code
   Case "INCHARGETESTING":z1412.InchargeTesting = Children(i).Code
   Case "CHECKTESTING":z1412.CheckTesting = Children(i).Code
   Case "CHECKCONFIRM":z1412.CheckConfirm = Children(i).Code
   Case "DATECONFIRM":z1412.DateConfirm = Children(i).Code
   Case "SPECNO":z1412.SpecNo = Children(i).Code
   Case "SPECNOSEQ":z1412.SpecNoSeq = Children(i).Code
   Case "DATESOLE":z1412.DateSole = Children(i).Code
   Case "DATECUTTING":z1412.DateCutting = Children(i).Code
   Case "DATESTITCHING":z1412.DateStitching = Children(i).Code
   Case "DATESTOCKFIT":z1412.DateStockfit = Children(i).Code
   Case "DATEASSMBLY":z1412.DateAssmbly = Children(i).Code
   Case "DATESHIPPING":z1412.DateShipping = Children(i).Code
   Case "SEUNITMATERIAL":z1412.seUnitMaterial = Children(i).Code
   Case "CDUNITMATERIAL":z1412.cdUnitMaterial = Children(i).Code
   Case "SEUNITPACKING":z1412.seUnitPacking = Children(i).Code
   Case "CDUNITPACKING":z1412.cdUnitPacking = Children(i).Code
   Case "QTYORDER":z1412.QtyOrder = Children(i).Code
   Case "QTYJOB":z1412.QtyJob = Children(i).Code
   Case "QTYSOLE":z1412.QtySole = Children(i).Code
   Case "QTYCUTTING":z1412.QtyCutting = Children(i).Code
   Case "QTYSTITCHING":z1412.QtyStitching = Children(i).Code
   Case "QTYSTOCKFIT":z1412.QtyStockfit = Children(i).Code
   Case "QTYASSEMBLY":z1412.QtyAssembly = Children(i).Code
   Case "QTYPACKING":z1412.QtyPacking = Children(i).Code
   Case "QTYINBOUND":z1412.QtyInbound = Children(i).Code
   Case "QTYSHIPPING":z1412.QtyShipping = Children(i).Code
   Case "DATEINSERT":z1412.DateInsert = Children(i).Code
   Case "INCHARGEINSERT":z1412.InchargeInsert = Children(i).Code
   Case "DATEUPDATE":z1412.DateUpdate = Children(i).Code
   Case "INCHARGEUPDATE":z1412.InchargeUpdate = Children(i).Code
   Case "INCHARGESALES":z1412.InchargeSales = Children(i).Code
   Case "INCHARGEPPC":z1412.InchargePPC = Children(i).Code
   Case "TOTALQTY":z1412.TotalQty = Children(i).Code
   Case "TOTALAMT":z1412.TotalAMT = Children(i).Code
   Case "TOTALCOST":z1412.TotalCost = Children(i).Code
   Case "TOTALPROFIT":z1412.TotalProfit = Children(i).Code
   Case "TOTALAMTEX":z1412.TotalAMTEX = Children(i).Code
   Case "TOTALAMTVND":z1412.TotalAMTVND = Children(i).Code
   Case "TOTALCOSTEX":z1412.TotalCostEX = Children(i).Code
   Case "TOTALCOSTVND":z1412.TotalCostVND = Children(i).Code
   Case "TOTALPROFITEX":z1412.TotalProfitEX = Children(i).Code
   Case "TOTALPROFITVND":z1412.TotalProfitVND = Children(i).Code
   Case "ATTACHID":z1412.AttachID = Children(i).Code
   Case "ORDERNOREF":z1412.OrderNoRef = Children(i).Code
   Case "ORDERNOSEQREF":z1412.OrderNoSeqRef = Children(i).Code
   Case "REMARK":z1412.Remark = Children(i).Code
   Case "REMARKORDER":z1412.RemarkOrder = Children(i).Code
   Case "REMARKCUSTOMER":z1412.RemarkCustomer = Children(i).Code
   Case "REMARKOTHER":z1412.RemarkOther = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "ORDERNO":z1412.OrderNo = Children(i).Data
   Case "ORDERNOSEQ":z1412.OrderNoSeq = Children(i).Data
   Case "SHOESCODE":z1412.ShoesCode = Children(i).Data
   Case "FACPO":z1412.FacPO = Children(i).Data
   Case "SLNOSYS":z1412.SLNoSys = Children(i).Data
   Case "SLNO":z1412.SLNo = Children(i).Data
   Case "PONO":z1412.PONO = Children(i).Data
   Case "CPONO":z1412.CPONO = Children(i).Data
   Case "CUSTOMERCODE":z1412.CustomerCode = Children(i).Data
   Case "CUSTOMERNAME":z1412.CustomerName = Children(i).Data
   Case "COUNTRY":z1412.Country = Children(i).Data
   Case "DESTINATION":z1412.Destination = Children(i).Data
   Case "FINALSHOP":z1412.FinalShop = Children(i).Data
   Case "PKO":z1412.PKO = Children(i).Data
   Case "DATEPO":z1412.DatePO = Children(i).Data
   Case "JBCARD":z1412.JbCard = Children(i).Data
   Case "SEPACKINGCODE":z1412.sePackingCode = Children(i).Data
   Case "CDPACKINGCODE":z1412.cdPackingCode = Children(i).Data
   Case "SESPECSTATUS":z1412.seSpecStatus = Children(i).Data
   Case "CDSPECSTATUS":z1412.cdSpecStatus = Children(i).Data
   Case "SIZERANGE":z1412.SizeRange = Children(i).Data
   Case "SPECITICSIZE":z1412.SpeciticSize = Children(i).Data
   Case "DATESIZE":z1412.DateSize = Children(i).Data
   Case "ORDERDETAILSTATUS":z1412.OrderDetailStatus = Children(i).Data
   Case "DATEORDER":z1412.DateOrder = Children(i).Data
   Case "DATEAPPROVAL":z1412.DateApproval = Children(i).Data
   Case "DATECANCEL":z1412.DateCancel = Children(i).Data
   Case "DATECOMPLETE":z1412.DateComplete = Children(i).Data
   Case "DATEPENDING":z1412.DatePending = Children(i).Data
   Case "DATEPENDING2":z1412.DatePending2 = Children(i).Data
   Case "DATEEXCHANGEPRICE":z1412.DateExchangePrice = Children(i).Data
   Case "PRICEEXCHANGE":z1412.PriceExchange = Children(i).Data
   Case "PRICEORDER":z1412.PriceOrder = Children(i).Data
   Case "SEUNITPRICE":z1412.seUnitPrice = Children(i).Data
   Case "CDUNITPRICE":z1412.cdUnitPrice = Children(i).Data
   Case "UNITPRICE":z1412.UnitPrice = Children(i).Data
   Case "PRICEORDEREX":z1412.PriceOrderEX = Children(i).Data
   Case "PRICEORDERVND":z1412.PriceOrderVND = Children(i).Data
   Case "DATEDELIVERY":z1412.Datedelivery = Children(i).Data
   Case "DATETRANSFER":z1412.DateTransfer = Children(i).Data
   Case "ACCEPTEDORDER":z1412.AcceptedOrder = Children(i).Data
   Case "MATERIALSTATUS":z1412.MaterialStatus = Children(i).Data
   Case "SOLESTATUS":z1412.SoleStatus = Children(i).Data
   Case "DATELABLE":z1412.DateLable = Children(i).Data
   Case "DATEPATTERN":z1412.DatePattern = Children(i).Data
   Case "DATEMATERIAL":z1412.DateMaterial = Children(i).Data
   Case "DATEPLANNING":z1412.DatePlanning = Children(i).Data
   Case "DATERND":z1412.DateRnD = Children(i).Data
   Case "DATEFITTING":z1412.DateFitting = Children(i).Data
   Case "INCHARGEFITTING":z1412.InchargeFitting = Children(i).Data
   Case "CHECKFITTING":z1412.CheckFitting = Children(i).Data
   Case "DATETESTING":z1412.DateTesting = Children(i).Data
   Case "INCHARGETESTING":z1412.InchargeTesting = Children(i).Data
   Case "CHECKTESTING":z1412.CheckTesting = Children(i).Data
   Case "CHECKCONFIRM":z1412.CheckConfirm = Children(i).Data
   Case "DATECONFIRM":z1412.DateConfirm = Children(i).Data
   Case "SPECNO":z1412.SpecNo = Children(i).Data
   Case "SPECNOSEQ":z1412.SpecNoSeq = Children(i).Data
   Case "DATESOLE":z1412.DateSole = Children(i).Data
   Case "DATECUTTING":z1412.DateCutting = Children(i).Data
   Case "DATESTITCHING":z1412.DateStitching = Children(i).Data
   Case "DATESTOCKFIT":z1412.DateStockfit = Children(i).Data
   Case "DATEASSMBLY":z1412.DateAssmbly = Children(i).Data
   Case "DATESHIPPING":z1412.DateShipping = Children(i).Data
   Case "SEUNITMATERIAL":z1412.seUnitMaterial = Children(i).Data
   Case "CDUNITMATERIAL":z1412.cdUnitMaterial = Children(i).Data
   Case "SEUNITPACKING":z1412.seUnitPacking = Children(i).Data
   Case "CDUNITPACKING":z1412.cdUnitPacking = Children(i).Data
   Case "QTYORDER":z1412.QtyOrder = Children(i).Data
   Case "QTYJOB":z1412.QtyJob = Children(i).Data
   Case "QTYSOLE":z1412.QtySole = Children(i).Data
   Case "QTYCUTTING":z1412.QtyCutting = Children(i).Data
   Case "QTYSTITCHING":z1412.QtyStitching = Children(i).Data
   Case "QTYSTOCKFIT":z1412.QtyStockfit = Children(i).Data
   Case "QTYASSEMBLY":z1412.QtyAssembly = Children(i).Data
   Case "QTYPACKING":z1412.QtyPacking = Children(i).Data
   Case "QTYINBOUND":z1412.QtyInbound = Children(i).Data
   Case "QTYSHIPPING":z1412.QtyShipping = Children(i).Data
   Case "DATEINSERT":z1412.DateInsert = Children(i).Data
   Case "INCHARGEINSERT":z1412.InchargeInsert = Children(i).Data
   Case "DATEUPDATE":z1412.DateUpdate = Children(i).Data
   Case "INCHARGEUPDATE":z1412.InchargeUpdate = Children(i).Data
   Case "INCHARGESALES":z1412.InchargeSales = Children(i).Data
   Case "INCHARGEPPC":z1412.InchargePPC = Children(i).Data
   Case "TOTALQTY":z1412.TotalQty = Children(i).Data
   Case "TOTALAMT":z1412.TotalAMT = Children(i).Data
   Case "TOTALCOST":z1412.TotalCost = Children(i).Data
   Case "TOTALPROFIT":z1412.TotalProfit = Children(i).Data
   Case "TOTALAMTEX":z1412.TotalAMTEX = Children(i).Data
   Case "TOTALAMTVND":z1412.TotalAMTVND = Children(i).Data
   Case "TOTALCOSTEX":z1412.TotalCostEX = Children(i).Data
   Case "TOTALCOSTVND":z1412.TotalCostVND = Children(i).Data
   Case "TOTALPROFITEX":z1412.TotalProfitEX = Children(i).Data
   Case "TOTALPROFITVND":z1412.TotalProfitVND = Children(i).Data
   Case "ATTACHID":z1412.AttachID = Children(i).Data
   Case "ORDERNOREF":z1412.OrderNoRef = Children(i).Data
   Case "ORDERNOSEQREF":z1412.OrderNoSeqRef = Children(i).Data
   Case "REMARK":z1412.Remark = Children(i).Data
   Case "REMARKORDER":z1412.RemarkOrder = Children(i).Data
   Case "REMARKCUSTOMER":z1412.RemarkCustomer = Children(i).Data
   Case "REMARKOTHER":z1412.RemarkOther = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K1412_MOVE",vbCritical)
End Try
End Function 
    
End Module 
