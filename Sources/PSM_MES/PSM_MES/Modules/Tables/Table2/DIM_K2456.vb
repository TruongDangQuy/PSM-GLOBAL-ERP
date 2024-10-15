'=========================================================================================================================================================
'   TABLE : (PFK2456)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K2456

Structure T2456_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	ProductOutboundNo	 AS String	'			char(9)		*
Public 	ProductOutboundSeq	 AS String	'			char(3)		*
Public 	CustomerCode	 AS String	'			char(6)
Public 	SupplierCode	 AS String	'			char(6)
Public 	seFactory	 AS String	'			char(3)
Public 	cdFactory	 AS String	'			char(3)
        Public ShoesCode As String  '			char(6)
        Public SizeRange As String  '			char(6)
        Public CheckOutBoundMaterial As String  '			char(1)
        Public CheckMaterialType As String  '			char(1)
        Public CheckMarketType As String  '			char(1)
        Public InvoiceNo As String  '			nvarchar(20)
        Public seUnitPrice As String  '			char(3)
        Public cdUnitPrice As String  '			char(3)
        Public DateExchange As String  '			char(8)
        Public PriceExchange As Double  '			decimal
        Public ProductInboundNo As String  '			char(9)
        Public ProductInboundSeq As String  '			char(3)
        Public DateOutbound As String  '			char(8)
        Public InchargeOutbound As String  '			char(8)
        Public FactOrderNo As String  '			char(9)
        Public FactOrderSeq As Double  '			decimal
        Public PalletNo As String  '			nvarchar(50)
        Public StockNo As String  '			nvarchar(50)
        Public CheckComplete As String  '			char(1)
        Public PriceShipping As Double  '			decimal
        Public PriceShippingVND As Double  '			decimal
        Public AmountShipping As Double  '			decimal
        Public AmountShippingVND As Double  '			decimal
        Public QtyProductOutbound As Double  '			decimal
        Public IsPosted As String  '			char(1)
        Public DatePosted As String  '			char(8)
        Public DateInsert As String  '			char(8)
        Public DateUpdate As String  '			char(8)
        Public InchargeInsert As String  '			char(8)
        Public InchargeUpdate As String  '			char(8)
        Public Remark As String  '			nvarchar(100)
        '=========================================================================================================================================================
    End Structure

    Public D2456 As T2456_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK2456(PRODUCTOUTBOUNDNO As String, PRODUCTOUTBOUNDSEQ As String) As Boolean
        READ_PFK2456 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK2456 "
            SQL = SQL & " WHERE K2456_ProductOutboundNo		 = '" & ProductOutboundNo & "' "
            SQL = SQL & "   AND K2456_ProductOutboundSeq		 = '" & ProductOutboundSeq & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D2456_CLEAR() : GoTo SKIP_READ_PFK2456

            Call K2456_MOVE(rd)
            READ_PFK2456 = True

SKIP_READ_PFK2456:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK2456", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK2456(PRODUCTOUTBOUNDNO As String, PRODUCTOUTBOUNDSEQ As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK2456 "
            SQL = SQL & " WHERE K2456_ProductOutboundNo		 = '" & ProductOutboundNo & "' "
            SQL = SQL & "   AND K2456_ProductOutboundSeq		 = '" & ProductOutboundSeq & "' "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK2456", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK2456(z2456 As T2456_AREA) As Boolean
        WRITE_PFK2456 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z2456)

            SQL = " INSERT INTO PFK2456 "
            SQL = SQL & " ( "
            SQL = SQL & " K2456_ProductOutboundNo,"
            SQL = SQL & " K2456_ProductOutboundSeq,"
            SQL = SQL & " K2456_CustomerCode,"
            SQL = SQL & " K2456_SupplierCode,"
            SQL = SQL & " K2456_seFactory,"
            SQL = SQL & " K2456_cdFactory,"
            SQL = SQL & " K2456_ShoesCode,"
            SQL = SQL & " K2456_SizeRange,"
            SQL = SQL & " K2456_CheckOutBoundMaterial,"
            SQL = SQL & " K2456_CheckMaterialType,"
            SQL = SQL & " K2456_CheckMarketType,"
            SQL = SQL & " K2456_InvoiceNo,"
            SQL = SQL & " K2456_seUnitPrice,"
            SQL = SQL & " K2456_cdUnitPrice,"
            SQL = SQL & " K2456_DateExchange,"
            SQL = SQL & " K2456_PriceExchange,"
            SQL = SQL & " K2456_ProductInboundNo,"
            SQL = SQL & " K2456_ProductInboundSeq,"
            SQL = SQL & " K2456_DateOutbound,"
            SQL = SQL & " K2456_InchargeOutbound,"
            SQL = SQL & " K2456_FactOrderNo,"
            SQL = SQL & " K2456_FactOrderSeq,"
            SQL = SQL & " K2456_PalletNo,"
            SQL = SQL & " K2456_StockNo,"
            SQL = SQL & " K2456_CheckComplete,"
            SQL = SQL & " K2456_PriceShipping,"
            SQL = SQL & " K2456_PriceShippingVND,"
            SQL = SQL & " K2456_AmountShipping,"
            SQL = SQL & " K2456_AmountShippingVND,"
            SQL = SQL & " K2456_QtyProductOutbound,"
            SQL = SQL & " K2456_IsPosted,"
            SQL = SQL & " K2456_DatePosted,"
            SQL = SQL & " K2456_DateInsert,"
            SQL = SQL & " K2456_DateUpdate,"
            SQL = SQL & " K2456_InchargeInsert,"
            SQL = SQL & " K2456_InchargeUpdate,"
            SQL = SQL & " K2456_Remark "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z2456.ProductOutboundNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2456.ProductOutboundSeq) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2456.CustomerCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2456.SupplierCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2456.seFactory) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2456.cdFactory) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2456.ShoesCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2456.SizeRange) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2456.CheckOutBoundMaterial) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2456.CheckMaterialType) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2456.CheckMarketType) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2456.InvoiceNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2456.seUnitPrice) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2456.cdUnitPrice) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2456.DateExchange) & "', "
            SQL = SQL & "   " & FormatSQL(z2456.PriceExchange) & ", "
            SQL = SQL & "  N'" & FormatSQL(z2456.ProductInboundNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2456.ProductInboundSeq) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2456.DateOutbound) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2456.InchargeOutbound) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2456.FactOrderNo) & "', "
            SQL = SQL & "   " & FormatSQL(z2456.FactOrderSeq) & ", "
            SQL = SQL & "  N'" & FormatSQL(z2456.PalletNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2456.StockNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2456.CheckComplete) & "', "
            SQL = SQL & "   " & FormatSQL(z2456.PriceShipping) & ", "
            SQL = SQL & "   " & FormatSQL(z2456.PriceShippingVND) & ", "
            SQL = SQL & "   " & FormatSQL(z2456.AmountShipping) & ", "
            SQL = SQL & "   " & FormatSQL(z2456.AmountShippingVND) & ", "
            SQL = SQL & "   " & FormatSQL(z2456.QtyProductOutbound) & ", "
            SQL = SQL & "  N'" & FormatSQL(z2456.IsPosted) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2456.DatePosted) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2456.DateInsert) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2456.DateUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2456.InchargeInsert) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2456.InchargeUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2456.Remark) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK2456 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK2456", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK2456(z2456 As T2456_AREA) As Boolean
        REWRITE_PFK2456 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z2456)

            SQL = " UPDATE PFK2456 SET "
            SQL = SQL & "    K2456_CustomerCode      = N'" & FormatSQL(z2456.CustomerCode) & "', "
            SQL = SQL & "    K2456_SupplierCode      = N'" & FormatSQL(z2456.SupplierCode) & "', "
            SQL = SQL & "    K2456_seFactory      = N'" & FormatSQL(z2456.seFactory) & "', "
            SQL = SQL & "    K2456_cdFactory      = N'" & FormatSQL(z2456.cdFactory) & "', "
            SQL = SQL & "    K2456_ShoesCode      = N'" & FormatSQL(z2456.ShoesCode) & "', "
            SQL = SQL & "    K2456_SizeRange      = N'" & FormatSQL(z2456.SizeRange) & "', "
            SQL = SQL & "    K2456_CheckOutBoundMaterial      = N'" & FormatSQL(z2456.CheckOutBoundMaterial) & "', "
            SQL = SQL & "    K2456_CheckMaterialType      = N'" & FormatSQL(z2456.CheckMaterialType) & "', "
            SQL = SQL & "    K2456_CheckMarketType      = N'" & FormatSQL(z2456.CheckMarketType) & "', "
            SQL = SQL & "    K2456_InvoiceNo      = N'" & FormatSQL(z2456.InvoiceNo) & "', "
            SQL = SQL & "    K2456_seUnitPrice      = N'" & FormatSQL(z2456.seUnitPrice) & "', "
            SQL = SQL & "    K2456_cdUnitPrice      = N'" & FormatSQL(z2456.cdUnitPrice) & "', "
            SQL = SQL & "    K2456_DateExchange      = N'" & FormatSQL(z2456.DateExchange) & "', "
            SQL = SQL & "    K2456_PriceExchange      =  " & FormatSQL(z2456.PriceExchange) & ", "
            SQL = SQL & "    K2456_ProductInboundNo      = N'" & FormatSQL(z2456.ProductInboundNo) & "', "
            SQL = SQL & "    K2456_ProductInboundSeq      = N'" & FormatSQL(z2456.ProductInboundSeq) & "', "
            SQL = SQL & "    K2456_DateOutbound      = N'" & FormatSQL(z2456.DateOutbound) & "', "
            SQL = SQL & "    K2456_InchargeOutbound      = N'" & FormatSQL(z2456.InchargeOutbound) & "', "
            SQL = SQL & "    K2456_FactOrderNo      = N'" & FormatSQL(z2456.FactOrderNo) & "', "
            SQL = SQL & "    K2456_FactOrderSeq      =  " & FormatSQL(z2456.FactOrderSeq) & ", "
            SQL = SQL & "    K2456_PalletNo      = N'" & FormatSQL(z2456.PalletNo) & "', "
            SQL = SQL & "    K2456_StockNo      = N'" & FormatSQL(z2456.StockNo) & "', "
            SQL = SQL & "    K2456_CheckComplete      = N'" & FormatSQL(z2456.CheckComplete) & "', "
            SQL = SQL & "    K2456_PriceShipping      =  " & FormatSQL(z2456.PriceShipping) & ", "
            SQL = SQL & "    K2456_PriceShippingVND      =  " & FormatSQL(z2456.PriceShippingVND) & ", "
            SQL = SQL & "    K2456_AmountShipping      =  " & FormatSQL(z2456.AmountShipping) & ", "
            SQL = SQL & "    K2456_AmountShippingVND      =  " & FormatSQL(z2456.AmountShippingVND) & ", "
            SQL = SQL & "    K2456_QtyProductOutbound      =  " & FormatSQL(z2456.QtyProductOutbound) & ", "
            SQL = SQL & "    K2456_IsPosted      = N'" & FormatSQL(z2456.IsPosted) & "', "
            SQL = SQL & "    K2456_DatePosted      = N'" & FormatSQL(z2456.DatePosted) & "', "
            SQL = SQL & "    K2456_DateInsert      = N'" & FormatSQL(z2456.DateInsert) & "', "
            SQL = SQL & "    K2456_DateUpdate      = N'" & FormatSQL(z2456.DateUpdate) & "', "
            SQL = SQL & "    K2456_InchargeInsert      = N'" & FormatSQL(z2456.InchargeInsert) & "', "
            SQL = SQL & "    K2456_InchargeUpdate      = N'" & FormatSQL(z2456.InchargeUpdate) & "', "
            SQL = SQL & "    K2456_Remark      = N'" & FormatSQL(z2456.Remark) & "'  "
            SQL = SQL & " WHERE K2456_ProductOutboundNo		 = '" & z2456.ProductOutboundNo & "' "
            SQL = SQL & "   AND K2456_ProductOutboundSeq		 = '" & z2456.ProductOutboundSeq & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK2456 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK2456", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK2456(z2456 As T2456_AREA) As Boolean
        DELETE_PFK2456 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK2456 "
            SQL = SQL & " WHERE K2456_ProductOutboundNo		 = '" & z2456.ProductOutboundNo & "' "
            SQL = SQL & "   AND K2456_ProductOutboundSeq		 = '" & z2456.ProductOutboundSeq & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK2456 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK2456", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D2456_CLEAR()
        Try

            D2456.ProductOutboundNo = ""
            D2456.ProductOutboundSeq = ""
            D2456.CustomerCode = ""
            D2456.SupplierCode = ""
            D2456.seFactory = ""
            D2456.cdFactory = ""
            D2456.ShoesCode = ""
            D2456.SizeRange = ""
            D2456.CheckOutBoundMaterial = ""
            D2456.CheckMaterialType = ""
            D2456.CheckMarketType = ""
            D2456.InvoiceNo = ""
            D2456.seUnitPrice = ""
            D2456.cdUnitPrice = ""
            D2456.DateExchange = ""
            D2456.PriceExchange = 0
            D2456.ProductInboundNo = ""
            D2456.ProductInboundSeq = ""
            D2456.DateOutbound = ""
            D2456.InchargeOutbound = ""
            D2456.FactOrderNo = ""
            D2456.FactOrderSeq = 0
            D2456.PalletNo = ""
            D2456.StockNo = ""
            D2456.CheckComplete = ""
            D2456.PriceShipping = 0
            D2456.PriceShippingVND = 0
            D2456.AmountShipping = 0
            D2456.AmountShippingVND = 0
            D2456.QtyProductOutbound = 0
            D2456.IsPosted = ""
            D2456.DatePosted = ""
            D2456.DateInsert = ""
            D2456.DateUpdate = ""
            D2456.InchargeInsert = ""
            D2456.InchargeUpdate = ""
            D2456.Remark = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D2456_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x2456 As T2456_AREA)
        Try

            x2456.ProductOutboundNo = trim$(x2456.ProductOutboundNo)
            x2456.ProductOutboundSeq = trim$(x2456.ProductOutboundSeq)
            x2456.CustomerCode = trim$(x2456.CustomerCode)
            x2456.SupplierCode = trim$(x2456.SupplierCode)
            x2456.seFactory = trim$(x2456.seFactory)
            x2456.cdFactory = trim$(x2456.cdFactory)
            x2456.ShoesCode = trim$(x2456.ShoesCode)
            x2456.SizeRange = trim$(x2456.SizeRange)
            x2456.CheckOutBoundMaterial = trim$(x2456.CheckOutBoundMaterial)
            x2456.CheckMaterialType = trim$(x2456.CheckMaterialType)
            x2456.CheckMarketType = trim$(x2456.CheckMarketType)
            x2456.InvoiceNo = trim$(x2456.InvoiceNo)
            x2456.seUnitPrice = trim$(x2456.seUnitPrice)
            x2456.cdUnitPrice = trim$(x2456.cdUnitPrice)
            x2456.DateExchange = trim$(x2456.DateExchange)
            x2456.PriceExchange = trim$(x2456.PriceExchange)
            x2456.ProductInboundNo = trim$(x2456.ProductInboundNo)
            x2456.ProductInboundSeq = trim$(x2456.ProductInboundSeq)
            x2456.DateOutbound = trim$(x2456.DateOutbound)
            x2456.InchargeOutbound = trim$(x2456.InchargeOutbound)
            x2456.FactOrderNo = trim$(x2456.FactOrderNo)
            x2456.FactOrderSeq = trim$(x2456.FactOrderSeq)
            x2456.PalletNo = trim$(x2456.PalletNo)
            x2456.StockNo = trim$(x2456.StockNo)
            x2456.CheckComplete = trim$(x2456.CheckComplete)
            x2456.PriceShipping = trim$(x2456.PriceShipping)
            x2456.PriceShippingVND = trim$(x2456.PriceShippingVND)
            x2456.AmountShipping = trim$(x2456.AmountShipping)
            x2456.AmountShippingVND = trim$(x2456.AmountShippingVND)
            x2456.QtyProductOutbound = trim$(x2456.QtyProductOutbound)
            x2456.IsPosted = trim$(x2456.IsPosted)
            x2456.DatePosted = trim$(x2456.DatePosted)
            x2456.DateInsert = trim$(x2456.DateInsert)
            x2456.DateUpdate = trim$(x2456.DateUpdate)
            x2456.InchargeInsert = trim$(x2456.InchargeInsert)
            x2456.InchargeUpdate = trim$(x2456.InchargeUpdate)
            x2456.Remark = trim$(x2456.Remark)

            If trim$(x2456.ProductOutboundNo) = "" Then x2456.ProductOutboundNo = Space(1)
            If trim$(x2456.ProductOutboundSeq) = "" Then x2456.ProductOutboundSeq = Space(1)
            If trim$(x2456.CustomerCode) = "" Then x2456.CustomerCode = Space(1)
            If trim$(x2456.SupplierCode) = "" Then x2456.SupplierCode = Space(1)
            If trim$(x2456.seFactory) = "" Then x2456.seFactory = Space(1)
            If trim$(x2456.cdFactory) = "" Then x2456.cdFactory = Space(1)
            If trim$(x2456.ShoesCode) = "" Then x2456.ShoesCode = Space(1)
            If trim$(x2456.SizeRange) = "" Then x2456.SizeRange = Space(1)
            If trim$(x2456.CheckOutBoundMaterial) = "" Then x2456.CheckOutBoundMaterial = Space(1)
            If trim$(x2456.CheckMaterialType) = "" Then x2456.CheckMaterialType = Space(1)
            If trim$(x2456.CheckMarketType) = "" Then x2456.CheckMarketType = Space(1)
            If trim$(x2456.InvoiceNo) = "" Then x2456.InvoiceNo = Space(1)
            If trim$(x2456.seUnitPrice) = "" Then x2456.seUnitPrice = Space(1)
            If trim$(x2456.cdUnitPrice) = "" Then x2456.cdUnitPrice = Space(1)
            If trim$(x2456.DateExchange) = "" Then x2456.DateExchange = Space(1)
            If trim$(x2456.PriceExchange) = "" Then x2456.PriceExchange = 0
            If trim$(x2456.ProductInboundNo) = "" Then x2456.ProductInboundNo = Space(1)
            If trim$(x2456.ProductInboundSeq) = "" Then x2456.ProductInboundSeq = Space(1)
            If trim$(x2456.DateOutbound) = "" Then x2456.DateOutbound = Space(1)
            If trim$(x2456.InchargeOutbound) = "" Then x2456.InchargeOutbound = Space(1)
            If trim$(x2456.FactOrderNo) = "" Then x2456.FactOrderNo = Space(1)
            If trim$(x2456.FactOrderSeq) = "" Then x2456.FactOrderSeq = 0
            If trim$(x2456.PalletNo) = "" Then x2456.PalletNo = Space(1)
            If trim$(x2456.StockNo) = "" Then x2456.StockNo = Space(1)
            If trim$(x2456.CheckComplete) = "" Then x2456.CheckComplete = Space(1)
            If trim$(x2456.PriceShipping) = "" Then x2456.PriceShipping = 0
            If trim$(x2456.PriceShippingVND) = "" Then x2456.PriceShippingVND = 0
            If trim$(x2456.AmountShipping) = "" Then x2456.AmountShipping = 0
            If trim$(x2456.AmountShippingVND) = "" Then x2456.AmountShippingVND = 0
            If trim$(x2456.QtyProductOutbound) = "" Then x2456.QtyProductOutbound = 0
            If trim$(x2456.IsPosted) = "" Then x2456.IsPosted = Space(1)
            If trim$(x2456.DatePosted) = "" Then x2456.DatePosted = Space(1)
            If trim$(x2456.DateInsert) = "" Then x2456.DateInsert = Space(1)
            If trim$(x2456.DateUpdate) = "" Then x2456.DateUpdate = Space(1)
            If trim$(x2456.InchargeInsert) = "" Then x2456.InchargeInsert = Space(1)
            If trim$(x2456.InchargeUpdate) = "" Then x2456.InchargeUpdate = Space(1)
            If trim$(x2456.Remark) = "" Then x2456.Remark = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K2456_MOVE(rs2456 As SqlClient.SqlDataReader)
        Try

            Call D2456_CLEAR()

            If IsdbNull(rs2456!K2456_ProductOutboundNo) = False Then D2456.ProductOutboundNo = Trim$(rs2456!K2456_ProductOutboundNo)
            If IsdbNull(rs2456!K2456_ProductOutboundSeq) = False Then D2456.ProductOutboundSeq = Trim$(rs2456!K2456_ProductOutboundSeq)
            If IsdbNull(rs2456!K2456_CustomerCode) = False Then D2456.CustomerCode = Trim$(rs2456!K2456_CustomerCode)
            If IsdbNull(rs2456!K2456_SupplierCode) = False Then D2456.SupplierCode = Trim$(rs2456!K2456_SupplierCode)
            If IsdbNull(rs2456!K2456_seFactory) = False Then D2456.seFactory = Trim$(rs2456!K2456_seFactory)
            If IsdbNull(rs2456!K2456_cdFactory) = False Then D2456.cdFactory = Trim$(rs2456!K2456_cdFactory)
            If IsdbNull(rs2456!K2456_ShoesCode) = False Then D2456.ShoesCode = Trim$(rs2456!K2456_ShoesCode)
            If IsdbNull(rs2456!K2456_SizeRange) = False Then D2456.SizeRange = Trim$(rs2456!K2456_SizeRange)
            If IsdbNull(rs2456!K2456_CheckOutBoundMaterial) = False Then D2456.CheckOutBoundMaterial = Trim$(rs2456!K2456_CheckOutBoundMaterial)
            If IsdbNull(rs2456!K2456_CheckMaterialType) = False Then D2456.CheckMaterialType = Trim$(rs2456!K2456_CheckMaterialType)
            If IsdbNull(rs2456!K2456_CheckMarketType) = False Then D2456.CheckMarketType = Trim$(rs2456!K2456_CheckMarketType)
            If IsdbNull(rs2456!K2456_InvoiceNo) = False Then D2456.InvoiceNo = Trim$(rs2456!K2456_InvoiceNo)
            If IsdbNull(rs2456!K2456_seUnitPrice) = False Then D2456.seUnitPrice = Trim$(rs2456!K2456_seUnitPrice)
            If IsdbNull(rs2456!K2456_cdUnitPrice) = False Then D2456.cdUnitPrice = Trim$(rs2456!K2456_cdUnitPrice)
            If IsdbNull(rs2456!K2456_DateExchange) = False Then D2456.DateExchange = Trim$(rs2456!K2456_DateExchange)
            If IsdbNull(rs2456!K2456_PriceExchange) = False Then D2456.PriceExchange = Trim$(rs2456!K2456_PriceExchange)
            If IsdbNull(rs2456!K2456_ProductInboundNo) = False Then D2456.ProductInboundNo = Trim$(rs2456!K2456_ProductInboundNo)
            If IsdbNull(rs2456!K2456_ProductInboundSeq) = False Then D2456.ProductInboundSeq = Trim$(rs2456!K2456_ProductInboundSeq)
            If IsdbNull(rs2456!K2456_DateOutbound) = False Then D2456.DateOutbound = Trim$(rs2456!K2456_DateOutbound)
            If IsdbNull(rs2456!K2456_InchargeOutbound) = False Then D2456.InchargeOutbound = Trim$(rs2456!K2456_InchargeOutbound)
            If IsdbNull(rs2456!K2456_FactOrderNo) = False Then D2456.FactOrderNo = Trim$(rs2456!K2456_FactOrderNo)
            If IsdbNull(rs2456!K2456_FactOrderSeq) = False Then D2456.FactOrderSeq = Trim$(rs2456!K2456_FactOrderSeq)
            If IsdbNull(rs2456!K2456_PalletNo) = False Then D2456.PalletNo = Trim$(rs2456!K2456_PalletNo)
            If IsdbNull(rs2456!K2456_StockNo) = False Then D2456.StockNo = Trim$(rs2456!K2456_StockNo)
            If IsdbNull(rs2456!K2456_CheckComplete) = False Then D2456.CheckComplete = Trim$(rs2456!K2456_CheckComplete)
            If IsdbNull(rs2456!K2456_PriceShipping) = False Then D2456.PriceShipping = Trim$(rs2456!K2456_PriceShipping)
            If IsdbNull(rs2456!K2456_PriceShippingVND) = False Then D2456.PriceShippingVND = Trim$(rs2456!K2456_PriceShippingVND)
            If IsdbNull(rs2456!K2456_AmountShipping) = False Then D2456.AmountShipping = Trim$(rs2456!K2456_AmountShipping)
            If IsdbNull(rs2456!K2456_AmountShippingVND) = False Then D2456.AmountShippingVND = Trim$(rs2456!K2456_AmountShippingVND)
            If IsdbNull(rs2456!K2456_QtyProductOutbound) = False Then D2456.QtyProductOutbound = Trim$(rs2456!K2456_QtyProductOutbound)
            If IsdbNull(rs2456!K2456_IsPosted) = False Then D2456.IsPosted = Trim$(rs2456!K2456_IsPosted)
            If IsdbNull(rs2456!K2456_DatePosted) = False Then D2456.DatePosted = Trim$(rs2456!K2456_DatePosted)
            If IsdbNull(rs2456!K2456_DateInsert) = False Then D2456.DateInsert = Trim$(rs2456!K2456_DateInsert)
            If IsdbNull(rs2456!K2456_DateUpdate) = False Then D2456.DateUpdate = Trim$(rs2456!K2456_DateUpdate)
            If IsdbNull(rs2456!K2456_InchargeInsert) = False Then D2456.InchargeInsert = Trim$(rs2456!K2456_InchargeInsert)
            If IsdbNull(rs2456!K2456_InchargeUpdate) = False Then D2456.InchargeUpdate = Trim$(rs2456!K2456_InchargeUpdate)
            If IsdbNull(rs2456!K2456_Remark) = False Then D2456.Remark = Trim$(rs2456!K2456_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K2456_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K2456_MOVE(rs2456 As DataRow)
        Try

            Call D2456_CLEAR()

            If IsdbNull(rs2456!K2456_ProductOutboundNo) = False Then D2456.ProductOutboundNo = Trim$(rs2456!K2456_ProductOutboundNo)
            If IsdbNull(rs2456!K2456_ProductOutboundSeq) = False Then D2456.ProductOutboundSeq = Trim$(rs2456!K2456_ProductOutboundSeq)
            If IsdbNull(rs2456!K2456_CustomerCode) = False Then D2456.CustomerCode = Trim$(rs2456!K2456_CustomerCode)
            If IsdbNull(rs2456!K2456_SupplierCode) = False Then D2456.SupplierCode = Trim$(rs2456!K2456_SupplierCode)
            If IsdbNull(rs2456!K2456_seFactory) = False Then D2456.seFactory = Trim$(rs2456!K2456_seFactory)
            If IsdbNull(rs2456!K2456_cdFactory) = False Then D2456.cdFactory = Trim$(rs2456!K2456_cdFactory)
            If IsdbNull(rs2456!K2456_ShoesCode) = False Then D2456.ShoesCode = Trim$(rs2456!K2456_ShoesCode)
            If IsdbNull(rs2456!K2456_SizeRange) = False Then D2456.SizeRange = Trim$(rs2456!K2456_SizeRange)
            If IsdbNull(rs2456!K2456_CheckOutBoundMaterial) = False Then D2456.CheckOutBoundMaterial = Trim$(rs2456!K2456_CheckOutBoundMaterial)
            If IsdbNull(rs2456!K2456_CheckMaterialType) = False Then D2456.CheckMaterialType = Trim$(rs2456!K2456_CheckMaterialType)
            If IsdbNull(rs2456!K2456_CheckMarketType) = False Then D2456.CheckMarketType = Trim$(rs2456!K2456_CheckMarketType)
            If IsdbNull(rs2456!K2456_InvoiceNo) = False Then D2456.InvoiceNo = Trim$(rs2456!K2456_InvoiceNo)
            If IsdbNull(rs2456!K2456_seUnitPrice) = False Then D2456.seUnitPrice = Trim$(rs2456!K2456_seUnitPrice)
            If IsdbNull(rs2456!K2456_cdUnitPrice) = False Then D2456.cdUnitPrice = Trim$(rs2456!K2456_cdUnitPrice)
            If IsdbNull(rs2456!K2456_DateExchange) = False Then D2456.DateExchange = Trim$(rs2456!K2456_DateExchange)
            If IsdbNull(rs2456!K2456_PriceExchange) = False Then D2456.PriceExchange = Trim$(rs2456!K2456_PriceExchange)
            If IsdbNull(rs2456!K2456_ProductInboundNo) = False Then D2456.ProductInboundNo = Trim$(rs2456!K2456_ProductInboundNo)
            If IsdbNull(rs2456!K2456_ProductInboundSeq) = False Then D2456.ProductInboundSeq = Trim$(rs2456!K2456_ProductInboundSeq)
            If IsdbNull(rs2456!K2456_DateOutbound) = False Then D2456.DateOutbound = Trim$(rs2456!K2456_DateOutbound)
            If IsdbNull(rs2456!K2456_InchargeOutbound) = False Then D2456.InchargeOutbound = Trim$(rs2456!K2456_InchargeOutbound)
            If IsdbNull(rs2456!K2456_FactOrderNo) = False Then D2456.FactOrderNo = Trim$(rs2456!K2456_FactOrderNo)
            If IsdbNull(rs2456!K2456_FactOrderSeq) = False Then D2456.FactOrderSeq = Trim$(rs2456!K2456_FactOrderSeq)
            If IsdbNull(rs2456!K2456_PalletNo) = False Then D2456.PalletNo = Trim$(rs2456!K2456_PalletNo)
            If IsdbNull(rs2456!K2456_StockNo) = False Then D2456.StockNo = Trim$(rs2456!K2456_StockNo)
            If IsdbNull(rs2456!K2456_CheckComplete) = False Then D2456.CheckComplete = Trim$(rs2456!K2456_CheckComplete)
            If IsdbNull(rs2456!K2456_PriceShipping) = False Then D2456.PriceShipping = Trim$(rs2456!K2456_PriceShipping)
            If IsdbNull(rs2456!K2456_PriceShippingVND) = False Then D2456.PriceShippingVND = Trim$(rs2456!K2456_PriceShippingVND)
            If IsdbNull(rs2456!K2456_AmountShipping) = False Then D2456.AmountShipping = Trim$(rs2456!K2456_AmountShipping)
            If IsdbNull(rs2456!K2456_AmountShippingVND) = False Then D2456.AmountShippingVND = Trim$(rs2456!K2456_AmountShippingVND)
            If IsdbNull(rs2456!K2456_QtyProductOutbound) = False Then D2456.QtyProductOutbound = Trim$(rs2456!K2456_QtyProductOutbound)
            If IsdbNull(rs2456!K2456_IsPosted) = False Then D2456.IsPosted = Trim$(rs2456!K2456_IsPosted)
            If IsdbNull(rs2456!K2456_DatePosted) = False Then D2456.DatePosted = Trim$(rs2456!K2456_DatePosted)
            If IsdbNull(rs2456!K2456_DateInsert) = False Then D2456.DateInsert = Trim$(rs2456!K2456_DateInsert)
            If IsdbNull(rs2456!K2456_DateUpdate) = False Then D2456.DateUpdate = Trim$(rs2456!K2456_DateUpdate)
            If IsdbNull(rs2456!K2456_InchargeInsert) = False Then D2456.InchargeInsert = Trim$(rs2456!K2456_InchargeInsert)
            If IsdbNull(rs2456!K2456_InchargeUpdate) = False Then D2456.InchargeUpdate = Trim$(rs2456!K2456_InchargeUpdate)
            If IsdbNull(rs2456!K2456_Remark) = False Then D2456.Remark = Trim$(rs2456!K2456_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K2456_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K2456_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z2456 As T2456_AREA, PRODUCTOUTBOUNDNO As String, PRODUCTOUTBOUNDSEQ As String) As Boolean

        K2456_MOVE = False

        Try
            If READ_PFK2456(PRODUCTOUTBOUNDNO, PRODUCTOUTBOUNDSEQ) = True Then
                z2456 = D2456
                K2456_MOVE = True
            Else
                z2456 = Nothing
            End If

            If getColumIndex(spr, "ProductOutboundNo") > -1 Then z2456.ProductOutboundNo = getDataM(spr, getColumIndex(spr, "ProductOutboundNo"), xRow)
            If getColumIndex(spr, "ProductOutboundSeq") > -1 Then z2456.ProductOutboundSeq = getDataM(spr, getColumIndex(spr, "ProductOutboundSeq"), xRow)
            If getColumIndex(spr, "CustomerCode") > -1 Then z2456.CustomerCode = getDataM(spr, getColumIndex(spr, "CustomerCode"), xRow)
            If getColumIndex(spr, "SupplierCode") > -1 Then z2456.SupplierCode = getDataM(spr, getColumIndex(spr, "SupplierCode"), xRow)
            If getColumIndex(spr, "seFactory") > -1 Then z2456.seFactory = getDataM(spr, getColumIndex(spr, "seFactory"), xRow)
            If getColumIndex(spr, "cdFactory") > -1 Then z2456.cdFactory = getDataM(spr, getColumIndex(spr, "cdFactory"), xRow)
            If getColumIndex(spr, "ShoesCode") > -1 Then z2456.ShoesCode = getDataM(spr, getColumIndex(spr, "ShoesCode"), xRow)
            If getColumIndex(spr, "SizeRange") > -1 Then z2456.SizeRange = getDataM(spr, getColumIndex(spr, "SizeRange"), xRow)
            If getColumIndex(spr, "CheckOutBoundMaterial") > -1 Then z2456.CheckOutBoundMaterial = getDataM(spr, getColumIndex(spr, "CheckOutBoundMaterial"), xRow)
            If getColumIndex(spr, "CheckMaterialType") > -1 Then z2456.CheckMaterialType = getDataM(spr, getColumIndex(spr, "CheckMaterialType"), xRow)
            If getColumIndex(spr, "CheckMarketType") > -1 Then z2456.CheckMarketType = getDataM(spr, getColumIndex(spr, "CheckMarketType"), xRow)
            If getColumIndex(spr, "InvoiceNo") > -1 Then z2456.InvoiceNo = getDataM(spr, getColumIndex(spr, "InvoiceNo"), xRow)
            If getColumIndex(spr, "seUnitPrice") > -1 Then z2456.seUnitPrice = getDataM(spr, getColumIndex(spr, "seUnitPrice"), xRow)
            If getColumIndex(spr, "cdUnitPrice") > -1 Then z2456.cdUnitPrice = getDataM(spr, getColumIndex(spr, "cdUnitPrice"), xRow)
            If getColumIndex(spr, "DateExchange") > -1 Then z2456.DateExchange = getDataM(spr, getColumIndex(spr, "DateExchange"), xRow)
            If getColumIndex(spr, "PriceExchange") > -1 Then z2456.PriceExchange = getDataM(spr, getColumIndex(spr, "PriceExchange"), xRow)
            If getColumIndex(spr, "ProductInboundNo") > -1 Then z2456.ProductInboundNo = getDataM(spr, getColumIndex(spr, "ProductInboundNo"), xRow)
            If getColumIndex(spr, "ProductInboundSeq") > -1 Then z2456.ProductInboundSeq = getDataM(spr, getColumIndex(spr, "ProductInboundSeq"), xRow)
            If getColumIndex(spr, "DateOutbound") > -1 Then z2456.DateOutbound = getDataM(spr, getColumIndex(spr, "DateOutbound"), xRow)
            If getColumIndex(spr, "InchargeOutbound") > -1 Then z2456.InchargeOutbound = getDataM(spr, getColumIndex(spr, "InchargeOutbound"), xRow)
            If getColumIndex(spr, "FactOrderNo") > -1 Then z2456.FactOrderNo = getDataM(spr, getColumIndex(spr, "FactOrderNo"), xRow)
            If getColumIndex(spr, "FactOrderSeq") > -1 Then z2456.FactOrderSeq = getDataM(spr, getColumIndex(spr, "FactOrderSeq"), xRow)
            If getColumIndex(spr, "PalletNo") > -1 Then z2456.PalletNo = getDataM(spr, getColumIndex(spr, "PalletNo"), xRow)
            If getColumIndex(spr, "StockNo") > -1 Then z2456.StockNo = getDataM(spr, getColumIndex(spr, "StockNo"), xRow)
            If getColumIndex(spr, "CheckComplete") > -1 Then z2456.CheckComplete = getDataM(spr, getColumIndex(spr, "CheckComplete"), xRow)
            If getColumIndex(spr, "PriceShipping") > -1 Then z2456.PriceShipping = getDataM(spr, getColumIndex(spr, "PriceShipping"), xRow)
            If getColumIndex(spr, "PriceShippingVND") > -1 Then z2456.PriceShippingVND = getDataM(spr, getColumIndex(spr, "PriceShippingVND"), xRow)
            If getColumIndex(spr, "AmountShipping") > -1 Then z2456.AmountShipping = getDataM(spr, getColumIndex(spr, "AmountShipping"), xRow)
            If getColumIndex(spr, "AmountShippingVND") > -1 Then z2456.AmountShippingVND = getDataM(spr, getColumIndex(spr, "AmountShippingVND"), xRow)
            If getColumIndex(spr, "QtyProductOutbound") > -1 Then z2456.QtyProductOutbound = getDataM(spr, getColumIndex(spr, "QtyProductOutbound"), xRow)
            If getColumIndex(spr, "IsPosted") > -1 Then z2456.IsPosted = getDataM(spr, getColumIndex(spr, "IsPosted"), xRow)
            If getColumIndex(spr, "DatePosted") > -1 Then z2456.DatePosted = getDataM(spr, getColumIndex(spr, "DatePosted"), xRow)
            If getColumIndex(spr, "DateInsert") > -1 Then z2456.DateInsert = getDataM(spr, getColumIndex(spr, "DateInsert"), xRow)
            If getColumIndex(spr, "DateUpdate") > -1 Then z2456.DateUpdate = getDataM(spr, getColumIndex(spr, "DateUpdate"), xRow)
            If getColumIndex(spr, "InchargeInsert") > -1 Then z2456.InchargeInsert = getDataM(spr, getColumIndex(spr, "InchargeInsert"), xRow)
            If getColumIndex(spr, "InchargeUpdate") > -1 Then z2456.InchargeUpdate = getDataM(spr, getColumIndex(spr, "InchargeUpdate"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z2456.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K2456_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K2456_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z2456 As T2456_AREA, CheckClear As Boolean, PRODUCTOUTBOUNDNO As String, PRODUCTOUTBOUNDSEQ As String) As Boolean

        K2456_MOVE = False

        Try
            If READ_PFK2456(PRODUCTOUTBOUNDNO, PRODUCTOUTBOUNDSEQ) = True Then
                z2456 = D2456
                K2456_MOVE = True
            Else
                If CheckClear = True Then z2456 = Nothing
            End If

            If getColumIndex(spr, "ProductOutboundNo") > -1 Then z2456.ProductOutboundNo = getDataM(spr, getColumIndex(spr, "ProductOutboundNo"), xRow)
            If getColumIndex(spr, "ProductOutboundSeq") > -1 Then z2456.ProductOutboundSeq = getDataM(spr, getColumIndex(spr, "ProductOutboundSeq"), xRow)
            If getColumIndex(spr, "CustomerCode") > -1 Then z2456.CustomerCode = getDataM(spr, getColumIndex(spr, "CustomerCode"), xRow)
            If getColumIndex(spr, "SupplierCode") > -1 Then z2456.SupplierCode = getDataM(spr, getColumIndex(spr, "SupplierCode"), xRow)
            If getColumIndex(spr, "seFactory") > -1 Then z2456.seFactory = getDataM(spr, getColumIndex(spr, "seFactory"), xRow)
            If getColumIndex(spr, "cdFactory") > -1 Then z2456.cdFactory = getDataM(spr, getColumIndex(spr, "cdFactory"), xRow)
            If getColumIndex(spr, "ShoesCode") > -1 Then z2456.ShoesCode = getDataM(spr, getColumIndex(spr, "ShoesCode"), xRow)
            If getColumIndex(spr, "SizeRange") > -1 Then z2456.SizeRange = getDataM(spr, getColumIndex(spr, "SizeRange"), xRow)
            If getColumIndex(spr, "CheckOutBoundMaterial") > -1 Then z2456.CheckOutBoundMaterial = getDataM(spr, getColumIndex(spr, "CheckOutBoundMaterial"), xRow)
            If getColumIndex(spr, "CheckMaterialType") > -1 Then z2456.CheckMaterialType = getDataM(spr, getColumIndex(spr, "CheckMaterialType"), xRow)
            If getColumIndex(spr, "CheckMarketType") > -1 Then z2456.CheckMarketType = getDataM(spr, getColumIndex(spr, "CheckMarketType"), xRow)
            If getColumIndex(spr, "InvoiceNo") > -1 Then z2456.InvoiceNo = getDataM(spr, getColumIndex(spr, "InvoiceNo"), xRow)
            If getColumIndex(spr, "seUnitPrice") > -1 Then z2456.seUnitPrice = getDataM(spr, getColumIndex(spr, "seUnitPrice"), xRow)
            If getColumIndex(spr, "cdUnitPrice") > -1 Then z2456.cdUnitPrice = getDataM(spr, getColumIndex(spr, "cdUnitPrice"), xRow)
            If getColumIndex(spr, "DateExchange") > -1 Then z2456.DateExchange = getDataM(spr, getColumIndex(spr, "DateExchange"), xRow)
            If getColumIndex(spr, "PriceExchange") > -1 Then z2456.PriceExchange = getDataM(spr, getColumIndex(spr, "PriceExchange"), xRow)
            If getColumIndex(spr, "ProductInboundNo") > -1 Then z2456.ProductInboundNo = getDataM(spr, getColumIndex(spr, "ProductInboundNo"), xRow)
            If getColumIndex(spr, "ProductInboundSeq") > -1 Then z2456.ProductInboundSeq = getDataM(spr, getColumIndex(spr, "ProductInboundSeq"), xRow)
            If getColumIndex(spr, "DateOutbound") > -1 Then z2456.DateOutbound = getDataM(spr, getColumIndex(spr, "DateOutbound"), xRow)
            If getColumIndex(spr, "InchargeOutbound") > -1 Then z2456.InchargeOutbound = getDataM(spr, getColumIndex(spr, "InchargeOutbound"), xRow)
            If getColumIndex(spr, "FactOrderNo") > -1 Then z2456.FactOrderNo = getDataM(spr, getColumIndex(spr, "FactOrderNo"), xRow)
            If getColumIndex(spr, "FactOrderSeq") > -1 Then z2456.FactOrderSeq = getDataM(spr, getColumIndex(spr, "FactOrderSeq"), xRow)
            If getColumIndex(spr, "PalletNo") > -1 Then z2456.PalletNo = getDataM(spr, getColumIndex(spr, "PalletNo"), xRow)
            If getColumIndex(spr, "StockNo") > -1 Then z2456.StockNo = getDataM(spr, getColumIndex(spr, "StockNo"), xRow)
            If getColumIndex(spr, "CheckComplete") > -1 Then z2456.CheckComplete = getDataM(spr, getColumIndex(spr, "CheckComplete"), xRow)
            If getColumIndex(spr, "PriceShipping") > -1 Then z2456.PriceShipping = getDataM(spr, getColumIndex(spr, "PriceShipping"), xRow)
            If getColumIndex(spr, "PriceShippingVND") > -1 Then z2456.PriceShippingVND = getDataM(spr, getColumIndex(spr, "PriceShippingVND"), xRow)
            If getColumIndex(spr, "AmountShipping") > -1 Then z2456.AmountShipping = getDataM(spr, getColumIndex(spr, "AmountShipping"), xRow)
            If getColumIndex(spr, "AmountShippingVND") > -1 Then z2456.AmountShippingVND = getDataM(spr, getColumIndex(spr, "AmountShippingVND"), xRow)
            If getColumIndex(spr, "QtyProductOutbound") > -1 Then z2456.QtyProductOutbound = getDataM(spr, getColumIndex(spr, "QtyProductOutbound"), xRow)
            If getColumIndex(spr, "IsPosted") > -1 Then z2456.IsPosted = getDataM(spr, getColumIndex(spr, "IsPosted"), xRow)
            If getColumIndex(spr, "DatePosted") > -1 Then z2456.DatePosted = getDataM(spr, getColumIndex(spr, "DatePosted"), xRow)
            If getColumIndex(spr, "DateInsert") > -1 Then z2456.DateInsert = getDataM(spr, getColumIndex(spr, "DateInsert"), xRow)
            If getColumIndex(spr, "DateUpdate") > -1 Then z2456.DateUpdate = getDataM(spr, getColumIndex(spr, "DateUpdate"), xRow)
            If getColumIndex(spr, "InchargeInsert") > -1 Then z2456.InchargeInsert = getDataM(spr, getColumIndex(spr, "InchargeInsert"), xRow)
            If getColumIndex(spr, "InchargeUpdate") > -1 Then z2456.InchargeUpdate = getDataM(spr, getColumIndex(spr, "InchargeUpdate"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z2456.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K2456_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K2456_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z2456 As T2456_AREA, Job As String, PRODUCTOUTBOUNDNO As String, PRODUCTOUTBOUNDSEQ As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K2456_MOVE = False

        Try
            If READ_PFK2456(PRODUCTOUTBOUNDNO, PRODUCTOUTBOUNDSEQ) = True Then
                z2456 = D2456
                K2456_MOVE = True
            Else
                z2456 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK2456")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "PRODUCTOUTBOUNDNO" : z2456.ProductOutboundNo = Children(i).Code
                                Case "PRODUCTOUTBOUNDSEQ" : z2456.ProductOutboundSeq = Children(i).Code
                                Case "CUSTOMERCODE" : z2456.CustomerCode = Children(i).Code
                                Case "SUPPLIERCODE" : z2456.SupplierCode = Children(i).Code
                                Case "SEFACTORY" : z2456.seFactory = Children(i).Code
                                Case "CDFACTORY" : z2456.cdFactory = Children(i).Code
                                Case "SHOESCODE" : z2456.ShoesCode = Children(i).Code
                                Case "SIZERANGE" : z2456.SizeRange = Children(i).Code
                                Case "CHECKOUTBOUNDMATERIAL" : z2456.CheckOutBoundMaterial = Children(i).Code
                                Case "CHECKMATERIALTYPE" : z2456.CheckMaterialType = Children(i).Code
                                Case "CHECKMARKETTYPE" : z2456.CheckMarketType = Children(i).Code
                                Case "INVOICENO" : z2456.InvoiceNo = Children(i).Code
                                Case "SEUNITPRICE" : z2456.seUnitPrice = Children(i).Code
                                Case "CDUNITPRICE" : z2456.cdUnitPrice = Children(i).Code
                                Case "DATEEXCHANGE" : z2456.DateExchange = Children(i).Code
                                Case "PRICEEXCHANGE" : z2456.PriceExchange = Children(i).Code
                                Case "PRODUCTINBOUNDNO" : z2456.ProductInboundNo = Children(i).Code
                                Case "PRODUCTINBOUNDSEQ" : z2456.ProductInboundSeq = Children(i).Code
                                Case "DATEOUTBOUND" : z2456.DateOutbound = Children(i).Code
                                Case "INCHARGEOUTBOUND" : z2456.InchargeOutbound = Children(i).Code
                                Case "FACTORDERNO" : z2456.FactOrderNo = Children(i).Code
                                Case "FACTORDERSEQ" : z2456.FactOrderSeq = Children(i).Code
                                Case "PALLETNO" : z2456.PalletNo = Children(i).Code
                                Case "STOCKNO" : z2456.StockNo = Children(i).Code
                                Case "CHECKCOMPLETE" : z2456.CheckComplete = Children(i).Code
                                Case "PRICESHIPPING" : z2456.PriceShipping = Children(i).Code
                                Case "PRICESHIPPINGVND" : z2456.PriceShippingVND = Children(i).Code
                                Case "AMOUNTSHIPPING" : z2456.AmountShipping = Children(i).Code
                                Case "AMOUNTSHIPPINGVND" : z2456.AmountShippingVND = Children(i).Code
                                Case "QTYPRODUCTOUTBOUND" : z2456.QtyProductOutbound = Children(i).Code
                                Case "ISPOSTED" : z2456.IsPosted = Children(i).Code
                                Case "DATEPOSTED" : z2456.DatePosted = Children(i).Code
                                Case "DATEINSERT" : z2456.DateInsert = Children(i).Code
                                Case "DATEUPDATE" : z2456.DateUpdate = Children(i).Code
                                Case "INCHARGEINSERT" : z2456.InchargeInsert = Children(i).Code
                                Case "INCHARGEUPDATE" : z2456.InchargeUpdate = Children(i).Code
                                Case "REMARK" : z2456.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "PRODUCTOUTBOUNDNO" : z2456.ProductOutboundNo = Children(i).Data
                                Case "PRODUCTOUTBOUNDSEQ" : z2456.ProductOutboundSeq = Children(i).Data
                                Case "CUSTOMERCODE" : z2456.CustomerCode = Children(i).Data
                                Case "SUPPLIERCODE" : z2456.SupplierCode = Children(i).Data
                                Case "SEFACTORY" : z2456.seFactory = Children(i).Data
                                Case "CDFACTORY" : z2456.cdFactory = Children(i).Data
                                Case "SHOESCODE" : z2456.ShoesCode = Children(i).Data
                                Case "SIZERANGE" : z2456.SizeRange = Children(i).Data
                                Case "CHECKOUTBOUNDMATERIAL" : z2456.CheckOutBoundMaterial = Children(i).Data
                                Case "CHECKMATERIALTYPE" : z2456.CheckMaterialType = Children(i).Data
                                Case "CHECKMARKETTYPE" : z2456.CheckMarketType = Children(i).Data
                                Case "INVOICENO" : z2456.InvoiceNo = Children(i).Data
                                Case "SEUNITPRICE" : z2456.seUnitPrice = Children(i).Data
                                Case "CDUNITPRICE" : z2456.cdUnitPrice = Children(i).Data
                                Case "DATEEXCHANGE" : z2456.DateExchange = Children(i).Data
                                Case "PRICEEXCHANGE" : z2456.PriceExchange = Children(i).Data
                                Case "PRODUCTINBOUNDNO" : z2456.ProductInboundNo = Children(i).Data
                                Case "PRODUCTINBOUNDSEQ" : z2456.ProductInboundSeq = Children(i).Data
                                Case "DATEOUTBOUND" : z2456.DateOutbound = Children(i).Data
                                Case "INCHARGEOUTBOUND" : z2456.InchargeOutbound = Children(i).Data
                                Case "FACTORDERNO" : z2456.FactOrderNo = Children(i).Data
                                Case "FACTORDERSEQ" : z2456.FactOrderSeq = Children(i).Data
                                Case "PALLETNO" : z2456.PalletNo = Children(i).Data
                                Case "STOCKNO" : z2456.StockNo = Children(i).Data
                                Case "CHECKCOMPLETE" : z2456.CheckComplete = Children(i).Data
                                Case "PRICESHIPPING" : z2456.PriceShipping = Children(i).Data
                                Case "PRICESHIPPINGVND" : z2456.PriceShippingVND = Children(i).Data
                                Case "AMOUNTSHIPPING" : z2456.AmountShipping = Children(i).Data
                                Case "AMOUNTSHIPPINGVND" : z2456.AmountShippingVND = Children(i).Data
                                Case "QTYPRODUCTOUTBOUND" : z2456.QtyProductOutbound = Children(i).Data
                                Case "ISPOSTED" : z2456.IsPosted = Children(i).Data
                                Case "DATEPOSTED" : z2456.DatePosted = Children(i).Data
                                Case "DATEINSERT" : z2456.DateInsert = Children(i).Data
                                Case "DATEUPDATE" : z2456.DateUpdate = Children(i).Data
                                Case "INCHARGEINSERT" : z2456.InchargeInsert = Children(i).Data
                                Case "INCHARGEUPDATE" : z2456.InchargeUpdate = Children(i).Data
                                Case "REMARK" : z2456.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K2456_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K2456_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z2456 As T2456_AREA, Job As String, CheckClear As Boolean, PRODUCTOUTBOUNDNO As String, PRODUCTOUTBOUNDSEQ As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K2456_MOVE = False

        Try
            If READ_PFK2456(PRODUCTOUTBOUNDNO, PRODUCTOUTBOUNDSEQ) = True Then
                z2456 = D2456
                K2456_MOVE = True
            Else
                If CheckClear = True Then z2456 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK2456")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "PRODUCTOUTBOUNDNO" : z2456.ProductOutboundNo = Children(i).Code
                                Case "PRODUCTOUTBOUNDSEQ" : z2456.ProductOutboundSeq = Children(i).Code
                                Case "CUSTOMERCODE" : z2456.CustomerCode = Children(i).Code
                                Case "SUPPLIERCODE" : z2456.SupplierCode = Children(i).Code
                                Case "SEFACTORY" : z2456.seFactory = Children(i).Code
                                Case "CDFACTORY" : z2456.cdFactory = Children(i).Code
                                Case "SHOESCODE" : z2456.ShoesCode = Children(i).Code
                                Case "SIZERANGE" : z2456.SizeRange = Children(i).Code
                                Case "CHECKOUTBOUNDMATERIAL" : z2456.CheckOutBoundMaterial = Children(i).Code
                                Case "CHECKMATERIALTYPE" : z2456.CheckMaterialType = Children(i).Code
                                Case "CHECKMARKETTYPE" : z2456.CheckMarketType = Children(i).Code
                                Case "INVOICENO" : z2456.InvoiceNo = Children(i).Code
                                Case "SEUNITPRICE" : z2456.seUnitPrice = Children(i).Code
                                Case "CDUNITPRICE" : z2456.cdUnitPrice = Children(i).Code
                                Case "DATEEXCHANGE" : z2456.DateExchange = Children(i).Code
                                Case "PRICEEXCHANGE" : z2456.PriceExchange = Children(i).Code
                                Case "PRODUCTINBOUNDNO" : z2456.ProductInboundNo = Children(i).Code
                                Case "PRODUCTINBOUNDSEQ" : z2456.ProductInboundSeq = Children(i).Code
                                Case "DATEOUTBOUND" : z2456.DateOutbound = Children(i).Code
                                Case "INCHARGEOUTBOUND" : z2456.InchargeOutbound = Children(i).Code
                                Case "FACTORDERNO" : z2456.FactOrderNo = Children(i).Code
                                Case "FACTORDERSEQ" : z2456.FactOrderSeq = Children(i).Code
                                Case "PALLETNO" : z2456.PalletNo = Children(i).Code
                                Case "STOCKNO" : z2456.StockNo = Children(i).Code
                                Case "CHECKCOMPLETE" : z2456.CheckComplete = Children(i).Code
                                Case "PRICESHIPPING" : z2456.PriceShipping = Children(i).Code
                                Case "PRICESHIPPINGVND" : z2456.PriceShippingVND = Children(i).Code
                                Case "AMOUNTSHIPPING" : z2456.AmountShipping = Children(i).Code
                                Case "AMOUNTSHIPPINGVND" : z2456.AmountShippingVND = Children(i).Code
                                Case "QTYPRODUCTOUTBOUND" : z2456.QtyProductOutbound = Children(i).Code
                                Case "ISPOSTED" : z2456.IsPosted = Children(i).Code
                                Case "DATEPOSTED" : z2456.DatePosted = Children(i).Code
                                Case "DATEINSERT" : z2456.DateInsert = Children(i).Code
                                Case "DATEUPDATE" : z2456.DateUpdate = Children(i).Code
                                Case "INCHARGEINSERT" : z2456.InchargeInsert = Children(i).Code
                                Case "INCHARGEUPDATE" : z2456.InchargeUpdate = Children(i).Code
                                Case "REMARK" : z2456.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "PRODUCTOUTBOUNDNO" : z2456.ProductOutboundNo = Children(i).Data
                                Case "PRODUCTOUTBOUNDSEQ" : z2456.ProductOutboundSeq = Children(i).Data
                                Case "CUSTOMERCODE" : z2456.CustomerCode = Children(i).Data
                                Case "SUPPLIERCODE" : z2456.SupplierCode = Children(i).Data
                                Case "SEFACTORY" : z2456.seFactory = Children(i).Data
                                Case "CDFACTORY" : z2456.cdFactory = Children(i).Data
                                Case "SHOESCODE" : z2456.ShoesCode = Children(i).Data
                                Case "SIZERANGE" : z2456.SizeRange = Children(i).Data
                                Case "CHECKOUTBOUNDMATERIAL" : z2456.CheckOutBoundMaterial = Children(i).Data
                                Case "CHECKMATERIALTYPE" : z2456.CheckMaterialType = Children(i).Data
                                Case "CHECKMARKETTYPE" : z2456.CheckMarketType = Children(i).Data
                                Case "INVOICENO" : z2456.InvoiceNo = Children(i).Data
                                Case "SEUNITPRICE" : z2456.seUnitPrice = Children(i).Data
                                Case "CDUNITPRICE" : z2456.cdUnitPrice = Children(i).Data
                                Case "DATEEXCHANGE" : z2456.DateExchange = Children(i).Data
                                Case "PRICEEXCHANGE" : z2456.PriceExchange = Children(i).Data
                                Case "PRODUCTINBOUNDNO" : z2456.ProductInboundNo = Children(i).Data
                                Case "PRODUCTINBOUNDSEQ" : z2456.ProductInboundSeq = Children(i).Data
                                Case "DATEOUTBOUND" : z2456.DateOutbound = Children(i).Data
                                Case "INCHARGEOUTBOUND" : z2456.InchargeOutbound = Children(i).Data
                                Case "FACTORDERNO" : z2456.FactOrderNo = Children(i).Data
                                Case "FACTORDERSEQ" : z2456.FactOrderSeq = Children(i).Data
                                Case "PALLETNO" : z2456.PalletNo = Children(i).Data
                                Case "STOCKNO" : z2456.StockNo = Children(i).Data
                                Case "CHECKCOMPLETE" : z2456.CheckComplete = Children(i).Data
                                Case "PRICESHIPPING" : z2456.PriceShipping = Children(i).Data
                                Case "PRICESHIPPINGVND" : z2456.PriceShippingVND = Children(i).Data
                                Case "AMOUNTSHIPPING" : z2456.AmountShipping = Children(i).Data
   Case "AMOUNTSHIPPINGVND":z2456.AmountShippingVND = Children(i).Data
   Case "QTYPRODUCTOUTBOUND":z2456.QtyProductOutbound = Children(i).Data
   Case "ISPOSTED":z2456.IsPosted = Children(i).Data
   Case "DATEPOSTED":z2456.DatePosted = Children(i).Data
   Case "DATEINSERT":z2456.DateInsert = Children(i).Data
   Case "DATEUPDATE":z2456.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z2456.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z2456.InchargeUpdate = Children(i).Data
   Case "REMARK":z2456.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K2456_MOVE",vbCritical)
End Try
End Function 
    
End Module 
