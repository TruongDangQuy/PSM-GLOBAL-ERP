'=========================================================================================================================================================
'   TABLE : (PFK3141)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K3141

    Structure T3141_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public RequestPurchasingNo As String  '			char(9)		*
        Public InvoiceNo As String  '			nvarchar(50)
        Public DateAccept As String  '			char(8)
        Public CheckPurchsingType As String  '			char(1)
        Public CheckIOType As String  '			char(1)
        Public CheckInbound As String  '			char(1)
        Public CheckOutbound As String  '			char(1)
        Public CheckMaterialType As String  '			char(1)
        Public CheckMarketType As String  '			char(1)
        Public CustomerPurchasing As String  '			char(6)
        Public selPaymentCondition As String  '			char(3)
        Public cdPaymentCondition As String  '			char(3)
        Public selImPortCondition As String  '			char(3)
        Public cdImPortCondition As String  '			char(3)
        Public EstimatedTimePayment As String  '			char(8)
        Public EstimatedTimeShipping As String  '			char(8)
        Public EstimatedTimeArrival As String  '			char(8)
        Public EstimatedTimeInBound As String  '			char(8)
        Public DateExchange As String  '			char(8)
        Public PriceExchange As Double  '			decimal
        Public AmtPurchasing_USD As Double  '			decimal
        Public AmtPurchasing_VND As Double  '			decimal
        Public InchargePurcharsing As String  '			char(8)
        Public DateExchangeGM As String  '			char(8)
        Public PriceExchangeGM As Double  '			decimal
        Public AmtTaxImport As Double  '			decimal
        Public AmtTaxVat As Double  '			decimal
        Public AmtPurchasingLC_USD As Double  '			decimal
        Public AmtPurchasingLC_VND As Double  '			decimal
        Public AmtPurcharsingAP_USD As Double  '			decimal
        Public AmtPurcharsingAP_VND As Double  '			decimal
        Public AmtTaxImportAP As Double  '			decimal
        Public AmtTaxVatAP As Double  '			decimal
        Public AmtInBoundMaterial_USD As Double  '			decimal
        Public AmtInBoundMaterial_VND As Double  '			decimal
        Public CheckComplete As String  '			char(1)
        Public DateComplete As String  '			char(8)
        Public Remark As String  '			nvarchar(200)
        '=========================================================================================================================================================
    End Structure

    Public D3141 As T3141_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK3141(REQUESTPURCHASINGNO As String) As Boolean
        READ_PFK3141 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK3141 "
            SQL = SQL & " WHERE K3141_RequestPurchasingNo		 = '" & RequestPurchasingNo & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D3141_CLEAR() : GoTo SKIP_READ_PFK3141

            Call K3141_MOVE(rd)
            READ_PFK3141 = True

SKIP_READ_PFK3141:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK3141", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK3141(REQUESTPURCHASINGNO As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK3141 "
            SQL = SQL & " WHERE K3141_RequestPurchasingNo		 = '" & RequestPurchasingNo & "' "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK3141", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK3141(z3141 As T3141_AREA) As Boolean
        WRITE_PFK3141 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z3141)

            SQL = " INSERT INTO PFK3141 "
            SQL = SQL & " ( "
            SQL = SQL & " K3141_RequestPurchasingNo,"
            SQL = SQL & " K3141_InvoiceNo,"
            SQL = SQL & " K3141_DateAccept,"
            SQL = SQL & " K3141_CheckPurchsingType,"
            SQL = SQL & " K3141_CheckIOType,"
            SQL = SQL & " K3141_CheckInbound,"
            SQL = SQL & " K3141_CheckOutbound,"
            SQL = SQL & " K3141_CheckMaterialType,"
            SQL = SQL & " K3141_CheckMarketType,"
            SQL = SQL & " K3141_CustomerPurchasing,"
            SQL = SQL & " K3141_selPaymentCondition,"
            SQL = SQL & " K3141_cdPaymentCondition,"
            SQL = SQL & " K3141_selImPortCondition,"
            SQL = SQL & " K3141_cdImPortCondition,"
            SQL = SQL & " K3141_EstimatedTimePayment,"
            SQL = SQL & " K3141_EstimatedTimeShipping,"
            SQL = SQL & " K3141_EstimatedTimeArrival,"
            SQL = SQL & " K3141_EstimatedTimeInBound,"
            SQL = SQL & " K3141_DateExchange,"
            SQL = SQL & " K3141_PriceExchange,"
            SQL = SQL & " K3141_AmtPurchasing_USD,"
            SQL = SQL & " K3141_AmtPurchasing_VND,"
            SQL = SQL & " K3141_InchargePurcharsing,"
            SQL = SQL & " K3141_DateExchangeGM,"
            SQL = SQL & " K3141_PriceExchangeGM,"
            SQL = SQL & " K3141_AmtTaxImport,"
            SQL = SQL & " K3141_AmtTaxVat,"
            SQL = SQL & " K3141_AmtPurchasingLC_USD,"
            SQL = SQL & " K3141_AmtPurchasingLC_VND,"
            SQL = SQL & " K3141_AmtPurcharsingAP_USD,"
            SQL = SQL & " K3141_AmtPurcharsingAP_VND,"
            SQL = SQL & " K3141_AmtTaxImportAP,"
            SQL = SQL & " K3141_AmtTaxVatAP,"
            SQL = SQL & " K3141_AmtInBoundMaterial_USD,"
            SQL = SQL & " K3141_AmtInBoundMaterial_VND,"
            SQL = SQL & " K3141_CheckComplete,"
            SQL = SQL & " K3141_DateComplete,"
            SQL = SQL & " K3141_Remark "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  '" & z3141.RequestPurchasingNo & "', "
            SQL = SQL & "  '" & z3141.InvoiceNo & "', "
            SQL = SQL & "  '" & z3141.DateAccept & "', "
            SQL = SQL & "  '" & z3141.CheckPurchsingType & "', "
            SQL = SQL & "  '" & z3141.CheckIOType & "', "
            SQL = SQL & "  '" & z3141.CheckInbound & "', "
            SQL = SQL & "  '" & z3141.CheckOutbound & "', "
            SQL = SQL & "  '" & z3141.CheckMaterialType & "', "
            SQL = SQL & "  '" & z3141.CheckMarketType & "', "
            SQL = SQL & "  '" & z3141.CustomerPurchasing & "', "
            SQL = SQL & "  '" & z3141.selPaymentCondition & "', "
            SQL = SQL & "  '" & z3141.cdPaymentCondition & "', "
            SQL = SQL & "  '" & z3141.selImPortCondition & "', "
            SQL = SQL & "  '" & z3141.cdImPortCondition & "', "
            SQL = SQL & "  '" & z3141.EstimatedTimePayment & "', "
            SQL = SQL & "  '" & z3141.EstimatedTimeShipping & "', "
            SQL = SQL & "  '" & z3141.EstimatedTimeArrival & "', "
            SQL = SQL & "  '" & z3141.EstimatedTimeInBound & "', "
            SQL = SQL & "  '" & z3141.DateExchange & "', "
            SQL = SQL & "   " & z3141.PriceExchange & " , "
            SQL = SQL & "   " & z3141.AmtPurchasing_USD & " , "
            SQL = SQL & "   " & z3141.AmtPurchasing_VND & " , "
            SQL = SQL & "  '" & z3141.InchargePurcharsing & "', "
            SQL = SQL & "  '" & z3141.DateExchangeGM & "', "
            SQL = SQL & "   " & z3141.PriceExchangeGM & " , "
            SQL = SQL & "   " & z3141.AmtTaxImport & " , "
            SQL = SQL & "   " & z3141.AmtTaxVat & " , "
            SQL = SQL & "   " & z3141.AmtPurchasingLC_USD & " , "
            SQL = SQL & "   " & z3141.AmtPurchasingLC_VND & " , "
            SQL = SQL & "   " & z3141.AmtPurcharsingAP_USD & " , "
            SQL = SQL & "   " & z3141.AmtPurcharsingAP_VND & " , "
            SQL = SQL & "   " & z3141.AmtTaxImportAP & " , "
            SQL = SQL & "   " & z3141.AmtTaxVatAP & " , "
            SQL = SQL & "   " & z3141.AmtInBoundMaterial_USD & " , "
            SQL = SQL & "   " & z3141.AmtInBoundMaterial_VND & " , "
            SQL = SQL & "  '" & z3141.CheckComplete & "', "
            SQL = SQL & "  '" & z3141.DateComplete & "', "
            SQL = SQL & "  '" & z3141.Remark & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK3141 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK3141", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK3141(z3141 As T3141_AREA) As Boolean
        REWRITE_PFK3141 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z3141)

            SQL = " UPDATE PFK3141 SET "
            SQL = SQL & "    K3141_InvoiceNo      = '" & z3141.InvoiceNo & "', "
            SQL = SQL & "    K3141_DateAccept      = '" & z3141.DateAccept & "', "
            SQL = SQL & "    K3141_CheckPurchsingType      = '" & z3141.CheckPurchsingType & "', "
            SQL = SQL & "    K3141_CheckIOType      = '" & z3141.CheckIOType & "', "
            SQL = SQL & "    K3141_CheckInbound      = '" & z3141.CheckInbound & "', "
            SQL = SQL & "    K3141_CheckOutbound      = '" & z3141.CheckOutbound & "', "
            SQL = SQL & "    K3141_CheckMaterialType      = '" & z3141.CheckMaterialType & "', "
            SQL = SQL & "    K3141_CheckMarketType      = '" & z3141.CheckMarketType & "', "
            SQL = SQL & "    K3141_CustomerPurchasing      = '" & z3141.CustomerPurchasing & "', "
            SQL = SQL & "    K3141_selPaymentCondition      = '" & z3141.selPaymentCondition & "', "
            SQL = SQL & "    K3141_cdPaymentCondition      = '" & z3141.cdPaymentCondition & "', "
            SQL = SQL & "    K3141_selImPortCondition      = '" & z3141.selImPortCondition & "', "
            SQL = SQL & "    K3141_cdImPortCondition      = '" & z3141.cdImPortCondition & "', "
            SQL = SQL & "    K3141_EstimatedTimePayment      = '" & z3141.EstimatedTimePayment & "', "
            SQL = SQL & "    K3141_EstimatedTimeShipping      = '" & z3141.EstimatedTimeShipping & "', "
            SQL = SQL & "    K3141_EstimatedTimeArrival      = '" & z3141.EstimatedTimeArrival & "', "
            SQL = SQL & "    K3141_EstimatedTimeInBound      = '" & z3141.EstimatedTimeInBound & "', "
            SQL = SQL & "    K3141_DateExchange      = '" & z3141.DateExchange & "', "
            SQL = SQL & "    K3141_PriceExchange      =  " & z3141.PriceExchange & " , "
            SQL = SQL & "    K3141_AmtPurchasing_USD      =  " & z3141.AmtPurchasing_USD & " , "
            SQL = SQL & "    K3141_AmtPurchasing_VND      =  " & z3141.AmtPurchasing_VND & " , "
            SQL = SQL & "    K3141_InchargePurcharsing      = '" & z3141.InchargePurcharsing & "', "
            SQL = SQL & "    K3141_DateExchangeGM      = '" & z3141.DateExchangeGM & "', "
            SQL = SQL & "    K3141_PriceExchangeGM      =  " & z3141.PriceExchangeGM & " , "
            SQL = SQL & "    K3141_AmtTaxImport      =  " & z3141.AmtTaxImport & " , "
            SQL = SQL & "    K3141_AmtTaxVat      =  " & z3141.AmtTaxVat & " , "
            SQL = SQL & "    K3141_AmtPurchasingLC_USD      =  " & z3141.AmtPurchasingLC_USD & " , "
            SQL = SQL & "    K3141_AmtPurchasingLC_VND      =  " & z3141.AmtPurchasingLC_VND & " , "
            SQL = SQL & "    K3141_AmtPurcharsingAP_USD      =  " & z3141.AmtPurcharsingAP_USD & " , "
            SQL = SQL & "    K3141_AmtPurcharsingAP_VND      =  " & z3141.AmtPurcharsingAP_VND & " , "
            SQL = SQL & "    K3141_AmtTaxImportAP      =  " & z3141.AmtTaxImportAP & " , "
            SQL = SQL & "    K3141_AmtTaxVatAP      =  " & z3141.AmtTaxVatAP & " , "
            SQL = SQL & "    K3141_AmtInBoundMaterial_USD      =  " & z3141.AmtInBoundMaterial_USD & " , "
            SQL = SQL & "    K3141_AmtInBoundMaterial_VND      =  " & z3141.AmtInBoundMaterial_VND & " , "
            SQL = SQL & "    K3141_CheckComplete      = '" & z3141.CheckComplete & "', "
            SQL = SQL & "    K3141_DateComplete      = '" & z3141.DateComplete & "', "
            SQL = SQL & "    K3141_Remark      = '" & z3141.Remark & "'  "
            SQL = SQL & " WHERE K3141_RequestPurchasingNo		 = '" & z3141.RequestPurchasingNo & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK3141 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK3141", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK3141(z3141 As T3141_AREA) As Boolean
        DELETE_PFK3141 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK3141 "
            SQL = SQL & " WHERE K3141_RequestPurchasingNo		 = '" & z3141.RequestPurchasingNo & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK3141 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK3141", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D3141_CLEAR()
        Try

            D3141.RequestPurchasingNo = ""
            D3141.InvoiceNo = ""
            D3141.DateAccept = ""
            D3141.CheckPurchsingType = ""
            D3141.CheckIOType = ""
            D3141.CheckInbound = ""
            D3141.CheckOutbound = ""
            D3141.CheckMaterialType = ""
            D3141.CheckMarketType = ""
            D3141.CustomerPurchasing = ""
            D3141.selPaymentCondition = ""
            D3141.cdPaymentCondition = ""
            D3141.selImPortCondition = ""
            D3141.cdImPortCondition = ""
            D3141.EstimatedTimePayment = ""
            D3141.EstimatedTimeShipping = ""
            D3141.EstimatedTimeArrival = ""
            D3141.EstimatedTimeInBound = ""
            D3141.DateExchange = ""
            D3141.PriceExchange = 0
            D3141.AmtPurchasing_USD = 0
            D3141.AmtPurchasing_VND = 0
            D3141.InchargePurcharsing = ""
            D3141.DateExchangeGM = ""
            D3141.PriceExchangeGM = 0
            D3141.AmtTaxImport = 0
            D3141.AmtTaxVat = 0
            D3141.AmtPurchasingLC_USD = 0
            D3141.AmtPurchasingLC_VND = 0
            D3141.AmtPurcharsingAP_USD = 0
            D3141.AmtPurcharsingAP_VND = 0
            D3141.AmtTaxImportAP = 0
            D3141.AmtTaxVatAP = 0
            D3141.AmtInBoundMaterial_USD = 0
            D3141.AmtInBoundMaterial_VND = 0
            D3141.CheckComplete = ""
            D3141.DateComplete = ""
            D3141.Remark = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D3141_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x3141 As T3141_AREA)
        Try

            x3141.RequestPurchasingNo = trim$(x3141.RequestPurchasingNo)
            x3141.InvoiceNo = trim$(x3141.InvoiceNo)
            x3141.DateAccept = trim$(x3141.DateAccept)
            x3141.CheckPurchsingType = trim$(x3141.CheckPurchsingType)
            x3141.CheckIOType = trim$(x3141.CheckIOType)
            x3141.CheckInbound = trim$(x3141.CheckInbound)
            x3141.CheckOutbound = trim$(x3141.CheckOutbound)
            x3141.CheckMaterialType = trim$(x3141.CheckMaterialType)
            x3141.CheckMarketType = trim$(x3141.CheckMarketType)
            x3141.CustomerPurchasing = trim$(x3141.CustomerPurchasing)
            x3141.selPaymentCondition = trim$(x3141.selPaymentCondition)
            x3141.cdPaymentCondition = trim$(x3141.cdPaymentCondition)
            x3141.selImPortCondition = trim$(x3141.selImPortCondition)
            x3141.cdImPortCondition = trim$(x3141.cdImPortCondition)
            x3141.EstimatedTimePayment = trim$(x3141.EstimatedTimePayment)
            x3141.EstimatedTimeShipping = trim$(x3141.EstimatedTimeShipping)
            x3141.EstimatedTimeArrival = trim$(x3141.EstimatedTimeArrival)
            x3141.EstimatedTimeInBound = trim$(x3141.EstimatedTimeInBound)
            x3141.DateExchange = trim$(x3141.DateExchange)
            x3141.PriceExchange = trim$(x3141.PriceExchange)
            x3141.AmtPurchasing_USD = trim$(x3141.AmtPurchasing_USD)
            x3141.AmtPurchasing_VND = trim$(x3141.AmtPurchasing_VND)
            x3141.InchargePurcharsing = trim$(x3141.InchargePurcharsing)
            x3141.DateExchangeGM = trim$(x3141.DateExchangeGM)
            x3141.PriceExchangeGM = trim$(x3141.PriceExchangeGM)
            x3141.AmtTaxImport = trim$(x3141.AmtTaxImport)
            x3141.AmtTaxVat = trim$(x3141.AmtTaxVat)
            x3141.AmtPurchasingLC_USD = trim$(x3141.AmtPurchasingLC_USD)
            x3141.AmtPurchasingLC_VND = trim$(x3141.AmtPurchasingLC_VND)
            x3141.AmtPurcharsingAP_USD = trim$(x3141.AmtPurcharsingAP_USD)
            x3141.AmtPurcharsingAP_VND = trim$(x3141.AmtPurcharsingAP_VND)
            x3141.AmtTaxImportAP = trim$(x3141.AmtTaxImportAP)
            x3141.AmtTaxVatAP = trim$(x3141.AmtTaxVatAP)
            x3141.AmtInBoundMaterial_USD = trim$(x3141.AmtInBoundMaterial_USD)
            x3141.AmtInBoundMaterial_VND = trim$(x3141.AmtInBoundMaterial_VND)
            x3141.CheckComplete = trim$(x3141.CheckComplete)
            x3141.DateComplete = trim$(x3141.DateComplete)
            x3141.Remark = trim$(x3141.Remark)

            If trim$(x3141.RequestPurchasingNo) = "" Then x3141.RequestPurchasingNo = Space(1)
            If trim$(x3141.InvoiceNo) = "" Then x3141.InvoiceNo = Space(1)
            If trim$(x3141.DateAccept) = "" Then x3141.DateAccept = Space(1)
            If trim$(x3141.CheckPurchsingType) = "" Then x3141.CheckPurchsingType = Space(1)
            If trim$(x3141.CheckIOType) = "" Then x3141.CheckIOType = Space(1)
            If trim$(x3141.CheckInbound) = "" Then x3141.CheckInbound = Space(1)
            If trim$(x3141.CheckOutbound) = "" Then x3141.CheckOutbound = Space(1)
            If trim$(x3141.CheckMaterialType) = "" Then x3141.CheckMaterialType = Space(1)
            If trim$(x3141.CheckMarketType) = "" Then x3141.CheckMarketType = Space(1)
            If trim$(x3141.CustomerPurchasing) = "" Then x3141.CustomerPurchasing = Space(1)
            If trim$(x3141.selPaymentCondition) = "" Then x3141.selPaymentCondition = Space(1)
            If trim$(x3141.cdPaymentCondition) = "" Then x3141.cdPaymentCondition = Space(1)
            If trim$(x3141.selImPortCondition) = "" Then x3141.selImPortCondition = Space(1)
            If trim$(x3141.cdImPortCondition) = "" Then x3141.cdImPortCondition = Space(1)
            If trim$(x3141.EstimatedTimePayment) = "" Then x3141.EstimatedTimePayment = Space(1)
            If trim$(x3141.EstimatedTimeShipping) = "" Then x3141.EstimatedTimeShipping = Space(1)
            If trim$(x3141.EstimatedTimeArrival) = "" Then x3141.EstimatedTimeArrival = Space(1)
            If trim$(x3141.EstimatedTimeInBound) = "" Then x3141.EstimatedTimeInBound = Space(1)
            If trim$(x3141.DateExchange) = "" Then x3141.DateExchange = Space(1)
            If trim$(x3141.PriceExchange) = "" Then x3141.PriceExchange = 0
            If trim$(x3141.AmtPurchasing_USD) = "" Then x3141.AmtPurchasing_USD = 0
            If trim$(x3141.AmtPurchasing_VND) = "" Then x3141.AmtPurchasing_VND = 0
            If trim$(x3141.InchargePurcharsing) = "" Then x3141.InchargePurcharsing = Space(1)
            If trim$(x3141.DateExchangeGM) = "" Then x3141.DateExchangeGM = Space(1)
            If trim$(x3141.PriceExchangeGM) = "" Then x3141.PriceExchangeGM = 0
            If trim$(x3141.AmtTaxImport) = "" Then x3141.AmtTaxImport = 0
            If trim$(x3141.AmtTaxVat) = "" Then x3141.AmtTaxVat = 0
            If trim$(x3141.AmtPurchasingLC_USD) = "" Then x3141.AmtPurchasingLC_USD = 0
            If trim$(x3141.AmtPurchasingLC_VND) = "" Then x3141.AmtPurchasingLC_VND = 0
            If trim$(x3141.AmtPurcharsingAP_USD) = "" Then x3141.AmtPurcharsingAP_USD = 0
            If trim$(x3141.AmtPurcharsingAP_VND) = "" Then x3141.AmtPurcharsingAP_VND = 0
            If trim$(x3141.AmtTaxImportAP) = "" Then x3141.AmtTaxImportAP = 0
            If trim$(x3141.AmtTaxVatAP) = "" Then x3141.AmtTaxVatAP = 0
            If trim$(x3141.AmtInBoundMaterial_USD) = "" Then x3141.AmtInBoundMaterial_USD = 0
            If trim$(x3141.AmtInBoundMaterial_VND) = "" Then x3141.AmtInBoundMaterial_VND = 0
            If trim$(x3141.CheckComplete) = "" Then x3141.CheckComplete = Space(1)
            If trim$(x3141.DateComplete) = "" Then x3141.DateComplete = Space(1)
            If trim$(x3141.Remark) = "" Then x3141.Remark = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K3141_MOVE(rs3141 As SqlClient.SqlDataReader)
        Try

            Call D3141_CLEAR()

            If IsdbNull(rs3141!K3141_RequestPurchasingNo) = False Then D3141.RequestPurchasingNo = Trim$(rs3141!K3141_RequestPurchasingNo)
            If IsdbNull(rs3141!K3141_InvoiceNo) = False Then D3141.InvoiceNo = Trim$(rs3141!K3141_InvoiceNo)
            If IsdbNull(rs3141!K3141_DateAccept) = False Then D3141.DateAccept = Trim$(rs3141!K3141_DateAccept)
            If IsdbNull(rs3141!K3141_CheckPurchsingType) = False Then D3141.CheckPurchsingType = Trim$(rs3141!K3141_CheckPurchsingType)
            If IsdbNull(rs3141!K3141_CheckIOType) = False Then D3141.CheckIOType = Trim$(rs3141!K3141_CheckIOType)
            If IsdbNull(rs3141!K3141_CheckInbound) = False Then D3141.CheckInbound = Trim$(rs3141!K3141_CheckInbound)
            If IsdbNull(rs3141!K3141_CheckOutbound) = False Then D3141.CheckOutbound = Trim$(rs3141!K3141_CheckOutbound)
            If IsdbNull(rs3141!K3141_CheckMaterialType) = False Then D3141.CheckMaterialType = Trim$(rs3141!K3141_CheckMaterialType)
            If IsdbNull(rs3141!K3141_CheckMarketType) = False Then D3141.CheckMarketType = Trim$(rs3141!K3141_CheckMarketType)
            If IsdbNull(rs3141!K3141_CustomerPurchasing) = False Then D3141.CustomerPurchasing = Trim$(rs3141!K3141_CustomerPurchasing)
            If IsdbNull(rs3141!K3141_selPaymentCondition) = False Then D3141.selPaymentCondition = Trim$(rs3141!K3141_selPaymentCondition)
            If IsdbNull(rs3141!K3141_cdPaymentCondition) = False Then D3141.cdPaymentCondition = Trim$(rs3141!K3141_cdPaymentCondition)
            If IsdbNull(rs3141!K3141_selImPortCondition) = False Then D3141.selImPortCondition = Trim$(rs3141!K3141_selImPortCondition)
            If IsdbNull(rs3141!K3141_cdImPortCondition) = False Then D3141.cdImPortCondition = Trim$(rs3141!K3141_cdImPortCondition)
            If IsdbNull(rs3141!K3141_EstimatedTimePayment) = False Then D3141.EstimatedTimePayment = Trim$(rs3141!K3141_EstimatedTimePayment)
            If IsdbNull(rs3141!K3141_EstimatedTimeShipping) = False Then D3141.EstimatedTimeShipping = Trim$(rs3141!K3141_EstimatedTimeShipping)
            If IsdbNull(rs3141!K3141_EstimatedTimeArrival) = False Then D3141.EstimatedTimeArrival = Trim$(rs3141!K3141_EstimatedTimeArrival)
            If IsdbNull(rs3141!K3141_EstimatedTimeInBound) = False Then D3141.EstimatedTimeInBound = Trim$(rs3141!K3141_EstimatedTimeInBound)
            If IsdbNull(rs3141!K3141_DateExchange) = False Then D3141.DateExchange = Trim$(rs3141!K3141_DateExchange)
            If IsdbNull(rs3141!K3141_PriceExchange) = False Then D3141.PriceExchange = Trim$(rs3141!K3141_PriceExchange)
            If IsdbNull(rs3141!K3141_AmtPurchasing_USD) = False Then D3141.AmtPurchasing_USD = Trim$(rs3141!K3141_AmtPurchasing_USD)
            If IsdbNull(rs3141!K3141_AmtPurchasing_VND) = False Then D3141.AmtPurchasing_VND = Trim$(rs3141!K3141_AmtPurchasing_VND)
            If IsdbNull(rs3141!K3141_InchargePurcharsing) = False Then D3141.InchargePurcharsing = Trim$(rs3141!K3141_InchargePurcharsing)
            If IsdbNull(rs3141!K3141_DateExchangeGM) = False Then D3141.DateExchangeGM = Trim$(rs3141!K3141_DateExchangeGM)
            If IsdbNull(rs3141!K3141_PriceExchangeGM) = False Then D3141.PriceExchangeGM = Trim$(rs3141!K3141_PriceExchangeGM)
            If IsdbNull(rs3141!K3141_AmtTaxImport) = False Then D3141.AmtTaxImport = Trim$(rs3141!K3141_AmtTaxImport)
            If IsdbNull(rs3141!K3141_AmtTaxVat) = False Then D3141.AmtTaxVat = Trim$(rs3141!K3141_AmtTaxVat)
            If IsdbNull(rs3141!K3141_AmtPurchasingLC_USD) = False Then D3141.AmtPurchasingLC_USD = Trim$(rs3141!K3141_AmtPurchasingLC_USD)
            If IsdbNull(rs3141!K3141_AmtPurchasingLC_VND) = False Then D3141.AmtPurchasingLC_VND = Trim$(rs3141!K3141_AmtPurchasingLC_VND)
            If IsdbNull(rs3141!K3141_AmtPurcharsingAP_USD) = False Then D3141.AmtPurcharsingAP_USD = Trim$(rs3141!K3141_AmtPurcharsingAP_USD)
            If IsdbNull(rs3141!K3141_AmtPurcharsingAP_VND) = False Then D3141.AmtPurcharsingAP_VND = Trim$(rs3141!K3141_AmtPurcharsingAP_VND)
            If IsdbNull(rs3141!K3141_AmtTaxImportAP) = False Then D3141.AmtTaxImportAP = Trim$(rs3141!K3141_AmtTaxImportAP)
            If IsdbNull(rs3141!K3141_AmtTaxVatAP) = False Then D3141.AmtTaxVatAP = Trim$(rs3141!K3141_AmtTaxVatAP)
            If IsdbNull(rs3141!K3141_AmtInBoundMaterial_USD) = False Then D3141.AmtInBoundMaterial_USD = Trim$(rs3141!K3141_AmtInBoundMaterial_USD)
            If IsdbNull(rs3141!K3141_AmtInBoundMaterial_VND) = False Then D3141.AmtInBoundMaterial_VND = Trim$(rs3141!K3141_AmtInBoundMaterial_VND)
            If IsdbNull(rs3141!K3141_CheckComplete) = False Then D3141.CheckComplete = Trim$(rs3141!K3141_CheckComplete)
            If IsdbNull(rs3141!K3141_DateComplete) = False Then D3141.DateComplete = Trim$(rs3141!K3141_DateComplete)
            If IsdbNull(rs3141!K3141_Remark) = False Then D3141.Remark = Trim$(rs3141!K3141_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K3141_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K3141_MOVE(rs3141 As DataRow)
        Try

            Call D3141_CLEAR()

            If IsdbNull(rs3141!K3141_RequestPurchasingNo) = False Then D3141.RequestPurchasingNo = Trim$(rs3141!K3141_RequestPurchasingNo)
            If IsdbNull(rs3141!K3141_InvoiceNo) = False Then D3141.InvoiceNo = Trim$(rs3141!K3141_InvoiceNo)
            If IsdbNull(rs3141!K3141_DateAccept) = False Then D3141.DateAccept = Trim$(rs3141!K3141_DateAccept)
            If IsdbNull(rs3141!K3141_CheckPurchsingType) = False Then D3141.CheckPurchsingType = Trim$(rs3141!K3141_CheckPurchsingType)
            If IsdbNull(rs3141!K3141_CheckIOType) = False Then D3141.CheckIOType = Trim$(rs3141!K3141_CheckIOType)
            If IsdbNull(rs3141!K3141_CheckInbound) = False Then D3141.CheckInbound = Trim$(rs3141!K3141_CheckInbound)
            If IsdbNull(rs3141!K3141_CheckOutbound) = False Then D3141.CheckOutbound = Trim$(rs3141!K3141_CheckOutbound)
            If IsdbNull(rs3141!K3141_CheckMaterialType) = False Then D3141.CheckMaterialType = Trim$(rs3141!K3141_CheckMaterialType)
            If IsdbNull(rs3141!K3141_CheckMarketType) = False Then D3141.CheckMarketType = Trim$(rs3141!K3141_CheckMarketType)
            If IsdbNull(rs3141!K3141_CustomerPurchasing) = False Then D3141.CustomerPurchasing = Trim$(rs3141!K3141_CustomerPurchasing)
            If IsdbNull(rs3141!K3141_selPaymentCondition) = False Then D3141.selPaymentCondition = Trim$(rs3141!K3141_selPaymentCondition)
            If IsdbNull(rs3141!K3141_cdPaymentCondition) = False Then D3141.cdPaymentCondition = Trim$(rs3141!K3141_cdPaymentCondition)
            If IsdbNull(rs3141!K3141_selImPortCondition) = False Then D3141.selImPortCondition = Trim$(rs3141!K3141_selImPortCondition)
            If IsdbNull(rs3141!K3141_cdImPortCondition) = False Then D3141.cdImPortCondition = Trim$(rs3141!K3141_cdImPortCondition)
            If IsdbNull(rs3141!K3141_EstimatedTimePayment) = False Then D3141.EstimatedTimePayment = Trim$(rs3141!K3141_EstimatedTimePayment)
            If IsdbNull(rs3141!K3141_EstimatedTimeShipping) = False Then D3141.EstimatedTimeShipping = Trim$(rs3141!K3141_EstimatedTimeShipping)
            If IsdbNull(rs3141!K3141_EstimatedTimeArrival) = False Then D3141.EstimatedTimeArrival = Trim$(rs3141!K3141_EstimatedTimeArrival)
            If IsdbNull(rs3141!K3141_EstimatedTimeInBound) = False Then D3141.EstimatedTimeInBound = Trim$(rs3141!K3141_EstimatedTimeInBound)
            If IsdbNull(rs3141!K3141_DateExchange) = False Then D3141.DateExchange = Trim$(rs3141!K3141_DateExchange)
            If IsdbNull(rs3141!K3141_PriceExchange) = False Then D3141.PriceExchange = Trim$(rs3141!K3141_PriceExchange)
            If IsdbNull(rs3141!K3141_AmtPurchasing_USD) = False Then D3141.AmtPurchasing_USD = Trim$(rs3141!K3141_AmtPurchasing_USD)
            If IsdbNull(rs3141!K3141_AmtPurchasing_VND) = False Then D3141.AmtPurchasing_VND = Trim$(rs3141!K3141_AmtPurchasing_VND)
            If IsdbNull(rs3141!K3141_InchargePurcharsing) = False Then D3141.InchargePurcharsing = Trim$(rs3141!K3141_InchargePurcharsing)
            If IsdbNull(rs3141!K3141_DateExchangeGM) = False Then D3141.DateExchangeGM = Trim$(rs3141!K3141_DateExchangeGM)
            If IsdbNull(rs3141!K3141_PriceExchangeGM) = False Then D3141.PriceExchangeGM = Trim$(rs3141!K3141_PriceExchangeGM)
            If IsdbNull(rs3141!K3141_AmtTaxImport) = False Then D3141.AmtTaxImport = Trim$(rs3141!K3141_AmtTaxImport)
            If IsdbNull(rs3141!K3141_AmtTaxVat) = False Then D3141.AmtTaxVat = Trim$(rs3141!K3141_AmtTaxVat)
            If IsdbNull(rs3141!K3141_AmtPurchasingLC_USD) = False Then D3141.AmtPurchasingLC_USD = Trim$(rs3141!K3141_AmtPurchasingLC_USD)
            If IsdbNull(rs3141!K3141_AmtPurchasingLC_VND) = False Then D3141.AmtPurchasingLC_VND = Trim$(rs3141!K3141_AmtPurchasingLC_VND)
            If IsdbNull(rs3141!K3141_AmtPurcharsingAP_USD) = False Then D3141.AmtPurcharsingAP_USD = Trim$(rs3141!K3141_AmtPurcharsingAP_USD)
            If IsdbNull(rs3141!K3141_AmtPurcharsingAP_VND) = False Then D3141.AmtPurcharsingAP_VND = Trim$(rs3141!K3141_AmtPurcharsingAP_VND)
            If IsdbNull(rs3141!K3141_AmtTaxImportAP) = False Then D3141.AmtTaxImportAP = Trim$(rs3141!K3141_AmtTaxImportAP)
            If IsdbNull(rs3141!K3141_AmtTaxVatAP) = False Then D3141.AmtTaxVatAP = Trim$(rs3141!K3141_AmtTaxVatAP)
            If IsdbNull(rs3141!K3141_AmtInBoundMaterial_USD) = False Then D3141.AmtInBoundMaterial_USD = Trim$(rs3141!K3141_AmtInBoundMaterial_USD)
            If IsdbNull(rs3141!K3141_AmtInBoundMaterial_VND) = False Then D3141.AmtInBoundMaterial_VND = Trim$(rs3141!K3141_AmtInBoundMaterial_VND)
            If IsdbNull(rs3141!K3141_CheckComplete) = False Then D3141.CheckComplete = Trim$(rs3141!K3141_CheckComplete)
            If IsdbNull(rs3141!K3141_DateComplete) = False Then D3141.DateComplete = Trim$(rs3141!K3141_DateComplete)
            If IsdbNull(rs3141!K3141_Remark) = False Then D3141.Remark = Trim$(rs3141!K3141_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K3141_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K3141_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z3141 As T3141_AREA, REQUESTPURCHASINGNO As String) As Boolean

        K3141_MOVE = False

        Try
            If READ_PFK3141(REQUESTPURCHASINGNO) = True Then
                z3141 = D3141
                K3141_MOVE = True
            Else
                z3141 = Nothing
            End If

            If getColumIndex(spr, "RequestPurchasingNo") > -1 Then z3141.RequestPurchasingNo = getDataM(spr, getColumIndex(spr, "RequestPurchasingNo"), xRow)
            If getColumIndex(spr, "InvoiceNo") > -1 Then z3141.InvoiceNo = getDataM(spr, getColumIndex(spr, "InvoiceNo"), xRow)
            If getColumIndex(spr, "DateAccept") > -1 Then z3141.DateAccept = getDataM(spr, getColumIndex(spr, "DateAccept"), xRow)
            If getColumIndex(spr, "CheckPurchsingType") > -1 Then z3141.CheckPurchsingType = getDataM(spr, getColumIndex(spr, "CheckPurchsingType"), xRow)
            If getColumIndex(spr, "CheckIOType") > -1 Then z3141.CheckIOType = getDataM(spr, getColumIndex(spr, "CheckIOType"), xRow)
            If getColumIndex(spr, "CheckInbound") > -1 Then z3141.CheckInbound = getDataM(spr, getColumIndex(spr, "CheckInbound"), xRow)
            If getColumIndex(spr, "CheckOutbound") > -1 Then z3141.CheckOutbound = getDataM(spr, getColumIndex(spr, "CheckOutbound"), xRow)
            If getColumIndex(spr, "CheckMaterialType") > -1 Then z3141.CheckMaterialType = getDataM(spr, getColumIndex(spr, "CheckMaterialType"), xRow)
            If getColumIndex(spr, "CheckMarketType") > -1 Then z3141.CheckMarketType = getDataM(spr, getColumIndex(spr, "CheckMarketType"), xRow)
            If getColumIndex(spr, "CustomerPurchasing") > -1 Then z3141.CustomerPurchasing = getDataM(spr, getColumIndex(spr, "CustomerPurchasing"), xRow)
            If getColumIndex(spr, "selPaymentCondition") > -1 Then z3141.selPaymentCondition = getDataM(spr, getColumIndex(spr, "selPaymentCondition"), xRow)
            If getColumIndex(spr, "cdPaymentCondition") > -1 Then z3141.cdPaymentCondition = getDataM(spr, getColumIndex(spr, "cdPaymentCondition"), xRow)
            If getColumIndex(spr, "selImPortCondition") > -1 Then z3141.selImPortCondition = getDataM(spr, getColumIndex(spr, "selImPortCondition"), xRow)
            If getColumIndex(spr, "cdImPortCondition") > -1 Then z3141.cdImPortCondition = getDataM(spr, getColumIndex(spr, "cdImPortCondition"), xRow)
            If getColumIndex(spr, "EstimatedTimePayment") > -1 Then z3141.EstimatedTimePayment = getDataM(spr, getColumIndex(spr, "EstimatedTimePayment"), xRow)
            If getColumIndex(spr, "EstimatedTimeShipping") > -1 Then z3141.EstimatedTimeShipping = getDataM(spr, getColumIndex(spr, "EstimatedTimeShipping"), xRow)
            If getColumIndex(spr, "EstimatedTimeArrival") > -1 Then z3141.EstimatedTimeArrival = getDataM(spr, getColumIndex(spr, "EstimatedTimeArrival"), xRow)
            If getColumIndex(spr, "EstimatedTimeInBound") > -1 Then z3141.EstimatedTimeInBound = getDataM(spr, getColumIndex(spr, "EstimatedTimeInBound"), xRow)
            If getColumIndex(spr, "DateExchange") > -1 Then z3141.DateExchange = getDataM(spr, getColumIndex(spr, "DateExchange"), xRow)
            If getColumIndex(spr, "PriceExchange") > -1 Then z3141.PriceExchange = getDataM(spr, getColumIndex(spr, "PriceExchange"), xRow)
            If getColumIndex(spr, "AmtPurchasing_USD") > -1 Then z3141.AmtPurchasing_USD = getDataM(spr, getColumIndex(spr, "AmtPurchasing_USD"), xRow)
            If getColumIndex(spr, "AmtPurchasing_VND") > -1 Then z3141.AmtPurchasing_VND = getDataM(spr, getColumIndex(spr, "AmtPurchasing_VND"), xRow)
            If getColumIndex(spr, "InchargePurcharsing") > -1 Then z3141.InchargePurcharsing = getDataM(spr, getColumIndex(spr, "InchargePurcharsing"), xRow)
            If getColumIndex(spr, "DateExchangeGM") > -1 Then z3141.DateExchangeGM = getDataM(spr, getColumIndex(spr, "DateExchangeGM"), xRow)
            If getColumIndex(spr, "PriceExchangeGM") > -1 Then z3141.PriceExchangeGM = getDataM(spr, getColumIndex(spr, "PriceExchangeGM"), xRow)
            If getColumIndex(spr, "AmtTaxImport") > -1 Then z3141.AmtTaxImport = getDataM(spr, getColumIndex(spr, "AmtTaxImport"), xRow)
            If getColumIndex(spr, "AmtTaxVat") > -1 Then z3141.AmtTaxVat = getDataM(spr, getColumIndex(spr, "AmtTaxVat"), xRow)
            If getColumIndex(spr, "AmtPurchasingLC_USD") > -1 Then z3141.AmtPurchasingLC_USD = getDataM(spr, getColumIndex(spr, "AmtPurchasingLC_USD"), xRow)
            If getColumIndex(spr, "AmtPurchasingLC_VND") > -1 Then z3141.AmtPurchasingLC_VND = getDataM(spr, getColumIndex(spr, "AmtPurchasingLC_VND"), xRow)
            If getColumIndex(spr, "AmtPurcharsingAP_USD") > -1 Then z3141.AmtPurcharsingAP_USD = getDataM(spr, getColumIndex(spr, "AmtPurcharsingAP_USD"), xRow)
            If getColumIndex(spr, "AmtPurcharsingAP_VND") > -1 Then z3141.AmtPurcharsingAP_VND = getDataM(spr, getColumIndex(spr, "AmtPurcharsingAP_VND"), xRow)
            If getColumIndex(spr, "AmtTaxImportAP") > -1 Then z3141.AmtTaxImportAP = getDataM(spr, getColumIndex(spr, "AmtTaxImportAP"), xRow)
            If getColumIndex(spr, "AmtTaxVatAP") > -1 Then z3141.AmtTaxVatAP = getDataM(spr, getColumIndex(spr, "AmtTaxVatAP"), xRow)
            If getColumIndex(spr, "AmtInBoundMaterial_USD") > -1 Then z3141.AmtInBoundMaterial_USD = getDataM(spr, getColumIndex(spr, "AmtInBoundMaterial_USD"), xRow)
            If getColumIndex(spr, "AmtInBoundMaterial_VND") > -1 Then z3141.AmtInBoundMaterial_VND = getDataM(spr, getColumIndex(spr, "AmtInBoundMaterial_VND"), xRow)
            If getColumIndex(spr, "CheckComplete") > -1 Then z3141.CheckComplete = getDataM(spr, getColumIndex(spr, "CheckComplete"), xRow)
            If getColumIndex(spr, "DateComplete") > -1 Then z3141.DateComplete = getDataM(spr, getColumIndex(spr, "DateComplete"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z3141.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K3141_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K3141_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z3141 As T3141_AREA, CheckClear As Boolean, REQUESTPURCHASINGNO As String) As Boolean

        K3141_MOVE = False

        Try
            If READ_PFK3141(REQUESTPURCHASINGNO) = True Then
                z3141 = D3141
                K3141_MOVE = True
            Else
                If CheckClear = True Then z3141 = Nothing
            End If

            If getColumIndex(spr, "RequestPurchasingNo") > -1 Then z3141.RequestPurchasingNo = getDataM(spr, getColumIndex(spr, "RequestPurchasingNo"), xRow)
            If getColumIndex(spr, "InvoiceNo") > -1 Then z3141.InvoiceNo = getDataM(spr, getColumIndex(spr, "InvoiceNo"), xRow)
            If getColumIndex(spr, "DateAccept") > -1 Then z3141.DateAccept = getDataM(spr, getColumIndex(spr, "DateAccept"), xRow)
            If getColumIndex(spr, "CheckPurchsingType") > -1 Then z3141.CheckPurchsingType = getDataM(spr, getColumIndex(spr, "CheckPurchsingType"), xRow)
            If getColumIndex(spr, "CheckIOType") > -1 Then z3141.CheckIOType = getDataM(spr, getColumIndex(spr, "CheckIOType"), xRow)
            If getColumIndex(spr, "CheckInbound") > -1 Then z3141.CheckInbound = getDataM(spr, getColumIndex(spr, "CheckInbound"), xRow)
            If getColumIndex(spr, "CheckOutbound") > -1 Then z3141.CheckOutbound = getDataM(spr, getColumIndex(spr, "CheckOutbound"), xRow)
            If getColumIndex(spr, "CheckMaterialType") > -1 Then z3141.CheckMaterialType = getDataM(spr, getColumIndex(spr, "CheckMaterialType"), xRow)
            If getColumIndex(spr, "CheckMarketType") > -1 Then z3141.CheckMarketType = getDataM(spr, getColumIndex(spr, "CheckMarketType"), xRow)
            If getColumIndex(spr, "CustomerPurchasing") > -1 Then z3141.CustomerPurchasing = getDataM(spr, getColumIndex(spr, "CustomerPurchasing"), xRow)
            If getColumIndex(spr, "selPaymentCondition") > -1 Then z3141.selPaymentCondition = getDataM(spr, getColumIndex(spr, "selPaymentCondition"), xRow)
            If getColumIndex(spr, "cdPaymentCondition") > -1 Then z3141.cdPaymentCondition = getDataM(spr, getColumIndex(spr, "cdPaymentCondition"), xRow)
            If getColumIndex(spr, "selImPortCondition") > -1 Then z3141.selImPortCondition = getDataM(spr, getColumIndex(spr, "selImPortCondition"), xRow)
            If getColumIndex(spr, "cdImPortCondition") > -1 Then z3141.cdImPortCondition = getDataM(spr, getColumIndex(spr, "cdImPortCondition"), xRow)
            If getColumIndex(spr, "EstimatedTimePayment") > -1 Then z3141.EstimatedTimePayment = getDataM(spr, getColumIndex(spr, "EstimatedTimePayment"), xRow)
            If getColumIndex(spr, "EstimatedTimeShipping") > -1 Then z3141.EstimatedTimeShipping = getDataM(spr, getColumIndex(spr, "EstimatedTimeShipping"), xRow)
            If getColumIndex(spr, "EstimatedTimeArrival") > -1 Then z3141.EstimatedTimeArrival = getDataM(spr, getColumIndex(spr, "EstimatedTimeArrival"), xRow)
            If getColumIndex(spr, "EstimatedTimeInBound") > -1 Then z3141.EstimatedTimeInBound = getDataM(spr, getColumIndex(spr, "EstimatedTimeInBound"), xRow)
            If getColumIndex(spr, "DateExchange") > -1 Then z3141.DateExchange = getDataM(spr, getColumIndex(spr, "DateExchange"), xRow)
            If getColumIndex(spr, "PriceExchange") > -1 Then z3141.PriceExchange = getDataM(spr, getColumIndex(spr, "PriceExchange"), xRow)
            If getColumIndex(spr, "AmtPurchasing_USD") > -1 Then z3141.AmtPurchasing_USD = getDataM(spr, getColumIndex(spr, "AmtPurchasing_USD"), xRow)
            If getColumIndex(spr, "AmtPurchasing_VND") > -1 Then z3141.AmtPurchasing_VND = getDataM(spr, getColumIndex(spr, "AmtPurchasing_VND"), xRow)
            If getColumIndex(spr, "InchargePurcharsing") > -1 Then z3141.InchargePurcharsing = getDataM(spr, getColumIndex(spr, "InchargePurcharsing"), xRow)
            If getColumIndex(spr, "DateExchangeGM") > -1 Then z3141.DateExchangeGM = getDataM(spr, getColumIndex(spr, "DateExchangeGM"), xRow)
            If getColumIndex(spr, "PriceExchangeGM") > -1 Then z3141.PriceExchangeGM = getDataM(spr, getColumIndex(spr, "PriceExchangeGM"), xRow)
            If getColumIndex(spr, "AmtTaxImport") > -1 Then z3141.AmtTaxImport = getDataM(spr, getColumIndex(spr, "AmtTaxImport"), xRow)
            If getColumIndex(spr, "AmtTaxVat") > -1 Then z3141.AmtTaxVat = getDataM(spr, getColumIndex(spr, "AmtTaxVat"), xRow)
            If getColumIndex(spr, "AmtPurchasingLC_USD") > -1 Then z3141.AmtPurchasingLC_USD = getDataM(spr, getColumIndex(spr, "AmtPurchasingLC_USD"), xRow)
            If getColumIndex(spr, "AmtPurchasingLC_VND") > -1 Then z3141.AmtPurchasingLC_VND = getDataM(spr, getColumIndex(spr, "AmtPurchasingLC_VND"), xRow)
            If getColumIndex(spr, "AmtPurcharsingAP_USD") > -1 Then z3141.AmtPurcharsingAP_USD = getDataM(spr, getColumIndex(spr, "AmtPurcharsingAP_USD"), xRow)
            If getColumIndex(spr, "AmtPurcharsingAP_VND") > -1 Then z3141.AmtPurcharsingAP_VND = getDataM(spr, getColumIndex(spr, "AmtPurcharsingAP_VND"), xRow)
            If getColumIndex(spr, "AmtTaxImportAP") > -1 Then z3141.AmtTaxImportAP = getDataM(spr, getColumIndex(spr, "AmtTaxImportAP"), xRow)
            If getColumIndex(spr, "AmtTaxVatAP") > -1 Then z3141.AmtTaxVatAP = getDataM(spr, getColumIndex(spr, "AmtTaxVatAP"), xRow)
            If getColumIndex(spr, "AmtInBoundMaterial_USD") > -1 Then z3141.AmtInBoundMaterial_USD = getDataM(spr, getColumIndex(spr, "AmtInBoundMaterial_USD"), xRow)
            If getColumIndex(spr, "AmtInBoundMaterial_VND") > -1 Then z3141.AmtInBoundMaterial_VND = getDataM(spr, getColumIndex(spr, "AmtInBoundMaterial_VND"), xRow)
            If getColumIndex(spr, "CheckComplete") > -1 Then z3141.CheckComplete = getDataM(spr, getColumIndex(spr, "CheckComplete"), xRow)
            If getColumIndex(spr, "DateComplete") > -1 Then z3141.DateComplete = getDataM(spr, getColumIndex(spr, "DateComplete"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z3141.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K3141_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K3141_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z3141 As T3141_AREA, Job As String, REQUESTPURCHASINGNO As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K3141_MOVE = False

        Try
            If READ_PFK3141(REQUESTPURCHASINGNO) = True Then
                z3141 = D3141
                K3141_MOVE = True
            Else
                z3141 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3141")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "RequestPurchasingNo" : z3141.RequestPurchasingNo = Children(i).Code
                                Case "InvoiceNo" : z3141.InvoiceNo = Children(i).Code
                                Case "DateAccept" : z3141.DateAccept = Children(i).Code
                                Case "CheckPurchsingType" : z3141.CheckPurchsingType = Children(i).Code
                                Case "CheckIOType" : z3141.CheckIOType = Children(i).Code
                                Case "CheckInbound" : z3141.CheckInbound = Children(i).Code
                                Case "CheckOutbound" : z3141.CheckOutbound = Children(i).Code
                                Case "CheckMaterialType" : z3141.CheckMaterialType = Children(i).Code
                                Case "CheckMarketType" : z3141.CheckMarketType = Children(i).Code
                                Case "CustomerPurchasing" : z3141.CustomerPurchasing = Children(i).Code
                                Case "selPaymentCondition" : z3141.selPaymentCondition = Children(i).Code
                                Case "cdPaymentCondition" : z3141.cdPaymentCondition = Children(i).Code
                                Case "selImPortCondition" : z3141.selImPortCondition = Children(i).Code
                                Case "cdImPortCondition" : z3141.cdImPortCondition = Children(i).Code
                                Case "EstimatedTimePayment" : z3141.EstimatedTimePayment = Children(i).Code
                                Case "EstimatedTimeShipping" : z3141.EstimatedTimeShipping = Children(i).Code
                                Case "EstimatedTimeArrival" : z3141.EstimatedTimeArrival = Children(i).Code
                                Case "EstimatedTimeInBound" : z3141.EstimatedTimeInBound = Children(i).Code
                                Case "DateExchange" : z3141.DateExchange = Children(i).Code
                                Case "PriceExchange" : z3141.PriceExchange = Children(i).Code
                                Case "AmtPurchasing_USD" : z3141.AmtPurchasing_USD = Children(i).Code
                                Case "AmtPurchasing_VND" : z3141.AmtPurchasing_VND = Children(i).Code
                                Case "InchargePurcharsing" : z3141.InchargePurcharsing = Children(i).Code
                                Case "DateExchangeGM" : z3141.DateExchangeGM = Children(i).Code
                                Case "PriceExchangeGM" : z3141.PriceExchangeGM = Children(i).Code
                                Case "AmtTaxImport" : z3141.AmtTaxImport = Children(i).Code
                                Case "AmtTaxVat" : z3141.AmtTaxVat = Children(i).Code
                                Case "AmtPurchasingLC_USD" : z3141.AmtPurchasingLC_USD = Children(i).Code
                                Case "AmtPurchasingLC_VND" : z3141.AmtPurchasingLC_VND = Children(i).Code
                                Case "AmtPurcharsingAP_USD" : z3141.AmtPurcharsingAP_USD = Children(i).Code
                                Case "AmtPurcharsingAP_VND" : z3141.AmtPurcharsingAP_VND = Children(i).Code
                                Case "AmtTaxImportAP" : z3141.AmtTaxImportAP = Children(i).Code
                                Case "AmtTaxVatAP" : z3141.AmtTaxVatAP = Children(i).Code
                                Case "AmtInBoundMaterial_USD" : z3141.AmtInBoundMaterial_USD = Children(i).Code
                                Case "AmtInBoundMaterial_VND" : z3141.AmtInBoundMaterial_VND = Children(i).Code
                                Case "CheckComplete" : z3141.CheckComplete = Children(i).Code
                                Case "DateComplete" : z3141.DateComplete = Children(i).Code
                                Case "Remark" : z3141.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "RequestPurchasingNo" : z3141.RequestPurchasingNo = Children(i).Data
                                Case "InvoiceNo" : z3141.InvoiceNo = Children(i).Data
                                Case "DateAccept" : z3141.DateAccept = Children(i).Data
                                Case "CheckPurchsingType" : z3141.CheckPurchsingType = Children(i).Data
                                Case "CheckIOType" : z3141.CheckIOType = Children(i).Data
                                Case "CheckInbound" : z3141.CheckInbound = Children(i).Data
                                Case "CheckOutbound" : z3141.CheckOutbound = Children(i).Data
                                Case "CheckMaterialType" : z3141.CheckMaterialType = Children(i).Data
                                Case "CheckMarketType" : z3141.CheckMarketType = Children(i).Data
                                Case "CustomerPurchasing" : z3141.CustomerPurchasing = Children(i).Data
                                Case "selPaymentCondition" : z3141.selPaymentCondition = Children(i).Data
                                Case "cdPaymentCondition" : z3141.cdPaymentCondition = Children(i).Data
                                Case "selImPortCondition" : z3141.selImPortCondition = Children(i).Data
                                Case "cdImPortCondition" : z3141.cdImPortCondition = Children(i).Data
                                Case "EstimatedTimePayment" : z3141.EstimatedTimePayment = Children(i).Data
                                Case "EstimatedTimeShipping" : z3141.EstimatedTimeShipping = Children(i).Data
                                Case "EstimatedTimeArrival" : z3141.EstimatedTimeArrival = Children(i).Data
                                Case "EstimatedTimeInBound" : z3141.EstimatedTimeInBound = Children(i).Data
                                Case "DateExchange" : z3141.DateExchange = Children(i).Data
                                Case "PriceExchange" : z3141.PriceExchange = Children(i).Data
                                Case "AmtPurchasing_USD" : z3141.AmtPurchasing_USD = Children(i).Data
                                Case "AmtPurchasing_VND" : z3141.AmtPurchasing_VND = Children(i).Data
                                Case "InchargePurcharsing" : z3141.InchargePurcharsing = Children(i).Data
                                Case "DateExchangeGM" : z3141.DateExchangeGM = Children(i).Data
                                Case "PriceExchangeGM" : z3141.PriceExchangeGM = Children(i).Data
                                Case "AmtTaxImport" : z3141.AmtTaxImport = Children(i).Data
                                Case "AmtTaxVat" : z3141.AmtTaxVat = Children(i).Data
                                Case "AmtPurchasingLC_USD" : z3141.AmtPurchasingLC_USD = Children(i).Data
                                Case "AmtPurchasingLC_VND" : z3141.AmtPurchasingLC_VND = Children(i).Data
                                Case "AmtPurcharsingAP_USD" : z3141.AmtPurcharsingAP_USD = Children(i).Data
                                Case "AmtPurcharsingAP_VND" : z3141.AmtPurcharsingAP_VND = Children(i).Data
                                Case "AmtTaxImportAP" : z3141.AmtTaxImportAP = Children(i).Data
                                Case "AmtTaxVatAP" : z3141.AmtTaxVatAP = Children(i).Data
                                Case "AmtInBoundMaterial_USD" : z3141.AmtInBoundMaterial_USD = Children(i).Data
                                Case "AmtInBoundMaterial_VND" : z3141.AmtInBoundMaterial_VND = Children(i).Data
                                Case "CheckComplete" : z3141.CheckComplete = Children(i).Data
                                Case "DateComplete" : z3141.DateComplete = Children(i).Data
                                Case "Remark" : z3141.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K3141_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K3141_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z3141 As T3141_AREA, Job As String, CheckClear As Boolean, REQUESTPURCHASINGNO As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K3141_MOVE = False

        Try
            If READ_PFK3141(REQUESTPURCHASINGNO) = True Then
                z3141 = D3141
                K3141_MOVE = True
            Else
                If CheckClear = True Then z3141 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3141")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "RequestPurchasingNo" : z3141.RequestPurchasingNo = Children(i).Code
                                Case "InvoiceNo" : z3141.InvoiceNo = Children(i).Code
                                Case "DateAccept" : z3141.DateAccept = Children(i).Code
                                Case "CheckPurchsingType" : z3141.CheckPurchsingType = Children(i).Code
                                Case "CheckIOType" : z3141.CheckIOType = Children(i).Code
                                Case "CheckInbound" : z3141.CheckInbound = Children(i).Code
                                Case "CheckOutbound" : z3141.CheckOutbound = Children(i).Code
                                Case "CheckMaterialType" : z3141.CheckMaterialType = Children(i).Code
                                Case "CheckMarketType" : z3141.CheckMarketType = Children(i).Code
                                Case "CustomerPurchasing" : z3141.CustomerPurchasing = Children(i).Code
                                Case "selPaymentCondition" : z3141.selPaymentCondition = Children(i).Code
                                Case "cdPaymentCondition" : z3141.cdPaymentCondition = Children(i).Code
                                Case "selImPortCondition" : z3141.selImPortCondition = Children(i).Code
                                Case "cdImPortCondition" : z3141.cdImPortCondition = Children(i).Code
                                Case "EstimatedTimePayment" : z3141.EstimatedTimePayment = Children(i).Code
                                Case "EstimatedTimeShipping" : z3141.EstimatedTimeShipping = Children(i).Code
                                Case "EstimatedTimeArrival" : z3141.EstimatedTimeArrival = Children(i).Code
                                Case "EstimatedTimeInBound" : z3141.EstimatedTimeInBound = Children(i).Code
                                Case "DateExchange" : z3141.DateExchange = Children(i).Code
                                Case "PriceExchange" : z3141.PriceExchange = Children(i).Code
                                Case "AmtPurchasing_USD" : z3141.AmtPurchasing_USD = Children(i).Code
                                Case "AmtPurchasing_VND" : z3141.AmtPurchasing_VND = Children(i).Code
                                Case "InchargePurcharsing" : z3141.InchargePurcharsing = Children(i).Code
                                Case "DateExchangeGM" : z3141.DateExchangeGM = Children(i).Code
                                Case "PriceExchangeGM" : z3141.PriceExchangeGM = Children(i).Code
                                Case "AmtTaxImport" : z3141.AmtTaxImport = Children(i).Code
                                Case "AmtTaxVat" : z3141.AmtTaxVat = Children(i).Code
                                Case "AmtPurchasingLC_USD" : z3141.AmtPurchasingLC_USD = Children(i).Code
                                Case "AmtPurchasingLC_VND" : z3141.AmtPurchasingLC_VND = Children(i).Code
                                Case "AmtPurcharsingAP_USD" : z3141.AmtPurcharsingAP_USD = Children(i).Code
                                Case "AmtPurcharsingAP_VND" : z3141.AmtPurcharsingAP_VND = Children(i).Code
                                Case "AmtTaxImportAP" : z3141.AmtTaxImportAP = Children(i).Code
                                Case "AmtTaxVatAP" : z3141.AmtTaxVatAP = Children(i).Code
                                Case "AmtInBoundMaterial_USD" : z3141.AmtInBoundMaterial_USD = Children(i).Code
                                Case "AmtInBoundMaterial_VND" : z3141.AmtInBoundMaterial_VND = Children(i).Code
                                Case "CheckComplete" : z3141.CheckComplete = Children(i).Code
                                Case "DateComplete" : z3141.DateComplete = Children(i).Code
                                Case "Remark" : z3141.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "RequestPurchasingNo" : z3141.RequestPurchasingNo = Children(i).Data
                                Case "InvoiceNo" : z3141.InvoiceNo = Children(i).Data
                                Case "DateAccept" : z3141.DateAccept = Children(i).Data
                                Case "CheckPurchsingType" : z3141.CheckPurchsingType = Children(i).Data
                                Case "CheckIOType" : z3141.CheckIOType = Children(i).Data
                                Case "CheckInbound" : z3141.CheckInbound = Children(i).Data
                                Case "CheckOutbound" : z3141.CheckOutbound = Children(i).Data
                                Case "CheckMaterialType" : z3141.CheckMaterialType = Children(i).Data
                                Case "CheckMarketType" : z3141.CheckMarketType = Children(i).Data
                                Case "CustomerPurchasing" : z3141.CustomerPurchasing = Children(i).Data
                                Case "selPaymentCondition" : z3141.selPaymentCondition = Children(i).Data
                                Case "cdPaymentCondition" : z3141.cdPaymentCondition = Children(i).Data
                                Case "selImPortCondition" : z3141.selImPortCondition = Children(i).Data
                                Case "cdImPortCondition" : z3141.cdImPortCondition = Children(i).Data
                                Case "EstimatedTimePayment" : z3141.EstimatedTimePayment = Children(i).Data
                                Case "EstimatedTimeShipping" : z3141.EstimatedTimeShipping = Children(i).Data
                                Case "EstimatedTimeArrival" : z3141.EstimatedTimeArrival = Children(i).Data
                                Case "EstimatedTimeInBound" : z3141.EstimatedTimeInBound = Children(i).Data
                                Case "DateExchange" : z3141.DateExchange = Children(i).Data
                                Case "PriceExchange" : z3141.PriceExchange = Children(i).Data
                                Case "AmtPurchasing_USD" : z3141.AmtPurchasing_USD = Children(i).Data
                                Case "AmtPurchasing_VND" : z3141.AmtPurchasing_VND = Children(i).Data
                                Case "InchargePurcharsing" : z3141.InchargePurcharsing = Children(i).Data
                                Case "DateExchangeGM" : z3141.DateExchangeGM = Children(i).Data
                                Case "PriceExchangeGM" : z3141.PriceExchangeGM = Children(i).Data
                                Case "AmtTaxImport" : z3141.AmtTaxImport = Children(i).Data
                                Case "AmtTaxVat" : z3141.AmtTaxVat = Children(i).Data
                                Case "AmtPurchasingLC_USD" : z3141.AmtPurchasingLC_USD = Children(i).Data
                                Case "AmtPurchasingLC_VND" : z3141.AmtPurchasingLC_VND = Children(i).Data
                                Case "AmtPurcharsingAP_USD" : z3141.AmtPurcharsingAP_USD = Children(i).Data
                                Case "AmtPurcharsingAP_VND" : z3141.AmtPurcharsingAP_VND = Children(i).Data
                                Case "AmtTaxImportAP" : z3141.AmtTaxImportAP = Children(i).Data
                                Case "AmtTaxVatAP" : z3141.AmtTaxVatAP = Children(i).Data
                                Case "AmtInBoundMaterial_USD" : z3141.AmtInBoundMaterial_USD = Children(i).Data
                                Case "AmtInBoundMaterial_VND" : z3141.AmtInBoundMaterial_VND = Children(i).Data
                                Case "CheckComplete" : z3141.CheckComplete = Children(i).Data
                                Case "DateComplete" : z3141.DateComplete = Children(i).Data
                                Case "Remark" : z3141.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K3141_MOVE", vbCritical)
        End Try
    End Function

End Module
