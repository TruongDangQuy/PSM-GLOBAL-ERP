'=========================================================================================================================================================
'   TABLE : (PFK1311)
'
'      WORKER : PSM GLOBAL ., LTD
'       WORK DATE : 2019 NEW
'       DEVELOPER    : MRNLV
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K1311

    Structure T1311_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public OrderNo As String  '			char(9)		*
        Public CustomerCode As String  '			char(6)
        Public VendorCode As String  '			char(6)
        Public AgentCode As String  '			char(6)
        Public Buyer As String  '			nvarchar(50)
        Public seOrderGroup As String  '			char(3)
        Public cdOrderGroup As String  '			char(3)
        Public seOrderKind As String  '			char(3)
        Public cdOrderKind As String  '			char(3)
        Public seOrderType As String  '			char(3)
        Public cdOrderType As String  '			char(3)
        Public cdOrderWork As String  '			char(3)
        Public seOrderWork As String  '			char(3)
        Public seStateSample As String  '			char(3)
        Public cdStateSample As String  '			char(3)
        Public seStateOfficial As String  '			char(3)
        Public cdStateOfficial As String  '			char(3)
        Public StatusOrder As String  '			char(1)
        Public DateOrder As String  '			char(8)
        Public DateApproval As String  '			char(8)
        Public DateComplete As String  '			char(8)
        Public DateCancel As String  '			char(8)
        Public DatePending As String  '			char(8)
        Public seUnitPrice As String  '			char(3)
        Public cdUnitPrice As String  '			char(3)
        Public PriceExchange As Double  '			decimal
        Public DateExchange As String  '			char(8)
        Public DateTransfer As String  '			char(8)
        Public DateAccept As String  '			char(8)
        Public StatusTransfer As String  '			char(1)
        Public CheckPKO As String  '			char(1)
        Public seSeason As String  '			char(3)
        Public cdSeason As String  '			char(3)
        Public seShippingTerm As String  '			char(3)
        Public cdShippingTerm As String  '			char(3)
        Public cdDeliveryTerm As String  '			char(3)
        Public seDeliveryTerm As String  '			char(3)
        Public sePaymentTerm As String  '			char(3)
        Public cdPaymentTerm As String  '			char(3)
        Public sePaymentCondition As String  '			char(3)
        Public cdPaymentCondition As String  '			char(3)
        Public sePaymentTime As String  '			char(3)
        Public cdPaymentTime As String  '			char(3)
        Public sePaymentDay As String  '			char(3)
        Public cdPaymentDay As String  '			char(3)
        Public seMarketType As String  '			char(3)
        Public cdMarketType As String  '			char(3)
        Public seDepartment As String  '			char(3)
        Public cdDepartment As String  '			char(3)
        Public seBrand As String  '			char(3)
        Public cdBrand As String  '			char(3)
        Public ContractIn As String  '			nvarchar(100)
        Public ContractOut As String  '			nvarchar(100)
        Public Destination As String  '			nvarchar(100)
        Public CustPoNo As String  '			nvarchar(100)
        Public CustPoNoParent As String  '			nvarchar(100)
        Public InchargeSales As String  '			char(8)
        Public InchargePPC As String  '			char(8)
        Public InchargeInsert As String  '			char(8)
        Public DateInsert As String  '			char(8)
        Public InchargeUpdate As String  '			char(8)
        Public DateUpdate As String  '			char(8)
        Public TimeInsert As String  '			char(14)
        Public TimeUpdate As String  '			char(14)
        Public TotalQty As Double  '			decimal
        Public TotalAmount As Double  '			decimal
        Public TotalCost As Double  '			decimal
        Public TotalProfit As Double  '			decimal
        Public AttachID As String  '			char(9)
        Public RemarkOrder As String  '			nvarchar(1000)
        Public RemarkCustomer As String  '			nvarchar(1000)
        Public Remark As String  '			nvarchar(1000)
        Public seSite As String  '			char(3)
        Public cdSite As String  '			char(3)
        '=========================================================================================================================================================
    End Structure

    Public D1311 As T1311_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK1311(ORDERNO As String) As Boolean
        READ_PFK1311 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK1311 "
            SQL = SQL & " WHERE K1311_OrderNo		 = '" & OrderNo & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D1311_CLEAR() : GoTo SKIP_READ_PFK1311

            Call K1311_MOVE(rd)
            READ_PFK1311 = True

SKIP_READ_PFK1311:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK1311", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK1311(ORDERNO As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK1311 "
            SQL = SQL & " WHERE K1311_OrderNo		 = '" & OrderNo & "' "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK1311", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK1311(z1311 As T1311_AREA) As Boolean
        WRITE_PFK1311 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z1311)

            SQL = " INSERT INTO PFK1311 "
            SQL = SQL & " ( "
            SQL = SQL & " K1311_OrderNo,"
            SQL = SQL & " K1311_CustomerCode,"
            SQL = SQL & " K1311_VendorCode,"
            SQL = SQL & " K1311_AgentCode,"
            SQL = SQL & " K1311_Buyer,"
            SQL = SQL & " K1311_seOrderGroup,"
            SQL = SQL & " K1311_cdOrderGroup,"
            SQL = SQL & " K1311_seOrderKind,"
            SQL = SQL & " K1311_cdOrderKind,"
            SQL = SQL & " K1311_seOrderType,"
            SQL = SQL & " K1311_cdOrderType,"
            SQL = SQL & " K1311_cdOrderWork,"
            SQL = SQL & " K1311_seOrderWork,"
            SQL = SQL & " K1311_seStateSample,"
            SQL = SQL & " K1311_cdStateSample,"
            SQL = SQL & " K1311_seStateOfficial,"
            SQL = SQL & " K1311_cdStateOfficial,"
            SQL = SQL & " K1311_StatusOrder,"
            SQL = SQL & " K1311_DateOrder,"
            SQL = SQL & " K1311_DateApproval,"
            SQL = SQL & " K1311_DateComplete,"
            SQL = SQL & " K1311_DateCancel,"
            SQL = SQL & " K1311_DatePending,"
            SQL = SQL & " K1311_seUnitPrice,"
            SQL = SQL & " K1311_cdUnitPrice,"
            SQL = SQL & " K1311_PriceExchange,"
            SQL = SQL & " K1311_DateExchange,"
            SQL = SQL & " K1311_DateTransfer,"
            SQL = SQL & " K1311_DateAccept,"
            SQL = SQL & " K1311_StatusTransfer,"
            SQL = SQL & " K1311_CheckPKO,"
            SQL = SQL & " K1311_seSeason,"
            SQL = SQL & " K1311_cdSeason,"
            SQL = SQL & " K1311_seShippingTerm,"
            SQL = SQL & " K1311_cdShippingTerm,"
            SQL = SQL & " K1311_cdDeliveryTerm,"
            SQL = SQL & " K1311_seDeliveryTerm,"
            SQL = SQL & " K1311_sePaymentTerm,"
            SQL = SQL & " K1311_cdPaymentTerm,"
            SQL = SQL & " K1311_sePaymentCondition,"
            SQL = SQL & " K1311_cdPaymentCondition,"
            SQL = SQL & " K1311_sePaymentTime,"
            SQL = SQL & " K1311_cdPaymentTime,"
            SQL = SQL & " K1311_sePaymentDay,"
            SQL = SQL & " K1311_cdPaymentDay,"
            SQL = SQL & " K1311_seMarketType,"
            SQL = SQL & " K1311_cdMarketType,"
            SQL = SQL & " K1311_seDepartment,"
            SQL = SQL & " K1311_cdDepartment,"
            SQL = SQL & " K1311_seBrand,"
            SQL = SQL & " K1311_cdBrand,"
            SQL = SQL & " K1311_ContractIn,"
            SQL = SQL & " K1311_ContractOut,"
            SQL = SQL & " K1311_Destination,"
            SQL = SQL & " K1311_CustPoNo,"
            SQL = SQL & " K1311_CustPoNoParent,"
            SQL = SQL & " K1311_InchargeSales,"
            SQL = SQL & " K1311_InchargePPC,"
            SQL = SQL & " K1311_InchargeInsert,"
            SQL = SQL & " K1311_DateInsert,"
            SQL = SQL & " K1311_InchargeUpdate,"
            SQL = SQL & " K1311_DateUpdate,"
            SQL = SQL & " K1311_TimeInsert,"
            SQL = SQL & " K1311_TimeUpdate,"
            SQL = SQL & " K1311_TotalQty,"
            SQL = SQL & " K1311_TotalAmount,"
            SQL = SQL & " K1311_TotalCost,"
            SQL = SQL & " K1311_TotalProfit,"
            SQL = SQL & " K1311_AttachID,"
            SQL = SQL & " K1311_RemarkOrder,"
            SQL = SQL & " K1311_RemarkCustomer,"
            SQL = SQL & " K1311_Remark,"
            SQL = SQL & " K1311_seSite,"
            SQL = SQL & " K1311_cdSite "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z1311.OrderNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1311.CustomerCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1311.VendorCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1311.AgentCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1311.Buyer) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1311.seOrderGroup) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1311.cdOrderGroup) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1311.seOrderKind) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1311.cdOrderKind) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1311.seOrderType) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1311.cdOrderType) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1311.cdOrderWork) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1311.seOrderWork) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1311.seStateSample) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1311.cdStateSample) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1311.seStateOfficial) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1311.cdStateOfficial) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1311.StatusOrder) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1311.DateOrder) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1311.DateApproval) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1311.DateComplete) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1311.DateCancel) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1311.DatePending) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1311.seUnitPrice) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1311.cdUnitPrice) & "', "
            SQL = SQL & "   " & FormatSQL(z1311.PriceExchange) & ", "
            SQL = SQL & "  N'" & FormatSQL(z1311.DateExchange) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1311.DateTransfer) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1311.DateAccept) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1311.StatusTransfer) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1311.CheckPKO) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1311.seSeason) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1311.cdSeason) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1311.seShippingTerm) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1311.cdShippingTerm) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1311.cdDeliveryTerm) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1311.seDeliveryTerm) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1311.sePaymentTerm) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1311.cdPaymentTerm) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1311.sePaymentCondition) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1311.cdPaymentCondition) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1311.sePaymentTime) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1311.cdPaymentTime) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1311.sePaymentDay) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1311.cdPaymentDay) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1311.seMarketType) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1311.cdMarketType) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1311.seDepartment) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1311.cdDepartment) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1311.seBrand) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1311.cdBrand) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1311.ContractIn) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1311.ContractOut) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1311.Destination) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1311.CustPoNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1311.CustPoNoParent) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1311.InchargeSales) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1311.InchargePPC) & "', "
            SQL = SQL & "  N'" & FormatSQL(PUB.SAW) & "', "
            SQL = SQL & "  N'" & FormatSQL(PUB.DAT) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1311.InchargeUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1311.DateUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(PUB.TIME) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1311.TimeUpdate) & "', "
            SQL = SQL & "   " & FormatSQL(z1311.TotalQty) & ", "
            SQL = SQL & "   " & FormatSQL(z1311.TotalAmount) & ", "
            SQL = SQL & "   " & FormatSQL(z1311.TotalCost) & ", "
            SQL = SQL & "   " & FormatSQL(z1311.TotalProfit) & ", "
            SQL = SQL & "  N'" & FormatSQL(z1311.AttachID) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1311.RemarkOrder) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1311.RemarkCustomer) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1311.Remark) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1311.seSite) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1311.cdSite) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK1311 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK1311", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK1311(z1311 As T1311_AREA) As Boolean
        REWRITE_PFK1311 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z1311)

            SQL = " UPDATE PFK1311 SET "
            SQL = SQL & "    K1311_CustomerCode      = N'" & FormatSQL(z1311.CustomerCode) & "', "
            SQL = SQL & "    K1311_VendorCode      = N'" & FormatSQL(z1311.VendorCode) & "', "
            SQL = SQL & "    K1311_AgentCode      = N'" & FormatSQL(z1311.AgentCode) & "', "
            SQL = SQL & "    K1311_Buyer      = N'" & FormatSQL(z1311.Buyer) & "', "
            SQL = SQL & "    K1311_seOrderGroup      = N'" & FormatSQL(z1311.seOrderGroup) & "', "
            SQL = SQL & "    K1311_cdOrderGroup      = N'" & FormatSQL(z1311.cdOrderGroup) & "', "
            SQL = SQL & "    K1311_seOrderKind      = N'" & FormatSQL(z1311.seOrderKind) & "', "
            SQL = SQL & "    K1311_cdOrderKind      = N'" & FormatSQL(z1311.cdOrderKind) & "', "
            SQL = SQL & "    K1311_seOrderType      = N'" & FormatSQL(z1311.seOrderType) & "', "
            SQL = SQL & "    K1311_cdOrderType      = N'" & FormatSQL(z1311.cdOrderType) & "', "
            SQL = SQL & "    K1311_cdOrderWork      = N'" & FormatSQL(z1311.cdOrderWork) & "', "
            SQL = SQL & "    K1311_seOrderWork      = N'" & FormatSQL(z1311.seOrderWork) & "', "
            SQL = SQL & "    K1311_seStateSample      = N'" & FormatSQL(z1311.seStateSample) & "', "
            SQL = SQL & "    K1311_cdStateSample      = N'" & FormatSQL(z1311.cdStateSample) & "', "
            SQL = SQL & "    K1311_seStateOfficial      = N'" & FormatSQL(z1311.seStateOfficial) & "', "
            SQL = SQL & "    K1311_cdStateOfficial      = N'" & FormatSQL(z1311.cdStateOfficial) & "', "
            SQL = SQL & "    K1311_StatusOrder      = N'" & FormatSQL(z1311.StatusOrder) & "', "
            SQL = SQL & "    K1311_DateOrder      = N'" & FormatSQL(z1311.DateOrder) & "', "
            SQL = SQL & "    K1311_DateApproval      = N'" & FormatSQL(z1311.DateApproval) & "', "
            SQL = SQL & "    K1311_DateComplete      = N'" & FormatSQL(z1311.DateComplete) & "', "
            SQL = SQL & "    K1311_DateCancel      = N'" & FormatSQL(z1311.DateCancel) & "', "
            SQL = SQL & "    K1311_DatePending      = N'" & FormatSQL(z1311.DatePending) & "', "
            SQL = SQL & "    K1311_seUnitPrice      = N'" & FormatSQL(z1311.seUnitPrice) & "', "
            SQL = SQL & "    K1311_cdUnitPrice      = N'" & FormatSQL(z1311.cdUnitPrice) & "', "
            SQL = SQL & "    K1311_PriceExchange      =  " & FormatSQL(z1311.PriceExchange) & ", "
            SQL = SQL & "    K1311_DateExchange      = N'" & FormatSQL(z1311.DateExchange) & "', "
            SQL = SQL & "    K1311_DateTransfer      = N'" & FormatSQL(z1311.DateTransfer) & "', "
            SQL = SQL & "    K1311_DateAccept      = N'" & FormatSQL(z1311.DateAccept) & "', "
            SQL = SQL & "    K1311_StatusTransfer      = N'" & FormatSQL(z1311.StatusTransfer) & "', "
            SQL = SQL & "    K1311_CheckPKO      = N'" & FormatSQL(z1311.CheckPKO) & "', "
            SQL = SQL & "    K1311_seSeason      = N'" & FormatSQL(z1311.seSeason) & "', "
            SQL = SQL & "    K1311_cdSeason      = N'" & FormatSQL(z1311.cdSeason) & "', "
            SQL = SQL & "    K1311_seShippingTerm      = N'" & FormatSQL(z1311.seShippingTerm) & "', "
            SQL = SQL & "    K1311_cdShippingTerm      = N'" & FormatSQL(z1311.cdShippingTerm) & "', "
            SQL = SQL & "    K1311_cdDeliveryTerm      = N'" & FormatSQL(z1311.cdDeliveryTerm) & "', "
            SQL = SQL & "    K1311_seDeliveryTerm      = N'" & FormatSQL(z1311.seDeliveryTerm) & "', "
            SQL = SQL & "    K1311_sePaymentTerm      = N'" & FormatSQL(z1311.sePaymentTerm) & "', "
            SQL = SQL & "    K1311_cdPaymentTerm      = N'" & FormatSQL(z1311.cdPaymentTerm) & "', "
            SQL = SQL & "    K1311_sePaymentCondition      = N'" & FormatSQL(z1311.sePaymentCondition) & "', "
            SQL = SQL & "    K1311_cdPaymentCondition      = N'" & FormatSQL(z1311.cdPaymentCondition) & "', "
            SQL = SQL & "    K1311_sePaymentTime      = N'" & FormatSQL(z1311.sePaymentTime) & "', "
            SQL = SQL & "    K1311_cdPaymentTime      = N'" & FormatSQL(z1311.cdPaymentTime) & "', "
            SQL = SQL & "    K1311_sePaymentDay      = N'" & FormatSQL(z1311.sePaymentDay) & "', "
            SQL = SQL & "    K1311_cdPaymentDay      = N'" & FormatSQL(z1311.cdPaymentDay) & "', "
            SQL = SQL & "    K1311_seMarketType      = N'" & FormatSQL(z1311.seMarketType) & "', "
            SQL = SQL & "    K1311_cdMarketType      = N'" & FormatSQL(z1311.cdMarketType) & "', "
            SQL = SQL & "    K1311_seDepartment      = N'" & FormatSQL(z1311.seDepartment) & "', "
            SQL = SQL & "    K1311_cdDepartment      = N'" & FormatSQL(z1311.cdDepartment) & "', "
            SQL = SQL & "    K1311_seBrand      = N'" & FormatSQL(z1311.seBrand) & "', "
            SQL = SQL & "    K1311_cdBrand      = N'" & FormatSQL(z1311.cdBrand) & "', "
            SQL = SQL & "    K1311_ContractIn      = N'" & FormatSQL(z1311.ContractIn) & "', "
            SQL = SQL & "    K1311_ContractOut      = N'" & FormatSQL(z1311.ContractOut) & "', "
            SQL = SQL & "    K1311_Destination      = N'" & FormatSQL(z1311.Destination) & "', "
            SQL = SQL & "    K1311_CustPoNo      = N'" & FormatSQL(z1311.CustPoNo) & "', "
            SQL = SQL & "    K1311_CustPoNoParent      = N'" & FormatSQL(z1311.CustPoNoParent) & "', "
            SQL = SQL & "    K1311_InchargeSales      = N'" & FormatSQL(z1311.InchargeSales) & "', "
            SQL = SQL & "    K1311_InchargePPC      = N'" & FormatSQL(z1311.InchargePPC) & "', "
            SQL = SQL & "    K1311_InchargeInsert      = N'" & FormatSQL(z1311.InchargeInsert) & "', "
            SQL = SQL & "    K1311_DateInsert      = N'" & FormatSQL(z1311.DateInsert) & "', "
            SQL = SQL & "    K1311_InchargeUpdate      = N'" & FormatSQL(PUB.SAW) & "', "
            SQL = SQL & "    K1311_DateUpdate      = N'" & FormatSQL(PUB.DAT) & "', "
            SQL = SQL & "    K1311_TimeInsert      = N'" & FormatSQL(z1311.TimeInsert) & "', "
            SQL = SQL & "    K1311_TimeUpdate      = N'" & FormatSQL(PUB.TIME) & "', "
            SQL = SQL & "    K1311_TotalQty      =  " & FormatSQL(z1311.TotalQty) & ", "
            SQL = SQL & "    K1311_TotalAmount      =  " & FormatSQL(z1311.TotalAmount) & ", "
            SQL = SQL & "    K1311_TotalCost      =  " & FormatSQL(z1311.TotalCost) & ", "
            SQL = SQL & "    K1311_TotalProfit      =  " & FormatSQL(z1311.TotalProfit) & ", "
            SQL = SQL & "    K1311_AttachID      = N'" & FormatSQL(z1311.AttachID) & "', "
            SQL = SQL & "    K1311_RemarkOrder      = N'" & FormatSQL(z1311.RemarkOrder) & "', "
            SQL = SQL & "    K1311_RemarkCustomer      = N'" & FormatSQL(z1311.RemarkCustomer) & "', "
            SQL = SQL & "    K1311_Remark      = N'" & FormatSQL(z1311.Remark) & "', "
            SQL = SQL & "    K1311_seSite      = N'" & FormatSQL(z1311.seSite) & "', "
            SQL = SQL & "    K1311_cdSite      = N'" & FormatSQL(z1311.cdSite) & "'  "
            SQL = SQL & " WHERE K1311_OrderNo		 = '" & z1311.OrderNo & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()


            REWRITE_PFK1311 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK1311", vbCritical)

        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK1311(z1311 As T1311_AREA) As Boolean
        DELETE_PFK1311 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z1311)

            SQL = " DELETE FROM PFK1311  "
            SQL = SQL & " WHERE K1311_OrderNo		 = '" & z1311.OrderNo & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK1311 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK1311", vbCritical)
        Finally
            Call GetFullInformation("PFK1311", "D", SQL)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D1311_CLEAR()
        Try

            D1311.OrderNo = ""
            D1311.CustomerCode = ""
            D1311.VendorCode = ""
            D1311.AgentCode = ""
            D1311.Buyer = ""
            D1311.seOrderGroup = ""
            D1311.cdOrderGroup = ""
            D1311.seOrderKind = ""
            D1311.cdOrderKind = ""
            D1311.seOrderType = ""
            D1311.cdOrderType = ""
            D1311.cdOrderWork = ""
            D1311.seOrderWork = ""
            D1311.seStateSample = ""
            D1311.cdStateSample = ""
            D1311.seStateOfficial = ""
            D1311.cdStateOfficial = ""
            D1311.StatusOrder = ""
            D1311.DateOrder = ""
            D1311.DateApproval = ""
            D1311.DateComplete = ""
            D1311.DateCancel = ""
            D1311.DatePending = ""
            D1311.seUnitPrice = ""
            D1311.cdUnitPrice = ""
            D1311.PriceExchange = 0
            D1311.DateExchange = ""
            D1311.DateTransfer = ""
            D1311.DateAccept = ""
            D1311.StatusTransfer = ""
            D1311.CheckPKO = ""
            D1311.seSeason = ""
            D1311.cdSeason = ""
            D1311.seShippingTerm = ""
            D1311.cdShippingTerm = ""
            D1311.cdDeliveryTerm = ""
            D1311.seDeliveryTerm = ""
            D1311.sePaymentTerm = ""
            D1311.cdPaymentTerm = ""
            D1311.sePaymentCondition = ""
            D1311.cdPaymentCondition = ""
            D1311.sePaymentTime = ""
            D1311.cdPaymentTime = ""
            D1311.sePaymentDay = ""
            D1311.cdPaymentDay = ""
            D1311.seMarketType = ""
            D1311.cdMarketType = ""
            D1311.seDepartment = ""
            D1311.cdDepartment = ""
            D1311.seBrand = ""
            D1311.cdBrand = ""
            D1311.ContractIn = ""
            D1311.ContractOut = ""
            D1311.Destination = ""
            D1311.CustPoNo = ""
            D1311.CustPoNoParent = ""
            D1311.InchargeSales = ""
            D1311.InchargePPC = ""
            D1311.InchargeInsert = ""
            D1311.DateInsert = ""
            D1311.InchargeUpdate = ""
            D1311.DateUpdate = ""
            D1311.TimeInsert = ""
            D1311.TimeUpdate = ""
            D1311.TotalQty = 0
            D1311.TotalAmount = 0
            D1311.TotalCost = 0
            D1311.TotalProfit = 0
            D1311.AttachID = ""
            D1311.RemarkOrder = ""
            D1311.RemarkCustomer = ""
            D1311.Remark = ""
            D1311.seSite = ""
            D1311.cdSite = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D1311_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x1311 As T1311_AREA)
        Try

            x1311.OrderNo = trim$(x1311.OrderNo)
            x1311.CustomerCode = trim$(x1311.CustomerCode)
            x1311.VendorCode = trim$(x1311.VendorCode)
            x1311.AgentCode = trim$(x1311.AgentCode)
            x1311.Buyer = trim$(x1311.Buyer)
            x1311.seOrderGroup = trim$(x1311.seOrderGroup)
            x1311.cdOrderGroup = trim$(x1311.cdOrderGroup)
            x1311.seOrderKind = trim$(x1311.seOrderKind)
            x1311.cdOrderKind = trim$(x1311.cdOrderKind)
            x1311.seOrderType = trim$(x1311.seOrderType)
            x1311.cdOrderType = trim$(x1311.cdOrderType)
            x1311.cdOrderWork = trim$(x1311.cdOrderWork)
            x1311.seOrderWork = trim$(x1311.seOrderWork)
            x1311.seStateSample = trim$(x1311.seStateSample)
            x1311.cdStateSample = trim$(x1311.cdStateSample)
            x1311.seStateOfficial = trim$(x1311.seStateOfficial)
            x1311.cdStateOfficial = trim$(x1311.cdStateOfficial)
            x1311.StatusOrder = trim$(x1311.StatusOrder)
            x1311.DateOrder = trim$(x1311.DateOrder)
            x1311.DateApproval = trim$(x1311.DateApproval)
            x1311.DateComplete = trim$(x1311.DateComplete)
            x1311.DateCancel = trim$(x1311.DateCancel)
            x1311.DatePending = trim$(x1311.DatePending)
            x1311.seUnitPrice = trim$(x1311.seUnitPrice)
            x1311.cdUnitPrice = trim$(x1311.cdUnitPrice)
            x1311.PriceExchange = trim$(x1311.PriceExchange)
            x1311.DateExchange = trim$(x1311.DateExchange)
            x1311.DateTransfer = trim$(x1311.DateTransfer)
            x1311.DateAccept = trim$(x1311.DateAccept)
            x1311.StatusTransfer = trim$(x1311.StatusTransfer)
            x1311.CheckPKO = trim$(x1311.CheckPKO)
            x1311.seSeason = trim$(x1311.seSeason)
            x1311.cdSeason = trim$(x1311.cdSeason)
            x1311.seShippingTerm = trim$(x1311.seShippingTerm)
            x1311.cdShippingTerm = trim$(x1311.cdShippingTerm)
            x1311.cdDeliveryTerm = trim$(x1311.cdDeliveryTerm)
            x1311.seDeliveryTerm = trim$(x1311.seDeliveryTerm)
            x1311.sePaymentTerm = trim$(x1311.sePaymentTerm)
            x1311.cdPaymentTerm = trim$(x1311.cdPaymentTerm)
            x1311.sePaymentCondition = trim$(x1311.sePaymentCondition)
            x1311.cdPaymentCondition = trim$(x1311.cdPaymentCondition)
            x1311.sePaymentTime = trim$(x1311.sePaymentTime)
            x1311.cdPaymentTime = trim$(x1311.cdPaymentTime)
            x1311.sePaymentDay = trim$(x1311.sePaymentDay)
            x1311.cdPaymentDay = trim$(x1311.cdPaymentDay)
            x1311.seMarketType = trim$(x1311.seMarketType)
            x1311.cdMarketType = trim$(x1311.cdMarketType)
            x1311.seDepartment = trim$(x1311.seDepartment)
            x1311.cdDepartment = trim$(x1311.cdDepartment)
            x1311.seBrand = trim$(x1311.seBrand)
            x1311.cdBrand = trim$(x1311.cdBrand)
            x1311.ContractIn = trim$(x1311.ContractIn)
            x1311.ContractOut = trim$(x1311.ContractOut)
            x1311.Destination = trim$(x1311.Destination)
            x1311.CustPoNo = Trim$(x1311.CustPoNo)
            x1311.CustPoNoParent = Trim$(x1311.CustPoNoParent)
            x1311.InchargeSales = trim$(x1311.InchargeSales)
            x1311.InchargePPC = trim$(x1311.InchargePPC)
            x1311.InchargeInsert = trim$(x1311.InchargeInsert)
            x1311.DateInsert = trim$(x1311.DateInsert)
            x1311.InchargeUpdate = trim$(x1311.InchargeUpdate)
            x1311.DateUpdate = trim$(x1311.DateUpdate)
            x1311.TimeInsert = trim$(x1311.TimeInsert)
            x1311.TimeUpdate = trim$(x1311.TimeUpdate)
            x1311.TotalQty = trim$(x1311.TotalQty)
            x1311.TotalAmount = trim$(x1311.TotalAmount)
            x1311.TotalCost = trim$(x1311.TotalCost)
            x1311.TotalProfit = trim$(x1311.TotalProfit)
            x1311.AttachID = trim$(x1311.AttachID)
            x1311.RemarkOrder = trim$(x1311.RemarkOrder)
            x1311.RemarkCustomer = trim$(x1311.RemarkCustomer)
            x1311.Remark = trim$(x1311.Remark)
            x1311.seSite = trim$(x1311.seSite)
            x1311.cdSite = trim$(x1311.cdSite)

            If trim$(x1311.OrderNo) = "" Then x1311.OrderNo = Space(1)
            If trim$(x1311.CustomerCode) = "" Then x1311.CustomerCode = Space(1)
            If trim$(x1311.VendorCode) = "" Then x1311.VendorCode = Space(1)
            If trim$(x1311.AgentCode) = "" Then x1311.AgentCode = Space(1)
            If trim$(x1311.Buyer) = "" Then x1311.Buyer = Space(1)
            If trim$(x1311.seOrderGroup) = "" Then x1311.seOrderGroup = Space(1)
            If trim$(x1311.cdOrderGroup) = "" Then x1311.cdOrderGroup = Space(1)
            If trim$(x1311.seOrderKind) = "" Then x1311.seOrderKind = Space(1)
            If trim$(x1311.cdOrderKind) = "" Then x1311.cdOrderKind = Space(1)
            If trim$(x1311.seOrderType) = "" Then x1311.seOrderType = Space(1)
            If trim$(x1311.cdOrderType) = "" Then x1311.cdOrderType = Space(1)
            If trim$(x1311.cdOrderWork) = "" Then x1311.cdOrderWork = Space(1)
            If trim$(x1311.seOrderWork) = "" Then x1311.seOrderWork = Space(1)
            If trim$(x1311.seStateSample) = "" Then x1311.seStateSample = Space(1)
            If trim$(x1311.cdStateSample) = "" Then x1311.cdStateSample = Space(1)
            If trim$(x1311.seStateOfficial) = "" Then x1311.seStateOfficial = Space(1)
            If trim$(x1311.cdStateOfficial) = "" Then x1311.cdStateOfficial = Space(1)
            If trim$(x1311.StatusOrder) = "" Then x1311.StatusOrder = Space(1)
            If trim$(x1311.DateOrder) = "" Then x1311.DateOrder = Space(1)
            If trim$(x1311.DateApproval) = "" Then x1311.DateApproval = Space(1)
            If trim$(x1311.DateComplete) = "" Then x1311.DateComplete = Space(1)
            If trim$(x1311.DateCancel) = "" Then x1311.DateCancel = Space(1)
            If trim$(x1311.DatePending) = "" Then x1311.DatePending = Space(1)
            If trim$(x1311.seUnitPrice) = "" Then x1311.seUnitPrice = Space(1)
            If trim$(x1311.cdUnitPrice) = "" Then x1311.cdUnitPrice = Space(1)
            If trim$(x1311.PriceExchange) = "" Then x1311.PriceExchange = 0
            If trim$(x1311.DateExchange) = "" Then x1311.DateExchange = Space(1)
            If trim$(x1311.DateTransfer) = "" Then x1311.DateTransfer = Space(1)
            If trim$(x1311.DateAccept) = "" Then x1311.DateAccept = Space(1)
            If trim$(x1311.StatusTransfer) = "" Then x1311.StatusTransfer = Space(1)
            If trim$(x1311.CheckPKO) = "" Then x1311.CheckPKO = Space(1)
            If trim$(x1311.seSeason) = "" Then x1311.seSeason = Space(1)
            If trim$(x1311.cdSeason) = "" Then x1311.cdSeason = Space(1)
            If trim$(x1311.seShippingTerm) = "" Then x1311.seShippingTerm = Space(1)
            If trim$(x1311.cdShippingTerm) = "" Then x1311.cdShippingTerm = Space(1)
            If trim$(x1311.cdDeliveryTerm) = "" Then x1311.cdDeliveryTerm = Space(1)
            If trim$(x1311.seDeliveryTerm) = "" Then x1311.seDeliveryTerm = Space(1)
            If trim$(x1311.sePaymentTerm) = "" Then x1311.sePaymentTerm = Space(1)
            If trim$(x1311.cdPaymentTerm) = "" Then x1311.cdPaymentTerm = Space(1)
            If trim$(x1311.sePaymentCondition) = "" Then x1311.sePaymentCondition = Space(1)
            If trim$(x1311.cdPaymentCondition) = "" Then x1311.cdPaymentCondition = Space(1)
            If trim$(x1311.sePaymentTime) = "" Then x1311.sePaymentTime = Space(1)
            If trim$(x1311.cdPaymentTime) = "" Then x1311.cdPaymentTime = Space(1)
            If trim$(x1311.sePaymentDay) = "" Then x1311.sePaymentDay = Space(1)
            If trim$(x1311.cdPaymentDay) = "" Then x1311.cdPaymentDay = Space(1)
            If trim$(x1311.seMarketType) = "" Then x1311.seMarketType = Space(1)
            If trim$(x1311.cdMarketType) = "" Then x1311.cdMarketType = Space(1)
            If trim$(x1311.seDepartment) = "" Then x1311.seDepartment = Space(1)
            If trim$(x1311.cdDepartment) = "" Then x1311.cdDepartment = Space(1)
            If trim$(x1311.seBrand) = "" Then x1311.seBrand = Space(1)
            If trim$(x1311.cdBrand) = "" Then x1311.cdBrand = Space(1)
            If trim$(x1311.ContractIn) = "" Then x1311.ContractIn = Space(1)
            If trim$(x1311.ContractOut) = "" Then x1311.ContractOut = Space(1)
            If trim$(x1311.Destination) = "" Then x1311.Destination = Space(1)
            If Trim$(x1311.CustPoNo) = "" Then x1311.CustPoNo = Space(1)
            If Trim$(x1311.CustPoNoParent) = "" Then x1311.CustPoNoParent = Space(1)
            If trim$(x1311.InchargeSales) = "" Then x1311.InchargeSales = Space(1)
            If trim$(x1311.InchargePPC) = "" Then x1311.InchargePPC = Space(1)
            If trim$(x1311.InchargeInsert) = "" Then x1311.InchargeInsert = Space(1)
            If trim$(x1311.DateInsert) = "" Then x1311.DateInsert = Space(1)
            If trim$(x1311.InchargeUpdate) = "" Then x1311.InchargeUpdate = Space(1)
            If trim$(x1311.DateUpdate) = "" Then x1311.DateUpdate = Space(1)
            If trim$(x1311.TimeInsert) = "" Then x1311.TimeInsert = Space(1)
            If trim$(x1311.TimeUpdate) = "" Then x1311.TimeUpdate = Space(1)
            If trim$(x1311.TotalQty) = "" Then x1311.TotalQty = 0
            If trim$(x1311.TotalAmount) = "" Then x1311.TotalAmount = 0
            If trim$(x1311.TotalCost) = "" Then x1311.TotalCost = 0
            If trim$(x1311.TotalProfit) = "" Then x1311.TotalProfit = 0
            If trim$(x1311.AttachID) = "" Then x1311.AttachID = Space(1)
            If trim$(x1311.RemarkOrder) = "" Then x1311.RemarkOrder = Space(1)
            If trim$(x1311.RemarkCustomer) = "" Then x1311.RemarkCustomer = Space(1)
            If trim$(x1311.Remark) = "" Then x1311.Remark = Space(1)
            If trim$(x1311.seSite) = "" Then x1311.seSite = Space(1)
            If trim$(x1311.cdSite) = "" Then x1311.cdSite = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K1311_MOVE(rs1311 As SqlClient.SqlDataReader)
        Try

            Call D1311_CLEAR()

            If IsdbNull(rs1311!K1311_OrderNo) = False Then D1311.OrderNo = Trim$(rs1311!K1311_OrderNo)
            If IsdbNull(rs1311!K1311_CustomerCode) = False Then D1311.CustomerCode = Trim$(rs1311!K1311_CustomerCode)
            If IsdbNull(rs1311!K1311_VendorCode) = False Then D1311.VendorCode = Trim$(rs1311!K1311_VendorCode)
            If IsdbNull(rs1311!K1311_AgentCode) = False Then D1311.AgentCode = Trim$(rs1311!K1311_AgentCode)
            If IsdbNull(rs1311!K1311_Buyer) = False Then D1311.Buyer = Trim$(rs1311!K1311_Buyer)
            If IsdbNull(rs1311!K1311_seOrderGroup) = False Then D1311.seOrderGroup = Trim$(rs1311!K1311_seOrderGroup)
            If IsdbNull(rs1311!K1311_cdOrderGroup) = False Then D1311.cdOrderGroup = Trim$(rs1311!K1311_cdOrderGroup)
            If IsdbNull(rs1311!K1311_seOrderKind) = False Then D1311.seOrderKind = Trim$(rs1311!K1311_seOrderKind)
            If IsdbNull(rs1311!K1311_cdOrderKind) = False Then D1311.cdOrderKind = Trim$(rs1311!K1311_cdOrderKind)
            If IsdbNull(rs1311!K1311_seOrderType) = False Then D1311.seOrderType = Trim$(rs1311!K1311_seOrderType)
            If IsdbNull(rs1311!K1311_cdOrderType) = False Then D1311.cdOrderType = Trim$(rs1311!K1311_cdOrderType)
            If IsdbNull(rs1311!K1311_cdOrderWork) = False Then D1311.cdOrderWork = Trim$(rs1311!K1311_cdOrderWork)
            If IsdbNull(rs1311!K1311_seOrderWork) = False Then D1311.seOrderWork = Trim$(rs1311!K1311_seOrderWork)
            If IsdbNull(rs1311!K1311_seStateSample) = False Then D1311.seStateSample = Trim$(rs1311!K1311_seStateSample)
            If IsdbNull(rs1311!K1311_cdStateSample) = False Then D1311.cdStateSample = Trim$(rs1311!K1311_cdStateSample)
            If IsdbNull(rs1311!K1311_seStateOfficial) = False Then D1311.seStateOfficial = Trim$(rs1311!K1311_seStateOfficial)
            If IsdbNull(rs1311!K1311_cdStateOfficial) = False Then D1311.cdStateOfficial = Trim$(rs1311!K1311_cdStateOfficial)
            If IsdbNull(rs1311!K1311_StatusOrder) = False Then D1311.StatusOrder = Trim$(rs1311!K1311_StatusOrder)
            If IsdbNull(rs1311!K1311_DateOrder) = False Then D1311.DateOrder = Trim$(rs1311!K1311_DateOrder)
            If IsdbNull(rs1311!K1311_DateApproval) = False Then D1311.DateApproval = Trim$(rs1311!K1311_DateApproval)
            If IsdbNull(rs1311!K1311_DateComplete) = False Then D1311.DateComplete = Trim$(rs1311!K1311_DateComplete)
            If IsdbNull(rs1311!K1311_DateCancel) = False Then D1311.DateCancel = Trim$(rs1311!K1311_DateCancel)
            If IsdbNull(rs1311!K1311_DatePending) = False Then D1311.DatePending = Trim$(rs1311!K1311_DatePending)
            If IsdbNull(rs1311!K1311_seUnitPrice) = False Then D1311.seUnitPrice = Trim$(rs1311!K1311_seUnitPrice)
            If IsdbNull(rs1311!K1311_cdUnitPrice) = False Then D1311.cdUnitPrice = Trim$(rs1311!K1311_cdUnitPrice)
            If IsdbNull(rs1311!K1311_PriceExchange) = False Then D1311.PriceExchange = Trim$(rs1311!K1311_PriceExchange)
            If IsdbNull(rs1311!K1311_DateExchange) = False Then D1311.DateExchange = Trim$(rs1311!K1311_DateExchange)
            If IsdbNull(rs1311!K1311_DateTransfer) = False Then D1311.DateTransfer = Trim$(rs1311!K1311_DateTransfer)
            If IsdbNull(rs1311!K1311_DateAccept) = False Then D1311.DateAccept = Trim$(rs1311!K1311_DateAccept)
            If IsdbNull(rs1311!K1311_StatusTransfer) = False Then D1311.StatusTransfer = Trim$(rs1311!K1311_StatusTransfer)
            If IsdbNull(rs1311!K1311_CheckPKO) = False Then D1311.CheckPKO = Trim$(rs1311!K1311_CheckPKO)
            If IsdbNull(rs1311!K1311_seSeason) = False Then D1311.seSeason = Trim$(rs1311!K1311_seSeason)
            If IsdbNull(rs1311!K1311_cdSeason) = False Then D1311.cdSeason = Trim$(rs1311!K1311_cdSeason)
            If IsdbNull(rs1311!K1311_seShippingTerm) = False Then D1311.seShippingTerm = Trim$(rs1311!K1311_seShippingTerm)
            If IsdbNull(rs1311!K1311_cdShippingTerm) = False Then D1311.cdShippingTerm = Trim$(rs1311!K1311_cdShippingTerm)
            If IsdbNull(rs1311!K1311_cdDeliveryTerm) = False Then D1311.cdDeliveryTerm = Trim$(rs1311!K1311_cdDeliveryTerm)
            If IsdbNull(rs1311!K1311_seDeliveryTerm) = False Then D1311.seDeliveryTerm = Trim$(rs1311!K1311_seDeliveryTerm)
            If IsdbNull(rs1311!K1311_sePaymentTerm) = False Then D1311.sePaymentTerm = Trim$(rs1311!K1311_sePaymentTerm)
            If IsdbNull(rs1311!K1311_cdPaymentTerm) = False Then D1311.cdPaymentTerm = Trim$(rs1311!K1311_cdPaymentTerm)
            If IsdbNull(rs1311!K1311_sePaymentCondition) = False Then D1311.sePaymentCondition = Trim$(rs1311!K1311_sePaymentCondition)
            If IsdbNull(rs1311!K1311_cdPaymentCondition) = False Then D1311.cdPaymentCondition = Trim$(rs1311!K1311_cdPaymentCondition)
            If IsdbNull(rs1311!K1311_sePaymentTime) = False Then D1311.sePaymentTime = Trim$(rs1311!K1311_sePaymentTime)
            If IsdbNull(rs1311!K1311_cdPaymentTime) = False Then D1311.cdPaymentTime = Trim$(rs1311!K1311_cdPaymentTime)
            If IsdbNull(rs1311!K1311_sePaymentDay) = False Then D1311.sePaymentDay = Trim$(rs1311!K1311_sePaymentDay)
            If IsdbNull(rs1311!K1311_cdPaymentDay) = False Then D1311.cdPaymentDay = Trim$(rs1311!K1311_cdPaymentDay)
            If IsdbNull(rs1311!K1311_seMarketType) = False Then D1311.seMarketType = Trim$(rs1311!K1311_seMarketType)
            If IsdbNull(rs1311!K1311_cdMarketType) = False Then D1311.cdMarketType = Trim$(rs1311!K1311_cdMarketType)
            If IsdbNull(rs1311!K1311_seDepartment) = False Then D1311.seDepartment = Trim$(rs1311!K1311_seDepartment)
            If IsdbNull(rs1311!K1311_cdDepartment) = False Then D1311.cdDepartment = Trim$(rs1311!K1311_cdDepartment)
            If IsdbNull(rs1311!K1311_seBrand) = False Then D1311.seBrand = Trim$(rs1311!K1311_seBrand)
            If IsdbNull(rs1311!K1311_cdBrand) = False Then D1311.cdBrand = Trim$(rs1311!K1311_cdBrand)
            If IsdbNull(rs1311!K1311_ContractIn) = False Then D1311.ContractIn = Trim$(rs1311!K1311_ContractIn)
            If IsdbNull(rs1311!K1311_ContractOut) = False Then D1311.ContractOut = Trim$(rs1311!K1311_ContractOut)
            If IsdbNull(rs1311!K1311_Destination) = False Then D1311.Destination = Trim$(rs1311!K1311_Destination)
            If IsDBNull(rs1311!K1311_CustPoNo) = False Then D1311.CustPoNo = Trim$(rs1311!K1311_CustPoNo)
            If IsDBNull(rs1311!K1311_CustPoNoParent) = False Then D1311.CustPoNoParent = Trim$(rs1311!K1311_CustPoNoParent)
            If IsdbNull(rs1311!K1311_InchargeSales) = False Then D1311.InchargeSales = Trim$(rs1311!K1311_InchargeSales)
            If IsdbNull(rs1311!K1311_InchargePPC) = False Then D1311.InchargePPC = Trim$(rs1311!K1311_InchargePPC)
            If IsdbNull(rs1311!K1311_InchargeInsert) = False Then D1311.InchargeInsert = Trim$(rs1311!K1311_InchargeInsert)
            If IsdbNull(rs1311!K1311_DateInsert) = False Then D1311.DateInsert = Trim$(rs1311!K1311_DateInsert)
            If IsdbNull(rs1311!K1311_InchargeUpdate) = False Then D1311.InchargeUpdate = Trim$(rs1311!K1311_InchargeUpdate)
            If IsdbNull(rs1311!K1311_DateUpdate) = False Then D1311.DateUpdate = Trim$(rs1311!K1311_DateUpdate)
            If IsdbNull(rs1311!K1311_TimeInsert) = False Then D1311.TimeInsert = Trim$(rs1311!K1311_TimeInsert)
            If IsdbNull(rs1311!K1311_TimeUpdate) = False Then D1311.TimeUpdate = Trim$(rs1311!K1311_TimeUpdate)
            If IsdbNull(rs1311!K1311_TotalQty) = False Then D1311.TotalQty = Trim$(rs1311!K1311_TotalQty)
            If IsdbNull(rs1311!K1311_TotalAmount) = False Then D1311.TotalAmount = Trim$(rs1311!K1311_TotalAmount)
            If IsdbNull(rs1311!K1311_TotalCost) = False Then D1311.TotalCost = Trim$(rs1311!K1311_TotalCost)
            If IsdbNull(rs1311!K1311_TotalProfit) = False Then D1311.TotalProfit = Trim$(rs1311!K1311_TotalProfit)
            If IsdbNull(rs1311!K1311_AttachID) = False Then D1311.AttachID = Trim$(rs1311!K1311_AttachID)
            If IsdbNull(rs1311!K1311_RemarkOrder) = False Then D1311.RemarkOrder = Trim$(rs1311!K1311_RemarkOrder)
            If IsdbNull(rs1311!K1311_RemarkCustomer) = False Then D1311.RemarkCustomer = Trim$(rs1311!K1311_RemarkCustomer)
            If IsdbNull(rs1311!K1311_Remark) = False Then D1311.Remark = Trim$(rs1311!K1311_Remark)
            If IsdbNull(rs1311!K1311_seSite) = False Then D1311.seSite = Trim$(rs1311!K1311_seSite)
            If IsdbNull(rs1311!K1311_cdSite) = False Then D1311.cdSite = Trim$(rs1311!K1311_cdSite)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K1311_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K1311_MOVE(rs1311 As DataRow)
        Try

            Call D1311_CLEAR()

            If IsdbNull(rs1311!K1311_OrderNo) = False Then D1311.OrderNo = Trim$(rs1311!K1311_OrderNo)
            If IsdbNull(rs1311!K1311_CustomerCode) = False Then D1311.CustomerCode = Trim$(rs1311!K1311_CustomerCode)
            If IsdbNull(rs1311!K1311_VendorCode) = False Then D1311.VendorCode = Trim$(rs1311!K1311_VendorCode)
            If IsdbNull(rs1311!K1311_AgentCode) = False Then D1311.AgentCode = Trim$(rs1311!K1311_AgentCode)
            If IsdbNull(rs1311!K1311_Buyer) = False Then D1311.Buyer = Trim$(rs1311!K1311_Buyer)
            If IsdbNull(rs1311!K1311_seOrderGroup) = False Then D1311.seOrderGroup = Trim$(rs1311!K1311_seOrderGroup)
            If IsdbNull(rs1311!K1311_cdOrderGroup) = False Then D1311.cdOrderGroup = Trim$(rs1311!K1311_cdOrderGroup)
            If IsdbNull(rs1311!K1311_seOrderKind) = False Then D1311.seOrderKind = Trim$(rs1311!K1311_seOrderKind)
            If IsdbNull(rs1311!K1311_cdOrderKind) = False Then D1311.cdOrderKind = Trim$(rs1311!K1311_cdOrderKind)
            If IsdbNull(rs1311!K1311_seOrderType) = False Then D1311.seOrderType = Trim$(rs1311!K1311_seOrderType)
            If IsdbNull(rs1311!K1311_cdOrderType) = False Then D1311.cdOrderType = Trim$(rs1311!K1311_cdOrderType)
            If IsdbNull(rs1311!K1311_cdOrderWork) = False Then D1311.cdOrderWork = Trim$(rs1311!K1311_cdOrderWork)
            If IsdbNull(rs1311!K1311_seOrderWork) = False Then D1311.seOrderWork = Trim$(rs1311!K1311_seOrderWork)
            If IsdbNull(rs1311!K1311_seStateSample) = False Then D1311.seStateSample = Trim$(rs1311!K1311_seStateSample)
            If IsdbNull(rs1311!K1311_cdStateSample) = False Then D1311.cdStateSample = Trim$(rs1311!K1311_cdStateSample)
            If IsdbNull(rs1311!K1311_seStateOfficial) = False Then D1311.seStateOfficial = Trim$(rs1311!K1311_seStateOfficial)
            If IsdbNull(rs1311!K1311_cdStateOfficial) = False Then D1311.cdStateOfficial = Trim$(rs1311!K1311_cdStateOfficial)
            If IsdbNull(rs1311!K1311_StatusOrder) = False Then D1311.StatusOrder = Trim$(rs1311!K1311_StatusOrder)
            If IsdbNull(rs1311!K1311_DateOrder) = False Then D1311.DateOrder = Trim$(rs1311!K1311_DateOrder)
            If IsdbNull(rs1311!K1311_DateApproval) = False Then D1311.DateApproval = Trim$(rs1311!K1311_DateApproval)
            If IsdbNull(rs1311!K1311_DateComplete) = False Then D1311.DateComplete = Trim$(rs1311!K1311_DateComplete)
            If IsdbNull(rs1311!K1311_DateCancel) = False Then D1311.DateCancel = Trim$(rs1311!K1311_DateCancel)
            If IsdbNull(rs1311!K1311_DatePending) = False Then D1311.DatePending = Trim$(rs1311!K1311_DatePending)
            If IsdbNull(rs1311!K1311_seUnitPrice) = False Then D1311.seUnitPrice = Trim$(rs1311!K1311_seUnitPrice)
            If IsdbNull(rs1311!K1311_cdUnitPrice) = False Then D1311.cdUnitPrice = Trim$(rs1311!K1311_cdUnitPrice)
            If IsdbNull(rs1311!K1311_PriceExchange) = False Then D1311.PriceExchange = Trim$(rs1311!K1311_PriceExchange)
            If IsdbNull(rs1311!K1311_DateExchange) = False Then D1311.DateExchange = Trim$(rs1311!K1311_DateExchange)
            If IsdbNull(rs1311!K1311_DateTransfer) = False Then D1311.DateTransfer = Trim$(rs1311!K1311_DateTransfer)
            If IsdbNull(rs1311!K1311_DateAccept) = False Then D1311.DateAccept = Trim$(rs1311!K1311_DateAccept)
            If IsdbNull(rs1311!K1311_StatusTransfer) = False Then D1311.StatusTransfer = Trim$(rs1311!K1311_StatusTransfer)
            If IsdbNull(rs1311!K1311_CheckPKO) = False Then D1311.CheckPKO = Trim$(rs1311!K1311_CheckPKO)
            If IsdbNull(rs1311!K1311_seSeason) = False Then D1311.seSeason = Trim$(rs1311!K1311_seSeason)
            If IsdbNull(rs1311!K1311_cdSeason) = False Then D1311.cdSeason = Trim$(rs1311!K1311_cdSeason)
            If IsdbNull(rs1311!K1311_seShippingTerm) = False Then D1311.seShippingTerm = Trim$(rs1311!K1311_seShippingTerm)
            If IsdbNull(rs1311!K1311_cdShippingTerm) = False Then D1311.cdShippingTerm = Trim$(rs1311!K1311_cdShippingTerm)
            If IsdbNull(rs1311!K1311_cdDeliveryTerm) = False Then D1311.cdDeliveryTerm = Trim$(rs1311!K1311_cdDeliveryTerm)
            If IsdbNull(rs1311!K1311_seDeliveryTerm) = False Then D1311.seDeliveryTerm = Trim$(rs1311!K1311_seDeliveryTerm)
            If IsdbNull(rs1311!K1311_sePaymentTerm) = False Then D1311.sePaymentTerm = Trim$(rs1311!K1311_sePaymentTerm)
            If IsdbNull(rs1311!K1311_cdPaymentTerm) = False Then D1311.cdPaymentTerm = Trim$(rs1311!K1311_cdPaymentTerm)
            If IsdbNull(rs1311!K1311_sePaymentCondition) = False Then D1311.sePaymentCondition = Trim$(rs1311!K1311_sePaymentCondition)
            If IsdbNull(rs1311!K1311_cdPaymentCondition) = False Then D1311.cdPaymentCondition = Trim$(rs1311!K1311_cdPaymentCondition)
            If IsdbNull(rs1311!K1311_sePaymentTime) = False Then D1311.sePaymentTime = Trim$(rs1311!K1311_sePaymentTime)
            If IsdbNull(rs1311!K1311_cdPaymentTime) = False Then D1311.cdPaymentTime = Trim$(rs1311!K1311_cdPaymentTime)
            If IsdbNull(rs1311!K1311_sePaymentDay) = False Then D1311.sePaymentDay = Trim$(rs1311!K1311_sePaymentDay)
            If IsdbNull(rs1311!K1311_cdPaymentDay) = False Then D1311.cdPaymentDay = Trim$(rs1311!K1311_cdPaymentDay)
            If IsdbNull(rs1311!K1311_seMarketType) = False Then D1311.seMarketType = Trim$(rs1311!K1311_seMarketType)
            If IsdbNull(rs1311!K1311_cdMarketType) = False Then D1311.cdMarketType = Trim$(rs1311!K1311_cdMarketType)
            If IsdbNull(rs1311!K1311_seDepartment) = False Then D1311.seDepartment = Trim$(rs1311!K1311_seDepartment)
            If IsdbNull(rs1311!K1311_cdDepartment) = False Then D1311.cdDepartment = Trim$(rs1311!K1311_cdDepartment)
            If IsdbNull(rs1311!K1311_seBrand) = False Then D1311.seBrand = Trim$(rs1311!K1311_seBrand)
            If IsdbNull(rs1311!K1311_cdBrand) = False Then D1311.cdBrand = Trim$(rs1311!K1311_cdBrand)
            If IsdbNull(rs1311!K1311_ContractIn) = False Then D1311.ContractIn = Trim$(rs1311!K1311_ContractIn)
            If IsdbNull(rs1311!K1311_ContractOut) = False Then D1311.ContractOut = Trim$(rs1311!K1311_ContractOut)
            If IsdbNull(rs1311!K1311_Destination) = False Then D1311.Destination = Trim$(rs1311!K1311_Destination)
            If IsDBNull(rs1311!K1311_CustPoNo) = False Then D1311.CustPoNo = Trim$(rs1311!K1311_CustPoNo)
            If IsDBNull(rs1311!K1311_CustPoNoParent) = False Then D1311.CustPoNoParent = Trim$(rs1311!K1311_CustPoNoParent)
            If IsdbNull(rs1311!K1311_InchargeSales) = False Then D1311.InchargeSales = Trim$(rs1311!K1311_InchargeSales)
            If IsdbNull(rs1311!K1311_InchargePPC) = False Then D1311.InchargePPC = Trim$(rs1311!K1311_InchargePPC)
            If IsdbNull(rs1311!K1311_InchargeInsert) = False Then D1311.InchargeInsert = Trim$(rs1311!K1311_InchargeInsert)
            If IsdbNull(rs1311!K1311_DateInsert) = False Then D1311.DateInsert = Trim$(rs1311!K1311_DateInsert)
            If IsdbNull(rs1311!K1311_InchargeUpdate) = False Then D1311.InchargeUpdate = Trim$(rs1311!K1311_InchargeUpdate)
            If IsdbNull(rs1311!K1311_DateUpdate) = False Then D1311.DateUpdate = Trim$(rs1311!K1311_DateUpdate)
            If IsdbNull(rs1311!K1311_TimeInsert) = False Then D1311.TimeInsert = Trim$(rs1311!K1311_TimeInsert)
            If IsdbNull(rs1311!K1311_TimeUpdate) = False Then D1311.TimeUpdate = Trim$(rs1311!K1311_TimeUpdate)
            If IsdbNull(rs1311!K1311_TotalQty) = False Then D1311.TotalQty = Trim$(rs1311!K1311_TotalQty)
            If IsdbNull(rs1311!K1311_TotalAmount) = False Then D1311.TotalAmount = Trim$(rs1311!K1311_TotalAmount)
            If IsdbNull(rs1311!K1311_TotalCost) = False Then D1311.TotalCost = Trim$(rs1311!K1311_TotalCost)
            If IsdbNull(rs1311!K1311_TotalProfit) = False Then D1311.TotalProfit = Trim$(rs1311!K1311_TotalProfit)
            If IsdbNull(rs1311!K1311_AttachID) = False Then D1311.AttachID = Trim$(rs1311!K1311_AttachID)
            If IsdbNull(rs1311!K1311_RemarkOrder) = False Then D1311.RemarkOrder = Trim$(rs1311!K1311_RemarkOrder)
            If IsdbNull(rs1311!K1311_RemarkCustomer) = False Then D1311.RemarkCustomer = Trim$(rs1311!K1311_RemarkCustomer)
            If IsdbNull(rs1311!K1311_Remark) = False Then D1311.Remark = Trim$(rs1311!K1311_Remark)
            If IsdbNull(rs1311!K1311_seSite) = False Then D1311.seSite = Trim$(rs1311!K1311_seSite)
            If IsdbNull(rs1311!K1311_cdSite) = False Then D1311.cdSite = Trim$(rs1311!K1311_cdSite)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K1311_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K1311_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z1311 As T1311_AREA, Job As String, ORDERNO As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K1311_MOVE = False

        Try
            If READ_PFK1311(ORDERNO) = True Then
                z1311 = D1311
                K1311_MOVE = True
            Else
                z1311 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK1311")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "ORDERNO" : z1311.OrderNo = Children(i).Code
                                Case "CUSTOMERCODE" : z1311.CustomerCode = Children(i).Code
                                Case "VENDORCODE" : z1311.VendorCode = Children(i).Code
                                Case "AGENTCODE" : z1311.AgentCode = Children(i).Code
                                Case "BUYER" : z1311.Buyer = Children(i).Code
                                Case "SEORDERGROUP" : z1311.seOrderGroup = Children(i).Code
                                Case "CDORDERGROUP" : z1311.cdOrderGroup = Children(i).Code
                                Case "SEORDERKIND" : z1311.seOrderKind = Children(i).Code
                                Case "CDORDERKIND" : z1311.cdOrderKind = Children(i).Code
                                Case "SEORDERTYPE" : z1311.seOrderType = Children(i).Code
                                Case "CDORDERTYPE" : z1311.cdOrderType = Children(i).Code
                                Case "CDORDERWORK" : z1311.cdOrderWork = Children(i).Code
                                Case "SEORDERWORK" : z1311.seOrderWork = Children(i).Code
                                Case "SESTATESAMPLE" : z1311.seStateSample = Children(i).Code
                                Case "CDSTATESAMPLE" : z1311.cdStateSample = Children(i).Code
                                Case "SESTATEOFFICIAL" : z1311.seStateOfficial = Children(i).Code
                                Case "CDSTATEOFFICIAL" : z1311.cdStateOfficial = Children(i).Code
                                Case "STATUSORDER" : z1311.StatusOrder = Children(i).Code
                                Case "DATEORDER" : z1311.DateOrder = Children(i).Code
                                Case "DATEAPPROVAL" : z1311.DateApproval = Children(i).Code
                                Case "DATECOMPLETE" : z1311.DateComplete = Children(i).Code
                                Case "DATECANCEL" : z1311.DateCancel = Children(i).Code
                                Case "DATEPENDING" : z1311.DatePending = Children(i).Code
                                Case "SEUNITPRICE" : z1311.seUnitPrice = Children(i).Code
                                Case "CDUNITPRICE" : z1311.cdUnitPrice = Children(i).Code
                                Case "PRICEEXCHANGE" : z1311.PriceExchange = Children(i).Code
                                Case "DATEEXCHANGE" : z1311.DateExchange = Children(i).Code
                                Case "DATETRANSFER" : z1311.DateTransfer = Children(i).Code
                                Case "DATEACCEPT" : z1311.DateAccept = Children(i).Code
                                Case "STATUSTRANSFER" : z1311.StatusTransfer = Children(i).Code
                                Case "CHECKPKO" : z1311.CheckPKO = Children(i).Code
                                Case "SESEASON" : z1311.seSeason = Children(i).Code
                                Case "CDSEASON" : z1311.cdSeason = Children(i).Code
                                Case "SESHIPPINGTERM" : z1311.seShippingTerm = Children(i).Code
                                Case "CDSHIPPINGTERM" : z1311.cdShippingTerm = Children(i).Code
                                Case "CDDELIVERYTERM" : z1311.cdDeliveryTerm = Children(i).Code
                                Case "SEDELIVERYTERM" : z1311.seDeliveryTerm = Children(i).Code
                                Case "SEPAYMENTTERM" : z1311.sePaymentTerm = Children(i).Code
                                Case "CDPAYMENTTERM" : z1311.cdPaymentTerm = Children(i).Code
                                Case "SEPAYMENTCONDITION" : z1311.sePaymentCondition = Children(i).Code
                                Case "CDPAYMENTCONDITION" : z1311.cdPaymentCondition = Children(i).Code
                                Case "SEPAYMENTTIME" : z1311.sePaymentTime = Children(i).Code
                                Case "CDPAYMENTTIME" : z1311.cdPaymentTime = Children(i).Code
                                Case "SEPAYMENTDAY" : z1311.sePaymentDay = Children(i).Code
                                Case "CDPAYMENTDAY" : z1311.cdPaymentDay = Children(i).Code
                                Case "SEMARKETTYPE" : z1311.seMarketType = Children(i).Code
                                Case "CDMARKETTYPE" : z1311.cdMarketType = Children(i).Code
                                Case "SEDEPARTMENT" : z1311.seDepartment = Children(i).Code
                                Case "CDDEPARTMENT" : z1311.cdDepartment = Children(i).Code
                                Case "SEBRAND" : z1311.seBrand = Children(i).Code
                                Case "CDBRAND" : z1311.cdBrand = Children(i).Code
                                Case "CONTRACTIN" : z1311.ContractIn = Children(i).Code
                                Case "CONTRACTOUT" : z1311.ContractOut = Children(i).Code
                                Case "DESTINATION" : z1311.Destination = Children(i).Code
                                Case "CUSTPONO" : z1311.CustPoNo = Children(i).Code
                                Case "CUSTPONOPARENT" : z1311.CustPoNoParent = Children(i).Code
                                Case "INCHARGESALES" : z1311.InchargeSales = Children(i).Code
                                Case "INCHARGEPPC" : z1311.InchargePPC = Children(i).Code
                                Case "INCHARGEINSERT" : z1311.InchargeInsert = Children(i).Code
                                Case "DATEINSERT" : z1311.DateInsert = Children(i).Code
                                Case "INCHARGEUPDATE" : z1311.InchargeUpdate = Children(i).Code
                                Case "DATEUPDATE" : z1311.DateUpdate = Children(i).Code
                                Case "TIMEINSERT" : z1311.TimeInsert = Children(i).Code
                                Case "TIMEUPDATE" : z1311.TimeUpdate = Children(i).Code
                                Case "TOTALQTY" : z1311.TotalQty = Children(i).Code
                                Case "TOTALAMOUNT" : z1311.TotalAmount = Children(i).Code
                                Case "TOTALCOST" : z1311.TotalCost = Children(i).Code
                                Case "TOTALPROFIT" : z1311.TotalProfit = Children(i).Code
                                Case "ATTACHID" : z1311.AttachID = Children(i).Code
                                Case "REMARKORDER" : z1311.RemarkOrder = Children(i).Code
                                Case "REMARKCUSTOMER" : z1311.RemarkCustomer = Children(i).Code
                                Case "REMARK" : z1311.Remark = Children(i).Code
                                Case "SESITE" : z1311.seSite = Children(i).Code
                                Case "CDSITE" : z1311.cdSite = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "ORDERNO" : z1311.OrderNo = Children(i).Data
                                Case "CUSTOMERCODE" : z1311.CustomerCode = Children(i).Data
                                Case "VENDORCODE" : z1311.VendorCode = Children(i).Data
                                Case "AGENTCODE" : z1311.AgentCode = Children(i).Data
                                Case "BUYER" : z1311.Buyer = Children(i).Data
                                Case "SEORDERGROUP" : z1311.seOrderGroup = Children(i).Data
                                Case "CDORDERGROUP" : z1311.cdOrderGroup = Children(i).Data
                                Case "SEORDERKIND" : z1311.seOrderKind = Children(i).Data
                                Case "CDORDERKIND" : z1311.cdOrderKind = Children(i).Data
                                Case "SEORDERTYPE" : z1311.seOrderType = Children(i).Data
                                Case "CDORDERTYPE" : z1311.cdOrderType = Children(i).Data
                                Case "CDORDERWORK" : z1311.cdOrderWork = Children(i).Data
                                Case "SEORDERWORK" : z1311.seOrderWork = Children(i).Data
                                Case "SESTATESAMPLE" : z1311.seStateSample = Children(i).Data
                                Case "CDSTATESAMPLE" : z1311.cdStateSample = Children(i).Data
                                Case "SESTATEOFFICIAL" : z1311.seStateOfficial = Children(i).Data
                                Case "CDSTATEOFFICIAL" : z1311.cdStateOfficial = Children(i).Data
                                Case "STATUSORDER" : z1311.StatusOrder = Children(i).Data
                                Case "DATEORDER" : z1311.DateOrder = Children(i).Data
                                Case "DATEAPPROVAL" : z1311.DateApproval = Children(i).Data
                                Case "DATECOMPLETE" : z1311.DateComplete = Children(i).Data
                                Case "DATECANCEL" : z1311.DateCancel = Children(i).Data
                                Case "DATEPENDING" : z1311.DatePending = Children(i).Data
                                Case "SEUNITPRICE" : z1311.seUnitPrice = Children(i).Data
                                Case "CDUNITPRICE" : z1311.cdUnitPrice = Children(i).Data
                                Case "PRICEEXCHANGE" : z1311.PriceExchange = Cdecp(Children(i).Data)
                                Case "DATEEXCHANGE" : z1311.DateExchange = Children(i).Data
                                Case "DATETRANSFER" : z1311.DateTransfer = Children(i).Data
                                Case "DATEACCEPT" : z1311.DateAccept = Children(i).Data
                                Case "STATUSTRANSFER" : z1311.StatusTransfer = Children(i).Data
                                Case "CHECKPKO" : z1311.CheckPKO = Children(i).Data
                                Case "SESEASON" : z1311.seSeason = Children(i).Data
                                Case "CDSEASON" : z1311.cdSeason = Children(i).Data
                                Case "SESHIPPINGTERM" : z1311.seShippingTerm = Children(i).Data
                                Case "CDSHIPPINGTERM" : z1311.cdShippingTerm = Children(i).Data
                                Case "CDDELIVERYTERM" : z1311.cdDeliveryTerm = Children(i).Data
                                Case "SEDELIVERYTERM" : z1311.seDeliveryTerm = Children(i).Data
                                Case "SEPAYMENTTERM" : z1311.sePaymentTerm = Children(i).Data
                                Case "CDPAYMENTTERM" : z1311.cdPaymentTerm = Children(i).Data
                                Case "SEPAYMENTCONDITION" : z1311.sePaymentCondition = Children(i).Data
                                Case "CDPAYMENTCONDITION" : z1311.cdPaymentCondition = Children(i).Data
                                Case "SEPAYMENTTIME" : z1311.sePaymentTime = Children(i).Data
                                Case "CDPAYMENTTIME" : z1311.cdPaymentTime = Children(i).Data
                                Case "SEPAYMENTDAY" : z1311.sePaymentDay = Children(i).Data
                                Case "CDPAYMENTDAY" : z1311.cdPaymentDay = Children(i).Data
                                Case "SEMARKETTYPE" : z1311.seMarketType = Children(i).Data
                                Case "CDMARKETTYPE" : z1311.cdMarketType = Children(i).Data
                                Case "SEDEPARTMENT" : z1311.seDepartment = Children(i).Data
                                Case "CDDEPARTMENT" : z1311.cdDepartment = Children(i).Data
                                Case "SEBRAND" : z1311.seBrand = Children(i).Data
                                Case "CDBRAND" : z1311.cdBrand = Children(i).Data
                                Case "CONTRACTIN" : z1311.ContractIn = Children(i).Data
                                Case "CONTRACTOUT" : z1311.ContractOut = Children(i).Data
                                Case "DESTINATION" : z1311.Destination = Children(i).Data
                                Case "CUSTPONO" : z1311.CustPoNo = Children(i).Data
                                Case "CUSTPONOPARENT" : z1311.CustPoNoParent = Children(i).Data
                                Case "INCHARGESALES" : z1311.InchargeSales = Children(i).Data
                                Case "INCHARGEPPC" : z1311.InchargePPC = Children(i).Data
                                Case "INCHARGEINSERT" : z1311.InchargeInsert = Children(i).Data
                                Case "DATEINSERT" : z1311.DateInsert = Children(i).Data
                                Case "INCHARGEUPDATE" : z1311.InchargeUpdate = Children(i).Data
                                Case "DATEUPDATE" : z1311.DateUpdate = Children(i).Data
                                Case "TIMEINSERT" : z1311.TimeInsert = Children(i).Data
                                Case "TIMEUPDATE" : z1311.TimeUpdate = Children(i).Data
                                Case "TOTALQTY" : z1311.TotalQty = Cdecp(Children(i).Data)
                                Case "TOTALAMOUNT" : z1311.TotalAmount = Cdecp(Children(i).Data)
                                Case "TOTALCOST" : z1311.TotalCost = Cdecp(Children(i).Data)
                                Case "TOTALPROFIT" : z1311.TotalProfit = Cdecp(Children(i).Data)
                                Case "ATTACHID" : z1311.AttachID = Children(i).Data
                                Case "REMARKORDER" : z1311.RemarkOrder = Children(i).Data
                                Case "REMARKCUSTOMER" : z1311.RemarkCustomer = Children(i).Data
                                Case "REMARK" : z1311.Remark = Children(i).Data
                                Case "SESITE" : z1311.seSite = Children(i).Data
                                Case "CDSITE" : z1311.cdSite = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K1311_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K1311_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z1311 As T1311_AREA, Job As String, CheckClear As Boolean, ORDERNO As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K1311_MOVE = False

        Try
            If READ_PFK1311(ORDERNO) = True Then
                z1311 = D1311
                K1311_MOVE = True
            Else
                If CheckClear = True Then z1311 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK1311")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "ORDERNO" : z1311.OrderNo = Children(i).Code
                                Case "CUSTOMERCODE" : z1311.CustomerCode = Children(i).Code
                                Case "VENDORCODE" : z1311.VendorCode = Children(i).Code
                                Case "AGENTCODE" : z1311.AgentCode = Children(i).Code
                                Case "BUYER" : z1311.Buyer = Children(i).Code
                                Case "SEORDERGROUP" : z1311.seOrderGroup = Children(i).Code
                                Case "CDORDERGROUP" : z1311.cdOrderGroup = Children(i).Code
                                Case "SEORDERKIND" : z1311.seOrderKind = Children(i).Code
                                Case "CDORDERKIND" : z1311.cdOrderKind = Children(i).Code
                                Case "SEORDERTYPE" : z1311.seOrderType = Children(i).Code
                                Case "CDORDERTYPE" : z1311.cdOrderType = Children(i).Code
                                Case "CDORDERWORK" : z1311.cdOrderWork = Children(i).Code
                                Case "SEORDERWORK" : z1311.seOrderWork = Children(i).Code
                                Case "SESTATESAMPLE" : z1311.seStateSample = Children(i).Code
                                Case "CDSTATESAMPLE" : z1311.cdStateSample = Children(i).Code
                                Case "SESTATEOFFICIAL" : z1311.seStateOfficial = Children(i).Code
                                Case "CDSTATEOFFICIAL" : z1311.cdStateOfficial = Children(i).Code
                                Case "STATUSORDER" : z1311.StatusOrder = Children(i).Code
                                Case "DATEORDER" : z1311.DateOrder = Children(i).Code
                                Case "DATEAPPROVAL" : z1311.DateApproval = Children(i).Code
                                Case "DATECOMPLETE" : z1311.DateComplete = Children(i).Code
                                Case "DATECANCEL" : z1311.DateCancel = Children(i).Code
                                Case "DATEPENDING" : z1311.DatePending = Children(i).Code
                                Case "SEUNITPRICE" : z1311.seUnitPrice = Children(i).Code
                                Case "CDUNITPRICE" : z1311.cdUnitPrice = Children(i).Code
                                Case "PRICEEXCHANGE" : z1311.PriceExchange = Children(i).Code
                                Case "DATEEXCHANGE" : z1311.DateExchange = Children(i).Code
                                Case "DATETRANSFER" : z1311.DateTransfer = Children(i).Code
                                Case "DATEACCEPT" : z1311.DateAccept = Children(i).Code
                                Case "STATUSTRANSFER" : z1311.StatusTransfer = Children(i).Code
                                Case "CHECKPKO" : z1311.CheckPKO = Children(i).Code
                                Case "SESEASON" : z1311.seSeason = Children(i).Code
                                Case "CDSEASON" : z1311.cdSeason = Children(i).Code
                                Case "SESHIPPINGTERM" : z1311.seShippingTerm = Children(i).Code
                                Case "CDSHIPPINGTERM" : z1311.cdShippingTerm = Children(i).Code
                                Case "CDDELIVERYTERM" : z1311.cdDeliveryTerm = Children(i).Code
                                Case "SEDELIVERYTERM" : z1311.seDeliveryTerm = Children(i).Code
                                Case "SEPAYMENTTERM" : z1311.sePaymentTerm = Children(i).Code
                                Case "CDPAYMENTTERM" : z1311.cdPaymentTerm = Children(i).Code
                                Case "SEPAYMENTCONDITION" : z1311.sePaymentCondition = Children(i).Code
                                Case "CDPAYMENTCONDITION" : z1311.cdPaymentCondition = Children(i).Code
                                Case "SEPAYMENTTIME" : z1311.sePaymentTime = Children(i).Code
                                Case "CDPAYMENTTIME" : z1311.cdPaymentTime = Children(i).Code
                                Case "SEPAYMENTDAY" : z1311.sePaymentDay = Children(i).Code
                                Case "CDPAYMENTDAY" : z1311.cdPaymentDay = Children(i).Code
                                Case "SEMARKETTYPE" : z1311.seMarketType = Children(i).Code
                                Case "CDMARKETTYPE" : z1311.cdMarketType = Children(i).Code
                                Case "SEDEPARTMENT" : z1311.seDepartment = Children(i).Code
                                Case "CDDEPARTMENT" : z1311.cdDepartment = Children(i).Code
                                Case "SEBRAND" : z1311.seBrand = Children(i).Code
                                Case "CDBRAND" : z1311.cdBrand = Children(i).Code
                                Case "CONTRACTIN" : z1311.ContractIn = Children(i).Code
                                Case "CONTRACTOUT" : z1311.ContractOut = Children(i).Code
                                Case "DESTINATION" : z1311.Destination = Children(i).Code
                                Case "CUSTPONO" : z1311.CustPoNo = Children(i).Code
                                Case "CUSTPONOPARENT" : z1311.CustPoNoParent = Children(i).Code
                                Case "INCHARGESALES" : z1311.InchargeSales = Children(i).Code
                                Case "INCHARGEPPC" : z1311.InchargePPC = Children(i).Code
                                Case "INCHARGEINSERT" : z1311.InchargeInsert = Children(i).Code
                                Case "DATEINSERT" : z1311.DateInsert = Children(i).Code
                                Case "INCHARGEUPDATE" : z1311.InchargeUpdate = Children(i).Code
                                Case "DATEUPDATE" : z1311.DateUpdate = Children(i).Code
                                Case "TIMEINSERT" : z1311.TimeInsert = Children(i).Code
                                Case "TIMEUPDATE" : z1311.TimeUpdate = Children(i).Code
                                Case "TOTALQTY" : z1311.TotalQty = Children(i).Code
                                Case "TOTALAMOUNT" : z1311.TotalAmount = Children(i).Code
                                Case "TOTALCOST" : z1311.TotalCost = Children(i).Code
                                Case "TOTALPROFIT" : z1311.TotalProfit = Children(i).Code
                                Case "ATTACHID" : z1311.AttachID = Children(i).Code
                                Case "REMARKORDER" : z1311.RemarkOrder = Children(i).Code
                                Case "REMARKCUSTOMER" : z1311.RemarkCustomer = Children(i).Code
                                Case "REMARK" : z1311.Remark = Children(i).Code
                                Case "SESITE" : z1311.seSite = Children(i).Code
                                Case "CDSITE" : z1311.cdSite = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "ORDERNO" : z1311.OrderNo = Children(i).Data
                                Case "CUSTOMERCODE" : z1311.CustomerCode = Children(i).Data
                                Case "VENDORCODE" : z1311.VendorCode = Children(i).Data
                                Case "AGENTCODE" : z1311.AgentCode = Children(i).Data
                                Case "BUYER" : z1311.Buyer = Children(i).Data
                                Case "SEORDERGROUP" : z1311.seOrderGroup = Children(i).Data
                                Case "CDORDERGROUP" : z1311.cdOrderGroup = Children(i).Data
                                Case "SEORDERKIND" : z1311.seOrderKind = Children(i).Data
                                Case "CDORDERKIND" : z1311.cdOrderKind = Children(i).Data
                                Case "SEORDERTYPE" : z1311.seOrderType = Children(i).Data
                                Case "CDORDERTYPE" : z1311.cdOrderType = Children(i).Data
                                Case "CDORDERWORK" : z1311.cdOrderWork = Children(i).Data
                                Case "SEORDERWORK" : z1311.seOrderWork = Children(i).Data
                                Case "SESTATESAMPLE" : z1311.seStateSample = Children(i).Data
                                Case "CDSTATESAMPLE" : z1311.cdStateSample = Children(i).Data
                                Case "SESTATEOFFICIAL" : z1311.seStateOfficial = Children(i).Data
                                Case "CDSTATEOFFICIAL" : z1311.cdStateOfficial = Children(i).Data
                                Case "STATUSORDER" : z1311.StatusOrder = Children(i).Data
                                Case "DATEORDER" : z1311.DateOrder = Children(i).Data
                                Case "DATEAPPROVAL" : z1311.DateApproval = Children(i).Data
                                Case "DATECOMPLETE" : z1311.DateComplete = Children(i).Data
                                Case "DATECANCEL" : z1311.DateCancel = Children(i).Data
                                Case "DATEPENDING" : z1311.DatePending = Children(i).Data
                                Case "SEUNITPRICE" : z1311.seUnitPrice = Children(i).Data
                                Case "CDUNITPRICE" : z1311.cdUnitPrice = Children(i).Data
                                Case "PRICEEXCHANGE" : z1311.PriceExchange = Cdecp(Children(i).Data)
                                Case "DATEEXCHANGE" : z1311.DateExchange = Children(i).Data
                                Case "DATETRANSFER" : z1311.DateTransfer = Children(i).Data
                                Case "DATEACCEPT" : z1311.DateAccept = Children(i).Data
                                Case "STATUSTRANSFER" : z1311.StatusTransfer = Children(i).Data
                                Case "CHECKPKO" : z1311.CheckPKO = Children(i).Data
                                Case "SESEASON" : z1311.seSeason = Children(i).Data
                                Case "CDSEASON" : z1311.cdSeason = Children(i).Data
                                Case "SESHIPPINGTERM" : z1311.seShippingTerm = Children(i).Data
                                Case "CDSHIPPINGTERM" : z1311.cdShippingTerm = Children(i).Data
                                Case "CDDELIVERYTERM" : z1311.cdDeliveryTerm = Children(i).Data
                                Case "SEDELIVERYTERM" : z1311.seDeliveryTerm = Children(i).Data
                                Case "SEPAYMENTTERM" : z1311.sePaymentTerm = Children(i).Data
                                Case "CDPAYMENTTERM" : z1311.cdPaymentTerm = Children(i).Data
                                Case "SEPAYMENTCONDITION" : z1311.sePaymentCondition = Children(i).Data
                                Case "CDPAYMENTCONDITION" : z1311.cdPaymentCondition = Children(i).Data
                                Case "SEPAYMENTTIME" : z1311.sePaymentTime = Children(i).Data
                                Case "CDPAYMENTTIME" : z1311.cdPaymentTime = Children(i).Data
                                Case "SEPAYMENTDAY" : z1311.sePaymentDay = Children(i).Data
                                Case "CDPAYMENTDAY" : z1311.cdPaymentDay = Children(i).Data
                                Case "SEMARKETTYPE" : z1311.seMarketType = Children(i).Data
                                Case "CDMARKETTYPE" : z1311.cdMarketType = Children(i).Data
                                Case "SEDEPARTMENT" : z1311.seDepartment = Children(i).Data
                                Case "CDDEPARTMENT" : z1311.cdDepartment = Children(i).Data
                                Case "SEBRAND" : z1311.seBrand = Children(i).Data
                                Case "CDBRAND" : z1311.cdBrand = Children(i).Data
                                Case "CONTRACTIN" : z1311.ContractIn = Children(i).Data
                                Case "CONTRACTOUT" : z1311.ContractOut = Children(i).Data
                                Case "DESTINATION" : z1311.Destination = Children(i).Data
                                Case "CUSTPONO" : z1311.CustPoNo = Children(i).Data
                                Case "CUSTPONOPARENT" : z1311.CustPoNoParent = Children(i).Data
                                Case "INCHARGESALES" : z1311.InchargeSales = Children(i).Data
                                Case "INCHARGEPPC" : z1311.InchargePPC = Children(i).Data
                                Case "INCHARGEINSERT" : z1311.InchargeInsert = Children(i).Data
                                Case "DATEINSERT" : z1311.DateInsert = Children(i).Data
                                Case "INCHARGEUPDATE" : z1311.InchargeUpdate = Children(i).Data
                                Case "DATEUPDATE" : z1311.DateUpdate = Children(i).Data
                                Case "TIMEINSERT" : z1311.TimeInsert = Children(i).Data
                                Case "TIMEUPDATE" : z1311.TimeUpdate = Children(i).Data
                                Case "TOTALQTY" : z1311.TotalQty = Cdecp(Children(i).Data)
                                Case "TOTALAMOUNT" : z1311.TotalAmount = Cdecp(Children(i).Data)
                                Case "TOTALCOST" : z1311.TotalCost = Cdecp(Children(i).Data)
                                Case "TOTALPROFIT" : z1311.TotalProfit = Cdecp(Children(i).Data)
                                Case "ATTACHID" : z1311.AttachID = Children(i).Data
                                Case "REMARKORDER" : z1311.RemarkOrder = Children(i).Data
                                Case "REMARKCUSTOMER" : z1311.RemarkCustomer = Children(i).Data
                                Case "REMARK" : z1311.Remark = Children(i).Data
                                Case "SESITE" : z1311.seSite = Children(i).Data
                                Case "CDSITE" : z1311.cdSite = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K1311_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW AREA
    '=========================================================================================================================================================
    Public Sub K1311_MOVE(ByRef a1311 As T1311_AREA, ByRef b1311 As T1311_AREA)
        Try
            If trim$(a1311.OrderNo) = "" Then b1311.OrderNo = "" Else b1311.OrderNo = a1311.OrderNo
            If trim$(a1311.CustomerCode) = "" Then b1311.CustomerCode = "" Else b1311.CustomerCode = a1311.CustomerCode
            If trim$(a1311.VendorCode) = "" Then b1311.VendorCode = "" Else b1311.VendorCode = a1311.VendorCode
            If trim$(a1311.AgentCode) = "" Then b1311.AgentCode = "" Else b1311.AgentCode = a1311.AgentCode
            If trim$(a1311.Buyer) = "" Then b1311.Buyer = "" Else b1311.Buyer = a1311.Buyer
            If trim$(a1311.seOrderGroup) = "" Then b1311.seOrderGroup = "" Else b1311.seOrderGroup = a1311.seOrderGroup
            If trim$(a1311.cdOrderGroup) = "" Then b1311.cdOrderGroup = "" Else b1311.cdOrderGroup = a1311.cdOrderGroup
            If trim$(a1311.seOrderKind) = "" Then b1311.seOrderKind = "" Else b1311.seOrderKind = a1311.seOrderKind
            If trim$(a1311.cdOrderKind) = "" Then b1311.cdOrderKind = "" Else b1311.cdOrderKind = a1311.cdOrderKind
            If trim$(a1311.seOrderType) = "" Then b1311.seOrderType = "" Else b1311.seOrderType = a1311.seOrderType
            If trim$(a1311.cdOrderType) = "" Then b1311.cdOrderType = "" Else b1311.cdOrderType = a1311.cdOrderType
            If trim$(a1311.cdOrderWork) = "" Then b1311.cdOrderWork = "" Else b1311.cdOrderWork = a1311.cdOrderWork
            If trim$(a1311.seOrderWork) = "" Then b1311.seOrderWork = "" Else b1311.seOrderWork = a1311.seOrderWork
            If trim$(a1311.seStateSample) = "" Then b1311.seStateSample = "" Else b1311.seStateSample = a1311.seStateSample
            If trim$(a1311.cdStateSample) = "" Then b1311.cdStateSample = "" Else b1311.cdStateSample = a1311.cdStateSample
            If trim$(a1311.seStateOfficial) = "" Then b1311.seStateOfficial = "" Else b1311.seStateOfficial = a1311.seStateOfficial
            If trim$(a1311.cdStateOfficial) = "" Then b1311.cdStateOfficial = "" Else b1311.cdStateOfficial = a1311.cdStateOfficial
            If trim$(a1311.StatusOrder) = "" Then b1311.StatusOrder = "" Else b1311.StatusOrder = a1311.StatusOrder
            If trim$(a1311.DateOrder) = "" Then b1311.DateOrder = "" Else b1311.DateOrder = a1311.DateOrder
            If trim$(a1311.DateApproval) = "" Then b1311.DateApproval = "" Else b1311.DateApproval = a1311.DateApproval
            If trim$(a1311.DateComplete) = "" Then b1311.DateComplete = "" Else b1311.DateComplete = a1311.DateComplete
            If trim$(a1311.DateCancel) = "" Then b1311.DateCancel = "" Else b1311.DateCancel = a1311.DateCancel
            If trim$(a1311.DatePending) = "" Then b1311.DatePending = "" Else b1311.DatePending = a1311.DatePending
            If trim$(a1311.seUnitPrice) = "" Then b1311.seUnitPrice = "" Else b1311.seUnitPrice = a1311.seUnitPrice
            If trim$(a1311.cdUnitPrice) = "" Then b1311.cdUnitPrice = "" Else b1311.cdUnitPrice = a1311.cdUnitPrice
            If trim$(a1311.PriceExchange) = "" Then b1311.PriceExchange = "" Else b1311.PriceExchange = a1311.PriceExchange
            If trim$(a1311.DateExchange) = "" Then b1311.DateExchange = "" Else b1311.DateExchange = a1311.DateExchange
            If trim$(a1311.DateTransfer) = "" Then b1311.DateTransfer = "" Else b1311.DateTransfer = a1311.DateTransfer
            If trim$(a1311.DateAccept) = "" Then b1311.DateAccept = "" Else b1311.DateAccept = a1311.DateAccept
            If trim$(a1311.StatusTransfer) = "" Then b1311.StatusTransfer = "" Else b1311.StatusTransfer = a1311.StatusTransfer
            If trim$(a1311.CheckPKO) = "" Then b1311.CheckPKO = "" Else b1311.CheckPKO = a1311.CheckPKO
            If trim$(a1311.seSeason) = "" Then b1311.seSeason = "" Else b1311.seSeason = a1311.seSeason
            If trim$(a1311.cdSeason) = "" Then b1311.cdSeason = "" Else b1311.cdSeason = a1311.cdSeason
            If trim$(a1311.seShippingTerm) = "" Then b1311.seShippingTerm = "" Else b1311.seShippingTerm = a1311.seShippingTerm
            If trim$(a1311.cdShippingTerm) = "" Then b1311.cdShippingTerm = "" Else b1311.cdShippingTerm = a1311.cdShippingTerm
            If trim$(a1311.cdDeliveryTerm) = "" Then b1311.cdDeliveryTerm = "" Else b1311.cdDeliveryTerm = a1311.cdDeliveryTerm
            If trim$(a1311.seDeliveryTerm) = "" Then b1311.seDeliveryTerm = "" Else b1311.seDeliveryTerm = a1311.seDeliveryTerm
            If trim$(a1311.sePaymentTerm) = "" Then b1311.sePaymentTerm = "" Else b1311.sePaymentTerm = a1311.sePaymentTerm
            If trim$(a1311.cdPaymentTerm) = "" Then b1311.cdPaymentTerm = "" Else b1311.cdPaymentTerm = a1311.cdPaymentTerm
            If trim$(a1311.sePaymentCondition) = "" Then b1311.sePaymentCondition = "" Else b1311.sePaymentCondition = a1311.sePaymentCondition
            If trim$(a1311.cdPaymentCondition) = "" Then b1311.cdPaymentCondition = "" Else b1311.cdPaymentCondition = a1311.cdPaymentCondition
            If trim$(a1311.sePaymentTime) = "" Then b1311.sePaymentTime = "" Else b1311.sePaymentTime = a1311.sePaymentTime
            If trim$(a1311.cdPaymentTime) = "" Then b1311.cdPaymentTime = "" Else b1311.cdPaymentTime = a1311.cdPaymentTime
            If trim$(a1311.sePaymentDay) = "" Then b1311.sePaymentDay = "" Else b1311.sePaymentDay = a1311.sePaymentDay
            If trim$(a1311.cdPaymentDay) = "" Then b1311.cdPaymentDay = "" Else b1311.cdPaymentDay = a1311.cdPaymentDay
            If trim$(a1311.seMarketType) = "" Then b1311.seMarketType = "" Else b1311.seMarketType = a1311.seMarketType
            If trim$(a1311.cdMarketType) = "" Then b1311.cdMarketType = "" Else b1311.cdMarketType = a1311.cdMarketType
            If trim$(a1311.seDepartment) = "" Then b1311.seDepartment = "" Else b1311.seDepartment = a1311.seDepartment
            If trim$(a1311.cdDepartment) = "" Then b1311.cdDepartment = "" Else b1311.cdDepartment = a1311.cdDepartment
            If trim$(a1311.seBrand) = "" Then b1311.seBrand = "" Else b1311.seBrand = a1311.seBrand
            If trim$(a1311.cdBrand) = "" Then b1311.cdBrand = "" Else b1311.cdBrand = a1311.cdBrand
            If trim$(a1311.ContractIn) = "" Then b1311.ContractIn = "" Else b1311.ContractIn = a1311.ContractIn
            If trim$(a1311.ContractOut) = "" Then b1311.ContractOut = "" Else b1311.ContractOut = a1311.ContractOut
            If trim$(a1311.Destination) = "" Then b1311.Destination = "" Else b1311.Destination = a1311.Destination
            If Trim$(a1311.CustPoNo) = "" Then b1311.CustPoNo = "" Else b1311.CustPoNo = a1311.CustPoNo
            If Trim$(a1311.CustPoNoParent) = "" Then b1311.CustPoNoParent = "" Else b1311.CustPoNoParent = a1311.CustPoNoParent
            If trim$(a1311.InchargeSales) = "" Then b1311.InchargeSales = "" Else b1311.InchargeSales = a1311.InchargeSales
            If trim$(a1311.InchargePPC) = "" Then b1311.InchargePPC = "" Else b1311.InchargePPC = a1311.InchargePPC
            If trim$(a1311.InchargeInsert) = "" Then b1311.InchargeInsert = "" Else b1311.InchargeInsert = a1311.InchargeInsert
            If trim$(a1311.DateInsert) = "" Then b1311.DateInsert = "" Else b1311.DateInsert = a1311.DateInsert
            If trim$(a1311.InchargeUpdate) = "" Then b1311.InchargeUpdate = "" Else b1311.InchargeUpdate = a1311.InchargeUpdate
            If trim$(a1311.DateUpdate) = "" Then b1311.DateUpdate = "" Else b1311.DateUpdate = a1311.DateUpdate
            If trim$(a1311.TimeInsert) = "" Then b1311.TimeInsert = "" Else b1311.TimeInsert = a1311.TimeInsert
            If trim$(a1311.TimeUpdate) = "" Then b1311.TimeUpdate = "" Else b1311.TimeUpdate = a1311.TimeUpdate
            If trim$(a1311.TotalQty) = "" Then b1311.TotalQty = "" Else b1311.TotalQty = a1311.TotalQty
            If trim$(a1311.TotalAmount) = "" Then b1311.TotalAmount = "" Else b1311.TotalAmount = a1311.TotalAmount
            If trim$(a1311.TotalCost) = "" Then b1311.TotalCost = "" Else b1311.TotalCost = a1311.TotalCost
            If trim$(a1311.TotalProfit) = "" Then b1311.TotalProfit = "" Else b1311.TotalProfit = a1311.TotalProfit
            If trim$(a1311.AttachID) = "" Then b1311.AttachID = "" Else b1311.AttachID = a1311.AttachID
            If trim$(a1311.RemarkOrder) = "" Then b1311.RemarkOrder = "" Else b1311.RemarkOrder = a1311.RemarkOrder
            If trim$(a1311.RemarkCustomer) = "" Then b1311.RemarkCustomer = "" Else b1311.RemarkCustomer = a1311.RemarkCustomer
            If trim$(a1311.Remark) = "" Then b1311.Remark = "" Else b1311.Remark = a1311.Remark
            If trim$(a1311.seSite) = "" Then b1311.seSite = "" Else b1311.seSite = a1311.seSite
            If trim$(a1311.cdSite) = "" Then b1311.cdSite = "" Else b1311.cdSite = a1311.cdSite
        Catch ex As Exception
            Call MsgBoxP("K1311_MOVE", vbCritical)
        End Try
    End Sub


End Module
