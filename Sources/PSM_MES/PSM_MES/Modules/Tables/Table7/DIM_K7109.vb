'=========================================================================================================================================================
'   TABLE : (PFK7109)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7109

Structure T7109_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	GroupComponentBOM	 AS String	'			char(6)		*
Public 	GroupComponentSeq	 AS Double	'			decimal		*
Public 	Dseq	 AS Double	'			decimal
Public 	ProcessSeq	 AS String	'			nvarchar(10)
Public 	CustomerCode	 AS String	'			char(6)
Public 	selGroupComponent	 AS String	'			char(3)
Public 	cdGroupComponent	 AS String	'			char(3)
Public 	ComponentName	 AS String	'			nvarchar(100)
Public 	MaterialCode	 AS String	'			char(6)
Public 	seUnitMaterial	 AS String	'			char(3)
Public 	cdUnitMaterial	 AS String	'			char(3)
Public 	Specification	 AS String	'			nvarchar(200)
Public 	Width	 AS String	'			nvarchar(20)
Public 	WidthID	 AS String	'			nvarchar(20)
Public 	Height	 AS String	'			nvarchar(20)
Public 	SizeName	 AS String	'			nvarchar(20)
Public 	cdColorCode	 AS String	'			char(3)
Public 	ColorCode	 AS String	'			char(6)
Public 	ColorName	 AS String	'			nvarchar(200)
Public 	seShoesStatus	 AS String	'			char(3)
Public 	cdShoesStatus	 AS String	'			char(3)
Public 	seDepartment	 AS String	'			char(3)
Public 	cdDepartment	 AS String	'			char(3)
Public 	ContractID	 AS String	'			char(6)
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

    Public D7109 As T7109_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK7109(GROUPCOMPONENTBOM As String, GROUPCOMPONENTSEQ As Double) As Boolean
        READ_PFK7109 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7109 "
            SQL = SQL & " WHERE K7109_GroupComponentBOM		 = '" & GroupComponentBOM & "' "
            SQL = SQL & "   AND K7109_GroupComponentSeq		 =  " & GroupComponentSeq & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7109_CLEAR() : GoTo SKIP_READ_PFK7109

            Call K7109_MOVE(rd)
            READ_PFK7109 = True

SKIP_READ_PFK7109:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7109", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK7109(GROUPCOMPONENTBOM As String, GROUPCOMPONENTSEQ As Double, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7109 "
            SQL = SQL & " WHERE K7109_GroupComponentBOM		 = '" & GroupComponentBOM & "' "
            SQL = SQL & "   AND K7109_GroupComponentSeq		 =  " & GroupComponentSeq & "  "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK7109", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK7109(z7109 As T7109_AREA) As Boolean
        WRITE_PFK7109 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z7109)

            SQL = " INSERT INTO PFK7109 "
            SQL = SQL & " ( "
            SQL = SQL & " K7109_GroupComponentBOM,"
            SQL = SQL & " K7109_GroupComponentSeq,"
            SQL = SQL & " K7109_Dseq,"
            SQL = SQL & " K7109_ProcessSeq,"
            SQL = SQL & " K7109_CustomerCode,"
            SQL = SQL & " K7109_selGroupComponent,"
            SQL = SQL & " K7109_cdGroupComponent,"
            SQL = SQL & " K7109_ComponentName,"
            SQL = SQL & " K7109_MaterialCode,"
            SQL = SQL & " K7109_seUnitMaterial,"
            SQL = SQL & " K7109_cdUnitMaterial,"
            SQL = SQL & " K7109_Specification,"
            SQL = SQL & " K7109_Width,"
            SQL = SQL & " K7109_WidthID,"
            SQL = SQL & " K7109_Height,"
            SQL = SQL & " K7109_SizeName,"
            SQL = SQL & " K7109_cdColorCode,"
            SQL = SQL & " K7109_ColorCode,"
            SQL = SQL & " K7109_ColorName,"
            SQL = SQL & " K7109_seShoesStatus,"
            SQL = SQL & " K7109_cdShoesStatus,"
            SQL = SQL & " K7109_seDepartment,"
            SQL = SQL & " K7109_cdDepartment,"
            SQL = SQL & " K7109_ContractID,"
            SQL = SQL & " K7109_ContracSeq,"
            SQL = SQL & " K7109_SupplierCode,"
            SQL = SQL & " K7109_PriceMaterial,"
            SQL = SQL & " K7109_ExchangeCost,"
            SQL = SQL & " K7109_ComplicationCost,"
            SQL = SQL & " K7109_AddedCost,"
            SQL = SQL & " K7109_ShippingRate,"
            SQL = SQL & " K7109_ShippingCost,"
            SQL = SQL & " K7109_PriceRnD,"
            SQL = SQL & " K7109_Price,"
            SQL = SQL & " K7109_seUnitPrice,"
            SQL = SQL & " K7109_cdUnitPrice,"
            SQL = SQL & " K7109_QtyComponent,"
            SQL = SQL & " K7109_Consumption,"
            SQL = SQL & " K7109_Loss,"
            SQL = SQL & " K7109_GrossUsage,"
            SQL = SQL & " K7109_MaterialAMT,"
            SQL = SQL & " K7109_MaterialAMTPurchasing,"
            SQL = SQL & " K7109_MaterialAMTSales,"
            SQL = SQL & " K7109_seSubProcess,"
            SQL = SQL & " K7109_cdSubProcess,"
            SQL = SQL & " K7109_seSpecialProcess,"
            SQL = SQL & " K7109_cdSpecialProcess,"
            SQL = SQL & " K7109_CheckMark,"
            SQL = SQL & " K7109_CheckUse,"
            SQL = SQL & " K7109_CheckP1,"
            SQL = SQL & " K7109_CheckP2,"
            SQL = SQL & " K7109_CheckP3,"
            SQL = SQL & " K7109_CheckP4,"
            SQL = SQL & " K7109_CheckP5,"
            SQL = SQL & " K7109_CheckP6,"
            SQL = SQL & " K7109_CheckP7,"
            SQL = SQL & " K7109_CheckP8,"
            SQL = SQL & " K7109_CheckP9,"
            SQL = SQL & " K7109_CheckUse1,"
            SQL = SQL & " K7109_CheckMatching,"
            SQL = SQL & " K7109_Remark,"
            SQL = SQL & " K7109_MaterialCode_K3011,"

            SQL = SQL & " K7109_DateInsert,"
            SQL = SQL & " K7109_InchargeInsert,"

            SQL = SQL & " K7109_seSite,"
            SQL = SQL & " K7109_cdSite "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z7109.GroupComponentBOM) & "', "
            SQL = SQL & "   " & FormatSQL(z7109.GroupComponentSeq) & ", "
            SQL = SQL & "   " & FormatSQL(z7109.Dseq) & ", "
            SQL = SQL & "  N'" & FormatSQL(z7109.ProcessSeq) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7109.CustomerCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7109.selGroupComponent) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7109.cdGroupComponent) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7109.ComponentName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7109.MaterialCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7109.seUnitMaterial) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7109.cdUnitMaterial) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7109.Specification) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7109.Width) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7109.WidthID) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7109.Height) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7109.SizeName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7109.cdColorCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7109.ColorCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7109.ColorName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7109.seShoesStatus) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7109.cdShoesStatus) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7109.seDepartment) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7109.cdDepartment) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7109.ContractID) & "', "
            SQL = SQL & "   " & FormatSQL(z7109.ContracSeq) & ", "
            SQL = SQL & "  N'" & FormatSQL(z7109.SupplierCode) & "', "
            SQL = SQL & "   " & FormatSQL(z7109.PriceMaterial) & ", "
            SQL = SQL & "   " & FormatSQL(z7109.ExchangeCost) & ", "
            SQL = SQL & "   " & FormatSQL(z7109.ComplicationCost) & ", "
            SQL = SQL & "   " & FormatSQL(z7109.AddedCost) & ", "
            SQL = SQL & "   " & FormatSQL(z7109.ShippingRate) & ", "
            SQL = SQL & "   " & FormatSQL(z7109.ShippingCost) & ", "
            SQL = SQL & "   " & FormatSQL(z7109.PriceRnD) & ", "
            SQL = SQL & "   " & FormatSQL(z7109.Price) & ", "
            SQL = SQL & "  N'" & FormatSQL(z7109.seUnitPrice) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7109.cdUnitPrice) & "', "
            SQL = SQL & "   " & FormatSQL(z7109.QtyComponent) & ", "
            SQL = SQL & "   " & FormatSQL(z7109.Consumption) & ", "
            SQL = SQL & "   " & FormatSQL(z7109.Loss) & ", "
            SQL = SQL & "   " & FormatSQL(z7109.GrossUsage) & ", "
            SQL = SQL & "   " & FormatSQL(z7109.MaterialAMT) & ", "
            SQL = SQL & "   " & FormatSQL(z7109.MaterialAMTPurchasing) & ", "
            SQL = SQL & "   " & FormatSQL(z7109.MaterialAMTSales) & ", "
            SQL = SQL & "  N'" & FormatSQL(z7109.seSubProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7109.cdSubProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7109.seSpecialProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7109.cdSpecialProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7109.CheckMark) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7109.CheckUse) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7109.CheckP1) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7109.CheckP2) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7109.CheckP3) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7109.CheckP4) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7109.CheckP5) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7109.CheckP6) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7109.CheckP7) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7109.CheckP8) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7109.CheckP9) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7109.CheckUse1) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7109.CheckMatching) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7109.Remark) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7109.MaterialCode_K3011) & "', "

            SQL = SQL & "  N'" & FormatSQL(Pub.DAT) & "', "
            SQL = SQL & "  N'" & FormatSQL(Pub.SAW) & "', "

            SQL = SQL & "  N'" & FormatSQL(z7109.seSite) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7109.cdSite) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK7109 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK7109", vbCritical)
        Finally
            Call GetFullInformation("PFK7109", "I", SQL)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK7109(z7109 As T7109_AREA) As Boolean
        REWRITE_PFK7109 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z7109)

            SQL = " UPDATE PFK7109 SET "
            SQL = SQL & "    K7109_Dseq      =  " & FormatSQL(z7109.Dseq) & ", "
            SQL = SQL & "    K7109_ProcessSeq      = N'" & FormatSQL(z7109.ProcessSeq) & "', "
            SQL = SQL & "    K7109_CustomerCode      = N'" & FormatSQL(z7109.CustomerCode) & "', "
            SQL = SQL & "    K7109_selGroupComponent      = N'" & FormatSQL(z7109.selGroupComponent) & "', "
            SQL = SQL & "    K7109_cdGroupComponent      = N'" & FormatSQL(z7109.cdGroupComponent) & "', "
            SQL = SQL & "    K7109_ComponentName      = N'" & FormatSQL(z7109.ComponentName) & "', "
            SQL = SQL & "    K7109_MaterialCode      = N'" & FormatSQL(z7109.MaterialCode) & "', "
            SQL = SQL & "    K7109_seUnitMaterial      = N'" & FormatSQL(z7109.seUnitMaterial) & "', "
            SQL = SQL & "    K7109_cdUnitMaterial      = N'" & FormatSQL(z7109.cdUnitMaterial) & "', "
            SQL = SQL & "    K7109_Specification      = N'" & FormatSQL(z7109.Specification) & "', "
            SQL = SQL & "    K7109_Width      = N'" & FormatSQL(z7109.Width) & "', "
            SQL = SQL & "    K7109_WidthID      = N'" & FormatSQL(z7109.WidthID) & "', "
            SQL = SQL & "    K7109_Height      = N'" & FormatSQL(z7109.Height) & "', "
            SQL = SQL & "    K7109_SizeName      = N'" & FormatSQL(z7109.SizeName) & "', "
            SQL = SQL & "    K7109_cdColorCode      = N'" & FormatSQL(z7109.cdColorCode) & "', "
            SQL = SQL & "    K7109_ColorCode      = N'" & FormatSQL(z7109.ColorCode) & "', "
            SQL = SQL & "    K7109_ColorName      = N'" & FormatSQL(z7109.ColorName) & "', "
            SQL = SQL & "    K7109_seShoesStatus      = N'" & FormatSQL(z7109.seShoesStatus) & "', "
            SQL = SQL & "    K7109_cdShoesStatus      = N'" & FormatSQL(z7109.cdShoesStatus) & "', "
            SQL = SQL & "    K7109_seDepartment      = N'" & FormatSQL(z7109.seDepartment) & "', "
            SQL = SQL & "    K7109_cdDepartment      = N'" & FormatSQL(z7109.cdDepartment) & "', "
            SQL = SQL & "    K7109_ContractID      = N'" & FormatSQL(z7109.ContractID) & "', "
            SQL = SQL & "    K7109_ContracSeq      =  " & FormatSQL(z7109.ContracSeq) & ", "
            SQL = SQL & "    K7109_SupplierCode      = N'" & FormatSQL(z7109.SupplierCode) & "', "
            SQL = SQL & "    K7109_PriceMaterial      =  " & FormatSQL(z7109.PriceMaterial) & ", "
            SQL = SQL & "    K7109_ExchangeCost      =  " & FormatSQL(z7109.ExchangeCost) & ", "
            SQL = SQL & "    K7109_ComplicationCost      =  " & FormatSQL(z7109.ComplicationCost) & ", "
            SQL = SQL & "    K7109_AddedCost      =  " & FormatSQL(z7109.AddedCost) & ", "
            SQL = SQL & "    K7109_ShippingRate      =  " & FormatSQL(z7109.ShippingRate) & ", "
            SQL = SQL & "    K7109_ShippingCost      =  " & FormatSQL(z7109.ShippingCost) & ", "
            SQL = SQL & "    K7109_PriceRnD      =  " & FormatSQL(z7109.PriceRnD) & ", "
            SQL = SQL & "    K7109_Price      =  " & FormatSQL(z7109.Price) & ", "
            SQL = SQL & "    K7109_seUnitPrice      = N'" & FormatSQL(z7109.seUnitPrice) & "', "
            SQL = SQL & "    K7109_cdUnitPrice      = N'" & FormatSQL(z7109.cdUnitPrice) & "', "
            SQL = SQL & "    K7109_QtyComponent      =  " & FormatSQL(z7109.QtyComponent) & ", "
            SQL = SQL & "    K7109_Consumption      =  " & FormatSQL(z7109.Consumption) & ", "
            SQL = SQL & "    K7109_Loss      =  " & FormatSQL(z7109.Loss) & ", "
            SQL = SQL & "    K7109_GrossUsage      =  " & FormatSQL(z7109.GrossUsage) & ", "
            SQL = SQL & "    K7109_MaterialAMT      =  " & FormatSQL(z7109.MaterialAMT) & ", "
            SQL = SQL & "    K7109_MaterialAMTPurchasing      =  " & FormatSQL(z7109.MaterialAMTPurchasing) & ", "
            SQL = SQL & "    K7109_MaterialAMTSales      =  " & FormatSQL(z7109.MaterialAMTSales) & ", "
            SQL = SQL & "    K7109_seSubProcess      = N'" & FormatSQL(z7109.seSubProcess) & "', "
            SQL = SQL & "    K7109_cdSubProcess      = N'" & FormatSQL(z7109.cdSubProcess) & "', "
            SQL = SQL & "    K7109_seSpecialProcess      = N'" & FormatSQL(z7109.seSpecialProcess) & "', "
            SQL = SQL & "    K7109_cdSpecialProcess      = N'" & FormatSQL(z7109.cdSpecialProcess) & "', "
            SQL = SQL & "    K7109_CheckMark      = N'" & FormatSQL(z7109.CheckMark) & "', "
            SQL = SQL & "    K7109_CheckUse      = N'" & FormatSQL(z7109.CheckUse) & "', "
            SQL = SQL & "    K7109_CheckP1      = N'" & FormatSQL(z7109.CheckP1) & "', "
            SQL = SQL & "    K7109_CheckP2      = N'" & FormatSQL(z7109.CheckP2) & "', "
            SQL = SQL & "    K7109_CheckP3      = N'" & FormatSQL(z7109.CheckP3) & "', "
            SQL = SQL & "    K7109_CheckP4      = N'" & FormatSQL(z7109.CheckP4) & "', "
            SQL = SQL & "    K7109_CheckP5      = N'" & FormatSQL(z7109.CheckP5) & "', "
            SQL = SQL & "    K7109_CheckP6      = N'" & FormatSQL(z7109.CheckP6) & "', "
            SQL = SQL & "    K7109_CheckP7      = N'" & FormatSQL(z7109.CheckP7) & "', "
            SQL = SQL & "    K7109_CheckP8      = N'" & FormatSQL(z7109.CheckP8) & "', "
            SQL = SQL & "    K7109_CheckP9      = N'" & FormatSQL(z7109.CheckP9) & "', "
            SQL = SQL & "    K7109_CheckUse1      = N'" & FormatSQL(z7109.CheckUse1) & "', "
            SQL = SQL & "    K7109_CheckMatching      = N'" & FormatSQL(z7109.CheckMatching) & "', "
            SQL = SQL & "    K7109_Remark      = N'" & FormatSQL(z7109.Remark) & "', "
            SQL = SQL & "    K7109_MaterialCode_K3011      = N'" & FormatSQL(z7109.MaterialCode_K3011) & "', "

            SQL = SQL & "    K7109_TimeUpdate      = N'" & FormatSQL(System_Date_time) & "', "
            SQL = SQL & "    K7109_DateUpdate      = N'" & FormatSQL(Pub.DAT) & "', "
            SQL = SQL & "    K7109_InchargeUpdate      = N'" & FormatSQL(Pub.SAW) & "', "

            SQL = SQL & "    K7109_seSite      = N'" & FormatSQL(z7109.seSite) & "', "
            SQL = SQL & "    K7109_cdSite      = N'" & FormatSQL(z7109.cdSite) & "'  "
            SQL = SQL & " WHERE K7109_GroupComponentBOM		 = '" & z7109.GroupComponentBOM & "' "
            SQL = SQL & "   AND K7109_GroupComponentSeq		 =  " & z7109.GroupComponentSeq & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK7109 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK7109", vbCritical)
        Finally
            Call GetFullInformation("PFK7109", "U", SQL)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK7109(z7109 As T7109_AREA) As Boolean
        DELETE_PFK7109 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z7109)

            SQL = " DELETE FROM PFK7109  "
            SQL = SQL & " WHERE K7109_GroupComponentBOM		 = '" & z7109.GroupComponentBOM & "' "
            SQL = SQL & "   AND K7109_GroupComponentSeq		 =  " & z7109.GroupComponentSeq & "  "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK7109 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK7109", vbCritical)
        Finally
            Call GetFullInformation("PFK7109", "U", SQL)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D7109_CLEAR()
        Try

            D7109.GroupComponentBOM = ""
            D7109.GroupComponentSeq = 0
            D7109.Dseq = 0
            D7109.ProcessSeq = ""
            D7109.CustomerCode = ""
            D7109.selGroupComponent = ""
            D7109.cdGroupComponent = ""
            D7109.ComponentName = ""
            D7109.MaterialCode = ""
            D7109.seUnitMaterial = ""
            D7109.cdUnitMaterial = ""
            D7109.Specification = ""
            D7109.Width = ""
            D7109.WidthID = ""
            D7109.Height = ""
            D7109.SizeName = ""
            D7109.cdColorCode = ""
            D7109.ColorCode = ""
            D7109.ColorName = ""
            D7109.seShoesStatus = ""
            D7109.cdShoesStatus = ""
            D7109.seDepartment = ""
            D7109.cdDepartment = ""
            D7109.ContractID = ""
            D7109.ContracSeq = 0
            D7109.SupplierCode = ""
            D7109.PriceMaterial = 0
            D7109.ExchangeCost = 0
            D7109.ComplicationCost = 0
            D7109.AddedCost = 0
            D7109.ShippingRate = 0
            D7109.ShippingCost = 0
            D7109.PriceRnD = 0
            D7109.Price = 0
            D7109.seUnitPrice = ""
            D7109.cdUnitPrice = ""
            D7109.QtyComponent = 0
            D7109.Consumption = 0
            D7109.Loss = 0
            D7109.GrossUsage = 0
            D7109.MaterialAMT = 0
            D7109.MaterialAMTPurchasing = 0
            D7109.MaterialAMTSales = 0
            D7109.seSubProcess = ""
            D7109.cdSubProcess = ""
            D7109.seSpecialProcess = ""
            D7109.cdSpecialProcess = ""
            D7109.CheckMark = ""
            D7109.CheckUse = ""
            D7109.CheckP1 = ""
            D7109.CheckP2 = ""
            D7109.CheckP3 = ""
            D7109.CheckP4 = ""
            D7109.CheckP5 = ""
            D7109.CheckP6 = ""
            D7109.CheckP7 = ""
            D7109.CheckP8 = ""
            D7109.CheckP9 = ""
            D7109.CheckUse1 = ""
            D7109.CheckMatching = ""
            D7109.Remark = ""
            D7109.MaterialCode_K3011 = ""
            D7109.seSite = ""
            D7109.cdSite = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D7109_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x7109 As T7109_AREA)
        Try

            x7109.GroupComponentBOM = trim$(x7109.GroupComponentBOM)
            x7109.GroupComponentSeq = trim$(x7109.GroupComponentSeq)
            x7109.Dseq = trim$(x7109.Dseq)
            x7109.ProcessSeq = trim$(x7109.ProcessSeq)
            x7109.CustomerCode = trim$(x7109.CustomerCode)
            x7109.selGroupComponent = trim$(x7109.selGroupComponent)
            x7109.cdGroupComponent = trim$(x7109.cdGroupComponent)
            x7109.ComponentName = trim$(x7109.ComponentName)
            x7109.MaterialCode = trim$(x7109.MaterialCode)
            x7109.seUnitMaterial = trim$(x7109.seUnitMaterial)
            x7109.cdUnitMaterial = trim$(x7109.cdUnitMaterial)
            x7109.Specification = trim$(x7109.Specification)
            x7109.Width = trim$(x7109.Width)
            x7109.WidthID = trim$(x7109.WidthID)
            x7109.Height = trim$(x7109.Height)
            x7109.SizeName = trim$(x7109.SizeName)
            x7109.cdColorCode = trim$(x7109.cdColorCode)
            x7109.ColorCode = trim$(x7109.ColorCode)
            x7109.ColorName = trim$(x7109.ColorName)
            x7109.seShoesStatus = trim$(x7109.seShoesStatus)
            x7109.cdShoesStatus = trim$(x7109.cdShoesStatus)
            x7109.seDepartment = trim$(x7109.seDepartment)
            x7109.cdDepartment = trim$(x7109.cdDepartment)
            x7109.ContractID = trim$(x7109.ContractID)
            x7109.ContracSeq = trim$(x7109.ContracSeq)
            x7109.SupplierCode = trim$(x7109.SupplierCode)
            x7109.PriceMaterial = trim$(x7109.PriceMaterial)
            x7109.ExchangeCost = trim$(x7109.ExchangeCost)
            x7109.ComplicationCost = trim$(x7109.ComplicationCost)
            x7109.AddedCost = trim$(x7109.AddedCost)
            x7109.ShippingRate = trim$(x7109.ShippingRate)
            x7109.ShippingCost = trim$(x7109.ShippingCost)
            x7109.PriceRnD = trim$(x7109.PriceRnD)
            x7109.Price = trim$(x7109.Price)
            x7109.seUnitPrice = trim$(x7109.seUnitPrice)
            x7109.cdUnitPrice = trim$(x7109.cdUnitPrice)
            x7109.QtyComponent = trim$(x7109.QtyComponent)
            x7109.Consumption = trim$(x7109.Consumption)
            x7109.Loss = trim$(x7109.Loss)
            x7109.GrossUsage = trim$(x7109.GrossUsage)
            x7109.MaterialAMT = trim$(x7109.MaterialAMT)
            x7109.MaterialAMTPurchasing = trim$(x7109.MaterialAMTPurchasing)
            x7109.MaterialAMTSales = trim$(x7109.MaterialAMTSales)
            x7109.seSubProcess = trim$(x7109.seSubProcess)
            x7109.cdSubProcess = trim$(x7109.cdSubProcess)
            x7109.seSpecialProcess = trim$(x7109.seSpecialProcess)
            x7109.cdSpecialProcess = trim$(x7109.cdSpecialProcess)
            x7109.CheckMark = trim$(x7109.CheckMark)
            x7109.CheckUse = trim$(x7109.CheckUse)
            x7109.CheckP1 = trim$(x7109.CheckP1)
            x7109.CheckP2 = trim$(x7109.CheckP2)
            x7109.CheckP3 = trim$(x7109.CheckP3)
            x7109.CheckP4 = trim$(x7109.CheckP4)
            x7109.CheckP5 = trim$(x7109.CheckP5)
            x7109.CheckP6 = trim$(x7109.CheckP6)
            x7109.CheckP7 = trim$(x7109.CheckP7)
            x7109.CheckP8 = trim$(x7109.CheckP8)
            x7109.CheckP9 = trim$(x7109.CheckP9)
            x7109.CheckUse1 = trim$(x7109.CheckUse1)
            x7109.CheckMatching = trim$(x7109.CheckMatching)
            x7109.Remark = trim$(x7109.Remark)
            x7109.MaterialCode_K3011 = trim$(x7109.MaterialCode_K3011)
            x7109.seSite = Trim$(x7109.seSite)
            x7109.cdSite = trim$(x7109.cdSite)

            If trim$(x7109.GroupComponentBOM) = "" Then x7109.GroupComponentBOM = Space(1)
            If trim$(x7109.GroupComponentSeq) = "" Then x7109.GroupComponentSeq = 0
            If trim$(x7109.Dseq) = "" Then x7109.Dseq = 0
            If trim$(x7109.ProcessSeq) = "" Then x7109.ProcessSeq = Space(1)
            If trim$(x7109.CustomerCode) = "" Then x7109.CustomerCode = Space(1)
            If trim$(x7109.selGroupComponent) = "" Then x7109.selGroupComponent = Space(1)
            If trim$(x7109.cdGroupComponent) = "" Then x7109.cdGroupComponent = Space(1)
            If trim$(x7109.ComponentName) = "" Then x7109.ComponentName = Space(1)
            If trim$(x7109.MaterialCode) = "" Then x7109.MaterialCode = Space(1)
            If trim$(x7109.seUnitMaterial) = "" Then x7109.seUnitMaterial = Space(1)
            If trim$(x7109.cdUnitMaterial) = "" Then x7109.cdUnitMaterial = Space(1)
            If trim$(x7109.Specification) = "" Then x7109.Specification = Space(1)
            If trim$(x7109.Width) = "" Then x7109.Width = Space(1)
            If trim$(x7109.WidthID) = "" Then x7109.WidthID = Space(1)
            If trim$(x7109.Height) = "" Then x7109.Height = Space(1)
            If trim$(x7109.SizeName) = "" Then x7109.SizeName = Space(1)
            If trim$(x7109.cdColorCode) = "" Then x7109.cdColorCode = Space(1)
            If trim$(x7109.ColorCode) = "" Then x7109.ColorCode = Space(1)
            If trim$(x7109.ColorName) = "" Then x7109.ColorName = Space(1)
            If trim$(x7109.seShoesStatus) = "" Then x7109.seShoesStatus = Space(1)
            If trim$(x7109.cdShoesStatus) = "" Then x7109.cdShoesStatus = Space(1)
            If trim$(x7109.seDepartment) = "" Then x7109.seDepartment = Space(1)
            If trim$(x7109.cdDepartment) = "" Then x7109.cdDepartment = Space(1)
            If trim$(x7109.ContractID) = "" Then x7109.ContractID = Space(1)
            If trim$(x7109.ContracSeq) = "" Then x7109.ContracSeq = 0
            If trim$(x7109.SupplierCode) = "" Then x7109.SupplierCode = Space(1)
            If trim$(x7109.PriceMaterial) = "" Then x7109.PriceMaterial = 0
            If trim$(x7109.ExchangeCost) = "" Then x7109.ExchangeCost = 0
            If trim$(x7109.ComplicationCost) = "" Then x7109.ComplicationCost = 0
            If trim$(x7109.AddedCost) = "" Then x7109.AddedCost = 0
            If trim$(x7109.ShippingRate) = "" Then x7109.ShippingRate = 0
            If trim$(x7109.ShippingCost) = "" Then x7109.ShippingCost = 0
            If trim$(x7109.PriceRnD) = "" Then x7109.PriceRnD = 0
            If trim$(x7109.Price) = "" Then x7109.Price = 0
            If trim$(x7109.seUnitPrice) = "" Then x7109.seUnitPrice = Space(1)
            If trim$(x7109.cdUnitPrice) = "" Then x7109.cdUnitPrice = Space(1)
            If trim$(x7109.QtyComponent) = "" Then x7109.QtyComponent = 0
            If trim$(x7109.Consumption) = "" Then x7109.Consumption = 0
            If trim$(x7109.Loss) = "" Then x7109.Loss = 0
            If trim$(x7109.GrossUsage) = "" Then x7109.GrossUsage = 0
            If trim$(x7109.MaterialAMT) = "" Then x7109.MaterialAMT = 0
            If trim$(x7109.MaterialAMTPurchasing) = "" Then x7109.MaterialAMTPurchasing = 0
            If trim$(x7109.MaterialAMTSales) = "" Then x7109.MaterialAMTSales = 0
            If trim$(x7109.seSubProcess) = "" Then x7109.seSubProcess = Space(1)
            If trim$(x7109.cdSubProcess) = "" Then x7109.cdSubProcess = Space(1)
            If trim$(x7109.seSpecialProcess) = "" Then x7109.seSpecialProcess = Space(1)
            If trim$(x7109.cdSpecialProcess) = "" Then x7109.cdSpecialProcess = Space(1)
            If trim$(x7109.CheckMark) = "" Then x7109.CheckMark = Space(1)
            If trim$(x7109.CheckUse) = "" Then x7109.CheckUse = Space(1)
            If trim$(x7109.CheckP1) = "" Then x7109.CheckP1 = Space(1)
            If trim$(x7109.CheckP2) = "" Then x7109.CheckP2 = Space(1)
            If trim$(x7109.CheckP3) = "" Then x7109.CheckP3 = Space(1)
            If trim$(x7109.CheckP4) = "" Then x7109.CheckP4 = Space(1)
            If trim$(x7109.CheckP5) = "" Then x7109.CheckP5 = Space(1)
            If trim$(x7109.CheckP6) = "" Then x7109.CheckP6 = Space(1)
            If trim$(x7109.CheckP7) = "" Then x7109.CheckP7 = Space(1)
            If trim$(x7109.CheckP8) = "" Then x7109.CheckP8 = Space(1)
            If trim$(x7109.CheckP9) = "" Then x7109.CheckP9 = Space(1)
            If trim$(x7109.CheckUse1) = "" Then x7109.CheckUse1 = Space(1)
            If trim$(x7109.CheckMatching) = "" Then x7109.CheckMatching = Space(1)
            If trim$(x7109.Remark) = "" Then x7109.Remark = Space(1)
            If trim$(x7109.MaterialCode_K3011) = "" Then x7109.MaterialCode_K3011 = Space(1)
            If Trim$(x7109.seSite) = "" Then x7109.seSite = Space(1)
            If trim$(x7109.cdSite) = "" Then x7109.cdSite = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K7109_MOVE(rs7109 As SqlClient.SqlDataReader)
        Try

            Call D7109_CLEAR()

            If IsdbNull(rs7109!K7109_GroupComponentBOM) = False Then D7109.GroupComponentBOM = Trim$(rs7109!K7109_GroupComponentBOM)
            If IsdbNull(rs7109!K7109_GroupComponentSeq) = False Then D7109.GroupComponentSeq = Trim$(rs7109!K7109_GroupComponentSeq)
            If IsdbNull(rs7109!K7109_Dseq) = False Then D7109.Dseq = Trim$(rs7109!K7109_Dseq)
            If IsdbNull(rs7109!K7109_ProcessSeq) = False Then D7109.ProcessSeq = Trim$(rs7109!K7109_ProcessSeq)
            If IsdbNull(rs7109!K7109_CustomerCode) = False Then D7109.CustomerCode = Trim$(rs7109!K7109_CustomerCode)
            If IsdbNull(rs7109!K7109_selGroupComponent) = False Then D7109.selGroupComponent = Trim$(rs7109!K7109_selGroupComponent)
            If IsdbNull(rs7109!K7109_cdGroupComponent) = False Then D7109.cdGroupComponent = Trim$(rs7109!K7109_cdGroupComponent)
            If IsdbNull(rs7109!K7109_ComponentName) = False Then D7109.ComponentName = Trim$(rs7109!K7109_ComponentName)
            If IsdbNull(rs7109!K7109_MaterialCode) = False Then D7109.MaterialCode = Trim$(rs7109!K7109_MaterialCode)
            If IsdbNull(rs7109!K7109_seUnitMaterial) = False Then D7109.seUnitMaterial = Trim$(rs7109!K7109_seUnitMaterial)
            If IsdbNull(rs7109!K7109_cdUnitMaterial) = False Then D7109.cdUnitMaterial = Trim$(rs7109!K7109_cdUnitMaterial)
            If IsdbNull(rs7109!K7109_Specification) = False Then D7109.Specification = Trim$(rs7109!K7109_Specification)
            If IsdbNull(rs7109!K7109_Width) = False Then D7109.Width = Trim$(rs7109!K7109_Width)
            If IsdbNull(rs7109!K7109_WidthID) = False Then D7109.WidthID = Trim$(rs7109!K7109_WidthID)
            If IsdbNull(rs7109!K7109_Height) = False Then D7109.Height = Trim$(rs7109!K7109_Height)
            If IsdbNull(rs7109!K7109_SizeName) = False Then D7109.SizeName = Trim$(rs7109!K7109_SizeName)
            If IsdbNull(rs7109!K7109_cdColorCode) = False Then D7109.cdColorCode = Trim$(rs7109!K7109_cdColorCode)
            If IsdbNull(rs7109!K7109_ColorCode) = False Then D7109.ColorCode = Trim$(rs7109!K7109_ColorCode)
            If IsdbNull(rs7109!K7109_ColorName) = False Then D7109.ColorName = Trim$(rs7109!K7109_ColorName)
            If IsdbNull(rs7109!K7109_seShoesStatus) = False Then D7109.seShoesStatus = Trim$(rs7109!K7109_seShoesStatus)
            If IsdbNull(rs7109!K7109_cdShoesStatus) = False Then D7109.cdShoesStatus = Trim$(rs7109!K7109_cdShoesStatus)
            If IsdbNull(rs7109!K7109_seDepartment) = False Then D7109.seDepartment = Trim$(rs7109!K7109_seDepartment)
            If IsdbNull(rs7109!K7109_cdDepartment) = False Then D7109.cdDepartment = Trim$(rs7109!K7109_cdDepartment)
            If IsdbNull(rs7109!K7109_ContractID) = False Then D7109.ContractID = Trim$(rs7109!K7109_ContractID)
            If IsdbNull(rs7109!K7109_ContracSeq) = False Then D7109.ContracSeq = Trim$(rs7109!K7109_ContracSeq)
            If IsdbNull(rs7109!K7109_SupplierCode) = False Then D7109.SupplierCode = Trim$(rs7109!K7109_SupplierCode)
            If IsdbNull(rs7109!K7109_PriceMaterial) = False Then D7109.PriceMaterial = Trim$(rs7109!K7109_PriceMaterial)
            If IsdbNull(rs7109!K7109_ExchangeCost) = False Then D7109.ExchangeCost = Trim$(rs7109!K7109_ExchangeCost)
            If IsdbNull(rs7109!K7109_ComplicationCost) = False Then D7109.ComplicationCost = Trim$(rs7109!K7109_ComplicationCost)
            If IsdbNull(rs7109!K7109_AddedCost) = False Then D7109.AddedCost = Trim$(rs7109!K7109_AddedCost)
            If IsdbNull(rs7109!K7109_ShippingRate) = False Then D7109.ShippingRate = Trim$(rs7109!K7109_ShippingRate)
            If IsdbNull(rs7109!K7109_ShippingCost) = False Then D7109.ShippingCost = Trim$(rs7109!K7109_ShippingCost)
            If IsdbNull(rs7109!K7109_PriceRnD) = False Then D7109.PriceRnD = Trim$(rs7109!K7109_PriceRnD)
            If IsdbNull(rs7109!K7109_Price) = False Then D7109.Price = Trim$(rs7109!K7109_Price)
            If IsdbNull(rs7109!K7109_seUnitPrice) = False Then D7109.seUnitPrice = Trim$(rs7109!K7109_seUnitPrice)
            If IsdbNull(rs7109!K7109_cdUnitPrice) = False Then D7109.cdUnitPrice = Trim$(rs7109!K7109_cdUnitPrice)
            If IsdbNull(rs7109!K7109_QtyComponent) = False Then D7109.QtyComponent = Trim$(rs7109!K7109_QtyComponent)
            If IsdbNull(rs7109!K7109_Consumption) = False Then D7109.Consumption = Trim$(rs7109!K7109_Consumption)
            If IsdbNull(rs7109!K7109_Loss) = False Then D7109.Loss = Trim$(rs7109!K7109_Loss)
            If IsdbNull(rs7109!K7109_GrossUsage) = False Then D7109.GrossUsage = Trim$(rs7109!K7109_GrossUsage)
            If IsdbNull(rs7109!K7109_MaterialAMT) = False Then D7109.MaterialAMT = Trim$(rs7109!K7109_MaterialAMT)
            If IsdbNull(rs7109!K7109_MaterialAMTPurchasing) = False Then D7109.MaterialAMTPurchasing = Trim$(rs7109!K7109_MaterialAMTPurchasing)
            If IsdbNull(rs7109!K7109_MaterialAMTSales) = False Then D7109.MaterialAMTSales = Trim$(rs7109!K7109_MaterialAMTSales)
            If IsdbNull(rs7109!K7109_seSubProcess) = False Then D7109.seSubProcess = Trim$(rs7109!K7109_seSubProcess)
            If IsdbNull(rs7109!K7109_cdSubProcess) = False Then D7109.cdSubProcess = Trim$(rs7109!K7109_cdSubProcess)
            If IsdbNull(rs7109!K7109_seSpecialProcess) = False Then D7109.seSpecialProcess = Trim$(rs7109!K7109_seSpecialProcess)
            If IsdbNull(rs7109!K7109_cdSpecialProcess) = False Then D7109.cdSpecialProcess = Trim$(rs7109!K7109_cdSpecialProcess)
            If IsdbNull(rs7109!K7109_CheckMark) = False Then D7109.CheckMark = Trim$(rs7109!K7109_CheckMark)
            If IsdbNull(rs7109!K7109_CheckUse) = False Then D7109.CheckUse = Trim$(rs7109!K7109_CheckUse)
            If IsdbNull(rs7109!K7109_CheckP1) = False Then D7109.CheckP1 = Trim$(rs7109!K7109_CheckP1)
            If IsdbNull(rs7109!K7109_CheckP2) = False Then D7109.CheckP2 = Trim$(rs7109!K7109_CheckP2)
            If IsdbNull(rs7109!K7109_CheckP3) = False Then D7109.CheckP3 = Trim$(rs7109!K7109_CheckP3)
            If IsdbNull(rs7109!K7109_CheckP4) = False Then D7109.CheckP4 = Trim$(rs7109!K7109_CheckP4)
            If IsdbNull(rs7109!K7109_CheckP5) = False Then D7109.CheckP5 = Trim$(rs7109!K7109_CheckP5)
            If IsdbNull(rs7109!K7109_CheckP6) = False Then D7109.CheckP6 = Trim$(rs7109!K7109_CheckP6)
            If IsdbNull(rs7109!K7109_CheckP7) = False Then D7109.CheckP7 = Trim$(rs7109!K7109_CheckP7)
            If IsdbNull(rs7109!K7109_CheckP8) = False Then D7109.CheckP8 = Trim$(rs7109!K7109_CheckP8)
            If IsdbNull(rs7109!K7109_CheckP9) = False Then D7109.CheckP9 = Trim$(rs7109!K7109_CheckP9)
            If IsdbNull(rs7109!K7109_CheckUse1) = False Then D7109.CheckUse1 = Trim$(rs7109!K7109_CheckUse1)
            If IsdbNull(rs7109!K7109_CheckMatching) = False Then D7109.CheckMatching = Trim$(rs7109!K7109_CheckMatching)
            If IsdbNull(rs7109!K7109_Remark) = False Then D7109.Remark = Trim$(rs7109!K7109_Remark)
            If IsdbNull(rs7109!K7109_MaterialCode_K3011) = False Then D7109.MaterialCode_K3011 = Trim$(rs7109!K7109_MaterialCode_K3011)
            If IsDBNull(rs7109!K7109_seSite) = False Then D7109.seSite = Trim$(rs7109!K7109_seSite)
            If IsdbNull(rs7109!K7109_cdSite) = False Then D7109.cdSite = Trim$(rs7109!K7109_cdSite)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K7109_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K7109_MOVE(rs7109 As DataRow)
        Try

            Call D7109_CLEAR()

            If IsdbNull(rs7109!K7109_GroupComponentBOM) = False Then D7109.GroupComponentBOM = Trim$(rs7109!K7109_GroupComponentBOM)
            If IsdbNull(rs7109!K7109_GroupComponentSeq) = False Then D7109.GroupComponentSeq = Trim$(rs7109!K7109_GroupComponentSeq)
            If IsdbNull(rs7109!K7109_Dseq) = False Then D7109.Dseq = Trim$(rs7109!K7109_Dseq)
            If IsdbNull(rs7109!K7109_ProcessSeq) = False Then D7109.ProcessSeq = Trim$(rs7109!K7109_ProcessSeq)
            If IsdbNull(rs7109!K7109_CustomerCode) = False Then D7109.CustomerCode = Trim$(rs7109!K7109_CustomerCode)
            If IsdbNull(rs7109!K7109_selGroupComponent) = False Then D7109.selGroupComponent = Trim$(rs7109!K7109_selGroupComponent)
            If IsdbNull(rs7109!K7109_cdGroupComponent) = False Then D7109.cdGroupComponent = Trim$(rs7109!K7109_cdGroupComponent)
            If IsdbNull(rs7109!K7109_ComponentName) = False Then D7109.ComponentName = Trim$(rs7109!K7109_ComponentName)
            If IsdbNull(rs7109!K7109_MaterialCode) = False Then D7109.MaterialCode = Trim$(rs7109!K7109_MaterialCode)
            If IsdbNull(rs7109!K7109_seUnitMaterial) = False Then D7109.seUnitMaterial = Trim$(rs7109!K7109_seUnitMaterial)
            If IsdbNull(rs7109!K7109_cdUnitMaterial) = False Then D7109.cdUnitMaterial = Trim$(rs7109!K7109_cdUnitMaterial)
            If IsdbNull(rs7109!K7109_Specification) = False Then D7109.Specification = Trim$(rs7109!K7109_Specification)
            If IsdbNull(rs7109!K7109_Width) = False Then D7109.Width = Trim$(rs7109!K7109_Width)
            If IsdbNull(rs7109!K7109_WidthID) = False Then D7109.WidthID = Trim$(rs7109!K7109_WidthID)
            If IsdbNull(rs7109!K7109_Height) = False Then D7109.Height = Trim$(rs7109!K7109_Height)
            If IsdbNull(rs7109!K7109_SizeName) = False Then D7109.SizeName = Trim$(rs7109!K7109_SizeName)
            If IsdbNull(rs7109!K7109_cdColorCode) = False Then D7109.cdColorCode = Trim$(rs7109!K7109_cdColorCode)
            If IsdbNull(rs7109!K7109_ColorCode) = False Then D7109.ColorCode = Trim$(rs7109!K7109_ColorCode)
            If IsdbNull(rs7109!K7109_ColorName) = False Then D7109.ColorName = Trim$(rs7109!K7109_ColorName)
            If IsdbNull(rs7109!K7109_seShoesStatus) = False Then D7109.seShoesStatus = Trim$(rs7109!K7109_seShoesStatus)
            If IsdbNull(rs7109!K7109_cdShoesStatus) = False Then D7109.cdShoesStatus = Trim$(rs7109!K7109_cdShoesStatus)
            If IsdbNull(rs7109!K7109_seDepartment) = False Then D7109.seDepartment = Trim$(rs7109!K7109_seDepartment)
            If IsdbNull(rs7109!K7109_cdDepartment) = False Then D7109.cdDepartment = Trim$(rs7109!K7109_cdDepartment)
            If IsdbNull(rs7109!K7109_ContractID) = False Then D7109.ContractID = Trim$(rs7109!K7109_ContractID)
            If IsdbNull(rs7109!K7109_ContracSeq) = False Then D7109.ContracSeq = Trim$(rs7109!K7109_ContracSeq)
            If IsdbNull(rs7109!K7109_SupplierCode) = False Then D7109.SupplierCode = Trim$(rs7109!K7109_SupplierCode)
            If IsdbNull(rs7109!K7109_PriceMaterial) = False Then D7109.PriceMaterial = Trim$(rs7109!K7109_PriceMaterial)
            If IsdbNull(rs7109!K7109_ExchangeCost) = False Then D7109.ExchangeCost = Trim$(rs7109!K7109_ExchangeCost)
            If IsdbNull(rs7109!K7109_ComplicationCost) = False Then D7109.ComplicationCost = Trim$(rs7109!K7109_ComplicationCost)
            If IsdbNull(rs7109!K7109_AddedCost) = False Then D7109.AddedCost = Trim$(rs7109!K7109_AddedCost)
            If IsdbNull(rs7109!K7109_ShippingRate) = False Then D7109.ShippingRate = Trim$(rs7109!K7109_ShippingRate)
            If IsdbNull(rs7109!K7109_ShippingCost) = False Then D7109.ShippingCost = Trim$(rs7109!K7109_ShippingCost)
            If IsdbNull(rs7109!K7109_PriceRnD) = False Then D7109.PriceRnD = Trim$(rs7109!K7109_PriceRnD)
            If IsdbNull(rs7109!K7109_Price) = False Then D7109.Price = Trim$(rs7109!K7109_Price)
            If IsdbNull(rs7109!K7109_seUnitPrice) = False Then D7109.seUnitPrice = Trim$(rs7109!K7109_seUnitPrice)
            If IsdbNull(rs7109!K7109_cdUnitPrice) = False Then D7109.cdUnitPrice = Trim$(rs7109!K7109_cdUnitPrice)
            If IsdbNull(rs7109!K7109_QtyComponent) = False Then D7109.QtyComponent = Trim$(rs7109!K7109_QtyComponent)
            If IsdbNull(rs7109!K7109_Consumption) = False Then D7109.Consumption = Trim$(rs7109!K7109_Consumption)
            If IsdbNull(rs7109!K7109_Loss) = False Then D7109.Loss = Trim$(rs7109!K7109_Loss)
            If IsdbNull(rs7109!K7109_GrossUsage) = False Then D7109.GrossUsage = Trim$(rs7109!K7109_GrossUsage)
            If IsdbNull(rs7109!K7109_MaterialAMT) = False Then D7109.MaterialAMT = Trim$(rs7109!K7109_MaterialAMT)
            If IsdbNull(rs7109!K7109_MaterialAMTPurchasing) = False Then D7109.MaterialAMTPurchasing = Trim$(rs7109!K7109_MaterialAMTPurchasing)
            If IsdbNull(rs7109!K7109_MaterialAMTSales) = False Then D7109.MaterialAMTSales = Trim$(rs7109!K7109_MaterialAMTSales)
            If IsdbNull(rs7109!K7109_seSubProcess) = False Then D7109.seSubProcess = Trim$(rs7109!K7109_seSubProcess)
            If IsdbNull(rs7109!K7109_cdSubProcess) = False Then D7109.cdSubProcess = Trim$(rs7109!K7109_cdSubProcess)
            If IsdbNull(rs7109!K7109_seSpecialProcess) = False Then D7109.seSpecialProcess = Trim$(rs7109!K7109_seSpecialProcess)
            If IsdbNull(rs7109!K7109_cdSpecialProcess) = False Then D7109.cdSpecialProcess = Trim$(rs7109!K7109_cdSpecialProcess)
            If IsdbNull(rs7109!K7109_CheckMark) = False Then D7109.CheckMark = Trim$(rs7109!K7109_CheckMark)
            If IsdbNull(rs7109!K7109_CheckUse) = False Then D7109.CheckUse = Trim$(rs7109!K7109_CheckUse)
            If IsdbNull(rs7109!K7109_CheckP1) = False Then D7109.CheckP1 = Trim$(rs7109!K7109_CheckP1)
            If IsdbNull(rs7109!K7109_CheckP2) = False Then D7109.CheckP2 = Trim$(rs7109!K7109_CheckP2)
            If IsdbNull(rs7109!K7109_CheckP3) = False Then D7109.CheckP3 = Trim$(rs7109!K7109_CheckP3)
            If IsdbNull(rs7109!K7109_CheckP4) = False Then D7109.CheckP4 = Trim$(rs7109!K7109_CheckP4)
            If IsdbNull(rs7109!K7109_CheckP5) = False Then D7109.CheckP5 = Trim$(rs7109!K7109_CheckP5)
            If IsdbNull(rs7109!K7109_CheckP6) = False Then D7109.CheckP6 = Trim$(rs7109!K7109_CheckP6)
            If IsdbNull(rs7109!K7109_CheckP7) = False Then D7109.CheckP7 = Trim$(rs7109!K7109_CheckP7)
            If IsdbNull(rs7109!K7109_CheckP8) = False Then D7109.CheckP8 = Trim$(rs7109!K7109_CheckP8)
            If IsdbNull(rs7109!K7109_CheckP9) = False Then D7109.CheckP9 = Trim$(rs7109!K7109_CheckP9)
            If IsdbNull(rs7109!K7109_CheckUse1) = False Then D7109.CheckUse1 = Trim$(rs7109!K7109_CheckUse1)
            If IsdbNull(rs7109!K7109_CheckMatching) = False Then D7109.CheckMatching = Trim$(rs7109!K7109_CheckMatching)
            If IsdbNull(rs7109!K7109_Remark) = False Then D7109.Remark = Trim$(rs7109!K7109_Remark)
            If IsdbNull(rs7109!K7109_MaterialCode_K3011) = False Then D7109.MaterialCode_K3011 = Trim$(rs7109!K7109_MaterialCode_K3011)
            If IsDBNull(rs7109!K7109_seSite) = False Then D7109.seSite = Trim$(rs7109!K7109_seSite)
            If IsdbNull(rs7109!K7109_cdSite) = False Then D7109.cdSite = Trim$(rs7109!K7109_cdSite)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K7109_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K7109_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z7109 As T7109_AREA, GROUPCOMPONENTBOM As String, GROUPCOMPONENTSEQ As Double) As Boolean

        K7109_MOVE = False

        Try
            If READ_PFK7109(GROUPCOMPONENTBOM, GROUPCOMPONENTSEQ) = True Then
                z7109 = D7109
                K7109_MOVE = True
            Else
                z7109 = Nothing
            End If

            If getColumnIndex(spr, "GroupComponentBOM") > -1 Then z7109.GroupComponentBOM = getDataM(spr, getColumnIndex(spr, "GroupComponentBOM"), xRow)
            If getColumnIndex(spr, "GroupComponentSeq") > -1 Then z7109.GroupComponentSeq = getDataM(spr, getColumnIndex(spr, "GroupComponentSeq"), xRow)
            If getColumnIndex(spr, "Dseq") > -1 Then z7109.Dseq = getDataM(spr, getColumnIndex(spr, "Dseq"), xRow)
            If getColumnIndex(spr, "ProcessSeq") > -1 Then z7109.ProcessSeq = getDataM(spr, getColumnIndex(spr, "ProcessSeq"), xRow)
            If getColumnIndex(spr, "CustomerCode") > -1 Then z7109.CustomerCode = getDataM(spr, getColumnIndex(spr, "CustomerCode"), xRow)
            If getColumnIndex(spr, "selGroupComponent") > -1 Then z7109.selGroupComponent = getDataM(spr, getColumnIndex(spr, "selGroupComponent"), xRow)
            If getColumnIndex(spr, "cdGroupComponent") > -1 Then z7109.cdGroupComponent = getDataM(spr, getColumnIndex(spr, "cdGroupComponent"), xRow)
            If getColumnIndex(spr, "ComponentName") > -1 Then z7109.ComponentName = getDataM(spr, getColumnIndex(spr, "ComponentName"), xRow)
            If getColumnIndex(spr, "MaterialCode") > -1 Then z7109.MaterialCode = getDataM(spr, getColumnIndex(spr, "MaterialCode"), xRow)
            If getColumnIndex(spr, "seUnitMaterial") > -1 Then z7109.seUnitMaterial = getDataM(spr, getColumnIndex(spr, "seUnitMaterial"), xRow)
            If getColumnIndex(spr, "cdUnitMaterial") > -1 Then z7109.cdUnitMaterial = getDataM(spr, getColumnIndex(spr, "cdUnitMaterial"), xRow)
            If getColumnIndex(spr, "Specification") > -1 Then z7109.Specification = getDataM(spr, getColumnIndex(spr, "Specification"), xRow)
            If getColumnIndex(spr, "Width") > -1 Then z7109.Width = getDataM(spr, getColumnIndex(spr, "Width"), xRow)
            If getColumnIndex(spr, "WidthID") > -1 Then z7109.WidthID = getDataM(spr, getColumnIndex(spr, "WidthID"), xRow)
            If getColumnIndex(spr, "Height") > -1 Then z7109.Height = getDataM(spr, getColumnIndex(spr, "Height"), xRow)
            If getColumnIndex(spr, "SizeName") > -1 Then z7109.SizeName = getDataM(spr, getColumnIndex(spr, "SizeName"), xRow)
            If getColumnIndex(spr, "cdColorCode") > -1 Then z7109.cdColorCode = getDataM(spr, getColumnIndex(spr, "cdColorCode"), xRow)
            If getColumnIndex(spr, "ColorCode") > -1 Then z7109.ColorCode = getDataM(spr, getColumnIndex(spr, "ColorCode"), xRow)
            If getColumnIndex(spr, "ColorName") > -1 Then z7109.ColorName = getDataM(spr, getColumnIndex(spr, "ColorName"), xRow)
            If getColumnIndex(spr, "seShoesStatus") > -1 Then z7109.seShoesStatus = getDataM(spr, getColumnIndex(spr, "seShoesStatus"), xRow)
            If getColumnIndex(spr, "cdShoesStatus") > -1 Then z7109.cdShoesStatus = getDataM(spr, getColumnIndex(spr, "cdShoesStatus"), xRow)
            If getColumnIndex(spr, "seDepartment") > -1 Then z7109.seDepartment = getDataM(spr, getColumnIndex(spr, "seDepartment"), xRow)
            If getColumnIndex(spr, "cdDepartment") > -1 Then z7109.cdDepartment = getDataM(spr, getColumnIndex(spr, "cdDepartment"), xRow)
            If getColumnIndex(spr, "ContractID") > -1 Then z7109.ContractID = getDataM(spr, getColumnIndex(spr, "ContractID"), xRow)
            If getColumnIndex(spr, "ContracSeq") > -1 Then z7109.ContracSeq = getDataM(spr, getColumnIndex(spr, "ContracSeq"), xRow)
            If getColumnIndex(spr, "SupplierCode") > -1 Then z7109.SupplierCode = getDataM(spr, getColumnIndex(spr, "SupplierCode"), xRow)
            If getColumnIndex(spr, "PriceMaterial") > -1 Then z7109.PriceMaterial = getDataM(spr, getColumnIndex(spr, "PriceMaterial"), xRow)
            If getColumnIndex(spr, "ExchangeCost") > -1 Then z7109.ExchangeCost = getDataM(spr, getColumnIndex(spr, "ExchangeCost"), xRow)
            If getColumnIndex(spr, "ComplicationCost") > -1 Then z7109.ComplicationCost = getDataM(spr, getColumnIndex(spr, "ComplicationCost"), xRow)
            If getColumnIndex(spr, "AddedCost") > -1 Then z7109.AddedCost = getDataM(spr, getColumnIndex(spr, "AddedCost"), xRow)
            If getColumnIndex(spr, "ShippingRate") > -1 Then z7109.ShippingRate = getDataM(spr, getColumnIndex(spr, "ShippingRate"), xRow)
            If getColumnIndex(spr, "ShippingCost") > -1 Then z7109.ShippingCost = getDataM(spr, getColumnIndex(spr, "ShippingCost"), xRow)
            If getColumnIndex(spr, "PriceRnD") > -1 Then z7109.PriceRnD = getDataM(spr, getColumnIndex(spr, "PriceRnD"), xRow)
            If getColumnIndex(spr, "Price") > -1 Then z7109.Price = getDataM(spr, getColumnIndex(spr, "Price"), xRow)
            If getColumnIndex(spr, "seUnitPrice") > -1 Then z7109.seUnitPrice = getDataM(spr, getColumnIndex(spr, "seUnitPrice"), xRow)
            If getColumnIndex(spr, "cdUnitPrice") > -1 Then z7109.cdUnitPrice = getDataM(spr, getColumnIndex(spr, "cdUnitPrice"), xRow)
            If getColumnIndex(spr, "QtyComponent") > -1 Then z7109.QtyComponent = getDataM(spr, getColumnIndex(spr, "QtyComponent"), xRow)
            If getColumnIndex(spr, "Consumption") > -1 Then z7109.Consumption = getDataM(spr, getColumnIndex(spr, "Consumption"), xRow)
            If getColumnIndex(spr, "Loss") > -1 Then z7109.Loss = getDataM(spr, getColumnIndex(spr, "Loss"), xRow)
            If getColumnIndex(spr, "GrossUsage") > -1 Then z7109.GrossUsage = getDataM(spr, getColumnIndex(spr, "GrossUsage"), xRow)
            If getColumnIndex(spr, "MaterialAMT") > -1 Then z7109.MaterialAMT = getDataM(spr, getColumnIndex(spr, "MaterialAMT"), xRow)
            If getColumnIndex(spr, "MaterialAMTPurchasing") > -1 Then z7109.MaterialAMTPurchasing = getDataM(spr, getColumnIndex(spr, "MaterialAMTPurchasing"), xRow)
            If getColumnIndex(spr, "MaterialAMTSales") > -1 Then z7109.MaterialAMTSales = getDataM(spr, getColumnIndex(spr, "MaterialAMTSales"), xRow)
            If getColumnIndex(spr, "seSubProcess") > -1 Then z7109.seSubProcess = getDataM(spr, getColumnIndex(spr, "seSubProcess"), xRow)
            If getColumnIndex(spr, "cdSubProcess") > -1 Then z7109.cdSubProcess = getDataM(spr, getColumnIndex(spr, "cdSubProcess"), xRow)
            If getColumnIndex(spr, "seSpecialProcess") > -1 Then z7109.seSpecialProcess = getDataM(spr, getColumnIndex(spr, "seSpecialProcess"), xRow)
            If getColumnIndex(spr, "cdSpecialProcess") > -1 Then z7109.cdSpecialProcess = getDataM(spr, getColumnIndex(spr, "cdSpecialProcess"), xRow)
            If getColumnIndex(spr, "CheckMark") > -1 Then z7109.CheckMark = getDataM(spr, getColumnIndex(spr, "CheckMark"), xRow)
            If getColumnIndex(spr, "CheckUse") > -1 Then z7109.CheckUse = getDataM(spr, getColumnIndex(spr, "CheckUse"), xRow)
            If getColumnIndex(spr, "CheckP1") > -1 Then z7109.CheckP1 = getDataM(spr, getColumnIndex(spr, "CheckP1"), xRow)
            If getColumnIndex(spr, "CheckP2") > -1 Then z7109.CheckP2 = getDataM(spr, getColumnIndex(spr, "CheckP2"), xRow)
            If getColumnIndex(spr, "CheckP3") > -1 Then z7109.CheckP3 = getDataM(spr, getColumnIndex(spr, "CheckP3"), xRow)
            If getColumnIndex(spr, "CheckP4") > -1 Then z7109.CheckP4 = getDataM(spr, getColumnIndex(spr, "CheckP4"), xRow)
            If getColumnIndex(spr, "CheckP5") > -1 Then z7109.CheckP5 = getDataM(spr, getColumnIndex(spr, "CheckP5"), xRow)
            If getColumnIndex(spr, "CheckP6") > -1 Then z7109.CheckP6 = getDataM(spr, getColumnIndex(spr, "CheckP6"), xRow)
            If getColumnIndex(spr, "CheckP7") > -1 Then z7109.CheckP7 = getDataM(spr, getColumnIndex(spr, "CheckP7"), xRow)
            If getColumnIndex(spr, "CheckP8") > -1 Then z7109.CheckP8 = getDataM(spr, getColumnIndex(spr, "CheckP8"), xRow)
            If getColumnIndex(spr, "CheckP9") > -1 Then z7109.CheckP9 = getDataM(spr, getColumnIndex(spr, "CheckP9"), xRow)
            If getColumnIndex(spr, "CheckUse1") > -1 Then z7109.CheckUse1 = getDataM(spr, getColumnIndex(spr, "CheckUse1"), xRow)
            If getColumnIndex(spr, "CheckMatching") > -1 Then z7109.CheckMatching = getDataM(spr, getColumnIndex(spr, "CheckMatching"), xRow)
            If getColumnIndex(spr, "Remark") > -1 Then z7109.Remark = getDataM(spr, getColumnIndex(spr, "Remark"), xRow)
            If getColumnIndex(spr, "MaterialCode_K3011") > -1 Then z7109.MaterialCode_K3011 = getDataM(spr, getColumnIndex(spr, "MaterialCode_K3011"), xRow)
            If getColumnIndex(spr, "seSite") > -1 Then z7109.seSite = getDataM(spr, getColumnIndex(spr, "seSite"), xRow)
            If getColumnIndex(spr, "cdSite") > -1 Then z7109.cdSite = getDataM(spr, getColumnIndex(spr, "cdSite"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7109_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K7109_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z7109 As T7109_AREA, CheckClear As Boolean, GROUPCOMPONENTBOM As String, GROUPCOMPONENTSEQ As Double) As Boolean

        K7109_MOVE = False

        Try
            If READ_PFK7109(GROUPCOMPONENTBOM, GROUPCOMPONENTSEQ) = True Then
                z7109 = D7109
                K7109_MOVE = True
            Else
                If CheckClear = True Then z7109 = Nothing
            End If

            If getColumnIndex(spr, "GroupComponentBOM") > -1 Then z7109.GroupComponentBOM = getDataM(spr, getColumnIndex(spr, "GroupComponentBOM"), xRow)
            If getColumnIndex(spr, "GroupComponentSeq") > -1 Then z7109.GroupComponentSeq = getDataM(spr, getColumnIndex(spr, "GroupComponentSeq"), xRow)
            If getColumnIndex(spr, "Dseq") > -1 Then z7109.Dseq = getDataM(spr, getColumnIndex(spr, "Dseq"), xRow)
            If getColumnIndex(spr, "ProcessSeq") > -1 Then z7109.ProcessSeq = getDataM(spr, getColumnIndex(spr, "ProcessSeq"), xRow)
            If getColumnIndex(spr, "CustomerCode") > -1 Then z7109.CustomerCode = getDataM(spr, getColumnIndex(spr, "CustomerCode"), xRow)
            If getColumnIndex(spr, "selGroupComponent") > -1 Then z7109.selGroupComponent = getDataM(spr, getColumnIndex(spr, "selGroupComponent"), xRow)
            If getColumnIndex(spr, "cdGroupComponent") > -1 Then z7109.cdGroupComponent = getDataM(spr, getColumnIndex(spr, "cdGroupComponent"), xRow)
            If getColumnIndex(spr, "ComponentName") > -1 Then z7109.ComponentName = getDataM(spr, getColumnIndex(spr, "ComponentName"), xRow)
            If getColumnIndex(spr, "MaterialCode") > -1 Then z7109.MaterialCode = getDataM(spr, getColumnIndex(spr, "MaterialCode"), xRow)
            If getColumnIndex(spr, "seUnitMaterial") > -1 Then z7109.seUnitMaterial = getDataM(spr, getColumnIndex(spr, "seUnitMaterial"), xRow)
            If getColumnIndex(spr, "cdUnitMaterial") > -1 Then z7109.cdUnitMaterial = getDataM(spr, getColumnIndex(spr, "cdUnitMaterial"), xRow)
            If getColumnIndex(spr, "Specification") > -1 Then z7109.Specification = getDataM(spr, getColumnIndex(spr, "Specification"), xRow)
            If getColumnIndex(spr, "Width") > -1 Then z7109.Width = getDataM(spr, getColumnIndex(spr, "Width"), xRow)
            If getColumnIndex(spr, "WidthID") > -1 Then z7109.WidthID = getDataM(spr, getColumnIndex(spr, "WidthID"), xRow)
            If getColumnIndex(spr, "Height") > -1 Then z7109.Height = getDataM(spr, getColumnIndex(spr, "Height"), xRow)
            If getColumnIndex(spr, "SizeName") > -1 Then z7109.SizeName = getDataM(spr, getColumnIndex(spr, "SizeName"), xRow)
            If getColumnIndex(spr, "cdColorCode") > -1 Then z7109.cdColorCode = getDataM(spr, getColumnIndex(spr, "cdColorCode"), xRow)
            If getColumnIndex(spr, "ColorCode") > -1 Then z7109.ColorCode = getDataM(spr, getColumnIndex(spr, "ColorCode"), xRow)
            If getColumnIndex(spr, "ColorName") > -1 Then z7109.ColorName = getDataM(spr, getColumnIndex(spr, "ColorName"), xRow)
            If getColumnIndex(spr, "seShoesStatus") > -1 Then z7109.seShoesStatus = getDataM(spr, getColumnIndex(spr, "seShoesStatus"), xRow)
            If getColumnIndex(spr, "cdShoesStatus") > -1 Then z7109.cdShoesStatus = getDataM(spr, getColumnIndex(spr, "cdShoesStatus"), xRow)
            If getColumnIndex(spr, "seDepartment") > -1 Then z7109.seDepartment = getDataM(spr, getColumnIndex(spr, "seDepartment"), xRow)
            If getColumnIndex(spr, "cdDepartment") > -1 Then z7109.cdDepartment = getDataM(spr, getColumnIndex(spr, "cdDepartment"), xRow)
            If getColumnIndex(spr, "ContractID") > -1 Then z7109.ContractID = getDataM(spr, getColumnIndex(spr, "ContractID"), xRow)
            If getColumnIndex(spr, "ContracSeq") > -1 Then z7109.ContracSeq = getDataM(spr, getColumnIndex(spr, "ContracSeq"), xRow)
            If getColumnIndex(spr, "SupplierCode") > -1 Then z7109.SupplierCode = getDataM(spr, getColumnIndex(spr, "SupplierCode"), xRow)
            If getColumnIndex(spr, "PriceMaterial") > -1 Then z7109.PriceMaterial = getDataM(spr, getColumnIndex(spr, "PriceMaterial"), xRow)
            If getColumnIndex(spr, "ExchangeCost") > -1 Then z7109.ExchangeCost = getDataM(spr, getColumnIndex(spr, "ExchangeCost"), xRow)
            If getColumnIndex(spr, "ComplicationCost") > -1 Then z7109.ComplicationCost = getDataM(spr, getColumnIndex(spr, "ComplicationCost"), xRow)
            If getColumnIndex(spr, "AddedCost") > -1 Then z7109.AddedCost = getDataM(spr, getColumnIndex(spr, "AddedCost"), xRow)
            If getColumnIndex(spr, "ShippingRate") > -1 Then z7109.ShippingRate = getDataM(spr, getColumnIndex(spr, "ShippingRate"), xRow)
            If getColumnIndex(spr, "ShippingCost") > -1 Then z7109.ShippingCost = getDataM(spr, getColumnIndex(spr, "ShippingCost"), xRow)
            If getColumnIndex(spr, "PriceRnD") > -1 Then z7109.PriceRnD = getDataM(spr, getColumnIndex(spr, "PriceRnD"), xRow)
            If getColumnIndex(spr, "Price") > -1 Then z7109.Price = getDataM(spr, getColumnIndex(spr, "Price"), xRow)
            If getColumnIndex(spr, "seUnitPrice") > -1 Then z7109.seUnitPrice = getDataM(spr, getColumnIndex(spr, "seUnitPrice"), xRow)
            If getColumnIndex(spr, "cdUnitPrice") > -1 Then z7109.cdUnitPrice = getDataM(spr, getColumnIndex(spr, "cdUnitPrice"), xRow)
            If getColumnIndex(spr, "QtyComponent") > -1 Then z7109.QtyComponent = getDataM(spr, getColumnIndex(spr, "QtyComponent"), xRow)
            If getColumnIndex(spr, "Consumption") > -1 Then z7109.Consumption = getDataM(spr, getColumnIndex(spr, "Consumption"), xRow)
            If getColumnIndex(spr, "Loss") > -1 Then z7109.Loss = getDataM(spr, getColumnIndex(spr, "Loss"), xRow)
            If getColumnIndex(spr, "GrossUsage") > -1 Then z7109.GrossUsage = getDataM(spr, getColumnIndex(spr, "GrossUsage"), xRow)
            If getColumnIndex(spr, "MaterialAMT") > -1 Then z7109.MaterialAMT = getDataM(spr, getColumnIndex(spr, "MaterialAMT"), xRow)
            If getColumnIndex(spr, "MaterialAMTPurchasing") > -1 Then z7109.MaterialAMTPurchasing = getDataM(spr, getColumnIndex(spr, "MaterialAMTPurchasing"), xRow)
            If getColumnIndex(spr, "MaterialAMTSales") > -1 Then z7109.MaterialAMTSales = getDataM(spr, getColumnIndex(spr, "MaterialAMTSales"), xRow)
            If getColumnIndex(spr, "seSubProcess") > -1 Then z7109.seSubProcess = getDataM(spr, getColumnIndex(spr, "seSubProcess"), xRow)
            If getColumnIndex(spr, "cdSubProcess") > -1 Then z7109.cdSubProcess = getDataM(spr, getColumnIndex(spr, "cdSubProcess"), xRow)
            If getColumnIndex(spr, "seSpecialProcess") > -1 Then z7109.seSpecialProcess = getDataM(spr, getColumnIndex(spr, "seSpecialProcess"), xRow)
            If getColumnIndex(spr, "cdSpecialProcess") > -1 Then z7109.cdSpecialProcess = getDataM(spr, getColumnIndex(spr, "cdSpecialProcess"), xRow)
            If getColumnIndex(spr, "CheckMark") > -1 Then z7109.CheckMark = getDataM(spr, getColumnIndex(spr, "CheckMark"), xRow)
            If getColumnIndex(spr, "CheckUse") > -1 Then z7109.CheckUse = getDataM(spr, getColumnIndex(spr, "CheckUse"), xRow)
            If getColumnIndex(spr, "CheckP1") > -1 Then z7109.CheckP1 = getDataM(spr, getColumnIndex(spr, "CheckP1"), xRow)
            If getColumnIndex(spr, "CheckP2") > -1 Then z7109.CheckP2 = getDataM(spr, getColumnIndex(spr, "CheckP2"), xRow)
            If getColumnIndex(spr, "CheckP3") > -1 Then z7109.CheckP3 = getDataM(spr, getColumnIndex(spr, "CheckP3"), xRow)
            If getColumnIndex(spr, "CheckP4") > -1 Then z7109.CheckP4 = getDataM(spr, getColumnIndex(spr, "CheckP4"), xRow)
            If getColumnIndex(spr, "CheckP5") > -1 Then z7109.CheckP5 = getDataM(spr, getColumnIndex(spr, "CheckP5"), xRow)
            If getColumnIndex(spr, "CheckP6") > -1 Then z7109.CheckP6 = getDataM(spr, getColumnIndex(spr, "CheckP6"), xRow)
            If getColumnIndex(spr, "CheckP7") > -1 Then z7109.CheckP7 = getDataM(spr, getColumnIndex(spr, "CheckP7"), xRow)
            If getColumnIndex(spr, "CheckP8") > -1 Then z7109.CheckP8 = getDataM(spr, getColumnIndex(spr, "CheckP8"), xRow)
            If getColumnIndex(spr, "CheckP9") > -1 Then z7109.CheckP9 = getDataM(spr, getColumnIndex(spr, "CheckP9"), xRow)
            If getColumnIndex(spr, "CheckUse1") > -1 Then z7109.CheckUse1 = getDataM(spr, getColumnIndex(spr, "CheckUse1"), xRow)
            If getColumnIndex(spr, "CheckMatching") > -1 Then z7109.CheckMatching = getDataM(spr, getColumnIndex(spr, "CheckMatching"), xRow)
            If getColumnIndex(spr, "Remark") > -1 Then z7109.Remark = getDataM(spr, getColumnIndex(spr, "Remark"), xRow)
            If getColumnIndex(spr, "MaterialCode_K3011") > -1 Then z7109.MaterialCode_K3011 = getDataM(spr, getColumnIndex(spr, "MaterialCode_K3011"), xRow)
            If getColumnIndex(spr, "seSite") > -1 Then z7109.seSite = getDataM(spr, getColumnIndex(spr, "seSite"), xRow)
            If getColumnIndex(spr, "cdSite") > -1 Then z7109.cdSite = getDataM(spr, getColumnIndex(spr, "cdSite"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7109_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K7109_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z7109 As T7109_AREA, Job As String, GROUPCOMPONENTBOM As String, GROUPCOMPONENTSEQ As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K7109_MOVE = False

        Try
            If READ_PFK7109(GROUPCOMPONENTBOM, GROUPCOMPONENTSEQ) = True Then
                z7109 = D7109
                K7109_MOVE = True
            Else
                z7109 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7109")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "GROUPCOMPONENTBOM" : z7109.GroupComponentBOM = Children(i).Code
                                Case "GROUPCOMPONENTSEQ" : z7109.GroupComponentSeq = Children(i).Code
                                Case "DSEQ" : z7109.Dseq = Children(i).Code
                                Case "PROCESSSEQ" : z7109.ProcessSeq = Children(i).Code
                                Case "CUSTOMERCODE" : z7109.CustomerCode = Children(i).Code
                                Case "SELGROUPCOMPONENT" : z7109.selGroupComponent = Children(i).Code
                                Case "CDGROUPCOMPONENT" : z7109.cdGroupComponent = Children(i).Code
                                Case "COMPONENTNAME" : z7109.ComponentName = Children(i).Code
                                Case "MATERIALCODE" : z7109.MaterialCode = Children(i).Code
                                Case "SEUNITMATERIAL" : z7109.seUnitMaterial = Children(i).Code
                                Case "CDUNITMATERIAL" : z7109.cdUnitMaterial = Children(i).Code
                                Case "SPECIFICATION" : z7109.Specification = Children(i).Code
                                Case "WIDTH" : z7109.Width = Children(i).Code
                                Case "WIDTHID" : z7109.WidthID = Children(i).Code
                                Case "HEIGHT" : z7109.Height = Children(i).Code
                                Case "SIZENAME" : z7109.SizeName = Children(i).Code
                                Case "CDCOLORCODE" : z7109.cdColorCode = Children(i).Code
                                Case "COLORCODE" : z7109.ColorCode = Children(i).Code
                                Case "COLORNAME" : z7109.ColorName = Children(i).Code
                                Case "SESHOESSTATUS" : z7109.seShoesStatus = Children(i).Code
                                Case "CDSHOESSTATUS" : z7109.cdShoesStatus = Children(i).Code
                                Case "SEDEPARTMENT" : z7109.seDepartment = Children(i).Code
                                Case "CDDEPARTMENT" : z7109.cdDepartment = Children(i).Code
                                Case "CONTRACTID" : z7109.ContractID = Children(i).Code
                                Case "ContracSeq" : z7109.ContracSeq = Children(i).Code
                                Case "SUPPLIERCODE" : z7109.SupplierCode = Children(i).Code
                                Case "PRICEMATERIAL" : z7109.PriceMaterial = Children(i).Code
                                Case "EXCHANGECOST" : z7109.ExchangeCost = Children(i).Code
                                Case "COMPLICATIONCOST" : z7109.ComplicationCost = Children(i).Code
                                Case "ADDEDCOST" : z7109.AddedCost = Children(i).Code
                                Case "SHIPPINGRATE" : z7109.ShippingRate = Children(i).Code
                                Case "SHIPPINGCOST" : z7109.ShippingCost = Children(i).Code
                                Case "PRICERND" : z7109.PriceRnD = Children(i).Code
                                Case "PRICE" : z7109.Price = Children(i).Code
                                Case "SEUNITPRICE" : z7109.seUnitPrice = Children(i).Code
                                Case "CDUNITPRICE" : z7109.cdUnitPrice = Children(i).Code
                                Case "QTYCOMPONENT" : z7109.QtyComponent = Children(i).Code
                                Case "CONSUMPTION" : z7109.Consumption = Children(i).Code
                                Case "LOSS" : z7109.Loss = Children(i).Code
                                Case "GROSSUSAGE" : z7109.GrossUsage = Children(i).Code
                                Case "MATERIALAMT" : z7109.MaterialAMT = Children(i).Code
                                Case "MATERIALAMTPURCHASING" : z7109.MaterialAMTPurchasing = Children(i).Code
                                Case "MATERIALAMTSALES" : z7109.MaterialAMTSales = Children(i).Code
                                Case "SESUBPROCESS" : z7109.seSubProcess = Children(i).Code
                                Case "CDSUBPROCESS" : z7109.cdSubProcess = Children(i).Code
                                Case "SESPECIALPROCESS" : z7109.seSpecialProcess = Children(i).Code
                                Case "CDSPECIALPROCESS" : z7109.cdSpecialProcess = Children(i).Code
                                Case "CHECKMARK" : z7109.CheckMark = Children(i).Code
                                Case "CHECKUSE" : z7109.CheckUse = Children(i).Code
                                Case "CHECKP1" : z7109.CheckP1 = Children(i).Code
                                Case "CHECKP2" : z7109.CheckP2 = Children(i).Code
                                Case "CHECKP3" : z7109.CheckP3 = Children(i).Code
                                Case "CHECKP4" : z7109.CheckP4 = Children(i).Code
                                Case "CHECKP5" : z7109.CheckP5 = Children(i).Code
                                Case "CHECKP6" : z7109.CheckP6 = Children(i).Code
                                Case "CHECKP7" : z7109.CheckP7 = Children(i).Code
                                Case "CHECKP8" : z7109.CheckP8 = Children(i).Code
                                Case "CHECKP9" : z7109.CheckP9 = Children(i).Code
                                Case "CHECKUSE1" : z7109.CheckUse1 = Children(i).Code
                                Case "CHECKMATCHING" : z7109.CheckMatching = Children(i).Code
                                Case "REMARK" : z7109.Remark = Children(i).Code
                                Case "MATERIALCODE_K3011" : z7109.MaterialCode_K3011 = Children(i).Code
                                Case "SESITE" : z7109.seSite = Children(i).Code
                                Case "CDSITE" : z7109.cdSite = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "GROUPCOMPONENTBOM" : z7109.GroupComponentBOM = Children(i).Data
                                Case "GROUPCOMPONENTSEQ" : z7109.GroupComponentSeq = Children(i).Data
                                Case "DSEQ" : z7109.Dseq = Children(i).Data
                                Case "PROCESSSEQ" : z7109.ProcessSeq = Children(i).Data
                                Case "CUSTOMERCODE" : z7109.CustomerCode = Children(i).Data
                                Case "SELGROUPCOMPONENT" : z7109.selGroupComponent = Children(i).Data
                                Case "CDGROUPCOMPONENT" : z7109.cdGroupComponent = Children(i).Data
                                Case "COMPONENTNAME" : z7109.ComponentName = Children(i).Data
                                Case "MATERIALCODE" : z7109.MaterialCode = Children(i).Data
                                Case "SEUNITMATERIAL" : z7109.seUnitMaterial = Children(i).Data
                                Case "CDUNITMATERIAL" : z7109.cdUnitMaterial = Children(i).Data
                                Case "SPECIFICATION" : z7109.Specification = Children(i).Data
                                Case "WIDTH" : z7109.Width = Children(i).Data
                                Case "WIDTHID" : z7109.WidthID = Children(i).Data
                                Case "HEIGHT" : z7109.Height = Children(i).Data
                                Case "SIZENAME" : z7109.SizeName = Children(i).Data
                                Case "CDCOLORCODE" : z7109.cdColorCode = Children(i).Data
                                Case "COLORCODE" : z7109.ColorCode = Children(i).Data
                                Case "COLORNAME" : z7109.ColorName = Children(i).Data
                                Case "SESHOESSTATUS" : z7109.seShoesStatus = Children(i).Data
                                Case "CDSHOESSTATUS" : z7109.cdShoesStatus = Children(i).Data
                                Case "SEDEPARTMENT" : z7109.seDepartment = Children(i).Data
                                Case "CDDEPARTMENT" : z7109.cdDepartment = Children(i).Data
                                Case "CONTRACTID" : z7109.ContractID = Children(i).Data
                                Case "ContracSeq" : z7109.ContracSeq = Children(i).Data
                                Case "SUPPLIERCODE" : z7109.SupplierCode = Children(i).Data
                                Case "PRICEMATERIAL" : z7109.PriceMaterial = Children(i).Data
                                Case "EXCHANGECOST" : z7109.ExchangeCost = Children(i).Data
                                Case "COMPLICATIONCOST" : z7109.ComplicationCost = Children(i).Data
                                Case "ADDEDCOST" : z7109.AddedCost = Children(i).Data
                                Case "SHIPPINGRATE" : z7109.ShippingRate = Children(i).Data
                                Case "SHIPPINGCOST" : z7109.ShippingCost = Children(i).Data
                                Case "PRICERND" : z7109.PriceRnD = Children(i).Data
                                Case "PRICE" : z7109.Price = Children(i).Data
                                Case "SEUNITPRICE" : z7109.seUnitPrice = Children(i).Data
                                Case "CDUNITPRICE" : z7109.cdUnitPrice = Children(i).Data
                                Case "QTYCOMPONENT" : z7109.QtyComponent = Children(i).Data
                                Case "CONSUMPTION" : z7109.Consumption = Children(i).Data
                                Case "LOSS" : z7109.Loss = Children(i).Data
                                Case "GROSSUSAGE" : z7109.GrossUsage = Children(i).Data
                                Case "MATERIALAMT" : z7109.MaterialAMT = Children(i).Data
                                Case "MATERIALAMTPURCHASING" : z7109.MaterialAMTPurchasing = Children(i).Data
                                Case "MATERIALAMTSALES" : z7109.MaterialAMTSales = Children(i).Data
                                Case "SESUBPROCESS" : z7109.seSubProcess = Children(i).Data
                                Case "CDSUBPROCESS" : z7109.cdSubProcess = Children(i).Data
                                Case "SESPECIALPROCESS" : z7109.seSpecialProcess = Children(i).Data
                                Case "CDSPECIALPROCESS" : z7109.cdSpecialProcess = Children(i).Data
                                Case "CHECKMARK" : z7109.CheckMark = Children(i).Data
                                Case "CHECKUSE" : z7109.CheckUse = Children(i).Data
                                Case "CHECKP1" : z7109.CheckP1 = Children(i).Data
                                Case "CHECKP2" : z7109.CheckP2 = Children(i).Data
                                Case "CHECKP3" : z7109.CheckP3 = Children(i).Data
                                Case "CHECKP4" : z7109.CheckP4 = Children(i).Data
                                Case "CHECKP5" : z7109.CheckP5 = Children(i).Data
                                Case "CHECKP6" : z7109.CheckP6 = Children(i).Data
                                Case "CHECKP7" : z7109.CheckP7 = Children(i).Data
                                Case "CHECKP8" : z7109.CheckP8 = Children(i).Data
                                Case "CHECKP9" : z7109.CheckP9 = Children(i).Data
                                Case "CHECKUSE1" : z7109.CheckUse1 = Children(i).Data
                                Case "CHECKMATCHING" : z7109.CheckMatching = Children(i).Data
                                Case "REMARK" : z7109.Remark = Children(i).Data
                                Case "MATERIALCODE_K3011" : z7109.MaterialCode_K3011 = Children(i).Data
                                Case "SESITE" : z7109.seSite = Children(i).Data
                                Case "CDSITE" : z7109.cdSite = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7109_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K7109_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z7109 As T7109_AREA, Job As String, CheckClear As Boolean, GROUPCOMPONENTBOM As String, GROUPCOMPONENTSEQ As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K7109_MOVE = False

        Try
            If READ_PFK7109(GROUPCOMPONENTBOM, GROUPCOMPONENTSEQ) = True Then
                z7109 = D7109
                K7109_MOVE = True
            Else
                If CheckClear = True Then z7109 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7109")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "GROUPCOMPONENTBOM" : z7109.GroupComponentBOM = Children(i).Code
                                Case "GROUPCOMPONENTSEQ" : z7109.GroupComponentSeq = Children(i).Code
                                Case "DSEQ" : z7109.Dseq = Children(i).Code
                                Case "PROCESSSEQ" : z7109.ProcessSeq = Children(i).Code
                                Case "CUSTOMERCODE" : z7109.CustomerCode = Children(i).Code
                                Case "SELGROUPCOMPONENT" : z7109.selGroupComponent = Children(i).Code
                                Case "CDGROUPCOMPONENT" : z7109.cdGroupComponent = Children(i).Code
                                Case "COMPONENTNAME" : z7109.ComponentName = Children(i).Code
                                Case "MATERIALCODE" : z7109.MaterialCode = Children(i).Code
                                Case "SEUNITMATERIAL" : z7109.seUnitMaterial = Children(i).Code
                                Case "CDUNITMATERIAL" : z7109.cdUnitMaterial = Children(i).Code
                                Case "SPECIFICATION" : z7109.Specification = Children(i).Code
                                Case "WIDTH" : z7109.Width = Children(i).Code
                                Case "WIDTHID" : z7109.WidthID = Children(i).Code
                                Case "HEIGHT" : z7109.Height = Children(i).Code
                                Case "SIZENAME" : z7109.SizeName = Children(i).Code
                                Case "CDCOLORCODE" : z7109.cdColorCode = Children(i).Code
                                Case "COLORCODE" : z7109.ColorCode = Children(i).Code
                                Case "COLORNAME" : z7109.ColorName = Children(i).Code
                                Case "SESHOESSTATUS" : z7109.seShoesStatus = Children(i).Code
                                Case "CDSHOESSTATUS" : z7109.cdShoesStatus = Children(i).Code
                                Case "SEDEPARTMENT" : z7109.seDepartment = Children(i).Code
                                Case "CDDEPARTMENT" : z7109.cdDepartment = Children(i).Code
                                Case "CONTRACTID" : z7109.ContractID = Children(i).Code
                                Case "ContracSeq" : z7109.ContracSeq = Children(i).Code
                                Case "SUPPLIERCODE" : z7109.SupplierCode = Children(i).Code
                                Case "PRICEMATERIAL" : z7109.PriceMaterial = Children(i).Code
                                Case "EXCHANGECOST" : z7109.ExchangeCost = Children(i).Code
                                Case "COMPLICATIONCOST" : z7109.ComplicationCost = Children(i).Code
                                Case "ADDEDCOST" : z7109.AddedCost = Children(i).Code
                                Case "SHIPPINGRATE" : z7109.ShippingRate = Children(i).Code
                                Case "SHIPPINGCOST" : z7109.ShippingCost = Children(i).Code
                                Case "PRICERND" : z7109.PriceRnD = Children(i).Code
                                Case "PRICE" : z7109.Price = Children(i).Code
                                Case "SEUNITPRICE" : z7109.seUnitPrice = Children(i).Code
                                Case "CDUNITPRICE" : z7109.cdUnitPrice = Children(i).Code
                                Case "QTYCOMPONENT" : z7109.QtyComponent = Children(i).Code
                                Case "CONSUMPTION" : z7109.Consumption = Children(i).Code
                                Case "LOSS" : z7109.Loss = Children(i).Code
                                Case "GROSSUSAGE" : z7109.GrossUsage = Children(i).Code
                                Case "MATERIALAMT" : z7109.MaterialAMT = Children(i).Code
                                Case "MATERIALAMTPURCHASING" : z7109.MaterialAMTPurchasing = Children(i).Code
                                Case "MATERIALAMTSALES" : z7109.MaterialAMTSales = Children(i).Code
                                Case "SESUBPROCESS" : z7109.seSubProcess = Children(i).Code
                                Case "CDSUBPROCESS" : z7109.cdSubProcess = Children(i).Code
                                Case "SESPECIALPROCESS" : z7109.seSpecialProcess = Children(i).Code
                                Case "CDSPECIALPROCESS" : z7109.cdSpecialProcess = Children(i).Code
                                Case "CHECKMARK" : z7109.CheckMark = Children(i).Code
                                Case "CHECKUSE" : z7109.CheckUse = Children(i).Code
                                Case "CHECKP1" : z7109.CheckP1 = Children(i).Code
                                Case "CHECKP2" : z7109.CheckP2 = Children(i).Code
                                Case "CHECKP3" : z7109.CheckP3 = Children(i).Code
                                Case "CHECKP4" : z7109.CheckP4 = Children(i).Code
                                Case "CHECKP5" : z7109.CheckP5 = Children(i).Code
                                Case "CHECKP6" : z7109.CheckP6 = Children(i).Code
                                Case "CHECKP7" : z7109.CheckP7 = Children(i).Code
                                Case "CHECKP8" : z7109.CheckP8 = Children(i).Code
                                Case "CHECKP9" : z7109.CheckP9 = Children(i).Code
                                Case "CHECKUSE1" : z7109.CheckUse1 = Children(i).Code
                                Case "CHECKMATCHING" : z7109.CheckMatching = Children(i).Code
                                Case "REMARK" : z7109.Remark = Children(i).Code
                                Case "MATERIALCODE_K3011" : z7109.MaterialCode_K3011 = Children(i).Code
                                Case "SESITE" : z7109.seSite = Children(i).Code
                                Case "CDSITE" : z7109.cdSite = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "GROUPCOMPONENTBOM" : z7109.GroupComponentBOM = Children(i).Data
                                Case "GROUPCOMPONENTSEQ" : z7109.GroupComponentSeq = Children(i).Data
                                Case "DSEQ" : z7109.Dseq = Children(i).Data
                                Case "PROCESSSEQ" : z7109.ProcessSeq = Children(i).Data
                                Case "CUSTOMERCODE" : z7109.CustomerCode = Children(i).Data
                                Case "SELGROUPCOMPONENT" : z7109.selGroupComponent = Children(i).Data
                                Case "CDGROUPCOMPONENT" : z7109.cdGroupComponent = Children(i).Data
                                Case "COMPONENTNAME" : z7109.ComponentName = Children(i).Data
                                Case "MATERIALCODE" : z7109.MaterialCode = Children(i).Data
                                Case "SEUNITMATERIAL" : z7109.seUnitMaterial = Children(i).Data
                                Case "CDUNITMATERIAL" : z7109.cdUnitMaterial = Children(i).Data
                                Case "SPECIFICATION" : z7109.Specification = Children(i).Data
                                Case "WIDTH" : z7109.Width = Children(i).Data
                                Case "WIDTHID" : z7109.WidthID = Children(i).Data
                                Case "HEIGHT" : z7109.Height = Children(i).Data
                                Case "SIZENAME" : z7109.SizeName = Children(i).Data
                                Case "CDCOLORCODE" : z7109.cdColorCode = Children(i).Data
                                Case "COLORCODE" : z7109.ColorCode = Children(i).Data
                                Case "COLORNAME" : z7109.ColorName = Children(i).Data
                                Case "SESHOESSTATUS" : z7109.seShoesStatus = Children(i).Data
                                Case "CDSHOESSTATUS" : z7109.cdShoesStatus = Children(i).Data
                                Case "SEDEPARTMENT" : z7109.seDepartment = Children(i).Data
                                Case "CDDEPARTMENT" : z7109.cdDepartment = Children(i).Data
                                Case "CONTRACTID" : z7109.ContractID = Children(i).Data
                                Case "ContracSeq" : z7109.ContracSeq = Children(i).Data
                                Case "SUPPLIERCODE" : z7109.SupplierCode = Children(i).Data
                                Case "PRICEMATERIAL" : z7109.PriceMaterial = Children(i).Data
                                Case "EXCHANGECOST" : z7109.ExchangeCost = Children(i).Data
                                Case "COMPLICATIONCOST" : z7109.ComplicationCost = Children(i).Data
                                Case "ADDEDCOST" : z7109.AddedCost = Children(i).Data
                                Case "SHIPPINGRATE" : z7109.ShippingRate = Children(i).Data
                                Case "SHIPPINGCOST" : z7109.ShippingCost = Children(i).Data
                                Case "PRICERND" : z7109.PriceRnD = Children(i).Data
                                Case "PRICE" : z7109.Price = Children(i).Data
                                Case "SEUNITPRICE" : z7109.seUnitPrice = Children(i).Data
                                Case "CDUNITPRICE" : z7109.cdUnitPrice = Children(i).Data
                                Case "QTYCOMPONENT" : z7109.QtyComponent = Children(i).Data
                                Case "CONSUMPTION" : z7109.Consumption = Children(i).Data
                                Case "LOSS" : z7109.Loss = Children(i).Data
                                Case "GROSSUSAGE" : z7109.GrossUsage = Children(i).Data
                                Case "MATERIALAMT" : z7109.MaterialAMT = Children(i).Data
                                Case "MATERIALAMTPURCHASING" : z7109.MaterialAMTPurchasing = Children(i).Data
                                Case "MATERIALAMTSALES" : z7109.MaterialAMTSales = Children(i).Data
                                Case "SESUBPROCESS" : z7109.seSubProcess = Children(i).Data
                                Case "CDSUBPROCESS" : z7109.cdSubProcess = Children(i).Data
                                Case "SESPECIALPROCESS" : z7109.seSpecialProcess = Children(i).Data
                                Case "CDSPECIALPROCESS" : z7109.cdSpecialProcess = Children(i).Data
                                Case "CHECKMARK" : z7109.CheckMark = Children(i).Data
                                Case "CHECKUSE" : z7109.CheckUse = Children(i).Data
                                Case "CHECKP1" : z7109.CheckP1 = Children(i).Data
                                Case "CHECKP2" : z7109.CheckP2 = Children(i).Data
                                Case "CHECKP3" : z7109.CheckP3 = Children(i).Data
                                Case "CHECKP4" : z7109.CheckP4 = Children(i).Data
                                Case "CHECKP5" : z7109.CheckP5 = Children(i).Data
                                Case "CHECKP6" : z7109.CheckP6 = Children(i).Data
                                Case "CHECKP7" : z7109.CheckP7 = Children(i).Data
                                Case "CHECKP8" : z7109.CheckP8 = Children(i).Data
                                Case "CHECKP9" : z7109.CheckP9 = Children(i).Data
                                Case "CHECKUSE1" : z7109.CheckUse1 = Children(i).Data
                                Case "CHECKMATCHING" : z7109.CheckMatching = Children(i).Data
                                Case "REMARK" : z7109.Remark = Children(i).Data
                                Case "MATERIALCODE_K3011" : z7109.MaterialCode_K3011 = Children(i).Data
                                Case "SESITE" : z7109.seSite = Children(i).Data
                                Case "CDSITE" : z7109.cdSite = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7109_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW AREA
    '=========================================================================================================================================================
    Public Sub K7109_MOVE(ByRef a7109 As T7109_AREA, ByRef b7109 As T7109_AREA)
        Try
            If trim$(a7109.GroupComponentBOM) = "" Then b7109.GroupComponentBOM = "" Else b7109.GroupComponentBOM = a7109.GroupComponentBOM
            If trim$(a7109.GroupComponentSeq) = "" Then b7109.GroupComponentSeq = "" Else b7109.GroupComponentSeq = a7109.GroupComponentSeq
            If trim$(a7109.Dseq) = "" Then b7109.Dseq = "" Else b7109.Dseq = a7109.Dseq
            If trim$(a7109.ProcessSeq) = "" Then b7109.ProcessSeq = "" Else b7109.ProcessSeq = a7109.ProcessSeq
            If trim$(a7109.CustomerCode) = "" Then b7109.CustomerCode = "" Else b7109.CustomerCode = a7109.CustomerCode
            If trim$(a7109.selGroupComponent) = "" Then b7109.selGroupComponent = "" Else b7109.selGroupComponent = a7109.selGroupComponent
            If trim$(a7109.cdGroupComponent) = "" Then b7109.cdGroupComponent = "" Else b7109.cdGroupComponent = a7109.cdGroupComponent
            If trim$(a7109.ComponentName) = "" Then b7109.ComponentName = "" Else b7109.ComponentName = a7109.ComponentName
            If trim$(a7109.MaterialCode) = "" Then b7109.MaterialCode = "" Else b7109.MaterialCode = a7109.MaterialCode
            If trim$(a7109.seUnitMaterial) = "" Then b7109.seUnitMaterial = "" Else b7109.seUnitMaterial = a7109.seUnitMaterial
            If trim$(a7109.cdUnitMaterial) = "" Then b7109.cdUnitMaterial = "" Else b7109.cdUnitMaterial = a7109.cdUnitMaterial
            If trim$(a7109.Specification) = "" Then b7109.Specification = "" Else b7109.Specification = a7109.Specification
            If trim$(a7109.Width) = "" Then b7109.Width = "" Else b7109.Width = a7109.Width
            If trim$(a7109.WidthID) = "" Then b7109.WidthID = "" Else b7109.WidthID = a7109.WidthID
            If trim$(a7109.Height) = "" Then b7109.Height = "" Else b7109.Height = a7109.Height
            If trim$(a7109.SizeName) = "" Then b7109.SizeName = "" Else b7109.SizeName = a7109.SizeName
            If trim$(a7109.cdColorCode) = "" Then b7109.cdColorCode = "" Else b7109.cdColorCode = a7109.cdColorCode
            If trim$(a7109.ColorCode) = "" Then b7109.ColorCode = "" Else b7109.ColorCode = a7109.ColorCode
            If trim$(a7109.ColorName) = "" Then b7109.ColorName = "" Else b7109.ColorName = a7109.ColorName
            If trim$(a7109.seShoesStatus) = "" Then b7109.seShoesStatus = "" Else b7109.seShoesStatus = a7109.seShoesStatus
            If trim$(a7109.cdShoesStatus) = "" Then b7109.cdShoesStatus = "" Else b7109.cdShoesStatus = a7109.cdShoesStatus
            If trim$(a7109.seDepartment) = "" Then b7109.seDepartment = "" Else b7109.seDepartment = a7109.seDepartment
            If trim$(a7109.cdDepartment) = "" Then b7109.cdDepartment = "" Else b7109.cdDepartment = a7109.cdDepartment
            If trim$(a7109.ContractID) = "" Then b7109.ContractID = "" Else b7109.ContractID = a7109.ContractID
            If trim$(a7109.ContracSeq) = "" Then b7109.ContracSeq = "" Else b7109.ContracSeq = a7109.ContracSeq
If trim$( a7109.SupplierCode ) = "" Then b7109.SupplierCode = ""  Else b7109.SupplierCode=a7109.SupplierCode
If trim$( a7109.PriceMaterial ) = "" Then b7109.PriceMaterial = ""  Else b7109.PriceMaterial=a7109.PriceMaterial
If trim$( a7109.ExchangeCost ) = "" Then b7109.ExchangeCost = ""  Else b7109.ExchangeCost=a7109.ExchangeCost
If trim$( a7109.ComplicationCost ) = "" Then b7109.ComplicationCost = ""  Else b7109.ComplicationCost=a7109.ComplicationCost
If trim$( a7109.AddedCost ) = "" Then b7109.AddedCost = ""  Else b7109.AddedCost=a7109.AddedCost
If trim$( a7109.ShippingRate ) = "" Then b7109.ShippingRate = ""  Else b7109.ShippingRate=a7109.ShippingRate
If trim$( a7109.ShippingCost ) = "" Then b7109.ShippingCost = ""  Else b7109.ShippingCost=a7109.ShippingCost
If trim$( a7109.PriceRnD ) = "" Then b7109.PriceRnD = ""  Else b7109.PriceRnD=a7109.PriceRnD
If trim$( a7109.Price ) = "" Then b7109.Price = ""  Else b7109.Price=a7109.Price
If trim$( a7109.seUnitPrice ) = "" Then b7109.seUnitPrice = ""  Else b7109.seUnitPrice=a7109.seUnitPrice
If trim$( a7109.cdUnitPrice ) = "" Then b7109.cdUnitPrice = ""  Else b7109.cdUnitPrice=a7109.cdUnitPrice
If trim$( a7109.QtyComponent ) = "" Then b7109.QtyComponent = ""  Else b7109.QtyComponent=a7109.QtyComponent
If trim$( a7109.Consumption ) = "" Then b7109.Consumption = ""  Else b7109.Consumption=a7109.Consumption
If trim$( a7109.Loss ) = "" Then b7109.Loss = ""  Else b7109.Loss=a7109.Loss
If trim$( a7109.GrossUsage ) = "" Then b7109.GrossUsage = ""  Else b7109.GrossUsage=a7109.GrossUsage
If trim$( a7109.MaterialAMT ) = "" Then b7109.MaterialAMT = ""  Else b7109.MaterialAMT=a7109.MaterialAMT
If trim$( a7109.MaterialAMTPurchasing ) = "" Then b7109.MaterialAMTPurchasing = ""  Else b7109.MaterialAMTPurchasing=a7109.MaterialAMTPurchasing
If trim$( a7109.MaterialAMTSales ) = "" Then b7109.MaterialAMTSales = ""  Else b7109.MaterialAMTSales=a7109.MaterialAMTSales
If trim$( a7109.seSubProcess ) = "" Then b7109.seSubProcess = ""  Else b7109.seSubProcess=a7109.seSubProcess
If trim$( a7109.cdSubProcess ) = "" Then b7109.cdSubProcess = ""  Else b7109.cdSubProcess=a7109.cdSubProcess
If trim$( a7109.seSpecialProcess ) = "" Then b7109.seSpecialProcess = ""  Else b7109.seSpecialProcess=a7109.seSpecialProcess
If trim$( a7109.cdSpecialProcess ) = "" Then b7109.cdSpecialProcess = ""  Else b7109.cdSpecialProcess=a7109.cdSpecialProcess
If trim$( a7109.CheckMark ) = "" Then b7109.CheckMark = ""  Else b7109.CheckMark=a7109.CheckMark
If trim$( a7109.CheckUse ) = "" Then b7109.CheckUse = ""  Else b7109.CheckUse=a7109.CheckUse
If trim$( a7109.CheckP1 ) = "" Then b7109.CheckP1 = ""  Else b7109.CheckP1=a7109.CheckP1
If trim$( a7109.CheckP2 ) = "" Then b7109.CheckP2 = ""  Else b7109.CheckP2=a7109.CheckP2
If trim$( a7109.CheckP3 ) = "" Then b7109.CheckP3 = ""  Else b7109.CheckP3=a7109.CheckP3
If trim$( a7109.CheckP4 ) = "" Then b7109.CheckP4 = ""  Else b7109.CheckP4=a7109.CheckP4
If trim$( a7109.CheckP5 ) = "" Then b7109.CheckP5 = ""  Else b7109.CheckP5=a7109.CheckP5
If trim$( a7109.CheckP6 ) = "" Then b7109.CheckP6 = ""  Else b7109.CheckP6=a7109.CheckP6
If trim$( a7109.CheckP7 ) = "" Then b7109.CheckP7 = ""  Else b7109.CheckP7=a7109.CheckP7
If trim$( a7109.CheckP8 ) = "" Then b7109.CheckP8 = ""  Else b7109.CheckP8=a7109.CheckP8
If trim$( a7109.CheckP9 ) = "" Then b7109.CheckP9 = ""  Else b7109.CheckP9=a7109.CheckP9
If trim$( a7109.CheckUse1 ) = "" Then b7109.CheckUse1 = ""  Else b7109.CheckUse1=a7109.CheckUse1
If trim$( a7109.CheckMatching ) = "" Then b7109.CheckMatching = ""  Else b7109.CheckMatching=a7109.CheckMatching
If trim$( a7109.Remark ) = "" Then b7109.Remark = ""  Else b7109.Remark=a7109.Remark
If trim$( a7109.MaterialCode_K3011 ) = "" Then b7109.MaterialCode_K3011 = ""  Else b7109.MaterialCode_K3011=a7109.MaterialCode_K3011
            If Trim$(a7109.seSite) = "" Then b7109.seSite = "" Else b7109.seSite = a7109.seSite
If trim$( a7109.cdSite ) = "" Then b7109.cdSite = ""  Else b7109.cdSite=a7109.cdSite
Catch ex As Exception
      Call MsgBoxP("K7109_MOVE",vbCritical)
End Try
End Sub 


End Module 
