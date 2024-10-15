'=========================================================================================================================================================
'   TABLE : (PFK3461)
'
'      WORKER : PSM GLOBAL ., LTD
'       WORK DATE : 2019 NEW
'       DEVELOPER    : MRNLV
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K3461

Structure T3461_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	InvoiceNo	 AS String	'			char(9)		*
Public 	InvoiceSeq	 AS String	'			char(4)		*
Public 	SONo	 AS String	'			nvarchar(50)
Public 	BookingNo	 AS String	'			nvarchar(50)
Public 	LoadingNo	 AS String	'			nvarchar(50)
Public 	VesselName	 AS String	'			nvarchar(50)
Public 	TradingName	 AS String	'			nvarchar(1000)
Public 	TradingCode	 AS String	'			nvarchar(200)
Public 	ShipmentType	 AS String	'			nvarchar(50)
Public 	DateBL	 AS String	'			nvarchar(50)
Public 	BLNo	 AS String	'			nvarchar(200)
Public 	ContainerNo	 AS String	'			nvarchar(200)
Public 	seShipType	 AS String	'			char(3)
Public 	cdShipType	 AS String	'			char(3)
Public 	DateEXFac	 AS String	'			nvarchar(50)
Public 	DateETD	 AS String	'			nvarchar(50)
Public 	DateETA	 AS String	'			nvarchar(50)
Public 	OrderNo	 AS String	'			char(9)
Public 	OrderNoSeq	 AS String	'			char(3)
Public 	LoadingCode	 AS String	'			char(6)
Public 	TransferType	 AS String	'			char(1)
Public 	ChkDeclare	 AS String	'			nvarchar(50)
Public 	DateDeclare	 AS String	'			nvarchar(50)
Public 	ChkSMDocs	 AS String	'			nvarchar(50)
Public 	DateSMDocs	 AS String	'			nvarchar(50)
Public 	ChkLocalCharge	 AS String	'			nvarchar(50)
Public 	DateLocalCharge	 AS String	'			nvarchar(50)
Public 	ChkUploadDocs	 AS String	'			nvarchar(50)
Public 	DateUploadDocs	 AS String	'			nvarchar(50)
Public 	ChkDocsHK	 AS String	'			nvarchar(50)
Public 	DateDocsHK	 AS String	'			nvarchar(50)
Public 	ChkDocsBuyer	 AS String	'			nvarchar(50)
Public 	ChkReceiveHK	 AS String	'			nvarchar(50)
Public 	ChkPending	 AS String	'			nvarchar(50)
Public 	DateDocsBuyer	 AS String	'			nvarchar(50)
Public 	CheckStatus	 AS Long	'			int
Public 	QtyOrder	 AS Double	'			decimal
Public 	QtyOrderSample	 AS Double	'			decimal
Public 	PriceOrderFOB	 AS Double	'			decimal
Public 	TotalAMTFOB	 AS Double	'			decimal
Public 	PriceOrder	 AS Double	'			decimal
Public 	TotalAMT	 AS Double	'			decimal
Public 	TotalGW	 AS Double	'			decimal
Public 	TotalNW	 AS Double	'			decimal
Public 	TotalCBM	 AS Double	'			decimal
Public 	TotalQty	 AS Double	'			decimal
Public 	TotalCnt	 AS Double	'			decimal
Public 	ContName1	 AS String	'			nvarchar(50)
Public 	ContName2	 AS String	'			nvarchar(50)
Public 	ContName3	 AS String	'			nvarchar(50)
Public 	ContName4	 AS String	'			nvarchar(50)
Public 	ContName5	 AS String	'			nvarchar(50)
Public 	ContName6	 AS String	'			nvarchar(50)
Public 	ContName7	 AS String	'			nvarchar(50)
Public 	ContName8	 AS String	'			nvarchar(50)
Public 	ContName9	 AS String	'			nvarchar(50)
Public 	ContName10	 AS String	'			nvarchar(50)
Public 	QtyPL1	 AS Double	'			decimal
Public 	QtyPL2	 AS Double	'			decimal
Public 	QtyPL3	 AS Double	'			decimal
Public 	QtyPL4	 AS Double	'			decimal
Public 	QtyPL5	 AS Double	'			decimal
Public 	QtyPL6	 AS Double	'			decimal
Public 	QtyPL7	 AS Double	'			decimal
Public 	QtyPL8	 AS Double	'			decimal
Public 	QtyPL9	 AS Double	'			decimal
Public 	QtyPL10	 AS Double	'			decimal
Public 	seSite	 AS String	'			char(3)
Public 	cdSite	 AS String	'			char(3)
Public 	Remark	 AS String	'			nvarchar(500)
Public 	TimeInsert	 AS String	'			char(14)
Public 	TimeUpdate	 AS String	'			char(14)
Public 	DateUpdate	 AS String	'			char(8)
Public 	DateInsert	 AS String	'			char(8)
Public 	InchargeInsert	 AS String	'			char(8)
Public 	InchargeUpdate	 AS String	'			char(8)
'=========================================================================================================================================================
End structure

Public D3461 As T3461_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK3461(INVOICENO AS String, INVOICESEQ AS String) As Boolean
    READ_PFK3461 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK3461 "
    SQL = SQL & " WHERE K3461_InvoiceNo		 = '" & InvoiceNo & "' " 
    SQL = SQL & "   AND K3461_InvoiceSeq		 = '" & InvoiceSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D3461_CLEAR: GoTo SKIP_READ_PFK3461
                
    Call K3461_MOVE(rd)
    READ_PFK3461 = True

SKIP_READ_PFK3461:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK3461",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK3461(INVOICENO AS String, INVOICESEQ AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK3461 "
    SQL = SQL & " WHERE K3461_InvoiceNo		 = '" & InvoiceNo & "' " 
    SQL = SQL & "   AND K3461_InvoiceSeq		 = '" & InvoiceSeq & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK3461",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK3461(z3461 As T3461_AREA) As Boolean
    WRITE_PFK3461 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z3461)
 
    SQL = " INSERT INTO PFK3461 "
    SQL = SQL & " ( "
    SQL = SQL & " K3461_InvoiceNo," 
    SQL = SQL & " K3461_InvoiceSeq," 
    SQL = SQL & " K3461_SONo," 
    SQL = SQL & " K3461_BookingNo," 
    SQL = SQL & " K3461_LoadingNo," 
    SQL = SQL & " K3461_VesselName," 
    SQL = SQL & " K3461_TradingName," 
    SQL = SQL & " K3461_TradingCode," 
    SQL = SQL & " K3461_ShipmentType," 
    SQL = SQL & " K3461_DateBL," 
    SQL = SQL & " K3461_BLNo," 
    SQL = SQL & " K3461_ContainerNo," 
    SQL = SQL & " K3461_seShipType," 
    SQL = SQL & " K3461_cdShipType," 
    SQL = SQL & " K3461_DateEXFac," 
    SQL = SQL & " K3461_DateETD," 
    SQL = SQL & " K3461_DateETA," 
    SQL = SQL & " K3461_OrderNo," 
    SQL = SQL & " K3461_OrderNoSeq," 
    SQL = SQL & " K3461_LoadingCode," 
    SQL = SQL & " K3461_TransferType," 
    SQL = SQL & " K3461_ChkDeclare," 
    SQL = SQL & " K3461_DateDeclare," 
    SQL = SQL & " K3461_ChkSMDocs," 
    SQL = SQL & " K3461_DateSMDocs," 
    SQL = SQL & " K3461_ChkLocalCharge," 
    SQL = SQL & " K3461_DateLocalCharge," 
    SQL = SQL & " K3461_ChkUploadDocs," 
    SQL = SQL & " K3461_DateUploadDocs," 
    SQL = SQL & " K3461_ChkDocsHK," 
    SQL = SQL & " K3461_DateDocsHK," 
    SQL = SQL & " K3461_ChkDocsBuyer," 
    SQL = SQL & " K3461_ChkReceiveHK," 
    SQL = SQL & " K3461_ChkPending," 
    SQL = SQL & " K3461_DateDocsBuyer," 
    SQL = SQL & " K3461_CheckStatus," 
    SQL = SQL & " K3461_QtyOrder," 
    SQL = SQL & " K3461_QtyOrderSample," 
    SQL = SQL & " K3461_PriceOrderFOB," 
    SQL = SQL & " K3461_TotalAMTFOB," 
    SQL = SQL & " K3461_PriceOrder," 
    SQL = SQL & " K3461_TotalAMT," 
    SQL = SQL & " K3461_TotalGW," 
    SQL = SQL & " K3461_TotalNW," 
    SQL = SQL & " K3461_TotalCBM," 
    SQL = SQL & " K3461_TotalQty," 
    SQL = SQL & " K3461_TotalCnt," 
    SQL = SQL & " K3461_ContName1," 
    SQL = SQL & " K3461_ContName2," 
    SQL = SQL & " K3461_ContName3," 
    SQL = SQL & " K3461_ContName4," 
    SQL = SQL & " K3461_ContName5," 
    SQL = SQL & " K3461_ContName6," 
    SQL = SQL & " K3461_ContName7," 
    SQL = SQL & " K3461_ContName8," 
    SQL = SQL & " K3461_ContName9," 
    SQL = SQL & " K3461_ContName10," 
    SQL = SQL & " K3461_QtyPL1," 
    SQL = SQL & " K3461_QtyPL2," 
    SQL = SQL & " K3461_QtyPL3," 
    SQL = SQL & " K3461_QtyPL4," 
    SQL = SQL & " K3461_QtyPL5," 
    SQL = SQL & " K3461_QtyPL6," 
    SQL = SQL & " K3461_QtyPL7," 
    SQL = SQL & " K3461_QtyPL8," 
    SQL = SQL & " K3461_QtyPL9," 
    SQL = SQL & " K3461_QtyPL10," 
    SQL = SQL & " K3461_seSite," 
    SQL = SQL & " K3461_cdSite," 
    SQL = SQL & " K3461_Remark," 
    SQL = SQL & " K3461_TimeInsert," 
    SQL = SQL & " K3461_TimeUpdate," 
    SQL = SQL & " K3461_DateUpdate," 
    SQL = SQL & " K3461_DateInsert," 
    SQL = SQL & " K3461_InchargeInsert," 
    SQL = SQL & " K3461_InchargeUpdate " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z3461.InvoiceNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3461.InvoiceSeq) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3461.SONo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3461.BookingNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3461.LoadingNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3461.VesselName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3461.TradingName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3461.TradingCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3461.ShipmentType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3461.DateBL) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3461.BLNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3461.ContainerNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3461.seShipType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3461.cdShipType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3461.DateEXFac) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3461.DateETD) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3461.DateETA) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3461.OrderNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3461.OrderNoSeq) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3461.LoadingCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3461.TransferType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3461.ChkDeclare) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3461.DateDeclare) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3461.ChkSMDocs) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3461.DateSMDocs) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3461.ChkLocalCharge) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3461.DateLocalCharge) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3461.ChkUploadDocs) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3461.DateUploadDocs) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3461.ChkDocsHK) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3461.DateDocsHK) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3461.ChkDocsBuyer) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3461.ChkReceiveHK) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3461.ChkPending) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3461.DateDocsBuyer) & "', "  
    SQL = SQL & "   " & FormatSQL(z3461.CheckStatus) & ", "  
    SQL = SQL & "   " & FormatSQL(z3461.QtyOrder) & ", "  
    SQL = SQL & "   " & FormatSQL(z3461.QtyOrderSample) & ", "  
    SQL = SQL & "   " & FormatSQL(z3461.PriceOrderFOB) & ", "  
    SQL = SQL & "   " & FormatSQL(z3461.TotalAMTFOB) & ", "  
    SQL = SQL & "   " & FormatSQL(z3461.PriceOrder) & ", "  
    SQL = SQL & "   " & FormatSQL(z3461.TotalAMT) & ", "  
    SQL = SQL & "   " & FormatSQL(z3461.TotalGW) & ", "  
    SQL = SQL & "   " & FormatSQL(z3461.TotalNW) & ", "  
    SQL = SQL & "   " & FormatSQL(z3461.TotalCBM) & ", "  
    SQL = SQL & "   " & FormatSQL(z3461.TotalQty) & ", "  
    SQL = SQL & "   " & FormatSQL(z3461.TotalCnt) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z3461.ContName1) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3461.ContName2) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3461.ContName3) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3461.ContName4) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3461.ContName5) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3461.ContName6) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3461.ContName7) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3461.ContName8) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3461.ContName9) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3461.ContName10) & "', "  
    SQL = SQL & "   " & FormatSQL(z3461.QtyPL1) & ", "  
    SQL = SQL & "   " & FormatSQL(z3461.QtyPL2) & ", "  
    SQL = SQL & "   " & FormatSQL(z3461.QtyPL3) & ", "  
    SQL = SQL & "   " & FormatSQL(z3461.QtyPL4) & ", "  
    SQL = SQL & "   " & FormatSQL(z3461.QtyPL5) & ", "  
    SQL = SQL & "   " & FormatSQL(z3461.QtyPL6) & ", "  
    SQL = SQL & "   " & FormatSQL(z3461.QtyPL7) & ", "  
    SQL = SQL & "   " & FormatSQL(z3461.QtyPL8) & ", "  
    SQL = SQL & "   " & FormatSQL(z3461.QtyPL9) & ", "  
    SQL = SQL & "   " & FormatSQL(z3461.QtyPL10) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z3461.seSite) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3461.cdSite) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3461.Remark) & "', "  
    SQL = SQL & "  N'" & FormatSQL(PUB.TIME) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3461.TimeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3461.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(PUB.DAT) & "', "  
    SQL = SQL & "  N'" & FormatSQL(PUB.SAW) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3461.InchargeUpdate) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK3461 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK3461",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK3461(z3461 As T3461_AREA) As Boolean
    REWRITE_PFK3461 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z3461)
   
    SQL = " UPDATE PFK3461 SET "
    SQL = SQL & "    K3461_SONo      = N'" & FormatSQL(z3461.SONo) & "', " 
    SQL = SQL & "    K3461_BookingNo      = N'" & FormatSQL(z3461.BookingNo) & "', " 
    SQL = SQL & "    K3461_LoadingNo      = N'" & FormatSQL(z3461.LoadingNo) & "', " 
    SQL = SQL & "    K3461_VesselName      = N'" & FormatSQL(z3461.VesselName) & "', " 
    SQL = SQL & "    K3461_TradingName      = N'" & FormatSQL(z3461.TradingName) & "', " 
    SQL = SQL & "    K3461_TradingCode      = N'" & FormatSQL(z3461.TradingCode) & "', " 
    SQL = SQL & "    K3461_ShipmentType      = N'" & FormatSQL(z3461.ShipmentType) & "', " 
    SQL = SQL & "    K3461_DateBL      = N'" & FormatSQL(z3461.DateBL) & "', " 
    SQL = SQL & "    K3461_BLNo      = N'" & FormatSQL(z3461.BLNo) & "', " 
    SQL = SQL & "    K3461_ContainerNo      = N'" & FormatSQL(z3461.ContainerNo) & "', " 
    SQL = SQL & "    K3461_seShipType      = N'" & FormatSQL(z3461.seShipType) & "', " 
    SQL = SQL & "    K3461_cdShipType      = N'" & FormatSQL(z3461.cdShipType) & "', " 
    SQL = SQL & "    K3461_DateEXFac      = N'" & FormatSQL(z3461.DateEXFac) & "', " 
    SQL = SQL & "    K3461_DateETD      = N'" & FormatSQL(z3461.DateETD) & "', " 
    SQL = SQL & "    K3461_DateETA      = N'" & FormatSQL(z3461.DateETA) & "', " 
    SQL = SQL & "    K3461_OrderNo      = N'" & FormatSQL(z3461.OrderNo) & "', " 
    SQL = SQL & "    K3461_OrderNoSeq      = N'" & FormatSQL(z3461.OrderNoSeq) & "', " 
    SQL = SQL & "    K3461_LoadingCode      = N'" & FormatSQL(z3461.LoadingCode) & "', " 
    SQL = SQL & "    K3461_TransferType      = N'" & FormatSQL(z3461.TransferType) & "', " 
    SQL = SQL & "    K3461_ChkDeclare      = N'" & FormatSQL(z3461.ChkDeclare) & "', " 
    SQL = SQL & "    K3461_DateDeclare      = N'" & FormatSQL(z3461.DateDeclare) & "', " 
    SQL = SQL & "    K3461_ChkSMDocs      = N'" & FormatSQL(z3461.ChkSMDocs) & "', " 
    SQL = SQL & "    K3461_DateSMDocs      = N'" & FormatSQL(z3461.DateSMDocs) & "', " 
    SQL = SQL & "    K3461_ChkLocalCharge      = N'" & FormatSQL(z3461.ChkLocalCharge) & "', " 
    SQL = SQL & "    K3461_DateLocalCharge      = N'" & FormatSQL(z3461.DateLocalCharge) & "', " 
    SQL = SQL & "    K3461_ChkUploadDocs      = N'" & FormatSQL(z3461.ChkUploadDocs) & "', " 
    SQL = SQL & "    K3461_DateUploadDocs      = N'" & FormatSQL(z3461.DateUploadDocs) & "', " 
    SQL = SQL & "    K3461_ChkDocsHK      = N'" & FormatSQL(z3461.ChkDocsHK) & "', " 
    SQL = SQL & "    K3461_DateDocsHK      = N'" & FormatSQL(z3461.DateDocsHK) & "', " 
    SQL = SQL & "    K3461_ChkDocsBuyer      = N'" & FormatSQL(z3461.ChkDocsBuyer) & "', " 
    SQL = SQL & "    K3461_ChkReceiveHK      = N'" & FormatSQL(z3461.ChkReceiveHK) & "', " 
    SQL = SQL & "    K3461_ChkPending      = N'" & FormatSQL(z3461.ChkPending) & "', " 
    SQL = SQL & "    K3461_DateDocsBuyer      = N'" & FormatSQL(z3461.DateDocsBuyer) & "', " 
    SQL = SQL & "    K3461_CheckStatus      =  " & FormatSQL(z3461.CheckStatus) & ", " 
    SQL = SQL & "    K3461_QtyOrder      =  " & FormatSQL(z3461.QtyOrder) & ", " 
    SQL = SQL & "    K3461_QtyOrderSample      =  " & FormatSQL(z3461.QtyOrderSample) & ", " 
    SQL = SQL & "    K3461_PriceOrderFOB      =  " & FormatSQL(z3461.PriceOrderFOB) & ", " 
    SQL = SQL & "    K3461_TotalAMTFOB      =  " & FormatSQL(z3461.TotalAMTFOB) & ", " 
    SQL = SQL & "    K3461_PriceOrder      =  " & FormatSQL(z3461.PriceOrder) & ", " 
    SQL = SQL & "    K3461_TotalAMT      =  " & FormatSQL(z3461.TotalAMT) & ", " 
    SQL = SQL & "    K3461_TotalGW      =  " & FormatSQL(z3461.TotalGW) & ", " 
    SQL = SQL & "    K3461_TotalNW      =  " & FormatSQL(z3461.TotalNW) & ", " 
    SQL = SQL & "    K3461_TotalCBM      =  " & FormatSQL(z3461.TotalCBM) & ", " 
    SQL = SQL & "    K3461_TotalQty      =  " & FormatSQL(z3461.TotalQty) & ", " 
    SQL = SQL & "    K3461_TotalCnt      =  " & FormatSQL(z3461.TotalCnt) & ", " 
    SQL = SQL & "    K3461_ContName1      = N'" & FormatSQL(z3461.ContName1) & "', " 
    SQL = SQL & "    K3461_ContName2      = N'" & FormatSQL(z3461.ContName2) & "', " 
    SQL = SQL & "    K3461_ContName3      = N'" & FormatSQL(z3461.ContName3) & "', " 
    SQL = SQL & "    K3461_ContName4      = N'" & FormatSQL(z3461.ContName4) & "', " 
    SQL = SQL & "    K3461_ContName5      = N'" & FormatSQL(z3461.ContName5) & "', " 
    SQL = SQL & "    K3461_ContName6      = N'" & FormatSQL(z3461.ContName6) & "', " 
    SQL = SQL & "    K3461_ContName7      = N'" & FormatSQL(z3461.ContName7) & "', " 
    SQL = SQL & "    K3461_ContName8      = N'" & FormatSQL(z3461.ContName8) & "', " 
    SQL = SQL & "    K3461_ContName9      = N'" & FormatSQL(z3461.ContName9) & "', " 
    SQL = SQL & "    K3461_ContName10      = N'" & FormatSQL(z3461.ContName10) & "', " 
    SQL = SQL & "    K3461_QtyPL1      =  " & FormatSQL(z3461.QtyPL1) & ", " 
    SQL = SQL & "    K3461_QtyPL2      =  " & FormatSQL(z3461.QtyPL2) & ", " 
    SQL = SQL & "    K3461_QtyPL3      =  " & FormatSQL(z3461.QtyPL3) & ", " 
    SQL = SQL & "    K3461_QtyPL4      =  " & FormatSQL(z3461.QtyPL4) & ", " 
    SQL = SQL & "    K3461_QtyPL5      =  " & FormatSQL(z3461.QtyPL5) & ", " 
    SQL = SQL & "    K3461_QtyPL6      =  " & FormatSQL(z3461.QtyPL6) & ", " 
    SQL = SQL & "    K3461_QtyPL7      =  " & FormatSQL(z3461.QtyPL7) & ", " 
    SQL = SQL & "    K3461_QtyPL8      =  " & FormatSQL(z3461.QtyPL8) & ", " 
    SQL = SQL & "    K3461_QtyPL9      =  " & FormatSQL(z3461.QtyPL9) & ", " 
    SQL = SQL & "    K3461_QtyPL10      =  " & FormatSQL(z3461.QtyPL10) & ", " 
    SQL = SQL & "    K3461_seSite      = N'" & FormatSQL(z3461.seSite) & "', " 
    SQL = SQL & "    K3461_cdSite      = N'" & FormatSQL(z3461.cdSite) & "', " 
    SQL = SQL & "    K3461_Remark      = N'" & FormatSQL(z3461.Remark) & "', " 
    SQL = SQL & "    K3461_TimeInsert      = N'" & FormatSQL(z3461.TimeInsert) & "', " 
    SQL = SQL & "    K3461_TimeUpdate      = N'" & FormatSQL(PUB.TIME) & "', " 
    SQL = SQL & "    K3461_DateUpdate      = N'" & FormatSQL(PUB.DAT) & "', " 
    SQL = SQL & "    K3461_DateInsert      = N'" & FormatSQL(z3461.DateInsert) & "', " 
    SQL = SQL & "    K3461_InchargeInsert      = N'" & FormatSQL(z3461.InchargeInsert) & "', " 
    SQL = SQL & "    K3461_InchargeUpdate      = N'" & FormatSQL(PUB.SAW) & "'  " 
    SQL = SQL & " WHERE K3461_InvoiceNo		 = '" & z3461.InvoiceNo & "' " 
    SQL = SQL & "   AND K3461_InvoiceSeq		 = '" & z3461.InvoiceSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  

    REWRITE_PFK3461 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK3461",vbCritical)

  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK3461(z3461 As T3461_AREA) As Boolean
    DELETE_PFK3461 = False

   Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z3461)
      
        SQL = " DELETE FROM PFK3461  "
    SQL = SQL & " WHERE K3461_InvoiceNo		 = '" & z3461.InvoiceNo & "' " 
    SQL = SQL & "   AND K3461_InvoiceSeq		 = '" & z3461.InvoiceSeq & "' " 

    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK3461 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK3461",vbCritical)
Finally
        Call GetFullInformation("PFK3461", "D", SQL)
  End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D3461_CLEAR()
Try
    
   D3461.InvoiceNo = ""
   D3461.InvoiceSeq = ""
   D3461.SONo = ""
   D3461.BookingNo = ""
   D3461.LoadingNo = ""
   D3461.VesselName = ""
   D3461.TradingName = ""
   D3461.TradingCode = ""
   D3461.ShipmentType = ""
   D3461.DateBL = ""
   D3461.BLNo = ""
   D3461.ContainerNo = ""
   D3461.seShipType = ""
   D3461.cdShipType = ""
   D3461.DateEXFac = ""
   D3461.DateETD = ""
   D3461.DateETA = ""
   D3461.OrderNo = ""
   D3461.OrderNoSeq = ""
   D3461.LoadingCode = ""
   D3461.TransferType = ""
   D3461.ChkDeclare = ""
   D3461.DateDeclare = ""
   D3461.ChkSMDocs = ""
   D3461.DateSMDocs = ""
   D3461.ChkLocalCharge = ""
   D3461.DateLocalCharge = ""
   D3461.ChkUploadDocs = ""
   D3461.DateUploadDocs = ""
   D3461.ChkDocsHK = ""
   D3461.DateDocsHK = ""
   D3461.ChkDocsBuyer = ""
   D3461.ChkReceiveHK = ""
   D3461.ChkPending = ""
   D3461.DateDocsBuyer = ""
    D3461.CheckStatus = 0 
    D3461.QtyOrder = 0 
    D3461.QtyOrderSample = 0 
    D3461.PriceOrderFOB = 0 
    D3461.TotalAMTFOB = 0 
    D3461.PriceOrder = 0 
    D3461.TotalAMT = 0 
    D3461.TotalGW = 0 
    D3461.TotalNW = 0 
    D3461.TotalCBM = 0 
    D3461.TotalQty = 0 
    D3461.TotalCnt = 0 
   D3461.ContName1 = ""
   D3461.ContName2 = ""
   D3461.ContName3 = ""
   D3461.ContName4 = ""
   D3461.ContName5 = ""
   D3461.ContName6 = ""
   D3461.ContName7 = ""
   D3461.ContName8 = ""
   D3461.ContName9 = ""
   D3461.ContName10 = ""
    D3461.QtyPL1 = 0 
    D3461.QtyPL2 = 0 
    D3461.QtyPL3 = 0 
    D3461.QtyPL4 = 0 
    D3461.QtyPL5 = 0 
    D3461.QtyPL6 = 0 
    D3461.QtyPL7 = 0 
    D3461.QtyPL8 = 0 
    D3461.QtyPL9 = 0 
    D3461.QtyPL10 = 0 
   D3461.seSite = ""
   D3461.cdSite = ""
   D3461.Remark = ""
   D3461.TimeInsert = ""
   D3461.TimeUpdate = ""
   D3461.DateUpdate = ""
   D3461.DateInsert = ""
   D3461.InchargeInsert = ""
   D3461.InchargeUpdate = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D3461_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x3461 As T3461_AREA)
Try
    
    x3461.InvoiceNo = trim$(  x3461.InvoiceNo)
    x3461.InvoiceSeq = trim$(  x3461.InvoiceSeq)
    x3461.SONo = trim$(  x3461.SONo)
    x3461.BookingNo = trim$(  x3461.BookingNo)
    x3461.LoadingNo = trim$(  x3461.LoadingNo)
    x3461.VesselName = trim$(  x3461.VesselName)
    x3461.TradingName = trim$(  x3461.TradingName)
    x3461.TradingCode = trim$(  x3461.TradingCode)
    x3461.ShipmentType = trim$(  x3461.ShipmentType)
    x3461.DateBL = trim$(  x3461.DateBL)
    x3461.BLNo = trim$(  x3461.BLNo)
    x3461.ContainerNo = trim$(  x3461.ContainerNo)
    x3461.seShipType = trim$(  x3461.seShipType)
    x3461.cdShipType = trim$(  x3461.cdShipType)
    x3461.DateEXFac = trim$(  x3461.DateEXFac)
    x3461.DateETD = trim$(  x3461.DateETD)
    x3461.DateETA = trim$(  x3461.DateETA)
    x3461.OrderNo = trim$(  x3461.OrderNo)
    x3461.OrderNoSeq = trim$(  x3461.OrderNoSeq)
    x3461.LoadingCode = trim$(  x3461.LoadingCode)
    x3461.TransferType = trim$(  x3461.TransferType)
    x3461.ChkDeclare = trim$(  x3461.ChkDeclare)
    x3461.DateDeclare = trim$(  x3461.DateDeclare)
    x3461.ChkSMDocs = trim$(  x3461.ChkSMDocs)
    x3461.DateSMDocs = trim$(  x3461.DateSMDocs)
    x3461.ChkLocalCharge = trim$(  x3461.ChkLocalCharge)
    x3461.DateLocalCharge = trim$(  x3461.DateLocalCharge)
    x3461.ChkUploadDocs = trim$(  x3461.ChkUploadDocs)
    x3461.DateUploadDocs = trim$(  x3461.DateUploadDocs)
    x3461.ChkDocsHK = trim$(  x3461.ChkDocsHK)
    x3461.DateDocsHK = trim$(  x3461.DateDocsHK)
    x3461.ChkDocsBuyer = trim$(  x3461.ChkDocsBuyer)
    x3461.ChkReceiveHK = trim$(  x3461.ChkReceiveHK)
    x3461.ChkPending = trim$(  x3461.ChkPending)
    x3461.DateDocsBuyer = trim$(  x3461.DateDocsBuyer)
    x3461.CheckStatus = trim$(  x3461.CheckStatus)
    x3461.QtyOrder = trim$(  x3461.QtyOrder)
    x3461.QtyOrderSample = trim$(  x3461.QtyOrderSample)
    x3461.PriceOrderFOB = trim$(  x3461.PriceOrderFOB)
    x3461.TotalAMTFOB = trim$(  x3461.TotalAMTFOB)
    x3461.PriceOrder = trim$(  x3461.PriceOrder)
    x3461.TotalAMT = trim$(  x3461.TotalAMT)
    x3461.TotalGW = trim$(  x3461.TotalGW)
    x3461.TotalNW = trim$(  x3461.TotalNW)
    x3461.TotalCBM = trim$(  x3461.TotalCBM)
    x3461.TotalQty = trim$(  x3461.TotalQty)
    x3461.TotalCnt = trim$(  x3461.TotalCnt)
    x3461.ContName1 = trim$(  x3461.ContName1)
    x3461.ContName2 = trim$(  x3461.ContName2)
    x3461.ContName3 = trim$(  x3461.ContName3)
    x3461.ContName4 = trim$(  x3461.ContName4)
    x3461.ContName5 = trim$(  x3461.ContName5)
    x3461.ContName6 = trim$(  x3461.ContName6)
    x3461.ContName7 = trim$(  x3461.ContName7)
    x3461.ContName8 = trim$(  x3461.ContName8)
    x3461.ContName9 = trim$(  x3461.ContName9)
    x3461.ContName10 = trim$(  x3461.ContName10)
    x3461.QtyPL1 = trim$(  x3461.QtyPL1)
    x3461.QtyPL2 = trim$(  x3461.QtyPL2)
    x3461.QtyPL3 = trim$(  x3461.QtyPL3)
    x3461.QtyPL4 = trim$(  x3461.QtyPL4)
    x3461.QtyPL5 = trim$(  x3461.QtyPL5)
    x3461.QtyPL6 = trim$(  x3461.QtyPL6)
    x3461.QtyPL7 = trim$(  x3461.QtyPL7)
    x3461.QtyPL8 = trim$(  x3461.QtyPL8)
    x3461.QtyPL9 = trim$(  x3461.QtyPL9)
    x3461.QtyPL10 = trim$(  x3461.QtyPL10)
    x3461.seSite = trim$(  x3461.seSite)
    x3461.cdSite = trim$(  x3461.cdSite)
    x3461.Remark = trim$(  x3461.Remark)
    x3461.TimeInsert = trim$(  x3461.TimeInsert)
    x3461.TimeUpdate = trim$(  x3461.TimeUpdate)
    x3461.DateUpdate = trim$(  x3461.DateUpdate)
    x3461.DateInsert = trim$(  x3461.DateInsert)
    x3461.InchargeInsert = trim$(  x3461.InchargeInsert)
    x3461.InchargeUpdate = trim$(  x3461.InchargeUpdate)
     
    If trim$( x3461.InvoiceNo ) = "" Then x3461.InvoiceNo = Space(1) 
    If trim$( x3461.InvoiceSeq ) = "" Then x3461.InvoiceSeq = Space(1) 
    If trim$( x3461.SONo ) = "" Then x3461.SONo = Space(1) 
    If trim$( x3461.BookingNo ) = "" Then x3461.BookingNo = Space(1) 
    If trim$( x3461.LoadingNo ) = "" Then x3461.LoadingNo = Space(1) 
    If trim$( x3461.VesselName ) = "" Then x3461.VesselName = Space(1) 
    If trim$( x3461.TradingName ) = "" Then x3461.TradingName = Space(1) 
    If trim$( x3461.TradingCode ) = "" Then x3461.TradingCode = Space(1) 
    If trim$( x3461.ShipmentType ) = "" Then x3461.ShipmentType = Space(1) 
    If trim$( x3461.DateBL ) = "" Then x3461.DateBL = Space(1) 
    If trim$( x3461.BLNo ) = "" Then x3461.BLNo = Space(1) 
    If trim$( x3461.ContainerNo ) = "" Then x3461.ContainerNo = Space(1) 
    If trim$( x3461.seShipType ) = "" Then x3461.seShipType = Space(1) 
    If trim$( x3461.cdShipType ) = "" Then x3461.cdShipType = Space(1) 
    If trim$( x3461.DateEXFac ) = "" Then x3461.DateEXFac = Space(1) 
    If trim$( x3461.DateETD ) = "" Then x3461.DateETD = Space(1) 
    If trim$( x3461.DateETA ) = "" Then x3461.DateETA = Space(1) 
    If trim$( x3461.OrderNo ) = "" Then x3461.OrderNo = Space(1) 
    If trim$( x3461.OrderNoSeq ) = "" Then x3461.OrderNoSeq = Space(1) 
    If trim$( x3461.LoadingCode ) = "" Then x3461.LoadingCode = Space(1) 
    If trim$( x3461.TransferType ) = "" Then x3461.TransferType = Space(1) 
    If trim$( x3461.ChkDeclare ) = "" Then x3461.ChkDeclare = Space(1) 
    If trim$( x3461.DateDeclare ) = "" Then x3461.DateDeclare = Space(1) 
    If trim$( x3461.ChkSMDocs ) = "" Then x3461.ChkSMDocs = Space(1) 
    If trim$( x3461.DateSMDocs ) = "" Then x3461.DateSMDocs = Space(1) 
    If trim$( x3461.ChkLocalCharge ) = "" Then x3461.ChkLocalCharge = Space(1) 
    If trim$( x3461.DateLocalCharge ) = "" Then x3461.DateLocalCharge = Space(1) 
    If trim$( x3461.ChkUploadDocs ) = "" Then x3461.ChkUploadDocs = Space(1) 
    If trim$( x3461.DateUploadDocs ) = "" Then x3461.DateUploadDocs = Space(1) 
    If trim$( x3461.ChkDocsHK ) = "" Then x3461.ChkDocsHK = Space(1) 
    If trim$( x3461.DateDocsHK ) = "" Then x3461.DateDocsHK = Space(1) 
    If trim$( x3461.ChkDocsBuyer ) = "" Then x3461.ChkDocsBuyer = Space(1) 
    If trim$( x3461.ChkReceiveHK ) = "" Then x3461.ChkReceiveHK = Space(1) 
    If trim$( x3461.ChkPending ) = "" Then x3461.ChkPending = Space(1) 
    If trim$( x3461.DateDocsBuyer ) = "" Then x3461.DateDocsBuyer = Space(1) 
    If trim$( x3461.CheckStatus ) = "" Then x3461.CheckStatus = 0 
    If trim$( x3461.QtyOrder ) = "" Then x3461.QtyOrder = 0 
    If trim$( x3461.QtyOrderSample ) = "" Then x3461.QtyOrderSample = 0 
    If trim$( x3461.PriceOrderFOB ) = "" Then x3461.PriceOrderFOB = 0 
    If trim$( x3461.TotalAMTFOB ) = "" Then x3461.TotalAMTFOB = 0 
    If trim$( x3461.PriceOrder ) = "" Then x3461.PriceOrder = 0 
    If trim$( x3461.TotalAMT ) = "" Then x3461.TotalAMT = 0 
    If trim$( x3461.TotalGW ) = "" Then x3461.TotalGW = 0 
    If trim$( x3461.TotalNW ) = "" Then x3461.TotalNW = 0 
    If trim$( x3461.TotalCBM ) = "" Then x3461.TotalCBM = 0 
    If trim$( x3461.TotalQty ) = "" Then x3461.TotalQty = 0 
    If trim$( x3461.TotalCnt ) = "" Then x3461.TotalCnt = 0 
    If trim$( x3461.ContName1 ) = "" Then x3461.ContName1 = Space(1) 
    If trim$( x3461.ContName2 ) = "" Then x3461.ContName2 = Space(1) 
    If trim$( x3461.ContName3 ) = "" Then x3461.ContName3 = Space(1) 
    If trim$( x3461.ContName4 ) = "" Then x3461.ContName4 = Space(1) 
    If trim$( x3461.ContName5 ) = "" Then x3461.ContName5 = Space(1) 
    If trim$( x3461.ContName6 ) = "" Then x3461.ContName6 = Space(1) 
    If trim$( x3461.ContName7 ) = "" Then x3461.ContName7 = Space(1) 
    If trim$( x3461.ContName8 ) = "" Then x3461.ContName8 = Space(1) 
    If trim$( x3461.ContName9 ) = "" Then x3461.ContName9 = Space(1) 
    If trim$( x3461.ContName10 ) = "" Then x3461.ContName10 = Space(1) 
    If trim$( x3461.QtyPL1 ) = "" Then x3461.QtyPL1 = 0 
    If trim$( x3461.QtyPL2 ) = "" Then x3461.QtyPL2 = 0 
    If trim$( x3461.QtyPL3 ) = "" Then x3461.QtyPL3 = 0 
    If trim$( x3461.QtyPL4 ) = "" Then x3461.QtyPL4 = 0 
    If trim$( x3461.QtyPL5 ) = "" Then x3461.QtyPL5 = 0 
    If trim$( x3461.QtyPL6 ) = "" Then x3461.QtyPL6 = 0 
    If trim$( x3461.QtyPL7 ) = "" Then x3461.QtyPL7 = 0 
    If trim$( x3461.QtyPL8 ) = "" Then x3461.QtyPL8 = 0 
    If trim$( x3461.QtyPL9 ) = "" Then x3461.QtyPL9 = 0 
    If trim$( x3461.QtyPL10 ) = "" Then x3461.QtyPL10 = 0 
    If trim$( x3461.seSite ) = "" Then x3461.seSite = Space(1) 
    If trim$( x3461.cdSite ) = "" Then x3461.cdSite = Space(1) 
    If trim$( x3461.Remark ) = "" Then x3461.Remark = Space(1) 
    If trim$( x3461.TimeInsert ) = "" Then x3461.TimeInsert = Space(1) 
    If trim$( x3461.TimeUpdate ) = "" Then x3461.TimeUpdate = Space(1) 
    If trim$( x3461.DateUpdate ) = "" Then x3461.DateUpdate = Space(1) 
    If trim$( x3461.DateInsert ) = "" Then x3461.DateInsert = Space(1) 
    If trim$( x3461.InchargeInsert ) = "" Then x3461.InchargeInsert = Space(1) 
    If trim$( x3461.InchargeUpdate ) = "" Then x3461.InchargeUpdate = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K3461_MOVE(rs3461 As SqlClient.SqlDataReader)
Try

    call D3461_CLEAR()   

    If IsdbNull(rs3461!K3461_InvoiceNo) = False Then D3461.InvoiceNo = Trim$(rs3461!K3461_InvoiceNo)
    If IsdbNull(rs3461!K3461_InvoiceSeq) = False Then D3461.InvoiceSeq = Trim$(rs3461!K3461_InvoiceSeq)
    If IsdbNull(rs3461!K3461_SONo) = False Then D3461.SONo = Trim$(rs3461!K3461_SONo)
    If IsdbNull(rs3461!K3461_BookingNo) = False Then D3461.BookingNo = Trim$(rs3461!K3461_BookingNo)
    If IsdbNull(rs3461!K3461_LoadingNo) = False Then D3461.LoadingNo = Trim$(rs3461!K3461_LoadingNo)
    If IsdbNull(rs3461!K3461_VesselName) = False Then D3461.VesselName = Trim$(rs3461!K3461_VesselName)
    If IsdbNull(rs3461!K3461_TradingName) = False Then D3461.TradingName = Trim$(rs3461!K3461_TradingName)
    If IsdbNull(rs3461!K3461_TradingCode) = False Then D3461.TradingCode = Trim$(rs3461!K3461_TradingCode)
    If IsdbNull(rs3461!K3461_ShipmentType) = False Then D3461.ShipmentType = Trim$(rs3461!K3461_ShipmentType)
    If IsdbNull(rs3461!K3461_DateBL) = False Then D3461.DateBL = Trim$(rs3461!K3461_DateBL)
    If IsdbNull(rs3461!K3461_BLNo) = False Then D3461.BLNo = Trim$(rs3461!K3461_BLNo)
    If IsdbNull(rs3461!K3461_ContainerNo) = False Then D3461.ContainerNo = Trim$(rs3461!K3461_ContainerNo)
    If IsdbNull(rs3461!K3461_seShipType) = False Then D3461.seShipType = Trim$(rs3461!K3461_seShipType)
    If IsdbNull(rs3461!K3461_cdShipType) = False Then D3461.cdShipType = Trim$(rs3461!K3461_cdShipType)
    If IsdbNull(rs3461!K3461_DateEXFac) = False Then D3461.DateEXFac = Trim$(rs3461!K3461_DateEXFac)
    If IsdbNull(rs3461!K3461_DateETD) = False Then D3461.DateETD = Trim$(rs3461!K3461_DateETD)
    If IsdbNull(rs3461!K3461_DateETA) = False Then D3461.DateETA = Trim$(rs3461!K3461_DateETA)
    If IsdbNull(rs3461!K3461_OrderNo) = False Then D3461.OrderNo = Trim$(rs3461!K3461_OrderNo)
    If IsdbNull(rs3461!K3461_OrderNoSeq) = False Then D3461.OrderNoSeq = Trim$(rs3461!K3461_OrderNoSeq)
    If IsdbNull(rs3461!K3461_LoadingCode) = False Then D3461.LoadingCode = Trim$(rs3461!K3461_LoadingCode)
    If IsdbNull(rs3461!K3461_TransferType) = False Then D3461.TransferType = Trim$(rs3461!K3461_TransferType)
    If IsdbNull(rs3461!K3461_ChkDeclare) = False Then D3461.ChkDeclare = Trim$(rs3461!K3461_ChkDeclare)
    If IsdbNull(rs3461!K3461_DateDeclare) = False Then D3461.DateDeclare = Trim$(rs3461!K3461_DateDeclare)
    If IsdbNull(rs3461!K3461_ChkSMDocs) = False Then D3461.ChkSMDocs = Trim$(rs3461!K3461_ChkSMDocs)
    If IsdbNull(rs3461!K3461_DateSMDocs) = False Then D3461.DateSMDocs = Trim$(rs3461!K3461_DateSMDocs)
    If IsdbNull(rs3461!K3461_ChkLocalCharge) = False Then D3461.ChkLocalCharge = Trim$(rs3461!K3461_ChkLocalCharge)
    If IsdbNull(rs3461!K3461_DateLocalCharge) = False Then D3461.DateLocalCharge = Trim$(rs3461!K3461_DateLocalCharge)
    If IsdbNull(rs3461!K3461_ChkUploadDocs) = False Then D3461.ChkUploadDocs = Trim$(rs3461!K3461_ChkUploadDocs)
    If IsdbNull(rs3461!K3461_DateUploadDocs) = False Then D3461.DateUploadDocs = Trim$(rs3461!K3461_DateUploadDocs)
    If IsdbNull(rs3461!K3461_ChkDocsHK) = False Then D3461.ChkDocsHK = Trim$(rs3461!K3461_ChkDocsHK)
    If IsdbNull(rs3461!K3461_DateDocsHK) = False Then D3461.DateDocsHK = Trim$(rs3461!K3461_DateDocsHK)
    If IsdbNull(rs3461!K3461_ChkDocsBuyer) = False Then D3461.ChkDocsBuyer = Trim$(rs3461!K3461_ChkDocsBuyer)
    If IsdbNull(rs3461!K3461_ChkReceiveHK) = False Then D3461.ChkReceiveHK = Trim$(rs3461!K3461_ChkReceiveHK)
    If IsdbNull(rs3461!K3461_ChkPending) = False Then D3461.ChkPending = Trim$(rs3461!K3461_ChkPending)
    If IsdbNull(rs3461!K3461_DateDocsBuyer) = False Then D3461.DateDocsBuyer = Trim$(rs3461!K3461_DateDocsBuyer)
    If IsdbNull(rs3461!K3461_CheckStatus) = False Then D3461.CheckStatus = Trim$(rs3461!K3461_CheckStatus)
    If IsdbNull(rs3461!K3461_QtyOrder) = False Then D3461.QtyOrder = Trim$(rs3461!K3461_QtyOrder)
    If IsdbNull(rs3461!K3461_QtyOrderSample) = False Then D3461.QtyOrderSample = Trim$(rs3461!K3461_QtyOrderSample)
    If IsdbNull(rs3461!K3461_PriceOrderFOB) = False Then D3461.PriceOrderFOB = Trim$(rs3461!K3461_PriceOrderFOB)
    If IsdbNull(rs3461!K3461_TotalAMTFOB) = False Then D3461.TotalAMTFOB = Trim$(rs3461!K3461_TotalAMTFOB)
    If IsdbNull(rs3461!K3461_PriceOrder) = False Then D3461.PriceOrder = Trim$(rs3461!K3461_PriceOrder)
    If IsdbNull(rs3461!K3461_TotalAMT) = False Then D3461.TotalAMT = Trim$(rs3461!K3461_TotalAMT)
    If IsdbNull(rs3461!K3461_TotalGW) = False Then D3461.TotalGW = Trim$(rs3461!K3461_TotalGW)
    If IsdbNull(rs3461!K3461_TotalNW) = False Then D3461.TotalNW = Trim$(rs3461!K3461_TotalNW)
    If IsdbNull(rs3461!K3461_TotalCBM) = False Then D3461.TotalCBM = Trim$(rs3461!K3461_TotalCBM)
    If IsdbNull(rs3461!K3461_TotalQty) = False Then D3461.TotalQty = Trim$(rs3461!K3461_TotalQty)
    If IsdbNull(rs3461!K3461_TotalCnt) = False Then D3461.TotalCnt = Trim$(rs3461!K3461_TotalCnt)
    If IsdbNull(rs3461!K3461_ContName1) = False Then D3461.ContName1 = Trim$(rs3461!K3461_ContName1)
    If IsdbNull(rs3461!K3461_ContName2) = False Then D3461.ContName2 = Trim$(rs3461!K3461_ContName2)
    If IsdbNull(rs3461!K3461_ContName3) = False Then D3461.ContName3 = Trim$(rs3461!K3461_ContName3)
    If IsdbNull(rs3461!K3461_ContName4) = False Then D3461.ContName4 = Trim$(rs3461!K3461_ContName4)
    If IsdbNull(rs3461!K3461_ContName5) = False Then D3461.ContName5 = Trim$(rs3461!K3461_ContName5)
    If IsdbNull(rs3461!K3461_ContName6) = False Then D3461.ContName6 = Trim$(rs3461!K3461_ContName6)
    If IsdbNull(rs3461!K3461_ContName7) = False Then D3461.ContName7 = Trim$(rs3461!K3461_ContName7)
    If IsdbNull(rs3461!K3461_ContName8) = False Then D3461.ContName8 = Trim$(rs3461!K3461_ContName8)
    If IsdbNull(rs3461!K3461_ContName9) = False Then D3461.ContName9 = Trim$(rs3461!K3461_ContName9)
    If IsdbNull(rs3461!K3461_ContName10) = False Then D3461.ContName10 = Trim$(rs3461!K3461_ContName10)
    If IsdbNull(rs3461!K3461_QtyPL1) = False Then D3461.QtyPL1 = Trim$(rs3461!K3461_QtyPL1)
    If IsdbNull(rs3461!K3461_QtyPL2) = False Then D3461.QtyPL2 = Trim$(rs3461!K3461_QtyPL2)
    If IsdbNull(rs3461!K3461_QtyPL3) = False Then D3461.QtyPL3 = Trim$(rs3461!K3461_QtyPL3)
    If IsdbNull(rs3461!K3461_QtyPL4) = False Then D3461.QtyPL4 = Trim$(rs3461!K3461_QtyPL4)
    If IsdbNull(rs3461!K3461_QtyPL5) = False Then D3461.QtyPL5 = Trim$(rs3461!K3461_QtyPL5)
    If IsdbNull(rs3461!K3461_QtyPL6) = False Then D3461.QtyPL6 = Trim$(rs3461!K3461_QtyPL6)
    If IsdbNull(rs3461!K3461_QtyPL7) = False Then D3461.QtyPL7 = Trim$(rs3461!K3461_QtyPL7)
    If IsdbNull(rs3461!K3461_QtyPL8) = False Then D3461.QtyPL8 = Trim$(rs3461!K3461_QtyPL8)
    If IsdbNull(rs3461!K3461_QtyPL9) = False Then D3461.QtyPL9 = Trim$(rs3461!K3461_QtyPL9)
    If IsdbNull(rs3461!K3461_QtyPL10) = False Then D3461.QtyPL10 = Trim$(rs3461!K3461_QtyPL10)
    If IsdbNull(rs3461!K3461_seSite) = False Then D3461.seSite = Trim$(rs3461!K3461_seSite)
    If IsdbNull(rs3461!K3461_cdSite) = False Then D3461.cdSite = Trim$(rs3461!K3461_cdSite)
    If IsdbNull(rs3461!K3461_Remark) = False Then D3461.Remark = Trim$(rs3461!K3461_Remark)
    If IsdbNull(rs3461!K3461_TimeInsert) = False Then D3461.TimeInsert = Trim$(rs3461!K3461_TimeInsert)
    If IsdbNull(rs3461!K3461_TimeUpdate) = False Then D3461.TimeUpdate = Trim$(rs3461!K3461_TimeUpdate)
    If IsdbNull(rs3461!K3461_DateUpdate) = False Then D3461.DateUpdate = Trim$(rs3461!K3461_DateUpdate)
    If IsdbNull(rs3461!K3461_DateInsert) = False Then D3461.DateInsert = Trim$(rs3461!K3461_DateInsert)
    If IsdbNull(rs3461!K3461_InchargeInsert) = False Then D3461.InchargeInsert = Trim$(rs3461!K3461_InchargeInsert)
    If IsdbNull(rs3461!K3461_InchargeUpdate) = False Then D3461.InchargeUpdate = Trim$(rs3461!K3461_InchargeUpdate)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K3461_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K3461_MOVE(rs3461 As DataRow)
Try

    call D3461_CLEAR()   

    If IsdbNull(rs3461!K3461_InvoiceNo) = False Then D3461.InvoiceNo = Trim$(rs3461!K3461_InvoiceNo)
    If IsdbNull(rs3461!K3461_InvoiceSeq) = False Then D3461.InvoiceSeq = Trim$(rs3461!K3461_InvoiceSeq)
    If IsdbNull(rs3461!K3461_SONo) = False Then D3461.SONo = Trim$(rs3461!K3461_SONo)
    If IsdbNull(rs3461!K3461_BookingNo) = False Then D3461.BookingNo = Trim$(rs3461!K3461_BookingNo)
    If IsdbNull(rs3461!K3461_LoadingNo) = False Then D3461.LoadingNo = Trim$(rs3461!K3461_LoadingNo)
    If IsdbNull(rs3461!K3461_VesselName) = False Then D3461.VesselName = Trim$(rs3461!K3461_VesselName)
    If IsdbNull(rs3461!K3461_TradingName) = False Then D3461.TradingName = Trim$(rs3461!K3461_TradingName)
    If IsdbNull(rs3461!K3461_TradingCode) = False Then D3461.TradingCode = Trim$(rs3461!K3461_TradingCode)
    If IsdbNull(rs3461!K3461_ShipmentType) = False Then D3461.ShipmentType = Trim$(rs3461!K3461_ShipmentType)
    If IsdbNull(rs3461!K3461_DateBL) = False Then D3461.DateBL = Trim$(rs3461!K3461_DateBL)
    If IsdbNull(rs3461!K3461_BLNo) = False Then D3461.BLNo = Trim$(rs3461!K3461_BLNo)
    If IsdbNull(rs3461!K3461_ContainerNo) = False Then D3461.ContainerNo = Trim$(rs3461!K3461_ContainerNo)
    If IsdbNull(rs3461!K3461_seShipType) = False Then D3461.seShipType = Trim$(rs3461!K3461_seShipType)
    If IsdbNull(rs3461!K3461_cdShipType) = False Then D3461.cdShipType = Trim$(rs3461!K3461_cdShipType)
    If IsdbNull(rs3461!K3461_DateEXFac) = False Then D3461.DateEXFac = Trim$(rs3461!K3461_DateEXFac)
    If IsdbNull(rs3461!K3461_DateETD) = False Then D3461.DateETD = Trim$(rs3461!K3461_DateETD)
    If IsdbNull(rs3461!K3461_DateETA) = False Then D3461.DateETA = Trim$(rs3461!K3461_DateETA)
    If IsdbNull(rs3461!K3461_OrderNo) = False Then D3461.OrderNo = Trim$(rs3461!K3461_OrderNo)
    If IsdbNull(rs3461!K3461_OrderNoSeq) = False Then D3461.OrderNoSeq = Trim$(rs3461!K3461_OrderNoSeq)
    If IsdbNull(rs3461!K3461_LoadingCode) = False Then D3461.LoadingCode = Trim$(rs3461!K3461_LoadingCode)
    If IsdbNull(rs3461!K3461_TransferType) = False Then D3461.TransferType = Trim$(rs3461!K3461_TransferType)
    If IsdbNull(rs3461!K3461_ChkDeclare) = False Then D3461.ChkDeclare = Trim$(rs3461!K3461_ChkDeclare)
    If IsdbNull(rs3461!K3461_DateDeclare) = False Then D3461.DateDeclare = Trim$(rs3461!K3461_DateDeclare)
    If IsdbNull(rs3461!K3461_ChkSMDocs) = False Then D3461.ChkSMDocs = Trim$(rs3461!K3461_ChkSMDocs)
    If IsdbNull(rs3461!K3461_DateSMDocs) = False Then D3461.DateSMDocs = Trim$(rs3461!K3461_DateSMDocs)
    If IsdbNull(rs3461!K3461_ChkLocalCharge) = False Then D3461.ChkLocalCharge = Trim$(rs3461!K3461_ChkLocalCharge)
    If IsdbNull(rs3461!K3461_DateLocalCharge) = False Then D3461.DateLocalCharge = Trim$(rs3461!K3461_DateLocalCharge)
    If IsdbNull(rs3461!K3461_ChkUploadDocs) = False Then D3461.ChkUploadDocs = Trim$(rs3461!K3461_ChkUploadDocs)
    If IsdbNull(rs3461!K3461_DateUploadDocs) = False Then D3461.DateUploadDocs = Trim$(rs3461!K3461_DateUploadDocs)
    If IsdbNull(rs3461!K3461_ChkDocsHK) = False Then D3461.ChkDocsHK = Trim$(rs3461!K3461_ChkDocsHK)
    If IsdbNull(rs3461!K3461_DateDocsHK) = False Then D3461.DateDocsHK = Trim$(rs3461!K3461_DateDocsHK)
    If IsdbNull(rs3461!K3461_ChkDocsBuyer) = False Then D3461.ChkDocsBuyer = Trim$(rs3461!K3461_ChkDocsBuyer)
    If IsdbNull(rs3461!K3461_ChkReceiveHK) = False Then D3461.ChkReceiveHK = Trim$(rs3461!K3461_ChkReceiveHK)
    If IsdbNull(rs3461!K3461_ChkPending) = False Then D3461.ChkPending = Trim$(rs3461!K3461_ChkPending)
    If IsdbNull(rs3461!K3461_DateDocsBuyer) = False Then D3461.DateDocsBuyer = Trim$(rs3461!K3461_DateDocsBuyer)
    If IsdbNull(rs3461!K3461_CheckStatus) = False Then D3461.CheckStatus = Trim$(rs3461!K3461_CheckStatus)
    If IsdbNull(rs3461!K3461_QtyOrder) = False Then D3461.QtyOrder = Trim$(rs3461!K3461_QtyOrder)
    If IsdbNull(rs3461!K3461_QtyOrderSample) = False Then D3461.QtyOrderSample = Trim$(rs3461!K3461_QtyOrderSample)
    If IsdbNull(rs3461!K3461_PriceOrderFOB) = False Then D3461.PriceOrderFOB = Trim$(rs3461!K3461_PriceOrderFOB)
    If IsdbNull(rs3461!K3461_TotalAMTFOB) = False Then D3461.TotalAMTFOB = Trim$(rs3461!K3461_TotalAMTFOB)
    If IsdbNull(rs3461!K3461_PriceOrder) = False Then D3461.PriceOrder = Trim$(rs3461!K3461_PriceOrder)
    If IsdbNull(rs3461!K3461_TotalAMT) = False Then D3461.TotalAMT = Trim$(rs3461!K3461_TotalAMT)
    If IsdbNull(rs3461!K3461_TotalGW) = False Then D3461.TotalGW = Trim$(rs3461!K3461_TotalGW)
    If IsdbNull(rs3461!K3461_TotalNW) = False Then D3461.TotalNW = Trim$(rs3461!K3461_TotalNW)
    If IsdbNull(rs3461!K3461_TotalCBM) = False Then D3461.TotalCBM = Trim$(rs3461!K3461_TotalCBM)
    If IsdbNull(rs3461!K3461_TotalQty) = False Then D3461.TotalQty = Trim$(rs3461!K3461_TotalQty)
    If IsdbNull(rs3461!K3461_TotalCnt) = False Then D3461.TotalCnt = Trim$(rs3461!K3461_TotalCnt)
    If IsdbNull(rs3461!K3461_ContName1) = False Then D3461.ContName1 = Trim$(rs3461!K3461_ContName1)
    If IsdbNull(rs3461!K3461_ContName2) = False Then D3461.ContName2 = Trim$(rs3461!K3461_ContName2)
    If IsdbNull(rs3461!K3461_ContName3) = False Then D3461.ContName3 = Trim$(rs3461!K3461_ContName3)
    If IsdbNull(rs3461!K3461_ContName4) = False Then D3461.ContName4 = Trim$(rs3461!K3461_ContName4)
    If IsdbNull(rs3461!K3461_ContName5) = False Then D3461.ContName5 = Trim$(rs3461!K3461_ContName5)
    If IsdbNull(rs3461!K3461_ContName6) = False Then D3461.ContName6 = Trim$(rs3461!K3461_ContName6)
    If IsdbNull(rs3461!K3461_ContName7) = False Then D3461.ContName7 = Trim$(rs3461!K3461_ContName7)
    If IsdbNull(rs3461!K3461_ContName8) = False Then D3461.ContName8 = Trim$(rs3461!K3461_ContName8)
    If IsdbNull(rs3461!K3461_ContName9) = False Then D3461.ContName9 = Trim$(rs3461!K3461_ContName9)
    If IsdbNull(rs3461!K3461_ContName10) = False Then D3461.ContName10 = Trim$(rs3461!K3461_ContName10)
    If IsdbNull(rs3461!K3461_QtyPL1) = False Then D3461.QtyPL1 = Trim$(rs3461!K3461_QtyPL1)
    If IsdbNull(rs3461!K3461_QtyPL2) = False Then D3461.QtyPL2 = Trim$(rs3461!K3461_QtyPL2)
    If IsdbNull(rs3461!K3461_QtyPL3) = False Then D3461.QtyPL3 = Trim$(rs3461!K3461_QtyPL3)
    If IsdbNull(rs3461!K3461_QtyPL4) = False Then D3461.QtyPL4 = Trim$(rs3461!K3461_QtyPL4)
    If IsdbNull(rs3461!K3461_QtyPL5) = False Then D3461.QtyPL5 = Trim$(rs3461!K3461_QtyPL5)
    If IsdbNull(rs3461!K3461_QtyPL6) = False Then D3461.QtyPL6 = Trim$(rs3461!K3461_QtyPL6)
    If IsdbNull(rs3461!K3461_QtyPL7) = False Then D3461.QtyPL7 = Trim$(rs3461!K3461_QtyPL7)
    If IsdbNull(rs3461!K3461_QtyPL8) = False Then D3461.QtyPL8 = Trim$(rs3461!K3461_QtyPL8)
    If IsdbNull(rs3461!K3461_QtyPL9) = False Then D3461.QtyPL9 = Trim$(rs3461!K3461_QtyPL9)
    If IsdbNull(rs3461!K3461_QtyPL10) = False Then D3461.QtyPL10 = Trim$(rs3461!K3461_QtyPL10)
    If IsdbNull(rs3461!K3461_seSite) = False Then D3461.seSite = Trim$(rs3461!K3461_seSite)
    If IsdbNull(rs3461!K3461_cdSite) = False Then D3461.cdSite = Trim$(rs3461!K3461_cdSite)
    If IsdbNull(rs3461!K3461_Remark) = False Then D3461.Remark = Trim$(rs3461!K3461_Remark)
    If IsdbNull(rs3461!K3461_TimeInsert) = False Then D3461.TimeInsert = Trim$(rs3461!K3461_TimeInsert)
    If IsdbNull(rs3461!K3461_TimeUpdate) = False Then D3461.TimeUpdate = Trim$(rs3461!K3461_TimeUpdate)
    If IsdbNull(rs3461!K3461_DateUpdate) = False Then D3461.DateUpdate = Trim$(rs3461!K3461_DateUpdate)
    If IsdbNull(rs3461!K3461_DateInsert) = False Then D3461.DateInsert = Trim$(rs3461!K3461_DateInsert)
    If IsdbNull(rs3461!K3461_InchargeInsert) = False Then D3461.InchargeInsert = Trim$(rs3461!K3461_InchargeInsert)
    If IsdbNull(rs3461!K3461_InchargeUpdate) = False Then D3461.InchargeUpdate = Trim$(rs3461!K3461_InchargeUpdate)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K3461_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K3461_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z3461 As T3461_AREA, INVOICENO AS String, INVOICESEQ AS String) as Boolean

K3461_MOVE = False

Try
    If READ_PFK3461(INVOICENO, INVOICESEQ) = True Then
                z3461 = D3461
		K3461_MOVE = True
		else
	z3461 = nothing
     End If

     If  getColumnIndex(spr,"InvoiceNo") > -1 then z3461.InvoiceNo = getDataM(spr, getColumnIndex(spr,"InvoiceNo"), xRow)
     If  getColumnIndex(spr,"InvoiceSeq") > -1 then z3461.InvoiceSeq = getDataM(spr, getColumnIndex(spr,"InvoiceSeq"), xRow)
     If  getColumnIndex(spr,"SONo") > -1 then z3461.SONo = getDataM(spr, getColumnIndex(spr,"SONo"), xRow)
     If  getColumnIndex(spr,"BookingNo") > -1 then z3461.BookingNo = getDataM(spr, getColumnIndex(spr,"BookingNo"), xRow)
     If  getColumnIndex(spr,"LoadingNo") > -1 then z3461.LoadingNo = getDataM(spr, getColumnIndex(spr,"LoadingNo"), xRow)
     If  getColumnIndex(spr,"VesselName") > -1 then z3461.VesselName = getDataM(spr, getColumnIndex(spr,"VesselName"), xRow)
     If  getColumnIndex(spr,"TradingName") > -1 then z3461.TradingName = getDataM(spr, getColumnIndex(spr,"TradingName"), xRow)
     If  getColumnIndex(spr,"TradingCode") > -1 then z3461.TradingCode = getDataM(spr, getColumnIndex(spr,"TradingCode"), xRow)
     If  getColumnIndex(spr,"ShipmentType") > -1 then z3461.ShipmentType = getDataM(spr, getColumnIndex(spr,"ShipmentType"), xRow)
     If  getColumnIndex(spr,"DateBL") > -1 then z3461.DateBL = getDataM(spr, getColumnIndex(spr,"DateBL"), xRow)
     If  getColumnIndex(spr,"BLNo") > -1 then z3461.BLNo = getDataM(spr, getColumnIndex(spr,"BLNo"), xRow)
     If  getColumnIndex(spr,"ContainerNo") > -1 then z3461.ContainerNo = getDataM(spr, getColumnIndex(spr,"ContainerNo"), xRow)
     If  getColumnIndex(spr,"seShipType") > -1 then z3461.seShipType = getDataM(spr, getColumnIndex(spr,"seShipType"), xRow)
     If  getColumnIndex(spr,"cdShipType") > -1 then z3461.cdShipType = getDataM(spr, getColumnIndex(spr,"cdShipType"), xRow)
     If  getColumnIndex(spr,"DateEXFac") > -1 then z3461.DateEXFac = getDataM(spr, getColumnIndex(spr,"DateEXFac"), xRow)
     If  getColumnIndex(spr,"DateETD") > -1 then z3461.DateETD = getDataM(spr, getColumnIndex(spr,"DateETD"), xRow)
     If  getColumnIndex(spr,"DateETA") > -1 then z3461.DateETA = getDataM(spr, getColumnIndex(spr,"DateETA"), xRow)
     If  getColumnIndex(spr,"OrderNo") > -1 then z3461.OrderNo = getDataM(spr, getColumnIndex(spr,"OrderNo"), xRow)
     If  getColumnIndex(spr,"OrderNoSeq") > -1 then z3461.OrderNoSeq = getDataM(spr, getColumnIndex(spr,"OrderNoSeq"), xRow)
     If  getColumnIndex(spr,"LoadingCode") > -1 then z3461.LoadingCode = getDataM(spr, getColumnIndex(spr,"LoadingCode"), xRow)
     If  getColumnIndex(spr,"TransferType") > -1 then z3461.TransferType = getDataM(spr, getColumnIndex(spr,"TransferType"), xRow)
     If  getColumnIndex(spr,"ChkDeclare") > -1 then z3461.ChkDeclare = getDataM(spr, getColumnIndex(spr,"ChkDeclare"), xRow)
     If  getColumnIndex(spr,"DateDeclare") > -1 then z3461.DateDeclare = getDataM(spr, getColumnIndex(spr,"DateDeclare"), xRow)
     If  getColumnIndex(spr,"ChkSMDocs") > -1 then z3461.ChkSMDocs = getDataM(spr, getColumnIndex(spr,"ChkSMDocs"), xRow)
     If  getColumnIndex(spr,"DateSMDocs") > -1 then z3461.DateSMDocs = getDataM(spr, getColumnIndex(spr,"DateSMDocs"), xRow)
     If  getColumnIndex(spr,"ChkLocalCharge") > -1 then z3461.ChkLocalCharge = getDataM(spr, getColumnIndex(spr,"ChkLocalCharge"), xRow)
     If  getColumnIndex(spr,"DateLocalCharge") > -1 then z3461.DateLocalCharge = getDataM(spr, getColumnIndex(spr,"DateLocalCharge"), xRow)
     If  getColumnIndex(spr,"ChkUploadDocs") > -1 then z3461.ChkUploadDocs = getDataM(spr, getColumnIndex(spr,"ChkUploadDocs"), xRow)
     If  getColumnIndex(spr,"DateUploadDocs") > -1 then z3461.DateUploadDocs = getDataM(spr, getColumnIndex(spr,"DateUploadDocs"), xRow)
     If  getColumnIndex(spr,"ChkDocsHK") > -1 then z3461.ChkDocsHK = getDataM(spr, getColumnIndex(spr,"ChkDocsHK"), xRow)
     If  getColumnIndex(spr,"DateDocsHK") > -1 then z3461.DateDocsHK = getDataM(spr, getColumnIndex(spr,"DateDocsHK"), xRow)
     If  getColumnIndex(spr,"ChkDocsBuyer") > -1 then z3461.ChkDocsBuyer = getDataM(spr, getColumnIndex(spr,"ChkDocsBuyer"), xRow)
     If  getColumnIndex(spr,"ChkReceiveHK") > -1 then z3461.ChkReceiveHK = getDataM(spr, getColumnIndex(spr,"ChkReceiveHK"), xRow)
     If  getColumnIndex(spr,"ChkPending") > -1 then z3461.ChkPending = getDataM(spr, getColumnIndex(spr,"ChkPending"), xRow)
     If  getColumnIndex(spr,"DateDocsBuyer") > -1 then z3461.DateDocsBuyer = getDataM(spr, getColumnIndex(spr,"DateDocsBuyer"), xRow)
     If  getColumnIndex(spr,"CheckStatus") > -1 then z3461.CheckStatus = Cdecp(getDataM(spr, getColumnIndex(spr,"CheckStatus"), xRow))
     If  getColumnIndex(spr,"QtyOrder") > -1 then z3461.QtyOrder = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyOrder"), xRow))
     If  getColumnIndex(spr,"QtyOrderSample") > -1 then z3461.QtyOrderSample = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyOrderSample"), xRow))
     If  getColumnIndex(spr,"PriceOrderFOB") > -1 then z3461.PriceOrderFOB = Cdecp(getDataM(spr, getColumnIndex(spr,"PriceOrderFOB"), xRow))
     If  getColumnIndex(spr,"TotalAMTFOB") > -1 then z3461.TotalAMTFOB = Cdecp(getDataM(spr, getColumnIndex(spr,"TotalAMTFOB"), xRow))
     If  getColumnIndex(spr,"PriceOrder") > -1 then z3461.PriceOrder = Cdecp(getDataM(spr, getColumnIndex(spr,"PriceOrder"), xRow))
     If  getColumnIndex(spr,"TotalAMT") > -1 then z3461.TotalAMT = Cdecp(getDataM(spr, getColumnIndex(spr,"TotalAMT"), xRow))
     If  getColumnIndex(spr,"TotalGW") > -1 then z3461.TotalGW = Cdecp(getDataM(spr, getColumnIndex(spr,"TotalGW"), xRow))
     If  getColumnIndex(spr,"TotalNW") > -1 then z3461.TotalNW = Cdecp(getDataM(spr, getColumnIndex(spr,"TotalNW"), xRow))
     If  getColumnIndex(spr,"TotalCBM") > -1 then z3461.TotalCBM = Cdecp(getDataM(spr, getColumnIndex(spr,"TotalCBM"), xRow))
     If  getColumnIndex(spr,"TotalQty") > -1 then z3461.TotalQty = Cdecp(getDataM(spr, getColumnIndex(spr,"TotalQty"), xRow))
     If  getColumnIndex(spr,"TotalCnt") > -1 then z3461.TotalCnt = Cdecp(getDataM(spr, getColumnIndex(spr,"TotalCnt"), xRow))
     If  getColumnIndex(spr,"ContName1") > -1 then z3461.ContName1 = getDataM(spr, getColumnIndex(spr,"ContName1"), xRow)
     If  getColumnIndex(spr,"ContName2") > -1 then z3461.ContName2 = getDataM(spr, getColumnIndex(spr,"ContName2"), xRow)
     If  getColumnIndex(spr,"ContName3") > -1 then z3461.ContName3 = getDataM(spr, getColumnIndex(spr,"ContName3"), xRow)
     If  getColumnIndex(spr,"ContName4") > -1 then z3461.ContName4 = getDataM(spr, getColumnIndex(spr,"ContName4"), xRow)
     If  getColumnIndex(spr,"ContName5") > -1 then z3461.ContName5 = getDataM(spr, getColumnIndex(spr,"ContName5"), xRow)
     If  getColumnIndex(spr,"ContName6") > -1 then z3461.ContName6 = getDataM(spr, getColumnIndex(spr,"ContName6"), xRow)
     If  getColumnIndex(spr,"ContName7") > -1 then z3461.ContName7 = getDataM(spr, getColumnIndex(spr,"ContName7"), xRow)
     If  getColumnIndex(spr,"ContName8") > -1 then z3461.ContName8 = getDataM(spr, getColumnIndex(spr,"ContName8"), xRow)
     If  getColumnIndex(spr,"ContName9") > -1 then z3461.ContName9 = getDataM(spr, getColumnIndex(spr,"ContName9"), xRow)
     If  getColumnIndex(spr,"ContName10") > -1 then z3461.ContName10 = getDataM(spr, getColumnIndex(spr,"ContName10"), xRow)
     If  getColumnIndex(spr,"QtyPL1") > -1 then z3461.QtyPL1 = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyPL1"), xRow))
     If  getColumnIndex(spr,"QtyPL2") > -1 then z3461.QtyPL2 = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyPL2"), xRow))
     If  getColumnIndex(spr,"QtyPL3") > -1 then z3461.QtyPL3 = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyPL3"), xRow))
     If  getColumnIndex(spr,"QtyPL4") > -1 then z3461.QtyPL4 = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyPL4"), xRow))
     If  getColumnIndex(spr,"QtyPL5") > -1 then z3461.QtyPL5 = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyPL5"), xRow))
     If  getColumnIndex(spr,"QtyPL6") > -1 then z3461.QtyPL6 = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyPL6"), xRow))
     If  getColumnIndex(spr,"QtyPL7") > -1 then z3461.QtyPL7 = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyPL7"), xRow))
     If  getColumnIndex(spr,"QtyPL8") > -1 then z3461.QtyPL8 = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyPL8"), xRow))
     If  getColumnIndex(spr,"QtyPL9") > -1 then z3461.QtyPL9 = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyPL9"), xRow))
     If  getColumnIndex(spr,"QtyPL10") > -1 then z3461.QtyPL10 = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyPL10"), xRow))
     If  getColumnIndex(spr,"seSite") > -1 then z3461.seSite = getDataM(spr, getColumnIndex(spr,"seSite"), xRow)
     If  getColumnIndex(spr,"cdSite") > -1 then z3461.cdSite = getDataM(spr, getColumnIndex(spr,"cdSite"), xRow)
     If  getColumnIndex(spr,"Remark") > -1 then z3461.Remark = getDataM(spr, getColumnIndex(spr,"Remark"), xRow)
     If  getColumnIndex(spr,"TimeInsert") > -1 then z3461.TimeInsert = getDataM(spr, getColumnIndex(spr,"TimeInsert"), xRow)
     If  getColumnIndex(spr,"TimeUpdate") > -1 then z3461.TimeUpdate = getDataM(spr, getColumnIndex(spr,"TimeUpdate"), xRow)
     If  getColumnIndex(spr,"DateUpdate") > -1 then z3461.DateUpdate = getDataM(spr, getColumnIndex(spr,"DateUpdate"), xRow)
     If  getColumnIndex(spr,"DateInsert") > -1 then z3461.DateInsert = getDataM(spr, getColumnIndex(spr,"DateInsert"), xRow)
     If  getColumnIndex(spr,"InchargeInsert") > -1 then z3461.InchargeInsert = getDataM(spr, getColumnIndex(spr,"InchargeInsert"), xRow)
     If  getColumnIndex(spr,"InchargeUpdate") > -1 then z3461.InchargeUpdate = getDataM(spr, getColumnIndex(spr,"InchargeUpdate"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K3461_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K3461_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z3461 As T3461_AREA,CheckClear as Boolean,INVOICENO AS String, INVOICESEQ AS String) as Boolean

K3461_MOVE = False

Try
    If READ_PFK3461(INVOICENO, INVOICESEQ) = True Then
                z3461 = D3461
		K3461_MOVE = True
		else
	If CheckClear  = True then z3461 = nothing
     End If

     If  getColumnIndex(spr,"InvoiceNo") > -1 then z3461.InvoiceNo = getDataM(spr, getColumnIndex(spr,"InvoiceNo"), xRow)
     If  getColumnIndex(spr,"InvoiceSeq") > -1 then z3461.InvoiceSeq = getDataM(spr, getColumnIndex(spr,"InvoiceSeq"), xRow)
     If  getColumnIndex(spr,"SONo") > -1 then z3461.SONo = getDataM(spr, getColumnIndex(spr,"SONo"), xRow)
     If  getColumnIndex(spr,"BookingNo") > -1 then z3461.BookingNo = getDataM(spr, getColumnIndex(spr,"BookingNo"), xRow)
     If  getColumnIndex(spr,"LoadingNo") > -1 then z3461.LoadingNo = getDataM(spr, getColumnIndex(spr,"LoadingNo"), xRow)
     If  getColumnIndex(spr,"VesselName") > -1 then z3461.VesselName = getDataM(spr, getColumnIndex(spr,"VesselName"), xRow)
     If  getColumnIndex(spr,"TradingName") > -1 then z3461.TradingName = getDataM(spr, getColumnIndex(spr,"TradingName"), xRow)
     If  getColumnIndex(spr,"TradingCode") > -1 then z3461.TradingCode = getDataM(spr, getColumnIndex(spr,"TradingCode"), xRow)
     If  getColumnIndex(spr,"ShipmentType") > -1 then z3461.ShipmentType = getDataM(spr, getColumnIndex(spr,"ShipmentType"), xRow)
     If  getColumnIndex(spr,"DateBL") > -1 then z3461.DateBL = getDataM(spr, getColumnIndex(spr,"DateBL"), xRow)
     If  getColumnIndex(spr,"BLNo") > -1 then z3461.BLNo = getDataM(spr, getColumnIndex(spr,"BLNo"), xRow)
     If  getColumnIndex(spr,"ContainerNo") > -1 then z3461.ContainerNo = getDataM(spr, getColumnIndex(spr,"ContainerNo"), xRow)
     If  getColumnIndex(spr,"seShipType") > -1 then z3461.seShipType = getDataM(spr, getColumnIndex(spr,"seShipType"), xRow)
     If  getColumnIndex(spr,"cdShipType") > -1 then z3461.cdShipType = getDataM(spr, getColumnIndex(spr,"cdShipType"), xRow)
     If  getColumnIndex(spr,"DateEXFac") > -1 then z3461.DateEXFac = getDataM(spr, getColumnIndex(spr,"DateEXFac"), xRow)
     If  getColumnIndex(spr,"DateETD") > -1 then z3461.DateETD = getDataM(spr, getColumnIndex(spr,"DateETD"), xRow)
     If  getColumnIndex(spr,"DateETA") > -1 then z3461.DateETA = getDataM(spr, getColumnIndex(spr,"DateETA"), xRow)
     If  getColumnIndex(spr,"OrderNo") > -1 then z3461.OrderNo = getDataM(spr, getColumnIndex(spr,"OrderNo"), xRow)
     If  getColumnIndex(spr,"OrderNoSeq") > -1 then z3461.OrderNoSeq = getDataM(spr, getColumnIndex(spr,"OrderNoSeq"), xRow)
     If  getColumnIndex(spr,"LoadingCode") > -1 then z3461.LoadingCode = getDataM(spr, getColumnIndex(spr,"LoadingCode"), xRow)
     If  getColumnIndex(spr,"TransferType") > -1 then z3461.TransferType = getDataM(spr, getColumnIndex(spr,"TransferType"), xRow)
     If  getColumnIndex(spr,"ChkDeclare") > -1 then z3461.ChkDeclare = getDataM(spr, getColumnIndex(spr,"ChkDeclare"), xRow)
     If  getColumnIndex(spr,"DateDeclare") > -1 then z3461.DateDeclare = getDataM(spr, getColumnIndex(spr,"DateDeclare"), xRow)
     If  getColumnIndex(spr,"ChkSMDocs") > -1 then z3461.ChkSMDocs = getDataM(spr, getColumnIndex(spr,"ChkSMDocs"), xRow)
     If  getColumnIndex(spr,"DateSMDocs") > -1 then z3461.DateSMDocs = getDataM(spr, getColumnIndex(spr,"DateSMDocs"), xRow)
     If  getColumnIndex(spr,"ChkLocalCharge") > -1 then z3461.ChkLocalCharge = getDataM(spr, getColumnIndex(spr,"ChkLocalCharge"), xRow)
     If  getColumnIndex(spr,"DateLocalCharge") > -1 then z3461.DateLocalCharge = getDataM(spr, getColumnIndex(spr,"DateLocalCharge"), xRow)
     If  getColumnIndex(spr,"ChkUploadDocs") > -1 then z3461.ChkUploadDocs = getDataM(spr, getColumnIndex(spr,"ChkUploadDocs"), xRow)
     If  getColumnIndex(spr,"DateUploadDocs") > -1 then z3461.DateUploadDocs = getDataM(spr, getColumnIndex(spr,"DateUploadDocs"), xRow)
     If  getColumnIndex(spr,"ChkDocsHK") > -1 then z3461.ChkDocsHK = getDataM(spr, getColumnIndex(spr,"ChkDocsHK"), xRow)
     If  getColumnIndex(spr,"DateDocsHK") > -1 then z3461.DateDocsHK = getDataM(spr, getColumnIndex(spr,"DateDocsHK"), xRow)
     If  getColumnIndex(spr,"ChkDocsBuyer") > -1 then z3461.ChkDocsBuyer = getDataM(spr, getColumnIndex(spr,"ChkDocsBuyer"), xRow)
     If  getColumnIndex(spr,"ChkReceiveHK") > -1 then z3461.ChkReceiveHK = getDataM(spr, getColumnIndex(spr,"ChkReceiveHK"), xRow)
     If  getColumnIndex(spr,"ChkPending") > -1 then z3461.ChkPending = getDataM(spr, getColumnIndex(spr,"ChkPending"), xRow)
     If  getColumnIndex(spr,"DateDocsBuyer") > -1 then z3461.DateDocsBuyer = getDataM(spr, getColumnIndex(spr,"DateDocsBuyer"), xRow)
     If  getColumnIndex(spr,"CheckStatus") > -1 then z3461.CheckStatus = Cdecp(getDataM(spr, getColumnIndex(spr,"CheckStatus"), xRow))
     If  getColumnIndex(spr,"QtyOrder") > -1 then z3461.QtyOrder = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyOrder"), xRow))
     If  getColumnIndex(spr,"QtyOrderSample") > -1 then z3461.QtyOrderSample = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyOrderSample"), xRow))
     If  getColumnIndex(spr,"PriceOrderFOB") > -1 then z3461.PriceOrderFOB = Cdecp(getDataM(spr, getColumnIndex(spr,"PriceOrderFOB"), xRow))
     If  getColumnIndex(spr,"TotalAMTFOB") > -1 then z3461.TotalAMTFOB = Cdecp(getDataM(spr, getColumnIndex(spr,"TotalAMTFOB"), xRow))
     If  getColumnIndex(spr,"PriceOrder") > -1 then z3461.PriceOrder = Cdecp(getDataM(spr, getColumnIndex(spr,"PriceOrder"), xRow))
     If  getColumnIndex(spr,"TotalAMT") > -1 then z3461.TotalAMT = Cdecp(getDataM(spr, getColumnIndex(spr,"TotalAMT"), xRow))
     If  getColumnIndex(spr,"TotalGW") > -1 then z3461.TotalGW = Cdecp(getDataM(spr, getColumnIndex(spr,"TotalGW"), xRow))
     If  getColumnIndex(spr,"TotalNW") > -1 then z3461.TotalNW = Cdecp(getDataM(spr, getColumnIndex(spr,"TotalNW"), xRow))
     If  getColumnIndex(spr,"TotalCBM") > -1 then z3461.TotalCBM = Cdecp(getDataM(spr, getColumnIndex(spr,"TotalCBM"), xRow))
     If  getColumnIndex(spr,"TotalQty") > -1 then z3461.TotalQty = Cdecp(getDataM(spr, getColumnIndex(spr,"TotalQty"), xRow))
     If  getColumnIndex(spr,"TotalCnt") > -1 then z3461.TotalCnt = Cdecp(getDataM(spr, getColumnIndex(spr,"TotalCnt"), xRow))
     If  getColumnIndex(spr,"ContName1") > -1 then z3461.ContName1 = getDataM(spr, getColumnIndex(spr,"ContName1"), xRow)
     If  getColumnIndex(spr,"ContName2") > -1 then z3461.ContName2 = getDataM(spr, getColumnIndex(spr,"ContName2"), xRow)
     If  getColumnIndex(spr,"ContName3") > -1 then z3461.ContName3 = getDataM(spr, getColumnIndex(spr,"ContName3"), xRow)
     If  getColumnIndex(spr,"ContName4") > -1 then z3461.ContName4 = getDataM(spr, getColumnIndex(spr,"ContName4"), xRow)
     If  getColumnIndex(spr,"ContName5") > -1 then z3461.ContName5 = getDataM(spr, getColumnIndex(spr,"ContName5"), xRow)
     If  getColumnIndex(spr,"ContName6") > -1 then z3461.ContName6 = getDataM(spr, getColumnIndex(spr,"ContName6"), xRow)
     If  getColumnIndex(spr,"ContName7") > -1 then z3461.ContName7 = getDataM(spr, getColumnIndex(spr,"ContName7"), xRow)
     If  getColumnIndex(spr,"ContName8") > -1 then z3461.ContName8 = getDataM(spr, getColumnIndex(spr,"ContName8"), xRow)
     If  getColumnIndex(spr,"ContName9") > -1 then z3461.ContName9 = getDataM(spr, getColumnIndex(spr,"ContName9"), xRow)
     If  getColumnIndex(spr,"ContName10") > -1 then z3461.ContName10 = getDataM(spr, getColumnIndex(spr,"ContName10"), xRow)
     If  getColumnIndex(spr,"QtyPL1") > -1 then z3461.QtyPL1 = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyPL1"), xRow))
     If  getColumnIndex(spr,"QtyPL2") > -1 then z3461.QtyPL2 = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyPL2"), xRow))
     If  getColumnIndex(spr,"QtyPL3") > -1 then z3461.QtyPL3 = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyPL3"), xRow))
     If  getColumnIndex(spr,"QtyPL4") > -1 then z3461.QtyPL4 = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyPL4"), xRow))
     If  getColumnIndex(spr,"QtyPL5") > -1 then z3461.QtyPL5 = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyPL5"), xRow))
     If  getColumnIndex(spr,"QtyPL6") > -1 then z3461.QtyPL6 = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyPL6"), xRow))
     If  getColumnIndex(spr,"QtyPL7") > -1 then z3461.QtyPL7 = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyPL7"), xRow))
     If  getColumnIndex(spr,"QtyPL8") > -1 then z3461.QtyPL8 = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyPL8"), xRow))
     If  getColumnIndex(spr,"QtyPL9") > -1 then z3461.QtyPL9 = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyPL9"), xRow))
     If  getColumnIndex(spr,"QtyPL10") > -1 then z3461.QtyPL10 = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyPL10"), xRow))
     If  getColumnIndex(spr,"seSite") > -1 then z3461.seSite = getDataM(spr, getColumnIndex(spr,"seSite"), xRow)
     If  getColumnIndex(spr,"cdSite") > -1 then z3461.cdSite = getDataM(spr, getColumnIndex(spr,"cdSite"), xRow)
     If  getColumnIndex(spr,"Remark") > -1 then z3461.Remark = getDataM(spr, getColumnIndex(spr,"Remark"), xRow)
     If  getColumnIndex(spr,"TimeInsert") > -1 then z3461.TimeInsert = getDataM(spr, getColumnIndex(spr,"TimeInsert"), xRow)
     If  getColumnIndex(spr,"TimeUpdate") > -1 then z3461.TimeUpdate = getDataM(spr, getColumnIndex(spr,"TimeUpdate"), xRow)
     If  getColumnIndex(spr,"DateUpdate") > -1 then z3461.DateUpdate = getDataM(spr, getColumnIndex(spr,"DateUpdate"), xRow)
     If  getColumnIndex(spr,"DateInsert") > -1 then z3461.DateInsert = getDataM(spr, getColumnIndex(spr,"DateInsert"), xRow)
     If  getColumnIndex(spr,"InchargeInsert") > -1 then z3461.InchargeInsert = getDataM(spr, getColumnIndex(spr,"InchargeInsert"), xRow)
     If  getColumnIndex(spr,"InchargeUpdate") > -1 then z3461.InchargeUpdate = getDataM(spr, getColumnIndex(spr,"InchargeUpdate"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K3461_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K3461_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z3461 As T3461_AREA, Job as String, INVOICENO AS String, INVOICESEQ AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K3461_MOVE = False

Try
    If READ_PFK3461(INVOICENO, INVOICESEQ) = True Then
                z3461 = D3461
		K3461_MOVE = True
		else
	z3461 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3461")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "INVOICENO":z3461.InvoiceNo = Children(i).Code
   Case "INVOICESEQ":z3461.InvoiceSeq = Children(i).Code
   Case "SONO":z3461.SONo = Children(i).Code
   Case "BOOKINGNO":z3461.BookingNo = Children(i).Code
   Case "LOADINGNO":z3461.LoadingNo = Children(i).Code
   Case "VESSELNAME":z3461.VesselName = Children(i).Code
   Case "TRADINGNAME":z3461.TradingName = Children(i).Code
   Case "TRADINGCODE":z3461.TradingCode = Children(i).Code
   Case "SHIPMENTTYPE":z3461.ShipmentType = Children(i).Code
   Case "DATEBL":z3461.DateBL = Children(i).Code
   Case "BLNO":z3461.BLNo = Children(i).Code
   Case "CONTAINERNO":z3461.ContainerNo = Children(i).Code
   Case "SESHIPTYPE":z3461.seShipType = Children(i).Code
   Case "CDSHIPTYPE":z3461.cdShipType = Children(i).Code
   Case "DATEEXFAC":z3461.DateEXFac = Children(i).Code
   Case "DATEETD":z3461.DateETD = Children(i).Code
   Case "DATEETA":z3461.DateETA = Children(i).Code
   Case "ORDERNO":z3461.OrderNo = Children(i).Code
   Case "ORDERNOSEQ":z3461.OrderNoSeq = Children(i).Code
   Case "LOADINGCODE":z3461.LoadingCode = Children(i).Code
   Case "TRANSFERTYPE":z3461.TransferType = Children(i).Code
   Case "CHKDECLARE":z3461.ChkDeclare = Children(i).Code
   Case "DATEDECLARE":z3461.DateDeclare = Children(i).Code
   Case "CHKSMDOCS":z3461.ChkSMDocs = Children(i).Code
   Case "DATESMDOCS":z3461.DateSMDocs = Children(i).Code
   Case "CHKLOCALCHARGE":z3461.ChkLocalCharge = Children(i).Code
   Case "DATELOCALCHARGE":z3461.DateLocalCharge = Children(i).Code
   Case "CHKUPLOADDOCS":z3461.ChkUploadDocs = Children(i).Code
   Case "DATEUPLOADDOCS":z3461.DateUploadDocs = Children(i).Code
   Case "CHKDOCSHK":z3461.ChkDocsHK = Children(i).Code
   Case "DATEDOCSHK":z3461.DateDocsHK = Children(i).Code
   Case "CHKDOCSBUYER":z3461.ChkDocsBuyer = Children(i).Code
   Case "CHKRECEIVEHK":z3461.ChkReceiveHK = Children(i).Code
   Case "CHKPENDING":z3461.ChkPending = Children(i).Code
   Case "DATEDOCSBUYER":z3461.DateDocsBuyer = Children(i).Code
   Case "CHECKSTATUS":z3461.CheckStatus = Children(i).Code
   Case "QTYORDER":z3461.QtyOrder = Children(i).Code
   Case "QTYORDERSAMPLE":z3461.QtyOrderSample = Children(i).Code
   Case "PRICEORDERFOB":z3461.PriceOrderFOB = Children(i).Code
   Case "TOTALAMTFOB":z3461.TotalAMTFOB = Children(i).Code
   Case "PRICEORDER":z3461.PriceOrder = Children(i).Code
   Case "TOTALAMT":z3461.TotalAMT = Children(i).Code
   Case "TOTALGW":z3461.TotalGW = Children(i).Code
   Case "TOTALNW":z3461.TotalNW = Children(i).Code
   Case "TOTALCBM":z3461.TotalCBM = Children(i).Code
   Case "TOTALQTY":z3461.TotalQty = Children(i).Code
   Case "TOTALCNT":z3461.TotalCnt = Children(i).Code
   Case "CONTNAME1":z3461.ContName1 = Children(i).Code
   Case "CONTNAME2":z3461.ContName2 = Children(i).Code
   Case "CONTNAME3":z3461.ContName3 = Children(i).Code
   Case "CONTNAME4":z3461.ContName4 = Children(i).Code
   Case "CONTNAME5":z3461.ContName5 = Children(i).Code
   Case "CONTNAME6":z3461.ContName6 = Children(i).Code
   Case "CONTNAME7":z3461.ContName7 = Children(i).Code
   Case "CONTNAME8":z3461.ContName8 = Children(i).Code
   Case "CONTNAME9":z3461.ContName9 = Children(i).Code
   Case "CONTNAME10":z3461.ContName10 = Children(i).Code
   Case "QTYPL1":z3461.QtyPL1 = Children(i).Code
   Case "QTYPL2":z3461.QtyPL2 = Children(i).Code
   Case "QTYPL3":z3461.QtyPL3 = Children(i).Code
   Case "QTYPL4":z3461.QtyPL4 = Children(i).Code
   Case "QTYPL5":z3461.QtyPL5 = Children(i).Code
   Case "QTYPL6":z3461.QtyPL6 = Children(i).Code
   Case "QTYPL7":z3461.QtyPL7 = Children(i).Code
   Case "QTYPL8":z3461.QtyPL8 = Children(i).Code
   Case "QTYPL9":z3461.QtyPL9 = Children(i).Code
   Case "QTYPL10":z3461.QtyPL10 = Children(i).Code
   Case "SESITE":z3461.seSite = Children(i).Code
   Case "CDSITE":z3461.cdSite = Children(i).Code
   Case "REMARK":z3461.Remark = Children(i).Code
   Case "TIMEINSERT":z3461.TimeInsert = Children(i).Code
   Case "TIMEUPDATE":z3461.TimeUpdate = Children(i).Code
   Case "DATEUPDATE":z3461.DateUpdate = Children(i).Code
   Case "DATEINSERT":z3461.DateInsert = Children(i).Code
   Case "INCHARGEINSERT":z3461.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z3461.InchargeUpdate = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "INVOICENO":z3461.InvoiceNo = Children(i).Data
   Case "INVOICESEQ":z3461.InvoiceSeq = Children(i).Data
   Case "SONO":z3461.SONo = Children(i).Data
   Case "BOOKINGNO":z3461.BookingNo = Children(i).Data
   Case "LOADINGNO":z3461.LoadingNo = Children(i).Data
   Case "VESSELNAME":z3461.VesselName = Children(i).Data
   Case "TRADINGNAME":z3461.TradingName = Children(i).Data
   Case "TRADINGCODE":z3461.TradingCode = Children(i).Data
   Case "SHIPMENTTYPE":z3461.ShipmentType = Children(i).Data
   Case "DATEBL":z3461.DateBL = Children(i).Data
   Case "BLNO":z3461.BLNo = Children(i).Data
   Case "CONTAINERNO":z3461.ContainerNo = Children(i).Data
   Case "SESHIPTYPE":z3461.seShipType = Children(i).Data
   Case "CDSHIPTYPE":z3461.cdShipType = Children(i).Data
   Case "DATEEXFAC":z3461.DateEXFac = Children(i).Data
   Case "DATEETD":z3461.DateETD = Children(i).Data
   Case "DATEETA":z3461.DateETA = Children(i).Data
   Case "ORDERNO":z3461.OrderNo = Children(i).Data
   Case "ORDERNOSEQ":z3461.OrderNoSeq = Children(i).Data
   Case "LOADINGCODE":z3461.LoadingCode = Children(i).Data
   Case "TRANSFERTYPE":z3461.TransferType = Children(i).Data
   Case "CHKDECLARE":z3461.ChkDeclare = Children(i).Data
   Case "DATEDECLARE":z3461.DateDeclare = Children(i).Data
   Case "CHKSMDOCS":z3461.ChkSMDocs = Children(i).Data
   Case "DATESMDOCS":z3461.DateSMDocs = Children(i).Data
   Case "CHKLOCALCHARGE":z3461.ChkLocalCharge = Children(i).Data
   Case "DATELOCALCHARGE":z3461.DateLocalCharge = Children(i).Data
   Case "CHKUPLOADDOCS":z3461.ChkUploadDocs = Children(i).Data
   Case "DATEUPLOADDOCS":z3461.DateUploadDocs = Children(i).Data
   Case "CHKDOCSHK":z3461.ChkDocsHK = Children(i).Data
   Case "DATEDOCSHK":z3461.DateDocsHK = Children(i).Data
   Case "CHKDOCSBUYER":z3461.ChkDocsBuyer = Children(i).Data
   Case "CHKRECEIVEHK":z3461.ChkReceiveHK = Children(i).Data
   Case "CHKPENDING":z3461.ChkPending = Children(i).Data
   Case "DATEDOCSBUYER":z3461.DateDocsBuyer = Children(i).Data
   Case "CHECKSTATUS":z3461.CheckStatus = Cdecp(Children(i).Data)
   Case "QTYORDER":z3461.QtyOrder = Cdecp(Children(i).Data)
   Case "QTYORDERSAMPLE":z3461.QtyOrderSample = Cdecp(Children(i).Data)
   Case "PRICEORDERFOB":z3461.PriceOrderFOB = Cdecp(Children(i).Data)
   Case "TOTALAMTFOB":z3461.TotalAMTFOB = Cdecp(Children(i).Data)
   Case "PRICEORDER":z3461.PriceOrder = Cdecp(Children(i).Data)
   Case "TOTALAMT":z3461.TotalAMT = Cdecp(Children(i).Data)
   Case "TOTALGW":z3461.TotalGW = Cdecp(Children(i).Data)
   Case "TOTALNW":z3461.TotalNW = Cdecp(Children(i).Data)
   Case "TOTALCBM":z3461.TotalCBM = Cdecp(Children(i).Data)
   Case "TOTALQTY":z3461.TotalQty = Cdecp(Children(i).Data)
   Case "TOTALCNT":z3461.TotalCnt = Cdecp(Children(i).Data)
   Case "CONTNAME1":z3461.ContName1 = Children(i).Data
   Case "CONTNAME2":z3461.ContName2 = Children(i).Data
   Case "CONTNAME3":z3461.ContName3 = Children(i).Data
   Case "CONTNAME4":z3461.ContName4 = Children(i).Data
   Case "CONTNAME5":z3461.ContName5 = Children(i).Data
   Case "CONTNAME6":z3461.ContName6 = Children(i).Data
   Case "CONTNAME7":z3461.ContName7 = Children(i).Data
   Case "CONTNAME8":z3461.ContName8 = Children(i).Data
   Case "CONTNAME9":z3461.ContName9 = Children(i).Data
   Case "CONTNAME10":z3461.ContName10 = Children(i).Data
   Case "QTYPL1":z3461.QtyPL1 = Cdecp(Children(i).Data)
   Case "QTYPL2":z3461.QtyPL2 = Cdecp(Children(i).Data)
   Case "QTYPL3":z3461.QtyPL3 = Cdecp(Children(i).Data)
   Case "QTYPL4":z3461.QtyPL4 = Cdecp(Children(i).Data)
   Case "QTYPL5":z3461.QtyPL5 = Cdecp(Children(i).Data)
   Case "QTYPL6":z3461.QtyPL6 = Cdecp(Children(i).Data)
   Case "QTYPL7":z3461.QtyPL7 = Cdecp(Children(i).Data)
   Case "QTYPL8":z3461.QtyPL8 = Cdecp(Children(i).Data)
   Case "QTYPL9":z3461.QtyPL9 = Cdecp(Children(i).Data)
   Case "QTYPL10":z3461.QtyPL10 = Cdecp(Children(i).Data)
   Case "SESITE":z3461.seSite = Children(i).Data
   Case "CDSITE":z3461.cdSite = Children(i).Data
   Case "REMARK":z3461.Remark = Children(i).Data
   Case "TIMEINSERT":z3461.TimeInsert = Children(i).Data
   Case "TIMEUPDATE":z3461.TimeUpdate = Children(i).Data
   Case "DATEUPDATE":z3461.DateUpdate = Children(i).Data
   Case "DATEINSERT":z3461.DateInsert = Children(i).Data
   Case "INCHARGEINSERT":z3461.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z3461.InchargeUpdate = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K3461_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K3461_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z3461 As T3461_AREA, Job as String, CheckClear as Boolean, INVOICENO AS String, INVOICESEQ AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K3461_MOVE = False

Try
    If READ_PFK3461(INVOICENO, INVOICESEQ) = True Then
                z3461 = D3461
		K3461_MOVE = True
		else
	If CheckClear  = True then z3461 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3461")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "INVOICENO":z3461.InvoiceNo = Children(i).Code
   Case "INVOICESEQ":z3461.InvoiceSeq = Children(i).Code
   Case "SONO":z3461.SONo = Children(i).Code
   Case "BOOKINGNO":z3461.BookingNo = Children(i).Code
   Case "LOADINGNO":z3461.LoadingNo = Children(i).Code
   Case "VESSELNAME":z3461.VesselName = Children(i).Code
   Case "TRADINGNAME":z3461.TradingName = Children(i).Code
   Case "TRADINGCODE":z3461.TradingCode = Children(i).Code
   Case "SHIPMENTTYPE":z3461.ShipmentType = Children(i).Code
   Case "DATEBL":z3461.DateBL = Children(i).Code
   Case "BLNO":z3461.BLNo = Children(i).Code
   Case "CONTAINERNO":z3461.ContainerNo = Children(i).Code
   Case "SESHIPTYPE":z3461.seShipType = Children(i).Code
   Case "CDSHIPTYPE":z3461.cdShipType = Children(i).Code
   Case "DATEEXFAC":z3461.DateEXFac = Children(i).Code
   Case "DATEETD":z3461.DateETD = Children(i).Code
   Case "DATEETA":z3461.DateETA = Children(i).Code
   Case "ORDERNO":z3461.OrderNo = Children(i).Code
   Case "ORDERNOSEQ":z3461.OrderNoSeq = Children(i).Code
   Case "LOADINGCODE":z3461.LoadingCode = Children(i).Code
   Case "TRANSFERTYPE":z3461.TransferType = Children(i).Code
   Case "CHKDECLARE":z3461.ChkDeclare = Children(i).Code
   Case "DATEDECLARE":z3461.DateDeclare = Children(i).Code
   Case "CHKSMDOCS":z3461.ChkSMDocs = Children(i).Code
   Case "DATESMDOCS":z3461.DateSMDocs = Children(i).Code
   Case "CHKLOCALCHARGE":z3461.ChkLocalCharge = Children(i).Code
   Case "DATELOCALCHARGE":z3461.DateLocalCharge = Children(i).Code
   Case "CHKUPLOADDOCS":z3461.ChkUploadDocs = Children(i).Code
   Case "DATEUPLOADDOCS":z3461.DateUploadDocs = Children(i).Code
   Case "CHKDOCSHK":z3461.ChkDocsHK = Children(i).Code
   Case "DATEDOCSHK":z3461.DateDocsHK = Children(i).Code
   Case "CHKDOCSBUYER":z3461.ChkDocsBuyer = Children(i).Code
   Case "CHKRECEIVEHK":z3461.ChkReceiveHK = Children(i).Code
   Case "CHKPENDING":z3461.ChkPending = Children(i).Code
   Case "DATEDOCSBUYER":z3461.DateDocsBuyer = Children(i).Code
   Case "CHECKSTATUS":z3461.CheckStatus = Children(i).Code
   Case "QTYORDER":z3461.QtyOrder = Children(i).Code
   Case "QTYORDERSAMPLE":z3461.QtyOrderSample = Children(i).Code
   Case "PRICEORDERFOB":z3461.PriceOrderFOB = Children(i).Code
   Case "TOTALAMTFOB":z3461.TotalAMTFOB = Children(i).Code
   Case "PRICEORDER":z3461.PriceOrder = Children(i).Code
   Case "TOTALAMT":z3461.TotalAMT = Children(i).Code
   Case "TOTALGW":z3461.TotalGW = Children(i).Code
   Case "TOTALNW":z3461.TotalNW = Children(i).Code
   Case "TOTALCBM":z3461.TotalCBM = Children(i).Code
   Case "TOTALQTY":z3461.TotalQty = Children(i).Code
   Case "TOTALCNT":z3461.TotalCnt = Children(i).Code
   Case "CONTNAME1":z3461.ContName1 = Children(i).Code
   Case "CONTNAME2":z3461.ContName2 = Children(i).Code
   Case "CONTNAME3":z3461.ContName3 = Children(i).Code
   Case "CONTNAME4":z3461.ContName4 = Children(i).Code
   Case "CONTNAME5":z3461.ContName5 = Children(i).Code
   Case "CONTNAME6":z3461.ContName6 = Children(i).Code
   Case "CONTNAME7":z3461.ContName7 = Children(i).Code
   Case "CONTNAME8":z3461.ContName8 = Children(i).Code
   Case "CONTNAME9":z3461.ContName9 = Children(i).Code
   Case "CONTNAME10":z3461.ContName10 = Children(i).Code
   Case "QTYPL1":z3461.QtyPL1 = Children(i).Code
   Case "QTYPL2":z3461.QtyPL2 = Children(i).Code
   Case "QTYPL3":z3461.QtyPL3 = Children(i).Code
   Case "QTYPL4":z3461.QtyPL4 = Children(i).Code
   Case "QTYPL5":z3461.QtyPL5 = Children(i).Code
   Case "QTYPL6":z3461.QtyPL6 = Children(i).Code
   Case "QTYPL7":z3461.QtyPL7 = Children(i).Code
   Case "QTYPL8":z3461.QtyPL8 = Children(i).Code
   Case "QTYPL9":z3461.QtyPL9 = Children(i).Code
   Case "QTYPL10":z3461.QtyPL10 = Children(i).Code
   Case "SESITE":z3461.seSite = Children(i).Code
   Case "CDSITE":z3461.cdSite = Children(i).Code
   Case "REMARK":z3461.Remark = Children(i).Code
   Case "TIMEINSERT":z3461.TimeInsert = Children(i).Code
   Case "TIMEUPDATE":z3461.TimeUpdate = Children(i).Code
   Case "DATEUPDATE":z3461.DateUpdate = Children(i).Code
   Case "DATEINSERT":z3461.DateInsert = Children(i).Code
   Case "INCHARGEINSERT":z3461.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z3461.InchargeUpdate = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "INVOICENO":z3461.InvoiceNo = Children(i).Data
   Case "INVOICESEQ":z3461.InvoiceSeq = Children(i).Data
   Case "SONO":z3461.SONo = Children(i).Data
   Case "BOOKINGNO":z3461.BookingNo = Children(i).Data
   Case "LOADINGNO":z3461.LoadingNo = Children(i).Data
   Case "VESSELNAME":z3461.VesselName = Children(i).Data
   Case "TRADINGNAME":z3461.TradingName = Children(i).Data
   Case "TRADINGCODE":z3461.TradingCode = Children(i).Data
   Case "SHIPMENTTYPE":z3461.ShipmentType = Children(i).Data
   Case "DATEBL":z3461.DateBL = Children(i).Data
   Case "BLNO":z3461.BLNo = Children(i).Data
   Case "CONTAINERNO":z3461.ContainerNo = Children(i).Data
   Case "SESHIPTYPE":z3461.seShipType = Children(i).Data
   Case "CDSHIPTYPE":z3461.cdShipType = Children(i).Data
   Case "DATEEXFAC":z3461.DateEXFac = Children(i).Data
   Case "DATEETD":z3461.DateETD = Children(i).Data
   Case "DATEETA":z3461.DateETA = Children(i).Data
   Case "ORDERNO":z3461.OrderNo = Children(i).Data
   Case "ORDERNOSEQ":z3461.OrderNoSeq = Children(i).Data
   Case "LOADINGCODE":z3461.LoadingCode = Children(i).Data
   Case "TRANSFERTYPE":z3461.TransferType = Children(i).Data
   Case "CHKDECLARE":z3461.ChkDeclare = Children(i).Data
   Case "DATEDECLARE":z3461.DateDeclare = Children(i).Data
   Case "CHKSMDOCS":z3461.ChkSMDocs = Children(i).Data
   Case "DATESMDOCS":z3461.DateSMDocs = Children(i).Data
   Case "CHKLOCALCHARGE":z3461.ChkLocalCharge = Children(i).Data
   Case "DATELOCALCHARGE":z3461.DateLocalCharge = Children(i).Data
   Case "CHKUPLOADDOCS":z3461.ChkUploadDocs = Children(i).Data
   Case "DATEUPLOADDOCS":z3461.DateUploadDocs = Children(i).Data
   Case "CHKDOCSHK":z3461.ChkDocsHK = Children(i).Data
   Case "DATEDOCSHK":z3461.DateDocsHK = Children(i).Data
   Case "CHKDOCSBUYER":z3461.ChkDocsBuyer = Children(i).Data
   Case "CHKRECEIVEHK":z3461.ChkReceiveHK = Children(i).Data
   Case "CHKPENDING":z3461.ChkPending = Children(i).Data
   Case "DATEDOCSBUYER":z3461.DateDocsBuyer = Children(i).Data
   Case "CHECKSTATUS":z3461.CheckStatus = Cdecp(Children(i).Data)
   Case "QTYORDER":z3461.QtyOrder = Cdecp(Children(i).Data)
   Case "QTYORDERSAMPLE":z3461.QtyOrderSample = Cdecp(Children(i).Data)
   Case "PRICEORDERFOB":z3461.PriceOrderFOB = Cdecp(Children(i).Data)
   Case "TOTALAMTFOB":z3461.TotalAMTFOB = Cdecp(Children(i).Data)
   Case "PRICEORDER":z3461.PriceOrder = Cdecp(Children(i).Data)
   Case "TOTALAMT":z3461.TotalAMT = Cdecp(Children(i).Data)
   Case "TOTALGW":z3461.TotalGW = Cdecp(Children(i).Data)
   Case "TOTALNW":z3461.TotalNW = Cdecp(Children(i).Data)
   Case "TOTALCBM":z3461.TotalCBM = Cdecp(Children(i).Data)
   Case "TOTALQTY":z3461.TotalQty = Cdecp(Children(i).Data)
   Case "TOTALCNT":z3461.TotalCnt = Cdecp(Children(i).Data)
   Case "CONTNAME1":z3461.ContName1 = Children(i).Data
   Case "CONTNAME2":z3461.ContName2 = Children(i).Data
   Case "CONTNAME3":z3461.ContName3 = Children(i).Data
   Case "CONTNAME4":z3461.ContName4 = Children(i).Data
   Case "CONTNAME5":z3461.ContName5 = Children(i).Data
   Case "CONTNAME6":z3461.ContName6 = Children(i).Data
   Case "CONTNAME7":z3461.ContName7 = Children(i).Data
   Case "CONTNAME8":z3461.ContName8 = Children(i).Data
   Case "CONTNAME9":z3461.ContName9 = Children(i).Data
   Case "CONTNAME10":z3461.ContName10 = Children(i).Data
   Case "QTYPL1":z3461.QtyPL1 = Cdecp(Children(i).Data)
   Case "QTYPL2":z3461.QtyPL2 = Cdecp(Children(i).Data)
   Case "QTYPL3":z3461.QtyPL3 = Cdecp(Children(i).Data)
   Case "QTYPL4":z3461.QtyPL4 = Cdecp(Children(i).Data)
   Case "QTYPL5":z3461.QtyPL5 = Cdecp(Children(i).Data)
   Case "QTYPL6":z3461.QtyPL6 = Cdecp(Children(i).Data)
   Case "QTYPL7":z3461.QtyPL7 = Cdecp(Children(i).Data)
   Case "QTYPL8":z3461.QtyPL8 = Cdecp(Children(i).Data)
   Case "QTYPL9":z3461.QtyPL9 = Cdecp(Children(i).Data)
   Case "QTYPL10":z3461.QtyPL10 = Cdecp(Children(i).Data)
   Case "SESITE":z3461.seSite = Children(i).Data
   Case "CDSITE":z3461.cdSite = Children(i).Data
   Case "REMARK":z3461.Remark = Children(i).Data
   Case "TIMEINSERT":z3461.TimeInsert = Children(i).Data
   Case "TIMEUPDATE":z3461.TimeUpdate = Children(i).Data
   Case "DATEUPDATE":z3461.DateUpdate = Children(i).Data
   Case "DATEINSERT":z3461.DateInsert = Children(i).Data
   Case "INCHARGEINSERT":z3461.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z3461.InchargeUpdate = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K3461_MOVE",vbCritical)
End Try
End Function 
    

'=========================================================================================================================================================
' DATA MOVE FORM NEW AREA
'=========================================================================================================================================================
Public Sub K3461_MOVE(ByRef a3461 As T3461_AREA, ByRef b3461 As T3461_AREA) 
Try
If trim$( a3461.InvoiceNo ) = "" Then b3461.InvoiceNo = ""  Else b3461.InvoiceNo=a3461.InvoiceNo
If trim$( a3461.InvoiceSeq ) = "" Then b3461.InvoiceSeq = ""  Else b3461.InvoiceSeq=a3461.InvoiceSeq
If trim$( a3461.SONo ) = "" Then b3461.SONo = ""  Else b3461.SONo=a3461.SONo
If trim$( a3461.BookingNo ) = "" Then b3461.BookingNo = ""  Else b3461.BookingNo=a3461.BookingNo
If trim$( a3461.LoadingNo ) = "" Then b3461.LoadingNo = ""  Else b3461.LoadingNo=a3461.LoadingNo
If trim$( a3461.VesselName ) = "" Then b3461.VesselName = ""  Else b3461.VesselName=a3461.VesselName
If trim$( a3461.TradingName ) = "" Then b3461.TradingName = ""  Else b3461.TradingName=a3461.TradingName
If trim$( a3461.TradingCode ) = "" Then b3461.TradingCode = ""  Else b3461.TradingCode=a3461.TradingCode
If trim$( a3461.ShipmentType ) = "" Then b3461.ShipmentType = ""  Else b3461.ShipmentType=a3461.ShipmentType
If trim$( a3461.DateBL ) = "" Then b3461.DateBL = ""  Else b3461.DateBL=a3461.DateBL
If trim$( a3461.BLNo ) = "" Then b3461.BLNo = ""  Else b3461.BLNo=a3461.BLNo
If trim$( a3461.ContainerNo ) = "" Then b3461.ContainerNo = ""  Else b3461.ContainerNo=a3461.ContainerNo
If trim$( a3461.seShipType ) = "" Then b3461.seShipType = ""  Else b3461.seShipType=a3461.seShipType
If trim$( a3461.cdShipType ) = "" Then b3461.cdShipType = ""  Else b3461.cdShipType=a3461.cdShipType
If trim$( a3461.DateEXFac ) = "" Then b3461.DateEXFac = ""  Else b3461.DateEXFac=a3461.DateEXFac
If trim$( a3461.DateETD ) = "" Then b3461.DateETD = ""  Else b3461.DateETD=a3461.DateETD
If trim$( a3461.DateETA ) = "" Then b3461.DateETA = ""  Else b3461.DateETA=a3461.DateETA
If trim$( a3461.OrderNo ) = "" Then b3461.OrderNo = ""  Else b3461.OrderNo=a3461.OrderNo
If trim$( a3461.OrderNoSeq ) = "" Then b3461.OrderNoSeq = ""  Else b3461.OrderNoSeq=a3461.OrderNoSeq
If trim$( a3461.LoadingCode ) = "" Then b3461.LoadingCode = ""  Else b3461.LoadingCode=a3461.LoadingCode
If trim$( a3461.TransferType ) = "" Then b3461.TransferType = ""  Else b3461.TransferType=a3461.TransferType
If trim$( a3461.ChkDeclare ) = "" Then b3461.ChkDeclare = ""  Else b3461.ChkDeclare=a3461.ChkDeclare
If trim$( a3461.DateDeclare ) = "" Then b3461.DateDeclare = ""  Else b3461.DateDeclare=a3461.DateDeclare
If trim$( a3461.ChkSMDocs ) = "" Then b3461.ChkSMDocs = ""  Else b3461.ChkSMDocs=a3461.ChkSMDocs
If trim$( a3461.DateSMDocs ) = "" Then b3461.DateSMDocs = ""  Else b3461.DateSMDocs=a3461.DateSMDocs
If trim$( a3461.ChkLocalCharge ) = "" Then b3461.ChkLocalCharge = ""  Else b3461.ChkLocalCharge=a3461.ChkLocalCharge
If trim$( a3461.DateLocalCharge ) = "" Then b3461.DateLocalCharge = ""  Else b3461.DateLocalCharge=a3461.DateLocalCharge
If trim$( a3461.ChkUploadDocs ) = "" Then b3461.ChkUploadDocs = ""  Else b3461.ChkUploadDocs=a3461.ChkUploadDocs
If trim$( a3461.DateUploadDocs ) = "" Then b3461.DateUploadDocs = ""  Else b3461.DateUploadDocs=a3461.DateUploadDocs
If trim$( a3461.ChkDocsHK ) = "" Then b3461.ChkDocsHK = ""  Else b3461.ChkDocsHK=a3461.ChkDocsHK
If trim$( a3461.DateDocsHK ) = "" Then b3461.DateDocsHK = ""  Else b3461.DateDocsHK=a3461.DateDocsHK
If trim$( a3461.ChkDocsBuyer ) = "" Then b3461.ChkDocsBuyer = ""  Else b3461.ChkDocsBuyer=a3461.ChkDocsBuyer
If trim$( a3461.ChkReceiveHK ) = "" Then b3461.ChkReceiveHK = ""  Else b3461.ChkReceiveHK=a3461.ChkReceiveHK
If trim$( a3461.ChkPending ) = "" Then b3461.ChkPending = ""  Else b3461.ChkPending=a3461.ChkPending
If trim$( a3461.DateDocsBuyer ) = "" Then b3461.DateDocsBuyer = ""  Else b3461.DateDocsBuyer=a3461.DateDocsBuyer
If trim$( a3461.CheckStatus ) = "" Then b3461.CheckStatus = ""  Else b3461.CheckStatus=a3461.CheckStatus
If trim$( a3461.QtyOrder ) = "" Then b3461.QtyOrder = ""  Else b3461.QtyOrder=a3461.QtyOrder
If trim$( a3461.QtyOrderSample ) = "" Then b3461.QtyOrderSample = ""  Else b3461.QtyOrderSample=a3461.QtyOrderSample
If trim$( a3461.PriceOrderFOB ) = "" Then b3461.PriceOrderFOB = ""  Else b3461.PriceOrderFOB=a3461.PriceOrderFOB
If trim$( a3461.TotalAMTFOB ) = "" Then b3461.TotalAMTFOB = ""  Else b3461.TotalAMTFOB=a3461.TotalAMTFOB
If trim$( a3461.PriceOrder ) = "" Then b3461.PriceOrder = ""  Else b3461.PriceOrder=a3461.PriceOrder
If trim$( a3461.TotalAMT ) = "" Then b3461.TotalAMT = ""  Else b3461.TotalAMT=a3461.TotalAMT
If trim$( a3461.TotalGW ) = "" Then b3461.TotalGW = ""  Else b3461.TotalGW=a3461.TotalGW
If trim$( a3461.TotalNW ) = "" Then b3461.TotalNW = ""  Else b3461.TotalNW=a3461.TotalNW
If trim$( a3461.TotalCBM ) = "" Then b3461.TotalCBM = ""  Else b3461.TotalCBM=a3461.TotalCBM
If trim$( a3461.TotalQty ) = "" Then b3461.TotalQty = ""  Else b3461.TotalQty=a3461.TotalQty
If trim$( a3461.TotalCnt ) = "" Then b3461.TotalCnt = ""  Else b3461.TotalCnt=a3461.TotalCnt
If trim$( a3461.ContName1 ) = "" Then b3461.ContName1 = ""  Else b3461.ContName1=a3461.ContName1
If trim$( a3461.ContName2 ) = "" Then b3461.ContName2 = ""  Else b3461.ContName2=a3461.ContName2
If trim$( a3461.ContName3 ) = "" Then b3461.ContName3 = ""  Else b3461.ContName3=a3461.ContName3
If trim$( a3461.ContName4 ) = "" Then b3461.ContName4 = ""  Else b3461.ContName4=a3461.ContName4
If trim$( a3461.ContName5 ) = "" Then b3461.ContName5 = ""  Else b3461.ContName5=a3461.ContName5
If trim$( a3461.ContName6 ) = "" Then b3461.ContName6 = ""  Else b3461.ContName6=a3461.ContName6
If trim$( a3461.ContName7 ) = "" Then b3461.ContName7 = ""  Else b3461.ContName7=a3461.ContName7
If trim$( a3461.ContName8 ) = "" Then b3461.ContName8 = ""  Else b3461.ContName8=a3461.ContName8
If trim$( a3461.ContName9 ) = "" Then b3461.ContName9 = ""  Else b3461.ContName9=a3461.ContName9
If trim$( a3461.ContName10 ) = "" Then b3461.ContName10 = ""  Else b3461.ContName10=a3461.ContName10
If trim$( a3461.QtyPL1 ) = "" Then b3461.QtyPL1 = ""  Else b3461.QtyPL1=a3461.QtyPL1
If trim$( a3461.QtyPL2 ) = "" Then b3461.QtyPL2 = ""  Else b3461.QtyPL2=a3461.QtyPL2
If trim$( a3461.QtyPL3 ) = "" Then b3461.QtyPL3 = ""  Else b3461.QtyPL3=a3461.QtyPL3
If trim$( a3461.QtyPL4 ) = "" Then b3461.QtyPL4 = ""  Else b3461.QtyPL4=a3461.QtyPL4
If trim$( a3461.QtyPL5 ) = "" Then b3461.QtyPL5 = ""  Else b3461.QtyPL5=a3461.QtyPL5
If trim$( a3461.QtyPL6 ) = "" Then b3461.QtyPL6 = ""  Else b3461.QtyPL6=a3461.QtyPL6
If trim$( a3461.QtyPL7 ) = "" Then b3461.QtyPL7 = ""  Else b3461.QtyPL7=a3461.QtyPL7
If trim$( a3461.QtyPL8 ) = "" Then b3461.QtyPL8 = ""  Else b3461.QtyPL8=a3461.QtyPL8
If trim$( a3461.QtyPL9 ) = "" Then b3461.QtyPL9 = ""  Else b3461.QtyPL9=a3461.QtyPL9
If trim$( a3461.QtyPL10 ) = "" Then b3461.QtyPL10 = ""  Else b3461.QtyPL10=a3461.QtyPL10
If trim$( a3461.seSite ) = "" Then b3461.seSite = ""  Else b3461.seSite=a3461.seSite
If trim$( a3461.cdSite ) = "" Then b3461.cdSite = ""  Else b3461.cdSite=a3461.cdSite
If trim$( a3461.Remark ) = "" Then b3461.Remark = ""  Else b3461.Remark=a3461.Remark
If trim$( a3461.TimeInsert ) = "" Then b3461.TimeInsert = ""  Else b3461.TimeInsert=a3461.TimeInsert
If trim$( a3461.TimeUpdate ) = "" Then b3461.TimeUpdate = ""  Else b3461.TimeUpdate=a3461.TimeUpdate
If trim$( a3461.DateUpdate ) = "" Then b3461.DateUpdate = ""  Else b3461.DateUpdate=a3461.DateUpdate
If trim$( a3461.DateInsert ) = "" Then b3461.DateInsert = ""  Else b3461.DateInsert=a3461.DateInsert
If trim$( a3461.InchargeInsert ) = "" Then b3461.InchargeInsert = ""  Else b3461.InchargeInsert=a3461.InchargeInsert
If trim$( a3461.InchargeUpdate ) = "" Then b3461.InchargeUpdate = ""  Else b3461.InchargeUpdate=a3461.InchargeUpdate
Catch ex As Exception
      Call MsgBoxP("K3461_MOVE",vbCritical)
End Try
End Sub 


End Module 
