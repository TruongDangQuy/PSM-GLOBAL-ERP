'=========================================================================================================================================================
'   TABLE : (PFK2346)
'
'      WORKER : PSM GLOBAL ., LTD
'       WORK DATE : 2019 NEW
'       DEVELOPER    : MRNLV
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K2346

Structure T2346_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	FactOrderNo	 AS String	'			char(9)		*
Public 	FactOrderSeq	 AS Double	'			decimal		*
Public 	CustSpecNo	 AS String	'			nvarchar(50)
Public 	ProductCode	 AS String	'			nvarchar(50)
Public 	Article	 AS String	'			nvarchar(50)
Public 	CustPoNo	 AS String	'			nvarchar(100)
Public 	FacPO	 AS String	'			nvarchar(50)
Public 	PONO	 AS String	'			nvarchar(50)
Public 	PKO	 AS String	'			nvarchar(50)
Public 	CustomerName	 AS String	'			nvarchar(50)
Public 	DeclareNo	 AS String	'			nvarchar(50)
        Public DateLable As String  '			char(8)
        Public InchargeDeclare As String  '			char(8)
        Public DeclareAmount As Double  '			decimal
        Public DeclareWgt As Double  '			decimal
        Public seSite As String  '			char(3)
        Public cdSite As String  '			char(3)
        Public seDepartment As String  '			char(3)
        Public cdDepartment As String  '			char(3)
        Public seFactory As String  '			char(3)
        Public cdFactory As String  '			char(3)
        Public seLineProd As String  '			char(3)
        Public cdLineProd As String  '			char(3)
        Public seSubProcess As String  '			char(3)
        Public cdSubProcess As String  '			char(3)
        Public seGroupComponent As String  '			char(3)
        Public cdGroupComponent As String  '			char(3)
        Public CustomerSupplier As String  '			char(6)
        Public Dseq As Double  '			decimal
        Public Pseq As Double  '			decimal
        Public AutokeyK3011 As Double  '			decimal
        Public CheckRelationType As String  '			char(1)
        Public ComponentName As String  '			nvarchar(50)
        Public MaterialCode As String  '			char(6)
        Public Specification As String  '			nvarchar(200)
        Public Width As String  '			nvarchar(200)
        Public Height As String  '			nvarchar(200)
        Public SizeNo As String  '			char(2)
        Public SizeName As String  '			nvarchar(200)
        Public ColorCode As String  '			char(6)
        Public ColorName As String  '			nvarchar(200)
        Public seOrigin As String  '			char(3)
        Public cdOrigin As String  '			char(3)
        Public MaterialCheck As String  '			char(1)
        Public seUnitPrice As String  '			char(3)
        Public cdUnitPrice As String  '			char(3)
        Public seTax As String  '			char(3)
        Public cdTax As String  '			char(3)
        Public seUnitMaterial As String  '			char(3)
        Public cdUnitMaterial As String  '			char(3)
        Public seUnitPacking As String  '			char(3)
        Public cdUnitPacking As String  '			char(3)
        Public UnitBaseCheck As String  '			char(1)
        Public QtyBasic As Double  '			decimal
        Public PricePurchasing As Double  '			decimal
        Public PriceMarket As Double  '			decimal
        Public PriceExchange As Double  '			decimal
        Public PriceExchangeAP As Double  '			decimal
        Public DateExchange As String  '			char(8)
        Public PricePurchasingEX As Double  '			decimal
        Public PriceMarketEX As Double  '			decimal
        Public PricePurchasingVND As Double  '			decimal
        Public PriceMarketVND As Double  '			decimal
        Public AmountPurchasingEX As Double  '			decimal
        Public AmountPurchasingVND As Double  '			decimal
        Public AmountTaxEX As Double  '			decimal
        Public AmountTaxVND As Double  '			decimal
        Public seTax1 As String  '			char(3)
        Public cdTax1 As String  '			char(3)
        Public PerTax1 As Double  '			decimal
        Public AmountTax1 As Double  '			decimal
        Public seTax2 As String  '			char(3)
        Public cdTax2 As String  '			char(3)
        Public PerTax2 As Double  '			decimal
        Public AmountTax2 As Double  '			decimal
        Public seTax3 As String  '			char(3)
        Public cdTax3 As String  '			char(3)
        Public PerTax3 As Double  '			decimal
        Public AmountTax3 As Double  '			decimal
        Public QtyRequestPO As Double  '			decimal
        Public QtyPurchasingNet As Double  '			decimal
        Public QtyPurchasingMOQ As Double  '			decimal
        Public QtyPurchasing As Double  '			decimal
        Public PackPurchasing As Double  '			decimal
        Public QtyWarehouse As Double  '			decimal
        Public PackWarehouse As Double  '			decimal
        Public QtyInbound As Double  '			decimal
        Public PackInbound As Double  '			decimal
        Public QtyOutbound As Double  '			decimal
        Public PackOutbound As Double  '			decimal
        Public AmountEX As Double  '			decimal
        Public AmountVND As Double  '			decimal
        Public AmountInBoundEX As Double  '			decimal
        Public AmountInBoundVND As Double  '			decimal
        Public DateDelivery As String  '			char(8)
        Public DateStart As String  '			char(8)
        Public DateFinish As String  '			char(8)
        Public CheckPurchasing As String  '			char(1)
        Public DateAccept As String  '			char(8)
        Public DatePosted As String  '			char(8)
        Public IsPosted As String  '			char(1)
        Public DateComplete As String  '			char(8)
        Public DateApproval As String  '			char(8)
        Public DateCancel As String  '			char(8)
        Public CheckComplete As String  '			char(1)
        Public PurchasingOrderNo As String  '			char(9)
        Public PurchasingOrderSeq As Double  '			decimal
        Public JobCardWorking As String  '			char(9)
        Public JobCardWorkingSeq As String  '			char(3)
        Public JobCardType As String  '			char(1)
        Public SalesOrderNo As String  '			char(9)
        Public SalesOrderSeq As String  '			char(2)
        Public SalesOrderSno As String  '			char(2)
        Public CheckOrderType As String  '			char(1)
        Public OrderNo As String  '			char(9)
        Public OrderNoSeq As String  '			char(3)
        Public JobCard As String  '			char(9)
        Public DateSync As String  '			char(8)
        Public CheckSync As String  '			char(1)
        Public SlNo As String  '			nvarchar(200)
        Public Check_Spec_1 As String  '			char(1)
        Public Check_Spec_2 As String  '			char(1)
        Public Check_Spec_3 As String  '			char(1)
        Public Check_Spec_4 As String  '			char(1)
        Public Check_Spec_5 As String  '			char(1)
        Public Check_Spec_6 As String  '			char(1)
        Public Check_Spec_7 As String  '			char(1)
        Public Check_Spec_8 As String  '			char(1)
        Public Check_Spec_9 As String  '			char(1)
        Public Remark As String  '			nvarchar(200)
        Public TimeInsert As String  '			char(14)
        Public TimeUpdate As String  '			char(14)
        Public DateInsert As String  '			char(8)
        Public DateUpdate As String  '			char(8)
        Public InchargeInsert As String  '			char(8)
        Public InchargeUpdate As String  '			char(8)
        '=========================================================================================================================================================
    End Structure

    Public D2346 As T2346_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK2346(FACTORDERNO As String, FACTORDERSEQ As Double) As Boolean
        READ_PFK2346 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK2346 "
            SQL = SQL & " WHERE K2346_FactOrderNo		 = '" & FactOrderNo & "' "
            SQL = SQL & "   AND K2346_FactOrderSeq		 =  " & FactOrderSeq & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D2346_CLEAR() : GoTo SKIP_READ_PFK2346

            Call K2346_MOVE(rd)
            READ_PFK2346 = True

SKIP_READ_PFK2346:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK2346", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK2346(FACTORDERNO As String, FACTORDERSEQ As Double, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK2346 "
            SQL = SQL & " WHERE K2346_FactOrderNo		 = '" & FactOrderNo & "' "
            SQL = SQL & "   AND K2346_FactOrderSeq		 =  " & FactOrderSeq & "  "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK2346", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK2346(z2346 As T2346_AREA) As Boolean
        WRITE_PFK2346 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z2346)

            SQL = " INSERT INTO PFK2346 "
            SQL = SQL & " ( "
            SQL = SQL & " K2346_FactOrderNo,"
            SQL = SQL & " K2346_FactOrderSeq,"
            SQL = SQL & " K2346_CustSpecNo,"
            SQL = SQL & " K2346_ProductCode,"
            SQL = SQL & " K2346_Article,"
            SQL = SQL & " K2346_CustPoNo,"
            SQL = SQL & " K2346_FacPO,"
            SQL = SQL & " K2346_PONO,"
            SQL = SQL & " K2346_PKO,"
            SQL = SQL & " K2346_CustomerName,"
            SQL = SQL & " K2346_DeclareNo,"
            SQL = SQL & " K2346_DateLable,"
            SQL = SQL & " K2346_InchargeDeclare,"
            SQL = SQL & " K2346_DeclareAmount,"
            SQL = SQL & " K2346_DeclareWgt,"
            SQL = SQL & " K2346_seSite,"
            SQL = SQL & " K2346_cdSite,"
            SQL = SQL & " K2346_seDepartment,"
            SQL = SQL & " K2346_cdDepartment,"
            SQL = SQL & " K2346_seFactory,"
            SQL = SQL & " K2346_cdFactory,"
            SQL = SQL & " K2346_seLineProd,"
            SQL = SQL & " K2346_cdLineProd,"
            SQL = SQL & " K2346_seSubProcess,"
            SQL = SQL & " K2346_cdSubProcess,"
            SQL = SQL & " K2346_seGroupComponent,"
            SQL = SQL & " K2346_cdGroupComponent,"
            SQL = SQL & " K2346_CustomerSupplier,"
            SQL = SQL & " K2346_Dseq,"
            SQL = SQL & " K2346_Pseq,"
            SQL = SQL & " K2346_AutokeyK3011,"
            SQL = SQL & " K2346_CheckRelationType,"
            SQL = SQL & " K2346_ComponentName,"
            SQL = SQL & " K2346_MaterialCode,"
            SQL = SQL & " K2346_Specification,"
            SQL = SQL & " K2346_Width,"
            SQL = SQL & " K2346_Height,"
            SQL = SQL & " K2346_SizeNo,"
            SQL = SQL & " K2346_SizeName,"
            SQL = SQL & " K2346_ColorCode,"
            SQL = SQL & " K2346_ColorName,"
            SQL = SQL & " K2346_seOrigin,"
            SQL = SQL & " K2346_cdOrigin,"
            SQL = SQL & " K2346_MaterialCheck,"
            SQL = SQL & " K2346_seUnitPrice,"
            SQL = SQL & " K2346_cdUnitPrice,"
            SQL = SQL & " K2346_seTax,"
            SQL = SQL & " K2346_cdTax,"
            SQL = SQL & " K2346_seUnitMaterial,"
            SQL = SQL & " K2346_cdUnitMaterial,"
            SQL = SQL & " K2346_seUnitPacking,"
            SQL = SQL & " K2346_cdUnitPacking,"
            SQL = SQL & " K2346_UnitBaseCheck,"
            SQL = SQL & " K2346_QtyBasic,"
            SQL = SQL & " K2346_PricePurchasing,"
            SQL = SQL & " K2346_PriceMarket,"
            SQL = SQL & " K2346_PriceExchange,"
            SQL = SQL & " K2346_PriceExchangeAP,"
            SQL = SQL & " K2346_DateExchange,"
            SQL = SQL & " K2346_PricePurchasingEX,"
            SQL = SQL & " K2346_PriceMarketEX,"
            SQL = SQL & " K2346_PricePurchasingVND,"
            SQL = SQL & " K2346_PriceMarketVND,"
            SQL = SQL & " K2346_AmountPurchasingEX,"
            SQL = SQL & " K2346_AmountPurchasingVND,"
            SQL = SQL & " K2346_AmountTaxEX,"
            SQL = SQL & " K2346_AmountTaxVND,"
            SQL = SQL & " K2346_seTax1,"
            SQL = SQL & " K2346_cdTax1,"
            SQL = SQL & " K2346_PerTax1,"
            SQL = SQL & " K2346_AmountTax1,"
            SQL = SQL & " K2346_seTax2,"
            SQL = SQL & " K2346_cdTax2,"
            SQL = SQL & " K2346_PerTax2,"
            SQL = SQL & " K2346_AmountTax2,"
            SQL = SQL & " K2346_seTax3,"
            SQL = SQL & " K2346_cdTax3,"
            SQL = SQL & " K2346_PerTax3,"
            SQL = SQL & " K2346_AmountTax3,"
            SQL = SQL & " K2346_QtyRequestPO,"
            SQL = SQL & " K2346_QtyPurchasingNet,"
            SQL = SQL & " K2346_QtyPurchasingMOQ,"
            SQL = SQL & " K2346_QtyPurchasing,"
            SQL = SQL & " K2346_PackPurchasing,"
            SQL = SQL & " K2346_QtyWarehouse,"
            SQL = SQL & " K2346_PackWarehouse,"
            SQL = SQL & " K2346_QtyInbound,"
            SQL = SQL & " K2346_PackInbound,"
            SQL = SQL & " K2346_QtyOutbound,"
            SQL = SQL & " K2346_PackOutbound,"
            SQL = SQL & " K2346_AmountEX,"
            SQL = SQL & " K2346_AmountVND,"
            SQL = SQL & " K2346_AmountInBoundEX,"
            SQL = SQL & " K2346_AmountInBoundVND,"
            SQL = SQL & " K2346_DateDelivery,"
            SQL = SQL & " K2346_DateStart,"
            SQL = SQL & " K2346_DateFinish,"
            SQL = SQL & " K2346_CheckPurchasing,"
            SQL = SQL & " K2346_DateAccept,"
            SQL = SQL & " K2346_DatePosted,"
            SQL = SQL & " K2346_IsPosted,"
            SQL = SQL & " K2346_DateComplete,"
            SQL = SQL & " K2346_DateApproval,"
            SQL = SQL & " K2346_DateCancel,"
            SQL = SQL & " K2346_CheckComplete,"
            SQL = SQL & " K2346_PurchasingOrderNo,"
            SQL = SQL & " K2346_PurchasingOrderSeq,"
            SQL = SQL & " K2346_JobCardWorking,"
            SQL = SQL & " K2346_JobCardWorkingSeq,"
            SQL = SQL & " K2346_JobCardType,"
            SQL = SQL & " K2346_SalesOrderNo,"
            SQL = SQL & " K2346_SalesOrderSeq,"
            SQL = SQL & " K2346_SalesOrderSno,"
            SQL = SQL & " K2346_CheckOrderType,"
            SQL = SQL & " K2346_OrderNo,"
            SQL = SQL & " K2346_OrderNoSeq,"
            SQL = SQL & " K2346_JobCard,"
            SQL = SQL & " K2346_DateSync,"
            SQL = SQL & " K2346_CheckSync,"
            SQL = SQL & " K2346_SlNo,"
            SQL = SQL & " K2346_Check_Spec_1,"
            SQL = SQL & " K2346_Check_Spec_2,"
            SQL = SQL & " K2346_Check_Spec_3,"
            SQL = SQL & " K2346_Check_Spec_4,"
            SQL = SQL & " K2346_Check_Spec_5,"
            SQL = SQL & " K2346_Check_Spec_6,"
            SQL = SQL & " K2346_Check_Spec_7,"
            SQL = SQL & " K2346_Check_Spec_8,"
            SQL = SQL & " K2346_Check_Spec_9,"
            SQL = SQL & " K2346_Remark,"
            SQL = SQL & " K2346_TimeInsert,"
            SQL = SQL & " K2346_TimeUpdate,"
            SQL = SQL & " K2346_DateInsert,"
            SQL = SQL & " K2346_DateUpdate,"
            SQL = SQL & " K2346_InchargeInsert,"
            SQL = SQL & " K2346_InchargeUpdate "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z2346.FactOrderNo) & "', "
            SQL = SQL & "   " & FormatSQL(z2346.FactOrderSeq) & ", "
            SQL = SQL & "  N'" & FormatSQL(z2346.CustSpecNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.ProductCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.Article) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.CustPoNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.FacPO) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.PONO) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.PKO) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.CustomerName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.DeclareNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.DateLable) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.InchargeDeclare) & "', "
            SQL = SQL & "   " & FormatSQL(z2346.DeclareAmount) & ", "
            SQL = SQL & "   " & FormatSQL(z2346.DeclareWgt) & ", "
            SQL = SQL & "  N'" & FormatSQL(z2346.seSite) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.cdSite) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.seDepartment) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.cdDepartment) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.seFactory) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.cdFactory) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.seLineProd) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.cdLineProd) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.seSubProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.cdSubProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.seGroupComponent) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.cdGroupComponent) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.CustomerSupplier) & "', "
            SQL = SQL & "   " & FormatSQL(z2346.Dseq) & ", "
            SQL = SQL & "   " & FormatSQL(z2346.Pseq) & ", "
            SQL = SQL & "   " & FormatSQL(z2346.AutokeyK3011) & ", "
            SQL = SQL & "  N'" & FormatSQL(z2346.CheckRelationType) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.ComponentName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.MaterialCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.Specification) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.Width) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.Height) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.SizeNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.SizeName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.ColorCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.ColorName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.seOrigin) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.cdOrigin) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.MaterialCheck) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.seUnitPrice) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.cdUnitPrice) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.seTax) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.cdTax) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.seUnitMaterial) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.cdUnitMaterial) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.seUnitPacking) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.cdUnitPacking) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.UnitBaseCheck) & "', "
            SQL = SQL & "   " & FormatSQL(z2346.QtyBasic) & ", "
            SQL = SQL & "   " & FormatSQL(z2346.PricePurchasing) & ", "
            SQL = SQL & "   " & FormatSQL(z2346.PriceMarket) & ", "
            SQL = SQL & "   " & FormatSQL(z2346.PriceExchange) & ", "
            SQL = SQL & "   " & FormatSQL(z2346.PriceExchangeAP) & ", "
            SQL = SQL & "  N'" & FormatSQL(z2346.DateExchange) & "', "
            SQL = SQL & "   " & FormatSQL(z2346.PricePurchasingEX) & ", "
            SQL = SQL & "   " & FormatSQL(z2346.PriceMarketEX) & ", "
            SQL = SQL & "   " & FormatSQL(z2346.PricePurchasingVND) & ", "
            SQL = SQL & "   " & FormatSQL(z2346.PriceMarketVND) & ", "
            SQL = SQL & "   " & FormatSQL(z2346.AmountPurchasingEX) & ", "
            SQL = SQL & "   " & FormatSQL(z2346.AmountPurchasingVND) & ", "
            SQL = SQL & "   " & FormatSQL(z2346.AmountTaxEX) & ", "
            SQL = SQL & "   " & FormatSQL(z2346.AmountTaxVND) & ", "
            SQL = SQL & "  N'" & FormatSQL(z2346.seTax1) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.cdTax1) & "', "
            SQL = SQL & "   " & FormatSQL(z2346.PerTax1) & ", "
            SQL = SQL & "   " & FormatSQL(z2346.AmountTax1) & ", "
            SQL = SQL & "  N'" & FormatSQL(z2346.seTax2) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.cdTax2) & "', "
            SQL = SQL & "   " & FormatSQL(z2346.PerTax2) & ", "
            SQL = SQL & "   " & FormatSQL(z2346.AmountTax2) & ", "
            SQL = SQL & "  N'" & FormatSQL(z2346.seTax3) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.cdTax3) & "', "
            SQL = SQL & "   " & FormatSQL(z2346.PerTax3) & ", "
            SQL = SQL & "   " & FormatSQL(z2346.AmountTax3) & ", "
            SQL = SQL & "   " & FormatSQL(z2346.QtyRequestPO) & ", "
            SQL = SQL & "   " & FormatSQL(z2346.QtyPurchasingNet) & ", "
            SQL = SQL & "   " & FormatSQL(z2346.QtyPurchasingMOQ) & ", "
            SQL = SQL & "   " & FormatSQL(z2346.QtyPurchasing) & ", "
            SQL = SQL & "   " & FormatSQL(z2346.PackPurchasing) & ", "
            SQL = SQL & "   " & FormatSQL(z2346.QtyWarehouse) & ", "
            SQL = SQL & "   " & FormatSQL(z2346.PackWarehouse) & ", "
            SQL = SQL & "   " & FormatSQL(z2346.QtyInbound) & ", "
            SQL = SQL & "   " & FormatSQL(z2346.PackInbound) & ", "
            SQL = SQL & "   " & FormatSQL(z2346.QtyOutbound) & ", "
            SQL = SQL & "   " & FormatSQL(z2346.PackOutbound) & ", "
            SQL = SQL & "   " & FormatSQL(z2346.AmountEX) & ", "
            SQL = SQL & "   " & FormatSQL(z2346.AmountVND) & ", "
            SQL = SQL & "   " & FormatSQL(z2346.AmountInBoundEX) & ", "
            SQL = SQL & "   " & FormatSQL(z2346.AmountInBoundVND) & ", "
            SQL = SQL & "  N'" & FormatSQL(z2346.DateDelivery) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.DateStart) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.DateFinish) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.CheckPurchasing) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.DateAccept) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.DatePosted) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.IsPosted) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.DateComplete) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.DateApproval) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.DateCancel) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.CheckComplete) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.PurchasingOrderNo) & "', "
            SQL = SQL & "   " & FormatSQL(z2346.PurchasingOrderSeq) & ", "
            SQL = SQL & "  N'" & FormatSQL(z2346.JobCardWorking) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.JobCardWorkingSeq) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.JobCardType) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.SalesOrderNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.SalesOrderSeq) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.SalesOrderSno) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.CheckOrderType) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.OrderNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.OrderNoSeq) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.JobCard) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.DateSync) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.CheckSync) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.SlNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.Check_Spec_1) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.Check_Spec_2) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.Check_Spec_3) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.Check_Spec_4) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.Check_Spec_5) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.Check_Spec_6) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.Check_Spec_7) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.Check_Spec_8) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.Check_Spec_9) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.Remark) & "', "
            SQL = SQL & "  N'" & FormatSQL(PUB.TIME) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.TimeUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(PUB.DAT) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.DateUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(PUB.SAW) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2346.InchargeUpdate) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK2346 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK2346", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK2346(z2346 As T2346_AREA) As Boolean
        REWRITE_PFK2346 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z2346)

            SQL = " UPDATE PFK2346 SET "
            SQL = SQL & "    K2346_CustSpecNo      = N'" & FormatSQL(z2346.CustSpecNo) & "', "
            SQL = SQL & "    K2346_ProductCode      = N'" & FormatSQL(z2346.ProductCode) & "', "
            SQL = SQL & "    K2346_Article      = N'" & FormatSQL(z2346.Article) & "', "
            SQL = SQL & "    K2346_CustPoNo      = N'" & FormatSQL(z2346.CustPoNo) & "', "
            SQL = SQL & "    K2346_FacPO      = N'" & FormatSQL(z2346.FacPO) & "', "
            SQL = SQL & "    K2346_PONO      = N'" & FormatSQL(z2346.PONO) & "', "
            SQL = SQL & "    K2346_PKO      = N'" & FormatSQL(z2346.PKO) & "', "
            SQL = SQL & "    K2346_CustomerName      = N'" & FormatSQL(z2346.CustomerName) & "', "
            SQL = SQL & "    K2346_DeclareNo      = N'" & FormatSQL(z2346.DeclareNo) & "', "
            SQL = SQL & "    K2346_DateLable      = N'" & FormatSQL(z2346.DateLable) & "', "
            SQL = SQL & "    K2346_InchargeDeclare      = N'" & FormatSQL(z2346.InchargeDeclare) & "', "
            SQL = SQL & "    K2346_DeclareAmount      =  " & FormatSQL(z2346.DeclareAmount) & ", "
            SQL = SQL & "    K2346_DeclareWgt      =  " & FormatSQL(z2346.DeclareWgt) & ", "
            SQL = SQL & "    K2346_seSite      = N'" & FormatSQL(z2346.seSite) & "', "
            SQL = SQL & "    K2346_cdSite      = N'" & FormatSQL(z2346.cdSite) & "', "
            SQL = SQL & "    K2346_seDepartment      = N'" & FormatSQL(z2346.seDepartment) & "', "
            SQL = SQL & "    K2346_cdDepartment      = N'" & FormatSQL(z2346.cdDepartment) & "', "
            SQL = SQL & "    K2346_seFactory      = N'" & FormatSQL(z2346.seFactory) & "', "
            SQL = SQL & "    K2346_cdFactory      = N'" & FormatSQL(z2346.cdFactory) & "', "
            SQL = SQL & "    K2346_seLineProd      = N'" & FormatSQL(z2346.seLineProd) & "', "
            SQL = SQL & "    K2346_cdLineProd      = N'" & FormatSQL(z2346.cdLineProd) & "', "
            SQL = SQL & "    K2346_seSubProcess      = N'" & FormatSQL(z2346.seSubProcess) & "', "
            SQL = SQL & "    K2346_cdSubProcess      = N'" & FormatSQL(z2346.cdSubProcess) & "', "
            SQL = SQL & "    K2346_seGroupComponent      = N'" & FormatSQL(z2346.seGroupComponent) & "', "
            SQL = SQL & "    K2346_cdGroupComponent      = N'" & FormatSQL(z2346.cdGroupComponent) & "', "
            SQL = SQL & "    K2346_CustomerSupplier      = N'" & FormatSQL(z2346.CustomerSupplier) & "', "
            SQL = SQL & "    K2346_Dseq      =  " & FormatSQL(z2346.Dseq) & ", "
            SQL = SQL & "    K2346_Pseq      =  " & FormatSQL(z2346.Pseq) & ", "
            SQL = SQL & "    K2346_AutokeyK3011      =  " & FormatSQL(z2346.AutokeyK3011) & ", "
            SQL = SQL & "    K2346_CheckRelationType      = N'" & FormatSQL(z2346.CheckRelationType) & "', "
            SQL = SQL & "    K2346_ComponentName      = N'" & FormatSQL(z2346.ComponentName) & "', "
            SQL = SQL & "    K2346_MaterialCode      = N'" & FormatSQL(z2346.MaterialCode) & "', "
            SQL = SQL & "    K2346_Specification      = N'" & FormatSQL(z2346.Specification) & "', "
            SQL = SQL & "    K2346_Width      = N'" & FormatSQL(z2346.Width) & "', "
            SQL = SQL & "    K2346_Height      = N'" & FormatSQL(z2346.Height) & "', "
            SQL = SQL & "    K2346_SizeNo      = N'" & FormatSQL(z2346.SizeNo) & "', "
            SQL = SQL & "    K2346_SizeName      = N'" & FormatSQL(z2346.SizeName) & "', "
            SQL = SQL & "    K2346_ColorCode      = N'" & FormatSQL(z2346.ColorCode) & "', "
            SQL = SQL & "    K2346_ColorName      = N'" & FormatSQL(z2346.ColorName) & "', "
            SQL = SQL & "    K2346_seOrigin      = N'" & FormatSQL(z2346.seOrigin) & "', "
            SQL = SQL & "    K2346_cdOrigin      = N'" & FormatSQL(z2346.cdOrigin) & "', "
            SQL = SQL & "    K2346_MaterialCheck      = N'" & FormatSQL(z2346.MaterialCheck) & "', "
            SQL = SQL & "    K2346_seUnitPrice      = N'" & FormatSQL(z2346.seUnitPrice) & "', "
            SQL = SQL & "    K2346_cdUnitPrice      = N'" & FormatSQL(z2346.cdUnitPrice) & "', "
            SQL = SQL & "    K2346_seTax      = N'" & FormatSQL(z2346.seTax) & "', "
            SQL = SQL & "    K2346_cdTax      = N'" & FormatSQL(z2346.cdTax) & "', "
            SQL = SQL & "    K2346_seUnitMaterial      = N'" & FormatSQL(z2346.seUnitMaterial) & "', "
            SQL = SQL & "    K2346_cdUnitMaterial      = N'" & FormatSQL(z2346.cdUnitMaterial) & "', "
            SQL = SQL & "    K2346_seUnitPacking      = N'" & FormatSQL(z2346.seUnitPacking) & "', "
            SQL = SQL & "    K2346_cdUnitPacking      = N'" & FormatSQL(z2346.cdUnitPacking) & "', "
            SQL = SQL & "    K2346_UnitBaseCheck      = N'" & FormatSQL(z2346.UnitBaseCheck) & "', "
            SQL = SQL & "    K2346_QtyBasic      =  " & FormatSQL(z2346.QtyBasic) & ", "
            SQL = SQL & "    K2346_PricePurchasing      =  " & FormatSQL(z2346.PricePurchasing) & ", "
            SQL = SQL & "    K2346_PriceMarket      =  " & FormatSQL(z2346.PriceMarket) & ", "
            SQL = SQL & "    K2346_PriceExchange      =  " & FormatSQL(z2346.PriceExchange) & ", "
            SQL = SQL & "    K2346_PriceExchangeAP      =  " & FormatSQL(z2346.PriceExchangeAP) & ", "
            SQL = SQL & "    K2346_DateExchange      = N'" & FormatSQL(z2346.DateExchange) & "', "
            SQL = SQL & "    K2346_PricePurchasingEX      =  " & FormatSQL(z2346.PricePurchasingEX) & ", "
            SQL = SQL & "    K2346_PriceMarketEX      =  " & FormatSQL(z2346.PriceMarketEX) & ", "
            SQL = SQL & "    K2346_PricePurchasingVND      =  " & FormatSQL(z2346.PricePurchasingVND) & ", "
            SQL = SQL & "    K2346_PriceMarketVND      =  " & FormatSQL(z2346.PriceMarketVND) & ", "
            SQL = SQL & "    K2346_AmountPurchasingEX      =  " & FormatSQL(z2346.AmountPurchasingEX) & ", "
            SQL = SQL & "    K2346_AmountPurchasingVND      =  " & FormatSQL(z2346.AmountPurchasingVND) & ", "
            SQL = SQL & "    K2346_AmountTaxEX      =  " & FormatSQL(z2346.AmountTaxEX) & ", "
            SQL = SQL & "    K2346_AmountTaxVND      =  " & FormatSQL(z2346.AmountTaxVND) & ", "
            SQL = SQL & "    K2346_seTax1      = N'" & FormatSQL(z2346.seTax1) & "', "
            SQL = SQL & "    K2346_cdTax1      = N'" & FormatSQL(z2346.cdTax1) & "', "
            SQL = SQL & "    K2346_PerTax1      =  " & FormatSQL(z2346.PerTax1) & ", "
            SQL = SQL & "    K2346_AmountTax1      =  " & FormatSQL(z2346.AmountTax1) & ", "
            SQL = SQL & "    K2346_seTax2      = N'" & FormatSQL(z2346.seTax2) & "', "
            SQL = SQL & "    K2346_cdTax2      = N'" & FormatSQL(z2346.cdTax2) & "', "
            SQL = SQL & "    K2346_PerTax2      =  " & FormatSQL(z2346.PerTax2) & ", "
            SQL = SQL & "    K2346_AmountTax2      =  " & FormatSQL(z2346.AmountTax2) & ", "
            SQL = SQL & "    K2346_seTax3      = N'" & FormatSQL(z2346.seTax3) & "', "
            SQL = SQL & "    K2346_cdTax3      = N'" & FormatSQL(z2346.cdTax3) & "', "
            SQL = SQL & "    K2346_PerTax3      =  " & FormatSQL(z2346.PerTax3) & ", "
            SQL = SQL & "    K2346_AmountTax3      =  " & FormatSQL(z2346.AmountTax3) & ", "
            SQL = SQL & "    K2346_QtyRequestPO      =  " & FormatSQL(z2346.QtyRequestPO) & ", "
            SQL = SQL & "    K2346_QtyPurchasingNet      =  " & FormatSQL(z2346.QtyPurchasingNet) & ", "
            SQL = SQL & "    K2346_QtyPurchasingMOQ      =  " & FormatSQL(z2346.QtyPurchasingMOQ) & ", "
            SQL = SQL & "    K2346_QtyPurchasing      =  " & FormatSQL(z2346.QtyPurchasing) & ", "
            SQL = SQL & "    K2346_PackPurchasing      =  " & FormatSQL(z2346.PackPurchasing) & ", "
            SQL = SQL & "    K2346_QtyWarehouse      =  " & FormatSQL(z2346.QtyWarehouse) & ", "
            SQL = SQL & "    K2346_PackWarehouse      =  " & FormatSQL(z2346.PackWarehouse) & ", "
            SQL = SQL & "    K2346_QtyInbound      =  " & FormatSQL(z2346.QtyInbound) & ", "
            SQL = SQL & "    K2346_PackInbound      =  " & FormatSQL(z2346.PackInbound) & ", "
            SQL = SQL & "    K2346_QtyOutbound      =  " & FormatSQL(z2346.QtyOutbound) & ", "
            SQL = SQL & "    K2346_PackOutbound      =  " & FormatSQL(z2346.PackOutbound) & ", "
            SQL = SQL & "    K2346_AmountEX      =  " & FormatSQL(z2346.AmountEX) & ", "
            SQL = SQL & "    K2346_AmountVND      =  " & FormatSQL(z2346.AmountVND) & ", "
            SQL = SQL & "    K2346_AmountInBoundEX      =  " & FormatSQL(z2346.AmountInBoundEX) & ", "
            SQL = SQL & "    K2346_AmountInBoundVND      =  " & FormatSQL(z2346.AmountInBoundVND) & ", "
            SQL = SQL & "    K2346_DateDelivery      = N'" & FormatSQL(z2346.DateDelivery) & "', "
            SQL = SQL & "    K2346_DateStart      = N'" & FormatSQL(z2346.DateStart) & "', "
            SQL = SQL & "    K2346_DateFinish      = N'" & FormatSQL(z2346.DateFinish) & "', "
            SQL = SQL & "    K2346_CheckPurchasing      = N'" & FormatSQL(z2346.CheckPurchasing) & "', "
            SQL = SQL & "    K2346_DateAccept      = N'" & FormatSQL(z2346.DateAccept) & "', "
            SQL = SQL & "    K2346_DatePosted      = N'" & FormatSQL(z2346.DatePosted) & "', "
            SQL = SQL & "    K2346_IsPosted      = N'" & FormatSQL(z2346.IsPosted) & "', "
            SQL = SQL & "    K2346_DateComplete      = N'" & FormatSQL(z2346.DateComplete) & "', "
            SQL = SQL & "    K2346_DateApproval      = N'" & FormatSQL(z2346.DateApproval) & "', "
            SQL = SQL & "    K2346_DateCancel      = N'" & FormatSQL(z2346.DateCancel) & "', "
            SQL = SQL & "    K2346_CheckComplete      = N'" & FormatSQL(z2346.CheckComplete) & "', "
            SQL = SQL & "    K2346_PurchasingOrderNo      = N'" & FormatSQL(z2346.PurchasingOrderNo) & "', "
            SQL = SQL & "    K2346_PurchasingOrderSeq      =  " & FormatSQL(z2346.PurchasingOrderSeq) & ", "
            SQL = SQL & "    K2346_JobCardWorking      = N'" & FormatSQL(z2346.JobCardWorking) & "', "
            SQL = SQL & "    K2346_JobCardWorkingSeq      = N'" & FormatSQL(z2346.JobCardWorkingSeq) & "', "
            SQL = SQL & "    K2346_JobCardType      = N'" & FormatSQL(z2346.JobCardType) & "', "
            SQL = SQL & "    K2346_SalesOrderNo      = N'" & FormatSQL(z2346.SalesOrderNo) & "', "
            SQL = SQL & "    K2346_SalesOrderSeq      = N'" & FormatSQL(z2346.SalesOrderSeq) & "', "
            SQL = SQL & "    K2346_SalesOrderSno      = N'" & FormatSQL(z2346.SalesOrderSno) & "', "
            SQL = SQL & "    K2346_CheckOrderType      = N'" & FormatSQL(z2346.CheckOrderType) & "', "
            SQL = SQL & "    K2346_OrderNo      = N'" & FormatSQL(z2346.OrderNo) & "', "
            SQL = SQL & "    K2346_OrderNoSeq      = N'" & FormatSQL(z2346.OrderNoSeq) & "', "
            SQL = SQL & "    K2346_JobCard      = N'" & FormatSQL(z2346.JobCard) & "', "
            SQL = SQL & "    K2346_DateSync      = N'" & FormatSQL(z2346.DateSync) & "', "
            SQL = SQL & "    K2346_CheckSync      = N'" & FormatSQL(z2346.CheckSync) & "', "
            SQL = SQL & "    K2346_SlNo      = N'" & FormatSQL(z2346.SlNo) & "', "
            SQL = SQL & "    K2346_Check_Spec_1      = N'" & FormatSQL(z2346.Check_Spec_1) & "', "
            SQL = SQL & "    K2346_Check_Spec_2      = N'" & FormatSQL(z2346.Check_Spec_2) & "', "
            SQL = SQL & "    K2346_Check_Spec_3      = N'" & FormatSQL(z2346.Check_Spec_3) & "', "
            SQL = SQL & "    K2346_Check_Spec_4      = N'" & FormatSQL(z2346.Check_Spec_4) & "', "
            SQL = SQL & "    K2346_Check_Spec_5      = N'" & FormatSQL(z2346.Check_Spec_5) & "', "
            SQL = SQL & "    K2346_Check_Spec_6      = N'" & FormatSQL(z2346.Check_Spec_6) & "', "
            SQL = SQL & "    K2346_Check_Spec_7      = N'" & FormatSQL(z2346.Check_Spec_7) & "', "
            SQL = SQL & "    K2346_Check_Spec_8      = N'" & FormatSQL(z2346.Check_Spec_8) & "', "
            SQL = SQL & "    K2346_Check_Spec_9      = N'" & FormatSQL(z2346.Check_Spec_9) & "', "
            SQL = SQL & "    K2346_Remark      = N'" & FormatSQL(z2346.Remark) & "', "
            SQL = SQL & "    K2346_TimeInsert      = N'" & FormatSQL(z2346.TimeInsert) & "', "
            SQL = SQL & "    K2346_TimeUpdate      = N'" & FormatSQL(PUB.TIME) & "', "
            SQL = SQL & "    K2346_DateInsert      = N'" & FormatSQL(z2346.DateInsert) & "', "
            SQL = SQL & "    K2346_DateUpdate      = N'" & FormatSQL(PUB.DAT) & "', "
            SQL = SQL & "    K2346_InchargeInsert      = N'" & FormatSQL(z2346.InchargeInsert) & "', "
            SQL = SQL & "    K2346_InchargeUpdate      = N'" & FormatSQL(PUB.SAW) & "'  "
            SQL = SQL & " WHERE K2346_FactOrderNo		 = '" & z2346.FactOrderNo & "' "
            SQL = SQL & "   AND K2346_FactOrderSeq		 =  " & z2346.FactOrderSeq & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()


            REWRITE_PFK2346 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK2346", vbCritical)

        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK2346(z2346 As T2346_AREA) As Boolean
        DELETE_PFK2346 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z2346)

            SQL = " DELETE FROM PFK2346  "
            SQL = SQL & " WHERE K2346_FactOrderNo		 = '" & z2346.FactOrderNo & "' "
            SQL = SQL & "   AND K2346_FactOrderSeq		 =  " & z2346.FactOrderSeq & "  "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK2346 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK2346", vbCritical)
        Finally
            Call GetFullInformation("PFK2346", "D", SQL)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D2346_CLEAR()
        Try

            D2346.FactOrderNo = ""
            D2346.FactOrderSeq = 0
            D2346.CustSpecNo = ""
            D2346.ProductCode = ""
            D2346.Article = ""
            D2346.CustPoNo = ""
            D2346.FacPO = ""
            D2346.PONO = ""
            D2346.PKO = ""
            D2346.CustomerName = ""
            D2346.DeclareNo = ""
            D2346.DateLable = ""
            D2346.InchargeDeclare = ""
            D2346.DeclareAmount = 0
            D2346.DeclareWgt = 0
            D2346.seSite = ""
            D2346.cdSite = ""
            D2346.seDepartment = ""
            D2346.cdDepartment = ""
            D2346.seFactory = ""
            D2346.cdFactory = ""
            D2346.seLineProd = ""
            D2346.cdLineProd = ""
            D2346.seSubProcess = ""
            D2346.cdSubProcess = ""
            D2346.seGroupComponent = ""
            D2346.cdGroupComponent = ""
            D2346.CustomerSupplier = ""
            D2346.Dseq = 0
            D2346.Pseq = 0
            D2346.AutokeyK3011 = 0
            D2346.CheckRelationType = ""
            D2346.ComponentName = ""
            D2346.MaterialCode = ""
            D2346.Specification = ""
            D2346.Width = ""
            D2346.Height = ""
            D2346.SizeNo = ""
            D2346.SizeName = ""
            D2346.ColorCode = ""
            D2346.ColorName = ""
            D2346.seOrigin = ""
            D2346.cdOrigin = ""
            D2346.MaterialCheck = ""
            D2346.seUnitPrice = ""
            D2346.cdUnitPrice = ""
            D2346.seTax = ""
            D2346.cdTax = ""
            D2346.seUnitMaterial = ""
            D2346.cdUnitMaterial = ""
            D2346.seUnitPacking = ""
            D2346.cdUnitPacking = ""
            D2346.UnitBaseCheck = ""
            D2346.QtyBasic = 0
            D2346.PricePurchasing = 0
            D2346.PriceMarket = 0
            D2346.PriceExchange = 0
            D2346.PriceExchangeAP = 0
            D2346.DateExchange = ""
            D2346.PricePurchasingEX = 0
            D2346.PriceMarketEX = 0
            D2346.PricePurchasingVND = 0
            D2346.PriceMarketVND = 0
            D2346.AmountPurchasingEX = 0
            D2346.AmountPurchasingVND = 0
            D2346.AmountTaxEX = 0
            D2346.AmountTaxVND = 0
            D2346.seTax1 = ""
            D2346.cdTax1 = ""
            D2346.PerTax1 = 0
            D2346.AmountTax1 = 0
            D2346.seTax2 = ""
            D2346.cdTax2 = ""
            D2346.PerTax2 = 0
            D2346.AmountTax2 = 0
            D2346.seTax3 = ""
            D2346.cdTax3 = ""
            D2346.PerTax3 = 0
            D2346.AmountTax3 = 0
            D2346.QtyRequestPO = 0
            D2346.QtyPurchasingNet = 0
            D2346.QtyPurchasingMOQ = 0
            D2346.QtyPurchasing = 0
            D2346.PackPurchasing = 0
            D2346.QtyWarehouse = 0
            D2346.PackWarehouse = 0
            D2346.QtyInbound = 0
            D2346.PackInbound = 0
            D2346.QtyOutbound = 0
            D2346.PackOutbound = 0
            D2346.AmountEX = 0
            D2346.AmountVND = 0
            D2346.AmountInBoundEX = 0
            D2346.AmountInBoundVND = 0
            D2346.DateDelivery = ""
            D2346.DateStart = ""
            D2346.DateFinish = ""
            D2346.CheckPurchasing = ""
            D2346.DateAccept = ""
            D2346.DatePosted = ""
            D2346.IsPosted = ""
            D2346.DateComplete = ""
            D2346.DateApproval = ""
            D2346.DateCancel = ""
            D2346.CheckComplete = ""
            D2346.PurchasingOrderNo = ""
            D2346.PurchasingOrderSeq = 0
            D2346.JobCardWorking = ""
            D2346.JobCardWorkingSeq = ""
            D2346.JobCardType = ""
            D2346.SalesOrderNo = ""
            D2346.SalesOrderSeq = ""
            D2346.SalesOrderSno = ""
            D2346.CheckOrderType = ""
            D2346.OrderNo = ""
            D2346.OrderNoSeq = ""
            D2346.JobCard = ""
            D2346.DateSync = ""
            D2346.CheckSync = ""
            D2346.SlNo = ""
            D2346.Check_Spec_1 = ""
            D2346.Check_Spec_2 = ""
            D2346.Check_Spec_3 = ""
            D2346.Check_Spec_4 = ""
            D2346.Check_Spec_5 = ""
            D2346.Check_Spec_6 = ""
            D2346.Check_Spec_7 = ""
            D2346.Check_Spec_8 = ""
            D2346.Check_Spec_9 = ""
            D2346.Remark = ""
            D2346.TimeInsert = ""
            D2346.TimeUpdate = ""
            D2346.DateInsert = ""
            D2346.DateUpdate = ""
            D2346.InchargeInsert = ""
            D2346.InchargeUpdate = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D2346_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x2346 As T2346_AREA)
        Try

            x2346.FactOrderNo = trim$(x2346.FactOrderNo)
            x2346.FactOrderSeq = trim$(x2346.FactOrderSeq)
            x2346.CustSpecNo = trim$(x2346.CustSpecNo)
            x2346.ProductCode = trim$(x2346.ProductCode)
            x2346.Article = trim$(x2346.Article)
            x2346.CustPoNo = trim$(x2346.CustPoNo)
            x2346.FacPO = trim$(x2346.FacPO)
            x2346.PONO = trim$(x2346.PONO)
            x2346.PKO = trim$(x2346.PKO)
            x2346.CustomerName = trim$(x2346.CustomerName)
            x2346.DeclareNo = trim$(x2346.DeclareNo)
            x2346.DateLable = trim$(x2346.DateLable)
            x2346.InchargeDeclare = trim$(x2346.InchargeDeclare)
            x2346.DeclareAmount = trim$(x2346.DeclareAmount)
            x2346.DeclareWgt = trim$(x2346.DeclareWgt)
            x2346.seSite = trim$(x2346.seSite)
            x2346.cdSite = trim$(x2346.cdSite)
            x2346.seDepartment = trim$(x2346.seDepartment)
            x2346.cdDepartment = trim$(x2346.cdDepartment)
            x2346.seFactory = trim$(x2346.seFactory)
            x2346.cdFactory = trim$(x2346.cdFactory)
            x2346.seLineProd = trim$(x2346.seLineProd)
            x2346.cdLineProd = trim$(x2346.cdLineProd)
            x2346.seSubProcess = trim$(x2346.seSubProcess)
            x2346.cdSubProcess = trim$(x2346.cdSubProcess)
            x2346.seGroupComponent = trim$(x2346.seGroupComponent)
            x2346.cdGroupComponent = trim$(x2346.cdGroupComponent)
            x2346.CustomerSupplier = trim$(x2346.CustomerSupplier)
            x2346.Dseq = trim$(x2346.Dseq)
            x2346.Pseq = trim$(x2346.Pseq)
            x2346.AutokeyK3011 = trim$(x2346.AutokeyK3011)
            x2346.CheckRelationType = trim$(x2346.CheckRelationType)
            x2346.ComponentName = trim$(x2346.ComponentName)
            x2346.MaterialCode = trim$(x2346.MaterialCode)
            x2346.Specification = trim$(x2346.Specification)
            x2346.Width = trim$(x2346.Width)
            x2346.Height = trim$(x2346.Height)
            x2346.SizeNo = trim$(x2346.SizeNo)
            x2346.SizeName = trim$(x2346.SizeName)
            x2346.ColorCode = trim$(x2346.ColorCode)
            x2346.ColorName = trim$(x2346.ColorName)
            x2346.seOrigin = trim$(x2346.seOrigin)
            x2346.cdOrigin = trim$(x2346.cdOrigin)
            x2346.MaterialCheck = trim$(x2346.MaterialCheck)
            x2346.seUnitPrice = trim$(x2346.seUnitPrice)
            x2346.cdUnitPrice = trim$(x2346.cdUnitPrice)
            x2346.seTax = trim$(x2346.seTax)
            x2346.cdTax = trim$(x2346.cdTax)
            x2346.seUnitMaterial = trim$(x2346.seUnitMaterial)
            x2346.cdUnitMaterial = trim$(x2346.cdUnitMaterial)
            x2346.seUnitPacking = trim$(x2346.seUnitPacking)
            x2346.cdUnitPacking = trim$(x2346.cdUnitPacking)
            x2346.UnitBaseCheck = trim$(x2346.UnitBaseCheck)
            x2346.QtyBasic = trim$(x2346.QtyBasic)
            x2346.PricePurchasing = trim$(x2346.PricePurchasing)
            x2346.PriceMarket = trim$(x2346.PriceMarket)
            x2346.PriceExchange = trim$(x2346.PriceExchange)
            x2346.PriceExchangeAP = trim$(x2346.PriceExchangeAP)
            x2346.DateExchange = trim$(x2346.DateExchange)
            x2346.PricePurchasingEX = trim$(x2346.PricePurchasingEX)
            x2346.PriceMarketEX = trim$(x2346.PriceMarketEX)
            x2346.PricePurchasingVND = trim$(x2346.PricePurchasingVND)
            x2346.PriceMarketVND = trim$(x2346.PriceMarketVND)
            x2346.AmountPurchasingEX = trim$(x2346.AmountPurchasingEX)
            x2346.AmountPurchasingVND = trim$(x2346.AmountPurchasingVND)
            x2346.AmountTaxEX = trim$(x2346.AmountTaxEX)
            x2346.AmountTaxVND = trim$(x2346.AmountTaxVND)
            x2346.seTax1 = trim$(x2346.seTax1)
            x2346.cdTax1 = trim$(x2346.cdTax1)
            x2346.PerTax1 = trim$(x2346.PerTax1)
            x2346.AmountTax1 = trim$(x2346.AmountTax1)
            x2346.seTax2 = trim$(x2346.seTax2)
            x2346.cdTax2 = trim$(x2346.cdTax2)
            x2346.PerTax2 = trim$(x2346.PerTax2)
            x2346.AmountTax2 = trim$(x2346.AmountTax2)
            x2346.seTax3 = trim$(x2346.seTax3)
            x2346.cdTax3 = trim$(x2346.cdTax3)
            x2346.PerTax3 = trim$(x2346.PerTax3)
            x2346.AmountTax3 = trim$(x2346.AmountTax3)
            x2346.QtyRequestPO = trim$(x2346.QtyRequestPO)
            x2346.QtyPurchasingNet = trim$(x2346.QtyPurchasingNet)
            x2346.QtyPurchasingMOQ = trim$(x2346.QtyPurchasingMOQ)
            x2346.QtyPurchasing = trim$(x2346.QtyPurchasing)
            x2346.PackPurchasing = trim$(x2346.PackPurchasing)
            x2346.QtyWarehouse = trim$(x2346.QtyWarehouse)
            x2346.PackWarehouse = trim$(x2346.PackWarehouse)
            x2346.QtyInbound = trim$(x2346.QtyInbound)
            x2346.PackInbound = trim$(x2346.PackInbound)
            x2346.QtyOutbound = trim$(x2346.QtyOutbound)
            x2346.PackOutbound = trim$(x2346.PackOutbound)
            x2346.AmountEX = trim$(x2346.AmountEX)
            x2346.AmountVND = trim$(x2346.AmountVND)
            x2346.AmountInBoundEX = trim$(x2346.AmountInBoundEX)
            x2346.AmountInBoundVND = trim$(x2346.AmountInBoundVND)
            x2346.DateDelivery = trim$(x2346.DateDelivery)
            x2346.DateStart = trim$(x2346.DateStart)
            x2346.DateFinish = trim$(x2346.DateFinish)
            x2346.CheckPurchasing = trim$(x2346.CheckPurchasing)
            x2346.DateAccept = trim$(x2346.DateAccept)
            x2346.DatePosted = trim$(x2346.DatePosted)
            x2346.IsPosted = trim$(x2346.IsPosted)
            x2346.DateComplete = trim$(x2346.DateComplete)
            x2346.DateApproval = trim$(x2346.DateApproval)
            x2346.DateCancel = trim$(x2346.DateCancel)
            x2346.CheckComplete = trim$(x2346.CheckComplete)
            x2346.PurchasingOrderNo = trim$(x2346.PurchasingOrderNo)
            x2346.PurchasingOrderSeq = trim$(x2346.PurchasingOrderSeq)
            x2346.JobCardWorking = trim$(x2346.JobCardWorking)
            x2346.JobCardWorkingSeq = trim$(x2346.JobCardWorkingSeq)
            x2346.JobCardType = trim$(x2346.JobCardType)
            x2346.SalesOrderNo = trim$(x2346.SalesOrderNo)
            x2346.SalesOrderSeq = trim$(x2346.SalesOrderSeq)
            x2346.SalesOrderSno = trim$(x2346.SalesOrderSno)
            x2346.CheckOrderType = trim$(x2346.CheckOrderType)
            x2346.OrderNo = trim$(x2346.OrderNo)
            x2346.OrderNoSeq = trim$(x2346.OrderNoSeq)
            x2346.JobCard = trim$(x2346.JobCard)
            x2346.DateSync = trim$(x2346.DateSync)
            x2346.CheckSync = trim$(x2346.CheckSync)
            x2346.SlNo = trim$(x2346.SlNo)
            x2346.Check_Spec_1 = trim$(x2346.Check_Spec_1)
            x2346.Check_Spec_2 = trim$(x2346.Check_Spec_2)
            x2346.Check_Spec_3 = trim$(x2346.Check_Spec_3)
            x2346.Check_Spec_4 = trim$(x2346.Check_Spec_4)
            x2346.Check_Spec_5 = trim$(x2346.Check_Spec_5)
            x2346.Check_Spec_6 = trim$(x2346.Check_Spec_6)
            x2346.Check_Spec_7 = trim$(x2346.Check_Spec_7)
            x2346.Check_Spec_8 = trim$(x2346.Check_Spec_8)
            x2346.Check_Spec_9 = trim$(x2346.Check_Spec_9)
            x2346.Remark = trim$(x2346.Remark)
            x2346.TimeInsert = trim$(x2346.TimeInsert)
            x2346.TimeUpdate = trim$(x2346.TimeUpdate)
            x2346.DateInsert = trim$(x2346.DateInsert)
            x2346.DateUpdate = trim$(x2346.DateUpdate)
            x2346.InchargeInsert = trim$(x2346.InchargeInsert)
            x2346.InchargeUpdate = trim$(x2346.InchargeUpdate)

            If trim$(x2346.FactOrderNo) = "" Then x2346.FactOrderNo = Space(1)
            If trim$(x2346.FactOrderSeq) = "" Then x2346.FactOrderSeq = 0
            If trim$(x2346.CustSpecNo) = "" Then x2346.CustSpecNo = Space(1)
            If trim$(x2346.ProductCode) = "" Then x2346.ProductCode = Space(1)
            If trim$(x2346.Article) = "" Then x2346.Article = Space(1)
            If trim$(x2346.CustPoNo) = "" Then x2346.CustPoNo = Space(1)
            If trim$(x2346.FacPO) = "" Then x2346.FacPO = Space(1)
            If trim$(x2346.PONO) = "" Then x2346.PONO = Space(1)
            If trim$(x2346.PKO) = "" Then x2346.PKO = Space(1)
            If trim$(x2346.CustomerName) = "" Then x2346.CustomerName = Space(1)
            If trim$(x2346.DeclareNo) = "" Then x2346.DeclareNo = Space(1)
            If trim$(x2346.DateLable) = "" Then x2346.DateLable = Space(1)
            If trim$(x2346.InchargeDeclare) = "" Then x2346.InchargeDeclare = Space(1)
            If trim$(x2346.DeclareAmount) = "" Then x2346.DeclareAmount = 0
            If trim$(x2346.DeclareWgt) = "" Then x2346.DeclareWgt = 0
            If trim$(x2346.seSite) = "" Then x2346.seSite = Space(1)
            If trim$(x2346.cdSite) = "" Then x2346.cdSite = Space(1)
            If trim$(x2346.seDepartment) = "" Then x2346.seDepartment = Space(1)
            If trim$(x2346.cdDepartment) = "" Then x2346.cdDepartment = Space(1)
            If trim$(x2346.seFactory) = "" Then x2346.seFactory = Space(1)
            If trim$(x2346.cdFactory) = "" Then x2346.cdFactory = Space(1)
            If trim$(x2346.seLineProd) = "" Then x2346.seLineProd = Space(1)
            If trim$(x2346.cdLineProd) = "" Then x2346.cdLineProd = Space(1)
            If trim$(x2346.seSubProcess) = "" Then x2346.seSubProcess = Space(1)
            If trim$(x2346.cdSubProcess) = "" Then x2346.cdSubProcess = Space(1)
            If trim$(x2346.seGroupComponent) = "" Then x2346.seGroupComponent = Space(1)
            If trim$(x2346.cdGroupComponent) = "" Then x2346.cdGroupComponent = Space(1)
            If trim$(x2346.CustomerSupplier) = "" Then x2346.CustomerSupplier = Space(1)
            If trim$(x2346.Dseq) = "" Then x2346.Dseq = 0
            If trim$(x2346.Pseq) = "" Then x2346.Pseq = 0
            If trim$(x2346.AutokeyK3011) = "" Then x2346.AutokeyK3011 = 0
            If trim$(x2346.CheckRelationType) = "" Then x2346.CheckRelationType = Space(1)
            If trim$(x2346.ComponentName) = "" Then x2346.ComponentName = Space(1)
            If trim$(x2346.MaterialCode) = "" Then x2346.MaterialCode = Space(1)
            If trim$(x2346.Specification) = "" Then x2346.Specification = Space(1)
            If trim$(x2346.Width) = "" Then x2346.Width = Space(1)
            If trim$(x2346.Height) = "" Then x2346.Height = Space(1)
            If trim$(x2346.SizeNo) = "" Then x2346.SizeNo = Space(1)
            If trim$(x2346.SizeName) = "" Then x2346.SizeName = Space(1)
            If trim$(x2346.ColorCode) = "" Then x2346.ColorCode = Space(1)
            If trim$(x2346.ColorName) = "" Then x2346.ColorName = Space(1)
            If trim$(x2346.seOrigin) = "" Then x2346.seOrigin = Space(1)
            If trim$(x2346.cdOrigin) = "" Then x2346.cdOrigin = Space(1)
            If trim$(x2346.MaterialCheck) = "" Then x2346.MaterialCheck = Space(1)
            If trim$(x2346.seUnitPrice) = "" Then x2346.seUnitPrice = Space(1)
            If trim$(x2346.cdUnitPrice) = "" Then x2346.cdUnitPrice = Space(1)
            If trim$(x2346.seTax) = "" Then x2346.seTax = Space(1)
            If trim$(x2346.cdTax) = "" Then x2346.cdTax = Space(1)
            If trim$(x2346.seUnitMaterial) = "" Then x2346.seUnitMaterial = Space(1)
            If trim$(x2346.cdUnitMaterial) = "" Then x2346.cdUnitMaterial = Space(1)
            If trim$(x2346.seUnitPacking) = "" Then x2346.seUnitPacking = Space(1)
            If trim$(x2346.cdUnitPacking) = "" Then x2346.cdUnitPacking = Space(1)
            If trim$(x2346.UnitBaseCheck) = "" Then x2346.UnitBaseCheck = Space(1)
            If trim$(x2346.QtyBasic) = "" Then x2346.QtyBasic = 0
            If trim$(x2346.PricePurchasing) = "" Then x2346.PricePurchasing = 0
            If trim$(x2346.PriceMarket) = "" Then x2346.PriceMarket = 0
            If trim$(x2346.PriceExchange) = "" Then x2346.PriceExchange = 0
            If trim$(x2346.PriceExchangeAP) = "" Then x2346.PriceExchangeAP = 0
            If trim$(x2346.DateExchange) = "" Then x2346.DateExchange = Space(1)
            If trim$(x2346.PricePurchasingEX) = "" Then x2346.PricePurchasingEX = 0
            If trim$(x2346.PriceMarketEX) = "" Then x2346.PriceMarketEX = 0
            If trim$(x2346.PricePurchasingVND) = "" Then x2346.PricePurchasingVND = 0
            If trim$(x2346.PriceMarketVND) = "" Then x2346.PriceMarketVND = 0
            If trim$(x2346.AmountPurchasingEX) = "" Then x2346.AmountPurchasingEX = 0
            If trim$(x2346.AmountPurchasingVND) = "" Then x2346.AmountPurchasingVND = 0
            If trim$(x2346.AmountTaxEX) = "" Then x2346.AmountTaxEX = 0
            If trim$(x2346.AmountTaxVND) = "" Then x2346.AmountTaxVND = 0
            If trim$(x2346.seTax1) = "" Then x2346.seTax1 = Space(1)
            If trim$(x2346.cdTax1) = "" Then x2346.cdTax1 = Space(1)
            If trim$(x2346.PerTax1) = "" Then x2346.PerTax1 = 0
            If trim$(x2346.AmountTax1) = "" Then x2346.AmountTax1 = 0
            If trim$(x2346.seTax2) = "" Then x2346.seTax2 = Space(1)
            If trim$(x2346.cdTax2) = "" Then x2346.cdTax2 = Space(1)
            If trim$(x2346.PerTax2) = "" Then x2346.PerTax2 = 0
            If trim$(x2346.AmountTax2) = "" Then x2346.AmountTax2 = 0
            If trim$(x2346.seTax3) = "" Then x2346.seTax3 = Space(1)
            If trim$(x2346.cdTax3) = "" Then x2346.cdTax3 = Space(1)
            If trim$(x2346.PerTax3) = "" Then x2346.PerTax3 = 0
            If trim$(x2346.AmountTax3) = "" Then x2346.AmountTax3 = 0
            If trim$(x2346.QtyRequestPO) = "" Then x2346.QtyRequestPO = 0
            If trim$(x2346.QtyPurchasingNet) = "" Then x2346.QtyPurchasingNet = 0
            If trim$(x2346.QtyPurchasingMOQ) = "" Then x2346.QtyPurchasingMOQ = 0
            If trim$(x2346.QtyPurchasing) = "" Then x2346.QtyPurchasing = 0
            If trim$(x2346.PackPurchasing) = "" Then x2346.PackPurchasing = 0
            If trim$(x2346.QtyWarehouse) = "" Then x2346.QtyWarehouse = 0
            If trim$(x2346.PackWarehouse) = "" Then x2346.PackWarehouse = 0
            If trim$(x2346.QtyInbound) = "" Then x2346.QtyInbound = 0
            If trim$(x2346.PackInbound) = "" Then x2346.PackInbound = 0
            If trim$(x2346.QtyOutbound) = "" Then x2346.QtyOutbound = 0
            If trim$(x2346.PackOutbound) = "" Then x2346.PackOutbound = 0
            If trim$(x2346.AmountEX) = "" Then x2346.AmountEX = 0
            If trim$(x2346.AmountVND) = "" Then x2346.AmountVND = 0
            If trim$(x2346.AmountInBoundEX) = "" Then x2346.AmountInBoundEX = 0
            If trim$(x2346.AmountInBoundVND) = "" Then x2346.AmountInBoundVND = 0
            If trim$(x2346.DateDelivery) = "" Then x2346.DateDelivery = Space(1)
            If trim$(x2346.DateStart) = "" Then x2346.DateStart = Space(1)
            If trim$(x2346.DateFinish) = "" Then x2346.DateFinish = Space(1)
            If trim$(x2346.CheckPurchasing) = "" Then x2346.CheckPurchasing = Space(1)
            If trim$(x2346.DateAccept) = "" Then x2346.DateAccept = Space(1)
            If trim$(x2346.DatePosted) = "" Then x2346.DatePosted = Space(1)
            If trim$(x2346.IsPosted) = "" Then x2346.IsPosted = Space(1)
            If trim$(x2346.DateComplete) = "" Then x2346.DateComplete = Space(1)
            If trim$(x2346.DateApproval) = "" Then x2346.DateApproval = Space(1)
            If trim$(x2346.DateCancel) = "" Then x2346.DateCancel = Space(1)
            If trim$(x2346.CheckComplete) = "" Then x2346.CheckComplete = Space(1)
            If trim$(x2346.PurchasingOrderNo) = "" Then x2346.PurchasingOrderNo = Space(1)
            If trim$(x2346.PurchasingOrderSeq) = "" Then x2346.PurchasingOrderSeq = 0
            If trim$(x2346.JobCardWorking) = "" Then x2346.JobCardWorking = Space(1)
            If trim$(x2346.JobCardWorkingSeq) = "" Then x2346.JobCardWorkingSeq = Space(1)
            If trim$(x2346.JobCardType) = "" Then x2346.JobCardType = Space(1)
            If trim$(x2346.SalesOrderNo) = "" Then x2346.SalesOrderNo = Space(1)
            If trim$(x2346.SalesOrderSeq) = "" Then x2346.SalesOrderSeq = Space(1)
            If trim$(x2346.SalesOrderSno) = "" Then x2346.SalesOrderSno = Space(1)
            If trim$(x2346.CheckOrderType) = "" Then x2346.CheckOrderType = Space(1)
            If trim$(x2346.OrderNo) = "" Then x2346.OrderNo = Space(1)
            If trim$(x2346.OrderNoSeq) = "" Then x2346.OrderNoSeq = Space(1)
            If trim$(x2346.JobCard) = "" Then x2346.JobCard = Space(1)
            If trim$(x2346.DateSync) = "" Then x2346.DateSync = Space(1)
            If trim$(x2346.CheckSync) = "" Then x2346.CheckSync = Space(1)
            If trim$(x2346.SlNo) = "" Then x2346.SlNo = Space(1)
            If trim$(x2346.Check_Spec_1) = "" Then x2346.Check_Spec_1 = Space(1)
            If trim$(x2346.Check_Spec_2) = "" Then x2346.Check_Spec_2 = Space(1)
            If trim$(x2346.Check_Spec_3) = "" Then x2346.Check_Spec_3 = Space(1)
            If trim$(x2346.Check_Spec_4) = "" Then x2346.Check_Spec_4 = Space(1)
            If trim$(x2346.Check_Spec_5) = "" Then x2346.Check_Spec_5 = Space(1)
            If trim$(x2346.Check_Spec_6) = "" Then x2346.Check_Spec_6 = Space(1)
            If trim$(x2346.Check_Spec_7) = "" Then x2346.Check_Spec_7 = Space(1)
            If trim$(x2346.Check_Spec_8) = "" Then x2346.Check_Spec_8 = Space(1)
            If trim$(x2346.Check_Spec_9) = "" Then x2346.Check_Spec_9 = Space(1)
            If trim$(x2346.Remark) = "" Then x2346.Remark = Space(1)
            If trim$(x2346.TimeInsert) = "" Then x2346.TimeInsert = Space(1)
            If trim$(x2346.TimeUpdate) = "" Then x2346.TimeUpdate = Space(1)
            If trim$(x2346.DateInsert) = "" Then x2346.DateInsert = Space(1)
            If trim$(x2346.DateUpdate) = "" Then x2346.DateUpdate = Space(1)
            If trim$(x2346.InchargeInsert) = "" Then x2346.InchargeInsert = Space(1)
            If trim$(x2346.InchargeUpdate) = "" Then x2346.InchargeUpdate = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K2346_MOVE(rs2346 As SqlClient.SqlDataReader)
        Try

            Call D2346_CLEAR()

            If IsdbNull(rs2346!K2346_FactOrderNo) = False Then D2346.FactOrderNo = Trim$(rs2346!K2346_FactOrderNo)
            If IsdbNull(rs2346!K2346_FactOrderSeq) = False Then D2346.FactOrderSeq = Trim$(rs2346!K2346_FactOrderSeq)
            If IsdbNull(rs2346!K2346_CustSpecNo) = False Then D2346.CustSpecNo = Trim$(rs2346!K2346_CustSpecNo)
            If IsdbNull(rs2346!K2346_ProductCode) = False Then D2346.ProductCode = Trim$(rs2346!K2346_ProductCode)
            If IsdbNull(rs2346!K2346_Article) = False Then D2346.Article = Trim$(rs2346!K2346_Article)
            If IsdbNull(rs2346!K2346_CustPoNo) = False Then D2346.CustPoNo = Trim$(rs2346!K2346_CustPoNo)
            If IsdbNull(rs2346!K2346_FacPO) = False Then D2346.FacPO = Trim$(rs2346!K2346_FacPO)
            If IsdbNull(rs2346!K2346_PONO) = False Then D2346.PONO = Trim$(rs2346!K2346_PONO)
            If IsdbNull(rs2346!K2346_PKO) = False Then D2346.PKO = Trim$(rs2346!K2346_PKO)
            If IsdbNull(rs2346!K2346_CustomerName) = False Then D2346.CustomerName = Trim$(rs2346!K2346_CustomerName)
            If IsdbNull(rs2346!K2346_DeclareNo) = False Then D2346.DeclareNo = Trim$(rs2346!K2346_DeclareNo)
            If IsdbNull(rs2346!K2346_DateLable) = False Then D2346.DateLable = Trim$(rs2346!K2346_DateLable)
            If IsdbNull(rs2346!K2346_InchargeDeclare) = False Then D2346.InchargeDeclare = Trim$(rs2346!K2346_InchargeDeclare)
            If IsdbNull(rs2346!K2346_DeclareAmount) = False Then D2346.DeclareAmount = Trim$(rs2346!K2346_DeclareAmount)
            If IsdbNull(rs2346!K2346_DeclareWgt) = False Then D2346.DeclareWgt = Trim$(rs2346!K2346_DeclareWgt)
            If IsdbNull(rs2346!K2346_seSite) = False Then D2346.seSite = Trim$(rs2346!K2346_seSite)
            If IsdbNull(rs2346!K2346_cdSite) = False Then D2346.cdSite = Trim$(rs2346!K2346_cdSite)
            If IsdbNull(rs2346!K2346_seDepartment) = False Then D2346.seDepartment = Trim$(rs2346!K2346_seDepartment)
            If IsdbNull(rs2346!K2346_cdDepartment) = False Then D2346.cdDepartment = Trim$(rs2346!K2346_cdDepartment)
            If IsdbNull(rs2346!K2346_seFactory) = False Then D2346.seFactory = Trim$(rs2346!K2346_seFactory)
            If IsdbNull(rs2346!K2346_cdFactory) = False Then D2346.cdFactory = Trim$(rs2346!K2346_cdFactory)
            If IsdbNull(rs2346!K2346_seLineProd) = False Then D2346.seLineProd = Trim$(rs2346!K2346_seLineProd)
            If IsdbNull(rs2346!K2346_cdLineProd) = False Then D2346.cdLineProd = Trim$(rs2346!K2346_cdLineProd)
            If IsdbNull(rs2346!K2346_seSubProcess) = False Then D2346.seSubProcess = Trim$(rs2346!K2346_seSubProcess)
            If IsdbNull(rs2346!K2346_cdSubProcess) = False Then D2346.cdSubProcess = Trim$(rs2346!K2346_cdSubProcess)
            If IsdbNull(rs2346!K2346_seGroupComponent) = False Then D2346.seGroupComponent = Trim$(rs2346!K2346_seGroupComponent)
            If IsdbNull(rs2346!K2346_cdGroupComponent) = False Then D2346.cdGroupComponent = Trim$(rs2346!K2346_cdGroupComponent)
            If IsdbNull(rs2346!K2346_CustomerSupplier) = False Then D2346.CustomerSupplier = Trim$(rs2346!K2346_CustomerSupplier)
            If IsdbNull(rs2346!K2346_Dseq) = False Then D2346.Dseq = Trim$(rs2346!K2346_Dseq)
            If IsdbNull(rs2346!K2346_Pseq) = False Then D2346.Pseq = Trim$(rs2346!K2346_Pseq)
            If IsdbNull(rs2346!K2346_AutokeyK3011) = False Then D2346.AutokeyK3011 = Trim$(rs2346!K2346_AutokeyK3011)
            If IsdbNull(rs2346!K2346_CheckRelationType) = False Then D2346.CheckRelationType = Trim$(rs2346!K2346_CheckRelationType)
            If IsdbNull(rs2346!K2346_ComponentName) = False Then D2346.ComponentName = Trim$(rs2346!K2346_ComponentName)
            If IsdbNull(rs2346!K2346_MaterialCode) = False Then D2346.MaterialCode = Trim$(rs2346!K2346_MaterialCode)
            If IsdbNull(rs2346!K2346_Specification) = False Then D2346.Specification = Trim$(rs2346!K2346_Specification)
            If IsdbNull(rs2346!K2346_Width) = False Then D2346.Width = Trim$(rs2346!K2346_Width)
            If IsdbNull(rs2346!K2346_Height) = False Then D2346.Height = Trim$(rs2346!K2346_Height)
            If IsdbNull(rs2346!K2346_SizeNo) = False Then D2346.SizeNo = Trim$(rs2346!K2346_SizeNo)
            If IsdbNull(rs2346!K2346_SizeName) = False Then D2346.SizeName = Trim$(rs2346!K2346_SizeName)
            If IsdbNull(rs2346!K2346_ColorCode) = False Then D2346.ColorCode = Trim$(rs2346!K2346_ColorCode)
            If IsdbNull(rs2346!K2346_ColorName) = False Then D2346.ColorName = Trim$(rs2346!K2346_ColorName)
            If IsdbNull(rs2346!K2346_seOrigin) = False Then D2346.seOrigin = Trim$(rs2346!K2346_seOrigin)
            If IsdbNull(rs2346!K2346_cdOrigin) = False Then D2346.cdOrigin = Trim$(rs2346!K2346_cdOrigin)
            If IsdbNull(rs2346!K2346_MaterialCheck) = False Then D2346.MaterialCheck = Trim$(rs2346!K2346_MaterialCheck)
            If IsdbNull(rs2346!K2346_seUnitPrice) = False Then D2346.seUnitPrice = Trim$(rs2346!K2346_seUnitPrice)
            If IsdbNull(rs2346!K2346_cdUnitPrice) = False Then D2346.cdUnitPrice = Trim$(rs2346!K2346_cdUnitPrice)
            If IsdbNull(rs2346!K2346_seTax) = False Then D2346.seTax = Trim$(rs2346!K2346_seTax)
            If IsdbNull(rs2346!K2346_cdTax) = False Then D2346.cdTax = Trim$(rs2346!K2346_cdTax)
            If IsdbNull(rs2346!K2346_seUnitMaterial) = False Then D2346.seUnitMaterial = Trim$(rs2346!K2346_seUnitMaterial)
            If IsdbNull(rs2346!K2346_cdUnitMaterial) = False Then D2346.cdUnitMaterial = Trim$(rs2346!K2346_cdUnitMaterial)
            If IsdbNull(rs2346!K2346_seUnitPacking) = False Then D2346.seUnitPacking = Trim$(rs2346!K2346_seUnitPacking)
            If IsdbNull(rs2346!K2346_cdUnitPacking) = False Then D2346.cdUnitPacking = Trim$(rs2346!K2346_cdUnitPacking)
            If IsdbNull(rs2346!K2346_UnitBaseCheck) = False Then D2346.UnitBaseCheck = Trim$(rs2346!K2346_UnitBaseCheck)
            If IsdbNull(rs2346!K2346_QtyBasic) = False Then D2346.QtyBasic = Trim$(rs2346!K2346_QtyBasic)
            If IsdbNull(rs2346!K2346_PricePurchasing) = False Then D2346.PricePurchasing = Trim$(rs2346!K2346_PricePurchasing)
            If IsdbNull(rs2346!K2346_PriceMarket) = False Then D2346.PriceMarket = Trim$(rs2346!K2346_PriceMarket)
            If IsdbNull(rs2346!K2346_PriceExchange) = False Then D2346.PriceExchange = Trim$(rs2346!K2346_PriceExchange)
            If IsdbNull(rs2346!K2346_PriceExchangeAP) = False Then D2346.PriceExchangeAP = Trim$(rs2346!K2346_PriceExchangeAP)
            If IsdbNull(rs2346!K2346_DateExchange) = False Then D2346.DateExchange = Trim$(rs2346!K2346_DateExchange)
            If IsdbNull(rs2346!K2346_PricePurchasingEX) = False Then D2346.PricePurchasingEX = Trim$(rs2346!K2346_PricePurchasingEX)
            If IsdbNull(rs2346!K2346_PriceMarketEX) = False Then D2346.PriceMarketEX = Trim$(rs2346!K2346_PriceMarketEX)
            If IsdbNull(rs2346!K2346_PricePurchasingVND) = False Then D2346.PricePurchasingVND = Trim$(rs2346!K2346_PricePurchasingVND)
            If IsdbNull(rs2346!K2346_PriceMarketVND) = False Then D2346.PriceMarketVND = Trim$(rs2346!K2346_PriceMarketVND)
            If IsdbNull(rs2346!K2346_AmountPurchasingEX) = False Then D2346.AmountPurchasingEX = Trim$(rs2346!K2346_AmountPurchasingEX)
            If IsdbNull(rs2346!K2346_AmountPurchasingVND) = False Then D2346.AmountPurchasingVND = Trim$(rs2346!K2346_AmountPurchasingVND)
            If IsdbNull(rs2346!K2346_AmountTaxEX) = False Then D2346.AmountTaxEX = Trim$(rs2346!K2346_AmountTaxEX)
            If IsdbNull(rs2346!K2346_AmountTaxVND) = False Then D2346.AmountTaxVND = Trim$(rs2346!K2346_AmountTaxVND)
            If IsdbNull(rs2346!K2346_seTax1) = False Then D2346.seTax1 = Trim$(rs2346!K2346_seTax1)
            If IsdbNull(rs2346!K2346_cdTax1) = False Then D2346.cdTax1 = Trim$(rs2346!K2346_cdTax1)
            If IsdbNull(rs2346!K2346_PerTax1) = False Then D2346.PerTax1 = Trim$(rs2346!K2346_PerTax1)
            If IsdbNull(rs2346!K2346_AmountTax1) = False Then D2346.AmountTax1 = Trim$(rs2346!K2346_AmountTax1)
            If IsdbNull(rs2346!K2346_seTax2) = False Then D2346.seTax2 = Trim$(rs2346!K2346_seTax2)
            If IsdbNull(rs2346!K2346_cdTax2) = False Then D2346.cdTax2 = Trim$(rs2346!K2346_cdTax2)
            If IsdbNull(rs2346!K2346_PerTax2) = False Then D2346.PerTax2 = Trim$(rs2346!K2346_PerTax2)
            If IsdbNull(rs2346!K2346_AmountTax2) = False Then D2346.AmountTax2 = Trim$(rs2346!K2346_AmountTax2)
            If IsdbNull(rs2346!K2346_seTax3) = False Then D2346.seTax3 = Trim$(rs2346!K2346_seTax3)
            If IsdbNull(rs2346!K2346_cdTax3) = False Then D2346.cdTax3 = Trim$(rs2346!K2346_cdTax3)
            If IsdbNull(rs2346!K2346_PerTax3) = False Then D2346.PerTax3 = Trim$(rs2346!K2346_PerTax3)
            If IsdbNull(rs2346!K2346_AmountTax3) = False Then D2346.AmountTax3 = Trim$(rs2346!K2346_AmountTax3)
            If IsdbNull(rs2346!K2346_QtyRequestPO) = False Then D2346.QtyRequestPO = Trim$(rs2346!K2346_QtyRequestPO)
            If IsdbNull(rs2346!K2346_QtyPurchasingNet) = False Then D2346.QtyPurchasingNet = Trim$(rs2346!K2346_QtyPurchasingNet)
            If IsdbNull(rs2346!K2346_QtyPurchasingMOQ) = False Then D2346.QtyPurchasingMOQ = Trim$(rs2346!K2346_QtyPurchasingMOQ)
            If IsdbNull(rs2346!K2346_QtyPurchasing) = False Then D2346.QtyPurchasing = Trim$(rs2346!K2346_QtyPurchasing)
            If IsdbNull(rs2346!K2346_PackPurchasing) = False Then D2346.PackPurchasing = Trim$(rs2346!K2346_PackPurchasing)
            If IsdbNull(rs2346!K2346_QtyWarehouse) = False Then D2346.QtyWarehouse = Trim$(rs2346!K2346_QtyWarehouse)
            If IsdbNull(rs2346!K2346_PackWarehouse) = False Then D2346.PackWarehouse = Trim$(rs2346!K2346_PackWarehouse)
            If IsdbNull(rs2346!K2346_QtyInbound) = False Then D2346.QtyInbound = Trim$(rs2346!K2346_QtyInbound)
            If IsdbNull(rs2346!K2346_PackInbound) = False Then D2346.PackInbound = Trim$(rs2346!K2346_PackInbound)
            If IsdbNull(rs2346!K2346_QtyOutbound) = False Then D2346.QtyOutbound = Trim$(rs2346!K2346_QtyOutbound)
            If IsdbNull(rs2346!K2346_PackOutbound) = False Then D2346.PackOutbound = Trim$(rs2346!K2346_PackOutbound)
            If IsdbNull(rs2346!K2346_AmountEX) = False Then D2346.AmountEX = Trim$(rs2346!K2346_AmountEX)
            If IsdbNull(rs2346!K2346_AmountVND) = False Then D2346.AmountVND = Trim$(rs2346!K2346_AmountVND)
            If IsdbNull(rs2346!K2346_AmountInBoundEX) = False Then D2346.AmountInBoundEX = Trim$(rs2346!K2346_AmountInBoundEX)
            If IsdbNull(rs2346!K2346_AmountInBoundVND) = False Then D2346.AmountInBoundVND = Trim$(rs2346!K2346_AmountInBoundVND)
            If IsdbNull(rs2346!K2346_DateDelivery) = False Then D2346.DateDelivery = Trim$(rs2346!K2346_DateDelivery)
            If IsdbNull(rs2346!K2346_DateStart) = False Then D2346.DateStart = Trim$(rs2346!K2346_DateStart)
            If IsdbNull(rs2346!K2346_DateFinish) = False Then D2346.DateFinish = Trim$(rs2346!K2346_DateFinish)
            If IsdbNull(rs2346!K2346_CheckPurchasing) = False Then D2346.CheckPurchasing = Trim$(rs2346!K2346_CheckPurchasing)
            If IsdbNull(rs2346!K2346_DateAccept) = False Then D2346.DateAccept = Trim$(rs2346!K2346_DateAccept)
            If IsdbNull(rs2346!K2346_DatePosted) = False Then D2346.DatePosted = Trim$(rs2346!K2346_DatePosted)
            If IsdbNull(rs2346!K2346_IsPosted) = False Then D2346.IsPosted = Trim$(rs2346!K2346_IsPosted)
            If IsdbNull(rs2346!K2346_DateComplete) = False Then D2346.DateComplete = Trim$(rs2346!K2346_DateComplete)
            If IsdbNull(rs2346!K2346_DateApproval) = False Then D2346.DateApproval = Trim$(rs2346!K2346_DateApproval)
            If IsdbNull(rs2346!K2346_DateCancel) = False Then D2346.DateCancel = Trim$(rs2346!K2346_DateCancel)
            If IsdbNull(rs2346!K2346_CheckComplete) = False Then D2346.CheckComplete = Trim$(rs2346!K2346_CheckComplete)
            If IsdbNull(rs2346!K2346_PurchasingOrderNo) = False Then D2346.PurchasingOrderNo = Trim$(rs2346!K2346_PurchasingOrderNo)
            If IsdbNull(rs2346!K2346_PurchasingOrderSeq) = False Then D2346.PurchasingOrderSeq = Trim$(rs2346!K2346_PurchasingOrderSeq)
            If IsdbNull(rs2346!K2346_JobCardWorking) = False Then D2346.JobCardWorking = Trim$(rs2346!K2346_JobCardWorking)
            If IsdbNull(rs2346!K2346_JobCardWorkingSeq) = False Then D2346.JobCardWorkingSeq = Trim$(rs2346!K2346_JobCardWorkingSeq)
            If IsdbNull(rs2346!K2346_JobCardType) = False Then D2346.JobCardType = Trim$(rs2346!K2346_JobCardType)
            If IsdbNull(rs2346!K2346_SalesOrderNo) = False Then D2346.SalesOrderNo = Trim$(rs2346!K2346_SalesOrderNo)
            If IsdbNull(rs2346!K2346_SalesOrderSeq) = False Then D2346.SalesOrderSeq = Trim$(rs2346!K2346_SalesOrderSeq)
            If IsdbNull(rs2346!K2346_SalesOrderSno) = False Then D2346.SalesOrderSno = Trim$(rs2346!K2346_SalesOrderSno)
            If IsdbNull(rs2346!K2346_CheckOrderType) = False Then D2346.CheckOrderType = Trim$(rs2346!K2346_CheckOrderType)
            If IsdbNull(rs2346!K2346_OrderNo) = False Then D2346.OrderNo = Trim$(rs2346!K2346_OrderNo)
            If IsdbNull(rs2346!K2346_OrderNoSeq) = False Then D2346.OrderNoSeq = Trim$(rs2346!K2346_OrderNoSeq)
            If IsdbNull(rs2346!K2346_JobCard) = False Then D2346.JobCard = Trim$(rs2346!K2346_JobCard)
            If IsdbNull(rs2346!K2346_DateSync) = False Then D2346.DateSync = Trim$(rs2346!K2346_DateSync)
            If IsdbNull(rs2346!K2346_CheckSync) = False Then D2346.CheckSync = Trim$(rs2346!K2346_CheckSync)
            If IsdbNull(rs2346!K2346_SlNo) = False Then D2346.SlNo = Trim$(rs2346!K2346_SlNo)
            If IsdbNull(rs2346!K2346_Check_Spec_1) = False Then D2346.Check_Spec_1 = Trim$(rs2346!K2346_Check_Spec_1)
            If IsdbNull(rs2346!K2346_Check_Spec_2) = False Then D2346.Check_Spec_2 = Trim$(rs2346!K2346_Check_Spec_2)
            If IsdbNull(rs2346!K2346_Check_Spec_3) = False Then D2346.Check_Spec_3 = Trim$(rs2346!K2346_Check_Spec_3)
            If IsdbNull(rs2346!K2346_Check_Spec_4) = False Then D2346.Check_Spec_4 = Trim$(rs2346!K2346_Check_Spec_4)
            If IsdbNull(rs2346!K2346_Check_Spec_5) = False Then D2346.Check_Spec_5 = Trim$(rs2346!K2346_Check_Spec_5)
            If IsdbNull(rs2346!K2346_Check_Spec_6) = False Then D2346.Check_Spec_6 = Trim$(rs2346!K2346_Check_Spec_6)
            If IsdbNull(rs2346!K2346_Check_Spec_7) = False Then D2346.Check_Spec_7 = Trim$(rs2346!K2346_Check_Spec_7)
            If IsdbNull(rs2346!K2346_Check_Spec_8) = False Then D2346.Check_Spec_8 = Trim$(rs2346!K2346_Check_Spec_8)
            If IsdbNull(rs2346!K2346_Check_Spec_9) = False Then D2346.Check_Spec_9 = Trim$(rs2346!K2346_Check_Spec_9)
            If IsdbNull(rs2346!K2346_Remark) = False Then D2346.Remark = Trim$(rs2346!K2346_Remark)
            If IsdbNull(rs2346!K2346_TimeInsert) = False Then D2346.TimeInsert = Trim$(rs2346!K2346_TimeInsert)
            If IsdbNull(rs2346!K2346_TimeUpdate) = False Then D2346.TimeUpdate = Trim$(rs2346!K2346_TimeUpdate)
            If IsdbNull(rs2346!K2346_DateInsert) = False Then D2346.DateInsert = Trim$(rs2346!K2346_DateInsert)
            If IsdbNull(rs2346!K2346_DateUpdate) = False Then D2346.DateUpdate = Trim$(rs2346!K2346_DateUpdate)
            If IsdbNull(rs2346!K2346_InchargeInsert) = False Then D2346.InchargeInsert = Trim$(rs2346!K2346_InchargeInsert)
            If IsdbNull(rs2346!K2346_InchargeUpdate) = False Then D2346.InchargeUpdate = Trim$(rs2346!K2346_InchargeUpdate)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K2346_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K2346_MOVE(rs2346 As DataRow)
        Try

            Call D2346_CLEAR()

            If IsdbNull(rs2346!K2346_FactOrderNo) = False Then D2346.FactOrderNo = Trim$(rs2346!K2346_FactOrderNo)
            If IsdbNull(rs2346!K2346_FactOrderSeq) = False Then D2346.FactOrderSeq = Trim$(rs2346!K2346_FactOrderSeq)
            If IsdbNull(rs2346!K2346_CustSpecNo) = False Then D2346.CustSpecNo = Trim$(rs2346!K2346_CustSpecNo)
            If IsdbNull(rs2346!K2346_ProductCode) = False Then D2346.ProductCode = Trim$(rs2346!K2346_ProductCode)
            If IsdbNull(rs2346!K2346_Article) = False Then D2346.Article = Trim$(rs2346!K2346_Article)
            If IsdbNull(rs2346!K2346_CustPoNo) = False Then D2346.CustPoNo = Trim$(rs2346!K2346_CustPoNo)
            If IsdbNull(rs2346!K2346_FacPO) = False Then D2346.FacPO = Trim$(rs2346!K2346_FacPO)
            If IsdbNull(rs2346!K2346_PONO) = False Then D2346.PONO = Trim$(rs2346!K2346_PONO)
            If IsdbNull(rs2346!K2346_PKO) = False Then D2346.PKO = Trim$(rs2346!K2346_PKO)
            If IsdbNull(rs2346!K2346_CustomerName) = False Then D2346.CustomerName = Trim$(rs2346!K2346_CustomerName)
            If IsdbNull(rs2346!K2346_DeclareNo) = False Then D2346.DeclareNo = Trim$(rs2346!K2346_DeclareNo)
            If IsdbNull(rs2346!K2346_DateLable) = False Then D2346.DateLable = Trim$(rs2346!K2346_DateLable)
            If IsdbNull(rs2346!K2346_InchargeDeclare) = False Then D2346.InchargeDeclare = Trim$(rs2346!K2346_InchargeDeclare)
            If IsdbNull(rs2346!K2346_DeclareAmount) = False Then D2346.DeclareAmount = Trim$(rs2346!K2346_DeclareAmount)
            If IsdbNull(rs2346!K2346_DeclareWgt) = False Then D2346.DeclareWgt = Trim$(rs2346!K2346_DeclareWgt)
            If IsdbNull(rs2346!K2346_seSite) = False Then D2346.seSite = Trim$(rs2346!K2346_seSite)
            If IsdbNull(rs2346!K2346_cdSite) = False Then D2346.cdSite = Trim$(rs2346!K2346_cdSite)
            If IsdbNull(rs2346!K2346_seDepartment) = False Then D2346.seDepartment = Trim$(rs2346!K2346_seDepartment)
            If IsdbNull(rs2346!K2346_cdDepartment) = False Then D2346.cdDepartment = Trim$(rs2346!K2346_cdDepartment)
            If IsdbNull(rs2346!K2346_seFactory) = False Then D2346.seFactory = Trim$(rs2346!K2346_seFactory)
            If IsdbNull(rs2346!K2346_cdFactory) = False Then D2346.cdFactory = Trim$(rs2346!K2346_cdFactory)
            If IsdbNull(rs2346!K2346_seLineProd) = False Then D2346.seLineProd = Trim$(rs2346!K2346_seLineProd)
            If IsdbNull(rs2346!K2346_cdLineProd) = False Then D2346.cdLineProd = Trim$(rs2346!K2346_cdLineProd)
            If IsdbNull(rs2346!K2346_seSubProcess) = False Then D2346.seSubProcess = Trim$(rs2346!K2346_seSubProcess)
            If IsdbNull(rs2346!K2346_cdSubProcess) = False Then D2346.cdSubProcess = Trim$(rs2346!K2346_cdSubProcess)
            If IsdbNull(rs2346!K2346_seGroupComponent) = False Then D2346.seGroupComponent = Trim$(rs2346!K2346_seGroupComponent)
            If IsdbNull(rs2346!K2346_cdGroupComponent) = False Then D2346.cdGroupComponent = Trim$(rs2346!K2346_cdGroupComponent)
            If IsdbNull(rs2346!K2346_CustomerSupplier) = False Then D2346.CustomerSupplier = Trim$(rs2346!K2346_CustomerSupplier)
            If IsdbNull(rs2346!K2346_Dseq) = False Then D2346.Dseq = Trim$(rs2346!K2346_Dseq)
            If IsdbNull(rs2346!K2346_Pseq) = False Then D2346.Pseq = Trim$(rs2346!K2346_Pseq)
            If IsdbNull(rs2346!K2346_AutokeyK3011) = False Then D2346.AutokeyK3011 = Trim$(rs2346!K2346_AutokeyK3011)
            If IsdbNull(rs2346!K2346_CheckRelationType) = False Then D2346.CheckRelationType = Trim$(rs2346!K2346_CheckRelationType)
            If IsdbNull(rs2346!K2346_ComponentName) = False Then D2346.ComponentName = Trim$(rs2346!K2346_ComponentName)
            If IsdbNull(rs2346!K2346_MaterialCode) = False Then D2346.MaterialCode = Trim$(rs2346!K2346_MaterialCode)
            If IsdbNull(rs2346!K2346_Specification) = False Then D2346.Specification = Trim$(rs2346!K2346_Specification)
            If IsdbNull(rs2346!K2346_Width) = False Then D2346.Width = Trim$(rs2346!K2346_Width)
            If IsdbNull(rs2346!K2346_Height) = False Then D2346.Height = Trim$(rs2346!K2346_Height)
            If IsdbNull(rs2346!K2346_SizeNo) = False Then D2346.SizeNo = Trim$(rs2346!K2346_SizeNo)
            If IsdbNull(rs2346!K2346_SizeName) = False Then D2346.SizeName = Trim$(rs2346!K2346_SizeName)
            If IsdbNull(rs2346!K2346_ColorCode) = False Then D2346.ColorCode = Trim$(rs2346!K2346_ColorCode)
            If IsdbNull(rs2346!K2346_ColorName) = False Then D2346.ColorName = Trim$(rs2346!K2346_ColorName)
            If IsdbNull(rs2346!K2346_seOrigin) = False Then D2346.seOrigin = Trim$(rs2346!K2346_seOrigin)
            If IsdbNull(rs2346!K2346_cdOrigin) = False Then D2346.cdOrigin = Trim$(rs2346!K2346_cdOrigin)
            If IsdbNull(rs2346!K2346_MaterialCheck) = False Then D2346.MaterialCheck = Trim$(rs2346!K2346_MaterialCheck)
            If IsdbNull(rs2346!K2346_seUnitPrice) = False Then D2346.seUnitPrice = Trim$(rs2346!K2346_seUnitPrice)
            If IsdbNull(rs2346!K2346_cdUnitPrice) = False Then D2346.cdUnitPrice = Trim$(rs2346!K2346_cdUnitPrice)
            If IsdbNull(rs2346!K2346_seTax) = False Then D2346.seTax = Trim$(rs2346!K2346_seTax)
            If IsdbNull(rs2346!K2346_cdTax) = False Then D2346.cdTax = Trim$(rs2346!K2346_cdTax)
            If IsdbNull(rs2346!K2346_seUnitMaterial) = False Then D2346.seUnitMaterial = Trim$(rs2346!K2346_seUnitMaterial)
            If IsdbNull(rs2346!K2346_cdUnitMaterial) = False Then D2346.cdUnitMaterial = Trim$(rs2346!K2346_cdUnitMaterial)
            If IsdbNull(rs2346!K2346_seUnitPacking) = False Then D2346.seUnitPacking = Trim$(rs2346!K2346_seUnitPacking)
            If IsdbNull(rs2346!K2346_cdUnitPacking) = False Then D2346.cdUnitPacking = Trim$(rs2346!K2346_cdUnitPacking)
            If IsdbNull(rs2346!K2346_UnitBaseCheck) = False Then D2346.UnitBaseCheck = Trim$(rs2346!K2346_UnitBaseCheck)
            If IsdbNull(rs2346!K2346_QtyBasic) = False Then D2346.QtyBasic = Trim$(rs2346!K2346_QtyBasic)
            If IsdbNull(rs2346!K2346_PricePurchasing) = False Then D2346.PricePurchasing = Trim$(rs2346!K2346_PricePurchasing)
            If IsdbNull(rs2346!K2346_PriceMarket) = False Then D2346.PriceMarket = Trim$(rs2346!K2346_PriceMarket)
            If IsdbNull(rs2346!K2346_PriceExchange) = False Then D2346.PriceExchange = Trim$(rs2346!K2346_PriceExchange)
            If IsdbNull(rs2346!K2346_PriceExchangeAP) = False Then D2346.PriceExchangeAP = Trim$(rs2346!K2346_PriceExchangeAP)
            If IsdbNull(rs2346!K2346_DateExchange) = False Then D2346.DateExchange = Trim$(rs2346!K2346_DateExchange)
            If IsdbNull(rs2346!K2346_PricePurchasingEX) = False Then D2346.PricePurchasingEX = Trim$(rs2346!K2346_PricePurchasingEX)
            If IsdbNull(rs2346!K2346_PriceMarketEX) = False Then D2346.PriceMarketEX = Trim$(rs2346!K2346_PriceMarketEX)
            If IsdbNull(rs2346!K2346_PricePurchasingVND) = False Then D2346.PricePurchasingVND = Trim$(rs2346!K2346_PricePurchasingVND)
            If IsdbNull(rs2346!K2346_PriceMarketVND) = False Then D2346.PriceMarketVND = Trim$(rs2346!K2346_PriceMarketVND)
            If IsdbNull(rs2346!K2346_AmountPurchasingEX) = False Then D2346.AmountPurchasingEX = Trim$(rs2346!K2346_AmountPurchasingEX)
            If IsdbNull(rs2346!K2346_AmountPurchasingVND) = False Then D2346.AmountPurchasingVND = Trim$(rs2346!K2346_AmountPurchasingVND)
            If IsdbNull(rs2346!K2346_AmountTaxEX) = False Then D2346.AmountTaxEX = Trim$(rs2346!K2346_AmountTaxEX)
            If IsdbNull(rs2346!K2346_AmountTaxVND) = False Then D2346.AmountTaxVND = Trim$(rs2346!K2346_AmountTaxVND)
            If IsdbNull(rs2346!K2346_seTax1) = False Then D2346.seTax1 = Trim$(rs2346!K2346_seTax1)
            If IsdbNull(rs2346!K2346_cdTax1) = False Then D2346.cdTax1 = Trim$(rs2346!K2346_cdTax1)
            If IsdbNull(rs2346!K2346_PerTax1) = False Then D2346.PerTax1 = Trim$(rs2346!K2346_PerTax1)
            If IsdbNull(rs2346!K2346_AmountTax1) = False Then D2346.AmountTax1 = Trim$(rs2346!K2346_AmountTax1)
            If IsdbNull(rs2346!K2346_seTax2) = False Then D2346.seTax2 = Trim$(rs2346!K2346_seTax2)
            If IsdbNull(rs2346!K2346_cdTax2) = False Then D2346.cdTax2 = Trim$(rs2346!K2346_cdTax2)
            If IsdbNull(rs2346!K2346_PerTax2) = False Then D2346.PerTax2 = Trim$(rs2346!K2346_PerTax2)
            If IsdbNull(rs2346!K2346_AmountTax2) = False Then D2346.AmountTax2 = Trim$(rs2346!K2346_AmountTax2)
            If IsdbNull(rs2346!K2346_seTax3) = False Then D2346.seTax3 = Trim$(rs2346!K2346_seTax3)
            If IsdbNull(rs2346!K2346_cdTax3) = False Then D2346.cdTax3 = Trim$(rs2346!K2346_cdTax3)
            If IsdbNull(rs2346!K2346_PerTax3) = False Then D2346.PerTax3 = Trim$(rs2346!K2346_PerTax3)
            If IsdbNull(rs2346!K2346_AmountTax3) = False Then D2346.AmountTax3 = Trim$(rs2346!K2346_AmountTax3)
            If IsdbNull(rs2346!K2346_QtyRequestPO) = False Then D2346.QtyRequestPO = Trim$(rs2346!K2346_QtyRequestPO)
            If IsdbNull(rs2346!K2346_QtyPurchasingNet) = False Then D2346.QtyPurchasingNet = Trim$(rs2346!K2346_QtyPurchasingNet)
            If IsdbNull(rs2346!K2346_QtyPurchasingMOQ) = False Then D2346.QtyPurchasingMOQ = Trim$(rs2346!K2346_QtyPurchasingMOQ)
            If IsdbNull(rs2346!K2346_QtyPurchasing) = False Then D2346.QtyPurchasing = Trim$(rs2346!K2346_QtyPurchasing)
            If IsdbNull(rs2346!K2346_PackPurchasing) = False Then D2346.PackPurchasing = Trim$(rs2346!K2346_PackPurchasing)
            If IsdbNull(rs2346!K2346_QtyWarehouse) = False Then D2346.QtyWarehouse = Trim$(rs2346!K2346_QtyWarehouse)
            If IsdbNull(rs2346!K2346_PackWarehouse) = False Then D2346.PackWarehouse = Trim$(rs2346!K2346_PackWarehouse)
            If IsdbNull(rs2346!K2346_QtyInbound) = False Then D2346.QtyInbound = Trim$(rs2346!K2346_QtyInbound)
            If IsdbNull(rs2346!K2346_PackInbound) = False Then D2346.PackInbound = Trim$(rs2346!K2346_PackInbound)
            If IsdbNull(rs2346!K2346_QtyOutbound) = False Then D2346.QtyOutbound = Trim$(rs2346!K2346_QtyOutbound)
            If IsdbNull(rs2346!K2346_PackOutbound) = False Then D2346.PackOutbound = Trim$(rs2346!K2346_PackOutbound)
            If IsdbNull(rs2346!K2346_AmountEX) = False Then D2346.AmountEX = Trim$(rs2346!K2346_AmountEX)
            If IsdbNull(rs2346!K2346_AmountVND) = False Then D2346.AmountVND = Trim$(rs2346!K2346_AmountVND)
            If IsdbNull(rs2346!K2346_AmountInBoundEX) = False Then D2346.AmountInBoundEX = Trim$(rs2346!K2346_AmountInBoundEX)
            If IsdbNull(rs2346!K2346_AmountInBoundVND) = False Then D2346.AmountInBoundVND = Trim$(rs2346!K2346_AmountInBoundVND)
            If IsdbNull(rs2346!K2346_DateDelivery) = False Then D2346.DateDelivery = Trim$(rs2346!K2346_DateDelivery)
            If IsdbNull(rs2346!K2346_DateStart) = False Then D2346.DateStart = Trim$(rs2346!K2346_DateStart)
            If IsdbNull(rs2346!K2346_DateFinish) = False Then D2346.DateFinish = Trim$(rs2346!K2346_DateFinish)
            If IsdbNull(rs2346!K2346_CheckPurchasing) = False Then D2346.CheckPurchasing = Trim$(rs2346!K2346_CheckPurchasing)
            If IsdbNull(rs2346!K2346_DateAccept) = False Then D2346.DateAccept = Trim$(rs2346!K2346_DateAccept)
            If IsdbNull(rs2346!K2346_DatePosted) = False Then D2346.DatePosted = Trim$(rs2346!K2346_DatePosted)
            If IsdbNull(rs2346!K2346_IsPosted) = False Then D2346.IsPosted = Trim$(rs2346!K2346_IsPosted)
            If IsdbNull(rs2346!K2346_DateComplete) = False Then D2346.DateComplete = Trim$(rs2346!K2346_DateComplete)
            If IsdbNull(rs2346!K2346_DateApproval) = False Then D2346.DateApproval = Trim$(rs2346!K2346_DateApproval)
            If IsdbNull(rs2346!K2346_DateCancel) = False Then D2346.DateCancel = Trim$(rs2346!K2346_DateCancel)
            If IsdbNull(rs2346!K2346_CheckComplete) = False Then D2346.CheckComplete = Trim$(rs2346!K2346_CheckComplete)
            If IsdbNull(rs2346!K2346_PurchasingOrderNo) = False Then D2346.PurchasingOrderNo = Trim$(rs2346!K2346_PurchasingOrderNo)
            If IsdbNull(rs2346!K2346_PurchasingOrderSeq) = False Then D2346.PurchasingOrderSeq = Trim$(rs2346!K2346_PurchasingOrderSeq)
            If IsdbNull(rs2346!K2346_JobCardWorking) = False Then D2346.JobCardWorking = Trim$(rs2346!K2346_JobCardWorking)
            If IsdbNull(rs2346!K2346_JobCardWorkingSeq) = False Then D2346.JobCardWorkingSeq = Trim$(rs2346!K2346_JobCardWorkingSeq)
            If IsdbNull(rs2346!K2346_JobCardType) = False Then D2346.JobCardType = Trim$(rs2346!K2346_JobCardType)
            If IsdbNull(rs2346!K2346_SalesOrderNo) = False Then D2346.SalesOrderNo = Trim$(rs2346!K2346_SalesOrderNo)
            If IsdbNull(rs2346!K2346_SalesOrderSeq) = False Then D2346.SalesOrderSeq = Trim$(rs2346!K2346_SalesOrderSeq)
            If IsdbNull(rs2346!K2346_SalesOrderSno) = False Then D2346.SalesOrderSno = Trim$(rs2346!K2346_SalesOrderSno)
            If IsdbNull(rs2346!K2346_CheckOrderType) = False Then D2346.CheckOrderType = Trim$(rs2346!K2346_CheckOrderType)
            If IsdbNull(rs2346!K2346_OrderNo) = False Then D2346.OrderNo = Trim$(rs2346!K2346_OrderNo)
            If IsdbNull(rs2346!K2346_OrderNoSeq) = False Then D2346.OrderNoSeq = Trim$(rs2346!K2346_OrderNoSeq)
            If IsdbNull(rs2346!K2346_JobCard) = False Then D2346.JobCard = Trim$(rs2346!K2346_JobCard)
            If IsdbNull(rs2346!K2346_DateSync) = False Then D2346.DateSync = Trim$(rs2346!K2346_DateSync)
            If IsdbNull(rs2346!K2346_CheckSync) = False Then D2346.CheckSync = Trim$(rs2346!K2346_CheckSync)
            If IsdbNull(rs2346!K2346_SlNo) = False Then D2346.SlNo = Trim$(rs2346!K2346_SlNo)
            If IsdbNull(rs2346!K2346_Check_Spec_1) = False Then D2346.Check_Spec_1 = Trim$(rs2346!K2346_Check_Spec_1)
            If IsdbNull(rs2346!K2346_Check_Spec_2) = False Then D2346.Check_Spec_2 = Trim$(rs2346!K2346_Check_Spec_2)
            If IsdbNull(rs2346!K2346_Check_Spec_3) = False Then D2346.Check_Spec_3 = Trim$(rs2346!K2346_Check_Spec_3)
            If IsdbNull(rs2346!K2346_Check_Spec_4) = False Then D2346.Check_Spec_4 = Trim$(rs2346!K2346_Check_Spec_4)
            If IsdbNull(rs2346!K2346_Check_Spec_5) = False Then D2346.Check_Spec_5 = Trim$(rs2346!K2346_Check_Spec_5)
            If IsdbNull(rs2346!K2346_Check_Spec_6) = False Then D2346.Check_Spec_6 = Trim$(rs2346!K2346_Check_Spec_6)
            If IsdbNull(rs2346!K2346_Check_Spec_7) = False Then D2346.Check_Spec_7 = Trim$(rs2346!K2346_Check_Spec_7)
            If IsdbNull(rs2346!K2346_Check_Spec_8) = False Then D2346.Check_Spec_8 = Trim$(rs2346!K2346_Check_Spec_8)
            If IsdbNull(rs2346!K2346_Check_Spec_9) = False Then D2346.Check_Spec_9 = Trim$(rs2346!K2346_Check_Spec_9)
            If IsdbNull(rs2346!K2346_Remark) = False Then D2346.Remark = Trim$(rs2346!K2346_Remark)
            If IsdbNull(rs2346!K2346_TimeInsert) = False Then D2346.TimeInsert = Trim$(rs2346!K2346_TimeInsert)
            If IsdbNull(rs2346!K2346_TimeUpdate) = False Then D2346.TimeUpdate = Trim$(rs2346!K2346_TimeUpdate)
            If IsdbNull(rs2346!K2346_DateInsert) = False Then D2346.DateInsert = Trim$(rs2346!K2346_DateInsert)
            If IsdbNull(rs2346!K2346_DateUpdate) = False Then D2346.DateUpdate = Trim$(rs2346!K2346_DateUpdate)
            If IsdbNull(rs2346!K2346_InchargeInsert) = False Then D2346.InchargeInsert = Trim$(rs2346!K2346_InchargeInsert)
            If IsdbNull(rs2346!K2346_InchargeUpdate) = False Then D2346.InchargeUpdate = Trim$(rs2346!K2346_InchargeUpdate)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K2346_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K2346_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z2346 As T2346_AREA, FACTORDERNO As String, FACTORDERSEQ As Double) As Boolean

        K2346_MOVE = False

        Try
            If READ_PFK2346(FACTORDERNO, FACTORDERSEQ) = True Then
                z2346 = D2346
                K2346_MOVE = True
            Else
                z2346 = Nothing
            End If

            If getColumnIndex(spr, "FactOrderNo") > -1 Then z2346.FactOrderNo = getDataM(spr, getColumnIndex(spr, "FactOrderNo"), xRow)
            If getColumnIndex(spr, "FactOrderSeq") > -1 Then z2346.FactOrderSeq = Cdecp(getDataM(spr, getColumnIndex(spr, "FactOrderSeq"), xRow))
            If getColumnIndex(spr, "CustSpecNo") > -1 Then z2346.CustSpecNo = getDataM(spr, getColumnIndex(spr, "CustSpecNo"), xRow)
            If getColumnIndex(spr, "ProductCode") > -1 Then z2346.ProductCode = getDataM(spr, getColumnIndex(spr, "ProductCode"), xRow)
            If getColumnIndex(spr, "Article") > -1 Then z2346.Article = getDataM(spr, getColumnIndex(spr, "Article"), xRow)
            If getColumnIndex(spr, "CustPoNo") > -1 Then z2346.CustPoNo = getDataM(spr, getColumnIndex(spr, "CustPoNo"), xRow)
            If getColumnIndex(spr, "FacPO") > -1 Then z2346.FacPO = getDataM(spr, getColumnIndex(spr, "FacPO"), xRow)
            If getColumnIndex(spr, "PONO") > -1 Then z2346.PONO = getDataM(spr, getColumnIndex(spr, "PONO"), xRow)
            If getColumnIndex(spr, "PKO") > -1 Then z2346.PKO = getDataM(spr, getColumnIndex(spr, "PKO"), xRow)
            If getColumnIndex(spr, "CustomerName") > -1 Then z2346.CustomerName = getDataM(spr, getColumnIndex(spr, "CustomerName"), xRow)
            If getColumnIndex(spr, "DeclareNo") > -1 Then z2346.DeclareNo = getDataM(spr, getColumnIndex(spr, "DeclareNo"), xRow)
            If getColumnIndex(spr, "DateLable") > -1 Then z2346.DateLable = getDataM(spr, getColumnIndex(spr, "DateLable"), xRow)
            If getColumnIndex(spr, "InchargeDeclare") > -1 Then z2346.InchargeDeclare = getDataM(spr, getColumnIndex(spr, "InchargeDeclare"), xRow)
            If getColumnIndex(spr, "DeclareAmount") > -1 Then z2346.DeclareAmount = Cdecp(getDataM(spr, getColumnIndex(spr, "DeclareAmount"), xRow))
            If getColumnIndex(spr, "DeclareWgt") > -1 Then z2346.DeclareWgt = Cdecp(getDataM(spr, getColumnIndex(spr, "DeclareWgt"), xRow))
            If getColumnIndex(spr, "seSite") > -1 Then z2346.seSite = getDataM(spr, getColumnIndex(spr, "seSite"), xRow)
            If getColumnIndex(spr, "cdSite") > -1 Then z2346.cdSite = getDataM(spr, getColumnIndex(spr, "cdSite"), xRow)
            If getColumnIndex(spr, "seDepartment") > -1 Then z2346.seDepartment = getDataM(spr, getColumnIndex(spr, "seDepartment"), xRow)
            If getColumnIndex(spr, "cdDepartment") > -1 Then z2346.cdDepartment = getDataM(spr, getColumnIndex(spr, "cdDepartment"), xRow)
            If getColumnIndex(spr, "seFactory") > -1 Then z2346.seFactory = getDataM(spr, getColumnIndex(spr, "seFactory"), xRow)
            If getColumnIndex(spr, "cdFactory") > -1 Then z2346.cdFactory = getDataM(spr, getColumnIndex(spr, "cdFactory"), xRow)
            If getColumnIndex(spr, "seLineProd") > -1 Then z2346.seLineProd = getDataM(spr, getColumnIndex(spr, "seLineProd"), xRow)
            If getColumnIndex(spr, "cdLineProd") > -1 Then z2346.cdLineProd = getDataM(spr, getColumnIndex(spr, "cdLineProd"), xRow)
            If getColumnIndex(spr, "seSubProcess") > -1 Then z2346.seSubProcess = getDataM(spr, getColumnIndex(spr, "seSubProcess"), xRow)
            If getColumnIndex(spr, "cdSubProcess") > -1 Then z2346.cdSubProcess = getDataM(spr, getColumnIndex(spr, "cdSubProcess"), xRow)
            If getColumnIndex(spr, "seGroupComponent") > -1 Then z2346.seGroupComponent = getDataM(spr, getColumnIndex(spr, "seGroupComponent"), xRow)
            If getColumnIndex(spr, "cdGroupComponent") > -1 Then z2346.cdGroupComponent = getDataM(spr, getColumnIndex(spr, "cdGroupComponent"), xRow)
            If getColumnIndex(spr, "CustomerSupplier") > -1 Then z2346.CustomerSupplier = getDataM(spr, getColumnIndex(spr, "CustomerSupplier"), xRow)
            If getColumnIndex(spr, "Dseq") > -1 Then z2346.Dseq = Cdecp(getDataM(spr, getColumnIndex(spr, "Dseq"), xRow))
            If getColumnIndex(spr, "Pseq") > -1 Then z2346.Pseq = Cdecp(getDataM(spr, getColumnIndex(spr, "Pseq"), xRow))
            If getColumnIndex(spr, "AutokeyK3011") > -1 Then z2346.AutokeyK3011 = Cdecp(getDataM(spr, getColumnIndex(spr, "AutokeyK3011"), xRow))
            If getColumnIndex(spr, "CheckRelationType") > -1 Then z2346.CheckRelationType = getDataM(spr, getColumnIndex(spr, "CheckRelationType"), xRow)
            If getColumnIndex(spr, "ComponentName") > -1 Then z2346.ComponentName = getDataM(spr, getColumnIndex(spr, "ComponentName"), xRow)
            If getColumnIndex(spr, "MaterialCode") > -1 Then z2346.MaterialCode = getDataM(spr, getColumnIndex(spr, "MaterialCode"), xRow)
            If getColumnIndex(spr, "Specification") > -1 Then z2346.Specification = getDataM(spr, getColumnIndex(spr, "Specification"), xRow)
            If getColumnIndex(spr, "Width") > -1 Then z2346.Width = getDataM(spr, getColumnIndex(spr, "Width"), xRow)
            If getColumnIndex(spr, "Height") > -1 Then z2346.Height = getDataM(spr, getColumnIndex(spr, "Height"), xRow)
            If getColumnIndex(spr, "SizeNo") > -1 Then z2346.SizeNo = getDataM(spr, getColumnIndex(spr, "SizeNo"), xRow)
            If getColumnIndex(spr, "SizeName") > -1 Then z2346.SizeName = getDataM(spr, getColumnIndex(spr, "SizeName"), xRow)
            If getColumnIndex(spr, "ColorCode") > -1 Then z2346.ColorCode = getDataM(spr, getColumnIndex(spr, "ColorCode"), xRow)
            If getColumnIndex(spr, "ColorName") > -1 Then z2346.ColorName = getDataM(spr, getColumnIndex(spr, "ColorName"), xRow)
            If getColumnIndex(spr, "seOrigin") > -1 Then z2346.seOrigin = getDataM(spr, getColumnIndex(spr, "seOrigin"), xRow)
            If getColumnIndex(spr, "cdOrigin") > -1 Then z2346.cdOrigin = getDataM(spr, getColumnIndex(spr, "cdOrigin"), xRow)
            If getColumnIndex(spr, "MaterialCheck") > -1 Then z2346.MaterialCheck = getDataM(spr, getColumnIndex(spr, "MaterialCheck"), xRow)
            If getColumnIndex(spr, "seUnitPrice") > -1 Then z2346.seUnitPrice = getDataM(spr, getColumnIndex(spr, "seUnitPrice"), xRow)
            If getColumnIndex(spr, "cdUnitPrice") > -1 Then z2346.cdUnitPrice = getDataM(spr, getColumnIndex(spr, "cdUnitPrice"), xRow)
            If getColumnIndex(spr, "seTax") > -1 Then z2346.seTax = getDataM(spr, getColumnIndex(spr, "seTax"), xRow)
            If getColumnIndex(spr, "cdTax") > -1 Then z2346.cdTax = getDataM(spr, getColumnIndex(spr, "cdTax"), xRow)
            If getColumnIndex(spr, "seUnitMaterial") > -1 Then z2346.seUnitMaterial = getDataM(spr, getColumnIndex(spr, "seUnitMaterial"), xRow)
            If getColumnIndex(spr, "cdUnitMaterial") > -1 Then z2346.cdUnitMaterial = getDataM(spr, getColumnIndex(spr, "cdUnitMaterial"), xRow)
            If getColumnIndex(spr, "seUnitPacking") > -1 Then z2346.seUnitPacking = getDataM(spr, getColumnIndex(spr, "seUnitPacking"), xRow)
            If getColumnIndex(spr, "cdUnitPacking") > -1 Then z2346.cdUnitPacking = getDataM(spr, getColumnIndex(spr, "cdUnitPacking"), xRow)
            If getColumnIndex(spr, "UnitBaseCheck") > -1 Then z2346.UnitBaseCheck = getDataM(spr, getColumnIndex(spr, "UnitBaseCheck"), xRow)
            If getColumnIndex(spr, "QtyBasic") > -1 Then z2346.QtyBasic = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyBasic"), xRow))
            If getColumnIndex(spr, "PricePurchasing") > -1 Then z2346.PricePurchasing = Cdecp(getDataM(spr, getColumnIndex(spr, "PricePurchasing"), xRow))
            If getColumnIndex(spr, "PriceMarket") > -1 Then z2346.PriceMarket = Cdecp(getDataM(spr, getColumnIndex(spr, "PriceMarket"), xRow))
            If getColumnIndex(spr, "PriceExchange") > -1 Then z2346.PriceExchange = Cdecp(getDataM(spr, getColumnIndex(spr, "PriceExchange"), xRow))
            If getColumnIndex(spr, "PriceExchangeAP") > -1 Then z2346.PriceExchangeAP = Cdecp(getDataM(spr, getColumnIndex(spr, "PriceExchangeAP"), xRow))
            If getColumnIndex(spr, "DateExchange") > -1 Then z2346.DateExchange = getDataM(spr, getColumnIndex(spr, "DateExchange"), xRow)
            If getColumnIndex(spr, "PricePurchasingEX") > -1 Then z2346.PricePurchasingEX = Cdecp(getDataM(spr, getColumnIndex(spr, "PricePurchasingEX"), xRow))
            If getColumnIndex(spr, "PriceMarketEX") > -1 Then z2346.PriceMarketEX = Cdecp(getDataM(spr, getColumnIndex(spr, "PriceMarketEX"), xRow))
            If getColumnIndex(spr, "PricePurchasingVND") > -1 Then z2346.PricePurchasingVND = Cdecp(getDataM(spr, getColumnIndex(spr, "PricePurchasingVND"), xRow))
            If getColumnIndex(spr, "PriceMarketVND") > -1 Then z2346.PriceMarketVND = Cdecp(getDataM(spr, getColumnIndex(spr, "PriceMarketVND"), xRow))
            If getColumnIndex(spr, "AmountPurchasingEX") > -1 Then z2346.AmountPurchasingEX = Cdecp(getDataM(spr, getColumnIndex(spr, "AmountPurchasingEX"), xRow))
            If getColumnIndex(spr, "AmountPurchasingVND") > -1 Then z2346.AmountPurchasingVND = Cdecp(getDataM(spr, getColumnIndex(spr, "AmountPurchasingVND"), xRow))
            If getColumnIndex(spr, "AmountTaxEX") > -1 Then z2346.AmountTaxEX = Cdecp(getDataM(spr, getColumnIndex(spr, "AmountTaxEX"), xRow))
            If getColumnIndex(spr, "AmountTaxVND") > -1 Then z2346.AmountTaxVND = Cdecp(getDataM(spr, getColumnIndex(spr, "AmountTaxVND"), xRow))
            If getColumnIndex(spr, "seTax1") > -1 Then z2346.seTax1 = getDataM(spr, getColumnIndex(spr, "seTax1"), xRow)
            If getColumnIndex(spr, "cdTax1") > -1 Then z2346.cdTax1 = getDataM(spr, getColumnIndex(spr, "cdTax1"), xRow)
            If getColumnIndex(spr, "PerTax1") > -1 Then z2346.PerTax1 = Cdecp(getDataM(spr, getColumnIndex(spr, "PerTax1"), xRow))
            If getColumnIndex(spr, "AmountTax1") > -1 Then z2346.AmountTax1 = Cdecp(getDataM(spr, getColumnIndex(spr, "AmountTax1"), xRow))
            If getColumnIndex(spr, "seTax2") > -1 Then z2346.seTax2 = getDataM(spr, getColumnIndex(spr, "seTax2"), xRow)
            If getColumnIndex(spr, "cdTax2") > -1 Then z2346.cdTax2 = getDataM(spr, getColumnIndex(spr, "cdTax2"), xRow)
            If getColumnIndex(spr, "PerTax2") > -1 Then z2346.PerTax2 = Cdecp(getDataM(spr, getColumnIndex(spr, "PerTax2"), xRow))
            If getColumnIndex(spr, "AmountTax2") > -1 Then z2346.AmountTax2 = Cdecp(getDataM(spr, getColumnIndex(spr, "AmountTax2"), xRow))
            If getColumnIndex(spr, "seTax3") > -1 Then z2346.seTax3 = getDataM(spr, getColumnIndex(spr, "seTax3"), xRow)
            If getColumnIndex(spr, "cdTax3") > -1 Then z2346.cdTax3 = getDataM(spr, getColumnIndex(spr, "cdTax3"), xRow)
            If getColumnIndex(spr, "PerTax3") > -1 Then z2346.PerTax3 = Cdecp(getDataM(spr, getColumnIndex(spr, "PerTax3"), xRow))
            If getColumnIndex(spr, "AmountTax3") > -1 Then z2346.AmountTax3 = Cdecp(getDataM(spr, getColumnIndex(spr, "AmountTax3"), xRow))
            If getColumnIndex(spr, "QtyRequestPO") > -1 Then z2346.QtyRequestPO = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyRequestPO"), xRow))
            If getColumnIndex(spr, "QtyPurchasingNet") > -1 Then z2346.QtyPurchasingNet = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyPurchasingNet"), xRow))
            If getColumnIndex(spr, "QtyPurchasingMOQ") > -1 Then z2346.QtyPurchasingMOQ = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyPurchasingMOQ"), xRow))
            If getColumnIndex(spr, "QtyPurchasing") > -1 Then z2346.QtyPurchasing = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyPurchasing"), xRow))
            If getColumnIndex(spr, "PackPurchasing") > -1 Then z2346.PackPurchasing = Cdecp(getDataM(spr, getColumnIndex(spr, "PackPurchasing"), xRow))
            If getColumnIndex(spr, "QtyWarehouse") > -1 Then z2346.QtyWarehouse = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyWarehouse"), xRow))
            If getColumnIndex(spr, "PackWarehouse") > -1 Then z2346.PackWarehouse = Cdecp(getDataM(spr, getColumnIndex(spr, "PackWarehouse"), xRow))
            If getColumnIndex(spr, "QtyInbound") > -1 Then z2346.QtyInbound = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyInbound"), xRow))
            If getColumnIndex(spr, "PackInbound") > -1 Then z2346.PackInbound = Cdecp(getDataM(spr, getColumnIndex(spr, "PackInbound"), xRow))
            If getColumnIndex(spr, "QtyOutbound") > -1 Then z2346.QtyOutbound = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyOutbound"), xRow))
            If getColumnIndex(spr, "PackOutbound") > -1 Then z2346.PackOutbound = Cdecp(getDataM(spr, getColumnIndex(spr, "PackOutbound"), xRow))
            If getColumnIndex(spr, "AmountEX") > -1 Then z2346.AmountEX = Cdecp(getDataM(spr, getColumnIndex(spr, "AmountEX"), xRow))
            If getColumnIndex(spr, "AmountVND") > -1 Then z2346.AmountVND = Cdecp(getDataM(spr, getColumnIndex(spr, "AmountVND"), xRow))
            If getColumnIndex(spr, "AmountInBoundEX") > -1 Then z2346.AmountInBoundEX = Cdecp(getDataM(spr, getColumnIndex(spr, "AmountInBoundEX"), xRow))
            If getColumnIndex(spr, "AmountInBoundVND") > -1 Then z2346.AmountInBoundVND = Cdecp(getDataM(spr, getColumnIndex(spr, "AmountInBoundVND"), xRow))
            If getColumnIndex(spr, "DateDelivery") > -1 Then z2346.DateDelivery = getDataM(spr, getColumnIndex(spr, "DateDelivery"), xRow)
            If getColumnIndex(spr, "DateStart") > -1 Then z2346.DateStart = getDataM(spr, getColumnIndex(spr, "DateStart"), xRow)
            If getColumnIndex(spr, "DateFinish") > -1 Then z2346.DateFinish = getDataM(spr, getColumnIndex(spr, "DateFinish"), xRow)
            If getColumnIndex(spr, "CheckPurchasing") > -1 Then z2346.CheckPurchasing = getDataM(spr, getColumnIndex(spr, "CheckPurchasing"), xRow)
            If getColumnIndex(spr, "DateAccept") > -1 Then z2346.DateAccept = getDataM(spr, getColumnIndex(spr, "DateAccept"), xRow)
            If getColumnIndex(spr, "DatePosted") > -1 Then z2346.DatePosted = getDataM(spr, getColumnIndex(spr, "DatePosted"), xRow)
            If getColumnIndex(spr, "IsPosted") > -1 Then z2346.IsPosted = getDataM(spr, getColumnIndex(spr, "IsPosted"), xRow)
            If getColumnIndex(spr, "DateComplete") > -1 Then z2346.DateComplete = getDataM(spr, getColumnIndex(spr, "DateComplete"), xRow)
            If getColumnIndex(spr, "DateApproval") > -1 Then z2346.DateApproval = getDataM(spr, getColumnIndex(spr, "DateApproval"), xRow)
            If getColumnIndex(spr, "DateCancel") > -1 Then z2346.DateCancel = getDataM(spr, getColumnIndex(spr, "DateCancel"), xRow)
            If getColumnIndex(spr, "CheckComplete") > -1 Then z2346.CheckComplete = getDataM(spr, getColumnIndex(spr, "CheckComplete"), xRow)
            If getColumnIndex(spr, "PurchasingOrderNo") > -1 Then z2346.PurchasingOrderNo = getDataM(spr, getColumnIndex(spr, "PurchasingOrderNo"), xRow)
            If getColumnIndex(spr, "PurchasingOrderSeq") > -1 Then z2346.PurchasingOrderSeq = Cdecp(getDataM(spr, getColumnIndex(spr, "PurchasingOrderSeq"), xRow))
            If getColumnIndex(spr, "JobCardWorking") > -1 Then z2346.JobCardWorking = getDataM(spr, getColumnIndex(spr, "JobCardWorking"), xRow)
            If getColumnIndex(spr, "JobCardWorkingSeq") > -1 Then z2346.JobCardWorkingSeq = getDataM(spr, getColumnIndex(spr, "JobCardWorkingSeq"), xRow)
            If getColumnIndex(spr, "JobCardType") > -1 Then z2346.JobCardType = getDataM(spr, getColumnIndex(spr, "JobCardType"), xRow)
            If getColumnIndex(spr, "SalesOrderNo") > -1 Then z2346.SalesOrderNo = getDataM(spr, getColumnIndex(spr, "SalesOrderNo"), xRow)
            If getColumnIndex(spr, "SalesOrderSeq") > -1 Then z2346.SalesOrderSeq = getDataM(spr, getColumnIndex(spr, "SalesOrderSeq"), xRow)
            If getColumnIndex(spr, "SalesOrderSno") > -1 Then z2346.SalesOrderSno = getDataM(spr, getColumnIndex(spr, "SalesOrderSno"), xRow)
            If getColumnIndex(spr, "CheckOrderType") > -1 Then z2346.CheckOrderType = getDataM(spr, getColumnIndex(spr, "CheckOrderType"), xRow)
            If getColumnIndex(spr, "OrderNo") > -1 Then z2346.OrderNo = getDataM(spr, getColumnIndex(spr, "OrderNo"), xRow)
            If getColumnIndex(spr, "OrderNoSeq") > -1 Then z2346.OrderNoSeq = getDataM(spr, getColumnIndex(spr, "OrderNoSeq"), xRow)
            If getColumnIndex(spr, "JobCard") > -1 Then z2346.JobCard = getDataM(spr, getColumnIndex(spr, "JobCard"), xRow)
            If getColumnIndex(spr, "DateSync") > -1 Then z2346.DateSync = getDataM(spr, getColumnIndex(spr, "DateSync"), xRow)
            If getColumnIndex(spr, "CheckSync") > -1 Then z2346.CheckSync = getDataM(spr, getColumnIndex(spr, "CheckSync"), xRow)
            If getColumnIndex(spr, "SlNo") > -1 Then z2346.SlNo = getDataM(spr, getColumnIndex(spr, "SlNo"), xRow)
            If getColumnIndex(spr, "Check_Spec_1") > -1 Then z2346.Check_Spec_1 = getDataM(spr, getColumnIndex(spr, "Check_Spec_1"), xRow)
            If getColumnIndex(spr, "Check_Spec_2") > -1 Then z2346.Check_Spec_2 = getDataM(spr, getColumnIndex(spr, "Check_Spec_2"), xRow)
            If getColumnIndex(spr, "Check_Spec_3") > -1 Then z2346.Check_Spec_3 = getDataM(spr, getColumnIndex(spr, "Check_Spec_3"), xRow)
            If getColumnIndex(spr, "Check_Spec_4") > -1 Then z2346.Check_Spec_4 = getDataM(spr, getColumnIndex(spr, "Check_Spec_4"), xRow)
            If getColumnIndex(spr, "Check_Spec_5") > -1 Then z2346.Check_Spec_5 = getDataM(spr, getColumnIndex(spr, "Check_Spec_5"), xRow)
            If getColumnIndex(spr, "Check_Spec_6") > -1 Then z2346.Check_Spec_6 = getDataM(spr, getColumnIndex(spr, "Check_Spec_6"), xRow)
            If getColumnIndex(spr, "Check_Spec_7") > -1 Then z2346.Check_Spec_7 = getDataM(spr, getColumnIndex(spr, "Check_Spec_7"), xRow)
            If getColumnIndex(spr, "Check_Spec_8") > -1 Then z2346.Check_Spec_8 = getDataM(spr, getColumnIndex(spr, "Check_Spec_8"), xRow)
            If getColumnIndex(spr, "Check_Spec_9") > -1 Then z2346.Check_Spec_9 = getDataM(spr, getColumnIndex(spr, "Check_Spec_9"), xRow)
            If getColumnIndex(spr, "Remark") > -1 Then z2346.Remark = getDataM(spr, getColumnIndex(spr, "Remark"), xRow)
            If getColumnIndex(spr, "TimeInsert") > -1 Then z2346.TimeInsert = getDataM(spr, getColumnIndex(spr, "TimeInsert"), xRow)
            If getColumnIndex(spr, "TimeUpdate") > -1 Then z2346.TimeUpdate = getDataM(spr, getColumnIndex(spr, "TimeUpdate"), xRow)
            If getColumnIndex(spr, "DateInsert") > -1 Then z2346.DateInsert = getDataM(spr, getColumnIndex(spr, "DateInsert"), xRow)
            If getColumnIndex(spr, "DateUpdate") > -1 Then z2346.DateUpdate = getDataM(spr, getColumnIndex(spr, "DateUpdate"), xRow)
            If getColumnIndex(spr, "InchargeInsert") > -1 Then z2346.InchargeInsert = getDataM(spr, getColumnIndex(spr, "InchargeInsert"), xRow)
            If getColumnIndex(spr, "InchargeUpdate") > -1 Then z2346.InchargeUpdate = getDataM(spr, getColumnIndex(spr, "InchargeUpdate"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K2346_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K2346_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z2346 As T2346_AREA, CheckClear As Boolean, FACTORDERNO As String, FACTORDERSEQ As Double) As Boolean

        K2346_MOVE = False

        Try
            If READ_PFK2346(FACTORDERNO, FACTORDERSEQ) = True Then
                z2346 = D2346
                K2346_MOVE = True
            Else
                If CheckClear = True Then z2346 = Nothing
            End If

            If getColumnIndex(spr, "FactOrderNo") > -1 Then z2346.FactOrderNo = getDataM(spr, getColumnIndex(spr, "FactOrderNo"), xRow)
            If getColumnIndex(spr, "FactOrderSeq") > -1 Then z2346.FactOrderSeq = Cdecp(getDataM(spr, getColumnIndex(spr, "FactOrderSeq"), xRow))
            If getColumnIndex(spr, "CustSpecNo") > -1 Then z2346.CustSpecNo = getDataM(spr, getColumnIndex(spr, "CustSpecNo"), xRow)
            If getColumnIndex(spr, "ProductCode") > -1 Then z2346.ProductCode = getDataM(spr, getColumnIndex(spr, "ProductCode"), xRow)
            If getColumnIndex(spr, "Article") > -1 Then z2346.Article = getDataM(spr, getColumnIndex(spr, "Article"), xRow)
            If getColumnIndex(spr, "CustPoNo") > -1 Then z2346.CustPoNo = getDataM(spr, getColumnIndex(spr, "CustPoNo"), xRow)
            If getColumnIndex(spr, "FacPO") > -1 Then z2346.FacPO = getDataM(spr, getColumnIndex(spr, "FacPO"), xRow)
            If getColumnIndex(spr, "PONO") > -1 Then z2346.PONO = getDataM(spr, getColumnIndex(spr, "PONO"), xRow)
            If getColumnIndex(spr, "PKO") > -1 Then z2346.PKO = getDataM(spr, getColumnIndex(spr, "PKO"), xRow)
            If getColumnIndex(spr, "CustomerName") > -1 Then z2346.CustomerName = getDataM(spr, getColumnIndex(spr, "CustomerName"), xRow)
            If getColumnIndex(spr, "DeclareNo") > -1 Then z2346.DeclareNo = getDataM(spr, getColumnIndex(spr, "DeclareNo"), xRow)
            If getColumnIndex(spr, "DateLable") > -1 Then z2346.DateLable = getDataM(spr, getColumnIndex(spr, "DateLable"), xRow)
            If getColumnIndex(spr, "InchargeDeclare") > -1 Then z2346.InchargeDeclare = getDataM(spr, getColumnIndex(spr, "InchargeDeclare"), xRow)
            If getColumnIndex(spr, "DeclareAmount") > -1 Then z2346.DeclareAmount = Cdecp(getDataM(spr, getColumnIndex(spr, "DeclareAmount"), xRow))
            If getColumnIndex(spr, "DeclareWgt") > -1 Then z2346.DeclareWgt = Cdecp(getDataM(spr, getColumnIndex(spr, "DeclareWgt"), xRow))
            If getColumnIndex(spr, "seSite") > -1 Then z2346.seSite = getDataM(spr, getColumnIndex(spr, "seSite"), xRow)
            If getColumnIndex(spr, "cdSite") > -1 Then z2346.cdSite = getDataM(spr, getColumnIndex(spr, "cdSite"), xRow)
            If getColumnIndex(spr, "seDepartment") > -1 Then z2346.seDepartment = getDataM(spr, getColumnIndex(spr, "seDepartment"), xRow)
            If getColumnIndex(spr, "cdDepartment") > -1 Then z2346.cdDepartment = getDataM(spr, getColumnIndex(spr, "cdDepartment"), xRow)
            If getColumnIndex(spr, "seFactory") > -1 Then z2346.seFactory = getDataM(spr, getColumnIndex(spr, "seFactory"), xRow)
            If getColumnIndex(spr, "cdFactory") > -1 Then z2346.cdFactory = getDataM(spr, getColumnIndex(spr, "cdFactory"), xRow)
            If getColumnIndex(spr, "seLineProd") > -1 Then z2346.seLineProd = getDataM(spr, getColumnIndex(spr, "seLineProd"), xRow)
            If getColumnIndex(spr, "cdLineProd") > -1 Then z2346.cdLineProd = getDataM(spr, getColumnIndex(spr, "cdLineProd"), xRow)
            If getColumnIndex(spr, "seSubProcess") > -1 Then z2346.seSubProcess = getDataM(spr, getColumnIndex(spr, "seSubProcess"), xRow)
            If getColumnIndex(spr, "cdSubProcess") > -1 Then z2346.cdSubProcess = getDataM(spr, getColumnIndex(spr, "cdSubProcess"), xRow)
            If getColumnIndex(spr, "seGroupComponent") > -1 Then z2346.seGroupComponent = getDataM(spr, getColumnIndex(spr, "seGroupComponent"), xRow)
            If getColumnIndex(spr, "cdGroupComponent") > -1 Then z2346.cdGroupComponent = getDataM(spr, getColumnIndex(spr, "cdGroupComponent"), xRow)
            If getColumnIndex(spr, "CustomerSupplier") > -1 Then z2346.CustomerSupplier = getDataM(spr, getColumnIndex(spr, "CustomerSupplier"), xRow)
            If getColumnIndex(spr, "Dseq") > -1 Then z2346.Dseq = Cdecp(getDataM(spr, getColumnIndex(spr, "Dseq"), xRow))
            If getColumnIndex(spr, "Pseq") > -1 Then z2346.Pseq = Cdecp(getDataM(spr, getColumnIndex(spr, "Pseq"), xRow))
            If getColumnIndex(spr, "AutokeyK3011") > -1 Then z2346.AutokeyK3011 = Cdecp(getDataM(spr, getColumnIndex(spr, "AutokeyK3011"), xRow))
            If getColumnIndex(spr, "CheckRelationType") > -1 Then z2346.CheckRelationType = getDataM(spr, getColumnIndex(spr, "CheckRelationType"), xRow)
            If getColumnIndex(spr, "ComponentName") > -1 Then z2346.ComponentName = getDataM(spr, getColumnIndex(spr, "ComponentName"), xRow)
            If getColumnIndex(spr, "MaterialCode") > -1 Then z2346.MaterialCode = getDataM(spr, getColumnIndex(spr, "MaterialCode"), xRow)
            If getColumnIndex(spr, "Specification") > -1 Then z2346.Specification = getDataM(spr, getColumnIndex(spr, "Specification"), xRow)
            If getColumnIndex(spr, "Width") > -1 Then z2346.Width = getDataM(spr, getColumnIndex(spr, "Width"), xRow)
            If getColumnIndex(spr, "Height") > -1 Then z2346.Height = getDataM(spr, getColumnIndex(spr, "Height"), xRow)
            If getColumnIndex(spr, "SizeNo") > -1 Then z2346.SizeNo = getDataM(spr, getColumnIndex(spr, "SizeNo"), xRow)
            If getColumnIndex(spr, "SizeName") > -1 Then z2346.SizeName = getDataM(spr, getColumnIndex(spr, "SizeName"), xRow)
            If getColumnIndex(spr, "ColorCode") > -1 Then z2346.ColorCode = getDataM(spr, getColumnIndex(spr, "ColorCode"), xRow)
            If getColumnIndex(spr, "ColorName") > -1 Then z2346.ColorName = getDataM(spr, getColumnIndex(spr, "ColorName"), xRow)
            If getColumnIndex(spr, "seOrigin") > -1 Then z2346.seOrigin = getDataM(spr, getColumnIndex(spr, "seOrigin"), xRow)
            If getColumnIndex(spr, "cdOrigin") > -1 Then z2346.cdOrigin = getDataM(spr, getColumnIndex(spr, "cdOrigin"), xRow)
            If getColumnIndex(spr, "MaterialCheck") > -1 Then z2346.MaterialCheck = getDataM(spr, getColumnIndex(spr, "MaterialCheck"), xRow)
            If getColumnIndex(spr, "seUnitPrice") > -1 Then z2346.seUnitPrice = getDataM(spr, getColumnIndex(spr, "seUnitPrice"), xRow)
            If getColumnIndex(spr, "cdUnitPrice") > -1 Then z2346.cdUnitPrice = getDataM(spr, getColumnIndex(spr, "cdUnitPrice"), xRow)
            If getColumnIndex(spr, "seTax") > -1 Then z2346.seTax = getDataM(spr, getColumnIndex(spr, "seTax"), xRow)
            If getColumnIndex(spr, "cdTax") > -1 Then z2346.cdTax = getDataM(spr, getColumnIndex(spr, "cdTax"), xRow)
            If getColumnIndex(spr, "seUnitMaterial") > -1 Then z2346.seUnitMaterial = getDataM(spr, getColumnIndex(spr, "seUnitMaterial"), xRow)
            If getColumnIndex(spr, "cdUnitMaterial") > -1 Then z2346.cdUnitMaterial = getDataM(spr, getColumnIndex(spr, "cdUnitMaterial"), xRow)
            If getColumnIndex(spr, "seUnitPacking") > -1 Then z2346.seUnitPacking = getDataM(spr, getColumnIndex(spr, "seUnitPacking"), xRow)
            If getColumnIndex(spr, "cdUnitPacking") > -1 Then z2346.cdUnitPacking = getDataM(spr, getColumnIndex(spr, "cdUnitPacking"), xRow)
            If getColumnIndex(spr, "UnitBaseCheck") > -1 Then z2346.UnitBaseCheck = getDataM(spr, getColumnIndex(spr, "UnitBaseCheck"), xRow)
            If getColumnIndex(spr, "QtyBasic") > -1 Then z2346.QtyBasic = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyBasic"), xRow))
            If getColumnIndex(spr, "PricePurchasing") > -1 Then z2346.PricePurchasing = Cdecp(getDataM(spr, getColumnIndex(spr, "PricePurchasing"), xRow))
            If getColumnIndex(spr, "PriceMarket") > -1 Then z2346.PriceMarket = Cdecp(getDataM(spr, getColumnIndex(spr, "PriceMarket"), xRow))
            If getColumnIndex(spr, "PriceExchange") > -1 Then z2346.PriceExchange = Cdecp(getDataM(spr, getColumnIndex(spr, "PriceExchange"), xRow))
            If getColumnIndex(spr, "PriceExchangeAP") > -1 Then z2346.PriceExchangeAP = Cdecp(getDataM(spr, getColumnIndex(spr, "PriceExchangeAP"), xRow))
            If getColumnIndex(spr, "DateExchange") > -1 Then z2346.DateExchange = getDataM(spr, getColumnIndex(spr, "DateExchange"), xRow)
            If getColumnIndex(spr, "PricePurchasingEX") > -1 Then z2346.PricePurchasingEX = Cdecp(getDataM(spr, getColumnIndex(spr, "PricePurchasingEX"), xRow))
            If getColumnIndex(spr, "PriceMarketEX") > -1 Then z2346.PriceMarketEX = Cdecp(getDataM(spr, getColumnIndex(spr, "PriceMarketEX"), xRow))
            If getColumnIndex(spr, "PricePurchasingVND") > -1 Then z2346.PricePurchasingVND = Cdecp(getDataM(spr, getColumnIndex(spr, "PricePurchasingVND"), xRow))
            If getColumnIndex(spr, "PriceMarketVND") > -1 Then z2346.PriceMarketVND = Cdecp(getDataM(spr, getColumnIndex(spr, "PriceMarketVND"), xRow))
            If getColumnIndex(spr, "AmountPurchasingEX") > -1 Then z2346.AmountPurchasingEX = Cdecp(getDataM(spr, getColumnIndex(spr, "AmountPurchasingEX"), xRow))
            If getColumnIndex(spr, "AmountPurchasingVND") > -1 Then z2346.AmountPurchasingVND = Cdecp(getDataM(spr, getColumnIndex(spr, "AmountPurchasingVND"), xRow))
            If getColumnIndex(spr, "AmountTaxEX") > -1 Then z2346.AmountTaxEX = Cdecp(getDataM(spr, getColumnIndex(spr, "AmountTaxEX"), xRow))
            If getColumnIndex(spr, "AmountTaxVND") > -1 Then z2346.AmountTaxVND = Cdecp(getDataM(spr, getColumnIndex(spr, "AmountTaxVND"), xRow))
            If getColumnIndex(spr, "seTax1") > -1 Then z2346.seTax1 = getDataM(spr, getColumnIndex(spr, "seTax1"), xRow)
            If getColumnIndex(spr, "cdTax1") > -1 Then z2346.cdTax1 = getDataM(spr, getColumnIndex(spr, "cdTax1"), xRow)
            If getColumnIndex(spr, "PerTax1") > -1 Then z2346.PerTax1 = Cdecp(getDataM(spr, getColumnIndex(spr, "PerTax1"), xRow))
            If getColumnIndex(spr, "AmountTax1") > -1 Then z2346.AmountTax1 = Cdecp(getDataM(spr, getColumnIndex(spr, "AmountTax1"), xRow))
            If getColumnIndex(spr, "seTax2") > -1 Then z2346.seTax2 = getDataM(spr, getColumnIndex(spr, "seTax2"), xRow)
            If getColumnIndex(spr, "cdTax2") > -1 Then z2346.cdTax2 = getDataM(spr, getColumnIndex(spr, "cdTax2"), xRow)
            If getColumnIndex(spr, "PerTax2") > -1 Then z2346.PerTax2 = Cdecp(getDataM(spr, getColumnIndex(spr, "PerTax2"), xRow))
            If getColumnIndex(spr, "AmountTax2") > -1 Then z2346.AmountTax2 = Cdecp(getDataM(spr, getColumnIndex(spr, "AmountTax2"), xRow))
            If getColumnIndex(spr, "seTax3") > -1 Then z2346.seTax3 = getDataM(spr, getColumnIndex(spr, "seTax3"), xRow)
            If getColumnIndex(spr, "cdTax3") > -1 Then z2346.cdTax3 = getDataM(spr, getColumnIndex(spr, "cdTax3"), xRow)
            If getColumnIndex(spr, "PerTax3") > -1 Then z2346.PerTax3 = Cdecp(getDataM(spr, getColumnIndex(spr, "PerTax3"), xRow))
            If getColumnIndex(spr, "AmountTax3") > -1 Then z2346.AmountTax3 = Cdecp(getDataM(spr, getColumnIndex(spr, "AmountTax3"), xRow))
            If getColumnIndex(spr, "QtyRequestPO") > -1 Then z2346.QtyRequestPO = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyRequestPO"), xRow))
            If getColumnIndex(spr, "QtyPurchasingNet") > -1 Then z2346.QtyPurchasingNet = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyPurchasingNet"), xRow))
            If getColumnIndex(spr, "QtyPurchasingMOQ") > -1 Then z2346.QtyPurchasingMOQ = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyPurchasingMOQ"), xRow))
            If getColumnIndex(spr, "QtyPurchasing") > -1 Then z2346.QtyPurchasing = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyPurchasing"), xRow))
            If getColumnIndex(spr, "PackPurchasing") > -1 Then z2346.PackPurchasing = Cdecp(getDataM(spr, getColumnIndex(spr, "PackPurchasing"), xRow))
            If getColumnIndex(spr, "QtyWarehouse") > -1 Then z2346.QtyWarehouse = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyWarehouse"), xRow))
            If getColumnIndex(spr, "PackWarehouse") > -1 Then z2346.PackWarehouse = Cdecp(getDataM(spr, getColumnIndex(spr, "PackWarehouse"), xRow))
            If getColumnIndex(spr, "QtyInbound") > -1 Then z2346.QtyInbound = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyInbound"), xRow))
            If getColumnIndex(spr, "PackInbound") > -1 Then z2346.PackInbound = Cdecp(getDataM(spr, getColumnIndex(spr, "PackInbound"), xRow))
            If getColumnIndex(spr, "QtyOutbound") > -1 Then z2346.QtyOutbound = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyOutbound"), xRow))
            If getColumnIndex(spr, "PackOutbound") > -1 Then z2346.PackOutbound = Cdecp(getDataM(spr, getColumnIndex(spr, "PackOutbound"), xRow))
            If getColumnIndex(spr, "AmountEX") > -1 Then z2346.AmountEX = Cdecp(getDataM(spr, getColumnIndex(spr, "AmountEX"), xRow))
            If getColumnIndex(spr, "AmountVND") > -1 Then z2346.AmountVND = Cdecp(getDataM(spr, getColumnIndex(spr, "AmountVND"), xRow))
            If getColumnIndex(spr, "AmountInBoundEX") > -1 Then z2346.AmountInBoundEX = Cdecp(getDataM(spr, getColumnIndex(spr, "AmountInBoundEX"), xRow))
            If getColumnIndex(spr, "AmountInBoundVND") > -1 Then z2346.AmountInBoundVND = Cdecp(getDataM(spr, getColumnIndex(spr, "AmountInBoundVND"), xRow))
            If getColumnIndex(spr, "DateDelivery") > -1 Then z2346.DateDelivery = getDataM(spr, getColumnIndex(spr, "DateDelivery"), xRow)
            If getColumnIndex(spr, "DateStart") > -1 Then z2346.DateStart = getDataM(spr, getColumnIndex(spr, "DateStart"), xRow)
            If getColumnIndex(spr, "DateFinish") > -1 Then z2346.DateFinish = getDataM(spr, getColumnIndex(spr, "DateFinish"), xRow)
            If getColumnIndex(spr, "CheckPurchasing") > -1 Then z2346.CheckPurchasing = getDataM(spr, getColumnIndex(spr, "CheckPurchasing"), xRow)
            If getColumnIndex(spr, "DateAccept") > -1 Then z2346.DateAccept = getDataM(spr, getColumnIndex(spr, "DateAccept"), xRow)
            If getColumnIndex(spr, "DatePosted") > -1 Then z2346.DatePosted = getDataM(spr, getColumnIndex(spr, "DatePosted"), xRow)
            If getColumnIndex(spr, "IsPosted") > -1 Then z2346.IsPosted = getDataM(spr, getColumnIndex(spr, "IsPosted"), xRow)
            If getColumnIndex(spr, "DateComplete") > -1 Then z2346.DateComplete = getDataM(spr, getColumnIndex(spr, "DateComplete"), xRow)
            If getColumnIndex(spr, "DateApproval") > -1 Then z2346.DateApproval = getDataM(spr, getColumnIndex(spr, "DateApproval"), xRow)
            If getColumnIndex(spr, "DateCancel") > -1 Then z2346.DateCancel = getDataM(spr, getColumnIndex(spr, "DateCancel"), xRow)
            If getColumnIndex(spr, "CheckComplete") > -1 Then z2346.CheckComplete = getDataM(spr, getColumnIndex(spr, "CheckComplete"), xRow)
            If getColumnIndex(spr, "PurchasingOrderNo") > -1 Then z2346.PurchasingOrderNo = getDataM(spr, getColumnIndex(spr, "PurchasingOrderNo"), xRow)
            If getColumnIndex(spr, "PurchasingOrderSeq") > -1 Then z2346.PurchasingOrderSeq = Cdecp(getDataM(spr, getColumnIndex(spr, "PurchasingOrderSeq"), xRow))
            If getColumnIndex(spr, "JobCardWorking") > -1 Then z2346.JobCardWorking = getDataM(spr, getColumnIndex(spr, "JobCardWorking"), xRow)
            If getColumnIndex(spr, "JobCardWorkingSeq") > -1 Then z2346.JobCardWorkingSeq = getDataM(spr, getColumnIndex(spr, "JobCardWorkingSeq"), xRow)
            If getColumnIndex(spr, "JobCardType") > -1 Then z2346.JobCardType = getDataM(spr, getColumnIndex(spr, "JobCardType"), xRow)
            If getColumnIndex(spr, "SalesOrderNo") > -1 Then z2346.SalesOrderNo = getDataM(spr, getColumnIndex(spr, "SalesOrderNo"), xRow)
            If getColumnIndex(spr, "SalesOrderSeq") > -1 Then z2346.SalesOrderSeq = getDataM(spr, getColumnIndex(spr, "SalesOrderSeq"), xRow)
            If getColumnIndex(spr, "SalesOrderSno") > -1 Then z2346.SalesOrderSno = getDataM(spr, getColumnIndex(spr, "SalesOrderSno"), xRow)
            If getColumnIndex(spr, "CheckOrderType") > -1 Then z2346.CheckOrderType = getDataM(spr, getColumnIndex(spr, "CheckOrderType"), xRow)
            If getColumnIndex(spr, "OrderNo") > -1 Then z2346.OrderNo = getDataM(spr, getColumnIndex(spr, "OrderNo"), xRow)
            If getColumnIndex(spr, "OrderNoSeq") > -1 Then z2346.OrderNoSeq = getDataM(spr, getColumnIndex(spr, "OrderNoSeq"), xRow)
            If getColumnIndex(spr, "JobCard") > -1 Then z2346.JobCard = getDataM(spr, getColumnIndex(spr, "JobCard"), xRow)
            If getColumnIndex(spr, "DateSync") > -1 Then z2346.DateSync = getDataM(spr, getColumnIndex(spr, "DateSync"), xRow)
            If getColumnIndex(spr, "CheckSync") > -1 Then z2346.CheckSync = getDataM(spr, getColumnIndex(spr, "CheckSync"), xRow)
            If getColumnIndex(spr, "SlNo") > -1 Then z2346.SlNo = getDataM(spr, getColumnIndex(spr, "SlNo"), xRow)
            If getColumnIndex(spr, "Check_Spec_1") > -1 Then z2346.Check_Spec_1 = getDataM(spr, getColumnIndex(spr, "Check_Spec_1"), xRow)
            If getColumnIndex(spr, "Check_Spec_2") > -1 Then z2346.Check_Spec_2 = getDataM(spr, getColumnIndex(spr, "Check_Spec_2"), xRow)
            If getColumnIndex(spr, "Check_Spec_3") > -1 Then z2346.Check_Spec_3 = getDataM(spr, getColumnIndex(spr, "Check_Spec_3"), xRow)
            If getColumnIndex(spr, "Check_Spec_4") > -1 Then z2346.Check_Spec_4 = getDataM(spr, getColumnIndex(spr, "Check_Spec_4"), xRow)
            If getColumnIndex(spr, "Check_Spec_5") > -1 Then z2346.Check_Spec_5 = getDataM(spr, getColumnIndex(spr, "Check_Spec_5"), xRow)
            If getColumnIndex(spr, "Check_Spec_6") > -1 Then z2346.Check_Spec_6 = getDataM(spr, getColumnIndex(spr, "Check_Spec_6"), xRow)
            If getColumnIndex(spr, "Check_Spec_7") > -1 Then z2346.Check_Spec_7 = getDataM(spr, getColumnIndex(spr, "Check_Spec_7"), xRow)
            If getColumnIndex(spr, "Check_Spec_8") > -1 Then z2346.Check_Spec_8 = getDataM(spr, getColumnIndex(spr, "Check_Spec_8"), xRow)
            If getColumnIndex(spr, "Check_Spec_9") > -1 Then z2346.Check_Spec_9 = getDataM(spr, getColumnIndex(spr, "Check_Spec_9"), xRow)
            If getColumnIndex(spr, "Remark") > -1 Then z2346.Remark = getDataM(spr, getColumnIndex(spr, "Remark"), xRow)
            If getColumnIndex(spr, "TimeInsert") > -1 Then z2346.TimeInsert = getDataM(spr, getColumnIndex(spr, "TimeInsert"), xRow)
            If getColumnIndex(spr, "TimeUpdate") > -1 Then z2346.TimeUpdate = getDataM(spr, getColumnIndex(spr, "TimeUpdate"), xRow)
            If getColumnIndex(spr, "DateInsert") > -1 Then z2346.DateInsert = getDataM(spr, getColumnIndex(spr, "DateInsert"), xRow)
            If getColumnIndex(spr, "DateUpdate") > -1 Then z2346.DateUpdate = getDataM(spr, getColumnIndex(spr, "DateUpdate"), xRow)
            If getColumnIndex(spr, "InchargeInsert") > -1 Then z2346.InchargeInsert = getDataM(spr, getColumnIndex(spr, "InchargeInsert"), xRow)
            If getColumnIndex(spr, "InchargeUpdate") > -1 Then z2346.InchargeUpdate = getDataM(spr, getColumnIndex(spr, "InchargeUpdate"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K2346_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K2346_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z2346 As T2346_AREA, Job As String, FACTORDERNO As String, FACTORDERSEQ As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K2346_MOVE = False

        Try
            If READ_PFK2346(FACTORDERNO, FACTORDERSEQ) = True Then
                z2346 = D2346
                K2346_MOVE = True
            Else
                z2346 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK2346")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "FACTORDERNO" : z2346.FactOrderNo = Children(i).Code
                                Case "FACTORDERSEQ" : z2346.FactOrderSeq = Children(i).Code
                                Case "CUSTSPECNO" : z2346.CustSpecNo = Children(i).Code
                                Case "PRODUCTCODE" : z2346.ProductCode = Children(i).Code
                                Case "ARTICLE" : z2346.Article = Children(i).Code
                                Case "CUSTPONO" : z2346.CustPoNo = Children(i).Code
                                Case "FACPO" : z2346.FacPO = Children(i).Code
                                Case "PONO" : z2346.PONO = Children(i).Code
                                Case "PKO" : z2346.PKO = Children(i).Code
                                Case "CUSTOMERNAME" : z2346.CustomerName = Children(i).Code
                                Case "DECLARENO" : z2346.DeclareNo = Children(i).Code
                                Case "DateLable" : z2346.DateLable = Children(i).Code
                                Case "INCHARGEDECLARE" : z2346.InchargeDeclare = Children(i).Code
                                Case "DECLAREAMOUNT" : z2346.DeclareAmount = Children(i).Code
                                Case "DECLAREWGT" : z2346.DeclareWgt = Children(i).Code
                                Case "SESITE" : z2346.seSite = Children(i).Code
                                Case "CDSITE" : z2346.cdSite = Children(i).Code
                                Case "SEDEPARTMENT" : z2346.seDepartment = Children(i).Code
                                Case "CDDEPARTMENT" : z2346.cdDepartment = Children(i).Code
                                Case "SEFACTORY" : z2346.seFactory = Children(i).Code
                                Case "CDFACTORY" : z2346.cdFactory = Children(i).Code
                                Case "SELINEPROD" : z2346.seLineProd = Children(i).Code
                                Case "CDLINEPROD" : z2346.cdLineProd = Children(i).Code
                                Case "SESUBPROCESS" : z2346.seSubProcess = Children(i).Code
                                Case "CDSUBPROCESS" : z2346.cdSubProcess = Children(i).Code
                                Case "SEGROUPCOMPONENT" : z2346.seGroupComponent = Children(i).Code
                                Case "CDGROUPCOMPONENT" : z2346.cdGroupComponent = Children(i).Code
                                Case "CUSTOMERSUPPLIER" : z2346.CustomerSupplier = Children(i).Code
                                Case "DSEQ" : z2346.Dseq = Children(i).Code
                                Case "PSEQ" : z2346.Pseq = Children(i).Code
                                Case "AUTOKEYK3011" : z2346.AutokeyK3011 = Children(i).Code
                                Case "CHECKRELATIONTYPE" : z2346.CheckRelationType = Children(i).Code
                                Case "COMPONENTNAME" : z2346.ComponentName = Children(i).Code
                                Case "MATERIALCODE" : z2346.MaterialCode = Children(i).Code
                                Case "SPECIFICATION" : z2346.Specification = Children(i).Code
                                Case "WIDTH" : z2346.Width = Children(i).Code
                                Case "HEIGHT" : z2346.Height = Children(i).Code
                                Case "SIZENO" : z2346.SizeNo = Children(i).Code
                                Case "SIZENAME" : z2346.SizeName = Children(i).Code
                                Case "COLORCODE" : z2346.ColorCode = Children(i).Code
                                Case "COLORNAME" : z2346.ColorName = Children(i).Code
                                Case "SEORIGIN" : z2346.seOrigin = Children(i).Code
                                Case "CDORIGIN" : z2346.cdOrigin = Children(i).Code
                                Case "MATERIALCHECK" : z2346.MaterialCheck = Children(i).Code
                                Case "SEUNITPRICE" : z2346.seUnitPrice = Children(i).Code
                                Case "CDUNITPRICE" : z2346.cdUnitPrice = Children(i).Code
                                Case "SETAX" : z2346.seTax = Children(i).Code
                                Case "CDTAX" : z2346.cdTax = Children(i).Code
                                Case "SEUNITMATERIAL" : z2346.seUnitMaterial = Children(i).Code
                                Case "CDUNITMATERIAL" : z2346.cdUnitMaterial = Children(i).Code
                                Case "SEUNITPACKING" : z2346.seUnitPacking = Children(i).Code
                                Case "CDUNITPACKING" : z2346.cdUnitPacking = Children(i).Code
                                Case "UNITBASECHECK" : z2346.UnitBaseCheck = Children(i).Code
                                Case "QTYBASIC" : z2346.QtyBasic = Children(i).Code
                                Case "PRICEPURCHASING" : z2346.PricePurchasing = Children(i).Code
                                Case "PRICEMARKET" : z2346.PriceMarket = Children(i).Code
                                Case "PRICEEXCHANGE" : z2346.PriceExchange = Children(i).Code
                                Case "PRICEEXCHANGEAP" : z2346.PriceExchangeAP = Children(i).Code
                                Case "DATEEXCHANGE" : z2346.DateExchange = Children(i).Code
                                Case "PRICEPURCHASINGEX" : z2346.PricePurchasingEX = Children(i).Code
                                Case "PRICEMARKETEX" : z2346.PriceMarketEX = Children(i).Code
                                Case "PRICEPURCHASINGVND" : z2346.PricePurchasingVND = Children(i).Code
                                Case "PRICEMARKETVND" : z2346.PriceMarketVND = Children(i).Code
                                Case "AMOUNTPURCHASINGEX" : z2346.AmountPurchasingEX = Children(i).Code
                                Case "AMOUNTPURCHASINGVND" : z2346.AmountPurchasingVND = Children(i).Code
                                Case "AMOUNTTAXEX" : z2346.AmountTaxEX = Children(i).Code
                                Case "AMOUNTTAXVND" : z2346.AmountTaxVND = Children(i).Code
                                Case "SETAX1" : z2346.seTax1 = Children(i).Code
                                Case "CDTAX1" : z2346.cdTax1 = Children(i).Code
                                Case "PERTAX1" : z2346.PerTax1 = Children(i).Code
                                Case "AMOUNTTAX1" : z2346.AmountTax1 = Children(i).Code
                                Case "SETAX2" : z2346.seTax2 = Children(i).Code
                                Case "CDTAX2" : z2346.cdTax2 = Children(i).Code
                                Case "PERTAX2" : z2346.PerTax2 = Children(i).Code
                                Case "AMOUNTTAX2" : z2346.AmountTax2 = Children(i).Code
                                Case "SETAX3" : z2346.seTax3 = Children(i).Code
                                Case "CDTAX3" : z2346.cdTax3 = Children(i).Code
                                Case "PERTAX3" : z2346.PerTax3 = Children(i).Code
                                Case "AMOUNTTAX3" : z2346.AmountTax3 = Children(i).Code
                                Case "QTYREQUESTPO" : z2346.QtyRequestPO = Children(i).Code
                                Case "QTYPURCHASINGNET" : z2346.QtyPurchasingNet = Children(i).Code
                                Case "QTYPURCHASINGMOQ" : z2346.QtyPurchasingMOQ = Children(i).Code
                                Case "QTYPURCHASING" : z2346.QtyPurchasing = Children(i).Code
                                Case "PACKPURCHASING" : z2346.PackPurchasing = Children(i).Code
                                Case "QTYWAREHOUSE" : z2346.QtyWarehouse = Children(i).Code
                                Case "PACKWAREHOUSE" : z2346.PackWarehouse = Children(i).Code
                                Case "QTYINBOUND" : z2346.QtyInbound = Children(i).Code
                                Case "PACKINBOUND" : z2346.PackInbound = Children(i).Code
                                Case "QTYOUTBOUND" : z2346.QtyOutbound = Children(i).Code
                                Case "PACKOUTBOUND" : z2346.PackOutbound = Children(i).Code
                                Case "AMOUNTEX" : z2346.AmountEX = Children(i).Code
                                Case "AMOUNTVND" : z2346.AmountVND = Children(i).Code
                                Case "AMOUNTINBOUNDEX" : z2346.AmountInBoundEX = Children(i).Code
                                Case "AMOUNTINBOUNDVND" : z2346.AmountInBoundVND = Children(i).Code
                                Case "DATEDELIVERY" : z2346.DateDelivery = Children(i).Code
                                Case "DATESTART" : z2346.DateStart = Children(i).Code
                                Case "DATEFINISH" : z2346.DateFinish = Children(i).Code
                                Case "CHECKPURCHASING" : z2346.CheckPurchasing = Children(i).Code
                                Case "DATEACCEPT" : z2346.DateAccept = Children(i).Code
                                Case "DATEPOSTED" : z2346.DatePosted = Children(i).Code
                                Case "ISPOSTED" : z2346.IsPosted = Children(i).Code
                                Case "DATECOMPLETE" : z2346.DateComplete = Children(i).Code
                                Case "DATEAPPROVAL" : z2346.DateApproval = Children(i).Code
                                Case "DATECANCEL" : z2346.DateCancel = Children(i).Code
                                Case "CHECKCOMPLETE" : z2346.CheckComplete = Children(i).Code
                                Case "PURCHASINGORDERNO" : z2346.PurchasingOrderNo = Children(i).Code
                                Case "PURCHASINGORDERSEQ" : z2346.PurchasingOrderSeq = Children(i).Code
                                Case "JOBCARDWORKING" : z2346.JobCardWorking = Children(i).Code
                                Case "JOBCARDWORKINGSEQ" : z2346.JobCardWorkingSeq = Children(i).Code
                                Case "JOBCARDTYPE" : z2346.JobCardType = Children(i).Code
                                Case "SALESORDERNO" : z2346.SalesOrderNo = Children(i).Code
                                Case "SALESORDERSEQ" : z2346.SalesOrderSeq = Children(i).Code
                                Case "SALESORDERSNO" : z2346.SalesOrderSno = Children(i).Code
                                Case "CHECKORDERTYPE" : z2346.CheckOrderType = Children(i).Code
                                Case "ORDERNO" : z2346.OrderNo = Children(i).Code
                                Case "ORDERNOSEQ" : z2346.OrderNoSeq = Children(i).Code
                                Case "JOBCARD" : z2346.JobCard = Children(i).Code
                                Case "DATESYNC" : z2346.DateSync = Children(i).Code
                                Case "CHECKSYNC" : z2346.CheckSync = Children(i).Code
                                Case "SLNO" : z2346.SlNo = Children(i).Code
                                Case "CHECK_SPEC_1" : z2346.Check_Spec_1 = Children(i).Code
                                Case "CHECK_SPEC_2" : z2346.Check_Spec_2 = Children(i).Code
                                Case "CHECK_SPEC_3" : z2346.Check_Spec_3 = Children(i).Code
                                Case "CHECK_SPEC_4" : z2346.Check_Spec_4 = Children(i).Code
                                Case "CHECK_SPEC_5" : z2346.Check_Spec_5 = Children(i).Code
                                Case "CHECK_SPEC_6" : z2346.Check_Spec_6 = Children(i).Code
                                Case "CHECK_SPEC_7" : z2346.Check_Spec_7 = Children(i).Code
                                Case "CHECK_SPEC_8" : z2346.Check_Spec_8 = Children(i).Code
                                Case "CHECK_SPEC_9" : z2346.Check_Spec_9 = Children(i).Code
                                Case "REMARK" : z2346.Remark = Children(i).Code
                                Case "TIMEINSERT" : z2346.TimeInsert = Children(i).Code
                                Case "TIMEUPDATE" : z2346.TimeUpdate = Children(i).Code
                                Case "DATEINSERT" : z2346.DateInsert = Children(i).Code
                                Case "DATEUPDATE" : z2346.DateUpdate = Children(i).Code
                                Case "INCHARGEINSERT" : z2346.InchargeInsert = Children(i).Code
                                Case "INCHARGEUPDATE" : z2346.InchargeUpdate = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "FACTORDERNO" : z2346.FactOrderNo = Children(i).Data
                                Case "FACTORDERSEQ" : z2346.FactOrderSeq = Cdecp(Children(i).Data)
                                Case "CUSTSPECNO" : z2346.CustSpecNo = Children(i).Data
                                Case "PRODUCTCODE" : z2346.ProductCode = Children(i).Data
                                Case "ARTICLE" : z2346.Article = Children(i).Data
                                Case "CUSTPONO" : z2346.CustPoNo = Children(i).Data
                                Case "FACPO" : z2346.FacPO = Children(i).Data
                                Case "PONO" : z2346.PONO = Children(i).Data
                                Case "PKO" : z2346.PKO = Children(i).Data
                                Case "CUSTOMERNAME" : z2346.CustomerName = Children(i).Data
                                Case "DECLARENO" : z2346.DeclareNo = Children(i).Data
                                Case "DateLable" : z2346.DateLable = Children(i).Data
                                Case "INCHARGEDECLARE" : z2346.InchargeDeclare = Children(i).Data
                                Case "DECLAREAMOUNT" : z2346.DeclareAmount = Cdecp(Children(i).Data)
                                Case "DECLAREWGT" : z2346.DeclareWgt = Cdecp(Children(i).Data)
                                Case "SESITE" : z2346.seSite = Children(i).Data
                                Case "CDSITE" : z2346.cdSite = Children(i).Data
                                Case "SEDEPARTMENT" : z2346.seDepartment = Children(i).Data
                                Case "CDDEPARTMENT" : z2346.cdDepartment = Children(i).Data
                                Case "SEFACTORY" : z2346.seFactory = Children(i).Data
                                Case "CDFACTORY" : z2346.cdFactory = Children(i).Data
                                Case "SELINEPROD" : z2346.seLineProd = Children(i).Data
                                Case "CDLINEPROD" : z2346.cdLineProd = Children(i).Data
                                Case "SESUBPROCESS" : z2346.seSubProcess = Children(i).Data
                                Case "CDSUBPROCESS" : z2346.cdSubProcess = Children(i).Data
                                Case "SEGROUPCOMPONENT" : z2346.seGroupComponent = Children(i).Data
                                Case "CDGROUPCOMPONENT" : z2346.cdGroupComponent = Children(i).Data
                                Case "CUSTOMERSUPPLIER" : z2346.CustomerSupplier = Children(i).Data
                                Case "DSEQ" : z2346.Dseq = Cdecp(Children(i).Data)
                                Case "PSEQ" : z2346.Pseq = Cdecp(Children(i).Data)
                                Case "AUTOKEYK3011" : z2346.AutokeyK3011 = Cdecp(Children(i).Data)
                                Case "CHECKRELATIONTYPE" : z2346.CheckRelationType = Children(i).Data
                                Case "COMPONENTNAME" : z2346.ComponentName = Children(i).Data
                                Case "MATERIALCODE" : z2346.MaterialCode = Children(i).Data
                                Case "SPECIFICATION" : z2346.Specification = Children(i).Data
                                Case "WIDTH" : z2346.Width = Children(i).Data
                                Case "HEIGHT" : z2346.Height = Children(i).Data
                                Case "SIZENO" : z2346.SizeNo = Children(i).Data
                                Case "SIZENAME" : z2346.SizeName = Children(i).Data
                                Case "COLORCODE" : z2346.ColorCode = Children(i).Data
                                Case "COLORNAME" : z2346.ColorName = Children(i).Data
                                Case "SEORIGIN" : z2346.seOrigin = Children(i).Data
                                Case "CDORIGIN" : z2346.cdOrigin = Children(i).Data
                                Case "MATERIALCHECK" : z2346.MaterialCheck = Children(i).Data
                                Case "SEUNITPRICE" : z2346.seUnitPrice = Children(i).Data
                                Case "CDUNITPRICE" : z2346.cdUnitPrice = Children(i).Data
                                Case "SETAX" : z2346.seTax = Children(i).Data
                                Case "CDTAX" : z2346.cdTax = Children(i).Data
                                Case "SEUNITMATERIAL" : z2346.seUnitMaterial = Children(i).Data
                                Case "CDUNITMATERIAL" : z2346.cdUnitMaterial = Children(i).Data
                                Case "SEUNITPACKING" : z2346.seUnitPacking = Children(i).Data
                                Case "CDUNITPACKING" : z2346.cdUnitPacking = Children(i).Data
                                Case "UNITBASECHECK" : z2346.UnitBaseCheck = Children(i).Data
                                Case "QTYBASIC" : z2346.QtyBasic = Cdecp(Children(i).Data)
                                Case "PRICEPURCHASING" : z2346.PricePurchasing = Cdecp(Children(i).Data)
                                Case "PRICEMARKET" : z2346.PriceMarket = Cdecp(Children(i).Data)
                                Case "PRICEEXCHANGE" : z2346.PriceExchange = Cdecp(Children(i).Data)
                                Case "PRICEEXCHANGEAP" : z2346.PriceExchangeAP = Cdecp(Children(i).Data)
                                Case "DATEEXCHANGE" : z2346.DateExchange = Children(i).Data
                                Case "PRICEPURCHASINGEX" : z2346.PricePurchasingEX = Cdecp(Children(i).Data)
                                Case "PRICEMARKETEX" : z2346.PriceMarketEX = Cdecp(Children(i).Data)
                                Case "PRICEPURCHASINGVND" : z2346.PricePurchasingVND = Cdecp(Children(i).Data)
                                Case "PRICEMARKETVND" : z2346.PriceMarketVND = Cdecp(Children(i).Data)
                                Case "AMOUNTPURCHASINGEX" : z2346.AmountPurchasingEX = Cdecp(Children(i).Data)
                                Case "AMOUNTPURCHASINGVND" : z2346.AmountPurchasingVND = Cdecp(Children(i).Data)
                                Case "AMOUNTTAXEX" : z2346.AmountTaxEX = Cdecp(Children(i).Data)
                                Case "AMOUNTTAXVND" : z2346.AmountTaxVND = Cdecp(Children(i).Data)
                                Case "SETAX1" : z2346.seTax1 = Children(i).Data
                                Case "CDTAX1" : z2346.cdTax1 = Children(i).Data
                                Case "PERTAX1" : z2346.PerTax1 = Cdecp(Children(i).Data)
                                Case "AMOUNTTAX1" : z2346.AmountTax1 = Cdecp(Children(i).Data)
                                Case "SETAX2" : z2346.seTax2 = Children(i).Data
                                Case "CDTAX2" : z2346.cdTax2 = Children(i).Data
                                Case "PERTAX2" : z2346.PerTax2 = Cdecp(Children(i).Data)
                                Case "AMOUNTTAX2" : z2346.AmountTax2 = Cdecp(Children(i).Data)
                                Case "SETAX3" : z2346.seTax3 = Children(i).Data
                                Case "CDTAX3" : z2346.cdTax3 = Children(i).Data
                                Case "PERTAX3" : z2346.PerTax3 = Cdecp(Children(i).Data)
                                Case "AMOUNTTAX3" : z2346.AmountTax3 = Cdecp(Children(i).Data)
                                Case "QTYREQUESTPO" : z2346.QtyRequestPO = Cdecp(Children(i).Data)
                                Case "QTYPURCHASINGNET" : z2346.QtyPurchasingNet = Cdecp(Children(i).Data)
                                Case "QTYPURCHASINGMOQ" : z2346.QtyPurchasingMOQ = Cdecp(Children(i).Data)
                                Case "QTYPURCHASING" : z2346.QtyPurchasing = Cdecp(Children(i).Data)
                                Case "PACKPURCHASING" : z2346.PackPurchasing = Cdecp(Children(i).Data)
                                Case "QTYWAREHOUSE" : z2346.QtyWarehouse = Cdecp(Children(i).Data)
                                Case "PACKWAREHOUSE" : z2346.PackWarehouse = Cdecp(Children(i).Data)
                                Case "QTYINBOUND" : z2346.QtyInbound = Cdecp(Children(i).Data)
                                Case "PACKINBOUND" : z2346.PackInbound = Cdecp(Children(i).Data)
                                Case "QTYOUTBOUND" : z2346.QtyOutbound = Cdecp(Children(i).Data)
                                Case "PACKOUTBOUND" : z2346.PackOutbound = Cdecp(Children(i).Data)
                                Case "AMOUNTEX" : z2346.AmountEX = Cdecp(Children(i).Data)
                                Case "AMOUNTVND" : z2346.AmountVND = Cdecp(Children(i).Data)
                                Case "AMOUNTINBOUNDEX" : z2346.AmountInBoundEX = Cdecp(Children(i).Data)
                                Case "AMOUNTINBOUNDVND" : z2346.AmountInBoundVND = Cdecp(Children(i).Data)
                                Case "DATEDELIVERY" : z2346.DateDelivery = Children(i).Data
                                Case "DATESTART" : z2346.DateStart = Children(i).Data
                                Case "DATEFINISH" : z2346.DateFinish = Children(i).Data
                                Case "CHECKPURCHASING" : z2346.CheckPurchasing = Children(i).Data
                                Case "DATEACCEPT" : z2346.DateAccept = Children(i).Data
                                Case "DATEPOSTED" : z2346.DatePosted = Children(i).Data
                                Case "ISPOSTED" : z2346.IsPosted = Children(i).Data
                                Case "DATECOMPLETE" : z2346.DateComplete = Children(i).Data
                                Case "DATEAPPROVAL" : z2346.DateApproval = Children(i).Data
                                Case "DATECANCEL" : z2346.DateCancel = Children(i).Data
                                Case "CHECKCOMPLETE" : z2346.CheckComplete = Children(i).Data
                                Case "PURCHASINGORDERNO" : z2346.PurchasingOrderNo = Children(i).Data
                                Case "PURCHASINGORDERSEQ" : z2346.PurchasingOrderSeq = Cdecp(Children(i).Data)
                                Case "JOBCARDWORKING" : z2346.JobCardWorking = Children(i).Data
                                Case "JOBCARDWORKINGSEQ" : z2346.JobCardWorkingSeq = Children(i).Data
                                Case "JOBCARDTYPE" : z2346.JobCardType = Children(i).Data
                                Case "SALESORDERNO" : z2346.SalesOrderNo = Children(i).Data
                                Case "SALESORDERSEQ" : z2346.SalesOrderSeq = Children(i).Data
                                Case "SALESORDERSNO" : z2346.SalesOrderSno = Children(i).Data
                                Case "CHECKORDERTYPE" : z2346.CheckOrderType = Children(i).Data
                                Case "ORDERNO" : z2346.OrderNo = Children(i).Data
                                Case "ORDERNOSEQ" : z2346.OrderNoSeq = Children(i).Data
                                Case "JOBCARD" : z2346.JobCard = Children(i).Data
                                Case "DATESYNC" : z2346.DateSync = Children(i).Data
                                Case "CHECKSYNC" : z2346.CheckSync = Children(i).Data
                                Case "SLNO" : z2346.SlNo = Children(i).Data
                                Case "CHECK_SPEC_1" : z2346.Check_Spec_1 = Children(i).Data
                                Case "CHECK_SPEC_2" : z2346.Check_Spec_2 = Children(i).Data
                                Case "CHECK_SPEC_3" : z2346.Check_Spec_3 = Children(i).Data
                                Case "CHECK_SPEC_4" : z2346.Check_Spec_4 = Children(i).Data
                                Case "CHECK_SPEC_5" : z2346.Check_Spec_5 = Children(i).Data
                                Case "CHECK_SPEC_6" : z2346.Check_Spec_6 = Children(i).Data
                                Case "CHECK_SPEC_7" : z2346.Check_Spec_7 = Children(i).Data
                                Case "CHECK_SPEC_8" : z2346.Check_Spec_8 = Children(i).Data
                                Case "CHECK_SPEC_9" : z2346.Check_Spec_9 = Children(i).Data
                                Case "REMARK" : z2346.Remark = Children(i).Data
                                Case "TIMEINSERT" : z2346.TimeInsert = Children(i).Data
                                Case "TIMEUPDATE" : z2346.TimeUpdate = Children(i).Data
                                Case "DATEINSERT" : z2346.DateInsert = Children(i).Data
                                Case "DATEUPDATE" : z2346.DateUpdate = Children(i).Data
                                Case "INCHARGEINSERT" : z2346.InchargeInsert = Children(i).Data
                                Case "INCHARGEUPDATE" : z2346.InchargeUpdate = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K2346_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K2346_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z2346 As T2346_AREA, Job As String, CheckClear As Boolean, FACTORDERNO As String, FACTORDERSEQ As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K2346_MOVE = False

        Try
            If READ_PFK2346(FACTORDERNO, FACTORDERSEQ) = True Then
                z2346 = D2346
                K2346_MOVE = True
            Else
                If CheckClear = True Then z2346 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK2346")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "FACTORDERNO" : z2346.FactOrderNo = Children(i).Code
                                Case "FACTORDERSEQ" : z2346.FactOrderSeq = Children(i).Code
                                Case "CUSTSPECNO" : z2346.CustSpecNo = Children(i).Code
                                Case "PRODUCTCODE" : z2346.ProductCode = Children(i).Code
                                Case "ARTICLE" : z2346.Article = Children(i).Code
                                Case "CUSTPONO" : z2346.CustPoNo = Children(i).Code
                                Case "FACPO" : z2346.FacPO = Children(i).Code
                                Case "PONO" : z2346.PONO = Children(i).Code
                                Case "PKO" : z2346.PKO = Children(i).Code
                                Case "CUSTOMERNAME" : z2346.CustomerName = Children(i).Code
                                Case "DECLARENO" : z2346.DeclareNo = Children(i).Code
                                Case "DateLable" : z2346.DateLable = Children(i).Code
                                Case "INCHARGEDECLARE" : z2346.InchargeDeclare = Children(i).Code
                                Case "DECLAREAMOUNT" : z2346.DeclareAmount = Children(i).Code
                                Case "DECLAREWGT" : z2346.DeclareWgt = Children(i).Code
                                Case "SESITE" : z2346.seSite = Children(i).Code
                                Case "CDSITE" : z2346.cdSite = Children(i).Code
                                Case "SEDEPARTMENT" : z2346.seDepartment = Children(i).Code
                                Case "CDDEPARTMENT" : z2346.cdDepartment = Children(i).Code
                                Case "SEFACTORY" : z2346.seFactory = Children(i).Code
                                Case "CDFACTORY" : z2346.cdFactory = Children(i).Code
                                Case "SELINEPROD" : z2346.seLineProd = Children(i).Code
                                Case "CDLINEPROD" : z2346.cdLineProd = Children(i).Code
                                Case "SESUBPROCESS" : z2346.seSubProcess = Children(i).Code
                                Case "CDSUBPROCESS" : z2346.cdSubProcess = Children(i).Code
                                Case "SEGROUPCOMPONENT" : z2346.seGroupComponent = Children(i).Code
                                Case "CDGROUPCOMPONENT" : z2346.cdGroupComponent = Children(i).Code
                                Case "CUSTOMERSUPPLIER" : z2346.CustomerSupplier = Children(i).Code
                                Case "DSEQ" : z2346.Dseq = Children(i).Code
                                Case "PSEQ" : z2346.Pseq = Children(i).Code
                                Case "AUTOKEYK3011" : z2346.AutokeyK3011 = Children(i).Code
                                Case "CHECKRELATIONTYPE" : z2346.CheckRelationType = Children(i).Code
                                Case "COMPONENTNAME" : z2346.ComponentName = Children(i).Code
                                Case "MATERIALCODE" : z2346.MaterialCode = Children(i).Code
                                Case "SPECIFICATION" : z2346.Specification = Children(i).Code
                                Case "WIDTH" : z2346.Width = Children(i).Code
                                Case "HEIGHT" : z2346.Height = Children(i).Code
                                Case "SIZENO" : z2346.SizeNo = Children(i).Code
                                Case "SIZENAME" : z2346.SizeName = Children(i).Code
                                Case "COLORCODE" : z2346.ColorCode = Children(i).Code
                                Case "COLORNAME" : z2346.ColorName = Children(i).Code
                                Case "SEORIGIN" : z2346.seOrigin = Children(i).Code
                                Case "CDORIGIN" : z2346.cdOrigin = Children(i).Code
                                Case "MATERIALCHECK" : z2346.MaterialCheck = Children(i).Code
                                Case "SEUNITPRICE" : z2346.seUnitPrice = Children(i).Code
                                Case "CDUNITPRICE" : z2346.cdUnitPrice = Children(i).Code
                                Case "SETAX" : z2346.seTax = Children(i).Code
                                Case "CDTAX" : z2346.cdTax = Children(i).Code
                                Case "SEUNITMATERIAL" : z2346.seUnitMaterial = Children(i).Code
                                Case "CDUNITMATERIAL" : z2346.cdUnitMaterial = Children(i).Code
                                Case "SEUNITPACKING" : z2346.seUnitPacking = Children(i).Code
                                Case "CDUNITPACKING" : z2346.cdUnitPacking = Children(i).Code
                                Case "UNITBASECHECK" : z2346.UnitBaseCheck = Children(i).Code
                                Case "QTYBASIC" : z2346.QtyBasic = Children(i).Code
                                Case "PRICEPURCHASING" : z2346.PricePurchasing = Children(i).Code
                                Case "PRICEMARKET" : z2346.PriceMarket = Children(i).Code
                                Case "PRICEEXCHANGE" : z2346.PriceExchange = Children(i).Code
                                Case "PRICEEXCHANGEAP" : z2346.PriceExchangeAP = Children(i).Code
                                Case "DATEEXCHANGE" : z2346.DateExchange = Children(i).Code
                                Case "PRICEPURCHASINGEX" : z2346.PricePurchasingEX = Children(i).Code
                                Case "PRICEMARKETEX" : z2346.PriceMarketEX = Children(i).Code
                                Case "PRICEPURCHASINGVND" : z2346.PricePurchasingVND = Children(i).Code
                                Case "PRICEMARKETVND" : z2346.PriceMarketVND = Children(i).Code
                                Case "AMOUNTPURCHASINGEX" : z2346.AmountPurchasingEX = Children(i).Code
                                Case "AMOUNTPURCHASINGVND" : z2346.AmountPurchasingVND = Children(i).Code
                                Case "AMOUNTTAXEX" : z2346.AmountTaxEX = Children(i).Code
                                Case "AMOUNTTAXVND" : z2346.AmountTaxVND = Children(i).Code
                                Case "SETAX1" : z2346.seTax1 = Children(i).Code
                                Case "CDTAX1" : z2346.cdTax1 = Children(i).Code
                                Case "PERTAX1" : z2346.PerTax1 = Children(i).Code
                                Case "AMOUNTTAX1" : z2346.AmountTax1 = Children(i).Code
                                Case "SETAX2" : z2346.seTax2 = Children(i).Code
                                Case "CDTAX2" : z2346.cdTax2 = Children(i).Code
                                Case "PERTAX2" : z2346.PerTax2 = Children(i).Code
                                Case "AMOUNTTAX2" : z2346.AmountTax2 = Children(i).Code
                                Case "SETAX3" : z2346.seTax3 = Children(i).Code
                                Case "CDTAX3" : z2346.cdTax3 = Children(i).Code
                                Case "PERTAX3" : z2346.PerTax3 = Children(i).Code
                                Case "AMOUNTTAX3" : z2346.AmountTax3 = Children(i).Code
                                Case "QTYREQUESTPO" : z2346.QtyRequestPO = Children(i).Code
                                Case "QTYPURCHASINGNET" : z2346.QtyPurchasingNet = Children(i).Code
                                Case "QTYPURCHASINGMOQ" : z2346.QtyPurchasingMOQ = Children(i).Code
                                Case "QTYPURCHASING" : z2346.QtyPurchasing = Children(i).Code
                                Case "PACKPURCHASING" : z2346.PackPurchasing = Children(i).Code
                                Case "QTYWAREHOUSE" : z2346.QtyWarehouse = Children(i).Code
                                Case "PACKWAREHOUSE" : z2346.PackWarehouse = Children(i).Code
                                Case "QTYINBOUND" : z2346.QtyInbound = Children(i).Code
                                Case "PACKINBOUND" : z2346.PackInbound = Children(i).Code
                                Case "QTYOUTBOUND" : z2346.QtyOutbound = Children(i).Code
                                Case "PACKOUTBOUND" : z2346.PackOutbound = Children(i).Code
                                Case "AMOUNTEX" : z2346.AmountEX = Children(i).Code
                                Case "AMOUNTVND" : z2346.AmountVND = Children(i).Code
                                Case "AMOUNTINBOUNDEX" : z2346.AmountInBoundEX = Children(i).Code
                                Case "AMOUNTINBOUNDVND" : z2346.AmountInBoundVND = Children(i).Code
                                Case "DATEDELIVERY" : z2346.DateDelivery = Children(i).Code
                                Case "DATESTART" : z2346.DateStart = Children(i).Code
                                Case "DATEFINISH" : z2346.DateFinish = Children(i).Code
                                Case "CHECKPURCHASING" : z2346.CheckPurchasing = Children(i).Code
                                Case "DATEACCEPT" : z2346.DateAccept = Children(i).Code
                                Case "DATEPOSTED" : z2346.DatePosted = Children(i).Code
                                Case "ISPOSTED" : z2346.IsPosted = Children(i).Code
                                Case "DATECOMPLETE" : z2346.DateComplete = Children(i).Code
                                Case "DATEAPPROVAL" : z2346.DateApproval = Children(i).Code
                                Case "DATECANCEL" : z2346.DateCancel = Children(i).Code
                                Case "CHECKCOMPLETE" : z2346.CheckComplete = Children(i).Code
                                Case "PURCHASINGORDERNO" : z2346.PurchasingOrderNo = Children(i).Code
                                Case "PURCHASINGORDERSEQ" : z2346.PurchasingOrderSeq = Children(i).Code
                                Case "JOBCARDWORKING" : z2346.JobCardWorking = Children(i).Code
                                Case "JOBCARDWORKINGSEQ" : z2346.JobCardWorkingSeq = Children(i).Code
                                Case "JOBCARDTYPE" : z2346.JobCardType = Children(i).Code
                                Case "SALESORDERNO" : z2346.SalesOrderNo = Children(i).Code
                                Case "SALESORDERSEQ" : z2346.SalesOrderSeq = Children(i).Code
                                Case "SALESORDERSNO" : z2346.SalesOrderSno = Children(i).Code
                                Case "CHECKORDERTYPE" : z2346.CheckOrderType = Children(i).Code
                                Case "ORDERNO" : z2346.OrderNo = Children(i).Code
                                Case "ORDERNOSEQ" : z2346.OrderNoSeq = Children(i).Code
                                Case "JOBCARD" : z2346.JobCard = Children(i).Code
                                Case "DATESYNC" : z2346.DateSync = Children(i).Code
                                Case "CHECKSYNC" : z2346.CheckSync = Children(i).Code
                                Case "SLNO" : z2346.SlNo = Children(i).Code
                                Case "CHECK_SPEC_1" : z2346.Check_Spec_1 = Children(i).Code
                                Case "CHECK_SPEC_2" : z2346.Check_Spec_2 = Children(i).Code
                                Case "CHECK_SPEC_3" : z2346.Check_Spec_3 = Children(i).Code
                                Case "CHECK_SPEC_4" : z2346.Check_Spec_4 = Children(i).Code
                                Case "CHECK_SPEC_5" : z2346.Check_Spec_5 = Children(i).Code
                                Case "CHECK_SPEC_6" : z2346.Check_Spec_6 = Children(i).Code
                                Case "CHECK_SPEC_7" : z2346.Check_Spec_7 = Children(i).Code
                                Case "CHECK_SPEC_8" : z2346.Check_Spec_8 = Children(i).Code
                                Case "CHECK_SPEC_9" : z2346.Check_Spec_9 = Children(i).Code
                                Case "REMARK" : z2346.Remark = Children(i).Code
                                Case "TIMEINSERT" : z2346.TimeInsert = Children(i).Code
                                Case "TIMEUPDATE" : z2346.TimeUpdate = Children(i).Code
                                Case "DATEINSERT" : z2346.DateInsert = Children(i).Code
                                Case "DATEUPDATE" : z2346.DateUpdate = Children(i).Code
                                Case "INCHARGEINSERT" : z2346.InchargeInsert = Children(i).Code
                                Case "INCHARGEUPDATE" : z2346.InchargeUpdate = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "FACTORDERNO" : z2346.FactOrderNo = Children(i).Data
                                Case "FACTORDERSEQ" : z2346.FactOrderSeq = Cdecp(Children(i).Data)
                                Case "CUSTSPECNO" : z2346.CustSpecNo = Children(i).Data
                                Case "PRODUCTCODE" : z2346.ProductCode = Children(i).Data
                                Case "ARTICLE" : z2346.Article = Children(i).Data
                                Case "CUSTPONO" : z2346.CustPoNo = Children(i).Data
                                Case "FACPO" : z2346.FacPO = Children(i).Data
                                Case "PONO" : z2346.PONO = Children(i).Data
                                Case "PKO" : z2346.PKO = Children(i).Data
                                Case "CUSTOMERNAME" : z2346.CustomerName = Children(i).Data
                                Case "DECLARENO" : z2346.DeclareNo = Children(i).Data
                                Case "DateLable" : z2346.DateLable = Children(i).Data
                                Case "INCHARGEDECLARE" : z2346.InchargeDeclare = Children(i).Data
                                Case "DECLAREAMOUNT" : z2346.DeclareAmount = Cdecp(Children(i).Data)
                                Case "DECLAREWGT" : z2346.DeclareWgt = Cdecp(Children(i).Data)
                                Case "SESITE" : z2346.seSite = Children(i).Data
                                Case "CDSITE" : z2346.cdSite = Children(i).Data
                                Case "SEDEPARTMENT" : z2346.seDepartment = Children(i).Data
                                Case "CDDEPARTMENT" : z2346.cdDepartment = Children(i).Data
                                Case "SEFACTORY" : z2346.seFactory = Children(i).Data
                                Case "CDFACTORY" : z2346.cdFactory = Children(i).Data
                                Case "SELINEPROD" : z2346.seLineProd = Children(i).Data
                                Case "CDLINEPROD" : z2346.cdLineProd = Children(i).Data
                                Case "SESUBPROCESS" : z2346.seSubProcess = Children(i).Data
                                Case "CDSUBPROCESS" : z2346.cdSubProcess = Children(i).Data
                                Case "SEGROUPCOMPONENT" : z2346.seGroupComponent = Children(i).Data
                                Case "CDGROUPCOMPONENT" : z2346.cdGroupComponent = Children(i).Data
                                Case "CUSTOMERSUPPLIER" : z2346.CustomerSupplier = Children(i).Data
                                Case "DSEQ" : z2346.Dseq = Cdecp(Children(i).Data)
                                Case "PSEQ" : z2346.Pseq = Cdecp(Children(i).Data)
                                Case "AUTOKEYK3011" : z2346.AutokeyK3011 = Cdecp(Children(i).Data)
                                Case "CHECKRELATIONTYPE" : z2346.CheckRelationType = Children(i).Data
                                Case "COMPONENTNAME" : z2346.ComponentName = Children(i).Data
                                Case "MATERIALCODE" : z2346.MaterialCode = Children(i).Data
                                Case "SPECIFICATION" : z2346.Specification = Children(i).Data
                                Case "WIDTH" : z2346.Width = Children(i).Data
                                Case "HEIGHT" : z2346.Height = Children(i).Data
                                Case "SIZENO" : z2346.SizeNo = Children(i).Data
                                Case "SIZENAME" : z2346.SizeName = Children(i).Data
                                Case "COLORCODE" : z2346.ColorCode = Children(i).Data
                                Case "COLORNAME" : z2346.ColorName = Children(i).Data
                                Case "SEORIGIN" : z2346.seOrigin = Children(i).Data
                                Case "CDORIGIN" : z2346.cdOrigin = Children(i).Data
                                Case "MATERIALCHECK" : z2346.MaterialCheck = Children(i).Data
                                Case "SEUNITPRICE" : z2346.seUnitPrice = Children(i).Data
                                Case "CDUNITPRICE" : z2346.cdUnitPrice = Children(i).Data
                                Case "SETAX" : z2346.seTax = Children(i).Data
                                Case "CDTAX" : z2346.cdTax = Children(i).Data
                                Case "SEUNITMATERIAL" : z2346.seUnitMaterial = Children(i).Data
                                Case "CDUNITMATERIAL" : z2346.cdUnitMaterial = Children(i).Data
                                Case "SEUNITPACKING" : z2346.seUnitPacking = Children(i).Data
                                Case "CDUNITPACKING" : z2346.cdUnitPacking = Children(i).Data
                                Case "UNITBASECHECK" : z2346.UnitBaseCheck = Children(i).Data
                                Case "QTYBASIC" : z2346.QtyBasic = Cdecp(Children(i).Data)
                                Case "PRICEPURCHASING" : z2346.PricePurchasing = Cdecp(Children(i).Data)
                                Case "PRICEMARKET" : z2346.PriceMarket = Cdecp(Children(i).Data)
                                Case "PRICEEXCHANGE" : z2346.PriceExchange = Cdecp(Children(i).Data)
                                Case "PRICEEXCHANGEAP" : z2346.PriceExchangeAP = Cdecp(Children(i).Data)
                                Case "DATEEXCHANGE" : z2346.DateExchange = Children(i).Data
                                Case "PRICEPURCHASINGEX" : z2346.PricePurchasingEX = Cdecp(Children(i).Data)
                                Case "PRICEMARKETEX" : z2346.PriceMarketEX = Cdecp(Children(i).Data)
                                Case "PRICEPURCHASINGVND" : z2346.PricePurchasingVND = Cdecp(Children(i).Data)
                                Case "PRICEMARKETVND" : z2346.PriceMarketVND = Cdecp(Children(i).Data)
                                Case "AMOUNTPURCHASINGEX" : z2346.AmountPurchasingEX = Cdecp(Children(i).Data)
                                Case "AMOUNTPURCHASINGVND" : z2346.AmountPurchasingVND = Cdecp(Children(i).Data)
                                Case "AMOUNTTAXEX" : z2346.AmountTaxEX = Cdecp(Children(i).Data)
                                Case "AMOUNTTAXVND" : z2346.AmountTaxVND = Cdecp(Children(i).Data)
                                Case "SETAX1" : z2346.seTax1 = Children(i).Data
                                Case "CDTAX1" : z2346.cdTax1 = Children(i).Data
                                Case "PERTAX1" : z2346.PerTax1 = Cdecp(Children(i).Data)
                                Case "AMOUNTTAX1" : z2346.AmountTax1 = Cdecp(Children(i).Data)
                                Case "SETAX2" : z2346.seTax2 = Children(i).Data
                                Case "CDTAX2" : z2346.cdTax2 = Children(i).Data
                                Case "PERTAX2" : z2346.PerTax2 = Cdecp(Children(i).Data)
                                Case "AMOUNTTAX2" : z2346.AmountTax2 = Cdecp(Children(i).Data)
                                Case "SETAX3" : z2346.seTax3 = Children(i).Data
                                Case "CDTAX3" : z2346.cdTax3 = Children(i).Data
                                Case "PERTAX3" : z2346.PerTax3 = Cdecp(Children(i).Data)
                                Case "AMOUNTTAX3" : z2346.AmountTax3 = Cdecp(Children(i).Data)
                                Case "QTYREQUESTPO" : z2346.QtyRequestPO = Cdecp(Children(i).Data)
                                Case "QTYPURCHASINGNET" : z2346.QtyPurchasingNet = Cdecp(Children(i).Data)
                                Case "QTYPURCHASINGMOQ" : z2346.QtyPurchasingMOQ = Cdecp(Children(i).Data)
                                Case "QTYPURCHASING" : z2346.QtyPurchasing = Cdecp(Children(i).Data)
                                Case "PACKPURCHASING" : z2346.PackPurchasing = Cdecp(Children(i).Data)
                                Case "QTYWAREHOUSE" : z2346.QtyWarehouse = Cdecp(Children(i).Data)
                                Case "PACKWAREHOUSE" : z2346.PackWarehouse = Cdecp(Children(i).Data)
                                Case "QTYINBOUND" : z2346.QtyInbound = Cdecp(Children(i).Data)
                                Case "PACKINBOUND" : z2346.PackInbound = Cdecp(Children(i).Data)
                                Case "QTYOUTBOUND" : z2346.QtyOutbound = Cdecp(Children(i).Data)
                                Case "PACKOUTBOUND" : z2346.PackOutbound = Cdecp(Children(i).Data)
                                Case "AMOUNTEX" : z2346.AmountEX = Cdecp(Children(i).Data)
                                Case "AMOUNTVND" : z2346.AmountVND = Cdecp(Children(i).Data)
                                Case "AMOUNTINBOUNDEX" : z2346.AmountInBoundEX = Cdecp(Children(i).Data)
                                Case "AMOUNTINBOUNDVND" : z2346.AmountInBoundVND = Cdecp(Children(i).Data)
                                Case "DATEDELIVERY" : z2346.DateDelivery = Children(i).Data
                                Case "DATESTART" : z2346.DateStart = Children(i).Data
                                Case "DATEFINISH" : z2346.DateFinish = Children(i).Data
                                Case "CHECKPURCHASING" : z2346.CheckPurchasing = Children(i).Data
                                Case "DATEACCEPT" : z2346.DateAccept = Children(i).Data
                                Case "DATEPOSTED" : z2346.DatePosted = Children(i).Data
                                Case "ISPOSTED" : z2346.IsPosted = Children(i).Data
                                Case "DATECOMPLETE" : z2346.DateComplete = Children(i).Data
                                Case "DATEAPPROVAL" : z2346.DateApproval = Children(i).Data
                                Case "DATECANCEL" : z2346.DateCancel = Children(i).Data
                                Case "CHECKCOMPLETE" : z2346.CheckComplete = Children(i).Data
                                Case "PURCHASINGORDERNO" : z2346.PurchasingOrderNo = Children(i).Data
                                Case "PURCHASINGORDERSEQ" : z2346.PurchasingOrderSeq = Cdecp(Children(i).Data)
                                Case "JOBCARDWORKING" : z2346.JobCardWorking = Children(i).Data
                                Case "JOBCARDWORKINGSEQ" : z2346.JobCardWorkingSeq = Children(i).Data
                                Case "JOBCARDTYPE" : z2346.JobCardType = Children(i).Data
                                Case "SALESORDERNO" : z2346.SalesOrderNo = Children(i).Data
                                Case "SALESORDERSEQ" : z2346.SalesOrderSeq = Children(i).Data
                                Case "SALESORDERSNO" : z2346.SalesOrderSno = Children(i).Data
                                Case "CHECKORDERTYPE" : z2346.CheckOrderType = Children(i).Data
                                Case "ORDERNO" : z2346.OrderNo = Children(i).Data
                                Case "ORDERNOSEQ" : z2346.OrderNoSeq = Children(i).Data
                                Case "JOBCARD" : z2346.JobCard = Children(i).Data
                                Case "DATESYNC" : z2346.DateSync = Children(i).Data
                                Case "CHECKSYNC" : z2346.CheckSync = Children(i).Data
                                Case "SLNO" : z2346.SlNo = Children(i).Data
                                Case "CHECK_SPEC_1" : z2346.Check_Spec_1 = Children(i).Data
                                Case "CHECK_SPEC_2" : z2346.Check_Spec_2 = Children(i).Data
                                Case "CHECK_SPEC_3" : z2346.Check_Spec_3 = Children(i).Data
                                Case "CHECK_SPEC_4" : z2346.Check_Spec_4 = Children(i).Data
                                Case "CHECK_SPEC_5" : z2346.Check_Spec_5 = Children(i).Data
                                Case "CHECK_SPEC_6" : z2346.Check_Spec_6 = Children(i).Data
                                Case "CHECK_SPEC_7" : z2346.Check_Spec_7 = Children(i).Data
                                Case "CHECK_SPEC_8" : z2346.Check_Spec_8 = Children(i).Data
                                Case "CHECK_SPEC_9" : z2346.Check_Spec_9 = Children(i).Data
                                Case "REMARK" : z2346.Remark = Children(i).Data
                                Case "TIMEINSERT" : z2346.TimeInsert = Children(i).Data
                                Case "TIMEUPDATE" : z2346.TimeUpdate = Children(i).Data
                                Case "DATEINSERT" : z2346.DateInsert = Children(i).Data
                                Case "DATEUPDATE" : z2346.DateUpdate = Children(i).Data
                                Case "INCHARGEINSERT" : z2346.InchargeInsert = Children(i).Data
                                Case "INCHARGEUPDATE" : z2346.InchargeUpdate = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K2346_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW AREA
    '=========================================================================================================================================================
    Public Sub K2346_MOVE(ByRef a2346 As T2346_AREA, ByRef b2346 As T2346_AREA)
        Try
            If trim$(a2346.FactOrderNo) = "" Then b2346.FactOrderNo = "" Else b2346.FactOrderNo = a2346.FactOrderNo
            If trim$(a2346.FactOrderSeq) = "" Then b2346.FactOrderSeq = "" Else b2346.FactOrderSeq = a2346.FactOrderSeq
            If trim$(a2346.CustSpecNo) = "" Then b2346.CustSpecNo = "" Else b2346.CustSpecNo = a2346.CustSpecNo
            If trim$(a2346.ProductCode) = "" Then b2346.ProductCode = "" Else b2346.ProductCode = a2346.ProductCode
            If trim$(a2346.Article) = "" Then b2346.Article = "" Else b2346.Article = a2346.Article
            If trim$(a2346.CustPoNo) = "" Then b2346.CustPoNo = "" Else b2346.CustPoNo = a2346.CustPoNo
            If trim$(a2346.FacPO) = "" Then b2346.FacPO = "" Else b2346.FacPO = a2346.FacPO
            If trim$(a2346.PONO) = "" Then b2346.PONO = "" Else b2346.PONO = a2346.PONO
            If trim$(a2346.PKO) = "" Then b2346.PKO = "" Else b2346.PKO = a2346.PKO
            If trim$(a2346.CustomerName) = "" Then b2346.CustomerName = "" Else b2346.CustomerName = a2346.CustomerName
            If trim$(a2346.DeclareNo) = "" Then b2346.DeclareNo = "" Else b2346.DeclareNo = a2346.DeclareNo
            If trim$(a2346.DateLable) = "" Then b2346.DateLable = "" Else b2346.DateLable = a2346.DateLable
If trim$( a2346.InchargeDeclare ) = "" Then b2346.InchargeDeclare = ""  Else b2346.InchargeDeclare=a2346.InchargeDeclare
If trim$( a2346.DeclareAmount ) = "" Then b2346.DeclareAmount = ""  Else b2346.DeclareAmount=a2346.DeclareAmount
If trim$( a2346.DeclareWgt ) = "" Then b2346.DeclareWgt = ""  Else b2346.DeclareWgt=a2346.DeclareWgt
If trim$( a2346.seSite ) = "" Then b2346.seSite = ""  Else b2346.seSite=a2346.seSite
If trim$( a2346.cdSite ) = "" Then b2346.cdSite = ""  Else b2346.cdSite=a2346.cdSite
If trim$( a2346.seDepartment ) = "" Then b2346.seDepartment = ""  Else b2346.seDepartment=a2346.seDepartment
If trim$( a2346.cdDepartment ) = "" Then b2346.cdDepartment = ""  Else b2346.cdDepartment=a2346.cdDepartment
If trim$( a2346.seFactory ) = "" Then b2346.seFactory = ""  Else b2346.seFactory=a2346.seFactory
If trim$( a2346.cdFactory ) = "" Then b2346.cdFactory = ""  Else b2346.cdFactory=a2346.cdFactory
If trim$( a2346.seLineProd ) = "" Then b2346.seLineProd = ""  Else b2346.seLineProd=a2346.seLineProd
If trim$( a2346.cdLineProd ) = "" Then b2346.cdLineProd = ""  Else b2346.cdLineProd=a2346.cdLineProd
If trim$( a2346.seSubProcess ) = "" Then b2346.seSubProcess = ""  Else b2346.seSubProcess=a2346.seSubProcess
If trim$( a2346.cdSubProcess ) = "" Then b2346.cdSubProcess = ""  Else b2346.cdSubProcess=a2346.cdSubProcess
If trim$( a2346.seGroupComponent ) = "" Then b2346.seGroupComponent = ""  Else b2346.seGroupComponent=a2346.seGroupComponent
If trim$( a2346.cdGroupComponent ) = "" Then b2346.cdGroupComponent = ""  Else b2346.cdGroupComponent=a2346.cdGroupComponent
If trim$( a2346.CustomerSupplier ) = "" Then b2346.CustomerSupplier = ""  Else b2346.CustomerSupplier=a2346.CustomerSupplier
If trim$( a2346.Dseq ) = "" Then b2346.Dseq = ""  Else b2346.Dseq=a2346.Dseq
If trim$( a2346.Pseq ) = "" Then b2346.Pseq = ""  Else b2346.Pseq=a2346.Pseq
If trim$( a2346.AutokeyK3011 ) = "" Then b2346.AutokeyK3011 = ""  Else b2346.AutokeyK3011=a2346.AutokeyK3011
If trim$( a2346.CheckRelationType ) = "" Then b2346.CheckRelationType = ""  Else b2346.CheckRelationType=a2346.CheckRelationType
If trim$( a2346.ComponentName ) = "" Then b2346.ComponentName = ""  Else b2346.ComponentName=a2346.ComponentName
If trim$( a2346.MaterialCode ) = "" Then b2346.MaterialCode = ""  Else b2346.MaterialCode=a2346.MaterialCode
If trim$( a2346.Specification ) = "" Then b2346.Specification = ""  Else b2346.Specification=a2346.Specification
If trim$( a2346.Width ) = "" Then b2346.Width = ""  Else b2346.Width=a2346.Width
If trim$( a2346.Height ) = "" Then b2346.Height = ""  Else b2346.Height=a2346.Height
If trim$( a2346.SizeNo ) = "" Then b2346.SizeNo = ""  Else b2346.SizeNo=a2346.SizeNo
If trim$( a2346.SizeName ) = "" Then b2346.SizeName = ""  Else b2346.SizeName=a2346.SizeName
If trim$( a2346.ColorCode ) = "" Then b2346.ColorCode = ""  Else b2346.ColorCode=a2346.ColorCode
If trim$( a2346.ColorName ) = "" Then b2346.ColorName = ""  Else b2346.ColorName=a2346.ColorName
If trim$( a2346.seOrigin ) = "" Then b2346.seOrigin = ""  Else b2346.seOrigin=a2346.seOrigin
If trim$( a2346.cdOrigin ) = "" Then b2346.cdOrigin = ""  Else b2346.cdOrigin=a2346.cdOrigin
If trim$( a2346.MaterialCheck ) = "" Then b2346.MaterialCheck = ""  Else b2346.MaterialCheck=a2346.MaterialCheck
If trim$( a2346.seUnitPrice ) = "" Then b2346.seUnitPrice = ""  Else b2346.seUnitPrice=a2346.seUnitPrice
If trim$( a2346.cdUnitPrice ) = "" Then b2346.cdUnitPrice = ""  Else b2346.cdUnitPrice=a2346.cdUnitPrice
If trim$( a2346.seTax ) = "" Then b2346.seTax = ""  Else b2346.seTax=a2346.seTax
If trim$( a2346.cdTax ) = "" Then b2346.cdTax = ""  Else b2346.cdTax=a2346.cdTax
If trim$( a2346.seUnitMaterial ) = "" Then b2346.seUnitMaterial = ""  Else b2346.seUnitMaterial=a2346.seUnitMaterial
If trim$( a2346.cdUnitMaterial ) = "" Then b2346.cdUnitMaterial = ""  Else b2346.cdUnitMaterial=a2346.cdUnitMaterial
If trim$( a2346.seUnitPacking ) = "" Then b2346.seUnitPacking = ""  Else b2346.seUnitPacking=a2346.seUnitPacking
If trim$( a2346.cdUnitPacking ) = "" Then b2346.cdUnitPacking = ""  Else b2346.cdUnitPacking=a2346.cdUnitPacking
If trim$( a2346.UnitBaseCheck ) = "" Then b2346.UnitBaseCheck = ""  Else b2346.UnitBaseCheck=a2346.UnitBaseCheck
If trim$( a2346.QtyBasic ) = "" Then b2346.QtyBasic = ""  Else b2346.QtyBasic=a2346.QtyBasic
If trim$( a2346.PricePurchasing ) = "" Then b2346.PricePurchasing = ""  Else b2346.PricePurchasing=a2346.PricePurchasing
If trim$( a2346.PriceMarket ) = "" Then b2346.PriceMarket = ""  Else b2346.PriceMarket=a2346.PriceMarket
If trim$( a2346.PriceExchange ) = "" Then b2346.PriceExchange = ""  Else b2346.PriceExchange=a2346.PriceExchange
If trim$( a2346.PriceExchangeAP ) = "" Then b2346.PriceExchangeAP = ""  Else b2346.PriceExchangeAP=a2346.PriceExchangeAP
If trim$( a2346.DateExchange ) = "" Then b2346.DateExchange = ""  Else b2346.DateExchange=a2346.DateExchange
If trim$( a2346.PricePurchasingEX ) = "" Then b2346.PricePurchasingEX = ""  Else b2346.PricePurchasingEX=a2346.PricePurchasingEX
If trim$( a2346.PriceMarketEX ) = "" Then b2346.PriceMarketEX = ""  Else b2346.PriceMarketEX=a2346.PriceMarketEX
If trim$( a2346.PricePurchasingVND ) = "" Then b2346.PricePurchasingVND = ""  Else b2346.PricePurchasingVND=a2346.PricePurchasingVND
If trim$( a2346.PriceMarketVND ) = "" Then b2346.PriceMarketVND = ""  Else b2346.PriceMarketVND=a2346.PriceMarketVND
If trim$( a2346.AmountPurchasingEX ) = "" Then b2346.AmountPurchasingEX = ""  Else b2346.AmountPurchasingEX=a2346.AmountPurchasingEX
If trim$( a2346.AmountPurchasingVND ) = "" Then b2346.AmountPurchasingVND = ""  Else b2346.AmountPurchasingVND=a2346.AmountPurchasingVND
If trim$( a2346.AmountTaxEX ) = "" Then b2346.AmountTaxEX = ""  Else b2346.AmountTaxEX=a2346.AmountTaxEX
If trim$( a2346.AmountTaxVND ) = "" Then b2346.AmountTaxVND = ""  Else b2346.AmountTaxVND=a2346.AmountTaxVND
If trim$( a2346.seTax1 ) = "" Then b2346.seTax1 = ""  Else b2346.seTax1=a2346.seTax1
If trim$( a2346.cdTax1 ) = "" Then b2346.cdTax1 = ""  Else b2346.cdTax1=a2346.cdTax1
If trim$( a2346.PerTax1 ) = "" Then b2346.PerTax1 = ""  Else b2346.PerTax1=a2346.PerTax1
If trim$( a2346.AmountTax1 ) = "" Then b2346.AmountTax1 = ""  Else b2346.AmountTax1=a2346.AmountTax1
If trim$( a2346.seTax2 ) = "" Then b2346.seTax2 = ""  Else b2346.seTax2=a2346.seTax2
If trim$( a2346.cdTax2 ) = "" Then b2346.cdTax2 = ""  Else b2346.cdTax2=a2346.cdTax2
If trim$( a2346.PerTax2 ) = "" Then b2346.PerTax2 = ""  Else b2346.PerTax2=a2346.PerTax2
If trim$( a2346.AmountTax2 ) = "" Then b2346.AmountTax2 = ""  Else b2346.AmountTax2=a2346.AmountTax2
If trim$( a2346.seTax3 ) = "" Then b2346.seTax3 = ""  Else b2346.seTax3=a2346.seTax3
If trim$( a2346.cdTax3 ) = "" Then b2346.cdTax3 = ""  Else b2346.cdTax3=a2346.cdTax3
If trim$( a2346.PerTax3 ) = "" Then b2346.PerTax3 = ""  Else b2346.PerTax3=a2346.PerTax3
If trim$( a2346.AmountTax3 ) = "" Then b2346.AmountTax3 = ""  Else b2346.AmountTax3=a2346.AmountTax3
If trim$( a2346.QtyRequestPO ) = "" Then b2346.QtyRequestPO = ""  Else b2346.QtyRequestPO=a2346.QtyRequestPO
If trim$( a2346.QtyPurchasingNet ) = "" Then b2346.QtyPurchasingNet = ""  Else b2346.QtyPurchasingNet=a2346.QtyPurchasingNet
If trim$( a2346.QtyPurchasingMOQ ) = "" Then b2346.QtyPurchasingMOQ = ""  Else b2346.QtyPurchasingMOQ=a2346.QtyPurchasingMOQ
If trim$( a2346.QtyPurchasing ) = "" Then b2346.QtyPurchasing = ""  Else b2346.QtyPurchasing=a2346.QtyPurchasing
If trim$( a2346.PackPurchasing ) = "" Then b2346.PackPurchasing = ""  Else b2346.PackPurchasing=a2346.PackPurchasing
If trim$( a2346.QtyWarehouse ) = "" Then b2346.QtyWarehouse = ""  Else b2346.QtyWarehouse=a2346.QtyWarehouse
If trim$( a2346.PackWarehouse ) = "" Then b2346.PackWarehouse = ""  Else b2346.PackWarehouse=a2346.PackWarehouse
If trim$( a2346.QtyInbound ) = "" Then b2346.QtyInbound = ""  Else b2346.QtyInbound=a2346.QtyInbound
If trim$( a2346.PackInbound ) = "" Then b2346.PackInbound = ""  Else b2346.PackInbound=a2346.PackInbound
If trim$( a2346.QtyOutbound ) = "" Then b2346.QtyOutbound = ""  Else b2346.QtyOutbound=a2346.QtyOutbound
If trim$( a2346.PackOutbound ) = "" Then b2346.PackOutbound = ""  Else b2346.PackOutbound=a2346.PackOutbound
If trim$( a2346.AmountEX ) = "" Then b2346.AmountEX = ""  Else b2346.AmountEX=a2346.AmountEX
If trim$( a2346.AmountVND ) = "" Then b2346.AmountVND = ""  Else b2346.AmountVND=a2346.AmountVND
If trim$( a2346.AmountInBoundEX ) = "" Then b2346.AmountInBoundEX = ""  Else b2346.AmountInBoundEX=a2346.AmountInBoundEX
If trim$( a2346.AmountInBoundVND ) = "" Then b2346.AmountInBoundVND = ""  Else b2346.AmountInBoundVND=a2346.AmountInBoundVND
If trim$( a2346.DateDelivery ) = "" Then b2346.DateDelivery = ""  Else b2346.DateDelivery=a2346.DateDelivery
If trim$( a2346.DateStart ) = "" Then b2346.DateStart = ""  Else b2346.DateStart=a2346.DateStart
If trim$( a2346.DateFinish ) = "" Then b2346.DateFinish = ""  Else b2346.DateFinish=a2346.DateFinish
If trim$( a2346.CheckPurchasing ) = "" Then b2346.CheckPurchasing = ""  Else b2346.CheckPurchasing=a2346.CheckPurchasing
If trim$( a2346.DateAccept ) = "" Then b2346.DateAccept = ""  Else b2346.DateAccept=a2346.DateAccept
If trim$( a2346.DatePosted ) = "" Then b2346.DatePosted = ""  Else b2346.DatePosted=a2346.DatePosted
If trim$( a2346.IsPosted ) = "" Then b2346.IsPosted = ""  Else b2346.IsPosted=a2346.IsPosted
If trim$( a2346.DateComplete ) = "" Then b2346.DateComplete = ""  Else b2346.DateComplete=a2346.DateComplete
If trim$( a2346.DateApproval ) = "" Then b2346.DateApproval = ""  Else b2346.DateApproval=a2346.DateApproval
If trim$( a2346.DateCancel ) = "" Then b2346.DateCancel = ""  Else b2346.DateCancel=a2346.DateCancel
If trim$( a2346.CheckComplete ) = "" Then b2346.CheckComplete = ""  Else b2346.CheckComplete=a2346.CheckComplete
If trim$( a2346.PurchasingOrderNo ) = "" Then b2346.PurchasingOrderNo = ""  Else b2346.PurchasingOrderNo=a2346.PurchasingOrderNo
If trim$( a2346.PurchasingOrderSeq ) = "" Then b2346.PurchasingOrderSeq = ""  Else b2346.PurchasingOrderSeq=a2346.PurchasingOrderSeq
If trim$( a2346.JobCardWorking ) = "" Then b2346.JobCardWorking = ""  Else b2346.JobCardWorking=a2346.JobCardWorking
If trim$( a2346.JobCardWorkingSeq ) = "" Then b2346.JobCardWorkingSeq = ""  Else b2346.JobCardWorkingSeq=a2346.JobCardWorkingSeq
If trim$( a2346.JobCardType ) = "" Then b2346.JobCardType = ""  Else b2346.JobCardType=a2346.JobCardType
If trim$( a2346.SalesOrderNo ) = "" Then b2346.SalesOrderNo = ""  Else b2346.SalesOrderNo=a2346.SalesOrderNo
If trim$( a2346.SalesOrderSeq ) = "" Then b2346.SalesOrderSeq = ""  Else b2346.SalesOrderSeq=a2346.SalesOrderSeq
If trim$( a2346.SalesOrderSno ) = "" Then b2346.SalesOrderSno = ""  Else b2346.SalesOrderSno=a2346.SalesOrderSno
If trim$( a2346.CheckOrderType ) = "" Then b2346.CheckOrderType = ""  Else b2346.CheckOrderType=a2346.CheckOrderType
If trim$( a2346.OrderNo ) = "" Then b2346.OrderNo = ""  Else b2346.OrderNo=a2346.OrderNo
If trim$( a2346.OrderNoSeq ) = "" Then b2346.OrderNoSeq = ""  Else b2346.OrderNoSeq=a2346.OrderNoSeq
If trim$( a2346.JobCard ) = "" Then b2346.JobCard = ""  Else b2346.JobCard=a2346.JobCard
If trim$( a2346.DateSync ) = "" Then b2346.DateSync = ""  Else b2346.DateSync=a2346.DateSync
If trim$( a2346.CheckSync ) = "" Then b2346.CheckSync = ""  Else b2346.CheckSync=a2346.CheckSync
If trim$( a2346.SlNo ) = "" Then b2346.SlNo = ""  Else b2346.SlNo=a2346.SlNo
If trim$( a2346.Check_Spec_1 ) = "" Then b2346.Check_Spec_1 = ""  Else b2346.Check_Spec_1=a2346.Check_Spec_1
If trim$( a2346.Check_Spec_2 ) = "" Then b2346.Check_Spec_2 = ""  Else b2346.Check_Spec_2=a2346.Check_Spec_2
If trim$( a2346.Check_Spec_3 ) = "" Then b2346.Check_Spec_3 = ""  Else b2346.Check_Spec_3=a2346.Check_Spec_3
If trim$( a2346.Check_Spec_4 ) = "" Then b2346.Check_Spec_4 = ""  Else b2346.Check_Spec_4=a2346.Check_Spec_4
If trim$( a2346.Check_Spec_5 ) = "" Then b2346.Check_Spec_5 = ""  Else b2346.Check_Spec_5=a2346.Check_Spec_5
If trim$( a2346.Check_Spec_6 ) = "" Then b2346.Check_Spec_6 = ""  Else b2346.Check_Spec_6=a2346.Check_Spec_6
If trim$( a2346.Check_Spec_7 ) = "" Then b2346.Check_Spec_7 = ""  Else b2346.Check_Spec_7=a2346.Check_Spec_7
If trim$( a2346.Check_Spec_8 ) = "" Then b2346.Check_Spec_8 = ""  Else b2346.Check_Spec_8=a2346.Check_Spec_8
If trim$( a2346.Check_Spec_9 ) = "" Then b2346.Check_Spec_9 = ""  Else b2346.Check_Spec_9=a2346.Check_Spec_9
If trim$( a2346.Remark ) = "" Then b2346.Remark = ""  Else b2346.Remark=a2346.Remark
If trim$( a2346.TimeInsert ) = "" Then b2346.TimeInsert = ""  Else b2346.TimeInsert=a2346.TimeInsert
If trim$( a2346.TimeUpdate ) = "" Then b2346.TimeUpdate = ""  Else b2346.TimeUpdate=a2346.TimeUpdate
If trim$( a2346.DateInsert ) = "" Then b2346.DateInsert = ""  Else b2346.DateInsert=a2346.DateInsert
If trim$( a2346.DateUpdate ) = "" Then b2346.DateUpdate = ""  Else b2346.DateUpdate=a2346.DateUpdate
If trim$( a2346.InchargeInsert ) = "" Then b2346.InchargeInsert = ""  Else b2346.InchargeInsert=a2346.InchargeInsert
If trim$( a2346.InchargeUpdate ) = "" Then b2346.InchargeUpdate = ""  Else b2346.InchargeUpdate=a2346.InchargeUpdate
Catch ex As Exception
      Call MsgBoxP("K2346_MOVE",vbCritical)
End Try
End Sub 


End Module 
