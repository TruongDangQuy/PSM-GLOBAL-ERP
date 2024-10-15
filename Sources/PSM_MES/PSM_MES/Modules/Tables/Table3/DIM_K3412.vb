'=========================================================================================================================================================
'   TABLE : (PFK3412)
'
'      WORKER : PSM GLOBAL ., LTD
'       WORK DATE : 2019 NEW
'       DEVELOPER    : MRNLV
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K3412

    Structure T3412_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public PurchasingOrderNo As String  '			char(9)		*
        Public PurchasingOrderSeq As Double  '			decimal		*
        Public seSite As String  '			char(3)
        Public cdSite As String  '			char(3)
        Public seDepartment As String  '			char(3)
        Public cdDepartment As String  '			char(3)
        Public seFactory As String  '			char(3)
        Public cdFactory As String  '			char(3)
        Public CustomerSupplier As String  '			char(6)
        Public Dseq As Double  '			decimal
        Public AutokeyK3011 As Double  '			decimal
        Public CheckRelationType As String  '			char(1)
        Public MaterialCode As String  '			char(6)
        Public Specification As String  '			nvarchar(50)
        Public Width As String  '			nvarchar(50)
        Public Height As String  '			nvarchar(50)
        Public SizeNo As String  '			char(2)
        Public SizeName As String  '			nvarchar(100)
        Public ColorCode As String  '			char(6)
        Public ColorName As String  '			nvarchar(500)
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
        Public PriceExchangeAP As Double  '			decimal
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
        Public seTax1 As String  '			char(3)
        Public cdTax1 As String  '			char(3)
        Public PerTax1 As Double  '			decimal
        Public AmountTax1EX As Double  '			decimal
        Public AmountTax1 As Double  '			decimal
        Public seTax2 As String  '			char(3)
        Public cdTax2 As String  '			char(3)
        Public PerTax2 As Double  '			decimal
        Public AmountTax2EX As Double  '			decimal
        Public AmountTax2 As Double  '			decimal
        Public seTax3 As String  '			char(3)
        Public cdTax3 As String  '			char(3)
        Public PerTax3 As Double  '			decimal
        Public AmountTax3EX As Double  '			decimal
        Public AmountTax3 As Double  '			decimal
        Public QtyBooking As Double  '			decimal
        Public QtyPurchasingNet As Double  '			decimal
        Public QtyPurchasingMOQ As Double  '			decimal
        Public QtyPurchasing As Double  '			decimal
        Public PackPurchasing As Double  '			decimal
        Public AmountPSC As Double  '			decimal
        Public AmountEX As Double  '			decimal
        Public AmountVND As Double  '			decimal
        Public AmountNoVATEX As Double  '			decimal
        Public AmountNoVATVND As Double  '			decimal
        Public AmountTotalEX As Double  '			decimal
        Public AmountTotalVND As Double  '			decimal
        Public TotalQtyPurchasing As Double  '			decimal
        Public TotalPackPurchasing As Double  '			decimal
        Public QtyWarehouse As Double  '			decimal
        Public PackWarehouse As Double  '			decimal
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
        Public PurchasingRequestNo As String  '			nvarchar(20)
        Public PurchasingRequestSeq As Double  '			decimal
        Public OrderNo As String  '			char(9)
        Public OrderNoSeq As String  '			char(3)
        Public PurchasingOrderNo_Bf As String  '			char(9)
        Public PurchasingOrderSeq_Bf As Double  '			decimal
        Public Remark As String  '			nvarchar(500)
        Public TimeInsert As String  '			char(14)
        Public TimeUpdate As String  '			char(14)
        Public DateInsert As String  '			char(8)
        Public DateUpdate As String  '			char(8)
        Public InchargeInsert As String  '			char(8)
        Public InchargeUpdate As String  '			char(8)
        Public PriceAPurchasing As Double  '			decimal
        Public cdUnitMaterialA As String  '			char(3)
        Public cdUnitPriceA As String  '			nvarchar(20)
        Public QtyAPurchasing As Double  '			decimal
        Public QtyATotal As Double  '			decimal
        Public AmtAPurchasing As Double  '			decimal
        Public AmtATotal As Double  '			decimal
        Public InvoiceNo1 As String  '			nvarchar(50)
        Public InvoiceNo2 As String  '			nvarchar(50)
        Public InvoiceNo3 As String  '			nvarchar(50)
        Public InvoiceNo4 As String  '			nvarchar(50)
        Public InvoiceNo5 As String  '			nvarchar(50)
        Public InvoiceNo6 As String  '			nvarchar(50)
        Public InvoiceNo7 As String  '			nvarchar(50)
        Public InvoiceNo8 As String  '			nvarchar(50)
        Public InvoiceNo9 As String  '			nvarchar(50)
        Public InvoiceNo10 As String  '			nvarchar(50)

        Public DateArrive1 As String  '			char(8)
        Public DateArrive2 As String  '			char(8)
        Public DateArrive3 As String  '			char(8)
        Public DateArrive4 As String  '			char(8)
        Public DateArrive5 As String  '			char(8)
        Public DateArrive6 As String  '			char(8)
        Public DateArrive7 As String  '			char(8)
        Public DateArrive8 As String  '			char(8)
        Public DateArrive9 As String  '			char(8)
        Public DateArrive10 As String  '			char(8)

        Public QtyAArrive1 As Double  '			decimal
        Public QtyAArrive2 As Double  '			decimal
        Public QtyAArrive3 As Double  '			decimal
        Public QtyAArrive4 As Double  '			decimal
        Public QtyAArrive5 As Double  '			decimal
        Public QtyAArrive6 As Double  '			decimal
        Public QtyAArrive7 As Double  '			decimal
        Public QtyAArrive8 As Double  '			decimal
        Public QtyAArrive9 As Double  '			decimal
        Public QtyAArrive10 As Double  '			decimal

        Public InchargeInvoice As String  '			char(8)
        Public APLName As String  '			nvarchar(200)
        Public AInvoice As String  '			nvarchar(200)
        Public ARemark As String  '			nvarchar(200)
        '=========================================================================================================================================================
    End Structure

    Public D3412 As T3412_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK3412(PURCHASINGORDERNO As String, PURCHASINGORDERSEQ As Double) As Boolean
        READ_PFK3412 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK3412 "
            SQL = SQL & " WHERE K3412_PurchasingOrderNo		 = '" & PurchasingOrderNo & "' "
            SQL = SQL & "   AND K3412_PurchasingOrderSeq		 =  " & PurchasingOrderSeq & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D3412_CLEAR() : GoTo SKIP_READ_PFK3412

            Call K3412_MOVE(rd)
            READ_PFK3412 = True

SKIP_READ_PFK3412:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK3412", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK3412(PURCHASINGORDERNO As String, PURCHASINGORDERSEQ As Double, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK3412 "
            SQL = SQL & " WHERE K3412_PurchasingOrderNo		 = '" & PurchasingOrderNo & "' "
            SQL = SQL & "   AND K3412_PurchasingOrderSeq		 =  " & PurchasingOrderSeq & "  "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK3412", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK3412(z3412 As T3412_AREA) As Boolean
        WRITE_PFK3412 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z3412)

            SQL = " INSERT INTO PFK3412 "
            SQL = SQL & " ( "
            SQL = SQL & " K3412_PurchasingOrderNo,"
            SQL = SQL & " K3412_PurchasingOrderSeq,"
            SQL = SQL & " K3412_seSite,"
            SQL = SQL & " K3412_cdSite,"
            SQL = SQL & " K3412_seDepartment,"
            SQL = SQL & " K3412_cdDepartment,"
            SQL = SQL & " K3412_seFactory,"
            SQL = SQL & " K3412_cdFactory,"
            SQL = SQL & " K3412_CustomerSupplier,"
            SQL = SQL & " K3412_Dseq,"
            SQL = SQL & " K3412_AutokeyK3011,"
            SQL = SQL & " K3412_CheckRelationType,"
            SQL = SQL & " K3412_MaterialCode,"
            SQL = SQL & " K3412_Specification,"
            SQL = SQL & " K3412_Width,"
            SQL = SQL & " K3412_Height,"
            SQL = SQL & " K3412_SizeNo,"
            SQL = SQL & " K3412_SizeName,"
            SQL = SQL & " K3412_ColorCode,"
            SQL = SQL & " K3412_ColorName,"
            SQL = SQL & " K3412_seOrigin,"
            SQL = SQL & " K3412_cdOrigin,"
            SQL = SQL & " K3412_MaterialCheck,"
            SQL = SQL & " K3412_seUnitPrice,"
            SQL = SQL & " K3412_cdUnitPrice,"
            SQL = SQL & " K3412_seTax,"
            SQL = SQL & " K3412_cdTax,"
            SQL = SQL & " K3412_seUnitMaterial,"
            SQL = SQL & " K3412_cdUnitMaterial,"
            SQL = SQL & " K3412_seUnitPacking,"
            SQL = SQL & " K3412_cdUnitPacking,"
            SQL = SQL & " K3412_UnitBaseCheck,"
            SQL = SQL & " K3412_QtyBasic,"
            SQL = SQL & " K3412_PricePurchasing,"
            SQL = SQL & " K3412_PriceMarket,"
            SQL = SQL & " K3412_PriceExchangeAP,"
            SQL = SQL & " K3412_PriceExchange,"
            SQL = SQL & " K3412_DateExchange,"
            SQL = SQL & " K3412_PricePurchasingEX,"
            SQL = SQL & " K3412_PriceMarketEX,"
            SQL = SQL & " K3412_PricePurchasingVND,"
            SQL = SQL & " K3412_PriceMarketVND,"
            SQL = SQL & " K3412_AmountPurchasingEX,"
            SQL = SQL & " K3412_AmountPurchasingVND,"
            SQL = SQL & " K3412_AmountTaxEX,"
            SQL = SQL & " K3412_AmountTaxVND,"
            SQL = SQL & " K3412_seTax1,"
            SQL = SQL & " K3412_cdTax1,"
            SQL = SQL & " K3412_PerTax1,"
            SQL = SQL & " K3412_AmountTax1EX,"
            SQL = SQL & " K3412_AmountTax1,"
            SQL = SQL & " K3412_seTax2,"
            SQL = SQL & " K3412_cdTax2,"
            SQL = SQL & " K3412_PerTax2,"
            SQL = SQL & " K3412_AmountTax2EX,"
            SQL = SQL & " K3412_AmountTax2,"
            SQL = SQL & " K3412_seTax3,"
            SQL = SQL & " K3412_cdTax3,"
            SQL = SQL & " K3412_PerTax3,"
            SQL = SQL & " K3412_AmountTax3EX,"
            SQL = SQL & " K3412_AmountTax3,"
            SQL = SQL & " K3412_QtyBooking,"
            SQL = SQL & " K3412_QtyPurchasingNet,"
            SQL = SQL & " K3412_QtyPurchasingMOQ,"
            SQL = SQL & " K3412_QtyPurchasing,"
            SQL = SQL & " K3412_PackPurchasing,"
            SQL = SQL & " K3412_AmountPSC,"
            SQL = SQL & " K3412_AmountEX,"
            SQL = SQL & " K3412_AmountVND,"
            SQL = SQL & " K3412_AmountNoVATEX,"
            SQL = SQL & " K3412_AmountNoVATVND,"
            SQL = SQL & " K3412_AmountTotalEX,"
            SQL = SQL & " K3412_AmountTotalVND,"
            SQL = SQL & " K3412_TotalQtyPurchasing,"
            SQL = SQL & " K3412_TotalPackPurchasing,"
            SQL = SQL & " K3412_QtyWarehouse,"
            SQL = SQL & " K3412_PackWarehouse,"
            SQL = SQL & " K3412_DateDelivery,"
            SQL = SQL & " K3412_DateStart,"
            SQL = SQL & " K3412_DateFinish,"
            SQL = SQL & " K3412_CheckPurchasing,"
            SQL = SQL & " K3412_DateAccept,"
            SQL = SQL & " K3412_DatePosted,"
            SQL = SQL & " K3412_IsPosted,"
            SQL = SQL & " K3412_DateComplete,"
            SQL = SQL & " K3412_DateApproval,"
            SQL = SQL & " K3412_DateCancel,"
            SQL = SQL & " K3412_CheckComplete,"
            SQL = SQL & " K3412_PurchasingRequestNo,"
            SQL = SQL & " K3412_PurchasingRequestSeq,"
            SQL = SQL & " K3412_OrderNo,"
            SQL = SQL & " K3412_OrderNoSeq,"
            SQL = SQL & " K3412_PurchasingOrderNo_Bf,"
            SQL = SQL & " K3412_PurchasingOrderSeq_Bf,"
            SQL = SQL & " K3412_Remark,"
            SQL = SQL & " K3412_TimeInsert,"
            SQL = SQL & " K3412_TimeUpdate,"
            SQL = SQL & " K3412_DateInsert,"
            SQL = SQL & " K3412_DateUpdate,"
            SQL = SQL & " K3412_InchargeInsert,"
            SQL = SQL & " K3412_InchargeUpdate,"
            SQL = SQL & " K3412_PriceAPurchasing,"
            SQL = SQL & " K3412_cdUnitMaterialA,"
            SQL = SQL & " K3412_cdUnitPriceA,"
            SQL = SQL & " K3412_QtyAPurchasing,"
            SQL = SQL & " K3412_QtyATotal,"
            SQL = SQL & " K3412_AmtAPurchasing,"
            SQL = SQL & " K3412_AmtATotal,"
            SQL = SQL & " K3412_InvoiceNo1,"
            SQL = SQL & " K3412_InvoiceNo2,"
            SQL = SQL & " K3412_InvoiceNo3,"
            SQL = SQL & " K3412_InvoiceNo4,"
            SQL = SQL & " K3412_InvoiceNo5,"
            SQL = SQL & " K3412_InvoiceNo6,"
            SQL = SQL & " K3412_InvoiceNo7,"
            SQL = SQL & " K3412_InvoiceNo8,"
            SQL = SQL & " K3412_InvoiceNo9,"
            SQL = SQL & " K3412_InvoiceNo10,"

            SQL = SQL & " K3412_DateArrive1,"
            SQL = SQL & " K3412_DateArrive2,"
            SQL = SQL & " K3412_DateArrive3,"
            SQL = SQL & " K3412_DateArrive4,"
            SQL = SQL & " K3412_DateArrive5,"
            SQL = SQL & " K3412_DateArrive6,"
            SQL = SQL & " K3412_DateArrive7,"
            SQL = SQL & " K3412_DateArrive8,"
            SQL = SQL & " K3412_DateArrive9,"
            SQL = SQL & " K3412_DateArrive10,"

            SQL = SQL & " K3412_QtyAArrive1,"
            SQL = SQL & " K3412_QtyAArrive2,"
            SQL = SQL & " K3412_QtyAArrive3,"
            SQL = SQL & " K3412_QtyAArrive4,"
            SQL = SQL & " K3412_QtyAArrive5,"
            SQL = SQL & " K3412_QtyAArrive6,"
            SQL = SQL & " K3412_QtyAArrive7,"
            SQL = SQL & " K3412_QtyAArrive8,"
            SQL = SQL & " K3412_QtyAArrive9,"
            SQL = SQL & " K3412_QtyAArrive10,"

            SQL = SQL & " K3412_InchargeInvoice,"
            SQL = SQL & " K3412_APLName,"
            SQL = SQL & " K3412_AInvoice,"
            SQL = SQL & " K3412_ARemark "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z3412.PurchasingOrderNo) & "', "
            SQL = SQL & "   " & FormatSQL(z3412.PurchasingOrderSeq) & ", "
            SQL = SQL & "  N'" & FormatSQL(z3412.seSite) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3412.cdSite) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3412.seDepartment) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3412.cdDepartment) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3412.seFactory) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3412.cdFactory) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3412.CustomerSupplier) & "', "
            SQL = SQL & "   " & FormatSQL(z3412.Dseq) & ", "
            SQL = SQL & "   " & FormatSQL(z3412.AutokeyK3011) & ", "
            SQL = SQL & "  N'" & FormatSQL(z3412.CheckRelationType) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3412.MaterialCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3412.Specification) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3412.Width) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3412.Height) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3412.SizeNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3412.SizeName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3412.ColorCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3412.ColorName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3412.seOrigin) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3412.cdOrigin) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3412.MaterialCheck) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3412.seUnitPrice) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3412.cdUnitPrice) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3412.seTax) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3412.cdTax) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3412.seUnitMaterial) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3412.cdUnitMaterial) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3412.seUnitPacking) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3412.cdUnitPacking) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3412.UnitBaseCheck) & "', "
            SQL = SQL & "   " & FormatSQL(z3412.QtyBasic) & ", "
            SQL = SQL & "   " & FormatSQL(z3412.PricePurchasing) & ", "
            SQL = SQL & "   " & FormatSQL(z3412.PriceMarket) & ", "
            SQL = SQL & "   " & FormatSQL(z3412.PriceExchangeAP) & ", "
            SQL = SQL & "   " & FormatSQL(z3412.PriceExchange) & ", "
            SQL = SQL & "  N'" & FormatSQL(z3412.DateExchange) & "', "
            SQL = SQL & "   " & FormatSQL(z3412.PricePurchasingEX) & ", "
            SQL = SQL & "   " & FormatSQL(z3412.PriceMarketEX) & ", "
            SQL = SQL & "   " & FormatSQL(z3412.PricePurchasingVND) & ", "
            SQL = SQL & "   " & FormatSQL(z3412.PriceMarketVND) & ", "
            SQL = SQL & "   " & FormatSQL(z3412.AmountPurchasingEX) & ", "
            SQL = SQL & "   " & FormatSQL(z3412.AmountPurchasingVND) & ", "
            SQL = SQL & "   " & FormatSQL(z3412.AmountTaxEX) & ", "
            SQL = SQL & "   " & FormatSQL(z3412.AmountTaxVND) & ", "
            SQL = SQL & "  N'" & FormatSQL(z3412.seTax1) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3412.cdTax1) & "', "
            SQL = SQL & "   " & FormatSQL(z3412.PerTax1) & ", "
            SQL = SQL & "   " & FormatSQL(z3412.AmountTax1EX) & ", "
            SQL = SQL & "   " & FormatSQL(z3412.AmountTax1) & ", "
            SQL = SQL & "  N'" & FormatSQL(z3412.seTax2) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3412.cdTax2) & "', "
            SQL = SQL & "   " & FormatSQL(z3412.PerTax2) & ", "
            SQL = SQL & "   " & FormatSQL(z3412.AmountTax2EX) & ", "
            SQL = SQL & "   " & FormatSQL(z3412.AmountTax2) & ", "
            SQL = SQL & "  N'" & FormatSQL(z3412.seTax3) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3412.cdTax3) & "', "
            SQL = SQL & "   " & FormatSQL(z3412.PerTax3) & ", "
            SQL = SQL & "   " & FormatSQL(z3412.AmountTax3EX) & ", "
            SQL = SQL & "   " & FormatSQL(z3412.AmountTax3) & ", "
            SQL = SQL & "   " & FormatSQL(z3412.QtyBooking) & ", "
            SQL = SQL & "   " & FormatSQL(z3412.QtyPurchasingNet) & ", "
            SQL = SQL & "   " & FormatSQL(z3412.QtyPurchasingMOQ) & ", "
            SQL = SQL & "   " & FormatSQL(z3412.QtyPurchasing) & ", "
            SQL = SQL & "   " & FormatSQL(z3412.PackPurchasing) & ", "
            SQL = SQL & "   " & FormatSQL(z3412.AmountPSC) & ", "
            SQL = SQL & "   " & FormatSQL(z3412.AmountEX) & ", "
            SQL = SQL & "   " & FormatSQL(z3412.AmountVND) & ", "
            SQL = SQL & "   " & FormatSQL(z3412.AmountNoVATEX) & ", "
            SQL = SQL & "   " & FormatSQL(z3412.AmountNoVATVND) & ", "
            SQL = SQL & "   " & FormatSQL(z3412.AmountTotalEX) & ", "
            SQL = SQL & "   " & FormatSQL(z3412.AmountTotalVND) & ", "
            SQL = SQL & "   " & FormatSQL(z3412.TotalQtyPurchasing) & ", "
            SQL = SQL & "   " & FormatSQL(z3412.TotalPackPurchasing) & ", "
            SQL = SQL & "   " & FormatSQL(z3412.QtyWarehouse) & ", "
            SQL = SQL & "   " & FormatSQL(z3412.PackWarehouse) & ", "
            SQL = SQL & "  N'" & FormatSQL(z3412.DateDelivery) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3412.DateStart) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3412.DateFinish) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3412.CheckPurchasing) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3412.DateAccept) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3412.DatePosted) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3412.IsPosted) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3412.DateComplete) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3412.DateApproval) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3412.DateCancel) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3412.CheckComplete) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3412.PurchasingRequestNo) & "', "
            SQL = SQL & "   " & FormatSQL(z3412.PurchasingRequestSeq) & ", "
            SQL = SQL & "  N'" & FormatSQL(z3412.OrderNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3412.OrderNoSeq) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3412.PurchasingOrderNo_Bf) & "', "
            SQL = SQL & "   " & FormatSQL(z3412.PurchasingOrderSeq_Bf) & ", "
            SQL = SQL & "  N'" & FormatSQL(z3412.Remark) & "', "
            SQL = SQL & "  N'" & FormatSQL(PUB.TIME) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3412.TimeUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(PUB.DAT) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3412.DateUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(PUB.SAW) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3412.InchargeUpdate) & "', "
            SQL = SQL & "   " & FormatSQL(z3412.PriceAPurchasing) & ", "
            SQL = SQL & "  N'" & FormatSQL(z3412.cdUnitMaterialA) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3412.cdUnitPriceA) & "', "
            SQL = SQL & "   " & FormatSQL(z3412.QtyAPurchasing) & ", "
            SQL = SQL & "   " & FormatSQL(z3412.QtyATotal) & ", "
            SQL = SQL & "   " & FormatSQL(z3412.AmtAPurchasing) & ", "
            SQL = SQL & "   " & FormatSQL(z3412.AmtATotal) & ", "
            SQL = SQL & "  N'" & FormatSQL(z3412.InvoiceNo1) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3412.InvoiceNo2) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3412.InvoiceNo3) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3412.InvoiceNo4) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3412.InvoiceNo5) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3412.InvoiceNo6) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3412.InvoiceNo7) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3412.InvoiceNo8) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3412.InvoiceNo9) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3412.InvoiceNo10) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3412.DateArrive1) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3412.DateArrive2) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3412.DateArrive3) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3412.DateArrive4) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3412.DateArrive5) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3412.DateArrive6) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3412.DateArrive7) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3412.DateArrive8) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3412.DateArrive9) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3412.DateArrive10) & "', "
            SQL = SQL & "   " & FormatSQL(z3412.QtyAArrive1) & ", "
            SQL = SQL & "   " & FormatSQL(z3412.QtyAArrive2) & ", "
            SQL = SQL & "   " & FormatSQL(z3412.QtyAArrive3) & ", "
            SQL = SQL & "   " & FormatSQL(z3412.QtyAArrive4) & ", "
            SQL = SQL & "   " & FormatSQL(z3412.QtyAArrive5) & ", "
            SQL = SQL & "   " & FormatSQL(z3412.QtyAArrive6) & ", "
            SQL = SQL & "   " & FormatSQL(z3412.QtyAArrive7) & ", "
            SQL = SQL & "   " & FormatSQL(z3412.QtyAArrive8) & ", "
            SQL = SQL & "   " & FormatSQL(z3412.QtyAArrive9) & ", "
            SQL = SQL & "   " & FormatSQL(z3412.QtyAArrive10) & ", "
            SQL = SQL & "  N'" & FormatSQL(z3412.InchargeInvoice) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3412.APLName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3412.AInvoice) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3412.ARemark) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK3412 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK3412", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK3412(z3412 As T3412_AREA) As Boolean
        REWRITE_PFK3412 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z3412)

            SQL = " UPDATE PFK3412 SET "
            SQL = SQL & "    K3412_seSite      = N'" & FormatSQL(z3412.seSite) & "', "
            SQL = SQL & "    K3412_cdSite      = N'" & FormatSQL(z3412.cdSite) & "', "
            SQL = SQL & "    K3412_seDepartment      = N'" & FormatSQL(z3412.seDepartment) & "', "
            SQL = SQL & "    K3412_cdDepartment      = N'" & FormatSQL(z3412.cdDepartment) & "', "
            SQL = SQL & "    K3412_seFactory      = N'" & FormatSQL(z3412.seFactory) & "', "
            SQL = SQL & "    K3412_cdFactory      = N'" & FormatSQL(z3412.cdFactory) & "', "
            SQL = SQL & "    K3412_CustomerSupplier      = N'" & FormatSQL(z3412.CustomerSupplier) & "', "
            SQL = SQL & "    K3412_Dseq      =  " & FormatSQL(z3412.Dseq) & ", "
            SQL = SQL & "    K3412_AutokeyK3011      =  " & FormatSQL(z3412.AutokeyK3011) & ", "
            SQL = SQL & "    K3412_CheckRelationType      = N'" & FormatSQL(z3412.CheckRelationType) & "', "
            SQL = SQL & "    K3412_MaterialCode      = N'" & FormatSQL(z3412.MaterialCode) & "', "
            SQL = SQL & "    K3412_Specification      = N'" & FormatSQL(z3412.Specification) & "', "
            SQL = SQL & "    K3412_Width      = N'" & FormatSQL(z3412.Width) & "', "
            SQL = SQL & "    K3412_Height      = N'" & FormatSQL(z3412.Height) & "', "
            SQL = SQL & "    K3412_SizeNo      = N'" & FormatSQL(z3412.SizeNo) & "', "
            SQL = SQL & "    K3412_SizeName      = N'" & FormatSQL(z3412.SizeName) & "', "
            SQL = SQL & "    K3412_ColorCode      = N'" & FormatSQL(z3412.ColorCode) & "', "
            SQL = SQL & "    K3412_ColorName      = N'" & FormatSQL(z3412.ColorName) & "', "
            SQL = SQL & "    K3412_seOrigin      = N'" & FormatSQL(z3412.seOrigin) & "', "
            SQL = SQL & "    K3412_cdOrigin      = N'" & FormatSQL(z3412.cdOrigin) & "', "
            SQL = SQL & "    K3412_MaterialCheck      = N'" & FormatSQL(z3412.MaterialCheck) & "', "
            SQL = SQL & "    K3412_seUnitPrice      = N'" & FormatSQL(z3412.seUnitPrice) & "', "
            SQL = SQL & "    K3412_cdUnitPrice      = N'" & FormatSQL(z3412.cdUnitPrice) & "', "
            SQL = SQL & "    K3412_seTax      = N'" & FormatSQL(z3412.seTax) & "', "
            SQL = SQL & "    K3412_cdTax      = N'" & FormatSQL(z3412.cdTax) & "', "
            SQL = SQL & "    K3412_seUnitMaterial      = N'" & FormatSQL(z3412.seUnitMaterial) & "', "
            SQL = SQL & "    K3412_cdUnitMaterial      = N'" & FormatSQL(z3412.cdUnitMaterial) & "', "
            SQL = SQL & "    K3412_seUnitPacking      = N'" & FormatSQL(z3412.seUnitPacking) & "', "
            SQL = SQL & "    K3412_cdUnitPacking      = N'" & FormatSQL(z3412.cdUnitPacking) & "', "
            SQL = SQL & "    K3412_UnitBaseCheck      = N'" & FormatSQL(z3412.UnitBaseCheck) & "', "
            SQL = SQL & "    K3412_QtyBasic      =  " & FormatSQL(z3412.QtyBasic) & ", "
            SQL = SQL & "    K3412_PricePurchasing      =  " & FormatSQL(z3412.PricePurchasing) & ", "
            SQL = SQL & "    K3412_PriceMarket      =  " & FormatSQL(z3412.PriceMarket) & ", "
            SQL = SQL & "    K3412_PriceExchangeAP      =  " & FormatSQL(z3412.PriceExchangeAP) & ", "
            SQL = SQL & "    K3412_PriceExchange      =  " & FormatSQL(z3412.PriceExchange) & ", "
            SQL = SQL & "    K3412_DateExchange      = N'" & FormatSQL(z3412.DateExchange) & "', "
            SQL = SQL & "    K3412_PricePurchasingEX      =  " & FormatSQL(z3412.PricePurchasingEX) & ", "
            SQL = SQL & "    K3412_PriceMarketEX      =  " & FormatSQL(z3412.PriceMarketEX) & ", "
            SQL = SQL & "    K3412_PricePurchasingVND      =  " & FormatSQL(z3412.PricePurchasingVND) & ", "
            SQL = SQL & "    K3412_PriceMarketVND      =  " & FormatSQL(z3412.PriceMarketVND) & ", "
            SQL = SQL & "    K3412_AmountPurchasingEX      =  " & FormatSQL(z3412.AmountPurchasingEX) & ", "
            SQL = SQL & "    K3412_AmountPurchasingVND      =  " & FormatSQL(z3412.AmountPurchasingVND) & ", "
            SQL = SQL & "    K3412_AmountTaxEX      =  " & FormatSQL(z3412.AmountTaxEX) & ", "
            SQL = SQL & "    K3412_AmountTaxVND      =  " & FormatSQL(z3412.AmountTaxVND) & ", "
            SQL = SQL & "    K3412_seTax1      = N'" & FormatSQL(z3412.seTax1) & "', "
            SQL = SQL & "    K3412_cdTax1      = N'" & FormatSQL(z3412.cdTax1) & "', "
            SQL = SQL & "    K3412_PerTax1      =  " & FormatSQL(z3412.PerTax1) & ", "
            SQL = SQL & "    K3412_AmountTax1EX      =  " & FormatSQL(z3412.AmountTax1EX) & ", "
            SQL = SQL & "    K3412_AmountTax1      =  " & FormatSQL(z3412.AmountTax1) & ", "
            SQL = SQL & "    K3412_seTax2      = N'" & FormatSQL(z3412.seTax2) & "', "
            SQL = SQL & "    K3412_cdTax2      = N'" & FormatSQL(z3412.cdTax2) & "', "
            SQL = SQL & "    K3412_PerTax2      =  " & FormatSQL(z3412.PerTax2) & ", "
            SQL = SQL & "    K3412_AmountTax2EX      =  " & FormatSQL(z3412.AmountTax2EX) & ", "
            SQL = SQL & "    K3412_AmountTax2      =  " & FormatSQL(z3412.AmountTax2) & ", "
            SQL = SQL & "    K3412_seTax3      = N'" & FormatSQL(z3412.seTax3) & "', "
            SQL = SQL & "    K3412_cdTax3      = N'" & FormatSQL(z3412.cdTax3) & "', "
            SQL = SQL & "    K3412_PerTax3      =  " & FormatSQL(z3412.PerTax3) & ", "
            SQL = SQL & "    K3412_AmountTax3EX      =  " & FormatSQL(z3412.AmountTax3EX) & ", "
            SQL = SQL & "    K3412_AmountTax3      =  " & FormatSQL(z3412.AmountTax3) & ", "
            SQL = SQL & "    K3412_QtyBooking      =  " & FormatSQL(z3412.QtyBooking) & ", "
            SQL = SQL & "    K3412_QtyPurchasingNet      =  " & FormatSQL(z3412.QtyPurchasingNet) & ", "
            SQL = SQL & "    K3412_QtyPurchasingMOQ      =  " & FormatSQL(z3412.QtyPurchasingMOQ) & ", "
            SQL = SQL & "    K3412_QtyPurchasing      =  " & FormatSQL(z3412.QtyPurchasing) & ", "
            SQL = SQL & "    K3412_PackPurchasing      =  " & FormatSQL(z3412.PackPurchasing) & ", "
            SQL = SQL & "    K3412_AmountPSC      =  " & FormatSQL(z3412.AmountPSC) & ", "
            SQL = SQL & "    K3412_AmountEX      =  " & FormatSQL(z3412.AmountEX) & ", "
            SQL = SQL & "    K3412_AmountVND      =  " & FormatSQL(z3412.AmountVND) & ", "
            SQL = SQL & "    K3412_AmountNoVATEX      =  " & FormatSQL(z3412.AmountNoVATEX) & ", "
            SQL = SQL & "    K3412_AmountNoVATVND      =  " & FormatSQL(z3412.AmountNoVATVND) & ", "
            SQL = SQL & "    K3412_AmountTotalEX      =  " & FormatSQL(z3412.AmountTotalEX) & ", "
            SQL = SQL & "    K3412_AmountTotalVND      =  " & FormatSQL(z3412.AmountTotalVND) & ", "
            SQL = SQL & "    K3412_TotalQtyPurchasing      =  " & FormatSQL(z3412.TotalQtyPurchasing) & ", "
            SQL = SQL & "    K3412_TotalPackPurchasing      =  " & FormatSQL(z3412.TotalPackPurchasing) & ", "
            SQL = SQL & "    K3412_QtyWarehouse      =  " & FormatSQL(z3412.QtyWarehouse) & ", "
            SQL = SQL & "    K3412_PackWarehouse      =  " & FormatSQL(z3412.PackWarehouse) & ", "
            SQL = SQL & "    K3412_DateDelivery      = N'" & FormatSQL(z3412.DateDelivery) & "', "
            SQL = SQL & "    K3412_DateStart      = N'" & FormatSQL(z3412.DateStart) & "', "
            SQL = SQL & "    K3412_DateFinish      = N'" & FormatSQL(z3412.DateFinish) & "', "
            SQL = SQL & "    K3412_CheckPurchasing      = N'" & FormatSQL(z3412.CheckPurchasing) & "', "
            SQL = SQL & "    K3412_DateAccept      = N'" & FormatSQL(z3412.DateAccept) & "', "
            SQL = SQL & "    K3412_DatePosted      = N'" & FormatSQL(z3412.DatePosted) & "', "
            SQL = SQL & "    K3412_IsPosted      = N'" & FormatSQL(z3412.IsPosted) & "', "
            SQL = SQL & "    K3412_DateComplete      = N'" & FormatSQL(z3412.DateComplete) & "', "
            SQL = SQL & "    K3412_DateApproval      = N'" & FormatSQL(z3412.DateApproval) & "', "
            SQL = SQL & "    K3412_DateCancel      = N'" & FormatSQL(z3412.DateCancel) & "', "
            SQL = SQL & "    K3412_CheckComplete      = N'" & FormatSQL(z3412.CheckComplete) & "', "
            SQL = SQL & "    K3412_PurchasingRequestNo      = N'" & FormatSQL(z3412.PurchasingRequestNo) & "', "
            SQL = SQL & "    K3412_PurchasingRequestSeq      =  " & FormatSQL(z3412.PurchasingRequestSeq) & ", "
            SQL = SQL & "    K3412_OrderNo      = N'" & FormatSQL(z3412.OrderNo) & "', "
            SQL = SQL & "    K3412_OrderNoSeq      = N'" & FormatSQL(z3412.OrderNoSeq) & "', "
            SQL = SQL & "    K3412_PurchasingOrderNo_Bf      = N'" & FormatSQL(z3412.PurchasingOrderNo_Bf) & "', "
            SQL = SQL & "    K3412_PurchasingOrderSeq_Bf      =  " & FormatSQL(z3412.PurchasingOrderSeq_Bf) & ", "
            SQL = SQL & "    K3412_Remark      = N'" & FormatSQL(z3412.Remark) & "', "
            SQL = SQL & "    K3412_TimeInsert      = N'" & FormatSQL(z3412.TimeInsert) & "', "
            SQL = SQL & "    K3412_TimeUpdate      = N'" & FormatSQL(PUB.TIME) & "', "
            SQL = SQL & "    K3412_DateInsert      = N'" & FormatSQL(z3412.DateInsert) & "', "
            SQL = SQL & "    K3412_DateUpdate      = N'" & FormatSQL(PUB.DAT) & "', "
            SQL = SQL & "    K3412_InchargeInsert      = N'" & FormatSQL(z3412.InchargeInsert) & "', "
            SQL = SQL & "    K3412_InchargeUpdate      = N'" & FormatSQL(PUB.SAW) & "', "
            SQL = SQL & "    K3412_PriceAPurchasing      =  " & FormatSQL(z3412.PriceAPurchasing) & ", "
            SQL = SQL & "    K3412_cdUnitMaterialA      = N'" & FormatSQL(z3412.cdUnitMaterialA) & "', "
            SQL = SQL & "    K3412_cdUnitPriceA      = N'" & FormatSQL(z3412.cdUnitPriceA) & "', "
            SQL = SQL & "    K3412_QtyAPurchasing      =  " & FormatSQL(z3412.QtyAPurchasing) & ", "
            SQL = SQL & "    K3412_QtyATotal      =  " & FormatSQL(z3412.QtyATotal) & ", "
            SQL = SQL & "    K3412_AmtAPurchasing      =  " & FormatSQL(z3412.AmtAPurchasing) & ", "
            SQL = SQL & "    K3412_AmtATotal      =  " & FormatSQL(z3412.AmtATotal) & ", "
            SQL = SQL & "    K3412_InvoiceNo1      = N'" & FormatSQL(z3412.InvoiceNo1) & "', "
            SQL = SQL & "    K3412_InvoiceNo2      = N'" & FormatSQL(z3412.InvoiceNo2) & "', "
            SQL = SQL & "    K3412_InvoiceNo3      = N'" & FormatSQL(z3412.InvoiceNo3) & "', "
            SQL = SQL & "    K3412_InvoiceNo4      = N'" & FormatSQL(z3412.InvoiceNo4) & "', "
            SQL = SQL & "    K3412_InvoiceNo5      = N'" & FormatSQL(z3412.InvoiceNo5) & "', "
            SQL = SQL & "    K3412_InvoiceNo6      = N'" & FormatSQL(z3412.InvoiceNo6) & "', "
            SQL = SQL & "    K3412_InvoiceNo7      = N'" & FormatSQL(z3412.InvoiceNo7) & "', "
            SQL = SQL & "    K3412_InvoiceNo8      = N'" & FormatSQL(z3412.InvoiceNo8) & "', "
            SQL = SQL & "    K3412_InvoiceNo9      = N'" & FormatSQL(z3412.InvoiceNo9) & "', "
            SQL = SQL & "    K3412_InvoiceNo10      = N'" & FormatSQL(z3412.InvoiceNo10) & "', "
            SQL = SQL & "    K3412_DateArrive1      = N'" & FormatSQL(z3412.DateArrive1) & "', "
            SQL = SQL & "    K3412_DateArrive2      = N'" & FormatSQL(z3412.DateArrive2) & "', "
            SQL = SQL & "    K3412_DateArrive3      = N'" & FormatSQL(z3412.DateArrive3) & "', "
            SQL = SQL & "    K3412_DateArrive4      = N'" & FormatSQL(z3412.DateArrive4) & "', "
            SQL = SQL & "    K3412_DateArrive5      = N'" & FormatSQL(z3412.DateArrive5) & "', "
            SQL = SQL & "    K3412_DateArrive6      = N'" & FormatSQL(z3412.DateArrive6) & "', "
            SQL = SQL & "    K3412_DateArrive7      = N'" & FormatSQL(z3412.DateArrive7) & "', "
            SQL = SQL & "    K3412_DateArrive8      = N'" & FormatSQL(z3412.DateArrive8) & "', "
            SQL = SQL & "    K3412_DateArrive9      = N'" & FormatSQL(z3412.DateArrive9) & "', "
            SQL = SQL & "    K3412_DateArrive10      = N'" & FormatSQL(z3412.DateArrive10) & "', "
            SQL = SQL & "    K3412_QtyAArrive1      =  " & FormatSQL(z3412.QtyAArrive1) & ", "
            SQL = SQL & "    K3412_QtyAArrive2      =  " & FormatSQL(z3412.QtyAArrive2) & ", "
            SQL = SQL & "    K3412_QtyAArrive3      =  " & FormatSQL(z3412.QtyAArrive3) & ", "
            SQL = SQL & "    K3412_QtyAArrive4      =  " & FormatSQL(z3412.QtyAArrive4) & ", "
            SQL = SQL & "    K3412_QtyAArrive5      =  " & FormatSQL(z3412.QtyAArrive5) & ", "
            SQL = SQL & "    K3412_QtyAArrive6      =  " & FormatSQL(z3412.QtyAArrive6) & ", "
            SQL = SQL & "    K3412_QtyAArrive7      =  " & FormatSQL(z3412.QtyAArrive7) & ", "
            SQL = SQL & "    K3412_QtyAArrive8      =  " & FormatSQL(z3412.QtyAArrive8) & ", "
            SQL = SQL & "    K3412_QtyAArrive9      =  " & FormatSQL(z3412.QtyAArrive9) & ", "
            SQL = SQL & "    K3412_QtyAArrive10      =  " & FormatSQL(z3412.QtyAArrive10) & ", "
            SQL = SQL & "    K3412_InchargeInvoice      = N'" & FormatSQL(z3412.InchargeInvoice) & "', "
            SQL = SQL & "    K3412_APLName      = N'" & FormatSQL(z3412.APLName) & "', "
            SQL = SQL & "    K3412_AInvoice      = N'" & FormatSQL(z3412.AInvoice) & "', "
            SQL = SQL & "    K3412_ARemark      = N'" & FormatSQL(z3412.ARemark) & "'  "
            SQL = SQL & " WHERE K3412_PurchasingOrderNo		 = '" & z3412.PurchasingOrderNo & "' "
            SQL = SQL & "   AND K3412_PurchasingOrderSeq		 =  " & z3412.PurchasingOrderSeq & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()


            REWRITE_PFK3412 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK3412", vbCritical)

        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK3412(z3412 As T3412_AREA) As Boolean
        DELETE_PFK3412 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z3412)

            SQL = " DELETE FROM PFK3412  "
            SQL = SQL & " WHERE K3412_PurchasingOrderNo		 = '" & z3412.PurchasingOrderNo & "' "
            SQL = SQL & "   AND K3412_PurchasingOrderSeq		 =  " & z3412.PurchasingOrderSeq & "  "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK3412 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK3412", vbCritical)
        Finally
            Call GetFullInformation("PFK3412", "D", SQL)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D3412_CLEAR()
        Try

            D3412.PurchasingOrderNo = ""
            D3412.PurchasingOrderSeq = 0
            D3412.seSite = ""
            D3412.cdSite = ""
            D3412.seDepartment = ""
            D3412.cdDepartment = ""
            D3412.seFactory = ""
            D3412.cdFactory = ""
            D3412.CustomerSupplier = ""
            D3412.Dseq = 0
            D3412.AutokeyK3011 = 0
            D3412.CheckRelationType = ""
            D3412.MaterialCode = ""
            D3412.Specification = ""
            D3412.Width = ""
            D3412.Height = ""
            D3412.SizeNo = ""
            D3412.SizeName = ""
            D3412.ColorCode = ""
            D3412.ColorName = ""
            D3412.seOrigin = ""
            D3412.cdOrigin = ""
            D3412.MaterialCheck = ""
            D3412.seUnitPrice = ""
            D3412.cdUnitPrice = ""
            D3412.seTax = ""
            D3412.cdTax = ""
            D3412.seUnitMaterial = ""
            D3412.cdUnitMaterial = ""
            D3412.seUnitPacking = ""
            D3412.cdUnitPacking = ""
            D3412.UnitBaseCheck = ""
            D3412.QtyBasic = 0
            D3412.PricePurchasing = 0
            D3412.PriceMarket = 0
            D3412.PriceExchangeAP = 0
            D3412.PriceExchange = 0
            D3412.DateExchange = ""
            D3412.PricePurchasingEX = 0
            D3412.PriceMarketEX = 0
            D3412.PricePurchasingVND = 0
            D3412.PriceMarketVND = 0
            D3412.AmountPurchasingEX = 0
            D3412.AmountPurchasingVND = 0
            D3412.AmountTaxEX = 0
            D3412.AmountTaxVND = 0
            D3412.seTax1 = ""
            D3412.cdTax1 = ""
            D3412.PerTax1 = 0
            D3412.AmountTax1EX = 0
            D3412.AmountTax1 = 0
            D3412.seTax2 = ""
            D3412.cdTax2 = ""
            D3412.PerTax2 = 0
            D3412.AmountTax2EX = 0
            D3412.AmountTax2 = 0
            D3412.seTax3 = ""
            D3412.cdTax3 = ""
            D3412.PerTax3 = 0
            D3412.AmountTax3EX = 0
            D3412.AmountTax3 = 0
            D3412.QtyBooking = 0
            D3412.QtyPurchasingNet = 0
            D3412.QtyPurchasingMOQ = 0
            D3412.QtyPurchasing = 0
            D3412.PackPurchasing = 0
            D3412.AmountPSC = 0
            D3412.AmountEX = 0
            D3412.AmountVND = 0
            D3412.AmountNoVATEX = 0
            D3412.AmountNoVATVND = 0
            D3412.AmountTotalEX = 0
            D3412.AmountTotalVND = 0
            D3412.TotalQtyPurchasing = 0
            D3412.TotalPackPurchasing = 0
            D3412.QtyWarehouse = 0
            D3412.PackWarehouse = 0
            D3412.DateDelivery = ""
            D3412.DateStart = ""
            D3412.DateFinish = ""
            D3412.CheckPurchasing = ""
            D3412.DateAccept = ""
            D3412.DatePosted = ""
            D3412.IsPosted = ""
            D3412.DateComplete = ""
            D3412.DateApproval = ""
            D3412.DateCancel = ""
            D3412.CheckComplete = ""
            D3412.PurchasingRequestNo = ""
            D3412.PurchasingRequestSeq = 0
            D3412.OrderNo = ""
            D3412.OrderNoSeq = ""
            D3412.PurchasingOrderNo_Bf = ""
            D3412.PurchasingOrderSeq_Bf = 0
            D3412.Remark = ""
            D3412.TimeInsert = ""
            D3412.TimeUpdate = ""
            D3412.DateInsert = ""
            D3412.DateUpdate = ""
            D3412.InchargeInsert = ""
            D3412.InchargeUpdate = ""
            D3412.PriceAPurchasing = 0
            D3412.cdUnitMaterialA = ""
            D3412.cdUnitPriceA = ""
            D3412.QtyAPurchasing = 0
            D3412.QtyATotal = 0
            D3412.AmtAPurchasing = 0
            D3412.AmtATotal = 0
            D3412.InvoiceNo1 = ""
            D3412.InvoiceNo2 = ""
            D3412.InvoiceNo3 = ""
            D3412.InvoiceNo4 = ""
            D3412.InvoiceNo5 = ""
            D3412.InvoiceNo6 = ""
            D3412.InvoiceNo7 = ""
            D3412.InvoiceNo8 = ""
            D3412.InvoiceNo9 = ""
            D3412.InvoiceNo10 = ""
            D3412.DateArrive1 = ""
            D3412.DateArrive2 = ""
            D3412.DateArrive3 = ""
            D3412.DateArrive4 = ""
            D3412.DateArrive5 = ""
            D3412.DateArrive6 = ""
            D3412.DateArrive7 = ""
            D3412.DateArrive8 = ""
            D3412.DateArrive9 = ""
            D3412.DateArrive10 = ""
            D3412.QtyAArrive1 = 0
            D3412.QtyAArrive2 = 0
            D3412.QtyAArrive3 = 0
            D3412.QtyAArrive4 = 0
            D3412.QtyAArrive5 = 0
            D3412.QtyAArrive6 = 0
            D3412.QtyAArrive7 = 0
            D3412.QtyAArrive8 = 0
            D3412.QtyAArrive9 = 0
            D3412.QtyAArrive10 = 0
            D3412.InchargeInvoice = ""
            D3412.APLName = ""
            D3412.AInvoice = ""
            D3412.ARemark = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D3412_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x3412 As T3412_AREA)
        Try

            x3412.PurchasingOrderNo = trim$(x3412.PurchasingOrderNo)
            x3412.PurchasingOrderSeq = trim$(x3412.PurchasingOrderSeq)
            x3412.seSite = trim$(x3412.seSite)
            x3412.cdSite = trim$(x3412.cdSite)
            x3412.seDepartment = trim$(x3412.seDepartment)
            x3412.cdDepartment = trim$(x3412.cdDepartment)
            x3412.seFactory = trim$(x3412.seFactory)
            x3412.cdFactory = trim$(x3412.cdFactory)
            x3412.CustomerSupplier = trim$(x3412.CustomerSupplier)
            x3412.Dseq = trim$(x3412.Dseq)
            x3412.AutokeyK3011 = trim$(x3412.AutokeyK3011)
            x3412.CheckRelationType = trim$(x3412.CheckRelationType)
            x3412.MaterialCode = trim$(x3412.MaterialCode)
            x3412.Specification = trim$(x3412.Specification)
            x3412.Width = trim$(x3412.Width)
            x3412.Height = trim$(x3412.Height)
            x3412.SizeNo = trim$(x3412.SizeNo)
            x3412.SizeName = trim$(x3412.SizeName)
            x3412.ColorCode = trim$(x3412.ColorCode)
            x3412.ColorName = trim$(x3412.ColorName)
            x3412.seOrigin = trim$(x3412.seOrigin)
            x3412.cdOrigin = trim$(x3412.cdOrigin)
            x3412.MaterialCheck = trim$(x3412.MaterialCheck)
            x3412.seUnitPrice = trim$(x3412.seUnitPrice)
            x3412.cdUnitPrice = trim$(x3412.cdUnitPrice)
            x3412.seTax = trim$(x3412.seTax)
            x3412.cdTax = trim$(x3412.cdTax)
            x3412.seUnitMaterial = trim$(x3412.seUnitMaterial)
            x3412.cdUnitMaterial = trim$(x3412.cdUnitMaterial)
            x3412.seUnitPacking = trim$(x3412.seUnitPacking)
            x3412.cdUnitPacking = trim$(x3412.cdUnitPacking)
            x3412.UnitBaseCheck = trim$(x3412.UnitBaseCheck)
            x3412.QtyBasic = trim$(x3412.QtyBasic)
            x3412.PricePurchasing = trim$(x3412.PricePurchasing)
            x3412.PriceMarket = trim$(x3412.PriceMarket)
            x3412.PriceExchangeAP = trim$(x3412.PriceExchangeAP)
            x3412.PriceExchange = trim$(x3412.PriceExchange)
            x3412.DateExchange = trim$(x3412.DateExchange)
            x3412.PricePurchasingEX = trim$(x3412.PricePurchasingEX)
            x3412.PriceMarketEX = trim$(x3412.PriceMarketEX)
            x3412.PricePurchasingVND = trim$(x3412.PricePurchasingVND)
            x3412.PriceMarketVND = trim$(x3412.PriceMarketVND)
            x3412.AmountPurchasingEX = trim$(x3412.AmountPurchasingEX)
            x3412.AmountPurchasingVND = trim$(x3412.AmountPurchasingVND)
            x3412.AmountTaxEX = trim$(x3412.AmountTaxEX)
            x3412.AmountTaxVND = trim$(x3412.AmountTaxVND)
            x3412.seTax1 = trim$(x3412.seTax1)
            x3412.cdTax1 = trim$(x3412.cdTax1)
            x3412.PerTax1 = trim$(x3412.PerTax1)
            x3412.AmountTax1EX = trim$(x3412.AmountTax1EX)
            x3412.AmountTax1 = trim$(x3412.AmountTax1)
            x3412.seTax2 = trim$(x3412.seTax2)
            x3412.cdTax2 = trim$(x3412.cdTax2)
            x3412.PerTax2 = trim$(x3412.PerTax2)
            x3412.AmountTax2EX = trim$(x3412.AmountTax2EX)
            x3412.AmountTax2 = trim$(x3412.AmountTax2)
            x3412.seTax3 = trim$(x3412.seTax3)
            x3412.cdTax3 = trim$(x3412.cdTax3)
            x3412.PerTax3 = trim$(x3412.PerTax3)
            x3412.AmountTax3EX = trim$(x3412.AmountTax3EX)
            x3412.AmountTax3 = trim$(x3412.AmountTax3)
            x3412.QtyBooking = trim$(x3412.QtyBooking)
            x3412.QtyPurchasingNet = trim$(x3412.QtyPurchasingNet)
            x3412.QtyPurchasingMOQ = trim$(x3412.QtyPurchasingMOQ)
            x3412.QtyPurchasing = trim$(x3412.QtyPurchasing)
            x3412.PackPurchasing = trim$(x3412.PackPurchasing)
            x3412.AmountPSC = trim$(x3412.AmountPSC)
            x3412.AmountEX = trim$(x3412.AmountEX)
            x3412.AmountVND = trim$(x3412.AmountVND)
            x3412.AmountNoVATEX = trim$(x3412.AmountNoVATEX)
            x3412.AmountNoVATVND = trim$(x3412.AmountNoVATVND)
            x3412.AmountTotalEX = trim$(x3412.AmountTotalEX)
            x3412.AmountTotalVND = trim$(x3412.AmountTotalVND)
            x3412.TotalQtyPurchasing = trim$(x3412.TotalQtyPurchasing)
            x3412.TotalPackPurchasing = trim$(x3412.TotalPackPurchasing)
            x3412.QtyWarehouse = trim$(x3412.QtyWarehouse)
            x3412.PackWarehouse = trim$(x3412.PackWarehouse)
            x3412.DateDelivery = trim$(x3412.DateDelivery)
            x3412.DateStart = trim$(x3412.DateStart)
            x3412.DateFinish = trim$(x3412.DateFinish)
            x3412.CheckPurchasing = trim$(x3412.CheckPurchasing)
            x3412.DateAccept = trim$(x3412.DateAccept)
            x3412.DatePosted = trim$(x3412.DatePosted)
            x3412.IsPosted = trim$(x3412.IsPosted)
            x3412.DateComplete = trim$(x3412.DateComplete)
            x3412.DateApproval = trim$(x3412.DateApproval)
            x3412.DateCancel = trim$(x3412.DateCancel)
            x3412.CheckComplete = trim$(x3412.CheckComplete)
            x3412.PurchasingRequestNo = trim$(x3412.PurchasingRequestNo)
            x3412.PurchasingRequestSeq = trim$(x3412.PurchasingRequestSeq)
            x3412.OrderNo = trim$(x3412.OrderNo)
            x3412.OrderNoSeq = trim$(x3412.OrderNoSeq)
            x3412.PurchasingOrderNo_Bf = trim$(x3412.PurchasingOrderNo_Bf)
            x3412.PurchasingOrderSeq_Bf = trim$(x3412.PurchasingOrderSeq_Bf)
            x3412.Remark = trim$(x3412.Remark)
            x3412.TimeInsert = trim$(x3412.TimeInsert)
            x3412.TimeUpdate = trim$(x3412.TimeUpdate)
            x3412.DateInsert = trim$(x3412.DateInsert)
            x3412.DateUpdate = trim$(x3412.DateUpdate)
            x3412.InchargeInsert = trim$(x3412.InchargeInsert)
            x3412.InchargeUpdate = trim$(x3412.InchargeUpdate)
            x3412.PriceAPurchasing = trim$(x3412.PriceAPurchasing)
            x3412.cdUnitMaterialA = trim$(x3412.cdUnitMaterialA)
            x3412.cdUnitPriceA = trim$(x3412.cdUnitPriceA)
            x3412.QtyAPurchasing = trim$(x3412.QtyAPurchasing)
            x3412.QtyATotal = trim$(x3412.QtyATotal)
            x3412.AmtAPurchasing = trim$(x3412.AmtAPurchasing)
            x3412.AmtATotal = trim$(x3412.AmtATotal)
            x3412.InvoiceNo1 = trim$(x3412.InvoiceNo1)
            x3412.InvoiceNo2 = trim$(x3412.InvoiceNo2)
            x3412.InvoiceNo3 = trim$(x3412.InvoiceNo3)
            x3412.InvoiceNo4 = trim$(x3412.InvoiceNo4)
            x3412.InvoiceNo5 = Trim$(x3412.InvoiceNo5)
            x3412.InvoiceNo6 = Trim$(x3412.InvoiceNo6)
            x3412.InvoiceNo7 = Trim$(x3412.InvoiceNo7)
            x3412.InvoiceNo8 = Trim$(x3412.InvoiceNo8)
            x3412.InvoiceNo9 = Trim$(x3412.InvoiceNo9)
            x3412.InvoiceNo10 = Trim$(x3412.InvoiceNo10)
            x3412.DateArrive1 = trim$(x3412.DateArrive1)
            x3412.DateArrive2 = trim$(x3412.DateArrive2)
            x3412.DateArrive3 = trim$(x3412.DateArrive3)
            x3412.DateArrive4 = trim$(x3412.DateArrive4)
            x3412.DateArrive5 = Trim$(x3412.DateArrive5)
            x3412.DateArrive6 = Trim$(x3412.DateArrive6)
            x3412.DateArrive7 = Trim$(x3412.DateArrive7)
            x3412.DateArrive8 = Trim$(x3412.DateArrive8)
            x3412.DateArrive9 = Trim$(x3412.DateArrive9)
            x3412.DateArrive10 = Trim$(x3412.DateArrive10)
            x3412.QtyAArrive1 = trim$(x3412.QtyAArrive1)
            x3412.QtyAArrive2 = trim$(x3412.QtyAArrive2)
            x3412.QtyAArrive3 = trim$(x3412.QtyAArrive3)
            x3412.QtyAArrive4 = trim$(x3412.QtyAArrive4)
            x3412.QtyAArrive5 = Trim$(x3412.QtyAArrive5)
            x3412.QtyAArrive6 = Trim$(x3412.QtyAArrive6)
            x3412.QtyAArrive7 = Trim$(x3412.QtyAArrive7)
            x3412.QtyAArrive8 = Trim$(x3412.QtyAArrive8)
            x3412.QtyAArrive9 = Trim$(x3412.QtyAArrive9)
            x3412.QtyAArrive10 = Trim$(x3412.QtyAArrive10)

            x3412.InchargeInvoice = trim$(x3412.InchargeInvoice)
            x3412.APLName = trim$(x3412.APLName)
            x3412.AInvoice = trim$(x3412.AInvoice)
            x3412.ARemark = trim$(x3412.ARemark)

            If trim$(x3412.PurchasingOrderNo) = "" Then x3412.PurchasingOrderNo = Space(1)
            If trim$(x3412.PurchasingOrderSeq) = "" Then x3412.PurchasingOrderSeq = 0
            If trim$(x3412.seSite) = "" Then x3412.seSite = Space(1)
            If trim$(x3412.cdSite) = "" Then x3412.cdSite = Space(1)
            If trim$(x3412.seDepartment) = "" Then x3412.seDepartment = Space(1)
            If trim$(x3412.cdDepartment) = "" Then x3412.cdDepartment = Space(1)
            If trim$(x3412.seFactory) = "" Then x3412.seFactory = Space(1)
            If trim$(x3412.cdFactory) = "" Then x3412.cdFactory = Space(1)
            If trim$(x3412.CustomerSupplier) = "" Then x3412.CustomerSupplier = Space(1)
            If trim$(x3412.Dseq) = "" Then x3412.Dseq = 0
            If trim$(x3412.AutokeyK3011) = "" Then x3412.AutokeyK3011 = 0
            If trim$(x3412.CheckRelationType) = "" Then x3412.CheckRelationType = Space(1)
            If trim$(x3412.MaterialCode) = "" Then x3412.MaterialCode = Space(1)
            If trim$(x3412.Specification) = "" Then x3412.Specification = Space(1)
            If trim$(x3412.Width) = "" Then x3412.Width = Space(1)
            If trim$(x3412.Height) = "" Then x3412.Height = Space(1)
            If trim$(x3412.SizeNo) = "" Then x3412.SizeNo = Space(1)
            If trim$(x3412.SizeName) = "" Then x3412.SizeName = Space(1)
            If trim$(x3412.ColorCode) = "" Then x3412.ColorCode = Space(1)
            If trim$(x3412.ColorName) = "" Then x3412.ColorName = Space(1)
            If trim$(x3412.seOrigin) = "" Then x3412.seOrigin = Space(1)
            If trim$(x3412.cdOrigin) = "" Then x3412.cdOrigin = Space(1)
            If trim$(x3412.MaterialCheck) = "" Then x3412.MaterialCheck = Space(1)
            If trim$(x3412.seUnitPrice) = "" Then x3412.seUnitPrice = Space(1)
            If trim$(x3412.cdUnitPrice) = "" Then x3412.cdUnitPrice = Space(1)
            If trim$(x3412.seTax) = "" Then x3412.seTax = Space(1)
            If trim$(x3412.cdTax) = "" Then x3412.cdTax = Space(1)
            If trim$(x3412.seUnitMaterial) = "" Then x3412.seUnitMaterial = Space(1)
            If trim$(x3412.cdUnitMaterial) = "" Then x3412.cdUnitMaterial = Space(1)
            If trim$(x3412.seUnitPacking) = "" Then x3412.seUnitPacking = Space(1)
            If trim$(x3412.cdUnitPacking) = "" Then x3412.cdUnitPacking = Space(1)
            If trim$(x3412.UnitBaseCheck) = "" Then x3412.UnitBaseCheck = Space(1)
            If trim$(x3412.QtyBasic) = "" Then x3412.QtyBasic = 0
            If trim$(x3412.PricePurchasing) = "" Then x3412.PricePurchasing = 0
            If trim$(x3412.PriceMarket) = "" Then x3412.PriceMarket = 0
            If trim$(x3412.PriceExchangeAP) = "" Then x3412.PriceExchangeAP = 0
            If trim$(x3412.PriceExchange) = "" Then x3412.PriceExchange = 0
            If trim$(x3412.DateExchange) = "" Then x3412.DateExchange = Space(1)
            If trim$(x3412.PricePurchasingEX) = "" Then x3412.PricePurchasingEX = 0
            If trim$(x3412.PriceMarketEX) = "" Then x3412.PriceMarketEX = 0
            If trim$(x3412.PricePurchasingVND) = "" Then x3412.PricePurchasingVND = 0
            If trim$(x3412.PriceMarketVND) = "" Then x3412.PriceMarketVND = 0
            If trim$(x3412.AmountPurchasingEX) = "" Then x3412.AmountPurchasingEX = 0
            If trim$(x3412.AmountPurchasingVND) = "" Then x3412.AmountPurchasingVND = 0
            If trim$(x3412.AmountTaxEX) = "" Then x3412.AmountTaxEX = 0
            If trim$(x3412.AmountTaxVND) = "" Then x3412.AmountTaxVND = 0
            If trim$(x3412.seTax1) = "" Then x3412.seTax1 = Space(1)
            If trim$(x3412.cdTax1) = "" Then x3412.cdTax1 = Space(1)
            If trim$(x3412.PerTax1) = "" Then x3412.PerTax1 = 0
            If trim$(x3412.AmountTax1EX) = "" Then x3412.AmountTax1EX = 0
            If trim$(x3412.AmountTax1) = "" Then x3412.AmountTax1 = 0
            If trim$(x3412.seTax2) = "" Then x3412.seTax2 = Space(1)
            If trim$(x3412.cdTax2) = "" Then x3412.cdTax2 = Space(1)
            If trim$(x3412.PerTax2) = "" Then x3412.PerTax2 = 0
            If trim$(x3412.AmountTax2EX) = "" Then x3412.AmountTax2EX = 0
            If trim$(x3412.AmountTax2) = "" Then x3412.AmountTax2 = 0
            If trim$(x3412.seTax3) = "" Then x3412.seTax3 = Space(1)
            If trim$(x3412.cdTax3) = "" Then x3412.cdTax3 = Space(1)
            If trim$(x3412.PerTax3) = "" Then x3412.PerTax3 = 0
            If trim$(x3412.AmountTax3EX) = "" Then x3412.AmountTax3EX = 0
            If trim$(x3412.AmountTax3) = "" Then x3412.AmountTax3 = 0
            If trim$(x3412.QtyBooking) = "" Then x3412.QtyBooking = 0
            If trim$(x3412.QtyPurchasingNet) = "" Then x3412.QtyPurchasingNet = 0
            If trim$(x3412.QtyPurchasingMOQ) = "" Then x3412.QtyPurchasingMOQ = 0
            If trim$(x3412.QtyPurchasing) = "" Then x3412.QtyPurchasing = 0
            If trim$(x3412.PackPurchasing) = "" Then x3412.PackPurchasing = 0
            If trim$(x3412.AmountPSC) = "" Then x3412.AmountPSC = 0
            If trim$(x3412.AmountEX) = "" Then x3412.AmountEX = 0
            If trim$(x3412.AmountVND) = "" Then x3412.AmountVND = 0
            If trim$(x3412.AmountNoVATEX) = "" Then x3412.AmountNoVATEX = 0
            If trim$(x3412.AmountNoVATVND) = "" Then x3412.AmountNoVATVND = 0
            If trim$(x3412.AmountTotalEX) = "" Then x3412.AmountTotalEX = 0
            If trim$(x3412.AmountTotalVND) = "" Then x3412.AmountTotalVND = 0
            If trim$(x3412.TotalQtyPurchasing) = "" Then x3412.TotalQtyPurchasing = 0
            If trim$(x3412.TotalPackPurchasing) = "" Then x3412.TotalPackPurchasing = 0
            If trim$(x3412.QtyWarehouse) = "" Then x3412.QtyWarehouse = 0
            If trim$(x3412.PackWarehouse) = "" Then x3412.PackWarehouse = 0
            If trim$(x3412.DateDelivery) = "" Then x3412.DateDelivery = Space(1)
            If trim$(x3412.DateStart) = "" Then x3412.DateStart = Space(1)
            If trim$(x3412.DateFinish) = "" Then x3412.DateFinish = Space(1)
            If trim$(x3412.CheckPurchasing) = "" Then x3412.CheckPurchasing = Space(1)
            If trim$(x3412.DateAccept) = "" Then x3412.DateAccept = Space(1)
            If trim$(x3412.DatePosted) = "" Then x3412.DatePosted = Space(1)
            If trim$(x3412.IsPosted) = "" Then x3412.IsPosted = Space(1)
            If trim$(x3412.DateComplete) = "" Then x3412.DateComplete = Space(1)
            If trim$(x3412.DateApproval) = "" Then x3412.DateApproval = Space(1)
            If trim$(x3412.DateCancel) = "" Then x3412.DateCancel = Space(1)
            If trim$(x3412.CheckComplete) = "" Then x3412.CheckComplete = Space(1)
            If trim$(x3412.PurchasingRequestNo) = "" Then x3412.PurchasingRequestNo = Space(1)
            If trim$(x3412.PurchasingRequestSeq) = "" Then x3412.PurchasingRequestSeq = 0
            If trim$(x3412.OrderNo) = "" Then x3412.OrderNo = Space(1)
            If trim$(x3412.OrderNoSeq) = "" Then x3412.OrderNoSeq = Space(1)
            If trim$(x3412.PurchasingOrderNo_Bf) = "" Then x3412.PurchasingOrderNo_Bf = Space(1)
            If trim$(x3412.PurchasingOrderSeq_Bf) = "" Then x3412.PurchasingOrderSeq_Bf = 0
            If trim$(x3412.Remark) = "" Then x3412.Remark = Space(1)
            If trim$(x3412.TimeInsert) = "" Then x3412.TimeInsert = Space(1)
            If trim$(x3412.TimeUpdate) = "" Then x3412.TimeUpdate = Space(1)
            If trim$(x3412.DateInsert) = "" Then x3412.DateInsert = Space(1)
            If trim$(x3412.DateUpdate) = "" Then x3412.DateUpdate = Space(1)
            If trim$(x3412.InchargeInsert) = "" Then x3412.InchargeInsert = Space(1)
            If trim$(x3412.InchargeUpdate) = "" Then x3412.InchargeUpdate = Space(1)
            If trim$(x3412.PriceAPurchasing) = "" Then x3412.PriceAPurchasing = 0
            If trim$(x3412.cdUnitMaterialA) = "" Then x3412.cdUnitMaterialA = Space(1)
            If trim$(x3412.cdUnitPriceA) = "" Then x3412.cdUnitPriceA = Space(1)
            If trim$(x3412.QtyAPurchasing) = "" Then x3412.QtyAPurchasing = 0
            If trim$(x3412.QtyATotal) = "" Then x3412.QtyATotal = 0
            If trim$(x3412.AmtAPurchasing) = "" Then x3412.AmtAPurchasing = 0
            If trim$(x3412.AmtATotal) = "" Then x3412.AmtATotal = 0
            If trim$(x3412.InvoiceNo1) = "" Then x3412.InvoiceNo1 = Space(1)
            If trim$(x3412.InvoiceNo2) = "" Then x3412.InvoiceNo2 = Space(1)
            If trim$(x3412.InvoiceNo3) = "" Then x3412.InvoiceNo3 = Space(1)
            If trim$(x3412.InvoiceNo4) = "" Then x3412.InvoiceNo4 = Space(1)
            If Trim$(x3412.InvoiceNo5) = "" Then x3412.InvoiceNo5 = Space(1)
            If Trim$(x3412.InvoiceNo6) = "" Then x3412.InvoiceNo6 = Space(1)
            If Trim$(x3412.InvoiceNo7) = "" Then x3412.InvoiceNo7 = Space(1)
            If Trim$(x3412.InvoiceNo8) = "" Then x3412.InvoiceNo8 = Space(1)
            If Trim$(x3412.InvoiceNo9) = "" Then x3412.InvoiceNo9 = Space(1)
            If Trim$(x3412.InvoiceNo10) = "" Then x3412.InvoiceNo10 = Space(1)
            If trim$(x3412.DateArrive1) = "" Then x3412.DateArrive1 = Space(1)
            If trim$(x3412.DateArrive2) = "" Then x3412.DateArrive2 = Space(1)
            If trim$(x3412.DateArrive3) = "" Then x3412.DateArrive3 = Space(1)
            If trim$(x3412.DateArrive4) = "" Then x3412.DateArrive4 = Space(1)
            If Trim$(x3412.DateArrive5) = "" Then x3412.DateArrive5 = Space(1)
            If Trim$(x3412.DateArrive6) = "" Then x3412.DateArrive6 = Space(1)
            If Trim$(x3412.DateArrive7) = "" Then x3412.DateArrive7 = Space(1)
            If Trim$(x3412.DateArrive8) = "" Then x3412.DateArrive8 = Space(1)
            If Trim$(x3412.DateArrive9) = "" Then x3412.DateArrive9 = Space(1)
            If Trim$(x3412.DateArrive10) = "" Then x3412.DateArrive10 = Space(1)
            If trim$(x3412.QtyAArrive1) = "" Then x3412.QtyAArrive1 = 0
            If trim$(x3412.QtyAArrive2) = "" Then x3412.QtyAArrive2 = 0
            If trim$(x3412.QtyAArrive3) = "" Then x3412.QtyAArrive3 = 0
            If trim$(x3412.QtyAArrive4) = "" Then x3412.QtyAArrive4 = 0
            If Trim$(x3412.QtyAArrive5) = "" Then x3412.QtyAArrive5 = 0
            If Trim$(x3412.QtyAArrive6) = "" Then x3412.QtyAArrive6 = 0
            If Trim$(x3412.QtyAArrive7) = "" Then x3412.QtyAArrive7 = 0
            If Trim$(x3412.QtyAArrive8) = "" Then x3412.QtyAArrive8 = 0
            If Trim$(x3412.QtyAArrive9) = "" Then x3412.QtyAArrive9 = 0
            If Trim$(x3412.QtyAArrive10) = "" Then x3412.QtyAArrive10 = 0
            If trim$(x3412.InchargeInvoice) = "" Then x3412.InchargeInvoice = Space(1)
            If trim$(x3412.APLName) = "" Then x3412.APLName = Space(1)
            If trim$(x3412.AInvoice) = "" Then x3412.AInvoice = Space(1)
            If trim$(x3412.ARemark) = "" Then x3412.ARemark = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K3412_MOVE(rs3412 As SqlClient.SqlDataReader)
        Try

            Call D3412_CLEAR()

            If IsdbNull(rs3412!K3412_PurchasingOrderNo) = False Then D3412.PurchasingOrderNo = Trim$(rs3412!K3412_PurchasingOrderNo)
            If IsdbNull(rs3412!K3412_PurchasingOrderSeq) = False Then D3412.PurchasingOrderSeq = Trim$(rs3412!K3412_PurchasingOrderSeq)
            If IsdbNull(rs3412!K3412_seSite) = False Then D3412.seSite = Trim$(rs3412!K3412_seSite)
            If IsdbNull(rs3412!K3412_cdSite) = False Then D3412.cdSite = Trim$(rs3412!K3412_cdSite)
            If IsdbNull(rs3412!K3412_seDepartment) = False Then D3412.seDepartment = Trim$(rs3412!K3412_seDepartment)
            If IsdbNull(rs3412!K3412_cdDepartment) = False Then D3412.cdDepartment = Trim$(rs3412!K3412_cdDepartment)
            If IsdbNull(rs3412!K3412_seFactory) = False Then D3412.seFactory = Trim$(rs3412!K3412_seFactory)
            If IsdbNull(rs3412!K3412_cdFactory) = False Then D3412.cdFactory = Trim$(rs3412!K3412_cdFactory)
            If IsdbNull(rs3412!K3412_CustomerSupplier) = False Then D3412.CustomerSupplier = Trim$(rs3412!K3412_CustomerSupplier)
            If IsdbNull(rs3412!K3412_Dseq) = False Then D3412.Dseq = Trim$(rs3412!K3412_Dseq)
            If IsdbNull(rs3412!K3412_AutokeyK3011) = False Then D3412.AutokeyK3011 = Trim$(rs3412!K3412_AutokeyK3011)
            If IsdbNull(rs3412!K3412_CheckRelationType) = False Then D3412.CheckRelationType = Trim$(rs3412!K3412_CheckRelationType)
            If IsdbNull(rs3412!K3412_MaterialCode) = False Then D3412.MaterialCode = Trim$(rs3412!K3412_MaterialCode)
            If IsdbNull(rs3412!K3412_Specification) = False Then D3412.Specification = Trim$(rs3412!K3412_Specification)
            If IsdbNull(rs3412!K3412_Width) = False Then D3412.Width = Trim$(rs3412!K3412_Width)
            If IsdbNull(rs3412!K3412_Height) = False Then D3412.Height = Trim$(rs3412!K3412_Height)
            If IsdbNull(rs3412!K3412_SizeNo) = False Then D3412.SizeNo = Trim$(rs3412!K3412_SizeNo)
            If IsdbNull(rs3412!K3412_SizeName) = False Then D3412.SizeName = Trim$(rs3412!K3412_SizeName)
            If IsdbNull(rs3412!K3412_ColorCode) = False Then D3412.ColorCode = Trim$(rs3412!K3412_ColorCode)
            If IsdbNull(rs3412!K3412_ColorName) = False Then D3412.ColorName = Trim$(rs3412!K3412_ColorName)
            If IsdbNull(rs3412!K3412_seOrigin) = False Then D3412.seOrigin = Trim$(rs3412!K3412_seOrigin)
            If IsdbNull(rs3412!K3412_cdOrigin) = False Then D3412.cdOrigin = Trim$(rs3412!K3412_cdOrigin)
            If IsdbNull(rs3412!K3412_MaterialCheck) = False Then D3412.MaterialCheck = Trim$(rs3412!K3412_MaterialCheck)
            If IsdbNull(rs3412!K3412_seUnitPrice) = False Then D3412.seUnitPrice = Trim$(rs3412!K3412_seUnitPrice)
            If IsdbNull(rs3412!K3412_cdUnitPrice) = False Then D3412.cdUnitPrice = Trim$(rs3412!K3412_cdUnitPrice)
            If IsdbNull(rs3412!K3412_seTax) = False Then D3412.seTax = Trim$(rs3412!K3412_seTax)
            If IsdbNull(rs3412!K3412_cdTax) = False Then D3412.cdTax = Trim$(rs3412!K3412_cdTax)
            If IsdbNull(rs3412!K3412_seUnitMaterial) = False Then D3412.seUnitMaterial = Trim$(rs3412!K3412_seUnitMaterial)
            If IsdbNull(rs3412!K3412_cdUnitMaterial) = False Then D3412.cdUnitMaterial = Trim$(rs3412!K3412_cdUnitMaterial)
            If IsdbNull(rs3412!K3412_seUnitPacking) = False Then D3412.seUnitPacking = Trim$(rs3412!K3412_seUnitPacking)
            If IsdbNull(rs3412!K3412_cdUnitPacking) = False Then D3412.cdUnitPacking = Trim$(rs3412!K3412_cdUnitPacking)
            If IsdbNull(rs3412!K3412_UnitBaseCheck) = False Then D3412.UnitBaseCheck = Trim$(rs3412!K3412_UnitBaseCheck)
            If IsdbNull(rs3412!K3412_QtyBasic) = False Then D3412.QtyBasic = Trim$(rs3412!K3412_QtyBasic)
            If IsdbNull(rs3412!K3412_PricePurchasing) = False Then D3412.PricePurchasing = Trim$(rs3412!K3412_PricePurchasing)
            If IsdbNull(rs3412!K3412_PriceMarket) = False Then D3412.PriceMarket = Trim$(rs3412!K3412_PriceMarket)
            If IsdbNull(rs3412!K3412_PriceExchangeAP) = False Then D3412.PriceExchangeAP = Trim$(rs3412!K3412_PriceExchangeAP)
            If IsdbNull(rs3412!K3412_PriceExchange) = False Then D3412.PriceExchange = Trim$(rs3412!K3412_PriceExchange)
            If IsdbNull(rs3412!K3412_DateExchange) = False Then D3412.DateExchange = Trim$(rs3412!K3412_DateExchange)
            If IsdbNull(rs3412!K3412_PricePurchasingEX) = False Then D3412.PricePurchasingEX = Trim$(rs3412!K3412_PricePurchasingEX)
            If IsdbNull(rs3412!K3412_PriceMarketEX) = False Then D3412.PriceMarketEX = Trim$(rs3412!K3412_PriceMarketEX)
            If IsdbNull(rs3412!K3412_PricePurchasingVND) = False Then D3412.PricePurchasingVND = Trim$(rs3412!K3412_PricePurchasingVND)
            If IsdbNull(rs3412!K3412_PriceMarketVND) = False Then D3412.PriceMarketVND = Trim$(rs3412!K3412_PriceMarketVND)
            If IsdbNull(rs3412!K3412_AmountPurchasingEX) = False Then D3412.AmountPurchasingEX = Trim$(rs3412!K3412_AmountPurchasingEX)
            If IsdbNull(rs3412!K3412_AmountPurchasingVND) = False Then D3412.AmountPurchasingVND = Trim$(rs3412!K3412_AmountPurchasingVND)
            If IsdbNull(rs3412!K3412_AmountTaxEX) = False Then D3412.AmountTaxEX = Trim$(rs3412!K3412_AmountTaxEX)
            If IsdbNull(rs3412!K3412_AmountTaxVND) = False Then D3412.AmountTaxVND = Trim$(rs3412!K3412_AmountTaxVND)
            If IsdbNull(rs3412!K3412_seTax1) = False Then D3412.seTax1 = Trim$(rs3412!K3412_seTax1)
            If IsdbNull(rs3412!K3412_cdTax1) = False Then D3412.cdTax1 = Trim$(rs3412!K3412_cdTax1)
            If IsdbNull(rs3412!K3412_PerTax1) = False Then D3412.PerTax1 = Trim$(rs3412!K3412_PerTax1)
            If IsdbNull(rs3412!K3412_AmountTax1EX) = False Then D3412.AmountTax1EX = Trim$(rs3412!K3412_AmountTax1EX)
            If IsdbNull(rs3412!K3412_AmountTax1) = False Then D3412.AmountTax1 = Trim$(rs3412!K3412_AmountTax1)
            If IsdbNull(rs3412!K3412_seTax2) = False Then D3412.seTax2 = Trim$(rs3412!K3412_seTax2)
            If IsdbNull(rs3412!K3412_cdTax2) = False Then D3412.cdTax2 = Trim$(rs3412!K3412_cdTax2)
            If IsdbNull(rs3412!K3412_PerTax2) = False Then D3412.PerTax2 = Trim$(rs3412!K3412_PerTax2)
            If IsdbNull(rs3412!K3412_AmountTax2EX) = False Then D3412.AmountTax2EX = Trim$(rs3412!K3412_AmountTax2EX)
            If IsdbNull(rs3412!K3412_AmountTax2) = False Then D3412.AmountTax2 = Trim$(rs3412!K3412_AmountTax2)
            If IsdbNull(rs3412!K3412_seTax3) = False Then D3412.seTax3 = Trim$(rs3412!K3412_seTax3)
            If IsdbNull(rs3412!K3412_cdTax3) = False Then D3412.cdTax3 = Trim$(rs3412!K3412_cdTax3)
            If IsdbNull(rs3412!K3412_PerTax3) = False Then D3412.PerTax3 = Trim$(rs3412!K3412_PerTax3)
            If IsdbNull(rs3412!K3412_AmountTax3EX) = False Then D3412.AmountTax3EX = Trim$(rs3412!K3412_AmountTax3EX)
            If IsdbNull(rs3412!K3412_AmountTax3) = False Then D3412.AmountTax3 = Trim$(rs3412!K3412_AmountTax3)
            If IsdbNull(rs3412!K3412_QtyBooking) = False Then D3412.QtyBooking = Trim$(rs3412!K3412_QtyBooking)
            If IsdbNull(rs3412!K3412_QtyPurchasingNet) = False Then D3412.QtyPurchasingNet = Trim$(rs3412!K3412_QtyPurchasingNet)
            If IsdbNull(rs3412!K3412_QtyPurchasingMOQ) = False Then D3412.QtyPurchasingMOQ = Trim$(rs3412!K3412_QtyPurchasingMOQ)
            If IsdbNull(rs3412!K3412_QtyPurchasing) = False Then D3412.QtyPurchasing = Trim$(rs3412!K3412_QtyPurchasing)
            If IsdbNull(rs3412!K3412_PackPurchasing) = False Then D3412.PackPurchasing = Trim$(rs3412!K3412_PackPurchasing)
            If IsdbNull(rs3412!K3412_AmountPSC) = False Then D3412.AmountPSC = Trim$(rs3412!K3412_AmountPSC)
            If IsdbNull(rs3412!K3412_AmountEX) = False Then D3412.AmountEX = Trim$(rs3412!K3412_AmountEX)
            If IsdbNull(rs3412!K3412_AmountVND) = False Then D3412.AmountVND = Trim$(rs3412!K3412_AmountVND)
            If IsdbNull(rs3412!K3412_AmountNoVATEX) = False Then D3412.AmountNoVATEX = Trim$(rs3412!K3412_AmountNoVATEX)
            If IsdbNull(rs3412!K3412_AmountNoVATVND) = False Then D3412.AmountNoVATVND = Trim$(rs3412!K3412_AmountNoVATVND)
            If IsdbNull(rs3412!K3412_AmountTotalEX) = False Then D3412.AmountTotalEX = Trim$(rs3412!K3412_AmountTotalEX)
            If IsdbNull(rs3412!K3412_AmountTotalVND) = False Then D3412.AmountTotalVND = Trim$(rs3412!K3412_AmountTotalVND)
            If IsdbNull(rs3412!K3412_TotalQtyPurchasing) = False Then D3412.TotalQtyPurchasing = Trim$(rs3412!K3412_TotalQtyPurchasing)
            If IsdbNull(rs3412!K3412_TotalPackPurchasing) = False Then D3412.TotalPackPurchasing = Trim$(rs3412!K3412_TotalPackPurchasing)
            If IsdbNull(rs3412!K3412_QtyWarehouse) = False Then D3412.QtyWarehouse = Trim$(rs3412!K3412_QtyWarehouse)
            If IsdbNull(rs3412!K3412_PackWarehouse) = False Then D3412.PackWarehouse = Trim$(rs3412!K3412_PackWarehouse)
            If IsdbNull(rs3412!K3412_DateDelivery) = False Then D3412.DateDelivery = Trim$(rs3412!K3412_DateDelivery)
            If IsdbNull(rs3412!K3412_DateStart) = False Then D3412.DateStart = Trim$(rs3412!K3412_DateStart)
            If IsdbNull(rs3412!K3412_DateFinish) = False Then D3412.DateFinish = Trim$(rs3412!K3412_DateFinish)
            If IsdbNull(rs3412!K3412_CheckPurchasing) = False Then D3412.CheckPurchasing = Trim$(rs3412!K3412_CheckPurchasing)
            If IsdbNull(rs3412!K3412_DateAccept) = False Then D3412.DateAccept = Trim$(rs3412!K3412_DateAccept)
            If IsdbNull(rs3412!K3412_DatePosted) = False Then D3412.DatePosted = Trim$(rs3412!K3412_DatePosted)
            If IsdbNull(rs3412!K3412_IsPosted) = False Then D3412.IsPosted = Trim$(rs3412!K3412_IsPosted)
            If IsdbNull(rs3412!K3412_DateComplete) = False Then D3412.DateComplete = Trim$(rs3412!K3412_DateComplete)
            If IsdbNull(rs3412!K3412_DateApproval) = False Then D3412.DateApproval = Trim$(rs3412!K3412_DateApproval)
            If IsdbNull(rs3412!K3412_DateCancel) = False Then D3412.DateCancel = Trim$(rs3412!K3412_DateCancel)
            If IsdbNull(rs3412!K3412_CheckComplete) = False Then D3412.CheckComplete = Trim$(rs3412!K3412_CheckComplete)
            If IsdbNull(rs3412!K3412_PurchasingRequestNo) = False Then D3412.PurchasingRequestNo = Trim$(rs3412!K3412_PurchasingRequestNo)
            If IsdbNull(rs3412!K3412_PurchasingRequestSeq) = False Then D3412.PurchasingRequestSeq = Trim$(rs3412!K3412_PurchasingRequestSeq)
            If IsdbNull(rs3412!K3412_OrderNo) = False Then D3412.OrderNo = Trim$(rs3412!K3412_OrderNo)
            If IsdbNull(rs3412!K3412_OrderNoSeq) = False Then D3412.OrderNoSeq = Trim$(rs3412!K3412_OrderNoSeq)
            If IsdbNull(rs3412!K3412_PurchasingOrderNo_Bf) = False Then D3412.PurchasingOrderNo_Bf = Trim$(rs3412!K3412_PurchasingOrderNo_Bf)
            If IsdbNull(rs3412!K3412_PurchasingOrderSeq_Bf) = False Then D3412.PurchasingOrderSeq_Bf = Trim$(rs3412!K3412_PurchasingOrderSeq_Bf)
            If IsdbNull(rs3412!K3412_Remark) = False Then D3412.Remark = Trim$(rs3412!K3412_Remark)
            If IsdbNull(rs3412!K3412_TimeInsert) = False Then D3412.TimeInsert = Trim$(rs3412!K3412_TimeInsert)
            If IsdbNull(rs3412!K3412_TimeUpdate) = False Then D3412.TimeUpdate = Trim$(rs3412!K3412_TimeUpdate)
            If IsdbNull(rs3412!K3412_DateInsert) = False Then D3412.DateInsert = Trim$(rs3412!K3412_DateInsert)
            If IsdbNull(rs3412!K3412_DateUpdate) = False Then D3412.DateUpdate = Trim$(rs3412!K3412_DateUpdate)
            If IsdbNull(rs3412!K3412_InchargeInsert) = False Then D3412.InchargeInsert = Trim$(rs3412!K3412_InchargeInsert)
            If IsdbNull(rs3412!K3412_InchargeUpdate) = False Then D3412.InchargeUpdate = Trim$(rs3412!K3412_InchargeUpdate)
            If IsdbNull(rs3412!K3412_PriceAPurchasing) = False Then D3412.PriceAPurchasing = Trim$(rs3412!K3412_PriceAPurchasing)
            If IsdbNull(rs3412!K3412_cdUnitMaterialA) = False Then D3412.cdUnitMaterialA = Trim$(rs3412!K3412_cdUnitMaterialA)
            If IsdbNull(rs3412!K3412_cdUnitPriceA) = False Then D3412.cdUnitPriceA = Trim$(rs3412!K3412_cdUnitPriceA)
            If IsdbNull(rs3412!K3412_QtyAPurchasing) = False Then D3412.QtyAPurchasing = Trim$(rs3412!K3412_QtyAPurchasing)
            If IsdbNull(rs3412!K3412_QtyATotal) = False Then D3412.QtyATotal = Trim$(rs3412!K3412_QtyATotal)
            If IsdbNull(rs3412!K3412_AmtAPurchasing) = False Then D3412.AmtAPurchasing = Trim$(rs3412!K3412_AmtAPurchasing)
            If IsdbNull(rs3412!K3412_AmtATotal) = False Then D3412.AmtATotal = Trim$(rs3412!K3412_AmtATotal)
            If IsdbNull(rs3412!K3412_InvoiceNo1) = False Then D3412.InvoiceNo1 = Trim$(rs3412!K3412_InvoiceNo1)
            If IsdbNull(rs3412!K3412_InvoiceNo2) = False Then D3412.InvoiceNo2 = Trim$(rs3412!K3412_InvoiceNo2)
            If IsdbNull(rs3412!K3412_InvoiceNo3) = False Then D3412.InvoiceNo3 = Trim$(rs3412!K3412_InvoiceNo3)
            If IsdbNull(rs3412!K3412_InvoiceNo4) = False Then D3412.InvoiceNo4 = Trim$(rs3412!K3412_InvoiceNo4)
            If IsDBNull(rs3412!K3412_InvoiceNo5) = False Then D3412.InvoiceNo5 = Trim$(rs3412!K3412_InvoiceNo5)
            If IsDBNull(rs3412!K3412_InvoiceNo6) = False Then D3412.InvoiceNo6 = Trim$(rs3412!K3412_InvoiceNo6)
            If IsDBNull(rs3412!K3412_InvoiceNo7) = False Then D3412.InvoiceNo7 = Trim$(rs3412!K3412_InvoiceNo7)
            If IsDBNull(rs3412!K3412_InvoiceNo8) = False Then D3412.InvoiceNo8 = Trim$(rs3412!K3412_InvoiceNo8)
            If IsDBNull(rs3412!K3412_InvoiceNo9) = False Then D3412.InvoiceNo9 = Trim$(rs3412!K3412_InvoiceNo9)
            If IsDBNull(rs3412!K3412_InvoiceNo10) = False Then D3412.InvoiceNo10 = Trim$(rs3412!K3412_InvoiceNo10)
            If IsdbNull(rs3412!K3412_DateArrive1) = False Then D3412.DateArrive1 = Trim$(rs3412!K3412_DateArrive1)
            If IsdbNull(rs3412!K3412_DateArrive2) = False Then D3412.DateArrive2 = Trim$(rs3412!K3412_DateArrive2)
            If IsdbNull(rs3412!K3412_DateArrive3) = False Then D3412.DateArrive3 = Trim$(rs3412!K3412_DateArrive3)
            If IsdbNull(rs3412!K3412_DateArrive4) = False Then D3412.DateArrive4 = Trim$(rs3412!K3412_DateArrive4)
            If IsDBNull(rs3412!K3412_DateArrive5) = False Then D3412.DateArrive5 = Trim$(rs3412!K3412_DateArrive5)
            If IsDBNull(rs3412!K3412_DateArrive6) = False Then D3412.DateArrive6 = Trim$(rs3412!K3412_DateArrive6)
            If IsDBNull(rs3412!K3412_DateArrive7) = False Then D3412.DateArrive7 = Trim$(rs3412!K3412_DateArrive7)
            If IsDBNull(rs3412!K3412_DateArrive8) = False Then D3412.DateArrive8 = Trim$(rs3412!K3412_DateArrive8)
            If IsDBNull(rs3412!K3412_DateArrive9) = False Then D3412.DateArrive9 = Trim$(rs3412!K3412_DateArrive9)
            If IsDBNull(rs3412!K3412_DateArrive10) = False Then D3412.DateArrive10 = Trim$(rs3412!K3412_DateArrive10)

            If IsdbNull(rs3412!K3412_QtyAArrive1) = False Then D3412.QtyAArrive1 = Trim$(rs3412!K3412_QtyAArrive1)
            If IsdbNull(rs3412!K3412_QtyAArrive2) = False Then D3412.QtyAArrive2 = Trim$(rs3412!K3412_QtyAArrive2)
            If IsdbNull(rs3412!K3412_QtyAArrive3) = False Then D3412.QtyAArrive3 = Trim$(rs3412!K3412_QtyAArrive3)
            If IsdbNull(rs3412!K3412_QtyAArrive4) = False Then D3412.QtyAArrive4 = Trim$(rs3412!K3412_QtyAArrive4)
            If IsDBNull(rs3412!K3412_QtyAArrive5) = False Then D3412.QtyAArrive5 = Trim$(rs3412!K3412_QtyAArrive5)
            If IsDBNull(rs3412!K3412_QtyAArrive6) = False Then D3412.QtyAArrive6 = Trim$(rs3412!K3412_QtyAArrive6)
            If IsDBNull(rs3412!K3412_QtyAArrive7) = False Then D3412.QtyAArrive7 = Trim$(rs3412!K3412_QtyAArrive7)
            If IsDBNull(rs3412!K3412_QtyAArrive8) = False Then D3412.QtyAArrive8 = Trim$(rs3412!K3412_QtyAArrive8)
            If IsDBNull(rs3412!K3412_QtyAArrive9) = False Then D3412.QtyAArrive9 = Trim$(rs3412!K3412_QtyAArrive9)
            If IsDBNull(rs3412!K3412_QtyAArrive10) = False Then D3412.QtyAArrive10 = Trim$(rs3412!K3412_QtyAArrive10)

            If IsdbNull(rs3412!K3412_InchargeInvoice) = False Then D3412.InchargeInvoice = Trim$(rs3412!K3412_InchargeInvoice)
            If IsdbNull(rs3412!K3412_APLName) = False Then D3412.APLName = Trim$(rs3412!K3412_APLName)
            If IsdbNull(rs3412!K3412_AInvoice) = False Then D3412.AInvoice = Trim$(rs3412!K3412_AInvoice)
            If IsdbNull(rs3412!K3412_ARemark) = False Then D3412.ARemark = Trim$(rs3412!K3412_ARemark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K3412_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K3412_MOVE(rs3412 As DataRow)
        Try

            Call D3412_CLEAR()

            If IsdbNull(rs3412!K3412_PurchasingOrderNo) = False Then D3412.PurchasingOrderNo = Trim$(rs3412!K3412_PurchasingOrderNo)
            If IsdbNull(rs3412!K3412_PurchasingOrderSeq) = False Then D3412.PurchasingOrderSeq = Trim$(rs3412!K3412_PurchasingOrderSeq)
            If IsdbNull(rs3412!K3412_seSite) = False Then D3412.seSite = Trim$(rs3412!K3412_seSite)
            If IsdbNull(rs3412!K3412_cdSite) = False Then D3412.cdSite = Trim$(rs3412!K3412_cdSite)
            If IsdbNull(rs3412!K3412_seDepartment) = False Then D3412.seDepartment = Trim$(rs3412!K3412_seDepartment)
            If IsdbNull(rs3412!K3412_cdDepartment) = False Then D3412.cdDepartment = Trim$(rs3412!K3412_cdDepartment)
            If IsdbNull(rs3412!K3412_seFactory) = False Then D3412.seFactory = Trim$(rs3412!K3412_seFactory)
            If IsdbNull(rs3412!K3412_cdFactory) = False Then D3412.cdFactory = Trim$(rs3412!K3412_cdFactory)
            If IsdbNull(rs3412!K3412_CustomerSupplier) = False Then D3412.CustomerSupplier = Trim$(rs3412!K3412_CustomerSupplier)
            If IsdbNull(rs3412!K3412_Dseq) = False Then D3412.Dseq = Trim$(rs3412!K3412_Dseq)
            If IsdbNull(rs3412!K3412_AutokeyK3011) = False Then D3412.AutokeyK3011 = Trim$(rs3412!K3412_AutokeyK3011)
            If IsdbNull(rs3412!K3412_CheckRelationType) = False Then D3412.CheckRelationType = Trim$(rs3412!K3412_CheckRelationType)
            If IsdbNull(rs3412!K3412_MaterialCode) = False Then D3412.MaterialCode = Trim$(rs3412!K3412_MaterialCode)
            If IsdbNull(rs3412!K3412_Specification) = False Then D3412.Specification = Trim$(rs3412!K3412_Specification)
            If IsdbNull(rs3412!K3412_Width) = False Then D3412.Width = Trim$(rs3412!K3412_Width)
            If IsdbNull(rs3412!K3412_Height) = False Then D3412.Height = Trim$(rs3412!K3412_Height)
            If IsdbNull(rs3412!K3412_SizeNo) = False Then D3412.SizeNo = Trim$(rs3412!K3412_SizeNo)
            If IsdbNull(rs3412!K3412_SizeName) = False Then D3412.SizeName = Trim$(rs3412!K3412_SizeName)
            If IsdbNull(rs3412!K3412_ColorCode) = False Then D3412.ColorCode = Trim$(rs3412!K3412_ColorCode)
            If IsdbNull(rs3412!K3412_ColorName) = False Then D3412.ColorName = Trim$(rs3412!K3412_ColorName)
            If IsdbNull(rs3412!K3412_seOrigin) = False Then D3412.seOrigin = Trim$(rs3412!K3412_seOrigin)
            If IsdbNull(rs3412!K3412_cdOrigin) = False Then D3412.cdOrigin = Trim$(rs3412!K3412_cdOrigin)
            If IsdbNull(rs3412!K3412_MaterialCheck) = False Then D3412.MaterialCheck = Trim$(rs3412!K3412_MaterialCheck)
            If IsdbNull(rs3412!K3412_seUnitPrice) = False Then D3412.seUnitPrice = Trim$(rs3412!K3412_seUnitPrice)
            If IsdbNull(rs3412!K3412_cdUnitPrice) = False Then D3412.cdUnitPrice = Trim$(rs3412!K3412_cdUnitPrice)
            If IsdbNull(rs3412!K3412_seTax) = False Then D3412.seTax = Trim$(rs3412!K3412_seTax)
            If IsdbNull(rs3412!K3412_cdTax) = False Then D3412.cdTax = Trim$(rs3412!K3412_cdTax)
            If IsdbNull(rs3412!K3412_seUnitMaterial) = False Then D3412.seUnitMaterial = Trim$(rs3412!K3412_seUnitMaterial)
            If IsdbNull(rs3412!K3412_cdUnitMaterial) = False Then D3412.cdUnitMaterial = Trim$(rs3412!K3412_cdUnitMaterial)
            If IsdbNull(rs3412!K3412_seUnitPacking) = False Then D3412.seUnitPacking = Trim$(rs3412!K3412_seUnitPacking)
            If IsdbNull(rs3412!K3412_cdUnitPacking) = False Then D3412.cdUnitPacking = Trim$(rs3412!K3412_cdUnitPacking)
            If IsdbNull(rs3412!K3412_UnitBaseCheck) = False Then D3412.UnitBaseCheck = Trim$(rs3412!K3412_UnitBaseCheck)
            If IsdbNull(rs3412!K3412_QtyBasic) = False Then D3412.QtyBasic = Trim$(rs3412!K3412_QtyBasic)
            If IsdbNull(rs3412!K3412_PricePurchasing) = False Then D3412.PricePurchasing = Trim$(rs3412!K3412_PricePurchasing)
            If IsdbNull(rs3412!K3412_PriceMarket) = False Then D3412.PriceMarket = Trim$(rs3412!K3412_PriceMarket)
            If IsdbNull(rs3412!K3412_PriceExchangeAP) = False Then D3412.PriceExchangeAP = Trim$(rs3412!K3412_PriceExchangeAP)
            If IsdbNull(rs3412!K3412_PriceExchange) = False Then D3412.PriceExchange = Trim$(rs3412!K3412_PriceExchange)
            If IsdbNull(rs3412!K3412_DateExchange) = False Then D3412.DateExchange = Trim$(rs3412!K3412_DateExchange)
            If IsdbNull(rs3412!K3412_PricePurchasingEX) = False Then D3412.PricePurchasingEX = Trim$(rs3412!K3412_PricePurchasingEX)
            If IsdbNull(rs3412!K3412_PriceMarketEX) = False Then D3412.PriceMarketEX = Trim$(rs3412!K3412_PriceMarketEX)
            If IsdbNull(rs3412!K3412_PricePurchasingVND) = False Then D3412.PricePurchasingVND = Trim$(rs3412!K3412_PricePurchasingVND)
            If IsdbNull(rs3412!K3412_PriceMarketVND) = False Then D3412.PriceMarketVND = Trim$(rs3412!K3412_PriceMarketVND)
            If IsdbNull(rs3412!K3412_AmountPurchasingEX) = False Then D3412.AmountPurchasingEX = Trim$(rs3412!K3412_AmountPurchasingEX)
            If IsdbNull(rs3412!K3412_AmountPurchasingVND) = False Then D3412.AmountPurchasingVND = Trim$(rs3412!K3412_AmountPurchasingVND)
            If IsdbNull(rs3412!K3412_AmountTaxEX) = False Then D3412.AmountTaxEX = Trim$(rs3412!K3412_AmountTaxEX)
            If IsdbNull(rs3412!K3412_AmountTaxVND) = False Then D3412.AmountTaxVND = Trim$(rs3412!K3412_AmountTaxVND)
            If IsdbNull(rs3412!K3412_seTax1) = False Then D3412.seTax1 = Trim$(rs3412!K3412_seTax1)
            If IsdbNull(rs3412!K3412_cdTax1) = False Then D3412.cdTax1 = Trim$(rs3412!K3412_cdTax1)
            If IsdbNull(rs3412!K3412_PerTax1) = False Then D3412.PerTax1 = Trim$(rs3412!K3412_PerTax1)
            If IsdbNull(rs3412!K3412_AmountTax1EX) = False Then D3412.AmountTax1EX = Trim$(rs3412!K3412_AmountTax1EX)
            If IsdbNull(rs3412!K3412_AmountTax1) = False Then D3412.AmountTax1 = Trim$(rs3412!K3412_AmountTax1)
            If IsdbNull(rs3412!K3412_seTax2) = False Then D3412.seTax2 = Trim$(rs3412!K3412_seTax2)
            If IsdbNull(rs3412!K3412_cdTax2) = False Then D3412.cdTax2 = Trim$(rs3412!K3412_cdTax2)
            If IsdbNull(rs3412!K3412_PerTax2) = False Then D3412.PerTax2 = Trim$(rs3412!K3412_PerTax2)
            If IsdbNull(rs3412!K3412_AmountTax2EX) = False Then D3412.AmountTax2EX = Trim$(rs3412!K3412_AmountTax2EX)
            If IsdbNull(rs3412!K3412_AmountTax2) = False Then D3412.AmountTax2 = Trim$(rs3412!K3412_AmountTax2)
            If IsdbNull(rs3412!K3412_seTax3) = False Then D3412.seTax3 = Trim$(rs3412!K3412_seTax3)
            If IsdbNull(rs3412!K3412_cdTax3) = False Then D3412.cdTax3 = Trim$(rs3412!K3412_cdTax3)
            If IsdbNull(rs3412!K3412_PerTax3) = False Then D3412.PerTax3 = Trim$(rs3412!K3412_PerTax3)
            If IsdbNull(rs3412!K3412_AmountTax3EX) = False Then D3412.AmountTax3EX = Trim$(rs3412!K3412_AmountTax3EX)
            If IsdbNull(rs3412!K3412_AmountTax3) = False Then D3412.AmountTax3 = Trim$(rs3412!K3412_AmountTax3)
            If IsdbNull(rs3412!K3412_QtyBooking) = False Then D3412.QtyBooking = Trim$(rs3412!K3412_QtyBooking)
            If IsdbNull(rs3412!K3412_QtyPurchasingNet) = False Then D3412.QtyPurchasingNet = Trim$(rs3412!K3412_QtyPurchasingNet)
            If IsdbNull(rs3412!K3412_QtyPurchasingMOQ) = False Then D3412.QtyPurchasingMOQ = Trim$(rs3412!K3412_QtyPurchasingMOQ)
            If IsdbNull(rs3412!K3412_QtyPurchasing) = False Then D3412.QtyPurchasing = Trim$(rs3412!K3412_QtyPurchasing)
            If IsdbNull(rs3412!K3412_PackPurchasing) = False Then D3412.PackPurchasing = Trim$(rs3412!K3412_PackPurchasing)
            If IsdbNull(rs3412!K3412_AmountPSC) = False Then D3412.AmountPSC = Trim$(rs3412!K3412_AmountPSC)
            If IsdbNull(rs3412!K3412_AmountEX) = False Then D3412.AmountEX = Trim$(rs3412!K3412_AmountEX)
            If IsdbNull(rs3412!K3412_AmountVND) = False Then D3412.AmountVND = Trim$(rs3412!K3412_AmountVND)
            If IsdbNull(rs3412!K3412_AmountNoVATEX) = False Then D3412.AmountNoVATEX = Trim$(rs3412!K3412_AmountNoVATEX)
            If IsdbNull(rs3412!K3412_AmountNoVATVND) = False Then D3412.AmountNoVATVND = Trim$(rs3412!K3412_AmountNoVATVND)
            If IsdbNull(rs3412!K3412_AmountTotalEX) = False Then D3412.AmountTotalEX = Trim$(rs3412!K3412_AmountTotalEX)
            If IsdbNull(rs3412!K3412_AmountTotalVND) = False Then D3412.AmountTotalVND = Trim$(rs3412!K3412_AmountTotalVND)
            If IsdbNull(rs3412!K3412_TotalQtyPurchasing) = False Then D3412.TotalQtyPurchasing = Trim$(rs3412!K3412_TotalQtyPurchasing)
            If IsdbNull(rs3412!K3412_TotalPackPurchasing) = False Then D3412.TotalPackPurchasing = Trim$(rs3412!K3412_TotalPackPurchasing)
            If IsdbNull(rs3412!K3412_QtyWarehouse) = False Then D3412.QtyWarehouse = Trim$(rs3412!K3412_QtyWarehouse)
            If IsdbNull(rs3412!K3412_PackWarehouse) = False Then D3412.PackWarehouse = Trim$(rs3412!K3412_PackWarehouse)
            If IsdbNull(rs3412!K3412_DateDelivery) = False Then D3412.DateDelivery = Trim$(rs3412!K3412_DateDelivery)
            If IsdbNull(rs3412!K3412_DateStart) = False Then D3412.DateStart = Trim$(rs3412!K3412_DateStart)
            If IsdbNull(rs3412!K3412_DateFinish) = False Then D3412.DateFinish = Trim$(rs3412!K3412_DateFinish)
            If IsdbNull(rs3412!K3412_CheckPurchasing) = False Then D3412.CheckPurchasing = Trim$(rs3412!K3412_CheckPurchasing)
            If IsdbNull(rs3412!K3412_DateAccept) = False Then D3412.DateAccept = Trim$(rs3412!K3412_DateAccept)
            If IsdbNull(rs3412!K3412_DatePosted) = False Then D3412.DatePosted = Trim$(rs3412!K3412_DatePosted)
            If IsdbNull(rs3412!K3412_IsPosted) = False Then D3412.IsPosted = Trim$(rs3412!K3412_IsPosted)
            If IsdbNull(rs3412!K3412_DateComplete) = False Then D3412.DateComplete = Trim$(rs3412!K3412_DateComplete)
            If IsdbNull(rs3412!K3412_DateApproval) = False Then D3412.DateApproval = Trim$(rs3412!K3412_DateApproval)
            If IsdbNull(rs3412!K3412_DateCancel) = False Then D3412.DateCancel = Trim$(rs3412!K3412_DateCancel)
            If IsdbNull(rs3412!K3412_CheckComplete) = False Then D3412.CheckComplete = Trim$(rs3412!K3412_CheckComplete)
            If IsdbNull(rs3412!K3412_PurchasingRequestNo) = False Then D3412.PurchasingRequestNo = Trim$(rs3412!K3412_PurchasingRequestNo)
            If IsdbNull(rs3412!K3412_PurchasingRequestSeq) = False Then D3412.PurchasingRequestSeq = Trim$(rs3412!K3412_PurchasingRequestSeq)
            If IsdbNull(rs3412!K3412_OrderNo) = False Then D3412.OrderNo = Trim$(rs3412!K3412_OrderNo)
            If IsdbNull(rs3412!K3412_OrderNoSeq) = False Then D3412.OrderNoSeq = Trim$(rs3412!K3412_OrderNoSeq)
            If IsdbNull(rs3412!K3412_PurchasingOrderNo_Bf) = False Then D3412.PurchasingOrderNo_Bf = Trim$(rs3412!K3412_PurchasingOrderNo_Bf)
            If IsdbNull(rs3412!K3412_PurchasingOrderSeq_Bf) = False Then D3412.PurchasingOrderSeq_Bf = Trim$(rs3412!K3412_PurchasingOrderSeq_Bf)
            If IsdbNull(rs3412!K3412_Remark) = False Then D3412.Remark = Trim$(rs3412!K3412_Remark)
            If IsdbNull(rs3412!K3412_TimeInsert) = False Then D3412.TimeInsert = Trim$(rs3412!K3412_TimeInsert)
            If IsdbNull(rs3412!K3412_TimeUpdate) = False Then D3412.TimeUpdate = Trim$(rs3412!K3412_TimeUpdate)
            If IsdbNull(rs3412!K3412_DateInsert) = False Then D3412.DateInsert = Trim$(rs3412!K3412_DateInsert)
            If IsdbNull(rs3412!K3412_DateUpdate) = False Then D3412.DateUpdate = Trim$(rs3412!K3412_DateUpdate)
            If IsdbNull(rs3412!K3412_InchargeInsert) = False Then D3412.InchargeInsert = Trim$(rs3412!K3412_InchargeInsert)
            If IsdbNull(rs3412!K3412_InchargeUpdate) = False Then D3412.InchargeUpdate = Trim$(rs3412!K3412_InchargeUpdate)
            If IsdbNull(rs3412!K3412_PriceAPurchasing) = False Then D3412.PriceAPurchasing = Trim$(rs3412!K3412_PriceAPurchasing)
            If IsdbNull(rs3412!K3412_cdUnitMaterialA) = False Then D3412.cdUnitMaterialA = Trim$(rs3412!K3412_cdUnitMaterialA)
            If IsdbNull(rs3412!K3412_cdUnitPriceA) = False Then D3412.cdUnitPriceA = Trim$(rs3412!K3412_cdUnitPriceA)
            If IsdbNull(rs3412!K3412_QtyAPurchasing) = False Then D3412.QtyAPurchasing = Trim$(rs3412!K3412_QtyAPurchasing)
            If IsdbNull(rs3412!K3412_QtyATotal) = False Then D3412.QtyATotal = Trim$(rs3412!K3412_QtyATotal)
            If IsdbNull(rs3412!K3412_AmtAPurchasing) = False Then D3412.AmtAPurchasing = Trim$(rs3412!K3412_AmtAPurchasing)
            If IsdbNull(rs3412!K3412_AmtATotal) = False Then D3412.AmtATotal = Trim$(rs3412!K3412_AmtATotal)
            If IsdbNull(rs3412!K3412_InvoiceNo1) = False Then D3412.InvoiceNo1 = Trim$(rs3412!K3412_InvoiceNo1)
            If IsdbNull(rs3412!K3412_InvoiceNo2) = False Then D3412.InvoiceNo2 = Trim$(rs3412!K3412_InvoiceNo2)
            If IsdbNull(rs3412!K3412_InvoiceNo3) = False Then D3412.InvoiceNo3 = Trim$(rs3412!K3412_InvoiceNo3)
            If IsdbNull(rs3412!K3412_InvoiceNo4) = False Then D3412.InvoiceNo4 = Trim$(rs3412!K3412_InvoiceNo4)
            If IsDBNull(rs3412!K3412_InvoiceNo5) = False Then D3412.InvoiceNo5 = Trim$(rs3412!K3412_InvoiceNo5)
            If IsDBNull(rs3412!K3412_InvoiceNo6) = False Then D3412.InvoiceNo6 = Trim$(rs3412!K3412_InvoiceNo6)
            If IsDBNull(rs3412!K3412_InvoiceNo7) = False Then D3412.InvoiceNo7 = Trim$(rs3412!K3412_InvoiceNo7)
            If IsDBNull(rs3412!K3412_InvoiceNo8) = False Then D3412.InvoiceNo8 = Trim$(rs3412!K3412_InvoiceNo8)
            If IsDBNull(rs3412!K3412_InvoiceNo9) = False Then D3412.InvoiceNo9 = Trim$(rs3412!K3412_InvoiceNo9)
            If IsDBNull(rs3412!K3412_InvoiceNo10) = False Then D3412.InvoiceNo10 = Trim$(rs3412!K3412_InvoiceNo10)

            If IsdbNull(rs3412!K3412_DateArrive1) = False Then D3412.DateArrive1 = Trim$(rs3412!K3412_DateArrive1)
            If IsdbNull(rs3412!K3412_DateArrive2) = False Then D3412.DateArrive2 = Trim$(rs3412!K3412_DateArrive2)
            If IsdbNull(rs3412!K3412_DateArrive3) = False Then D3412.DateArrive3 = Trim$(rs3412!K3412_DateArrive3)
            If IsdbNull(rs3412!K3412_DateArrive4) = False Then D3412.DateArrive4 = Trim$(rs3412!K3412_DateArrive4)
            If IsDBNull(rs3412!K3412_DateArrive5) = False Then D3412.DateArrive5 = Trim$(rs3412!K3412_DateArrive5)
            If IsDBNull(rs3412!K3412_DateArrive6) = False Then D3412.DateArrive6 = Trim$(rs3412!K3412_DateArrive6)
            If IsDBNull(rs3412!K3412_DateArrive7) = False Then D3412.DateArrive7 = Trim$(rs3412!K3412_DateArrive7)
            If IsDBNull(rs3412!K3412_DateArrive8) = False Then D3412.DateArrive8 = Trim$(rs3412!K3412_DateArrive8)
            If IsDBNull(rs3412!K3412_DateArrive9) = False Then D3412.DateArrive9 = Trim$(rs3412!K3412_DateArrive9)
            If IsDBNull(rs3412!K3412_DateArrive10) = False Then D3412.DateArrive10 = Trim$(rs3412!K3412_DateArrive10)

            If IsdbNull(rs3412!K3412_QtyAArrive1) = False Then D3412.QtyAArrive1 = Trim$(rs3412!K3412_QtyAArrive1)
            If IsdbNull(rs3412!K3412_QtyAArrive2) = False Then D3412.QtyAArrive2 = Trim$(rs3412!K3412_QtyAArrive2)
            If IsdbNull(rs3412!K3412_QtyAArrive3) = False Then D3412.QtyAArrive3 = Trim$(rs3412!K3412_QtyAArrive3)
            If IsdbNull(rs3412!K3412_QtyAArrive4) = False Then D3412.QtyAArrive4 = Trim$(rs3412!K3412_QtyAArrive4)
            If IsDBNull(rs3412!K3412_QtyAArrive5) = False Then D3412.QtyAArrive5 = Trim$(rs3412!K3412_QtyAArrive5)
            If IsDBNull(rs3412!K3412_QtyAArrive6) = False Then D3412.QtyAArrive6 = Trim$(rs3412!K3412_QtyAArrive6)
            If IsDBNull(rs3412!K3412_QtyAArrive7) = False Then D3412.QtyAArrive7 = Trim$(rs3412!K3412_QtyAArrive7)
            If IsDBNull(rs3412!K3412_QtyAArrive8) = False Then D3412.QtyAArrive8 = Trim$(rs3412!K3412_QtyAArrive8)
            If IsDBNull(rs3412!K3412_QtyAArrive9) = False Then D3412.QtyAArrive9 = Trim$(rs3412!K3412_QtyAArrive9)
            If IsDBNull(rs3412!K3412_QtyAArrive10) = False Then D3412.QtyAArrive10 = Trim$(rs3412!K3412_QtyAArrive10)

            If IsdbNull(rs3412!K3412_InchargeInvoice) = False Then D3412.InchargeInvoice = Trim$(rs3412!K3412_InchargeInvoice)
            If IsdbNull(rs3412!K3412_APLName) = False Then D3412.APLName = Trim$(rs3412!K3412_APLName)
            If IsdbNull(rs3412!K3412_AInvoice) = False Then D3412.AInvoice = Trim$(rs3412!K3412_AInvoice)
            If IsdbNull(rs3412!K3412_ARemark) = False Then D3412.ARemark = Trim$(rs3412!K3412_ARemark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K3412_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K3412_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z3412 As T3412_AREA, PURCHASINGORDERNO As String, PURCHASINGORDERSEQ As Double) As Boolean

        K3412_MOVE = False

        Try
            If READ_PFK3412(PURCHASINGORDERNO, PURCHASINGORDERSEQ) = True Then
                z3412 = D3412
                K3412_MOVE = True
            Else
                z3412 = Nothing
            End If

            If getColumnIndex(spr, "PurchasingOrderNo") > -1 Then z3412.PurchasingOrderNo = getDataM(spr, getColumnIndex(spr, "PurchasingOrderNo"), xRow)
            If getColumnIndex(spr, "PurchasingOrderSeq") > -1 Then z3412.PurchasingOrderSeq = Cdecp(getDataM(spr, getColumnIndex(spr, "PurchasingOrderSeq"), xRow))
            If getColumnIndex(spr, "seSite") > -1 Then z3412.seSite = getDataM(spr, getColumnIndex(spr, "seSite"), xRow)
            If getColumnIndex(spr, "cdSite") > -1 Then z3412.cdSite = getDataM(spr, getColumnIndex(spr, "cdSite"), xRow)
            If getColumnIndex(spr, "seDepartment") > -1 Then z3412.seDepartment = getDataM(spr, getColumnIndex(spr, "seDepartment"), xRow)
            If getColumnIndex(spr, "cdDepartment") > -1 Then z3412.cdDepartment = getDataM(spr, getColumnIndex(spr, "cdDepartment"), xRow)
            If getColumnIndex(spr, "seFactory") > -1 Then z3412.seFactory = getDataM(spr, getColumnIndex(spr, "seFactory"), xRow)
            If getColumnIndex(spr, "cdFactory") > -1 Then z3412.cdFactory = getDataM(spr, getColumnIndex(spr, "cdFactory"), xRow)
            If getColumnIndex(spr, "CustomerSupplier") > -1 Then z3412.CustomerSupplier = getDataM(spr, getColumnIndex(spr, "CustomerSupplier"), xRow)
            If getColumnIndex(spr, "Dseq") > -1 Then z3412.Dseq = Cdecp(getDataM(spr, getColumnIndex(spr, "Dseq"), xRow))
            If getColumnIndex(spr, "AutokeyK3011") > -1 Then z3412.AutokeyK3011 = Cdecp(getDataM(spr, getColumnIndex(spr, "AutokeyK3011"), xRow))
            If getColumnIndex(spr, "CheckRelationType") > -1 Then z3412.CheckRelationType = getDataM(spr, getColumnIndex(spr, "CheckRelationType"), xRow)
            If getColumnIndex(spr, "MaterialCode") > -1 Then z3412.MaterialCode = getDataM(spr, getColumnIndex(spr, "MaterialCode"), xRow)
            If getColumnIndex(spr, "Specification") > -1 Then z3412.Specification = getDataM(spr, getColumnIndex(spr, "Specification"), xRow)
            If getColumnIndex(spr, "Width") > -1 Then z3412.Width = getDataM(spr, getColumnIndex(spr, "Width"), xRow)
            If getColumnIndex(spr, "Height") > -1 Then z3412.Height = getDataM(spr, getColumnIndex(spr, "Height"), xRow)
            If getColumnIndex(spr, "SizeNo") > -1 Then z3412.SizeNo = getDataM(spr, getColumnIndex(spr, "SizeNo"), xRow)
            If getColumnIndex(spr, "SizeName") > -1 Then z3412.SizeName = getDataM(spr, getColumnIndex(spr, "SizeName"), xRow)
            If getColumnIndex(spr, "ColorCode") > -1 Then z3412.ColorCode = getDataM(spr, getColumnIndex(spr, "ColorCode"), xRow)
            If getColumnIndex(spr, "ColorName") > -1 Then z3412.ColorName = getDataM(spr, getColumnIndex(spr, "ColorName"), xRow)
            If getColumnIndex(spr, "seOrigin") > -1 Then z3412.seOrigin = getDataM(spr, getColumnIndex(spr, "seOrigin"), xRow)
            If getColumnIndex(spr, "cdOrigin") > -1 Then z3412.cdOrigin = getDataM(spr, getColumnIndex(spr, "cdOrigin"), xRow)
            If getColumnIndex(spr, "MaterialCheck") > -1 Then z3412.MaterialCheck = getDataM(spr, getColumnIndex(spr, "MaterialCheck"), xRow)
            If getColumnIndex(spr, "seUnitPrice") > -1 Then z3412.seUnitPrice = getDataM(spr, getColumnIndex(spr, "seUnitPrice"), xRow)
            If getColumnIndex(spr, "cdUnitPrice") > -1 Then z3412.cdUnitPrice = getDataM(spr, getColumnIndex(spr, "cdUnitPrice"), xRow)
            If getColumnIndex(spr, "seTax") > -1 Then z3412.seTax = getDataM(spr, getColumnIndex(spr, "seTax"), xRow)
            If getColumnIndex(spr, "cdTax") > -1 Then z3412.cdTax = getDataM(spr, getColumnIndex(spr, "cdTax"), xRow)
            If getColumnIndex(spr, "seUnitMaterial") > -1 Then z3412.seUnitMaterial = getDataM(spr, getColumnIndex(spr, "seUnitMaterial"), xRow)
            If getColumnIndex(spr, "cdUnitMaterial") > -1 Then z3412.cdUnitMaterial = getDataM(spr, getColumnIndex(spr, "cdUnitMaterial"), xRow)
            If getColumnIndex(spr, "seUnitPacking") > -1 Then z3412.seUnitPacking = getDataM(spr, getColumnIndex(spr, "seUnitPacking"), xRow)
            If getColumnIndex(spr, "cdUnitPacking") > -1 Then z3412.cdUnitPacking = getDataM(spr, getColumnIndex(spr, "cdUnitPacking"), xRow)
            If getColumnIndex(spr, "UnitBaseCheck") > -1 Then z3412.UnitBaseCheck = getDataM(spr, getColumnIndex(spr, "UnitBaseCheck"), xRow)
            If getColumnIndex(spr, "QtyBasic") > -1 Then z3412.QtyBasic = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyBasic"), xRow))
            If getColumnIndex(spr, "PricePurchasing") > -1 Then z3412.PricePurchasing = Cdecp(getDataM(spr, getColumnIndex(spr, "PricePurchasing"), xRow))
            If getColumnIndex(spr, "PriceMarket") > -1 Then z3412.PriceMarket = Cdecp(getDataM(spr, getColumnIndex(spr, "PriceMarket"), xRow))
            If getColumnIndex(spr, "PriceExchangeAP") > -1 Then z3412.PriceExchangeAP = Cdecp(getDataM(spr, getColumnIndex(spr, "PriceExchangeAP"), xRow))
            If getColumnIndex(spr, "PriceExchange") > -1 Then z3412.PriceExchange = Cdecp(getDataM(spr, getColumnIndex(spr, "PriceExchange"), xRow))
            If getColumnIndex(spr, "DateExchange") > -1 Then z3412.DateExchange = getDataM(spr, getColumnIndex(spr, "DateExchange"), xRow)
            If getColumnIndex(spr, "PricePurchasingEX") > -1 Then z3412.PricePurchasingEX = Cdecp(getDataM(spr, getColumnIndex(spr, "PricePurchasingEX"), xRow))
            If getColumnIndex(spr, "PriceMarketEX") > -1 Then z3412.PriceMarketEX = Cdecp(getDataM(spr, getColumnIndex(spr, "PriceMarketEX"), xRow))
            If getColumnIndex(spr, "PricePurchasingVND") > -1 Then z3412.PricePurchasingVND = Cdecp(getDataM(spr, getColumnIndex(spr, "PricePurchasingVND"), xRow))
            If getColumnIndex(spr, "PriceMarketVND") > -1 Then z3412.PriceMarketVND = Cdecp(getDataM(spr, getColumnIndex(spr, "PriceMarketVND"), xRow))
            If getColumnIndex(spr, "AmountPurchasingEX") > -1 Then z3412.AmountPurchasingEX = Cdecp(getDataM(spr, getColumnIndex(spr, "AmountPurchasingEX"), xRow))
            If getColumnIndex(spr, "AmountPurchasingVND") > -1 Then z3412.AmountPurchasingVND = Cdecp(getDataM(spr, getColumnIndex(spr, "AmountPurchasingVND"), xRow))
            If getColumnIndex(spr, "AmountTaxEX") > -1 Then z3412.AmountTaxEX = Cdecp(getDataM(spr, getColumnIndex(spr, "AmountTaxEX"), xRow))
            If getColumnIndex(spr, "AmountTaxVND") > -1 Then z3412.AmountTaxVND = Cdecp(getDataM(spr, getColumnIndex(spr, "AmountTaxVND"), xRow))
            If getColumnIndex(spr, "seTax1") > -1 Then z3412.seTax1 = getDataM(spr, getColumnIndex(spr, "seTax1"), xRow)
            If getColumnIndex(spr, "cdTax1") > -1 Then z3412.cdTax1 = getDataM(spr, getColumnIndex(spr, "cdTax1"), xRow)
            If getColumnIndex(spr, "PerTax1") > -1 Then z3412.PerTax1 = Cdecp(getDataM(spr, getColumnIndex(spr, "PerTax1"), xRow))
            If getColumnIndex(spr, "AmountTax1EX") > -1 Then z3412.AmountTax1EX = Cdecp(getDataM(spr, getColumnIndex(spr, "AmountTax1EX"), xRow))
            If getColumnIndex(spr, "AmountTax1") > -1 Then z3412.AmountTax1 = Cdecp(getDataM(spr, getColumnIndex(spr, "AmountTax1"), xRow))
            If getColumnIndex(spr, "seTax2") > -1 Then z3412.seTax2 = getDataM(spr, getColumnIndex(spr, "seTax2"), xRow)
            If getColumnIndex(spr, "cdTax2") > -1 Then z3412.cdTax2 = getDataM(spr, getColumnIndex(spr, "cdTax2"), xRow)
            If getColumnIndex(spr, "PerTax2") > -1 Then z3412.PerTax2 = Cdecp(getDataM(spr, getColumnIndex(spr, "PerTax2"), xRow))
            If getColumnIndex(spr, "AmountTax2EX") > -1 Then z3412.AmountTax2EX = Cdecp(getDataM(spr, getColumnIndex(spr, "AmountTax2EX"), xRow))
            If getColumnIndex(spr, "AmountTax2") > -1 Then z3412.AmountTax2 = Cdecp(getDataM(spr, getColumnIndex(spr, "AmountTax2"), xRow))
            If getColumnIndex(spr, "seTax3") > -1 Then z3412.seTax3 = getDataM(spr, getColumnIndex(spr, "seTax3"), xRow)
            If getColumnIndex(spr, "cdTax3") > -1 Then z3412.cdTax3 = getDataM(spr, getColumnIndex(spr, "cdTax3"), xRow)
            If getColumnIndex(spr, "PerTax3") > -1 Then z3412.PerTax3 = Cdecp(getDataM(spr, getColumnIndex(spr, "PerTax3"), xRow))
            If getColumnIndex(spr, "AmountTax3EX") > -1 Then z3412.AmountTax3EX = Cdecp(getDataM(spr, getColumnIndex(spr, "AmountTax3EX"), xRow))
            If getColumnIndex(spr, "AmountTax3") > -1 Then z3412.AmountTax3 = Cdecp(getDataM(spr, getColumnIndex(spr, "AmountTax3"), xRow))
            If getColumnIndex(spr, "QtyBooking") > -1 Then z3412.QtyBooking = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyBooking"), xRow))
            If getColumnIndex(spr, "QtyPurchasingNet") > -1 Then z3412.QtyPurchasingNet = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyPurchasingNet"), xRow))
            If getColumnIndex(spr, "QtyPurchasingMOQ") > -1 Then z3412.QtyPurchasingMOQ = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyPurchasingMOQ"), xRow))
            If getColumnIndex(spr, "QtyPurchasing") > -1 Then z3412.QtyPurchasing = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyPurchasing"), xRow))
            If getColumnIndex(spr, "PackPurchasing") > -1 Then z3412.PackPurchasing = Cdecp(getDataM(spr, getColumnIndex(spr, "PackPurchasing"), xRow))
            If getColumnIndex(spr, "AmountPSC") > -1 Then z3412.AmountPSC = Cdecp(getDataM(spr, getColumnIndex(spr, "AmountPSC"), xRow))
            If getColumnIndex(spr, "AmountEX") > -1 Then z3412.AmountEX = Cdecp(getDataM(spr, getColumnIndex(spr, "AmountEX"), xRow))
            If getColumnIndex(spr, "AmountVND") > -1 Then z3412.AmountVND = Cdecp(getDataM(spr, getColumnIndex(spr, "AmountVND"), xRow))
            If getColumnIndex(spr, "AmountNoVATEX") > -1 Then z3412.AmountNoVATEX = Cdecp(getDataM(spr, getColumnIndex(spr, "AmountNoVATEX"), xRow))
            If getColumnIndex(spr, "AmountNoVATVND") > -1 Then z3412.AmountNoVATVND = Cdecp(getDataM(spr, getColumnIndex(spr, "AmountNoVATVND"), xRow))
            If getColumnIndex(spr, "AmountTotalEX") > -1 Then z3412.AmountTotalEX = Cdecp(getDataM(spr, getColumnIndex(spr, "AmountTotalEX"), xRow))
            If getColumnIndex(spr, "AmountTotalVND") > -1 Then z3412.AmountTotalVND = Cdecp(getDataM(spr, getColumnIndex(spr, "AmountTotalVND"), xRow))
            If getColumnIndex(spr, "TotalQtyPurchasing") > -1 Then z3412.TotalQtyPurchasing = Cdecp(getDataM(spr, getColumnIndex(spr, "TotalQtyPurchasing"), xRow))
            If getColumnIndex(spr, "TotalPackPurchasing") > -1 Then z3412.TotalPackPurchasing = Cdecp(getDataM(spr, getColumnIndex(spr, "TotalPackPurchasing"), xRow))
            If getColumnIndex(spr, "QtyWarehouse") > -1 Then z3412.QtyWarehouse = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyWarehouse"), xRow))
            If getColumnIndex(spr, "PackWarehouse") > -1 Then z3412.PackWarehouse = Cdecp(getDataM(spr, getColumnIndex(spr, "PackWarehouse"), xRow))
            If getColumnIndex(spr, "DateDelivery") > -1 Then z3412.DateDelivery = getDataM(spr, getColumnIndex(spr, "DateDelivery"), xRow)
            If getColumnIndex(spr, "DateStart") > -1 Then z3412.DateStart = getDataM(spr, getColumnIndex(spr, "DateStart"), xRow)
            If getColumnIndex(spr, "DateFinish") > -1 Then z3412.DateFinish = getDataM(spr, getColumnIndex(spr, "DateFinish"), xRow)
            If getColumnIndex(spr, "CheckPurchasing") > -1 Then z3412.CheckPurchasing = getDataM(spr, getColumnIndex(spr, "CheckPurchasing"), xRow)
            If getColumnIndex(spr, "DateAccept") > -1 Then z3412.DateAccept = getDataM(spr, getColumnIndex(spr, "DateAccept"), xRow)
            If getColumnIndex(spr, "DatePosted") > -1 Then z3412.DatePosted = getDataM(spr, getColumnIndex(spr, "DatePosted"), xRow)
            If getColumnIndex(spr, "IsPosted") > -1 Then z3412.IsPosted = getDataM(spr, getColumnIndex(spr, "IsPosted"), xRow)
            If getColumnIndex(spr, "DateComplete") > -1 Then z3412.DateComplete = getDataM(spr, getColumnIndex(spr, "DateComplete"), xRow)
            If getColumnIndex(spr, "DateApproval") > -1 Then z3412.DateApproval = getDataM(spr, getColumnIndex(spr, "DateApproval"), xRow)
            If getColumnIndex(spr, "DateCancel") > -1 Then z3412.DateCancel = getDataM(spr, getColumnIndex(spr, "DateCancel"), xRow)
            If getColumnIndex(spr, "CheckComplete") > -1 Then z3412.CheckComplete = getDataM(spr, getColumnIndex(spr, "CheckComplete"), xRow)
            If getColumnIndex(spr, "PurchasingRequestNo") > -1 Then z3412.PurchasingRequestNo = getDataM(spr, getColumnIndex(spr, "PurchasingRequestNo"), xRow)
            If getColumnIndex(spr, "PurchasingRequestSeq") > -1 Then z3412.PurchasingRequestSeq = Cdecp(getDataM(spr, getColumnIndex(spr, "PurchasingRequestSeq"), xRow))
            If getColumnIndex(spr, "OrderNo") > -1 Then z3412.OrderNo = getDataM(spr, getColumnIndex(spr, "OrderNo"), xRow)
            If getColumnIndex(spr, "OrderNoSeq") > -1 Then z3412.OrderNoSeq = getDataM(spr, getColumnIndex(spr, "OrderNoSeq"), xRow)
            If getColumnIndex(spr, "PurchasingOrderNo_Bf") > -1 Then z3412.PurchasingOrderNo_Bf = getDataM(spr, getColumnIndex(spr, "PurchasingOrderNo_Bf"), xRow)
            If getColumnIndex(spr, "PurchasingOrderSeq_Bf") > -1 Then z3412.PurchasingOrderSeq_Bf = Cdecp(getDataM(spr, getColumnIndex(spr, "PurchasingOrderSeq_Bf"), xRow))
            If getColumnIndex(spr, "Remark") > -1 Then z3412.Remark = getDataM(spr, getColumnIndex(spr, "Remark"), xRow)
            If getColumnIndex(spr, "TimeInsert") > -1 Then z3412.TimeInsert = getDataM(spr, getColumnIndex(spr, "TimeInsert"), xRow)
            If getColumnIndex(spr, "TimeUpdate") > -1 Then z3412.TimeUpdate = getDataM(spr, getColumnIndex(spr, "TimeUpdate"), xRow)
            If getColumnIndex(spr, "DateInsert") > -1 Then z3412.DateInsert = getDataM(spr, getColumnIndex(spr, "DateInsert"), xRow)
            If getColumnIndex(spr, "DateUpdate") > -1 Then z3412.DateUpdate = getDataM(spr, getColumnIndex(spr, "DateUpdate"), xRow)
            If getColumnIndex(spr, "InchargeInsert") > -1 Then z3412.InchargeInsert = getDataM(spr, getColumnIndex(spr, "InchargeInsert"), xRow)
            If getColumnIndex(spr, "InchargeUpdate") > -1 Then z3412.InchargeUpdate = getDataM(spr, getColumnIndex(spr, "InchargeUpdate"), xRow)
            If getColumnIndex(spr, "PriceAPurchasing") > -1 Then z3412.PriceAPurchasing = Cdecp(getDataM(spr, getColumnIndex(spr, "PriceAPurchasing"), xRow))
            If getColumnIndex(spr, "cdUnitMaterialA") > -1 Then z3412.cdUnitMaterialA = getDataM(spr, getColumnIndex(spr, "cdUnitMaterialA"), xRow)
            If getColumnIndex(spr, "cdUnitPriceA") > -1 Then z3412.cdUnitPriceA = getDataM(spr, getColumnIndex(spr, "cdUnitPriceA"), xRow)
            If getColumnIndex(spr, "QtyAPurchasing") > -1 Then z3412.QtyAPurchasing = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyAPurchasing"), xRow))
            If getColumnIndex(spr, "QtyATotal") > -1 Then z3412.QtyATotal = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyATotal"), xRow))
            If getColumnIndex(spr, "AmtAPurchasing") > -1 Then z3412.AmtAPurchasing = Cdecp(getDataM(spr, getColumnIndex(spr, "AmtAPurchasing"), xRow))
            If getColumnIndex(spr, "AmtATotal") > -1 Then z3412.AmtATotal = Cdecp(getDataM(spr, getColumnIndex(spr, "AmtATotal"), xRow))
            If getColumnIndex(spr, "InvoiceNo1") > -1 Then z3412.InvoiceNo1 = getDataM(spr, getColumnIndex(spr, "InvoiceNo1"), xRow)
            If getColumnIndex(spr, "InvoiceNo2") > -1 Then z3412.InvoiceNo2 = getDataM(spr, getColumnIndex(spr, "InvoiceNo2"), xRow)
            If getColumnIndex(spr, "InvoiceNo3") > -1 Then z3412.InvoiceNo3 = getDataM(spr, getColumnIndex(spr, "InvoiceNo3"), xRow)
            If getColumnIndex(spr, "InvoiceNo4") > -1 Then z3412.InvoiceNo4 = getDataM(spr, getColumnIndex(spr, "InvoiceNo4"), xRow)
            If getColumnIndex(spr, "InvoiceNo5") > -1 Then z3412.InvoiceNo5 = getDataM(spr, getColumnIndex(spr, "InvoiceNo5"), xRow)
            If getColumnIndex(spr, "InvoiceNo6") > -1 Then z3412.InvoiceNo6 = getDataM(spr, getColumnIndex(spr, "InvoiceNo6"), xRow)
            If getColumnIndex(spr, "InvoiceNo7") > -1 Then z3412.InvoiceNo7 = getDataM(spr, getColumnIndex(spr, "InvoiceNo7"), xRow)
            If getColumnIndex(spr, "InvoiceNo8") > -1 Then z3412.InvoiceNo8 = getDataM(spr, getColumnIndex(spr, "InvoiceNo8"), xRow)
            If getColumnIndex(spr, "InvoiceNo9") > -1 Then z3412.InvoiceNo9 = getDataM(spr, getColumnIndex(spr, "InvoiceNo9"), xRow)
            If getColumnIndex(spr, "InvoiceNo10") > -1 Then z3412.InvoiceNo10 = getDataM(spr, getColumnIndex(spr, "InvoiceNo10"), xRow)

            If getColumnIndex(spr, "DateArrive1") > -1 Then z3412.DateArrive1 = getDataM(spr, getColumnIndex(spr, "DateArrive1"), xRow)
            If getColumnIndex(spr, "DateArrive2") > -1 Then z3412.DateArrive2 = getDataM(spr, getColumnIndex(spr, "DateArrive2"), xRow)
            If getColumnIndex(spr, "DateArrive3") > -1 Then z3412.DateArrive3 = getDataM(spr, getColumnIndex(spr, "DateArrive3"), xRow)
            If getColumnIndex(spr, "DateArrive4") > -1 Then z3412.DateArrive4 = getDataM(spr, getColumnIndex(spr, "DateArrive4"), xRow)
            If getColumnIndex(spr, "DateArrive5") > -1 Then z3412.DateArrive5 = getDataM(spr, getColumnIndex(spr, "DateArrive5"), xRow)
            If getColumnIndex(spr, "DateArrive6") > -1 Then z3412.DateArrive6 = getDataM(spr, getColumnIndex(spr, "DateArrive6"), xRow)
            If getColumnIndex(spr, "DateArrive7") > -1 Then z3412.DateArrive7 = getDataM(spr, getColumnIndex(spr, "DateArrive7"), xRow)
            If getColumnIndex(spr, "DateArrive8") > -1 Then z3412.DateArrive8 = getDataM(spr, getColumnIndex(spr, "DateArrive8"), xRow)
            If getColumnIndex(spr, "DateArrive9") > -1 Then z3412.DateArrive9 = getDataM(spr, getColumnIndex(spr, "DateArrive9"), xRow)
            If getColumnIndex(spr, "DateArrive10") > -1 Then z3412.DateArrive10 = getDataM(spr, getColumnIndex(spr, "DateArrive10"), xRow)

            If getColumnIndex(spr, "QtyAArrive1") > -1 Then z3412.QtyAArrive1 = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyAArrive1"), xRow))
            If getColumnIndex(spr, "QtyAArrive2") > -1 Then z3412.QtyAArrive2 = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyAArrive2"), xRow))
            If getColumnIndex(spr, "QtyAArrive3") > -1 Then z3412.QtyAArrive3 = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyAArrive3"), xRow))
            If getColumnIndex(spr, "QtyAArrive4") > -1 Then z3412.QtyAArrive4 = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyAArrive4"), xRow))
            If getColumnIndex(spr, "QtyAArrive5") > -1 Then z3412.QtyAArrive5 = CDecp(getDataM(spr, getColumnIndex(spr, "QtyAArrive5"), xRow))
            If getColumnIndex(spr, "QtyAArrive6") > -1 Then z3412.QtyAArrive6 = CDecp(getDataM(spr, getColumnIndex(spr, "QtyAArrive6"), xRow))
            If getColumnIndex(spr, "QtyAArrive7") > -1 Then z3412.QtyAArrive7 = CDecp(getDataM(spr, getColumnIndex(spr, "QtyAArrive7"), xRow))
            If getColumnIndex(spr, "QtyAArrive8") > -1 Then z3412.QtyAArrive8 = CDecp(getDataM(spr, getColumnIndex(spr, "QtyAArrive8"), xRow))
            If getColumnIndex(spr, "QtyAArrive9") > -1 Then z3412.QtyAArrive9 = CDecp(getDataM(spr, getColumnIndex(spr, "QtyAArrive9"), xRow))
            If getColumnIndex(spr, "QtyAArrive10") > -1 Then z3412.QtyAArrive10 = CDecp(getDataM(spr, getColumnIndex(spr, "QtyAArrive10"), xRow))

            If getColumnIndex(spr, "InchargeInvoice") > -1 Then z3412.InchargeInvoice = getDataM(spr, getColumnIndex(spr, "InchargeInvoice"), xRow)
            If getColumnIndex(spr, "APLName") > -1 Then z3412.APLName = getDataM(spr, getColumnIndex(spr, "APLName"), xRow)
            If getColumnIndex(spr, "AInvoice") > -1 Then z3412.AInvoice = getDataM(spr, getColumnIndex(spr, "AInvoice"), xRow)
            If getColumnIndex(spr, "ARemark") > -1 Then z3412.ARemark = getDataM(spr, getColumnIndex(spr, "ARemark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K3412_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K3412_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z3412 As T3412_AREA, CheckClear As Boolean, PURCHASINGORDERNO As String, PURCHASINGORDERSEQ As Double) As Boolean

        K3412_MOVE = False

        Try
            If READ_PFK3412(PURCHASINGORDERNO, PURCHASINGORDERSEQ) = True Then
                z3412 = D3412
                K3412_MOVE = True
            Else
                If CheckClear = True Then z3412 = Nothing
            End If

            If getColumnIndex(spr, "PurchasingOrderNo") > -1 Then z3412.PurchasingOrderNo = getDataM(spr, getColumnIndex(spr, "PurchasingOrderNo"), xRow)
            If getColumnIndex(spr, "PurchasingOrderSeq") > -1 Then z3412.PurchasingOrderSeq = Cdecp(getDataM(spr, getColumnIndex(spr, "PurchasingOrderSeq"), xRow))
            If getColumnIndex(spr, "seSite") > -1 Then z3412.seSite = getDataM(spr, getColumnIndex(spr, "seSite"), xRow)
            If getColumnIndex(spr, "cdSite") > -1 Then z3412.cdSite = getDataM(spr, getColumnIndex(spr, "cdSite"), xRow)
            If getColumnIndex(spr, "seDepartment") > -1 Then z3412.seDepartment = getDataM(spr, getColumnIndex(spr, "seDepartment"), xRow)
            If getColumnIndex(spr, "cdDepartment") > -1 Then z3412.cdDepartment = getDataM(spr, getColumnIndex(spr, "cdDepartment"), xRow)
            If getColumnIndex(spr, "seFactory") > -1 Then z3412.seFactory = getDataM(spr, getColumnIndex(spr, "seFactory"), xRow)
            If getColumnIndex(spr, "cdFactory") > -1 Then z3412.cdFactory = getDataM(spr, getColumnIndex(spr, "cdFactory"), xRow)
            If getColumnIndex(spr, "CustomerSupplier") > -1 Then z3412.CustomerSupplier = getDataM(spr, getColumnIndex(spr, "CustomerSupplier"), xRow)
            If getColumnIndex(spr, "Dseq") > -1 Then z3412.Dseq = Cdecp(getDataM(spr, getColumnIndex(spr, "Dseq"), xRow))
            If getColumnIndex(spr, "AutokeyK3011") > -1 Then z3412.AutokeyK3011 = Cdecp(getDataM(spr, getColumnIndex(spr, "AutokeyK3011"), xRow))
            If getColumnIndex(spr, "CheckRelationType") > -1 Then z3412.CheckRelationType = getDataM(spr, getColumnIndex(spr, "CheckRelationType"), xRow)
            If getColumnIndex(spr, "MaterialCode") > -1 Then z3412.MaterialCode = getDataM(spr, getColumnIndex(spr, "MaterialCode"), xRow)
            If getColumnIndex(spr, "Specification") > -1 Then z3412.Specification = getDataM(spr, getColumnIndex(spr, "Specification"), xRow)
            If getColumnIndex(spr, "Width") > -1 Then z3412.Width = getDataM(spr, getColumnIndex(spr, "Width"), xRow)
            If getColumnIndex(spr, "Height") > -1 Then z3412.Height = getDataM(spr, getColumnIndex(spr, "Height"), xRow)
            If getColumnIndex(spr, "SizeNo") > -1 Then z3412.SizeNo = getDataM(spr, getColumnIndex(spr, "SizeNo"), xRow)
            If getColumnIndex(spr, "SizeName") > -1 Then z3412.SizeName = getDataM(spr, getColumnIndex(spr, "SizeName"), xRow)
            If getColumnIndex(spr, "ColorCode") > -1 Then z3412.ColorCode = getDataM(spr, getColumnIndex(spr, "ColorCode"), xRow)
            If getColumnIndex(spr, "ColorName") > -1 Then z3412.ColorName = getDataM(spr, getColumnIndex(spr, "ColorName"), xRow)
            If getColumnIndex(spr, "seOrigin") > -1 Then z3412.seOrigin = getDataM(spr, getColumnIndex(spr, "seOrigin"), xRow)
            If getColumnIndex(spr, "cdOrigin") > -1 Then z3412.cdOrigin = getDataM(spr, getColumnIndex(spr, "cdOrigin"), xRow)
            If getColumnIndex(spr, "MaterialCheck") > -1 Then z3412.MaterialCheck = getDataM(spr, getColumnIndex(spr, "MaterialCheck"), xRow)
            If getColumnIndex(spr, "seUnitPrice") > -1 Then z3412.seUnitPrice = getDataM(spr, getColumnIndex(spr, "seUnitPrice"), xRow)
            If getColumnIndex(spr, "cdUnitPrice") > -1 Then z3412.cdUnitPrice = getDataM(spr, getColumnIndex(spr, "cdUnitPrice"), xRow)
            If getColumnIndex(spr, "seTax") > -1 Then z3412.seTax = getDataM(spr, getColumnIndex(spr, "seTax"), xRow)
            If getColumnIndex(spr, "cdTax") > -1 Then z3412.cdTax = getDataM(spr, getColumnIndex(spr, "cdTax"), xRow)
            If getColumnIndex(spr, "seUnitMaterial") > -1 Then z3412.seUnitMaterial = getDataM(spr, getColumnIndex(spr, "seUnitMaterial"), xRow)
            If getColumnIndex(spr, "cdUnitMaterial") > -1 Then z3412.cdUnitMaterial = getDataM(spr, getColumnIndex(spr, "cdUnitMaterial"), xRow)
            If getColumnIndex(spr, "seUnitPacking") > -1 Then z3412.seUnitPacking = getDataM(spr, getColumnIndex(spr, "seUnitPacking"), xRow)
            If getColumnIndex(spr, "cdUnitPacking") > -1 Then z3412.cdUnitPacking = getDataM(spr, getColumnIndex(spr, "cdUnitPacking"), xRow)
            If getColumnIndex(spr, "UnitBaseCheck") > -1 Then z3412.UnitBaseCheck = getDataM(spr, getColumnIndex(spr, "UnitBaseCheck"), xRow)
            If getColumnIndex(spr, "QtyBasic") > -1 Then z3412.QtyBasic = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyBasic"), xRow))
            If getColumnIndex(spr, "PricePurchasing") > -1 Then z3412.PricePurchasing = Cdecp(getDataM(spr, getColumnIndex(spr, "PricePurchasing"), xRow))
            If getColumnIndex(spr, "PriceMarket") > -1 Then z3412.PriceMarket = Cdecp(getDataM(spr, getColumnIndex(spr, "PriceMarket"), xRow))
            If getColumnIndex(spr, "PriceExchangeAP") > -1 Then z3412.PriceExchangeAP = Cdecp(getDataM(spr, getColumnIndex(spr, "PriceExchangeAP"), xRow))
            If getColumnIndex(spr, "PriceExchange") > -1 Then z3412.PriceExchange = Cdecp(getDataM(spr, getColumnIndex(spr, "PriceExchange"), xRow))
            If getColumnIndex(spr, "DateExchange") > -1 Then z3412.DateExchange = getDataM(spr, getColumnIndex(spr, "DateExchange"), xRow)
            If getColumnIndex(spr, "PricePurchasingEX") > -1 Then z3412.PricePurchasingEX = Cdecp(getDataM(spr, getColumnIndex(spr, "PricePurchasingEX"), xRow))
            If getColumnIndex(spr, "PriceMarketEX") > -1 Then z3412.PriceMarketEX = Cdecp(getDataM(spr, getColumnIndex(spr, "PriceMarketEX"), xRow))
            If getColumnIndex(spr, "PricePurchasingVND") > -1 Then z3412.PricePurchasingVND = Cdecp(getDataM(spr, getColumnIndex(spr, "PricePurchasingVND"), xRow))
            If getColumnIndex(spr, "PriceMarketVND") > -1 Then z3412.PriceMarketVND = Cdecp(getDataM(spr, getColumnIndex(spr, "PriceMarketVND"), xRow))
            If getColumnIndex(spr, "AmountPurchasingEX") > -1 Then z3412.AmountPurchasingEX = Cdecp(getDataM(spr, getColumnIndex(spr, "AmountPurchasingEX"), xRow))
            If getColumnIndex(spr, "AmountPurchasingVND") > -1 Then z3412.AmountPurchasingVND = Cdecp(getDataM(spr, getColumnIndex(spr, "AmountPurchasingVND"), xRow))
            If getColumnIndex(spr, "AmountTaxEX") > -1 Then z3412.AmountTaxEX = Cdecp(getDataM(spr, getColumnIndex(spr, "AmountTaxEX"), xRow))
            If getColumnIndex(spr, "AmountTaxVND") > -1 Then z3412.AmountTaxVND = Cdecp(getDataM(spr, getColumnIndex(spr, "AmountTaxVND"), xRow))
            If getColumnIndex(spr, "seTax1") > -1 Then z3412.seTax1 = getDataM(spr, getColumnIndex(spr, "seTax1"), xRow)
            If getColumnIndex(spr, "cdTax1") > -1 Then z3412.cdTax1 = getDataM(spr, getColumnIndex(spr, "cdTax1"), xRow)
            If getColumnIndex(spr, "PerTax1") > -1 Then z3412.PerTax1 = Cdecp(getDataM(spr, getColumnIndex(spr, "PerTax1"), xRow))
            If getColumnIndex(spr, "AmountTax1EX") > -1 Then z3412.AmountTax1EX = Cdecp(getDataM(spr, getColumnIndex(spr, "AmountTax1EX"), xRow))
            If getColumnIndex(spr, "AmountTax1") > -1 Then z3412.AmountTax1 = Cdecp(getDataM(spr, getColumnIndex(spr, "AmountTax1"), xRow))
            If getColumnIndex(spr, "seTax2") > -1 Then z3412.seTax2 = getDataM(spr, getColumnIndex(spr, "seTax2"), xRow)
            If getColumnIndex(spr, "cdTax2") > -1 Then z3412.cdTax2 = getDataM(spr, getColumnIndex(spr, "cdTax2"), xRow)
            If getColumnIndex(spr, "PerTax2") > -1 Then z3412.PerTax2 = Cdecp(getDataM(spr, getColumnIndex(spr, "PerTax2"), xRow))
            If getColumnIndex(spr, "AmountTax2EX") > -1 Then z3412.AmountTax2EX = Cdecp(getDataM(spr, getColumnIndex(spr, "AmountTax2EX"), xRow))
            If getColumnIndex(spr, "AmountTax2") > -1 Then z3412.AmountTax2 = Cdecp(getDataM(spr, getColumnIndex(spr, "AmountTax2"), xRow))
            If getColumnIndex(spr, "seTax3") > -1 Then z3412.seTax3 = getDataM(spr, getColumnIndex(spr, "seTax3"), xRow)
            If getColumnIndex(spr, "cdTax3") > -1 Then z3412.cdTax3 = getDataM(spr, getColumnIndex(spr, "cdTax3"), xRow)
            If getColumnIndex(spr, "PerTax3") > -1 Then z3412.PerTax3 = Cdecp(getDataM(spr, getColumnIndex(spr, "PerTax3"), xRow))
            If getColumnIndex(spr, "AmountTax3EX") > -1 Then z3412.AmountTax3EX = Cdecp(getDataM(spr, getColumnIndex(spr, "AmountTax3EX"), xRow))
            If getColumnIndex(spr, "AmountTax3") > -1 Then z3412.AmountTax3 = Cdecp(getDataM(spr, getColumnIndex(spr, "AmountTax3"), xRow))
            If getColumnIndex(spr, "QtyBooking") > -1 Then z3412.QtyBooking = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyBooking"), xRow))
            If getColumnIndex(spr, "QtyPurchasingNet") > -1 Then z3412.QtyPurchasingNet = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyPurchasingNet"), xRow))
            If getColumnIndex(spr, "QtyPurchasingMOQ") > -1 Then z3412.QtyPurchasingMOQ = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyPurchasingMOQ"), xRow))
            If getColumnIndex(spr, "QtyPurchasing") > -1 Then z3412.QtyPurchasing = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyPurchasing"), xRow))
            If getColumnIndex(spr, "PackPurchasing") > -1 Then z3412.PackPurchasing = Cdecp(getDataM(spr, getColumnIndex(spr, "PackPurchasing"), xRow))
            If getColumnIndex(spr, "AmountPSC") > -1 Then z3412.AmountPSC = Cdecp(getDataM(spr, getColumnIndex(spr, "AmountPSC"), xRow))
            If getColumnIndex(spr, "AmountEX") > -1 Then z3412.AmountEX = Cdecp(getDataM(spr, getColumnIndex(spr, "AmountEX"), xRow))
            If getColumnIndex(spr, "AmountVND") > -1 Then z3412.AmountVND = Cdecp(getDataM(spr, getColumnIndex(spr, "AmountVND"), xRow))
            If getColumnIndex(spr, "AmountNoVATEX") > -1 Then z3412.AmountNoVATEX = Cdecp(getDataM(spr, getColumnIndex(spr, "AmountNoVATEX"), xRow))
            If getColumnIndex(spr, "AmountNoVATVND") > -1 Then z3412.AmountNoVATVND = Cdecp(getDataM(spr, getColumnIndex(spr, "AmountNoVATVND"), xRow))
            If getColumnIndex(spr, "AmountTotalEX") > -1 Then z3412.AmountTotalEX = Cdecp(getDataM(spr, getColumnIndex(spr, "AmountTotalEX"), xRow))
            If getColumnIndex(spr, "AmountTotalVND") > -1 Then z3412.AmountTotalVND = Cdecp(getDataM(spr, getColumnIndex(spr, "AmountTotalVND"), xRow))
            If getColumnIndex(spr, "TotalQtyPurchasing") > -1 Then z3412.TotalQtyPurchasing = Cdecp(getDataM(spr, getColumnIndex(spr, "TotalQtyPurchasing"), xRow))
            If getColumnIndex(spr, "TotalPackPurchasing") > -1 Then z3412.TotalPackPurchasing = Cdecp(getDataM(spr, getColumnIndex(spr, "TotalPackPurchasing"), xRow))
            If getColumnIndex(spr, "QtyWarehouse") > -1 Then z3412.QtyWarehouse = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyWarehouse"), xRow))
            If getColumnIndex(spr, "PackWarehouse") > -1 Then z3412.PackWarehouse = Cdecp(getDataM(spr, getColumnIndex(spr, "PackWarehouse"), xRow))
            If getColumnIndex(spr, "DateDelivery") > -1 Then z3412.DateDelivery = getDataM(spr, getColumnIndex(spr, "DateDelivery"), xRow)
            If getColumnIndex(spr, "DateStart") > -1 Then z3412.DateStart = getDataM(spr, getColumnIndex(spr, "DateStart"), xRow)
            If getColumnIndex(spr, "DateFinish") > -1 Then z3412.DateFinish = getDataM(spr, getColumnIndex(spr, "DateFinish"), xRow)
            If getColumnIndex(spr, "CheckPurchasing") > -1 Then z3412.CheckPurchasing = getDataM(spr, getColumnIndex(spr, "CheckPurchasing"), xRow)
            If getColumnIndex(spr, "DateAccept") > -1 Then z3412.DateAccept = getDataM(spr, getColumnIndex(spr, "DateAccept"), xRow)
            If getColumnIndex(spr, "DatePosted") > -1 Then z3412.DatePosted = getDataM(spr, getColumnIndex(spr, "DatePosted"), xRow)
            If getColumnIndex(spr, "IsPosted") > -1 Then z3412.IsPosted = getDataM(spr, getColumnIndex(spr, "IsPosted"), xRow)
            If getColumnIndex(spr, "DateComplete") > -1 Then z3412.DateComplete = getDataM(spr, getColumnIndex(spr, "DateComplete"), xRow)
            If getColumnIndex(spr, "DateApproval") > -1 Then z3412.DateApproval = getDataM(spr, getColumnIndex(spr, "DateApproval"), xRow)
            If getColumnIndex(spr, "DateCancel") > -1 Then z3412.DateCancel = getDataM(spr, getColumnIndex(spr, "DateCancel"), xRow)
            If getColumnIndex(spr, "CheckComplete") > -1 Then z3412.CheckComplete = getDataM(spr, getColumnIndex(spr, "CheckComplete"), xRow)
            If getColumnIndex(spr, "PurchasingRequestNo") > -1 Then z3412.PurchasingRequestNo = getDataM(spr, getColumnIndex(spr, "PurchasingRequestNo"), xRow)
            If getColumnIndex(spr, "PurchasingRequestSeq") > -1 Then z3412.PurchasingRequestSeq = Cdecp(getDataM(spr, getColumnIndex(spr, "PurchasingRequestSeq"), xRow))
            If getColumnIndex(spr, "OrderNo") > -1 Then z3412.OrderNo = getDataM(spr, getColumnIndex(spr, "OrderNo"), xRow)
            If getColumnIndex(spr, "OrderNoSeq") > -1 Then z3412.OrderNoSeq = getDataM(spr, getColumnIndex(spr, "OrderNoSeq"), xRow)
            If getColumnIndex(spr, "PurchasingOrderNo_Bf") > -1 Then z3412.PurchasingOrderNo_Bf = getDataM(spr, getColumnIndex(spr, "PurchasingOrderNo_Bf"), xRow)
            If getColumnIndex(spr, "PurchasingOrderSeq_Bf") > -1 Then z3412.PurchasingOrderSeq_Bf = Cdecp(getDataM(spr, getColumnIndex(spr, "PurchasingOrderSeq_Bf"), xRow))
            If getColumnIndex(spr, "Remark") > -1 Then z3412.Remark = getDataM(spr, getColumnIndex(spr, "Remark"), xRow)
            If getColumnIndex(spr, "TimeInsert") > -1 Then z3412.TimeInsert = getDataM(spr, getColumnIndex(spr, "TimeInsert"), xRow)
            If getColumnIndex(spr, "TimeUpdate") > -1 Then z3412.TimeUpdate = getDataM(spr, getColumnIndex(spr, "TimeUpdate"), xRow)
            If getColumnIndex(spr, "DateInsert") > -1 Then z3412.DateInsert = getDataM(spr, getColumnIndex(spr, "DateInsert"), xRow)
            If getColumnIndex(spr, "DateUpdate") > -1 Then z3412.DateUpdate = getDataM(spr, getColumnIndex(spr, "DateUpdate"), xRow)
            If getColumnIndex(spr, "InchargeInsert") > -1 Then z3412.InchargeInsert = getDataM(spr, getColumnIndex(spr, "InchargeInsert"), xRow)
            If getColumnIndex(spr, "InchargeUpdate") > -1 Then z3412.InchargeUpdate = getDataM(spr, getColumnIndex(spr, "InchargeUpdate"), xRow)
            If getColumnIndex(spr, "PriceAPurchasing") > -1 Then z3412.PriceAPurchasing = Cdecp(getDataM(spr, getColumnIndex(spr, "PriceAPurchasing"), xRow))
            If getColumnIndex(spr, "cdUnitMaterialA") > -1 Then z3412.cdUnitMaterialA = getDataM(spr, getColumnIndex(spr, "cdUnitMaterialA"), xRow)
            If getColumnIndex(spr, "cdUnitPriceA") > -1 Then z3412.cdUnitPriceA = getDataM(spr, getColumnIndex(spr, "cdUnitPriceA"), xRow)
            If getColumnIndex(spr, "QtyAPurchasing") > -1 Then z3412.QtyAPurchasing = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyAPurchasing"), xRow))
            If getColumnIndex(spr, "QtyATotal") > -1 Then z3412.QtyATotal = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyATotal"), xRow))
            If getColumnIndex(spr, "AmtAPurchasing") > -1 Then z3412.AmtAPurchasing = Cdecp(getDataM(spr, getColumnIndex(spr, "AmtAPurchasing"), xRow))
            If getColumnIndex(spr, "AmtATotal") > -1 Then z3412.AmtATotal = Cdecp(getDataM(spr, getColumnIndex(spr, "AmtATotal"), xRow))
            If getColumnIndex(spr, "InvoiceNo1") > -1 Then z3412.InvoiceNo1 = getDataM(spr, getColumnIndex(spr, "InvoiceNo1"), xRow)
            If getColumnIndex(spr, "InvoiceNo2") > -1 Then z3412.InvoiceNo2 = getDataM(spr, getColumnIndex(spr, "InvoiceNo2"), xRow)
            If getColumnIndex(spr, "InvoiceNo3") > -1 Then z3412.InvoiceNo3 = getDataM(spr, getColumnIndex(spr, "InvoiceNo3"), xRow)
            If getColumnIndex(spr, "InvoiceNo4") > -1 Then z3412.InvoiceNo4 = getDataM(spr, getColumnIndex(spr, "InvoiceNo4"), xRow)
            If getColumnIndex(spr, "InvoiceNo5") > -1 Then z3412.InvoiceNo5 = getDataM(spr, getColumnIndex(spr, "InvoiceNo5"), xRow)
            If getColumnIndex(spr, "InvoiceNo6") > -1 Then z3412.InvoiceNo6 = getDataM(spr, getColumnIndex(spr, "InvoiceNo6"), xRow)
            If getColumnIndex(spr, "InvoiceNo7") > -1 Then z3412.InvoiceNo7 = getDataM(spr, getColumnIndex(spr, "InvoiceNo7"), xRow)
            If getColumnIndex(spr, "InvoiceNo8") > -1 Then z3412.InvoiceNo8 = getDataM(spr, getColumnIndex(spr, "InvoiceNo8"), xRow)
            If getColumnIndex(spr, "InvoiceNo9") > -1 Then z3412.InvoiceNo9 = getDataM(spr, getColumnIndex(spr, "InvoiceNo9"), xRow)
            If getColumnIndex(spr, "InvoiceNo10") > -1 Then z3412.InvoiceNo10 = getDataM(spr, getColumnIndex(spr, "InvoiceNo10"), xRow)

            If getColumnIndex(spr, "DateArrive1") > -1 Then z3412.DateArrive1 = getDataM(spr, getColumnIndex(spr, "DateArrive1"), xRow)
            If getColumnIndex(spr, "DateArrive2") > -1 Then z3412.DateArrive2 = getDataM(spr, getColumnIndex(spr, "DateArrive2"), xRow)
            If getColumnIndex(spr, "DateArrive3") > -1 Then z3412.DateArrive3 = getDataM(spr, getColumnIndex(spr, "DateArrive3"), xRow)
            If getColumnIndex(spr, "DateArrive4") > -1 Then z3412.DateArrive4 = getDataM(spr, getColumnIndex(spr, "DateArrive4"), xRow)
            If getColumnIndex(spr, "DateArrive5") > -1 Then z3412.DateArrive5 = getDataM(spr, getColumnIndex(spr, "DateArrive5"), xRow)
            If getColumnIndex(spr, "DateArrive6") > -1 Then z3412.DateArrive6 = getDataM(spr, getColumnIndex(spr, "DateArrive6"), xRow)
            If getColumnIndex(spr, "DateArrive7") > -1 Then z3412.DateArrive7 = getDataM(spr, getColumnIndex(spr, "DateArrive7"), xRow)
            If getColumnIndex(spr, "DateArrive8") > -1 Then z3412.DateArrive8 = getDataM(spr, getColumnIndex(spr, "DateArrive8"), xRow)
            If getColumnIndex(spr, "DateArrive9") > -1 Then z3412.DateArrive9 = getDataM(spr, getColumnIndex(spr, "DateArrive9"), xRow)
            If getColumnIndex(spr, "DateArrive10") > -1 Then z3412.DateArrive10 = getDataM(spr, getColumnIndex(spr, "DateArrive10"), xRow)

            If getColumnIndex(spr, "QtyAArrive1") > -1 Then z3412.QtyAArrive1 = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyAArrive1"), xRow))
            If getColumnIndex(spr, "QtyAArrive2") > -1 Then z3412.QtyAArrive2 = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyAArrive2"), xRow))
            If getColumnIndex(spr, "QtyAArrive3") > -1 Then z3412.QtyAArrive3 = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyAArrive3"), xRow))
            If getColumnIndex(spr, "QtyAArrive4") > -1 Then z3412.QtyAArrive4 = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyAArrive4"), xRow))
            If getColumnIndex(spr, "QtyAArrive5") > -1 Then z3412.QtyAArrive5 = CDecp(getDataM(spr, getColumnIndex(spr, "QtyAArrive5"), xRow))
            If getColumnIndex(spr, "QtyAArrive6") > -1 Then z3412.QtyAArrive6 = CDecp(getDataM(spr, getColumnIndex(spr, "QtyAArrive6"), xRow))
            If getColumnIndex(spr, "QtyAArrive7") > -1 Then z3412.QtyAArrive7 = CDecp(getDataM(spr, getColumnIndex(spr, "QtyAArrive7"), xRow))
            If getColumnIndex(spr, "QtyAArrive8") > -1 Then z3412.QtyAArrive8 = CDecp(getDataM(spr, getColumnIndex(spr, "QtyAArrive8"), xRow))
            If getColumnIndex(spr, "QtyAArrive9") > -1 Then z3412.QtyAArrive9 = CDecp(getDataM(spr, getColumnIndex(spr, "QtyAArrive9"), xRow))
            If getColumnIndex(spr, "QtyAArrive10") > -1 Then z3412.QtyAArrive10 = CDecp(getDataM(spr, getColumnIndex(spr, "QtyAArrive10"), xRow))

            If getColumnIndex(spr, "InchargeInvoice") > -1 Then z3412.InchargeInvoice = getDataM(spr, getColumnIndex(spr, "InchargeInvoice"), xRow)
            If getColumnIndex(spr, "APLName") > -1 Then z3412.APLName = getDataM(spr, getColumnIndex(spr, "APLName"), xRow)
            If getColumnIndex(spr, "AInvoice") > -1 Then z3412.AInvoice = getDataM(spr, getColumnIndex(spr, "AInvoice"), xRow)
            If getColumnIndex(spr, "ARemark") > -1 Then z3412.ARemark = getDataM(spr, getColumnIndex(spr, "ARemark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K3412_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K3412_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z3412 As T3412_AREA, Job As String, PURCHASINGORDERNO As String, PURCHASINGORDERSEQ As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K3412_MOVE = False

        Try
            If READ_PFK3412(PURCHASINGORDERNO, PURCHASINGORDERSEQ) = True Then
                z3412 = D3412
                K3412_MOVE = True
            Else
                z3412 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3412")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "PURCHASINGORDERNO" : z3412.PurchasingOrderNo = Children(i).Code
                                Case "PURCHASINGORDERSEQ" : z3412.PurchasingOrderSeq = Children(i).Code
                                Case "SESITE" : z3412.seSite = Children(i).Code
                                Case "CDSITE" : z3412.cdSite = Children(i).Code
                                Case "SEDEPARTMENT" : z3412.seDepartment = Children(i).Code
                                Case "CDDEPARTMENT" : z3412.cdDepartment = Children(i).Code
                                Case "SEFACTORY" : z3412.seFactory = Children(i).Code
                                Case "CDFACTORY" : z3412.cdFactory = Children(i).Code
                                Case "CUSTOMERSUPPLIER" : z3412.CustomerSupplier = Children(i).Code
                                Case "DSEQ" : z3412.Dseq = Children(i).Code
                                Case "AUTOKEYK3011" : z3412.AutokeyK3011 = Children(i).Code
                                Case "CHECKRELATIONTYPE" : z3412.CheckRelationType = Children(i).Code
                                Case "MATERIALCODE" : z3412.MaterialCode = Children(i).Code
                                Case "SPECIFICATION" : z3412.Specification = Children(i).Code
                                Case "WIDTH" : z3412.Width = Children(i).Code
                                Case "HEIGHT" : z3412.Height = Children(i).Code
                                Case "SIZENO" : z3412.SizeNo = Children(i).Code
                                Case "SIZENAME" : z3412.SizeName = Children(i).Code
                                Case "COLORCODE" : z3412.ColorCode = Children(i).Code
                                Case "COLORNAME" : z3412.ColorName = Children(i).Code
                                Case "SEORIGIN" : z3412.seOrigin = Children(i).Code
                                Case "CDORIGIN" : z3412.cdOrigin = Children(i).Code
                                Case "MATERIALCHECK" : z3412.MaterialCheck = Children(i).Code
                                Case "SEUNITPRICE" : z3412.seUnitPrice = Children(i).Code
                                Case "CDUNITPRICE" : z3412.cdUnitPrice = Children(i).Code
                                Case "SETAX" : z3412.seTax = Children(i).Code
                                Case "CDTAX" : z3412.cdTax = Children(i).Code
                                Case "SEUNITMATERIAL" : z3412.seUnitMaterial = Children(i).Code
                                Case "CDUNITMATERIAL" : z3412.cdUnitMaterial = Children(i).Code
                                Case "SEUNITPACKING" : z3412.seUnitPacking = Children(i).Code
                                Case "CDUNITPACKING" : z3412.cdUnitPacking = Children(i).Code
                                Case "UNITBASECHECK" : z3412.UnitBaseCheck = Children(i).Code
                                Case "QTYBASIC" : z3412.QtyBasic = Children(i).Code
                                Case "PRICEPURCHASING" : z3412.PricePurchasing = Children(i).Code
                                Case "PRICEMARKET" : z3412.PriceMarket = Children(i).Code
                                Case "PRICEEXCHANGEAP" : z3412.PriceExchangeAP = Children(i).Code
                                Case "PRICEEXCHANGE" : z3412.PriceExchange = Children(i).Code
                                Case "DATEEXCHANGE" : z3412.DateExchange = Children(i).Code
                                Case "PRICEPURCHASINGEX" : z3412.PricePurchasingEX = Children(i).Code
                                Case "PRICEMARKETEX" : z3412.PriceMarketEX = Children(i).Code
                                Case "PRICEPURCHASINGVND" : z3412.PricePurchasingVND = Children(i).Code
                                Case "PRICEMARKETVND" : z3412.PriceMarketVND = Children(i).Code
                                Case "AMOUNTPURCHASINGEX" : z3412.AmountPurchasingEX = Children(i).Code
                                Case "AMOUNTPURCHASINGVND" : z3412.AmountPurchasingVND = Children(i).Code
                                Case "AMOUNTTAXEX" : z3412.AmountTaxEX = Children(i).Code
                                Case "AMOUNTTAXVND" : z3412.AmountTaxVND = Children(i).Code
                                Case "SETAX1" : z3412.seTax1 = Children(i).Code
                                Case "CDTAX1" : z3412.cdTax1 = Children(i).Code
                                Case "PERTAX1" : z3412.PerTax1 = Children(i).Code
                                Case "AMOUNTTAX1EX" : z3412.AmountTax1EX = Children(i).Code
                                Case "AMOUNTTAX1" : z3412.AmountTax1 = Children(i).Code
                                Case "SETAX2" : z3412.seTax2 = Children(i).Code
                                Case "CDTAX2" : z3412.cdTax2 = Children(i).Code
                                Case "PERTAX2" : z3412.PerTax2 = Children(i).Code
                                Case "AMOUNTTAX2EX" : z3412.AmountTax2EX = Children(i).Code
                                Case "AMOUNTTAX2" : z3412.AmountTax2 = Children(i).Code
                                Case "SETAX3" : z3412.seTax3 = Children(i).Code
                                Case "CDTAX3" : z3412.cdTax3 = Children(i).Code
                                Case "PERTAX3" : z3412.PerTax3 = Children(i).Code
                                Case "AMOUNTTAX3EX" : z3412.AmountTax3EX = Children(i).Code
                                Case "AMOUNTTAX3" : z3412.AmountTax3 = Children(i).Code
                                Case "QTYBOOKING" : z3412.QtyBooking = Children(i).Code
                                Case "QTYPURCHASINGNET" : z3412.QtyPurchasingNet = Children(i).Code
                                Case "QTYPURCHASINGMOQ" : z3412.QtyPurchasingMOQ = Children(i).Code
                                Case "QTYPURCHASING" : z3412.QtyPurchasing = Children(i).Code
                                Case "PACKPURCHASING" : z3412.PackPurchasing = Children(i).Code
                                Case "AMOUNTPSC" : z3412.AmountPSC = Children(i).Code
                                Case "AMOUNTEX" : z3412.AmountEX = Children(i).Code
                                Case "AMOUNTVND" : z3412.AmountVND = Children(i).Code
                                Case "AMOUNTNOVATEX" : z3412.AmountNoVATEX = Children(i).Code
                                Case "AMOUNTNOVATVND" : z3412.AmountNoVATVND = Children(i).Code
                                Case "AMOUNTTOTALEX" : z3412.AmountTotalEX = Children(i).Code
                                Case "AMOUNTTOTALVND" : z3412.AmountTotalVND = Children(i).Code
                                Case "TOTALQTYPURCHASING" : z3412.TotalQtyPurchasing = Children(i).Code
                                Case "TOTALPACKPURCHASING" : z3412.TotalPackPurchasing = Children(i).Code
                                Case "QTYWAREHOUSE" : z3412.QtyWarehouse = Children(i).Code
                                Case "PACKWAREHOUSE" : z3412.PackWarehouse = Children(i).Code
                                Case "DATEDELIVERY" : z3412.DateDelivery = Children(i).Code
                                Case "DATESTART" : z3412.DateStart = Children(i).Code
                                Case "DATEFINISH" : z3412.DateFinish = Children(i).Code
                                Case "CHECKPURCHASING" : z3412.CheckPurchasing = Children(i).Code
                                Case "DATEACCEPT" : z3412.DateAccept = Children(i).Code
                                Case "DATEPOSTED" : z3412.DatePosted = Children(i).Code
                                Case "ISPOSTED" : z3412.IsPosted = Children(i).Code
                                Case "DATECOMPLETE" : z3412.DateComplete = Children(i).Code
                                Case "DATEAPPROVAL" : z3412.DateApproval = Children(i).Code
                                Case "DATECANCEL" : z3412.DateCancel = Children(i).Code
                                Case "CHECKCOMPLETE" : z3412.CheckComplete = Children(i).Code
                                Case "PURCHASINGREQUESTNO" : z3412.PurchasingRequestNo = Children(i).Code
                                Case "PURCHASINGREQUESTSEQ" : z3412.PurchasingRequestSeq = Children(i).Code
                                Case "ORDERNO" : z3412.OrderNo = Children(i).Code
                                Case "ORDERNOSEQ" : z3412.OrderNoSeq = Children(i).Code
                                Case "PURCHASINGORDERNO_BF" : z3412.PurchasingOrderNo_Bf = Children(i).Code
                                Case "PURCHASINGORDERSEQ_BF" : z3412.PurchasingOrderSeq_Bf = Children(i).Code
                                Case "REMARK" : z3412.Remark = Children(i).Code
                                Case "TIMEINSERT" : z3412.TimeInsert = Children(i).Code
                                Case "TIMEUPDATE" : z3412.TimeUpdate = Children(i).Code
                                Case "DATEINSERT" : z3412.DateInsert = Children(i).Code
                                Case "DATEUPDATE" : z3412.DateUpdate = Children(i).Code
                                Case "INCHARGEINSERT" : z3412.InchargeInsert = Children(i).Code
                                Case "INCHARGEUPDATE" : z3412.InchargeUpdate = Children(i).Code
                                Case "PRICEAPURCHASING" : z3412.PriceAPurchasing = Children(i).Code
                                Case "CDUNITMATERIALA" : z3412.cdUnitMaterialA = Children(i).Code
                                Case "CDUNITPRICEA" : z3412.cdUnitPriceA = Children(i).Code
                                Case "QTYAPURCHASING" : z3412.QtyAPurchasing = Children(i).Code
                                Case "QTYATOTAL" : z3412.QtyATotal = Children(i).Code
                                Case "AMTAPURCHASING" : z3412.AmtAPurchasing = Children(i).Code
                                Case "AMTATOTAL" : z3412.AmtATotal = Children(i).Code
                                Case "INVOICENO1" : z3412.InvoiceNo1 = Children(i).Code
                                Case "INVOICENO2" : z3412.InvoiceNo2 = Children(i).Code
                                Case "INVOICENO3" : z3412.InvoiceNo3 = Children(i).Code
                                Case "INVOICENO4" : z3412.InvoiceNo4 = Children(i).Code
                                Case "INVOICENO5" : z3412.InvoiceNo5 = Children(i).Code
                                Case "INVOICENO6" : z3412.InvoiceNo6 = Children(i).Code
                                Case "INVOICENO7" : z3412.InvoiceNo7 = Children(i).Code
                                Case "INVOICENO8" : z3412.InvoiceNo8 = Children(i).Code
                                Case "INVOICENO9" : z3412.InvoiceNo9 = Children(i).Code
                                Case "INVOICEN10" : z3412.InvoiceNo8 = Children(i).Code

                                Case "DATEARRIVE1" : z3412.DateArrive1 = Children(i).Code
                                Case "DATEARRIVE2" : z3412.DateArrive2 = Children(i).Code
                                Case "DATEARRIVE3" : z3412.DateArrive3 = Children(i).Code
                                Case "DATEARRIVE4" : z3412.DateArrive4 = Children(i).Code
                                Case "DATEARRIVE5" : z3412.DateArrive5 = Children(i).Code
                                Case "DATEARRIVE6" : z3412.DateArrive6 = Children(i).Code
                                Case "DATEARRIVE7" : z3412.DateArrive7 = Children(i).Code
                                Case "DATEARRIVE8" : z3412.DateArrive8 = Children(i).Code
                                Case "DATEARRIVE9" : z3412.DateArrive9 = Children(i).Code
                                Case "DATEARRIVE10" : z3412.DateArrive10 = Children(i).Code

                                Case "QTYAARRIVE1" : z3412.QtyAArrive1 = Children(i).Code
                                Case "QTYAARRIVE2" : z3412.QtyAArrive2 = Children(i).Code
                                Case "QTYAARRIVE3" : z3412.QtyAArrive3 = Children(i).Code
                                Case "QTYAARRIVE4" : z3412.QtyAArrive4 = Children(i).Code
                                Case "QTYAARRIVE5" : z3412.QtyAArrive5 = Children(i).Code
                                Case "QTYAARRIVE6" : z3412.QtyAArrive6 = Children(i).Code
                                Case "QTYAARRIVE7" : z3412.QtyAArrive7 = Children(i).Code
                                Case "QTYAARRIVE8" : z3412.QtyAArrive8 = Children(i).Code
                                Case "QTYAARRIVE9" : z3412.QtyAArrive9 = Children(i).Code
                                Case "QTYAARRIVE10" : z3412.QtyAArrive10 = Children(i).Code

                                Case "INCHARGEINVOICE" : z3412.InchargeInvoice = Children(i).Code
                                Case "APLNAME" : z3412.APLName = Children(i).Code
                                Case "AINVOICE" : z3412.AInvoice = Children(i).Code
                                Case "AREMARK" : z3412.ARemark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "PURCHASINGORDERNO" : z3412.PurchasingOrderNo = Children(i).Data
                                Case "PURCHASINGORDERSEQ" : z3412.PurchasingOrderSeq = Cdecp(Children(i).Data)
                                Case "SESITE" : z3412.seSite = Children(i).Data
                                Case "CDSITE" : z3412.cdSite = Children(i).Data
                                Case "SEDEPARTMENT" : z3412.seDepartment = Children(i).Data
                                Case "CDDEPARTMENT" : z3412.cdDepartment = Children(i).Data
                                Case "SEFACTORY" : z3412.seFactory = Children(i).Data
                                Case "CDFACTORY" : z3412.cdFactory = Children(i).Data
                                Case "CUSTOMERSUPPLIER" : z3412.CustomerSupplier = Children(i).Data
                                Case "DSEQ" : z3412.Dseq = Cdecp(Children(i).Data)
                                Case "AUTOKEYK3011" : z3412.AutokeyK3011 = Cdecp(Children(i).Data)
                                Case "CHECKRELATIONTYPE" : z3412.CheckRelationType = Children(i).Data
                                Case "MATERIALCODE" : z3412.MaterialCode = Children(i).Data
                                Case "SPECIFICATION" : z3412.Specification = Children(i).Data
                                Case "WIDTH" : z3412.Width = Children(i).Data
                                Case "HEIGHT" : z3412.Height = Children(i).Data
                                Case "SIZENO" : z3412.SizeNo = Children(i).Data
                                Case "SIZENAME" : z3412.SizeName = Children(i).Data
                                Case "COLORCODE" : z3412.ColorCode = Children(i).Data
                                Case "COLORNAME" : z3412.ColorName = Children(i).Data
                                Case "SEORIGIN" : z3412.seOrigin = Children(i).Data
                                Case "CDORIGIN" : z3412.cdOrigin = Children(i).Data
                                Case "MATERIALCHECK" : z3412.MaterialCheck = Children(i).Data
                                Case "SEUNITPRICE" : z3412.seUnitPrice = Children(i).Data
                                Case "CDUNITPRICE" : z3412.cdUnitPrice = Children(i).Data
                                Case "SETAX" : z3412.seTax = Children(i).Data
                                Case "CDTAX" : z3412.cdTax = Children(i).Data
                                Case "SEUNITMATERIAL" : z3412.seUnitMaterial = Children(i).Data
                                Case "CDUNITMATERIAL" : z3412.cdUnitMaterial = Children(i).Data
                                Case "SEUNITPACKING" : z3412.seUnitPacking = Children(i).Data
                                Case "CDUNITPACKING" : z3412.cdUnitPacking = Children(i).Data
                                Case "UNITBASECHECK" : z3412.UnitBaseCheck = Children(i).Data
                                Case "QTYBASIC" : z3412.QtyBasic = Cdecp(Children(i).Data)
                                Case "PRICEPURCHASING" : z3412.PricePurchasing = Cdecp(Children(i).Data)
                                Case "PRICEMARKET" : z3412.PriceMarket = Cdecp(Children(i).Data)
                                Case "PRICEEXCHANGEAP" : z3412.PriceExchangeAP = Cdecp(Children(i).Data)
                                Case "PRICEEXCHANGE" : z3412.PriceExchange = Cdecp(Children(i).Data)
                                Case "DATEEXCHANGE" : z3412.DateExchange = Children(i).Data
                                Case "PRICEPURCHASINGEX" : z3412.PricePurchasingEX = Cdecp(Children(i).Data)
                                Case "PRICEMARKETEX" : z3412.PriceMarketEX = Cdecp(Children(i).Data)
                                Case "PRICEPURCHASINGVND" : z3412.PricePurchasingVND = Cdecp(Children(i).Data)
                                Case "PRICEMARKETVND" : z3412.PriceMarketVND = Cdecp(Children(i).Data)
                                Case "AMOUNTPURCHASINGEX" : z3412.AmountPurchasingEX = Cdecp(Children(i).Data)
                                Case "AMOUNTPURCHASINGVND" : z3412.AmountPurchasingVND = Cdecp(Children(i).Data)
                                Case "AMOUNTTAXEX" : z3412.AmountTaxEX = Cdecp(Children(i).Data)
                                Case "AMOUNTTAXVND" : z3412.AmountTaxVND = Cdecp(Children(i).Data)
                                Case "SETAX1" : z3412.seTax1 = Children(i).Data
                                Case "CDTAX1" : z3412.cdTax1 = Children(i).Data
                                Case "PERTAX1" : z3412.PerTax1 = Cdecp(Children(i).Data)
                                Case "AMOUNTTAX1EX" : z3412.AmountTax1EX = Cdecp(Children(i).Data)
                                Case "AMOUNTTAX1" : z3412.AmountTax1 = Cdecp(Children(i).Data)
                                Case "SETAX2" : z3412.seTax2 = Children(i).Data
                                Case "CDTAX2" : z3412.cdTax2 = Children(i).Data
                                Case "PERTAX2" : z3412.PerTax2 = Cdecp(Children(i).Data)
                                Case "AMOUNTTAX2EX" : z3412.AmountTax2EX = Cdecp(Children(i).Data)
                                Case "AMOUNTTAX2" : z3412.AmountTax2 = Cdecp(Children(i).Data)
                                Case "SETAX3" : z3412.seTax3 = Children(i).Data
                                Case "CDTAX3" : z3412.cdTax3 = Children(i).Data
                                Case "PERTAX3" : z3412.PerTax3 = Cdecp(Children(i).Data)
                                Case "AMOUNTTAX3EX" : z3412.AmountTax3EX = Cdecp(Children(i).Data)
                                Case "AMOUNTTAX3" : z3412.AmountTax3 = Cdecp(Children(i).Data)
                                Case "QTYBOOKING" : z3412.QtyBooking = Cdecp(Children(i).Data)
                                Case "QTYPURCHASINGNET" : z3412.QtyPurchasingNet = Cdecp(Children(i).Data)
                                Case "QTYPURCHASINGMOQ" : z3412.QtyPurchasingMOQ = Cdecp(Children(i).Data)
                                Case "QTYPURCHASING" : z3412.QtyPurchasing = Cdecp(Children(i).Data)
                                Case "PACKPURCHASING" : z3412.PackPurchasing = Cdecp(Children(i).Data)
                                Case "AMOUNTPSC" : z3412.AmountPSC = Cdecp(Children(i).Data)
                                Case "AMOUNTEX" : z3412.AmountEX = Cdecp(Children(i).Data)
                                Case "AMOUNTVND" : z3412.AmountVND = Cdecp(Children(i).Data)
                                Case "AMOUNTNOVATEX" : z3412.AmountNoVATEX = Cdecp(Children(i).Data)
                                Case "AMOUNTNOVATVND" : z3412.AmountNoVATVND = Cdecp(Children(i).Data)
                                Case "AMOUNTTOTALEX" : z3412.AmountTotalEX = Cdecp(Children(i).Data)
                                Case "AMOUNTTOTALVND" : z3412.AmountTotalVND = Cdecp(Children(i).Data)
                                Case "TOTALQTYPURCHASING" : z3412.TotalQtyPurchasing = Cdecp(Children(i).Data)
                                Case "TOTALPACKPURCHASING" : z3412.TotalPackPurchasing = Cdecp(Children(i).Data)
                                Case "QTYWAREHOUSE" : z3412.QtyWarehouse = Cdecp(Children(i).Data)
                                Case "PACKWAREHOUSE" : z3412.PackWarehouse = Cdecp(Children(i).Data)
                                Case "DATEDELIVERY" : z3412.DateDelivery = Children(i).Data
                                Case "DATESTART" : z3412.DateStart = Children(i).Data
                                Case "DATEFINISH" : z3412.DateFinish = Children(i).Data
                                Case "CHECKPURCHASING" : z3412.CheckPurchasing = Children(i).Data
                                Case "DATEACCEPT" : z3412.DateAccept = Children(i).Data
                                Case "DATEPOSTED" : z3412.DatePosted = Children(i).Data
                                Case "ISPOSTED" : z3412.IsPosted = Children(i).Data
                                Case "DATECOMPLETE" : z3412.DateComplete = Children(i).Data
                                Case "DATEAPPROVAL" : z3412.DateApproval = Children(i).Data
                                Case "DATECANCEL" : z3412.DateCancel = Children(i).Data
                                Case "CHECKCOMPLETE" : z3412.CheckComplete = Children(i).Data
                                Case "PURCHASINGREQUESTNO" : z3412.PurchasingRequestNo = Children(i).Data
                                Case "PURCHASINGREQUESTSEQ" : z3412.PurchasingRequestSeq = Cdecp(Children(i).Data)
                                Case "ORDERNO" : z3412.OrderNo = Children(i).Data
                                Case "ORDERNOSEQ" : z3412.OrderNoSeq = Children(i).Data
                                Case "PURCHASINGORDERNO_BF" : z3412.PurchasingOrderNo_Bf = Children(i).Data
                                Case "PURCHASINGORDERSEQ_BF" : z3412.PurchasingOrderSeq_Bf = Cdecp(Children(i).Data)
                                Case "REMARK" : z3412.Remark = Children(i).Data
                                Case "TIMEINSERT" : z3412.TimeInsert = Children(i).Data
                                Case "TIMEUPDATE" : z3412.TimeUpdate = Children(i).Data
                                Case "DATEINSERT" : z3412.DateInsert = Children(i).Data
                                Case "DATEUPDATE" : z3412.DateUpdate = Children(i).Data
                                Case "INCHARGEINSERT" : z3412.InchargeInsert = Children(i).Data
                                Case "INCHARGEUPDATE" : z3412.InchargeUpdate = Children(i).Data
                                Case "PRICEAPURCHASING" : z3412.PriceAPurchasing = Cdecp(Children(i).Data)
                                Case "CDUNITMATERIALA" : z3412.cdUnitMaterialA = Children(i).Data
                                Case "CDUNITPRICEA" : z3412.cdUnitPriceA = Children(i).Data
                                Case "QTYAPURCHASING" : z3412.QtyAPurchasing = Cdecp(Children(i).Data)
                                Case "QTYATOTAL" : z3412.QtyATotal = Cdecp(Children(i).Data)
                                Case "AMTAPURCHASING" : z3412.AmtAPurchasing = Cdecp(Children(i).Data)
                                Case "AMTATOTAL" : z3412.AmtATotal = Cdecp(Children(i).Data)
                                Case "INVOICENO1" : z3412.InvoiceNo1 = Children(i).Data
                                Case "INVOICENO2" : z3412.InvoiceNo2 = Children(i).Data
                                Case "INVOICENO3" : z3412.InvoiceNo3 = Children(i).Data
                                Case "INVOICENO4" : z3412.InvoiceNo4 = Children(i).Data
                                Case "INVOICENO5" : z3412.InvoiceNo5 = Children(i).Data
                                Case "INVOICENO6" : z3412.InvoiceNo6 = Children(i).Data
                                Case "INVOICENO7" : z3412.InvoiceNo7 = Children(i).Data
                                Case "INVOICENO8" : z3412.InvoiceNo8 = Children(i).Data
                                Case "INVOICENO9" : z3412.InvoiceNo9 = Children(i).Data
                                Case "INVOICEN10" : z3412.InvoiceNo10 = Children(i).Data

                                Case "DATEARRIVE1" : z3412.DateArrive1 = Children(i).Data
                                Case "DATEARRIVE2" : z3412.DateArrive2 = Children(i).Data
                                Case "DATEARRIVE3" : z3412.DateArrive3 = Children(i).Data
                                Case "DATEARRIVE4" : z3412.DateArrive4 = Children(i).Data
                                Case "DATEARRIVE5" : z3412.DateArrive5 = Children(i).Data
                                Case "DATEARRIVE6" : z3412.DateArrive6 = Children(i).Data
                                Case "DATEARRIVE7" : z3412.DateArrive7 = Children(i).Data
                                Case "DATEARRIVE8" : z3412.DateArrive8 = Children(i).Data
                                Case "DATEARRIVE9" : z3412.DateArrive9 = Children(i).Data
                                Case "DATEARRIVE10" : z3412.DateArrive10 = Children(i).Data

                                Case "QTYAARRIVE1" : z3412.QtyAArrive1 = Cdecp(Children(i).Data)
                                Case "QTYAARRIVE2" : z3412.QtyAArrive2 = Cdecp(Children(i).Data)
                                Case "QTYAARRIVE3" : z3412.QtyAArrive3 = Cdecp(Children(i).Data)
                                Case "QTYAARRIVE4" : z3412.QtyAArrive4 = Cdecp(Children(i).Data)
                                Case "QTYAARRIVE5" : z3412.QtyAArrive5 = CDecp(Children(i).Data)
                                Case "QTYAARRIVE6" : z3412.QtyAArrive6 = CDecp(Children(i).Data)
                                Case "QTYAARRIVE7" : z3412.QtyAArrive7 = CDecp(Children(i).Data)
                                Case "QTYAARRIVE8" : z3412.QtyAArrive8 = CDecp(Children(i).Data)
                                Case "QTYAARRIVE9" : z3412.QtyAArrive9 = CDecp(Children(i).Data)
                                Case "QTYAARRIVE10" : z3412.QtyAArrive10 = CDecp(Children(i).Data)

                                Case "INCHARGEINVOICE" : z3412.InchargeInvoice = Children(i).Data
                                Case "APLNAME" : z3412.APLName = Children(i).Data
                                Case "AINVOICE" : z3412.AInvoice = Children(i).Data
                                Case "AREMARK" : z3412.ARemark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K3412_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K3412_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z3412 As T3412_AREA, Job As String, CheckClear As Boolean, PURCHASINGORDERNO As String, PURCHASINGORDERSEQ As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K3412_MOVE = False

        Try
            If READ_PFK3412(PURCHASINGORDERNO, PURCHASINGORDERSEQ) = True Then
                z3412 = D3412
                K3412_MOVE = True
            Else
                If CheckClear = True Then z3412 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3412")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "PURCHASINGORDERNO" : z3412.PurchasingOrderNo = Children(i).Code
                                Case "PURCHASINGORDERSEQ" : z3412.PurchasingOrderSeq = Children(i).Code
                                Case "SESITE" : z3412.seSite = Children(i).Code
                                Case "CDSITE" : z3412.cdSite = Children(i).Code
                                Case "SEDEPARTMENT" : z3412.seDepartment = Children(i).Code
                                Case "CDDEPARTMENT" : z3412.cdDepartment = Children(i).Code
                                Case "SEFACTORY" : z3412.seFactory = Children(i).Code
                                Case "CDFACTORY" : z3412.cdFactory = Children(i).Code
                                Case "CUSTOMERSUPPLIER" : z3412.CustomerSupplier = Children(i).Code
                                Case "DSEQ" : z3412.Dseq = Children(i).Code
                                Case "AUTOKEYK3011" : z3412.AutokeyK3011 = Children(i).Code
                                Case "CHECKRELATIONTYPE" : z3412.CheckRelationType = Children(i).Code
                                Case "MATERIALCODE" : z3412.MaterialCode = Children(i).Code
                                Case "SPECIFICATION" : z3412.Specification = Children(i).Code
                                Case "WIDTH" : z3412.Width = Children(i).Code
                                Case "HEIGHT" : z3412.Height = Children(i).Code
                                Case "SIZENO" : z3412.SizeNo = Children(i).Code
                                Case "SIZENAME" : z3412.SizeName = Children(i).Code
                                Case "COLORCODE" : z3412.ColorCode = Children(i).Code
                                Case "COLORNAME" : z3412.ColorName = Children(i).Code
                                Case "SEORIGIN" : z3412.seOrigin = Children(i).Code
                                Case "CDORIGIN" : z3412.cdOrigin = Children(i).Code
                                Case "MATERIALCHECK" : z3412.MaterialCheck = Children(i).Code
                                Case "SEUNITPRICE" : z3412.seUnitPrice = Children(i).Code
                                Case "CDUNITPRICE" : z3412.cdUnitPrice = Children(i).Code
                                Case "SETAX" : z3412.seTax = Children(i).Code
                                Case "CDTAX" : z3412.cdTax = Children(i).Code
                                Case "SEUNITMATERIAL" : z3412.seUnitMaterial = Children(i).Code
                                Case "CDUNITMATERIAL" : z3412.cdUnitMaterial = Children(i).Code
                                Case "SEUNITPACKING" : z3412.seUnitPacking = Children(i).Code
                                Case "CDUNITPACKING" : z3412.cdUnitPacking = Children(i).Code
                                Case "UNITBASECHECK" : z3412.UnitBaseCheck = Children(i).Code
                                Case "QTYBASIC" : z3412.QtyBasic = Children(i).Code
                                Case "PRICEPURCHASING" : z3412.PricePurchasing = Children(i).Code
                                Case "PRICEMARKET" : z3412.PriceMarket = Children(i).Code
                                Case "PRICEEXCHANGEAP" : z3412.PriceExchangeAP = Children(i).Code
                                Case "PRICEEXCHANGE" : z3412.PriceExchange = Children(i).Code
                                Case "DATEEXCHANGE" : z3412.DateExchange = Children(i).Code
                                Case "PRICEPURCHASINGEX" : z3412.PricePurchasingEX = Children(i).Code
                                Case "PRICEMARKETEX" : z3412.PriceMarketEX = Children(i).Code
                                Case "PRICEPURCHASINGVND" : z3412.PricePurchasingVND = Children(i).Code
                                Case "PRICEMARKETVND" : z3412.PriceMarketVND = Children(i).Code
                                Case "AMOUNTPURCHASINGEX" : z3412.AmountPurchasingEX = Children(i).Code
                                Case "AMOUNTPURCHASINGVND" : z3412.AmountPurchasingVND = Children(i).Code
                                Case "AMOUNTTAXEX" : z3412.AmountTaxEX = Children(i).Code
                                Case "AMOUNTTAXVND" : z3412.AmountTaxVND = Children(i).Code
                                Case "SETAX1" : z3412.seTax1 = Children(i).Code
                                Case "CDTAX1" : z3412.cdTax1 = Children(i).Code
                                Case "PERTAX1" : z3412.PerTax1 = Children(i).Code
                                Case "AMOUNTTAX1EX" : z3412.AmountTax1EX = Children(i).Code
                                Case "AMOUNTTAX1" : z3412.AmountTax1 = Children(i).Code
                                Case "SETAX2" : z3412.seTax2 = Children(i).Code
                                Case "CDTAX2" : z3412.cdTax2 = Children(i).Code
                                Case "PERTAX2" : z3412.PerTax2 = Children(i).Code
                                Case "AMOUNTTAX2EX" : z3412.AmountTax2EX = Children(i).Code
                                Case "AMOUNTTAX2" : z3412.AmountTax2 = Children(i).Code
                                Case "SETAX3" : z3412.seTax3 = Children(i).Code
                                Case "CDTAX3" : z3412.cdTax3 = Children(i).Code
                                Case "PERTAX3" : z3412.PerTax3 = Children(i).Code
                                Case "AMOUNTTAX3EX" : z3412.AmountTax3EX = Children(i).Code
                                Case "AMOUNTTAX3" : z3412.AmountTax3 = Children(i).Code
                                Case "QTYBOOKING" : z3412.QtyBooking = Children(i).Code
                                Case "QTYPURCHASINGNET" : z3412.QtyPurchasingNet = Children(i).Code
                                Case "QTYPURCHASINGMOQ" : z3412.QtyPurchasingMOQ = Children(i).Code
                                Case "QTYPURCHASING" : z3412.QtyPurchasing = Children(i).Code
                                Case "PACKPURCHASING" : z3412.PackPurchasing = Children(i).Code
                                Case "AMOUNTPSC" : z3412.AmountPSC = Children(i).Code
                                Case "AMOUNTEX" : z3412.AmountEX = Children(i).Code
                                Case "AMOUNTVND" : z3412.AmountVND = Children(i).Code
                                Case "AMOUNTNOVATEX" : z3412.AmountNoVATEX = Children(i).Code
                                Case "AMOUNTNOVATVND" : z3412.AmountNoVATVND = Children(i).Code
                                Case "AMOUNTTOTALEX" : z3412.AmountTotalEX = Children(i).Code
                                Case "AMOUNTTOTALVND" : z3412.AmountTotalVND = Children(i).Code
                                Case "TOTALQTYPURCHASING" : z3412.TotalQtyPurchasing = Children(i).Code
                                Case "TOTALPACKPURCHASING" : z3412.TotalPackPurchasing = Children(i).Code
                                Case "QTYWAREHOUSE" : z3412.QtyWarehouse = Children(i).Code
                                Case "PACKWAREHOUSE" : z3412.PackWarehouse = Children(i).Code
                                Case "DATEDELIVERY" : z3412.DateDelivery = Children(i).Code
                                Case "DATESTART" : z3412.DateStart = Children(i).Code
                                Case "DATEFINISH" : z3412.DateFinish = Children(i).Code
                                Case "CHECKPURCHASING" : z3412.CheckPurchasing = Children(i).Code
                                Case "DATEACCEPT" : z3412.DateAccept = Children(i).Code
                                Case "DATEPOSTED" : z3412.DatePosted = Children(i).Code
                                Case "ISPOSTED" : z3412.IsPosted = Children(i).Code
                                Case "DATECOMPLETE" : z3412.DateComplete = Children(i).Code
                                Case "DATEAPPROVAL" : z3412.DateApproval = Children(i).Code
                                Case "DATECANCEL" : z3412.DateCancel = Children(i).Code
                                Case "CHECKCOMPLETE" : z3412.CheckComplete = Children(i).Code
                                Case "PURCHASINGREQUESTNO" : z3412.PurchasingRequestNo = Children(i).Code
                                Case "PURCHASINGREQUESTSEQ" : z3412.PurchasingRequestSeq = Children(i).Code
                                Case "ORDERNO" : z3412.OrderNo = Children(i).Code
                                Case "ORDERNOSEQ" : z3412.OrderNoSeq = Children(i).Code
                                Case "PURCHASINGORDERNO_BF" : z3412.PurchasingOrderNo_Bf = Children(i).Code
                                Case "PURCHASINGORDERSEQ_BF" : z3412.PurchasingOrderSeq_Bf = Children(i).Code
                                Case "REMARK" : z3412.Remark = Children(i).Code
                                Case "TIMEINSERT" : z3412.TimeInsert = Children(i).Code
                                Case "TIMEUPDATE" : z3412.TimeUpdate = Children(i).Code
                                Case "DATEINSERT" : z3412.DateInsert = Children(i).Code
                                Case "DATEUPDATE" : z3412.DateUpdate = Children(i).Code
                                Case "INCHARGEINSERT" : z3412.InchargeInsert = Children(i).Code
                                Case "INCHARGEUPDATE" : z3412.InchargeUpdate = Children(i).Code
                                Case "PRICEAPURCHASING" : z3412.PriceAPurchasing = Children(i).Code
                                Case "CDUNITMATERIALA" : z3412.cdUnitMaterialA = Children(i).Code
                                Case "CDUNITPRICEA" : z3412.cdUnitPriceA = Children(i).Code
                                Case "QTYAPURCHASING" : z3412.QtyAPurchasing = Children(i).Code
                                Case "QTYATOTAL" : z3412.QtyATotal = Children(i).Code
                                Case "AMTAPURCHASING" : z3412.AmtAPurchasing = Children(i).Code
                                Case "AMTATOTAL" : z3412.AmtATotal = Children(i).Code
                                Case "INVOICENO1" : z3412.InvoiceNo1 = Children(i).Code
                                Case "INVOICENO2" : z3412.InvoiceNo2 = Children(i).Code
                                Case "INVOICENO3" : z3412.InvoiceNo3 = Children(i).Code
                                Case "INVOICENO4" : z3412.InvoiceNo4 = Children(i).Code
                                Case "INVOICENO5" : z3412.InvoiceNo5 = Children(i).Code
                                Case "INVOICENO6" : z3412.InvoiceNo6 = Children(i).Code
                                Case "INVOICENO7" : z3412.InvoiceNo7 = Children(i).Code
                                Case "INVOICENO8" : z3412.InvoiceNo8 = Children(i).Code
                                Case "INVOICENO9" : z3412.InvoiceNo9 = Children(i).Code
                                Case "INVOICEN10" : z3412.InvoiceNo10 = Children(i).Code

                                Case "DATEARRIVE1" : z3412.DateArrive1 = Children(i).Code
                                Case "DATEARRIVE2" : z3412.DateArrive2 = Children(i).Code
                                Case "DATEARRIVE3" : z3412.DateArrive3 = Children(i).Code
                                Case "DATEARRIVE4" : z3412.DateArrive4 = Children(i).Code
                                Case "DATEARRIVE5" : z3412.DateArrive5 = Children(i).Code
                                Case "DATEARRIVE6" : z3412.DateArrive6 = Children(i).Code
                                Case "DATEARRIVE7" : z3412.DateArrive7 = Children(i).Code
                                Case "DATEARRIVE8" : z3412.DateArrive8 = Children(i).Code
                                Case "DATEARRIVE9" : z3412.DateArrive9 = Children(i).Code
                                Case "DATEARRIVE10" : z3412.DateArrive10 = Children(i).Code

                                Case "QTYAARRIVE1" : z3412.QtyAArrive1 = Children(i).Code
                                Case "QTYAARRIVE2" : z3412.QtyAArrive2 = Children(i).Code
                                Case "QTYAARRIVE3" : z3412.QtyAArrive3 = Children(i).Code
                                Case "QTYAARRIVE4" : z3412.QtyAArrive4 = Children(i).Code
                                Case "QTYAARRIVE5" : z3412.QtyAArrive5 = Children(i).Code
                                Case "QTYAARRIVE6" : z3412.QtyAArrive6 = Children(i).Code
                                Case "QTYAARRIVE7" : z3412.QtyAArrive7 = Children(i).Code
                                Case "QTYAARRIVE8" : z3412.QtyAArrive8 = Children(i).Code
                                Case "QTYAARRIVE9" : z3412.QtyAArrive9 = Children(i).Code
                                Case "QTYAARRIVE10" : z3412.QtyAArrive10 = Children(i).Code

                                Case "INCHARGEINVOICE" : z3412.InchargeInvoice = Children(i).Code
                                Case "APLNAME" : z3412.APLName = Children(i).Code
                                Case "AINVOICE" : z3412.AInvoice = Children(i).Code
                                Case "AREMARK" : z3412.ARemark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "PURCHASINGORDERNO" : z3412.PurchasingOrderNo = Children(i).Data
                                Case "PURCHASINGORDERSEQ" : z3412.PurchasingOrderSeq = Cdecp(Children(i).Data)
                                Case "SESITE" : z3412.seSite = Children(i).Data
                                Case "CDSITE" : z3412.cdSite = Children(i).Data
                                Case "SEDEPARTMENT" : z3412.seDepartment = Children(i).Data
                                Case "CDDEPARTMENT" : z3412.cdDepartment = Children(i).Data
                                Case "SEFACTORY" : z3412.seFactory = Children(i).Data
                                Case "CDFACTORY" : z3412.cdFactory = Children(i).Data
                                Case "CUSTOMERSUPPLIER" : z3412.CustomerSupplier = Children(i).Data
                                Case "DSEQ" : z3412.Dseq = Cdecp(Children(i).Data)
                                Case "AUTOKEYK3011" : z3412.AutokeyK3011 = Cdecp(Children(i).Data)
                                Case "CHECKRELATIONTYPE" : z3412.CheckRelationType = Children(i).Data
                                Case "MATERIALCODE" : z3412.MaterialCode = Children(i).Data
                                Case "SPECIFICATION" : z3412.Specification = Children(i).Data
                                Case "WIDTH" : z3412.Width = Children(i).Data
                                Case "HEIGHT" : z3412.Height = Children(i).Data
                                Case "SIZENO" : z3412.SizeNo = Children(i).Data
                                Case "SIZENAME" : z3412.SizeName = Children(i).Data
                                Case "COLORCODE" : z3412.ColorCode = Children(i).Data
                                Case "COLORNAME" : z3412.ColorName = Children(i).Data
                                Case "SEORIGIN" : z3412.seOrigin = Children(i).Data
                                Case "CDORIGIN" : z3412.cdOrigin = Children(i).Data
                                Case "MATERIALCHECK" : z3412.MaterialCheck = Children(i).Data
                                Case "SEUNITPRICE" : z3412.seUnitPrice = Children(i).Data
                                Case "CDUNITPRICE" : z3412.cdUnitPrice = Children(i).Data
                                Case "SETAX" : z3412.seTax = Children(i).Data
                                Case "CDTAX" : z3412.cdTax = Children(i).Data
                                Case "SEUNITMATERIAL" : z3412.seUnitMaterial = Children(i).Data
                                Case "CDUNITMATERIAL" : z3412.cdUnitMaterial = Children(i).Data
                                Case "SEUNITPACKING" : z3412.seUnitPacking = Children(i).Data
                                Case "CDUNITPACKING" : z3412.cdUnitPacking = Children(i).Data
                                Case "UNITBASECHECK" : z3412.UnitBaseCheck = Children(i).Data
                                Case "QTYBASIC" : z3412.QtyBasic = Cdecp(Children(i).Data)
                                Case "PRICEPURCHASING" : z3412.PricePurchasing = Cdecp(Children(i).Data)
                                Case "PRICEMARKET" : z3412.PriceMarket = Cdecp(Children(i).Data)
                                Case "PRICEEXCHANGEAP" : z3412.PriceExchangeAP = Cdecp(Children(i).Data)
                                Case "PRICEEXCHANGE" : z3412.PriceExchange = Cdecp(Children(i).Data)
                                Case "DATEEXCHANGE" : z3412.DateExchange = Children(i).Data
                                Case "PRICEPURCHASINGEX" : z3412.PricePurchasingEX = Cdecp(Children(i).Data)
                                Case "PRICEMARKETEX" : z3412.PriceMarketEX = Cdecp(Children(i).Data)
                                Case "PRICEPURCHASINGVND" : z3412.PricePurchasingVND = Cdecp(Children(i).Data)
                                Case "PRICEMARKETVND" : z3412.PriceMarketVND = Cdecp(Children(i).Data)
                                Case "AMOUNTPURCHASINGEX" : z3412.AmountPurchasingEX = Cdecp(Children(i).Data)
                                Case "AMOUNTPURCHASINGVND" : z3412.AmountPurchasingVND = Cdecp(Children(i).Data)
                                Case "AMOUNTTAXEX" : z3412.AmountTaxEX = Cdecp(Children(i).Data)
                                Case "AMOUNTTAXVND" : z3412.AmountTaxVND = Cdecp(Children(i).Data)
                                Case "SETAX1" : z3412.seTax1 = Children(i).Data
                                Case "CDTAX1" : z3412.cdTax1 = Children(i).Data
                                Case "PERTAX1" : z3412.PerTax1 = Cdecp(Children(i).Data)
                                Case "AMOUNTTAX1EX" : z3412.AmountTax1EX = Cdecp(Children(i).Data)
                                Case "AMOUNTTAX1" : z3412.AmountTax1 = Cdecp(Children(i).Data)
                                Case "SETAX2" : z3412.seTax2 = Children(i).Data
                                Case "CDTAX2" : z3412.cdTax2 = Children(i).Data
                                Case "PERTAX2" : z3412.PerTax2 = Cdecp(Children(i).Data)
                                Case "AMOUNTTAX2EX" : z3412.AmountTax2EX = Cdecp(Children(i).Data)
                                Case "AMOUNTTAX2" : z3412.AmountTax2 = Cdecp(Children(i).Data)
                                Case "SETAX3" : z3412.seTax3 = Children(i).Data
                                Case "CDTAX3" : z3412.cdTax3 = Children(i).Data
                                Case "PERTAX3" : z3412.PerTax3 = Cdecp(Children(i).Data)
                                Case "AMOUNTTAX3EX" : z3412.AmountTax3EX = Cdecp(Children(i).Data)
                                Case "AMOUNTTAX3" : z3412.AmountTax3 = Cdecp(Children(i).Data)
                                Case "QTYBOOKING" : z3412.QtyBooking = Cdecp(Children(i).Data)
                                Case "QTYPURCHASINGNET" : z3412.QtyPurchasingNet = Cdecp(Children(i).Data)
                                Case "QTYPURCHASINGMOQ" : z3412.QtyPurchasingMOQ = Cdecp(Children(i).Data)
                                Case "QTYPURCHASING" : z3412.QtyPurchasing = Cdecp(Children(i).Data)
                                Case "PACKPURCHASING" : z3412.PackPurchasing = Cdecp(Children(i).Data)
                                Case "AMOUNTPSC" : z3412.AmountPSC = Cdecp(Children(i).Data)
                                Case "AMOUNTEX" : z3412.AmountEX = Cdecp(Children(i).Data)
                                Case "AMOUNTVND" : z3412.AmountVND = Cdecp(Children(i).Data)
                                Case "AMOUNTNOVATEX" : z3412.AmountNoVATEX = Cdecp(Children(i).Data)
                                Case "AMOUNTNOVATVND" : z3412.AmountNoVATVND = Cdecp(Children(i).Data)
                                Case "AMOUNTTOTALEX" : z3412.AmountTotalEX = Cdecp(Children(i).Data)
                                Case "AMOUNTTOTALVND" : z3412.AmountTotalVND = Cdecp(Children(i).Data)
                                Case "TOTALQTYPURCHASING" : z3412.TotalQtyPurchasing = Cdecp(Children(i).Data)
                                Case "TOTALPACKPURCHASING" : z3412.TotalPackPurchasing = Cdecp(Children(i).Data)
                                Case "QTYWAREHOUSE" : z3412.QtyWarehouse = Cdecp(Children(i).Data)
                                Case "PACKWAREHOUSE" : z3412.PackWarehouse = Cdecp(Children(i).Data)
                                Case "DATEDELIVERY" : z3412.DateDelivery = Children(i).Data
                                Case "DATESTART" : z3412.DateStart = Children(i).Data
                                Case "DATEFINISH" : z3412.DateFinish = Children(i).Data
                                Case "CHECKPURCHASING" : z3412.CheckPurchasing = Children(i).Data
                                Case "DATEACCEPT" : z3412.DateAccept = Children(i).Data
                                Case "DATEPOSTED" : z3412.DatePosted = Children(i).Data
                                Case "ISPOSTED" : z3412.IsPosted = Children(i).Data
                                Case "DATECOMPLETE" : z3412.DateComplete = Children(i).Data
                                Case "DATEAPPROVAL" : z3412.DateApproval = Children(i).Data
                                Case "DATECANCEL" : z3412.DateCancel = Children(i).Data
                                Case "CHECKCOMPLETE" : z3412.CheckComplete = Children(i).Data
                                Case "PURCHASINGREQUESTNO" : z3412.PurchasingRequestNo = Children(i).Data
                                Case "PURCHASINGREQUESTSEQ" : z3412.PurchasingRequestSeq = Cdecp(Children(i).Data)
                                Case "ORDERNO" : z3412.OrderNo = Children(i).Data
                                Case "ORDERNOSEQ" : z3412.OrderNoSeq = Children(i).Data
                                Case "PURCHASINGORDERNO_BF" : z3412.PurchasingOrderNo_Bf = Children(i).Data
                                Case "PURCHASINGORDERSEQ_BF" : z3412.PurchasingOrderSeq_Bf = Cdecp(Children(i).Data)
                                Case "REMARK" : z3412.Remark = Children(i).Data
                                Case "TIMEINSERT" : z3412.TimeInsert = Children(i).Data
                                Case "TIMEUPDATE" : z3412.TimeUpdate = Children(i).Data
                                Case "DATEINSERT" : z3412.DateInsert = Children(i).Data
                                Case "DATEUPDATE" : z3412.DateUpdate = Children(i).Data
                                Case "INCHARGEINSERT" : z3412.InchargeInsert = Children(i).Data
                                Case "INCHARGEUPDATE" : z3412.InchargeUpdate = Children(i).Data
                                Case "PRICEAPURCHASING" : z3412.PriceAPurchasing = Cdecp(Children(i).Data)
                                Case "CDUNITMATERIALA" : z3412.cdUnitMaterialA = Children(i).Data
                                Case "CDUNITPRICEA" : z3412.cdUnitPriceA = Children(i).Data
                                Case "QTYAPURCHASING" : z3412.QtyAPurchasing = Cdecp(Children(i).Data)
                                Case "QTYATOTAL" : z3412.QtyATotal = Cdecp(Children(i).Data)
                                Case "AMTAPURCHASING" : z3412.AmtAPurchasing = Cdecp(Children(i).Data)
                                Case "AMTATOTAL" : z3412.AmtATotal = Cdecp(Children(i).Data)
                                Case "INVOICENO1" : z3412.InvoiceNo1 = Children(i).Data
                                Case "INVOICENO2" : z3412.InvoiceNo2 = Children(i).Data
                                Case "INVOICENO3" : z3412.InvoiceNo3 = Children(i).Data
                                Case "INVOICENO4" : z3412.InvoiceNo4 = Children(i).Data
                                Case "INVOICENO5" : z3412.InvoiceNo5 = Children(i).Data
                                Case "INVOICENO6" : z3412.InvoiceNo6 = Children(i).Data
                                Case "INVOICENO7" : z3412.InvoiceNo7 = Children(i).Data
                                Case "INVOICENO8" : z3412.InvoiceNo8 = Children(i).Data
                                Case "INVOICENO9" : z3412.InvoiceNo9 = Children(i).Data
                                Case "INVOICEN10" : z3412.InvoiceNo10 = Children(i).Data

                                Case "DATEARRIVE1" : z3412.DateArrive1 = Children(i).Data
                                Case "DATEARRIVE2" : z3412.DateArrive2 = Children(i).Data
                                Case "DATEARRIVE3" : z3412.DateArrive3 = Children(i).Data
                                Case "DATEARRIVE4" : z3412.DateArrive4 = Children(i).Data
                                Case "DATEARRIVE5" : z3412.DateArrive5 = Children(i).Data
                                Case "DATEARRIVE6" : z3412.DateArrive6 = Children(i).Data
                                Case "DATEARRIVE7" : z3412.DateArrive7 = Children(i).Data
                                Case "DATEARRIVE8" : z3412.DateArrive8 = Children(i).Data
                                Case "DATEARRIVE9" : z3412.DateArrive9 = Children(i).Data
                                Case "DATEARRIVE10" : z3412.DateArrive10 = Children(i).Data

                                Case "QTYAARRIVE1" : z3412.QtyAArrive1 = Cdecp(Children(i).Data)
                                Case "QTYAARRIVE2" : z3412.QtyAArrive2 = Cdecp(Children(i).Data)
                                Case "QTYAARRIVE3" : z3412.QtyAArrive3 = Cdecp(Children(i).Data)
                                Case "QTYAARRIVE4" : z3412.QtyAArrive4 = Cdecp(Children(i).Data)
                                Case "QTYAARRIVE5" : z3412.QtyAArrive5 = CDecp(Children(i).Data)
                                Case "QTYAARRIVE6" : z3412.QtyAArrive6 = CDecp(Children(i).Data)
                                Case "QTYAARRIVE7" : z3412.QtyAArrive7 = CDecp(Children(i).Data)
                                Case "QTYAARRIVE8" : z3412.QtyAArrive8 = CDecp(Children(i).Data)
                                Case "QTYAARRIVE9" : z3412.QtyAArrive9 = CDecp(Children(i).Data)
                                Case "QTYAARRIVE10" : z3412.QtyAArrive10 = CDecp(Children(i).Data)

                                Case "INCHARGEINVOICE" : z3412.InchargeInvoice = Children(i).Data
                                Case "APLNAME" : z3412.APLName = Children(i).Data
                                Case "AINVOICE" : z3412.AInvoice = Children(i).Data
                                Case "AREMARK" : z3412.ARemark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K3412_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW AREA
    '=========================================================================================================================================================
    Public Sub K3412_MOVE(ByRef a3412 As T3412_AREA, ByRef b3412 As T3412_AREA)
        Try
            If trim$(a3412.PurchasingOrderNo) = "" Then b3412.PurchasingOrderNo = "" Else b3412.PurchasingOrderNo = a3412.PurchasingOrderNo
            If trim$(a3412.PurchasingOrderSeq) = "" Then b3412.PurchasingOrderSeq = "" Else b3412.PurchasingOrderSeq = a3412.PurchasingOrderSeq
            If trim$(a3412.seSite) = "" Then b3412.seSite = "" Else b3412.seSite = a3412.seSite
            If trim$(a3412.cdSite) = "" Then b3412.cdSite = "" Else b3412.cdSite = a3412.cdSite
            If trim$(a3412.seDepartment) = "" Then b3412.seDepartment = "" Else b3412.seDepartment = a3412.seDepartment
            If trim$(a3412.cdDepartment) = "" Then b3412.cdDepartment = "" Else b3412.cdDepartment = a3412.cdDepartment
            If trim$(a3412.seFactory) = "" Then b3412.seFactory = "" Else b3412.seFactory = a3412.seFactory
            If trim$(a3412.cdFactory) = "" Then b3412.cdFactory = "" Else b3412.cdFactory = a3412.cdFactory
            If trim$(a3412.CustomerSupplier) = "" Then b3412.CustomerSupplier = "" Else b3412.CustomerSupplier = a3412.CustomerSupplier
            If trim$(a3412.Dseq) = "" Then b3412.Dseq = "" Else b3412.Dseq = a3412.Dseq
            If trim$(a3412.AutokeyK3011) = "" Then b3412.AutokeyK3011 = "" Else b3412.AutokeyK3011 = a3412.AutokeyK3011
            If trim$(a3412.CheckRelationType) = "" Then b3412.CheckRelationType = "" Else b3412.CheckRelationType = a3412.CheckRelationType
            If trim$(a3412.MaterialCode) = "" Then b3412.MaterialCode = "" Else b3412.MaterialCode = a3412.MaterialCode
            If trim$(a3412.Specification) = "" Then b3412.Specification = "" Else b3412.Specification = a3412.Specification
            If trim$(a3412.Width) = "" Then b3412.Width = "" Else b3412.Width = a3412.Width
            If trim$(a3412.Height) = "" Then b3412.Height = "" Else b3412.Height = a3412.Height
            If trim$(a3412.SizeNo) = "" Then b3412.SizeNo = "" Else b3412.SizeNo = a3412.SizeNo
            If trim$(a3412.SizeName) = "" Then b3412.SizeName = "" Else b3412.SizeName = a3412.SizeName
            If trim$(a3412.ColorCode) = "" Then b3412.ColorCode = "" Else b3412.ColorCode = a3412.ColorCode
            If trim$(a3412.ColorName) = "" Then b3412.ColorName = "" Else b3412.ColorName = a3412.ColorName
            If trim$(a3412.seOrigin) = "" Then b3412.seOrigin = "" Else b3412.seOrigin = a3412.seOrigin
            If trim$(a3412.cdOrigin) = "" Then b3412.cdOrigin = "" Else b3412.cdOrigin = a3412.cdOrigin
            If trim$(a3412.MaterialCheck) = "" Then b3412.MaterialCheck = "" Else b3412.MaterialCheck = a3412.MaterialCheck
            If trim$(a3412.seUnitPrice) = "" Then b3412.seUnitPrice = "" Else b3412.seUnitPrice = a3412.seUnitPrice
            If trim$(a3412.cdUnitPrice) = "" Then b3412.cdUnitPrice = "" Else b3412.cdUnitPrice = a3412.cdUnitPrice
            If trim$(a3412.seTax) = "" Then b3412.seTax = "" Else b3412.seTax = a3412.seTax
            If trim$(a3412.cdTax) = "" Then b3412.cdTax = "" Else b3412.cdTax = a3412.cdTax
            If trim$(a3412.seUnitMaterial) = "" Then b3412.seUnitMaterial = "" Else b3412.seUnitMaterial = a3412.seUnitMaterial
            If trim$(a3412.cdUnitMaterial) = "" Then b3412.cdUnitMaterial = "" Else b3412.cdUnitMaterial = a3412.cdUnitMaterial
            If trim$(a3412.seUnitPacking) = "" Then b3412.seUnitPacking = "" Else b3412.seUnitPacking = a3412.seUnitPacking
            If trim$(a3412.cdUnitPacking) = "" Then b3412.cdUnitPacking = "" Else b3412.cdUnitPacking = a3412.cdUnitPacking
            If trim$(a3412.UnitBaseCheck) = "" Then b3412.UnitBaseCheck = "" Else b3412.UnitBaseCheck = a3412.UnitBaseCheck
            If trim$(a3412.QtyBasic) = "" Then b3412.QtyBasic = "" Else b3412.QtyBasic = a3412.QtyBasic
            If trim$(a3412.PricePurchasing) = "" Then b3412.PricePurchasing = "" Else b3412.PricePurchasing = a3412.PricePurchasing
            If trim$(a3412.PriceMarket) = "" Then b3412.PriceMarket = "" Else b3412.PriceMarket = a3412.PriceMarket
            If trim$(a3412.PriceExchangeAP) = "" Then b3412.PriceExchangeAP = "" Else b3412.PriceExchangeAP = a3412.PriceExchangeAP
            If trim$(a3412.PriceExchange) = "" Then b3412.PriceExchange = "" Else b3412.PriceExchange = a3412.PriceExchange
            If trim$(a3412.DateExchange) = "" Then b3412.DateExchange = "" Else b3412.DateExchange = a3412.DateExchange
            If trim$(a3412.PricePurchasingEX) = "" Then b3412.PricePurchasingEX = "" Else b3412.PricePurchasingEX = a3412.PricePurchasingEX
            If trim$(a3412.PriceMarketEX) = "" Then b3412.PriceMarketEX = "" Else b3412.PriceMarketEX = a3412.PriceMarketEX
            If trim$(a3412.PricePurchasingVND) = "" Then b3412.PricePurchasingVND = "" Else b3412.PricePurchasingVND = a3412.PricePurchasingVND
            If trim$(a3412.PriceMarketVND) = "" Then b3412.PriceMarketVND = "" Else b3412.PriceMarketVND = a3412.PriceMarketVND
            If trim$(a3412.AmountPurchasingEX) = "" Then b3412.AmountPurchasingEX = "" Else b3412.AmountPurchasingEX = a3412.AmountPurchasingEX
            If trim$(a3412.AmountPurchasingVND) = "" Then b3412.AmountPurchasingVND = "" Else b3412.AmountPurchasingVND = a3412.AmountPurchasingVND
            If trim$(a3412.AmountTaxEX) = "" Then b3412.AmountTaxEX = "" Else b3412.AmountTaxEX = a3412.AmountTaxEX
            If trim$(a3412.AmountTaxVND) = "" Then b3412.AmountTaxVND = "" Else b3412.AmountTaxVND = a3412.AmountTaxVND
            If trim$(a3412.seTax1) = "" Then b3412.seTax1 = "" Else b3412.seTax1 = a3412.seTax1
            If trim$(a3412.cdTax1) = "" Then b3412.cdTax1 = "" Else b3412.cdTax1 = a3412.cdTax1
            If trim$(a3412.PerTax1) = "" Then b3412.PerTax1 = "" Else b3412.PerTax1 = a3412.PerTax1
            If trim$(a3412.AmountTax1EX) = "" Then b3412.AmountTax1EX = "" Else b3412.AmountTax1EX = a3412.AmountTax1EX
            If trim$(a3412.AmountTax1) = "" Then b3412.AmountTax1 = "" Else b3412.AmountTax1 = a3412.AmountTax1
            If trim$(a3412.seTax2) = "" Then b3412.seTax2 = "" Else b3412.seTax2 = a3412.seTax2
            If trim$(a3412.cdTax2) = "" Then b3412.cdTax2 = "" Else b3412.cdTax2 = a3412.cdTax2
            If trim$(a3412.PerTax2) = "" Then b3412.PerTax2 = "" Else b3412.PerTax2 = a3412.PerTax2
            If trim$(a3412.AmountTax2EX) = "" Then b3412.AmountTax2EX = "" Else b3412.AmountTax2EX = a3412.AmountTax2EX
            If trim$(a3412.AmountTax2) = "" Then b3412.AmountTax2 = "" Else b3412.AmountTax2 = a3412.AmountTax2
            If trim$(a3412.seTax3) = "" Then b3412.seTax3 = "" Else b3412.seTax3 = a3412.seTax3
            If trim$(a3412.cdTax3) = "" Then b3412.cdTax3 = "" Else b3412.cdTax3 = a3412.cdTax3
            If trim$(a3412.PerTax3) = "" Then b3412.PerTax3 = "" Else b3412.PerTax3 = a3412.PerTax3
            If trim$(a3412.AmountTax3EX) = "" Then b3412.AmountTax3EX = "" Else b3412.AmountTax3EX = a3412.AmountTax3EX
            If trim$(a3412.AmountTax3) = "" Then b3412.AmountTax3 = "" Else b3412.AmountTax3 = a3412.AmountTax3
            If trim$(a3412.QtyBooking) = "" Then b3412.QtyBooking = "" Else b3412.QtyBooking = a3412.QtyBooking
            If trim$(a3412.QtyPurchasingNet) = "" Then b3412.QtyPurchasingNet = "" Else b3412.QtyPurchasingNet = a3412.QtyPurchasingNet
            If trim$(a3412.QtyPurchasingMOQ) = "" Then b3412.QtyPurchasingMOQ = "" Else b3412.QtyPurchasingMOQ = a3412.QtyPurchasingMOQ
            If trim$(a3412.QtyPurchasing) = "" Then b3412.QtyPurchasing = "" Else b3412.QtyPurchasing = a3412.QtyPurchasing
            If trim$(a3412.PackPurchasing) = "" Then b3412.PackPurchasing = "" Else b3412.PackPurchasing = a3412.PackPurchasing
            If trim$(a3412.AmountPSC) = "" Then b3412.AmountPSC = "" Else b3412.AmountPSC = a3412.AmountPSC
            If trim$(a3412.AmountEX) = "" Then b3412.AmountEX = "" Else b3412.AmountEX = a3412.AmountEX
            If trim$(a3412.AmountVND) = "" Then b3412.AmountVND = "" Else b3412.AmountVND = a3412.AmountVND
            If trim$(a3412.AmountNoVATEX) = "" Then b3412.AmountNoVATEX = "" Else b3412.AmountNoVATEX = a3412.AmountNoVATEX
            If trim$(a3412.AmountNoVATVND) = "" Then b3412.AmountNoVATVND = "" Else b3412.AmountNoVATVND = a3412.AmountNoVATVND
            If trim$(a3412.AmountTotalEX) = "" Then b3412.AmountTotalEX = "" Else b3412.AmountTotalEX = a3412.AmountTotalEX
            If trim$(a3412.AmountTotalVND) = "" Then b3412.AmountTotalVND = "" Else b3412.AmountTotalVND = a3412.AmountTotalVND
            If trim$(a3412.TotalQtyPurchasing) = "" Then b3412.TotalQtyPurchasing = "" Else b3412.TotalQtyPurchasing = a3412.TotalQtyPurchasing
            If trim$(a3412.TotalPackPurchasing) = "" Then b3412.TotalPackPurchasing = "" Else b3412.TotalPackPurchasing = a3412.TotalPackPurchasing
            If trim$(a3412.QtyWarehouse) = "" Then b3412.QtyWarehouse = "" Else b3412.QtyWarehouse = a3412.QtyWarehouse
            If trim$(a3412.PackWarehouse) = "" Then b3412.PackWarehouse = "" Else b3412.PackWarehouse = a3412.PackWarehouse
            If trim$(a3412.DateDelivery) = "" Then b3412.DateDelivery = "" Else b3412.DateDelivery = a3412.DateDelivery
            If trim$(a3412.DateStart) = "" Then b3412.DateStart = "" Else b3412.DateStart = a3412.DateStart
            If trim$(a3412.DateFinish) = "" Then b3412.DateFinish = "" Else b3412.DateFinish = a3412.DateFinish
            If trim$(a3412.CheckPurchasing) = "" Then b3412.CheckPurchasing = "" Else b3412.CheckPurchasing = a3412.CheckPurchasing
            If trim$(a3412.DateAccept) = "" Then b3412.DateAccept = "" Else b3412.DateAccept = a3412.DateAccept
            If trim$(a3412.DatePosted) = "" Then b3412.DatePosted = "" Else b3412.DatePosted = a3412.DatePosted
            If trim$(a3412.IsPosted) = "" Then b3412.IsPosted = "" Else b3412.IsPosted = a3412.IsPosted
            If trim$(a3412.DateComplete) = "" Then b3412.DateComplete = "" Else b3412.DateComplete = a3412.DateComplete
            If trim$(a3412.DateApproval) = "" Then b3412.DateApproval = "" Else b3412.DateApproval = a3412.DateApproval
            If trim$(a3412.DateCancel) = "" Then b3412.DateCancel = "" Else b3412.DateCancel = a3412.DateCancel
            If trim$(a3412.CheckComplete) = "" Then b3412.CheckComplete = "" Else b3412.CheckComplete = a3412.CheckComplete
            If trim$(a3412.PurchasingRequestNo) = "" Then b3412.PurchasingRequestNo = "" Else b3412.PurchasingRequestNo = a3412.PurchasingRequestNo
            If trim$(a3412.PurchasingRequestSeq) = "" Then b3412.PurchasingRequestSeq = "" Else b3412.PurchasingRequestSeq = a3412.PurchasingRequestSeq
            If trim$(a3412.OrderNo) = "" Then b3412.OrderNo = "" Else b3412.OrderNo = a3412.OrderNo
            If trim$(a3412.OrderNoSeq) = "" Then b3412.OrderNoSeq = "" Else b3412.OrderNoSeq = a3412.OrderNoSeq
            If trim$(a3412.PurchasingOrderNo_Bf) = "" Then b3412.PurchasingOrderNo_Bf = "" Else b3412.PurchasingOrderNo_Bf = a3412.PurchasingOrderNo_Bf
            If trim$(a3412.PurchasingOrderSeq_Bf) = "" Then b3412.PurchasingOrderSeq_Bf = "" Else b3412.PurchasingOrderSeq_Bf = a3412.PurchasingOrderSeq_Bf
            If trim$(a3412.Remark) = "" Then b3412.Remark = "" Else b3412.Remark = a3412.Remark
            If trim$(a3412.TimeInsert) = "" Then b3412.TimeInsert = "" Else b3412.TimeInsert = a3412.TimeInsert
            If trim$(a3412.TimeUpdate) = "" Then b3412.TimeUpdate = "" Else b3412.TimeUpdate = a3412.TimeUpdate
            If trim$(a3412.DateInsert) = "" Then b3412.DateInsert = "" Else b3412.DateInsert = a3412.DateInsert
            If trim$(a3412.DateUpdate) = "" Then b3412.DateUpdate = "" Else b3412.DateUpdate = a3412.DateUpdate
            If trim$(a3412.InchargeInsert) = "" Then b3412.InchargeInsert = "" Else b3412.InchargeInsert = a3412.InchargeInsert
            If trim$(a3412.InchargeUpdate) = "" Then b3412.InchargeUpdate = "" Else b3412.InchargeUpdate = a3412.InchargeUpdate
            If trim$(a3412.PriceAPurchasing) = "" Then b3412.PriceAPurchasing = "" Else b3412.PriceAPurchasing = a3412.PriceAPurchasing
            If trim$(a3412.cdUnitMaterialA) = "" Then b3412.cdUnitMaterialA = "" Else b3412.cdUnitMaterialA = a3412.cdUnitMaterialA
            If trim$(a3412.cdUnitPriceA) = "" Then b3412.cdUnitPriceA = "" Else b3412.cdUnitPriceA = a3412.cdUnitPriceA
            If trim$(a3412.QtyAPurchasing) = "" Then b3412.QtyAPurchasing = "" Else b3412.QtyAPurchasing = a3412.QtyAPurchasing
            If trim$(a3412.QtyATotal) = "" Then b3412.QtyATotal = "" Else b3412.QtyATotal = a3412.QtyATotal
            If trim$(a3412.AmtAPurchasing) = "" Then b3412.AmtAPurchasing = "" Else b3412.AmtAPurchasing = a3412.AmtAPurchasing
            If trim$(a3412.AmtATotal) = "" Then b3412.AmtATotal = "" Else b3412.AmtATotal = a3412.AmtATotal
            If trim$(a3412.InvoiceNo1) = "" Then b3412.InvoiceNo1 = "" Else b3412.InvoiceNo1 = a3412.InvoiceNo1
            If trim$(a3412.InvoiceNo2) = "" Then b3412.InvoiceNo2 = "" Else b3412.InvoiceNo2 = a3412.InvoiceNo2
            If trim$(a3412.InvoiceNo3) = "" Then b3412.InvoiceNo3 = "" Else b3412.InvoiceNo3 = a3412.InvoiceNo3
            If trim$(a3412.InvoiceNo4) = "" Then b3412.InvoiceNo4 = "" Else b3412.InvoiceNo4 = a3412.InvoiceNo4
            If Trim$(a3412.InvoiceNo5) = "" Then b3412.InvoiceNo5 = "" Else b3412.InvoiceNo5 = a3412.InvoiceNo5
            If Trim$(a3412.InvoiceNo6) = "" Then b3412.InvoiceNo6 = "" Else b3412.InvoiceNo6 = a3412.InvoiceNo6
            If Trim$(a3412.InvoiceNo7) = "" Then b3412.InvoiceNo7 = "" Else b3412.InvoiceNo7 = a3412.InvoiceNo7
            If Trim$(a3412.InvoiceNo8) = "" Then b3412.InvoiceNo8 = "" Else b3412.InvoiceNo8 = a3412.InvoiceNo8
            If Trim$(a3412.InvoiceNo9) = "" Then b3412.InvoiceNo9 = "" Else b3412.InvoiceNo9 = a3412.InvoiceNo9
            If Trim$(a3412.InvoiceNo10) = "" Then b3412.InvoiceNo10 = "" Else b3412.InvoiceNo10 = a3412.InvoiceNo10

            If trim$(a3412.DateArrive1) = "" Then b3412.DateArrive1 = "" Else b3412.DateArrive1 = a3412.DateArrive1
            If trim$(a3412.DateArrive2) = "" Then b3412.DateArrive2 = "" Else b3412.DateArrive2 = a3412.DateArrive2
            If trim$(a3412.DateArrive3) = "" Then b3412.DateArrive3 = "" Else b3412.DateArrive3 = a3412.DateArrive3
            If trim$(a3412.DateArrive4) = "" Then b3412.DateArrive4 = "" Else b3412.DateArrive4 = a3412.DateArrive4
            If Trim$(a3412.DateArrive5) = "" Then b3412.DateArrive5 = "" Else b3412.DateArrive5 = a3412.DateArrive5
            If Trim$(a3412.DateArrive6) = "" Then b3412.DateArrive6 = "" Else b3412.DateArrive6 = a3412.DateArrive6
            If Trim$(a3412.DateArrive7) = "" Then b3412.DateArrive7 = "" Else b3412.DateArrive7 = a3412.DateArrive7
            If Trim$(a3412.DateArrive8) = "" Then b3412.DateArrive8 = "" Else b3412.DateArrive8 = a3412.DateArrive8
            If Trim$(a3412.DateArrive9) = "" Then b3412.DateArrive9 = "" Else b3412.DateArrive9 = a3412.DateArrive9
            If Trim$(a3412.DateArrive10) = "" Then b3412.DateArrive10 = "" Else b3412.DateArrive10 = a3412.DateArrive10

            If trim$(a3412.QtyAArrive1) = "" Then b3412.QtyAArrive1 = "" Else b3412.QtyAArrive1 = a3412.QtyAArrive1
            If trim$(a3412.QtyAArrive2) = "" Then b3412.QtyAArrive2 = "" Else b3412.QtyAArrive2 = a3412.QtyAArrive2
            If trim$(a3412.QtyAArrive3) = "" Then b3412.QtyAArrive3 = "" Else b3412.QtyAArrive3 = a3412.QtyAArrive3
            If trim$(a3412.QtyAArrive4) = "" Then b3412.QtyAArrive4 = "" Else b3412.QtyAArrive4 = a3412.QtyAArrive4
            If Trim$(a3412.QtyAArrive5) = "" Then b3412.QtyAArrive5 = "" Else b3412.QtyAArrive5 = a3412.QtyAArrive5
            If Trim$(a3412.QtyAArrive6) = "" Then b3412.QtyAArrive6 = "" Else b3412.QtyAArrive6 = a3412.QtyAArrive6
            If Trim$(a3412.QtyAArrive7) = "" Then b3412.QtyAArrive7 = "" Else b3412.QtyAArrive7 = a3412.QtyAArrive7
            If Trim$(a3412.QtyAArrive8) = "" Then b3412.QtyAArrive8 = "" Else b3412.QtyAArrive8 = a3412.QtyAArrive8
            If Trim$(a3412.QtyAArrive9) = "" Then b3412.QtyAArrive9 = "" Else b3412.QtyAArrive9 = a3412.QtyAArrive9
            If Trim$(a3412.QtyAArrive10) = "" Then b3412.QtyAArrive10 = "" Else b3412.QtyAArrive10 = a3412.QtyAArrive10

            If trim$(a3412.InchargeInvoice) = "" Then b3412.InchargeInvoice = "" Else b3412.InchargeInvoice = a3412.InchargeInvoice
            If trim$(a3412.APLName) = "" Then b3412.APLName = "" Else b3412.APLName = a3412.APLName
            If trim$(a3412.AInvoice) = "" Then b3412.AInvoice = "" Else b3412.AInvoice = a3412.AInvoice
            If trim$(a3412.ARemark) = "" Then b3412.ARemark = "" Else b3412.ARemark = a3412.ARemark
        Catch ex As Exception
            Call MsgBoxP("K3412_MOVE", vbCritical)
        End Try
    End Sub


End Module
