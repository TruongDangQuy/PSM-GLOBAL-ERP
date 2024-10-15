'=========================================================================================================================================================
'   TABLE : (PFK3471)
'
'      WORKER : PSM GLOBAL ., LTD
'       WORK DATE : 2019 NEW
'       DEVELOPER    : MRNLV
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K3471

Structure T3471_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	LiquidNo	 AS String	'			char(9)		*
Public 	LiquidSeq	 AS String	'			char(4)		*
Public 	ShoesCode	 AS String	'			char(6)
Public 	YearLiquidation	 AS String	'			char(4)
Public 	DateDlr	 AS String	'			char(8)
Public 	SOTK	 AS Double	'			decimal
Public 	TONGTGKB	 AS Double	'			decimal
Public 	InvoiceNoMaster	 AS String	'			nvarchar(50)
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
Public 	CheckLiquidation	 AS String	'			char(1)
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

Public D3471 As T3471_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK3471(LIQUIDNO AS String, LIQUIDSEQ AS String) As Boolean
    READ_PFK3471 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK3471 "
    SQL = SQL & " WHERE K3471_LiquidNo		 = '" & LiquidNo & "' " 
    SQL = SQL & "   AND K3471_LiquidSeq		 = '" & LiquidSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D3471_CLEAR: GoTo SKIP_READ_PFK3471
                
    Call K3471_MOVE(rd)
    READ_PFK3471 = True

SKIP_READ_PFK3471:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK3471",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK3471(LIQUIDNO AS String, LIQUIDSEQ AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK3471 "
    SQL = SQL & " WHERE K3471_LiquidNo		 = '" & LiquidNo & "' " 
    SQL = SQL & "   AND K3471_LiquidSeq		 = '" & LiquidSeq & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK3471",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK3471(z3471 As T3471_AREA) As Boolean
    WRITE_PFK3471 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z3471)
 
    SQL = " INSERT INTO PFK3471 "
    SQL = SQL & " ( "
    SQL = SQL & " K3471_LiquidNo," 
    SQL = SQL & " K3471_LiquidSeq," 
    SQL = SQL & " K3471_ShoesCode," 
    SQL = SQL & " K3471_YearLiquidation," 
    SQL = SQL & " K3471_DateDlr," 
    SQL = SQL & " K3471_SOTK," 
    SQL = SQL & " K3471_TONGTGKB," 
    SQL = SQL & " K3471_InvoiceNoMaster," 
    SQL = SQL & " K3471_InvoiceNo," 
    SQL = SQL & " K3471_InvoiceSeq," 
    SQL = SQL & " K3471_SONo," 
    SQL = SQL & " K3471_BookingNo," 
    SQL = SQL & " K3471_LoadingNo," 
    SQL = SQL & " K3471_VesselName," 
    SQL = SQL & " K3471_TradingName," 
    SQL = SQL & " K3471_TradingCode," 
    SQL = SQL & " K3471_ShipmentType," 
    SQL = SQL & " K3471_DateBL," 
    SQL = SQL & " K3471_BLNo," 
    SQL = SQL & " K3471_ContainerNo," 
    SQL = SQL & " K3471_seShipType," 
    SQL = SQL & " K3471_cdShipType," 
    SQL = SQL & " K3471_DateEXFac," 
    SQL = SQL & " K3471_DateETD," 
    SQL = SQL & " K3471_DateETA," 
    SQL = SQL & " K3471_OrderNo," 
    SQL = SQL & " K3471_OrderNoSeq," 
    SQL = SQL & " K3471_LoadingCode," 
    SQL = SQL & " K3471_TransferType," 
    SQL = SQL & " K3471_ChkDeclare," 
    SQL = SQL & " K3471_DateDeclare," 
    SQL = SQL & " K3471_ChkSMDocs," 
    SQL = SQL & " K3471_DateSMDocs," 
    SQL = SQL & " K3471_ChkLocalCharge," 
    SQL = SQL & " K3471_DateLocalCharge," 
    SQL = SQL & " K3471_ChkUploadDocs," 
    SQL = SQL & " K3471_DateUploadDocs," 
    SQL = SQL & " K3471_ChkDocsHK," 
    SQL = SQL & " K3471_DateDocsHK," 
    SQL = SQL & " K3471_ChkDocsBuyer," 
    SQL = SQL & " K3471_ChkReceiveHK," 
    SQL = SQL & " K3471_ChkPending," 
    SQL = SQL & " K3471_DateDocsBuyer," 
    SQL = SQL & " K3471_CheckLiquidation," 
    SQL = SQL & " K3471_CheckStatus," 
    SQL = SQL & " K3471_QtyOrder," 
    SQL = SQL & " K3471_QtyOrderSample," 
    SQL = SQL & " K3471_PriceOrderFOB," 
    SQL = SQL & " K3471_TotalAMTFOB," 
    SQL = SQL & " K3471_PriceOrder," 
    SQL = SQL & " K3471_TotalAMT," 
    SQL = SQL & " K3471_TotalGW," 
    SQL = SQL & " K3471_TotalNW," 
    SQL = SQL & " K3471_TotalCBM," 
    SQL = SQL & " K3471_TotalQty," 
    SQL = SQL & " K3471_TotalCnt," 
    SQL = SQL & " K3471_ContName1," 
    SQL = SQL & " K3471_ContName2," 
    SQL = SQL & " K3471_ContName3," 
    SQL = SQL & " K3471_ContName4," 
    SQL = SQL & " K3471_ContName5," 
    SQL = SQL & " K3471_ContName6," 
    SQL = SQL & " K3471_ContName7," 
    SQL = SQL & " K3471_ContName8," 
    SQL = SQL & " K3471_ContName9," 
    SQL = SQL & " K3471_ContName10," 
    SQL = SQL & " K3471_QtyPL1," 
    SQL = SQL & " K3471_QtyPL2," 
    SQL = SQL & " K3471_QtyPL3," 
    SQL = SQL & " K3471_QtyPL4," 
    SQL = SQL & " K3471_QtyPL5," 
    SQL = SQL & " K3471_QtyPL6," 
    SQL = SQL & " K3471_QtyPL7," 
    SQL = SQL & " K3471_QtyPL8," 
    SQL = SQL & " K3471_QtyPL9," 
    SQL = SQL & " K3471_QtyPL10," 
    SQL = SQL & " K3471_seSite," 
    SQL = SQL & " K3471_cdSite," 
    SQL = SQL & " K3471_Remark," 
    SQL = SQL & " K3471_TimeInsert," 
    SQL = SQL & " K3471_TimeUpdate," 
    SQL = SQL & " K3471_DateUpdate," 
    SQL = SQL & " K3471_DateInsert," 
    SQL = SQL & " K3471_InchargeInsert," 
    SQL = SQL & " K3471_InchargeUpdate " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z3471.LiquidNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3471.LiquidSeq) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3471.ShoesCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3471.YearLiquidation) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3471.DateDlr) & "', "  
    SQL = SQL & "   " & FormatSQL(z3471.SOTK) & ", "  
    SQL = SQL & "   " & FormatSQL(z3471.TONGTGKB) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z3471.InvoiceNoMaster) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3471.InvoiceNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3471.InvoiceSeq) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3471.SONo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3471.BookingNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3471.LoadingNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3471.VesselName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3471.TradingName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3471.TradingCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3471.ShipmentType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3471.DateBL) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3471.BLNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3471.ContainerNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3471.seShipType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3471.cdShipType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3471.DateEXFac) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3471.DateETD) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3471.DateETA) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3471.OrderNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3471.OrderNoSeq) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3471.LoadingCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3471.TransferType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3471.ChkDeclare) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3471.DateDeclare) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3471.ChkSMDocs) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3471.DateSMDocs) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3471.ChkLocalCharge) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3471.DateLocalCharge) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3471.ChkUploadDocs) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3471.DateUploadDocs) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3471.ChkDocsHK) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3471.DateDocsHK) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3471.ChkDocsBuyer) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3471.ChkReceiveHK) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3471.ChkPending) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3471.DateDocsBuyer) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3471.CheckLiquidation) & "', "  
    SQL = SQL & "   " & FormatSQL(z3471.CheckStatus) & ", "  
    SQL = SQL & "   " & FormatSQL(z3471.QtyOrder) & ", "  
    SQL = SQL & "   " & FormatSQL(z3471.QtyOrderSample) & ", "  
    SQL = SQL & "   " & FormatSQL(z3471.PriceOrderFOB) & ", "  
    SQL = SQL & "   " & FormatSQL(z3471.TotalAMTFOB) & ", "  
    SQL = SQL & "   " & FormatSQL(z3471.PriceOrder) & ", "  
    SQL = SQL & "   " & FormatSQL(z3471.TotalAMT) & ", "  
    SQL = SQL & "   " & FormatSQL(z3471.TotalGW) & ", "  
    SQL = SQL & "   " & FormatSQL(z3471.TotalNW) & ", "  
    SQL = SQL & "   " & FormatSQL(z3471.TotalCBM) & ", "  
    SQL = SQL & "   " & FormatSQL(z3471.TotalQty) & ", "  
    SQL = SQL & "   " & FormatSQL(z3471.TotalCnt) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z3471.ContName1) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3471.ContName2) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3471.ContName3) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3471.ContName4) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3471.ContName5) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3471.ContName6) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3471.ContName7) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3471.ContName8) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3471.ContName9) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3471.ContName10) & "', "  
    SQL = SQL & "   " & FormatSQL(z3471.QtyPL1) & ", "  
    SQL = SQL & "   " & FormatSQL(z3471.QtyPL2) & ", "  
    SQL = SQL & "   " & FormatSQL(z3471.QtyPL3) & ", "  
    SQL = SQL & "   " & FormatSQL(z3471.QtyPL4) & ", "  
    SQL = SQL & "   " & FormatSQL(z3471.QtyPL5) & ", "  
    SQL = SQL & "   " & FormatSQL(z3471.QtyPL6) & ", "  
    SQL = SQL & "   " & FormatSQL(z3471.QtyPL7) & ", "  
    SQL = SQL & "   " & FormatSQL(z3471.QtyPL8) & ", "  
    SQL = SQL & "   " & FormatSQL(z3471.QtyPL9) & ", "  
    SQL = SQL & "   " & FormatSQL(z3471.QtyPL10) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z3471.seSite) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3471.cdSite) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3471.Remark) & "', "  
    SQL = SQL & "  N'" & FormatSQL(PUB.TIME) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3471.TimeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3471.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(PUB.DAT) & "', "  
    SQL = SQL & "  N'" & FormatSQL(PUB.SAW) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3471.InchargeUpdate) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK3471 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK3471",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK3471(z3471 As T3471_AREA) As Boolean
    REWRITE_PFK3471 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z3471)
   
    SQL = " UPDATE PFK3471 SET "
    SQL = SQL & "    K3471_ShoesCode      = N'" & FormatSQL(z3471.ShoesCode) & "', " 
    SQL = SQL & "    K3471_YearLiquidation      = N'" & FormatSQL(z3471.YearLiquidation) & "', " 
    SQL = SQL & "    K3471_DateDlr      = N'" & FormatSQL(z3471.DateDlr) & "', " 
    SQL = SQL & "    K3471_SOTK      =  " & FormatSQL(z3471.SOTK) & ", " 
    SQL = SQL & "    K3471_TONGTGKB      =  " & FormatSQL(z3471.TONGTGKB) & ", " 
    SQL = SQL & "    K3471_InvoiceNoMaster      = N'" & FormatSQL(z3471.InvoiceNoMaster) & "', " 
    SQL = SQL & "    K3471_InvoiceNo      = N'" & FormatSQL(z3471.InvoiceNo) & "', " 
    SQL = SQL & "    K3471_InvoiceSeq      = N'" & FormatSQL(z3471.InvoiceSeq) & "', " 
    SQL = SQL & "    K3471_SONo      = N'" & FormatSQL(z3471.SONo) & "', " 
    SQL = SQL & "    K3471_BookingNo      = N'" & FormatSQL(z3471.BookingNo) & "', " 
    SQL = SQL & "    K3471_LoadingNo      = N'" & FormatSQL(z3471.LoadingNo) & "', " 
    SQL = SQL & "    K3471_VesselName      = N'" & FormatSQL(z3471.VesselName) & "', " 
    SQL = SQL & "    K3471_TradingName      = N'" & FormatSQL(z3471.TradingName) & "', " 
    SQL = SQL & "    K3471_TradingCode      = N'" & FormatSQL(z3471.TradingCode) & "', " 
    SQL = SQL & "    K3471_ShipmentType      = N'" & FormatSQL(z3471.ShipmentType) & "', " 
    SQL = SQL & "    K3471_DateBL      = N'" & FormatSQL(z3471.DateBL) & "', " 
    SQL = SQL & "    K3471_BLNo      = N'" & FormatSQL(z3471.BLNo) & "', " 
    SQL = SQL & "    K3471_ContainerNo      = N'" & FormatSQL(z3471.ContainerNo) & "', " 
    SQL = SQL & "    K3471_seShipType      = N'" & FormatSQL(z3471.seShipType) & "', " 
    SQL = SQL & "    K3471_cdShipType      = N'" & FormatSQL(z3471.cdShipType) & "', " 
    SQL = SQL & "    K3471_DateEXFac      = N'" & FormatSQL(z3471.DateEXFac) & "', " 
    SQL = SQL & "    K3471_DateETD      = N'" & FormatSQL(z3471.DateETD) & "', " 
    SQL = SQL & "    K3471_DateETA      = N'" & FormatSQL(z3471.DateETA) & "', " 
    SQL = SQL & "    K3471_OrderNo      = N'" & FormatSQL(z3471.OrderNo) & "', " 
    SQL = SQL & "    K3471_OrderNoSeq      = N'" & FormatSQL(z3471.OrderNoSeq) & "', " 
    SQL = SQL & "    K3471_LoadingCode      = N'" & FormatSQL(z3471.LoadingCode) & "', " 
    SQL = SQL & "    K3471_TransferType      = N'" & FormatSQL(z3471.TransferType) & "', " 
    SQL = SQL & "    K3471_ChkDeclare      = N'" & FormatSQL(z3471.ChkDeclare) & "', " 
    SQL = SQL & "    K3471_DateDeclare      = N'" & FormatSQL(z3471.DateDeclare) & "', " 
    SQL = SQL & "    K3471_ChkSMDocs      = N'" & FormatSQL(z3471.ChkSMDocs) & "', " 
    SQL = SQL & "    K3471_DateSMDocs      = N'" & FormatSQL(z3471.DateSMDocs) & "', " 
    SQL = SQL & "    K3471_ChkLocalCharge      = N'" & FormatSQL(z3471.ChkLocalCharge) & "', " 
    SQL = SQL & "    K3471_DateLocalCharge      = N'" & FormatSQL(z3471.DateLocalCharge) & "', " 
    SQL = SQL & "    K3471_ChkUploadDocs      = N'" & FormatSQL(z3471.ChkUploadDocs) & "', " 
    SQL = SQL & "    K3471_DateUploadDocs      = N'" & FormatSQL(z3471.DateUploadDocs) & "', " 
    SQL = SQL & "    K3471_ChkDocsHK      = N'" & FormatSQL(z3471.ChkDocsHK) & "', " 
    SQL = SQL & "    K3471_DateDocsHK      = N'" & FormatSQL(z3471.DateDocsHK) & "', " 
    SQL = SQL & "    K3471_ChkDocsBuyer      = N'" & FormatSQL(z3471.ChkDocsBuyer) & "', " 
    SQL = SQL & "    K3471_ChkReceiveHK      = N'" & FormatSQL(z3471.ChkReceiveHK) & "', " 
    SQL = SQL & "    K3471_ChkPending      = N'" & FormatSQL(z3471.ChkPending) & "', " 
    SQL = SQL & "    K3471_DateDocsBuyer      = N'" & FormatSQL(z3471.DateDocsBuyer) & "', " 
    SQL = SQL & "    K3471_CheckLiquidation      = N'" & FormatSQL(z3471.CheckLiquidation) & "', " 
    SQL = SQL & "    K3471_CheckStatus      =  " & FormatSQL(z3471.CheckStatus) & ", " 
    SQL = SQL & "    K3471_QtyOrder      =  " & FormatSQL(z3471.QtyOrder) & ", " 
    SQL = SQL & "    K3471_QtyOrderSample      =  " & FormatSQL(z3471.QtyOrderSample) & ", " 
    SQL = SQL & "    K3471_PriceOrderFOB      =  " & FormatSQL(z3471.PriceOrderFOB) & ", " 
    SQL = SQL & "    K3471_TotalAMTFOB      =  " & FormatSQL(z3471.TotalAMTFOB) & ", " 
    SQL = SQL & "    K3471_PriceOrder      =  " & FormatSQL(z3471.PriceOrder) & ", " 
    SQL = SQL & "    K3471_TotalAMT      =  " & FormatSQL(z3471.TotalAMT) & ", " 
    SQL = SQL & "    K3471_TotalGW      =  " & FormatSQL(z3471.TotalGW) & ", " 
    SQL = SQL & "    K3471_TotalNW      =  " & FormatSQL(z3471.TotalNW) & ", " 
    SQL = SQL & "    K3471_TotalCBM      =  " & FormatSQL(z3471.TotalCBM) & ", " 
    SQL = SQL & "    K3471_TotalQty      =  " & FormatSQL(z3471.TotalQty) & ", " 
    SQL = SQL & "    K3471_TotalCnt      =  " & FormatSQL(z3471.TotalCnt) & ", " 
    SQL = SQL & "    K3471_ContName1      = N'" & FormatSQL(z3471.ContName1) & "', " 
    SQL = SQL & "    K3471_ContName2      = N'" & FormatSQL(z3471.ContName2) & "', " 
    SQL = SQL & "    K3471_ContName3      = N'" & FormatSQL(z3471.ContName3) & "', " 
    SQL = SQL & "    K3471_ContName4      = N'" & FormatSQL(z3471.ContName4) & "', " 
    SQL = SQL & "    K3471_ContName5      = N'" & FormatSQL(z3471.ContName5) & "', " 
    SQL = SQL & "    K3471_ContName6      = N'" & FormatSQL(z3471.ContName6) & "', " 
    SQL = SQL & "    K3471_ContName7      = N'" & FormatSQL(z3471.ContName7) & "', " 
    SQL = SQL & "    K3471_ContName8      = N'" & FormatSQL(z3471.ContName8) & "', " 
    SQL = SQL & "    K3471_ContName9      = N'" & FormatSQL(z3471.ContName9) & "', " 
    SQL = SQL & "    K3471_ContName10      = N'" & FormatSQL(z3471.ContName10) & "', " 
    SQL = SQL & "    K3471_QtyPL1      =  " & FormatSQL(z3471.QtyPL1) & ", " 
    SQL = SQL & "    K3471_QtyPL2      =  " & FormatSQL(z3471.QtyPL2) & ", " 
    SQL = SQL & "    K3471_QtyPL3      =  " & FormatSQL(z3471.QtyPL3) & ", " 
    SQL = SQL & "    K3471_QtyPL4      =  " & FormatSQL(z3471.QtyPL4) & ", " 
    SQL = SQL & "    K3471_QtyPL5      =  " & FormatSQL(z3471.QtyPL5) & ", " 
    SQL = SQL & "    K3471_QtyPL6      =  " & FormatSQL(z3471.QtyPL6) & ", " 
    SQL = SQL & "    K3471_QtyPL7      =  " & FormatSQL(z3471.QtyPL7) & ", " 
    SQL = SQL & "    K3471_QtyPL8      =  " & FormatSQL(z3471.QtyPL8) & ", " 
    SQL = SQL & "    K3471_QtyPL9      =  " & FormatSQL(z3471.QtyPL9) & ", " 
    SQL = SQL & "    K3471_QtyPL10      =  " & FormatSQL(z3471.QtyPL10) & ", " 
    SQL = SQL & "    K3471_seSite      = N'" & FormatSQL(z3471.seSite) & "', " 
    SQL = SQL & "    K3471_cdSite      = N'" & FormatSQL(z3471.cdSite) & "', " 
    SQL = SQL & "    K3471_Remark      = N'" & FormatSQL(z3471.Remark) & "', " 
    SQL = SQL & "    K3471_TimeInsert      = N'" & FormatSQL(z3471.TimeInsert) & "', " 
    SQL = SQL & "    K3471_TimeUpdate      = N'" & FormatSQL(PUB.TIME) & "', " 
    SQL = SQL & "    K3471_DateUpdate      = N'" & FormatSQL(PUB.DAT) & "', " 
    SQL = SQL & "    K3471_DateInsert      = N'" & FormatSQL(z3471.DateInsert) & "', " 
    SQL = SQL & "    K3471_InchargeInsert      = N'" & FormatSQL(z3471.InchargeInsert) & "', " 
    SQL = SQL & "    K3471_InchargeUpdate      = N'" & FormatSQL(PUB.SAW) & "'  " 
    SQL = SQL & " WHERE K3471_LiquidNo		 = '" & z3471.LiquidNo & "' " 
    SQL = SQL & "   AND K3471_LiquidSeq		 = '" & z3471.LiquidSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  

    REWRITE_PFK3471 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK3471",vbCritical)

  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK3471(z3471 As T3471_AREA) As Boolean
    DELETE_PFK3471 = False

   Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z3471)
      
        SQL = " DELETE FROM PFK3471  "
    SQL = SQL & " WHERE K3471_LiquidNo		 = '" & z3471.LiquidNo & "' " 
    SQL = SQL & "   AND K3471_LiquidSeq		 = '" & z3471.LiquidSeq & "' " 

    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK3471 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK3471",vbCritical)
Finally
        Call GetFullInformation("PFK3471", "D", SQL)
  End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D3471_CLEAR()
Try
    
   D3471.LiquidNo = ""
   D3471.LiquidSeq = ""
   D3471.ShoesCode = ""
   D3471.YearLiquidation = ""
   D3471.DateDlr = ""
    D3471.SOTK = 0 
    D3471.TONGTGKB = 0 
   D3471.InvoiceNoMaster = ""
   D3471.InvoiceNo = ""
   D3471.InvoiceSeq = ""
   D3471.SONo = ""
   D3471.BookingNo = ""
   D3471.LoadingNo = ""
   D3471.VesselName = ""
   D3471.TradingName = ""
   D3471.TradingCode = ""
   D3471.ShipmentType = ""
   D3471.DateBL = ""
   D3471.BLNo = ""
   D3471.ContainerNo = ""
   D3471.seShipType = ""
   D3471.cdShipType = ""
   D3471.DateEXFac = ""
   D3471.DateETD = ""
   D3471.DateETA = ""
   D3471.OrderNo = ""
   D3471.OrderNoSeq = ""
   D3471.LoadingCode = ""
   D3471.TransferType = ""
   D3471.ChkDeclare = ""
   D3471.DateDeclare = ""
   D3471.ChkSMDocs = ""
   D3471.DateSMDocs = ""
   D3471.ChkLocalCharge = ""
   D3471.DateLocalCharge = ""
   D3471.ChkUploadDocs = ""
   D3471.DateUploadDocs = ""
   D3471.ChkDocsHK = ""
   D3471.DateDocsHK = ""
   D3471.ChkDocsBuyer = ""
   D3471.ChkReceiveHK = ""
   D3471.ChkPending = ""
   D3471.DateDocsBuyer = ""
   D3471.CheckLiquidation = ""
    D3471.CheckStatus = 0 
    D3471.QtyOrder = 0 
    D3471.QtyOrderSample = 0 
    D3471.PriceOrderFOB = 0 
    D3471.TotalAMTFOB = 0 
    D3471.PriceOrder = 0 
    D3471.TotalAMT = 0 
    D3471.TotalGW = 0 
    D3471.TotalNW = 0 
    D3471.TotalCBM = 0 
    D3471.TotalQty = 0 
    D3471.TotalCnt = 0 
   D3471.ContName1 = ""
   D3471.ContName2 = ""
   D3471.ContName3 = ""
   D3471.ContName4 = ""
   D3471.ContName5 = ""
   D3471.ContName6 = ""
   D3471.ContName7 = ""
   D3471.ContName8 = ""
   D3471.ContName9 = ""
   D3471.ContName10 = ""
    D3471.QtyPL1 = 0 
    D3471.QtyPL2 = 0 
    D3471.QtyPL3 = 0 
    D3471.QtyPL4 = 0 
    D3471.QtyPL5 = 0 
    D3471.QtyPL6 = 0 
    D3471.QtyPL7 = 0 
    D3471.QtyPL8 = 0 
    D3471.QtyPL9 = 0 
    D3471.QtyPL10 = 0 
   D3471.seSite = ""
   D3471.cdSite = ""
   D3471.Remark = ""
   D3471.TimeInsert = ""
   D3471.TimeUpdate = ""
   D3471.DateUpdate = ""
   D3471.DateInsert = ""
   D3471.InchargeInsert = ""
   D3471.InchargeUpdate = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D3471_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x3471 As T3471_AREA)
Try
    
    x3471.LiquidNo = trim$(  x3471.LiquidNo)
    x3471.LiquidSeq = trim$(  x3471.LiquidSeq)
    x3471.ShoesCode = trim$(  x3471.ShoesCode)
    x3471.YearLiquidation = trim$(  x3471.YearLiquidation)
    x3471.DateDlr = trim$(  x3471.DateDlr)
    x3471.SOTK = trim$(  x3471.SOTK)
    x3471.TONGTGKB = trim$(  x3471.TONGTGKB)
    x3471.InvoiceNoMaster = trim$(  x3471.InvoiceNoMaster)
    x3471.InvoiceNo = trim$(  x3471.InvoiceNo)
    x3471.InvoiceSeq = trim$(  x3471.InvoiceSeq)
    x3471.SONo = trim$(  x3471.SONo)
    x3471.BookingNo = trim$(  x3471.BookingNo)
    x3471.LoadingNo = trim$(  x3471.LoadingNo)
    x3471.VesselName = trim$(  x3471.VesselName)
    x3471.TradingName = trim$(  x3471.TradingName)
    x3471.TradingCode = trim$(  x3471.TradingCode)
    x3471.ShipmentType = trim$(  x3471.ShipmentType)
    x3471.DateBL = trim$(  x3471.DateBL)
    x3471.BLNo = trim$(  x3471.BLNo)
    x3471.ContainerNo = trim$(  x3471.ContainerNo)
    x3471.seShipType = trim$(  x3471.seShipType)
    x3471.cdShipType = trim$(  x3471.cdShipType)
    x3471.DateEXFac = trim$(  x3471.DateEXFac)
    x3471.DateETD = trim$(  x3471.DateETD)
    x3471.DateETA = trim$(  x3471.DateETA)
    x3471.OrderNo = trim$(  x3471.OrderNo)
    x3471.OrderNoSeq = trim$(  x3471.OrderNoSeq)
    x3471.LoadingCode = trim$(  x3471.LoadingCode)
    x3471.TransferType = trim$(  x3471.TransferType)
    x3471.ChkDeclare = trim$(  x3471.ChkDeclare)
    x3471.DateDeclare = trim$(  x3471.DateDeclare)
    x3471.ChkSMDocs = trim$(  x3471.ChkSMDocs)
    x3471.DateSMDocs = trim$(  x3471.DateSMDocs)
    x3471.ChkLocalCharge = trim$(  x3471.ChkLocalCharge)
    x3471.DateLocalCharge = trim$(  x3471.DateLocalCharge)
    x3471.ChkUploadDocs = trim$(  x3471.ChkUploadDocs)
    x3471.DateUploadDocs = trim$(  x3471.DateUploadDocs)
    x3471.ChkDocsHK = trim$(  x3471.ChkDocsHK)
    x3471.DateDocsHK = trim$(  x3471.DateDocsHK)
    x3471.ChkDocsBuyer = trim$(  x3471.ChkDocsBuyer)
    x3471.ChkReceiveHK = trim$(  x3471.ChkReceiveHK)
    x3471.ChkPending = trim$(  x3471.ChkPending)
    x3471.DateDocsBuyer = trim$(  x3471.DateDocsBuyer)
    x3471.CheckLiquidation = trim$(  x3471.CheckLiquidation)
    x3471.CheckStatus = trim$(  x3471.CheckStatus)
    x3471.QtyOrder = trim$(  x3471.QtyOrder)
    x3471.QtyOrderSample = trim$(  x3471.QtyOrderSample)
    x3471.PriceOrderFOB = trim$(  x3471.PriceOrderFOB)
    x3471.TotalAMTFOB = trim$(  x3471.TotalAMTFOB)
    x3471.PriceOrder = trim$(  x3471.PriceOrder)
    x3471.TotalAMT = trim$(  x3471.TotalAMT)
    x3471.TotalGW = trim$(  x3471.TotalGW)
    x3471.TotalNW = trim$(  x3471.TotalNW)
    x3471.TotalCBM = trim$(  x3471.TotalCBM)
    x3471.TotalQty = trim$(  x3471.TotalQty)
    x3471.TotalCnt = trim$(  x3471.TotalCnt)
    x3471.ContName1 = trim$(  x3471.ContName1)
    x3471.ContName2 = trim$(  x3471.ContName2)
    x3471.ContName3 = trim$(  x3471.ContName3)
    x3471.ContName4 = trim$(  x3471.ContName4)
    x3471.ContName5 = trim$(  x3471.ContName5)
    x3471.ContName6 = trim$(  x3471.ContName6)
    x3471.ContName7 = trim$(  x3471.ContName7)
    x3471.ContName8 = trim$(  x3471.ContName8)
    x3471.ContName9 = trim$(  x3471.ContName9)
    x3471.ContName10 = trim$(  x3471.ContName10)
    x3471.QtyPL1 = trim$(  x3471.QtyPL1)
    x3471.QtyPL2 = trim$(  x3471.QtyPL2)
    x3471.QtyPL3 = trim$(  x3471.QtyPL3)
    x3471.QtyPL4 = trim$(  x3471.QtyPL4)
    x3471.QtyPL5 = trim$(  x3471.QtyPL5)
    x3471.QtyPL6 = trim$(  x3471.QtyPL6)
    x3471.QtyPL7 = trim$(  x3471.QtyPL7)
    x3471.QtyPL8 = trim$(  x3471.QtyPL8)
    x3471.QtyPL9 = trim$(  x3471.QtyPL9)
    x3471.QtyPL10 = trim$(  x3471.QtyPL10)
    x3471.seSite = trim$(  x3471.seSite)
    x3471.cdSite = trim$(  x3471.cdSite)
    x3471.Remark = trim$(  x3471.Remark)
    x3471.TimeInsert = trim$(  x3471.TimeInsert)
    x3471.TimeUpdate = trim$(  x3471.TimeUpdate)
    x3471.DateUpdate = trim$(  x3471.DateUpdate)
    x3471.DateInsert = trim$(  x3471.DateInsert)
    x3471.InchargeInsert = trim$(  x3471.InchargeInsert)
    x3471.InchargeUpdate = trim$(  x3471.InchargeUpdate)
     
    If trim$( x3471.LiquidNo ) = "" Then x3471.LiquidNo = Space(1) 
    If trim$( x3471.LiquidSeq ) = "" Then x3471.LiquidSeq = Space(1) 
    If trim$( x3471.ShoesCode ) = "" Then x3471.ShoesCode = Space(1) 
    If trim$( x3471.YearLiquidation ) = "" Then x3471.YearLiquidation = Space(1) 
    If trim$( x3471.DateDlr ) = "" Then x3471.DateDlr = Space(1) 
    If trim$( x3471.SOTK ) = "" Then x3471.SOTK = 0 
    If trim$( x3471.TONGTGKB ) = "" Then x3471.TONGTGKB = 0 
    If trim$( x3471.InvoiceNoMaster ) = "" Then x3471.InvoiceNoMaster = Space(1) 
    If trim$( x3471.InvoiceNo ) = "" Then x3471.InvoiceNo = Space(1) 
    If trim$( x3471.InvoiceSeq ) = "" Then x3471.InvoiceSeq = Space(1) 
    If trim$( x3471.SONo ) = "" Then x3471.SONo = Space(1) 
    If trim$( x3471.BookingNo ) = "" Then x3471.BookingNo = Space(1) 
    If trim$( x3471.LoadingNo ) = "" Then x3471.LoadingNo = Space(1) 
    If trim$( x3471.VesselName ) = "" Then x3471.VesselName = Space(1) 
    If trim$( x3471.TradingName ) = "" Then x3471.TradingName = Space(1) 
    If trim$( x3471.TradingCode ) = "" Then x3471.TradingCode = Space(1) 
    If trim$( x3471.ShipmentType ) = "" Then x3471.ShipmentType = Space(1) 
    If trim$( x3471.DateBL ) = "" Then x3471.DateBL = Space(1) 
    If trim$( x3471.BLNo ) = "" Then x3471.BLNo = Space(1) 
    If trim$( x3471.ContainerNo ) = "" Then x3471.ContainerNo = Space(1) 
    If trim$( x3471.seShipType ) = "" Then x3471.seShipType = Space(1) 
    If trim$( x3471.cdShipType ) = "" Then x3471.cdShipType = Space(1) 
    If trim$( x3471.DateEXFac ) = "" Then x3471.DateEXFac = Space(1) 
    If trim$( x3471.DateETD ) = "" Then x3471.DateETD = Space(1) 
    If trim$( x3471.DateETA ) = "" Then x3471.DateETA = Space(1) 
    If trim$( x3471.OrderNo ) = "" Then x3471.OrderNo = Space(1) 
    If trim$( x3471.OrderNoSeq ) = "" Then x3471.OrderNoSeq = Space(1) 
    If trim$( x3471.LoadingCode ) = "" Then x3471.LoadingCode = Space(1) 
    If trim$( x3471.TransferType ) = "" Then x3471.TransferType = Space(1) 
    If trim$( x3471.ChkDeclare ) = "" Then x3471.ChkDeclare = Space(1) 
    If trim$( x3471.DateDeclare ) = "" Then x3471.DateDeclare = Space(1) 
    If trim$( x3471.ChkSMDocs ) = "" Then x3471.ChkSMDocs = Space(1) 
    If trim$( x3471.DateSMDocs ) = "" Then x3471.DateSMDocs = Space(1) 
    If trim$( x3471.ChkLocalCharge ) = "" Then x3471.ChkLocalCharge = Space(1) 
    If trim$( x3471.DateLocalCharge ) = "" Then x3471.DateLocalCharge = Space(1) 
    If trim$( x3471.ChkUploadDocs ) = "" Then x3471.ChkUploadDocs = Space(1) 
    If trim$( x3471.DateUploadDocs ) = "" Then x3471.DateUploadDocs = Space(1) 
    If trim$( x3471.ChkDocsHK ) = "" Then x3471.ChkDocsHK = Space(1) 
    If trim$( x3471.DateDocsHK ) = "" Then x3471.DateDocsHK = Space(1) 
    If trim$( x3471.ChkDocsBuyer ) = "" Then x3471.ChkDocsBuyer = Space(1) 
    If trim$( x3471.ChkReceiveHK ) = "" Then x3471.ChkReceiveHK = Space(1) 
    If trim$( x3471.ChkPending ) = "" Then x3471.ChkPending = Space(1) 
    If trim$( x3471.DateDocsBuyer ) = "" Then x3471.DateDocsBuyer = Space(1) 
    If trim$( x3471.CheckLiquidation ) = "" Then x3471.CheckLiquidation = Space(1) 
    If trim$( x3471.CheckStatus ) = "" Then x3471.CheckStatus = 0 
    If trim$( x3471.QtyOrder ) = "" Then x3471.QtyOrder = 0 
    If trim$( x3471.QtyOrderSample ) = "" Then x3471.QtyOrderSample = 0 
    If trim$( x3471.PriceOrderFOB ) = "" Then x3471.PriceOrderFOB = 0 
    If trim$( x3471.TotalAMTFOB ) = "" Then x3471.TotalAMTFOB = 0 
    If trim$( x3471.PriceOrder ) = "" Then x3471.PriceOrder = 0 
    If trim$( x3471.TotalAMT ) = "" Then x3471.TotalAMT = 0 
    If trim$( x3471.TotalGW ) = "" Then x3471.TotalGW = 0 
    If trim$( x3471.TotalNW ) = "" Then x3471.TotalNW = 0 
    If trim$( x3471.TotalCBM ) = "" Then x3471.TotalCBM = 0 
    If trim$( x3471.TotalQty ) = "" Then x3471.TotalQty = 0 
    If trim$( x3471.TotalCnt ) = "" Then x3471.TotalCnt = 0 
    If trim$( x3471.ContName1 ) = "" Then x3471.ContName1 = Space(1) 
    If trim$( x3471.ContName2 ) = "" Then x3471.ContName2 = Space(1) 
    If trim$( x3471.ContName3 ) = "" Then x3471.ContName3 = Space(1) 
    If trim$( x3471.ContName4 ) = "" Then x3471.ContName4 = Space(1) 
    If trim$( x3471.ContName5 ) = "" Then x3471.ContName5 = Space(1) 
    If trim$( x3471.ContName6 ) = "" Then x3471.ContName6 = Space(1) 
    If trim$( x3471.ContName7 ) = "" Then x3471.ContName7 = Space(1) 
    If trim$( x3471.ContName8 ) = "" Then x3471.ContName8 = Space(1) 
    If trim$( x3471.ContName9 ) = "" Then x3471.ContName9 = Space(1) 
    If trim$( x3471.ContName10 ) = "" Then x3471.ContName10 = Space(1) 
    If trim$( x3471.QtyPL1 ) = "" Then x3471.QtyPL1 = 0 
    If trim$( x3471.QtyPL2 ) = "" Then x3471.QtyPL2 = 0 
    If trim$( x3471.QtyPL3 ) = "" Then x3471.QtyPL3 = 0 
    If trim$( x3471.QtyPL4 ) = "" Then x3471.QtyPL4 = 0 
    If trim$( x3471.QtyPL5 ) = "" Then x3471.QtyPL5 = 0 
    If trim$( x3471.QtyPL6 ) = "" Then x3471.QtyPL6 = 0 
    If trim$( x3471.QtyPL7 ) = "" Then x3471.QtyPL7 = 0 
    If trim$( x3471.QtyPL8 ) = "" Then x3471.QtyPL8 = 0 
    If trim$( x3471.QtyPL9 ) = "" Then x3471.QtyPL9 = 0 
    If trim$( x3471.QtyPL10 ) = "" Then x3471.QtyPL10 = 0 
    If trim$( x3471.seSite ) = "" Then x3471.seSite = Space(1) 
    If trim$( x3471.cdSite ) = "" Then x3471.cdSite = Space(1) 
    If trim$( x3471.Remark ) = "" Then x3471.Remark = Space(1) 
    If trim$( x3471.TimeInsert ) = "" Then x3471.TimeInsert = Space(1) 
    If trim$( x3471.TimeUpdate ) = "" Then x3471.TimeUpdate = Space(1) 
    If trim$( x3471.DateUpdate ) = "" Then x3471.DateUpdate = Space(1) 
    If trim$( x3471.DateInsert ) = "" Then x3471.DateInsert = Space(1) 
    If trim$( x3471.InchargeInsert ) = "" Then x3471.InchargeInsert = Space(1) 
    If trim$( x3471.InchargeUpdate ) = "" Then x3471.InchargeUpdate = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K3471_MOVE(rs3471 As SqlClient.SqlDataReader)
Try

    call D3471_CLEAR()   

    If IsdbNull(rs3471!K3471_LiquidNo) = False Then D3471.LiquidNo = Trim$(rs3471!K3471_LiquidNo)
    If IsdbNull(rs3471!K3471_LiquidSeq) = False Then D3471.LiquidSeq = Trim$(rs3471!K3471_LiquidSeq)
    If IsdbNull(rs3471!K3471_ShoesCode) = False Then D3471.ShoesCode = Trim$(rs3471!K3471_ShoesCode)
    If IsdbNull(rs3471!K3471_YearLiquidation) = False Then D3471.YearLiquidation = Trim$(rs3471!K3471_YearLiquidation)
    If IsdbNull(rs3471!K3471_DateDlr) = False Then D3471.DateDlr = Trim$(rs3471!K3471_DateDlr)
    If IsdbNull(rs3471!K3471_SOTK) = False Then D3471.SOTK = Trim$(rs3471!K3471_SOTK)
    If IsdbNull(rs3471!K3471_TONGTGKB) = False Then D3471.TONGTGKB = Trim$(rs3471!K3471_TONGTGKB)
    If IsdbNull(rs3471!K3471_InvoiceNoMaster) = False Then D3471.InvoiceNoMaster = Trim$(rs3471!K3471_InvoiceNoMaster)
    If IsdbNull(rs3471!K3471_InvoiceNo) = False Then D3471.InvoiceNo = Trim$(rs3471!K3471_InvoiceNo)
    If IsdbNull(rs3471!K3471_InvoiceSeq) = False Then D3471.InvoiceSeq = Trim$(rs3471!K3471_InvoiceSeq)
    If IsdbNull(rs3471!K3471_SONo) = False Then D3471.SONo = Trim$(rs3471!K3471_SONo)
    If IsdbNull(rs3471!K3471_BookingNo) = False Then D3471.BookingNo = Trim$(rs3471!K3471_BookingNo)
    If IsdbNull(rs3471!K3471_LoadingNo) = False Then D3471.LoadingNo = Trim$(rs3471!K3471_LoadingNo)
    If IsdbNull(rs3471!K3471_VesselName) = False Then D3471.VesselName = Trim$(rs3471!K3471_VesselName)
    If IsdbNull(rs3471!K3471_TradingName) = False Then D3471.TradingName = Trim$(rs3471!K3471_TradingName)
    If IsdbNull(rs3471!K3471_TradingCode) = False Then D3471.TradingCode = Trim$(rs3471!K3471_TradingCode)
    If IsdbNull(rs3471!K3471_ShipmentType) = False Then D3471.ShipmentType = Trim$(rs3471!K3471_ShipmentType)
    If IsdbNull(rs3471!K3471_DateBL) = False Then D3471.DateBL = Trim$(rs3471!K3471_DateBL)
    If IsdbNull(rs3471!K3471_BLNo) = False Then D3471.BLNo = Trim$(rs3471!K3471_BLNo)
    If IsdbNull(rs3471!K3471_ContainerNo) = False Then D3471.ContainerNo = Trim$(rs3471!K3471_ContainerNo)
    If IsdbNull(rs3471!K3471_seShipType) = False Then D3471.seShipType = Trim$(rs3471!K3471_seShipType)
    If IsdbNull(rs3471!K3471_cdShipType) = False Then D3471.cdShipType = Trim$(rs3471!K3471_cdShipType)
    If IsdbNull(rs3471!K3471_DateEXFac) = False Then D3471.DateEXFac = Trim$(rs3471!K3471_DateEXFac)
    If IsdbNull(rs3471!K3471_DateETD) = False Then D3471.DateETD = Trim$(rs3471!K3471_DateETD)
    If IsdbNull(rs3471!K3471_DateETA) = False Then D3471.DateETA = Trim$(rs3471!K3471_DateETA)
    If IsdbNull(rs3471!K3471_OrderNo) = False Then D3471.OrderNo = Trim$(rs3471!K3471_OrderNo)
    If IsdbNull(rs3471!K3471_OrderNoSeq) = False Then D3471.OrderNoSeq = Trim$(rs3471!K3471_OrderNoSeq)
    If IsdbNull(rs3471!K3471_LoadingCode) = False Then D3471.LoadingCode = Trim$(rs3471!K3471_LoadingCode)
    If IsdbNull(rs3471!K3471_TransferType) = False Then D3471.TransferType = Trim$(rs3471!K3471_TransferType)
    If IsdbNull(rs3471!K3471_ChkDeclare) = False Then D3471.ChkDeclare = Trim$(rs3471!K3471_ChkDeclare)
    If IsdbNull(rs3471!K3471_DateDeclare) = False Then D3471.DateDeclare = Trim$(rs3471!K3471_DateDeclare)
    If IsdbNull(rs3471!K3471_ChkSMDocs) = False Then D3471.ChkSMDocs = Trim$(rs3471!K3471_ChkSMDocs)
    If IsdbNull(rs3471!K3471_DateSMDocs) = False Then D3471.DateSMDocs = Trim$(rs3471!K3471_DateSMDocs)
    If IsdbNull(rs3471!K3471_ChkLocalCharge) = False Then D3471.ChkLocalCharge = Trim$(rs3471!K3471_ChkLocalCharge)
    If IsdbNull(rs3471!K3471_DateLocalCharge) = False Then D3471.DateLocalCharge = Trim$(rs3471!K3471_DateLocalCharge)
    If IsdbNull(rs3471!K3471_ChkUploadDocs) = False Then D3471.ChkUploadDocs = Trim$(rs3471!K3471_ChkUploadDocs)
    If IsdbNull(rs3471!K3471_DateUploadDocs) = False Then D3471.DateUploadDocs = Trim$(rs3471!K3471_DateUploadDocs)
    If IsdbNull(rs3471!K3471_ChkDocsHK) = False Then D3471.ChkDocsHK = Trim$(rs3471!K3471_ChkDocsHK)
    If IsdbNull(rs3471!K3471_DateDocsHK) = False Then D3471.DateDocsHK = Trim$(rs3471!K3471_DateDocsHK)
    If IsdbNull(rs3471!K3471_ChkDocsBuyer) = False Then D3471.ChkDocsBuyer = Trim$(rs3471!K3471_ChkDocsBuyer)
    If IsdbNull(rs3471!K3471_ChkReceiveHK) = False Then D3471.ChkReceiveHK = Trim$(rs3471!K3471_ChkReceiveHK)
    If IsdbNull(rs3471!K3471_ChkPending) = False Then D3471.ChkPending = Trim$(rs3471!K3471_ChkPending)
    If IsdbNull(rs3471!K3471_DateDocsBuyer) = False Then D3471.DateDocsBuyer = Trim$(rs3471!K3471_DateDocsBuyer)
    If IsdbNull(rs3471!K3471_CheckLiquidation) = False Then D3471.CheckLiquidation = Trim$(rs3471!K3471_CheckLiquidation)
    If IsdbNull(rs3471!K3471_CheckStatus) = False Then D3471.CheckStatus = Trim$(rs3471!K3471_CheckStatus)
    If IsdbNull(rs3471!K3471_QtyOrder) = False Then D3471.QtyOrder = Trim$(rs3471!K3471_QtyOrder)
    If IsdbNull(rs3471!K3471_QtyOrderSample) = False Then D3471.QtyOrderSample = Trim$(rs3471!K3471_QtyOrderSample)
    If IsdbNull(rs3471!K3471_PriceOrderFOB) = False Then D3471.PriceOrderFOB = Trim$(rs3471!K3471_PriceOrderFOB)
    If IsdbNull(rs3471!K3471_TotalAMTFOB) = False Then D3471.TotalAMTFOB = Trim$(rs3471!K3471_TotalAMTFOB)
    If IsdbNull(rs3471!K3471_PriceOrder) = False Then D3471.PriceOrder = Trim$(rs3471!K3471_PriceOrder)
    If IsdbNull(rs3471!K3471_TotalAMT) = False Then D3471.TotalAMT = Trim$(rs3471!K3471_TotalAMT)
    If IsdbNull(rs3471!K3471_TotalGW) = False Then D3471.TotalGW = Trim$(rs3471!K3471_TotalGW)
    If IsdbNull(rs3471!K3471_TotalNW) = False Then D3471.TotalNW = Trim$(rs3471!K3471_TotalNW)
    If IsdbNull(rs3471!K3471_TotalCBM) = False Then D3471.TotalCBM = Trim$(rs3471!K3471_TotalCBM)
    If IsdbNull(rs3471!K3471_TotalQty) = False Then D3471.TotalQty = Trim$(rs3471!K3471_TotalQty)
    If IsdbNull(rs3471!K3471_TotalCnt) = False Then D3471.TotalCnt = Trim$(rs3471!K3471_TotalCnt)
    If IsdbNull(rs3471!K3471_ContName1) = False Then D3471.ContName1 = Trim$(rs3471!K3471_ContName1)
    If IsdbNull(rs3471!K3471_ContName2) = False Then D3471.ContName2 = Trim$(rs3471!K3471_ContName2)
    If IsdbNull(rs3471!K3471_ContName3) = False Then D3471.ContName3 = Trim$(rs3471!K3471_ContName3)
    If IsdbNull(rs3471!K3471_ContName4) = False Then D3471.ContName4 = Trim$(rs3471!K3471_ContName4)
    If IsdbNull(rs3471!K3471_ContName5) = False Then D3471.ContName5 = Trim$(rs3471!K3471_ContName5)
    If IsdbNull(rs3471!K3471_ContName6) = False Then D3471.ContName6 = Trim$(rs3471!K3471_ContName6)
    If IsdbNull(rs3471!K3471_ContName7) = False Then D3471.ContName7 = Trim$(rs3471!K3471_ContName7)
    If IsdbNull(rs3471!K3471_ContName8) = False Then D3471.ContName8 = Trim$(rs3471!K3471_ContName8)
    If IsdbNull(rs3471!K3471_ContName9) = False Then D3471.ContName9 = Trim$(rs3471!K3471_ContName9)
    If IsdbNull(rs3471!K3471_ContName10) = False Then D3471.ContName10 = Trim$(rs3471!K3471_ContName10)
    If IsdbNull(rs3471!K3471_QtyPL1) = False Then D3471.QtyPL1 = Trim$(rs3471!K3471_QtyPL1)
    If IsdbNull(rs3471!K3471_QtyPL2) = False Then D3471.QtyPL2 = Trim$(rs3471!K3471_QtyPL2)
    If IsdbNull(rs3471!K3471_QtyPL3) = False Then D3471.QtyPL3 = Trim$(rs3471!K3471_QtyPL3)
    If IsdbNull(rs3471!K3471_QtyPL4) = False Then D3471.QtyPL4 = Trim$(rs3471!K3471_QtyPL4)
    If IsdbNull(rs3471!K3471_QtyPL5) = False Then D3471.QtyPL5 = Trim$(rs3471!K3471_QtyPL5)
    If IsdbNull(rs3471!K3471_QtyPL6) = False Then D3471.QtyPL6 = Trim$(rs3471!K3471_QtyPL6)
    If IsdbNull(rs3471!K3471_QtyPL7) = False Then D3471.QtyPL7 = Trim$(rs3471!K3471_QtyPL7)
    If IsdbNull(rs3471!K3471_QtyPL8) = False Then D3471.QtyPL8 = Trim$(rs3471!K3471_QtyPL8)
    If IsdbNull(rs3471!K3471_QtyPL9) = False Then D3471.QtyPL9 = Trim$(rs3471!K3471_QtyPL9)
    If IsdbNull(rs3471!K3471_QtyPL10) = False Then D3471.QtyPL10 = Trim$(rs3471!K3471_QtyPL10)
    If IsdbNull(rs3471!K3471_seSite) = False Then D3471.seSite = Trim$(rs3471!K3471_seSite)
    If IsdbNull(rs3471!K3471_cdSite) = False Then D3471.cdSite = Trim$(rs3471!K3471_cdSite)
    If IsdbNull(rs3471!K3471_Remark) = False Then D3471.Remark = Trim$(rs3471!K3471_Remark)
    If IsdbNull(rs3471!K3471_TimeInsert) = False Then D3471.TimeInsert = Trim$(rs3471!K3471_TimeInsert)
    If IsdbNull(rs3471!K3471_TimeUpdate) = False Then D3471.TimeUpdate = Trim$(rs3471!K3471_TimeUpdate)
    If IsdbNull(rs3471!K3471_DateUpdate) = False Then D3471.DateUpdate = Trim$(rs3471!K3471_DateUpdate)
    If IsdbNull(rs3471!K3471_DateInsert) = False Then D3471.DateInsert = Trim$(rs3471!K3471_DateInsert)
    If IsdbNull(rs3471!K3471_InchargeInsert) = False Then D3471.InchargeInsert = Trim$(rs3471!K3471_InchargeInsert)
    If IsdbNull(rs3471!K3471_InchargeUpdate) = False Then D3471.InchargeUpdate = Trim$(rs3471!K3471_InchargeUpdate)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K3471_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K3471_MOVE(rs3471 As DataRow)
Try

    call D3471_CLEAR()   

    If IsdbNull(rs3471!K3471_LiquidNo) = False Then D3471.LiquidNo = Trim$(rs3471!K3471_LiquidNo)
    If IsdbNull(rs3471!K3471_LiquidSeq) = False Then D3471.LiquidSeq = Trim$(rs3471!K3471_LiquidSeq)
    If IsdbNull(rs3471!K3471_ShoesCode) = False Then D3471.ShoesCode = Trim$(rs3471!K3471_ShoesCode)
    If IsdbNull(rs3471!K3471_YearLiquidation) = False Then D3471.YearLiquidation = Trim$(rs3471!K3471_YearLiquidation)
    If IsdbNull(rs3471!K3471_DateDlr) = False Then D3471.DateDlr = Trim$(rs3471!K3471_DateDlr)
    If IsdbNull(rs3471!K3471_SOTK) = False Then D3471.SOTK = Trim$(rs3471!K3471_SOTK)
    If IsdbNull(rs3471!K3471_TONGTGKB) = False Then D3471.TONGTGKB = Trim$(rs3471!K3471_TONGTGKB)
    If IsdbNull(rs3471!K3471_InvoiceNoMaster) = False Then D3471.InvoiceNoMaster = Trim$(rs3471!K3471_InvoiceNoMaster)
    If IsdbNull(rs3471!K3471_InvoiceNo) = False Then D3471.InvoiceNo = Trim$(rs3471!K3471_InvoiceNo)
    If IsdbNull(rs3471!K3471_InvoiceSeq) = False Then D3471.InvoiceSeq = Trim$(rs3471!K3471_InvoiceSeq)
    If IsdbNull(rs3471!K3471_SONo) = False Then D3471.SONo = Trim$(rs3471!K3471_SONo)
    If IsdbNull(rs3471!K3471_BookingNo) = False Then D3471.BookingNo = Trim$(rs3471!K3471_BookingNo)
    If IsdbNull(rs3471!K3471_LoadingNo) = False Then D3471.LoadingNo = Trim$(rs3471!K3471_LoadingNo)
    If IsdbNull(rs3471!K3471_VesselName) = False Then D3471.VesselName = Trim$(rs3471!K3471_VesselName)
    If IsdbNull(rs3471!K3471_TradingName) = False Then D3471.TradingName = Trim$(rs3471!K3471_TradingName)
    If IsdbNull(rs3471!K3471_TradingCode) = False Then D3471.TradingCode = Trim$(rs3471!K3471_TradingCode)
    If IsdbNull(rs3471!K3471_ShipmentType) = False Then D3471.ShipmentType = Trim$(rs3471!K3471_ShipmentType)
    If IsdbNull(rs3471!K3471_DateBL) = False Then D3471.DateBL = Trim$(rs3471!K3471_DateBL)
    If IsdbNull(rs3471!K3471_BLNo) = False Then D3471.BLNo = Trim$(rs3471!K3471_BLNo)
    If IsdbNull(rs3471!K3471_ContainerNo) = False Then D3471.ContainerNo = Trim$(rs3471!K3471_ContainerNo)
    If IsdbNull(rs3471!K3471_seShipType) = False Then D3471.seShipType = Trim$(rs3471!K3471_seShipType)
    If IsdbNull(rs3471!K3471_cdShipType) = False Then D3471.cdShipType = Trim$(rs3471!K3471_cdShipType)
    If IsdbNull(rs3471!K3471_DateEXFac) = False Then D3471.DateEXFac = Trim$(rs3471!K3471_DateEXFac)
    If IsdbNull(rs3471!K3471_DateETD) = False Then D3471.DateETD = Trim$(rs3471!K3471_DateETD)
    If IsdbNull(rs3471!K3471_DateETA) = False Then D3471.DateETA = Trim$(rs3471!K3471_DateETA)
    If IsdbNull(rs3471!K3471_OrderNo) = False Then D3471.OrderNo = Trim$(rs3471!K3471_OrderNo)
    If IsdbNull(rs3471!K3471_OrderNoSeq) = False Then D3471.OrderNoSeq = Trim$(rs3471!K3471_OrderNoSeq)
    If IsdbNull(rs3471!K3471_LoadingCode) = False Then D3471.LoadingCode = Trim$(rs3471!K3471_LoadingCode)
    If IsdbNull(rs3471!K3471_TransferType) = False Then D3471.TransferType = Trim$(rs3471!K3471_TransferType)
    If IsdbNull(rs3471!K3471_ChkDeclare) = False Then D3471.ChkDeclare = Trim$(rs3471!K3471_ChkDeclare)
    If IsdbNull(rs3471!K3471_DateDeclare) = False Then D3471.DateDeclare = Trim$(rs3471!K3471_DateDeclare)
    If IsdbNull(rs3471!K3471_ChkSMDocs) = False Then D3471.ChkSMDocs = Trim$(rs3471!K3471_ChkSMDocs)
    If IsdbNull(rs3471!K3471_DateSMDocs) = False Then D3471.DateSMDocs = Trim$(rs3471!K3471_DateSMDocs)
    If IsdbNull(rs3471!K3471_ChkLocalCharge) = False Then D3471.ChkLocalCharge = Trim$(rs3471!K3471_ChkLocalCharge)
    If IsdbNull(rs3471!K3471_DateLocalCharge) = False Then D3471.DateLocalCharge = Trim$(rs3471!K3471_DateLocalCharge)
    If IsdbNull(rs3471!K3471_ChkUploadDocs) = False Then D3471.ChkUploadDocs = Trim$(rs3471!K3471_ChkUploadDocs)
    If IsdbNull(rs3471!K3471_DateUploadDocs) = False Then D3471.DateUploadDocs = Trim$(rs3471!K3471_DateUploadDocs)
    If IsdbNull(rs3471!K3471_ChkDocsHK) = False Then D3471.ChkDocsHK = Trim$(rs3471!K3471_ChkDocsHK)
    If IsdbNull(rs3471!K3471_DateDocsHK) = False Then D3471.DateDocsHK = Trim$(rs3471!K3471_DateDocsHK)
    If IsdbNull(rs3471!K3471_ChkDocsBuyer) = False Then D3471.ChkDocsBuyer = Trim$(rs3471!K3471_ChkDocsBuyer)
    If IsdbNull(rs3471!K3471_ChkReceiveHK) = False Then D3471.ChkReceiveHK = Trim$(rs3471!K3471_ChkReceiveHK)
    If IsdbNull(rs3471!K3471_ChkPending) = False Then D3471.ChkPending = Trim$(rs3471!K3471_ChkPending)
    If IsdbNull(rs3471!K3471_DateDocsBuyer) = False Then D3471.DateDocsBuyer = Trim$(rs3471!K3471_DateDocsBuyer)
    If IsdbNull(rs3471!K3471_CheckLiquidation) = False Then D3471.CheckLiquidation = Trim$(rs3471!K3471_CheckLiquidation)
    If IsdbNull(rs3471!K3471_CheckStatus) = False Then D3471.CheckStatus = Trim$(rs3471!K3471_CheckStatus)
    If IsdbNull(rs3471!K3471_QtyOrder) = False Then D3471.QtyOrder = Trim$(rs3471!K3471_QtyOrder)
    If IsdbNull(rs3471!K3471_QtyOrderSample) = False Then D3471.QtyOrderSample = Trim$(rs3471!K3471_QtyOrderSample)
    If IsdbNull(rs3471!K3471_PriceOrderFOB) = False Then D3471.PriceOrderFOB = Trim$(rs3471!K3471_PriceOrderFOB)
    If IsdbNull(rs3471!K3471_TotalAMTFOB) = False Then D3471.TotalAMTFOB = Trim$(rs3471!K3471_TotalAMTFOB)
    If IsdbNull(rs3471!K3471_PriceOrder) = False Then D3471.PriceOrder = Trim$(rs3471!K3471_PriceOrder)
    If IsdbNull(rs3471!K3471_TotalAMT) = False Then D3471.TotalAMT = Trim$(rs3471!K3471_TotalAMT)
    If IsdbNull(rs3471!K3471_TotalGW) = False Then D3471.TotalGW = Trim$(rs3471!K3471_TotalGW)
    If IsdbNull(rs3471!K3471_TotalNW) = False Then D3471.TotalNW = Trim$(rs3471!K3471_TotalNW)
    If IsdbNull(rs3471!K3471_TotalCBM) = False Then D3471.TotalCBM = Trim$(rs3471!K3471_TotalCBM)
    If IsdbNull(rs3471!K3471_TotalQty) = False Then D3471.TotalQty = Trim$(rs3471!K3471_TotalQty)
    If IsdbNull(rs3471!K3471_TotalCnt) = False Then D3471.TotalCnt = Trim$(rs3471!K3471_TotalCnt)
    If IsdbNull(rs3471!K3471_ContName1) = False Then D3471.ContName1 = Trim$(rs3471!K3471_ContName1)
    If IsdbNull(rs3471!K3471_ContName2) = False Then D3471.ContName2 = Trim$(rs3471!K3471_ContName2)
    If IsdbNull(rs3471!K3471_ContName3) = False Then D3471.ContName3 = Trim$(rs3471!K3471_ContName3)
    If IsdbNull(rs3471!K3471_ContName4) = False Then D3471.ContName4 = Trim$(rs3471!K3471_ContName4)
    If IsdbNull(rs3471!K3471_ContName5) = False Then D3471.ContName5 = Trim$(rs3471!K3471_ContName5)
    If IsdbNull(rs3471!K3471_ContName6) = False Then D3471.ContName6 = Trim$(rs3471!K3471_ContName6)
    If IsdbNull(rs3471!K3471_ContName7) = False Then D3471.ContName7 = Trim$(rs3471!K3471_ContName7)
    If IsdbNull(rs3471!K3471_ContName8) = False Then D3471.ContName8 = Trim$(rs3471!K3471_ContName8)
    If IsdbNull(rs3471!K3471_ContName9) = False Then D3471.ContName9 = Trim$(rs3471!K3471_ContName9)
    If IsdbNull(rs3471!K3471_ContName10) = False Then D3471.ContName10 = Trim$(rs3471!K3471_ContName10)
    If IsdbNull(rs3471!K3471_QtyPL1) = False Then D3471.QtyPL1 = Trim$(rs3471!K3471_QtyPL1)
    If IsdbNull(rs3471!K3471_QtyPL2) = False Then D3471.QtyPL2 = Trim$(rs3471!K3471_QtyPL2)
    If IsdbNull(rs3471!K3471_QtyPL3) = False Then D3471.QtyPL3 = Trim$(rs3471!K3471_QtyPL3)
    If IsdbNull(rs3471!K3471_QtyPL4) = False Then D3471.QtyPL4 = Trim$(rs3471!K3471_QtyPL4)
    If IsdbNull(rs3471!K3471_QtyPL5) = False Then D3471.QtyPL5 = Trim$(rs3471!K3471_QtyPL5)
    If IsdbNull(rs3471!K3471_QtyPL6) = False Then D3471.QtyPL6 = Trim$(rs3471!K3471_QtyPL6)
    If IsdbNull(rs3471!K3471_QtyPL7) = False Then D3471.QtyPL7 = Trim$(rs3471!K3471_QtyPL7)
    If IsdbNull(rs3471!K3471_QtyPL8) = False Then D3471.QtyPL8 = Trim$(rs3471!K3471_QtyPL8)
    If IsdbNull(rs3471!K3471_QtyPL9) = False Then D3471.QtyPL9 = Trim$(rs3471!K3471_QtyPL9)
    If IsdbNull(rs3471!K3471_QtyPL10) = False Then D3471.QtyPL10 = Trim$(rs3471!K3471_QtyPL10)
    If IsdbNull(rs3471!K3471_seSite) = False Then D3471.seSite = Trim$(rs3471!K3471_seSite)
    If IsdbNull(rs3471!K3471_cdSite) = False Then D3471.cdSite = Trim$(rs3471!K3471_cdSite)
    If IsdbNull(rs3471!K3471_Remark) = False Then D3471.Remark = Trim$(rs3471!K3471_Remark)
    If IsdbNull(rs3471!K3471_TimeInsert) = False Then D3471.TimeInsert = Trim$(rs3471!K3471_TimeInsert)
    If IsdbNull(rs3471!K3471_TimeUpdate) = False Then D3471.TimeUpdate = Trim$(rs3471!K3471_TimeUpdate)
    If IsdbNull(rs3471!K3471_DateUpdate) = False Then D3471.DateUpdate = Trim$(rs3471!K3471_DateUpdate)
    If IsdbNull(rs3471!K3471_DateInsert) = False Then D3471.DateInsert = Trim$(rs3471!K3471_DateInsert)
    If IsdbNull(rs3471!K3471_InchargeInsert) = False Then D3471.InchargeInsert = Trim$(rs3471!K3471_InchargeInsert)
    If IsdbNull(rs3471!K3471_InchargeUpdate) = False Then D3471.InchargeUpdate = Trim$(rs3471!K3471_InchargeUpdate)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K3471_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K3471_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z3471 As T3471_AREA, LIQUIDNO AS String, LIQUIDSEQ AS String) as Boolean

K3471_MOVE = False

Try
    If READ_PFK3471(LIQUIDNO, LIQUIDSEQ) = True Then
                z3471 = D3471
		K3471_MOVE = True
		else
	z3471 = nothing
     End If

     If  getColumnIndex(spr,"LiquidNo") > -1 then z3471.LiquidNo = getDataM(spr, getColumnIndex(spr,"LiquidNo"), xRow)
     If  getColumnIndex(spr,"LiquidSeq") > -1 then z3471.LiquidSeq = getDataM(spr, getColumnIndex(spr,"LiquidSeq"), xRow)
     If  getColumnIndex(spr,"ShoesCode") > -1 then z3471.ShoesCode = getDataM(spr, getColumnIndex(spr,"ShoesCode"), xRow)
     If  getColumnIndex(spr,"YearLiquidation") > -1 then z3471.YearLiquidation = getDataM(spr, getColumnIndex(spr,"YearLiquidation"), xRow)
     If  getColumnIndex(spr,"DateDlr") > -1 then z3471.DateDlr = getDataM(spr, getColumnIndex(spr,"DateDlr"), xRow)
     If  getColumnIndex(spr,"SOTK") > -1 then z3471.SOTK = Cdecp(getDataM(spr, getColumnIndex(spr,"SOTK"), xRow))
     If  getColumnIndex(spr,"TONGTGKB") > -1 then z3471.TONGTGKB = Cdecp(getDataM(spr, getColumnIndex(spr,"TONGTGKB"), xRow))
     If  getColumnIndex(spr,"InvoiceNoMaster") > -1 then z3471.InvoiceNoMaster = getDataM(spr, getColumnIndex(spr,"InvoiceNoMaster"), xRow)
     If  getColumnIndex(spr,"InvoiceNo") > -1 then z3471.InvoiceNo = getDataM(spr, getColumnIndex(spr,"InvoiceNo"), xRow)
     If  getColumnIndex(spr,"InvoiceSeq") > -1 then z3471.InvoiceSeq = getDataM(spr, getColumnIndex(spr,"InvoiceSeq"), xRow)
     If  getColumnIndex(spr,"SONo") > -1 then z3471.SONo = getDataM(spr, getColumnIndex(spr,"SONo"), xRow)
     If  getColumnIndex(spr,"BookingNo") > -1 then z3471.BookingNo = getDataM(spr, getColumnIndex(spr,"BookingNo"), xRow)
     If  getColumnIndex(spr,"LoadingNo") > -1 then z3471.LoadingNo = getDataM(spr, getColumnIndex(spr,"LoadingNo"), xRow)
     If  getColumnIndex(spr,"VesselName") > -1 then z3471.VesselName = getDataM(spr, getColumnIndex(spr,"VesselName"), xRow)
     If  getColumnIndex(spr,"TradingName") > -1 then z3471.TradingName = getDataM(spr, getColumnIndex(spr,"TradingName"), xRow)
     If  getColumnIndex(spr,"TradingCode") > -1 then z3471.TradingCode = getDataM(spr, getColumnIndex(spr,"TradingCode"), xRow)
     If  getColumnIndex(spr,"ShipmentType") > -1 then z3471.ShipmentType = getDataM(spr, getColumnIndex(spr,"ShipmentType"), xRow)
     If  getColumnIndex(spr,"DateBL") > -1 then z3471.DateBL = getDataM(spr, getColumnIndex(spr,"DateBL"), xRow)
     If  getColumnIndex(spr,"BLNo") > -1 then z3471.BLNo = getDataM(spr, getColumnIndex(spr,"BLNo"), xRow)
     If  getColumnIndex(spr,"ContainerNo") > -1 then z3471.ContainerNo = getDataM(spr, getColumnIndex(spr,"ContainerNo"), xRow)
     If  getColumnIndex(spr,"seShipType") > -1 then z3471.seShipType = getDataM(spr, getColumnIndex(spr,"seShipType"), xRow)
     If  getColumnIndex(spr,"cdShipType") > -1 then z3471.cdShipType = getDataM(spr, getColumnIndex(spr,"cdShipType"), xRow)
     If  getColumnIndex(spr,"DateEXFac") > -1 then z3471.DateEXFac = getDataM(spr, getColumnIndex(spr,"DateEXFac"), xRow)
     If  getColumnIndex(spr,"DateETD") > -1 then z3471.DateETD = getDataM(spr, getColumnIndex(spr,"DateETD"), xRow)
     If  getColumnIndex(spr,"DateETA") > -1 then z3471.DateETA = getDataM(spr, getColumnIndex(spr,"DateETA"), xRow)
     If  getColumnIndex(spr,"OrderNo") > -1 then z3471.OrderNo = getDataM(spr, getColumnIndex(spr,"OrderNo"), xRow)
     If  getColumnIndex(spr,"OrderNoSeq") > -1 then z3471.OrderNoSeq = getDataM(spr, getColumnIndex(spr,"OrderNoSeq"), xRow)
     If  getColumnIndex(spr,"LoadingCode") > -1 then z3471.LoadingCode = getDataM(spr, getColumnIndex(spr,"LoadingCode"), xRow)
     If  getColumnIndex(spr,"TransferType") > -1 then z3471.TransferType = getDataM(spr, getColumnIndex(spr,"TransferType"), xRow)
     If  getColumnIndex(spr,"ChkDeclare") > -1 then z3471.ChkDeclare = getDataM(spr, getColumnIndex(spr,"ChkDeclare"), xRow)
     If  getColumnIndex(spr,"DateDeclare") > -1 then z3471.DateDeclare = getDataM(spr, getColumnIndex(spr,"DateDeclare"), xRow)
     If  getColumnIndex(spr,"ChkSMDocs") > -1 then z3471.ChkSMDocs = getDataM(spr, getColumnIndex(spr,"ChkSMDocs"), xRow)
     If  getColumnIndex(spr,"DateSMDocs") > -1 then z3471.DateSMDocs = getDataM(spr, getColumnIndex(spr,"DateSMDocs"), xRow)
     If  getColumnIndex(spr,"ChkLocalCharge") > -1 then z3471.ChkLocalCharge = getDataM(spr, getColumnIndex(spr,"ChkLocalCharge"), xRow)
     If  getColumnIndex(spr,"DateLocalCharge") > -1 then z3471.DateLocalCharge = getDataM(spr, getColumnIndex(spr,"DateLocalCharge"), xRow)
     If  getColumnIndex(spr,"ChkUploadDocs") > -1 then z3471.ChkUploadDocs = getDataM(spr, getColumnIndex(spr,"ChkUploadDocs"), xRow)
     If  getColumnIndex(spr,"DateUploadDocs") > -1 then z3471.DateUploadDocs = getDataM(spr, getColumnIndex(spr,"DateUploadDocs"), xRow)
     If  getColumnIndex(spr,"ChkDocsHK") > -1 then z3471.ChkDocsHK = getDataM(spr, getColumnIndex(spr,"ChkDocsHK"), xRow)
     If  getColumnIndex(spr,"DateDocsHK") > -1 then z3471.DateDocsHK = getDataM(spr, getColumnIndex(spr,"DateDocsHK"), xRow)
     If  getColumnIndex(spr,"ChkDocsBuyer") > -1 then z3471.ChkDocsBuyer = getDataM(spr, getColumnIndex(spr,"ChkDocsBuyer"), xRow)
     If  getColumnIndex(spr,"ChkReceiveHK") > -1 then z3471.ChkReceiveHK = getDataM(spr, getColumnIndex(spr,"ChkReceiveHK"), xRow)
     If  getColumnIndex(spr,"ChkPending") > -1 then z3471.ChkPending = getDataM(spr, getColumnIndex(spr,"ChkPending"), xRow)
     If  getColumnIndex(spr,"DateDocsBuyer") > -1 then z3471.DateDocsBuyer = getDataM(spr, getColumnIndex(spr,"DateDocsBuyer"), xRow)
     If  getColumnIndex(spr,"CheckLiquidation") > -1 then z3471.CheckLiquidation = getDataM(spr, getColumnIndex(spr,"CheckLiquidation"), xRow)
     If  getColumnIndex(spr,"CheckStatus") > -1 then z3471.CheckStatus = Cdecp(getDataM(spr, getColumnIndex(spr,"CheckStatus"), xRow))
     If  getColumnIndex(spr,"QtyOrder") > -1 then z3471.QtyOrder = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyOrder"), xRow))
     If  getColumnIndex(spr,"QtyOrderSample") > -1 then z3471.QtyOrderSample = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyOrderSample"), xRow))
     If  getColumnIndex(spr,"PriceOrderFOB") > -1 then z3471.PriceOrderFOB = Cdecp(getDataM(spr, getColumnIndex(spr,"PriceOrderFOB"), xRow))
     If  getColumnIndex(spr,"TotalAMTFOB") > -1 then z3471.TotalAMTFOB = Cdecp(getDataM(spr, getColumnIndex(spr,"TotalAMTFOB"), xRow))
     If  getColumnIndex(spr,"PriceOrder") > -1 then z3471.PriceOrder = Cdecp(getDataM(spr, getColumnIndex(spr,"PriceOrder"), xRow))
     If  getColumnIndex(spr,"TotalAMT") > -1 then z3471.TotalAMT = Cdecp(getDataM(spr, getColumnIndex(spr,"TotalAMT"), xRow))
     If  getColumnIndex(spr,"TotalGW") > -1 then z3471.TotalGW = Cdecp(getDataM(spr, getColumnIndex(spr,"TotalGW"), xRow))
     If  getColumnIndex(spr,"TotalNW") > -1 then z3471.TotalNW = Cdecp(getDataM(spr, getColumnIndex(spr,"TotalNW"), xRow))
     If  getColumnIndex(spr,"TotalCBM") > -1 then z3471.TotalCBM = Cdecp(getDataM(spr, getColumnIndex(spr,"TotalCBM"), xRow))
     If  getColumnIndex(spr,"TotalQty") > -1 then z3471.TotalQty = Cdecp(getDataM(spr, getColumnIndex(spr,"TotalQty"), xRow))
     If  getColumnIndex(spr,"TotalCnt") > -1 then z3471.TotalCnt = Cdecp(getDataM(spr, getColumnIndex(spr,"TotalCnt"), xRow))
     If  getColumnIndex(spr,"ContName1") > -1 then z3471.ContName1 = getDataM(spr, getColumnIndex(spr,"ContName1"), xRow)
     If  getColumnIndex(spr,"ContName2") > -1 then z3471.ContName2 = getDataM(spr, getColumnIndex(spr,"ContName2"), xRow)
     If  getColumnIndex(spr,"ContName3") > -1 then z3471.ContName3 = getDataM(spr, getColumnIndex(spr,"ContName3"), xRow)
     If  getColumnIndex(spr,"ContName4") > -1 then z3471.ContName4 = getDataM(spr, getColumnIndex(spr,"ContName4"), xRow)
     If  getColumnIndex(spr,"ContName5") > -1 then z3471.ContName5 = getDataM(spr, getColumnIndex(spr,"ContName5"), xRow)
     If  getColumnIndex(spr,"ContName6") > -1 then z3471.ContName6 = getDataM(spr, getColumnIndex(spr,"ContName6"), xRow)
     If  getColumnIndex(spr,"ContName7") > -1 then z3471.ContName7 = getDataM(spr, getColumnIndex(spr,"ContName7"), xRow)
     If  getColumnIndex(spr,"ContName8") > -1 then z3471.ContName8 = getDataM(spr, getColumnIndex(spr,"ContName8"), xRow)
     If  getColumnIndex(spr,"ContName9") > -1 then z3471.ContName9 = getDataM(spr, getColumnIndex(spr,"ContName9"), xRow)
     If  getColumnIndex(spr,"ContName10") > -1 then z3471.ContName10 = getDataM(spr, getColumnIndex(spr,"ContName10"), xRow)
     If  getColumnIndex(spr,"QtyPL1") > -1 then z3471.QtyPL1 = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyPL1"), xRow))
     If  getColumnIndex(spr,"QtyPL2") > -1 then z3471.QtyPL2 = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyPL2"), xRow))
     If  getColumnIndex(spr,"QtyPL3") > -1 then z3471.QtyPL3 = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyPL3"), xRow))
     If  getColumnIndex(spr,"QtyPL4") > -1 then z3471.QtyPL4 = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyPL4"), xRow))
     If  getColumnIndex(spr,"QtyPL5") > -1 then z3471.QtyPL5 = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyPL5"), xRow))
     If  getColumnIndex(spr,"QtyPL6") > -1 then z3471.QtyPL6 = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyPL6"), xRow))
     If  getColumnIndex(spr,"QtyPL7") > -1 then z3471.QtyPL7 = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyPL7"), xRow))
     If  getColumnIndex(spr,"QtyPL8") > -1 then z3471.QtyPL8 = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyPL8"), xRow))
     If  getColumnIndex(spr,"QtyPL9") > -1 then z3471.QtyPL9 = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyPL9"), xRow))
     If  getColumnIndex(spr,"QtyPL10") > -1 then z3471.QtyPL10 = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyPL10"), xRow))
     If  getColumnIndex(spr,"seSite") > -1 then z3471.seSite = getDataM(spr, getColumnIndex(spr,"seSite"), xRow)
     If  getColumnIndex(spr,"cdSite") > -1 then z3471.cdSite = getDataM(spr, getColumnIndex(spr,"cdSite"), xRow)
     If  getColumnIndex(spr,"Remark") > -1 then z3471.Remark = getDataM(spr, getColumnIndex(spr,"Remark"), xRow)
     If  getColumnIndex(spr,"TimeInsert") > -1 then z3471.TimeInsert = getDataM(spr, getColumnIndex(spr,"TimeInsert"), xRow)
     If  getColumnIndex(spr,"TimeUpdate") > -1 then z3471.TimeUpdate = getDataM(spr, getColumnIndex(spr,"TimeUpdate"), xRow)
     If  getColumnIndex(spr,"DateUpdate") > -1 then z3471.DateUpdate = getDataM(spr, getColumnIndex(spr,"DateUpdate"), xRow)
     If  getColumnIndex(spr,"DateInsert") > -1 then z3471.DateInsert = getDataM(spr, getColumnIndex(spr,"DateInsert"), xRow)
     If  getColumnIndex(spr,"InchargeInsert") > -1 then z3471.InchargeInsert = getDataM(spr, getColumnIndex(spr,"InchargeInsert"), xRow)
     If  getColumnIndex(spr,"InchargeUpdate") > -1 then z3471.InchargeUpdate = getDataM(spr, getColumnIndex(spr,"InchargeUpdate"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K3471_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K3471_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z3471 As T3471_AREA,CheckClear as Boolean,LIQUIDNO AS String, LIQUIDSEQ AS String) as Boolean

K3471_MOVE = False

Try
    If READ_PFK3471(LIQUIDNO, LIQUIDSEQ) = True Then
                z3471 = D3471
		K3471_MOVE = True
		else
	If CheckClear  = True then z3471 = nothing
     End If

     If  getColumnIndex(spr,"LiquidNo") > -1 then z3471.LiquidNo = getDataM(spr, getColumnIndex(spr,"LiquidNo"), xRow)
     If  getColumnIndex(spr,"LiquidSeq") > -1 then z3471.LiquidSeq = getDataM(spr, getColumnIndex(spr,"LiquidSeq"), xRow)
     If  getColumnIndex(spr,"ShoesCode") > -1 then z3471.ShoesCode = getDataM(spr, getColumnIndex(spr,"ShoesCode"), xRow)
     If  getColumnIndex(spr,"YearLiquidation") > -1 then z3471.YearLiquidation = getDataM(spr, getColumnIndex(spr,"YearLiquidation"), xRow)
     If  getColumnIndex(spr,"DateDlr") > -1 then z3471.DateDlr = getDataM(spr, getColumnIndex(spr,"DateDlr"), xRow)
     If  getColumnIndex(spr,"SOTK") > -1 then z3471.SOTK = Cdecp(getDataM(spr, getColumnIndex(spr,"SOTK"), xRow))
     If  getColumnIndex(spr,"TONGTGKB") > -1 then z3471.TONGTGKB = Cdecp(getDataM(spr, getColumnIndex(spr,"TONGTGKB"), xRow))
     If  getColumnIndex(spr,"InvoiceNoMaster") > -1 then z3471.InvoiceNoMaster = getDataM(spr, getColumnIndex(spr,"InvoiceNoMaster"), xRow)
     If  getColumnIndex(spr,"InvoiceNo") > -1 then z3471.InvoiceNo = getDataM(spr, getColumnIndex(spr,"InvoiceNo"), xRow)
     If  getColumnIndex(spr,"InvoiceSeq") > -1 then z3471.InvoiceSeq = getDataM(spr, getColumnIndex(spr,"InvoiceSeq"), xRow)
     If  getColumnIndex(spr,"SONo") > -1 then z3471.SONo = getDataM(spr, getColumnIndex(spr,"SONo"), xRow)
     If  getColumnIndex(spr,"BookingNo") > -1 then z3471.BookingNo = getDataM(spr, getColumnIndex(spr,"BookingNo"), xRow)
     If  getColumnIndex(spr,"LoadingNo") > -1 then z3471.LoadingNo = getDataM(spr, getColumnIndex(spr,"LoadingNo"), xRow)
     If  getColumnIndex(spr,"VesselName") > -1 then z3471.VesselName = getDataM(spr, getColumnIndex(spr,"VesselName"), xRow)
     If  getColumnIndex(spr,"TradingName") > -1 then z3471.TradingName = getDataM(spr, getColumnIndex(spr,"TradingName"), xRow)
     If  getColumnIndex(spr,"TradingCode") > -1 then z3471.TradingCode = getDataM(spr, getColumnIndex(spr,"TradingCode"), xRow)
     If  getColumnIndex(spr,"ShipmentType") > -1 then z3471.ShipmentType = getDataM(spr, getColumnIndex(spr,"ShipmentType"), xRow)
     If  getColumnIndex(spr,"DateBL") > -1 then z3471.DateBL = getDataM(spr, getColumnIndex(spr,"DateBL"), xRow)
     If  getColumnIndex(spr,"BLNo") > -1 then z3471.BLNo = getDataM(spr, getColumnIndex(spr,"BLNo"), xRow)
     If  getColumnIndex(spr,"ContainerNo") > -1 then z3471.ContainerNo = getDataM(spr, getColumnIndex(spr,"ContainerNo"), xRow)
     If  getColumnIndex(spr,"seShipType") > -1 then z3471.seShipType = getDataM(spr, getColumnIndex(spr,"seShipType"), xRow)
     If  getColumnIndex(spr,"cdShipType") > -1 then z3471.cdShipType = getDataM(spr, getColumnIndex(spr,"cdShipType"), xRow)
     If  getColumnIndex(spr,"DateEXFac") > -1 then z3471.DateEXFac = getDataM(spr, getColumnIndex(spr,"DateEXFac"), xRow)
     If  getColumnIndex(spr,"DateETD") > -1 then z3471.DateETD = getDataM(spr, getColumnIndex(spr,"DateETD"), xRow)
     If  getColumnIndex(spr,"DateETA") > -1 then z3471.DateETA = getDataM(spr, getColumnIndex(spr,"DateETA"), xRow)
     If  getColumnIndex(spr,"OrderNo") > -1 then z3471.OrderNo = getDataM(spr, getColumnIndex(spr,"OrderNo"), xRow)
     If  getColumnIndex(spr,"OrderNoSeq") > -1 then z3471.OrderNoSeq = getDataM(spr, getColumnIndex(spr,"OrderNoSeq"), xRow)
     If  getColumnIndex(spr,"LoadingCode") > -1 then z3471.LoadingCode = getDataM(spr, getColumnIndex(spr,"LoadingCode"), xRow)
     If  getColumnIndex(spr,"TransferType") > -1 then z3471.TransferType = getDataM(spr, getColumnIndex(spr,"TransferType"), xRow)
     If  getColumnIndex(spr,"ChkDeclare") > -1 then z3471.ChkDeclare = getDataM(spr, getColumnIndex(spr,"ChkDeclare"), xRow)
     If  getColumnIndex(spr,"DateDeclare") > -1 then z3471.DateDeclare = getDataM(spr, getColumnIndex(spr,"DateDeclare"), xRow)
     If  getColumnIndex(spr,"ChkSMDocs") > -1 then z3471.ChkSMDocs = getDataM(spr, getColumnIndex(spr,"ChkSMDocs"), xRow)
     If  getColumnIndex(spr,"DateSMDocs") > -1 then z3471.DateSMDocs = getDataM(spr, getColumnIndex(spr,"DateSMDocs"), xRow)
     If  getColumnIndex(spr,"ChkLocalCharge") > -1 then z3471.ChkLocalCharge = getDataM(spr, getColumnIndex(spr,"ChkLocalCharge"), xRow)
     If  getColumnIndex(spr,"DateLocalCharge") > -1 then z3471.DateLocalCharge = getDataM(spr, getColumnIndex(spr,"DateLocalCharge"), xRow)
     If  getColumnIndex(spr,"ChkUploadDocs") > -1 then z3471.ChkUploadDocs = getDataM(spr, getColumnIndex(spr,"ChkUploadDocs"), xRow)
     If  getColumnIndex(spr,"DateUploadDocs") > -1 then z3471.DateUploadDocs = getDataM(spr, getColumnIndex(spr,"DateUploadDocs"), xRow)
     If  getColumnIndex(spr,"ChkDocsHK") > -1 then z3471.ChkDocsHK = getDataM(spr, getColumnIndex(spr,"ChkDocsHK"), xRow)
     If  getColumnIndex(spr,"DateDocsHK") > -1 then z3471.DateDocsHK = getDataM(spr, getColumnIndex(spr,"DateDocsHK"), xRow)
     If  getColumnIndex(spr,"ChkDocsBuyer") > -1 then z3471.ChkDocsBuyer = getDataM(spr, getColumnIndex(spr,"ChkDocsBuyer"), xRow)
     If  getColumnIndex(spr,"ChkReceiveHK") > -1 then z3471.ChkReceiveHK = getDataM(spr, getColumnIndex(spr,"ChkReceiveHK"), xRow)
     If  getColumnIndex(spr,"ChkPending") > -1 then z3471.ChkPending = getDataM(spr, getColumnIndex(spr,"ChkPending"), xRow)
     If  getColumnIndex(spr,"DateDocsBuyer") > -1 then z3471.DateDocsBuyer = getDataM(spr, getColumnIndex(spr,"DateDocsBuyer"), xRow)
     If  getColumnIndex(spr,"CheckLiquidation") > -1 then z3471.CheckLiquidation = getDataM(spr, getColumnIndex(spr,"CheckLiquidation"), xRow)
     If  getColumnIndex(spr,"CheckStatus") > -1 then z3471.CheckStatus = Cdecp(getDataM(spr, getColumnIndex(spr,"CheckStatus"), xRow))
     If  getColumnIndex(spr,"QtyOrder") > -1 then z3471.QtyOrder = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyOrder"), xRow))
     If  getColumnIndex(spr,"QtyOrderSample") > -1 then z3471.QtyOrderSample = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyOrderSample"), xRow))
     If  getColumnIndex(spr,"PriceOrderFOB") > -1 then z3471.PriceOrderFOB = Cdecp(getDataM(spr, getColumnIndex(spr,"PriceOrderFOB"), xRow))
     If  getColumnIndex(spr,"TotalAMTFOB") > -1 then z3471.TotalAMTFOB = Cdecp(getDataM(spr, getColumnIndex(spr,"TotalAMTFOB"), xRow))
     If  getColumnIndex(spr,"PriceOrder") > -1 then z3471.PriceOrder = Cdecp(getDataM(spr, getColumnIndex(spr,"PriceOrder"), xRow))
     If  getColumnIndex(spr,"TotalAMT") > -1 then z3471.TotalAMT = Cdecp(getDataM(spr, getColumnIndex(spr,"TotalAMT"), xRow))
     If  getColumnIndex(spr,"TotalGW") > -1 then z3471.TotalGW = Cdecp(getDataM(spr, getColumnIndex(spr,"TotalGW"), xRow))
     If  getColumnIndex(spr,"TotalNW") > -1 then z3471.TotalNW = Cdecp(getDataM(spr, getColumnIndex(spr,"TotalNW"), xRow))
     If  getColumnIndex(spr,"TotalCBM") > -1 then z3471.TotalCBM = Cdecp(getDataM(spr, getColumnIndex(spr,"TotalCBM"), xRow))
     If  getColumnIndex(spr,"TotalQty") > -1 then z3471.TotalQty = Cdecp(getDataM(spr, getColumnIndex(spr,"TotalQty"), xRow))
     If  getColumnIndex(spr,"TotalCnt") > -1 then z3471.TotalCnt = Cdecp(getDataM(spr, getColumnIndex(spr,"TotalCnt"), xRow))
     If  getColumnIndex(spr,"ContName1") > -1 then z3471.ContName1 = getDataM(spr, getColumnIndex(spr,"ContName1"), xRow)
     If  getColumnIndex(spr,"ContName2") > -1 then z3471.ContName2 = getDataM(spr, getColumnIndex(spr,"ContName2"), xRow)
     If  getColumnIndex(spr,"ContName3") > -1 then z3471.ContName3 = getDataM(spr, getColumnIndex(spr,"ContName3"), xRow)
     If  getColumnIndex(spr,"ContName4") > -1 then z3471.ContName4 = getDataM(spr, getColumnIndex(spr,"ContName4"), xRow)
     If  getColumnIndex(spr,"ContName5") > -1 then z3471.ContName5 = getDataM(spr, getColumnIndex(spr,"ContName5"), xRow)
     If  getColumnIndex(spr,"ContName6") > -1 then z3471.ContName6 = getDataM(spr, getColumnIndex(spr,"ContName6"), xRow)
     If  getColumnIndex(spr,"ContName7") > -1 then z3471.ContName7 = getDataM(spr, getColumnIndex(spr,"ContName7"), xRow)
     If  getColumnIndex(spr,"ContName8") > -1 then z3471.ContName8 = getDataM(spr, getColumnIndex(spr,"ContName8"), xRow)
     If  getColumnIndex(spr,"ContName9") > -1 then z3471.ContName9 = getDataM(spr, getColumnIndex(spr,"ContName9"), xRow)
     If  getColumnIndex(spr,"ContName10") > -1 then z3471.ContName10 = getDataM(spr, getColumnIndex(spr,"ContName10"), xRow)
     If  getColumnIndex(spr,"QtyPL1") > -1 then z3471.QtyPL1 = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyPL1"), xRow))
     If  getColumnIndex(spr,"QtyPL2") > -1 then z3471.QtyPL2 = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyPL2"), xRow))
     If  getColumnIndex(spr,"QtyPL3") > -1 then z3471.QtyPL3 = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyPL3"), xRow))
     If  getColumnIndex(spr,"QtyPL4") > -1 then z3471.QtyPL4 = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyPL4"), xRow))
     If  getColumnIndex(spr,"QtyPL5") > -1 then z3471.QtyPL5 = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyPL5"), xRow))
     If  getColumnIndex(spr,"QtyPL6") > -1 then z3471.QtyPL6 = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyPL6"), xRow))
     If  getColumnIndex(spr,"QtyPL7") > -1 then z3471.QtyPL7 = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyPL7"), xRow))
     If  getColumnIndex(spr,"QtyPL8") > -1 then z3471.QtyPL8 = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyPL8"), xRow))
     If  getColumnIndex(spr,"QtyPL9") > -1 then z3471.QtyPL9 = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyPL9"), xRow))
     If  getColumnIndex(spr,"QtyPL10") > -1 then z3471.QtyPL10 = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyPL10"), xRow))
     If  getColumnIndex(spr,"seSite") > -1 then z3471.seSite = getDataM(spr, getColumnIndex(spr,"seSite"), xRow)
     If  getColumnIndex(spr,"cdSite") > -1 then z3471.cdSite = getDataM(spr, getColumnIndex(spr,"cdSite"), xRow)
     If  getColumnIndex(spr,"Remark") > -1 then z3471.Remark = getDataM(spr, getColumnIndex(spr,"Remark"), xRow)
     If  getColumnIndex(spr,"TimeInsert") > -1 then z3471.TimeInsert = getDataM(spr, getColumnIndex(spr,"TimeInsert"), xRow)
     If  getColumnIndex(spr,"TimeUpdate") > -1 then z3471.TimeUpdate = getDataM(spr, getColumnIndex(spr,"TimeUpdate"), xRow)
     If  getColumnIndex(spr,"DateUpdate") > -1 then z3471.DateUpdate = getDataM(spr, getColumnIndex(spr,"DateUpdate"), xRow)
     If  getColumnIndex(spr,"DateInsert") > -1 then z3471.DateInsert = getDataM(spr, getColumnIndex(spr,"DateInsert"), xRow)
     If  getColumnIndex(spr,"InchargeInsert") > -1 then z3471.InchargeInsert = getDataM(spr, getColumnIndex(spr,"InchargeInsert"), xRow)
     If  getColumnIndex(spr,"InchargeUpdate") > -1 then z3471.InchargeUpdate = getDataM(spr, getColumnIndex(spr,"InchargeUpdate"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K3471_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K3471_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z3471 As T3471_AREA, Job as String, LIQUIDNO AS String, LIQUIDSEQ AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K3471_MOVE = False

Try
    If READ_PFK3471(LIQUIDNO, LIQUIDSEQ) = True Then
                z3471 = D3471
		K3471_MOVE = True
		else
	z3471 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3471")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "LIQUIDNO":z3471.LiquidNo = Children(i).Code
   Case "LIQUIDSEQ":z3471.LiquidSeq = Children(i).Code
   Case "SHOESCODE":z3471.ShoesCode = Children(i).Code
   Case "YEARLIQUIDATION":z3471.YearLiquidation = Children(i).Code
   Case "DATEDLR":z3471.DateDlr = Children(i).Code
   Case "SOTK":z3471.SOTK = Children(i).Code
   Case "TONGTGKB":z3471.TONGTGKB = Children(i).Code
   Case "INVOICENOMASTER":z3471.InvoiceNoMaster = Children(i).Code
   Case "INVOICENO":z3471.InvoiceNo = Children(i).Code
   Case "INVOICESEQ":z3471.InvoiceSeq = Children(i).Code
   Case "SONO":z3471.SONo = Children(i).Code
   Case "BOOKINGNO":z3471.BookingNo = Children(i).Code
   Case "LOADINGNO":z3471.LoadingNo = Children(i).Code
   Case "VESSELNAME":z3471.VesselName = Children(i).Code
   Case "TRADINGNAME":z3471.TradingName = Children(i).Code
   Case "TRADINGCODE":z3471.TradingCode = Children(i).Code
   Case "SHIPMENTTYPE":z3471.ShipmentType = Children(i).Code
   Case "DATEBL":z3471.DateBL = Children(i).Code
   Case "BLNO":z3471.BLNo = Children(i).Code
   Case "CONTAINERNO":z3471.ContainerNo = Children(i).Code
   Case "SESHIPTYPE":z3471.seShipType = Children(i).Code
   Case "CDSHIPTYPE":z3471.cdShipType = Children(i).Code
   Case "DATEEXFAC":z3471.DateEXFac = Children(i).Code
   Case "DATEETD":z3471.DateETD = Children(i).Code
   Case "DATEETA":z3471.DateETA = Children(i).Code
   Case "ORDERNO":z3471.OrderNo = Children(i).Code
   Case "ORDERNOSEQ":z3471.OrderNoSeq = Children(i).Code
   Case "LOADINGCODE":z3471.LoadingCode = Children(i).Code
   Case "TRANSFERTYPE":z3471.TransferType = Children(i).Code
   Case "CHKDECLARE":z3471.ChkDeclare = Children(i).Code
   Case "DATEDECLARE":z3471.DateDeclare = Children(i).Code
   Case "CHKSMDOCS":z3471.ChkSMDocs = Children(i).Code
   Case "DATESMDOCS":z3471.DateSMDocs = Children(i).Code
   Case "CHKLOCALCHARGE":z3471.ChkLocalCharge = Children(i).Code
   Case "DATELOCALCHARGE":z3471.DateLocalCharge = Children(i).Code
   Case "CHKUPLOADDOCS":z3471.ChkUploadDocs = Children(i).Code
   Case "DATEUPLOADDOCS":z3471.DateUploadDocs = Children(i).Code
   Case "CHKDOCSHK":z3471.ChkDocsHK = Children(i).Code
   Case "DATEDOCSHK":z3471.DateDocsHK = Children(i).Code
   Case "CHKDOCSBUYER":z3471.ChkDocsBuyer = Children(i).Code
   Case "CHKRECEIVEHK":z3471.ChkReceiveHK = Children(i).Code
   Case "CHKPENDING":z3471.ChkPending = Children(i).Code
   Case "DATEDOCSBUYER":z3471.DateDocsBuyer = Children(i).Code
   Case "CHECKLIQUIDATION":z3471.CheckLiquidation = Children(i).Code
   Case "CHECKSTATUS":z3471.CheckStatus = Children(i).Code
   Case "QTYORDER":z3471.QtyOrder = Children(i).Code
   Case "QTYORDERSAMPLE":z3471.QtyOrderSample = Children(i).Code
   Case "PRICEORDERFOB":z3471.PriceOrderFOB = Children(i).Code
   Case "TOTALAMTFOB":z3471.TotalAMTFOB = Children(i).Code
   Case "PRICEORDER":z3471.PriceOrder = Children(i).Code
   Case "TOTALAMT":z3471.TotalAMT = Children(i).Code
   Case "TOTALGW":z3471.TotalGW = Children(i).Code
   Case "TOTALNW":z3471.TotalNW = Children(i).Code
   Case "TOTALCBM":z3471.TotalCBM = Children(i).Code
   Case "TOTALQTY":z3471.TotalQty = Children(i).Code
   Case "TOTALCNT":z3471.TotalCnt = Children(i).Code
   Case "CONTNAME1":z3471.ContName1 = Children(i).Code
   Case "CONTNAME2":z3471.ContName2 = Children(i).Code
   Case "CONTNAME3":z3471.ContName3 = Children(i).Code
   Case "CONTNAME4":z3471.ContName4 = Children(i).Code
   Case "CONTNAME5":z3471.ContName5 = Children(i).Code
   Case "CONTNAME6":z3471.ContName6 = Children(i).Code
   Case "CONTNAME7":z3471.ContName7 = Children(i).Code
   Case "CONTNAME8":z3471.ContName8 = Children(i).Code
   Case "CONTNAME9":z3471.ContName9 = Children(i).Code
   Case "CONTNAME10":z3471.ContName10 = Children(i).Code
   Case "QTYPL1":z3471.QtyPL1 = Children(i).Code
   Case "QTYPL2":z3471.QtyPL2 = Children(i).Code
   Case "QTYPL3":z3471.QtyPL3 = Children(i).Code
   Case "QTYPL4":z3471.QtyPL4 = Children(i).Code
   Case "QTYPL5":z3471.QtyPL5 = Children(i).Code
   Case "QTYPL6":z3471.QtyPL6 = Children(i).Code
   Case "QTYPL7":z3471.QtyPL7 = Children(i).Code
   Case "QTYPL8":z3471.QtyPL8 = Children(i).Code
   Case "QTYPL9":z3471.QtyPL9 = Children(i).Code
   Case "QTYPL10":z3471.QtyPL10 = Children(i).Code
   Case "SESITE":z3471.seSite = Children(i).Code
   Case "CDSITE":z3471.cdSite = Children(i).Code
   Case "REMARK":z3471.Remark = Children(i).Code
   Case "TIMEINSERT":z3471.TimeInsert = Children(i).Code
   Case "TIMEUPDATE":z3471.TimeUpdate = Children(i).Code
   Case "DATEUPDATE":z3471.DateUpdate = Children(i).Code
   Case "DATEINSERT":z3471.DateInsert = Children(i).Code
   Case "INCHARGEINSERT":z3471.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z3471.InchargeUpdate = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "LIQUIDNO":z3471.LiquidNo = Children(i).Data
   Case "LIQUIDSEQ":z3471.LiquidSeq = Children(i).Data
   Case "SHOESCODE":z3471.ShoesCode = Children(i).Data
   Case "YEARLIQUIDATION":z3471.YearLiquidation = Children(i).Data
   Case "DATEDLR":z3471.DateDlr = Children(i).Data
   Case "SOTK":z3471.SOTK = Cdecp(Children(i).Data)
   Case "TONGTGKB":z3471.TONGTGKB = Cdecp(Children(i).Data)
   Case "INVOICENOMASTER":z3471.InvoiceNoMaster = Children(i).Data
   Case "INVOICENO":z3471.InvoiceNo = Children(i).Data
   Case "INVOICESEQ":z3471.InvoiceSeq = Children(i).Data
   Case "SONO":z3471.SONo = Children(i).Data
   Case "BOOKINGNO":z3471.BookingNo = Children(i).Data
   Case "LOADINGNO":z3471.LoadingNo = Children(i).Data
   Case "VESSELNAME":z3471.VesselName = Children(i).Data
   Case "TRADINGNAME":z3471.TradingName = Children(i).Data
   Case "TRADINGCODE":z3471.TradingCode = Children(i).Data
   Case "SHIPMENTTYPE":z3471.ShipmentType = Children(i).Data
   Case "DATEBL":z3471.DateBL = Children(i).Data
   Case "BLNO":z3471.BLNo = Children(i).Data
   Case "CONTAINERNO":z3471.ContainerNo = Children(i).Data
   Case "SESHIPTYPE":z3471.seShipType = Children(i).Data
   Case "CDSHIPTYPE":z3471.cdShipType = Children(i).Data
   Case "DATEEXFAC":z3471.DateEXFac = Children(i).Data
   Case "DATEETD":z3471.DateETD = Children(i).Data
   Case "DATEETA":z3471.DateETA = Children(i).Data
   Case "ORDERNO":z3471.OrderNo = Children(i).Data
   Case "ORDERNOSEQ":z3471.OrderNoSeq = Children(i).Data
   Case "LOADINGCODE":z3471.LoadingCode = Children(i).Data
   Case "TRANSFERTYPE":z3471.TransferType = Children(i).Data
   Case "CHKDECLARE":z3471.ChkDeclare = Children(i).Data
   Case "DATEDECLARE":z3471.DateDeclare = Children(i).Data
   Case "CHKSMDOCS":z3471.ChkSMDocs = Children(i).Data
   Case "DATESMDOCS":z3471.DateSMDocs = Children(i).Data
   Case "CHKLOCALCHARGE":z3471.ChkLocalCharge = Children(i).Data
   Case "DATELOCALCHARGE":z3471.DateLocalCharge = Children(i).Data
   Case "CHKUPLOADDOCS":z3471.ChkUploadDocs = Children(i).Data
   Case "DATEUPLOADDOCS":z3471.DateUploadDocs = Children(i).Data
   Case "CHKDOCSHK":z3471.ChkDocsHK = Children(i).Data
   Case "DATEDOCSHK":z3471.DateDocsHK = Children(i).Data
   Case "CHKDOCSBUYER":z3471.ChkDocsBuyer = Children(i).Data
   Case "CHKRECEIVEHK":z3471.ChkReceiveHK = Children(i).Data
   Case "CHKPENDING":z3471.ChkPending = Children(i).Data
   Case "DATEDOCSBUYER":z3471.DateDocsBuyer = Children(i).Data
   Case "CHECKLIQUIDATION":z3471.CheckLiquidation = Children(i).Data
   Case "CHECKSTATUS":z3471.CheckStatus = Cdecp(Children(i).Data)
   Case "QTYORDER":z3471.QtyOrder = Cdecp(Children(i).Data)
   Case "QTYORDERSAMPLE":z3471.QtyOrderSample = Cdecp(Children(i).Data)
   Case "PRICEORDERFOB":z3471.PriceOrderFOB = Cdecp(Children(i).Data)
   Case "TOTALAMTFOB":z3471.TotalAMTFOB = Cdecp(Children(i).Data)
   Case "PRICEORDER":z3471.PriceOrder = Cdecp(Children(i).Data)
   Case "TOTALAMT":z3471.TotalAMT = Cdecp(Children(i).Data)
   Case "TOTALGW":z3471.TotalGW = Cdecp(Children(i).Data)
   Case "TOTALNW":z3471.TotalNW = Cdecp(Children(i).Data)
   Case "TOTALCBM":z3471.TotalCBM = Cdecp(Children(i).Data)
   Case "TOTALQTY":z3471.TotalQty = Cdecp(Children(i).Data)
   Case "TOTALCNT":z3471.TotalCnt = Cdecp(Children(i).Data)
   Case "CONTNAME1":z3471.ContName1 = Children(i).Data
   Case "CONTNAME2":z3471.ContName2 = Children(i).Data
   Case "CONTNAME3":z3471.ContName3 = Children(i).Data
   Case "CONTNAME4":z3471.ContName4 = Children(i).Data
   Case "CONTNAME5":z3471.ContName5 = Children(i).Data
   Case "CONTNAME6":z3471.ContName6 = Children(i).Data
   Case "CONTNAME7":z3471.ContName7 = Children(i).Data
   Case "CONTNAME8":z3471.ContName8 = Children(i).Data
   Case "CONTNAME9":z3471.ContName9 = Children(i).Data
   Case "CONTNAME10":z3471.ContName10 = Children(i).Data
   Case "QTYPL1":z3471.QtyPL1 = Cdecp(Children(i).Data)
   Case "QTYPL2":z3471.QtyPL2 = Cdecp(Children(i).Data)
   Case "QTYPL3":z3471.QtyPL3 = Cdecp(Children(i).Data)
   Case "QTYPL4":z3471.QtyPL4 = Cdecp(Children(i).Data)
   Case "QTYPL5":z3471.QtyPL5 = Cdecp(Children(i).Data)
   Case "QTYPL6":z3471.QtyPL6 = Cdecp(Children(i).Data)
   Case "QTYPL7":z3471.QtyPL7 = Cdecp(Children(i).Data)
   Case "QTYPL8":z3471.QtyPL8 = Cdecp(Children(i).Data)
   Case "QTYPL9":z3471.QtyPL9 = Cdecp(Children(i).Data)
   Case "QTYPL10":z3471.QtyPL10 = Cdecp(Children(i).Data)
   Case "SESITE":z3471.seSite = Children(i).Data
   Case "CDSITE":z3471.cdSite = Children(i).Data
   Case "REMARK":z3471.Remark = Children(i).Data
   Case "TIMEINSERT":z3471.TimeInsert = Children(i).Data
   Case "TIMEUPDATE":z3471.TimeUpdate = Children(i).Data
   Case "DATEUPDATE":z3471.DateUpdate = Children(i).Data
   Case "DATEINSERT":z3471.DateInsert = Children(i).Data
   Case "INCHARGEINSERT":z3471.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z3471.InchargeUpdate = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K3471_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K3471_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z3471 As T3471_AREA, Job as String, CheckClear as Boolean, LIQUIDNO AS String, LIQUIDSEQ AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K3471_MOVE = False

Try
    If READ_PFK3471(LIQUIDNO, LIQUIDSEQ) = True Then
                z3471 = D3471
		K3471_MOVE = True
		else
	If CheckClear  = True then z3471 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3471")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "LIQUIDNO":z3471.LiquidNo = Children(i).Code
   Case "LIQUIDSEQ":z3471.LiquidSeq = Children(i).Code
   Case "SHOESCODE":z3471.ShoesCode = Children(i).Code
   Case "YEARLIQUIDATION":z3471.YearLiquidation = Children(i).Code
   Case "DATEDLR":z3471.DateDlr = Children(i).Code
   Case "SOTK":z3471.SOTK = Children(i).Code
   Case "TONGTGKB":z3471.TONGTGKB = Children(i).Code
   Case "INVOICENOMASTER":z3471.InvoiceNoMaster = Children(i).Code
   Case "INVOICENO":z3471.InvoiceNo = Children(i).Code
   Case "INVOICESEQ":z3471.InvoiceSeq = Children(i).Code
   Case "SONO":z3471.SONo = Children(i).Code
   Case "BOOKINGNO":z3471.BookingNo = Children(i).Code
   Case "LOADINGNO":z3471.LoadingNo = Children(i).Code
   Case "VESSELNAME":z3471.VesselName = Children(i).Code
   Case "TRADINGNAME":z3471.TradingName = Children(i).Code
   Case "TRADINGCODE":z3471.TradingCode = Children(i).Code
   Case "SHIPMENTTYPE":z3471.ShipmentType = Children(i).Code
   Case "DATEBL":z3471.DateBL = Children(i).Code
   Case "BLNO":z3471.BLNo = Children(i).Code
   Case "CONTAINERNO":z3471.ContainerNo = Children(i).Code
   Case "SESHIPTYPE":z3471.seShipType = Children(i).Code
   Case "CDSHIPTYPE":z3471.cdShipType = Children(i).Code
   Case "DATEEXFAC":z3471.DateEXFac = Children(i).Code
   Case "DATEETD":z3471.DateETD = Children(i).Code
   Case "DATEETA":z3471.DateETA = Children(i).Code
   Case "ORDERNO":z3471.OrderNo = Children(i).Code
   Case "ORDERNOSEQ":z3471.OrderNoSeq = Children(i).Code
   Case "LOADINGCODE":z3471.LoadingCode = Children(i).Code
   Case "TRANSFERTYPE":z3471.TransferType = Children(i).Code
   Case "CHKDECLARE":z3471.ChkDeclare = Children(i).Code
   Case "DATEDECLARE":z3471.DateDeclare = Children(i).Code
   Case "CHKSMDOCS":z3471.ChkSMDocs = Children(i).Code
   Case "DATESMDOCS":z3471.DateSMDocs = Children(i).Code
   Case "CHKLOCALCHARGE":z3471.ChkLocalCharge = Children(i).Code
   Case "DATELOCALCHARGE":z3471.DateLocalCharge = Children(i).Code
   Case "CHKUPLOADDOCS":z3471.ChkUploadDocs = Children(i).Code
   Case "DATEUPLOADDOCS":z3471.DateUploadDocs = Children(i).Code
   Case "CHKDOCSHK":z3471.ChkDocsHK = Children(i).Code
   Case "DATEDOCSHK":z3471.DateDocsHK = Children(i).Code
   Case "CHKDOCSBUYER":z3471.ChkDocsBuyer = Children(i).Code
   Case "CHKRECEIVEHK":z3471.ChkReceiveHK = Children(i).Code
   Case "CHKPENDING":z3471.ChkPending = Children(i).Code
   Case "DATEDOCSBUYER":z3471.DateDocsBuyer = Children(i).Code
   Case "CHECKLIQUIDATION":z3471.CheckLiquidation = Children(i).Code
   Case "CHECKSTATUS":z3471.CheckStatus = Children(i).Code
   Case "QTYORDER":z3471.QtyOrder = Children(i).Code
   Case "QTYORDERSAMPLE":z3471.QtyOrderSample = Children(i).Code
   Case "PRICEORDERFOB":z3471.PriceOrderFOB = Children(i).Code
   Case "TOTALAMTFOB":z3471.TotalAMTFOB = Children(i).Code
   Case "PRICEORDER":z3471.PriceOrder = Children(i).Code
   Case "TOTALAMT":z3471.TotalAMT = Children(i).Code
   Case "TOTALGW":z3471.TotalGW = Children(i).Code
   Case "TOTALNW":z3471.TotalNW = Children(i).Code
   Case "TOTALCBM":z3471.TotalCBM = Children(i).Code
   Case "TOTALQTY":z3471.TotalQty = Children(i).Code
   Case "TOTALCNT":z3471.TotalCnt = Children(i).Code
   Case "CONTNAME1":z3471.ContName1 = Children(i).Code
   Case "CONTNAME2":z3471.ContName2 = Children(i).Code
   Case "CONTNAME3":z3471.ContName3 = Children(i).Code
   Case "CONTNAME4":z3471.ContName4 = Children(i).Code
   Case "CONTNAME5":z3471.ContName5 = Children(i).Code
   Case "CONTNAME6":z3471.ContName6 = Children(i).Code
   Case "CONTNAME7":z3471.ContName7 = Children(i).Code
   Case "CONTNAME8":z3471.ContName8 = Children(i).Code
   Case "CONTNAME9":z3471.ContName9 = Children(i).Code
   Case "CONTNAME10":z3471.ContName10 = Children(i).Code
   Case "QTYPL1":z3471.QtyPL1 = Children(i).Code
   Case "QTYPL2":z3471.QtyPL2 = Children(i).Code
   Case "QTYPL3":z3471.QtyPL3 = Children(i).Code
   Case "QTYPL4":z3471.QtyPL4 = Children(i).Code
   Case "QTYPL5":z3471.QtyPL5 = Children(i).Code
   Case "QTYPL6":z3471.QtyPL6 = Children(i).Code
   Case "QTYPL7":z3471.QtyPL7 = Children(i).Code
   Case "QTYPL8":z3471.QtyPL8 = Children(i).Code
   Case "QTYPL9":z3471.QtyPL9 = Children(i).Code
   Case "QTYPL10":z3471.QtyPL10 = Children(i).Code
   Case "SESITE":z3471.seSite = Children(i).Code
   Case "CDSITE":z3471.cdSite = Children(i).Code
   Case "REMARK":z3471.Remark = Children(i).Code
   Case "TIMEINSERT":z3471.TimeInsert = Children(i).Code
   Case "TIMEUPDATE":z3471.TimeUpdate = Children(i).Code
   Case "DATEUPDATE":z3471.DateUpdate = Children(i).Code
   Case "DATEINSERT":z3471.DateInsert = Children(i).Code
   Case "INCHARGEINSERT":z3471.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z3471.InchargeUpdate = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "LIQUIDNO":z3471.LiquidNo = Children(i).Data
   Case "LIQUIDSEQ":z3471.LiquidSeq = Children(i).Data
   Case "SHOESCODE":z3471.ShoesCode = Children(i).Data
   Case "YEARLIQUIDATION":z3471.YearLiquidation = Children(i).Data
   Case "DATEDLR":z3471.DateDlr = Children(i).Data
   Case "SOTK":z3471.SOTK = Cdecp(Children(i).Data)
   Case "TONGTGKB":z3471.TONGTGKB = Cdecp(Children(i).Data)
   Case "INVOICENOMASTER":z3471.InvoiceNoMaster = Children(i).Data
   Case "INVOICENO":z3471.InvoiceNo = Children(i).Data
   Case "INVOICESEQ":z3471.InvoiceSeq = Children(i).Data
   Case "SONO":z3471.SONo = Children(i).Data
   Case "BOOKINGNO":z3471.BookingNo = Children(i).Data
   Case "LOADINGNO":z3471.LoadingNo = Children(i).Data
   Case "VESSELNAME":z3471.VesselName = Children(i).Data
   Case "TRADINGNAME":z3471.TradingName = Children(i).Data
   Case "TRADINGCODE":z3471.TradingCode = Children(i).Data
   Case "SHIPMENTTYPE":z3471.ShipmentType = Children(i).Data
   Case "DATEBL":z3471.DateBL = Children(i).Data
   Case "BLNO":z3471.BLNo = Children(i).Data
   Case "CONTAINERNO":z3471.ContainerNo = Children(i).Data
   Case "SESHIPTYPE":z3471.seShipType = Children(i).Data
   Case "CDSHIPTYPE":z3471.cdShipType = Children(i).Data
   Case "DATEEXFAC":z3471.DateEXFac = Children(i).Data
   Case "DATEETD":z3471.DateETD = Children(i).Data
   Case "DATEETA":z3471.DateETA = Children(i).Data
   Case "ORDERNO":z3471.OrderNo = Children(i).Data
   Case "ORDERNOSEQ":z3471.OrderNoSeq = Children(i).Data
   Case "LOADINGCODE":z3471.LoadingCode = Children(i).Data
   Case "TRANSFERTYPE":z3471.TransferType = Children(i).Data
   Case "CHKDECLARE":z3471.ChkDeclare = Children(i).Data
   Case "DATEDECLARE":z3471.DateDeclare = Children(i).Data
   Case "CHKSMDOCS":z3471.ChkSMDocs = Children(i).Data
   Case "DATESMDOCS":z3471.DateSMDocs = Children(i).Data
   Case "CHKLOCALCHARGE":z3471.ChkLocalCharge = Children(i).Data
   Case "DATELOCALCHARGE":z3471.DateLocalCharge = Children(i).Data
   Case "CHKUPLOADDOCS":z3471.ChkUploadDocs = Children(i).Data
   Case "DATEUPLOADDOCS":z3471.DateUploadDocs = Children(i).Data
   Case "CHKDOCSHK":z3471.ChkDocsHK = Children(i).Data
   Case "DATEDOCSHK":z3471.DateDocsHK = Children(i).Data
   Case "CHKDOCSBUYER":z3471.ChkDocsBuyer = Children(i).Data
   Case "CHKRECEIVEHK":z3471.ChkReceiveHK = Children(i).Data
   Case "CHKPENDING":z3471.ChkPending = Children(i).Data
   Case "DATEDOCSBUYER":z3471.DateDocsBuyer = Children(i).Data
   Case "CHECKLIQUIDATION":z3471.CheckLiquidation = Children(i).Data
   Case "CHECKSTATUS":z3471.CheckStatus = Cdecp(Children(i).Data)
   Case "QTYORDER":z3471.QtyOrder = Cdecp(Children(i).Data)
   Case "QTYORDERSAMPLE":z3471.QtyOrderSample = Cdecp(Children(i).Data)
   Case "PRICEORDERFOB":z3471.PriceOrderFOB = Cdecp(Children(i).Data)
   Case "TOTALAMTFOB":z3471.TotalAMTFOB = Cdecp(Children(i).Data)
   Case "PRICEORDER":z3471.PriceOrder = Cdecp(Children(i).Data)
   Case "TOTALAMT":z3471.TotalAMT = Cdecp(Children(i).Data)
   Case "TOTALGW":z3471.TotalGW = Cdecp(Children(i).Data)
   Case "TOTALNW":z3471.TotalNW = Cdecp(Children(i).Data)
   Case "TOTALCBM":z3471.TotalCBM = Cdecp(Children(i).Data)
   Case "TOTALQTY":z3471.TotalQty = Cdecp(Children(i).Data)
   Case "TOTALCNT":z3471.TotalCnt = Cdecp(Children(i).Data)
   Case "CONTNAME1":z3471.ContName1 = Children(i).Data
   Case "CONTNAME2":z3471.ContName2 = Children(i).Data
   Case "CONTNAME3":z3471.ContName3 = Children(i).Data
   Case "CONTNAME4":z3471.ContName4 = Children(i).Data
   Case "CONTNAME5":z3471.ContName5 = Children(i).Data
   Case "CONTNAME6":z3471.ContName6 = Children(i).Data
   Case "CONTNAME7":z3471.ContName7 = Children(i).Data
   Case "CONTNAME8":z3471.ContName8 = Children(i).Data
   Case "CONTNAME9":z3471.ContName9 = Children(i).Data
   Case "CONTNAME10":z3471.ContName10 = Children(i).Data
   Case "QTYPL1":z3471.QtyPL1 = Cdecp(Children(i).Data)
   Case "QTYPL2":z3471.QtyPL2 = Cdecp(Children(i).Data)
   Case "QTYPL3":z3471.QtyPL3 = Cdecp(Children(i).Data)
   Case "QTYPL4":z3471.QtyPL4 = Cdecp(Children(i).Data)
   Case "QTYPL5":z3471.QtyPL5 = Cdecp(Children(i).Data)
   Case "QTYPL6":z3471.QtyPL6 = Cdecp(Children(i).Data)
   Case "QTYPL7":z3471.QtyPL7 = Cdecp(Children(i).Data)
   Case "QTYPL8":z3471.QtyPL8 = Cdecp(Children(i).Data)
   Case "QTYPL9":z3471.QtyPL9 = Cdecp(Children(i).Data)
   Case "QTYPL10":z3471.QtyPL10 = Cdecp(Children(i).Data)
   Case "SESITE":z3471.seSite = Children(i).Data
   Case "CDSITE":z3471.cdSite = Children(i).Data
   Case "REMARK":z3471.Remark = Children(i).Data
   Case "TIMEINSERT":z3471.TimeInsert = Children(i).Data
   Case "TIMEUPDATE":z3471.TimeUpdate = Children(i).Data
   Case "DATEUPDATE":z3471.DateUpdate = Children(i).Data
   Case "DATEINSERT":z3471.DateInsert = Children(i).Data
   Case "INCHARGEINSERT":z3471.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z3471.InchargeUpdate = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K3471_MOVE",vbCritical)
End Try
End Function 
    

'=========================================================================================================================================================
' DATA MOVE FORM NEW AREA
'=========================================================================================================================================================
Public Sub K3471_MOVE(ByRef a3471 As T3471_AREA, ByRef b3471 As T3471_AREA) 
Try
If trim$( a3471.LiquidNo ) = "" Then b3471.LiquidNo = ""  Else b3471.LiquidNo=a3471.LiquidNo
If trim$( a3471.LiquidSeq ) = "" Then b3471.LiquidSeq = ""  Else b3471.LiquidSeq=a3471.LiquidSeq
If trim$( a3471.ShoesCode ) = "" Then b3471.ShoesCode = ""  Else b3471.ShoesCode=a3471.ShoesCode
If trim$( a3471.YearLiquidation ) = "" Then b3471.YearLiquidation = ""  Else b3471.YearLiquidation=a3471.YearLiquidation
If trim$( a3471.DateDlr ) = "" Then b3471.DateDlr = ""  Else b3471.DateDlr=a3471.DateDlr
If trim$( a3471.SOTK ) = "" Then b3471.SOTK = ""  Else b3471.SOTK=a3471.SOTK
If trim$( a3471.TONGTGKB ) = "" Then b3471.TONGTGKB = ""  Else b3471.TONGTGKB=a3471.TONGTGKB
If trim$( a3471.InvoiceNoMaster ) = "" Then b3471.InvoiceNoMaster = ""  Else b3471.InvoiceNoMaster=a3471.InvoiceNoMaster
If trim$( a3471.InvoiceNo ) = "" Then b3471.InvoiceNo = ""  Else b3471.InvoiceNo=a3471.InvoiceNo
If trim$( a3471.InvoiceSeq ) = "" Then b3471.InvoiceSeq = ""  Else b3471.InvoiceSeq=a3471.InvoiceSeq
If trim$( a3471.SONo ) = "" Then b3471.SONo = ""  Else b3471.SONo=a3471.SONo
If trim$( a3471.BookingNo ) = "" Then b3471.BookingNo = ""  Else b3471.BookingNo=a3471.BookingNo
If trim$( a3471.LoadingNo ) = "" Then b3471.LoadingNo = ""  Else b3471.LoadingNo=a3471.LoadingNo
If trim$( a3471.VesselName ) = "" Then b3471.VesselName = ""  Else b3471.VesselName=a3471.VesselName
If trim$( a3471.TradingName ) = "" Then b3471.TradingName = ""  Else b3471.TradingName=a3471.TradingName
If trim$( a3471.TradingCode ) = "" Then b3471.TradingCode = ""  Else b3471.TradingCode=a3471.TradingCode
If trim$( a3471.ShipmentType ) = "" Then b3471.ShipmentType = ""  Else b3471.ShipmentType=a3471.ShipmentType
If trim$( a3471.DateBL ) = "" Then b3471.DateBL = ""  Else b3471.DateBL=a3471.DateBL
If trim$( a3471.BLNo ) = "" Then b3471.BLNo = ""  Else b3471.BLNo=a3471.BLNo
If trim$( a3471.ContainerNo ) = "" Then b3471.ContainerNo = ""  Else b3471.ContainerNo=a3471.ContainerNo
If trim$( a3471.seShipType ) = "" Then b3471.seShipType = ""  Else b3471.seShipType=a3471.seShipType
If trim$( a3471.cdShipType ) = "" Then b3471.cdShipType = ""  Else b3471.cdShipType=a3471.cdShipType
If trim$( a3471.DateEXFac ) = "" Then b3471.DateEXFac = ""  Else b3471.DateEXFac=a3471.DateEXFac
If trim$( a3471.DateETD ) = "" Then b3471.DateETD = ""  Else b3471.DateETD=a3471.DateETD
If trim$( a3471.DateETA ) = "" Then b3471.DateETA = ""  Else b3471.DateETA=a3471.DateETA
If trim$( a3471.OrderNo ) = "" Then b3471.OrderNo = ""  Else b3471.OrderNo=a3471.OrderNo
If trim$( a3471.OrderNoSeq ) = "" Then b3471.OrderNoSeq = ""  Else b3471.OrderNoSeq=a3471.OrderNoSeq
If trim$( a3471.LoadingCode ) = "" Then b3471.LoadingCode = ""  Else b3471.LoadingCode=a3471.LoadingCode
If trim$( a3471.TransferType ) = "" Then b3471.TransferType = ""  Else b3471.TransferType=a3471.TransferType
If trim$( a3471.ChkDeclare ) = "" Then b3471.ChkDeclare = ""  Else b3471.ChkDeclare=a3471.ChkDeclare
If trim$( a3471.DateDeclare ) = "" Then b3471.DateDeclare = ""  Else b3471.DateDeclare=a3471.DateDeclare
If trim$( a3471.ChkSMDocs ) = "" Then b3471.ChkSMDocs = ""  Else b3471.ChkSMDocs=a3471.ChkSMDocs
If trim$( a3471.DateSMDocs ) = "" Then b3471.DateSMDocs = ""  Else b3471.DateSMDocs=a3471.DateSMDocs
If trim$( a3471.ChkLocalCharge ) = "" Then b3471.ChkLocalCharge = ""  Else b3471.ChkLocalCharge=a3471.ChkLocalCharge
If trim$( a3471.DateLocalCharge ) = "" Then b3471.DateLocalCharge = ""  Else b3471.DateLocalCharge=a3471.DateLocalCharge
If trim$( a3471.ChkUploadDocs ) = "" Then b3471.ChkUploadDocs = ""  Else b3471.ChkUploadDocs=a3471.ChkUploadDocs
If trim$( a3471.DateUploadDocs ) = "" Then b3471.DateUploadDocs = ""  Else b3471.DateUploadDocs=a3471.DateUploadDocs
If trim$( a3471.ChkDocsHK ) = "" Then b3471.ChkDocsHK = ""  Else b3471.ChkDocsHK=a3471.ChkDocsHK
If trim$( a3471.DateDocsHK ) = "" Then b3471.DateDocsHK = ""  Else b3471.DateDocsHK=a3471.DateDocsHK
If trim$( a3471.ChkDocsBuyer ) = "" Then b3471.ChkDocsBuyer = ""  Else b3471.ChkDocsBuyer=a3471.ChkDocsBuyer
If trim$( a3471.ChkReceiveHK ) = "" Then b3471.ChkReceiveHK = ""  Else b3471.ChkReceiveHK=a3471.ChkReceiveHK
If trim$( a3471.ChkPending ) = "" Then b3471.ChkPending = ""  Else b3471.ChkPending=a3471.ChkPending
If trim$( a3471.DateDocsBuyer ) = "" Then b3471.DateDocsBuyer = ""  Else b3471.DateDocsBuyer=a3471.DateDocsBuyer
If trim$( a3471.CheckLiquidation ) = "" Then b3471.CheckLiquidation = ""  Else b3471.CheckLiquidation=a3471.CheckLiquidation
If trim$( a3471.CheckStatus ) = "" Then b3471.CheckStatus = ""  Else b3471.CheckStatus=a3471.CheckStatus
If trim$( a3471.QtyOrder ) = "" Then b3471.QtyOrder = ""  Else b3471.QtyOrder=a3471.QtyOrder
If trim$( a3471.QtyOrderSample ) = "" Then b3471.QtyOrderSample = ""  Else b3471.QtyOrderSample=a3471.QtyOrderSample
If trim$( a3471.PriceOrderFOB ) = "" Then b3471.PriceOrderFOB = ""  Else b3471.PriceOrderFOB=a3471.PriceOrderFOB
If trim$( a3471.TotalAMTFOB ) = "" Then b3471.TotalAMTFOB = ""  Else b3471.TotalAMTFOB=a3471.TotalAMTFOB
If trim$( a3471.PriceOrder ) = "" Then b3471.PriceOrder = ""  Else b3471.PriceOrder=a3471.PriceOrder
If trim$( a3471.TotalAMT ) = "" Then b3471.TotalAMT = ""  Else b3471.TotalAMT=a3471.TotalAMT
If trim$( a3471.TotalGW ) = "" Then b3471.TotalGW = ""  Else b3471.TotalGW=a3471.TotalGW
If trim$( a3471.TotalNW ) = "" Then b3471.TotalNW = ""  Else b3471.TotalNW=a3471.TotalNW
If trim$( a3471.TotalCBM ) = "" Then b3471.TotalCBM = ""  Else b3471.TotalCBM=a3471.TotalCBM
If trim$( a3471.TotalQty ) = "" Then b3471.TotalQty = ""  Else b3471.TotalQty=a3471.TotalQty
If trim$( a3471.TotalCnt ) = "" Then b3471.TotalCnt = ""  Else b3471.TotalCnt=a3471.TotalCnt
If trim$( a3471.ContName1 ) = "" Then b3471.ContName1 = ""  Else b3471.ContName1=a3471.ContName1
If trim$( a3471.ContName2 ) = "" Then b3471.ContName2 = ""  Else b3471.ContName2=a3471.ContName2
If trim$( a3471.ContName3 ) = "" Then b3471.ContName3 = ""  Else b3471.ContName3=a3471.ContName3
If trim$( a3471.ContName4 ) = "" Then b3471.ContName4 = ""  Else b3471.ContName4=a3471.ContName4
If trim$( a3471.ContName5 ) = "" Then b3471.ContName5 = ""  Else b3471.ContName5=a3471.ContName5
If trim$( a3471.ContName6 ) = "" Then b3471.ContName6 = ""  Else b3471.ContName6=a3471.ContName6
If trim$( a3471.ContName7 ) = "" Then b3471.ContName7 = ""  Else b3471.ContName7=a3471.ContName7
If trim$( a3471.ContName8 ) = "" Then b3471.ContName8 = ""  Else b3471.ContName8=a3471.ContName8
If trim$( a3471.ContName9 ) = "" Then b3471.ContName9 = ""  Else b3471.ContName9=a3471.ContName9
If trim$( a3471.ContName10 ) = "" Then b3471.ContName10 = ""  Else b3471.ContName10=a3471.ContName10
If trim$( a3471.QtyPL1 ) = "" Then b3471.QtyPL1 = ""  Else b3471.QtyPL1=a3471.QtyPL1
If trim$( a3471.QtyPL2 ) = "" Then b3471.QtyPL2 = ""  Else b3471.QtyPL2=a3471.QtyPL2
If trim$( a3471.QtyPL3 ) = "" Then b3471.QtyPL3 = ""  Else b3471.QtyPL3=a3471.QtyPL3
If trim$( a3471.QtyPL4 ) = "" Then b3471.QtyPL4 = ""  Else b3471.QtyPL4=a3471.QtyPL4
If trim$( a3471.QtyPL5 ) = "" Then b3471.QtyPL5 = ""  Else b3471.QtyPL5=a3471.QtyPL5
If trim$( a3471.QtyPL6 ) = "" Then b3471.QtyPL6 = ""  Else b3471.QtyPL6=a3471.QtyPL6
If trim$( a3471.QtyPL7 ) = "" Then b3471.QtyPL7 = ""  Else b3471.QtyPL7=a3471.QtyPL7
If trim$( a3471.QtyPL8 ) = "" Then b3471.QtyPL8 = ""  Else b3471.QtyPL8=a3471.QtyPL8
If trim$( a3471.QtyPL9 ) = "" Then b3471.QtyPL9 = ""  Else b3471.QtyPL9=a3471.QtyPL9
If trim$( a3471.QtyPL10 ) = "" Then b3471.QtyPL10 = ""  Else b3471.QtyPL10=a3471.QtyPL10
If trim$( a3471.seSite ) = "" Then b3471.seSite = ""  Else b3471.seSite=a3471.seSite
If trim$( a3471.cdSite ) = "" Then b3471.cdSite = ""  Else b3471.cdSite=a3471.cdSite
If trim$( a3471.Remark ) = "" Then b3471.Remark = ""  Else b3471.Remark=a3471.Remark
If trim$( a3471.TimeInsert ) = "" Then b3471.TimeInsert = ""  Else b3471.TimeInsert=a3471.TimeInsert
If trim$( a3471.TimeUpdate ) = "" Then b3471.TimeUpdate = ""  Else b3471.TimeUpdate=a3471.TimeUpdate
If trim$( a3471.DateUpdate ) = "" Then b3471.DateUpdate = ""  Else b3471.DateUpdate=a3471.DateUpdate
If trim$( a3471.DateInsert ) = "" Then b3471.DateInsert = ""  Else b3471.DateInsert=a3471.DateInsert
If trim$( a3471.InchargeInsert ) = "" Then b3471.InchargeInsert = ""  Else b3471.InchargeInsert=a3471.InchargeInsert
If trim$( a3471.InchargeUpdate ) = "" Then b3471.InchargeUpdate = ""  Else b3471.InchargeUpdate=a3471.InchargeUpdate
Catch ex As Exception
      Call MsgBoxP("K3471_MOVE",vbCritical)
End Try
End Sub 


End Module 
