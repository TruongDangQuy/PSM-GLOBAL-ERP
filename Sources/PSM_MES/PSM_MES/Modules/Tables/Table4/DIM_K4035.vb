'=========================================================================================================================================================
'   TABLE : (PFK4035)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K4035

Structure T4035_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	WorkOrder	 AS String	'			char(9)		*
Public 	WorkOrderSeq	 AS String	'			char(3)		*
Public 	OverCostSeq	 AS Double	'			decimal		*
Public 	Status	 AS String	'			char(1)
Public 	seOverheadCost	 AS String	'			char(3)
Public 	cdOverheadCost	 AS String	'			char(3)
Public 	Description	 AS String	'			nvarchar(500)
Public 	PriceOutsole	 AS Double	'			decimal
Public 	PriceCutting	 AS Double	'			decimal
Public 	PriceStitching	 AS Double	'			decimal
Public 	PriceStockfit	 AS Double	'			decimal
Public 	PriceAssembly	 AS Double	'			decimal
Public 	PriceSubProcess	 AS Double	'			decimal
Public 	PriceOutsource	 AS Double	'			decimal
Public 	ExpenseAMT	 AS Double	'			decimal
Public 	TotalQty	 AS Double	'			decimal
Public 	TotalExpenseAMT	 AS Double	'			decimal
Public 	InsertDate	 AS String	'			char(8)
Public 	InchargeInsert	 AS String	'			char(6)
Public 	UpdateDate	 AS String	'			char(8)
Public 	InchargeUpdate	 AS String	'			char(6)
Public 	AttachID	 AS String	'			char(6)
Public 	RemarkOrder	 AS String	'			nvarchar(500)
Public 	RemarkCustomer	 AS String	'			nvarchar(500)
Public 	Remark	 AS String	'			nvarchar(500)
'=========================================================================================================================================================
End structure

Public D4035 As T4035_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK4035(WORKORDER AS String, WORKORDERSEQ AS String, OVERCOSTSEQ AS Double) As Boolean
    READ_PFK4035 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK4035 "
    SQL = SQL & " WHERE K4035_WorkOrder		 = '" & WorkOrder & "' " 
    SQL = SQL & "   AND K4035_WorkOrderSeq		 = '" & WorkOrderSeq & "' " 
    SQL = SQL & "   AND K4035_OverCostSeq		 =  " & OverCostSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D4035_CLEAR: GoTo SKIP_READ_PFK4035
                
    Call K4035_MOVE(rd)
    READ_PFK4035 = True

SKIP_READ_PFK4035:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK4035",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK4035(WORKORDER AS String, WORKORDERSEQ AS String, OVERCOSTSEQ AS Double, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK4035 "
    SQL = SQL & " WHERE K4035_WorkOrder		 = '" & WorkOrder & "' " 
    SQL = SQL & "   AND K4035_WorkOrderSeq		 = '" & WorkOrderSeq & "' " 
    SQL = SQL & "   AND K4035_OverCostSeq		 =  " & OverCostSeq & "  " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK4035",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK4035(z4035 As T4035_AREA) As Boolean
    WRITE_PFK4035 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z4035)
 
    SQL = " INSERT INTO PFK4035 "
    SQL = SQL & " ( "
    SQL = SQL & " K4035_WorkOrder," 
    SQL = SQL & " K4035_WorkOrderSeq," 
    SQL = SQL & " K4035_OverCostSeq," 
    SQL = SQL & " K4035_Status," 
    SQL = SQL & " K4035_seOverheadCost," 
    SQL = SQL & " K4035_cdOverheadCost," 
    SQL = SQL & " K4035_Description," 
    SQL = SQL & " K4035_PriceOutsole," 
    SQL = SQL & " K4035_PriceCutting," 
    SQL = SQL & " K4035_PriceStitching," 
    SQL = SQL & " K4035_PriceStockfit," 
    SQL = SQL & " K4035_PriceAssembly," 
    SQL = SQL & " K4035_PriceSubProcess," 
    SQL = SQL & " K4035_PriceOutsource," 
    SQL = SQL & " K4035_ExpenseAMT," 
    SQL = SQL & " K4035_TotalQty," 
    SQL = SQL & " K4035_TotalExpenseAMT," 
    SQL = SQL & " K4035_InsertDate," 
    SQL = SQL & " K4035_InchargeInsert," 
    SQL = SQL & " K4035_UpdateDate," 
    SQL = SQL & " K4035_InchargeUpdate," 
    SQL = SQL & " K4035_AttachID," 
    SQL = SQL & " K4035_RemarkOrder," 
    SQL = SQL & " K4035_RemarkCustomer," 
    SQL = SQL & " K4035_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z4035.WorkOrder) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4035.WorkOrderSeq) & "', "  
    SQL = SQL & "   " & FormatSQL(z4035.OverCostSeq) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z4035.Status) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4035.seOverheadCost) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4035.cdOverheadCost) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4035.Description) & "', "  
    SQL = SQL & "   " & FormatSQL(z4035.PriceOutsole) & ", "  
    SQL = SQL & "   " & FormatSQL(z4035.PriceCutting) & ", "  
    SQL = SQL & "   " & FormatSQL(z4035.PriceStitching) & ", "  
    SQL = SQL & "   " & FormatSQL(z4035.PriceStockfit) & ", "  
    SQL = SQL & "   " & FormatSQL(z4035.PriceAssembly) & ", "  
    SQL = SQL & "   " & FormatSQL(z4035.PriceSubProcess) & ", "  
    SQL = SQL & "   " & FormatSQL(z4035.PriceOutsource) & ", "  
    SQL = SQL & "   " & FormatSQL(z4035.ExpenseAMT) & ", "  
    SQL = SQL & "   " & FormatSQL(z4035.TotalQty) & ", "  
    SQL = SQL & "   " & FormatSQL(z4035.TotalExpenseAMT) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z4035.InsertDate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4035.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4035.UpdateDate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4035.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4035.AttachID) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4035.RemarkOrder) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4035.RemarkCustomer) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4035.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK4035 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK4035",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK4035(z4035 As T4035_AREA) As Boolean
    REWRITE_PFK4035 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z4035)
   
    SQL = " UPDATE PFK4035 SET "
    SQL = SQL & "    K4035_Status      = N'" & FormatSQL(z4035.Status) & "', " 
    SQL = SQL & "    K4035_seOverheadCost      = N'" & FormatSQL(z4035.seOverheadCost) & "', " 
    SQL = SQL & "    K4035_cdOverheadCost      = N'" & FormatSQL(z4035.cdOverheadCost) & "', " 
    SQL = SQL & "    K4035_Description      = N'" & FormatSQL(z4035.Description) & "', " 
    SQL = SQL & "    K4035_PriceOutsole      =  " & FormatSQL(z4035.PriceOutsole) & ", " 
    SQL = SQL & "    K4035_PriceCutting      =  " & FormatSQL(z4035.PriceCutting) & ", " 
    SQL = SQL & "    K4035_PriceStitching      =  " & FormatSQL(z4035.PriceStitching) & ", " 
    SQL = SQL & "    K4035_PriceStockfit      =  " & FormatSQL(z4035.PriceStockfit) & ", " 
    SQL = SQL & "    K4035_PriceAssembly      =  " & FormatSQL(z4035.PriceAssembly) & ", " 
    SQL = SQL & "    K4035_PriceSubProcess      =  " & FormatSQL(z4035.PriceSubProcess) & ", " 
    SQL = SQL & "    K4035_PriceOutsource      =  " & FormatSQL(z4035.PriceOutsource) & ", " 
    SQL = SQL & "    K4035_ExpenseAMT      =  " & FormatSQL(z4035.ExpenseAMT) & ", " 
    SQL = SQL & "    K4035_TotalQty      =  " & FormatSQL(z4035.TotalQty) & ", " 
    SQL = SQL & "    K4035_TotalExpenseAMT      =  " & FormatSQL(z4035.TotalExpenseAMT) & ", " 
    SQL = SQL & "    K4035_InsertDate      = N'" & FormatSQL(z4035.InsertDate) & "', " 
    SQL = SQL & "    K4035_InchargeInsert      = N'" & FormatSQL(z4035.InchargeInsert) & "', " 
    SQL = SQL & "    K4035_UpdateDate      = N'" & FormatSQL(z4035.UpdateDate) & "', " 
    SQL = SQL & "    K4035_InchargeUpdate      = N'" & FormatSQL(z4035.InchargeUpdate) & "', " 
    SQL = SQL & "    K4035_AttachID      = N'" & FormatSQL(z4035.AttachID) & "', " 
    SQL = SQL & "    K4035_RemarkOrder      = N'" & FormatSQL(z4035.RemarkOrder) & "', " 
    SQL = SQL & "    K4035_RemarkCustomer      = N'" & FormatSQL(z4035.RemarkCustomer) & "', " 
    SQL = SQL & "    K4035_Remark      = N'" & FormatSQL(z4035.Remark) & "'  " 
    SQL = SQL & " WHERE K4035_WorkOrder		 = '" & z4035.WorkOrder & "' " 
    SQL = SQL & "   AND K4035_WorkOrderSeq		 = '" & z4035.WorkOrderSeq & "' " 
    SQL = SQL & "   AND K4035_OverCostSeq		 =  " & z4035.OverCostSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK4035 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK4035",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK4035(z4035 As T4035_AREA) As Boolean
    DELETE_PFK4035 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK4035 "
    SQL = SQL & " WHERE K4035_WorkOrder		 = '" & z4035.WorkOrder & "' " 
    SQL = SQL & "   AND K4035_WorkOrderSeq		 = '" & z4035.WorkOrderSeq & "' " 
    SQL = SQL & "   AND K4035_OverCostSeq		 =  " & z4035.OverCostSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK4035 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK4035",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D4035_CLEAR()
Try
    
   D4035.WorkOrder = ""
   D4035.WorkOrderSeq = ""
    D4035.OverCostSeq = 0 
   D4035.Status = ""
   D4035.seOverheadCost = ""
   D4035.cdOverheadCost = ""
   D4035.Description = ""
    D4035.PriceOutsole = 0 
    D4035.PriceCutting = 0 
    D4035.PriceStitching = 0 
    D4035.PriceStockfit = 0 
    D4035.PriceAssembly = 0 
    D4035.PriceSubProcess = 0 
    D4035.PriceOutsource = 0 
    D4035.ExpenseAMT = 0 
    D4035.TotalQty = 0 
    D4035.TotalExpenseAMT = 0 
   D4035.InsertDate = ""
   D4035.InchargeInsert = ""
   D4035.UpdateDate = ""
   D4035.InchargeUpdate = ""
   D4035.AttachID = ""
   D4035.RemarkOrder = ""
   D4035.RemarkCustomer = ""
   D4035.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D4035_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x4035 As T4035_AREA)
Try
    
    x4035.WorkOrder = trim$(  x4035.WorkOrder)
    x4035.WorkOrderSeq = trim$(  x4035.WorkOrderSeq)
    x4035.OverCostSeq = trim$(  x4035.OverCostSeq)
    x4035.Status = trim$(  x4035.Status)
    x4035.seOverheadCost = trim$(  x4035.seOverheadCost)
    x4035.cdOverheadCost = trim$(  x4035.cdOverheadCost)
    x4035.Description = trim$(  x4035.Description)
    x4035.PriceOutsole = trim$(  x4035.PriceOutsole)
    x4035.PriceCutting = trim$(  x4035.PriceCutting)
    x4035.PriceStitching = trim$(  x4035.PriceStitching)
    x4035.PriceStockfit = trim$(  x4035.PriceStockfit)
    x4035.PriceAssembly = trim$(  x4035.PriceAssembly)
    x4035.PriceSubProcess = trim$(  x4035.PriceSubProcess)
    x4035.PriceOutsource = trim$(  x4035.PriceOutsource)
    x4035.ExpenseAMT = trim$(  x4035.ExpenseAMT)
    x4035.TotalQty = trim$(  x4035.TotalQty)
    x4035.TotalExpenseAMT = trim$(  x4035.TotalExpenseAMT)
    x4035.InsertDate = trim$(  x4035.InsertDate)
    x4035.InchargeInsert = trim$(  x4035.InchargeInsert)
    x4035.UpdateDate = trim$(  x4035.UpdateDate)
    x4035.InchargeUpdate = trim$(  x4035.InchargeUpdate)
    x4035.AttachID = trim$(  x4035.AttachID)
    x4035.RemarkOrder = trim$(  x4035.RemarkOrder)
    x4035.RemarkCustomer = trim$(  x4035.RemarkCustomer)
    x4035.Remark = trim$(  x4035.Remark)
     
    If trim$( x4035.WorkOrder ) = "" Then x4035.WorkOrder = Space(1) 
    If trim$( x4035.WorkOrderSeq ) = "" Then x4035.WorkOrderSeq = Space(1) 
    If trim$( x4035.OverCostSeq ) = "" Then x4035.OverCostSeq = 0 
    If trim$( x4035.Status ) = "" Then x4035.Status = Space(1) 
    If trim$( x4035.seOverheadCost ) = "" Then x4035.seOverheadCost = Space(1) 
    If trim$( x4035.cdOverheadCost ) = "" Then x4035.cdOverheadCost = Space(1) 
    If trim$( x4035.Description ) = "" Then x4035.Description = Space(1) 
    If trim$( x4035.PriceOutsole ) = "" Then x4035.PriceOutsole = 0 
    If trim$( x4035.PriceCutting ) = "" Then x4035.PriceCutting = 0 
    If trim$( x4035.PriceStitching ) = "" Then x4035.PriceStitching = 0 
    If trim$( x4035.PriceStockfit ) = "" Then x4035.PriceStockfit = 0 
    If trim$( x4035.PriceAssembly ) = "" Then x4035.PriceAssembly = 0 
    If trim$( x4035.PriceSubProcess ) = "" Then x4035.PriceSubProcess = 0 
    If trim$( x4035.PriceOutsource ) = "" Then x4035.PriceOutsource = 0 
    If trim$( x4035.ExpenseAMT ) = "" Then x4035.ExpenseAMT = 0 
    If trim$( x4035.TotalQty ) = "" Then x4035.TotalQty = 0 
    If trim$( x4035.TotalExpenseAMT ) = "" Then x4035.TotalExpenseAMT = 0 
    If trim$( x4035.InsertDate ) = "" Then x4035.InsertDate = Space(1) 
    If trim$( x4035.InchargeInsert ) = "" Then x4035.InchargeInsert = Space(1) 
    If trim$( x4035.UpdateDate ) = "" Then x4035.UpdateDate = Space(1) 
    If trim$( x4035.InchargeUpdate ) = "" Then x4035.InchargeUpdate = Space(1) 
    If trim$( x4035.AttachID ) = "" Then x4035.AttachID = Space(1) 
    If trim$( x4035.RemarkOrder ) = "" Then x4035.RemarkOrder = Space(1) 
    If trim$( x4035.RemarkCustomer ) = "" Then x4035.RemarkCustomer = Space(1) 
    If trim$( x4035.Remark ) = "" Then x4035.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K4035_MOVE(rs4035 As SqlClient.SqlDataReader)
Try

    call D4035_CLEAR()   

    If IsdbNull(rs4035!K4035_WorkOrder) = False Then D4035.WorkOrder = Trim$(rs4035!K4035_WorkOrder)
    If IsdbNull(rs4035!K4035_WorkOrderSeq) = False Then D4035.WorkOrderSeq = Trim$(rs4035!K4035_WorkOrderSeq)
    If IsdbNull(rs4035!K4035_OverCostSeq) = False Then D4035.OverCostSeq = Trim$(rs4035!K4035_OverCostSeq)
    If IsdbNull(rs4035!K4035_Status) = False Then D4035.Status = Trim$(rs4035!K4035_Status)
    If IsdbNull(rs4035!K4035_seOverheadCost) = False Then D4035.seOverheadCost = Trim$(rs4035!K4035_seOverheadCost)
    If IsdbNull(rs4035!K4035_cdOverheadCost) = False Then D4035.cdOverheadCost = Trim$(rs4035!K4035_cdOverheadCost)
    If IsdbNull(rs4035!K4035_Description) = False Then D4035.Description = Trim$(rs4035!K4035_Description)
    If IsdbNull(rs4035!K4035_PriceOutsole) = False Then D4035.PriceOutsole = Trim$(rs4035!K4035_PriceOutsole)
    If IsdbNull(rs4035!K4035_PriceCutting) = False Then D4035.PriceCutting = Trim$(rs4035!K4035_PriceCutting)
    If IsdbNull(rs4035!K4035_PriceStitching) = False Then D4035.PriceStitching = Trim$(rs4035!K4035_PriceStitching)
    If IsdbNull(rs4035!K4035_PriceStockfit) = False Then D4035.PriceStockfit = Trim$(rs4035!K4035_PriceStockfit)
    If IsdbNull(rs4035!K4035_PriceAssembly) = False Then D4035.PriceAssembly = Trim$(rs4035!K4035_PriceAssembly)
    If IsdbNull(rs4035!K4035_PriceSubProcess) = False Then D4035.PriceSubProcess = Trim$(rs4035!K4035_PriceSubProcess)
    If IsdbNull(rs4035!K4035_PriceOutsource) = False Then D4035.PriceOutsource = Trim$(rs4035!K4035_PriceOutsource)
    If IsdbNull(rs4035!K4035_ExpenseAMT) = False Then D4035.ExpenseAMT = Trim$(rs4035!K4035_ExpenseAMT)
    If IsdbNull(rs4035!K4035_TotalQty) = False Then D4035.TotalQty = Trim$(rs4035!K4035_TotalQty)
    If IsdbNull(rs4035!K4035_TotalExpenseAMT) = False Then D4035.TotalExpenseAMT = Trim$(rs4035!K4035_TotalExpenseAMT)
    If IsdbNull(rs4035!K4035_InsertDate) = False Then D4035.InsertDate = Trim$(rs4035!K4035_InsertDate)
    If IsdbNull(rs4035!K4035_InchargeInsert) = False Then D4035.InchargeInsert = Trim$(rs4035!K4035_InchargeInsert)
    If IsdbNull(rs4035!K4035_UpdateDate) = False Then D4035.UpdateDate = Trim$(rs4035!K4035_UpdateDate)
    If IsdbNull(rs4035!K4035_InchargeUpdate) = False Then D4035.InchargeUpdate = Trim$(rs4035!K4035_InchargeUpdate)
    If IsdbNull(rs4035!K4035_AttachID) = False Then D4035.AttachID = Trim$(rs4035!K4035_AttachID)
    If IsdbNull(rs4035!K4035_RemarkOrder) = False Then D4035.RemarkOrder = Trim$(rs4035!K4035_RemarkOrder)
    If IsdbNull(rs4035!K4035_RemarkCustomer) = False Then D4035.RemarkCustomer = Trim$(rs4035!K4035_RemarkCustomer)
    If IsdbNull(rs4035!K4035_Remark) = False Then D4035.Remark = Trim$(rs4035!K4035_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K4035_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K4035_MOVE(rs4035 As DataRow)
Try

    call D4035_CLEAR()   

    If IsdbNull(rs4035!K4035_WorkOrder) = False Then D4035.WorkOrder = Trim$(rs4035!K4035_WorkOrder)
    If IsdbNull(rs4035!K4035_WorkOrderSeq) = False Then D4035.WorkOrderSeq = Trim$(rs4035!K4035_WorkOrderSeq)
    If IsdbNull(rs4035!K4035_OverCostSeq) = False Then D4035.OverCostSeq = Trim$(rs4035!K4035_OverCostSeq)
    If IsdbNull(rs4035!K4035_Status) = False Then D4035.Status = Trim$(rs4035!K4035_Status)
    If IsdbNull(rs4035!K4035_seOverheadCost) = False Then D4035.seOverheadCost = Trim$(rs4035!K4035_seOverheadCost)
    If IsdbNull(rs4035!K4035_cdOverheadCost) = False Then D4035.cdOverheadCost = Trim$(rs4035!K4035_cdOverheadCost)
    If IsdbNull(rs4035!K4035_Description) = False Then D4035.Description = Trim$(rs4035!K4035_Description)
    If IsdbNull(rs4035!K4035_PriceOutsole) = False Then D4035.PriceOutsole = Trim$(rs4035!K4035_PriceOutsole)
    If IsdbNull(rs4035!K4035_PriceCutting) = False Then D4035.PriceCutting = Trim$(rs4035!K4035_PriceCutting)
    If IsdbNull(rs4035!K4035_PriceStitching) = False Then D4035.PriceStitching = Trim$(rs4035!K4035_PriceStitching)
    If IsdbNull(rs4035!K4035_PriceStockfit) = False Then D4035.PriceStockfit = Trim$(rs4035!K4035_PriceStockfit)
    If IsdbNull(rs4035!K4035_PriceAssembly) = False Then D4035.PriceAssembly = Trim$(rs4035!K4035_PriceAssembly)
    If IsdbNull(rs4035!K4035_PriceSubProcess) = False Then D4035.PriceSubProcess = Trim$(rs4035!K4035_PriceSubProcess)
    If IsdbNull(rs4035!K4035_PriceOutsource) = False Then D4035.PriceOutsource = Trim$(rs4035!K4035_PriceOutsource)
    If IsdbNull(rs4035!K4035_ExpenseAMT) = False Then D4035.ExpenseAMT = Trim$(rs4035!K4035_ExpenseAMT)
    If IsdbNull(rs4035!K4035_TotalQty) = False Then D4035.TotalQty = Trim$(rs4035!K4035_TotalQty)
    If IsdbNull(rs4035!K4035_TotalExpenseAMT) = False Then D4035.TotalExpenseAMT = Trim$(rs4035!K4035_TotalExpenseAMT)
    If IsdbNull(rs4035!K4035_InsertDate) = False Then D4035.InsertDate = Trim$(rs4035!K4035_InsertDate)
    If IsdbNull(rs4035!K4035_InchargeInsert) = False Then D4035.InchargeInsert = Trim$(rs4035!K4035_InchargeInsert)
    If IsdbNull(rs4035!K4035_UpdateDate) = False Then D4035.UpdateDate = Trim$(rs4035!K4035_UpdateDate)
    If IsdbNull(rs4035!K4035_InchargeUpdate) = False Then D4035.InchargeUpdate = Trim$(rs4035!K4035_InchargeUpdate)
    If IsdbNull(rs4035!K4035_AttachID) = False Then D4035.AttachID = Trim$(rs4035!K4035_AttachID)
    If IsdbNull(rs4035!K4035_RemarkOrder) = False Then D4035.RemarkOrder = Trim$(rs4035!K4035_RemarkOrder)
    If IsdbNull(rs4035!K4035_RemarkCustomer) = False Then D4035.RemarkCustomer = Trim$(rs4035!K4035_RemarkCustomer)
    If IsdbNull(rs4035!K4035_Remark) = False Then D4035.Remark = Trim$(rs4035!K4035_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K4035_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K4035_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z4035 As T4035_AREA, WORKORDER AS String, WORKORDERSEQ AS String, OVERCOSTSEQ AS Double) as Boolean

K4035_MOVE = False

Try
    If READ_PFK4035(WORKORDER, WORKORDERSEQ, OVERCOSTSEQ) = True Then
                z4035 = D4035
		K4035_MOVE = True
		else
	z4035 = nothing
     End If

     If  getColumIndex(spr,"WorkOrder") > -1 then z4035.WorkOrder = getDataM(spr, getColumIndex(spr,"WorkOrder"), xRow)
     If  getColumIndex(spr,"WorkOrderSeq") > -1 then z4035.WorkOrderSeq = getDataM(spr, getColumIndex(spr,"WorkOrderSeq"), xRow)
     If  getColumIndex(spr,"OverCostSeq") > -1 then z4035.OverCostSeq = getDataM(spr, getColumIndex(spr,"OverCostSeq"), xRow)
     If  getColumIndex(spr,"Status") > -1 then z4035.Status = getDataM(spr, getColumIndex(spr,"Status"), xRow)
     If  getColumIndex(spr,"seOverheadCost") > -1 then z4035.seOverheadCost = getDataM(spr, getColumIndex(spr,"seOverheadCost"), xRow)
     If  getColumIndex(spr,"cdOverheadCost") > -1 then z4035.cdOverheadCost = getDataM(spr, getColumIndex(spr,"cdOverheadCost"), xRow)
     If  getColumIndex(spr,"Description") > -1 then z4035.Description = getDataM(spr, getColumIndex(spr,"Description"), xRow)
     If  getColumIndex(spr,"PriceOutsole") > -1 then z4035.PriceOutsole = getDataM(spr, getColumIndex(spr,"PriceOutsole"), xRow)
     If  getColumIndex(spr,"PriceCutting") > -1 then z4035.PriceCutting = getDataM(spr, getColumIndex(spr,"PriceCutting"), xRow)
     If  getColumIndex(spr,"PriceStitching") > -1 then z4035.PriceStitching = getDataM(spr, getColumIndex(spr,"PriceStitching"), xRow)
     If  getColumIndex(spr,"PriceStockfit") > -1 then z4035.PriceStockfit = getDataM(spr, getColumIndex(spr,"PriceStockfit"), xRow)
     If  getColumIndex(spr,"PriceAssembly") > -1 then z4035.PriceAssembly = getDataM(spr, getColumIndex(spr,"PriceAssembly"), xRow)
     If  getColumIndex(spr,"PriceSubProcess") > -1 then z4035.PriceSubProcess = getDataM(spr, getColumIndex(spr,"PriceSubProcess"), xRow)
     If  getColumIndex(spr,"PriceOutsource") > -1 then z4035.PriceOutsource = getDataM(spr, getColumIndex(spr,"PriceOutsource"), xRow)
     If  getColumIndex(spr,"ExpenseAMT") > -1 then z4035.ExpenseAMT = getDataM(spr, getColumIndex(spr,"ExpenseAMT"), xRow)
     If  getColumIndex(spr,"TotalQty") > -1 then z4035.TotalQty = getDataM(spr, getColumIndex(spr,"TotalQty"), xRow)
     If  getColumIndex(spr,"TotalExpenseAMT") > -1 then z4035.TotalExpenseAMT = getDataM(spr, getColumIndex(spr,"TotalExpenseAMT"), xRow)
     If  getColumIndex(spr,"InsertDate") > -1 then z4035.InsertDate = getDataM(spr, getColumIndex(spr,"InsertDate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z4035.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"UpdateDate") > -1 then z4035.UpdateDate = getDataM(spr, getColumIndex(spr,"UpdateDate"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z4035.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"AttachID") > -1 then z4035.AttachID = getDataM(spr, getColumIndex(spr,"AttachID"), xRow)
     If  getColumIndex(spr,"RemarkOrder") > -1 then z4035.RemarkOrder = getDataM(spr, getColumIndex(spr,"RemarkOrder"), xRow)
     If  getColumIndex(spr,"RemarkCustomer") > -1 then z4035.RemarkCustomer = getDataM(spr, getColumIndex(spr,"RemarkCustomer"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z4035.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K4035_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K4035_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z4035 As T4035_AREA,CheckClear as Boolean,WORKORDER AS String, WORKORDERSEQ AS String, OVERCOSTSEQ AS Double) as Boolean

K4035_MOVE = False

Try
    If READ_PFK4035(WORKORDER, WORKORDERSEQ, OVERCOSTSEQ) = True Then
                z4035 = D4035
		K4035_MOVE = True
		else
	If CheckClear  = True then z4035 = nothing
     End If

     If  getColumIndex(spr,"WorkOrder") > -1 then z4035.WorkOrder = getDataM(spr, getColumIndex(spr,"WorkOrder"), xRow)
     If  getColumIndex(spr,"WorkOrderSeq") > -1 then z4035.WorkOrderSeq = getDataM(spr, getColumIndex(spr,"WorkOrderSeq"), xRow)
     If  getColumIndex(spr,"OverCostSeq") > -1 then z4035.OverCostSeq = getDataM(spr, getColumIndex(spr,"OverCostSeq"), xRow)
     If  getColumIndex(spr,"Status") > -1 then z4035.Status = getDataM(spr, getColumIndex(spr,"Status"), xRow)
     If  getColumIndex(spr,"seOverheadCost") > -1 then z4035.seOverheadCost = getDataM(spr, getColumIndex(spr,"seOverheadCost"), xRow)
     If  getColumIndex(spr,"cdOverheadCost") > -1 then z4035.cdOverheadCost = getDataM(spr, getColumIndex(spr,"cdOverheadCost"), xRow)
     If  getColumIndex(spr,"Description") > -1 then z4035.Description = getDataM(spr, getColumIndex(spr,"Description"), xRow)
     If  getColumIndex(spr,"PriceOutsole") > -1 then z4035.PriceOutsole = getDataM(spr, getColumIndex(spr,"PriceOutsole"), xRow)
     If  getColumIndex(spr,"PriceCutting") > -1 then z4035.PriceCutting = getDataM(spr, getColumIndex(spr,"PriceCutting"), xRow)
     If  getColumIndex(spr,"PriceStitching") > -1 then z4035.PriceStitching = getDataM(spr, getColumIndex(spr,"PriceStitching"), xRow)
     If  getColumIndex(spr,"PriceStockfit") > -1 then z4035.PriceStockfit = getDataM(spr, getColumIndex(spr,"PriceStockfit"), xRow)
     If  getColumIndex(spr,"PriceAssembly") > -1 then z4035.PriceAssembly = getDataM(spr, getColumIndex(spr,"PriceAssembly"), xRow)
     If  getColumIndex(spr,"PriceSubProcess") > -1 then z4035.PriceSubProcess = getDataM(spr, getColumIndex(spr,"PriceSubProcess"), xRow)
     If  getColumIndex(spr,"PriceOutsource") > -1 then z4035.PriceOutsource = getDataM(spr, getColumIndex(spr,"PriceOutsource"), xRow)
     If  getColumIndex(spr,"ExpenseAMT") > -1 then z4035.ExpenseAMT = getDataM(spr, getColumIndex(spr,"ExpenseAMT"), xRow)
     If  getColumIndex(spr,"TotalQty") > -1 then z4035.TotalQty = getDataM(spr, getColumIndex(spr,"TotalQty"), xRow)
     If  getColumIndex(spr,"TotalExpenseAMT") > -1 then z4035.TotalExpenseAMT = getDataM(spr, getColumIndex(spr,"TotalExpenseAMT"), xRow)
     If  getColumIndex(spr,"InsertDate") > -1 then z4035.InsertDate = getDataM(spr, getColumIndex(spr,"InsertDate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z4035.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"UpdateDate") > -1 then z4035.UpdateDate = getDataM(spr, getColumIndex(spr,"UpdateDate"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z4035.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"AttachID") > -1 then z4035.AttachID = getDataM(spr, getColumIndex(spr,"AttachID"), xRow)
     If  getColumIndex(spr,"RemarkOrder") > -1 then z4035.RemarkOrder = getDataM(spr, getColumIndex(spr,"RemarkOrder"), xRow)
     If  getColumIndex(spr,"RemarkCustomer") > -1 then z4035.RemarkCustomer = getDataM(spr, getColumIndex(spr,"RemarkCustomer"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z4035.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K4035_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K4035_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z4035 As T4035_AREA, Job as String, WORKORDER AS String, WORKORDERSEQ AS String, OVERCOSTSEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K4035_MOVE = False

Try
    If READ_PFK4035(WORKORDER, WORKORDERSEQ, OVERCOSTSEQ) = True Then
                z4035 = D4035
		K4035_MOVE = True
		else
	z4035 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4035")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "WORKORDER":z4035.WorkOrder = Children(i).Code
   Case "WORKORDERSEQ":z4035.WorkOrderSeq = Children(i).Code
   Case "OVERCOSTSEQ":z4035.OverCostSeq = Children(i).Code
   Case "STATUS":z4035.Status = Children(i).Code
   Case "SEOVERHEADCOST":z4035.seOverheadCost = Children(i).Code
   Case "CDOVERHEADCOST":z4035.cdOverheadCost = Children(i).Code
   Case "DESCRIPTION":z4035.Description = Children(i).Code
   Case "PRICEOUTSOLE":z4035.PriceOutsole = Children(i).Code
   Case "PRICECUTTING":z4035.PriceCutting = Children(i).Code
   Case "PRICESTITCHING":z4035.PriceStitching = Children(i).Code
   Case "PRICESTOCKFIT":z4035.PriceStockfit = Children(i).Code
   Case "PRICEASSEMBLY":z4035.PriceAssembly = Children(i).Code
   Case "PRICESUBPROCESS":z4035.PriceSubProcess = Children(i).Code
   Case "PRICEOUTSOURCE":z4035.PriceOutsource = Children(i).Code
   Case "EXPENSEAMT":z4035.ExpenseAMT = Children(i).Code
   Case "TOTALQTY":z4035.TotalQty = Children(i).Code
   Case "TOTALEXPENSEAMT":z4035.TotalExpenseAMT = Children(i).Code
   Case "INSERTDATE":z4035.InsertDate = Children(i).Code
   Case "INCHARGEINSERT":z4035.InchargeInsert = Children(i).Code
   Case "UPDATEDATE":z4035.UpdateDate = Children(i).Code
   Case "INCHARGEUPDATE":z4035.InchargeUpdate = Children(i).Code
   Case "ATTACHID":z4035.AttachID = Children(i).Code
   Case "REMARKORDER":z4035.RemarkOrder = Children(i).Code
   Case "REMARKCUSTOMER":z4035.RemarkCustomer = Children(i).Code
   Case "REMARK":z4035.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "WORKORDER":z4035.WorkOrder = Children(i).Data
   Case "WORKORDERSEQ":z4035.WorkOrderSeq = Children(i).Data
   Case "OVERCOSTSEQ":z4035.OverCostSeq = Children(i).Data
   Case "STATUS":z4035.Status = Children(i).Data
   Case "SEOVERHEADCOST":z4035.seOverheadCost = Children(i).Data
   Case "CDOVERHEADCOST":z4035.cdOverheadCost = Children(i).Data
   Case "DESCRIPTION":z4035.Description = Children(i).Data
   Case "PRICEOUTSOLE":z4035.PriceOutsole = Children(i).Data
   Case "PRICECUTTING":z4035.PriceCutting = Children(i).Data
   Case "PRICESTITCHING":z4035.PriceStitching = Children(i).Data
   Case "PRICESTOCKFIT":z4035.PriceStockfit = Children(i).Data
   Case "PRICEASSEMBLY":z4035.PriceAssembly = Children(i).Data
   Case "PRICESUBPROCESS":z4035.PriceSubProcess = Children(i).Data
   Case "PRICEOUTSOURCE":z4035.PriceOutsource = Children(i).Data
   Case "EXPENSEAMT":z4035.ExpenseAMT = Children(i).Data
   Case "TOTALQTY":z4035.TotalQty = Children(i).Data
   Case "TOTALEXPENSEAMT":z4035.TotalExpenseAMT = Children(i).Data
   Case "INSERTDATE":z4035.InsertDate = Children(i).Data
   Case "INCHARGEINSERT":z4035.InchargeInsert = Children(i).Data
   Case "UPDATEDATE":z4035.UpdateDate = Children(i).Data
   Case "INCHARGEUPDATE":z4035.InchargeUpdate = Children(i).Data
   Case "ATTACHID":z4035.AttachID = Children(i).Data
   Case "REMARKORDER":z4035.RemarkOrder = Children(i).Data
   Case "REMARKCUSTOMER":z4035.RemarkCustomer = Children(i).Data
   Case "REMARK":z4035.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K4035_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K4035_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z4035 As T4035_AREA, Job as String, CheckClear as Boolean, WORKORDER AS String, WORKORDERSEQ AS String, OVERCOSTSEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K4035_MOVE = False

Try
    If READ_PFK4035(WORKORDER, WORKORDERSEQ, OVERCOSTSEQ) = True Then
                z4035 = D4035
		K4035_MOVE = True
		else
	If CheckClear  = True then z4035 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4035")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "WORKORDER":z4035.WorkOrder = Children(i).Code
   Case "WORKORDERSEQ":z4035.WorkOrderSeq = Children(i).Code
   Case "OVERCOSTSEQ":z4035.OverCostSeq = Children(i).Code
   Case "STATUS":z4035.Status = Children(i).Code
   Case "SEOVERHEADCOST":z4035.seOverheadCost = Children(i).Code
   Case "CDOVERHEADCOST":z4035.cdOverheadCost = Children(i).Code
   Case "DESCRIPTION":z4035.Description = Children(i).Code
   Case "PRICEOUTSOLE":z4035.PriceOutsole = Children(i).Code
   Case "PRICECUTTING":z4035.PriceCutting = Children(i).Code
   Case "PRICESTITCHING":z4035.PriceStitching = Children(i).Code
   Case "PRICESTOCKFIT":z4035.PriceStockfit = Children(i).Code
   Case "PRICEASSEMBLY":z4035.PriceAssembly = Children(i).Code
   Case "PRICESUBPROCESS":z4035.PriceSubProcess = Children(i).Code
   Case "PRICEOUTSOURCE":z4035.PriceOutsource = Children(i).Code
   Case "EXPENSEAMT":z4035.ExpenseAMT = Children(i).Code
   Case "TOTALQTY":z4035.TotalQty = Children(i).Code
   Case "TOTALEXPENSEAMT":z4035.TotalExpenseAMT = Children(i).Code
   Case "INSERTDATE":z4035.InsertDate = Children(i).Code
   Case "INCHARGEINSERT":z4035.InchargeInsert = Children(i).Code
   Case "UPDATEDATE":z4035.UpdateDate = Children(i).Code
   Case "INCHARGEUPDATE":z4035.InchargeUpdate = Children(i).Code
   Case "ATTACHID":z4035.AttachID = Children(i).Code
   Case "REMARKORDER":z4035.RemarkOrder = Children(i).Code
   Case "REMARKCUSTOMER":z4035.RemarkCustomer = Children(i).Code
   Case "REMARK":z4035.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "WORKORDER":z4035.WorkOrder = Children(i).Data
   Case "WORKORDERSEQ":z4035.WorkOrderSeq = Children(i).Data
   Case "OVERCOSTSEQ":z4035.OverCostSeq = Children(i).Data
   Case "STATUS":z4035.Status = Children(i).Data
   Case "SEOVERHEADCOST":z4035.seOverheadCost = Children(i).Data
   Case "CDOVERHEADCOST":z4035.cdOverheadCost = Children(i).Data
   Case "DESCRIPTION":z4035.Description = Children(i).Data
   Case "PRICEOUTSOLE":z4035.PriceOutsole = Children(i).Data
   Case "PRICECUTTING":z4035.PriceCutting = Children(i).Data
   Case "PRICESTITCHING":z4035.PriceStitching = Children(i).Data
   Case "PRICESTOCKFIT":z4035.PriceStockfit = Children(i).Data
   Case "PRICEASSEMBLY":z4035.PriceAssembly = Children(i).Data
   Case "PRICESUBPROCESS":z4035.PriceSubProcess = Children(i).Data
   Case "PRICEOUTSOURCE":z4035.PriceOutsource = Children(i).Data
   Case "EXPENSEAMT":z4035.ExpenseAMT = Children(i).Data
   Case "TOTALQTY":z4035.TotalQty = Children(i).Data
   Case "TOTALEXPENSEAMT":z4035.TotalExpenseAMT = Children(i).Data
   Case "INSERTDATE":z4035.InsertDate = Children(i).Data
   Case "INCHARGEINSERT":z4035.InchargeInsert = Children(i).Data
   Case "UPDATEDATE":z4035.UpdateDate = Children(i).Data
   Case "INCHARGEUPDATE":z4035.InchargeUpdate = Children(i).Data
   Case "ATTACHID":z4035.AttachID = Children(i).Data
   Case "REMARKORDER":z4035.RemarkOrder = Children(i).Data
   Case "REMARKCUSTOMER":z4035.RemarkCustomer = Children(i).Data
   Case "REMARK":z4035.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K4035_MOVE",vbCritical)
End Try
End Function 
    
End Module 
