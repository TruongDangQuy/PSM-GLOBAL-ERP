'=========================================================================================================================================================
'   TABLE : (PFK4033)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K4033

Structure T4033_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	WorkOrder	 AS String	'			char(9)		*
Public 	WorkOrderSeq	 AS String	'			char(3)		*
Public 	AddCostSeq	 AS Double	'			decimal		*
Public 	Status	 AS String	'			char(1)
Public 	seAdditionalCost	 AS String	'			char(3)
Public 	cdAdditionalCost	 AS String	'			char(3)
Public 	seCostingType	 AS String	'			char(3)
Public 	cdCostingType	 AS String	'			char(3)
Public 	Price	 AS Double	'			decimal
Public 	TotalQty	 AS Double	'			decimal
Public 	TotalAMT	 AS Double	'			decimal
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

Public D4033 As T4033_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK4033(WORKORDER AS String, WORKORDERSEQ AS String, ADDCOSTSEQ AS Double) As Boolean
    READ_PFK4033 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK4033 "
    SQL = SQL & " WHERE K4033_WorkOrder		 = '" & WorkOrder & "' " 
    SQL = SQL & "   AND K4033_WorkOrderSeq		 = '" & WorkOrderSeq & "' " 
    SQL = SQL & "   AND K4033_AddCostSeq		 =  " & AddCostSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D4033_CLEAR: GoTo SKIP_READ_PFK4033
                
    Call K4033_MOVE(rd)
    READ_PFK4033 = True

SKIP_READ_PFK4033:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK4033",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK4033(WORKORDER AS String, WORKORDERSEQ AS String, ADDCOSTSEQ AS Double, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK4033 "
    SQL = SQL & " WHERE K4033_WorkOrder		 = '" & WorkOrder & "' " 
    SQL = SQL & "   AND K4033_WorkOrderSeq		 = '" & WorkOrderSeq & "' " 
    SQL = SQL & "   AND K4033_AddCostSeq		 =  " & AddCostSeq & "  " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK4033",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK4033(z4033 As T4033_AREA) As Boolean
    WRITE_PFK4033 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z4033)
 
    SQL = " INSERT INTO PFK4033 "
    SQL = SQL & " ( "
    SQL = SQL & " K4033_WorkOrder," 
    SQL = SQL & " K4033_WorkOrderSeq," 
    SQL = SQL & " K4033_AddCostSeq," 
    SQL = SQL & " K4033_Status," 
    SQL = SQL & " K4033_seAdditionalCost," 
    SQL = SQL & " K4033_cdAdditionalCost," 
    SQL = SQL & " K4033_seCostingType," 
    SQL = SQL & " K4033_cdCostingType," 
    SQL = SQL & " K4033_Price," 
    SQL = SQL & " K4033_TotalQty," 
    SQL = SQL & " K4033_TotalAMT," 
    SQL = SQL & " K4033_InsertDate," 
    SQL = SQL & " K4033_InchargeInsert," 
    SQL = SQL & " K4033_UpdateDate," 
    SQL = SQL & " K4033_InchargeUpdate," 
    SQL = SQL & " K4033_AttachID," 
    SQL = SQL & " K4033_RemarkOrder," 
    SQL = SQL & " K4033_RemarkCustomer," 
    SQL = SQL & " K4033_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z4033.WorkOrder) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4033.WorkOrderSeq) & "', "  
    SQL = SQL & "   " & FormatSQL(z4033.AddCostSeq) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z4033.Status) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4033.seAdditionalCost) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4033.cdAdditionalCost) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4033.seCostingType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4033.cdCostingType) & "', "  
    SQL = SQL & "   " & FormatSQL(z4033.Price) & ", "  
    SQL = SQL & "   " & FormatSQL(z4033.TotalQty) & ", "  
    SQL = SQL & "   " & FormatSQL(z4033.TotalAMT) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z4033.InsertDate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4033.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4033.UpdateDate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4033.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4033.AttachID) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4033.RemarkOrder) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4033.RemarkCustomer) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4033.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK4033 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK4033",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK4033(z4033 As T4033_AREA) As Boolean
    REWRITE_PFK4033 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z4033)
   
    SQL = " UPDATE PFK4033 SET "
    SQL = SQL & "    K4033_Status      = N'" & FormatSQL(z4033.Status) & "', " 
    SQL = SQL & "    K4033_seAdditionalCost      = N'" & FormatSQL(z4033.seAdditionalCost) & "', " 
    SQL = SQL & "    K4033_cdAdditionalCost      = N'" & FormatSQL(z4033.cdAdditionalCost) & "', " 
    SQL = SQL & "    K4033_seCostingType      = N'" & FormatSQL(z4033.seCostingType) & "', " 
    SQL = SQL & "    K4033_cdCostingType      = N'" & FormatSQL(z4033.cdCostingType) & "', " 
    SQL = SQL & "    K4033_Price      =  " & FormatSQL(z4033.Price) & ", " 
    SQL = SQL & "    K4033_TotalQty      =  " & FormatSQL(z4033.TotalQty) & ", " 
    SQL = SQL & "    K4033_TotalAMT      =  " & FormatSQL(z4033.TotalAMT) & ", " 
    SQL = SQL & "    K4033_InsertDate      = N'" & FormatSQL(z4033.InsertDate) & "', " 
    SQL = SQL & "    K4033_InchargeInsert      = N'" & FormatSQL(z4033.InchargeInsert) & "', " 
    SQL = SQL & "    K4033_UpdateDate      = N'" & FormatSQL(z4033.UpdateDate) & "', " 
    SQL = SQL & "    K4033_InchargeUpdate      = N'" & FormatSQL(z4033.InchargeUpdate) & "', " 
    SQL = SQL & "    K4033_AttachID      = N'" & FormatSQL(z4033.AttachID) & "', " 
    SQL = SQL & "    K4033_RemarkOrder      = N'" & FormatSQL(z4033.RemarkOrder) & "', " 
    SQL = SQL & "    K4033_RemarkCustomer      = N'" & FormatSQL(z4033.RemarkCustomer) & "', " 
    SQL = SQL & "    K4033_Remark      = N'" & FormatSQL(z4033.Remark) & "'  " 
    SQL = SQL & " WHERE K4033_WorkOrder		 = '" & z4033.WorkOrder & "' " 
    SQL = SQL & "   AND K4033_WorkOrderSeq		 = '" & z4033.WorkOrderSeq & "' " 
    SQL = SQL & "   AND K4033_AddCostSeq		 =  " & z4033.AddCostSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK4033 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK4033",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK4033(z4033 As T4033_AREA) As Boolean
    DELETE_PFK4033 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK4033 "
    SQL = SQL & " WHERE K4033_WorkOrder		 = '" & z4033.WorkOrder & "' " 
    SQL = SQL & "   AND K4033_WorkOrderSeq		 = '" & z4033.WorkOrderSeq & "' " 
    SQL = SQL & "   AND K4033_AddCostSeq		 =  " & z4033.AddCostSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK4033 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK4033",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D4033_CLEAR()
Try
    
   D4033.WorkOrder = ""
   D4033.WorkOrderSeq = ""
    D4033.AddCostSeq = 0 
   D4033.Status = ""
   D4033.seAdditionalCost = ""
   D4033.cdAdditionalCost = ""
   D4033.seCostingType = ""
   D4033.cdCostingType = ""
    D4033.Price = 0 
    D4033.TotalQty = 0 
    D4033.TotalAMT = 0 
   D4033.InsertDate = ""
   D4033.InchargeInsert = ""
   D4033.UpdateDate = ""
   D4033.InchargeUpdate = ""
   D4033.AttachID = ""
   D4033.RemarkOrder = ""
   D4033.RemarkCustomer = ""
   D4033.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D4033_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x4033 As T4033_AREA)
Try
    
    x4033.WorkOrder = trim$(  x4033.WorkOrder)
    x4033.WorkOrderSeq = trim$(  x4033.WorkOrderSeq)
    x4033.AddCostSeq = trim$(  x4033.AddCostSeq)
    x4033.Status = trim$(  x4033.Status)
    x4033.seAdditionalCost = trim$(  x4033.seAdditionalCost)
    x4033.cdAdditionalCost = trim$(  x4033.cdAdditionalCost)
    x4033.seCostingType = trim$(  x4033.seCostingType)
    x4033.cdCostingType = trim$(  x4033.cdCostingType)
    x4033.Price = trim$(  x4033.Price)
    x4033.TotalQty = trim$(  x4033.TotalQty)
    x4033.TotalAMT = trim$(  x4033.TotalAMT)
    x4033.InsertDate = trim$(  x4033.InsertDate)
    x4033.InchargeInsert = trim$(  x4033.InchargeInsert)
    x4033.UpdateDate = trim$(  x4033.UpdateDate)
    x4033.InchargeUpdate = trim$(  x4033.InchargeUpdate)
    x4033.AttachID = trim$(  x4033.AttachID)
    x4033.RemarkOrder = trim$(  x4033.RemarkOrder)
    x4033.RemarkCustomer = trim$(  x4033.RemarkCustomer)
    x4033.Remark = trim$(  x4033.Remark)
     
    If trim$( x4033.WorkOrder ) = "" Then x4033.WorkOrder = Space(1) 
    If trim$( x4033.WorkOrderSeq ) = "" Then x4033.WorkOrderSeq = Space(1) 
    If trim$( x4033.AddCostSeq ) = "" Then x4033.AddCostSeq = 0 
    If trim$( x4033.Status ) = "" Then x4033.Status = Space(1) 
    If trim$( x4033.seAdditionalCost ) = "" Then x4033.seAdditionalCost = Space(1) 
    If trim$( x4033.cdAdditionalCost ) = "" Then x4033.cdAdditionalCost = Space(1) 
    If trim$( x4033.seCostingType ) = "" Then x4033.seCostingType = Space(1) 
    If trim$( x4033.cdCostingType ) = "" Then x4033.cdCostingType = Space(1) 
    If trim$( x4033.Price ) = "" Then x4033.Price = 0 
    If trim$( x4033.TotalQty ) = "" Then x4033.TotalQty = 0 
    If trim$( x4033.TotalAMT ) = "" Then x4033.TotalAMT = 0 
    If trim$( x4033.InsertDate ) = "" Then x4033.InsertDate = Space(1) 
    If trim$( x4033.InchargeInsert ) = "" Then x4033.InchargeInsert = Space(1) 
    If trim$( x4033.UpdateDate ) = "" Then x4033.UpdateDate = Space(1) 
    If trim$( x4033.InchargeUpdate ) = "" Then x4033.InchargeUpdate = Space(1) 
    If trim$( x4033.AttachID ) = "" Then x4033.AttachID = Space(1) 
    If trim$( x4033.RemarkOrder ) = "" Then x4033.RemarkOrder = Space(1) 
    If trim$( x4033.RemarkCustomer ) = "" Then x4033.RemarkCustomer = Space(1) 
    If trim$( x4033.Remark ) = "" Then x4033.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K4033_MOVE(rs4033 As SqlClient.SqlDataReader)
Try

    call D4033_CLEAR()   

    If IsdbNull(rs4033!K4033_WorkOrder) = False Then D4033.WorkOrder = Trim$(rs4033!K4033_WorkOrder)
    If IsdbNull(rs4033!K4033_WorkOrderSeq) = False Then D4033.WorkOrderSeq = Trim$(rs4033!K4033_WorkOrderSeq)
    If IsdbNull(rs4033!K4033_AddCostSeq) = False Then D4033.AddCostSeq = Trim$(rs4033!K4033_AddCostSeq)
    If IsdbNull(rs4033!K4033_Status) = False Then D4033.Status = Trim$(rs4033!K4033_Status)
    If IsdbNull(rs4033!K4033_seAdditionalCost) = False Then D4033.seAdditionalCost = Trim$(rs4033!K4033_seAdditionalCost)
    If IsdbNull(rs4033!K4033_cdAdditionalCost) = False Then D4033.cdAdditionalCost = Trim$(rs4033!K4033_cdAdditionalCost)
    If IsdbNull(rs4033!K4033_seCostingType) = False Then D4033.seCostingType = Trim$(rs4033!K4033_seCostingType)
    If IsdbNull(rs4033!K4033_cdCostingType) = False Then D4033.cdCostingType = Trim$(rs4033!K4033_cdCostingType)
    If IsdbNull(rs4033!K4033_Price) = False Then D4033.Price = Trim$(rs4033!K4033_Price)
    If IsdbNull(rs4033!K4033_TotalQty) = False Then D4033.TotalQty = Trim$(rs4033!K4033_TotalQty)
    If IsdbNull(rs4033!K4033_TotalAMT) = False Then D4033.TotalAMT = Trim$(rs4033!K4033_TotalAMT)
    If IsdbNull(rs4033!K4033_InsertDate) = False Then D4033.InsertDate = Trim$(rs4033!K4033_InsertDate)
    If IsdbNull(rs4033!K4033_InchargeInsert) = False Then D4033.InchargeInsert = Trim$(rs4033!K4033_InchargeInsert)
    If IsdbNull(rs4033!K4033_UpdateDate) = False Then D4033.UpdateDate = Trim$(rs4033!K4033_UpdateDate)
    If IsdbNull(rs4033!K4033_InchargeUpdate) = False Then D4033.InchargeUpdate = Trim$(rs4033!K4033_InchargeUpdate)
    If IsdbNull(rs4033!K4033_AttachID) = False Then D4033.AttachID = Trim$(rs4033!K4033_AttachID)
    If IsdbNull(rs4033!K4033_RemarkOrder) = False Then D4033.RemarkOrder = Trim$(rs4033!K4033_RemarkOrder)
    If IsdbNull(rs4033!K4033_RemarkCustomer) = False Then D4033.RemarkCustomer = Trim$(rs4033!K4033_RemarkCustomer)
    If IsdbNull(rs4033!K4033_Remark) = False Then D4033.Remark = Trim$(rs4033!K4033_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K4033_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K4033_MOVE(rs4033 As DataRow)
Try

    call D4033_CLEAR()   

    If IsdbNull(rs4033!K4033_WorkOrder) = False Then D4033.WorkOrder = Trim$(rs4033!K4033_WorkOrder)
    If IsdbNull(rs4033!K4033_WorkOrderSeq) = False Then D4033.WorkOrderSeq = Trim$(rs4033!K4033_WorkOrderSeq)
    If IsdbNull(rs4033!K4033_AddCostSeq) = False Then D4033.AddCostSeq = Trim$(rs4033!K4033_AddCostSeq)
    If IsdbNull(rs4033!K4033_Status) = False Then D4033.Status = Trim$(rs4033!K4033_Status)
    If IsdbNull(rs4033!K4033_seAdditionalCost) = False Then D4033.seAdditionalCost = Trim$(rs4033!K4033_seAdditionalCost)
    If IsdbNull(rs4033!K4033_cdAdditionalCost) = False Then D4033.cdAdditionalCost = Trim$(rs4033!K4033_cdAdditionalCost)
    If IsdbNull(rs4033!K4033_seCostingType) = False Then D4033.seCostingType = Trim$(rs4033!K4033_seCostingType)
    If IsdbNull(rs4033!K4033_cdCostingType) = False Then D4033.cdCostingType = Trim$(rs4033!K4033_cdCostingType)
    If IsdbNull(rs4033!K4033_Price) = False Then D4033.Price = Trim$(rs4033!K4033_Price)
    If IsdbNull(rs4033!K4033_TotalQty) = False Then D4033.TotalQty = Trim$(rs4033!K4033_TotalQty)
    If IsdbNull(rs4033!K4033_TotalAMT) = False Then D4033.TotalAMT = Trim$(rs4033!K4033_TotalAMT)
    If IsdbNull(rs4033!K4033_InsertDate) = False Then D4033.InsertDate = Trim$(rs4033!K4033_InsertDate)
    If IsdbNull(rs4033!K4033_InchargeInsert) = False Then D4033.InchargeInsert = Trim$(rs4033!K4033_InchargeInsert)
    If IsdbNull(rs4033!K4033_UpdateDate) = False Then D4033.UpdateDate = Trim$(rs4033!K4033_UpdateDate)
    If IsdbNull(rs4033!K4033_InchargeUpdate) = False Then D4033.InchargeUpdate = Trim$(rs4033!K4033_InchargeUpdate)
    If IsdbNull(rs4033!K4033_AttachID) = False Then D4033.AttachID = Trim$(rs4033!K4033_AttachID)
    If IsdbNull(rs4033!K4033_RemarkOrder) = False Then D4033.RemarkOrder = Trim$(rs4033!K4033_RemarkOrder)
    If IsdbNull(rs4033!K4033_RemarkCustomer) = False Then D4033.RemarkCustomer = Trim$(rs4033!K4033_RemarkCustomer)
    If IsdbNull(rs4033!K4033_Remark) = False Then D4033.Remark = Trim$(rs4033!K4033_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K4033_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K4033_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z4033 As T4033_AREA, WORKORDER AS String, WORKORDERSEQ AS String, ADDCOSTSEQ AS Double) as Boolean

K4033_MOVE = False

Try
    If READ_PFK4033(WORKORDER, WORKORDERSEQ, ADDCOSTSEQ) = True Then
                z4033 = D4033
		K4033_MOVE = True
		else
	z4033 = nothing
     End If

     If  getColumIndex(spr,"WorkOrder") > -1 then z4033.WorkOrder = getDataM(spr, getColumIndex(spr,"WorkOrder"), xRow)
     If  getColumIndex(spr,"WorkOrderSeq") > -1 then z4033.WorkOrderSeq = getDataM(spr, getColumIndex(spr,"WorkOrderSeq"), xRow)
     If  getColumIndex(spr,"AddCostSeq") > -1 then z4033.AddCostSeq = getDataM(spr, getColumIndex(spr,"AddCostSeq"), xRow)
     If  getColumIndex(spr,"Status") > -1 then z4033.Status = getDataM(spr, getColumIndex(spr,"Status"), xRow)
     If  getColumIndex(spr,"seAdditionalCost") > -1 then z4033.seAdditionalCost = getDataM(spr, getColumIndex(spr,"seAdditionalCost"), xRow)
     If  getColumIndex(spr,"cdAdditionalCost") > -1 then z4033.cdAdditionalCost = getDataM(spr, getColumIndex(spr,"cdAdditionalCost"), xRow)
     If  getColumIndex(spr,"seCostingType") > -1 then z4033.seCostingType = getDataM(spr, getColumIndex(spr,"seCostingType"), xRow)
     If  getColumIndex(spr,"cdCostingType") > -1 then z4033.cdCostingType = getDataM(spr, getColumIndex(spr,"cdCostingType"), xRow)
     If  getColumIndex(spr,"Price") > -1 then z4033.Price = getDataM(spr, getColumIndex(spr,"Price"), xRow)
     If  getColumIndex(spr,"TotalQty") > -1 then z4033.TotalQty = getDataM(spr, getColumIndex(spr,"TotalQty"), xRow)
     If  getColumIndex(spr,"TotalAMT") > -1 then z4033.TotalAMT = getDataM(spr, getColumIndex(spr,"TotalAMT"), xRow)
     If  getColumIndex(spr,"InsertDate") > -1 then z4033.InsertDate = getDataM(spr, getColumIndex(spr,"InsertDate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z4033.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"UpdateDate") > -1 then z4033.UpdateDate = getDataM(spr, getColumIndex(spr,"UpdateDate"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z4033.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"AttachID") > -1 then z4033.AttachID = getDataM(spr, getColumIndex(spr,"AttachID"), xRow)
     If  getColumIndex(spr,"RemarkOrder") > -1 then z4033.RemarkOrder = getDataM(spr, getColumIndex(spr,"RemarkOrder"), xRow)
     If  getColumIndex(spr,"RemarkCustomer") > -1 then z4033.RemarkCustomer = getDataM(spr, getColumIndex(spr,"RemarkCustomer"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z4033.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K4033_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K4033_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z4033 As T4033_AREA,CheckClear as Boolean,WORKORDER AS String, WORKORDERSEQ AS String, ADDCOSTSEQ AS Double) as Boolean

K4033_MOVE = False

Try
    If READ_PFK4033(WORKORDER, WORKORDERSEQ, ADDCOSTSEQ) = True Then
                z4033 = D4033
		K4033_MOVE = True
		else
	If CheckClear  = True then z4033 = nothing
     End If

     If  getColumIndex(spr,"WorkOrder") > -1 then z4033.WorkOrder = getDataM(spr, getColumIndex(spr,"WorkOrder"), xRow)
     If  getColumIndex(spr,"WorkOrderSeq") > -1 then z4033.WorkOrderSeq = getDataM(spr, getColumIndex(spr,"WorkOrderSeq"), xRow)
     If  getColumIndex(spr,"AddCostSeq") > -1 then z4033.AddCostSeq = getDataM(spr, getColumIndex(spr,"AddCostSeq"), xRow)
     If  getColumIndex(spr,"Status") > -1 then z4033.Status = getDataM(spr, getColumIndex(spr,"Status"), xRow)
     If  getColumIndex(spr,"seAdditionalCost") > -1 then z4033.seAdditionalCost = getDataM(spr, getColumIndex(spr,"seAdditionalCost"), xRow)
     If  getColumIndex(spr,"cdAdditionalCost") > -1 then z4033.cdAdditionalCost = getDataM(spr, getColumIndex(spr,"cdAdditionalCost"), xRow)
     If  getColumIndex(spr,"seCostingType") > -1 then z4033.seCostingType = getDataM(spr, getColumIndex(spr,"seCostingType"), xRow)
     If  getColumIndex(spr,"cdCostingType") > -1 then z4033.cdCostingType = getDataM(spr, getColumIndex(spr,"cdCostingType"), xRow)
     If  getColumIndex(spr,"Price") > -1 then z4033.Price = getDataM(spr, getColumIndex(spr,"Price"), xRow)
     If  getColumIndex(spr,"TotalQty") > -1 then z4033.TotalQty = getDataM(spr, getColumIndex(spr,"TotalQty"), xRow)
     If  getColumIndex(spr,"TotalAMT") > -1 then z4033.TotalAMT = getDataM(spr, getColumIndex(spr,"TotalAMT"), xRow)
     If  getColumIndex(spr,"InsertDate") > -1 then z4033.InsertDate = getDataM(spr, getColumIndex(spr,"InsertDate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z4033.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"UpdateDate") > -1 then z4033.UpdateDate = getDataM(spr, getColumIndex(spr,"UpdateDate"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z4033.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"AttachID") > -1 then z4033.AttachID = getDataM(spr, getColumIndex(spr,"AttachID"), xRow)
     If  getColumIndex(spr,"RemarkOrder") > -1 then z4033.RemarkOrder = getDataM(spr, getColumIndex(spr,"RemarkOrder"), xRow)
     If  getColumIndex(spr,"RemarkCustomer") > -1 then z4033.RemarkCustomer = getDataM(spr, getColumIndex(spr,"RemarkCustomer"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z4033.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K4033_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K4033_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z4033 As T4033_AREA, Job as String, WORKORDER AS String, WORKORDERSEQ AS String, ADDCOSTSEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K4033_MOVE = False

Try
    If READ_PFK4033(WORKORDER, WORKORDERSEQ, ADDCOSTSEQ) = True Then
                z4033 = D4033
		K4033_MOVE = True
		else
	z4033 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4033")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "WORKORDER":z4033.WorkOrder = Children(i).Code
   Case "WORKORDERSEQ":z4033.WorkOrderSeq = Children(i).Code
   Case "ADDCOSTSEQ":z4033.AddCostSeq = Children(i).Code
   Case "STATUS":z4033.Status = Children(i).Code
   Case "SEADDITIONALCOST":z4033.seAdditionalCost = Children(i).Code
   Case "CDADDITIONALCOST":z4033.cdAdditionalCost = Children(i).Code
   Case "SECOSTINGTYPE":z4033.seCostingType = Children(i).Code
   Case "CDCOSTINGTYPE":z4033.cdCostingType = Children(i).Code
   Case "PRICE":z4033.Price = Children(i).Code
   Case "TOTALQTY":z4033.TotalQty = Children(i).Code
   Case "TOTALAMT":z4033.TotalAMT = Children(i).Code
   Case "INSERTDATE":z4033.InsertDate = Children(i).Code
   Case "INCHARGEINSERT":z4033.InchargeInsert = Children(i).Code
   Case "UPDATEDATE":z4033.UpdateDate = Children(i).Code
   Case "INCHARGEUPDATE":z4033.InchargeUpdate = Children(i).Code
   Case "ATTACHID":z4033.AttachID = Children(i).Code
   Case "REMARKORDER":z4033.RemarkOrder = Children(i).Code
   Case "REMARKCUSTOMER":z4033.RemarkCustomer = Children(i).Code
   Case "REMARK":z4033.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "WORKORDER":z4033.WorkOrder = Children(i).Data
   Case "WORKORDERSEQ":z4033.WorkOrderSeq = Children(i).Data
   Case "ADDCOSTSEQ":z4033.AddCostSeq = Children(i).Data
   Case "STATUS":z4033.Status = Children(i).Data
   Case "SEADDITIONALCOST":z4033.seAdditionalCost = Children(i).Data
   Case "CDADDITIONALCOST":z4033.cdAdditionalCost = Children(i).Data
   Case "SECOSTINGTYPE":z4033.seCostingType = Children(i).Data
   Case "CDCOSTINGTYPE":z4033.cdCostingType = Children(i).Data
   Case "PRICE":z4033.Price = Children(i).Data
   Case "TOTALQTY":z4033.TotalQty = Children(i).Data
   Case "TOTALAMT":z4033.TotalAMT = Children(i).Data
   Case "INSERTDATE":z4033.InsertDate = Children(i).Data
   Case "INCHARGEINSERT":z4033.InchargeInsert = Children(i).Data
   Case "UPDATEDATE":z4033.UpdateDate = Children(i).Data
   Case "INCHARGEUPDATE":z4033.InchargeUpdate = Children(i).Data
   Case "ATTACHID":z4033.AttachID = Children(i).Data
   Case "REMARKORDER":z4033.RemarkOrder = Children(i).Data
   Case "REMARKCUSTOMER":z4033.RemarkCustomer = Children(i).Data
   Case "REMARK":z4033.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K4033_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K4033_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z4033 As T4033_AREA, Job as String, CheckClear as Boolean, WORKORDER AS String, WORKORDERSEQ AS String, ADDCOSTSEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K4033_MOVE = False

Try
    If READ_PFK4033(WORKORDER, WORKORDERSEQ, ADDCOSTSEQ) = True Then
                z4033 = D4033
		K4033_MOVE = True
		else
	If CheckClear  = True then z4033 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4033")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "WORKORDER":z4033.WorkOrder = Children(i).Code
   Case "WORKORDERSEQ":z4033.WorkOrderSeq = Children(i).Code
   Case "ADDCOSTSEQ":z4033.AddCostSeq = Children(i).Code
   Case "STATUS":z4033.Status = Children(i).Code
   Case "SEADDITIONALCOST":z4033.seAdditionalCost = Children(i).Code
   Case "CDADDITIONALCOST":z4033.cdAdditionalCost = Children(i).Code
   Case "SECOSTINGTYPE":z4033.seCostingType = Children(i).Code
   Case "CDCOSTINGTYPE":z4033.cdCostingType = Children(i).Code
   Case "PRICE":z4033.Price = Children(i).Code
   Case "TOTALQTY":z4033.TotalQty = Children(i).Code
   Case "TOTALAMT":z4033.TotalAMT = Children(i).Code
   Case "INSERTDATE":z4033.InsertDate = Children(i).Code
   Case "INCHARGEINSERT":z4033.InchargeInsert = Children(i).Code
   Case "UPDATEDATE":z4033.UpdateDate = Children(i).Code
   Case "INCHARGEUPDATE":z4033.InchargeUpdate = Children(i).Code
   Case "ATTACHID":z4033.AttachID = Children(i).Code
   Case "REMARKORDER":z4033.RemarkOrder = Children(i).Code
   Case "REMARKCUSTOMER":z4033.RemarkCustomer = Children(i).Code
   Case "REMARK":z4033.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "WORKORDER":z4033.WorkOrder = Children(i).Data
   Case "WORKORDERSEQ":z4033.WorkOrderSeq = Children(i).Data
   Case "ADDCOSTSEQ":z4033.AddCostSeq = Children(i).Data
   Case "STATUS":z4033.Status = Children(i).Data
   Case "SEADDITIONALCOST":z4033.seAdditionalCost = Children(i).Data
   Case "CDADDITIONALCOST":z4033.cdAdditionalCost = Children(i).Data
   Case "SECOSTINGTYPE":z4033.seCostingType = Children(i).Data
   Case "CDCOSTINGTYPE":z4033.cdCostingType = Children(i).Data
   Case "PRICE":z4033.Price = Children(i).Data
   Case "TOTALQTY":z4033.TotalQty = Children(i).Data
   Case "TOTALAMT":z4033.TotalAMT = Children(i).Data
   Case "INSERTDATE":z4033.InsertDate = Children(i).Data
   Case "INCHARGEINSERT":z4033.InchargeInsert = Children(i).Data
   Case "UPDATEDATE":z4033.UpdateDate = Children(i).Data
   Case "INCHARGEUPDATE":z4033.InchargeUpdate = Children(i).Data
   Case "ATTACHID":z4033.AttachID = Children(i).Data
   Case "REMARKORDER":z4033.RemarkOrder = Children(i).Data
   Case "REMARKCUSTOMER":z4033.RemarkCustomer = Children(i).Data
   Case "REMARK":z4033.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K4033_MOVE",vbCritical)
End Try
End Function 
    
End Module 
