'=========================================================================================================================================================
'   TABLE : (PFK2351)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K2351

    Structure T2351_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public MaterialInBoundNo As String  '			char(9)		*
        Public MaterialInBoundSeq As String  '			char(3)		*
        Public DateAccept As String  '			char(8)
        Public seSite As String  '			char(3)
        Public cdSite As String  '			char(3)
        Public seDepartment As String  '			char(3)
        Public cdDepartment As String  '			char(3)
        Public seFactory As String  '			char(3)
        Public cdFactory As String  '			char(3)
        Public seSeason As String  '			char(3)
        Public cdSeason As String  '			char(3)
        Public seWareHouseGroup As String  '			char(3)
        Public cdWareHouseGroup As String  '			char(3)
        Public seWareHousePosition As String  '			char(3)
        Public cdWareHousePosition As String  '			char(3)
        Public DateInBoundMaterial As String  '			char(8)
        Public CheckInBoundMaterial As String  '			char(1)
        Public CheckMaterialType As String  '			char(1)
        Public CheckMarketType As String  '			char(1)
        Public CustomerCode As String  '			char(6)
        Public SupplierCode As String  '			char(6)
        Public InchargeInBound As String  '			char(8)
        Public InvoiceNo As String  '			nvarchar(50)
        Public ContainerNo As String  '			nvarchar(50)
        Public MaterialCode As String  '			char(6)
        Public ColorCode As String  '			char(6)
        Public ColorName As String  '			nvarchar(500)
        Public SizeName As String  '			nvarchar(500)
        Public Width As String  '			nvarchar(500)

        Public seUnitPrice As String  '			char(3)
        Public cdUnitPrice As String  '			char(3)
        Public PriceMaterial As Double  '			decimal
        Public DateExchange As String  '			char(8)
        Public PriceExchange As Double  '			decimal
        Public PriceExchangeAP As Double  '			decimal
        Public PriceMaterialEX As Double  '			decimal
        Public PriceMaterialVND As Double  '			decimal
        Public seUnitMaterial As String  '			char(3)
        Public cdUnitMaterial As String  '			char(3)
        Public cdUnitMaterialPL As String  '			char(3)
        Public QtyConversion As Double  '			decimal
        Public [Operator] As String  '			char(1)
        Public CheckConversion As String  '			char(1)
        Public DateConversion As String  '			char(8)
        Public seUnitMaterialOld As String  '			char(3)
        Public cdUnitMaterialOld As String  '			char(3)
        Public seUnitPacking As String  '			char(3)
        Public cdUnitPacking As String  '			char(3)
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
        Public AmountTaxVND As Double  '			decimal
        Public AmountPurchasingEX As Double  '			decimal
        Public AmountPurchasingVND As Double  '			decimal
        Public PackInBound As Double  '			decimal
        Public QtyBasic As Double  '			decimal
        Public QtyInBound_Or As Double  '			decimal
        Public QtyPackingList As Double  '			decimal
        Public QtyAllocation As Double  '			decimal
        Public QtyInBound As Double  '			decimal
        Public QtyInBoundPL As Double  '			decimal
        Public PackOutBound As Double  '			decimal
        Public QtyOutBound As Double  '			decimal
        Public QtyInBoundTrading As Double  '			decimal
        Public InchargeTrading As String  '			char(8)
        Public TradingDate As String  '			char(8)
        Public TradingNo As String  '			nvarchar(50)
        Public TradingCode As String  '			nvarchar(50)
        Public TradingGroup As String  '			nvarchar(50)
        Public PriceTrading As Double  '			decimal
        Public AMTTradingNet As Double  '			decimal
        Public AMTTradingVAT As Double  '			decimal
        Public AMTTrading As Double  '			decimal
        Public AmountNoVATEX As Double  '			decimal
        Public AmountNoVATVND As Double  '			decimal
        Public AmountTotalEX As Double  '			decimal
        Public AmountTotalVND As Double  '			decimal
        Public AmountInBoundEX As Double  '			decimal
        Public AmountInBoundVND As Double  '			decimal
        Public AmountEX As Double  '			decimal
        Public AmountVND As Double  '			decimal
        Public FactOrderNo As String  '			char(9)
        Public FactOrderSeq As Double  '			decimal
        Public JobCardWorking As String  '			char(10)
        Public JobCardWorkingSeq As String  '			char(3)
        Public JobCardType As String  '			char(1)
        Public CheckComplete As String  '			char(1)
        Public CheckQC As String  '			char(1)
        Public IsPosted As String  '			char(1)
        Public DatePosted As String  '			char(8)
        Public DateInsert As String  '			char(8)
        Public DateUpdate As String  '			char(8)
        Public InchargeInsert As String  '			char(8)
        Public InchargeUpdate As String  '			char(8)
        Public DateSync As String  '			char(8)
        Public CheckSync As String  '			char(1)
        Public CheckPL As String  '			char(1)
        Public Remark As String  '			nvarchar(-1)
        '=========================================================================================================================================================
    End Structure

    Public D2351 As T2351_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK2351(MATERIALINBOUNDNO As String, MATERIALINBOUNDSEQ As String) As Boolean
        READ_PFK2351 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK2351 "
            SQL = SQL & " WHERE K2351_MaterialInBoundNo		 = '" & MaterialInBoundNo & "' "
            SQL = SQL & "   AND K2351_MaterialInBoundSeq		 = '" & MaterialInBoundSeq & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D2351_CLEAR() : GoTo SKIP_READ_PFK2351

            Call K2351_MOVE(rd)
            READ_PFK2351 = True

SKIP_READ_PFK2351:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK2351", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK2351(MATERIALINBOUNDNO As String, MATERIALINBOUNDSEQ As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK2351 "
            SQL = SQL & " WHERE K2351_MaterialInBoundNo		 = '" & MaterialInBoundNo & "' "
            SQL = SQL & "   AND K2351_MaterialInBoundSeq		 = '" & MaterialInBoundSeq & "' "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK2351", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK2351(z2351 As T2351_AREA) As Boolean
        WRITE_PFK2351 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z2351)

            SQL = " INSERT INTO PFK2351 "
            SQL = SQL & " ( "
            SQL = SQL & " K2351_MaterialInBoundNo,"
            SQL = SQL & " K2351_MaterialInBoundSeq,"
            SQL = SQL & " K2351_DateAccept,"
            SQL = SQL & " K2351_seSite,"
            SQL = SQL & " K2351_cdSite,"
            SQL = SQL & " K2351_seDepartment,"
            SQL = SQL & " K2351_cdDepartment,"
            SQL = SQL & " K2351_seFactory,"
            SQL = SQL & " K2351_cdFactory,"
            SQL = SQL & " K2351_seSeason,"
            SQL = SQL & " K2351_cdSeason,"
            SQL = SQL & " K2351_seWareHouseGroup,"
            SQL = SQL & " K2351_cdWareHouseGroup,"
            SQL = SQL & " K2351_seWareHousePosition,"
            SQL = SQL & " K2351_cdWareHousePosition,"
            SQL = SQL & " K2351_DateInBoundMaterial,"
            SQL = SQL & " K2351_CheckInBoundMaterial,"
            SQL = SQL & " K2351_CheckMaterialType,"
            SQL = SQL & " K2351_CheckMarketType,"
            SQL = SQL & " K2351_CustomerCode,"
            SQL = SQL & " K2351_SupplierCode,"
            SQL = SQL & " K2351_InchargeInBound,"
            SQL = SQL & " K2351_InvoiceNo,"
            SQL = SQL & " K2351_ContainerNo,"
            SQL = SQL & " K2351_MaterialCode,"
            SQL = SQL & " K2351_ColorCode,"
            SQL = SQL & " K2351_ColorName,"
            SQL = SQL & " K2351_SizeName,"
            SQL = SQL & " K2351_Width,"
            SQL = SQL & " K2351_seUnitPrice,"
            SQL = SQL & " K2351_cdUnitPrice,"
            SQL = SQL & " K2351_PriceMaterial,"
            SQL = SQL & " K2351_DateExchange,"
            SQL = SQL & " K2351_PriceExchange,"
            SQL = SQL & " K2351_PriceExchangeAP,"
            SQL = SQL & " K2351_PriceMaterialEX,"
            SQL = SQL & " K2351_PriceMaterialVND,"
            SQL = SQL & " K2351_seUnitMaterial,"
            SQL = SQL & " K2351_cdUnitMaterial,"
            SQL = SQL & " K2351_cdUnitMaterialPL,"

            SQL = SQL & " K2351_QtyConversion,"
            SQL = SQL & " K2351_Operator,"
            SQL = SQL & " K2351_CheckConversion,"
            SQL = SQL & " K2351_DateConversion,"
            SQL = SQL & " K2351_seUnitMaterialOld,"
            SQL = SQL & " K2351_cdUnitMaterialOld,"
            SQL = SQL & " K2351_seUnitPacking,"
            SQL = SQL & " K2351_cdUnitPacking,"
            SQL = SQL & " K2351_seTax1,"
            SQL = SQL & " K2351_cdTax1,"
            SQL = SQL & " K2351_PerTax1,"
            SQL = SQL & " K2351_AmountTax1EX,"
            SQL = SQL & " K2351_AmountTax1,"
            SQL = SQL & " K2351_seTax2,"
            SQL = SQL & " K2351_cdTax2,"
            SQL = SQL & " K2351_PerTax2,"
            SQL = SQL & " K2351_AmountTax2EX,"
            SQL = SQL & " K2351_AmountTax2,"
            SQL = SQL & " K2351_seTax3,"
            SQL = SQL & " K2351_cdTax3,"
            SQL = SQL & " K2351_PerTax3,"
            SQL = SQL & " K2351_AmountTax3EX,"
            SQL = SQL & " K2351_AmountTax3,"
            SQL = SQL & " K2351_AmountTaxVND,"
            SQL = SQL & " K2351_AmountPurchasingEX,"
            SQL = SQL & " K2351_AmountPurchasingVND,"
            SQL = SQL & " K2351_PackInBound,"
            SQL = SQL & " K2351_QtyBasic,"
            SQL = SQL & " K2351_QtyInBound_Or,"
            SQL = SQL & " K2351_QtyPackingList,"
            SQL = SQL & " K2351_QtyAllocation,"
            SQL = SQL & " K2351_QtyInBound,"
            SQL = SQL & " K2351_QtyInBoundPL,"
            SQL = SQL & " K2351_PackOutBound,"
            SQL = SQL & " K2351_QtyOutBound,"
            SQL = SQL & " K2351_QtyInBoundTrading,"
            SQL = SQL & " K2351_InchargeTrading,"
            SQL = SQL & " K2351_TradingDate,"
            SQL = SQL & " K2351_TradingNo,"
            SQL = SQL & " K2351_TradingCode,"
            SQL = SQL & " K2351_TradingGroup,"
            SQL = SQL & " K2351_PriceTrading,"
            SQL = SQL & " K2351_AMTTradingNet,"
            SQL = SQL & " K2351_AMTTradingVAT,"
            SQL = SQL & " K2351_AMTTrading,"
            SQL = SQL & " K2351_AmountNoVATEX,"
            SQL = SQL & " K2351_AmountNoVATVND,"
            SQL = SQL & " K2351_AmountTotalEX,"
            SQL = SQL & " K2351_AmountTotalVND,"
            SQL = SQL & " K2351_AmountInBoundEX,"
            SQL = SQL & " K2351_AmountInBoundVND,"
            SQL = SQL & " K2351_AmountEX,"
            SQL = SQL & " K2351_AmountVND,"
            SQL = SQL & " K2351_FactOrderNo,"
            SQL = SQL & " K2351_FactOrderSeq,"
            SQL = SQL & " K2351_JobCardWorking,"
            SQL = SQL & " K2351_JobCardWorkingSeq,"
            SQL = SQL & " K2351_JobCardType,"
            SQL = SQL & " K2351_CheckComplete,"
            SQL = SQL & " K2351_CheckQC,"
            SQL = SQL & " K2351_IsPosted,"
            SQL = SQL & " K2351_DatePosted,"
            SQL = SQL & " K2351_DateInsert,"
            SQL = SQL & " K2351_DateUpdate,"
            SQL = SQL & " K2351_InchargeInsert,"
            SQL = SQL & " K2351_InchargeUpdate,"
            SQL = SQL & " K2351_DateSync,"
            SQL = SQL & " K2351_CheckSync,"
            SQL = SQL & " K2351_CheckPL,"
            SQL = SQL & " K2351_Remark "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z2351.MaterialInBoundNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2351.MaterialInBoundSeq) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2351.DateAccept) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2351.seSite) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2351.cdSite) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2351.seDepartment) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2351.cdDepartment) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2351.seFactory) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2351.cdFactory) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2351.seSeason) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2351.cdSeason) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2351.seWareHouseGroup) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2351.cdWareHouseGroup) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2351.seWareHousePosition) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2351.cdWareHousePosition) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2351.DateInBoundMaterial) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2351.CheckInBoundMaterial) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2351.CheckMaterialType) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2351.CheckMarketType) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2351.CustomerCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2351.SupplierCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2351.InchargeInBound) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2351.InvoiceNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2351.ContainerNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2351.MaterialCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2351.ColorCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2351.ColorName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2351.SizeName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2351.Width) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2351.seUnitPrice) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2351.cdUnitPrice) & "', "
            SQL = SQL & "   " & FormatSQL(z2351.PriceMaterial) & ", "
            SQL = SQL & "  N'" & FormatSQL(z2351.DateExchange) & "', "
            SQL = SQL & "   " & FormatSQL(z2351.PriceExchange) & ", "
            SQL = SQL & "   " & FormatSQL(z2351.PriceExchangeAP) & ", "
            SQL = SQL & "   " & FormatSQL(z2351.PriceMaterialEX) & ", "
            SQL = SQL & "   " & FormatSQL(z2351.PriceMaterialVND) & ", "
            SQL = SQL & "  N'" & FormatSQL(z2351.seUnitMaterial) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2351.cdUnitMaterial) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2351.cdUnitMaterialPL) & "', "

            SQL = SQL & "   " & FormatSQL(z2351.QtyConversion) & ", "
            SQL = SQL & "  N'" & FormatSQL(z2351.Operator) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2351.CheckConversion) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2351.DateConversion) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2351.seUnitMaterialOld) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2351.cdUnitMaterialOld) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2351.seUnitPacking) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2351.cdUnitPacking) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2351.seTax1) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2351.cdTax1) & "', "
            SQL = SQL & "   " & FormatSQL(z2351.PerTax1) & ", "
            SQL = SQL & "   " & FormatSQL(z2351.AmountTax1EX) & ", "
            SQL = SQL & "   " & FormatSQL(z2351.AmountTax1) & ", "
            SQL = SQL & "  N'" & FormatSQL(z2351.seTax2) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2351.cdTax2) & "', "
            SQL = SQL & "   " & FormatSQL(z2351.PerTax2) & ", "
            SQL = SQL & "   " & FormatSQL(z2351.AmountTax2EX) & ", "
            SQL = SQL & "   " & FormatSQL(z2351.AmountTax2) & ", "
            SQL = SQL & "  N'" & FormatSQL(z2351.seTax3) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2351.cdTax3) & "', "
            SQL = SQL & "   " & FormatSQL(z2351.PerTax3) & ", "
            SQL = SQL & "   " & FormatSQL(z2351.AmountTax3EX) & ", "
            SQL = SQL & "   " & FormatSQL(z2351.AmountTax3) & ", "
            SQL = SQL & "   " & FormatSQL(z2351.AmountTaxVND) & ", "
            SQL = SQL & "   " & FormatSQL(z2351.AmountPurchasingEX) & ", "
            SQL = SQL & "   " & FormatSQL(z2351.AmountPurchasingVND) & ", "
            SQL = SQL & "   " & FormatSQL(z2351.PackInBound) & ", "
            SQL = SQL & "   " & FormatSQL(z2351.QtyBasic) & ", "
            SQL = SQL & "   " & FormatSQL(z2351.QtyInBound_Or) & ", "
            SQL = SQL & "   " & FormatSQL(z2351.QtyPackingList) & ", "
            SQL = SQL & "   " & FormatSQL(z2351.QtyAllocation) & ", "
            SQL = SQL & "   " & FormatSQL(z2351.QtyInBound) & ", "
            SQL = SQL & "   " & FormatSQL(z2351.QtyInBoundPL) & ", "
            SQL = SQL & "   " & FormatSQL(z2351.PackOutBound) & ", "
            SQL = SQL & "   " & FormatSQL(z2351.QtyOutBound) & ", "
            SQL = SQL & "   " & FormatSQL(z2351.QtyInBoundTrading) & ", "
            SQL = SQL & "  N'" & FormatSQL(z2351.InchargeTrading) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2351.TradingDate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2351.TradingNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2351.TradingCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2351.TradingGroup) & "', "
            SQL = SQL & "   " & FormatSQL(z2351.PriceTrading) & ", "
            SQL = SQL & "   " & FormatSQL(z2351.AMTTradingNet) & ", "
            SQL = SQL & "   " & FormatSQL(z2351.AMTTradingVAT) & ", "
            SQL = SQL & "   " & FormatSQL(z2351.AMTTrading) & ", "
            SQL = SQL & "   " & FormatSQL(z2351.AmountNoVATEX) & ", "
            SQL = SQL & "   " & FormatSQL(z2351.AmountNoVATVND) & ", "
            SQL = SQL & "   " & FormatSQL(z2351.AmountTotalEX) & ", "
            SQL = SQL & "   " & FormatSQL(z2351.AmountTotalVND) & ", "
            SQL = SQL & "   " & FormatSQL(z2351.AmountInBoundEX) & ", "
            SQL = SQL & "   " & FormatSQL(z2351.AmountInBoundVND) & ", "
            SQL = SQL & "   " & FormatSQL(z2351.AmountEX) & ", "
            SQL = SQL & "   " & FormatSQL(z2351.AmountVND) & ", "
            SQL = SQL & "  N'" & FormatSQL(z2351.FactOrderNo) & "', "
            SQL = SQL & "   " & FormatSQL(z2351.FactOrderSeq) & ", "
            SQL = SQL & "  N'" & FormatSQL(z2351.JobCardWorking) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2351.JobCardWorkingSeq) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2351.JobCardType) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2351.CheckComplete) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2351.CheckQC) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2351.IsPosted) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2351.DatePosted) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2351.DateInsert) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2351.DateUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2351.InchargeInsert) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2351.InchargeUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2351.DateSync) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2351.CheckSync) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2351.CheckPL) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2351.Remark) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK2351 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK2351", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK2351(z2351 As T2351_AREA) As Boolean
        REWRITE_PFK2351 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z2351)

            SQL = " UPDATE PFK2351 SET "
            SQL = SQL & "    K2351_DateAccept      = N'" & FormatSQL(z2351.DateAccept) & "', "
            SQL = SQL & "    K2351_seSite      = N'" & FormatSQL(z2351.seSite) & "', "
            SQL = SQL & "    K2351_cdSite      = N'" & FormatSQL(z2351.cdSite) & "', "
            SQL = SQL & "    K2351_seDepartment      = N'" & FormatSQL(z2351.seDepartment) & "', "
            SQL = SQL & "    K2351_cdDepartment      = N'" & FormatSQL(z2351.cdDepartment) & "', "
            SQL = SQL & "    K2351_seFactory      = N'" & FormatSQL(z2351.seFactory) & "', "
            SQL = SQL & "    K2351_cdFactory      = N'" & FormatSQL(z2351.cdFactory) & "', "
            SQL = SQL & "    K2351_seSeason      = N'" & FormatSQL(z2351.seSeason) & "', "
            SQL = SQL & "    K2351_cdSeason      = N'" & FormatSQL(z2351.cdSeason) & "', "
            SQL = SQL & "    K2351_seWareHouseGroup      = N'" & FormatSQL(z2351.seWareHouseGroup) & "', "
            SQL = SQL & "    K2351_cdWareHouseGroup      = N'" & FormatSQL(z2351.cdWareHouseGroup) & "', "
            SQL = SQL & "    K2351_seWareHousePosition      = N'" & FormatSQL(z2351.seWareHousePosition) & "', "
            SQL = SQL & "    K2351_cdWareHousePosition      = N'" & FormatSQL(z2351.cdWareHousePosition) & "', "
            SQL = SQL & "    K2351_DateInBoundMaterial      = N'" & FormatSQL(z2351.DateInBoundMaterial) & "', "
            SQL = SQL & "    K2351_CheckInBoundMaterial      = N'" & FormatSQL(z2351.CheckInBoundMaterial) & "', "
            SQL = SQL & "    K2351_CheckMaterialType      = N'" & FormatSQL(z2351.CheckMaterialType) & "', "
            SQL = SQL & "    K2351_CheckMarketType      = N'" & FormatSQL(z2351.CheckMarketType) & "', "
            SQL = SQL & "    K2351_CustomerCode      = N'" & FormatSQL(z2351.CustomerCode) & "', "
            SQL = SQL & "    K2351_SupplierCode      = N'" & FormatSQL(z2351.SupplierCode) & "', "
            SQL = SQL & "    K2351_InchargeInBound      = N'" & FormatSQL(z2351.InchargeInBound) & "', "
            SQL = SQL & "    K2351_InvoiceNo      = N'" & FormatSQL(z2351.InvoiceNo) & "', "
            SQL = SQL & "    K2351_ContainerNo      = N'" & FormatSQL(z2351.ContainerNo) & "', "
            SQL = SQL & "    K2351_MaterialCode      = N'" & FormatSQL(z2351.MaterialCode) & "', "
            SQL = SQL & "    K2351_ColorCode      = N'" & FormatSQL(z2351.ColorCode) & "', "
            SQL = SQL & "    K2351_ColorName      = N'" & FormatSQL(z2351.ColorName) & "', "
            SQL = SQL & "    K2351_SizeName      = N'" & FormatSQL(z2351.SizeName) & "', "
            SQL = SQL & "    K2351_Width      = N'" & FormatSQL(z2351.Width) & "', "
            SQL = SQL & "    K2351_seUnitPrice      = N'" & FormatSQL(z2351.seUnitPrice) & "', "
            SQL = SQL & "    K2351_cdUnitPrice      = N'" & FormatSQL(z2351.cdUnitPrice) & "', "
            SQL = SQL & "    K2351_PriceMaterial      =  " & FormatSQL(z2351.PriceMaterial) & ", "
            SQL = SQL & "    K2351_DateExchange      = N'" & FormatSQL(z2351.DateExchange) & "', "
            SQL = SQL & "    K2351_PriceExchange      =  " & FormatSQL(z2351.PriceExchange) & ", "
            SQL = SQL & "    K2351_PriceExchangeAP      =  " & FormatSQL(z2351.PriceExchangeAP) & ", "
            SQL = SQL & "    K2351_PriceMaterialEX      =  " & FormatSQL(z2351.PriceMaterialEX) & ", "
            SQL = SQL & "    K2351_PriceMaterialVND      =  " & FormatSQL(z2351.PriceMaterialVND) & ", "
            SQL = SQL & "    K2351_seUnitMaterial      = N'" & FormatSQL(z2351.seUnitMaterial) & "', "
            SQL = SQL & "    K2351_cdUnitMaterial      = N'" & FormatSQL(z2351.cdUnitMaterial) & "', "
            SQL = SQL & "    K2351_cdUnitMaterialPL      = N'" & FormatSQL(z2351.cdUnitMaterialPL) & "', "

            SQL = SQL & "    K2351_QtyConversion      =  " & FormatSQL(z2351.QtyConversion) & ", "
            SQL = SQL & "    K2351_Operator      = N'" & FormatSQL(z2351.Operator) & "', "
            SQL = SQL & "    K2351_CheckConversion      = N'" & FormatSQL(z2351.CheckConversion) & "', "
            SQL = SQL & "    K2351_DateConversion      = N'" & FormatSQL(z2351.DateConversion) & "', "
            SQL = SQL & "    K2351_seUnitMaterialOld      = N'" & FormatSQL(z2351.seUnitMaterialOld) & "', "
            SQL = SQL & "    K2351_cdUnitMaterialOld      = N'" & FormatSQL(z2351.cdUnitMaterialOld) & "', "
            SQL = SQL & "    K2351_seUnitPacking      = N'" & FormatSQL(z2351.seUnitPacking) & "', "
            SQL = SQL & "    K2351_cdUnitPacking      = N'" & FormatSQL(z2351.cdUnitPacking) & "', "
            SQL = SQL & "    K2351_seTax1      = N'" & FormatSQL(z2351.seTax1) & "', "
            SQL = SQL & "    K2351_cdTax1      = N'" & FormatSQL(z2351.cdTax1) & "', "
            SQL = SQL & "    K2351_PerTax1      =  " & FormatSQL(z2351.PerTax1) & ", "
            SQL = SQL & "    K2351_AmountTax1EX      =  " & FormatSQL(z2351.AmountTax1EX) & ", "
            SQL = SQL & "    K2351_AmountTax1      =  " & FormatSQL(z2351.AmountTax1) & ", "
            SQL = SQL & "    K2351_seTax2      = N'" & FormatSQL(z2351.seTax2) & "', "
            SQL = SQL & "    K2351_cdTax2      = N'" & FormatSQL(z2351.cdTax2) & "', "
            SQL = SQL & "    K2351_PerTax2      =  " & FormatSQL(z2351.PerTax2) & ", "
            SQL = SQL & "    K2351_AmountTax2EX      =  " & FormatSQL(z2351.AmountTax2EX) & ", "
            SQL = SQL & "    K2351_AmountTax2      =  " & FormatSQL(z2351.AmountTax2) & ", "
            SQL = SQL & "    K2351_seTax3      = N'" & FormatSQL(z2351.seTax3) & "', "
            SQL = SQL & "    K2351_cdTax3      = N'" & FormatSQL(z2351.cdTax3) & "', "
            SQL = SQL & "    K2351_PerTax3      =  " & FormatSQL(z2351.PerTax3) & ", "
            SQL = SQL & "    K2351_AmountTax3EX      =  " & FormatSQL(z2351.AmountTax3EX) & ", "
            SQL = SQL & "    K2351_AmountTax3      =  " & FormatSQL(z2351.AmountTax3) & ", "
            SQL = SQL & "    K2351_AmountTaxVND      =  " & FormatSQL(z2351.AmountTaxVND) & ", "
            SQL = SQL & "    K2351_AmountPurchasingEX      =  " & FormatSQL(z2351.AmountPurchasingEX) & ", "
            SQL = SQL & "    K2351_AmountPurchasingVND      =  " & FormatSQL(z2351.AmountPurchasingVND) & ", "
            SQL = SQL & "    K2351_PackInBound      =  " & FormatSQL(z2351.PackInBound) & ", "
            SQL = SQL & "    K2351_QtyBasic      =  " & FormatSQL(z2351.QtyBasic) & ", "
            SQL = SQL & "    K2351_QtyInBound_Or      =  " & FormatSQL(z2351.QtyInBound_Or) & ", "
            SQL = SQL & "    K2351_QtyPackingList      =  " & FormatSQL(z2351.QtyPackingList) & ", "
            SQL = SQL & "    K2351_QtyAllocation      =  " & FormatSQL(z2351.QtyAllocation) & ", "
            SQL = SQL & "    K2351_QtyInBound      =  " & FormatSQL(z2351.QtyInBound) & ", "
            SQL = SQL & "    K2351_QtyInBoundPL      =  " & FormatSQL(z2351.QtyInBoundPL) & ", "
            SQL = SQL & "    K2351_PackOutBound      =  " & FormatSQL(z2351.PackOutBound) & ", "
            SQL = SQL & "    K2351_QtyOutBound      =  " & FormatSQL(z2351.QtyOutBound) & ", "
            SQL = SQL & "    K2351_QtyInBoundTrading      =  " & FormatSQL(z2351.QtyInBoundTrading) & ", "
            SQL = SQL & "    K2351_InchargeTrading      = N'" & FormatSQL(z2351.InchargeTrading) & "', "
            SQL = SQL & "    K2351_TradingDate      = N'" & FormatSQL(z2351.TradingDate) & "', "
            SQL = SQL & "    K2351_TradingNo      = N'" & FormatSQL(z2351.TradingNo) & "', "
            SQL = SQL & "    K2351_TradingCode      = N'" & FormatSQL(z2351.TradingCode) & "', "
            SQL = SQL & "    K2351_TradingGroup      = N'" & FormatSQL(z2351.TradingGroup) & "', "
            SQL = SQL & "    K2351_PriceTrading      =  " & FormatSQL(z2351.PriceTrading) & ", "
            SQL = SQL & "    K2351_AMTTradingNet      =  " & FormatSQL(z2351.AMTTradingNet) & ", "
            SQL = SQL & "    K2351_AMTTradingVAT      =  " & FormatSQL(z2351.AMTTradingVAT) & ", "
            SQL = SQL & "    K2351_AMTTrading      =  " & FormatSQL(z2351.AMTTrading) & ", "
            SQL = SQL & "    K2351_AmountNoVATEX      =  " & FormatSQL(z2351.AmountNoVATEX) & ", "
            SQL = SQL & "    K2351_AmountNoVATVND      =  " & FormatSQL(z2351.AmountNoVATVND) & ", "
            SQL = SQL & "    K2351_AmountTotalEX      =  " & FormatSQL(z2351.AmountTotalEX) & ", "
            SQL = SQL & "    K2351_AmountTotalVND      =  " & FormatSQL(z2351.AmountTotalVND) & ", "
            SQL = SQL & "    K2351_AmountInBoundEX      =  " & FormatSQL(z2351.AmountInBoundEX) & ", "
            SQL = SQL & "    K2351_AmountInBoundVND      =  " & FormatSQL(z2351.AmountInBoundVND) & ", "
            SQL = SQL & "    K2351_AmountEX      =  " & FormatSQL(z2351.AmountEX) & ", "
            SQL = SQL & "    K2351_AmountVND      =  " & FormatSQL(z2351.AmountVND) & ", "
            SQL = SQL & "    K2351_FactOrderNo      = N'" & FormatSQL(z2351.FactOrderNo) & "', "
            SQL = SQL & "    K2351_FactOrderSeq      =  " & FormatSQL(z2351.FactOrderSeq) & ", "
            SQL = SQL & "    K2351_JobCardWorking      = N'" & FormatSQL(z2351.JobCardWorking) & "', "
            SQL = SQL & "    K2351_JobCardWorkingSeq      = N'" & FormatSQL(z2351.JobCardWorkingSeq) & "', "
            SQL = SQL & "    K2351_JobCardType      = N'" & FormatSQL(z2351.JobCardType) & "', "
            SQL = SQL & "    K2351_CheckComplete      = N'" & FormatSQL(z2351.CheckComplete) & "', "
            SQL = SQL & "    K2351_CheckQC      = N'" & FormatSQL(z2351.CheckQC) & "', "
            SQL = SQL & "    K2351_IsPosted      = N'" & FormatSQL(z2351.IsPosted) & "', "
            SQL = SQL & "    K2351_DatePosted      = N'" & FormatSQL(z2351.DatePosted) & "', "
            SQL = SQL & "    K2351_DateInsert      = N'" & FormatSQL(z2351.DateInsert) & "', "
            SQL = SQL & "    K2351_DateUpdate      = N'" & FormatSQL(z2351.DateUpdate) & "', "
            SQL = SQL & "    K2351_InchargeInsert      = N'" & FormatSQL(z2351.InchargeInsert) & "', "
            SQL = SQL & "    K2351_InchargeUpdate      = N'" & FormatSQL(z2351.InchargeUpdate) & "', "
            SQL = SQL & "    K2351_DateSync      = N'" & FormatSQL(z2351.DateSync) & "', "
            SQL = SQL & "    K2351_CheckSync      = N'" & FormatSQL(z2351.CheckSync) & "', "
            SQL = SQL & "    K2351_CheckPL      = N'" & FormatSQL(z2351.CheckPL) & "', "
            SQL = SQL & "    K2351_Remark      = N'" & FormatSQL(z2351.Remark) & "'  "
            SQL = SQL & " WHERE K2351_MaterialInBoundNo		 = '" & z2351.MaterialInBoundNo & "' "
            SQL = SQL & "   AND K2351_MaterialInBoundSeq		 = '" & z2351.MaterialInBoundSeq & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK2351 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK2351", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK2351(z2351 As T2351_AREA) As Boolean
        DELETE_PFK2351 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK2351 "
            SQL = SQL & " WHERE K2351_MaterialInBoundNo		 = '" & z2351.MaterialInBoundNo & "' "
            SQL = SQL & "   AND K2351_MaterialInBoundSeq		 = '" & z2351.MaterialInBoundSeq & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK2351 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK2351", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D2351_CLEAR()
        Try

            D2351.MaterialInBoundNo = ""
            D2351.MaterialInBoundSeq = ""
            D2351.DateAccept = ""
            D2351.seSite = ""
            D2351.cdSite = ""
            D2351.seDepartment = ""
            D2351.cdDepartment = ""
            D2351.seFactory = ""
            D2351.cdFactory = ""
            D2351.seSeason = ""
            D2351.cdSeason = ""
            D2351.seWareHouseGroup = ""
            D2351.cdWareHouseGroup = ""
            D2351.seWareHousePosition = ""
            D2351.cdWareHousePosition = ""
            D2351.DateInBoundMaterial = ""
            D2351.CheckInBoundMaterial = ""
            D2351.CheckMaterialType = ""
            D2351.CheckMarketType = ""
            D2351.CustomerCode = ""
            D2351.SupplierCode = ""
            D2351.InchargeInBound = ""
            D2351.InvoiceNo = ""
            D2351.ContainerNo = ""
            D2351.MaterialCode = ""
            D2351.ColorCode = ""
            D2351.ColorName = ""
            D2351.SizeName = ""
            D2351.Width = ""
            D2351.seUnitPrice = ""
            D2351.cdUnitPrice = ""
            D2351.PriceMaterial = 0
            D2351.DateExchange = ""
            D2351.PriceExchange = 0
            D2351.PriceExchangeAP = 0
            D2351.PriceMaterialEX = 0
            D2351.PriceMaterialVND = 0
            D2351.seUnitMaterial = ""
            D2351.cdUnitMaterial = ""
            D2351.cdUnitMaterialPL = ""
            D2351.QtyConversion = 0
            D2351.Operator = ""
            D2351.CheckConversion = ""
            D2351.DateConversion = ""
            D2351.seUnitMaterialOld = ""
            D2351.cdUnitMaterialOld = ""
            D2351.seUnitPacking = ""
            D2351.cdUnitPacking = ""
            D2351.seTax1 = ""
            D2351.cdTax1 = ""
            D2351.PerTax1 = 0
            D2351.AmountTax1EX = 0
            D2351.AmountTax1 = 0
            D2351.seTax2 = ""
            D2351.cdTax2 = ""
            D2351.PerTax2 = 0
            D2351.AmountTax2EX = 0
            D2351.AmountTax2 = 0
            D2351.seTax3 = ""
            D2351.cdTax3 = ""
            D2351.PerTax3 = 0
            D2351.AmountTax3EX = 0
            D2351.AmountTax3 = 0
            D2351.AmountTaxVND = 0
            D2351.AmountPurchasingEX = 0
            D2351.AmountPurchasingVND = 0
            D2351.PackInBound = 0
            D2351.QtyBasic = 0
            D2351.QtyInBound_Or = 0
            D2351.QtyPackingList = 0
            D2351.QtyAllocation = 0
            D2351.QtyInBound = 0
            D2351.QtyInBoundPL = 0
            D2351.PackOutBound = 0
            D2351.QtyOutBound = 0
            D2351.QtyInBoundTrading = 0
            D2351.InchargeTrading = ""
            D2351.TradingDate = ""
            D2351.TradingNo = ""
            D2351.TradingCode = ""
            D2351.TradingGroup = ""
            D2351.PriceTrading = 0
            D2351.AMTTradingNet = 0
            D2351.AMTTradingVAT = 0
            D2351.AMTTrading = 0
            D2351.AmountNoVATEX = 0
            D2351.AmountNoVATVND = 0
            D2351.AmountTotalEX = 0
            D2351.AmountTotalVND = 0
            D2351.AmountInBoundEX = 0
            D2351.AmountInBoundVND = 0
            D2351.AmountEX = 0
            D2351.AmountVND = 0
            D2351.FactOrderNo = ""
            D2351.FactOrderSeq = 0
            D2351.JobCardWorking = ""
            D2351.JobCardWorkingSeq = ""
            D2351.JobCardType = ""
            D2351.CheckComplete = ""
            D2351.CheckQC = ""
            D2351.IsPosted = ""
            D2351.DatePosted = ""
            D2351.DateInsert = ""
            D2351.DateUpdate = ""
            D2351.InchargeInsert = ""
            D2351.InchargeUpdate = ""
            D2351.DateSync = ""
            D2351.CheckSync = ""
            D2351.CheckPL = ""
            D2351.Remark = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D2351_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x2351 As T2351_AREA)
        Try

            x2351.MaterialInBoundNo = trim$(x2351.MaterialInBoundNo)
            x2351.MaterialInBoundSeq = trim$(x2351.MaterialInBoundSeq)
            x2351.DateAccept = trim$(x2351.DateAccept)
            x2351.seSite = trim$(x2351.seSite)
            x2351.cdSite = trim$(x2351.cdSite)
            x2351.seDepartment = trim$(x2351.seDepartment)
            x2351.cdDepartment = trim$(x2351.cdDepartment)
            x2351.seFactory = trim$(x2351.seFactory)
            x2351.cdFactory = trim$(x2351.cdFactory)
            x2351.seSeason = trim$(x2351.seSeason)
            x2351.cdSeason = trim$(x2351.cdSeason)
            x2351.seWareHouseGroup = trim$(x2351.seWareHouseGroup)
            x2351.cdWareHouseGroup = trim$(x2351.cdWareHouseGroup)
            x2351.seWareHousePosition = trim$(x2351.seWareHousePosition)
            x2351.cdWareHousePosition = trim$(x2351.cdWareHousePosition)
            x2351.DateInBoundMaterial = trim$(x2351.DateInBoundMaterial)
            x2351.CheckInBoundMaterial = trim$(x2351.CheckInBoundMaterial)
            x2351.CheckMaterialType = trim$(x2351.CheckMaterialType)
            x2351.CheckMarketType = trim$(x2351.CheckMarketType)
            x2351.CustomerCode = trim$(x2351.CustomerCode)
            x2351.SupplierCode = trim$(x2351.SupplierCode)
            x2351.InchargeInBound = trim$(x2351.InchargeInBound)
            x2351.InvoiceNo = trim$(x2351.InvoiceNo)
            x2351.ContainerNo = trim$(x2351.ContainerNo)
            x2351.MaterialCode = trim$(x2351.MaterialCode)
            x2351.ColorCode = trim$(x2351.ColorCode)
            x2351.ColorName = Trim$(x2351.ColorName)
            x2351.SizeName = Trim$(x2351.SizeName)
            x2351.Width = Trim$(x2351.Width)
            x2351.seUnitPrice = trim$(x2351.seUnitPrice)
            x2351.cdUnitPrice = trim$(x2351.cdUnitPrice)
            x2351.PriceMaterial = trim$(x2351.PriceMaterial)
            x2351.DateExchange = trim$(x2351.DateExchange)
            x2351.PriceExchange = trim$(x2351.PriceExchange)
            x2351.PriceExchangeAP = trim$(x2351.PriceExchangeAP)
            x2351.PriceMaterialEX = trim$(x2351.PriceMaterialEX)
            x2351.PriceMaterialVND = trim$(x2351.PriceMaterialVND)
            x2351.seUnitMaterial = trim$(x2351.seUnitMaterial)
            x2351.cdUnitMaterial = Trim$(x2351.cdUnitMaterial)
            x2351.cdUnitMaterialPL = Trim$(x2351.cdUnitMaterialPL)
            x2351.QtyConversion = trim$(x2351.QtyConversion)
            x2351.Operator = trim$(x2351.Operator)
            x2351.CheckConversion = trim$(x2351.CheckConversion)
            x2351.DateConversion = trim$(x2351.DateConversion)
            x2351.seUnitMaterialOld = trim$(x2351.seUnitMaterialOld)
            x2351.cdUnitMaterialOld = trim$(x2351.cdUnitMaterialOld)
            x2351.seUnitPacking = trim$(x2351.seUnitPacking)
            x2351.cdUnitPacking = trim$(x2351.cdUnitPacking)
            x2351.seTax1 = trim$(x2351.seTax1)
            x2351.cdTax1 = trim$(x2351.cdTax1)
            x2351.PerTax1 = trim$(x2351.PerTax1)
            x2351.AmountTax1EX = trim$(x2351.AmountTax1EX)
            x2351.AmountTax1 = trim$(x2351.AmountTax1)
            x2351.seTax2 = trim$(x2351.seTax2)
            x2351.cdTax2 = trim$(x2351.cdTax2)
            x2351.PerTax2 = trim$(x2351.PerTax2)
            x2351.AmountTax2EX = trim$(x2351.AmountTax2EX)
            x2351.AmountTax2 = trim$(x2351.AmountTax2)
            x2351.seTax3 = trim$(x2351.seTax3)
            x2351.cdTax3 = trim$(x2351.cdTax3)
            x2351.PerTax3 = trim$(x2351.PerTax3)
            x2351.AmountTax3EX = trim$(x2351.AmountTax3EX)
            x2351.AmountTax3 = trim$(x2351.AmountTax3)
            x2351.AmountTaxVND = trim$(x2351.AmountTaxVND)
            x2351.AmountPurchasingEX = trim$(x2351.AmountPurchasingEX)
            x2351.AmountPurchasingVND = trim$(x2351.AmountPurchasingVND)
            x2351.PackInBound = trim$(x2351.PackInBound)
            x2351.QtyBasic = trim$(x2351.QtyBasic)
            x2351.QtyInBound_Or = trim$(x2351.QtyInBound_Or)
            x2351.QtyPackingList = trim$(x2351.QtyPackingList)
            x2351.QtyAllocation = trim$(x2351.QtyAllocation)
            x2351.QtyInBound = Trim$(x2351.QtyInBound)
            x2351.QtyInBoundPL = Trim$(x2351.QtyInBoundPL)
            x2351.PackOutBound = trim$(x2351.PackOutBound)
            x2351.QtyOutBound = trim$(x2351.QtyOutBound)
            x2351.QtyInBoundTrading = trim$(x2351.QtyInBoundTrading)
            x2351.InchargeTrading = trim$(x2351.InchargeTrading)
            x2351.TradingDate = trim$(x2351.TradingDate)
            x2351.TradingNo = trim$(x2351.TradingNo)
            x2351.TradingCode = trim$(x2351.TradingCode)
            x2351.TradingGroup = trim$(x2351.TradingGroup)
            x2351.PriceTrading = trim$(x2351.PriceTrading)
            x2351.AMTTradingNet = trim$(x2351.AMTTradingNet)
            x2351.AMTTradingVAT = trim$(x2351.AMTTradingVAT)
            x2351.AMTTrading = trim$(x2351.AMTTrading)
            x2351.AmountNoVATEX = trim$(x2351.AmountNoVATEX)
            x2351.AmountNoVATVND = trim$(x2351.AmountNoVATVND)
            x2351.AmountTotalEX = trim$(x2351.AmountTotalEX)
            x2351.AmountTotalVND = trim$(x2351.AmountTotalVND)
            x2351.AmountInBoundEX = trim$(x2351.AmountInBoundEX)
            x2351.AmountInBoundVND = trim$(x2351.AmountInBoundVND)
            x2351.AmountEX = trim$(x2351.AmountEX)
            x2351.AmountVND = trim$(x2351.AmountVND)
            x2351.FactOrderNo = trim$(x2351.FactOrderNo)
            x2351.FactOrderSeq = trim$(x2351.FactOrderSeq)
            x2351.JobCardWorking = trim$(x2351.JobCardWorking)
            x2351.JobCardWorkingSeq = trim$(x2351.JobCardWorkingSeq)
            x2351.JobCardType = trim$(x2351.JobCardType)
            x2351.CheckComplete = trim$(x2351.CheckComplete)
            x2351.CheckQC = trim$(x2351.CheckQC)
            x2351.IsPosted = trim$(x2351.IsPosted)
            x2351.DatePosted = trim$(x2351.DatePosted)
            x2351.DateInsert = trim$(x2351.DateInsert)
            x2351.DateUpdate = trim$(x2351.DateUpdate)
            x2351.InchargeInsert = trim$(x2351.InchargeInsert)
            x2351.InchargeUpdate = trim$(x2351.InchargeUpdate)
            x2351.DateSync = trim$(x2351.DateSync)
            x2351.CheckSync = trim$(x2351.CheckSync)
            x2351.CheckPL = trim$(x2351.CheckPL)
            x2351.Remark = trim$(x2351.Remark)

            If trim$(x2351.MaterialInBoundNo) = "" Then x2351.MaterialInBoundNo = Space(1)
            If trim$(x2351.MaterialInBoundSeq) = "" Then x2351.MaterialInBoundSeq = Space(1)
            If trim$(x2351.DateAccept) = "" Then x2351.DateAccept = Space(1)
            If trim$(x2351.seSite) = "" Then x2351.seSite = Space(1)
            If trim$(x2351.cdSite) = "" Then x2351.cdSite = Space(1)
            If trim$(x2351.seDepartment) = "" Then x2351.seDepartment = Space(1)
            If trim$(x2351.cdDepartment) = "" Then x2351.cdDepartment = Space(1)
            If trim$(x2351.seFactory) = "" Then x2351.seFactory = Space(1)
            If trim$(x2351.cdFactory) = "" Then x2351.cdFactory = Space(1)
            If trim$(x2351.seSeason) = "" Then x2351.seSeason = Space(1)
            If trim$(x2351.cdSeason) = "" Then x2351.cdSeason = Space(1)
            If trim$(x2351.seWareHouseGroup) = "" Then x2351.seWareHouseGroup = Space(1)
            If trim$(x2351.cdWareHouseGroup) = "" Then x2351.cdWareHouseGroup = Space(1)
            If trim$(x2351.seWareHousePosition) = "" Then x2351.seWareHousePosition = Space(1)
            If trim$(x2351.cdWareHousePosition) = "" Then x2351.cdWareHousePosition = Space(1)
            If trim$(x2351.DateInBoundMaterial) = "" Then x2351.DateInBoundMaterial = Space(1)
            If trim$(x2351.CheckInBoundMaterial) = "" Then x2351.CheckInBoundMaterial = Space(1)
            If trim$(x2351.CheckMaterialType) = "" Then x2351.CheckMaterialType = Space(1)
            If trim$(x2351.CheckMarketType) = "" Then x2351.CheckMarketType = Space(1)
            If trim$(x2351.CustomerCode) = "" Then x2351.CustomerCode = Space(1)
            If trim$(x2351.SupplierCode) = "" Then x2351.SupplierCode = Space(1)
            If trim$(x2351.InchargeInBound) = "" Then x2351.InchargeInBound = Space(1)
            If trim$(x2351.InvoiceNo) = "" Then x2351.InvoiceNo = Space(1)
            If trim$(x2351.ContainerNo) = "" Then x2351.ContainerNo = Space(1)
            If trim$(x2351.MaterialCode) = "" Then x2351.MaterialCode = Space(1)
            If trim$(x2351.ColorCode) = "" Then x2351.ColorCode = Space(1)
            If Trim$(x2351.ColorName) = "" Then x2351.ColorName = Space(1)
            If Trim$(x2351.SizeName) = "" Then x2351.SizeName = Space(1)
            If Trim$(x2351.Width) = "" Then x2351.Width = Space(1)
            If trim$(x2351.seUnitPrice) = "" Then x2351.seUnitPrice = Space(1)
            If trim$(x2351.cdUnitPrice) = "" Then x2351.cdUnitPrice = Space(1)
            If trim$(x2351.PriceMaterial) = "" Then x2351.PriceMaterial = 0
            If trim$(x2351.DateExchange) = "" Then x2351.DateExchange = Space(1)
            If trim$(x2351.PriceExchange) = "" Then x2351.PriceExchange = 0
            If trim$(x2351.PriceExchangeAP) = "" Then x2351.PriceExchangeAP = 0
            If trim$(x2351.PriceMaterialEX) = "" Then x2351.PriceMaterialEX = 0
            If trim$(x2351.PriceMaterialVND) = "" Then x2351.PriceMaterialVND = 0
            If trim$(x2351.seUnitMaterial) = "" Then x2351.seUnitMaterial = Space(1)
            If Trim$(x2351.cdUnitMaterial) = "" Then x2351.cdUnitMaterial = Space(1)
            If Trim$(x2351.cdUnitMaterialPL) = "" Then x2351.cdUnitMaterialPL = Space(1)
            If trim$(x2351.QtyConversion) = "" Then x2351.QtyConversion = 0
            If trim$(x2351.Operator) = "" Then x2351.Operator = Space(1)
            If trim$(x2351.CheckConversion) = "" Then x2351.CheckConversion = Space(1)
            If trim$(x2351.DateConversion) = "" Then x2351.DateConversion = Space(1)
            If trim$(x2351.seUnitMaterialOld) = "" Then x2351.seUnitMaterialOld = Space(1)
            If trim$(x2351.cdUnitMaterialOld) = "" Then x2351.cdUnitMaterialOld = Space(1)
            If trim$(x2351.seUnitPacking) = "" Then x2351.seUnitPacking = Space(1)
            If trim$(x2351.cdUnitPacking) = "" Then x2351.cdUnitPacking = Space(1)
            If trim$(x2351.seTax1) = "" Then x2351.seTax1 = Space(1)
            If trim$(x2351.cdTax1) = "" Then x2351.cdTax1 = Space(1)
            If trim$(x2351.PerTax1) = "" Then x2351.PerTax1 = 0
            If trim$(x2351.AmountTax1EX) = "" Then x2351.AmountTax1EX = 0
            If trim$(x2351.AmountTax1) = "" Then x2351.AmountTax1 = 0
            If trim$(x2351.seTax2) = "" Then x2351.seTax2 = Space(1)
            If trim$(x2351.cdTax2) = "" Then x2351.cdTax2 = Space(1)
            If trim$(x2351.PerTax2) = "" Then x2351.PerTax2 = 0
            If trim$(x2351.AmountTax2EX) = "" Then x2351.AmountTax2EX = 0
            If trim$(x2351.AmountTax2) = "" Then x2351.AmountTax2 = 0
            If trim$(x2351.seTax3) = "" Then x2351.seTax3 = Space(1)
            If trim$(x2351.cdTax3) = "" Then x2351.cdTax3 = Space(1)
            If trim$(x2351.PerTax3) = "" Then x2351.PerTax3 = 0
            If trim$(x2351.AmountTax3EX) = "" Then x2351.AmountTax3EX = 0
            If trim$(x2351.AmountTax3) = "" Then x2351.AmountTax3 = 0
            If trim$(x2351.AmountTaxVND) = "" Then x2351.AmountTaxVND = 0
            If trim$(x2351.AmountPurchasingEX) = "" Then x2351.AmountPurchasingEX = 0
            If trim$(x2351.AmountPurchasingVND) = "" Then x2351.AmountPurchasingVND = 0
            If trim$(x2351.PackInBound) = "" Then x2351.PackInBound = 0
            If trim$(x2351.QtyBasic) = "" Then x2351.QtyBasic = 0
            If trim$(x2351.QtyInBound_Or) = "" Then x2351.QtyInBound_Or = 0
            If trim$(x2351.QtyPackingList) = "" Then x2351.QtyPackingList = 0
            If trim$(x2351.QtyAllocation) = "" Then x2351.QtyAllocation = 0
            If Trim$(x2351.QtyInBound) = "" Then x2351.QtyInBound = 0
            If Trim$(x2351.QtyInBoundPL) = "" Then x2351.QtyInBoundPL = 0
            If trim$(x2351.PackOutBound) = "" Then x2351.PackOutBound = 0
            If trim$(x2351.QtyOutBound) = "" Then x2351.QtyOutBound = 0
            If trim$(x2351.QtyInBoundTrading) = "" Then x2351.QtyInBoundTrading = 0
            If trim$(x2351.InchargeTrading) = "" Then x2351.InchargeTrading = Space(1)
            If trim$(x2351.TradingDate) = "" Then x2351.TradingDate = Space(1)
            If trim$(x2351.TradingNo) = "" Then x2351.TradingNo = Space(1)
            If trim$(x2351.TradingCode) = "" Then x2351.TradingCode = Space(1)
            If trim$(x2351.TradingGroup) = "" Then x2351.TradingGroup = Space(1)
            If trim$(x2351.PriceTrading) = "" Then x2351.PriceTrading = 0
            If trim$(x2351.AMTTradingNet) = "" Then x2351.AMTTradingNet = 0
            If trim$(x2351.AMTTradingVAT) = "" Then x2351.AMTTradingVAT = 0
            If trim$(x2351.AMTTrading) = "" Then x2351.AMTTrading = 0
            If trim$(x2351.AmountNoVATEX) = "" Then x2351.AmountNoVATEX = 0
            If trim$(x2351.AmountNoVATVND) = "" Then x2351.AmountNoVATVND = 0
            If trim$(x2351.AmountTotalEX) = "" Then x2351.AmountTotalEX = 0
            If trim$(x2351.AmountTotalVND) = "" Then x2351.AmountTotalVND = 0
            If trim$(x2351.AmountInBoundEX) = "" Then x2351.AmountInBoundEX = 0
            If trim$(x2351.AmountInBoundVND) = "" Then x2351.AmountInBoundVND = 0
            If trim$(x2351.AmountEX) = "" Then x2351.AmountEX = 0
            If trim$(x2351.AmountVND) = "" Then x2351.AmountVND = 0
            If trim$(x2351.FactOrderNo) = "" Then x2351.FactOrderNo = Space(1)
            If trim$(x2351.FactOrderSeq) = "" Then x2351.FactOrderSeq = 0
            If trim$(x2351.JobCardWorking) = "" Then x2351.JobCardWorking = Space(1)
            If trim$(x2351.JobCardWorkingSeq) = "" Then x2351.JobCardWorkingSeq = Space(1)
            If trim$(x2351.JobCardType) = "" Then x2351.JobCardType = Space(1)
            If trim$(x2351.CheckComplete) = "" Then x2351.CheckComplete = Space(1)
            If trim$(x2351.CheckQC) = "" Then x2351.CheckQC = Space(1)
            If trim$(x2351.IsPosted) = "" Then x2351.IsPosted = Space(1)
            If trim$(x2351.DatePosted) = "" Then x2351.DatePosted = Space(1)
            If trim$(x2351.DateInsert) = "" Then x2351.DateInsert = Space(1)
            If trim$(x2351.DateUpdate) = "" Then x2351.DateUpdate = Space(1)
            If trim$(x2351.InchargeInsert) = "" Then x2351.InchargeInsert = Space(1)
            If trim$(x2351.InchargeUpdate) = "" Then x2351.InchargeUpdate = Space(1)
            If trim$(x2351.DateSync) = "" Then x2351.DateSync = Space(1)
            If trim$(x2351.CheckSync) = "" Then x2351.CheckSync = Space(1)
            If trim$(x2351.CheckPL) = "" Then x2351.CheckPL = Space(1)
            If trim$(x2351.Remark) = "" Then x2351.Remark = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K2351_MOVE(rs2351 As SqlClient.SqlDataReader)
        Try

            Call D2351_CLEAR()

            If IsdbNull(rs2351!K2351_MaterialInBoundNo) = False Then D2351.MaterialInBoundNo = Trim$(rs2351!K2351_MaterialInBoundNo)
            If IsdbNull(rs2351!K2351_MaterialInBoundSeq) = False Then D2351.MaterialInBoundSeq = Trim$(rs2351!K2351_MaterialInBoundSeq)
            If IsdbNull(rs2351!K2351_DateAccept) = False Then D2351.DateAccept = Trim$(rs2351!K2351_DateAccept)
            If IsdbNull(rs2351!K2351_seSite) = False Then D2351.seSite = Trim$(rs2351!K2351_seSite)
            If IsdbNull(rs2351!K2351_cdSite) = False Then D2351.cdSite = Trim$(rs2351!K2351_cdSite)
            If IsdbNull(rs2351!K2351_seDepartment) = False Then D2351.seDepartment = Trim$(rs2351!K2351_seDepartment)
            If IsdbNull(rs2351!K2351_cdDepartment) = False Then D2351.cdDepartment = Trim$(rs2351!K2351_cdDepartment)
            If IsdbNull(rs2351!K2351_seFactory) = False Then D2351.seFactory = Trim$(rs2351!K2351_seFactory)
            If IsdbNull(rs2351!K2351_cdFactory) = False Then D2351.cdFactory = Trim$(rs2351!K2351_cdFactory)
            If IsdbNull(rs2351!K2351_seSeason) = False Then D2351.seSeason = Trim$(rs2351!K2351_seSeason)
            If IsdbNull(rs2351!K2351_cdSeason) = False Then D2351.cdSeason = Trim$(rs2351!K2351_cdSeason)
            If IsdbNull(rs2351!K2351_seWareHouseGroup) = False Then D2351.seWareHouseGroup = Trim$(rs2351!K2351_seWareHouseGroup)
            If IsdbNull(rs2351!K2351_cdWareHouseGroup) = False Then D2351.cdWareHouseGroup = Trim$(rs2351!K2351_cdWareHouseGroup)
            If IsdbNull(rs2351!K2351_seWareHousePosition) = False Then D2351.seWareHousePosition = Trim$(rs2351!K2351_seWareHousePosition)
            If IsdbNull(rs2351!K2351_cdWareHousePosition) = False Then D2351.cdWareHousePosition = Trim$(rs2351!K2351_cdWareHousePosition)
            If IsdbNull(rs2351!K2351_DateInBoundMaterial) = False Then D2351.DateInBoundMaterial = Trim$(rs2351!K2351_DateInBoundMaterial)
            If IsdbNull(rs2351!K2351_CheckInBoundMaterial) = False Then D2351.CheckInBoundMaterial = Trim$(rs2351!K2351_CheckInBoundMaterial)
            If IsdbNull(rs2351!K2351_CheckMaterialType) = False Then D2351.CheckMaterialType = Trim$(rs2351!K2351_CheckMaterialType)
            If IsdbNull(rs2351!K2351_CheckMarketType) = False Then D2351.CheckMarketType = Trim$(rs2351!K2351_CheckMarketType)
            If IsdbNull(rs2351!K2351_CustomerCode) = False Then D2351.CustomerCode = Trim$(rs2351!K2351_CustomerCode)
            If IsdbNull(rs2351!K2351_SupplierCode) = False Then D2351.SupplierCode = Trim$(rs2351!K2351_SupplierCode)
            If IsdbNull(rs2351!K2351_InchargeInBound) = False Then D2351.InchargeInBound = Trim$(rs2351!K2351_InchargeInBound)
            If IsdbNull(rs2351!K2351_InvoiceNo) = False Then D2351.InvoiceNo = Trim$(rs2351!K2351_InvoiceNo)
            If IsdbNull(rs2351!K2351_ContainerNo) = False Then D2351.ContainerNo = Trim$(rs2351!K2351_ContainerNo)
            If IsdbNull(rs2351!K2351_MaterialCode) = False Then D2351.MaterialCode = Trim$(rs2351!K2351_MaterialCode)
            If IsdbNull(rs2351!K2351_ColorCode) = False Then D2351.ColorCode = Trim$(rs2351!K2351_ColorCode)
            If IsDBNull(rs2351!K2351_ColorName) = False Then D2351.ColorName = Trim$(rs2351!K2351_ColorName)
            If IsDBNull(rs2351!K2351_SizeName) = False Then D2351.SizeName = Trim$(rs2351!K2351_SizeName)
            If IsDBNull(rs2351!K2351_Width) = False Then D2351.Width = Trim$(rs2351!K2351_Width)
            If IsdbNull(rs2351!K2351_seUnitPrice) = False Then D2351.seUnitPrice = Trim$(rs2351!K2351_seUnitPrice)
            If IsdbNull(rs2351!K2351_cdUnitPrice) = False Then D2351.cdUnitPrice = Trim$(rs2351!K2351_cdUnitPrice)
            If IsdbNull(rs2351!K2351_PriceMaterial) = False Then D2351.PriceMaterial = Trim$(rs2351!K2351_PriceMaterial)
            If IsdbNull(rs2351!K2351_DateExchange) = False Then D2351.DateExchange = Trim$(rs2351!K2351_DateExchange)
            If IsdbNull(rs2351!K2351_PriceExchange) = False Then D2351.PriceExchange = Trim$(rs2351!K2351_PriceExchange)
            If IsdbNull(rs2351!K2351_PriceExchangeAP) = False Then D2351.PriceExchangeAP = Trim$(rs2351!K2351_PriceExchangeAP)
            If IsdbNull(rs2351!K2351_PriceMaterialEX) = False Then D2351.PriceMaterialEX = Trim$(rs2351!K2351_PriceMaterialEX)
            If IsdbNull(rs2351!K2351_PriceMaterialVND) = False Then D2351.PriceMaterialVND = Trim$(rs2351!K2351_PriceMaterialVND)
            If IsdbNull(rs2351!K2351_seUnitMaterial) = False Then D2351.seUnitMaterial = Trim$(rs2351!K2351_seUnitMaterial)
            If IsDBNull(rs2351!K2351_cdUnitMaterial) = False Then D2351.cdUnitMaterial = Trim$(rs2351!K2351_cdUnitMaterial)
            If IsDBNull(rs2351!K2351_cdUnitMaterialPL) = False Then D2351.cdUnitMaterialPL = Trim$(rs2351!K2351_cdUnitMaterialPL)
            If IsdbNull(rs2351!K2351_QtyConversion) = False Then D2351.QtyConversion = Trim$(rs2351!K2351_QtyConversion)
            If IsdbNull(rs2351!K2351_Operator) = False Then D2351.Operator = Trim$(rs2351!K2351_Operator)
            If IsdbNull(rs2351!K2351_CheckConversion) = False Then D2351.CheckConversion = Trim$(rs2351!K2351_CheckConversion)
            If IsdbNull(rs2351!K2351_DateConversion) = False Then D2351.DateConversion = Trim$(rs2351!K2351_DateConversion)
            If IsdbNull(rs2351!K2351_seUnitMaterialOld) = False Then D2351.seUnitMaterialOld = Trim$(rs2351!K2351_seUnitMaterialOld)
            If IsdbNull(rs2351!K2351_cdUnitMaterialOld) = False Then D2351.cdUnitMaterialOld = Trim$(rs2351!K2351_cdUnitMaterialOld)
            If IsdbNull(rs2351!K2351_seUnitPacking) = False Then D2351.seUnitPacking = Trim$(rs2351!K2351_seUnitPacking)
            If IsdbNull(rs2351!K2351_cdUnitPacking) = False Then D2351.cdUnitPacking = Trim$(rs2351!K2351_cdUnitPacking)
            If IsdbNull(rs2351!K2351_seTax1) = False Then D2351.seTax1 = Trim$(rs2351!K2351_seTax1)
            If IsdbNull(rs2351!K2351_cdTax1) = False Then D2351.cdTax1 = Trim$(rs2351!K2351_cdTax1)
            If IsdbNull(rs2351!K2351_PerTax1) = False Then D2351.PerTax1 = Trim$(rs2351!K2351_PerTax1)
            If IsdbNull(rs2351!K2351_AmountTax1EX) = False Then D2351.AmountTax1EX = Trim$(rs2351!K2351_AmountTax1EX)
            If IsdbNull(rs2351!K2351_AmountTax1) = False Then D2351.AmountTax1 = Trim$(rs2351!K2351_AmountTax1)
            If IsdbNull(rs2351!K2351_seTax2) = False Then D2351.seTax2 = Trim$(rs2351!K2351_seTax2)
            If IsdbNull(rs2351!K2351_cdTax2) = False Then D2351.cdTax2 = Trim$(rs2351!K2351_cdTax2)
            If IsdbNull(rs2351!K2351_PerTax2) = False Then D2351.PerTax2 = Trim$(rs2351!K2351_PerTax2)
            If IsdbNull(rs2351!K2351_AmountTax2EX) = False Then D2351.AmountTax2EX = Trim$(rs2351!K2351_AmountTax2EX)
            If IsdbNull(rs2351!K2351_AmountTax2) = False Then D2351.AmountTax2 = Trim$(rs2351!K2351_AmountTax2)
            If IsdbNull(rs2351!K2351_seTax3) = False Then D2351.seTax3 = Trim$(rs2351!K2351_seTax3)
            If IsdbNull(rs2351!K2351_cdTax3) = False Then D2351.cdTax3 = Trim$(rs2351!K2351_cdTax3)
            If IsdbNull(rs2351!K2351_PerTax3) = False Then D2351.PerTax3 = Trim$(rs2351!K2351_PerTax3)
            If IsdbNull(rs2351!K2351_AmountTax3EX) = False Then D2351.AmountTax3EX = Trim$(rs2351!K2351_AmountTax3EX)
            If IsdbNull(rs2351!K2351_AmountTax3) = False Then D2351.AmountTax3 = Trim$(rs2351!K2351_AmountTax3)
            If IsdbNull(rs2351!K2351_AmountTaxVND) = False Then D2351.AmountTaxVND = Trim$(rs2351!K2351_AmountTaxVND)
            If IsdbNull(rs2351!K2351_AmountPurchasingEX) = False Then D2351.AmountPurchasingEX = Trim$(rs2351!K2351_AmountPurchasingEX)
            If IsdbNull(rs2351!K2351_AmountPurchasingVND) = False Then D2351.AmountPurchasingVND = Trim$(rs2351!K2351_AmountPurchasingVND)
            If IsdbNull(rs2351!K2351_PackInBound) = False Then D2351.PackInBound = Trim$(rs2351!K2351_PackInBound)
            If IsdbNull(rs2351!K2351_QtyBasic) = False Then D2351.QtyBasic = Trim$(rs2351!K2351_QtyBasic)
            If IsdbNull(rs2351!K2351_QtyInBound_Or) = False Then D2351.QtyInBound_Or = Trim$(rs2351!K2351_QtyInBound_Or)
            If IsdbNull(rs2351!K2351_QtyPackingList) = False Then D2351.QtyPackingList = Trim$(rs2351!K2351_QtyPackingList)
            If IsdbNull(rs2351!K2351_QtyAllocation) = False Then D2351.QtyAllocation = Trim$(rs2351!K2351_QtyAllocation)
            If IsDBNull(rs2351!K2351_QtyInBound) = False Then D2351.QtyInBound = Trim$(rs2351!K2351_QtyInBound)
            If IsDBNull(rs2351!K2351_QtyInBoundPL) = False Then D2351.QtyInBoundPL = Trim$(rs2351!K2351_QtyInBoundPL)
            If IsdbNull(rs2351!K2351_PackOutBound) = False Then D2351.PackOutBound = Trim$(rs2351!K2351_PackOutBound)
            If IsdbNull(rs2351!K2351_QtyOutBound) = False Then D2351.QtyOutBound = Trim$(rs2351!K2351_QtyOutBound)
            If IsdbNull(rs2351!K2351_QtyInBoundTrading) = False Then D2351.QtyInBoundTrading = Trim$(rs2351!K2351_QtyInBoundTrading)
            If IsdbNull(rs2351!K2351_InchargeTrading) = False Then D2351.InchargeTrading = Trim$(rs2351!K2351_InchargeTrading)
            If IsdbNull(rs2351!K2351_TradingDate) = False Then D2351.TradingDate = Trim$(rs2351!K2351_TradingDate)
            If IsdbNull(rs2351!K2351_TradingNo) = False Then D2351.TradingNo = Trim$(rs2351!K2351_TradingNo)
            If IsdbNull(rs2351!K2351_TradingCode) = False Then D2351.TradingCode = Trim$(rs2351!K2351_TradingCode)
            If IsdbNull(rs2351!K2351_TradingGroup) = False Then D2351.TradingGroup = Trim$(rs2351!K2351_TradingGroup)
            If IsdbNull(rs2351!K2351_PriceTrading) = False Then D2351.PriceTrading = Trim$(rs2351!K2351_PriceTrading)
            If IsdbNull(rs2351!K2351_AMTTradingNet) = False Then D2351.AMTTradingNet = Trim$(rs2351!K2351_AMTTradingNet)
            If IsdbNull(rs2351!K2351_AMTTradingVAT) = False Then D2351.AMTTradingVAT = Trim$(rs2351!K2351_AMTTradingVAT)
            If IsdbNull(rs2351!K2351_AMTTrading) = False Then D2351.AMTTrading = Trim$(rs2351!K2351_AMTTrading)
            If IsdbNull(rs2351!K2351_AmountNoVATEX) = False Then D2351.AmountNoVATEX = Trim$(rs2351!K2351_AmountNoVATEX)
            If IsdbNull(rs2351!K2351_AmountNoVATVND) = False Then D2351.AmountNoVATVND = Trim$(rs2351!K2351_AmountNoVATVND)
            If IsdbNull(rs2351!K2351_AmountTotalEX) = False Then D2351.AmountTotalEX = Trim$(rs2351!K2351_AmountTotalEX)
            If IsdbNull(rs2351!K2351_AmountTotalVND) = False Then D2351.AmountTotalVND = Trim$(rs2351!K2351_AmountTotalVND)
            If IsdbNull(rs2351!K2351_AmountInBoundEX) = False Then D2351.AmountInBoundEX = Trim$(rs2351!K2351_AmountInBoundEX)
            If IsdbNull(rs2351!K2351_AmountInBoundVND) = False Then D2351.AmountInBoundVND = Trim$(rs2351!K2351_AmountInBoundVND)
            If IsdbNull(rs2351!K2351_AmountEX) = False Then D2351.AmountEX = Trim$(rs2351!K2351_AmountEX)
            If IsdbNull(rs2351!K2351_AmountVND) = False Then D2351.AmountVND = Trim$(rs2351!K2351_AmountVND)
            If IsdbNull(rs2351!K2351_FactOrderNo) = False Then D2351.FactOrderNo = Trim$(rs2351!K2351_FactOrderNo)
            If IsdbNull(rs2351!K2351_FactOrderSeq) = False Then D2351.FactOrderSeq = Trim$(rs2351!K2351_FactOrderSeq)
            If IsdbNull(rs2351!K2351_JobCardWorking) = False Then D2351.JobCardWorking = Trim$(rs2351!K2351_JobCardWorking)
            If IsdbNull(rs2351!K2351_JobCardWorkingSeq) = False Then D2351.JobCardWorkingSeq = Trim$(rs2351!K2351_JobCardWorkingSeq)
            If IsdbNull(rs2351!K2351_JobCardType) = False Then D2351.JobCardType = Trim$(rs2351!K2351_JobCardType)
            If IsdbNull(rs2351!K2351_CheckComplete) = False Then D2351.CheckComplete = Trim$(rs2351!K2351_CheckComplete)
            If IsdbNull(rs2351!K2351_CheckQC) = False Then D2351.CheckQC = Trim$(rs2351!K2351_CheckQC)
            If IsdbNull(rs2351!K2351_IsPosted) = False Then D2351.IsPosted = Trim$(rs2351!K2351_IsPosted)
            If IsdbNull(rs2351!K2351_DatePosted) = False Then D2351.DatePosted = Trim$(rs2351!K2351_DatePosted)
            If IsdbNull(rs2351!K2351_DateInsert) = False Then D2351.DateInsert = Trim$(rs2351!K2351_DateInsert)
            If IsdbNull(rs2351!K2351_DateUpdate) = False Then D2351.DateUpdate = Trim$(rs2351!K2351_DateUpdate)
            If IsdbNull(rs2351!K2351_InchargeInsert) = False Then D2351.InchargeInsert = Trim$(rs2351!K2351_InchargeInsert)
            If IsdbNull(rs2351!K2351_InchargeUpdate) = False Then D2351.InchargeUpdate = Trim$(rs2351!K2351_InchargeUpdate)
            If IsdbNull(rs2351!K2351_DateSync) = False Then D2351.DateSync = Trim$(rs2351!K2351_DateSync)
            If IsdbNull(rs2351!K2351_CheckSync) = False Then D2351.CheckSync = Trim$(rs2351!K2351_CheckSync)
            If IsdbNull(rs2351!K2351_CheckPL) = False Then D2351.CheckPL = Trim$(rs2351!K2351_CheckPL)
            If IsdbNull(rs2351!K2351_Remark) = False Then D2351.Remark = Trim$(rs2351!K2351_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K2351_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K2351_MOVE(rs2351 As DataRow)
        Try

            Call D2351_CLEAR()

            If IsdbNull(rs2351!K2351_MaterialInBoundNo) = False Then D2351.MaterialInBoundNo = Trim$(rs2351!K2351_MaterialInBoundNo)
            If IsdbNull(rs2351!K2351_MaterialInBoundSeq) = False Then D2351.MaterialInBoundSeq = Trim$(rs2351!K2351_MaterialInBoundSeq)
            If IsdbNull(rs2351!K2351_DateAccept) = False Then D2351.DateAccept = Trim$(rs2351!K2351_DateAccept)
            If IsdbNull(rs2351!K2351_seSite) = False Then D2351.seSite = Trim$(rs2351!K2351_seSite)
            If IsdbNull(rs2351!K2351_cdSite) = False Then D2351.cdSite = Trim$(rs2351!K2351_cdSite)
            If IsdbNull(rs2351!K2351_seDepartment) = False Then D2351.seDepartment = Trim$(rs2351!K2351_seDepartment)
            If IsdbNull(rs2351!K2351_cdDepartment) = False Then D2351.cdDepartment = Trim$(rs2351!K2351_cdDepartment)
            If IsdbNull(rs2351!K2351_seFactory) = False Then D2351.seFactory = Trim$(rs2351!K2351_seFactory)
            If IsdbNull(rs2351!K2351_cdFactory) = False Then D2351.cdFactory = Trim$(rs2351!K2351_cdFactory)
            If IsdbNull(rs2351!K2351_seSeason) = False Then D2351.seSeason = Trim$(rs2351!K2351_seSeason)
            If IsdbNull(rs2351!K2351_cdSeason) = False Then D2351.cdSeason = Trim$(rs2351!K2351_cdSeason)
            If IsdbNull(rs2351!K2351_seWareHouseGroup) = False Then D2351.seWareHouseGroup = Trim$(rs2351!K2351_seWareHouseGroup)
            If IsdbNull(rs2351!K2351_cdWareHouseGroup) = False Then D2351.cdWareHouseGroup = Trim$(rs2351!K2351_cdWareHouseGroup)
            If IsdbNull(rs2351!K2351_seWareHousePosition) = False Then D2351.seWareHousePosition = Trim$(rs2351!K2351_seWareHousePosition)
            If IsdbNull(rs2351!K2351_cdWareHousePosition) = False Then D2351.cdWareHousePosition = Trim$(rs2351!K2351_cdWareHousePosition)
            If IsdbNull(rs2351!K2351_DateInBoundMaterial) = False Then D2351.DateInBoundMaterial = Trim$(rs2351!K2351_DateInBoundMaterial)
            If IsdbNull(rs2351!K2351_CheckInBoundMaterial) = False Then D2351.CheckInBoundMaterial = Trim$(rs2351!K2351_CheckInBoundMaterial)
            If IsdbNull(rs2351!K2351_CheckMaterialType) = False Then D2351.CheckMaterialType = Trim$(rs2351!K2351_CheckMaterialType)
            If IsdbNull(rs2351!K2351_CheckMarketType) = False Then D2351.CheckMarketType = Trim$(rs2351!K2351_CheckMarketType)
            If IsdbNull(rs2351!K2351_CustomerCode) = False Then D2351.CustomerCode = Trim$(rs2351!K2351_CustomerCode)
            If IsdbNull(rs2351!K2351_SupplierCode) = False Then D2351.SupplierCode = Trim$(rs2351!K2351_SupplierCode)
            If IsdbNull(rs2351!K2351_InchargeInBound) = False Then D2351.InchargeInBound = Trim$(rs2351!K2351_InchargeInBound)
            If IsdbNull(rs2351!K2351_InvoiceNo) = False Then D2351.InvoiceNo = Trim$(rs2351!K2351_InvoiceNo)
            If IsdbNull(rs2351!K2351_ContainerNo) = False Then D2351.ContainerNo = Trim$(rs2351!K2351_ContainerNo)
            If IsdbNull(rs2351!K2351_MaterialCode) = False Then D2351.MaterialCode = Trim$(rs2351!K2351_MaterialCode)
            If IsdbNull(rs2351!K2351_ColorCode) = False Then D2351.ColorCode = Trim$(rs2351!K2351_ColorCode)
            If IsDBNull(rs2351!K2351_ColorName) = False Then D2351.ColorName = Trim$(rs2351!K2351_ColorName)
            If IsDBNull(rs2351!K2351_SizeName) = False Then D2351.SizeName = Trim$(rs2351!K2351_SizeName)
            If IsDBNull(rs2351!K2351_Width) = False Then D2351.Width = Trim$(rs2351!K2351_Width)
            If IsdbNull(rs2351!K2351_seUnitPrice) = False Then D2351.seUnitPrice = Trim$(rs2351!K2351_seUnitPrice)
            If IsdbNull(rs2351!K2351_cdUnitPrice) = False Then D2351.cdUnitPrice = Trim$(rs2351!K2351_cdUnitPrice)
            If IsdbNull(rs2351!K2351_PriceMaterial) = False Then D2351.PriceMaterial = Trim$(rs2351!K2351_PriceMaterial)
            If IsdbNull(rs2351!K2351_DateExchange) = False Then D2351.DateExchange = Trim$(rs2351!K2351_DateExchange)
            If IsdbNull(rs2351!K2351_PriceExchange) = False Then D2351.PriceExchange = Trim$(rs2351!K2351_PriceExchange)
            If IsdbNull(rs2351!K2351_PriceExchangeAP) = False Then D2351.PriceExchangeAP = Trim$(rs2351!K2351_PriceExchangeAP)
            If IsdbNull(rs2351!K2351_PriceMaterialEX) = False Then D2351.PriceMaterialEX = Trim$(rs2351!K2351_PriceMaterialEX)
            If IsdbNull(rs2351!K2351_PriceMaterialVND) = False Then D2351.PriceMaterialVND = Trim$(rs2351!K2351_PriceMaterialVND)
            If IsdbNull(rs2351!K2351_seUnitMaterial) = False Then D2351.seUnitMaterial = Trim$(rs2351!K2351_seUnitMaterial)
            If IsDBNull(rs2351!K2351_cdUnitMaterial) = False Then D2351.cdUnitMaterial = Trim$(rs2351!K2351_cdUnitMaterial)
            If IsDBNull(rs2351!K2351_cdUnitMaterialPL) = False Then D2351.cdUnitMaterialPL = Trim$(rs2351!K2351_cdUnitMaterialPL)
            If IsdbNull(rs2351!K2351_QtyConversion) = False Then D2351.QtyConversion = Trim$(rs2351!K2351_QtyConversion)
            If IsdbNull(rs2351!K2351_Operator) = False Then D2351.Operator = Trim$(rs2351!K2351_Operator)
            If IsdbNull(rs2351!K2351_CheckConversion) = False Then D2351.CheckConversion = Trim$(rs2351!K2351_CheckConversion)
            If IsdbNull(rs2351!K2351_DateConversion) = False Then D2351.DateConversion = Trim$(rs2351!K2351_DateConversion)
            If IsdbNull(rs2351!K2351_seUnitMaterialOld) = False Then D2351.seUnitMaterialOld = Trim$(rs2351!K2351_seUnitMaterialOld)
            If IsdbNull(rs2351!K2351_cdUnitMaterialOld) = False Then D2351.cdUnitMaterialOld = Trim$(rs2351!K2351_cdUnitMaterialOld)
            If IsdbNull(rs2351!K2351_seUnitPacking) = False Then D2351.seUnitPacking = Trim$(rs2351!K2351_seUnitPacking)
            If IsdbNull(rs2351!K2351_cdUnitPacking) = False Then D2351.cdUnitPacking = Trim$(rs2351!K2351_cdUnitPacking)
            If IsdbNull(rs2351!K2351_seTax1) = False Then D2351.seTax1 = Trim$(rs2351!K2351_seTax1)
            If IsdbNull(rs2351!K2351_cdTax1) = False Then D2351.cdTax1 = Trim$(rs2351!K2351_cdTax1)
            If IsdbNull(rs2351!K2351_PerTax1) = False Then D2351.PerTax1 = Trim$(rs2351!K2351_PerTax1)
            If IsdbNull(rs2351!K2351_AmountTax1EX) = False Then D2351.AmountTax1EX = Trim$(rs2351!K2351_AmountTax1EX)
            If IsdbNull(rs2351!K2351_AmountTax1) = False Then D2351.AmountTax1 = Trim$(rs2351!K2351_AmountTax1)
            If IsdbNull(rs2351!K2351_seTax2) = False Then D2351.seTax2 = Trim$(rs2351!K2351_seTax2)
            If IsdbNull(rs2351!K2351_cdTax2) = False Then D2351.cdTax2 = Trim$(rs2351!K2351_cdTax2)
            If IsdbNull(rs2351!K2351_PerTax2) = False Then D2351.PerTax2 = Trim$(rs2351!K2351_PerTax2)
            If IsdbNull(rs2351!K2351_AmountTax2EX) = False Then D2351.AmountTax2EX = Trim$(rs2351!K2351_AmountTax2EX)
            If IsdbNull(rs2351!K2351_AmountTax2) = False Then D2351.AmountTax2 = Trim$(rs2351!K2351_AmountTax2)
            If IsdbNull(rs2351!K2351_seTax3) = False Then D2351.seTax3 = Trim$(rs2351!K2351_seTax3)
            If IsdbNull(rs2351!K2351_cdTax3) = False Then D2351.cdTax3 = Trim$(rs2351!K2351_cdTax3)
            If IsdbNull(rs2351!K2351_PerTax3) = False Then D2351.PerTax3 = Trim$(rs2351!K2351_PerTax3)
            If IsdbNull(rs2351!K2351_AmountTax3EX) = False Then D2351.AmountTax3EX = Trim$(rs2351!K2351_AmountTax3EX)
            If IsdbNull(rs2351!K2351_AmountTax3) = False Then D2351.AmountTax3 = Trim$(rs2351!K2351_AmountTax3)
            If IsdbNull(rs2351!K2351_AmountTaxVND) = False Then D2351.AmountTaxVND = Trim$(rs2351!K2351_AmountTaxVND)
            If IsdbNull(rs2351!K2351_AmountPurchasingEX) = False Then D2351.AmountPurchasingEX = Trim$(rs2351!K2351_AmountPurchasingEX)
            If IsdbNull(rs2351!K2351_AmountPurchasingVND) = False Then D2351.AmountPurchasingVND = Trim$(rs2351!K2351_AmountPurchasingVND)
            If IsdbNull(rs2351!K2351_PackInBound) = False Then D2351.PackInBound = Trim$(rs2351!K2351_PackInBound)
            If IsdbNull(rs2351!K2351_QtyBasic) = False Then D2351.QtyBasic = Trim$(rs2351!K2351_QtyBasic)
            If IsdbNull(rs2351!K2351_QtyInBound_Or) = False Then D2351.QtyInBound_Or = Trim$(rs2351!K2351_QtyInBound_Or)
            If IsdbNull(rs2351!K2351_QtyPackingList) = False Then D2351.QtyPackingList = Trim$(rs2351!K2351_QtyPackingList)
            If IsdbNull(rs2351!K2351_QtyAllocation) = False Then D2351.QtyAllocation = Trim$(rs2351!K2351_QtyAllocation)
            If IsDBNull(rs2351!K2351_QtyInBound) = False Then D2351.QtyInBound = Trim$(rs2351!K2351_QtyInBound)
            If IsDBNull(rs2351!K2351_QtyInBoundPL) = False Then D2351.QtyInBoundPL = Trim$(rs2351!K2351_QtyInBoundPL)
            If IsdbNull(rs2351!K2351_PackOutBound) = False Then D2351.PackOutBound = Trim$(rs2351!K2351_PackOutBound)
            If IsdbNull(rs2351!K2351_QtyOutBound) = False Then D2351.QtyOutBound = Trim$(rs2351!K2351_QtyOutBound)
            If IsdbNull(rs2351!K2351_QtyInBoundTrading) = False Then D2351.QtyInBoundTrading = Trim$(rs2351!K2351_QtyInBoundTrading)
            If IsdbNull(rs2351!K2351_InchargeTrading) = False Then D2351.InchargeTrading = Trim$(rs2351!K2351_InchargeTrading)
            If IsdbNull(rs2351!K2351_TradingDate) = False Then D2351.TradingDate = Trim$(rs2351!K2351_TradingDate)
            If IsdbNull(rs2351!K2351_TradingNo) = False Then D2351.TradingNo = Trim$(rs2351!K2351_TradingNo)
            If IsdbNull(rs2351!K2351_TradingCode) = False Then D2351.TradingCode = Trim$(rs2351!K2351_TradingCode)
            If IsdbNull(rs2351!K2351_TradingGroup) = False Then D2351.TradingGroup = Trim$(rs2351!K2351_TradingGroup)
            If IsdbNull(rs2351!K2351_PriceTrading) = False Then D2351.PriceTrading = Trim$(rs2351!K2351_PriceTrading)
            If IsdbNull(rs2351!K2351_AMTTradingNet) = False Then D2351.AMTTradingNet = Trim$(rs2351!K2351_AMTTradingNet)
            If IsdbNull(rs2351!K2351_AMTTradingVAT) = False Then D2351.AMTTradingVAT = Trim$(rs2351!K2351_AMTTradingVAT)
            If IsdbNull(rs2351!K2351_AMTTrading) = False Then D2351.AMTTrading = Trim$(rs2351!K2351_AMTTrading)
            If IsdbNull(rs2351!K2351_AmountNoVATEX) = False Then D2351.AmountNoVATEX = Trim$(rs2351!K2351_AmountNoVATEX)
            If IsdbNull(rs2351!K2351_AmountNoVATVND) = False Then D2351.AmountNoVATVND = Trim$(rs2351!K2351_AmountNoVATVND)
            If IsdbNull(rs2351!K2351_AmountTotalEX) = False Then D2351.AmountTotalEX = Trim$(rs2351!K2351_AmountTotalEX)
            If IsdbNull(rs2351!K2351_AmountTotalVND) = False Then D2351.AmountTotalVND = Trim$(rs2351!K2351_AmountTotalVND)
            If IsdbNull(rs2351!K2351_AmountInBoundEX) = False Then D2351.AmountInBoundEX = Trim$(rs2351!K2351_AmountInBoundEX)
            If IsdbNull(rs2351!K2351_AmountInBoundVND) = False Then D2351.AmountInBoundVND = Trim$(rs2351!K2351_AmountInBoundVND)
            If IsdbNull(rs2351!K2351_AmountEX) = False Then D2351.AmountEX = Trim$(rs2351!K2351_AmountEX)
            If IsdbNull(rs2351!K2351_AmountVND) = False Then D2351.AmountVND = Trim$(rs2351!K2351_AmountVND)
            If IsdbNull(rs2351!K2351_FactOrderNo) = False Then D2351.FactOrderNo = Trim$(rs2351!K2351_FactOrderNo)
            If IsdbNull(rs2351!K2351_FactOrderSeq) = False Then D2351.FactOrderSeq = Trim$(rs2351!K2351_FactOrderSeq)
            If IsdbNull(rs2351!K2351_JobCardWorking) = False Then D2351.JobCardWorking = Trim$(rs2351!K2351_JobCardWorking)
            If IsdbNull(rs2351!K2351_JobCardWorkingSeq) = False Then D2351.JobCardWorkingSeq = Trim$(rs2351!K2351_JobCardWorkingSeq)
            If IsdbNull(rs2351!K2351_JobCardType) = False Then D2351.JobCardType = Trim$(rs2351!K2351_JobCardType)
            If IsdbNull(rs2351!K2351_CheckComplete) = False Then D2351.CheckComplete = Trim$(rs2351!K2351_CheckComplete)
            If IsdbNull(rs2351!K2351_CheckQC) = False Then D2351.CheckQC = Trim$(rs2351!K2351_CheckQC)
            If IsdbNull(rs2351!K2351_IsPosted) = False Then D2351.IsPosted = Trim$(rs2351!K2351_IsPosted)
            If IsdbNull(rs2351!K2351_DatePosted) = False Then D2351.DatePosted = Trim$(rs2351!K2351_DatePosted)
            If IsdbNull(rs2351!K2351_DateInsert) = False Then D2351.DateInsert = Trim$(rs2351!K2351_DateInsert)
            If IsdbNull(rs2351!K2351_DateUpdate) = False Then D2351.DateUpdate = Trim$(rs2351!K2351_DateUpdate)
            If IsdbNull(rs2351!K2351_InchargeInsert) = False Then D2351.InchargeInsert = Trim$(rs2351!K2351_InchargeInsert)
            If IsdbNull(rs2351!K2351_InchargeUpdate) = False Then D2351.InchargeUpdate = Trim$(rs2351!K2351_InchargeUpdate)
            If IsdbNull(rs2351!K2351_DateSync) = False Then D2351.DateSync = Trim$(rs2351!K2351_DateSync)
            If IsdbNull(rs2351!K2351_CheckSync) = False Then D2351.CheckSync = Trim$(rs2351!K2351_CheckSync)
            If IsdbNull(rs2351!K2351_CheckPL) = False Then D2351.CheckPL = Trim$(rs2351!K2351_CheckPL)
            If IsdbNull(rs2351!K2351_Remark) = False Then D2351.Remark = Trim$(rs2351!K2351_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K2351_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K2351_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z2351 As T2351_AREA, MATERIALINBOUNDNO As String, MATERIALINBOUNDSEQ As String) As Boolean

        K2351_MOVE = False

        Try
            If READ_PFK2351(MATERIALINBOUNDNO, MATERIALINBOUNDSEQ) = True Then
                z2351 = D2351
                K2351_MOVE = True
            Else
                z2351 = Nothing
            End If

            If getColumIndex(spr, "MaterialInBoundNo") > -1 Then z2351.MaterialInBoundNo = getDataM(spr, getColumIndex(spr, "MaterialInBoundNo"), xRow)
            If getColumIndex(spr, "MaterialInBoundSeq") > -1 Then z2351.MaterialInBoundSeq = getDataM(spr, getColumIndex(spr, "MaterialInBoundSeq"), xRow)
            If getColumIndex(spr, "DateAccept") > -1 Then z2351.DateAccept = getDataM(spr, getColumIndex(spr, "DateAccept"), xRow)
            If getColumIndex(spr, "seSite") > -1 Then z2351.seSite = getDataM(spr, getColumIndex(spr, "seSite"), xRow)
            If getColumIndex(spr, "cdSite") > -1 Then z2351.cdSite = getDataM(spr, getColumIndex(spr, "cdSite"), xRow)
            If getColumIndex(spr, "seDepartment") > -1 Then z2351.seDepartment = getDataM(spr, getColumIndex(spr, "seDepartment"), xRow)
            If getColumIndex(spr, "cdDepartment") > -1 Then z2351.cdDepartment = getDataM(spr, getColumIndex(spr, "cdDepartment"), xRow)
            If getColumIndex(spr, "seFactory") > -1 Then z2351.seFactory = getDataM(spr, getColumIndex(spr, "seFactory"), xRow)
            If getColumIndex(spr, "cdFactory") > -1 Then z2351.cdFactory = getDataM(spr, getColumIndex(spr, "cdFactory"), xRow)
            If getColumIndex(spr, "seSeason") > -1 Then z2351.seSeason = getDataM(spr, getColumIndex(spr, "seSeason"), xRow)
            If getColumIndex(spr, "cdSeason") > -1 Then z2351.cdSeason = getDataM(spr, getColumIndex(spr, "cdSeason"), xRow)
            If getColumIndex(spr, "seWareHouseGroup") > -1 Then z2351.seWareHouseGroup = getDataM(spr, getColumIndex(spr, "seWareHouseGroup"), xRow)
            If getColumIndex(spr, "cdWareHouseGroup") > -1 Then z2351.cdWareHouseGroup = getDataM(spr, getColumIndex(spr, "cdWareHouseGroup"), xRow)
            If getColumIndex(spr, "seWareHousePosition") > -1 Then z2351.seWareHousePosition = getDataM(spr, getColumIndex(spr, "seWareHousePosition"), xRow)
            If getColumIndex(spr, "cdWareHousePosition") > -1 Then z2351.cdWareHousePosition = getDataM(spr, getColumIndex(spr, "cdWareHousePosition"), xRow)
            If getColumIndex(spr, "DateInBoundMaterial") > -1 Then z2351.DateInBoundMaterial = getDataM(spr, getColumIndex(spr, "DateInBoundMaterial"), xRow)
            If getColumIndex(spr, "CheckInBoundMaterial") > -1 Then z2351.CheckInBoundMaterial = getDataM(spr, getColumIndex(spr, "CheckInBoundMaterial"), xRow)
            If getColumIndex(spr, "CheckMaterialType") > -1 Then z2351.CheckMaterialType = getDataM(spr, getColumIndex(spr, "CheckMaterialType"), xRow)
            If getColumIndex(spr, "CheckMarketType") > -1 Then z2351.CheckMarketType = getDataM(spr, getColumIndex(spr, "CheckMarketType"), xRow)
            If getColumIndex(spr, "CustomerCode") > -1 Then z2351.CustomerCode = getDataM(spr, getColumIndex(spr, "CustomerCode"), xRow)
            If getColumIndex(spr, "SupplierCode") > -1 Then z2351.SupplierCode = getDataM(spr, getColumIndex(spr, "SupplierCode"), xRow)
            If getColumIndex(spr, "InchargeInBound") > -1 Then z2351.InchargeInBound = getDataM(spr, getColumIndex(spr, "InchargeInBound"), xRow)
            If getColumIndex(spr, "InvoiceNo") > -1 Then z2351.InvoiceNo = getDataM(spr, getColumIndex(spr, "InvoiceNo"), xRow)
            If getColumIndex(spr, "ContainerNo") > -1 Then z2351.ContainerNo = getDataM(spr, getColumIndex(spr, "ContainerNo"), xRow)
            If getColumIndex(spr, "MaterialCode") > -1 Then z2351.MaterialCode = getDataM(spr, getColumIndex(spr, "MaterialCode"), xRow)
            If getColumIndex(spr, "ColorCode") > -1 Then z2351.ColorCode = getDataM(spr, getColumIndex(spr, "ColorCode"), xRow)
            If getColumIndex(spr, "ColorName") > -1 Then z2351.ColorName = getDataM(spr, getColumIndex(spr, "ColorName"), xRow)
            If getColumIndex(spr, "SizeName") > -1 Then z2351.SizeName = getDataM(spr, getColumIndex(spr, "SizeName"), xRow)
            If getColumIndex(spr, "Width") > -1 Then z2351.Width = getDataM(spr, getColumIndex(spr, "Width"), xRow)
            If getColumIndex(spr, "seUnitPrice") > -1 Then z2351.seUnitPrice = getDataM(spr, getColumIndex(spr, "seUnitPrice"), xRow)
            If getColumIndex(spr, "cdUnitPrice") > -1 Then z2351.cdUnitPrice = getDataM(spr, getColumIndex(spr, "cdUnitPrice"), xRow)
            If getColumIndex(spr, "PriceMaterial") > -1 Then z2351.PriceMaterial = getDataM(spr, getColumIndex(spr, "PriceMaterial"), xRow)
            If getColumIndex(spr, "DateExchange") > -1 Then z2351.DateExchange = getDataM(spr, getColumIndex(spr, "DateExchange"), xRow)
            If getColumIndex(spr, "PriceExchange") > -1 Then z2351.PriceExchange = getDataM(spr, getColumIndex(spr, "PriceExchange"), xRow)
            If getColumIndex(spr, "PriceExchangeAP") > -1 Then z2351.PriceExchangeAP = getDataM(spr, getColumIndex(spr, "PriceExchangeAP"), xRow)
            If getColumIndex(spr, "PriceMaterialEX") > -1 Then z2351.PriceMaterialEX = getDataM(spr, getColumIndex(spr, "PriceMaterialEX"), xRow)
            If getColumIndex(spr, "PriceMaterialVND") > -1 Then z2351.PriceMaterialVND = getDataM(spr, getColumIndex(spr, "PriceMaterialVND"), xRow)
            If getColumIndex(spr, "seUnitMaterial") > -1 Then z2351.seUnitMaterial = getDataM(spr, getColumIndex(spr, "seUnitMaterial"), xRow)
            If getColumIndex(spr, "cdUnitMaterial") > -1 Then z2351.cdUnitMaterial = getDataM(spr, getColumIndex(spr, "cdUnitMaterial"), xRow)
            If getColumIndex(spr, "cdUnitMaterialPL") > -1 Then z2351.cdUnitMaterialPL = getDataM(spr, getColumIndex(spr, "cdUnitMaterialPL"), xRow)

            If getColumIndex(spr, "QtyConversion") > -1 Then z2351.QtyConversion = getDataM(spr, getColumIndex(spr, "QtyConversion"), xRow)
            If getColumIndex(spr, "Operator") > -1 Then z2351.Operator = getDataM(spr, getColumIndex(spr, "Operator"), xRow)
            If getColumIndex(spr, "CheckConversion") > -1 Then z2351.CheckConversion = getDataM(spr, getColumIndex(spr, "CheckConversion"), xRow)
            If getColumIndex(spr, "DateConversion") > -1 Then z2351.DateConversion = getDataM(spr, getColumIndex(spr, "DateConversion"), xRow)
            If getColumIndex(spr, "seUnitMaterialOld") > -1 Then z2351.seUnitMaterialOld = getDataM(spr, getColumIndex(spr, "seUnitMaterialOld"), xRow)
            If getColumIndex(spr, "cdUnitMaterialOld") > -1 Then z2351.cdUnitMaterialOld = getDataM(spr, getColumIndex(spr, "cdUnitMaterialOld"), xRow)
            If getColumIndex(spr, "seUnitPacking") > -1 Then z2351.seUnitPacking = getDataM(spr, getColumIndex(spr, "seUnitPacking"), xRow)
            If getColumIndex(spr, "cdUnitPacking") > -1 Then z2351.cdUnitPacking = getDataM(spr, getColumIndex(spr, "cdUnitPacking"), xRow)
            If getColumIndex(spr, "seTax1") > -1 Then z2351.seTax1 = getDataM(spr, getColumIndex(spr, "seTax1"), xRow)
            If getColumIndex(spr, "cdTax1") > -1 Then z2351.cdTax1 = getDataM(spr, getColumIndex(spr, "cdTax1"), xRow)
            If getColumIndex(spr, "PerTax1") > -1 Then z2351.PerTax1 = getDataM(spr, getColumIndex(spr, "PerTax1"), xRow)
            If getColumIndex(spr, "AmountTax1EX") > -1 Then z2351.AmountTax1EX = getDataM(spr, getColumIndex(spr, "AmountTax1EX"), xRow)
            If getColumIndex(spr, "AmountTax1") > -1 Then z2351.AmountTax1 = getDataM(spr, getColumIndex(spr, "AmountTax1"), xRow)
            If getColumIndex(spr, "seTax2") > -1 Then z2351.seTax2 = getDataM(spr, getColumIndex(spr, "seTax2"), xRow)
            If getColumIndex(spr, "cdTax2") > -1 Then z2351.cdTax2 = getDataM(spr, getColumIndex(spr, "cdTax2"), xRow)
            If getColumIndex(spr, "PerTax2") > -1 Then z2351.PerTax2 = getDataM(spr, getColumIndex(spr, "PerTax2"), xRow)
            If getColumIndex(spr, "AmountTax2EX") > -1 Then z2351.AmountTax2EX = getDataM(spr, getColumIndex(spr, "AmountTax2EX"), xRow)
            If getColumIndex(spr, "AmountTax2") > -1 Then z2351.AmountTax2 = getDataM(spr, getColumIndex(spr, "AmountTax2"), xRow)
            If getColumIndex(spr, "seTax3") > -1 Then z2351.seTax3 = getDataM(spr, getColumIndex(spr, "seTax3"), xRow)
            If getColumIndex(spr, "cdTax3") > -1 Then z2351.cdTax3 = getDataM(spr, getColumIndex(spr, "cdTax3"), xRow)
            If getColumIndex(spr, "PerTax3") > -1 Then z2351.PerTax3 = getDataM(spr, getColumIndex(spr, "PerTax3"), xRow)
            If getColumIndex(spr, "AmountTax3EX") > -1 Then z2351.AmountTax3EX = getDataM(spr, getColumIndex(spr, "AmountTax3EX"), xRow)
            If getColumIndex(spr, "AmountTax3") > -1 Then z2351.AmountTax3 = getDataM(spr, getColumIndex(spr, "AmountTax3"), xRow)
            If getColumIndex(spr, "AmountTaxVND") > -1 Then z2351.AmountTaxVND = getDataM(spr, getColumIndex(spr, "AmountTaxVND"), xRow)
            If getColumIndex(spr, "AmountPurchasingEX") > -1 Then z2351.AmountPurchasingEX = getDataM(spr, getColumIndex(spr, "AmountPurchasingEX"), xRow)
            If getColumIndex(spr, "AmountPurchasingVND") > -1 Then z2351.AmountPurchasingVND = getDataM(spr, getColumIndex(spr, "AmountPurchasingVND"), xRow)
            If getColumIndex(spr, "PackInBound") > -1 Then z2351.PackInBound = getDataM(spr, getColumIndex(spr, "PackInBound"), xRow)
            If getColumIndex(spr, "QtyBasic") > -1 Then z2351.QtyBasic = getDataM(spr, getColumIndex(spr, "QtyBasic"), xRow)
            If getColumIndex(spr, "QtyInBound_Or") > -1 Then z2351.QtyInBound_Or = getDataM(spr, getColumIndex(spr, "QtyInBound_Or"), xRow)
            If getColumIndex(spr, "QtyPackingList") > -1 Then z2351.QtyPackingList = getDataM(spr, getColumIndex(spr, "QtyPackingList"), xRow)
            If getColumIndex(spr, "QtyAllocation") > -1 Then z2351.QtyAllocation = getDataM(spr, getColumIndex(spr, "QtyAllocation"), xRow)
            If getColumIndex(spr, "QtyInBound") > -1 Then z2351.QtyInBound = getDataM(spr, getColumIndex(spr, "QtyInBound"), xRow)
            If getColumIndex(spr, "QtyInBoundPL") > -1 Then z2351.QtyInBoundPL = getDataM(spr, getColumIndex(spr, "QtyInBoundPL"), xRow)
            If getColumIndex(spr, "PackOutBound") > -1 Then z2351.PackOutBound = getDataM(spr, getColumIndex(spr, "PackOutBound"), xRow)
            If getColumIndex(spr, "QtyOutBound") > -1 Then z2351.QtyOutBound = getDataM(spr, getColumIndex(spr, "QtyOutBound"), xRow)
            If getColumIndex(spr, "QtyInBoundTrading") > -1 Then z2351.QtyInBoundTrading = getDataM(spr, getColumIndex(spr, "QtyInBoundTrading"), xRow)
            If getColumIndex(spr, "InchargeTrading") > -1 Then z2351.InchargeTrading = getDataM(spr, getColumIndex(spr, "InchargeTrading"), xRow)
            If getColumIndex(spr, "TradingDate") > -1 Then z2351.TradingDate = getDataM(spr, getColumIndex(spr, "TradingDate"), xRow)
            If getColumIndex(spr, "TradingNo") > -1 Then z2351.TradingNo = getDataM(spr, getColumIndex(spr, "TradingNo"), xRow)
            If getColumIndex(spr, "TradingCode") > -1 Then z2351.TradingCode = getDataM(spr, getColumIndex(spr, "TradingCode"), xRow)
            If getColumIndex(spr, "TradingGroup") > -1 Then z2351.TradingGroup = getDataM(spr, getColumIndex(spr, "TradingGroup"), xRow)
            If getColumIndex(spr, "PriceTrading") > -1 Then z2351.PriceTrading = getDataM(spr, getColumIndex(spr, "PriceTrading"), xRow)
            If getColumIndex(spr, "AMTTradingNet") > -1 Then z2351.AMTTradingNet = getDataM(spr, getColumIndex(spr, "AMTTradingNet"), xRow)
            If getColumIndex(spr, "AMTTradingVAT") > -1 Then z2351.AMTTradingVAT = getDataM(spr, getColumIndex(spr, "AMTTradingVAT"), xRow)
            If getColumIndex(spr, "AMTTrading") > -1 Then z2351.AMTTrading = getDataM(spr, getColumIndex(spr, "AMTTrading"), xRow)
            If getColumIndex(spr, "AmountNoVATEX") > -1 Then z2351.AmountNoVATEX = getDataM(spr, getColumIndex(spr, "AmountNoVATEX"), xRow)
            If getColumIndex(spr, "AmountNoVATVND") > -1 Then z2351.AmountNoVATVND = getDataM(spr, getColumIndex(spr, "AmountNoVATVND"), xRow)
            If getColumIndex(spr, "AmountTotalEX") > -1 Then z2351.AmountTotalEX = getDataM(spr, getColumIndex(spr, "AmountTotalEX"), xRow)
            If getColumIndex(spr, "AmountTotalVND") > -1 Then z2351.AmountTotalVND = getDataM(spr, getColumIndex(spr, "AmountTotalVND"), xRow)
            If getColumIndex(spr, "AmountInBoundEX") > -1 Then z2351.AmountInBoundEX = getDataM(spr, getColumIndex(spr, "AmountInBoundEX"), xRow)
            If getColumIndex(spr, "AmountInBoundVND") > -1 Then z2351.AmountInBoundVND = getDataM(spr, getColumIndex(spr, "AmountInBoundVND"), xRow)
            If getColumIndex(spr, "AmountEX") > -1 Then z2351.AmountEX = getDataM(spr, getColumIndex(spr, "AmountEX"), xRow)
            If getColumIndex(spr, "AmountVND") > -1 Then z2351.AmountVND = getDataM(spr, getColumIndex(spr, "AmountVND"), xRow)
            If getColumIndex(spr, "FactOrderNo") > -1 Then z2351.FactOrderNo = getDataM(spr, getColumIndex(spr, "FactOrderNo"), xRow)
            If getColumIndex(spr, "FactOrderSeq") > -1 Then z2351.FactOrderSeq = getDataM(spr, getColumIndex(spr, "FactOrderSeq"), xRow)
            If getColumIndex(spr, "JobCardWorking") > -1 Then z2351.JobCardWorking = getDataM(spr, getColumIndex(spr, "JobCardWorking"), xRow)
            If getColumIndex(spr, "JobCardWorkingSeq") > -1 Then z2351.JobCardWorkingSeq = getDataM(spr, getColumIndex(spr, "JobCardWorkingSeq"), xRow)
            If getColumIndex(spr, "JobCardType") > -1 Then z2351.JobCardType = getDataM(spr, getColumIndex(spr, "JobCardType"), xRow)
            If getColumIndex(spr, "CheckComplete") > -1 Then z2351.CheckComplete = getDataM(spr, getColumIndex(spr, "CheckComplete"), xRow)
            If getColumIndex(spr, "CheckQC") > -1 Then z2351.CheckQC = getDataM(spr, getColumIndex(spr, "CheckQC"), xRow)
            If getColumIndex(spr, "IsPosted") > -1 Then z2351.IsPosted = getDataM(spr, getColumIndex(spr, "IsPosted"), xRow)
            If getColumIndex(spr, "DatePosted") > -1 Then z2351.DatePosted = getDataM(spr, getColumIndex(spr, "DatePosted"), xRow)
            If getColumIndex(spr, "DateInsert") > -1 Then z2351.DateInsert = getDataM(spr, getColumIndex(spr, "DateInsert"), xRow)
            If getColumIndex(spr, "DateUpdate") > -1 Then z2351.DateUpdate = getDataM(spr, getColumIndex(spr, "DateUpdate"), xRow)
            If getColumIndex(spr, "InchargeInsert") > -1 Then z2351.InchargeInsert = getDataM(spr, getColumIndex(spr, "InchargeInsert"), xRow)
            If getColumIndex(spr, "InchargeUpdate") > -1 Then z2351.InchargeUpdate = getDataM(spr, getColumIndex(spr, "InchargeUpdate"), xRow)
            If getColumIndex(spr, "DateSync") > -1 Then z2351.DateSync = getDataM(spr, getColumIndex(spr, "DateSync"), xRow)
            If getColumIndex(spr, "CheckSync") > -1 Then z2351.CheckSync = getDataM(spr, getColumIndex(spr, "CheckSync"), xRow)
            If getColumIndex(spr, "CheckPL") > -1 Then z2351.CheckPL = getDataM(spr, getColumIndex(spr, "CheckPL"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z2351.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K2351_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K2351_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z2351 As T2351_AREA, CheckClear As Boolean, MATERIALINBOUNDNO As String, MATERIALINBOUNDSEQ As String) As Boolean

        K2351_MOVE = False

        Try
            If READ_PFK2351(MATERIALINBOUNDNO, MATERIALINBOUNDSEQ) = True Then
                z2351 = D2351
                K2351_MOVE = True
            Else
                If CheckClear = True Then z2351 = Nothing
            End If

            If getColumIndex(spr, "MaterialInBoundNo") > -1 Then z2351.MaterialInBoundNo = getDataM(spr, getColumIndex(spr, "MaterialInBoundNo"), xRow)
            If getColumIndex(spr, "MaterialInBoundSeq") > -1 Then z2351.MaterialInBoundSeq = getDataM(spr, getColumIndex(spr, "MaterialInBoundSeq"), xRow)
            If getColumIndex(spr, "DateAccept") > -1 Then z2351.DateAccept = getDataM(spr, getColumIndex(spr, "DateAccept"), xRow)
            If getColumIndex(spr, "seSite") > -1 Then z2351.seSite = getDataM(spr, getColumIndex(spr, "seSite"), xRow)
            If getColumIndex(spr, "cdSite") > -1 Then z2351.cdSite = getDataM(spr, getColumIndex(spr, "cdSite"), xRow)
            If getColumIndex(spr, "seDepartment") > -1 Then z2351.seDepartment = getDataM(spr, getColumIndex(spr, "seDepartment"), xRow)
            If getColumIndex(spr, "cdDepartment") > -1 Then z2351.cdDepartment = getDataM(spr, getColumIndex(spr, "cdDepartment"), xRow)
            If getColumIndex(spr, "seFactory") > -1 Then z2351.seFactory = getDataM(spr, getColumIndex(spr, "seFactory"), xRow)
            If getColumIndex(spr, "cdFactory") > -1 Then z2351.cdFactory = getDataM(spr, getColumIndex(spr, "cdFactory"), xRow)
            If getColumIndex(spr, "seSeason") > -1 Then z2351.seSeason = getDataM(spr, getColumIndex(spr, "seSeason"), xRow)
            If getColumIndex(spr, "cdSeason") > -1 Then z2351.cdSeason = getDataM(spr, getColumIndex(spr, "cdSeason"), xRow)
            If getColumIndex(spr, "seWareHouseGroup") > -1 Then z2351.seWareHouseGroup = getDataM(spr, getColumIndex(spr, "seWareHouseGroup"), xRow)
            If getColumIndex(spr, "cdWareHouseGroup") > -1 Then z2351.cdWareHouseGroup = getDataM(spr, getColumIndex(spr, "cdWareHouseGroup"), xRow)
            If getColumIndex(spr, "seWareHousePosition") > -1 Then z2351.seWareHousePosition = getDataM(spr, getColumIndex(spr, "seWareHousePosition"), xRow)
            If getColumIndex(spr, "cdWareHousePosition") > -1 Then z2351.cdWareHousePosition = getDataM(spr, getColumIndex(spr, "cdWareHousePosition"), xRow)
            If getColumIndex(spr, "DateInBoundMaterial") > -1 Then z2351.DateInBoundMaterial = getDataM(spr, getColumIndex(spr, "DateInBoundMaterial"), xRow)
            If getColumIndex(spr, "CheckInBoundMaterial") > -1 Then z2351.CheckInBoundMaterial = getDataM(spr, getColumIndex(spr, "CheckInBoundMaterial"), xRow)
            If getColumIndex(spr, "CheckMaterialType") > -1 Then z2351.CheckMaterialType = getDataM(spr, getColumIndex(spr, "CheckMaterialType"), xRow)
            If getColumIndex(spr, "CheckMarketType") > -1 Then z2351.CheckMarketType = getDataM(spr, getColumIndex(spr, "CheckMarketType"), xRow)
            If getColumIndex(spr, "CustomerCode") > -1 Then z2351.CustomerCode = getDataM(spr, getColumIndex(spr, "CustomerCode"), xRow)
            If getColumIndex(spr, "SupplierCode") > -1 Then z2351.SupplierCode = getDataM(spr, getColumIndex(spr, "SupplierCode"), xRow)
            If getColumIndex(spr, "InchargeInBound") > -1 Then z2351.InchargeInBound = getDataM(spr, getColumIndex(spr, "InchargeInBound"), xRow)
            If getColumIndex(spr, "InvoiceNo") > -1 Then z2351.InvoiceNo = getDataM(spr, getColumIndex(spr, "InvoiceNo"), xRow)
            If getColumIndex(spr, "ContainerNo") > -1 Then z2351.ContainerNo = getDataM(spr, getColumIndex(spr, "ContainerNo"), xRow)
            If getColumIndex(spr, "MaterialCode") > -1 Then z2351.MaterialCode = getDataM(spr, getColumIndex(spr, "MaterialCode"), xRow)
            If getColumIndex(spr, "ColorCode") > -1 Then z2351.ColorCode = getDataM(spr, getColumIndex(spr, "ColorCode"), xRow)
            If getColumIndex(spr, "ColorName") > -1 Then z2351.ColorName = getDataM(spr, getColumIndex(spr, "ColorName"), xRow)
            If getColumIndex(spr, "SizeName") > -1 Then z2351.SizeName = getDataM(spr, getColumIndex(spr, "SizeName"), xRow)
            If getColumIndex(spr, "Width") > -1 Then z2351.Width = getDataM(spr, getColumIndex(spr, "Width"), xRow)
            If getColumIndex(spr, "seUnitPrice") > -1 Then z2351.seUnitPrice = getDataM(spr, getColumIndex(spr, "seUnitPrice"), xRow)
            If getColumIndex(spr, "cdUnitPrice") > -1 Then z2351.cdUnitPrice = getDataM(spr, getColumIndex(spr, "cdUnitPrice"), xRow)
            If getColumIndex(spr, "PriceMaterial") > -1 Then z2351.PriceMaterial = getDataM(spr, getColumIndex(spr, "PriceMaterial"), xRow)
            If getColumIndex(spr, "DateExchange") > -1 Then z2351.DateExchange = getDataM(spr, getColumIndex(spr, "DateExchange"), xRow)
            If getColumIndex(spr, "PriceExchange") > -1 Then z2351.PriceExchange = getDataM(spr, getColumIndex(spr, "PriceExchange"), xRow)
            If getColumIndex(spr, "PriceExchangeAP") > -1 Then z2351.PriceExchangeAP = getDataM(spr, getColumIndex(spr, "PriceExchangeAP"), xRow)
            If getColumIndex(spr, "PriceMaterialEX") > -1 Then z2351.PriceMaterialEX = getDataM(spr, getColumIndex(spr, "PriceMaterialEX"), xRow)
            If getColumIndex(spr, "PriceMaterialVND") > -1 Then z2351.PriceMaterialVND = getDataM(spr, getColumIndex(spr, "PriceMaterialVND"), xRow)
            If getColumIndex(spr, "seUnitMaterial") > -1 Then z2351.seUnitMaterial = getDataM(spr, getColumIndex(spr, "seUnitMaterial"), xRow)
            If getColumIndex(spr, "cdUnitMaterial") > -1 Then z2351.cdUnitMaterial = getDataM(spr, getColumIndex(spr, "cdUnitMaterial"), xRow)
            If getColumIndex(spr, "cdUnitMaterialPL") > -1 Then z2351.cdUnitMaterialPL = getDataM(spr, getColumIndex(spr, "cdUnitMaterialPL"), xRow)
            If getColumIndex(spr, "QtyConversion") > -1 Then z2351.QtyConversion = getDataM(spr, getColumIndex(spr, "QtyConversion"), xRow)
            If getColumIndex(spr, "Operator") > -1 Then z2351.Operator = getDataM(spr, getColumIndex(spr, "Operator"), xRow)
            If getColumIndex(spr, "CheckConversion") > -1 Then z2351.CheckConversion = getDataM(spr, getColumIndex(spr, "CheckConversion"), xRow)
            If getColumIndex(spr, "DateConversion") > -1 Then z2351.DateConversion = getDataM(spr, getColumIndex(spr, "DateConversion"), xRow)
            If getColumIndex(spr, "seUnitMaterialOld") > -1 Then z2351.seUnitMaterialOld = getDataM(spr, getColumIndex(spr, "seUnitMaterialOld"), xRow)
            If getColumIndex(spr, "cdUnitMaterialOld") > -1 Then z2351.cdUnitMaterialOld = getDataM(spr, getColumIndex(spr, "cdUnitMaterialOld"), xRow)
            If getColumIndex(spr, "seUnitPacking") > -1 Then z2351.seUnitPacking = getDataM(spr, getColumIndex(spr, "seUnitPacking"), xRow)
            If getColumIndex(spr, "cdUnitPacking") > -1 Then z2351.cdUnitPacking = getDataM(spr, getColumIndex(spr, "cdUnitPacking"), xRow)
            If getColumIndex(spr, "seTax1") > -1 Then z2351.seTax1 = getDataM(spr, getColumIndex(spr, "seTax1"), xRow)
            If getColumIndex(spr, "cdTax1") > -1 Then z2351.cdTax1 = getDataM(spr, getColumIndex(spr, "cdTax1"), xRow)
            If getColumIndex(spr, "PerTax1") > -1 Then z2351.PerTax1 = getDataM(spr, getColumIndex(spr, "PerTax1"), xRow)
            If getColumIndex(spr, "AmountTax1EX") > -1 Then z2351.AmountTax1EX = getDataM(spr, getColumIndex(spr, "AmountTax1EX"), xRow)
            If getColumIndex(spr, "AmountTax1") > -1 Then z2351.AmountTax1 = getDataM(spr, getColumIndex(spr, "AmountTax1"), xRow)
            If getColumIndex(spr, "seTax2") > -1 Then z2351.seTax2 = getDataM(spr, getColumIndex(spr, "seTax2"), xRow)
            If getColumIndex(spr, "cdTax2") > -1 Then z2351.cdTax2 = getDataM(spr, getColumIndex(spr, "cdTax2"), xRow)
            If getColumIndex(spr, "PerTax2") > -1 Then z2351.PerTax2 = getDataM(spr, getColumIndex(spr, "PerTax2"), xRow)
            If getColumIndex(spr, "AmountTax2EX") > -1 Then z2351.AmountTax2EX = getDataM(spr, getColumIndex(spr, "AmountTax2EX"), xRow)
            If getColumIndex(spr, "AmountTax2") > -1 Then z2351.AmountTax2 = getDataM(spr, getColumIndex(spr, "AmountTax2"), xRow)
            If getColumIndex(spr, "seTax3") > -1 Then z2351.seTax3 = getDataM(spr, getColumIndex(spr, "seTax3"), xRow)
            If getColumIndex(spr, "cdTax3") > -1 Then z2351.cdTax3 = getDataM(spr, getColumIndex(spr, "cdTax3"), xRow)
            If getColumIndex(spr, "PerTax3") > -1 Then z2351.PerTax3 = getDataM(spr, getColumIndex(spr, "PerTax3"), xRow)
            If getColumIndex(spr, "AmountTax3EX") > -1 Then z2351.AmountTax3EX = getDataM(spr, getColumIndex(spr, "AmountTax3EX"), xRow)
            If getColumIndex(spr, "AmountTax3") > -1 Then z2351.AmountTax3 = getDataM(spr, getColumIndex(spr, "AmountTax3"), xRow)
            If getColumIndex(spr, "AmountTaxVND") > -1 Then z2351.AmountTaxVND = getDataM(spr, getColumIndex(spr, "AmountTaxVND"), xRow)
            If getColumIndex(spr, "AmountPurchasingEX") > -1 Then z2351.AmountPurchasingEX = getDataM(spr, getColumIndex(spr, "AmountPurchasingEX"), xRow)
            If getColumIndex(spr, "AmountPurchasingVND") > -1 Then z2351.AmountPurchasingVND = getDataM(spr, getColumIndex(spr, "AmountPurchasingVND"), xRow)
            If getColumIndex(spr, "PackInBound") > -1 Then z2351.PackInBound = getDataM(spr, getColumIndex(spr, "PackInBound"), xRow)
            If getColumIndex(spr, "QtyBasic") > -1 Then z2351.QtyBasic = getDataM(spr, getColumIndex(spr, "QtyBasic"), xRow)
            If getColumIndex(spr, "QtyInBound_Or") > -1 Then z2351.QtyInBound_Or = getDataM(spr, getColumIndex(spr, "QtyInBound_Or"), xRow)
            If getColumIndex(spr, "QtyPackingList") > -1 Then z2351.QtyPackingList = getDataM(spr, getColumIndex(spr, "QtyPackingList"), xRow)
            If getColumIndex(spr, "QtyAllocation") > -1 Then z2351.QtyAllocation = getDataM(spr, getColumIndex(spr, "QtyAllocation"), xRow)
            If getColumIndex(spr, "QtyInBound") > -1 Then z2351.QtyInBound = getDataM(spr, getColumIndex(spr, "QtyInBound"), xRow)
            If getColumIndex(spr, "QtyInBoundPL") > -1 Then z2351.QtyInBoundPL = getDataM(spr, getColumIndex(spr, "QtyInBoundPL"), xRow)
            If getColumIndex(spr, "PackOutBound") > -1 Then z2351.PackOutBound = getDataM(spr, getColumIndex(spr, "PackOutBound"), xRow)
            If getColumIndex(spr, "QtyOutBound") > -1 Then z2351.QtyOutBound = getDataM(spr, getColumIndex(spr, "QtyOutBound"), xRow)
            If getColumIndex(spr, "QtyInBoundTrading") > -1 Then z2351.QtyInBoundTrading = getDataM(spr, getColumIndex(spr, "QtyInBoundTrading"), xRow)
            If getColumIndex(spr, "InchargeTrading") > -1 Then z2351.InchargeTrading = getDataM(spr, getColumIndex(spr, "InchargeTrading"), xRow)
            If getColumIndex(spr, "TradingDate") > -1 Then z2351.TradingDate = getDataM(spr, getColumIndex(spr, "TradingDate"), xRow)
            If getColumIndex(spr, "TradingNo") > -1 Then z2351.TradingNo = getDataM(spr, getColumIndex(spr, "TradingNo"), xRow)
            If getColumIndex(spr, "TradingCode") > -1 Then z2351.TradingCode = getDataM(spr, getColumIndex(spr, "TradingCode"), xRow)
            If getColumIndex(spr, "TradingGroup") > -1 Then z2351.TradingGroup = getDataM(spr, getColumIndex(spr, "TradingGroup"), xRow)
            If getColumIndex(spr, "PriceTrading") > -1 Then z2351.PriceTrading = getDataM(spr, getColumIndex(spr, "PriceTrading"), xRow)
            If getColumIndex(spr, "AMTTradingNet") > -1 Then z2351.AMTTradingNet = getDataM(spr, getColumIndex(spr, "AMTTradingNet"), xRow)
            If getColumIndex(spr, "AMTTradingVAT") > -1 Then z2351.AMTTradingVAT = getDataM(spr, getColumIndex(spr, "AMTTradingVAT"), xRow)
            If getColumIndex(spr, "AMTTrading") > -1 Then z2351.AMTTrading = getDataM(spr, getColumIndex(spr, "AMTTrading"), xRow)
            If getColumIndex(spr, "AmountNoVATEX") > -1 Then z2351.AmountNoVATEX = getDataM(spr, getColumIndex(spr, "AmountNoVATEX"), xRow)
            If getColumIndex(spr, "AmountNoVATVND") > -1 Then z2351.AmountNoVATVND = getDataM(spr, getColumIndex(spr, "AmountNoVATVND"), xRow)
            If getColumIndex(spr, "AmountTotalEX") > -1 Then z2351.AmountTotalEX = getDataM(spr, getColumIndex(spr, "AmountTotalEX"), xRow)
            If getColumIndex(spr, "AmountTotalVND") > -1 Then z2351.AmountTotalVND = getDataM(spr, getColumIndex(spr, "AmountTotalVND"), xRow)
            If getColumIndex(spr, "AmountInBoundEX") > -1 Then z2351.AmountInBoundEX = getDataM(spr, getColumIndex(spr, "AmountInBoundEX"), xRow)
            If getColumIndex(spr, "AmountInBoundVND") > -1 Then z2351.AmountInBoundVND = getDataM(spr, getColumIndex(spr, "AmountInBoundVND"), xRow)
            If getColumIndex(spr, "AmountEX") > -1 Then z2351.AmountEX = getDataM(spr, getColumIndex(spr, "AmountEX"), xRow)
            If getColumIndex(spr, "AmountVND") > -1 Then z2351.AmountVND = getDataM(spr, getColumIndex(spr, "AmountVND"), xRow)
            If getColumIndex(spr, "FactOrderNo") > -1 Then z2351.FactOrderNo = getDataM(spr, getColumIndex(spr, "FactOrderNo"), xRow)
            If getColumIndex(spr, "FactOrderSeq") > -1 Then z2351.FactOrderSeq = getDataM(spr, getColumIndex(spr, "FactOrderSeq"), xRow)
            If getColumIndex(spr, "JobCardWorking") > -1 Then z2351.JobCardWorking = getDataM(spr, getColumIndex(spr, "JobCardWorking"), xRow)
            If getColumIndex(spr, "JobCardWorkingSeq") > -1 Then z2351.JobCardWorkingSeq = getDataM(spr, getColumIndex(spr, "JobCardWorkingSeq"), xRow)
            If getColumIndex(spr, "JobCardType") > -1 Then z2351.JobCardType = getDataM(spr, getColumIndex(spr, "JobCardType"), xRow)
            If getColumIndex(spr, "CheckComplete") > -1 Then z2351.CheckComplete = getDataM(spr, getColumIndex(spr, "CheckComplete"), xRow)
            If getColumIndex(spr, "CheckQC") > -1 Then z2351.CheckQC = getDataM(spr, getColumIndex(spr, "CheckQC"), xRow)
            If getColumIndex(spr, "IsPosted") > -1 Then z2351.IsPosted = getDataM(spr, getColumIndex(spr, "IsPosted"), xRow)
            If getColumIndex(spr, "DatePosted") > -1 Then z2351.DatePosted = getDataM(spr, getColumIndex(spr, "DatePosted"), xRow)
            If getColumIndex(spr, "DateInsert") > -1 Then z2351.DateInsert = getDataM(spr, getColumIndex(spr, "DateInsert"), xRow)
            If getColumIndex(spr, "DateUpdate") > -1 Then z2351.DateUpdate = getDataM(spr, getColumIndex(spr, "DateUpdate"), xRow)
            If getColumIndex(spr, "InchargeInsert") > -1 Then z2351.InchargeInsert = getDataM(spr, getColumIndex(spr, "InchargeInsert"), xRow)
            If getColumIndex(spr, "InchargeUpdate") > -1 Then z2351.InchargeUpdate = getDataM(spr, getColumIndex(spr, "InchargeUpdate"), xRow)
            If getColumIndex(spr, "DateSync") > -1 Then z2351.DateSync = getDataM(spr, getColumIndex(spr, "DateSync"), xRow)
            If getColumIndex(spr, "CheckSync") > -1 Then z2351.CheckSync = getDataM(spr, getColumIndex(spr, "CheckSync"), xRow)
            If getColumIndex(spr, "CheckPL") > -1 Then z2351.CheckPL = getDataM(spr, getColumIndex(spr, "CheckPL"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z2351.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K2351_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K2351_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z2351 As T2351_AREA, Job As String, MATERIALINBOUNDNO As String, MATERIALINBOUNDSEQ As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K2351_MOVE = False

        Try
            If READ_PFK2351(MATERIALINBOUNDNO, MATERIALINBOUNDSEQ) = True Then
                z2351 = D2351
                K2351_MOVE = True
            Else
                z2351 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK2351")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "MATERIALINBOUNDNO" : z2351.MaterialInBoundNo = Children(i).Code
                                Case "MATERIALINBOUNDSEQ" : z2351.MaterialInBoundSeq = Children(i).Code
                                Case "DATEACCEPT" : z2351.DateAccept = Children(i).Code
                                Case "SESITE" : z2351.seSite = Children(i).Code
                                Case "CDSITE" : z2351.cdSite = Children(i).Code
                                Case "SEDEPARTMENT" : z2351.seDepartment = Children(i).Code
                                Case "CDDEPARTMENT" : z2351.cdDepartment = Children(i).Code
                                Case "SEFACTORY" : z2351.seFactory = Children(i).Code
                                Case "CDFACTORY" : z2351.cdFactory = Children(i).Code
                                Case "SESEASON" : z2351.seSeason = Children(i).Code
                                Case "CDSEASON" : z2351.cdSeason = Children(i).Code
                                Case "SEWAREHOUSEGROUP" : z2351.seWareHouseGroup = Children(i).Code
                                Case "CDWAREHOUSEGROUP" : z2351.cdWareHouseGroup = Children(i).Code
                                Case "SEWAREHOUSEPOSITION" : z2351.seWareHousePosition = Children(i).Code
                                Case "CDWAREHOUSEPOSITION" : z2351.cdWareHousePosition = Children(i).Code
                                Case "DATEINBOUNDMATERIAL" : z2351.DateInBoundMaterial = Children(i).Code
                                Case "CHECKINBOUNDMATERIAL" : z2351.CheckInBoundMaterial = Children(i).Code
                                Case "CHECKMATERIALTYPE" : z2351.CheckMaterialType = Children(i).Code
                                Case "CHECKMARKETTYPE" : z2351.CheckMarketType = Children(i).Code
                                Case "CUSTOMERCODE" : z2351.CustomerCode = Children(i).Code
                                Case "SUPPLIERCODE" : z2351.SupplierCode = Children(i).Code
                                Case "INCHARGEINBOUND" : z2351.InchargeInBound = Children(i).Code
                                Case "INVOICENO" : z2351.InvoiceNo = Children(i).Code
                                Case "CONTAINERNO" : z2351.ContainerNo = Children(i).Code
                                Case "MATERIALCODE" : z2351.MaterialCode = Children(i).Code
                                Case "COLORCODE" : z2351.ColorCode = Children(i).Code
                                Case "COLORNAME" : z2351.ColorName = Children(i).Code
                                Case "SIZENAME" : z2351.SizeName = Children(i).Code
                                Case "WIDTH" : z2351.Width = Children(i).Code
                                Case "SEUNITPRICE" : z2351.seUnitPrice = Children(i).Code
                                Case "CDUNITPRICE" : z2351.cdUnitPrice = Children(i).Code
                                Case "PRICEMATERIAL" : z2351.PriceMaterial = Children(i).Code
                                Case "DATEEXCHANGE" : z2351.DateExchange = Children(i).Code
                                Case "PRICEEXCHANGE" : z2351.PriceExchange = Children(i).Code
                                Case "PRICEEXCHANGEAP" : z2351.PriceExchangeAP = Children(i).Code
                                Case "PRICEMATERIALEX" : z2351.PriceMaterialEX = Children(i).Code
                                Case "PRICEMATERIALVND" : z2351.PriceMaterialVND = Children(i).Code
                                Case "SEUNITMATERIAL" : z2351.seUnitMaterial = Children(i).Code
                                Case "CDUNITMATERIAL" : z2351.cdUnitMaterial = Children(i).Code
                                Case "CDUNITMATERIALPL" : z2351.cdUnitMaterialPL = Children(i).Code
                                Case "QTYCONVERSION" : z2351.QtyConversion = Children(i).Code
                                Case "OPERATOR" : z2351.Operator = Children(i).Code
                                Case "CHECKCONVERSION" : z2351.CheckConversion = Children(i).Code
                                Case "DATECONVERSION" : z2351.DateConversion = Children(i).Code
                                Case "SEUNITMATERIALOLD" : z2351.seUnitMaterialOld = Children(i).Code
                                Case "CDUNITMATERIALOLD" : z2351.cdUnitMaterialOld = Children(i).Code
                                Case "SEUNITPACKING" : z2351.seUnitPacking = Children(i).Code
                                Case "CDUNITPACKING" : z2351.cdUnitPacking = Children(i).Code
                                Case "SETAX1" : z2351.seTax1 = Children(i).Code
                                Case "CDTAX1" : z2351.cdTax1 = Children(i).Code
                                Case "PERTAX1" : z2351.PerTax1 = Children(i).Code
                                Case "AMOUNTTAX1EX" : z2351.AmountTax1EX = Children(i).Code
                                Case "AMOUNTTAX1" : z2351.AmountTax1 = Children(i).Code
                                Case "SETAX2" : z2351.seTax2 = Children(i).Code
                                Case "CDTAX2" : z2351.cdTax2 = Children(i).Code
                                Case "PERTAX2" : z2351.PerTax2 = Children(i).Code
                                Case "AMOUNTTAX2EX" : z2351.AmountTax2EX = Children(i).Code
                                Case "AMOUNTTAX2" : z2351.AmountTax2 = Children(i).Code
                                Case "SETAX3" : z2351.seTax3 = Children(i).Code
                                Case "CDTAX3" : z2351.cdTax3 = Children(i).Code
                                Case "PERTAX3" : z2351.PerTax3 = Children(i).Code
                                Case "AMOUNTTAX3EX" : z2351.AmountTax3EX = Children(i).Code
                                Case "AMOUNTTAX3" : z2351.AmountTax3 = Children(i).Code
                                Case "AMOUNTTAXVND" : z2351.AmountTaxVND = Children(i).Code
                                Case "AMOUNTPURCHASINGEX" : z2351.AmountPurchasingEX = Children(i).Code
                                Case "AMOUNTPURCHASINGVND" : z2351.AmountPurchasingVND = Children(i).Code
                                Case "PACKINBOUND" : z2351.PackInBound = Children(i).Code
                                Case "QTYBASIC" : z2351.QtyBasic = Children(i).Code
                                Case "QTYINBOUND_OR" : z2351.QtyInBound_Or = Children(i).Code
                                Case "QTYPACKINGLIST" : z2351.QtyPackingList = Children(i).Code
                                Case "QTYALLOCATION" : z2351.QtyAllocation = Children(i).Code
                                Case "QTYINBOUND" : z2351.QtyInBound = Children(i).Code
                                Case "QTYINBOUNDPL" : z2351.QtyInBoundPL = Children(i).Code
                                Case "PACKOUTBOUND" : z2351.PackOutBound = Children(i).Code
                                Case "QTYOUTBOUND" : z2351.QtyOutBound = Children(i).Code
                                Case "QTYINBOUNDTRADING" : z2351.QtyInBoundTrading = Children(i).Code
                                Case "INCHARGETRADING" : z2351.InchargeTrading = Children(i).Code
                                Case "TRADINGDATE" : z2351.TradingDate = Children(i).Code
                                Case "TRADINGNO" : z2351.TradingNo = Children(i).Code
                                Case "TRADINGCODE" : z2351.TradingCode = Children(i).Code
                                Case "TRADINGGROUP" : z2351.TradingGroup = Children(i).Code
                                Case "PRICETRADING" : z2351.PriceTrading = Children(i).Code
                                Case "AMTTRADINGNET" : z2351.AMTTradingNet = Children(i).Code
                                Case "AMTTRADINGVAT" : z2351.AMTTradingVAT = Children(i).Code
                                Case "AMTTRADING" : z2351.AMTTrading = Children(i).Code
                                Case "AMOUNTNOVATEX" : z2351.AmountNoVATEX = Children(i).Code
                                Case "AMOUNTNOVATVND" : z2351.AmountNoVATVND = Children(i).Code
                                Case "AMOUNTTOTALEX" : z2351.AmountTotalEX = Children(i).Code
                                Case "AMOUNTTOTALVND" : z2351.AmountTotalVND = Children(i).Code
                                Case "AMOUNTINBOUNDEX" : z2351.AmountInBoundEX = Children(i).Code
                                Case "AMOUNTINBOUNDVND" : z2351.AmountInBoundVND = Children(i).Code
                                Case "AMOUNTEX" : z2351.AmountEX = Children(i).Code
                                Case "AMOUNTVND" : z2351.AmountVND = Children(i).Code
                                Case "FACTORDERNO" : z2351.FactOrderNo = Children(i).Code
                                Case "FACTORDERSEQ" : z2351.FactOrderSeq = Children(i).Code
                                Case "JOBCARDWORKING" : z2351.JobCardWorking = Children(i).Code
                                Case "JOBCARDWORKINGSEQ" : z2351.JobCardWorkingSeq = Children(i).Code
                                Case "JOBCARDTYPE" : z2351.JobCardType = Children(i).Code
                                Case "CHECKCOMPLETE" : z2351.CheckComplete = Children(i).Code
                                Case "CHECKQC" : z2351.CheckQC = Children(i).Code
                                Case "ISPOSTED" : z2351.IsPosted = Children(i).Code
                                Case "DATEPOSTED" : z2351.DatePosted = Children(i).Code
                                Case "DATEINSERT" : z2351.DateInsert = Children(i).Code
                                Case "DATEUPDATE" : z2351.DateUpdate = Children(i).Code
                                Case "INCHARGEINSERT" : z2351.InchargeInsert = Children(i).Code
                                Case "INCHARGEUPDATE" : z2351.InchargeUpdate = Children(i).Code
                                Case "DATESYNC" : z2351.DateSync = Children(i).Code
                                Case "CHECKSYNC" : z2351.CheckSync = Children(i).Code
                                Case "CHECKPL" : z2351.CheckPL = Children(i).Code
                                Case "REMARK" : z2351.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "MATERIALINBOUNDNO" : z2351.MaterialInBoundNo = Children(i).Data
                                Case "MATERIALINBOUNDSEQ" : z2351.MaterialInBoundSeq = Children(i).Data
                                Case "DATEACCEPT" : z2351.DateAccept = Children(i).Data
                                Case "SESITE" : z2351.seSite = Children(i).Data
                                Case "CDSITE" : z2351.cdSite = Children(i).Data
                                Case "SEDEPARTMENT" : z2351.seDepartment = Children(i).Data
                                Case "CDDEPARTMENT" : z2351.cdDepartment = Children(i).Data
                                Case "SEFACTORY" : z2351.seFactory = Children(i).Data
                                Case "CDFACTORY" : z2351.cdFactory = Children(i).Data
                                Case "SESEASON" : z2351.seSeason = Children(i).Data
                                Case "CDSEASON" : z2351.cdSeason = Children(i).Data
                                Case "SEWAREHOUSEGROUP" : z2351.seWareHouseGroup = Children(i).Data
                                Case "CDWAREHOUSEGROUP" : z2351.cdWareHouseGroup = Children(i).Data
                                Case "SEWAREHOUSEPOSITION" : z2351.seWareHousePosition = Children(i).Data
                                Case "CDWAREHOUSEPOSITION" : z2351.cdWareHousePosition = Children(i).Data
                                Case "DATEINBOUNDMATERIAL" : z2351.DateInBoundMaterial = Children(i).Data
                                Case "CHECKINBOUNDMATERIAL" : z2351.CheckInBoundMaterial = Children(i).Data
                                Case "CHECKMATERIALTYPE" : z2351.CheckMaterialType = Children(i).Data
                                Case "CHECKMARKETTYPE" : z2351.CheckMarketType = Children(i).Data
                                Case "CUSTOMERCODE" : z2351.CustomerCode = Children(i).Data
                                Case "SUPPLIERCODE" : z2351.SupplierCode = Children(i).Data
                                Case "INCHARGEINBOUND" : z2351.InchargeInBound = Children(i).Data
                                Case "INVOICENO" : z2351.InvoiceNo = Children(i).Data
                                Case "CONTAINERNO" : z2351.ContainerNo = Children(i).Data
                                Case "MATERIALCODE" : z2351.MaterialCode = Children(i).Data
                                Case "COLORCODE" : z2351.ColorCode = Children(i).Data
                                Case "COLORNAME" : z2351.ColorName = Children(i).Data
                                Case "SIZENAME" : z2351.SizeName = Children(i).Data
                                Case "WIDTH" : z2351.Width = Children(i).Data
                                Case "SEUNITPRICE" : z2351.seUnitPrice = Children(i).Data
                                Case "CDUNITPRICE" : z2351.cdUnitPrice = Children(i).Data
                                Case "PRICEMATERIAL" : z2351.PriceMaterial = Children(i).Data
                                Case "DATEEXCHANGE" : z2351.DateExchange = Children(i).Data
                                Case "PRICEEXCHANGE" : z2351.PriceExchange = Children(i).Data
                                Case "PRICEEXCHANGEAP" : z2351.PriceExchangeAP = Children(i).Data
                                Case "PRICEMATERIALEX" : z2351.PriceMaterialEX = Children(i).Data
                                Case "PRICEMATERIALVND" : z2351.PriceMaterialVND = Children(i).Data
                                Case "SEUNITMATERIAL" : z2351.seUnitMaterial = Children(i).Data
                                Case "CDUNITMATERIAL" : z2351.cdUnitMaterial = Children(i).Data
                                Case "CDUNITMATERIALPL" : z2351.cdUnitMaterialPL = Children(i).Data
                                Case "QTYCONVERSION" : z2351.QtyConversion = Children(i).Data
                                Case "OPERATOR" : z2351.Operator = Children(i).Data
                                Case "CHECKCONVERSION" : z2351.CheckConversion = Children(i).Data
                                Case "DATECONVERSION" : z2351.DateConversion = Children(i).Data
                                Case "SEUNITMATERIALOLD" : z2351.seUnitMaterialOld = Children(i).Data
                                Case "CDUNITMATERIALOLD" : z2351.cdUnitMaterialOld = Children(i).Data
                                Case "SEUNITPACKING" : z2351.seUnitPacking = Children(i).Data
                                Case "CDUNITPACKING" : z2351.cdUnitPacking = Children(i).Data
                                Case "SETAX1" : z2351.seTax1 = Children(i).Data
                                Case "CDTAX1" : z2351.cdTax1 = Children(i).Data
                                Case "PERTAX1" : z2351.PerTax1 = Children(i).Data
                                Case "AMOUNTTAX1EX" : z2351.AmountTax1EX = Children(i).Data
                                Case "AMOUNTTAX1" : z2351.AmountTax1 = Children(i).Data
                                Case "SETAX2" : z2351.seTax2 = Children(i).Data
                                Case "CDTAX2" : z2351.cdTax2 = Children(i).Data
                                Case "PERTAX2" : z2351.PerTax2 = Children(i).Data
                                Case "AMOUNTTAX2EX" : z2351.AmountTax2EX = Children(i).Data
                                Case "AMOUNTTAX2" : z2351.AmountTax2 = Children(i).Data
                                Case "SETAX3" : z2351.seTax3 = Children(i).Data
                                Case "CDTAX3" : z2351.cdTax3 = Children(i).Data
                                Case "PERTAX3" : z2351.PerTax3 = Children(i).Data
                                Case "AMOUNTTAX3EX" : z2351.AmountTax3EX = Children(i).Data
                                Case "AMOUNTTAX3" : z2351.AmountTax3 = Children(i).Data
                                Case "AMOUNTTAXVND" : z2351.AmountTaxVND = Children(i).Data
                                Case "AMOUNTPURCHASINGEX" : z2351.AmountPurchasingEX = Children(i).Data
                                Case "AMOUNTPURCHASINGVND" : z2351.AmountPurchasingVND = Children(i).Data
                                Case "PACKINBOUND" : z2351.PackInBound = Children(i).Data
                                Case "QTYBASIC" : z2351.QtyBasic = Children(i).Data
                                Case "QTYINBOUND_OR" : z2351.QtyInBound_Or = Children(i).Data
                                Case "QTYPACKINGLIST" : z2351.QtyPackingList = Children(i).Data
                                Case "QTYALLOCATION" : z2351.QtyAllocation = Children(i).Data
                                Case "QTYINBOUND" : z2351.QtyInBound = Children(i).Data
                                Case "QTYINBOUNDPL" : z2351.QtyInBoundPL = Children(i).Data
                                Case "PACKOUTBOUND" : z2351.PackOutBound = Children(i).Data
                                Case "QTYOUTBOUND" : z2351.QtyOutBound = Children(i).Data
                                Case "QTYINBOUNDTRADING" : z2351.QtyInBoundTrading = Children(i).Data
                                Case "INCHARGETRADING" : z2351.InchargeTrading = Children(i).Data
                                Case "TRADINGDATE" : z2351.TradingDate = Children(i).Data
                                Case "TRADINGNO" : z2351.TradingNo = Children(i).Data
                                Case "TRADINGCODE" : z2351.TradingCode = Children(i).Data
                                Case "TRADINGGROUP" : z2351.TradingGroup = Children(i).Data
                                Case "PRICETRADING" : z2351.PriceTrading = Children(i).Data
                                Case "AMTTRADINGNET" : z2351.AMTTradingNet = Children(i).Data
                                Case "AMTTRADINGVAT" : z2351.AMTTradingVAT = Children(i).Data
                                Case "AMTTRADING" : z2351.AMTTrading = Children(i).Data
                                Case "AMOUNTNOVATEX" : z2351.AmountNoVATEX = Children(i).Data
                                Case "AMOUNTNOVATVND" : z2351.AmountNoVATVND = Children(i).Data
                                Case "AMOUNTTOTALEX" : z2351.AmountTotalEX = Children(i).Data
                                Case "AMOUNTTOTALVND" : z2351.AmountTotalVND = Children(i).Data
                                Case "AMOUNTINBOUNDEX" : z2351.AmountInBoundEX = Children(i).Data
                                Case "AMOUNTINBOUNDVND" : z2351.AmountInBoundVND = Children(i).Data
                                Case "AMOUNTEX" : z2351.AmountEX = Children(i).Data
                                Case "AMOUNTVND" : z2351.AmountVND = Children(i).Data
                                Case "FACTORDERNO" : z2351.FactOrderNo = Children(i).Data
                                Case "FACTORDERSEQ" : z2351.FactOrderSeq = Children(i).Data
                                Case "JOBCARDWORKING" : z2351.JobCardWorking = Children(i).Data
                                Case "JOBCARDWORKINGSEQ" : z2351.JobCardWorkingSeq = Children(i).Data
                                Case "JOBCARDTYPE" : z2351.JobCardType = Children(i).Data
                                Case "CHECKCOMPLETE" : z2351.CheckComplete = Children(i).Data
                                Case "CHECKQC" : z2351.CheckQC = Children(i).Data
                                Case "ISPOSTED" : z2351.IsPosted = Children(i).Data
                                Case "DATEPOSTED" : z2351.DatePosted = Children(i).Data
                                Case "DATEINSERT" : z2351.DateInsert = Children(i).Data
                                Case "DATEUPDATE" : z2351.DateUpdate = Children(i).Data
                                Case "INCHARGEINSERT" : z2351.InchargeInsert = Children(i).Data
                                Case "INCHARGEUPDATE" : z2351.InchargeUpdate = Children(i).Data
                                Case "DATESYNC" : z2351.DateSync = Children(i).Data
                                Case "CHECKSYNC" : z2351.CheckSync = Children(i).Data
                                Case "CHECKPL" : z2351.CheckPL = Children(i).Data
                                Case "REMARK" : z2351.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K2351_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K2351_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z2351 As T2351_AREA, Job As String, CheckClear As Boolean, MATERIALINBOUNDNO As String, MATERIALINBOUNDSEQ As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K2351_MOVE = False

        Try
            If READ_PFK2351(MATERIALINBOUNDNO, MATERIALINBOUNDSEQ) = True Then
                z2351 = D2351
                K2351_MOVE = True
            Else
                If CheckClear = True Then z2351 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK2351")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "MATERIALINBOUNDNO" : z2351.MaterialInBoundNo = Children(i).Code
                                Case "MATERIALINBOUNDSEQ" : z2351.MaterialInBoundSeq = Children(i).Code
                                Case "DATEACCEPT" : z2351.DateAccept = Children(i).Code
                                Case "SESITE" : z2351.seSite = Children(i).Code
                                Case "CDSITE" : z2351.cdSite = Children(i).Code
                                Case "SEDEPARTMENT" : z2351.seDepartment = Children(i).Code
                                Case "CDDEPARTMENT" : z2351.cdDepartment = Children(i).Code
                                Case "SEFACTORY" : z2351.seFactory = Children(i).Code
                                Case "CDFACTORY" : z2351.cdFactory = Children(i).Code
                                Case "SESEASON" : z2351.seSeason = Children(i).Code
                                Case "CDSEASON" : z2351.cdSeason = Children(i).Code
                                Case "SEWAREHOUSEGROUP" : z2351.seWareHouseGroup = Children(i).Code
                                Case "CDWAREHOUSEGROUP" : z2351.cdWareHouseGroup = Children(i).Code
                                Case "SEWAREHOUSEPOSITION" : z2351.seWareHousePosition = Children(i).Code
                                Case "CDWAREHOUSEPOSITION" : z2351.cdWareHousePosition = Children(i).Code
                                Case "DATEINBOUNDMATERIAL" : z2351.DateInBoundMaterial = Children(i).Code
                                Case "CHECKINBOUNDMATERIAL" : z2351.CheckInBoundMaterial = Children(i).Code
                                Case "CHECKMATERIALTYPE" : z2351.CheckMaterialType = Children(i).Code
                                Case "CHECKMARKETTYPE" : z2351.CheckMarketType = Children(i).Code
                                Case "CUSTOMERCODE" : z2351.CustomerCode = Children(i).Code
                                Case "SUPPLIERCODE" : z2351.SupplierCode = Children(i).Code
                                Case "INCHARGEINBOUND" : z2351.InchargeInBound = Children(i).Code
                                Case "INVOICENO" : z2351.InvoiceNo = Children(i).Code
                                Case "CONTAINERNO" : z2351.ContainerNo = Children(i).Code
                                Case "MATERIALCODE" : z2351.MaterialCode = Children(i).Code
                                Case "COLORCODE" : z2351.ColorCode = Children(i).Code
                                Case "COLORNAME" : z2351.ColorName = Children(i).Code
                                Case "SIZENAME" : z2351.SizeName = Children(i).Code
                                Case "WIDTH" : z2351.Width = Children(i).Code
                                Case "SEUNITPRICE" : z2351.seUnitPrice = Children(i).Code
                                Case "CDUNITPRICE" : z2351.cdUnitPrice = Children(i).Code
                                Case "PRICEMATERIAL" : z2351.PriceMaterial = Children(i).Code
                                Case "DATEEXCHANGE" : z2351.DateExchange = Children(i).Code
                                Case "PRICEEXCHANGE" : z2351.PriceExchange = Children(i).Code
                                Case "PRICEEXCHANGEAP" : z2351.PriceExchangeAP = Children(i).Code
                                Case "PRICEMATERIALEX" : z2351.PriceMaterialEX = Children(i).Code
                                Case "PRICEMATERIALVND" : z2351.PriceMaterialVND = Children(i).Code
                                Case "SEUNITMATERIAL" : z2351.seUnitMaterial = Children(i).Code
                                Case "CDUNITMATERIAL" : z2351.cdUnitMaterial = Children(i).Code
                                Case "CDUNITMATERIALPL" : z2351.cdUnitMaterialPL = Children(i).Code
                                Case "QTYCONVERSION" : z2351.QtyConversion = Children(i).Code
                                Case "OPERATOR" : z2351.Operator = Children(i).Code
                                Case "CHECKCONVERSION" : z2351.CheckConversion = Children(i).Code
                                Case "DATECONVERSION" : z2351.DateConversion = Children(i).Code
                                Case "SEUNITMATERIALOLD" : z2351.seUnitMaterialOld = Children(i).Code
                                Case "CDUNITMATERIALOLD" : z2351.cdUnitMaterialOld = Children(i).Code
                                Case "SEUNITPACKING" : z2351.seUnitPacking = Children(i).Code
                                Case "CDUNITPACKING" : z2351.cdUnitPacking = Children(i).Code
                                Case "SETAX1" : z2351.seTax1 = Children(i).Code
                                Case "CDTAX1" : z2351.cdTax1 = Children(i).Code
                                Case "PERTAX1" : z2351.PerTax1 = Children(i).Code
                                Case "AMOUNTTAX1EX" : z2351.AmountTax1EX = Children(i).Code
                                Case "AMOUNTTAX1" : z2351.AmountTax1 = Children(i).Code
                                Case "SETAX2" : z2351.seTax2 = Children(i).Code
                                Case "CDTAX2" : z2351.cdTax2 = Children(i).Code
                                Case "PERTAX2" : z2351.PerTax2 = Children(i).Code
                                Case "AMOUNTTAX2EX" : z2351.AmountTax2EX = Children(i).Code
                                Case "AMOUNTTAX2" : z2351.AmountTax2 = Children(i).Code
                                Case "SETAX3" : z2351.seTax3 = Children(i).Code
                                Case "CDTAX3" : z2351.cdTax3 = Children(i).Code
                                Case "PERTAX3" : z2351.PerTax3 = Children(i).Code
                                Case "AMOUNTTAX3EX" : z2351.AmountTax3EX = Children(i).Code
                                Case "AMOUNTTAX3" : z2351.AmountTax3 = Children(i).Code
                                Case "AMOUNTTAXVND" : z2351.AmountTaxVND = Children(i).Code
                                Case "AMOUNTPURCHASINGEX" : z2351.AmountPurchasingEX = Children(i).Code
                                Case "AMOUNTPURCHASINGVND" : z2351.AmountPurchasingVND = Children(i).Code
                                Case "PACKINBOUND" : z2351.PackInBound = Children(i).Code
                                Case "QTYBASIC" : z2351.QtyBasic = Children(i).Code
                                Case "QTYINBOUND_OR" : z2351.QtyInBound_Or = Children(i).Code
                                Case "QTYPACKINGLIST" : z2351.QtyPackingList = Children(i).Code
                                Case "QTYALLOCATION" : z2351.QtyAllocation = Children(i).Code
                                Case "QTYINBOUND" : z2351.QtyInBound = Children(i).Code
                                Case "QTYINBOUNDPL" : z2351.QtyInBoundPL = Children(i).Code
                                Case "PACKOUTBOUND" : z2351.PackOutBound = Children(i).Code
                                Case "QTYOUTBOUND" : z2351.QtyOutBound = Children(i).Code
                                Case "QTYINBOUNDTRADING" : z2351.QtyInBoundTrading = Children(i).Code
                                Case "INCHARGETRADING" : z2351.InchargeTrading = Children(i).Code
                                Case "TRADINGDATE" : z2351.TradingDate = Children(i).Code
                                Case "TRADINGNO" : z2351.TradingNo = Children(i).Code
                                Case "TRADINGCODE" : z2351.TradingCode = Children(i).Code
                                Case "TRADINGGROUP" : z2351.TradingGroup = Children(i).Code
                                Case "PRICETRADING" : z2351.PriceTrading = Children(i).Code
                                Case "AMTTRADINGNET" : z2351.AMTTradingNet = Children(i).Code
                                Case "AMTTRADINGVAT" : z2351.AMTTradingVAT = Children(i).Code
                                Case "AMTTRADING" : z2351.AMTTrading = Children(i).Code
                                Case "AMOUNTNOVATEX" : z2351.AmountNoVATEX = Children(i).Code
                                Case "AMOUNTNOVATVND" : z2351.AmountNoVATVND = Children(i).Code
                                Case "AMOUNTTOTALEX" : z2351.AmountTotalEX = Children(i).Code
                                Case "AMOUNTTOTALVND" : z2351.AmountTotalVND = Children(i).Code
                                Case "AMOUNTINBOUNDEX" : z2351.AmountInBoundEX = Children(i).Code
                                Case "AMOUNTINBOUNDVND" : z2351.AmountInBoundVND = Children(i).Code
                                Case "AMOUNTEX" : z2351.AmountEX = Children(i).Code
                                Case "AMOUNTVND" : z2351.AmountVND = Children(i).Code
                                Case "FACTORDERNO" : z2351.FactOrderNo = Children(i).Code
                                Case "FACTORDERSEQ" : z2351.FactOrderSeq = Children(i).Code
                                Case "JOBCARDWORKING" : z2351.JobCardWorking = Children(i).Code
                                Case "JOBCARDWORKINGSEQ" : z2351.JobCardWorkingSeq = Children(i).Code
                                Case "JOBCARDTYPE" : z2351.JobCardType = Children(i).Code
                                Case "CHECKCOMPLETE" : z2351.CheckComplete = Children(i).Code
                                Case "CHECKQC" : z2351.CheckQC = Children(i).Code
                                Case "ISPOSTED" : z2351.IsPosted = Children(i).Code
                                Case "DATEPOSTED" : z2351.DatePosted = Children(i).Code
                                Case "DATEINSERT" : z2351.DateInsert = Children(i).Code
                                Case "DATEUPDATE" : z2351.DateUpdate = Children(i).Code
                                Case "INCHARGEINSERT" : z2351.InchargeInsert = Children(i).Code
                                Case "INCHARGEUPDATE" : z2351.InchargeUpdate = Children(i).Code
                                Case "DATESYNC" : z2351.DateSync = Children(i).Code
                                Case "CHECKSYNC" : z2351.CheckSync = Children(i).Code
                                Case "CHECKPL" : z2351.CheckPL = Children(i).Code
                                Case "REMARK" : z2351.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "MATERIALINBOUNDNO" : z2351.MaterialInBoundNo = Children(i).Data
                                Case "MATERIALINBOUNDSEQ" : z2351.MaterialInBoundSeq = Children(i).Data
                                Case "DATEACCEPT" : z2351.DateAccept = Children(i).Data
                                Case "SESITE" : z2351.seSite = Children(i).Data
                                Case "CDSITE" : z2351.cdSite = Children(i).Data
                                Case "SEDEPARTMENT" : z2351.seDepartment = Children(i).Data
                                Case "CDDEPARTMENT" : z2351.cdDepartment = Children(i).Data
                                Case "SEFACTORY" : z2351.seFactory = Children(i).Data
                                Case "CDFACTORY" : z2351.cdFactory = Children(i).Data
                                Case "SESEASON" : z2351.seSeason = Children(i).Data
                                Case "CDSEASON" : z2351.cdSeason = Children(i).Data
                                Case "SEWAREHOUSEGROUP" : z2351.seWareHouseGroup = Children(i).Data
                                Case "CDWAREHOUSEGROUP" : z2351.cdWareHouseGroup = Children(i).Data
                                Case "SEWAREHOUSEPOSITION" : z2351.seWareHousePosition = Children(i).Data
                                Case "CDWAREHOUSEPOSITION" : z2351.cdWareHousePosition = Children(i).Data
                                Case "DATEINBOUNDMATERIAL" : z2351.DateInBoundMaterial = Children(i).Data
                                Case "CHECKINBOUNDMATERIAL" : z2351.CheckInBoundMaterial = Children(i).Data
                                Case "CHECKMATERIALTYPE" : z2351.CheckMaterialType = Children(i).Data
                                Case "CHECKMARKETTYPE" : z2351.CheckMarketType = Children(i).Data
                                Case "CUSTOMERCODE" : z2351.CustomerCode = Children(i).Data
                                Case "SUPPLIERCODE" : z2351.SupplierCode = Children(i).Data
                                Case "INCHARGEINBOUND" : z2351.InchargeInBound = Children(i).Data
                                Case "INVOICENO" : z2351.InvoiceNo = Children(i).Data
                                Case "CONTAINERNO" : z2351.ContainerNo = Children(i).Data
                                Case "MATERIALCODE" : z2351.MaterialCode = Children(i).Data
                                Case "COLORCODE" : z2351.ColorCode = Children(i).Data
                                Case "COLORNAME" : z2351.ColorName = Children(i).Data
                                Case "SIZENAME" : z2351.SizeName = Children(i).Data
                                Case "WIDTH" : z2351.Width = Children(i).Data
                                Case "SEUNITPRICE" : z2351.seUnitPrice = Children(i).Data
                                Case "CDUNITPRICE" : z2351.cdUnitPrice = Children(i).Data
                                Case "PRICEMATERIAL" : z2351.PriceMaterial = Children(i).Data
                                Case "DATEEXCHANGE" : z2351.DateExchange = Children(i).Data
                                Case "PRICEEXCHANGE" : z2351.PriceExchange = Children(i).Data
                                Case "PRICEEXCHANGEAP" : z2351.PriceExchangeAP = Children(i).Data
                                Case "PRICEMATERIALEX" : z2351.PriceMaterialEX = Children(i).Data
                                Case "PRICEMATERIALVND" : z2351.PriceMaterialVND = Children(i).Data
                                Case "SEUNITMATERIAL" : z2351.seUnitMaterial = Children(i).Data
                                Case "CDUNITMATERIAL" : z2351.cdUnitMaterial = Children(i).Data
                                Case "CDUNITMATERIALPL" : z2351.cdUnitMaterialPL = Children(i).Data
                                Case "QTYCONVERSION" : z2351.QtyConversion = Children(i).Data
                                Case "OPERATOR" : z2351.Operator = Children(i).Data
                                Case "CHECKCONVERSION" : z2351.CheckConversion = Children(i).Data
                                Case "DATECONVERSION" : z2351.DateConversion = Children(i).Data
                                Case "SEUNITMATERIALOLD" : z2351.seUnitMaterialOld = Children(i).Data
                                Case "CDUNITMATERIALOLD" : z2351.cdUnitMaterialOld = Children(i).Data
                                Case "SEUNITPACKING" : z2351.seUnitPacking = Children(i).Data
                                Case "CDUNITPACKING" : z2351.cdUnitPacking = Children(i).Data
                                Case "SETAX1" : z2351.seTax1 = Children(i).Data
                                Case "CDTAX1" : z2351.cdTax1 = Children(i).Data
                                Case "PERTAX1" : z2351.PerTax1 = Children(i).Data
                                Case "AMOUNTTAX1EX" : z2351.AmountTax1EX = Children(i).Data
                                Case "AMOUNTTAX1" : z2351.AmountTax1 = Children(i).Data
                                Case "SETAX2" : z2351.seTax2 = Children(i).Data
                                Case "CDTAX2" : z2351.cdTax2 = Children(i).Data
                                Case "PERTAX2" : z2351.PerTax2 = Children(i).Data
                                Case "AMOUNTTAX2EX" : z2351.AmountTax2EX = Children(i).Data
                                Case "AMOUNTTAX2" : z2351.AmountTax2 = Children(i).Data
                                Case "SETAX3" : z2351.seTax3 = Children(i).Data
                                Case "CDTAX3" : z2351.cdTax3 = Children(i).Data
                                Case "PERTAX3" : z2351.PerTax3 = Children(i).Data
                                Case "AMOUNTTAX3EX" : z2351.AmountTax3EX = Children(i).Data
                                Case "AMOUNTTAX3" : z2351.AmountTax3 = Children(i).Data
                                Case "AMOUNTTAXVND" : z2351.AmountTaxVND = Children(i).Data
                                Case "AMOUNTPURCHASINGEX" : z2351.AmountPurchasingEX = Children(i).Data
                                Case "AMOUNTPURCHASINGVND" : z2351.AmountPurchasingVND = Children(i).Data
                                Case "PACKINBOUND" : z2351.PackInBound = Children(i).Data
                                Case "QTYBASIC" : z2351.QtyBasic = Children(i).Data
                                Case "QTYINBOUND_OR" : z2351.QtyInBound_Or = Children(i).Data
                                Case "QTYPACKINGLIST" : z2351.QtyPackingList = Children(i).Data
                                Case "QTYALLOCATION" : z2351.QtyAllocation = Children(i).Data
                                Case "QTYINBOUND" : z2351.QtyInBound = Children(i).Data
                                Case "QTYINBOUNDPL" : z2351.QtyInBoundPL = Children(i).Data
                                Case "PACKOUTBOUND" : z2351.PackOutBound = Children(i).Data
                                Case "QTYOUTBOUND" : z2351.QtyOutBound = Children(i).Data
                                Case "QTYINBOUNDTRADING" : z2351.QtyInBoundTrading = Children(i).Data
                                Case "INCHARGETRADING" : z2351.InchargeTrading = Children(i).Data
                                Case "TRADINGDATE" : z2351.TradingDate = Children(i).Data
                                Case "TRADINGNO" : z2351.TradingNo = Children(i).Data
                                Case "TRADINGCODE" : z2351.TradingCode = Children(i).Data
                                Case "TRADINGGROUP" : z2351.TradingGroup = Children(i).Data
                                Case "PRICETRADING" : z2351.PriceTrading = Children(i).Data
                                Case "AMTTRADINGNET" : z2351.AMTTradingNet = Children(i).Data
                                Case "AMTTRADINGVAT" : z2351.AMTTradingVAT = Children(i).Data
                                Case "AMTTRADING" : z2351.AMTTrading = Children(i).Data
                                Case "AMOUNTNOVATEX" : z2351.AmountNoVATEX = Children(i).Data
                                Case "AMOUNTNOVATVND" : z2351.AmountNoVATVND = Children(i).Data
                                Case "AMOUNTTOTALEX" : z2351.AmountTotalEX = Children(i).Data
                                Case "AMOUNTTOTALVND" : z2351.AmountTotalVND = Children(i).Data
                                Case "AMOUNTINBOUNDEX" : z2351.AmountInBoundEX = Children(i).Data
                                Case "AMOUNTINBOUNDVND" : z2351.AmountInBoundVND = Children(i).Data
                                Case "AMOUNTEX" : z2351.AmountEX = Children(i).Data
                                Case "AMOUNTVND" : z2351.AmountVND = Children(i).Data
                                Case "FACTORDERNO" : z2351.FactOrderNo = Children(i).Data
                                Case "FACTORDERSEQ" : z2351.FactOrderSeq = Children(i).Data
                                Case "JOBCARDWORKING" : z2351.JobCardWorking = Children(i).Data
                                Case "JOBCARDWORKINGSEQ" : z2351.JobCardWorkingSeq = Children(i).Data
                                Case "JOBCARDTYPE" : z2351.JobCardType = Children(i).Data
                                Case "CHECKCOMPLETE" : z2351.CheckComplete = Children(i).Data
                                Case "CHECKQC" : z2351.CheckQC = Children(i).Data
                                Case "ISPOSTED" : z2351.IsPosted = Children(i).Data
                                Case "DATEPOSTED" : z2351.DatePosted = Children(i).Data
                                Case "DATEINSERT" : z2351.DateInsert = Children(i).Data
                                Case "DATEUPDATE" : z2351.DateUpdate = Children(i).Data
                                Case "INCHARGEINSERT" : z2351.InchargeInsert = Children(i).Data
                                Case "INCHARGEUPDATE" : z2351.InchargeUpdate = Children(i).Data
                                Case "DATESYNC" : z2351.DateSync = Children(i).Data
                                Case "CHECKSYNC" : z2351.CheckSync = Children(i).Data
                                Case "CHECKPL" : z2351.CheckPL = Children(i).Data
                                Case "REMARK" : z2351.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K2351_MOVE", vbCritical)
        End Try
    End Function

End Module
