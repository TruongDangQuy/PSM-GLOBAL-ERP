'=========================================================================================================================================================
'   TABLE : (PFK4002)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K4002

Structure T4002_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	WorkOrder	 AS String	'			char(9)		*
Public 	WorkOrderSeq	 AS String	'			char(3)		*
Public 	OrderNo	 AS String	'			char(9)
Public 	OrderNoSeq	 AS String	'			char(3)
Public 	SLNo	 AS String	'			nvarchar(20)
Public 	SealMaster	 AS String	'			nvarchar(20)
Public 	WorkOrderStatus	 AS String	'			char(1)
Public 	DateApproval	 AS String	'			char(8)
Public 	DateCancel	 AS String	'			char(8)
Public 	DateComplete	 AS String	'			char(8)
Public 	DatePending	 AS String	'			char(8)
Public 	DateDelivery	 AS String	'			char(8)
Public 	DateTransfer	 AS String	'			char(8)
Public 	DateAccept	 AS String	'			char(8)
Public 	AcceptedOrder	 AS String	'			char(1)
Public 	MaterialStatus	 AS String	'			char(1)
Public 	SoleNo	 AS String	'			char(9)
Public 	CuttingNo	 AS String	'			char(9)
Public 	StitchingNo	 AS String	'			char(9)
Public 	SubprocessNo	 AS String	'			char(9)
Public 	OutsourceNo	 AS String	'			char(9)
Public 	StockfitNo	 AS String	'			char(9)
Public 	AssemblyNo	 AS String	'			char(9)
Public 	CuttingStatus	 AS String	'			char(1)
Public 	StitchingStatus	 AS String	'			char(1)
Public 	SubprocessStatus	 AS String	'			char(1)
Public 	OutsourceStatsus	 AS String	'			char(1)
Public 	StockfitStatsus	 AS String	'			char(1)
Public 	AssemblyStatus	 AS String	'			char(1)
Public 	SoleStatus	 AS String	'			char(1)
Public 	DatePattern	 AS String	'			char(8)
Public 	DateMaterial	 AS String	'			char(8)
Public 	DatePlanning	 AS String	'			char(8)
Public 	DateRnD	 AS String	'			char(8)
Public 	DateConfirm	 AS String	'			char(8)
Public 	DateStart	 AS String	'			char(8)
Public 	DateFinish	 AS String	'			char(8)
Public 	DateSole	 AS String	'			char(8)
Public 	DateCutting	 AS String	'			char(8)
Public 	DateStitching	 AS String	'			char(8)
Public 	DateStockfit	 AS String	'			char(8)
Public 	DateAssembly	 AS String	'			char(8)
Public 	DateShipping	 AS String	'			char(8)
Public 	seUnitMaterial	 AS String	'			char(3)
Public 	cdUnitMaterial	 AS String	'			char(3)
Public 	seUnitPacking	 AS String	'			char(3)
Public 	cdUnitPacking	 AS String	'			char(3)
Public 	QtyOrder	 AS Double	'			decimal
Public 	QtyBooking	 AS Double	'			decimal
Public 	QtyJob	 AS Double	'			decimal
Public 	QtyPlan	 AS Double	'			decimal
Public 	QtySole	 AS Double	'			decimal
Public 	QtySoleA	 AS Double	'			decimal
Public 	QtySoleX	 AS Double	'			decimal
Public 	QtySoleBLOut	 AS Double	'			decimal
Public 	QtySoleBLIn	 AS Double	'			decimal
Public 	QtyCutting	 AS Double	'			decimal
Public 	QtyCuttingA	 AS Double	'			decimal
Public 	QtyCuttingX	 AS Double	'			decimal
Public 	QtyCuttingBLOut	 AS Double	'			decimal
Public 	QtyCuttingBLIn	 AS Double	'			decimal
Public 	QtyStitching	 AS Double	'			decimal
Public 	QtyStitchingA	 AS Double	'			decimal
Public 	QtyStitchingX	 AS Double	'			decimal
Public 	QtyStitchingBLOut	 AS Double	'			decimal
Public 	QtyStitchingBLIn	 AS Double	'			decimal
Public 	QtyStockfit	 AS Double	'			decimal
Public 	QtyStockfitA	 AS Double	'			decimal
Public 	QtyStockfitX	 AS Double	'			decimal
Public 	QtyStockfitBLOut	 AS Double	'			decimal
Public 	QtyStockfitBLIn	 AS Double	'			decimal
Public 	QtyAssembly	 AS Double	'			decimal
Public 	QtyAssemblyA	 AS Double	'			decimal
Public 	QtyAssemblyX	 AS Double	'			decimal
Public 	QtyAssemblyBLOut	 AS Double	'			decimal
Public 	QtyAssemblyBLIn	 AS Double	'			decimal
Public 	QtyJobShipping	 AS Double	'			decimal
Public 	QtyShipping	 AS Double	'			decimal
Public 	DateInsert	 AS String	'			char(8)
Public 	InchargeInsert	 AS String	'			char(8)
Public 	DateUpdate	 AS String	'			char(8)
Public 	InchargeUpdate	 AS String	'			char(8)
Public 	InchargeSales	 AS String	'			char(8)
Public 	InchargePPC	 AS String	'			char(8)
Public 	AttachID	 AS String	'			char(6)
Public 	chkMaterial	 AS String	'			char(1)
Public 	RemarkMaterial	 AS String	'			nvarchar(30)
Public 	InchargeMaterial	 AS String	'			char(8)
Public 	DateRemarkMaterial	 AS String	'			char(8)
Public 	chkSole	 AS String	'			char(1)
Public 	RemarkSole	 AS String	'			nvarchar(30)
Public 	InchargeSole	 AS String	'			char(8)
Public 	DateRemarkSole	 AS String	'			char(8)
Public 	chkLast	 AS String	'			char(1)
Public 	RemarkLast	 AS String	'			nvarchar(30)
Public 	InchargeLast	 AS String	'			char(8)
Public 	DateRemarkLast	 AS String	'			char(8)
Public 	chkMold	 AS String	'			char(1)
Public 	RemarkMold	 AS String	'			nvarchar(30)
Public 	InchargeMold	 AS String	'			char(8)
Public 	DateRemarkMold	 AS String	'			char(8)
Public 	chkSpec	 AS String	'			char(1)
Public 	RemarkSpec	 AS String	'			nvarchar(30)
Public 	InchargeSpec	 AS String	'			char(8)
Public 	DateRemarkSpec	 AS String	'			char(8)
Public 	chkTest	 AS String	'			char(1)
Public 	RemarkTest	 AS String	'			nvarchar(30)
Public 	InchargeTest	 AS String	'			char(8)
Public 	DateRemarkTest	 AS String	'			char(8)
Public 	chkCFM	 AS String	'			char(1)
Public 	RemarkCFM	 AS String	'			nvarchar(30)
Public 	InchargeCFM	 AS String	'			char(8)
Public 	DateRemarkCFM	 AS String	'			char(8)
Public 	FactorykAllocation	 AS String	'			nvarchar(10)
Public 	LineAllocation	 AS String	'			nvarchar(20)
Public 	RemarkAllocation	 AS String	'			nvarchar(30)
Public 	RemarkOrder	 AS String	'			nvarchar(100)
Public 	RemarkCustomer	 AS String	'			nvarchar(100)
Public 	RemarkOther	 AS String	'			nvarchar(100)
Public 	Remark	 AS String	'			nvarchar(100)
'=========================================================================================================================================================
End structure

Public D4002 As T4002_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK4002(WORKORDER AS String, WORKORDERSEQ AS String) As Boolean
    READ_PFK4002 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK4002 "
    SQL = SQL & " WHERE K4002_WorkOrder		 = '" & WorkOrder & "' " 
    SQL = SQL & "   AND K4002_WorkOrderSeq		 = '" & WorkOrderSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D4002_CLEAR: GoTo SKIP_READ_PFK4002
                
    Call K4002_MOVE(rd)
    READ_PFK4002 = True

SKIP_READ_PFK4002:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK4002",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK4002(WORKORDER AS String, WORKORDERSEQ AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK4002 "
    SQL = SQL & " WHERE K4002_WorkOrder		 = '" & WorkOrder & "' " 
    SQL = SQL & "   AND K4002_WorkOrderSeq		 = '" & WorkOrderSeq & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK4002",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK4002(z4002 As T4002_AREA) As Boolean
    WRITE_PFK4002 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z4002)
 
    SQL = " INSERT INTO PFK4002 "
    SQL = SQL & " ( "
    SQL = SQL & " K4002_WorkOrder," 
    SQL = SQL & " K4002_WorkOrderSeq," 
    SQL = SQL & " K4002_OrderNo," 
    SQL = SQL & " K4002_OrderNoSeq," 
    SQL = SQL & " K4002_SLNo," 
    SQL = SQL & " K4002_SealMaster," 
    SQL = SQL & " K4002_WorkOrderStatus," 
    SQL = SQL & " K4002_DateApproval," 
    SQL = SQL & " K4002_DateCancel," 
    SQL = SQL & " K4002_DateComplete," 
    SQL = SQL & " K4002_DatePending," 
    SQL = SQL & " K4002_DateDelivery," 
    SQL = SQL & " K4002_DateTransfer," 
    SQL = SQL & " K4002_DateAccept," 
    SQL = SQL & " K4002_AcceptedOrder," 
    SQL = SQL & " K4002_MaterialStatus," 
    SQL = SQL & " K4002_SoleNo," 
    SQL = SQL & " K4002_CuttingNo," 
    SQL = SQL & " K4002_StitchingNo," 
    SQL = SQL & " K4002_SubprocessNo," 
    SQL = SQL & " K4002_OutsourceNo," 
    SQL = SQL & " K4002_StockfitNo," 
    SQL = SQL & " K4002_AssemblyNo," 
    SQL = SQL & " K4002_CuttingStatus," 
    SQL = SQL & " K4002_StitchingStatus," 
    SQL = SQL & " K4002_SubprocessStatus," 
    SQL = SQL & " K4002_OutsourceStatsus," 
    SQL = SQL & " K4002_StockfitStatsus," 
    SQL = SQL & " K4002_AssemblyStatus," 
    SQL = SQL & " K4002_SoleStatus," 
    SQL = SQL & " K4002_DatePattern," 
    SQL = SQL & " K4002_DateMaterial," 
    SQL = SQL & " K4002_DatePlanning," 
    SQL = SQL & " K4002_DateRnD," 
    SQL = SQL & " K4002_DateConfirm," 
    SQL = SQL & " K4002_DateStart," 
    SQL = SQL & " K4002_DateFinish," 
    SQL = SQL & " K4002_DateSole," 
    SQL = SQL & " K4002_DateCutting," 
    SQL = SQL & " K4002_DateStitching," 
    SQL = SQL & " K4002_DateStockfit," 
    SQL = SQL & " K4002_DateAssembly," 
    SQL = SQL & " K4002_DateShipping," 
    SQL = SQL & " K4002_seUnitMaterial," 
    SQL = SQL & " K4002_cdUnitMaterial," 
    SQL = SQL & " K4002_seUnitPacking," 
    SQL = SQL & " K4002_cdUnitPacking," 
    SQL = SQL & " K4002_QtyOrder," 
    SQL = SQL & " K4002_QtyBooking," 
    SQL = SQL & " K4002_QtyJob," 
    SQL = SQL & " K4002_QtyPlan," 
    SQL = SQL & " K4002_QtySole," 
    SQL = SQL & " K4002_QtySoleA," 
    SQL = SQL & " K4002_QtySoleX," 
    SQL = SQL & " K4002_QtySoleBLOut," 
    SQL = SQL & " K4002_QtySoleBLIn," 
    SQL = SQL & " K4002_QtyCutting," 
    SQL = SQL & " K4002_QtyCuttingA," 
    SQL = SQL & " K4002_QtyCuttingX," 
    SQL = SQL & " K4002_QtyCuttingBLOut," 
    SQL = SQL & " K4002_QtyCuttingBLIn," 
    SQL = SQL & " K4002_QtyStitching," 
    SQL = SQL & " K4002_QtyStitchingA," 
    SQL = SQL & " K4002_QtyStitchingX," 
    SQL = SQL & " K4002_QtyStitchingBLOut," 
    SQL = SQL & " K4002_QtyStitchingBLIn," 
    SQL = SQL & " K4002_QtyStockfit," 
    SQL = SQL & " K4002_QtyStockfitA," 
    SQL = SQL & " K4002_QtyStockfitX," 
    SQL = SQL & " K4002_QtyStockfitBLOut," 
    SQL = SQL & " K4002_QtyStockfitBLIn," 
    SQL = SQL & " K4002_QtyAssembly," 
    SQL = SQL & " K4002_QtyAssemblyA," 
    SQL = SQL & " K4002_QtyAssemblyX," 
    SQL = SQL & " K4002_QtyAssemblyBLOut," 
    SQL = SQL & " K4002_QtyAssemblyBLIn," 
    SQL = SQL & " K4002_QtyJobShipping," 
    SQL = SQL & " K4002_QtyShipping," 
    SQL = SQL & " K4002_DateInsert," 
    SQL = SQL & " K4002_InchargeInsert," 
    SQL = SQL & " K4002_DateUpdate," 
    SQL = SQL & " K4002_InchargeUpdate," 
    SQL = SQL & " K4002_InchargeSales," 
    SQL = SQL & " K4002_InchargePPC," 
    SQL = SQL & " K4002_AttachID," 
    SQL = SQL & " K4002_chkMaterial," 
    SQL = SQL & " K4002_RemarkMaterial," 
    SQL = SQL & " K4002_InchargeMaterial," 
    SQL = SQL & " K4002_DateRemarkMaterial," 
    SQL = SQL & " K4002_chkSole," 
    SQL = SQL & " K4002_RemarkSole," 
    SQL = SQL & " K4002_InchargeSole," 
    SQL = SQL & " K4002_DateRemarkSole," 
    SQL = SQL & " K4002_chkLast," 
    SQL = SQL & " K4002_RemarkLast," 
    SQL = SQL & " K4002_InchargeLast," 
    SQL = SQL & " K4002_DateRemarkLast," 
    SQL = SQL & " K4002_chkMold," 
    SQL = SQL & " K4002_RemarkMold," 
    SQL = SQL & " K4002_InchargeMold," 
    SQL = SQL & " K4002_DateRemarkMold," 
    SQL = SQL & " K4002_chkSpec," 
    SQL = SQL & " K4002_RemarkSpec," 
    SQL = SQL & " K4002_InchargeSpec," 
    SQL = SQL & " K4002_DateRemarkSpec," 
    SQL = SQL & " K4002_chkTest," 
    SQL = SQL & " K4002_RemarkTest," 
    SQL = SQL & " K4002_InchargeTest," 
    SQL = SQL & " K4002_DateRemarkTest," 
    SQL = SQL & " K4002_chkCFM," 
    SQL = SQL & " K4002_RemarkCFM," 
    SQL = SQL & " K4002_InchargeCFM," 
    SQL = SQL & " K4002_DateRemarkCFM," 
    SQL = SQL & " K4002_FactorykAllocation," 
    SQL = SQL & " K4002_LineAllocation," 
    SQL = SQL & " K4002_RemarkAllocation," 
    SQL = SQL & " K4002_RemarkOrder," 
    SQL = SQL & " K4002_RemarkCustomer," 
    SQL = SQL & " K4002_RemarkOther," 
    SQL = SQL & " K4002_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z4002.WorkOrder) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.WorkOrderSeq) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.OrderNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.OrderNoSeq) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.SLNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.SealMaster) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.WorkOrderStatus) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.DateApproval) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.DateCancel) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.DateComplete) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.DatePending) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.DateDelivery) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.DateTransfer) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.DateAccept) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.AcceptedOrder) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.MaterialStatus) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.SoleNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.CuttingNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.StitchingNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.SubprocessNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.OutsourceNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.StockfitNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.AssemblyNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.CuttingStatus) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.StitchingStatus) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.SubprocessStatus) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.OutsourceStatsus) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.StockfitStatsus) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.AssemblyStatus) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.SoleStatus) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.DatePattern) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.DateMaterial) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.DatePlanning) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.DateRnD) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.DateConfirm) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.DateStart) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.DateFinish) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.DateSole) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.DateCutting) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.DateStitching) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.DateStockfit) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.DateAssembly) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.DateShipping) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.seUnitMaterial) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.cdUnitMaterial) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.seUnitPacking) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.cdUnitPacking) & "', "  
    SQL = SQL & "   " & FormatSQL(z4002.QtyOrder) & ", "  
    SQL = SQL & "   " & FormatSQL(z4002.QtyBooking) & ", "  
    SQL = SQL & "   " & FormatSQL(z4002.QtyJob) & ", "  
    SQL = SQL & "   " & FormatSQL(z4002.QtyPlan) & ", "  
    SQL = SQL & "   " & FormatSQL(z4002.QtySole) & ", "  
    SQL = SQL & "   " & FormatSQL(z4002.QtySoleA) & ", "  
    SQL = SQL & "   " & FormatSQL(z4002.QtySoleX) & ", "  
    SQL = SQL & "   " & FormatSQL(z4002.QtySoleBLOut) & ", "  
    SQL = SQL & "   " & FormatSQL(z4002.QtySoleBLIn) & ", "  
    SQL = SQL & "   " & FormatSQL(z4002.QtyCutting) & ", "  
    SQL = SQL & "   " & FormatSQL(z4002.QtyCuttingA) & ", "  
    SQL = SQL & "   " & FormatSQL(z4002.QtyCuttingX) & ", "  
    SQL = SQL & "   " & FormatSQL(z4002.QtyCuttingBLOut) & ", "  
    SQL = SQL & "   " & FormatSQL(z4002.QtyCuttingBLIn) & ", "  
    SQL = SQL & "   " & FormatSQL(z4002.QtyStitching) & ", "  
    SQL = SQL & "   " & FormatSQL(z4002.QtyStitchingA) & ", "  
    SQL = SQL & "   " & FormatSQL(z4002.QtyStitchingX) & ", "  
    SQL = SQL & "   " & FormatSQL(z4002.QtyStitchingBLOut) & ", "  
    SQL = SQL & "   " & FormatSQL(z4002.QtyStitchingBLIn) & ", "  
    SQL = SQL & "   " & FormatSQL(z4002.QtyStockfit) & ", "  
    SQL = SQL & "   " & FormatSQL(z4002.QtyStockfitA) & ", "  
    SQL = SQL & "   " & FormatSQL(z4002.QtyStockfitX) & ", "  
    SQL = SQL & "   " & FormatSQL(z4002.QtyStockfitBLOut) & ", "  
    SQL = SQL & "   " & FormatSQL(z4002.QtyStockfitBLIn) & ", "  
    SQL = SQL & "   " & FormatSQL(z4002.QtyAssembly) & ", "  
    SQL = SQL & "   " & FormatSQL(z4002.QtyAssemblyA) & ", "  
    SQL = SQL & "   " & FormatSQL(z4002.QtyAssemblyX) & ", "  
    SQL = SQL & "   " & FormatSQL(z4002.QtyAssemblyBLOut) & ", "  
    SQL = SQL & "   " & FormatSQL(z4002.QtyAssemblyBLIn) & ", "  
    SQL = SQL & "   " & FormatSQL(z4002.QtyJobShipping) & ", "  
    SQL = SQL & "   " & FormatSQL(z4002.QtyShipping) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z4002.DateInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.InchargeSales) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.InchargePPC) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.AttachID) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.chkMaterial) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.RemarkMaterial) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.InchargeMaterial) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.DateRemarkMaterial) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.chkSole) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.RemarkSole) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.InchargeSole) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.DateRemarkSole) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.chkLast) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.RemarkLast) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.InchargeLast) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.DateRemarkLast) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.chkMold) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.RemarkMold) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.InchargeMold) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.DateRemarkMold) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.chkSpec) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.RemarkSpec) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.InchargeSpec) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.DateRemarkSpec) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.chkTest) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.RemarkTest) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.InchargeTest) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.DateRemarkTest) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.chkCFM) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.RemarkCFM) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.InchargeCFM) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.DateRemarkCFM) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.FactorykAllocation) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.LineAllocation) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.RemarkAllocation) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.RemarkOrder) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.RemarkCustomer) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.RemarkOther) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4002.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK4002 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK4002",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK4002(z4002 As T4002_AREA) As Boolean
    REWRITE_PFK4002 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z4002)
   
    SQL = " UPDATE PFK4002 SET "
    SQL = SQL & "    K4002_OrderNo      = N'" & FormatSQL(z4002.OrderNo) & "', " 
    SQL = SQL & "    K4002_OrderNoSeq      = N'" & FormatSQL(z4002.OrderNoSeq) & "', " 
    SQL = SQL & "    K4002_SLNo      = N'" & FormatSQL(z4002.SLNo) & "', " 
    SQL = SQL & "    K4002_SealMaster      = N'" & FormatSQL(z4002.SealMaster) & "', " 
    SQL = SQL & "    K4002_WorkOrderStatus      = N'" & FormatSQL(z4002.WorkOrderStatus) & "', " 
    SQL = SQL & "    K4002_DateApproval      = N'" & FormatSQL(z4002.DateApproval) & "', " 
    SQL = SQL & "    K4002_DateCancel      = N'" & FormatSQL(z4002.DateCancel) & "', " 
    SQL = SQL & "    K4002_DateComplete      = N'" & FormatSQL(z4002.DateComplete) & "', " 
    SQL = SQL & "    K4002_DatePending      = N'" & FormatSQL(z4002.DatePending) & "', " 
    SQL = SQL & "    K4002_DateDelivery      = N'" & FormatSQL(z4002.DateDelivery) & "', " 
    SQL = SQL & "    K4002_DateTransfer      = N'" & FormatSQL(z4002.DateTransfer) & "', " 
    SQL = SQL & "    K4002_DateAccept      = N'" & FormatSQL(z4002.DateAccept) & "', " 
    SQL = SQL & "    K4002_AcceptedOrder      = N'" & FormatSQL(z4002.AcceptedOrder) & "', " 
    SQL = SQL & "    K4002_MaterialStatus      = N'" & FormatSQL(z4002.MaterialStatus) & "', " 
    SQL = SQL & "    K4002_SoleNo      = N'" & FormatSQL(z4002.SoleNo) & "', " 
    SQL = SQL & "    K4002_CuttingNo      = N'" & FormatSQL(z4002.CuttingNo) & "', " 
    SQL = SQL & "    K4002_StitchingNo      = N'" & FormatSQL(z4002.StitchingNo) & "', " 
    SQL = SQL & "    K4002_SubprocessNo      = N'" & FormatSQL(z4002.SubprocessNo) & "', " 
    SQL = SQL & "    K4002_OutsourceNo      = N'" & FormatSQL(z4002.OutsourceNo) & "', " 
    SQL = SQL & "    K4002_StockfitNo      = N'" & FormatSQL(z4002.StockfitNo) & "', " 
    SQL = SQL & "    K4002_AssemblyNo      = N'" & FormatSQL(z4002.AssemblyNo) & "', " 
    SQL = SQL & "    K4002_CuttingStatus      = N'" & FormatSQL(z4002.CuttingStatus) & "', " 
    SQL = SQL & "    K4002_StitchingStatus      = N'" & FormatSQL(z4002.StitchingStatus) & "', " 
    SQL = SQL & "    K4002_SubprocessStatus      = N'" & FormatSQL(z4002.SubprocessStatus) & "', " 
    SQL = SQL & "    K4002_OutsourceStatsus      = N'" & FormatSQL(z4002.OutsourceStatsus) & "', " 
    SQL = SQL & "    K4002_StockfitStatsus      = N'" & FormatSQL(z4002.StockfitStatsus) & "', " 
    SQL = SQL & "    K4002_AssemblyStatus      = N'" & FormatSQL(z4002.AssemblyStatus) & "', " 
    SQL = SQL & "    K4002_SoleStatus      = N'" & FormatSQL(z4002.SoleStatus) & "', " 
    SQL = SQL & "    K4002_DatePattern      = N'" & FormatSQL(z4002.DatePattern) & "', " 
    SQL = SQL & "    K4002_DateMaterial      = N'" & FormatSQL(z4002.DateMaterial) & "', " 
    SQL = SQL & "    K4002_DatePlanning      = N'" & FormatSQL(z4002.DatePlanning) & "', " 
    SQL = SQL & "    K4002_DateRnD      = N'" & FormatSQL(z4002.DateRnD) & "', " 
    SQL = SQL & "    K4002_DateConfirm      = N'" & FormatSQL(z4002.DateConfirm) & "', " 
    SQL = SQL & "    K4002_DateStart      = N'" & FormatSQL(z4002.DateStart) & "', " 
    SQL = SQL & "    K4002_DateFinish      = N'" & FormatSQL(z4002.DateFinish) & "', " 
    SQL = SQL & "    K4002_DateSole      = N'" & FormatSQL(z4002.DateSole) & "', " 
    SQL = SQL & "    K4002_DateCutting      = N'" & FormatSQL(z4002.DateCutting) & "', " 
    SQL = SQL & "    K4002_DateStitching      = N'" & FormatSQL(z4002.DateStitching) & "', " 
    SQL = SQL & "    K4002_DateStockfit      = N'" & FormatSQL(z4002.DateStockfit) & "', " 
    SQL = SQL & "    K4002_DateAssembly      = N'" & FormatSQL(z4002.DateAssembly) & "', " 
    SQL = SQL & "    K4002_DateShipping      = N'" & FormatSQL(z4002.DateShipping) & "', " 
    SQL = SQL & "    K4002_seUnitMaterial      = N'" & FormatSQL(z4002.seUnitMaterial) & "', " 
    SQL = SQL & "    K4002_cdUnitMaterial      = N'" & FormatSQL(z4002.cdUnitMaterial) & "', " 
    SQL = SQL & "    K4002_seUnitPacking      = N'" & FormatSQL(z4002.seUnitPacking) & "', " 
    SQL = SQL & "    K4002_cdUnitPacking      = N'" & FormatSQL(z4002.cdUnitPacking) & "', " 
    SQL = SQL & "    K4002_QtyOrder      =  " & FormatSQL(z4002.QtyOrder) & ", " 
    SQL = SQL & "    K4002_QtyBooking      =  " & FormatSQL(z4002.QtyBooking) & ", " 
    SQL = SQL & "    K4002_QtyJob      =  " & FormatSQL(z4002.QtyJob) & ", " 
    SQL = SQL & "    K4002_QtyPlan      =  " & FormatSQL(z4002.QtyPlan) & ", " 
    SQL = SQL & "    K4002_QtySole      =  " & FormatSQL(z4002.QtySole) & ", " 
    SQL = SQL & "    K4002_QtySoleA      =  " & FormatSQL(z4002.QtySoleA) & ", " 
    SQL = SQL & "    K4002_QtySoleX      =  " & FormatSQL(z4002.QtySoleX) & ", " 
    SQL = SQL & "    K4002_QtySoleBLOut      =  " & FormatSQL(z4002.QtySoleBLOut) & ", " 
    SQL = SQL & "    K4002_QtySoleBLIn      =  " & FormatSQL(z4002.QtySoleBLIn) & ", " 
    SQL = SQL & "    K4002_QtyCutting      =  " & FormatSQL(z4002.QtyCutting) & ", " 
    SQL = SQL & "    K4002_QtyCuttingA      =  " & FormatSQL(z4002.QtyCuttingA) & ", " 
    SQL = SQL & "    K4002_QtyCuttingX      =  " & FormatSQL(z4002.QtyCuttingX) & ", " 
    SQL = SQL & "    K4002_QtyCuttingBLOut      =  " & FormatSQL(z4002.QtyCuttingBLOut) & ", " 
    SQL = SQL & "    K4002_QtyCuttingBLIn      =  " & FormatSQL(z4002.QtyCuttingBLIn) & ", " 
    SQL = SQL & "    K4002_QtyStitching      =  " & FormatSQL(z4002.QtyStitching) & ", " 
    SQL = SQL & "    K4002_QtyStitchingA      =  " & FormatSQL(z4002.QtyStitchingA) & ", " 
    SQL = SQL & "    K4002_QtyStitchingX      =  " & FormatSQL(z4002.QtyStitchingX) & ", " 
    SQL = SQL & "    K4002_QtyStitchingBLOut      =  " & FormatSQL(z4002.QtyStitchingBLOut) & ", " 
    SQL = SQL & "    K4002_QtyStitchingBLIn      =  " & FormatSQL(z4002.QtyStitchingBLIn) & ", " 
    SQL = SQL & "    K4002_QtyStockfit      =  " & FormatSQL(z4002.QtyStockfit) & ", " 
    SQL = SQL & "    K4002_QtyStockfitA      =  " & FormatSQL(z4002.QtyStockfitA) & ", " 
    SQL = SQL & "    K4002_QtyStockfitX      =  " & FormatSQL(z4002.QtyStockfitX) & ", " 
    SQL = SQL & "    K4002_QtyStockfitBLOut      =  " & FormatSQL(z4002.QtyStockfitBLOut) & ", " 
    SQL = SQL & "    K4002_QtyStockfitBLIn      =  " & FormatSQL(z4002.QtyStockfitBLIn) & ", " 
    SQL = SQL & "    K4002_QtyAssembly      =  " & FormatSQL(z4002.QtyAssembly) & ", " 
    SQL = SQL & "    K4002_QtyAssemblyA      =  " & FormatSQL(z4002.QtyAssemblyA) & ", " 
    SQL = SQL & "    K4002_QtyAssemblyX      =  " & FormatSQL(z4002.QtyAssemblyX) & ", " 
    SQL = SQL & "    K4002_QtyAssemblyBLOut      =  " & FormatSQL(z4002.QtyAssemblyBLOut) & ", " 
    SQL = SQL & "    K4002_QtyAssemblyBLIn      =  " & FormatSQL(z4002.QtyAssemblyBLIn) & ", " 
    SQL = SQL & "    K4002_QtyJobShipping      =  " & FormatSQL(z4002.QtyJobShipping) & ", " 
    SQL = SQL & "    K4002_QtyShipping      =  " & FormatSQL(z4002.QtyShipping) & ", " 
    SQL = SQL & "    K4002_DateInsert      = N'" & FormatSQL(z4002.DateInsert) & "', " 
    SQL = SQL & "    K4002_InchargeInsert      = N'" & FormatSQL(z4002.InchargeInsert) & "', " 
    SQL = SQL & "    K4002_DateUpdate      = N'" & FormatSQL(z4002.DateUpdate) & "', " 
    SQL = SQL & "    K4002_InchargeUpdate      = N'" & FormatSQL(z4002.InchargeUpdate) & "', " 
    SQL = SQL & "    K4002_InchargeSales      = N'" & FormatSQL(z4002.InchargeSales) & "', " 
    SQL = SQL & "    K4002_InchargePPC      = N'" & FormatSQL(z4002.InchargePPC) & "', " 
    SQL = SQL & "    K4002_AttachID      = N'" & FormatSQL(z4002.AttachID) & "', " 
    SQL = SQL & "    K4002_chkMaterial      = N'" & FormatSQL(z4002.chkMaterial) & "', " 
    SQL = SQL & "    K4002_RemarkMaterial      = N'" & FormatSQL(z4002.RemarkMaterial) & "', " 
    SQL = SQL & "    K4002_InchargeMaterial      = N'" & FormatSQL(z4002.InchargeMaterial) & "', " 
    SQL = SQL & "    K4002_DateRemarkMaterial      = N'" & FormatSQL(z4002.DateRemarkMaterial) & "', " 
    SQL = SQL & "    K4002_chkSole      = N'" & FormatSQL(z4002.chkSole) & "', " 
    SQL = SQL & "    K4002_RemarkSole      = N'" & FormatSQL(z4002.RemarkSole) & "', " 
    SQL = SQL & "    K4002_InchargeSole      = N'" & FormatSQL(z4002.InchargeSole) & "', " 
    SQL = SQL & "    K4002_DateRemarkSole      = N'" & FormatSQL(z4002.DateRemarkSole) & "', " 
    SQL = SQL & "    K4002_chkLast      = N'" & FormatSQL(z4002.chkLast) & "', " 
    SQL = SQL & "    K4002_RemarkLast      = N'" & FormatSQL(z4002.RemarkLast) & "', " 
    SQL = SQL & "    K4002_InchargeLast      = N'" & FormatSQL(z4002.InchargeLast) & "', " 
    SQL = SQL & "    K4002_DateRemarkLast      = N'" & FormatSQL(z4002.DateRemarkLast) & "', " 
    SQL = SQL & "    K4002_chkMold      = N'" & FormatSQL(z4002.chkMold) & "', " 
    SQL = SQL & "    K4002_RemarkMold      = N'" & FormatSQL(z4002.RemarkMold) & "', " 
    SQL = SQL & "    K4002_InchargeMold      = N'" & FormatSQL(z4002.InchargeMold) & "', " 
    SQL = SQL & "    K4002_DateRemarkMold      = N'" & FormatSQL(z4002.DateRemarkMold) & "', " 
    SQL = SQL & "    K4002_chkSpec      = N'" & FormatSQL(z4002.chkSpec) & "', " 
    SQL = SQL & "    K4002_RemarkSpec      = N'" & FormatSQL(z4002.RemarkSpec) & "', " 
    SQL = SQL & "    K4002_InchargeSpec      = N'" & FormatSQL(z4002.InchargeSpec) & "', " 
    SQL = SQL & "    K4002_DateRemarkSpec      = N'" & FormatSQL(z4002.DateRemarkSpec) & "', " 
    SQL = SQL & "    K4002_chkTest      = N'" & FormatSQL(z4002.chkTest) & "', " 
    SQL = SQL & "    K4002_RemarkTest      = N'" & FormatSQL(z4002.RemarkTest) & "', " 
    SQL = SQL & "    K4002_InchargeTest      = N'" & FormatSQL(z4002.InchargeTest) & "', " 
    SQL = SQL & "    K4002_DateRemarkTest      = N'" & FormatSQL(z4002.DateRemarkTest) & "', " 
    SQL = SQL & "    K4002_chkCFM      = N'" & FormatSQL(z4002.chkCFM) & "', " 
    SQL = SQL & "    K4002_RemarkCFM      = N'" & FormatSQL(z4002.RemarkCFM) & "', " 
    SQL = SQL & "    K4002_InchargeCFM      = N'" & FormatSQL(z4002.InchargeCFM) & "', " 
    SQL = SQL & "    K4002_DateRemarkCFM      = N'" & FormatSQL(z4002.DateRemarkCFM) & "', " 
    SQL = SQL & "    K4002_FactorykAllocation      = N'" & FormatSQL(z4002.FactorykAllocation) & "', " 
    SQL = SQL & "    K4002_LineAllocation      = N'" & FormatSQL(z4002.LineAllocation) & "', " 
    SQL = SQL & "    K4002_RemarkAllocation      = N'" & FormatSQL(z4002.RemarkAllocation) & "', " 
    SQL = SQL & "    K4002_RemarkOrder      = N'" & FormatSQL(z4002.RemarkOrder) & "', " 
    SQL = SQL & "    K4002_RemarkCustomer      = N'" & FormatSQL(z4002.RemarkCustomer) & "', " 
    SQL = SQL & "    K4002_RemarkOther      = N'" & FormatSQL(z4002.RemarkOther) & "', " 
    SQL = SQL & "    K4002_Remark      = N'" & FormatSQL(z4002.Remark) & "'  " 
    SQL = SQL & " WHERE K4002_WorkOrder		 = '" & z4002.WorkOrder & "' " 
    SQL = SQL & "   AND K4002_WorkOrderSeq		 = '" & z4002.WorkOrderSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK4002 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK4002",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK4002(z4002 As T4002_AREA) As Boolean
    DELETE_PFK4002 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK4002 "
    SQL = SQL & " WHERE K4002_WorkOrder		 = '" & z4002.WorkOrder & "' " 
    SQL = SQL & "   AND K4002_WorkOrderSeq		 = '" & z4002.WorkOrderSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK4002 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK4002",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D4002_CLEAR()
Try
    
   D4002.WorkOrder = ""
   D4002.WorkOrderSeq = ""
   D4002.OrderNo = ""
   D4002.OrderNoSeq = ""
   D4002.SLNo = ""
   D4002.SealMaster = ""
   D4002.WorkOrderStatus = ""
   D4002.DateApproval = ""
   D4002.DateCancel = ""
   D4002.DateComplete = ""
   D4002.DatePending = ""
   D4002.DateDelivery = ""
   D4002.DateTransfer = ""
   D4002.DateAccept = ""
   D4002.AcceptedOrder = ""
   D4002.MaterialStatus = ""
   D4002.SoleNo = ""
   D4002.CuttingNo = ""
   D4002.StitchingNo = ""
   D4002.SubprocessNo = ""
   D4002.OutsourceNo = ""
   D4002.StockfitNo = ""
   D4002.AssemblyNo = ""
   D4002.CuttingStatus = ""
   D4002.StitchingStatus = ""
   D4002.SubprocessStatus = ""
   D4002.OutsourceStatsus = ""
   D4002.StockfitStatsus = ""
   D4002.AssemblyStatus = ""
   D4002.SoleStatus = ""
   D4002.DatePattern = ""
   D4002.DateMaterial = ""
   D4002.DatePlanning = ""
   D4002.DateRnD = ""
   D4002.DateConfirm = ""
   D4002.DateStart = ""
   D4002.DateFinish = ""
   D4002.DateSole = ""
   D4002.DateCutting = ""
   D4002.DateStitching = ""
   D4002.DateStockfit = ""
   D4002.DateAssembly = ""
   D4002.DateShipping = ""
   D4002.seUnitMaterial = ""
   D4002.cdUnitMaterial = ""
   D4002.seUnitPacking = ""
   D4002.cdUnitPacking = ""
    D4002.QtyOrder = 0 
    D4002.QtyBooking = 0 
    D4002.QtyJob = 0 
    D4002.QtyPlan = 0 
    D4002.QtySole = 0 
    D4002.QtySoleA = 0 
    D4002.QtySoleX = 0 
    D4002.QtySoleBLOut = 0 
    D4002.QtySoleBLIn = 0 
    D4002.QtyCutting = 0 
    D4002.QtyCuttingA = 0 
    D4002.QtyCuttingX = 0 
    D4002.QtyCuttingBLOut = 0 
    D4002.QtyCuttingBLIn = 0 
    D4002.QtyStitching = 0 
    D4002.QtyStitchingA = 0 
    D4002.QtyStitchingX = 0 
    D4002.QtyStitchingBLOut = 0 
    D4002.QtyStitchingBLIn = 0 
    D4002.QtyStockfit = 0 
    D4002.QtyStockfitA = 0 
    D4002.QtyStockfitX = 0 
    D4002.QtyStockfitBLOut = 0 
    D4002.QtyStockfitBLIn = 0 
    D4002.QtyAssembly = 0 
    D4002.QtyAssemblyA = 0 
    D4002.QtyAssemblyX = 0 
    D4002.QtyAssemblyBLOut = 0 
    D4002.QtyAssemblyBLIn = 0 
    D4002.QtyJobShipping = 0 
    D4002.QtyShipping = 0 
   D4002.DateInsert = ""
   D4002.InchargeInsert = ""
   D4002.DateUpdate = ""
   D4002.InchargeUpdate = ""
   D4002.InchargeSales = ""
   D4002.InchargePPC = ""
   D4002.AttachID = ""
   D4002.chkMaterial = ""
   D4002.RemarkMaterial = ""
   D4002.InchargeMaterial = ""
   D4002.DateRemarkMaterial = ""
   D4002.chkSole = ""
   D4002.RemarkSole = ""
   D4002.InchargeSole = ""
   D4002.DateRemarkSole = ""
   D4002.chkLast = ""
   D4002.RemarkLast = ""
   D4002.InchargeLast = ""
   D4002.DateRemarkLast = ""
   D4002.chkMold = ""
   D4002.RemarkMold = ""
   D4002.InchargeMold = ""
   D4002.DateRemarkMold = ""
   D4002.chkSpec = ""
   D4002.RemarkSpec = ""
   D4002.InchargeSpec = ""
   D4002.DateRemarkSpec = ""
   D4002.chkTest = ""
   D4002.RemarkTest = ""
   D4002.InchargeTest = ""
   D4002.DateRemarkTest = ""
   D4002.chkCFM = ""
   D4002.RemarkCFM = ""
   D4002.InchargeCFM = ""
   D4002.DateRemarkCFM = ""
   D4002.FactorykAllocation = ""
   D4002.LineAllocation = ""
   D4002.RemarkAllocation = ""
   D4002.RemarkOrder = ""
   D4002.RemarkCustomer = ""
   D4002.RemarkOther = ""
   D4002.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D4002_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x4002 As T4002_AREA)
Try
    
    x4002.WorkOrder = trim$(  x4002.WorkOrder)
    x4002.WorkOrderSeq = trim$(  x4002.WorkOrderSeq)
    x4002.OrderNo = trim$(  x4002.OrderNo)
    x4002.OrderNoSeq = trim$(  x4002.OrderNoSeq)
    x4002.SLNo = trim$(  x4002.SLNo)
    x4002.SealMaster = trim$(  x4002.SealMaster)
    x4002.WorkOrderStatus = trim$(  x4002.WorkOrderStatus)
    x4002.DateApproval = trim$(  x4002.DateApproval)
    x4002.DateCancel = trim$(  x4002.DateCancel)
    x4002.DateComplete = trim$(  x4002.DateComplete)
    x4002.DatePending = trim$(  x4002.DatePending)
    x4002.DateDelivery = trim$(  x4002.DateDelivery)
    x4002.DateTransfer = trim$(  x4002.DateTransfer)
    x4002.DateAccept = trim$(  x4002.DateAccept)
    x4002.AcceptedOrder = trim$(  x4002.AcceptedOrder)
    x4002.MaterialStatus = trim$(  x4002.MaterialStatus)
    x4002.SoleNo = trim$(  x4002.SoleNo)
    x4002.CuttingNo = trim$(  x4002.CuttingNo)
    x4002.StitchingNo = trim$(  x4002.StitchingNo)
    x4002.SubprocessNo = trim$(  x4002.SubprocessNo)
    x4002.OutsourceNo = trim$(  x4002.OutsourceNo)
    x4002.StockfitNo = trim$(  x4002.StockfitNo)
    x4002.AssemblyNo = trim$(  x4002.AssemblyNo)
    x4002.CuttingStatus = trim$(  x4002.CuttingStatus)
    x4002.StitchingStatus = trim$(  x4002.StitchingStatus)
    x4002.SubprocessStatus = trim$(  x4002.SubprocessStatus)
    x4002.OutsourceStatsus = trim$(  x4002.OutsourceStatsus)
    x4002.StockfitStatsus = trim$(  x4002.StockfitStatsus)
    x4002.AssemblyStatus = trim$(  x4002.AssemblyStatus)
    x4002.SoleStatus = trim$(  x4002.SoleStatus)
    x4002.DatePattern = trim$(  x4002.DatePattern)
    x4002.DateMaterial = trim$(  x4002.DateMaterial)
    x4002.DatePlanning = trim$(  x4002.DatePlanning)
    x4002.DateRnD = trim$(  x4002.DateRnD)
    x4002.DateConfirm = trim$(  x4002.DateConfirm)
    x4002.DateStart = trim$(  x4002.DateStart)
    x4002.DateFinish = trim$(  x4002.DateFinish)
    x4002.DateSole = trim$(  x4002.DateSole)
    x4002.DateCutting = trim$(  x4002.DateCutting)
    x4002.DateStitching = trim$(  x4002.DateStitching)
    x4002.DateStockfit = trim$(  x4002.DateStockfit)
    x4002.DateAssembly = trim$(  x4002.DateAssembly)
    x4002.DateShipping = trim$(  x4002.DateShipping)
    x4002.seUnitMaterial = trim$(  x4002.seUnitMaterial)
    x4002.cdUnitMaterial = trim$(  x4002.cdUnitMaterial)
    x4002.seUnitPacking = trim$(  x4002.seUnitPacking)
    x4002.cdUnitPacking = trim$(  x4002.cdUnitPacking)
    x4002.QtyOrder = trim$(  x4002.QtyOrder)
    x4002.QtyBooking = trim$(  x4002.QtyBooking)
    x4002.QtyJob = trim$(  x4002.QtyJob)
    x4002.QtyPlan = trim$(  x4002.QtyPlan)
    x4002.QtySole = trim$(  x4002.QtySole)
    x4002.QtySoleA = trim$(  x4002.QtySoleA)
    x4002.QtySoleX = trim$(  x4002.QtySoleX)
    x4002.QtySoleBLOut = trim$(  x4002.QtySoleBLOut)
    x4002.QtySoleBLIn = trim$(  x4002.QtySoleBLIn)
    x4002.QtyCutting = trim$(  x4002.QtyCutting)
    x4002.QtyCuttingA = trim$(  x4002.QtyCuttingA)
    x4002.QtyCuttingX = trim$(  x4002.QtyCuttingX)
    x4002.QtyCuttingBLOut = trim$(  x4002.QtyCuttingBLOut)
    x4002.QtyCuttingBLIn = trim$(  x4002.QtyCuttingBLIn)
    x4002.QtyStitching = trim$(  x4002.QtyStitching)
    x4002.QtyStitchingA = trim$(  x4002.QtyStitchingA)
    x4002.QtyStitchingX = trim$(  x4002.QtyStitchingX)
    x4002.QtyStitchingBLOut = trim$(  x4002.QtyStitchingBLOut)
    x4002.QtyStitchingBLIn = trim$(  x4002.QtyStitchingBLIn)
    x4002.QtyStockfit = trim$(  x4002.QtyStockfit)
    x4002.QtyStockfitA = trim$(  x4002.QtyStockfitA)
    x4002.QtyStockfitX = trim$(  x4002.QtyStockfitX)
    x4002.QtyStockfitBLOut = trim$(  x4002.QtyStockfitBLOut)
    x4002.QtyStockfitBLIn = trim$(  x4002.QtyStockfitBLIn)
    x4002.QtyAssembly = trim$(  x4002.QtyAssembly)
    x4002.QtyAssemblyA = trim$(  x4002.QtyAssemblyA)
    x4002.QtyAssemblyX = trim$(  x4002.QtyAssemblyX)
    x4002.QtyAssemblyBLOut = trim$(  x4002.QtyAssemblyBLOut)
    x4002.QtyAssemblyBLIn = trim$(  x4002.QtyAssemblyBLIn)
    x4002.QtyJobShipping = trim$(  x4002.QtyJobShipping)
    x4002.QtyShipping = trim$(  x4002.QtyShipping)
    x4002.DateInsert = trim$(  x4002.DateInsert)
    x4002.InchargeInsert = trim$(  x4002.InchargeInsert)
    x4002.DateUpdate = trim$(  x4002.DateUpdate)
    x4002.InchargeUpdate = trim$(  x4002.InchargeUpdate)
    x4002.InchargeSales = trim$(  x4002.InchargeSales)
    x4002.InchargePPC = trim$(  x4002.InchargePPC)
    x4002.AttachID = trim$(  x4002.AttachID)
    x4002.chkMaterial = trim$(  x4002.chkMaterial)
    x4002.RemarkMaterial = trim$(  x4002.RemarkMaterial)
    x4002.InchargeMaterial = trim$(  x4002.InchargeMaterial)
    x4002.DateRemarkMaterial = trim$(  x4002.DateRemarkMaterial)
    x4002.chkSole = trim$(  x4002.chkSole)
    x4002.RemarkSole = trim$(  x4002.RemarkSole)
    x4002.InchargeSole = trim$(  x4002.InchargeSole)
    x4002.DateRemarkSole = trim$(  x4002.DateRemarkSole)
    x4002.chkLast = trim$(  x4002.chkLast)
    x4002.RemarkLast = trim$(  x4002.RemarkLast)
    x4002.InchargeLast = trim$(  x4002.InchargeLast)
    x4002.DateRemarkLast = trim$(  x4002.DateRemarkLast)
    x4002.chkMold = trim$(  x4002.chkMold)
    x4002.RemarkMold = trim$(  x4002.RemarkMold)
    x4002.InchargeMold = trim$(  x4002.InchargeMold)
    x4002.DateRemarkMold = trim$(  x4002.DateRemarkMold)
    x4002.chkSpec = trim$(  x4002.chkSpec)
    x4002.RemarkSpec = trim$(  x4002.RemarkSpec)
    x4002.InchargeSpec = trim$(  x4002.InchargeSpec)
    x4002.DateRemarkSpec = trim$(  x4002.DateRemarkSpec)
    x4002.chkTest = trim$(  x4002.chkTest)
    x4002.RemarkTest = trim$(  x4002.RemarkTest)
    x4002.InchargeTest = trim$(  x4002.InchargeTest)
    x4002.DateRemarkTest = trim$(  x4002.DateRemarkTest)
    x4002.chkCFM = trim$(  x4002.chkCFM)
    x4002.RemarkCFM = trim$(  x4002.RemarkCFM)
    x4002.InchargeCFM = trim$(  x4002.InchargeCFM)
    x4002.DateRemarkCFM = trim$(  x4002.DateRemarkCFM)
    x4002.FactorykAllocation = trim$(  x4002.FactorykAllocation)
    x4002.LineAllocation = trim$(  x4002.LineAllocation)
    x4002.RemarkAllocation = trim$(  x4002.RemarkAllocation)
    x4002.RemarkOrder = trim$(  x4002.RemarkOrder)
    x4002.RemarkCustomer = trim$(  x4002.RemarkCustomer)
    x4002.RemarkOther = trim$(  x4002.RemarkOther)
    x4002.Remark = trim$(  x4002.Remark)
     
    If trim$( x4002.WorkOrder ) = "" Then x4002.WorkOrder = Space(1) 
    If trim$( x4002.WorkOrderSeq ) = "" Then x4002.WorkOrderSeq = Space(1) 
    If trim$( x4002.OrderNo ) = "" Then x4002.OrderNo = Space(1) 
    If trim$( x4002.OrderNoSeq ) = "" Then x4002.OrderNoSeq = Space(1) 
    If trim$( x4002.SLNo ) = "" Then x4002.SLNo = Space(1) 
    If trim$( x4002.SealMaster ) = "" Then x4002.SealMaster = Space(1) 
    If trim$( x4002.WorkOrderStatus ) = "" Then x4002.WorkOrderStatus = Space(1) 
    If trim$( x4002.DateApproval ) = "" Then x4002.DateApproval = Space(1) 
    If trim$( x4002.DateCancel ) = "" Then x4002.DateCancel = Space(1) 
    If trim$( x4002.DateComplete ) = "" Then x4002.DateComplete = Space(1) 
    If trim$( x4002.DatePending ) = "" Then x4002.DatePending = Space(1) 
    If trim$( x4002.DateDelivery ) = "" Then x4002.DateDelivery = Space(1) 
    If trim$( x4002.DateTransfer ) = "" Then x4002.DateTransfer = Space(1) 
    If trim$( x4002.DateAccept ) = "" Then x4002.DateAccept = Space(1) 
    If trim$( x4002.AcceptedOrder ) = "" Then x4002.AcceptedOrder = Space(1) 
    If trim$( x4002.MaterialStatus ) = "" Then x4002.MaterialStatus = Space(1) 
    If trim$( x4002.SoleNo ) = "" Then x4002.SoleNo = Space(1) 
    If trim$( x4002.CuttingNo ) = "" Then x4002.CuttingNo = Space(1) 
    If trim$( x4002.StitchingNo ) = "" Then x4002.StitchingNo = Space(1) 
    If trim$( x4002.SubprocessNo ) = "" Then x4002.SubprocessNo = Space(1) 
    If trim$( x4002.OutsourceNo ) = "" Then x4002.OutsourceNo = Space(1) 
    If trim$( x4002.StockfitNo ) = "" Then x4002.StockfitNo = Space(1) 
    If trim$( x4002.AssemblyNo ) = "" Then x4002.AssemblyNo = Space(1) 
    If trim$( x4002.CuttingStatus ) = "" Then x4002.CuttingStatus = Space(1) 
    If trim$( x4002.StitchingStatus ) = "" Then x4002.StitchingStatus = Space(1) 
    If trim$( x4002.SubprocessStatus ) = "" Then x4002.SubprocessStatus = Space(1) 
    If trim$( x4002.OutsourceStatsus ) = "" Then x4002.OutsourceStatsus = Space(1) 
    If trim$( x4002.StockfitStatsus ) = "" Then x4002.StockfitStatsus = Space(1) 
    If trim$( x4002.AssemblyStatus ) = "" Then x4002.AssemblyStatus = Space(1) 
    If trim$( x4002.SoleStatus ) = "" Then x4002.SoleStatus = Space(1) 
    If trim$( x4002.DatePattern ) = "" Then x4002.DatePattern = Space(1) 
    If trim$( x4002.DateMaterial ) = "" Then x4002.DateMaterial = Space(1) 
    If trim$( x4002.DatePlanning ) = "" Then x4002.DatePlanning = Space(1) 
    If trim$( x4002.DateRnD ) = "" Then x4002.DateRnD = Space(1) 
    If trim$( x4002.DateConfirm ) = "" Then x4002.DateConfirm = Space(1) 
    If trim$( x4002.DateStart ) = "" Then x4002.DateStart = Space(1) 
    If trim$( x4002.DateFinish ) = "" Then x4002.DateFinish = Space(1) 
    If trim$( x4002.DateSole ) = "" Then x4002.DateSole = Space(1) 
    If trim$( x4002.DateCutting ) = "" Then x4002.DateCutting = Space(1) 
    If trim$( x4002.DateStitching ) = "" Then x4002.DateStitching = Space(1) 
    If trim$( x4002.DateStockfit ) = "" Then x4002.DateStockfit = Space(1) 
    If trim$( x4002.DateAssembly ) = "" Then x4002.DateAssembly = Space(1) 
    If trim$( x4002.DateShipping ) = "" Then x4002.DateShipping = Space(1) 
    If trim$( x4002.seUnitMaterial ) = "" Then x4002.seUnitMaterial = Space(1) 
    If trim$( x4002.cdUnitMaterial ) = "" Then x4002.cdUnitMaterial = Space(1) 
    If trim$( x4002.seUnitPacking ) = "" Then x4002.seUnitPacking = Space(1) 
    If trim$( x4002.cdUnitPacking ) = "" Then x4002.cdUnitPacking = Space(1) 
    If trim$( x4002.QtyOrder ) = "" Then x4002.QtyOrder = 0 
    If trim$( x4002.QtyBooking ) = "" Then x4002.QtyBooking = 0 
    If trim$( x4002.QtyJob ) = "" Then x4002.QtyJob = 0 
    If trim$( x4002.QtyPlan ) = "" Then x4002.QtyPlan = 0 
    If trim$( x4002.QtySole ) = "" Then x4002.QtySole = 0 
    If trim$( x4002.QtySoleA ) = "" Then x4002.QtySoleA = 0 
    If trim$( x4002.QtySoleX ) = "" Then x4002.QtySoleX = 0 
    If trim$( x4002.QtySoleBLOut ) = "" Then x4002.QtySoleBLOut = 0 
    If trim$( x4002.QtySoleBLIn ) = "" Then x4002.QtySoleBLIn = 0 
    If trim$( x4002.QtyCutting ) = "" Then x4002.QtyCutting = 0 
    If trim$( x4002.QtyCuttingA ) = "" Then x4002.QtyCuttingA = 0 
    If trim$( x4002.QtyCuttingX ) = "" Then x4002.QtyCuttingX = 0 
    If trim$( x4002.QtyCuttingBLOut ) = "" Then x4002.QtyCuttingBLOut = 0 
    If trim$( x4002.QtyCuttingBLIn ) = "" Then x4002.QtyCuttingBLIn = 0 
    If trim$( x4002.QtyStitching ) = "" Then x4002.QtyStitching = 0 
    If trim$( x4002.QtyStitchingA ) = "" Then x4002.QtyStitchingA = 0 
    If trim$( x4002.QtyStitchingX ) = "" Then x4002.QtyStitchingX = 0 
    If trim$( x4002.QtyStitchingBLOut ) = "" Then x4002.QtyStitchingBLOut = 0 
    If trim$( x4002.QtyStitchingBLIn ) = "" Then x4002.QtyStitchingBLIn = 0 
    If trim$( x4002.QtyStockfit ) = "" Then x4002.QtyStockfit = 0 
    If trim$( x4002.QtyStockfitA ) = "" Then x4002.QtyStockfitA = 0 
    If trim$( x4002.QtyStockfitX ) = "" Then x4002.QtyStockfitX = 0 
    If trim$( x4002.QtyStockfitBLOut ) = "" Then x4002.QtyStockfitBLOut = 0 
    If trim$( x4002.QtyStockfitBLIn ) = "" Then x4002.QtyStockfitBLIn = 0 
    If trim$( x4002.QtyAssembly ) = "" Then x4002.QtyAssembly = 0 
    If trim$( x4002.QtyAssemblyA ) = "" Then x4002.QtyAssemblyA = 0 
    If trim$( x4002.QtyAssemblyX ) = "" Then x4002.QtyAssemblyX = 0 
    If trim$( x4002.QtyAssemblyBLOut ) = "" Then x4002.QtyAssemblyBLOut = 0 
    If trim$( x4002.QtyAssemblyBLIn ) = "" Then x4002.QtyAssemblyBLIn = 0 
    If trim$( x4002.QtyJobShipping ) = "" Then x4002.QtyJobShipping = 0 
    If trim$( x4002.QtyShipping ) = "" Then x4002.QtyShipping = 0 
    If trim$( x4002.DateInsert ) = "" Then x4002.DateInsert = Space(1) 
    If trim$( x4002.InchargeInsert ) = "" Then x4002.InchargeInsert = Space(1) 
    If trim$( x4002.DateUpdate ) = "" Then x4002.DateUpdate = Space(1) 
    If trim$( x4002.InchargeUpdate ) = "" Then x4002.InchargeUpdate = Space(1) 
    If trim$( x4002.InchargeSales ) = "" Then x4002.InchargeSales = Space(1) 
    If trim$( x4002.InchargePPC ) = "" Then x4002.InchargePPC = Space(1) 
    If trim$( x4002.AttachID ) = "" Then x4002.AttachID = Space(1) 
    If trim$( x4002.chkMaterial ) = "" Then x4002.chkMaterial = Space(1) 
    If trim$( x4002.RemarkMaterial ) = "" Then x4002.RemarkMaterial = Space(1) 
    If trim$( x4002.InchargeMaterial ) = "" Then x4002.InchargeMaterial = Space(1) 
    If trim$( x4002.DateRemarkMaterial ) = "" Then x4002.DateRemarkMaterial = Space(1) 
    If trim$( x4002.chkSole ) = "" Then x4002.chkSole = Space(1) 
    If trim$( x4002.RemarkSole ) = "" Then x4002.RemarkSole = Space(1) 
    If trim$( x4002.InchargeSole ) = "" Then x4002.InchargeSole = Space(1) 
    If trim$( x4002.DateRemarkSole ) = "" Then x4002.DateRemarkSole = Space(1) 
    If trim$( x4002.chkLast ) = "" Then x4002.chkLast = Space(1) 
    If trim$( x4002.RemarkLast ) = "" Then x4002.RemarkLast = Space(1) 
    If trim$( x4002.InchargeLast ) = "" Then x4002.InchargeLast = Space(1) 
    If trim$( x4002.DateRemarkLast ) = "" Then x4002.DateRemarkLast = Space(1) 
    If trim$( x4002.chkMold ) = "" Then x4002.chkMold = Space(1) 
    If trim$( x4002.RemarkMold ) = "" Then x4002.RemarkMold = Space(1) 
    If trim$( x4002.InchargeMold ) = "" Then x4002.InchargeMold = Space(1) 
    If trim$( x4002.DateRemarkMold ) = "" Then x4002.DateRemarkMold = Space(1) 
    If trim$( x4002.chkSpec ) = "" Then x4002.chkSpec = Space(1) 
    If trim$( x4002.RemarkSpec ) = "" Then x4002.RemarkSpec = Space(1) 
    If trim$( x4002.InchargeSpec ) = "" Then x4002.InchargeSpec = Space(1) 
    If trim$( x4002.DateRemarkSpec ) = "" Then x4002.DateRemarkSpec = Space(1) 
    If trim$( x4002.chkTest ) = "" Then x4002.chkTest = Space(1) 
    If trim$( x4002.RemarkTest ) = "" Then x4002.RemarkTest = Space(1) 
    If trim$( x4002.InchargeTest ) = "" Then x4002.InchargeTest = Space(1) 
    If trim$( x4002.DateRemarkTest ) = "" Then x4002.DateRemarkTest = Space(1) 
    If trim$( x4002.chkCFM ) = "" Then x4002.chkCFM = Space(1) 
    If trim$( x4002.RemarkCFM ) = "" Then x4002.RemarkCFM = Space(1) 
    If trim$( x4002.InchargeCFM ) = "" Then x4002.InchargeCFM = Space(1) 
    If trim$( x4002.DateRemarkCFM ) = "" Then x4002.DateRemarkCFM = Space(1) 
    If trim$( x4002.FactorykAllocation ) = "" Then x4002.FactorykAllocation = Space(1) 
    If trim$( x4002.LineAllocation ) = "" Then x4002.LineAllocation = Space(1) 
    If trim$( x4002.RemarkAllocation ) = "" Then x4002.RemarkAllocation = Space(1) 
    If trim$( x4002.RemarkOrder ) = "" Then x4002.RemarkOrder = Space(1) 
    If trim$( x4002.RemarkCustomer ) = "" Then x4002.RemarkCustomer = Space(1) 
    If trim$( x4002.RemarkOther ) = "" Then x4002.RemarkOther = Space(1) 
    If trim$( x4002.Remark ) = "" Then x4002.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K4002_MOVE(rs4002 As SqlClient.SqlDataReader)
Try

    call D4002_CLEAR()   

    If IsdbNull(rs4002!K4002_WorkOrder) = False Then D4002.WorkOrder = Trim$(rs4002!K4002_WorkOrder)
    If IsdbNull(rs4002!K4002_WorkOrderSeq) = False Then D4002.WorkOrderSeq = Trim$(rs4002!K4002_WorkOrderSeq)
    If IsdbNull(rs4002!K4002_OrderNo) = False Then D4002.OrderNo = Trim$(rs4002!K4002_OrderNo)
    If IsdbNull(rs4002!K4002_OrderNoSeq) = False Then D4002.OrderNoSeq = Trim$(rs4002!K4002_OrderNoSeq)
    If IsdbNull(rs4002!K4002_SLNo) = False Then D4002.SLNo = Trim$(rs4002!K4002_SLNo)
    If IsdbNull(rs4002!K4002_SealMaster) = False Then D4002.SealMaster = Trim$(rs4002!K4002_SealMaster)
    If IsdbNull(rs4002!K4002_WorkOrderStatus) = False Then D4002.WorkOrderStatus = Trim$(rs4002!K4002_WorkOrderStatus)
    If IsdbNull(rs4002!K4002_DateApproval) = False Then D4002.DateApproval = Trim$(rs4002!K4002_DateApproval)
    If IsdbNull(rs4002!K4002_DateCancel) = False Then D4002.DateCancel = Trim$(rs4002!K4002_DateCancel)
    If IsdbNull(rs4002!K4002_DateComplete) = False Then D4002.DateComplete = Trim$(rs4002!K4002_DateComplete)
    If IsdbNull(rs4002!K4002_DatePending) = False Then D4002.DatePending = Trim$(rs4002!K4002_DatePending)
    If IsdbNull(rs4002!K4002_DateDelivery) = False Then D4002.DateDelivery = Trim$(rs4002!K4002_DateDelivery)
    If IsdbNull(rs4002!K4002_DateTransfer) = False Then D4002.DateTransfer = Trim$(rs4002!K4002_DateTransfer)
    If IsdbNull(rs4002!K4002_DateAccept) = False Then D4002.DateAccept = Trim$(rs4002!K4002_DateAccept)
    If IsdbNull(rs4002!K4002_AcceptedOrder) = False Then D4002.AcceptedOrder = Trim$(rs4002!K4002_AcceptedOrder)
    If IsdbNull(rs4002!K4002_MaterialStatus) = False Then D4002.MaterialStatus = Trim$(rs4002!K4002_MaterialStatus)
    If IsdbNull(rs4002!K4002_SoleNo) = False Then D4002.SoleNo = Trim$(rs4002!K4002_SoleNo)
    If IsdbNull(rs4002!K4002_CuttingNo) = False Then D4002.CuttingNo = Trim$(rs4002!K4002_CuttingNo)
    If IsdbNull(rs4002!K4002_StitchingNo) = False Then D4002.StitchingNo = Trim$(rs4002!K4002_StitchingNo)
    If IsdbNull(rs4002!K4002_SubprocessNo) = False Then D4002.SubprocessNo = Trim$(rs4002!K4002_SubprocessNo)
    If IsdbNull(rs4002!K4002_OutsourceNo) = False Then D4002.OutsourceNo = Trim$(rs4002!K4002_OutsourceNo)
    If IsdbNull(rs4002!K4002_StockfitNo) = False Then D4002.StockfitNo = Trim$(rs4002!K4002_StockfitNo)
    If IsdbNull(rs4002!K4002_AssemblyNo) = False Then D4002.AssemblyNo = Trim$(rs4002!K4002_AssemblyNo)
    If IsdbNull(rs4002!K4002_CuttingStatus) = False Then D4002.CuttingStatus = Trim$(rs4002!K4002_CuttingStatus)
    If IsdbNull(rs4002!K4002_StitchingStatus) = False Then D4002.StitchingStatus = Trim$(rs4002!K4002_StitchingStatus)
    If IsdbNull(rs4002!K4002_SubprocessStatus) = False Then D4002.SubprocessStatus = Trim$(rs4002!K4002_SubprocessStatus)
    If IsdbNull(rs4002!K4002_OutsourceStatsus) = False Then D4002.OutsourceStatsus = Trim$(rs4002!K4002_OutsourceStatsus)
    If IsdbNull(rs4002!K4002_StockfitStatsus) = False Then D4002.StockfitStatsus = Trim$(rs4002!K4002_StockfitStatsus)
    If IsdbNull(rs4002!K4002_AssemblyStatus) = False Then D4002.AssemblyStatus = Trim$(rs4002!K4002_AssemblyStatus)
    If IsdbNull(rs4002!K4002_SoleStatus) = False Then D4002.SoleStatus = Trim$(rs4002!K4002_SoleStatus)
    If IsdbNull(rs4002!K4002_DatePattern) = False Then D4002.DatePattern = Trim$(rs4002!K4002_DatePattern)
    If IsdbNull(rs4002!K4002_DateMaterial) = False Then D4002.DateMaterial = Trim$(rs4002!K4002_DateMaterial)
    If IsdbNull(rs4002!K4002_DatePlanning) = False Then D4002.DatePlanning = Trim$(rs4002!K4002_DatePlanning)
    If IsdbNull(rs4002!K4002_DateRnD) = False Then D4002.DateRnD = Trim$(rs4002!K4002_DateRnD)
    If IsdbNull(rs4002!K4002_DateConfirm) = False Then D4002.DateConfirm = Trim$(rs4002!K4002_DateConfirm)
    If IsdbNull(rs4002!K4002_DateStart) = False Then D4002.DateStart = Trim$(rs4002!K4002_DateStart)
    If IsdbNull(rs4002!K4002_DateFinish) = False Then D4002.DateFinish = Trim$(rs4002!K4002_DateFinish)
    If IsdbNull(rs4002!K4002_DateSole) = False Then D4002.DateSole = Trim$(rs4002!K4002_DateSole)
    If IsdbNull(rs4002!K4002_DateCutting) = False Then D4002.DateCutting = Trim$(rs4002!K4002_DateCutting)
    If IsdbNull(rs4002!K4002_DateStitching) = False Then D4002.DateStitching = Trim$(rs4002!K4002_DateStitching)
    If IsdbNull(rs4002!K4002_DateStockfit) = False Then D4002.DateStockfit = Trim$(rs4002!K4002_DateStockfit)
    If IsdbNull(rs4002!K4002_DateAssembly) = False Then D4002.DateAssembly = Trim$(rs4002!K4002_DateAssembly)
    If IsdbNull(rs4002!K4002_DateShipping) = False Then D4002.DateShipping = Trim$(rs4002!K4002_DateShipping)
    If IsdbNull(rs4002!K4002_seUnitMaterial) = False Then D4002.seUnitMaterial = Trim$(rs4002!K4002_seUnitMaterial)
    If IsdbNull(rs4002!K4002_cdUnitMaterial) = False Then D4002.cdUnitMaterial = Trim$(rs4002!K4002_cdUnitMaterial)
    If IsdbNull(rs4002!K4002_seUnitPacking) = False Then D4002.seUnitPacking = Trim$(rs4002!K4002_seUnitPacking)
    If IsdbNull(rs4002!K4002_cdUnitPacking) = False Then D4002.cdUnitPacking = Trim$(rs4002!K4002_cdUnitPacking)
    If IsdbNull(rs4002!K4002_QtyOrder) = False Then D4002.QtyOrder = Trim$(rs4002!K4002_QtyOrder)
    If IsdbNull(rs4002!K4002_QtyBooking) = False Then D4002.QtyBooking = Trim$(rs4002!K4002_QtyBooking)
    If IsdbNull(rs4002!K4002_QtyJob) = False Then D4002.QtyJob = Trim$(rs4002!K4002_QtyJob)
    If IsdbNull(rs4002!K4002_QtyPlan) = False Then D4002.QtyPlan = Trim$(rs4002!K4002_QtyPlan)
    If IsdbNull(rs4002!K4002_QtySole) = False Then D4002.QtySole = Trim$(rs4002!K4002_QtySole)
    If IsdbNull(rs4002!K4002_QtySoleA) = False Then D4002.QtySoleA = Trim$(rs4002!K4002_QtySoleA)
    If IsdbNull(rs4002!K4002_QtySoleX) = False Then D4002.QtySoleX = Trim$(rs4002!K4002_QtySoleX)
    If IsdbNull(rs4002!K4002_QtySoleBLOut) = False Then D4002.QtySoleBLOut = Trim$(rs4002!K4002_QtySoleBLOut)
    If IsdbNull(rs4002!K4002_QtySoleBLIn) = False Then D4002.QtySoleBLIn = Trim$(rs4002!K4002_QtySoleBLIn)
    If IsdbNull(rs4002!K4002_QtyCutting) = False Then D4002.QtyCutting = Trim$(rs4002!K4002_QtyCutting)
    If IsdbNull(rs4002!K4002_QtyCuttingA) = False Then D4002.QtyCuttingA = Trim$(rs4002!K4002_QtyCuttingA)
    If IsdbNull(rs4002!K4002_QtyCuttingX) = False Then D4002.QtyCuttingX = Trim$(rs4002!K4002_QtyCuttingX)
    If IsdbNull(rs4002!K4002_QtyCuttingBLOut) = False Then D4002.QtyCuttingBLOut = Trim$(rs4002!K4002_QtyCuttingBLOut)
    If IsdbNull(rs4002!K4002_QtyCuttingBLIn) = False Then D4002.QtyCuttingBLIn = Trim$(rs4002!K4002_QtyCuttingBLIn)
    If IsdbNull(rs4002!K4002_QtyStitching) = False Then D4002.QtyStitching = Trim$(rs4002!K4002_QtyStitching)
    If IsdbNull(rs4002!K4002_QtyStitchingA) = False Then D4002.QtyStitchingA = Trim$(rs4002!K4002_QtyStitchingA)
    If IsdbNull(rs4002!K4002_QtyStitchingX) = False Then D4002.QtyStitchingX = Trim$(rs4002!K4002_QtyStitchingX)
    If IsdbNull(rs4002!K4002_QtyStitchingBLOut) = False Then D4002.QtyStitchingBLOut = Trim$(rs4002!K4002_QtyStitchingBLOut)
    If IsdbNull(rs4002!K4002_QtyStitchingBLIn) = False Then D4002.QtyStitchingBLIn = Trim$(rs4002!K4002_QtyStitchingBLIn)
    If IsdbNull(rs4002!K4002_QtyStockfit) = False Then D4002.QtyStockfit = Trim$(rs4002!K4002_QtyStockfit)
    If IsdbNull(rs4002!K4002_QtyStockfitA) = False Then D4002.QtyStockfitA = Trim$(rs4002!K4002_QtyStockfitA)
    If IsdbNull(rs4002!K4002_QtyStockfitX) = False Then D4002.QtyStockfitX = Trim$(rs4002!K4002_QtyStockfitX)
    If IsdbNull(rs4002!K4002_QtyStockfitBLOut) = False Then D4002.QtyStockfitBLOut = Trim$(rs4002!K4002_QtyStockfitBLOut)
    If IsdbNull(rs4002!K4002_QtyStockfitBLIn) = False Then D4002.QtyStockfitBLIn = Trim$(rs4002!K4002_QtyStockfitBLIn)
    If IsdbNull(rs4002!K4002_QtyAssembly) = False Then D4002.QtyAssembly = Trim$(rs4002!K4002_QtyAssembly)
    If IsdbNull(rs4002!K4002_QtyAssemblyA) = False Then D4002.QtyAssemblyA = Trim$(rs4002!K4002_QtyAssemblyA)
    If IsdbNull(rs4002!K4002_QtyAssemblyX) = False Then D4002.QtyAssemblyX = Trim$(rs4002!K4002_QtyAssemblyX)
    If IsdbNull(rs4002!K4002_QtyAssemblyBLOut) = False Then D4002.QtyAssemblyBLOut = Trim$(rs4002!K4002_QtyAssemblyBLOut)
    If IsdbNull(rs4002!K4002_QtyAssemblyBLIn) = False Then D4002.QtyAssemblyBLIn = Trim$(rs4002!K4002_QtyAssemblyBLIn)
    If IsdbNull(rs4002!K4002_QtyJobShipping) = False Then D4002.QtyJobShipping = Trim$(rs4002!K4002_QtyJobShipping)
    If IsdbNull(rs4002!K4002_QtyShipping) = False Then D4002.QtyShipping = Trim$(rs4002!K4002_QtyShipping)
    If IsdbNull(rs4002!K4002_DateInsert) = False Then D4002.DateInsert = Trim$(rs4002!K4002_DateInsert)
    If IsdbNull(rs4002!K4002_InchargeInsert) = False Then D4002.InchargeInsert = Trim$(rs4002!K4002_InchargeInsert)
    If IsdbNull(rs4002!K4002_DateUpdate) = False Then D4002.DateUpdate = Trim$(rs4002!K4002_DateUpdate)
    If IsdbNull(rs4002!K4002_InchargeUpdate) = False Then D4002.InchargeUpdate = Trim$(rs4002!K4002_InchargeUpdate)
    If IsdbNull(rs4002!K4002_InchargeSales) = False Then D4002.InchargeSales = Trim$(rs4002!K4002_InchargeSales)
    If IsdbNull(rs4002!K4002_InchargePPC) = False Then D4002.InchargePPC = Trim$(rs4002!K4002_InchargePPC)
    If IsdbNull(rs4002!K4002_AttachID) = False Then D4002.AttachID = Trim$(rs4002!K4002_AttachID)
    If IsdbNull(rs4002!K4002_chkMaterial) = False Then D4002.chkMaterial = Trim$(rs4002!K4002_chkMaterial)
    If IsdbNull(rs4002!K4002_RemarkMaterial) = False Then D4002.RemarkMaterial = Trim$(rs4002!K4002_RemarkMaterial)
    If IsdbNull(rs4002!K4002_InchargeMaterial) = False Then D4002.InchargeMaterial = Trim$(rs4002!K4002_InchargeMaterial)
    If IsdbNull(rs4002!K4002_DateRemarkMaterial) = False Then D4002.DateRemarkMaterial = Trim$(rs4002!K4002_DateRemarkMaterial)
    If IsdbNull(rs4002!K4002_chkSole) = False Then D4002.chkSole = Trim$(rs4002!K4002_chkSole)
    If IsdbNull(rs4002!K4002_RemarkSole) = False Then D4002.RemarkSole = Trim$(rs4002!K4002_RemarkSole)
    If IsdbNull(rs4002!K4002_InchargeSole) = False Then D4002.InchargeSole = Trim$(rs4002!K4002_InchargeSole)
    If IsdbNull(rs4002!K4002_DateRemarkSole) = False Then D4002.DateRemarkSole = Trim$(rs4002!K4002_DateRemarkSole)
    If IsdbNull(rs4002!K4002_chkLast) = False Then D4002.chkLast = Trim$(rs4002!K4002_chkLast)
    If IsdbNull(rs4002!K4002_RemarkLast) = False Then D4002.RemarkLast = Trim$(rs4002!K4002_RemarkLast)
    If IsdbNull(rs4002!K4002_InchargeLast) = False Then D4002.InchargeLast = Trim$(rs4002!K4002_InchargeLast)
    If IsdbNull(rs4002!K4002_DateRemarkLast) = False Then D4002.DateRemarkLast = Trim$(rs4002!K4002_DateRemarkLast)
    If IsdbNull(rs4002!K4002_chkMold) = False Then D4002.chkMold = Trim$(rs4002!K4002_chkMold)
    If IsdbNull(rs4002!K4002_RemarkMold) = False Then D4002.RemarkMold = Trim$(rs4002!K4002_RemarkMold)
    If IsdbNull(rs4002!K4002_InchargeMold) = False Then D4002.InchargeMold = Trim$(rs4002!K4002_InchargeMold)
    If IsdbNull(rs4002!K4002_DateRemarkMold) = False Then D4002.DateRemarkMold = Trim$(rs4002!K4002_DateRemarkMold)
    If IsdbNull(rs4002!K4002_chkSpec) = False Then D4002.chkSpec = Trim$(rs4002!K4002_chkSpec)
    If IsdbNull(rs4002!K4002_RemarkSpec) = False Then D4002.RemarkSpec = Trim$(rs4002!K4002_RemarkSpec)
    If IsdbNull(rs4002!K4002_InchargeSpec) = False Then D4002.InchargeSpec = Trim$(rs4002!K4002_InchargeSpec)
    If IsdbNull(rs4002!K4002_DateRemarkSpec) = False Then D4002.DateRemarkSpec = Trim$(rs4002!K4002_DateRemarkSpec)
    If IsdbNull(rs4002!K4002_chkTest) = False Then D4002.chkTest = Trim$(rs4002!K4002_chkTest)
    If IsdbNull(rs4002!K4002_RemarkTest) = False Then D4002.RemarkTest = Trim$(rs4002!K4002_RemarkTest)
    If IsdbNull(rs4002!K4002_InchargeTest) = False Then D4002.InchargeTest = Trim$(rs4002!K4002_InchargeTest)
    If IsdbNull(rs4002!K4002_DateRemarkTest) = False Then D4002.DateRemarkTest = Trim$(rs4002!K4002_DateRemarkTest)
    If IsdbNull(rs4002!K4002_chkCFM) = False Then D4002.chkCFM = Trim$(rs4002!K4002_chkCFM)
    If IsdbNull(rs4002!K4002_RemarkCFM) = False Then D4002.RemarkCFM = Trim$(rs4002!K4002_RemarkCFM)
    If IsdbNull(rs4002!K4002_InchargeCFM) = False Then D4002.InchargeCFM = Trim$(rs4002!K4002_InchargeCFM)
    If IsdbNull(rs4002!K4002_DateRemarkCFM) = False Then D4002.DateRemarkCFM = Trim$(rs4002!K4002_DateRemarkCFM)
    If IsdbNull(rs4002!K4002_FactorykAllocation) = False Then D4002.FactorykAllocation = Trim$(rs4002!K4002_FactorykAllocation)
    If IsdbNull(rs4002!K4002_LineAllocation) = False Then D4002.LineAllocation = Trim$(rs4002!K4002_LineAllocation)
    If IsdbNull(rs4002!K4002_RemarkAllocation) = False Then D4002.RemarkAllocation = Trim$(rs4002!K4002_RemarkAllocation)
    If IsdbNull(rs4002!K4002_RemarkOrder) = False Then D4002.RemarkOrder = Trim$(rs4002!K4002_RemarkOrder)
    If IsdbNull(rs4002!K4002_RemarkCustomer) = False Then D4002.RemarkCustomer = Trim$(rs4002!K4002_RemarkCustomer)
    If IsdbNull(rs4002!K4002_RemarkOther) = False Then D4002.RemarkOther = Trim$(rs4002!K4002_RemarkOther)
    If IsdbNull(rs4002!K4002_Remark) = False Then D4002.Remark = Trim$(rs4002!K4002_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K4002_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K4002_MOVE(rs4002 As DataRow)
Try

    call D4002_CLEAR()   

    If IsdbNull(rs4002!K4002_WorkOrder) = False Then D4002.WorkOrder = Trim$(rs4002!K4002_WorkOrder)
    If IsdbNull(rs4002!K4002_WorkOrderSeq) = False Then D4002.WorkOrderSeq = Trim$(rs4002!K4002_WorkOrderSeq)
    If IsdbNull(rs4002!K4002_OrderNo) = False Then D4002.OrderNo = Trim$(rs4002!K4002_OrderNo)
    If IsdbNull(rs4002!K4002_OrderNoSeq) = False Then D4002.OrderNoSeq = Trim$(rs4002!K4002_OrderNoSeq)
    If IsdbNull(rs4002!K4002_SLNo) = False Then D4002.SLNo = Trim$(rs4002!K4002_SLNo)
    If IsdbNull(rs4002!K4002_SealMaster) = False Then D4002.SealMaster = Trim$(rs4002!K4002_SealMaster)
    If IsdbNull(rs4002!K4002_WorkOrderStatus) = False Then D4002.WorkOrderStatus = Trim$(rs4002!K4002_WorkOrderStatus)
    If IsdbNull(rs4002!K4002_DateApproval) = False Then D4002.DateApproval = Trim$(rs4002!K4002_DateApproval)
    If IsdbNull(rs4002!K4002_DateCancel) = False Then D4002.DateCancel = Trim$(rs4002!K4002_DateCancel)
    If IsdbNull(rs4002!K4002_DateComplete) = False Then D4002.DateComplete = Trim$(rs4002!K4002_DateComplete)
    If IsdbNull(rs4002!K4002_DatePending) = False Then D4002.DatePending = Trim$(rs4002!K4002_DatePending)
    If IsdbNull(rs4002!K4002_DateDelivery) = False Then D4002.DateDelivery = Trim$(rs4002!K4002_DateDelivery)
    If IsdbNull(rs4002!K4002_DateTransfer) = False Then D4002.DateTransfer = Trim$(rs4002!K4002_DateTransfer)
    If IsdbNull(rs4002!K4002_DateAccept) = False Then D4002.DateAccept = Trim$(rs4002!K4002_DateAccept)
    If IsdbNull(rs4002!K4002_AcceptedOrder) = False Then D4002.AcceptedOrder = Trim$(rs4002!K4002_AcceptedOrder)
    If IsdbNull(rs4002!K4002_MaterialStatus) = False Then D4002.MaterialStatus = Trim$(rs4002!K4002_MaterialStatus)
    If IsdbNull(rs4002!K4002_SoleNo) = False Then D4002.SoleNo = Trim$(rs4002!K4002_SoleNo)
    If IsdbNull(rs4002!K4002_CuttingNo) = False Then D4002.CuttingNo = Trim$(rs4002!K4002_CuttingNo)
    If IsdbNull(rs4002!K4002_StitchingNo) = False Then D4002.StitchingNo = Trim$(rs4002!K4002_StitchingNo)
    If IsdbNull(rs4002!K4002_SubprocessNo) = False Then D4002.SubprocessNo = Trim$(rs4002!K4002_SubprocessNo)
    If IsdbNull(rs4002!K4002_OutsourceNo) = False Then D4002.OutsourceNo = Trim$(rs4002!K4002_OutsourceNo)
    If IsdbNull(rs4002!K4002_StockfitNo) = False Then D4002.StockfitNo = Trim$(rs4002!K4002_StockfitNo)
    If IsdbNull(rs4002!K4002_AssemblyNo) = False Then D4002.AssemblyNo = Trim$(rs4002!K4002_AssemblyNo)
    If IsdbNull(rs4002!K4002_CuttingStatus) = False Then D4002.CuttingStatus = Trim$(rs4002!K4002_CuttingStatus)
    If IsdbNull(rs4002!K4002_StitchingStatus) = False Then D4002.StitchingStatus = Trim$(rs4002!K4002_StitchingStatus)
    If IsdbNull(rs4002!K4002_SubprocessStatus) = False Then D4002.SubprocessStatus = Trim$(rs4002!K4002_SubprocessStatus)
    If IsdbNull(rs4002!K4002_OutsourceStatsus) = False Then D4002.OutsourceStatsus = Trim$(rs4002!K4002_OutsourceStatsus)
    If IsdbNull(rs4002!K4002_StockfitStatsus) = False Then D4002.StockfitStatsus = Trim$(rs4002!K4002_StockfitStatsus)
    If IsdbNull(rs4002!K4002_AssemblyStatus) = False Then D4002.AssemblyStatus = Trim$(rs4002!K4002_AssemblyStatus)
    If IsdbNull(rs4002!K4002_SoleStatus) = False Then D4002.SoleStatus = Trim$(rs4002!K4002_SoleStatus)
    If IsdbNull(rs4002!K4002_DatePattern) = False Then D4002.DatePattern = Trim$(rs4002!K4002_DatePattern)
    If IsdbNull(rs4002!K4002_DateMaterial) = False Then D4002.DateMaterial = Trim$(rs4002!K4002_DateMaterial)
    If IsdbNull(rs4002!K4002_DatePlanning) = False Then D4002.DatePlanning = Trim$(rs4002!K4002_DatePlanning)
    If IsdbNull(rs4002!K4002_DateRnD) = False Then D4002.DateRnD = Trim$(rs4002!K4002_DateRnD)
    If IsdbNull(rs4002!K4002_DateConfirm) = False Then D4002.DateConfirm = Trim$(rs4002!K4002_DateConfirm)
    If IsdbNull(rs4002!K4002_DateStart) = False Then D4002.DateStart = Trim$(rs4002!K4002_DateStart)
    If IsdbNull(rs4002!K4002_DateFinish) = False Then D4002.DateFinish = Trim$(rs4002!K4002_DateFinish)
    If IsdbNull(rs4002!K4002_DateSole) = False Then D4002.DateSole = Trim$(rs4002!K4002_DateSole)
    If IsdbNull(rs4002!K4002_DateCutting) = False Then D4002.DateCutting = Trim$(rs4002!K4002_DateCutting)
    If IsdbNull(rs4002!K4002_DateStitching) = False Then D4002.DateStitching = Trim$(rs4002!K4002_DateStitching)
    If IsdbNull(rs4002!K4002_DateStockfit) = False Then D4002.DateStockfit = Trim$(rs4002!K4002_DateStockfit)
    If IsdbNull(rs4002!K4002_DateAssembly) = False Then D4002.DateAssembly = Trim$(rs4002!K4002_DateAssembly)
    If IsdbNull(rs4002!K4002_DateShipping) = False Then D4002.DateShipping = Trim$(rs4002!K4002_DateShipping)
    If IsdbNull(rs4002!K4002_seUnitMaterial) = False Then D4002.seUnitMaterial = Trim$(rs4002!K4002_seUnitMaterial)
    If IsdbNull(rs4002!K4002_cdUnitMaterial) = False Then D4002.cdUnitMaterial = Trim$(rs4002!K4002_cdUnitMaterial)
    If IsdbNull(rs4002!K4002_seUnitPacking) = False Then D4002.seUnitPacking = Trim$(rs4002!K4002_seUnitPacking)
    If IsdbNull(rs4002!K4002_cdUnitPacking) = False Then D4002.cdUnitPacking = Trim$(rs4002!K4002_cdUnitPacking)
    If IsdbNull(rs4002!K4002_QtyOrder) = False Then D4002.QtyOrder = Trim$(rs4002!K4002_QtyOrder)
    If IsdbNull(rs4002!K4002_QtyBooking) = False Then D4002.QtyBooking = Trim$(rs4002!K4002_QtyBooking)
    If IsdbNull(rs4002!K4002_QtyJob) = False Then D4002.QtyJob = Trim$(rs4002!K4002_QtyJob)
    If IsdbNull(rs4002!K4002_QtyPlan) = False Then D4002.QtyPlan = Trim$(rs4002!K4002_QtyPlan)
    If IsdbNull(rs4002!K4002_QtySole) = False Then D4002.QtySole = Trim$(rs4002!K4002_QtySole)
    If IsdbNull(rs4002!K4002_QtySoleA) = False Then D4002.QtySoleA = Trim$(rs4002!K4002_QtySoleA)
    If IsdbNull(rs4002!K4002_QtySoleX) = False Then D4002.QtySoleX = Trim$(rs4002!K4002_QtySoleX)
    If IsdbNull(rs4002!K4002_QtySoleBLOut) = False Then D4002.QtySoleBLOut = Trim$(rs4002!K4002_QtySoleBLOut)
    If IsdbNull(rs4002!K4002_QtySoleBLIn) = False Then D4002.QtySoleBLIn = Trim$(rs4002!K4002_QtySoleBLIn)
    If IsdbNull(rs4002!K4002_QtyCutting) = False Then D4002.QtyCutting = Trim$(rs4002!K4002_QtyCutting)
    If IsdbNull(rs4002!K4002_QtyCuttingA) = False Then D4002.QtyCuttingA = Trim$(rs4002!K4002_QtyCuttingA)
    If IsdbNull(rs4002!K4002_QtyCuttingX) = False Then D4002.QtyCuttingX = Trim$(rs4002!K4002_QtyCuttingX)
    If IsdbNull(rs4002!K4002_QtyCuttingBLOut) = False Then D4002.QtyCuttingBLOut = Trim$(rs4002!K4002_QtyCuttingBLOut)
    If IsdbNull(rs4002!K4002_QtyCuttingBLIn) = False Then D4002.QtyCuttingBLIn = Trim$(rs4002!K4002_QtyCuttingBLIn)
    If IsdbNull(rs4002!K4002_QtyStitching) = False Then D4002.QtyStitching = Trim$(rs4002!K4002_QtyStitching)
    If IsdbNull(rs4002!K4002_QtyStitchingA) = False Then D4002.QtyStitchingA = Trim$(rs4002!K4002_QtyStitchingA)
    If IsdbNull(rs4002!K4002_QtyStitchingX) = False Then D4002.QtyStitchingX = Trim$(rs4002!K4002_QtyStitchingX)
    If IsdbNull(rs4002!K4002_QtyStitchingBLOut) = False Then D4002.QtyStitchingBLOut = Trim$(rs4002!K4002_QtyStitchingBLOut)
    If IsdbNull(rs4002!K4002_QtyStitchingBLIn) = False Then D4002.QtyStitchingBLIn = Trim$(rs4002!K4002_QtyStitchingBLIn)
    If IsdbNull(rs4002!K4002_QtyStockfit) = False Then D4002.QtyStockfit = Trim$(rs4002!K4002_QtyStockfit)
    If IsdbNull(rs4002!K4002_QtyStockfitA) = False Then D4002.QtyStockfitA = Trim$(rs4002!K4002_QtyStockfitA)
    If IsdbNull(rs4002!K4002_QtyStockfitX) = False Then D4002.QtyStockfitX = Trim$(rs4002!K4002_QtyStockfitX)
    If IsdbNull(rs4002!K4002_QtyStockfitBLOut) = False Then D4002.QtyStockfitBLOut = Trim$(rs4002!K4002_QtyStockfitBLOut)
    If IsdbNull(rs4002!K4002_QtyStockfitBLIn) = False Then D4002.QtyStockfitBLIn = Trim$(rs4002!K4002_QtyStockfitBLIn)
    If IsdbNull(rs4002!K4002_QtyAssembly) = False Then D4002.QtyAssembly = Trim$(rs4002!K4002_QtyAssembly)
    If IsdbNull(rs4002!K4002_QtyAssemblyA) = False Then D4002.QtyAssemblyA = Trim$(rs4002!K4002_QtyAssemblyA)
    If IsdbNull(rs4002!K4002_QtyAssemblyX) = False Then D4002.QtyAssemblyX = Trim$(rs4002!K4002_QtyAssemblyX)
    If IsdbNull(rs4002!K4002_QtyAssemblyBLOut) = False Then D4002.QtyAssemblyBLOut = Trim$(rs4002!K4002_QtyAssemblyBLOut)
    If IsdbNull(rs4002!K4002_QtyAssemblyBLIn) = False Then D4002.QtyAssemblyBLIn = Trim$(rs4002!K4002_QtyAssemblyBLIn)
    If IsdbNull(rs4002!K4002_QtyJobShipping) = False Then D4002.QtyJobShipping = Trim$(rs4002!K4002_QtyJobShipping)
    If IsdbNull(rs4002!K4002_QtyShipping) = False Then D4002.QtyShipping = Trim$(rs4002!K4002_QtyShipping)
    If IsdbNull(rs4002!K4002_DateInsert) = False Then D4002.DateInsert = Trim$(rs4002!K4002_DateInsert)
    If IsdbNull(rs4002!K4002_InchargeInsert) = False Then D4002.InchargeInsert = Trim$(rs4002!K4002_InchargeInsert)
    If IsdbNull(rs4002!K4002_DateUpdate) = False Then D4002.DateUpdate = Trim$(rs4002!K4002_DateUpdate)
    If IsdbNull(rs4002!K4002_InchargeUpdate) = False Then D4002.InchargeUpdate = Trim$(rs4002!K4002_InchargeUpdate)
    If IsdbNull(rs4002!K4002_InchargeSales) = False Then D4002.InchargeSales = Trim$(rs4002!K4002_InchargeSales)
    If IsdbNull(rs4002!K4002_InchargePPC) = False Then D4002.InchargePPC = Trim$(rs4002!K4002_InchargePPC)
    If IsdbNull(rs4002!K4002_AttachID) = False Then D4002.AttachID = Trim$(rs4002!K4002_AttachID)
    If IsdbNull(rs4002!K4002_chkMaterial) = False Then D4002.chkMaterial = Trim$(rs4002!K4002_chkMaterial)
    If IsdbNull(rs4002!K4002_RemarkMaterial) = False Then D4002.RemarkMaterial = Trim$(rs4002!K4002_RemarkMaterial)
    If IsdbNull(rs4002!K4002_InchargeMaterial) = False Then D4002.InchargeMaterial = Trim$(rs4002!K4002_InchargeMaterial)
    If IsdbNull(rs4002!K4002_DateRemarkMaterial) = False Then D4002.DateRemarkMaterial = Trim$(rs4002!K4002_DateRemarkMaterial)
    If IsdbNull(rs4002!K4002_chkSole) = False Then D4002.chkSole = Trim$(rs4002!K4002_chkSole)
    If IsdbNull(rs4002!K4002_RemarkSole) = False Then D4002.RemarkSole = Trim$(rs4002!K4002_RemarkSole)
    If IsdbNull(rs4002!K4002_InchargeSole) = False Then D4002.InchargeSole = Trim$(rs4002!K4002_InchargeSole)
    If IsdbNull(rs4002!K4002_DateRemarkSole) = False Then D4002.DateRemarkSole = Trim$(rs4002!K4002_DateRemarkSole)
    If IsdbNull(rs4002!K4002_chkLast) = False Then D4002.chkLast = Trim$(rs4002!K4002_chkLast)
    If IsdbNull(rs4002!K4002_RemarkLast) = False Then D4002.RemarkLast = Trim$(rs4002!K4002_RemarkLast)
    If IsdbNull(rs4002!K4002_InchargeLast) = False Then D4002.InchargeLast = Trim$(rs4002!K4002_InchargeLast)
    If IsdbNull(rs4002!K4002_DateRemarkLast) = False Then D4002.DateRemarkLast = Trim$(rs4002!K4002_DateRemarkLast)
    If IsdbNull(rs4002!K4002_chkMold) = False Then D4002.chkMold = Trim$(rs4002!K4002_chkMold)
    If IsdbNull(rs4002!K4002_RemarkMold) = False Then D4002.RemarkMold = Trim$(rs4002!K4002_RemarkMold)
    If IsdbNull(rs4002!K4002_InchargeMold) = False Then D4002.InchargeMold = Trim$(rs4002!K4002_InchargeMold)
    If IsdbNull(rs4002!K4002_DateRemarkMold) = False Then D4002.DateRemarkMold = Trim$(rs4002!K4002_DateRemarkMold)
    If IsdbNull(rs4002!K4002_chkSpec) = False Then D4002.chkSpec = Trim$(rs4002!K4002_chkSpec)
    If IsdbNull(rs4002!K4002_RemarkSpec) = False Then D4002.RemarkSpec = Trim$(rs4002!K4002_RemarkSpec)
    If IsdbNull(rs4002!K4002_InchargeSpec) = False Then D4002.InchargeSpec = Trim$(rs4002!K4002_InchargeSpec)
    If IsdbNull(rs4002!K4002_DateRemarkSpec) = False Then D4002.DateRemarkSpec = Trim$(rs4002!K4002_DateRemarkSpec)
    If IsdbNull(rs4002!K4002_chkTest) = False Then D4002.chkTest = Trim$(rs4002!K4002_chkTest)
    If IsdbNull(rs4002!K4002_RemarkTest) = False Then D4002.RemarkTest = Trim$(rs4002!K4002_RemarkTest)
    If IsdbNull(rs4002!K4002_InchargeTest) = False Then D4002.InchargeTest = Trim$(rs4002!K4002_InchargeTest)
    If IsdbNull(rs4002!K4002_DateRemarkTest) = False Then D4002.DateRemarkTest = Trim$(rs4002!K4002_DateRemarkTest)
    If IsdbNull(rs4002!K4002_chkCFM) = False Then D4002.chkCFM = Trim$(rs4002!K4002_chkCFM)
    If IsdbNull(rs4002!K4002_RemarkCFM) = False Then D4002.RemarkCFM = Trim$(rs4002!K4002_RemarkCFM)
    If IsdbNull(rs4002!K4002_InchargeCFM) = False Then D4002.InchargeCFM = Trim$(rs4002!K4002_InchargeCFM)
    If IsdbNull(rs4002!K4002_DateRemarkCFM) = False Then D4002.DateRemarkCFM = Trim$(rs4002!K4002_DateRemarkCFM)
    If IsdbNull(rs4002!K4002_FactorykAllocation) = False Then D4002.FactorykAllocation = Trim$(rs4002!K4002_FactorykAllocation)
    If IsdbNull(rs4002!K4002_LineAllocation) = False Then D4002.LineAllocation = Trim$(rs4002!K4002_LineAllocation)
    If IsdbNull(rs4002!K4002_RemarkAllocation) = False Then D4002.RemarkAllocation = Trim$(rs4002!K4002_RemarkAllocation)
    If IsdbNull(rs4002!K4002_RemarkOrder) = False Then D4002.RemarkOrder = Trim$(rs4002!K4002_RemarkOrder)
    If IsdbNull(rs4002!K4002_RemarkCustomer) = False Then D4002.RemarkCustomer = Trim$(rs4002!K4002_RemarkCustomer)
    If IsdbNull(rs4002!K4002_RemarkOther) = False Then D4002.RemarkOther = Trim$(rs4002!K4002_RemarkOther)
    If IsdbNull(rs4002!K4002_Remark) = False Then D4002.Remark = Trim$(rs4002!K4002_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K4002_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K4002_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z4002 As T4002_AREA, WORKORDER AS String, WORKORDERSEQ AS String) as Boolean

K4002_MOVE = False

Try
    If READ_PFK4002(WORKORDER, WORKORDERSEQ) = True Then
                z4002 = D4002
		K4002_MOVE = True
		else
	z4002 = nothing
     End If

     If  getColumIndex(spr,"WorkOrder") > -1 then z4002.WorkOrder = getDataM(spr, getColumIndex(spr,"WorkOrder"), xRow)
     If  getColumIndex(spr,"WorkOrderSeq") > -1 then z4002.WorkOrderSeq = getDataM(spr, getColumIndex(spr,"WorkOrderSeq"), xRow)
     If  getColumIndex(spr,"OrderNo") > -1 then z4002.OrderNo = getDataM(spr, getColumIndex(spr,"OrderNo"), xRow)
     If  getColumIndex(spr,"OrderNoSeq") > -1 then z4002.OrderNoSeq = getDataM(spr, getColumIndex(spr,"OrderNoSeq"), xRow)
     If  getColumIndex(spr,"SLNo") > -1 then z4002.SLNo = getDataM(spr, getColumIndex(spr,"SLNo"), xRow)
     If  getColumIndex(spr,"SealMaster") > -1 then z4002.SealMaster = getDataM(spr, getColumIndex(spr,"SealMaster"), xRow)
     If  getColumIndex(spr,"WorkOrderStatus") > -1 then z4002.WorkOrderStatus = getDataM(spr, getColumIndex(spr,"WorkOrderStatus"), xRow)
     If  getColumIndex(spr,"DateApproval") > -1 then z4002.DateApproval = getDataM(spr, getColumIndex(spr,"DateApproval"), xRow)
     If  getColumIndex(spr,"DateCancel") > -1 then z4002.DateCancel = getDataM(spr, getColumIndex(spr,"DateCancel"), xRow)
     If  getColumIndex(spr,"DateComplete") > -1 then z4002.DateComplete = getDataM(spr, getColumIndex(spr,"DateComplete"), xRow)
     If  getColumIndex(spr,"DatePending") > -1 then z4002.DatePending = getDataM(spr, getColumIndex(spr,"DatePending"), xRow)
     If  getColumIndex(spr,"DateDelivery") > -1 then z4002.DateDelivery = getDataM(spr, getColumIndex(spr,"DateDelivery"), xRow)
     If  getColumIndex(spr,"DateTransfer") > -1 then z4002.DateTransfer = getDataM(spr, getColumIndex(spr,"DateTransfer"), xRow)
     If  getColumIndex(spr,"DateAccept") > -1 then z4002.DateAccept = getDataM(spr, getColumIndex(spr,"DateAccept"), xRow)
     If  getColumIndex(spr,"AcceptedOrder") > -1 then z4002.AcceptedOrder = getDataM(spr, getColumIndex(spr,"AcceptedOrder"), xRow)
     If  getColumIndex(spr,"MaterialStatus") > -1 then z4002.MaterialStatus = getDataM(spr, getColumIndex(spr,"MaterialStatus"), xRow)
     If  getColumIndex(spr,"SoleNo") > -1 then z4002.SoleNo = getDataM(spr, getColumIndex(spr,"SoleNo"), xRow)
     If  getColumIndex(spr,"CuttingNo") > -1 then z4002.CuttingNo = getDataM(spr, getColumIndex(spr,"CuttingNo"), xRow)
     If  getColumIndex(spr,"StitchingNo") > -1 then z4002.StitchingNo = getDataM(spr, getColumIndex(spr,"StitchingNo"), xRow)
     If  getColumIndex(spr,"SubprocessNo") > -1 then z4002.SubprocessNo = getDataM(spr, getColumIndex(spr,"SubprocessNo"), xRow)
     If  getColumIndex(spr,"OutsourceNo") > -1 then z4002.OutsourceNo = getDataM(spr, getColumIndex(spr,"OutsourceNo"), xRow)
     If  getColumIndex(spr,"StockfitNo") > -1 then z4002.StockfitNo = getDataM(spr, getColumIndex(spr,"StockfitNo"), xRow)
     If  getColumIndex(spr,"AssemblyNo") > -1 then z4002.AssemblyNo = getDataM(spr, getColumIndex(spr,"AssemblyNo"), xRow)
     If  getColumIndex(spr,"CuttingStatus") > -1 then z4002.CuttingStatus = getDataM(spr, getColumIndex(spr,"CuttingStatus"), xRow)
     If  getColumIndex(spr,"StitchingStatus") > -1 then z4002.StitchingStatus = getDataM(spr, getColumIndex(spr,"StitchingStatus"), xRow)
     If  getColumIndex(spr,"SubprocessStatus") > -1 then z4002.SubprocessStatus = getDataM(spr, getColumIndex(spr,"SubprocessStatus"), xRow)
     If  getColumIndex(spr,"OutsourceStatsus") > -1 then z4002.OutsourceStatsus = getDataM(spr, getColumIndex(spr,"OutsourceStatsus"), xRow)
     If  getColumIndex(spr,"StockfitStatsus") > -1 then z4002.StockfitStatsus = getDataM(spr, getColumIndex(spr,"StockfitStatsus"), xRow)
     If  getColumIndex(spr,"AssemblyStatus") > -1 then z4002.AssemblyStatus = getDataM(spr, getColumIndex(spr,"AssemblyStatus"), xRow)
     If  getColumIndex(spr,"SoleStatus") > -1 then z4002.SoleStatus = getDataM(spr, getColumIndex(spr,"SoleStatus"), xRow)
     If  getColumIndex(spr,"DatePattern") > -1 then z4002.DatePattern = getDataM(spr, getColumIndex(spr,"DatePattern"), xRow)
     If  getColumIndex(spr,"DateMaterial") > -1 then z4002.DateMaterial = getDataM(spr, getColumIndex(spr,"DateMaterial"), xRow)
     If  getColumIndex(spr,"DatePlanning") > -1 then z4002.DatePlanning = getDataM(spr, getColumIndex(spr,"DatePlanning"), xRow)
     If  getColumIndex(spr,"DateRnD") > -1 then z4002.DateRnD = getDataM(spr, getColumIndex(spr,"DateRnD"), xRow)
     If  getColumIndex(spr,"DateConfirm") > -1 then z4002.DateConfirm = getDataM(spr, getColumIndex(spr,"DateConfirm"), xRow)
     If  getColumIndex(spr,"DateStart") > -1 then z4002.DateStart = getDataM(spr, getColumIndex(spr,"DateStart"), xRow)
     If  getColumIndex(spr,"DateFinish") > -1 then z4002.DateFinish = getDataM(spr, getColumIndex(spr,"DateFinish"), xRow)
     If  getColumIndex(spr,"DateSole") > -1 then z4002.DateSole = getDataM(spr, getColumIndex(spr,"DateSole"), xRow)
     If  getColumIndex(spr,"DateCutting") > -1 then z4002.DateCutting = getDataM(spr, getColumIndex(spr,"DateCutting"), xRow)
     If  getColumIndex(spr,"DateStitching") > -1 then z4002.DateStitching = getDataM(spr, getColumIndex(spr,"DateStitching"), xRow)
     If  getColumIndex(spr,"DateStockfit") > -1 then z4002.DateStockfit = getDataM(spr, getColumIndex(spr,"DateStockfit"), xRow)
     If  getColumIndex(spr,"DateAssembly") > -1 then z4002.DateAssembly = getDataM(spr, getColumIndex(spr,"DateAssembly"), xRow)
     If  getColumIndex(spr,"DateShipping") > -1 then z4002.DateShipping = getDataM(spr, getColumIndex(spr,"DateShipping"), xRow)
     If  getColumIndex(spr,"seUnitMaterial") > -1 then z4002.seUnitMaterial = getDataM(spr, getColumIndex(spr,"seUnitMaterial"), xRow)
     If  getColumIndex(spr,"cdUnitMaterial") > -1 then z4002.cdUnitMaterial = getDataM(spr, getColumIndex(spr,"cdUnitMaterial"), xRow)
     If  getColumIndex(spr,"seUnitPacking") > -1 then z4002.seUnitPacking = getDataM(spr, getColumIndex(spr,"seUnitPacking"), xRow)
     If  getColumIndex(spr,"cdUnitPacking") > -1 then z4002.cdUnitPacking = getDataM(spr, getColumIndex(spr,"cdUnitPacking"), xRow)
     If  getColumIndex(spr,"QtyOrder") > -1 then z4002.QtyOrder = getDataM(spr, getColumIndex(spr,"QtyOrder"), xRow)
     If  getColumIndex(spr,"QtyBooking") > -1 then z4002.QtyBooking = getDataM(spr, getColumIndex(spr,"QtyBooking"), xRow)
     If  getColumIndex(spr,"QtyJob") > -1 then z4002.QtyJob = getDataM(spr, getColumIndex(spr,"QtyJob"), xRow)
     If  getColumIndex(spr,"QtyPlan") > -1 then z4002.QtyPlan = getDataM(spr, getColumIndex(spr,"QtyPlan"), xRow)
     If  getColumIndex(spr,"QtySole") > -1 then z4002.QtySole = getDataM(spr, getColumIndex(spr,"QtySole"), xRow)
     If  getColumIndex(spr,"QtySoleA") > -1 then z4002.QtySoleA = getDataM(spr, getColumIndex(spr,"QtySoleA"), xRow)
     If  getColumIndex(spr,"QtySoleX") > -1 then z4002.QtySoleX = getDataM(spr, getColumIndex(spr,"QtySoleX"), xRow)
     If  getColumIndex(spr,"QtySoleBLOut") > -1 then z4002.QtySoleBLOut = getDataM(spr, getColumIndex(spr,"QtySoleBLOut"), xRow)
     If  getColumIndex(spr,"QtySoleBLIn") > -1 then z4002.QtySoleBLIn = getDataM(spr, getColumIndex(spr,"QtySoleBLIn"), xRow)
     If  getColumIndex(spr,"QtyCutting") > -1 then z4002.QtyCutting = getDataM(spr, getColumIndex(spr,"QtyCutting"), xRow)
     If  getColumIndex(spr,"QtyCuttingA") > -1 then z4002.QtyCuttingA = getDataM(spr, getColumIndex(spr,"QtyCuttingA"), xRow)
     If  getColumIndex(spr,"QtyCuttingX") > -1 then z4002.QtyCuttingX = getDataM(spr, getColumIndex(spr,"QtyCuttingX"), xRow)
     If  getColumIndex(spr,"QtyCuttingBLOut") > -1 then z4002.QtyCuttingBLOut = getDataM(spr, getColumIndex(spr,"QtyCuttingBLOut"), xRow)
     If  getColumIndex(spr,"QtyCuttingBLIn") > -1 then z4002.QtyCuttingBLIn = getDataM(spr, getColumIndex(spr,"QtyCuttingBLIn"), xRow)
     If  getColumIndex(spr,"QtyStitching") > -1 then z4002.QtyStitching = getDataM(spr, getColumIndex(spr,"QtyStitching"), xRow)
     If  getColumIndex(spr,"QtyStitchingA") > -1 then z4002.QtyStitchingA = getDataM(spr, getColumIndex(spr,"QtyStitchingA"), xRow)
     If  getColumIndex(spr,"QtyStitchingX") > -1 then z4002.QtyStitchingX = getDataM(spr, getColumIndex(spr,"QtyStitchingX"), xRow)
     If  getColumIndex(spr,"QtyStitchingBLOut") > -1 then z4002.QtyStitchingBLOut = getDataM(spr, getColumIndex(spr,"QtyStitchingBLOut"), xRow)
     If  getColumIndex(spr,"QtyStitchingBLIn") > -1 then z4002.QtyStitchingBLIn = getDataM(spr, getColumIndex(spr,"QtyStitchingBLIn"), xRow)
     If  getColumIndex(spr,"QtyStockfit") > -1 then z4002.QtyStockfit = getDataM(spr, getColumIndex(spr,"QtyStockfit"), xRow)
     If  getColumIndex(spr,"QtyStockfitA") > -1 then z4002.QtyStockfitA = getDataM(spr, getColumIndex(spr,"QtyStockfitA"), xRow)
     If  getColumIndex(spr,"QtyStockfitX") > -1 then z4002.QtyStockfitX = getDataM(spr, getColumIndex(spr,"QtyStockfitX"), xRow)
     If  getColumIndex(spr,"QtyStockfitBLOut") > -1 then z4002.QtyStockfitBLOut = getDataM(spr, getColumIndex(spr,"QtyStockfitBLOut"), xRow)
     If  getColumIndex(spr,"QtyStockfitBLIn") > -1 then z4002.QtyStockfitBLIn = getDataM(spr, getColumIndex(spr,"QtyStockfitBLIn"), xRow)
     If  getColumIndex(spr,"QtyAssembly") > -1 then z4002.QtyAssembly = getDataM(spr, getColumIndex(spr,"QtyAssembly"), xRow)
     If  getColumIndex(spr,"QtyAssemblyA") > -1 then z4002.QtyAssemblyA = getDataM(spr, getColumIndex(spr,"QtyAssemblyA"), xRow)
     If  getColumIndex(spr,"QtyAssemblyX") > -1 then z4002.QtyAssemblyX = getDataM(spr, getColumIndex(spr,"QtyAssemblyX"), xRow)
     If  getColumIndex(spr,"QtyAssemblyBLOut") > -1 then z4002.QtyAssemblyBLOut = getDataM(spr, getColumIndex(spr,"QtyAssemblyBLOut"), xRow)
     If  getColumIndex(spr,"QtyAssemblyBLIn") > -1 then z4002.QtyAssemblyBLIn = getDataM(spr, getColumIndex(spr,"QtyAssemblyBLIn"), xRow)
     If  getColumIndex(spr,"QtyJobShipping") > -1 then z4002.QtyJobShipping = getDataM(spr, getColumIndex(spr,"QtyJobShipping"), xRow)
     If  getColumIndex(spr,"QtyShipping") > -1 then z4002.QtyShipping = getDataM(spr, getColumIndex(spr,"QtyShipping"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z4002.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z4002.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z4002.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z4002.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"InchargeSales") > -1 then z4002.InchargeSales = getDataM(spr, getColumIndex(spr,"InchargeSales"), xRow)
     If  getColumIndex(spr,"InchargePPC") > -1 then z4002.InchargePPC = getDataM(spr, getColumIndex(spr,"InchargePPC"), xRow)
     If  getColumIndex(spr,"AttachID") > -1 then z4002.AttachID = getDataM(spr, getColumIndex(spr,"AttachID"), xRow)
     If  getColumIndex(spr,"chkMaterial") > -1 then z4002.chkMaterial = getDataM(spr, getColumIndex(spr,"chkMaterial"), xRow)
     If  getColumIndex(spr,"RemarkMaterial") > -1 then z4002.RemarkMaterial = getDataM(spr, getColumIndex(spr,"RemarkMaterial"), xRow)
     If  getColumIndex(spr,"InchargeMaterial") > -1 then z4002.InchargeMaterial = getDataM(spr, getColumIndex(spr,"InchargeMaterial"), xRow)
     If  getColumIndex(spr,"DateRemarkMaterial") > -1 then z4002.DateRemarkMaterial = getDataM(spr, getColumIndex(spr,"DateRemarkMaterial"), xRow)
     If  getColumIndex(spr,"chkSole") > -1 then z4002.chkSole = getDataM(spr, getColumIndex(spr,"chkSole"), xRow)
     If  getColumIndex(spr,"RemarkSole") > -1 then z4002.RemarkSole = getDataM(spr, getColumIndex(spr,"RemarkSole"), xRow)
     If  getColumIndex(spr,"InchargeSole") > -1 then z4002.InchargeSole = getDataM(spr, getColumIndex(spr,"InchargeSole"), xRow)
     If  getColumIndex(spr,"DateRemarkSole") > -1 then z4002.DateRemarkSole = getDataM(spr, getColumIndex(spr,"DateRemarkSole"), xRow)
     If  getColumIndex(spr,"chkLast") > -1 then z4002.chkLast = getDataM(spr, getColumIndex(spr,"chkLast"), xRow)
     If  getColumIndex(spr,"RemarkLast") > -1 then z4002.RemarkLast = getDataM(spr, getColumIndex(spr,"RemarkLast"), xRow)
     If  getColumIndex(spr,"InchargeLast") > -1 then z4002.InchargeLast = getDataM(spr, getColumIndex(spr,"InchargeLast"), xRow)
     If  getColumIndex(spr,"DateRemarkLast") > -1 then z4002.DateRemarkLast = getDataM(spr, getColumIndex(spr,"DateRemarkLast"), xRow)
     If  getColumIndex(spr,"chkMold") > -1 then z4002.chkMold = getDataM(spr, getColumIndex(spr,"chkMold"), xRow)
     If  getColumIndex(spr,"RemarkMold") > -1 then z4002.RemarkMold = getDataM(spr, getColumIndex(spr,"RemarkMold"), xRow)
     If  getColumIndex(spr,"InchargeMold") > -1 then z4002.InchargeMold = getDataM(spr, getColumIndex(spr,"InchargeMold"), xRow)
     If  getColumIndex(spr,"DateRemarkMold") > -1 then z4002.DateRemarkMold = getDataM(spr, getColumIndex(spr,"DateRemarkMold"), xRow)
     If  getColumIndex(spr,"chkSpec") > -1 then z4002.chkSpec = getDataM(spr, getColumIndex(spr,"chkSpec"), xRow)
     If  getColumIndex(spr,"RemarkSpec") > -1 then z4002.RemarkSpec = getDataM(spr, getColumIndex(spr,"RemarkSpec"), xRow)
     If  getColumIndex(spr,"InchargeSpec") > -1 then z4002.InchargeSpec = getDataM(spr, getColumIndex(spr,"InchargeSpec"), xRow)
     If  getColumIndex(spr,"DateRemarkSpec") > -1 then z4002.DateRemarkSpec = getDataM(spr, getColumIndex(spr,"DateRemarkSpec"), xRow)
     If  getColumIndex(spr,"chkTest") > -1 then z4002.chkTest = getDataM(spr, getColumIndex(spr,"chkTest"), xRow)
     If  getColumIndex(spr,"RemarkTest") > -1 then z4002.RemarkTest = getDataM(spr, getColumIndex(spr,"RemarkTest"), xRow)
     If  getColumIndex(spr,"InchargeTest") > -1 then z4002.InchargeTest = getDataM(spr, getColumIndex(spr,"InchargeTest"), xRow)
     If  getColumIndex(spr,"DateRemarkTest") > -1 then z4002.DateRemarkTest = getDataM(spr, getColumIndex(spr,"DateRemarkTest"), xRow)
     If  getColumIndex(spr,"chkCFM") > -1 then z4002.chkCFM = getDataM(spr, getColumIndex(spr,"chkCFM"), xRow)
     If  getColumIndex(spr,"RemarkCFM") > -1 then z4002.RemarkCFM = getDataM(spr, getColumIndex(spr,"RemarkCFM"), xRow)
     If  getColumIndex(spr,"InchargeCFM") > -1 then z4002.InchargeCFM = getDataM(spr, getColumIndex(spr,"InchargeCFM"), xRow)
     If  getColumIndex(spr,"DateRemarkCFM") > -1 then z4002.DateRemarkCFM = getDataM(spr, getColumIndex(spr,"DateRemarkCFM"), xRow)
     If  getColumIndex(spr,"FactorykAllocation") > -1 then z4002.FactorykAllocation = getDataM(spr, getColumIndex(spr,"FactorykAllocation"), xRow)
     If  getColumIndex(spr,"LineAllocation") > -1 then z4002.LineAllocation = getDataM(spr, getColumIndex(spr,"LineAllocation"), xRow)
     If  getColumIndex(spr,"RemarkAllocation") > -1 then z4002.RemarkAllocation = getDataM(spr, getColumIndex(spr,"RemarkAllocation"), xRow)
     If  getColumIndex(spr,"RemarkOrder") > -1 then z4002.RemarkOrder = getDataM(spr, getColumIndex(spr,"RemarkOrder"), xRow)
     If  getColumIndex(spr,"RemarkCustomer") > -1 then z4002.RemarkCustomer = getDataM(spr, getColumIndex(spr,"RemarkCustomer"), xRow)
     If  getColumIndex(spr,"RemarkOther") > -1 then z4002.RemarkOther = getDataM(spr, getColumIndex(spr,"RemarkOther"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z4002.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K4002_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K4002_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z4002 As T4002_AREA,CheckClear as Boolean,WORKORDER AS String, WORKORDERSEQ AS String) as Boolean

K4002_MOVE = False

Try
    If READ_PFK4002(WORKORDER, WORKORDERSEQ) = True Then
                z4002 = D4002
		K4002_MOVE = True
		else
	If CheckClear  = True then z4002 = nothing
     End If

     If  getColumIndex(spr,"WorkOrder") > -1 then z4002.WorkOrder = getDataM(spr, getColumIndex(spr,"WorkOrder"), xRow)
     If  getColumIndex(spr,"WorkOrderSeq") > -1 then z4002.WorkOrderSeq = getDataM(spr, getColumIndex(spr,"WorkOrderSeq"), xRow)
     If  getColumIndex(spr,"OrderNo") > -1 then z4002.OrderNo = getDataM(spr, getColumIndex(spr,"OrderNo"), xRow)
     If  getColumIndex(spr,"OrderNoSeq") > -1 then z4002.OrderNoSeq = getDataM(spr, getColumIndex(spr,"OrderNoSeq"), xRow)
     If  getColumIndex(spr,"SLNo") > -1 then z4002.SLNo = getDataM(spr, getColumIndex(spr,"SLNo"), xRow)
     If  getColumIndex(spr,"SealMaster") > -1 then z4002.SealMaster = getDataM(spr, getColumIndex(spr,"SealMaster"), xRow)
     If  getColumIndex(spr,"WorkOrderStatus") > -1 then z4002.WorkOrderStatus = getDataM(spr, getColumIndex(spr,"WorkOrderStatus"), xRow)
     If  getColumIndex(spr,"DateApproval") > -1 then z4002.DateApproval = getDataM(spr, getColumIndex(spr,"DateApproval"), xRow)
     If  getColumIndex(spr,"DateCancel") > -1 then z4002.DateCancel = getDataM(spr, getColumIndex(spr,"DateCancel"), xRow)
     If  getColumIndex(spr,"DateComplete") > -1 then z4002.DateComplete = getDataM(spr, getColumIndex(spr,"DateComplete"), xRow)
     If  getColumIndex(spr,"DatePending") > -1 then z4002.DatePending = getDataM(spr, getColumIndex(spr,"DatePending"), xRow)
     If  getColumIndex(spr,"DateDelivery") > -1 then z4002.DateDelivery = getDataM(spr, getColumIndex(spr,"DateDelivery"), xRow)
     If  getColumIndex(spr,"DateTransfer") > -1 then z4002.DateTransfer = getDataM(spr, getColumIndex(spr,"DateTransfer"), xRow)
     If  getColumIndex(spr,"DateAccept") > -1 then z4002.DateAccept = getDataM(spr, getColumIndex(spr,"DateAccept"), xRow)
     If  getColumIndex(spr,"AcceptedOrder") > -1 then z4002.AcceptedOrder = getDataM(spr, getColumIndex(spr,"AcceptedOrder"), xRow)
     If  getColumIndex(spr,"MaterialStatus") > -1 then z4002.MaterialStatus = getDataM(spr, getColumIndex(spr,"MaterialStatus"), xRow)
     If  getColumIndex(spr,"SoleNo") > -1 then z4002.SoleNo = getDataM(spr, getColumIndex(spr,"SoleNo"), xRow)
     If  getColumIndex(spr,"CuttingNo") > -1 then z4002.CuttingNo = getDataM(spr, getColumIndex(spr,"CuttingNo"), xRow)
     If  getColumIndex(spr,"StitchingNo") > -1 then z4002.StitchingNo = getDataM(spr, getColumIndex(spr,"StitchingNo"), xRow)
     If  getColumIndex(spr,"SubprocessNo") > -1 then z4002.SubprocessNo = getDataM(spr, getColumIndex(spr,"SubprocessNo"), xRow)
     If  getColumIndex(spr,"OutsourceNo") > -1 then z4002.OutsourceNo = getDataM(spr, getColumIndex(spr,"OutsourceNo"), xRow)
     If  getColumIndex(spr,"StockfitNo") > -1 then z4002.StockfitNo = getDataM(spr, getColumIndex(spr,"StockfitNo"), xRow)
     If  getColumIndex(spr,"AssemblyNo") > -1 then z4002.AssemblyNo = getDataM(spr, getColumIndex(spr,"AssemblyNo"), xRow)
     If  getColumIndex(spr,"CuttingStatus") > -1 then z4002.CuttingStatus = getDataM(spr, getColumIndex(spr,"CuttingStatus"), xRow)
     If  getColumIndex(spr,"StitchingStatus") > -1 then z4002.StitchingStatus = getDataM(spr, getColumIndex(spr,"StitchingStatus"), xRow)
     If  getColumIndex(spr,"SubprocessStatus") > -1 then z4002.SubprocessStatus = getDataM(spr, getColumIndex(spr,"SubprocessStatus"), xRow)
     If  getColumIndex(spr,"OutsourceStatsus") > -1 then z4002.OutsourceStatsus = getDataM(spr, getColumIndex(spr,"OutsourceStatsus"), xRow)
     If  getColumIndex(spr,"StockfitStatsus") > -1 then z4002.StockfitStatsus = getDataM(spr, getColumIndex(spr,"StockfitStatsus"), xRow)
     If  getColumIndex(spr,"AssemblyStatus") > -1 then z4002.AssemblyStatus = getDataM(spr, getColumIndex(spr,"AssemblyStatus"), xRow)
     If  getColumIndex(spr,"SoleStatus") > -1 then z4002.SoleStatus = getDataM(spr, getColumIndex(spr,"SoleStatus"), xRow)
     If  getColumIndex(spr,"DatePattern") > -1 then z4002.DatePattern = getDataM(spr, getColumIndex(spr,"DatePattern"), xRow)
     If  getColumIndex(spr,"DateMaterial") > -1 then z4002.DateMaterial = getDataM(spr, getColumIndex(spr,"DateMaterial"), xRow)
     If  getColumIndex(spr,"DatePlanning") > -1 then z4002.DatePlanning = getDataM(spr, getColumIndex(spr,"DatePlanning"), xRow)
     If  getColumIndex(spr,"DateRnD") > -1 then z4002.DateRnD = getDataM(spr, getColumIndex(spr,"DateRnD"), xRow)
     If  getColumIndex(spr,"DateConfirm") > -1 then z4002.DateConfirm = getDataM(spr, getColumIndex(spr,"DateConfirm"), xRow)
     If  getColumIndex(spr,"DateStart") > -1 then z4002.DateStart = getDataM(spr, getColumIndex(spr,"DateStart"), xRow)
     If  getColumIndex(spr,"DateFinish") > -1 then z4002.DateFinish = getDataM(spr, getColumIndex(spr,"DateFinish"), xRow)
     If  getColumIndex(spr,"DateSole") > -1 then z4002.DateSole = getDataM(spr, getColumIndex(spr,"DateSole"), xRow)
     If  getColumIndex(spr,"DateCutting") > -1 then z4002.DateCutting = getDataM(spr, getColumIndex(spr,"DateCutting"), xRow)
     If  getColumIndex(spr,"DateStitching") > -1 then z4002.DateStitching = getDataM(spr, getColumIndex(spr,"DateStitching"), xRow)
     If  getColumIndex(spr,"DateStockfit") > -1 then z4002.DateStockfit = getDataM(spr, getColumIndex(spr,"DateStockfit"), xRow)
     If  getColumIndex(spr,"DateAssembly") > -1 then z4002.DateAssembly = getDataM(spr, getColumIndex(spr,"DateAssembly"), xRow)
     If  getColumIndex(spr,"DateShipping") > -1 then z4002.DateShipping = getDataM(spr, getColumIndex(spr,"DateShipping"), xRow)
     If  getColumIndex(spr,"seUnitMaterial") > -1 then z4002.seUnitMaterial = getDataM(spr, getColumIndex(spr,"seUnitMaterial"), xRow)
     If  getColumIndex(spr,"cdUnitMaterial") > -1 then z4002.cdUnitMaterial = getDataM(spr, getColumIndex(spr,"cdUnitMaterial"), xRow)
     If  getColumIndex(spr,"seUnitPacking") > -1 then z4002.seUnitPacking = getDataM(spr, getColumIndex(spr,"seUnitPacking"), xRow)
     If  getColumIndex(spr,"cdUnitPacking") > -1 then z4002.cdUnitPacking = getDataM(spr, getColumIndex(spr,"cdUnitPacking"), xRow)
     If  getColumIndex(spr,"QtyOrder") > -1 then z4002.QtyOrder = getDataM(spr, getColumIndex(spr,"QtyOrder"), xRow)
     If  getColumIndex(spr,"QtyBooking") > -1 then z4002.QtyBooking = getDataM(spr, getColumIndex(spr,"QtyBooking"), xRow)
     If  getColumIndex(spr,"QtyJob") > -1 then z4002.QtyJob = getDataM(spr, getColumIndex(spr,"QtyJob"), xRow)
     If  getColumIndex(spr,"QtyPlan") > -1 then z4002.QtyPlan = getDataM(spr, getColumIndex(spr,"QtyPlan"), xRow)
     If  getColumIndex(spr,"QtySole") > -1 then z4002.QtySole = getDataM(spr, getColumIndex(spr,"QtySole"), xRow)
     If  getColumIndex(spr,"QtySoleA") > -1 then z4002.QtySoleA = getDataM(spr, getColumIndex(spr,"QtySoleA"), xRow)
     If  getColumIndex(spr,"QtySoleX") > -1 then z4002.QtySoleX = getDataM(spr, getColumIndex(spr,"QtySoleX"), xRow)
     If  getColumIndex(spr,"QtySoleBLOut") > -1 then z4002.QtySoleBLOut = getDataM(spr, getColumIndex(spr,"QtySoleBLOut"), xRow)
     If  getColumIndex(spr,"QtySoleBLIn") > -1 then z4002.QtySoleBLIn = getDataM(spr, getColumIndex(spr,"QtySoleBLIn"), xRow)
     If  getColumIndex(spr,"QtyCutting") > -1 then z4002.QtyCutting = getDataM(spr, getColumIndex(spr,"QtyCutting"), xRow)
     If  getColumIndex(spr,"QtyCuttingA") > -1 then z4002.QtyCuttingA = getDataM(spr, getColumIndex(spr,"QtyCuttingA"), xRow)
     If  getColumIndex(spr,"QtyCuttingX") > -1 then z4002.QtyCuttingX = getDataM(spr, getColumIndex(spr,"QtyCuttingX"), xRow)
     If  getColumIndex(spr,"QtyCuttingBLOut") > -1 then z4002.QtyCuttingBLOut = getDataM(spr, getColumIndex(spr,"QtyCuttingBLOut"), xRow)
     If  getColumIndex(spr,"QtyCuttingBLIn") > -1 then z4002.QtyCuttingBLIn = getDataM(spr, getColumIndex(spr,"QtyCuttingBLIn"), xRow)
     If  getColumIndex(spr,"QtyStitching") > -1 then z4002.QtyStitching = getDataM(spr, getColumIndex(spr,"QtyStitching"), xRow)
     If  getColumIndex(spr,"QtyStitchingA") > -1 then z4002.QtyStitchingA = getDataM(spr, getColumIndex(spr,"QtyStitchingA"), xRow)
     If  getColumIndex(spr,"QtyStitchingX") > -1 then z4002.QtyStitchingX = getDataM(spr, getColumIndex(spr,"QtyStitchingX"), xRow)
     If  getColumIndex(spr,"QtyStitchingBLOut") > -1 then z4002.QtyStitchingBLOut = getDataM(spr, getColumIndex(spr,"QtyStitchingBLOut"), xRow)
     If  getColumIndex(spr,"QtyStitchingBLIn") > -1 then z4002.QtyStitchingBLIn = getDataM(spr, getColumIndex(spr,"QtyStitchingBLIn"), xRow)
     If  getColumIndex(spr,"QtyStockfit") > -1 then z4002.QtyStockfit = getDataM(spr, getColumIndex(spr,"QtyStockfit"), xRow)
     If  getColumIndex(spr,"QtyStockfitA") > -1 then z4002.QtyStockfitA = getDataM(spr, getColumIndex(spr,"QtyStockfitA"), xRow)
     If  getColumIndex(spr,"QtyStockfitX") > -1 then z4002.QtyStockfitX = getDataM(spr, getColumIndex(spr,"QtyStockfitX"), xRow)
     If  getColumIndex(spr,"QtyStockfitBLOut") > -1 then z4002.QtyStockfitBLOut = getDataM(spr, getColumIndex(spr,"QtyStockfitBLOut"), xRow)
     If  getColumIndex(spr,"QtyStockfitBLIn") > -1 then z4002.QtyStockfitBLIn = getDataM(spr, getColumIndex(spr,"QtyStockfitBLIn"), xRow)
     If  getColumIndex(spr,"QtyAssembly") > -1 then z4002.QtyAssembly = getDataM(spr, getColumIndex(spr,"QtyAssembly"), xRow)
     If  getColumIndex(spr,"QtyAssemblyA") > -1 then z4002.QtyAssemblyA = getDataM(spr, getColumIndex(spr,"QtyAssemblyA"), xRow)
     If  getColumIndex(spr,"QtyAssemblyX") > -1 then z4002.QtyAssemblyX = getDataM(spr, getColumIndex(spr,"QtyAssemblyX"), xRow)
     If  getColumIndex(spr,"QtyAssemblyBLOut") > -1 then z4002.QtyAssemblyBLOut = getDataM(spr, getColumIndex(spr,"QtyAssemblyBLOut"), xRow)
     If  getColumIndex(spr,"QtyAssemblyBLIn") > -1 then z4002.QtyAssemblyBLIn = getDataM(spr, getColumIndex(spr,"QtyAssemblyBLIn"), xRow)
     If  getColumIndex(spr,"QtyJobShipping") > -1 then z4002.QtyJobShipping = getDataM(spr, getColumIndex(spr,"QtyJobShipping"), xRow)
     If  getColumIndex(spr,"QtyShipping") > -1 then z4002.QtyShipping = getDataM(spr, getColumIndex(spr,"QtyShipping"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z4002.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z4002.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z4002.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z4002.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"InchargeSales") > -1 then z4002.InchargeSales = getDataM(spr, getColumIndex(spr,"InchargeSales"), xRow)
     If  getColumIndex(spr,"InchargePPC") > -1 then z4002.InchargePPC = getDataM(spr, getColumIndex(spr,"InchargePPC"), xRow)
     If  getColumIndex(spr,"AttachID") > -1 then z4002.AttachID = getDataM(spr, getColumIndex(spr,"AttachID"), xRow)
     If  getColumIndex(spr,"chkMaterial") > -1 then z4002.chkMaterial = getDataM(spr, getColumIndex(spr,"chkMaterial"), xRow)
     If  getColumIndex(spr,"RemarkMaterial") > -1 then z4002.RemarkMaterial = getDataM(spr, getColumIndex(spr,"RemarkMaterial"), xRow)
     If  getColumIndex(spr,"InchargeMaterial") > -1 then z4002.InchargeMaterial = getDataM(spr, getColumIndex(spr,"InchargeMaterial"), xRow)
     If  getColumIndex(spr,"DateRemarkMaterial") > -1 then z4002.DateRemarkMaterial = getDataM(spr, getColumIndex(spr,"DateRemarkMaterial"), xRow)
     If  getColumIndex(spr,"chkSole") > -1 then z4002.chkSole = getDataM(spr, getColumIndex(spr,"chkSole"), xRow)
     If  getColumIndex(spr,"RemarkSole") > -1 then z4002.RemarkSole = getDataM(spr, getColumIndex(spr,"RemarkSole"), xRow)
     If  getColumIndex(spr,"InchargeSole") > -1 then z4002.InchargeSole = getDataM(spr, getColumIndex(spr,"InchargeSole"), xRow)
     If  getColumIndex(spr,"DateRemarkSole") > -1 then z4002.DateRemarkSole = getDataM(spr, getColumIndex(spr,"DateRemarkSole"), xRow)
     If  getColumIndex(spr,"chkLast") > -1 then z4002.chkLast = getDataM(spr, getColumIndex(spr,"chkLast"), xRow)
     If  getColumIndex(spr,"RemarkLast") > -1 then z4002.RemarkLast = getDataM(spr, getColumIndex(spr,"RemarkLast"), xRow)
     If  getColumIndex(spr,"InchargeLast") > -1 then z4002.InchargeLast = getDataM(spr, getColumIndex(spr,"InchargeLast"), xRow)
     If  getColumIndex(spr,"DateRemarkLast") > -1 then z4002.DateRemarkLast = getDataM(spr, getColumIndex(spr,"DateRemarkLast"), xRow)
     If  getColumIndex(spr,"chkMold") > -1 then z4002.chkMold = getDataM(spr, getColumIndex(spr,"chkMold"), xRow)
     If  getColumIndex(spr,"RemarkMold") > -1 then z4002.RemarkMold = getDataM(spr, getColumIndex(spr,"RemarkMold"), xRow)
     If  getColumIndex(spr,"InchargeMold") > -1 then z4002.InchargeMold = getDataM(spr, getColumIndex(spr,"InchargeMold"), xRow)
     If  getColumIndex(spr,"DateRemarkMold") > -1 then z4002.DateRemarkMold = getDataM(spr, getColumIndex(spr,"DateRemarkMold"), xRow)
     If  getColumIndex(spr,"chkSpec") > -1 then z4002.chkSpec = getDataM(spr, getColumIndex(spr,"chkSpec"), xRow)
     If  getColumIndex(spr,"RemarkSpec") > -1 then z4002.RemarkSpec = getDataM(spr, getColumIndex(spr,"RemarkSpec"), xRow)
     If  getColumIndex(spr,"InchargeSpec") > -1 then z4002.InchargeSpec = getDataM(spr, getColumIndex(spr,"InchargeSpec"), xRow)
     If  getColumIndex(spr,"DateRemarkSpec") > -1 then z4002.DateRemarkSpec = getDataM(spr, getColumIndex(spr,"DateRemarkSpec"), xRow)
     If  getColumIndex(spr,"chkTest") > -1 then z4002.chkTest = getDataM(spr, getColumIndex(spr,"chkTest"), xRow)
     If  getColumIndex(spr,"RemarkTest") > -1 then z4002.RemarkTest = getDataM(spr, getColumIndex(spr,"RemarkTest"), xRow)
     If  getColumIndex(spr,"InchargeTest") > -1 then z4002.InchargeTest = getDataM(spr, getColumIndex(spr,"InchargeTest"), xRow)
     If  getColumIndex(spr,"DateRemarkTest") > -1 then z4002.DateRemarkTest = getDataM(spr, getColumIndex(spr,"DateRemarkTest"), xRow)
     If  getColumIndex(spr,"chkCFM") > -1 then z4002.chkCFM = getDataM(spr, getColumIndex(spr,"chkCFM"), xRow)
     If  getColumIndex(spr,"RemarkCFM") > -1 then z4002.RemarkCFM = getDataM(spr, getColumIndex(spr,"RemarkCFM"), xRow)
     If  getColumIndex(spr,"InchargeCFM") > -1 then z4002.InchargeCFM = getDataM(spr, getColumIndex(spr,"InchargeCFM"), xRow)
     If  getColumIndex(spr,"DateRemarkCFM") > -1 then z4002.DateRemarkCFM = getDataM(spr, getColumIndex(spr,"DateRemarkCFM"), xRow)
     If  getColumIndex(spr,"FactorykAllocation") > -1 then z4002.FactorykAllocation = getDataM(spr, getColumIndex(spr,"FactorykAllocation"), xRow)
     If  getColumIndex(spr,"LineAllocation") > -1 then z4002.LineAllocation = getDataM(spr, getColumIndex(spr,"LineAllocation"), xRow)
     If  getColumIndex(spr,"RemarkAllocation") > -1 then z4002.RemarkAllocation = getDataM(spr, getColumIndex(spr,"RemarkAllocation"), xRow)
     If  getColumIndex(spr,"RemarkOrder") > -1 then z4002.RemarkOrder = getDataM(spr, getColumIndex(spr,"RemarkOrder"), xRow)
     If  getColumIndex(spr,"RemarkCustomer") > -1 then z4002.RemarkCustomer = getDataM(spr, getColumIndex(spr,"RemarkCustomer"), xRow)
     If  getColumIndex(spr,"RemarkOther") > -1 then z4002.RemarkOther = getDataM(spr, getColumIndex(spr,"RemarkOther"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z4002.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K4002_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K4002_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z4002 As T4002_AREA, Job as String, WORKORDER AS String, WORKORDERSEQ AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K4002_MOVE = False

Try
    If READ_PFK4002(WORKORDER, WORKORDERSEQ) = True Then
                z4002 = D4002
		K4002_MOVE = True
		else
	z4002 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4002")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "WORKORDER":z4002.WorkOrder = Children(i).Code
   Case "WORKORDERSEQ":z4002.WorkOrderSeq = Children(i).Code
   Case "ORDERNO":z4002.OrderNo = Children(i).Code
   Case "ORDERNOSEQ":z4002.OrderNoSeq = Children(i).Code
   Case "SLNO":z4002.SLNo = Children(i).Code
   Case "SEALMASTER":z4002.SealMaster = Children(i).Code
   Case "WORKORDERSTATUS":z4002.WorkOrderStatus = Children(i).Code
   Case "DATEAPPROVAL":z4002.DateApproval = Children(i).Code
   Case "DATECANCEL":z4002.DateCancel = Children(i).Code
   Case "DATECOMPLETE":z4002.DateComplete = Children(i).Code
   Case "DATEPENDING":z4002.DatePending = Children(i).Code
   Case "DATEDELIVERY":z4002.DateDelivery = Children(i).Code
   Case "DATETRANSFER":z4002.DateTransfer = Children(i).Code
   Case "DATEACCEPT":z4002.DateAccept = Children(i).Code
   Case "ACCEPTEDORDER":z4002.AcceptedOrder = Children(i).Code
   Case "MATERIALSTATUS":z4002.MaterialStatus = Children(i).Code
   Case "SOLENO":z4002.SoleNo = Children(i).Code
   Case "CUTTINGNO":z4002.CuttingNo = Children(i).Code
   Case "STITCHINGNO":z4002.StitchingNo = Children(i).Code
   Case "SUBPROCESSNO":z4002.SubprocessNo = Children(i).Code
   Case "OUTSOURCENO":z4002.OutsourceNo = Children(i).Code
   Case "STOCKFITNO":z4002.StockfitNo = Children(i).Code
   Case "ASSEMBLYNO":z4002.AssemblyNo = Children(i).Code
   Case "CUTTINGSTATUS":z4002.CuttingStatus = Children(i).Code
   Case "STITCHINGSTATUS":z4002.StitchingStatus = Children(i).Code
   Case "SUBPROCESSSTATUS":z4002.SubprocessStatus = Children(i).Code
   Case "OUTSOURCESTATSUS":z4002.OutsourceStatsus = Children(i).Code
   Case "STOCKFITSTATSUS":z4002.StockfitStatsus = Children(i).Code
   Case "ASSEMBLYSTATUS":z4002.AssemblyStatus = Children(i).Code
   Case "SOLESTATUS":z4002.SoleStatus = Children(i).Code
   Case "DATEPATTERN":z4002.DatePattern = Children(i).Code
   Case "DATEMATERIAL":z4002.DateMaterial = Children(i).Code
   Case "DATEPLANNING":z4002.DatePlanning = Children(i).Code
   Case "DATERND":z4002.DateRnD = Children(i).Code
   Case "DATECONFIRM":z4002.DateConfirm = Children(i).Code
   Case "DATESTART":z4002.DateStart = Children(i).Code
   Case "DATEFINISH":z4002.DateFinish = Children(i).Code
   Case "DATESOLE":z4002.DateSole = Children(i).Code
   Case "DATECUTTING":z4002.DateCutting = Children(i).Code
   Case "DATESTITCHING":z4002.DateStitching = Children(i).Code
   Case "DATESTOCKFIT":z4002.DateStockfit = Children(i).Code
   Case "DATEASSEMBLY":z4002.DateAssembly = Children(i).Code
   Case "DATESHIPPING":z4002.DateShipping = Children(i).Code
   Case "SEUNITMATERIAL":z4002.seUnitMaterial = Children(i).Code
   Case "CDUNITMATERIAL":z4002.cdUnitMaterial = Children(i).Code
   Case "SEUNITPACKING":z4002.seUnitPacking = Children(i).Code
   Case "CDUNITPACKING":z4002.cdUnitPacking = Children(i).Code
   Case "QTYORDER":z4002.QtyOrder = Children(i).Code
   Case "QTYBOOKING":z4002.QtyBooking = Children(i).Code
   Case "QTYJOB":z4002.QtyJob = Children(i).Code
   Case "QTYPLAN":z4002.QtyPlan = Children(i).Code
   Case "QTYSOLE":z4002.QtySole = Children(i).Code
   Case "QTYSOLEA":z4002.QtySoleA = Children(i).Code
   Case "QTYSOLEX":z4002.QtySoleX = Children(i).Code
   Case "QTYSOLEBLOUT":z4002.QtySoleBLOut = Children(i).Code
   Case "QTYSOLEBLIN":z4002.QtySoleBLIn = Children(i).Code
   Case "QTYCUTTING":z4002.QtyCutting = Children(i).Code
   Case "QTYCUTTINGA":z4002.QtyCuttingA = Children(i).Code
   Case "QTYCUTTINGX":z4002.QtyCuttingX = Children(i).Code
   Case "QTYCUTTINGBLOUT":z4002.QtyCuttingBLOut = Children(i).Code
   Case "QTYCUTTINGBLIN":z4002.QtyCuttingBLIn = Children(i).Code
   Case "QTYSTITCHING":z4002.QtyStitching = Children(i).Code
   Case "QTYSTITCHINGA":z4002.QtyStitchingA = Children(i).Code
   Case "QTYSTITCHINGX":z4002.QtyStitchingX = Children(i).Code
   Case "QTYSTITCHINGBLOUT":z4002.QtyStitchingBLOut = Children(i).Code
   Case "QTYSTITCHINGBLIN":z4002.QtyStitchingBLIn = Children(i).Code
   Case "QTYSTOCKFIT":z4002.QtyStockfit = Children(i).Code
   Case "QTYSTOCKFITA":z4002.QtyStockfitA = Children(i).Code
   Case "QTYSTOCKFITX":z4002.QtyStockfitX = Children(i).Code
   Case "QTYSTOCKFITBLOUT":z4002.QtyStockfitBLOut = Children(i).Code
   Case "QTYSTOCKFITBLIN":z4002.QtyStockfitBLIn = Children(i).Code
   Case "QTYASSEMBLY":z4002.QtyAssembly = Children(i).Code
   Case "QTYASSEMBLYA":z4002.QtyAssemblyA = Children(i).Code
   Case "QTYASSEMBLYX":z4002.QtyAssemblyX = Children(i).Code
   Case "QTYASSEMBLYBLOUT":z4002.QtyAssemblyBLOut = Children(i).Code
   Case "QTYASSEMBLYBLIN":z4002.QtyAssemblyBLIn = Children(i).Code
   Case "QTYJOBSHIPPING":z4002.QtyJobShipping = Children(i).Code
   Case "QTYSHIPPING":z4002.QtyShipping = Children(i).Code
   Case "DATEINSERT":z4002.DateInsert = Children(i).Code
   Case "INCHARGEINSERT":z4002.InchargeInsert = Children(i).Code
   Case "DATEUPDATE":z4002.DateUpdate = Children(i).Code
   Case "INCHARGEUPDATE":z4002.InchargeUpdate = Children(i).Code
   Case "INCHARGESALES":z4002.InchargeSales = Children(i).Code
   Case "INCHARGEPPC":z4002.InchargePPC = Children(i).Code
   Case "ATTACHID":z4002.AttachID = Children(i).Code
   Case "CHKMATERIAL":z4002.chkMaterial = Children(i).Code
   Case "REMARKMATERIAL":z4002.RemarkMaterial = Children(i).Code
   Case "INCHARGEMATERIAL":z4002.InchargeMaterial = Children(i).Code
   Case "DATEREMARKMATERIAL":z4002.DateRemarkMaterial = Children(i).Code
   Case "CHKSOLE":z4002.chkSole = Children(i).Code
   Case "REMARKSOLE":z4002.RemarkSole = Children(i).Code
   Case "INCHARGESOLE":z4002.InchargeSole = Children(i).Code
   Case "DATEREMARKSOLE":z4002.DateRemarkSole = Children(i).Code
   Case "CHKLAST":z4002.chkLast = Children(i).Code
   Case "REMARKLAST":z4002.RemarkLast = Children(i).Code
   Case "INCHARGELAST":z4002.InchargeLast = Children(i).Code
   Case "DATEREMARKLAST":z4002.DateRemarkLast = Children(i).Code
   Case "CHKMOLD":z4002.chkMold = Children(i).Code
   Case "REMARKMOLD":z4002.RemarkMold = Children(i).Code
   Case "INCHARGEMOLD":z4002.InchargeMold = Children(i).Code
   Case "DATEREMARKMOLD":z4002.DateRemarkMold = Children(i).Code
   Case "CHKSPEC":z4002.chkSpec = Children(i).Code
   Case "REMARKSPEC":z4002.RemarkSpec = Children(i).Code
   Case "INCHARGESPEC":z4002.InchargeSpec = Children(i).Code
   Case "DATEREMARKSPEC":z4002.DateRemarkSpec = Children(i).Code
   Case "CHKTEST":z4002.chkTest = Children(i).Code
   Case "REMARKTEST":z4002.RemarkTest = Children(i).Code
   Case "INCHARGETEST":z4002.InchargeTest = Children(i).Code
   Case "DATEREMARKTEST":z4002.DateRemarkTest = Children(i).Code
   Case "CHKCFM":z4002.chkCFM = Children(i).Code
   Case "REMARKCFM":z4002.RemarkCFM = Children(i).Code
   Case "INCHARGECFM":z4002.InchargeCFM = Children(i).Code
   Case "DATEREMARKCFM":z4002.DateRemarkCFM = Children(i).Code
   Case "FACTORYKALLOCATION":z4002.FactorykAllocation = Children(i).Code
   Case "LINEALLOCATION":z4002.LineAllocation = Children(i).Code
   Case "REMARKALLOCATION":z4002.RemarkAllocation = Children(i).Code
   Case "REMARKORDER":z4002.RemarkOrder = Children(i).Code
   Case "REMARKCUSTOMER":z4002.RemarkCustomer = Children(i).Code
   Case "REMARKOTHER":z4002.RemarkOther = Children(i).Code
   Case "REMARK":z4002.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "WORKORDER":z4002.WorkOrder = Children(i).Data
   Case "WORKORDERSEQ":z4002.WorkOrderSeq = Children(i).Data
   Case "ORDERNO":z4002.OrderNo = Children(i).Data
   Case "ORDERNOSEQ":z4002.OrderNoSeq = Children(i).Data
   Case "SLNO":z4002.SLNo = Children(i).Data
   Case "SEALMASTER":z4002.SealMaster = Children(i).Data
   Case "WORKORDERSTATUS":z4002.WorkOrderStatus = Children(i).Data
   Case "DATEAPPROVAL":z4002.DateApproval = Children(i).Data
   Case "DATECANCEL":z4002.DateCancel = Children(i).Data
   Case "DATECOMPLETE":z4002.DateComplete = Children(i).Data
   Case "DATEPENDING":z4002.DatePending = Children(i).Data
   Case "DATEDELIVERY":z4002.DateDelivery = Children(i).Data
   Case "DATETRANSFER":z4002.DateTransfer = Children(i).Data
   Case "DATEACCEPT":z4002.DateAccept = Children(i).Data
   Case "ACCEPTEDORDER":z4002.AcceptedOrder = Children(i).Data
   Case "MATERIALSTATUS":z4002.MaterialStatus = Children(i).Data
   Case "SOLENO":z4002.SoleNo = Children(i).Data
   Case "CUTTINGNO":z4002.CuttingNo = Children(i).Data
   Case "STITCHINGNO":z4002.StitchingNo = Children(i).Data
   Case "SUBPROCESSNO":z4002.SubprocessNo = Children(i).Data
   Case "OUTSOURCENO":z4002.OutsourceNo = Children(i).Data
   Case "STOCKFITNO":z4002.StockfitNo = Children(i).Data
   Case "ASSEMBLYNO":z4002.AssemblyNo = Children(i).Data
   Case "CUTTINGSTATUS":z4002.CuttingStatus = Children(i).Data
   Case "STITCHINGSTATUS":z4002.StitchingStatus = Children(i).Data
   Case "SUBPROCESSSTATUS":z4002.SubprocessStatus = Children(i).Data
   Case "OUTSOURCESTATSUS":z4002.OutsourceStatsus = Children(i).Data
   Case "STOCKFITSTATSUS":z4002.StockfitStatsus = Children(i).Data
   Case "ASSEMBLYSTATUS":z4002.AssemblyStatus = Children(i).Data
   Case "SOLESTATUS":z4002.SoleStatus = Children(i).Data
   Case "DATEPATTERN":z4002.DatePattern = Children(i).Data
   Case "DATEMATERIAL":z4002.DateMaterial = Children(i).Data
   Case "DATEPLANNING":z4002.DatePlanning = Children(i).Data
   Case "DATERND":z4002.DateRnD = Children(i).Data
   Case "DATECONFIRM":z4002.DateConfirm = Children(i).Data
   Case "DATESTART":z4002.DateStart = Children(i).Data
   Case "DATEFINISH":z4002.DateFinish = Children(i).Data
   Case "DATESOLE":z4002.DateSole = Children(i).Data
   Case "DATECUTTING":z4002.DateCutting = Children(i).Data
   Case "DATESTITCHING":z4002.DateStitching = Children(i).Data
   Case "DATESTOCKFIT":z4002.DateStockfit = Children(i).Data
   Case "DATEASSEMBLY":z4002.DateAssembly = Children(i).Data
   Case "DATESHIPPING":z4002.DateShipping = Children(i).Data
   Case "SEUNITMATERIAL":z4002.seUnitMaterial = Children(i).Data
   Case "CDUNITMATERIAL":z4002.cdUnitMaterial = Children(i).Data
   Case "SEUNITPACKING":z4002.seUnitPacking = Children(i).Data
   Case "CDUNITPACKING":z4002.cdUnitPacking = Children(i).Data
   Case "QTYORDER":z4002.QtyOrder = Children(i).Data
   Case "QTYBOOKING":z4002.QtyBooking = Children(i).Data
   Case "QTYJOB":z4002.QtyJob = Children(i).Data
   Case "QTYPLAN":z4002.QtyPlan = Children(i).Data
   Case "QTYSOLE":z4002.QtySole = Children(i).Data
   Case "QTYSOLEA":z4002.QtySoleA = Children(i).Data
   Case "QTYSOLEX":z4002.QtySoleX = Children(i).Data
   Case "QTYSOLEBLOUT":z4002.QtySoleBLOut = Children(i).Data
   Case "QTYSOLEBLIN":z4002.QtySoleBLIn = Children(i).Data
   Case "QTYCUTTING":z4002.QtyCutting = Children(i).Data
   Case "QTYCUTTINGA":z4002.QtyCuttingA = Children(i).Data
   Case "QTYCUTTINGX":z4002.QtyCuttingX = Children(i).Data
   Case "QTYCUTTINGBLOUT":z4002.QtyCuttingBLOut = Children(i).Data
   Case "QTYCUTTINGBLIN":z4002.QtyCuttingBLIn = Children(i).Data
   Case "QTYSTITCHING":z4002.QtyStitching = Children(i).Data
   Case "QTYSTITCHINGA":z4002.QtyStitchingA = Children(i).Data
   Case "QTYSTITCHINGX":z4002.QtyStitchingX = Children(i).Data
   Case "QTYSTITCHINGBLOUT":z4002.QtyStitchingBLOut = Children(i).Data
   Case "QTYSTITCHINGBLIN":z4002.QtyStitchingBLIn = Children(i).Data
   Case "QTYSTOCKFIT":z4002.QtyStockfit = Children(i).Data
   Case "QTYSTOCKFITA":z4002.QtyStockfitA = Children(i).Data
   Case "QTYSTOCKFITX":z4002.QtyStockfitX = Children(i).Data
   Case "QTYSTOCKFITBLOUT":z4002.QtyStockfitBLOut = Children(i).Data
   Case "QTYSTOCKFITBLIN":z4002.QtyStockfitBLIn = Children(i).Data
   Case "QTYASSEMBLY":z4002.QtyAssembly = Children(i).Data
   Case "QTYASSEMBLYA":z4002.QtyAssemblyA = Children(i).Data
   Case "QTYASSEMBLYX":z4002.QtyAssemblyX = Children(i).Data
   Case "QTYASSEMBLYBLOUT":z4002.QtyAssemblyBLOut = Children(i).Data
   Case "QTYASSEMBLYBLIN":z4002.QtyAssemblyBLIn = Children(i).Data
   Case "QTYJOBSHIPPING":z4002.QtyJobShipping = Children(i).Data
   Case "QTYSHIPPING":z4002.QtyShipping = Children(i).Data
   Case "DATEINSERT":z4002.DateInsert = Children(i).Data
   Case "INCHARGEINSERT":z4002.InchargeInsert = Children(i).Data
   Case "DATEUPDATE":z4002.DateUpdate = Children(i).Data
   Case "INCHARGEUPDATE":z4002.InchargeUpdate = Children(i).Data
   Case "INCHARGESALES":z4002.InchargeSales = Children(i).Data
   Case "INCHARGEPPC":z4002.InchargePPC = Children(i).Data
   Case "ATTACHID":z4002.AttachID = Children(i).Data
   Case "CHKMATERIAL":z4002.chkMaterial = Children(i).Data
   Case "REMARKMATERIAL":z4002.RemarkMaterial = Children(i).Data
   Case "INCHARGEMATERIAL":z4002.InchargeMaterial = Children(i).Data
   Case "DATEREMARKMATERIAL":z4002.DateRemarkMaterial = Children(i).Data
   Case "CHKSOLE":z4002.chkSole = Children(i).Data
   Case "REMARKSOLE":z4002.RemarkSole = Children(i).Data
   Case "INCHARGESOLE":z4002.InchargeSole = Children(i).Data
   Case "DATEREMARKSOLE":z4002.DateRemarkSole = Children(i).Data
   Case "CHKLAST":z4002.chkLast = Children(i).Data
   Case "REMARKLAST":z4002.RemarkLast = Children(i).Data
   Case "INCHARGELAST":z4002.InchargeLast = Children(i).Data
   Case "DATEREMARKLAST":z4002.DateRemarkLast = Children(i).Data
   Case "CHKMOLD":z4002.chkMold = Children(i).Data
   Case "REMARKMOLD":z4002.RemarkMold = Children(i).Data
   Case "INCHARGEMOLD":z4002.InchargeMold = Children(i).Data
   Case "DATEREMARKMOLD":z4002.DateRemarkMold = Children(i).Data
   Case "CHKSPEC":z4002.chkSpec = Children(i).Data
   Case "REMARKSPEC":z4002.RemarkSpec = Children(i).Data
   Case "INCHARGESPEC":z4002.InchargeSpec = Children(i).Data
   Case "DATEREMARKSPEC":z4002.DateRemarkSpec = Children(i).Data
   Case "CHKTEST":z4002.chkTest = Children(i).Data
   Case "REMARKTEST":z4002.RemarkTest = Children(i).Data
   Case "INCHARGETEST":z4002.InchargeTest = Children(i).Data
   Case "DATEREMARKTEST":z4002.DateRemarkTest = Children(i).Data
   Case "CHKCFM":z4002.chkCFM = Children(i).Data
   Case "REMARKCFM":z4002.RemarkCFM = Children(i).Data
   Case "INCHARGECFM":z4002.InchargeCFM = Children(i).Data
   Case "DATEREMARKCFM":z4002.DateRemarkCFM = Children(i).Data
   Case "FACTORYKALLOCATION":z4002.FactorykAllocation = Children(i).Data
   Case "LINEALLOCATION":z4002.LineAllocation = Children(i).Data
   Case "REMARKALLOCATION":z4002.RemarkAllocation = Children(i).Data
   Case "REMARKORDER":z4002.RemarkOrder = Children(i).Data
   Case "REMARKCUSTOMER":z4002.RemarkCustomer = Children(i).Data
   Case "REMARKOTHER":z4002.RemarkOther = Children(i).Data
   Case "REMARK":z4002.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K4002_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K4002_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z4002 As T4002_AREA, Job as String, CheckClear as Boolean, WORKORDER AS String, WORKORDERSEQ AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K4002_MOVE = False

Try
    If READ_PFK4002(WORKORDER, WORKORDERSEQ) = True Then
                z4002 = D4002
		K4002_MOVE = True
		else
	If CheckClear  = True then z4002 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4002")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "WORKORDER":z4002.WorkOrder = Children(i).Code
   Case "WORKORDERSEQ":z4002.WorkOrderSeq = Children(i).Code
   Case "ORDERNO":z4002.OrderNo = Children(i).Code
   Case "ORDERNOSEQ":z4002.OrderNoSeq = Children(i).Code
   Case "SLNO":z4002.SLNo = Children(i).Code
   Case "SEALMASTER":z4002.SealMaster = Children(i).Code
   Case "WORKORDERSTATUS":z4002.WorkOrderStatus = Children(i).Code
   Case "DATEAPPROVAL":z4002.DateApproval = Children(i).Code
   Case "DATECANCEL":z4002.DateCancel = Children(i).Code
   Case "DATECOMPLETE":z4002.DateComplete = Children(i).Code
   Case "DATEPENDING":z4002.DatePending = Children(i).Code
   Case "DATEDELIVERY":z4002.DateDelivery = Children(i).Code
   Case "DATETRANSFER":z4002.DateTransfer = Children(i).Code
   Case "DATEACCEPT":z4002.DateAccept = Children(i).Code
   Case "ACCEPTEDORDER":z4002.AcceptedOrder = Children(i).Code
   Case "MATERIALSTATUS":z4002.MaterialStatus = Children(i).Code
   Case "SOLENO":z4002.SoleNo = Children(i).Code
   Case "CUTTINGNO":z4002.CuttingNo = Children(i).Code
   Case "STITCHINGNO":z4002.StitchingNo = Children(i).Code
   Case "SUBPROCESSNO":z4002.SubprocessNo = Children(i).Code
   Case "OUTSOURCENO":z4002.OutsourceNo = Children(i).Code
   Case "STOCKFITNO":z4002.StockfitNo = Children(i).Code
   Case "ASSEMBLYNO":z4002.AssemblyNo = Children(i).Code
   Case "CUTTINGSTATUS":z4002.CuttingStatus = Children(i).Code
   Case "STITCHINGSTATUS":z4002.StitchingStatus = Children(i).Code
   Case "SUBPROCESSSTATUS":z4002.SubprocessStatus = Children(i).Code
   Case "OUTSOURCESTATSUS":z4002.OutsourceStatsus = Children(i).Code
   Case "STOCKFITSTATSUS":z4002.StockfitStatsus = Children(i).Code
   Case "ASSEMBLYSTATUS":z4002.AssemblyStatus = Children(i).Code
   Case "SOLESTATUS":z4002.SoleStatus = Children(i).Code
   Case "DATEPATTERN":z4002.DatePattern = Children(i).Code
   Case "DATEMATERIAL":z4002.DateMaterial = Children(i).Code
   Case "DATEPLANNING":z4002.DatePlanning = Children(i).Code
   Case "DATERND":z4002.DateRnD = Children(i).Code
   Case "DATECONFIRM":z4002.DateConfirm = Children(i).Code
   Case "DATESTART":z4002.DateStart = Children(i).Code
   Case "DATEFINISH":z4002.DateFinish = Children(i).Code
   Case "DATESOLE":z4002.DateSole = Children(i).Code
   Case "DATECUTTING":z4002.DateCutting = Children(i).Code
   Case "DATESTITCHING":z4002.DateStitching = Children(i).Code
   Case "DATESTOCKFIT":z4002.DateStockfit = Children(i).Code
   Case "DATEASSEMBLY":z4002.DateAssembly = Children(i).Code
   Case "DATESHIPPING":z4002.DateShipping = Children(i).Code
   Case "SEUNITMATERIAL":z4002.seUnitMaterial = Children(i).Code
   Case "CDUNITMATERIAL":z4002.cdUnitMaterial = Children(i).Code
   Case "SEUNITPACKING":z4002.seUnitPacking = Children(i).Code
   Case "CDUNITPACKING":z4002.cdUnitPacking = Children(i).Code
   Case "QTYORDER":z4002.QtyOrder = Children(i).Code
   Case "QTYBOOKING":z4002.QtyBooking = Children(i).Code
   Case "QTYJOB":z4002.QtyJob = Children(i).Code
   Case "QTYPLAN":z4002.QtyPlan = Children(i).Code
   Case "QTYSOLE":z4002.QtySole = Children(i).Code
   Case "QTYSOLEA":z4002.QtySoleA = Children(i).Code
   Case "QTYSOLEX":z4002.QtySoleX = Children(i).Code
   Case "QTYSOLEBLOUT":z4002.QtySoleBLOut = Children(i).Code
   Case "QTYSOLEBLIN":z4002.QtySoleBLIn = Children(i).Code
   Case "QTYCUTTING":z4002.QtyCutting = Children(i).Code
   Case "QTYCUTTINGA":z4002.QtyCuttingA = Children(i).Code
   Case "QTYCUTTINGX":z4002.QtyCuttingX = Children(i).Code
   Case "QTYCUTTINGBLOUT":z4002.QtyCuttingBLOut = Children(i).Code
   Case "QTYCUTTINGBLIN":z4002.QtyCuttingBLIn = Children(i).Code
   Case "QTYSTITCHING":z4002.QtyStitching = Children(i).Code
   Case "QTYSTITCHINGA":z4002.QtyStitchingA = Children(i).Code
   Case "QTYSTITCHINGX":z4002.QtyStitchingX = Children(i).Code
   Case "QTYSTITCHINGBLOUT":z4002.QtyStitchingBLOut = Children(i).Code
   Case "QTYSTITCHINGBLIN":z4002.QtyStitchingBLIn = Children(i).Code
   Case "QTYSTOCKFIT":z4002.QtyStockfit = Children(i).Code
   Case "QTYSTOCKFITA":z4002.QtyStockfitA = Children(i).Code
   Case "QTYSTOCKFITX":z4002.QtyStockfitX = Children(i).Code
   Case "QTYSTOCKFITBLOUT":z4002.QtyStockfitBLOut = Children(i).Code
   Case "QTYSTOCKFITBLIN":z4002.QtyStockfitBLIn = Children(i).Code
   Case "QTYASSEMBLY":z4002.QtyAssembly = Children(i).Code
   Case "QTYASSEMBLYA":z4002.QtyAssemblyA = Children(i).Code
   Case "QTYASSEMBLYX":z4002.QtyAssemblyX = Children(i).Code
   Case "QTYASSEMBLYBLOUT":z4002.QtyAssemblyBLOut = Children(i).Code
   Case "QTYASSEMBLYBLIN":z4002.QtyAssemblyBLIn = Children(i).Code
   Case "QTYJOBSHIPPING":z4002.QtyJobShipping = Children(i).Code
   Case "QTYSHIPPING":z4002.QtyShipping = Children(i).Code
   Case "DATEINSERT":z4002.DateInsert = Children(i).Code
   Case "INCHARGEINSERT":z4002.InchargeInsert = Children(i).Code
   Case "DATEUPDATE":z4002.DateUpdate = Children(i).Code
   Case "INCHARGEUPDATE":z4002.InchargeUpdate = Children(i).Code
   Case "INCHARGESALES":z4002.InchargeSales = Children(i).Code
   Case "INCHARGEPPC":z4002.InchargePPC = Children(i).Code
   Case "ATTACHID":z4002.AttachID = Children(i).Code
   Case "CHKMATERIAL":z4002.chkMaterial = Children(i).Code
   Case "REMARKMATERIAL":z4002.RemarkMaterial = Children(i).Code
   Case "INCHARGEMATERIAL":z4002.InchargeMaterial = Children(i).Code
   Case "DATEREMARKMATERIAL":z4002.DateRemarkMaterial = Children(i).Code
   Case "CHKSOLE":z4002.chkSole = Children(i).Code
   Case "REMARKSOLE":z4002.RemarkSole = Children(i).Code
   Case "INCHARGESOLE":z4002.InchargeSole = Children(i).Code
   Case "DATEREMARKSOLE":z4002.DateRemarkSole = Children(i).Code
   Case "CHKLAST":z4002.chkLast = Children(i).Code
   Case "REMARKLAST":z4002.RemarkLast = Children(i).Code
   Case "INCHARGELAST":z4002.InchargeLast = Children(i).Code
   Case "DATEREMARKLAST":z4002.DateRemarkLast = Children(i).Code
   Case "CHKMOLD":z4002.chkMold = Children(i).Code
   Case "REMARKMOLD":z4002.RemarkMold = Children(i).Code
   Case "INCHARGEMOLD":z4002.InchargeMold = Children(i).Code
   Case "DATEREMARKMOLD":z4002.DateRemarkMold = Children(i).Code
   Case "CHKSPEC":z4002.chkSpec = Children(i).Code
   Case "REMARKSPEC":z4002.RemarkSpec = Children(i).Code
   Case "INCHARGESPEC":z4002.InchargeSpec = Children(i).Code
   Case "DATEREMARKSPEC":z4002.DateRemarkSpec = Children(i).Code
   Case "CHKTEST":z4002.chkTest = Children(i).Code
   Case "REMARKTEST":z4002.RemarkTest = Children(i).Code
   Case "INCHARGETEST":z4002.InchargeTest = Children(i).Code
   Case "DATEREMARKTEST":z4002.DateRemarkTest = Children(i).Code
   Case "CHKCFM":z4002.chkCFM = Children(i).Code
   Case "REMARKCFM":z4002.RemarkCFM = Children(i).Code
   Case "INCHARGECFM":z4002.InchargeCFM = Children(i).Code
   Case "DATEREMARKCFM":z4002.DateRemarkCFM = Children(i).Code
   Case "FACTORYKALLOCATION":z4002.FactorykAllocation = Children(i).Code
   Case "LINEALLOCATION":z4002.LineAllocation = Children(i).Code
   Case "REMARKALLOCATION":z4002.RemarkAllocation = Children(i).Code
   Case "REMARKORDER":z4002.RemarkOrder = Children(i).Code
   Case "REMARKCUSTOMER":z4002.RemarkCustomer = Children(i).Code
   Case "REMARKOTHER":z4002.RemarkOther = Children(i).Code
   Case "REMARK":z4002.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "WORKORDER":z4002.WorkOrder = Children(i).Data
   Case "WORKORDERSEQ":z4002.WorkOrderSeq = Children(i).Data
   Case "ORDERNO":z4002.OrderNo = Children(i).Data
   Case "ORDERNOSEQ":z4002.OrderNoSeq = Children(i).Data
   Case "SLNO":z4002.SLNo = Children(i).Data
   Case "SEALMASTER":z4002.SealMaster = Children(i).Data
   Case "WORKORDERSTATUS":z4002.WorkOrderStatus = Children(i).Data
   Case "DATEAPPROVAL":z4002.DateApproval = Children(i).Data
   Case "DATECANCEL":z4002.DateCancel = Children(i).Data
   Case "DATECOMPLETE":z4002.DateComplete = Children(i).Data
   Case "DATEPENDING":z4002.DatePending = Children(i).Data
   Case "DATEDELIVERY":z4002.DateDelivery = Children(i).Data
   Case "DATETRANSFER":z4002.DateTransfer = Children(i).Data
   Case "DATEACCEPT":z4002.DateAccept = Children(i).Data
   Case "ACCEPTEDORDER":z4002.AcceptedOrder = Children(i).Data
   Case "MATERIALSTATUS":z4002.MaterialStatus = Children(i).Data
   Case "SOLENO":z4002.SoleNo = Children(i).Data
   Case "CUTTINGNO":z4002.CuttingNo = Children(i).Data
   Case "STITCHINGNO":z4002.StitchingNo = Children(i).Data
   Case "SUBPROCESSNO":z4002.SubprocessNo = Children(i).Data
   Case "OUTSOURCENO":z4002.OutsourceNo = Children(i).Data
   Case "STOCKFITNO":z4002.StockfitNo = Children(i).Data
   Case "ASSEMBLYNO":z4002.AssemblyNo = Children(i).Data
   Case "CUTTINGSTATUS":z4002.CuttingStatus = Children(i).Data
   Case "STITCHINGSTATUS":z4002.StitchingStatus = Children(i).Data
   Case "SUBPROCESSSTATUS":z4002.SubprocessStatus = Children(i).Data
   Case "OUTSOURCESTATSUS":z4002.OutsourceStatsus = Children(i).Data
   Case "STOCKFITSTATSUS":z4002.StockfitStatsus = Children(i).Data
   Case "ASSEMBLYSTATUS":z4002.AssemblyStatus = Children(i).Data
   Case "SOLESTATUS":z4002.SoleStatus = Children(i).Data
   Case "DATEPATTERN":z4002.DatePattern = Children(i).Data
   Case "DATEMATERIAL":z4002.DateMaterial = Children(i).Data
   Case "DATEPLANNING":z4002.DatePlanning = Children(i).Data
   Case "DATERND":z4002.DateRnD = Children(i).Data
   Case "DATECONFIRM":z4002.DateConfirm = Children(i).Data
   Case "DATESTART":z4002.DateStart = Children(i).Data
   Case "DATEFINISH":z4002.DateFinish = Children(i).Data
   Case "DATESOLE":z4002.DateSole = Children(i).Data
   Case "DATECUTTING":z4002.DateCutting = Children(i).Data
   Case "DATESTITCHING":z4002.DateStitching = Children(i).Data
   Case "DATESTOCKFIT":z4002.DateStockfit = Children(i).Data
   Case "DATEASSEMBLY":z4002.DateAssembly = Children(i).Data
   Case "DATESHIPPING":z4002.DateShipping = Children(i).Data
   Case "SEUNITMATERIAL":z4002.seUnitMaterial = Children(i).Data
   Case "CDUNITMATERIAL":z4002.cdUnitMaterial = Children(i).Data
   Case "SEUNITPACKING":z4002.seUnitPacking = Children(i).Data
   Case "CDUNITPACKING":z4002.cdUnitPacking = Children(i).Data
   Case "QTYORDER":z4002.QtyOrder = Children(i).Data
   Case "QTYBOOKING":z4002.QtyBooking = Children(i).Data
   Case "QTYJOB":z4002.QtyJob = Children(i).Data
   Case "QTYPLAN":z4002.QtyPlan = Children(i).Data
   Case "QTYSOLE":z4002.QtySole = Children(i).Data
   Case "QTYSOLEA":z4002.QtySoleA = Children(i).Data
   Case "QTYSOLEX":z4002.QtySoleX = Children(i).Data
   Case "QTYSOLEBLOUT":z4002.QtySoleBLOut = Children(i).Data
   Case "QTYSOLEBLIN":z4002.QtySoleBLIn = Children(i).Data
   Case "QTYCUTTING":z4002.QtyCutting = Children(i).Data
   Case "QTYCUTTINGA":z4002.QtyCuttingA = Children(i).Data
   Case "QTYCUTTINGX":z4002.QtyCuttingX = Children(i).Data
   Case "QTYCUTTINGBLOUT":z4002.QtyCuttingBLOut = Children(i).Data
   Case "QTYCUTTINGBLIN":z4002.QtyCuttingBLIn = Children(i).Data
   Case "QTYSTITCHING":z4002.QtyStitching = Children(i).Data
   Case "QTYSTITCHINGA":z4002.QtyStitchingA = Children(i).Data
   Case "QTYSTITCHINGX":z4002.QtyStitchingX = Children(i).Data
   Case "QTYSTITCHINGBLOUT":z4002.QtyStitchingBLOut = Children(i).Data
   Case "QTYSTITCHINGBLIN":z4002.QtyStitchingBLIn = Children(i).Data
   Case "QTYSTOCKFIT":z4002.QtyStockfit = Children(i).Data
   Case "QTYSTOCKFITA":z4002.QtyStockfitA = Children(i).Data
   Case "QTYSTOCKFITX":z4002.QtyStockfitX = Children(i).Data
   Case "QTYSTOCKFITBLOUT":z4002.QtyStockfitBLOut = Children(i).Data
   Case "QTYSTOCKFITBLIN":z4002.QtyStockfitBLIn = Children(i).Data
   Case "QTYASSEMBLY":z4002.QtyAssembly = Children(i).Data
   Case "QTYASSEMBLYA":z4002.QtyAssemblyA = Children(i).Data
   Case "QTYASSEMBLYX":z4002.QtyAssemblyX = Children(i).Data
   Case "QTYASSEMBLYBLOUT":z4002.QtyAssemblyBLOut = Children(i).Data
   Case "QTYASSEMBLYBLIN":z4002.QtyAssemblyBLIn = Children(i).Data
   Case "QTYJOBSHIPPING":z4002.QtyJobShipping = Children(i).Data
   Case "QTYSHIPPING":z4002.QtyShipping = Children(i).Data
   Case "DATEINSERT":z4002.DateInsert = Children(i).Data
   Case "INCHARGEINSERT":z4002.InchargeInsert = Children(i).Data
   Case "DATEUPDATE":z4002.DateUpdate = Children(i).Data
   Case "INCHARGEUPDATE":z4002.InchargeUpdate = Children(i).Data
   Case "INCHARGESALES":z4002.InchargeSales = Children(i).Data
   Case "INCHARGEPPC":z4002.InchargePPC = Children(i).Data
   Case "ATTACHID":z4002.AttachID = Children(i).Data
   Case "CHKMATERIAL":z4002.chkMaterial = Children(i).Data
   Case "REMARKMATERIAL":z4002.RemarkMaterial = Children(i).Data
   Case "INCHARGEMATERIAL":z4002.InchargeMaterial = Children(i).Data
   Case "DATEREMARKMATERIAL":z4002.DateRemarkMaterial = Children(i).Data
   Case "CHKSOLE":z4002.chkSole = Children(i).Data
   Case "REMARKSOLE":z4002.RemarkSole = Children(i).Data
   Case "INCHARGESOLE":z4002.InchargeSole = Children(i).Data
   Case "DATEREMARKSOLE":z4002.DateRemarkSole = Children(i).Data
   Case "CHKLAST":z4002.chkLast = Children(i).Data
   Case "REMARKLAST":z4002.RemarkLast = Children(i).Data
   Case "INCHARGELAST":z4002.InchargeLast = Children(i).Data
   Case "DATEREMARKLAST":z4002.DateRemarkLast = Children(i).Data
   Case "CHKMOLD":z4002.chkMold = Children(i).Data
   Case "REMARKMOLD":z4002.RemarkMold = Children(i).Data
   Case "INCHARGEMOLD":z4002.InchargeMold = Children(i).Data
   Case "DATEREMARKMOLD":z4002.DateRemarkMold = Children(i).Data
   Case "CHKSPEC":z4002.chkSpec = Children(i).Data
   Case "REMARKSPEC":z4002.RemarkSpec = Children(i).Data
   Case "INCHARGESPEC":z4002.InchargeSpec = Children(i).Data
   Case "DATEREMARKSPEC":z4002.DateRemarkSpec = Children(i).Data
   Case "CHKTEST":z4002.chkTest = Children(i).Data
   Case "REMARKTEST":z4002.RemarkTest = Children(i).Data
   Case "INCHARGETEST":z4002.InchargeTest = Children(i).Data
   Case "DATEREMARKTEST":z4002.DateRemarkTest = Children(i).Data
   Case "CHKCFM":z4002.chkCFM = Children(i).Data
   Case "REMARKCFM":z4002.RemarkCFM = Children(i).Data
   Case "INCHARGECFM":z4002.InchargeCFM = Children(i).Data
   Case "DATEREMARKCFM":z4002.DateRemarkCFM = Children(i).Data
   Case "FACTORYKALLOCATION":z4002.FactorykAllocation = Children(i).Data
   Case "LINEALLOCATION":z4002.LineAllocation = Children(i).Data
   Case "REMARKALLOCATION":z4002.RemarkAllocation = Children(i).Data
   Case "REMARKORDER":z4002.RemarkOrder = Children(i).Data
   Case "REMARKCUSTOMER":z4002.RemarkCustomer = Children(i).Data
   Case "REMARKOTHER":z4002.RemarkOther = Children(i).Data
   Case "REMARK":z4002.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K4002_MOVE",vbCritical)
End Try
End Function 
    
End Module 
