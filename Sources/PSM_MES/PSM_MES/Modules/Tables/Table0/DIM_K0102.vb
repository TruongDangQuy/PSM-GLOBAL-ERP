'=========================================================================================================================================================
'   TABLE : (PFK0102)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K0102

Structure T0102_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	SpecNo	 AS String	'			char(9)		*
Public 	SpecNoSeq	 AS String	'			char(3)		*
Public 	DateConfirm	 AS String	'			char(8)
Public 	SpecNoRef	 AS String	'			char(9)
Public 	SpecSeqRef	 AS String	'			char(3)
Public 	SpecNoBe	 AS String	'			char(9)
Public 	SpecSeqBe	 AS String	'			char(3)
Public 	SpeciticSize	 AS String	'			nvarchar(50)
Public 	OrderRnDStatus	 AS String	'			char(1)
Public 	DateAccept	 AS String	'			char(8)
Public 	DateApproval	 AS String	'			char(8)
Public 	DateComplete	 AS String	'			char(8)
Public 	DatePending	 AS String	'			char(8)
Public 	DateCancel	 AS String	'			char(8)
Public 	InchargeAccept	 AS String	'			char(8)
Public 	MaterialBOMCode	 AS String	'			char(6)
Public 	InchargeMaterialBOM	 AS String	'			char(8)
Public 	ProcessBOMCode	 AS String	'			char(6)
Public 	InchargeProcessBOM	 AS String	'			char(8)
Public 	JobBOMCode	 AS String	'			char(6)
Public 	InchargeJobBOM	 AS String	'			char(8)
Public 	DevelopCode	 AS String	'			char(6)
Public 	StartTime	 AS String	'			char(14)
Public 	FinishTime	 AS String	'			char(14)
Public 	InsertDate	 AS String	'			char(8)
Public 	InchargeInsert	 AS String	'			char(8)
Public 	UpdateDate	 AS String	'			char(8)
Public 	InchargeUpdate	 AS String	'			char(8)
Public 	AttchID	 AS String	'			char(6)
Public 	CheckUse	 AS String	'			char(1)
Public 	CheckComplete	 AS String	'			char(1)
Public 	MaterialAMT	 AS Double	'			decimal
Public 	ProcessAMT	 AS Double	'			decimal
Public 	AdditionalAMT	 AS Double	'			decimal
Public 	ExpenseAMT	 AS Double	'			decimal
Public 	SalesAMT	 AS Double	'			decimal
Public 	TotalAMT	 AS Double	'			decimal
Public 	PerProfit	 AS Double	'			decimal
Public 	TotalCost	 AS Double	'			decimal
Public 	SalesPrice	 AS Double	'			decimal
Public 	SalesProfit	 AS Double	'			decimal
Public 	MaterialStatus	 AS String	'			char(1)
Public 	SoleStatus	 AS String	'			char(1)
Public 	DatePattern	 AS String	'			char(8)
Public 	DateMaterial	 AS String	'			char(8)
Public 	DatePlanning	 AS String	'			char(8)
Public 	DateSole	 AS String	'			char(8)
Public 	DateRnD	 AS String	'			char(8)
Public 	DateFitting	 AS String	'			char(8)
Public 	DateCutting	 AS String	'			char(8)
Public 	DateStitching	 AS String	'			char(8)
Public 	DateStockfit	 AS String	'			char(8)
Public 	DateAssembly	 AS String	'			char(8)
Public 	DateShipping	 AS String	'			char(8)
Public 	QtyOrder	 AS Double	'			decimal
Public 	QtyBooking	 AS Double	'			decimal
Public 	QtyJob	 AS Double	'			decimal
Public 	QtySole	 AS Double	'			decimal
Public 	QtyCutting	 AS Double	'			decimal
Public 	QtyStitching	 AS Double	'			decimal
Public 	QtyStockfit	 AS Double	'			decimal
Public 	QtyAssembly	 AS Double	'			decimal
Public 	QtyShipping	 AS Double	'			decimal
Public 	RemarkOrder	 AS String	'			nvarchar(100)
Public 	RemarkCustomer	 AS String	'			nvarchar(100)
Public 	Remark	 AS String	'			nvarchar(100)
'=========================================================================================================================================================
End structure

Public D0102 As T0102_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK0102(SPECNO AS String, SPECNOSEQ AS String) As Boolean
    READ_PFK0102 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK0102 "
    SQL = SQL & " WHERE K0102_SpecNo		 = '" & SpecNo & "' " 
    SQL = SQL & "   AND K0102_SpecNoSeq		 = '" & SpecNoSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D0102_CLEAR: GoTo SKIP_READ_PFK0102
                
    Call K0102_MOVE(rd)
    READ_PFK0102 = True

SKIP_READ_PFK0102:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK0102",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK0102(SPECNO AS String, SPECNOSEQ AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK0102 "
    SQL = SQL & " WHERE K0102_SpecNo		 = '" & SpecNo & "' " 
    SQL = SQL & "   AND K0102_SpecNoSeq		 = '" & SpecNoSeq & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK0102",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK0102(z0102 As T0102_AREA) As Boolean
    WRITE_PFK0102 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z0102)
 
    SQL = " INSERT INTO PFK0102 "
    SQL = SQL & " ( "
    SQL = SQL & " K0102_SpecNo," 
    SQL = SQL & " K0102_SpecNoSeq," 
    SQL = SQL & " K0102_DateConfirm," 
    SQL = SQL & " K0102_SpecNoRef," 
    SQL = SQL & " K0102_SpecSeqRef," 
    SQL = SQL & " K0102_SpecNoBe," 
    SQL = SQL & " K0102_SpecSeqBe," 
    SQL = SQL & " K0102_SpeciticSize," 
    SQL = SQL & " K0102_OrderRnDStatus," 
    SQL = SQL & " K0102_DateAccept," 
    SQL = SQL & " K0102_DateApproval," 
    SQL = SQL & " K0102_DateComplete," 
    SQL = SQL & " K0102_DatePending," 
    SQL = SQL & " K0102_DateCancel," 
    SQL = SQL & " K0102_InchargeAccept," 
    SQL = SQL & " K0102_MaterialBOMCode," 
    SQL = SQL & " K0102_InchargeMaterialBOM," 
    SQL = SQL & " K0102_ProcessBOMCode," 
    SQL = SQL & " K0102_InchargeProcessBOM," 
    SQL = SQL & " K0102_JobBOMCode," 
    SQL = SQL & " K0102_InchargeJobBOM," 
    SQL = SQL & " K0102_DevelopCode," 
    SQL = SQL & " K0102_StartTime," 
    SQL = SQL & " K0102_FinishTime," 
    SQL = SQL & " K0102_InsertDate," 
    SQL = SQL & " K0102_InchargeInsert," 
    SQL = SQL & " K0102_UpdateDate," 
    SQL = SQL & " K0102_InchargeUpdate," 
    SQL = SQL & " K0102_AttchID," 
    SQL = SQL & " K0102_CheckUse," 
    SQL = SQL & " K0102_CheckComplete," 
    SQL = SQL & " K0102_MaterialAMT," 
    SQL = SQL & " K0102_ProcessAMT," 
    SQL = SQL & " K0102_AdditionalAMT," 
    SQL = SQL & " K0102_ExpenseAMT," 
    SQL = SQL & " K0102_SalesAMT," 
    SQL = SQL & " K0102_TotalAMT," 
    SQL = SQL & " K0102_PerProfit," 
    SQL = SQL & " K0102_TotalCost," 
    SQL = SQL & " K0102_SalesPrice," 
    SQL = SQL & " K0102_SalesProfit," 
    SQL = SQL & " K0102_MaterialStatus," 
    SQL = SQL & " K0102_SoleStatus," 
    SQL = SQL & " K0102_DatePattern," 
    SQL = SQL & " K0102_DateMaterial," 
    SQL = SQL & " K0102_DatePlanning," 
    SQL = SQL & " K0102_DateSole," 
    SQL = SQL & " K0102_DateRnD," 
    SQL = SQL & " K0102_DateFitting," 
    SQL = SQL & " K0102_DateCutting," 
    SQL = SQL & " K0102_DateStitching," 
    SQL = SQL & " K0102_DateStockfit," 
    SQL = SQL & " K0102_DateAssembly," 
    SQL = SQL & " K0102_DateShipping," 
    SQL = SQL & " K0102_QtyOrder," 
    SQL = SQL & " K0102_QtyBooking," 
    SQL = SQL & " K0102_QtyJob," 
    SQL = SQL & " K0102_QtySole," 
    SQL = SQL & " K0102_QtyCutting," 
    SQL = SQL & " K0102_QtyStitching," 
    SQL = SQL & " K0102_QtyStockfit," 
    SQL = SQL & " K0102_QtyAssembly," 
    SQL = SQL & " K0102_QtyShipping," 
    SQL = SQL & " K0102_RemarkOrder," 
    SQL = SQL & " K0102_RemarkCustomer," 
    SQL = SQL & " K0102_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z0102.SpecNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0102.SpecNoSeq) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0102.DateConfirm) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0102.SpecNoRef) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0102.SpecSeqRef) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0102.SpecNoBe) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0102.SpecSeqBe) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0102.SpeciticSize) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0102.OrderRnDStatus) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0102.DateAccept) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0102.DateApproval) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0102.DateComplete) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0102.DatePending) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0102.DateCancel) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0102.InchargeAccept) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0102.MaterialBOMCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0102.InchargeMaterialBOM) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0102.ProcessBOMCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0102.InchargeProcessBOM) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0102.JobBOMCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0102.InchargeJobBOM) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0102.DevelopCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0102.StartTime) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0102.FinishTime) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0102.InsertDate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0102.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0102.UpdateDate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0102.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0102.AttchID) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0102.CheckUse) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0102.CheckComplete) & "', "  
    SQL = SQL & "   " & FormatSQL(z0102.MaterialAMT) & ", "  
    SQL = SQL & "   " & FormatSQL(z0102.ProcessAMT) & ", "  
    SQL = SQL & "   " & FormatSQL(z0102.AdditionalAMT) & ", "  
    SQL = SQL & "   " & FormatSQL(z0102.ExpenseAMT) & ", "  
    SQL = SQL & "   " & FormatSQL(z0102.SalesAMT) & ", "  
    SQL = SQL & "   " & FormatSQL(z0102.TotalAMT) & ", "  
    SQL = SQL & "   " & FormatSQL(z0102.PerProfit) & ", "  
    SQL = SQL & "   " & FormatSQL(z0102.TotalCost) & ", "  
    SQL = SQL & "   " & FormatSQL(z0102.SalesPrice) & ", "  
    SQL = SQL & "   " & FormatSQL(z0102.SalesProfit) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z0102.MaterialStatus) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0102.SoleStatus) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0102.DatePattern) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0102.DateMaterial) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0102.DatePlanning) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0102.DateSole) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0102.DateRnD) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0102.DateFitting) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0102.DateCutting) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0102.DateStitching) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0102.DateStockfit) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0102.DateAssembly) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0102.DateShipping) & "', "  
    SQL = SQL & "   " & FormatSQL(z0102.QtyOrder) & ", "  
    SQL = SQL & "   " & FormatSQL(z0102.QtyBooking) & ", "  
    SQL = SQL & "   " & FormatSQL(z0102.QtyJob) & ", "  
    SQL = SQL & "   " & FormatSQL(z0102.QtySole) & ", "  
    SQL = SQL & "   " & FormatSQL(z0102.QtyCutting) & ", "  
    SQL = SQL & "   " & FormatSQL(z0102.QtyStitching) & ", "  
    SQL = SQL & "   " & FormatSQL(z0102.QtyStockfit) & ", "  
    SQL = SQL & "   " & FormatSQL(z0102.QtyAssembly) & ", "  
    SQL = SQL & "   " & FormatSQL(z0102.QtyShipping) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z0102.RemarkOrder) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0102.RemarkCustomer) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0102.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK0102 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK0102",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK0102(z0102 As T0102_AREA) As Boolean
    REWRITE_PFK0102 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z0102)
   
    SQL = " UPDATE PFK0102 SET "
    SQL = SQL & "    K0102_DateConfirm      = N'" & FormatSQL(z0102.DateConfirm) & "', " 
    SQL = SQL & "    K0102_SpecNoRef      = N'" & FormatSQL(z0102.SpecNoRef) & "', " 
    SQL = SQL & "    K0102_SpecSeqRef      = N'" & FormatSQL(z0102.SpecSeqRef) & "', " 
    SQL = SQL & "    K0102_SpecNoBe      = N'" & FormatSQL(z0102.SpecNoBe) & "', " 
    SQL = SQL & "    K0102_SpecSeqBe      = N'" & FormatSQL(z0102.SpecSeqBe) & "', " 
    SQL = SQL & "    K0102_SpeciticSize      = N'" & FormatSQL(z0102.SpeciticSize) & "', " 
    SQL = SQL & "    K0102_OrderRnDStatus      = N'" & FormatSQL(z0102.OrderRnDStatus) & "', " 
    SQL = SQL & "    K0102_DateAccept      = N'" & FormatSQL(z0102.DateAccept) & "', " 
    SQL = SQL & "    K0102_DateApproval      = N'" & FormatSQL(z0102.DateApproval) & "', " 
    SQL = SQL & "    K0102_DateComplete      = N'" & FormatSQL(z0102.DateComplete) & "', " 
    SQL = SQL & "    K0102_DatePending      = N'" & FormatSQL(z0102.DatePending) & "', " 
    SQL = SQL & "    K0102_DateCancel      = N'" & FormatSQL(z0102.DateCancel) & "', " 
    SQL = SQL & "    K0102_InchargeAccept      = N'" & FormatSQL(z0102.InchargeAccept) & "', " 
    SQL = SQL & "    K0102_MaterialBOMCode      = N'" & FormatSQL(z0102.MaterialBOMCode) & "', " 
    SQL = SQL & "    K0102_InchargeMaterialBOM      = N'" & FormatSQL(z0102.InchargeMaterialBOM) & "', " 
    SQL = SQL & "    K0102_ProcessBOMCode      = N'" & FormatSQL(z0102.ProcessBOMCode) & "', " 
    SQL = SQL & "    K0102_InchargeProcessBOM      = N'" & FormatSQL(z0102.InchargeProcessBOM) & "', " 
    SQL = SQL & "    K0102_JobBOMCode      = N'" & FormatSQL(z0102.JobBOMCode) & "', " 
    SQL = SQL & "    K0102_InchargeJobBOM      = N'" & FormatSQL(z0102.InchargeJobBOM) & "', " 
    SQL = SQL & "    K0102_DevelopCode      = N'" & FormatSQL(z0102.DevelopCode) & "', " 
    SQL = SQL & "    K0102_StartTime      = N'" & FormatSQL(z0102.StartTime) & "', " 
    SQL = SQL & "    K0102_FinishTime      = N'" & FormatSQL(z0102.FinishTime) & "', " 
    SQL = SQL & "    K0102_InsertDate      = N'" & FormatSQL(z0102.InsertDate) & "', " 
    SQL = SQL & "    K0102_InchargeInsert      = N'" & FormatSQL(z0102.InchargeInsert) & "', " 
    SQL = SQL & "    K0102_UpdateDate      = N'" & FormatSQL(z0102.UpdateDate) & "', " 
    SQL = SQL & "    K0102_InchargeUpdate      = N'" & FormatSQL(z0102.InchargeUpdate) & "', " 
    SQL = SQL & "    K0102_AttchID      = N'" & FormatSQL(z0102.AttchID) & "', " 
    SQL = SQL & "    K0102_CheckUse      = N'" & FormatSQL(z0102.CheckUse) & "', " 
    SQL = SQL & "    K0102_CheckComplete      = N'" & FormatSQL(z0102.CheckComplete) & "', " 
    SQL = SQL & "    K0102_MaterialAMT      =  " & FormatSQL(z0102.MaterialAMT) & ", " 
    SQL = SQL & "    K0102_ProcessAMT      =  " & FormatSQL(z0102.ProcessAMT) & ", " 
    SQL = SQL & "    K0102_AdditionalAMT      =  " & FormatSQL(z0102.AdditionalAMT) & ", " 
    SQL = SQL & "    K0102_ExpenseAMT      =  " & FormatSQL(z0102.ExpenseAMT) & ", " 
    SQL = SQL & "    K0102_SalesAMT      =  " & FormatSQL(z0102.SalesAMT) & ", " 
    SQL = SQL & "    K0102_TotalAMT      =  " & FormatSQL(z0102.TotalAMT) & ", " 
    SQL = SQL & "    K0102_PerProfit      =  " & FormatSQL(z0102.PerProfit) & ", " 
    SQL = SQL & "    K0102_TotalCost      =  " & FormatSQL(z0102.TotalCost) & ", " 
    SQL = SQL & "    K0102_SalesPrice      =  " & FormatSQL(z0102.SalesPrice) & ", " 
    SQL = SQL & "    K0102_SalesProfit      =  " & FormatSQL(z0102.SalesProfit) & ", " 
    SQL = SQL & "    K0102_MaterialStatus      = N'" & FormatSQL(z0102.MaterialStatus) & "', " 
    SQL = SQL & "    K0102_SoleStatus      = N'" & FormatSQL(z0102.SoleStatus) & "', " 
    SQL = SQL & "    K0102_DatePattern      = N'" & FormatSQL(z0102.DatePattern) & "', " 
    SQL = SQL & "    K0102_DateMaterial      = N'" & FormatSQL(z0102.DateMaterial) & "', " 
    SQL = SQL & "    K0102_DatePlanning      = N'" & FormatSQL(z0102.DatePlanning) & "', " 
    SQL = SQL & "    K0102_DateSole      = N'" & FormatSQL(z0102.DateSole) & "', " 
    SQL = SQL & "    K0102_DateRnD      = N'" & FormatSQL(z0102.DateRnD) & "', " 
    SQL = SQL & "    K0102_DateFitting      = N'" & FormatSQL(z0102.DateFitting) & "', " 
    SQL = SQL & "    K0102_DateCutting      = N'" & FormatSQL(z0102.DateCutting) & "', " 
    SQL = SQL & "    K0102_DateStitching      = N'" & FormatSQL(z0102.DateStitching) & "', " 
    SQL = SQL & "    K0102_DateStockfit      = N'" & FormatSQL(z0102.DateStockfit) & "', " 
    SQL = SQL & "    K0102_DateAssembly      = N'" & FormatSQL(z0102.DateAssembly) & "', " 
    SQL = SQL & "    K0102_DateShipping      = N'" & FormatSQL(z0102.DateShipping) & "', " 
    SQL = SQL & "    K0102_QtyOrder      =  " & FormatSQL(z0102.QtyOrder) & ", " 
    SQL = SQL & "    K0102_QtyBooking      =  " & FormatSQL(z0102.QtyBooking) & ", " 
    SQL = SQL & "    K0102_QtyJob      =  " & FormatSQL(z0102.QtyJob) & ", " 
    SQL = SQL & "    K0102_QtySole      =  " & FormatSQL(z0102.QtySole) & ", " 
    SQL = SQL & "    K0102_QtyCutting      =  " & FormatSQL(z0102.QtyCutting) & ", " 
    SQL = SQL & "    K0102_QtyStitching      =  " & FormatSQL(z0102.QtyStitching) & ", " 
    SQL = SQL & "    K0102_QtyStockfit      =  " & FormatSQL(z0102.QtyStockfit) & ", " 
    SQL = SQL & "    K0102_QtyAssembly      =  " & FormatSQL(z0102.QtyAssembly) & ", " 
    SQL = SQL & "    K0102_QtyShipping      =  " & FormatSQL(z0102.QtyShipping) & ", " 
    SQL = SQL & "    K0102_RemarkOrder      = N'" & FormatSQL(z0102.RemarkOrder) & "', " 
    SQL = SQL & "    K0102_RemarkCustomer      = N'" & FormatSQL(z0102.RemarkCustomer) & "', " 
    SQL = SQL & "    K0102_Remark      = N'" & FormatSQL(z0102.Remark) & "'  " 
    SQL = SQL & " WHERE K0102_SpecNo		 = '" & z0102.SpecNo & "' " 
    SQL = SQL & "   AND K0102_SpecNoSeq		 = '" & z0102.SpecNoSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK0102 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK0102",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK0102(z0102 As T0102_AREA) As Boolean
    DELETE_PFK0102 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK0102 "
    SQL = SQL & " WHERE K0102_SpecNo		 = '" & z0102.SpecNo & "' " 
    SQL = SQL & "   AND K0102_SpecNoSeq		 = '" & z0102.SpecNoSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK0102 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK0102",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D0102_CLEAR()
Try
    
   D0102.SpecNo = ""
   D0102.SpecNoSeq = ""
   D0102.DateConfirm = ""
   D0102.SpecNoRef = ""
   D0102.SpecSeqRef = ""
   D0102.SpecNoBe = ""
   D0102.SpecSeqBe = ""
   D0102.SpeciticSize = ""
   D0102.OrderRnDStatus = ""
   D0102.DateAccept = ""
   D0102.DateApproval = ""
   D0102.DateComplete = ""
   D0102.DatePending = ""
   D0102.DateCancel = ""
   D0102.InchargeAccept = ""
   D0102.MaterialBOMCode = ""
   D0102.InchargeMaterialBOM = ""
   D0102.ProcessBOMCode = ""
   D0102.InchargeProcessBOM = ""
   D0102.JobBOMCode = ""
   D0102.InchargeJobBOM = ""
   D0102.DevelopCode = ""
   D0102.StartTime = ""
   D0102.FinishTime = ""
   D0102.InsertDate = ""
   D0102.InchargeInsert = ""
   D0102.UpdateDate = ""
   D0102.InchargeUpdate = ""
   D0102.AttchID = ""
   D0102.CheckUse = ""
   D0102.CheckComplete = ""
    D0102.MaterialAMT = 0 
    D0102.ProcessAMT = 0 
    D0102.AdditionalAMT = 0 
    D0102.ExpenseAMT = 0 
    D0102.SalesAMT = 0 
    D0102.TotalAMT = 0 
    D0102.PerProfit = 0 
    D0102.TotalCost = 0 
    D0102.SalesPrice = 0 
    D0102.SalesProfit = 0 
   D0102.MaterialStatus = ""
   D0102.SoleStatus = ""
   D0102.DatePattern = ""
   D0102.DateMaterial = ""
   D0102.DatePlanning = ""
   D0102.DateSole = ""
   D0102.DateRnD = ""
   D0102.DateFitting = ""
   D0102.DateCutting = ""
   D0102.DateStitching = ""
   D0102.DateStockfit = ""
   D0102.DateAssembly = ""
   D0102.DateShipping = ""
    D0102.QtyOrder = 0 
    D0102.QtyBooking = 0 
    D0102.QtyJob = 0 
    D0102.QtySole = 0 
    D0102.QtyCutting = 0 
    D0102.QtyStitching = 0 
    D0102.QtyStockfit = 0 
    D0102.QtyAssembly = 0 
    D0102.QtyShipping = 0 
   D0102.RemarkOrder = ""
   D0102.RemarkCustomer = ""
   D0102.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D0102_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x0102 As T0102_AREA)
Try
    
    x0102.SpecNo = trim$(  x0102.SpecNo)
    x0102.SpecNoSeq = trim$(  x0102.SpecNoSeq)
    x0102.DateConfirm = trim$(  x0102.DateConfirm)
    x0102.SpecNoRef = trim$(  x0102.SpecNoRef)
    x0102.SpecSeqRef = trim$(  x0102.SpecSeqRef)
    x0102.SpecNoBe = trim$(  x0102.SpecNoBe)
    x0102.SpecSeqBe = trim$(  x0102.SpecSeqBe)
    x0102.SpeciticSize = trim$(  x0102.SpeciticSize)
    x0102.OrderRnDStatus = trim$(  x0102.OrderRnDStatus)
    x0102.DateAccept = trim$(  x0102.DateAccept)
    x0102.DateApproval = trim$(  x0102.DateApproval)
    x0102.DateComplete = trim$(  x0102.DateComplete)
    x0102.DatePending = trim$(  x0102.DatePending)
    x0102.DateCancel = trim$(  x0102.DateCancel)
    x0102.InchargeAccept = trim$(  x0102.InchargeAccept)
    x0102.MaterialBOMCode = trim$(  x0102.MaterialBOMCode)
    x0102.InchargeMaterialBOM = trim$(  x0102.InchargeMaterialBOM)
    x0102.ProcessBOMCode = trim$(  x0102.ProcessBOMCode)
    x0102.InchargeProcessBOM = trim$(  x0102.InchargeProcessBOM)
    x0102.JobBOMCode = trim$(  x0102.JobBOMCode)
    x0102.InchargeJobBOM = trim$(  x0102.InchargeJobBOM)
    x0102.DevelopCode = trim$(  x0102.DevelopCode)
    x0102.StartTime = trim$(  x0102.StartTime)
    x0102.FinishTime = trim$(  x0102.FinishTime)
    x0102.InsertDate = trim$(  x0102.InsertDate)
    x0102.InchargeInsert = trim$(  x0102.InchargeInsert)
    x0102.UpdateDate = trim$(  x0102.UpdateDate)
    x0102.InchargeUpdate = trim$(  x0102.InchargeUpdate)
    x0102.AttchID = trim$(  x0102.AttchID)
    x0102.CheckUse = trim$(  x0102.CheckUse)
    x0102.CheckComplete = trim$(  x0102.CheckComplete)
    x0102.MaterialAMT = trim$(  x0102.MaterialAMT)
    x0102.ProcessAMT = trim$(  x0102.ProcessAMT)
    x0102.AdditionalAMT = trim$(  x0102.AdditionalAMT)
    x0102.ExpenseAMT = trim$(  x0102.ExpenseAMT)
    x0102.SalesAMT = trim$(  x0102.SalesAMT)
    x0102.TotalAMT = trim$(  x0102.TotalAMT)
    x0102.PerProfit = trim$(  x0102.PerProfit)
    x0102.TotalCost = trim$(  x0102.TotalCost)
    x0102.SalesPrice = trim$(  x0102.SalesPrice)
    x0102.SalesProfit = trim$(  x0102.SalesProfit)
    x0102.MaterialStatus = trim$(  x0102.MaterialStatus)
    x0102.SoleStatus = trim$(  x0102.SoleStatus)
    x0102.DatePattern = trim$(  x0102.DatePattern)
    x0102.DateMaterial = trim$(  x0102.DateMaterial)
    x0102.DatePlanning = trim$(  x0102.DatePlanning)
    x0102.DateSole = trim$(  x0102.DateSole)
    x0102.DateRnD = trim$(  x0102.DateRnD)
    x0102.DateFitting = trim$(  x0102.DateFitting)
    x0102.DateCutting = trim$(  x0102.DateCutting)
    x0102.DateStitching = trim$(  x0102.DateStitching)
    x0102.DateStockfit = trim$(  x0102.DateStockfit)
    x0102.DateAssembly = trim$(  x0102.DateAssembly)
    x0102.DateShipping = trim$(  x0102.DateShipping)
    x0102.QtyOrder = trim$(  x0102.QtyOrder)
    x0102.QtyBooking = trim$(  x0102.QtyBooking)
    x0102.QtyJob = trim$(  x0102.QtyJob)
    x0102.QtySole = trim$(  x0102.QtySole)
    x0102.QtyCutting = trim$(  x0102.QtyCutting)
    x0102.QtyStitching = trim$(  x0102.QtyStitching)
    x0102.QtyStockfit = trim$(  x0102.QtyStockfit)
    x0102.QtyAssembly = trim$(  x0102.QtyAssembly)
    x0102.QtyShipping = trim$(  x0102.QtyShipping)
    x0102.RemarkOrder = trim$(  x0102.RemarkOrder)
    x0102.RemarkCustomer = trim$(  x0102.RemarkCustomer)
    x0102.Remark = trim$(  x0102.Remark)
     
    If trim$( x0102.SpecNo ) = "" Then x0102.SpecNo = Space(1) 
    If trim$( x0102.SpecNoSeq ) = "" Then x0102.SpecNoSeq = Space(1) 
    If trim$( x0102.DateConfirm ) = "" Then x0102.DateConfirm = Space(1) 
    If trim$( x0102.SpecNoRef ) = "" Then x0102.SpecNoRef = Space(1) 
    If trim$( x0102.SpecSeqRef ) = "" Then x0102.SpecSeqRef = Space(1) 
    If trim$( x0102.SpecNoBe ) = "" Then x0102.SpecNoBe = Space(1) 
    If trim$( x0102.SpecSeqBe ) = "" Then x0102.SpecSeqBe = Space(1) 
    If trim$( x0102.SpeciticSize ) = "" Then x0102.SpeciticSize = Space(1) 
    If trim$( x0102.OrderRnDStatus ) = "" Then x0102.OrderRnDStatus = Space(1) 
    If trim$( x0102.DateAccept ) = "" Then x0102.DateAccept = Space(1) 
    If trim$( x0102.DateApproval ) = "" Then x0102.DateApproval = Space(1) 
    If trim$( x0102.DateComplete ) = "" Then x0102.DateComplete = Space(1) 
    If trim$( x0102.DatePending ) = "" Then x0102.DatePending = Space(1) 
    If trim$( x0102.DateCancel ) = "" Then x0102.DateCancel = Space(1) 
    If trim$( x0102.InchargeAccept ) = "" Then x0102.InchargeAccept = Space(1) 
    If trim$( x0102.MaterialBOMCode ) = "" Then x0102.MaterialBOMCode = Space(1) 
    If trim$( x0102.InchargeMaterialBOM ) = "" Then x0102.InchargeMaterialBOM = Space(1) 
    If trim$( x0102.ProcessBOMCode ) = "" Then x0102.ProcessBOMCode = Space(1) 
    If trim$( x0102.InchargeProcessBOM ) = "" Then x0102.InchargeProcessBOM = Space(1) 
    If trim$( x0102.JobBOMCode ) = "" Then x0102.JobBOMCode = Space(1) 
    If trim$( x0102.InchargeJobBOM ) = "" Then x0102.InchargeJobBOM = Space(1) 
    If trim$( x0102.DevelopCode ) = "" Then x0102.DevelopCode = Space(1) 
    If trim$( x0102.StartTime ) = "" Then x0102.StartTime = Space(1) 
    If trim$( x0102.FinishTime ) = "" Then x0102.FinishTime = Space(1) 
    If trim$( x0102.InsertDate ) = "" Then x0102.InsertDate = Space(1) 
    If trim$( x0102.InchargeInsert ) = "" Then x0102.InchargeInsert = Space(1) 
    If trim$( x0102.UpdateDate ) = "" Then x0102.UpdateDate = Space(1) 
    If trim$( x0102.InchargeUpdate ) = "" Then x0102.InchargeUpdate = Space(1) 
    If trim$( x0102.AttchID ) = "" Then x0102.AttchID = Space(1) 
    If trim$( x0102.CheckUse ) = "" Then x0102.CheckUse = Space(1) 
    If trim$( x0102.CheckComplete ) = "" Then x0102.CheckComplete = Space(1) 
    If trim$( x0102.MaterialAMT ) = "" Then x0102.MaterialAMT = 0 
    If trim$( x0102.ProcessAMT ) = "" Then x0102.ProcessAMT = 0 
    If trim$( x0102.AdditionalAMT ) = "" Then x0102.AdditionalAMT = 0 
    If trim$( x0102.ExpenseAMT ) = "" Then x0102.ExpenseAMT = 0 
    If trim$( x0102.SalesAMT ) = "" Then x0102.SalesAMT = 0 
    If trim$( x0102.TotalAMT ) = "" Then x0102.TotalAMT = 0 
    If trim$( x0102.PerProfit ) = "" Then x0102.PerProfit = 0 
    If trim$( x0102.TotalCost ) = "" Then x0102.TotalCost = 0 
    If trim$( x0102.SalesPrice ) = "" Then x0102.SalesPrice = 0 
    If trim$( x0102.SalesProfit ) = "" Then x0102.SalesProfit = 0 
    If trim$( x0102.MaterialStatus ) = "" Then x0102.MaterialStatus = Space(1) 
    If trim$( x0102.SoleStatus ) = "" Then x0102.SoleStatus = Space(1) 
    If trim$( x0102.DatePattern ) = "" Then x0102.DatePattern = Space(1) 
    If trim$( x0102.DateMaterial ) = "" Then x0102.DateMaterial = Space(1) 
    If trim$( x0102.DatePlanning ) = "" Then x0102.DatePlanning = Space(1) 
    If trim$( x0102.DateSole ) = "" Then x0102.DateSole = Space(1) 
    If trim$( x0102.DateRnD ) = "" Then x0102.DateRnD = Space(1) 
    If trim$( x0102.DateFitting ) = "" Then x0102.DateFitting = Space(1) 
    If trim$( x0102.DateCutting ) = "" Then x0102.DateCutting = Space(1) 
    If trim$( x0102.DateStitching ) = "" Then x0102.DateStitching = Space(1) 
    If trim$( x0102.DateStockfit ) = "" Then x0102.DateStockfit = Space(1) 
    If trim$( x0102.DateAssembly ) = "" Then x0102.DateAssembly = Space(1) 
    If trim$( x0102.DateShipping ) = "" Then x0102.DateShipping = Space(1) 
    If trim$( x0102.QtyOrder ) = "" Then x0102.QtyOrder = 0 
    If trim$( x0102.QtyBooking ) = "" Then x0102.QtyBooking = 0 
    If trim$( x0102.QtyJob ) = "" Then x0102.QtyJob = 0 
    If trim$( x0102.QtySole ) = "" Then x0102.QtySole = 0 
    If trim$( x0102.QtyCutting ) = "" Then x0102.QtyCutting = 0 
    If trim$( x0102.QtyStitching ) = "" Then x0102.QtyStitching = 0 
    If trim$( x0102.QtyStockfit ) = "" Then x0102.QtyStockfit = 0 
    If trim$( x0102.QtyAssembly ) = "" Then x0102.QtyAssembly = 0 
    If trim$( x0102.QtyShipping ) = "" Then x0102.QtyShipping = 0 
    If trim$( x0102.RemarkOrder ) = "" Then x0102.RemarkOrder = Space(1) 
    If trim$( x0102.RemarkCustomer ) = "" Then x0102.RemarkCustomer = Space(1) 
    If trim$( x0102.Remark ) = "" Then x0102.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K0102_MOVE(rs0102 As SqlClient.SqlDataReader)
Try

    call D0102_CLEAR()   

    If IsdbNull(rs0102!K0102_SpecNo) = False Then D0102.SpecNo = Trim$(rs0102!K0102_SpecNo)
    If IsdbNull(rs0102!K0102_SpecNoSeq) = False Then D0102.SpecNoSeq = Trim$(rs0102!K0102_SpecNoSeq)
    If IsdbNull(rs0102!K0102_DateConfirm) = False Then D0102.DateConfirm = Trim$(rs0102!K0102_DateConfirm)
    If IsdbNull(rs0102!K0102_SpecNoRef) = False Then D0102.SpecNoRef = Trim$(rs0102!K0102_SpecNoRef)
    If IsdbNull(rs0102!K0102_SpecSeqRef) = False Then D0102.SpecSeqRef = Trim$(rs0102!K0102_SpecSeqRef)
    If IsdbNull(rs0102!K0102_SpecNoBe) = False Then D0102.SpecNoBe = Trim$(rs0102!K0102_SpecNoBe)
    If IsdbNull(rs0102!K0102_SpecSeqBe) = False Then D0102.SpecSeqBe = Trim$(rs0102!K0102_SpecSeqBe)
    If IsdbNull(rs0102!K0102_SpeciticSize) = False Then D0102.SpeciticSize = Trim$(rs0102!K0102_SpeciticSize)
    If IsdbNull(rs0102!K0102_OrderRnDStatus) = False Then D0102.OrderRnDStatus = Trim$(rs0102!K0102_OrderRnDStatus)
    If IsdbNull(rs0102!K0102_DateAccept) = False Then D0102.DateAccept = Trim$(rs0102!K0102_DateAccept)
    If IsdbNull(rs0102!K0102_DateApproval) = False Then D0102.DateApproval = Trim$(rs0102!K0102_DateApproval)
    If IsdbNull(rs0102!K0102_DateComplete) = False Then D0102.DateComplete = Trim$(rs0102!K0102_DateComplete)
    If IsdbNull(rs0102!K0102_DatePending) = False Then D0102.DatePending = Trim$(rs0102!K0102_DatePending)
    If IsdbNull(rs0102!K0102_DateCancel) = False Then D0102.DateCancel = Trim$(rs0102!K0102_DateCancel)
    If IsdbNull(rs0102!K0102_InchargeAccept) = False Then D0102.InchargeAccept = Trim$(rs0102!K0102_InchargeAccept)
    If IsdbNull(rs0102!K0102_MaterialBOMCode) = False Then D0102.MaterialBOMCode = Trim$(rs0102!K0102_MaterialBOMCode)
    If IsdbNull(rs0102!K0102_InchargeMaterialBOM) = False Then D0102.InchargeMaterialBOM = Trim$(rs0102!K0102_InchargeMaterialBOM)
    If IsdbNull(rs0102!K0102_ProcessBOMCode) = False Then D0102.ProcessBOMCode = Trim$(rs0102!K0102_ProcessBOMCode)
    If IsdbNull(rs0102!K0102_InchargeProcessBOM) = False Then D0102.InchargeProcessBOM = Trim$(rs0102!K0102_InchargeProcessBOM)
    If IsdbNull(rs0102!K0102_JobBOMCode) = False Then D0102.JobBOMCode = Trim$(rs0102!K0102_JobBOMCode)
    If IsdbNull(rs0102!K0102_InchargeJobBOM) = False Then D0102.InchargeJobBOM = Trim$(rs0102!K0102_InchargeJobBOM)
    If IsdbNull(rs0102!K0102_DevelopCode) = False Then D0102.DevelopCode = Trim$(rs0102!K0102_DevelopCode)
    If IsdbNull(rs0102!K0102_StartTime) = False Then D0102.StartTime = Trim$(rs0102!K0102_StartTime)
    If IsdbNull(rs0102!K0102_FinishTime) = False Then D0102.FinishTime = Trim$(rs0102!K0102_FinishTime)
    If IsdbNull(rs0102!K0102_InsertDate) = False Then D0102.InsertDate = Trim$(rs0102!K0102_InsertDate)
    If IsdbNull(rs0102!K0102_InchargeInsert) = False Then D0102.InchargeInsert = Trim$(rs0102!K0102_InchargeInsert)
    If IsdbNull(rs0102!K0102_UpdateDate) = False Then D0102.UpdateDate = Trim$(rs0102!K0102_UpdateDate)
    If IsdbNull(rs0102!K0102_InchargeUpdate) = False Then D0102.InchargeUpdate = Trim$(rs0102!K0102_InchargeUpdate)
    If IsdbNull(rs0102!K0102_AttchID) = False Then D0102.AttchID = Trim$(rs0102!K0102_AttchID)
    If IsdbNull(rs0102!K0102_CheckUse) = False Then D0102.CheckUse = Trim$(rs0102!K0102_CheckUse)
    If IsdbNull(rs0102!K0102_CheckComplete) = False Then D0102.CheckComplete = Trim$(rs0102!K0102_CheckComplete)
    If IsdbNull(rs0102!K0102_MaterialAMT) = False Then D0102.MaterialAMT = Trim$(rs0102!K0102_MaterialAMT)
    If IsdbNull(rs0102!K0102_ProcessAMT) = False Then D0102.ProcessAMT = Trim$(rs0102!K0102_ProcessAMT)
    If IsdbNull(rs0102!K0102_AdditionalAMT) = False Then D0102.AdditionalAMT = Trim$(rs0102!K0102_AdditionalAMT)
    If IsdbNull(rs0102!K0102_ExpenseAMT) = False Then D0102.ExpenseAMT = Trim$(rs0102!K0102_ExpenseAMT)
    If IsdbNull(rs0102!K0102_SalesAMT) = False Then D0102.SalesAMT = Trim$(rs0102!K0102_SalesAMT)
    If IsdbNull(rs0102!K0102_TotalAMT) = False Then D0102.TotalAMT = Trim$(rs0102!K0102_TotalAMT)
    If IsdbNull(rs0102!K0102_PerProfit) = False Then D0102.PerProfit = Trim$(rs0102!K0102_PerProfit)
    If IsdbNull(rs0102!K0102_TotalCost) = False Then D0102.TotalCost = Trim$(rs0102!K0102_TotalCost)
    If IsdbNull(rs0102!K0102_SalesPrice) = False Then D0102.SalesPrice = Trim$(rs0102!K0102_SalesPrice)
    If IsdbNull(rs0102!K0102_SalesProfit) = False Then D0102.SalesProfit = Trim$(rs0102!K0102_SalesProfit)
    If IsdbNull(rs0102!K0102_MaterialStatus) = False Then D0102.MaterialStatus = Trim$(rs0102!K0102_MaterialStatus)
    If IsdbNull(rs0102!K0102_SoleStatus) = False Then D0102.SoleStatus = Trim$(rs0102!K0102_SoleStatus)
    If IsdbNull(rs0102!K0102_DatePattern) = False Then D0102.DatePattern = Trim$(rs0102!K0102_DatePattern)
    If IsdbNull(rs0102!K0102_DateMaterial) = False Then D0102.DateMaterial = Trim$(rs0102!K0102_DateMaterial)
    If IsdbNull(rs0102!K0102_DatePlanning) = False Then D0102.DatePlanning = Trim$(rs0102!K0102_DatePlanning)
    If IsdbNull(rs0102!K0102_DateSole) = False Then D0102.DateSole = Trim$(rs0102!K0102_DateSole)
    If IsdbNull(rs0102!K0102_DateRnD) = False Then D0102.DateRnD = Trim$(rs0102!K0102_DateRnD)
    If IsdbNull(rs0102!K0102_DateFitting) = False Then D0102.DateFitting = Trim$(rs0102!K0102_DateFitting)
    If IsdbNull(rs0102!K0102_DateCutting) = False Then D0102.DateCutting = Trim$(rs0102!K0102_DateCutting)
    If IsdbNull(rs0102!K0102_DateStitching) = False Then D0102.DateStitching = Trim$(rs0102!K0102_DateStitching)
    If IsdbNull(rs0102!K0102_DateStockfit) = False Then D0102.DateStockfit = Trim$(rs0102!K0102_DateStockfit)
    If IsdbNull(rs0102!K0102_DateAssembly) = False Then D0102.DateAssembly = Trim$(rs0102!K0102_DateAssembly)
    If IsdbNull(rs0102!K0102_DateShipping) = False Then D0102.DateShipping = Trim$(rs0102!K0102_DateShipping)
    If IsdbNull(rs0102!K0102_QtyOrder) = False Then D0102.QtyOrder = Trim$(rs0102!K0102_QtyOrder)
    If IsdbNull(rs0102!K0102_QtyBooking) = False Then D0102.QtyBooking = Trim$(rs0102!K0102_QtyBooking)
    If IsdbNull(rs0102!K0102_QtyJob) = False Then D0102.QtyJob = Trim$(rs0102!K0102_QtyJob)
    If IsdbNull(rs0102!K0102_QtySole) = False Then D0102.QtySole = Trim$(rs0102!K0102_QtySole)
    If IsdbNull(rs0102!K0102_QtyCutting) = False Then D0102.QtyCutting = Trim$(rs0102!K0102_QtyCutting)
    If IsdbNull(rs0102!K0102_QtyStitching) = False Then D0102.QtyStitching = Trim$(rs0102!K0102_QtyStitching)
    If IsdbNull(rs0102!K0102_QtyStockfit) = False Then D0102.QtyStockfit = Trim$(rs0102!K0102_QtyStockfit)
    If IsdbNull(rs0102!K0102_QtyAssembly) = False Then D0102.QtyAssembly = Trim$(rs0102!K0102_QtyAssembly)
    If IsdbNull(rs0102!K0102_QtyShipping) = False Then D0102.QtyShipping = Trim$(rs0102!K0102_QtyShipping)
    If IsdbNull(rs0102!K0102_RemarkOrder) = False Then D0102.RemarkOrder = Trim$(rs0102!K0102_RemarkOrder)
    If IsdbNull(rs0102!K0102_RemarkCustomer) = False Then D0102.RemarkCustomer = Trim$(rs0102!K0102_RemarkCustomer)
    If IsdbNull(rs0102!K0102_Remark) = False Then D0102.Remark = Trim$(rs0102!K0102_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K0102_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K0102_MOVE(rs0102 As DataRow)
Try

    call D0102_CLEAR()   

    If IsdbNull(rs0102!K0102_SpecNo) = False Then D0102.SpecNo = Trim$(rs0102!K0102_SpecNo)
    If IsdbNull(rs0102!K0102_SpecNoSeq) = False Then D0102.SpecNoSeq = Trim$(rs0102!K0102_SpecNoSeq)
    If IsdbNull(rs0102!K0102_DateConfirm) = False Then D0102.DateConfirm = Trim$(rs0102!K0102_DateConfirm)
    If IsdbNull(rs0102!K0102_SpecNoRef) = False Then D0102.SpecNoRef = Trim$(rs0102!K0102_SpecNoRef)
    If IsdbNull(rs0102!K0102_SpecSeqRef) = False Then D0102.SpecSeqRef = Trim$(rs0102!K0102_SpecSeqRef)
    If IsdbNull(rs0102!K0102_SpecNoBe) = False Then D0102.SpecNoBe = Trim$(rs0102!K0102_SpecNoBe)
    If IsdbNull(rs0102!K0102_SpecSeqBe) = False Then D0102.SpecSeqBe = Trim$(rs0102!K0102_SpecSeqBe)
    If IsdbNull(rs0102!K0102_SpeciticSize) = False Then D0102.SpeciticSize = Trim$(rs0102!K0102_SpeciticSize)
    If IsdbNull(rs0102!K0102_OrderRnDStatus) = False Then D0102.OrderRnDStatus = Trim$(rs0102!K0102_OrderRnDStatus)
    If IsdbNull(rs0102!K0102_DateAccept) = False Then D0102.DateAccept = Trim$(rs0102!K0102_DateAccept)
    If IsdbNull(rs0102!K0102_DateApproval) = False Then D0102.DateApproval = Trim$(rs0102!K0102_DateApproval)
    If IsdbNull(rs0102!K0102_DateComplete) = False Then D0102.DateComplete = Trim$(rs0102!K0102_DateComplete)
    If IsdbNull(rs0102!K0102_DatePending) = False Then D0102.DatePending = Trim$(rs0102!K0102_DatePending)
    If IsdbNull(rs0102!K0102_DateCancel) = False Then D0102.DateCancel = Trim$(rs0102!K0102_DateCancel)
    If IsdbNull(rs0102!K0102_InchargeAccept) = False Then D0102.InchargeAccept = Trim$(rs0102!K0102_InchargeAccept)
    If IsdbNull(rs0102!K0102_MaterialBOMCode) = False Then D0102.MaterialBOMCode = Trim$(rs0102!K0102_MaterialBOMCode)
    If IsdbNull(rs0102!K0102_InchargeMaterialBOM) = False Then D0102.InchargeMaterialBOM = Trim$(rs0102!K0102_InchargeMaterialBOM)
    If IsdbNull(rs0102!K0102_ProcessBOMCode) = False Then D0102.ProcessBOMCode = Trim$(rs0102!K0102_ProcessBOMCode)
    If IsdbNull(rs0102!K0102_InchargeProcessBOM) = False Then D0102.InchargeProcessBOM = Trim$(rs0102!K0102_InchargeProcessBOM)
    If IsdbNull(rs0102!K0102_JobBOMCode) = False Then D0102.JobBOMCode = Trim$(rs0102!K0102_JobBOMCode)
    If IsdbNull(rs0102!K0102_InchargeJobBOM) = False Then D0102.InchargeJobBOM = Trim$(rs0102!K0102_InchargeJobBOM)
    If IsdbNull(rs0102!K0102_DevelopCode) = False Then D0102.DevelopCode = Trim$(rs0102!K0102_DevelopCode)
    If IsdbNull(rs0102!K0102_StartTime) = False Then D0102.StartTime = Trim$(rs0102!K0102_StartTime)
    If IsdbNull(rs0102!K0102_FinishTime) = False Then D0102.FinishTime = Trim$(rs0102!K0102_FinishTime)
    If IsdbNull(rs0102!K0102_InsertDate) = False Then D0102.InsertDate = Trim$(rs0102!K0102_InsertDate)
    If IsdbNull(rs0102!K0102_InchargeInsert) = False Then D0102.InchargeInsert = Trim$(rs0102!K0102_InchargeInsert)
    If IsdbNull(rs0102!K0102_UpdateDate) = False Then D0102.UpdateDate = Trim$(rs0102!K0102_UpdateDate)
    If IsdbNull(rs0102!K0102_InchargeUpdate) = False Then D0102.InchargeUpdate = Trim$(rs0102!K0102_InchargeUpdate)
    If IsdbNull(rs0102!K0102_AttchID) = False Then D0102.AttchID = Trim$(rs0102!K0102_AttchID)
    If IsdbNull(rs0102!K0102_CheckUse) = False Then D0102.CheckUse = Trim$(rs0102!K0102_CheckUse)
    If IsdbNull(rs0102!K0102_CheckComplete) = False Then D0102.CheckComplete = Trim$(rs0102!K0102_CheckComplete)
    If IsdbNull(rs0102!K0102_MaterialAMT) = False Then D0102.MaterialAMT = Trim$(rs0102!K0102_MaterialAMT)
    If IsdbNull(rs0102!K0102_ProcessAMT) = False Then D0102.ProcessAMT = Trim$(rs0102!K0102_ProcessAMT)
    If IsdbNull(rs0102!K0102_AdditionalAMT) = False Then D0102.AdditionalAMT = Trim$(rs0102!K0102_AdditionalAMT)
    If IsdbNull(rs0102!K0102_ExpenseAMT) = False Then D0102.ExpenseAMT = Trim$(rs0102!K0102_ExpenseAMT)
    If IsdbNull(rs0102!K0102_SalesAMT) = False Then D0102.SalesAMT = Trim$(rs0102!K0102_SalesAMT)
    If IsdbNull(rs0102!K0102_TotalAMT) = False Then D0102.TotalAMT = Trim$(rs0102!K0102_TotalAMT)
    If IsdbNull(rs0102!K0102_PerProfit) = False Then D0102.PerProfit = Trim$(rs0102!K0102_PerProfit)
    If IsdbNull(rs0102!K0102_TotalCost) = False Then D0102.TotalCost = Trim$(rs0102!K0102_TotalCost)
    If IsdbNull(rs0102!K0102_SalesPrice) = False Then D0102.SalesPrice = Trim$(rs0102!K0102_SalesPrice)
    If IsdbNull(rs0102!K0102_SalesProfit) = False Then D0102.SalesProfit = Trim$(rs0102!K0102_SalesProfit)
    If IsdbNull(rs0102!K0102_MaterialStatus) = False Then D0102.MaterialStatus = Trim$(rs0102!K0102_MaterialStatus)
    If IsdbNull(rs0102!K0102_SoleStatus) = False Then D0102.SoleStatus = Trim$(rs0102!K0102_SoleStatus)
    If IsdbNull(rs0102!K0102_DatePattern) = False Then D0102.DatePattern = Trim$(rs0102!K0102_DatePattern)
    If IsdbNull(rs0102!K0102_DateMaterial) = False Then D0102.DateMaterial = Trim$(rs0102!K0102_DateMaterial)
    If IsdbNull(rs0102!K0102_DatePlanning) = False Then D0102.DatePlanning = Trim$(rs0102!K0102_DatePlanning)
    If IsdbNull(rs0102!K0102_DateSole) = False Then D0102.DateSole = Trim$(rs0102!K0102_DateSole)
    If IsdbNull(rs0102!K0102_DateRnD) = False Then D0102.DateRnD = Trim$(rs0102!K0102_DateRnD)
    If IsdbNull(rs0102!K0102_DateFitting) = False Then D0102.DateFitting = Trim$(rs0102!K0102_DateFitting)
    If IsdbNull(rs0102!K0102_DateCutting) = False Then D0102.DateCutting = Trim$(rs0102!K0102_DateCutting)
    If IsdbNull(rs0102!K0102_DateStitching) = False Then D0102.DateStitching = Trim$(rs0102!K0102_DateStitching)
    If IsdbNull(rs0102!K0102_DateStockfit) = False Then D0102.DateStockfit = Trim$(rs0102!K0102_DateStockfit)
    If IsdbNull(rs0102!K0102_DateAssembly) = False Then D0102.DateAssembly = Trim$(rs0102!K0102_DateAssembly)
    If IsdbNull(rs0102!K0102_DateShipping) = False Then D0102.DateShipping = Trim$(rs0102!K0102_DateShipping)
    If IsdbNull(rs0102!K0102_QtyOrder) = False Then D0102.QtyOrder = Trim$(rs0102!K0102_QtyOrder)
    If IsdbNull(rs0102!K0102_QtyBooking) = False Then D0102.QtyBooking = Trim$(rs0102!K0102_QtyBooking)
    If IsdbNull(rs0102!K0102_QtyJob) = False Then D0102.QtyJob = Trim$(rs0102!K0102_QtyJob)
    If IsdbNull(rs0102!K0102_QtySole) = False Then D0102.QtySole = Trim$(rs0102!K0102_QtySole)
    If IsdbNull(rs0102!K0102_QtyCutting) = False Then D0102.QtyCutting = Trim$(rs0102!K0102_QtyCutting)
    If IsdbNull(rs0102!K0102_QtyStitching) = False Then D0102.QtyStitching = Trim$(rs0102!K0102_QtyStitching)
    If IsdbNull(rs0102!K0102_QtyStockfit) = False Then D0102.QtyStockfit = Trim$(rs0102!K0102_QtyStockfit)
    If IsdbNull(rs0102!K0102_QtyAssembly) = False Then D0102.QtyAssembly = Trim$(rs0102!K0102_QtyAssembly)
    If IsdbNull(rs0102!K0102_QtyShipping) = False Then D0102.QtyShipping = Trim$(rs0102!K0102_QtyShipping)
    If IsdbNull(rs0102!K0102_RemarkOrder) = False Then D0102.RemarkOrder = Trim$(rs0102!K0102_RemarkOrder)
    If IsdbNull(rs0102!K0102_RemarkCustomer) = False Then D0102.RemarkCustomer = Trim$(rs0102!K0102_RemarkCustomer)
    If IsdbNull(rs0102!K0102_Remark) = False Then D0102.Remark = Trim$(rs0102!K0102_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K0102_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K0102_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z0102 As T0102_AREA, SPECNO AS String, SPECNOSEQ AS String) as Boolean

K0102_MOVE = False

Try
    If READ_PFK0102(SPECNO, SPECNOSEQ) = True Then
                z0102 = D0102
		K0102_MOVE = True
		else
	z0102 = nothing
     End If

     If  getColumIndex(spr,"SpecNo") > -1 then z0102.SpecNo = getDataM(spr, getColumIndex(spr,"SpecNo"), xRow)
     If  getColumIndex(spr,"SpecNoSeq") > -1 then z0102.SpecNoSeq = getDataM(spr, getColumIndex(spr,"SpecNoSeq"), xRow)
     If  getColumIndex(spr,"DateConfirm") > -1 then z0102.DateConfirm = getDataM(spr, getColumIndex(spr,"DateConfirm"), xRow)
     If  getColumIndex(spr,"SpecNoRef") > -1 then z0102.SpecNoRef = getDataM(spr, getColumIndex(spr,"SpecNoRef"), xRow)
     If  getColumIndex(spr,"SpecSeqRef") > -1 then z0102.SpecSeqRef = getDataM(spr, getColumIndex(spr,"SpecSeqRef"), xRow)
     If  getColumIndex(spr,"SpecNoBe") > -1 then z0102.SpecNoBe = getDataM(spr, getColumIndex(spr,"SpecNoBe"), xRow)
     If  getColumIndex(spr,"SpecSeqBe") > -1 then z0102.SpecSeqBe = getDataM(spr, getColumIndex(spr,"SpecSeqBe"), xRow)
     If  getColumIndex(spr,"SpeciticSize") > -1 then z0102.SpeciticSize = getDataM(spr, getColumIndex(spr,"SpeciticSize"), xRow)
     If  getColumIndex(spr,"OrderRnDStatus") > -1 then z0102.OrderRnDStatus = getDataM(spr, getColumIndex(spr,"OrderRnDStatus"), xRow)
     If  getColumIndex(spr,"DateAccept") > -1 then z0102.DateAccept = getDataM(spr, getColumIndex(spr,"DateAccept"), xRow)
     If  getColumIndex(spr,"DateApproval") > -1 then z0102.DateApproval = getDataM(spr, getColumIndex(spr,"DateApproval"), xRow)
     If  getColumIndex(spr,"DateComplete") > -1 then z0102.DateComplete = getDataM(spr, getColumIndex(spr,"DateComplete"), xRow)
     If  getColumIndex(spr,"DatePending") > -1 then z0102.DatePending = getDataM(spr, getColumIndex(spr,"DatePending"), xRow)
     If  getColumIndex(spr,"DateCancel") > -1 then z0102.DateCancel = getDataM(spr, getColumIndex(spr,"DateCancel"), xRow)
     If  getColumIndex(spr,"InchargeAccept") > -1 then z0102.InchargeAccept = getDataM(spr, getColumIndex(spr,"InchargeAccept"), xRow)
     If  getColumIndex(spr,"MaterialBOMCode") > -1 then z0102.MaterialBOMCode = getDataM(spr, getColumIndex(spr,"MaterialBOMCode"), xRow)
     If  getColumIndex(spr,"InchargeMaterialBOM") > -1 then z0102.InchargeMaterialBOM = getDataM(spr, getColumIndex(spr,"InchargeMaterialBOM"), xRow)
     If  getColumIndex(spr,"ProcessBOMCode") > -1 then z0102.ProcessBOMCode = getDataM(spr, getColumIndex(spr,"ProcessBOMCode"), xRow)
     If  getColumIndex(spr,"InchargeProcessBOM") > -1 then z0102.InchargeProcessBOM = getDataM(spr, getColumIndex(spr,"InchargeProcessBOM"), xRow)
     If  getColumIndex(spr,"JobBOMCode") > -1 then z0102.JobBOMCode = getDataM(spr, getColumIndex(spr,"JobBOMCode"), xRow)
     If  getColumIndex(spr,"InchargeJobBOM") > -1 then z0102.InchargeJobBOM = getDataM(spr, getColumIndex(spr,"InchargeJobBOM"), xRow)
     If  getColumIndex(spr,"DevelopCode") > -1 then z0102.DevelopCode = getDataM(spr, getColumIndex(spr,"DevelopCode"), xRow)
     If  getColumIndex(spr,"StartTime") > -1 then z0102.StartTime = getDataM(spr, getColumIndex(spr,"StartTime"), xRow)
     If  getColumIndex(spr,"FinishTime") > -1 then z0102.FinishTime = getDataM(spr, getColumIndex(spr,"FinishTime"), xRow)
     If  getColumIndex(spr,"InsertDate") > -1 then z0102.InsertDate = getDataM(spr, getColumIndex(spr,"InsertDate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z0102.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"UpdateDate") > -1 then z0102.UpdateDate = getDataM(spr, getColumIndex(spr,"UpdateDate"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z0102.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"AttchID") > -1 then z0102.AttchID = getDataM(spr, getColumIndex(spr,"AttchID"), xRow)
     If  getColumIndex(spr,"CheckUse") > -1 then z0102.CheckUse = getDataM(spr, getColumIndex(spr,"CheckUse"), xRow)
     If  getColumIndex(spr,"CheckComplete") > -1 then z0102.CheckComplete = getDataM(spr, getColumIndex(spr,"CheckComplete"), xRow)
     If  getColumIndex(spr,"MaterialAMT") > -1 then z0102.MaterialAMT = getDataM(spr, getColumIndex(spr,"MaterialAMT"), xRow)
     If  getColumIndex(spr,"ProcessAMT") > -1 then z0102.ProcessAMT = getDataM(spr, getColumIndex(spr,"ProcessAMT"), xRow)
     If  getColumIndex(spr,"AdditionalAMT") > -1 then z0102.AdditionalAMT = getDataM(spr, getColumIndex(spr,"AdditionalAMT"), xRow)
     If  getColumIndex(spr,"ExpenseAMT") > -1 then z0102.ExpenseAMT = getDataM(spr, getColumIndex(spr,"ExpenseAMT"), xRow)
     If  getColumIndex(spr,"SalesAMT") > -1 then z0102.SalesAMT = getDataM(spr, getColumIndex(spr,"SalesAMT"), xRow)
     If  getColumIndex(spr,"TotalAMT") > -1 then z0102.TotalAMT = getDataM(spr, getColumIndex(spr,"TotalAMT"), xRow)
     If  getColumIndex(spr,"PerProfit") > -1 then z0102.PerProfit = getDataM(spr, getColumIndex(spr,"PerProfit"), xRow)
     If  getColumIndex(spr,"TotalCost") > -1 then z0102.TotalCost = getDataM(spr, getColumIndex(spr,"TotalCost"), xRow)
     If  getColumIndex(spr,"SalesPrice") > -1 then z0102.SalesPrice = getDataM(spr, getColumIndex(spr,"SalesPrice"), xRow)
     If  getColumIndex(spr,"SalesProfit") > -1 then z0102.SalesProfit = getDataM(spr, getColumIndex(spr,"SalesProfit"), xRow)
     If  getColumIndex(spr,"MaterialStatus") > -1 then z0102.MaterialStatus = getDataM(spr, getColumIndex(spr,"MaterialStatus"), xRow)
     If  getColumIndex(spr,"SoleStatus") > -1 then z0102.SoleStatus = getDataM(spr, getColumIndex(spr,"SoleStatus"), xRow)
     If  getColumIndex(spr,"DatePattern") > -1 then z0102.DatePattern = getDataM(spr, getColumIndex(spr,"DatePattern"), xRow)
     If  getColumIndex(spr,"DateMaterial") > -1 then z0102.DateMaterial = getDataM(spr, getColumIndex(spr,"DateMaterial"), xRow)
     If  getColumIndex(spr,"DatePlanning") > -1 then z0102.DatePlanning = getDataM(spr, getColumIndex(spr,"DatePlanning"), xRow)
     If  getColumIndex(spr,"DateSole") > -1 then z0102.DateSole = getDataM(spr, getColumIndex(spr,"DateSole"), xRow)
     If  getColumIndex(spr,"DateRnD") > -1 then z0102.DateRnD = getDataM(spr, getColumIndex(spr,"DateRnD"), xRow)
     If  getColumIndex(spr,"DateFitting") > -1 then z0102.DateFitting = getDataM(spr, getColumIndex(spr,"DateFitting"), xRow)
     If  getColumIndex(spr,"DateCutting") > -1 then z0102.DateCutting = getDataM(spr, getColumIndex(spr,"DateCutting"), xRow)
     If  getColumIndex(spr,"DateStitching") > -1 then z0102.DateStitching = getDataM(spr, getColumIndex(spr,"DateStitching"), xRow)
     If  getColumIndex(spr,"DateStockfit") > -1 then z0102.DateStockfit = getDataM(spr, getColumIndex(spr,"DateStockfit"), xRow)
     If  getColumIndex(spr,"DateAssembly") > -1 then z0102.DateAssembly = getDataM(spr, getColumIndex(spr,"DateAssembly"), xRow)
     If  getColumIndex(spr,"DateShipping") > -1 then z0102.DateShipping = getDataM(spr, getColumIndex(spr,"DateShipping"), xRow)
     If  getColumIndex(spr,"QtyOrder") > -1 then z0102.QtyOrder = getDataM(spr, getColumIndex(spr,"QtyOrder"), xRow)
     If  getColumIndex(spr,"QtyBooking") > -1 then z0102.QtyBooking = getDataM(spr, getColumIndex(spr,"QtyBooking"), xRow)
     If  getColumIndex(spr,"QtyJob") > -1 then z0102.QtyJob = getDataM(spr, getColumIndex(spr,"QtyJob"), xRow)
     If  getColumIndex(spr,"QtySole") > -1 then z0102.QtySole = getDataM(spr, getColumIndex(spr,"QtySole"), xRow)
     If  getColumIndex(spr,"QtyCutting") > -1 then z0102.QtyCutting = getDataM(spr, getColumIndex(spr,"QtyCutting"), xRow)
     If  getColumIndex(spr,"QtyStitching") > -1 then z0102.QtyStitching = getDataM(spr, getColumIndex(spr,"QtyStitching"), xRow)
     If  getColumIndex(spr,"QtyStockfit") > -1 then z0102.QtyStockfit = getDataM(spr, getColumIndex(spr,"QtyStockfit"), xRow)
     If  getColumIndex(spr,"QtyAssembly") > -1 then z0102.QtyAssembly = getDataM(spr, getColumIndex(spr,"QtyAssembly"), xRow)
     If  getColumIndex(spr,"QtyShipping") > -1 then z0102.QtyShipping = getDataM(spr, getColumIndex(spr,"QtyShipping"), xRow)
     If  getColumIndex(spr,"RemarkOrder") > -1 then z0102.RemarkOrder = getDataM(spr, getColumIndex(spr,"RemarkOrder"), xRow)
     If  getColumIndex(spr,"RemarkCustomer") > -1 then z0102.RemarkCustomer = getDataM(spr, getColumIndex(spr,"RemarkCustomer"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z0102.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K0102_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K0102_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z0102 As T0102_AREA,CheckClear as Boolean,SPECNO AS String, SPECNOSEQ AS String) as Boolean

K0102_MOVE = False

Try
    If READ_PFK0102(SPECNO, SPECNOSEQ) = True Then
                z0102 = D0102
		K0102_MOVE = True
		else
	If CheckClear  = True then z0102 = nothing
     End If

     If  getColumIndex(spr,"SpecNo") > -1 then z0102.SpecNo = getDataM(spr, getColumIndex(spr,"SpecNo"), xRow)
     If  getColumIndex(spr,"SpecNoSeq") > -1 then z0102.SpecNoSeq = getDataM(spr, getColumIndex(spr,"SpecNoSeq"), xRow)
     If  getColumIndex(spr,"DateConfirm") > -1 then z0102.DateConfirm = getDataM(spr, getColumIndex(spr,"DateConfirm"), xRow)
     If  getColumIndex(spr,"SpecNoRef") > -1 then z0102.SpecNoRef = getDataM(spr, getColumIndex(spr,"SpecNoRef"), xRow)
     If  getColumIndex(spr,"SpecSeqRef") > -1 then z0102.SpecSeqRef = getDataM(spr, getColumIndex(spr,"SpecSeqRef"), xRow)
     If  getColumIndex(spr,"SpecNoBe") > -1 then z0102.SpecNoBe = getDataM(spr, getColumIndex(spr,"SpecNoBe"), xRow)
     If  getColumIndex(spr,"SpecSeqBe") > -1 then z0102.SpecSeqBe = getDataM(spr, getColumIndex(spr,"SpecSeqBe"), xRow)
     If  getColumIndex(spr,"SpeciticSize") > -1 then z0102.SpeciticSize = getDataM(spr, getColumIndex(spr,"SpeciticSize"), xRow)
     If  getColumIndex(spr,"OrderRnDStatus") > -1 then z0102.OrderRnDStatus = getDataM(spr, getColumIndex(spr,"OrderRnDStatus"), xRow)
     If  getColumIndex(spr,"DateAccept") > -1 then z0102.DateAccept = getDataM(spr, getColumIndex(spr,"DateAccept"), xRow)
     If  getColumIndex(spr,"DateApproval") > -1 then z0102.DateApproval = getDataM(spr, getColumIndex(spr,"DateApproval"), xRow)
     If  getColumIndex(spr,"DateComplete") > -1 then z0102.DateComplete = getDataM(spr, getColumIndex(spr,"DateComplete"), xRow)
     If  getColumIndex(spr,"DatePending") > -1 then z0102.DatePending = getDataM(spr, getColumIndex(spr,"DatePending"), xRow)
     If  getColumIndex(spr,"DateCancel") > -1 then z0102.DateCancel = getDataM(spr, getColumIndex(spr,"DateCancel"), xRow)
     If  getColumIndex(spr,"InchargeAccept") > -1 then z0102.InchargeAccept = getDataM(spr, getColumIndex(spr,"InchargeAccept"), xRow)
     If  getColumIndex(spr,"MaterialBOMCode") > -1 then z0102.MaterialBOMCode = getDataM(spr, getColumIndex(spr,"MaterialBOMCode"), xRow)
     If  getColumIndex(spr,"InchargeMaterialBOM") > -1 then z0102.InchargeMaterialBOM = getDataM(spr, getColumIndex(spr,"InchargeMaterialBOM"), xRow)
     If  getColumIndex(spr,"ProcessBOMCode") > -1 then z0102.ProcessBOMCode = getDataM(spr, getColumIndex(spr,"ProcessBOMCode"), xRow)
     If  getColumIndex(spr,"InchargeProcessBOM") > -1 then z0102.InchargeProcessBOM = getDataM(spr, getColumIndex(spr,"InchargeProcessBOM"), xRow)
     If  getColumIndex(spr,"JobBOMCode") > -1 then z0102.JobBOMCode = getDataM(spr, getColumIndex(spr,"JobBOMCode"), xRow)
     If  getColumIndex(spr,"InchargeJobBOM") > -1 then z0102.InchargeJobBOM = getDataM(spr, getColumIndex(spr,"InchargeJobBOM"), xRow)
     If  getColumIndex(spr,"DevelopCode") > -1 then z0102.DevelopCode = getDataM(spr, getColumIndex(spr,"DevelopCode"), xRow)
     If  getColumIndex(spr,"StartTime") > -1 then z0102.StartTime = getDataM(spr, getColumIndex(spr,"StartTime"), xRow)
     If  getColumIndex(spr,"FinishTime") > -1 then z0102.FinishTime = getDataM(spr, getColumIndex(spr,"FinishTime"), xRow)
     If  getColumIndex(spr,"InsertDate") > -1 then z0102.InsertDate = getDataM(spr, getColumIndex(spr,"InsertDate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z0102.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"UpdateDate") > -1 then z0102.UpdateDate = getDataM(spr, getColumIndex(spr,"UpdateDate"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z0102.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"AttchID") > -1 then z0102.AttchID = getDataM(spr, getColumIndex(spr,"AttchID"), xRow)
     If  getColumIndex(spr,"CheckUse") > -1 then z0102.CheckUse = getDataM(spr, getColumIndex(spr,"CheckUse"), xRow)
     If  getColumIndex(spr,"CheckComplete") > -1 then z0102.CheckComplete = getDataM(spr, getColumIndex(spr,"CheckComplete"), xRow)
     If  getColumIndex(spr,"MaterialAMT") > -1 then z0102.MaterialAMT = getDataM(spr, getColumIndex(spr,"MaterialAMT"), xRow)
     If  getColumIndex(spr,"ProcessAMT") > -1 then z0102.ProcessAMT = getDataM(spr, getColumIndex(spr,"ProcessAMT"), xRow)
     If  getColumIndex(spr,"AdditionalAMT") > -1 then z0102.AdditionalAMT = getDataM(spr, getColumIndex(spr,"AdditionalAMT"), xRow)
     If  getColumIndex(spr,"ExpenseAMT") > -1 then z0102.ExpenseAMT = getDataM(spr, getColumIndex(spr,"ExpenseAMT"), xRow)
     If  getColumIndex(spr,"SalesAMT") > -1 then z0102.SalesAMT = getDataM(spr, getColumIndex(spr,"SalesAMT"), xRow)
     If  getColumIndex(spr,"TotalAMT") > -1 then z0102.TotalAMT = getDataM(spr, getColumIndex(spr,"TotalAMT"), xRow)
     If  getColumIndex(spr,"PerProfit") > -1 then z0102.PerProfit = getDataM(spr, getColumIndex(spr,"PerProfit"), xRow)
     If  getColumIndex(spr,"TotalCost") > -1 then z0102.TotalCost = getDataM(spr, getColumIndex(spr,"TotalCost"), xRow)
     If  getColumIndex(spr,"SalesPrice") > -1 then z0102.SalesPrice = getDataM(spr, getColumIndex(spr,"SalesPrice"), xRow)
     If  getColumIndex(spr,"SalesProfit") > -1 then z0102.SalesProfit = getDataM(spr, getColumIndex(spr,"SalesProfit"), xRow)
     If  getColumIndex(spr,"MaterialStatus") > -1 then z0102.MaterialStatus = getDataM(spr, getColumIndex(spr,"MaterialStatus"), xRow)
     If  getColumIndex(spr,"SoleStatus") > -1 then z0102.SoleStatus = getDataM(spr, getColumIndex(spr,"SoleStatus"), xRow)
     If  getColumIndex(spr,"DatePattern") > -1 then z0102.DatePattern = getDataM(spr, getColumIndex(spr,"DatePattern"), xRow)
     If  getColumIndex(spr,"DateMaterial") > -1 then z0102.DateMaterial = getDataM(spr, getColumIndex(spr,"DateMaterial"), xRow)
     If  getColumIndex(spr,"DatePlanning") > -1 then z0102.DatePlanning = getDataM(spr, getColumIndex(spr,"DatePlanning"), xRow)
     If  getColumIndex(spr,"DateSole") > -1 then z0102.DateSole = getDataM(spr, getColumIndex(spr,"DateSole"), xRow)
     If  getColumIndex(spr,"DateRnD") > -1 then z0102.DateRnD = getDataM(spr, getColumIndex(spr,"DateRnD"), xRow)
     If  getColumIndex(spr,"DateFitting") > -1 then z0102.DateFitting = getDataM(spr, getColumIndex(spr,"DateFitting"), xRow)
     If  getColumIndex(spr,"DateCutting") > -1 then z0102.DateCutting = getDataM(spr, getColumIndex(spr,"DateCutting"), xRow)
     If  getColumIndex(spr,"DateStitching") > -1 then z0102.DateStitching = getDataM(spr, getColumIndex(spr,"DateStitching"), xRow)
     If  getColumIndex(spr,"DateStockfit") > -1 then z0102.DateStockfit = getDataM(spr, getColumIndex(spr,"DateStockfit"), xRow)
     If  getColumIndex(spr,"DateAssembly") > -1 then z0102.DateAssembly = getDataM(spr, getColumIndex(spr,"DateAssembly"), xRow)
     If  getColumIndex(spr,"DateShipping") > -1 then z0102.DateShipping = getDataM(spr, getColumIndex(spr,"DateShipping"), xRow)
     If  getColumIndex(spr,"QtyOrder") > -1 then z0102.QtyOrder = getDataM(spr, getColumIndex(spr,"QtyOrder"), xRow)
     If  getColumIndex(spr,"QtyBooking") > -1 then z0102.QtyBooking = getDataM(spr, getColumIndex(spr,"QtyBooking"), xRow)
     If  getColumIndex(spr,"QtyJob") > -1 then z0102.QtyJob = getDataM(spr, getColumIndex(spr,"QtyJob"), xRow)
     If  getColumIndex(spr,"QtySole") > -1 then z0102.QtySole = getDataM(spr, getColumIndex(spr,"QtySole"), xRow)
     If  getColumIndex(spr,"QtyCutting") > -1 then z0102.QtyCutting = getDataM(spr, getColumIndex(spr,"QtyCutting"), xRow)
     If  getColumIndex(spr,"QtyStitching") > -1 then z0102.QtyStitching = getDataM(spr, getColumIndex(spr,"QtyStitching"), xRow)
     If  getColumIndex(spr,"QtyStockfit") > -1 then z0102.QtyStockfit = getDataM(spr, getColumIndex(spr,"QtyStockfit"), xRow)
     If  getColumIndex(spr,"QtyAssembly") > -1 then z0102.QtyAssembly = getDataM(spr, getColumIndex(spr,"QtyAssembly"), xRow)
     If  getColumIndex(spr,"QtyShipping") > -1 then z0102.QtyShipping = getDataM(spr, getColumIndex(spr,"QtyShipping"), xRow)
     If  getColumIndex(spr,"RemarkOrder") > -1 then z0102.RemarkOrder = getDataM(spr, getColumIndex(spr,"RemarkOrder"), xRow)
     If  getColumIndex(spr,"RemarkCustomer") > -1 then z0102.RemarkCustomer = getDataM(spr, getColumIndex(spr,"RemarkCustomer"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z0102.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K0102_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K0102_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z0102 As T0102_AREA, Job as String, SPECNO AS String, SPECNOSEQ AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K0102_MOVE = False

Try
    If READ_PFK0102(SPECNO, SPECNOSEQ) = True Then
                z0102 = D0102
		K0102_MOVE = True
		else
	z0102 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK0102")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "SPECNO":z0102.SpecNo = Children(i).Code
   Case "SPECNOSEQ":z0102.SpecNoSeq = Children(i).Code
   Case "DATECONFIRM":z0102.DateConfirm = Children(i).Code
   Case "SPECNOREF":z0102.SpecNoRef = Children(i).Code
   Case "SPECSEQREF":z0102.SpecSeqRef = Children(i).Code
   Case "SPECNOBE":z0102.SpecNoBe = Children(i).Code
   Case "SPECSEQBE":z0102.SpecSeqBe = Children(i).Code
   Case "SPECITICSIZE":z0102.SpeciticSize = Children(i).Code
   Case "ORDERRNDSTATUS":z0102.OrderRnDStatus = Children(i).Code
   Case "DATEACCEPT":z0102.DateAccept = Children(i).Code
   Case "DATEAPPROVAL":z0102.DateApproval = Children(i).Code
   Case "DATECOMPLETE":z0102.DateComplete = Children(i).Code
   Case "DATEPENDING":z0102.DatePending = Children(i).Code
   Case "DATECANCEL":z0102.DateCancel = Children(i).Code
   Case "INCHARGEACCEPT":z0102.InchargeAccept = Children(i).Code
   Case "MATERIALBOMCODE":z0102.MaterialBOMCode = Children(i).Code
   Case "INCHARGEMATERIALBOM":z0102.InchargeMaterialBOM = Children(i).Code
   Case "PROCESSBOMCODE":z0102.ProcessBOMCode = Children(i).Code
   Case "INCHARGEPROCESSBOM":z0102.InchargeProcessBOM = Children(i).Code
   Case "JOBBOMCODE":z0102.JobBOMCode = Children(i).Code
   Case "INCHARGEJOBBOM":z0102.InchargeJobBOM = Children(i).Code
   Case "DEVELOPCODE":z0102.DevelopCode = Children(i).Code
   Case "STARTTIME":z0102.StartTime = Children(i).Code
   Case "FINISHTIME":z0102.FinishTime = Children(i).Code
   Case "INSERTDATE":z0102.InsertDate = Children(i).Code
   Case "INCHARGEINSERT":z0102.InchargeInsert = Children(i).Code
   Case "UPDATEDATE":z0102.UpdateDate = Children(i).Code
   Case "INCHARGEUPDATE":z0102.InchargeUpdate = Children(i).Code
   Case "ATTCHID":z0102.AttchID = Children(i).Code
   Case "CHECKUSE":z0102.CheckUse = Children(i).Code
   Case "CHECKCOMPLETE":z0102.CheckComplete = Children(i).Code
   Case "MATERIALAMT":z0102.MaterialAMT = Children(i).Code
   Case "PROCESSAMT":z0102.ProcessAMT = Children(i).Code
   Case "ADDITIONALAMT":z0102.AdditionalAMT = Children(i).Code
   Case "EXPENSEAMT":z0102.ExpenseAMT = Children(i).Code
   Case "SALESAMT":z0102.SalesAMT = Children(i).Code
   Case "TOTALAMT":z0102.TotalAMT = Children(i).Code
   Case "PERPROFIT":z0102.PerProfit = Children(i).Code
   Case "TOTALCOST":z0102.TotalCost = Children(i).Code
   Case "SALESPRICE":z0102.SalesPrice = Children(i).Code
   Case "SALESPROFIT":z0102.SalesProfit = Children(i).Code
   Case "MATERIALSTATUS":z0102.MaterialStatus = Children(i).Code
   Case "SOLESTATUS":z0102.SoleStatus = Children(i).Code
   Case "DATEPATTERN":z0102.DatePattern = Children(i).Code
   Case "DATEMATERIAL":z0102.DateMaterial = Children(i).Code
   Case "DATEPLANNING":z0102.DatePlanning = Children(i).Code
   Case "DATESOLE":z0102.DateSole = Children(i).Code
   Case "DATERND":z0102.DateRnD = Children(i).Code
   Case "DATEFITTING":z0102.DateFitting = Children(i).Code
   Case "DATECUTTING":z0102.DateCutting = Children(i).Code
   Case "DATESTITCHING":z0102.DateStitching = Children(i).Code
   Case "DATESTOCKFIT":z0102.DateStockfit = Children(i).Code
   Case "DATEASSEMBLY":z0102.DateAssembly = Children(i).Code
   Case "DATESHIPPING":z0102.DateShipping = Children(i).Code
   Case "QTYORDER":z0102.QtyOrder = Children(i).Code
   Case "QTYBOOKING":z0102.QtyBooking = Children(i).Code
   Case "QTYJOB":z0102.QtyJob = Children(i).Code
   Case "QTYSOLE":z0102.QtySole = Children(i).Code
   Case "QTYCUTTING":z0102.QtyCutting = Children(i).Code
   Case "QTYSTITCHING":z0102.QtyStitching = Children(i).Code
   Case "QTYSTOCKFIT":z0102.QtyStockfit = Children(i).Code
   Case "QTYASSEMBLY":z0102.QtyAssembly = Children(i).Code
   Case "QTYSHIPPING":z0102.QtyShipping = Children(i).Code
   Case "REMARKORDER":z0102.RemarkOrder = Children(i).Code
   Case "REMARKCUSTOMER":z0102.RemarkCustomer = Children(i).Code
   Case "REMARK":z0102.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "SPECNO":z0102.SpecNo = Children(i).Data
   Case "SPECNOSEQ":z0102.SpecNoSeq = Children(i).Data
   Case "DATECONFIRM":z0102.DateConfirm = Children(i).Data
   Case "SPECNOREF":z0102.SpecNoRef = Children(i).Data
   Case "SPECSEQREF":z0102.SpecSeqRef = Children(i).Data
   Case "SPECNOBE":z0102.SpecNoBe = Children(i).Data
   Case "SPECSEQBE":z0102.SpecSeqBe = Children(i).Data
   Case "SPECITICSIZE":z0102.SpeciticSize = Children(i).Data
   Case "ORDERRNDSTATUS":z0102.OrderRnDStatus = Children(i).Data
   Case "DATEACCEPT":z0102.DateAccept = Children(i).Data
   Case "DATEAPPROVAL":z0102.DateApproval = Children(i).Data
   Case "DATECOMPLETE":z0102.DateComplete = Children(i).Data
   Case "DATEPENDING":z0102.DatePending = Children(i).Data
   Case "DATECANCEL":z0102.DateCancel = Children(i).Data
   Case "INCHARGEACCEPT":z0102.InchargeAccept = Children(i).Data
   Case "MATERIALBOMCODE":z0102.MaterialBOMCode = Children(i).Data
   Case "INCHARGEMATERIALBOM":z0102.InchargeMaterialBOM = Children(i).Data
   Case "PROCESSBOMCODE":z0102.ProcessBOMCode = Children(i).Data
   Case "INCHARGEPROCESSBOM":z0102.InchargeProcessBOM = Children(i).Data
   Case "JOBBOMCODE":z0102.JobBOMCode = Children(i).Data
   Case "INCHARGEJOBBOM":z0102.InchargeJobBOM = Children(i).Data
   Case "DEVELOPCODE":z0102.DevelopCode = Children(i).Data
   Case "STARTTIME":z0102.StartTime = Children(i).Data
   Case "FINISHTIME":z0102.FinishTime = Children(i).Data
   Case "INSERTDATE":z0102.InsertDate = Children(i).Data
   Case "INCHARGEINSERT":z0102.InchargeInsert = Children(i).Data
   Case "UPDATEDATE":z0102.UpdateDate = Children(i).Data
   Case "INCHARGEUPDATE":z0102.InchargeUpdate = Children(i).Data
   Case "ATTCHID":z0102.AttchID = Children(i).Data
   Case "CHECKUSE":z0102.CheckUse = Children(i).Data
   Case "CHECKCOMPLETE":z0102.CheckComplete = Children(i).Data
   Case "MATERIALAMT":z0102.MaterialAMT = Children(i).Data
   Case "PROCESSAMT":z0102.ProcessAMT = Children(i).Data
   Case "ADDITIONALAMT":z0102.AdditionalAMT = Children(i).Data
   Case "EXPENSEAMT":z0102.ExpenseAMT = Children(i).Data
   Case "SALESAMT":z0102.SalesAMT = Children(i).Data
   Case "TOTALAMT":z0102.TotalAMT = Children(i).Data
   Case "PERPROFIT":z0102.PerProfit = Children(i).Data
   Case "TOTALCOST":z0102.TotalCost = Children(i).Data
   Case "SALESPRICE":z0102.SalesPrice = Children(i).Data
   Case "SALESPROFIT":z0102.SalesProfit = Children(i).Data
   Case "MATERIALSTATUS":z0102.MaterialStatus = Children(i).Data
   Case "SOLESTATUS":z0102.SoleStatus = Children(i).Data
   Case "DATEPATTERN":z0102.DatePattern = Children(i).Data
   Case "DATEMATERIAL":z0102.DateMaterial = Children(i).Data
   Case "DATEPLANNING":z0102.DatePlanning = Children(i).Data
   Case "DATESOLE":z0102.DateSole = Children(i).Data
   Case "DATERND":z0102.DateRnD = Children(i).Data
   Case "DATEFITTING":z0102.DateFitting = Children(i).Data
   Case "DATECUTTING":z0102.DateCutting = Children(i).Data
   Case "DATESTITCHING":z0102.DateStitching = Children(i).Data
   Case "DATESTOCKFIT":z0102.DateStockfit = Children(i).Data
   Case "DATEASSEMBLY":z0102.DateAssembly = Children(i).Data
   Case "DATESHIPPING":z0102.DateShipping = Children(i).Data
   Case "QTYORDER":z0102.QtyOrder = Children(i).Data
   Case "QTYBOOKING":z0102.QtyBooking = Children(i).Data
   Case "QTYJOB":z0102.QtyJob = Children(i).Data
   Case "QTYSOLE":z0102.QtySole = Children(i).Data
   Case "QTYCUTTING":z0102.QtyCutting = Children(i).Data
   Case "QTYSTITCHING":z0102.QtyStitching = Children(i).Data
   Case "QTYSTOCKFIT":z0102.QtyStockfit = Children(i).Data
   Case "QTYASSEMBLY":z0102.QtyAssembly = Children(i).Data
   Case "QTYSHIPPING":z0102.QtyShipping = Children(i).Data
   Case "REMARKORDER":z0102.RemarkOrder = Children(i).Data
   Case "REMARKCUSTOMER":z0102.RemarkCustomer = Children(i).Data
   Case "REMARK":z0102.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K0102_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K0102_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z0102 As T0102_AREA, Job as String, CheckClear as Boolean, SPECNO AS String, SPECNOSEQ AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K0102_MOVE = False

Try
    If READ_PFK0102(SPECNO, SPECNOSEQ) = True Then
                z0102 = D0102
		K0102_MOVE = True
		else
	If CheckClear  = True then z0102 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK0102")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "SPECNO":z0102.SpecNo = Children(i).Code
   Case "SPECNOSEQ":z0102.SpecNoSeq = Children(i).Code
   Case "DATECONFIRM":z0102.DateConfirm = Children(i).Code
   Case "SPECNOREF":z0102.SpecNoRef = Children(i).Code
   Case "SPECSEQREF":z0102.SpecSeqRef = Children(i).Code
   Case "SPECNOBE":z0102.SpecNoBe = Children(i).Code
   Case "SPECSEQBE":z0102.SpecSeqBe = Children(i).Code
   Case "SPECITICSIZE":z0102.SpeciticSize = Children(i).Code
   Case "ORDERRNDSTATUS":z0102.OrderRnDStatus = Children(i).Code
   Case "DATEACCEPT":z0102.DateAccept = Children(i).Code
   Case "DATEAPPROVAL":z0102.DateApproval = Children(i).Code
   Case "DATECOMPLETE":z0102.DateComplete = Children(i).Code
   Case "DATEPENDING":z0102.DatePending = Children(i).Code
   Case "DATECANCEL":z0102.DateCancel = Children(i).Code
   Case "INCHARGEACCEPT":z0102.InchargeAccept = Children(i).Code
   Case "MATERIALBOMCODE":z0102.MaterialBOMCode = Children(i).Code
   Case "INCHARGEMATERIALBOM":z0102.InchargeMaterialBOM = Children(i).Code
   Case "PROCESSBOMCODE":z0102.ProcessBOMCode = Children(i).Code
   Case "INCHARGEPROCESSBOM":z0102.InchargeProcessBOM = Children(i).Code
   Case "JOBBOMCODE":z0102.JobBOMCode = Children(i).Code
   Case "INCHARGEJOBBOM":z0102.InchargeJobBOM = Children(i).Code
   Case "DEVELOPCODE":z0102.DevelopCode = Children(i).Code
   Case "STARTTIME":z0102.StartTime = Children(i).Code
   Case "FINISHTIME":z0102.FinishTime = Children(i).Code
   Case "INSERTDATE":z0102.InsertDate = Children(i).Code
   Case "INCHARGEINSERT":z0102.InchargeInsert = Children(i).Code
   Case "UPDATEDATE":z0102.UpdateDate = Children(i).Code
   Case "INCHARGEUPDATE":z0102.InchargeUpdate = Children(i).Code
   Case "ATTCHID":z0102.AttchID = Children(i).Code
   Case "CHECKUSE":z0102.CheckUse = Children(i).Code
   Case "CHECKCOMPLETE":z0102.CheckComplete = Children(i).Code
   Case "MATERIALAMT":z0102.MaterialAMT = Children(i).Code
   Case "PROCESSAMT":z0102.ProcessAMT = Children(i).Code
   Case "ADDITIONALAMT":z0102.AdditionalAMT = Children(i).Code
   Case "EXPENSEAMT":z0102.ExpenseAMT = Children(i).Code
   Case "SALESAMT":z0102.SalesAMT = Children(i).Code
   Case "TOTALAMT":z0102.TotalAMT = Children(i).Code
   Case "PERPROFIT":z0102.PerProfit = Children(i).Code
   Case "TOTALCOST":z0102.TotalCost = Children(i).Code
   Case "SALESPRICE":z0102.SalesPrice = Children(i).Code
   Case "SALESPROFIT":z0102.SalesProfit = Children(i).Code
   Case "MATERIALSTATUS":z0102.MaterialStatus = Children(i).Code
   Case "SOLESTATUS":z0102.SoleStatus = Children(i).Code
   Case "DATEPATTERN":z0102.DatePattern = Children(i).Code
   Case "DATEMATERIAL":z0102.DateMaterial = Children(i).Code
   Case "DATEPLANNING":z0102.DatePlanning = Children(i).Code
   Case "DATESOLE":z0102.DateSole = Children(i).Code
   Case "DATERND":z0102.DateRnD = Children(i).Code
   Case "DATEFITTING":z0102.DateFitting = Children(i).Code
   Case "DATECUTTING":z0102.DateCutting = Children(i).Code
   Case "DATESTITCHING":z0102.DateStitching = Children(i).Code
   Case "DATESTOCKFIT":z0102.DateStockfit = Children(i).Code
   Case "DATEASSEMBLY":z0102.DateAssembly = Children(i).Code
   Case "DATESHIPPING":z0102.DateShipping = Children(i).Code
   Case "QTYORDER":z0102.QtyOrder = Children(i).Code
   Case "QTYBOOKING":z0102.QtyBooking = Children(i).Code
   Case "QTYJOB":z0102.QtyJob = Children(i).Code
   Case "QTYSOLE":z0102.QtySole = Children(i).Code
   Case "QTYCUTTING":z0102.QtyCutting = Children(i).Code
   Case "QTYSTITCHING":z0102.QtyStitching = Children(i).Code
   Case "QTYSTOCKFIT":z0102.QtyStockfit = Children(i).Code
   Case "QTYASSEMBLY":z0102.QtyAssembly = Children(i).Code
   Case "QTYSHIPPING":z0102.QtyShipping = Children(i).Code
   Case "REMARKORDER":z0102.RemarkOrder = Children(i).Code
   Case "REMARKCUSTOMER":z0102.RemarkCustomer = Children(i).Code
   Case "REMARK":z0102.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "SPECNO":z0102.SpecNo = Children(i).Data
   Case "SPECNOSEQ":z0102.SpecNoSeq = Children(i).Data
   Case "DATECONFIRM":z0102.DateConfirm = Children(i).Data
   Case "SPECNOREF":z0102.SpecNoRef = Children(i).Data
   Case "SPECSEQREF":z0102.SpecSeqRef = Children(i).Data
   Case "SPECNOBE":z0102.SpecNoBe = Children(i).Data
   Case "SPECSEQBE":z0102.SpecSeqBe = Children(i).Data
   Case "SPECITICSIZE":z0102.SpeciticSize = Children(i).Data
   Case "ORDERRNDSTATUS":z0102.OrderRnDStatus = Children(i).Data
   Case "DATEACCEPT":z0102.DateAccept = Children(i).Data
   Case "DATEAPPROVAL":z0102.DateApproval = Children(i).Data
   Case "DATECOMPLETE":z0102.DateComplete = Children(i).Data
   Case "DATEPENDING":z0102.DatePending = Children(i).Data
   Case "DATECANCEL":z0102.DateCancel = Children(i).Data
   Case "INCHARGEACCEPT":z0102.InchargeAccept = Children(i).Data
   Case "MATERIALBOMCODE":z0102.MaterialBOMCode = Children(i).Data
   Case "INCHARGEMATERIALBOM":z0102.InchargeMaterialBOM = Children(i).Data
   Case "PROCESSBOMCODE":z0102.ProcessBOMCode = Children(i).Data
   Case "INCHARGEPROCESSBOM":z0102.InchargeProcessBOM = Children(i).Data
   Case "JOBBOMCODE":z0102.JobBOMCode = Children(i).Data
   Case "INCHARGEJOBBOM":z0102.InchargeJobBOM = Children(i).Data
   Case "DEVELOPCODE":z0102.DevelopCode = Children(i).Data
   Case "STARTTIME":z0102.StartTime = Children(i).Data
   Case "FINISHTIME":z0102.FinishTime = Children(i).Data
   Case "INSERTDATE":z0102.InsertDate = Children(i).Data
   Case "INCHARGEINSERT":z0102.InchargeInsert = Children(i).Data
   Case "UPDATEDATE":z0102.UpdateDate = Children(i).Data
   Case "INCHARGEUPDATE":z0102.InchargeUpdate = Children(i).Data
   Case "ATTCHID":z0102.AttchID = Children(i).Data
   Case "CHECKUSE":z0102.CheckUse = Children(i).Data
   Case "CHECKCOMPLETE":z0102.CheckComplete = Children(i).Data
   Case "MATERIALAMT":z0102.MaterialAMT = Children(i).Data
   Case "PROCESSAMT":z0102.ProcessAMT = Children(i).Data
   Case "ADDITIONALAMT":z0102.AdditionalAMT = Children(i).Data
   Case "EXPENSEAMT":z0102.ExpenseAMT = Children(i).Data
   Case "SALESAMT":z0102.SalesAMT = Children(i).Data
   Case "TOTALAMT":z0102.TotalAMT = Children(i).Data
   Case "PERPROFIT":z0102.PerProfit = Children(i).Data
   Case "TOTALCOST":z0102.TotalCost = Children(i).Data
   Case "SALESPRICE":z0102.SalesPrice = Children(i).Data
   Case "SALESPROFIT":z0102.SalesProfit = Children(i).Data
   Case "MATERIALSTATUS":z0102.MaterialStatus = Children(i).Data
   Case "SOLESTATUS":z0102.SoleStatus = Children(i).Data
   Case "DATEPATTERN":z0102.DatePattern = Children(i).Data
   Case "DATEMATERIAL":z0102.DateMaterial = Children(i).Data
   Case "DATEPLANNING":z0102.DatePlanning = Children(i).Data
   Case "DATESOLE":z0102.DateSole = Children(i).Data
   Case "DATERND":z0102.DateRnD = Children(i).Data
   Case "DATEFITTING":z0102.DateFitting = Children(i).Data
   Case "DATECUTTING":z0102.DateCutting = Children(i).Data
   Case "DATESTITCHING":z0102.DateStitching = Children(i).Data
   Case "DATESTOCKFIT":z0102.DateStockfit = Children(i).Data
   Case "DATEASSEMBLY":z0102.DateAssembly = Children(i).Data
   Case "DATESHIPPING":z0102.DateShipping = Children(i).Data
   Case "QTYORDER":z0102.QtyOrder = Children(i).Data
   Case "QTYBOOKING":z0102.QtyBooking = Children(i).Data
   Case "QTYJOB":z0102.QtyJob = Children(i).Data
   Case "QTYSOLE":z0102.QtySole = Children(i).Data
   Case "QTYCUTTING":z0102.QtyCutting = Children(i).Data
   Case "QTYSTITCHING":z0102.QtyStitching = Children(i).Data
   Case "QTYSTOCKFIT":z0102.QtyStockfit = Children(i).Data
   Case "QTYASSEMBLY":z0102.QtyAssembly = Children(i).Data
   Case "QTYSHIPPING":z0102.QtyShipping = Children(i).Data
   Case "REMARKORDER":z0102.RemarkOrder = Children(i).Data
   Case "REMARKCUSTOMER":z0102.RemarkCustomer = Children(i).Data
   Case "REMARK":z0102.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K0102_MOVE",vbCritical)
End Try
End Function 
    
End Module 
