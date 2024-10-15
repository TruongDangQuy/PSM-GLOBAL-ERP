'=========================================================================================================================================================
'   TABLE : (PFK3441)
'
'      WORKER : PSM GLOBAL ., LTD
'       WORK DATE : 2019 NEW
'       DEVELOPER    : MRNLV
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K3441

    Structure T3441_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public InvoiceNo As String  '			char(9)		*
        Public InvoiceSeq As String  '			char(4)		*
        Public SONo As String  '			nvarchar(50)
        Public BookingNo As String  '			nvarchar(50)
        Public LoadingNo As String  '			nvarchar(50)
        Public VesselName As String  '			nvarchar(50)
        Public TradingName As String  '			nvarchar(1000)
        Public TradingCode As String  '			nvarchar(200)
        Public ShipmentType As String  '			nvarchar(50)
        Public DateBL As String  '			nvarchar(50)
        Public BLNo As String  '			nvarchar(200)
        Public ContainerNo As String  '			nvarchar(200)
        Public seShipType As String  '			char(3)
        Public cdShipType As String  '			char(3)
        Public DateEXFac As String  '			nvarchar(50)
        Public DateETD As String  '			nvarchar(50)
        Public DateETA As String  '			nvarchar(50)
        Public OrderNo As String  '			char(9)
        Public OrderNoSeq As String  '			char(3)
        Public LoadingCode As String  '			char(6)
        Public TransferType As String  '			char(1)
        Public ChkDeclare As String  '			nvarchar(50)
        Public DateDeclare As String  '			nvarchar(50)
        Public ChkSMDocs As String  '			nvarchar(50)
        Public DateSMDocs As String  '			nvarchar(50)
        Public ChkLocalCharge As String  '			nvarchar(50)
        Public DateLocalCharge As String  '			nvarchar(50)
        Public ChkUploadDocs As String  '			nvarchar(50)
        Public DateUploadDocs As String  '			nvarchar(50)
        Public ChkDocsHK As String  '			nvarchar(50)
        Public DateDocsHK As String  '			nvarchar(50)
        Public ChkDocsBuyer As String  '			nvarchar(50)
        Public ChkReceiveHK As String  '			nvarchar(50)
        Public ChkPending As String  '			nvarchar(50)
        Public DateDocsBuyer As String  '			nvarchar(50)
        Public CheckStatus As Long    '			int
        Public QtyOrder As Double  '			decimal
        Public QtyOrderSample As Double  '			decimal
        Public PriceOrderFOB As Double  '			decimal
        Public TotalAMTFOB As Double  '			decimal
        Public PriceOrder As Double  '			decimal
        Public TotalAMT As Double  '			decimal
        Public TotalGW As Double  '			decimal
        Public TotalNW As Double  '			decimal
        Public TotalCBM As Double  '			decimal
        Public TotalQty As Double  '			decimal
        Public TotalCnt As Double  '			decimal
        Public ContName1 As String  '			nvarchar(50)
        Public ContName2 As String  '			nvarchar(50)
        Public ContName3 As String  '			nvarchar(50)
        Public ContName4 As String  '			nvarchar(50)
        Public ContName5 As String  '			nvarchar(50)
        Public ContName6 As String  '			nvarchar(50)
        Public ContName7 As String  '			nvarchar(50)
        Public ContName8 As String  '			nvarchar(50)
        Public ContName9 As String  '			nvarchar(50)
        Public ContName10 As String  '			nvarchar(50)
        Public QtyPL1 As Double  '			decimal
        Public QtyPL2 As Double  '			decimal
        Public QtyPL3 As Double  '			decimal
        Public QtyPL4 As Double  '			decimal
        Public QtyPL5 As Double  '			decimal
        Public QtyPL6 As Double  '			decimal
        Public QtyPL7 As Double  '			decimal
        Public QtyPL8 As Double  '			decimal
        Public QtyPL9 As Double  '			decimal
        Public QtyPL10 As Double  '			decimal
        Public seSite As String  '			char(3)
        Public cdSite As String  '			char(3)
        Public Remark As String  '			nvarchar(500)
        Public TimeInsert As String  '			char(14)
        Public TimeUpdate As String  '			char(14)
        Public DateUpdate As String  '			char(8)
        Public DateInsert As String  '			char(8)
        Public InchargeInsert As String  '			char(8)
        Public InchargeUpdate As String  '			char(8)
        '=========================================================================================================================================================
    End Structure

    Public D3441 As T3441_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK3441(INVOICENO As String, INVOICESEQ As String) As Boolean
        READ_PFK3441 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK3441 "
            SQL = SQL & " WHERE K3441_InvoiceNo		 = '" & InvoiceNo & "' "
            SQL = SQL & "   AND K3441_InvoiceSeq		 = '" & InvoiceSeq & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D3441_CLEAR() : GoTo SKIP_READ_PFK3441

            Call K3441_MOVE(rd)
            READ_PFK3441 = True

SKIP_READ_PFK3441:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK3441", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK3441(INVOICENO As String, INVOICESEQ As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK3441 "
            SQL = SQL & " WHERE K3441_InvoiceNo		 = '" & InvoiceNo & "' "
            SQL = SQL & "   AND K3441_InvoiceSeq		 = '" & InvoiceSeq & "' "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK3441", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK3441(z3441 As T3441_AREA) As Boolean
        WRITE_PFK3441 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z3441)

            SQL = " INSERT INTO PFK3441 "
            SQL = SQL & " ( "
            SQL = SQL & " K3441_InvoiceNo,"
            SQL = SQL & " K3441_InvoiceSeq,"
            SQL = SQL & " K3441_SONo,"
            SQL = SQL & " K3441_BookingNo,"
            SQL = SQL & " K3441_LoadingNo,"
            SQL = SQL & " K3441_VesselName,"
            SQL = SQL & " K3441_TradingName,"
            SQL = SQL & " K3441_TradingCode,"
            SQL = SQL & " K3441_ShipmentType,"
            SQL = SQL & " K3441_DateBL,"
            SQL = SQL & " K3441_BLNo,"
            SQL = SQL & " K3441_ContainerNo,"
            SQL = SQL & " K3441_seShipType,"
            SQL = SQL & " K3441_cdShipType,"
            SQL = SQL & " K3441_DateEXFac,"
            SQL = SQL & " K3441_DateETD,"
            SQL = SQL & " K3441_DateETA,"
            SQL = SQL & " K3441_OrderNo,"
            SQL = SQL & " K3441_OrderNoSeq,"
            SQL = SQL & " K3441_LoadingCode,"
            SQL = SQL & " K3441_TransferType,"
            SQL = SQL & " K3441_ChkDeclare,"
            SQL = SQL & " K3441_DateDeclare,"
            SQL = SQL & " K3441_ChkSMDocs,"
            SQL = SQL & " K3441_DateSMDocs,"
            SQL = SQL & " K3441_ChkLocalCharge,"
            SQL = SQL & " K3441_DateLocalCharge,"
            SQL = SQL & " K3441_ChkUploadDocs,"
            SQL = SQL & " K3441_DateUploadDocs,"
            SQL = SQL & " K3441_ChkDocsHK,"
            SQL = SQL & " K3441_DateDocsHK,"
            SQL = SQL & " K3441_ChkDocsBuyer,"
            SQL = SQL & " K3441_ChkReceiveHK,"
            SQL = SQL & " K3441_ChkPending,"
            SQL = SQL & " K3441_DateDocsBuyer,"
            SQL = SQL & " K3441_CheckStatus,"
            SQL = SQL & " K3441_QtyOrder,"
            SQL = SQL & " K3441_QtyOrderSample,"
            SQL = SQL & " K3441_PriceOrderFOB,"
            SQL = SQL & " K3441_TotalAMTFOB,"
            SQL = SQL & " K3441_PriceOrder,"
            SQL = SQL & " K3441_TotalAMT,"
            SQL = SQL & " K3441_TotalGW,"
            SQL = SQL & " K3441_TotalNW,"
            SQL = SQL & " K3441_TotalCBM,"
            SQL = SQL & " K3441_TotalQty,"
            SQL = SQL & " K3441_TotalCnt,"
            SQL = SQL & " K3441_ContName1,"
            SQL = SQL & " K3441_ContName2,"
            SQL = SQL & " K3441_ContName3,"
            SQL = SQL & " K3441_ContName4,"
            SQL = SQL & " K3441_ContName5,"
            SQL = SQL & " K3441_ContName6,"
            SQL = SQL & " K3441_ContName7,"
            SQL = SQL & " K3441_ContName8,"
            SQL = SQL & " K3441_ContName9,"
            SQL = SQL & " K3441_ContName10,"
            SQL = SQL & " K3441_QtyPL1,"
            SQL = SQL & " K3441_QtyPL2,"
            SQL = SQL & " K3441_QtyPL3,"
            SQL = SQL & " K3441_QtyPL4,"
            SQL = SQL & " K3441_QtyPL5,"
            SQL = SQL & " K3441_QtyPL6,"
            SQL = SQL & " K3441_QtyPL7,"
            SQL = SQL & " K3441_QtyPL8,"
            SQL = SQL & " K3441_QtyPL9,"
            SQL = SQL & " K3441_QtyPL10,"
            SQL = SQL & " K3441_seSite,"
            SQL = SQL & " K3441_cdSite,"
            SQL = SQL & " K3441_Remark,"
            SQL = SQL & " K3441_TimeInsert,"
            SQL = SQL & " K3441_TimeUpdate,"
            SQL = SQL & " K3441_DateUpdate,"
            SQL = SQL & " K3441_DateInsert,"
            SQL = SQL & " K3441_InchargeInsert,"
            SQL = SQL & " K3441_InchargeUpdate "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z3441.InvoiceNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3441.InvoiceSeq) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3441.SONo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3441.BookingNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3441.LoadingNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3441.VesselName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3441.TradingName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3441.TradingCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3441.ShipmentType) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3441.DateBL) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3441.BLNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3441.ContainerNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3441.seShipType) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3441.cdShipType) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3441.DateEXFac) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3441.DateETD) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3441.DateETA) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3441.OrderNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3441.OrderNoSeq) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3441.LoadingCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3441.TransferType) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3441.ChkDeclare) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3441.DateDeclare) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3441.ChkSMDocs) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3441.DateSMDocs) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3441.ChkLocalCharge) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3441.DateLocalCharge) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3441.ChkUploadDocs) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3441.DateUploadDocs) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3441.ChkDocsHK) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3441.DateDocsHK) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3441.ChkDocsBuyer) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3441.ChkReceiveHK) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3441.ChkPending) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3441.DateDocsBuyer) & "', "
            SQL = SQL & "   " & FormatSQL(z3441.CheckStatus) & ", "
            SQL = SQL & "   " & FormatSQL(z3441.QtyOrder) & ", "
            SQL = SQL & "   " & FormatSQL(z3441.QtyOrderSample) & ", "
            SQL = SQL & "   " & FormatSQL(z3441.PriceOrderFOB) & ", "
            SQL = SQL & "   " & FormatSQL(z3441.TotalAMTFOB) & ", "
            SQL = SQL & "   " & FormatSQL(z3441.PriceOrder) & ", "
            SQL = SQL & "   " & FormatSQL(z3441.TotalAMT) & ", "
            SQL = SQL & "   " & FormatSQL(z3441.TotalGW) & ", "
            SQL = SQL & "   " & FormatSQL(z3441.TotalNW) & ", "
            SQL = SQL & "   " & FormatSQL(z3441.TotalCBM) & ", "
            SQL = SQL & "   " & FormatSQL(z3441.TotalQty) & ", "
            SQL = SQL & "   " & FormatSQL(z3441.TotalCnt) & ", "
            SQL = SQL & "  N'" & FormatSQL(z3441.ContName1) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3441.ContName2) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3441.ContName3) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3441.ContName4) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3441.ContName5) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3441.ContName6) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3441.ContName7) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3441.ContName8) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3441.ContName9) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3441.ContName10) & "', "
            SQL = SQL & "   " & FormatSQL(z3441.QtyPL1) & ", "
            SQL = SQL & "   " & FormatSQL(z3441.QtyPL2) & ", "
            SQL = SQL & "   " & FormatSQL(z3441.QtyPL3) & ", "
            SQL = SQL & "   " & FormatSQL(z3441.QtyPL4) & ", "
            SQL = SQL & "   " & FormatSQL(z3441.QtyPL5) & ", "
            SQL = SQL & "   " & FormatSQL(z3441.QtyPL6) & ", "
            SQL = SQL & "   " & FormatSQL(z3441.QtyPL7) & ", "
            SQL = SQL & "   " & FormatSQL(z3441.QtyPL8) & ", "
            SQL = SQL & "   " & FormatSQL(z3441.QtyPL9) & ", "
            SQL = SQL & "   " & FormatSQL(z3441.QtyPL10) & ", "
            SQL = SQL & "  N'" & FormatSQL(z3441.seSite) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3441.cdSite) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3441.Remark) & "', "
            SQL = SQL & "  N'" & FormatSQL(PUB.TIME) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3441.TimeUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3441.DateUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(PUB.DAT) & "', "
            SQL = SQL & "  N'" & FormatSQL(PUB.SAW) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3441.InchargeUpdate) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK3441 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK3441", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK3441(z3441 As T3441_AREA) As Boolean
        REWRITE_PFK3441 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z3441)

            SQL = " UPDATE PFK3441 SET "
            SQL = SQL & "    K3441_SONo      = N'" & FormatSQL(z3441.SONo) & "', "
            SQL = SQL & "    K3441_BookingNo      = N'" & FormatSQL(z3441.BookingNo) & "', "
            SQL = SQL & "    K3441_LoadingNo      = N'" & FormatSQL(z3441.LoadingNo) & "', "
            SQL = SQL & "    K3441_VesselName      = N'" & FormatSQL(z3441.VesselName) & "', "
            SQL = SQL & "    K3441_TradingName      = N'" & FormatSQL(z3441.TradingName) & "', "
            SQL = SQL & "    K3441_TradingCode      = N'" & FormatSQL(z3441.TradingCode) & "', "
            SQL = SQL & "    K3441_ShipmentType      = N'" & FormatSQL(z3441.ShipmentType) & "', "
            SQL = SQL & "    K3441_DateBL      = N'" & FormatSQL(z3441.DateBL) & "', "
            SQL = SQL & "    K3441_BLNo      = N'" & FormatSQL(z3441.BLNo) & "', "
            SQL = SQL & "    K3441_ContainerNo      = N'" & FormatSQL(z3441.ContainerNo) & "', "
            SQL = SQL & "    K3441_seShipType      = N'" & FormatSQL(z3441.seShipType) & "', "
            SQL = SQL & "    K3441_cdShipType      = N'" & FormatSQL(z3441.cdShipType) & "', "
            SQL = SQL & "    K3441_DateEXFac      = N'" & FormatSQL(z3441.DateEXFac) & "', "
            SQL = SQL & "    K3441_DateETD      = N'" & FormatSQL(z3441.DateETD) & "', "
            SQL = SQL & "    K3441_DateETA      = N'" & FormatSQL(z3441.DateETA) & "', "
            SQL = SQL & "    K3441_OrderNo      = N'" & FormatSQL(z3441.OrderNo) & "', "
            SQL = SQL & "    K3441_OrderNoSeq      = N'" & FormatSQL(z3441.OrderNoSeq) & "', "
            SQL = SQL & "    K3441_LoadingCode      = N'" & FormatSQL(z3441.LoadingCode) & "', "
            SQL = SQL & "    K3441_TransferType      = N'" & FormatSQL(z3441.TransferType) & "', "
            SQL = SQL & "    K3441_ChkDeclare      = N'" & FormatSQL(z3441.ChkDeclare) & "', "
            SQL = SQL & "    K3441_DateDeclare      = N'" & FormatSQL(z3441.DateDeclare) & "', "
            SQL = SQL & "    K3441_ChkSMDocs      = N'" & FormatSQL(z3441.ChkSMDocs) & "', "
            SQL = SQL & "    K3441_DateSMDocs      = N'" & FormatSQL(z3441.DateSMDocs) & "', "
            SQL = SQL & "    K3441_ChkLocalCharge      = N'" & FormatSQL(z3441.ChkLocalCharge) & "', "
            SQL = SQL & "    K3441_DateLocalCharge      = N'" & FormatSQL(z3441.DateLocalCharge) & "', "
            SQL = SQL & "    K3441_ChkUploadDocs      = N'" & FormatSQL(z3441.ChkUploadDocs) & "', "
            SQL = SQL & "    K3441_DateUploadDocs      = N'" & FormatSQL(z3441.DateUploadDocs) & "', "
            SQL = SQL & "    K3441_ChkDocsHK      = N'" & FormatSQL(z3441.ChkDocsHK) & "', "
            SQL = SQL & "    K3441_DateDocsHK      = N'" & FormatSQL(z3441.DateDocsHK) & "', "
            SQL = SQL & "    K3441_ChkDocsBuyer      = N'" & FormatSQL(z3441.ChkDocsBuyer) & "', "
            SQL = SQL & "    K3441_ChkReceiveHK      = N'" & FormatSQL(z3441.ChkReceiveHK) & "', "
            SQL = SQL & "    K3441_ChkPending      = N'" & FormatSQL(z3441.ChkPending) & "', "
            SQL = SQL & "    K3441_DateDocsBuyer      = N'" & FormatSQL(z3441.DateDocsBuyer) & "', "
            SQL = SQL & "    K3441_CheckStatus      =  " & FormatSQL(z3441.CheckStatus) & ", "
            SQL = SQL & "    K3441_QtyOrder      =  " & FormatSQL(z3441.QtyOrder) & ", "
            SQL = SQL & "    K3441_QtyOrderSample      =  " & FormatSQL(z3441.QtyOrderSample) & ", "
            SQL = SQL & "    K3441_PriceOrderFOB      =  " & FormatSQL(z3441.PriceOrderFOB) & ", "
            SQL = SQL & "    K3441_TotalAMTFOB      =  " & FormatSQL(z3441.TotalAMTFOB) & ", "
            SQL = SQL & "    K3441_PriceOrder      =  " & FormatSQL(z3441.PriceOrder) & ", "
            SQL = SQL & "    K3441_TotalAMT      =  " & FormatSQL(z3441.TotalAMT) & ", "
            SQL = SQL & "    K3441_TotalGW      =  " & FormatSQL(z3441.TotalGW) & ", "
            SQL = SQL & "    K3441_TotalNW      =  " & FormatSQL(z3441.TotalNW) & ", "
            SQL = SQL & "    K3441_TotalCBM      =  " & FormatSQL(z3441.TotalCBM) & ", "
            SQL = SQL & "    K3441_TotalQty      =  " & FormatSQL(z3441.TotalQty) & ", "
            SQL = SQL & "    K3441_TotalCnt      =  " & FormatSQL(z3441.TotalCnt) & ", "
            SQL = SQL & "    K3441_ContName1      = N'" & FormatSQL(z3441.ContName1) & "', "
            SQL = SQL & "    K3441_ContName2      = N'" & FormatSQL(z3441.ContName2) & "', "
            SQL = SQL & "    K3441_ContName3      = N'" & FormatSQL(z3441.ContName3) & "', "
            SQL = SQL & "    K3441_ContName4      = N'" & FormatSQL(z3441.ContName4) & "', "
            SQL = SQL & "    K3441_ContName5      = N'" & FormatSQL(z3441.ContName5) & "', "
            SQL = SQL & "    K3441_ContName6      = N'" & FormatSQL(z3441.ContName6) & "', "
            SQL = SQL & "    K3441_ContName7      = N'" & FormatSQL(z3441.ContName7) & "', "
            SQL = SQL & "    K3441_ContName8      = N'" & FormatSQL(z3441.ContName8) & "', "
            SQL = SQL & "    K3441_ContName9      = N'" & FormatSQL(z3441.ContName9) & "', "
            SQL = SQL & "    K3441_ContName10      = N'" & FormatSQL(z3441.ContName10) & "', "
            SQL = SQL & "    K3441_QtyPL1      =  " & FormatSQL(z3441.QtyPL1) & ", "
            SQL = SQL & "    K3441_QtyPL2      =  " & FormatSQL(z3441.QtyPL2) & ", "
            SQL = SQL & "    K3441_QtyPL3      =  " & FormatSQL(z3441.QtyPL3) & ", "
            SQL = SQL & "    K3441_QtyPL4      =  " & FormatSQL(z3441.QtyPL4) & ", "
            SQL = SQL & "    K3441_QtyPL5      =  " & FormatSQL(z3441.QtyPL5) & ", "
            SQL = SQL & "    K3441_QtyPL6      =  " & FormatSQL(z3441.QtyPL6) & ", "
            SQL = SQL & "    K3441_QtyPL7      =  " & FormatSQL(z3441.QtyPL7) & ", "
            SQL = SQL & "    K3441_QtyPL8      =  " & FormatSQL(z3441.QtyPL8) & ", "
            SQL = SQL & "    K3441_QtyPL9      =  " & FormatSQL(z3441.QtyPL9) & ", "
            SQL = SQL & "    K3441_QtyPL10      =  " & FormatSQL(z3441.QtyPL10) & ", "
            SQL = SQL & "    K3441_seSite      = N'" & FormatSQL(z3441.seSite) & "', "
            SQL = SQL & "    K3441_cdSite      = N'" & FormatSQL(z3441.cdSite) & "', "
            SQL = SQL & "    K3441_Remark      = N'" & FormatSQL(z3441.Remark) & "', "
            SQL = SQL & "    K3441_TimeInsert      = N'" & FormatSQL(z3441.TimeInsert) & "', "
            SQL = SQL & "    K3441_TimeUpdate      = N'" & FormatSQL(PUB.TIME) & "', "
            SQL = SQL & "    K3441_DateUpdate      = N'" & FormatSQL(PUB.DAT) & "', "
            SQL = SQL & "    K3441_DateInsert      = N'" & FormatSQL(z3441.DateInsert) & "', "
            SQL = SQL & "    K3441_InchargeInsert      = N'" & FormatSQL(z3441.InchargeInsert) & "', "
            SQL = SQL & "    K3441_InchargeUpdate      = N'" & FormatSQL(PUB.SAW) & "'  "
            SQL = SQL & " WHERE K3441_InvoiceNo		 = '" & z3441.InvoiceNo & "' "
            SQL = SQL & "   AND K3441_InvoiceSeq		 = '" & z3441.InvoiceSeq & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()


            REWRITE_PFK3441 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK3441", vbCritical)

        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK3441(z3441 As T3441_AREA) As Boolean
        DELETE_PFK3441 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z3441)

            SQL = " DELETE FROM PFK3441  "
            SQL = SQL & " WHERE K3441_InvoiceNo		 = '" & z3441.InvoiceNo & "' "
            SQL = SQL & "   AND K3441_InvoiceSeq		 = '" & z3441.InvoiceSeq & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK3441 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK3441", vbCritical)
        Finally
            Call GetFullInformation("PFK3441", "D", SQL)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D3441_CLEAR()
        Try

            D3441.InvoiceNo = ""
            D3441.InvoiceSeq = ""
            D3441.SONo = ""
            D3441.BookingNo = ""
            D3441.LoadingNo = ""
            D3441.VesselName = ""
            D3441.TradingName = ""
            D3441.TradingCode = ""
            D3441.ShipmentType = ""
            D3441.DateBL = ""
            D3441.BLNo = ""
            D3441.ContainerNo = ""
            D3441.seShipType = ""
            D3441.cdShipType = ""
            D3441.DateEXFac = ""
            D3441.DateETD = ""
            D3441.DateETA = ""
            D3441.OrderNo = ""
            D3441.OrderNoSeq = ""
            D3441.LoadingCode = ""
            D3441.TransferType = ""
            D3441.ChkDeclare = ""
            D3441.DateDeclare = ""
            D3441.ChkSMDocs = ""
            D3441.DateSMDocs = ""
            D3441.ChkLocalCharge = ""
            D3441.DateLocalCharge = ""
            D3441.ChkUploadDocs = ""
            D3441.DateUploadDocs = ""
            D3441.ChkDocsHK = ""
            D3441.DateDocsHK = ""
            D3441.ChkDocsBuyer = ""
            D3441.ChkReceiveHK = ""
            D3441.ChkPending = ""
            D3441.DateDocsBuyer = ""
            D3441.CheckStatus = 0
            D3441.QtyOrder = 0
            D3441.QtyOrderSample = 0
            D3441.PriceOrderFOB = 0
            D3441.TotalAMTFOB = 0
            D3441.PriceOrder = 0
            D3441.TotalAMT = 0
            D3441.TotalGW = 0
            D3441.TotalNW = 0
            D3441.TotalCBM = 0
            D3441.TotalQty = 0
            D3441.TotalCnt = 0
            D3441.ContName1 = ""
            D3441.ContName2 = ""
            D3441.ContName3 = ""
            D3441.ContName4 = ""
            D3441.ContName5 = ""
            D3441.ContName6 = ""
            D3441.ContName7 = ""
            D3441.ContName8 = ""
            D3441.ContName9 = ""
            D3441.ContName10 = ""
            D3441.QtyPL1 = 0
            D3441.QtyPL2 = 0
            D3441.QtyPL3 = 0
            D3441.QtyPL4 = 0
            D3441.QtyPL5 = 0
            D3441.QtyPL6 = 0
            D3441.QtyPL7 = 0
            D3441.QtyPL8 = 0
            D3441.QtyPL9 = 0
            D3441.QtyPL10 = 0
            D3441.seSite = ""
            D3441.cdSite = ""
            D3441.Remark = ""
            D3441.TimeInsert = ""
            D3441.TimeUpdate = ""
            D3441.DateUpdate = ""
            D3441.DateInsert = ""
            D3441.InchargeInsert = ""
            D3441.InchargeUpdate = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D3441_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x3441 As T3441_AREA)
        Try

            x3441.InvoiceNo = trim$(x3441.InvoiceNo)
            x3441.InvoiceSeq = trim$(x3441.InvoiceSeq)
            x3441.SONo = trim$(x3441.SONo)
            x3441.BookingNo = trim$(x3441.BookingNo)
            x3441.LoadingNo = trim$(x3441.LoadingNo)
            x3441.VesselName = trim$(x3441.VesselName)
            x3441.TradingName = trim$(x3441.TradingName)
            x3441.TradingCode = trim$(x3441.TradingCode)
            x3441.ShipmentType = trim$(x3441.ShipmentType)
            x3441.DateBL = trim$(x3441.DateBL)
            x3441.BLNo = trim$(x3441.BLNo)
            x3441.ContainerNo = trim$(x3441.ContainerNo)
            x3441.seShipType = trim$(x3441.seShipType)
            x3441.cdShipType = trim$(x3441.cdShipType)
            x3441.DateEXFac = trim$(x3441.DateEXFac)
            x3441.DateETD = trim$(x3441.DateETD)
            x3441.DateETA = trim$(x3441.DateETA)
            x3441.OrderNo = trim$(x3441.OrderNo)
            x3441.OrderNoSeq = trim$(x3441.OrderNoSeq)
            x3441.LoadingCode = trim$(x3441.LoadingCode)
            x3441.TransferType = trim$(x3441.TransferType)
            x3441.ChkDeclare = trim$(x3441.ChkDeclare)
            x3441.DateDeclare = trim$(x3441.DateDeclare)
            x3441.ChkSMDocs = trim$(x3441.ChkSMDocs)
            x3441.DateSMDocs = trim$(x3441.DateSMDocs)
            x3441.ChkLocalCharge = trim$(x3441.ChkLocalCharge)
            x3441.DateLocalCharge = trim$(x3441.DateLocalCharge)
            x3441.ChkUploadDocs = trim$(x3441.ChkUploadDocs)
            x3441.DateUploadDocs = trim$(x3441.DateUploadDocs)
            x3441.ChkDocsHK = trim$(x3441.ChkDocsHK)
            x3441.DateDocsHK = trim$(x3441.DateDocsHK)
            x3441.ChkDocsBuyer = trim$(x3441.ChkDocsBuyer)
            x3441.ChkReceiveHK = trim$(x3441.ChkReceiveHK)
            x3441.ChkPending = trim$(x3441.ChkPending)
            x3441.DateDocsBuyer = trim$(x3441.DateDocsBuyer)
            x3441.CheckStatus = trim$(x3441.CheckStatus)
            x3441.QtyOrder = trim$(x3441.QtyOrder)
            x3441.QtyOrderSample = trim$(x3441.QtyOrderSample)
            x3441.PriceOrderFOB = trim$(x3441.PriceOrderFOB)
            x3441.TotalAMTFOB = trim$(x3441.TotalAMTFOB)
            x3441.PriceOrder = trim$(x3441.PriceOrder)
            x3441.TotalAMT = trim$(x3441.TotalAMT)
            x3441.TotalGW = trim$(x3441.TotalGW)
            x3441.TotalNW = trim$(x3441.TotalNW)
            x3441.TotalCBM = trim$(x3441.TotalCBM)
            x3441.TotalQty = trim$(x3441.TotalQty)
            x3441.TotalCnt = trim$(x3441.TotalCnt)
            x3441.ContName1 = trim$(x3441.ContName1)
            x3441.ContName2 = trim$(x3441.ContName2)
            x3441.ContName3 = trim$(x3441.ContName3)
            x3441.ContName4 = trim$(x3441.ContName4)
            x3441.ContName5 = trim$(x3441.ContName5)
            x3441.ContName6 = trim$(x3441.ContName6)
            x3441.ContName7 = trim$(x3441.ContName7)
            x3441.ContName8 = trim$(x3441.ContName8)
            x3441.ContName9 = trim$(x3441.ContName9)
            x3441.ContName10 = trim$(x3441.ContName10)
            x3441.QtyPL1 = trim$(x3441.QtyPL1)
            x3441.QtyPL2 = trim$(x3441.QtyPL2)
            x3441.QtyPL3 = trim$(x3441.QtyPL3)
            x3441.QtyPL4 = trim$(x3441.QtyPL4)
            x3441.QtyPL5 = trim$(x3441.QtyPL5)
            x3441.QtyPL6 = trim$(x3441.QtyPL6)
            x3441.QtyPL7 = trim$(x3441.QtyPL7)
            x3441.QtyPL8 = trim$(x3441.QtyPL8)
            x3441.QtyPL9 = trim$(x3441.QtyPL9)
            x3441.QtyPL10 = trim$(x3441.QtyPL10)
            x3441.seSite = trim$(x3441.seSite)
            x3441.cdSite = trim$(x3441.cdSite)
            x3441.Remark = trim$(x3441.Remark)
            x3441.TimeInsert = trim$(x3441.TimeInsert)
            x3441.TimeUpdate = trim$(x3441.TimeUpdate)
            x3441.DateUpdate = trim$(x3441.DateUpdate)
            x3441.DateInsert = trim$(x3441.DateInsert)
            x3441.InchargeInsert = trim$(x3441.InchargeInsert)
            x3441.InchargeUpdate = trim$(x3441.InchargeUpdate)

            If trim$(x3441.InvoiceNo) = "" Then x3441.InvoiceNo = Space(1)
            If trim$(x3441.InvoiceSeq) = "" Then x3441.InvoiceSeq = Space(1)
            If trim$(x3441.SONo) = "" Then x3441.SONo = Space(1)
            If trim$(x3441.BookingNo) = "" Then x3441.BookingNo = Space(1)
            If trim$(x3441.LoadingNo) = "" Then x3441.LoadingNo = Space(1)
            If trim$(x3441.VesselName) = "" Then x3441.VesselName = Space(1)
            If trim$(x3441.TradingName) = "" Then x3441.TradingName = Space(1)
            If trim$(x3441.TradingCode) = "" Then x3441.TradingCode = Space(1)
            If trim$(x3441.ShipmentType) = "" Then x3441.ShipmentType = Space(1)
            If trim$(x3441.DateBL) = "" Then x3441.DateBL = Space(1)
            If trim$(x3441.BLNo) = "" Then x3441.BLNo = Space(1)
            If trim$(x3441.ContainerNo) = "" Then x3441.ContainerNo = Space(1)
            If trim$(x3441.seShipType) = "" Then x3441.seShipType = Space(1)
            If trim$(x3441.cdShipType) = "" Then x3441.cdShipType = Space(1)
            If trim$(x3441.DateEXFac) = "" Then x3441.DateEXFac = Space(1)
            If trim$(x3441.DateETD) = "" Then x3441.DateETD = Space(1)
            If trim$(x3441.DateETA) = "" Then x3441.DateETA = Space(1)
            If trim$(x3441.OrderNo) = "" Then x3441.OrderNo = Space(1)
            If trim$(x3441.OrderNoSeq) = "" Then x3441.OrderNoSeq = Space(1)
            If trim$(x3441.LoadingCode) = "" Then x3441.LoadingCode = Space(1)
            If trim$(x3441.TransferType) = "" Then x3441.TransferType = Space(1)
            If trim$(x3441.ChkDeclare) = "" Then x3441.ChkDeclare = Space(1)
            If trim$(x3441.DateDeclare) = "" Then x3441.DateDeclare = Space(1)
            If trim$(x3441.ChkSMDocs) = "" Then x3441.ChkSMDocs = Space(1)
            If trim$(x3441.DateSMDocs) = "" Then x3441.DateSMDocs = Space(1)
            If trim$(x3441.ChkLocalCharge) = "" Then x3441.ChkLocalCharge = Space(1)
            If trim$(x3441.DateLocalCharge) = "" Then x3441.DateLocalCharge = Space(1)
            If trim$(x3441.ChkUploadDocs) = "" Then x3441.ChkUploadDocs = Space(1)
            If trim$(x3441.DateUploadDocs) = "" Then x3441.DateUploadDocs = Space(1)
            If trim$(x3441.ChkDocsHK) = "" Then x3441.ChkDocsHK = Space(1)
            If trim$(x3441.DateDocsHK) = "" Then x3441.DateDocsHK = Space(1)
            If trim$(x3441.ChkDocsBuyer) = "" Then x3441.ChkDocsBuyer = Space(1)
            If trim$(x3441.ChkReceiveHK) = "" Then x3441.ChkReceiveHK = Space(1)
            If trim$(x3441.ChkPending) = "" Then x3441.ChkPending = Space(1)
            If trim$(x3441.DateDocsBuyer) = "" Then x3441.DateDocsBuyer = Space(1)
            If trim$(x3441.CheckStatus) = "" Then x3441.CheckStatus = 0
            If trim$(x3441.QtyOrder) = "" Then x3441.QtyOrder = 0
            If trim$(x3441.QtyOrderSample) = "" Then x3441.QtyOrderSample = 0
            If trim$(x3441.PriceOrderFOB) = "" Then x3441.PriceOrderFOB = 0
            If trim$(x3441.TotalAMTFOB) = "" Then x3441.TotalAMTFOB = 0
            If trim$(x3441.PriceOrder) = "" Then x3441.PriceOrder = 0
            If trim$(x3441.TotalAMT) = "" Then x3441.TotalAMT = 0
            If trim$(x3441.TotalGW) = "" Then x3441.TotalGW = 0
            If trim$(x3441.TotalNW) = "" Then x3441.TotalNW = 0
            If trim$(x3441.TotalCBM) = "" Then x3441.TotalCBM = 0
            If trim$(x3441.TotalQty) = "" Then x3441.TotalQty = 0
            If trim$(x3441.TotalCnt) = "" Then x3441.TotalCnt = 0
            If trim$(x3441.ContName1) = "" Then x3441.ContName1 = Space(1)
            If trim$(x3441.ContName2) = "" Then x3441.ContName2 = Space(1)
            If trim$(x3441.ContName3) = "" Then x3441.ContName3 = Space(1)
            If trim$(x3441.ContName4) = "" Then x3441.ContName4 = Space(1)
            If trim$(x3441.ContName5) = "" Then x3441.ContName5 = Space(1)
            If trim$(x3441.ContName6) = "" Then x3441.ContName6 = Space(1)
            If trim$(x3441.ContName7) = "" Then x3441.ContName7 = Space(1)
            If trim$(x3441.ContName8) = "" Then x3441.ContName8 = Space(1)
            If trim$(x3441.ContName9) = "" Then x3441.ContName9 = Space(1)
            If trim$(x3441.ContName10) = "" Then x3441.ContName10 = Space(1)
            If trim$(x3441.QtyPL1) = "" Then x3441.QtyPL1 = 0
            If trim$(x3441.QtyPL2) = "" Then x3441.QtyPL2 = 0
            If trim$(x3441.QtyPL3) = "" Then x3441.QtyPL3 = 0
            If trim$(x3441.QtyPL4) = "" Then x3441.QtyPL4 = 0
            If trim$(x3441.QtyPL5) = "" Then x3441.QtyPL5 = 0
            If trim$(x3441.QtyPL6) = "" Then x3441.QtyPL6 = 0
            If trim$(x3441.QtyPL7) = "" Then x3441.QtyPL7 = 0
            If trim$(x3441.QtyPL8) = "" Then x3441.QtyPL8 = 0
            If trim$(x3441.QtyPL9) = "" Then x3441.QtyPL9 = 0
            If trim$(x3441.QtyPL10) = "" Then x3441.QtyPL10 = 0
            If trim$(x3441.seSite) = "" Then x3441.seSite = Space(1)
            If trim$(x3441.cdSite) = "" Then x3441.cdSite = Space(1)
            If trim$(x3441.Remark) = "" Then x3441.Remark = Space(1)
            If trim$(x3441.TimeInsert) = "" Then x3441.TimeInsert = Space(1)
            If trim$(x3441.TimeUpdate) = "" Then x3441.TimeUpdate = Space(1)
            If trim$(x3441.DateUpdate) = "" Then x3441.DateUpdate = Space(1)
            If trim$(x3441.DateInsert) = "" Then x3441.DateInsert = Space(1)
            If trim$(x3441.InchargeInsert) = "" Then x3441.InchargeInsert = Space(1)
            If trim$(x3441.InchargeUpdate) = "" Then x3441.InchargeUpdate = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K3441_MOVE(rs3441 As SqlClient.SqlDataReader)
        Try

            Call D3441_CLEAR()

            If IsdbNull(rs3441!K3441_InvoiceNo) = False Then D3441.InvoiceNo = Trim$(rs3441!K3441_InvoiceNo)
            If IsdbNull(rs3441!K3441_InvoiceSeq) = False Then D3441.InvoiceSeq = Trim$(rs3441!K3441_InvoiceSeq)
            If IsdbNull(rs3441!K3441_SONo) = False Then D3441.SONo = Trim$(rs3441!K3441_SONo)
            If IsdbNull(rs3441!K3441_BookingNo) = False Then D3441.BookingNo = Trim$(rs3441!K3441_BookingNo)
            If IsdbNull(rs3441!K3441_LoadingNo) = False Then D3441.LoadingNo = Trim$(rs3441!K3441_LoadingNo)
            If IsdbNull(rs3441!K3441_VesselName) = False Then D3441.VesselName = Trim$(rs3441!K3441_VesselName)
            If IsdbNull(rs3441!K3441_TradingName) = False Then D3441.TradingName = Trim$(rs3441!K3441_TradingName)
            If IsdbNull(rs3441!K3441_TradingCode) = False Then D3441.TradingCode = Trim$(rs3441!K3441_TradingCode)
            If IsdbNull(rs3441!K3441_ShipmentType) = False Then D3441.ShipmentType = Trim$(rs3441!K3441_ShipmentType)
            If IsdbNull(rs3441!K3441_DateBL) = False Then D3441.DateBL = Trim$(rs3441!K3441_DateBL)
            If IsdbNull(rs3441!K3441_BLNo) = False Then D3441.BLNo = Trim$(rs3441!K3441_BLNo)
            If IsdbNull(rs3441!K3441_ContainerNo) = False Then D3441.ContainerNo = Trim$(rs3441!K3441_ContainerNo)
            If IsdbNull(rs3441!K3441_seShipType) = False Then D3441.seShipType = Trim$(rs3441!K3441_seShipType)
            If IsdbNull(rs3441!K3441_cdShipType) = False Then D3441.cdShipType = Trim$(rs3441!K3441_cdShipType)
            If IsdbNull(rs3441!K3441_DateEXFac) = False Then D3441.DateEXFac = Trim$(rs3441!K3441_DateEXFac)
            If IsdbNull(rs3441!K3441_DateETD) = False Then D3441.DateETD = Trim$(rs3441!K3441_DateETD)
            If IsdbNull(rs3441!K3441_DateETA) = False Then D3441.DateETA = Trim$(rs3441!K3441_DateETA)
            If IsdbNull(rs3441!K3441_OrderNo) = False Then D3441.OrderNo = Trim$(rs3441!K3441_OrderNo)
            If IsdbNull(rs3441!K3441_OrderNoSeq) = False Then D3441.OrderNoSeq = Trim$(rs3441!K3441_OrderNoSeq)
            If IsdbNull(rs3441!K3441_LoadingCode) = False Then D3441.LoadingCode = Trim$(rs3441!K3441_LoadingCode)
            If IsdbNull(rs3441!K3441_TransferType) = False Then D3441.TransferType = Trim$(rs3441!K3441_TransferType)
            If IsdbNull(rs3441!K3441_ChkDeclare) = False Then D3441.ChkDeclare = Trim$(rs3441!K3441_ChkDeclare)
            If IsdbNull(rs3441!K3441_DateDeclare) = False Then D3441.DateDeclare = Trim$(rs3441!K3441_DateDeclare)
            If IsdbNull(rs3441!K3441_ChkSMDocs) = False Then D3441.ChkSMDocs = Trim$(rs3441!K3441_ChkSMDocs)
            If IsdbNull(rs3441!K3441_DateSMDocs) = False Then D3441.DateSMDocs = Trim$(rs3441!K3441_DateSMDocs)
            If IsdbNull(rs3441!K3441_ChkLocalCharge) = False Then D3441.ChkLocalCharge = Trim$(rs3441!K3441_ChkLocalCharge)
            If IsdbNull(rs3441!K3441_DateLocalCharge) = False Then D3441.DateLocalCharge = Trim$(rs3441!K3441_DateLocalCharge)
            If IsdbNull(rs3441!K3441_ChkUploadDocs) = False Then D3441.ChkUploadDocs = Trim$(rs3441!K3441_ChkUploadDocs)
            If IsdbNull(rs3441!K3441_DateUploadDocs) = False Then D3441.DateUploadDocs = Trim$(rs3441!K3441_DateUploadDocs)
            If IsdbNull(rs3441!K3441_ChkDocsHK) = False Then D3441.ChkDocsHK = Trim$(rs3441!K3441_ChkDocsHK)
            If IsdbNull(rs3441!K3441_DateDocsHK) = False Then D3441.DateDocsHK = Trim$(rs3441!K3441_DateDocsHK)
            If IsdbNull(rs3441!K3441_ChkDocsBuyer) = False Then D3441.ChkDocsBuyer = Trim$(rs3441!K3441_ChkDocsBuyer)
            If IsdbNull(rs3441!K3441_ChkReceiveHK) = False Then D3441.ChkReceiveHK = Trim$(rs3441!K3441_ChkReceiveHK)
            If IsdbNull(rs3441!K3441_ChkPending) = False Then D3441.ChkPending = Trim$(rs3441!K3441_ChkPending)
            If IsdbNull(rs3441!K3441_DateDocsBuyer) = False Then D3441.DateDocsBuyer = Trim$(rs3441!K3441_DateDocsBuyer)
            If IsdbNull(rs3441!K3441_CheckStatus) = False Then D3441.CheckStatus = Trim$(rs3441!K3441_CheckStatus)
            If IsdbNull(rs3441!K3441_QtyOrder) = False Then D3441.QtyOrder = Trim$(rs3441!K3441_QtyOrder)
            If IsdbNull(rs3441!K3441_QtyOrderSample) = False Then D3441.QtyOrderSample = Trim$(rs3441!K3441_QtyOrderSample)
            If IsdbNull(rs3441!K3441_PriceOrderFOB) = False Then D3441.PriceOrderFOB = Trim$(rs3441!K3441_PriceOrderFOB)
            If IsdbNull(rs3441!K3441_TotalAMTFOB) = False Then D3441.TotalAMTFOB = Trim$(rs3441!K3441_TotalAMTFOB)
            If IsdbNull(rs3441!K3441_PriceOrder) = False Then D3441.PriceOrder = Trim$(rs3441!K3441_PriceOrder)
            If IsdbNull(rs3441!K3441_TotalAMT) = False Then D3441.TotalAMT = Trim$(rs3441!K3441_TotalAMT)
            If IsdbNull(rs3441!K3441_TotalGW) = False Then D3441.TotalGW = Trim$(rs3441!K3441_TotalGW)
            If IsdbNull(rs3441!K3441_TotalNW) = False Then D3441.TotalNW = Trim$(rs3441!K3441_TotalNW)
            If IsdbNull(rs3441!K3441_TotalCBM) = False Then D3441.TotalCBM = Trim$(rs3441!K3441_TotalCBM)
            If IsdbNull(rs3441!K3441_TotalQty) = False Then D3441.TotalQty = Trim$(rs3441!K3441_TotalQty)
            If IsdbNull(rs3441!K3441_TotalCnt) = False Then D3441.TotalCnt = Trim$(rs3441!K3441_TotalCnt)
            If IsdbNull(rs3441!K3441_ContName1) = False Then D3441.ContName1 = Trim$(rs3441!K3441_ContName1)
            If IsdbNull(rs3441!K3441_ContName2) = False Then D3441.ContName2 = Trim$(rs3441!K3441_ContName2)
            If IsdbNull(rs3441!K3441_ContName3) = False Then D3441.ContName3 = Trim$(rs3441!K3441_ContName3)
            If IsdbNull(rs3441!K3441_ContName4) = False Then D3441.ContName4 = Trim$(rs3441!K3441_ContName4)
            If IsdbNull(rs3441!K3441_ContName5) = False Then D3441.ContName5 = Trim$(rs3441!K3441_ContName5)
            If IsdbNull(rs3441!K3441_ContName6) = False Then D3441.ContName6 = Trim$(rs3441!K3441_ContName6)
            If IsdbNull(rs3441!K3441_ContName7) = False Then D3441.ContName7 = Trim$(rs3441!K3441_ContName7)
            If IsdbNull(rs3441!K3441_ContName8) = False Then D3441.ContName8 = Trim$(rs3441!K3441_ContName8)
            If IsdbNull(rs3441!K3441_ContName9) = False Then D3441.ContName9 = Trim$(rs3441!K3441_ContName9)
            If IsdbNull(rs3441!K3441_ContName10) = False Then D3441.ContName10 = Trim$(rs3441!K3441_ContName10)
            If IsdbNull(rs3441!K3441_QtyPL1) = False Then D3441.QtyPL1 = Trim$(rs3441!K3441_QtyPL1)
            If IsdbNull(rs3441!K3441_QtyPL2) = False Then D3441.QtyPL2 = Trim$(rs3441!K3441_QtyPL2)
            If IsdbNull(rs3441!K3441_QtyPL3) = False Then D3441.QtyPL3 = Trim$(rs3441!K3441_QtyPL3)
            If IsdbNull(rs3441!K3441_QtyPL4) = False Then D3441.QtyPL4 = Trim$(rs3441!K3441_QtyPL4)
            If IsdbNull(rs3441!K3441_QtyPL5) = False Then D3441.QtyPL5 = Trim$(rs3441!K3441_QtyPL5)
            If IsdbNull(rs3441!K3441_QtyPL6) = False Then D3441.QtyPL6 = Trim$(rs3441!K3441_QtyPL6)
            If IsdbNull(rs3441!K3441_QtyPL7) = False Then D3441.QtyPL7 = Trim$(rs3441!K3441_QtyPL7)
            If IsdbNull(rs3441!K3441_QtyPL8) = False Then D3441.QtyPL8 = Trim$(rs3441!K3441_QtyPL8)
            If IsdbNull(rs3441!K3441_QtyPL9) = False Then D3441.QtyPL9 = Trim$(rs3441!K3441_QtyPL9)
            If IsdbNull(rs3441!K3441_QtyPL10) = False Then D3441.QtyPL10 = Trim$(rs3441!K3441_QtyPL10)
            If IsdbNull(rs3441!K3441_seSite) = False Then D3441.seSite = Trim$(rs3441!K3441_seSite)
            If IsdbNull(rs3441!K3441_cdSite) = False Then D3441.cdSite = Trim$(rs3441!K3441_cdSite)
            If IsdbNull(rs3441!K3441_Remark) = False Then D3441.Remark = Trim$(rs3441!K3441_Remark)
            If IsdbNull(rs3441!K3441_TimeInsert) = False Then D3441.TimeInsert = Trim$(rs3441!K3441_TimeInsert)
            If IsdbNull(rs3441!K3441_TimeUpdate) = False Then D3441.TimeUpdate = Trim$(rs3441!K3441_TimeUpdate)
            If IsdbNull(rs3441!K3441_DateUpdate) = False Then D3441.DateUpdate = Trim$(rs3441!K3441_DateUpdate)
            If IsdbNull(rs3441!K3441_DateInsert) = False Then D3441.DateInsert = Trim$(rs3441!K3441_DateInsert)
            If IsdbNull(rs3441!K3441_InchargeInsert) = False Then D3441.InchargeInsert = Trim$(rs3441!K3441_InchargeInsert)
            If IsdbNull(rs3441!K3441_InchargeUpdate) = False Then D3441.InchargeUpdate = Trim$(rs3441!K3441_InchargeUpdate)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K3441_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K3441_MOVE(rs3441 As DataRow)
        Try

            Call D3441_CLEAR()

            If IsdbNull(rs3441!K3441_InvoiceNo) = False Then D3441.InvoiceNo = Trim$(rs3441!K3441_InvoiceNo)
            If IsdbNull(rs3441!K3441_InvoiceSeq) = False Then D3441.InvoiceSeq = Trim$(rs3441!K3441_InvoiceSeq)
            If IsdbNull(rs3441!K3441_SONo) = False Then D3441.SONo = Trim$(rs3441!K3441_SONo)
            If IsdbNull(rs3441!K3441_BookingNo) = False Then D3441.BookingNo = Trim$(rs3441!K3441_BookingNo)
            If IsdbNull(rs3441!K3441_LoadingNo) = False Then D3441.LoadingNo = Trim$(rs3441!K3441_LoadingNo)
            If IsdbNull(rs3441!K3441_VesselName) = False Then D3441.VesselName = Trim$(rs3441!K3441_VesselName)
            If IsdbNull(rs3441!K3441_TradingName) = False Then D3441.TradingName = Trim$(rs3441!K3441_TradingName)
            If IsdbNull(rs3441!K3441_TradingCode) = False Then D3441.TradingCode = Trim$(rs3441!K3441_TradingCode)
            If IsdbNull(rs3441!K3441_ShipmentType) = False Then D3441.ShipmentType = Trim$(rs3441!K3441_ShipmentType)
            If IsdbNull(rs3441!K3441_DateBL) = False Then D3441.DateBL = Trim$(rs3441!K3441_DateBL)
            If IsdbNull(rs3441!K3441_BLNo) = False Then D3441.BLNo = Trim$(rs3441!K3441_BLNo)
            If IsdbNull(rs3441!K3441_ContainerNo) = False Then D3441.ContainerNo = Trim$(rs3441!K3441_ContainerNo)
            If IsdbNull(rs3441!K3441_seShipType) = False Then D3441.seShipType = Trim$(rs3441!K3441_seShipType)
            If IsdbNull(rs3441!K3441_cdShipType) = False Then D3441.cdShipType = Trim$(rs3441!K3441_cdShipType)
            If IsdbNull(rs3441!K3441_DateEXFac) = False Then D3441.DateEXFac = Trim$(rs3441!K3441_DateEXFac)
            If IsdbNull(rs3441!K3441_DateETD) = False Then D3441.DateETD = Trim$(rs3441!K3441_DateETD)
            If IsdbNull(rs3441!K3441_DateETA) = False Then D3441.DateETA = Trim$(rs3441!K3441_DateETA)
            If IsdbNull(rs3441!K3441_OrderNo) = False Then D3441.OrderNo = Trim$(rs3441!K3441_OrderNo)
            If IsdbNull(rs3441!K3441_OrderNoSeq) = False Then D3441.OrderNoSeq = Trim$(rs3441!K3441_OrderNoSeq)
            If IsdbNull(rs3441!K3441_LoadingCode) = False Then D3441.LoadingCode = Trim$(rs3441!K3441_LoadingCode)
            If IsdbNull(rs3441!K3441_TransferType) = False Then D3441.TransferType = Trim$(rs3441!K3441_TransferType)
            If IsdbNull(rs3441!K3441_ChkDeclare) = False Then D3441.ChkDeclare = Trim$(rs3441!K3441_ChkDeclare)
            If IsdbNull(rs3441!K3441_DateDeclare) = False Then D3441.DateDeclare = Trim$(rs3441!K3441_DateDeclare)
            If IsdbNull(rs3441!K3441_ChkSMDocs) = False Then D3441.ChkSMDocs = Trim$(rs3441!K3441_ChkSMDocs)
            If IsdbNull(rs3441!K3441_DateSMDocs) = False Then D3441.DateSMDocs = Trim$(rs3441!K3441_DateSMDocs)
            If IsdbNull(rs3441!K3441_ChkLocalCharge) = False Then D3441.ChkLocalCharge = Trim$(rs3441!K3441_ChkLocalCharge)
            If IsdbNull(rs3441!K3441_DateLocalCharge) = False Then D3441.DateLocalCharge = Trim$(rs3441!K3441_DateLocalCharge)
            If IsdbNull(rs3441!K3441_ChkUploadDocs) = False Then D3441.ChkUploadDocs = Trim$(rs3441!K3441_ChkUploadDocs)
            If IsdbNull(rs3441!K3441_DateUploadDocs) = False Then D3441.DateUploadDocs = Trim$(rs3441!K3441_DateUploadDocs)
            If IsdbNull(rs3441!K3441_ChkDocsHK) = False Then D3441.ChkDocsHK = Trim$(rs3441!K3441_ChkDocsHK)
            If IsdbNull(rs3441!K3441_DateDocsHK) = False Then D3441.DateDocsHK = Trim$(rs3441!K3441_DateDocsHK)
            If IsdbNull(rs3441!K3441_ChkDocsBuyer) = False Then D3441.ChkDocsBuyer = Trim$(rs3441!K3441_ChkDocsBuyer)
            If IsdbNull(rs3441!K3441_ChkReceiveHK) = False Then D3441.ChkReceiveHK = Trim$(rs3441!K3441_ChkReceiveHK)
            If IsdbNull(rs3441!K3441_ChkPending) = False Then D3441.ChkPending = Trim$(rs3441!K3441_ChkPending)
            If IsdbNull(rs3441!K3441_DateDocsBuyer) = False Then D3441.DateDocsBuyer = Trim$(rs3441!K3441_DateDocsBuyer)
            If IsdbNull(rs3441!K3441_CheckStatus) = False Then D3441.CheckStatus = Trim$(rs3441!K3441_CheckStatus)
            If IsdbNull(rs3441!K3441_QtyOrder) = False Then D3441.QtyOrder = Trim$(rs3441!K3441_QtyOrder)
            If IsdbNull(rs3441!K3441_QtyOrderSample) = False Then D3441.QtyOrderSample = Trim$(rs3441!K3441_QtyOrderSample)
            If IsdbNull(rs3441!K3441_PriceOrderFOB) = False Then D3441.PriceOrderFOB = Trim$(rs3441!K3441_PriceOrderFOB)
            If IsdbNull(rs3441!K3441_TotalAMTFOB) = False Then D3441.TotalAMTFOB = Trim$(rs3441!K3441_TotalAMTFOB)
            If IsdbNull(rs3441!K3441_PriceOrder) = False Then D3441.PriceOrder = Trim$(rs3441!K3441_PriceOrder)
            If IsdbNull(rs3441!K3441_TotalAMT) = False Then D3441.TotalAMT = Trim$(rs3441!K3441_TotalAMT)
            If IsdbNull(rs3441!K3441_TotalGW) = False Then D3441.TotalGW = Trim$(rs3441!K3441_TotalGW)
            If IsdbNull(rs3441!K3441_TotalNW) = False Then D3441.TotalNW = Trim$(rs3441!K3441_TotalNW)
            If IsdbNull(rs3441!K3441_TotalCBM) = False Then D3441.TotalCBM = Trim$(rs3441!K3441_TotalCBM)
            If IsdbNull(rs3441!K3441_TotalQty) = False Then D3441.TotalQty = Trim$(rs3441!K3441_TotalQty)
            If IsdbNull(rs3441!K3441_TotalCnt) = False Then D3441.TotalCnt = Trim$(rs3441!K3441_TotalCnt)
            If IsdbNull(rs3441!K3441_ContName1) = False Then D3441.ContName1 = Trim$(rs3441!K3441_ContName1)
            If IsdbNull(rs3441!K3441_ContName2) = False Then D3441.ContName2 = Trim$(rs3441!K3441_ContName2)
            If IsdbNull(rs3441!K3441_ContName3) = False Then D3441.ContName3 = Trim$(rs3441!K3441_ContName3)
            If IsdbNull(rs3441!K3441_ContName4) = False Then D3441.ContName4 = Trim$(rs3441!K3441_ContName4)
            If IsdbNull(rs3441!K3441_ContName5) = False Then D3441.ContName5 = Trim$(rs3441!K3441_ContName5)
            If IsdbNull(rs3441!K3441_ContName6) = False Then D3441.ContName6 = Trim$(rs3441!K3441_ContName6)
            If IsdbNull(rs3441!K3441_ContName7) = False Then D3441.ContName7 = Trim$(rs3441!K3441_ContName7)
            If IsdbNull(rs3441!K3441_ContName8) = False Then D3441.ContName8 = Trim$(rs3441!K3441_ContName8)
            If IsdbNull(rs3441!K3441_ContName9) = False Then D3441.ContName9 = Trim$(rs3441!K3441_ContName9)
            If IsdbNull(rs3441!K3441_ContName10) = False Then D3441.ContName10 = Trim$(rs3441!K3441_ContName10)
            If IsdbNull(rs3441!K3441_QtyPL1) = False Then D3441.QtyPL1 = Trim$(rs3441!K3441_QtyPL1)
            If IsdbNull(rs3441!K3441_QtyPL2) = False Then D3441.QtyPL2 = Trim$(rs3441!K3441_QtyPL2)
            If IsdbNull(rs3441!K3441_QtyPL3) = False Then D3441.QtyPL3 = Trim$(rs3441!K3441_QtyPL3)
            If IsdbNull(rs3441!K3441_QtyPL4) = False Then D3441.QtyPL4 = Trim$(rs3441!K3441_QtyPL4)
            If IsdbNull(rs3441!K3441_QtyPL5) = False Then D3441.QtyPL5 = Trim$(rs3441!K3441_QtyPL5)
            If IsdbNull(rs3441!K3441_QtyPL6) = False Then D3441.QtyPL6 = Trim$(rs3441!K3441_QtyPL6)
            If IsdbNull(rs3441!K3441_QtyPL7) = False Then D3441.QtyPL7 = Trim$(rs3441!K3441_QtyPL7)
            If IsdbNull(rs3441!K3441_QtyPL8) = False Then D3441.QtyPL8 = Trim$(rs3441!K3441_QtyPL8)
            If IsdbNull(rs3441!K3441_QtyPL9) = False Then D3441.QtyPL9 = Trim$(rs3441!K3441_QtyPL9)
            If IsdbNull(rs3441!K3441_QtyPL10) = False Then D3441.QtyPL10 = Trim$(rs3441!K3441_QtyPL10)
            If IsdbNull(rs3441!K3441_seSite) = False Then D3441.seSite = Trim$(rs3441!K3441_seSite)
            If IsdbNull(rs3441!K3441_cdSite) = False Then D3441.cdSite = Trim$(rs3441!K3441_cdSite)
            If IsdbNull(rs3441!K3441_Remark) = False Then D3441.Remark = Trim$(rs3441!K3441_Remark)
            If IsdbNull(rs3441!K3441_TimeInsert) = False Then D3441.TimeInsert = Trim$(rs3441!K3441_TimeInsert)
            If IsdbNull(rs3441!K3441_TimeUpdate) = False Then D3441.TimeUpdate = Trim$(rs3441!K3441_TimeUpdate)
            If IsdbNull(rs3441!K3441_DateUpdate) = False Then D3441.DateUpdate = Trim$(rs3441!K3441_DateUpdate)
            If IsdbNull(rs3441!K3441_DateInsert) = False Then D3441.DateInsert = Trim$(rs3441!K3441_DateInsert)
            If IsdbNull(rs3441!K3441_InchargeInsert) = False Then D3441.InchargeInsert = Trim$(rs3441!K3441_InchargeInsert)
            If IsdbNull(rs3441!K3441_InchargeUpdate) = False Then D3441.InchargeUpdate = Trim$(rs3441!K3441_InchargeUpdate)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K3441_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K3441_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z3441 As T3441_AREA, INVOICENO As String, INVOICESEQ As String) As Boolean

        K3441_MOVE = False

        Try
            If READ_PFK3441(INVOICENO, INVOICESEQ) = True Then
                z3441 = D3441
                K3441_MOVE = True
            Else
                z3441 = Nothing
            End If

            If getColumnIndex(spr, "InvoiceNo") > -1 Then z3441.InvoiceNo = getDataM(spr, getColumnIndex(spr, "InvoiceNo"), xRow)
            If getColumnIndex(spr, "InvoiceSeq") > -1 Then z3441.InvoiceSeq = getDataM(spr, getColumnIndex(spr, "InvoiceSeq"), xRow)
            If getColumnIndex(spr, "SONo") > -1 Then z3441.SONo = getDataM(spr, getColumnIndex(spr, "SONo"), xRow)
            If getColumnIndex(spr, "BookingNo") > -1 Then z3441.BookingNo = getDataM(spr, getColumnIndex(spr, "BookingNo"), xRow)
            If getColumnIndex(spr, "LoadingNo") > -1 Then z3441.LoadingNo = getDataM(spr, getColumnIndex(spr, "LoadingNo"), xRow)
            If getColumnIndex(spr, "VesselName") > -1 Then z3441.VesselName = getDataM(spr, getColumnIndex(spr, "VesselName"), xRow)
            If getColumnIndex(spr, "TradingName") > -1 Then z3441.TradingName = getDataM(spr, getColumnIndex(spr, "TradingName"), xRow)
            If getColumnIndex(spr, "TradingCode") > -1 Then z3441.TradingCode = getDataM(spr, getColumnIndex(spr, "TradingCode"), xRow)
            If getColumnIndex(spr, "ShipmentType") > -1 Then z3441.ShipmentType = getDataM(spr, getColumnIndex(spr, "ShipmentType"), xRow)
            If getColumnIndex(spr, "DateBL") > -1 Then z3441.DateBL = getDataM(spr, getColumnIndex(spr, "DateBL"), xRow)
            If getColumnIndex(spr, "BLNo") > -1 Then z3441.BLNo = getDataM(spr, getColumnIndex(spr, "BLNo"), xRow)
            If getColumnIndex(spr, "ContainerNo") > -1 Then z3441.ContainerNo = getDataM(spr, getColumnIndex(spr, "ContainerNo"), xRow)
            If getColumnIndex(spr, "seShipType") > -1 Then z3441.seShipType = getDataM(spr, getColumnIndex(spr, "seShipType"), xRow)
            If getColumnIndex(spr, "cdShipType") > -1 Then z3441.cdShipType = getDataM(spr, getColumnIndex(spr, "cdShipType"), xRow)
            If getColumnIndex(spr, "DateEXFac") > -1 Then z3441.DateEXFac = getDataM(spr, getColumnIndex(spr, "DateEXFac"), xRow)
            If getColumnIndex(spr, "DateETD") > -1 Then z3441.DateETD = getDataM(spr, getColumnIndex(spr, "DateETD"), xRow)
            If getColumnIndex(spr, "DateETA") > -1 Then z3441.DateETA = getDataM(spr, getColumnIndex(spr, "DateETA"), xRow)
            If getColumnIndex(spr, "OrderNo") > -1 Then z3441.OrderNo = getDataM(spr, getColumnIndex(spr, "OrderNo"), xRow)
            If getColumnIndex(spr, "OrderNoSeq") > -1 Then z3441.OrderNoSeq = getDataM(spr, getColumnIndex(spr, "OrderNoSeq"), xRow)
            If getColumnIndex(spr, "LoadingCode") > -1 Then z3441.LoadingCode = getDataM(spr, getColumnIndex(spr, "LoadingCode"), xRow)
            If getColumnIndex(spr, "TransferType") > -1 Then z3441.TransferType = getDataM(spr, getColumnIndex(spr, "TransferType"), xRow)
            If getColumnIndex(spr, "ChkDeclare") > -1 Then z3441.ChkDeclare = getDataM(spr, getColumnIndex(spr, "ChkDeclare"), xRow)
            If getColumnIndex(spr, "DateDeclare") > -1 Then z3441.DateDeclare = getDataM(spr, getColumnIndex(spr, "DateDeclare"), xRow)
            If getColumnIndex(spr, "ChkSMDocs") > -1 Then z3441.ChkSMDocs = getDataM(spr, getColumnIndex(spr, "ChkSMDocs"), xRow)
            If getColumnIndex(spr, "DateSMDocs") > -1 Then z3441.DateSMDocs = getDataM(spr, getColumnIndex(spr, "DateSMDocs"), xRow)
            If getColumnIndex(spr, "ChkLocalCharge") > -1 Then z3441.ChkLocalCharge = getDataM(spr, getColumnIndex(spr, "ChkLocalCharge"), xRow)
            If getColumnIndex(spr, "DateLocalCharge") > -1 Then z3441.DateLocalCharge = getDataM(spr, getColumnIndex(spr, "DateLocalCharge"), xRow)
            If getColumnIndex(spr, "ChkUploadDocs") > -1 Then z3441.ChkUploadDocs = getDataM(spr, getColumnIndex(spr, "ChkUploadDocs"), xRow)
            If getColumnIndex(spr, "DateUploadDocs") > -1 Then z3441.DateUploadDocs = getDataM(spr, getColumnIndex(spr, "DateUploadDocs"), xRow)
            If getColumnIndex(spr, "ChkDocsHK") > -1 Then z3441.ChkDocsHK = getDataM(spr, getColumnIndex(spr, "ChkDocsHK"), xRow)
            If getColumnIndex(spr, "DateDocsHK") > -1 Then z3441.DateDocsHK = getDataM(spr, getColumnIndex(spr, "DateDocsHK"), xRow)
            If getColumnIndex(spr, "ChkDocsBuyer") > -1 Then z3441.ChkDocsBuyer = getDataM(spr, getColumnIndex(spr, "ChkDocsBuyer"), xRow)
            If getColumnIndex(spr, "ChkReceiveHK") > -1 Then z3441.ChkReceiveHK = getDataM(spr, getColumnIndex(spr, "ChkReceiveHK"), xRow)
            If getColumnIndex(spr, "ChkPending") > -1 Then z3441.ChkPending = getDataM(spr, getColumnIndex(spr, "ChkPending"), xRow)
            If getColumnIndex(spr, "DateDocsBuyer") > -1 Then z3441.DateDocsBuyer = getDataM(spr, getColumnIndex(spr, "DateDocsBuyer"), xRow)
            If getColumnIndex(spr, "CheckStatus") > -1 Then z3441.CheckStatus = Cdecp(getDataM(spr, getColumnIndex(spr, "CheckStatus"), xRow))
            If getColumnIndex(spr, "QtyOrder") > -1 Then z3441.QtyOrder = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyOrder"), xRow))
            If getColumnIndex(spr, "QtyOrderSample") > -1 Then z3441.QtyOrderSample = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyOrderSample"), xRow))
            If getColumnIndex(spr, "PriceOrderFOB") > -1 Then z3441.PriceOrderFOB = Cdecp(getDataM(spr, getColumnIndex(spr, "PriceOrderFOB"), xRow))
            If getColumnIndex(spr, "TotalAMTFOB") > -1 Then z3441.TotalAMTFOB = Cdecp(getDataM(spr, getColumnIndex(spr, "TotalAMTFOB"), xRow))
            If getColumnIndex(spr, "PriceOrder") > -1 Then z3441.PriceOrder = Cdecp(getDataM(spr, getColumnIndex(spr, "PriceOrder"), xRow))
            If getColumnIndex(spr, "TotalAMT") > -1 Then z3441.TotalAMT = Cdecp(getDataM(spr, getColumnIndex(spr, "TotalAMT"), xRow))
            If getColumnIndex(spr, "TotalGW") > -1 Then z3441.TotalGW = Cdecp(getDataM(spr, getColumnIndex(spr, "TotalGW"), xRow))
            If getColumnIndex(spr, "TotalNW") > -1 Then z3441.TotalNW = Cdecp(getDataM(spr, getColumnIndex(spr, "TotalNW"), xRow))
            If getColumnIndex(spr, "TotalCBM") > -1 Then z3441.TotalCBM = Cdecp(getDataM(spr, getColumnIndex(spr, "TotalCBM"), xRow))
            If getColumnIndex(spr, "TotalQty") > -1 Then z3441.TotalQty = Cdecp(getDataM(spr, getColumnIndex(spr, "TotalQty"), xRow))
            If getColumnIndex(spr, "TotalCnt") > -1 Then z3441.TotalCnt = Cdecp(getDataM(spr, getColumnIndex(spr, "TotalCnt"), xRow))
            If getColumnIndex(spr, "ContName1") > -1 Then z3441.ContName1 = getDataM(spr, getColumnIndex(spr, "ContName1"), xRow)
            If getColumnIndex(spr, "ContName2") > -1 Then z3441.ContName2 = getDataM(spr, getColumnIndex(spr, "ContName2"), xRow)
            If getColumnIndex(spr, "ContName3") > -1 Then z3441.ContName3 = getDataM(spr, getColumnIndex(spr, "ContName3"), xRow)
            If getColumnIndex(spr, "ContName4") > -1 Then z3441.ContName4 = getDataM(spr, getColumnIndex(spr, "ContName4"), xRow)
            If getColumnIndex(spr, "ContName5") > -1 Then z3441.ContName5 = getDataM(spr, getColumnIndex(spr, "ContName5"), xRow)
            If getColumnIndex(spr, "ContName6") > -1 Then z3441.ContName6 = getDataM(spr, getColumnIndex(spr, "ContName6"), xRow)
            If getColumnIndex(spr, "ContName7") > -1 Then z3441.ContName7 = getDataM(spr, getColumnIndex(spr, "ContName7"), xRow)
            If getColumnIndex(spr, "ContName8") > -1 Then z3441.ContName8 = getDataM(spr, getColumnIndex(spr, "ContName8"), xRow)
            If getColumnIndex(spr, "ContName9") > -1 Then z3441.ContName9 = getDataM(spr, getColumnIndex(spr, "ContName9"), xRow)
            If getColumnIndex(spr, "ContName10") > -1 Then z3441.ContName10 = getDataM(spr, getColumnIndex(spr, "ContName10"), xRow)
            If getColumnIndex(spr, "QtyPL1") > -1 Then z3441.QtyPL1 = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyPL1"), xRow))
            If getColumnIndex(spr, "QtyPL2") > -1 Then z3441.QtyPL2 = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyPL2"), xRow))
            If getColumnIndex(spr, "QtyPL3") > -1 Then z3441.QtyPL3 = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyPL3"), xRow))
            If getColumnIndex(spr, "QtyPL4") > -1 Then z3441.QtyPL4 = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyPL4"), xRow))
            If getColumnIndex(spr, "QtyPL5") > -1 Then z3441.QtyPL5 = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyPL5"), xRow))
            If getColumnIndex(spr, "QtyPL6") > -1 Then z3441.QtyPL6 = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyPL6"), xRow))
            If getColumnIndex(spr, "QtyPL7") > -1 Then z3441.QtyPL7 = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyPL7"), xRow))
            If getColumnIndex(spr, "QtyPL8") > -1 Then z3441.QtyPL8 = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyPL8"), xRow))
            If getColumnIndex(spr, "QtyPL9") > -1 Then z3441.QtyPL9 = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyPL9"), xRow))
            If getColumnIndex(spr, "QtyPL10") > -1 Then z3441.QtyPL10 = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyPL10"), xRow))
            If getColumnIndex(spr, "seSite") > -1 Then z3441.seSite = getDataM(spr, getColumnIndex(spr, "seSite"), xRow)
            If getColumnIndex(spr, "cdSite") > -1 Then z3441.cdSite = getDataM(spr, getColumnIndex(spr, "cdSite"), xRow)
            If getColumnIndex(spr, "Remark") > -1 Then z3441.Remark = getDataM(spr, getColumnIndex(spr, "Remark"), xRow)
            If getColumnIndex(spr, "TimeInsert") > -1 Then z3441.TimeInsert = getDataM(spr, getColumnIndex(spr, "TimeInsert"), xRow)
            If getColumnIndex(spr, "TimeUpdate") > -1 Then z3441.TimeUpdate = getDataM(spr, getColumnIndex(spr, "TimeUpdate"), xRow)
            If getColumnIndex(spr, "DateUpdate") > -1 Then z3441.DateUpdate = getDataM(spr, getColumnIndex(spr, "DateUpdate"), xRow)
            If getColumnIndex(spr, "DateInsert") > -1 Then z3441.DateInsert = getDataM(spr, getColumnIndex(spr, "DateInsert"), xRow)
            If getColumnIndex(spr, "InchargeInsert") > -1 Then z3441.InchargeInsert = getDataM(spr, getColumnIndex(spr, "InchargeInsert"), xRow)
            If getColumnIndex(spr, "InchargeUpdate") > -1 Then z3441.InchargeUpdate = getDataM(spr, getColumnIndex(spr, "InchargeUpdate"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K3441_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K3441_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z3441 As T3441_AREA, CheckClear As Boolean, INVOICENO As String, INVOICESEQ As String) As Boolean

        K3441_MOVE = False

        Try
            If READ_PFK3441(INVOICENO, INVOICESEQ) = True Then
                z3441 = D3441
                K3441_MOVE = True
            Else
                If CheckClear = True Then z3441 = Nothing
            End If

            If getColumnIndex(spr, "InvoiceNo") > -1 Then z3441.InvoiceNo = getDataM(spr, getColumnIndex(spr, "InvoiceNo"), xRow)
            If getColumnIndex(spr, "InvoiceSeq") > -1 Then z3441.InvoiceSeq = getDataM(spr, getColumnIndex(spr, "InvoiceSeq"), xRow)
            If getColumnIndex(spr, "SONo") > -1 Then z3441.SONo = getDataM(spr, getColumnIndex(spr, "SONo"), xRow)
            If getColumnIndex(spr, "BookingNo") > -1 Then z3441.BookingNo = getDataM(spr, getColumnIndex(spr, "BookingNo"), xRow)
            If getColumnIndex(spr, "LoadingNo") > -1 Then z3441.LoadingNo = getDataM(spr, getColumnIndex(spr, "LoadingNo"), xRow)
            If getColumnIndex(spr, "VesselName") > -1 Then z3441.VesselName = getDataM(spr, getColumnIndex(spr, "VesselName"), xRow)
            If getColumnIndex(spr, "TradingName") > -1 Then z3441.TradingName = getDataM(spr, getColumnIndex(spr, "TradingName"), xRow)
            If getColumnIndex(spr, "TradingCode") > -1 Then z3441.TradingCode = getDataM(spr, getColumnIndex(spr, "TradingCode"), xRow)
            If getColumnIndex(spr, "ShipmentType") > -1 Then z3441.ShipmentType = getDataM(spr, getColumnIndex(spr, "ShipmentType"), xRow)
            If getColumnIndex(spr, "DateBL") > -1 Then z3441.DateBL = getDataM(spr, getColumnIndex(spr, "DateBL"), xRow)
            If getColumnIndex(spr, "BLNo") > -1 Then z3441.BLNo = getDataM(spr, getColumnIndex(spr, "BLNo"), xRow)
            If getColumnIndex(spr, "ContainerNo") > -1 Then z3441.ContainerNo = getDataM(spr, getColumnIndex(spr, "ContainerNo"), xRow)
            If getColumnIndex(spr, "seShipType") > -1 Then z3441.seShipType = getDataM(spr, getColumnIndex(spr, "seShipType"), xRow)
            If getColumnIndex(spr, "cdShipType") > -1 Then z3441.cdShipType = getDataM(spr, getColumnIndex(spr, "cdShipType"), xRow)
            If getColumnIndex(spr, "DateEXFac") > -1 Then z3441.DateEXFac = getDataM(spr, getColumnIndex(spr, "DateEXFac"), xRow)
            If getColumnIndex(spr, "DateETD") > -1 Then z3441.DateETD = getDataM(spr, getColumnIndex(spr, "DateETD"), xRow)
            If getColumnIndex(spr, "DateETA") > -1 Then z3441.DateETA = getDataM(spr, getColumnIndex(spr, "DateETA"), xRow)
            If getColumnIndex(spr, "OrderNo") > -1 Then z3441.OrderNo = getDataM(spr, getColumnIndex(spr, "OrderNo"), xRow)
            If getColumnIndex(spr, "OrderNoSeq") > -1 Then z3441.OrderNoSeq = getDataM(spr, getColumnIndex(spr, "OrderNoSeq"), xRow)
            If getColumnIndex(spr, "LoadingCode") > -1 Then z3441.LoadingCode = getDataM(spr, getColumnIndex(spr, "LoadingCode"), xRow)
            If getColumnIndex(spr, "TransferType") > -1 Then z3441.TransferType = getDataM(spr, getColumnIndex(spr, "TransferType"), xRow)
            If getColumnIndex(spr, "ChkDeclare") > -1 Then z3441.ChkDeclare = getDataM(spr, getColumnIndex(spr, "ChkDeclare"), xRow)
            If getColumnIndex(spr, "DateDeclare") > -1 Then z3441.DateDeclare = getDataM(spr, getColumnIndex(spr, "DateDeclare"), xRow)
            If getColumnIndex(spr, "ChkSMDocs") > -1 Then z3441.ChkSMDocs = getDataM(spr, getColumnIndex(spr, "ChkSMDocs"), xRow)
            If getColumnIndex(spr, "DateSMDocs") > -1 Then z3441.DateSMDocs = getDataM(spr, getColumnIndex(spr, "DateSMDocs"), xRow)
            If getColumnIndex(spr, "ChkLocalCharge") > -1 Then z3441.ChkLocalCharge = getDataM(spr, getColumnIndex(spr, "ChkLocalCharge"), xRow)
            If getColumnIndex(spr, "DateLocalCharge") > -1 Then z3441.DateLocalCharge = getDataM(spr, getColumnIndex(spr, "DateLocalCharge"), xRow)
            If getColumnIndex(spr, "ChkUploadDocs") > -1 Then z3441.ChkUploadDocs = getDataM(spr, getColumnIndex(spr, "ChkUploadDocs"), xRow)
            If getColumnIndex(spr, "DateUploadDocs") > -1 Then z3441.DateUploadDocs = getDataM(spr, getColumnIndex(spr, "DateUploadDocs"), xRow)
            If getColumnIndex(spr, "ChkDocsHK") > -1 Then z3441.ChkDocsHK = getDataM(spr, getColumnIndex(spr, "ChkDocsHK"), xRow)
            If getColumnIndex(spr, "DateDocsHK") > -1 Then z3441.DateDocsHK = getDataM(spr, getColumnIndex(spr, "DateDocsHK"), xRow)
            If getColumnIndex(spr, "ChkDocsBuyer") > -1 Then z3441.ChkDocsBuyer = getDataM(spr, getColumnIndex(spr, "ChkDocsBuyer"), xRow)
            If getColumnIndex(spr, "ChkReceiveHK") > -1 Then z3441.ChkReceiveHK = getDataM(spr, getColumnIndex(spr, "ChkReceiveHK"), xRow)
            If getColumnIndex(spr, "ChkPending") > -1 Then z3441.ChkPending = getDataM(spr, getColumnIndex(spr, "ChkPending"), xRow)
            If getColumnIndex(spr, "DateDocsBuyer") > -1 Then z3441.DateDocsBuyer = getDataM(spr, getColumnIndex(spr, "DateDocsBuyer"), xRow)
            If getColumnIndex(spr, "CheckStatus") > -1 Then z3441.CheckStatus = Cdecp(getDataM(spr, getColumnIndex(spr, "CheckStatus"), xRow))
            If getColumnIndex(spr, "QtyOrder") > -1 Then z3441.QtyOrder = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyOrder"), xRow))
            If getColumnIndex(spr, "QtyOrderSample") > -1 Then z3441.QtyOrderSample = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyOrderSample"), xRow))
            If getColumnIndex(spr, "PriceOrderFOB") > -1 Then z3441.PriceOrderFOB = Cdecp(getDataM(spr, getColumnIndex(spr, "PriceOrderFOB"), xRow))
            If getColumnIndex(spr, "TotalAMTFOB") > -1 Then z3441.TotalAMTFOB = Cdecp(getDataM(spr, getColumnIndex(spr, "TotalAMTFOB"), xRow))
            If getColumnIndex(spr, "PriceOrder") > -1 Then z3441.PriceOrder = Cdecp(getDataM(spr, getColumnIndex(spr, "PriceOrder"), xRow))
            If getColumnIndex(spr, "TotalAMT") > -1 Then z3441.TotalAMT = Cdecp(getDataM(spr, getColumnIndex(spr, "TotalAMT"), xRow))
            If getColumnIndex(spr, "TotalGW") > -1 Then z3441.TotalGW = Cdecp(getDataM(spr, getColumnIndex(spr, "TotalGW"), xRow))
            If getColumnIndex(spr, "TotalNW") > -1 Then z3441.TotalNW = Cdecp(getDataM(spr, getColumnIndex(spr, "TotalNW"), xRow))
            If getColumnIndex(spr, "TotalCBM") > -1 Then z3441.TotalCBM = Cdecp(getDataM(spr, getColumnIndex(spr, "TotalCBM"), xRow))
            If getColumnIndex(spr, "TotalQty") > -1 Then z3441.TotalQty = Cdecp(getDataM(spr, getColumnIndex(spr, "TotalQty"), xRow))
            If getColumnIndex(spr, "TotalCnt") > -1 Then z3441.TotalCnt = Cdecp(getDataM(spr, getColumnIndex(spr, "TotalCnt"), xRow))
            If getColumnIndex(spr, "ContName1") > -1 Then z3441.ContName1 = getDataM(spr, getColumnIndex(spr, "ContName1"), xRow)
            If getColumnIndex(spr, "ContName2") > -1 Then z3441.ContName2 = getDataM(spr, getColumnIndex(spr, "ContName2"), xRow)
            If getColumnIndex(spr, "ContName3") > -1 Then z3441.ContName3 = getDataM(spr, getColumnIndex(spr, "ContName3"), xRow)
            If getColumnIndex(spr, "ContName4") > -1 Then z3441.ContName4 = getDataM(spr, getColumnIndex(spr, "ContName4"), xRow)
            If getColumnIndex(spr, "ContName5") > -1 Then z3441.ContName5 = getDataM(spr, getColumnIndex(spr, "ContName5"), xRow)
            If getColumnIndex(spr, "ContName6") > -1 Then z3441.ContName6 = getDataM(spr, getColumnIndex(spr, "ContName6"), xRow)
            If getColumnIndex(spr, "ContName7") > -1 Then z3441.ContName7 = getDataM(spr, getColumnIndex(spr, "ContName7"), xRow)
            If getColumnIndex(spr, "ContName8") > -1 Then z3441.ContName8 = getDataM(spr, getColumnIndex(spr, "ContName8"), xRow)
            If getColumnIndex(spr, "ContName9") > -1 Then z3441.ContName9 = getDataM(spr, getColumnIndex(spr, "ContName9"), xRow)
            If getColumnIndex(spr, "ContName10") > -1 Then z3441.ContName10 = getDataM(spr, getColumnIndex(spr, "ContName10"), xRow)
            If getColumnIndex(spr, "QtyPL1") > -1 Then z3441.QtyPL1 = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyPL1"), xRow))
            If getColumnIndex(spr, "QtyPL2") > -1 Then z3441.QtyPL2 = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyPL2"), xRow))
            If getColumnIndex(spr, "QtyPL3") > -1 Then z3441.QtyPL3 = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyPL3"), xRow))
            If getColumnIndex(spr, "QtyPL4") > -1 Then z3441.QtyPL4 = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyPL4"), xRow))
            If getColumnIndex(spr, "QtyPL5") > -1 Then z3441.QtyPL5 = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyPL5"), xRow))
            If getColumnIndex(spr, "QtyPL6") > -1 Then z3441.QtyPL6 = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyPL6"), xRow))
            If getColumnIndex(spr, "QtyPL7") > -1 Then z3441.QtyPL7 = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyPL7"), xRow))
            If getColumnIndex(spr, "QtyPL8") > -1 Then z3441.QtyPL8 = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyPL8"), xRow))
            If getColumnIndex(spr, "QtyPL9") > -1 Then z3441.QtyPL9 = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyPL9"), xRow))
            If getColumnIndex(spr, "QtyPL10") > -1 Then z3441.QtyPL10 = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyPL10"), xRow))
            If getColumnIndex(spr, "seSite") > -1 Then z3441.seSite = getDataM(spr, getColumnIndex(spr, "seSite"), xRow)
            If getColumnIndex(spr, "cdSite") > -1 Then z3441.cdSite = getDataM(spr, getColumnIndex(spr, "cdSite"), xRow)
            If getColumnIndex(spr, "Remark") > -1 Then z3441.Remark = getDataM(spr, getColumnIndex(spr, "Remark"), xRow)
            If getColumnIndex(spr, "TimeInsert") > -1 Then z3441.TimeInsert = getDataM(spr, getColumnIndex(spr, "TimeInsert"), xRow)
            If getColumnIndex(spr, "TimeUpdate") > -1 Then z3441.TimeUpdate = getDataM(spr, getColumnIndex(spr, "TimeUpdate"), xRow)
            If getColumnIndex(spr, "DateUpdate") > -1 Then z3441.DateUpdate = getDataM(spr, getColumnIndex(spr, "DateUpdate"), xRow)
            If getColumnIndex(spr, "DateInsert") > -1 Then z3441.DateInsert = getDataM(spr, getColumnIndex(spr, "DateInsert"), xRow)
            If getColumnIndex(spr, "InchargeInsert") > -1 Then z3441.InchargeInsert = getDataM(spr, getColumnIndex(spr, "InchargeInsert"), xRow)
            If getColumnIndex(spr, "InchargeUpdate") > -1 Then z3441.InchargeUpdate = getDataM(spr, getColumnIndex(spr, "InchargeUpdate"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K3441_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K3441_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z3441 As T3441_AREA, Job As String, INVOICENO As String, INVOICESEQ As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K3441_MOVE = False

        Try
            If READ_PFK3441(INVOICENO, INVOICESEQ) = True Then
                z3441 = D3441
                K3441_MOVE = True
            Else
                z3441 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3441")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "INVOICENO" : z3441.InvoiceNo = Children(i).Code
                                Case "INVOICESEQ" : z3441.InvoiceSeq = Children(i).Code
                                Case "SONO" : z3441.SONo = Children(i).Code
                                Case "BOOKINGNO" : z3441.BookingNo = Children(i).Code
                                Case "LOADINGNO" : z3441.LoadingNo = Children(i).Code
                                Case "VESSELNAME" : z3441.VesselName = Children(i).Code
                                Case "TRADINGNAME" : z3441.TradingName = Children(i).Code
                                Case "TRADINGCODE" : z3441.TradingCode = Children(i).Code
                                Case "SHIPMENTTYPE" : z3441.ShipmentType = Children(i).Code
                                Case "DATEBL" : z3441.DateBL = Children(i).Code
                                Case "BLNO" : z3441.BLNo = Children(i).Code
                                Case "CONTAINERNO" : z3441.ContainerNo = Children(i).Code
                                Case "SESHIPTYPE" : z3441.seShipType = Children(i).Code
                                Case "CDSHIPTYPE" : z3441.cdShipType = Children(i).Code
                                Case "DATEEXFAC" : z3441.DateEXFac = Children(i).Code
                                Case "DATEETD" : z3441.DateETD = Children(i).Code
                                Case "DATEETA" : z3441.DateETA = Children(i).Code
                                Case "ORDERNO" : z3441.OrderNo = Children(i).Code
                                Case "ORDERNOSEQ" : z3441.OrderNoSeq = Children(i).Code
                                Case "LOADINGCODE" : z3441.LoadingCode = Children(i).Code
                                Case "TRANSFERTYPE" : z3441.TransferType = Children(i).Code
                                Case "CHKDECLARE" : z3441.ChkDeclare = Children(i).Code
                                Case "DATEDECLARE" : z3441.DateDeclare = Children(i).Code
                                Case "CHKSMDOCS" : z3441.ChkSMDocs = Children(i).Code
                                Case "DATESMDOCS" : z3441.DateSMDocs = Children(i).Code
                                Case "CHKLOCALCHARGE" : z3441.ChkLocalCharge = Children(i).Code
                                Case "DATELOCALCHARGE" : z3441.DateLocalCharge = Children(i).Code
                                Case "CHKUPLOADDOCS" : z3441.ChkUploadDocs = Children(i).Code
                                Case "DATEUPLOADDOCS" : z3441.DateUploadDocs = Children(i).Code
                                Case "CHKDOCSHK" : z3441.ChkDocsHK = Children(i).Code
                                Case "DATEDOCSHK" : z3441.DateDocsHK = Children(i).Code
                                Case "CHKDOCSBUYER" : z3441.ChkDocsBuyer = Children(i).Code
                                Case "CHKRECEIVEHK" : z3441.ChkReceiveHK = Children(i).Code
                                Case "CHKPENDING" : z3441.ChkPending = Children(i).Code
                                Case "DATEDOCSBUYER" : z3441.DateDocsBuyer = Children(i).Code
                                Case "CHECKSTATUS" : z3441.CheckStatus = Children(i).Code
                                Case "QTYORDER" : z3441.QtyOrder = Children(i).Code
                                Case "QTYORDERSAMPLE" : z3441.QtyOrderSample = Children(i).Code
                                Case "PRICEORDERFOB" : z3441.PriceOrderFOB = Children(i).Code
                                Case "TOTALAMTFOB" : z3441.TotalAMTFOB = Children(i).Code
                                Case "PRICEORDER" : z3441.PriceOrder = Children(i).Code
                                Case "TOTALAMT" : z3441.TotalAMT = Children(i).Code
                                Case "TOTALGW" : z3441.TotalGW = Children(i).Code
                                Case "TOTALNW" : z3441.TotalNW = Children(i).Code
                                Case "TOTALCBM" : z3441.TotalCBM = Children(i).Code
                                Case "TOTALQTY" : z3441.TotalQty = Children(i).Code
                                Case "TOTALCNT" : z3441.TotalCnt = Children(i).Code
                                Case "CONTNAME1" : z3441.ContName1 = Children(i).Code
                                Case "CONTNAME2" : z3441.ContName2 = Children(i).Code
                                Case "CONTNAME3" : z3441.ContName3 = Children(i).Code
                                Case "CONTNAME4" : z3441.ContName4 = Children(i).Code
                                Case "CONTNAME5" : z3441.ContName5 = Children(i).Code
                                Case "CONTNAME6" : z3441.ContName6 = Children(i).Code
                                Case "CONTNAME7" : z3441.ContName7 = Children(i).Code
                                Case "CONTNAME8" : z3441.ContName8 = Children(i).Code
                                Case "CONTNAME9" : z3441.ContName9 = Children(i).Code
                                Case "CONTNAME10" : z3441.ContName10 = Children(i).Code
                                Case "QTYPL1" : z3441.QtyPL1 = Children(i).Code
                                Case "QTYPL2" : z3441.QtyPL2 = Children(i).Code
                                Case "QTYPL3" : z3441.QtyPL3 = Children(i).Code
                                Case "QTYPL4" : z3441.QtyPL4 = Children(i).Code
                                Case "QTYPL5" : z3441.QtyPL5 = Children(i).Code
                                Case "QTYPL6" : z3441.QtyPL6 = Children(i).Code
                                Case "QTYPL7" : z3441.QtyPL7 = Children(i).Code
                                Case "QTYPL8" : z3441.QtyPL8 = Children(i).Code
                                Case "QTYPL9" : z3441.QtyPL9 = Children(i).Code
                                Case "QTYPL10" : z3441.QtyPL10 = Children(i).Code
                                Case "SESITE" : z3441.seSite = Children(i).Code
                                Case "CDSITE" : z3441.cdSite = Children(i).Code
                                Case "REMARK" : z3441.Remark = Children(i).Code
                                Case "TIMEINSERT" : z3441.TimeInsert = Children(i).Code
                                Case "TIMEUPDATE" : z3441.TimeUpdate = Children(i).Code
                                Case "DATEUPDATE" : z3441.DateUpdate = Children(i).Code
                                Case "DATEINSERT" : z3441.DateInsert = Children(i).Code
                                Case "INCHARGEINSERT" : z3441.InchargeInsert = Children(i).Code
                                Case "INCHARGEUPDATE" : z3441.InchargeUpdate = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "INVOICENO" : z3441.InvoiceNo = Children(i).Data
                                Case "INVOICESEQ" : z3441.InvoiceSeq = Children(i).Data
                                Case "SONO" : z3441.SONo = Children(i).Data
                                Case "BOOKINGNO" : z3441.BookingNo = Children(i).Data
                                Case "LOADINGNO" : z3441.LoadingNo = Children(i).Data
                                Case "VESSELNAME" : z3441.VesselName = Children(i).Data
                                Case "TRADINGNAME" : z3441.TradingName = Children(i).Data
                                Case "TRADINGCODE" : z3441.TradingCode = Children(i).Data
                                Case "SHIPMENTTYPE" : z3441.ShipmentType = Children(i).Data
                                Case "DATEBL" : z3441.DateBL = Children(i).Data
                                Case "BLNO" : z3441.BLNo = Children(i).Data
                                Case "CONTAINERNO" : z3441.ContainerNo = Children(i).Data
                                Case "SESHIPTYPE" : z3441.seShipType = Children(i).Data
                                Case "CDSHIPTYPE" : z3441.cdShipType = Children(i).Data
                                Case "DATEEXFAC" : z3441.DateEXFac = Children(i).Data
                                Case "DATEETD" : z3441.DateETD = Children(i).Data
                                Case "DATEETA" : z3441.DateETA = Children(i).Data
                                Case "ORDERNO" : z3441.OrderNo = Children(i).Data
                                Case "ORDERNOSEQ" : z3441.OrderNoSeq = Children(i).Data
                                Case "LOADINGCODE" : z3441.LoadingCode = Children(i).Data
                                Case "TRANSFERTYPE" : z3441.TransferType = Children(i).Data
                                Case "CHKDECLARE" : z3441.ChkDeclare = Children(i).Data
                                Case "DATEDECLARE" : z3441.DateDeclare = Children(i).Data
                                Case "CHKSMDOCS" : z3441.ChkSMDocs = Children(i).Data
                                Case "DATESMDOCS" : z3441.DateSMDocs = Children(i).Data
                                Case "CHKLOCALCHARGE" : z3441.ChkLocalCharge = Children(i).Data
                                Case "DATELOCALCHARGE" : z3441.DateLocalCharge = Children(i).Data
                                Case "CHKUPLOADDOCS" : z3441.ChkUploadDocs = Children(i).Data
                                Case "DATEUPLOADDOCS" : z3441.DateUploadDocs = Children(i).Data
                                Case "CHKDOCSHK" : z3441.ChkDocsHK = Children(i).Data
                                Case "DATEDOCSHK" : z3441.DateDocsHK = Children(i).Data
                                Case "CHKDOCSBUYER" : z3441.ChkDocsBuyer = Children(i).Data
                                Case "CHKRECEIVEHK" : z3441.ChkReceiveHK = Children(i).Data
                                Case "CHKPENDING" : z3441.ChkPending = Children(i).Data
                                Case "DATEDOCSBUYER" : z3441.DateDocsBuyer = Children(i).Data
                                Case "CHECKSTATUS" : z3441.CheckStatus = Cdecp(Children(i).Data)
                                Case "QTYORDER" : z3441.QtyOrder = Cdecp(Children(i).Data)
                                Case "QTYORDERSAMPLE" : z3441.QtyOrderSample = Cdecp(Children(i).Data)
                                Case "PRICEORDERFOB" : z3441.PriceOrderFOB = Cdecp(Children(i).Data)
                                Case "TOTALAMTFOB" : z3441.TotalAMTFOB = Cdecp(Children(i).Data)
                                Case "PRICEORDER" : z3441.PriceOrder = Cdecp(Children(i).Data)
                                Case "TOTALAMT" : z3441.TotalAMT = Cdecp(Children(i).Data)
                                Case "TOTALGW" : z3441.TotalGW = Cdecp(Children(i).Data)
                                Case "TOTALNW" : z3441.TotalNW = Cdecp(Children(i).Data)
                                Case "TOTALCBM" : z3441.TotalCBM = Cdecp(Children(i).Data)
                                Case "TOTALQTY" : z3441.TotalQty = Cdecp(Children(i).Data)
                                Case "TOTALCNT" : z3441.TotalCnt = Cdecp(Children(i).Data)
                                Case "CONTNAME1" : z3441.ContName1 = Children(i).Data
                                Case "CONTNAME2" : z3441.ContName2 = Children(i).Data
                                Case "CONTNAME3" : z3441.ContName3 = Children(i).Data
                                Case "CONTNAME4" : z3441.ContName4 = Children(i).Data
                                Case "CONTNAME5" : z3441.ContName5 = Children(i).Data
                                Case "CONTNAME6" : z3441.ContName6 = Children(i).Data
                                Case "CONTNAME7" : z3441.ContName7 = Children(i).Data
                                Case "CONTNAME8" : z3441.ContName8 = Children(i).Data
                                Case "CONTNAME9" : z3441.ContName9 = Children(i).Data
                                Case "CONTNAME10" : z3441.ContName10 = Children(i).Data
                                Case "QTYPL1" : z3441.QtyPL1 = Cdecp(Children(i).Data)
                                Case "QTYPL2" : z3441.QtyPL2 = Cdecp(Children(i).Data)
                                Case "QTYPL3" : z3441.QtyPL3 = Cdecp(Children(i).Data)
                                Case "QTYPL4" : z3441.QtyPL4 = Cdecp(Children(i).Data)
                                Case "QTYPL5" : z3441.QtyPL5 = Cdecp(Children(i).Data)
                                Case "QTYPL6" : z3441.QtyPL6 = Cdecp(Children(i).Data)
                                Case "QTYPL7" : z3441.QtyPL7 = Cdecp(Children(i).Data)
                                Case "QTYPL8" : z3441.QtyPL8 = Cdecp(Children(i).Data)
                                Case "QTYPL9" : z3441.QtyPL9 = Cdecp(Children(i).Data)
                                Case "QTYPL10" : z3441.QtyPL10 = Cdecp(Children(i).Data)
                                Case "SESITE" : z3441.seSite = Children(i).Data
                                Case "CDSITE" : z3441.cdSite = Children(i).Data
                                Case "REMARK" : z3441.Remark = Children(i).Data
                                Case "TIMEINSERT" : z3441.TimeInsert = Children(i).Data
                                Case "TIMEUPDATE" : z3441.TimeUpdate = Children(i).Data
                                Case "DATEUPDATE" : z3441.DateUpdate = Children(i).Data
                                Case "DATEINSERT" : z3441.DateInsert = Children(i).Data
                                Case "INCHARGEINSERT" : z3441.InchargeInsert = Children(i).Data
                                Case "INCHARGEUPDATE" : z3441.InchargeUpdate = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K3441_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K3441_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z3441 As T3441_AREA, Job As String, CheckClear As Boolean, INVOICENO As String, INVOICESEQ As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K3441_MOVE = False

        Try
            If READ_PFK3441(INVOICENO, INVOICESEQ) = True Then
                z3441 = D3441
                K3441_MOVE = True
            Else
                If CheckClear = True Then z3441 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3441")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "INVOICENO" : z3441.InvoiceNo = Children(i).Code
                                Case "INVOICESEQ" : z3441.InvoiceSeq = Children(i).Code
                                Case "SONO" : z3441.SONo = Children(i).Code
                                Case "BOOKINGNO" : z3441.BookingNo = Children(i).Code
                                Case "LOADINGNO" : z3441.LoadingNo = Children(i).Code
                                Case "VESSELNAME" : z3441.VesselName = Children(i).Code
                                Case "TRADINGNAME" : z3441.TradingName = Children(i).Code
                                Case "TRADINGCODE" : z3441.TradingCode = Children(i).Code
                                Case "SHIPMENTTYPE" : z3441.ShipmentType = Children(i).Code
                                Case "DATEBL" : z3441.DateBL = Children(i).Code
                                Case "BLNO" : z3441.BLNo = Children(i).Code
                                Case "CONTAINERNO" : z3441.ContainerNo = Children(i).Code
                                Case "SESHIPTYPE" : z3441.seShipType = Children(i).Code
                                Case "CDSHIPTYPE" : z3441.cdShipType = Children(i).Code
                                Case "DATEEXFAC" : z3441.DateEXFac = Children(i).Code
                                Case "DATEETD" : z3441.DateETD = Children(i).Code
                                Case "DATEETA" : z3441.DateETA = Children(i).Code
                                Case "ORDERNO" : z3441.OrderNo = Children(i).Code
                                Case "ORDERNOSEQ" : z3441.OrderNoSeq = Children(i).Code
                                Case "LOADINGCODE" : z3441.LoadingCode = Children(i).Code
                                Case "TRANSFERTYPE" : z3441.TransferType = Children(i).Code
                                Case "CHKDECLARE" : z3441.ChkDeclare = Children(i).Code
                                Case "DATEDECLARE" : z3441.DateDeclare = Children(i).Code
                                Case "CHKSMDOCS" : z3441.ChkSMDocs = Children(i).Code
                                Case "DATESMDOCS" : z3441.DateSMDocs = Children(i).Code
                                Case "CHKLOCALCHARGE" : z3441.ChkLocalCharge = Children(i).Code
                                Case "DATELOCALCHARGE" : z3441.DateLocalCharge = Children(i).Code
                                Case "CHKUPLOADDOCS" : z3441.ChkUploadDocs = Children(i).Code
                                Case "DATEUPLOADDOCS" : z3441.DateUploadDocs = Children(i).Code
                                Case "CHKDOCSHK" : z3441.ChkDocsHK = Children(i).Code
                                Case "DATEDOCSHK" : z3441.DateDocsHK = Children(i).Code
                                Case "CHKDOCSBUYER" : z3441.ChkDocsBuyer = Children(i).Code
                                Case "CHKRECEIVEHK" : z3441.ChkReceiveHK = Children(i).Code
                                Case "CHKPENDING" : z3441.ChkPending = Children(i).Code
                                Case "DATEDOCSBUYER" : z3441.DateDocsBuyer = Children(i).Code
                                Case "CHECKSTATUS" : z3441.CheckStatus = Children(i).Code
                                Case "QTYORDER" : z3441.QtyOrder = Children(i).Code
                                Case "QTYORDERSAMPLE" : z3441.QtyOrderSample = Children(i).Code
                                Case "PRICEORDERFOB" : z3441.PriceOrderFOB = Children(i).Code
                                Case "TOTALAMTFOB" : z3441.TotalAMTFOB = Children(i).Code
                                Case "PRICEORDER" : z3441.PriceOrder = Children(i).Code
                                Case "TOTALAMT" : z3441.TotalAMT = Children(i).Code
                                Case "TOTALGW" : z3441.TotalGW = Children(i).Code
                                Case "TOTALNW" : z3441.TotalNW = Children(i).Code
                                Case "TOTALCBM" : z3441.TotalCBM = Children(i).Code
                                Case "TOTALQTY" : z3441.TotalQty = Children(i).Code
                                Case "TOTALCNT" : z3441.TotalCnt = Children(i).Code
                                Case "CONTNAME1" : z3441.ContName1 = Children(i).Code
                                Case "CONTNAME2" : z3441.ContName2 = Children(i).Code
                                Case "CONTNAME3" : z3441.ContName3 = Children(i).Code
                                Case "CONTNAME4" : z3441.ContName4 = Children(i).Code
                                Case "CONTNAME5" : z3441.ContName5 = Children(i).Code
                                Case "CONTNAME6" : z3441.ContName6 = Children(i).Code
                                Case "CONTNAME7" : z3441.ContName7 = Children(i).Code
                                Case "CONTNAME8" : z3441.ContName8 = Children(i).Code
                                Case "CONTNAME9" : z3441.ContName9 = Children(i).Code
                                Case "CONTNAME10" : z3441.ContName10 = Children(i).Code
                                Case "QTYPL1" : z3441.QtyPL1 = Children(i).Code
                                Case "QTYPL2" : z3441.QtyPL2 = Children(i).Code
                                Case "QTYPL3" : z3441.QtyPL3 = Children(i).Code
                                Case "QTYPL4" : z3441.QtyPL4 = Children(i).Code
                                Case "QTYPL5" : z3441.QtyPL5 = Children(i).Code
                                Case "QTYPL6" : z3441.QtyPL6 = Children(i).Code
                                Case "QTYPL7" : z3441.QtyPL7 = Children(i).Code
                                Case "QTYPL8" : z3441.QtyPL8 = Children(i).Code
                                Case "QTYPL9" : z3441.QtyPL9 = Children(i).Code
                                Case "QTYPL10" : z3441.QtyPL10 = Children(i).Code
                                Case "SESITE" : z3441.seSite = Children(i).Code
                                Case "CDSITE" : z3441.cdSite = Children(i).Code
                                Case "REMARK" : z3441.Remark = Children(i).Code
                                Case "TIMEINSERT" : z3441.TimeInsert = Children(i).Code
                                Case "TIMEUPDATE" : z3441.TimeUpdate = Children(i).Code
                                Case "DATEUPDATE" : z3441.DateUpdate = Children(i).Code
                                Case "DATEINSERT" : z3441.DateInsert = Children(i).Code
                                Case "INCHARGEINSERT" : z3441.InchargeInsert = Children(i).Code
                                Case "INCHARGEUPDATE" : z3441.InchargeUpdate = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "INVOICENO" : z3441.InvoiceNo = Children(i).Data
                                Case "INVOICESEQ" : z3441.InvoiceSeq = Children(i).Data
                                Case "SONO" : z3441.SONo = Children(i).Data
                                Case "BOOKINGNO" : z3441.BookingNo = Children(i).Data
                                Case "LOADINGNO" : z3441.LoadingNo = Children(i).Data
                                Case "VESSELNAME" : z3441.VesselName = Children(i).Data
                                Case "TRADINGNAME" : z3441.TradingName = Children(i).Data
                                Case "TRADINGCODE" : z3441.TradingCode = Children(i).Data
                                Case "SHIPMENTTYPE" : z3441.ShipmentType = Children(i).Data
                                Case "DATEBL" : z3441.DateBL = Children(i).Data
                                Case "BLNO" : z3441.BLNo = Children(i).Data
                                Case "CONTAINERNO" : z3441.ContainerNo = Children(i).Data
                                Case "SESHIPTYPE" : z3441.seShipType = Children(i).Data
                                Case "CDSHIPTYPE" : z3441.cdShipType = Children(i).Data
                                Case "DATEEXFAC" : z3441.DateEXFac = Children(i).Data
                                Case "DATEETD" : z3441.DateETD = Children(i).Data
                                Case "DATEETA" : z3441.DateETA = Children(i).Data
                                Case "ORDERNO" : z3441.OrderNo = Children(i).Data
                                Case "ORDERNOSEQ" : z3441.OrderNoSeq = Children(i).Data
                                Case "LOADINGCODE" : z3441.LoadingCode = Children(i).Data
                                Case "TRANSFERTYPE" : z3441.TransferType = Children(i).Data
                                Case "CHKDECLARE" : z3441.ChkDeclare = Children(i).Data
                                Case "DATEDECLARE" : z3441.DateDeclare = Children(i).Data
                                Case "CHKSMDOCS" : z3441.ChkSMDocs = Children(i).Data
                                Case "DATESMDOCS" : z3441.DateSMDocs = Children(i).Data
                                Case "CHKLOCALCHARGE" : z3441.ChkLocalCharge = Children(i).Data
                                Case "DATELOCALCHARGE" : z3441.DateLocalCharge = Children(i).Data
                                Case "CHKUPLOADDOCS" : z3441.ChkUploadDocs = Children(i).Data
                                Case "DATEUPLOADDOCS" : z3441.DateUploadDocs = Children(i).Data
                                Case "CHKDOCSHK" : z3441.ChkDocsHK = Children(i).Data
                                Case "DATEDOCSHK" : z3441.DateDocsHK = Children(i).Data
                                Case "CHKDOCSBUYER" : z3441.ChkDocsBuyer = Children(i).Data
                                Case "CHKRECEIVEHK" : z3441.ChkReceiveHK = Children(i).Data
                                Case "CHKPENDING" : z3441.ChkPending = Children(i).Data
                                Case "DATEDOCSBUYER" : z3441.DateDocsBuyer = Children(i).Data
                                Case "CHECKSTATUS" : z3441.CheckStatus = Cdecp(Children(i).Data)
                                Case "QTYORDER" : z3441.QtyOrder = Cdecp(Children(i).Data)
                                Case "QTYORDERSAMPLE" : z3441.QtyOrderSample = Cdecp(Children(i).Data)
                                Case "PRICEORDERFOB" : z3441.PriceOrderFOB = Cdecp(Children(i).Data)
                                Case "TOTALAMTFOB" : z3441.TotalAMTFOB = Cdecp(Children(i).Data)
                                Case "PRICEORDER" : z3441.PriceOrder = Cdecp(Children(i).Data)
                                Case "TOTALAMT" : z3441.TotalAMT = Cdecp(Children(i).Data)
                                Case "TOTALGW" : z3441.TotalGW = Cdecp(Children(i).Data)
                                Case "TOTALNW" : z3441.TotalNW = Cdecp(Children(i).Data)
                                Case "TOTALCBM" : z3441.TotalCBM = Cdecp(Children(i).Data)
                                Case "TOTALQTY" : z3441.TotalQty = Cdecp(Children(i).Data)
                                Case "TOTALCNT" : z3441.TotalCnt = Cdecp(Children(i).Data)
                                Case "CONTNAME1" : z3441.ContName1 = Children(i).Data
                                Case "CONTNAME2" : z3441.ContName2 = Children(i).Data
                                Case "CONTNAME3" : z3441.ContName3 = Children(i).Data
                                Case "CONTNAME4" : z3441.ContName4 = Children(i).Data
                                Case "CONTNAME5" : z3441.ContName5 = Children(i).Data
                                Case "CONTNAME6" : z3441.ContName6 = Children(i).Data
                                Case "CONTNAME7" : z3441.ContName7 = Children(i).Data
                                Case "CONTNAME8" : z3441.ContName8 = Children(i).Data
                                Case "CONTNAME9" : z3441.ContName9 = Children(i).Data
                                Case "CONTNAME10" : z3441.ContName10 = Children(i).Data
                                Case "QTYPL1" : z3441.QtyPL1 = Cdecp(Children(i).Data)
                                Case "QTYPL2" : z3441.QtyPL2 = Cdecp(Children(i).Data)
                                Case "QTYPL3" : z3441.QtyPL3 = Cdecp(Children(i).Data)
                                Case "QTYPL4" : z3441.QtyPL4 = Cdecp(Children(i).Data)
                                Case "QTYPL5" : z3441.QtyPL5 = Cdecp(Children(i).Data)
                                Case "QTYPL6" : z3441.QtyPL6 = Cdecp(Children(i).Data)
                                Case "QTYPL7" : z3441.QtyPL7 = Cdecp(Children(i).Data)
                                Case "QTYPL8" : z3441.QtyPL8 = Cdecp(Children(i).Data)
                                Case "QTYPL9" : z3441.QtyPL9 = Cdecp(Children(i).Data)
                                Case "QTYPL10" : z3441.QtyPL10 = Cdecp(Children(i).Data)
                                Case "SESITE" : z3441.seSite = Children(i).Data
                                Case "CDSITE" : z3441.cdSite = Children(i).Data
                                Case "REMARK" : z3441.Remark = Children(i).Data
                                Case "TIMEINSERT" : z3441.TimeInsert = Children(i).Data
                                Case "TIMEUPDATE" : z3441.TimeUpdate = Children(i).Data
                                Case "DATEUPDATE" : z3441.DateUpdate = Children(i).Data
                                Case "DATEINSERT" : z3441.DateInsert = Children(i).Data
                                Case "INCHARGEINSERT" : z3441.InchargeInsert = Children(i).Data
                                Case "INCHARGEUPDATE" : z3441.InchargeUpdate = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K3441_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW AREA
    '=========================================================================================================================================================
    Public Sub K3441_MOVE(ByRef a3441 As T3441_AREA, ByRef b3441 As T3441_AREA)
        Try
            If trim$(a3441.InvoiceNo) = "" Then b3441.InvoiceNo = "" Else b3441.InvoiceNo = a3441.InvoiceNo
            If trim$(a3441.InvoiceSeq) = "" Then b3441.InvoiceSeq = "" Else b3441.InvoiceSeq = a3441.InvoiceSeq
            If trim$(a3441.SONo) = "" Then b3441.SONo = "" Else b3441.SONo = a3441.SONo
            If trim$(a3441.BookingNo) = "" Then b3441.BookingNo = "" Else b3441.BookingNo = a3441.BookingNo
            If trim$(a3441.LoadingNo) = "" Then b3441.LoadingNo = "" Else b3441.LoadingNo = a3441.LoadingNo
            If trim$(a3441.VesselName) = "" Then b3441.VesselName = "" Else b3441.VesselName = a3441.VesselName
            If trim$(a3441.TradingName) = "" Then b3441.TradingName = "" Else b3441.TradingName = a3441.TradingName
            If trim$(a3441.TradingCode) = "" Then b3441.TradingCode = "" Else b3441.TradingCode = a3441.TradingCode
            If trim$(a3441.ShipmentType) = "" Then b3441.ShipmentType = "" Else b3441.ShipmentType = a3441.ShipmentType
            If trim$(a3441.DateBL) = "" Then b3441.DateBL = "" Else b3441.DateBL = a3441.DateBL
            If trim$(a3441.BLNo) = "" Then b3441.BLNo = "" Else b3441.BLNo = a3441.BLNo
            If trim$(a3441.ContainerNo) = "" Then b3441.ContainerNo = "" Else b3441.ContainerNo = a3441.ContainerNo
            If trim$(a3441.seShipType) = "" Then b3441.seShipType = "" Else b3441.seShipType = a3441.seShipType
            If trim$(a3441.cdShipType) = "" Then b3441.cdShipType = "" Else b3441.cdShipType = a3441.cdShipType
            If trim$(a3441.DateEXFac) = "" Then b3441.DateEXFac = "" Else b3441.DateEXFac = a3441.DateEXFac
            If trim$(a3441.DateETD) = "" Then b3441.DateETD = "" Else b3441.DateETD = a3441.DateETD
            If trim$(a3441.DateETA) = "" Then b3441.DateETA = "" Else b3441.DateETA = a3441.DateETA
            If trim$(a3441.OrderNo) = "" Then b3441.OrderNo = "" Else b3441.OrderNo = a3441.OrderNo
            If trim$(a3441.OrderNoSeq) = "" Then b3441.OrderNoSeq = "" Else b3441.OrderNoSeq = a3441.OrderNoSeq
            If trim$(a3441.LoadingCode) = "" Then b3441.LoadingCode = "" Else b3441.LoadingCode = a3441.LoadingCode
            If trim$(a3441.TransferType) = "" Then b3441.TransferType = "" Else b3441.TransferType = a3441.TransferType
            If trim$(a3441.ChkDeclare) = "" Then b3441.ChkDeclare = "" Else b3441.ChkDeclare = a3441.ChkDeclare
            If trim$(a3441.DateDeclare) = "" Then b3441.DateDeclare = "" Else b3441.DateDeclare = a3441.DateDeclare
            If trim$(a3441.ChkSMDocs) = "" Then b3441.ChkSMDocs = "" Else b3441.ChkSMDocs = a3441.ChkSMDocs
            If trim$(a3441.DateSMDocs) = "" Then b3441.DateSMDocs = "" Else b3441.DateSMDocs = a3441.DateSMDocs
            If trim$(a3441.ChkLocalCharge) = "" Then b3441.ChkLocalCharge = "" Else b3441.ChkLocalCharge = a3441.ChkLocalCharge
            If trim$(a3441.DateLocalCharge) = "" Then b3441.DateLocalCharge = "" Else b3441.DateLocalCharge = a3441.DateLocalCharge
            If trim$(a3441.ChkUploadDocs) = "" Then b3441.ChkUploadDocs = "" Else b3441.ChkUploadDocs = a3441.ChkUploadDocs
            If trim$(a3441.DateUploadDocs) = "" Then b3441.DateUploadDocs = "" Else b3441.DateUploadDocs = a3441.DateUploadDocs
            If trim$(a3441.ChkDocsHK) = "" Then b3441.ChkDocsHK = "" Else b3441.ChkDocsHK = a3441.ChkDocsHK
            If trim$(a3441.DateDocsHK) = "" Then b3441.DateDocsHK = "" Else b3441.DateDocsHK = a3441.DateDocsHK
            If trim$(a3441.ChkDocsBuyer) = "" Then b3441.ChkDocsBuyer = "" Else b3441.ChkDocsBuyer = a3441.ChkDocsBuyer
            If trim$(a3441.ChkReceiveHK) = "" Then b3441.ChkReceiveHK = "" Else b3441.ChkReceiveHK = a3441.ChkReceiveHK
            If trim$(a3441.ChkPending) = "" Then b3441.ChkPending = "" Else b3441.ChkPending = a3441.ChkPending
            If trim$(a3441.DateDocsBuyer) = "" Then b3441.DateDocsBuyer = "" Else b3441.DateDocsBuyer = a3441.DateDocsBuyer
            If trim$(a3441.CheckStatus) = "" Then b3441.CheckStatus = "" Else b3441.CheckStatus = a3441.CheckStatus
            If trim$(a3441.QtyOrder) = "" Then b3441.QtyOrder = "" Else b3441.QtyOrder = a3441.QtyOrder
            If trim$(a3441.QtyOrderSample) = "" Then b3441.QtyOrderSample = "" Else b3441.QtyOrderSample = a3441.QtyOrderSample
            If trim$(a3441.PriceOrderFOB) = "" Then b3441.PriceOrderFOB = "" Else b3441.PriceOrderFOB = a3441.PriceOrderFOB
            If trim$(a3441.TotalAMTFOB) = "" Then b3441.TotalAMTFOB = "" Else b3441.TotalAMTFOB = a3441.TotalAMTFOB
            If trim$(a3441.PriceOrder) = "" Then b3441.PriceOrder = "" Else b3441.PriceOrder = a3441.PriceOrder
            If trim$(a3441.TotalAMT) = "" Then b3441.TotalAMT = "" Else b3441.TotalAMT = a3441.TotalAMT
            If trim$(a3441.TotalGW) = "" Then b3441.TotalGW = "" Else b3441.TotalGW = a3441.TotalGW
            If trim$(a3441.TotalNW) = "" Then b3441.TotalNW = "" Else b3441.TotalNW = a3441.TotalNW
            If trim$(a3441.TotalCBM) = "" Then b3441.TotalCBM = "" Else b3441.TotalCBM = a3441.TotalCBM
            If trim$(a3441.TotalQty) = "" Then b3441.TotalQty = "" Else b3441.TotalQty = a3441.TotalQty
            If trim$(a3441.TotalCnt) = "" Then b3441.TotalCnt = "" Else b3441.TotalCnt = a3441.TotalCnt
            If trim$(a3441.ContName1) = "" Then b3441.ContName1 = "" Else b3441.ContName1 = a3441.ContName1
            If trim$(a3441.ContName2) = "" Then b3441.ContName2 = "" Else b3441.ContName2 = a3441.ContName2
            If trim$(a3441.ContName3) = "" Then b3441.ContName3 = "" Else b3441.ContName3 = a3441.ContName3
            If trim$(a3441.ContName4) = "" Then b3441.ContName4 = "" Else b3441.ContName4 = a3441.ContName4
            If trim$(a3441.ContName5) = "" Then b3441.ContName5 = "" Else b3441.ContName5 = a3441.ContName5
            If trim$(a3441.ContName6) = "" Then b3441.ContName6 = "" Else b3441.ContName6 = a3441.ContName6
            If trim$(a3441.ContName7) = "" Then b3441.ContName7 = "" Else b3441.ContName7 = a3441.ContName7
            If trim$(a3441.ContName8) = "" Then b3441.ContName8 = "" Else b3441.ContName8 = a3441.ContName8
            If trim$(a3441.ContName9) = "" Then b3441.ContName9 = "" Else b3441.ContName9 = a3441.ContName9
            If trim$(a3441.ContName10) = "" Then b3441.ContName10 = "" Else b3441.ContName10 = a3441.ContName10
            If trim$(a3441.QtyPL1) = "" Then b3441.QtyPL1 = "" Else b3441.QtyPL1 = a3441.QtyPL1
            If trim$(a3441.QtyPL2) = "" Then b3441.QtyPL2 = "" Else b3441.QtyPL2 = a3441.QtyPL2
            If trim$(a3441.QtyPL3) = "" Then b3441.QtyPL3 = "" Else b3441.QtyPL3 = a3441.QtyPL3
            If trim$(a3441.QtyPL4) = "" Then b3441.QtyPL4 = "" Else b3441.QtyPL4 = a3441.QtyPL4
            If trim$(a3441.QtyPL5) = "" Then b3441.QtyPL5 = "" Else b3441.QtyPL5 = a3441.QtyPL5
            If trim$(a3441.QtyPL6) = "" Then b3441.QtyPL6 = "" Else b3441.QtyPL6 = a3441.QtyPL6
            If trim$(a3441.QtyPL7) = "" Then b3441.QtyPL7 = "" Else b3441.QtyPL7 = a3441.QtyPL7
            If trim$(a3441.QtyPL8) = "" Then b3441.QtyPL8 = "" Else b3441.QtyPL8 = a3441.QtyPL8
            If trim$(a3441.QtyPL9) = "" Then b3441.QtyPL9 = "" Else b3441.QtyPL9 = a3441.QtyPL9
            If trim$(a3441.QtyPL10) = "" Then b3441.QtyPL10 = "" Else b3441.QtyPL10 = a3441.QtyPL10
            If trim$(a3441.seSite) = "" Then b3441.seSite = "" Else b3441.seSite = a3441.seSite
            If trim$(a3441.cdSite) = "" Then b3441.cdSite = "" Else b3441.cdSite = a3441.cdSite
            If trim$(a3441.Remark) = "" Then b3441.Remark = "" Else b3441.Remark = a3441.Remark
            If trim$(a3441.TimeInsert) = "" Then b3441.TimeInsert = "" Else b3441.TimeInsert = a3441.TimeInsert
            If trim$(a3441.TimeUpdate) = "" Then b3441.TimeUpdate = "" Else b3441.TimeUpdate = a3441.TimeUpdate
            If trim$(a3441.DateUpdate) = "" Then b3441.DateUpdate = "" Else b3441.DateUpdate = a3441.DateUpdate
            If trim$(a3441.DateInsert) = "" Then b3441.DateInsert = "" Else b3441.DateInsert = a3441.DateInsert
            If trim$(a3441.InchargeInsert) = "" Then b3441.InchargeInsert = "" Else b3441.InchargeInsert = a3441.InchargeInsert
            If trim$(a3441.InchargeUpdate) = "" Then b3441.InchargeUpdate = "" Else b3441.InchargeUpdate = a3441.InchargeUpdate
        Catch ex As Exception
            Call MsgBoxP("K3441_MOVE", vbCritical)
        End Try
    End Sub


End Module
