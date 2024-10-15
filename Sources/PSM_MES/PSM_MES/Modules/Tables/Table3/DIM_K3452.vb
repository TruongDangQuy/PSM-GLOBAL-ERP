'=========================================================================================================================================================
'   TABLE : (PFK3452)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K3452

    Structure T3452_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public Autokey As Double  '			decimal		*
        Public TIVE30 As String  '			nvarchar(20)
        Public DTIV30 As String  '			nvarchar(50)
        Public DTEX30 As String  '			nvarchar(50)
        Public FactOrderNo As String  '			char(9)
        Public FactOrderSeq As Double  '			decimal
        Public PackingBatch As String  '			nvarchar(20)
        Public PKO As String  '			nvarchar(50)
        Public seSite As String  '			char(3)
        Public cdSite As String  '			char(3)
        Public seDepartment As String  '			char(3)
        Public cdDepartment As String  '			char(3)
        Public CustomerSupplier As String  '			char(6)
        Public Dseq As Double  '			decimal
        Public CheckRelationType As String  '			char(1)
        Public ShoesCode As String  '			char(6)
        Public Specification As String  '			nvarchar(50)
        Public Width As String  '			nvarchar(50)
        Public Height As String  '			nvarchar(50)
        Public SizeNo As String  '			char(2)
        Public SizeName As String  '			nvarchar(50)
        Public ColorName As String  '			nvarchar(50)
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
        Public DateExchange As String  '			char(8)
        Public PricePurchasingEX As Double  '			decimal
        Public PriceMarketEX As Double  '			decimal
        Public PricePurchasingVND As Double  '			decimal
        Public PriceMarketVND As Double  '			decimal
        Public AmountPurchasingEX As Double  '			decimal
        Public AmountPurchasingVND As Double  '			decimal
        Public AmountTaxEX As Double  '			decimal
        Public AmountTaxVND As Double  '			decimal
        Public QtyPurchasing As Double  '			decimal
        Public PackPurchasing As Double  '			decimal
        Public QtyWarehouse As Double  '			decimal
        Public PackWarehouse As Double  '			decimal
        Public QtyPacking As Double  '			decimal
        Public PackPacking As Double  '			decimal
        Public QtyInbound As Double  '			decimal
        Public PackInbound As Double  '			decimal
        Public QtyOutbound As Double  '			decimal
        Public PackOutbound As Double  '			decimal
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
        Public ShippingWorkOrder As String  '			char(9)
        Public ShippingWorkOrderSeq As String  '			char(3)
        Public OrderNo As String  '			char(9)
        Public OrderNoSeq As String  '			char(3)
        Public Remark As String  '			nvarchar(500)
        '=========================================================================================================================================================
    End Structure

    Public D3452 As T3452_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK3452(AUTOKEY As Double) As Boolean
        READ_PFK3452 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK3452 "
            SQL = SQL & " WHERE K3452_Autokey		 =  " & Autokey & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D3452_CLEAR() : GoTo SKIP_READ_PFK3452

            Call K3452_MOVE(rd)
            READ_PFK3452 = True

SKIP_READ_PFK3452:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK3452", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK3452(AUTOKEY As Double, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK3452 "
            SQL = SQL & " WHERE K3452_Autokey		 =  " & Autokey & "  "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK3452", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK3452(z3452 As T3452_AREA) As Boolean
        WRITE_PFK3452 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z3452)

            SQL = " INSERT INTO PFK3452 "
            SQL = SQL & " ( "
            SQL = SQL & " K3452_Autokey,"
            SQL = SQL & " K3452_TIVE30,"
            SQL = SQL & " K3452_DTIV30,"
            SQL = SQL & " K3452_DTEX30,"
            SQL = SQL & " K3452_FactOrderNo,"
            SQL = SQL & " K3452_FactOrderSeq,"
            SQL = SQL & " K3452_PackingBatch,"
            SQL = SQL & " K3452_PKO,"
            SQL = SQL & " K3452_seSite,"
            SQL = SQL & " K3452_cdSite,"
            SQL = SQL & " K3452_seDepartment,"
            SQL = SQL & " K3452_cdDepartment,"
            SQL = SQL & " K3452_CustomerSupplier,"
            SQL = SQL & " K3452_Dseq,"
            SQL = SQL & " K3452_CheckRelationType,"
            SQL = SQL & " K3452_ShoesCode,"
            SQL = SQL & " K3452_Specification,"
            SQL = SQL & " K3452_Width,"
            SQL = SQL & " K3452_Height,"
            SQL = SQL & " K3452_SizeNo,"
            SQL = SQL & " K3452_SizeName,"
            SQL = SQL & " K3452_ColorName,"
            SQL = SQL & " K3452_seOrigin,"
            SQL = SQL & " K3452_cdOrigin,"
            SQL = SQL & " K3452_MaterialCheck,"
            SQL = SQL & " K3452_seUnitPrice,"
            SQL = SQL & " K3452_cdUnitPrice,"
            SQL = SQL & " K3452_seTax,"
            SQL = SQL & " K3452_cdTax,"
            SQL = SQL & " K3452_seUnitMaterial,"
            SQL = SQL & " K3452_cdUnitMaterial,"
            SQL = SQL & " K3452_seUnitPacking,"
            SQL = SQL & " K3452_cdUnitPacking,"
            SQL = SQL & " K3452_UnitBaseCheck,"
            SQL = SQL & " K3452_QtyBasic,"
            SQL = SQL & " K3452_PricePurchasing,"
            SQL = SQL & " K3452_PriceMarket,"
            SQL = SQL & " K3452_PriceExchange,"
            SQL = SQL & " K3452_DateExchange,"
            SQL = SQL & " K3452_PricePurchasingEX,"
            SQL = SQL & " K3452_PriceMarketEX,"
            SQL = SQL & " K3452_PricePurchasingVND,"
            SQL = SQL & " K3452_PriceMarketVND,"
            SQL = SQL & " K3452_AmountPurchasingEX,"
            SQL = SQL & " K3452_AmountPurchasingVND,"
            SQL = SQL & " K3452_AmountTaxEX,"
            SQL = SQL & " K3452_AmountTaxVND,"
            SQL = SQL & " K3452_QtyPurchasing,"
            SQL = SQL & " K3452_PackPurchasing,"
            SQL = SQL & " K3452_QtyWarehouse,"
            SQL = SQL & " K3452_PackWarehouse,"
            SQL = SQL & " K3452_QtyPacking,"
            SQL = SQL & " K3452_PackPacking,"
            SQL = SQL & " K3452_QtyInbound,"
            SQL = SQL & " K3452_PackInbound,"
            SQL = SQL & " K3452_QtyOutbound,"
            SQL = SQL & " K3452_PackOutbound,"
            SQL = SQL & " K3452_AmountInBoundEX,"
            SQL = SQL & " K3452_AmountInBoundVND,"
            SQL = SQL & " K3452_DateDelivery,"
            SQL = SQL & " K3452_DateStart,"
            SQL = SQL & " K3452_DateFinish,"
            SQL = SQL & " K3452_CheckPurchasing,"
            SQL = SQL & " K3452_DateAccept,"
            SQL = SQL & " K3452_DatePosted,"
            SQL = SQL & " K3452_IsPosted,"
            SQL = SQL & " K3452_DateComplete,"
            SQL = SQL & " K3452_DateApproval,"
            SQL = SQL & " K3452_DateCancel,"
            SQL = SQL & " K3452_CheckComplete,"
            SQL = SQL & " K3452_ShippingWorkOrder,"
            SQL = SQL & " K3452_ShippingWorkOrderSeq,"
            SQL = SQL & " K3452_OrderNo,"
            SQL = SQL & " K3452_OrderNoSeq,"
            SQL = SQL & " K3452_Remark "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "   " & FormatSQL(z3452.Autokey) & ", "
            SQL = SQL & "  N'" & FormatSQL(z3452.TIVE30) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3452.DTIV30) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3452.DTEX30) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3452.FactOrderNo) & "', "
            SQL = SQL & "   " & FormatSQL(z3452.FactOrderSeq) & ", "
            SQL = SQL & "  N'" & FormatSQL(z3452.PackingBatch) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3452.PKO) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3452.seSite) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3452.cdSite) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3452.seDepartment) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3452.cdDepartment) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3452.CustomerSupplier) & "', "
            SQL = SQL & "   " & FormatSQL(z3452.Dseq) & ", "
            SQL = SQL & "  N'" & FormatSQL(z3452.CheckRelationType) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3452.ShoesCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3452.Specification) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3452.Width) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3452.Height) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3452.SizeNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3452.SizeName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3452.ColorName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3452.seOrigin) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3452.cdOrigin) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3452.MaterialCheck) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3452.seUnitPrice) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3452.cdUnitPrice) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3452.seTax) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3452.cdTax) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3452.seUnitMaterial) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3452.cdUnitMaterial) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3452.seUnitPacking) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3452.cdUnitPacking) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3452.UnitBaseCheck) & "', "
            SQL = SQL & "   " & FormatSQL(z3452.QtyBasic) & ", "
            SQL = SQL & "   " & FormatSQL(z3452.PricePurchasing) & ", "
            SQL = SQL & "   " & FormatSQL(z3452.PriceMarket) & ", "
            SQL = SQL & "   " & FormatSQL(z3452.PriceExchange) & ", "
            SQL = SQL & "  N'" & FormatSQL(z3452.DateExchange) & "', "
            SQL = SQL & "   " & FormatSQL(z3452.PricePurchasingEX) & ", "
            SQL = SQL & "   " & FormatSQL(z3452.PriceMarketEX) & ", "
            SQL = SQL & "   " & FormatSQL(z3452.PricePurchasingVND) & ", "
            SQL = SQL & "   " & FormatSQL(z3452.PriceMarketVND) & ", "
            SQL = SQL & "   " & FormatSQL(z3452.AmountPurchasingEX) & ", "
            SQL = SQL & "   " & FormatSQL(z3452.AmountPurchasingVND) & ", "
            SQL = SQL & "   " & FormatSQL(z3452.AmountTaxEX) & ", "
            SQL = SQL & "   " & FormatSQL(z3452.AmountTaxVND) & ", "
            SQL = SQL & "   " & FormatSQL(z3452.QtyPurchasing) & ", "
            SQL = SQL & "   " & FormatSQL(z3452.PackPurchasing) & ", "
            SQL = SQL & "   " & FormatSQL(z3452.QtyWarehouse) & ", "
            SQL = SQL & "   " & FormatSQL(z3452.PackWarehouse) & ", "
            SQL = SQL & "   " & FormatSQL(z3452.QtyPacking) & ", "
            SQL = SQL & "   " & FormatSQL(z3452.PackPacking) & ", "
            SQL = SQL & "   " & FormatSQL(z3452.QtyInbound) & ", "
            SQL = SQL & "   " & FormatSQL(z3452.PackInbound) & ", "
            SQL = SQL & "   " & FormatSQL(z3452.QtyOutbound) & ", "
            SQL = SQL & "   " & FormatSQL(z3452.PackOutbound) & ", "
            SQL = SQL & "   " & FormatSQL(z3452.AmountInBoundEX) & ", "
            SQL = SQL & "   " & FormatSQL(z3452.AmountInBoundVND) & ", "
            SQL = SQL & "  N'" & FormatSQL(z3452.DateDelivery) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3452.DateStart) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3452.DateFinish) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3452.CheckPurchasing) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3452.DateAccept) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3452.DatePosted) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3452.IsPosted) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3452.DateComplete) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3452.DateApproval) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3452.DateCancel) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3452.CheckComplete) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3452.ShippingWorkOrder) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3452.ShippingWorkOrderSeq) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3452.OrderNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3452.OrderNoSeq) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3452.Remark) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK3452 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK3452", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK3452(z3452 As T3452_AREA) As Boolean
        REWRITE_PFK3452 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z3452)

            SQL = " UPDATE PFK3452 SET "
            SQL = SQL & "    K3452_TIVE30      = N'" & FormatSQL(z3452.TIVE30) & "', "
            SQL = SQL & "    K3452_DTIV30      = N'" & FormatSQL(z3452.DTIV30) & "', "
            SQL = SQL & "    K3452_DTEX30      = N'" & FormatSQL(z3452.DTEX30) & "', "
            SQL = SQL & "    K3452_FactOrderNo      = N'" & FormatSQL(z3452.FactOrderNo) & "', "
            SQL = SQL & "    K3452_FactOrderSeq      =  " & FormatSQL(z3452.FactOrderSeq) & ", "
            SQL = SQL & "    K3452_PackingBatch      = N'" & FormatSQL(z3452.PackingBatch) & "', "
            SQL = SQL & "    K3452_PKO      = N'" & FormatSQL(z3452.PKO) & "', "
            SQL = SQL & "    K3452_seSite      = N'" & FormatSQL(z3452.seSite) & "', "
            SQL = SQL & "    K3452_cdSite      = N'" & FormatSQL(z3452.cdSite) & "', "
            SQL = SQL & "    K3452_seDepartment      = N'" & FormatSQL(z3452.seDepartment) & "', "
            SQL = SQL & "    K3452_cdDepartment      = N'" & FormatSQL(z3452.cdDepartment) & "', "
            SQL = SQL & "    K3452_CustomerSupplier      = N'" & FormatSQL(z3452.CustomerSupplier) & "', "
            SQL = SQL & "    K3452_Dseq      =  " & FormatSQL(z3452.Dseq) & ", "
            SQL = SQL & "    K3452_CheckRelationType      = N'" & FormatSQL(z3452.CheckRelationType) & "', "
            SQL = SQL & "    K3452_ShoesCode      = N'" & FormatSQL(z3452.ShoesCode) & "', "
            SQL = SQL & "    K3452_Specification      = N'" & FormatSQL(z3452.Specification) & "', "
            SQL = SQL & "    K3452_Width      = N'" & FormatSQL(z3452.Width) & "', "
            SQL = SQL & "    K3452_Height      = N'" & FormatSQL(z3452.Height) & "', "
            SQL = SQL & "    K3452_SizeNo      = N'" & FormatSQL(z3452.SizeNo) & "', "
            SQL = SQL & "    K3452_SizeName      = N'" & FormatSQL(z3452.SizeName) & "', "
            SQL = SQL & "    K3452_ColorName      = N'" & FormatSQL(z3452.ColorName) & "', "
            SQL = SQL & "    K3452_seOrigin      = N'" & FormatSQL(z3452.seOrigin) & "', "
            SQL = SQL & "    K3452_cdOrigin      = N'" & FormatSQL(z3452.cdOrigin) & "', "
            SQL = SQL & "    K3452_MaterialCheck      = N'" & FormatSQL(z3452.MaterialCheck) & "', "
            SQL = SQL & "    K3452_seUnitPrice      = N'" & FormatSQL(z3452.seUnitPrice) & "', "
            SQL = SQL & "    K3452_cdUnitPrice      = N'" & FormatSQL(z3452.cdUnitPrice) & "', "
            SQL = SQL & "    K3452_seTax      = N'" & FormatSQL(z3452.seTax) & "', "
            SQL = SQL & "    K3452_cdTax      = N'" & FormatSQL(z3452.cdTax) & "', "
            SQL = SQL & "    K3452_seUnitMaterial      = N'" & FormatSQL(z3452.seUnitMaterial) & "', "
            SQL = SQL & "    K3452_cdUnitMaterial      = N'" & FormatSQL(z3452.cdUnitMaterial) & "', "
            SQL = SQL & "    K3452_seUnitPacking      = N'" & FormatSQL(z3452.seUnitPacking) & "', "
            SQL = SQL & "    K3452_cdUnitPacking      = N'" & FormatSQL(z3452.cdUnitPacking) & "', "
            SQL = SQL & "    K3452_UnitBaseCheck      = N'" & FormatSQL(z3452.UnitBaseCheck) & "', "
            SQL = SQL & "    K3452_QtyBasic      =  " & FormatSQL(z3452.QtyBasic) & ", "
            SQL = SQL & "    K3452_PricePurchasing      =  " & FormatSQL(z3452.PricePurchasing) & ", "
            SQL = SQL & "    K3452_PriceMarket      =  " & FormatSQL(z3452.PriceMarket) & ", "
            SQL = SQL & "    K3452_PriceExchange      =  " & FormatSQL(z3452.PriceExchange) & ", "
            SQL = SQL & "    K3452_DateExchange      = N'" & FormatSQL(z3452.DateExchange) & "', "
            SQL = SQL & "    K3452_PricePurchasingEX      =  " & FormatSQL(z3452.PricePurchasingEX) & ", "
            SQL = SQL & "    K3452_PriceMarketEX      =  " & FormatSQL(z3452.PriceMarketEX) & ", "
            SQL = SQL & "    K3452_PricePurchasingVND      =  " & FormatSQL(z3452.PricePurchasingVND) & ", "
            SQL = SQL & "    K3452_PriceMarketVND      =  " & FormatSQL(z3452.PriceMarketVND) & ", "
            SQL = SQL & "    K3452_AmountPurchasingEX      =  " & FormatSQL(z3452.AmountPurchasingEX) & ", "
            SQL = SQL & "    K3452_AmountPurchasingVND      =  " & FormatSQL(z3452.AmountPurchasingVND) & ", "
            SQL = SQL & "    K3452_AmountTaxEX      =  " & FormatSQL(z3452.AmountTaxEX) & ", "
            SQL = SQL & "    K3452_AmountTaxVND      =  " & FormatSQL(z3452.AmountTaxVND) & ", "
            SQL = SQL & "    K3452_QtyPurchasing      =  " & FormatSQL(z3452.QtyPurchasing) & ", "
            SQL = SQL & "    K3452_PackPurchasing      =  " & FormatSQL(z3452.PackPurchasing) & ", "
            SQL = SQL & "    K3452_QtyWarehouse      =  " & FormatSQL(z3452.QtyWarehouse) & ", "
            SQL = SQL & "    K3452_PackWarehouse      =  " & FormatSQL(z3452.PackWarehouse) & ", "
            SQL = SQL & "    K3452_QtyPacking      =  " & FormatSQL(z3452.QtyPacking) & ", "
            SQL = SQL & "    K3452_PackPacking      =  " & FormatSQL(z3452.PackPacking) & ", "
            SQL = SQL & "    K3452_QtyInbound      =  " & FormatSQL(z3452.QtyInbound) & ", "
            SQL = SQL & "    K3452_PackInbound      =  " & FormatSQL(z3452.PackInbound) & ", "
            SQL = SQL & "    K3452_QtyOutbound      =  " & FormatSQL(z3452.QtyOutbound) & ", "
            SQL = SQL & "    K3452_PackOutbound      =  " & FormatSQL(z3452.PackOutbound) & ", "
            SQL = SQL & "    K3452_AmountInBoundEX      =  " & FormatSQL(z3452.AmountInBoundEX) & ", "
            SQL = SQL & "    K3452_AmountInBoundVND      =  " & FormatSQL(z3452.AmountInBoundVND) & ", "
            SQL = SQL & "    K3452_DateDelivery      = N'" & FormatSQL(z3452.DateDelivery) & "', "
            SQL = SQL & "    K3452_DateStart      = N'" & FormatSQL(z3452.DateStart) & "', "
            SQL = SQL & "    K3452_DateFinish      = N'" & FormatSQL(z3452.DateFinish) & "', "
            SQL = SQL & "    K3452_CheckPurchasing      = N'" & FormatSQL(z3452.CheckPurchasing) & "', "
            SQL = SQL & "    K3452_DateAccept      = N'" & FormatSQL(z3452.DateAccept) & "', "
            SQL = SQL & "    K3452_DatePosted      = N'" & FormatSQL(z3452.DatePosted) & "', "
            SQL = SQL & "    K3452_IsPosted      = N'" & FormatSQL(z3452.IsPosted) & "', "
            SQL = SQL & "    K3452_DateComplete      = N'" & FormatSQL(z3452.DateComplete) & "', "
            SQL = SQL & "    K3452_DateApproval      = N'" & FormatSQL(z3452.DateApproval) & "', "
            SQL = SQL & "    K3452_DateCancel      = N'" & FormatSQL(z3452.DateCancel) & "', "
            SQL = SQL & "    K3452_CheckComplete      = N'" & FormatSQL(z3452.CheckComplete) & "', "
            SQL = SQL & "    K3452_ShippingWorkOrder      = N'" & FormatSQL(z3452.ShippingWorkOrder) & "', "
            SQL = SQL & "    K3452_ShippingWorkOrderSeq      = N'" & FormatSQL(z3452.ShippingWorkOrderSeq) & "', "
            SQL = SQL & "    K3452_OrderNo      = N'" & FormatSQL(z3452.OrderNo) & "', "
            SQL = SQL & "    K3452_OrderNoSeq      = N'" & FormatSQL(z3452.OrderNoSeq) & "', "
            SQL = SQL & "    K3452_Remark      = N'" & FormatSQL(z3452.Remark) & "'  "
            SQL = SQL & " WHERE K3452_Autokey		 =  " & z3452.Autokey & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK3452 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK3452", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK3452(z3452 As T3452_AREA) As Boolean
        DELETE_PFK3452 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK3452 "
            SQL = SQL & " WHERE K3452_Autokey		 =  " & z3452.Autokey & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK3452 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK3452", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D3452_CLEAR()
        Try

            D3452.Autokey = 0
            D3452.TIVE30 = ""
            D3452.DTIV30 = ""
            D3452.DTEX30 = ""
            D3452.FactOrderNo = ""
            D3452.FactOrderSeq = 0
            D3452.PackingBatch = ""
            D3452.PKO = ""
            D3452.seSite = ""
            D3452.cdSite = ""
            D3452.seDepartment = ""
            D3452.cdDepartment = ""
            D3452.CustomerSupplier = ""
            D3452.Dseq = 0
            D3452.CheckRelationType = ""
            D3452.ShoesCode = ""
            D3452.Specification = ""
            D3452.Width = ""
            D3452.Height = ""
            D3452.SizeNo = ""
            D3452.SizeName = ""
            D3452.ColorName = ""
            D3452.seOrigin = ""
            D3452.cdOrigin = ""
            D3452.MaterialCheck = ""
            D3452.seUnitPrice = ""
            D3452.cdUnitPrice = ""
            D3452.seTax = ""
            D3452.cdTax = ""
            D3452.seUnitMaterial = ""
            D3452.cdUnitMaterial = ""
            D3452.seUnitPacking = ""
            D3452.cdUnitPacking = ""
            D3452.UnitBaseCheck = ""
            D3452.QtyBasic = 0
            D3452.PricePurchasing = 0
            D3452.PriceMarket = 0
            D3452.PriceExchange = 0
            D3452.DateExchange = ""
            D3452.PricePurchasingEX = 0
            D3452.PriceMarketEX = 0
            D3452.PricePurchasingVND = 0
            D3452.PriceMarketVND = 0
            D3452.AmountPurchasingEX = 0
            D3452.AmountPurchasingVND = 0
            D3452.AmountTaxEX = 0
            D3452.AmountTaxVND = 0
            D3452.QtyPurchasing = 0
            D3452.PackPurchasing = 0
            D3452.QtyWarehouse = 0
            D3452.PackWarehouse = 0
            D3452.QtyPacking = 0
            D3452.PackPacking = 0
            D3452.QtyInbound = 0
            D3452.PackInbound = 0
            D3452.QtyOutbound = 0
            D3452.PackOutbound = 0
            D3452.AmountInBoundEX = 0
            D3452.AmountInBoundVND = 0
            D3452.DateDelivery = ""
            D3452.DateStart = ""
            D3452.DateFinish = ""
            D3452.CheckPurchasing = ""
            D3452.DateAccept = ""
            D3452.DatePosted = ""
            D3452.IsPosted = ""
            D3452.DateComplete = ""
            D3452.DateApproval = ""
            D3452.DateCancel = ""
            D3452.CheckComplete = ""
            D3452.ShippingWorkOrder = ""
            D3452.ShippingWorkOrderSeq = ""
            D3452.OrderNo = ""
            D3452.OrderNoSeq = ""
            D3452.Remark = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D3452_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x3452 As T3452_AREA)
        Try

            x3452.Autokey = trim$(x3452.Autokey)
            x3452.TIVE30 = trim$(x3452.TIVE30)
            x3452.DTIV30 = trim$(x3452.DTIV30)
            x3452.DTEX30 = trim$(x3452.DTEX30)
            x3452.FactOrderNo = trim$(x3452.FactOrderNo)
            x3452.FactOrderSeq = trim$(x3452.FactOrderSeq)
            x3452.PackingBatch = trim$(x3452.PackingBatch)
            x3452.PKO = trim$(x3452.PKO)
            x3452.seSite = trim$(x3452.seSite)
            x3452.cdSite = trim$(x3452.cdSite)
            x3452.seDepartment = trim$(x3452.seDepartment)
            x3452.cdDepartment = trim$(x3452.cdDepartment)
            x3452.CustomerSupplier = trim$(x3452.CustomerSupplier)
            x3452.Dseq = trim$(x3452.Dseq)
            x3452.CheckRelationType = trim$(x3452.CheckRelationType)
            x3452.ShoesCode = trim$(x3452.ShoesCode)
            x3452.Specification = trim$(x3452.Specification)
            x3452.Width = trim$(x3452.Width)
            x3452.Height = trim$(x3452.Height)
            x3452.SizeNo = trim$(x3452.SizeNo)
            x3452.SizeName = trim$(x3452.SizeName)
            x3452.ColorName = trim$(x3452.ColorName)
            x3452.seOrigin = trim$(x3452.seOrigin)
            x3452.cdOrigin = trim$(x3452.cdOrigin)
            x3452.MaterialCheck = trim$(x3452.MaterialCheck)
            x3452.seUnitPrice = trim$(x3452.seUnitPrice)
            x3452.cdUnitPrice = trim$(x3452.cdUnitPrice)
            x3452.seTax = trim$(x3452.seTax)
            x3452.cdTax = trim$(x3452.cdTax)
            x3452.seUnitMaterial = trim$(x3452.seUnitMaterial)
            x3452.cdUnitMaterial = trim$(x3452.cdUnitMaterial)
            x3452.seUnitPacking = trim$(x3452.seUnitPacking)
            x3452.cdUnitPacking = trim$(x3452.cdUnitPacking)
            x3452.UnitBaseCheck = trim$(x3452.UnitBaseCheck)
            x3452.QtyBasic = trim$(x3452.QtyBasic)
            x3452.PricePurchasing = trim$(x3452.PricePurchasing)
            x3452.PriceMarket = trim$(x3452.PriceMarket)
            x3452.PriceExchange = trim$(x3452.PriceExchange)
            x3452.DateExchange = trim$(x3452.DateExchange)
            x3452.PricePurchasingEX = trim$(x3452.PricePurchasingEX)
            x3452.PriceMarketEX = trim$(x3452.PriceMarketEX)
            x3452.PricePurchasingVND = trim$(x3452.PricePurchasingVND)
            x3452.PriceMarketVND = trim$(x3452.PriceMarketVND)
            x3452.AmountPurchasingEX = trim$(x3452.AmountPurchasingEX)
            x3452.AmountPurchasingVND = trim$(x3452.AmountPurchasingVND)
            x3452.AmountTaxEX = trim$(x3452.AmountTaxEX)
            x3452.AmountTaxVND = trim$(x3452.AmountTaxVND)
            x3452.QtyPurchasing = trim$(x3452.QtyPurchasing)
            x3452.PackPurchasing = trim$(x3452.PackPurchasing)
            x3452.QtyWarehouse = trim$(x3452.QtyWarehouse)
            x3452.PackWarehouse = trim$(x3452.PackWarehouse)
            x3452.QtyPacking = trim$(x3452.QtyPacking)
            x3452.PackPacking = trim$(x3452.PackPacking)
            x3452.QtyInbound = trim$(x3452.QtyInbound)
            x3452.PackInbound = trim$(x3452.PackInbound)
            x3452.QtyOutbound = trim$(x3452.QtyOutbound)
            x3452.PackOutbound = trim$(x3452.PackOutbound)
            x3452.AmountInBoundEX = trim$(x3452.AmountInBoundEX)
            x3452.AmountInBoundVND = trim$(x3452.AmountInBoundVND)
            x3452.DateDelivery = trim$(x3452.DateDelivery)
            x3452.DateStart = trim$(x3452.DateStart)
            x3452.DateFinish = trim$(x3452.DateFinish)
            x3452.CheckPurchasing = trim$(x3452.CheckPurchasing)
            x3452.DateAccept = trim$(x3452.DateAccept)
            x3452.DatePosted = trim$(x3452.DatePosted)
            x3452.IsPosted = trim$(x3452.IsPosted)
            x3452.DateComplete = trim$(x3452.DateComplete)
            x3452.DateApproval = trim$(x3452.DateApproval)
            x3452.DateCancel = trim$(x3452.DateCancel)
            x3452.CheckComplete = trim$(x3452.CheckComplete)
            x3452.ShippingWorkOrder = trim$(x3452.ShippingWorkOrder)
            x3452.ShippingWorkOrderSeq = trim$(x3452.ShippingWorkOrderSeq)
            x3452.OrderNo = trim$(x3452.OrderNo)
            x3452.OrderNoSeq = trim$(x3452.OrderNoSeq)
            x3452.Remark = trim$(x3452.Remark)

            If trim$(x3452.Autokey) = "" Then x3452.Autokey = 0
            If trim$(x3452.TIVE30) = "" Then x3452.TIVE30 = Space(1)
            If trim$(x3452.DTIV30) = "" Then x3452.DTIV30 = Space(1)
            If trim$(x3452.DTEX30) = "" Then x3452.DTEX30 = Space(1)
            If trim$(x3452.FactOrderNo) = "" Then x3452.FactOrderNo = Space(1)
            If trim$(x3452.FactOrderSeq) = "" Then x3452.FactOrderSeq = 0
            If trim$(x3452.PackingBatch) = "" Then x3452.PackingBatch = Space(1)
            If trim$(x3452.PKO) = "" Then x3452.PKO = Space(1)
            If trim$(x3452.seSite) = "" Then x3452.seSite = Space(1)
            If trim$(x3452.cdSite) = "" Then x3452.cdSite = Space(1)
            If trim$(x3452.seDepartment) = "" Then x3452.seDepartment = Space(1)
            If trim$(x3452.cdDepartment) = "" Then x3452.cdDepartment = Space(1)
            If trim$(x3452.CustomerSupplier) = "" Then x3452.CustomerSupplier = Space(1)
            If trim$(x3452.Dseq) = "" Then x3452.Dseq = 0
            If trim$(x3452.CheckRelationType) = "" Then x3452.CheckRelationType = Space(1)
            If trim$(x3452.ShoesCode) = "" Then x3452.ShoesCode = Space(1)
            If trim$(x3452.Specification) = "" Then x3452.Specification = Space(1)
            If trim$(x3452.Width) = "" Then x3452.Width = Space(1)
            If trim$(x3452.Height) = "" Then x3452.Height = Space(1)
            If trim$(x3452.SizeNo) = "" Then x3452.SizeNo = Space(1)
            If trim$(x3452.SizeName) = "" Then x3452.SizeName = Space(1)
            If trim$(x3452.ColorName) = "" Then x3452.ColorName = Space(1)
            If trim$(x3452.seOrigin) = "" Then x3452.seOrigin = Space(1)
            If trim$(x3452.cdOrigin) = "" Then x3452.cdOrigin = Space(1)
            If trim$(x3452.MaterialCheck) = "" Then x3452.MaterialCheck = Space(1)
            If trim$(x3452.seUnitPrice) = "" Then x3452.seUnitPrice = Space(1)
            If trim$(x3452.cdUnitPrice) = "" Then x3452.cdUnitPrice = Space(1)
            If trim$(x3452.seTax) = "" Then x3452.seTax = Space(1)
            If trim$(x3452.cdTax) = "" Then x3452.cdTax = Space(1)
            If trim$(x3452.seUnitMaterial) = "" Then x3452.seUnitMaterial = Space(1)
            If trim$(x3452.cdUnitMaterial) = "" Then x3452.cdUnitMaterial = Space(1)
            If trim$(x3452.seUnitPacking) = "" Then x3452.seUnitPacking = Space(1)
            If trim$(x3452.cdUnitPacking) = "" Then x3452.cdUnitPacking = Space(1)
            If trim$(x3452.UnitBaseCheck) = "" Then x3452.UnitBaseCheck = Space(1)
            If trim$(x3452.QtyBasic) = "" Then x3452.QtyBasic = 0
            If trim$(x3452.PricePurchasing) = "" Then x3452.PricePurchasing = 0
            If trim$(x3452.PriceMarket) = "" Then x3452.PriceMarket = 0
            If trim$(x3452.PriceExchange) = "" Then x3452.PriceExchange = 0
            If trim$(x3452.DateExchange) = "" Then x3452.DateExchange = Space(1)
            If trim$(x3452.PricePurchasingEX) = "" Then x3452.PricePurchasingEX = 0
            If trim$(x3452.PriceMarketEX) = "" Then x3452.PriceMarketEX = 0
            If trim$(x3452.PricePurchasingVND) = "" Then x3452.PricePurchasingVND = 0
            If trim$(x3452.PriceMarketVND) = "" Then x3452.PriceMarketVND = 0
            If trim$(x3452.AmountPurchasingEX) = "" Then x3452.AmountPurchasingEX = 0
            If trim$(x3452.AmountPurchasingVND) = "" Then x3452.AmountPurchasingVND = 0
            If trim$(x3452.AmountTaxEX) = "" Then x3452.AmountTaxEX = 0
            If trim$(x3452.AmountTaxVND) = "" Then x3452.AmountTaxVND = 0
            If trim$(x3452.QtyPurchasing) = "" Then x3452.QtyPurchasing = 0
            If trim$(x3452.PackPurchasing) = "" Then x3452.PackPurchasing = 0
            If trim$(x3452.QtyWarehouse) = "" Then x3452.QtyWarehouse = 0
            If trim$(x3452.PackWarehouse) = "" Then x3452.PackWarehouse = 0
            If trim$(x3452.QtyPacking) = "" Then x3452.QtyPacking = 0
            If trim$(x3452.PackPacking) = "" Then x3452.PackPacking = 0
            If trim$(x3452.QtyInbound) = "" Then x3452.QtyInbound = 0
            If trim$(x3452.PackInbound) = "" Then x3452.PackInbound = 0
            If trim$(x3452.QtyOutbound) = "" Then x3452.QtyOutbound = 0
            If trim$(x3452.PackOutbound) = "" Then x3452.PackOutbound = 0
            If trim$(x3452.AmountInBoundEX) = "" Then x3452.AmountInBoundEX = 0
            If trim$(x3452.AmountInBoundVND) = "" Then x3452.AmountInBoundVND = 0
            If trim$(x3452.DateDelivery) = "" Then x3452.DateDelivery = Space(1)
            If trim$(x3452.DateStart) = "" Then x3452.DateStart = Space(1)
            If trim$(x3452.DateFinish) = "" Then x3452.DateFinish = Space(1)
            If trim$(x3452.CheckPurchasing) = "" Then x3452.CheckPurchasing = Space(1)
            If trim$(x3452.DateAccept) = "" Then x3452.DateAccept = Space(1)
            If trim$(x3452.DatePosted) = "" Then x3452.DatePosted = Space(1)
            If trim$(x3452.IsPosted) = "" Then x3452.IsPosted = Space(1)
            If trim$(x3452.DateComplete) = "" Then x3452.DateComplete = Space(1)
            If trim$(x3452.DateApproval) = "" Then x3452.DateApproval = Space(1)
            If trim$(x3452.DateCancel) = "" Then x3452.DateCancel = Space(1)
            If trim$(x3452.CheckComplete) = "" Then x3452.CheckComplete = Space(1)
            If trim$(x3452.ShippingWorkOrder) = "" Then x3452.ShippingWorkOrder = Space(1)
            If trim$(x3452.ShippingWorkOrderSeq) = "" Then x3452.ShippingWorkOrderSeq = Space(1)
            If trim$(x3452.OrderNo) = "" Then x3452.OrderNo = Space(1)
            If trim$(x3452.OrderNoSeq) = "" Then x3452.OrderNoSeq = Space(1)
            If trim$(x3452.Remark) = "" Then x3452.Remark = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K3452_MOVE(rs3452 As SqlClient.SqlDataReader)
        Try

            Call D3452_CLEAR()

            If IsdbNull(rs3452!K3452_Autokey) = False Then D3452.Autokey = Trim$(rs3452!K3452_Autokey)
            If IsdbNull(rs3452!K3452_TIVE30) = False Then D3452.TIVE30 = Trim$(rs3452!K3452_TIVE30)
            If IsdbNull(rs3452!K3452_DTIV30) = False Then D3452.DTIV30 = Trim$(rs3452!K3452_DTIV30)
            If IsdbNull(rs3452!K3452_DTEX30) = False Then D3452.DTEX30 = Trim$(rs3452!K3452_DTEX30)
            If IsdbNull(rs3452!K3452_FactOrderNo) = False Then D3452.FactOrderNo = Trim$(rs3452!K3452_FactOrderNo)
            If IsdbNull(rs3452!K3452_FactOrderSeq) = False Then D3452.FactOrderSeq = Trim$(rs3452!K3452_FactOrderSeq)
            If IsdbNull(rs3452!K3452_PackingBatch) = False Then D3452.PackingBatch = Trim$(rs3452!K3452_PackingBatch)
            If IsdbNull(rs3452!K3452_PKO) = False Then D3452.PKO = Trim$(rs3452!K3452_PKO)
            If IsdbNull(rs3452!K3452_seSite) = False Then D3452.seSite = Trim$(rs3452!K3452_seSite)
            If IsdbNull(rs3452!K3452_cdSite) = False Then D3452.cdSite = Trim$(rs3452!K3452_cdSite)
            If IsdbNull(rs3452!K3452_seDepartment) = False Then D3452.seDepartment = Trim$(rs3452!K3452_seDepartment)
            If IsdbNull(rs3452!K3452_cdDepartment) = False Then D3452.cdDepartment = Trim$(rs3452!K3452_cdDepartment)
            If IsdbNull(rs3452!K3452_CustomerSupplier) = False Then D3452.CustomerSupplier = Trim$(rs3452!K3452_CustomerSupplier)
            If IsdbNull(rs3452!K3452_Dseq) = False Then D3452.Dseq = Trim$(rs3452!K3452_Dseq)
            If IsdbNull(rs3452!K3452_CheckRelationType) = False Then D3452.CheckRelationType = Trim$(rs3452!K3452_CheckRelationType)
            If IsdbNull(rs3452!K3452_ShoesCode) = False Then D3452.ShoesCode = Trim$(rs3452!K3452_ShoesCode)
            If IsdbNull(rs3452!K3452_Specification) = False Then D3452.Specification = Trim$(rs3452!K3452_Specification)
            If IsdbNull(rs3452!K3452_Width) = False Then D3452.Width = Trim$(rs3452!K3452_Width)
            If IsdbNull(rs3452!K3452_Height) = False Then D3452.Height = Trim$(rs3452!K3452_Height)
            If IsdbNull(rs3452!K3452_SizeNo) = False Then D3452.SizeNo = Trim$(rs3452!K3452_SizeNo)
            If IsdbNull(rs3452!K3452_SizeName) = False Then D3452.SizeName = Trim$(rs3452!K3452_SizeName)
            If IsdbNull(rs3452!K3452_ColorName) = False Then D3452.ColorName = Trim$(rs3452!K3452_ColorName)
            If IsdbNull(rs3452!K3452_seOrigin) = False Then D3452.seOrigin = Trim$(rs3452!K3452_seOrigin)
            If IsdbNull(rs3452!K3452_cdOrigin) = False Then D3452.cdOrigin = Trim$(rs3452!K3452_cdOrigin)
            If IsdbNull(rs3452!K3452_MaterialCheck) = False Then D3452.MaterialCheck = Trim$(rs3452!K3452_MaterialCheck)
            If IsdbNull(rs3452!K3452_seUnitPrice) = False Then D3452.seUnitPrice = Trim$(rs3452!K3452_seUnitPrice)
            If IsdbNull(rs3452!K3452_cdUnitPrice) = False Then D3452.cdUnitPrice = Trim$(rs3452!K3452_cdUnitPrice)
            If IsdbNull(rs3452!K3452_seTax) = False Then D3452.seTax = Trim$(rs3452!K3452_seTax)
            If IsdbNull(rs3452!K3452_cdTax) = False Then D3452.cdTax = Trim$(rs3452!K3452_cdTax)
            If IsdbNull(rs3452!K3452_seUnitMaterial) = False Then D3452.seUnitMaterial = Trim$(rs3452!K3452_seUnitMaterial)
            If IsdbNull(rs3452!K3452_cdUnitMaterial) = False Then D3452.cdUnitMaterial = Trim$(rs3452!K3452_cdUnitMaterial)
            If IsdbNull(rs3452!K3452_seUnitPacking) = False Then D3452.seUnitPacking = Trim$(rs3452!K3452_seUnitPacking)
            If IsdbNull(rs3452!K3452_cdUnitPacking) = False Then D3452.cdUnitPacking = Trim$(rs3452!K3452_cdUnitPacking)
            If IsdbNull(rs3452!K3452_UnitBaseCheck) = False Then D3452.UnitBaseCheck = Trim$(rs3452!K3452_UnitBaseCheck)
            If IsdbNull(rs3452!K3452_QtyBasic) = False Then D3452.QtyBasic = Trim$(rs3452!K3452_QtyBasic)
            If IsdbNull(rs3452!K3452_PricePurchasing) = False Then D3452.PricePurchasing = Trim$(rs3452!K3452_PricePurchasing)
            If IsdbNull(rs3452!K3452_PriceMarket) = False Then D3452.PriceMarket = Trim$(rs3452!K3452_PriceMarket)
            If IsdbNull(rs3452!K3452_PriceExchange) = False Then D3452.PriceExchange = Trim$(rs3452!K3452_PriceExchange)
            If IsdbNull(rs3452!K3452_DateExchange) = False Then D3452.DateExchange = Trim$(rs3452!K3452_DateExchange)
            If IsdbNull(rs3452!K3452_PricePurchasingEX) = False Then D3452.PricePurchasingEX = Trim$(rs3452!K3452_PricePurchasingEX)
            If IsdbNull(rs3452!K3452_PriceMarketEX) = False Then D3452.PriceMarketEX = Trim$(rs3452!K3452_PriceMarketEX)
            If IsdbNull(rs3452!K3452_PricePurchasingVND) = False Then D3452.PricePurchasingVND = Trim$(rs3452!K3452_PricePurchasingVND)
            If IsdbNull(rs3452!K3452_PriceMarketVND) = False Then D3452.PriceMarketVND = Trim$(rs3452!K3452_PriceMarketVND)
            If IsdbNull(rs3452!K3452_AmountPurchasingEX) = False Then D3452.AmountPurchasingEX = Trim$(rs3452!K3452_AmountPurchasingEX)
            If IsdbNull(rs3452!K3452_AmountPurchasingVND) = False Then D3452.AmountPurchasingVND = Trim$(rs3452!K3452_AmountPurchasingVND)
            If IsdbNull(rs3452!K3452_AmountTaxEX) = False Then D3452.AmountTaxEX = Trim$(rs3452!K3452_AmountTaxEX)
            If IsdbNull(rs3452!K3452_AmountTaxVND) = False Then D3452.AmountTaxVND = Trim$(rs3452!K3452_AmountTaxVND)
            If IsdbNull(rs3452!K3452_QtyPurchasing) = False Then D3452.QtyPurchasing = Trim$(rs3452!K3452_QtyPurchasing)
            If IsdbNull(rs3452!K3452_PackPurchasing) = False Then D3452.PackPurchasing = Trim$(rs3452!K3452_PackPurchasing)
            If IsdbNull(rs3452!K3452_QtyWarehouse) = False Then D3452.QtyWarehouse = Trim$(rs3452!K3452_QtyWarehouse)
            If IsdbNull(rs3452!K3452_PackWarehouse) = False Then D3452.PackWarehouse = Trim$(rs3452!K3452_PackWarehouse)
            If IsdbNull(rs3452!K3452_QtyPacking) = False Then D3452.QtyPacking = Trim$(rs3452!K3452_QtyPacking)
            If IsdbNull(rs3452!K3452_PackPacking) = False Then D3452.PackPacking = Trim$(rs3452!K3452_PackPacking)
            If IsdbNull(rs3452!K3452_QtyInbound) = False Then D3452.QtyInbound = Trim$(rs3452!K3452_QtyInbound)
            If IsdbNull(rs3452!K3452_PackInbound) = False Then D3452.PackInbound = Trim$(rs3452!K3452_PackInbound)
            If IsdbNull(rs3452!K3452_QtyOutbound) = False Then D3452.QtyOutbound = Trim$(rs3452!K3452_QtyOutbound)
            If IsdbNull(rs3452!K3452_PackOutbound) = False Then D3452.PackOutbound = Trim$(rs3452!K3452_PackOutbound)
            If IsdbNull(rs3452!K3452_AmountInBoundEX) = False Then D3452.AmountInBoundEX = Trim$(rs3452!K3452_AmountInBoundEX)
            If IsdbNull(rs3452!K3452_AmountInBoundVND) = False Then D3452.AmountInBoundVND = Trim$(rs3452!K3452_AmountInBoundVND)
            If IsdbNull(rs3452!K3452_DateDelivery) = False Then D3452.DateDelivery = Trim$(rs3452!K3452_DateDelivery)
            If IsdbNull(rs3452!K3452_DateStart) = False Then D3452.DateStart = Trim$(rs3452!K3452_DateStart)
            If IsdbNull(rs3452!K3452_DateFinish) = False Then D3452.DateFinish = Trim$(rs3452!K3452_DateFinish)
            If IsdbNull(rs3452!K3452_CheckPurchasing) = False Then D3452.CheckPurchasing = Trim$(rs3452!K3452_CheckPurchasing)
            If IsdbNull(rs3452!K3452_DateAccept) = False Then D3452.DateAccept = Trim$(rs3452!K3452_DateAccept)
            If IsdbNull(rs3452!K3452_DatePosted) = False Then D3452.DatePosted = Trim$(rs3452!K3452_DatePosted)
            If IsdbNull(rs3452!K3452_IsPosted) = False Then D3452.IsPosted = Trim$(rs3452!K3452_IsPosted)
            If IsdbNull(rs3452!K3452_DateComplete) = False Then D3452.DateComplete = Trim$(rs3452!K3452_DateComplete)
            If IsdbNull(rs3452!K3452_DateApproval) = False Then D3452.DateApproval = Trim$(rs3452!K3452_DateApproval)
            If IsdbNull(rs3452!K3452_DateCancel) = False Then D3452.DateCancel = Trim$(rs3452!K3452_DateCancel)
            If IsdbNull(rs3452!K3452_CheckComplete) = False Then D3452.CheckComplete = Trim$(rs3452!K3452_CheckComplete)
            If IsdbNull(rs3452!K3452_ShippingWorkOrder) = False Then D3452.ShippingWorkOrder = Trim$(rs3452!K3452_ShippingWorkOrder)
            If IsdbNull(rs3452!K3452_ShippingWorkOrderSeq) = False Then D3452.ShippingWorkOrderSeq = Trim$(rs3452!K3452_ShippingWorkOrderSeq)
            If IsdbNull(rs3452!K3452_OrderNo) = False Then D3452.OrderNo = Trim$(rs3452!K3452_OrderNo)
            If IsdbNull(rs3452!K3452_OrderNoSeq) = False Then D3452.OrderNoSeq = Trim$(rs3452!K3452_OrderNoSeq)
            If IsdbNull(rs3452!K3452_Remark) = False Then D3452.Remark = Trim$(rs3452!K3452_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K3452_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K3452_MOVE(rs3452 As DataRow)
        Try

            Call D3452_CLEAR()

            If IsdbNull(rs3452!K3452_Autokey) = False Then D3452.Autokey = Trim$(rs3452!K3452_Autokey)
            If IsdbNull(rs3452!K3452_TIVE30) = False Then D3452.TIVE30 = Trim$(rs3452!K3452_TIVE30)
            If IsdbNull(rs3452!K3452_DTIV30) = False Then D3452.DTIV30 = Trim$(rs3452!K3452_DTIV30)
            If IsdbNull(rs3452!K3452_DTEX30) = False Then D3452.DTEX30 = Trim$(rs3452!K3452_DTEX30)
            If IsdbNull(rs3452!K3452_FactOrderNo) = False Then D3452.FactOrderNo = Trim$(rs3452!K3452_FactOrderNo)
            If IsdbNull(rs3452!K3452_FactOrderSeq) = False Then D3452.FactOrderSeq = Trim$(rs3452!K3452_FactOrderSeq)
            If IsdbNull(rs3452!K3452_PackingBatch) = False Then D3452.PackingBatch = Trim$(rs3452!K3452_PackingBatch)
            If IsdbNull(rs3452!K3452_PKO) = False Then D3452.PKO = Trim$(rs3452!K3452_PKO)
            If IsdbNull(rs3452!K3452_seSite) = False Then D3452.seSite = Trim$(rs3452!K3452_seSite)
            If IsdbNull(rs3452!K3452_cdSite) = False Then D3452.cdSite = Trim$(rs3452!K3452_cdSite)
            If IsdbNull(rs3452!K3452_seDepartment) = False Then D3452.seDepartment = Trim$(rs3452!K3452_seDepartment)
            If IsdbNull(rs3452!K3452_cdDepartment) = False Then D3452.cdDepartment = Trim$(rs3452!K3452_cdDepartment)
            If IsdbNull(rs3452!K3452_CustomerSupplier) = False Then D3452.CustomerSupplier = Trim$(rs3452!K3452_CustomerSupplier)
            If IsdbNull(rs3452!K3452_Dseq) = False Then D3452.Dseq = Trim$(rs3452!K3452_Dseq)
            If IsdbNull(rs3452!K3452_CheckRelationType) = False Then D3452.CheckRelationType = Trim$(rs3452!K3452_CheckRelationType)
            If IsdbNull(rs3452!K3452_ShoesCode) = False Then D3452.ShoesCode = Trim$(rs3452!K3452_ShoesCode)
            If IsdbNull(rs3452!K3452_Specification) = False Then D3452.Specification = Trim$(rs3452!K3452_Specification)
            If IsdbNull(rs3452!K3452_Width) = False Then D3452.Width = Trim$(rs3452!K3452_Width)
            If IsdbNull(rs3452!K3452_Height) = False Then D3452.Height = Trim$(rs3452!K3452_Height)
            If IsdbNull(rs3452!K3452_SizeNo) = False Then D3452.SizeNo = Trim$(rs3452!K3452_SizeNo)
            If IsdbNull(rs3452!K3452_SizeName) = False Then D3452.SizeName = Trim$(rs3452!K3452_SizeName)
            If IsdbNull(rs3452!K3452_ColorName) = False Then D3452.ColorName = Trim$(rs3452!K3452_ColorName)
            If IsdbNull(rs3452!K3452_seOrigin) = False Then D3452.seOrigin = Trim$(rs3452!K3452_seOrigin)
            If IsdbNull(rs3452!K3452_cdOrigin) = False Then D3452.cdOrigin = Trim$(rs3452!K3452_cdOrigin)
            If IsdbNull(rs3452!K3452_MaterialCheck) = False Then D3452.MaterialCheck = Trim$(rs3452!K3452_MaterialCheck)
            If IsdbNull(rs3452!K3452_seUnitPrice) = False Then D3452.seUnitPrice = Trim$(rs3452!K3452_seUnitPrice)
            If IsdbNull(rs3452!K3452_cdUnitPrice) = False Then D3452.cdUnitPrice = Trim$(rs3452!K3452_cdUnitPrice)
            If IsdbNull(rs3452!K3452_seTax) = False Then D3452.seTax = Trim$(rs3452!K3452_seTax)
            If IsdbNull(rs3452!K3452_cdTax) = False Then D3452.cdTax = Trim$(rs3452!K3452_cdTax)
            If IsdbNull(rs3452!K3452_seUnitMaterial) = False Then D3452.seUnitMaterial = Trim$(rs3452!K3452_seUnitMaterial)
            If IsdbNull(rs3452!K3452_cdUnitMaterial) = False Then D3452.cdUnitMaterial = Trim$(rs3452!K3452_cdUnitMaterial)
            If IsdbNull(rs3452!K3452_seUnitPacking) = False Then D3452.seUnitPacking = Trim$(rs3452!K3452_seUnitPacking)
            If IsdbNull(rs3452!K3452_cdUnitPacking) = False Then D3452.cdUnitPacking = Trim$(rs3452!K3452_cdUnitPacking)
            If IsdbNull(rs3452!K3452_UnitBaseCheck) = False Then D3452.UnitBaseCheck = Trim$(rs3452!K3452_UnitBaseCheck)
            If IsdbNull(rs3452!K3452_QtyBasic) = False Then D3452.QtyBasic = Trim$(rs3452!K3452_QtyBasic)
            If IsdbNull(rs3452!K3452_PricePurchasing) = False Then D3452.PricePurchasing = Trim$(rs3452!K3452_PricePurchasing)
            If IsdbNull(rs3452!K3452_PriceMarket) = False Then D3452.PriceMarket = Trim$(rs3452!K3452_PriceMarket)
            If IsdbNull(rs3452!K3452_PriceExchange) = False Then D3452.PriceExchange = Trim$(rs3452!K3452_PriceExchange)
            If IsdbNull(rs3452!K3452_DateExchange) = False Then D3452.DateExchange = Trim$(rs3452!K3452_DateExchange)
            If IsdbNull(rs3452!K3452_PricePurchasingEX) = False Then D3452.PricePurchasingEX = Trim$(rs3452!K3452_PricePurchasingEX)
            If IsdbNull(rs3452!K3452_PriceMarketEX) = False Then D3452.PriceMarketEX = Trim$(rs3452!K3452_PriceMarketEX)
            If IsdbNull(rs3452!K3452_PricePurchasingVND) = False Then D3452.PricePurchasingVND = Trim$(rs3452!K3452_PricePurchasingVND)
            If IsdbNull(rs3452!K3452_PriceMarketVND) = False Then D3452.PriceMarketVND = Trim$(rs3452!K3452_PriceMarketVND)
            If IsdbNull(rs3452!K3452_AmountPurchasingEX) = False Then D3452.AmountPurchasingEX = Trim$(rs3452!K3452_AmountPurchasingEX)
            If IsdbNull(rs3452!K3452_AmountPurchasingVND) = False Then D3452.AmountPurchasingVND = Trim$(rs3452!K3452_AmountPurchasingVND)
            If IsdbNull(rs3452!K3452_AmountTaxEX) = False Then D3452.AmountTaxEX = Trim$(rs3452!K3452_AmountTaxEX)
            If IsdbNull(rs3452!K3452_AmountTaxVND) = False Then D3452.AmountTaxVND = Trim$(rs3452!K3452_AmountTaxVND)
            If IsdbNull(rs3452!K3452_QtyPurchasing) = False Then D3452.QtyPurchasing = Trim$(rs3452!K3452_QtyPurchasing)
            If IsdbNull(rs3452!K3452_PackPurchasing) = False Then D3452.PackPurchasing = Trim$(rs3452!K3452_PackPurchasing)
            If IsdbNull(rs3452!K3452_QtyWarehouse) = False Then D3452.QtyWarehouse = Trim$(rs3452!K3452_QtyWarehouse)
            If IsdbNull(rs3452!K3452_PackWarehouse) = False Then D3452.PackWarehouse = Trim$(rs3452!K3452_PackWarehouse)
            If IsdbNull(rs3452!K3452_QtyPacking) = False Then D3452.QtyPacking = Trim$(rs3452!K3452_QtyPacking)
            If IsdbNull(rs3452!K3452_PackPacking) = False Then D3452.PackPacking = Trim$(rs3452!K3452_PackPacking)
            If IsdbNull(rs3452!K3452_QtyInbound) = False Then D3452.QtyInbound = Trim$(rs3452!K3452_QtyInbound)
            If IsdbNull(rs3452!K3452_PackInbound) = False Then D3452.PackInbound = Trim$(rs3452!K3452_PackInbound)
            If IsdbNull(rs3452!K3452_QtyOutbound) = False Then D3452.QtyOutbound = Trim$(rs3452!K3452_QtyOutbound)
            If IsdbNull(rs3452!K3452_PackOutbound) = False Then D3452.PackOutbound = Trim$(rs3452!K3452_PackOutbound)
            If IsdbNull(rs3452!K3452_AmountInBoundEX) = False Then D3452.AmountInBoundEX = Trim$(rs3452!K3452_AmountInBoundEX)
            If IsdbNull(rs3452!K3452_AmountInBoundVND) = False Then D3452.AmountInBoundVND = Trim$(rs3452!K3452_AmountInBoundVND)
            If IsdbNull(rs3452!K3452_DateDelivery) = False Then D3452.DateDelivery = Trim$(rs3452!K3452_DateDelivery)
            If IsdbNull(rs3452!K3452_DateStart) = False Then D3452.DateStart = Trim$(rs3452!K3452_DateStart)
            If IsdbNull(rs3452!K3452_DateFinish) = False Then D3452.DateFinish = Trim$(rs3452!K3452_DateFinish)
            If IsdbNull(rs3452!K3452_CheckPurchasing) = False Then D3452.CheckPurchasing = Trim$(rs3452!K3452_CheckPurchasing)
            If IsdbNull(rs3452!K3452_DateAccept) = False Then D3452.DateAccept = Trim$(rs3452!K3452_DateAccept)
            If IsdbNull(rs3452!K3452_DatePosted) = False Then D3452.DatePosted = Trim$(rs3452!K3452_DatePosted)
            If IsdbNull(rs3452!K3452_IsPosted) = False Then D3452.IsPosted = Trim$(rs3452!K3452_IsPosted)
            If IsdbNull(rs3452!K3452_DateComplete) = False Then D3452.DateComplete = Trim$(rs3452!K3452_DateComplete)
            If IsdbNull(rs3452!K3452_DateApproval) = False Then D3452.DateApproval = Trim$(rs3452!K3452_DateApproval)
            If IsdbNull(rs3452!K3452_DateCancel) = False Then D3452.DateCancel = Trim$(rs3452!K3452_DateCancel)
            If IsdbNull(rs3452!K3452_CheckComplete) = False Then D3452.CheckComplete = Trim$(rs3452!K3452_CheckComplete)
            If IsdbNull(rs3452!K3452_ShippingWorkOrder) = False Then D3452.ShippingWorkOrder = Trim$(rs3452!K3452_ShippingWorkOrder)
            If IsdbNull(rs3452!K3452_ShippingWorkOrderSeq) = False Then D3452.ShippingWorkOrderSeq = Trim$(rs3452!K3452_ShippingWorkOrderSeq)
            If IsdbNull(rs3452!K3452_OrderNo) = False Then D3452.OrderNo = Trim$(rs3452!K3452_OrderNo)
            If IsdbNull(rs3452!K3452_OrderNoSeq) = False Then D3452.OrderNoSeq = Trim$(rs3452!K3452_OrderNoSeq)
            If IsdbNull(rs3452!K3452_Remark) = False Then D3452.Remark = Trim$(rs3452!K3452_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K3452_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K3452_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z3452 As T3452_AREA, AUTOKEY As Double) As Boolean

        K3452_MOVE = False

        Try
            If READ_PFK3452(AUTOKEY) = True Then
                z3452 = D3452
                K3452_MOVE = True
            Else
                z3452 = Nothing
            End If

            If getColumIndex(spr, "Autokey") > -1 Then z3452.Autokey = getDataM(spr, getColumIndex(spr, "Autokey"), xRow)
            If getColumIndex(spr, "TIVE30") > -1 Then z3452.TIVE30 = getDataM(spr, getColumIndex(spr, "TIVE30"), xRow)
            If getColumIndex(spr, "DTIV30") > -1 Then z3452.DTIV30 = getDataM(spr, getColumIndex(spr, "DTIV30"), xRow)
            If getColumIndex(spr, "DTEX30") > -1 Then z3452.DTEX30 = getDataM(spr, getColumIndex(spr, "DTEX30"), xRow)
            If getColumIndex(spr, "FactOrderNo") > -1 Then z3452.FactOrderNo = getDataM(spr, getColumIndex(spr, "FactOrderNo"), xRow)
            If getColumIndex(spr, "FactOrderSeq") > -1 Then z3452.FactOrderSeq = getDataM(spr, getColumIndex(spr, "FactOrderSeq"), xRow)
            If getColumIndex(spr, "PackingBatch") > -1 Then z3452.PackingBatch = getDataM(spr, getColumIndex(spr, "PackingBatch"), xRow)
            If getColumIndex(spr, "PKO") > -1 Then z3452.PKO = getDataM(spr, getColumIndex(spr, "PKO"), xRow)
            If getColumIndex(spr, "seSite") > -1 Then z3452.seSite = getDataM(spr, getColumIndex(spr, "seSite"), xRow)
            If getColumIndex(spr, "cdSite") > -1 Then z3452.cdSite = getDataM(spr, getColumIndex(spr, "cdSite"), xRow)
            If getColumIndex(spr, "seDepartment") > -1 Then z3452.seDepartment = getDataM(spr, getColumIndex(spr, "seDepartment"), xRow)
            If getColumIndex(spr, "cdDepartment") > -1 Then z3452.cdDepartment = getDataM(spr, getColumIndex(spr, "cdDepartment"), xRow)
            If getColumIndex(spr, "CustomerSupplier") > -1 Then z3452.CustomerSupplier = getDataM(spr, getColumIndex(spr, "CustomerSupplier"), xRow)
            If getColumIndex(spr, "Dseq") > -1 Then z3452.Dseq = getDataM(spr, getColumIndex(spr, "Dseq"), xRow)
            If getColumIndex(spr, "CheckRelationType") > -1 Then z3452.CheckRelationType = getDataM(spr, getColumIndex(spr, "CheckRelationType"), xRow)
            If getColumIndex(spr, "ShoesCode") > -1 Then z3452.ShoesCode = getDataM(spr, getColumIndex(spr, "ShoesCode"), xRow)
            If getColumIndex(spr, "Specification") > -1 Then z3452.Specification = getDataM(spr, getColumIndex(spr, "Specification"), xRow)
            If getColumIndex(spr, "Width") > -1 Then z3452.Width = getDataM(spr, getColumIndex(spr, "Width"), xRow)
            If getColumIndex(spr, "Height") > -1 Then z3452.Height = getDataM(spr, getColumIndex(spr, "Height"), xRow)
            If getColumIndex(spr, "SizeNo") > -1 Then z3452.SizeNo = getDataM(spr, getColumIndex(spr, "SizeNo"), xRow)
            If getColumIndex(spr, "SizeName") > -1 Then z3452.SizeName = getDataM(spr, getColumIndex(spr, "SizeName"), xRow)
            If getColumIndex(spr, "ColorName") > -1 Then z3452.ColorName = getDataM(spr, getColumIndex(spr, "ColorName"), xRow)
            If getColumIndex(spr, "seOrigin") > -1 Then z3452.seOrigin = getDataM(spr, getColumIndex(spr, "seOrigin"), xRow)
            If getColumIndex(spr, "cdOrigin") > -1 Then z3452.cdOrigin = getDataM(spr, getColumIndex(spr, "cdOrigin"), xRow)
            If getColumIndex(spr, "MaterialCheck") > -1 Then z3452.MaterialCheck = getDataM(spr, getColumIndex(spr, "MaterialCheck"), xRow)
            If getColumIndex(spr, "seUnitPrice") > -1 Then z3452.seUnitPrice = getDataM(spr, getColumIndex(spr, "seUnitPrice"), xRow)
            If getColumIndex(spr, "cdUnitPrice") > -1 Then z3452.cdUnitPrice = getDataM(spr, getColumIndex(spr, "cdUnitPrice"), xRow)
            If getColumIndex(spr, "seTax") > -1 Then z3452.seTax = getDataM(spr, getColumIndex(spr, "seTax"), xRow)
            If getColumIndex(spr, "cdTax") > -1 Then z3452.cdTax = getDataM(spr, getColumIndex(spr, "cdTax"), xRow)
            If getColumIndex(spr, "seUnitMaterial") > -1 Then z3452.seUnitMaterial = getDataM(spr, getColumIndex(spr, "seUnitMaterial"), xRow)
            If getColumIndex(spr, "cdUnitMaterial") > -1 Then z3452.cdUnitMaterial = getDataM(spr, getColumIndex(spr, "cdUnitMaterial"), xRow)
            If getColumIndex(spr, "seUnitPacking") > -1 Then z3452.seUnitPacking = getDataM(spr, getColumIndex(spr, "seUnitPacking"), xRow)
            If getColumIndex(spr, "cdUnitPacking") > -1 Then z3452.cdUnitPacking = getDataM(spr, getColumIndex(spr, "cdUnitPacking"), xRow)
            If getColumIndex(spr, "UnitBaseCheck") > -1 Then z3452.UnitBaseCheck = getDataM(spr, getColumIndex(spr, "UnitBaseCheck"), xRow)
            If getColumIndex(spr, "QtyBasic") > -1 Then z3452.QtyBasic = getDataM(spr, getColumIndex(spr, "QtyBasic"), xRow)
            If getColumIndex(spr, "PricePurchasing") > -1 Then z3452.PricePurchasing = getDataM(spr, getColumIndex(spr, "PricePurchasing"), xRow)
            If getColumIndex(spr, "PriceMarket") > -1 Then z3452.PriceMarket = getDataM(spr, getColumIndex(spr, "PriceMarket"), xRow)
            If getColumIndex(spr, "PriceExchange") > -1 Then z3452.PriceExchange = getDataM(spr, getColumIndex(spr, "PriceExchange"), xRow)
            If getColumIndex(spr, "DateExchange") > -1 Then z3452.DateExchange = getDataM(spr, getColumIndex(spr, "DateExchange"), xRow)
            If getColumIndex(spr, "PricePurchasingEX") > -1 Then z3452.PricePurchasingEX = getDataM(spr, getColumIndex(spr, "PricePurchasingEX"), xRow)
            If getColumIndex(spr, "PriceMarketEX") > -1 Then z3452.PriceMarketEX = getDataM(spr, getColumIndex(spr, "PriceMarketEX"), xRow)
            If getColumIndex(spr, "PricePurchasingVND") > -1 Then z3452.PricePurchasingVND = getDataM(spr, getColumIndex(spr, "PricePurchasingVND"), xRow)
            If getColumIndex(spr, "PriceMarketVND") > -1 Then z3452.PriceMarketVND = getDataM(spr, getColumIndex(spr, "PriceMarketVND"), xRow)
            If getColumIndex(spr, "AmountPurchasingEX") > -1 Then z3452.AmountPurchasingEX = getDataM(spr, getColumIndex(spr, "AmountPurchasingEX"), xRow)
            If getColumIndex(spr, "AmountPurchasingVND") > -1 Then z3452.AmountPurchasingVND = getDataM(spr, getColumIndex(spr, "AmountPurchasingVND"), xRow)
            If getColumIndex(spr, "AmountTaxEX") > -1 Then z3452.AmountTaxEX = getDataM(spr, getColumIndex(spr, "AmountTaxEX"), xRow)
            If getColumIndex(spr, "AmountTaxVND") > -1 Then z3452.AmountTaxVND = getDataM(spr, getColumIndex(spr, "AmountTaxVND"), xRow)
            If getColumIndex(spr, "QtyPurchasing") > -1 Then z3452.QtyPurchasing = getDataM(spr, getColumIndex(spr, "QtyPurchasing"), xRow)
            If getColumIndex(spr, "PackPurchasing") > -1 Then z3452.PackPurchasing = getDataM(spr, getColumIndex(spr, "PackPurchasing"), xRow)
            If getColumIndex(spr, "QtyWarehouse") > -1 Then z3452.QtyWarehouse = getDataM(spr, getColumIndex(spr, "QtyWarehouse"), xRow)
            If getColumIndex(spr, "PackWarehouse") > -1 Then z3452.PackWarehouse = getDataM(spr, getColumIndex(spr, "PackWarehouse"), xRow)
            If getColumIndex(spr, "QtyPacking") > -1 Then z3452.QtyPacking = getDataM(spr, getColumIndex(spr, "QtyPacking"), xRow)
            If getColumIndex(spr, "PackPacking") > -1 Then z3452.PackPacking = getDataM(spr, getColumIndex(spr, "PackPacking"), xRow)
            If getColumIndex(spr, "QtyInbound") > -1 Then z3452.QtyInbound = getDataM(spr, getColumIndex(spr, "QtyInbound"), xRow)
            If getColumIndex(spr, "PackInbound") > -1 Then z3452.PackInbound = getDataM(spr, getColumIndex(spr, "PackInbound"), xRow)
            If getColumIndex(spr, "QtyOutbound") > -1 Then z3452.QtyOutbound = getDataM(spr, getColumIndex(spr, "QtyOutbound"), xRow)
            If getColumIndex(spr, "PackOutbound") > -1 Then z3452.PackOutbound = getDataM(spr, getColumIndex(spr, "PackOutbound"), xRow)
            If getColumIndex(spr, "AmountInBoundEX") > -1 Then z3452.AmountInBoundEX = getDataM(spr, getColumIndex(spr, "AmountInBoundEX"), xRow)
            If getColumIndex(spr, "AmountInBoundVND") > -1 Then z3452.AmountInBoundVND = getDataM(spr, getColumIndex(spr, "AmountInBoundVND"), xRow)
            If getColumIndex(spr, "DateDelivery") > -1 Then z3452.DateDelivery = getDataM(spr, getColumIndex(spr, "DateDelivery"), xRow)
            If getColumIndex(spr, "DateStart") > -1 Then z3452.DateStart = getDataM(spr, getColumIndex(spr, "DateStart"), xRow)
            If getColumIndex(spr, "DateFinish") > -1 Then z3452.DateFinish = getDataM(spr, getColumIndex(spr, "DateFinish"), xRow)
            If getColumIndex(spr, "CheckPurchasing") > -1 Then z3452.CheckPurchasing = getDataM(spr, getColumIndex(spr, "CheckPurchasing"), xRow)
            If getColumIndex(spr, "DateAccept") > -1 Then z3452.DateAccept = getDataM(spr, getColumIndex(spr, "DateAccept"), xRow)
            If getColumIndex(spr, "DatePosted") > -1 Then z3452.DatePosted = getDataM(spr, getColumIndex(spr, "DatePosted"), xRow)
            If getColumIndex(spr, "IsPosted") > -1 Then z3452.IsPosted = getDataM(spr, getColumIndex(spr, "IsPosted"), xRow)
            If getColumIndex(spr, "DateComplete") > -1 Then z3452.DateComplete = getDataM(spr, getColumIndex(spr, "DateComplete"), xRow)
            If getColumIndex(spr, "DateApproval") > -1 Then z3452.DateApproval = getDataM(spr, getColumIndex(spr, "DateApproval"), xRow)
            If getColumIndex(spr, "DateCancel") > -1 Then z3452.DateCancel = getDataM(spr, getColumIndex(spr, "DateCancel"), xRow)
            If getColumIndex(spr, "CheckComplete") > -1 Then z3452.CheckComplete = getDataM(spr, getColumIndex(spr, "CheckComplete"), xRow)
            If getColumIndex(spr, "ShippingWorkOrder") > -1 Then z3452.ShippingWorkOrder = getDataM(spr, getColumIndex(spr, "ShippingWorkOrder"), xRow)
            If getColumIndex(spr, "ShippingWorkOrderSeq") > -1 Then z3452.ShippingWorkOrderSeq = getDataM(spr, getColumIndex(spr, "ShippingWorkOrderSeq"), xRow)
            If getColumIndex(spr, "OrderNo") > -1 Then z3452.OrderNo = getDataM(spr, getColumIndex(spr, "OrderNo"), xRow)
            If getColumIndex(spr, "OrderNoSeq") > -1 Then z3452.OrderNoSeq = getDataM(spr, getColumIndex(spr, "OrderNoSeq"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z3452.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K3452_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K3452_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z3452 As T3452_AREA, CheckClear As Boolean, AUTOKEY As Double) As Boolean

        K3452_MOVE = False

        Try
            If READ_PFK3452(AUTOKEY) = True Then
                z3452 = D3452
                K3452_MOVE = True
            Else
                If CheckClear = True Then z3452 = Nothing
            End If

            If getColumIndex(spr, "Autokey") > -1 Then z3452.Autokey = getDataM(spr, getColumIndex(spr, "Autokey"), xRow)
            If getColumIndex(spr, "TIVE30") > -1 Then z3452.TIVE30 = getDataM(spr, getColumIndex(spr, "TIVE30"), xRow)
            If getColumIndex(spr, "DTIV30") > -1 Then z3452.DTIV30 = getDataM(spr, getColumIndex(spr, "DTIV30"), xRow)
            If getColumIndex(spr, "DTEX30") > -1 Then z3452.DTEX30 = getDataM(spr, getColumIndex(spr, "DTEX30"), xRow)
            If getColumIndex(spr, "FactOrderNo") > -1 Then z3452.FactOrderNo = getDataM(spr, getColumIndex(spr, "FactOrderNo"), xRow)
            If getColumIndex(spr, "FactOrderSeq") > -1 Then z3452.FactOrderSeq = getDataM(spr, getColumIndex(spr, "FactOrderSeq"), xRow)
            If getColumIndex(spr, "PackingBatch") > -1 Then z3452.PackingBatch = getDataM(spr, getColumIndex(spr, "PackingBatch"), xRow)
            If getColumIndex(spr, "PKO") > -1 Then z3452.PKO = getDataM(spr, getColumIndex(spr, "PKO"), xRow)
            If getColumIndex(spr, "seSite") > -1 Then z3452.seSite = getDataM(spr, getColumIndex(spr, "seSite"), xRow)
            If getColumIndex(spr, "cdSite") > -1 Then z3452.cdSite = getDataM(spr, getColumIndex(spr, "cdSite"), xRow)
            If getColumIndex(spr, "seDepartment") > -1 Then z3452.seDepartment = getDataM(spr, getColumIndex(spr, "seDepartment"), xRow)
            If getColumIndex(spr, "cdDepartment") > -1 Then z3452.cdDepartment = getDataM(spr, getColumIndex(spr, "cdDepartment"), xRow)
            If getColumIndex(spr, "CustomerSupplier") > -1 Then z3452.CustomerSupplier = getDataM(spr, getColumIndex(spr, "CustomerSupplier"), xRow)
            If getColumIndex(spr, "Dseq") > -1 Then z3452.Dseq = getDataM(spr, getColumIndex(spr, "Dseq"), xRow)
            If getColumIndex(spr, "CheckRelationType") > -1 Then z3452.CheckRelationType = getDataM(spr, getColumIndex(spr, "CheckRelationType"), xRow)
            If getColumIndex(spr, "ShoesCode") > -1 Then z3452.ShoesCode = getDataM(spr, getColumIndex(spr, "ShoesCode"), xRow)
            If getColumIndex(spr, "Specification") > -1 Then z3452.Specification = getDataM(spr, getColumIndex(spr, "Specification"), xRow)
            If getColumIndex(spr, "Width") > -1 Then z3452.Width = getDataM(spr, getColumIndex(spr, "Width"), xRow)
            If getColumIndex(spr, "Height") > -1 Then z3452.Height = getDataM(spr, getColumIndex(spr, "Height"), xRow)
            If getColumIndex(spr, "SizeNo") > -1 Then z3452.SizeNo = getDataM(spr, getColumIndex(spr, "SizeNo"), xRow)
            If getColumIndex(spr, "SizeName") > -1 Then z3452.SizeName = getDataM(spr, getColumIndex(spr, "SizeName"), xRow)
            If getColumIndex(spr, "ColorName") > -1 Then z3452.ColorName = getDataM(spr, getColumIndex(spr, "ColorName"), xRow)
            If getColumIndex(spr, "seOrigin") > -1 Then z3452.seOrigin = getDataM(spr, getColumIndex(spr, "seOrigin"), xRow)
            If getColumIndex(spr, "cdOrigin") > -1 Then z3452.cdOrigin = getDataM(spr, getColumIndex(spr, "cdOrigin"), xRow)
            If getColumIndex(spr, "MaterialCheck") > -1 Then z3452.MaterialCheck = getDataM(spr, getColumIndex(spr, "MaterialCheck"), xRow)
            If getColumIndex(spr, "seUnitPrice") > -1 Then z3452.seUnitPrice = getDataM(spr, getColumIndex(spr, "seUnitPrice"), xRow)
            If getColumIndex(spr, "cdUnitPrice") > -1 Then z3452.cdUnitPrice = getDataM(spr, getColumIndex(spr, "cdUnitPrice"), xRow)
            If getColumIndex(spr, "seTax") > -1 Then z3452.seTax = getDataM(spr, getColumIndex(spr, "seTax"), xRow)
            If getColumIndex(spr, "cdTax") > -1 Then z3452.cdTax = getDataM(spr, getColumIndex(spr, "cdTax"), xRow)
            If getColumIndex(spr, "seUnitMaterial") > -1 Then z3452.seUnitMaterial = getDataM(spr, getColumIndex(spr, "seUnitMaterial"), xRow)
            If getColumIndex(spr, "cdUnitMaterial") > -1 Then z3452.cdUnitMaterial = getDataM(spr, getColumIndex(spr, "cdUnitMaterial"), xRow)
            If getColumIndex(spr, "seUnitPacking") > -1 Then z3452.seUnitPacking = getDataM(spr, getColumIndex(spr, "seUnitPacking"), xRow)
            If getColumIndex(spr, "cdUnitPacking") > -1 Then z3452.cdUnitPacking = getDataM(spr, getColumIndex(spr, "cdUnitPacking"), xRow)
            If getColumIndex(spr, "UnitBaseCheck") > -1 Then z3452.UnitBaseCheck = getDataM(spr, getColumIndex(spr, "UnitBaseCheck"), xRow)
            If getColumIndex(spr, "QtyBasic") > -1 Then z3452.QtyBasic = getDataM(spr, getColumIndex(spr, "QtyBasic"), xRow)
            If getColumIndex(spr, "PricePurchasing") > -1 Then z3452.PricePurchasing = getDataM(spr, getColumIndex(spr, "PricePurchasing"), xRow)
            If getColumIndex(spr, "PriceMarket") > -1 Then z3452.PriceMarket = getDataM(spr, getColumIndex(spr, "PriceMarket"), xRow)
            If getColumIndex(spr, "PriceExchange") > -1 Then z3452.PriceExchange = getDataM(spr, getColumIndex(spr, "PriceExchange"), xRow)
            If getColumIndex(spr, "DateExchange") > -1 Then z3452.DateExchange = getDataM(spr, getColumIndex(spr, "DateExchange"), xRow)
            If getColumIndex(spr, "PricePurchasingEX") > -1 Then z3452.PricePurchasingEX = getDataM(spr, getColumIndex(spr, "PricePurchasingEX"), xRow)
            If getColumIndex(spr, "PriceMarketEX") > -1 Then z3452.PriceMarketEX = getDataM(spr, getColumIndex(spr, "PriceMarketEX"), xRow)
            If getColumIndex(spr, "PricePurchasingVND") > -1 Then z3452.PricePurchasingVND = getDataM(spr, getColumIndex(spr, "PricePurchasingVND"), xRow)
            If getColumIndex(spr, "PriceMarketVND") > -1 Then z3452.PriceMarketVND = getDataM(spr, getColumIndex(spr, "PriceMarketVND"), xRow)
            If getColumIndex(spr, "AmountPurchasingEX") > -1 Then z3452.AmountPurchasingEX = getDataM(spr, getColumIndex(spr, "AmountPurchasingEX"), xRow)
            If getColumIndex(spr, "AmountPurchasingVND") > -1 Then z3452.AmountPurchasingVND = getDataM(spr, getColumIndex(spr, "AmountPurchasingVND"), xRow)
            If getColumIndex(spr, "AmountTaxEX") > -1 Then z3452.AmountTaxEX = getDataM(spr, getColumIndex(spr, "AmountTaxEX"), xRow)
            If getColumIndex(spr, "AmountTaxVND") > -1 Then z3452.AmountTaxVND = getDataM(spr, getColumIndex(spr, "AmountTaxVND"), xRow)
            If getColumIndex(spr, "QtyPurchasing") > -1 Then z3452.QtyPurchasing = getDataM(spr, getColumIndex(spr, "QtyPurchasing"), xRow)
            If getColumIndex(spr, "PackPurchasing") > -1 Then z3452.PackPurchasing = getDataM(spr, getColumIndex(spr, "PackPurchasing"), xRow)
            If getColumIndex(spr, "QtyWarehouse") > -1 Then z3452.QtyWarehouse = getDataM(spr, getColumIndex(spr, "QtyWarehouse"), xRow)
            If getColumIndex(spr, "PackWarehouse") > -1 Then z3452.PackWarehouse = getDataM(spr, getColumIndex(spr, "PackWarehouse"), xRow)
            If getColumIndex(spr, "QtyPacking") > -1 Then z3452.QtyPacking = getDataM(spr, getColumIndex(spr, "QtyPacking"), xRow)
            If getColumIndex(spr, "PackPacking") > -1 Then z3452.PackPacking = getDataM(spr, getColumIndex(spr, "PackPacking"), xRow)
            If getColumIndex(spr, "QtyInbound") > -1 Then z3452.QtyInbound = getDataM(spr, getColumIndex(spr, "QtyInbound"), xRow)
            If getColumIndex(spr, "PackInbound") > -1 Then z3452.PackInbound = getDataM(spr, getColumIndex(spr, "PackInbound"), xRow)
            If getColumIndex(spr, "QtyOutbound") > -1 Then z3452.QtyOutbound = getDataM(spr, getColumIndex(spr, "QtyOutbound"), xRow)
            If getColumIndex(spr, "PackOutbound") > -1 Then z3452.PackOutbound = getDataM(spr, getColumIndex(spr, "PackOutbound"), xRow)
            If getColumIndex(spr, "AmountInBoundEX") > -1 Then z3452.AmountInBoundEX = getDataM(spr, getColumIndex(spr, "AmountInBoundEX"), xRow)
            If getColumIndex(spr, "AmountInBoundVND") > -1 Then z3452.AmountInBoundVND = getDataM(spr, getColumIndex(spr, "AmountInBoundVND"), xRow)
            If getColumIndex(spr, "DateDelivery") > -1 Then z3452.DateDelivery = getDataM(spr, getColumIndex(spr, "DateDelivery"), xRow)
            If getColumIndex(spr, "DateStart") > -1 Then z3452.DateStart = getDataM(spr, getColumIndex(spr, "DateStart"), xRow)
            If getColumIndex(spr, "DateFinish") > -1 Then z3452.DateFinish = getDataM(spr, getColumIndex(spr, "DateFinish"), xRow)
            If getColumIndex(spr, "CheckPurchasing") > -1 Then z3452.CheckPurchasing = getDataM(spr, getColumIndex(spr, "CheckPurchasing"), xRow)
            If getColumIndex(spr, "DateAccept") > -1 Then z3452.DateAccept = getDataM(spr, getColumIndex(spr, "DateAccept"), xRow)
            If getColumIndex(spr, "DatePosted") > -1 Then z3452.DatePosted = getDataM(spr, getColumIndex(spr, "DatePosted"), xRow)
            If getColumIndex(spr, "IsPosted") > -1 Then z3452.IsPosted = getDataM(spr, getColumIndex(spr, "IsPosted"), xRow)
            If getColumIndex(spr, "DateComplete") > -1 Then z3452.DateComplete = getDataM(spr, getColumIndex(spr, "DateComplete"), xRow)
            If getColumIndex(spr, "DateApproval") > -1 Then z3452.DateApproval = getDataM(spr, getColumIndex(spr, "DateApproval"), xRow)
            If getColumIndex(spr, "DateCancel") > -1 Then z3452.DateCancel = getDataM(spr, getColumIndex(spr, "DateCancel"), xRow)
            If getColumIndex(spr, "CheckComplete") > -1 Then z3452.CheckComplete = getDataM(spr, getColumIndex(spr, "CheckComplete"), xRow)
            If getColumIndex(spr, "ShippingWorkOrder") > -1 Then z3452.ShippingWorkOrder = getDataM(spr, getColumIndex(spr, "ShippingWorkOrder"), xRow)
            If getColumIndex(spr, "ShippingWorkOrderSeq") > -1 Then z3452.ShippingWorkOrderSeq = getDataM(spr, getColumIndex(spr, "ShippingWorkOrderSeq"), xRow)
            If getColumIndex(spr, "OrderNo") > -1 Then z3452.OrderNo = getDataM(spr, getColumIndex(spr, "OrderNo"), xRow)
            If getColumIndex(spr, "OrderNoSeq") > -1 Then z3452.OrderNoSeq = getDataM(spr, getColumIndex(spr, "OrderNoSeq"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z3452.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K3452_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K3452_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z3452 As T3452_AREA, Job As String, AUTOKEY As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K3452_MOVE = False

        Try
            If READ_PFK3452(AUTOKEY) = True Then
                z3452 = D3452
                K3452_MOVE = True
            Else
                z3452 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3452")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "AUTOKEY" : z3452.Autokey = Children(i).Code
                                Case "TIVE30" : z3452.TIVE30 = Children(i).Code
                                Case "DTIV30" : z3452.DTIV30 = Children(i).Code
                                Case "DTEX30" : z3452.DTEX30 = Children(i).Code
                                Case "FACTORDERNO" : z3452.FactOrderNo = Children(i).Code
                                Case "FACTORDERSEQ" : z3452.FactOrderSeq = Children(i).Code
                                Case "PACKINGBATCH" : z3452.PackingBatch = Children(i).Code
                                Case "PKO" : z3452.PKO = Children(i).Code
                                Case "SESITE" : z3452.seSite = Children(i).Code
                                Case "CDSITE" : z3452.cdSite = Children(i).Code
                                Case "SEDEPARTMENT" : z3452.seDepartment = Children(i).Code
                                Case "CDDEPARTMENT" : z3452.cdDepartment = Children(i).Code
                                Case "CUSTOMERSUPPLIER" : z3452.CustomerSupplier = Children(i).Code
                                Case "DSEQ" : z3452.Dseq = Children(i).Code
                                Case "CHECKRELATIONTYPE" : z3452.CheckRelationType = Children(i).Code
                                Case "SHOESCODE" : z3452.ShoesCode = Children(i).Code
                                Case "SPECIFICATION" : z3452.Specification = Children(i).Code
                                Case "WIDTH" : z3452.Width = Children(i).Code
                                Case "HEIGHT" : z3452.Height = Children(i).Code
                                Case "SIZENO" : z3452.SizeNo = Children(i).Code
                                Case "SIZENAME" : z3452.SizeName = Children(i).Code
                                Case "COLORNAME" : z3452.ColorName = Children(i).Code
                                Case "SEORIGIN" : z3452.seOrigin = Children(i).Code
                                Case "CDORIGIN" : z3452.cdOrigin = Children(i).Code
                                Case "MATERIALCHECK" : z3452.MaterialCheck = Children(i).Code
                                Case "SEUNITPRICE" : z3452.seUnitPrice = Children(i).Code
                                Case "CDUNITPRICE" : z3452.cdUnitPrice = Children(i).Code
                                Case "SETAX" : z3452.seTax = Children(i).Code
                                Case "CDTAX" : z3452.cdTax = Children(i).Code
                                Case "SEUNITMATERIAL" : z3452.seUnitMaterial = Children(i).Code
                                Case "CDUNITMATERIAL" : z3452.cdUnitMaterial = Children(i).Code
                                Case "SEUNITPACKING" : z3452.seUnitPacking = Children(i).Code
                                Case "CDUNITPACKING" : z3452.cdUnitPacking = Children(i).Code
                                Case "UNITBASECHECK" : z3452.UnitBaseCheck = Children(i).Code
                                Case "QTYBASIC" : z3452.QtyBasic = Children(i).Code
                                Case "PRICEPURCHASING" : z3452.PricePurchasing = Children(i).Code
                                Case "PRICEMARKET" : z3452.PriceMarket = Children(i).Code
                                Case "PRICEEXCHANGE" : z3452.PriceExchange = Children(i).Code
                                Case "DATEEXCHANGE" : z3452.DateExchange = Children(i).Code
                                Case "PRICEPURCHASINGEX" : z3452.PricePurchasingEX = Children(i).Code
                                Case "PRICEMARKETEX" : z3452.PriceMarketEX = Children(i).Code
                                Case "PRICEPURCHASINGVND" : z3452.PricePurchasingVND = Children(i).Code
                                Case "PRICEMARKETVND" : z3452.PriceMarketVND = Children(i).Code
                                Case "AMOUNTPURCHASINGEX" : z3452.AmountPurchasingEX = Children(i).Code
                                Case "AMOUNTPURCHASINGVND" : z3452.AmountPurchasingVND = Children(i).Code
                                Case "AMOUNTTAXEX" : z3452.AmountTaxEX = Children(i).Code
                                Case "AMOUNTTAXVND" : z3452.AmountTaxVND = Children(i).Code
                                Case "QTYPURCHASING" : z3452.QtyPurchasing = Children(i).Code
                                Case "PACKPURCHASING" : z3452.PackPurchasing = Children(i).Code
                                Case "QTYWAREHOUSE" : z3452.QtyWarehouse = Children(i).Code
                                Case "PACKWAREHOUSE" : z3452.PackWarehouse = Children(i).Code
                                Case "QTYPACKING" : z3452.QtyPacking = Children(i).Code
                                Case "PACKPACKING" : z3452.PackPacking = Children(i).Code
                                Case "QTYINBOUND" : z3452.QtyInbound = Children(i).Code
                                Case "PACKINBOUND" : z3452.PackInbound = Children(i).Code
                                Case "QTYOUTBOUND" : z3452.QtyOutbound = Children(i).Code
                                Case "PACKOUTBOUND" : z3452.PackOutbound = Children(i).Code
                                Case "AMOUNTINBOUNDEX" : z3452.AmountInBoundEX = Children(i).Code
                                Case "AMOUNTINBOUNDVND" : z3452.AmountInBoundVND = Children(i).Code
                                Case "DATEDELIVERY" : z3452.DateDelivery = Children(i).Code
                                Case "DATESTART" : z3452.DateStart = Children(i).Code
                                Case "DATEFINISH" : z3452.DateFinish = Children(i).Code
                                Case "CHECKPURCHASING" : z3452.CheckPurchasing = Children(i).Code
                                Case "DATEACCEPT" : z3452.DateAccept = Children(i).Code
                                Case "DATEPOSTED" : z3452.DatePosted = Children(i).Code
                                Case "ISPOSTED" : z3452.IsPosted = Children(i).Code
                                Case "DATECOMPLETE" : z3452.DateComplete = Children(i).Code
                                Case "DATEAPPROVAL" : z3452.DateApproval = Children(i).Code
                                Case "DATECANCEL" : z3452.DateCancel = Children(i).Code
                                Case "CHECKCOMPLETE" : z3452.CheckComplete = Children(i).Code
                                Case "SHIPPINGWORKORDER" : z3452.ShippingWorkOrder = Children(i).Code
                                Case "SHIPPINGWORKORDERSEQ" : z3452.ShippingWorkOrderSeq = Children(i).Code
                                Case "ORDERNO" : z3452.OrderNo = Children(i).Code
                                Case "ORDERNOSEQ" : z3452.OrderNoSeq = Children(i).Code
                                Case "REMARK" : z3452.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "AUTOKEY" : z3452.Autokey = Children(i).Data
                                Case "TIVE30" : z3452.TIVE30 = Children(i).Data
                                Case "DTIV30" : z3452.DTIV30 = Children(i).Data
                                Case "DTEX30" : z3452.DTEX30 = Children(i).Data
                                Case "FACTORDERNO" : z3452.FactOrderNo = Children(i).Data
                                Case "FACTORDERSEQ" : z3452.FactOrderSeq = Children(i).Data
                                Case "PACKINGBATCH" : z3452.PackingBatch = Children(i).Data
                                Case "PKO" : z3452.PKO = Children(i).Data
                                Case "SESITE" : z3452.seSite = Children(i).Data
                                Case "CDSITE" : z3452.cdSite = Children(i).Data
                                Case "SEDEPARTMENT" : z3452.seDepartment = Children(i).Data
                                Case "CDDEPARTMENT" : z3452.cdDepartment = Children(i).Data
                                Case "CUSTOMERSUPPLIER" : z3452.CustomerSupplier = Children(i).Data
                                Case "DSEQ" : z3452.Dseq = Children(i).Data
                                Case "CHECKRELATIONTYPE" : z3452.CheckRelationType = Children(i).Data
                                Case "SHOESCODE" : z3452.ShoesCode = Children(i).Data
                                Case "SPECIFICATION" : z3452.Specification = Children(i).Data
                                Case "WIDTH" : z3452.Width = Children(i).Data
                                Case "HEIGHT" : z3452.Height = Children(i).Data
                                Case "SIZENO" : z3452.SizeNo = Children(i).Data
                                Case "SIZENAME" : z3452.SizeName = Children(i).Data
                                Case "COLORNAME" : z3452.ColorName = Children(i).Data
                                Case "SEORIGIN" : z3452.seOrigin = Children(i).Data
                                Case "CDORIGIN" : z3452.cdOrigin = Children(i).Data
                                Case "MATERIALCHECK" : z3452.MaterialCheck = Children(i).Data
                                Case "SEUNITPRICE" : z3452.seUnitPrice = Children(i).Data
                                Case "CDUNITPRICE" : z3452.cdUnitPrice = Children(i).Data
                                Case "SETAX" : z3452.seTax = Children(i).Data
                                Case "CDTAX" : z3452.cdTax = Children(i).Data
                                Case "SEUNITMATERIAL" : z3452.seUnitMaterial = Children(i).Data
                                Case "CDUNITMATERIAL" : z3452.cdUnitMaterial = Children(i).Data
                                Case "SEUNITPACKING" : z3452.seUnitPacking = Children(i).Data
                                Case "CDUNITPACKING" : z3452.cdUnitPacking = Children(i).Data
                                Case "UNITBASECHECK" : z3452.UnitBaseCheck = Children(i).Data
                                Case "QTYBASIC" : z3452.QtyBasic = Children(i).Data
                                Case "PRICEPURCHASING" : z3452.PricePurchasing = Children(i).Data
                                Case "PRICEMARKET" : z3452.PriceMarket = Children(i).Data
                                Case "PRICEEXCHANGE" : z3452.PriceExchange = Children(i).Data
                                Case "DATEEXCHANGE" : z3452.DateExchange = Children(i).Data
                                Case "PRICEPURCHASINGEX" : z3452.PricePurchasingEX = Children(i).Data
                                Case "PRICEMARKETEX" : z3452.PriceMarketEX = Children(i).Data
                                Case "PRICEPURCHASINGVND" : z3452.PricePurchasingVND = Children(i).Data
                                Case "PRICEMARKETVND" : z3452.PriceMarketVND = Children(i).Data
                                Case "AMOUNTPURCHASINGEX" : z3452.AmountPurchasingEX = Children(i).Data
                                Case "AMOUNTPURCHASINGVND" : z3452.AmountPurchasingVND = Children(i).Data
                                Case "AMOUNTTAXEX" : z3452.AmountTaxEX = Children(i).Data
                                Case "AMOUNTTAXVND" : z3452.AmountTaxVND = Children(i).Data
                                Case "QTYPURCHASING" : z3452.QtyPurchasing = Children(i).Data
                                Case "PACKPURCHASING" : z3452.PackPurchasing = Children(i).Data
                                Case "QTYWAREHOUSE" : z3452.QtyWarehouse = Children(i).Data
                                Case "PACKWAREHOUSE" : z3452.PackWarehouse = Children(i).Data
                                Case "QTYPACKING" : z3452.QtyPacking = Children(i).Data
                                Case "PACKPACKING" : z3452.PackPacking = Children(i).Data
                                Case "QTYINBOUND" : z3452.QtyInbound = Children(i).Data
                                Case "PACKINBOUND" : z3452.PackInbound = Children(i).Data
                                Case "QTYOUTBOUND" : z3452.QtyOutbound = Children(i).Data
                                Case "PACKOUTBOUND" : z3452.PackOutbound = Children(i).Data
                                Case "AMOUNTINBOUNDEX" : z3452.AmountInBoundEX = Children(i).Data
                                Case "AMOUNTINBOUNDVND" : z3452.AmountInBoundVND = Children(i).Data
                                Case "DATEDELIVERY" : z3452.DateDelivery = Children(i).Data
                                Case "DATESTART" : z3452.DateStart = Children(i).Data
                                Case "DATEFINISH" : z3452.DateFinish = Children(i).Data
                                Case "CHECKPURCHASING" : z3452.CheckPurchasing = Children(i).Data
                                Case "DATEACCEPT" : z3452.DateAccept = Children(i).Data
                                Case "DATEPOSTED" : z3452.DatePosted = Children(i).Data
                                Case "ISPOSTED" : z3452.IsPosted = Children(i).Data
                                Case "DATECOMPLETE" : z3452.DateComplete = Children(i).Data
                                Case "DATEAPPROVAL" : z3452.DateApproval = Children(i).Data
                                Case "DATECANCEL" : z3452.DateCancel = Children(i).Data
                                Case "CHECKCOMPLETE" : z3452.CheckComplete = Children(i).Data
                                Case "SHIPPINGWORKORDER" : z3452.ShippingWorkOrder = Children(i).Data
                                Case "SHIPPINGWORKORDERSEQ" : z3452.ShippingWorkOrderSeq = Children(i).Data
                                Case "ORDERNO" : z3452.OrderNo = Children(i).Data
                                Case "ORDERNOSEQ" : z3452.OrderNoSeq = Children(i).Data
                                Case "REMARK" : z3452.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K3452_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K3452_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z3452 As T3452_AREA, Job As String, CheckClear As Boolean, AUTOKEY As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K3452_MOVE = False

        Try
            If READ_PFK3452(AUTOKEY) = True Then
                z3452 = D3452
                K3452_MOVE = True
            Else
                If CheckClear = True Then z3452 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3452")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "AUTOKEY" : z3452.Autokey = Children(i).Code
                                Case "TIVE30" : z3452.TIVE30 = Children(i).Code
                                Case "DTIV30" : z3452.DTIV30 = Children(i).Code
                                Case "DTEX30" : z3452.DTEX30 = Children(i).Code
                                Case "FACTORDERNO" : z3452.FactOrderNo = Children(i).Code
                                Case "FACTORDERSEQ" : z3452.FactOrderSeq = Children(i).Code
                                Case "PACKINGBATCH" : z3452.PackingBatch = Children(i).Code
                                Case "PKO" : z3452.PKO = Children(i).Code
                                Case "SESITE" : z3452.seSite = Children(i).Code
                                Case "CDSITE" : z3452.cdSite = Children(i).Code
                                Case "SEDEPARTMENT" : z3452.seDepartment = Children(i).Code
                                Case "CDDEPARTMENT" : z3452.cdDepartment = Children(i).Code
                                Case "CUSTOMERSUPPLIER" : z3452.CustomerSupplier = Children(i).Code
                                Case "DSEQ" : z3452.Dseq = Children(i).Code
                                Case "CHECKRELATIONTYPE" : z3452.CheckRelationType = Children(i).Code
                                Case "SHOESCODE" : z3452.ShoesCode = Children(i).Code
                                Case "SPECIFICATION" : z3452.Specification = Children(i).Code
                                Case "WIDTH" : z3452.Width = Children(i).Code
                                Case "HEIGHT" : z3452.Height = Children(i).Code
                                Case "SIZENO" : z3452.SizeNo = Children(i).Code
                                Case "SIZENAME" : z3452.SizeName = Children(i).Code
                                Case "COLORNAME" : z3452.ColorName = Children(i).Code
                                Case "SEORIGIN" : z3452.seOrigin = Children(i).Code
                                Case "CDORIGIN" : z3452.cdOrigin = Children(i).Code
                                Case "MATERIALCHECK" : z3452.MaterialCheck = Children(i).Code
                                Case "SEUNITPRICE" : z3452.seUnitPrice = Children(i).Code
                                Case "CDUNITPRICE" : z3452.cdUnitPrice = Children(i).Code
                                Case "SETAX" : z3452.seTax = Children(i).Code
                                Case "CDTAX" : z3452.cdTax = Children(i).Code
                                Case "SEUNITMATERIAL" : z3452.seUnitMaterial = Children(i).Code
                                Case "CDUNITMATERIAL" : z3452.cdUnitMaterial = Children(i).Code
                                Case "SEUNITPACKING" : z3452.seUnitPacking = Children(i).Code
                                Case "CDUNITPACKING" : z3452.cdUnitPacking = Children(i).Code
                                Case "UNITBASECHECK" : z3452.UnitBaseCheck = Children(i).Code
                                Case "QTYBASIC" : z3452.QtyBasic = Children(i).Code
                                Case "PRICEPURCHASING" : z3452.PricePurchasing = Children(i).Code
                                Case "PRICEMARKET" : z3452.PriceMarket = Children(i).Code
                                Case "PRICEEXCHANGE" : z3452.PriceExchange = Children(i).Code
                                Case "DATEEXCHANGE" : z3452.DateExchange = Children(i).Code
                                Case "PRICEPURCHASINGEX" : z3452.PricePurchasingEX = Children(i).Code
                                Case "PRICEMARKETEX" : z3452.PriceMarketEX = Children(i).Code
                                Case "PRICEPURCHASINGVND" : z3452.PricePurchasingVND = Children(i).Code
                                Case "PRICEMARKETVND" : z3452.PriceMarketVND = Children(i).Code
                                Case "AMOUNTPURCHASINGEX" : z3452.AmountPurchasingEX = Children(i).Code
                                Case "AMOUNTPURCHASINGVND" : z3452.AmountPurchasingVND = Children(i).Code
                                Case "AMOUNTTAXEX" : z3452.AmountTaxEX = Children(i).Code
                                Case "AMOUNTTAXVND" : z3452.AmountTaxVND = Children(i).Code
                                Case "QTYPURCHASING" : z3452.QtyPurchasing = Children(i).Code
                                Case "PACKPURCHASING" : z3452.PackPurchasing = Children(i).Code
                                Case "QTYWAREHOUSE" : z3452.QtyWarehouse = Children(i).Code
                                Case "PACKWAREHOUSE" : z3452.PackWarehouse = Children(i).Code
                                Case "QTYPACKING" : z3452.QtyPacking = Children(i).Code
                                Case "PACKPACKING" : z3452.PackPacking = Children(i).Code
                                Case "QTYINBOUND" : z3452.QtyInbound = Children(i).Code
                                Case "PACKINBOUND" : z3452.PackInbound = Children(i).Code
                                Case "QTYOUTBOUND" : z3452.QtyOutbound = Children(i).Code
                                Case "PACKOUTBOUND" : z3452.PackOutbound = Children(i).Code
                                Case "AMOUNTINBOUNDEX" : z3452.AmountInBoundEX = Children(i).Code
                                Case "AMOUNTINBOUNDVND" : z3452.AmountInBoundVND = Children(i).Code
                                Case "DATEDELIVERY" : z3452.DateDelivery = Children(i).Code
                                Case "DATESTART" : z3452.DateStart = Children(i).Code
                                Case "DATEFINISH" : z3452.DateFinish = Children(i).Code
                                Case "CHECKPURCHASING" : z3452.CheckPurchasing = Children(i).Code
                                Case "DATEACCEPT" : z3452.DateAccept = Children(i).Code
                                Case "DATEPOSTED" : z3452.DatePosted = Children(i).Code
                                Case "ISPOSTED" : z3452.IsPosted = Children(i).Code
                                Case "DATECOMPLETE" : z3452.DateComplete = Children(i).Code
                                Case "DATEAPPROVAL" : z3452.DateApproval = Children(i).Code
                                Case "DATECANCEL" : z3452.DateCancel = Children(i).Code
                                Case "CHECKCOMPLETE" : z3452.CheckComplete = Children(i).Code
                                Case "SHIPPINGWORKORDER" : z3452.ShippingWorkOrder = Children(i).Code
                                Case "SHIPPINGWORKORDERSEQ" : z3452.ShippingWorkOrderSeq = Children(i).Code
                                Case "ORDERNO" : z3452.OrderNo = Children(i).Code
                                Case "ORDERNOSEQ" : z3452.OrderNoSeq = Children(i).Code
                                Case "REMARK" : z3452.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "AUTOKEY" : z3452.Autokey = Children(i).Data
                                Case "TIVE30" : z3452.TIVE30 = Children(i).Data
                                Case "DTIV30" : z3452.DTIV30 = Children(i).Data
                                Case "DTEX30" : z3452.DTEX30 = Children(i).Data
                                Case "FACTORDERNO" : z3452.FactOrderNo = Children(i).Data
                                Case "FACTORDERSEQ" : z3452.FactOrderSeq = Children(i).Data
                                Case "PACKINGBATCH" : z3452.PackingBatch = Children(i).Data
                                Case "PKO" : z3452.PKO = Children(i).Data
                                Case "SESITE" : z3452.seSite = Children(i).Data
                                Case "CDSITE" : z3452.cdSite = Children(i).Data
                                Case "SEDEPARTMENT" : z3452.seDepartment = Children(i).Data
                                Case "CDDEPARTMENT" : z3452.cdDepartment = Children(i).Data
                                Case "CUSTOMERSUPPLIER" : z3452.CustomerSupplier = Children(i).Data
                                Case "DSEQ" : z3452.Dseq = Children(i).Data
                                Case "CHECKRELATIONTYPE" : z3452.CheckRelationType = Children(i).Data
                                Case "SHOESCODE" : z3452.ShoesCode = Children(i).Data
                                Case "SPECIFICATION" : z3452.Specification = Children(i).Data
                                Case "WIDTH" : z3452.Width = Children(i).Data
                                Case "HEIGHT" : z3452.Height = Children(i).Data
                                Case "SIZENO" : z3452.SizeNo = Children(i).Data
                                Case "SIZENAME" : z3452.SizeName = Children(i).Data
                                Case "COLORNAME" : z3452.ColorName = Children(i).Data
                                Case "SEORIGIN" : z3452.seOrigin = Children(i).Data
                                Case "CDORIGIN" : z3452.cdOrigin = Children(i).Data
                                Case "MATERIALCHECK" : z3452.MaterialCheck = Children(i).Data
                                Case "SEUNITPRICE" : z3452.seUnitPrice = Children(i).Data
                                Case "CDUNITPRICE" : z3452.cdUnitPrice = Children(i).Data
                                Case "SETAX" : z3452.seTax = Children(i).Data
                                Case "CDTAX" : z3452.cdTax = Children(i).Data
                                Case "SEUNITMATERIAL" : z3452.seUnitMaterial = Children(i).Data
                                Case "CDUNITMATERIAL" : z3452.cdUnitMaterial = Children(i).Data
                                Case "SEUNITPACKING" : z3452.seUnitPacking = Children(i).Data
                                Case "CDUNITPACKING" : z3452.cdUnitPacking = Children(i).Data
                                Case "UNITBASECHECK" : z3452.UnitBaseCheck = Children(i).Data
                                Case "QTYBASIC" : z3452.QtyBasic = Children(i).Data
                                Case "PRICEPURCHASING" : z3452.PricePurchasing = Children(i).Data
                                Case "PRICEMARKET" : z3452.PriceMarket = Children(i).Data
                                Case "PRICEEXCHANGE" : z3452.PriceExchange = Children(i).Data
                                Case "DATEEXCHANGE" : z3452.DateExchange = Children(i).Data
                                Case "PRICEPURCHASINGEX" : z3452.PricePurchasingEX = Children(i).Data
                                Case "PRICEMARKETEX" : z3452.PriceMarketEX = Children(i).Data
                                Case "PRICEPURCHASINGVND" : z3452.PricePurchasingVND = Children(i).Data
                                Case "PRICEMARKETVND" : z3452.PriceMarketVND = Children(i).Data
                                Case "AMOUNTPURCHASINGEX" : z3452.AmountPurchasingEX = Children(i).Data
                                Case "AMOUNTPURCHASINGVND" : z3452.AmountPurchasingVND = Children(i).Data
                                Case "AMOUNTTAXEX" : z3452.AmountTaxEX = Children(i).Data
                                Case "AMOUNTTAXVND" : z3452.AmountTaxVND = Children(i).Data
                                Case "QTYPURCHASING" : z3452.QtyPurchasing = Children(i).Data
                                Case "PACKPURCHASING" : z3452.PackPurchasing = Children(i).Data
                                Case "QTYWAREHOUSE" : z3452.QtyWarehouse = Children(i).Data
                                Case "PACKWAREHOUSE" : z3452.PackWarehouse = Children(i).Data
                                Case "QTYPACKING" : z3452.QtyPacking = Children(i).Data
                                Case "PACKPACKING" : z3452.PackPacking = Children(i).Data
                                Case "QTYINBOUND" : z3452.QtyInbound = Children(i).Data
                                Case "PACKINBOUND" : z3452.PackInbound = Children(i).Data
                                Case "QTYOUTBOUND" : z3452.QtyOutbound = Children(i).Data
                                Case "PACKOUTBOUND" : z3452.PackOutbound = Children(i).Data
                                Case "AMOUNTINBOUNDEX" : z3452.AmountInBoundEX = Children(i).Data
                                Case "AMOUNTINBOUNDVND" : z3452.AmountInBoundVND = Children(i).Data
                                Case "DATEDELIVERY" : z3452.DateDelivery = Children(i).Data
                                Case "DATESTART" : z3452.DateStart = Children(i).Data
                                Case "DATEFINISH" : z3452.DateFinish = Children(i).Data
                                Case "CHECKPURCHASING" : z3452.CheckPurchasing = Children(i).Data
                                Case "DATEACCEPT" : z3452.DateAccept = Children(i).Data
                                Case "DATEPOSTED" : z3452.DatePosted = Children(i).Data
                                Case "ISPOSTED" : z3452.IsPosted = Children(i).Data
                                Case "DATECOMPLETE" : z3452.DateComplete = Children(i).Data
                                Case "DATEAPPROVAL" : z3452.DateApproval = Children(i).Data
                                Case "DATECANCEL" : z3452.DateCancel = Children(i).Data
                                Case "CHECKCOMPLETE" : z3452.CheckComplete = Children(i).Data
                                Case "SHIPPINGWORKORDER" : z3452.ShippingWorkOrder = Children(i).Data
                                Case "SHIPPINGWORKORDERSEQ" : z3452.ShippingWorkOrderSeq = Children(i).Data
                                Case "ORDERNO" : z3452.OrderNo = Children(i).Data
                                Case "ORDERNOSEQ" : z3452.OrderNoSeq = Children(i).Data
                                Case "REMARK" : z3452.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K3452_MOVE", vbCritical)
        End Try
    End Function

End Module
