'=========================================================================================================================================================
'   TABLE : (PFK3242)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K3242

    Structure T3242_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public RequestSalesNo As String  '			char(9)		*
        Public RequestSalesSeq As Double  '			decimal		*
        Public Dseq As Double  '			decimal
        Public MaterialCode As String  '			char(6)
        Public selUnitPrice As String  '			char(3)
        Public cdUnitPrice As String  '			char(3)
        Public PriceSales As Double  '			decimal
        Public PriceSalesUSD As Double  '			decimal
        Public PriceSalesVND As Double  '			decimal
        Public BoxRequestSales As Double  '			decimal
        Public QtyBasic As Double   '			decimal
        Public QtyRequestSales As Double  '			decimal
        Public AmtNetRequestSalesUSD As Double  '			decimal
        Public AmtNetRequestSalesVND As Double  '			decimal
        Public selTaxExport As String  '			char(3)
        Public cdTaxExport As String  '			char(3)
        Public PerTaxExport As Double  '			decimal
        Public AmtTaxExportRequestSales As Double  '			decimal
        Public selTaxVat As String  '			char(3)
        Public cdTaxVat As String  '			char(3)
        Public PerTaxVat As Double  '			decimal
        Public AmtTaxVatRequestSales As Double  '			decimal
        Public AmtGressRequestSalesUSD As Double  '			decimal
        Public AmtGressRequestSalesVND As Double  '			decimal
        Public BoxInOutboundWH As Double  '			decimal
        Public QtyInOutboundWH As Double  '			decimal
        Public AmtInOutboundWHUSD As Double  '			decimal
        Public AmtInOutboundWHVND As Double  '			decimal
        Public DateDelivery As String  '			char(8)
        Public InVoiceNo As String  '			char(9)
        Public SalesOrderNo As String  '			char(9)
        Public SalesOrderSeq As String  '			char(2)
        Public CheckRequestSales As String  '			char(1)
        Public DateRequestSales As String  '			char(8)
        Public DateApprovalSales As String  '			char(8)
        Public DateCancelSales As String  '			char(8)
        Public DateCompleteSales As String  '			char(8)
        Public Remark As String  '			nchar(200)
        '=========================================================================================================================================================
    End Structure

    Public D3242 As T3242_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK3242(REQUESTSALESNO As String, REQUESTSALESSEQ As Double) As Boolean
        READ_PFK3242 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK3242 "
            SQL = SQL & " WHERE K3242_RequestSalesNo		 = '" & RequestSalesNo & "' "
            SQL = SQL & "   AND K3242_RequestSalesSeq		 =  " & RequestSalesSeq & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D3242_CLEAR() : GoTo SKIP_READ_PFK3242

            Call K3242_MOVE(rd)
            READ_PFK3242 = True

SKIP_READ_PFK3242:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK3242", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK3242(REQUESTSALESNO As String, REQUESTSALESSEQ As Double, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK3242 "
            SQL = SQL & " WHERE K3242_RequestSalesNo		 = '" & RequestSalesNo & "' "
            SQL = SQL & "   AND K3242_RequestSalesSeq		 =  " & RequestSalesSeq & "  "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK3242", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK3242(z3242 As T3242_AREA) As Boolean
        WRITE_PFK3242 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z3242)

            SQL = " INSERT INTO PFK3242 "
            SQL = SQL & " ( "
            SQL = SQL & " K3242_RequestSalesNo,"
            SQL = SQL & " K3242_RequestSalesSeq,"
            SQL = SQL & " K3242_Dseq,"
            SQL = SQL & " K3242_MaterialCode,"
            SQL = SQL & " K3242_selUnitPrice,"
            SQL = SQL & " K3242_cdUnitPrice,"
            SQL = SQL & " K3242_PriceSales,"
            SQL = SQL & " K3242_PriceSalesUSD,"
            SQL = SQL & " K3242_PriceSalesVND,"
            SQL = SQL & " K3242_QtyBasic,"
            SQL = SQL & " K3242_BoxRequestSales,"
            SQL = SQL & " K3242_QtyRequestSales,"
            SQL = SQL & " K3242_AmtNetRequestSalesUSD,"
            SQL = SQL & " K3242_AmtNetRequestSalesVND,"
            SQL = SQL & " K3242_selTaxExport,"
            SQL = SQL & " K3242_cdTaxExport,"
            SQL = SQL & " K3242_PerTaxExport,"
            SQL = SQL & " K3242_AmtTaxExportRequestSales,"
            SQL = SQL & " K3242_selTaxVat,"
            SQL = SQL & " K3242_cdTaxVat,"
            SQL = SQL & " K3242_PerTaxVat,"
            SQL = SQL & " K3242_AmtTaxVatRequestSales,"
            SQL = SQL & " K3242_AmtGressRequestSalesUSD,"
            SQL = SQL & " K3242_AmtGressRequestSalesVND,"
            SQL = SQL & " K3242_BoxInOutboundWH,"
            SQL = SQL & " K3242_QtyInOutboundWH,"
            SQL = SQL & " K3242_AmtInOutboundWHUSD,"
            SQL = SQL & " K3242_AmtInOutboundWHVND,"
            SQL = SQL & " K3242_DateDelivery,"
            SQL = SQL & " K3242_InVoiceNo,"
            SQL = SQL & " K3242_SalesOrderNo,"
            SQL = SQL & " K3242_SalesOrderSeq,"
            SQL = SQL & " K3242_CheckRequestSales,"
            SQL = SQL & " K3242_DateRequestSales,"
            SQL = SQL & " K3242_DateApprovalSales,"
            SQL = SQL & " K3242_DateCancelSales,"
            SQL = SQL & " K3242_DateCompleteSales,"
            SQL = SQL & " K3242_Remark "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z3242.RequestSalesNo) & "', "
            SQL = SQL & "   " & FormatSQL(z3242.RequestSalesSeq) & ", "
            SQL = SQL & "   " & FormatSQL(z3242.Dseq) & ", "
            SQL = SQL & "  N'" & FormatSQL(z3242.MaterialCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3242.selUnitPrice) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3242.cdUnitPrice) & "', "
            SQL = SQL & "   " & FormatSQL(z3242.PriceSales) & ", "
            SQL = SQL & "   " & FormatSQL(z3242.PriceSalesUSD) & ", "
            SQL = SQL & "   " & FormatSQL(z3242.PriceSalesVND) & ", "
            SQL = SQL & "   " & FormatSQL(z3242.QtyBasic) & ", "
            SQL = SQL & "   " & FormatSQL(z3242.BoxRequestSales) & ", "
            SQL = SQL & "   " & FormatSQL(z3242.QtyRequestSales) & ", "
            SQL = SQL & "   " & FormatSQL(z3242.AmtNetRequestSalesUSD) & ", "
            SQL = SQL & "   " & FormatSQL(z3242.AmtNetRequestSalesVND) & ", "
            SQL = SQL & "  N'" & FormatSQL(z3242.selTaxExport) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3242.cdTaxExport) & "', "
            SQL = SQL & "   " & FormatSQL(z3242.PerTaxExport) & ", "
            SQL = SQL & "   " & FormatSQL(z3242.AmtTaxExportRequestSales) & ", "
            SQL = SQL & "  N'" & FormatSQL(z3242.selTaxVat) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3242.cdTaxVat) & "', "
            SQL = SQL & "   " & FormatSQL(z3242.PerTaxVat) & ", "
            SQL = SQL & "   " & FormatSQL(z3242.AmtTaxVatRequestSales) & ", "
            SQL = SQL & "   " & FormatSQL(z3242.AmtGressRequestSalesUSD) & ", "
            SQL = SQL & "   " & FormatSQL(z3242.AmtGressRequestSalesVND) & ", "
            SQL = SQL & "   " & FormatSQL(z3242.BoxInOutboundWH) & ", "
            SQL = SQL & "   " & FormatSQL(z3242.QtyInOutboundWH) & ", "
            SQL = SQL & "   " & FormatSQL(z3242.AmtInOutboundWHUSD) & ", "
            SQL = SQL & "   " & FormatSQL(z3242.AmtInOutboundWHVND) & ", "
            SQL = SQL & "  N'" & FormatSQL(z3242.DateDelivery) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3242.InVoiceNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3242.SalesOrderNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3242.SalesOrderSeq) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3242.CheckRequestSales) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3242.DateRequestSales) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3242.DateApprovalSales) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3242.DateCancelSales) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3242.DateCompleteSales) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3242.Remark) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK3242 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK3242", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK3242(z3242 As T3242_AREA) As Boolean
        REWRITE_PFK3242 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z3242)

            SQL = " UPDATE PFK3242 SET "
            SQL = SQL & "    K3242_Dseq      =  " & FormatSQL(z3242.Dseq) & ", "
            SQL = SQL & "    K3242_MaterialCode      = N'" & FormatSQL(z3242.MaterialCode) & "', "
            SQL = SQL & "    K3242_selUnitPrice      = N'" & FormatSQL(z3242.selUnitPrice) & "', "
            SQL = SQL & "    K3242_cdUnitPrice      = N'" & FormatSQL(z3242.cdUnitPrice) & "', "
            SQL = SQL & "    K3242_PriceSales      =  " & FormatSQL(z3242.PriceSales) & ", "
            SQL = SQL & "    K3242_PriceSalesUSD      =  " & FormatSQL(z3242.PriceSalesUSD) & ", "
            SQL = SQL & "    K3242_PriceSalesVND      =  " & FormatSQL(z3242.PriceSalesVND) & ", "
            SQL = SQL & "    K3242_QtyBasic      =  " & FormatSQL(z3242.QtyBasic) & ", "
            SQL = SQL & "    K3242_BoxRequestSales      =  " & FormatSQL(z3242.BoxRequestSales) & ", "
            SQL = SQL & "    K3242_QtyRequestSales      =  " & FormatSQL(z3242.QtyRequestSales) & ", "
            SQL = SQL & "    K3242_AmtNetRequestSalesUSD      =  " & FormatSQL(z3242.AmtNetRequestSalesUSD) & ", "
            SQL = SQL & "    K3242_AmtNetRequestSalesVND      =  " & FormatSQL(z3242.AmtNetRequestSalesVND) & ", "
            SQL = SQL & "    K3242_selTaxExport      = N'" & FormatSQL(z3242.selTaxExport) & "', "
            SQL = SQL & "    K3242_cdTaxExport      = N'" & FormatSQL(z3242.cdTaxExport) & "', "
            SQL = SQL & "    K3242_PerTaxExport      =  " & FormatSQL(z3242.PerTaxExport) & ", "
            SQL = SQL & "    K3242_AmtTaxExportRequestSales      =  " & FormatSQL(z3242.AmtTaxExportRequestSales) & ", "
            SQL = SQL & "    K3242_selTaxVat      = N'" & FormatSQL(z3242.selTaxVat) & "', "
            SQL = SQL & "    K3242_cdTaxVat      = N'" & FormatSQL(z3242.cdTaxVat) & "', "
            SQL = SQL & "    K3242_PerTaxVat      =  " & FormatSQL(z3242.PerTaxVat) & ", "
            SQL = SQL & "    K3242_AmtTaxVatRequestSales      =  " & FormatSQL(z3242.AmtTaxVatRequestSales) & ", "
            SQL = SQL & "    K3242_AmtGressRequestSalesUSD      =  " & FormatSQL(z3242.AmtGressRequestSalesUSD) & ", "
            SQL = SQL & "    K3242_AmtGressRequestSalesVND      =  " & FormatSQL(z3242.AmtGressRequestSalesVND) & ", "
            SQL = SQL & "    K3242_BoxInOutboundWH      =  " & FormatSQL(z3242.BoxInOutboundWH) & ", "
            SQL = SQL & "    K3242_QtyInOutboundWH      =  " & FormatSQL(z3242.QtyInOutboundWH) & ", "
            SQL = SQL & "    K3242_AmtInOutboundWHUSD      =  " & FormatSQL(z3242.AmtInOutboundWHUSD) & ", "
            SQL = SQL & "    K3242_AmtInOutboundWHVND      =  " & FormatSQL(z3242.AmtInOutboundWHVND) & ", "
            SQL = SQL & "    K3242_DateDelivery      = N'" & FormatSQL(z3242.DateDelivery) & "', "
            SQL = SQL & "    K3242_InVoiceNo      = N'" & FormatSQL(z3242.InVoiceNo) & "', "
            SQL = SQL & "    K3242_SalesOrderNo      = N'" & FormatSQL(z3242.SalesOrderNo) & "', "
            SQL = SQL & "    K3242_SalesOrderSeq      = N'" & FormatSQL(z3242.SalesOrderSeq) & "', "
            SQL = SQL & "    K3242_CheckRequestSales      = N'" & FormatSQL(z3242.CheckRequestSales) & "', "
            SQL = SQL & "    K3242_DateRequestSales      = N'" & FormatSQL(z3242.DateRequestSales) & "', "
            SQL = SQL & "    K3242_DateApprovalSales      = N'" & FormatSQL(z3242.DateApprovalSales) & "', "
            SQL = SQL & "    K3242_DateCancelSales      = N'" & FormatSQL(z3242.DateCancelSales) & "', "
            SQL = SQL & "    K3242_DateCompleteSales      = N'" & FormatSQL(z3242.DateCompleteSales) & "', "
            SQL = SQL & "    K3242_Remark      = N'" & FormatSQL(z3242.Remark) & "'  "
            SQL = SQL & " WHERE K3242_RequestSalesNo		 = '" & z3242.RequestSalesNo & "' "
            SQL = SQL & "   AND K3242_RequestSalesSeq		 =  " & z3242.RequestSalesSeq & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK3242 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK3242", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK3242(z3242 As T3242_AREA) As Boolean
        DELETE_PFK3242 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK3242 "
            SQL = SQL & " WHERE K3242_RequestSalesNo		 = '" & z3242.RequestSalesNo & "' "
            SQL = SQL & "   AND K3242_RequestSalesSeq		 =  " & z3242.RequestSalesSeq & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK3242 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK3242", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D3242_CLEAR()
        Try

            D3242.RequestSalesNo = ""
            D3242.RequestSalesSeq = 0
            D3242.Dseq = 0
            D3242.MaterialCode = ""
            D3242.selUnitPrice = ""
            D3242.cdUnitPrice = ""
            D3242.PriceSales = 0
            D3242.PriceSalesUSD = 0
            D3242.PriceSalesVND = 0
            D3242.QtyBasic = 0
            D3242.BoxRequestSales = 0
            D3242.QtyRequestSales = 0
            D3242.AmtNetRequestSalesUSD = 0
            D3242.AmtNetRequestSalesVND = 0
            D3242.selTaxExport = ""
            D3242.cdTaxExport = ""
            D3242.PerTaxExport = 0
            D3242.AmtTaxExportRequestSales = 0
            D3242.selTaxVat = ""
            D3242.cdTaxVat = ""
            D3242.PerTaxVat = 0
            D3242.AmtTaxVatRequestSales = 0
            D3242.AmtGressRequestSalesUSD = 0
            D3242.AmtGressRequestSalesVND = 0
            D3242.BoxInOutboundWH = 0
            D3242.QtyInOutboundWH = 0
            D3242.AmtInOutboundWHUSD = 0
            D3242.AmtInOutboundWHVND = 0
            D3242.DateDelivery = ""
            D3242.InVoiceNo = ""
            D3242.SalesOrderNo = ""
            D3242.SalesOrderSeq = ""
            D3242.CheckRequestSales = ""
            D3242.DateRequestSales = ""
            D3242.DateApprovalSales = ""
            D3242.DateCancelSales = ""
            D3242.DateCompleteSales = ""
            D3242.Remark = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D3242_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x3242 As T3242_AREA)
        Try

            x3242.RequestSalesNo = trim$(x3242.RequestSalesNo)
            x3242.RequestSalesSeq = trim$(x3242.RequestSalesSeq)
            x3242.Dseq = trim$(x3242.Dseq)
            x3242.MaterialCode = trim$(x3242.MaterialCode)
            x3242.selUnitPrice = trim$(x3242.selUnitPrice)
            x3242.cdUnitPrice = trim$(x3242.cdUnitPrice)
            x3242.PriceSales = trim$(x3242.PriceSales)
            x3242.PriceSalesUSD = trim$(x3242.PriceSalesUSD)
            x3242.PriceSalesVND = trim$(x3242.PriceSalesVND)
            x3242.QtyBasic = Trim$(x3242.QtyBasic)
            x3242.BoxRequestSales = Trim$(x3242.BoxRequestSales)
            x3242.QtyRequestSales = trim$(x3242.QtyRequestSales)
            x3242.AmtNetRequestSalesUSD = trim$(x3242.AmtNetRequestSalesUSD)
            x3242.AmtNetRequestSalesVND = trim$(x3242.AmtNetRequestSalesVND)
            x3242.selTaxExport = trim$(x3242.selTaxExport)
            x3242.cdTaxExport = trim$(x3242.cdTaxExport)
            x3242.PerTaxExport = trim$(x3242.PerTaxExport)
            x3242.AmtTaxExportRequestSales = trim$(x3242.AmtTaxExportRequestSales)
            x3242.selTaxVat = trim$(x3242.selTaxVat)
            x3242.cdTaxVat = trim$(x3242.cdTaxVat)
            x3242.PerTaxVat = trim$(x3242.PerTaxVat)
            x3242.AmtTaxVatRequestSales = trim$(x3242.AmtTaxVatRequestSales)
            x3242.AmtGressRequestSalesUSD = trim$(x3242.AmtGressRequestSalesUSD)
            x3242.AmtGressRequestSalesVND = trim$(x3242.AmtGressRequestSalesVND)
            x3242.BoxInOutboundWH = trim$(x3242.BoxInOutboundWH)
            x3242.QtyInOutboundWH = trim$(x3242.QtyInOutboundWH)
            x3242.AmtInOutboundWHUSD = trim$(x3242.AmtInOutboundWHUSD)
            x3242.AmtInOutboundWHVND = trim$(x3242.AmtInOutboundWHVND)
            x3242.DateDelivery = trim$(x3242.DateDelivery)
            x3242.InVoiceNo = trim$(x3242.InVoiceNo)
            x3242.SalesOrderNo = trim$(x3242.SalesOrderNo)
            x3242.SalesOrderSeq = trim$(x3242.SalesOrderSeq)
            x3242.CheckRequestSales = trim$(x3242.CheckRequestSales)
            x3242.DateRequestSales = trim$(x3242.DateRequestSales)
            x3242.DateApprovalSales = trim$(x3242.DateApprovalSales)
            x3242.DateCancelSales = trim$(x3242.DateCancelSales)
            x3242.DateCompleteSales = trim$(x3242.DateCompleteSales)
            x3242.Remark = trim$(x3242.Remark)

            If trim$(x3242.RequestSalesNo) = "" Then x3242.RequestSalesNo = Space(1)
            If trim$(x3242.RequestSalesSeq) = "" Then x3242.RequestSalesSeq = 0
            If trim$(x3242.Dseq) = "" Then x3242.Dseq = 0
            If trim$(x3242.MaterialCode) = "" Then x3242.MaterialCode = Space(1)
            If trim$(x3242.selUnitPrice) = "" Then x3242.selUnitPrice = Space(1)
            If trim$(x3242.cdUnitPrice) = "" Then x3242.cdUnitPrice = Space(1)
            If trim$(x3242.PriceSales) = "" Then x3242.PriceSales = 0
            If trim$(x3242.PriceSalesUSD) = "" Then x3242.PriceSalesUSD = 0
            If trim$(x3242.PriceSalesVND) = "" Then x3242.PriceSalesVND = 0
            If Trim$(x3242.QtyBasic) = "" Then x3242.QtyBasic = 0
            If Trim$(x3242.BoxRequestSales) = "" Then x3242.BoxRequestSales = 0
            If trim$(x3242.QtyRequestSales) = "" Then x3242.QtyRequestSales = 0
            If trim$(x3242.AmtNetRequestSalesUSD) = "" Then x3242.AmtNetRequestSalesUSD = 0
            If trim$(x3242.AmtNetRequestSalesVND) = "" Then x3242.AmtNetRequestSalesVND = 0
            If trim$(x3242.selTaxExport) = "" Then x3242.selTaxExport = Space(1)
            If trim$(x3242.cdTaxExport) = "" Then x3242.cdTaxExport = Space(1)
            If trim$(x3242.PerTaxExport) = "" Then x3242.PerTaxExport = 0
            If trim$(x3242.AmtTaxExportRequestSales) = "" Then x3242.AmtTaxExportRequestSales = 0
            If trim$(x3242.selTaxVat) = "" Then x3242.selTaxVat = Space(1)
            If trim$(x3242.cdTaxVat) = "" Then x3242.cdTaxVat = Space(1)
            If trim$(x3242.PerTaxVat) = "" Then x3242.PerTaxVat = 0
            If trim$(x3242.AmtTaxVatRequestSales) = "" Then x3242.AmtTaxVatRequestSales = 0
            If trim$(x3242.AmtGressRequestSalesUSD) = "" Then x3242.AmtGressRequestSalesUSD = 0
            If trim$(x3242.AmtGressRequestSalesVND) = "" Then x3242.AmtGressRequestSalesVND = 0
            If trim$(x3242.BoxInOutboundWH) = "" Then x3242.BoxInOutboundWH = 0
            If trim$(x3242.QtyInOutboundWH) = "" Then x3242.QtyInOutboundWH = 0
            If trim$(x3242.AmtInOutboundWHUSD) = "" Then x3242.AmtInOutboundWHUSD = 0
            If trim$(x3242.AmtInOutboundWHVND) = "" Then x3242.AmtInOutboundWHVND = 0
            If trim$(x3242.DateDelivery) = "" Then x3242.DateDelivery = Space(1)
            If trim$(x3242.InVoiceNo) = "" Then x3242.InVoiceNo = Space(1)
            If trim$(x3242.SalesOrderNo) = "" Then x3242.SalesOrderNo = Space(1)
            If trim$(x3242.SalesOrderSeq) = "" Then x3242.SalesOrderSeq = Space(1)
            If trim$(x3242.CheckRequestSales) = "" Then x3242.CheckRequestSales = Space(1)
            If trim$(x3242.DateRequestSales) = "" Then x3242.DateRequestSales = Space(1)
            If trim$(x3242.DateApprovalSales) = "" Then x3242.DateApprovalSales = Space(1)
            If trim$(x3242.DateCancelSales) = "" Then x3242.DateCancelSales = Space(1)
            If trim$(x3242.DateCompleteSales) = "" Then x3242.DateCompleteSales = Space(1)
            If trim$(x3242.Remark) = "" Then x3242.Remark = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K3242_MOVE(rs3242 As SqlClient.SqlDataReader)
        Try

            Call D3242_CLEAR()

            If IsdbNull(rs3242!K3242_RequestSalesNo) = False Then D3242.RequestSalesNo = Trim$(rs3242!K3242_RequestSalesNo)
            If IsdbNull(rs3242!K3242_RequestSalesSeq) = False Then D3242.RequestSalesSeq = Trim$(rs3242!K3242_RequestSalesSeq)
            If IsdbNull(rs3242!K3242_Dseq) = False Then D3242.Dseq = Trim$(rs3242!K3242_Dseq)
            If IsdbNull(rs3242!K3242_MaterialCode) = False Then D3242.MaterialCode = Trim$(rs3242!K3242_MaterialCode)
            If IsdbNull(rs3242!K3242_selUnitPrice) = False Then D3242.selUnitPrice = Trim$(rs3242!K3242_selUnitPrice)
            If IsdbNull(rs3242!K3242_cdUnitPrice) = False Then D3242.cdUnitPrice = Trim$(rs3242!K3242_cdUnitPrice)
            If IsdbNull(rs3242!K3242_PriceSales) = False Then D3242.PriceSales = Trim$(rs3242!K3242_PriceSales)
            If IsdbNull(rs3242!K3242_PriceSalesUSD) = False Then D3242.PriceSalesUSD = Trim$(rs3242!K3242_PriceSalesUSD)
            If IsdbNull(rs3242!K3242_PriceSalesVND) = False Then D3242.PriceSalesVND = Trim$(rs3242!K3242_PriceSalesVND)
            If IsDBNull(rs3242!K3242_QtyBasic) = False Then D3242.QtyBasic = Trim$(rs3242!K3242_QtyBasic)
            If IsDBNull(rs3242!K3242_BoxRequestSales) = False Then D3242.BoxRequestSales = Trim$(rs3242!K3242_BoxRequestSales)
            If IsdbNull(rs3242!K3242_QtyRequestSales) = False Then D3242.QtyRequestSales = Trim$(rs3242!K3242_QtyRequestSales)
            If IsdbNull(rs3242!K3242_AmtNetRequestSalesUSD) = False Then D3242.AmtNetRequestSalesUSD = Trim$(rs3242!K3242_AmtNetRequestSalesUSD)
            If IsdbNull(rs3242!K3242_AmtNetRequestSalesVND) = False Then D3242.AmtNetRequestSalesVND = Trim$(rs3242!K3242_AmtNetRequestSalesVND)
            If IsdbNull(rs3242!K3242_selTaxExport) = False Then D3242.selTaxExport = Trim$(rs3242!K3242_selTaxExport)
            If IsdbNull(rs3242!K3242_cdTaxExport) = False Then D3242.cdTaxExport = Trim$(rs3242!K3242_cdTaxExport)
            If IsdbNull(rs3242!K3242_PerTaxExport) = False Then D3242.PerTaxExport = Trim$(rs3242!K3242_PerTaxExport)
            If IsdbNull(rs3242!K3242_AmtTaxExportRequestSales) = False Then D3242.AmtTaxExportRequestSales = Trim$(rs3242!K3242_AmtTaxExportRequestSales)
            If IsdbNull(rs3242!K3242_selTaxVat) = False Then D3242.selTaxVat = Trim$(rs3242!K3242_selTaxVat)
            If IsdbNull(rs3242!K3242_cdTaxVat) = False Then D3242.cdTaxVat = Trim$(rs3242!K3242_cdTaxVat)
            If IsdbNull(rs3242!K3242_PerTaxVat) = False Then D3242.PerTaxVat = Trim$(rs3242!K3242_PerTaxVat)
            If IsdbNull(rs3242!K3242_AmtTaxVatRequestSales) = False Then D3242.AmtTaxVatRequestSales = Trim$(rs3242!K3242_AmtTaxVatRequestSales)
            If IsdbNull(rs3242!K3242_AmtGressRequestSalesUSD) = False Then D3242.AmtGressRequestSalesUSD = Trim$(rs3242!K3242_AmtGressRequestSalesUSD)
            If IsdbNull(rs3242!K3242_AmtGressRequestSalesVND) = False Then D3242.AmtGressRequestSalesVND = Trim$(rs3242!K3242_AmtGressRequestSalesVND)
            If IsdbNull(rs3242!K3242_BoxInOutboundWH) = False Then D3242.BoxInOutboundWH = Trim$(rs3242!K3242_BoxInOutboundWH)
            If IsdbNull(rs3242!K3242_QtyInOutboundWH) = False Then D3242.QtyInOutboundWH = Trim$(rs3242!K3242_QtyInOutboundWH)
            If IsdbNull(rs3242!K3242_AmtInOutboundWHUSD) = False Then D3242.AmtInOutboundWHUSD = Trim$(rs3242!K3242_AmtInOutboundWHUSD)
            If IsdbNull(rs3242!K3242_AmtInOutboundWHVND) = False Then D3242.AmtInOutboundWHVND = Trim$(rs3242!K3242_AmtInOutboundWHVND)
            If IsdbNull(rs3242!K3242_DateDelivery) = False Then D3242.DateDelivery = Trim$(rs3242!K3242_DateDelivery)
            If IsdbNull(rs3242!K3242_InVoiceNo) = False Then D3242.InVoiceNo = Trim$(rs3242!K3242_InVoiceNo)
            If IsdbNull(rs3242!K3242_SalesOrderNo) = False Then D3242.SalesOrderNo = Trim$(rs3242!K3242_SalesOrderNo)
            If IsdbNull(rs3242!K3242_SalesOrderSeq) = False Then D3242.SalesOrderSeq = Trim$(rs3242!K3242_SalesOrderSeq)
            If IsdbNull(rs3242!K3242_CheckRequestSales) = False Then D3242.CheckRequestSales = Trim$(rs3242!K3242_CheckRequestSales)
            If IsdbNull(rs3242!K3242_DateRequestSales) = False Then D3242.DateRequestSales = Trim$(rs3242!K3242_DateRequestSales)
            If IsdbNull(rs3242!K3242_DateApprovalSales) = False Then D3242.DateApprovalSales = Trim$(rs3242!K3242_DateApprovalSales)
            If IsdbNull(rs3242!K3242_DateCancelSales) = False Then D3242.DateCancelSales = Trim$(rs3242!K3242_DateCancelSales)
            If IsdbNull(rs3242!K3242_DateCompleteSales) = False Then D3242.DateCompleteSales = Trim$(rs3242!K3242_DateCompleteSales)
            If IsdbNull(rs3242!K3242_Remark) = False Then D3242.Remark = Trim$(rs3242!K3242_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K3242_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K3242_MOVE(rs3242 As DataRow)
        Try

            Call D3242_CLEAR()

            If IsdbNull(rs3242!K3242_RequestSalesNo) = False Then D3242.RequestSalesNo = Trim$(rs3242!K3242_RequestSalesNo)
            If IsdbNull(rs3242!K3242_RequestSalesSeq) = False Then D3242.RequestSalesSeq = Trim$(rs3242!K3242_RequestSalesSeq)
            If IsdbNull(rs3242!K3242_Dseq) = False Then D3242.Dseq = Trim$(rs3242!K3242_Dseq)
            If IsdbNull(rs3242!K3242_MaterialCode) = False Then D3242.MaterialCode = Trim$(rs3242!K3242_MaterialCode)
            If IsdbNull(rs3242!K3242_selUnitPrice) = False Then D3242.selUnitPrice = Trim$(rs3242!K3242_selUnitPrice)
            If IsdbNull(rs3242!K3242_cdUnitPrice) = False Then D3242.cdUnitPrice = Trim$(rs3242!K3242_cdUnitPrice)
            If IsdbNull(rs3242!K3242_PriceSales) = False Then D3242.PriceSales = Trim$(rs3242!K3242_PriceSales)
            If IsdbNull(rs3242!K3242_PriceSalesUSD) = False Then D3242.PriceSalesUSD = Trim$(rs3242!K3242_PriceSalesUSD)
            If IsDBNull(rs3242!K3242_PriceSalesVND) = False Then D3242.PriceSalesVND = Trim$(rs3242!K3242_PriceSalesVND)
            If IsDBNull(rs3242!K3242_QtyBasic) = False Then D3242.QtyBasic = Trim$(rs3242!K3242_QtyBasic)
            If IsDBNull(rs3242!K3242_BoxRequestSales) = False Then D3242.BoxRequestSales = Trim$(rs3242!K3242_BoxRequestSales)
            If IsdbNull(rs3242!K3242_QtyRequestSales) = False Then D3242.QtyRequestSales = Trim$(rs3242!K3242_QtyRequestSales)
            If IsdbNull(rs3242!K3242_AmtNetRequestSalesUSD) = False Then D3242.AmtNetRequestSalesUSD = Trim$(rs3242!K3242_AmtNetRequestSalesUSD)
            If IsdbNull(rs3242!K3242_AmtNetRequestSalesVND) = False Then D3242.AmtNetRequestSalesVND = Trim$(rs3242!K3242_AmtNetRequestSalesVND)
            If IsdbNull(rs3242!K3242_selTaxExport) = False Then D3242.selTaxExport = Trim$(rs3242!K3242_selTaxExport)
            If IsdbNull(rs3242!K3242_cdTaxExport) = False Then D3242.cdTaxExport = Trim$(rs3242!K3242_cdTaxExport)
            If IsdbNull(rs3242!K3242_PerTaxExport) = False Then D3242.PerTaxExport = Trim$(rs3242!K3242_PerTaxExport)
            If IsdbNull(rs3242!K3242_AmtTaxExportRequestSales) = False Then D3242.AmtTaxExportRequestSales = Trim$(rs3242!K3242_AmtTaxExportRequestSales)
            If IsdbNull(rs3242!K3242_selTaxVat) = False Then D3242.selTaxVat = Trim$(rs3242!K3242_selTaxVat)
            If IsdbNull(rs3242!K3242_cdTaxVat) = False Then D3242.cdTaxVat = Trim$(rs3242!K3242_cdTaxVat)
            If IsdbNull(rs3242!K3242_PerTaxVat) = False Then D3242.PerTaxVat = Trim$(rs3242!K3242_PerTaxVat)
            If IsdbNull(rs3242!K3242_AmtTaxVatRequestSales) = False Then D3242.AmtTaxVatRequestSales = Trim$(rs3242!K3242_AmtTaxVatRequestSales)
            If IsdbNull(rs3242!K3242_AmtGressRequestSalesUSD) = False Then D3242.AmtGressRequestSalesUSD = Trim$(rs3242!K3242_AmtGressRequestSalesUSD)
            If IsdbNull(rs3242!K3242_AmtGressRequestSalesVND) = False Then D3242.AmtGressRequestSalesVND = Trim$(rs3242!K3242_AmtGressRequestSalesVND)
            If IsdbNull(rs3242!K3242_BoxInOutboundWH) = False Then D3242.BoxInOutboundWH = Trim$(rs3242!K3242_BoxInOutboundWH)
            If IsdbNull(rs3242!K3242_QtyInOutboundWH) = False Then D3242.QtyInOutboundWH = Trim$(rs3242!K3242_QtyInOutboundWH)
            If IsdbNull(rs3242!K3242_AmtInOutboundWHUSD) = False Then D3242.AmtInOutboundWHUSD = Trim$(rs3242!K3242_AmtInOutboundWHUSD)
            If IsdbNull(rs3242!K3242_AmtInOutboundWHVND) = False Then D3242.AmtInOutboundWHVND = Trim$(rs3242!K3242_AmtInOutboundWHVND)
            If IsdbNull(rs3242!K3242_DateDelivery) = False Then D3242.DateDelivery = Trim$(rs3242!K3242_DateDelivery)
            If IsdbNull(rs3242!K3242_InVoiceNo) = False Then D3242.InVoiceNo = Trim$(rs3242!K3242_InVoiceNo)
            If IsdbNull(rs3242!K3242_SalesOrderNo) = False Then D3242.SalesOrderNo = Trim$(rs3242!K3242_SalesOrderNo)
            If IsdbNull(rs3242!K3242_SalesOrderSeq) = False Then D3242.SalesOrderSeq = Trim$(rs3242!K3242_SalesOrderSeq)
            If IsdbNull(rs3242!K3242_CheckRequestSales) = False Then D3242.CheckRequestSales = Trim$(rs3242!K3242_CheckRequestSales)
            If IsdbNull(rs3242!K3242_DateRequestSales) = False Then D3242.DateRequestSales = Trim$(rs3242!K3242_DateRequestSales)
            If IsdbNull(rs3242!K3242_DateApprovalSales) = False Then D3242.DateApprovalSales = Trim$(rs3242!K3242_DateApprovalSales)
            If IsdbNull(rs3242!K3242_DateCancelSales) = False Then D3242.DateCancelSales = Trim$(rs3242!K3242_DateCancelSales)
            If IsdbNull(rs3242!K3242_DateCompleteSales) = False Then D3242.DateCompleteSales = Trim$(rs3242!K3242_DateCompleteSales)
            If IsdbNull(rs3242!K3242_Remark) = False Then D3242.Remark = Trim$(rs3242!K3242_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K3242_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K3242_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z3242 As T3242_AREA, REQUESTSALESNO As String, REQUESTSALESSEQ As Double) As Boolean

        K3242_MOVE = False

        Try
            If READ_PFK3242(REQUESTSALESNO, REQUESTSALESSEQ) = True Then
                z3242 = D3242
                K3242_MOVE = True
            Else
                z3242 = Nothing
            End If

            If getColumIndex(spr, "RequestSalesNo") > -1 Then z3242.RequestSalesNo = getDataM(spr, getColumIndex(spr, "RequestSalesNo"), xRow)
            If getColumIndex(spr, "RequestSalesSeq") > -1 Then z3242.RequestSalesSeq = getDataM(spr, getColumIndex(spr, "RequestSalesSeq"), xRow)
            If getColumIndex(spr, "Dseq") > -1 Then z3242.Dseq = getDataM(spr, getColumIndex(spr, "Dseq"), xRow)
            If getColumIndex(spr, "MaterialCode") > -1 Then z3242.MaterialCode = getDataM(spr, getColumIndex(spr, "MaterialCode"), xRow)
            If getColumIndex(spr, "selUnitPrice") > -1 Then z3242.selUnitPrice = getDataM(spr, getColumIndex(spr, "selUnitPrice"), xRow)
            If getColumIndex(spr, "cdUnitPrice") > -1 Then z3242.cdUnitPrice = getDataM(spr, getColumIndex(spr, "cdUnitPrice"), xRow)
            If getColumIndex(spr, "PriceSales") > -1 Then z3242.PriceSales = getDataM(spr, getColumIndex(spr, "PriceSales"), xRow)
            If getColumIndex(spr, "PriceSalesUSD") > -1 Then z3242.PriceSalesUSD = getDataM(spr, getColumIndex(spr, "PriceSalesUSD"), xRow)
            If getColumIndex(spr, "PriceSalesVND") > -1 Then z3242.PriceSalesVND = getDataM(spr, getColumIndex(spr, "PriceSalesVND"), xRow)
            If getColumIndex(spr, "QtyBasic") > -1 Then z3242.QtyBasic = getDataM(spr, getColumIndex(spr, "QtyBasic"), xRow)
            If getColumIndex(spr, "BoxRequestSales") > -1 Then z3242.BoxRequestSales = getDataM(spr, getColumIndex(spr, "BoxRequestSales"), xRow)
            If getColumIndex(spr, "QtyRequestSales") > -1 Then z3242.QtyRequestSales = getDataM(spr, getColumIndex(spr, "QtyRequestSales"), xRow)
            If getColumIndex(spr, "AmtNetRequestSalesUSD") > -1 Then z3242.AmtNetRequestSalesUSD = getDataM(spr, getColumIndex(spr, "AmtNetRequestSalesUSD"), xRow)
            If getColumIndex(spr, "AmtNetRequestSalesVND") > -1 Then z3242.AmtNetRequestSalesVND = getDataM(spr, getColumIndex(spr, "AmtNetRequestSalesVND"), xRow)
            If getColumIndex(spr, "selTaxExport") > -1 Then z3242.selTaxExport = getDataM(spr, getColumIndex(spr, "selTaxExport"), xRow)
            If getColumIndex(spr, "cdTaxExport") > -1 Then z3242.cdTaxExport = getDataM(spr, getColumIndex(spr, "cdTaxExport"), xRow)
            If getColumIndex(spr, "PerTaxExport") > -1 Then z3242.PerTaxExport = getDataM(spr, getColumIndex(spr, "PerTaxExport"), xRow)
            If getColumIndex(spr, "AmtTaxExportRequestSales") > -1 Then z3242.AmtTaxExportRequestSales = getDataM(spr, getColumIndex(spr, "AmtTaxExportRequestSales"), xRow)
            If getColumIndex(spr, "selTaxVat") > -1 Then z3242.selTaxVat = getDataM(spr, getColumIndex(spr, "selTaxVat"), xRow)
            If getColumIndex(spr, "cdTaxVat") > -1 Then z3242.cdTaxVat = getDataM(spr, getColumIndex(spr, "cdTaxVat"), xRow)
            If getColumIndex(spr, "PerTaxVat") > -1 Then z3242.PerTaxVat = getDataM(spr, getColumIndex(spr, "PerTaxVat"), xRow)
            If getColumIndex(spr, "AmtTaxVatRequestSales") > -1 Then z3242.AmtTaxVatRequestSales = getDataM(spr, getColumIndex(spr, "AmtTaxVatRequestSales"), xRow)
            If getColumIndex(spr, "AmtGressRequestSalesUSD") > -1 Then z3242.AmtGressRequestSalesUSD = getDataM(spr, getColumIndex(spr, "AmtGressRequestSalesUSD"), xRow)
            If getColumIndex(spr, "AmtGressRequestSalesVND") > -1 Then z3242.AmtGressRequestSalesVND = getDataM(spr, getColumIndex(spr, "AmtGressRequestSalesVND"), xRow)
            If getColumIndex(spr, "BoxInOutboundWH") > -1 Then z3242.BoxInOutboundWH = getDataM(spr, getColumIndex(spr, "BoxInOutboundWH"), xRow)
            If getColumIndex(spr, "QtyInOutboundWH") > -1 Then z3242.QtyInOutboundWH = getDataM(spr, getColumIndex(spr, "QtyInOutboundWH"), xRow)
            If getColumIndex(spr, "AmtInOutboundWHUSD") > -1 Then z3242.AmtInOutboundWHUSD = getDataM(spr, getColumIndex(spr, "AmtInOutboundWHUSD"), xRow)
            If getColumIndex(spr, "AmtInOutboundWHVND") > -1 Then z3242.AmtInOutboundWHVND = getDataM(spr, getColumIndex(spr, "AmtInOutboundWHVND"), xRow)
            If getColumIndex(spr, "DateDelivery") > -1 Then z3242.DateDelivery = getDataM(spr, getColumIndex(spr, "DateDelivery"), xRow)
            If getColumIndex(spr, "InVoiceNo") > -1 Then z3242.InVoiceNo = getDataM(spr, getColumIndex(spr, "InVoiceNo"), xRow)
            If getColumIndex(spr, "SalesOrderNo") > -1 Then z3242.SalesOrderNo = getDataM(spr, getColumIndex(spr, "SalesOrderNo"), xRow)
            If getColumIndex(spr, "SalesOrderSeq") > -1 Then z3242.SalesOrderSeq = getDataM(spr, getColumIndex(spr, "SalesOrderSeq"), xRow)
            If getColumIndex(spr, "CheckRequestSales") > -1 Then z3242.CheckRequestSales = getDataM(spr, getColumIndex(spr, "CheckRequestSales"), xRow)
            If getColumIndex(spr, "DateRequestSales") > -1 Then z3242.DateRequestSales = getDataM(spr, getColumIndex(spr, "DateRequestSales"), xRow)
            If getColumIndex(spr, "DateApprovalSales") > -1 Then z3242.DateApprovalSales = getDataM(spr, getColumIndex(spr, "DateApprovalSales"), xRow)
            If getColumIndex(spr, "DateCancelSales") > -1 Then z3242.DateCancelSales = getDataM(spr, getColumIndex(spr, "DateCancelSales"), xRow)
            If getColumIndex(spr, "DateCompleteSales") > -1 Then z3242.DateCompleteSales = getDataM(spr, getColumIndex(spr, "DateCompleteSales"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z3242.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K3242_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K3242_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z3242 As T3242_AREA, CheckClear As Boolean, REQUESTSALESNO As String, REQUESTSALESSEQ As Double) As Boolean

        K3242_MOVE = False

        Try
            If READ_PFK3242(REQUESTSALESNO, REQUESTSALESSEQ) = True Then
                z3242 = D3242
                K3242_MOVE = True
            Else
                If CheckClear = True Then z3242 = Nothing
            End If

            If getColumIndex(spr, "RequestSalesNo") > -1 Then z3242.RequestSalesNo = getDataM(spr, getColumIndex(spr, "RequestSalesNo"), xRow)
            If getColumIndex(spr, "RequestSalesSeq") > -1 Then z3242.RequestSalesSeq = getDataM(spr, getColumIndex(spr, "RequestSalesSeq"), xRow)
            If getColumIndex(spr, "Dseq") > -1 Then z3242.Dseq = getDataM(spr, getColumIndex(spr, "Dseq"), xRow)
            If getColumIndex(spr, "MaterialCode") > -1 Then z3242.MaterialCode = getDataM(spr, getColumIndex(spr, "MaterialCode"), xRow)
            If getColumIndex(spr, "selUnitPrice") > -1 Then z3242.selUnitPrice = getDataM(spr, getColumIndex(spr, "selUnitPrice"), xRow)
            If getColumIndex(spr, "cdUnitPrice") > -1 Then z3242.cdUnitPrice = getDataM(spr, getColumIndex(spr, "cdUnitPrice"), xRow)
            If getColumIndex(spr, "PriceSales") > -1 Then z3242.PriceSales = getDataM(spr, getColumIndex(spr, "PriceSales"), xRow)
            If getColumIndex(spr, "PriceSalesUSD") > -1 Then z3242.PriceSalesUSD = getDataM(spr, getColumIndex(spr, "PriceSalesUSD"), xRow)
            If getColumIndex(spr, "PriceSalesVND") > -1 Then z3242.PriceSalesVND = getDataM(spr, getColumIndex(spr, "PriceSalesVND"), xRow)
            If getColumIndex(spr, "QtyBasic") > -1 Then z3242.QtyBasic = getDataM(spr, getColumIndex(spr, "QtyBasic"), xRow)
            If getColumIndex(spr, "BoxRequestSales") > -1 Then z3242.BoxRequestSales = getDataM(spr, getColumIndex(spr, "BoxRequestSales"), xRow)
            If getColumIndex(spr, "QtyRequestSales") > -1 Then z3242.QtyRequestSales = getDataM(spr, getColumIndex(spr, "QtyRequestSales"), xRow)
            If getColumIndex(spr, "AmtNetRequestSalesUSD") > -1 Then z3242.AmtNetRequestSalesUSD = getDataM(spr, getColumIndex(spr, "AmtNetRequestSalesUSD"), xRow)
            If getColumIndex(spr, "AmtNetRequestSalesVND") > -1 Then z3242.AmtNetRequestSalesVND = getDataM(spr, getColumIndex(spr, "AmtNetRequestSalesVND"), xRow)
            If getColumIndex(spr, "selTaxExport") > -1 Then z3242.selTaxExport = getDataM(spr, getColumIndex(spr, "selTaxExport"), xRow)
            If getColumIndex(spr, "cdTaxExport") > -1 Then z3242.cdTaxExport = getDataM(spr, getColumIndex(spr, "cdTaxExport"), xRow)
            If getColumIndex(spr, "PerTaxExport") > -1 Then z3242.PerTaxExport = getDataM(spr, getColumIndex(spr, "PerTaxExport"), xRow)
            If getColumIndex(spr, "AmtTaxExportRequestSales") > -1 Then z3242.AmtTaxExportRequestSales = getDataM(spr, getColumIndex(spr, "AmtTaxExportRequestSales"), xRow)
            If getColumIndex(spr, "selTaxVat") > -1 Then z3242.selTaxVat = getDataM(spr, getColumIndex(spr, "selTaxVat"), xRow)
            If getColumIndex(spr, "cdTaxVat") > -1 Then z3242.cdTaxVat = getDataM(spr, getColumIndex(spr, "cdTaxVat"), xRow)
            If getColumIndex(spr, "PerTaxVat") > -1 Then z3242.PerTaxVat = getDataM(spr, getColumIndex(spr, "PerTaxVat"), xRow)
            If getColumIndex(spr, "AmtTaxVatRequestSales") > -1 Then z3242.AmtTaxVatRequestSales = getDataM(spr, getColumIndex(spr, "AmtTaxVatRequestSales"), xRow)
            If getColumIndex(spr, "AmtGressRequestSalesUSD") > -1 Then z3242.AmtGressRequestSalesUSD = getDataM(spr, getColumIndex(spr, "AmtGressRequestSalesUSD"), xRow)
            If getColumIndex(spr, "AmtGressRequestSalesVND") > -1 Then z3242.AmtGressRequestSalesVND = getDataM(spr, getColumIndex(spr, "AmtGressRequestSalesVND"), xRow)
            If getColumIndex(spr, "BoxInOutboundWH") > -1 Then z3242.BoxInOutboundWH = getDataM(spr, getColumIndex(spr, "BoxInOutboundWH"), xRow)
            If getColumIndex(spr, "QtyInOutboundWH") > -1 Then z3242.QtyInOutboundWH = getDataM(spr, getColumIndex(spr, "QtyInOutboundWH"), xRow)
            If getColumIndex(spr, "AmtInOutboundWHUSD") > -1 Then z3242.AmtInOutboundWHUSD = getDataM(spr, getColumIndex(spr, "AmtInOutboundWHUSD"), xRow)
            If getColumIndex(spr, "AmtInOutboundWHVND") > -1 Then z3242.AmtInOutboundWHVND = getDataM(spr, getColumIndex(spr, "AmtInOutboundWHVND"), xRow)
            If getColumIndex(spr, "DateDelivery") > -1 Then z3242.DateDelivery = getDataM(spr, getColumIndex(spr, "DateDelivery"), xRow)
            If getColumIndex(spr, "InVoiceNo") > -1 Then z3242.InVoiceNo = getDataM(spr, getColumIndex(spr, "InVoiceNo"), xRow)
            If getColumIndex(spr, "SalesOrderNo") > -1 Then z3242.SalesOrderNo = getDataM(spr, getColumIndex(spr, "SalesOrderNo"), xRow)
            If getColumIndex(spr, "SalesOrderSeq") > -1 Then z3242.SalesOrderSeq = getDataM(spr, getColumIndex(spr, "SalesOrderSeq"), xRow)
            If getColumIndex(spr, "CheckRequestSales") > -1 Then z3242.CheckRequestSales = getDataM(spr, getColumIndex(spr, "CheckRequestSales"), xRow)
            If getColumIndex(spr, "DateRequestSales") > -1 Then z3242.DateRequestSales = getDataM(spr, getColumIndex(spr, "DateRequestSales"), xRow)
            If getColumIndex(spr, "DateApprovalSales") > -1 Then z3242.DateApprovalSales = getDataM(spr, getColumIndex(spr, "DateApprovalSales"), xRow)
            If getColumIndex(spr, "DateCancelSales") > -1 Then z3242.DateCancelSales = getDataM(spr, getColumIndex(spr, "DateCancelSales"), xRow)
            If getColumIndex(spr, "DateCompleteSales") > -1 Then z3242.DateCompleteSales = getDataM(spr, getColumIndex(spr, "DateCompleteSales"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z3242.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K3242_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K3242_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z3242 As T3242_AREA, Job As String, REQUESTSALESNO As String, REQUESTSALESSEQ As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K3242_MOVE = False

        Try
            If READ_PFK3242(REQUESTSALESNO, REQUESTSALESSEQ) = True Then
                z3242 = D3242
                K3242_MOVE = True
            Else
                z3242 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3242")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "REQUESTSALESNO" : z3242.RequestSalesNo = Children(i).Code
                                Case "REQUESTSALESSEQ" : z3242.RequestSalesSeq = Children(i).Code
                                Case "DSEQ" : z3242.Dseq = Children(i).Code
                                Case "MATERIALCODE" : z3242.MaterialCode = Children(i).Code
                                Case "SELUNITPRICE" : z3242.selUnitPrice = Children(i).Code
                                Case "CDUNITPRICE" : z3242.cdUnitPrice = Children(i).Code
                                Case "PRICESALES" : z3242.PriceSales = Children(i).Code
                                Case "PRICESALESUSD" : z3242.PriceSalesUSD = Children(i).Code
                                Case "PRICESALESVND" : z3242.PriceSalesVND = Children(i).Code
                                Case "QTYBASIC" : z3242.QtyBasic = Children(i).Code
                                Case "BOXREQUESTSALES" : z3242.BoxRequestSales = Children(i).Code
                                Case "QTYREQUESTSALES" : z3242.QtyRequestSales = Children(i).Code
                                Case "AMTNETREQUESTSALESUSD" : z3242.AmtNetRequestSalesUSD = Children(i).Code
                                Case "AMTNETREQUESTSALESVND" : z3242.AmtNetRequestSalesVND = Children(i).Code
                                Case "SELTAXEXPORT" : z3242.selTaxExport = Children(i).Code
                                Case "CDTAXEXPORT" : z3242.cdTaxExport = Children(i).Code
                                Case "PERTAXEXPORT" : z3242.PerTaxExport = Children(i).Code
                                Case "AMTTAXEXPORTREQUESTSALES" : z3242.AmtTaxExportRequestSales = Children(i).Code
                                Case "SELTAXVAT" : z3242.selTaxVat = Children(i).Code
                                Case "CDTAXVAT" : z3242.cdTaxVat = Children(i).Code
                                Case "PERTAXVAT" : z3242.PerTaxVat = Children(i).Code
                                Case "AMTTAXVATREQUESTSALES" : z3242.AmtTaxVatRequestSales = Children(i).Code
                                Case "AMTGRESSREQUESTSALESUSD" : z3242.AmtGressRequestSalesUSD = Children(i).Code
                                Case "AMTGRESSREQUESTSALESVND" : z3242.AmtGressRequestSalesVND = Children(i).Code
                                Case "BOXINOUTBOUNDWH" : z3242.BoxInOutboundWH = Children(i).Code
                                Case "QTYINOUTBOUNDWH" : z3242.QtyInOutboundWH = Children(i).Code
                                Case "AMTINOUTBOUNDWHUSD" : z3242.AmtInOutboundWHUSD = Children(i).Code
                                Case "AMTINOUTBOUNDWHVND" : z3242.AmtInOutboundWHVND = Children(i).Code
                                Case "DATEDELIVERY" : z3242.DateDelivery = Children(i).Code
                                Case "INVOICENO" : z3242.InVoiceNo = Children(i).Code
                                Case "SALESORDERNO" : z3242.SalesOrderNo = Children(i).Code
                                Case "SALESORDERSEQ" : z3242.SalesOrderSeq = Children(i).Code
                                Case "CHECKREQUESTSALES" : z3242.CheckRequestSales = Children(i).Code
                                Case "DATEREQUESTSALES" : z3242.DateRequestSales = Children(i).Code
                                Case "DATEAPPROVALSALES" : z3242.DateApprovalSales = Children(i).Code
                                Case "DATECANCELSALES" : z3242.DateCancelSales = Children(i).Code
                                Case "DATECOMPLETESALES" : z3242.DateCompleteSales = Children(i).Code
                                Case "REMARK" : z3242.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "REQUESTSALESNO" : z3242.RequestSalesNo = Children(i).Data
                                Case "REQUESTSALESSEQ" : z3242.RequestSalesSeq = Children(i).Data
                                Case "DSEQ" : z3242.Dseq = Children(i).Data
                                Case "MATERIALCODE" : z3242.MaterialCode = Children(i).Data
                                Case "SELUNITPRICE" : z3242.selUnitPrice = Children(i).Data
                                Case "CDUNITPRICE" : z3242.cdUnitPrice = Children(i).Data
                                Case "PRICESALES" : z3242.PriceSales = Children(i).Data
                                Case "PRICESALESUSD" : z3242.PriceSalesUSD = Children(i).Data
                                Case "PRICESALESVND" : z3242.PriceSalesVND = Children(i).Data
                                Case "QTYBASIC" : z3242.QtyBasic = Children(i).Data
                                Case "BOXREQUESTSALES" : z3242.BoxRequestSales = Children(i).Data
                                Case "QTYREQUESTSALES" : z3242.QtyRequestSales = Children(i).Data
                                Case "AMTNETREQUESTSALESUSD" : z3242.AmtNetRequestSalesUSD = Children(i).Data
                                Case "AMTNETREQUESTSALESVND" : z3242.AmtNetRequestSalesVND = Children(i).Data
                                Case "SELTAXEXPORT" : z3242.selTaxExport = Children(i).Data
                                Case "CDTAXEXPORT" : z3242.cdTaxExport = Children(i).Data
                                Case "PERTAXEXPORT" : z3242.PerTaxExport = Children(i).Data
                                Case "AMTTAXEXPORTREQUESTSALES" : z3242.AmtTaxExportRequestSales = Children(i).Data
                                Case "SELTAXVAT" : z3242.selTaxVat = Children(i).Data
                                Case "CDTAXVAT" : z3242.cdTaxVat = Children(i).Data
                                Case "PERTAXVAT" : z3242.PerTaxVat = Children(i).Data
                                Case "AMTTAXVATREQUESTSALES" : z3242.AmtTaxVatRequestSales = Children(i).Data
                                Case "AMTGRESSREQUESTSALESUSD" : z3242.AmtGressRequestSalesUSD = Children(i).Data
                                Case "AMTGRESSREQUESTSALESVND" : z3242.AmtGressRequestSalesVND = Children(i).Data
                                Case "BOXINOUTBOUNDWH" : z3242.BoxInOutboundWH = Children(i).Data
                                Case "QTYINOUTBOUNDWH" : z3242.QtyInOutboundWH = Children(i).Data
                                Case "AMTINOUTBOUNDWHUSD" : z3242.AmtInOutboundWHUSD = Children(i).Data
                                Case "AMTINOUTBOUNDWHVND" : z3242.AmtInOutboundWHVND = Children(i).Data
                                Case "DATEDELIVERY" : z3242.DateDelivery = Children(i).Data
                                Case "INVOICENO" : z3242.InVoiceNo = Children(i).Data
                                Case "SALESORDERNO" : z3242.SalesOrderNo = Children(i).Data
                                Case "SALESORDERSEQ" : z3242.SalesOrderSeq = Children(i).Data
                                Case "CHECKREQUESTSALES" : z3242.CheckRequestSales = Children(i).Data
                                Case "DATEREQUESTSALES" : z3242.DateRequestSales = Children(i).Data
                                Case "DATEAPPROVALSALES" : z3242.DateApprovalSales = Children(i).Data
                                Case "DATECANCELSALES" : z3242.DateCancelSales = Children(i).Data
                                Case "DATECOMPLETESALES" : z3242.DateCompleteSales = Children(i).Data
                                Case "REMARK" : z3242.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K3242_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K3242_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z3242 As T3242_AREA, Job As String, CheckClear As Boolean, REQUESTSALESNO As String, REQUESTSALESSEQ As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K3242_MOVE = False

        Try
            If READ_PFK3242(REQUESTSALESNO, REQUESTSALESSEQ) = True Then
                z3242 = D3242
                K3242_MOVE = True
            Else
                If CheckClear = True Then z3242 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3242")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "REQUESTSALESNO" : z3242.RequestSalesNo = Children(i).Code
                                Case "REQUESTSALESSEQ" : z3242.RequestSalesSeq = Children(i).Code
                                Case "DSEQ" : z3242.Dseq = Children(i).Code
                                Case "MATERIALCODE" : z3242.MaterialCode = Children(i).Code
                                Case "SELUNITPRICE" : z3242.selUnitPrice = Children(i).Code
                                Case "CDUNITPRICE" : z3242.cdUnitPrice = Children(i).Code
                                Case "PRICESALES" : z3242.PriceSales = Children(i).Code
                                Case "PRICESALESUSD" : z3242.PriceSalesUSD = Children(i).Code
                                Case "PRICESALESVND" : z3242.PriceSalesVND = Children(i).Code
                                Case "QTYBASIC" : z3242.QtyBasic = Children(i).Code
                                Case "BOXREQUESTSALES" : z3242.BoxRequestSales = Children(i).Code
                                Case "QTYREQUESTSALES" : z3242.QtyRequestSales = Children(i).Code
                                Case "AMTNETREQUESTSALESUSD" : z3242.AmtNetRequestSalesUSD = Children(i).Code
                                Case "AMTNETREQUESTSALESVND" : z3242.AmtNetRequestSalesVND = Children(i).Code
                                Case "SELTAXEXPORT" : z3242.selTaxExport = Children(i).Code
                                Case "CDTAXEXPORT" : z3242.cdTaxExport = Children(i).Code
                                Case "PERTAXEXPORT" : z3242.PerTaxExport = Children(i).Code
                                Case "AMTTAXEXPORTREQUESTSALES" : z3242.AmtTaxExportRequestSales = Children(i).Code
                                Case "SELTAXVAT" : z3242.selTaxVat = Children(i).Code
                                Case "CDTAXVAT" : z3242.cdTaxVat = Children(i).Code
                                Case "PERTAXVAT" : z3242.PerTaxVat = Children(i).Code
                                Case "AMTTAXVATREQUESTSALES" : z3242.AmtTaxVatRequestSales = Children(i).Code
                                Case "AMTGRESSREQUESTSALESUSD" : z3242.AmtGressRequestSalesUSD = Children(i).Code
                                Case "AMTGRESSREQUESTSALESVND" : z3242.AmtGressRequestSalesVND = Children(i).Code
                                Case "BOXINOUTBOUNDWH" : z3242.BoxInOutboundWH = Children(i).Code
                                Case "QTYINOUTBOUNDWH" : z3242.QtyInOutboundWH = Children(i).Code
                                Case "AMTINOUTBOUNDWHUSD" : z3242.AmtInOutboundWHUSD = Children(i).Code
                                Case "AMTINOUTBOUNDWHVND" : z3242.AmtInOutboundWHVND = Children(i).Code
                                Case "DATEDELIVERY" : z3242.DateDelivery = Children(i).Code
                                Case "INVOICENO" : z3242.InVoiceNo = Children(i).Code
                                Case "SALESORDERNO" : z3242.SalesOrderNo = Children(i).Code
                                Case "SALESORDERSEQ" : z3242.SalesOrderSeq = Children(i).Code
                                Case "CHECKREQUESTSALES" : z3242.CheckRequestSales = Children(i).Code
                                Case "DATEREQUESTSALES" : z3242.DateRequestSales = Children(i).Code
                                Case "DATEAPPROVALSALES" : z3242.DateApprovalSales = Children(i).Code
                                Case "DATECANCELSALES" : z3242.DateCancelSales = Children(i).Code
                                Case "DATECOMPLETESALES" : z3242.DateCompleteSales = Children(i).Code
                                Case "REMARK" : z3242.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "REQUESTSALESNO" : z3242.RequestSalesNo = Children(i).Data
                                Case "REQUESTSALESSEQ" : z3242.RequestSalesSeq = Children(i).Data
                                Case "DSEQ" : z3242.Dseq = Children(i).Data
                                Case "MATERIALCODE" : z3242.MaterialCode = Children(i).Data
                                Case "SELUNITPRICE" : z3242.selUnitPrice = Children(i).Data
                                Case "CDUNITPRICE" : z3242.cdUnitPrice = Children(i).Data
                                Case "PRICESALES" : z3242.PriceSales = Children(i).Data
                                Case "PRICESALESUSD" : z3242.PriceSalesUSD = Children(i).Data
                                Case "PRICESALESVND" : z3242.PriceSalesVND = Children(i).Data
                                Case "QTYBASIC" : z3242.QtyBasic = Children(i).Data
                                Case "BOXREQUESTSALES" : z3242.BoxRequestSales = Children(i).Data
                                Case "QTYREQUESTSALES" : z3242.QtyRequestSales = Children(i).Data
                                Case "AMTNETREQUESTSALESUSD" : z3242.AmtNetRequestSalesUSD = Children(i).Data
                                Case "AMTNETREQUESTSALESVND" : z3242.AmtNetRequestSalesVND = Children(i).Data
                                Case "SELTAXEXPORT" : z3242.selTaxExport = Children(i).Data
                                Case "CDTAXEXPORT" : z3242.cdTaxExport = Children(i).Data
                                Case "PERTAXEXPORT" : z3242.PerTaxExport = Children(i).Data
                                Case "AMTTAXEXPORTREQUESTSALES" : z3242.AmtTaxExportRequestSales = Children(i).Data
                                Case "SELTAXVAT" : z3242.selTaxVat = Children(i).Data
                                Case "CDTAXVAT" : z3242.cdTaxVat = Children(i).Data
                                Case "PERTAXVAT" : z3242.PerTaxVat = Children(i).Data
                                Case "AMTTAXVATREQUESTSALES" : z3242.AmtTaxVatRequestSales = Children(i).Data
                                Case "AMTGRESSREQUESTSALESUSD" : z3242.AmtGressRequestSalesUSD = Children(i).Data
                                Case "AMTGRESSREQUESTSALESVND" : z3242.AmtGressRequestSalesVND = Children(i).Data
                                Case "BOXINOUTBOUNDWH" : z3242.BoxInOutboundWH = Children(i).Data
                                Case "QTYINOUTBOUNDWH" : z3242.QtyInOutboundWH = Children(i).Data
                                Case "AMTINOUTBOUNDWHUSD" : z3242.AmtInOutboundWHUSD = Children(i).Data
                                Case "AMTINOUTBOUNDWHVND" : z3242.AmtInOutboundWHVND = Children(i).Data
                                Case "DATEDELIVERY" : z3242.DateDelivery = Children(i).Data
                                Case "INVOICENO" : z3242.InVoiceNo = Children(i).Data
                                Case "SALESORDERNO" : z3242.SalesOrderNo = Children(i).Data
                                Case "SALESORDERSEQ" : z3242.SalesOrderSeq = Children(i).Data
                                Case "CHECKREQUESTSALES" : z3242.CheckRequestSales = Children(i).Data
                                Case "DATEREQUESTSALES" : z3242.DateRequestSales = Children(i).Data
                                Case "DATEAPPROVALSALES" : z3242.DateApprovalSales = Children(i).Data
                                Case "DATECANCELSALES" : z3242.DateCancelSales = Children(i).Data
                                Case "DATECOMPLETESALES" : z3242.DateCompleteSales = Children(i).Data
                                Case "REMARK" : z3242.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K3242_MOVE", vbCritical)
        End Try
    End Function

End Module
