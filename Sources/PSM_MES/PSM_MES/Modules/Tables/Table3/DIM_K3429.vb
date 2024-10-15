'=========================================================================================================================================================
'   TABLE : (PFK3429)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K3429

Structure T3429_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	PayableNo	 AS String	'			char(9)		*
Public 	PayableNoSeq	 AS Double	'			decimal		*
Public 	CheckTypePayable	 AS String	'			char(1)
Public 	FactOrderNo	 AS String	'			char(9)
Public 	FactOrderSeq	 AS Double	'			decimal
Public 	DienGiai	 AS String	'			nvarchar(200)
Public 	DienGiai2	 AS String	'			nvarchar(50)
Public 	SeriInvoice	 AS String	'			nvarchar(50)
Public 	PurchaseInvoice1	 AS String	'			nvarchar(50)
Public 	DateInvoice	 AS String	'			char(8)
Public 	MaterialInBoundNo	 AS String	'			char(9)
Public 	MaterialInBoundSeq	 AS String	'			char(3)
Public 	seSite	 AS String	'			char(3)
Public 	cdSite	 AS String	'			char(3)
Public 	seDepartment	 AS String	'			char(3)
Public 	cdDepartment	 AS String	'			char(3)
Public 	seFactory	 AS String	'			char(3)
Public 	cdFactory	 AS String	'			char(3)
Public 	seLineProd	 AS String	'			char(3)
Public 	cdLineProd	 AS String	'			char(3)
Public 	seSubProcess	 AS String	'			char(3)
Public 	cdSubProcess	 AS String	'			char(3)
Public 	CustomerSupplier	 AS String	'			char(6)
Public 	Dseq	 AS Double	'			decimal
Public 	AutokeyK3011	 AS Double	'			decimal
Public 	CheckRelationType	 AS String	'			char(1)
Public 	MaterialCode	 AS String	'			char(6)
Public 	Specification	 AS String	'			nvarchar(500)
Public 	Width	 AS String	'			nvarchar(50)
Public 	Height	 AS String	'			nvarchar(50)
Public 	SizeNo	 AS String	'			char(2)
Public 	SizeName	 AS String	'			nvarchar(50)
Public 	ColorCode	 AS String	'			char(6)
Public 	ColorName	 AS String	'			nvarchar(200)
Public 	seOrigin	 AS String	'			char(3)
Public 	cdOrigin	 AS String	'			char(3)
Public 	MaterialCheck	 AS String	'			char(1)
Public 	seUnitPrice	 AS String	'			char(3)
Public 	cdUnitPrice	 AS String	'			char(3)
Public 	seTax	 AS String	'			char(3)
Public 	cdTax	 AS String	'			char(3)
Public 	seUnitMaterial	 AS String	'			char(3)
Public 	cdUnitMaterial	 AS String	'			char(3)
Public 	seUnitPacking	 AS String	'			char(3)
Public 	cdUnitPacking	 AS String	'			char(3)
Public 	UnitBaseCheck	 AS String	'			char(1)
Public 	TypeDiscount	 AS String	'			char(1)
Public 	PerDiscount	 AS Double	'			decimal
Public 	AmtDiscount	 AS Double	'			decimal
Public 	QtyBasic	 AS Double	'			decimal
Public 	PricePurchasing	 AS Double	'			decimal
Public 	PriceMarket	 AS Double	'			decimal
Public 	PriceExchange	 AS Double	'			decimal
Public 	PriceExchangeAP	 AS Double	'			decimal
Public 	DateExchange	 AS String	'			char(8)
Public 	PricePurchasingEX	 AS Double	'			decimal
Public 	PriceMarketEX	 AS Double	'			decimal
Public 	PricePurchasingVND	 AS Double	'			decimal
Public 	PriceMarketVND	 AS Double	'			decimal
Public 	AmountPurchasingEX	 AS Double	'			decimal
Public 	AmountPurchasingVND	 AS Double	'			decimal
Public 	AmountTaxEX	 AS Double	'			decimal
Public 	AmountTaxVND	 AS Double	'			decimal
Public 	PctExpense	 AS Double	'			decimal
Public 	AmountExpenseEX	 AS Double	'			decimal
Public 	AmountExpensVND	 AS Double	'			decimal
Public 	seTax1	 AS String	'			char(3)
Public 	cdTax1	 AS String	'			char(3)
Public 	PerTax1	 AS Double	'			decimal
        Public AmountTax1 As Double  '			decimal

Public 	seTax2	 AS String	'			char(3)
Public 	cdTax2	 AS String	'			char(3)
Public 	PerTax2	 AS Double	'			decimal
Public 	AmountTax2	 AS Double	'			decimal
Public 	seTax3	 AS String	'			char(3)
Public 	cdTax3	 AS String	'			char(3)
Public 	PerTax3	 AS Double	'			decimal
Public 	AmountTax3	 AS Double	'			decimal
Public 	QtyPurchasing	 AS Double	'			decimal
Public 	PackPurchasing	 AS Double	'			decimal
Public 	QtyWarehouse	 AS Double	'			decimal
Public 	PackWarehouse	 AS Double	'			decimal
Public 	QtyInbound	 AS Double	'			decimal
Public 	PackInbound	 AS Double	'			decimal
Public 	QtyOutbound	 AS Double	'			decimal
Public 	PackOutbound	 AS Double	'			decimal
Public 	AmountEX	 AS Double	'			decimal
Public 	AmountVND	 AS Double	'			decimal
Public 	AmountInBoundEX	 AS Double	'			decimal
        Public AmountInBoundVND As Double  '			decimal
        Public AmountFCT As Double  '			decimal
        Public AmountFCT2 As Double  '			decimal

Public 	DateDelivery	 AS String	'			char(8)
Public 	DateStart	 AS String	'			char(8)
Public 	DateFinish	 AS String	'			char(8)
Public 	CheckPurchasing	 AS String	'			char(1)
Public 	DateAccept	 AS String	'			char(8)
Public 	DatePosted	 AS String	'			char(8)
Public 	IsPosted	 AS String	'			char(1)
Public 	DateComplete	 AS String	'			char(8)
Public 	DateApproval	 AS String	'			char(8)
Public 	DateCancel	 AS String	'			char(8)
Public 	CheckComplete	 AS String	'			char(1)
Public 	PurchasingOrderNo	 AS String	'			char(9)
Public 	PurchasingOrderSeq	 AS Double	'			decimal
Public 	JobCardWorking	 AS String	'			char(9)
Public 	JobCardWorkingSeq	 AS String	'			char(3)
Public 	JobCardType	 AS String	'			char(1)
Public 	SalesOrderNo	 AS String	'			char(9)
Public 	SalesOrderSeq	 AS String	'			char(2)
Public 	SalesOrderSno	 AS String	'			char(2)
Public 	OrderNo	 AS String	'			char(9)
Public 	OrderNoSeq	 AS String	'			char(3)
Public 	Remark	 AS String	'			nvarchar(500)
'=========================================================================================================================================================
End structure

Public D3429 As T3429_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK3429(PAYABLENO AS String, PAYABLENOSEQ AS Double) As Boolean
    READ_PFK3429 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK3429 "
    SQL = SQL & " WHERE K3429_PayableNo		 = '" & PayableNo & "' " 
    SQL = SQL & "   AND K3429_PayableNoSeq		 =  " & PayableNoSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D3429_CLEAR: GoTo SKIP_READ_PFK3429
                
    Call K3429_MOVE(rd)
    READ_PFK3429 = True

SKIP_READ_PFK3429:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK3429",vbCritical)
 End Try
    End Function

    Public Function READ_PFK3429_CNT(PAYABLENO As String) As Boolean
        READ_PFK3429_CNT = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT TOP 1 * FROM PFK3429 "
            SQL = SQL & " WHERE K3429_PayableNo   = '" & PAYABLENO & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D3429_CLEAR() : GoTo SKIP_READ_PFK3429

            Call K3429_MOVE(rd)
            READ_PFK3429_CNT = True

SKIP_READ_PFK3429:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK3429", vbCritical)
        End Try
    End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK3429(PAYABLENO AS String, PAYABLENOSEQ AS Double, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK3429 "
    SQL = SQL & " WHERE K3429_PayableNo		 = '" & PayableNo & "' " 
    SQL = SQL & "   AND K3429_PayableNoSeq		 =  " & PayableNoSeq & "  " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK3429",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK3429(z3429 As T3429_AREA) As Boolean
    WRITE_PFK3429 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z3429)
 
    SQL = " INSERT INTO PFK3429 "
    SQL = SQL & " ( "
    SQL = SQL & " K3429_PayableNo," 
    SQL = SQL & " K3429_PayableNoSeq," 
    SQL = SQL & " K3429_CheckTypePayable," 
    SQL = SQL & " K3429_FactOrderNo," 
    SQL = SQL & " K3429_FactOrderSeq," 
    SQL = SQL & " K3429_DienGiai," 
    SQL = SQL & " K3429_DienGiai2," 
    SQL = SQL & " K3429_SeriInvoice," 
    SQL = SQL & " K3429_PurchaseInvoice1," 
    SQL = SQL & " K3429_DateInvoice," 
    SQL = SQL & " K3429_MaterialInBoundNo," 
    SQL = SQL & " K3429_MaterialInBoundSeq," 
    SQL = SQL & " K3429_seSite," 
    SQL = SQL & " K3429_cdSite," 
    SQL = SQL & " K3429_seDepartment," 
    SQL = SQL & " K3429_cdDepartment," 
    SQL = SQL & " K3429_seFactory," 
    SQL = SQL & " K3429_cdFactory," 
    SQL = SQL & " K3429_seLineProd," 
    SQL = SQL & " K3429_cdLineProd," 
    SQL = SQL & " K3429_seSubProcess," 
    SQL = SQL & " K3429_cdSubProcess," 
    SQL = SQL & " K3429_CustomerSupplier," 
    SQL = SQL & " K3429_Dseq," 
    SQL = SQL & " K3429_AutokeyK3011," 
    SQL = SQL & " K3429_CheckRelationType," 
    SQL = SQL & " K3429_MaterialCode," 
    SQL = SQL & " K3429_Specification," 
    SQL = SQL & " K3429_Width," 
    SQL = SQL & " K3429_Height," 
    SQL = SQL & " K3429_SizeNo," 
    SQL = SQL & " K3429_SizeName," 
    SQL = SQL & " K3429_ColorCode," 
    SQL = SQL & " K3429_ColorName," 
    SQL = SQL & " K3429_seOrigin," 
    SQL = SQL & " K3429_cdOrigin," 
    SQL = SQL & " K3429_MaterialCheck," 
    SQL = SQL & " K3429_seUnitPrice," 
    SQL = SQL & " K3429_cdUnitPrice," 
    SQL = SQL & " K3429_seTax," 
    SQL = SQL & " K3429_cdTax," 
    SQL = SQL & " K3429_seUnitMaterial," 
    SQL = SQL & " K3429_cdUnitMaterial," 
    SQL = SQL & " K3429_seUnitPacking," 
    SQL = SQL & " K3429_cdUnitPacking," 
    SQL = SQL & " K3429_UnitBaseCheck," 
    SQL = SQL & " K3429_TypeDiscount," 
    SQL = SQL & " K3429_PerDiscount," 
    SQL = SQL & " K3429_AmtDiscount," 
    SQL = SQL & " K3429_QtyBasic," 
    SQL = SQL & " K3429_PricePurchasing," 
    SQL = SQL & " K3429_PriceMarket," 
    SQL = SQL & " K3429_PriceExchange," 
    SQL = SQL & " K3429_PriceExchangeAP," 
    SQL = SQL & " K3429_DateExchange," 
    SQL = SQL & " K3429_PricePurchasingEX," 
    SQL = SQL & " K3429_PriceMarketEX," 
    SQL = SQL & " K3429_PricePurchasingVND," 
    SQL = SQL & " K3429_PriceMarketVND," 
    SQL = SQL & " K3429_AmountPurchasingEX," 
    SQL = SQL & " K3429_AmountPurchasingVND," 
    SQL = SQL & " K3429_AmountTaxEX," 
    SQL = SQL & " K3429_AmountTaxVND," 
    SQL = SQL & " K3429_PctExpense," 
    SQL = SQL & " K3429_AmountExpenseEX," 
    SQL = SQL & " K3429_AmountExpensVND," 
    SQL = SQL & " K3429_seTax1," 
    SQL = SQL & " K3429_cdTax1," 
    SQL = SQL & " K3429_PerTax1," 
    SQL = SQL & " K3429_AmountTax1," 
    SQL = SQL & " K3429_seTax2," 
    SQL = SQL & " K3429_cdTax2," 
    SQL = SQL & " K3429_PerTax2," 
    SQL = SQL & " K3429_AmountTax2," 
    SQL = SQL & " K3429_seTax3," 
    SQL = SQL & " K3429_cdTax3," 
    SQL = SQL & " K3429_PerTax3," 
    SQL = SQL & " K3429_AmountTax3," 
    SQL = SQL & " K3429_QtyPurchasing," 
    SQL = SQL & " K3429_PackPurchasing," 
    SQL = SQL & " K3429_QtyWarehouse," 
    SQL = SQL & " K3429_PackWarehouse," 
    SQL = SQL & " K3429_QtyInbound," 
    SQL = SQL & " K3429_PackInbound," 
    SQL = SQL & " K3429_QtyOutbound," 
    SQL = SQL & " K3429_PackOutbound," 
    SQL = SQL & " K3429_AmountEX," 
    SQL = SQL & " K3429_AmountVND," 
    SQL = SQL & " K3429_AmountInBoundEX," 
            SQL = SQL & " K3429_AmountInBoundVND,"
            SQL = SQL & " K3429_AMOUNTFCT,"
            SQL = SQL & " K3429_AMOUNTFCT2,"
    SQL = SQL & " K3429_DateDelivery," 
    SQL = SQL & " K3429_DateStart," 
    SQL = SQL & " K3429_DateFinish," 
    SQL = SQL & " K3429_CheckPurchasing," 
    SQL = SQL & " K3429_DateAccept," 
    SQL = SQL & " K3429_DatePosted," 
    SQL = SQL & " K3429_IsPosted," 
    SQL = SQL & " K3429_DateComplete," 
    SQL = SQL & " K3429_DateApproval," 
    SQL = SQL & " K3429_DateCancel," 
    SQL = SQL & " K3429_CheckComplete," 
    SQL = SQL & " K3429_PurchasingOrderNo," 
    SQL = SQL & " K3429_PurchasingOrderSeq," 
    SQL = SQL & " K3429_JobCardWorking," 
    SQL = SQL & " K3429_JobCardWorkingSeq," 
    SQL = SQL & " K3429_JobCardType," 
    SQL = SQL & " K3429_SalesOrderNo," 
    SQL = SQL & " K3429_SalesOrderSeq," 
    SQL = SQL & " K3429_SalesOrderSno," 
    SQL = SQL & " K3429_OrderNo," 
    SQL = SQL & " K3429_OrderNoSeq," 
    SQL = SQL & " K3429_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z3429.PayableNo) & "', "  
    SQL = SQL & "   " & FormatSQL(z3429.PayableNoSeq) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z3429.CheckTypePayable) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3429.FactOrderNo) & "', "  
    SQL = SQL & "   " & FormatSQL(z3429.FactOrderSeq) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z3429.DienGiai) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3429.DienGiai2) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3429.SeriInvoice) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3429.PurchaseInvoice1) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3429.DateInvoice) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3429.MaterialInBoundNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3429.MaterialInBoundSeq) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3429.seSite) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3429.cdSite) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3429.seDepartment) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3429.cdDepartment) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3429.seFactory) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3429.cdFactory) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3429.seLineProd) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3429.cdLineProd) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3429.seSubProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3429.cdSubProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3429.CustomerSupplier) & "', "  
    SQL = SQL & "   " & FormatSQL(z3429.Dseq) & ", "  
    SQL = SQL & "   " & FormatSQL(z3429.AutokeyK3011) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z3429.CheckRelationType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3429.MaterialCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3429.Specification) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3429.Width) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3429.Height) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3429.SizeNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3429.SizeName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3429.ColorCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3429.ColorName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3429.seOrigin) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3429.cdOrigin) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3429.MaterialCheck) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3429.seUnitPrice) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3429.cdUnitPrice) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3429.seTax) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3429.cdTax) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3429.seUnitMaterial) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3429.cdUnitMaterial) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3429.seUnitPacking) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3429.cdUnitPacking) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3429.UnitBaseCheck) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3429.TypeDiscount) & "', "  
    SQL = SQL & "   " & FormatSQL(z3429.PerDiscount) & ", "  
    SQL = SQL & "   " & FormatSQL(z3429.AmtDiscount) & ", "  
    SQL = SQL & "   " & FormatSQL(z3429.QtyBasic) & ", "  
    SQL = SQL & "   " & FormatSQL(z3429.PricePurchasing) & ", "  
    SQL = SQL & "   " & FormatSQL(z3429.PriceMarket) & ", "  
    SQL = SQL & "   " & FormatSQL(z3429.PriceExchange) & ", "  
    SQL = SQL & "   " & FormatSQL(z3429.PriceExchangeAP) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z3429.DateExchange) & "', "  
    SQL = SQL & "   " & FormatSQL(z3429.PricePurchasingEX) & ", "  
    SQL = SQL & "   " & FormatSQL(z3429.PriceMarketEX) & ", "  
    SQL = SQL & "   " & FormatSQL(z3429.PricePurchasingVND) & ", "  
    SQL = SQL & "   " & FormatSQL(z3429.PriceMarketVND) & ", "  
    SQL = SQL & "   " & FormatSQL(z3429.AmountPurchasingEX) & ", "  
    SQL = SQL & "   " & FormatSQL(z3429.AmountPurchasingVND) & ", "  
    SQL = SQL & "   " & FormatSQL(z3429.AmountTaxEX) & ", "  
    SQL = SQL & "   " & FormatSQL(z3429.AmountTaxVND) & ", "  
    SQL = SQL & "   " & FormatSQL(z3429.PctExpense) & ", "  
    SQL = SQL & "   " & FormatSQL(z3429.AmountExpenseEX) & ", "  
    SQL = SQL & "   " & FormatSQL(z3429.AmountExpensVND) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z3429.seTax1) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3429.cdTax1) & "', "  
    SQL = SQL & "   " & FormatSQL(z3429.PerTax1) & ", "  
    SQL = SQL & "   " & FormatSQL(z3429.AmountTax1) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z3429.seTax2) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3429.cdTax2) & "', "  
    SQL = SQL & "   " & FormatSQL(z3429.PerTax2) & ", "  
    SQL = SQL & "   " & FormatSQL(z3429.AmountTax2) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z3429.seTax3) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3429.cdTax3) & "', "  
    SQL = SQL & "   " & FormatSQL(z3429.PerTax3) & ", "  
    SQL = SQL & "   " & FormatSQL(z3429.AmountTax3) & ", "  
    SQL = SQL & "   " & FormatSQL(z3429.QtyPurchasing) & ", "  
    SQL = SQL & "   " & FormatSQL(z3429.PackPurchasing) & ", "  
    SQL = SQL & "   " & FormatSQL(z3429.QtyWarehouse) & ", "  
    SQL = SQL & "   " & FormatSQL(z3429.PackWarehouse) & ", "  
    SQL = SQL & "   " & FormatSQL(z3429.QtyInbound) & ", "  
    SQL = SQL & "   " & FormatSQL(z3429.PackInbound) & ", "  
    SQL = SQL & "   " & FormatSQL(z3429.QtyOutbound) & ", "  
    SQL = SQL & "   " & FormatSQL(z3429.PackOutbound) & ", "  
    SQL = SQL & "   " & FormatSQL(z3429.AmountEX) & ", "  
    SQL = SQL & "   " & FormatSQL(z3429.AmountVND) & ", "  
    SQL = SQL & "   " & FormatSQL(z3429.AmountInBoundEX) & ", "  
            SQL = SQL & "   " & FormatSQL(z3429.AmountInBoundVND) & ", "
            SQL = SQL & "   " & FormatSQL(z3429.AmountFCT) & ", "
            SQL = SQL & "   " & FormatSQL(z3429.AmountFCT2) & ", "
    SQL = SQL & "  N'" & FormatSQL(z3429.DateDelivery) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3429.DateStart) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3429.DateFinish) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3429.CheckPurchasing) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3429.DateAccept) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3429.DatePosted) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3429.IsPosted) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3429.DateComplete) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3429.DateApproval) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3429.DateCancel) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3429.CheckComplete) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3429.PurchasingOrderNo) & "', "  
    SQL = SQL & "   " & FormatSQL(z3429.PurchasingOrderSeq) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z3429.JobCardWorking) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3429.JobCardWorkingSeq) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3429.JobCardType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3429.SalesOrderNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3429.SalesOrderSeq) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3429.SalesOrderSno) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3429.OrderNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3429.OrderNoSeq) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3429.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK3429 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK3429",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK3429(z3429 As T3429_AREA) As Boolean
    REWRITE_PFK3429 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z3429)
   
    SQL = " UPDATE PFK3429 SET "
    SQL = SQL & "    K3429_CheckTypePayable      = N'" & FormatSQL(z3429.CheckTypePayable) & "', " 
    SQL = SQL & "    K3429_FactOrderNo      = N'" & FormatSQL(z3429.FactOrderNo) & "', " 
    SQL = SQL & "    K3429_FactOrderSeq      =  " & FormatSQL(z3429.FactOrderSeq) & ", " 
    SQL = SQL & "    K3429_DienGiai      = N'" & FormatSQL(z3429.DienGiai) & "', " 
    SQL = SQL & "    K3429_DienGiai2      = N'" & FormatSQL(z3429.DienGiai2) & "', " 
    SQL = SQL & "    K3429_SeriInvoice      = N'" & FormatSQL(z3429.SeriInvoice) & "', " 
    SQL = SQL & "    K3429_PurchaseInvoice1      = N'" & FormatSQL(z3429.PurchaseInvoice1) & "', " 
    SQL = SQL & "    K3429_DateInvoice      = N'" & FormatSQL(z3429.DateInvoice) & "', " 
    SQL = SQL & "    K3429_MaterialInBoundNo      = N'" & FormatSQL(z3429.MaterialInBoundNo) & "', " 
    SQL = SQL & "    K3429_MaterialInBoundSeq      = N'" & FormatSQL(z3429.MaterialInBoundSeq) & "', " 
    SQL = SQL & "    K3429_seSite      = N'" & FormatSQL(z3429.seSite) & "', " 
    SQL = SQL & "    K3429_cdSite      = N'" & FormatSQL(z3429.cdSite) & "', " 
    SQL = SQL & "    K3429_seDepartment      = N'" & FormatSQL(z3429.seDepartment) & "', " 
    SQL = SQL & "    K3429_cdDepartment      = N'" & FormatSQL(z3429.cdDepartment) & "', " 
    SQL = SQL & "    K3429_seFactory      = N'" & FormatSQL(z3429.seFactory) & "', " 
    SQL = SQL & "    K3429_cdFactory      = N'" & FormatSQL(z3429.cdFactory) & "', " 
    SQL = SQL & "    K3429_seLineProd      = N'" & FormatSQL(z3429.seLineProd) & "', " 
    SQL = SQL & "    K3429_cdLineProd      = N'" & FormatSQL(z3429.cdLineProd) & "', " 
    SQL = SQL & "    K3429_seSubProcess      = N'" & FormatSQL(z3429.seSubProcess) & "', " 
    SQL = SQL & "    K3429_cdSubProcess      = N'" & FormatSQL(z3429.cdSubProcess) & "', " 
    SQL = SQL & "    K3429_CustomerSupplier      = N'" & FormatSQL(z3429.CustomerSupplier) & "', " 
    SQL = SQL & "    K3429_Dseq      =  " & FormatSQL(z3429.Dseq) & ", " 
    SQL = SQL & "    K3429_AutokeyK3011      =  " & FormatSQL(z3429.AutokeyK3011) & ", " 
    SQL = SQL & "    K3429_CheckRelationType      = N'" & FormatSQL(z3429.CheckRelationType) & "', " 
    SQL = SQL & "    K3429_MaterialCode      = N'" & FormatSQL(z3429.MaterialCode) & "', " 
    SQL = SQL & "    K3429_Specification      = N'" & FormatSQL(z3429.Specification) & "', " 
    SQL = SQL & "    K3429_Width      = N'" & FormatSQL(z3429.Width) & "', " 
    SQL = SQL & "    K3429_Height      = N'" & FormatSQL(z3429.Height) & "', " 
    SQL = SQL & "    K3429_SizeNo      = N'" & FormatSQL(z3429.SizeNo) & "', " 
    SQL = SQL & "    K3429_SizeName      = N'" & FormatSQL(z3429.SizeName) & "', " 
    SQL = SQL & "    K3429_ColorCode      = N'" & FormatSQL(z3429.ColorCode) & "', " 
    SQL = SQL & "    K3429_ColorName      = N'" & FormatSQL(z3429.ColorName) & "', " 
    SQL = SQL & "    K3429_seOrigin      = N'" & FormatSQL(z3429.seOrigin) & "', " 
    SQL = SQL & "    K3429_cdOrigin      = N'" & FormatSQL(z3429.cdOrigin) & "', " 
    SQL = SQL & "    K3429_MaterialCheck      = N'" & FormatSQL(z3429.MaterialCheck) & "', " 
    SQL = SQL & "    K3429_seUnitPrice      = N'" & FormatSQL(z3429.seUnitPrice) & "', " 
    SQL = SQL & "    K3429_cdUnitPrice      = N'" & FormatSQL(z3429.cdUnitPrice) & "', " 
    SQL = SQL & "    K3429_seTax      = N'" & FormatSQL(z3429.seTax) & "', " 
    SQL = SQL & "    K3429_cdTax      = N'" & FormatSQL(z3429.cdTax) & "', " 
    SQL = SQL & "    K3429_seUnitMaterial      = N'" & FormatSQL(z3429.seUnitMaterial) & "', " 
    SQL = SQL & "    K3429_cdUnitMaterial      = N'" & FormatSQL(z3429.cdUnitMaterial) & "', " 
    SQL = SQL & "    K3429_seUnitPacking      = N'" & FormatSQL(z3429.seUnitPacking) & "', " 
    SQL = SQL & "    K3429_cdUnitPacking      = N'" & FormatSQL(z3429.cdUnitPacking) & "', " 
    SQL = SQL & "    K3429_UnitBaseCheck      = N'" & FormatSQL(z3429.UnitBaseCheck) & "', " 
    SQL = SQL & "    K3429_TypeDiscount      = N'" & FormatSQL(z3429.TypeDiscount) & "', " 
    SQL = SQL & "    K3429_PerDiscount      =  " & FormatSQL(z3429.PerDiscount) & ", " 
    SQL = SQL & "    K3429_AmtDiscount      =  " & FormatSQL(z3429.AmtDiscount) & ", " 
    SQL = SQL & "    K3429_QtyBasic      =  " & FormatSQL(z3429.QtyBasic) & ", " 
    SQL = SQL & "    K3429_PricePurchasing      =  " & FormatSQL(z3429.PricePurchasing) & ", " 
    SQL = SQL & "    K3429_PriceMarket      =  " & FormatSQL(z3429.PriceMarket) & ", " 
    SQL = SQL & "    K3429_PriceExchange      =  " & FormatSQL(z3429.PriceExchange) & ", " 
    SQL = SQL & "    K3429_PriceExchangeAP      =  " & FormatSQL(z3429.PriceExchangeAP) & ", " 
    SQL = SQL & "    K3429_DateExchange      = N'" & FormatSQL(z3429.DateExchange) & "', " 
    SQL = SQL & "    K3429_PricePurchasingEX      =  " & FormatSQL(z3429.PricePurchasingEX) & ", " 
    SQL = SQL & "    K3429_PriceMarketEX      =  " & FormatSQL(z3429.PriceMarketEX) & ", " 
    SQL = SQL & "    K3429_PricePurchasingVND      =  " & FormatSQL(z3429.PricePurchasingVND) & ", " 
    SQL = SQL & "    K3429_PriceMarketVND      =  " & FormatSQL(z3429.PriceMarketVND) & ", " 
    SQL = SQL & "    K3429_AmountPurchasingEX      =  " & FormatSQL(z3429.AmountPurchasingEX) & ", " 
    SQL = SQL & "    K3429_AmountPurchasingVND      =  " & FormatSQL(z3429.AmountPurchasingVND) & ", " 
    SQL = SQL & "    K3429_AmountTaxEX      =  " & FormatSQL(z3429.AmountTaxEX) & ", " 
    SQL = SQL & "    K3429_AmountTaxVND      =  " & FormatSQL(z3429.AmountTaxVND) & ", " 
    SQL = SQL & "    K3429_PctExpense      =  " & FormatSQL(z3429.PctExpense) & ", " 
    SQL = SQL & "    K3429_AmountExpenseEX      =  " & FormatSQL(z3429.AmountExpenseEX) & ", " 
    SQL = SQL & "    K3429_AmountExpensVND      =  " & FormatSQL(z3429.AmountExpensVND) & ", " 
    SQL = SQL & "    K3429_seTax1      = N'" & FormatSQL(z3429.seTax1) & "', " 
    SQL = SQL & "    K3429_cdTax1      = N'" & FormatSQL(z3429.cdTax1) & "', " 
    SQL = SQL & "    K3429_PerTax1      =  " & FormatSQL(z3429.PerTax1) & ", " 
    SQL = SQL & "    K3429_AmountTax1      =  " & FormatSQL(z3429.AmountTax1) & ", " 
    SQL = SQL & "    K3429_seTax2      = N'" & FormatSQL(z3429.seTax2) & "', " 
    SQL = SQL & "    K3429_cdTax2      = N'" & FormatSQL(z3429.cdTax2) & "', " 
    SQL = SQL & "    K3429_PerTax2      =  " & FormatSQL(z3429.PerTax2) & ", " 
    SQL = SQL & "    K3429_AmountTax2      =  " & FormatSQL(z3429.AmountTax2) & ", " 
    SQL = SQL & "    K3429_seTax3      = N'" & FormatSQL(z3429.seTax3) & "', " 
    SQL = SQL & "    K3429_cdTax3      = N'" & FormatSQL(z3429.cdTax3) & "', " 
    SQL = SQL & "    K3429_PerTax3      =  " & FormatSQL(z3429.PerTax3) & ", " 
    SQL = SQL & "    K3429_AmountTax3      =  " & FormatSQL(z3429.AmountTax3) & ", " 
    SQL = SQL & "    K3429_QtyPurchasing      =  " & FormatSQL(z3429.QtyPurchasing) & ", " 
    SQL = SQL & "    K3429_PackPurchasing      =  " & FormatSQL(z3429.PackPurchasing) & ", " 
    SQL = SQL & "    K3429_QtyWarehouse      =  " & FormatSQL(z3429.QtyWarehouse) & ", " 
    SQL = SQL & "    K3429_PackWarehouse      =  " & FormatSQL(z3429.PackWarehouse) & ", " 
    SQL = SQL & "    K3429_QtyInbound      =  " & FormatSQL(z3429.QtyInbound) & ", " 
    SQL = SQL & "    K3429_PackInbound      =  " & FormatSQL(z3429.PackInbound) & ", " 
    SQL = SQL & "    K3429_QtyOutbound      =  " & FormatSQL(z3429.QtyOutbound) & ", " 
    SQL = SQL & "    K3429_PackOutbound      =  " & FormatSQL(z3429.PackOutbound) & ", " 
    SQL = SQL & "    K3429_AmountEX      =  " & FormatSQL(z3429.AmountEX) & ", " 
    SQL = SQL & "    K3429_AmountVND      =  " & FormatSQL(z3429.AmountVND) & ", " 
    SQL = SQL & "    K3429_AmountInBoundEX      =  " & FormatSQL(z3429.AmountInBoundEX) & ", " 
            SQL = SQL & "    K3429_AmountInBoundVND      =  " & FormatSQL(z3429.AmountInBoundVND) & ", "
            SQL = SQL & "    K3429_AMOUNTFCT      =  " & FormatSQL(z3429.AmountFCT) & ", "
            SQL = SQL & "    K3429_AMOUNTFCT2      =  " & FormatSQL(z3429.AmountFCT2) & ", "
    SQL = SQL & "    K3429_DateDelivery      = N'" & FormatSQL(z3429.DateDelivery) & "', " 
    SQL = SQL & "    K3429_DateStart      = N'" & FormatSQL(z3429.DateStart) & "', " 
    SQL = SQL & "    K3429_DateFinish      = N'" & FormatSQL(z3429.DateFinish) & "', " 
    SQL = SQL & "    K3429_CheckPurchasing      = N'" & FormatSQL(z3429.CheckPurchasing) & "', " 
    SQL = SQL & "    K3429_DateAccept      = N'" & FormatSQL(z3429.DateAccept) & "', " 
    SQL = SQL & "    K3429_DatePosted      = N'" & FormatSQL(z3429.DatePosted) & "', " 
    SQL = SQL & "    K3429_IsPosted      = N'" & FormatSQL(z3429.IsPosted) & "', " 
    SQL = SQL & "    K3429_DateComplete      = N'" & FormatSQL(z3429.DateComplete) & "', " 
    SQL = SQL & "    K3429_DateApproval      = N'" & FormatSQL(z3429.DateApproval) & "', " 
    SQL = SQL & "    K3429_DateCancel      = N'" & FormatSQL(z3429.DateCancel) & "', " 
    SQL = SQL & "    K3429_CheckComplete      = N'" & FormatSQL(z3429.CheckComplete) & "', " 
    SQL = SQL & "    K3429_PurchasingOrderNo      = N'" & FormatSQL(z3429.PurchasingOrderNo) & "', " 
    SQL = SQL & "    K3429_PurchasingOrderSeq      =  " & FormatSQL(z3429.PurchasingOrderSeq) & ", " 
    SQL = SQL & "    K3429_JobCardWorking      = N'" & FormatSQL(z3429.JobCardWorking) & "', " 
    SQL = SQL & "    K3429_JobCardWorkingSeq      = N'" & FormatSQL(z3429.JobCardWorkingSeq) & "', " 
    SQL = SQL & "    K3429_JobCardType      = N'" & FormatSQL(z3429.JobCardType) & "', " 
    SQL = SQL & "    K3429_SalesOrderNo      = N'" & FormatSQL(z3429.SalesOrderNo) & "', " 
    SQL = SQL & "    K3429_SalesOrderSeq      = N'" & FormatSQL(z3429.SalesOrderSeq) & "', " 
    SQL = SQL & "    K3429_SalesOrderSno      = N'" & FormatSQL(z3429.SalesOrderSno) & "', " 
    SQL = SQL & "    K3429_OrderNo      = N'" & FormatSQL(z3429.OrderNo) & "', " 
    SQL = SQL & "    K3429_OrderNoSeq      = N'" & FormatSQL(z3429.OrderNoSeq) & "', " 
    SQL = SQL & "    K3429_Remark      = N'" & FormatSQL(z3429.Remark) & "'  " 
    SQL = SQL & " WHERE K3429_PayableNo		 = '" & z3429.PayableNo & "' " 
    SQL = SQL & "   AND K3429_PayableNoSeq		 =  " & z3429.PayableNoSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK3429 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK3429",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK3429(z3429 As T3429_AREA) As Boolean
    DELETE_PFK3429 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK3429 "
    SQL = SQL & " WHERE K3429_PayableNo		 = '" & z3429.PayableNo & "' " 
    SQL = SQL & "   AND K3429_PayableNoSeq		 =  " & z3429.PayableNoSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK3429 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK3429",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D3429_CLEAR()
Try
    
   D3429.PayableNo = ""
    D3429.PayableNoSeq = 0 
   D3429.CheckTypePayable = ""
   D3429.FactOrderNo = ""
    D3429.FactOrderSeq = 0 
   D3429.DienGiai = ""
   D3429.DienGiai2 = ""
   D3429.SeriInvoice = ""
   D3429.PurchaseInvoice1 = ""
   D3429.DateInvoice = ""
   D3429.MaterialInBoundNo = ""
   D3429.MaterialInBoundSeq = ""
   D3429.seSite = ""
   D3429.cdSite = ""
   D3429.seDepartment = ""
   D3429.cdDepartment = ""
   D3429.seFactory = ""
   D3429.cdFactory = ""
   D3429.seLineProd = ""
   D3429.cdLineProd = ""
   D3429.seSubProcess = ""
   D3429.cdSubProcess = ""
   D3429.CustomerSupplier = ""
    D3429.Dseq = 0 
    D3429.AutokeyK3011 = 0 
   D3429.CheckRelationType = ""
   D3429.MaterialCode = ""
   D3429.Specification = ""
   D3429.Width = ""
   D3429.Height = ""
   D3429.SizeNo = ""
   D3429.SizeName = ""
   D3429.ColorCode = ""
   D3429.ColorName = ""
   D3429.seOrigin = ""
   D3429.cdOrigin = ""
   D3429.MaterialCheck = ""
   D3429.seUnitPrice = ""
   D3429.cdUnitPrice = ""
   D3429.seTax = ""
   D3429.cdTax = ""
   D3429.seUnitMaterial = ""
   D3429.cdUnitMaterial = ""
   D3429.seUnitPacking = ""
   D3429.cdUnitPacking = ""
   D3429.UnitBaseCheck = ""
   D3429.TypeDiscount = ""
    D3429.PerDiscount = 0 
    D3429.AmtDiscount = 0 
    D3429.QtyBasic = 0 
    D3429.PricePurchasing = 0 
    D3429.PriceMarket = 0 
    D3429.PriceExchange = 0 
    D3429.PriceExchangeAP = 0 
   D3429.DateExchange = ""
    D3429.PricePurchasingEX = 0 
    D3429.PriceMarketEX = 0 
    D3429.PricePurchasingVND = 0 
    D3429.PriceMarketVND = 0 
    D3429.AmountPurchasingEX = 0 
    D3429.AmountPurchasingVND = 0 
    D3429.AmountTaxEX = 0 
    D3429.AmountTaxVND = 0 
    D3429.PctExpense = 0 
    D3429.AmountExpenseEX = 0 
    D3429.AmountExpensVND = 0 
   D3429.seTax1 = ""
   D3429.cdTax1 = ""
    D3429.PerTax1 = 0 
    D3429.AmountTax1 = 0 
   D3429.seTax2 = ""
   D3429.cdTax2 = ""
    D3429.PerTax2 = 0 
    D3429.AmountTax2 = 0 
   D3429.seTax3 = ""
   D3429.cdTax3 = ""
    D3429.PerTax3 = 0 
    D3429.AmountTax3 = 0 
    D3429.QtyPurchasing = 0 
    D3429.PackPurchasing = 0 
    D3429.QtyWarehouse = 0 
    D3429.PackWarehouse = 0 
    D3429.QtyInbound = 0 
    D3429.PackInbound = 0 
    D3429.QtyOutbound = 0 
    D3429.PackOutbound = 0 
    D3429.AmountEX = 0 
    D3429.AmountVND = 0 
    D3429.AmountInBoundEX = 0 
            D3429.AmountInBoundVND = 0
            D3429.AmountFCT = 0
            D3429.AmountFCT2 = 0
   D3429.DateDelivery = ""
   D3429.DateStart = ""
   D3429.DateFinish = ""
   D3429.CheckPurchasing = ""
   D3429.DateAccept = ""
   D3429.DatePosted = ""
   D3429.IsPosted = ""
   D3429.DateComplete = ""
   D3429.DateApproval = ""
   D3429.DateCancel = ""
   D3429.CheckComplete = ""
   D3429.PurchasingOrderNo = ""
    D3429.PurchasingOrderSeq = 0 
   D3429.JobCardWorking = ""
   D3429.JobCardWorkingSeq = ""
   D3429.JobCardType = ""
   D3429.SalesOrderNo = ""
   D3429.SalesOrderSeq = ""
   D3429.SalesOrderSno = ""
   D3429.OrderNo = ""
   D3429.OrderNoSeq = ""
   D3429.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D3429_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x3429 As T3429_AREA)
Try
    
    x3429.PayableNo = trim$(  x3429.PayableNo)
    x3429.PayableNoSeq = trim$(  x3429.PayableNoSeq)
    x3429.CheckTypePayable = trim$(  x3429.CheckTypePayable)
    x3429.FactOrderNo = trim$(  x3429.FactOrderNo)
    x3429.FactOrderSeq = trim$(  x3429.FactOrderSeq)
    x3429.DienGiai = trim$(  x3429.DienGiai)
    x3429.DienGiai2 = trim$(  x3429.DienGiai2)
    x3429.SeriInvoice = trim$(  x3429.SeriInvoice)
    x3429.PurchaseInvoice1 = trim$(  x3429.PurchaseInvoice1)
    x3429.DateInvoice = trim$(  x3429.DateInvoice)
    x3429.MaterialInBoundNo = trim$(  x3429.MaterialInBoundNo)
    x3429.MaterialInBoundSeq = trim$(  x3429.MaterialInBoundSeq)
    x3429.seSite = trim$(  x3429.seSite)
    x3429.cdSite = trim$(  x3429.cdSite)
    x3429.seDepartment = trim$(  x3429.seDepartment)
    x3429.cdDepartment = trim$(  x3429.cdDepartment)
    x3429.seFactory = trim$(  x3429.seFactory)
    x3429.cdFactory = trim$(  x3429.cdFactory)
    x3429.seLineProd = trim$(  x3429.seLineProd)
    x3429.cdLineProd = trim$(  x3429.cdLineProd)
    x3429.seSubProcess = trim$(  x3429.seSubProcess)
    x3429.cdSubProcess = trim$(  x3429.cdSubProcess)
    x3429.CustomerSupplier = trim$(  x3429.CustomerSupplier)
    x3429.Dseq = trim$(  x3429.Dseq)
    x3429.AutokeyK3011 = trim$(  x3429.AutokeyK3011)
    x3429.CheckRelationType = trim$(  x3429.CheckRelationType)
    x3429.MaterialCode = trim$(  x3429.MaterialCode)
    x3429.Specification = trim$(  x3429.Specification)
    x3429.Width = trim$(  x3429.Width)
    x3429.Height = trim$(  x3429.Height)
    x3429.SizeNo = trim$(  x3429.SizeNo)
    x3429.SizeName = trim$(  x3429.SizeName)
    x3429.ColorCode = trim$(  x3429.ColorCode)
    x3429.ColorName = trim$(  x3429.ColorName)
    x3429.seOrigin = trim$(  x3429.seOrigin)
    x3429.cdOrigin = trim$(  x3429.cdOrigin)
    x3429.MaterialCheck = trim$(  x3429.MaterialCheck)
    x3429.seUnitPrice = trim$(  x3429.seUnitPrice)
    x3429.cdUnitPrice = trim$(  x3429.cdUnitPrice)
    x3429.seTax = trim$(  x3429.seTax)
    x3429.cdTax = trim$(  x3429.cdTax)
    x3429.seUnitMaterial = trim$(  x3429.seUnitMaterial)
    x3429.cdUnitMaterial = trim$(  x3429.cdUnitMaterial)
    x3429.seUnitPacking = trim$(  x3429.seUnitPacking)
    x3429.cdUnitPacking = trim$(  x3429.cdUnitPacking)
    x3429.UnitBaseCheck = trim$(  x3429.UnitBaseCheck)
    x3429.TypeDiscount = trim$(  x3429.TypeDiscount)
    x3429.PerDiscount = trim$(  x3429.PerDiscount)
    x3429.AmtDiscount = trim$(  x3429.AmtDiscount)
    x3429.QtyBasic = trim$(  x3429.QtyBasic)
    x3429.PricePurchasing = trim$(  x3429.PricePurchasing)
    x3429.PriceMarket = trim$(  x3429.PriceMarket)
    x3429.PriceExchange = trim$(  x3429.PriceExchange)
    x3429.PriceExchangeAP = trim$(  x3429.PriceExchangeAP)
    x3429.DateExchange = trim$(  x3429.DateExchange)
    x3429.PricePurchasingEX = trim$(  x3429.PricePurchasingEX)
    x3429.PriceMarketEX = trim$(  x3429.PriceMarketEX)
    x3429.PricePurchasingVND = trim$(  x3429.PricePurchasingVND)
    x3429.PriceMarketVND = trim$(  x3429.PriceMarketVND)
    x3429.AmountPurchasingEX = trim$(  x3429.AmountPurchasingEX)
    x3429.AmountPurchasingVND = trim$(  x3429.AmountPurchasingVND)
    x3429.AmountTaxEX = trim$(  x3429.AmountTaxEX)
    x3429.AmountTaxVND = trim$(  x3429.AmountTaxVND)
    x3429.PctExpense = trim$(  x3429.PctExpense)
    x3429.AmountExpenseEX = trim$(  x3429.AmountExpenseEX)
    x3429.AmountExpensVND = trim$(  x3429.AmountExpensVND)
    x3429.seTax1 = trim$(  x3429.seTax1)
    x3429.cdTax1 = trim$(  x3429.cdTax1)
    x3429.PerTax1 = trim$(  x3429.PerTax1)
    x3429.AmountTax1 = trim$(  x3429.AmountTax1)
    x3429.seTax2 = trim$(  x3429.seTax2)
    x3429.cdTax2 = trim$(  x3429.cdTax2)
    x3429.PerTax2 = trim$(  x3429.PerTax2)
    x3429.AmountTax2 = trim$(  x3429.AmountTax2)
    x3429.seTax3 = trim$(  x3429.seTax3)
    x3429.cdTax3 = trim$(  x3429.cdTax3)
    x3429.PerTax3 = trim$(  x3429.PerTax3)
    x3429.AmountTax3 = trim$(  x3429.AmountTax3)
    x3429.QtyPurchasing = trim$(  x3429.QtyPurchasing)
    x3429.PackPurchasing = trim$(  x3429.PackPurchasing)
    x3429.QtyWarehouse = trim$(  x3429.QtyWarehouse)
    x3429.PackWarehouse = trim$(  x3429.PackWarehouse)
    x3429.QtyInbound = trim$(  x3429.QtyInbound)
    x3429.PackInbound = trim$(  x3429.PackInbound)
    x3429.QtyOutbound = trim$(  x3429.QtyOutbound)
    x3429.PackOutbound = trim$(  x3429.PackOutbound)
    x3429.AmountEX = trim$(  x3429.AmountEX)
    x3429.AmountVND = trim$(  x3429.AmountVND)
    x3429.AmountInBoundEX = trim$(  x3429.AmountInBoundEX)
            x3429.AmountInBoundVND = Trim$(x3429.AmountInBoundVND)
            x3429.AmountFCT = Trim$(x3429.AmountFCT)
            x3429.AmountFCT2 = Trim$(x3429.AmountFCT2)
    x3429.DateDelivery = trim$(  x3429.DateDelivery)
    x3429.DateStart = trim$(  x3429.DateStart)
    x3429.DateFinish = trim$(  x3429.DateFinish)
    x3429.CheckPurchasing = trim$(  x3429.CheckPurchasing)
    x3429.DateAccept = trim$(  x3429.DateAccept)
    x3429.DatePosted = trim$(  x3429.DatePosted)
    x3429.IsPosted = trim$(  x3429.IsPosted)
    x3429.DateComplete = trim$(  x3429.DateComplete)
    x3429.DateApproval = trim$(  x3429.DateApproval)
    x3429.DateCancel = trim$(  x3429.DateCancel)
    x3429.CheckComplete = trim$(  x3429.CheckComplete)
    x3429.PurchasingOrderNo = trim$(  x3429.PurchasingOrderNo)
    x3429.PurchasingOrderSeq = trim$(  x3429.PurchasingOrderSeq)
    x3429.JobCardWorking = trim$(  x3429.JobCardWorking)
    x3429.JobCardWorkingSeq = trim$(  x3429.JobCardWorkingSeq)
    x3429.JobCardType = trim$(  x3429.JobCardType)
    x3429.SalesOrderNo = trim$(  x3429.SalesOrderNo)
    x3429.SalesOrderSeq = trim$(  x3429.SalesOrderSeq)
    x3429.SalesOrderSno = trim$(  x3429.SalesOrderSno)
    x3429.OrderNo = trim$(  x3429.OrderNo)
    x3429.OrderNoSeq = trim$(  x3429.OrderNoSeq)
    x3429.Remark = trim$(  x3429.Remark)
     
    If trim$( x3429.PayableNo ) = "" Then x3429.PayableNo = Space(1) 
    If trim$( x3429.PayableNoSeq ) = "" Then x3429.PayableNoSeq = 0 
    If trim$( x3429.CheckTypePayable ) = "" Then x3429.CheckTypePayable = Space(1) 
    If trim$( x3429.FactOrderNo ) = "" Then x3429.FactOrderNo = Space(1) 
    If trim$( x3429.FactOrderSeq ) = "" Then x3429.FactOrderSeq = 0 
    If trim$( x3429.DienGiai ) = "" Then x3429.DienGiai = Space(1) 
    If trim$( x3429.DienGiai2 ) = "" Then x3429.DienGiai2 = Space(1) 
    If trim$( x3429.SeriInvoice ) = "" Then x3429.SeriInvoice = Space(1) 
    If trim$( x3429.PurchaseInvoice1 ) = "" Then x3429.PurchaseInvoice1 = Space(1) 
    If trim$( x3429.DateInvoice ) = "" Then x3429.DateInvoice = Space(1) 
    If trim$( x3429.MaterialInBoundNo ) = "" Then x3429.MaterialInBoundNo = Space(1) 
    If trim$( x3429.MaterialInBoundSeq ) = "" Then x3429.MaterialInBoundSeq = Space(1) 
    If trim$( x3429.seSite ) = "" Then x3429.seSite = Space(1) 
    If trim$( x3429.cdSite ) = "" Then x3429.cdSite = Space(1) 
    If trim$( x3429.seDepartment ) = "" Then x3429.seDepartment = Space(1) 
    If trim$( x3429.cdDepartment ) = "" Then x3429.cdDepartment = Space(1) 
    If trim$( x3429.seFactory ) = "" Then x3429.seFactory = Space(1) 
    If trim$( x3429.cdFactory ) = "" Then x3429.cdFactory = Space(1) 
    If trim$( x3429.seLineProd ) = "" Then x3429.seLineProd = Space(1) 
    If trim$( x3429.cdLineProd ) = "" Then x3429.cdLineProd = Space(1) 
    If trim$( x3429.seSubProcess ) = "" Then x3429.seSubProcess = Space(1) 
    If trim$( x3429.cdSubProcess ) = "" Then x3429.cdSubProcess = Space(1) 
    If trim$( x3429.CustomerSupplier ) = "" Then x3429.CustomerSupplier = Space(1) 
    If trim$( x3429.Dseq ) = "" Then x3429.Dseq = 0 
    If trim$( x3429.AutokeyK3011 ) = "" Then x3429.AutokeyK3011 = 0 
    If trim$( x3429.CheckRelationType ) = "" Then x3429.CheckRelationType = Space(1) 
    If trim$( x3429.MaterialCode ) = "" Then x3429.MaterialCode = Space(1) 
    If trim$( x3429.Specification ) = "" Then x3429.Specification = Space(1) 
    If trim$( x3429.Width ) = "" Then x3429.Width = Space(1) 
    If trim$( x3429.Height ) = "" Then x3429.Height = Space(1) 
    If trim$( x3429.SizeNo ) = "" Then x3429.SizeNo = Space(1) 
    If trim$( x3429.SizeName ) = "" Then x3429.SizeName = Space(1) 
    If trim$( x3429.ColorCode ) = "" Then x3429.ColorCode = Space(1) 
    If trim$( x3429.ColorName ) = "" Then x3429.ColorName = Space(1) 
    If trim$( x3429.seOrigin ) = "" Then x3429.seOrigin = Space(1) 
    If trim$( x3429.cdOrigin ) = "" Then x3429.cdOrigin = Space(1) 
    If trim$( x3429.MaterialCheck ) = "" Then x3429.MaterialCheck = Space(1) 
    If trim$( x3429.seUnitPrice ) = "" Then x3429.seUnitPrice = Space(1) 
    If trim$( x3429.cdUnitPrice ) = "" Then x3429.cdUnitPrice = Space(1) 
    If trim$( x3429.seTax ) = "" Then x3429.seTax = Space(1) 
    If trim$( x3429.cdTax ) = "" Then x3429.cdTax = Space(1) 
    If trim$( x3429.seUnitMaterial ) = "" Then x3429.seUnitMaterial = Space(1) 
    If trim$( x3429.cdUnitMaterial ) = "" Then x3429.cdUnitMaterial = Space(1) 
    If trim$( x3429.seUnitPacking ) = "" Then x3429.seUnitPacking = Space(1) 
    If trim$( x3429.cdUnitPacking ) = "" Then x3429.cdUnitPacking = Space(1) 
    If trim$( x3429.UnitBaseCheck ) = "" Then x3429.UnitBaseCheck = Space(1) 
    If trim$( x3429.TypeDiscount ) = "" Then x3429.TypeDiscount = Space(1) 
    If trim$( x3429.PerDiscount ) = "" Then x3429.PerDiscount = 0 
    If trim$( x3429.AmtDiscount ) = "" Then x3429.AmtDiscount = 0 
    If trim$( x3429.QtyBasic ) = "" Then x3429.QtyBasic = 0 
    If trim$( x3429.PricePurchasing ) = "" Then x3429.PricePurchasing = 0 
    If trim$( x3429.PriceMarket ) = "" Then x3429.PriceMarket = 0 
    If trim$( x3429.PriceExchange ) = "" Then x3429.PriceExchange = 0 
    If trim$( x3429.PriceExchangeAP ) = "" Then x3429.PriceExchangeAP = 0 
    If trim$( x3429.DateExchange ) = "" Then x3429.DateExchange = Space(1) 
    If trim$( x3429.PricePurchasingEX ) = "" Then x3429.PricePurchasingEX = 0 
    If trim$( x3429.PriceMarketEX ) = "" Then x3429.PriceMarketEX = 0 
    If trim$( x3429.PricePurchasingVND ) = "" Then x3429.PricePurchasingVND = 0 
    If trim$( x3429.PriceMarketVND ) = "" Then x3429.PriceMarketVND = 0 
    If trim$( x3429.AmountPurchasingEX ) = "" Then x3429.AmountPurchasingEX = 0 
    If trim$( x3429.AmountPurchasingVND ) = "" Then x3429.AmountPurchasingVND = 0 
    If trim$( x3429.AmountTaxEX ) = "" Then x3429.AmountTaxEX = 0 
    If trim$( x3429.AmountTaxVND ) = "" Then x3429.AmountTaxVND = 0 
    If trim$( x3429.PctExpense ) = "" Then x3429.PctExpense = 0 
    If trim$( x3429.AmountExpenseEX ) = "" Then x3429.AmountExpenseEX = 0 
    If trim$( x3429.AmountExpensVND ) = "" Then x3429.AmountExpensVND = 0 
    If trim$( x3429.seTax1 ) = "" Then x3429.seTax1 = Space(1) 
    If trim$( x3429.cdTax1 ) = "" Then x3429.cdTax1 = Space(1) 
    If trim$( x3429.PerTax1 ) = "" Then x3429.PerTax1 = 0 
    If trim$( x3429.AmountTax1 ) = "" Then x3429.AmountTax1 = 0 
    If trim$( x3429.seTax2 ) = "" Then x3429.seTax2 = Space(1) 
    If trim$( x3429.cdTax2 ) = "" Then x3429.cdTax2 = Space(1) 
    If trim$( x3429.PerTax2 ) = "" Then x3429.PerTax2 = 0 
    If trim$( x3429.AmountTax2 ) = "" Then x3429.AmountTax2 = 0 
    If trim$( x3429.seTax3 ) = "" Then x3429.seTax3 = Space(1) 
    If trim$( x3429.cdTax3 ) = "" Then x3429.cdTax3 = Space(1) 
    If trim$( x3429.PerTax3 ) = "" Then x3429.PerTax3 = 0 
    If trim$( x3429.AmountTax3 ) = "" Then x3429.AmountTax3 = 0 
    If trim$( x3429.QtyPurchasing ) = "" Then x3429.QtyPurchasing = 0 
    If trim$( x3429.PackPurchasing ) = "" Then x3429.PackPurchasing = 0 
    If trim$( x3429.QtyWarehouse ) = "" Then x3429.QtyWarehouse = 0 
    If trim$( x3429.PackWarehouse ) = "" Then x3429.PackWarehouse = 0 
    If trim$( x3429.QtyInbound ) = "" Then x3429.QtyInbound = 0 
    If trim$( x3429.PackInbound ) = "" Then x3429.PackInbound = 0 
    If trim$( x3429.QtyOutbound ) = "" Then x3429.QtyOutbound = 0 
    If trim$( x3429.PackOutbound ) = "" Then x3429.PackOutbound = 0 
    If trim$( x3429.AmountEX ) = "" Then x3429.AmountEX = 0 
    If trim$( x3429.AmountVND ) = "" Then x3429.AmountVND = 0 
    If trim$( x3429.AmountInBoundEX ) = "" Then x3429.AmountInBoundEX = 0 
            If Trim$(x3429.AmountInBoundVND) = "" Then x3429.AmountInBoundVND = 0
            If Trim$(x3429.AmountFCT) = "" Then x3429.AmountFCT = 0
            If Trim$(x3429.AmountFCT2) = "" Then x3429.AmountFCT2 = 0
    If trim$( x3429.DateDelivery ) = "" Then x3429.DateDelivery = Space(1) 
    If trim$( x3429.DateStart ) = "" Then x3429.DateStart = Space(1) 
    If trim$( x3429.DateFinish ) = "" Then x3429.DateFinish = Space(1) 
    If trim$( x3429.CheckPurchasing ) = "" Then x3429.CheckPurchasing = Space(1) 
    If trim$( x3429.DateAccept ) = "" Then x3429.DateAccept = Space(1) 
    If trim$( x3429.DatePosted ) = "" Then x3429.DatePosted = Space(1) 
    If trim$( x3429.IsPosted ) = "" Then x3429.IsPosted = Space(1) 
    If trim$( x3429.DateComplete ) = "" Then x3429.DateComplete = Space(1) 
    If trim$( x3429.DateApproval ) = "" Then x3429.DateApproval = Space(1) 
    If trim$( x3429.DateCancel ) = "" Then x3429.DateCancel = Space(1) 
    If trim$( x3429.CheckComplete ) = "" Then x3429.CheckComplete = Space(1) 
    If trim$( x3429.PurchasingOrderNo ) = "" Then x3429.PurchasingOrderNo = Space(1) 
    If trim$( x3429.PurchasingOrderSeq ) = "" Then x3429.PurchasingOrderSeq = 0 
    If trim$( x3429.JobCardWorking ) = "" Then x3429.JobCardWorking = Space(1) 
    If trim$( x3429.JobCardWorkingSeq ) = "" Then x3429.JobCardWorkingSeq = Space(1) 
    If trim$( x3429.JobCardType ) = "" Then x3429.JobCardType = Space(1) 
    If trim$( x3429.SalesOrderNo ) = "" Then x3429.SalesOrderNo = Space(1) 
    If trim$( x3429.SalesOrderSeq ) = "" Then x3429.SalesOrderSeq = Space(1) 
    If trim$( x3429.SalesOrderSno ) = "" Then x3429.SalesOrderSno = Space(1) 
    If trim$( x3429.OrderNo ) = "" Then x3429.OrderNo = Space(1) 
    If trim$( x3429.OrderNoSeq ) = "" Then x3429.OrderNoSeq = Space(1) 
    If trim$( x3429.Remark ) = "" Then x3429.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K3429_MOVE(rs3429 As SqlClient.SqlDataReader)
Try

    call D3429_CLEAR()   

    If IsdbNull(rs3429!K3429_PayableNo) = False Then D3429.PayableNo = Trim$(rs3429!K3429_PayableNo)
    If IsdbNull(rs3429!K3429_PayableNoSeq) = False Then D3429.PayableNoSeq = Trim$(rs3429!K3429_PayableNoSeq)
    If IsdbNull(rs3429!K3429_CheckTypePayable) = False Then D3429.CheckTypePayable = Trim$(rs3429!K3429_CheckTypePayable)
    If IsdbNull(rs3429!K3429_FactOrderNo) = False Then D3429.FactOrderNo = Trim$(rs3429!K3429_FactOrderNo)
    If IsdbNull(rs3429!K3429_FactOrderSeq) = False Then D3429.FactOrderSeq = Trim$(rs3429!K3429_FactOrderSeq)
    If IsdbNull(rs3429!K3429_DienGiai) = False Then D3429.DienGiai = Trim$(rs3429!K3429_DienGiai)
    If IsdbNull(rs3429!K3429_DienGiai2) = False Then D3429.DienGiai2 = Trim$(rs3429!K3429_DienGiai2)
    If IsdbNull(rs3429!K3429_SeriInvoice) = False Then D3429.SeriInvoice = Trim$(rs3429!K3429_SeriInvoice)
    If IsdbNull(rs3429!K3429_PurchaseInvoice1) = False Then D3429.PurchaseInvoice1 = Trim$(rs3429!K3429_PurchaseInvoice1)
    If IsdbNull(rs3429!K3429_DateInvoice) = False Then D3429.DateInvoice = Trim$(rs3429!K3429_DateInvoice)
    If IsdbNull(rs3429!K3429_MaterialInBoundNo) = False Then D3429.MaterialInBoundNo = Trim$(rs3429!K3429_MaterialInBoundNo)
    If IsdbNull(rs3429!K3429_MaterialInBoundSeq) = False Then D3429.MaterialInBoundSeq = Trim$(rs3429!K3429_MaterialInBoundSeq)
    If IsdbNull(rs3429!K3429_seSite) = False Then D3429.seSite = Trim$(rs3429!K3429_seSite)
    If IsdbNull(rs3429!K3429_cdSite) = False Then D3429.cdSite = Trim$(rs3429!K3429_cdSite)
    If IsdbNull(rs3429!K3429_seDepartment) = False Then D3429.seDepartment = Trim$(rs3429!K3429_seDepartment)
    If IsdbNull(rs3429!K3429_cdDepartment) = False Then D3429.cdDepartment = Trim$(rs3429!K3429_cdDepartment)
    If IsdbNull(rs3429!K3429_seFactory) = False Then D3429.seFactory = Trim$(rs3429!K3429_seFactory)
    If IsdbNull(rs3429!K3429_cdFactory) = False Then D3429.cdFactory = Trim$(rs3429!K3429_cdFactory)
    If IsdbNull(rs3429!K3429_seLineProd) = False Then D3429.seLineProd = Trim$(rs3429!K3429_seLineProd)
    If IsdbNull(rs3429!K3429_cdLineProd) = False Then D3429.cdLineProd = Trim$(rs3429!K3429_cdLineProd)
    If IsdbNull(rs3429!K3429_seSubProcess) = False Then D3429.seSubProcess = Trim$(rs3429!K3429_seSubProcess)
    If IsdbNull(rs3429!K3429_cdSubProcess) = False Then D3429.cdSubProcess = Trim$(rs3429!K3429_cdSubProcess)
    If IsdbNull(rs3429!K3429_CustomerSupplier) = False Then D3429.CustomerSupplier = Trim$(rs3429!K3429_CustomerSupplier)
    If IsdbNull(rs3429!K3429_Dseq) = False Then D3429.Dseq = Trim$(rs3429!K3429_Dseq)
    If IsdbNull(rs3429!K3429_AutokeyK3011) = False Then D3429.AutokeyK3011 = Trim$(rs3429!K3429_AutokeyK3011)
    If IsdbNull(rs3429!K3429_CheckRelationType) = False Then D3429.CheckRelationType = Trim$(rs3429!K3429_CheckRelationType)
    If IsdbNull(rs3429!K3429_MaterialCode) = False Then D3429.MaterialCode = Trim$(rs3429!K3429_MaterialCode)
    If IsdbNull(rs3429!K3429_Specification) = False Then D3429.Specification = Trim$(rs3429!K3429_Specification)
    If IsdbNull(rs3429!K3429_Width) = False Then D3429.Width = Trim$(rs3429!K3429_Width)
    If IsdbNull(rs3429!K3429_Height) = False Then D3429.Height = Trim$(rs3429!K3429_Height)
    If IsdbNull(rs3429!K3429_SizeNo) = False Then D3429.SizeNo = Trim$(rs3429!K3429_SizeNo)
    If IsdbNull(rs3429!K3429_SizeName) = False Then D3429.SizeName = Trim$(rs3429!K3429_SizeName)
    If IsdbNull(rs3429!K3429_ColorCode) = False Then D3429.ColorCode = Trim$(rs3429!K3429_ColorCode)
    If IsdbNull(rs3429!K3429_ColorName) = False Then D3429.ColorName = Trim$(rs3429!K3429_ColorName)
    If IsdbNull(rs3429!K3429_seOrigin) = False Then D3429.seOrigin = Trim$(rs3429!K3429_seOrigin)
    If IsdbNull(rs3429!K3429_cdOrigin) = False Then D3429.cdOrigin = Trim$(rs3429!K3429_cdOrigin)
    If IsdbNull(rs3429!K3429_MaterialCheck) = False Then D3429.MaterialCheck = Trim$(rs3429!K3429_MaterialCheck)
    If IsdbNull(rs3429!K3429_seUnitPrice) = False Then D3429.seUnitPrice = Trim$(rs3429!K3429_seUnitPrice)
    If IsdbNull(rs3429!K3429_cdUnitPrice) = False Then D3429.cdUnitPrice = Trim$(rs3429!K3429_cdUnitPrice)
    If IsdbNull(rs3429!K3429_seTax) = False Then D3429.seTax = Trim$(rs3429!K3429_seTax)
    If IsdbNull(rs3429!K3429_cdTax) = False Then D3429.cdTax = Trim$(rs3429!K3429_cdTax)
    If IsdbNull(rs3429!K3429_seUnitMaterial) = False Then D3429.seUnitMaterial = Trim$(rs3429!K3429_seUnitMaterial)
    If IsdbNull(rs3429!K3429_cdUnitMaterial) = False Then D3429.cdUnitMaterial = Trim$(rs3429!K3429_cdUnitMaterial)
    If IsdbNull(rs3429!K3429_seUnitPacking) = False Then D3429.seUnitPacking = Trim$(rs3429!K3429_seUnitPacking)
    If IsdbNull(rs3429!K3429_cdUnitPacking) = False Then D3429.cdUnitPacking = Trim$(rs3429!K3429_cdUnitPacking)
    If IsdbNull(rs3429!K3429_UnitBaseCheck) = False Then D3429.UnitBaseCheck = Trim$(rs3429!K3429_UnitBaseCheck)
    If IsdbNull(rs3429!K3429_TypeDiscount) = False Then D3429.TypeDiscount = Trim$(rs3429!K3429_TypeDiscount)
    If IsdbNull(rs3429!K3429_PerDiscount) = False Then D3429.PerDiscount = Trim$(rs3429!K3429_PerDiscount)
    If IsdbNull(rs3429!K3429_AmtDiscount) = False Then D3429.AmtDiscount = Trim$(rs3429!K3429_AmtDiscount)
    If IsdbNull(rs3429!K3429_QtyBasic) = False Then D3429.QtyBasic = Trim$(rs3429!K3429_QtyBasic)
    If IsdbNull(rs3429!K3429_PricePurchasing) = False Then D3429.PricePurchasing = Trim$(rs3429!K3429_PricePurchasing)
    If IsdbNull(rs3429!K3429_PriceMarket) = False Then D3429.PriceMarket = Trim$(rs3429!K3429_PriceMarket)
    If IsdbNull(rs3429!K3429_PriceExchange) = False Then D3429.PriceExchange = Trim$(rs3429!K3429_PriceExchange)
    If IsdbNull(rs3429!K3429_PriceExchangeAP) = False Then D3429.PriceExchangeAP = Trim$(rs3429!K3429_PriceExchangeAP)
    If IsdbNull(rs3429!K3429_DateExchange) = False Then D3429.DateExchange = Trim$(rs3429!K3429_DateExchange)
    If IsdbNull(rs3429!K3429_PricePurchasingEX) = False Then D3429.PricePurchasingEX = Trim$(rs3429!K3429_PricePurchasingEX)
    If IsdbNull(rs3429!K3429_PriceMarketEX) = False Then D3429.PriceMarketEX = Trim$(rs3429!K3429_PriceMarketEX)
    If IsdbNull(rs3429!K3429_PricePurchasingVND) = False Then D3429.PricePurchasingVND = Trim$(rs3429!K3429_PricePurchasingVND)
    If IsdbNull(rs3429!K3429_PriceMarketVND) = False Then D3429.PriceMarketVND = Trim$(rs3429!K3429_PriceMarketVND)
    If IsdbNull(rs3429!K3429_AmountPurchasingEX) = False Then D3429.AmountPurchasingEX = Trim$(rs3429!K3429_AmountPurchasingEX)
    If IsdbNull(rs3429!K3429_AmountPurchasingVND) = False Then D3429.AmountPurchasingVND = Trim$(rs3429!K3429_AmountPurchasingVND)
    If IsdbNull(rs3429!K3429_AmountTaxEX) = False Then D3429.AmountTaxEX = Trim$(rs3429!K3429_AmountTaxEX)
    If IsdbNull(rs3429!K3429_AmountTaxVND) = False Then D3429.AmountTaxVND = Trim$(rs3429!K3429_AmountTaxVND)
    If IsdbNull(rs3429!K3429_PctExpense) = False Then D3429.PctExpense = Trim$(rs3429!K3429_PctExpense)
    If IsdbNull(rs3429!K3429_AmountExpenseEX) = False Then D3429.AmountExpenseEX = Trim$(rs3429!K3429_AmountExpenseEX)
    If IsdbNull(rs3429!K3429_AmountExpensVND) = False Then D3429.AmountExpensVND = Trim$(rs3429!K3429_AmountExpensVND)
    If IsdbNull(rs3429!K3429_seTax1) = False Then D3429.seTax1 = Trim$(rs3429!K3429_seTax1)
    If IsdbNull(rs3429!K3429_cdTax1) = False Then D3429.cdTax1 = Trim$(rs3429!K3429_cdTax1)
    If IsdbNull(rs3429!K3429_PerTax1) = False Then D3429.PerTax1 = Trim$(rs3429!K3429_PerTax1)
    If IsdbNull(rs3429!K3429_AmountTax1) = False Then D3429.AmountTax1 = Trim$(rs3429!K3429_AmountTax1)
    If IsdbNull(rs3429!K3429_seTax2) = False Then D3429.seTax2 = Trim$(rs3429!K3429_seTax2)
    If IsdbNull(rs3429!K3429_cdTax2) = False Then D3429.cdTax2 = Trim$(rs3429!K3429_cdTax2)
    If IsdbNull(rs3429!K3429_PerTax2) = False Then D3429.PerTax2 = Trim$(rs3429!K3429_PerTax2)
    If IsdbNull(rs3429!K3429_AmountTax2) = False Then D3429.AmountTax2 = Trim$(rs3429!K3429_AmountTax2)
    If IsdbNull(rs3429!K3429_seTax3) = False Then D3429.seTax3 = Trim$(rs3429!K3429_seTax3)
    If IsdbNull(rs3429!K3429_cdTax3) = False Then D3429.cdTax3 = Trim$(rs3429!K3429_cdTax3)
    If IsdbNull(rs3429!K3429_PerTax3) = False Then D3429.PerTax3 = Trim$(rs3429!K3429_PerTax3)
    If IsdbNull(rs3429!K3429_AmountTax3) = False Then D3429.AmountTax3 = Trim$(rs3429!K3429_AmountTax3)
    If IsdbNull(rs3429!K3429_QtyPurchasing) = False Then D3429.QtyPurchasing = Trim$(rs3429!K3429_QtyPurchasing)
    If IsdbNull(rs3429!K3429_PackPurchasing) = False Then D3429.PackPurchasing = Trim$(rs3429!K3429_PackPurchasing)
    If IsdbNull(rs3429!K3429_QtyWarehouse) = False Then D3429.QtyWarehouse = Trim$(rs3429!K3429_QtyWarehouse)
    If IsdbNull(rs3429!K3429_PackWarehouse) = False Then D3429.PackWarehouse = Trim$(rs3429!K3429_PackWarehouse)
    If IsdbNull(rs3429!K3429_QtyInbound) = False Then D3429.QtyInbound = Trim$(rs3429!K3429_QtyInbound)
    If IsdbNull(rs3429!K3429_PackInbound) = False Then D3429.PackInbound = Trim$(rs3429!K3429_PackInbound)
    If IsdbNull(rs3429!K3429_QtyOutbound) = False Then D3429.QtyOutbound = Trim$(rs3429!K3429_QtyOutbound)
    If IsdbNull(rs3429!K3429_PackOutbound) = False Then D3429.PackOutbound = Trim$(rs3429!K3429_PackOutbound)
    If IsdbNull(rs3429!K3429_AmountEX) = False Then D3429.AmountEX = Trim$(rs3429!K3429_AmountEX)
    If IsdbNull(rs3429!K3429_AmountVND) = False Then D3429.AmountVND = Trim$(rs3429!K3429_AmountVND)
    If IsdbNull(rs3429!K3429_AmountInBoundEX) = False Then D3429.AmountInBoundEX = Trim$(rs3429!K3429_AmountInBoundEX)
            If IsDBNull(rs3429!K3429_AmountInBoundVND) = False Then D3429.AmountInBoundVND = Trim$(rs3429!K3429_AmountInBoundVND)
            If IsDBNull(rs3429!K3429_AMOUNTFCT) = False Then D3429.AmountFCT = Trim$(rs3429!K3429_AMOUNTFCT)
            If IsDBNull(rs3429!K3429_AMOUNTFCT2) = False Then D3429.AmountFCT2 = Trim$(rs3429!K3429_AMOUNTFCT2)
    If IsdbNull(rs3429!K3429_DateDelivery) = False Then D3429.DateDelivery = Trim$(rs3429!K3429_DateDelivery)
    If IsdbNull(rs3429!K3429_DateStart) = False Then D3429.DateStart = Trim$(rs3429!K3429_DateStart)
    If IsdbNull(rs3429!K3429_DateFinish) = False Then D3429.DateFinish = Trim$(rs3429!K3429_DateFinish)
    If IsdbNull(rs3429!K3429_CheckPurchasing) = False Then D3429.CheckPurchasing = Trim$(rs3429!K3429_CheckPurchasing)
    If IsdbNull(rs3429!K3429_DateAccept) = False Then D3429.DateAccept = Trim$(rs3429!K3429_DateAccept)
    If IsdbNull(rs3429!K3429_DatePosted) = False Then D3429.DatePosted = Trim$(rs3429!K3429_DatePosted)
    If IsdbNull(rs3429!K3429_IsPosted) = False Then D3429.IsPosted = Trim$(rs3429!K3429_IsPosted)
    If IsdbNull(rs3429!K3429_DateComplete) = False Then D3429.DateComplete = Trim$(rs3429!K3429_DateComplete)
    If IsdbNull(rs3429!K3429_DateApproval) = False Then D3429.DateApproval = Trim$(rs3429!K3429_DateApproval)
    If IsdbNull(rs3429!K3429_DateCancel) = False Then D3429.DateCancel = Trim$(rs3429!K3429_DateCancel)
    If IsdbNull(rs3429!K3429_CheckComplete) = False Then D3429.CheckComplete = Trim$(rs3429!K3429_CheckComplete)
    If IsdbNull(rs3429!K3429_PurchasingOrderNo) = False Then D3429.PurchasingOrderNo = Trim$(rs3429!K3429_PurchasingOrderNo)
    If IsdbNull(rs3429!K3429_PurchasingOrderSeq) = False Then D3429.PurchasingOrderSeq = Trim$(rs3429!K3429_PurchasingOrderSeq)
    If IsdbNull(rs3429!K3429_JobCardWorking) = False Then D3429.JobCardWorking = Trim$(rs3429!K3429_JobCardWorking)
    If IsdbNull(rs3429!K3429_JobCardWorkingSeq) = False Then D3429.JobCardWorkingSeq = Trim$(rs3429!K3429_JobCardWorkingSeq)
    If IsdbNull(rs3429!K3429_JobCardType) = False Then D3429.JobCardType = Trim$(rs3429!K3429_JobCardType)
    If IsdbNull(rs3429!K3429_SalesOrderNo) = False Then D3429.SalesOrderNo = Trim$(rs3429!K3429_SalesOrderNo)
    If IsdbNull(rs3429!K3429_SalesOrderSeq) = False Then D3429.SalesOrderSeq = Trim$(rs3429!K3429_SalesOrderSeq)
    If IsdbNull(rs3429!K3429_SalesOrderSno) = False Then D3429.SalesOrderSno = Trim$(rs3429!K3429_SalesOrderSno)
    If IsdbNull(rs3429!K3429_OrderNo) = False Then D3429.OrderNo = Trim$(rs3429!K3429_OrderNo)
    If IsdbNull(rs3429!K3429_OrderNoSeq) = False Then D3429.OrderNoSeq = Trim$(rs3429!K3429_OrderNoSeq)
    If IsdbNull(rs3429!K3429_Remark) = False Then D3429.Remark = Trim$(rs3429!K3429_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K3429_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K3429_MOVE(rs3429 As DataRow)
Try

    call D3429_CLEAR()   

    If IsdbNull(rs3429!K3429_PayableNo) = False Then D3429.PayableNo = Trim$(rs3429!K3429_PayableNo)
    If IsdbNull(rs3429!K3429_PayableNoSeq) = False Then D3429.PayableNoSeq = Trim$(rs3429!K3429_PayableNoSeq)
    If IsdbNull(rs3429!K3429_CheckTypePayable) = False Then D3429.CheckTypePayable = Trim$(rs3429!K3429_CheckTypePayable)
    If IsdbNull(rs3429!K3429_FactOrderNo) = False Then D3429.FactOrderNo = Trim$(rs3429!K3429_FactOrderNo)
    If IsdbNull(rs3429!K3429_FactOrderSeq) = False Then D3429.FactOrderSeq = Trim$(rs3429!K3429_FactOrderSeq)
    If IsdbNull(rs3429!K3429_DienGiai) = False Then D3429.DienGiai = Trim$(rs3429!K3429_DienGiai)
    If IsdbNull(rs3429!K3429_DienGiai2) = False Then D3429.DienGiai2 = Trim$(rs3429!K3429_DienGiai2)
    If IsdbNull(rs3429!K3429_SeriInvoice) = False Then D3429.SeriInvoice = Trim$(rs3429!K3429_SeriInvoice)
    If IsdbNull(rs3429!K3429_PurchaseInvoice1) = False Then D3429.PurchaseInvoice1 = Trim$(rs3429!K3429_PurchaseInvoice1)
    If IsdbNull(rs3429!K3429_DateInvoice) = False Then D3429.DateInvoice = Trim$(rs3429!K3429_DateInvoice)
    If IsdbNull(rs3429!K3429_MaterialInBoundNo) = False Then D3429.MaterialInBoundNo = Trim$(rs3429!K3429_MaterialInBoundNo)
    If IsdbNull(rs3429!K3429_MaterialInBoundSeq) = False Then D3429.MaterialInBoundSeq = Trim$(rs3429!K3429_MaterialInBoundSeq)
    If IsdbNull(rs3429!K3429_seSite) = False Then D3429.seSite = Trim$(rs3429!K3429_seSite)
    If IsdbNull(rs3429!K3429_cdSite) = False Then D3429.cdSite = Trim$(rs3429!K3429_cdSite)
    If IsdbNull(rs3429!K3429_seDepartment) = False Then D3429.seDepartment = Trim$(rs3429!K3429_seDepartment)
    If IsdbNull(rs3429!K3429_cdDepartment) = False Then D3429.cdDepartment = Trim$(rs3429!K3429_cdDepartment)
    If IsdbNull(rs3429!K3429_seFactory) = False Then D3429.seFactory = Trim$(rs3429!K3429_seFactory)
    If IsdbNull(rs3429!K3429_cdFactory) = False Then D3429.cdFactory = Trim$(rs3429!K3429_cdFactory)
    If IsdbNull(rs3429!K3429_seLineProd) = False Then D3429.seLineProd = Trim$(rs3429!K3429_seLineProd)
    If IsdbNull(rs3429!K3429_cdLineProd) = False Then D3429.cdLineProd = Trim$(rs3429!K3429_cdLineProd)
    If IsdbNull(rs3429!K3429_seSubProcess) = False Then D3429.seSubProcess = Trim$(rs3429!K3429_seSubProcess)
    If IsdbNull(rs3429!K3429_cdSubProcess) = False Then D3429.cdSubProcess = Trim$(rs3429!K3429_cdSubProcess)
    If IsdbNull(rs3429!K3429_CustomerSupplier) = False Then D3429.CustomerSupplier = Trim$(rs3429!K3429_CustomerSupplier)
    If IsdbNull(rs3429!K3429_Dseq) = False Then D3429.Dseq = Trim$(rs3429!K3429_Dseq)
    If IsdbNull(rs3429!K3429_AutokeyK3011) = False Then D3429.AutokeyK3011 = Trim$(rs3429!K3429_AutokeyK3011)
    If IsdbNull(rs3429!K3429_CheckRelationType) = False Then D3429.CheckRelationType = Trim$(rs3429!K3429_CheckRelationType)
    If IsdbNull(rs3429!K3429_MaterialCode) = False Then D3429.MaterialCode = Trim$(rs3429!K3429_MaterialCode)
    If IsdbNull(rs3429!K3429_Specification) = False Then D3429.Specification = Trim$(rs3429!K3429_Specification)
    If IsdbNull(rs3429!K3429_Width) = False Then D3429.Width = Trim$(rs3429!K3429_Width)
    If IsdbNull(rs3429!K3429_Height) = False Then D3429.Height = Trim$(rs3429!K3429_Height)
    If IsdbNull(rs3429!K3429_SizeNo) = False Then D3429.SizeNo = Trim$(rs3429!K3429_SizeNo)
    If IsdbNull(rs3429!K3429_SizeName) = False Then D3429.SizeName = Trim$(rs3429!K3429_SizeName)
    If IsdbNull(rs3429!K3429_ColorCode) = False Then D3429.ColorCode = Trim$(rs3429!K3429_ColorCode)
    If IsdbNull(rs3429!K3429_ColorName) = False Then D3429.ColorName = Trim$(rs3429!K3429_ColorName)
    If IsdbNull(rs3429!K3429_seOrigin) = False Then D3429.seOrigin = Trim$(rs3429!K3429_seOrigin)
    If IsdbNull(rs3429!K3429_cdOrigin) = False Then D3429.cdOrigin = Trim$(rs3429!K3429_cdOrigin)
    If IsdbNull(rs3429!K3429_MaterialCheck) = False Then D3429.MaterialCheck = Trim$(rs3429!K3429_MaterialCheck)
    If IsdbNull(rs3429!K3429_seUnitPrice) = False Then D3429.seUnitPrice = Trim$(rs3429!K3429_seUnitPrice)
    If IsdbNull(rs3429!K3429_cdUnitPrice) = False Then D3429.cdUnitPrice = Trim$(rs3429!K3429_cdUnitPrice)
    If IsdbNull(rs3429!K3429_seTax) = False Then D3429.seTax = Trim$(rs3429!K3429_seTax)
    If IsdbNull(rs3429!K3429_cdTax) = False Then D3429.cdTax = Trim$(rs3429!K3429_cdTax)
    If IsdbNull(rs3429!K3429_seUnitMaterial) = False Then D3429.seUnitMaterial = Trim$(rs3429!K3429_seUnitMaterial)
    If IsdbNull(rs3429!K3429_cdUnitMaterial) = False Then D3429.cdUnitMaterial = Trim$(rs3429!K3429_cdUnitMaterial)
    If IsdbNull(rs3429!K3429_seUnitPacking) = False Then D3429.seUnitPacking = Trim$(rs3429!K3429_seUnitPacking)
    If IsdbNull(rs3429!K3429_cdUnitPacking) = False Then D3429.cdUnitPacking = Trim$(rs3429!K3429_cdUnitPacking)
    If IsdbNull(rs3429!K3429_UnitBaseCheck) = False Then D3429.UnitBaseCheck = Trim$(rs3429!K3429_UnitBaseCheck)
    If IsdbNull(rs3429!K3429_TypeDiscount) = False Then D3429.TypeDiscount = Trim$(rs3429!K3429_TypeDiscount)
    If IsdbNull(rs3429!K3429_PerDiscount) = False Then D3429.PerDiscount = Trim$(rs3429!K3429_PerDiscount)
    If IsdbNull(rs3429!K3429_AmtDiscount) = False Then D3429.AmtDiscount = Trim$(rs3429!K3429_AmtDiscount)
    If IsdbNull(rs3429!K3429_QtyBasic) = False Then D3429.QtyBasic = Trim$(rs3429!K3429_QtyBasic)
    If IsdbNull(rs3429!K3429_PricePurchasing) = False Then D3429.PricePurchasing = Trim$(rs3429!K3429_PricePurchasing)
    If IsdbNull(rs3429!K3429_PriceMarket) = False Then D3429.PriceMarket = Trim$(rs3429!K3429_PriceMarket)
    If IsdbNull(rs3429!K3429_PriceExchange) = False Then D3429.PriceExchange = Trim$(rs3429!K3429_PriceExchange)
    If IsdbNull(rs3429!K3429_PriceExchangeAP) = False Then D3429.PriceExchangeAP = Trim$(rs3429!K3429_PriceExchangeAP)
    If IsdbNull(rs3429!K3429_DateExchange) = False Then D3429.DateExchange = Trim$(rs3429!K3429_DateExchange)
    If IsdbNull(rs3429!K3429_PricePurchasingEX) = False Then D3429.PricePurchasingEX = Trim$(rs3429!K3429_PricePurchasingEX)
    If IsdbNull(rs3429!K3429_PriceMarketEX) = False Then D3429.PriceMarketEX = Trim$(rs3429!K3429_PriceMarketEX)
    If IsdbNull(rs3429!K3429_PricePurchasingVND) = False Then D3429.PricePurchasingVND = Trim$(rs3429!K3429_PricePurchasingVND)
    If IsdbNull(rs3429!K3429_PriceMarketVND) = False Then D3429.PriceMarketVND = Trim$(rs3429!K3429_PriceMarketVND)
    If IsdbNull(rs3429!K3429_AmountPurchasingEX) = False Then D3429.AmountPurchasingEX = Trim$(rs3429!K3429_AmountPurchasingEX)
    If IsdbNull(rs3429!K3429_AmountPurchasingVND) = False Then D3429.AmountPurchasingVND = Trim$(rs3429!K3429_AmountPurchasingVND)
    If IsdbNull(rs3429!K3429_AmountTaxEX) = False Then D3429.AmountTaxEX = Trim$(rs3429!K3429_AmountTaxEX)
    If IsdbNull(rs3429!K3429_AmountTaxVND) = False Then D3429.AmountTaxVND = Trim$(rs3429!K3429_AmountTaxVND)
    If IsdbNull(rs3429!K3429_PctExpense) = False Then D3429.PctExpense = Trim$(rs3429!K3429_PctExpense)
    If IsdbNull(rs3429!K3429_AmountExpenseEX) = False Then D3429.AmountExpenseEX = Trim$(rs3429!K3429_AmountExpenseEX)
    If IsdbNull(rs3429!K3429_AmountExpensVND) = False Then D3429.AmountExpensVND = Trim$(rs3429!K3429_AmountExpensVND)
    If IsdbNull(rs3429!K3429_seTax1) = False Then D3429.seTax1 = Trim$(rs3429!K3429_seTax1)
    If IsdbNull(rs3429!K3429_cdTax1) = False Then D3429.cdTax1 = Trim$(rs3429!K3429_cdTax1)
    If IsdbNull(rs3429!K3429_PerTax1) = False Then D3429.PerTax1 = Trim$(rs3429!K3429_PerTax1)
    If IsdbNull(rs3429!K3429_AmountTax1) = False Then D3429.AmountTax1 = Trim$(rs3429!K3429_AmountTax1)
    If IsdbNull(rs3429!K3429_seTax2) = False Then D3429.seTax2 = Trim$(rs3429!K3429_seTax2)
    If IsdbNull(rs3429!K3429_cdTax2) = False Then D3429.cdTax2 = Trim$(rs3429!K3429_cdTax2)
    If IsdbNull(rs3429!K3429_PerTax2) = False Then D3429.PerTax2 = Trim$(rs3429!K3429_PerTax2)
    If IsdbNull(rs3429!K3429_AmountTax2) = False Then D3429.AmountTax2 = Trim$(rs3429!K3429_AmountTax2)
    If IsdbNull(rs3429!K3429_seTax3) = False Then D3429.seTax3 = Trim$(rs3429!K3429_seTax3)
    If IsdbNull(rs3429!K3429_cdTax3) = False Then D3429.cdTax3 = Trim$(rs3429!K3429_cdTax3)
    If IsdbNull(rs3429!K3429_PerTax3) = False Then D3429.PerTax3 = Trim$(rs3429!K3429_PerTax3)
    If IsdbNull(rs3429!K3429_AmountTax3) = False Then D3429.AmountTax3 = Trim$(rs3429!K3429_AmountTax3)
    If IsdbNull(rs3429!K3429_QtyPurchasing) = False Then D3429.QtyPurchasing = Trim$(rs3429!K3429_QtyPurchasing)
    If IsdbNull(rs3429!K3429_PackPurchasing) = False Then D3429.PackPurchasing = Trim$(rs3429!K3429_PackPurchasing)
    If IsdbNull(rs3429!K3429_QtyWarehouse) = False Then D3429.QtyWarehouse = Trim$(rs3429!K3429_QtyWarehouse)
    If IsdbNull(rs3429!K3429_PackWarehouse) = False Then D3429.PackWarehouse = Trim$(rs3429!K3429_PackWarehouse)
    If IsdbNull(rs3429!K3429_QtyInbound) = False Then D3429.QtyInbound = Trim$(rs3429!K3429_QtyInbound)
    If IsdbNull(rs3429!K3429_PackInbound) = False Then D3429.PackInbound = Trim$(rs3429!K3429_PackInbound)
    If IsdbNull(rs3429!K3429_QtyOutbound) = False Then D3429.QtyOutbound = Trim$(rs3429!K3429_QtyOutbound)
    If IsdbNull(rs3429!K3429_PackOutbound) = False Then D3429.PackOutbound = Trim$(rs3429!K3429_PackOutbound)
    If IsdbNull(rs3429!K3429_AmountEX) = False Then D3429.AmountEX = Trim$(rs3429!K3429_AmountEX)
    If IsdbNull(rs3429!K3429_AmountVND) = False Then D3429.AmountVND = Trim$(rs3429!K3429_AmountVND)
    If IsdbNull(rs3429!K3429_AmountInBoundEX) = False Then D3429.AmountInBoundEX = Trim$(rs3429!K3429_AmountInBoundEX)
            If IsDBNull(rs3429!K3429_AmountInBoundVND) = False Then D3429.AmountInBoundVND = Trim$(rs3429!K3429_AmountInBoundVND)
            If IsDBNull(rs3429!K3429_AMOUNTFCT) = False Then D3429.AmountFCT = Trim$(rs3429!K3429_AMOUNTFCT)
            If IsDBNull(rs3429!K3429_AMOUNTFCT2) = False Then D3429.AmountFCT2 = Trim$(rs3429!K3429_AMOUNTFCT2)
    If IsdbNull(rs3429!K3429_DateDelivery) = False Then D3429.DateDelivery = Trim$(rs3429!K3429_DateDelivery)
    If IsdbNull(rs3429!K3429_DateStart) = False Then D3429.DateStart = Trim$(rs3429!K3429_DateStart)
    If IsdbNull(rs3429!K3429_DateFinish) = False Then D3429.DateFinish = Trim$(rs3429!K3429_DateFinish)
    If IsdbNull(rs3429!K3429_CheckPurchasing) = False Then D3429.CheckPurchasing = Trim$(rs3429!K3429_CheckPurchasing)
    If IsdbNull(rs3429!K3429_DateAccept) = False Then D3429.DateAccept = Trim$(rs3429!K3429_DateAccept)
    If IsdbNull(rs3429!K3429_DatePosted) = False Then D3429.DatePosted = Trim$(rs3429!K3429_DatePosted)
    If IsdbNull(rs3429!K3429_IsPosted) = False Then D3429.IsPosted = Trim$(rs3429!K3429_IsPosted)
    If IsdbNull(rs3429!K3429_DateComplete) = False Then D3429.DateComplete = Trim$(rs3429!K3429_DateComplete)
    If IsdbNull(rs3429!K3429_DateApproval) = False Then D3429.DateApproval = Trim$(rs3429!K3429_DateApproval)
    If IsdbNull(rs3429!K3429_DateCancel) = False Then D3429.DateCancel = Trim$(rs3429!K3429_DateCancel)
    If IsdbNull(rs3429!K3429_CheckComplete) = False Then D3429.CheckComplete = Trim$(rs3429!K3429_CheckComplete)
    If IsdbNull(rs3429!K3429_PurchasingOrderNo) = False Then D3429.PurchasingOrderNo = Trim$(rs3429!K3429_PurchasingOrderNo)
    If IsdbNull(rs3429!K3429_PurchasingOrderSeq) = False Then D3429.PurchasingOrderSeq = Trim$(rs3429!K3429_PurchasingOrderSeq)
    If IsdbNull(rs3429!K3429_JobCardWorking) = False Then D3429.JobCardWorking = Trim$(rs3429!K3429_JobCardWorking)
    If IsdbNull(rs3429!K3429_JobCardWorkingSeq) = False Then D3429.JobCardWorkingSeq = Trim$(rs3429!K3429_JobCardWorkingSeq)
    If IsdbNull(rs3429!K3429_JobCardType) = False Then D3429.JobCardType = Trim$(rs3429!K3429_JobCardType)
    If IsdbNull(rs3429!K3429_SalesOrderNo) = False Then D3429.SalesOrderNo = Trim$(rs3429!K3429_SalesOrderNo)
    If IsdbNull(rs3429!K3429_SalesOrderSeq) = False Then D3429.SalesOrderSeq = Trim$(rs3429!K3429_SalesOrderSeq)
    If IsdbNull(rs3429!K3429_SalesOrderSno) = False Then D3429.SalesOrderSno = Trim$(rs3429!K3429_SalesOrderSno)
    If IsdbNull(rs3429!K3429_OrderNo) = False Then D3429.OrderNo = Trim$(rs3429!K3429_OrderNo)
    If IsdbNull(rs3429!K3429_OrderNoSeq) = False Then D3429.OrderNoSeq = Trim$(rs3429!K3429_OrderNoSeq)
    If IsdbNull(rs3429!K3429_Remark) = False Then D3429.Remark = Trim$(rs3429!K3429_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K3429_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K3429_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z3429 As T3429_AREA, PAYABLENO AS String, PAYABLENOSEQ AS Double) as Boolean

K3429_MOVE = False

Try
    If READ_PFK3429(PAYABLENO, PAYABLENOSEQ) = True Then
                z3429 = D3429
		K3429_MOVE = True
		else
	z3429 = nothing
     End If

     If  getColumIndex(spr,"PayableNo") > -1 then z3429.PayableNo = getDataM(spr, getColumIndex(spr,"PayableNo"), xRow)
     If  getColumIndex(spr,"PayableNoSeq") > -1 then z3429.PayableNoSeq = getDataM(spr, getColumIndex(spr,"PayableNoSeq"), xRow)
     If  getColumIndex(spr,"CheckTypePayable") > -1 then z3429.CheckTypePayable = getDataM(spr, getColumIndex(spr,"CheckTypePayable"), xRow)
     If  getColumIndex(spr,"FactOrderNo") > -1 then z3429.FactOrderNo = getDataM(spr, getColumIndex(spr,"FactOrderNo"), xRow)
     If  getColumIndex(spr,"FactOrderSeq") > -1 then z3429.FactOrderSeq = getDataM(spr, getColumIndex(spr,"FactOrderSeq"), xRow)
     If  getColumIndex(spr,"DienGiai") > -1 then z3429.DienGiai = getDataM(spr, getColumIndex(spr,"DienGiai"), xRow)
     If  getColumIndex(spr,"DienGiai2") > -1 then z3429.DienGiai2 = getDataM(spr, getColumIndex(spr,"DienGiai2"), xRow)
     If  getColumIndex(spr,"SeriInvoice") > -1 then z3429.SeriInvoice = getDataM(spr, getColumIndex(spr,"SeriInvoice"), xRow)
     If  getColumIndex(spr,"PurchaseInvoice1") > -1 then z3429.PurchaseInvoice1 = getDataM(spr, getColumIndex(spr,"PurchaseInvoice1"), xRow)
     If  getColumIndex(spr,"DateInvoice") > -1 then z3429.DateInvoice = getDataM(spr, getColumIndex(spr,"DateInvoice"), xRow)
     If  getColumIndex(spr,"MaterialInBoundNo") > -1 then z3429.MaterialInBoundNo = getDataM(spr, getColumIndex(spr,"MaterialInBoundNo"), xRow)
     If  getColumIndex(spr,"MaterialInBoundSeq") > -1 then z3429.MaterialInBoundSeq = getDataM(spr, getColumIndex(spr,"MaterialInBoundSeq"), xRow)
     If  getColumIndex(spr,"seSite") > -1 then z3429.seSite = getDataM(spr, getColumIndex(spr,"seSite"), xRow)
     If  getColumIndex(spr,"cdSite") > -1 then z3429.cdSite = getDataM(spr, getColumIndex(spr,"cdSite"), xRow)
     If  getColumIndex(spr,"seDepartment") > -1 then z3429.seDepartment = getDataM(spr, getColumIndex(spr,"seDepartment"), xRow)
     If  getColumIndex(spr,"cdDepartment") > -1 then z3429.cdDepartment = getDataM(spr, getColumIndex(spr,"cdDepartment"), xRow)
     If  getColumIndex(spr,"seFactory") > -1 then z3429.seFactory = getDataM(spr, getColumIndex(spr,"seFactory"), xRow)
     If  getColumIndex(spr,"cdFactory") > -1 then z3429.cdFactory = getDataM(spr, getColumIndex(spr,"cdFactory"), xRow)
     If  getColumIndex(spr,"seLineProd") > -1 then z3429.seLineProd = getDataM(spr, getColumIndex(spr,"seLineProd"), xRow)
     If  getColumIndex(spr,"cdLineProd") > -1 then z3429.cdLineProd = getDataM(spr, getColumIndex(spr,"cdLineProd"), xRow)
     If  getColumIndex(spr,"seSubProcess") > -1 then z3429.seSubProcess = getDataM(spr, getColumIndex(spr,"seSubProcess"), xRow)
     If  getColumIndex(spr,"cdSubProcess") > -1 then z3429.cdSubProcess = getDataM(spr, getColumIndex(spr,"cdSubProcess"), xRow)
     If  getColumIndex(spr,"CustomerSupplier") > -1 then z3429.CustomerSupplier = getDataM(spr, getColumIndex(spr,"CustomerSupplier"), xRow)
     If  getColumIndex(spr,"Dseq") > -1 then z3429.Dseq = getDataM(spr, getColumIndex(spr,"Dseq"), xRow)
     If  getColumIndex(spr,"AutokeyK3011") > -1 then z3429.AutokeyK3011 = getDataM(spr, getColumIndex(spr,"AutokeyK3011"), xRow)
     If  getColumIndex(spr,"CheckRelationType") > -1 then z3429.CheckRelationType = getDataM(spr, getColumIndex(spr,"CheckRelationType"), xRow)
     If  getColumIndex(spr,"MaterialCode") > -1 then z3429.MaterialCode = getDataM(spr, getColumIndex(spr,"MaterialCode"), xRow)
     If  getColumIndex(spr,"Specification") > -1 then z3429.Specification = getDataM(spr, getColumIndex(spr,"Specification"), xRow)
     If  getColumIndex(spr,"Width") > -1 then z3429.Width = getDataM(spr, getColumIndex(spr,"Width"), xRow)
     If  getColumIndex(spr,"Height") > -1 then z3429.Height = getDataM(spr, getColumIndex(spr,"Height"), xRow)
     If  getColumIndex(spr,"SizeNo") > -1 then z3429.SizeNo = getDataM(spr, getColumIndex(spr,"SizeNo"), xRow)
     If  getColumIndex(spr,"SizeName") > -1 then z3429.SizeName = getDataM(spr, getColumIndex(spr,"SizeName"), xRow)
     If  getColumIndex(spr,"ColorCode") > -1 then z3429.ColorCode = getDataM(spr, getColumIndex(spr,"ColorCode"), xRow)
     If  getColumIndex(spr,"ColorName") > -1 then z3429.ColorName = getDataM(spr, getColumIndex(spr,"ColorName"), xRow)
     If  getColumIndex(spr,"seOrigin") > -1 then z3429.seOrigin = getDataM(spr, getColumIndex(spr,"seOrigin"), xRow)
     If  getColumIndex(spr,"cdOrigin") > -1 then z3429.cdOrigin = getDataM(spr, getColumIndex(spr,"cdOrigin"), xRow)
     If  getColumIndex(spr,"MaterialCheck") > -1 then z3429.MaterialCheck = getDataM(spr, getColumIndex(spr,"MaterialCheck"), xRow)
     If  getColumIndex(spr,"seUnitPrice") > -1 then z3429.seUnitPrice = getDataM(spr, getColumIndex(spr,"seUnitPrice"), xRow)
     If  getColumIndex(spr,"cdUnitPrice") > -1 then z3429.cdUnitPrice = getDataM(spr, getColumIndex(spr,"cdUnitPrice"), xRow)
     If  getColumIndex(spr,"seTax") > -1 then z3429.seTax = getDataM(spr, getColumIndex(spr,"seTax"), xRow)
     If  getColumIndex(spr,"cdTax") > -1 then z3429.cdTax = getDataM(spr, getColumIndex(spr,"cdTax"), xRow)
     If  getColumIndex(spr,"seUnitMaterial") > -1 then z3429.seUnitMaterial = getDataM(spr, getColumIndex(spr,"seUnitMaterial"), xRow)
     If  getColumIndex(spr,"cdUnitMaterial") > -1 then z3429.cdUnitMaterial = getDataM(spr, getColumIndex(spr,"cdUnitMaterial"), xRow)
     If  getColumIndex(spr,"seUnitPacking") > -1 then z3429.seUnitPacking = getDataM(spr, getColumIndex(spr,"seUnitPacking"), xRow)
     If  getColumIndex(spr,"cdUnitPacking") > -1 then z3429.cdUnitPacking = getDataM(spr, getColumIndex(spr,"cdUnitPacking"), xRow)
     If  getColumIndex(spr,"UnitBaseCheck") > -1 then z3429.UnitBaseCheck = getDataM(spr, getColumIndex(spr,"UnitBaseCheck"), xRow)
     If  getColumIndex(spr,"TypeDiscount") > -1 then z3429.TypeDiscount = getDataM(spr, getColumIndex(spr,"TypeDiscount"), xRow)
     If  getColumIndex(spr,"PerDiscount") > -1 then z3429.PerDiscount = getDataM(spr, getColumIndex(spr,"PerDiscount"), xRow)
     If  getColumIndex(spr,"AmtDiscount") > -1 then z3429.AmtDiscount = getDataM(spr, getColumIndex(spr,"AmtDiscount"), xRow)
     If  getColumIndex(spr,"QtyBasic") > -1 then z3429.QtyBasic = getDataM(spr, getColumIndex(spr,"QtyBasic"), xRow)
     If  getColumIndex(spr,"PricePurchasing") > -1 then z3429.PricePurchasing = getDataM(spr, getColumIndex(spr,"PricePurchasing"), xRow)
     If  getColumIndex(spr,"PriceMarket") > -1 then z3429.PriceMarket = getDataM(spr, getColumIndex(spr,"PriceMarket"), xRow)
     If  getColumIndex(spr,"PriceExchange") > -1 then z3429.PriceExchange = getDataM(spr, getColumIndex(spr,"PriceExchange"), xRow)
     If  getColumIndex(spr,"PriceExchangeAP") > -1 then z3429.PriceExchangeAP = getDataM(spr, getColumIndex(spr,"PriceExchangeAP"), xRow)
     If  getColumIndex(spr,"DateExchange") > -1 then z3429.DateExchange = getDataM(spr, getColumIndex(spr,"DateExchange"), xRow)
     If  getColumIndex(spr,"PricePurchasingEX") > -1 then z3429.PricePurchasingEX = getDataM(spr, getColumIndex(spr,"PricePurchasingEX"), xRow)
     If  getColumIndex(spr,"PriceMarketEX") > -1 then z3429.PriceMarketEX = getDataM(spr, getColumIndex(spr,"PriceMarketEX"), xRow)
     If  getColumIndex(spr,"PricePurchasingVND") > -1 then z3429.PricePurchasingVND = getDataM(spr, getColumIndex(spr,"PricePurchasingVND"), xRow)
     If  getColumIndex(spr,"PriceMarketVND") > -1 then z3429.PriceMarketVND = getDataM(spr, getColumIndex(spr,"PriceMarketVND"), xRow)
     If  getColumIndex(spr,"AmountPurchasingEX") > -1 then z3429.AmountPurchasingEX = getDataM(spr, getColumIndex(spr,"AmountPurchasingEX"), xRow)
     If  getColumIndex(spr,"AmountPurchasingVND") > -1 then z3429.AmountPurchasingVND = getDataM(spr, getColumIndex(spr,"AmountPurchasingVND"), xRow)
     If  getColumIndex(spr,"AmountTaxEX") > -1 then z3429.AmountTaxEX = getDataM(spr, getColumIndex(spr,"AmountTaxEX"), xRow)
     If  getColumIndex(spr,"AmountTaxVND") > -1 then z3429.AmountTaxVND = getDataM(spr, getColumIndex(spr,"AmountTaxVND"), xRow)
     If  getColumIndex(spr,"PctExpense") > -1 then z3429.PctExpense = getDataM(spr, getColumIndex(spr,"PctExpense"), xRow)
     If  getColumIndex(spr,"AmountExpenseEX") > -1 then z3429.AmountExpenseEX = getDataM(spr, getColumIndex(spr,"AmountExpenseEX"), xRow)
     If  getColumIndex(spr,"AmountExpensVND") > -1 then z3429.AmountExpensVND = getDataM(spr, getColumIndex(spr,"AmountExpensVND"), xRow)
     If  getColumIndex(spr,"seTax1") > -1 then z3429.seTax1 = getDataM(spr, getColumIndex(spr,"seTax1"), xRow)
     If  getColumIndex(spr,"cdTax1") > -1 then z3429.cdTax1 = getDataM(spr, getColumIndex(spr,"cdTax1"), xRow)
     If  getColumIndex(spr,"PerTax1") > -1 then z3429.PerTax1 = getDataM(spr, getColumIndex(spr,"PerTax1"), xRow)
     If  getColumIndex(spr,"AmountTax1") > -1 then z3429.AmountTax1 = getDataM(spr, getColumIndex(spr,"AmountTax1"), xRow)
     If  getColumIndex(spr,"seTax2") > -1 then z3429.seTax2 = getDataM(spr, getColumIndex(spr,"seTax2"), xRow)
     If  getColumIndex(spr,"cdTax2") > -1 then z3429.cdTax2 = getDataM(spr, getColumIndex(spr,"cdTax2"), xRow)
     If  getColumIndex(spr,"PerTax2") > -1 then z3429.PerTax2 = getDataM(spr, getColumIndex(spr,"PerTax2"), xRow)
     If  getColumIndex(spr,"AmountTax2") > -1 then z3429.AmountTax2 = getDataM(spr, getColumIndex(spr,"AmountTax2"), xRow)
     If  getColumIndex(spr,"seTax3") > -1 then z3429.seTax3 = getDataM(spr, getColumIndex(spr,"seTax3"), xRow)
     If  getColumIndex(spr,"cdTax3") > -1 then z3429.cdTax3 = getDataM(spr, getColumIndex(spr,"cdTax3"), xRow)
     If  getColumIndex(spr,"PerTax3") > -1 then z3429.PerTax3 = getDataM(spr, getColumIndex(spr,"PerTax3"), xRow)
     If  getColumIndex(spr,"AmountTax3") > -1 then z3429.AmountTax3 = getDataM(spr, getColumIndex(spr,"AmountTax3"), xRow)
     If  getColumIndex(spr,"QtyPurchasing") > -1 then z3429.QtyPurchasing = getDataM(spr, getColumIndex(spr,"QtyPurchasing"), xRow)
     If  getColumIndex(spr,"PackPurchasing") > -1 then z3429.PackPurchasing = getDataM(spr, getColumIndex(spr,"PackPurchasing"), xRow)
     If  getColumIndex(spr,"QtyWarehouse") > -1 then z3429.QtyWarehouse = getDataM(spr, getColumIndex(spr,"QtyWarehouse"), xRow)
     If  getColumIndex(spr,"PackWarehouse") > -1 then z3429.PackWarehouse = getDataM(spr, getColumIndex(spr,"PackWarehouse"), xRow)
     If  getColumIndex(spr,"QtyInbound") > -1 then z3429.QtyInbound = getDataM(spr, getColumIndex(spr,"QtyInbound"), xRow)
     If  getColumIndex(spr,"PackInbound") > -1 then z3429.PackInbound = getDataM(spr, getColumIndex(spr,"PackInbound"), xRow)
     If  getColumIndex(spr,"QtyOutbound") > -1 then z3429.QtyOutbound = getDataM(spr, getColumIndex(spr,"QtyOutbound"), xRow)
     If  getColumIndex(spr,"PackOutbound") > -1 then z3429.PackOutbound = getDataM(spr, getColumIndex(spr,"PackOutbound"), xRow)
     If  getColumIndex(spr,"AmountEX") > -1 then z3429.AmountEX = getDataM(spr, getColumIndex(spr,"AmountEX"), xRow)
     If  getColumIndex(spr,"AmountVND") > -1 then z3429.AmountVND = getDataM(spr, getColumIndex(spr,"AmountVND"), xRow)
     If  getColumIndex(spr,"AmountInBoundEX") > -1 then z3429.AmountInBoundEX = getDataM(spr, getColumIndex(spr,"AmountInBoundEX"), xRow)
            If getColumIndex(spr, "AmountInBoundVND") > -1 Then z3429.AmountInBoundVND = getDataM(spr, getColumIndex(spr, "AmountInBoundVND"), xRow)
            If getColumIndex(spr, "AmountFCT") > -1 Then z3429.AmountFCT = getDataM(spr, getColumIndex(spr, "AmountFCT"), xRow)
            If getColumIndex(spr, "AmountFCT2") > -1 Then z3429.AmountFCT2 = getDataM(spr, getColumIndex(spr, "AmountFCT2"), xRow)
     If  getColumIndex(spr,"DateDelivery") > -1 then z3429.DateDelivery = getDataM(spr, getColumIndex(spr,"DateDelivery"), xRow)
     If  getColumIndex(spr,"DateStart") > -1 then z3429.DateStart = getDataM(spr, getColumIndex(spr,"DateStart"), xRow)
     If  getColumIndex(spr,"DateFinish") > -1 then z3429.DateFinish = getDataM(spr, getColumIndex(spr,"DateFinish"), xRow)
     If  getColumIndex(spr,"CheckPurchasing") > -1 then z3429.CheckPurchasing = getDataM(spr, getColumIndex(spr,"CheckPurchasing"), xRow)
     If  getColumIndex(spr,"DateAccept") > -1 then z3429.DateAccept = getDataM(spr, getColumIndex(spr,"DateAccept"), xRow)
     If  getColumIndex(spr,"DatePosted") > -1 then z3429.DatePosted = getDataM(spr, getColumIndex(spr,"DatePosted"), xRow)
     If  getColumIndex(spr,"IsPosted") > -1 then z3429.IsPosted = getDataM(spr, getColumIndex(spr,"IsPosted"), xRow)
     If  getColumIndex(spr,"DateComplete") > -1 then z3429.DateComplete = getDataM(spr, getColumIndex(spr,"DateComplete"), xRow)
     If  getColumIndex(spr,"DateApproval") > -1 then z3429.DateApproval = getDataM(spr, getColumIndex(spr,"DateApproval"), xRow)
     If  getColumIndex(spr,"DateCancel") > -1 then z3429.DateCancel = getDataM(spr, getColumIndex(spr,"DateCancel"), xRow)
     If  getColumIndex(spr,"CheckComplete") > -1 then z3429.CheckComplete = getDataM(spr, getColumIndex(spr,"CheckComplete"), xRow)
     If  getColumIndex(spr,"PurchasingOrderNo") > -1 then z3429.PurchasingOrderNo = getDataM(spr, getColumIndex(spr,"PurchasingOrderNo"), xRow)
     If  getColumIndex(spr,"PurchasingOrderSeq") > -1 then z3429.PurchasingOrderSeq = getDataM(spr, getColumIndex(spr,"PurchasingOrderSeq"), xRow)
     If  getColumIndex(spr,"JobCardWorking") > -1 then z3429.JobCardWorking = getDataM(spr, getColumIndex(spr,"JobCardWorking"), xRow)
     If  getColumIndex(spr,"JobCardWorkingSeq") > -1 then z3429.JobCardWorkingSeq = getDataM(spr, getColumIndex(spr,"JobCardWorkingSeq"), xRow)
     If  getColumIndex(spr,"JobCardType") > -1 then z3429.JobCardType = getDataM(spr, getColumIndex(spr,"JobCardType"), xRow)
     If  getColumIndex(spr,"SalesOrderNo") > -1 then z3429.SalesOrderNo = getDataM(spr, getColumIndex(spr,"SalesOrderNo"), xRow)
     If  getColumIndex(spr,"SalesOrderSeq") > -1 then z3429.SalesOrderSeq = getDataM(spr, getColumIndex(spr,"SalesOrderSeq"), xRow)
     If  getColumIndex(spr,"SalesOrderSno") > -1 then z3429.SalesOrderSno = getDataM(spr, getColumIndex(spr,"SalesOrderSno"), xRow)
     If  getColumIndex(spr,"OrderNo") > -1 then z3429.OrderNo = getDataM(spr, getColumIndex(spr,"OrderNo"), xRow)
     If  getColumIndex(spr,"OrderNoSeq") > -1 then z3429.OrderNoSeq = getDataM(spr, getColumIndex(spr,"OrderNoSeq"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z3429.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K3429_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K3429_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z3429 As T3429_AREA,CheckClear as Boolean,PAYABLENO AS String, PAYABLENOSEQ AS Double) as Boolean

K3429_MOVE = False

Try
    If READ_PFK3429(PAYABLENO, PAYABLENOSEQ) = True Then
                z3429 = D3429
		K3429_MOVE = True
		else
	If CheckClear  = True then z3429 = nothing
     End If

     If  getColumIndex(spr,"PayableNo") > -1 then z3429.PayableNo = getDataM(spr, getColumIndex(spr,"PayableNo"), xRow)
     If  getColumIndex(spr,"PayableNoSeq") > -1 then z3429.PayableNoSeq = getDataM(spr, getColumIndex(spr,"PayableNoSeq"), xRow)
     If  getColumIndex(spr,"CheckTypePayable") > -1 then z3429.CheckTypePayable = getDataM(spr, getColumIndex(spr,"CheckTypePayable"), xRow)
     If  getColumIndex(spr,"FactOrderNo") > -1 then z3429.FactOrderNo = getDataM(spr, getColumIndex(spr,"FactOrderNo"), xRow)
     If  getColumIndex(spr,"FactOrderSeq") > -1 then z3429.FactOrderSeq = getDataM(spr, getColumIndex(spr,"FactOrderSeq"), xRow)
     If  getColumIndex(spr,"DienGiai") > -1 then z3429.DienGiai = getDataM(spr, getColumIndex(spr,"DienGiai"), xRow)
     If  getColumIndex(spr,"DienGiai2") > -1 then z3429.DienGiai2 = getDataM(spr, getColumIndex(spr,"DienGiai2"), xRow)
     If  getColumIndex(spr,"SeriInvoice") > -1 then z3429.SeriInvoice = getDataM(spr, getColumIndex(spr,"SeriInvoice"), xRow)
     If  getColumIndex(spr,"PurchaseInvoice1") > -1 then z3429.PurchaseInvoice1 = getDataM(spr, getColumIndex(spr,"PurchaseInvoice1"), xRow)
     If  getColumIndex(spr,"DateInvoice") > -1 then z3429.DateInvoice = getDataM(spr, getColumIndex(spr,"DateInvoice"), xRow)
     If  getColumIndex(spr,"MaterialInBoundNo") > -1 then z3429.MaterialInBoundNo = getDataM(spr, getColumIndex(spr,"MaterialInBoundNo"), xRow)
     If  getColumIndex(spr,"MaterialInBoundSeq") > -1 then z3429.MaterialInBoundSeq = getDataM(spr, getColumIndex(spr,"MaterialInBoundSeq"), xRow)
     If  getColumIndex(spr,"seSite") > -1 then z3429.seSite = getDataM(spr, getColumIndex(spr,"seSite"), xRow)
     If  getColumIndex(spr,"cdSite") > -1 then z3429.cdSite = getDataM(spr, getColumIndex(spr,"cdSite"), xRow)
     If  getColumIndex(spr,"seDepartment") > -1 then z3429.seDepartment = getDataM(spr, getColumIndex(spr,"seDepartment"), xRow)
     If  getColumIndex(spr,"cdDepartment") > -1 then z3429.cdDepartment = getDataM(spr, getColumIndex(spr,"cdDepartment"), xRow)
     If  getColumIndex(spr,"seFactory") > -1 then z3429.seFactory = getDataM(spr, getColumIndex(spr,"seFactory"), xRow)
     If  getColumIndex(spr,"cdFactory") > -1 then z3429.cdFactory = getDataM(spr, getColumIndex(spr,"cdFactory"), xRow)
     If  getColumIndex(spr,"seLineProd") > -1 then z3429.seLineProd = getDataM(spr, getColumIndex(spr,"seLineProd"), xRow)
     If  getColumIndex(spr,"cdLineProd") > -1 then z3429.cdLineProd = getDataM(spr, getColumIndex(spr,"cdLineProd"), xRow)
     If  getColumIndex(spr,"seSubProcess") > -1 then z3429.seSubProcess = getDataM(spr, getColumIndex(spr,"seSubProcess"), xRow)
     If  getColumIndex(spr,"cdSubProcess") > -1 then z3429.cdSubProcess = getDataM(spr, getColumIndex(spr,"cdSubProcess"), xRow)
     If  getColumIndex(spr,"CustomerSupplier") > -1 then z3429.CustomerSupplier = getDataM(spr, getColumIndex(spr,"CustomerSupplier"), xRow)
     If  getColumIndex(spr,"Dseq") > -1 then z3429.Dseq = getDataM(spr, getColumIndex(spr,"Dseq"), xRow)
     If  getColumIndex(spr,"AutokeyK3011") > -1 then z3429.AutokeyK3011 = getDataM(spr, getColumIndex(spr,"AutokeyK3011"), xRow)
     If  getColumIndex(spr,"CheckRelationType") > -1 then z3429.CheckRelationType = getDataM(spr, getColumIndex(spr,"CheckRelationType"), xRow)
     If  getColumIndex(spr,"MaterialCode") > -1 then z3429.MaterialCode = getDataM(spr, getColumIndex(spr,"MaterialCode"), xRow)
     If  getColumIndex(spr,"Specification") > -1 then z3429.Specification = getDataM(spr, getColumIndex(spr,"Specification"), xRow)
     If  getColumIndex(spr,"Width") > -1 then z3429.Width = getDataM(spr, getColumIndex(spr,"Width"), xRow)
     If  getColumIndex(spr,"Height") > -1 then z3429.Height = getDataM(spr, getColumIndex(spr,"Height"), xRow)
     If  getColumIndex(spr,"SizeNo") > -1 then z3429.SizeNo = getDataM(spr, getColumIndex(spr,"SizeNo"), xRow)
     If  getColumIndex(spr,"SizeName") > -1 then z3429.SizeName = getDataM(spr, getColumIndex(spr,"SizeName"), xRow)
     If  getColumIndex(spr,"ColorCode") > -1 then z3429.ColorCode = getDataM(spr, getColumIndex(spr,"ColorCode"), xRow)
     If  getColumIndex(spr,"ColorName") > -1 then z3429.ColorName = getDataM(spr, getColumIndex(spr,"ColorName"), xRow)
     If  getColumIndex(spr,"seOrigin") > -1 then z3429.seOrigin = getDataM(spr, getColumIndex(spr,"seOrigin"), xRow)
     If  getColumIndex(spr,"cdOrigin") > -1 then z3429.cdOrigin = getDataM(spr, getColumIndex(spr,"cdOrigin"), xRow)
     If  getColumIndex(spr,"MaterialCheck") > -1 then z3429.MaterialCheck = getDataM(spr, getColumIndex(spr,"MaterialCheck"), xRow)
     If  getColumIndex(spr,"seUnitPrice") > -1 then z3429.seUnitPrice = getDataM(spr, getColumIndex(spr,"seUnitPrice"), xRow)
     If  getColumIndex(spr,"cdUnitPrice") > -1 then z3429.cdUnitPrice = getDataM(spr, getColumIndex(spr,"cdUnitPrice"), xRow)
     If  getColumIndex(spr,"seTax") > -1 then z3429.seTax = getDataM(spr, getColumIndex(spr,"seTax"), xRow)
     If  getColumIndex(spr,"cdTax") > -1 then z3429.cdTax = getDataM(spr, getColumIndex(spr,"cdTax"), xRow)
     If  getColumIndex(spr,"seUnitMaterial") > -1 then z3429.seUnitMaterial = getDataM(spr, getColumIndex(spr,"seUnitMaterial"), xRow)
     If  getColumIndex(spr,"cdUnitMaterial") > -1 then z3429.cdUnitMaterial = getDataM(spr, getColumIndex(spr,"cdUnitMaterial"), xRow)
     If  getColumIndex(spr,"seUnitPacking") > -1 then z3429.seUnitPacking = getDataM(spr, getColumIndex(spr,"seUnitPacking"), xRow)
     If  getColumIndex(spr,"cdUnitPacking") > -1 then z3429.cdUnitPacking = getDataM(spr, getColumIndex(spr,"cdUnitPacking"), xRow)
     If  getColumIndex(spr,"UnitBaseCheck") > -1 then z3429.UnitBaseCheck = getDataM(spr, getColumIndex(spr,"UnitBaseCheck"), xRow)
     If  getColumIndex(spr,"TypeDiscount") > -1 then z3429.TypeDiscount = getDataM(spr, getColumIndex(spr,"TypeDiscount"), xRow)
     If  getColumIndex(spr,"PerDiscount") > -1 then z3429.PerDiscount = getDataM(spr, getColumIndex(spr,"PerDiscount"), xRow)
     If  getColumIndex(spr,"AmtDiscount") > -1 then z3429.AmtDiscount = getDataM(spr, getColumIndex(spr,"AmtDiscount"), xRow)
     If  getColumIndex(spr,"QtyBasic") > -1 then z3429.QtyBasic = getDataM(spr, getColumIndex(spr,"QtyBasic"), xRow)
     If  getColumIndex(spr,"PricePurchasing") > -1 then z3429.PricePurchasing = getDataM(spr, getColumIndex(spr,"PricePurchasing"), xRow)
     If  getColumIndex(spr,"PriceMarket") > -1 then z3429.PriceMarket = getDataM(spr, getColumIndex(spr,"PriceMarket"), xRow)
     If  getColumIndex(spr,"PriceExchange") > -1 then z3429.PriceExchange = getDataM(spr, getColumIndex(spr,"PriceExchange"), xRow)
     If  getColumIndex(spr,"PriceExchangeAP") > -1 then z3429.PriceExchangeAP = getDataM(spr, getColumIndex(spr,"PriceExchangeAP"), xRow)
     If  getColumIndex(spr,"DateExchange") > -1 then z3429.DateExchange = getDataM(spr, getColumIndex(spr,"DateExchange"), xRow)
     If  getColumIndex(spr,"PricePurchasingEX") > -1 then z3429.PricePurchasingEX = getDataM(spr, getColumIndex(spr,"PricePurchasingEX"), xRow)
     If  getColumIndex(spr,"PriceMarketEX") > -1 then z3429.PriceMarketEX = getDataM(spr, getColumIndex(spr,"PriceMarketEX"), xRow)
     If  getColumIndex(spr,"PricePurchasingVND") > -1 then z3429.PricePurchasingVND = getDataM(spr, getColumIndex(spr,"PricePurchasingVND"), xRow)
     If  getColumIndex(spr,"PriceMarketVND") > -1 then z3429.PriceMarketVND = getDataM(spr, getColumIndex(spr,"PriceMarketVND"), xRow)
     If  getColumIndex(spr,"AmountPurchasingEX") > -1 then z3429.AmountPurchasingEX = getDataM(spr, getColumIndex(spr,"AmountPurchasingEX"), xRow)
     If  getColumIndex(spr,"AmountPurchasingVND") > -1 then z3429.AmountPurchasingVND = getDataM(spr, getColumIndex(spr,"AmountPurchasingVND"), xRow)
     If  getColumIndex(spr,"AmountTaxEX") > -1 then z3429.AmountTaxEX = getDataM(spr, getColumIndex(spr,"AmountTaxEX"), xRow)
     If  getColumIndex(spr,"AmountTaxVND") > -1 then z3429.AmountTaxVND = getDataM(spr, getColumIndex(spr,"AmountTaxVND"), xRow)
     If  getColumIndex(spr,"PctExpense") > -1 then z3429.PctExpense = getDataM(spr, getColumIndex(spr,"PctExpense"), xRow)
     If  getColumIndex(spr,"AmountExpenseEX") > -1 then z3429.AmountExpenseEX = getDataM(spr, getColumIndex(spr,"AmountExpenseEX"), xRow)
     If  getColumIndex(spr,"AmountExpensVND") > -1 then z3429.AmountExpensVND = getDataM(spr, getColumIndex(spr,"AmountExpensVND"), xRow)
     If  getColumIndex(spr,"seTax1") > -1 then z3429.seTax1 = getDataM(spr, getColumIndex(spr,"seTax1"), xRow)
     If  getColumIndex(spr,"cdTax1") > -1 then z3429.cdTax1 = getDataM(spr, getColumIndex(spr,"cdTax1"), xRow)
     If  getColumIndex(spr,"PerTax1") > -1 then z3429.PerTax1 = getDataM(spr, getColumIndex(spr,"PerTax1"), xRow)
     If  getColumIndex(spr,"AmountTax1") > -1 then z3429.AmountTax1 = getDataM(spr, getColumIndex(spr,"AmountTax1"), xRow)
     If  getColumIndex(spr,"seTax2") > -1 then z3429.seTax2 = getDataM(spr, getColumIndex(spr,"seTax2"), xRow)
     If  getColumIndex(spr,"cdTax2") > -1 then z3429.cdTax2 = getDataM(spr, getColumIndex(spr,"cdTax2"), xRow)
     If  getColumIndex(spr,"PerTax2") > -1 then z3429.PerTax2 = getDataM(spr, getColumIndex(spr,"PerTax2"), xRow)
     If  getColumIndex(spr,"AmountTax2") > -1 then z3429.AmountTax2 = getDataM(spr, getColumIndex(spr,"AmountTax2"), xRow)
     If  getColumIndex(spr,"seTax3") > -1 then z3429.seTax3 = getDataM(spr, getColumIndex(spr,"seTax3"), xRow)
     If  getColumIndex(spr,"cdTax3") > -1 then z3429.cdTax3 = getDataM(spr, getColumIndex(spr,"cdTax3"), xRow)
     If  getColumIndex(spr,"PerTax3") > -1 then z3429.PerTax3 = getDataM(spr, getColumIndex(spr,"PerTax3"), xRow)
     If  getColumIndex(spr,"AmountTax3") > -1 then z3429.AmountTax3 = getDataM(spr, getColumIndex(spr,"AmountTax3"), xRow)
     If  getColumIndex(spr,"QtyPurchasing") > -1 then z3429.QtyPurchasing = getDataM(spr, getColumIndex(spr,"QtyPurchasing"), xRow)
     If  getColumIndex(spr,"PackPurchasing") > -1 then z3429.PackPurchasing = getDataM(spr, getColumIndex(spr,"PackPurchasing"), xRow)
     If  getColumIndex(spr,"QtyWarehouse") > -1 then z3429.QtyWarehouse = getDataM(spr, getColumIndex(spr,"QtyWarehouse"), xRow)
     If  getColumIndex(spr,"PackWarehouse") > -1 then z3429.PackWarehouse = getDataM(spr, getColumIndex(spr,"PackWarehouse"), xRow)
     If  getColumIndex(spr,"QtyInbound") > -1 then z3429.QtyInbound = getDataM(spr, getColumIndex(spr,"QtyInbound"), xRow)
     If  getColumIndex(spr,"PackInbound") > -1 then z3429.PackInbound = getDataM(spr, getColumIndex(spr,"PackInbound"), xRow)
     If  getColumIndex(spr,"QtyOutbound") > -1 then z3429.QtyOutbound = getDataM(spr, getColumIndex(spr,"QtyOutbound"), xRow)
     If  getColumIndex(spr,"PackOutbound") > -1 then z3429.PackOutbound = getDataM(spr, getColumIndex(spr,"PackOutbound"), xRow)
     If  getColumIndex(spr,"AmountEX") > -1 then z3429.AmountEX = getDataM(spr, getColumIndex(spr,"AmountEX"), xRow)
     If  getColumIndex(spr,"AmountVND") > -1 then z3429.AmountVND = getDataM(spr, getColumIndex(spr,"AmountVND"), xRow)
     If  getColumIndex(spr,"AmountInBoundEX") > -1 then z3429.AmountInBoundEX = getDataM(spr, getColumIndex(spr,"AmountInBoundEX"), xRow)
            If getColumIndex(spr, "AmountInBoundVND") > -1 Then z3429.AmountInBoundVND = getDataM(spr, getColumIndex(spr, "AmountInBoundVND"), xRow)
            If getColumIndex(spr, "AmountFCT") > -1 Then z3429.AmountFCT = getDataM(spr, getColumIndex(spr, "AmountFCT"), xRow)
            If getColumIndex(spr, "AmountFCT2") > -1 Then z3429.AmountFCT2 = getDataM(spr, getColumIndex(spr, "AmountFCT2"), xRow)
     If  getColumIndex(spr,"DateDelivery") > -1 then z3429.DateDelivery = getDataM(spr, getColumIndex(spr,"DateDelivery"), xRow)
     If  getColumIndex(spr,"DateStart") > -1 then z3429.DateStart = getDataM(spr, getColumIndex(spr,"DateStart"), xRow)
     If  getColumIndex(spr,"DateFinish") > -1 then z3429.DateFinish = getDataM(spr, getColumIndex(spr,"DateFinish"), xRow)
     If  getColumIndex(spr,"CheckPurchasing") > -1 then z3429.CheckPurchasing = getDataM(spr, getColumIndex(spr,"CheckPurchasing"), xRow)
     If  getColumIndex(spr,"DateAccept") > -1 then z3429.DateAccept = getDataM(spr, getColumIndex(spr,"DateAccept"), xRow)
     If  getColumIndex(spr,"DatePosted") > -1 then z3429.DatePosted = getDataM(spr, getColumIndex(spr,"DatePosted"), xRow)
     If  getColumIndex(spr,"IsPosted") > -1 then z3429.IsPosted = getDataM(spr, getColumIndex(spr,"IsPosted"), xRow)
     If  getColumIndex(spr,"DateComplete") > -1 then z3429.DateComplete = getDataM(spr, getColumIndex(spr,"DateComplete"), xRow)
     If  getColumIndex(spr,"DateApproval") > -1 then z3429.DateApproval = getDataM(spr, getColumIndex(spr,"DateApproval"), xRow)
     If  getColumIndex(spr,"DateCancel") > -1 then z3429.DateCancel = getDataM(spr, getColumIndex(spr,"DateCancel"), xRow)
     If  getColumIndex(spr,"CheckComplete") > -1 then z3429.CheckComplete = getDataM(spr, getColumIndex(spr,"CheckComplete"), xRow)
     If  getColumIndex(spr,"PurchasingOrderNo") > -1 then z3429.PurchasingOrderNo = getDataM(spr, getColumIndex(spr,"PurchasingOrderNo"), xRow)
     If  getColumIndex(spr,"PurchasingOrderSeq") > -1 then z3429.PurchasingOrderSeq = getDataM(spr, getColumIndex(spr,"PurchasingOrderSeq"), xRow)
     If  getColumIndex(spr,"JobCardWorking") > -1 then z3429.JobCardWorking = getDataM(spr, getColumIndex(spr,"JobCardWorking"), xRow)
     If  getColumIndex(spr,"JobCardWorkingSeq") > -1 then z3429.JobCardWorkingSeq = getDataM(spr, getColumIndex(spr,"JobCardWorkingSeq"), xRow)
     If  getColumIndex(spr,"JobCardType") > -1 then z3429.JobCardType = getDataM(spr, getColumIndex(spr,"JobCardType"), xRow)
     If  getColumIndex(spr,"SalesOrderNo") > -1 then z3429.SalesOrderNo = getDataM(spr, getColumIndex(spr,"SalesOrderNo"), xRow)
     If  getColumIndex(spr,"SalesOrderSeq") > -1 then z3429.SalesOrderSeq = getDataM(spr, getColumIndex(spr,"SalesOrderSeq"), xRow)
     If  getColumIndex(spr,"SalesOrderSno") > -1 then z3429.SalesOrderSno = getDataM(spr, getColumIndex(spr,"SalesOrderSno"), xRow)
     If  getColumIndex(spr,"OrderNo") > -1 then z3429.OrderNo = getDataM(spr, getColumIndex(spr,"OrderNo"), xRow)
     If  getColumIndex(spr,"OrderNoSeq") > -1 then z3429.OrderNoSeq = getDataM(spr, getColumIndex(spr,"OrderNoSeq"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z3429.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K3429_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K3429_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z3429 As T3429_AREA, Job as String, PAYABLENO AS String, PAYABLENOSEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K3429_MOVE = False

Try
    If READ_PFK3429(PAYABLENO, PAYABLENOSEQ) = True Then
                z3429 = D3429
		K3429_MOVE = True
		else
	z3429 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3429")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "PAYABLENO":z3429.PayableNo = Children(i).Code
   Case "PAYABLENOSEQ":z3429.PayableNoSeq = Children(i).Code
   Case "CHECKTYPEPAYABLE":z3429.CheckTypePayable = Children(i).Code
   Case "FACTORDERNO":z3429.FactOrderNo = Children(i).Code
   Case "FACTORDERSEQ":z3429.FactOrderSeq = Children(i).Code
   Case "DIENGIAI":z3429.DienGiai = Children(i).Code
   Case "DIENGIAI2":z3429.DienGiai2 = Children(i).Code
   Case "SERIINVOICE":z3429.SeriInvoice = Children(i).Code
   Case "PURCHASEINVOICE1":z3429.PurchaseInvoice1 = Children(i).Code
   Case "DATEINVOICE":z3429.DateInvoice = Children(i).Code
   Case "MATERIALINBOUNDNO":z3429.MaterialInBoundNo = Children(i).Code
   Case "MATERIALINBOUNDSEQ":z3429.MaterialInBoundSeq = Children(i).Code
   Case "SESITE":z3429.seSite = Children(i).Code
   Case "CDSITE":z3429.cdSite = Children(i).Code
   Case "SEDEPARTMENT":z3429.seDepartment = Children(i).Code
   Case "CDDEPARTMENT":z3429.cdDepartment = Children(i).Code
   Case "SEFACTORY":z3429.seFactory = Children(i).Code
   Case "CDFACTORY":z3429.cdFactory = Children(i).Code
   Case "SELINEPROD":z3429.seLineProd = Children(i).Code
   Case "CDLINEPROD":z3429.cdLineProd = Children(i).Code
   Case "SESUBPROCESS":z3429.seSubProcess = Children(i).Code
   Case "CDSUBPROCESS":z3429.cdSubProcess = Children(i).Code
   Case "CUSTOMERSUPPLIER":z3429.CustomerSupplier = Children(i).Code
   Case "DSEQ":z3429.Dseq = Children(i).Code
   Case "AUTOKEYK3011":z3429.AutokeyK3011 = Children(i).Code
   Case "CHECKRELATIONTYPE":z3429.CheckRelationType = Children(i).Code
   Case "MATERIALCODE":z3429.MaterialCode = Children(i).Code
   Case "SPECIFICATION":z3429.Specification = Children(i).Code
   Case "WIDTH":z3429.Width = Children(i).Code
   Case "HEIGHT":z3429.Height = Children(i).Code
   Case "SIZENO":z3429.SizeNo = Children(i).Code
   Case "SIZENAME":z3429.SizeName = Children(i).Code
   Case "COLORCODE":z3429.ColorCode = Children(i).Code
   Case "COLORNAME":z3429.ColorName = Children(i).Code
   Case "SEORIGIN":z3429.seOrigin = Children(i).Code
   Case "CDORIGIN":z3429.cdOrigin = Children(i).Code
   Case "MATERIALCHECK":z3429.MaterialCheck = Children(i).Code
   Case "SEUNITPRICE":z3429.seUnitPrice = Children(i).Code
   Case "CDUNITPRICE":z3429.cdUnitPrice = Children(i).Code
   Case "SETAX":z3429.seTax = Children(i).Code
   Case "CDTAX":z3429.cdTax = Children(i).Code
   Case "SEUNITMATERIAL":z3429.seUnitMaterial = Children(i).Code
   Case "CDUNITMATERIAL":z3429.cdUnitMaterial = Children(i).Code
   Case "SEUNITPACKING":z3429.seUnitPacking = Children(i).Code
   Case "CDUNITPACKING":z3429.cdUnitPacking = Children(i).Code
   Case "UNITBASECHECK":z3429.UnitBaseCheck = Children(i).Code
   Case "TYPEDISCOUNT":z3429.TypeDiscount = Children(i).Code
   Case "PERDISCOUNT":z3429.PerDiscount = Children(i).Code
   Case "AMTDISCOUNT":z3429.AmtDiscount = Children(i).Code
   Case "QTYBASIC":z3429.QtyBasic = Children(i).Code
   Case "PRICEPURCHASING":z3429.PricePurchasing = Children(i).Code
   Case "PRICEMARKET":z3429.PriceMarket = Children(i).Code
   Case "PRICEEXCHANGE":z3429.PriceExchange = Children(i).Code
   Case "PRICEEXCHANGEAP":z3429.PriceExchangeAP = Children(i).Code
   Case "DATEEXCHANGE":z3429.DateExchange = Children(i).Code
   Case "PRICEPURCHASINGEX":z3429.PricePurchasingEX = Children(i).Code
   Case "PRICEMARKETEX":z3429.PriceMarketEX = Children(i).Code
   Case "PRICEPURCHASINGVND":z3429.PricePurchasingVND = Children(i).Code
   Case "PRICEMARKETVND":z3429.PriceMarketVND = Children(i).Code
   Case "AMOUNTPURCHASINGEX":z3429.AmountPurchasingEX = Children(i).Code
   Case "AMOUNTPURCHASINGVND":z3429.AmountPurchasingVND = Children(i).Code
   Case "AMOUNTTAXEX":z3429.AmountTaxEX = Children(i).Code
   Case "AMOUNTTAXVND":z3429.AmountTaxVND = Children(i).Code
   Case "PCTEXPENSE":z3429.PctExpense = Children(i).Code
   Case "AMOUNTEXPENSEEX":z3429.AmountExpenseEX = Children(i).Code
   Case "AMOUNTEXPENSVND":z3429.AmountExpensVND = Children(i).Code
   Case "SETAX1":z3429.seTax1 = Children(i).Code
   Case "CDTAX1":z3429.cdTax1 = Children(i).Code
   Case "PERTAX1":z3429.PerTax1 = Children(i).Code
   Case "AMOUNTTAX1":z3429.AmountTax1 = Children(i).Code
   Case "SETAX2":z3429.seTax2 = Children(i).Code
   Case "CDTAX2":z3429.cdTax2 = Children(i).Code
   Case "PERTAX2":z3429.PerTax2 = Children(i).Code
   Case "AMOUNTTAX2":z3429.AmountTax2 = Children(i).Code
   Case "SETAX3":z3429.seTax3 = Children(i).Code
   Case "CDTAX3":z3429.cdTax3 = Children(i).Code
   Case "PERTAX3":z3429.PerTax3 = Children(i).Code
   Case "AMOUNTTAX3":z3429.AmountTax3 = Children(i).Code
   Case "QTYPURCHASING":z3429.QtyPurchasing = Children(i).Code
   Case "PACKPURCHASING":z3429.PackPurchasing = Children(i).Code
   Case "QTYWAREHOUSE":z3429.QtyWarehouse = Children(i).Code
   Case "PACKWAREHOUSE":z3429.PackWarehouse = Children(i).Code
   Case "QTYINBOUND":z3429.QtyInbound = Children(i).Code
   Case "PACKINBOUND":z3429.PackInbound = Children(i).Code
   Case "QTYOUTBOUND":z3429.QtyOutbound = Children(i).Code
   Case "PACKOUTBOUND":z3429.PackOutbound = Children(i).Code
   Case "AMOUNTEX":z3429.AmountEX = Children(i).Code
   Case "AMOUNTVND":z3429.AmountVND = Children(i).Code
   Case "AMOUNTINBOUNDEX":z3429.AmountInBoundEX = Children(i).Code
                                Case "AMOUNTINBOUNDVND" : z3429.AmountInBoundVND = Children(i).Code
                                Case "AMOUNTFCT" : z3429.AmountFCT = Children(i).Code
                                Case "AMOUNTFCT2" : z3429.AmountFCT2 = Children(i).Code
   Case "DATEDELIVERY":z3429.DateDelivery = Children(i).Code
   Case "DATESTART":z3429.DateStart = Children(i).Code
   Case "DATEFINISH":z3429.DateFinish = Children(i).Code
   Case "CHECKPURCHASING":z3429.CheckPurchasing = Children(i).Code
   Case "DATEACCEPT":z3429.DateAccept = Children(i).Code
   Case "DATEPOSTED":z3429.DatePosted = Children(i).Code
   Case "ISPOSTED":z3429.IsPosted = Children(i).Code
   Case "DATECOMPLETE":z3429.DateComplete = Children(i).Code
   Case "DATEAPPROVAL":z3429.DateApproval = Children(i).Code
   Case "DATECANCEL":z3429.DateCancel = Children(i).Code
   Case "CHECKCOMPLETE":z3429.CheckComplete = Children(i).Code
   Case "PURCHASINGORDERNO":z3429.PurchasingOrderNo = Children(i).Code
   Case "PURCHASINGORDERSEQ":z3429.PurchasingOrderSeq = Children(i).Code
   Case "JOBCARDWORKING":z3429.JobCardWorking = Children(i).Code
   Case "JOBCARDWORKINGSEQ":z3429.JobCardWorkingSeq = Children(i).Code
   Case "JOBCARDTYPE":z3429.JobCardType = Children(i).Code
   Case "SALESORDERNO":z3429.SalesOrderNo = Children(i).Code
   Case "SALESORDERSEQ":z3429.SalesOrderSeq = Children(i).Code
   Case "SALESORDERSNO":z3429.SalesOrderSno = Children(i).Code
   Case "ORDERNO":z3429.OrderNo = Children(i).Code
   Case "ORDERNOSEQ":z3429.OrderNoSeq = Children(i).Code
   Case "REMARK":z3429.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "PAYABLENO":z3429.PayableNo = Children(i).Data
   Case "PAYABLENOSEQ":z3429.PayableNoSeq = Children(i).Data
   Case "CHECKTYPEPAYABLE":z3429.CheckTypePayable = Children(i).Data
   Case "FACTORDERNO":z3429.FactOrderNo = Children(i).Data
   Case "FACTORDERSEQ":z3429.FactOrderSeq = Children(i).Data
   Case "DIENGIAI":z3429.DienGiai = Children(i).Data
   Case "DIENGIAI2":z3429.DienGiai2 = Children(i).Data
   Case "SERIINVOICE":z3429.SeriInvoice = Children(i).Data
   Case "PURCHASEINVOICE1":z3429.PurchaseInvoice1 = Children(i).Data
   Case "DATEINVOICE":z3429.DateInvoice = Children(i).Data
   Case "MATERIALINBOUNDNO":z3429.MaterialInBoundNo = Children(i).Data
   Case "MATERIALINBOUNDSEQ":z3429.MaterialInBoundSeq = Children(i).Data
   Case "SESITE":z3429.seSite = Children(i).Data
   Case "CDSITE":z3429.cdSite = Children(i).Data
   Case "SEDEPARTMENT":z3429.seDepartment = Children(i).Data
   Case "CDDEPARTMENT":z3429.cdDepartment = Children(i).Data
   Case "SEFACTORY":z3429.seFactory = Children(i).Data
   Case "CDFACTORY":z3429.cdFactory = Children(i).Data
   Case "SELINEPROD":z3429.seLineProd = Children(i).Data
   Case "CDLINEPROD":z3429.cdLineProd = Children(i).Data
   Case "SESUBPROCESS":z3429.seSubProcess = Children(i).Data
   Case "CDSUBPROCESS":z3429.cdSubProcess = Children(i).Data
   Case "CUSTOMERSUPPLIER":z3429.CustomerSupplier = Children(i).Data
   Case "DSEQ":z3429.Dseq = Children(i).Data
   Case "AUTOKEYK3011":z3429.AutokeyK3011 = Children(i).Data
   Case "CHECKRELATIONTYPE":z3429.CheckRelationType = Children(i).Data
   Case "MATERIALCODE":z3429.MaterialCode = Children(i).Data
   Case "SPECIFICATION":z3429.Specification = Children(i).Data
   Case "WIDTH":z3429.Width = Children(i).Data
   Case "HEIGHT":z3429.Height = Children(i).Data
   Case "SIZENO":z3429.SizeNo = Children(i).Data
   Case "SIZENAME":z3429.SizeName = Children(i).Data
   Case "COLORCODE":z3429.ColorCode = Children(i).Data
   Case "COLORNAME":z3429.ColorName = Children(i).Data
   Case "SEORIGIN":z3429.seOrigin = Children(i).Data
   Case "CDORIGIN":z3429.cdOrigin = Children(i).Data
   Case "MATERIALCHECK":z3429.MaterialCheck = Children(i).Data
   Case "SEUNITPRICE":z3429.seUnitPrice = Children(i).Data
   Case "CDUNITPRICE":z3429.cdUnitPrice = Children(i).Data
   Case "SETAX":z3429.seTax = Children(i).Data
   Case "CDTAX":z3429.cdTax = Children(i).Data
   Case "SEUNITMATERIAL":z3429.seUnitMaterial = Children(i).Data
   Case "CDUNITMATERIAL":z3429.cdUnitMaterial = Children(i).Data
   Case "SEUNITPACKING":z3429.seUnitPacking = Children(i).Data
   Case "CDUNITPACKING":z3429.cdUnitPacking = Children(i).Data
   Case "UNITBASECHECK":z3429.UnitBaseCheck = Children(i).Data
   Case "TYPEDISCOUNT":z3429.TypeDiscount = Children(i).Data
   Case "PERDISCOUNT":z3429.PerDiscount = Children(i).Data
   Case "AMTDISCOUNT":z3429.AmtDiscount = Children(i).Data
   Case "QTYBASIC":z3429.QtyBasic = Children(i).Data
   Case "PRICEPURCHASING":z3429.PricePurchasing = Children(i).Data
   Case "PRICEMARKET":z3429.PriceMarket = Children(i).Data
   Case "PRICEEXCHANGE":z3429.PriceExchange = Children(i).Data
   Case "PRICEEXCHANGEAP":z3429.PriceExchangeAP = Children(i).Data
   Case "DATEEXCHANGE":z3429.DateExchange = Children(i).Data
   Case "PRICEPURCHASINGEX":z3429.PricePurchasingEX = Children(i).Data
   Case "PRICEMARKETEX":z3429.PriceMarketEX = Children(i).Data
   Case "PRICEPURCHASINGVND":z3429.PricePurchasingVND = Children(i).Data
   Case "PRICEMARKETVND":z3429.PriceMarketVND = Children(i).Data
   Case "AMOUNTPURCHASINGEX":z3429.AmountPurchasingEX = Children(i).Data
   Case "AMOUNTPURCHASINGVND":z3429.AmountPurchasingVND = Children(i).Data
   Case "AMOUNTTAXEX":z3429.AmountTaxEX = Children(i).Data
   Case "AMOUNTTAXVND":z3429.AmountTaxVND = Children(i).Data
   Case "PCTEXPENSE":z3429.PctExpense = Children(i).Data
   Case "AMOUNTEXPENSEEX":z3429.AmountExpenseEX = Children(i).Data
   Case "AMOUNTEXPENSVND":z3429.AmountExpensVND = Children(i).Data
   Case "SETAX1":z3429.seTax1 = Children(i).Data
   Case "CDTAX1":z3429.cdTax1 = Children(i).Data
   Case "PERTAX1":z3429.PerTax1 = Children(i).Data
   Case "AMOUNTTAX1":z3429.AmountTax1 = Children(i).Data
   Case "SETAX2":z3429.seTax2 = Children(i).Data
   Case "CDTAX2":z3429.cdTax2 = Children(i).Data
   Case "PERTAX2":z3429.PerTax2 = Children(i).Data
   Case "AMOUNTTAX2":z3429.AmountTax2 = Children(i).Data
   Case "SETAX3":z3429.seTax3 = Children(i).Data
   Case "CDTAX3":z3429.cdTax3 = Children(i).Data
   Case "PERTAX3":z3429.PerTax3 = Children(i).Data
   Case "AMOUNTTAX3":z3429.AmountTax3 = Children(i).Data
   Case "QTYPURCHASING":z3429.QtyPurchasing = Children(i).Data
   Case "PACKPURCHASING":z3429.PackPurchasing = Children(i).Data
   Case "QTYWAREHOUSE":z3429.QtyWarehouse = Children(i).Data
   Case "PACKWAREHOUSE":z3429.PackWarehouse = Children(i).Data
   Case "QTYINBOUND":z3429.QtyInbound = Children(i).Data
   Case "PACKINBOUND":z3429.PackInbound = Children(i).Data
   Case "QTYOUTBOUND":z3429.QtyOutbound = Children(i).Data
   Case "PACKOUTBOUND":z3429.PackOutbound = Children(i).Data
   Case "AMOUNTEX":z3429.AmountEX = Children(i).Data
   Case "AMOUNTVND":z3429.AmountVND = Children(i).Data
   Case "AMOUNTINBOUNDEX":z3429.AmountInBoundEX = Children(i).Data
                                Case "AMOUNTINBOUNDVND" : z3429.AmountInBoundVND = Children(i).Data
                                Case "AMOUNTFCT" : z3429.AmountFCT = Children(i).Data
                                Case "AMOUNTFCT2" : z3429.AmountFCT2 = Children(i).Data
   Case "DATEDELIVERY":z3429.DateDelivery = Children(i).Data
   Case "DATESTART":z3429.DateStart = Children(i).Data
   Case "DATEFINISH":z3429.DateFinish = Children(i).Data
   Case "CHECKPURCHASING":z3429.CheckPurchasing = Children(i).Data
   Case "DATEACCEPT":z3429.DateAccept = Children(i).Data
   Case "DATEPOSTED":z3429.DatePosted = Children(i).Data
   Case "ISPOSTED":z3429.IsPosted = Children(i).Data
   Case "DATECOMPLETE":z3429.DateComplete = Children(i).Data
   Case "DATEAPPROVAL":z3429.DateApproval = Children(i).Data
   Case "DATECANCEL":z3429.DateCancel = Children(i).Data
   Case "CHECKCOMPLETE":z3429.CheckComplete = Children(i).Data
   Case "PURCHASINGORDERNO":z3429.PurchasingOrderNo = Children(i).Data
   Case "PURCHASINGORDERSEQ":z3429.PurchasingOrderSeq = Children(i).Data
   Case "JOBCARDWORKING":z3429.JobCardWorking = Children(i).Data
   Case "JOBCARDWORKINGSEQ":z3429.JobCardWorkingSeq = Children(i).Data
   Case "JOBCARDTYPE":z3429.JobCardType = Children(i).Data
   Case "SALESORDERNO":z3429.SalesOrderNo = Children(i).Data
   Case "SALESORDERSEQ":z3429.SalesOrderSeq = Children(i).Data
   Case "SALESORDERSNO":z3429.SalesOrderSno = Children(i).Data
   Case "ORDERNO":z3429.OrderNo = Children(i).Data
   Case "ORDERNOSEQ":z3429.OrderNoSeq = Children(i).Data
   Case "REMARK":z3429.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K3429_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K3429_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z3429 As T3429_AREA, Job as String, CheckClear as Boolean, PAYABLENO AS String, PAYABLENOSEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K3429_MOVE = False

Try
    If READ_PFK3429(PAYABLENO, PAYABLENOSEQ) = True Then
                z3429 = D3429
		K3429_MOVE = True
		else
	If CheckClear  = True then z3429 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3429")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "PAYABLENO":z3429.PayableNo = Children(i).Code
   Case "PAYABLENOSEQ":z3429.PayableNoSeq = Children(i).Code
   Case "CHECKTYPEPAYABLE":z3429.CheckTypePayable = Children(i).Code
   Case "FACTORDERNO":z3429.FactOrderNo = Children(i).Code
   Case "FACTORDERSEQ":z3429.FactOrderSeq = Children(i).Code
   Case "DIENGIAI":z3429.DienGiai = Children(i).Code
   Case "DIENGIAI2":z3429.DienGiai2 = Children(i).Code
   Case "SERIINVOICE":z3429.SeriInvoice = Children(i).Code
   Case "PURCHASEINVOICE1":z3429.PurchaseInvoice1 = Children(i).Code
   Case "DATEINVOICE":z3429.DateInvoice = Children(i).Code
   Case "MATERIALINBOUNDNO":z3429.MaterialInBoundNo = Children(i).Code
   Case "MATERIALINBOUNDSEQ":z3429.MaterialInBoundSeq = Children(i).Code
   Case "SESITE":z3429.seSite = Children(i).Code
   Case "CDSITE":z3429.cdSite = Children(i).Code
   Case "SEDEPARTMENT":z3429.seDepartment = Children(i).Code
   Case "CDDEPARTMENT":z3429.cdDepartment = Children(i).Code
   Case "SEFACTORY":z3429.seFactory = Children(i).Code
   Case "CDFACTORY":z3429.cdFactory = Children(i).Code
   Case "SELINEPROD":z3429.seLineProd = Children(i).Code
   Case "CDLINEPROD":z3429.cdLineProd = Children(i).Code
   Case "SESUBPROCESS":z3429.seSubProcess = Children(i).Code
   Case "CDSUBPROCESS":z3429.cdSubProcess = Children(i).Code
   Case "CUSTOMERSUPPLIER":z3429.CustomerSupplier = Children(i).Code
   Case "DSEQ":z3429.Dseq = Children(i).Code
   Case "AUTOKEYK3011":z3429.AutokeyK3011 = Children(i).Code
   Case "CHECKRELATIONTYPE":z3429.CheckRelationType = Children(i).Code
   Case "MATERIALCODE":z3429.MaterialCode = Children(i).Code
   Case "SPECIFICATION":z3429.Specification = Children(i).Code
   Case "WIDTH":z3429.Width = Children(i).Code
   Case "HEIGHT":z3429.Height = Children(i).Code
   Case "SIZENO":z3429.SizeNo = Children(i).Code
   Case "SIZENAME":z3429.SizeName = Children(i).Code
   Case "COLORCODE":z3429.ColorCode = Children(i).Code
   Case "COLORNAME":z3429.ColorName = Children(i).Code
   Case "SEORIGIN":z3429.seOrigin = Children(i).Code
   Case "CDORIGIN":z3429.cdOrigin = Children(i).Code
   Case "MATERIALCHECK":z3429.MaterialCheck = Children(i).Code
   Case "SEUNITPRICE":z3429.seUnitPrice = Children(i).Code
   Case "CDUNITPRICE":z3429.cdUnitPrice = Children(i).Code
   Case "SETAX":z3429.seTax = Children(i).Code
   Case "CDTAX":z3429.cdTax = Children(i).Code
   Case "SEUNITMATERIAL":z3429.seUnitMaterial = Children(i).Code
   Case "CDUNITMATERIAL":z3429.cdUnitMaterial = Children(i).Code
   Case "SEUNITPACKING":z3429.seUnitPacking = Children(i).Code
   Case "CDUNITPACKING":z3429.cdUnitPacking = Children(i).Code
   Case "UNITBASECHECK":z3429.UnitBaseCheck = Children(i).Code
   Case "TYPEDISCOUNT":z3429.TypeDiscount = Children(i).Code
   Case "PERDISCOUNT":z3429.PerDiscount = Children(i).Code
   Case "AMTDISCOUNT":z3429.AmtDiscount = Children(i).Code
   Case "QTYBASIC":z3429.QtyBasic = Children(i).Code
   Case "PRICEPURCHASING":z3429.PricePurchasing = Children(i).Code
   Case "PRICEMARKET":z3429.PriceMarket = Children(i).Code
   Case "PRICEEXCHANGE":z3429.PriceExchange = Children(i).Code
   Case "PRICEEXCHANGEAP":z3429.PriceExchangeAP = Children(i).Code
   Case "DATEEXCHANGE":z3429.DateExchange = Children(i).Code
   Case "PRICEPURCHASINGEX":z3429.PricePurchasingEX = Children(i).Code
   Case "PRICEMARKETEX":z3429.PriceMarketEX = Children(i).Code
   Case "PRICEPURCHASINGVND":z3429.PricePurchasingVND = Children(i).Code
   Case "PRICEMARKETVND":z3429.PriceMarketVND = Children(i).Code
   Case "AMOUNTPURCHASINGEX":z3429.AmountPurchasingEX = Children(i).Code
   Case "AMOUNTPURCHASINGVND":z3429.AmountPurchasingVND = Children(i).Code
   Case "AMOUNTTAXEX":z3429.AmountTaxEX = Children(i).Code
   Case "AMOUNTTAXVND":z3429.AmountTaxVND = Children(i).Code
   Case "PCTEXPENSE":z3429.PctExpense = Children(i).Code
   Case "AMOUNTEXPENSEEX":z3429.AmountExpenseEX = Children(i).Code
   Case "AMOUNTEXPENSVND":z3429.AmountExpensVND = Children(i).Code
   Case "SETAX1":z3429.seTax1 = Children(i).Code
   Case "CDTAX1":z3429.cdTax1 = Children(i).Code
   Case "PERTAX1":z3429.PerTax1 = Children(i).Code
   Case "AMOUNTTAX1":z3429.AmountTax1 = Children(i).Code
   Case "SETAX2":z3429.seTax2 = Children(i).Code
   Case "CDTAX2":z3429.cdTax2 = Children(i).Code
   Case "PERTAX2":z3429.PerTax2 = Children(i).Code
   Case "AMOUNTTAX2":z3429.AmountTax2 = Children(i).Code
   Case "SETAX3":z3429.seTax3 = Children(i).Code
   Case "CDTAX3":z3429.cdTax3 = Children(i).Code
   Case "PERTAX3":z3429.PerTax3 = Children(i).Code
   Case "AMOUNTTAX3":z3429.AmountTax3 = Children(i).Code
   Case "QTYPURCHASING":z3429.QtyPurchasing = Children(i).Code
   Case "PACKPURCHASING":z3429.PackPurchasing = Children(i).Code
   Case "QTYWAREHOUSE":z3429.QtyWarehouse = Children(i).Code
   Case "PACKWAREHOUSE":z3429.PackWarehouse = Children(i).Code
   Case "QTYINBOUND":z3429.QtyInbound = Children(i).Code
   Case "PACKINBOUND":z3429.PackInbound = Children(i).Code
   Case "QTYOUTBOUND":z3429.QtyOutbound = Children(i).Code
   Case "PACKOUTBOUND":z3429.PackOutbound = Children(i).Code
   Case "AMOUNTEX":z3429.AmountEX = Children(i).Code
   Case "AMOUNTVND":z3429.AmountVND = Children(i).Code
   Case "AMOUNTINBOUNDEX":z3429.AmountInBoundEX = Children(i).Code
                                Case "AMOUNTINBOUNDVND" : z3429.AmountInBoundVND = Children(i).Code
                                Case "AMOUNTFCT" : z3429.AmountFCT = Children(i).Code
                                Case "AMOUNTFCT2" : z3429.AmountFCT2 = Children(i).Code
   Case "DATEDELIVERY":z3429.DateDelivery = Children(i).Code
   Case "DATESTART":z3429.DateStart = Children(i).Code
   Case "DATEFINISH":z3429.DateFinish = Children(i).Code
   Case "CHECKPURCHASING":z3429.CheckPurchasing = Children(i).Code
   Case "DATEACCEPT":z3429.DateAccept = Children(i).Code
   Case "DATEPOSTED":z3429.DatePosted = Children(i).Code
   Case "ISPOSTED":z3429.IsPosted = Children(i).Code
   Case "DATECOMPLETE":z3429.DateComplete = Children(i).Code
   Case "DATEAPPROVAL":z3429.DateApproval = Children(i).Code
   Case "DATECANCEL":z3429.DateCancel = Children(i).Code
   Case "CHECKCOMPLETE":z3429.CheckComplete = Children(i).Code
   Case "PURCHASINGORDERNO":z3429.PurchasingOrderNo = Children(i).Code
   Case "PURCHASINGORDERSEQ":z3429.PurchasingOrderSeq = Children(i).Code
   Case "JOBCARDWORKING":z3429.JobCardWorking = Children(i).Code
   Case "JOBCARDWORKINGSEQ":z3429.JobCardWorkingSeq = Children(i).Code
   Case "JOBCARDTYPE":z3429.JobCardType = Children(i).Code
   Case "SALESORDERNO":z3429.SalesOrderNo = Children(i).Code
   Case "SALESORDERSEQ":z3429.SalesOrderSeq = Children(i).Code
   Case "SALESORDERSNO":z3429.SalesOrderSno = Children(i).Code
   Case "ORDERNO":z3429.OrderNo = Children(i).Code
   Case "ORDERNOSEQ":z3429.OrderNoSeq = Children(i).Code
   Case "REMARK":z3429.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "PAYABLENO":z3429.PayableNo = Children(i).Data
   Case "PAYABLENOSEQ":z3429.PayableNoSeq = Children(i).Data
   Case "CHECKTYPEPAYABLE":z3429.CheckTypePayable = Children(i).Data
   Case "FACTORDERNO":z3429.FactOrderNo = Children(i).Data
   Case "FACTORDERSEQ":z3429.FactOrderSeq = Children(i).Data
   Case "DIENGIAI":z3429.DienGiai = Children(i).Data
   Case "DIENGIAI2":z3429.DienGiai2 = Children(i).Data
   Case "SERIINVOICE":z3429.SeriInvoice = Children(i).Data
   Case "PURCHASEINVOICE1":z3429.PurchaseInvoice1 = Children(i).Data
   Case "DATEINVOICE":z3429.DateInvoice = Children(i).Data
   Case "MATERIALINBOUNDNO":z3429.MaterialInBoundNo = Children(i).Data
   Case "MATERIALINBOUNDSEQ":z3429.MaterialInBoundSeq = Children(i).Data
   Case "SESITE":z3429.seSite = Children(i).Data
   Case "CDSITE":z3429.cdSite = Children(i).Data
   Case "SEDEPARTMENT":z3429.seDepartment = Children(i).Data
   Case "CDDEPARTMENT":z3429.cdDepartment = Children(i).Data
   Case "SEFACTORY":z3429.seFactory = Children(i).Data
   Case "CDFACTORY":z3429.cdFactory = Children(i).Data
   Case "SELINEPROD":z3429.seLineProd = Children(i).Data
   Case "CDLINEPROD":z3429.cdLineProd = Children(i).Data
   Case "SESUBPROCESS":z3429.seSubProcess = Children(i).Data
   Case "CDSUBPROCESS":z3429.cdSubProcess = Children(i).Data
   Case "CUSTOMERSUPPLIER":z3429.CustomerSupplier = Children(i).Data
   Case "DSEQ":z3429.Dseq = Children(i).Data
   Case "AUTOKEYK3011":z3429.AutokeyK3011 = Children(i).Data
   Case "CHECKRELATIONTYPE":z3429.CheckRelationType = Children(i).Data
   Case "MATERIALCODE":z3429.MaterialCode = Children(i).Data
   Case "SPECIFICATION":z3429.Specification = Children(i).Data
   Case "WIDTH":z3429.Width = Children(i).Data
   Case "HEIGHT":z3429.Height = Children(i).Data
   Case "SIZENO":z3429.SizeNo = Children(i).Data
   Case "SIZENAME":z3429.SizeName = Children(i).Data
   Case "COLORCODE":z3429.ColorCode = Children(i).Data
   Case "COLORNAME":z3429.ColorName = Children(i).Data
   Case "SEORIGIN":z3429.seOrigin = Children(i).Data
   Case "CDORIGIN":z3429.cdOrigin = Children(i).Data
   Case "MATERIALCHECK":z3429.MaterialCheck = Children(i).Data
   Case "SEUNITPRICE":z3429.seUnitPrice = Children(i).Data
   Case "CDUNITPRICE":z3429.cdUnitPrice = Children(i).Data
   Case "SETAX":z3429.seTax = Children(i).Data
   Case "CDTAX":z3429.cdTax = Children(i).Data
   Case "SEUNITMATERIAL":z3429.seUnitMaterial = Children(i).Data
   Case "CDUNITMATERIAL":z3429.cdUnitMaterial = Children(i).Data
   Case "SEUNITPACKING":z3429.seUnitPacking = Children(i).Data
   Case "CDUNITPACKING":z3429.cdUnitPacking = Children(i).Data
   Case "UNITBASECHECK":z3429.UnitBaseCheck = Children(i).Data
   Case "TYPEDISCOUNT":z3429.TypeDiscount = Children(i).Data
   Case "PERDISCOUNT":z3429.PerDiscount = Children(i).Data
   Case "AMTDISCOUNT":z3429.AmtDiscount = Children(i).Data
   Case "QTYBASIC":z3429.QtyBasic = Children(i).Data
   Case "PRICEPURCHASING":z3429.PricePurchasing = Children(i).Data
   Case "PRICEMARKET":z3429.PriceMarket = Children(i).Data
   Case "PRICEEXCHANGE":z3429.PriceExchange = Children(i).Data
   Case "PRICEEXCHANGEAP":z3429.PriceExchangeAP = Children(i).Data
   Case "DATEEXCHANGE":z3429.DateExchange = Children(i).Data
   Case "PRICEPURCHASINGEX":z3429.PricePurchasingEX = Children(i).Data
   Case "PRICEMARKETEX":z3429.PriceMarketEX = Children(i).Data
   Case "PRICEPURCHASINGVND":z3429.PricePurchasingVND = Children(i).Data
   Case "PRICEMARKETVND":z3429.PriceMarketVND = Children(i).Data
   Case "AMOUNTPURCHASINGEX":z3429.AmountPurchasingEX = Children(i).Data
   Case "AMOUNTPURCHASINGVND":z3429.AmountPurchasingVND = Children(i).Data
   Case "AMOUNTTAXEX":z3429.AmountTaxEX = Children(i).Data
   Case "AMOUNTTAXVND":z3429.AmountTaxVND = Children(i).Data
   Case "PCTEXPENSE":z3429.PctExpense = Children(i).Data
   Case "AMOUNTEXPENSEEX":z3429.AmountExpenseEX = Children(i).Data
   Case "AMOUNTEXPENSVND":z3429.AmountExpensVND = Children(i).Data
   Case "SETAX1":z3429.seTax1 = Children(i).Data
   Case "CDTAX1":z3429.cdTax1 = Children(i).Data
   Case "PERTAX1":z3429.PerTax1 = Children(i).Data
   Case "AMOUNTTAX1":z3429.AmountTax1 = Children(i).Data
   Case "SETAX2":z3429.seTax2 = Children(i).Data
   Case "CDTAX2":z3429.cdTax2 = Children(i).Data
   Case "PERTAX2":z3429.PerTax2 = Children(i).Data
   Case "AMOUNTTAX2":z3429.AmountTax2 = Children(i).Data
   Case "SETAX3":z3429.seTax3 = Children(i).Data
   Case "CDTAX3":z3429.cdTax3 = Children(i).Data
   Case "PERTAX3":z3429.PerTax3 = Children(i).Data
   Case "AMOUNTTAX3":z3429.AmountTax3 = Children(i).Data
   Case "QTYPURCHASING":z3429.QtyPurchasing = Children(i).Data
   Case "PACKPURCHASING":z3429.PackPurchasing = Children(i).Data
   Case "QTYWAREHOUSE":z3429.QtyWarehouse = Children(i).Data
   Case "PACKWAREHOUSE":z3429.PackWarehouse = Children(i).Data
   Case "QTYINBOUND":z3429.QtyInbound = Children(i).Data
   Case "PACKINBOUND":z3429.PackInbound = Children(i).Data
   Case "QTYOUTBOUND":z3429.QtyOutbound = Children(i).Data
   Case "PACKOUTBOUND":z3429.PackOutbound = Children(i).Data
   Case "AMOUNTEX":z3429.AmountEX = Children(i).Data
   Case "AMOUNTVND":z3429.AmountVND = Children(i).Data
   Case "AMOUNTINBOUNDEX":z3429.AmountInBoundEX = Children(i).Data
                                Case "AMOUNTINBOUNDVND" : z3429.AmountInBoundVND = Children(i).Data
                                Case "AMOUNTFCT" : z3429.AmountFCT = Children(i).Data
                                Case "AMOUNTFCT2" : z3429.AmountFCT2 = Children(i).Data
   Case "DATEDELIVERY":z3429.DateDelivery = Children(i).Data
   Case "DATESTART":z3429.DateStart = Children(i).Data
   Case "DATEFINISH":z3429.DateFinish = Children(i).Data
   Case "CHECKPURCHASING":z3429.CheckPurchasing = Children(i).Data
   Case "DATEACCEPT":z3429.DateAccept = Children(i).Data
   Case "DATEPOSTED":z3429.DatePosted = Children(i).Data
   Case "ISPOSTED":z3429.IsPosted = Children(i).Data
   Case "DATECOMPLETE":z3429.DateComplete = Children(i).Data
   Case "DATEAPPROVAL":z3429.DateApproval = Children(i).Data
   Case "DATECANCEL":z3429.DateCancel = Children(i).Data
   Case "CHECKCOMPLETE":z3429.CheckComplete = Children(i).Data
   Case "PURCHASINGORDERNO":z3429.PurchasingOrderNo = Children(i).Data
   Case "PURCHASINGORDERSEQ":z3429.PurchasingOrderSeq = Children(i).Data
   Case "JOBCARDWORKING":z3429.JobCardWorking = Children(i).Data
   Case "JOBCARDWORKINGSEQ":z3429.JobCardWorkingSeq = Children(i).Data
   Case "JOBCARDTYPE":z3429.JobCardType = Children(i).Data
   Case "SALESORDERNO":z3429.SalesOrderNo = Children(i).Data
   Case "SALESORDERSEQ":z3429.SalesOrderSeq = Children(i).Data
   Case "SALESORDERSNO":z3429.SalesOrderSno = Children(i).Data
   Case "ORDERNO":z3429.OrderNo = Children(i).Data
   Case "ORDERNOSEQ":z3429.OrderNoSeq = Children(i).Data
   Case "REMARK":z3429.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K3429_MOVE",vbCritical)
End Try
End Function 
    
End Module 
