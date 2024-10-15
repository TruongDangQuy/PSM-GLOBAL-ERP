'=========================================================================================================================================================
'   TABLE : (PFK7262)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7262

    Structure T7262_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public ContractID As String  '			char(6)		*
        Public DateAccept As String  '			char(8)
        Public CustomerCode As String  '			char(6)
        Public CheckProcessType As String  '			char(1)
        Public CheckIOType As String  '			char(1)
        Public CheckMaterialType As String  '			char(1)
        Public CheckMarketType As String  '			char(1)
        Public CheckRelationType As String  '			char(1)
        Public seDeliveryTerm As String  '			char(3)
        Public cdDeliveryTerm As String  '			char(3)
        Public seOrigin As String  '			char(3)
        Public cdOrigin As String  '			char(3)
        Public seCommercialTerm As String  '			char(3)
        Public cdCommercialTerm As String  '			char(3)
        Public sePaymentTerm As String  '			char(3)
        Public cdPaymentTerm As String  '			char(3)
        Public sePaymentCondition As String  '			char(3)
        Public cdPaymentCondition As String  '			char(3)
        Public sePaymentTime As String  '			char(3)
        Public cdPaymentTime As String  '			char(3)
        Public sePaymentDay As String  '			char(3)
        Public cdPaymentDay As String  '			char(3)
        Public seBuyingType As String  '			char(3)
        Public cdBuyingType As String  '			char(3)
        Public seUnitPrice As String  '			char(3)
        Public cdUnitPrice As String  '			char(3)
        Public DateExchange As String  '			char(8)
        Public PriceExchange As Double  '			decimal
        Public QualityRequest As String  '			nvarchar(50)
        Public ContractNo As String  '			nvarchar(50)
        Public Tolerance As String  '			nvarchar(50)
        Public Destination As String  '			nvarchar(50)
        Public DateInsert As String  '			char(8)
        Public DateUpdate As String  '			char(8)
        Public InchargeInsert As String  '			char(6)
        Public InchargeUpdate As String  '			char(6)
        Public InchargePurchasing As String  '			char(8)
        Public CheckSupplierPrice As String  '			char(1)
        Public DateComplete As String  '			char(8)
        Public DateApproved As String  '			char(8)
        Public DateCancel As String  '			char(8)
        Public DatePending1 As String  '			char(8)
        Public DatePending2 As String  '			char(8)
        Public CheckUse As String  '			char(1)
        Public Remark As String  '			nvarchar(1000)
        '=========================================================================================================================================================
    End Structure

    Public D7262 As T7262_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK7262(CONTRACTID As String) As Boolean
        READ_PFK7262 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7262 "
            SQL = SQL & " WHERE K7262_ContractID		 = '" & ContractID & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7262_CLEAR() : GoTo SKIP_READ_PFK7262

            Call K7262_MOVE(rd)
            READ_PFK7262 = True

SKIP_READ_PFK7262:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7262", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK7262(CONTRACTID As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7262 "
            SQL = SQL & " WHERE K7262_ContractID		 = '" & ContractID & "' "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK7262", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK7262(z7262 As T7262_AREA) As Boolean
        WRITE_PFK7262 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z7262)

            SQL = " INSERT INTO PFK7262 "
            SQL = SQL & " ( "
            SQL = SQL & " K7262_ContractID,"
            SQL = SQL & " K7262_DateAccept,"
            SQL = SQL & " K7262_CustomerCode,"
            SQL = SQL & " K7262_CheckProcessType,"
            SQL = SQL & " K7262_CheckIOType,"
            SQL = SQL & " K7262_CheckMaterialType,"
            SQL = SQL & " K7262_CheckMarketType,"
            SQL = SQL & " K7262_CheckRelationType,"
            SQL = SQL & " K7262_seDeliveryTerm,"
            SQL = SQL & " K7262_cdDeliveryTerm,"
            SQL = SQL & " K7262_seOrigin,"
            SQL = SQL & " K7262_cdOrigin,"
            SQL = SQL & " K7262_seCommercialTerm,"
            SQL = SQL & " K7262_cdCommercialTerm,"
            SQL = SQL & " K7262_sePaymentTerm,"
            SQL = SQL & " K7262_cdPaymentTerm,"
            SQL = SQL & " K7262_sePaymentCondition,"
            SQL = SQL & " K7262_cdPaymentCondition,"
            SQL = SQL & " K7262_sePaymentTime,"
            SQL = SQL & " K7262_cdPaymentTime,"
            SQL = SQL & " K7262_sePaymentDay,"
            SQL = SQL & " K7262_cdPaymentDay,"
            SQL = SQL & " K7262_seBuyingType,"
            SQL = SQL & " K7262_cdBuyingType,"
            SQL = SQL & " K7262_seUnitPrice,"
            SQL = SQL & " K7262_cdUnitPrice,"
            SQL = SQL & " K7262_DateExchange,"
            SQL = SQL & " K7262_PriceExchange,"
            SQL = SQL & " K7262_QualityRequest,"
            SQL = SQL & " K7262_ContractNo,"
            SQL = SQL & " K7262_Tolerance,"
            SQL = SQL & " K7262_Destination,"
            SQL = SQL & " K7262_DateInsert,"
            SQL = SQL & " K7262_DateUpdate,"
            SQL = SQL & " K7262_InchargeInsert,"
            SQL = SQL & " K7262_InchargeUpdate,"
            SQL = SQL & " K7262_InchargePurchasing,"
            SQL = SQL & " K7262_CheckSupplierPrice,"
            SQL = SQL & " K7262_DateComplete,"
            SQL = SQL & " K7262_DateApproved,"
            SQL = SQL & " K7262_DateCancel,"
            SQL = SQL & " K7262_DatePending1,"
            SQL = SQL & " K7262_DatePending2,"
            SQL = SQL & " K7262_CheckUse,"
            SQL = SQL & " K7262_Remark "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z7262.ContractID) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7262.DateAccept) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7262.CustomerCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7262.CheckProcessType) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7262.CheckIOType) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7262.CheckMaterialType) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7262.CheckMarketType) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7262.CheckRelationType) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7262.seDeliveryTerm) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7262.cdDeliveryTerm) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7262.seOrigin) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7262.cdOrigin) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7262.seCommercialTerm) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7262.cdCommercialTerm) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7262.sePaymentTerm) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7262.cdPaymentTerm) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7262.sePaymentCondition) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7262.cdPaymentCondition) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7262.sePaymentTime) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7262.cdPaymentTime) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7262.sePaymentDay) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7262.cdPaymentDay) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7262.seBuyingType) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7262.cdBuyingType) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7262.seUnitPrice) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7262.cdUnitPrice) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7262.DateExchange) & "', "
            SQL = SQL & "   " & FormatSQL(z7262.PriceExchange) & ", "
            SQL = SQL & "  N'" & FormatSQL(z7262.QualityRequest) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7262.ContractNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7262.Tolerance) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7262.Destination) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7262.DateInsert) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7262.DateUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7262.InchargeInsert) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7262.InchargeUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7262.InchargePurchasing) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7262.CheckSupplierPrice) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7262.DateComplete) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7262.DateApproved) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7262.DateCancel) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7262.DatePending1) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7262.DatePending2) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7262.CheckUse) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7262.Remark) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK7262 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK7262", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK7262(z7262 As T7262_AREA) As Boolean
        REWRITE_PFK7262 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z7262)

            SQL = " UPDATE PFK7262 SET "
            SQL = SQL & "    K7262_DateAccept      = N'" & FormatSQL(z7262.DateAccept) & "', "
            SQL = SQL & "    K7262_CustomerCode      = N'" & FormatSQL(z7262.CustomerCode) & "', "
            SQL = SQL & "    K7262_CheckProcessType      = N'" & FormatSQL(z7262.CheckProcessType) & "', "
            SQL = SQL & "    K7262_CheckIOType      = N'" & FormatSQL(z7262.CheckIOType) & "', "
            SQL = SQL & "    K7262_CheckMaterialType      = N'" & FormatSQL(z7262.CheckMaterialType) & "', "
            SQL = SQL & "    K7262_CheckMarketType      = N'" & FormatSQL(z7262.CheckMarketType) & "', "
            SQL = SQL & "    K7262_CheckRelationType      = N'" & FormatSQL(z7262.CheckRelationType) & "', "
            SQL = SQL & "    K7262_seDeliveryTerm      = N'" & FormatSQL(z7262.seDeliveryTerm) & "', "
            SQL = SQL & "    K7262_cdDeliveryTerm      = N'" & FormatSQL(z7262.cdDeliveryTerm) & "', "
            SQL = SQL & "    K7262_seOrigin      = N'" & FormatSQL(z7262.seOrigin) & "', "
            SQL = SQL & "    K7262_cdOrigin      = N'" & FormatSQL(z7262.cdOrigin) & "', "
            SQL = SQL & "    K7262_seCommercialTerm      = N'" & FormatSQL(z7262.seCommercialTerm) & "', "
            SQL = SQL & "    K7262_cdCommercialTerm      = N'" & FormatSQL(z7262.cdCommercialTerm) & "', "
            SQL = SQL & "    K7262_sePaymentTerm      = N'" & FormatSQL(z7262.sePaymentTerm) & "', "
            SQL = SQL & "    K7262_cdPaymentTerm      = N'" & FormatSQL(z7262.cdPaymentTerm) & "', "
            SQL = SQL & "    K7262_sePaymentCondition      = N'" & FormatSQL(z7262.sePaymentCondition) & "', "
            SQL = SQL & "    K7262_cdPaymentCondition      = N'" & FormatSQL(z7262.cdPaymentCondition) & "', "
            SQL = SQL & "    K7262_sePaymentTime      = N'" & FormatSQL(z7262.sePaymentTime) & "', "
            SQL = SQL & "    K7262_cdPaymentTime      = N'" & FormatSQL(z7262.cdPaymentTime) & "', "
            SQL = SQL & "    K7262_sePaymentDay      = N'" & FormatSQL(z7262.sePaymentDay) & "', "
            SQL = SQL & "    K7262_cdPaymentDay      = N'" & FormatSQL(z7262.cdPaymentDay) & "', "
            SQL = SQL & "    K7262_seBuyingType      = N'" & FormatSQL(z7262.seBuyingType) & "', "
            SQL = SQL & "    K7262_cdBuyingType      = N'" & FormatSQL(z7262.cdBuyingType) & "', "
            SQL = SQL & "    K7262_seUnitPrice      = N'" & FormatSQL(z7262.seUnitPrice) & "', "
            SQL = SQL & "    K7262_cdUnitPrice      = N'" & FormatSQL(z7262.cdUnitPrice) & "', "
            SQL = SQL & "    K7262_DateExchange      = N'" & FormatSQL(z7262.DateExchange) & "', "
            SQL = SQL & "    K7262_PriceExchange      =  " & FormatSQL(z7262.PriceExchange) & ", "
            SQL = SQL & "    K7262_QualityRequest      = N'" & FormatSQL(z7262.QualityRequest) & "', "
            SQL = SQL & "    K7262_ContractNo      = N'" & FormatSQL(z7262.ContractNo) & "', "
            SQL = SQL & "    K7262_Tolerance      = N'" & FormatSQL(z7262.Tolerance) & "', "
            SQL = SQL & "    K7262_Destination      = N'" & FormatSQL(z7262.Destination) & "', "
            SQL = SQL & "    K7262_DateInsert      = N'" & FormatSQL(z7262.DateInsert) & "', "
            SQL = SQL & "    K7262_DateUpdate      = N'" & FormatSQL(z7262.DateUpdate) & "', "
            SQL = SQL & "    K7262_InchargeInsert      = N'" & FormatSQL(z7262.InchargeInsert) & "', "
            SQL = SQL & "    K7262_InchargeUpdate      = N'" & FormatSQL(z7262.InchargeUpdate) & "', "
            SQL = SQL & "    K7262_InchargePurchasing      = N'" & FormatSQL(z7262.InchargePurchasing) & "', "
            SQL = SQL & "    K7262_CheckSupplierPrice      = N'" & FormatSQL(z7262.CheckSupplierPrice) & "', "
            SQL = SQL & "    K7262_DateComplete      = N'" & FormatSQL(z7262.DateComplete) & "', "
            SQL = SQL & "    K7262_DateApproved      = N'" & FormatSQL(z7262.DateApproved) & "', "
            SQL = SQL & "    K7262_DateCancel      = N'" & FormatSQL(z7262.DateCancel) & "', "
            SQL = SQL & "    K7262_DatePending1      = N'" & FormatSQL(z7262.DatePending1) & "', "
            SQL = SQL & "    K7262_DatePending2      = N'" & FormatSQL(z7262.DatePending2) & "', "
            SQL = SQL & "    K7262_CheckUse      = N'" & FormatSQL(z7262.CheckUse) & "', "
            SQL = SQL & "    K7262_Remark      = N'" & FormatSQL(z7262.Remark) & "'  "
            SQL = SQL & " WHERE K7262_ContractID		 = '" & z7262.ContractID & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK7262 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK7262", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK7262(z7262 As T7262_AREA) As Boolean
        DELETE_PFK7262 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK7262 "
            SQL = SQL & " WHERE K7262_ContractID		 = '" & z7262.ContractID & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK7262 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK7262", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D7262_CLEAR()
        Try

            D7262.ContractID = ""
            D7262.DateAccept = ""
            D7262.CustomerCode = ""
            D7262.CheckProcessType = ""
            D7262.CheckIOType = ""
            D7262.CheckMaterialType = ""
            D7262.CheckMarketType = ""
            D7262.CheckRelationType = ""
            D7262.seDeliveryTerm = ""
            D7262.cdDeliveryTerm = ""
            D7262.seOrigin = ""
            D7262.cdOrigin = ""
            D7262.seCommercialTerm = ""
            D7262.cdCommercialTerm = ""
            D7262.sePaymentTerm = ""
            D7262.cdPaymentTerm = ""
            D7262.sePaymentCondition = ""
            D7262.cdPaymentCondition = ""
            D7262.sePaymentTime = ""
            D7262.cdPaymentTime = ""
            D7262.sePaymentDay = ""
            D7262.cdPaymentDay = ""
            D7262.seBuyingType = ""
            D7262.cdBuyingType = ""
            D7262.seUnitPrice = ""
            D7262.cdUnitPrice = ""
            D7262.DateExchange = ""
            D7262.PriceExchange = 0
            D7262.QualityRequest = ""
            D7262.ContractNo = ""
            D7262.Tolerance = ""
            D7262.Destination = ""
            D7262.DateInsert = ""
            D7262.DateUpdate = ""
            D7262.InchargeInsert = ""
            D7262.InchargeUpdate = ""
            D7262.InchargePurchasing = ""
            D7262.CheckSupplierPrice = ""
            D7262.DateComplete = ""
            D7262.DateApproved = ""
            D7262.DateCancel = ""
            D7262.DatePending1 = ""
            D7262.DatePending2 = ""
            D7262.CheckUse = ""
            D7262.Remark = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D7262_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x7262 As T7262_AREA)
        Try

            x7262.ContractID = trim$(x7262.ContractID)
            x7262.DateAccept = trim$(x7262.DateAccept)
            x7262.CustomerCode = trim$(x7262.CustomerCode)
            x7262.CheckProcessType = trim$(x7262.CheckProcessType)
            x7262.CheckIOType = trim$(x7262.CheckIOType)
            x7262.CheckMaterialType = trim$(x7262.CheckMaterialType)
            x7262.CheckMarketType = trim$(x7262.CheckMarketType)
            x7262.CheckRelationType = trim$(x7262.CheckRelationType)
            x7262.seDeliveryTerm = trim$(x7262.seDeliveryTerm)
            x7262.cdDeliveryTerm = trim$(x7262.cdDeliveryTerm)
            x7262.seOrigin = trim$(x7262.seOrigin)
            x7262.cdOrigin = trim$(x7262.cdOrigin)
            x7262.seCommercialTerm = trim$(x7262.seCommercialTerm)
            x7262.cdCommercialTerm = trim$(x7262.cdCommercialTerm)
            x7262.sePaymentTerm = trim$(x7262.sePaymentTerm)
            x7262.cdPaymentTerm = trim$(x7262.cdPaymentTerm)
            x7262.sePaymentCondition = trim$(x7262.sePaymentCondition)
            x7262.cdPaymentCondition = trim$(x7262.cdPaymentCondition)
            x7262.sePaymentTime = trim$(x7262.sePaymentTime)
            x7262.cdPaymentTime = trim$(x7262.cdPaymentTime)
            x7262.sePaymentDay = trim$(x7262.sePaymentDay)
            x7262.cdPaymentDay = trim$(x7262.cdPaymentDay)
            x7262.seBuyingType = trim$(x7262.seBuyingType)
            x7262.cdBuyingType = trim$(x7262.cdBuyingType)
            x7262.seUnitPrice = trim$(x7262.seUnitPrice)
            x7262.cdUnitPrice = trim$(x7262.cdUnitPrice)
            x7262.DateExchange = trim$(x7262.DateExchange)
            x7262.PriceExchange = trim$(x7262.PriceExchange)
            x7262.QualityRequest = trim$(x7262.QualityRequest)
            x7262.ContractNo = trim$(x7262.ContractNo)
            x7262.Tolerance = trim$(x7262.Tolerance)
            x7262.Destination = trim$(x7262.Destination)
            x7262.DateInsert = trim$(x7262.DateInsert)
            x7262.DateUpdate = trim$(x7262.DateUpdate)
            x7262.InchargeInsert = trim$(x7262.InchargeInsert)
            x7262.InchargeUpdate = trim$(x7262.InchargeUpdate)
            x7262.InchargePurchasing = trim$(x7262.InchargePurchasing)
            x7262.CheckSupplierPrice = trim$(x7262.CheckSupplierPrice)
            x7262.DateComplete = trim$(x7262.DateComplete)
            x7262.DateApproved = trim$(x7262.DateApproved)
            x7262.DateCancel = trim$(x7262.DateCancel)
            x7262.DatePending1 = trim$(x7262.DatePending1)
            x7262.DatePending2 = trim$(x7262.DatePending2)
            x7262.CheckUse = trim$(x7262.CheckUse)
            x7262.Remark = trim$(x7262.Remark)

            If trim$(x7262.ContractID) = "" Then x7262.ContractID = Space(1)
            If trim$(x7262.DateAccept) = "" Then x7262.DateAccept = Space(1)
            If trim$(x7262.CustomerCode) = "" Then x7262.CustomerCode = Space(1)
            If trim$(x7262.CheckProcessType) = "" Then x7262.CheckProcessType = Space(1)
            If trim$(x7262.CheckIOType) = "" Then x7262.CheckIOType = Space(1)
            If trim$(x7262.CheckMaterialType) = "" Then x7262.CheckMaterialType = Space(1)
            If trim$(x7262.CheckMarketType) = "" Then x7262.CheckMarketType = Space(1)
            If trim$(x7262.CheckRelationType) = "" Then x7262.CheckRelationType = Space(1)
            If trim$(x7262.seDeliveryTerm) = "" Then x7262.seDeliveryTerm = Space(1)
            If trim$(x7262.cdDeliveryTerm) = "" Then x7262.cdDeliveryTerm = Space(1)
            If trim$(x7262.seOrigin) = "" Then x7262.seOrigin = Space(1)
            If trim$(x7262.cdOrigin) = "" Then x7262.cdOrigin = Space(1)
            If trim$(x7262.seCommercialTerm) = "" Then x7262.seCommercialTerm = Space(1)
            If trim$(x7262.cdCommercialTerm) = "" Then x7262.cdCommercialTerm = Space(1)
            If trim$(x7262.sePaymentTerm) = "" Then x7262.sePaymentTerm = Space(1)
            If trim$(x7262.cdPaymentTerm) = "" Then x7262.cdPaymentTerm = Space(1)
            If trim$(x7262.sePaymentCondition) = "" Then x7262.sePaymentCondition = Space(1)
            If trim$(x7262.cdPaymentCondition) = "" Then x7262.cdPaymentCondition = Space(1)
            If trim$(x7262.sePaymentTime) = "" Then x7262.sePaymentTime = Space(1)
            If trim$(x7262.cdPaymentTime) = "" Then x7262.cdPaymentTime = Space(1)
            If trim$(x7262.sePaymentDay) = "" Then x7262.sePaymentDay = Space(1)
            If trim$(x7262.cdPaymentDay) = "" Then x7262.cdPaymentDay = Space(1)
            If trim$(x7262.seBuyingType) = "" Then x7262.seBuyingType = Space(1)
            If trim$(x7262.cdBuyingType) = "" Then x7262.cdBuyingType = Space(1)
            If trim$(x7262.seUnitPrice) = "" Then x7262.seUnitPrice = Space(1)
            If trim$(x7262.cdUnitPrice) = "" Then x7262.cdUnitPrice = Space(1)
            If trim$(x7262.DateExchange) = "" Then x7262.DateExchange = Space(1)
            If trim$(x7262.PriceExchange) = "" Then x7262.PriceExchange = 0
            If trim$(x7262.QualityRequest) = "" Then x7262.QualityRequest = Space(1)
            If trim$(x7262.ContractNo) = "" Then x7262.ContractNo = Space(1)
            If trim$(x7262.Tolerance) = "" Then x7262.Tolerance = Space(1)
            If trim$(x7262.Destination) = "" Then x7262.Destination = Space(1)
            If trim$(x7262.DateInsert) = "" Then x7262.DateInsert = Space(1)
            If trim$(x7262.DateUpdate) = "" Then x7262.DateUpdate = Space(1)
            If trim$(x7262.InchargeInsert) = "" Then x7262.InchargeInsert = Space(1)
            If trim$(x7262.InchargeUpdate) = "" Then x7262.InchargeUpdate = Space(1)
            If trim$(x7262.InchargePurchasing) = "" Then x7262.InchargePurchasing = Space(1)
            If trim$(x7262.CheckSupplierPrice) = "" Then x7262.CheckSupplierPrice = Space(1)
            If trim$(x7262.DateComplete) = "" Then x7262.DateComplete = Space(1)
            If trim$(x7262.DateApproved) = "" Then x7262.DateApproved = Space(1)
            If trim$(x7262.DateCancel) = "" Then x7262.DateCancel = Space(1)
            If trim$(x7262.DatePending1) = "" Then x7262.DatePending1 = Space(1)
            If trim$(x7262.DatePending2) = "" Then x7262.DatePending2 = Space(1)
            If trim$(x7262.CheckUse) = "" Then x7262.CheckUse = Space(1)
            If trim$(x7262.Remark) = "" Then x7262.Remark = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K7262_MOVE(rs7262 As SqlClient.SqlDataReader)
        Try

            Call D7262_CLEAR()

            If IsdbNull(rs7262!K7262_ContractID) = False Then D7262.ContractID = Trim$(rs7262!K7262_ContractID)
            If IsdbNull(rs7262!K7262_DateAccept) = False Then D7262.DateAccept = Trim$(rs7262!K7262_DateAccept)
            If IsdbNull(rs7262!K7262_CustomerCode) = False Then D7262.CustomerCode = Trim$(rs7262!K7262_CustomerCode)
            If IsdbNull(rs7262!K7262_CheckProcessType) = False Then D7262.CheckProcessType = Trim$(rs7262!K7262_CheckProcessType)
            If IsdbNull(rs7262!K7262_CheckIOType) = False Then D7262.CheckIOType = Trim$(rs7262!K7262_CheckIOType)
            If IsdbNull(rs7262!K7262_CheckMaterialType) = False Then D7262.CheckMaterialType = Trim$(rs7262!K7262_CheckMaterialType)
            If IsdbNull(rs7262!K7262_CheckMarketType) = False Then D7262.CheckMarketType = Trim$(rs7262!K7262_CheckMarketType)
            If IsdbNull(rs7262!K7262_CheckRelationType) = False Then D7262.CheckRelationType = Trim$(rs7262!K7262_CheckRelationType)
            If IsdbNull(rs7262!K7262_seDeliveryTerm) = False Then D7262.seDeliveryTerm = Trim$(rs7262!K7262_seDeliveryTerm)
            If IsdbNull(rs7262!K7262_cdDeliveryTerm) = False Then D7262.cdDeliveryTerm = Trim$(rs7262!K7262_cdDeliveryTerm)
            If IsdbNull(rs7262!K7262_seOrigin) = False Then D7262.seOrigin = Trim$(rs7262!K7262_seOrigin)
            If IsdbNull(rs7262!K7262_cdOrigin) = False Then D7262.cdOrigin = Trim$(rs7262!K7262_cdOrigin)
            If IsdbNull(rs7262!K7262_seCommercialTerm) = False Then D7262.seCommercialTerm = Trim$(rs7262!K7262_seCommercialTerm)
            If IsdbNull(rs7262!K7262_cdCommercialTerm) = False Then D7262.cdCommercialTerm = Trim$(rs7262!K7262_cdCommercialTerm)
            If IsdbNull(rs7262!K7262_sePaymentTerm) = False Then D7262.sePaymentTerm = Trim$(rs7262!K7262_sePaymentTerm)
            If IsdbNull(rs7262!K7262_cdPaymentTerm) = False Then D7262.cdPaymentTerm = Trim$(rs7262!K7262_cdPaymentTerm)
            If IsdbNull(rs7262!K7262_sePaymentCondition) = False Then D7262.sePaymentCondition = Trim$(rs7262!K7262_sePaymentCondition)
            If IsdbNull(rs7262!K7262_cdPaymentCondition) = False Then D7262.cdPaymentCondition = Trim$(rs7262!K7262_cdPaymentCondition)
            If IsdbNull(rs7262!K7262_sePaymentTime) = False Then D7262.sePaymentTime = Trim$(rs7262!K7262_sePaymentTime)
            If IsdbNull(rs7262!K7262_cdPaymentTime) = False Then D7262.cdPaymentTime = Trim$(rs7262!K7262_cdPaymentTime)
            If IsdbNull(rs7262!K7262_sePaymentDay) = False Then D7262.sePaymentDay = Trim$(rs7262!K7262_sePaymentDay)
            If IsdbNull(rs7262!K7262_cdPaymentDay) = False Then D7262.cdPaymentDay = Trim$(rs7262!K7262_cdPaymentDay)
            If IsdbNull(rs7262!K7262_seBuyingType) = False Then D7262.seBuyingType = Trim$(rs7262!K7262_seBuyingType)
            If IsdbNull(rs7262!K7262_cdBuyingType) = False Then D7262.cdBuyingType = Trim$(rs7262!K7262_cdBuyingType)
            If IsdbNull(rs7262!K7262_seUnitPrice) = False Then D7262.seUnitPrice = Trim$(rs7262!K7262_seUnitPrice)
            If IsdbNull(rs7262!K7262_cdUnitPrice) = False Then D7262.cdUnitPrice = Trim$(rs7262!K7262_cdUnitPrice)
            If IsdbNull(rs7262!K7262_DateExchange) = False Then D7262.DateExchange = Trim$(rs7262!K7262_DateExchange)
            If IsdbNull(rs7262!K7262_PriceExchange) = False Then D7262.PriceExchange = Trim$(rs7262!K7262_PriceExchange)
            If IsdbNull(rs7262!K7262_QualityRequest) = False Then D7262.QualityRequest = Trim$(rs7262!K7262_QualityRequest)
            If IsdbNull(rs7262!K7262_ContractNo) = False Then D7262.ContractNo = Trim$(rs7262!K7262_ContractNo)
            If IsdbNull(rs7262!K7262_Tolerance) = False Then D7262.Tolerance = Trim$(rs7262!K7262_Tolerance)
            If IsdbNull(rs7262!K7262_Destination) = False Then D7262.Destination = Trim$(rs7262!K7262_Destination)
            If IsdbNull(rs7262!K7262_DateInsert) = False Then D7262.DateInsert = Trim$(rs7262!K7262_DateInsert)
            If IsdbNull(rs7262!K7262_DateUpdate) = False Then D7262.DateUpdate = Trim$(rs7262!K7262_DateUpdate)
            If IsdbNull(rs7262!K7262_InchargeInsert) = False Then D7262.InchargeInsert = Trim$(rs7262!K7262_InchargeInsert)
            If IsdbNull(rs7262!K7262_InchargeUpdate) = False Then D7262.InchargeUpdate = Trim$(rs7262!K7262_InchargeUpdate)
            If IsdbNull(rs7262!K7262_InchargePurchasing) = False Then D7262.InchargePurchasing = Trim$(rs7262!K7262_InchargePurchasing)
            If IsdbNull(rs7262!K7262_CheckSupplierPrice) = False Then D7262.CheckSupplierPrice = Trim$(rs7262!K7262_CheckSupplierPrice)
            If IsdbNull(rs7262!K7262_DateComplete) = False Then D7262.DateComplete = Trim$(rs7262!K7262_DateComplete)
            If IsdbNull(rs7262!K7262_DateApproved) = False Then D7262.DateApproved = Trim$(rs7262!K7262_DateApproved)
            If IsdbNull(rs7262!K7262_DateCancel) = False Then D7262.DateCancel = Trim$(rs7262!K7262_DateCancel)
            If IsdbNull(rs7262!K7262_DatePending1) = False Then D7262.DatePending1 = Trim$(rs7262!K7262_DatePending1)
            If IsdbNull(rs7262!K7262_DatePending2) = False Then D7262.DatePending2 = Trim$(rs7262!K7262_DatePending2)
            If IsdbNull(rs7262!K7262_CheckUse) = False Then D7262.CheckUse = Trim$(rs7262!K7262_CheckUse)
            If IsdbNull(rs7262!K7262_Remark) = False Then D7262.Remark = Trim$(rs7262!K7262_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K7262_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K7262_MOVE(rs7262 As DataRow)
        Try

            Call D7262_CLEAR()

            If IsdbNull(rs7262!K7262_ContractID) = False Then D7262.ContractID = Trim$(rs7262!K7262_ContractID)
            If IsdbNull(rs7262!K7262_DateAccept) = False Then D7262.DateAccept = Trim$(rs7262!K7262_DateAccept)
            If IsdbNull(rs7262!K7262_CustomerCode) = False Then D7262.CustomerCode = Trim$(rs7262!K7262_CustomerCode)
            If IsdbNull(rs7262!K7262_CheckProcessType) = False Then D7262.CheckProcessType = Trim$(rs7262!K7262_CheckProcessType)
            If IsdbNull(rs7262!K7262_CheckIOType) = False Then D7262.CheckIOType = Trim$(rs7262!K7262_CheckIOType)
            If IsdbNull(rs7262!K7262_CheckMaterialType) = False Then D7262.CheckMaterialType = Trim$(rs7262!K7262_CheckMaterialType)
            If IsdbNull(rs7262!K7262_CheckMarketType) = False Then D7262.CheckMarketType = Trim$(rs7262!K7262_CheckMarketType)
            If IsdbNull(rs7262!K7262_CheckRelationType) = False Then D7262.CheckRelationType = Trim$(rs7262!K7262_CheckRelationType)
            If IsdbNull(rs7262!K7262_seDeliveryTerm) = False Then D7262.seDeliveryTerm = Trim$(rs7262!K7262_seDeliveryTerm)
            If IsdbNull(rs7262!K7262_cdDeliveryTerm) = False Then D7262.cdDeliveryTerm = Trim$(rs7262!K7262_cdDeliveryTerm)
            If IsdbNull(rs7262!K7262_seOrigin) = False Then D7262.seOrigin = Trim$(rs7262!K7262_seOrigin)
            If IsdbNull(rs7262!K7262_cdOrigin) = False Then D7262.cdOrigin = Trim$(rs7262!K7262_cdOrigin)
            If IsdbNull(rs7262!K7262_seCommercialTerm) = False Then D7262.seCommercialTerm = Trim$(rs7262!K7262_seCommercialTerm)
            If IsdbNull(rs7262!K7262_cdCommercialTerm) = False Then D7262.cdCommercialTerm = Trim$(rs7262!K7262_cdCommercialTerm)
            If IsdbNull(rs7262!K7262_sePaymentTerm) = False Then D7262.sePaymentTerm = Trim$(rs7262!K7262_sePaymentTerm)
            If IsdbNull(rs7262!K7262_cdPaymentTerm) = False Then D7262.cdPaymentTerm = Trim$(rs7262!K7262_cdPaymentTerm)
            If IsdbNull(rs7262!K7262_sePaymentCondition) = False Then D7262.sePaymentCondition = Trim$(rs7262!K7262_sePaymentCondition)
            If IsdbNull(rs7262!K7262_cdPaymentCondition) = False Then D7262.cdPaymentCondition = Trim$(rs7262!K7262_cdPaymentCondition)
            If IsdbNull(rs7262!K7262_sePaymentTime) = False Then D7262.sePaymentTime = Trim$(rs7262!K7262_sePaymentTime)
            If IsdbNull(rs7262!K7262_cdPaymentTime) = False Then D7262.cdPaymentTime = Trim$(rs7262!K7262_cdPaymentTime)
            If IsdbNull(rs7262!K7262_sePaymentDay) = False Then D7262.sePaymentDay = Trim$(rs7262!K7262_sePaymentDay)
            If IsdbNull(rs7262!K7262_cdPaymentDay) = False Then D7262.cdPaymentDay = Trim$(rs7262!K7262_cdPaymentDay)
            If IsdbNull(rs7262!K7262_seBuyingType) = False Then D7262.seBuyingType = Trim$(rs7262!K7262_seBuyingType)
            If IsdbNull(rs7262!K7262_cdBuyingType) = False Then D7262.cdBuyingType = Trim$(rs7262!K7262_cdBuyingType)
            If IsdbNull(rs7262!K7262_seUnitPrice) = False Then D7262.seUnitPrice = Trim$(rs7262!K7262_seUnitPrice)
            If IsdbNull(rs7262!K7262_cdUnitPrice) = False Then D7262.cdUnitPrice = Trim$(rs7262!K7262_cdUnitPrice)
            If IsdbNull(rs7262!K7262_DateExchange) = False Then D7262.DateExchange = Trim$(rs7262!K7262_DateExchange)
            If IsdbNull(rs7262!K7262_PriceExchange) = False Then D7262.PriceExchange = Trim$(rs7262!K7262_PriceExchange)
            If IsdbNull(rs7262!K7262_QualityRequest) = False Then D7262.QualityRequest = Trim$(rs7262!K7262_QualityRequest)
            If IsdbNull(rs7262!K7262_ContractNo) = False Then D7262.ContractNo = Trim$(rs7262!K7262_ContractNo)
            If IsdbNull(rs7262!K7262_Tolerance) = False Then D7262.Tolerance = Trim$(rs7262!K7262_Tolerance)
            If IsdbNull(rs7262!K7262_Destination) = False Then D7262.Destination = Trim$(rs7262!K7262_Destination)
            If IsdbNull(rs7262!K7262_DateInsert) = False Then D7262.DateInsert = Trim$(rs7262!K7262_DateInsert)
            If IsdbNull(rs7262!K7262_DateUpdate) = False Then D7262.DateUpdate = Trim$(rs7262!K7262_DateUpdate)
            If IsdbNull(rs7262!K7262_InchargeInsert) = False Then D7262.InchargeInsert = Trim$(rs7262!K7262_InchargeInsert)
            If IsdbNull(rs7262!K7262_InchargeUpdate) = False Then D7262.InchargeUpdate = Trim$(rs7262!K7262_InchargeUpdate)
            If IsdbNull(rs7262!K7262_InchargePurchasing) = False Then D7262.InchargePurchasing = Trim$(rs7262!K7262_InchargePurchasing)
            If IsdbNull(rs7262!K7262_CheckSupplierPrice) = False Then D7262.CheckSupplierPrice = Trim$(rs7262!K7262_CheckSupplierPrice)
            If IsdbNull(rs7262!K7262_DateComplete) = False Then D7262.DateComplete = Trim$(rs7262!K7262_DateComplete)
            If IsdbNull(rs7262!K7262_DateApproved) = False Then D7262.DateApproved = Trim$(rs7262!K7262_DateApproved)
            If IsdbNull(rs7262!K7262_DateCancel) = False Then D7262.DateCancel = Trim$(rs7262!K7262_DateCancel)
            If IsdbNull(rs7262!K7262_DatePending1) = False Then D7262.DatePending1 = Trim$(rs7262!K7262_DatePending1)
            If IsdbNull(rs7262!K7262_DatePending2) = False Then D7262.DatePending2 = Trim$(rs7262!K7262_DatePending2)
            If IsdbNull(rs7262!K7262_CheckUse) = False Then D7262.CheckUse = Trim$(rs7262!K7262_CheckUse)
            If IsdbNull(rs7262!K7262_Remark) = False Then D7262.Remark = Trim$(rs7262!K7262_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K7262_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K7262_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z7262 As T7262_AREA, CONTRACTID As String) As Boolean

        K7262_MOVE = False

        Try
            If READ_PFK7262(CONTRACTID) = True Then
                z7262 = D7262
                K7262_MOVE = True
            Else
                z7262 = Nothing
            End If

            If getColumIndex(spr, "ContractID") > -1 Then z7262.ContractID = getDataM(spr, getColumIndex(spr, "ContractID"), xRow)
            If getColumIndex(spr, "DateAccept") > -1 Then z7262.DateAccept = getDataM(spr, getColumIndex(spr, "DateAccept"), xRow)
            If getColumIndex(spr, "CustomerCode") > -1 Then z7262.CustomerCode = getDataM(spr, getColumIndex(spr, "CustomerCode"), xRow)
            If getColumIndex(spr, "CheckProcessType") > -1 Then z7262.CheckProcessType = getDataM(spr, getColumIndex(spr, "CheckProcessType"), xRow)
            If getColumIndex(spr, "CheckIOType") > -1 Then z7262.CheckIOType = getDataM(spr, getColumIndex(spr, "CheckIOType"), xRow)
            If getColumIndex(spr, "CheckMaterialType") > -1 Then z7262.CheckMaterialType = getDataM(spr, getColumIndex(spr, "CheckMaterialType"), xRow)
            If getColumIndex(spr, "CheckMarketType") > -1 Then z7262.CheckMarketType = getDataM(spr, getColumIndex(spr, "CheckMarketType"), xRow)
            If getColumIndex(spr, "CheckRelationType") > -1 Then z7262.CheckRelationType = getDataM(spr, getColumIndex(spr, "CheckRelationType"), xRow)
            If getColumIndex(spr, "seDeliveryTerm") > -1 Then z7262.seDeliveryTerm = getDataM(spr, getColumIndex(spr, "seDeliveryTerm"), xRow)
            If getColumIndex(spr, "cdDeliveryTerm") > -1 Then z7262.cdDeliveryTerm = getDataM(spr, getColumIndex(spr, "cdDeliveryTerm"), xRow)
            If getColumIndex(spr, "seOrigin") > -1 Then z7262.seOrigin = getDataM(spr, getColumIndex(spr, "seOrigin"), xRow)
            If getColumIndex(spr, "cdOrigin") > -1 Then z7262.cdOrigin = getDataM(spr, getColumIndex(spr, "cdOrigin"), xRow)
            If getColumIndex(spr, "seCommercialTerm") > -1 Then z7262.seCommercialTerm = getDataM(spr, getColumIndex(spr, "seCommercialTerm"), xRow)
            If getColumIndex(spr, "cdCommercialTerm") > -1 Then z7262.cdCommercialTerm = getDataM(spr, getColumIndex(spr, "cdCommercialTerm"), xRow)
            If getColumIndex(spr, "sePaymentTerm") > -1 Then z7262.sePaymentTerm = getDataM(spr, getColumIndex(spr, "sePaymentTerm"), xRow)
            If getColumIndex(spr, "cdPaymentTerm") > -1 Then z7262.cdPaymentTerm = getDataM(spr, getColumIndex(spr, "cdPaymentTerm"), xRow)
            If getColumIndex(spr, "sePaymentCondition") > -1 Then z7262.sePaymentCondition = getDataM(spr, getColumIndex(spr, "sePaymentCondition"), xRow)
            If getColumIndex(spr, "cdPaymentCondition") > -1 Then z7262.cdPaymentCondition = getDataM(spr, getColumIndex(spr, "cdPaymentCondition"), xRow)
            If getColumIndex(spr, "sePaymentTime") > -1 Then z7262.sePaymentTime = getDataM(spr, getColumIndex(spr, "sePaymentTime"), xRow)
            If getColumIndex(spr, "cdPaymentTime") > -1 Then z7262.cdPaymentTime = getDataM(spr, getColumIndex(spr, "cdPaymentTime"), xRow)
            If getColumIndex(spr, "sePaymentDay") > -1 Then z7262.sePaymentDay = getDataM(spr, getColumIndex(spr, "sePaymentDay"), xRow)
            If getColumIndex(spr, "cdPaymentDay") > -1 Then z7262.cdPaymentDay = getDataM(spr, getColumIndex(spr, "cdPaymentDay"), xRow)
            If getColumIndex(spr, "seBuyingType") > -1 Then z7262.seBuyingType = getDataM(spr, getColumIndex(spr, "seBuyingType"), xRow)
            If getColumIndex(spr, "cdBuyingType") > -1 Then z7262.cdBuyingType = getDataM(spr, getColumIndex(spr, "cdBuyingType"), xRow)
            If getColumIndex(spr, "seUnitPrice") > -1 Then z7262.seUnitPrice = getDataM(spr, getColumIndex(spr, "seUnitPrice"), xRow)
            If getColumIndex(spr, "cdUnitPrice") > -1 Then z7262.cdUnitPrice = getDataM(spr, getColumIndex(spr, "cdUnitPrice"), xRow)
            If getColumIndex(spr, "DateExchange") > -1 Then z7262.DateExchange = getDataM(spr, getColumIndex(spr, "DateExchange"), xRow)
            If getColumIndex(spr, "PriceExchange") > -1 Then z7262.PriceExchange = getDataM(spr, getColumIndex(spr, "PriceExchange"), xRow)
            If getColumIndex(spr, "QualityRequest") > -1 Then z7262.QualityRequest = getDataM(spr, getColumIndex(spr, "QualityRequest"), xRow)
            If getColumIndex(spr, "ContractNo") > -1 Then z7262.ContractNo = getDataM(spr, getColumIndex(spr, "ContractNo"), xRow)
            If getColumIndex(spr, "Tolerance") > -1 Then z7262.Tolerance = getDataM(spr, getColumIndex(spr, "Tolerance"), xRow)
            If getColumIndex(spr, "Destination") > -1 Then z7262.Destination = getDataM(spr, getColumIndex(spr, "Destination"), xRow)
            If getColumIndex(spr, "DateInsert") > -1 Then z7262.DateInsert = getDataM(spr, getColumIndex(spr, "DateInsert"), xRow)
            If getColumIndex(spr, "DateUpdate") > -1 Then z7262.DateUpdate = getDataM(spr, getColumIndex(spr, "DateUpdate"), xRow)
            If getColumIndex(spr, "InchargeInsert") > -1 Then z7262.InchargeInsert = getDataM(spr, getColumIndex(spr, "InchargeInsert"), xRow)
            If getColumIndex(spr, "InchargeUpdate") > -1 Then z7262.InchargeUpdate = getDataM(spr, getColumIndex(spr, "InchargeUpdate"), xRow)
            If getColumIndex(spr, "InchargePurchasing") > -1 Then z7262.InchargePurchasing = getDataM(spr, getColumIndex(spr, "InchargePurchasing"), xRow)
            If getColumIndex(spr, "CheckSupplierPrice") > -1 Then z7262.CheckSupplierPrice = getDataM(spr, getColumIndex(spr, "CheckSupplierPrice"), xRow)
            If getColumIndex(spr, "DateComplete") > -1 Then z7262.DateComplete = getDataM(spr, getColumIndex(spr, "DateComplete"), xRow)
            If getColumIndex(spr, "DateApproved") > -1 Then z7262.DateApproved = getDataM(spr, getColumIndex(spr, "DateApproved"), xRow)
            If getColumIndex(spr, "DateCancel") > -1 Then z7262.DateCancel = getDataM(spr, getColumIndex(spr, "DateCancel"), xRow)
            If getColumIndex(spr, "DatePending1") > -1 Then z7262.DatePending1 = getDataM(spr, getColumIndex(spr, "DatePending1"), xRow)
            If getColumIndex(spr, "DatePending2") > -1 Then z7262.DatePending2 = getDataM(spr, getColumIndex(spr, "DatePending2"), xRow)
            If getColumIndex(spr, "CheckUse") > -1 Then z7262.CheckUse = getDataM(spr, getColumIndex(spr, "CheckUse"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z7262.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7262_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K7262_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z7262 As T7262_AREA, CheckClear As Boolean, CONTRACTID As String) As Boolean

        K7262_MOVE = False

        Try
            If READ_PFK7262(CONTRACTID) = True Then
                z7262 = D7262
                K7262_MOVE = True
            Else
                If CheckClear = True Then z7262 = Nothing
            End If

            If getColumIndex(spr, "ContractID") > -1 Then z7262.ContractID = getDataM(spr, getColumIndex(spr, "ContractID"), xRow)
            If getColumIndex(spr, "DateAccept") > -1 Then z7262.DateAccept = getDataM(spr, getColumIndex(spr, "DateAccept"), xRow)
            If getColumIndex(spr, "CustomerCode") > -1 Then z7262.CustomerCode = getDataM(spr, getColumIndex(spr, "CustomerCode"), xRow)
            If getColumIndex(spr, "CheckProcessType") > -1 Then z7262.CheckProcessType = getDataM(spr, getColumIndex(spr, "CheckProcessType"), xRow)
            If getColumIndex(spr, "CheckIOType") > -1 Then z7262.CheckIOType = getDataM(spr, getColumIndex(spr, "CheckIOType"), xRow)
            If getColumIndex(spr, "CheckMaterialType") > -1 Then z7262.CheckMaterialType = getDataM(spr, getColumIndex(spr, "CheckMaterialType"), xRow)
            If getColumIndex(spr, "CheckMarketType") > -1 Then z7262.CheckMarketType = getDataM(spr, getColumIndex(spr, "CheckMarketType"), xRow)
            If getColumIndex(spr, "CheckRelationType") > -1 Then z7262.CheckRelationType = getDataM(spr, getColumIndex(spr, "CheckRelationType"), xRow)
            If getColumIndex(spr, "seDeliveryTerm") > -1 Then z7262.seDeliveryTerm = getDataM(spr, getColumIndex(spr, "seDeliveryTerm"), xRow)
            If getColumIndex(spr, "cdDeliveryTerm") > -1 Then z7262.cdDeliveryTerm = getDataM(spr, getColumIndex(spr, "cdDeliveryTerm"), xRow)
            If getColumIndex(spr, "seOrigin") > -1 Then z7262.seOrigin = getDataM(spr, getColumIndex(spr, "seOrigin"), xRow)
            If getColumIndex(spr, "cdOrigin") > -1 Then z7262.cdOrigin = getDataM(spr, getColumIndex(spr, "cdOrigin"), xRow)
            If getColumIndex(spr, "seCommercialTerm") > -1 Then z7262.seCommercialTerm = getDataM(spr, getColumIndex(spr, "seCommercialTerm"), xRow)
            If getColumIndex(spr, "cdCommercialTerm") > -1 Then z7262.cdCommercialTerm = getDataM(spr, getColumIndex(spr, "cdCommercialTerm"), xRow)
            If getColumIndex(spr, "sePaymentTerm") > -1 Then z7262.sePaymentTerm = getDataM(spr, getColumIndex(spr, "sePaymentTerm"), xRow)
            If getColumIndex(spr, "cdPaymentTerm") > -1 Then z7262.cdPaymentTerm = getDataM(spr, getColumIndex(spr, "cdPaymentTerm"), xRow)
            If getColumIndex(spr, "sePaymentCondition") > -1 Then z7262.sePaymentCondition = getDataM(spr, getColumIndex(spr, "sePaymentCondition"), xRow)
            If getColumIndex(spr, "cdPaymentCondition") > -1 Then z7262.cdPaymentCondition = getDataM(spr, getColumIndex(spr, "cdPaymentCondition"), xRow)
            If getColumIndex(spr, "sePaymentTime") > -1 Then z7262.sePaymentTime = getDataM(spr, getColumIndex(spr, "sePaymentTime"), xRow)
            If getColumIndex(spr, "cdPaymentTime") > -1 Then z7262.cdPaymentTime = getDataM(spr, getColumIndex(spr, "cdPaymentTime"), xRow)
            If getColumIndex(spr, "sePaymentDay") > -1 Then z7262.sePaymentDay = getDataM(spr, getColumIndex(spr, "sePaymentDay"), xRow)
            If getColumIndex(spr, "cdPaymentDay") > -1 Then z7262.cdPaymentDay = getDataM(spr, getColumIndex(spr, "cdPaymentDay"), xRow)
            If getColumIndex(spr, "seBuyingType") > -1 Then z7262.seBuyingType = getDataM(spr, getColumIndex(spr, "seBuyingType"), xRow)
            If getColumIndex(spr, "cdBuyingType") > -1 Then z7262.cdBuyingType = getDataM(spr, getColumIndex(spr, "cdBuyingType"), xRow)
            If getColumIndex(spr, "seUnitPrice") > -1 Then z7262.seUnitPrice = getDataM(spr, getColumIndex(spr, "seUnitPrice"), xRow)
            If getColumIndex(spr, "cdUnitPrice") > -1 Then z7262.cdUnitPrice = getDataM(spr, getColumIndex(spr, "cdUnitPrice"), xRow)
            If getColumIndex(spr, "DateExchange") > -1 Then z7262.DateExchange = getDataM(spr, getColumIndex(spr, "DateExchange"), xRow)
            If getColumIndex(spr, "PriceExchange") > -1 Then z7262.PriceExchange = getDataM(spr, getColumIndex(spr, "PriceExchange"), xRow)
            If getColumIndex(spr, "QualityRequest") > -1 Then z7262.QualityRequest = getDataM(spr, getColumIndex(spr, "QualityRequest"), xRow)
            If getColumIndex(spr, "ContractNo") > -1 Then z7262.ContractNo = getDataM(spr, getColumIndex(spr, "ContractNo"), xRow)
            If getColumIndex(spr, "Tolerance") > -1 Then z7262.Tolerance = getDataM(spr, getColumIndex(spr, "Tolerance"), xRow)
            If getColumIndex(spr, "Destination") > -1 Then z7262.Destination = getDataM(spr, getColumIndex(spr, "Destination"), xRow)
            If getColumIndex(spr, "DateInsert") > -1 Then z7262.DateInsert = getDataM(spr, getColumIndex(spr, "DateInsert"), xRow)
            If getColumIndex(spr, "DateUpdate") > -1 Then z7262.DateUpdate = getDataM(spr, getColumIndex(spr, "DateUpdate"), xRow)
            If getColumIndex(spr, "InchargeInsert") > -1 Then z7262.InchargeInsert = getDataM(spr, getColumIndex(spr, "InchargeInsert"), xRow)
            If getColumIndex(spr, "InchargeUpdate") > -1 Then z7262.InchargeUpdate = getDataM(spr, getColumIndex(spr, "InchargeUpdate"), xRow)
            If getColumIndex(spr, "InchargePurchasing") > -1 Then z7262.InchargePurchasing = getDataM(spr, getColumIndex(spr, "InchargePurchasing"), xRow)
            If getColumIndex(spr, "CheckSupplierPrice") > -1 Then z7262.CheckSupplierPrice = getDataM(spr, getColumIndex(spr, "CheckSupplierPrice"), xRow)
            If getColumIndex(spr, "DateComplete") > -1 Then z7262.DateComplete = getDataM(spr, getColumIndex(spr, "DateComplete"), xRow)
            If getColumIndex(spr, "DateApproved") > -1 Then z7262.DateApproved = getDataM(spr, getColumIndex(spr, "DateApproved"), xRow)
            If getColumIndex(spr, "DateCancel") > -1 Then z7262.DateCancel = getDataM(spr, getColumIndex(spr, "DateCancel"), xRow)
            If getColumIndex(spr, "DatePending1") > -1 Then z7262.DatePending1 = getDataM(spr, getColumIndex(spr, "DatePending1"), xRow)
            If getColumIndex(spr, "DatePending2") > -1 Then z7262.DatePending2 = getDataM(spr, getColumIndex(spr, "DatePending2"), xRow)
            If getColumIndex(spr, "CheckUse") > -1 Then z7262.CheckUse = getDataM(spr, getColumIndex(spr, "CheckUse"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z7262.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7262_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K7262_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z7262 As T7262_AREA, Job As String, CONTRACTID As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K7262_MOVE = False

        Try
            If READ_PFK7262(CONTRACTID) = True Then
                z7262 = D7262
                K7262_MOVE = True
            Else
                z7262 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7262")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "CONTRACTID" : z7262.ContractID = Children(i).Code
                                Case "DATEACCEPT" : z7262.DateAccept = Children(i).Code
                                Case "CUSTOMERCODE" : z7262.CustomerCode = Children(i).Code
                                Case "CHECKPROCESSTYPE" : z7262.CheckProcessType = Children(i).Code
                                Case "CHECKIOTYPE" : z7262.CheckIOType = Children(i).Code
                                Case "CHECKMATERIALTYPE" : z7262.CheckMaterialType = Children(i).Code
                                Case "CHECKMARKETTYPE" : z7262.CheckMarketType = Children(i).Code
                                Case "CHECKRELATIONTYPE" : z7262.CheckRelationType = Children(i).Code
                                Case "SEDELIVERYTERM" : z7262.seDeliveryTerm = Children(i).Code
                                Case "CDDELIVERYTERM" : z7262.cdDeliveryTerm = Children(i).Code
                                Case "SEORIGIN" : z7262.seOrigin = Children(i).Code
                                Case "CDORIGIN" : z7262.cdOrigin = Children(i).Code
                                Case "SECOMMERCIALTERM" : z7262.seCommercialTerm = Children(i).Code
                                Case "CDCOMMERCIALTERM" : z7262.cdCommercialTerm = Children(i).Code
                                Case "SEPAYMENTTERM" : z7262.sePaymentTerm = Children(i).Code
                                Case "CDPAYMENTTERM" : z7262.cdPaymentTerm = Children(i).Code
                                Case "SEPAYMENTCONDITION" : z7262.sePaymentCondition = Children(i).Code
                                Case "CDPAYMENTCONDITION" : z7262.cdPaymentCondition = Children(i).Code
                                Case "SEPAYMENTTIME" : z7262.sePaymentTime = Children(i).Code
                                Case "CDPAYMENTTIME" : z7262.cdPaymentTime = Children(i).Code
                                Case "SEPAYMENTDAY" : z7262.sePaymentDay = Children(i).Code
                                Case "CDPAYMENTDAY" : z7262.cdPaymentDay = Children(i).Code
                                Case "SEBUYINGTYPE" : z7262.seBuyingType = Children(i).Code
                                Case "CDBUYINGTYPE" : z7262.cdBuyingType = Children(i).Code
                                Case "SEUNITPRICE" : z7262.seUnitPrice = Children(i).Code
                                Case "CDUNITPRICE" : z7262.cdUnitPrice = Children(i).Code
                                Case "DATEEXCHANGE" : z7262.DateExchange = Children(i).Code
                                Case "PRICEEXCHANGE" : z7262.PriceExchange = Children(i).Code
                                Case "QUALITYREQUEST" : z7262.QualityRequest = Children(i).Code
                                Case "CONTRACTNO" : z7262.ContractNo = Children(i).Code
                                Case "TOLERANCE" : z7262.Tolerance = Children(i).Code
                                Case "DESTINATION" : z7262.Destination = Children(i).Code
                                Case "DATEINSERT" : z7262.DateInsert = Children(i).Code
                                Case "DATEUPDATE" : z7262.DateUpdate = Children(i).Code
                                Case "INCHARGEINSERT" : z7262.InchargeInsert = Children(i).Code
                                Case "INCHARGEUPDATE" : z7262.InchargeUpdate = Children(i).Code
                                Case "INCHARGEPURCHASING" : z7262.InchargePurchasing = Children(i).Code
                                Case "CHECKSUPPLIERPRICE" : z7262.CheckSupplierPrice = Children(i).Code
                                Case "DATECOMPLETE" : z7262.DateComplete = Children(i).Code
                                Case "DATEAPPROVED" : z7262.DateApproved = Children(i).Code
                                Case "DATECANCEL" : z7262.DateCancel = Children(i).Code
                                Case "DATEPENDING1" : z7262.DatePending1 = Children(i).Code
                                Case "DATEPENDING2" : z7262.DatePending2 = Children(i).Code
                                Case "CHECKUSE" : z7262.CheckUse = Children(i).Code
                                Case "REMARK" : z7262.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "CONTRACTID" : z7262.ContractID = Children(i).Data
                                Case "DATEACCEPT" : z7262.DateAccept = Children(i).Data
                                Case "CUSTOMERCODE" : z7262.CustomerCode = Children(i).Data
                                Case "CHECKPROCESSTYPE" : z7262.CheckProcessType = Children(i).Data
                                Case "CHECKIOTYPE" : z7262.CheckIOType = Children(i).Data
                                Case "CHECKMATERIALTYPE" : z7262.CheckMaterialType = Children(i).Data
                                Case "CHECKMARKETTYPE" : z7262.CheckMarketType = Children(i).Data
                                Case "CHECKRELATIONTYPE" : z7262.CheckRelationType = Children(i).Data
                                Case "SEDELIVERYTERM" : z7262.seDeliveryTerm = Children(i).Data
                                Case "CDDELIVERYTERM" : z7262.cdDeliveryTerm = Children(i).Data
                                Case "SEORIGIN" : z7262.seOrigin = Children(i).Data
                                Case "CDORIGIN" : z7262.cdOrigin = Children(i).Data
                                Case "SECOMMERCIALTERM" : z7262.seCommercialTerm = Children(i).Data
                                Case "CDCOMMERCIALTERM" : z7262.cdCommercialTerm = Children(i).Data
                                Case "SEPAYMENTTERM" : z7262.sePaymentTerm = Children(i).Data
                                Case "CDPAYMENTTERM" : z7262.cdPaymentTerm = Children(i).Data
                                Case "SEPAYMENTCONDITION" : z7262.sePaymentCondition = Children(i).Data
                                Case "CDPAYMENTCONDITION" : z7262.cdPaymentCondition = Children(i).Data
                                Case "SEPAYMENTTIME" : z7262.sePaymentTime = Children(i).Data
                                Case "CDPAYMENTTIME" : z7262.cdPaymentTime = Children(i).Data
                                Case "SEPAYMENTDAY" : z7262.sePaymentDay = Children(i).Data
                                Case "CDPAYMENTDAY" : z7262.cdPaymentDay = Children(i).Data
                                Case "SEBUYINGTYPE" : z7262.seBuyingType = Children(i).Data
                                Case "CDBUYINGTYPE" : z7262.cdBuyingType = Children(i).Data
                                Case "SEUNITPRICE" : z7262.seUnitPrice = Children(i).Data
                                Case "CDUNITPRICE" : z7262.cdUnitPrice = Children(i).Data
                                Case "DATEEXCHANGE" : z7262.DateExchange = Children(i).Data
                                Case "PRICEEXCHANGE" : z7262.PriceExchange = Children(i).Data
                                Case "QUALITYREQUEST" : z7262.QualityRequest = Children(i).Data
                                Case "CONTRACTNO" : z7262.ContractNo = Children(i).Data
                                Case "TOLERANCE" : z7262.Tolerance = Children(i).Data
                                Case "DESTINATION" : z7262.Destination = Children(i).Data
                                Case "DATEINSERT" : z7262.DateInsert = Children(i).Data
                                Case "DATEUPDATE" : z7262.DateUpdate = Children(i).Data
                                Case "INCHARGEINSERT" : z7262.InchargeInsert = Children(i).Data
                                Case "INCHARGEUPDATE" : z7262.InchargeUpdate = Children(i).Data
                                Case "INCHARGEPURCHASING" : z7262.InchargePurchasing = Children(i).Data
                                Case "CHECKSUPPLIERPRICE" : z7262.CheckSupplierPrice = Children(i).Data
                                Case "DATECOMPLETE" : z7262.DateComplete = Children(i).Data
                                Case "DATEAPPROVED" : z7262.DateApproved = Children(i).Data
                                Case "DATECANCEL" : z7262.DateCancel = Children(i).Data
                                Case "DATEPENDING1" : z7262.DatePending1 = Children(i).Data
                                Case "DATEPENDING2" : z7262.DatePending2 = Children(i).Data
                                Case "CHECKUSE" : z7262.CheckUse = Children(i).Data
                                Case "REMARK" : z7262.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7262_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K7262_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z7262 As T7262_AREA, Job As String, CheckClear As Boolean, CONTRACTID As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K7262_MOVE = False

        Try
            If READ_PFK7262(CONTRACTID) = True Then
                z7262 = D7262
                K7262_MOVE = True
            Else
                If CheckClear = True Then z7262 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7262")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "CONTRACTID" : z7262.ContractID = Children(i).Code
                                Case "DATEACCEPT" : z7262.DateAccept = Children(i).Code
                                Case "CUSTOMERCODE" : z7262.CustomerCode = Children(i).Code
                                Case "CHECKPROCESSTYPE" : z7262.CheckProcessType = Children(i).Code
                                Case "CHECKIOTYPE" : z7262.CheckIOType = Children(i).Code
                                Case "CHECKMATERIALTYPE" : z7262.CheckMaterialType = Children(i).Code
                                Case "CHECKMARKETTYPE" : z7262.CheckMarketType = Children(i).Code
                                Case "CHECKRELATIONTYPE" : z7262.CheckRelationType = Children(i).Code
                                Case "SEDELIVERYTERM" : z7262.seDeliveryTerm = Children(i).Code
                                Case "CDDELIVERYTERM" : z7262.cdDeliveryTerm = Children(i).Code
                                Case "SEORIGIN" : z7262.seOrigin = Children(i).Code
                                Case "CDORIGIN" : z7262.cdOrigin = Children(i).Code
                                Case "SECOMMERCIALTERM" : z7262.seCommercialTerm = Children(i).Code
                                Case "CDCOMMERCIALTERM" : z7262.cdCommercialTerm = Children(i).Code
                                Case "SEPAYMENTTERM" : z7262.sePaymentTerm = Children(i).Code
                                Case "CDPAYMENTTERM" : z7262.cdPaymentTerm = Children(i).Code
                                Case "SEPAYMENTCONDITION" : z7262.sePaymentCondition = Children(i).Code
                                Case "CDPAYMENTCONDITION" : z7262.cdPaymentCondition = Children(i).Code
                                Case "SEPAYMENTTIME" : z7262.sePaymentTime = Children(i).Code
                                Case "CDPAYMENTTIME" : z7262.cdPaymentTime = Children(i).Code
                                Case "SEPAYMENTDAY" : z7262.sePaymentDay = Children(i).Code
                                Case "CDPAYMENTDAY" : z7262.cdPaymentDay = Children(i).Code
                                Case "SEBUYINGTYPE" : z7262.seBuyingType = Children(i).Code
                                Case "CDBUYINGTYPE" : z7262.cdBuyingType = Children(i).Code
                                Case "SEUNITPRICE" : z7262.seUnitPrice = Children(i).Code
                                Case "CDUNITPRICE" : z7262.cdUnitPrice = Children(i).Code
                                Case "DATEEXCHANGE" : z7262.DateExchange = Children(i).Code
                                Case "PRICEEXCHANGE" : z7262.PriceExchange = Children(i).Code
                                Case "QUALITYREQUEST" : z7262.QualityRequest = Children(i).Code
                                Case "CONTRACTNO" : z7262.ContractNo = Children(i).Code
                                Case "TOLERANCE" : z7262.Tolerance = Children(i).Code
                                Case "DESTINATION" : z7262.Destination = Children(i).Code
                                Case "DATEINSERT" : z7262.DateInsert = Children(i).Code
                                Case "DATEUPDATE" : z7262.DateUpdate = Children(i).Code
                                Case "INCHARGEINSERT" : z7262.InchargeInsert = Children(i).Code
                                Case "INCHARGEUPDATE" : z7262.InchargeUpdate = Children(i).Code
                                Case "INCHARGEPURCHASING" : z7262.InchargePurchasing = Children(i).Code
                                Case "CHECKSUPPLIERPRICE" : z7262.CheckSupplierPrice = Children(i).Code
                                Case "DATECOMPLETE" : z7262.DateComplete = Children(i).Code
                                Case "DATEAPPROVED" : z7262.DateApproved = Children(i).Code
                                Case "DATECANCEL" : z7262.DateCancel = Children(i).Code
                                Case "DATEPENDING1" : z7262.DatePending1 = Children(i).Code
                                Case "DATEPENDING2" : z7262.DatePending2 = Children(i).Code
                                Case "CHECKUSE" : z7262.CheckUse = Children(i).Code
                                Case "REMARK" : z7262.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "CONTRACTID" : z7262.ContractID = Children(i).Data
                                Case "DATEACCEPT" : z7262.DateAccept = Children(i).Data
                                Case "CUSTOMERCODE" : z7262.CustomerCode = Children(i).Data
                                Case "CHECKPROCESSTYPE" : z7262.CheckProcessType = Children(i).Data
                                Case "CHECKIOTYPE" : z7262.CheckIOType = Children(i).Data
                                Case "CHECKMATERIALTYPE" : z7262.CheckMaterialType = Children(i).Data
                                Case "CHECKMARKETTYPE" : z7262.CheckMarketType = Children(i).Data
                                Case "CHECKRELATIONTYPE" : z7262.CheckRelationType = Children(i).Data
                                Case "SEDELIVERYTERM" : z7262.seDeliveryTerm = Children(i).Data
                                Case "CDDELIVERYTERM" : z7262.cdDeliveryTerm = Children(i).Data
                                Case "SEORIGIN" : z7262.seOrigin = Children(i).Data
                                Case "CDORIGIN" : z7262.cdOrigin = Children(i).Data
                                Case "SECOMMERCIALTERM" : z7262.seCommercialTerm = Children(i).Data
                                Case "CDCOMMERCIALTERM" : z7262.cdCommercialTerm = Children(i).Data
                                Case "SEPAYMENTTERM" : z7262.sePaymentTerm = Children(i).Data
                                Case "CDPAYMENTTERM" : z7262.cdPaymentTerm = Children(i).Data
                                Case "SEPAYMENTCONDITION" : z7262.sePaymentCondition = Children(i).Data
                                Case "CDPAYMENTCONDITION" : z7262.cdPaymentCondition = Children(i).Data
                                Case "SEPAYMENTTIME" : z7262.sePaymentTime = Children(i).Data
                                Case "CDPAYMENTTIME" : z7262.cdPaymentTime = Children(i).Data
                                Case "SEPAYMENTDAY" : z7262.sePaymentDay = Children(i).Data
                                Case "CDPAYMENTDAY" : z7262.cdPaymentDay = Children(i).Data
                                Case "SEBUYINGTYPE" : z7262.seBuyingType = Children(i).Data
                                Case "CDBUYINGTYPE" : z7262.cdBuyingType = Children(i).Data
                                Case "SEUNITPRICE" : z7262.seUnitPrice = Children(i).Data
                                Case "CDUNITPRICE" : z7262.cdUnitPrice = Children(i).Data
                                Case "DATEEXCHANGE" : z7262.DateExchange = Children(i).Data
                                Case "PRICEEXCHANGE" : z7262.PriceExchange = Children(i).Data
                                Case "QUALITYREQUEST" : z7262.QualityRequest = Children(i).Data
                                Case "CONTRACTNO" : z7262.ContractNo = Children(i).Data
                                Case "TOLERANCE" : z7262.Tolerance = Children(i).Data
                                Case "DESTINATION" : z7262.Destination = Children(i).Data
                                Case "DATEINSERT" : z7262.DateInsert = Children(i).Data
                                Case "DATEUPDATE" : z7262.DateUpdate = Children(i).Data
                                Case "INCHARGEINSERT" : z7262.InchargeInsert = Children(i).Data
                                Case "INCHARGEUPDATE" : z7262.InchargeUpdate = Children(i).Data
                                Case "INCHARGEPURCHASING" : z7262.InchargePurchasing = Children(i).Data
                                Case "CHECKSUPPLIERPRICE" : z7262.CheckSupplierPrice = Children(i).Data
                                Case "DATECOMPLETE" : z7262.DateComplete = Children(i).Data
                                Case "DATEAPPROVED" : z7262.DateApproved = Children(i).Data
                                Case "DATECANCEL" : z7262.DateCancel = Children(i).Data
                                Case "DATEPENDING1" : z7262.DatePending1 = Children(i).Data
                                Case "DATEPENDING2" : z7262.DatePending2 = Children(i).Data
                                Case "CHECKUSE" : z7262.CheckUse = Children(i).Data
                                Case "REMARK" : z7262.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7262_MOVE", vbCritical)
        End Try
    End Function

End Module
