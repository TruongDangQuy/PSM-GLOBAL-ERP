'=========================================================================================================================================================
'   TABLE : (PFK3491)
'
'      WORKER : PSM GLOBAL ., LTD
'       WORK DATE : 2019 NEW
'       DEVELOPER    : MRNLV
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K3491

Structure T3491_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	WIPNo	 AS String	'			char(9)		*
Public 	WIPSeq	 AS String	'			char(4)		*
Public 	InvoiceNo	 AS String	'			char(9)
Public 	InvoiceSeq	 AS String	'			char(4)
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
Public 	Autokey_P	 AS Double	'			decimal
Public 	Remark	 AS String	'			nvarchar(500)
Public 	TimeInsert	 AS String	'			char(14)
Public 	TimeUpdate	 AS String	'			char(14)
Public 	DateUpdate	 AS String	'			char(8)
Public 	DateInsert	 AS String	'			char(8)
Public 	InchargeInsert	 AS String	'			char(8)
Public 	InchargeUpdate	 AS String	'			char(8)
'=========================================================================================================================================================
End structure

Public D3491 As T3491_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK3491(WIPNO AS String, WIPSEQ AS String) As Boolean
    READ_PFK3491 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK3491 "
    SQL = SQL & " WHERE K3491_WIPNo		 = '" & WIPNo & "' " 
    SQL = SQL & "   AND K3491_WIPSeq		 = '" & WIPSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D3491_CLEAR: GoTo SKIP_READ_PFK3491
                
    Call K3491_MOVE(rd)
    READ_PFK3491 = True

SKIP_READ_PFK3491:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK3491",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK3491(WIPNO AS String, WIPSEQ AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK3491 "
    SQL = SQL & " WHERE K3491_WIPNo		 = '" & WIPNo & "' " 
    SQL = SQL & "   AND K3491_WIPSeq		 = '" & WIPSeq & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK3491",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK3491(z3491 As T3491_AREA) As Boolean
    WRITE_PFK3491 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z3491)
 
    SQL = " INSERT INTO PFK3491 "
    SQL = SQL & " ( "
    SQL = SQL & " K3491_WIPNo," 
    SQL = SQL & " K3491_WIPSeq," 
    SQL = SQL & " K3491_InvoiceNo," 
    SQL = SQL & " K3491_InvoiceSeq," 
    SQL = SQL & " K3491_SONo," 
    SQL = SQL & " K3491_BookingNo," 
    SQL = SQL & " K3491_LoadingNo," 
    SQL = SQL & " K3491_VesselName," 
    SQL = SQL & " K3491_TradingName," 
    SQL = SQL & " K3491_TradingCode," 
    SQL = SQL & " K3491_ShipmentType," 
    SQL = SQL & " K3491_DateBL," 
    SQL = SQL & " K3491_BLNo," 
    SQL = SQL & " K3491_ContainerNo," 
    SQL = SQL & " K3491_seShipType," 
    SQL = SQL & " K3491_cdShipType," 
    SQL = SQL & " K3491_DateEXFac," 
    SQL = SQL & " K3491_DateETD," 
    SQL = SQL & " K3491_DateETA," 
    SQL = SQL & " K3491_OrderNo," 
    SQL = SQL & " K3491_OrderNoSeq," 
    SQL = SQL & " K3491_LoadingCode," 
    SQL = SQL & " K3491_TransferType," 
    SQL = SQL & " K3491_ChkDeclare," 
    SQL = SQL & " K3491_DateDeclare," 
    SQL = SQL & " K3491_ChkSMDocs," 
    SQL = SQL & " K3491_DateSMDocs," 
    SQL = SQL & " K3491_ChkLocalCharge," 
    SQL = SQL & " K3491_DateLocalCharge," 
    SQL = SQL & " K3491_ChkUploadDocs," 
    SQL = SQL & " K3491_DateUploadDocs," 
    SQL = SQL & " K3491_ChkDocsHK," 
    SQL = SQL & " K3491_DateDocsHK," 
    SQL = SQL & " K3491_ChkDocsBuyer," 
    SQL = SQL & " K3491_ChkReceiveHK," 
    SQL = SQL & " K3491_ChkPending," 
    SQL = SQL & " K3491_DateDocsBuyer," 
    SQL = SQL & " K3491_CheckStatus," 
    SQL = SQL & " K3491_QtyOrder," 
    SQL = SQL & " K3491_QtyOrderSample," 
    SQL = SQL & " K3491_PriceOrderFOB," 
    SQL = SQL & " K3491_TotalAMTFOB," 
    SQL = SQL & " K3491_PriceOrder," 
    SQL = SQL & " K3491_TotalAMT," 
    SQL = SQL & " K3491_TotalGW," 
    SQL = SQL & " K3491_TotalNW," 
    SQL = SQL & " K3491_TotalCBM," 
    SQL = SQL & " K3491_TotalQty," 
    SQL = SQL & " K3491_TotalCnt," 
    SQL = SQL & " K3491_ContName1," 
    SQL = SQL & " K3491_ContName2," 
    SQL = SQL & " K3491_ContName3," 
    SQL = SQL & " K3491_ContName4," 
    SQL = SQL & " K3491_ContName5," 
    SQL = SQL & " K3491_ContName6," 
    SQL = SQL & " K3491_ContName7," 
    SQL = SQL & " K3491_ContName8," 
    SQL = SQL & " K3491_ContName9," 
    SQL = SQL & " K3491_ContName10," 
    SQL = SQL & " K3491_QtyPL1," 
    SQL = SQL & " K3491_QtyPL2," 
    SQL = SQL & " K3491_QtyPL3," 
    SQL = SQL & " K3491_QtyPL4," 
    SQL = SQL & " K3491_QtyPL5," 
    SQL = SQL & " K3491_QtyPL6," 
    SQL = SQL & " K3491_QtyPL7," 
    SQL = SQL & " K3491_QtyPL8," 
    SQL = SQL & " K3491_QtyPL9," 
    SQL = SQL & " K3491_QtyPL10," 
    SQL = SQL & " K3491_seSite," 
    SQL = SQL & " K3491_cdSite," 
    SQL = SQL & " K3491_Autokey_P," 
    SQL = SQL & " K3491_Remark," 
    SQL = SQL & " K3491_TimeInsert," 
    SQL = SQL & " K3491_TimeUpdate," 
    SQL = SQL & " K3491_DateUpdate," 
    SQL = SQL & " K3491_DateInsert," 
    SQL = SQL & " K3491_InchargeInsert," 
    SQL = SQL & " K3491_InchargeUpdate " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z3491.WIPNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3491.WIPSeq) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3491.InvoiceNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3491.InvoiceSeq) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3491.SONo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3491.BookingNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3491.LoadingNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3491.VesselName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3491.TradingName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3491.TradingCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3491.ShipmentType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3491.DateBL) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3491.BLNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3491.ContainerNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3491.seShipType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3491.cdShipType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3491.DateEXFac) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3491.DateETD) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3491.DateETA) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3491.OrderNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3491.OrderNoSeq) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3491.LoadingCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3491.TransferType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3491.ChkDeclare) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3491.DateDeclare) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3491.ChkSMDocs) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3491.DateSMDocs) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3491.ChkLocalCharge) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3491.DateLocalCharge) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3491.ChkUploadDocs) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3491.DateUploadDocs) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3491.ChkDocsHK) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3491.DateDocsHK) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3491.ChkDocsBuyer) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3491.ChkReceiveHK) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3491.ChkPending) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3491.DateDocsBuyer) & "', "  
    SQL = SQL & "   " & FormatSQL(z3491.CheckStatus) & ", "  
    SQL = SQL & "   " & FormatSQL(z3491.QtyOrder) & ", "  
    SQL = SQL & "   " & FormatSQL(z3491.QtyOrderSample) & ", "  
    SQL = SQL & "   " & FormatSQL(z3491.PriceOrderFOB) & ", "  
    SQL = SQL & "   " & FormatSQL(z3491.TotalAMTFOB) & ", "  
    SQL = SQL & "   " & FormatSQL(z3491.PriceOrder) & ", "  
    SQL = SQL & "   " & FormatSQL(z3491.TotalAMT) & ", "  
    SQL = SQL & "   " & FormatSQL(z3491.TotalGW) & ", "  
    SQL = SQL & "   " & FormatSQL(z3491.TotalNW) & ", "  
    SQL = SQL & "   " & FormatSQL(z3491.TotalCBM) & ", "  
    SQL = SQL & "   " & FormatSQL(z3491.TotalQty) & ", "  
    SQL = SQL & "   " & FormatSQL(z3491.TotalCnt) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z3491.ContName1) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3491.ContName2) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3491.ContName3) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3491.ContName4) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3491.ContName5) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3491.ContName6) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3491.ContName7) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3491.ContName8) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3491.ContName9) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3491.ContName10) & "', "  
    SQL = SQL & "   " & FormatSQL(z3491.QtyPL1) & ", "  
    SQL = SQL & "   " & FormatSQL(z3491.QtyPL2) & ", "  
    SQL = SQL & "   " & FormatSQL(z3491.QtyPL3) & ", "  
    SQL = SQL & "   " & FormatSQL(z3491.QtyPL4) & ", "  
    SQL = SQL & "   " & FormatSQL(z3491.QtyPL5) & ", "  
    SQL = SQL & "   " & FormatSQL(z3491.QtyPL6) & ", "  
    SQL = SQL & "   " & FormatSQL(z3491.QtyPL7) & ", "  
    SQL = SQL & "   " & FormatSQL(z3491.QtyPL8) & ", "  
    SQL = SQL & "   " & FormatSQL(z3491.QtyPL9) & ", "  
    SQL = SQL & "   " & FormatSQL(z3491.QtyPL10) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z3491.seSite) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3491.cdSite) & "', "  
    SQL = SQL & "   " & FormatSQL(z3491.Autokey_P) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z3491.Remark) & "', "  
    SQL = SQL & "  N'" & FormatSQL(PUB.TIME) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3491.TimeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3491.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(PUB.DAT) & "', "  
    SQL = SQL & "  N'" & FormatSQL(PUB.SAW) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3491.InchargeUpdate) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK3491 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK3491",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK3491(z3491 As T3491_AREA) As Boolean
    REWRITE_PFK3491 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z3491)
   
    SQL = " UPDATE PFK3491 SET "
    SQL = SQL & "    K3491_InvoiceNo      = N'" & FormatSQL(z3491.InvoiceNo) & "', " 
    SQL = SQL & "    K3491_InvoiceSeq      = N'" & FormatSQL(z3491.InvoiceSeq) & "', " 
    SQL = SQL & "    K3491_SONo      = N'" & FormatSQL(z3491.SONo) & "', " 
    SQL = SQL & "    K3491_BookingNo      = N'" & FormatSQL(z3491.BookingNo) & "', " 
    SQL = SQL & "    K3491_LoadingNo      = N'" & FormatSQL(z3491.LoadingNo) & "', " 
    SQL = SQL & "    K3491_VesselName      = N'" & FormatSQL(z3491.VesselName) & "', " 
    SQL = SQL & "    K3491_TradingName      = N'" & FormatSQL(z3491.TradingName) & "', " 
    SQL = SQL & "    K3491_TradingCode      = N'" & FormatSQL(z3491.TradingCode) & "', " 
    SQL = SQL & "    K3491_ShipmentType      = N'" & FormatSQL(z3491.ShipmentType) & "', " 
    SQL = SQL & "    K3491_DateBL      = N'" & FormatSQL(z3491.DateBL) & "', " 
    SQL = SQL & "    K3491_BLNo      = N'" & FormatSQL(z3491.BLNo) & "', " 
    SQL = SQL & "    K3491_ContainerNo      = N'" & FormatSQL(z3491.ContainerNo) & "', " 
    SQL = SQL & "    K3491_seShipType      = N'" & FormatSQL(z3491.seShipType) & "', " 
    SQL = SQL & "    K3491_cdShipType      = N'" & FormatSQL(z3491.cdShipType) & "', " 
    SQL = SQL & "    K3491_DateEXFac      = N'" & FormatSQL(z3491.DateEXFac) & "', " 
    SQL = SQL & "    K3491_DateETD      = N'" & FormatSQL(z3491.DateETD) & "', " 
    SQL = SQL & "    K3491_DateETA      = N'" & FormatSQL(z3491.DateETA) & "', " 
    SQL = SQL & "    K3491_OrderNo      = N'" & FormatSQL(z3491.OrderNo) & "', " 
    SQL = SQL & "    K3491_OrderNoSeq      = N'" & FormatSQL(z3491.OrderNoSeq) & "', " 
    SQL = SQL & "    K3491_LoadingCode      = N'" & FormatSQL(z3491.LoadingCode) & "', " 
    SQL = SQL & "    K3491_TransferType      = N'" & FormatSQL(z3491.TransferType) & "', " 
    SQL = SQL & "    K3491_ChkDeclare      = N'" & FormatSQL(z3491.ChkDeclare) & "', " 
    SQL = SQL & "    K3491_DateDeclare      = N'" & FormatSQL(z3491.DateDeclare) & "', " 
    SQL = SQL & "    K3491_ChkSMDocs      = N'" & FormatSQL(z3491.ChkSMDocs) & "', " 
    SQL = SQL & "    K3491_DateSMDocs      = N'" & FormatSQL(z3491.DateSMDocs) & "', " 
    SQL = SQL & "    K3491_ChkLocalCharge      = N'" & FormatSQL(z3491.ChkLocalCharge) & "', " 
    SQL = SQL & "    K3491_DateLocalCharge      = N'" & FormatSQL(z3491.DateLocalCharge) & "', " 
    SQL = SQL & "    K3491_ChkUploadDocs      = N'" & FormatSQL(z3491.ChkUploadDocs) & "', " 
    SQL = SQL & "    K3491_DateUploadDocs      = N'" & FormatSQL(z3491.DateUploadDocs) & "', " 
    SQL = SQL & "    K3491_ChkDocsHK      = N'" & FormatSQL(z3491.ChkDocsHK) & "', " 
    SQL = SQL & "    K3491_DateDocsHK      = N'" & FormatSQL(z3491.DateDocsHK) & "', " 
    SQL = SQL & "    K3491_ChkDocsBuyer      = N'" & FormatSQL(z3491.ChkDocsBuyer) & "', " 
    SQL = SQL & "    K3491_ChkReceiveHK      = N'" & FormatSQL(z3491.ChkReceiveHK) & "', " 
    SQL = SQL & "    K3491_ChkPending      = N'" & FormatSQL(z3491.ChkPending) & "', " 
    SQL = SQL & "    K3491_DateDocsBuyer      = N'" & FormatSQL(z3491.DateDocsBuyer) & "', " 
    SQL = SQL & "    K3491_CheckStatus      =  " & FormatSQL(z3491.CheckStatus) & ", " 
    SQL = SQL & "    K3491_QtyOrder      =  " & FormatSQL(z3491.QtyOrder) & ", " 
    SQL = SQL & "    K3491_QtyOrderSample      =  " & FormatSQL(z3491.QtyOrderSample) & ", " 
    SQL = SQL & "    K3491_PriceOrderFOB      =  " & FormatSQL(z3491.PriceOrderFOB) & ", " 
    SQL = SQL & "    K3491_TotalAMTFOB      =  " & FormatSQL(z3491.TotalAMTFOB) & ", " 
    SQL = SQL & "    K3491_PriceOrder      =  " & FormatSQL(z3491.PriceOrder) & ", " 
    SQL = SQL & "    K3491_TotalAMT      =  " & FormatSQL(z3491.TotalAMT) & ", " 
    SQL = SQL & "    K3491_TotalGW      =  " & FormatSQL(z3491.TotalGW) & ", " 
    SQL = SQL & "    K3491_TotalNW      =  " & FormatSQL(z3491.TotalNW) & ", " 
    SQL = SQL & "    K3491_TotalCBM      =  " & FormatSQL(z3491.TotalCBM) & ", " 
    SQL = SQL & "    K3491_TotalQty      =  " & FormatSQL(z3491.TotalQty) & ", " 
    SQL = SQL & "    K3491_TotalCnt      =  " & FormatSQL(z3491.TotalCnt) & ", " 
    SQL = SQL & "    K3491_ContName1      = N'" & FormatSQL(z3491.ContName1) & "', " 
    SQL = SQL & "    K3491_ContName2      = N'" & FormatSQL(z3491.ContName2) & "', " 
    SQL = SQL & "    K3491_ContName3      = N'" & FormatSQL(z3491.ContName3) & "', " 
    SQL = SQL & "    K3491_ContName4      = N'" & FormatSQL(z3491.ContName4) & "', " 
    SQL = SQL & "    K3491_ContName5      = N'" & FormatSQL(z3491.ContName5) & "', " 
    SQL = SQL & "    K3491_ContName6      = N'" & FormatSQL(z3491.ContName6) & "', " 
    SQL = SQL & "    K3491_ContName7      = N'" & FormatSQL(z3491.ContName7) & "', " 
    SQL = SQL & "    K3491_ContName8      = N'" & FormatSQL(z3491.ContName8) & "', " 
    SQL = SQL & "    K3491_ContName9      = N'" & FormatSQL(z3491.ContName9) & "', " 
    SQL = SQL & "    K3491_ContName10      = N'" & FormatSQL(z3491.ContName10) & "', " 
    SQL = SQL & "    K3491_QtyPL1      =  " & FormatSQL(z3491.QtyPL1) & ", " 
    SQL = SQL & "    K3491_QtyPL2      =  " & FormatSQL(z3491.QtyPL2) & ", " 
    SQL = SQL & "    K3491_QtyPL3      =  " & FormatSQL(z3491.QtyPL3) & ", " 
    SQL = SQL & "    K3491_QtyPL4      =  " & FormatSQL(z3491.QtyPL4) & ", " 
    SQL = SQL & "    K3491_QtyPL5      =  " & FormatSQL(z3491.QtyPL5) & ", " 
    SQL = SQL & "    K3491_QtyPL6      =  " & FormatSQL(z3491.QtyPL6) & ", " 
    SQL = SQL & "    K3491_QtyPL7      =  " & FormatSQL(z3491.QtyPL7) & ", " 
    SQL = SQL & "    K3491_QtyPL8      =  " & FormatSQL(z3491.QtyPL8) & ", " 
    SQL = SQL & "    K3491_QtyPL9      =  " & FormatSQL(z3491.QtyPL9) & ", " 
    SQL = SQL & "    K3491_QtyPL10      =  " & FormatSQL(z3491.QtyPL10) & ", " 
    SQL = SQL & "    K3491_seSite      = N'" & FormatSQL(z3491.seSite) & "', " 
    SQL = SQL & "    K3491_cdSite      = N'" & FormatSQL(z3491.cdSite) & "', " 
    SQL = SQL & "    K3491_Autokey_P      =  " & FormatSQL(z3491.Autokey_P) & ", " 
    SQL = SQL & "    K3491_Remark      = N'" & FormatSQL(z3491.Remark) & "', " 
    SQL = SQL & "    K3491_TimeInsert      = N'" & FormatSQL(z3491.TimeInsert) & "', " 
    SQL = SQL & "    K3491_TimeUpdate      = N'" & FormatSQL(PUB.TIME) & "', " 
    SQL = SQL & "    K3491_DateUpdate      = N'" & FormatSQL(PUB.DAT) & "', " 
    SQL = SQL & "    K3491_DateInsert      = N'" & FormatSQL(z3491.DateInsert) & "', " 
    SQL = SQL & "    K3491_InchargeInsert      = N'" & FormatSQL(z3491.InchargeInsert) & "', " 
    SQL = SQL & "    K3491_InchargeUpdate      = N'" & FormatSQL(PUB.SAW) & "'  " 
    SQL = SQL & " WHERE K3491_WIPNo		 = '" & z3491.WIPNo & "' " 
    SQL = SQL & "   AND K3491_WIPSeq		 = '" & z3491.WIPSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  

    REWRITE_PFK3491 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK3491",vbCritical)

  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK3491(z3491 As T3491_AREA) As Boolean
    DELETE_PFK3491 = False

   Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z3491)
      
        SQL = " DELETE FROM PFK3491  "
    SQL = SQL & " WHERE K3491_WIPNo		 = '" & z3491.WIPNo & "' " 
    SQL = SQL & "   AND K3491_WIPSeq		 = '" & z3491.WIPSeq & "' " 

    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK3491 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK3491",vbCritical)
Finally
        Call GetFullInformation("PFK3491", "D", SQL)
  End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D3491_CLEAR()
Try
    
   D3491.WIPNo = ""
   D3491.WIPSeq = ""
   D3491.InvoiceNo = ""
   D3491.InvoiceSeq = ""
   D3491.SONo = ""
   D3491.BookingNo = ""
   D3491.LoadingNo = ""
   D3491.VesselName = ""
   D3491.TradingName = ""
   D3491.TradingCode = ""
   D3491.ShipmentType = ""
   D3491.DateBL = ""
   D3491.BLNo = ""
   D3491.ContainerNo = ""
   D3491.seShipType = ""
   D3491.cdShipType = ""
   D3491.DateEXFac = ""
   D3491.DateETD = ""
   D3491.DateETA = ""
   D3491.OrderNo = ""
   D3491.OrderNoSeq = ""
   D3491.LoadingCode = ""
   D3491.TransferType = ""
   D3491.ChkDeclare = ""
   D3491.DateDeclare = ""
   D3491.ChkSMDocs = ""
   D3491.DateSMDocs = ""
   D3491.ChkLocalCharge = ""
   D3491.DateLocalCharge = ""
   D3491.ChkUploadDocs = ""
   D3491.DateUploadDocs = ""
   D3491.ChkDocsHK = ""
   D3491.DateDocsHK = ""
   D3491.ChkDocsBuyer = ""
   D3491.ChkReceiveHK = ""
   D3491.ChkPending = ""
   D3491.DateDocsBuyer = ""
    D3491.CheckStatus = 0 
    D3491.QtyOrder = 0 
    D3491.QtyOrderSample = 0 
    D3491.PriceOrderFOB = 0 
    D3491.TotalAMTFOB = 0 
    D3491.PriceOrder = 0 
    D3491.TotalAMT = 0 
    D3491.TotalGW = 0 
    D3491.TotalNW = 0 
    D3491.TotalCBM = 0 
    D3491.TotalQty = 0 
    D3491.TotalCnt = 0 
   D3491.ContName1 = ""
   D3491.ContName2 = ""
   D3491.ContName3 = ""
   D3491.ContName4 = ""
   D3491.ContName5 = ""
   D3491.ContName6 = ""
   D3491.ContName7 = ""
   D3491.ContName8 = ""
   D3491.ContName9 = ""
   D3491.ContName10 = ""
    D3491.QtyPL1 = 0 
    D3491.QtyPL2 = 0 
    D3491.QtyPL3 = 0 
    D3491.QtyPL4 = 0 
    D3491.QtyPL5 = 0 
    D3491.QtyPL6 = 0 
    D3491.QtyPL7 = 0 
    D3491.QtyPL8 = 0 
    D3491.QtyPL9 = 0 
    D3491.QtyPL10 = 0 
   D3491.seSite = ""
   D3491.cdSite = ""
    D3491.Autokey_P = 0 
   D3491.Remark = ""
   D3491.TimeInsert = ""
   D3491.TimeUpdate = ""
   D3491.DateUpdate = ""
   D3491.DateInsert = ""
   D3491.InchargeInsert = ""
   D3491.InchargeUpdate = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D3491_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x3491 As T3491_AREA)
Try
    
    x3491.WIPNo = trim$(  x3491.WIPNo)
    x3491.WIPSeq = trim$(  x3491.WIPSeq)
    x3491.InvoiceNo = trim$(  x3491.InvoiceNo)
    x3491.InvoiceSeq = trim$(  x3491.InvoiceSeq)
    x3491.SONo = trim$(  x3491.SONo)
    x3491.BookingNo = trim$(  x3491.BookingNo)
    x3491.LoadingNo = trim$(  x3491.LoadingNo)
    x3491.VesselName = trim$(  x3491.VesselName)
    x3491.TradingName = trim$(  x3491.TradingName)
    x3491.TradingCode = trim$(  x3491.TradingCode)
    x3491.ShipmentType = trim$(  x3491.ShipmentType)
    x3491.DateBL = trim$(  x3491.DateBL)
    x3491.BLNo = trim$(  x3491.BLNo)
    x3491.ContainerNo = trim$(  x3491.ContainerNo)
    x3491.seShipType = trim$(  x3491.seShipType)
    x3491.cdShipType = trim$(  x3491.cdShipType)
    x3491.DateEXFac = trim$(  x3491.DateEXFac)
    x3491.DateETD = trim$(  x3491.DateETD)
    x3491.DateETA = trim$(  x3491.DateETA)
    x3491.OrderNo = trim$(  x3491.OrderNo)
    x3491.OrderNoSeq = trim$(  x3491.OrderNoSeq)
    x3491.LoadingCode = trim$(  x3491.LoadingCode)
    x3491.TransferType = trim$(  x3491.TransferType)
    x3491.ChkDeclare = trim$(  x3491.ChkDeclare)
    x3491.DateDeclare = trim$(  x3491.DateDeclare)
    x3491.ChkSMDocs = trim$(  x3491.ChkSMDocs)
    x3491.DateSMDocs = trim$(  x3491.DateSMDocs)
    x3491.ChkLocalCharge = trim$(  x3491.ChkLocalCharge)
    x3491.DateLocalCharge = trim$(  x3491.DateLocalCharge)
    x3491.ChkUploadDocs = trim$(  x3491.ChkUploadDocs)
    x3491.DateUploadDocs = trim$(  x3491.DateUploadDocs)
    x3491.ChkDocsHK = trim$(  x3491.ChkDocsHK)
    x3491.DateDocsHK = trim$(  x3491.DateDocsHK)
    x3491.ChkDocsBuyer = trim$(  x3491.ChkDocsBuyer)
    x3491.ChkReceiveHK = trim$(  x3491.ChkReceiveHK)
    x3491.ChkPending = trim$(  x3491.ChkPending)
    x3491.DateDocsBuyer = trim$(  x3491.DateDocsBuyer)
    x3491.CheckStatus = trim$(  x3491.CheckStatus)
    x3491.QtyOrder = trim$(  x3491.QtyOrder)
    x3491.QtyOrderSample = trim$(  x3491.QtyOrderSample)
    x3491.PriceOrderFOB = trim$(  x3491.PriceOrderFOB)
    x3491.TotalAMTFOB = trim$(  x3491.TotalAMTFOB)
    x3491.PriceOrder = trim$(  x3491.PriceOrder)
    x3491.TotalAMT = trim$(  x3491.TotalAMT)
    x3491.TotalGW = trim$(  x3491.TotalGW)
    x3491.TotalNW = trim$(  x3491.TotalNW)
    x3491.TotalCBM = trim$(  x3491.TotalCBM)
    x3491.TotalQty = trim$(  x3491.TotalQty)
    x3491.TotalCnt = trim$(  x3491.TotalCnt)
    x3491.ContName1 = trim$(  x3491.ContName1)
    x3491.ContName2 = trim$(  x3491.ContName2)
    x3491.ContName3 = trim$(  x3491.ContName3)
    x3491.ContName4 = trim$(  x3491.ContName4)
    x3491.ContName5 = trim$(  x3491.ContName5)
    x3491.ContName6 = trim$(  x3491.ContName6)
    x3491.ContName7 = trim$(  x3491.ContName7)
    x3491.ContName8 = trim$(  x3491.ContName8)
    x3491.ContName9 = trim$(  x3491.ContName9)
    x3491.ContName10 = trim$(  x3491.ContName10)
    x3491.QtyPL1 = trim$(  x3491.QtyPL1)
    x3491.QtyPL2 = trim$(  x3491.QtyPL2)
    x3491.QtyPL3 = trim$(  x3491.QtyPL3)
    x3491.QtyPL4 = trim$(  x3491.QtyPL4)
    x3491.QtyPL5 = trim$(  x3491.QtyPL5)
    x3491.QtyPL6 = trim$(  x3491.QtyPL6)
    x3491.QtyPL7 = trim$(  x3491.QtyPL7)
    x3491.QtyPL8 = trim$(  x3491.QtyPL8)
    x3491.QtyPL9 = trim$(  x3491.QtyPL9)
    x3491.QtyPL10 = trim$(  x3491.QtyPL10)
    x3491.seSite = trim$(  x3491.seSite)
    x3491.cdSite = trim$(  x3491.cdSite)
    x3491.Autokey_P = trim$(  x3491.Autokey_P)
    x3491.Remark = trim$(  x3491.Remark)
    x3491.TimeInsert = trim$(  x3491.TimeInsert)
    x3491.TimeUpdate = trim$(  x3491.TimeUpdate)
    x3491.DateUpdate = trim$(  x3491.DateUpdate)
    x3491.DateInsert = trim$(  x3491.DateInsert)
    x3491.InchargeInsert = trim$(  x3491.InchargeInsert)
    x3491.InchargeUpdate = trim$(  x3491.InchargeUpdate)
     
    If trim$( x3491.WIPNo ) = "" Then x3491.WIPNo = Space(1) 
    If trim$( x3491.WIPSeq ) = "" Then x3491.WIPSeq = Space(1) 
    If trim$( x3491.InvoiceNo ) = "" Then x3491.InvoiceNo = Space(1) 
    If trim$( x3491.InvoiceSeq ) = "" Then x3491.InvoiceSeq = Space(1) 
    If trim$( x3491.SONo ) = "" Then x3491.SONo = Space(1) 
    If trim$( x3491.BookingNo ) = "" Then x3491.BookingNo = Space(1) 
    If trim$( x3491.LoadingNo ) = "" Then x3491.LoadingNo = Space(1) 
    If trim$( x3491.VesselName ) = "" Then x3491.VesselName = Space(1) 
    If trim$( x3491.TradingName ) = "" Then x3491.TradingName = Space(1) 
    If trim$( x3491.TradingCode ) = "" Then x3491.TradingCode = Space(1) 
    If trim$( x3491.ShipmentType ) = "" Then x3491.ShipmentType = Space(1) 
    If trim$( x3491.DateBL ) = "" Then x3491.DateBL = Space(1) 
    If trim$( x3491.BLNo ) = "" Then x3491.BLNo = Space(1) 
    If trim$( x3491.ContainerNo ) = "" Then x3491.ContainerNo = Space(1) 
    If trim$( x3491.seShipType ) = "" Then x3491.seShipType = Space(1) 
    If trim$( x3491.cdShipType ) = "" Then x3491.cdShipType = Space(1) 
    If trim$( x3491.DateEXFac ) = "" Then x3491.DateEXFac = Space(1) 
    If trim$( x3491.DateETD ) = "" Then x3491.DateETD = Space(1) 
    If trim$( x3491.DateETA ) = "" Then x3491.DateETA = Space(1) 
    If trim$( x3491.OrderNo ) = "" Then x3491.OrderNo = Space(1) 
    If trim$( x3491.OrderNoSeq ) = "" Then x3491.OrderNoSeq = Space(1) 
    If trim$( x3491.LoadingCode ) = "" Then x3491.LoadingCode = Space(1) 
    If trim$( x3491.TransferType ) = "" Then x3491.TransferType = Space(1) 
    If trim$( x3491.ChkDeclare ) = "" Then x3491.ChkDeclare = Space(1) 
    If trim$( x3491.DateDeclare ) = "" Then x3491.DateDeclare = Space(1) 
    If trim$( x3491.ChkSMDocs ) = "" Then x3491.ChkSMDocs = Space(1) 
    If trim$( x3491.DateSMDocs ) = "" Then x3491.DateSMDocs = Space(1) 
    If trim$( x3491.ChkLocalCharge ) = "" Then x3491.ChkLocalCharge = Space(1) 
    If trim$( x3491.DateLocalCharge ) = "" Then x3491.DateLocalCharge = Space(1) 
    If trim$( x3491.ChkUploadDocs ) = "" Then x3491.ChkUploadDocs = Space(1) 
    If trim$( x3491.DateUploadDocs ) = "" Then x3491.DateUploadDocs = Space(1) 
    If trim$( x3491.ChkDocsHK ) = "" Then x3491.ChkDocsHK = Space(1) 
    If trim$( x3491.DateDocsHK ) = "" Then x3491.DateDocsHK = Space(1) 
    If trim$( x3491.ChkDocsBuyer ) = "" Then x3491.ChkDocsBuyer = Space(1) 
    If trim$( x3491.ChkReceiveHK ) = "" Then x3491.ChkReceiveHK = Space(1) 
    If trim$( x3491.ChkPending ) = "" Then x3491.ChkPending = Space(1) 
    If trim$( x3491.DateDocsBuyer ) = "" Then x3491.DateDocsBuyer = Space(1) 
    If trim$( x3491.CheckStatus ) = "" Then x3491.CheckStatus = 0 
    If trim$( x3491.QtyOrder ) = "" Then x3491.QtyOrder = 0 
    If trim$( x3491.QtyOrderSample ) = "" Then x3491.QtyOrderSample = 0 
    If trim$( x3491.PriceOrderFOB ) = "" Then x3491.PriceOrderFOB = 0 
    If trim$( x3491.TotalAMTFOB ) = "" Then x3491.TotalAMTFOB = 0 
    If trim$( x3491.PriceOrder ) = "" Then x3491.PriceOrder = 0 
    If trim$( x3491.TotalAMT ) = "" Then x3491.TotalAMT = 0 
    If trim$( x3491.TotalGW ) = "" Then x3491.TotalGW = 0 
    If trim$( x3491.TotalNW ) = "" Then x3491.TotalNW = 0 
    If trim$( x3491.TotalCBM ) = "" Then x3491.TotalCBM = 0 
    If trim$( x3491.TotalQty ) = "" Then x3491.TotalQty = 0 
    If trim$( x3491.TotalCnt ) = "" Then x3491.TotalCnt = 0 
    If trim$( x3491.ContName1 ) = "" Then x3491.ContName1 = Space(1) 
    If trim$( x3491.ContName2 ) = "" Then x3491.ContName2 = Space(1) 
    If trim$( x3491.ContName3 ) = "" Then x3491.ContName3 = Space(1) 
    If trim$( x3491.ContName4 ) = "" Then x3491.ContName4 = Space(1) 
    If trim$( x3491.ContName5 ) = "" Then x3491.ContName5 = Space(1) 
    If trim$( x3491.ContName6 ) = "" Then x3491.ContName6 = Space(1) 
    If trim$( x3491.ContName7 ) = "" Then x3491.ContName7 = Space(1) 
    If trim$( x3491.ContName8 ) = "" Then x3491.ContName8 = Space(1) 
    If trim$( x3491.ContName9 ) = "" Then x3491.ContName9 = Space(1) 
    If trim$( x3491.ContName10 ) = "" Then x3491.ContName10 = Space(1) 
    If trim$( x3491.QtyPL1 ) = "" Then x3491.QtyPL1 = 0 
    If trim$( x3491.QtyPL2 ) = "" Then x3491.QtyPL2 = 0 
    If trim$( x3491.QtyPL3 ) = "" Then x3491.QtyPL3 = 0 
    If trim$( x3491.QtyPL4 ) = "" Then x3491.QtyPL4 = 0 
    If trim$( x3491.QtyPL5 ) = "" Then x3491.QtyPL5 = 0 
    If trim$( x3491.QtyPL6 ) = "" Then x3491.QtyPL6 = 0 
    If trim$( x3491.QtyPL7 ) = "" Then x3491.QtyPL7 = 0 
    If trim$( x3491.QtyPL8 ) = "" Then x3491.QtyPL8 = 0 
    If trim$( x3491.QtyPL9 ) = "" Then x3491.QtyPL9 = 0 
    If trim$( x3491.QtyPL10 ) = "" Then x3491.QtyPL10 = 0 
    If trim$( x3491.seSite ) = "" Then x3491.seSite = Space(1) 
    If trim$( x3491.cdSite ) = "" Then x3491.cdSite = Space(1) 
    If trim$( x3491.Autokey_P ) = "" Then x3491.Autokey_P = 0 
    If trim$( x3491.Remark ) = "" Then x3491.Remark = Space(1) 
    If trim$( x3491.TimeInsert ) = "" Then x3491.TimeInsert = Space(1) 
    If trim$( x3491.TimeUpdate ) = "" Then x3491.TimeUpdate = Space(1) 
    If trim$( x3491.DateUpdate ) = "" Then x3491.DateUpdate = Space(1) 
    If trim$( x3491.DateInsert ) = "" Then x3491.DateInsert = Space(1) 
    If trim$( x3491.InchargeInsert ) = "" Then x3491.InchargeInsert = Space(1) 
    If trim$( x3491.InchargeUpdate ) = "" Then x3491.InchargeUpdate = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K3491_MOVE(rs3491 As SqlClient.SqlDataReader)
Try

    call D3491_CLEAR()   

    If IsdbNull(rs3491!K3491_WIPNo) = False Then D3491.WIPNo = Trim$(rs3491!K3491_WIPNo)
    If IsdbNull(rs3491!K3491_WIPSeq) = False Then D3491.WIPSeq = Trim$(rs3491!K3491_WIPSeq)
    If IsdbNull(rs3491!K3491_InvoiceNo) = False Then D3491.InvoiceNo = Trim$(rs3491!K3491_InvoiceNo)
    If IsdbNull(rs3491!K3491_InvoiceSeq) = False Then D3491.InvoiceSeq = Trim$(rs3491!K3491_InvoiceSeq)
    If IsdbNull(rs3491!K3491_SONo) = False Then D3491.SONo = Trim$(rs3491!K3491_SONo)
    If IsdbNull(rs3491!K3491_BookingNo) = False Then D3491.BookingNo = Trim$(rs3491!K3491_BookingNo)
    If IsdbNull(rs3491!K3491_LoadingNo) = False Then D3491.LoadingNo = Trim$(rs3491!K3491_LoadingNo)
    If IsdbNull(rs3491!K3491_VesselName) = False Then D3491.VesselName = Trim$(rs3491!K3491_VesselName)
    If IsdbNull(rs3491!K3491_TradingName) = False Then D3491.TradingName = Trim$(rs3491!K3491_TradingName)
    If IsdbNull(rs3491!K3491_TradingCode) = False Then D3491.TradingCode = Trim$(rs3491!K3491_TradingCode)
    If IsdbNull(rs3491!K3491_ShipmentType) = False Then D3491.ShipmentType = Trim$(rs3491!K3491_ShipmentType)
    If IsdbNull(rs3491!K3491_DateBL) = False Then D3491.DateBL = Trim$(rs3491!K3491_DateBL)
    If IsdbNull(rs3491!K3491_BLNo) = False Then D3491.BLNo = Trim$(rs3491!K3491_BLNo)
    If IsdbNull(rs3491!K3491_ContainerNo) = False Then D3491.ContainerNo = Trim$(rs3491!K3491_ContainerNo)
    If IsdbNull(rs3491!K3491_seShipType) = False Then D3491.seShipType = Trim$(rs3491!K3491_seShipType)
    If IsdbNull(rs3491!K3491_cdShipType) = False Then D3491.cdShipType = Trim$(rs3491!K3491_cdShipType)
    If IsdbNull(rs3491!K3491_DateEXFac) = False Then D3491.DateEXFac = Trim$(rs3491!K3491_DateEXFac)
    If IsdbNull(rs3491!K3491_DateETD) = False Then D3491.DateETD = Trim$(rs3491!K3491_DateETD)
    If IsdbNull(rs3491!K3491_DateETA) = False Then D3491.DateETA = Trim$(rs3491!K3491_DateETA)
    If IsdbNull(rs3491!K3491_OrderNo) = False Then D3491.OrderNo = Trim$(rs3491!K3491_OrderNo)
    If IsdbNull(rs3491!K3491_OrderNoSeq) = False Then D3491.OrderNoSeq = Trim$(rs3491!K3491_OrderNoSeq)
    If IsdbNull(rs3491!K3491_LoadingCode) = False Then D3491.LoadingCode = Trim$(rs3491!K3491_LoadingCode)
    If IsdbNull(rs3491!K3491_TransferType) = False Then D3491.TransferType = Trim$(rs3491!K3491_TransferType)
    If IsdbNull(rs3491!K3491_ChkDeclare) = False Then D3491.ChkDeclare = Trim$(rs3491!K3491_ChkDeclare)
    If IsdbNull(rs3491!K3491_DateDeclare) = False Then D3491.DateDeclare = Trim$(rs3491!K3491_DateDeclare)
    If IsdbNull(rs3491!K3491_ChkSMDocs) = False Then D3491.ChkSMDocs = Trim$(rs3491!K3491_ChkSMDocs)
    If IsdbNull(rs3491!K3491_DateSMDocs) = False Then D3491.DateSMDocs = Trim$(rs3491!K3491_DateSMDocs)
    If IsdbNull(rs3491!K3491_ChkLocalCharge) = False Then D3491.ChkLocalCharge = Trim$(rs3491!K3491_ChkLocalCharge)
    If IsdbNull(rs3491!K3491_DateLocalCharge) = False Then D3491.DateLocalCharge = Trim$(rs3491!K3491_DateLocalCharge)
    If IsdbNull(rs3491!K3491_ChkUploadDocs) = False Then D3491.ChkUploadDocs = Trim$(rs3491!K3491_ChkUploadDocs)
    If IsdbNull(rs3491!K3491_DateUploadDocs) = False Then D3491.DateUploadDocs = Trim$(rs3491!K3491_DateUploadDocs)
    If IsdbNull(rs3491!K3491_ChkDocsHK) = False Then D3491.ChkDocsHK = Trim$(rs3491!K3491_ChkDocsHK)
    If IsdbNull(rs3491!K3491_DateDocsHK) = False Then D3491.DateDocsHK = Trim$(rs3491!K3491_DateDocsHK)
    If IsdbNull(rs3491!K3491_ChkDocsBuyer) = False Then D3491.ChkDocsBuyer = Trim$(rs3491!K3491_ChkDocsBuyer)
    If IsdbNull(rs3491!K3491_ChkReceiveHK) = False Then D3491.ChkReceiveHK = Trim$(rs3491!K3491_ChkReceiveHK)
    If IsdbNull(rs3491!K3491_ChkPending) = False Then D3491.ChkPending = Trim$(rs3491!K3491_ChkPending)
    If IsdbNull(rs3491!K3491_DateDocsBuyer) = False Then D3491.DateDocsBuyer = Trim$(rs3491!K3491_DateDocsBuyer)
    If IsdbNull(rs3491!K3491_CheckStatus) = False Then D3491.CheckStatus = Trim$(rs3491!K3491_CheckStatus)
    If IsdbNull(rs3491!K3491_QtyOrder) = False Then D3491.QtyOrder = Trim$(rs3491!K3491_QtyOrder)
    If IsdbNull(rs3491!K3491_QtyOrderSample) = False Then D3491.QtyOrderSample = Trim$(rs3491!K3491_QtyOrderSample)
    If IsdbNull(rs3491!K3491_PriceOrderFOB) = False Then D3491.PriceOrderFOB = Trim$(rs3491!K3491_PriceOrderFOB)
    If IsdbNull(rs3491!K3491_TotalAMTFOB) = False Then D3491.TotalAMTFOB = Trim$(rs3491!K3491_TotalAMTFOB)
    If IsdbNull(rs3491!K3491_PriceOrder) = False Then D3491.PriceOrder = Trim$(rs3491!K3491_PriceOrder)
    If IsdbNull(rs3491!K3491_TotalAMT) = False Then D3491.TotalAMT = Trim$(rs3491!K3491_TotalAMT)
    If IsdbNull(rs3491!K3491_TotalGW) = False Then D3491.TotalGW = Trim$(rs3491!K3491_TotalGW)
    If IsdbNull(rs3491!K3491_TotalNW) = False Then D3491.TotalNW = Trim$(rs3491!K3491_TotalNW)
    If IsdbNull(rs3491!K3491_TotalCBM) = False Then D3491.TotalCBM = Trim$(rs3491!K3491_TotalCBM)
    If IsdbNull(rs3491!K3491_TotalQty) = False Then D3491.TotalQty = Trim$(rs3491!K3491_TotalQty)
    If IsdbNull(rs3491!K3491_TotalCnt) = False Then D3491.TotalCnt = Trim$(rs3491!K3491_TotalCnt)
    If IsdbNull(rs3491!K3491_ContName1) = False Then D3491.ContName1 = Trim$(rs3491!K3491_ContName1)
    If IsdbNull(rs3491!K3491_ContName2) = False Then D3491.ContName2 = Trim$(rs3491!K3491_ContName2)
    If IsdbNull(rs3491!K3491_ContName3) = False Then D3491.ContName3 = Trim$(rs3491!K3491_ContName3)
    If IsdbNull(rs3491!K3491_ContName4) = False Then D3491.ContName4 = Trim$(rs3491!K3491_ContName4)
    If IsdbNull(rs3491!K3491_ContName5) = False Then D3491.ContName5 = Trim$(rs3491!K3491_ContName5)
    If IsdbNull(rs3491!K3491_ContName6) = False Then D3491.ContName6 = Trim$(rs3491!K3491_ContName6)
    If IsdbNull(rs3491!K3491_ContName7) = False Then D3491.ContName7 = Trim$(rs3491!K3491_ContName7)
    If IsdbNull(rs3491!K3491_ContName8) = False Then D3491.ContName8 = Trim$(rs3491!K3491_ContName8)
    If IsdbNull(rs3491!K3491_ContName9) = False Then D3491.ContName9 = Trim$(rs3491!K3491_ContName9)
    If IsdbNull(rs3491!K3491_ContName10) = False Then D3491.ContName10 = Trim$(rs3491!K3491_ContName10)
    If IsdbNull(rs3491!K3491_QtyPL1) = False Then D3491.QtyPL1 = Trim$(rs3491!K3491_QtyPL1)
    If IsdbNull(rs3491!K3491_QtyPL2) = False Then D3491.QtyPL2 = Trim$(rs3491!K3491_QtyPL2)
    If IsdbNull(rs3491!K3491_QtyPL3) = False Then D3491.QtyPL3 = Trim$(rs3491!K3491_QtyPL3)
    If IsdbNull(rs3491!K3491_QtyPL4) = False Then D3491.QtyPL4 = Trim$(rs3491!K3491_QtyPL4)
    If IsdbNull(rs3491!K3491_QtyPL5) = False Then D3491.QtyPL5 = Trim$(rs3491!K3491_QtyPL5)
    If IsdbNull(rs3491!K3491_QtyPL6) = False Then D3491.QtyPL6 = Trim$(rs3491!K3491_QtyPL6)
    If IsdbNull(rs3491!K3491_QtyPL7) = False Then D3491.QtyPL7 = Trim$(rs3491!K3491_QtyPL7)
    If IsdbNull(rs3491!K3491_QtyPL8) = False Then D3491.QtyPL8 = Trim$(rs3491!K3491_QtyPL8)
    If IsdbNull(rs3491!K3491_QtyPL9) = False Then D3491.QtyPL9 = Trim$(rs3491!K3491_QtyPL9)
    If IsdbNull(rs3491!K3491_QtyPL10) = False Then D3491.QtyPL10 = Trim$(rs3491!K3491_QtyPL10)
    If IsdbNull(rs3491!K3491_seSite) = False Then D3491.seSite = Trim$(rs3491!K3491_seSite)
    If IsdbNull(rs3491!K3491_cdSite) = False Then D3491.cdSite = Trim$(rs3491!K3491_cdSite)
    If IsdbNull(rs3491!K3491_Autokey_P) = False Then D3491.Autokey_P = Trim$(rs3491!K3491_Autokey_P)
    If IsdbNull(rs3491!K3491_Remark) = False Then D3491.Remark = Trim$(rs3491!K3491_Remark)
    If IsdbNull(rs3491!K3491_TimeInsert) = False Then D3491.TimeInsert = Trim$(rs3491!K3491_TimeInsert)
    If IsdbNull(rs3491!K3491_TimeUpdate) = False Then D3491.TimeUpdate = Trim$(rs3491!K3491_TimeUpdate)
    If IsdbNull(rs3491!K3491_DateUpdate) = False Then D3491.DateUpdate = Trim$(rs3491!K3491_DateUpdate)
    If IsdbNull(rs3491!K3491_DateInsert) = False Then D3491.DateInsert = Trim$(rs3491!K3491_DateInsert)
    If IsdbNull(rs3491!K3491_InchargeInsert) = False Then D3491.InchargeInsert = Trim$(rs3491!K3491_InchargeInsert)
    If IsdbNull(rs3491!K3491_InchargeUpdate) = False Then D3491.InchargeUpdate = Trim$(rs3491!K3491_InchargeUpdate)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K3491_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K3491_MOVE(rs3491 As DataRow)
Try

    call D3491_CLEAR()   

    If IsdbNull(rs3491!K3491_WIPNo) = False Then D3491.WIPNo = Trim$(rs3491!K3491_WIPNo)
    If IsdbNull(rs3491!K3491_WIPSeq) = False Then D3491.WIPSeq = Trim$(rs3491!K3491_WIPSeq)
    If IsdbNull(rs3491!K3491_InvoiceNo) = False Then D3491.InvoiceNo = Trim$(rs3491!K3491_InvoiceNo)
    If IsdbNull(rs3491!K3491_InvoiceSeq) = False Then D3491.InvoiceSeq = Trim$(rs3491!K3491_InvoiceSeq)
    If IsdbNull(rs3491!K3491_SONo) = False Then D3491.SONo = Trim$(rs3491!K3491_SONo)
    If IsdbNull(rs3491!K3491_BookingNo) = False Then D3491.BookingNo = Trim$(rs3491!K3491_BookingNo)
    If IsdbNull(rs3491!K3491_LoadingNo) = False Then D3491.LoadingNo = Trim$(rs3491!K3491_LoadingNo)
    If IsdbNull(rs3491!K3491_VesselName) = False Then D3491.VesselName = Trim$(rs3491!K3491_VesselName)
    If IsdbNull(rs3491!K3491_TradingName) = False Then D3491.TradingName = Trim$(rs3491!K3491_TradingName)
    If IsdbNull(rs3491!K3491_TradingCode) = False Then D3491.TradingCode = Trim$(rs3491!K3491_TradingCode)
    If IsdbNull(rs3491!K3491_ShipmentType) = False Then D3491.ShipmentType = Trim$(rs3491!K3491_ShipmentType)
    If IsdbNull(rs3491!K3491_DateBL) = False Then D3491.DateBL = Trim$(rs3491!K3491_DateBL)
    If IsdbNull(rs3491!K3491_BLNo) = False Then D3491.BLNo = Trim$(rs3491!K3491_BLNo)
    If IsdbNull(rs3491!K3491_ContainerNo) = False Then D3491.ContainerNo = Trim$(rs3491!K3491_ContainerNo)
    If IsdbNull(rs3491!K3491_seShipType) = False Then D3491.seShipType = Trim$(rs3491!K3491_seShipType)
    If IsdbNull(rs3491!K3491_cdShipType) = False Then D3491.cdShipType = Trim$(rs3491!K3491_cdShipType)
    If IsdbNull(rs3491!K3491_DateEXFac) = False Then D3491.DateEXFac = Trim$(rs3491!K3491_DateEXFac)
    If IsdbNull(rs3491!K3491_DateETD) = False Then D3491.DateETD = Trim$(rs3491!K3491_DateETD)
    If IsdbNull(rs3491!K3491_DateETA) = False Then D3491.DateETA = Trim$(rs3491!K3491_DateETA)
    If IsdbNull(rs3491!K3491_OrderNo) = False Then D3491.OrderNo = Trim$(rs3491!K3491_OrderNo)
    If IsdbNull(rs3491!K3491_OrderNoSeq) = False Then D3491.OrderNoSeq = Trim$(rs3491!K3491_OrderNoSeq)
    If IsdbNull(rs3491!K3491_LoadingCode) = False Then D3491.LoadingCode = Trim$(rs3491!K3491_LoadingCode)
    If IsdbNull(rs3491!K3491_TransferType) = False Then D3491.TransferType = Trim$(rs3491!K3491_TransferType)
    If IsdbNull(rs3491!K3491_ChkDeclare) = False Then D3491.ChkDeclare = Trim$(rs3491!K3491_ChkDeclare)
    If IsdbNull(rs3491!K3491_DateDeclare) = False Then D3491.DateDeclare = Trim$(rs3491!K3491_DateDeclare)
    If IsdbNull(rs3491!K3491_ChkSMDocs) = False Then D3491.ChkSMDocs = Trim$(rs3491!K3491_ChkSMDocs)
    If IsdbNull(rs3491!K3491_DateSMDocs) = False Then D3491.DateSMDocs = Trim$(rs3491!K3491_DateSMDocs)
    If IsdbNull(rs3491!K3491_ChkLocalCharge) = False Then D3491.ChkLocalCharge = Trim$(rs3491!K3491_ChkLocalCharge)
    If IsdbNull(rs3491!K3491_DateLocalCharge) = False Then D3491.DateLocalCharge = Trim$(rs3491!K3491_DateLocalCharge)
    If IsdbNull(rs3491!K3491_ChkUploadDocs) = False Then D3491.ChkUploadDocs = Trim$(rs3491!K3491_ChkUploadDocs)
    If IsdbNull(rs3491!K3491_DateUploadDocs) = False Then D3491.DateUploadDocs = Trim$(rs3491!K3491_DateUploadDocs)
    If IsdbNull(rs3491!K3491_ChkDocsHK) = False Then D3491.ChkDocsHK = Trim$(rs3491!K3491_ChkDocsHK)
    If IsdbNull(rs3491!K3491_DateDocsHK) = False Then D3491.DateDocsHK = Trim$(rs3491!K3491_DateDocsHK)
    If IsdbNull(rs3491!K3491_ChkDocsBuyer) = False Then D3491.ChkDocsBuyer = Trim$(rs3491!K3491_ChkDocsBuyer)
    If IsdbNull(rs3491!K3491_ChkReceiveHK) = False Then D3491.ChkReceiveHK = Trim$(rs3491!K3491_ChkReceiveHK)
    If IsdbNull(rs3491!K3491_ChkPending) = False Then D3491.ChkPending = Trim$(rs3491!K3491_ChkPending)
    If IsdbNull(rs3491!K3491_DateDocsBuyer) = False Then D3491.DateDocsBuyer = Trim$(rs3491!K3491_DateDocsBuyer)
    If IsdbNull(rs3491!K3491_CheckStatus) = False Then D3491.CheckStatus = Trim$(rs3491!K3491_CheckStatus)
    If IsdbNull(rs3491!K3491_QtyOrder) = False Then D3491.QtyOrder = Trim$(rs3491!K3491_QtyOrder)
    If IsdbNull(rs3491!K3491_QtyOrderSample) = False Then D3491.QtyOrderSample = Trim$(rs3491!K3491_QtyOrderSample)
    If IsdbNull(rs3491!K3491_PriceOrderFOB) = False Then D3491.PriceOrderFOB = Trim$(rs3491!K3491_PriceOrderFOB)
    If IsdbNull(rs3491!K3491_TotalAMTFOB) = False Then D3491.TotalAMTFOB = Trim$(rs3491!K3491_TotalAMTFOB)
    If IsdbNull(rs3491!K3491_PriceOrder) = False Then D3491.PriceOrder = Trim$(rs3491!K3491_PriceOrder)
    If IsdbNull(rs3491!K3491_TotalAMT) = False Then D3491.TotalAMT = Trim$(rs3491!K3491_TotalAMT)
    If IsdbNull(rs3491!K3491_TotalGW) = False Then D3491.TotalGW = Trim$(rs3491!K3491_TotalGW)
    If IsdbNull(rs3491!K3491_TotalNW) = False Then D3491.TotalNW = Trim$(rs3491!K3491_TotalNW)
    If IsdbNull(rs3491!K3491_TotalCBM) = False Then D3491.TotalCBM = Trim$(rs3491!K3491_TotalCBM)
    If IsdbNull(rs3491!K3491_TotalQty) = False Then D3491.TotalQty = Trim$(rs3491!K3491_TotalQty)
    If IsdbNull(rs3491!K3491_TotalCnt) = False Then D3491.TotalCnt = Trim$(rs3491!K3491_TotalCnt)
    If IsdbNull(rs3491!K3491_ContName1) = False Then D3491.ContName1 = Trim$(rs3491!K3491_ContName1)
    If IsdbNull(rs3491!K3491_ContName2) = False Then D3491.ContName2 = Trim$(rs3491!K3491_ContName2)
    If IsdbNull(rs3491!K3491_ContName3) = False Then D3491.ContName3 = Trim$(rs3491!K3491_ContName3)
    If IsdbNull(rs3491!K3491_ContName4) = False Then D3491.ContName4 = Trim$(rs3491!K3491_ContName4)
    If IsdbNull(rs3491!K3491_ContName5) = False Then D3491.ContName5 = Trim$(rs3491!K3491_ContName5)
    If IsdbNull(rs3491!K3491_ContName6) = False Then D3491.ContName6 = Trim$(rs3491!K3491_ContName6)
    If IsdbNull(rs3491!K3491_ContName7) = False Then D3491.ContName7 = Trim$(rs3491!K3491_ContName7)
    If IsdbNull(rs3491!K3491_ContName8) = False Then D3491.ContName8 = Trim$(rs3491!K3491_ContName8)
    If IsdbNull(rs3491!K3491_ContName9) = False Then D3491.ContName9 = Trim$(rs3491!K3491_ContName9)
    If IsdbNull(rs3491!K3491_ContName10) = False Then D3491.ContName10 = Trim$(rs3491!K3491_ContName10)
    If IsdbNull(rs3491!K3491_QtyPL1) = False Then D3491.QtyPL1 = Trim$(rs3491!K3491_QtyPL1)
    If IsdbNull(rs3491!K3491_QtyPL2) = False Then D3491.QtyPL2 = Trim$(rs3491!K3491_QtyPL2)
    If IsdbNull(rs3491!K3491_QtyPL3) = False Then D3491.QtyPL3 = Trim$(rs3491!K3491_QtyPL3)
    If IsdbNull(rs3491!K3491_QtyPL4) = False Then D3491.QtyPL4 = Trim$(rs3491!K3491_QtyPL4)
    If IsdbNull(rs3491!K3491_QtyPL5) = False Then D3491.QtyPL5 = Trim$(rs3491!K3491_QtyPL5)
    If IsdbNull(rs3491!K3491_QtyPL6) = False Then D3491.QtyPL6 = Trim$(rs3491!K3491_QtyPL6)
    If IsdbNull(rs3491!K3491_QtyPL7) = False Then D3491.QtyPL7 = Trim$(rs3491!K3491_QtyPL7)
    If IsdbNull(rs3491!K3491_QtyPL8) = False Then D3491.QtyPL8 = Trim$(rs3491!K3491_QtyPL8)
    If IsdbNull(rs3491!K3491_QtyPL9) = False Then D3491.QtyPL9 = Trim$(rs3491!K3491_QtyPL9)
    If IsdbNull(rs3491!K3491_QtyPL10) = False Then D3491.QtyPL10 = Trim$(rs3491!K3491_QtyPL10)
    If IsdbNull(rs3491!K3491_seSite) = False Then D3491.seSite = Trim$(rs3491!K3491_seSite)
    If IsdbNull(rs3491!K3491_cdSite) = False Then D3491.cdSite = Trim$(rs3491!K3491_cdSite)
    If IsdbNull(rs3491!K3491_Autokey_P) = False Then D3491.Autokey_P = Trim$(rs3491!K3491_Autokey_P)
    If IsdbNull(rs3491!K3491_Remark) = False Then D3491.Remark = Trim$(rs3491!K3491_Remark)
    If IsdbNull(rs3491!K3491_TimeInsert) = False Then D3491.TimeInsert = Trim$(rs3491!K3491_TimeInsert)
    If IsdbNull(rs3491!K3491_TimeUpdate) = False Then D3491.TimeUpdate = Trim$(rs3491!K3491_TimeUpdate)
    If IsdbNull(rs3491!K3491_DateUpdate) = False Then D3491.DateUpdate = Trim$(rs3491!K3491_DateUpdate)
    If IsdbNull(rs3491!K3491_DateInsert) = False Then D3491.DateInsert = Trim$(rs3491!K3491_DateInsert)
    If IsdbNull(rs3491!K3491_InchargeInsert) = False Then D3491.InchargeInsert = Trim$(rs3491!K3491_InchargeInsert)
    If IsdbNull(rs3491!K3491_InchargeUpdate) = False Then D3491.InchargeUpdate = Trim$(rs3491!K3491_InchargeUpdate)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K3491_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K3491_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z3491 As T3491_AREA, WIPNO AS String, WIPSEQ AS String) as Boolean

K3491_MOVE = False

Try
    If READ_PFK3491(WIPNO, WIPSEQ) = True Then
                z3491 = D3491
		K3491_MOVE = True
		else
	z3491 = nothing
     End If

     If  getColumnIndex(spr,"WIPNo") > -1 then z3491.WIPNo = getDataM(spr, getColumnIndex(spr,"WIPNo"), xRow)
     If  getColumnIndex(spr,"WIPSeq") > -1 then z3491.WIPSeq = getDataM(spr, getColumnIndex(spr,"WIPSeq"), xRow)
     If  getColumnIndex(spr,"InvoiceNo") > -1 then z3491.InvoiceNo = getDataM(spr, getColumnIndex(spr,"InvoiceNo"), xRow)
     If  getColumnIndex(spr,"InvoiceSeq") > -1 then z3491.InvoiceSeq = getDataM(spr, getColumnIndex(spr,"InvoiceSeq"), xRow)
     If  getColumnIndex(spr,"SONo") > -1 then z3491.SONo = getDataM(spr, getColumnIndex(spr,"SONo"), xRow)
     If  getColumnIndex(spr,"BookingNo") > -1 then z3491.BookingNo = getDataM(spr, getColumnIndex(spr,"BookingNo"), xRow)
     If  getColumnIndex(spr,"LoadingNo") > -1 then z3491.LoadingNo = getDataM(spr, getColumnIndex(spr,"LoadingNo"), xRow)
     If  getColumnIndex(spr,"VesselName") > -1 then z3491.VesselName = getDataM(spr, getColumnIndex(spr,"VesselName"), xRow)
     If  getColumnIndex(spr,"TradingName") > -1 then z3491.TradingName = getDataM(spr, getColumnIndex(spr,"TradingName"), xRow)
     If  getColumnIndex(spr,"TradingCode") > -1 then z3491.TradingCode = getDataM(spr, getColumnIndex(spr,"TradingCode"), xRow)
     If  getColumnIndex(spr,"ShipmentType") > -1 then z3491.ShipmentType = getDataM(spr, getColumnIndex(spr,"ShipmentType"), xRow)
     If  getColumnIndex(spr,"DateBL") > -1 then z3491.DateBL = getDataM(spr, getColumnIndex(spr,"DateBL"), xRow)
     If  getColumnIndex(spr,"BLNo") > -1 then z3491.BLNo = getDataM(spr, getColumnIndex(spr,"BLNo"), xRow)
     If  getColumnIndex(spr,"ContainerNo") > -1 then z3491.ContainerNo = getDataM(spr, getColumnIndex(spr,"ContainerNo"), xRow)
     If  getColumnIndex(spr,"seShipType") > -1 then z3491.seShipType = getDataM(spr, getColumnIndex(spr,"seShipType"), xRow)
     If  getColumnIndex(spr,"cdShipType") > -1 then z3491.cdShipType = getDataM(spr, getColumnIndex(spr,"cdShipType"), xRow)
     If  getColumnIndex(spr,"DateEXFac") > -1 then z3491.DateEXFac = getDataM(spr, getColumnIndex(spr,"DateEXFac"), xRow)
     If  getColumnIndex(spr,"DateETD") > -1 then z3491.DateETD = getDataM(spr, getColumnIndex(spr,"DateETD"), xRow)
     If  getColumnIndex(spr,"DateETA") > -1 then z3491.DateETA = getDataM(spr, getColumnIndex(spr,"DateETA"), xRow)
     If  getColumnIndex(spr,"OrderNo") > -1 then z3491.OrderNo = getDataM(spr, getColumnIndex(spr,"OrderNo"), xRow)
     If  getColumnIndex(spr,"OrderNoSeq") > -1 then z3491.OrderNoSeq = getDataM(spr, getColumnIndex(spr,"OrderNoSeq"), xRow)
     If  getColumnIndex(spr,"LoadingCode") > -1 then z3491.LoadingCode = getDataM(spr, getColumnIndex(spr,"LoadingCode"), xRow)
     If  getColumnIndex(spr,"TransferType") > -1 then z3491.TransferType = getDataM(spr, getColumnIndex(spr,"TransferType"), xRow)
     If  getColumnIndex(spr,"ChkDeclare") > -1 then z3491.ChkDeclare = getDataM(spr, getColumnIndex(spr,"ChkDeclare"), xRow)
     If  getColumnIndex(spr,"DateDeclare") > -1 then z3491.DateDeclare = getDataM(spr, getColumnIndex(spr,"DateDeclare"), xRow)
     If  getColumnIndex(spr,"ChkSMDocs") > -1 then z3491.ChkSMDocs = getDataM(spr, getColumnIndex(spr,"ChkSMDocs"), xRow)
     If  getColumnIndex(spr,"DateSMDocs") > -1 then z3491.DateSMDocs = getDataM(spr, getColumnIndex(spr,"DateSMDocs"), xRow)
     If  getColumnIndex(spr,"ChkLocalCharge") > -1 then z3491.ChkLocalCharge = getDataM(spr, getColumnIndex(spr,"ChkLocalCharge"), xRow)
     If  getColumnIndex(spr,"DateLocalCharge") > -1 then z3491.DateLocalCharge = getDataM(spr, getColumnIndex(spr,"DateLocalCharge"), xRow)
     If  getColumnIndex(spr,"ChkUploadDocs") > -1 then z3491.ChkUploadDocs = getDataM(spr, getColumnIndex(spr,"ChkUploadDocs"), xRow)
     If  getColumnIndex(spr,"DateUploadDocs") > -1 then z3491.DateUploadDocs = getDataM(spr, getColumnIndex(spr,"DateUploadDocs"), xRow)
     If  getColumnIndex(spr,"ChkDocsHK") > -1 then z3491.ChkDocsHK = getDataM(spr, getColumnIndex(spr,"ChkDocsHK"), xRow)
     If  getColumnIndex(spr,"DateDocsHK") > -1 then z3491.DateDocsHK = getDataM(spr, getColumnIndex(spr,"DateDocsHK"), xRow)
     If  getColumnIndex(spr,"ChkDocsBuyer") > -1 then z3491.ChkDocsBuyer = getDataM(spr, getColumnIndex(spr,"ChkDocsBuyer"), xRow)
     If  getColumnIndex(spr,"ChkReceiveHK") > -1 then z3491.ChkReceiveHK = getDataM(spr, getColumnIndex(spr,"ChkReceiveHK"), xRow)
     If  getColumnIndex(spr,"ChkPending") > -1 then z3491.ChkPending = getDataM(spr, getColumnIndex(spr,"ChkPending"), xRow)
     If  getColumnIndex(spr,"DateDocsBuyer") > -1 then z3491.DateDocsBuyer = getDataM(spr, getColumnIndex(spr,"DateDocsBuyer"), xRow)
     If  getColumnIndex(spr,"CheckStatus") > -1 then z3491.CheckStatus = Cdecp(getDataM(spr, getColumnIndex(spr,"CheckStatus"), xRow))
     If  getColumnIndex(spr,"QtyOrder") > -1 then z3491.QtyOrder = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyOrder"), xRow))
     If  getColumnIndex(spr,"QtyOrderSample") > -1 then z3491.QtyOrderSample = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyOrderSample"), xRow))
     If  getColumnIndex(spr,"PriceOrderFOB") > -1 then z3491.PriceOrderFOB = Cdecp(getDataM(spr, getColumnIndex(spr,"PriceOrderFOB"), xRow))
     If  getColumnIndex(spr,"TotalAMTFOB") > -1 then z3491.TotalAMTFOB = Cdecp(getDataM(spr, getColumnIndex(spr,"TotalAMTFOB"), xRow))
     If  getColumnIndex(spr,"PriceOrder") > -1 then z3491.PriceOrder = Cdecp(getDataM(spr, getColumnIndex(spr,"PriceOrder"), xRow))
     If  getColumnIndex(spr,"TotalAMT") > -1 then z3491.TotalAMT = Cdecp(getDataM(spr, getColumnIndex(spr,"TotalAMT"), xRow))
     If  getColumnIndex(spr,"TotalGW") > -1 then z3491.TotalGW = Cdecp(getDataM(spr, getColumnIndex(spr,"TotalGW"), xRow))
     If  getColumnIndex(spr,"TotalNW") > -1 then z3491.TotalNW = Cdecp(getDataM(spr, getColumnIndex(spr,"TotalNW"), xRow))
     If  getColumnIndex(spr,"TotalCBM") > -1 then z3491.TotalCBM = Cdecp(getDataM(spr, getColumnIndex(spr,"TotalCBM"), xRow))
     If  getColumnIndex(spr,"TotalQty") > -1 then z3491.TotalQty = Cdecp(getDataM(spr, getColumnIndex(spr,"TotalQty"), xRow))
     If  getColumnIndex(spr,"TotalCnt") > -1 then z3491.TotalCnt = Cdecp(getDataM(spr, getColumnIndex(spr,"TotalCnt"), xRow))
     If  getColumnIndex(spr,"ContName1") > -1 then z3491.ContName1 = getDataM(spr, getColumnIndex(spr,"ContName1"), xRow)
     If  getColumnIndex(spr,"ContName2") > -1 then z3491.ContName2 = getDataM(spr, getColumnIndex(spr,"ContName2"), xRow)
     If  getColumnIndex(spr,"ContName3") > -1 then z3491.ContName3 = getDataM(spr, getColumnIndex(spr,"ContName3"), xRow)
     If  getColumnIndex(spr,"ContName4") > -1 then z3491.ContName4 = getDataM(spr, getColumnIndex(spr,"ContName4"), xRow)
     If  getColumnIndex(spr,"ContName5") > -1 then z3491.ContName5 = getDataM(spr, getColumnIndex(spr,"ContName5"), xRow)
     If  getColumnIndex(spr,"ContName6") > -1 then z3491.ContName6 = getDataM(spr, getColumnIndex(spr,"ContName6"), xRow)
     If  getColumnIndex(spr,"ContName7") > -1 then z3491.ContName7 = getDataM(spr, getColumnIndex(spr,"ContName7"), xRow)
     If  getColumnIndex(spr,"ContName8") > -1 then z3491.ContName8 = getDataM(spr, getColumnIndex(spr,"ContName8"), xRow)
     If  getColumnIndex(spr,"ContName9") > -1 then z3491.ContName9 = getDataM(spr, getColumnIndex(spr,"ContName9"), xRow)
     If  getColumnIndex(spr,"ContName10") > -1 then z3491.ContName10 = getDataM(spr, getColumnIndex(spr,"ContName10"), xRow)
     If  getColumnIndex(spr,"QtyPL1") > -1 then z3491.QtyPL1 = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyPL1"), xRow))
     If  getColumnIndex(spr,"QtyPL2") > -1 then z3491.QtyPL2 = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyPL2"), xRow))
     If  getColumnIndex(spr,"QtyPL3") > -1 then z3491.QtyPL3 = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyPL3"), xRow))
     If  getColumnIndex(spr,"QtyPL4") > -1 then z3491.QtyPL4 = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyPL4"), xRow))
     If  getColumnIndex(spr,"QtyPL5") > -1 then z3491.QtyPL5 = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyPL5"), xRow))
     If  getColumnIndex(spr,"QtyPL6") > -1 then z3491.QtyPL6 = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyPL6"), xRow))
     If  getColumnIndex(spr,"QtyPL7") > -1 then z3491.QtyPL7 = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyPL7"), xRow))
     If  getColumnIndex(spr,"QtyPL8") > -1 then z3491.QtyPL8 = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyPL8"), xRow))
     If  getColumnIndex(spr,"QtyPL9") > -1 then z3491.QtyPL9 = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyPL9"), xRow))
     If  getColumnIndex(spr,"QtyPL10") > -1 then z3491.QtyPL10 = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyPL10"), xRow))
     If  getColumnIndex(spr,"seSite") > -1 then z3491.seSite = getDataM(spr, getColumnIndex(spr,"seSite"), xRow)
     If  getColumnIndex(spr,"cdSite") > -1 then z3491.cdSite = getDataM(spr, getColumnIndex(spr,"cdSite"), xRow)
     If  getColumnIndex(spr,"Autokey_P") > -1 then z3491.Autokey_P = Cdecp(getDataM(spr, getColumnIndex(spr,"Autokey_P"), xRow))
     If  getColumnIndex(spr,"Remark") > -1 then z3491.Remark = getDataM(spr, getColumnIndex(spr,"Remark"), xRow)
     If  getColumnIndex(spr,"TimeInsert") > -1 then z3491.TimeInsert = getDataM(spr, getColumnIndex(spr,"TimeInsert"), xRow)
     If  getColumnIndex(spr,"TimeUpdate") > -1 then z3491.TimeUpdate = getDataM(spr, getColumnIndex(spr,"TimeUpdate"), xRow)
     If  getColumnIndex(spr,"DateUpdate") > -1 then z3491.DateUpdate = getDataM(spr, getColumnIndex(spr,"DateUpdate"), xRow)
     If  getColumnIndex(spr,"DateInsert") > -1 then z3491.DateInsert = getDataM(spr, getColumnIndex(spr,"DateInsert"), xRow)
     If  getColumnIndex(spr,"InchargeInsert") > -1 then z3491.InchargeInsert = getDataM(spr, getColumnIndex(spr,"InchargeInsert"), xRow)
     If  getColumnIndex(spr,"InchargeUpdate") > -1 then z3491.InchargeUpdate = getDataM(spr, getColumnIndex(spr,"InchargeUpdate"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K3491_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K3491_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z3491 As T3491_AREA,CheckClear as Boolean,WIPNO AS String, WIPSEQ AS String) as Boolean

K3491_MOVE = False

Try
    If READ_PFK3491(WIPNO, WIPSEQ) = True Then
                z3491 = D3491
		K3491_MOVE = True
		else
	If CheckClear  = True then z3491 = nothing
     End If

     If  getColumnIndex(spr,"WIPNo") > -1 then z3491.WIPNo = getDataM(spr, getColumnIndex(spr,"WIPNo"), xRow)
     If  getColumnIndex(spr,"WIPSeq") > -1 then z3491.WIPSeq = getDataM(spr, getColumnIndex(spr,"WIPSeq"), xRow)
     If  getColumnIndex(spr,"InvoiceNo") > -1 then z3491.InvoiceNo = getDataM(spr, getColumnIndex(spr,"InvoiceNo"), xRow)
     If  getColumnIndex(spr,"InvoiceSeq") > -1 then z3491.InvoiceSeq = getDataM(spr, getColumnIndex(spr,"InvoiceSeq"), xRow)
     If  getColumnIndex(spr,"SONo") > -1 then z3491.SONo = getDataM(spr, getColumnIndex(spr,"SONo"), xRow)
     If  getColumnIndex(spr,"BookingNo") > -1 then z3491.BookingNo = getDataM(spr, getColumnIndex(spr,"BookingNo"), xRow)
     If  getColumnIndex(spr,"LoadingNo") > -1 then z3491.LoadingNo = getDataM(spr, getColumnIndex(spr,"LoadingNo"), xRow)
     If  getColumnIndex(spr,"VesselName") > -1 then z3491.VesselName = getDataM(spr, getColumnIndex(spr,"VesselName"), xRow)
     If  getColumnIndex(spr,"TradingName") > -1 then z3491.TradingName = getDataM(spr, getColumnIndex(spr,"TradingName"), xRow)
     If  getColumnIndex(spr,"TradingCode") > -1 then z3491.TradingCode = getDataM(spr, getColumnIndex(spr,"TradingCode"), xRow)
     If  getColumnIndex(spr,"ShipmentType") > -1 then z3491.ShipmentType = getDataM(spr, getColumnIndex(spr,"ShipmentType"), xRow)
     If  getColumnIndex(spr,"DateBL") > -1 then z3491.DateBL = getDataM(spr, getColumnIndex(spr,"DateBL"), xRow)
     If  getColumnIndex(spr,"BLNo") > -1 then z3491.BLNo = getDataM(spr, getColumnIndex(spr,"BLNo"), xRow)
     If  getColumnIndex(spr,"ContainerNo") > -1 then z3491.ContainerNo = getDataM(spr, getColumnIndex(spr,"ContainerNo"), xRow)
     If  getColumnIndex(spr,"seShipType") > -1 then z3491.seShipType = getDataM(spr, getColumnIndex(spr,"seShipType"), xRow)
     If  getColumnIndex(spr,"cdShipType") > -1 then z3491.cdShipType = getDataM(spr, getColumnIndex(spr,"cdShipType"), xRow)
     If  getColumnIndex(spr,"DateEXFac") > -1 then z3491.DateEXFac = getDataM(spr, getColumnIndex(spr,"DateEXFac"), xRow)
     If  getColumnIndex(spr,"DateETD") > -1 then z3491.DateETD = getDataM(spr, getColumnIndex(spr,"DateETD"), xRow)
     If  getColumnIndex(spr,"DateETA") > -1 then z3491.DateETA = getDataM(spr, getColumnIndex(spr,"DateETA"), xRow)
     If  getColumnIndex(spr,"OrderNo") > -1 then z3491.OrderNo = getDataM(spr, getColumnIndex(spr,"OrderNo"), xRow)
     If  getColumnIndex(spr,"OrderNoSeq") > -1 then z3491.OrderNoSeq = getDataM(spr, getColumnIndex(spr,"OrderNoSeq"), xRow)
     If  getColumnIndex(spr,"LoadingCode") > -1 then z3491.LoadingCode = getDataM(spr, getColumnIndex(spr,"LoadingCode"), xRow)
     If  getColumnIndex(spr,"TransferType") > -1 then z3491.TransferType = getDataM(spr, getColumnIndex(spr,"TransferType"), xRow)
     If  getColumnIndex(spr,"ChkDeclare") > -1 then z3491.ChkDeclare = getDataM(spr, getColumnIndex(spr,"ChkDeclare"), xRow)
     If  getColumnIndex(spr,"DateDeclare") > -1 then z3491.DateDeclare = getDataM(spr, getColumnIndex(spr,"DateDeclare"), xRow)
     If  getColumnIndex(spr,"ChkSMDocs") > -1 then z3491.ChkSMDocs = getDataM(spr, getColumnIndex(spr,"ChkSMDocs"), xRow)
     If  getColumnIndex(spr,"DateSMDocs") > -1 then z3491.DateSMDocs = getDataM(spr, getColumnIndex(spr,"DateSMDocs"), xRow)
     If  getColumnIndex(spr,"ChkLocalCharge") > -1 then z3491.ChkLocalCharge = getDataM(spr, getColumnIndex(spr,"ChkLocalCharge"), xRow)
     If  getColumnIndex(spr,"DateLocalCharge") > -1 then z3491.DateLocalCharge = getDataM(spr, getColumnIndex(spr,"DateLocalCharge"), xRow)
     If  getColumnIndex(spr,"ChkUploadDocs") > -1 then z3491.ChkUploadDocs = getDataM(spr, getColumnIndex(spr,"ChkUploadDocs"), xRow)
     If  getColumnIndex(spr,"DateUploadDocs") > -1 then z3491.DateUploadDocs = getDataM(spr, getColumnIndex(spr,"DateUploadDocs"), xRow)
     If  getColumnIndex(spr,"ChkDocsHK") > -1 then z3491.ChkDocsHK = getDataM(spr, getColumnIndex(spr,"ChkDocsHK"), xRow)
     If  getColumnIndex(spr,"DateDocsHK") > -1 then z3491.DateDocsHK = getDataM(spr, getColumnIndex(spr,"DateDocsHK"), xRow)
     If  getColumnIndex(spr,"ChkDocsBuyer") > -1 then z3491.ChkDocsBuyer = getDataM(spr, getColumnIndex(spr,"ChkDocsBuyer"), xRow)
     If  getColumnIndex(spr,"ChkReceiveHK") > -1 then z3491.ChkReceiveHK = getDataM(spr, getColumnIndex(spr,"ChkReceiveHK"), xRow)
     If  getColumnIndex(spr,"ChkPending") > -1 then z3491.ChkPending = getDataM(spr, getColumnIndex(spr,"ChkPending"), xRow)
     If  getColumnIndex(spr,"DateDocsBuyer") > -1 then z3491.DateDocsBuyer = getDataM(spr, getColumnIndex(spr,"DateDocsBuyer"), xRow)
     If  getColumnIndex(spr,"CheckStatus") > -1 then z3491.CheckStatus = Cdecp(getDataM(spr, getColumnIndex(spr,"CheckStatus"), xRow))
     If  getColumnIndex(spr,"QtyOrder") > -1 then z3491.QtyOrder = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyOrder"), xRow))
     If  getColumnIndex(spr,"QtyOrderSample") > -1 then z3491.QtyOrderSample = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyOrderSample"), xRow))
     If  getColumnIndex(spr,"PriceOrderFOB") > -1 then z3491.PriceOrderFOB = Cdecp(getDataM(spr, getColumnIndex(spr,"PriceOrderFOB"), xRow))
     If  getColumnIndex(spr,"TotalAMTFOB") > -1 then z3491.TotalAMTFOB = Cdecp(getDataM(spr, getColumnIndex(spr,"TotalAMTFOB"), xRow))
     If  getColumnIndex(spr,"PriceOrder") > -1 then z3491.PriceOrder = Cdecp(getDataM(spr, getColumnIndex(spr,"PriceOrder"), xRow))
     If  getColumnIndex(spr,"TotalAMT") > -1 then z3491.TotalAMT = Cdecp(getDataM(spr, getColumnIndex(spr,"TotalAMT"), xRow))
     If  getColumnIndex(spr,"TotalGW") > -1 then z3491.TotalGW = Cdecp(getDataM(spr, getColumnIndex(spr,"TotalGW"), xRow))
     If  getColumnIndex(spr,"TotalNW") > -1 then z3491.TotalNW = Cdecp(getDataM(spr, getColumnIndex(spr,"TotalNW"), xRow))
     If  getColumnIndex(spr,"TotalCBM") > -1 then z3491.TotalCBM = Cdecp(getDataM(spr, getColumnIndex(spr,"TotalCBM"), xRow))
     If  getColumnIndex(spr,"TotalQty") > -1 then z3491.TotalQty = Cdecp(getDataM(spr, getColumnIndex(spr,"TotalQty"), xRow))
     If  getColumnIndex(spr,"TotalCnt") > -1 then z3491.TotalCnt = Cdecp(getDataM(spr, getColumnIndex(spr,"TotalCnt"), xRow))
     If  getColumnIndex(spr,"ContName1") > -1 then z3491.ContName1 = getDataM(spr, getColumnIndex(spr,"ContName1"), xRow)
     If  getColumnIndex(spr,"ContName2") > -1 then z3491.ContName2 = getDataM(spr, getColumnIndex(spr,"ContName2"), xRow)
     If  getColumnIndex(spr,"ContName3") > -1 then z3491.ContName3 = getDataM(spr, getColumnIndex(spr,"ContName3"), xRow)
     If  getColumnIndex(spr,"ContName4") > -1 then z3491.ContName4 = getDataM(spr, getColumnIndex(spr,"ContName4"), xRow)
     If  getColumnIndex(spr,"ContName5") > -1 then z3491.ContName5 = getDataM(spr, getColumnIndex(spr,"ContName5"), xRow)
     If  getColumnIndex(spr,"ContName6") > -1 then z3491.ContName6 = getDataM(spr, getColumnIndex(spr,"ContName6"), xRow)
     If  getColumnIndex(spr,"ContName7") > -1 then z3491.ContName7 = getDataM(spr, getColumnIndex(spr,"ContName7"), xRow)
     If  getColumnIndex(spr,"ContName8") > -1 then z3491.ContName8 = getDataM(spr, getColumnIndex(spr,"ContName8"), xRow)
     If  getColumnIndex(spr,"ContName9") > -1 then z3491.ContName9 = getDataM(spr, getColumnIndex(spr,"ContName9"), xRow)
     If  getColumnIndex(spr,"ContName10") > -1 then z3491.ContName10 = getDataM(spr, getColumnIndex(spr,"ContName10"), xRow)
     If  getColumnIndex(spr,"QtyPL1") > -1 then z3491.QtyPL1 = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyPL1"), xRow))
     If  getColumnIndex(spr,"QtyPL2") > -1 then z3491.QtyPL2 = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyPL2"), xRow))
     If  getColumnIndex(spr,"QtyPL3") > -1 then z3491.QtyPL3 = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyPL3"), xRow))
     If  getColumnIndex(spr,"QtyPL4") > -1 then z3491.QtyPL4 = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyPL4"), xRow))
     If  getColumnIndex(spr,"QtyPL5") > -1 then z3491.QtyPL5 = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyPL5"), xRow))
     If  getColumnIndex(spr,"QtyPL6") > -1 then z3491.QtyPL6 = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyPL6"), xRow))
     If  getColumnIndex(spr,"QtyPL7") > -1 then z3491.QtyPL7 = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyPL7"), xRow))
     If  getColumnIndex(spr,"QtyPL8") > -1 then z3491.QtyPL8 = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyPL8"), xRow))
     If  getColumnIndex(spr,"QtyPL9") > -1 then z3491.QtyPL9 = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyPL9"), xRow))
     If  getColumnIndex(spr,"QtyPL10") > -1 then z3491.QtyPL10 = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyPL10"), xRow))
     If  getColumnIndex(spr,"seSite") > -1 then z3491.seSite = getDataM(spr, getColumnIndex(spr,"seSite"), xRow)
     If  getColumnIndex(spr,"cdSite") > -1 then z3491.cdSite = getDataM(spr, getColumnIndex(spr,"cdSite"), xRow)
     If  getColumnIndex(spr,"Autokey_P") > -1 then z3491.Autokey_P = Cdecp(getDataM(spr, getColumnIndex(spr,"Autokey_P"), xRow))
     If  getColumnIndex(spr,"Remark") > -1 then z3491.Remark = getDataM(spr, getColumnIndex(spr,"Remark"), xRow)
     If  getColumnIndex(spr,"TimeInsert") > -1 then z3491.TimeInsert = getDataM(spr, getColumnIndex(spr,"TimeInsert"), xRow)
     If  getColumnIndex(spr,"TimeUpdate") > -1 then z3491.TimeUpdate = getDataM(spr, getColumnIndex(spr,"TimeUpdate"), xRow)
     If  getColumnIndex(spr,"DateUpdate") > -1 then z3491.DateUpdate = getDataM(spr, getColumnIndex(spr,"DateUpdate"), xRow)
     If  getColumnIndex(spr,"DateInsert") > -1 then z3491.DateInsert = getDataM(spr, getColumnIndex(spr,"DateInsert"), xRow)
     If  getColumnIndex(spr,"InchargeInsert") > -1 then z3491.InchargeInsert = getDataM(spr, getColumnIndex(spr,"InchargeInsert"), xRow)
     If  getColumnIndex(spr,"InchargeUpdate") > -1 then z3491.InchargeUpdate = getDataM(spr, getColumnIndex(spr,"InchargeUpdate"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K3491_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K3491_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z3491 As T3491_AREA, Job as String, WIPNO AS String, WIPSEQ AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K3491_MOVE = False

Try
    If READ_PFK3491(WIPNO, WIPSEQ) = True Then
                z3491 = D3491
		K3491_MOVE = True
		else
	z3491 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3491")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "WIPNO":z3491.WIPNo = Children(i).Code
   Case "WIPSEQ":z3491.WIPSeq = Children(i).Code
   Case "INVOICENO":z3491.InvoiceNo = Children(i).Code
   Case "INVOICESEQ":z3491.InvoiceSeq = Children(i).Code
   Case "SONO":z3491.SONo = Children(i).Code
   Case "BOOKINGNO":z3491.BookingNo = Children(i).Code
   Case "LOADINGNO":z3491.LoadingNo = Children(i).Code
   Case "VESSELNAME":z3491.VesselName = Children(i).Code
   Case "TRADINGNAME":z3491.TradingName = Children(i).Code
   Case "TRADINGCODE":z3491.TradingCode = Children(i).Code
   Case "SHIPMENTTYPE":z3491.ShipmentType = Children(i).Code
   Case "DATEBL":z3491.DateBL = Children(i).Code
   Case "BLNO":z3491.BLNo = Children(i).Code
   Case "CONTAINERNO":z3491.ContainerNo = Children(i).Code
   Case "SESHIPTYPE":z3491.seShipType = Children(i).Code
   Case "CDSHIPTYPE":z3491.cdShipType = Children(i).Code
   Case "DATEEXFAC":z3491.DateEXFac = Children(i).Code
   Case "DATEETD":z3491.DateETD = Children(i).Code
   Case "DATEETA":z3491.DateETA = Children(i).Code
   Case "ORDERNO":z3491.OrderNo = Children(i).Code
   Case "ORDERNOSEQ":z3491.OrderNoSeq = Children(i).Code
   Case "LOADINGCODE":z3491.LoadingCode = Children(i).Code
   Case "TRANSFERTYPE":z3491.TransferType = Children(i).Code
   Case "CHKDECLARE":z3491.ChkDeclare = Children(i).Code
   Case "DATEDECLARE":z3491.DateDeclare = Children(i).Code
   Case "CHKSMDOCS":z3491.ChkSMDocs = Children(i).Code
   Case "DATESMDOCS":z3491.DateSMDocs = Children(i).Code
   Case "CHKLOCALCHARGE":z3491.ChkLocalCharge = Children(i).Code
   Case "DATELOCALCHARGE":z3491.DateLocalCharge = Children(i).Code
   Case "CHKUPLOADDOCS":z3491.ChkUploadDocs = Children(i).Code
   Case "DATEUPLOADDOCS":z3491.DateUploadDocs = Children(i).Code
   Case "CHKDOCSHK":z3491.ChkDocsHK = Children(i).Code
   Case "DATEDOCSHK":z3491.DateDocsHK = Children(i).Code
   Case "CHKDOCSBUYER":z3491.ChkDocsBuyer = Children(i).Code
   Case "CHKRECEIVEHK":z3491.ChkReceiveHK = Children(i).Code
   Case "CHKPENDING":z3491.ChkPending = Children(i).Code
   Case "DATEDOCSBUYER":z3491.DateDocsBuyer = Children(i).Code
   Case "CHECKSTATUS":z3491.CheckStatus = Children(i).Code
   Case "QTYORDER":z3491.QtyOrder = Children(i).Code
   Case "QTYORDERSAMPLE":z3491.QtyOrderSample = Children(i).Code
   Case "PRICEORDERFOB":z3491.PriceOrderFOB = Children(i).Code
   Case "TOTALAMTFOB":z3491.TotalAMTFOB = Children(i).Code
   Case "PRICEORDER":z3491.PriceOrder = Children(i).Code
   Case "TOTALAMT":z3491.TotalAMT = Children(i).Code
   Case "TOTALGW":z3491.TotalGW = Children(i).Code
   Case "TOTALNW":z3491.TotalNW = Children(i).Code
   Case "TOTALCBM":z3491.TotalCBM = Children(i).Code
   Case "TOTALQTY":z3491.TotalQty = Children(i).Code
   Case "TOTALCNT":z3491.TotalCnt = Children(i).Code
   Case "CONTNAME1":z3491.ContName1 = Children(i).Code
   Case "CONTNAME2":z3491.ContName2 = Children(i).Code
   Case "CONTNAME3":z3491.ContName3 = Children(i).Code
   Case "CONTNAME4":z3491.ContName4 = Children(i).Code
   Case "CONTNAME5":z3491.ContName5 = Children(i).Code
   Case "CONTNAME6":z3491.ContName6 = Children(i).Code
   Case "CONTNAME7":z3491.ContName7 = Children(i).Code
   Case "CONTNAME8":z3491.ContName8 = Children(i).Code
   Case "CONTNAME9":z3491.ContName9 = Children(i).Code
   Case "CONTNAME10":z3491.ContName10 = Children(i).Code
   Case "QTYPL1":z3491.QtyPL1 = Children(i).Code
   Case "QTYPL2":z3491.QtyPL2 = Children(i).Code
   Case "QTYPL3":z3491.QtyPL3 = Children(i).Code
   Case "QTYPL4":z3491.QtyPL4 = Children(i).Code
   Case "QTYPL5":z3491.QtyPL5 = Children(i).Code
   Case "QTYPL6":z3491.QtyPL6 = Children(i).Code
   Case "QTYPL7":z3491.QtyPL7 = Children(i).Code
   Case "QTYPL8":z3491.QtyPL8 = Children(i).Code
   Case "QTYPL9":z3491.QtyPL9 = Children(i).Code
   Case "QTYPL10":z3491.QtyPL10 = Children(i).Code
   Case "SESITE":z3491.seSite = Children(i).Code
   Case "CDSITE":z3491.cdSite = Children(i).Code
   Case "AUTOKEY_P":z3491.Autokey_P = Children(i).Code
   Case "REMARK":z3491.Remark = Children(i).Code
   Case "TIMEINSERT":z3491.TimeInsert = Children(i).Code
   Case "TIMEUPDATE":z3491.TimeUpdate = Children(i).Code
   Case "DATEUPDATE":z3491.DateUpdate = Children(i).Code
   Case "DATEINSERT":z3491.DateInsert = Children(i).Code
   Case "INCHARGEINSERT":z3491.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z3491.InchargeUpdate = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "WIPNO":z3491.WIPNo = Children(i).Data
   Case "WIPSEQ":z3491.WIPSeq = Children(i).Data
   Case "INVOICENO":z3491.InvoiceNo = Children(i).Data
   Case "INVOICESEQ":z3491.InvoiceSeq = Children(i).Data
   Case "SONO":z3491.SONo = Children(i).Data
   Case "BOOKINGNO":z3491.BookingNo = Children(i).Data
   Case "LOADINGNO":z3491.LoadingNo = Children(i).Data
   Case "VESSELNAME":z3491.VesselName = Children(i).Data
   Case "TRADINGNAME":z3491.TradingName = Children(i).Data
   Case "TRADINGCODE":z3491.TradingCode = Children(i).Data
   Case "SHIPMENTTYPE":z3491.ShipmentType = Children(i).Data
   Case "DATEBL":z3491.DateBL = Children(i).Data
   Case "BLNO":z3491.BLNo = Children(i).Data
   Case "CONTAINERNO":z3491.ContainerNo = Children(i).Data
   Case "SESHIPTYPE":z3491.seShipType = Children(i).Data
   Case "CDSHIPTYPE":z3491.cdShipType = Children(i).Data
   Case "DATEEXFAC":z3491.DateEXFac = Children(i).Data
   Case "DATEETD":z3491.DateETD = Children(i).Data
   Case "DATEETA":z3491.DateETA = Children(i).Data
   Case "ORDERNO":z3491.OrderNo = Children(i).Data
   Case "ORDERNOSEQ":z3491.OrderNoSeq = Children(i).Data
   Case "LOADINGCODE":z3491.LoadingCode = Children(i).Data
   Case "TRANSFERTYPE":z3491.TransferType = Children(i).Data
   Case "CHKDECLARE":z3491.ChkDeclare = Children(i).Data
   Case "DATEDECLARE":z3491.DateDeclare = Children(i).Data
   Case "CHKSMDOCS":z3491.ChkSMDocs = Children(i).Data
   Case "DATESMDOCS":z3491.DateSMDocs = Children(i).Data
   Case "CHKLOCALCHARGE":z3491.ChkLocalCharge = Children(i).Data
   Case "DATELOCALCHARGE":z3491.DateLocalCharge = Children(i).Data
   Case "CHKUPLOADDOCS":z3491.ChkUploadDocs = Children(i).Data
   Case "DATEUPLOADDOCS":z3491.DateUploadDocs = Children(i).Data
   Case "CHKDOCSHK":z3491.ChkDocsHK = Children(i).Data
   Case "DATEDOCSHK":z3491.DateDocsHK = Children(i).Data
   Case "CHKDOCSBUYER":z3491.ChkDocsBuyer = Children(i).Data
   Case "CHKRECEIVEHK":z3491.ChkReceiveHK = Children(i).Data
   Case "CHKPENDING":z3491.ChkPending = Children(i).Data
   Case "DATEDOCSBUYER":z3491.DateDocsBuyer = Children(i).Data
   Case "CHECKSTATUS":z3491.CheckStatus = Cdecp(Children(i).Data)
   Case "QTYORDER":z3491.QtyOrder = Cdecp(Children(i).Data)
   Case "QTYORDERSAMPLE":z3491.QtyOrderSample = Cdecp(Children(i).Data)
   Case "PRICEORDERFOB":z3491.PriceOrderFOB = Cdecp(Children(i).Data)
   Case "TOTALAMTFOB":z3491.TotalAMTFOB = Cdecp(Children(i).Data)
   Case "PRICEORDER":z3491.PriceOrder = Cdecp(Children(i).Data)
   Case "TOTALAMT":z3491.TotalAMT = Cdecp(Children(i).Data)
   Case "TOTALGW":z3491.TotalGW = Cdecp(Children(i).Data)
   Case "TOTALNW":z3491.TotalNW = Cdecp(Children(i).Data)
   Case "TOTALCBM":z3491.TotalCBM = Cdecp(Children(i).Data)
   Case "TOTALQTY":z3491.TotalQty = Cdecp(Children(i).Data)
   Case "TOTALCNT":z3491.TotalCnt = Cdecp(Children(i).Data)
   Case "CONTNAME1":z3491.ContName1 = Children(i).Data
   Case "CONTNAME2":z3491.ContName2 = Children(i).Data
   Case "CONTNAME3":z3491.ContName3 = Children(i).Data
   Case "CONTNAME4":z3491.ContName4 = Children(i).Data
   Case "CONTNAME5":z3491.ContName5 = Children(i).Data
   Case "CONTNAME6":z3491.ContName6 = Children(i).Data
   Case "CONTNAME7":z3491.ContName7 = Children(i).Data
   Case "CONTNAME8":z3491.ContName8 = Children(i).Data
   Case "CONTNAME9":z3491.ContName9 = Children(i).Data
   Case "CONTNAME10":z3491.ContName10 = Children(i).Data
   Case "QTYPL1":z3491.QtyPL1 = Cdecp(Children(i).Data)
   Case "QTYPL2":z3491.QtyPL2 = Cdecp(Children(i).Data)
   Case "QTYPL3":z3491.QtyPL3 = Cdecp(Children(i).Data)
   Case "QTYPL4":z3491.QtyPL4 = Cdecp(Children(i).Data)
   Case "QTYPL5":z3491.QtyPL5 = Cdecp(Children(i).Data)
   Case "QTYPL6":z3491.QtyPL6 = Cdecp(Children(i).Data)
   Case "QTYPL7":z3491.QtyPL7 = Cdecp(Children(i).Data)
   Case "QTYPL8":z3491.QtyPL8 = Cdecp(Children(i).Data)
   Case "QTYPL9":z3491.QtyPL9 = Cdecp(Children(i).Data)
   Case "QTYPL10":z3491.QtyPL10 = Cdecp(Children(i).Data)
   Case "SESITE":z3491.seSite = Children(i).Data
   Case "CDSITE":z3491.cdSite = Children(i).Data
   Case "AUTOKEY_P":z3491.Autokey_P = Cdecp(Children(i).Data)
   Case "REMARK":z3491.Remark = Children(i).Data
   Case "TIMEINSERT":z3491.TimeInsert = Children(i).Data
   Case "TIMEUPDATE":z3491.TimeUpdate = Children(i).Data
   Case "DATEUPDATE":z3491.DateUpdate = Children(i).Data
   Case "DATEINSERT":z3491.DateInsert = Children(i).Data
   Case "INCHARGEINSERT":z3491.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z3491.InchargeUpdate = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K3491_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K3491_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z3491 As T3491_AREA, Job as String, CheckClear as Boolean, WIPNO AS String, WIPSEQ AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K3491_MOVE = False

Try
    If READ_PFK3491(WIPNO, WIPSEQ) = True Then
                z3491 = D3491
		K3491_MOVE = True
		else
	If CheckClear  = True then z3491 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3491")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "WIPNO":z3491.WIPNo = Children(i).Code
   Case "WIPSEQ":z3491.WIPSeq = Children(i).Code
   Case "INVOICENO":z3491.InvoiceNo = Children(i).Code
   Case "INVOICESEQ":z3491.InvoiceSeq = Children(i).Code
   Case "SONO":z3491.SONo = Children(i).Code
   Case "BOOKINGNO":z3491.BookingNo = Children(i).Code
   Case "LOADINGNO":z3491.LoadingNo = Children(i).Code
   Case "VESSELNAME":z3491.VesselName = Children(i).Code
   Case "TRADINGNAME":z3491.TradingName = Children(i).Code
   Case "TRADINGCODE":z3491.TradingCode = Children(i).Code
   Case "SHIPMENTTYPE":z3491.ShipmentType = Children(i).Code
   Case "DATEBL":z3491.DateBL = Children(i).Code
   Case "BLNO":z3491.BLNo = Children(i).Code
   Case "CONTAINERNO":z3491.ContainerNo = Children(i).Code
   Case "SESHIPTYPE":z3491.seShipType = Children(i).Code
   Case "CDSHIPTYPE":z3491.cdShipType = Children(i).Code
   Case "DATEEXFAC":z3491.DateEXFac = Children(i).Code
   Case "DATEETD":z3491.DateETD = Children(i).Code
   Case "DATEETA":z3491.DateETA = Children(i).Code
   Case "ORDERNO":z3491.OrderNo = Children(i).Code
   Case "ORDERNOSEQ":z3491.OrderNoSeq = Children(i).Code
   Case "LOADINGCODE":z3491.LoadingCode = Children(i).Code
   Case "TRANSFERTYPE":z3491.TransferType = Children(i).Code
   Case "CHKDECLARE":z3491.ChkDeclare = Children(i).Code
   Case "DATEDECLARE":z3491.DateDeclare = Children(i).Code
   Case "CHKSMDOCS":z3491.ChkSMDocs = Children(i).Code
   Case "DATESMDOCS":z3491.DateSMDocs = Children(i).Code
   Case "CHKLOCALCHARGE":z3491.ChkLocalCharge = Children(i).Code
   Case "DATELOCALCHARGE":z3491.DateLocalCharge = Children(i).Code
   Case "CHKUPLOADDOCS":z3491.ChkUploadDocs = Children(i).Code
   Case "DATEUPLOADDOCS":z3491.DateUploadDocs = Children(i).Code
   Case "CHKDOCSHK":z3491.ChkDocsHK = Children(i).Code
   Case "DATEDOCSHK":z3491.DateDocsHK = Children(i).Code
   Case "CHKDOCSBUYER":z3491.ChkDocsBuyer = Children(i).Code
   Case "CHKRECEIVEHK":z3491.ChkReceiveHK = Children(i).Code
   Case "CHKPENDING":z3491.ChkPending = Children(i).Code
   Case "DATEDOCSBUYER":z3491.DateDocsBuyer = Children(i).Code
   Case "CHECKSTATUS":z3491.CheckStatus = Children(i).Code
   Case "QTYORDER":z3491.QtyOrder = Children(i).Code
   Case "QTYORDERSAMPLE":z3491.QtyOrderSample = Children(i).Code
   Case "PRICEORDERFOB":z3491.PriceOrderFOB = Children(i).Code
   Case "TOTALAMTFOB":z3491.TotalAMTFOB = Children(i).Code
   Case "PRICEORDER":z3491.PriceOrder = Children(i).Code
   Case "TOTALAMT":z3491.TotalAMT = Children(i).Code
   Case "TOTALGW":z3491.TotalGW = Children(i).Code
   Case "TOTALNW":z3491.TotalNW = Children(i).Code
   Case "TOTALCBM":z3491.TotalCBM = Children(i).Code
   Case "TOTALQTY":z3491.TotalQty = Children(i).Code
   Case "TOTALCNT":z3491.TotalCnt = Children(i).Code
   Case "CONTNAME1":z3491.ContName1 = Children(i).Code
   Case "CONTNAME2":z3491.ContName2 = Children(i).Code
   Case "CONTNAME3":z3491.ContName3 = Children(i).Code
   Case "CONTNAME4":z3491.ContName4 = Children(i).Code
   Case "CONTNAME5":z3491.ContName5 = Children(i).Code
   Case "CONTNAME6":z3491.ContName6 = Children(i).Code
   Case "CONTNAME7":z3491.ContName7 = Children(i).Code
   Case "CONTNAME8":z3491.ContName8 = Children(i).Code
   Case "CONTNAME9":z3491.ContName9 = Children(i).Code
   Case "CONTNAME10":z3491.ContName10 = Children(i).Code
   Case "QTYPL1":z3491.QtyPL1 = Children(i).Code
   Case "QTYPL2":z3491.QtyPL2 = Children(i).Code
   Case "QTYPL3":z3491.QtyPL3 = Children(i).Code
   Case "QTYPL4":z3491.QtyPL4 = Children(i).Code
   Case "QTYPL5":z3491.QtyPL5 = Children(i).Code
   Case "QTYPL6":z3491.QtyPL6 = Children(i).Code
   Case "QTYPL7":z3491.QtyPL7 = Children(i).Code
   Case "QTYPL8":z3491.QtyPL8 = Children(i).Code
   Case "QTYPL9":z3491.QtyPL9 = Children(i).Code
   Case "QTYPL10":z3491.QtyPL10 = Children(i).Code
   Case "SESITE":z3491.seSite = Children(i).Code
   Case "CDSITE":z3491.cdSite = Children(i).Code
   Case "AUTOKEY_P":z3491.Autokey_P = Children(i).Code
   Case "REMARK":z3491.Remark = Children(i).Code
   Case "TIMEINSERT":z3491.TimeInsert = Children(i).Code
   Case "TIMEUPDATE":z3491.TimeUpdate = Children(i).Code
   Case "DATEUPDATE":z3491.DateUpdate = Children(i).Code
   Case "DATEINSERT":z3491.DateInsert = Children(i).Code
   Case "INCHARGEINSERT":z3491.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z3491.InchargeUpdate = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "WIPNO":z3491.WIPNo = Children(i).Data
   Case "WIPSEQ":z3491.WIPSeq = Children(i).Data
   Case "INVOICENO":z3491.InvoiceNo = Children(i).Data
   Case "INVOICESEQ":z3491.InvoiceSeq = Children(i).Data
   Case "SONO":z3491.SONo = Children(i).Data
   Case "BOOKINGNO":z3491.BookingNo = Children(i).Data
   Case "LOADINGNO":z3491.LoadingNo = Children(i).Data
   Case "VESSELNAME":z3491.VesselName = Children(i).Data
   Case "TRADINGNAME":z3491.TradingName = Children(i).Data
   Case "TRADINGCODE":z3491.TradingCode = Children(i).Data
   Case "SHIPMENTTYPE":z3491.ShipmentType = Children(i).Data
   Case "DATEBL":z3491.DateBL = Children(i).Data
   Case "BLNO":z3491.BLNo = Children(i).Data
   Case "CONTAINERNO":z3491.ContainerNo = Children(i).Data
   Case "SESHIPTYPE":z3491.seShipType = Children(i).Data
   Case "CDSHIPTYPE":z3491.cdShipType = Children(i).Data
   Case "DATEEXFAC":z3491.DateEXFac = Children(i).Data
   Case "DATEETD":z3491.DateETD = Children(i).Data
   Case "DATEETA":z3491.DateETA = Children(i).Data
   Case "ORDERNO":z3491.OrderNo = Children(i).Data
   Case "ORDERNOSEQ":z3491.OrderNoSeq = Children(i).Data
   Case "LOADINGCODE":z3491.LoadingCode = Children(i).Data
   Case "TRANSFERTYPE":z3491.TransferType = Children(i).Data
   Case "CHKDECLARE":z3491.ChkDeclare = Children(i).Data
   Case "DATEDECLARE":z3491.DateDeclare = Children(i).Data
   Case "CHKSMDOCS":z3491.ChkSMDocs = Children(i).Data
   Case "DATESMDOCS":z3491.DateSMDocs = Children(i).Data
   Case "CHKLOCALCHARGE":z3491.ChkLocalCharge = Children(i).Data
   Case "DATELOCALCHARGE":z3491.DateLocalCharge = Children(i).Data
   Case "CHKUPLOADDOCS":z3491.ChkUploadDocs = Children(i).Data
   Case "DATEUPLOADDOCS":z3491.DateUploadDocs = Children(i).Data
   Case "CHKDOCSHK":z3491.ChkDocsHK = Children(i).Data
   Case "DATEDOCSHK":z3491.DateDocsHK = Children(i).Data
   Case "CHKDOCSBUYER":z3491.ChkDocsBuyer = Children(i).Data
   Case "CHKRECEIVEHK":z3491.ChkReceiveHK = Children(i).Data
   Case "CHKPENDING":z3491.ChkPending = Children(i).Data
   Case "DATEDOCSBUYER":z3491.DateDocsBuyer = Children(i).Data
   Case "CHECKSTATUS":z3491.CheckStatus = Cdecp(Children(i).Data)
   Case "QTYORDER":z3491.QtyOrder = Cdecp(Children(i).Data)
   Case "QTYORDERSAMPLE":z3491.QtyOrderSample = Cdecp(Children(i).Data)
   Case "PRICEORDERFOB":z3491.PriceOrderFOB = Cdecp(Children(i).Data)
   Case "TOTALAMTFOB":z3491.TotalAMTFOB = Cdecp(Children(i).Data)
   Case "PRICEORDER":z3491.PriceOrder = Cdecp(Children(i).Data)
   Case "TOTALAMT":z3491.TotalAMT = Cdecp(Children(i).Data)
   Case "TOTALGW":z3491.TotalGW = Cdecp(Children(i).Data)
   Case "TOTALNW":z3491.TotalNW = Cdecp(Children(i).Data)
   Case "TOTALCBM":z3491.TotalCBM = Cdecp(Children(i).Data)
   Case "TOTALQTY":z3491.TotalQty = Cdecp(Children(i).Data)
   Case "TOTALCNT":z3491.TotalCnt = Cdecp(Children(i).Data)
   Case "CONTNAME1":z3491.ContName1 = Children(i).Data
   Case "CONTNAME2":z3491.ContName2 = Children(i).Data
   Case "CONTNAME3":z3491.ContName3 = Children(i).Data
   Case "CONTNAME4":z3491.ContName4 = Children(i).Data
   Case "CONTNAME5":z3491.ContName5 = Children(i).Data
   Case "CONTNAME6":z3491.ContName6 = Children(i).Data
   Case "CONTNAME7":z3491.ContName7 = Children(i).Data
   Case "CONTNAME8":z3491.ContName8 = Children(i).Data
   Case "CONTNAME9":z3491.ContName9 = Children(i).Data
   Case "CONTNAME10":z3491.ContName10 = Children(i).Data
   Case "QTYPL1":z3491.QtyPL1 = Cdecp(Children(i).Data)
   Case "QTYPL2":z3491.QtyPL2 = Cdecp(Children(i).Data)
   Case "QTYPL3":z3491.QtyPL3 = Cdecp(Children(i).Data)
   Case "QTYPL4":z3491.QtyPL4 = Cdecp(Children(i).Data)
   Case "QTYPL5":z3491.QtyPL5 = Cdecp(Children(i).Data)
   Case "QTYPL6":z3491.QtyPL6 = Cdecp(Children(i).Data)
   Case "QTYPL7":z3491.QtyPL7 = Cdecp(Children(i).Data)
   Case "QTYPL8":z3491.QtyPL8 = Cdecp(Children(i).Data)
   Case "QTYPL9":z3491.QtyPL9 = Cdecp(Children(i).Data)
   Case "QTYPL10":z3491.QtyPL10 = Cdecp(Children(i).Data)
   Case "SESITE":z3491.seSite = Children(i).Data
   Case "CDSITE":z3491.cdSite = Children(i).Data
   Case "AUTOKEY_P":z3491.Autokey_P = Cdecp(Children(i).Data)
   Case "REMARK":z3491.Remark = Children(i).Data
   Case "TIMEINSERT":z3491.TimeInsert = Children(i).Data
   Case "TIMEUPDATE":z3491.TimeUpdate = Children(i).Data
   Case "DATEUPDATE":z3491.DateUpdate = Children(i).Data
   Case "DATEINSERT":z3491.DateInsert = Children(i).Data
   Case "INCHARGEINSERT":z3491.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z3491.InchargeUpdate = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K3491_MOVE",vbCritical)
End Try
End Function 
    

'=========================================================================================================================================================
' DATA MOVE FORM NEW AREA
'=========================================================================================================================================================
Public Sub K3491_MOVE(ByRef a3491 As T3491_AREA, ByRef b3491 As T3491_AREA) 
Try
If trim$( a3491.WIPNo ) = "" Then b3491.WIPNo = ""  Else b3491.WIPNo=a3491.WIPNo
If trim$( a3491.WIPSeq ) = "" Then b3491.WIPSeq = ""  Else b3491.WIPSeq=a3491.WIPSeq
If trim$( a3491.InvoiceNo ) = "" Then b3491.InvoiceNo = ""  Else b3491.InvoiceNo=a3491.InvoiceNo
If trim$( a3491.InvoiceSeq ) = "" Then b3491.InvoiceSeq = ""  Else b3491.InvoiceSeq=a3491.InvoiceSeq
If trim$( a3491.SONo ) = "" Then b3491.SONo = ""  Else b3491.SONo=a3491.SONo
If trim$( a3491.BookingNo ) = "" Then b3491.BookingNo = ""  Else b3491.BookingNo=a3491.BookingNo
If trim$( a3491.LoadingNo ) = "" Then b3491.LoadingNo = ""  Else b3491.LoadingNo=a3491.LoadingNo
If trim$( a3491.VesselName ) = "" Then b3491.VesselName = ""  Else b3491.VesselName=a3491.VesselName
If trim$( a3491.TradingName ) = "" Then b3491.TradingName = ""  Else b3491.TradingName=a3491.TradingName
If trim$( a3491.TradingCode ) = "" Then b3491.TradingCode = ""  Else b3491.TradingCode=a3491.TradingCode
If trim$( a3491.ShipmentType ) = "" Then b3491.ShipmentType = ""  Else b3491.ShipmentType=a3491.ShipmentType
If trim$( a3491.DateBL ) = "" Then b3491.DateBL = ""  Else b3491.DateBL=a3491.DateBL
If trim$( a3491.BLNo ) = "" Then b3491.BLNo = ""  Else b3491.BLNo=a3491.BLNo
If trim$( a3491.ContainerNo ) = "" Then b3491.ContainerNo = ""  Else b3491.ContainerNo=a3491.ContainerNo
If trim$( a3491.seShipType ) = "" Then b3491.seShipType = ""  Else b3491.seShipType=a3491.seShipType
If trim$( a3491.cdShipType ) = "" Then b3491.cdShipType = ""  Else b3491.cdShipType=a3491.cdShipType
If trim$( a3491.DateEXFac ) = "" Then b3491.DateEXFac = ""  Else b3491.DateEXFac=a3491.DateEXFac
If trim$( a3491.DateETD ) = "" Then b3491.DateETD = ""  Else b3491.DateETD=a3491.DateETD
If trim$( a3491.DateETA ) = "" Then b3491.DateETA = ""  Else b3491.DateETA=a3491.DateETA
If trim$( a3491.OrderNo ) = "" Then b3491.OrderNo = ""  Else b3491.OrderNo=a3491.OrderNo
If trim$( a3491.OrderNoSeq ) = "" Then b3491.OrderNoSeq = ""  Else b3491.OrderNoSeq=a3491.OrderNoSeq
If trim$( a3491.LoadingCode ) = "" Then b3491.LoadingCode = ""  Else b3491.LoadingCode=a3491.LoadingCode
If trim$( a3491.TransferType ) = "" Then b3491.TransferType = ""  Else b3491.TransferType=a3491.TransferType
If trim$( a3491.ChkDeclare ) = "" Then b3491.ChkDeclare = ""  Else b3491.ChkDeclare=a3491.ChkDeclare
If trim$( a3491.DateDeclare ) = "" Then b3491.DateDeclare = ""  Else b3491.DateDeclare=a3491.DateDeclare
If trim$( a3491.ChkSMDocs ) = "" Then b3491.ChkSMDocs = ""  Else b3491.ChkSMDocs=a3491.ChkSMDocs
If trim$( a3491.DateSMDocs ) = "" Then b3491.DateSMDocs = ""  Else b3491.DateSMDocs=a3491.DateSMDocs
If trim$( a3491.ChkLocalCharge ) = "" Then b3491.ChkLocalCharge = ""  Else b3491.ChkLocalCharge=a3491.ChkLocalCharge
If trim$( a3491.DateLocalCharge ) = "" Then b3491.DateLocalCharge = ""  Else b3491.DateLocalCharge=a3491.DateLocalCharge
If trim$( a3491.ChkUploadDocs ) = "" Then b3491.ChkUploadDocs = ""  Else b3491.ChkUploadDocs=a3491.ChkUploadDocs
If trim$( a3491.DateUploadDocs ) = "" Then b3491.DateUploadDocs = ""  Else b3491.DateUploadDocs=a3491.DateUploadDocs
If trim$( a3491.ChkDocsHK ) = "" Then b3491.ChkDocsHK = ""  Else b3491.ChkDocsHK=a3491.ChkDocsHK
If trim$( a3491.DateDocsHK ) = "" Then b3491.DateDocsHK = ""  Else b3491.DateDocsHK=a3491.DateDocsHK
If trim$( a3491.ChkDocsBuyer ) = "" Then b3491.ChkDocsBuyer = ""  Else b3491.ChkDocsBuyer=a3491.ChkDocsBuyer
If trim$( a3491.ChkReceiveHK ) = "" Then b3491.ChkReceiveHK = ""  Else b3491.ChkReceiveHK=a3491.ChkReceiveHK
If trim$( a3491.ChkPending ) = "" Then b3491.ChkPending = ""  Else b3491.ChkPending=a3491.ChkPending
If trim$( a3491.DateDocsBuyer ) = "" Then b3491.DateDocsBuyer = ""  Else b3491.DateDocsBuyer=a3491.DateDocsBuyer
If trim$( a3491.CheckStatus ) = "" Then b3491.CheckStatus = ""  Else b3491.CheckStatus=a3491.CheckStatus
If trim$( a3491.QtyOrder ) = "" Then b3491.QtyOrder = ""  Else b3491.QtyOrder=a3491.QtyOrder
If trim$( a3491.QtyOrderSample ) = "" Then b3491.QtyOrderSample = ""  Else b3491.QtyOrderSample=a3491.QtyOrderSample
If trim$( a3491.PriceOrderFOB ) = "" Then b3491.PriceOrderFOB = ""  Else b3491.PriceOrderFOB=a3491.PriceOrderFOB
If trim$( a3491.TotalAMTFOB ) = "" Then b3491.TotalAMTFOB = ""  Else b3491.TotalAMTFOB=a3491.TotalAMTFOB
If trim$( a3491.PriceOrder ) = "" Then b3491.PriceOrder = ""  Else b3491.PriceOrder=a3491.PriceOrder
If trim$( a3491.TotalAMT ) = "" Then b3491.TotalAMT = ""  Else b3491.TotalAMT=a3491.TotalAMT
If trim$( a3491.TotalGW ) = "" Then b3491.TotalGW = ""  Else b3491.TotalGW=a3491.TotalGW
If trim$( a3491.TotalNW ) = "" Then b3491.TotalNW = ""  Else b3491.TotalNW=a3491.TotalNW
If trim$( a3491.TotalCBM ) = "" Then b3491.TotalCBM = ""  Else b3491.TotalCBM=a3491.TotalCBM
If trim$( a3491.TotalQty ) = "" Then b3491.TotalQty = ""  Else b3491.TotalQty=a3491.TotalQty
If trim$( a3491.TotalCnt ) = "" Then b3491.TotalCnt = ""  Else b3491.TotalCnt=a3491.TotalCnt
If trim$( a3491.ContName1 ) = "" Then b3491.ContName1 = ""  Else b3491.ContName1=a3491.ContName1
If trim$( a3491.ContName2 ) = "" Then b3491.ContName2 = ""  Else b3491.ContName2=a3491.ContName2
If trim$( a3491.ContName3 ) = "" Then b3491.ContName3 = ""  Else b3491.ContName3=a3491.ContName3
If trim$( a3491.ContName4 ) = "" Then b3491.ContName4 = ""  Else b3491.ContName4=a3491.ContName4
If trim$( a3491.ContName5 ) = "" Then b3491.ContName5 = ""  Else b3491.ContName5=a3491.ContName5
If trim$( a3491.ContName6 ) = "" Then b3491.ContName6 = ""  Else b3491.ContName6=a3491.ContName6
If trim$( a3491.ContName7 ) = "" Then b3491.ContName7 = ""  Else b3491.ContName7=a3491.ContName7
If trim$( a3491.ContName8 ) = "" Then b3491.ContName8 = ""  Else b3491.ContName8=a3491.ContName8
If trim$( a3491.ContName9 ) = "" Then b3491.ContName9 = ""  Else b3491.ContName9=a3491.ContName9
If trim$( a3491.ContName10 ) = "" Then b3491.ContName10 = ""  Else b3491.ContName10=a3491.ContName10
If trim$( a3491.QtyPL1 ) = "" Then b3491.QtyPL1 = ""  Else b3491.QtyPL1=a3491.QtyPL1
If trim$( a3491.QtyPL2 ) = "" Then b3491.QtyPL2 = ""  Else b3491.QtyPL2=a3491.QtyPL2
If trim$( a3491.QtyPL3 ) = "" Then b3491.QtyPL3 = ""  Else b3491.QtyPL3=a3491.QtyPL3
If trim$( a3491.QtyPL4 ) = "" Then b3491.QtyPL4 = ""  Else b3491.QtyPL4=a3491.QtyPL4
If trim$( a3491.QtyPL5 ) = "" Then b3491.QtyPL5 = ""  Else b3491.QtyPL5=a3491.QtyPL5
If trim$( a3491.QtyPL6 ) = "" Then b3491.QtyPL6 = ""  Else b3491.QtyPL6=a3491.QtyPL6
If trim$( a3491.QtyPL7 ) = "" Then b3491.QtyPL7 = ""  Else b3491.QtyPL7=a3491.QtyPL7
If trim$( a3491.QtyPL8 ) = "" Then b3491.QtyPL8 = ""  Else b3491.QtyPL8=a3491.QtyPL8
If trim$( a3491.QtyPL9 ) = "" Then b3491.QtyPL9 = ""  Else b3491.QtyPL9=a3491.QtyPL9
If trim$( a3491.QtyPL10 ) = "" Then b3491.QtyPL10 = ""  Else b3491.QtyPL10=a3491.QtyPL10
If trim$( a3491.seSite ) = "" Then b3491.seSite = ""  Else b3491.seSite=a3491.seSite
If trim$( a3491.cdSite ) = "" Then b3491.cdSite = ""  Else b3491.cdSite=a3491.cdSite
If trim$( a3491.Autokey_P ) = "" Then b3491.Autokey_P = ""  Else b3491.Autokey_P=a3491.Autokey_P
If trim$( a3491.Remark ) = "" Then b3491.Remark = ""  Else b3491.Remark=a3491.Remark
If trim$( a3491.TimeInsert ) = "" Then b3491.TimeInsert = ""  Else b3491.TimeInsert=a3491.TimeInsert
If trim$( a3491.TimeUpdate ) = "" Then b3491.TimeUpdate = ""  Else b3491.TimeUpdate=a3491.TimeUpdate
If trim$( a3491.DateUpdate ) = "" Then b3491.DateUpdate = ""  Else b3491.DateUpdate=a3491.DateUpdate
If trim$( a3491.DateInsert ) = "" Then b3491.DateInsert = ""  Else b3491.DateInsert=a3491.DateInsert
If trim$( a3491.InchargeInsert ) = "" Then b3491.InchargeInsert = ""  Else b3491.InchargeInsert=a3491.InchargeInsert
If trim$( a3491.InchargeUpdate ) = "" Then b3491.InchargeUpdate = ""  Else b3491.InchargeUpdate=a3491.InchargeUpdate
Catch ex As Exception
      Call MsgBoxP("K3491_MOVE",vbCritical)
End Try
End Sub 


End Module 
