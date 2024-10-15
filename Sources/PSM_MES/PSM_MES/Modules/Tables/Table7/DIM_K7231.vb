'=========================================================================================================================================================
'   TABLE : (PFK7231)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7231

    Structure T7231_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public MaterialCode As String  '			char(6)		*
        Public MaterialName As String  '			nvarchar(500)
        Public MaterialPName As String  '			nvarchar(500)
        Public MaterialSimple As String  '			nvarchar(500)
        Public MaterialColor As String  '			nvarchar(500)
        Public seImportGroup As String  '			char(3)
        Public cdImportGroup As String  '			char(3)
        Public ImportCode As String  '			nvarchar(50)
        Public ImportName As String  '			nvarchar(500)

        Public ImportCode1 As String  '			nvarchar(50)
        Public ImportName1 As String  '			nvarchar(500)
        Public AccountCode As String  '			nvarchar(50)
        Public AccountName As String  '			nvarchar(50)
        Public OtherCode1 As String  '			nvarchar(50)
        Public OtherCode2 As String  '			nvarchar(50)
        Public DevelopmentCode As String  '			nvarchar(50)
        Public DevelopmentName As String  '			nvarchar(50)
        Public MaterialForeign1 As String  '			nvarchar(100)
        Public MaterialForeign2 As String  '			nvarchar(100)
        Public Width As String  '			nvarchar(20)
        Public Height As String  '			nvarchar(20)
        Public SizeName As String  '			nvarchar(100)
        Public CheckPrint As String  '			char(1)
        Public CheckSP As String  '			char(1)
        Public seSpecial As String  '			char(3)
        Public cdSpecial As String  '			char(3)
        Public SizeRangeTool As String  '			char(6)
        Public CheckKindMaterial As String  '			char(1)
        Public CheckMarketType As String  '			char(1)
        Public seUnitPrice As String  '			char(3)
        Public cdUnitPrice As String  '			char(3)
        Public DateExchangePrice As String  '			char(8)
        Public ExchangePrice As Double  '			decimal
        Public PriceUSD As Double  '			decimal
        Public PriceVND As Double  '			decimal
        Public seDepartment As String  '			char(3)
        Public cdDepartment As String  '			char(3)
        Public seLargeGroupMaterial As String  '			char(3)
        Public cdLargeGroupMaterial As String  '			char(3)
        Public seSemiGroupMaterial As String  '			char(3)
        Public cdSemiGroupMaterial As String  '			char(3)
        Public seDetailGroupMaterial As String  '			char(3)
        Public cdDetailGroupMaterial As String  '			char(3)
        Public seSpecGroup1 As String  '			char(3)
        Public cdSpecGroup1 As String  '			char(3)
        Public seSpecGroup2 As String  '			char(3)
        Public cdSpecGroup2 As String  '			char(3)
        Public seSpecGroup3 As String  '			char(3)
        Public cdSpecGroup3 As String  '			char(3)
        Public seSpecGroup4 As String  '			char(3)
        Public cdSpecGroup4 As String  '			char(3)
        Public seSpecGroup5 As String  '			char(3)
        Public cdSpecGroup5 As String  '			char(3)
        Public seUnitMaterial As String  '			char(3)
        Public cdUnitMaterial As String  '			char(3)
        Public seUnitPacking As String  '			char(3)
        Public cdUnitPacking As String  '			char(3)
        Public seTax As String  '			char(3)
        Public cdTax As String  '			char(3)
        Public PerTaxImport As Double  '			decimal
        Public PerTaxVAT As Double  '			decimal
        Public QtyBasic As Double  '			decimal
        Public QtyOptimum As Double  '			decimal
        Public DayOptimum As Double  '			decimal
        Public DayEstimate As Double  '			decimal
        Public PriceMaterial As Double  '			decimal
        Public QtyMOQ As Double  '			decimal
        Public MaxInventory As Double  '			decimal
        Public MinInventory As Double  '			decimal
        Public ReOrderQty As Double  '			decimal
        Public CheckDevRnD As String  '			char(1)
        Public StatusMaterial As String  '			char(1)
        Public BOMType As String  '			char(1)
        Public ApplyType As String  '			char(1)
        Public DateStart As String  '			char(8)
        Public DateOptimum As String  '			char(8)
        Public DateEstimate As String  '			char(8)
        Public DateInBound As String  '			char(8)
        Public DateOutBound As String  '			char(8)
        Public SupplyName As String  '			nvarchar(100)
        Public SupplyCode As String  '			char(6)
        Public SalesCode As String  '			char(6)
        Public Check1 As String  '			nvarchar(20)
        Public Check2 As String  '			nvarchar(20)
        Public Check3 As String  '			nvarchar(20)
        Public Check4 As String  '			nvarchar(20)
        Public Check5 As String  '			nvarchar(20)
        Public Check6 As String  '			nvarchar(10)
        Public Check7 As String  '			nvarchar(10)
        Public Check8 As String  '			nvarchar(10)
        Public Check9 As String  '			nvarchar(10)
        Public Check10 As String  '			nvarchar(10)
        Public CheckName1 As String  '			nvarchar(20)
        Public CheckName2 As String  '			nvarchar(20)
        Public CheckName3 As String  '			nvarchar(20)
        Public CheckName4 As String  '			nvarchar(20)
        Public CheckName5 As String  '			nvarchar(20)
        Public CheckName6 As String  '			nvarchar(20)
        Public CheckName7 As String  '			nvarchar(20)
        Public CheckName8 As String  '			nvarchar(20)
        Public CheckName9 As String  '			nvarchar(20)
        Public CheckName10 As String  '			nvarchar(20)
        Public ACodeMaterial As String  '			nvarchar(20)
        Public ACodeTax1 As String  '			nvarchar(20)
        Public ACodeTax2 As String  '			nvarchar(20)
        Public ACodeTax3 As String  '			nvarchar(20)
        Public ACodeSales As String  '			nvarchar(20)
        Public ACodeIntSales As String  '			nvarchar(20)
        Public ACodeCOGS As String  '			nvarchar(20)
        Public ACodeReturn As String  '			nvarchar(20)
        Public ACodeDiscount As String  '			nvarchar(20)
        Public ACodeWIP As String  '			nvarchar(20)
        Public CheckInventory As String  '			char(1)
        Public CheckPosition As String  '			char(1)
        Public CheckLotNo As String  '			char(1)
        Public CheckPrice As String  '			char(1)
        Public seTax1 As String  '			char(3)
        Public cdTax1 As String  '			char(3)
        Public PerTax1 As Double  '			decimal
        Public seTax2 As String  '			char(3)
        Public cdTax2 As String  '			char(3)
        Public PerTax2 As Double  '			decimal
        Public seTax3 As String  '			char(3)
        Public cdTax3 As String  '			char(3)
        Public PerTax3 As Double  '			decimal
        Public seTaxVAT As String  '			char(3)
        Public cdTaxVAT As String  '			char(3)
        Public seTaxImport As String  '			char(3)
        Public cdTaxImport As String  '			char(3)
        Public seTaxExport As String  '			char(3)
        Public cdTaxExport As String  '			char(3)
        Public seTaxSpecial As String  '			char(3)
        Public cdTaxSpecial As String  '			char(3)
        Public seAccMaterial As String  '			char(3)
        Public cdAccMaterial As String  '			char(3)
        Public seAccSales As String  '			char(3)
        Public cdAccSales As String  '			char(3)
        Public seAccIntSales As String  '			char(3)
        Public cdAccIntSales As String  '			char(3)
        Public seAccCOGS As String  '			char(3)
        Public cdAccCOGS As String  '			char(3)
        Public seAccReturn As String  '			char(3)
        Public cdAccReturn As String  '			char(3)
        Public seAccDiscount As String  '			char(3)
        Public cdAccDiscount As String  '			char(3)
        Public seAccWIP As String  '			char(3)
        Public cdAccWIP As String  '			char(3)
        Public DateInsert As String  '			char(8)
        Public DateUpdate As String  '			char(8)
        Public InchargeInsert As String  '			char(8)
        Public InchargeUpdate As String  '			char(8)
        Public InchargeComplete As String  '			char(8)
        Public InchargeCancel As String  '			char(8)
        Public InchargeApproved As String  '			char(8)
        Public InchargePending1 As String  '			char(8)
        Public InchargePending2 As String  '			char(8)
        Public CheckUse As String  '			char(1)
        Public DateActive As String  '			char(8)
        Public DateDeactive As String  '			char(8)
        Public CheckActive As String  '			char(1)
        Public DateComplete As String  '			char(8)
        Public DateApproved As String  '			char(8)
        Public DateCancel As String  '			char(8)
        Public DatePending1 As String  '			char(8)
        Public DatePending2 As String  '			char(8)
        Public CheckSync As String  '			char(1)
        Public MaterialFullName As String  '			nvarchar(500)
        Public MaterialOldName As String  '			nvarchar(200)
        Public Remark As String  '			nvarchar(500)
        '=========================================================================================================================================================
    End Structure

    Public D7231 As T7231_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK7231(MATERIALCODE As String) As Boolean
        READ_PFK7231 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7231 "
            SQL = SQL & " WHERE K7231_MaterialCode		 = '" & MaterialCode & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7231_CLEAR() : GoTo SKIP_READ_PFK7231

            Call K7231_MOVE(rd)
            READ_PFK7231 = True

SKIP_READ_PFK7231:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7231", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK7231(MATERIALCODE As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7231 "
            SQL = SQL & " WHERE K7231_MaterialCode		 = '" & MaterialCode & "' "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK7231", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK7231(z7231 As T7231_AREA) As Boolean
        WRITE_PFK7231 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z7231)

            SQL = " INSERT INTO PFK7231 "
            SQL = SQL & " ( "
            SQL = SQL & " K7231_MaterialCode,"
            SQL = SQL & " K7231_MaterialName,"
            SQL = SQL & " K7231_MaterialPName,"
            SQL = SQL & " K7231_MaterialSimple,"
            SQL = SQL & " K7231_MaterialColor,"
            SQL = SQL & " K7231_seImportGroup,"
            SQL = SQL & " K7231_cdImportGroup,"
            SQL = SQL & " K7231_ImportCode,"
            SQL = SQL & " K7231_ImportName,"
            SQL = SQL & " K7231_ImportCode1,"
            SQL = SQL & " K7231_ImportName1,"
            SQL = SQL & " K7231_AccountCode,"
            SQL = SQL & " K7231_AccountName,"
            SQL = SQL & " K7231_OtherCode1,"
            SQL = SQL & " K7231_OtherCode2,"
            SQL = SQL & " K7231_DevelopmentCode,"
            SQL = SQL & " K7231_DevelopmentName,"
            SQL = SQL & " K7231_MaterialForeign1,"
            SQL = SQL & " K7231_MaterialForeign2,"
            SQL = SQL & " K7231_Width,"
            SQL = SQL & " K7231_Height,"
            SQL = SQL & " K7231_SizeName,"
            SQL = SQL & " K7231_CheckPrint,"
            SQL = SQL & " K7231_CheckSP,"
            SQL = SQL & " K7231_seSpecial,"
            SQL = SQL & " K7231_cdSpecial,"
            SQL = SQL & " K7231_SizeRangeTool,"
            SQL = SQL & " K7231_CheckKindMaterial,"
            SQL = SQL & " K7231_CheckMarketType,"
            SQL = SQL & " K7231_seUnitPrice,"
            SQL = SQL & " K7231_cdUnitPrice,"
            SQL = SQL & " K7231_DateExchangePrice,"
            SQL = SQL & " K7231_ExchangePrice,"
            SQL = SQL & " K7231_PriceUSD,"
            SQL = SQL & " K7231_PriceVND,"
            SQL = SQL & " K7231_seDepartment,"
            SQL = SQL & " K7231_cdDepartment,"
            SQL = SQL & " K7231_seLargeGroupMaterial,"
            SQL = SQL & " K7231_cdLargeGroupMaterial,"
            SQL = SQL & " K7231_seSemiGroupMaterial,"
            SQL = SQL & " K7231_cdSemiGroupMaterial,"
            SQL = SQL & " K7231_seDetailGroupMaterial,"
            SQL = SQL & " K7231_cdDetailGroupMaterial,"
            SQL = SQL & " K7231_seSpecGroup1,"
            SQL = SQL & " K7231_cdSpecGroup1,"
            SQL = SQL & " K7231_seSpecGroup2,"
            SQL = SQL & " K7231_cdSpecGroup2,"
            SQL = SQL & " K7231_seSpecGroup3,"
            SQL = SQL & " K7231_cdSpecGroup3,"
            SQL = SQL & " K7231_seSpecGroup4,"
            SQL = SQL & " K7231_cdSpecGroup4,"
            SQL = SQL & " K7231_seSpecGroup5,"
            SQL = SQL & " K7231_cdSpecGroup5,"
            SQL = SQL & " K7231_seUnitMaterial,"
            SQL = SQL & " K7231_cdUnitMaterial,"
            SQL = SQL & " K7231_seUnitPacking,"
            SQL = SQL & " K7231_cdUnitPacking,"
            SQL = SQL & " K7231_seTax,"
            SQL = SQL & " K7231_cdTax,"
            SQL = SQL & " K7231_PerTaxImport,"
            SQL = SQL & " K7231_PerTaxVAT,"
            SQL = SQL & " K7231_QtyBasic,"
            SQL = SQL & " K7231_QtyOptimum,"
            SQL = SQL & " K7231_DayOptimum,"
            SQL = SQL & " K7231_DayEstimate,"
            SQL = SQL & " K7231_PriceMaterial,"
            SQL = SQL & " K7231_QtyMOQ,"
            SQL = SQL & " K7231_MaxInventory,"
            SQL = SQL & " K7231_MinInventory,"
            SQL = SQL & " K7231_ReOrderQty,"
            SQL = SQL & " K7231_CheckDevRnD,"
            SQL = SQL & " K7231_StatusMaterial,"
            SQL = SQL & " K7231_BOMType,"
            SQL = SQL & " K7231_ApplyType,"
            SQL = SQL & " K7231_DateStart,"
            SQL = SQL & " K7231_DateOptimum,"
            SQL = SQL & " K7231_DateEstimate,"
            SQL = SQL & " K7231_DateInBound,"
            SQL = SQL & " K7231_DateOutBound,"
            SQL = SQL & " K7231_SupplyName,"
            SQL = SQL & " K7231_SupplyCode,"
            SQL = SQL & " K7231_SalesCode,"
            SQL = SQL & " K7231_Check1,"
            SQL = SQL & " K7231_Check2,"
            SQL = SQL & " K7231_Check3,"
            SQL = SQL & " K7231_Check4,"
            SQL = SQL & " K7231_Check5,"
            SQL = SQL & " K7231_Check6,"
            SQL = SQL & " K7231_Check7,"
            SQL = SQL & " K7231_Check8,"
            SQL = SQL & " K7231_Check9,"
            SQL = SQL & " K7231_Check10,"
            SQL = SQL & " K7231_CheckName1,"
            SQL = SQL & " K7231_CheckName2,"
            SQL = SQL & " K7231_CheckName3,"
            SQL = SQL & " K7231_CheckName4,"
            SQL = SQL & " K7231_CheckName5,"
            SQL = SQL & " K7231_CheckName6,"
            SQL = SQL & " K7231_CheckName7,"
            SQL = SQL & " K7231_CheckName8,"
            SQL = SQL & " K7231_CheckName9,"
            SQL = SQL & " K7231_CheckName10,"
            SQL = SQL & " K7231_ACodeMaterial,"
            SQL = SQL & " K7231_ACodeTax1,"
            SQL = SQL & " K7231_ACodeTax2,"
            SQL = SQL & " K7231_ACodeTax3,"
            SQL = SQL & " K7231_ACodeSales,"
            SQL = SQL & " K7231_ACodeIntSales,"
            SQL = SQL & " K7231_ACodeCOGS,"
            SQL = SQL & " K7231_ACodeReturn,"
            SQL = SQL & " K7231_ACodeDiscount,"
            SQL = SQL & " K7231_ACodeWIP,"
            SQL = SQL & " K7231_CheckInventory,"
            SQL = SQL & " K7231_CheckPosition,"
            SQL = SQL & " K7231_CheckLotNo,"
            SQL = SQL & " K7231_CheckPrice,"
            SQL = SQL & " K7231_seTax1,"
            SQL = SQL & " K7231_cdTax1,"
            SQL = SQL & " K7231_PerTax1,"
            SQL = SQL & " K7231_seTax2,"
            SQL = SQL & " K7231_cdTax2,"
            SQL = SQL & " K7231_PerTax2,"
            SQL = SQL & " K7231_seTax3,"
            SQL = SQL & " K7231_cdTax3,"
            SQL = SQL & " K7231_PerTax3,"
            SQL = SQL & " K7231_seTaxVAT,"
            SQL = SQL & " K7231_cdTaxVAT,"
            SQL = SQL & " K7231_seTaxImport,"
            SQL = SQL & " K7231_cdTaxImport,"
            SQL = SQL & " K7231_seTaxExport,"
            SQL = SQL & " K7231_cdTaxExport,"
            SQL = SQL & " K7231_seTaxSpecial,"
            SQL = SQL & " K7231_cdTaxSpecial,"
            SQL = SQL & " K7231_seAccMaterial,"
            SQL = SQL & " K7231_cdAccMaterial,"
            SQL = SQL & " K7231_seAccSales,"
            SQL = SQL & " K7231_cdAccSales,"
            SQL = SQL & " K7231_seAccIntSales,"
            SQL = SQL & " K7231_cdAccIntSales,"
            SQL = SQL & " K7231_seAccCOGS,"
            SQL = SQL & " K7231_cdAccCOGS,"
            SQL = SQL & " K7231_seAccReturn,"
            SQL = SQL & " K7231_cdAccReturn,"
            SQL = SQL & " K7231_seAccDiscount,"
            SQL = SQL & " K7231_cdAccDiscount,"
            SQL = SQL & " K7231_seAccWIP,"
            SQL = SQL & " K7231_cdAccWIP,"
            SQL = SQL & " K7231_DateInsert,"
            SQL = SQL & " K7231_DateUpdate,"
            SQL = SQL & " K7231_InchargeInsert,"
            SQL = SQL & " K7231_InchargeUpdate,"
            SQL = SQL & " K7231_InchargeComplete,"
            SQL = SQL & " K7231_InchargeCancel,"
            SQL = SQL & " K7231_InchargeApproved,"
            SQL = SQL & " K7231_InchargePending1,"
            SQL = SQL & " K7231_InchargePending2,"
            SQL = SQL & " K7231_CheckUse,"
            SQL = SQL & " K7231_DateActive,"
            SQL = SQL & " K7231_DateDeactive,"
            SQL = SQL & " K7231_CheckActive,"
            SQL = SQL & " K7231_DateComplete,"
            SQL = SQL & " K7231_DateApproved,"
            SQL = SQL & " K7231_DateCancel,"
            SQL = SQL & " K7231_DatePending1,"
            SQL = SQL & " K7231_DatePending2,"
            SQL = SQL & " K7231_CheckSync,"
            SQL = SQL & " K7231_MaterialFullName,"
            SQL = SQL & " K7231_MaterialOldName,"
            SQL = SQL & " K7231_Remark "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z7231.MaterialCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.MaterialName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.MaterialPName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.MaterialSimple) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.MaterialColor) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.seImportGroup) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.cdImportGroup) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.ImportCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.ImportName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.ImportCode1) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.ImportName1) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.AccountCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.AccountName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.OtherCode1) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.OtherCode2) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.DevelopmentCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.DevelopmentName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.MaterialForeign1) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.MaterialForeign2) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.Width) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.Height) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.SizeName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.CheckPrint) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.CheckSP) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.seSpecial) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.cdSpecial) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.SizeRangeTool) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.CheckKindMaterial) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.CheckMarketType) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.seUnitPrice) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.cdUnitPrice) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.DateExchangePrice) & "', "
            SQL = SQL & "   " & FormatSQL(z7231.ExchangePrice) & ", "
            SQL = SQL & "   " & FormatSQL(z7231.PriceUSD) & ", "
            SQL = SQL & "   " & FormatSQL(z7231.PriceVND) & ", "
            SQL = SQL & "  N'" & FormatSQL(z7231.seDepartment) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.cdDepartment) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.seLargeGroupMaterial) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.cdLargeGroupMaterial) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.seSemiGroupMaterial) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.cdSemiGroupMaterial) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.seDetailGroupMaterial) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.cdDetailGroupMaterial) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.seSpecGroup1) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.cdSpecGroup1) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.seSpecGroup2) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.cdSpecGroup2) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.seSpecGroup3) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.cdSpecGroup3) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.seSpecGroup4) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.cdSpecGroup4) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.seSpecGroup5) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.cdSpecGroup5) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.seUnitMaterial) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.cdUnitMaterial) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.seUnitPacking) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.cdUnitPacking) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.seTax) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.cdTax) & "', "
            SQL = SQL & "   " & FormatSQL(z7231.PerTaxImport) & ", "
            SQL = SQL & "   " & FormatSQL(z7231.PerTaxVAT) & ", "
            SQL = SQL & "   " & FormatSQL(z7231.QtyBasic) & ", "
            SQL = SQL & "   " & FormatSQL(z7231.QtyOptimum) & ", "
            SQL = SQL & "   " & FormatSQL(z7231.DayOptimum) & ", "
            SQL = SQL & "   " & FormatSQL(z7231.DayEstimate) & ", "
            SQL = SQL & "   " & FormatSQL(z7231.PriceMaterial) & ", "
            SQL = SQL & "   " & FormatSQL(z7231.QtyMOQ) & ", "
            SQL = SQL & "   " & FormatSQL(z7231.MaxInventory) & ", "
            SQL = SQL & "   " & FormatSQL(z7231.MinInventory) & ", "
            SQL = SQL & "   " & FormatSQL(z7231.ReOrderQty) & ", "
            SQL = SQL & "  N'" & FormatSQL(z7231.CheckDevRnD) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.StatusMaterial) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.BOMType) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.ApplyType) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.DateStart) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.DateOptimum) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.DateEstimate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.DateInBound) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.DateOutBound) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.SupplyName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.SupplyCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.SalesCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.Check1) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.Check2) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.Check3) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.Check4) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.Check5) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.Check6) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.Check7) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.Check8) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.Check9) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.Check10) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.CheckName1) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.CheckName2) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.CheckName3) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.CheckName4) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.CheckName5) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.CheckName6) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.CheckName7) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.CheckName8) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.CheckName9) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.CheckName10) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.ACodeMaterial) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.ACodeTax1) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.ACodeTax2) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.ACodeTax3) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.ACodeSales) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.ACodeIntSales) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.ACodeCOGS) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.ACodeReturn) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.ACodeDiscount) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.ACodeWIP) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.CheckInventory) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.CheckPosition) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.CheckLotNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.CheckPrice) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.seTax1) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.cdTax1) & "', "
            SQL = SQL & "   " & FormatSQL(z7231.PerTax1) & ", "
            SQL = SQL & "  N'" & FormatSQL(z7231.seTax2) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.cdTax2) & "', "
            SQL = SQL & "   " & FormatSQL(z7231.PerTax2) & ", "
            SQL = SQL & "  N'" & FormatSQL(z7231.seTax3) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.cdTax3) & "', "
            SQL = SQL & "   " & FormatSQL(z7231.PerTax3) & ", "
            SQL = SQL & "  N'" & FormatSQL(z7231.seTaxVAT) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.cdTaxVAT) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.seTaxImport) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.cdTaxImport) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.seTaxExport) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.cdTaxExport) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.seTaxSpecial) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.cdTaxSpecial) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.seAccMaterial) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.cdAccMaterial) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.seAccSales) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.cdAccSales) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.seAccIntSales) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.cdAccIntSales) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.seAccCOGS) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.cdAccCOGS) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.seAccReturn) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.cdAccReturn) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.seAccDiscount) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.cdAccDiscount) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.seAccWIP) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.cdAccWIP) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.DateInsert) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.DateUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.InchargeInsert) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.InchargeUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.InchargeComplete) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.InchargeCancel) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.InchargeApproved) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.InchargePending1) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.InchargePending2) & "', "
            SQL = SQL & "  N'1', "
            SQL = SQL & "  N'" & FormatSQL(z7231.DateActive) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.DateDeactive) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.CheckActive) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.DateComplete) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.DateApproved) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.DateCancel) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.DatePending1) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.DatePending2) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.CheckSync) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.MaterialFullName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.MaterialOldName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7231.Remark) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK7231 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK7231", vbCritical)
        Finally
            Call GetFullInformation("PFK7231", "I", SQL)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK7231(z7231 As T7231_AREA) As Boolean
        REWRITE_PFK7231 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z7231)

            SQL = " UPDATE PFK7231 SET "
            SQL = SQL & "    K7231_MaterialName      = N'" & FormatSQL(z7231.MaterialName) & "', "
            SQL = SQL & "    K7231_MaterialPName      = N'" & FormatSQL(z7231.MaterialPName) & "', "
            SQL = SQL & "    K7231_MaterialSimple      = N'" & FormatSQL(z7231.MaterialSimple) & "', "
            SQL = SQL & "    K7231_MaterialColor      = N'" & FormatSQL(z7231.MaterialColor) & "', "
            SQL = SQL & "    K7231_seImportGroup      = N'" & FormatSQL(z7231.seImportGroup) & "', "
            SQL = SQL & "    K7231_cdImportGroup      = N'" & FormatSQL(z7231.cdImportGroup) & "', "
            SQL = SQL & "    K7231_ImportCode      = N'" & FormatSQL(z7231.ImportCode) & "', "
            SQL = SQL & "    K7231_ImportName      = N'" & FormatSQL(z7231.ImportName) & "', "
            SQL = SQL & "    K7231_ImportCode1      = N'" & FormatSQL(z7231.ImportCode1) & "', "
            SQL = SQL & "    K7231_ImportName1      = N'" & FormatSQL(z7231.ImportName1) & "', "
            SQL = SQL & "    K7231_AccountCode      = N'" & FormatSQL(z7231.AccountCode) & "', "
            SQL = SQL & "    K7231_AccountName      = N'" & FormatSQL(z7231.AccountName) & "', "
            SQL = SQL & "    K7231_OtherCode1      = N'" & FormatSQL(z7231.OtherCode1) & "', "
            SQL = SQL & "    K7231_OtherCode2      = N'" & FormatSQL(z7231.OtherCode2) & "', "
            SQL = SQL & "    K7231_DevelopmentCode      = N'" & FormatSQL(z7231.DevelopmentCode) & "', "
            SQL = SQL & "    K7231_DevelopmentName      = N'" & FormatSQL(z7231.DevelopmentName) & "', "
            SQL = SQL & "    K7231_MaterialForeign1      = N'" & FormatSQL(z7231.MaterialForeign1) & "', "
            SQL = SQL & "    K7231_MaterialForeign2      = N'" & FormatSQL(z7231.MaterialForeign2) & "', "
            SQL = SQL & "    K7231_Width      = N'" & FormatSQL(z7231.Width) & "', "
            SQL = SQL & "    K7231_Height      = N'" & FormatSQL(z7231.Height) & "', "
            SQL = SQL & "    K7231_SizeName      = N'" & FormatSQL(z7231.SizeName) & "', "
            SQL = SQL & "    K7231_CheckPrint      = N'" & FormatSQL(z7231.CheckPrint) & "', "
            SQL = SQL & "    K7231_CheckSP      = N'" & FormatSQL(z7231.CheckSP) & "', "
            SQL = SQL & "    K7231_seSpecial      = N'" & FormatSQL(z7231.seSpecial) & "', "
            SQL = SQL & "    K7231_cdSpecial      = N'" & FormatSQL(z7231.cdSpecial) & "', "
            SQL = SQL & "    K7231_SizeRangeTool      = N'" & FormatSQL(z7231.SizeRangeTool) & "', "
            SQL = SQL & "    K7231_CheckKindMaterial      = N'" & FormatSQL(z7231.CheckKindMaterial) & "', "
            SQL = SQL & "    K7231_CheckMarketType      = N'" & FormatSQL(z7231.CheckMarketType) & "', "
            SQL = SQL & "    K7231_seUnitPrice      = N'" & FormatSQL(z7231.seUnitPrice) & "', "
            SQL = SQL & "    K7231_cdUnitPrice      = N'" & FormatSQL(z7231.cdUnitPrice) & "', "
            SQL = SQL & "    K7231_DateExchangePrice      = N'" & FormatSQL(z7231.DateExchangePrice) & "', "
            SQL = SQL & "    K7231_ExchangePrice      =  " & FormatSQL(z7231.ExchangePrice) & ", "
            SQL = SQL & "    K7231_PriceUSD      =  " & FormatSQL(z7231.PriceUSD) & ", "
            SQL = SQL & "    K7231_PriceVND      =  " & FormatSQL(z7231.PriceVND) & ", "
            SQL = SQL & "    K7231_seDepartment      = N'" & FormatSQL(z7231.seDepartment) & "', "
            SQL = SQL & "    K7231_cdDepartment      = N'" & FormatSQL(z7231.cdDepartment) & "', "
            SQL = SQL & "    K7231_seLargeGroupMaterial      = N'" & FormatSQL(z7231.seLargeGroupMaterial) & "', "
            SQL = SQL & "    K7231_cdLargeGroupMaterial      = N'" & FormatSQL(z7231.cdLargeGroupMaterial) & "', "
            SQL = SQL & "    K7231_seSemiGroupMaterial      = N'" & FormatSQL(z7231.seSemiGroupMaterial) & "', "
            SQL = SQL & "    K7231_cdSemiGroupMaterial      = N'" & FormatSQL(z7231.cdSemiGroupMaterial) & "', "
            SQL = SQL & "    K7231_seDetailGroupMaterial      = N'" & FormatSQL(z7231.seDetailGroupMaterial) & "', "
            SQL = SQL & "    K7231_cdDetailGroupMaterial      = N'" & FormatSQL(z7231.cdDetailGroupMaterial) & "', "
            SQL = SQL & "    K7231_seSpecGroup1      = N'" & FormatSQL(z7231.seSpecGroup1) & "', "
            SQL = SQL & "    K7231_cdSpecGroup1      = N'" & FormatSQL(z7231.cdSpecGroup1) & "', "
            SQL = SQL & "    K7231_seSpecGroup2      = N'" & FormatSQL(z7231.seSpecGroup2) & "', "
            SQL = SQL & "    K7231_cdSpecGroup2      = N'" & FormatSQL(z7231.cdSpecGroup2) & "', "
            SQL = SQL & "    K7231_seSpecGroup3      = N'" & FormatSQL(z7231.seSpecGroup3) & "', "
            SQL = SQL & "    K7231_cdSpecGroup3      = N'" & FormatSQL(z7231.cdSpecGroup3) & "', "
            SQL = SQL & "    K7231_seSpecGroup4      = N'" & FormatSQL(z7231.seSpecGroup4) & "', "
            SQL = SQL & "    K7231_cdSpecGroup4      = N'" & FormatSQL(z7231.cdSpecGroup4) & "', "
            SQL = SQL & "    K7231_seSpecGroup5      = N'" & FormatSQL(z7231.seSpecGroup5) & "', "
            SQL = SQL & "    K7231_cdSpecGroup5      = N'" & FormatSQL(z7231.cdSpecGroup5) & "', "
            SQL = SQL & "    K7231_seUnitMaterial      = N'" & FormatSQL(z7231.seUnitMaterial) & "', "
            SQL = SQL & "    K7231_cdUnitMaterial      = N'" & FormatSQL(z7231.cdUnitMaterial) & "', "
            SQL = SQL & "    K7231_seUnitPacking      = N'" & FormatSQL(z7231.seUnitPacking) & "', "
            SQL = SQL & "    K7231_cdUnitPacking      = N'" & FormatSQL(z7231.cdUnitPacking) & "', "
            SQL = SQL & "    K7231_seTax      = N'" & FormatSQL(z7231.seTax) & "', "
            SQL = SQL & "    K7231_cdTax      = N'" & FormatSQL(z7231.cdTax) & "', "
            SQL = SQL & "    K7231_PerTaxImport      =  " & FormatSQL(z7231.PerTaxImport) & ", "
            SQL = SQL & "    K7231_PerTaxVAT      =  " & FormatSQL(z7231.PerTaxVAT) & ", "
            SQL = SQL & "    K7231_QtyBasic      =  " & FormatSQL(z7231.QtyBasic) & ", "
            SQL = SQL & "    K7231_QtyOptimum      =  " & FormatSQL(z7231.QtyOptimum) & ", "
            SQL = SQL & "    K7231_DayOptimum      =  " & FormatSQL(z7231.DayOptimum) & ", "
            SQL = SQL & "    K7231_DayEstimate      =  " & FormatSQL(z7231.DayEstimate) & ", "
            SQL = SQL & "    K7231_PriceMaterial      =  " & FormatSQL(z7231.PriceMaterial) & ", "
            SQL = SQL & "    K7231_QtyMOQ      =  " & FormatSQL(z7231.QtyMOQ) & ", "
            SQL = SQL & "    K7231_MaxInventory      =  " & FormatSQL(z7231.MaxInventory) & ", "
            SQL = SQL & "    K7231_MinInventory      =  " & FormatSQL(z7231.MinInventory) & ", "
            SQL = SQL & "    K7231_ReOrderQty      =  " & FormatSQL(z7231.ReOrderQty) & ", "
            SQL = SQL & "    K7231_CheckDevRnD      = N'" & FormatSQL(z7231.CheckDevRnD) & "', "
            SQL = SQL & "    K7231_StatusMaterial      = N'" & FormatSQL(z7231.StatusMaterial) & "', "
            SQL = SQL & "    K7231_BOMType      = N'" & FormatSQL(z7231.BOMType) & "', "
            SQL = SQL & "    K7231_ApplyType      = N'" & FormatSQL(z7231.ApplyType) & "', "
            SQL = SQL & "    K7231_DateStart      = N'" & FormatSQL(z7231.DateStart) & "', "
            SQL = SQL & "    K7231_DateOptimum      = N'" & FormatSQL(z7231.DateOptimum) & "', "
            SQL = SQL & "    K7231_DateEstimate      = N'" & FormatSQL(z7231.DateEstimate) & "', "
            SQL = SQL & "    K7231_DateInBound      = N'" & FormatSQL(z7231.DateInBound) & "', "
            SQL = SQL & "    K7231_DateOutBound      = N'" & FormatSQL(z7231.DateOutBound) & "', "
            SQL = SQL & "    K7231_SupplyName      = N'" & FormatSQL(z7231.SupplyName) & "', "
            SQL = SQL & "    K7231_SupplyCode      = N'" & FormatSQL(z7231.SupplyCode) & "', "
            SQL = SQL & "    K7231_SalesCode      = N'" & FormatSQL(z7231.SalesCode) & "', "
            SQL = SQL & "    K7231_Check1      = N'" & FormatSQL(z7231.Check1) & "', "
            SQL = SQL & "    K7231_Check2      = N'" & FormatSQL(z7231.Check2) & "', "
            SQL = SQL & "    K7231_Check3      = N'" & FormatSQL(z7231.Check3) & "', "
            SQL = SQL & "    K7231_Check4      = N'" & FormatSQL(z7231.Check4) & "', "
            SQL = SQL & "    K7231_Check5      = N'" & FormatSQL(z7231.Check5) & "', "
            SQL = SQL & "    K7231_Check6      = N'" & FormatSQL(z7231.Check6) & "', "
            SQL = SQL & "    K7231_Check7      = N'" & FormatSQL(z7231.Check7) & "', "
            SQL = SQL & "    K7231_Check8      = N'" & FormatSQL(z7231.Check8) & "', "
            SQL = SQL & "    K7231_Check9      = N'" & FormatSQL(z7231.Check9) & "', "
            SQL = SQL & "    K7231_Check10      = N'" & FormatSQL(z7231.Check10) & "', "
            SQL = SQL & "    K7231_CheckName1      = N'" & FormatSQL(z7231.CheckName1) & "', "
            SQL = SQL & "    K7231_CheckName2      = N'" & FormatSQL(z7231.CheckName2) & "', "
            SQL = SQL & "    K7231_CheckName3      = N'" & FormatSQL(z7231.CheckName3) & "', "
            SQL = SQL & "    K7231_CheckName4      = N'" & FormatSQL(z7231.CheckName4) & "', "
            SQL = SQL & "    K7231_CheckName5      = N'" & FormatSQL(z7231.CheckName5) & "', "
            SQL = SQL & "    K7231_CheckName6      = N'" & FormatSQL(z7231.CheckName6) & "', "
            SQL = SQL & "    K7231_CheckName7      = N'" & FormatSQL(z7231.CheckName7) & "', "
            SQL = SQL & "    K7231_CheckName8      = N'" & FormatSQL(z7231.CheckName8) & "', "
            SQL = SQL & "    K7231_CheckName9      = N'" & FormatSQL(z7231.CheckName9) & "', "
            SQL = SQL & "    K7231_CheckName10      = N'" & FormatSQL(z7231.CheckName10) & "', "
            SQL = SQL & "    K7231_ACodeMaterial      = N'" & FormatSQL(z7231.ACodeMaterial) & "', "
            SQL = SQL & "    K7231_ACodeTax1      = N'" & FormatSQL(z7231.ACodeTax1) & "', "
            SQL = SQL & "    K7231_ACodeTax2      = N'" & FormatSQL(z7231.ACodeTax2) & "', "
            SQL = SQL & "    K7231_ACodeTax3      = N'" & FormatSQL(z7231.ACodeTax3) & "', "
            SQL = SQL & "    K7231_ACodeSales      = N'" & FormatSQL(z7231.ACodeSales) & "', "
            SQL = SQL & "    K7231_ACodeIntSales      = N'" & FormatSQL(z7231.ACodeIntSales) & "', "
            SQL = SQL & "    K7231_ACodeCOGS      = N'" & FormatSQL(z7231.ACodeCOGS) & "', "
            SQL = SQL & "    K7231_ACodeReturn      = N'" & FormatSQL(z7231.ACodeReturn) & "', "
            SQL = SQL & "    K7231_ACodeDiscount      = N'" & FormatSQL(z7231.ACodeDiscount) & "', "
            SQL = SQL & "    K7231_ACodeWIP      = N'" & FormatSQL(z7231.ACodeWIP) & "', "
            SQL = SQL & "    K7231_CheckInventory      = N'" & FormatSQL(z7231.CheckInventory) & "', "
            SQL = SQL & "    K7231_CheckPosition      = N'" & FormatSQL(z7231.CheckPosition) & "', "
            SQL = SQL & "    K7231_CheckLotNo      = N'" & FormatSQL(z7231.CheckLotNo) & "', "
            SQL = SQL & "    K7231_CheckPrice      = N'" & FormatSQL(z7231.CheckPrice) & "', "
            SQL = SQL & "    K7231_seTax1      = N'" & FormatSQL(z7231.seTax1) & "', "
            SQL = SQL & "    K7231_cdTax1      = N'" & FormatSQL(z7231.cdTax1) & "', "
            SQL = SQL & "    K7231_PerTax1      =  " & FormatSQL(z7231.PerTax1) & ", "
            SQL = SQL & "    K7231_seTax2      = N'" & FormatSQL(z7231.seTax2) & "', "
            SQL = SQL & "    K7231_cdTax2      = N'" & FormatSQL(z7231.cdTax2) & "', "
            SQL = SQL & "    K7231_PerTax2      =  " & FormatSQL(z7231.PerTax2) & ", "
            SQL = SQL & "    K7231_seTax3      = N'" & FormatSQL(z7231.seTax3) & "', "
            SQL = SQL & "    K7231_cdTax3      = N'" & FormatSQL(z7231.cdTax3) & "', "
            SQL = SQL & "    K7231_PerTax3      =  " & FormatSQL(z7231.PerTax3) & ", "
            SQL = SQL & "    K7231_seTaxVAT      = N'" & FormatSQL(z7231.seTaxVAT) & "', "
            SQL = SQL & "    K7231_cdTaxVAT      = N'" & FormatSQL(z7231.cdTaxVAT) & "', "
            SQL = SQL & "    K7231_seTaxImport      = N'" & FormatSQL(z7231.seTaxImport) & "', "
            SQL = SQL & "    K7231_cdTaxImport      = N'" & FormatSQL(z7231.cdTaxImport) & "', "
            SQL = SQL & "    K7231_seTaxExport      = N'" & FormatSQL(z7231.seTaxExport) & "', "
            SQL = SQL & "    K7231_cdTaxExport      = N'" & FormatSQL(z7231.cdTaxExport) & "', "
            SQL = SQL & "    K7231_seTaxSpecial      = N'" & FormatSQL(z7231.seTaxSpecial) & "', "
            SQL = SQL & "    K7231_cdTaxSpecial      = N'" & FormatSQL(z7231.cdTaxSpecial) & "', "
            SQL = SQL & "    K7231_seAccMaterial      = N'" & FormatSQL(z7231.seAccMaterial) & "', "
            SQL = SQL & "    K7231_cdAccMaterial      = N'" & FormatSQL(z7231.cdAccMaterial) & "', "
            SQL = SQL & "    K7231_seAccSales      = N'" & FormatSQL(z7231.seAccSales) & "', "
            SQL = SQL & "    K7231_cdAccSales      = N'" & FormatSQL(z7231.cdAccSales) & "', "
            SQL = SQL & "    K7231_seAccIntSales      = N'" & FormatSQL(z7231.seAccIntSales) & "', "
            SQL = SQL & "    K7231_cdAccIntSales      = N'" & FormatSQL(z7231.cdAccIntSales) & "', "
            SQL = SQL & "    K7231_seAccCOGS      = N'" & FormatSQL(z7231.seAccCOGS) & "', "
            SQL = SQL & "    K7231_cdAccCOGS      = N'" & FormatSQL(z7231.cdAccCOGS) & "', "
            SQL = SQL & "    K7231_seAccReturn      = N'" & FormatSQL(z7231.seAccReturn) & "', "
            SQL = SQL & "    K7231_cdAccReturn      = N'" & FormatSQL(z7231.cdAccReturn) & "', "
            SQL = SQL & "    K7231_seAccDiscount      = N'" & FormatSQL(z7231.seAccDiscount) & "', "
            SQL = SQL & "    K7231_cdAccDiscount      = N'" & FormatSQL(z7231.cdAccDiscount) & "', "
            SQL = SQL & "    K7231_seAccWIP      = N'" & FormatSQL(z7231.seAccWIP) & "', "
            SQL = SQL & "    K7231_cdAccWIP      = N'" & FormatSQL(z7231.cdAccWIP) & "', "
            SQL = SQL & "    K7231_DateInsert      = N'" & FormatSQL(z7231.DateInsert) & "', "
            SQL = SQL & "    K7231_DateUpdate      = N'" & FormatSQL(z7231.DateUpdate) & "', "
            SQL = SQL & "    K7231_InchargeInsert      = N'" & FormatSQL(z7231.InchargeInsert) & "', "
            SQL = SQL & "    K7231_InchargeUpdate      = N'" & FormatSQL(z7231.InchargeUpdate) & "', "
            SQL = SQL & "    K7231_InchargeComplete      = N'" & FormatSQL(z7231.InchargeComplete) & "', "
            SQL = SQL & "    K7231_InchargeCancel      = N'" & FormatSQL(z7231.InchargeCancel) & "', "
            SQL = SQL & "    K7231_InchargeApproved      = N'" & FormatSQL(z7231.InchargeApproved) & "', "
            SQL = SQL & "    K7231_InchargePending1      = N'" & FormatSQL(z7231.InchargePending1) & "', "
            SQL = SQL & "    K7231_InchargePending2      = N'" & FormatSQL(z7231.InchargePending2) & "', "
            SQL = SQL & "    K7231_CheckUse      = N'" & FormatSQL(z7231.CheckUse) & "', "
            SQL = SQL & "    K7231_DateActive      = N'" & FormatSQL(z7231.DateActive) & "', "
            SQL = SQL & "    K7231_DateDeactive      = N'" & FormatSQL(z7231.DateDeactive) & "', "
            SQL = SQL & "    K7231_CheckActive      = N'" & FormatSQL(z7231.CheckActive) & "', "
            SQL = SQL & "    K7231_DateComplete      = N'" & FormatSQL(z7231.DateComplete) & "', "
            SQL = SQL & "    K7231_DateApproved      = N'" & FormatSQL(z7231.DateApproved) & "', "
            SQL = SQL & "    K7231_DateCancel      = N'" & FormatSQL(z7231.DateCancel) & "', "
            SQL = SQL & "    K7231_DatePending1      = N'" & FormatSQL(z7231.DatePending1) & "', "
            SQL = SQL & "    K7231_DatePending2      = N'" & FormatSQL(z7231.DatePending2) & "', "
            SQL = SQL & "    K7231_CheckSync      = N'" & FormatSQL(z7231.CheckSync) & "', "
            SQL = SQL & "    K7231_MaterialFullName      = N'" & FormatSQL(z7231.MaterialFullName) & "', "
            SQL = SQL & "    K7231_MaterialOldName      = N'" & FormatSQL(z7231.MaterialOldName) & "', "
            SQL = SQL & "    K7231_Remark      = N'" & FormatSQL(z7231.Remark) & "'  "
            SQL = SQL & " WHERE K7231_MaterialCode		 = '" & z7231.MaterialCode & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK7231 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK7231", vbCritical)
        Finally
            Call GetFullInformation("PFK7231", "U", SQL)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK7231(z7231 As T7231_AREA) As Boolean
        DELETE_PFK7231 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z7231)

            SQL = " DELETE FROM PFK7231  "
            SQL = SQL & " WHERE K7231_MaterialCode		 = '" & z7231.MaterialCode & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK7231 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK7231", vbCritical)
        Finally
            Call GetFullInformation("PFK7231", "U", SQL)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D7231_CLEAR()
        Try

            D7231.MaterialCode = ""
            D7231.MaterialName = ""
            D7231.MaterialPName = ""
            D7231.MaterialSimple = ""
            D7231.MaterialColor = ""
            D7231.seImportGroup = ""
            D7231.cdImportGroup = ""
            D7231.ImportCode = ""
            D7231.ImportName = ""
            D7231.ImportCode1 = ""
            D7231.ImportName1 = ""
            D7231.AccountCode = ""
            D7231.AccountName = ""
            D7231.OtherCode1 = ""
            D7231.OtherCode2 = ""
            D7231.DevelopmentCode = ""
            D7231.DevelopmentName = ""
            D7231.MaterialForeign1 = ""
            D7231.MaterialForeign2 = ""
            D7231.Width = ""
            D7231.Height = ""
            D7231.SizeName = ""
            D7231.CheckPrint = ""
            D7231.CheckSP = ""
            D7231.seSpecial = ""
            D7231.cdSpecial = ""
            D7231.SizeRangeTool = ""
            D7231.CheckKindMaterial = ""
            D7231.CheckMarketType = ""
            D7231.seUnitPrice = ""
            D7231.cdUnitPrice = ""
            D7231.DateExchangePrice = ""
            D7231.ExchangePrice = 0
            D7231.PriceUSD = 0
            D7231.PriceVND = 0
            D7231.seDepartment = ""
            D7231.cdDepartment = ""
            D7231.seLargeGroupMaterial = ""
            D7231.cdLargeGroupMaterial = ""
            D7231.seSemiGroupMaterial = ""
            D7231.cdSemiGroupMaterial = ""
            D7231.seDetailGroupMaterial = ""
            D7231.cdDetailGroupMaterial = ""
            D7231.seSpecGroup1 = ""
            D7231.cdSpecGroup1 = ""
            D7231.seSpecGroup2 = ""
            D7231.cdSpecGroup2 = ""
            D7231.seSpecGroup3 = ""
            D7231.cdSpecGroup3 = ""
            D7231.seSpecGroup4 = ""
            D7231.cdSpecGroup4 = ""
            D7231.seSpecGroup5 = ""
            D7231.cdSpecGroup5 = ""
            D7231.seUnitMaterial = ""
            D7231.cdUnitMaterial = ""
            D7231.seUnitPacking = ""
            D7231.cdUnitPacking = ""
            D7231.seTax = ""
            D7231.cdTax = ""
            D7231.PerTaxImport = 0
            D7231.PerTaxVAT = 0
            D7231.QtyBasic = 0
            D7231.QtyOptimum = 0
            D7231.DayOptimum = 0
            D7231.DayEstimate = 0
            D7231.PriceMaterial = 0
            D7231.QtyMOQ = 0
            D7231.MaxInventory = 0
            D7231.MinInventory = 0
            D7231.ReOrderQty = 0
            D7231.CheckDevRnD = ""
            D7231.StatusMaterial = ""
            D7231.BOMType = ""
            D7231.ApplyType = ""
            D7231.DateStart = ""
            D7231.DateOptimum = ""
            D7231.DateEstimate = ""
            D7231.DateInBound = ""
            D7231.DateOutBound = ""
            D7231.SupplyName = ""
            D7231.SupplyCode = ""
            D7231.SalesCode = ""
            D7231.Check1 = ""
            D7231.Check2 = ""
            D7231.Check3 = ""
            D7231.Check4 = ""
            D7231.Check5 = ""
            D7231.Check6 = ""
            D7231.Check7 = ""
            D7231.Check8 = ""
            D7231.Check9 = ""
            D7231.Check10 = ""
            D7231.CheckName1 = ""
            D7231.CheckName2 = ""
            D7231.CheckName3 = ""
            D7231.CheckName4 = ""
            D7231.CheckName5 = ""
            D7231.CheckName6 = ""
            D7231.CheckName7 = ""
            D7231.CheckName8 = ""
            D7231.CheckName9 = ""
            D7231.CheckName10 = ""
            D7231.ACodeMaterial = ""
            D7231.ACodeTax1 = ""
            D7231.ACodeTax2 = ""
            D7231.ACodeTax3 = ""
            D7231.ACodeSales = ""
            D7231.ACodeIntSales = ""
            D7231.ACodeCOGS = ""
            D7231.ACodeReturn = ""
            D7231.ACodeDiscount = ""
            D7231.ACodeWIP = ""
            D7231.CheckInventory = ""
            D7231.CheckPosition = ""
            D7231.CheckLotNo = ""
            D7231.CheckPrice = ""
            D7231.seTax1 = ""
            D7231.cdTax1 = ""
            D7231.PerTax1 = 0
            D7231.seTax2 = ""
            D7231.cdTax2 = ""
            D7231.PerTax2 = 0
            D7231.seTax3 = ""
            D7231.cdTax3 = ""
            D7231.PerTax3 = 0
            D7231.seTaxVAT = ""
            D7231.cdTaxVAT = ""
            D7231.seTaxImport = ""
            D7231.cdTaxImport = ""
            D7231.seTaxExport = ""
            D7231.cdTaxExport = ""
            D7231.seTaxSpecial = ""
            D7231.cdTaxSpecial = ""
            D7231.seAccMaterial = ""
            D7231.cdAccMaterial = ""
            D7231.seAccSales = ""
            D7231.cdAccSales = ""
            D7231.seAccIntSales = ""
            D7231.cdAccIntSales = ""
            D7231.seAccCOGS = ""
            D7231.cdAccCOGS = ""
            D7231.seAccReturn = ""
            D7231.cdAccReturn = ""
            D7231.seAccDiscount = ""
            D7231.cdAccDiscount = ""
            D7231.seAccWIP = ""
            D7231.cdAccWIP = ""
            D7231.DateInsert = ""
            D7231.DateUpdate = ""
            D7231.InchargeInsert = ""
            D7231.InchargeUpdate = ""
            D7231.InchargeComplete = ""
            D7231.InchargeCancel = ""
            D7231.InchargeApproved = ""
            D7231.InchargePending1 = ""
            D7231.InchargePending2 = ""
            D7231.CheckUse = ""
            D7231.DateActive = ""
            D7231.DateDeactive = ""
            D7231.CheckActive = ""
            D7231.DateComplete = ""
            D7231.DateApproved = ""
            D7231.DateCancel = ""
            D7231.DatePending1 = ""
            D7231.DatePending2 = ""
            D7231.CheckSync = ""
            D7231.MaterialFullName = ""
            D7231.MaterialOldName = ""
            D7231.Remark = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D7231_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x7231 As T7231_AREA)
        Try

            x7231.MaterialCode = trim$(x7231.MaterialCode)
            x7231.MaterialName = trim$(x7231.MaterialName)
            x7231.MaterialPName = trim$(x7231.MaterialPName)
            x7231.MaterialSimple = trim$(x7231.MaterialSimple)
            x7231.MaterialColor = trim$(x7231.MaterialColor)
            x7231.seImportGroup = trim$(x7231.seImportGroup)
            x7231.cdImportGroup = trim$(x7231.cdImportGroup)
            x7231.ImportCode = trim$(x7231.ImportCode)
            x7231.ImportName = Trim$(x7231.ImportName)
            x7231.ImportCode1 = Trim$(x7231.ImportCode1)
            x7231.ImportName1 = Trim$(x7231.ImportName1)
            x7231.AccountCode = trim$(x7231.AccountCode)
            x7231.AccountName = trim$(x7231.AccountName)
            x7231.OtherCode1 = trim$(x7231.OtherCode1)
            x7231.OtherCode2 = trim$(x7231.OtherCode2)
            x7231.DevelopmentCode = trim$(x7231.DevelopmentCode)
            x7231.DevelopmentName = trim$(x7231.DevelopmentName)
            x7231.MaterialForeign1 = trim$(x7231.MaterialForeign1)
            x7231.MaterialForeign2 = trim$(x7231.MaterialForeign2)
            x7231.Width = trim$(x7231.Width)
            x7231.Height = trim$(x7231.Height)
            x7231.SizeName = trim$(x7231.SizeName)
            x7231.CheckPrint = trim$(x7231.CheckPrint)
            x7231.CheckSP = trim$(x7231.CheckSP)
            x7231.seSpecial = trim$(x7231.seSpecial)
            x7231.cdSpecial = trim$(x7231.cdSpecial)
            x7231.SizeRangeTool = trim$(x7231.SizeRangeTool)
            x7231.CheckKindMaterial = trim$(x7231.CheckKindMaterial)
            x7231.CheckMarketType = trim$(x7231.CheckMarketType)
            x7231.seUnitPrice = trim$(x7231.seUnitPrice)
            x7231.cdUnitPrice = trim$(x7231.cdUnitPrice)
            x7231.DateExchangePrice = trim$(x7231.DateExchangePrice)
            x7231.ExchangePrice = trim$(x7231.ExchangePrice)
            x7231.PriceUSD = trim$(x7231.PriceUSD)
            x7231.PriceVND = trim$(x7231.PriceVND)
            x7231.seDepartment = trim$(x7231.seDepartment)
            x7231.cdDepartment = trim$(x7231.cdDepartment)
            x7231.seLargeGroupMaterial = trim$(x7231.seLargeGroupMaterial)
            x7231.cdLargeGroupMaterial = trim$(x7231.cdLargeGroupMaterial)
            x7231.seSemiGroupMaterial = trim$(x7231.seSemiGroupMaterial)
            x7231.cdSemiGroupMaterial = trim$(x7231.cdSemiGroupMaterial)
            x7231.seDetailGroupMaterial = trim$(x7231.seDetailGroupMaterial)
            x7231.cdDetailGroupMaterial = trim$(x7231.cdDetailGroupMaterial)
            x7231.seSpecGroup1 = trim$(x7231.seSpecGroup1)
            x7231.cdSpecGroup1 = trim$(x7231.cdSpecGroup1)
            x7231.seSpecGroup2 = trim$(x7231.seSpecGroup2)
            x7231.cdSpecGroup2 = trim$(x7231.cdSpecGroup2)
            x7231.seSpecGroup3 = trim$(x7231.seSpecGroup3)
            x7231.cdSpecGroup3 = trim$(x7231.cdSpecGroup3)
            x7231.seSpecGroup4 = trim$(x7231.seSpecGroup4)
            x7231.cdSpecGroup4 = trim$(x7231.cdSpecGroup4)
            x7231.seSpecGroup5 = trim$(x7231.seSpecGroup5)
            x7231.cdSpecGroup5 = trim$(x7231.cdSpecGroup5)
            x7231.seUnitMaterial = trim$(x7231.seUnitMaterial)
            x7231.cdUnitMaterial = trim$(x7231.cdUnitMaterial)
            x7231.seUnitPacking = trim$(x7231.seUnitPacking)
            x7231.cdUnitPacking = trim$(x7231.cdUnitPacking)
            x7231.seTax = trim$(x7231.seTax)
            x7231.cdTax = trim$(x7231.cdTax)
            x7231.PerTaxImport = trim$(x7231.PerTaxImport)
            x7231.PerTaxVAT = trim$(x7231.PerTaxVAT)
            x7231.QtyBasic = trim$(x7231.QtyBasic)
            x7231.QtyOptimum = trim$(x7231.QtyOptimum)
            x7231.DayOptimum = trim$(x7231.DayOptimum)
            x7231.DayEstimate = trim$(x7231.DayEstimate)
            x7231.PriceMaterial = trim$(x7231.PriceMaterial)
            x7231.QtyMOQ = trim$(x7231.QtyMOQ)
            x7231.MaxInventory = trim$(x7231.MaxInventory)
            x7231.MinInventory = trim$(x7231.MinInventory)
            x7231.ReOrderQty = trim$(x7231.ReOrderQty)
            x7231.CheckDevRnD = trim$(x7231.CheckDevRnD)
            x7231.StatusMaterial = trim$(x7231.StatusMaterial)
            x7231.BOMType = trim$(x7231.BOMType)
            x7231.ApplyType = trim$(x7231.ApplyType)
            x7231.DateStart = trim$(x7231.DateStart)
            x7231.DateOptimum = trim$(x7231.DateOptimum)
            x7231.DateEstimate = trim$(x7231.DateEstimate)
            x7231.DateInBound = trim$(x7231.DateInBound)
            x7231.DateOutBound = trim$(x7231.DateOutBound)
            x7231.SupplyName = trim$(x7231.SupplyName)
            x7231.SupplyCode = trim$(x7231.SupplyCode)
            x7231.SalesCode = trim$(x7231.SalesCode)
            x7231.Check1 = trim$(x7231.Check1)
            x7231.Check2 = trim$(x7231.Check2)
            x7231.Check3 = trim$(x7231.Check3)
            x7231.Check4 = trim$(x7231.Check4)
            x7231.Check5 = trim$(x7231.Check5)
            x7231.Check6 = trim$(x7231.Check6)
            x7231.Check7 = trim$(x7231.Check7)
            x7231.Check8 = trim$(x7231.Check8)
            x7231.Check9 = trim$(x7231.Check9)
            x7231.Check10 = trim$(x7231.Check10)
            x7231.CheckName1 = trim$(x7231.CheckName1)
            x7231.CheckName2 = trim$(x7231.CheckName2)
            x7231.CheckName3 = trim$(x7231.CheckName3)
            x7231.CheckName4 = trim$(x7231.CheckName4)
            x7231.CheckName5 = trim$(x7231.CheckName5)
            x7231.CheckName6 = trim$(x7231.CheckName6)
            x7231.CheckName7 = trim$(x7231.CheckName7)
            x7231.CheckName8 = trim$(x7231.CheckName8)
            x7231.CheckName9 = trim$(x7231.CheckName9)
            x7231.CheckName10 = trim$(x7231.CheckName10)
            x7231.ACodeMaterial = trim$(x7231.ACodeMaterial)
            x7231.ACodeTax1 = trim$(x7231.ACodeTax1)
            x7231.ACodeTax2 = trim$(x7231.ACodeTax2)
            x7231.ACodeTax3 = trim$(x7231.ACodeTax3)
            x7231.ACodeSales = trim$(x7231.ACodeSales)
            x7231.ACodeIntSales = trim$(x7231.ACodeIntSales)
            x7231.ACodeCOGS = trim$(x7231.ACodeCOGS)
            x7231.ACodeReturn = trim$(x7231.ACodeReturn)
            x7231.ACodeDiscount = trim$(x7231.ACodeDiscount)
            x7231.ACodeWIP = trim$(x7231.ACodeWIP)
            x7231.CheckInventory = trim$(x7231.CheckInventory)
            x7231.CheckPosition = trim$(x7231.CheckPosition)
            x7231.CheckLotNo = trim$(x7231.CheckLotNo)
            x7231.CheckPrice = trim$(x7231.CheckPrice)
            x7231.seTax1 = trim$(x7231.seTax1)
            x7231.cdTax1 = trim$(x7231.cdTax1)
            x7231.PerTax1 = trim$(x7231.PerTax1)
            x7231.seTax2 = trim$(x7231.seTax2)
            x7231.cdTax2 = trim$(x7231.cdTax2)
            x7231.PerTax2 = trim$(x7231.PerTax2)
            x7231.seTax3 = trim$(x7231.seTax3)
            x7231.cdTax3 = trim$(x7231.cdTax3)
            x7231.PerTax3 = trim$(x7231.PerTax3)
            x7231.seTaxVAT = trim$(x7231.seTaxVAT)
            x7231.cdTaxVAT = trim$(x7231.cdTaxVAT)
            x7231.seTaxImport = trim$(x7231.seTaxImport)
            x7231.cdTaxImport = trim$(x7231.cdTaxImport)
            x7231.seTaxExport = trim$(x7231.seTaxExport)
            x7231.cdTaxExport = trim$(x7231.cdTaxExport)
            x7231.seTaxSpecial = trim$(x7231.seTaxSpecial)
            x7231.cdTaxSpecial = trim$(x7231.cdTaxSpecial)
            x7231.seAccMaterial = trim$(x7231.seAccMaterial)
            x7231.cdAccMaterial = trim$(x7231.cdAccMaterial)
            x7231.seAccSales = trim$(x7231.seAccSales)
            x7231.cdAccSales = trim$(x7231.cdAccSales)
            x7231.seAccIntSales = trim$(x7231.seAccIntSales)
            x7231.cdAccIntSales = trim$(x7231.cdAccIntSales)
            x7231.seAccCOGS = trim$(x7231.seAccCOGS)
            x7231.cdAccCOGS = trim$(x7231.cdAccCOGS)
            x7231.seAccReturn = trim$(x7231.seAccReturn)
            x7231.cdAccReturn = trim$(x7231.cdAccReturn)
            x7231.seAccDiscount = trim$(x7231.seAccDiscount)
            x7231.cdAccDiscount = trim$(x7231.cdAccDiscount)
            x7231.seAccWIP = trim$(x7231.seAccWIP)
            x7231.cdAccWIP = trim$(x7231.cdAccWIP)
            x7231.DateInsert = trim$(x7231.DateInsert)
            x7231.DateUpdate = trim$(x7231.DateUpdate)
            x7231.InchargeInsert = trim$(x7231.InchargeInsert)
            x7231.InchargeUpdate = trim$(x7231.InchargeUpdate)
            x7231.InchargeComplete = trim$(x7231.InchargeComplete)
            x7231.InchargeCancel = trim$(x7231.InchargeCancel)
            x7231.InchargeApproved = trim$(x7231.InchargeApproved)
            x7231.InchargePending1 = trim$(x7231.InchargePending1)
            x7231.InchargePending2 = trim$(x7231.InchargePending2)
            x7231.CheckUse = trim$(x7231.CheckUse)
            x7231.DateActive = trim$(x7231.DateActive)
            x7231.DateDeactive = trim$(x7231.DateDeactive)
            x7231.CheckActive = trim$(x7231.CheckActive)
            x7231.DateComplete = trim$(x7231.DateComplete)
            x7231.DateApproved = trim$(x7231.DateApproved)
            x7231.DateCancel = trim$(x7231.DateCancel)
            x7231.DatePending1 = trim$(x7231.DatePending1)
            x7231.DatePending2 = trim$(x7231.DatePending2)
            x7231.CheckSync = trim$(x7231.CheckSync)
            x7231.MaterialFullName = trim$(x7231.MaterialFullName)
            x7231.MaterialOldName = trim$(x7231.MaterialOldName)
            x7231.Remark = trim$(x7231.Remark)

            If trim$(x7231.MaterialCode) = "" Then x7231.MaterialCode = Space(1)
            If trim$(x7231.MaterialName) = "" Then x7231.MaterialName = Space(1)
            If trim$(x7231.MaterialPName) = "" Then x7231.MaterialPName = Space(1)
            If trim$(x7231.MaterialSimple) = "" Then x7231.MaterialSimple = Space(1)
            If trim$(x7231.MaterialColor) = "" Then x7231.MaterialColor = Space(1)
            If trim$(x7231.seImportGroup) = "" Then x7231.seImportGroup = Space(1)
            If trim$(x7231.cdImportGroup) = "" Then x7231.cdImportGroup = Space(1)
            If trim$(x7231.ImportCode) = "" Then x7231.ImportCode = Space(1)
            If Trim$(x7231.ImportName) = "" Then x7231.ImportName = Space(1)

            If Trim$(x7231.ImportCode1) = "" Then x7231.ImportCode1 = Space(1)
            If Trim$(x7231.ImportName1) = "" Then x7231.ImportName1 = Space(1)
            If trim$(x7231.AccountCode) = "" Then x7231.AccountCode = Space(1)
            If trim$(x7231.AccountName) = "" Then x7231.AccountName = Space(1)
            If trim$(x7231.OtherCode1) = "" Then x7231.OtherCode1 = Space(1)
            If trim$(x7231.OtherCode2) = "" Then x7231.OtherCode2 = Space(1)
            If trim$(x7231.DevelopmentCode) = "" Then x7231.DevelopmentCode = Space(1)
            If trim$(x7231.DevelopmentName) = "" Then x7231.DevelopmentName = Space(1)
            If trim$(x7231.MaterialForeign1) = "" Then x7231.MaterialForeign1 = Space(1)
            If trim$(x7231.MaterialForeign2) = "" Then x7231.MaterialForeign2 = Space(1)
            If trim$(x7231.Width) = "" Then x7231.Width = Space(1)
            If trim$(x7231.Height) = "" Then x7231.Height = Space(1)
            If trim$(x7231.SizeName) = "" Then x7231.SizeName = Space(1)
            If trim$(x7231.CheckPrint) = "" Then x7231.CheckPrint = Space(1)
            If trim$(x7231.CheckSP) = "" Then x7231.CheckSP = Space(1)
            If trim$(x7231.seSpecial) = "" Then x7231.seSpecial = Space(1)
            If trim$(x7231.cdSpecial) = "" Then x7231.cdSpecial = Space(1)
            If trim$(x7231.SizeRangeTool) = "" Then x7231.SizeRangeTool = Space(1)
            If trim$(x7231.CheckKindMaterial) = "" Then x7231.CheckKindMaterial = Space(1)
            If trim$(x7231.CheckMarketType) = "" Then x7231.CheckMarketType = Space(1)
            If trim$(x7231.seUnitPrice) = "" Then x7231.seUnitPrice = Space(1)
            If trim$(x7231.cdUnitPrice) = "" Then x7231.cdUnitPrice = Space(1)
            If trim$(x7231.DateExchangePrice) = "" Then x7231.DateExchangePrice = Space(1)
            If trim$(x7231.ExchangePrice) = "" Then x7231.ExchangePrice = 0
            If trim$(x7231.PriceUSD) = "" Then x7231.PriceUSD = 0
            If trim$(x7231.PriceVND) = "" Then x7231.PriceVND = 0
            If trim$(x7231.seDepartment) = "" Then x7231.seDepartment = Space(1)
            If trim$(x7231.cdDepartment) = "" Then x7231.cdDepartment = Space(1)
            If trim$(x7231.seLargeGroupMaterial) = "" Then x7231.seLargeGroupMaterial = Space(1)
            If trim$(x7231.cdLargeGroupMaterial) = "" Then x7231.cdLargeGroupMaterial = Space(1)
            If trim$(x7231.seSemiGroupMaterial) = "" Then x7231.seSemiGroupMaterial = Space(1)
            If trim$(x7231.cdSemiGroupMaterial) = "" Then x7231.cdSemiGroupMaterial = Space(1)
            If trim$(x7231.seDetailGroupMaterial) = "" Then x7231.seDetailGroupMaterial = Space(1)
            If trim$(x7231.cdDetailGroupMaterial) = "" Then x7231.cdDetailGroupMaterial = Space(1)
            If trim$(x7231.seSpecGroup1) = "" Then x7231.seSpecGroup1 = Space(1)
            If trim$(x7231.cdSpecGroup1) = "" Then x7231.cdSpecGroup1 = Space(1)
            If trim$(x7231.seSpecGroup2) = "" Then x7231.seSpecGroup2 = Space(1)
            If trim$(x7231.cdSpecGroup2) = "" Then x7231.cdSpecGroup2 = Space(1)
            If trim$(x7231.seSpecGroup3) = "" Then x7231.seSpecGroup3 = Space(1)
            If trim$(x7231.cdSpecGroup3) = "" Then x7231.cdSpecGroup3 = Space(1)
            If trim$(x7231.seSpecGroup4) = "" Then x7231.seSpecGroup4 = Space(1)
            If trim$(x7231.cdSpecGroup4) = "" Then x7231.cdSpecGroup4 = Space(1)
            If trim$(x7231.seSpecGroup5) = "" Then x7231.seSpecGroup5 = Space(1)
            If trim$(x7231.cdSpecGroup5) = "" Then x7231.cdSpecGroup5 = Space(1)
            If trim$(x7231.seUnitMaterial) = "" Then x7231.seUnitMaterial = Space(1)
            If trim$(x7231.cdUnitMaterial) = "" Then x7231.cdUnitMaterial = Space(1)
            If trim$(x7231.seUnitPacking) = "" Then x7231.seUnitPacking = Space(1)
            If trim$(x7231.cdUnitPacking) = "" Then x7231.cdUnitPacking = Space(1)
            If trim$(x7231.seTax) = "" Then x7231.seTax = Space(1)
            If trim$(x7231.cdTax) = "" Then x7231.cdTax = Space(1)
            If trim$(x7231.PerTaxImport) = "" Then x7231.PerTaxImport = 0
            If trim$(x7231.PerTaxVAT) = "" Then x7231.PerTaxVAT = 0
            If trim$(x7231.QtyBasic) = "" Then x7231.QtyBasic = 0
            If trim$(x7231.QtyOptimum) = "" Then x7231.QtyOptimum = 0
            If trim$(x7231.DayOptimum) = "" Then x7231.DayOptimum = 0
            If trim$(x7231.DayEstimate) = "" Then x7231.DayEstimate = 0
            If trim$(x7231.PriceMaterial) = "" Then x7231.PriceMaterial = 0
            If trim$(x7231.QtyMOQ) = "" Then x7231.QtyMOQ = 0
            If trim$(x7231.MaxInventory) = "" Then x7231.MaxInventory = 0
            If trim$(x7231.MinInventory) = "" Then x7231.MinInventory = 0
            If trim$(x7231.ReOrderQty) = "" Then x7231.ReOrderQty = 0
            If trim$(x7231.CheckDevRnD) = "" Then x7231.CheckDevRnD = Space(1)
            If trim$(x7231.StatusMaterial) = "" Then x7231.StatusMaterial = Space(1)
            If trim$(x7231.BOMType) = "" Then x7231.BOMType = Space(1)
            If trim$(x7231.ApplyType) = "" Then x7231.ApplyType = Space(1)
            If trim$(x7231.DateStart) = "" Then x7231.DateStart = Space(1)
            If trim$(x7231.DateOptimum) = "" Then x7231.DateOptimum = Space(1)
            If trim$(x7231.DateEstimate) = "" Then x7231.DateEstimate = Space(1)
            If trim$(x7231.DateInBound) = "" Then x7231.DateInBound = Space(1)
            If trim$(x7231.DateOutBound) = "" Then x7231.DateOutBound = Space(1)
            If trim$(x7231.SupplyName) = "" Then x7231.SupplyName = Space(1)
            If trim$(x7231.SupplyCode) = "" Then x7231.SupplyCode = Space(1)
            If trim$(x7231.SalesCode) = "" Then x7231.SalesCode = Space(1)
            If trim$(x7231.Check1) = "" Then x7231.Check1 = Space(1)
            If trim$(x7231.Check2) = "" Then x7231.Check2 = Space(1)
            If trim$(x7231.Check3) = "" Then x7231.Check3 = Space(1)
            If trim$(x7231.Check4) = "" Then x7231.Check4 = Space(1)
            If trim$(x7231.Check5) = "" Then x7231.Check5 = Space(1)
            If trim$(x7231.Check6) = "" Then x7231.Check6 = Space(1)
            If trim$(x7231.Check7) = "" Then x7231.Check7 = Space(1)
            If trim$(x7231.Check8) = "" Then x7231.Check8 = Space(1)
            If trim$(x7231.Check9) = "" Then x7231.Check9 = Space(1)
            If trim$(x7231.Check10) = "" Then x7231.Check10 = Space(1)
            If trim$(x7231.CheckName1) = "" Then x7231.CheckName1 = Space(1)
            If trim$(x7231.CheckName2) = "" Then x7231.CheckName2 = Space(1)
            If trim$(x7231.CheckName3) = "" Then x7231.CheckName3 = Space(1)
            If trim$(x7231.CheckName4) = "" Then x7231.CheckName4 = Space(1)
            If trim$(x7231.CheckName5) = "" Then x7231.CheckName5 = Space(1)
            If trim$(x7231.CheckName6) = "" Then x7231.CheckName6 = Space(1)
            If trim$(x7231.CheckName7) = "" Then x7231.CheckName7 = Space(1)
            If trim$(x7231.CheckName8) = "" Then x7231.CheckName8 = Space(1)
            If trim$(x7231.CheckName9) = "" Then x7231.CheckName9 = Space(1)
            If trim$(x7231.CheckName10) = "" Then x7231.CheckName10 = Space(1)
            If trim$(x7231.ACodeMaterial) = "" Then x7231.ACodeMaterial = Space(1)
            If trim$(x7231.ACodeTax1) = "" Then x7231.ACodeTax1 = Space(1)
            If trim$(x7231.ACodeTax2) = "" Then x7231.ACodeTax2 = Space(1)
            If trim$(x7231.ACodeTax3) = "" Then x7231.ACodeTax3 = Space(1)
            If trim$(x7231.ACodeSales) = "" Then x7231.ACodeSales = Space(1)
            If trim$(x7231.ACodeIntSales) = "" Then x7231.ACodeIntSales = Space(1)
            If trim$(x7231.ACodeCOGS) = "" Then x7231.ACodeCOGS = Space(1)
            If trim$(x7231.ACodeReturn) = "" Then x7231.ACodeReturn = Space(1)
            If trim$(x7231.ACodeDiscount) = "" Then x7231.ACodeDiscount = Space(1)
            If trim$(x7231.ACodeWIP) = "" Then x7231.ACodeWIP = Space(1)
            If trim$(x7231.CheckInventory) = "" Then x7231.CheckInventory = Space(1)
            If trim$(x7231.CheckPosition) = "" Then x7231.CheckPosition = Space(1)
            If trim$(x7231.CheckLotNo) = "" Then x7231.CheckLotNo = Space(1)
            If trim$(x7231.CheckPrice) = "" Then x7231.CheckPrice = Space(1)
            If trim$(x7231.seTax1) = "" Then x7231.seTax1 = Space(1)
            If trim$(x7231.cdTax1) = "" Then x7231.cdTax1 = Space(1)
            If trim$(x7231.PerTax1) = "" Then x7231.PerTax1 = 0
            If trim$(x7231.seTax2) = "" Then x7231.seTax2 = Space(1)
            If trim$(x7231.cdTax2) = "" Then x7231.cdTax2 = Space(1)
            If trim$(x7231.PerTax2) = "" Then x7231.PerTax2 = 0
            If trim$(x7231.seTax3) = "" Then x7231.seTax3 = Space(1)
            If trim$(x7231.cdTax3) = "" Then x7231.cdTax3 = Space(1)
            If trim$(x7231.PerTax3) = "" Then x7231.PerTax3 = 0
            If trim$(x7231.seTaxVAT) = "" Then x7231.seTaxVAT = Space(1)
            If trim$(x7231.cdTaxVAT) = "" Then x7231.cdTaxVAT = Space(1)
            If trim$(x7231.seTaxImport) = "" Then x7231.seTaxImport = Space(1)
            If trim$(x7231.cdTaxImport) = "" Then x7231.cdTaxImport = Space(1)
            If trim$(x7231.seTaxExport) = "" Then x7231.seTaxExport = Space(1)
            If trim$(x7231.cdTaxExport) = "" Then x7231.cdTaxExport = Space(1)
            If trim$(x7231.seTaxSpecial) = "" Then x7231.seTaxSpecial = Space(1)
            If trim$(x7231.cdTaxSpecial) = "" Then x7231.cdTaxSpecial = Space(1)
            If trim$(x7231.seAccMaterial) = "" Then x7231.seAccMaterial = Space(1)
            If trim$(x7231.cdAccMaterial) = "" Then x7231.cdAccMaterial = Space(1)
            If trim$(x7231.seAccSales) = "" Then x7231.seAccSales = Space(1)
            If trim$(x7231.cdAccSales) = "" Then x7231.cdAccSales = Space(1)
            If trim$(x7231.seAccIntSales) = "" Then x7231.seAccIntSales = Space(1)
            If trim$(x7231.cdAccIntSales) = "" Then x7231.cdAccIntSales = Space(1)
            If trim$(x7231.seAccCOGS) = "" Then x7231.seAccCOGS = Space(1)
            If trim$(x7231.cdAccCOGS) = "" Then x7231.cdAccCOGS = Space(1)
            If trim$(x7231.seAccReturn) = "" Then x7231.seAccReturn = Space(1)
            If trim$(x7231.cdAccReturn) = "" Then x7231.cdAccReturn = Space(1)
            If trim$(x7231.seAccDiscount) = "" Then x7231.seAccDiscount = Space(1)
            If trim$(x7231.cdAccDiscount) = "" Then x7231.cdAccDiscount = Space(1)
            If trim$(x7231.seAccWIP) = "" Then x7231.seAccWIP = Space(1)
            If trim$(x7231.cdAccWIP) = "" Then x7231.cdAccWIP = Space(1)
            If trim$(x7231.DateInsert) = "" Then x7231.DateInsert = Space(1)
            If trim$(x7231.DateUpdate) = "" Then x7231.DateUpdate = Space(1)
            If trim$(x7231.InchargeInsert) = "" Then x7231.InchargeInsert = Space(1)
            If trim$(x7231.InchargeUpdate) = "" Then x7231.InchargeUpdate = Space(1)
            If trim$(x7231.InchargeComplete) = "" Then x7231.InchargeComplete = Space(1)
            If trim$(x7231.InchargeCancel) = "" Then x7231.InchargeCancel = Space(1)
            If trim$(x7231.InchargeApproved) = "" Then x7231.InchargeApproved = Space(1)
            If trim$(x7231.InchargePending1) = "" Then x7231.InchargePending1 = Space(1)
            If trim$(x7231.InchargePending2) = "" Then x7231.InchargePending2 = Space(1)
            If trim$(x7231.CheckUse) = "" Then x7231.CheckUse = Space(1)
            If trim$(x7231.DateActive) = "" Then x7231.DateActive = Space(1)
            If trim$(x7231.DateDeactive) = "" Then x7231.DateDeactive = Space(1)
            If trim$(x7231.CheckActive) = "" Then x7231.CheckActive = Space(1)
            If trim$(x7231.DateComplete) = "" Then x7231.DateComplete = Space(1)
            If trim$(x7231.DateApproved) = "" Then x7231.DateApproved = Space(1)
            If trim$(x7231.DateCancel) = "" Then x7231.DateCancel = Space(1)
            If trim$(x7231.DatePending1) = "" Then x7231.DatePending1 = Space(1)
            If trim$(x7231.DatePending2) = "" Then x7231.DatePending2 = Space(1)
            If trim$(x7231.CheckSync) = "" Then x7231.CheckSync = Space(1)
            If trim$(x7231.MaterialFullName) = "" Then x7231.MaterialFullName = Space(1)
            If trim$(x7231.MaterialOldName) = "" Then x7231.MaterialOldName = Space(1)
            If trim$(x7231.Remark) = "" Then x7231.Remark = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K7231_MOVE(rs7231 As SqlClient.SqlDataReader)
        Try

            Call D7231_CLEAR()

            If IsdbNull(rs7231!K7231_MaterialCode) = False Then D7231.MaterialCode = Trim$(rs7231!K7231_MaterialCode)
            If IsdbNull(rs7231!K7231_MaterialName) = False Then D7231.MaterialName = Trim$(rs7231!K7231_MaterialName)
            If IsdbNull(rs7231!K7231_MaterialPName) = False Then D7231.MaterialPName = Trim$(rs7231!K7231_MaterialPName)
            If IsdbNull(rs7231!K7231_MaterialSimple) = False Then D7231.MaterialSimple = Trim$(rs7231!K7231_MaterialSimple)
            If IsdbNull(rs7231!K7231_MaterialColor) = False Then D7231.MaterialColor = Trim$(rs7231!K7231_MaterialColor)
            If IsdbNull(rs7231!K7231_seImportGroup) = False Then D7231.seImportGroup = Trim$(rs7231!K7231_seImportGroup)
            If IsdbNull(rs7231!K7231_cdImportGroup) = False Then D7231.cdImportGroup = Trim$(rs7231!K7231_cdImportGroup)
            If IsdbNull(rs7231!K7231_ImportCode) = False Then D7231.ImportCode = Trim$(rs7231!K7231_ImportCode)
            If IsDBNull(rs7231!K7231_ImportName) = False Then D7231.ImportName = Trim$(rs7231!K7231_ImportName)
            If IsDBNull(rs7231!K7231_ImportCode1) = False Then D7231.ImportCode1 = Trim$(rs7231!K7231_ImportCode1)
            If IsDBNull(rs7231!K7231_ImportName1) = False Then D7231.ImportName1 = Trim$(rs7231!K7231_ImportName1)
            If IsdbNull(rs7231!K7231_AccountCode) = False Then D7231.AccountCode = Trim$(rs7231!K7231_AccountCode)
            If IsdbNull(rs7231!K7231_AccountName) = False Then D7231.AccountName = Trim$(rs7231!K7231_AccountName)
            If IsdbNull(rs7231!K7231_OtherCode1) = False Then D7231.OtherCode1 = Trim$(rs7231!K7231_OtherCode1)
            If IsdbNull(rs7231!K7231_OtherCode2) = False Then D7231.OtherCode2 = Trim$(rs7231!K7231_OtherCode2)
            If IsdbNull(rs7231!K7231_DevelopmentCode) = False Then D7231.DevelopmentCode = Trim$(rs7231!K7231_DevelopmentCode)
            If IsdbNull(rs7231!K7231_DevelopmentName) = False Then D7231.DevelopmentName = Trim$(rs7231!K7231_DevelopmentName)
            If IsdbNull(rs7231!K7231_MaterialForeign1) = False Then D7231.MaterialForeign1 = Trim$(rs7231!K7231_MaterialForeign1)
            If IsdbNull(rs7231!K7231_MaterialForeign2) = False Then D7231.MaterialForeign2 = Trim$(rs7231!K7231_MaterialForeign2)
            If IsdbNull(rs7231!K7231_Width) = False Then D7231.Width = Trim$(rs7231!K7231_Width)
            If IsdbNull(rs7231!K7231_Height) = False Then D7231.Height = Trim$(rs7231!K7231_Height)
            If IsdbNull(rs7231!K7231_SizeName) = False Then D7231.SizeName = Trim$(rs7231!K7231_SizeName)
            If IsdbNull(rs7231!K7231_CheckPrint) = False Then D7231.CheckPrint = Trim$(rs7231!K7231_CheckPrint)
            If IsdbNull(rs7231!K7231_CheckSP) = False Then D7231.CheckSP = Trim$(rs7231!K7231_CheckSP)
            If IsdbNull(rs7231!K7231_seSpecial) = False Then D7231.seSpecial = Trim$(rs7231!K7231_seSpecial)
            If IsdbNull(rs7231!K7231_cdSpecial) = False Then D7231.cdSpecial = Trim$(rs7231!K7231_cdSpecial)
            If IsdbNull(rs7231!K7231_SizeRangeTool) = False Then D7231.SizeRangeTool = Trim$(rs7231!K7231_SizeRangeTool)
            If IsdbNull(rs7231!K7231_CheckKindMaterial) = False Then D7231.CheckKindMaterial = Trim$(rs7231!K7231_CheckKindMaterial)
            If IsdbNull(rs7231!K7231_CheckMarketType) = False Then D7231.CheckMarketType = Trim$(rs7231!K7231_CheckMarketType)
            If IsdbNull(rs7231!K7231_seUnitPrice) = False Then D7231.seUnitPrice = Trim$(rs7231!K7231_seUnitPrice)
            If IsdbNull(rs7231!K7231_cdUnitPrice) = False Then D7231.cdUnitPrice = Trim$(rs7231!K7231_cdUnitPrice)
            If IsdbNull(rs7231!K7231_DateExchangePrice) = False Then D7231.DateExchangePrice = Trim$(rs7231!K7231_DateExchangePrice)
            If IsdbNull(rs7231!K7231_ExchangePrice) = False Then D7231.ExchangePrice = Trim$(rs7231!K7231_ExchangePrice)
            If IsdbNull(rs7231!K7231_PriceUSD) = False Then D7231.PriceUSD = Trim$(rs7231!K7231_PriceUSD)
            If IsdbNull(rs7231!K7231_PriceVND) = False Then D7231.PriceVND = Trim$(rs7231!K7231_PriceVND)
            If IsdbNull(rs7231!K7231_seDepartment) = False Then D7231.seDepartment = Trim$(rs7231!K7231_seDepartment)
            If IsdbNull(rs7231!K7231_cdDepartment) = False Then D7231.cdDepartment = Trim$(rs7231!K7231_cdDepartment)
            If IsdbNull(rs7231!K7231_seLargeGroupMaterial) = False Then D7231.seLargeGroupMaterial = Trim$(rs7231!K7231_seLargeGroupMaterial)
            If IsdbNull(rs7231!K7231_cdLargeGroupMaterial) = False Then D7231.cdLargeGroupMaterial = Trim$(rs7231!K7231_cdLargeGroupMaterial)
            If IsdbNull(rs7231!K7231_seSemiGroupMaterial) = False Then D7231.seSemiGroupMaterial = Trim$(rs7231!K7231_seSemiGroupMaterial)
            If IsdbNull(rs7231!K7231_cdSemiGroupMaterial) = False Then D7231.cdSemiGroupMaterial = Trim$(rs7231!K7231_cdSemiGroupMaterial)
            If IsdbNull(rs7231!K7231_seDetailGroupMaterial) = False Then D7231.seDetailGroupMaterial = Trim$(rs7231!K7231_seDetailGroupMaterial)
            If IsdbNull(rs7231!K7231_cdDetailGroupMaterial) = False Then D7231.cdDetailGroupMaterial = Trim$(rs7231!K7231_cdDetailGroupMaterial)
            If IsdbNull(rs7231!K7231_seSpecGroup1) = False Then D7231.seSpecGroup1 = Trim$(rs7231!K7231_seSpecGroup1)
            If IsdbNull(rs7231!K7231_cdSpecGroup1) = False Then D7231.cdSpecGroup1 = Trim$(rs7231!K7231_cdSpecGroup1)
            If IsdbNull(rs7231!K7231_seSpecGroup2) = False Then D7231.seSpecGroup2 = Trim$(rs7231!K7231_seSpecGroup2)
            If IsdbNull(rs7231!K7231_cdSpecGroup2) = False Then D7231.cdSpecGroup2 = Trim$(rs7231!K7231_cdSpecGroup2)
            If IsdbNull(rs7231!K7231_seSpecGroup3) = False Then D7231.seSpecGroup3 = Trim$(rs7231!K7231_seSpecGroup3)
            If IsdbNull(rs7231!K7231_cdSpecGroup3) = False Then D7231.cdSpecGroup3 = Trim$(rs7231!K7231_cdSpecGroup3)
            If IsdbNull(rs7231!K7231_seSpecGroup4) = False Then D7231.seSpecGroup4 = Trim$(rs7231!K7231_seSpecGroup4)
            If IsdbNull(rs7231!K7231_cdSpecGroup4) = False Then D7231.cdSpecGroup4 = Trim$(rs7231!K7231_cdSpecGroup4)
            If IsdbNull(rs7231!K7231_seSpecGroup5) = False Then D7231.seSpecGroup5 = Trim$(rs7231!K7231_seSpecGroup5)
            If IsdbNull(rs7231!K7231_cdSpecGroup5) = False Then D7231.cdSpecGroup5 = Trim$(rs7231!K7231_cdSpecGroup5)
            If IsdbNull(rs7231!K7231_seUnitMaterial) = False Then D7231.seUnitMaterial = Trim$(rs7231!K7231_seUnitMaterial)
            If IsdbNull(rs7231!K7231_cdUnitMaterial) = False Then D7231.cdUnitMaterial = Trim$(rs7231!K7231_cdUnitMaterial)
            If IsdbNull(rs7231!K7231_seUnitPacking) = False Then D7231.seUnitPacking = Trim$(rs7231!K7231_seUnitPacking)
            If IsdbNull(rs7231!K7231_cdUnitPacking) = False Then D7231.cdUnitPacking = Trim$(rs7231!K7231_cdUnitPacking)
            If IsdbNull(rs7231!K7231_seTax) = False Then D7231.seTax = Trim$(rs7231!K7231_seTax)
            If IsdbNull(rs7231!K7231_cdTax) = False Then D7231.cdTax = Trim$(rs7231!K7231_cdTax)
            If IsdbNull(rs7231!K7231_PerTaxImport) = False Then D7231.PerTaxImport = Trim$(rs7231!K7231_PerTaxImport)
            If IsdbNull(rs7231!K7231_PerTaxVAT) = False Then D7231.PerTaxVAT = Trim$(rs7231!K7231_PerTaxVAT)
            If IsdbNull(rs7231!K7231_QtyBasic) = False Then D7231.QtyBasic = Trim$(rs7231!K7231_QtyBasic)
            If IsdbNull(rs7231!K7231_QtyOptimum) = False Then D7231.QtyOptimum = Trim$(rs7231!K7231_QtyOptimum)
            If IsdbNull(rs7231!K7231_DayOptimum) = False Then D7231.DayOptimum = Trim$(rs7231!K7231_DayOptimum)
            If IsdbNull(rs7231!K7231_DayEstimate) = False Then D7231.DayEstimate = Trim$(rs7231!K7231_DayEstimate)
            If IsdbNull(rs7231!K7231_PriceMaterial) = False Then D7231.PriceMaterial = Trim$(rs7231!K7231_PriceMaterial)
            If IsdbNull(rs7231!K7231_QtyMOQ) = False Then D7231.QtyMOQ = Trim$(rs7231!K7231_QtyMOQ)
            If IsdbNull(rs7231!K7231_MaxInventory) = False Then D7231.MaxInventory = Trim$(rs7231!K7231_MaxInventory)
            If IsdbNull(rs7231!K7231_MinInventory) = False Then D7231.MinInventory = Trim$(rs7231!K7231_MinInventory)
            If IsdbNull(rs7231!K7231_ReOrderQty) = False Then D7231.ReOrderQty = Trim$(rs7231!K7231_ReOrderQty)
            If IsdbNull(rs7231!K7231_CheckDevRnD) = False Then D7231.CheckDevRnD = Trim$(rs7231!K7231_CheckDevRnD)
            If IsdbNull(rs7231!K7231_StatusMaterial) = False Then D7231.StatusMaterial = Trim$(rs7231!K7231_StatusMaterial)
            If IsdbNull(rs7231!K7231_BOMType) = False Then D7231.BOMType = Trim$(rs7231!K7231_BOMType)
            If IsdbNull(rs7231!K7231_ApplyType) = False Then D7231.ApplyType = Trim$(rs7231!K7231_ApplyType)
            If IsdbNull(rs7231!K7231_DateStart) = False Then D7231.DateStart = Trim$(rs7231!K7231_DateStart)
            If IsdbNull(rs7231!K7231_DateOptimum) = False Then D7231.DateOptimum = Trim$(rs7231!K7231_DateOptimum)
            If IsdbNull(rs7231!K7231_DateEstimate) = False Then D7231.DateEstimate = Trim$(rs7231!K7231_DateEstimate)
            If IsdbNull(rs7231!K7231_DateInBound) = False Then D7231.DateInBound = Trim$(rs7231!K7231_DateInBound)
            If IsdbNull(rs7231!K7231_DateOutBound) = False Then D7231.DateOutBound = Trim$(rs7231!K7231_DateOutBound)
            If IsdbNull(rs7231!K7231_SupplyName) = False Then D7231.SupplyName = Trim$(rs7231!K7231_SupplyName)
            If IsdbNull(rs7231!K7231_SupplyCode) = False Then D7231.SupplyCode = Trim$(rs7231!K7231_SupplyCode)
            If IsdbNull(rs7231!K7231_SalesCode) = False Then D7231.SalesCode = Trim$(rs7231!K7231_SalesCode)
            If IsdbNull(rs7231!K7231_Check1) = False Then D7231.Check1 = Trim$(rs7231!K7231_Check1)
            If IsdbNull(rs7231!K7231_Check2) = False Then D7231.Check2 = Trim$(rs7231!K7231_Check2)
            If IsdbNull(rs7231!K7231_Check3) = False Then D7231.Check3 = Trim$(rs7231!K7231_Check3)
            If IsdbNull(rs7231!K7231_Check4) = False Then D7231.Check4 = Trim$(rs7231!K7231_Check4)
            If IsdbNull(rs7231!K7231_Check5) = False Then D7231.Check5 = Trim$(rs7231!K7231_Check5)
            If IsdbNull(rs7231!K7231_Check6) = False Then D7231.Check6 = Trim$(rs7231!K7231_Check6)
            If IsdbNull(rs7231!K7231_Check7) = False Then D7231.Check7 = Trim$(rs7231!K7231_Check7)
            If IsdbNull(rs7231!K7231_Check8) = False Then D7231.Check8 = Trim$(rs7231!K7231_Check8)
            If IsdbNull(rs7231!K7231_Check9) = False Then D7231.Check9 = Trim$(rs7231!K7231_Check9)
            If IsdbNull(rs7231!K7231_Check10) = False Then D7231.Check10 = Trim$(rs7231!K7231_Check10)
            If IsdbNull(rs7231!K7231_CheckName1) = False Then D7231.CheckName1 = Trim$(rs7231!K7231_CheckName1)
            If IsdbNull(rs7231!K7231_CheckName2) = False Then D7231.CheckName2 = Trim$(rs7231!K7231_CheckName2)
            If IsdbNull(rs7231!K7231_CheckName3) = False Then D7231.CheckName3 = Trim$(rs7231!K7231_CheckName3)
            If IsdbNull(rs7231!K7231_CheckName4) = False Then D7231.CheckName4 = Trim$(rs7231!K7231_CheckName4)
            If IsdbNull(rs7231!K7231_CheckName5) = False Then D7231.CheckName5 = Trim$(rs7231!K7231_CheckName5)
            If IsdbNull(rs7231!K7231_CheckName6) = False Then D7231.CheckName6 = Trim$(rs7231!K7231_CheckName6)
            If IsdbNull(rs7231!K7231_CheckName7) = False Then D7231.CheckName7 = Trim$(rs7231!K7231_CheckName7)
            If IsdbNull(rs7231!K7231_CheckName8) = False Then D7231.CheckName8 = Trim$(rs7231!K7231_CheckName8)
            If IsdbNull(rs7231!K7231_CheckName9) = False Then D7231.CheckName9 = Trim$(rs7231!K7231_CheckName9)
            If IsdbNull(rs7231!K7231_CheckName10) = False Then D7231.CheckName10 = Trim$(rs7231!K7231_CheckName10)
            If IsdbNull(rs7231!K7231_ACodeMaterial) = False Then D7231.ACodeMaterial = Trim$(rs7231!K7231_ACodeMaterial)
            If IsdbNull(rs7231!K7231_ACodeTax1) = False Then D7231.ACodeTax1 = Trim$(rs7231!K7231_ACodeTax1)
            If IsdbNull(rs7231!K7231_ACodeTax2) = False Then D7231.ACodeTax2 = Trim$(rs7231!K7231_ACodeTax2)
            If IsdbNull(rs7231!K7231_ACodeTax3) = False Then D7231.ACodeTax3 = Trim$(rs7231!K7231_ACodeTax3)
            If IsdbNull(rs7231!K7231_ACodeSales) = False Then D7231.ACodeSales = Trim$(rs7231!K7231_ACodeSales)
            If IsdbNull(rs7231!K7231_ACodeIntSales) = False Then D7231.ACodeIntSales = Trim$(rs7231!K7231_ACodeIntSales)
            If IsdbNull(rs7231!K7231_ACodeCOGS) = False Then D7231.ACodeCOGS = Trim$(rs7231!K7231_ACodeCOGS)
            If IsdbNull(rs7231!K7231_ACodeReturn) = False Then D7231.ACodeReturn = Trim$(rs7231!K7231_ACodeReturn)
            If IsdbNull(rs7231!K7231_ACodeDiscount) = False Then D7231.ACodeDiscount = Trim$(rs7231!K7231_ACodeDiscount)
            If IsdbNull(rs7231!K7231_ACodeWIP) = False Then D7231.ACodeWIP = Trim$(rs7231!K7231_ACodeWIP)
            If IsdbNull(rs7231!K7231_CheckInventory) = False Then D7231.CheckInventory = Trim$(rs7231!K7231_CheckInventory)
            If IsdbNull(rs7231!K7231_CheckPosition) = False Then D7231.CheckPosition = Trim$(rs7231!K7231_CheckPosition)
            If IsdbNull(rs7231!K7231_CheckLotNo) = False Then D7231.CheckLotNo = Trim$(rs7231!K7231_CheckLotNo)
            If IsdbNull(rs7231!K7231_CheckPrice) = False Then D7231.CheckPrice = Trim$(rs7231!K7231_CheckPrice)
            If IsdbNull(rs7231!K7231_seTax1) = False Then D7231.seTax1 = Trim$(rs7231!K7231_seTax1)
            If IsdbNull(rs7231!K7231_cdTax1) = False Then D7231.cdTax1 = Trim$(rs7231!K7231_cdTax1)
            If IsdbNull(rs7231!K7231_PerTax1) = False Then D7231.PerTax1 = Trim$(rs7231!K7231_PerTax1)
            If IsdbNull(rs7231!K7231_seTax2) = False Then D7231.seTax2 = Trim$(rs7231!K7231_seTax2)
            If IsdbNull(rs7231!K7231_cdTax2) = False Then D7231.cdTax2 = Trim$(rs7231!K7231_cdTax2)
            If IsdbNull(rs7231!K7231_PerTax2) = False Then D7231.PerTax2 = Trim$(rs7231!K7231_PerTax2)
            If IsdbNull(rs7231!K7231_seTax3) = False Then D7231.seTax3 = Trim$(rs7231!K7231_seTax3)
            If IsdbNull(rs7231!K7231_cdTax3) = False Then D7231.cdTax3 = Trim$(rs7231!K7231_cdTax3)
            If IsdbNull(rs7231!K7231_PerTax3) = False Then D7231.PerTax3 = Trim$(rs7231!K7231_PerTax3)
            If IsdbNull(rs7231!K7231_seTaxVAT) = False Then D7231.seTaxVAT = Trim$(rs7231!K7231_seTaxVAT)
            If IsdbNull(rs7231!K7231_cdTaxVAT) = False Then D7231.cdTaxVAT = Trim$(rs7231!K7231_cdTaxVAT)
            If IsdbNull(rs7231!K7231_seTaxImport) = False Then D7231.seTaxImport = Trim$(rs7231!K7231_seTaxImport)
            If IsdbNull(rs7231!K7231_cdTaxImport) = False Then D7231.cdTaxImport = Trim$(rs7231!K7231_cdTaxImport)
            If IsdbNull(rs7231!K7231_seTaxExport) = False Then D7231.seTaxExport = Trim$(rs7231!K7231_seTaxExport)
            If IsdbNull(rs7231!K7231_cdTaxExport) = False Then D7231.cdTaxExport = Trim$(rs7231!K7231_cdTaxExport)
            If IsdbNull(rs7231!K7231_seTaxSpecial) = False Then D7231.seTaxSpecial = Trim$(rs7231!K7231_seTaxSpecial)
            If IsdbNull(rs7231!K7231_cdTaxSpecial) = False Then D7231.cdTaxSpecial = Trim$(rs7231!K7231_cdTaxSpecial)
            If IsdbNull(rs7231!K7231_seAccMaterial) = False Then D7231.seAccMaterial = Trim$(rs7231!K7231_seAccMaterial)
            If IsdbNull(rs7231!K7231_cdAccMaterial) = False Then D7231.cdAccMaterial = Trim$(rs7231!K7231_cdAccMaterial)
            If IsdbNull(rs7231!K7231_seAccSales) = False Then D7231.seAccSales = Trim$(rs7231!K7231_seAccSales)
            If IsdbNull(rs7231!K7231_cdAccSales) = False Then D7231.cdAccSales = Trim$(rs7231!K7231_cdAccSales)
            If IsdbNull(rs7231!K7231_seAccIntSales) = False Then D7231.seAccIntSales = Trim$(rs7231!K7231_seAccIntSales)
            If IsdbNull(rs7231!K7231_cdAccIntSales) = False Then D7231.cdAccIntSales = Trim$(rs7231!K7231_cdAccIntSales)
            If IsdbNull(rs7231!K7231_seAccCOGS) = False Then D7231.seAccCOGS = Trim$(rs7231!K7231_seAccCOGS)
            If IsdbNull(rs7231!K7231_cdAccCOGS) = False Then D7231.cdAccCOGS = Trim$(rs7231!K7231_cdAccCOGS)
            If IsdbNull(rs7231!K7231_seAccReturn) = False Then D7231.seAccReturn = Trim$(rs7231!K7231_seAccReturn)
            If IsdbNull(rs7231!K7231_cdAccReturn) = False Then D7231.cdAccReturn = Trim$(rs7231!K7231_cdAccReturn)
            If IsdbNull(rs7231!K7231_seAccDiscount) = False Then D7231.seAccDiscount = Trim$(rs7231!K7231_seAccDiscount)
            If IsdbNull(rs7231!K7231_cdAccDiscount) = False Then D7231.cdAccDiscount = Trim$(rs7231!K7231_cdAccDiscount)
            If IsdbNull(rs7231!K7231_seAccWIP) = False Then D7231.seAccWIP = Trim$(rs7231!K7231_seAccWIP)
            If IsdbNull(rs7231!K7231_cdAccWIP) = False Then D7231.cdAccWIP = Trim$(rs7231!K7231_cdAccWIP)
            If IsdbNull(rs7231!K7231_DateInsert) = False Then D7231.DateInsert = Trim$(rs7231!K7231_DateInsert)
            If IsdbNull(rs7231!K7231_DateUpdate) = False Then D7231.DateUpdate = Trim$(rs7231!K7231_DateUpdate)
            If IsdbNull(rs7231!K7231_InchargeInsert) = False Then D7231.InchargeInsert = Trim$(rs7231!K7231_InchargeInsert)
            If IsdbNull(rs7231!K7231_InchargeUpdate) = False Then D7231.InchargeUpdate = Trim$(rs7231!K7231_InchargeUpdate)
            If IsdbNull(rs7231!K7231_InchargeComplete) = False Then D7231.InchargeComplete = Trim$(rs7231!K7231_InchargeComplete)
            If IsdbNull(rs7231!K7231_InchargeCancel) = False Then D7231.InchargeCancel = Trim$(rs7231!K7231_InchargeCancel)
            If IsdbNull(rs7231!K7231_InchargeApproved) = False Then D7231.InchargeApproved = Trim$(rs7231!K7231_InchargeApproved)
            If IsdbNull(rs7231!K7231_InchargePending1) = False Then D7231.InchargePending1 = Trim$(rs7231!K7231_InchargePending1)
            If IsdbNull(rs7231!K7231_InchargePending2) = False Then D7231.InchargePending2 = Trim$(rs7231!K7231_InchargePending2)
            If IsdbNull(rs7231!K7231_CheckUse) = False Then D7231.CheckUse = Trim$(rs7231!K7231_CheckUse)
            If IsdbNull(rs7231!K7231_DateActive) = False Then D7231.DateActive = Trim$(rs7231!K7231_DateActive)
            If IsdbNull(rs7231!K7231_DateDeactive) = False Then D7231.DateDeactive = Trim$(rs7231!K7231_DateDeactive)
            If IsdbNull(rs7231!K7231_CheckActive) = False Then D7231.CheckActive = Trim$(rs7231!K7231_CheckActive)
            If IsdbNull(rs7231!K7231_DateComplete) = False Then D7231.DateComplete = Trim$(rs7231!K7231_DateComplete)
            If IsdbNull(rs7231!K7231_DateApproved) = False Then D7231.DateApproved = Trim$(rs7231!K7231_DateApproved)
            If IsdbNull(rs7231!K7231_DateCancel) = False Then D7231.DateCancel = Trim$(rs7231!K7231_DateCancel)
            If IsdbNull(rs7231!K7231_DatePending1) = False Then D7231.DatePending1 = Trim$(rs7231!K7231_DatePending1)
            If IsdbNull(rs7231!K7231_DatePending2) = False Then D7231.DatePending2 = Trim$(rs7231!K7231_DatePending2)
            If IsdbNull(rs7231!K7231_CheckSync) = False Then D7231.CheckSync = Trim$(rs7231!K7231_CheckSync)
            If IsdbNull(rs7231!K7231_MaterialFullName) = False Then D7231.MaterialFullName = Trim$(rs7231!K7231_MaterialFullName)
            If IsdbNull(rs7231!K7231_MaterialOldName) = False Then D7231.MaterialOldName = Trim$(rs7231!K7231_MaterialOldName)
            If IsdbNull(rs7231!K7231_Remark) = False Then D7231.Remark = Trim$(rs7231!K7231_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K7231_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K7231_MOVE(rs7231 As DataRow)
        Try

            Call D7231_CLEAR()

            If IsdbNull(rs7231!K7231_MaterialCode) = False Then D7231.MaterialCode = Trim$(rs7231!K7231_MaterialCode)
            If IsdbNull(rs7231!K7231_MaterialName) = False Then D7231.MaterialName = Trim$(rs7231!K7231_MaterialName)
            If IsdbNull(rs7231!K7231_MaterialPName) = False Then D7231.MaterialPName = Trim$(rs7231!K7231_MaterialPName)
            If IsdbNull(rs7231!K7231_MaterialSimple) = False Then D7231.MaterialSimple = Trim$(rs7231!K7231_MaterialSimple)
            If IsdbNull(rs7231!K7231_MaterialColor) = False Then D7231.MaterialColor = Trim$(rs7231!K7231_MaterialColor)
            If IsdbNull(rs7231!K7231_seImportGroup) = False Then D7231.seImportGroup = Trim$(rs7231!K7231_seImportGroup)
            If IsdbNull(rs7231!K7231_cdImportGroup) = False Then D7231.cdImportGroup = Trim$(rs7231!K7231_cdImportGroup)
            If IsdbNull(rs7231!K7231_ImportCode) = False Then D7231.ImportCode = Trim$(rs7231!K7231_ImportCode)
            If IsDBNull(rs7231!K7231_ImportName) = False Then D7231.ImportName = Trim$(rs7231!K7231_ImportName)
            If IsDBNull(rs7231!K7231_ImportCode1) = False Then D7231.ImportCode1 = Trim$(rs7231!K7231_ImportCode1)
            If IsDBNull(rs7231!K7231_ImportName1) = False Then D7231.ImportName1 = Trim$(rs7231!K7231_ImportName1)
            If IsdbNull(rs7231!K7231_AccountCode) = False Then D7231.AccountCode = Trim$(rs7231!K7231_AccountCode)
            If IsdbNull(rs7231!K7231_AccountName) = False Then D7231.AccountName = Trim$(rs7231!K7231_AccountName)
            If IsdbNull(rs7231!K7231_OtherCode1) = False Then D7231.OtherCode1 = Trim$(rs7231!K7231_OtherCode1)
            If IsdbNull(rs7231!K7231_OtherCode2) = False Then D7231.OtherCode2 = Trim$(rs7231!K7231_OtherCode2)
            If IsdbNull(rs7231!K7231_DevelopmentCode) = False Then D7231.DevelopmentCode = Trim$(rs7231!K7231_DevelopmentCode)
            If IsdbNull(rs7231!K7231_DevelopmentName) = False Then D7231.DevelopmentName = Trim$(rs7231!K7231_DevelopmentName)
            If IsdbNull(rs7231!K7231_MaterialForeign1) = False Then D7231.MaterialForeign1 = Trim$(rs7231!K7231_MaterialForeign1)
            If IsdbNull(rs7231!K7231_MaterialForeign2) = False Then D7231.MaterialForeign2 = Trim$(rs7231!K7231_MaterialForeign2)
            If IsdbNull(rs7231!K7231_Width) = False Then D7231.Width = Trim$(rs7231!K7231_Width)
            If IsdbNull(rs7231!K7231_Height) = False Then D7231.Height = Trim$(rs7231!K7231_Height)
            If IsdbNull(rs7231!K7231_SizeName) = False Then D7231.SizeName = Trim$(rs7231!K7231_SizeName)
            If IsdbNull(rs7231!K7231_CheckPrint) = False Then D7231.CheckPrint = Trim$(rs7231!K7231_CheckPrint)
            If IsdbNull(rs7231!K7231_CheckSP) = False Then D7231.CheckSP = Trim$(rs7231!K7231_CheckSP)
            If IsdbNull(rs7231!K7231_seSpecial) = False Then D7231.seSpecial = Trim$(rs7231!K7231_seSpecial)
            If IsdbNull(rs7231!K7231_cdSpecial) = False Then D7231.cdSpecial = Trim$(rs7231!K7231_cdSpecial)
            If IsdbNull(rs7231!K7231_SizeRangeTool) = False Then D7231.SizeRangeTool = Trim$(rs7231!K7231_SizeRangeTool)
            If IsdbNull(rs7231!K7231_CheckKindMaterial) = False Then D7231.CheckKindMaterial = Trim$(rs7231!K7231_CheckKindMaterial)
            If IsdbNull(rs7231!K7231_CheckMarketType) = False Then D7231.CheckMarketType = Trim$(rs7231!K7231_CheckMarketType)
            If IsdbNull(rs7231!K7231_seUnitPrice) = False Then D7231.seUnitPrice = Trim$(rs7231!K7231_seUnitPrice)
            If IsdbNull(rs7231!K7231_cdUnitPrice) = False Then D7231.cdUnitPrice = Trim$(rs7231!K7231_cdUnitPrice)
            If IsdbNull(rs7231!K7231_DateExchangePrice) = False Then D7231.DateExchangePrice = Trim$(rs7231!K7231_DateExchangePrice)
            If IsdbNull(rs7231!K7231_ExchangePrice) = False Then D7231.ExchangePrice = Trim$(rs7231!K7231_ExchangePrice)
            If IsdbNull(rs7231!K7231_PriceUSD) = False Then D7231.PriceUSD = Trim$(rs7231!K7231_PriceUSD)
            If IsdbNull(rs7231!K7231_PriceVND) = False Then D7231.PriceVND = Trim$(rs7231!K7231_PriceVND)
            If IsdbNull(rs7231!K7231_seDepartment) = False Then D7231.seDepartment = Trim$(rs7231!K7231_seDepartment)
            If IsdbNull(rs7231!K7231_cdDepartment) = False Then D7231.cdDepartment = Trim$(rs7231!K7231_cdDepartment)
            If IsdbNull(rs7231!K7231_seLargeGroupMaterial) = False Then D7231.seLargeGroupMaterial = Trim$(rs7231!K7231_seLargeGroupMaterial)
            If IsdbNull(rs7231!K7231_cdLargeGroupMaterial) = False Then D7231.cdLargeGroupMaterial = Trim$(rs7231!K7231_cdLargeGroupMaterial)
            If IsdbNull(rs7231!K7231_seSemiGroupMaterial) = False Then D7231.seSemiGroupMaterial = Trim$(rs7231!K7231_seSemiGroupMaterial)
            If IsdbNull(rs7231!K7231_cdSemiGroupMaterial) = False Then D7231.cdSemiGroupMaterial = Trim$(rs7231!K7231_cdSemiGroupMaterial)
            If IsdbNull(rs7231!K7231_seDetailGroupMaterial) = False Then D7231.seDetailGroupMaterial = Trim$(rs7231!K7231_seDetailGroupMaterial)
            If IsdbNull(rs7231!K7231_cdDetailGroupMaterial) = False Then D7231.cdDetailGroupMaterial = Trim$(rs7231!K7231_cdDetailGroupMaterial)
            If IsdbNull(rs7231!K7231_seSpecGroup1) = False Then D7231.seSpecGroup1 = Trim$(rs7231!K7231_seSpecGroup1)
            If IsdbNull(rs7231!K7231_cdSpecGroup1) = False Then D7231.cdSpecGroup1 = Trim$(rs7231!K7231_cdSpecGroup1)
            If IsdbNull(rs7231!K7231_seSpecGroup2) = False Then D7231.seSpecGroup2 = Trim$(rs7231!K7231_seSpecGroup2)
            If IsdbNull(rs7231!K7231_cdSpecGroup2) = False Then D7231.cdSpecGroup2 = Trim$(rs7231!K7231_cdSpecGroup2)
            If IsdbNull(rs7231!K7231_seSpecGroup3) = False Then D7231.seSpecGroup3 = Trim$(rs7231!K7231_seSpecGroup3)
            If IsdbNull(rs7231!K7231_cdSpecGroup3) = False Then D7231.cdSpecGroup3 = Trim$(rs7231!K7231_cdSpecGroup3)
            If IsdbNull(rs7231!K7231_seSpecGroup4) = False Then D7231.seSpecGroup4 = Trim$(rs7231!K7231_seSpecGroup4)
            If IsdbNull(rs7231!K7231_cdSpecGroup4) = False Then D7231.cdSpecGroup4 = Trim$(rs7231!K7231_cdSpecGroup4)
            If IsdbNull(rs7231!K7231_seSpecGroup5) = False Then D7231.seSpecGroup5 = Trim$(rs7231!K7231_seSpecGroup5)
            If IsdbNull(rs7231!K7231_cdSpecGroup5) = False Then D7231.cdSpecGroup5 = Trim$(rs7231!K7231_cdSpecGroup5)
            If IsdbNull(rs7231!K7231_seUnitMaterial) = False Then D7231.seUnitMaterial = Trim$(rs7231!K7231_seUnitMaterial)
            If IsdbNull(rs7231!K7231_cdUnitMaterial) = False Then D7231.cdUnitMaterial = Trim$(rs7231!K7231_cdUnitMaterial)
            If IsdbNull(rs7231!K7231_seUnitPacking) = False Then D7231.seUnitPacking = Trim$(rs7231!K7231_seUnitPacking)
            If IsdbNull(rs7231!K7231_cdUnitPacking) = False Then D7231.cdUnitPacking = Trim$(rs7231!K7231_cdUnitPacking)
            If IsdbNull(rs7231!K7231_seTax) = False Then D7231.seTax = Trim$(rs7231!K7231_seTax)
            If IsdbNull(rs7231!K7231_cdTax) = False Then D7231.cdTax = Trim$(rs7231!K7231_cdTax)
            If IsdbNull(rs7231!K7231_PerTaxImport) = False Then D7231.PerTaxImport = Trim$(rs7231!K7231_PerTaxImport)
            If IsdbNull(rs7231!K7231_PerTaxVAT) = False Then D7231.PerTaxVAT = Trim$(rs7231!K7231_PerTaxVAT)
            If IsdbNull(rs7231!K7231_QtyBasic) = False Then D7231.QtyBasic = Trim$(rs7231!K7231_QtyBasic)
            If IsdbNull(rs7231!K7231_QtyOptimum) = False Then D7231.QtyOptimum = Trim$(rs7231!K7231_QtyOptimum)
            If IsdbNull(rs7231!K7231_DayOptimum) = False Then D7231.DayOptimum = Trim$(rs7231!K7231_DayOptimum)
            If IsdbNull(rs7231!K7231_DayEstimate) = False Then D7231.DayEstimate = Trim$(rs7231!K7231_DayEstimate)
            If IsdbNull(rs7231!K7231_PriceMaterial) = False Then D7231.PriceMaterial = Trim$(rs7231!K7231_PriceMaterial)
            If IsdbNull(rs7231!K7231_QtyMOQ) = False Then D7231.QtyMOQ = Trim$(rs7231!K7231_QtyMOQ)
            If IsdbNull(rs7231!K7231_MaxInventory) = False Then D7231.MaxInventory = Trim$(rs7231!K7231_MaxInventory)
            If IsdbNull(rs7231!K7231_MinInventory) = False Then D7231.MinInventory = Trim$(rs7231!K7231_MinInventory)
            If IsdbNull(rs7231!K7231_ReOrderQty) = False Then D7231.ReOrderQty = Trim$(rs7231!K7231_ReOrderQty)
            If IsdbNull(rs7231!K7231_CheckDevRnD) = False Then D7231.CheckDevRnD = Trim$(rs7231!K7231_CheckDevRnD)
            If IsdbNull(rs7231!K7231_StatusMaterial) = False Then D7231.StatusMaterial = Trim$(rs7231!K7231_StatusMaterial)
            If IsdbNull(rs7231!K7231_BOMType) = False Then D7231.BOMType = Trim$(rs7231!K7231_BOMType)
            If IsdbNull(rs7231!K7231_ApplyType) = False Then D7231.ApplyType = Trim$(rs7231!K7231_ApplyType)
            If IsdbNull(rs7231!K7231_DateStart) = False Then D7231.DateStart = Trim$(rs7231!K7231_DateStart)
            If IsdbNull(rs7231!K7231_DateOptimum) = False Then D7231.DateOptimum = Trim$(rs7231!K7231_DateOptimum)
            If IsdbNull(rs7231!K7231_DateEstimate) = False Then D7231.DateEstimate = Trim$(rs7231!K7231_DateEstimate)
            If IsdbNull(rs7231!K7231_DateInBound) = False Then D7231.DateInBound = Trim$(rs7231!K7231_DateInBound)
            If IsdbNull(rs7231!K7231_DateOutBound) = False Then D7231.DateOutBound = Trim$(rs7231!K7231_DateOutBound)
            If IsdbNull(rs7231!K7231_SupplyName) = False Then D7231.SupplyName = Trim$(rs7231!K7231_SupplyName)
            If IsdbNull(rs7231!K7231_SupplyCode) = False Then D7231.SupplyCode = Trim$(rs7231!K7231_SupplyCode)
            If IsdbNull(rs7231!K7231_SalesCode) = False Then D7231.SalesCode = Trim$(rs7231!K7231_SalesCode)
            If IsdbNull(rs7231!K7231_Check1) = False Then D7231.Check1 = Trim$(rs7231!K7231_Check1)
            If IsdbNull(rs7231!K7231_Check2) = False Then D7231.Check2 = Trim$(rs7231!K7231_Check2)
            If IsdbNull(rs7231!K7231_Check3) = False Then D7231.Check3 = Trim$(rs7231!K7231_Check3)
            If IsdbNull(rs7231!K7231_Check4) = False Then D7231.Check4 = Trim$(rs7231!K7231_Check4)
            If IsdbNull(rs7231!K7231_Check5) = False Then D7231.Check5 = Trim$(rs7231!K7231_Check5)
            If IsdbNull(rs7231!K7231_Check6) = False Then D7231.Check6 = Trim$(rs7231!K7231_Check6)
            If IsdbNull(rs7231!K7231_Check7) = False Then D7231.Check7 = Trim$(rs7231!K7231_Check7)
            If IsdbNull(rs7231!K7231_Check8) = False Then D7231.Check8 = Trim$(rs7231!K7231_Check8)
            If IsdbNull(rs7231!K7231_Check9) = False Then D7231.Check9 = Trim$(rs7231!K7231_Check9)
            If IsdbNull(rs7231!K7231_Check10) = False Then D7231.Check10 = Trim$(rs7231!K7231_Check10)
            If IsdbNull(rs7231!K7231_CheckName1) = False Then D7231.CheckName1 = Trim$(rs7231!K7231_CheckName1)
            If IsdbNull(rs7231!K7231_CheckName2) = False Then D7231.CheckName2 = Trim$(rs7231!K7231_CheckName2)
            If IsdbNull(rs7231!K7231_CheckName3) = False Then D7231.CheckName3 = Trim$(rs7231!K7231_CheckName3)
            If IsdbNull(rs7231!K7231_CheckName4) = False Then D7231.CheckName4 = Trim$(rs7231!K7231_CheckName4)
            If IsdbNull(rs7231!K7231_CheckName5) = False Then D7231.CheckName5 = Trim$(rs7231!K7231_CheckName5)
            If IsdbNull(rs7231!K7231_CheckName6) = False Then D7231.CheckName6 = Trim$(rs7231!K7231_CheckName6)
            If IsdbNull(rs7231!K7231_CheckName7) = False Then D7231.CheckName7 = Trim$(rs7231!K7231_CheckName7)
            If IsdbNull(rs7231!K7231_CheckName8) = False Then D7231.CheckName8 = Trim$(rs7231!K7231_CheckName8)
            If IsdbNull(rs7231!K7231_CheckName9) = False Then D7231.CheckName9 = Trim$(rs7231!K7231_CheckName9)
            If IsdbNull(rs7231!K7231_CheckName10) = False Then D7231.CheckName10 = Trim$(rs7231!K7231_CheckName10)
            If IsdbNull(rs7231!K7231_ACodeMaterial) = False Then D7231.ACodeMaterial = Trim$(rs7231!K7231_ACodeMaterial)
            If IsdbNull(rs7231!K7231_ACodeTax1) = False Then D7231.ACodeTax1 = Trim$(rs7231!K7231_ACodeTax1)
            If IsdbNull(rs7231!K7231_ACodeTax2) = False Then D7231.ACodeTax2 = Trim$(rs7231!K7231_ACodeTax2)
            If IsdbNull(rs7231!K7231_ACodeTax3) = False Then D7231.ACodeTax3 = Trim$(rs7231!K7231_ACodeTax3)
            If IsdbNull(rs7231!K7231_ACodeSales) = False Then D7231.ACodeSales = Trim$(rs7231!K7231_ACodeSales)
            If IsdbNull(rs7231!K7231_ACodeIntSales) = False Then D7231.ACodeIntSales = Trim$(rs7231!K7231_ACodeIntSales)
            If IsdbNull(rs7231!K7231_ACodeCOGS) = False Then D7231.ACodeCOGS = Trim$(rs7231!K7231_ACodeCOGS)
            If IsdbNull(rs7231!K7231_ACodeReturn) = False Then D7231.ACodeReturn = Trim$(rs7231!K7231_ACodeReturn)
            If IsdbNull(rs7231!K7231_ACodeDiscount) = False Then D7231.ACodeDiscount = Trim$(rs7231!K7231_ACodeDiscount)
            If IsdbNull(rs7231!K7231_ACodeWIP) = False Then D7231.ACodeWIP = Trim$(rs7231!K7231_ACodeWIP)
            If IsdbNull(rs7231!K7231_CheckInventory) = False Then D7231.CheckInventory = Trim$(rs7231!K7231_CheckInventory)
            If IsdbNull(rs7231!K7231_CheckPosition) = False Then D7231.CheckPosition = Trim$(rs7231!K7231_CheckPosition)
            If IsdbNull(rs7231!K7231_CheckLotNo) = False Then D7231.CheckLotNo = Trim$(rs7231!K7231_CheckLotNo)
            If IsdbNull(rs7231!K7231_CheckPrice) = False Then D7231.CheckPrice = Trim$(rs7231!K7231_CheckPrice)
            If IsdbNull(rs7231!K7231_seTax1) = False Then D7231.seTax1 = Trim$(rs7231!K7231_seTax1)
            If IsdbNull(rs7231!K7231_cdTax1) = False Then D7231.cdTax1 = Trim$(rs7231!K7231_cdTax1)
            If IsdbNull(rs7231!K7231_PerTax1) = False Then D7231.PerTax1 = Trim$(rs7231!K7231_PerTax1)
            If IsdbNull(rs7231!K7231_seTax2) = False Then D7231.seTax2 = Trim$(rs7231!K7231_seTax2)
            If IsdbNull(rs7231!K7231_cdTax2) = False Then D7231.cdTax2 = Trim$(rs7231!K7231_cdTax2)
            If IsdbNull(rs7231!K7231_PerTax2) = False Then D7231.PerTax2 = Trim$(rs7231!K7231_PerTax2)
            If IsdbNull(rs7231!K7231_seTax3) = False Then D7231.seTax3 = Trim$(rs7231!K7231_seTax3)
            If IsdbNull(rs7231!K7231_cdTax3) = False Then D7231.cdTax3 = Trim$(rs7231!K7231_cdTax3)
            If IsdbNull(rs7231!K7231_PerTax3) = False Then D7231.PerTax3 = Trim$(rs7231!K7231_PerTax3)
            If IsdbNull(rs7231!K7231_seTaxVAT) = False Then D7231.seTaxVAT = Trim$(rs7231!K7231_seTaxVAT)
            If IsdbNull(rs7231!K7231_cdTaxVAT) = False Then D7231.cdTaxVAT = Trim$(rs7231!K7231_cdTaxVAT)
            If IsdbNull(rs7231!K7231_seTaxImport) = False Then D7231.seTaxImport = Trim$(rs7231!K7231_seTaxImport)
            If IsdbNull(rs7231!K7231_cdTaxImport) = False Then D7231.cdTaxImport = Trim$(rs7231!K7231_cdTaxImport)
            If IsdbNull(rs7231!K7231_seTaxExport) = False Then D7231.seTaxExport = Trim$(rs7231!K7231_seTaxExport)
            If IsdbNull(rs7231!K7231_cdTaxExport) = False Then D7231.cdTaxExport = Trim$(rs7231!K7231_cdTaxExport)
            If IsdbNull(rs7231!K7231_seTaxSpecial) = False Then D7231.seTaxSpecial = Trim$(rs7231!K7231_seTaxSpecial)
            If IsdbNull(rs7231!K7231_cdTaxSpecial) = False Then D7231.cdTaxSpecial = Trim$(rs7231!K7231_cdTaxSpecial)
            If IsdbNull(rs7231!K7231_seAccMaterial) = False Then D7231.seAccMaterial = Trim$(rs7231!K7231_seAccMaterial)
            If IsdbNull(rs7231!K7231_cdAccMaterial) = False Then D7231.cdAccMaterial = Trim$(rs7231!K7231_cdAccMaterial)
            If IsdbNull(rs7231!K7231_seAccSales) = False Then D7231.seAccSales = Trim$(rs7231!K7231_seAccSales)
            If IsdbNull(rs7231!K7231_cdAccSales) = False Then D7231.cdAccSales = Trim$(rs7231!K7231_cdAccSales)
            If IsdbNull(rs7231!K7231_seAccIntSales) = False Then D7231.seAccIntSales = Trim$(rs7231!K7231_seAccIntSales)
            If IsdbNull(rs7231!K7231_cdAccIntSales) = False Then D7231.cdAccIntSales = Trim$(rs7231!K7231_cdAccIntSales)
            If IsdbNull(rs7231!K7231_seAccCOGS) = False Then D7231.seAccCOGS = Trim$(rs7231!K7231_seAccCOGS)
            If IsdbNull(rs7231!K7231_cdAccCOGS) = False Then D7231.cdAccCOGS = Trim$(rs7231!K7231_cdAccCOGS)
            If IsdbNull(rs7231!K7231_seAccReturn) = False Then D7231.seAccReturn = Trim$(rs7231!K7231_seAccReturn)
            If IsdbNull(rs7231!K7231_cdAccReturn) = False Then D7231.cdAccReturn = Trim$(rs7231!K7231_cdAccReturn)
            If IsdbNull(rs7231!K7231_seAccDiscount) = False Then D7231.seAccDiscount = Trim$(rs7231!K7231_seAccDiscount)
            If IsdbNull(rs7231!K7231_cdAccDiscount) = False Then D7231.cdAccDiscount = Trim$(rs7231!K7231_cdAccDiscount)
            If IsdbNull(rs7231!K7231_seAccWIP) = False Then D7231.seAccWIP = Trim$(rs7231!K7231_seAccWIP)
            If IsdbNull(rs7231!K7231_cdAccWIP) = False Then D7231.cdAccWIP = Trim$(rs7231!K7231_cdAccWIP)
            If IsdbNull(rs7231!K7231_DateInsert) = False Then D7231.DateInsert = Trim$(rs7231!K7231_DateInsert)
            If IsdbNull(rs7231!K7231_DateUpdate) = False Then D7231.DateUpdate = Trim$(rs7231!K7231_DateUpdate)
            If IsdbNull(rs7231!K7231_InchargeInsert) = False Then D7231.InchargeInsert = Trim$(rs7231!K7231_InchargeInsert)
            If IsdbNull(rs7231!K7231_InchargeUpdate) = False Then D7231.InchargeUpdate = Trim$(rs7231!K7231_InchargeUpdate)
            If IsdbNull(rs7231!K7231_InchargeComplete) = False Then D7231.InchargeComplete = Trim$(rs7231!K7231_InchargeComplete)
            If IsdbNull(rs7231!K7231_InchargeCancel) = False Then D7231.InchargeCancel = Trim$(rs7231!K7231_InchargeCancel)
            If IsdbNull(rs7231!K7231_InchargeApproved) = False Then D7231.InchargeApproved = Trim$(rs7231!K7231_InchargeApproved)
            If IsdbNull(rs7231!K7231_InchargePending1) = False Then D7231.InchargePending1 = Trim$(rs7231!K7231_InchargePending1)
            If IsdbNull(rs7231!K7231_InchargePending2) = False Then D7231.InchargePending2 = Trim$(rs7231!K7231_InchargePending2)
            If IsdbNull(rs7231!K7231_CheckUse) = False Then D7231.CheckUse = Trim$(rs7231!K7231_CheckUse)
            If IsdbNull(rs7231!K7231_DateActive) = False Then D7231.DateActive = Trim$(rs7231!K7231_DateActive)
            If IsdbNull(rs7231!K7231_DateDeactive) = False Then D7231.DateDeactive = Trim$(rs7231!K7231_DateDeactive)
            If IsdbNull(rs7231!K7231_CheckActive) = False Then D7231.CheckActive = Trim$(rs7231!K7231_CheckActive)
            If IsdbNull(rs7231!K7231_DateComplete) = False Then D7231.DateComplete = Trim$(rs7231!K7231_DateComplete)
            If IsdbNull(rs7231!K7231_DateApproved) = False Then D7231.DateApproved = Trim$(rs7231!K7231_DateApproved)
            If IsdbNull(rs7231!K7231_DateCancel) = False Then D7231.DateCancel = Trim$(rs7231!K7231_DateCancel)
            If IsdbNull(rs7231!K7231_DatePending1) = False Then D7231.DatePending1 = Trim$(rs7231!K7231_DatePending1)
            If IsdbNull(rs7231!K7231_DatePending2) = False Then D7231.DatePending2 = Trim$(rs7231!K7231_DatePending2)
            If IsdbNull(rs7231!K7231_CheckSync) = False Then D7231.CheckSync = Trim$(rs7231!K7231_CheckSync)
            If IsdbNull(rs7231!K7231_MaterialFullName) = False Then D7231.MaterialFullName = Trim$(rs7231!K7231_MaterialFullName)
            If IsdbNull(rs7231!K7231_MaterialOldName) = False Then D7231.MaterialOldName = Trim$(rs7231!K7231_MaterialOldName)
            If IsdbNull(rs7231!K7231_Remark) = False Then D7231.Remark = Trim$(rs7231!K7231_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K7231_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K7231_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z7231 As T7231_AREA, MATERIALCODE As String) As Boolean

        K7231_MOVE = False

        Try
            If READ_PFK7231(MATERIALCODE) = True Then
                z7231 = D7231
                K7231_MOVE = True
            Else
                z7231 = Nothing
            End If

            If getColumnIndex(spr, "MaterialCode") > -1 Then z7231.MaterialCode = getDataM(spr, getColumnIndex(spr, "MaterialCode"), xRow)
            If getColumnIndex(spr, "MaterialName") > -1 Then z7231.MaterialName = getDataM(spr, getColumnIndex(spr, "MaterialName"), xRow)
            If getColumnIndex(spr, "MaterialPName") > -1 Then z7231.MaterialPName = getDataM(spr, getColumnIndex(spr, "MaterialPName"), xRow)
            If getColumnIndex(spr, "MaterialSimple") > -1 Then z7231.MaterialSimple = getDataM(spr, getColumnIndex(spr, "MaterialSimple"), xRow)
            If getColumnIndex(spr, "MaterialColor") > -1 Then z7231.MaterialColor = getDataM(spr, getColumnIndex(spr, "MaterialColor"), xRow)
            If getColumnIndex(spr, "seImportGroup") > -1 Then z7231.seImportGroup = getDataM(spr, getColumnIndex(spr, "seImportGroup"), xRow)
            If getColumnIndex(spr, "cdImportGroup") > -1 Then z7231.cdImportGroup = getDataM(spr, getColumnIndex(spr, "cdImportGroup"), xRow)
            If getColumnIndex(spr, "ImportCode") > -1 Then z7231.ImportCode = getDataM(spr, getColumnIndex(spr, "ImportCode"), xRow)
            If getColumnIndex(spr, "ImportName") > -1 Then z7231.ImportName = getDataM(spr, getColumnIndex(spr, "ImportName"), xRow)
            If getColumnIndex(spr, "ImportCode1") > -1 Then z7231.ImportCode1 = getDataM(spr, getColumnIndex(spr, "ImportCode1"), xRow)
            If getColumnIndex(spr, "ImportName1") > -1 Then z7231.ImportName1 = getDataM(spr, getColumnIndex(spr, "ImportName1"), xRow)
            If getColumnIndex(spr, "AccountCode") > -1 Then z7231.AccountCode = getDataM(spr, getColumnIndex(spr, "AccountCode"), xRow)
            If getColumnIndex(spr, "AccountName") > -1 Then z7231.AccountName = getDataM(spr, getColumnIndex(spr, "AccountName"), xRow)
            If getColumnIndex(spr, "OtherCode1") > -1 Then z7231.OtherCode1 = getDataM(spr, getColumnIndex(spr, "OtherCode1"), xRow)
            If getColumnIndex(spr, "OtherCode2") > -1 Then z7231.OtherCode2 = getDataM(spr, getColumnIndex(spr, "OtherCode2"), xRow)
            If getColumnIndex(spr, "DevelopmentCode") > -1 Then z7231.DevelopmentCode = getDataM(spr, getColumnIndex(spr, "DevelopmentCode"), xRow)
            If getColumnIndex(spr, "DevelopmentName") > -1 Then z7231.DevelopmentName = getDataM(spr, getColumnIndex(spr, "DevelopmentName"), xRow)
            If getColumnIndex(spr, "MaterialForeign1") > -1 Then z7231.MaterialForeign1 = getDataM(spr, getColumnIndex(spr, "MaterialForeign1"), xRow)
            If getColumnIndex(spr, "MaterialForeign2") > -1 Then z7231.MaterialForeign2 = getDataM(spr, getColumnIndex(spr, "MaterialForeign2"), xRow)
            If getColumnIndex(spr, "Width") > -1 Then z7231.Width = getDataM(spr, getColumnIndex(spr, "Width"), xRow)
            If getColumnIndex(spr, "Height") > -1 Then z7231.Height = getDataM(spr, getColumnIndex(spr, "Height"), xRow)
            If getColumnIndex(spr, "SizeName") > -1 Then z7231.SizeName = getDataM(spr, getColumnIndex(spr, "SizeName"), xRow)
            If getColumnIndex(spr, "CheckPrint") > -1 Then z7231.CheckPrint = getDataM(spr, getColumnIndex(spr, "CheckPrint"), xRow)
            If getColumnIndex(spr, "CheckSP") > -1 Then z7231.CheckSP = getDataM(spr, getColumnIndex(spr, "CheckSP"), xRow)
            If getColumnIndex(spr, "seSpecial") > -1 Then z7231.seSpecial = getDataM(spr, getColumnIndex(spr, "seSpecial"), xRow)
            If getColumnIndex(spr, "cdSpecial") > -1 Then z7231.cdSpecial = getDataM(spr, getColumnIndex(spr, "cdSpecial"), xRow)
            If getColumnIndex(spr, "SizeRangeTool") > -1 Then z7231.SizeRangeTool = getDataM(spr, getColumnIndex(spr, "SizeRangeTool"), xRow)
            If getColumnIndex(spr, "CheckKindMaterial") > -1 Then z7231.CheckKindMaterial = getDataM(spr, getColumnIndex(spr, "CheckKindMaterial"), xRow)
            If getColumnIndex(spr, "CheckMarketType") > -1 Then z7231.CheckMarketType = getDataM(spr, getColumnIndex(spr, "CheckMarketType"), xRow)
            If getColumnIndex(spr, "seUnitPrice") > -1 Then z7231.seUnitPrice = getDataM(spr, getColumnIndex(spr, "seUnitPrice"), xRow)
            If getColumnIndex(spr, "cdUnitPrice") > -1 Then z7231.cdUnitPrice = getDataM(spr, getColumnIndex(spr, "cdUnitPrice"), xRow)
            If getColumnIndex(spr, "DateExchangePrice") > -1 Then z7231.DateExchangePrice = getDataM(spr, getColumnIndex(spr, "DateExchangePrice"), xRow)
            If getColumnIndex(spr, "ExchangePrice") > -1 Then z7231.ExchangePrice = getDataM(spr, getColumnIndex(spr, "ExchangePrice"), xRow)
            If getColumnIndex(spr, "PriceUSD") > -1 Then z7231.PriceUSD = getDataM(spr, getColumnIndex(spr, "PriceUSD"), xRow)
            If getColumnIndex(spr, "PriceVND") > -1 Then z7231.PriceVND = getDataM(spr, getColumnIndex(spr, "PriceVND"), xRow)
            If getColumnIndex(spr, "seDepartment") > -1 Then z7231.seDepartment = getDataM(spr, getColumnIndex(spr, "seDepartment"), xRow)
            If getColumnIndex(spr, "cdDepartment") > -1 Then z7231.cdDepartment = getDataM(spr, getColumnIndex(spr, "cdDepartment"), xRow)
            If getColumnIndex(spr, "seLargeGroupMaterial") > -1 Then z7231.seLargeGroupMaterial = getDataM(spr, getColumnIndex(spr, "seLargeGroupMaterial"), xRow)
            If getColumnIndex(spr, "cdLargeGroupMaterial") > -1 Then z7231.cdLargeGroupMaterial = getDataM(spr, getColumnIndex(spr, "cdLargeGroupMaterial"), xRow)
            If getColumnIndex(spr, "seSemiGroupMaterial") > -1 Then z7231.seSemiGroupMaterial = getDataM(spr, getColumnIndex(spr, "seSemiGroupMaterial"), xRow)
            If getColumnIndex(spr, "cdSemiGroupMaterial") > -1 Then z7231.cdSemiGroupMaterial = getDataM(spr, getColumnIndex(spr, "cdSemiGroupMaterial"), xRow)
            If getColumnIndex(spr, "seDetailGroupMaterial") > -1 Then z7231.seDetailGroupMaterial = getDataM(spr, getColumnIndex(spr, "seDetailGroupMaterial"), xRow)
            If getColumnIndex(spr, "cdDetailGroupMaterial") > -1 Then z7231.cdDetailGroupMaterial = getDataM(spr, getColumnIndex(spr, "cdDetailGroupMaterial"), xRow)
            If getColumnIndex(spr, "seSpecGroup1") > -1 Then z7231.seSpecGroup1 = getDataM(spr, getColumnIndex(spr, "seSpecGroup1"), xRow)
            If getColumnIndex(spr, "cdSpecGroup1") > -1 Then z7231.cdSpecGroup1 = getDataM(spr, getColumnIndex(spr, "cdSpecGroup1"), xRow)
            If getColumnIndex(spr, "seSpecGroup2") > -1 Then z7231.seSpecGroup2 = getDataM(spr, getColumnIndex(spr, "seSpecGroup2"), xRow)
            If getColumnIndex(spr, "cdSpecGroup2") > -1 Then z7231.cdSpecGroup2 = getDataM(spr, getColumnIndex(spr, "cdSpecGroup2"), xRow)
            If getColumnIndex(spr, "seSpecGroup3") > -1 Then z7231.seSpecGroup3 = getDataM(spr, getColumnIndex(spr, "seSpecGroup3"), xRow)
            If getColumnIndex(spr, "cdSpecGroup3") > -1 Then z7231.cdSpecGroup3 = getDataM(spr, getColumnIndex(spr, "cdSpecGroup3"), xRow)
            If getColumnIndex(spr, "seSpecGroup4") > -1 Then z7231.seSpecGroup4 = getDataM(spr, getColumnIndex(spr, "seSpecGroup4"), xRow)
            If getColumnIndex(spr, "cdSpecGroup4") > -1 Then z7231.cdSpecGroup4 = getDataM(spr, getColumnIndex(spr, "cdSpecGroup4"), xRow)
            If getColumnIndex(spr, "seSpecGroup5") > -1 Then z7231.seSpecGroup5 = getDataM(spr, getColumnIndex(spr, "seSpecGroup5"), xRow)
            If getColumnIndex(spr, "cdSpecGroup5") > -1 Then z7231.cdSpecGroup5 = getDataM(spr, getColumnIndex(spr, "cdSpecGroup5"), xRow)
            If getColumnIndex(spr, "seUnitMaterial") > -1 Then z7231.seUnitMaterial = getDataM(spr, getColumnIndex(spr, "seUnitMaterial"), xRow)
            If getColumnIndex(spr, "cdUnitMaterial") > -1 Then z7231.cdUnitMaterial = getDataM(spr, getColumnIndex(spr, "cdUnitMaterial"), xRow)
            If getColumnIndex(spr, "seUnitPacking") > -1 Then z7231.seUnitPacking = getDataM(spr, getColumnIndex(spr, "seUnitPacking"), xRow)
            If getColumnIndex(spr, "cdUnitPacking") > -1 Then z7231.cdUnitPacking = getDataM(spr, getColumnIndex(spr, "cdUnitPacking"), xRow)
            If getColumnIndex(spr, "seTax") > -1 Then z7231.seTax = getDataM(spr, getColumnIndex(spr, "seTax"), xRow)
            If getColumnIndex(spr, "cdTax") > -1 Then z7231.cdTax = getDataM(spr, getColumnIndex(spr, "cdTax"), xRow)
            If getColumnIndex(spr, "PerTaxImport") > -1 Then z7231.PerTaxImport = getDataM(spr, getColumnIndex(spr, "PerTaxImport"), xRow)
            If getColumnIndex(spr, "PerTaxVAT") > -1 Then z7231.PerTaxVAT = getDataM(spr, getColumnIndex(spr, "PerTaxVAT"), xRow)
            If getColumnIndex(spr, "QtyBasic") > -1 Then z7231.QtyBasic = getDataM(spr, getColumnIndex(spr, "QtyBasic"), xRow)
            If getColumnIndex(spr, "QtyOptimum") > -1 Then z7231.QtyOptimum = getDataM(spr, getColumnIndex(spr, "QtyOptimum"), xRow)
            If getColumnIndex(spr, "DayOptimum") > -1 Then z7231.DayOptimum = getDataM(spr, getColumnIndex(spr, "DayOptimum"), xRow)
            If getColumnIndex(spr, "DayEstimate") > -1 Then z7231.DayEstimate = getDataM(spr, getColumnIndex(spr, "DayEstimate"), xRow)
            If getColumnIndex(spr, "PriceMaterial") > -1 Then z7231.PriceMaterial = getDataM(spr, getColumnIndex(spr, "PriceMaterial"), xRow)
            If getColumnIndex(spr, "QtyMOQ") > -1 Then z7231.QtyMOQ = getDataM(spr, getColumnIndex(spr, "QtyMOQ"), xRow)
            If getColumnIndex(spr, "MaxInventory") > -1 Then z7231.MaxInventory = getDataM(spr, getColumnIndex(spr, "MaxInventory"), xRow)
            If getColumnIndex(spr, "MinInventory") > -1 Then z7231.MinInventory = getDataM(spr, getColumnIndex(spr, "MinInventory"), xRow)
            If getColumnIndex(spr, "ReOrderQty") > -1 Then z7231.ReOrderQty = getDataM(spr, getColumnIndex(spr, "ReOrderQty"), xRow)
            If getColumnIndex(spr, "CheckDevRnD") > -1 Then z7231.CheckDevRnD = getDataM(spr, getColumnIndex(spr, "CheckDevRnD"), xRow)
            If getColumnIndex(spr, "StatusMaterial") > -1 Then z7231.StatusMaterial = getDataM(spr, getColumnIndex(spr, "StatusMaterial"), xRow)
            If getColumnIndex(spr, "BOMType") > -1 Then z7231.BOMType = getDataM(spr, getColumnIndex(spr, "BOMType"), xRow)
            If getColumnIndex(spr, "ApplyType") > -1 Then z7231.ApplyType = getDataM(spr, getColumnIndex(spr, "ApplyType"), xRow)
            If getColumnIndex(spr, "DateStart") > -1 Then z7231.DateStart = getDataM(spr, getColumnIndex(spr, "DateStart"), xRow)
            If getColumnIndex(spr, "DateOptimum") > -1 Then z7231.DateOptimum = getDataM(spr, getColumnIndex(spr, "DateOptimum"), xRow)
            If getColumnIndex(spr, "DateEstimate") > -1 Then z7231.DateEstimate = getDataM(spr, getColumnIndex(spr, "DateEstimate"), xRow)
            If getColumnIndex(spr, "DateInBound") > -1 Then z7231.DateInBound = getDataM(spr, getColumnIndex(spr, "DateInBound"), xRow)
            If getColumnIndex(spr, "DateOutBound") > -1 Then z7231.DateOutBound = getDataM(spr, getColumnIndex(spr, "DateOutBound"), xRow)
            If getColumnIndex(spr, "SupplyName") > -1 Then z7231.SupplyName = getDataM(spr, getColumnIndex(spr, "SupplyName"), xRow)
            If getColumnIndex(spr, "SupplyCode") > -1 Then z7231.SupplyCode = getDataM(spr, getColumnIndex(spr, "SupplyCode"), xRow)
            If getColumnIndex(spr, "SalesCode") > -1 Then z7231.SalesCode = getDataM(spr, getColumnIndex(spr, "SalesCode"), xRow)
            If getColumnIndex(spr, "Check1") > -1 Then z7231.Check1 = getDataM(spr, getColumnIndex(spr, "Check1"), xRow)
            If getColumnIndex(spr, "Check2") > -1 Then z7231.Check2 = getDataM(spr, getColumnIndex(spr, "Check2"), xRow)
            If getColumnIndex(spr, "Check3") > -1 Then z7231.Check3 = getDataM(spr, getColumnIndex(spr, "Check3"), xRow)
            If getColumnIndex(spr, "Check4") > -1 Then z7231.Check4 = getDataM(spr, getColumnIndex(spr, "Check4"), xRow)
            If getColumnIndex(spr, "Check5") > -1 Then z7231.Check5 = getDataM(spr, getColumnIndex(spr, "Check5"), xRow)
            If getColumnIndex(spr, "Check6") > -1 Then z7231.Check6 = getDataM(spr, getColumnIndex(spr, "Check6"), xRow)
            If getColumnIndex(spr, "Check7") > -1 Then z7231.Check7 = getDataM(spr, getColumnIndex(spr, "Check7"), xRow)
            If getColumnIndex(spr, "Check8") > -1 Then z7231.Check8 = getDataM(spr, getColumnIndex(spr, "Check8"), xRow)
            If getColumnIndex(spr, "Check9") > -1 Then z7231.Check9 = getDataM(spr, getColumnIndex(spr, "Check9"), xRow)
            If getColumnIndex(spr, "Check10") > -1 Then z7231.Check10 = getDataM(spr, getColumnIndex(spr, "Check10"), xRow)
            If getColumnIndex(spr, "CheckName1") > -1 Then z7231.CheckName1 = getDataM(spr, getColumnIndex(spr, "CheckName1"), xRow)
            If getColumnIndex(spr, "CheckName2") > -1 Then z7231.CheckName2 = getDataM(spr, getColumnIndex(spr, "CheckName2"), xRow)
            If getColumnIndex(spr, "CheckName3") > -1 Then z7231.CheckName3 = getDataM(spr, getColumnIndex(spr, "CheckName3"), xRow)
            If getColumnIndex(spr, "CheckName4") > -1 Then z7231.CheckName4 = getDataM(spr, getColumnIndex(spr, "CheckName4"), xRow)
            If getColumnIndex(spr, "CheckName5") > -1 Then z7231.CheckName5 = getDataM(spr, getColumnIndex(spr, "CheckName5"), xRow)
            If getColumnIndex(spr, "CheckName6") > -1 Then z7231.CheckName6 = getDataM(spr, getColumnIndex(spr, "CheckName6"), xRow)
            If getColumnIndex(spr, "CheckName7") > -1 Then z7231.CheckName7 = getDataM(spr, getColumnIndex(spr, "CheckName7"), xRow)
            If getColumnIndex(spr, "CheckName8") > -1 Then z7231.CheckName8 = getDataM(spr, getColumnIndex(spr, "CheckName8"), xRow)
            If getColumnIndex(spr, "CheckName9") > -1 Then z7231.CheckName9 = getDataM(spr, getColumnIndex(spr, "CheckName9"), xRow)
            If getColumnIndex(spr, "CheckName10") > -1 Then z7231.CheckName10 = getDataM(spr, getColumnIndex(spr, "CheckName10"), xRow)
            If getColumnIndex(spr, "ACodeMaterial") > -1 Then z7231.ACodeMaterial = getDataM(spr, getColumnIndex(spr, "ACodeMaterial"), xRow)
            If getColumnIndex(spr, "ACodeTax1") > -1 Then z7231.ACodeTax1 = getDataM(spr, getColumnIndex(spr, "ACodeTax1"), xRow)
            If getColumnIndex(spr, "ACodeTax2") > -1 Then z7231.ACodeTax2 = getDataM(spr, getColumnIndex(spr, "ACodeTax2"), xRow)
            If getColumnIndex(spr, "ACodeTax3") > -1 Then z7231.ACodeTax3 = getDataM(spr, getColumnIndex(spr, "ACodeTax3"), xRow)
            If getColumnIndex(spr, "ACodeSales") > -1 Then z7231.ACodeSales = getDataM(spr, getColumnIndex(spr, "ACodeSales"), xRow)
            If getColumnIndex(spr, "ACodeIntSales") > -1 Then z7231.ACodeIntSales = getDataM(spr, getColumnIndex(spr, "ACodeIntSales"), xRow)
            If getColumnIndex(spr, "ACodeCOGS") > -1 Then z7231.ACodeCOGS = getDataM(spr, getColumnIndex(spr, "ACodeCOGS"), xRow)
            If getColumnIndex(spr, "ACodeReturn") > -1 Then z7231.ACodeReturn = getDataM(spr, getColumnIndex(spr, "ACodeReturn"), xRow)
            If getColumnIndex(spr, "ACodeDiscount") > -1 Then z7231.ACodeDiscount = getDataM(spr, getColumnIndex(spr, "ACodeDiscount"), xRow)
            If getColumnIndex(spr, "ACodeWIP") > -1 Then z7231.ACodeWIP = getDataM(spr, getColumnIndex(spr, "ACodeWIP"), xRow)
            If getColumnIndex(spr, "CheckInventory") > -1 Then z7231.CheckInventory = getDataM(spr, getColumnIndex(spr, "CheckInventory"), xRow)
            If getColumnIndex(spr, "CheckPosition") > -1 Then z7231.CheckPosition = getDataM(spr, getColumnIndex(spr, "CheckPosition"), xRow)
            If getColumnIndex(spr, "CheckLotNo") > -1 Then z7231.CheckLotNo = getDataM(spr, getColumnIndex(spr, "CheckLotNo"), xRow)
            If getColumnIndex(spr, "CheckPrice") > -1 Then z7231.CheckPrice = getDataM(spr, getColumnIndex(spr, "CheckPrice"), xRow)
            If getColumnIndex(spr, "seTax1") > -1 Then z7231.seTax1 = getDataM(spr, getColumnIndex(spr, "seTax1"), xRow)
            If getColumnIndex(spr, "cdTax1") > -1 Then z7231.cdTax1 = getDataM(spr, getColumnIndex(spr, "cdTax1"), xRow)
            If getColumnIndex(spr, "PerTax1") > -1 Then z7231.PerTax1 = getDataM(spr, getColumnIndex(spr, "PerTax1"), xRow)
            If getColumnIndex(spr, "seTax2") > -1 Then z7231.seTax2 = getDataM(spr, getColumnIndex(spr, "seTax2"), xRow)
            If getColumnIndex(spr, "cdTax2") > -1 Then z7231.cdTax2 = getDataM(spr, getColumnIndex(spr, "cdTax2"), xRow)
            If getColumnIndex(spr, "PerTax2") > -1 Then z7231.PerTax2 = getDataM(spr, getColumnIndex(spr, "PerTax2"), xRow)
            If getColumnIndex(spr, "seTax3") > -1 Then z7231.seTax3 = getDataM(spr, getColumnIndex(spr, "seTax3"), xRow)
            If getColumnIndex(spr, "cdTax3") > -1 Then z7231.cdTax3 = getDataM(spr, getColumnIndex(spr, "cdTax3"), xRow)
            If getColumnIndex(spr, "PerTax3") > -1 Then z7231.PerTax3 = getDataM(spr, getColumnIndex(spr, "PerTax3"), xRow)
            If getColumnIndex(spr, "seTaxVAT") > -1 Then z7231.seTaxVAT = getDataM(spr, getColumnIndex(spr, "seTaxVAT"), xRow)
            If getColumnIndex(spr, "cdTaxVAT") > -1 Then z7231.cdTaxVAT = getDataM(spr, getColumnIndex(spr, "cdTaxVAT"), xRow)
            If getColumnIndex(spr, "seTaxImport") > -1 Then z7231.seTaxImport = getDataM(spr, getColumnIndex(spr, "seTaxImport"), xRow)
            If getColumnIndex(spr, "cdTaxImport") > -1 Then z7231.cdTaxImport = getDataM(spr, getColumnIndex(spr, "cdTaxImport"), xRow)
            If getColumnIndex(spr, "seTaxExport") > -1 Then z7231.seTaxExport = getDataM(spr, getColumnIndex(spr, "seTaxExport"), xRow)
            If getColumnIndex(spr, "cdTaxExport") > -1 Then z7231.cdTaxExport = getDataM(spr, getColumnIndex(spr, "cdTaxExport"), xRow)
            If getColumnIndex(spr, "seTaxSpecial") > -1 Then z7231.seTaxSpecial = getDataM(spr, getColumnIndex(spr, "seTaxSpecial"), xRow)
            If getColumnIndex(spr, "cdTaxSpecial") > -1 Then z7231.cdTaxSpecial = getDataM(spr, getColumnIndex(spr, "cdTaxSpecial"), xRow)
            If getColumnIndex(spr, "seAccMaterial") > -1 Then z7231.seAccMaterial = getDataM(spr, getColumnIndex(spr, "seAccMaterial"), xRow)
            If getColumnIndex(spr, "cdAccMaterial") > -1 Then z7231.cdAccMaterial = getDataM(spr, getColumnIndex(spr, "cdAccMaterial"), xRow)
            If getColumnIndex(spr, "seAccSales") > -1 Then z7231.seAccSales = getDataM(spr, getColumnIndex(spr, "seAccSales"), xRow)
            If getColumnIndex(spr, "cdAccSales") > -1 Then z7231.cdAccSales = getDataM(spr, getColumnIndex(spr, "cdAccSales"), xRow)
            If getColumnIndex(spr, "seAccIntSales") > -1 Then z7231.seAccIntSales = getDataM(spr, getColumnIndex(spr, "seAccIntSales"), xRow)
            If getColumnIndex(spr, "cdAccIntSales") > -1 Then z7231.cdAccIntSales = getDataM(spr, getColumnIndex(spr, "cdAccIntSales"), xRow)
            If getColumnIndex(spr, "seAccCOGS") > -1 Then z7231.seAccCOGS = getDataM(spr, getColumnIndex(spr, "seAccCOGS"), xRow)
            If getColumnIndex(spr, "cdAccCOGS") > -1 Then z7231.cdAccCOGS = getDataM(spr, getColumnIndex(spr, "cdAccCOGS"), xRow)
            If getColumnIndex(spr, "seAccReturn") > -1 Then z7231.seAccReturn = getDataM(spr, getColumnIndex(spr, "seAccReturn"), xRow)
            If getColumnIndex(spr, "cdAccReturn") > -1 Then z7231.cdAccReturn = getDataM(spr, getColumnIndex(spr, "cdAccReturn"), xRow)
            If getColumnIndex(spr, "seAccDiscount") > -1 Then z7231.seAccDiscount = getDataM(spr, getColumnIndex(spr, "seAccDiscount"), xRow)
            If getColumnIndex(spr, "cdAccDiscount") > -1 Then z7231.cdAccDiscount = getDataM(spr, getColumnIndex(spr, "cdAccDiscount"), xRow)
            If getColumnIndex(spr, "seAccWIP") > -1 Then z7231.seAccWIP = getDataM(spr, getColumnIndex(spr, "seAccWIP"), xRow)
            If getColumnIndex(spr, "cdAccWIP") > -1 Then z7231.cdAccWIP = getDataM(spr, getColumnIndex(spr, "cdAccWIP"), xRow)
            If getColumnIndex(spr, "DateInsert") > -1 Then z7231.DateInsert = getDataM(spr, getColumnIndex(spr, "DateInsert"), xRow)
            If getColumnIndex(spr, "DateUpdate") > -1 Then z7231.DateUpdate = getDataM(spr, getColumnIndex(spr, "DateUpdate"), xRow)
            If getColumnIndex(spr, "InchargeInsert") > -1 Then z7231.InchargeInsert = getDataM(spr, getColumnIndex(spr, "InchargeInsert"), xRow)
            If getColumnIndex(spr, "InchargeUpdate") > -1 Then z7231.InchargeUpdate = getDataM(spr, getColumnIndex(spr, "InchargeUpdate"), xRow)
            If getColumnIndex(spr, "InchargeComplete") > -1 Then z7231.InchargeComplete = getDataM(spr, getColumnIndex(spr, "InchargeComplete"), xRow)
            If getColumnIndex(spr, "InchargeCancel") > -1 Then z7231.InchargeCancel = getDataM(spr, getColumnIndex(spr, "InchargeCancel"), xRow)
            If getColumnIndex(spr, "InchargeApproved") > -1 Then z7231.InchargeApproved = getDataM(spr, getColumnIndex(spr, "InchargeApproved"), xRow)
            If getColumnIndex(spr, "InchargePending1") > -1 Then z7231.InchargePending1 = getDataM(spr, getColumnIndex(spr, "InchargePending1"), xRow)
            If getColumnIndex(spr, "InchargePending2") > -1 Then z7231.InchargePending2 = getDataM(spr, getColumnIndex(spr, "InchargePending2"), xRow)
            If getColumnIndex(spr, "CheckUse") > -1 Then z7231.CheckUse = getDataM(spr, getColumnIndex(spr, "CheckUse"), xRow)
            If getColumnIndex(spr, "DateActive") > -1 Then z7231.DateActive = getDataM(spr, getColumnIndex(spr, "DateActive"), xRow)
            If getColumnIndex(spr, "DateDeactive") > -1 Then z7231.DateDeactive = getDataM(spr, getColumnIndex(spr, "DateDeactive"), xRow)
            If getColumnIndex(spr, "CheckActive") > -1 Then z7231.CheckActive = getDataM(spr, getColumnIndex(spr, "CheckActive"), xRow)
            If getColumnIndex(spr, "DateComplete") > -1 Then z7231.DateComplete = getDataM(spr, getColumnIndex(spr, "DateComplete"), xRow)
            If getColumnIndex(spr, "DateApproved") > -1 Then z7231.DateApproved = getDataM(spr, getColumnIndex(spr, "DateApproved"), xRow)
            If getColumnIndex(spr, "DateCancel") > -1 Then z7231.DateCancel = getDataM(spr, getColumnIndex(spr, "DateCancel"), xRow)
            If getColumnIndex(spr, "DatePending1") > -1 Then z7231.DatePending1 = getDataM(spr, getColumnIndex(spr, "DatePending1"), xRow)
            If getColumnIndex(spr, "DatePending2") > -1 Then z7231.DatePending2 = getDataM(spr, getColumnIndex(spr, "DatePending2"), xRow)
            If getColumnIndex(spr, "CheckSync") > -1 Then z7231.CheckSync = getDataM(spr, getColumnIndex(spr, "CheckSync"), xRow)
            If getColumnIndex(spr, "MaterialFullName") > -1 Then z7231.MaterialFullName = getDataM(spr, getColumnIndex(spr, "MaterialFullName"), xRow)
            If getColumnIndex(spr, "MaterialOldName") > -1 Then z7231.MaterialOldName = getDataM(spr, getColumnIndex(spr, "MaterialOldName"), xRow)
            If getColumnIndex(spr, "Remark") > -1 Then z7231.Remark = getDataM(spr, getColumnIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7231_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K7231_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z7231 As T7231_AREA, CheckClear As Boolean, MATERIALCODE As String) As Boolean

        K7231_MOVE = False

        Try
            If READ_PFK7231(MATERIALCODE) = True Then
                z7231 = D7231
                K7231_MOVE = True
            Else
                If CheckClear = True Then z7231 = Nothing
            End If

            If getColumnIndex(spr, "MaterialCode") > -1 Then z7231.MaterialCode = getDataM(spr, getColumnIndex(spr, "MaterialCode"), xRow)
            If getColumnIndex(spr, "MaterialName") > -1 Then z7231.MaterialName = getDataM(spr, getColumnIndex(spr, "MaterialName"), xRow)
            If getColumnIndex(spr, "MaterialPName") > -1 Then z7231.MaterialPName = getDataM(spr, getColumnIndex(spr, "MaterialPName"), xRow)
            If getColumnIndex(spr, "MaterialSimple") > -1 Then z7231.MaterialSimple = getDataM(spr, getColumnIndex(spr, "MaterialSimple"), xRow)
            If getColumnIndex(spr, "MaterialColor") > -1 Then z7231.MaterialColor = getDataM(spr, getColumnIndex(spr, "MaterialColor"), xRow)
            If getColumnIndex(spr, "seImportGroup") > -1 Then z7231.seImportGroup = getDataM(spr, getColumnIndex(spr, "seImportGroup"), xRow)
            If getColumnIndex(spr, "cdImportGroup") > -1 Then z7231.cdImportGroup = getDataM(spr, getColumnIndex(spr, "cdImportGroup"), xRow)
            If getColumnIndex(spr, "ImportCode") > -1 Then z7231.ImportCode = getDataM(spr, getColumnIndex(spr, "ImportCode"), xRow)
            If getColumnIndex(spr, "ImportName") > -1 Then z7231.ImportName = getDataM(spr, getColumnIndex(spr, "ImportName"), xRow)
            If getColumnIndex(spr, "ImportCode1") > -1 Then z7231.ImportCode1 = getDataM(spr, getColumnIndex(spr, "ImportCode1"), xRow)
            If getColumnIndex(spr, "ImportName1") > -1 Then z7231.ImportName1 = getDataM(spr, getColumnIndex(spr, "ImportName1"), xRow)
            If getColumnIndex(spr, "AccountCode") > -1 Then z7231.AccountCode = getDataM(spr, getColumnIndex(spr, "AccountCode"), xRow)
            If getColumnIndex(spr, "AccountName") > -1 Then z7231.AccountName = getDataM(spr, getColumnIndex(spr, "AccountName"), xRow)
            If getColumnIndex(spr, "OtherCode1") > -1 Then z7231.OtherCode1 = getDataM(spr, getColumnIndex(spr, "OtherCode1"), xRow)
            If getColumnIndex(spr, "OtherCode2") > -1 Then z7231.OtherCode2 = getDataM(spr, getColumnIndex(spr, "OtherCode2"), xRow)
            If getColumnIndex(spr, "DevelopmentCode") > -1 Then z7231.DevelopmentCode = getDataM(spr, getColumnIndex(spr, "DevelopmentCode"), xRow)
            If getColumnIndex(spr, "DevelopmentName") > -1 Then z7231.DevelopmentName = getDataM(spr, getColumnIndex(spr, "DevelopmentName"), xRow)
            If getColumnIndex(spr, "MaterialForeign1") > -1 Then z7231.MaterialForeign1 = getDataM(spr, getColumnIndex(spr, "MaterialForeign1"), xRow)
            If getColumnIndex(spr, "MaterialForeign2") > -1 Then z7231.MaterialForeign2 = getDataM(spr, getColumnIndex(spr, "MaterialForeign2"), xRow)
            If getColumnIndex(spr, "Width") > -1 Then z7231.Width = getDataM(spr, getColumnIndex(spr, "Width"), xRow)
            If getColumnIndex(spr, "Height") > -1 Then z7231.Height = getDataM(spr, getColumnIndex(spr, "Height"), xRow)
            If getColumnIndex(spr, "SizeName") > -1 Then z7231.SizeName = getDataM(spr, getColumnIndex(spr, "SizeName"), xRow)
            If getColumnIndex(spr, "CheckPrint") > -1 Then z7231.CheckPrint = getDataM(spr, getColumnIndex(spr, "CheckPrint"), xRow)
            If getColumnIndex(spr, "CheckSP") > -1 Then z7231.CheckSP = getDataM(spr, getColumnIndex(spr, "CheckSP"), xRow)
            If getColumnIndex(spr, "seSpecial") > -1 Then z7231.seSpecial = getDataM(spr, getColumnIndex(spr, "seSpecial"), xRow)
            If getColumnIndex(spr, "cdSpecial") > -1 Then z7231.cdSpecial = getDataM(spr, getColumnIndex(spr, "cdSpecial"), xRow)
            If getColumnIndex(spr, "SizeRangeTool") > -1 Then z7231.SizeRangeTool = getDataM(spr, getColumnIndex(spr, "SizeRangeTool"), xRow)
            If getColumnIndex(spr, "CheckKindMaterial") > -1 Then z7231.CheckKindMaterial = getDataM(spr, getColumnIndex(spr, "CheckKindMaterial"), xRow)
            If getColumnIndex(spr, "CheckMarketType") > -1 Then z7231.CheckMarketType = getDataM(spr, getColumnIndex(spr, "CheckMarketType"), xRow)
            If getColumnIndex(spr, "seUnitPrice") > -1 Then z7231.seUnitPrice = getDataM(spr, getColumnIndex(spr, "seUnitPrice"), xRow)
            If getColumnIndex(spr, "cdUnitPrice") > -1 Then z7231.cdUnitPrice = getDataM(spr, getColumnIndex(spr, "cdUnitPrice"), xRow)
            If getColumnIndex(spr, "DateExchangePrice") > -1 Then z7231.DateExchangePrice = getDataM(spr, getColumnIndex(spr, "DateExchangePrice"), xRow)
            If getColumnIndex(spr, "ExchangePrice") > -1 Then z7231.ExchangePrice = getDataM(spr, getColumnIndex(spr, "ExchangePrice"), xRow)
            If getColumnIndex(spr, "PriceUSD") > -1 Then z7231.PriceUSD = getDataM(spr, getColumnIndex(spr, "PriceUSD"), xRow)
            If getColumnIndex(spr, "PriceVND") > -1 Then z7231.PriceVND = getDataM(spr, getColumnIndex(spr, "PriceVND"), xRow)
            If getColumnIndex(spr, "seDepartment") > -1 Then z7231.seDepartment = getDataM(spr, getColumnIndex(spr, "seDepartment"), xRow)
            If getColumnIndex(spr, "cdDepartment") > -1 Then z7231.cdDepartment = getDataM(spr, getColumnIndex(spr, "cdDepartment"), xRow)
            If getColumnIndex(spr, "seLargeGroupMaterial") > -1 Then z7231.seLargeGroupMaterial = getDataM(spr, getColumnIndex(spr, "seLargeGroupMaterial"), xRow)
            If getColumnIndex(spr, "cdLargeGroupMaterial") > -1 Then z7231.cdLargeGroupMaterial = getDataM(spr, getColumnIndex(spr, "cdLargeGroupMaterial"), xRow)
            If getColumnIndex(spr, "seSemiGroupMaterial") > -1 Then z7231.seSemiGroupMaterial = getDataM(spr, getColumnIndex(spr, "seSemiGroupMaterial"), xRow)
            If getColumnIndex(spr, "cdSemiGroupMaterial") > -1 Then z7231.cdSemiGroupMaterial = getDataM(spr, getColumnIndex(spr, "cdSemiGroupMaterial"), xRow)
            If getColumnIndex(spr, "seDetailGroupMaterial") > -1 Then z7231.seDetailGroupMaterial = getDataM(spr, getColumnIndex(spr, "seDetailGroupMaterial"), xRow)
            If getColumnIndex(spr, "cdDetailGroupMaterial") > -1 Then z7231.cdDetailGroupMaterial = getDataM(spr, getColumnIndex(spr, "cdDetailGroupMaterial"), xRow)
            If getColumnIndex(spr, "seSpecGroup1") > -1 Then z7231.seSpecGroup1 = getDataM(spr, getColumnIndex(spr, "seSpecGroup1"), xRow)
            If getColumnIndex(spr, "cdSpecGroup1") > -1 Then z7231.cdSpecGroup1 = getDataM(spr, getColumnIndex(spr, "cdSpecGroup1"), xRow)
            If getColumnIndex(spr, "seSpecGroup2") > -1 Then z7231.seSpecGroup2 = getDataM(spr, getColumnIndex(spr, "seSpecGroup2"), xRow)
            If getColumnIndex(spr, "cdSpecGroup2") > -1 Then z7231.cdSpecGroup2 = getDataM(spr, getColumnIndex(spr, "cdSpecGroup2"), xRow)
            If getColumnIndex(spr, "seSpecGroup3") > -1 Then z7231.seSpecGroup3 = getDataM(spr, getColumnIndex(spr, "seSpecGroup3"), xRow)
            If getColumnIndex(spr, "cdSpecGroup3") > -1 Then z7231.cdSpecGroup3 = getDataM(spr, getColumnIndex(spr, "cdSpecGroup3"), xRow)
            If getColumnIndex(spr, "seSpecGroup4") > -1 Then z7231.seSpecGroup4 = getDataM(spr, getColumnIndex(spr, "seSpecGroup4"), xRow)
            If getColumnIndex(spr, "cdSpecGroup4") > -1 Then z7231.cdSpecGroup4 = getDataM(spr, getColumnIndex(spr, "cdSpecGroup4"), xRow)
            If getColumnIndex(spr, "seSpecGroup5") > -1 Then z7231.seSpecGroup5 = getDataM(spr, getColumnIndex(spr, "seSpecGroup5"), xRow)
            If getColumnIndex(spr, "cdSpecGroup5") > -1 Then z7231.cdSpecGroup5 = getDataM(spr, getColumnIndex(spr, "cdSpecGroup5"), xRow)
            If getColumnIndex(spr, "seUnitMaterial") > -1 Then z7231.seUnitMaterial = getDataM(spr, getColumnIndex(spr, "seUnitMaterial"), xRow)
            If getColumnIndex(spr, "cdUnitMaterial") > -1 Then z7231.cdUnitMaterial = getDataM(spr, getColumnIndex(spr, "cdUnitMaterial"), xRow)
            If getColumnIndex(spr, "seUnitPacking") > -1 Then z7231.seUnitPacking = getDataM(spr, getColumnIndex(spr, "seUnitPacking"), xRow)
            If getColumnIndex(spr, "cdUnitPacking") > -1 Then z7231.cdUnitPacking = getDataM(spr, getColumnIndex(spr, "cdUnitPacking"), xRow)
            If getColumnIndex(spr, "seTax") > -1 Then z7231.seTax = getDataM(spr, getColumnIndex(spr, "seTax"), xRow)
            If getColumnIndex(spr, "cdTax") > -1 Then z7231.cdTax = getDataM(spr, getColumnIndex(spr, "cdTax"), xRow)
            If getColumnIndex(spr, "PerTaxImport") > -1 Then z7231.PerTaxImport = getDataM(spr, getColumnIndex(spr, "PerTaxImport"), xRow)
            If getColumnIndex(spr, "PerTaxVAT") > -1 Then z7231.PerTaxVAT = getDataM(spr, getColumnIndex(spr, "PerTaxVAT"), xRow)
            If getColumnIndex(spr, "QtyBasic") > -1 Then z7231.QtyBasic = getDataM(spr, getColumnIndex(spr, "QtyBasic"), xRow)
            If getColumnIndex(spr, "QtyOptimum") > -1 Then z7231.QtyOptimum = getDataM(spr, getColumnIndex(spr, "QtyOptimum"), xRow)
            If getColumnIndex(spr, "DayOptimum") > -1 Then z7231.DayOptimum = getDataM(spr, getColumnIndex(spr, "DayOptimum"), xRow)
            If getColumnIndex(spr, "DayEstimate") > -1 Then z7231.DayEstimate = getDataM(spr, getColumnIndex(spr, "DayEstimate"), xRow)
            If getColumnIndex(spr, "PriceMaterial") > -1 Then z7231.PriceMaterial = getDataM(spr, getColumnIndex(spr, "PriceMaterial"), xRow)
            If getColumnIndex(spr, "QtyMOQ") > -1 Then z7231.QtyMOQ = getDataM(spr, getColumnIndex(spr, "QtyMOQ"), xRow)
            If getColumnIndex(spr, "MaxInventory") > -1 Then z7231.MaxInventory = getDataM(spr, getColumnIndex(spr, "MaxInventory"), xRow)
            If getColumnIndex(spr, "MinInventory") > -1 Then z7231.MinInventory = getDataM(spr, getColumnIndex(spr, "MinInventory"), xRow)
            If getColumnIndex(spr, "ReOrderQty") > -1 Then z7231.ReOrderQty = getDataM(spr, getColumnIndex(spr, "ReOrderQty"), xRow)
            If getColumnIndex(spr, "CheckDevRnD") > -1 Then z7231.CheckDevRnD = getDataM(spr, getColumnIndex(spr, "CheckDevRnD"), xRow)
            If getColumnIndex(spr, "StatusMaterial") > -1 Then z7231.StatusMaterial = getDataM(spr, getColumnIndex(spr, "StatusMaterial"), xRow)
            If getColumnIndex(spr, "BOMType") > -1 Then z7231.BOMType = getDataM(spr, getColumnIndex(spr, "BOMType"), xRow)
            If getColumnIndex(spr, "ApplyType") > -1 Then z7231.ApplyType = getDataM(spr, getColumnIndex(spr, "ApplyType"), xRow)
            If getColumnIndex(spr, "DateStart") > -1 Then z7231.DateStart = getDataM(spr, getColumnIndex(spr, "DateStart"), xRow)
            If getColumnIndex(spr, "DateOptimum") > -1 Then z7231.DateOptimum = getDataM(spr, getColumnIndex(spr, "DateOptimum"), xRow)
            If getColumnIndex(spr, "DateEstimate") > -1 Then z7231.DateEstimate = getDataM(spr, getColumnIndex(spr, "DateEstimate"), xRow)
            If getColumnIndex(spr, "DateInBound") > -1 Then z7231.DateInBound = getDataM(spr, getColumnIndex(spr, "DateInBound"), xRow)
            If getColumnIndex(spr, "DateOutBound") > -1 Then z7231.DateOutBound = getDataM(spr, getColumnIndex(spr, "DateOutBound"), xRow)
            If getColumnIndex(spr, "SupplyName") > -1 Then z7231.SupplyName = getDataM(spr, getColumnIndex(spr, "SupplyName"), xRow)
            If getColumnIndex(spr, "SupplyCode") > -1 Then z7231.SupplyCode = getDataM(spr, getColumnIndex(spr, "SupplyCode"), xRow)
            If getColumnIndex(spr, "SalesCode") > -1 Then z7231.SalesCode = getDataM(spr, getColumnIndex(spr, "SalesCode"), xRow)
            If getColumnIndex(spr, "Check1") > -1 Then z7231.Check1 = getDataM(spr, getColumnIndex(spr, "Check1"), xRow)
            If getColumnIndex(spr, "Check2") > -1 Then z7231.Check2 = getDataM(spr, getColumnIndex(spr, "Check2"), xRow)
            If getColumnIndex(spr, "Check3") > -1 Then z7231.Check3 = getDataM(spr, getColumnIndex(spr, "Check3"), xRow)
            If getColumnIndex(spr, "Check4") > -1 Then z7231.Check4 = getDataM(spr, getColumnIndex(spr, "Check4"), xRow)
            If getColumnIndex(spr, "Check5") > -1 Then z7231.Check5 = getDataM(spr, getColumnIndex(spr, "Check5"), xRow)
            If getColumnIndex(spr, "Check6") > -1 Then z7231.Check6 = getDataM(spr, getColumnIndex(spr, "Check6"), xRow)
            If getColumnIndex(spr, "Check7") > -1 Then z7231.Check7 = getDataM(spr, getColumnIndex(spr, "Check7"), xRow)
            If getColumnIndex(spr, "Check8") > -1 Then z7231.Check8 = getDataM(spr, getColumnIndex(spr, "Check8"), xRow)
            If getColumnIndex(spr, "Check9") > -1 Then z7231.Check9 = getDataM(spr, getColumnIndex(spr, "Check9"), xRow)
            If getColumnIndex(spr, "Check10") > -1 Then z7231.Check10 = getDataM(spr, getColumnIndex(spr, "Check10"), xRow)
            If getColumnIndex(spr, "CheckName1") > -1 Then z7231.CheckName1 = getDataM(spr, getColumnIndex(spr, "CheckName1"), xRow)
            If getColumnIndex(spr, "CheckName2") > -1 Then z7231.CheckName2 = getDataM(spr, getColumnIndex(spr, "CheckName2"), xRow)
            If getColumnIndex(spr, "CheckName3") > -1 Then z7231.CheckName3 = getDataM(spr, getColumnIndex(spr, "CheckName3"), xRow)
            If getColumnIndex(spr, "CheckName4") > -1 Then z7231.CheckName4 = getDataM(spr, getColumnIndex(spr, "CheckName4"), xRow)
            If getColumnIndex(spr, "CheckName5") > -1 Then z7231.CheckName5 = getDataM(spr, getColumnIndex(spr, "CheckName5"), xRow)
            If getColumnIndex(spr, "CheckName6") > -1 Then z7231.CheckName6 = getDataM(spr, getColumnIndex(spr, "CheckName6"), xRow)
            If getColumnIndex(spr, "CheckName7") > -1 Then z7231.CheckName7 = getDataM(spr, getColumnIndex(spr, "CheckName7"), xRow)
            If getColumnIndex(spr, "CheckName8") > -1 Then z7231.CheckName8 = getDataM(spr, getColumnIndex(spr, "CheckName8"), xRow)
            If getColumnIndex(spr, "CheckName9") > -1 Then z7231.CheckName9 = getDataM(spr, getColumnIndex(spr, "CheckName9"), xRow)
            If getColumnIndex(spr, "CheckName10") > -1 Then z7231.CheckName10 = getDataM(spr, getColumnIndex(spr, "CheckName10"), xRow)
            If getColumnIndex(spr, "ACodeMaterial") > -1 Then z7231.ACodeMaterial = getDataM(spr, getColumnIndex(spr, "ACodeMaterial"), xRow)
            If getColumnIndex(spr, "ACodeTax1") > -1 Then z7231.ACodeTax1 = getDataM(spr, getColumnIndex(spr, "ACodeTax1"), xRow)
            If getColumnIndex(spr, "ACodeTax2") > -1 Then z7231.ACodeTax2 = getDataM(spr, getColumnIndex(spr, "ACodeTax2"), xRow)
            If getColumnIndex(spr, "ACodeTax3") > -1 Then z7231.ACodeTax3 = getDataM(spr, getColumnIndex(spr, "ACodeTax3"), xRow)
            If getColumnIndex(spr, "ACodeSales") > -1 Then z7231.ACodeSales = getDataM(spr, getColumnIndex(spr, "ACodeSales"), xRow)
            If getColumnIndex(spr, "ACodeIntSales") > -1 Then z7231.ACodeIntSales = getDataM(spr, getColumnIndex(spr, "ACodeIntSales"), xRow)
            If getColumnIndex(spr, "ACodeCOGS") > -1 Then z7231.ACodeCOGS = getDataM(spr, getColumnIndex(spr, "ACodeCOGS"), xRow)
            If getColumnIndex(spr, "ACodeReturn") > -1 Then z7231.ACodeReturn = getDataM(spr, getColumnIndex(spr, "ACodeReturn"), xRow)
            If getColumnIndex(spr, "ACodeDiscount") > -1 Then z7231.ACodeDiscount = getDataM(spr, getColumnIndex(spr, "ACodeDiscount"), xRow)
            If getColumnIndex(spr, "ACodeWIP") > -1 Then z7231.ACodeWIP = getDataM(spr, getColumnIndex(spr, "ACodeWIP"), xRow)
            If getColumnIndex(spr, "CheckInventory") > -1 Then z7231.CheckInventory = getDataM(spr, getColumnIndex(spr, "CheckInventory"), xRow)
            If getColumnIndex(spr, "CheckPosition") > -1 Then z7231.CheckPosition = getDataM(spr, getColumnIndex(spr, "CheckPosition"), xRow)
            If getColumnIndex(spr, "CheckLotNo") > -1 Then z7231.CheckLotNo = getDataM(spr, getColumnIndex(spr, "CheckLotNo"), xRow)
            If getColumnIndex(spr, "CheckPrice") > -1 Then z7231.CheckPrice = getDataM(spr, getColumnIndex(spr, "CheckPrice"), xRow)
            If getColumnIndex(spr, "seTax1") > -1 Then z7231.seTax1 = getDataM(spr, getColumnIndex(spr, "seTax1"), xRow)
            If getColumnIndex(spr, "cdTax1") > -1 Then z7231.cdTax1 = getDataM(spr, getColumnIndex(spr, "cdTax1"), xRow)
            If getColumnIndex(spr, "PerTax1") > -1 Then z7231.PerTax1 = getDataM(spr, getColumnIndex(spr, "PerTax1"), xRow)
            If getColumnIndex(spr, "seTax2") > -1 Then z7231.seTax2 = getDataM(spr, getColumnIndex(spr, "seTax2"), xRow)
            If getColumnIndex(spr, "cdTax2") > -1 Then z7231.cdTax2 = getDataM(spr, getColumnIndex(spr, "cdTax2"), xRow)
            If getColumnIndex(spr, "PerTax2") > -1 Then z7231.PerTax2 = getDataM(spr, getColumnIndex(spr, "PerTax2"), xRow)
            If getColumnIndex(spr, "seTax3") > -1 Then z7231.seTax3 = getDataM(spr, getColumnIndex(spr, "seTax3"), xRow)
            If getColumnIndex(spr, "cdTax3") > -1 Then z7231.cdTax3 = getDataM(spr, getColumnIndex(spr, "cdTax3"), xRow)
            If getColumnIndex(spr, "PerTax3") > -1 Then z7231.PerTax3 = getDataM(spr, getColumnIndex(spr, "PerTax3"), xRow)
            If getColumnIndex(spr, "seTaxVAT") > -1 Then z7231.seTaxVAT = getDataM(spr, getColumnIndex(spr, "seTaxVAT"), xRow)
            If getColumnIndex(spr, "cdTaxVAT") > -1 Then z7231.cdTaxVAT = getDataM(spr, getColumnIndex(spr, "cdTaxVAT"), xRow)
            If getColumnIndex(spr, "seTaxImport") > -1 Then z7231.seTaxImport = getDataM(spr, getColumnIndex(spr, "seTaxImport"), xRow)
            If getColumnIndex(spr, "cdTaxImport") > -1 Then z7231.cdTaxImport = getDataM(spr, getColumnIndex(spr, "cdTaxImport"), xRow)
            If getColumnIndex(spr, "seTaxExport") > -1 Then z7231.seTaxExport = getDataM(spr, getColumnIndex(spr, "seTaxExport"), xRow)
            If getColumnIndex(spr, "cdTaxExport") > -1 Then z7231.cdTaxExport = getDataM(spr, getColumnIndex(spr, "cdTaxExport"), xRow)
            If getColumnIndex(spr, "seTaxSpecial") > -1 Then z7231.seTaxSpecial = getDataM(spr, getColumnIndex(spr, "seTaxSpecial"), xRow)
            If getColumnIndex(spr, "cdTaxSpecial") > -1 Then z7231.cdTaxSpecial = getDataM(spr, getColumnIndex(spr, "cdTaxSpecial"), xRow)
            If getColumnIndex(spr, "seAccMaterial") > -1 Then z7231.seAccMaterial = getDataM(spr, getColumnIndex(spr, "seAccMaterial"), xRow)
            If getColumnIndex(spr, "cdAccMaterial") > -1 Then z7231.cdAccMaterial = getDataM(spr, getColumnIndex(spr, "cdAccMaterial"), xRow)
            If getColumnIndex(spr, "seAccSales") > -1 Then z7231.seAccSales = getDataM(spr, getColumnIndex(spr, "seAccSales"), xRow)
            If getColumnIndex(spr, "cdAccSales") > -1 Then z7231.cdAccSales = getDataM(spr, getColumnIndex(spr, "cdAccSales"), xRow)
            If getColumnIndex(spr, "seAccIntSales") > -1 Then z7231.seAccIntSales = getDataM(spr, getColumnIndex(spr, "seAccIntSales"), xRow)
            If getColumnIndex(spr, "cdAccIntSales") > -1 Then z7231.cdAccIntSales = getDataM(spr, getColumnIndex(spr, "cdAccIntSales"), xRow)
            If getColumnIndex(spr, "seAccCOGS") > -1 Then z7231.seAccCOGS = getDataM(spr, getColumnIndex(spr, "seAccCOGS"), xRow)
            If getColumnIndex(spr, "cdAccCOGS") > -1 Then z7231.cdAccCOGS = getDataM(spr, getColumnIndex(spr, "cdAccCOGS"), xRow)
            If getColumnIndex(spr, "seAccReturn") > -1 Then z7231.seAccReturn = getDataM(spr, getColumnIndex(spr, "seAccReturn"), xRow)
            If getColumnIndex(spr, "cdAccReturn") > -1 Then z7231.cdAccReturn = getDataM(spr, getColumnIndex(spr, "cdAccReturn"), xRow)
            If getColumnIndex(spr, "seAccDiscount") > -1 Then z7231.seAccDiscount = getDataM(spr, getColumnIndex(spr, "seAccDiscount"), xRow)
            If getColumnIndex(spr, "cdAccDiscount") > -1 Then z7231.cdAccDiscount = getDataM(spr, getColumnIndex(spr, "cdAccDiscount"), xRow)
            If getColumnIndex(spr, "seAccWIP") > -1 Then z7231.seAccWIP = getDataM(spr, getColumnIndex(spr, "seAccWIP"), xRow)
            If getColumnIndex(spr, "cdAccWIP") > -1 Then z7231.cdAccWIP = getDataM(spr, getColumnIndex(spr, "cdAccWIP"), xRow)
            If getColumnIndex(spr, "DateInsert") > -1 Then z7231.DateInsert = getDataM(spr, getColumnIndex(spr, "DateInsert"), xRow)
            If getColumnIndex(spr, "DateUpdate") > -1 Then z7231.DateUpdate = getDataM(spr, getColumnIndex(spr, "DateUpdate"), xRow)
            If getColumnIndex(spr, "InchargeInsert") > -1 Then z7231.InchargeInsert = getDataM(spr, getColumnIndex(spr, "InchargeInsert"), xRow)
            If getColumnIndex(spr, "InchargeUpdate") > -1 Then z7231.InchargeUpdate = getDataM(spr, getColumnIndex(spr, "InchargeUpdate"), xRow)
            If getColumnIndex(spr, "InchargeComplete") > -1 Then z7231.InchargeComplete = getDataM(spr, getColumnIndex(spr, "InchargeComplete"), xRow)
            If getColumnIndex(spr, "InchargeCancel") > -1 Then z7231.InchargeCancel = getDataM(spr, getColumnIndex(spr, "InchargeCancel"), xRow)
            If getColumnIndex(spr, "InchargeApproved") > -1 Then z7231.InchargeApproved = getDataM(spr, getColumnIndex(spr, "InchargeApproved"), xRow)
            If getColumnIndex(spr, "InchargePending1") > -1 Then z7231.InchargePending1 = getDataM(spr, getColumnIndex(spr, "InchargePending1"), xRow)
            If getColumnIndex(spr, "InchargePending2") > -1 Then z7231.InchargePending2 = getDataM(spr, getColumnIndex(spr, "InchargePending2"), xRow)
            If getColumnIndex(spr, "CheckUse") > -1 Then z7231.CheckUse = getDataM(spr, getColumnIndex(spr, "CheckUse"), xRow)
            If getColumnIndex(spr, "DateActive") > -1 Then z7231.DateActive = getDataM(spr, getColumnIndex(spr, "DateActive"), xRow)
            If getColumnIndex(spr, "DateDeactive") > -1 Then z7231.DateDeactive = getDataM(spr, getColumnIndex(spr, "DateDeactive"), xRow)
            If getColumnIndex(spr, "CheckActive") > -1 Then z7231.CheckActive = getDataM(spr, getColumnIndex(spr, "CheckActive"), xRow)
            If getColumnIndex(spr, "DateComplete") > -1 Then z7231.DateComplete = getDataM(spr, getColumnIndex(spr, "DateComplete"), xRow)
            If getColumnIndex(spr, "DateApproved") > -1 Then z7231.DateApproved = getDataM(spr, getColumnIndex(spr, "DateApproved"), xRow)
            If getColumnIndex(spr, "DateCancel") > -1 Then z7231.DateCancel = getDataM(spr, getColumnIndex(spr, "DateCancel"), xRow)
            If getColumnIndex(spr, "DatePending1") > -1 Then z7231.DatePending1 = getDataM(spr, getColumnIndex(spr, "DatePending1"), xRow)
            If getColumnIndex(spr, "DatePending2") > -1 Then z7231.DatePending2 = getDataM(spr, getColumnIndex(spr, "DatePending2"), xRow)
            If getColumnIndex(spr, "CheckSync") > -1 Then z7231.CheckSync = getDataM(spr, getColumnIndex(spr, "CheckSync"), xRow)
            If getColumnIndex(spr, "MaterialFullName") > -1 Then z7231.MaterialFullName = getDataM(spr, getColumnIndex(spr, "MaterialFullName"), xRow)
            If getColumnIndex(spr, "MaterialOldName") > -1 Then z7231.MaterialOldName = getDataM(spr, getColumnIndex(spr, "MaterialOldName"), xRow)
            If getColumnIndex(spr, "Remark") > -1 Then z7231.Remark = getDataM(spr, getColumnIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7231_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K7231_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z7231 As T7231_AREA, Job As String, MATERIALCODE As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K7231_MOVE = False

        Try
            If READ_PFK7231(MATERIALCODE) = True Then
                z7231 = D7231
                K7231_MOVE = True
            Else
                z7231 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7231")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "MATERIALCODE" : z7231.MaterialCode = Children(i).Code
                                Case "MATERIALNAME" : z7231.MaterialName = Children(i).Code
                                Case "MATERIALPNAME" : z7231.MaterialPName = Children(i).Code
                                Case "MATERIALSIMPLE" : z7231.MaterialSimple = Children(i).Code
                                Case "MATERIALCOLOR" : z7231.MaterialColor = Children(i).Code
                                Case "SEIMPORTGROUP" : z7231.seImportGroup = Children(i).Code
                                Case "CDIMPORTGROUP" : z7231.cdImportGroup = Children(i).Code
                                Case "IMPORTCODE" : z7231.ImportCode = Children(i).Code
                                Case "IMPORTNAME" : z7231.ImportName = Children(i).Code
                                Case "IMPORTCODE1" : z7231.ImportCode1 = Children(i).Code
                                Case "IMPORTNAME1" : z7231.ImportName1 = Children(i).Code
                                Case "ACCOUNTCODE" : z7231.AccountCode = Children(i).Code
                                Case "ACCOUNTNAME" : z7231.AccountName = Children(i).Code
                                Case "OTHERCODE1" : z7231.OtherCode1 = Children(i).Code
                                Case "OTHERCODE2" : z7231.OtherCode2 = Children(i).Code
                                Case "DEVELOPMENTCODE" : z7231.DevelopmentCode = Children(i).Code
                                Case "DEVELOPMENTNAME" : z7231.DevelopmentName = Children(i).Code
                                Case "MATERIALFOREIGN1" : z7231.MaterialForeign1 = Children(i).Code
                                Case "MATERIALFOREIGN2" : z7231.MaterialForeign2 = Children(i).Code
                                Case "WIDTH" : z7231.Width = Children(i).Code
                                Case "HEIGHT" : z7231.Height = Children(i).Code
                                Case "SIZENAME" : z7231.SizeName = Children(i).Code
                                Case "CHECKPRINT" : z7231.CheckPrint = Children(i).Code
                                Case "CHECKSP" : z7231.CheckSP = Children(i).Code
                                Case "SESPECIAL" : z7231.seSpecial = Children(i).Code
                                Case "CDSPECIAL" : z7231.cdSpecial = Children(i).Code
                                Case "SIZERANGETOOL" : z7231.SizeRangeTool = Children(i).Code
                                Case "CHECKKINDMATERIAL" : z7231.CheckKindMaterial = Children(i).Code
                                Case "CHECKMARKETTYPE" : z7231.CheckMarketType = Children(i).Code
                                Case "SEUNITPRICE" : z7231.seUnitPrice = Children(i).Code
                                Case "CDUNITPRICE" : z7231.cdUnitPrice = Children(i).Code
                                Case "DATEEXCHANGEPRICE" : z7231.DateExchangePrice = Children(i).Code
                                Case "EXCHANGEPRICE" : z7231.ExchangePrice = Children(i).Code
                                Case "PRICEUSD" : z7231.PriceUSD = Children(i).Code
                                Case "PRICEVND" : z7231.PriceVND = Children(i).Code
                                Case "SEDEPARTMENT" : z7231.seDepartment = Children(i).Code
                                Case "CDDEPARTMENT" : z7231.cdDepartment = Children(i).Code
                                Case "SELARGEGROUPMATERIAL" : z7231.seLargeGroupMaterial = Children(i).Code
                                Case "CDLARGEGROUPMATERIAL" : z7231.cdLargeGroupMaterial = Children(i).Code
                                Case "SESEMIGROUPMATERIAL" : z7231.seSemiGroupMaterial = Children(i).Code
                                Case "CDSEMIGROUPMATERIAL" : z7231.cdSemiGroupMaterial = Children(i).Code
                                Case "SEDETAILGROUPMATERIAL" : z7231.seDetailGroupMaterial = Children(i).Code
                                Case "CDDETAILGROUPMATERIAL" : z7231.cdDetailGroupMaterial = Children(i).Code
                                Case "SESPECGROUP1" : z7231.seSpecGroup1 = Children(i).Code
                                Case "CDSPECGROUP1" : z7231.cdSpecGroup1 = Children(i).Code
                                Case "SESPECGROUP2" : z7231.seSpecGroup2 = Children(i).Code
                                Case "CDSPECGROUP2" : z7231.cdSpecGroup2 = Children(i).Code
                                Case "SESPECGROUP3" : z7231.seSpecGroup3 = Children(i).Code
                                Case "CDSPECGROUP3" : z7231.cdSpecGroup3 = Children(i).Code
                                Case "SESPECGROUP4" : z7231.seSpecGroup4 = Children(i).Code
                                Case "CDSPECGROUP4" : z7231.cdSpecGroup4 = Children(i).Code
                                Case "SESPECGROUP5" : z7231.seSpecGroup5 = Children(i).Code
                                Case "CDSPECGROUP5" : z7231.cdSpecGroup5 = Children(i).Code
                                Case "SEUNITMATERIAL" : z7231.seUnitMaterial = Children(i).Code
                                Case "CDUNITMATERIAL" : z7231.cdUnitMaterial = Children(i).Code
                                Case "SEUNITPACKING" : z7231.seUnitPacking = Children(i).Code
                                Case "CDUNITPACKING" : z7231.cdUnitPacking = Children(i).Code
                                Case "SETAX" : z7231.seTax = Children(i).Code
                                Case "CDTAX" : z7231.cdTax = Children(i).Code
                                Case "PERTAXIMPORT" : z7231.PerTaxImport = Children(i).Code
                                Case "PERTAXVAT" : z7231.PerTaxVAT = Children(i).Code
                                Case "QTYBASIC" : z7231.QtyBasic = Children(i).Code
                                Case "QTYOPTIMUM" : z7231.QtyOptimum = Children(i).Code
                                Case "DAYOPTIMUM" : z7231.DayOptimum = Children(i).Code
                                Case "DAYESTIMATE" : z7231.DayEstimate = Children(i).Code
                                Case "PRICEMATERIAL" : z7231.PriceMaterial = Children(i).Code
                                Case "QTYMOQ" : z7231.QtyMOQ = Children(i).Code
                                Case "MAXINVENTORY" : z7231.MaxInventory = Children(i).Code
                                Case "MININVENTORY" : z7231.MinInventory = Children(i).Code
                                Case "REORDERQTY" : z7231.ReOrderQty = Children(i).Code
                                Case "CHECKDEVRND" : z7231.CheckDevRnD = Children(i).Code
                                Case "STATUSMATERIAL" : z7231.StatusMaterial = Children(i).Code
                                Case "BOMTYPE" : z7231.BOMType = Children(i).Code
                                Case "APPLYTYPE" : z7231.ApplyType = Children(i).Code
                                Case "DATESTART" : z7231.DateStart = Children(i).Code
                                Case "DATEOPTIMUM" : z7231.DateOptimum = Children(i).Code
                                Case "DATEESTIMATE" : z7231.DateEstimate = Children(i).Code
                                Case "DATEINBOUND" : z7231.DateInBound = Children(i).Code
                                Case "DATEOUTBOUND" : z7231.DateOutBound = Children(i).Code
                                Case "SUPPLYNAME" : z7231.SupplyName = Children(i).Code
                                Case "SUPPLYCODE" : z7231.SupplyCode = Children(i).Code
                                Case "SALESCODE" : z7231.SalesCode = Children(i).Code
                                Case "CHECK1" : z7231.Check1 = Children(i).Code
                                Case "CHECK2" : z7231.Check2 = Children(i).Code
                                Case "CHECK3" : z7231.Check3 = Children(i).Code
                                Case "CHECK4" : z7231.Check4 = Children(i).Code
                                Case "CHECK5" : z7231.Check5 = Children(i).Code
                                Case "CHECK6" : z7231.Check6 = Children(i).Code
                                Case "CHECK7" : z7231.Check7 = Children(i).Code
                                Case "CHECK8" : z7231.Check8 = Children(i).Code
                                Case "CHECK9" : z7231.Check9 = Children(i).Code
                                Case "CHECK10" : z7231.Check10 = Children(i).Code
                                Case "CHECKNAME1" : z7231.CheckName1 = Children(i).Code
                                Case "CHECKNAME2" : z7231.CheckName2 = Children(i).Code
                                Case "CHECKNAME3" : z7231.CheckName3 = Children(i).Code
                                Case "CHECKNAME4" : z7231.CheckName4 = Children(i).Code
                                Case "CHECKNAME5" : z7231.CheckName5 = Children(i).Code
                                Case "CHECKNAME6" : z7231.CheckName6 = Children(i).Code
                                Case "CHECKNAME7" : z7231.CheckName7 = Children(i).Code
                                Case "CHECKNAME8" : z7231.CheckName8 = Children(i).Code
                                Case "CHECKNAME9" : z7231.CheckName9 = Children(i).Code
                                Case "CHECKNAME10" : z7231.CheckName10 = Children(i).Code
                                Case "ACODEMATERIAL" : z7231.ACodeMaterial = Children(i).Code
                                Case "ACODETAX1" : z7231.ACodeTax1 = Children(i).Code
                                Case "ACODETAX2" : z7231.ACodeTax2 = Children(i).Code
                                Case "ACODETAX3" : z7231.ACodeTax3 = Children(i).Code
                                Case "ACODESALES" : z7231.ACodeSales = Children(i).Code
                                Case "ACODEINTSALES" : z7231.ACodeIntSales = Children(i).Code
                                Case "ACODECOGS" : z7231.ACodeCOGS = Children(i).Code
                                Case "ACODERETURN" : z7231.ACodeReturn = Children(i).Code
                                Case "ACODEDISCOUNT" : z7231.ACodeDiscount = Children(i).Code
                                Case "ACODEWIP" : z7231.ACodeWIP = Children(i).Code
                                Case "CHECKINVENTORY" : z7231.CheckInventory = Children(i).Code
                                Case "CHECKPOSITION" : z7231.CheckPosition = Children(i).Code
                                Case "CHECKLOTNO" : z7231.CheckLotNo = Children(i).Code
                                Case "CHECKPRICE" : z7231.CheckPrice = Children(i).Code
                                Case "SETAX1" : z7231.seTax1 = Children(i).Code
                                Case "CDTAX1" : z7231.cdTax1 = Children(i).Code
                                Case "PERTAX1" : z7231.PerTax1 = Children(i).Code
                                Case "SETAX2" : z7231.seTax2 = Children(i).Code
                                Case "CDTAX2" : z7231.cdTax2 = Children(i).Code
                                Case "PERTAX2" : z7231.PerTax2 = Children(i).Code
                                Case "SETAX3" : z7231.seTax3 = Children(i).Code
                                Case "CDTAX3" : z7231.cdTax3 = Children(i).Code
                                Case "PERTAX3" : z7231.PerTax3 = Children(i).Code
                                Case "SETAXVAT" : z7231.seTaxVAT = Children(i).Code
                                Case "CDTAXVAT" : z7231.cdTaxVAT = Children(i).Code
                                Case "SETAXIMPORT" : z7231.seTaxImport = Children(i).Code
                                Case "CDTAXIMPORT" : z7231.cdTaxImport = Children(i).Code
                                Case "SETAXEXPORT" : z7231.seTaxExport = Children(i).Code
                                Case "CDTAXEXPORT" : z7231.cdTaxExport = Children(i).Code
                                Case "SETAXSPECIAL" : z7231.seTaxSpecial = Children(i).Code
                                Case "CDTAXSPECIAL" : z7231.cdTaxSpecial = Children(i).Code
                                Case "SEACCMATERIAL" : z7231.seAccMaterial = Children(i).Code
                                Case "CDACCMATERIAL" : z7231.cdAccMaterial = Children(i).Code
                                Case "SEACCSALES" : z7231.seAccSales = Children(i).Code
                                Case "CDACCSALES" : z7231.cdAccSales = Children(i).Code
                                Case "SEACCINTSALES" : z7231.seAccIntSales = Children(i).Code
                                Case "CDACCINTSALES" : z7231.cdAccIntSales = Children(i).Code
                                Case "SEACCCOGS" : z7231.seAccCOGS = Children(i).Code
                                Case "CDACCCOGS" : z7231.cdAccCOGS = Children(i).Code
                                Case "SEACCRETURN" : z7231.seAccReturn = Children(i).Code
                                Case "CDACCRETURN" : z7231.cdAccReturn = Children(i).Code
                                Case "SEACCDISCOUNT" : z7231.seAccDiscount = Children(i).Code
                                Case "CDACCDISCOUNT" : z7231.cdAccDiscount = Children(i).Code
                                Case "SEACCWIP" : z7231.seAccWIP = Children(i).Code
                                Case "CDACCWIP" : z7231.cdAccWIP = Children(i).Code
                                Case "DATEINSERT" : z7231.DateInsert = Children(i).Code
                                Case "DATEUPDATE" : z7231.DateUpdate = Children(i).Code
                                Case "INCHARGEINSERT" : z7231.InchargeInsert = Children(i).Code
                                Case "INCHARGEUPDATE" : z7231.InchargeUpdate = Children(i).Code
                                Case "INCHARGECOMPLETE" : z7231.InchargeComplete = Children(i).Code
                                Case "INCHARGECANCEL" : z7231.InchargeCancel = Children(i).Code
                                Case "INCHARGEAPPROVED" : z7231.InchargeApproved = Children(i).Code
                                Case "INCHARGEPENDING1" : z7231.InchargePending1 = Children(i).Code
                                Case "INCHARGEPENDING2" : z7231.InchargePending2 = Children(i).Code
                                Case "CHECKUSE" : z7231.CheckUse = Children(i).Code
                                Case "DATEACTIVE" : z7231.DateActive = Children(i).Code
                                Case "DATEDEACTIVE" : z7231.DateDeactive = Children(i).Code
                                Case "CHECKACTIVE" : z7231.CheckActive = Children(i).Code
                                Case "DATECOMPLETE" : z7231.DateComplete = Children(i).Code
                                Case "DATEAPPROVED" : z7231.DateApproved = Children(i).Code
                                Case "DATECANCEL" : z7231.DateCancel = Children(i).Code
                                Case "DATEPENDING1" : z7231.DatePending1 = Children(i).Code
                                Case "DATEPENDING2" : z7231.DatePending2 = Children(i).Code
                                Case "CHECKSYNC" : z7231.CheckSync = Children(i).Code
                                Case "MATERIALFULLNAME" : z7231.MaterialFullName = Children(i).Code
                                Case "MATERIALOLDNAME" : z7231.MaterialOldName = Children(i).Code
                                Case "REMARK" : z7231.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "MATERIALCODE" : z7231.MaterialCode = Children(i).Data
                                Case "MATERIALNAME" : z7231.MaterialName = Children(i).Data
                                Case "MATERIALPNAME" : z7231.MaterialPName = Children(i).Data
                                Case "MATERIALSIMPLE" : z7231.MaterialSimple = Children(i).Data
                                Case "MATERIALCOLOR" : z7231.MaterialColor = Children(i).Data
                                Case "SEIMPORTGROUP" : z7231.seImportGroup = Children(i).Data
                                Case "CDIMPORTGROUP" : z7231.cdImportGroup = Children(i).Data
                                Case "IMPORTCODE" : z7231.ImportCode = Children(i).Data
                                Case "IMPORTNAME" : z7231.ImportName = Children(i).Data
                                Case "IMPORTCODE1" : z7231.ImportCode1 = Children(i).Data
                                Case "IMPORTNAME1" : z7231.ImportName1 = Children(i).Data
                                Case "ACCOUNTCODE" : z7231.AccountCode = Children(i).Data
                                Case "ACCOUNTNAME" : z7231.AccountName = Children(i).Data
                                Case "OTHERCODE1" : z7231.OtherCode1 = Children(i).Data
                                Case "OTHERCODE2" : z7231.OtherCode2 = Children(i).Data
                                Case "DEVELOPMENTCODE" : z7231.DevelopmentCode = Children(i).Data
                                Case "DEVELOPMENTNAME" : z7231.DevelopmentName = Children(i).Data
                                Case "MATERIALFOREIGN1" : z7231.MaterialForeign1 = Children(i).Data
                                Case "MATERIALFOREIGN2" : z7231.MaterialForeign2 = Children(i).Data
                                Case "WIDTH" : z7231.Width = Children(i).Data
                                Case "HEIGHT" : z7231.Height = Children(i).Data
                                Case "SIZENAME" : z7231.SizeName = Children(i).Data
                                Case "CHECKPRINT" : z7231.CheckPrint = Children(i).Data
                                Case "CHECKSP" : z7231.CheckSP = Children(i).Data
                                Case "SESPECIAL" : z7231.seSpecial = Children(i).Data
                                Case "CDSPECIAL" : z7231.cdSpecial = Children(i).Data
                                Case "SIZERANGETOOL" : z7231.SizeRangeTool = Children(i).Data
                                Case "CHECKKINDMATERIAL" : z7231.CheckKindMaterial = Children(i).Data
                                Case "CHECKMARKETTYPE" : z7231.CheckMarketType = Children(i).Data
                                Case "SEUNITPRICE" : z7231.seUnitPrice = Children(i).Data
                                Case "CDUNITPRICE" : z7231.cdUnitPrice = Children(i).Data
                                Case "DATEEXCHANGEPRICE" : z7231.DateExchangePrice = Children(i).Data
                                Case "EXCHANGEPRICE" : z7231.ExchangePrice = Children(i).Data
                                Case "PRICEUSD" : z7231.PriceUSD = Children(i).Data
                                Case "PRICEVND" : z7231.PriceVND = Children(i).Data
                                Case "SEDEPARTMENT" : z7231.seDepartment = Children(i).Data
                                Case "CDDEPARTMENT" : z7231.cdDepartment = Children(i).Data
                                Case "SELARGEGROUPMATERIAL" : z7231.seLargeGroupMaterial = Children(i).Data
                                Case "CDLARGEGROUPMATERIAL" : z7231.cdLargeGroupMaterial = Children(i).Data
                                Case "SESEMIGROUPMATERIAL" : z7231.seSemiGroupMaterial = Children(i).Data
                                Case "CDSEMIGROUPMATERIAL" : z7231.cdSemiGroupMaterial = Children(i).Data
                                Case "SEDETAILGROUPMATERIAL" : z7231.seDetailGroupMaterial = Children(i).Data
                                Case "CDDETAILGROUPMATERIAL" : z7231.cdDetailGroupMaterial = Children(i).Data
                                Case "SESPECGROUP1" : z7231.seSpecGroup1 = Children(i).Data
                                Case "CDSPECGROUP1" : z7231.cdSpecGroup1 = Children(i).Data
                                Case "SESPECGROUP2" : z7231.seSpecGroup2 = Children(i).Data
                                Case "CDSPECGROUP2" : z7231.cdSpecGroup2 = Children(i).Data
                                Case "SESPECGROUP3" : z7231.seSpecGroup3 = Children(i).Data
                                Case "CDSPECGROUP3" : z7231.cdSpecGroup3 = Children(i).Data
                                Case "SESPECGROUP4" : z7231.seSpecGroup4 = Children(i).Data
                                Case "CDSPECGROUP4" : z7231.cdSpecGroup4 = Children(i).Data
                                Case "SESPECGROUP5" : z7231.seSpecGroup5 = Children(i).Data
                                Case "CDSPECGROUP5" : z7231.cdSpecGroup5 = Children(i).Data
                                Case "SEUNITMATERIAL" : z7231.seUnitMaterial = Children(i).Data
                                Case "CDUNITMATERIAL" : z7231.cdUnitMaterial = Children(i).Data
                                Case "SEUNITPACKING" : z7231.seUnitPacking = Children(i).Data
                                Case "CDUNITPACKING" : z7231.cdUnitPacking = Children(i).Data
                                Case "SETAX" : z7231.seTax = Children(i).Data
                                Case "CDTAX" : z7231.cdTax = Children(i).Data
                                Case "PERTAXIMPORT" : z7231.PerTaxImport = Children(i).Data
                                Case "PERTAXVAT" : z7231.PerTaxVAT = Children(i).Data
                                Case "QTYBASIC" : z7231.QtyBasic = Children(i).Data
                                Case "QTYOPTIMUM" : z7231.QtyOptimum = Children(i).Data
                                Case "DAYOPTIMUM" : z7231.DayOptimum = Children(i).Data
                                Case "DAYESTIMATE" : z7231.DayEstimate = Children(i).Data
                                Case "PRICEMATERIAL" : z7231.PriceMaterial = Children(i).Data
                                Case "QTYMOQ" : z7231.QtyMOQ = Children(i).Data
                                Case "MAXINVENTORY" : z7231.MaxInventory = Children(i).Data
                                Case "MININVENTORY" : z7231.MinInventory = Children(i).Data
                                Case "REORDERQTY" : z7231.ReOrderQty = Children(i).Data
                                Case "CHECKDEVRND" : z7231.CheckDevRnD = Children(i).Data
                                Case "STATUSMATERIAL" : z7231.StatusMaterial = Children(i).Data
                                Case "BOMTYPE" : z7231.BOMType = Children(i).Data
                                Case "APPLYTYPE" : z7231.ApplyType = Children(i).Data
                                Case "DATESTART" : z7231.DateStart = Children(i).Data
                                Case "DATEOPTIMUM" : z7231.DateOptimum = Children(i).Data
                                Case "DATEESTIMATE" : z7231.DateEstimate = Children(i).Data
                                Case "DATEINBOUND" : z7231.DateInBound = Children(i).Data
                                Case "DATEOUTBOUND" : z7231.DateOutBound = Children(i).Data
                                Case "SUPPLYNAME" : z7231.SupplyName = Children(i).Data
                                Case "SUPPLYCODE" : z7231.SupplyCode = Children(i).Data
                                Case "SALESCODE" : z7231.SalesCode = Children(i).Data
                                Case "CHECK1" : z7231.Check1 = Children(i).Data
                                Case "CHECK2" : z7231.Check2 = Children(i).Data
                                Case "CHECK3" : z7231.Check3 = Children(i).Data
                                Case "CHECK4" : z7231.Check4 = Children(i).Data
                                Case "CHECK5" : z7231.Check5 = Children(i).Data
                                Case "CHECK6" : z7231.Check6 = Children(i).Data
                                Case "CHECK7" : z7231.Check7 = Children(i).Data
                                Case "CHECK8" : z7231.Check8 = Children(i).Data
                                Case "CHECK9" : z7231.Check9 = Children(i).Data
                                Case "CHECK10" : z7231.Check10 = Children(i).Data
                                Case "CHECKNAME1" : z7231.CheckName1 = Children(i).Data
                                Case "CHECKNAME2" : z7231.CheckName2 = Children(i).Data
                                Case "CHECKNAME3" : z7231.CheckName3 = Children(i).Data
                                Case "CHECKNAME4" : z7231.CheckName4 = Children(i).Data
                                Case "CHECKNAME5" : z7231.CheckName5 = Children(i).Data
                                Case "CHECKNAME6" : z7231.CheckName6 = Children(i).Data
                                Case "CHECKNAME7" : z7231.CheckName7 = Children(i).Data
                                Case "CHECKNAME8" : z7231.CheckName8 = Children(i).Data
                                Case "CHECKNAME9" : z7231.CheckName9 = Children(i).Data
                                Case "CHECKNAME10" : z7231.CheckName10 = Children(i).Data
                                Case "ACODEMATERIAL" : z7231.ACodeMaterial = Children(i).Data
                                Case "ACODETAX1" : z7231.ACodeTax1 = Children(i).Data
                                Case "ACODETAX2" : z7231.ACodeTax2 = Children(i).Data
                                Case "ACODETAX3" : z7231.ACodeTax3 = Children(i).Data
                                Case "ACODESALES" : z7231.ACodeSales = Children(i).Data
                                Case "ACODEINTSALES" : z7231.ACodeIntSales = Children(i).Data
                                Case "ACODECOGS" : z7231.ACodeCOGS = Children(i).Data
                                Case "ACODERETURN" : z7231.ACodeReturn = Children(i).Data
                                Case "ACODEDISCOUNT" : z7231.ACodeDiscount = Children(i).Data
                                Case "ACODEWIP" : z7231.ACodeWIP = Children(i).Data
                                Case "CHECKINVENTORY" : z7231.CheckInventory = Children(i).Data
                                Case "CHECKPOSITION" : z7231.CheckPosition = Children(i).Data
                                Case "CHECKLOTNO" : z7231.CheckLotNo = Children(i).Data
                                Case "CHECKPRICE" : z7231.CheckPrice = Children(i).Data
                                Case "SETAX1" : z7231.seTax1 = Children(i).Data
                                Case "CDTAX1" : z7231.cdTax1 = Children(i).Data
                                Case "PERTAX1" : z7231.PerTax1 = Children(i).Data
                                Case "SETAX2" : z7231.seTax2 = Children(i).Data
                                Case "CDTAX2" : z7231.cdTax2 = Children(i).Data
                                Case "PERTAX2" : z7231.PerTax2 = Children(i).Data
                                Case "SETAX3" : z7231.seTax3 = Children(i).Data
                                Case "CDTAX3" : z7231.cdTax3 = Children(i).Data
                                Case "PERTAX3" : z7231.PerTax3 = Children(i).Data
                                Case "SETAXVAT" : z7231.seTaxVAT = Children(i).Data
                                Case "CDTAXVAT" : z7231.cdTaxVAT = Children(i).Data
                                Case "SETAXIMPORT" : z7231.seTaxImport = Children(i).Data
                                Case "CDTAXIMPORT" : z7231.cdTaxImport = Children(i).Data
                                Case "SETAXEXPORT" : z7231.seTaxExport = Children(i).Data
                                Case "CDTAXEXPORT" : z7231.cdTaxExport = Children(i).Data
                                Case "SETAXSPECIAL" : z7231.seTaxSpecial = Children(i).Data
                                Case "CDTAXSPECIAL" : z7231.cdTaxSpecial = Children(i).Data
                                Case "SEACCMATERIAL" : z7231.seAccMaterial = Children(i).Data
                                Case "CDACCMATERIAL" : z7231.cdAccMaterial = Children(i).Data
                                Case "SEACCSALES" : z7231.seAccSales = Children(i).Data
                                Case "CDACCSALES" : z7231.cdAccSales = Children(i).Data
                                Case "SEACCINTSALES" : z7231.seAccIntSales = Children(i).Data
                                Case "CDACCINTSALES" : z7231.cdAccIntSales = Children(i).Data
                                Case "SEACCCOGS" : z7231.seAccCOGS = Children(i).Data
                                Case "CDACCCOGS" : z7231.cdAccCOGS = Children(i).Data
                                Case "SEACCRETURN" : z7231.seAccReturn = Children(i).Data
                                Case "CDACCRETURN" : z7231.cdAccReturn = Children(i).Data
                                Case "SEACCDISCOUNT" : z7231.seAccDiscount = Children(i).Data
                                Case "CDACCDISCOUNT" : z7231.cdAccDiscount = Children(i).Data
                                Case "SEACCWIP" : z7231.seAccWIP = Children(i).Data
                                Case "CDACCWIP" : z7231.cdAccWIP = Children(i).Data
                                Case "DATEINSERT" : z7231.DateInsert = Children(i).Data
                                Case "DATEUPDATE" : z7231.DateUpdate = Children(i).Data
                                Case "INCHARGEINSERT" : z7231.InchargeInsert = Children(i).Data
                                Case "INCHARGEUPDATE" : z7231.InchargeUpdate = Children(i).Data
                                Case "INCHARGECOMPLETE" : z7231.InchargeComplete = Children(i).Data
                                Case "INCHARGECANCEL" : z7231.InchargeCancel = Children(i).Data
                                Case "INCHARGEAPPROVED" : z7231.InchargeApproved = Children(i).Data
                                Case "INCHARGEPENDING1" : z7231.InchargePending1 = Children(i).Data
                                Case "INCHARGEPENDING2" : z7231.InchargePending2 = Children(i).Data
                                Case "CHECKUSE" : z7231.CheckUse = Children(i).Data
                                Case "DATEACTIVE" : z7231.DateActive = Children(i).Data
                                Case "DATEDEACTIVE" : z7231.DateDeactive = Children(i).Data
                                Case "CHECKACTIVE" : z7231.CheckActive = Children(i).Data
                                Case "DATECOMPLETE" : z7231.DateComplete = Children(i).Data
                                Case "DATEAPPROVED" : z7231.DateApproved = Children(i).Data
                                Case "DATECANCEL" : z7231.DateCancel = Children(i).Data
                                Case "DATEPENDING1" : z7231.DatePending1 = Children(i).Data
                                Case "DATEPENDING2" : z7231.DatePending2 = Children(i).Data
                                Case "CHECKSYNC" : z7231.CheckSync = Children(i).Data
                                Case "MATERIALFULLNAME" : z7231.MaterialFullName = Children(i).Data
                                Case "MATERIALOLDNAME" : z7231.MaterialOldName = Children(i).Data
                                Case "REMARK" : z7231.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7231_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K7231_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z7231 As T7231_AREA, Job As String, CheckClear As Boolean, MATERIALCODE As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K7231_MOVE = False

        Try
            If READ_PFK7231(MATERIALCODE) = True Then
                z7231 = D7231
                K7231_MOVE = True
            Else
                If CheckClear = True Then z7231 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7231")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "MATERIALCODE" : z7231.MaterialCode = Children(i).Code
                                Case "MATERIALNAME" : z7231.MaterialName = Children(i).Code
                                Case "MATERIALPNAME" : z7231.MaterialPName = Children(i).Code
                                Case "MATERIALSIMPLE" : z7231.MaterialSimple = Children(i).Code
                                Case "MATERIALCOLOR" : z7231.MaterialColor = Children(i).Code
                                Case "SEIMPORTGROUP" : z7231.seImportGroup = Children(i).Code
                                Case "CDIMPORTGROUP" : z7231.cdImportGroup = Children(i).Code
                                Case "IMPORTCODE" : z7231.ImportCode = Children(i).Code
                                Case "IMPORTNAME" : z7231.ImportName = Children(i).Code
                                Case "IMPORTCODE1" : z7231.ImportCode1 = Children(i).Code
                                Case "IMPORTNAME1" : z7231.ImportName1 = Children(i).Code
                                Case "ACCOUNTCODE" : z7231.AccountCode = Children(i).Code
                                Case "ACCOUNTNAME" : z7231.AccountName = Children(i).Code
                                Case "OTHERCODE1" : z7231.OtherCode1 = Children(i).Code
                                Case "OTHERCODE2" : z7231.OtherCode2 = Children(i).Code
                                Case "DEVELOPMENTCODE" : z7231.DevelopmentCode = Children(i).Code
                                Case "DEVELOPMENTNAME" : z7231.DevelopmentName = Children(i).Code
                                Case "MATERIALFOREIGN1" : z7231.MaterialForeign1 = Children(i).Code
                                Case "MATERIALFOREIGN2" : z7231.MaterialForeign2 = Children(i).Code
                                Case "WIDTH" : z7231.Width = Children(i).Code
                                Case "HEIGHT" : z7231.Height = Children(i).Code
                                Case "SIZENAME" : z7231.SizeName = Children(i).Code
                                Case "CHECKPRINT" : z7231.CheckPrint = Children(i).Code
                                Case "CHECKSP" : z7231.CheckSP = Children(i).Code
                                Case "SESPECIAL" : z7231.seSpecial = Children(i).Code
                                Case "CDSPECIAL" : z7231.cdSpecial = Children(i).Code
                                Case "SIZERANGETOOL" : z7231.SizeRangeTool = Children(i).Code
                                Case "CHECKKINDMATERIAL" : z7231.CheckKindMaterial = Children(i).Code
                                Case "CHECKMARKETTYPE" : z7231.CheckMarketType = Children(i).Code
                                Case "SEUNITPRICE" : z7231.seUnitPrice = Children(i).Code
                                Case "CDUNITPRICE" : z7231.cdUnitPrice = Children(i).Code
                                Case "DATEEXCHANGEPRICE" : z7231.DateExchangePrice = Children(i).Code
                                Case "EXCHANGEPRICE" : z7231.ExchangePrice = Children(i).Code
                                Case "PRICEUSD" : z7231.PriceUSD = Children(i).Code
                                Case "PRICEVND" : z7231.PriceVND = Children(i).Code
                                Case "SEDEPARTMENT" : z7231.seDepartment = Children(i).Code
                                Case "CDDEPARTMENT" : z7231.cdDepartment = Children(i).Code
                                Case "SELARGEGROUPMATERIAL" : z7231.seLargeGroupMaterial = Children(i).Code
                                Case "CDLARGEGROUPMATERIAL" : z7231.cdLargeGroupMaterial = Children(i).Code
                                Case "SESEMIGROUPMATERIAL" : z7231.seSemiGroupMaterial = Children(i).Code
                                Case "CDSEMIGROUPMATERIAL" : z7231.cdSemiGroupMaterial = Children(i).Code
                                Case "SEDETAILGROUPMATERIAL" : z7231.seDetailGroupMaterial = Children(i).Code
                                Case "CDDETAILGROUPMATERIAL" : z7231.cdDetailGroupMaterial = Children(i).Code
                                Case "SESPECGROUP1" : z7231.seSpecGroup1 = Children(i).Code
                                Case "CDSPECGROUP1" : z7231.cdSpecGroup1 = Children(i).Code
                                Case "SESPECGROUP2" : z7231.seSpecGroup2 = Children(i).Code
                                Case "CDSPECGROUP2" : z7231.cdSpecGroup2 = Children(i).Code
                                Case "SESPECGROUP3" : z7231.seSpecGroup3 = Children(i).Code
                                Case "CDSPECGROUP3" : z7231.cdSpecGroup3 = Children(i).Code
                                Case "SESPECGROUP4" : z7231.seSpecGroup4 = Children(i).Code
                                Case "CDSPECGROUP4" : z7231.cdSpecGroup4 = Children(i).Code
                                Case "SESPECGROUP5" : z7231.seSpecGroup5 = Children(i).Code
                                Case "CDSPECGROUP5" : z7231.cdSpecGroup5 = Children(i).Code
                                Case "SEUNITMATERIAL" : z7231.seUnitMaterial = Children(i).Code
                                Case "CDUNITMATERIAL" : z7231.cdUnitMaterial = Children(i).Code
                                Case "SEUNITPACKING" : z7231.seUnitPacking = Children(i).Code
                                Case "CDUNITPACKING" : z7231.cdUnitPacking = Children(i).Code
                                Case "SETAX" : z7231.seTax = Children(i).Code
                                Case "CDTAX" : z7231.cdTax = Children(i).Code
                                Case "PERTAXIMPORT" : z7231.PerTaxImport = Children(i).Code
                                Case "PERTAXVAT" : z7231.PerTaxVAT = Children(i).Code
                                Case "QTYBASIC" : z7231.QtyBasic = Children(i).Code
                                Case "QTYOPTIMUM" : z7231.QtyOptimum = Children(i).Code
                                Case "DAYOPTIMUM" : z7231.DayOptimum = Children(i).Code
                                Case "DAYESTIMATE" : z7231.DayEstimate = Children(i).Code
                                Case "PRICEMATERIAL" : z7231.PriceMaterial = Children(i).Code
                                Case "QTYMOQ" : z7231.QtyMOQ = Children(i).Code
                                Case "MAXINVENTORY" : z7231.MaxInventory = Children(i).Code
                                Case "MININVENTORY" : z7231.MinInventory = Children(i).Code
                                Case "REORDERQTY" : z7231.ReOrderQty = Children(i).Code
                                Case "CHECKDEVRND" : z7231.CheckDevRnD = Children(i).Code
                                Case "STATUSMATERIAL" : z7231.StatusMaterial = Children(i).Code
                                Case "BOMTYPE" : z7231.BOMType = Children(i).Code
                                Case "APPLYTYPE" : z7231.ApplyType = Children(i).Code
                                Case "DATESTART" : z7231.DateStart = Children(i).Code
                                Case "DATEOPTIMUM" : z7231.DateOptimum = Children(i).Code
                                Case "DATEESTIMATE" : z7231.DateEstimate = Children(i).Code
                                Case "DATEINBOUND" : z7231.DateInBound = Children(i).Code
                                Case "DATEOUTBOUND" : z7231.DateOutBound = Children(i).Code
                                Case "SUPPLYNAME" : z7231.SupplyName = Children(i).Code
                                Case "SUPPLYCODE" : z7231.SupplyCode = Children(i).Code
                                Case "SALESCODE" : z7231.SalesCode = Children(i).Code
                                Case "CHECK1" : z7231.Check1 = Children(i).Code
                                Case "CHECK2" : z7231.Check2 = Children(i).Code
                                Case "CHECK3" : z7231.Check3 = Children(i).Code
                                Case "CHECK4" : z7231.Check4 = Children(i).Code
                                Case "CHECK5" : z7231.Check5 = Children(i).Code
                                Case "CHECK6" : z7231.Check6 = Children(i).Code
                                Case "CHECK7" : z7231.Check7 = Children(i).Code
                                Case "CHECK8" : z7231.Check8 = Children(i).Code
                                Case "CHECK9" : z7231.Check9 = Children(i).Code
                                Case "CHECK10" : z7231.Check10 = Children(i).Code
                                Case "CHECKNAME1" : z7231.CheckName1 = Children(i).Code
                                Case "CHECKNAME2" : z7231.CheckName2 = Children(i).Code
                                Case "CHECKNAME3" : z7231.CheckName3 = Children(i).Code
                                Case "CHECKNAME4" : z7231.CheckName4 = Children(i).Code
                                Case "CHECKNAME5" : z7231.CheckName5 = Children(i).Code
                                Case "CHECKNAME6" : z7231.CheckName6 = Children(i).Code
                                Case "CHECKNAME7" : z7231.CheckName7 = Children(i).Code
                                Case "CHECKNAME8" : z7231.CheckName8 = Children(i).Code
                                Case "CHECKNAME9" : z7231.CheckName9 = Children(i).Code
                                Case "CHECKNAME10" : z7231.CheckName10 = Children(i).Code
                                Case "ACODEMATERIAL" : z7231.ACodeMaterial = Children(i).Code
                                Case "ACODETAX1" : z7231.ACodeTax1 = Children(i).Code
                                Case "ACODETAX2" : z7231.ACodeTax2 = Children(i).Code
                                Case "ACODETAX3" : z7231.ACodeTax3 = Children(i).Code
                                Case "ACODESALES" : z7231.ACodeSales = Children(i).Code
                                Case "ACODEINTSALES" : z7231.ACodeIntSales = Children(i).Code
                                Case "ACODECOGS" : z7231.ACodeCOGS = Children(i).Code
                                Case "ACODERETURN" : z7231.ACodeReturn = Children(i).Code
                                Case "ACODEDISCOUNT" : z7231.ACodeDiscount = Children(i).Code
                                Case "ACODEWIP" : z7231.ACodeWIP = Children(i).Code
                                Case "CHECKINVENTORY" : z7231.CheckInventory = Children(i).Code
                                Case "CHECKPOSITION" : z7231.CheckPosition = Children(i).Code
                                Case "CHECKLOTNO" : z7231.CheckLotNo = Children(i).Code
                                Case "CHECKPRICE" : z7231.CheckPrice = Children(i).Code
                                Case "SETAX1" : z7231.seTax1 = Children(i).Code
                                Case "CDTAX1" : z7231.cdTax1 = Children(i).Code
                                Case "PERTAX1" : z7231.PerTax1 = Children(i).Code
                                Case "SETAX2" : z7231.seTax2 = Children(i).Code
                                Case "CDTAX2" : z7231.cdTax2 = Children(i).Code
                                Case "PERTAX2" : z7231.PerTax2 = Children(i).Code
                                Case "SETAX3" : z7231.seTax3 = Children(i).Code
                                Case "CDTAX3" : z7231.cdTax3 = Children(i).Code
                                Case "PERTAX3" : z7231.PerTax3 = Children(i).Code
                                Case "SETAXVAT" : z7231.seTaxVAT = Children(i).Code
                                Case "CDTAXVAT" : z7231.cdTaxVAT = Children(i).Code
                                Case "SETAXIMPORT" : z7231.seTaxImport = Children(i).Code
                                Case "CDTAXIMPORT" : z7231.cdTaxImport = Children(i).Code
                                Case "SETAXEXPORT" : z7231.seTaxExport = Children(i).Code
                                Case "CDTAXEXPORT" : z7231.cdTaxExport = Children(i).Code
                                Case "SETAXSPECIAL" : z7231.seTaxSpecial = Children(i).Code
                                Case "CDTAXSPECIAL" : z7231.cdTaxSpecial = Children(i).Code
                                Case "SEACCMATERIAL" : z7231.seAccMaterial = Children(i).Code
                                Case "CDACCMATERIAL" : z7231.cdAccMaterial = Children(i).Code
                                Case "SEACCSALES" : z7231.seAccSales = Children(i).Code
                                Case "CDACCSALES" : z7231.cdAccSales = Children(i).Code
                                Case "SEACCINTSALES" : z7231.seAccIntSales = Children(i).Code
                                Case "CDACCINTSALES" : z7231.cdAccIntSales = Children(i).Code
                                Case "SEACCCOGS" : z7231.seAccCOGS = Children(i).Code
                                Case "CDACCCOGS" : z7231.cdAccCOGS = Children(i).Code
                                Case "SEACCRETURN" : z7231.seAccReturn = Children(i).Code
                                Case "CDACCRETURN" : z7231.cdAccReturn = Children(i).Code
                                Case "SEACCDISCOUNT" : z7231.seAccDiscount = Children(i).Code
                                Case "CDACCDISCOUNT" : z7231.cdAccDiscount = Children(i).Code
                                Case "SEACCWIP" : z7231.seAccWIP = Children(i).Code
                                Case "CDACCWIP" : z7231.cdAccWIP = Children(i).Code
                                Case "DATEINSERT" : z7231.DateInsert = Children(i).Code
                                Case "DATEUPDATE" : z7231.DateUpdate = Children(i).Code
                                Case "INCHARGEINSERT" : z7231.InchargeInsert = Children(i).Code
                                Case "INCHARGEUPDATE" : z7231.InchargeUpdate = Children(i).Code
                                Case "INCHARGECOMPLETE" : z7231.InchargeComplete = Children(i).Code
                                Case "INCHARGECANCEL" : z7231.InchargeCancel = Children(i).Code
                                Case "INCHARGEAPPROVED" : z7231.InchargeApproved = Children(i).Code
                                Case "INCHARGEPENDING1" : z7231.InchargePending1 = Children(i).Code
                                Case "INCHARGEPENDING2" : z7231.InchargePending2 = Children(i).Code
                                Case "CHECKUSE" : z7231.CheckUse = Children(i).Code
                                Case "DATEACTIVE" : z7231.DateActive = Children(i).Code
                                Case "DATEDEACTIVE" : z7231.DateDeactive = Children(i).Code
                                Case "CHECKACTIVE" : z7231.CheckActive = Children(i).Code
                                Case "DATECOMPLETE" : z7231.DateComplete = Children(i).Code
                                Case "DATEAPPROVED" : z7231.DateApproved = Children(i).Code
                                Case "DATECANCEL" : z7231.DateCancel = Children(i).Code
                                Case "DATEPENDING1" : z7231.DatePending1 = Children(i).Code
                                Case "DATEPENDING2" : z7231.DatePending2 = Children(i).Code
                                Case "CHECKSYNC" : z7231.CheckSync = Children(i).Code
                                Case "MATERIALFULLNAME" : z7231.MaterialFullName = Children(i).Code
                                Case "MATERIALOLDNAME" : z7231.MaterialOldName = Children(i).Code
                                Case "REMARK" : z7231.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "MATERIALCODE" : z7231.MaterialCode = Children(i).Data
                                Case "MATERIALNAME" : z7231.MaterialName = Children(i).Data
                                Case "MATERIALPNAME" : z7231.MaterialPName = Children(i).Data
                                Case "MATERIALSIMPLE" : z7231.MaterialSimple = Children(i).Data
                                Case "MATERIALCOLOR" : z7231.MaterialColor = Children(i).Data
                                Case "SEIMPORTGROUP" : z7231.seImportGroup = Children(i).Data
                                Case "CDIMPORTGROUP" : z7231.cdImportGroup = Children(i).Data
                                Case "IMPORTCODE" : z7231.ImportCode = Children(i).Data
                                Case "IMPORTNAME" : z7231.ImportName = Children(i).Data
                                Case "IMPORTCODE1" : z7231.ImportCode1 = Children(i).Data
                                Case "IMPORTNAME1" : z7231.ImportName1 = Children(i).Data
                                Case "ACCOUNTCODE" : z7231.AccountCode = Children(i).Data
                                Case "ACCOUNTNAME" : z7231.AccountName = Children(i).Data
                                Case "OTHERCODE1" : z7231.OtherCode1 = Children(i).Data
                                Case "OTHERCODE2" : z7231.OtherCode2 = Children(i).Data
                                Case "DEVELOPMENTCODE" : z7231.DevelopmentCode = Children(i).Data
                                Case "DEVELOPMENTNAME" : z7231.DevelopmentName = Children(i).Data
                                Case "MATERIALFOREIGN1" : z7231.MaterialForeign1 = Children(i).Data
                                Case "MATERIALFOREIGN2" : z7231.MaterialForeign2 = Children(i).Data
                                Case "WIDTH" : z7231.Width = Children(i).Data
                                Case "HEIGHT" : z7231.Height = Children(i).Data
                                Case "SIZENAME" : z7231.SizeName = Children(i).Data
                                Case "CHECKPRINT" : z7231.CheckPrint = Children(i).Data
                                Case "CHECKSP" : z7231.CheckSP = Children(i).Data
                                Case "SESPECIAL" : z7231.seSpecial = Children(i).Data
                                Case "CDSPECIAL" : z7231.cdSpecial = Children(i).Data
                                Case "SIZERANGETOOL" : z7231.SizeRangeTool = Children(i).Data
                                Case "CHECKKINDMATERIAL" : z7231.CheckKindMaterial = Children(i).Data
                                Case "CHECKMARKETTYPE" : z7231.CheckMarketType = Children(i).Data
                                Case "SEUNITPRICE" : z7231.seUnitPrice = Children(i).Data
                                Case "CDUNITPRICE" : z7231.cdUnitPrice = Children(i).Data
                                Case "DATEEXCHANGEPRICE" : z7231.DateExchangePrice = Children(i).Data
                                Case "EXCHANGEPRICE" : z7231.ExchangePrice = Children(i).Data
                                Case "PRICEUSD" : z7231.PriceUSD = Children(i).Data
                                Case "PRICEVND" : z7231.PriceVND = Children(i).Data
                                Case "SEDEPARTMENT" : z7231.seDepartment = Children(i).Data
                                Case "CDDEPARTMENT" : z7231.cdDepartment = Children(i).Data
                                Case "SELARGEGROUPMATERIAL" : z7231.seLargeGroupMaterial = Children(i).Data
                                Case "CDLARGEGROUPMATERIAL" : z7231.cdLargeGroupMaterial = Children(i).Data
                                Case "SESEMIGROUPMATERIAL" : z7231.seSemiGroupMaterial = Children(i).Data
                                Case "CDSEMIGROUPMATERIAL" : z7231.cdSemiGroupMaterial = Children(i).Data
                                Case "SEDETAILGROUPMATERIAL" : z7231.seDetailGroupMaterial = Children(i).Data
                                Case "CDDETAILGROUPMATERIAL" : z7231.cdDetailGroupMaterial = Children(i).Data
                                Case "SESPECGROUP1" : z7231.seSpecGroup1 = Children(i).Data
                                Case "CDSPECGROUP1" : z7231.cdSpecGroup1 = Children(i).Data
                                Case "SESPECGROUP2" : z7231.seSpecGroup2 = Children(i).Data
                                Case "CDSPECGROUP2" : z7231.cdSpecGroup2 = Children(i).Data
                                Case "SESPECGROUP3" : z7231.seSpecGroup3 = Children(i).Data
                                Case "CDSPECGROUP3" : z7231.cdSpecGroup3 = Children(i).Data
                                Case "SESPECGROUP4" : z7231.seSpecGroup4 = Children(i).Data
                                Case "CDSPECGROUP4" : z7231.cdSpecGroup4 = Children(i).Data
                                Case "SESPECGROUP5" : z7231.seSpecGroup5 = Children(i).Data
                                Case "CDSPECGROUP5" : z7231.cdSpecGroup5 = Children(i).Data
                                Case "SEUNITMATERIAL" : z7231.seUnitMaterial = Children(i).Data
                                Case "CDUNITMATERIAL" : z7231.cdUnitMaterial = Children(i).Data
                                Case "SEUNITPACKING" : z7231.seUnitPacking = Children(i).Data
                                Case "CDUNITPACKING" : z7231.cdUnitPacking = Children(i).Data
                                Case "SETAX" : z7231.seTax = Children(i).Data
                                Case "CDTAX" : z7231.cdTax = Children(i).Data
                                Case "PERTAXIMPORT" : z7231.PerTaxImport = Children(i).Data
                                Case "PERTAXVAT" : z7231.PerTaxVAT = Children(i).Data
                                Case "QTYBASIC" : z7231.QtyBasic = Children(i).Data
                                Case "QTYOPTIMUM" : z7231.QtyOptimum = Children(i).Data
                                Case "DAYOPTIMUM" : z7231.DayOptimum = Children(i).Data
                                Case "DAYESTIMATE" : z7231.DayEstimate = Children(i).Data
                                Case "PRICEMATERIAL" : z7231.PriceMaterial = Children(i).Data
                                Case "QTYMOQ" : z7231.QtyMOQ = Children(i).Data
                                Case "MAXINVENTORY" : z7231.MaxInventory = Children(i).Data
                                Case "MININVENTORY" : z7231.MinInventory = Children(i).Data
                                Case "REORDERQTY" : z7231.ReOrderQty = Children(i).Data
                                Case "CHECKDEVRND" : z7231.CheckDevRnD = Children(i).Data
                                Case "STATUSMATERIAL" : z7231.StatusMaterial = Children(i).Data
                                Case "BOMTYPE" : z7231.BOMType = Children(i).Data
                                Case "APPLYTYPE" : z7231.ApplyType = Children(i).Data
                                Case "DATESTART" : z7231.DateStart = Children(i).Data
                                Case "DATEOPTIMUM" : z7231.DateOptimum = Children(i).Data
                                Case "DATEESTIMATE" : z7231.DateEstimate = Children(i).Data
                                Case "DATEINBOUND" : z7231.DateInBound = Children(i).Data
                                Case "DATEOUTBOUND" : z7231.DateOutBound = Children(i).Data
                                Case "SUPPLYNAME" : z7231.SupplyName = Children(i).Data
                                Case "SUPPLYCODE" : z7231.SupplyCode = Children(i).Data
                                Case "SALESCODE" : z7231.SalesCode = Children(i).Data
                                Case "CHECK1" : z7231.Check1 = Children(i).Data
                                Case "CHECK2" : z7231.Check2 = Children(i).Data
                                Case "CHECK3" : z7231.Check3 = Children(i).Data
                                Case "CHECK4" : z7231.Check4 = Children(i).Data
                                Case "CHECK5" : z7231.Check5 = Children(i).Data
                                Case "CHECK6" : z7231.Check6 = Children(i).Data
                                Case "CHECK7" : z7231.Check7 = Children(i).Data
                                Case "CHECK8" : z7231.Check8 = Children(i).Data
                                Case "CHECK9" : z7231.Check9 = Children(i).Data
                                Case "CHECK10" : z7231.Check10 = Children(i).Data
                                Case "CHECKNAME1" : z7231.CheckName1 = Children(i).Data
                                Case "CHECKNAME2" : z7231.CheckName2 = Children(i).Data
                                Case "CHECKNAME3" : z7231.CheckName3 = Children(i).Data
                                Case "CHECKNAME4" : z7231.CheckName4 = Children(i).Data
                                Case "CHECKNAME5" : z7231.CheckName5 = Children(i).Data
                                Case "CHECKNAME6" : z7231.CheckName6 = Children(i).Data
                                Case "CHECKNAME7" : z7231.CheckName7 = Children(i).Data
                                Case "CHECKNAME8" : z7231.CheckName8 = Children(i).Data
                                Case "CHECKNAME9" : z7231.CheckName9 = Children(i).Data
                                Case "CHECKNAME10" : z7231.CheckName10 = Children(i).Data
                                Case "ACODEMATERIAL" : z7231.ACodeMaterial = Children(i).Data
                                Case "ACODETAX1" : z7231.ACodeTax1 = Children(i).Data
                                Case "ACODETAX2" : z7231.ACodeTax2 = Children(i).Data
                                Case "ACODETAX3" : z7231.ACodeTax3 = Children(i).Data
                                Case "ACODESALES" : z7231.ACodeSales = Children(i).Data
                                Case "ACODEINTSALES" : z7231.ACodeIntSales = Children(i).Data
                                Case "ACODECOGS" : z7231.ACodeCOGS = Children(i).Data
                                Case "ACODERETURN" : z7231.ACodeReturn = Children(i).Data
                                Case "ACODEDISCOUNT" : z7231.ACodeDiscount = Children(i).Data
                                Case "ACODEWIP" : z7231.ACodeWIP = Children(i).Data
                                Case "CHECKINVENTORY" : z7231.CheckInventory = Children(i).Data
                                Case "CHECKPOSITION" : z7231.CheckPosition = Children(i).Data
                                Case "CHECKLOTNO" : z7231.CheckLotNo = Children(i).Data
                                Case "CHECKPRICE" : z7231.CheckPrice = Children(i).Data
                                Case "SETAX1" : z7231.seTax1 = Children(i).Data
                                Case "CDTAX1" : z7231.cdTax1 = Children(i).Data
                                Case "PERTAX1" : z7231.PerTax1 = Children(i).Data
                                Case "SETAX2" : z7231.seTax2 = Children(i).Data
                                Case "CDTAX2" : z7231.cdTax2 = Children(i).Data
                                Case "PERTAX2" : z7231.PerTax2 = Children(i).Data
                                Case "SETAX3" : z7231.seTax3 = Children(i).Data
                                Case "CDTAX3" : z7231.cdTax3 = Children(i).Data
                                Case "PERTAX3" : z7231.PerTax3 = Children(i).Data
                                Case "SETAXVAT" : z7231.seTaxVAT = Children(i).Data
                                Case "CDTAXVAT" : z7231.cdTaxVAT = Children(i).Data
                                Case "SETAXIMPORT" : z7231.seTaxImport = Children(i).Data
                                Case "CDTAXIMPORT" : z7231.cdTaxImport = Children(i).Data
                                Case "SETAXEXPORT" : z7231.seTaxExport = Children(i).Data
                                Case "CDTAXEXPORT" : z7231.cdTaxExport = Children(i).Data
                                Case "SETAXSPECIAL" : z7231.seTaxSpecial = Children(i).Data
                                Case "CDTAXSPECIAL" : z7231.cdTaxSpecial = Children(i).Data
                                Case "SEACCMATERIAL" : z7231.seAccMaterial = Children(i).Data
                                Case "CDACCMATERIAL" : z7231.cdAccMaterial = Children(i).Data
                                Case "SEACCSALES" : z7231.seAccSales = Children(i).Data
                                Case "CDACCSALES" : z7231.cdAccSales = Children(i).Data
                                Case "SEACCINTSALES" : z7231.seAccIntSales = Children(i).Data
                                Case "CDACCINTSALES" : z7231.cdAccIntSales = Children(i).Data
                                Case "SEACCCOGS" : z7231.seAccCOGS = Children(i).Data
                                Case "CDACCCOGS" : z7231.cdAccCOGS = Children(i).Data
                                Case "SEACCRETURN" : z7231.seAccReturn = Children(i).Data
                                Case "CDACCRETURN" : z7231.cdAccReturn = Children(i).Data
                                Case "SEACCDISCOUNT" : z7231.seAccDiscount = Children(i).Data
                                Case "CDACCDISCOUNT" : z7231.cdAccDiscount = Children(i).Data
                                Case "SEACCWIP" : z7231.seAccWIP = Children(i).Data
                                Case "CDACCWIP" : z7231.cdAccWIP = Children(i).Data
                                Case "DATEINSERT" : z7231.DateInsert = Children(i).Data
                                Case "DATEUPDATE" : z7231.DateUpdate = Children(i).Data
                                Case "INCHARGEINSERT" : z7231.InchargeInsert = Children(i).Data
                                Case "INCHARGEUPDATE" : z7231.InchargeUpdate = Children(i).Data
                                Case "INCHARGECOMPLETE" : z7231.InchargeComplete = Children(i).Data
                                Case "INCHARGECANCEL" : z7231.InchargeCancel = Children(i).Data
                                Case "INCHARGEAPPROVED" : z7231.InchargeApproved = Children(i).Data
                                Case "INCHARGEPENDING1" : z7231.InchargePending1 = Children(i).Data
                                Case "INCHARGEPENDING2" : z7231.InchargePending2 = Children(i).Data
                                Case "CHECKUSE" : z7231.CheckUse = Children(i).Data
                                Case "DATEACTIVE" : z7231.DateActive = Children(i).Data
                                Case "DATEDEACTIVE" : z7231.DateDeactive = Children(i).Data
                                Case "CHECKACTIVE" : z7231.CheckActive = Children(i).Data
                                Case "DATECOMPLETE" : z7231.DateComplete = Children(i).Data
                                Case "DATEAPPROVED" : z7231.DateApproved = Children(i).Data
                                Case "DATECANCEL" : z7231.DateCancel = Children(i).Data
                                Case "DATEPENDING1" : z7231.DatePending1 = Children(i).Data
                                Case "DATEPENDING2" : z7231.DatePending2 = Children(i).Data
                                Case "CHECKSYNC" : z7231.CheckSync = Children(i).Data
                                Case "MATERIALFULLNAME" : z7231.MaterialFullName = Children(i).Data
                                Case "MATERIALOLDNAME" : z7231.MaterialOldName = Children(i).Data
                                Case "REMARK" : z7231.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7231_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW AREA
    '=========================================================================================================================================================
    Public Sub K7231_MOVE(ByRef a7231 As T7231_AREA, ByRef b7231 As T7231_AREA)
        Try
            If trim$(a7231.MaterialCode) = "" Then b7231.MaterialCode = "" Else b7231.MaterialCode = a7231.MaterialCode
            If trim$(a7231.MaterialName) = "" Then b7231.MaterialName = "" Else b7231.MaterialName = a7231.MaterialName
            If trim$(a7231.MaterialPName) = "" Then b7231.MaterialPName = "" Else b7231.MaterialPName = a7231.MaterialPName
            If trim$(a7231.MaterialSimple) = "" Then b7231.MaterialSimple = "" Else b7231.MaterialSimple = a7231.MaterialSimple
            If trim$(a7231.MaterialColor) = "" Then b7231.MaterialColor = "" Else b7231.MaterialColor = a7231.MaterialColor
            If trim$(a7231.seImportGroup) = "" Then b7231.seImportGroup = "" Else b7231.seImportGroup = a7231.seImportGroup
            If trim$(a7231.cdImportGroup) = "" Then b7231.cdImportGroup = "" Else b7231.cdImportGroup = a7231.cdImportGroup
            If trim$(a7231.ImportCode) = "" Then b7231.ImportCode = "" Else b7231.ImportCode = a7231.ImportCode
            If Trim$(a7231.ImportName) = "" Then b7231.ImportName = "" Else b7231.ImportName = a7231.ImportName
            If Trim$(a7231.ImportCode1) = "" Then b7231.ImportCode1 = "" Else b7231.ImportCode1 = a7231.ImportCode
            If Trim$(a7231.ImportName1) = "" Then b7231.ImportName1 = "" Else b7231.ImportName1 = a7231.ImportName
            If trim$(a7231.AccountCode) = "" Then b7231.AccountCode = "" Else b7231.AccountCode = a7231.AccountCode
            If trim$(a7231.AccountName) = "" Then b7231.AccountName = "" Else b7231.AccountName = a7231.AccountName
            If trim$(a7231.OtherCode1) = "" Then b7231.OtherCode1 = "" Else b7231.OtherCode1 = a7231.OtherCode1
            If trim$(a7231.OtherCode2) = "" Then b7231.OtherCode2 = "" Else b7231.OtherCode2 = a7231.OtherCode2
            If trim$(a7231.DevelopmentCode) = "" Then b7231.DevelopmentCode = "" Else b7231.DevelopmentCode = a7231.DevelopmentCode
            If trim$(a7231.DevelopmentName) = "" Then b7231.DevelopmentName = "" Else b7231.DevelopmentName = a7231.DevelopmentName
            If trim$(a7231.MaterialForeign1) = "" Then b7231.MaterialForeign1 = "" Else b7231.MaterialForeign1 = a7231.MaterialForeign1
            If trim$(a7231.MaterialForeign2) = "" Then b7231.MaterialForeign2 = "" Else b7231.MaterialForeign2 = a7231.MaterialForeign2
            If trim$(a7231.Width) = "" Then b7231.Width = "" Else b7231.Width = a7231.Width
            If trim$(a7231.Height) = "" Then b7231.Height = "" Else b7231.Height = a7231.Height
            If trim$(a7231.SizeName) = "" Then b7231.SizeName = "" Else b7231.SizeName = a7231.SizeName
            If trim$(a7231.CheckPrint) = "" Then b7231.CheckPrint = "" Else b7231.CheckPrint = a7231.CheckPrint
            If trim$(a7231.CheckSP) = "" Then b7231.CheckSP = "" Else b7231.CheckSP = a7231.CheckSP
            If trim$(a7231.seSpecial) = "" Then b7231.seSpecial = "" Else b7231.seSpecial = a7231.seSpecial
            If trim$(a7231.cdSpecial) = "" Then b7231.cdSpecial = "" Else b7231.cdSpecial = a7231.cdSpecial
            If trim$(a7231.SizeRangeTool) = "" Then b7231.SizeRangeTool = "" Else b7231.SizeRangeTool = a7231.SizeRangeTool
            If trim$(a7231.CheckKindMaterial) = "" Then b7231.CheckKindMaterial = "" Else b7231.CheckKindMaterial = a7231.CheckKindMaterial
            If trim$(a7231.CheckMarketType) = "" Then b7231.CheckMarketType = "" Else b7231.CheckMarketType = a7231.CheckMarketType
            If trim$(a7231.seUnitPrice) = "" Then b7231.seUnitPrice = "" Else b7231.seUnitPrice = a7231.seUnitPrice
            If trim$(a7231.cdUnitPrice) = "" Then b7231.cdUnitPrice = "" Else b7231.cdUnitPrice = a7231.cdUnitPrice
            If trim$(a7231.DateExchangePrice) = "" Then b7231.DateExchangePrice = "" Else b7231.DateExchangePrice = a7231.DateExchangePrice
            If trim$(a7231.ExchangePrice) = "" Then b7231.ExchangePrice = "" Else b7231.ExchangePrice = a7231.ExchangePrice
            If trim$(a7231.PriceUSD) = "" Then b7231.PriceUSD = "" Else b7231.PriceUSD = a7231.PriceUSD
            If trim$(a7231.PriceVND) = "" Then b7231.PriceVND = "" Else b7231.PriceVND = a7231.PriceVND
            If trim$(a7231.seDepartment) = "" Then b7231.seDepartment = "" Else b7231.seDepartment = a7231.seDepartment
            If trim$(a7231.cdDepartment) = "" Then b7231.cdDepartment = "" Else b7231.cdDepartment = a7231.cdDepartment
            If trim$(a7231.seLargeGroupMaterial) = "" Then b7231.seLargeGroupMaterial = "" Else b7231.seLargeGroupMaterial = a7231.seLargeGroupMaterial
            If trim$(a7231.cdLargeGroupMaterial) = "" Then b7231.cdLargeGroupMaterial = "" Else b7231.cdLargeGroupMaterial = a7231.cdLargeGroupMaterial
            If trim$(a7231.seSemiGroupMaterial) = "" Then b7231.seSemiGroupMaterial = "" Else b7231.seSemiGroupMaterial = a7231.seSemiGroupMaterial
            If trim$(a7231.cdSemiGroupMaterial) = "" Then b7231.cdSemiGroupMaterial = "" Else b7231.cdSemiGroupMaterial = a7231.cdSemiGroupMaterial
            If trim$(a7231.seDetailGroupMaterial) = "" Then b7231.seDetailGroupMaterial = "" Else b7231.seDetailGroupMaterial = a7231.seDetailGroupMaterial
            If trim$(a7231.cdDetailGroupMaterial) = "" Then b7231.cdDetailGroupMaterial = "" Else b7231.cdDetailGroupMaterial = a7231.cdDetailGroupMaterial
            If trim$(a7231.seSpecGroup1) = "" Then b7231.seSpecGroup1 = "" Else b7231.seSpecGroup1 = a7231.seSpecGroup1
            If trim$(a7231.cdSpecGroup1) = "" Then b7231.cdSpecGroup1 = "" Else b7231.cdSpecGroup1 = a7231.cdSpecGroup1
            If trim$(a7231.seSpecGroup2) = "" Then b7231.seSpecGroup2 = "" Else b7231.seSpecGroup2 = a7231.seSpecGroup2
            If trim$(a7231.cdSpecGroup2) = "" Then b7231.cdSpecGroup2 = "" Else b7231.cdSpecGroup2 = a7231.cdSpecGroup2
            If trim$(a7231.seSpecGroup3) = "" Then b7231.seSpecGroup3 = "" Else b7231.seSpecGroup3 = a7231.seSpecGroup3
            If trim$(a7231.cdSpecGroup3) = "" Then b7231.cdSpecGroup3 = "" Else b7231.cdSpecGroup3 = a7231.cdSpecGroup3
            If trim$(a7231.seSpecGroup4) = "" Then b7231.seSpecGroup4 = "" Else b7231.seSpecGroup4 = a7231.seSpecGroup4
            If trim$(a7231.cdSpecGroup4) = "" Then b7231.cdSpecGroup4 = "" Else b7231.cdSpecGroup4 = a7231.cdSpecGroup4
            If trim$(a7231.seSpecGroup5) = "" Then b7231.seSpecGroup5 = "" Else b7231.seSpecGroup5 = a7231.seSpecGroup5
            If trim$(a7231.cdSpecGroup5) = "" Then b7231.cdSpecGroup5 = "" Else b7231.cdSpecGroup5 = a7231.cdSpecGroup5
            If trim$(a7231.seUnitMaterial) = "" Then b7231.seUnitMaterial = "" Else b7231.seUnitMaterial = a7231.seUnitMaterial
            If trim$(a7231.cdUnitMaterial) = "" Then b7231.cdUnitMaterial = "" Else b7231.cdUnitMaterial = a7231.cdUnitMaterial
            If trim$(a7231.seUnitPacking) = "" Then b7231.seUnitPacking = "" Else b7231.seUnitPacking = a7231.seUnitPacking
            If trim$(a7231.cdUnitPacking) = "" Then b7231.cdUnitPacking = "" Else b7231.cdUnitPacking = a7231.cdUnitPacking
            If trim$(a7231.seTax) = "" Then b7231.seTax = "" Else b7231.seTax = a7231.seTax
            If trim$(a7231.cdTax) = "" Then b7231.cdTax = "" Else b7231.cdTax = a7231.cdTax
            If trim$(a7231.PerTaxImport) = "" Then b7231.PerTaxImport = "" Else b7231.PerTaxImport = a7231.PerTaxImport
            If trim$(a7231.PerTaxVAT) = "" Then b7231.PerTaxVAT = "" Else b7231.PerTaxVAT = a7231.PerTaxVAT
            If trim$(a7231.QtyBasic) = "" Then b7231.QtyBasic = "" Else b7231.QtyBasic = a7231.QtyBasic
            If trim$(a7231.QtyOptimum) = "" Then b7231.QtyOptimum = "" Else b7231.QtyOptimum = a7231.QtyOptimum
            If trim$(a7231.DayOptimum) = "" Then b7231.DayOptimum = "" Else b7231.DayOptimum = a7231.DayOptimum
            If trim$(a7231.DayEstimate) = "" Then b7231.DayEstimate = "" Else b7231.DayEstimate = a7231.DayEstimate
            If trim$(a7231.PriceMaterial) = "" Then b7231.PriceMaterial = "" Else b7231.PriceMaterial = a7231.PriceMaterial
            If trim$(a7231.QtyMOQ) = "" Then b7231.QtyMOQ = "" Else b7231.QtyMOQ = a7231.QtyMOQ
            If trim$(a7231.MaxInventory) = "" Then b7231.MaxInventory = "" Else b7231.MaxInventory = a7231.MaxInventory
            If trim$(a7231.MinInventory) = "" Then b7231.MinInventory = "" Else b7231.MinInventory = a7231.MinInventory
            If trim$(a7231.ReOrderQty) = "" Then b7231.ReOrderQty = "" Else b7231.ReOrderQty = a7231.ReOrderQty
            If trim$(a7231.CheckDevRnD) = "" Then b7231.CheckDevRnD = "" Else b7231.CheckDevRnD = a7231.CheckDevRnD
            If trim$(a7231.StatusMaterial) = "" Then b7231.StatusMaterial = "" Else b7231.StatusMaterial = a7231.StatusMaterial
            If trim$(a7231.BOMType) = "" Then b7231.BOMType = "" Else b7231.BOMType = a7231.BOMType
            If trim$(a7231.ApplyType) = "" Then b7231.ApplyType = "" Else b7231.ApplyType = a7231.ApplyType
            If trim$(a7231.DateStart) = "" Then b7231.DateStart = "" Else b7231.DateStart = a7231.DateStart
            If trim$(a7231.DateOptimum) = "" Then b7231.DateOptimum = "" Else b7231.DateOptimum = a7231.DateOptimum
            If trim$(a7231.DateEstimate) = "" Then b7231.DateEstimate = "" Else b7231.DateEstimate = a7231.DateEstimate
            If trim$(a7231.DateInBound) = "" Then b7231.DateInBound = "" Else b7231.DateInBound = a7231.DateInBound
            If trim$(a7231.DateOutBound) = "" Then b7231.DateOutBound = "" Else b7231.DateOutBound = a7231.DateOutBound
            If trim$(a7231.SupplyName) = "" Then b7231.SupplyName = "" Else b7231.SupplyName = a7231.SupplyName
            If trim$(a7231.SupplyCode) = "" Then b7231.SupplyCode = "" Else b7231.SupplyCode = a7231.SupplyCode
            If trim$(a7231.SalesCode) = "" Then b7231.SalesCode = "" Else b7231.SalesCode = a7231.SalesCode
            If trim$(a7231.Check1) = "" Then b7231.Check1 = "" Else b7231.Check1 = a7231.Check1
            If trim$(a7231.Check2) = "" Then b7231.Check2 = "" Else b7231.Check2 = a7231.Check2
            If trim$(a7231.Check3) = "" Then b7231.Check3 = "" Else b7231.Check3 = a7231.Check3
            If trim$(a7231.Check4) = "" Then b7231.Check4 = "" Else b7231.Check4 = a7231.Check4
            If trim$(a7231.Check5) = "" Then b7231.Check5 = "" Else b7231.Check5 = a7231.Check5
            If trim$(a7231.Check6) = "" Then b7231.Check6 = "" Else b7231.Check6 = a7231.Check6
            If trim$(a7231.Check7) = "" Then b7231.Check7 = "" Else b7231.Check7 = a7231.Check7
            If trim$(a7231.Check8) = "" Then b7231.Check8 = "" Else b7231.Check8 = a7231.Check8
            If trim$(a7231.Check9) = "" Then b7231.Check9 = "" Else b7231.Check9 = a7231.Check9
            If trim$(a7231.Check10) = "" Then b7231.Check10 = "" Else b7231.Check10 = a7231.Check10
            If trim$(a7231.CheckName1) = "" Then b7231.CheckName1 = "" Else b7231.CheckName1 = a7231.CheckName1
            If trim$(a7231.CheckName2) = "" Then b7231.CheckName2 = "" Else b7231.CheckName2 = a7231.CheckName2
            If trim$(a7231.CheckName3) = "" Then b7231.CheckName3 = "" Else b7231.CheckName3 = a7231.CheckName3
            If trim$(a7231.CheckName4) = "" Then b7231.CheckName4 = "" Else b7231.CheckName4 = a7231.CheckName4
            If trim$(a7231.CheckName5) = "" Then b7231.CheckName5 = "" Else b7231.CheckName5 = a7231.CheckName5
            If trim$(a7231.CheckName6) = "" Then b7231.CheckName6 = "" Else b7231.CheckName6 = a7231.CheckName6
            If trim$(a7231.CheckName7) = "" Then b7231.CheckName7 = "" Else b7231.CheckName7 = a7231.CheckName7
            If trim$(a7231.CheckName8) = "" Then b7231.CheckName8 = "" Else b7231.CheckName8 = a7231.CheckName8
            If trim$(a7231.CheckName9) = "" Then b7231.CheckName9 = "" Else b7231.CheckName9 = a7231.CheckName9
            If trim$(a7231.CheckName10) = "" Then b7231.CheckName10 = "" Else b7231.CheckName10 = a7231.CheckName10
            If trim$(a7231.ACodeMaterial) = "" Then b7231.ACodeMaterial = "" Else b7231.ACodeMaterial = a7231.ACodeMaterial
            If trim$(a7231.ACodeTax1) = "" Then b7231.ACodeTax1 = "" Else b7231.ACodeTax1 = a7231.ACodeTax1
            If trim$(a7231.ACodeTax2) = "" Then b7231.ACodeTax2 = "" Else b7231.ACodeTax2 = a7231.ACodeTax2
            If trim$(a7231.ACodeTax3) = "" Then b7231.ACodeTax3 = "" Else b7231.ACodeTax3 = a7231.ACodeTax3
            If trim$(a7231.ACodeSales) = "" Then b7231.ACodeSales = "" Else b7231.ACodeSales = a7231.ACodeSales
            If trim$(a7231.ACodeIntSales) = "" Then b7231.ACodeIntSales = "" Else b7231.ACodeIntSales = a7231.ACodeIntSales
            If trim$(a7231.ACodeCOGS) = "" Then b7231.ACodeCOGS = "" Else b7231.ACodeCOGS = a7231.ACodeCOGS
            If trim$(a7231.ACodeReturn) = "" Then b7231.ACodeReturn = "" Else b7231.ACodeReturn = a7231.ACodeReturn
            If trim$(a7231.ACodeDiscount) = "" Then b7231.ACodeDiscount = "" Else b7231.ACodeDiscount = a7231.ACodeDiscount
            If trim$(a7231.ACodeWIP) = "" Then b7231.ACodeWIP = "" Else b7231.ACodeWIP = a7231.ACodeWIP
            If trim$(a7231.CheckInventory) = "" Then b7231.CheckInventory = "" Else b7231.CheckInventory = a7231.CheckInventory
            If trim$(a7231.CheckPosition) = "" Then b7231.CheckPosition = "" Else b7231.CheckPosition = a7231.CheckPosition
            If trim$(a7231.CheckLotNo) = "" Then b7231.CheckLotNo = "" Else b7231.CheckLotNo = a7231.CheckLotNo
            If trim$(a7231.CheckPrice) = "" Then b7231.CheckPrice = "" Else b7231.CheckPrice = a7231.CheckPrice
            If trim$(a7231.seTax1) = "" Then b7231.seTax1 = "" Else b7231.seTax1 = a7231.seTax1
            If trim$(a7231.cdTax1) = "" Then b7231.cdTax1 = "" Else b7231.cdTax1 = a7231.cdTax1
            If trim$(a7231.PerTax1) = "" Then b7231.PerTax1 = "" Else b7231.PerTax1 = a7231.PerTax1
            If trim$(a7231.seTax2) = "" Then b7231.seTax2 = "" Else b7231.seTax2 = a7231.seTax2
            If trim$(a7231.cdTax2) = "" Then b7231.cdTax2 = "" Else b7231.cdTax2 = a7231.cdTax2
            If trim$(a7231.PerTax2) = "" Then b7231.PerTax2 = "" Else b7231.PerTax2 = a7231.PerTax2
            If trim$(a7231.seTax3) = "" Then b7231.seTax3 = "" Else b7231.seTax3 = a7231.seTax3
            If trim$(a7231.cdTax3) = "" Then b7231.cdTax3 = "" Else b7231.cdTax3 = a7231.cdTax3
            If trim$(a7231.PerTax3) = "" Then b7231.PerTax3 = "" Else b7231.PerTax3 = a7231.PerTax3
            If trim$(a7231.seTaxVAT) = "" Then b7231.seTaxVAT = "" Else b7231.seTaxVAT = a7231.seTaxVAT
            If trim$(a7231.cdTaxVAT) = "" Then b7231.cdTaxVAT = "" Else b7231.cdTaxVAT = a7231.cdTaxVAT
            If trim$(a7231.seTaxImport) = "" Then b7231.seTaxImport = "" Else b7231.seTaxImport = a7231.seTaxImport
            If trim$(a7231.cdTaxImport) = "" Then b7231.cdTaxImport = "" Else b7231.cdTaxImport = a7231.cdTaxImport
            If trim$(a7231.seTaxExport) = "" Then b7231.seTaxExport = "" Else b7231.seTaxExport = a7231.seTaxExport
            If trim$(a7231.cdTaxExport) = "" Then b7231.cdTaxExport = "" Else b7231.cdTaxExport = a7231.cdTaxExport
            If trim$(a7231.seTaxSpecial) = "" Then b7231.seTaxSpecial = "" Else b7231.seTaxSpecial = a7231.seTaxSpecial
            If trim$(a7231.cdTaxSpecial) = "" Then b7231.cdTaxSpecial = "" Else b7231.cdTaxSpecial = a7231.cdTaxSpecial
            If trim$(a7231.seAccMaterial) = "" Then b7231.seAccMaterial = "" Else b7231.seAccMaterial = a7231.seAccMaterial
            If trim$(a7231.cdAccMaterial) = "" Then b7231.cdAccMaterial = "" Else b7231.cdAccMaterial = a7231.cdAccMaterial
            If trim$(a7231.seAccSales) = "" Then b7231.seAccSales = "" Else b7231.seAccSales = a7231.seAccSales
            If trim$(a7231.cdAccSales) = "" Then b7231.cdAccSales = "" Else b7231.cdAccSales = a7231.cdAccSales
            If trim$(a7231.seAccIntSales) = "" Then b7231.seAccIntSales = "" Else b7231.seAccIntSales = a7231.seAccIntSales
            If trim$(a7231.cdAccIntSales) = "" Then b7231.cdAccIntSales = "" Else b7231.cdAccIntSales = a7231.cdAccIntSales
            If trim$(a7231.seAccCOGS) = "" Then b7231.seAccCOGS = "" Else b7231.seAccCOGS = a7231.seAccCOGS
            If trim$(a7231.cdAccCOGS) = "" Then b7231.cdAccCOGS = "" Else b7231.cdAccCOGS = a7231.cdAccCOGS
            If trim$(a7231.seAccReturn) = "" Then b7231.seAccReturn = "" Else b7231.seAccReturn = a7231.seAccReturn
            If trim$(a7231.cdAccReturn) = "" Then b7231.cdAccReturn = "" Else b7231.cdAccReturn = a7231.cdAccReturn
            If trim$(a7231.seAccDiscount) = "" Then b7231.seAccDiscount = "" Else b7231.seAccDiscount = a7231.seAccDiscount
            If trim$(a7231.cdAccDiscount) = "" Then b7231.cdAccDiscount = "" Else b7231.cdAccDiscount = a7231.cdAccDiscount
            If trim$(a7231.seAccWIP) = "" Then b7231.seAccWIP = "" Else b7231.seAccWIP = a7231.seAccWIP
            If trim$(a7231.cdAccWIP) = "" Then b7231.cdAccWIP = "" Else b7231.cdAccWIP = a7231.cdAccWIP
            If trim$(a7231.DateInsert) = "" Then b7231.DateInsert = "" Else b7231.DateInsert = a7231.DateInsert
            If trim$(a7231.DateUpdate) = "" Then b7231.DateUpdate = "" Else b7231.DateUpdate = a7231.DateUpdate
            If trim$(a7231.InchargeInsert) = "" Then b7231.InchargeInsert = "" Else b7231.InchargeInsert = a7231.InchargeInsert
            If trim$(a7231.InchargeUpdate) = "" Then b7231.InchargeUpdate = "" Else b7231.InchargeUpdate = a7231.InchargeUpdate
            If trim$(a7231.InchargeComplete) = "" Then b7231.InchargeComplete = "" Else b7231.InchargeComplete = a7231.InchargeComplete
            If trim$(a7231.InchargeCancel) = "" Then b7231.InchargeCancel = "" Else b7231.InchargeCancel = a7231.InchargeCancel
            If trim$(a7231.InchargeApproved) = "" Then b7231.InchargeApproved = "" Else b7231.InchargeApproved = a7231.InchargeApproved
            If trim$(a7231.InchargePending1) = "" Then b7231.InchargePending1 = "" Else b7231.InchargePending1 = a7231.InchargePending1
            If trim$(a7231.InchargePending2) = "" Then b7231.InchargePending2 = "" Else b7231.InchargePending2 = a7231.InchargePending2
            If trim$(a7231.CheckUse) = "" Then b7231.CheckUse = "" Else b7231.CheckUse = a7231.CheckUse
            If trim$(a7231.DateActive) = "" Then b7231.DateActive = "" Else b7231.DateActive = a7231.DateActive
            If trim$(a7231.DateDeactive) = "" Then b7231.DateDeactive = "" Else b7231.DateDeactive = a7231.DateDeactive
            If trim$(a7231.CheckActive) = "" Then b7231.CheckActive = "" Else b7231.CheckActive = a7231.CheckActive
            If trim$(a7231.DateComplete) = "" Then b7231.DateComplete = "" Else b7231.DateComplete = a7231.DateComplete
            If trim$(a7231.DateApproved) = "" Then b7231.DateApproved = "" Else b7231.DateApproved = a7231.DateApproved
            If trim$(a7231.DateCancel) = "" Then b7231.DateCancel = "" Else b7231.DateCancel = a7231.DateCancel
            If trim$(a7231.DatePending1) = "" Then b7231.DatePending1 = "" Else b7231.DatePending1 = a7231.DatePending1
            If trim$(a7231.DatePending2) = "" Then b7231.DatePending2 = "" Else b7231.DatePending2 = a7231.DatePending2
            If trim$(a7231.CheckSync) = "" Then b7231.CheckSync = "" Else b7231.CheckSync = a7231.CheckSync
            If trim$(a7231.MaterialFullName) = "" Then b7231.MaterialFullName = "" Else b7231.MaterialFullName = a7231.MaterialFullName
            If trim$(a7231.MaterialOldName) = "" Then b7231.MaterialOldName = "" Else b7231.MaterialOldName = a7231.MaterialOldName
            If trim$(a7231.Remark) = "" Then b7231.Remark = "" Else b7231.Remark = a7231.Remark
        Catch ex As Exception
            Call MsgBoxP("K7231_MOVE", vbCritical)
        End Try
    End Sub


End Module
