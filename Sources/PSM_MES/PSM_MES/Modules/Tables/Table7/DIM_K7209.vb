'=========================================================================================================================================================
'   TABLE : (PFK7209)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7209

    Structure T7209_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public GroupComponentBOM As String  '			char(6)		*
        Public GroupComponentSeq As Double  '			decimal		*
        Public Dseq As Double  '			decimal
        Public ProcessSeq As String  '			nvarchar(10)
        Public CustomerCode As String  '			char(6)
        Public selGroupComponent As String  '			char(3)
        Public cdGroupComponent As String  '			char(3)
        Public ComponentName As String  '			nvarchar(100)
        Public MaterialCode As String  '			char(6)
        Public seUnitMaterial As String  '			char(3)
        Public cdUnitMaterial As String  '			char(3)
        Public Specification As String  '			nvarchar(200)
        Public Width As String  '			nvarchar(20)
        Public WidthID As String  '			nvarchar(20)
        Public Height As String  '			nvarchar(20)
        Public SizeName As String  '			nvarchar(20)
        Public cdColorCode As String  '			char(3)
        Public ColorCode As String  '			char(6)
        Public ColorName As String  '			nvarchar(200)
        Public seShoesStatus As String  '			char(3)
        Public cdShoesStatus As String  '			char(3)
        Public seDepartment As String  '			char(3)
        Public cdDepartment As String  '			char(3)
        Public ContractID As String  '			char(6)
        Public ContracSeq As Double  '			decimal
        Public SupplierCode As String  '			char(6)
        Public PriceMaterial As Double  '			decimal
        Public ExchangeCost As Double  '			decimal
        Public ComplicationCost As Double  '			decimal
        Public AddedCost As Double  '			decimal
        Public ShippingRate As Double  '			decimal
        Public ShippingCost As Double  '			decimal
        Public PriceRnD As Double  '			decimal
        Public Price As Double  '			decimal
        Public seUnitPrice As String  '			char(3)
        Public cdUnitPrice As String  '			char(3)
        Public QtyComponent As Double  '			decimal
        Public Consumption As Double  '			decimal
        Public Loss As Double  '			decimal
        Public GrossUsage As Double  '			decimal
        Public MaterialAMT As Double  '			decimal
        Public MaterialAMTPurchasing As Double  '			decimal
        Public MaterialAMTSales As Double  '			decimal
        Public seSubProcess As String  '			char(3)
        Public cdSubProcess As String  '			char(3)
        Public seSpecialProcess As String  '			char(3)
        Public cdSpecialProcess As String  '			char(3)
        Public CheckMark As String  '			char(1)
        Public CheckUse As String  '			char(1)
        Public CheckP1 As String  '			char(1)
        Public CheckP2 As String  '			char(1)
        Public CheckP3 As String  '			char(1)
        Public CheckP4 As String  '			char(1)
        Public CheckP5 As String  '			char(1)
        Public CheckP6 As String  '			char(1)
        Public CheckP7 As String  '			char(1)
        Public CheckP8 As String  '			char(1)
        Public CheckP9 As String  '			char(1)
        Public CheckUse1 As String  '			char(1)
        Public CheckMatching As String  '			char(1)
        Public Remark As String  '			nvarchar(200)
        Public MaterialCode_K3011 As String  '			char(6)
        Public seSite As String  '			char(3)
        Public cdSite As String  '			char(3)
        '=========================================================================================================================================================
    End Structure

    Public D7209 As T7209_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK7209(GROUPCOMPONENTBOM As String, GROUPCOMPONENTSEQ As Double) As Boolean
        READ_PFK7209 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7209 "
            SQL = SQL & " WHERE K7209_GroupComponentBOM		 = '" & GroupComponentBOM & "' "
            SQL = SQL & "   AND K7209_GroupComponentSeq		 =  " & GroupComponentSeq & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7209_CLEAR() : GoTo SKIP_READ_PFK7209

            Call K7209_MOVE(rd)
            READ_PFK7209 = True

SKIP_READ_PFK7209:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7209", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK7209(GROUPCOMPONENTBOM As String, GROUPCOMPONENTSEQ As Double, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7209 "
            SQL = SQL & " WHERE K7209_GroupComponentBOM		 = '" & GroupComponentBOM & "' "
            SQL = SQL & "   AND K7209_GroupComponentSeq		 =  " & GroupComponentSeq & "  "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK7209", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK7209(z7209 As T7209_AREA) As Boolean
        WRITE_PFK7209 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z7209)

            SQL = " INSERT INTO PFK7209 "
            SQL = SQL & " ( "
            SQL = SQL & " K7209_GroupComponentBOM,"
            SQL = SQL & " K7209_GroupComponentSeq,"
            SQL = SQL & " K7209_Dseq,"
            SQL = SQL & " K7209_ProcessSeq,"
            SQL = SQL & " K7209_CustomerCode,"
            SQL = SQL & " K7209_selGroupComponent,"
            SQL = SQL & " K7209_cdGroupComponent,"
            SQL = SQL & " K7209_ComponentName,"
            SQL = SQL & " K7209_MaterialCode,"
            SQL = SQL & " K7209_seUnitMaterial,"
            SQL = SQL & " K7209_cdUnitMaterial,"
            SQL = SQL & " K7209_Specification,"
            SQL = SQL & " K7209_Width,"
            SQL = SQL & " K7209_WidthID,"
            SQL = SQL & " K7209_Height,"
            SQL = SQL & " K7209_SizeName,"
            SQL = SQL & " K7209_cdColorCode,"
            SQL = SQL & " K7209_ColorCode,"
            SQL = SQL & " K7209_ColorName,"
            SQL = SQL & " K7209_seShoesStatus,"
            SQL = SQL & " K7209_cdShoesStatus,"
            SQL = SQL & " K7209_seDepartment,"
            SQL = SQL & " K7209_cdDepartment,"
            SQL = SQL & " K7209_ContractID,"
            SQL = SQL & " K7209_ContracSeq,"
            SQL = SQL & " K7209_SupplierCode,"
            SQL = SQL & " K7209_PriceMaterial,"
            SQL = SQL & " K7209_ExchangeCost,"
            SQL = SQL & " K7209_ComplicationCost,"
            SQL = SQL & " K7209_AddedCost,"
            SQL = SQL & " K7209_ShippingRate,"
            SQL = SQL & " K7209_ShippingCost,"
            SQL = SQL & " K7209_PriceRnD,"
            SQL = SQL & " K7209_Price,"
            SQL = SQL & " K7209_seUnitPrice,"
            SQL = SQL & " K7209_cdUnitPrice,"
            SQL = SQL & " K7209_QtyComponent,"
            SQL = SQL & " K7209_Consumption,"
            SQL = SQL & " K7209_Loss,"
            SQL = SQL & " K7209_GrossUsage,"
            SQL = SQL & " K7209_MaterialAMT,"
            SQL = SQL & " K7209_MaterialAMTPurchasing,"
            SQL = SQL & " K7209_MaterialAMTSales,"
            SQL = SQL & " K7209_seSubProcess,"
            SQL = SQL & " K7209_cdSubProcess,"
            SQL = SQL & " K7209_seSpecialProcess,"
            SQL = SQL & " K7209_cdSpecialProcess,"
            SQL = SQL & " K7209_CheckMark,"
            SQL = SQL & " K7209_CheckUse,"
            SQL = SQL & " K7209_CheckP1,"
            SQL = SQL & " K7209_CheckP2,"
            SQL = SQL & " K7209_CheckP3,"
            SQL = SQL & " K7209_CheckP4,"
            SQL = SQL & " K7209_CheckP5,"
            SQL = SQL & " K7209_CheckP6,"
            SQL = SQL & " K7209_CheckP7,"
            SQL = SQL & " K7209_CheckP8,"
            SQL = SQL & " K7209_CheckP9,"
            SQL = SQL & " K7209_CheckUse1,"
            SQL = SQL & " K7209_CheckMatching,"
            SQL = SQL & " K7209_Remark,"
            SQL = SQL & " K7209_MaterialCode_K3011,"
            SQL = SQL & " K7209_seSite,"
            SQL = SQL & " K7209_cdSite "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z7209.GroupComponentBOM) & "', "
            SQL = SQL & "   " & FormatSQL(z7209.GroupComponentSeq) & ", "
            SQL = SQL & "   " & FormatSQL(z7209.Dseq) & ", "
            SQL = SQL & "  N'" & FormatSQL(z7209.ProcessSeq) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7209.CustomerCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7209.selGroupComponent) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7209.cdGroupComponent) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7209.ComponentName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7209.MaterialCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7209.seUnitMaterial) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7209.cdUnitMaterial) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7209.Specification) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7209.Width) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7209.WidthID) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7209.Height) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7209.SizeName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7209.cdColorCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7209.ColorCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7209.ColorName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7209.seShoesStatus) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7209.cdShoesStatus) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7209.seDepartment) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7209.cdDepartment) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7209.ContractID) & "', "
            SQL = SQL & "   " & FormatSQL(z7209.ContracSeq) & ", "
            SQL = SQL & "  N'" & FormatSQL(z7209.SupplierCode) & "', "
            SQL = SQL & "   " & FormatSQL(z7209.PriceMaterial) & ", "
            SQL = SQL & "   " & FormatSQL(z7209.ExchangeCost) & ", "
            SQL = SQL & "   " & FormatSQL(z7209.ComplicationCost) & ", "
            SQL = SQL & "   " & FormatSQL(z7209.AddedCost) & ", "
            SQL = SQL & "   " & FormatSQL(z7209.ShippingRate) & ", "
            SQL = SQL & "   " & FormatSQL(z7209.ShippingCost) & ", "
            SQL = SQL & "   " & FormatSQL(z7209.PriceRnD) & ", "
            SQL = SQL & "   " & FormatSQL(z7209.Price) & ", "
            SQL = SQL & "  N'" & FormatSQL(z7209.seUnitPrice) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7209.cdUnitPrice) & "', "
            SQL = SQL & "   " & FormatSQL(z7209.QtyComponent) & ", "
            SQL = SQL & "   " & FormatSQL(z7209.Consumption) & ", "
            SQL = SQL & "   " & FormatSQL(z7209.Loss) & ", "
            SQL = SQL & "   " & FormatSQL(z7209.GrossUsage) & ", "
            SQL = SQL & "   " & FormatSQL(z7209.MaterialAMT) & ", "
            SQL = SQL & "   " & FormatSQL(z7209.MaterialAMTPurchasing) & ", "
            SQL = SQL & "   " & FormatSQL(z7209.MaterialAMTSales) & ", "
            SQL = SQL & "  N'" & FormatSQL(z7209.seSubProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7209.cdSubProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7209.seSpecialProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7209.cdSpecialProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7209.CheckMark) & "', "
            SQL = SQL & "  N'1', "
            SQL = SQL & "  N'" & FormatSQL(z7209.CheckP1) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7209.CheckP2) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7209.CheckP3) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7209.CheckP4) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7209.CheckP5) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7209.CheckP6) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7209.CheckP7) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7209.CheckP8) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7209.CheckP9) & "', "
            SQL = SQL & "  N'1', "
            SQL = SQL & "  N'" & FormatSQL(z7209.CheckMatching) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7209.Remark) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7209.MaterialCode_K3011) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7209.seSite) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7209.cdSite) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK7209 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK7209", vbCritical)
        Finally
            Call GetFullInformation("PFK7209", "I", SQL)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK7209(z7209 As T7209_AREA) As Boolean
        REWRITE_PFK7209 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z7209)

            SQL = " UPDATE PFK7209 SET "
            SQL = SQL & "    K7209_Dseq      =  " & FormatSQL(z7209.Dseq) & ", "
            SQL = SQL & "    K7209_ProcessSeq      = N'" & FormatSQL(z7209.ProcessSeq) & "', "
            SQL = SQL & "    K7209_CustomerCode      = N'" & FormatSQL(z7209.CustomerCode) & "', "
            SQL = SQL & "    K7209_selGroupComponent      = N'" & FormatSQL(z7209.selGroupComponent) & "', "
            SQL = SQL & "    K7209_cdGroupComponent      = N'" & FormatSQL(z7209.cdGroupComponent) & "', "
            SQL = SQL & "    K7209_ComponentName      = N'" & FormatSQL(z7209.ComponentName) & "', "
            SQL = SQL & "    K7209_MaterialCode      = N'" & FormatSQL(z7209.MaterialCode) & "', "
            SQL = SQL & "    K7209_seUnitMaterial      = N'" & FormatSQL(z7209.seUnitMaterial) & "', "
            SQL = SQL & "    K7209_cdUnitMaterial      = N'" & FormatSQL(z7209.cdUnitMaterial) & "', "
            SQL = SQL & "    K7209_Specification      = N'" & FormatSQL(z7209.Specification) & "', "
            SQL = SQL & "    K7209_Width      = N'" & FormatSQL(z7209.Width) & "', "
            SQL = SQL & "    K7209_WidthID      = N'" & FormatSQL(z7209.WidthID) & "', "
            SQL = SQL & "    K7209_Height      = N'" & FormatSQL(z7209.Height) & "', "
            SQL = SQL & "    K7209_SizeName      = N'" & FormatSQL(z7209.SizeName) & "', "
            SQL = SQL & "    K7209_cdColorCode      = N'" & FormatSQL(z7209.cdColorCode) & "', "
            SQL = SQL & "    K7209_ColorCode      = N'" & FormatSQL(z7209.ColorCode) & "', "
            SQL = SQL & "    K7209_ColorName      = N'" & FormatSQL(z7209.ColorName) & "', "
            SQL = SQL & "    K7209_seShoesStatus      = N'" & FormatSQL(z7209.seShoesStatus) & "', "
            SQL = SQL & "    K7209_cdShoesStatus      = N'" & FormatSQL(z7209.cdShoesStatus) & "', "
            SQL = SQL & "    K7209_seDepartment      = N'" & FormatSQL(z7209.seDepartment) & "', "
            SQL = SQL & "    K7209_cdDepartment      = N'" & FormatSQL(z7209.cdDepartment) & "', "
            SQL = SQL & "    K7209_ContractID      = N'" & FormatSQL(z7209.ContractID) & "', "
            SQL = SQL & "    K7209_ContracSeq      =  " & FormatSQL(z7209.ContracSeq) & ", "
            SQL = SQL & "    K7209_SupplierCode      = N'" & FormatSQL(z7209.SupplierCode) & "', "
            SQL = SQL & "    K7209_PriceMaterial      =  " & FormatSQL(z7209.PriceMaterial) & ", "
            SQL = SQL & "    K7209_ExchangeCost      =  " & FormatSQL(z7209.ExchangeCost) & ", "
            SQL = SQL & "    K7209_ComplicationCost      =  " & FormatSQL(z7209.ComplicationCost) & ", "
            SQL = SQL & "    K7209_AddedCost      =  " & FormatSQL(z7209.AddedCost) & ", "
            SQL = SQL & "    K7209_ShippingRate      =  " & FormatSQL(z7209.ShippingRate) & ", "
            SQL = SQL & "    K7209_ShippingCost      =  " & FormatSQL(z7209.ShippingCost) & ", "
            SQL = SQL & "    K7209_PriceRnD      =  " & FormatSQL(z7209.PriceRnD) & ", "
            SQL = SQL & "    K7209_Price      =  " & FormatSQL(z7209.Price) & ", "
            SQL = SQL & "    K7209_seUnitPrice      = N'" & FormatSQL(z7209.seUnitPrice) & "', "
            SQL = SQL & "    K7209_cdUnitPrice      = N'" & FormatSQL(z7209.cdUnitPrice) & "', "
            SQL = SQL & "    K7209_QtyComponent      =  " & FormatSQL(z7209.QtyComponent) & ", "
            SQL = SQL & "    K7209_Consumption      =  " & FormatSQL(z7209.Consumption) & ", "
            SQL = SQL & "    K7209_Loss      =  " & FormatSQL(z7209.Loss) & ", "
            SQL = SQL & "    K7209_GrossUsage      =  " & FormatSQL(z7209.GrossUsage) & ", "
            SQL = SQL & "    K7209_MaterialAMT      =  " & FormatSQL(z7209.MaterialAMT) & ", "
            SQL = SQL & "    K7209_MaterialAMTPurchasing      =  " & FormatSQL(z7209.MaterialAMTPurchasing) & ", "
            SQL = SQL & "    K7209_MaterialAMTSales      =  " & FormatSQL(z7209.MaterialAMTSales) & ", "
            SQL = SQL & "    K7209_seSubProcess      = N'" & FormatSQL(z7209.seSubProcess) & "', "
            SQL = SQL & "    K7209_cdSubProcess      = N'" & FormatSQL(z7209.cdSubProcess) & "', "
            SQL = SQL & "    K7209_seSpecialProcess      = N'" & FormatSQL(z7209.seSpecialProcess) & "', "
            SQL = SQL & "    K7209_cdSpecialProcess      = N'" & FormatSQL(z7209.cdSpecialProcess) & "', "
            SQL = SQL & "    K7209_CheckMark      = N'" & FormatSQL(z7209.CheckMark) & "', "
            SQL = SQL & "    K7209_CheckUse      = N'" & FormatSQL(z7209.CheckUse) & "', "
            SQL = SQL & "    K7209_CheckP1      = N'" & FormatSQL(z7209.CheckP1) & "', "
            SQL = SQL & "    K7209_CheckP2      = N'" & FormatSQL(z7209.CheckP2) & "', "
            SQL = SQL & "    K7209_CheckP3      = N'" & FormatSQL(z7209.CheckP3) & "', "
            SQL = SQL & "    K7209_CheckP4      = N'" & FormatSQL(z7209.CheckP4) & "', "
            SQL = SQL & "    K7209_CheckP5      = N'" & FormatSQL(z7209.CheckP5) & "', "
            SQL = SQL & "    K7209_CheckP6      = N'" & FormatSQL(z7209.CheckP6) & "', "
            SQL = SQL & "    K7209_CheckP7      = N'" & FormatSQL(z7209.CheckP7) & "', "
            SQL = SQL & "    K7209_CheckP8      = N'" & FormatSQL(z7209.CheckP8) & "', "
            SQL = SQL & "    K7209_CheckP9      = N'" & FormatSQL(z7209.CheckP9) & "', "
            SQL = SQL & "    K7209_CheckUse1      = N'" & FormatSQL(z7209.CheckUse1) & "', "
            SQL = SQL & "    K7209_CheckMatching      = N'" & FormatSQL(z7209.CheckMatching) & "', "
            SQL = SQL & "    K7209_Remark      = N'" & FormatSQL(z7209.Remark) & "', "
            SQL = SQL & "    K7209_MaterialCode_K3011      = N'" & FormatSQL(z7209.MaterialCode_K3011) & "', "
            SQL = SQL & "    K7209_seSite      = N'" & FormatSQL(z7209.seSite) & "', "
            SQL = SQL & "    K7209_cdSite      = N'" & FormatSQL(z7209.cdSite) & "'  "
            SQL = SQL & " WHERE K7209_GroupComponentBOM		 = '" & z7209.GroupComponentBOM & "' "
            SQL = SQL & "   AND K7209_GroupComponentSeq		 =  " & z7209.GroupComponentSeq & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK7209 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK7209", vbCritical)
        Finally
            Call GetFullInformation("PFK7209", "U", SQL)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK7209(z7209 As T7209_AREA) As Boolean
        DELETE_PFK7209 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z7209)

            SQL = " DELETE FROM PFK7209  "
            SQL = SQL & " WHERE K7209_GroupComponentBOM		 = '" & z7209.GroupComponentBOM & "' "
            SQL = SQL & "   AND K7209_GroupComponentSeq		 =  " & z7209.GroupComponentSeq & "  "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK7209 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK7209", vbCritical)
        Finally
            Call GetFullInformation("PFK7209", "U", SQL)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D7209_CLEAR()
        Try

            D7209.GroupComponentBOM = ""
            D7209.GroupComponentSeq = 0
            D7209.Dseq = 0
            D7209.ProcessSeq = ""
            D7209.CustomerCode = ""
            D7209.selGroupComponent = ""
            D7209.cdGroupComponent = ""
            D7209.ComponentName = ""
            D7209.MaterialCode = ""
            D7209.seUnitMaterial = ""
            D7209.cdUnitMaterial = ""
            D7209.Specification = ""
            D7209.Width = ""
            D7209.WidthID = ""
            D7209.Height = ""
            D7209.SizeName = ""
            D7209.cdColorCode = ""
            D7209.ColorCode = ""
            D7209.ColorName = ""
            D7209.seShoesStatus = ""
            D7209.cdShoesStatus = ""
            D7209.seDepartment = ""
            D7209.cdDepartment = ""
            D7209.ContractID = ""
            D7209.ContracSeq = 0
            D7209.SupplierCode = ""
            D7209.PriceMaterial = 0
            D7209.ExchangeCost = 0
            D7209.ComplicationCost = 0
            D7209.AddedCost = 0
            D7209.ShippingRate = 0
            D7209.ShippingCost = 0
            D7209.PriceRnD = 0
            D7209.Price = 0
            D7209.seUnitPrice = ""
            D7209.cdUnitPrice = ""
            D7209.QtyComponent = 0
            D7209.Consumption = 0
            D7209.Loss = 0
            D7209.GrossUsage = 0
            D7209.MaterialAMT = 0
            D7209.MaterialAMTPurchasing = 0
            D7209.MaterialAMTSales = 0
            D7209.seSubProcess = ""
            D7209.cdSubProcess = ""
            D7209.seSpecialProcess = ""
            D7209.cdSpecialProcess = ""
            D7209.CheckMark = ""
            D7209.CheckUse = ""
            D7209.CheckP1 = ""
            D7209.CheckP2 = ""
            D7209.CheckP3 = ""
            D7209.CheckP4 = ""
            D7209.CheckP5 = ""
            D7209.CheckP6 = ""
            D7209.CheckP7 = ""
            D7209.CheckP8 = ""
            D7209.CheckP9 = ""
            D7209.CheckUse1 = ""
            D7209.CheckMatching = ""
            D7209.Remark = ""
            D7209.MaterialCode_K3011 = ""
            D7209.seSite = ""
            D7209.cdSite = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D7209_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x7209 As T7209_AREA)
        Try

            x7209.GroupComponentBOM = trim$(x7209.GroupComponentBOM)
            x7209.GroupComponentSeq = trim$(x7209.GroupComponentSeq)
            x7209.Dseq = trim$(x7209.Dseq)
            x7209.ProcessSeq = trim$(x7209.ProcessSeq)
            x7209.CustomerCode = trim$(x7209.CustomerCode)
            x7209.selGroupComponent = trim$(x7209.selGroupComponent)
            x7209.cdGroupComponent = trim$(x7209.cdGroupComponent)
            x7209.ComponentName = trim$(x7209.ComponentName)
            x7209.MaterialCode = trim$(x7209.MaterialCode)
            x7209.seUnitMaterial = trim$(x7209.seUnitMaterial)
            x7209.cdUnitMaterial = trim$(x7209.cdUnitMaterial)
            x7209.Specification = trim$(x7209.Specification)
            x7209.Width = trim$(x7209.Width)
            x7209.WidthID = trim$(x7209.WidthID)
            x7209.Height = trim$(x7209.Height)
            x7209.SizeName = trim$(x7209.SizeName)
            x7209.cdColorCode = trim$(x7209.cdColorCode)
            x7209.ColorCode = trim$(x7209.ColorCode)
            x7209.ColorName = trim$(x7209.ColorName)
            x7209.seShoesStatus = trim$(x7209.seShoesStatus)
            x7209.cdShoesStatus = trim$(x7209.cdShoesStatus)
            x7209.seDepartment = trim$(x7209.seDepartment)
            x7209.cdDepartment = trim$(x7209.cdDepartment)
            x7209.ContractID = trim$(x7209.ContractID)
            x7209.ContracSeq = trim$(x7209.ContracSeq)
            x7209.SupplierCode = trim$(x7209.SupplierCode)
            x7209.PriceMaterial = trim$(x7209.PriceMaterial)
            x7209.ExchangeCost = trim$(x7209.ExchangeCost)
            x7209.ComplicationCost = trim$(x7209.ComplicationCost)
            x7209.AddedCost = trim$(x7209.AddedCost)
            x7209.ShippingRate = trim$(x7209.ShippingRate)
            x7209.ShippingCost = trim$(x7209.ShippingCost)
            x7209.PriceRnD = trim$(x7209.PriceRnD)
            x7209.Price = trim$(x7209.Price)
            x7209.seUnitPrice = trim$(x7209.seUnitPrice)
            x7209.cdUnitPrice = trim$(x7209.cdUnitPrice)
            x7209.QtyComponent = trim$(x7209.QtyComponent)
            x7209.Consumption = trim$(x7209.Consumption)
            x7209.Loss = trim$(x7209.Loss)
            x7209.GrossUsage = trim$(x7209.GrossUsage)
            x7209.MaterialAMT = trim$(x7209.MaterialAMT)
            x7209.MaterialAMTPurchasing = trim$(x7209.MaterialAMTPurchasing)
            x7209.MaterialAMTSales = trim$(x7209.MaterialAMTSales)
            x7209.seSubProcess = trim$(x7209.seSubProcess)
            x7209.cdSubProcess = trim$(x7209.cdSubProcess)
            x7209.seSpecialProcess = trim$(x7209.seSpecialProcess)
            x7209.cdSpecialProcess = trim$(x7209.cdSpecialProcess)
            x7209.CheckMark = trim$(x7209.CheckMark)
            x7209.CheckUse = trim$(x7209.CheckUse)
            x7209.CheckP1 = trim$(x7209.CheckP1)
            x7209.CheckP2 = trim$(x7209.CheckP2)
            x7209.CheckP3 = trim$(x7209.CheckP3)
            x7209.CheckP4 = trim$(x7209.CheckP4)
            x7209.CheckP5 = trim$(x7209.CheckP5)
            x7209.CheckP6 = trim$(x7209.CheckP6)
            x7209.CheckP7 = trim$(x7209.CheckP7)
            x7209.CheckP8 = trim$(x7209.CheckP8)
            x7209.CheckP9 = trim$(x7209.CheckP9)
            x7209.CheckUse1 = trim$(x7209.CheckUse1)
            x7209.CheckMatching = trim$(x7209.CheckMatching)
            x7209.Remark = trim$(x7209.Remark)
            x7209.MaterialCode_K3011 = trim$(x7209.MaterialCode_K3011)
            x7209.seSite = Trim$(x7209.seSite)
            x7209.cdSite = trim$(x7209.cdSite)

            If trim$(x7209.GroupComponentBOM) = "" Then x7209.GroupComponentBOM = Space(1)
            If trim$(x7209.GroupComponentSeq) = "" Then x7209.GroupComponentSeq = 0
            If trim$(x7209.Dseq) = "" Then x7209.Dseq = 0
            If trim$(x7209.ProcessSeq) = "" Then x7209.ProcessSeq = Space(1)
            If trim$(x7209.CustomerCode) = "" Then x7209.CustomerCode = Space(1)
            If trim$(x7209.selGroupComponent) = "" Then x7209.selGroupComponent = Space(1)
            If trim$(x7209.cdGroupComponent) = "" Then x7209.cdGroupComponent = Space(1)
            If trim$(x7209.ComponentName) = "" Then x7209.ComponentName = Space(1)
            If trim$(x7209.MaterialCode) = "" Then x7209.MaterialCode = Space(1)
            If trim$(x7209.seUnitMaterial) = "" Then x7209.seUnitMaterial = Space(1)
            If trim$(x7209.cdUnitMaterial) = "" Then x7209.cdUnitMaterial = Space(1)
            If trim$(x7209.Specification) = "" Then x7209.Specification = Space(1)
            If trim$(x7209.Width) = "" Then x7209.Width = Space(1)
            If trim$(x7209.WidthID) = "" Then x7209.WidthID = Space(1)
            If trim$(x7209.Height) = "" Then x7209.Height = Space(1)
            If trim$(x7209.SizeName) = "" Then x7209.SizeName = Space(1)
            If trim$(x7209.cdColorCode) = "" Then x7209.cdColorCode = Space(1)
            If trim$(x7209.ColorCode) = "" Then x7209.ColorCode = Space(1)
            If trim$(x7209.ColorName) = "" Then x7209.ColorName = Space(1)
            If trim$(x7209.seShoesStatus) = "" Then x7209.seShoesStatus = Space(1)
            If trim$(x7209.cdShoesStatus) = "" Then x7209.cdShoesStatus = Space(1)
            If trim$(x7209.seDepartment) = "" Then x7209.seDepartment = Space(1)
            If trim$(x7209.cdDepartment) = "" Then x7209.cdDepartment = Space(1)
            If trim$(x7209.ContractID) = "" Then x7209.ContractID = Space(1)
            If trim$(x7209.ContracSeq) = "" Then x7209.ContracSeq = 0
            If trim$(x7209.SupplierCode) = "" Then x7209.SupplierCode = Space(1)
            If trim$(x7209.PriceMaterial) = "" Then x7209.PriceMaterial = 0
            If trim$(x7209.ExchangeCost) = "" Then x7209.ExchangeCost = 0
            If trim$(x7209.ComplicationCost) = "" Then x7209.ComplicationCost = 0
            If trim$(x7209.AddedCost) = "" Then x7209.AddedCost = 0
            If trim$(x7209.ShippingRate) = "" Then x7209.ShippingRate = 0
            If trim$(x7209.ShippingCost) = "" Then x7209.ShippingCost = 0
            If trim$(x7209.PriceRnD) = "" Then x7209.PriceRnD = 0
            If trim$(x7209.Price) = "" Then x7209.Price = 0
            If trim$(x7209.seUnitPrice) = "" Then x7209.seUnitPrice = Space(1)
            If trim$(x7209.cdUnitPrice) = "" Then x7209.cdUnitPrice = Space(1)
            If trim$(x7209.QtyComponent) = "" Then x7209.QtyComponent = 0
            If trim$(x7209.Consumption) = "" Then x7209.Consumption = 0
            If trim$(x7209.Loss) = "" Then x7209.Loss = 0
            If trim$(x7209.GrossUsage) = "" Then x7209.GrossUsage = 0
            If trim$(x7209.MaterialAMT) = "" Then x7209.MaterialAMT = 0
            If trim$(x7209.MaterialAMTPurchasing) = "" Then x7209.MaterialAMTPurchasing = 0
            If trim$(x7209.MaterialAMTSales) = "" Then x7209.MaterialAMTSales = 0
            If trim$(x7209.seSubProcess) = "" Then x7209.seSubProcess = Space(1)
            If trim$(x7209.cdSubProcess) = "" Then x7209.cdSubProcess = Space(1)
            If trim$(x7209.seSpecialProcess) = "" Then x7209.seSpecialProcess = Space(1)
            If trim$(x7209.cdSpecialProcess) = "" Then x7209.cdSpecialProcess = Space(1)
            If trim$(x7209.CheckMark) = "" Then x7209.CheckMark = Space(1)
            If trim$(x7209.CheckUse) = "" Then x7209.CheckUse = Space(1)
            If trim$(x7209.CheckP1) = "" Then x7209.CheckP1 = Space(1)
            If trim$(x7209.CheckP2) = "" Then x7209.CheckP2 = Space(1)
            If trim$(x7209.CheckP3) = "" Then x7209.CheckP3 = Space(1)
            If trim$(x7209.CheckP4) = "" Then x7209.CheckP4 = Space(1)
            If trim$(x7209.CheckP5) = "" Then x7209.CheckP5 = Space(1)
            If trim$(x7209.CheckP6) = "" Then x7209.CheckP6 = Space(1)
            If trim$(x7209.CheckP7) = "" Then x7209.CheckP7 = Space(1)
            If trim$(x7209.CheckP8) = "" Then x7209.CheckP8 = Space(1)
            If trim$(x7209.CheckP9) = "" Then x7209.CheckP9 = Space(1)
            If trim$(x7209.CheckUse1) = "" Then x7209.CheckUse1 = Space(1)
            If trim$(x7209.CheckMatching) = "" Then x7209.CheckMatching = Space(1)
            If trim$(x7209.Remark) = "" Then x7209.Remark = Space(1)
            If trim$(x7209.MaterialCode_K3011) = "" Then x7209.MaterialCode_K3011 = Space(1)
            If Trim$(x7209.seSite) = "" Then x7209.seSite = Space(1)
            If trim$(x7209.cdSite) = "" Then x7209.cdSite = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K7209_MOVE(rs7209 As SqlClient.SqlDataReader)
        Try

            Call D7209_CLEAR()

            If IsdbNull(rs7209!K7209_GroupComponentBOM) = False Then D7209.GroupComponentBOM = Trim$(rs7209!K7209_GroupComponentBOM)
            If IsdbNull(rs7209!K7209_GroupComponentSeq) = False Then D7209.GroupComponentSeq = Trim$(rs7209!K7209_GroupComponentSeq)
            If IsdbNull(rs7209!K7209_Dseq) = False Then D7209.Dseq = Trim$(rs7209!K7209_Dseq)
            If IsdbNull(rs7209!K7209_ProcessSeq) = False Then D7209.ProcessSeq = Trim$(rs7209!K7209_ProcessSeq)
            If IsdbNull(rs7209!K7209_CustomerCode) = False Then D7209.CustomerCode = Trim$(rs7209!K7209_CustomerCode)
            If IsdbNull(rs7209!K7209_selGroupComponent) = False Then D7209.selGroupComponent = Trim$(rs7209!K7209_selGroupComponent)
            If IsdbNull(rs7209!K7209_cdGroupComponent) = False Then D7209.cdGroupComponent = Trim$(rs7209!K7209_cdGroupComponent)
            If IsdbNull(rs7209!K7209_ComponentName) = False Then D7209.ComponentName = Trim$(rs7209!K7209_ComponentName)
            If IsdbNull(rs7209!K7209_MaterialCode) = False Then D7209.MaterialCode = Trim$(rs7209!K7209_MaterialCode)
            If IsdbNull(rs7209!K7209_seUnitMaterial) = False Then D7209.seUnitMaterial = Trim$(rs7209!K7209_seUnitMaterial)
            If IsdbNull(rs7209!K7209_cdUnitMaterial) = False Then D7209.cdUnitMaterial = Trim$(rs7209!K7209_cdUnitMaterial)
            If IsdbNull(rs7209!K7209_Specification) = False Then D7209.Specification = Trim$(rs7209!K7209_Specification)
            If IsdbNull(rs7209!K7209_Width) = False Then D7209.Width = Trim$(rs7209!K7209_Width)
            If IsdbNull(rs7209!K7209_WidthID) = False Then D7209.WidthID = Trim$(rs7209!K7209_WidthID)
            If IsdbNull(rs7209!K7209_Height) = False Then D7209.Height = Trim$(rs7209!K7209_Height)
            If IsdbNull(rs7209!K7209_SizeName) = False Then D7209.SizeName = Trim$(rs7209!K7209_SizeName)
            If IsdbNull(rs7209!K7209_cdColorCode) = False Then D7209.cdColorCode = Trim$(rs7209!K7209_cdColorCode)
            If IsdbNull(rs7209!K7209_ColorCode) = False Then D7209.ColorCode = Trim$(rs7209!K7209_ColorCode)
            If IsdbNull(rs7209!K7209_ColorName) = False Then D7209.ColorName = Trim$(rs7209!K7209_ColorName)
            If IsdbNull(rs7209!K7209_seShoesStatus) = False Then D7209.seShoesStatus = Trim$(rs7209!K7209_seShoesStatus)
            If IsdbNull(rs7209!K7209_cdShoesStatus) = False Then D7209.cdShoesStatus = Trim$(rs7209!K7209_cdShoesStatus)
            If IsdbNull(rs7209!K7209_seDepartment) = False Then D7209.seDepartment = Trim$(rs7209!K7209_seDepartment)
            If IsdbNull(rs7209!K7209_cdDepartment) = False Then D7209.cdDepartment = Trim$(rs7209!K7209_cdDepartment)
            If IsdbNull(rs7209!K7209_ContractID) = False Then D7209.ContractID = Trim$(rs7209!K7209_ContractID)
            If IsdbNull(rs7209!K7209_ContracSeq) = False Then D7209.ContracSeq = Trim$(rs7209!K7209_ContracSeq)
            If IsdbNull(rs7209!K7209_SupplierCode) = False Then D7209.SupplierCode = Trim$(rs7209!K7209_SupplierCode)
            If IsdbNull(rs7209!K7209_PriceMaterial) = False Then D7209.PriceMaterial = Trim$(rs7209!K7209_PriceMaterial)
            If IsdbNull(rs7209!K7209_ExchangeCost) = False Then D7209.ExchangeCost = Trim$(rs7209!K7209_ExchangeCost)
            If IsdbNull(rs7209!K7209_ComplicationCost) = False Then D7209.ComplicationCost = Trim$(rs7209!K7209_ComplicationCost)
            If IsdbNull(rs7209!K7209_AddedCost) = False Then D7209.AddedCost = Trim$(rs7209!K7209_AddedCost)
            If IsdbNull(rs7209!K7209_ShippingRate) = False Then D7209.ShippingRate = Trim$(rs7209!K7209_ShippingRate)
            If IsdbNull(rs7209!K7209_ShippingCost) = False Then D7209.ShippingCost = Trim$(rs7209!K7209_ShippingCost)
            If IsdbNull(rs7209!K7209_PriceRnD) = False Then D7209.PriceRnD = Trim$(rs7209!K7209_PriceRnD)
            If IsdbNull(rs7209!K7209_Price) = False Then D7209.Price = Trim$(rs7209!K7209_Price)
            If IsdbNull(rs7209!K7209_seUnitPrice) = False Then D7209.seUnitPrice = Trim$(rs7209!K7209_seUnitPrice)
            If IsdbNull(rs7209!K7209_cdUnitPrice) = False Then D7209.cdUnitPrice = Trim$(rs7209!K7209_cdUnitPrice)
            If IsdbNull(rs7209!K7209_QtyComponent) = False Then D7209.QtyComponent = Trim$(rs7209!K7209_QtyComponent)
            If IsdbNull(rs7209!K7209_Consumption) = False Then D7209.Consumption = Trim$(rs7209!K7209_Consumption)
            If IsdbNull(rs7209!K7209_Loss) = False Then D7209.Loss = Trim$(rs7209!K7209_Loss)
            If IsdbNull(rs7209!K7209_GrossUsage) = False Then D7209.GrossUsage = Trim$(rs7209!K7209_GrossUsage)
            If IsdbNull(rs7209!K7209_MaterialAMT) = False Then D7209.MaterialAMT = Trim$(rs7209!K7209_MaterialAMT)
            If IsdbNull(rs7209!K7209_MaterialAMTPurchasing) = False Then D7209.MaterialAMTPurchasing = Trim$(rs7209!K7209_MaterialAMTPurchasing)
            If IsdbNull(rs7209!K7209_MaterialAMTSales) = False Then D7209.MaterialAMTSales = Trim$(rs7209!K7209_MaterialAMTSales)
            If IsdbNull(rs7209!K7209_seSubProcess) = False Then D7209.seSubProcess = Trim$(rs7209!K7209_seSubProcess)
            If IsdbNull(rs7209!K7209_cdSubProcess) = False Then D7209.cdSubProcess = Trim$(rs7209!K7209_cdSubProcess)
            If IsdbNull(rs7209!K7209_seSpecialProcess) = False Then D7209.seSpecialProcess = Trim$(rs7209!K7209_seSpecialProcess)
            If IsdbNull(rs7209!K7209_cdSpecialProcess) = False Then D7209.cdSpecialProcess = Trim$(rs7209!K7209_cdSpecialProcess)
            If IsdbNull(rs7209!K7209_CheckMark) = False Then D7209.CheckMark = Trim$(rs7209!K7209_CheckMark)
            If IsdbNull(rs7209!K7209_CheckUse) = False Then D7209.CheckUse = Trim$(rs7209!K7209_CheckUse)
            If IsdbNull(rs7209!K7209_CheckP1) = False Then D7209.CheckP1 = Trim$(rs7209!K7209_CheckP1)
            If IsdbNull(rs7209!K7209_CheckP2) = False Then D7209.CheckP2 = Trim$(rs7209!K7209_CheckP2)
            If IsdbNull(rs7209!K7209_CheckP3) = False Then D7209.CheckP3 = Trim$(rs7209!K7209_CheckP3)
            If IsdbNull(rs7209!K7209_CheckP4) = False Then D7209.CheckP4 = Trim$(rs7209!K7209_CheckP4)
            If IsdbNull(rs7209!K7209_CheckP5) = False Then D7209.CheckP5 = Trim$(rs7209!K7209_CheckP5)
            If IsdbNull(rs7209!K7209_CheckP6) = False Then D7209.CheckP6 = Trim$(rs7209!K7209_CheckP6)
            If IsdbNull(rs7209!K7209_CheckP7) = False Then D7209.CheckP7 = Trim$(rs7209!K7209_CheckP7)
            If IsdbNull(rs7209!K7209_CheckP8) = False Then D7209.CheckP8 = Trim$(rs7209!K7209_CheckP8)
            If IsdbNull(rs7209!K7209_CheckP9) = False Then D7209.CheckP9 = Trim$(rs7209!K7209_CheckP9)
            If IsdbNull(rs7209!K7209_CheckUse1) = False Then D7209.CheckUse1 = Trim$(rs7209!K7209_CheckUse1)
            If IsdbNull(rs7209!K7209_CheckMatching) = False Then D7209.CheckMatching = Trim$(rs7209!K7209_CheckMatching)
            If IsdbNull(rs7209!K7209_Remark) = False Then D7209.Remark = Trim$(rs7209!K7209_Remark)
            If IsdbNull(rs7209!K7209_MaterialCode_K3011) = False Then D7209.MaterialCode_K3011 = Trim$(rs7209!K7209_MaterialCode_K3011)
            If IsDBNull(rs7209!K7209_seSite) = False Then D7209.seSite = Trim$(rs7209!K7209_seSite)
            If IsdbNull(rs7209!K7209_cdSite) = False Then D7209.cdSite = Trim$(rs7209!K7209_cdSite)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K7209_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K7209_MOVE(rs7209 As DataRow)
        Try

            Call D7209_CLEAR()

            If IsdbNull(rs7209!K7209_GroupComponentBOM) = False Then D7209.GroupComponentBOM = Trim$(rs7209!K7209_GroupComponentBOM)
            If IsdbNull(rs7209!K7209_GroupComponentSeq) = False Then D7209.GroupComponentSeq = Trim$(rs7209!K7209_GroupComponentSeq)
            If IsdbNull(rs7209!K7209_Dseq) = False Then D7209.Dseq = Trim$(rs7209!K7209_Dseq)
            If IsdbNull(rs7209!K7209_ProcessSeq) = False Then D7209.ProcessSeq = Trim$(rs7209!K7209_ProcessSeq)
            If IsdbNull(rs7209!K7209_CustomerCode) = False Then D7209.CustomerCode = Trim$(rs7209!K7209_CustomerCode)
            If IsdbNull(rs7209!K7209_selGroupComponent) = False Then D7209.selGroupComponent = Trim$(rs7209!K7209_selGroupComponent)
            If IsdbNull(rs7209!K7209_cdGroupComponent) = False Then D7209.cdGroupComponent = Trim$(rs7209!K7209_cdGroupComponent)
            If IsdbNull(rs7209!K7209_ComponentName) = False Then D7209.ComponentName = Trim$(rs7209!K7209_ComponentName)
            If IsdbNull(rs7209!K7209_MaterialCode) = False Then D7209.MaterialCode = Trim$(rs7209!K7209_MaterialCode)
            If IsdbNull(rs7209!K7209_seUnitMaterial) = False Then D7209.seUnitMaterial = Trim$(rs7209!K7209_seUnitMaterial)
            If IsdbNull(rs7209!K7209_cdUnitMaterial) = False Then D7209.cdUnitMaterial = Trim$(rs7209!K7209_cdUnitMaterial)
            If IsdbNull(rs7209!K7209_Specification) = False Then D7209.Specification = Trim$(rs7209!K7209_Specification)
            If IsdbNull(rs7209!K7209_Width) = False Then D7209.Width = Trim$(rs7209!K7209_Width)
            If IsdbNull(rs7209!K7209_WidthID) = False Then D7209.WidthID = Trim$(rs7209!K7209_WidthID)
            If IsdbNull(rs7209!K7209_Height) = False Then D7209.Height = Trim$(rs7209!K7209_Height)
            If IsdbNull(rs7209!K7209_SizeName) = False Then D7209.SizeName = Trim$(rs7209!K7209_SizeName)
            If IsdbNull(rs7209!K7209_cdColorCode) = False Then D7209.cdColorCode = Trim$(rs7209!K7209_cdColorCode)
            If IsdbNull(rs7209!K7209_ColorCode) = False Then D7209.ColorCode = Trim$(rs7209!K7209_ColorCode)
            If IsdbNull(rs7209!K7209_ColorName) = False Then D7209.ColorName = Trim$(rs7209!K7209_ColorName)
            If IsdbNull(rs7209!K7209_seShoesStatus) = False Then D7209.seShoesStatus = Trim$(rs7209!K7209_seShoesStatus)
            If IsdbNull(rs7209!K7209_cdShoesStatus) = False Then D7209.cdShoesStatus = Trim$(rs7209!K7209_cdShoesStatus)
            If IsdbNull(rs7209!K7209_seDepartment) = False Then D7209.seDepartment = Trim$(rs7209!K7209_seDepartment)
            If IsdbNull(rs7209!K7209_cdDepartment) = False Then D7209.cdDepartment = Trim$(rs7209!K7209_cdDepartment)
            If IsdbNull(rs7209!K7209_ContractID) = False Then D7209.ContractID = Trim$(rs7209!K7209_ContractID)
            If IsdbNull(rs7209!K7209_ContracSeq) = False Then D7209.ContracSeq = Trim$(rs7209!K7209_ContracSeq)
            If IsdbNull(rs7209!K7209_SupplierCode) = False Then D7209.SupplierCode = Trim$(rs7209!K7209_SupplierCode)
            If IsdbNull(rs7209!K7209_PriceMaterial) = False Then D7209.PriceMaterial = Trim$(rs7209!K7209_PriceMaterial)
            If IsdbNull(rs7209!K7209_ExchangeCost) = False Then D7209.ExchangeCost = Trim$(rs7209!K7209_ExchangeCost)
            If IsdbNull(rs7209!K7209_ComplicationCost) = False Then D7209.ComplicationCost = Trim$(rs7209!K7209_ComplicationCost)
            If IsdbNull(rs7209!K7209_AddedCost) = False Then D7209.AddedCost = Trim$(rs7209!K7209_AddedCost)
            If IsdbNull(rs7209!K7209_ShippingRate) = False Then D7209.ShippingRate = Trim$(rs7209!K7209_ShippingRate)
            If IsdbNull(rs7209!K7209_ShippingCost) = False Then D7209.ShippingCost = Trim$(rs7209!K7209_ShippingCost)
            If IsdbNull(rs7209!K7209_PriceRnD) = False Then D7209.PriceRnD = Trim$(rs7209!K7209_PriceRnD)
            If IsdbNull(rs7209!K7209_Price) = False Then D7209.Price = Trim$(rs7209!K7209_Price)
            If IsdbNull(rs7209!K7209_seUnitPrice) = False Then D7209.seUnitPrice = Trim$(rs7209!K7209_seUnitPrice)
            If IsdbNull(rs7209!K7209_cdUnitPrice) = False Then D7209.cdUnitPrice = Trim$(rs7209!K7209_cdUnitPrice)
            If IsdbNull(rs7209!K7209_QtyComponent) = False Then D7209.QtyComponent = Trim$(rs7209!K7209_QtyComponent)
            If IsdbNull(rs7209!K7209_Consumption) = False Then D7209.Consumption = Trim$(rs7209!K7209_Consumption)
            If IsdbNull(rs7209!K7209_Loss) = False Then D7209.Loss = Trim$(rs7209!K7209_Loss)
            If IsdbNull(rs7209!K7209_GrossUsage) = False Then D7209.GrossUsage = Trim$(rs7209!K7209_GrossUsage)
            If IsdbNull(rs7209!K7209_MaterialAMT) = False Then D7209.MaterialAMT = Trim$(rs7209!K7209_MaterialAMT)
            If IsdbNull(rs7209!K7209_MaterialAMTPurchasing) = False Then D7209.MaterialAMTPurchasing = Trim$(rs7209!K7209_MaterialAMTPurchasing)
            If IsdbNull(rs7209!K7209_MaterialAMTSales) = False Then D7209.MaterialAMTSales = Trim$(rs7209!K7209_MaterialAMTSales)
            If IsdbNull(rs7209!K7209_seSubProcess) = False Then D7209.seSubProcess = Trim$(rs7209!K7209_seSubProcess)
            If IsdbNull(rs7209!K7209_cdSubProcess) = False Then D7209.cdSubProcess = Trim$(rs7209!K7209_cdSubProcess)
            If IsdbNull(rs7209!K7209_seSpecialProcess) = False Then D7209.seSpecialProcess = Trim$(rs7209!K7209_seSpecialProcess)
            If IsdbNull(rs7209!K7209_cdSpecialProcess) = False Then D7209.cdSpecialProcess = Trim$(rs7209!K7209_cdSpecialProcess)
            If IsdbNull(rs7209!K7209_CheckMark) = False Then D7209.CheckMark = Trim$(rs7209!K7209_CheckMark)
            If IsdbNull(rs7209!K7209_CheckUse) = False Then D7209.CheckUse = Trim$(rs7209!K7209_CheckUse)
            If IsdbNull(rs7209!K7209_CheckP1) = False Then D7209.CheckP1 = Trim$(rs7209!K7209_CheckP1)
            If IsdbNull(rs7209!K7209_CheckP2) = False Then D7209.CheckP2 = Trim$(rs7209!K7209_CheckP2)
            If IsdbNull(rs7209!K7209_CheckP3) = False Then D7209.CheckP3 = Trim$(rs7209!K7209_CheckP3)
            If IsdbNull(rs7209!K7209_CheckP4) = False Then D7209.CheckP4 = Trim$(rs7209!K7209_CheckP4)
            If IsdbNull(rs7209!K7209_CheckP5) = False Then D7209.CheckP5 = Trim$(rs7209!K7209_CheckP5)
            If IsdbNull(rs7209!K7209_CheckP6) = False Then D7209.CheckP6 = Trim$(rs7209!K7209_CheckP6)
            If IsdbNull(rs7209!K7209_CheckP7) = False Then D7209.CheckP7 = Trim$(rs7209!K7209_CheckP7)
            If IsdbNull(rs7209!K7209_CheckP8) = False Then D7209.CheckP8 = Trim$(rs7209!K7209_CheckP8)
            If IsdbNull(rs7209!K7209_CheckP9) = False Then D7209.CheckP9 = Trim$(rs7209!K7209_CheckP9)
            If IsdbNull(rs7209!K7209_CheckUse1) = False Then D7209.CheckUse1 = Trim$(rs7209!K7209_CheckUse1)
            If IsdbNull(rs7209!K7209_CheckMatching) = False Then D7209.CheckMatching = Trim$(rs7209!K7209_CheckMatching)
            If IsdbNull(rs7209!K7209_Remark) = False Then D7209.Remark = Trim$(rs7209!K7209_Remark)
            If IsdbNull(rs7209!K7209_MaterialCode_K3011) = False Then D7209.MaterialCode_K3011 = Trim$(rs7209!K7209_MaterialCode_K3011)
            If IsDBNull(rs7209!K7209_seSite) = False Then D7209.seSite = Trim$(rs7209!K7209_seSite)
            If IsdbNull(rs7209!K7209_cdSite) = False Then D7209.cdSite = Trim$(rs7209!K7209_cdSite)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K7209_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K7209_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z7209 As T7209_AREA, GROUPCOMPONENTBOM As String, GROUPCOMPONENTSEQ As Double) As Boolean

        K7209_MOVE = False

        Try
            If READ_PFK7209(GROUPCOMPONENTBOM, GROUPCOMPONENTSEQ) = True Then
                z7209 = D7209
                K7209_MOVE = True
            Else
                z7209 = Nothing
            End If

            If getColumnIndex(spr, "GroupComponentBOM") > -1 Then z7209.GroupComponentBOM = getDataM(spr, getColumnIndex(spr, "GroupComponentBOM"), xRow)
            If getColumnIndex(spr, "GroupComponentSeq") > -1 Then z7209.GroupComponentSeq = getDataM(spr, getColumnIndex(spr, "GroupComponentSeq"), xRow)
            If getColumnIndex(spr, "Dseq") > -1 Then z7209.Dseq = getDataM(spr, getColumnIndex(spr, "Dseq"), xRow)
            If getColumnIndex(spr, "ProcessSeq") > -1 Then z7209.ProcessSeq = getDataM(spr, getColumnIndex(spr, "ProcessSeq"), xRow)
            If getColumnIndex(spr, "CustomerCode") > -1 Then z7209.CustomerCode = getDataM(spr, getColumnIndex(spr, "CustomerCode"), xRow)
            If getColumnIndex(spr, "selGroupComponent") > -1 Then z7209.selGroupComponent = getDataM(spr, getColumnIndex(spr, "selGroupComponent"), xRow)
            If getColumnIndex(spr, "cdGroupComponent") > -1 Then z7209.cdGroupComponent = getDataM(spr, getColumnIndex(spr, "cdGroupComponent"), xRow)
            If getColumnIndex(spr, "ComponentName") > -1 Then z7209.ComponentName = getDataM(spr, getColumnIndex(spr, "ComponentName"), xRow)
            If getColumnIndex(spr, "MaterialCode") > -1 Then z7209.MaterialCode = getDataM(spr, getColumnIndex(spr, "MaterialCode"), xRow)
            If getColumnIndex(spr, "seUnitMaterial") > -1 Then z7209.seUnitMaterial = getDataM(spr, getColumnIndex(spr, "seUnitMaterial"), xRow)
            If getColumnIndex(spr, "cdUnitMaterial") > -1 Then z7209.cdUnitMaterial = getDataM(spr, getColumnIndex(spr, "cdUnitMaterial"), xRow)
            If getColumnIndex(spr, "Specification") > -1 Then z7209.Specification = getDataM(spr, getColumnIndex(spr, "Specification"), xRow)
            If getColumnIndex(spr, "Width") > -1 Then z7209.Width = getDataM(spr, getColumnIndex(spr, "Width"), xRow)
            If getColumnIndex(spr, "WidthID") > -1 Then z7209.WidthID = getDataM(spr, getColumnIndex(spr, "WidthID"), xRow)
            If getColumnIndex(spr, "Height") > -1 Then z7209.Height = getDataM(spr, getColumnIndex(spr, "Height"), xRow)
            If getColumnIndex(spr, "SizeName") > -1 Then z7209.SizeName = getDataM(spr, getColumnIndex(spr, "SizeName"), xRow)
            If getColumnIndex(spr, "cdColorCode") > -1 Then z7209.cdColorCode = getDataM(spr, getColumnIndex(spr, "cdColorCode"), xRow)
            If getColumnIndex(spr, "ColorCode") > -1 Then z7209.ColorCode = getDataM(spr, getColumnIndex(spr, "ColorCode"), xRow)
            If getColumnIndex(spr, "ColorName") > -1 Then z7209.ColorName = getDataM(spr, getColumnIndex(spr, "ColorName"), xRow)
            If getColumnIndex(spr, "seShoesStatus") > -1 Then z7209.seShoesStatus = getDataM(spr, getColumnIndex(spr, "seShoesStatus"), xRow)
            If getColumnIndex(spr, "cdShoesStatus") > -1 Then z7209.cdShoesStatus = getDataM(spr, getColumnIndex(spr, "cdShoesStatus"), xRow)
            If getColumnIndex(spr, "seDepartment") > -1 Then z7209.seDepartment = getDataM(spr, getColumnIndex(spr, "seDepartment"), xRow)
            If getColumnIndex(spr, "cdDepartment") > -1 Then z7209.cdDepartment = getDataM(spr, getColumnIndex(spr, "cdDepartment"), xRow)
            If getColumnIndex(spr, "ContractID") > -1 Then z7209.ContractID = getDataM(spr, getColumnIndex(spr, "ContractID"), xRow)
            If getColumnIndex(spr, "ContracSeq") > -1 Then z7209.ContracSeq = getDataM(spr, getColumnIndex(spr, "ContracSeq"), xRow)
            If getColumnIndex(spr, "SupplierCode") > -1 Then z7209.SupplierCode = getDataM(spr, getColumnIndex(spr, "SupplierCode"), xRow)
            If getColumnIndex(spr, "PriceMaterial") > -1 Then z7209.PriceMaterial = getDataM(spr, getColumnIndex(spr, "PriceMaterial"), xRow)
            If getColumnIndex(spr, "ExchangeCost") > -1 Then z7209.ExchangeCost = getDataM(spr, getColumnIndex(spr, "ExchangeCost"), xRow)
            If getColumnIndex(spr, "ComplicationCost") > -1 Then z7209.ComplicationCost = getDataM(spr, getColumnIndex(spr, "ComplicationCost"), xRow)
            If getColumnIndex(spr, "AddedCost") > -1 Then z7209.AddedCost = getDataM(spr, getColumnIndex(spr, "AddedCost"), xRow)
            If getColumnIndex(spr, "ShippingRate") > -1 Then z7209.ShippingRate = getDataM(spr, getColumnIndex(spr, "ShippingRate"), xRow)
            If getColumnIndex(spr, "ShippingCost") > -1 Then z7209.ShippingCost = getDataM(spr, getColumnIndex(spr, "ShippingCost"), xRow)
            If getColumnIndex(spr, "PriceRnD") > -1 Then z7209.PriceRnD = getDataM(spr, getColumnIndex(spr, "PriceRnD"), xRow)
            If getColumnIndex(spr, "Price") > -1 Then z7209.Price = getDataM(spr, getColumnIndex(spr, "Price"), xRow)
            If getColumnIndex(spr, "seUnitPrice") > -1 Then z7209.seUnitPrice = getDataM(spr, getColumnIndex(spr, "seUnitPrice"), xRow)
            If getColumnIndex(spr, "cdUnitPrice") > -1 Then z7209.cdUnitPrice = getDataM(spr, getColumnIndex(spr, "cdUnitPrice"), xRow)
            If getColumnIndex(spr, "QtyComponent") > -1 Then z7209.QtyComponent = getDataM(spr, getColumnIndex(spr, "QtyComponent"), xRow)
            If getColumnIndex(spr, "Consumption") > -1 Then z7209.Consumption = getDataM(spr, getColumnIndex(spr, "Consumption"), xRow)
            If getColumnIndex(spr, "Loss") > -1 Then z7209.Loss = getDataM(spr, getColumnIndex(spr, "Loss"), xRow)
            If getColumnIndex(spr, "GrossUsage") > -1 Then z7209.GrossUsage = getDataM(spr, getColumnIndex(spr, "GrossUsage"), xRow)
            If getColumnIndex(spr, "MaterialAMT") > -1 Then z7209.MaterialAMT = getDataM(spr, getColumnIndex(spr, "MaterialAMT"), xRow)
            If getColumnIndex(spr, "MaterialAMTPurchasing") > -1 Then z7209.MaterialAMTPurchasing = getDataM(spr, getColumnIndex(spr, "MaterialAMTPurchasing"), xRow)
            If getColumnIndex(spr, "MaterialAMTSales") > -1 Then z7209.MaterialAMTSales = getDataM(spr, getColumnIndex(spr, "MaterialAMTSales"), xRow)
            If getColumnIndex(spr, "seSubProcess") > -1 Then z7209.seSubProcess = getDataM(spr, getColumnIndex(spr, "seSubProcess"), xRow)
            If getColumnIndex(spr, "cdSubProcess") > -1 Then z7209.cdSubProcess = getDataM(spr, getColumnIndex(spr, "cdSubProcess"), xRow)
            If getColumnIndex(spr, "seSpecialProcess") > -1 Then z7209.seSpecialProcess = getDataM(spr, getColumnIndex(spr, "seSpecialProcess"), xRow)
            If getColumnIndex(spr, "cdSpecialProcess") > -1 Then z7209.cdSpecialProcess = getDataM(spr, getColumnIndex(spr, "cdSpecialProcess"), xRow)
            If getColumnIndex(spr, "CheckMark") > -1 Then z7209.CheckMark = getDataM(spr, getColumnIndex(spr, "CheckMark"), xRow)
            If getColumnIndex(spr, "CheckUse") > -1 Then z7209.CheckUse = getDataM(spr, getColumnIndex(spr, "CheckUse"), xRow)
            If getColumnIndex(spr, "CheckP1") > -1 Then z7209.CheckP1 = getDataM(spr, getColumnIndex(spr, "CheckP1"), xRow)
            If getColumnIndex(spr, "CheckP2") > -1 Then z7209.CheckP2 = getDataM(spr, getColumnIndex(spr, "CheckP2"), xRow)
            If getColumnIndex(spr, "CheckP3") > -1 Then z7209.CheckP3 = getDataM(spr, getColumnIndex(spr, "CheckP3"), xRow)
            If getColumnIndex(spr, "CheckP4") > -1 Then z7209.CheckP4 = getDataM(spr, getColumnIndex(spr, "CheckP4"), xRow)
            If getColumnIndex(spr, "CheckP5") > -1 Then z7209.CheckP5 = getDataM(spr, getColumnIndex(spr, "CheckP5"), xRow)
            If getColumnIndex(spr, "CheckP6") > -1 Then z7209.CheckP6 = getDataM(spr, getColumnIndex(spr, "CheckP6"), xRow)
            If getColumnIndex(spr, "CheckP7") > -1 Then z7209.CheckP7 = getDataM(spr, getColumnIndex(spr, "CheckP7"), xRow)
            If getColumnIndex(spr, "CheckP8") > -1 Then z7209.CheckP8 = getDataM(spr, getColumnIndex(spr, "CheckP8"), xRow)
            If getColumnIndex(spr, "CheckP9") > -1 Then z7209.CheckP9 = getDataM(spr, getColumnIndex(spr, "CheckP9"), xRow)
            If getColumnIndex(spr, "CheckUse1") > -1 Then z7209.CheckUse1 = getDataM(spr, getColumnIndex(spr, "CheckUse1"), xRow)
            If getColumnIndex(spr, "CheckMatching") > -1 Then z7209.CheckMatching = getDataM(spr, getColumnIndex(spr, "CheckMatching"), xRow)
            If getColumnIndex(spr, "Remark") > -1 Then z7209.Remark = getDataM(spr, getColumnIndex(spr, "Remark"), xRow)
            If getColumnIndex(spr, "MaterialCode_K3011") > -1 Then z7209.MaterialCode_K3011 = getDataM(spr, getColumnIndex(spr, "MaterialCode_K3011"), xRow)
            If getColumnIndex(spr, "seSite") > -1 Then z7209.seSite = getDataM(spr, getColumnIndex(spr, "seSite"), xRow)
            If getColumnIndex(spr, "cdSite") > -1 Then z7209.cdSite = getDataM(spr, getColumnIndex(spr, "cdSite"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7209_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K7209_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z7209 As T7209_AREA, CheckClear As Boolean, GROUPCOMPONENTBOM As String, GROUPCOMPONENTSEQ As Double) As Boolean

        K7209_MOVE = False

        Try
            If READ_PFK7209(GROUPCOMPONENTBOM, GROUPCOMPONENTSEQ) = True Then
                z7209 = D7209
                K7209_MOVE = True
            Else
                If CheckClear = True Then z7209 = Nothing
            End If

            If getColumnIndex(spr, "GroupComponentBOM") > -1 Then z7209.GroupComponentBOM = getDataM(spr, getColumnIndex(spr, "GroupComponentBOM"), xRow)
            If getColumnIndex(spr, "GroupComponentSeq") > -1 Then z7209.GroupComponentSeq = getDataM(spr, getColumnIndex(spr, "GroupComponentSeq"), xRow)
            If getColumnIndex(spr, "Dseq") > -1 Then z7209.Dseq = getDataM(spr, getColumnIndex(spr, "Dseq"), xRow)
            If getColumnIndex(spr, "ProcessSeq") > -1 Then z7209.ProcessSeq = getDataM(spr, getColumnIndex(spr, "ProcessSeq"), xRow)
            If getColumnIndex(spr, "CustomerCode") > -1 Then z7209.CustomerCode = getDataM(spr, getColumnIndex(spr, "CustomerCode"), xRow)
            If getColumnIndex(spr, "selGroupComponent") > -1 Then z7209.selGroupComponent = getDataM(spr, getColumnIndex(spr, "selGroupComponent"), xRow)
            If getColumnIndex(spr, "cdGroupComponent") > -1 Then z7209.cdGroupComponent = getDataM(spr, getColumnIndex(spr, "cdGroupComponent"), xRow)
            If getColumnIndex(spr, "ComponentName") > -1 Then z7209.ComponentName = getDataM(spr, getColumnIndex(spr, "ComponentName"), xRow)
            If getColumnIndex(spr, "MaterialCode") > -1 Then z7209.MaterialCode = getDataM(spr, getColumnIndex(spr, "MaterialCode"), xRow)
            If getColumnIndex(spr, "seUnitMaterial") > -1 Then z7209.seUnitMaterial = getDataM(spr, getColumnIndex(spr, "seUnitMaterial"), xRow)
            If getColumnIndex(spr, "cdUnitMaterial") > -1 Then z7209.cdUnitMaterial = getDataM(spr, getColumnIndex(spr, "cdUnitMaterial"), xRow)
            If getColumnIndex(spr, "Specification") > -1 Then z7209.Specification = getDataM(spr, getColumnIndex(spr, "Specification"), xRow)
            If getColumnIndex(spr, "Width") > -1 Then z7209.Width = getDataM(spr, getColumnIndex(spr, "Width"), xRow)
            If getColumnIndex(spr, "WidthID") > -1 Then z7209.WidthID = getDataM(spr, getColumnIndex(spr, "WidthID"), xRow)
            If getColumnIndex(spr, "Height") > -1 Then z7209.Height = getDataM(spr, getColumnIndex(spr, "Height"), xRow)
            If getColumnIndex(spr, "SizeName") > -1 Then z7209.SizeName = getDataM(spr, getColumnIndex(spr, "SizeName"), xRow)
            If getColumnIndex(spr, "cdColorCode") > -1 Then z7209.cdColorCode = getDataM(spr, getColumnIndex(spr, "cdColorCode"), xRow)
            If getColumnIndex(spr, "ColorCode") > -1 Then z7209.ColorCode = getDataM(spr, getColumnIndex(spr, "ColorCode"), xRow)
            If getColumnIndex(spr, "ColorName") > -1 Then z7209.ColorName = getDataM(spr, getColumnIndex(spr, "ColorName"), xRow)
            If getColumnIndex(spr, "seShoesStatus") > -1 Then z7209.seShoesStatus = getDataM(spr, getColumnIndex(spr, "seShoesStatus"), xRow)
            If getColumnIndex(spr, "cdShoesStatus") > -1 Then z7209.cdShoesStatus = getDataM(spr, getColumnIndex(spr, "cdShoesStatus"), xRow)
            If getColumnIndex(spr, "seDepartment") > -1 Then z7209.seDepartment = getDataM(spr, getColumnIndex(spr, "seDepartment"), xRow)
            If getColumnIndex(spr, "cdDepartment") > -1 Then z7209.cdDepartment = getDataM(spr, getColumnIndex(spr, "cdDepartment"), xRow)
            If getColumnIndex(spr, "ContractID") > -1 Then z7209.ContractID = getDataM(spr, getColumnIndex(spr, "ContractID"), xRow)
            If getColumnIndex(spr, "ContracSeq") > -1 Then z7209.ContracSeq = getDataM(spr, getColumnIndex(spr, "ContracSeq"), xRow)
            If getColumnIndex(spr, "SupplierCode") > -1 Then z7209.SupplierCode = getDataM(spr, getColumnIndex(spr, "SupplierCode"), xRow)
            If getColumnIndex(spr, "PriceMaterial") > -1 Then z7209.PriceMaterial = getDataM(spr, getColumnIndex(spr, "PriceMaterial"), xRow)
            If getColumnIndex(spr, "ExchangeCost") > -1 Then z7209.ExchangeCost = getDataM(spr, getColumnIndex(spr, "ExchangeCost"), xRow)
            If getColumnIndex(spr, "ComplicationCost") > -1 Then z7209.ComplicationCost = getDataM(spr, getColumnIndex(spr, "ComplicationCost"), xRow)
            If getColumnIndex(spr, "AddedCost") > -1 Then z7209.AddedCost = getDataM(spr, getColumnIndex(spr, "AddedCost"), xRow)
            If getColumnIndex(spr, "ShippingRate") > -1 Then z7209.ShippingRate = getDataM(spr, getColumnIndex(spr, "ShippingRate"), xRow)
            If getColumnIndex(spr, "ShippingCost") > -1 Then z7209.ShippingCost = getDataM(spr, getColumnIndex(spr, "ShippingCost"), xRow)
            If getColumnIndex(spr, "PriceRnD") > -1 Then z7209.PriceRnD = getDataM(spr, getColumnIndex(spr, "PriceRnD"), xRow)
            If getColumnIndex(spr, "Price") > -1 Then z7209.Price = getDataM(spr, getColumnIndex(spr, "Price"), xRow)
            If getColumnIndex(spr, "seUnitPrice") > -1 Then z7209.seUnitPrice = getDataM(spr, getColumnIndex(spr, "seUnitPrice"), xRow)
            If getColumnIndex(spr, "cdUnitPrice") > -1 Then z7209.cdUnitPrice = getDataM(spr, getColumnIndex(spr, "cdUnitPrice"), xRow)
            If getColumnIndex(spr, "QtyComponent") > -1 Then z7209.QtyComponent = getDataM(spr, getColumnIndex(spr, "QtyComponent"), xRow)
            If getColumnIndex(spr, "Consumption") > -1 Then z7209.Consumption = getDataM(spr, getColumnIndex(spr, "Consumption"), xRow)
            If getColumnIndex(spr, "Loss") > -1 Then z7209.Loss = getDataM(spr, getColumnIndex(spr, "Loss"), xRow)
            If getColumnIndex(spr, "GrossUsage") > -1 Then z7209.GrossUsage = getDataM(spr, getColumnIndex(spr, "GrossUsage"), xRow)
            If getColumnIndex(spr, "MaterialAMT") > -1 Then z7209.MaterialAMT = getDataM(spr, getColumnIndex(spr, "MaterialAMT"), xRow)
            If getColumnIndex(spr, "MaterialAMTPurchasing") > -1 Then z7209.MaterialAMTPurchasing = getDataM(spr, getColumnIndex(spr, "MaterialAMTPurchasing"), xRow)
            If getColumnIndex(spr, "MaterialAMTSales") > -1 Then z7209.MaterialAMTSales = getDataM(spr, getColumnIndex(spr, "MaterialAMTSales"), xRow)
            If getColumnIndex(spr, "seSubProcess") > -1 Then z7209.seSubProcess = getDataM(spr, getColumnIndex(spr, "seSubProcess"), xRow)
            If getColumnIndex(spr, "cdSubProcess") > -1 Then z7209.cdSubProcess = getDataM(spr, getColumnIndex(spr, "cdSubProcess"), xRow)
            If getColumnIndex(spr, "seSpecialProcess") > -1 Then z7209.seSpecialProcess = getDataM(spr, getColumnIndex(spr, "seSpecialProcess"), xRow)
            If getColumnIndex(spr, "cdSpecialProcess") > -1 Then z7209.cdSpecialProcess = getDataM(spr, getColumnIndex(spr, "cdSpecialProcess"), xRow)
            If getColumnIndex(spr, "CheckMark") > -1 Then z7209.CheckMark = getDataM(spr, getColumnIndex(spr, "CheckMark"), xRow)
            If getColumnIndex(spr, "CheckUse") > -1 Then z7209.CheckUse = getDataM(spr, getColumnIndex(spr, "CheckUse"), xRow)
            If getColumnIndex(spr, "CheckP1") > -1 Then z7209.CheckP1 = getDataM(spr, getColumnIndex(spr, "CheckP1"), xRow)
            If getColumnIndex(spr, "CheckP2") > -1 Then z7209.CheckP2 = getDataM(spr, getColumnIndex(spr, "CheckP2"), xRow)
            If getColumnIndex(spr, "CheckP3") > -1 Then z7209.CheckP3 = getDataM(spr, getColumnIndex(spr, "CheckP3"), xRow)
            If getColumnIndex(spr, "CheckP4") > -1 Then z7209.CheckP4 = getDataM(spr, getColumnIndex(spr, "CheckP4"), xRow)
            If getColumnIndex(spr, "CheckP5") > -1 Then z7209.CheckP5 = getDataM(spr, getColumnIndex(spr, "CheckP5"), xRow)
            If getColumnIndex(spr, "CheckP6") > -1 Then z7209.CheckP6 = getDataM(spr, getColumnIndex(spr, "CheckP6"), xRow)
            If getColumnIndex(spr, "CheckP7") > -1 Then z7209.CheckP7 = getDataM(spr, getColumnIndex(spr, "CheckP7"), xRow)
            If getColumnIndex(spr, "CheckP8") > -1 Then z7209.CheckP8 = getDataM(spr, getColumnIndex(spr, "CheckP8"), xRow)
            If getColumnIndex(spr, "CheckP9") > -1 Then z7209.CheckP9 = getDataM(spr, getColumnIndex(spr, "CheckP9"), xRow)
            If getColumnIndex(spr, "CheckUse1") > -1 Then z7209.CheckUse1 = getDataM(spr, getColumnIndex(spr, "CheckUse1"), xRow)
            If getColumnIndex(spr, "CheckMatching") > -1 Then z7209.CheckMatching = getDataM(spr, getColumnIndex(spr, "CheckMatching"), xRow)
            If getColumnIndex(spr, "Remark") > -1 Then z7209.Remark = getDataM(spr, getColumnIndex(spr, "Remark"), xRow)
            If getColumnIndex(spr, "MaterialCode_K3011") > -1 Then z7209.MaterialCode_K3011 = getDataM(spr, getColumnIndex(spr, "MaterialCode_K3011"), xRow)
            If getColumnIndex(spr, "seSite") > -1 Then z7209.seSite = getDataM(spr, getColumnIndex(spr, "seSite"), xRow)
            If getColumnIndex(spr, "cdSite") > -1 Then z7209.cdSite = getDataM(spr, getColumnIndex(spr, "cdSite"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7209_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K7209_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z7209 As T7209_AREA, Job As String, GROUPCOMPONENTBOM As String, GROUPCOMPONENTSEQ As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K7209_MOVE = False

        Try
            If READ_PFK7209(GROUPCOMPONENTBOM, GROUPCOMPONENTSEQ) = True Then
                z7209 = D7209
                K7209_MOVE = True
            Else
                z7209 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7209")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "GROUPCOMPONENTBOM" : z7209.GroupComponentBOM = Children(i).Code
                                Case "GROUPCOMPONENTSEQ" : z7209.GroupComponentSeq = Children(i).Code
                                Case "DSEQ" : z7209.Dseq = Children(i).Code
                                Case "PROCESSSEQ" : z7209.ProcessSeq = Children(i).Code
                                Case "CUSTOMERCODE" : z7209.CustomerCode = Children(i).Code
                                Case "SELGROUPCOMPONENT" : z7209.selGroupComponent = Children(i).Code
                                Case "CDGROUPCOMPONENT" : z7209.cdGroupComponent = Children(i).Code
                                Case "COMPONENTNAME" : z7209.ComponentName = Children(i).Code
                                Case "MATERIALCODE" : z7209.MaterialCode = Children(i).Code
                                Case "SEUNITMATERIAL" : z7209.seUnitMaterial = Children(i).Code
                                Case "CDUNITMATERIAL" : z7209.cdUnitMaterial = Children(i).Code
                                Case "SPECIFICATION" : z7209.Specification = Children(i).Code
                                Case "WIDTH" : z7209.Width = Children(i).Code
                                Case "WIDTHID" : z7209.WidthID = Children(i).Code
                                Case "HEIGHT" : z7209.Height = Children(i).Code
                                Case "SIZENAME" : z7209.SizeName = Children(i).Code
                                Case "CDCOLORCODE" : z7209.cdColorCode = Children(i).Code
                                Case "COLORCODE" : z7209.ColorCode = Children(i).Code
                                Case "COLORNAME" : z7209.ColorName = Children(i).Code
                                Case "SESHOESSTATUS" : z7209.seShoesStatus = Children(i).Code
                                Case "CDSHOESSTATUS" : z7209.cdShoesStatus = Children(i).Code
                                Case "SEDEPARTMENT" : z7209.seDepartment = Children(i).Code
                                Case "CDDEPARTMENT" : z7209.cdDepartment = Children(i).Code
                                Case "CONTRACTID" : z7209.ContractID = Children(i).Code
                                Case "ContracSeq" : z7209.ContracSeq = Children(i).Code
                                Case "SUPPLIERCODE" : z7209.SupplierCode = Children(i).Code
                                Case "PRICEMATERIAL" : z7209.PriceMaterial = Children(i).Code
                                Case "EXCHANGECOST" : z7209.ExchangeCost = Children(i).Code
                                Case "COMPLICATIONCOST" : z7209.ComplicationCost = Children(i).Code
                                Case "ADDEDCOST" : z7209.AddedCost = Children(i).Code
                                Case "SHIPPINGRATE" : z7209.ShippingRate = Children(i).Code
                                Case "SHIPPINGCOST" : z7209.ShippingCost = Children(i).Code
                                Case "PRICERND" : z7209.PriceRnD = Children(i).Code
                                Case "PRICE" : z7209.Price = Children(i).Code
                                Case "SEUNITPRICE" : z7209.seUnitPrice = Children(i).Code
                                Case "CDUNITPRICE" : z7209.cdUnitPrice = Children(i).Code
                                Case "QTYCOMPONENT" : z7209.QtyComponent = Children(i).Code
                                Case "CONSUMPTION" : z7209.Consumption = Children(i).Code
                                Case "LOSS" : z7209.Loss = Children(i).Code
                                Case "GROSSUSAGE" : z7209.GrossUsage = Children(i).Code
                                Case "MATERIALAMT" : z7209.MaterialAMT = Children(i).Code
                                Case "MATERIALAMTPURCHASING" : z7209.MaterialAMTPurchasing = Children(i).Code
                                Case "MATERIALAMTSALES" : z7209.MaterialAMTSales = Children(i).Code
                                Case "SESUBPROCESS" : z7209.seSubProcess = Children(i).Code
                                Case "CDSUBPROCESS" : z7209.cdSubProcess = Children(i).Code
                                Case "SESPECIALPROCESS" : z7209.seSpecialProcess = Children(i).Code
                                Case "CDSPECIALPROCESS" : z7209.cdSpecialProcess = Children(i).Code
                                Case "CHECKMARK" : z7209.CheckMark = Children(i).Code
                                Case "CHECKUSE" : z7209.CheckUse = Children(i).Code
                                Case "CHECKP1" : z7209.CheckP1 = Children(i).Code
                                Case "CHECKP2" : z7209.CheckP2 = Children(i).Code
                                Case "CHECKP3" : z7209.CheckP3 = Children(i).Code
                                Case "CHECKP4" : z7209.CheckP4 = Children(i).Code
                                Case "CHECKP5" : z7209.CheckP5 = Children(i).Code
                                Case "CHECKP6" : z7209.CheckP6 = Children(i).Code
                                Case "CHECKP7" : z7209.CheckP7 = Children(i).Code
                                Case "CHECKP8" : z7209.CheckP8 = Children(i).Code
                                Case "CHECKP9" : z7209.CheckP9 = Children(i).Code
                                Case "CHECKUSE1" : z7209.CheckUse1 = Children(i).Code
                                Case "CHECKMATCHING" : z7209.CheckMatching = Children(i).Code
                                Case "REMARK" : z7209.Remark = Children(i).Code
                                Case "MATERIALCODE_K3011" : z7209.MaterialCode_K3011 = Children(i).Code
                                Case "SESITE" : z7209.seSite = Children(i).Code
                                Case "CDSITE" : z7209.cdSite = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "GROUPCOMPONENTBOM" : z7209.GroupComponentBOM = Children(i).Data
                                Case "GROUPCOMPONENTSEQ" : z7209.GroupComponentSeq = Children(i).Data
                                Case "DSEQ" : z7209.Dseq = Children(i).Data
                                Case "PROCESSSEQ" : z7209.ProcessSeq = Children(i).Data
                                Case "CUSTOMERCODE" : z7209.CustomerCode = Children(i).Data
                                Case "SELGROUPCOMPONENT" : z7209.selGroupComponent = Children(i).Data
                                Case "CDGROUPCOMPONENT" : z7209.cdGroupComponent = Children(i).Data
                                Case "COMPONENTNAME" : z7209.ComponentName = Children(i).Data
                                Case "MATERIALCODE" : z7209.MaterialCode = Children(i).Data
                                Case "SEUNITMATERIAL" : z7209.seUnitMaterial = Children(i).Data
                                Case "CDUNITMATERIAL" : z7209.cdUnitMaterial = Children(i).Data
                                Case "SPECIFICATION" : z7209.Specification = Children(i).Data
                                Case "WIDTH" : z7209.Width = Children(i).Data
                                Case "WIDTHID" : z7209.WidthID = Children(i).Data
                                Case "HEIGHT" : z7209.Height = Children(i).Data
                                Case "SIZENAME" : z7209.SizeName = Children(i).Data
                                Case "CDCOLORCODE" : z7209.cdColorCode = Children(i).Data
                                Case "COLORCODE" : z7209.ColorCode = Children(i).Data
                                Case "COLORNAME" : z7209.ColorName = Children(i).Data
                                Case "SESHOESSTATUS" : z7209.seShoesStatus = Children(i).Data
                                Case "CDSHOESSTATUS" : z7209.cdShoesStatus = Children(i).Data
                                Case "SEDEPARTMENT" : z7209.seDepartment = Children(i).Data
                                Case "CDDEPARTMENT" : z7209.cdDepartment = Children(i).Data
                                Case "CONTRACTID" : z7209.ContractID = Children(i).Data
                                Case "ContracSeq" : z7209.ContracSeq = Children(i).Data
                                Case "SUPPLIERCODE" : z7209.SupplierCode = Children(i).Data
                                Case "PRICEMATERIAL" : z7209.PriceMaterial = Children(i).Data
                                Case "EXCHANGECOST" : z7209.ExchangeCost = Children(i).Data
                                Case "COMPLICATIONCOST" : z7209.ComplicationCost = Children(i).Data
                                Case "ADDEDCOST" : z7209.AddedCost = Children(i).Data
                                Case "SHIPPINGRATE" : z7209.ShippingRate = Children(i).Data
                                Case "SHIPPINGCOST" : z7209.ShippingCost = Children(i).Data
                                Case "PRICERND" : z7209.PriceRnD = Children(i).Data
                                Case "PRICE" : z7209.Price = Children(i).Data
                                Case "SEUNITPRICE" : z7209.seUnitPrice = Children(i).Data
                                Case "CDUNITPRICE" : z7209.cdUnitPrice = Children(i).Data
                                Case "QTYCOMPONENT" : z7209.QtyComponent = Children(i).Data
                                Case "CONSUMPTION" : z7209.Consumption = Children(i).Data
                                Case "LOSS" : z7209.Loss = Children(i).Data
                                Case "GROSSUSAGE" : z7209.GrossUsage = Children(i).Data
                                Case "MATERIALAMT" : z7209.MaterialAMT = Children(i).Data
                                Case "MATERIALAMTPURCHASING" : z7209.MaterialAMTPurchasing = Children(i).Data
                                Case "MATERIALAMTSALES" : z7209.MaterialAMTSales = Children(i).Data
                                Case "SESUBPROCESS" : z7209.seSubProcess = Children(i).Data
                                Case "CDSUBPROCESS" : z7209.cdSubProcess = Children(i).Data
                                Case "SESPECIALPROCESS" : z7209.seSpecialProcess = Children(i).Data
                                Case "CDSPECIALPROCESS" : z7209.cdSpecialProcess = Children(i).Data
                                Case "CHECKMARK" : z7209.CheckMark = Children(i).Data
                                Case "CHECKUSE" : z7209.CheckUse = Children(i).Data
                                Case "CHECKP1" : z7209.CheckP1 = Children(i).Data
                                Case "CHECKP2" : z7209.CheckP2 = Children(i).Data
                                Case "CHECKP3" : z7209.CheckP3 = Children(i).Data
                                Case "CHECKP4" : z7209.CheckP4 = Children(i).Data
                                Case "CHECKP5" : z7209.CheckP5 = Children(i).Data
                                Case "CHECKP6" : z7209.CheckP6 = Children(i).Data
                                Case "CHECKP7" : z7209.CheckP7 = Children(i).Data
                                Case "CHECKP8" : z7209.CheckP8 = Children(i).Data
                                Case "CHECKP9" : z7209.CheckP9 = Children(i).Data
                                Case "CHECKUSE1" : z7209.CheckUse1 = Children(i).Data
                                Case "CHECKMATCHING" : z7209.CheckMatching = Children(i).Data
                                Case "REMARK" : z7209.Remark = Children(i).Data
                                Case "MATERIALCODE_K3011" : z7209.MaterialCode_K3011 = Children(i).Data
                                Case "SESITE" : z7209.seSite = Children(i).Data
                                Case "CDSITE" : z7209.cdSite = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7209_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K7209_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z7209 As T7209_AREA, Job As String, CheckClear As Boolean, GROUPCOMPONENTBOM As String, GROUPCOMPONENTSEQ As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K7209_MOVE = False

        Try
            If READ_PFK7209(GROUPCOMPONENTBOM, GROUPCOMPONENTSEQ) = True Then
                z7209 = D7209
                K7209_MOVE = True
            Else
                If CheckClear = True Then z7209 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7209")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "GROUPCOMPONENTBOM" : z7209.GroupComponentBOM = Children(i).Code
                                Case "GROUPCOMPONENTSEQ" : z7209.GroupComponentSeq = Children(i).Code
                                Case "DSEQ" : z7209.Dseq = Children(i).Code
                                Case "PROCESSSEQ" : z7209.ProcessSeq = Children(i).Code
                                Case "CUSTOMERCODE" : z7209.CustomerCode = Children(i).Code
                                Case "SELGROUPCOMPONENT" : z7209.selGroupComponent = Children(i).Code
                                Case "CDGROUPCOMPONENT" : z7209.cdGroupComponent = Children(i).Code
                                Case "COMPONENTNAME" : z7209.ComponentName = Children(i).Code
                                Case "MATERIALCODE" : z7209.MaterialCode = Children(i).Code
                                Case "SEUNITMATERIAL" : z7209.seUnitMaterial = Children(i).Code
                                Case "CDUNITMATERIAL" : z7209.cdUnitMaterial = Children(i).Code
                                Case "SPECIFICATION" : z7209.Specification = Children(i).Code
                                Case "WIDTH" : z7209.Width = Children(i).Code
                                Case "WIDTHID" : z7209.WidthID = Children(i).Code
                                Case "HEIGHT" : z7209.Height = Children(i).Code
                                Case "SIZENAME" : z7209.SizeName = Children(i).Code
                                Case "CDCOLORCODE" : z7209.cdColorCode = Children(i).Code
                                Case "COLORCODE" : z7209.ColorCode = Children(i).Code
                                Case "COLORNAME" : z7209.ColorName = Children(i).Code
                                Case "SESHOESSTATUS" : z7209.seShoesStatus = Children(i).Code
                                Case "CDSHOESSTATUS" : z7209.cdShoesStatus = Children(i).Code
                                Case "SEDEPARTMENT" : z7209.seDepartment = Children(i).Code
                                Case "CDDEPARTMENT" : z7209.cdDepartment = Children(i).Code
                                Case "CONTRACTID" : z7209.ContractID = Children(i).Code
                                Case "ContracSeq" : z7209.ContracSeq = Children(i).Code
                                Case "SUPPLIERCODE" : z7209.SupplierCode = Children(i).Code
                                Case "PRICEMATERIAL" : z7209.PriceMaterial = Children(i).Code
                                Case "EXCHANGECOST" : z7209.ExchangeCost = Children(i).Code
                                Case "COMPLICATIONCOST" : z7209.ComplicationCost = Children(i).Code
                                Case "ADDEDCOST" : z7209.AddedCost = Children(i).Code
                                Case "SHIPPINGRATE" : z7209.ShippingRate = Children(i).Code
                                Case "SHIPPINGCOST" : z7209.ShippingCost = Children(i).Code
                                Case "PRICERND" : z7209.PriceRnD = Children(i).Code
                                Case "PRICE" : z7209.Price = Children(i).Code
                                Case "SEUNITPRICE" : z7209.seUnitPrice = Children(i).Code
                                Case "CDUNITPRICE" : z7209.cdUnitPrice = Children(i).Code
                                Case "QTYCOMPONENT" : z7209.QtyComponent = Children(i).Code
                                Case "CONSUMPTION" : z7209.Consumption = Children(i).Code
                                Case "LOSS" : z7209.Loss = Children(i).Code
                                Case "GROSSUSAGE" : z7209.GrossUsage = Children(i).Code
                                Case "MATERIALAMT" : z7209.MaterialAMT = Children(i).Code
                                Case "MATERIALAMTPURCHASING" : z7209.MaterialAMTPurchasing = Children(i).Code
                                Case "MATERIALAMTSALES" : z7209.MaterialAMTSales = Children(i).Code
                                Case "SESUBPROCESS" : z7209.seSubProcess = Children(i).Code
                                Case "CDSUBPROCESS" : z7209.cdSubProcess = Children(i).Code
                                Case "SESPECIALPROCESS" : z7209.seSpecialProcess = Children(i).Code
                                Case "CDSPECIALPROCESS" : z7209.cdSpecialProcess = Children(i).Code
                                Case "CHECKMARK" : z7209.CheckMark = Children(i).Code
                                Case "CHECKUSE" : z7209.CheckUse = Children(i).Code
                                Case "CHECKP1" : z7209.CheckP1 = Children(i).Code
                                Case "CHECKP2" : z7209.CheckP2 = Children(i).Code
                                Case "CHECKP3" : z7209.CheckP3 = Children(i).Code
                                Case "CHECKP4" : z7209.CheckP4 = Children(i).Code
                                Case "CHECKP5" : z7209.CheckP5 = Children(i).Code
                                Case "CHECKP6" : z7209.CheckP6 = Children(i).Code
                                Case "CHECKP7" : z7209.CheckP7 = Children(i).Code
                                Case "CHECKP8" : z7209.CheckP8 = Children(i).Code
                                Case "CHECKP9" : z7209.CheckP9 = Children(i).Code
                                Case "CHECKUSE1" : z7209.CheckUse1 = Children(i).Code
                                Case "CHECKMATCHING" : z7209.CheckMatching = Children(i).Code
                                Case "REMARK" : z7209.Remark = Children(i).Code
                                Case "MATERIALCODE_K3011" : z7209.MaterialCode_K3011 = Children(i).Code
                                Case "SESITE" : z7209.seSite = Children(i).Code
                                Case "CDSITE" : z7209.cdSite = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "GROUPCOMPONENTBOM" : z7209.GroupComponentBOM = Children(i).Data
                                Case "GROUPCOMPONENTSEQ" : z7209.GroupComponentSeq = Children(i).Data
                                Case "DSEQ" : z7209.Dseq = Children(i).Data
                                Case "PROCESSSEQ" : z7209.ProcessSeq = Children(i).Data
                                Case "CUSTOMERCODE" : z7209.CustomerCode = Children(i).Data
                                Case "SELGROUPCOMPONENT" : z7209.selGroupComponent = Children(i).Data
                                Case "CDGROUPCOMPONENT" : z7209.cdGroupComponent = Children(i).Data
                                Case "COMPONENTNAME" : z7209.ComponentName = Children(i).Data
                                Case "MATERIALCODE" : z7209.MaterialCode = Children(i).Data
                                Case "SEUNITMATERIAL" : z7209.seUnitMaterial = Children(i).Data
                                Case "CDUNITMATERIAL" : z7209.cdUnitMaterial = Children(i).Data
                                Case "SPECIFICATION" : z7209.Specification = Children(i).Data
                                Case "WIDTH" : z7209.Width = Children(i).Data
                                Case "WIDTHID" : z7209.WidthID = Children(i).Data
                                Case "HEIGHT" : z7209.Height = Children(i).Data
                                Case "SIZENAME" : z7209.SizeName = Children(i).Data
                                Case "CDCOLORCODE" : z7209.cdColorCode = Children(i).Data
                                Case "COLORCODE" : z7209.ColorCode = Children(i).Data
                                Case "COLORNAME" : z7209.ColorName = Children(i).Data
                                Case "SESHOESSTATUS" : z7209.seShoesStatus = Children(i).Data
                                Case "CDSHOESSTATUS" : z7209.cdShoesStatus = Children(i).Data
                                Case "SEDEPARTMENT" : z7209.seDepartment = Children(i).Data
                                Case "CDDEPARTMENT" : z7209.cdDepartment = Children(i).Data
                                Case "CONTRACTID" : z7209.ContractID = Children(i).Data
                                Case "ContracSeq" : z7209.ContracSeq = Children(i).Data
                                Case "SUPPLIERCODE" : z7209.SupplierCode = Children(i).Data
                                Case "PRICEMATERIAL" : z7209.PriceMaterial = Children(i).Data
                                Case "EXCHANGECOST" : z7209.ExchangeCost = Children(i).Data
                                Case "COMPLICATIONCOST" : z7209.ComplicationCost = Children(i).Data
                                Case "ADDEDCOST" : z7209.AddedCost = Children(i).Data
                                Case "SHIPPINGRATE" : z7209.ShippingRate = Children(i).Data
                                Case "SHIPPINGCOST" : z7209.ShippingCost = Children(i).Data
                                Case "PRICERND" : z7209.PriceRnD = Children(i).Data
                                Case "PRICE" : z7209.Price = Children(i).Data
                                Case "SEUNITPRICE" : z7209.seUnitPrice = Children(i).Data
                                Case "CDUNITPRICE" : z7209.cdUnitPrice = Children(i).Data
                                Case "QTYCOMPONENT" : z7209.QtyComponent = Children(i).Data
                                Case "CONSUMPTION" : z7209.Consumption = Children(i).Data
                                Case "LOSS" : z7209.Loss = Children(i).Data
                                Case "GROSSUSAGE" : z7209.GrossUsage = Children(i).Data
                                Case "MATERIALAMT" : z7209.MaterialAMT = Children(i).Data
                                Case "MATERIALAMTPURCHASING" : z7209.MaterialAMTPurchasing = Children(i).Data
                                Case "MATERIALAMTSALES" : z7209.MaterialAMTSales = Children(i).Data
                                Case "SESUBPROCESS" : z7209.seSubProcess = Children(i).Data
                                Case "CDSUBPROCESS" : z7209.cdSubProcess = Children(i).Data
                                Case "SESPECIALPROCESS" : z7209.seSpecialProcess = Children(i).Data
                                Case "CDSPECIALPROCESS" : z7209.cdSpecialProcess = Children(i).Data
                                Case "CHECKMARK" : z7209.CheckMark = Children(i).Data
                                Case "CHECKUSE" : z7209.CheckUse = Children(i).Data
                                Case "CHECKP1" : z7209.CheckP1 = Children(i).Data
                                Case "CHECKP2" : z7209.CheckP2 = Children(i).Data
                                Case "CHECKP3" : z7209.CheckP3 = Children(i).Data
                                Case "CHECKP4" : z7209.CheckP4 = Children(i).Data
                                Case "CHECKP5" : z7209.CheckP5 = Children(i).Data
                                Case "CHECKP6" : z7209.CheckP6 = Children(i).Data
                                Case "CHECKP7" : z7209.CheckP7 = Children(i).Data
                                Case "CHECKP8" : z7209.CheckP8 = Children(i).Data
                                Case "CHECKP9" : z7209.CheckP9 = Children(i).Data
                                Case "CHECKUSE1" : z7209.CheckUse1 = Children(i).Data
                                Case "CHECKMATCHING" : z7209.CheckMatching = Children(i).Data
                                Case "REMARK" : z7209.Remark = Children(i).Data
                                Case "MATERIALCODE_K3011" : z7209.MaterialCode_K3011 = Children(i).Data
                                Case "SESITE" : z7209.seSite = Children(i).Data
                                Case "CDSITE" : z7209.cdSite = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7209_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW AREA
    '=========================================================================================================================================================
    Public Sub K7209_MOVE(ByRef a7209 As T7209_AREA, ByRef b7209 As T7209_AREA)
        Try
            If trim$(a7209.GroupComponentBOM) = "" Then b7209.GroupComponentBOM = "" Else b7209.GroupComponentBOM = a7209.GroupComponentBOM
            If trim$(a7209.GroupComponentSeq) = "" Then b7209.GroupComponentSeq = "" Else b7209.GroupComponentSeq = a7209.GroupComponentSeq
            If trim$(a7209.Dseq) = "" Then b7209.Dseq = "" Else b7209.Dseq = a7209.Dseq
            If trim$(a7209.ProcessSeq) = "" Then b7209.ProcessSeq = "" Else b7209.ProcessSeq = a7209.ProcessSeq
            If trim$(a7209.CustomerCode) = "" Then b7209.CustomerCode = "" Else b7209.CustomerCode = a7209.CustomerCode
            If trim$(a7209.selGroupComponent) = "" Then b7209.selGroupComponent = "" Else b7209.selGroupComponent = a7209.selGroupComponent
            If trim$(a7209.cdGroupComponent) = "" Then b7209.cdGroupComponent = "" Else b7209.cdGroupComponent = a7209.cdGroupComponent
            If trim$(a7209.ComponentName) = "" Then b7209.ComponentName = "" Else b7209.ComponentName = a7209.ComponentName
            If trim$(a7209.MaterialCode) = "" Then b7209.MaterialCode = "" Else b7209.MaterialCode = a7209.MaterialCode
            If trim$(a7209.seUnitMaterial) = "" Then b7209.seUnitMaterial = "" Else b7209.seUnitMaterial = a7209.seUnitMaterial
            If trim$(a7209.cdUnitMaterial) = "" Then b7209.cdUnitMaterial = "" Else b7209.cdUnitMaterial = a7209.cdUnitMaterial
            If trim$(a7209.Specification) = "" Then b7209.Specification = "" Else b7209.Specification = a7209.Specification
            If trim$(a7209.Width) = "" Then b7209.Width = "" Else b7209.Width = a7209.Width
            If trim$(a7209.WidthID) = "" Then b7209.WidthID = "" Else b7209.WidthID = a7209.WidthID
            If trim$(a7209.Height) = "" Then b7209.Height = "" Else b7209.Height = a7209.Height
            If trim$(a7209.SizeName) = "" Then b7209.SizeName = "" Else b7209.SizeName = a7209.SizeName
            If trim$(a7209.cdColorCode) = "" Then b7209.cdColorCode = "" Else b7209.cdColorCode = a7209.cdColorCode
            If trim$(a7209.ColorCode) = "" Then b7209.ColorCode = "" Else b7209.ColorCode = a7209.ColorCode
            If trim$(a7209.ColorName) = "" Then b7209.ColorName = "" Else b7209.ColorName = a7209.ColorName
            If trim$(a7209.seShoesStatus) = "" Then b7209.seShoesStatus = "" Else b7209.seShoesStatus = a7209.seShoesStatus
            If trim$(a7209.cdShoesStatus) = "" Then b7209.cdShoesStatus = "" Else b7209.cdShoesStatus = a7209.cdShoesStatus
            If trim$(a7209.seDepartment) = "" Then b7209.seDepartment = "" Else b7209.seDepartment = a7209.seDepartment
            If trim$(a7209.cdDepartment) = "" Then b7209.cdDepartment = "" Else b7209.cdDepartment = a7209.cdDepartment
            If trim$(a7209.ContractID) = "" Then b7209.ContractID = "" Else b7209.ContractID = a7209.ContractID
            If trim$(a7209.ContracSeq) = "" Then b7209.ContracSeq = "" Else b7209.ContracSeq = a7209.ContracSeq
            If trim$(a7209.SupplierCode) = "" Then b7209.SupplierCode = "" Else b7209.SupplierCode = a7209.SupplierCode
            If trim$(a7209.PriceMaterial) = "" Then b7209.PriceMaterial = "" Else b7209.PriceMaterial = a7209.PriceMaterial
            If trim$(a7209.ExchangeCost) = "" Then b7209.ExchangeCost = "" Else b7209.ExchangeCost = a7209.ExchangeCost
            If trim$(a7209.ComplicationCost) = "" Then b7209.ComplicationCost = "" Else b7209.ComplicationCost = a7209.ComplicationCost
            If trim$(a7209.AddedCost) = "" Then b7209.AddedCost = "" Else b7209.AddedCost = a7209.AddedCost
            If trim$(a7209.ShippingRate) = "" Then b7209.ShippingRate = "" Else b7209.ShippingRate = a7209.ShippingRate
            If trim$(a7209.ShippingCost) = "" Then b7209.ShippingCost = "" Else b7209.ShippingCost = a7209.ShippingCost
            If trim$(a7209.PriceRnD) = "" Then b7209.PriceRnD = "" Else b7209.PriceRnD = a7209.PriceRnD
            If trim$(a7209.Price) = "" Then b7209.Price = "" Else b7209.Price = a7209.Price
            If trim$(a7209.seUnitPrice) = "" Then b7209.seUnitPrice = "" Else b7209.seUnitPrice = a7209.seUnitPrice
            If trim$(a7209.cdUnitPrice) = "" Then b7209.cdUnitPrice = "" Else b7209.cdUnitPrice = a7209.cdUnitPrice
            If trim$(a7209.QtyComponent) = "" Then b7209.QtyComponent = "" Else b7209.QtyComponent = a7209.QtyComponent
            If trim$(a7209.Consumption) = "" Then b7209.Consumption = "" Else b7209.Consumption = a7209.Consumption
            If trim$(a7209.Loss) = "" Then b7209.Loss = "" Else b7209.Loss = a7209.Loss
            If trim$(a7209.GrossUsage) = "" Then b7209.GrossUsage = "" Else b7209.GrossUsage = a7209.GrossUsage
            If trim$(a7209.MaterialAMT) = "" Then b7209.MaterialAMT = "" Else b7209.MaterialAMT = a7209.MaterialAMT
            If trim$(a7209.MaterialAMTPurchasing) = "" Then b7209.MaterialAMTPurchasing = "" Else b7209.MaterialAMTPurchasing = a7209.MaterialAMTPurchasing
            If trim$(a7209.MaterialAMTSales) = "" Then b7209.MaterialAMTSales = "" Else b7209.MaterialAMTSales = a7209.MaterialAMTSales
            If trim$(a7209.seSubProcess) = "" Then b7209.seSubProcess = "" Else b7209.seSubProcess = a7209.seSubProcess
            If trim$(a7209.cdSubProcess) = "" Then b7209.cdSubProcess = "" Else b7209.cdSubProcess = a7209.cdSubProcess
            If trim$(a7209.seSpecialProcess) = "" Then b7209.seSpecialProcess = "" Else b7209.seSpecialProcess = a7209.seSpecialProcess
            If trim$(a7209.cdSpecialProcess) = "" Then b7209.cdSpecialProcess = "" Else b7209.cdSpecialProcess = a7209.cdSpecialProcess
            If trim$(a7209.CheckMark) = "" Then b7209.CheckMark = "" Else b7209.CheckMark = a7209.CheckMark
            If trim$(a7209.CheckUse) = "" Then b7209.CheckUse = "" Else b7209.CheckUse = a7209.CheckUse
            If trim$(a7209.CheckP1) = "" Then b7209.CheckP1 = "" Else b7209.CheckP1 = a7209.CheckP1
            If trim$(a7209.CheckP2) = "" Then b7209.CheckP2 = "" Else b7209.CheckP2 = a7209.CheckP2
            If trim$(a7209.CheckP3) = "" Then b7209.CheckP3 = "" Else b7209.CheckP3 = a7209.CheckP3
            If trim$(a7209.CheckP4) = "" Then b7209.CheckP4 = "" Else b7209.CheckP4 = a7209.CheckP4
            If trim$(a7209.CheckP5) = "" Then b7209.CheckP5 = "" Else b7209.CheckP5 = a7209.CheckP5
            If trim$(a7209.CheckP6) = "" Then b7209.CheckP6 = "" Else b7209.CheckP6 = a7209.CheckP6
            If trim$(a7209.CheckP7) = "" Then b7209.CheckP7 = "" Else b7209.CheckP7 = a7209.CheckP7
            If trim$(a7209.CheckP8) = "" Then b7209.CheckP8 = "" Else b7209.CheckP8 = a7209.CheckP8
            If trim$(a7209.CheckP9) = "" Then b7209.CheckP9 = "" Else b7209.CheckP9 = a7209.CheckP9
            If trim$(a7209.CheckUse1) = "" Then b7209.CheckUse1 = "" Else b7209.CheckUse1 = a7209.CheckUse1
            If trim$(a7209.CheckMatching) = "" Then b7209.CheckMatching = "" Else b7209.CheckMatching = a7209.CheckMatching
            If trim$(a7209.Remark) = "" Then b7209.Remark = "" Else b7209.Remark = a7209.Remark
            If trim$(a7209.MaterialCode_K3011) = "" Then b7209.MaterialCode_K3011 = "" Else b7209.MaterialCode_K3011 = a7209.MaterialCode_K3011
            If Trim$(a7209.seSite) = "" Then b7209.seSite = "" Else b7209.seSite = a7209.seSite
            If trim$(a7209.cdSite) = "" Then b7209.cdSite = "" Else b7209.cdSite = a7209.cdSite
        Catch ex As Exception
            Call MsgBoxP("K7209_MOVE", vbCritical)
        End Try
    End Sub


End Module
