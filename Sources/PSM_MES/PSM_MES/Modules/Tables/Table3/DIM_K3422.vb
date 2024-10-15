'=========================================================================================================================================================
'   TABLE : (PFK3422)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K3422

Structure T3422_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	FactOrderNo	 AS String	'			char(9)		*
Public 	FactOrderSeq	 AS Double	'			decimal		*
Public 	DeclareNo	 AS String	'			nvarchar(50)
Public 	DateDeclare	 AS String	'			char(8)
Public 	InchargeDeclare	 AS String	'			char(8)
Public 	DeclareAmount	 AS Double	'			decimal
Public 	DeclareWgt	 AS Double	'			decimal
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
Public 	seGroupComponent	 AS String	'			char(3)
Public 	cdGroupComponent	 AS String	'			char(3)
Public 	CustomerSupplier	 AS String	'			char(6)
Public 	Dseq	 AS Double	'			decimal
Public 	Pseq	 AS Double	'			decimal
Public 	AutokeyK3011	 AS Double	'			decimal
Public 	CheckRelationType	 AS String	'			char(1)
Public 	ComponentName	 AS String	'			nvarchar(50)
Public 	MaterialCode	 AS String	'			char(6)
Public 	Specification	 AS String	'			nvarchar(200)
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
Public 	seTax1	 AS String	'			char(3)
Public 	cdTax1	 AS String	'			char(3)
Public 	PerTax1	 AS Double	'			decimal
Public 	AmountTax1	 AS Double	'			decimal
Public 	seTax2	 AS String	'			char(3)
Public 	cdTax2	 AS String	'			char(3)
Public 	PerTax2	 AS Double	'			decimal
Public 	AmountTax2	 AS Double	'			decimal
Public 	seTax3	 AS String	'			char(3)
Public 	cdTax3	 AS String	'			char(3)
Public 	PerTax3	 AS Double	'			decimal
Public 	AmountTax3	 AS Double	'			decimal
Public 	QtyRequestPO	 AS Double	'			decimal
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
Public 	AmountInBoundVND	 AS Double	'			decimal
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
Public 	CheckOrderType	 AS String	'			char(1)
Public 	OrderNo	 AS String	'			char(9)
Public 	OrderNoSeq	 AS String	'			char(3)
Public 	JobCard	 AS String	'			char(9)
Public 	DateSync	 AS String	'			char(8)
Public 	CheckSync	 AS String	'			char(1)
Public 	SlNo	 AS String	'			nvarchar(20)
Public 	Check_Spec_1	 AS String	'			char(1)
Public 	Check_Spec_2	 AS String	'			char(1)
Public 	Check_Spec_3	 AS String	'			char(1)
Public 	Check_Spec_4	 AS String	'			char(1)
Public 	Check_Spec_5	 AS String	'			char(1)
Public 	Check_Spec_6	 AS String	'			char(1)
Public 	Check_Spec_7	 AS String	'			char(1)
Public 	Check_Spec_8	 AS String	'			char(1)
Public 	Check_Spec_9	 AS String	'			char(1)
Public 	Remark	 AS String	'			nvarchar(500)
        '=========================================================================================================================================================
    End Structure

    Public D3422 As T3422_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK3422(FACTORDERNO As String, FACTORDERSEQ As Double) As Boolean
        READ_PFK3422 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK3422 "
            SQL = SQL & " WHERE K3422_FactOrderNo		 = '" & FactOrderNo & "' "
            SQL = SQL & "   AND K3422_FactOrderSeq		 =  " & FactOrderSeq & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D3422_CLEAR() : GoTo SKIP_READ_PFK3422

            Call K3422_MOVE(rd)
            READ_PFK3422 = True

SKIP_READ_PFK3422:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK3422", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK3422(FACTORDERNO As String, FACTORDERSEQ As Double, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK3422 "
            SQL = SQL & " WHERE K3422_FactOrderNo		 = '" & FactOrderNo & "' "
            SQL = SQL & "   AND K3422_FactOrderSeq		 =  " & FactOrderSeq & "  "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK3422", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK3422(z3422 As T3422_AREA) As Boolean
        WRITE_PFK3422 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z3422)

            SQL = " INSERT INTO PFK3422 "
            SQL = SQL & " ( "
            SQL = SQL & " K3422_FactOrderNo,"
            SQL = SQL & " K3422_FactOrderSeq,"
            SQL = SQL & " K3422_DeclareNo,"
            SQL = SQL & " K3422_DateDeclare,"
            SQL = SQL & " K3422_InchargeDeclare,"
            SQL = SQL & " K3422_DeclareAmount,"
            SQL = SQL & " K3422_DeclareWgt,"
            SQL = SQL & " K3422_seSite,"
            SQL = SQL & " K3422_cdSite,"
            SQL = SQL & " K3422_seDepartment,"
            SQL = SQL & " K3422_cdDepartment,"
            SQL = SQL & " K3422_seFactory,"
            SQL = SQL & " K3422_cdFactory,"
            SQL = SQL & " K3422_seLineProd,"
            SQL = SQL & " K3422_cdLineProd,"
            SQL = SQL & " K3422_seSubProcess,"
            SQL = SQL & " K3422_cdSubProcess,"
            SQL = SQL & " K3422_seGroupComponent,"
            SQL = SQL & " K3422_cdGroupComponent,"
            SQL = SQL & " K3422_CustomerSupplier,"
            SQL = SQL & " K3422_Dseq,"
            SQL = SQL & " K3422_Pseq,"
            SQL = SQL & " K3422_AutokeyK3011,"
            SQL = SQL & " K3422_CheckRelationType,"
            SQL = SQL & " K3422_ComponentName,"
            SQL = SQL & " K3422_MaterialCode,"
            SQL = SQL & " K3422_Specification,"
            SQL = SQL & " K3422_Width,"
            SQL = SQL & " K3422_Height,"
            SQL = SQL & " K3422_SizeNo,"
            SQL = SQL & " K3422_SizeName,"
            SQL = SQL & " K3422_ColorCode,"
            SQL = SQL & " K3422_ColorName,"
            SQL = SQL & " K3422_seOrigin,"
            SQL = SQL & " K3422_cdOrigin,"
            SQL = SQL & " K3422_MaterialCheck,"
            SQL = SQL & " K3422_seUnitPrice,"
            SQL = SQL & " K3422_cdUnitPrice,"
            SQL = SQL & " K3422_seTax,"
            SQL = SQL & " K3422_cdTax,"
            SQL = SQL & " K3422_seUnitMaterial,"
            SQL = SQL & " K3422_cdUnitMaterial,"
            SQL = SQL & " K3422_seUnitPacking,"
            SQL = SQL & " K3422_cdUnitPacking,"
            SQL = SQL & " K3422_UnitBaseCheck,"
            SQL = SQL & " K3422_QtyBasic,"
            SQL = SQL & " K3422_PricePurchasing,"
            SQL = SQL & " K3422_PriceMarket,"
            SQL = SQL & " K3422_PriceExchange,"
            SQL = SQL & " K3422_PriceExchangeAP,"
            SQL = SQL & " K3422_DateExchange,"
            SQL = SQL & " K3422_PricePurchasingEX,"
            SQL = SQL & " K3422_PriceMarketEX,"
            SQL = SQL & " K3422_PricePurchasingVND,"
            SQL = SQL & " K3422_PriceMarketVND,"
            SQL = SQL & " K3422_AmountPurchasingEX,"
            SQL = SQL & " K3422_AmountPurchasingVND,"
            SQL = SQL & " K3422_AmountTaxEX,"
            SQL = SQL & " K3422_AmountTaxVND,"
            SQL = SQL & " K3422_seTax1,"
            SQL = SQL & " K3422_cdTax1,"
            SQL = SQL & " K3422_PerTax1,"
            SQL = SQL & " K3422_AmountTax1,"
            SQL = SQL & " K3422_seTax2,"
            SQL = SQL & " K3422_cdTax2,"
            SQL = SQL & " K3422_PerTax2,"
            SQL = SQL & " K3422_AmountTax2,"
            SQL = SQL & " K3422_seTax3,"
            SQL = SQL & " K3422_cdTax3,"
            SQL = SQL & " K3422_PerTax3,"
            SQL = SQL & " K3422_AmountTax3,"
            SQL = SQL & " K3422_QtyRequestPO,"
            SQL = SQL & " K3422_QtyPurchasing,"
            SQL = SQL & " K3422_PackPurchasing,"
            SQL = SQL & " K3422_QtyWarehouse,"
            SQL = SQL & " K3422_PackWarehouse,"
            SQL = SQL & " K3422_QtyInbound,"
            SQL = SQL & " K3422_PackInbound,"
            SQL = SQL & " K3422_QtyOutbound,"
            SQL = SQL & " K3422_PackOutbound,"
            SQL = SQL & " K3422_AmountEX,"
            SQL = SQL & " K3422_AmountVND,"
            SQL = SQL & " K3422_AmountInBoundEX,"
            SQL = SQL & " K3422_AmountInBoundVND,"
            SQL = SQL & " K3422_DateDelivery,"
            SQL = SQL & " K3422_DateStart,"
            SQL = SQL & " K3422_DateFinish,"
            SQL = SQL & " K3422_CheckPurchasing,"
            SQL = SQL & " K3422_DateAccept,"
            SQL = SQL & " K3422_DatePosted,"
            SQL = SQL & " K3422_IsPosted,"
            SQL = SQL & " K3422_DateComplete,"
            SQL = SQL & " K3422_DateApproval,"
            SQL = SQL & " K3422_DateCancel,"
            SQL = SQL & " K3422_CheckComplete,"
            SQL = SQL & " K3422_PurchasingOrderNo,"
            SQL = SQL & " K3422_PurchasingOrderSeq,"
            SQL = SQL & " K3422_JobCardWorking,"
            SQL = SQL & " K3422_JobCardWorkingSeq,"
            SQL = SQL & " K3422_JobCardType,"
            SQL = SQL & " K3422_SalesOrderNo,"
            SQL = SQL & " K3422_SalesOrderSeq,"
            SQL = SQL & " K3422_SalesOrderSno,"
            SQL = SQL & " K3422_CheckOrderType,"
            SQL = SQL & " K3422_OrderNo,"
            SQL = SQL & " K3422_OrderNoSeq,"
            SQL = SQL & " K3422_JobCard,"
            SQL = SQL & " K3422_DateSync,"
            SQL = SQL & " K3422_CheckSync,"
            SQL = SQL & " K3422_SlNo,"
            SQL = SQL & " K3422_Check_Spec_1,"
            SQL = SQL & " K3422_Check_Spec_2,"
            SQL = SQL & " K3422_Check_Spec_3,"
            SQL = SQL & " K3422_Check_Spec_4,"
            SQL = SQL & " K3422_Check_Spec_5,"
            SQL = SQL & " K3422_Check_Spec_6,"
            SQL = SQL & " K3422_Check_Spec_7,"
            SQL = SQL & " K3422_Check_Spec_8,"
            SQL = SQL & " K3422_Check_Spec_9,"
            SQL = SQL & " K3422_Remark "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z3422.FactOrderNo) & "', "
            SQL = SQL & "   " & FormatSQL(z3422.FactOrderSeq) & ", "
            SQL = SQL & "  N'" & FormatSQL(z3422.DeclareNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.DateDeclare) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.InchargeDeclare) & "', "
            SQL = SQL & "   " & FormatSQL(z3422.DeclareAmount) & ", "
            SQL = SQL & "   " & FormatSQL(z3422.DeclareWgt) & ", "
            SQL = SQL & "  N'" & FormatSQL(z3422.seSite) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.cdSite) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.seDepartment) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.cdDepartment) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.seFactory) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.cdFactory) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.seLineProd) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.cdLineProd) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.seSubProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.cdSubProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.seGroupComponent) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.cdGroupComponent) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.CustomerSupplier) & "', "
            SQL = SQL & "   " & FormatSQL(z3422.Dseq) & ", "
            SQL = SQL & "   " & FormatSQL(z3422.Pseq) & ", "
            SQL = SQL & "   " & FormatSQL(z3422.AutokeyK3011) & ", "
            SQL = SQL & "  N'" & FormatSQL(z3422.CheckRelationType) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.ComponentName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.MaterialCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.Specification) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.Width) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.Height) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.SizeNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.SizeName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.ColorCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.ColorName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.seOrigin) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.cdOrigin) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.MaterialCheck) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.seUnitPrice) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.cdUnitPrice) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.seTax) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.cdTax) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.seUnitMaterial) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.cdUnitMaterial) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.seUnitPacking) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.cdUnitPacking) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.UnitBaseCheck) & "', "
            SQL = SQL & "   " & FormatSQL(z3422.QtyBasic) & ", "
            SQL = SQL & "   " & FormatSQL(z3422.PricePurchasing) & ", "
            SQL = SQL & "   " & FormatSQL(z3422.PriceMarket) & ", "
            SQL = SQL & "   " & FormatSQL(z3422.PriceExchange) & ", "
            SQL = SQL & "   " & FormatSQL(z3422.PriceExchangeAP) & ", "
            SQL = SQL & "  N'" & FormatSQL(z3422.DateExchange) & "', "
            SQL = SQL & "   " & FormatSQL(z3422.PricePurchasingEX) & ", "
            SQL = SQL & "   " & FormatSQL(z3422.PriceMarketEX) & ", "
            SQL = SQL & "   " & FormatSQL(z3422.PricePurchasingVND) & ", "
            SQL = SQL & "   " & FormatSQL(z3422.PriceMarketVND) & ", "
            SQL = SQL & "   " & FormatSQL(z3422.AmountPurchasingEX) & ", "
            SQL = SQL & "   " & FormatSQL(z3422.AmountPurchasingVND) & ", "
            SQL = SQL & "   " & FormatSQL(z3422.AmountTaxEX) & ", "
            SQL = SQL & "   " & FormatSQL(z3422.AmountTaxVND) & ", "
            SQL = SQL & "  N'" & FormatSQL(z3422.seTax1) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.cdTax1) & "', "
            SQL = SQL & "   " & FormatSQL(z3422.PerTax1) & ", "
            SQL = SQL & "   " & FormatSQL(z3422.AmountTax1) & ", "
            SQL = SQL & "  N'" & FormatSQL(z3422.seTax2) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.cdTax2) & "', "
            SQL = SQL & "   " & FormatSQL(z3422.PerTax2) & ", "
            SQL = SQL & "   " & FormatSQL(z3422.AmountTax2) & ", "
            SQL = SQL & "  N'" & FormatSQL(z3422.seTax3) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.cdTax3) & "', "
            SQL = SQL & "   " & FormatSQL(z3422.PerTax3) & ", "
            SQL = SQL & "   " & FormatSQL(z3422.AmountTax3) & ", "
            SQL = SQL & "   " & FormatSQL(z3422.QtyRequestPO) & ", "
            SQL = SQL & "   " & FormatSQL(z3422.QtyPurchasing) & ", "
            SQL = SQL & "   " & FormatSQL(z3422.PackPurchasing) & ", "
            SQL = SQL & "   " & FormatSQL(z3422.QtyWarehouse) & ", "
            SQL = SQL & "   " & FormatSQL(z3422.PackWarehouse) & ", "
            SQL = SQL & "   " & FormatSQL(z3422.QtyInbound) & ", "
            SQL = SQL & "   " & FormatSQL(z3422.PackInbound) & ", "
            SQL = SQL & "   " & FormatSQL(z3422.QtyOutbound) & ", "
            SQL = SQL & "   " & FormatSQL(z3422.PackOutbound) & ", "
            SQL = SQL & "   " & FormatSQL(z3422.AmountEX) & ", "
            SQL = SQL & "   " & FormatSQL(z3422.AmountVND) & ", "
            SQL = SQL & "   " & FormatSQL(z3422.AmountInBoundEX) & ", "
            SQL = SQL & "   " & FormatSQL(z3422.AmountInBoundVND) & ", "
            SQL = SQL & "  N'" & FormatSQL(z3422.DateDelivery) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.DateStart) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.DateFinish) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.CheckPurchasing) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.DateAccept) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.DatePosted) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.IsPosted) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.DateComplete) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.DateApproval) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.DateCancel) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.CheckComplete) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.PurchasingOrderNo) & "', "
            SQL = SQL & "   " & FormatSQL(z3422.PurchasingOrderSeq) & ", "
            SQL = SQL & "  N'" & FormatSQL(z3422.JobCardWorking) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.JobCardWorkingSeq) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.JobCardType) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.SalesOrderNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.SalesOrderSeq) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.SalesOrderSno) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.CheckOrderType) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.OrderNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.OrderNoSeq) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.JobCard) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.DateSync) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.CheckSync) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.SlNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.Check_Spec_1) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.Check_Spec_2) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.Check_Spec_3) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.Check_Spec_4) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.Check_Spec_5) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.Check_Spec_6) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.Check_Spec_7) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.Check_Spec_8) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.Check_Spec_9) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3422.Remark) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK3422 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK3422", vbCritical)
        Finally
            Call GetFullInformation("PFK3422", "I", SQL)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK3422(z3422 As T3422_AREA) As Boolean
        REWRITE_PFK3422 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z3422)

            SQL = " UPDATE PFK3422 SET "
            SQL = SQL & "    K3422_DeclareNo      = N'" & FormatSQL(z3422.DeclareNo) & "', "
            SQL = SQL & "    K3422_DateDeclare      = N'" & FormatSQL(z3422.DateDeclare) & "', "
            SQL = SQL & "    K3422_InchargeDeclare      = N'" & FormatSQL(z3422.InchargeDeclare) & "', "
            SQL = SQL & "    K3422_DeclareAmount      =  " & FormatSQL(z3422.DeclareAmount) & ", "
            SQL = SQL & "    K3422_DeclareWgt      =  " & FormatSQL(z3422.DeclareWgt) & ", "
            SQL = SQL & "    K3422_seSite      = N'" & FormatSQL(z3422.seSite) & "', "
            SQL = SQL & "    K3422_cdSite      = N'" & FormatSQL(z3422.cdSite) & "', "
            SQL = SQL & "    K3422_seDepartment      = N'" & FormatSQL(z3422.seDepartment) & "', "
            SQL = SQL & "    K3422_cdDepartment      = N'" & FormatSQL(z3422.cdDepartment) & "', "
            SQL = SQL & "    K3422_seFactory      = N'" & FormatSQL(z3422.seFactory) & "', "
            SQL = SQL & "    K3422_cdFactory      = N'" & FormatSQL(z3422.cdFactory) & "', "
            SQL = SQL & "    K3422_seLineProd      = N'" & FormatSQL(z3422.seLineProd) & "', "
            SQL = SQL & "    K3422_cdLineProd      = N'" & FormatSQL(z3422.cdLineProd) & "', "
            SQL = SQL & "    K3422_seSubProcess      = N'" & FormatSQL(z3422.seSubProcess) & "', "
            SQL = SQL & "    K3422_cdSubProcess      = N'" & FormatSQL(z3422.cdSubProcess) & "', "
            SQL = SQL & "    K3422_seGroupComponent      = N'" & FormatSQL(z3422.seGroupComponent) & "', "
            SQL = SQL & "    K3422_cdGroupComponent      = N'" & FormatSQL(z3422.cdGroupComponent) & "', "
            SQL = SQL & "    K3422_CustomerSupplier      = N'" & FormatSQL(z3422.CustomerSupplier) & "', "
            SQL = SQL & "    K3422_Dseq      =  " & FormatSQL(z3422.Dseq) & ", "
            SQL = SQL & "    K3422_Pseq      =  " & FormatSQL(z3422.Pseq) & ", "
            SQL = SQL & "    K3422_AutokeyK3011      =  " & FormatSQL(z3422.AutokeyK3011) & ", "
            SQL = SQL & "    K3422_CheckRelationType      = N'" & FormatSQL(z3422.CheckRelationType) & "', "
            SQL = SQL & "    K3422_ComponentName      = N'" & FormatSQL(z3422.ComponentName) & "', "
            SQL = SQL & "    K3422_MaterialCode      = N'" & FormatSQL(z3422.MaterialCode) & "', "
            SQL = SQL & "    K3422_Specification      = N'" & FormatSQL(z3422.Specification) & "', "
            SQL = SQL & "    K3422_Width      = N'" & FormatSQL(z3422.Width) & "', "
            SQL = SQL & "    K3422_Height      = N'" & FormatSQL(z3422.Height) & "', "
            SQL = SQL & "    K3422_SizeNo      = N'" & FormatSQL(z3422.SizeNo) & "', "
            SQL = SQL & "    K3422_SizeName      = N'" & FormatSQL(z3422.SizeName) & "', "
            SQL = SQL & "    K3422_ColorCode      = N'" & FormatSQL(z3422.ColorCode) & "', "
            SQL = SQL & "    K3422_ColorName      = N'" & FormatSQL(z3422.ColorName) & "', "
            SQL = SQL & "    K3422_seOrigin      = N'" & FormatSQL(z3422.seOrigin) & "', "
            SQL = SQL & "    K3422_cdOrigin      = N'" & FormatSQL(z3422.cdOrigin) & "', "
            SQL = SQL & "    K3422_MaterialCheck      = N'" & FormatSQL(z3422.MaterialCheck) & "', "
            SQL = SQL & "    K3422_seUnitPrice      = N'" & FormatSQL(z3422.seUnitPrice) & "', "
            SQL = SQL & "    K3422_cdUnitPrice      = N'" & FormatSQL(z3422.cdUnitPrice) & "', "
            SQL = SQL & "    K3422_seTax      = N'" & FormatSQL(z3422.seTax) & "', "
            SQL = SQL & "    K3422_cdTax      = N'" & FormatSQL(z3422.cdTax) & "', "
            SQL = SQL & "    K3422_seUnitMaterial      = N'" & FormatSQL(z3422.seUnitMaterial) & "', "
            SQL = SQL & "    K3422_cdUnitMaterial      = N'" & FormatSQL(z3422.cdUnitMaterial) & "', "
            SQL = SQL & "    K3422_seUnitPacking      = N'" & FormatSQL(z3422.seUnitPacking) & "', "
            SQL = SQL & "    K3422_cdUnitPacking      = N'" & FormatSQL(z3422.cdUnitPacking) & "', "
            SQL = SQL & "    K3422_UnitBaseCheck      = N'" & FormatSQL(z3422.UnitBaseCheck) & "', "
            SQL = SQL & "    K3422_QtyBasic      =  " & FormatSQL(z3422.QtyBasic) & ", "
            SQL = SQL & "    K3422_PricePurchasing      =  " & FormatSQL(z3422.PricePurchasing) & ", "
            SQL = SQL & "    K3422_PriceMarket      =  " & FormatSQL(z3422.PriceMarket) & ", "
            SQL = SQL & "    K3422_PriceExchange      =  " & FormatSQL(z3422.PriceExchange) & ", "
            SQL = SQL & "    K3422_PriceExchangeAP      =  " & FormatSQL(z3422.PriceExchangeAP) & ", "
            SQL = SQL & "    K3422_DateExchange      = N'" & FormatSQL(z3422.DateExchange) & "', "
            SQL = SQL & "    K3422_PricePurchasingEX      =  " & FormatSQL(z3422.PricePurchasingEX) & ", "
            SQL = SQL & "    K3422_PriceMarketEX      =  " & FormatSQL(z3422.PriceMarketEX) & ", "
            SQL = SQL & "    K3422_PricePurchasingVND      =  " & FormatSQL(z3422.PricePurchasingVND) & ", "
            SQL = SQL & "    K3422_PriceMarketVND      =  " & FormatSQL(z3422.PriceMarketVND) & ", "
            SQL = SQL & "    K3422_AmountPurchasingEX      =  " & FormatSQL(z3422.AmountPurchasingEX) & ", "
            SQL = SQL & "    K3422_AmountPurchasingVND      =  " & FormatSQL(z3422.AmountPurchasingVND) & ", "
            SQL = SQL & "    K3422_AmountTaxEX      =  " & FormatSQL(z3422.AmountTaxEX) & ", "
            SQL = SQL & "    K3422_AmountTaxVND      =  " & FormatSQL(z3422.AmountTaxVND) & ", "
            SQL = SQL & "    K3422_seTax1      = N'" & FormatSQL(z3422.seTax1) & "', "
            SQL = SQL & "    K3422_cdTax1      = N'" & FormatSQL(z3422.cdTax1) & "', "
            SQL = SQL & "    K3422_PerTax1      =  " & FormatSQL(z3422.PerTax1) & ", "
            SQL = SQL & "    K3422_AmountTax1      =  " & FormatSQL(z3422.AmountTax1) & ", "
            SQL = SQL & "    K3422_seTax2      = N'" & FormatSQL(z3422.seTax2) & "', "
            SQL = SQL & "    K3422_cdTax2      = N'" & FormatSQL(z3422.cdTax2) & "', "
            SQL = SQL & "    K3422_PerTax2      =  " & FormatSQL(z3422.PerTax2) & ", "
            SQL = SQL & "    K3422_AmountTax2      =  " & FormatSQL(z3422.AmountTax2) & ", "
            SQL = SQL & "    K3422_seTax3      = N'" & FormatSQL(z3422.seTax3) & "', "
            SQL = SQL & "    K3422_cdTax3      = N'" & FormatSQL(z3422.cdTax3) & "', "
            SQL = SQL & "    K3422_PerTax3      =  " & FormatSQL(z3422.PerTax3) & ", "
            SQL = SQL & "    K3422_AmountTax3      =  " & FormatSQL(z3422.AmountTax3) & ", "
            SQL = SQL & "    K3422_QtyRequestPO      =  " & FormatSQL(z3422.QtyRequestPO) & ", "
            SQL = SQL & "    K3422_QtyPurchasing      =  " & FormatSQL(z3422.QtyPurchasing) & ", "
            SQL = SQL & "    K3422_PackPurchasing      =  " & FormatSQL(z3422.PackPurchasing) & ", "
            SQL = SQL & "    K3422_QtyWarehouse      =  " & FormatSQL(z3422.QtyWarehouse) & ", "
            SQL = SQL & "    K3422_PackWarehouse      =  " & FormatSQL(z3422.PackWarehouse) & ", "
            SQL = SQL & "    K3422_QtyInbound      =  " & FormatSQL(z3422.QtyInbound) & ", "
            SQL = SQL & "    K3422_PackInbound      =  " & FormatSQL(z3422.PackInbound) & ", "
            SQL = SQL & "    K3422_QtyOutbound      =  " & FormatSQL(z3422.QtyOutbound) & ", "
            SQL = SQL & "    K3422_PackOutbound      =  " & FormatSQL(z3422.PackOutbound) & ", "
            SQL = SQL & "    K3422_AmountEX      =  " & FormatSQL(z3422.AmountEX) & ", "
            SQL = SQL & "    K3422_AmountVND      =  " & FormatSQL(z3422.AmountVND) & ", "
            SQL = SQL & "    K3422_AmountInBoundEX      =  " & FormatSQL(z3422.AmountInBoundEX) & ", "
            SQL = SQL & "    K3422_AmountInBoundVND      =  " & FormatSQL(z3422.AmountInBoundVND) & ", "
            SQL = SQL & "    K3422_DateDelivery      = N'" & FormatSQL(z3422.DateDelivery) & "', "
            SQL = SQL & "    K3422_DateStart      = N'" & FormatSQL(z3422.DateStart) & "', "
            SQL = SQL & "    K3422_DateFinish      = N'" & FormatSQL(z3422.DateFinish) & "', "
            SQL = SQL & "    K3422_CheckPurchasing      = N'" & FormatSQL(z3422.CheckPurchasing) & "', "
            SQL = SQL & "    K3422_DateAccept      = N'" & FormatSQL(z3422.DateAccept) & "', "
            SQL = SQL & "    K3422_DatePosted      = N'" & FormatSQL(z3422.DatePosted) & "', "
            SQL = SQL & "    K3422_IsPosted      = N'" & FormatSQL(z3422.IsPosted) & "', "
            SQL = SQL & "    K3422_DateComplete      = N'" & FormatSQL(z3422.DateComplete) & "', "
            SQL = SQL & "    K3422_DateApproval      = N'" & FormatSQL(z3422.DateApproval) & "', "
            SQL = SQL & "    K3422_DateCancel      = N'" & FormatSQL(z3422.DateCancel) & "', "
            SQL = SQL & "    K3422_CheckComplete      = N'" & FormatSQL(z3422.CheckComplete) & "', "
            SQL = SQL & "    K3422_PurchasingOrderNo      = N'" & FormatSQL(z3422.PurchasingOrderNo) & "', "
            SQL = SQL & "    K3422_PurchasingOrderSeq      =  " & FormatSQL(z3422.PurchasingOrderSeq) & ", "
            SQL = SQL & "    K3422_JobCardWorking      = N'" & FormatSQL(z3422.JobCardWorking) & "', "
            SQL = SQL & "    K3422_JobCardWorkingSeq      = N'" & FormatSQL(z3422.JobCardWorkingSeq) & "', "
            SQL = SQL & "    K3422_JobCardType      = N'" & FormatSQL(z3422.JobCardType) & "', "
            SQL = SQL & "    K3422_SalesOrderNo      = N'" & FormatSQL(z3422.SalesOrderNo) & "', "
            SQL = SQL & "    K3422_SalesOrderSeq      = N'" & FormatSQL(z3422.SalesOrderSeq) & "', "
            SQL = SQL & "    K3422_SalesOrderSno      = N'" & FormatSQL(z3422.SalesOrderSno) & "', "
            SQL = SQL & "    K3422_CheckOrderType      = N'" & FormatSQL(z3422.CheckOrderType) & "', "
            SQL = SQL & "    K3422_OrderNo      = N'" & FormatSQL(z3422.OrderNo) & "', "
            SQL = SQL & "    K3422_OrderNoSeq      = N'" & FormatSQL(z3422.OrderNoSeq) & "', "
            SQL = SQL & "    K3422_JobCard      = N'" & FormatSQL(z3422.JobCard) & "', "
            SQL = SQL & "    K3422_DateSync      = N'" & FormatSQL(z3422.DateSync) & "', "
            SQL = SQL & "    K3422_CheckSync      = N'" & FormatSQL(z3422.CheckSync) & "', "
            SQL = SQL & "    K3422_SlNo      = N'" & FormatSQL(z3422.SlNo) & "', "
            SQL = SQL & "    K3422_Check_Spec_1      = N'" & FormatSQL(z3422.Check_Spec_1) & "', "
            SQL = SQL & "    K3422_Check_Spec_2      = N'" & FormatSQL(z3422.Check_Spec_2) & "', "
            SQL = SQL & "    K3422_Check_Spec_3      = N'" & FormatSQL(z3422.Check_Spec_3) & "', "
            SQL = SQL & "    K3422_Check_Spec_4      = N'" & FormatSQL(z3422.Check_Spec_4) & "', "
            SQL = SQL & "    K3422_Check_Spec_5      = N'" & FormatSQL(z3422.Check_Spec_5) & "', "
            SQL = SQL & "    K3422_Check_Spec_6      = N'" & FormatSQL(z3422.Check_Spec_6) & "', "
            SQL = SQL & "    K3422_Check_Spec_7      = N'" & FormatSQL(z3422.Check_Spec_7) & "', "
            SQL = SQL & "    K3422_Check_Spec_8      = N'" & FormatSQL(z3422.Check_Spec_8) & "', "
            SQL = SQL & "    K3422_Check_Spec_9      = N'" & FormatSQL(z3422.Check_Spec_9) & "', "
            SQL = SQL & "    K3422_Remark      = N'" & FormatSQL(z3422.Remark) & "'  "
            SQL = SQL & " WHERE K3422_FactOrderNo		 = '" & z3422.FactOrderNo & "' "
            SQL = SQL & "   AND K3422_FactOrderSeq		 =  " & z3422.FactOrderSeq & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK3422 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK3422", vbCritical)
        Finally
            Call GetFullInformation("PFK3422", "U", SQL)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK3422(z3422 As T3422_AREA) As Boolean
        DELETE_PFK3422 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z3422)

            SQL = " DELETE FROM PFK3422  "
            SQL = SQL & " WHERE K3422_FactOrderNo		 = '" & z3422.FactOrderNo & "' "
            SQL = SQL & "   AND K3422_FactOrderSeq		 =  " & z3422.FactOrderSeq & "  "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK3422 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK3422", vbCritical)
        Finally
            Call GetFullInformation("PFK3422", "U", SQL)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D3422_CLEAR()
        Try

            D3422.FactOrderNo = ""
            D3422.FactOrderSeq = 0
            D3422.DeclareNo = ""
            D3422.DateDeclare = ""
            D3422.InchargeDeclare = ""
            D3422.DeclareAmount = 0
            D3422.DeclareWgt = 0
            D3422.seSite = ""
            D3422.cdSite = ""
            D3422.seDepartment = ""
            D3422.cdDepartment = ""
            D3422.seFactory = ""
            D3422.cdFactory = ""
            D3422.seLineProd = ""
            D3422.cdLineProd = ""
            D3422.seSubProcess = ""
            D3422.cdSubProcess = ""
            D3422.seGroupComponent = ""
            D3422.cdGroupComponent = ""
            D3422.CustomerSupplier = ""
            D3422.Dseq = 0
            D3422.Pseq = 0
            D3422.AutokeyK3011 = 0
            D3422.CheckRelationType = ""
            D3422.ComponentName = ""
            D3422.MaterialCode = ""
            D3422.Specification = ""
            D3422.Width = ""
            D3422.Height = ""
            D3422.SizeNo = ""
            D3422.SizeName = ""
            D3422.ColorCode = ""
            D3422.ColorName = ""
            D3422.seOrigin = ""
            D3422.cdOrigin = ""
            D3422.MaterialCheck = ""
            D3422.seUnitPrice = ""
            D3422.cdUnitPrice = ""
            D3422.seTax = ""
            D3422.cdTax = ""
            D3422.seUnitMaterial = ""
            D3422.cdUnitMaterial = ""
            D3422.seUnitPacking = ""
            D3422.cdUnitPacking = ""
            D3422.UnitBaseCheck = ""
            D3422.QtyBasic = 0
            D3422.PricePurchasing = 0
            D3422.PriceMarket = 0
            D3422.PriceExchange = 0
            D3422.PriceExchangeAP = 0
            D3422.DateExchange = ""
            D3422.PricePurchasingEX = 0
            D3422.PriceMarketEX = 0
            D3422.PricePurchasingVND = 0
            D3422.PriceMarketVND = 0
            D3422.AmountPurchasingEX = 0
            D3422.AmountPurchasingVND = 0
            D3422.AmountTaxEX = 0
            D3422.AmountTaxVND = 0
            D3422.seTax1 = ""
            D3422.cdTax1 = ""
            D3422.PerTax1 = 0
            D3422.AmountTax1 = 0
            D3422.seTax2 = ""
            D3422.cdTax2 = ""
            D3422.PerTax2 = 0
            D3422.AmountTax2 = 0
            D3422.seTax3 = ""
            D3422.cdTax3 = ""
            D3422.PerTax3 = 0
            D3422.AmountTax3 = 0
            D3422.QtyRequestPO = 0
            D3422.QtyPurchasing = 0
            D3422.PackPurchasing = 0
            D3422.QtyWarehouse = 0
            D3422.PackWarehouse = 0
            D3422.QtyInbound = 0
            D3422.PackInbound = 0
            D3422.QtyOutbound = 0
            D3422.PackOutbound = 0
            D3422.AmountEX = 0
            D3422.AmountVND = 0
            D3422.AmountInBoundEX = 0
            D3422.AmountInBoundVND = 0
            D3422.DateDelivery = ""
            D3422.DateStart = ""
            D3422.DateFinish = ""
            D3422.CheckPurchasing = ""
            D3422.DateAccept = ""
            D3422.DatePosted = ""
            D3422.IsPosted = ""
            D3422.DateComplete = ""
            D3422.DateApproval = ""
            D3422.DateCancel = ""
            D3422.CheckComplete = ""
            D3422.PurchasingOrderNo = ""
            D3422.PurchasingOrderSeq = 0
            D3422.JobCardWorking = ""
            D3422.JobCardWorkingSeq = ""
            D3422.JobCardType = ""
            D3422.SalesOrderNo = ""
            D3422.SalesOrderSeq = ""
            D3422.SalesOrderSno = ""
            D3422.CheckOrderType = ""
            D3422.OrderNo = ""
            D3422.OrderNoSeq = ""
            D3422.JobCard = ""
            D3422.DateSync = ""
            D3422.CheckSync = ""
            D3422.SlNo = ""
            D3422.Check_Spec_1 = ""
            D3422.Check_Spec_2 = ""
            D3422.Check_Spec_3 = ""
            D3422.Check_Spec_4 = ""
            D3422.Check_Spec_5 = ""
            D3422.Check_Spec_6 = ""
            D3422.Check_Spec_7 = ""
            D3422.Check_Spec_8 = ""
            D3422.Check_Spec_9 = ""
            D3422.Remark = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D3422_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x3422 As T3422_AREA)
        Try

            x3422.FactOrderNo = trim$(x3422.FactOrderNo)
            x3422.FactOrderSeq = trim$(x3422.FactOrderSeq)
            x3422.DeclareNo = trim$(x3422.DeclareNo)
            x3422.DateDeclare = trim$(x3422.DateDeclare)
            x3422.InchargeDeclare = trim$(x3422.InchargeDeclare)
            x3422.DeclareAmount = trim$(x3422.DeclareAmount)
            x3422.DeclareWgt = trim$(x3422.DeclareWgt)
            x3422.seSite = trim$(x3422.seSite)
            x3422.cdSite = trim$(x3422.cdSite)
            x3422.seDepartment = trim$(x3422.seDepartment)
            x3422.cdDepartment = trim$(x3422.cdDepartment)
            x3422.seFactory = trim$(x3422.seFactory)
            x3422.cdFactory = trim$(x3422.cdFactory)
            x3422.seLineProd = trim$(x3422.seLineProd)
            x3422.cdLineProd = trim$(x3422.cdLineProd)
            x3422.seSubProcess = trim$(x3422.seSubProcess)
            x3422.cdSubProcess = trim$(x3422.cdSubProcess)
            x3422.seGroupComponent = trim$(x3422.seGroupComponent)
            x3422.cdGroupComponent = trim$(x3422.cdGroupComponent)
            x3422.CustomerSupplier = trim$(x3422.CustomerSupplier)
            x3422.Dseq = trim$(x3422.Dseq)
            x3422.Pseq = trim$(x3422.Pseq)
            x3422.AutokeyK3011 = trim$(x3422.AutokeyK3011)
            x3422.CheckRelationType = trim$(x3422.CheckRelationType)
            x3422.ComponentName = trim$(x3422.ComponentName)
            x3422.MaterialCode = trim$(x3422.MaterialCode)
            x3422.Specification = trim$(x3422.Specification)
            x3422.Width = trim$(x3422.Width)
            x3422.Height = trim$(x3422.Height)
            x3422.SizeNo = trim$(x3422.SizeNo)
            x3422.SizeName = trim$(x3422.SizeName)
            x3422.ColorCode = trim$(x3422.ColorCode)
            x3422.ColorName = trim$(x3422.ColorName)
            x3422.seOrigin = trim$(x3422.seOrigin)
            x3422.cdOrigin = trim$(x3422.cdOrigin)
            x3422.MaterialCheck = trim$(x3422.MaterialCheck)
            x3422.seUnitPrice = trim$(x3422.seUnitPrice)
            x3422.cdUnitPrice = trim$(x3422.cdUnitPrice)
            x3422.seTax = trim$(x3422.seTax)
            x3422.cdTax = trim$(x3422.cdTax)
            x3422.seUnitMaterial = trim$(x3422.seUnitMaterial)
            x3422.cdUnitMaterial = trim$(x3422.cdUnitMaterial)
            x3422.seUnitPacking = trim$(x3422.seUnitPacking)
            x3422.cdUnitPacking = trim$(x3422.cdUnitPacking)
            x3422.UnitBaseCheck = trim$(x3422.UnitBaseCheck)
            x3422.QtyBasic = trim$(x3422.QtyBasic)
            x3422.PricePurchasing = trim$(x3422.PricePurchasing)
            x3422.PriceMarket = trim$(x3422.PriceMarket)
            x3422.PriceExchange = trim$(x3422.PriceExchange)
            x3422.PriceExchangeAP = trim$(x3422.PriceExchangeAP)
            x3422.DateExchange = trim$(x3422.DateExchange)
            x3422.PricePurchasingEX = trim$(x3422.PricePurchasingEX)
            x3422.PriceMarketEX = trim$(x3422.PriceMarketEX)
            x3422.PricePurchasingVND = trim$(x3422.PricePurchasingVND)
            x3422.PriceMarketVND = trim$(x3422.PriceMarketVND)
            x3422.AmountPurchasingEX = trim$(x3422.AmountPurchasingEX)
            x3422.AmountPurchasingVND = trim$(x3422.AmountPurchasingVND)
            x3422.AmountTaxEX = trim$(x3422.AmountTaxEX)
            x3422.AmountTaxVND = trim$(x3422.AmountTaxVND)
            x3422.seTax1 = trim$(x3422.seTax1)
            x3422.cdTax1 = trim$(x3422.cdTax1)
            x3422.PerTax1 = trim$(x3422.PerTax1)
            x3422.AmountTax1 = trim$(x3422.AmountTax1)
            x3422.seTax2 = trim$(x3422.seTax2)
            x3422.cdTax2 = trim$(x3422.cdTax2)
            x3422.PerTax2 = trim$(x3422.PerTax2)
            x3422.AmountTax2 = trim$(x3422.AmountTax2)
            x3422.seTax3 = trim$(x3422.seTax3)
            x3422.cdTax3 = trim$(x3422.cdTax3)
            x3422.PerTax3 = trim$(x3422.PerTax3)
            x3422.AmountTax3 = trim$(x3422.AmountTax3)
            x3422.QtyRequestPO = trim$(x3422.QtyRequestPO)
            x3422.QtyPurchasing = trim$(x3422.QtyPurchasing)
            x3422.PackPurchasing = trim$(x3422.PackPurchasing)
            x3422.QtyWarehouse = trim$(x3422.QtyWarehouse)
            x3422.PackWarehouse = trim$(x3422.PackWarehouse)
            x3422.QtyInbound = trim$(x3422.QtyInbound)
            x3422.PackInbound = trim$(x3422.PackInbound)
            x3422.QtyOutbound = trim$(x3422.QtyOutbound)
            x3422.PackOutbound = trim$(x3422.PackOutbound)
            x3422.AmountEX = trim$(x3422.AmountEX)
            x3422.AmountVND = trim$(x3422.AmountVND)
            x3422.AmountInBoundEX = trim$(x3422.AmountInBoundEX)
            x3422.AmountInBoundVND = trim$(x3422.AmountInBoundVND)
            x3422.DateDelivery = trim$(x3422.DateDelivery)
            x3422.DateStart = trim$(x3422.DateStart)
            x3422.DateFinish = trim$(x3422.DateFinish)
            x3422.CheckPurchasing = trim$(x3422.CheckPurchasing)
            x3422.DateAccept = trim$(x3422.DateAccept)
            x3422.DatePosted = trim$(x3422.DatePosted)
            x3422.IsPosted = trim$(x3422.IsPosted)
            x3422.DateComplete = trim$(x3422.DateComplete)
            x3422.DateApproval = trim$(x3422.DateApproval)
            x3422.DateCancel = trim$(x3422.DateCancel)
            x3422.CheckComplete = trim$(x3422.CheckComplete)
            x3422.PurchasingOrderNo = trim$(x3422.PurchasingOrderNo)
            x3422.PurchasingOrderSeq = trim$(x3422.PurchasingOrderSeq)
            x3422.JobCardWorking = trim$(x3422.JobCardWorking)
            x3422.JobCardWorkingSeq = trim$(x3422.JobCardWorkingSeq)
            x3422.JobCardType = trim$(x3422.JobCardType)
            x3422.SalesOrderNo = trim$(x3422.SalesOrderNo)
            x3422.SalesOrderSeq = trim$(x3422.SalesOrderSeq)
            x3422.SalesOrderSno = trim$(x3422.SalesOrderSno)
            x3422.CheckOrderType = trim$(x3422.CheckOrderType)
            x3422.OrderNo = trim$(x3422.OrderNo)
            x3422.OrderNoSeq = trim$(x3422.OrderNoSeq)
            x3422.JobCard = trim$(x3422.JobCard)
            x3422.DateSync = trim$(x3422.DateSync)
            x3422.CheckSync = trim$(x3422.CheckSync)
            x3422.SlNo = trim$(x3422.SlNo)
            x3422.Check_Spec_1 = trim$(x3422.Check_Spec_1)
            x3422.Check_Spec_2 = trim$(x3422.Check_Spec_2)
            x3422.Check_Spec_3 = trim$(x3422.Check_Spec_3)
            x3422.Check_Spec_4 = trim$(x3422.Check_Spec_4)
            x3422.Check_Spec_5 = trim$(x3422.Check_Spec_5)
            x3422.Check_Spec_6 = trim$(x3422.Check_Spec_6)
            x3422.Check_Spec_7 = trim$(x3422.Check_Spec_7)
            x3422.Check_Spec_8 = trim$(x3422.Check_Spec_8)
            x3422.Check_Spec_9 = trim$(x3422.Check_Spec_9)
            x3422.Remark = trim$(x3422.Remark)

            If trim$(x3422.FactOrderNo) = "" Then x3422.FactOrderNo = Space(1)
            If trim$(x3422.FactOrderSeq) = "" Then x3422.FactOrderSeq = 0
            If trim$(x3422.DeclareNo) = "" Then x3422.DeclareNo = Space(1)
            If trim$(x3422.DateDeclare) = "" Then x3422.DateDeclare = Space(1)
            If trim$(x3422.InchargeDeclare) = "" Then x3422.InchargeDeclare = Space(1)
            If trim$(x3422.DeclareAmount) = "" Then x3422.DeclareAmount = 0
            If trim$(x3422.DeclareWgt) = "" Then x3422.DeclareWgt = 0
            If trim$(x3422.seSite) = "" Then x3422.seSite = Space(1)
            If trim$(x3422.cdSite) = "" Then x3422.cdSite = Space(1)
            If trim$(x3422.seDepartment) = "" Then x3422.seDepartment = Space(1)
            If trim$(x3422.cdDepartment) = "" Then x3422.cdDepartment = Space(1)
            If trim$(x3422.seFactory) = "" Then x3422.seFactory = Space(1)
            If trim$(x3422.cdFactory) = "" Then x3422.cdFactory = Space(1)
            If trim$(x3422.seLineProd) = "" Then x3422.seLineProd = Space(1)
            If trim$(x3422.cdLineProd) = "" Then x3422.cdLineProd = Space(1)
            If trim$(x3422.seSubProcess) = "" Then x3422.seSubProcess = Space(1)
            If trim$(x3422.cdSubProcess) = "" Then x3422.cdSubProcess = Space(1)
            If trim$(x3422.seGroupComponent) = "" Then x3422.seGroupComponent = Space(1)
            If trim$(x3422.cdGroupComponent) = "" Then x3422.cdGroupComponent = Space(1)
            If trim$(x3422.CustomerSupplier) = "" Then x3422.CustomerSupplier = Space(1)
            If trim$(x3422.Dseq) = "" Then x3422.Dseq = 0
            If trim$(x3422.Pseq) = "" Then x3422.Pseq = 0
            If trim$(x3422.AutokeyK3011) = "" Then x3422.AutokeyK3011 = 0
            If trim$(x3422.CheckRelationType) = "" Then x3422.CheckRelationType = Space(1)
            If trim$(x3422.ComponentName) = "" Then x3422.ComponentName = Space(1)
            If trim$(x3422.MaterialCode) = "" Then x3422.MaterialCode = Space(1)
            If trim$(x3422.Specification) = "" Then x3422.Specification = Space(1)
            If trim$(x3422.Width) = "" Then x3422.Width = Space(1)
            If trim$(x3422.Height) = "" Then x3422.Height = Space(1)
            If trim$(x3422.SizeNo) = "" Then x3422.SizeNo = Space(1)
            If trim$(x3422.SizeName) = "" Then x3422.SizeName = Space(1)
            If trim$(x3422.ColorCode) = "" Then x3422.ColorCode = Space(1)
            If trim$(x3422.ColorName) = "" Then x3422.ColorName = Space(1)
            If trim$(x3422.seOrigin) = "" Then x3422.seOrigin = Space(1)
            If trim$(x3422.cdOrigin) = "" Then x3422.cdOrigin = Space(1)
            If trim$(x3422.MaterialCheck) = "" Then x3422.MaterialCheck = Space(1)
            If trim$(x3422.seUnitPrice) = "" Then x3422.seUnitPrice = Space(1)
            If trim$(x3422.cdUnitPrice) = "" Then x3422.cdUnitPrice = Space(1)
            If trim$(x3422.seTax) = "" Then x3422.seTax = Space(1)
            If trim$(x3422.cdTax) = "" Then x3422.cdTax = Space(1)
            If trim$(x3422.seUnitMaterial) = "" Then x3422.seUnitMaterial = Space(1)
            If trim$(x3422.cdUnitMaterial) = "" Then x3422.cdUnitMaterial = Space(1)
            If trim$(x3422.seUnitPacking) = "" Then x3422.seUnitPacking = Space(1)
            If trim$(x3422.cdUnitPacking) = "" Then x3422.cdUnitPacking = Space(1)
            If trim$(x3422.UnitBaseCheck) = "" Then x3422.UnitBaseCheck = Space(1)
            If trim$(x3422.QtyBasic) = "" Then x3422.QtyBasic = 0
            If trim$(x3422.PricePurchasing) = "" Then x3422.PricePurchasing = 0
            If trim$(x3422.PriceMarket) = "" Then x3422.PriceMarket = 0
            If trim$(x3422.PriceExchange) = "" Then x3422.PriceExchange = 0
            If trim$(x3422.PriceExchangeAP) = "" Then x3422.PriceExchangeAP = 0
            If trim$(x3422.DateExchange) = "" Then x3422.DateExchange = Space(1)
            If trim$(x3422.PricePurchasingEX) = "" Then x3422.PricePurchasingEX = 0
            If trim$(x3422.PriceMarketEX) = "" Then x3422.PriceMarketEX = 0
            If trim$(x3422.PricePurchasingVND) = "" Then x3422.PricePurchasingVND = 0
            If trim$(x3422.PriceMarketVND) = "" Then x3422.PriceMarketVND = 0
            If trim$(x3422.AmountPurchasingEX) = "" Then x3422.AmountPurchasingEX = 0
            If trim$(x3422.AmountPurchasingVND) = "" Then x3422.AmountPurchasingVND = 0
            If trim$(x3422.AmountTaxEX) = "" Then x3422.AmountTaxEX = 0
            If trim$(x3422.AmountTaxVND) = "" Then x3422.AmountTaxVND = 0
            If trim$(x3422.seTax1) = "" Then x3422.seTax1 = Space(1)
            If trim$(x3422.cdTax1) = "" Then x3422.cdTax1 = Space(1)
            If trim$(x3422.PerTax1) = "" Then x3422.PerTax1 = 0
            If trim$(x3422.AmountTax1) = "" Then x3422.AmountTax1 = 0
            If trim$(x3422.seTax2) = "" Then x3422.seTax2 = Space(1)
            If trim$(x3422.cdTax2) = "" Then x3422.cdTax2 = Space(1)
            If trim$(x3422.PerTax2) = "" Then x3422.PerTax2 = 0
            If trim$(x3422.AmountTax2) = "" Then x3422.AmountTax2 = 0
            If trim$(x3422.seTax3) = "" Then x3422.seTax3 = Space(1)
            If trim$(x3422.cdTax3) = "" Then x3422.cdTax3 = Space(1)
            If trim$(x3422.PerTax3) = "" Then x3422.PerTax3 = 0
            If trim$(x3422.AmountTax3) = "" Then x3422.AmountTax3 = 0
            If trim$(x3422.QtyRequestPO) = "" Then x3422.QtyRequestPO = 0
            If trim$(x3422.QtyPurchasing) = "" Then x3422.QtyPurchasing = 0
            If trim$(x3422.PackPurchasing) = "" Then x3422.PackPurchasing = 0
            If trim$(x3422.QtyWarehouse) = "" Then x3422.QtyWarehouse = 0
            If trim$(x3422.PackWarehouse) = "" Then x3422.PackWarehouse = 0
            If trim$(x3422.QtyInbound) = "" Then x3422.QtyInbound = 0
            If trim$(x3422.PackInbound) = "" Then x3422.PackInbound = 0
            If trim$(x3422.QtyOutbound) = "" Then x3422.QtyOutbound = 0
            If trim$(x3422.PackOutbound) = "" Then x3422.PackOutbound = 0
            If trim$(x3422.AmountEX) = "" Then x3422.AmountEX = 0
            If trim$(x3422.AmountVND) = "" Then x3422.AmountVND = 0
            If trim$(x3422.AmountInBoundEX) = "" Then x3422.AmountInBoundEX = 0
            If trim$(x3422.AmountInBoundVND) = "" Then x3422.AmountInBoundVND = 0
            If trim$(x3422.DateDelivery) = "" Then x3422.DateDelivery = Space(1)
            If trim$(x3422.DateStart) = "" Then x3422.DateStart = Space(1)
            If trim$(x3422.DateFinish) = "" Then x3422.DateFinish = Space(1)
            If trim$(x3422.CheckPurchasing) = "" Then x3422.CheckPurchasing = Space(1)
            If trim$(x3422.DateAccept) = "" Then x3422.DateAccept = Space(1)
            If trim$(x3422.DatePosted) = "" Then x3422.DatePosted = Space(1)
            If trim$(x3422.IsPosted) = "" Then x3422.IsPosted = Space(1)
            If trim$(x3422.DateComplete) = "" Then x3422.DateComplete = Space(1)
            If trim$(x3422.DateApproval) = "" Then x3422.DateApproval = Space(1)
            If trim$(x3422.DateCancel) = "" Then x3422.DateCancel = Space(1)
            If trim$(x3422.CheckComplete) = "" Then x3422.CheckComplete = Space(1)
            If trim$(x3422.PurchasingOrderNo) = "" Then x3422.PurchasingOrderNo = Space(1)
            If trim$(x3422.PurchasingOrderSeq) = "" Then x3422.PurchasingOrderSeq = 0
            If trim$(x3422.JobCardWorking) = "" Then x3422.JobCardWorking = Space(1)
            If trim$(x3422.JobCardWorkingSeq) = "" Then x3422.JobCardWorkingSeq = Space(1)
            If trim$(x3422.JobCardType) = "" Then x3422.JobCardType = Space(1)
            If trim$(x3422.SalesOrderNo) = "" Then x3422.SalesOrderNo = Space(1)
            If trim$(x3422.SalesOrderSeq) = "" Then x3422.SalesOrderSeq = Space(1)
            If trim$(x3422.SalesOrderSno) = "" Then x3422.SalesOrderSno = Space(1)
            If trim$(x3422.CheckOrderType) = "" Then x3422.CheckOrderType = Space(1)
            If trim$(x3422.OrderNo) = "" Then x3422.OrderNo = Space(1)
            If trim$(x3422.OrderNoSeq) = "" Then x3422.OrderNoSeq = Space(1)
            If trim$(x3422.JobCard) = "" Then x3422.JobCard = Space(1)
            If trim$(x3422.DateSync) = "" Then x3422.DateSync = Space(1)
            If trim$(x3422.CheckSync) = "" Then x3422.CheckSync = Space(1)
            If trim$(x3422.SlNo) = "" Then x3422.SlNo = Space(1)
            If trim$(x3422.Check_Spec_1) = "" Then x3422.Check_Spec_1 = Space(1)
            If trim$(x3422.Check_Spec_2) = "" Then x3422.Check_Spec_2 = Space(1)
            If trim$(x3422.Check_Spec_3) = "" Then x3422.Check_Spec_3 = Space(1)
            If trim$(x3422.Check_Spec_4) = "" Then x3422.Check_Spec_4 = Space(1)
            If trim$(x3422.Check_Spec_5) = "" Then x3422.Check_Spec_5 = Space(1)
            If trim$(x3422.Check_Spec_6) = "" Then x3422.Check_Spec_6 = Space(1)
            If trim$(x3422.Check_Spec_7) = "" Then x3422.Check_Spec_7 = Space(1)
            If trim$(x3422.Check_Spec_8) = "" Then x3422.Check_Spec_8 = Space(1)
            If trim$(x3422.Check_Spec_9) = "" Then x3422.Check_Spec_9 = Space(1)
            If trim$(x3422.Remark) = "" Then x3422.Remark = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K3422_MOVE(rs3422 As SqlClient.SqlDataReader)
        Try

            Call D3422_CLEAR()

            If IsdbNull(rs3422!K3422_FactOrderNo) = False Then D3422.FactOrderNo = Trim$(rs3422!K3422_FactOrderNo)
            If IsdbNull(rs3422!K3422_FactOrderSeq) = False Then D3422.FactOrderSeq = Trim$(rs3422!K3422_FactOrderSeq)
            If IsdbNull(rs3422!K3422_DeclareNo) = False Then D3422.DeclareNo = Trim$(rs3422!K3422_DeclareNo)
            If IsdbNull(rs3422!K3422_DateDeclare) = False Then D3422.DateDeclare = Trim$(rs3422!K3422_DateDeclare)
            If IsdbNull(rs3422!K3422_InchargeDeclare) = False Then D3422.InchargeDeclare = Trim$(rs3422!K3422_InchargeDeclare)
            If IsdbNull(rs3422!K3422_DeclareAmount) = False Then D3422.DeclareAmount = Trim$(rs3422!K3422_DeclareAmount)
            If IsdbNull(rs3422!K3422_DeclareWgt) = False Then D3422.DeclareWgt = Trim$(rs3422!K3422_DeclareWgt)
            If IsdbNull(rs3422!K3422_seSite) = False Then D3422.seSite = Trim$(rs3422!K3422_seSite)
            If IsdbNull(rs3422!K3422_cdSite) = False Then D3422.cdSite = Trim$(rs3422!K3422_cdSite)
            If IsdbNull(rs3422!K3422_seDepartment) = False Then D3422.seDepartment = Trim$(rs3422!K3422_seDepartment)
            If IsdbNull(rs3422!K3422_cdDepartment) = False Then D3422.cdDepartment = Trim$(rs3422!K3422_cdDepartment)
            If IsdbNull(rs3422!K3422_seFactory) = False Then D3422.seFactory = Trim$(rs3422!K3422_seFactory)
            If IsdbNull(rs3422!K3422_cdFactory) = False Then D3422.cdFactory = Trim$(rs3422!K3422_cdFactory)
            If IsdbNull(rs3422!K3422_seLineProd) = False Then D3422.seLineProd = Trim$(rs3422!K3422_seLineProd)
            If IsdbNull(rs3422!K3422_cdLineProd) = False Then D3422.cdLineProd = Trim$(rs3422!K3422_cdLineProd)
            If IsdbNull(rs3422!K3422_seSubProcess) = False Then D3422.seSubProcess = Trim$(rs3422!K3422_seSubProcess)
            If IsdbNull(rs3422!K3422_cdSubProcess) = False Then D3422.cdSubProcess = Trim$(rs3422!K3422_cdSubProcess)
            If IsdbNull(rs3422!K3422_seGroupComponent) = False Then D3422.seGroupComponent = Trim$(rs3422!K3422_seGroupComponent)
            If IsdbNull(rs3422!K3422_cdGroupComponent) = False Then D3422.cdGroupComponent = Trim$(rs3422!K3422_cdGroupComponent)
            If IsdbNull(rs3422!K3422_CustomerSupplier) = False Then D3422.CustomerSupplier = Trim$(rs3422!K3422_CustomerSupplier)
            If IsdbNull(rs3422!K3422_Dseq) = False Then D3422.Dseq = Trim$(rs3422!K3422_Dseq)
            If IsdbNull(rs3422!K3422_Pseq) = False Then D3422.Pseq = Trim$(rs3422!K3422_Pseq)
            If IsdbNull(rs3422!K3422_AutokeyK3011) = False Then D3422.AutokeyK3011 = Trim$(rs3422!K3422_AutokeyK3011)
            If IsdbNull(rs3422!K3422_CheckRelationType) = False Then D3422.CheckRelationType = Trim$(rs3422!K3422_CheckRelationType)
            If IsdbNull(rs3422!K3422_ComponentName) = False Then D3422.ComponentName = Trim$(rs3422!K3422_ComponentName)
            If IsdbNull(rs3422!K3422_MaterialCode) = False Then D3422.MaterialCode = Trim$(rs3422!K3422_MaterialCode)
            If IsdbNull(rs3422!K3422_Specification) = False Then D3422.Specification = Trim$(rs3422!K3422_Specification)
            If IsdbNull(rs3422!K3422_Width) = False Then D3422.Width = Trim$(rs3422!K3422_Width)
            If IsdbNull(rs3422!K3422_Height) = False Then D3422.Height = Trim$(rs3422!K3422_Height)
            If IsdbNull(rs3422!K3422_SizeNo) = False Then D3422.SizeNo = Trim$(rs3422!K3422_SizeNo)
            If IsdbNull(rs3422!K3422_SizeName) = False Then D3422.SizeName = Trim$(rs3422!K3422_SizeName)
            If IsdbNull(rs3422!K3422_ColorCode) = False Then D3422.ColorCode = Trim$(rs3422!K3422_ColorCode)
            If IsdbNull(rs3422!K3422_ColorName) = False Then D3422.ColorName = Trim$(rs3422!K3422_ColorName)
            If IsdbNull(rs3422!K3422_seOrigin) = False Then D3422.seOrigin = Trim$(rs3422!K3422_seOrigin)
            If IsdbNull(rs3422!K3422_cdOrigin) = False Then D3422.cdOrigin = Trim$(rs3422!K3422_cdOrigin)
            If IsdbNull(rs3422!K3422_MaterialCheck) = False Then D3422.MaterialCheck = Trim$(rs3422!K3422_MaterialCheck)
            If IsdbNull(rs3422!K3422_seUnitPrice) = False Then D3422.seUnitPrice = Trim$(rs3422!K3422_seUnitPrice)
            If IsdbNull(rs3422!K3422_cdUnitPrice) = False Then D3422.cdUnitPrice = Trim$(rs3422!K3422_cdUnitPrice)
            If IsdbNull(rs3422!K3422_seTax) = False Then D3422.seTax = Trim$(rs3422!K3422_seTax)
            If IsdbNull(rs3422!K3422_cdTax) = False Then D3422.cdTax = Trim$(rs3422!K3422_cdTax)
            If IsdbNull(rs3422!K3422_seUnitMaterial) = False Then D3422.seUnitMaterial = Trim$(rs3422!K3422_seUnitMaterial)
            If IsdbNull(rs3422!K3422_cdUnitMaterial) = False Then D3422.cdUnitMaterial = Trim$(rs3422!K3422_cdUnitMaterial)
            If IsdbNull(rs3422!K3422_seUnitPacking) = False Then D3422.seUnitPacking = Trim$(rs3422!K3422_seUnitPacking)
            If IsdbNull(rs3422!K3422_cdUnitPacking) = False Then D3422.cdUnitPacking = Trim$(rs3422!K3422_cdUnitPacking)
            If IsdbNull(rs3422!K3422_UnitBaseCheck) = False Then D3422.UnitBaseCheck = Trim$(rs3422!K3422_UnitBaseCheck)
            If IsdbNull(rs3422!K3422_QtyBasic) = False Then D3422.QtyBasic = Trim$(rs3422!K3422_QtyBasic)
            If IsdbNull(rs3422!K3422_PricePurchasing) = False Then D3422.PricePurchasing = Trim$(rs3422!K3422_PricePurchasing)
            If IsdbNull(rs3422!K3422_PriceMarket) = False Then D3422.PriceMarket = Trim$(rs3422!K3422_PriceMarket)
            If IsdbNull(rs3422!K3422_PriceExchange) = False Then D3422.PriceExchange = Trim$(rs3422!K3422_PriceExchange)
            If IsdbNull(rs3422!K3422_PriceExchangeAP) = False Then D3422.PriceExchangeAP = Trim$(rs3422!K3422_PriceExchangeAP)
            If IsdbNull(rs3422!K3422_DateExchange) = False Then D3422.DateExchange = Trim$(rs3422!K3422_DateExchange)
            If IsdbNull(rs3422!K3422_PricePurchasingEX) = False Then D3422.PricePurchasingEX = Trim$(rs3422!K3422_PricePurchasingEX)
            If IsdbNull(rs3422!K3422_PriceMarketEX) = False Then D3422.PriceMarketEX = Trim$(rs3422!K3422_PriceMarketEX)
            If IsdbNull(rs3422!K3422_PricePurchasingVND) = False Then D3422.PricePurchasingVND = Trim$(rs3422!K3422_PricePurchasingVND)
            If IsdbNull(rs3422!K3422_PriceMarketVND) = False Then D3422.PriceMarketVND = Trim$(rs3422!K3422_PriceMarketVND)
            If IsdbNull(rs3422!K3422_AmountPurchasingEX) = False Then D3422.AmountPurchasingEX = Trim$(rs3422!K3422_AmountPurchasingEX)
            If IsdbNull(rs3422!K3422_AmountPurchasingVND) = False Then D3422.AmountPurchasingVND = Trim$(rs3422!K3422_AmountPurchasingVND)
            If IsdbNull(rs3422!K3422_AmountTaxEX) = False Then D3422.AmountTaxEX = Trim$(rs3422!K3422_AmountTaxEX)
            If IsdbNull(rs3422!K3422_AmountTaxVND) = False Then D3422.AmountTaxVND = Trim$(rs3422!K3422_AmountTaxVND)
            If IsdbNull(rs3422!K3422_seTax1) = False Then D3422.seTax1 = Trim$(rs3422!K3422_seTax1)
            If IsdbNull(rs3422!K3422_cdTax1) = False Then D3422.cdTax1 = Trim$(rs3422!K3422_cdTax1)
            If IsdbNull(rs3422!K3422_PerTax1) = False Then D3422.PerTax1 = Trim$(rs3422!K3422_PerTax1)
            If IsdbNull(rs3422!K3422_AmountTax1) = False Then D3422.AmountTax1 = Trim$(rs3422!K3422_AmountTax1)
            If IsdbNull(rs3422!K3422_seTax2) = False Then D3422.seTax2 = Trim$(rs3422!K3422_seTax2)
            If IsdbNull(rs3422!K3422_cdTax2) = False Then D3422.cdTax2 = Trim$(rs3422!K3422_cdTax2)
            If IsdbNull(rs3422!K3422_PerTax2) = False Then D3422.PerTax2 = Trim$(rs3422!K3422_PerTax2)
            If IsdbNull(rs3422!K3422_AmountTax2) = False Then D3422.AmountTax2 = Trim$(rs3422!K3422_AmountTax2)
            If IsdbNull(rs3422!K3422_seTax3) = False Then D3422.seTax3 = Trim$(rs3422!K3422_seTax3)
            If IsdbNull(rs3422!K3422_cdTax3) = False Then D3422.cdTax3 = Trim$(rs3422!K3422_cdTax3)
            If IsdbNull(rs3422!K3422_PerTax3) = False Then D3422.PerTax3 = Trim$(rs3422!K3422_PerTax3)
            If IsdbNull(rs3422!K3422_AmountTax3) = False Then D3422.AmountTax3 = Trim$(rs3422!K3422_AmountTax3)
            If IsdbNull(rs3422!K3422_QtyRequestPO) = False Then D3422.QtyRequestPO = Trim$(rs3422!K3422_QtyRequestPO)
            If IsdbNull(rs3422!K3422_QtyPurchasing) = False Then D3422.QtyPurchasing = Trim$(rs3422!K3422_QtyPurchasing)
            If IsdbNull(rs3422!K3422_PackPurchasing) = False Then D3422.PackPurchasing = Trim$(rs3422!K3422_PackPurchasing)
            If IsdbNull(rs3422!K3422_QtyWarehouse) = False Then D3422.QtyWarehouse = Trim$(rs3422!K3422_QtyWarehouse)
            If IsdbNull(rs3422!K3422_PackWarehouse) = False Then D3422.PackWarehouse = Trim$(rs3422!K3422_PackWarehouse)
            If IsdbNull(rs3422!K3422_QtyInbound) = False Then D3422.QtyInbound = Trim$(rs3422!K3422_QtyInbound)
            If IsdbNull(rs3422!K3422_PackInbound) = False Then D3422.PackInbound = Trim$(rs3422!K3422_PackInbound)
            If IsdbNull(rs3422!K3422_QtyOutbound) = False Then D3422.QtyOutbound = Trim$(rs3422!K3422_QtyOutbound)
            If IsdbNull(rs3422!K3422_PackOutbound) = False Then D3422.PackOutbound = Trim$(rs3422!K3422_PackOutbound)
            If IsdbNull(rs3422!K3422_AmountEX) = False Then D3422.AmountEX = Trim$(rs3422!K3422_AmountEX)
            If IsdbNull(rs3422!K3422_AmountVND) = False Then D3422.AmountVND = Trim$(rs3422!K3422_AmountVND)
            If IsdbNull(rs3422!K3422_AmountInBoundEX) = False Then D3422.AmountInBoundEX = Trim$(rs3422!K3422_AmountInBoundEX)
            If IsdbNull(rs3422!K3422_AmountInBoundVND) = False Then D3422.AmountInBoundVND = Trim$(rs3422!K3422_AmountInBoundVND)
            If IsdbNull(rs3422!K3422_DateDelivery) = False Then D3422.DateDelivery = Trim$(rs3422!K3422_DateDelivery)
            If IsdbNull(rs3422!K3422_DateStart) = False Then D3422.DateStart = Trim$(rs3422!K3422_DateStart)
            If IsdbNull(rs3422!K3422_DateFinish) = False Then D3422.DateFinish = Trim$(rs3422!K3422_DateFinish)
            If IsdbNull(rs3422!K3422_CheckPurchasing) = False Then D3422.CheckPurchasing = Trim$(rs3422!K3422_CheckPurchasing)
            If IsdbNull(rs3422!K3422_DateAccept) = False Then D3422.DateAccept = Trim$(rs3422!K3422_DateAccept)
            If IsdbNull(rs3422!K3422_DatePosted) = False Then D3422.DatePosted = Trim$(rs3422!K3422_DatePosted)
            If IsdbNull(rs3422!K3422_IsPosted) = False Then D3422.IsPosted = Trim$(rs3422!K3422_IsPosted)
            If IsdbNull(rs3422!K3422_DateComplete) = False Then D3422.DateComplete = Trim$(rs3422!K3422_DateComplete)
            If IsdbNull(rs3422!K3422_DateApproval) = False Then D3422.DateApproval = Trim$(rs3422!K3422_DateApproval)
            If IsdbNull(rs3422!K3422_DateCancel) = False Then D3422.DateCancel = Trim$(rs3422!K3422_DateCancel)
            If IsdbNull(rs3422!K3422_CheckComplete) = False Then D3422.CheckComplete = Trim$(rs3422!K3422_CheckComplete)
            If IsdbNull(rs3422!K3422_PurchasingOrderNo) = False Then D3422.PurchasingOrderNo = Trim$(rs3422!K3422_PurchasingOrderNo)
            If IsdbNull(rs3422!K3422_PurchasingOrderSeq) = False Then D3422.PurchasingOrderSeq = Trim$(rs3422!K3422_PurchasingOrderSeq)
            If IsdbNull(rs3422!K3422_JobCardWorking) = False Then D3422.JobCardWorking = Trim$(rs3422!K3422_JobCardWorking)
            If IsdbNull(rs3422!K3422_JobCardWorkingSeq) = False Then D3422.JobCardWorkingSeq = Trim$(rs3422!K3422_JobCardWorkingSeq)
            If IsdbNull(rs3422!K3422_JobCardType) = False Then D3422.JobCardType = Trim$(rs3422!K3422_JobCardType)
            If IsdbNull(rs3422!K3422_SalesOrderNo) = False Then D3422.SalesOrderNo = Trim$(rs3422!K3422_SalesOrderNo)
            If IsdbNull(rs3422!K3422_SalesOrderSeq) = False Then D3422.SalesOrderSeq = Trim$(rs3422!K3422_SalesOrderSeq)
            If IsdbNull(rs3422!K3422_SalesOrderSno) = False Then D3422.SalesOrderSno = Trim$(rs3422!K3422_SalesOrderSno)
            If IsdbNull(rs3422!K3422_CheckOrderType) = False Then D3422.CheckOrderType = Trim$(rs3422!K3422_CheckOrderType)
            If IsdbNull(rs3422!K3422_OrderNo) = False Then D3422.OrderNo = Trim$(rs3422!K3422_OrderNo)
            If IsdbNull(rs3422!K3422_OrderNoSeq) = False Then D3422.OrderNoSeq = Trim$(rs3422!K3422_OrderNoSeq)
            If IsdbNull(rs3422!K3422_JobCard) = False Then D3422.JobCard = Trim$(rs3422!K3422_JobCard)
            If IsdbNull(rs3422!K3422_DateSync) = False Then D3422.DateSync = Trim$(rs3422!K3422_DateSync)
            If IsdbNull(rs3422!K3422_CheckSync) = False Then D3422.CheckSync = Trim$(rs3422!K3422_CheckSync)
            If IsdbNull(rs3422!K3422_SlNo) = False Then D3422.SlNo = Trim$(rs3422!K3422_SlNo)
            If IsdbNull(rs3422!K3422_Check_Spec_1) = False Then D3422.Check_Spec_1 = Trim$(rs3422!K3422_Check_Spec_1)
            If IsdbNull(rs3422!K3422_Check_Spec_2) = False Then D3422.Check_Spec_2 = Trim$(rs3422!K3422_Check_Spec_2)
            If IsdbNull(rs3422!K3422_Check_Spec_3) = False Then D3422.Check_Spec_3 = Trim$(rs3422!K3422_Check_Spec_3)
            If IsdbNull(rs3422!K3422_Check_Spec_4) = False Then D3422.Check_Spec_4 = Trim$(rs3422!K3422_Check_Spec_4)
            If IsdbNull(rs3422!K3422_Check_Spec_5) = False Then D3422.Check_Spec_5 = Trim$(rs3422!K3422_Check_Spec_5)
            If IsdbNull(rs3422!K3422_Check_Spec_6) = False Then D3422.Check_Spec_6 = Trim$(rs3422!K3422_Check_Spec_6)
            If IsdbNull(rs3422!K3422_Check_Spec_7) = False Then D3422.Check_Spec_7 = Trim$(rs3422!K3422_Check_Spec_7)
            If IsdbNull(rs3422!K3422_Check_Spec_8) = False Then D3422.Check_Spec_8 = Trim$(rs3422!K3422_Check_Spec_8)
            If IsdbNull(rs3422!K3422_Check_Spec_9) = False Then D3422.Check_Spec_9 = Trim$(rs3422!K3422_Check_Spec_9)
            If IsdbNull(rs3422!K3422_Remark) = False Then D3422.Remark = Trim$(rs3422!K3422_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K3422_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K3422_MOVE(rs3422 As DataRow)
        Try

            Call D3422_CLEAR()

            If IsdbNull(rs3422!K3422_FactOrderNo) = False Then D3422.FactOrderNo = Trim$(rs3422!K3422_FactOrderNo)
            If IsdbNull(rs3422!K3422_FactOrderSeq) = False Then D3422.FactOrderSeq = Trim$(rs3422!K3422_FactOrderSeq)
            If IsdbNull(rs3422!K3422_DeclareNo) = False Then D3422.DeclareNo = Trim$(rs3422!K3422_DeclareNo)
            If IsdbNull(rs3422!K3422_DateDeclare) = False Then D3422.DateDeclare = Trim$(rs3422!K3422_DateDeclare)
            If IsdbNull(rs3422!K3422_InchargeDeclare) = False Then D3422.InchargeDeclare = Trim$(rs3422!K3422_InchargeDeclare)
            If IsdbNull(rs3422!K3422_DeclareAmount) = False Then D3422.DeclareAmount = Trim$(rs3422!K3422_DeclareAmount)
            If IsdbNull(rs3422!K3422_DeclareWgt) = False Then D3422.DeclareWgt = Trim$(rs3422!K3422_DeclareWgt)
            If IsdbNull(rs3422!K3422_seSite) = False Then D3422.seSite = Trim$(rs3422!K3422_seSite)
            If IsdbNull(rs3422!K3422_cdSite) = False Then D3422.cdSite = Trim$(rs3422!K3422_cdSite)
            If IsdbNull(rs3422!K3422_seDepartment) = False Then D3422.seDepartment = Trim$(rs3422!K3422_seDepartment)
            If IsdbNull(rs3422!K3422_cdDepartment) = False Then D3422.cdDepartment = Trim$(rs3422!K3422_cdDepartment)
            If IsdbNull(rs3422!K3422_seFactory) = False Then D3422.seFactory = Trim$(rs3422!K3422_seFactory)
            If IsdbNull(rs3422!K3422_cdFactory) = False Then D3422.cdFactory = Trim$(rs3422!K3422_cdFactory)
            If IsdbNull(rs3422!K3422_seLineProd) = False Then D3422.seLineProd = Trim$(rs3422!K3422_seLineProd)
            If IsdbNull(rs3422!K3422_cdLineProd) = False Then D3422.cdLineProd = Trim$(rs3422!K3422_cdLineProd)
            If IsdbNull(rs3422!K3422_seSubProcess) = False Then D3422.seSubProcess = Trim$(rs3422!K3422_seSubProcess)
            If IsdbNull(rs3422!K3422_cdSubProcess) = False Then D3422.cdSubProcess = Trim$(rs3422!K3422_cdSubProcess)
            If IsdbNull(rs3422!K3422_seGroupComponent) = False Then D3422.seGroupComponent = Trim$(rs3422!K3422_seGroupComponent)
            If IsdbNull(rs3422!K3422_cdGroupComponent) = False Then D3422.cdGroupComponent = Trim$(rs3422!K3422_cdGroupComponent)
            If IsdbNull(rs3422!K3422_CustomerSupplier) = False Then D3422.CustomerSupplier = Trim$(rs3422!K3422_CustomerSupplier)
            If IsdbNull(rs3422!K3422_Dseq) = False Then D3422.Dseq = Trim$(rs3422!K3422_Dseq)
            If IsdbNull(rs3422!K3422_Pseq) = False Then D3422.Pseq = Trim$(rs3422!K3422_Pseq)
            If IsdbNull(rs3422!K3422_AutokeyK3011) = False Then D3422.AutokeyK3011 = Trim$(rs3422!K3422_AutokeyK3011)
            If IsdbNull(rs3422!K3422_CheckRelationType) = False Then D3422.CheckRelationType = Trim$(rs3422!K3422_CheckRelationType)
            If IsdbNull(rs3422!K3422_ComponentName) = False Then D3422.ComponentName = Trim$(rs3422!K3422_ComponentName)
            If IsdbNull(rs3422!K3422_MaterialCode) = False Then D3422.MaterialCode = Trim$(rs3422!K3422_MaterialCode)
            If IsdbNull(rs3422!K3422_Specification) = False Then D3422.Specification = Trim$(rs3422!K3422_Specification)
            If IsdbNull(rs3422!K3422_Width) = False Then D3422.Width = Trim$(rs3422!K3422_Width)
            If IsdbNull(rs3422!K3422_Height) = False Then D3422.Height = Trim$(rs3422!K3422_Height)
            If IsdbNull(rs3422!K3422_SizeNo) = False Then D3422.SizeNo = Trim$(rs3422!K3422_SizeNo)
            If IsdbNull(rs3422!K3422_SizeName) = False Then D3422.SizeName = Trim$(rs3422!K3422_SizeName)
            If IsdbNull(rs3422!K3422_ColorCode) = False Then D3422.ColorCode = Trim$(rs3422!K3422_ColorCode)
            If IsdbNull(rs3422!K3422_ColorName) = False Then D3422.ColorName = Trim$(rs3422!K3422_ColorName)
            If IsdbNull(rs3422!K3422_seOrigin) = False Then D3422.seOrigin = Trim$(rs3422!K3422_seOrigin)
            If IsdbNull(rs3422!K3422_cdOrigin) = False Then D3422.cdOrigin = Trim$(rs3422!K3422_cdOrigin)
            If IsdbNull(rs3422!K3422_MaterialCheck) = False Then D3422.MaterialCheck = Trim$(rs3422!K3422_MaterialCheck)
            If IsdbNull(rs3422!K3422_seUnitPrice) = False Then D3422.seUnitPrice = Trim$(rs3422!K3422_seUnitPrice)
            If IsdbNull(rs3422!K3422_cdUnitPrice) = False Then D3422.cdUnitPrice = Trim$(rs3422!K3422_cdUnitPrice)
            If IsdbNull(rs3422!K3422_seTax) = False Then D3422.seTax = Trim$(rs3422!K3422_seTax)
            If IsdbNull(rs3422!K3422_cdTax) = False Then D3422.cdTax = Trim$(rs3422!K3422_cdTax)
            If IsdbNull(rs3422!K3422_seUnitMaterial) = False Then D3422.seUnitMaterial = Trim$(rs3422!K3422_seUnitMaterial)
            If IsdbNull(rs3422!K3422_cdUnitMaterial) = False Then D3422.cdUnitMaterial = Trim$(rs3422!K3422_cdUnitMaterial)
            If IsdbNull(rs3422!K3422_seUnitPacking) = False Then D3422.seUnitPacking = Trim$(rs3422!K3422_seUnitPacking)
            If IsdbNull(rs3422!K3422_cdUnitPacking) = False Then D3422.cdUnitPacking = Trim$(rs3422!K3422_cdUnitPacking)
            If IsdbNull(rs3422!K3422_UnitBaseCheck) = False Then D3422.UnitBaseCheck = Trim$(rs3422!K3422_UnitBaseCheck)
            If IsdbNull(rs3422!K3422_QtyBasic) = False Then D3422.QtyBasic = Trim$(rs3422!K3422_QtyBasic)
            If IsdbNull(rs3422!K3422_PricePurchasing) = False Then D3422.PricePurchasing = Trim$(rs3422!K3422_PricePurchasing)
            If IsdbNull(rs3422!K3422_PriceMarket) = False Then D3422.PriceMarket = Trim$(rs3422!K3422_PriceMarket)
            If IsdbNull(rs3422!K3422_PriceExchange) = False Then D3422.PriceExchange = Trim$(rs3422!K3422_PriceExchange)
            If IsdbNull(rs3422!K3422_PriceExchangeAP) = False Then D3422.PriceExchangeAP = Trim$(rs3422!K3422_PriceExchangeAP)
            If IsdbNull(rs3422!K3422_DateExchange) = False Then D3422.DateExchange = Trim$(rs3422!K3422_DateExchange)
            If IsdbNull(rs3422!K3422_PricePurchasingEX) = False Then D3422.PricePurchasingEX = Trim$(rs3422!K3422_PricePurchasingEX)
            If IsdbNull(rs3422!K3422_PriceMarketEX) = False Then D3422.PriceMarketEX = Trim$(rs3422!K3422_PriceMarketEX)
            If IsdbNull(rs3422!K3422_PricePurchasingVND) = False Then D3422.PricePurchasingVND = Trim$(rs3422!K3422_PricePurchasingVND)
            If IsdbNull(rs3422!K3422_PriceMarketVND) = False Then D3422.PriceMarketVND = Trim$(rs3422!K3422_PriceMarketVND)
            If IsdbNull(rs3422!K3422_AmountPurchasingEX) = False Then D3422.AmountPurchasingEX = Trim$(rs3422!K3422_AmountPurchasingEX)
            If IsdbNull(rs3422!K3422_AmountPurchasingVND) = False Then D3422.AmountPurchasingVND = Trim$(rs3422!K3422_AmountPurchasingVND)
            If IsdbNull(rs3422!K3422_AmountTaxEX) = False Then D3422.AmountTaxEX = Trim$(rs3422!K3422_AmountTaxEX)
            If IsdbNull(rs3422!K3422_AmountTaxVND) = False Then D3422.AmountTaxVND = Trim$(rs3422!K3422_AmountTaxVND)
            If IsdbNull(rs3422!K3422_seTax1) = False Then D3422.seTax1 = Trim$(rs3422!K3422_seTax1)
            If IsdbNull(rs3422!K3422_cdTax1) = False Then D3422.cdTax1 = Trim$(rs3422!K3422_cdTax1)
            If IsdbNull(rs3422!K3422_PerTax1) = False Then D3422.PerTax1 = Trim$(rs3422!K3422_PerTax1)
            If IsdbNull(rs3422!K3422_AmountTax1) = False Then D3422.AmountTax1 = Trim$(rs3422!K3422_AmountTax1)
            If IsdbNull(rs3422!K3422_seTax2) = False Then D3422.seTax2 = Trim$(rs3422!K3422_seTax2)
            If IsdbNull(rs3422!K3422_cdTax2) = False Then D3422.cdTax2 = Trim$(rs3422!K3422_cdTax2)
            If IsdbNull(rs3422!K3422_PerTax2) = False Then D3422.PerTax2 = Trim$(rs3422!K3422_PerTax2)
            If IsdbNull(rs3422!K3422_AmountTax2) = False Then D3422.AmountTax2 = Trim$(rs3422!K3422_AmountTax2)
            If IsdbNull(rs3422!K3422_seTax3) = False Then D3422.seTax3 = Trim$(rs3422!K3422_seTax3)
            If IsdbNull(rs3422!K3422_cdTax3) = False Then D3422.cdTax3 = Trim$(rs3422!K3422_cdTax3)
            If IsdbNull(rs3422!K3422_PerTax3) = False Then D3422.PerTax3 = Trim$(rs3422!K3422_PerTax3)
            If IsdbNull(rs3422!K3422_AmountTax3) = False Then D3422.AmountTax3 = Trim$(rs3422!K3422_AmountTax3)
            If IsdbNull(rs3422!K3422_QtyRequestPO) = False Then D3422.QtyRequestPO = Trim$(rs3422!K3422_QtyRequestPO)
            If IsdbNull(rs3422!K3422_QtyPurchasing) = False Then D3422.QtyPurchasing = Trim$(rs3422!K3422_QtyPurchasing)
            If IsdbNull(rs3422!K3422_PackPurchasing) = False Then D3422.PackPurchasing = Trim$(rs3422!K3422_PackPurchasing)
            If IsdbNull(rs3422!K3422_QtyWarehouse) = False Then D3422.QtyWarehouse = Trim$(rs3422!K3422_QtyWarehouse)
            If IsdbNull(rs3422!K3422_PackWarehouse) = False Then D3422.PackWarehouse = Trim$(rs3422!K3422_PackWarehouse)
            If IsdbNull(rs3422!K3422_QtyInbound) = False Then D3422.QtyInbound = Trim$(rs3422!K3422_QtyInbound)
            If IsdbNull(rs3422!K3422_PackInbound) = False Then D3422.PackInbound = Trim$(rs3422!K3422_PackInbound)
            If IsdbNull(rs3422!K3422_QtyOutbound) = False Then D3422.QtyOutbound = Trim$(rs3422!K3422_QtyOutbound)
            If IsdbNull(rs3422!K3422_PackOutbound) = False Then D3422.PackOutbound = Trim$(rs3422!K3422_PackOutbound)
            If IsdbNull(rs3422!K3422_AmountEX) = False Then D3422.AmountEX = Trim$(rs3422!K3422_AmountEX)
            If IsdbNull(rs3422!K3422_AmountVND) = False Then D3422.AmountVND = Trim$(rs3422!K3422_AmountVND)
            If IsdbNull(rs3422!K3422_AmountInBoundEX) = False Then D3422.AmountInBoundEX = Trim$(rs3422!K3422_AmountInBoundEX)
            If IsdbNull(rs3422!K3422_AmountInBoundVND) = False Then D3422.AmountInBoundVND = Trim$(rs3422!K3422_AmountInBoundVND)
            If IsdbNull(rs3422!K3422_DateDelivery) = False Then D3422.DateDelivery = Trim$(rs3422!K3422_DateDelivery)
            If IsdbNull(rs3422!K3422_DateStart) = False Then D3422.DateStart = Trim$(rs3422!K3422_DateStart)
            If IsdbNull(rs3422!K3422_DateFinish) = False Then D3422.DateFinish = Trim$(rs3422!K3422_DateFinish)
            If IsdbNull(rs3422!K3422_CheckPurchasing) = False Then D3422.CheckPurchasing = Trim$(rs3422!K3422_CheckPurchasing)
            If IsdbNull(rs3422!K3422_DateAccept) = False Then D3422.DateAccept = Trim$(rs3422!K3422_DateAccept)
            If IsdbNull(rs3422!K3422_DatePosted) = False Then D3422.DatePosted = Trim$(rs3422!K3422_DatePosted)
            If IsdbNull(rs3422!K3422_IsPosted) = False Then D3422.IsPosted = Trim$(rs3422!K3422_IsPosted)
            If IsdbNull(rs3422!K3422_DateComplete) = False Then D3422.DateComplete = Trim$(rs3422!K3422_DateComplete)
            If IsdbNull(rs3422!K3422_DateApproval) = False Then D3422.DateApproval = Trim$(rs3422!K3422_DateApproval)
            If IsdbNull(rs3422!K3422_DateCancel) = False Then D3422.DateCancel = Trim$(rs3422!K3422_DateCancel)
            If IsdbNull(rs3422!K3422_CheckComplete) = False Then D3422.CheckComplete = Trim$(rs3422!K3422_CheckComplete)
            If IsdbNull(rs3422!K3422_PurchasingOrderNo) = False Then D3422.PurchasingOrderNo = Trim$(rs3422!K3422_PurchasingOrderNo)
            If IsdbNull(rs3422!K3422_PurchasingOrderSeq) = False Then D3422.PurchasingOrderSeq = Trim$(rs3422!K3422_PurchasingOrderSeq)
            If IsdbNull(rs3422!K3422_JobCardWorking) = False Then D3422.JobCardWorking = Trim$(rs3422!K3422_JobCardWorking)
            If IsdbNull(rs3422!K3422_JobCardWorkingSeq) = False Then D3422.JobCardWorkingSeq = Trim$(rs3422!K3422_JobCardWorkingSeq)
            If IsdbNull(rs3422!K3422_JobCardType) = False Then D3422.JobCardType = Trim$(rs3422!K3422_JobCardType)
            If IsdbNull(rs3422!K3422_SalesOrderNo) = False Then D3422.SalesOrderNo = Trim$(rs3422!K3422_SalesOrderNo)
            If IsdbNull(rs3422!K3422_SalesOrderSeq) = False Then D3422.SalesOrderSeq = Trim$(rs3422!K3422_SalesOrderSeq)
            If IsdbNull(rs3422!K3422_SalesOrderSno) = False Then D3422.SalesOrderSno = Trim$(rs3422!K3422_SalesOrderSno)
            If IsdbNull(rs3422!K3422_CheckOrderType) = False Then D3422.CheckOrderType = Trim$(rs3422!K3422_CheckOrderType)
            If IsdbNull(rs3422!K3422_OrderNo) = False Then D3422.OrderNo = Trim$(rs3422!K3422_OrderNo)
            If IsdbNull(rs3422!K3422_OrderNoSeq) = False Then D3422.OrderNoSeq = Trim$(rs3422!K3422_OrderNoSeq)
            If IsdbNull(rs3422!K3422_JobCard) = False Then D3422.JobCard = Trim$(rs3422!K3422_JobCard)
            If IsdbNull(rs3422!K3422_DateSync) = False Then D3422.DateSync = Trim$(rs3422!K3422_DateSync)
            If IsdbNull(rs3422!K3422_CheckSync) = False Then D3422.CheckSync = Trim$(rs3422!K3422_CheckSync)
            If IsdbNull(rs3422!K3422_SlNo) = False Then D3422.SlNo = Trim$(rs3422!K3422_SlNo)
            If IsdbNull(rs3422!K3422_Check_Spec_1) = False Then D3422.Check_Spec_1 = Trim$(rs3422!K3422_Check_Spec_1)
            If IsdbNull(rs3422!K3422_Check_Spec_2) = False Then D3422.Check_Spec_2 = Trim$(rs3422!K3422_Check_Spec_2)
            If IsdbNull(rs3422!K3422_Check_Spec_3) = False Then D3422.Check_Spec_3 = Trim$(rs3422!K3422_Check_Spec_3)
            If IsdbNull(rs3422!K3422_Check_Spec_4) = False Then D3422.Check_Spec_4 = Trim$(rs3422!K3422_Check_Spec_4)
            If IsdbNull(rs3422!K3422_Check_Spec_5) = False Then D3422.Check_Spec_5 = Trim$(rs3422!K3422_Check_Spec_5)
            If IsdbNull(rs3422!K3422_Check_Spec_6) = False Then D3422.Check_Spec_6 = Trim$(rs3422!K3422_Check_Spec_6)
            If IsdbNull(rs3422!K3422_Check_Spec_7) = False Then D3422.Check_Spec_7 = Trim$(rs3422!K3422_Check_Spec_7)
            If IsdbNull(rs3422!K3422_Check_Spec_8) = False Then D3422.Check_Spec_8 = Trim$(rs3422!K3422_Check_Spec_8)
            If IsdbNull(rs3422!K3422_Check_Spec_9) = False Then D3422.Check_Spec_9 = Trim$(rs3422!K3422_Check_Spec_9)
            If IsdbNull(rs3422!K3422_Remark) = False Then D3422.Remark = Trim$(rs3422!K3422_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K3422_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K3422_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z3422 As T3422_AREA, FACTORDERNO As String, FACTORDERSEQ As Double) As Boolean

        K3422_MOVE = False

        Try
            If READ_PFK3422(FACTORDERNO, FACTORDERSEQ) = True Then
                z3422 = D3422
                K3422_MOVE = True
            Else
                z3422 = Nothing
            End If

            If getColumnIndex(spr, "FactOrderNo") > -1 Then z3422.FactOrderNo = getDataM(spr, getColumnIndex(spr, "FactOrderNo"), xRow)
            If getColumnIndex(spr, "FactOrderSeq") > -1 Then z3422.FactOrderSeq = getDataM(spr, getColumnIndex(spr, "FactOrderSeq"), xRow)
            If getColumnIndex(spr, "DeclareNo") > -1 Then z3422.DeclareNo = getDataM(spr, getColumnIndex(spr, "DeclareNo"), xRow)
            If getColumnIndex(spr, "DateDeclare") > -1 Then z3422.DateDeclare = getDataM(spr, getColumnIndex(spr, "DateDeclare"), xRow)
            If getColumnIndex(spr, "InchargeDeclare") > -1 Then z3422.InchargeDeclare = getDataM(spr, getColumnIndex(spr, "InchargeDeclare"), xRow)
            If getColumnIndex(spr, "DeclareAmount") > -1 Then z3422.DeclareAmount = getDataM(spr, getColumnIndex(spr, "DeclareAmount"), xRow)
            If getColumnIndex(spr, "DeclareWgt") > -1 Then z3422.DeclareWgt = getDataM(spr, getColumnIndex(spr, "DeclareWgt"), xRow)
            If getColumnIndex(spr, "seSite") > -1 Then z3422.seSite = getDataM(spr, getColumnIndex(spr, "seSite"), xRow)
            If getColumnIndex(spr, "cdSite") > -1 Then z3422.cdSite = getDataM(spr, getColumnIndex(spr, "cdSite"), xRow)
            If getColumnIndex(spr, "seDepartment") > -1 Then z3422.seDepartment = getDataM(spr, getColumnIndex(spr, "seDepartment"), xRow)
            If getColumnIndex(spr, "cdDepartment") > -1 Then z3422.cdDepartment = getDataM(spr, getColumnIndex(spr, "cdDepartment"), xRow)
            If getColumnIndex(spr, "seFactory") > -1 Then z3422.seFactory = getDataM(spr, getColumnIndex(spr, "seFactory"), xRow)
            If getColumnIndex(spr, "cdFactory") > -1 Then z3422.cdFactory = getDataM(spr, getColumnIndex(spr, "cdFactory"), xRow)
            If getColumnIndex(spr, "seLineProd") > -1 Then z3422.seLineProd = getDataM(spr, getColumnIndex(spr, "seLineProd"), xRow)
            If getColumnIndex(spr, "cdLineProd") > -1 Then z3422.cdLineProd = getDataM(spr, getColumnIndex(spr, "cdLineProd"), xRow)
            If getColumnIndex(spr, "seSubProcess") > -1 Then z3422.seSubProcess = getDataM(spr, getColumnIndex(spr, "seSubProcess"), xRow)
            If getColumnIndex(spr, "cdSubProcess") > -1 Then z3422.cdSubProcess = getDataM(spr, getColumnIndex(spr, "cdSubProcess"), xRow)
            If getColumnIndex(spr, "seGroupComponent") > -1 Then z3422.seGroupComponent = getDataM(spr, getColumnIndex(spr, "seGroupComponent"), xRow)
            If getColumnIndex(spr, "cdGroupComponent") > -1 Then z3422.cdGroupComponent = getDataM(spr, getColumnIndex(spr, "cdGroupComponent"), xRow)
            If getColumnIndex(spr, "CustomerSupplier") > -1 Then z3422.CustomerSupplier = getDataM(spr, getColumnIndex(spr, "CustomerSupplier"), xRow)
            If getColumnIndex(spr, "Dseq") > -1 Then z3422.Dseq = getDataM(spr, getColumnIndex(spr, "Dseq"), xRow)
            If getColumnIndex(spr, "Pseq") > -1 Then z3422.Pseq = getDataM(spr, getColumnIndex(spr, "Pseq"), xRow)
            If getColumnIndex(spr, "AutokeyK3011") > -1 Then z3422.AutokeyK3011 = getDataM(spr, getColumnIndex(spr, "AutokeyK3011"), xRow)
            If getColumnIndex(spr, "CheckRelationType") > -1 Then z3422.CheckRelationType = getDataM(spr, getColumnIndex(spr, "CheckRelationType"), xRow)
            If getColumnIndex(spr, "ComponentName") > -1 Then z3422.ComponentName = getDataM(spr, getColumnIndex(spr, "ComponentName"), xRow)
            If getColumnIndex(spr, "MaterialCode") > -1 Then z3422.MaterialCode = getDataM(spr, getColumnIndex(spr, "MaterialCode"), xRow)
            If getColumnIndex(spr, "Specification") > -1 Then z3422.Specification = getDataM(spr, getColumnIndex(spr, "Specification"), xRow)
            If getColumnIndex(spr, "Width") > -1 Then z3422.Width = getDataM(spr, getColumnIndex(spr, "Width"), xRow)
            If getColumnIndex(spr, "Height") > -1 Then z3422.Height = getDataM(spr, getColumnIndex(spr, "Height"), xRow)
            If getColumnIndex(spr, "SizeNo") > -1 Then z3422.SizeNo = getDataM(spr, getColumnIndex(spr, "SizeNo"), xRow)
            If getColumnIndex(spr, "SizeName") > -1 Then z3422.SizeName = getDataM(spr, getColumnIndex(spr, "SizeName"), xRow)
            If getColumnIndex(spr, "ColorCode") > -1 Then z3422.ColorCode = getDataM(spr, getColumnIndex(spr, "ColorCode"), xRow)
            If getColumnIndex(spr, "ColorName") > -1 Then z3422.ColorName = getDataM(spr, getColumnIndex(spr, "ColorName"), xRow)
            If getColumnIndex(spr, "seOrigin") > -1 Then z3422.seOrigin = getDataM(spr, getColumnIndex(spr, "seOrigin"), xRow)
            If getColumnIndex(spr, "cdOrigin") > -1 Then z3422.cdOrigin = getDataM(spr, getColumnIndex(spr, "cdOrigin"), xRow)
            If getColumnIndex(spr, "MaterialCheck") > -1 Then z3422.MaterialCheck = getDataM(spr, getColumnIndex(spr, "MaterialCheck"), xRow)
            If getColumnIndex(spr, "seUnitPrice") > -1 Then z3422.seUnitPrice = getDataM(spr, getColumnIndex(spr, "seUnitPrice"), xRow)
            If getColumnIndex(spr, "cdUnitPrice") > -1 Then z3422.cdUnitPrice = getDataM(spr, getColumnIndex(spr, "cdUnitPrice"), xRow)
            If getColumnIndex(spr, "seTax") > -1 Then z3422.seTax = getDataM(spr, getColumnIndex(spr, "seTax"), xRow)
            If getColumnIndex(spr, "cdTax") > -1 Then z3422.cdTax = getDataM(spr, getColumnIndex(spr, "cdTax"), xRow)
            If getColumnIndex(spr, "seUnitMaterial") > -1 Then z3422.seUnitMaterial = getDataM(spr, getColumnIndex(spr, "seUnitMaterial"), xRow)
            If getColumnIndex(spr, "cdUnitMaterial") > -1 Then z3422.cdUnitMaterial = getDataM(spr, getColumnIndex(spr, "cdUnitMaterial"), xRow)
            If getColumnIndex(spr, "seUnitPacking") > -1 Then z3422.seUnitPacking = getDataM(spr, getColumnIndex(spr, "seUnitPacking"), xRow)
            If getColumnIndex(spr, "cdUnitPacking") > -1 Then z3422.cdUnitPacking = getDataM(spr, getColumnIndex(spr, "cdUnitPacking"), xRow)
            If getColumnIndex(spr, "UnitBaseCheck") > -1 Then z3422.UnitBaseCheck = getDataM(spr, getColumnIndex(spr, "UnitBaseCheck"), xRow)
            If getColumnIndex(spr, "QtyBasic") > -1 Then z3422.QtyBasic = getDataM(spr, getColumnIndex(spr, "QtyBasic"), xRow)
            If getColumnIndex(spr, "PricePurchasing") > -1 Then z3422.PricePurchasing = getDataM(spr, getColumnIndex(spr, "PricePurchasing"), xRow)
            If getColumnIndex(spr, "PriceMarket") > -1 Then z3422.PriceMarket = getDataM(spr, getColumnIndex(spr, "PriceMarket"), xRow)
            If getColumnIndex(spr, "PriceExchange") > -1 Then z3422.PriceExchange = getDataM(spr, getColumnIndex(spr, "PriceExchange"), xRow)
            If getColumnIndex(spr, "PriceExchangeAP") > -1 Then z3422.PriceExchangeAP = getDataM(spr, getColumnIndex(spr, "PriceExchangeAP"), xRow)
            If getColumnIndex(spr, "DateExchange") > -1 Then z3422.DateExchange = getDataM(spr, getColumnIndex(spr, "DateExchange"), xRow)
            If getColumnIndex(spr, "PricePurchasingEX") > -1 Then z3422.PricePurchasingEX = getDataM(spr, getColumnIndex(spr, "PricePurchasingEX"), xRow)
            If getColumnIndex(spr, "PriceMarketEX") > -1 Then z3422.PriceMarketEX = getDataM(spr, getColumnIndex(spr, "PriceMarketEX"), xRow)
            If getColumnIndex(spr, "PricePurchasingVND") > -1 Then z3422.PricePurchasingVND = getDataM(spr, getColumnIndex(spr, "PricePurchasingVND"), xRow)
            If getColumnIndex(spr, "PriceMarketVND") > -1 Then z3422.PriceMarketVND = getDataM(spr, getColumnIndex(spr, "PriceMarketVND"), xRow)
            If getColumnIndex(spr, "AmountPurchasingEX") > -1 Then z3422.AmountPurchasingEX = getDataM(spr, getColumnIndex(spr, "AmountPurchasingEX"), xRow)
            If getColumnIndex(spr, "AmountPurchasingVND") > -1 Then z3422.AmountPurchasingVND = getDataM(spr, getColumnIndex(spr, "AmountPurchasingVND"), xRow)
            If getColumnIndex(spr, "AmountTaxEX") > -1 Then z3422.AmountTaxEX = getDataM(spr, getColumnIndex(spr, "AmountTaxEX"), xRow)
            If getColumnIndex(spr, "AmountTaxVND") > -1 Then z3422.AmountTaxVND = getDataM(spr, getColumnIndex(spr, "AmountTaxVND"), xRow)
            If getColumnIndex(spr, "seTax1") > -1 Then z3422.seTax1 = getDataM(spr, getColumnIndex(spr, "seTax1"), xRow)
            If getColumnIndex(spr, "cdTax1") > -1 Then z3422.cdTax1 = getDataM(spr, getColumnIndex(spr, "cdTax1"), xRow)
            If getColumnIndex(spr, "PerTax1") > -1 Then z3422.PerTax1 = getDataM(spr, getColumnIndex(spr, "PerTax1"), xRow)
            If getColumnIndex(spr, "AmountTax1") > -1 Then z3422.AmountTax1 = getDataM(spr, getColumnIndex(spr, "AmountTax1"), xRow)
            If getColumnIndex(spr, "seTax2") > -1 Then z3422.seTax2 = getDataM(spr, getColumnIndex(spr, "seTax2"), xRow)
            If getColumnIndex(spr, "cdTax2") > -1 Then z3422.cdTax2 = getDataM(spr, getColumnIndex(spr, "cdTax2"), xRow)
            If getColumnIndex(spr, "PerTax2") > -1 Then z3422.PerTax2 = getDataM(spr, getColumnIndex(spr, "PerTax2"), xRow)
            If getColumnIndex(spr, "AmountTax2") > -1 Then z3422.AmountTax2 = getDataM(spr, getColumnIndex(spr, "AmountTax2"), xRow)
            If getColumnIndex(spr, "seTax3") > -1 Then z3422.seTax3 = getDataM(spr, getColumnIndex(spr, "seTax3"), xRow)
            If getColumnIndex(spr, "cdTax3") > -1 Then z3422.cdTax3 = getDataM(spr, getColumnIndex(spr, "cdTax3"), xRow)
            If getColumnIndex(spr, "PerTax3") > -1 Then z3422.PerTax3 = getDataM(spr, getColumnIndex(spr, "PerTax3"), xRow)
            If getColumnIndex(spr, "AmountTax3") > -1 Then z3422.AmountTax3 = getDataM(spr, getColumnIndex(spr, "AmountTax3"), xRow)
            If getColumnIndex(spr, "QtyRequestPO") > -1 Then z3422.QtyRequestPO = getDataM(spr, getColumnIndex(spr, "QtyRequestPO"), xRow)
            If getColumnIndex(spr, "QtyPurchasing") > -1 Then z3422.QtyPurchasing = getDataM(spr, getColumnIndex(spr, "QtyPurchasing"), xRow)
            If getColumnIndex(spr, "PackPurchasing") > -1 Then z3422.PackPurchasing = getDataM(spr, getColumnIndex(spr, "PackPurchasing"), xRow)
            If getColumnIndex(spr, "QtyWarehouse") > -1 Then z3422.QtyWarehouse = getDataM(spr, getColumnIndex(spr, "QtyWarehouse"), xRow)
            If getColumnIndex(spr, "PackWarehouse") > -1 Then z3422.PackWarehouse = getDataM(spr, getColumnIndex(spr, "PackWarehouse"), xRow)
            If getColumnIndex(spr, "QtyInbound") > -1 Then z3422.QtyInbound = getDataM(spr, getColumnIndex(spr, "QtyInbound"), xRow)
            If getColumnIndex(spr, "PackInbound") > -1 Then z3422.PackInbound = getDataM(spr, getColumnIndex(spr, "PackInbound"), xRow)
            If getColumnIndex(spr, "QtyOutbound") > -1 Then z3422.QtyOutbound = getDataM(spr, getColumnIndex(spr, "QtyOutbound"), xRow)
            If getColumnIndex(spr, "PackOutbound") > -1 Then z3422.PackOutbound = getDataM(spr, getColumnIndex(spr, "PackOutbound"), xRow)
            If getColumnIndex(spr, "AmountEX") > -1 Then z3422.AmountEX = getDataM(spr, getColumnIndex(spr, "AmountEX"), xRow)
            If getColumnIndex(spr, "AmountVND") > -1 Then z3422.AmountVND = getDataM(spr, getColumnIndex(spr, "AmountVND"), xRow)
            If getColumnIndex(spr, "AmountInBoundEX") > -1 Then z3422.AmountInBoundEX = getDataM(spr, getColumnIndex(spr, "AmountInBoundEX"), xRow)
            If getColumnIndex(spr, "AmountInBoundVND") > -1 Then z3422.AmountInBoundVND = getDataM(spr, getColumnIndex(spr, "AmountInBoundVND"), xRow)
            If getColumnIndex(spr, "DateDelivery") > -1 Then z3422.DateDelivery = getDataM(spr, getColumnIndex(spr, "DateDelivery"), xRow)
            If getColumnIndex(spr, "DateStart") > -1 Then z3422.DateStart = getDataM(spr, getColumnIndex(spr, "DateStart"), xRow)
            If getColumnIndex(spr, "DateFinish") > -1 Then z3422.DateFinish = getDataM(spr, getColumnIndex(spr, "DateFinish"), xRow)
            If getColumnIndex(spr, "CheckPurchasing") > -1 Then z3422.CheckPurchasing = getDataM(spr, getColumnIndex(spr, "CheckPurchasing"), xRow)
            If getColumnIndex(spr, "DateAccept") > -1 Then z3422.DateAccept = getDataM(spr, getColumnIndex(spr, "DateAccept"), xRow)
            If getColumnIndex(spr, "DatePosted") > -1 Then z3422.DatePosted = getDataM(spr, getColumnIndex(spr, "DatePosted"), xRow)
            If getColumnIndex(spr, "IsPosted") > -1 Then z3422.IsPosted = getDataM(spr, getColumnIndex(spr, "IsPosted"), xRow)
            If getColumnIndex(spr, "DateComplete") > -1 Then z3422.DateComplete = getDataM(spr, getColumnIndex(spr, "DateComplete"), xRow)
            If getColumnIndex(spr, "DateApproval") > -1 Then z3422.DateApproval = getDataM(spr, getColumnIndex(spr, "DateApproval"), xRow)
            If getColumnIndex(spr, "DateCancel") > -1 Then z3422.DateCancel = getDataM(spr, getColumnIndex(spr, "DateCancel"), xRow)
            If getColumnIndex(spr, "CheckComplete") > -1 Then z3422.CheckComplete = getDataM(spr, getColumnIndex(spr, "CheckComplete"), xRow)
            If getColumnIndex(spr, "PurchasingOrderNo") > -1 Then z3422.PurchasingOrderNo = getDataM(spr, getColumnIndex(spr, "PurchasingOrderNo"), xRow)
            If getColumnIndex(spr, "PurchasingOrderSeq") > -1 Then z3422.PurchasingOrderSeq = getDataM(spr, getColumnIndex(spr, "PurchasingOrderSeq"), xRow)
            If getColumnIndex(spr, "JobCardWorking") > -1 Then z3422.JobCardWorking = getDataM(spr, getColumnIndex(spr, "JobCardWorking"), xRow)
            If getColumnIndex(spr, "JobCardWorkingSeq") > -1 Then z3422.JobCardWorkingSeq = getDataM(spr, getColumnIndex(spr, "JobCardWorkingSeq"), xRow)
            If getColumnIndex(spr, "JobCardType") > -1 Then z3422.JobCardType = getDataM(spr, getColumnIndex(spr, "JobCardType"), xRow)
            If getColumnIndex(spr, "SalesOrderNo") > -1 Then z3422.SalesOrderNo = getDataM(spr, getColumnIndex(spr, "SalesOrderNo"), xRow)
            If getColumnIndex(spr, "SalesOrderSeq") > -1 Then z3422.SalesOrderSeq = getDataM(spr, getColumnIndex(spr, "SalesOrderSeq"), xRow)
            If getColumnIndex(spr, "SalesOrderSno") > -1 Then z3422.SalesOrderSno = getDataM(spr, getColumnIndex(spr, "SalesOrderSno"), xRow)
            If getColumnIndex(spr, "CheckOrderType") > -1 Then z3422.CheckOrderType = getDataM(spr, getColumnIndex(spr, "CheckOrderType"), xRow)
            If getColumnIndex(spr, "OrderNo") > -1 Then z3422.OrderNo = getDataM(spr, getColumnIndex(spr, "OrderNo"), xRow)
            If getColumnIndex(spr, "OrderNoSeq") > -1 Then z3422.OrderNoSeq = getDataM(spr, getColumnIndex(spr, "OrderNoSeq"), xRow)
            If getColumnIndex(spr, "JobCard") > -1 Then z3422.JobCard = getDataM(spr, getColumnIndex(spr, "JobCard"), xRow)
            If getColumnIndex(spr, "DateSync") > -1 Then z3422.DateSync = getDataM(spr, getColumnIndex(spr, "DateSync"), xRow)
            If getColumnIndex(spr, "CheckSync") > -1 Then z3422.CheckSync = getDataM(spr, getColumnIndex(spr, "CheckSync"), xRow)
            If getColumnIndex(spr, "SlNo") > -1 Then z3422.SlNo = getDataM(spr, getColumnIndex(spr, "SlNo"), xRow)
            If getColumnIndex(spr, "Check_Spec_1") > -1 Then z3422.Check_Spec_1 = getDataM(spr, getColumnIndex(spr, "Check_Spec_1"), xRow)
            If getColumnIndex(spr, "Check_Spec_2") > -1 Then z3422.Check_Spec_2 = getDataM(spr, getColumnIndex(spr, "Check_Spec_2"), xRow)
            If getColumnIndex(spr, "Check_Spec_3") > -1 Then z3422.Check_Spec_3 = getDataM(spr, getColumnIndex(spr, "Check_Spec_3"), xRow)
            If getColumnIndex(spr, "Check_Spec_4") > -1 Then z3422.Check_Spec_4 = getDataM(spr, getColumnIndex(spr, "Check_Spec_4"), xRow)
            If getColumnIndex(spr, "Check_Spec_5") > -1 Then z3422.Check_Spec_5 = getDataM(spr, getColumnIndex(spr, "Check_Spec_5"), xRow)
            If getColumnIndex(spr, "Check_Spec_6") > -1 Then z3422.Check_Spec_6 = getDataM(spr, getColumnIndex(spr, "Check_Spec_6"), xRow)
            If getColumnIndex(spr, "Check_Spec_7") > -1 Then z3422.Check_Spec_7 = getDataM(spr, getColumnIndex(spr, "Check_Spec_7"), xRow)
            If getColumnIndex(spr, "Check_Spec_8") > -1 Then z3422.Check_Spec_8 = getDataM(spr, getColumnIndex(spr, "Check_Spec_8"), xRow)
            If getColumnIndex(spr, "Check_Spec_9") > -1 Then z3422.Check_Spec_9 = getDataM(spr, getColumnIndex(spr, "Check_Spec_9"), xRow)
            If getColumnIndex(spr, "Remark") > -1 Then z3422.Remark = getDataM(spr, getColumnIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K3422_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K3422_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z3422 As T3422_AREA, CheckClear As Boolean, FACTORDERNO As String, FACTORDERSEQ As Double) As Boolean

        K3422_MOVE = False

        Try
            If READ_PFK3422(FACTORDERNO, FACTORDERSEQ) = True Then
                z3422 = D3422
                K3422_MOVE = True
            Else
                If CheckClear = True Then z3422 = Nothing
            End If

            If getColumnIndex(spr, "FactOrderNo") > -1 Then z3422.FactOrderNo = getDataM(spr, getColumnIndex(spr, "FactOrderNo"), xRow)
            If getColumnIndex(spr, "FactOrderSeq") > -1 Then z3422.FactOrderSeq = getDataM(spr, getColumnIndex(spr, "FactOrderSeq"), xRow)
            If getColumnIndex(spr, "DeclareNo") > -1 Then z3422.DeclareNo = getDataM(spr, getColumnIndex(spr, "DeclareNo"), xRow)
            If getColumnIndex(spr, "DateDeclare") > -1 Then z3422.DateDeclare = getDataM(spr, getColumnIndex(spr, "DateDeclare"), xRow)
            If getColumnIndex(spr, "InchargeDeclare") > -1 Then z3422.InchargeDeclare = getDataM(spr, getColumnIndex(spr, "InchargeDeclare"), xRow)
            If getColumnIndex(spr, "DeclareAmount") > -1 Then z3422.DeclareAmount = getDataM(spr, getColumnIndex(spr, "DeclareAmount"), xRow)
            If getColumnIndex(spr, "DeclareWgt") > -1 Then z3422.DeclareWgt = getDataM(spr, getColumnIndex(spr, "DeclareWgt"), xRow)
            If getColumnIndex(spr, "seSite") > -1 Then z3422.seSite = getDataM(spr, getColumnIndex(spr, "seSite"), xRow)
            If getColumnIndex(spr, "cdSite") > -1 Then z3422.cdSite = getDataM(spr, getColumnIndex(spr, "cdSite"), xRow)
            If getColumnIndex(spr, "seDepartment") > -1 Then z3422.seDepartment = getDataM(spr, getColumnIndex(spr, "seDepartment"), xRow)
            If getColumnIndex(spr, "cdDepartment") > -1 Then z3422.cdDepartment = getDataM(spr, getColumnIndex(spr, "cdDepartment"), xRow)
            If getColumnIndex(spr, "seFactory") > -1 Then z3422.seFactory = getDataM(spr, getColumnIndex(spr, "seFactory"), xRow)
            If getColumnIndex(spr, "cdFactory") > -1 Then z3422.cdFactory = getDataM(spr, getColumnIndex(spr, "cdFactory"), xRow)
            If getColumnIndex(spr, "seLineProd") > -1 Then z3422.seLineProd = getDataM(spr, getColumnIndex(spr, "seLineProd"), xRow)
            If getColumnIndex(spr, "cdLineProd") > -1 Then z3422.cdLineProd = getDataM(spr, getColumnIndex(spr, "cdLineProd"), xRow)
            If getColumnIndex(spr, "seSubProcess") > -1 Then z3422.seSubProcess = getDataM(spr, getColumnIndex(spr, "seSubProcess"), xRow)
            If getColumnIndex(spr, "cdSubProcess") > -1 Then z3422.cdSubProcess = getDataM(spr, getColumnIndex(spr, "cdSubProcess"), xRow)
            If getColumnIndex(spr, "seGroupComponent") > -1 Then z3422.seGroupComponent = getDataM(spr, getColumnIndex(spr, "seGroupComponent"), xRow)
            If getColumnIndex(spr, "cdGroupComponent") > -1 Then z3422.cdGroupComponent = getDataM(spr, getColumnIndex(spr, "cdGroupComponent"), xRow)
            If getColumnIndex(spr, "CustomerSupplier") > -1 Then z3422.CustomerSupplier = getDataM(spr, getColumnIndex(spr, "CustomerSupplier"), xRow)
            If getColumnIndex(spr, "Dseq") > -1 Then z3422.Dseq = getDataM(spr, getColumnIndex(spr, "Dseq"), xRow)
            If getColumnIndex(spr, "Pseq") > -1 Then z3422.Pseq = getDataM(spr, getColumnIndex(spr, "Pseq"), xRow)
            If getColumnIndex(spr, "AutokeyK3011") > -1 Then z3422.AutokeyK3011 = getDataM(spr, getColumnIndex(spr, "AutokeyK3011"), xRow)
            If getColumnIndex(spr, "CheckRelationType") > -1 Then z3422.CheckRelationType = getDataM(spr, getColumnIndex(spr, "CheckRelationType"), xRow)
            If getColumnIndex(spr, "ComponentName") > -1 Then z3422.ComponentName = getDataM(spr, getColumnIndex(spr, "ComponentName"), xRow)
            If getColumnIndex(spr, "MaterialCode") > -1 Then z3422.MaterialCode = getDataM(spr, getColumnIndex(spr, "MaterialCode"), xRow)
            If getColumnIndex(spr, "Specification") > -1 Then z3422.Specification = getDataM(spr, getColumnIndex(spr, "Specification"), xRow)
            If getColumnIndex(spr, "Width") > -1 Then z3422.Width = getDataM(spr, getColumnIndex(spr, "Width"), xRow)
            If getColumnIndex(spr, "Height") > -1 Then z3422.Height = getDataM(spr, getColumnIndex(spr, "Height"), xRow)
            If getColumnIndex(spr, "SizeNo") > -1 Then z3422.SizeNo = getDataM(spr, getColumnIndex(spr, "SizeNo"), xRow)
            If getColumnIndex(spr, "SizeName") > -1 Then z3422.SizeName = getDataM(spr, getColumnIndex(spr, "SizeName"), xRow)
            If getColumnIndex(spr, "ColorCode") > -1 Then z3422.ColorCode = getDataM(spr, getColumnIndex(spr, "ColorCode"), xRow)
            If getColumnIndex(spr, "ColorName") > -1 Then z3422.ColorName = getDataM(spr, getColumnIndex(spr, "ColorName"), xRow)
            If getColumnIndex(spr, "seOrigin") > -1 Then z3422.seOrigin = getDataM(spr, getColumnIndex(spr, "seOrigin"), xRow)
            If getColumnIndex(spr, "cdOrigin") > -1 Then z3422.cdOrigin = getDataM(spr, getColumnIndex(spr, "cdOrigin"), xRow)
            If getColumnIndex(spr, "MaterialCheck") > -1 Then z3422.MaterialCheck = getDataM(spr, getColumnIndex(spr, "MaterialCheck"), xRow)
            If getColumnIndex(spr, "seUnitPrice") > -1 Then z3422.seUnitPrice = getDataM(spr, getColumnIndex(spr, "seUnitPrice"), xRow)
            If getColumnIndex(spr, "cdUnitPrice") > -1 Then z3422.cdUnitPrice = getDataM(spr, getColumnIndex(spr, "cdUnitPrice"), xRow)
            If getColumnIndex(spr, "seTax") > -1 Then z3422.seTax = getDataM(spr, getColumnIndex(spr, "seTax"), xRow)
            If getColumnIndex(spr, "cdTax") > -1 Then z3422.cdTax = getDataM(spr, getColumnIndex(spr, "cdTax"), xRow)
            If getColumnIndex(spr, "seUnitMaterial") > -1 Then z3422.seUnitMaterial = getDataM(spr, getColumnIndex(spr, "seUnitMaterial"), xRow)
            If getColumnIndex(spr, "cdUnitMaterial") > -1 Then z3422.cdUnitMaterial = getDataM(spr, getColumnIndex(spr, "cdUnitMaterial"), xRow)
            If getColumnIndex(spr, "seUnitPacking") > -1 Then z3422.seUnitPacking = getDataM(spr, getColumnIndex(spr, "seUnitPacking"), xRow)
            If getColumnIndex(spr, "cdUnitPacking") > -1 Then z3422.cdUnitPacking = getDataM(spr, getColumnIndex(spr, "cdUnitPacking"), xRow)
            If getColumnIndex(spr, "UnitBaseCheck") > -1 Then z3422.UnitBaseCheck = getDataM(spr, getColumnIndex(spr, "UnitBaseCheck"), xRow)
            If getColumnIndex(spr, "QtyBasic") > -1 Then z3422.QtyBasic = getDataM(spr, getColumnIndex(spr, "QtyBasic"), xRow)
            If getColumnIndex(spr, "PricePurchasing") > -1 Then z3422.PricePurchasing = getDataM(spr, getColumnIndex(spr, "PricePurchasing"), xRow)
            If getColumnIndex(spr, "PriceMarket") > -1 Then z3422.PriceMarket = getDataM(spr, getColumnIndex(spr, "PriceMarket"), xRow)
            If getColumnIndex(spr, "PriceExchange") > -1 Then z3422.PriceExchange = getDataM(spr, getColumnIndex(spr, "PriceExchange"), xRow)
            If getColumnIndex(spr, "PriceExchangeAP") > -1 Then z3422.PriceExchangeAP = getDataM(spr, getColumnIndex(spr, "PriceExchangeAP"), xRow)
            If getColumnIndex(spr, "DateExchange") > -1 Then z3422.DateExchange = getDataM(spr, getColumnIndex(spr, "DateExchange"), xRow)
            If getColumnIndex(spr, "PricePurchasingEX") > -1 Then z3422.PricePurchasingEX = getDataM(spr, getColumnIndex(spr, "PricePurchasingEX"), xRow)
            If getColumnIndex(spr, "PriceMarketEX") > -1 Then z3422.PriceMarketEX = getDataM(spr, getColumnIndex(spr, "PriceMarketEX"), xRow)
            If getColumnIndex(spr, "PricePurchasingVND") > -1 Then z3422.PricePurchasingVND = getDataM(spr, getColumnIndex(spr, "PricePurchasingVND"), xRow)
            If getColumnIndex(spr, "PriceMarketVND") > -1 Then z3422.PriceMarketVND = getDataM(spr, getColumnIndex(spr, "PriceMarketVND"), xRow)
            If getColumnIndex(spr, "AmountPurchasingEX") > -1 Then z3422.AmountPurchasingEX = getDataM(spr, getColumnIndex(spr, "AmountPurchasingEX"), xRow)
            If getColumnIndex(spr, "AmountPurchasingVND") > -1 Then z3422.AmountPurchasingVND = getDataM(spr, getColumnIndex(spr, "AmountPurchasingVND"), xRow)
            If getColumnIndex(spr, "AmountTaxEX") > -1 Then z3422.AmountTaxEX = getDataM(spr, getColumnIndex(spr, "AmountTaxEX"), xRow)
            If getColumnIndex(spr, "AmountTaxVND") > -1 Then z3422.AmountTaxVND = getDataM(spr, getColumnIndex(spr, "AmountTaxVND"), xRow)
            If getColumnIndex(spr, "seTax1") > -1 Then z3422.seTax1 = getDataM(spr, getColumnIndex(spr, "seTax1"), xRow)
            If getColumnIndex(spr, "cdTax1") > -1 Then z3422.cdTax1 = getDataM(spr, getColumnIndex(spr, "cdTax1"), xRow)
            If getColumnIndex(spr, "PerTax1") > -1 Then z3422.PerTax1 = getDataM(spr, getColumnIndex(spr, "PerTax1"), xRow)
            If getColumnIndex(spr, "AmountTax1") > -1 Then z3422.AmountTax1 = getDataM(spr, getColumnIndex(spr, "AmountTax1"), xRow)
            If getColumnIndex(spr, "seTax2") > -1 Then z3422.seTax2 = getDataM(spr, getColumnIndex(spr, "seTax2"), xRow)
            If getColumnIndex(spr, "cdTax2") > -1 Then z3422.cdTax2 = getDataM(spr, getColumnIndex(spr, "cdTax2"), xRow)
            If getColumnIndex(spr, "PerTax2") > -1 Then z3422.PerTax2 = getDataM(spr, getColumnIndex(spr, "PerTax2"), xRow)
            If getColumnIndex(spr, "AmountTax2") > -1 Then z3422.AmountTax2 = getDataM(spr, getColumnIndex(spr, "AmountTax2"), xRow)
            If getColumnIndex(spr, "seTax3") > -1 Then z3422.seTax3 = getDataM(spr, getColumnIndex(spr, "seTax3"), xRow)
            If getColumnIndex(spr, "cdTax3") > -1 Then z3422.cdTax3 = getDataM(spr, getColumnIndex(spr, "cdTax3"), xRow)
            If getColumnIndex(spr, "PerTax3") > -1 Then z3422.PerTax3 = getDataM(spr, getColumnIndex(spr, "PerTax3"), xRow)
            If getColumnIndex(spr, "AmountTax3") > -1 Then z3422.AmountTax3 = getDataM(spr, getColumnIndex(spr, "AmountTax3"), xRow)
            If getColumnIndex(spr, "QtyRequestPO") > -1 Then z3422.QtyRequestPO = getDataM(spr, getColumnIndex(spr, "QtyRequestPO"), xRow)
            If getColumnIndex(spr, "QtyPurchasing") > -1 Then z3422.QtyPurchasing = getDataM(spr, getColumnIndex(spr, "QtyPurchasing"), xRow)
            If getColumnIndex(spr, "PackPurchasing") > -1 Then z3422.PackPurchasing = getDataM(spr, getColumnIndex(spr, "PackPurchasing"), xRow)
            If getColumnIndex(spr, "QtyWarehouse") > -1 Then z3422.QtyWarehouse = getDataM(spr, getColumnIndex(spr, "QtyWarehouse"), xRow)
            If getColumnIndex(spr, "PackWarehouse") > -1 Then z3422.PackWarehouse = getDataM(spr, getColumnIndex(spr, "PackWarehouse"), xRow)
            If getColumnIndex(spr, "QtyInbound") > -1 Then z3422.QtyInbound = getDataM(spr, getColumnIndex(spr, "QtyInbound"), xRow)
            If getColumnIndex(spr, "PackInbound") > -1 Then z3422.PackInbound = getDataM(spr, getColumnIndex(spr, "PackInbound"), xRow)
            If getColumnIndex(spr, "QtyOutbound") > -1 Then z3422.QtyOutbound = getDataM(spr, getColumnIndex(spr, "QtyOutbound"), xRow)
            If getColumnIndex(spr, "PackOutbound") > -1 Then z3422.PackOutbound = getDataM(spr, getColumnIndex(spr, "PackOutbound"), xRow)
            If getColumnIndex(spr, "AmountEX") > -1 Then z3422.AmountEX = getDataM(spr, getColumnIndex(spr, "AmountEX"), xRow)
            If getColumnIndex(spr, "AmountVND") > -1 Then z3422.AmountVND = getDataM(spr, getColumnIndex(spr, "AmountVND"), xRow)
            If getColumnIndex(spr, "AmountInBoundEX") > -1 Then z3422.AmountInBoundEX = getDataM(spr, getColumnIndex(spr, "AmountInBoundEX"), xRow)
            If getColumnIndex(spr, "AmountInBoundVND") > -1 Then z3422.AmountInBoundVND = getDataM(spr, getColumnIndex(spr, "AmountInBoundVND"), xRow)
            If getColumnIndex(spr, "DateDelivery") > -1 Then z3422.DateDelivery = getDataM(spr, getColumnIndex(spr, "DateDelivery"), xRow)
            If getColumnIndex(spr, "DateStart") > -1 Then z3422.DateStart = getDataM(spr, getColumnIndex(spr, "DateStart"), xRow)
            If getColumnIndex(spr, "DateFinish") > -1 Then z3422.DateFinish = getDataM(spr, getColumnIndex(spr, "DateFinish"), xRow)
            If getColumnIndex(spr, "CheckPurchasing") > -1 Then z3422.CheckPurchasing = getDataM(spr, getColumnIndex(spr, "CheckPurchasing"), xRow)
            If getColumnIndex(spr, "DateAccept") > -1 Then z3422.DateAccept = getDataM(spr, getColumnIndex(spr, "DateAccept"), xRow)
            If getColumnIndex(spr, "DatePosted") > -1 Then z3422.DatePosted = getDataM(spr, getColumnIndex(spr, "DatePosted"), xRow)
            If getColumnIndex(spr, "IsPosted") > -1 Then z3422.IsPosted = getDataM(spr, getColumnIndex(spr, "IsPosted"), xRow)
            If getColumnIndex(spr, "DateComplete") > -1 Then z3422.DateComplete = getDataM(spr, getColumnIndex(spr, "DateComplete"), xRow)
            If getColumnIndex(spr, "DateApproval") > -1 Then z3422.DateApproval = getDataM(spr, getColumnIndex(spr, "DateApproval"), xRow)
            If getColumnIndex(spr, "DateCancel") > -1 Then z3422.DateCancel = getDataM(spr, getColumnIndex(spr, "DateCancel"), xRow)
            If getColumnIndex(spr, "CheckComplete") > -1 Then z3422.CheckComplete = getDataM(spr, getColumnIndex(spr, "CheckComplete"), xRow)
            If getColumnIndex(spr, "PurchasingOrderNo") > -1 Then z3422.PurchasingOrderNo = getDataM(spr, getColumnIndex(spr, "PurchasingOrderNo"), xRow)
            If getColumnIndex(spr, "PurchasingOrderSeq") > -1 Then z3422.PurchasingOrderSeq = getDataM(spr, getColumnIndex(spr, "PurchasingOrderSeq"), xRow)
            If getColumnIndex(spr, "JobCardWorking") > -1 Then z3422.JobCardWorking = getDataM(spr, getColumnIndex(spr, "JobCardWorking"), xRow)
            If getColumnIndex(spr, "JobCardWorkingSeq") > -1 Then z3422.JobCardWorkingSeq = getDataM(spr, getColumnIndex(spr, "JobCardWorkingSeq"), xRow)
            If getColumnIndex(spr, "JobCardType") > -1 Then z3422.JobCardType = getDataM(spr, getColumnIndex(spr, "JobCardType"), xRow)
            If getColumnIndex(spr, "SalesOrderNo") > -1 Then z3422.SalesOrderNo = getDataM(spr, getColumnIndex(spr, "SalesOrderNo"), xRow)
            If getColumnIndex(spr, "SalesOrderSeq") > -1 Then z3422.SalesOrderSeq = getDataM(spr, getColumnIndex(spr, "SalesOrderSeq"), xRow)
            If getColumnIndex(spr, "SalesOrderSno") > -1 Then z3422.SalesOrderSno = getDataM(spr, getColumnIndex(spr, "SalesOrderSno"), xRow)
            If getColumnIndex(spr, "CheckOrderType") > -1 Then z3422.CheckOrderType = getDataM(spr, getColumnIndex(spr, "CheckOrderType"), xRow)
            If getColumnIndex(spr, "OrderNo") > -1 Then z3422.OrderNo = getDataM(spr, getColumnIndex(spr, "OrderNo"), xRow)
            If getColumnIndex(spr, "OrderNoSeq") > -1 Then z3422.OrderNoSeq = getDataM(spr, getColumnIndex(spr, "OrderNoSeq"), xRow)
            If getColumnIndex(spr, "JobCard") > -1 Then z3422.JobCard = getDataM(spr, getColumnIndex(spr, "JobCard"), xRow)
            If getColumnIndex(spr, "DateSync") > -1 Then z3422.DateSync = getDataM(spr, getColumnIndex(spr, "DateSync"), xRow)
            If getColumnIndex(spr, "CheckSync") > -1 Then z3422.CheckSync = getDataM(spr, getColumnIndex(spr, "CheckSync"), xRow)
            If getColumnIndex(spr, "SlNo") > -1 Then z3422.SlNo = getDataM(spr, getColumnIndex(spr, "SlNo"), xRow)
            If getColumnIndex(spr, "Check_Spec_1") > -1 Then z3422.Check_Spec_1 = getDataM(spr, getColumnIndex(spr, "Check_Spec_1"), xRow)
            If getColumnIndex(spr, "Check_Spec_2") > -1 Then z3422.Check_Spec_2 = getDataM(spr, getColumnIndex(spr, "Check_Spec_2"), xRow)
            If getColumnIndex(spr, "Check_Spec_3") > -1 Then z3422.Check_Spec_3 = getDataM(spr, getColumnIndex(spr, "Check_Spec_3"), xRow)
            If getColumnIndex(spr, "Check_Spec_4") > -1 Then z3422.Check_Spec_4 = getDataM(spr, getColumnIndex(spr, "Check_Spec_4"), xRow)
            If getColumnIndex(spr, "Check_Spec_5") > -1 Then z3422.Check_Spec_5 = getDataM(spr, getColumnIndex(spr, "Check_Spec_5"), xRow)
            If getColumnIndex(spr, "Check_Spec_6") > -1 Then z3422.Check_Spec_6 = getDataM(spr, getColumnIndex(spr, "Check_Spec_6"), xRow)
            If getColumnIndex(spr, "Check_Spec_7") > -1 Then z3422.Check_Spec_7 = getDataM(spr, getColumnIndex(spr, "Check_Spec_7"), xRow)
            If getColumnIndex(spr, "Check_Spec_8") > -1 Then z3422.Check_Spec_8 = getDataM(spr, getColumnIndex(spr, "Check_Spec_8"), xRow)
            If getColumnIndex(spr, "Check_Spec_9") > -1 Then z3422.Check_Spec_9 = getDataM(spr, getColumnIndex(spr, "Check_Spec_9"), xRow)
            If getColumnIndex(spr, "Remark") > -1 Then z3422.Remark = getDataM(spr, getColumnIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K3422_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K3422_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z3422 As T3422_AREA, Job As String, FACTORDERNO As String, FACTORDERSEQ As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K3422_MOVE = False

        Try
            If READ_PFK3422(FACTORDERNO, FACTORDERSEQ) = True Then
                z3422 = D3422
                K3422_MOVE = True
            Else
                z3422 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3422")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "FACTORDERNO" : z3422.FactOrderNo = Children(i).Code
                                Case "FACTORDERSEQ" : z3422.FactOrderSeq = Children(i).Code
                                Case "DECLARENO" : z3422.DeclareNo = Children(i).Code
                                Case "DATEDECLARE" : z3422.DateDeclare = Children(i).Code
                                Case "INCHARGEDECLARE" : z3422.InchargeDeclare = Children(i).Code
                                Case "DECLAREAMOUNT" : z3422.DeclareAmount = Children(i).Code
                                Case "DECLAREWGT" : z3422.DeclareWgt = Children(i).Code
                                Case "SESITE" : z3422.seSite = Children(i).Code
                                Case "CDSITE" : z3422.cdSite = Children(i).Code
                                Case "SEDEPARTMENT" : z3422.seDepartment = Children(i).Code
                                Case "CDDEPARTMENT" : z3422.cdDepartment = Children(i).Code
                                Case "SEFACTORY" : z3422.seFactory = Children(i).Code
                                Case "CDFACTORY" : z3422.cdFactory = Children(i).Code
                                Case "SELINEPROD" : z3422.seLineProd = Children(i).Code
                                Case "CDLINEPROD" : z3422.cdLineProd = Children(i).Code
                                Case "SESUBPROCESS" : z3422.seSubProcess = Children(i).Code
                                Case "CDSUBPROCESS" : z3422.cdSubProcess = Children(i).Code
                                Case "SEGROUPCOMPONENT" : z3422.seGroupComponent = Children(i).Code
                                Case "CDGROUPCOMPONENT" : z3422.cdGroupComponent = Children(i).Code
                                Case "CUSTOMERSUPPLIER" : z3422.CustomerSupplier = Children(i).Code
                                Case "DSEQ" : z3422.Dseq = Children(i).Code
                                Case "PSEQ" : z3422.Pseq = Children(i).Code
                                Case "AUTOKEYK3011" : z3422.AutokeyK3011 = Children(i).Code
                                Case "CHECKRELATIONTYPE" : z3422.CheckRelationType = Children(i).Code
                                Case "COMPONENTNAME" : z3422.ComponentName = Children(i).Code
                                Case "MATERIALCODE" : z3422.MaterialCode = Children(i).Code
                                Case "SPECIFICATION" : z3422.Specification = Children(i).Code
                                Case "WIDTH" : z3422.Width = Children(i).Code
                                Case "HEIGHT" : z3422.Height = Children(i).Code
                                Case "SIZENO" : z3422.SizeNo = Children(i).Code
                                Case "SIZENAME" : z3422.SizeName = Children(i).Code
                                Case "COLORCODE" : z3422.ColorCode = Children(i).Code
                                Case "COLORNAME" : z3422.ColorName = Children(i).Code
                                Case "SEORIGIN" : z3422.seOrigin = Children(i).Code
                                Case "CDORIGIN" : z3422.cdOrigin = Children(i).Code
                                Case "MATERIALCHECK" : z3422.MaterialCheck = Children(i).Code
                                Case "SEUNITPRICE" : z3422.seUnitPrice = Children(i).Code
                                Case "CDUNITPRICE" : z3422.cdUnitPrice = Children(i).Code
                                Case "SETAX" : z3422.seTax = Children(i).Code
                                Case "CDTAX" : z3422.cdTax = Children(i).Code
                                Case "SEUNITMATERIAL" : z3422.seUnitMaterial = Children(i).Code
                                Case "CDUNITMATERIAL" : z3422.cdUnitMaterial = Children(i).Code
                                Case "SEUNITPACKING" : z3422.seUnitPacking = Children(i).Code
                                Case "CDUNITPACKING" : z3422.cdUnitPacking = Children(i).Code
                                Case "UNITBASECHECK" : z3422.UnitBaseCheck = Children(i).Code
                                Case "QTYBASIC" : z3422.QtyBasic = Children(i).Code
                                Case "PRICEPURCHASING" : z3422.PricePurchasing = Children(i).Code
                                Case "PRICEMARKET" : z3422.PriceMarket = Children(i).Code
                                Case "PRICEEXCHANGE" : z3422.PriceExchange = Children(i).Code
                                Case "PRICEEXCHANGEAP" : z3422.PriceExchangeAP = Children(i).Code
                                Case "DATEEXCHANGE" : z3422.DateExchange = Children(i).Code
                                Case "PRICEPURCHASINGEX" : z3422.PricePurchasingEX = Children(i).Code
                                Case "PRICEMARKETEX" : z3422.PriceMarketEX = Children(i).Code
                                Case "PRICEPURCHASINGVND" : z3422.PricePurchasingVND = Children(i).Code
                                Case "PRICEMARKETVND" : z3422.PriceMarketVND = Children(i).Code
                                Case "AMOUNTPURCHASINGEX" : z3422.AmountPurchasingEX = Children(i).Code
                                Case "AMOUNTPURCHASINGVND" : z3422.AmountPurchasingVND = Children(i).Code
                                Case "AMOUNTTAXEX" : z3422.AmountTaxEX = Children(i).Code
                                Case "AMOUNTTAXVND" : z3422.AmountTaxVND = Children(i).Code
                                Case "SETAX1" : z3422.seTax1 = Children(i).Code
                                Case "CDTAX1" : z3422.cdTax1 = Children(i).Code
                                Case "PERTAX1" : z3422.PerTax1 = Children(i).Code
                                Case "AMOUNTTAX1" : z3422.AmountTax1 = Children(i).Code
                                Case "SETAX2" : z3422.seTax2 = Children(i).Code
                                Case "CDTAX2" : z3422.cdTax2 = Children(i).Code
                                Case "PERTAX2" : z3422.PerTax2 = Children(i).Code
                                Case "AMOUNTTAX2" : z3422.AmountTax2 = Children(i).Code
                                Case "SETAX3" : z3422.seTax3 = Children(i).Code
                                Case "CDTAX3" : z3422.cdTax3 = Children(i).Code
                                Case "PERTAX3" : z3422.PerTax3 = Children(i).Code
                                Case "AMOUNTTAX3" : z3422.AmountTax3 = Children(i).Code
                                Case "QTYREQUESTPO" : z3422.QtyRequestPO = Children(i).Code
                                Case "QTYPURCHASING" : z3422.QtyPurchasing = Children(i).Code
                                Case "PACKPURCHASING" : z3422.PackPurchasing = Children(i).Code
                                Case "QTYWAREHOUSE" : z3422.QtyWarehouse = Children(i).Code
                                Case "PACKWAREHOUSE" : z3422.PackWarehouse = Children(i).Code
                                Case "QTYINBOUND" : z3422.QtyInbound = Children(i).Code
                                Case "PACKINBOUND" : z3422.PackInbound = Children(i).Code
                                Case "QTYOUTBOUND" : z3422.QtyOutbound = Children(i).Code
                                Case "PACKOUTBOUND" : z3422.PackOutbound = Children(i).Code
                                Case "AMOUNTEX" : z3422.AmountEX = Children(i).Code
                                Case "AMOUNTVND" : z3422.AmountVND = Children(i).Code
                                Case "AMOUNTINBOUNDEX" : z3422.AmountInBoundEX = Children(i).Code
                                Case "AMOUNTINBOUNDVND" : z3422.AmountInBoundVND = Children(i).Code
                                Case "DATEDELIVERY" : z3422.DateDelivery = Children(i).Code
                                Case "DATESTART" : z3422.DateStart = Children(i).Code
                                Case "DATEFINISH" : z3422.DateFinish = Children(i).Code
                                Case "CHECKPURCHASING" : z3422.CheckPurchasing = Children(i).Code
                                Case "DATEACCEPT" : z3422.DateAccept = Children(i).Code
                                Case "DATEPOSTED" : z3422.DatePosted = Children(i).Code
                                Case "ISPOSTED" : z3422.IsPosted = Children(i).Code
                                Case "DATECOMPLETE" : z3422.DateComplete = Children(i).Code
                                Case "DATEAPPROVAL" : z3422.DateApproval = Children(i).Code
                                Case "DATECANCEL" : z3422.DateCancel = Children(i).Code
                                Case "CHECKCOMPLETE" : z3422.CheckComplete = Children(i).Code
                                Case "PURCHASINGORDERNO" : z3422.PurchasingOrderNo = Children(i).Code
                                Case "PURCHASINGORDERSEQ" : z3422.PurchasingOrderSeq = Children(i).Code
                                Case "JOBCARDWORKING" : z3422.JobCardWorking = Children(i).Code
                                Case "JOBCARDWORKINGSEQ" : z3422.JobCardWorkingSeq = Children(i).Code
                                Case "JOBCARDTYPE" : z3422.JobCardType = Children(i).Code
                                Case "SALESORDERNO" : z3422.SalesOrderNo = Children(i).Code
                                Case "SALESORDERSEQ" : z3422.SalesOrderSeq = Children(i).Code
                                Case "SALESORDERSNO" : z3422.SalesOrderSno = Children(i).Code
                                Case "CHECKORDERTYPE" : z3422.CheckOrderType = Children(i).Code
                                Case "ORDERNO" : z3422.OrderNo = Children(i).Code
                                Case "ORDERNOSEQ" : z3422.OrderNoSeq = Children(i).Code
                                Case "JOBCARD" : z3422.JobCard = Children(i).Code
                                Case "DATESYNC" : z3422.DateSync = Children(i).Code
                                Case "CHECKSYNC" : z3422.CheckSync = Children(i).Code
                                Case "SLNO" : z3422.SlNo = Children(i).Code
                                Case "CHECK_SPEC_1" : z3422.Check_Spec_1 = Children(i).Code
                                Case "CHECK_SPEC_2" : z3422.Check_Spec_2 = Children(i).Code
                                Case "CHECK_SPEC_3" : z3422.Check_Spec_3 = Children(i).Code
                                Case "CHECK_SPEC_4" : z3422.Check_Spec_4 = Children(i).Code
                                Case "CHECK_SPEC_5" : z3422.Check_Spec_5 = Children(i).Code
                                Case "CHECK_SPEC_6" : z3422.Check_Spec_6 = Children(i).Code
                                Case "CHECK_SPEC_7" : z3422.Check_Spec_7 = Children(i).Code
                                Case "CHECK_SPEC_8" : z3422.Check_Spec_8 = Children(i).Code
                                Case "CHECK_SPEC_9" : z3422.Check_Spec_9 = Children(i).Code
                                Case "REMARK" : z3422.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "FACTORDERNO" : z3422.FactOrderNo = Children(i).Data
                                Case "FACTORDERSEQ" : z3422.FactOrderSeq = Children(i).Data
                                Case "DECLARENO" : z3422.DeclareNo = Children(i).Data
                                Case "DATEDECLARE" : z3422.DateDeclare = Children(i).Data
                                Case "INCHARGEDECLARE" : z3422.InchargeDeclare = Children(i).Data
                                Case "DECLAREAMOUNT" : z3422.DeclareAmount = Children(i).Data
                                Case "DECLAREWGT" : z3422.DeclareWgt = Children(i).Data
                                Case "SESITE" : z3422.seSite = Children(i).Data
                                Case "CDSITE" : z3422.cdSite = Children(i).Data
                                Case "SEDEPARTMENT" : z3422.seDepartment = Children(i).Data
                                Case "CDDEPARTMENT" : z3422.cdDepartment = Children(i).Data
                                Case "SEFACTORY" : z3422.seFactory = Children(i).Data
                                Case "CDFACTORY" : z3422.cdFactory = Children(i).Data
                                Case "SELINEPROD" : z3422.seLineProd = Children(i).Data
                                Case "CDLINEPROD" : z3422.cdLineProd = Children(i).Data
                                Case "SESUBPROCESS" : z3422.seSubProcess = Children(i).Data
                                Case "CDSUBPROCESS" : z3422.cdSubProcess = Children(i).Data
                                Case "SEGROUPCOMPONENT" : z3422.seGroupComponent = Children(i).Data
                                Case "CDGROUPCOMPONENT" : z3422.cdGroupComponent = Children(i).Data
                                Case "CUSTOMERSUPPLIER" : z3422.CustomerSupplier = Children(i).Data
                                Case "DSEQ" : z3422.Dseq = Children(i).Data
                                Case "PSEQ" : z3422.Pseq = Children(i).Data
                                Case "AUTOKEYK3011" : z3422.AutokeyK3011 = Children(i).Data
                                Case "CHECKRELATIONTYPE" : z3422.CheckRelationType = Children(i).Data
                                Case "COMPONENTNAME" : z3422.ComponentName = Children(i).Data
                                Case "MATERIALCODE" : z3422.MaterialCode = Children(i).Data
                                Case "SPECIFICATION" : z3422.Specification = Children(i).Data
                                Case "WIDTH" : z3422.Width = Children(i).Data
                                Case "HEIGHT" : z3422.Height = Children(i).Data
                                Case "SIZENO" : z3422.SizeNo = Children(i).Data
                                Case "SIZENAME" : z3422.SizeName = Children(i).Data
                                Case "COLORCODE" : z3422.ColorCode = Children(i).Data
                                Case "COLORNAME" : z3422.ColorName = Children(i).Data
                                Case "SEORIGIN" : z3422.seOrigin = Children(i).Data
                                Case "CDORIGIN" : z3422.cdOrigin = Children(i).Data
                                Case "MATERIALCHECK" : z3422.MaterialCheck = Children(i).Data
                                Case "SEUNITPRICE" : z3422.seUnitPrice = Children(i).Data
                                Case "CDUNITPRICE" : z3422.cdUnitPrice = Children(i).Data
                                Case "SETAX" : z3422.seTax = Children(i).Data
                                Case "CDTAX" : z3422.cdTax = Children(i).Data
                                Case "SEUNITMATERIAL" : z3422.seUnitMaterial = Children(i).Data
                                Case "CDUNITMATERIAL" : z3422.cdUnitMaterial = Children(i).Data
                                Case "SEUNITPACKING" : z3422.seUnitPacking = Children(i).Data
                                Case "CDUNITPACKING" : z3422.cdUnitPacking = Children(i).Data
                                Case "UNITBASECHECK" : z3422.UnitBaseCheck = Children(i).Data
                                Case "QTYBASIC" : z3422.QtyBasic = Children(i).Data
                                Case "PRICEPURCHASING" : z3422.PricePurchasing = Children(i).Data
                                Case "PRICEMARKET" : z3422.PriceMarket = Children(i).Data
                                Case "PRICEEXCHANGE" : z3422.PriceExchange = Children(i).Data
                                Case "PRICEEXCHANGEAP" : z3422.PriceExchangeAP = Children(i).Data
                                Case "DATEEXCHANGE" : z3422.DateExchange = Children(i).Data
                                Case "PRICEPURCHASINGEX" : z3422.PricePurchasingEX = Children(i).Data
                                Case "PRICEMARKETEX" : z3422.PriceMarketEX = Children(i).Data
                                Case "PRICEPURCHASINGVND" : z3422.PricePurchasingVND = Children(i).Data
                                Case "PRICEMARKETVND" : z3422.PriceMarketVND = Children(i).Data
                                Case "AMOUNTPURCHASINGEX" : z3422.AmountPurchasingEX = Children(i).Data
                                Case "AMOUNTPURCHASINGVND" : z3422.AmountPurchasingVND = Children(i).Data
                                Case "AMOUNTTAXEX" : z3422.AmountTaxEX = Children(i).Data
                                Case "AMOUNTTAXVND" : z3422.AmountTaxVND = Children(i).Data
                                Case "SETAX1" : z3422.seTax1 = Children(i).Data
                                Case "CDTAX1" : z3422.cdTax1 = Children(i).Data
                                Case "PERTAX1" : z3422.PerTax1 = Children(i).Data
                                Case "AMOUNTTAX1" : z3422.AmountTax1 = Children(i).Data
                                Case "SETAX2" : z3422.seTax2 = Children(i).Data
                                Case "CDTAX2" : z3422.cdTax2 = Children(i).Data
                                Case "PERTAX2" : z3422.PerTax2 = Children(i).Data
                                Case "AMOUNTTAX2" : z3422.AmountTax2 = Children(i).Data
                                Case "SETAX3" : z3422.seTax3 = Children(i).Data
                                Case "CDTAX3" : z3422.cdTax3 = Children(i).Data
                                Case "PERTAX3" : z3422.PerTax3 = Children(i).Data
                                Case "AMOUNTTAX3" : z3422.AmountTax3 = Children(i).Data
                                Case "QTYREQUESTPO" : z3422.QtyRequestPO = Children(i).Data
                                Case "QTYPURCHASING" : z3422.QtyPurchasing = Children(i).Data
                                Case "PACKPURCHASING" : z3422.PackPurchasing = Children(i).Data
                                Case "QTYWAREHOUSE" : z3422.QtyWarehouse = Children(i).Data
                                Case "PACKWAREHOUSE" : z3422.PackWarehouse = Children(i).Data
                                Case "QTYINBOUND" : z3422.QtyInbound = Children(i).Data
                                Case "PACKINBOUND" : z3422.PackInbound = Children(i).Data
                                Case "QTYOUTBOUND" : z3422.QtyOutbound = Children(i).Data
                                Case "PACKOUTBOUND" : z3422.PackOutbound = Children(i).Data
                                Case "AMOUNTEX" : z3422.AmountEX = Children(i).Data
                                Case "AMOUNTVND" : z3422.AmountVND = Children(i).Data
                                Case "AMOUNTINBOUNDEX" : z3422.AmountInBoundEX = Children(i).Data
                                Case "AMOUNTINBOUNDVND" : z3422.AmountInBoundVND = Children(i).Data
                                Case "DATEDELIVERY" : z3422.DateDelivery = Children(i).Data
                                Case "DATESTART" : z3422.DateStart = Children(i).Data
                                Case "DATEFINISH" : z3422.DateFinish = Children(i).Data
                                Case "CHECKPURCHASING" : z3422.CheckPurchasing = Children(i).Data
                                Case "DATEACCEPT" : z3422.DateAccept = Children(i).Data
                                Case "DATEPOSTED" : z3422.DatePosted = Children(i).Data
                                Case "ISPOSTED" : z3422.IsPosted = Children(i).Data
                                Case "DATECOMPLETE" : z3422.DateComplete = Children(i).Data
                                Case "DATEAPPROVAL" : z3422.DateApproval = Children(i).Data
                                Case "DATECANCEL" : z3422.DateCancel = Children(i).Data
                                Case "CHECKCOMPLETE" : z3422.CheckComplete = Children(i).Data
                                Case "PURCHASINGORDERNO" : z3422.PurchasingOrderNo = Children(i).Data
                                Case "PURCHASINGORDERSEQ" : z3422.PurchasingOrderSeq = Children(i).Data
                                Case "JOBCARDWORKING" : z3422.JobCardWorking = Children(i).Data
                                Case "JOBCARDWORKINGSEQ" : z3422.JobCardWorkingSeq = Children(i).Data
                                Case "JOBCARDTYPE" : z3422.JobCardType = Children(i).Data
                                Case "SALESORDERNO" : z3422.SalesOrderNo = Children(i).Data
                                Case "SALESORDERSEQ" : z3422.SalesOrderSeq = Children(i).Data
                                Case "SALESORDERSNO" : z3422.SalesOrderSno = Children(i).Data
                                Case "CHECKORDERTYPE" : z3422.CheckOrderType = Children(i).Data
                                Case "ORDERNO" : z3422.OrderNo = Children(i).Data
                                Case "ORDERNOSEQ" : z3422.OrderNoSeq = Children(i).Data
                                Case "JOBCARD" : z3422.JobCard = Children(i).Data
                                Case "DATESYNC" : z3422.DateSync = Children(i).Data
                                Case "CHECKSYNC" : z3422.CheckSync = Children(i).Data
                                Case "SLNO" : z3422.SlNo = Children(i).Data
                                Case "CHECK_SPEC_1" : z3422.Check_Spec_1 = Children(i).Data
                                Case "CHECK_SPEC_2" : z3422.Check_Spec_2 = Children(i).Data
                                Case "CHECK_SPEC_3" : z3422.Check_Spec_3 = Children(i).Data
                                Case "CHECK_SPEC_4" : z3422.Check_Spec_4 = Children(i).Data
                                Case "CHECK_SPEC_5" : z3422.Check_Spec_5 = Children(i).Data
                                Case "CHECK_SPEC_6" : z3422.Check_Spec_6 = Children(i).Data
                                Case "CHECK_SPEC_7" : z3422.Check_Spec_7 = Children(i).Data
                                Case "CHECK_SPEC_8" : z3422.Check_Spec_8 = Children(i).Data
                                Case "CHECK_SPEC_9" : z3422.Check_Spec_9 = Children(i).Data
                                Case "REMARK" : z3422.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K3422_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K3422_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z3422 As T3422_AREA, Job As String, CheckClear As Boolean, FACTORDERNO As String, FACTORDERSEQ As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K3422_MOVE = False

        Try
            If READ_PFK3422(FACTORDERNO, FACTORDERSEQ) = True Then
                z3422 = D3422
                K3422_MOVE = True
            Else
                If CheckClear = True Then z3422 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3422")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "FACTORDERNO" : z3422.FactOrderNo = Children(i).Code
                                Case "FACTORDERSEQ" : z3422.FactOrderSeq = Children(i).Code
                                Case "DECLARENO" : z3422.DeclareNo = Children(i).Code
                                Case "DATEDECLARE" : z3422.DateDeclare = Children(i).Code
                                Case "INCHARGEDECLARE" : z3422.InchargeDeclare = Children(i).Code
                                Case "DECLAREAMOUNT" : z3422.DeclareAmount = Children(i).Code
                                Case "DECLAREWGT" : z3422.DeclareWgt = Children(i).Code
                                Case "SESITE" : z3422.seSite = Children(i).Code
                                Case "CDSITE" : z3422.cdSite = Children(i).Code
                                Case "SEDEPARTMENT" : z3422.seDepartment = Children(i).Code
                                Case "CDDEPARTMENT" : z3422.cdDepartment = Children(i).Code
                                Case "SEFACTORY" : z3422.seFactory = Children(i).Code
                                Case "CDFACTORY" : z3422.cdFactory = Children(i).Code
                                Case "SELINEPROD" : z3422.seLineProd = Children(i).Code
                                Case "CDLINEPROD" : z3422.cdLineProd = Children(i).Code
                                Case "SESUBPROCESS" : z3422.seSubProcess = Children(i).Code
                                Case "CDSUBPROCESS" : z3422.cdSubProcess = Children(i).Code
                                Case "SEGROUPCOMPONENT" : z3422.seGroupComponent = Children(i).Code
                                Case "CDGROUPCOMPONENT" : z3422.cdGroupComponent = Children(i).Code
                                Case "CUSTOMERSUPPLIER" : z3422.CustomerSupplier = Children(i).Code
                                Case "DSEQ" : z3422.Dseq = Children(i).Code
                                Case "PSEQ" : z3422.Pseq = Children(i).Code
                                Case "AUTOKEYK3011" : z3422.AutokeyK3011 = Children(i).Code
                                Case "CHECKRELATIONTYPE" : z3422.CheckRelationType = Children(i).Code
                                Case "COMPONENTNAME" : z3422.ComponentName = Children(i).Code
                                Case "MATERIALCODE" : z3422.MaterialCode = Children(i).Code
                                Case "SPECIFICATION" : z3422.Specification = Children(i).Code
                                Case "WIDTH" : z3422.Width = Children(i).Code
                                Case "HEIGHT" : z3422.Height = Children(i).Code
                                Case "SIZENO" : z3422.SizeNo = Children(i).Code
                                Case "SIZENAME" : z3422.SizeName = Children(i).Code
                                Case "COLORCODE" : z3422.ColorCode = Children(i).Code
                                Case "COLORNAME" : z3422.ColorName = Children(i).Code
                                Case "SEORIGIN" : z3422.seOrigin = Children(i).Code
                                Case "CDORIGIN" : z3422.cdOrigin = Children(i).Code
                                Case "MATERIALCHECK" : z3422.MaterialCheck = Children(i).Code
                                Case "SEUNITPRICE" : z3422.seUnitPrice = Children(i).Code
                                Case "CDUNITPRICE" : z3422.cdUnitPrice = Children(i).Code
                                Case "SETAX" : z3422.seTax = Children(i).Code
                                Case "CDTAX" : z3422.cdTax = Children(i).Code
                                Case "SEUNITMATERIAL" : z3422.seUnitMaterial = Children(i).Code
                                Case "CDUNITMATERIAL" : z3422.cdUnitMaterial = Children(i).Code
                                Case "SEUNITPACKING" : z3422.seUnitPacking = Children(i).Code
                                Case "CDUNITPACKING" : z3422.cdUnitPacking = Children(i).Code
                                Case "UNITBASECHECK" : z3422.UnitBaseCheck = Children(i).Code
                                Case "QTYBASIC" : z3422.QtyBasic = Children(i).Code
                                Case "PRICEPURCHASING" : z3422.PricePurchasing = Children(i).Code
                                Case "PRICEMARKET" : z3422.PriceMarket = Children(i).Code
                                Case "PRICEEXCHANGE" : z3422.PriceExchange = Children(i).Code
                                Case "PRICEEXCHANGEAP" : z3422.PriceExchangeAP = Children(i).Code
                                Case "DATEEXCHANGE" : z3422.DateExchange = Children(i).Code
                                Case "PRICEPURCHASINGEX" : z3422.PricePurchasingEX = Children(i).Code
                                Case "PRICEMARKETEX" : z3422.PriceMarketEX = Children(i).Code
                                Case "PRICEPURCHASINGVND" : z3422.PricePurchasingVND = Children(i).Code
                                Case "PRICEMARKETVND" : z3422.PriceMarketVND = Children(i).Code
                                Case "AMOUNTPURCHASINGEX" : z3422.AmountPurchasingEX = Children(i).Code
                                Case "AMOUNTPURCHASINGVND" : z3422.AmountPurchasingVND = Children(i).Code
                                Case "AMOUNTTAXEX" : z3422.AmountTaxEX = Children(i).Code
                                Case "AMOUNTTAXVND" : z3422.AmountTaxVND = Children(i).Code
                                Case "SETAX1" : z3422.seTax1 = Children(i).Code
                                Case "CDTAX1" : z3422.cdTax1 = Children(i).Code
                                Case "PERTAX1" : z3422.PerTax1 = Children(i).Code
                                Case "AMOUNTTAX1" : z3422.AmountTax1 = Children(i).Code
                                Case "SETAX2" : z3422.seTax2 = Children(i).Code
                                Case "CDTAX2" : z3422.cdTax2 = Children(i).Code
                                Case "PERTAX2" : z3422.PerTax2 = Children(i).Code
                                Case "AMOUNTTAX2" : z3422.AmountTax2 = Children(i).Code
                                Case "SETAX3" : z3422.seTax3 = Children(i).Code
                                Case "CDTAX3" : z3422.cdTax3 = Children(i).Code
                                Case "PERTAX3" : z3422.PerTax3 = Children(i).Code
                                Case "AMOUNTTAX3" : z3422.AmountTax3 = Children(i).Code
                                Case "QTYREQUESTPO" : z3422.QtyRequestPO = Children(i).Code
                                Case "QTYPURCHASING" : z3422.QtyPurchasing = Children(i).Code
                                Case "PACKPURCHASING" : z3422.PackPurchasing = Children(i).Code
                                Case "QTYWAREHOUSE" : z3422.QtyWarehouse = Children(i).Code
                                Case "PACKWAREHOUSE" : z3422.PackWarehouse = Children(i).Code
                                Case "QTYINBOUND" : z3422.QtyInbound = Children(i).Code
                                Case "PACKINBOUND" : z3422.PackInbound = Children(i).Code
                                Case "QTYOUTBOUND" : z3422.QtyOutbound = Children(i).Code
                                Case "PACKOUTBOUND" : z3422.PackOutbound = Children(i).Code
                                Case "AMOUNTEX" : z3422.AmountEX = Children(i).Code
                                Case "AMOUNTVND" : z3422.AmountVND = Children(i).Code
                                Case "AMOUNTINBOUNDEX" : z3422.AmountInBoundEX = Children(i).Code
                                Case "AMOUNTINBOUNDVND" : z3422.AmountInBoundVND = Children(i).Code
                                Case "DATEDELIVERY" : z3422.DateDelivery = Children(i).Code
                                Case "DATESTART" : z3422.DateStart = Children(i).Code
                                Case "DATEFINISH" : z3422.DateFinish = Children(i).Code
                                Case "CHECKPURCHASING" : z3422.CheckPurchasing = Children(i).Code
                                Case "DATEACCEPT" : z3422.DateAccept = Children(i).Code
                                Case "DATEPOSTED" : z3422.DatePosted = Children(i).Code
                                Case "ISPOSTED" : z3422.IsPosted = Children(i).Code
                                Case "DATECOMPLETE" : z3422.DateComplete = Children(i).Code
                                Case "DATEAPPROVAL" : z3422.DateApproval = Children(i).Code
                                Case "DATECANCEL" : z3422.DateCancel = Children(i).Code
                                Case "CHECKCOMPLETE" : z3422.CheckComplete = Children(i).Code
                                Case "PURCHASINGORDERNO" : z3422.PurchasingOrderNo = Children(i).Code
                                Case "PURCHASINGORDERSEQ" : z3422.PurchasingOrderSeq = Children(i).Code
                                Case "JOBCARDWORKING" : z3422.JobCardWorking = Children(i).Code
                                Case "JOBCARDWORKINGSEQ" : z3422.JobCardWorkingSeq = Children(i).Code
                                Case "JOBCARDTYPE" : z3422.JobCardType = Children(i).Code
                                Case "SALESORDERNO" : z3422.SalesOrderNo = Children(i).Code
                                Case "SALESORDERSEQ" : z3422.SalesOrderSeq = Children(i).Code
                                Case "SALESORDERSNO" : z3422.SalesOrderSno = Children(i).Code
                                Case "CHECKORDERTYPE" : z3422.CheckOrderType = Children(i).Code
                                Case "ORDERNO" : z3422.OrderNo = Children(i).Code
                                Case "ORDERNOSEQ" : z3422.OrderNoSeq = Children(i).Code
                                Case "JOBCARD" : z3422.JobCard = Children(i).Code
                                Case "DATESYNC" : z3422.DateSync = Children(i).Code
                                Case "CHECKSYNC" : z3422.CheckSync = Children(i).Code
                                Case "SLNO" : z3422.SlNo = Children(i).Code
                                Case "CHECK_SPEC_1" : z3422.Check_Spec_1 = Children(i).Code
                                Case "CHECK_SPEC_2" : z3422.Check_Spec_2 = Children(i).Code
                                Case "CHECK_SPEC_3" : z3422.Check_Spec_3 = Children(i).Code
                                Case "CHECK_SPEC_4" : z3422.Check_Spec_4 = Children(i).Code
                                Case "CHECK_SPEC_5" : z3422.Check_Spec_5 = Children(i).Code
                                Case "CHECK_SPEC_6" : z3422.Check_Spec_6 = Children(i).Code
                                Case "CHECK_SPEC_7" : z3422.Check_Spec_7 = Children(i).Code
                                Case "CHECK_SPEC_8" : z3422.Check_Spec_8 = Children(i).Code
                                Case "CHECK_SPEC_9" : z3422.Check_Spec_9 = Children(i).Code
                                Case "REMARK" : z3422.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "FACTORDERNO" : z3422.FactOrderNo = Children(i).Data
                                Case "FACTORDERSEQ" : z3422.FactOrderSeq = Children(i).Data
                                Case "DECLARENO" : z3422.DeclareNo = Children(i).Data
                                Case "DATEDECLARE" : z3422.DateDeclare = Children(i).Data
                                Case "INCHARGEDECLARE" : z3422.InchargeDeclare = Children(i).Data
                                Case "DECLAREAMOUNT" : z3422.DeclareAmount = Children(i).Data
                                Case "DECLAREWGT" : z3422.DeclareWgt = Children(i).Data
                                Case "SESITE" : z3422.seSite = Children(i).Data
                                Case "CDSITE" : z3422.cdSite = Children(i).Data
                                Case "SEDEPARTMENT" : z3422.seDepartment = Children(i).Data
                                Case "CDDEPARTMENT" : z3422.cdDepartment = Children(i).Data
                                Case "SEFACTORY" : z3422.seFactory = Children(i).Data
                                Case "CDFACTORY" : z3422.cdFactory = Children(i).Data
                                Case "SELINEPROD" : z3422.seLineProd = Children(i).Data
                                Case "CDLINEPROD" : z3422.cdLineProd = Children(i).Data
                                Case "SESUBPROCESS" : z3422.seSubProcess = Children(i).Data
                                Case "CDSUBPROCESS" : z3422.cdSubProcess = Children(i).Data
                                Case "SEGROUPCOMPONENT" : z3422.seGroupComponent = Children(i).Data
                                Case "CDGROUPCOMPONENT" : z3422.cdGroupComponent = Children(i).Data
                                Case "CUSTOMERSUPPLIER" : z3422.CustomerSupplier = Children(i).Data
                                Case "DSEQ" : z3422.Dseq = Children(i).Data
                                Case "PSEQ" : z3422.Pseq = Children(i).Data
                                Case "AUTOKEYK3011" : z3422.AutokeyK3011 = Children(i).Data
                                Case "CHECKRELATIONTYPE" : z3422.CheckRelationType = Children(i).Data
                                Case "COMPONENTNAME" : z3422.ComponentName = Children(i).Data
                                Case "MATERIALCODE" : z3422.MaterialCode = Children(i).Data
                                Case "SPECIFICATION" : z3422.Specification = Children(i).Data
                                Case "WIDTH" : z3422.Width = Children(i).Data
                                Case "HEIGHT" : z3422.Height = Children(i).Data
                                Case "SIZENO" : z3422.SizeNo = Children(i).Data
                                Case "SIZENAME" : z3422.SizeName = Children(i).Data
                                Case "COLORCODE" : z3422.ColorCode = Children(i).Data
                                Case "COLORNAME" : z3422.ColorName = Children(i).Data
                                Case "SEORIGIN" : z3422.seOrigin = Children(i).Data
                                Case "CDORIGIN" : z3422.cdOrigin = Children(i).Data
                                Case "MATERIALCHECK" : z3422.MaterialCheck = Children(i).Data
                                Case "SEUNITPRICE" : z3422.seUnitPrice = Children(i).Data
                                Case "CDUNITPRICE" : z3422.cdUnitPrice = Children(i).Data
                                Case "SETAX" : z3422.seTax = Children(i).Data
                                Case "CDTAX" : z3422.cdTax = Children(i).Data
                                Case "SEUNITMATERIAL" : z3422.seUnitMaterial = Children(i).Data
                                Case "CDUNITMATERIAL" : z3422.cdUnitMaterial = Children(i).Data
                                Case "SEUNITPACKING" : z3422.seUnitPacking = Children(i).Data
                                Case "CDUNITPACKING" : z3422.cdUnitPacking = Children(i).Data
                                Case "UNITBASECHECK" : z3422.UnitBaseCheck = Children(i).Data
                                Case "QTYBASIC" : z3422.QtyBasic = Children(i).Data
                                Case "PRICEPURCHASING" : z3422.PricePurchasing = Children(i).Data
                                Case "PRICEMARKET" : z3422.PriceMarket = Children(i).Data
                                Case "PRICEEXCHANGE" : z3422.PriceExchange = Children(i).Data
                                Case "PRICEEXCHANGEAP" : z3422.PriceExchangeAP = Children(i).Data
                                Case "DATEEXCHANGE" : z3422.DateExchange = Children(i).Data
                                Case "PRICEPURCHASINGEX" : z3422.PricePurchasingEX = Children(i).Data
                                Case "PRICEMARKETEX" : z3422.PriceMarketEX = Children(i).Data
                                Case "PRICEPURCHASINGVND" : z3422.PricePurchasingVND = Children(i).Data
                                Case "PRICEMARKETVND" : z3422.PriceMarketVND = Children(i).Data
                                Case "AMOUNTPURCHASINGEX" : z3422.AmountPurchasingEX = Children(i).Data
                                Case "AMOUNTPURCHASINGVND" : z3422.AmountPurchasingVND = Children(i).Data
                                Case "AMOUNTTAXEX" : z3422.AmountTaxEX = Children(i).Data
                                Case "AMOUNTTAXVND" : z3422.AmountTaxVND = Children(i).Data
                                Case "SETAX1" : z3422.seTax1 = Children(i).Data
                                Case "CDTAX1" : z3422.cdTax1 = Children(i).Data
                                Case "PERTAX1" : z3422.PerTax1 = Children(i).Data
                                Case "AMOUNTTAX1" : z3422.AmountTax1 = Children(i).Data
                                Case "SETAX2" : z3422.seTax2 = Children(i).Data
                                Case "CDTAX2" : z3422.cdTax2 = Children(i).Data
                                Case "PERTAX2" : z3422.PerTax2 = Children(i).Data
                                Case "AMOUNTTAX2" : z3422.AmountTax2 = Children(i).Data
                                Case "SETAX3" : z3422.seTax3 = Children(i).Data
                                Case "CDTAX3" : z3422.cdTax3 = Children(i).Data
                                Case "PERTAX3" : z3422.PerTax3 = Children(i).Data
                                Case "AMOUNTTAX3" : z3422.AmountTax3 = Children(i).Data
                                Case "QTYREQUESTPO" : z3422.QtyRequestPO = Children(i).Data
                                Case "QTYPURCHASING" : z3422.QtyPurchasing = Children(i).Data
                                Case "PACKPURCHASING" : z3422.PackPurchasing = Children(i).Data
                                Case "QTYWAREHOUSE" : z3422.QtyWarehouse = Children(i).Data
                                Case "PACKWAREHOUSE" : z3422.PackWarehouse = Children(i).Data
                                Case "QTYINBOUND" : z3422.QtyInbound = Children(i).Data
                                Case "PACKINBOUND" : z3422.PackInbound = Children(i).Data
                                Case "QTYOUTBOUND" : z3422.QtyOutbound = Children(i).Data
                                Case "PACKOUTBOUND" : z3422.PackOutbound = Children(i).Data
                                Case "AMOUNTEX" : z3422.AmountEX = Children(i).Data
                                Case "AMOUNTVND" : z3422.AmountVND = Children(i).Data
                                Case "AMOUNTINBOUNDEX" : z3422.AmountInBoundEX = Children(i).Data
                                Case "AMOUNTINBOUNDVND" : z3422.AmountInBoundVND = Children(i).Data
                                Case "DATEDELIVERY" : z3422.DateDelivery = Children(i).Data
                                Case "DATESTART" : z3422.DateStart = Children(i).Data
                                Case "DATEFINISH" : z3422.DateFinish = Children(i).Data
                                Case "CHECKPURCHASING" : z3422.CheckPurchasing = Children(i).Data
                                Case "DATEACCEPT" : z3422.DateAccept = Children(i).Data
                                Case "DATEPOSTED" : z3422.DatePosted = Children(i).Data
                                Case "ISPOSTED" : z3422.IsPosted = Children(i).Data
                                Case "DATECOMPLETE" : z3422.DateComplete = Children(i).Data
                                Case "DATEAPPROVAL" : z3422.DateApproval = Children(i).Data
                                Case "DATECANCEL" : z3422.DateCancel = Children(i).Data
                                Case "CHECKCOMPLETE" : z3422.CheckComplete = Children(i).Data
                                Case "PURCHASINGORDERNO" : z3422.PurchasingOrderNo = Children(i).Data
                                Case "PURCHASINGORDERSEQ" : z3422.PurchasingOrderSeq = Children(i).Data
                                Case "JOBCARDWORKING" : z3422.JobCardWorking = Children(i).Data
                                Case "JOBCARDWORKINGSEQ" : z3422.JobCardWorkingSeq = Children(i).Data
                                Case "JOBCARDTYPE" : z3422.JobCardType = Children(i).Data
                                Case "SALESORDERNO" : z3422.SalesOrderNo = Children(i).Data
                                Case "SALESORDERSEQ" : z3422.SalesOrderSeq = Children(i).Data
                                Case "SALESORDERSNO" : z3422.SalesOrderSno = Children(i).Data
                                Case "CHECKORDERTYPE" : z3422.CheckOrderType = Children(i).Data
                                Case "ORDERNO" : z3422.OrderNo = Children(i).Data
                                Case "ORDERNOSEQ" : z3422.OrderNoSeq = Children(i).Data
                                Case "JOBCARD" : z3422.JobCard = Children(i).Data
                                Case "DATESYNC" : z3422.DateSync = Children(i).Data
                                Case "CHECKSYNC" : z3422.CheckSync = Children(i).Data
                                Case "SLNO" : z3422.SlNo = Children(i).Data
                                Case "CHECK_SPEC_1" : z3422.Check_Spec_1 = Children(i).Data
                                Case "CHECK_SPEC_2" : z3422.Check_Spec_2 = Children(i).Data
                                Case "CHECK_SPEC_3" : z3422.Check_Spec_3 = Children(i).Data
                                Case "CHECK_SPEC_4" : z3422.Check_Spec_4 = Children(i).Data
                                Case "CHECK_SPEC_5" : z3422.Check_Spec_5 = Children(i).Data
                                Case "CHECK_SPEC_6" : z3422.Check_Spec_6 = Children(i).Data
                                Case "CHECK_SPEC_7" : z3422.Check_Spec_7 = Children(i).Data
                                Case "CHECK_SPEC_8" : z3422.Check_Spec_8 = Children(i).Data
                                Case "CHECK_SPEC_9" : z3422.Check_Spec_9 = Children(i).Data
                                Case "REMARK" : z3422.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K3422_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW AREA
    '=========================================================================================================================================================
    Public Sub K3422_MOVE(ByRef a3422 As T3422_AREA, ByRef b3422 As T3422_AREA)
        Try
            If trim$(a3422.FactOrderNo) = "" Then b3422.FactOrderNo = "" Else b3422.FactOrderNo = a3422.FactOrderNo
            If trim$(a3422.FactOrderSeq) = "" Then b3422.FactOrderSeq = "" Else b3422.FactOrderSeq = a3422.FactOrderSeq
            If trim$(a3422.DeclareNo) = "" Then b3422.DeclareNo = "" Else b3422.DeclareNo = a3422.DeclareNo
            If trim$(a3422.DateDeclare) = "" Then b3422.DateDeclare = "" Else b3422.DateDeclare = a3422.DateDeclare
            If trim$(a3422.InchargeDeclare) = "" Then b3422.InchargeDeclare = "" Else b3422.InchargeDeclare = a3422.InchargeDeclare
            If trim$(a3422.DeclareAmount) = "" Then b3422.DeclareAmount = "" Else b3422.DeclareAmount = a3422.DeclareAmount
            If trim$(a3422.DeclareWgt) = "" Then b3422.DeclareWgt = "" Else b3422.DeclareWgt = a3422.DeclareWgt
            If trim$(a3422.seSite) = "" Then b3422.seSite = "" Else b3422.seSite = a3422.seSite
            If trim$(a3422.cdSite) = "" Then b3422.cdSite = "" Else b3422.cdSite = a3422.cdSite
            If trim$(a3422.seDepartment) = "" Then b3422.seDepartment = "" Else b3422.seDepartment = a3422.seDepartment
            If trim$(a3422.cdDepartment) = "" Then b3422.cdDepartment = "" Else b3422.cdDepartment = a3422.cdDepartment
            If trim$(a3422.seFactory) = "" Then b3422.seFactory = "" Else b3422.seFactory = a3422.seFactory
            If trim$(a3422.cdFactory) = "" Then b3422.cdFactory = "" Else b3422.cdFactory = a3422.cdFactory
            If trim$(a3422.seLineProd) = "" Then b3422.seLineProd = "" Else b3422.seLineProd = a3422.seLineProd
            If trim$(a3422.cdLineProd) = "" Then b3422.cdLineProd = "" Else b3422.cdLineProd = a3422.cdLineProd
            If trim$(a3422.seSubProcess) = "" Then b3422.seSubProcess = "" Else b3422.seSubProcess = a3422.seSubProcess
            If trim$(a3422.cdSubProcess) = "" Then b3422.cdSubProcess = "" Else b3422.cdSubProcess = a3422.cdSubProcess
            If trim$(a3422.seGroupComponent) = "" Then b3422.seGroupComponent = "" Else b3422.seGroupComponent = a3422.seGroupComponent
            If trim$(a3422.cdGroupComponent) = "" Then b3422.cdGroupComponent = "" Else b3422.cdGroupComponent = a3422.cdGroupComponent
            If trim$(a3422.CustomerSupplier) = "" Then b3422.CustomerSupplier = "" Else b3422.CustomerSupplier = a3422.CustomerSupplier
            If trim$(a3422.Dseq) = "" Then b3422.Dseq = "" Else b3422.Dseq = a3422.Dseq
            If trim$(a3422.Pseq) = "" Then b3422.Pseq = "" Else b3422.Pseq = a3422.Pseq
            If trim$(a3422.AutokeyK3011) = "" Then b3422.AutokeyK3011 = "" Else b3422.AutokeyK3011 = a3422.AutokeyK3011
            If trim$(a3422.CheckRelationType) = "" Then b3422.CheckRelationType = "" Else b3422.CheckRelationType = a3422.CheckRelationType
            If trim$(a3422.ComponentName) = "" Then b3422.ComponentName = "" Else b3422.ComponentName = a3422.ComponentName
            If trim$(a3422.MaterialCode) = "" Then b3422.MaterialCode = "" Else b3422.MaterialCode = a3422.MaterialCode
            If trim$(a3422.Specification) = "" Then b3422.Specification = "" Else b3422.Specification = a3422.Specification
            If trim$(a3422.Width) = "" Then b3422.Width = "" Else b3422.Width = a3422.Width
            If trim$(a3422.Height) = "" Then b3422.Height = "" Else b3422.Height = a3422.Height
            If trim$(a3422.SizeNo) = "" Then b3422.SizeNo = "" Else b3422.SizeNo = a3422.SizeNo
            If trim$(a3422.SizeName) = "" Then b3422.SizeName = "" Else b3422.SizeName = a3422.SizeName
            If trim$(a3422.ColorCode) = "" Then b3422.ColorCode = "" Else b3422.ColorCode = a3422.ColorCode
            If trim$(a3422.ColorName) = "" Then b3422.ColorName = "" Else b3422.ColorName = a3422.ColorName
            If trim$(a3422.seOrigin) = "" Then b3422.seOrigin = "" Else b3422.seOrigin = a3422.seOrigin
            If trim$(a3422.cdOrigin) = "" Then b3422.cdOrigin = "" Else b3422.cdOrigin = a3422.cdOrigin
            If trim$(a3422.MaterialCheck) = "" Then b3422.MaterialCheck = "" Else b3422.MaterialCheck = a3422.MaterialCheck
            If trim$(a3422.seUnitPrice) = "" Then b3422.seUnitPrice = "" Else b3422.seUnitPrice = a3422.seUnitPrice
            If trim$(a3422.cdUnitPrice) = "" Then b3422.cdUnitPrice = "" Else b3422.cdUnitPrice = a3422.cdUnitPrice
            If trim$(a3422.seTax) = "" Then b3422.seTax = "" Else b3422.seTax = a3422.seTax
            If trim$(a3422.cdTax) = "" Then b3422.cdTax = "" Else b3422.cdTax = a3422.cdTax
            If trim$(a3422.seUnitMaterial) = "" Then b3422.seUnitMaterial = "" Else b3422.seUnitMaterial = a3422.seUnitMaterial
            If trim$(a3422.cdUnitMaterial) = "" Then b3422.cdUnitMaterial = "" Else b3422.cdUnitMaterial = a3422.cdUnitMaterial
            If trim$(a3422.seUnitPacking) = "" Then b3422.seUnitPacking = "" Else b3422.seUnitPacking = a3422.seUnitPacking
            If trim$(a3422.cdUnitPacking) = "" Then b3422.cdUnitPacking = "" Else b3422.cdUnitPacking = a3422.cdUnitPacking
            If trim$(a3422.UnitBaseCheck) = "" Then b3422.UnitBaseCheck = "" Else b3422.UnitBaseCheck = a3422.UnitBaseCheck
            If trim$(a3422.QtyBasic) = "" Then b3422.QtyBasic = "" Else b3422.QtyBasic = a3422.QtyBasic
            If trim$(a3422.PricePurchasing) = "" Then b3422.PricePurchasing = "" Else b3422.PricePurchasing = a3422.PricePurchasing
            If trim$(a3422.PriceMarket) = "" Then b3422.PriceMarket = "" Else b3422.PriceMarket = a3422.PriceMarket
            If trim$(a3422.PriceExchange) = "" Then b3422.PriceExchange = "" Else b3422.PriceExchange = a3422.PriceExchange
            If trim$(a3422.PriceExchangeAP) = "" Then b3422.PriceExchangeAP = "" Else b3422.PriceExchangeAP = a3422.PriceExchangeAP
            If trim$(a3422.DateExchange) = "" Then b3422.DateExchange = "" Else b3422.DateExchange = a3422.DateExchange
            If trim$(a3422.PricePurchasingEX) = "" Then b3422.PricePurchasingEX = "" Else b3422.PricePurchasingEX = a3422.PricePurchasingEX
            If trim$(a3422.PriceMarketEX) = "" Then b3422.PriceMarketEX = "" Else b3422.PriceMarketEX = a3422.PriceMarketEX
            If trim$(a3422.PricePurchasingVND) = "" Then b3422.PricePurchasingVND = "" Else b3422.PricePurchasingVND = a3422.PricePurchasingVND
            If trim$(a3422.PriceMarketVND) = "" Then b3422.PriceMarketVND = "" Else b3422.PriceMarketVND = a3422.PriceMarketVND
            If trim$(a3422.AmountPurchasingEX) = "" Then b3422.AmountPurchasingEX = "" Else b3422.AmountPurchasingEX = a3422.AmountPurchasingEX
            If trim$(a3422.AmountPurchasingVND) = "" Then b3422.AmountPurchasingVND = "" Else b3422.AmountPurchasingVND = a3422.AmountPurchasingVND
            If trim$(a3422.AmountTaxEX) = "" Then b3422.AmountTaxEX = "" Else b3422.AmountTaxEX = a3422.AmountTaxEX
            If trim$(a3422.AmountTaxVND) = "" Then b3422.AmountTaxVND = "" Else b3422.AmountTaxVND = a3422.AmountTaxVND
            If trim$(a3422.seTax1) = "" Then b3422.seTax1 = "" Else b3422.seTax1 = a3422.seTax1
            If trim$(a3422.cdTax1) = "" Then b3422.cdTax1 = "" Else b3422.cdTax1 = a3422.cdTax1
            If trim$(a3422.PerTax1) = "" Then b3422.PerTax1 = "" Else b3422.PerTax1 = a3422.PerTax1
            If trim$(a3422.AmountTax1) = "" Then b3422.AmountTax1 = "" Else b3422.AmountTax1 = a3422.AmountTax1
            If trim$(a3422.seTax2) = "" Then b3422.seTax2 = "" Else b3422.seTax2 = a3422.seTax2
            If trim$(a3422.cdTax2) = "" Then b3422.cdTax2 = "" Else b3422.cdTax2 = a3422.cdTax2
            If trim$(a3422.PerTax2) = "" Then b3422.PerTax2 = "" Else b3422.PerTax2 = a3422.PerTax2
            If trim$(a3422.AmountTax2) = "" Then b3422.AmountTax2 = "" Else b3422.AmountTax2 = a3422.AmountTax2
            If trim$(a3422.seTax3) = "" Then b3422.seTax3 = "" Else b3422.seTax3 = a3422.seTax3
            If trim$(a3422.cdTax3) = "" Then b3422.cdTax3 = "" Else b3422.cdTax3 = a3422.cdTax3
            If trim$(a3422.PerTax3) = "" Then b3422.PerTax3 = "" Else b3422.PerTax3 = a3422.PerTax3
            If trim$(a3422.AmountTax3) = "" Then b3422.AmountTax3 = "" Else b3422.AmountTax3 = a3422.AmountTax3
            If trim$(a3422.QtyRequestPO) = "" Then b3422.QtyRequestPO = "" Else b3422.QtyRequestPO = a3422.QtyRequestPO
            If trim$(a3422.QtyPurchasing) = "" Then b3422.QtyPurchasing = "" Else b3422.QtyPurchasing = a3422.QtyPurchasing
            If trim$(a3422.PackPurchasing) = "" Then b3422.PackPurchasing = "" Else b3422.PackPurchasing = a3422.PackPurchasing
            If trim$(a3422.QtyWarehouse) = "" Then b3422.QtyWarehouse = "" Else b3422.QtyWarehouse = a3422.QtyWarehouse
            If trim$(a3422.PackWarehouse) = "" Then b3422.PackWarehouse = "" Else b3422.PackWarehouse = a3422.PackWarehouse
            If trim$(a3422.QtyInbound) = "" Then b3422.QtyInbound = "" Else b3422.QtyInbound = a3422.QtyInbound
            If trim$(a3422.PackInbound) = "" Then b3422.PackInbound = "" Else b3422.PackInbound = a3422.PackInbound
            If trim$(a3422.QtyOutbound) = "" Then b3422.QtyOutbound = "" Else b3422.QtyOutbound = a3422.QtyOutbound
            If trim$(a3422.PackOutbound) = "" Then b3422.PackOutbound = "" Else b3422.PackOutbound = a3422.PackOutbound
            If trim$(a3422.AmountEX) = "" Then b3422.AmountEX = "" Else b3422.AmountEX = a3422.AmountEX
            If trim$(a3422.AmountVND) = "" Then b3422.AmountVND = "" Else b3422.AmountVND = a3422.AmountVND
            If trim$(a3422.AmountInBoundEX) = "" Then b3422.AmountInBoundEX = "" Else b3422.AmountInBoundEX = a3422.AmountInBoundEX
            If trim$(a3422.AmountInBoundVND) = "" Then b3422.AmountInBoundVND = "" Else b3422.AmountInBoundVND = a3422.AmountInBoundVND
            If trim$(a3422.DateDelivery) = "" Then b3422.DateDelivery = "" Else b3422.DateDelivery = a3422.DateDelivery
            If trim$(a3422.DateStart) = "" Then b3422.DateStart = "" Else b3422.DateStart = a3422.DateStart
            If trim$(a3422.DateFinish) = "" Then b3422.DateFinish = "" Else b3422.DateFinish = a3422.DateFinish
            If trim$(a3422.CheckPurchasing) = "" Then b3422.CheckPurchasing = "" Else b3422.CheckPurchasing = a3422.CheckPurchasing
            If trim$(a3422.DateAccept) = "" Then b3422.DateAccept = "" Else b3422.DateAccept = a3422.DateAccept
            If trim$(a3422.DatePosted) = "" Then b3422.DatePosted = "" Else b3422.DatePosted = a3422.DatePosted
            If trim$(a3422.IsPosted) = "" Then b3422.IsPosted = "" Else b3422.IsPosted = a3422.IsPosted
            If trim$(a3422.DateComplete) = "" Then b3422.DateComplete = "" Else b3422.DateComplete = a3422.DateComplete
            If trim$(a3422.DateApproval) = "" Then b3422.DateApproval = "" Else b3422.DateApproval = a3422.DateApproval
            If trim$(a3422.DateCancel) = "" Then b3422.DateCancel = "" Else b3422.DateCancel = a3422.DateCancel
            If trim$(a3422.CheckComplete) = "" Then b3422.CheckComplete = "" Else b3422.CheckComplete = a3422.CheckComplete
            If trim$(a3422.PurchasingOrderNo) = "" Then b3422.PurchasingOrderNo = "" Else b3422.PurchasingOrderNo = a3422.PurchasingOrderNo
            If trim$(a3422.PurchasingOrderSeq) = "" Then b3422.PurchasingOrderSeq = "" Else b3422.PurchasingOrderSeq = a3422.PurchasingOrderSeq
            If trim$(a3422.JobCardWorking) = "" Then b3422.JobCardWorking = "" Else b3422.JobCardWorking = a3422.JobCardWorking
            If trim$(a3422.JobCardWorkingSeq) = "" Then b3422.JobCardWorkingSeq = "" Else b3422.JobCardWorkingSeq = a3422.JobCardWorkingSeq
            If trim$(a3422.JobCardType) = "" Then b3422.JobCardType = "" Else b3422.JobCardType = a3422.JobCardType
            If trim$(a3422.SalesOrderNo) = "" Then b3422.SalesOrderNo = "" Else b3422.SalesOrderNo = a3422.SalesOrderNo
            If trim$(a3422.SalesOrderSeq) = "" Then b3422.SalesOrderSeq = "" Else b3422.SalesOrderSeq = a3422.SalesOrderSeq
            If trim$(a3422.SalesOrderSno) = "" Then b3422.SalesOrderSno = "" Else b3422.SalesOrderSno = a3422.SalesOrderSno
            If trim$(a3422.CheckOrderType) = "" Then b3422.CheckOrderType = "" Else b3422.CheckOrderType = a3422.CheckOrderType
            If trim$(a3422.OrderNo) = "" Then b3422.OrderNo = "" Else b3422.OrderNo = a3422.OrderNo
            If trim$(a3422.OrderNoSeq) = "" Then b3422.OrderNoSeq = "" Else b3422.OrderNoSeq = a3422.OrderNoSeq
            If trim$(a3422.JobCard) = "" Then b3422.JobCard = "" Else b3422.JobCard = a3422.JobCard
            If trim$(a3422.DateSync) = "" Then b3422.DateSync = "" Else b3422.DateSync = a3422.DateSync
            If trim$(a3422.CheckSync) = "" Then b3422.CheckSync = "" Else b3422.CheckSync = a3422.CheckSync
            If trim$(a3422.SlNo) = "" Then b3422.SlNo = "" Else b3422.SlNo = a3422.SlNo
            If trim$(a3422.Check_Spec_1) = "" Then b3422.Check_Spec_1 = "" Else b3422.Check_Spec_1 = a3422.Check_Spec_1
            If trim$(a3422.Check_Spec_2) = "" Then b3422.Check_Spec_2 = "" Else b3422.Check_Spec_2 = a3422.Check_Spec_2
            If trim$(a3422.Check_Spec_3) = "" Then b3422.Check_Spec_3 = "" Else b3422.Check_Spec_3 = a3422.Check_Spec_3
            If trim$(a3422.Check_Spec_4) = "" Then b3422.Check_Spec_4 = "" Else b3422.Check_Spec_4 = a3422.Check_Spec_4
            If trim$(a3422.Check_Spec_5) = "" Then b3422.Check_Spec_5 = "" Else b3422.Check_Spec_5 = a3422.Check_Spec_5
            If trim$(a3422.Check_Spec_6) = "" Then b3422.Check_Spec_6 = "" Else b3422.Check_Spec_6 = a3422.Check_Spec_6
            If trim$(a3422.Check_Spec_7) = "" Then b3422.Check_Spec_7 = "" Else b3422.Check_Spec_7 = a3422.Check_Spec_7
            If trim$(a3422.Check_Spec_8) = "" Then b3422.Check_Spec_8 = "" Else b3422.Check_Spec_8 = a3422.Check_Spec_8
            If trim$(a3422.Check_Spec_9) = "" Then b3422.Check_Spec_9 = "" Else b3422.Check_Spec_9 = a3422.Check_Spec_9
            If trim$(a3422.Remark) = "" Then b3422.Remark = "" Else b3422.Remark = a3422.Remark
        Catch ex As Exception
            Call MsgBoxP("K3422_MOVE", vbCritical)
        End Try
    End Sub


End Module 
