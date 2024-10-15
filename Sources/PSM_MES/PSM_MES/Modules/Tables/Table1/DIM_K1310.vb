'=========================================================================================================================================================
'   TABLE : (PFK1310)
'
'      WORKER : PSM GLOBAL ., LTD
'       WORK DATE : 2019 NEW
'       DEVELOPER    : MRNLV
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K1310

    Structure T1310_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public AutoKey As Double  '			decimal		*
        Public OrderNo As String  '			char(9)
        Public OrderNoSeq As String  '			char(3)
        Public GroupComponentBOM As String  '			char(6)
        Public GroupComponentSeq As Double  '			decimal
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
        Public DateInsert As String  '			char(8)
        Public DateUpdate As String  '			char(8)
        Public InchargeInsert As String  '			char(8)
        Public InchargeUpdate As String  '			char(8)
        Public TimeInsert As String  '			char(14)
        Public TimeUpdate As String  '			char(14)
        '=========================================================================================================================================================
    End Structure

    Public D1310 As T1310_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK1310(AUTOKEY As Double) As Boolean
        READ_PFK1310 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK1310 "
            SQL = SQL & " WHERE K1310_AutoKey		 =  " & AutoKey & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D1310_CLEAR() : GoTo SKIP_READ_PFK1310

            Call K1310_MOVE(rd)
            READ_PFK1310 = True

SKIP_READ_PFK1310:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK1310", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK1310(AUTOKEY As Double, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK1310 "
            SQL = SQL & " WHERE K1310_AutoKey		 =  " & AutoKey & "  "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK1310", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK1310(z1310 As T1310_AREA) As Boolean
        WRITE_PFK1310 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z1310)

            SQL = " INSERT INTO PFK1310 "
            SQL = SQL & " ( "
            SQL = SQL & " K1310_OrderNo,"
            SQL = SQL & " K1310_OrderNoSeq,"
            SQL = SQL & " K1310_GroupComponentBOM,"
            SQL = SQL & " K1310_GroupComponentSeq,"
            SQL = SQL & " K1310_Dseq,"
            SQL = SQL & " K1310_ProcessSeq,"
            SQL = SQL & " K1310_CustomerCode,"
            SQL = SQL & " K1310_selGroupComponent,"
            SQL = SQL & " K1310_cdGroupComponent,"
            SQL = SQL & " K1310_ComponentName,"
            SQL = SQL & " K1310_MaterialCode,"
            SQL = SQL & " K1310_seUnitMaterial,"
            SQL = SQL & " K1310_cdUnitMaterial,"
            SQL = SQL & " K1310_Specification,"
            SQL = SQL & " K1310_Width,"
            SQL = SQL & " K1310_WidthID,"
            SQL = SQL & " K1310_Height,"
            SQL = SQL & " K1310_SizeName,"
            SQL = SQL & " K1310_cdColorCode,"
            SQL = SQL & " K1310_ColorCode,"
            SQL = SQL & " K1310_ColorName,"
            SQL = SQL & " K1310_seShoesStatus,"
            SQL = SQL & " K1310_cdShoesStatus,"
            SQL = SQL & " K1310_seDepartment,"
            SQL = SQL & " K1310_cdDepartment,"
            SQL = SQL & " K1310_ContractID,"
            SQL = SQL & " K1310_ContracSeq,"
            SQL = SQL & " K1310_SupplierCode,"
            SQL = SQL & " K1310_PriceMaterial,"
            SQL = SQL & " K1310_ExchangeCost,"
            SQL = SQL & " K1310_ComplicationCost,"
            SQL = SQL & " K1310_AddedCost,"
            SQL = SQL & " K1310_ShippingRate,"
            SQL = SQL & " K1310_ShippingCost,"
            SQL = SQL & " K1310_PriceRnD,"
            SQL = SQL & " K1310_Price,"
            SQL = SQL & " K1310_seUnitPrice,"
            SQL = SQL & " K1310_cdUnitPrice,"
            SQL = SQL & " K1310_QtyComponent,"
            SQL = SQL & " K1310_Consumption,"
            SQL = SQL & " K1310_Loss,"
            SQL = SQL & " K1310_GrossUsage,"
            SQL = SQL & " K1310_MaterialAMT,"
            SQL = SQL & " K1310_MaterialAMTPurchasing,"
            SQL = SQL & " K1310_MaterialAMTSales,"
            SQL = SQL & " K1310_seSubProcess,"
            SQL = SQL & " K1310_cdSubProcess,"
            SQL = SQL & " K1310_seSpecialProcess,"
            SQL = SQL & " K1310_cdSpecialProcess,"
            SQL = SQL & " K1310_CheckMark,"
            SQL = SQL & " K1310_CheckUse,"
            SQL = SQL & " K1310_CheckP1,"
            SQL = SQL & " K1310_CheckP2,"
            SQL = SQL & " K1310_CheckP3,"
            SQL = SQL & " K1310_CheckP4,"
            SQL = SQL & " K1310_CheckP5,"
            SQL = SQL & " K1310_CheckP6,"
            SQL = SQL & " K1310_CheckP7,"
            SQL = SQL & " K1310_CheckP8,"
            SQL = SQL & " K1310_CheckP9,"
            SQL = SQL & " K1310_CheckUse1,"
            SQL = SQL & " K1310_CheckMatching,"
            SQL = SQL & " K1310_Remark,"
            SQL = SQL & " K1310_MaterialCode_K3011,"
            SQL = SQL & " K1310_seSite,"
            SQL = SQL & " K1310_cdSite,"
            SQL = SQL & " K1310_DateInsert,"
            SQL = SQL & " K1310_DateUpdate,"
            SQL = SQL & " K1310_InchargeInsert,"
            SQL = SQL & " K1310_InchargeUpdate,"
            SQL = SQL & " K1310_TimeInsert,"
            SQL = SQL & " K1310_TimeUpdate "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z1310.OrderNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1310.OrderNoSeq) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1310.GroupComponentBOM) & "', "
            SQL = SQL & "   " & FormatSQL(z1310.GroupComponentSeq) & ", "
            SQL = SQL & "   " & FormatSQL(z1310.Dseq) & ", "
            SQL = SQL & "  N'" & FormatSQL(z1310.ProcessSeq) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1310.CustomerCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1310.selGroupComponent) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1310.cdGroupComponent) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1310.ComponentName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1310.MaterialCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1310.seUnitMaterial) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1310.cdUnitMaterial) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1310.Specification) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1310.Width) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1310.WidthID) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1310.Height) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1310.SizeName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1310.cdColorCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1310.ColorCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1310.ColorName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1310.seShoesStatus) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1310.cdShoesStatus) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1310.seDepartment) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1310.cdDepartment) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1310.ContractID) & "', "
            SQL = SQL & "   " & FormatSQL(z1310.ContracSeq) & ", "
            SQL = SQL & "  N'" & FormatSQL(z1310.SupplierCode) & "', "
            SQL = SQL & "   " & FormatSQL(z1310.PriceMaterial) & ", "
            SQL = SQL & "   " & FormatSQL(z1310.ExchangeCost) & ", "
            SQL = SQL & "   " & FormatSQL(z1310.ComplicationCost) & ", "
            SQL = SQL & "   " & FormatSQL(z1310.AddedCost) & ", "
            SQL = SQL & "   " & FormatSQL(z1310.ShippingRate) & ", "
            SQL = SQL & "   " & FormatSQL(z1310.ShippingCost) & ", "
            SQL = SQL & "   " & FormatSQL(z1310.PriceRnD) & ", "
            SQL = SQL & "   " & FormatSQL(z1310.Price) & ", "
            SQL = SQL & "  N'" & FormatSQL(z1310.seUnitPrice) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1310.cdUnitPrice) & "', "
            SQL = SQL & "   " & FormatSQL(z1310.QtyComponent) & ", "
            SQL = SQL & "   " & FormatSQL(z1310.Consumption) & ", "
            SQL = SQL & "   " & FormatSQL(z1310.Loss) & ", "
            SQL = SQL & "   " & FormatSQL(z1310.GrossUsage) & ", "
            SQL = SQL & "   " & FormatSQL(z1310.MaterialAMT) & ", "
            SQL = SQL & "   " & FormatSQL(z1310.MaterialAMTPurchasing) & ", "
            SQL = SQL & "   " & FormatSQL(z1310.MaterialAMTSales) & ", "
            SQL = SQL & "  N'" & FormatSQL(z1310.seSubProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1310.cdSubProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1310.seSpecialProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1310.cdSpecialProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1310.CheckMark) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1310.CheckUse) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1310.CheckP1) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1310.CheckP2) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1310.CheckP3) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1310.CheckP4) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1310.CheckP5) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1310.CheckP6) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1310.CheckP7) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1310.CheckP8) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1310.CheckP9) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1310.CheckUse1) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1310.CheckMatching) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1310.Remark) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1310.MaterialCode_K3011) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1310.seSite) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1310.cdSite) & "', "
            SQL = SQL & "  N'" & FormatSQL(PUB.DAT) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1310.DateUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(PUB.SAW) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1310.InchargeUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(PUB.TIME) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1310.TimeUpdate) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK1310 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK1310", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK1310(z1310 As T1310_AREA) As Boolean
        REWRITE_PFK1310 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z1310)

            SQL = " UPDATE PFK1310 SET "
            SQL = SQL & "    K1310_OrderNo      = N'" & FormatSQL(z1310.OrderNo) & "', "
            SQL = SQL & "    K1310_OrderNoSeq      = N'" & FormatSQL(z1310.OrderNoSeq) & "', "
            SQL = SQL & "    K1310_GroupComponentBOM      = N'" & FormatSQL(z1310.GroupComponentBOM) & "', "
            SQL = SQL & "    K1310_GroupComponentSeq      =  " & FormatSQL(z1310.GroupComponentSeq) & ", "
            SQL = SQL & "    K1310_Dseq      =  " & FormatSQL(z1310.Dseq) & ", "
            SQL = SQL & "    K1310_ProcessSeq      = N'" & FormatSQL(z1310.ProcessSeq) & "', "
            SQL = SQL & "    K1310_CustomerCode      = N'" & FormatSQL(z1310.CustomerCode) & "', "
            SQL = SQL & "    K1310_selGroupComponent      = N'" & FormatSQL(z1310.selGroupComponent) & "', "
            SQL = SQL & "    K1310_cdGroupComponent      = N'" & FormatSQL(z1310.cdGroupComponent) & "', "
            SQL = SQL & "    K1310_ComponentName      = N'" & FormatSQL(z1310.ComponentName) & "', "
            SQL = SQL & "    K1310_MaterialCode      = N'" & FormatSQL(z1310.MaterialCode) & "', "
            SQL = SQL & "    K1310_seUnitMaterial      = N'" & FormatSQL(z1310.seUnitMaterial) & "', "
            SQL = SQL & "    K1310_cdUnitMaterial      = N'" & FormatSQL(z1310.cdUnitMaterial) & "', "
            SQL = SQL & "    K1310_Specification      = N'" & FormatSQL(z1310.Specification) & "', "
            SQL = SQL & "    K1310_Width      = N'" & FormatSQL(z1310.Width) & "', "
            SQL = SQL & "    K1310_WidthID      = N'" & FormatSQL(z1310.WidthID) & "', "
            SQL = SQL & "    K1310_Height      = N'" & FormatSQL(z1310.Height) & "', "
            SQL = SQL & "    K1310_SizeName      = N'" & FormatSQL(z1310.SizeName) & "', "
            SQL = SQL & "    K1310_cdColorCode      = N'" & FormatSQL(z1310.cdColorCode) & "', "
            SQL = SQL & "    K1310_ColorCode      = N'" & FormatSQL(z1310.ColorCode) & "', "
            SQL = SQL & "    K1310_ColorName      = N'" & FormatSQL(z1310.ColorName) & "', "
            SQL = SQL & "    K1310_seShoesStatus      = N'" & FormatSQL(z1310.seShoesStatus) & "', "
            SQL = SQL & "    K1310_cdShoesStatus      = N'" & FormatSQL(z1310.cdShoesStatus) & "', "
            SQL = SQL & "    K1310_seDepartment      = N'" & FormatSQL(z1310.seDepartment) & "', "
            SQL = SQL & "    K1310_cdDepartment      = N'" & FormatSQL(z1310.cdDepartment) & "', "
            SQL = SQL & "    K1310_ContractID      = N'" & FormatSQL(z1310.ContractID) & "', "
            SQL = SQL & "    K1310_ContracSeq      =  " & FormatSQL(z1310.ContracSeq) & ", "
            SQL = SQL & "    K1310_SupplierCode      = N'" & FormatSQL(z1310.SupplierCode) & "', "
            SQL = SQL & "    K1310_PriceMaterial      =  " & FormatSQL(z1310.PriceMaterial) & ", "
            SQL = SQL & "    K1310_ExchangeCost      =  " & FormatSQL(z1310.ExchangeCost) & ", "
            SQL = SQL & "    K1310_ComplicationCost      =  " & FormatSQL(z1310.ComplicationCost) & ", "
            SQL = SQL & "    K1310_AddedCost      =  " & FormatSQL(z1310.AddedCost) & ", "
            SQL = SQL & "    K1310_ShippingRate      =  " & FormatSQL(z1310.ShippingRate) & ", "
            SQL = SQL & "    K1310_ShippingCost      =  " & FormatSQL(z1310.ShippingCost) & ", "
            SQL = SQL & "    K1310_PriceRnD      =  " & FormatSQL(z1310.PriceRnD) & ", "
            SQL = SQL & "    K1310_Price      =  " & FormatSQL(z1310.Price) & ", "
            SQL = SQL & "    K1310_seUnitPrice      = N'" & FormatSQL(z1310.seUnitPrice) & "', "
            SQL = SQL & "    K1310_cdUnitPrice      = N'" & FormatSQL(z1310.cdUnitPrice) & "', "
            SQL = SQL & "    K1310_QtyComponent      =  " & FormatSQL(z1310.QtyComponent) & ", "
            SQL = SQL & "    K1310_Consumption      =  " & FormatSQL(z1310.Consumption) & ", "
            SQL = SQL & "    K1310_Loss      =  " & FormatSQL(z1310.Loss) & ", "
            SQL = SQL & "    K1310_GrossUsage      =  " & FormatSQL(z1310.GrossUsage) & ", "
            SQL = SQL & "    K1310_MaterialAMT      =  " & FormatSQL(z1310.MaterialAMT) & ", "
            SQL = SQL & "    K1310_MaterialAMTPurchasing      =  " & FormatSQL(z1310.MaterialAMTPurchasing) & ", "
            SQL = SQL & "    K1310_MaterialAMTSales      =  " & FormatSQL(z1310.MaterialAMTSales) & ", "
            SQL = SQL & "    K1310_seSubProcess      = N'" & FormatSQL(z1310.seSubProcess) & "', "
            SQL = SQL & "    K1310_cdSubProcess      = N'" & FormatSQL(z1310.cdSubProcess) & "', "
            SQL = SQL & "    K1310_seSpecialProcess      = N'" & FormatSQL(z1310.seSpecialProcess) & "', "
            SQL = SQL & "    K1310_cdSpecialProcess      = N'" & FormatSQL(z1310.cdSpecialProcess) & "', "
            SQL = SQL & "    K1310_CheckMark      = N'" & FormatSQL(z1310.CheckMark) & "', "
            SQL = SQL & "    K1310_CheckUse      = N'" & FormatSQL(z1310.CheckUse) & "', "
            SQL = SQL & "    K1310_CheckP1      = N'" & FormatSQL(z1310.CheckP1) & "', "
            SQL = SQL & "    K1310_CheckP2      = N'" & FormatSQL(z1310.CheckP2) & "', "
            SQL = SQL & "    K1310_CheckP3      = N'" & FormatSQL(z1310.CheckP3) & "', "
            SQL = SQL & "    K1310_CheckP4      = N'" & FormatSQL(z1310.CheckP4) & "', "
            SQL = SQL & "    K1310_CheckP5      = N'" & FormatSQL(z1310.CheckP5) & "', "
            SQL = SQL & "    K1310_CheckP6      = N'" & FormatSQL(z1310.CheckP6) & "', "
            SQL = SQL & "    K1310_CheckP7      = N'" & FormatSQL(z1310.CheckP7) & "', "
            SQL = SQL & "    K1310_CheckP8      = N'" & FormatSQL(z1310.CheckP8) & "', "
            SQL = SQL & "    K1310_CheckP9      = N'" & FormatSQL(z1310.CheckP9) & "', "
            SQL = SQL & "    K1310_CheckUse1      = N'" & FormatSQL(z1310.CheckUse1) & "', "
            SQL = SQL & "    K1310_CheckMatching      = N'" & FormatSQL(z1310.CheckMatching) & "', "
            SQL = SQL & "    K1310_Remark      = N'" & FormatSQL(z1310.Remark) & "', "
            SQL = SQL & "    K1310_MaterialCode_K3011      = N'" & FormatSQL(z1310.MaterialCode_K3011) & "', "
            SQL = SQL & "    K1310_seSite      = N'" & FormatSQL(z1310.seSite) & "', "
            SQL = SQL & "    K1310_cdSite      = N'" & FormatSQL(z1310.cdSite) & "', "
            SQL = SQL & "    K1310_DateInsert      = N'" & FormatSQL(z1310.DateInsert) & "', "
            SQL = SQL & "    K1310_DateUpdate      = N'" & FormatSQL(PUB.DAT) & "', "
            SQL = SQL & "    K1310_InchargeInsert      = N'" & FormatSQL(z1310.InchargeInsert) & "', "
            SQL = SQL & "    K1310_InchargeUpdate      = N'" & FormatSQL(PUB.SAW) & "', "
            SQL = SQL & "    K1310_TimeInsert      = N'" & FormatSQL(z1310.TimeInsert) & "', "
            SQL = SQL & "    K1310_TimeUpdate      = N'" & FormatSQL(PUB.TIME) & "'  "
            SQL = SQL & " WHERE K1310_AutoKey		 =  " & z1310.AutoKey & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()


            REWRITE_PFK1310 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK1310", vbCritical)

        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK1310(z1310 As T1310_AREA) As Boolean
        DELETE_PFK1310 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z1310)

            SQL = " DELETE FROM PFK1310  "
            SQL = SQL & " WHERE K1310_AutoKey		 =  " & z1310.AutoKey & "  "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK1310 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK1310", vbCritical)
        Finally
            Call GetFullInformation("PFK1310", "D", SQL)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D1310_CLEAR()
        Try

            D1310.AutoKey = 0
            D1310.OrderNo = ""
            D1310.OrderNoSeq = ""
            D1310.GroupComponentBOM = ""
            D1310.GroupComponentSeq = 0
            D1310.Dseq = 0
            D1310.ProcessSeq = ""
            D1310.CustomerCode = ""
            D1310.selGroupComponent = ""
            D1310.cdGroupComponent = ""
            D1310.ComponentName = ""
            D1310.MaterialCode = ""
            D1310.seUnitMaterial = ""
            D1310.cdUnitMaterial = ""
            D1310.Specification = ""
            D1310.Width = ""
            D1310.WidthID = ""
            D1310.Height = ""
            D1310.SizeName = ""
            D1310.cdColorCode = ""
            D1310.ColorCode = ""
            D1310.ColorName = ""
            D1310.seShoesStatus = ""
            D1310.cdShoesStatus = ""
            D1310.seDepartment = ""
            D1310.cdDepartment = ""
            D1310.ContractID = ""
            D1310.ContracSeq = 0
            D1310.SupplierCode = ""
            D1310.PriceMaterial = 0
            D1310.ExchangeCost = 0
            D1310.ComplicationCost = 0
            D1310.AddedCost = 0
            D1310.ShippingRate = 0
            D1310.ShippingCost = 0
            D1310.PriceRnD = 0
            D1310.Price = 0
            D1310.seUnitPrice = ""
            D1310.cdUnitPrice = ""
            D1310.QtyComponent = 0
            D1310.Consumption = 0
            D1310.Loss = 0
            D1310.GrossUsage = 0
            D1310.MaterialAMT = 0
            D1310.MaterialAMTPurchasing = 0
            D1310.MaterialAMTSales = 0
            D1310.seSubProcess = ""
            D1310.cdSubProcess = ""
            D1310.seSpecialProcess = ""
            D1310.cdSpecialProcess = ""
            D1310.CheckMark = ""
            D1310.CheckUse = ""
            D1310.CheckP1 = ""
            D1310.CheckP2 = ""
            D1310.CheckP3 = ""
            D1310.CheckP4 = ""
            D1310.CheckP5 = ""
            D1310.CheckP6 = ""
            D1310.CheckP7 = ""
            D1310.CheckP8 = ""
            D1310.CheckP9 = ""
            D1310.CheckUse1 = ""
            D1310.CheckMatching = ""
            D1310.Remark = ""
            D1310.MaterialCode_K3011 = ""
            D1310.seSite = ""
            D1310.cdSite = ""
            D1310.DateInsert = ""
            D1310.DateUpdate = ""
            D1310.InchargeInsert = ""
            D1310.InchargeUpdate = ""
            D1310.TimeInsert = ""
            D1310.TimeUpdate = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D1310_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x1310 As T1310_AREA)
        Try

            x1310.AutoKey = trim$(x1310.AutoKey)
            x1310.OrderNo = trim$(x1310.OrderNo)
            x1310.OrderNoSeq = trim$(x1310.OrderNoSeq)
            x1310.GroupComponentBOM = trim$(x1310.GroupComponentBOM)
            x1310.GroupComponentSeq = trim$(x1310.GroupComponentSeq)
            x1310.Dseq = trim$(x1310.Dseq)
            x1310.ProcessSeq = trim$(x1310.ProcessSeq)
            x1310.CustomerCode = trim$(x1310.CustomerCode)
            x1310.selGroupComponent = trim$(x1310.selGroupComponent)
            x1310.cdGroupComponent = trim$(x1310.cdGroupComponent)
            x1310.ComponentName = trim$(x1310.ComponentName)
            x1310.MaterialCode = trim$(x1310.MaterialCode)
            x1310.seUnitMaterial = trim$(x1310.seUnitMaterial)
            x1310.cdUnitMaterial = trim$(x1310.cdUnitMaterial)
            x1310.Specification = trim$(x1310.Specification)
            x1310.Width = trim$(x1310.Width)
            x1310.WidthID = trim$(x1310.WidthID)
            x1310.Height = trim$(x1310.Height)
            x1310.SizeName = trim$(x1310.SizeName)
            x1310.cdColorCode = trim$(x1310.cdColorCode)
            x1310.ColorCode = trim$(x1310.ColorCode)
            x1310.ColorName = trim$(x1310.ColorName)
            x1310.seShoesStatus = trim$(x1310.seShoesStatus)
            x1310.cdShoesStatus = trim$(x1310.cdShoesStatus)
            x1310.seDepartment = trim$(x1310.seDepartment)
            x1310.cdDepartment = trim$(x1310.cdDepartment)
            x1310.ContractID = trim$(x1310.ContractID)
            x1310.ContracSeq = trim$(x1310.ContracSeq)
            x1310.SupplierCode = trim$(x1310.SupplierCode)
            x1310.PriceMaterial = trim$(x1310.PriceMaterial)
            x1310.ExchangeCost = trim$(x1310.ExchangeCost)
            x1310.ComplicationCost = trim$(x1310.ComplicationCost)
            x1310.AddedCost = trim$(x1310.AddedCost)
            x1310.ShippingRate = trim$(x1310.ShippingRate)
            x1310.ShippingCost = trim$(x1310.ShippingCost)
            x1310.PriceRnD = trim$(x1310.PriceRnD)
            x1310.Price = trim$(x1310.Price)
            x1310.seUnitPrice = trim$(x1310.seUnitPrice)
            x1310.cdUnitPrice = trim$(x1310.cdUnitPrice)
            x1310.QtyComponent = trim$(x1310.QtyComponent)
            x1310.Consumption = trim$(x1310.Consumption)
            x1310.Loss = trim$(x1310.Loss)
            x1310.GrossUsage = trim$(x1310.GrossUsage)
            x1310.MaterialAMT = trim$(x1310.MaterialAMT)
            x1310.MaterialAMTPurchasing = trim$(x1310.MaterialAMTPurchasing)
            x1310.MaterialAMTSales = trim$(x1310.MaterialAMTSales)
            x1310.seSubProcess = trim$(x1310.seSubProcess)
            x1310.cdSubProcess = trim$(x1310.cdSubProcess)
            x1310.seSpecialProcess = trim$(x1310.seSpecialProcess)
            x1310.cdSpecialProcess = trim$(x1310.cdSpecialProcess)
            x1310.CheckMark = trim$(x1310.CheckMark)
            x1310.CheckUse = trim$(x1310.CheckUse)
            x1310.CheckP1 = trim$(x1310.CheckP1)
            x1310.CheckP2 = trim$(x1310.CheckP2)
            x1310.CheckP3 = trim$(x1310.CheckP3)
            x1310.CheckP4 = trim$(x1310.CheckP4)
            x1310.CheckP5 = trim$(x1310.CheckP5)
            x1310.CheckP6 = trim$(x1310.CheckP6)
            x1310.CheckP7 = trim$(x1310.CheckP7)
            x1310.CheckP8 = trim$(x1310.CheckP8)
            x1310.CheckP9 = trim$(x1310.CheckP9)
            x1310.CheckUse1 = trim$(x1310.CheckUse1)
            x1310.CheckMatching = trim$(x1310.CheckMatching)
            x1310.Remark = trim$(x1310.Remark)
            x1310.MaterialCode_K3011 = trim$(x1310.MaterialCode_K3011)
            x1310.seSite = trim$(x1310.seSite)
            x1310.cdSite = trim$(x1310.cdSite)
            x1310.DateInsert = trim$(x1310.DateInsert)
            x1310.DateUpdate = trim$(x1310.DateUpdate)
            x1310.InchargeInsert = trim$(x1310.InchargeInsert)
            x1310.InchargeUpdate = trim$(x1310.InchargeUpdate)
            x1310.TimeInsert = trim$(x1310.TimeInsert)
            x1310.TimeUpdate = trim$(x1310.TimeUpdate)

            If trim$(x1310.AutoKey) = "" Then x1310.AutoKey = 0
            If trim$(x1310.OrderNo) = "" Then x1310.OrderNo = Space(1)
            If trim$(x1310.OrderNoSeq) = "" Then x1310.OrderNoSeq = Space(1)
            If trim$(x1310.GroupComponentBOM) = "" Then x1310.GroupComponentBOM = Space(1)
            If trim$(x1310.GroupComponentSeq) = "" Then x1310.GroupComponentSeq = 0
            If trim$(x1310.Dseq) = "" Then x1310.Dseq = 0
            If trim$(x1310.ProcessSeq) = "" Then x1310.ProcessSeq = Space(1)
            If trim$(x1310.CustomerCode) = "" Then x1310.CustomerCode = Space(1)
            If trim$(x1310.selGroupComponent) = "" Then x1310.selGroupComponent = Space(1)
            If trim$(x1310.cdGroupComponent) = "" Then x1310.cdGroupComponent = Space(1)
            If trim$(x1310.ComponentName) = "" Then x1310.ComponentName = Space(1)
            If trim$(x1310.MaterialCode) = "" Then x1310.MaterialCode = Space(1)
            If trim$(x1310.seUnitMaterial) = "" Then x1310.seUnitMaterial = Space(1)
            If trim$(x1310.cdUnitMaterial) = "" Then x1310.cdUnitMaterial = Space(1)
            If trim$(x1310.Specification) = "" Then x1310.Specification = Space(1)
            If trim$(x1310.Width) = "" Then x1310.Width = Space(1)
            If trim$(x1310.WidthID) = "" Then x1310.WidthID = Space(1)
            If trim$(x1310.Height) = "" Then x1310.Height = Space(1)
            If trim$(x1310.SizeName) = "" Then x1310.SizeName = Space(1)
            If trim$(x1310.cdColorCode) = "" Then x1310.cdColorCode = Space(1)
            If trim$(x1310.ColorCode) = "" Then x1310.ColorCode = Space(1)
            If trim$(x1310.ColorName) = "" Then x1310.ColorName = Space(1)
            If trim$(x1310.seShoesStatus) = "" Then x1310.seShoesStatus = Space(1)
            If trim$(x1310.cdShoesStatus) = "" Then x1310.cdShoesStatus = Space(1)
            If trim$(x1310.seDepartment) = "" Then x1310.seDepartment = Space(1)
            If trim$(x1310.cdDepartment) = "" Then x1310.cdDepartment = Space(1)
            If trim$(x1310.ContractID) = "" Then x1310.ContractID = Space(1)
            If trim$(x1310.ContracSeq) = "" Then x1310.ContracSeq = 0
            If trim$(x1310.SupplierCode) = "" Then x1310.SupplierCode = Space(1)
            If trim$(x1310.PriceMaterial) = "" Then x1310.PriceMaterial = 0
            If trim$(x1310.ExchangeCost) = "" Then x1310.ExchangeCost = 0
            If trim$(x1310.ComplicationCost) = "" Then x1310.ComplicationCost = 0
            If trim$(x1310.AddedCost) = "" Then x1310.AddedCost = 0
            If trim$(x1310.ShippingRate) = "" Then x1310.ShippingRate = 0
            If trim$(x1310.ShippingCost) = "" Then x1310.ShippingCost = 0
            If trim$(x1310.PriceRnD) = "" Then x1310.PriceRnD = 0
            If trim$(x1310.Price) = "" Then x1310.Price = 0
            If trim$(x1310.seUnitPrice) = "" Then x1310.seUnitPrice = Space(1)
            If trim$(x1310.cdUnitPrice) = "" Then x1310.cdUnitPrice = Space(1)
            If trim$(x1310.QtyComponent) = "" Then x1310.QtyComponent = 0
            If trim$(x1310.Consumption) = "" Then x1310.Consumption = 0
            If trim$(x1310.Loss) = "" Then x1310.Loss = 0
            If trim$(x1310.GrossUsage) = "" Then x1310.GrossUsage = 0
            If trim$(x1310.MaterialAMT) = "" Then x1310.MaterialAMT = 0
            If trim$(x1310.MaterialAMTPurchasing) = "" Then x1310.MaterialAMTPurchasing = 0
            If trim$(x1310.MaterialAMTSales) = "" Then x1310.MaterialAMTSales = 0
            If trim$(x1310.seSubProcess) = "" Then x1310.seSubProcess = Space(1)
            If trim$(x1310.cdSubProcess) = "" Then x1310.cdSubProcess = Space(1)
            If trim$(x1310.seSpecialProcess) = "" Then x1310.seSpecialProcess = Space(1)
            If trim$(x1310.cdSpecialProcess) = "" Then x1310.cdSpecialProcess = Space(1)
            If trim$(x1310.CheckMark) = "" Then x1310.CheckMark = Space(1)
            If trim$(x1310.CheckUse) = "" Then x1310.CheckUse = Space(1)
            If trim$(x1310.CheckP1) = "" Then x1310.CheckP1 = Space(1)
            If trim$(x1310.CheckP2) = "" Then x1310.CheckP2 = Space(1)
            If trim$(x1310.CheckP3) = "" Then x1310.CheckP3 = Space(1)
            If trim$(x1310.CheckP4) = "" Then x1310.CheckP4 = Space(1)
            If trim$(x1310.CheckP5) = "" Then x1310.CheckP5 = Space(1)
            If trim$(x1310.CheckP6) = "" Then x1310.CheckP6 = Space(1)
            If trim$(x1310.CheckP7) = "" Then x1310.CheckP7 = Space(1)
            If trim$(x1310.CheckP8) = "" Then x1310.CheckP8 = Space(1)
            If trim$(x1310.CheckP9) = "" Then x1310.CheckP9 = Space(1)
            If trim$(x1310.CheckUse1) = "" Then x1310.CheckUse1 = Space(1)
            If trim$(x1310.CheckMatching) = "" Then x1310.CheckMatching = Space(1)
            If trim$(x1310.Remark) = "" Then x1310.Remark = Space(1)
            If trim$(x1310.MaterialCode_K3011) = "" Then x1310.MaterialCode_K3011 = Space(1)
            If trim$(x1310.seSite) = "" Then x1310.seSite = Space(1)
            If trim$(x1310.cdSite) = "" Then x1310.cdSite = Space(1)
            If trim$(x1310.DateInsert) = "" Then x1310.DateInsert = Space(1)
            If trim$(x1310.DateUpdate) = "" Then x1310.DateUpdate = Space(1)
            If trim$(x1310.InchargeInsert) = "" Then x1310.InchargeInsert = Space(1)
            If trim$(x1310.InchargeUpdate) = "" Then x1310.InchargeUpdate = Space(1)
            If trim$(x1310.TimeInsert) = "" Then x1310.TimeInsert = Space(1)
            If trim$(x1310.TimeUpdate) = "" Then x1310.TimeUpdate = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K1310_MOVE(rs1310 As SqlClient.SqlDataReader)
        Try

            Call D1310_CLEAR()

            If IsdbNull(rs1310!K1310_AutoKey) = False Then D1310.AutoKey = Trim$(rs1310!K1310_AutoKey)
            If IsdbNull(rs1310!K1310_OrderNo) = False Then D1310.OrderNo = Trim$(rs1310!K1310_OrderNo)
            If IsdbNull(rs1310!K1310_OrderNoSeq) = False Then D1310.OrderNoSeq = Trim$(rs1310!K1310_OrderNoSeq)
            If IsdbNull(rs1310!K1310_GroupComponentBOM) = False Then D1310.GroupComponentBOM = Trim$(rs1310!K1310_GroupComponentBOM)
            If IsdbNull(rs1310!K1310_GroupComponentSeq) = False Then D1310.GroupComponentSeq = Trim$(rs1310!K1310_GroupComponentSeq)
            If IsdbNull(rs1310!K1310_Dseq) = False Then D1310.Dseq = Trim$(rs1310!K1310_Dseq)
            If IsdbNull(rs1310!K1310_ProcessSeq) = False Then D1310.ProcessSeq = Trim$(rs1310!K1310_ProcessSeq)
            If IsdbNull(rs1310!K1310_CustomerCode) = False Then D1310.CustomerCode = Trim$(rs1310!K1310_CustomerCode)
            If IsdbNull(rs1310!K1310_selGroupComponent) = False Then D1310.selGroupComponent = Trim$(rs1310!K1310_selGroupComponent)
            If IsdbNull(rs1310!K1310_cdGroupComponent) = False Then D1310.cdGroupComponent = Trim$(rs1310!K1310_cdGroupComponent)
            If IsdbNull(rs1310!K1310_ComponentName) = False Then D1310.ComponentName = Trim$(rs1310!K1310_ComponentName)
            If IsdbNull(rs1310!K1310_MaterialCode) = False Then D1310.MaterialCode = Trim$(rs1310!K1310_MaterialCode)
            If IsdbNull(rs1310!K1310_seUnitMaterial) = False Then D1310.seUnitMaterial = Trim$(rs1310!K1310_seUnitMaterial)
            If IsdbNull(rs1310!K1310_cdUnitMaterial) = False Then D1310.cdUnitMaterial = Trim$(rs1310!K1310_cdUnitMaterial)
            If IsdbNull(rs1310!K1310_Specification) = False Then D1310.Specification = Trim$(rs1310!K1310_Specification)
            If IsdbNull(rs1310!K1310_Width) = False Then D1310.Width = Trim$(rs1310!K1310_Width)
            If IsdbNull(rs1310!K1310_WidthID) = False Then D1310.WidthID = Trim$(rs1310!K1310_WidthID)
            If IsdbNull(rs1310!K1310_Height) = False Then D1310.Height = Trim$(rs1310!K1310_Height)
            If IsdbNull(rs1310!K1310_SizeName) = False Then D1310.SizeName = Trim$(rs1310!K1310_SizeName)
            If IsdbNull(rs1310!K1310_cdColorCode) = False Then D1310.cdColorCode = Trim$(rs1310!K1310_cdColorCode)
            If IsdbNull(rs1310!K1310_ColorCode) = False Then D1310.ColorCode = Trim$(rs1310!K1310_ColorCode)
            If IsdbNull(rs1310!K1310_ColorName) = False Then D1310.ColorName = Trim$(rs1310!K1310_ColorName)
            If IsdbNull(rs1310!K1310_seShoesStatus) = False Then D1310.seShoesStatus = Trim$(rs1310!K1310_seShoesStatus)
            If IsdbNull(rs1310!K1310_cdShoesStatus) = False Then D1310.cdShoesStatus = Trim$(rs1310!K1310_cdShoesStatus)
            If IsdbNull(rs1310!K1310_seDepartment) = False Then D1310.seDepartment = Trim$(rs1310!K1310_seDepartment)
            If IsdbNull(rs1310!K1310_cdDepartment) = False Then D1310.cdDepartment = Trim$(rs1310!K1310_cdDepartment)
            If IsdbNull(rs1310!K1310_ContractID) = False Then D1310.ContractID = Trim$(rs1310!K1310_ContractID)
            If IsdbNull(rs1310!K1310_ContracSeq) = False Then D1310.ContracSeq = Trim$(rs1310!K1310_ContracSeq)
            If IsdbNull(rs1310!K1310_SupplierCode) = False Then D1310.SupplierCode = Trim$(rs1310!K1310_SupplierCode)
            If IsdbNull(rs1310!K1310_PriceMaterial) = False Then D1310.PriceMaterial = Trim$(rs1310!K1310_PriceMaterial)
            If IsdbNull(rs1310!K1310_ExchangeCost) = False Then D1310.ExchangeCost = Trim$(rs1310!K1310_ExchangeCost)
            If IsdbNull(rs1310!K1310_ComplicationCost) = False Then D1310.ComplicationCost = Trim$(rs1310!K1310_ComplicationCost)
            If IsdbNull(rs1310!K1310_AddedCost) = False Then D1310.AddedCost = Trim$(rs1310!K1310_AddedCost)
            If IsdbNull(rs1310!K1310_ShippingRate) = False Then D1310.ShippingRate = Trim$(rs1310!K1310_ShippingRate)
            If IsdbNull(rs1310!K1310_ShippingCost) = False Then D1310.ShippingCost = Trim$(rs1310!K1310_ShippingCost)
            If IsdbNull(rs1310!K1310_PriceRnD) = False Then D1310.PriceRnD = Trim$(rs1310!K1310_PriceRnD)
            If IsdbNull(rs1310!K1310_Price) = False Then D1310.Price = Trim$(rs1310!K1310_Price)
            If IsdbNull(rs1310!K1310_seUnitPrice) = False Then D1310.seUnitPrice = Trim$(rs1310!K1310_seUnitPrice)
            If IsdbNull(rs1310!K1310_cdUnitPrice) = False Then D1310.cdUnitPrice = Trim$(rs1310!K1310_cdUnitPrice)
            If IsdbNull(rs1310!K1310_QtyComponent) = False Then D1310.QtyComponent = Trim$(rs1310!K1310_QtyComponent)
            If IsdbNull(rs1310!K1310_Consumption) = False Then D1310.Consumption = Trim$(rs1310!K1310_Consumption)
            If IsdbNull(rs1310!K1310_Loss) = False Then D1310.Loss = Trim$(rs1310!K1310_Loss)
            If IsdbNull(rs1310!K1310_GrossUsage) = False Then D1310.GrossUsage = Trim$(rs1310!K1310_GrossUsage)
            If IsdbNull(rs1310!K1310_MaterialAMT) = False Then D1310.MaterialAMT = Trim$(rs1310!K1310_MaterialAMT)
            If IsdbNull(rs1310!K1310_MaterialAMTPurchasing) = False Then D1310.MaterialAMTPurchasing = Trim$(rs1310!K1310_MaterialAMTPurchasing)
            If IsdbNull(rs1310!K1310_MaterialAMTSales) = False Then D1310.MaterialAMTSales = Trim$(rs1310!K1310_MaterialAMTSales)
            If IsdbNull(rs1310!K1310_seSubProcess) = False Then D1310.seSubProcess = Trim$(rs1310!K1310_seSubProcess)
            If IsdbNull(rs1310!K1310_cdSubProcess) = False Then D1310.cdSubProcess = Trim$(rs1310!K1310_cdSubProcess)
            If IsdbNull(rs1310!K1310_seSpecialProcess) = False Then D1310.seSpecialProcess = Trim$(rs1310!K1310_seSpecialProcess)
            If IsdbNull(rs1310!K1310_cdSpecialProcess) = False Then D1310.cdSpecialProcess = Trim$(rs1310!K1310_cdSpecialProcess)
            If IsdbNull(rs1310!K1310_CheckMark) = False Then D1310.CheckMark = Trim$(rs1310!K1310_CheckMark)
            If IsdbNull(rs1310!K1310_CheckUse) = False Then D1310.CheckUse = Trim$(rs1310!K1310_CheckUse)
            If IsdbNull(rs1310!K1310_CheckP1) = False Then D1310.CheckP1 = Trim$(rs1310!K1310_CheckP1)
            If IsdbNull(rs1310!K1310_CheckP2) = False Then D1310.CheckP2 = Trim$(rs1310!K1310_CheckP2)
            If IsdbNull(rs1310!K1310_CheckP3) = False Then D1310.CheckP3 = Trim$(rs1310!K1310_CheckP3)
            If IsdbNull(rs1310!K1310_CheckP4) = False Then D1310.CheckP4 = Trim$(rs1310!K1310_CheckP4)
            If IsdbNull(rs1310!K1310_CheckP5) = False Then D1310.CheckP5 = Trim$(rs1310!K1310_CheckP5)
            If IsdbNull(rs1310!K1310_CheckP6) = False Then D1310.CheckP6 = Trim$(rs1310!K1310_CheckP6)
            If IsdbNull(rs1310!K1310_CheckP7) = False Then D1310.CheckP7 = Trim$(rs1310!K1310_CheckP7)
            If IsdbNull(rs1310!K1310_CheckP8) = False Then D1310.CheckP8 = Trim$(rs1310!K1310_CheckP8)
            If IsdbNull(rs1310!K1310_CheckP9) = False Then D1310.CheckP9 = Trim$(rs1310!K1310_CheckP9)
            If IsdbNull(rs1310!K1310_CheckUse1) = False Then D1310.CheckUse1 = Trim$(rs1310!K1310_CheckUse1)
            If IsdbNull(rs1310!K1310_CheckMatching) = False Then D1310.CheckMatching = Trim$(rs1310!K1310_CheckMatching)
            If IsdbNull(rs1310!K1310_Remark) = False Then D1310.Remark = Trim$(rs1310!K1310_Remark)
            If IsdbNull(rs1310!K1310_MaterialCode_K3011) = False Then D1310.MaterialCode_K3011 = Trim$(rs1310!K1310_MaterialCode_K3011)
            If IsdbNull(rs1310!K1310_seSite) = False Then D1310.seSite = Trim$(rs1310!K1310_seSite)
            If IsdbNull(rs1310!K1310_cdSite) = False Then D1310.cdSite = Trim$(rs1310!K1310_cdSite)
            If IsdbNull(rs1310!K1310_DateInsert) = False Then D1310.DateInsert = Trim$(rs1310!K1310_DateInsert)
            If IsdbNull(rs1310!K1310_DateUpdate) = False Then D1310.DateUpdate = Trim$(rs1310!K1310_DateUpdate)
            If IsdbNull(rs1310!K1310_InchargeInsert) = False Then D1310.InchargeInsert = Trim$(rs1310!K1310_InchargeInsert)
            If IsdbNull(rs1310!K1310_InchargeUpdate) = False Then D1310.InchargeUpdate = Trim$(rs1310!K1310_InchargeUpdate)
            If IsdbNull(rs1310!K1310_TimeInsert) = False Then D1310.TimeInsert = Trim$(rs1310!K1310_TimeInsert)
            If IsdbNull(rs1310!K1310_TimeUpdate) = False Then D1310.TimeUpdate = Trim$(rs1310!K1310_TimeUpdate)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K1310_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K1310_MOVE(rs1310 As DataRow)
        Try

            Call D1310_CLEAR()

            If IsdbNull(rs1310!K1310_AutoKey) = False Then D1310.AutoKey = Trim$(rs1310!K1310_AutoKey)
            If IsdbNull(rs1310!K1310_OrderNo) = False Then D1310.OrderNo = Trim$(rs1310!K1310_OrderNo)
            If IsdbNull(rs1310!K1310_OrderNoSeq) = False Then D1310.OrderNoSeq = Trim$(rs1310!K1310_OrderNoSeq)
            If IsdbNull(rs1310!K1310_GroupComponentBOM) = False Then D1310.GroupComponentBOM = Trim$(rs1310!K1310_GroupComponentBOM)
            If IsdbNull(rs1310!K1310_GroupComponentSeq) = False Then D1310.GroupComponentSeq = Trim$(rs1310!K1310_GroupComponentSeq)
            If IsdbNull(rs1310!K1310_Dseq) = False Then D1310.Dseq = Trim$(rs1310!K1310_Dseq)
            If IsdbNull(rs1310!K1310_ProcessSeq) = False Then D1310.ProcessSeq = Trim$(rs1310!K1310_ProcessSeq)
            If IsdbNull(rs1310!K1310_CustomerCode) = False Then D1310.CustomerCode = Trim$(rs1310!K1310_CustomerCode)
            If IsdbNull(rs1310!K1310_selGroupComponent) = False Then D1310.selGroupComponent = Trim$(rs1310!K1310_selGroupComponent)
            If IsdbNull(rs1310!K1310_cdGroupComponent) = False Then D1310.cdGroupComponent = Trim$(rs1310!K1310_cdGroupComponent)
            If IsdbNull(rs1310!K1310_ComponentName) = False Then D1310.ComponentName = Trim$(rs1310!K1310_ComponentName)
            If IsdbNull(rs1310!K1310_MaterialCode) = False Then D1310.MaterialCode = Trim$(rs1310!K1310_MaterialCode)
            If IsdbNull(rs1310!K1310_seUnitMaterial) = False Then D1310.seUnitMaterial = Trim$(rs1310!K1310_seUnitMaterial)
            If IsdbNull(rs1310!K1310_cdUnitMaterial) = False Then D1310.cdUnitMaterial = Trim$(rs1310!K1310_cdUnitMaterial)
            If IsdbNull(rs1310!K1310_Specification) = False Then D1310.Specification = Trim$(rs1310!K1310_Specification)
            If IsdbNull(rs1310!K1310_Width) = False Then D1310.Width = Trim$(rs1310!K1310_Width)
            If IsdbNull(rs1310!K1310_WidthID) = False Then D1310.WidthID = Trim$(rs1310!K1310_WidthID)
            If IsdbNull(rs1310!K1310_Height) = False Then D1310.Height = Trim$(rs1310!K1310_Height)
            If IsdbNull(rs1310!K1310_SizeName) = False Then D1310.SizeName = Trim$(rs1310!K1310_SizeName)
            If IsdbNull(rs1310!K1310_cdColorCode) = False Then D1310.cdColorCode = Trim$(rs1310!K1310_cdColorCode)
            If IsdbNull(rs1310!K1310_ColorCode) = False Then D1310.ColorCode = Trim$(rs1310!K1310_ColorCode)
            If IsdbNull(rs1310!K1310_ColorName) = False Then D1310.ColorName = Trim$(rs1310!K1310_ColorName)
            If IsdbNull(rs1310!K1310_seShoesStatus) = False Then D1310.seShoesStatus = Trim$(rs1310!K1310_seShoesStatus)
            If IsdbNull(rs1310!K1310_cdShoesStatus) = False Then D1310.cdShoesStatus = Trim$(rs1310!K1310_cdShoesStatus)
            If IsdbNull(rs1310!K1310_seDepartment) = False Then D1310.seDepartment = Trim$(rs1310!K1310_seDepartment)
            If IsdbNull(rs1310!K1310_cdDepartment) = False Then D1310.cdDepartment = Trim$(rs1310!K1310_cdDepartment)
            If IsdbNull(rs1310!K1310_ContractID) = False Then D1310.ContractID = Trim$(rs1310!K1310_ContractID)
            If IsdbNull(rs1310!K1310_ContracSeq) = False Then D1310.ContracSeq = Trim$(rs1310!K1310_ContracSeq)
            If IsdbNull(rs1310!K1310_SupplierCode) = False Then D1310.SupplierCode = Trim$(rs1310!K1310_SupplierCode)
            If IsdbNull(rs1310!K1310_PriceMaterial) = False Then D1310.PriceMaterial = Trim$(rs1310!K1310_PriceMaterial)
            If IsdbNull(rs1310!K1310_ExchangeCost) = False Then D1310.ExchangeCost = Trim$(rs1310!K1310_ExchangeCost)
            If IsdbNull(rs1310!K1310_ComplicationCost) = False Then D1310.ComplicationCost = Trim$(rs1310!K1310_ComplicationCost)
            If IsdbNull(rs1310!K1310_AddedCost) = False Then D1310.AddedCost = Trim$(rs1310!K1310_AddedCost)
            If IsdbNull(rs1310!K1310_ShippingRate) = False Then D1310.ShippingRate = Trim$(rs1310!K1310_ShippingRate)
            If IsdbNull(rs1310!K1310_ShippingCost) = False Then D1310.ShippingCost = Trim$(rs1310!K1310_ShippingCost)
            If IsdbNull(rs1310!K1310_PriceRnD) = False Then D1310.PriceRnD = Trim$(rs1310!K1310_PriceRnD)
            If IsdbNull(rs1310!K1310_Price) = False Then D1310.Price = Trim$(rs1310!K1310_Price)
            If IsdbNull(rs1310!K1310_seUnitPrice) = False Then D1310.seUnitPrice = Trim$(rs1310!K1310_seUnitPrice)
            If IsdbNull(rs1310!K1310_cdUnitPrice) = False Then D1310.cdUnitPrice = Trim$(rs1310!K1310_cdUnitPrice)
            If IsdbNull(rs1310!K1310_QtyComponent) = False Then D1310.QtyComponent = Trim$(rs1310!K1310_QtyComponent)
            If IsdbNull(rs1310!K1310_Consumption) = False Then D1310.Consumption = Trim$(rs1310!K1310_Consumption)
            If IsdbNull(rs1310!K1310_Loss) = False Then D1310.Loss = Trim$(rs1310!K1310_Loss)
            If IsdbNull(rs1310!K1310_GrossUsage) = False Then D1310.GrossUsage = Trim$(rs1310!K1310_GrossUsage)
            If IsdbNull(rs1310!K1310_MaterialAMT) = False Then D1310.MaterialAMT = Trim$(rs1310!K1310_MaterialAMT)
            If IsdbNull(rs1310!K1310_MaterialAMTPurchasing) = False Then D1310.MaterialAMTPurchasing = Trim$(rs1310!K1310_MaterialAMTPurchasing)
            If IsdbNull(rs1310!K1310_MaterialAMTSales) = False Then D1310.MaterialAMTSales = Trim$(rs1310!K1310_MaterialAMTSales)
            If IsdbNull(rs1310!K1310_seSubProcess) = False Then D1310.seSubProcess = Trim$(rs1310!K1310_seSubProcess)
            If IsdbNull(rs1310!K1310_cdSubProcess) = False Then D1310.cdSubProcess = Trim$(rs1310!K1310_cdSubProcess)
            If IsdbNull(rs1310!K1310_seSpecialProcess) = False Then D1310.seSpecialProcess = Trim$(rs1310!K1310_seSpecialProcess)
            If IsdbNull(rs1310!K1310_cdSpecialProcess) = False Then D1310.cdSpecialProcess = Trim$(rs1310!K1310_cdSpecialProcess)
            If IsdbNull(rs1310!K1310_CheckMark) = False Then D1310.CheckMark = Trim$(rs1310!K1310_CheckMark)
            If IsdbNull(rs1310!K1310_CheckUse) = False Then D1310.CheckUse = Trim$(rs1310!K1310_CheckUse)
            If IsdbNull(rs1310!K1310_CheckP1) = False Then D1310.CheckP1 = Trim$(rs1310!K1310_CheckP1)
            If IsdbNull(rs1310!K1310_CheckP2) = False Then D1310.CheckP2 = Trim$(rs1310!K1310_CheckP2)
            If IsdbNull(rs1310!K1310_CheckP3) = False Then D1310.CheckP3 = Trim$(rs1310!K1310_CheckP3)
            If IsdbNull(rs1310!K1310_CheckP4) = False Then D1310.CheckP4 = Trim$(rs1310!K1310_CheckP4)
            If IsdbNull(rs1310!K1310_CheckP5) = False Then D1310.CheckP5 = Trim$(rs1310!K1310_CheckP5)
            If IsdbNull(rs1310!K1310_CheckP6) = False Then D1310.CheckP6 = Trim$(rs1310!K1310_CheckP6)
            If IsdbNull(rs1310!K1310_CheckP7) = False Then D1310.CheckP7 = Trim$(rs1310!K1310_CheckP7)
            If IsdbNull(rs1310!K1310_CheckP8) = False Then D1310.CheckP8 = Trim$(rs1310!K1310_CheckP8)
            If IsdbNull(rs1310!K1310_CheckP9) = False Then D1310.CheckP9 = Trim$(rs1310!K1310_CheckP9)
            If IsdbNull(rs1310!K1310_CheckUse1) = False Then D1310.CheckUse1 = Trim$(rs1310!K1310_CheckUse1)
            If IsdbNull(rs1310!K1310_CheckMatching) = False Then D1310.CheckMatching = Trim$(rs1310!K1310_CheckMatching)
            If IsdbNull(rs1310!K1310_Remark) = False Then D1310.Remark = Trim$(rs1310!K1310_Remark)
            If IsdbNull(rs1310!K1310_MaterialCode_K3011) = False Then D1310.MaterialCode_K3011 = Trim$(rs1310!K1310_MaterialCode_K3011)
            If IsdbNull(rs1310!K1310_seSite) = False Then D1310.seSite = Trim$(rs1310!K1310_seSite)
            If IsdbNull(rs1310!K1310_cdSite) = False Then D1310.cdSite = Trim$(rs1310!K1310_cdSite)
            If IsdbNull(rs1310!K1310_DateInsert) = False Then D1310.DateInsert = Trim$(rs1310!K1310_DateInsert)
            If IsdbNull(rs1310!K1310_DateUpdate) = False Then D1310.DateUpdate = Trim$(rs1310!K1310_DateUpdate)
            If IsdbNull(rs1310!K1310_InchargeInsert) = False Then D1310.InchargeInsert = Trim$(rs1310!K1310_InchargeInsert)
            If IsdbNull(rs1310!K1310_InchargeUpdate) = False Then D1310.InchargeUpdate = Trim$(rs1310!K1310_InchargeUpdate)
            If IsdbNull(rs1310!K1310_TimeInsert) = False Then D1310.TimeInsert = Trim$(rs1310!K1310_TimeInsert)
            If IsdbNull(rs1310!K1310_TimeUpdate) = False Then D1310.TimeUpdate = Trim$(rs1310!K1310_TimeUpdate)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K1310_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K1310_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z1310 As T1310_AREA, AUTOKEY As Double) As Boolean

        K1310_MOVE = False

        Try
            If READ_PFK1310(AUTOKEY) = True Then
                z1310 = D1310
                K1310_MOVE = True
            Else
                z1310 = Nothing
            End If

            If getColumnIndex(spr, "AutoKey") > -1 Then z1310.AutoKey = Cdecp(getDataM(spr, getColumnIndex(spr, "AutoKey"), xRow))
            If getColumnIndex(spr, "OrderNo") > -1 Then z1310.OrderNo = getDataM(spr, getColumnIndex(spr, "OrderNo"), xRow)
            If getColumnIndex(spr, "OrderNoSeq") > -1 Then z1310.OrderNoSeq = getDataM(spr, getColumnIndex(spr, "OrderNoSeq"), xRow)
            If getColumnIndex(spr, "GroupComponentBOM") > -1 Then z1310.GroupComponentBOM = getDataM(spr, getColumnIndex(spr, "GroupComponentBOM"), xRow)
            If getColumnIndex(spr, "GroupComponentSeq") > -1 Then z1310.GroupComponentSeq = Cdecp(getDataM(spr, getColumnIndex(spr, "GroupComponentSeq"), xRow))
            If getColumnIndex(spr, "Dseq") > -1 Then z1310.Dseq = Cdecp(getDataM(spr, getColumnIndex(spr, "Dseq"), xRow))
            If getColumnIndex(spr, "ProcessSeq") > -1 Then z1310.ProcessSeq = getDataM(spr, getColumnIndex(spr, "ProcessSeq"), xRow)
            If getColumnIndex(spr, "CustomerCode") > -1 Then z1310.CustomerCode = getDataM(spr, getColumnIndex(spr, "CustomerCode"), xRow)
            If getColumnIndex(spr, "selGroupComponent") > -1 Then z1310.selGroupComponent = getDataM(spr, getColumnIndex(spr, "selGroupComponent"), xRow)
            If getColumnIndex(spr, "cdGroupComponent") > -1 Then z1310.cdGroupComponent = getDataM(spr, getColumnIndex(spr, "cdGroupComponent"), xRow)
            If getColumnIndex(spr, "ComponentName") > -1 Then z1310.ComponentName = getDataM(spr, getColumnIndex(spr, "ComponentName"), xRow)
            If getColumnIndex(spr, "MaterialCode") > -1 Then z1310.MaterialCode = getDataM(spr, getColumnIndex(spr, "MaterialCode"), xRow)
            If getColumnIndex(spr, "seUnitMaterial") > -1 Then z1310.seUnitMaterial = getDataM(spr, getColumnIndex(spr, "seUnitMaterial"), xRow)
            If getColumnIndex(spr, "cdUnitMaterial") > -1 Then z1310.cdUnitMaterial = getDataM(spr, getColumnIndex(spr, "cdUnitMaterial"), xRow)
            If getColumnIndex(spr, "Specification") > -1 Then z1310.Specification = getDataM(spr, getColumnIndex(spr, "Specification"), xRow)
            If getColumnIndex(spr, "Width") > -1 Then z1310.Width = getDataM(spr, getColumnIndex(spr, "Width"), xRow)
            If getColumnIndex(spr, "WidthID") > -1 Then z1310.WidthID = getDataM(spr, getColumnIndex(spr, "WidthID"), xRow)
            If getColumnIndex(spr, "Height") > -1 Then z1310.Height = getDataM(spr, getColumnIndex(spr, "Height"), xRow)
            If getColumnIndex(spr, "SizeName") > -1 Then z1310.SizeName = getDataM(spr, getColumnIndex(spr, "SizeName"), xRow)
            If getColumnIndex(spr, "cdColorCode") > -1 Then z1310.cdColorCode = getDataM(spr, getColumnIndex(spr, "cdColorCode"), xRow)
            If getColumnIndex(spr, "ColorCode") > -1 Then z1310.ColorCode = getDataM(spr, getColumnIndex(spr, "ColorCode"), xRow)
            If getColumnIndex(spr, "ColorName") > -1 Then z1310.ColorName = getDataM(spr, getColumnIndex(spr, "ColorName"), xRow)
            If getColumnIndex(spr, "seShoesStatus") > -1 Then z1310.seShoesStatus = getDataM(spr, getColumnIndex(spr, "seShoesStatus"), xRow)
            If getColumnIndex(spr, "cdShoesStatus") > -1 Then z1310.cdShoesStatus = getDataM(spr, getColumnIndex(spr, "cdShoesStatus"), xRow)
            If getColumnIndex(spr, "seDepartment") > -1 Then z1310.seDepartment = getDataM(spr, getColumnIndex(spr, "seDepartment"), xRow)
            If getColumnIndex(spr, "cdDepartment") > -1 Then z1310.cdDepartment = getDataM(spr, getColumnIndex(spr, "cdDepartment"), xRow)
            If getColumnIndex(spr, "ContractID") > -1 Then z1310.ContractID = getDataM(spr, getColumnIndex(spr, "ContractID"), xRow)
            If getColumnIndex(spr, "ContracSeq") > -1 Then z1310.ContracSeq = Cdecp(getDataM(spr, getColumnIndex(spr, "ContracSeq"), xRow))
            If getColumnIndex(spr, "SupplierCode") > -1 Then z1310.SupplierCode = getDataM(spr, getColumnIndex(spr, "SupplierCode"), xRow)
            If getColumnIndex(spr, "PriceMaterial") > -1 Then z1310.PriceMaterial = Cdecp(getDataM(spr, getColumnIndex(spr, "PriceMaterial"), xRow))
            If getColumnIndex(spr, "ExchangeCost") > -1 Then z1310.ExchangeCost = Cdecp(getDataM(spr, getColumnIndex(spr, "ExchangeCost"), xRow))
            If getColumnIndex(spr, "ComplicationCost") > -1 Then z1310.ComplicationCost = Cdecp(getDataM(spr, getColumnIndex(spr, "ComplicationCost"), xRow))
            If getColumnIndex(spr, "AddedCost") > -1 Then z1310.AddedCost = Cdecp(getDataM(spr, getColumnIndex(spr, "AddedCost"), xRow))
            If getColumnIndex(spr, "ShippingRate") > -1 Then z1310.ShippingRate = Cdecp(getDataM(spr, getColumnIndex(spr, "ShippingRate"), xRow))
            If getColumnIndex(spr, "ShippingCost") > -1 Then z1310.ShippingCost = Cdecp(getDataM(spr, getColumnIndex(spr, "ShippingCost"), xRow))
            If getColumnIndex(spr, "PriceRnD") > -1 Then z1310.PriceRnD = Cdecp(getDataM(spr, getColumnIndex(spr, "PriceRnD"), xRow))
            If getColumnIndex(spr, "Price") > -1 Then z1310.Price = Cdecp(getDataM(spr, getColumnIndex(spr, "Price"), xRow))
            If getColumnIndex(spr, "seUnitPrice") > -1 Then z1310.seUnitPrice = getDataM(spr, getColumnIndex(spr, "seUnitPrice"), xRow)
            If getColumnIndex(spr, "cdUnitPrice") > -1 Then z1310.cdUnitPrice = getDataM(spr, getColumnIndex(spr, "cdUnitPrice"), xRow)
            If getColumnIndex(spr, "QtyComponent") > -1 Then z1310.QtyComponent = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyComponent"), xRow))
            If getColumnIndex(spr, "Consumption") > -1 Then z1310.Consumption = Cdecp(getDataM(spr, getColumnIndex(spr, "Consumption"), xRow))
            If getColumnIndex(spr, "Loss") > -1 Then z1310.Loss = Cdecp(getDataM(spr, getColumnIndex(spr, "Loss"), xRow))
            If getColumnIndex(spr, "GrossUsage") > -1 Then z1310.GrossUsage = Cdecp(getDataM(spr, getColumnIndex(spr, "GrossUsage"), xRow))
            If getColumnIndex(spr, "MaterialAMT") > -1 Then z1310.MaterialAMT = Cdecp(getDataM(spr, getColumnIndex(spr, "MaterialAMT"), xRow))
            If getColumnIndex(spr, "MaterialAMTPurchasing") > -1 Then z1310.MaterialAMTPurchasing = Cdecp(getDataM(spr, getColumnIndex(spr, "MaterialAMTPurchasing"), xRow))
            If getColumnIndex(spr, "MaterialAMTSales") > -1 Then z1310.MaterialAMTSales = Cdecp(getDataM(spr, getColumnIndex(spr, "MaterialAMTSales"), xRow))
            If getColumnIndex(spr, "seSubProcess") > -1 Then z1310.seSubProcess = getDataM(spr, getColumnIndex(spr, "seSubProcess"), xRow)
            If getColumnIndex(spr, "cdSubProcess") > -1 Then z1310.cdSubProcess = getDataM(spr, getColumnIndex(spr, "cdSubProcess"), xRow)
            If getColumnIndex(spr, "seSpecialProcess") > -1 Then z1310.seSpecialProcess = getDataM(spr, getColumnIndex(spr, "seSpecialProcess"), xRow)
            If getColumnIndex(spr, "cdSpecialProcess") > -1 Then z1310.cdSpecialProcess = getDataM(spr, getColumnIndex(spr, "cdSpecialProcess"), xRow)
            If getColumnIndex(spr, "CheckMark") > -1 Then z1310.CheckMark = getDataM(spr, getColumnIndex(spr, "CheckMark"), xRow)
            If getColumnIndex(spr, "CheckUse") > -1 Then z1310.CheckUse = getDataM(spr, getColumnIndex(spr, "CheckUse"), xRow)
            If getColumnIndex(spr, "CheckP1") > -1 Then z1310.CheckP1 = getDataM(spr, getColumnIndex(spr, "CheckP1"), xRow)
            If getColumnIndex(spr, "CheckP2") > -1 Then z1310.CheckP2 = getDataM(spr, getColumnIndex(spr, "CheckP2"), xRow)
            If getColumnIndex(spr, "CheckP3") > -1 Then z1310.CheckP3 = getDataM(spr, getColumnIndex(spr, "CheckP3"), xRow)
            If getColumnIndex(spr, "CheckP4") > -1 Then z1310.CheckP4 = getDataM(spr, getColumnIndex(spr, "CheckP4"), xRow)
            If getColumnIndex(spr, "CheckP5") > -1 Then z1310.CheckP5 = getDataM(spr, getColumnIndex(spr, "CheckP5"), xRow)
            If getColumnIndex(spr, "CheckP6") > -1 Then z1310.CheckP6 = getDataM(spr, getColumnIndex(spr, "CheckP6"), xRow)
            If getColumnIndex(spr, "CheckP7") > -1 Then z1310.CheckP7 = getDataM(spr, getColumnIndex(spr, "CheckP7"), xRow)
            If getColumnIndex(spr, "CheckP8") > -1 Then z1310.CheckP8 = getDataM(spr, getColumnIndex(spr, "CheckP8"), xRow)
            If getColumnIndex(spr, "CheckP9") > -1 Then z1310.CheckP9 = getDataM(spr, getColumnIndex(spr, "CheckP9"), xRow)
            If getColumnIndex(spr, "CheckUse1") > -1 Then z1310.CheckUse1 = getDataM(spr, getColumnIndex(spr, "CheckUse1"), xRow)
            If getColumnIndex(spr, "CheckMatching") > -1 Then z1310.CheckMatching = getDataM(spr, getColumnIndex(spr, "CheckMatching"), xRow)
            If getColumnIndex(spr, "Remark") > -1 Then z1310.Remark = getDataM(spr, getColumnIndex(spr, "Remark"), xRow)
            If getColumnIndex(spr, "MaterialCode_K3011") > -1 Then z1310.MaterialCode_K3011 = getDataM(spr, getColumnIndex(spr, "MaterialCode_K3011"), xRow)
            If getColumnIndex(spr, "seSite") > -1 Then z1310.seSite = getDataM(spr, getColumnIndex(spr, "seSite"), xRow)
            If getColumnIndex(spr, "cdSite") > -1 Then z1310.cdSite = getDataM(spr, getColumnIndex(spr, "cdSite"), xRow)
            If getColumnIndex(spr, "DateInsert") > -1 Then z1310.DateInsert = getDataM(spr, getColumnIndex(spr, "DateInsert"), xRow)
            If getColumnIndex(spr, "DateUpdate") > -1 Then z1310.DateUpdate = getDataM(spr, getColumnIndex(spr, "DateUpdate"), xRow)
            If getColumnIndex(spr, "InchargeInsert") > -1 Then z1310.InchargeInsert = getDataM(spr, getColumnIndex(spr, "InchargeInsert"), xRow)
            If getColumnIndex(spr, "InchargeUpdate") > -1 Then z1310.InchargeUpdate = getDataM(spr, getColumnIndex(spr, "InchargeUpdate"), xRow)
            If getColumnIndex(spr, "TimeInsert") > -1 Then z1310.TimeInsert = getDataM(spr, getColumnIndex(spr, "TimeInsert"), xRow)
            If getColumnIndex(spr, "TimeUpdate") > -1 Then z1310.TimeUpdate = getDataM(spr, getColumnIndex(spr, "TimeUpdate"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K1310_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K1310_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z1310 As T1310_AREA, CheckClear As Boolean, AUTOKEY As Double) As Boolean

        K1310_MOVE = False

        Try
            If READ_PFK1310(AUTOKEY) = True Then
                z1310 = D1310
                K1310_MOVE = True
            Else
                If CheckClear = True Then z1310 = Nothing
            End If

            If getColumnIndex(spr, "AutoKey") > -1 Then z1310.AutoKey = Cdecp(getDataM(spr, getColumnIndex(spr, "AutoKey"), xRow))
            If getColumnIndex(spr, "OrderNo") > -1 Then z1310.OrderNo = getDataM(spr, getColumnIndex(spr, "OrderNo"), xRow)
            If getColumnIndex(spr, "OrderNoSeq") > -1 Then z1310.OrderNoSeq = getDataM(spr, getColumnIndex(spr, "OrderNoSeq"), xRow)
            If getColumnIndex(spr, "GroupComponentBOM") > -1 Then z1310.GroupComponentBOM = getDataM(spr, getColumnIndex(spr, "GroupComponentBOM"), xRow)
            If getColumnIndex(spr, "GroupComponentSeq") > -1 Then z1310.GroupComponentSeq = Cdecp(getDataM(spr, getColumnIndex(spr, "GroupComponentSeq"), xRow))
            If getColumnIndex(spr, "Dseq") > -1 Then z1310.Dseq = Cdecp(getDataM(spr, getColumnIndex(spr, "Dseq"), xRow))
            If getColumnIndex(spr, "ProcessSeq") > -1 Then z1310.ProcessSeq = getDataM(spr, getColumnIndex(spr, "ProcessSeq"), xRow)
            If getColumnIndex(spr, "CustomerCode") > -1 Then z1310.CustomerCode = getDataM(spr, getColumnIndex(spr, "CustomerCode"), xRow)
            If getColumnIndex(spr, "selGroupComponent") > -1 Then z1310.selGroupComponent = getDataM(spr, getColumnIndex(spr, "selGroupComponent"), xRow)
            If getColumnIndex(spr, "cdGroupComponent") > -1 Then z1310.cdGroupComponent = getDataM(spr, getColumnIndex(spr, "cdGroupComponent"), xRow)
            If getColumnIndex(spr, "ComponentName") > -1 Then z1310.ComponentName = getDataM(spr, getColumnIndex(spr, "ComponentName"), xRow)
            If getColumnIndex(spr, "MaterialCode") > -1 Then z1310.MaterialCode = getDataM(spr, getColumnIndex(spr, "MaterialCode"), xRow)
            If getColumnIndex(spr, "seUnitMaterial") > -1 Then z1310.seUnitMaterial = getDataM(spr, getColumnIndex(spr, "seUnitMaterial"), xRow)
            If getColumnIndex(spr, "cdUnitMaterial") > -1 Then z1310.cdUnitMaterial = getDataM(spr, getColumnIndex(spr, "cdUnitMaterial"), xRow)
            If getColumnIndex(spr, "Specification") > -1 Then z1310.Specification = getDataM(spr, getColumnIndex(spr, "Specification"), xRow)
            If getColumnIndex(spr, "Width") > -1 Then z1310.Width = getDataM(spr, getColumnIndex(spr, "Width"), xRow)
            If getColumnIndex(spr, "WidthID") > -1 Then z1310.WidthID = getDataM(spr, getColumnIndex(spr, "WidthID"), xRow)
            If getColumnIndex(spr, "Height") > -1 Then z1310.Height = getDataM(spr, getColumnIndex(spr, "Height"), xRow)
            If getColumnIndex(spr, "SizeName") > -1 Then z1310.SizeName = getDataM(spr, getColumnIndex(spr, "SizeName"), xRow)
            If getColumnIndex(spr, "cdColorCode") > -1 Then z1310.cdColorCode = getDataM(spr, getColumnIndex(spr, "cdColorCode"), xRow)
            If getColumnIndex(spr, "ColorCode") > -1 Then z1310.ColorCode = getDataM(spr, getColumnIndex(spr, "ColorCode"), xRow)
            If getColumnIndex(spr, "ColorName") > -1 Then z1310.ColorName = getDataM(spr, getColumnIndex(spr, "ColorName"), xRow)
            If getColumnIndex(spr, "seShoesStatus") > -1 Then z1310.seShoesStatus = getDataM(spr, getColumnIndex(spr, "seShoesStatus"), xRow)
            If getColumnIndex(spr, "cdShoesStatus") > -1 Then z1310.cdShoesStatus = getDataM(spr, getColumnIndex(spr, "cdShoesStatus"), xRow)
            If getColumnIndex(spr, "seDepartment") > -1 Then z1310.seDepartment = getDataM(spr, getColumnIndex(spr, "seDepartment"), xRow)
            If getColumnIndex(spr, "cdDepartment") > -1 Then z1310.cdDepartment = getDataM(spr, getColumnIndex(spr, "cdDepartment"), xRow)
            If getColumnIndex(spr, "ContractID") > -1 Then z1310.ContractID = getDataM(spr, getColumnIndex(spr, "ContractID"), xRow)
            If getColumnIndex(spr, "ContracSeq") > -1 Then z1310.ContracSeq = Cdecp(getDataM(spr, getColumnIndex(spr, "ContracSeq"), xRow))
            If getColumnIndex(spr, "SupplierCode") > -1 Then z1310.SupplierCode = getDataM(spr, getColumnIndex(spr, "SupplierCode"), xRow)
            If getColumnIndex(spr, "PriceMaterial") > -1 Then z1310.PriceMaterial = Cdecp(getDataM(spr, getColumnIndex(spr, "PriceMaterial"), xRow))
            If getColumnIndex(spr, "ExchangeCost") > -1 Then z1310.ExchangeCost = Cdecp(getDataM(spr, getColumnIndex(spr, "ExchangeCost"), xRow))
            If getColumnIndex(spr, "ComplicationCost") > -1 Then z1310.ComplicationCost = Cdecp(getDataM(spr, getColumnIndex(spr, "ComplicationCost"), xRow))
            If getColumnIndex(spr, "AddedCost") > -1 Then z1310.AddedCost = Cdecp(getDataM(spr, getColumnIndex(spr, "AddedCost"), xRow))
            If getColumnIndex(spr, "ShippingRate") > -1 Then z1310.ShippingRate = Cdecp(getDataM(spr, getColumnIndex(spr, "ShippingRate"), xRow))
            If getColumnIndex(spr, "ShippingCost") > -1 Then z1310.ShippingCost = Cdecp(getDataM(spr, getColumnIndex(spr, "ShippingCost"), xRow))
            If getColumnIndex(spr, "PriceRnD") > -1 Then z1310.PriceRnD = Cdecp(getDataM(spr, getColumnIndex(spr, "PriceRnD"), xRow))
            If getColumnIndex(spr, "Price") > -1 Then z1310.Price = Cdecp(getDataM(spr, getColumnIndex(spr, "Price"), xRow))
            If getColumnIndex(spr, "seUnitPrice") > -1 Then z1310.seUnitPrice = getDataM(spr, getColumnIndex(spr, "seUnitPrice"), xRow)
            If getColumnIndex(spr, "cdUnitPrice") > -1 Then z1310.cdUnitPrice = getDataM(spr, getColumnIndex(spr, "cdUnitPrice"), xRow)
            If getColumnIndex(spr, "QtyComponent") > -1 Then z1310.QtyComponent = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyComponent"), xRow))
            If getColumnIndex(spr, "Consumption") > -1 Then z1310.Consumption = Cdecp(getDataM(spr, getColumnIndex(spr, "Consumption"), xRow))
            If getColumnIndex(spr, "Loss") > -1 Then z1310.Loss = Cdecp(getDataM(spr, getColumnIndex(spr, "Loss"), xRow))
            If getColumnIndex(spr, "GrossUsage") > -1 Then z1310.GrossUsage = Cdecp(getDataM(spr, getColumnIndex(spr, "GrossUsage"), xRow))
            If getColumnIndex(spr, "MaterialAMT") > -1 Then z1310.MaterialAMT = Cdecp(getDataM(spr, getColumnIndex(spr, "MaterialAMT"), xRow))
            If getColumnIndex(spr, "MaterialAMTPurchasing") > -1 Then z1310.MaterialAMTPurchasing = Cdecp(getDataM(spr, getColumnIndex(spr, "MaterialAMTPurchasing"), xRow))
            If getColumnIndex(spr, "MaterialAMTSales") > -1 Then z1310.MaterialAMTSales = Cdecp(getDataM(spr, getColumnIndex(spr, "MaterialAMTSales"), xRow))
            If getColumnIndex(spr, "seSubProcess") > -1 Then z1310.seSubProcess = getDataM(spr, getColumnIndex(spr, "seSubProcess"), xRow)
            If getColumnIndex(spr, "cdSubProcess") > -1 Then z1310.cdSubProcess = getDataM(spr, getColumnIndex(spr, "cdSubProcess"), xRow)
            If getColumnIndex(spr, "seSpecialProcess") > -1 Then z1310.seSpecialProcess = getDataM(spr, getColumnIndex(spr, "seSpecialProcess"), xRow)
            If getColumnIndex(spr, "cdSpecialProcess") > -1 Then z1310.cdSpecialProcess = getDataM(spr, getColumnIndex(spr, "cdSpecialProcess"), xRow)
            If getColumnIndex(spr, "CheckMark") > -1 Then z1310.CheckMark = getDataM(spr, getColumnIndex(spr, "CheckMark"), xRow)
            If getColumnIndex(spr, "CheckUse") > -1 Then z1310.CheckUse = getDataM(spr, getColumnIndex(spr, "CheckUse"), xRow)
            If getColumnIndex(spr, "CheckP1") > -1 Then z1310.CheckP1 = getDataM(spr, getColumnIndex(spr, "CheckP1"), xRow)
            If getColumnIndex(spr, "CheckP2") > -1 Then z1310.CheckP2 = getDataM(spr, getColumnIndex(spr, "CheckP2"), xRow)
            If getColumnIndex(spr, "CheckP3") > -1 Then z1310.CheckP3 = getDataM(spr, getColumnIndex(spr, "CheckP3"), xRow)
            If getColumnIndex(spr, "CheckP4") > -1 Then z1310.CheckP4 = getDataM(spr, getColumnIndex(spr, "CheckP4"), xRow)
            If getColumnIndex(spr, "CheckP5") > -1 Then z1310.CheckP5 = getDataM(spr, getColumnIndex(spr, "CheckP5"), xRow)
            If getColumnIndex(spr, "CheckP6") > -1 Then z1310.CheckP6 = getDataM(spr, getColumnIndex(spr, "CheckP6"), xRow)
            If getColumnIndex(spr, "CheckP7") > -1 Then z1310.CheckP7 = getDataM(spr, getColumnIndex(spr, "CheckP7"), xRow)
            If getColumnIndex(spr, "CheckP8") > -1 Then z1310.CheckP8 = getDataM(spr, getColumnIndex(spr, "CheckP8"), xRow)
            If getColumnIndex(spr, "CheckP9") > -1 Then z1310.CheckP9 = getDataM(spr, getColumnIndex(spr, "CheckP9"), xRow)
            If getColumnIndex(spr, "CheckUse1") > -1 Then z1310.CheckUse1 = getDataM(spr, getColumnIndex(spr, "CheckUse1"), xRow)
            If getColumnIndex(spr, "CheckMatching") > -1 Then z1310.CheckMatching = getDataM(spr, getColumnIndex(spr, "CheckMatching"), xRow)
            If getColumnIndex(spr, "Remark") > -1 Then z1310.Remark = getDataM(spr, getColumnIndex(spr, "Remark"), xRow)
            If getColumnIndex(spr, "MaterialCode_K3011") > -1 Then z1310.MaterialCode_K3011 = getDataM(spr, getColumnIndex(spr, "MaterialCode_K3011"), xRow)
            If getColumnIndex(spr, "seSite") > -1 Then z1310.seSite = getDataM(spr, getColumnIndex(spr, "seSite"), xRow)
            If getColumnIndex(spr, "cdSite") > -1 Then z1310.cdSite = getDataM(spr, getColumnIndex(spr, "cdSite"), xRow)
            If getColumnIndex(spr, "DateInsert") > -1 Then z1310.DateInsert = getDataM(spr, getColumnIndex(spr, "DateInsert"), xRow)
            If getColumnIndex(spr, "DateUpdate") > -1 Then z1310.DateUpdate = getDataM(spr, getColumnIndex(spr, "DateUpdate"), xRow)
            If getColumnIndex(spr, "InchargeInsert") > -1 Then z1310.InchargeInsert = getDataM(spr, getColumnIndex(spr, "InchargeInsert"), xRow)
            If getColumnIndex(spr, "InchargeUpdate") > -1 Then z1310.InchargeUpdate = getDataM(spr, getColumnIndex(spr, "InchargeUpdate"), xRow)
            If getColumnIndex(spr, "TimeInsert") > -1 Then z1310.TimeInsert = getDataM(spr, getColumnIndex(spr, "TimeInsert"), xRow)
            If getColumnIndex(spr, "TimeUpdate") > -1 Then z1310.TimeUpdate = getDataM(spr, getColumnIndex(spr, "TimeUpdate"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K1310_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K1310_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z1310 As T1310_AREA, Job As String, AUTOKEY As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K1310_MOVE = False

        Try
            If READ_PFK1310(AUTOKEY) = True Then
                z1310 = D1310
                K1310_MOVE = True
            Else
                z1310 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK1310")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "AUTOKEY" : z1310.AutoKey = Children(i).Code
                                Case "ORDERNO" : z1310.OrderNo = Children(i).Code
                                Case "ORDERNOSEQ" : z1310.OrderNoSeq = Children(i).Code
                                Case "GROUPCOMPONENTBOM" : z1310.GroupComponentBOM = Children(i).Code
                                Case "GROUPCOMPONENTSEQ" : z1310.GroupComponentSeq = Children(i).Code
                                Case "DSEQ" : z1310.Dseq = Children(i).Code
                                Case "PROCESSSEQ" : z1310.ProcessSeq = Children(i).Code
                                Case "CUSTOMERCODE" : z1310.CustomerCode = Children(i).Code
                                Case "SELGROUPCOMPONENT" : z1310.selGroupComponent = Children(i).Code
                                Case "CDGROUPCOMPONENT" : z1310.cdGroupComponent = Children(i).Code
                                Case "COMPONENTNAME" : z1310.ComponentName = Children(i).Code
                                Case "MATERIALCODE" : z1310.MaterialCode = Children(i).Code
                                Case "SEUNITMATERIAL" : z1310.seUnitMaterial = Children(i).Code
                                Case "CDUNITMATERIAL" : z1310.cdUnitMaterial = Children(i).Code
                                Case "SPECIFICATION" : z1310.Specification = Children(i).Code
                                Case "WIDTH" : z1310.Width = Children(i).Code
                                Case "WIDTHID" : z1310.WidthID = Children(i).Code
                                Case "HEIGHT" : z1310.Height = Children(i).Code
                                Case "SIZENAME" : z1310.SizeName = Children(i).Code
                                Case "CDCOLORCODE" : z1310.cdColorCode = Children(i).Code
                                Case "COLORCODE" : z1310.ColorCode = Children(i).Code
                                Case "COLORNAME" : z1310.ColorName = Children(i).Code
                                Case "SESHOESSTATUS" : z1310.seShoesStatus = Children(i).Code
                                Case "CDSHOESSTATUS" : z1310.cdShoesStatus = Children(i).Code
                                Case "SEDEPARTMENT" : z1310.seDepartment = Children(i).Code
                                Case "CDDEPARTMENT" : z1310.cdDepartment = Children(i).Code
                                Case "CONTRACTID" : z1310.ContractID = Children(i).Code
                                Case "CONTRACSEQ" : z1310.ContracSeq = Children(i).Code
                                Case "SUPPLIERCODE" : z1310.SupplierCode = Children(i).Code
                                Case "PRICEMATERIAL" : z1310.PriceMaterial = Children(i).Code
                                Case "EXCHANGECOST" : z1310.ExchangeCost = Children(i).Code
                                Case "COMPLICATIONCOST" : z1310.ComplicationCost = Children(i).Code
                                Case "ADDEDCOST" : z1310.AddedCost = Children(i).Code
                                Case "SHIPPINGRATE" : z1310.ShippingRate = Children(i).Code
                                Case "SHIPPINGCOST" : z1310.ShippingCost = Children(i).Code
                                Case "PRICERND" : z1310.PriceRnD = Children(i).Code
                                Case "PRICE" : z1310.Price = Children(i).Code
                                Case "SEUNITPRICE" : z1310.seUnitPrice = Children(i).Code
                                Case "CDUNITPRICE" : z1310.cdUnitPrice = Children(i).Code
                                Case "QTYCOMPONENT" : z1310.QtyComponent = Children(i).Code
                                Case "CONSUMPTION" : z1310.Consumption = Children(i).Code
                                Case "LOSS" : z1310.Loss = Children(i).Code
                                Case "GROSSUSAGE" : z1310.GrossUsage = Children(i).Code
                                Case "MATERIALAMT" : z1310.MaterialAMT = Children(i).Code
                                Case "MATERIALAMTPURCHASING" : z1310.MaterialAMTPurchasing = Children(i).Code
                                Case "MATERIALAMTSALES" : z1310.MaterialAMTSales = Children(i).Code
                                Case "SESUBPROCESS" : z1310.seSubProcess = Children(i).Code
                                Case "CDSUBPROCESS" : z1310.cdSubProcess = Children(i).Code
                                Case "SESPECIALPROCESS" : z1310.seSpecialProcess = Children(i).Code
                                Case "CDSPECIALPROCESS" : z1310.cdSpecialProcess = Children(i).Code
                                Case "CHECKMARK" : z1310.CheckMark = Children(i).Code
                                Case "CHECKUSE" : z1310.CheckUse = Children(i).Code
                                Case "CHECKP1" : z1310.CheckP1 = Children(i).Code
                                Case "CHECKP2" : z1310.CheckP2 = Children(i).Code
                                Case "CHECKP3" : z1310.CheckP3 = Children(i).Code
                                Case "CHECKP4" : z1310.CheckP4 = Children(i).Code
                                Case "CHECKP5" : z1310.CheckP5 = Children(i).Code
                                Case "CHECKP6" : z1310.CheckP6 = Children(i).Code
                                Case "CHECKP7" : z1310.CheckP7 = Children(i).Code
                                Case "CHECKP8" : z1310.CheckP8 = Children(i).Code
                                Case "CHECKP9" : z1310.CheckP9 = Children(i).Code
                                Case "CHECKUSE1" : z1310.CheckUse1 = Children(i).Code
                                Case "CHECKMATCHING" : z1310.CheckMatching = Children(i).Code
                                Case "REMARK" : z1310.Remark = Children(i).Code
                                Case "MATERIALCODE_K3011" : z1310.MaterialCode_K3011 = Children(i).Code
                                Case "SESITE" : z1310.seSite = Children(i).Code
                                Case "CDSITE" : z1310.cdSite = Children(i).Code
                                Case "DATEINSERT" : z1310.DateInsert = Children(i).Code
                                Case "DATEUPDATE" : z1310.DateUpdate = Children(i).Code
                                Case "INCHARGEINSERT" : z1310.InchargeInsert = Children(i).Code
                                Case "INCHARGEUPDATE" : z1310.InchargeUpdate = Children(i).Code
                                Case "TIMEINSERT" : z1310.TimeInsert = Children(i).Code
                                Case "TIMEUPDATE" : z1310.TimeUpdate = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "AUTOKEY" : z1310.AutoKey = Cdecp(Children(i).Data)
                                Case "ORDERNO" : z1310.OrderNo = Children(i).Data
                                Case "ORDERNOSEQ" : z1310.OrderNoSeq = Children(i).Data
                                Case "GROUPCOMPONENTBOM" : z1310.GroupComponentBOM = Children(i).Data
                                Case "GROUPCOMPONENTSEQ" : z1310.GroupComponentSeq = Cdecp(Children(i).Data)
                                Case "DSEQ" : z1310.Dseq = Cdecp(Children(i).Data)
                                Case "PROCESSSEQ" : z1310.ProcessSeq = Children(i).Data
                                Case "CUSTOMERCODE" : z1310.CustomerCode = Children(i).Data
                                Case "SELGROUPCOMPONENT" : z1310.selGroupComponent = Children(i).Data
                                Case "CDGROUPCOMPONENT" : z1310.cdGroupComponent = Children(i).Data
                                Case "COMPONENTNAME" : z1310.ComponentName = Children(i).Data
                                Case "MATERIALCODE" : z1310.MaterialCode = Children(i).Data
                                Case "SEUNITMATERIAL" : z1310.seUnitMaterial = Children(i).Data
                                Case "CDUNITMATERIAL" : z1310.cdUnitMaterial = Children(i).Data
                                Case "SPECIFICATION" : z1310.Specification = Children(i).Data
                                Case "WIDTH" : z1310.Width = Children(i).Data
                                Case "WIDTHID" : z1310.WidthID = Children(i).Data
                                Case "HEIGHT" : z1310.Height = Children(i).Data
                                Case "SIZENAME" : z1310.SizeName = Children(i).Data
                                Case "CDCOLORCODE" : z1310.cdColorCode = Children(i).Data
                                Case "COLORCODE" : z1310.ColorCode = Children(i).Data
                                Case "COLORNAME" : z1310.ColorName = Children(i).Data
                                Case "SESHOESSTATUS" : z1310.seShoesStatus = Children(i).Data
                                Case "CDSHOESSTATUS" : z1310.cdShoesStatus = Children(i).Data
                                Case "SEDEPARTMENT" : z1310.seDepartment = Children(i).Data
                                Case "CDDEPARTMENT" : z1310.cdDepartment = Children(i).Data
                                Case "CONTRACTID" : z1310.ContractID = Children(i).Data
                                Case "CONTRACSEQ" : z1310.ContracSeq = Cdecp(Children(i).Data)
                                Case "SUPPLIERCODE" : z1310.SupplierCode = Children(i).Data
                                Case "PRICEMATERIAL" : z1310.PriceMaterial = Cdecp(Children(i).Data)
                                Case "EXCHANGECOST" : z1310.ExchangeCost = Cdecp(Children(i).Data)
                                Case "COMPLICATIONCOST" : z1310.ComplicationCost = Cdecp(Children(i).Data)
                                Case "ADDEDCOST" : z1310.AddedCost = Cdecp(Children(i).Data)
                                Case "SHIPPINGRATE" : z1310.ShippingRate = Cdecp(Children(i).Data)
                                Case "SHIPPINGCOST" : z1310.ShippingCost = Cdecp(Children(i).Data)
                                Case "PRICERND" : z1310.PriceRnD = Cdecp(Children(i).Data)
                                Case "PRICE" : z1310.Price = Cdecp(Children(i).Data)
                                Case "SEUNITPRICE" : z1310.seUnitPrice = Children(i).Data
                                Case "CDUNITPRICE" : z1310.cdUnitPrice = Children(i).Data
                                Case "QTYCOMPONENT" : z1310.QtyComponent = Cdecp(Children(i).Data)
                                Case "CONSUMPTION" : z1310.Consumption = Cdecp(Children(i).Data)
                                Case "LOSS" : z1310.Loss = Cdecp(Children(i).Data)
                                Case "GROSSUSAGE" : z1310.GrossUsage = Cdecp(Children(i).Data)
                                Case "MATERIALAMT" : z1310.MaterialAMT = Cdecp(Children(i).Data)
                                Case "MATERIALAMTPURCHASING" : z1310.MaterialAMTPurchasing = Cdecp(Children(i).Data)
                                Case "MATERIALAMTSALES" : z1310.MaterialAMTSales = Cdecp(Children(i).Data)
                                Case "SESUBPROCESS" : z1310.seSubProcess = Children(i).Data
                                Case "CDSUBPROCESS" : z1310.cdSubProcess = Children(i).Data
                                Case "SESPECIALPROCESS" : z1310.seSpecialProcess = Children(i).Data
                                Case "CDSPECIALPROCESS" : z1310.cdSpecialProcess = Children(i).Data
                                Case "CHECKMARK" : z1310.CheckMark = Children(i).Data
                                Case "CHECKUSE" : z1310.CheckUse = Children(i).Data
                                Case "CHECKP1" : z1310.CheckP1 = Children(i).Data
                                Case "CHECKP2" : z1310.CheckP2 = Children(i).Data
                                Case "CHECKP3" : z1310.CheckP3 = Children(i).Data
                                Case "CHECKP4" : z1310.CheckP4 = Children(i).Data
                                Case "CHECKP5" : z1310.CheckP5 = Children(i).Data
                                Case "CHECKP6" : z1310.CheckP6 = Children(i).Data
                                Case "CHECKP7" : z1310.CheckP7 = Children(i).Data
                                Case "CHECKP8" : z1310.CheckP8 = Children(i).Data
                                Case "CHECKP9" : z1310.CheckP9 = Children(i).Data
                                Case "CHECKUSE1" : z1310.CheckUse1 = Children(i).Data
                                Case "CHECKMATCHING" : z1310.CheckMatching = Children(i).Data
                                Case "REMARK" : z1310.Remark = Children(i).Data
                                Case "MATERIALCODE_K3011" : z1310.MaterialCode_K3011 = Children(i).Data
                                Case "SESITE" : z1310.seSite = Children(i).Data
                                Case "CDSITE" : z1310.cdSite = Children(i).Data
                                Case "DATEINSERT" : z1310.DateInsert = Children(i).Data
                                Case "DATEUPDATE" : z1310.DateUpdate = Children(i).Data
                                Case "INCHARGEINSERT" : z1310.InchargeInsert = Children(i).Data
                                Case "INCHARGEUPDATE" : z1310.InchargeUpdate = Children(i).Data
                                Case "TIMEINSERT" : z1310.TimeInsert = Children(i).Data
                                Case "TIMEUPDATE" : z1310.TimeUpdate = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K1310_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K1310_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z1310 As T1310_AREA, Job As String, CheckClear As Boolean, AUTOKEY As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K1310_MOVE = False

        Try
            If READ_PFK1310(AUTOKEY) = True Then
                z1310 = D1310
                K1310_MOVE = True
            Else
                If CheckClear = True Then z1310 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK1310")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "AUTOKEY" : z1310.AutoKey = Children(i).Code
                                Case "ORDERNO" : z1310.OrderNo = Children(i).Code
                                Case "ORDERNOSEQ" : z1310.OrderNoSeq = Children(i).Code
                                Case "GROUPCOMPONENTBOM" : z1310.GroupComponentBOM = Children(i).Code
                                Case "GROUPCOMPONENTSEQ" : z1310.GroupComponentSeq = Children(i).Code
                                Case "DSEQ" : z1310.Dseq = Children(i).Code
                                Case "PROCESSSEQ" : z1310.ProcessSeq = Children(i).Code
                                Case "CUSTOMERCODE" : z1310.CustomerCode = Children(i).Code
                                Case "SELGROUPCOMPONENT" : z1310.selGroupComponent = Children(i).Code
                                Case "CDGROUPCOMPONENT" : z1310.cdGroupComponent = Children(i).Code
                                Case "COMPONENTNAME" : z1310.ComponentName = Children(i).Code
                                Case "MATERIALCODE" : z1310.MaterialCode = Children(i).Code
                                Case "SEUNITMATERIAL" : z1310.seUnitMaterial = Children(i).Code
                                Case "CDUNITMATERIAL" : z1310.cdUnitMaterial = Children(i).Code
                                Case "SPECIFICATION" : z1310.Specification = Children(i).Code
                                Case "WIDTH" : z1310.Width = Children(i).Code
                                Case "WIDTHID" : z1310.WidthID = Children(i).Code
                                Case "HEIGHT" : z1310.Height = Children(i).Code
                                Case "SIZENAME" : z1310.SizeName = Children(i).Code
                                Case "CDCOLORCODE" : z1310.cdColorCode = Children(i).Code
                                Case "COLORCODE" : z1310.ColorCode = Children(i).Code
                                Case "COLORNAME" : z1310.ColorName = Children(i).Code
                                Case "SESHOESSTATUS" : z1310.seShoesStatus = Children(i).Code
                                Case "CDSHOESSTATUS" : z1310.cdShoesStatus = Children(i).Code
                                Case "SEDEPARTMENT" : z1310.seDepartment = Children(i).Code
                                Case "CDDEPARTMENT" : z1310.cdDepartment = Children(i).Code
                                Case "CONTRACTID" : z1310.ContractID = Children(i).Code
                                Case "CONTRACSEQ" : z1310.ContracSeq = Children(i).Code
                                Case "SUPPLIERCODE" : z1310.SupplierCode = Children(i).Code
                                Case "PRICEMATERIAL" : z1310.PriceMaterial = Children(i).Code
                                Case "EXCHANGECOST" : z1310.ExchangeCost = Children(i).Code
                                Case "COMPLICATIONCOST" : z1310.ComplicationCost = Children(i).Code
                                Case "ADDEDCOST" : z1310.AddedCost = Children(i).Code
                                Case "SHIPPINGRATE" : z1310.ShippingRate = Children(i).Code
                                Case "SHIPPINGCOST" : z1310.ShippingCost = Children(i).Code
                                Case "PRICERND" : z1310.PriceRnD = Children(i).Code
                                Case "PRICE" : z1310.Price = Children(i).Code
                                Case "SEUNITPRICE" : z1310.seUnitPrice = Children(i).Code
                                Case "CDUNITPRICE" : z1310.cdUnitPrice = Children(i).Code
                                Case "QTYCOMPONENT" : z1310.QtyComponent = Children(i).Code
                                Case "CONSUMPTION" : z1310.Consumption = Children(i).Code
                                Case "LOSS" : z1310.Loss = Children(i).Code
                                Case "GROSSUSAGE" : z1310.GrossUsage = Children(i).Code
                                Case "MATERIALAMT" : z1310.MaterialAMT = Children(i).Code
                                Case "MATERIALAMTPURCHASING" : z1310.MaterialAMTPurchasing = Children(i).Code
                                Case "MATERIALAMTSALES" : z1310.MaterialAMTSales = Children(i).Code
                                Case "SESUBPROCESS" : z1310.seSubProcess = Children(i).Code
                                Case "CDSUBPROCESS" : z1310.cdSubProcess = Children(i).Code
                                Case "SESPECIALPROCESS" : z1310.seSpecialProcess = Children(i).Code
                                Case "CDSPECIALPROCESS" : z1310.cdSpecialProcess = Children(i).Code
                                Case "CHECKMARK" : z1310.CheckMark = Children(i).Code
                                Case "CHECKUSE" : z1310.CheckUse = Children(i).Code
                                Case "CHECKP1" : z1310.CheckP1 = Children(i).Code
                                Case "CHECKP2" : z1310.CheckP2 = Children(i).Code
                                Case "CHECKP3" : z1310.CheckP3 = Children(i).Code
                                Case "CHECKP4" : z1310.CheckP4 = Children(i).Code
                                Case "CHECKP5" : z1310.CheckP5 = Children(i).Code
                                Case "CHECKP6" : z1310.CheckP6 = Children(i).Code
                                Case "CHECKP7" : z1310.CheckP7 = Children(i).Code
                                Case "CHECKP8" : z1310.CheckP8 = Children(i).Code
                                Case "CHECKP9" : z1310.CheckP9 = Children(i).Code
                                Case "CHECKUSE1" : z1310.CheckUse1 = Children(i).Code
                                Case "CHECKMATCHING" : z1310.CheckMatching = Children(i).Code
                                Case "REMARK" : z1310.Remark = Children(i).Code
                                Case "MATERIALCODE_K3011" : z1310.MaterialCode_K3011 = Children(i).Code
                                Case "SESITE" : z1310.seSite = Children(i).Code
                                Case "CDSITE" : z1310.cdSite = Children(i).Code
                                Case "DATEINSERT" : z1310.DateInsert = Children(i).Code
                                Case "DATEUPDATE" : z1310.DateUpdate = Children(i).Code
                                Case "INCHARGEINSERT" : z1310.InchargeInsert = Children(i).Code
                                Case "INCHARGEUPDATE" : z1310.InchargeUpdate = Children(i).Code
                                Case "TIMEINSERT" : z1310.TimeInsert = Children(i).Code
                                Case "TIMEUPDATE" : z1310.TimeUpdate = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "AUTOKEY" : z1310.AutoKey = Cdecp(Children(i).Data)
                                Case "ORDERNO" : z1310.OrderNo = Children(i).Data
                                Case "ORDERNOSEQ" : z1310.OrderNoSeq = Children(i).Data
                                Case "GROUPCOMPONENTBOM" : z1310.GroupComponentBOM = Children(i).Data
                                Case "GROUPCOMPONENTSEQ" : z1310.GroupComponentSeq = Cdecp(Children(i).Data)
                                Case "DSEQ" : z1310.Dseq = Cdecp(Children(i).Data)
                                Case "PROCESSSEQ" : z1310.ProcessSeq = Children(i).Data
                                Case "CUSTOMERCODE" : z1310.CustomerCode = Children(i).Data
                                Case "SELGROUPCOMPONENT" : z1310.selGroupComponent = Children(i).Data
                                Case "CDGROUPCOMPONENT" : z1310.cdGroupComponent = Children(i).Data
                                Case "COMPONENTNAME" : z1310.ComponentName = Children(i).Data
                                Case "MATERIALCODE" : z1310.MaterialCode = Children(i).Data
                                Case "SEUNITMATERIAL" : z1310.seUnitMaterial = Children(i).Data
                                Case "CDUNITMATERIAL" : z1310.cdUnitMaterial = Children(i).Data
                                Case "SPECIFICATION" : z1310.Specification = Children(i).Data
                                Case "WIDTH" : z1310.Width = Children(i).Data
                                Case "WIDTHID" : z1310.WidthID = Children(i).Data
                                Case "HEIGHT" : z1310.Height = Children(i).Data
                                Case "SIZENAME" : z1310.SizeName = Children(i).Data
                                Case "CDCOLORCODE" : z1310.cdColorCode = Children(i).Data
                                Case "COLORCODE" : z1310.ColorCode = Children(i).Data
                                Case "COLORNAME" : z1310.ColorName = Children(i).Data
                                Case "SESHOESSTATUS" : z1310.seShoesStatus = Children(i).Data
                                Case "CDSHOESSTATUS" : z1310.cdShoesStatus = Children(i).Data
                                Case "SEDEPARTMENT" : z1310.seDepartment = Children(i).Data
                                Case "CDDEPARTMENT" : z1310.cdDepartment = Children(i).Data
                                Case "CONTRACTID" : z1310.ContractID = Children(i).Data
                                Case "CONTRACSEQ" : z1310.ContracSeq = Cdecp(Children(i).Data)
                                Case "SUPPLIERCODE" : z1310.SupplierCode = Children(i).Data
                                Case "PRICEMATERIAL" : z1310.PriceMaterial = Cdecp(Children(i).Data)
                                Case "EXCHANGECOST" : z1310.ExchangeCost = Cdecp(Children(i).Data)
                                Case "COMPLICATIONCOST" : z1310.ComplicationCost = Cdecp(Children(i).Data)
                                Case "ADDEDCOST" : z1310.AddedCost = Cdecp(Children(i).Data)
                                Case "SHIPPINGRATE" : z1310.ShippingRate = Cdecp(Children(i).Data)
                                Case "SHIPPINGCOST" : z1310.ShippingCost = Cdecp(Children(i).Data)
                                Case "PRICERND" : z1310.PriceRnD = Cdecp(Children(i).Data)
                                Case "PRICE" : z1310.Price = Cdecp(Children(i).Data)
                                Case "SEUNITPRICE" : z1310.seUnitPrice = Children(i).Data
                                Case "CDUNITPRICE" : z1310.cdUnitPrice = Children(i).Data
                                Case "QTYCOMPONENT" : z1310.QtyComponent = Cdecp(Children(i).Data)
                                Case "CONSUMPTION" : z1310.Consumption = Cdecp(Children(i).Data)
                                Case "LOSS" : z1310.Loss = Cdecp(Children(i).Data)
                                Case "GROSSUSAGE" : z1310.GrossUsage = Cdecp(Children(i).Data)
                                Case "MATERIALAMT" : z1310.MaterialAMT = Cdecp(Children(i).Data)
                                Case "MATERIALAMTPURCHASING" : z1310.MaterialAMTPurchasing = Cdecp(Children(i).Data)
                                Case "MATERIALAMTSALES" : z1310.MaterialAMTSales = Cdecp(Children(i).Data)
                                Case "SESUBPROCESS" : z1310.seSubProcess = Children(i).Data
                                Case "CDSUBPROCESS" : z1310.cdSubProcess = Children(i).Data
                                Case "SESPECIALPROCESS" : z1310.seSpecialProcess = Children(i).Data
                                Case "CDSPECIALPROCESS" : z1310.cdSpecialProcess = Children(i).Data
                                Case "CHECKMARK" : z1310.CheckMark = Children(i).Data
                                Case "CHECKUSE" : z1310.CheckUse = Children(i).Data
                                Case "CHECKP1" : z1310.CheckP1 = Children(i).Data
                                Case "CHECKP2" : z1310.CheckP2 = Children(i).Data
                                Case "CHECKP3" : z1310.CheckP3 = Children(i).Data
                                Case "CHECKP4" : z1310.CheckP4 = Children(i).Data
                                Case "CHECKP5" : z1310.CheckP5 = Children(i).Data
                                Case "CHECKP6" : z1310.CheckP6 = Children(i).Data
                                Case "CHECKP7" : z1310.CheckP7 = Children(i).Data
                                Case "CHECKP8" : z1310.CheckP8 = Children(i).Data
                                Case "CHECKP9" : z1310.CheckP9 = Children(i).Data
                                Case "CHECKUSE1" : z1310.CheckUse1 = Children(i).Data
                                Case "CHECKMATCHING" : z1310.CheckMatching = Children(i).Data
                                Case "REMARK" : z1310.Remark = Children(i).Data
                                Case "MATERIALCODE_K3011" : z1310.MaterialCode_K3011 = Children(i).Data
                                Case "SESITE" : z1310.seSite = Children(i).Data
                                Case "CDSITE" : z1310.cdSite = Children(i).Data
                                Case "DATEINSERT" : z1310.DateInsert = Children(i).Data
                                Case "DATEUPDATE" : z1310.DateUpdate = Children(i).Data
                                Case "INCHARGEINSERT" : z1310.InchargeInsert = Children(i).Data
                                Case "INCHARGEUPDATE" : z1310.InchargeUpdate = Children(i).Data
                                Case "TIMEINSERT" : z1310.TimeInsert = Children(i).Data
                                Case "TIMEUPDATE" : z1310.TimeUpdate = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K1310_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW AREA
    '=========================================================================================================================================================
    Public Sub K1310_MOVE(ByRef a1310 As T1310_AREA, ByRef b1310 As T1310_AREA)
        Try
            If trim$(a1310.AutoKey) = "" Then b1310.AutoKey = "" Else b1310.AutoKey = a1310.AutoKey
            If trim$(a1310.OrderNo) = "" Then b1310.OrderNo = "" Else b1310.OrderNo = a1310.OrderNo
            If trim$(a1310.OrderNoSeq) = "" Then b1310.OrderNoSeq = "" Else b1310.OrderNoSeq = a1310.OrderNoSeq
            If trim$(a1310.GroupComponentBOM) = "" Then b1310.GroupComponentBOM = "" Else b1310.GroupComponentBOM = a1310.GroupComponentBOM
            If trim$(a1310.GroupComponentSeq) = "" Then b1310.GroupComponentSeq = "" Else b1310.GroupComponentSeq = a1310.GroupComponentSeq
            If trim$(a1310.Dseq) = "" Then b1310.Dseq = "" Else b1310.Dseq = a1310.Dseq
            If trim$(a1310.ProcessSeq) = "" Then b1310.ProcessSeq = "" Else b1310.ProcessSeq = a1310.ProcessSeq
            If trim$(a1310.CustomerCode) = "" Then b1310.CustomerCode = "" Else b1310.CustomerCode = a1310.CustomerCode
            If trim$(a1310.selGroupComponent) = "" Then b1310.selGroupComponent = "" Else b1310.selGroupComponent = a1310.selGroupComponent
            If trim$(a1310.cdGroupComponent) = "" Then b1310.cdGroupComponent = "" Else b1310.cdGroupComponent = a1310.cdGroupComponent
            If trim$(a1310.ComponentName) = "" Then b1310.ComponentName = "" Else b1310.ComponentName = a1310.ComponentName
            If trim$(a1310.MaterialCode) = "" Then b1310.MaterialCode = "" Else b1310.MaterialCode = a1310.MaterialCode
            If trim$(a1310.seUnitMaterial) = "" Then b1310.seUnitMaterial = "" Else b1310.seUnitMaterial = a1310.seUnitMaterial
            If trim$(a1310.cdUnitMaterial) = "" Then b1310.cdUnitMaterial = "" Else b1310.cdUnitMaterial = a1310.cdUnitMaterial
            If trim$(a1310.Specification) = "" Then b1310.Specification = "" Else b1310.Specification = a1310.Specification
            If trim$(a1310.Width) = "" Then b1310.Width = "" Else b1310.Width = a1310.Width
            If trim$(a1310.WidthID) = "" Then b1310.WidthID = "" Else b1310.WidthID = a1310.WidthID
            If trim$(a1310.Height) = "" Then b1310.Height = "" Else b1310.Height = a1310.Height
            If trim$(a1310.SizeName) = "" Then b1310.SizeName = "" Else b1310.SizeName = a1310.SizeName
            If trim$(a1310.cdColorCode) = "" Then b1310.cdColorCode = "" Else b1310.cdColorCode = a1310.cdColorCode
            If trim$(a1310.ColorCode) = "" Then b1310.ColorCode = "" Else b1310.ColorCode = a1310.ColorCode
            If trim$(a1310.ColorName) = "" Then b1310.ColorName = "" Else b1310.ColorName = a1310.ColorName
            If trim$(a1310.seShoesStatus) = "" Then b1310.seShoesStatus = "" Else b1310.seShoesStatus = a1310.seShoesStatus
            If trim$(a1310.cdShoesStatus) = "" Then b1310.cdShoesStatus = "" Else b1310.cdShoesStatus = a1310.cdShoesStatus
            If trim$(a1310.seDepartment) = "" Then b1310.seDepartment = "" Else b1310.seDepartment = a1310.seDepartment
            If trim$(a1310.cdDepartment) = "" Then b1310.cdDepartment = "" Else b1310.cdDepartment = a1310.cdDepartment
            If trim$(a1310.ContractID) = "" Then b1310.ContractID = "" Else b1310.ContractID = a1310.ContractID
            If trim$(a1310.ContracSeq) = "" Then b1310.ContracSeq = "" Else b1310.ContracSeq = a1310.ContracSeq
            If trim$(a1310.SupplierCode) = "" Then b1310.SupplierCode = "" Else b1310.SupplierCode = a1310.SupplierCode
            If trim$(a1310.PriceMaterial) = "" Then b1310.PriceMaterial = "" Else b1310.PriceMaterial = a1310.PriceMaterial
            If trim$(a1310.ExchangeCost) = "" Then b1310.ExchangeCost = "" Else b1310.ExchangeCost = a1310.ExchangeCost
            If trim$(a1310.ComplicationCost) = "" Then b1310.ComplicationCost = "" Else b1310.ComplicationCost = a1310.ComplicationCost
            If trim$(a1310.AddedCost) = "" Then b1310.AddedCost = "" Else b1310.AddedCost = a1310.AddedCost
            If trim$(a1310.ShippingRate) = "" Then b1310.ShippingRate = "" Else b1310.ShippingRate = a1310.ShippingRate
            If trim$(a1310.ShippingCost) = "" Then b1310.ShippingCost = "" Else b1310.ShippingCost = a1310.ShippingCost
            If trim$(a1310.PriceRnD) = "" Then b1310.PriceRnD = "" Else b1310.PriceRnD = a1310.PriceRnD
            If trim$(a1310.Price) = "" Then b1310.Price = "" Else b1310.Price = a1310.Price
            If trim$(a1310.seUnitPrice) = "" Then b1310.seUnitPrice = "" Else b1310.seUnitPrice = a1310.seUnitPrice
            If trim$(a1310.cdUnitPrice) = "" Then b1310.cdUnitPrice = "" Else b1310.cdUnitPrice = a1310.cdUnitPrice
            If trim$(a1310.QtyComponent) = "" Then b1310.QtyComponent = "" Else b1310.QtyComponent = a1310.QtyComponent
            If trim$(a1310.Consumption) = "" Then b1310.Consumption = "" Else b1310.Consumption = a1310.Consumption
            If trim$(a1310.Loss) = "" Then b1310.Loss = "" Else b1310.Loss = a1310.Loss
            If trim$(a1310.GrossUsage) = "" Then b1310.GrossUsage = "" Else b1310.GrossUsage = a1310.GrossUsage
            If trim$(a1310.MaterialAMT) = "" Then b1310.MaterialAMT = "" Else b1310.MaterialAMT = a1310.MaterialAMT
            If trim$(a1310.MaterialAMTPurchasing) = "" Then b1310.MaterialAMTPurchasing = "" Else b1310.MaterialAMTPurchasing = a1310.MaterialAMTPurchasing
            If trim$(a1310.MaterialAMTSales) = "" Then b1310.MaterialAMTSales = "" Else b1310.MaterialAMTSales = a1310.MaterialAMTSales
            If trim$(a1310.seSubProcess) = "" Then b1310.seSubProcess = "" Else b1310.seSubProcess = a1310.seSubProcess
            If trim$(a1310.cdSubProcess) = "" Then b1310.cdSubProcess = "" Else b1310.cdSubProcess = a1310.cdSubProcess
            If trim$(a1310.seSpecialProcess) = "" Then b1310.seSpecialProcess = "" Else b1310.seSpecialProcess = a1310.seSpecialProcess
            If trim$(a1310.cdSpecialProcess) = "" Then b1310.cdSpecialProcess = "" Else b1310.cdSpecialProcess = a1310.cdSpecialProcess
            If trim$(a1310.CheckMark) = "" Then b1310.CheckMark = "" Else b1310.CheckMark = a1310.CheckMark
            If trim$(a1310.CheckUse) = "" Then b1310.CheckUse = "" Else b1310.CheckUse = a1310.CheckUse
            If trim$(a1310.CheckP1) = "" Then b1310.CheckP1 = "" Else b1310.CheckP1 = a1310.CheckP1
            If trim$(a1310.CheckP2) = "" Then b1310.CheckP2 = "" Else b1310.CheckP2 = a1310.CheckP2
            If trim$(a1310.CheckP3) = "" Then b1310.CheckP3 = "" Else b1310.CheckP3 = a1310.CheckP3
            If trim$(a1310.CheckP4) = "" Then b1310.CheckP4 = "" Else b1310.CheckP4 = a1310.CheckP4
            If trim$(a1310.CheckP5) = "" Then b1310.CheckP5 = "" Else b1310.CheckP5 = a1310.CheckP5
            If trim$(a1310.CheckP6) = "" Then b1310.CheckP6 = "" Else b1310.CheckP6 = a1310.CheckP6
            If trim$(a1310.CheckP7) = "" Then b1310.CheckP7 = "" Else b1310.CheckP7 = a1310.CheckP7
            If trim$(a1310.CheckP8) = "" Then b1310.CheckP8 = "" Else b1310.CheckP8 = a1310.CheckP8
            If trim$(a1310.CheckP9) = "" Then b1310.CheckP9 = "" Else b1310.CheckP9 = a1310.CheckP9
            If trim$(a1310.CheckUse1) = "" Then b1310.CheckUse1 = "" Else b1310.CheckUse1 = a1310.CheckUse1
            If trim$(a1310.CheckMatching) = "" Then b1310.CheckMatching = "" Else b1310.CheckMatching = a1310.CheckMatching
            If trim$(a1310.Remark) = "" Then b1310.Remark = "" Else b1310.Remark = a1310.Remark
            If trim$(a1310.MaterialCode_K3011) = "" Then b1310.MaterialCode_K3011 = "" Else b1310.MaterialCode_K3011 = a1310.MaterialCode_K3011
            If trim$(a1310.seSite) = "" Then b1310.seSite = "" Else b1310.seSite = a1310.seSite
            If trim$(a1310.cdSite) = "" Then b1310.cdSite = "" Else b1310.cdSite = a1310.cdSite
            If trim$(a1310.DateInsert) = "" Then b1310.DateInsert = "" Else b1310.DateInsert = a1310.DateInsert
            If trim$(a1310.DateUpdate) = "" Then b1310.DateUpdate = "" Else b1310.DateUpdate = a1310.DateUpdate
            If trim$(a1310.InchargeInsert) = "" Then b1310.InchargeInsert = "" Else b1310.InchargeInsert = a1310.InchargeInsert
            If trim$(a1310.InchargeUpdate) = "" Then b1310.InchargeUpdate = "" Else b1310.InchargeUpdate = a1310.InchargeUpdate
            If trim$(a1310.TimeInsert) = "" Then b1310.TimeInsert = "" Else b1310.TimeInsert = a1310.TimeInsert
            If trim$(a1310.TimeUpdate) = "" Then b1310.TimeUpdate = "" Else b1310.TimeUpdate = a1310.TimeUpdate
        Catch ex As Exception
            Call MsgBoxP("K1310_MOVE", vbCritical)
        End Try
    End Sub


End Module
