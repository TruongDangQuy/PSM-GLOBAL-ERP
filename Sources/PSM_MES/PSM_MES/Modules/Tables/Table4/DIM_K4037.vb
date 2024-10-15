'=========================================================================================================================================================
'   TABLE : (PFK4037)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K4037

Structure T4037_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	WorkOrder	 AS String	'			char(9)		*
Public 	WorkOrderSeq	 AS String	'			char(3)		*
Public 	SalesCostSeq	 AS Double	'			decimal		*
Public 	Status	 AS String	'			char(10)
Public 	seSalesCost	 AS String	'			char(3)
Public 	cdSalesCost	 AS String	'			char(3)
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

Public D4037 As T4037_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK4037(WORKORDER AS String, WORKORDERSEQ AS String, SALESCOSTSEQ AS Double) As Boolean
    READ_PFK4037 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK4037 "
    SQL = SQL & " WHERE K4037_WorkOrder		 = '" & WorkOrder & "' " 
    SQL = SQL & "   AND K4037_WorkOrderSeq		 = '" & WorkOrderSeq & "' " 
    SQL = SQL & "   AND K4037_SalesCostSeq		 =  " & SalesCostSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D4037_CLEAR: GoTo SKIP_READ_PFK4037
                
    Call K4037_MOVE(rd)
    READ_PFK4037 = True

SKIP_READ_PFK4037:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK4037",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK4037(WORKORDER AS String, WORKORDERSEQ AS String, SALESCOSTSEQ AS Double, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK4037 "
    SQL = SQL & " WHERE K4037_WorkOrder		 = '" & WorkOrder & "' " 
    SQL = SQL & "   AND K4037_WorkOrderSeq		 = '" & WorkOrderSeq & "' " 
    SQL = SQL & "   AND K4037_SalesCostSeq		 =  " & SalesCostSeq & "  " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK4037",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK4037(z4037 As T4037_AREA) As Boolean
    WRITE_PFK4037 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z4037)
 
    SQL = " INSERT INTO PFK4037 "
    SQL = SQL & " ( "
    SQL = SQL & " K4037_WorkOrder," 
    SQL = SQL & " K4037_WorkOrderSeq," 
    SQL = SQL & " K4037_SalesCostSeq," 
    SQL = SQL & " K4037_Status," 
    SQL = SQL & " K4037_seSalesCost," 
    SQL = SQL & " K4037_cdSalesCost," 
    SQL = SQL & " K4037_seCostingType," 
    SQL = SQL & " K4037_cdCostingType," 
    SQL = SQL & " K4037_Price," 
    SQL = SQL & " K4037_TotalQty," 
    SQL = SQL & " K4037_TotalAMT," 
    SQL = SQL & " K4037_InsertDate," 
    SQL = SQL & " K4037_InchargeInsert," 
    SQL = SQL & " K4037_UpdateDate," 
    SQL = SQL & " K4037_InchargeUpdate," 
    SQL = SQL & " K4037_AttachID," 
    SQL = SQL & " K4037_RemarkOrder," 
    SQL = SQL & " K4037_RemarkCustomer," 
    SQL = SQL & " K4037_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z4037.WorkOrder) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4037.WorkOrderSeq) & "', "  
    SQL = SQL & "   " & FormatSQL(z4037.SalesCostSeq) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z4037.Status) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4037.seSalesCost) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4037.cdSalesCost) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4037.seCostingType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4037.cdCostingType) & "', "  
    SQL = SQL & "   " & FormatSQL(z4037.Price) & ", "  
    SQL = SQL & "   " & FormatSQL(z4037.TotalQty) & ", "  
    SQL = SQL & "   " & FormatSQL(z4037.TotalAMT) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z4037.InsertDate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4037.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4037.UpdateDate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4037.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4037.AttachID) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4037.RemarkOrder) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4037.RemarkCustomer) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4037.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK4037 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK4037",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK4037(z4037 As T4037_AREA) As Boolean
    REWRITE_PFK4037 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z4037)
   
    SQL = " UPDATE PFK4037 SET "
    SQL = SQL & "    K4037_Status      = N'" & FormatSQL(z4037.Status) & "', " 
    SQL = SQL & "    K4037_seSalesCost      = N'" & FormatSQL(z4037.seSalesCost) & "', " 
    SQL = SQL & "    K4037_cdSalesCost      = N'" & FormatSQL(z4037.cdSalesCost) & "', " 
    SQL = SQL & "    K4037_seCostingType      = N'" & FormatSQL(z4037.seCostingType) & "', " 
    SQL = SQL & "    K4037_cdCostingType      = N'" & FormatSQL(z4037.cdCostingType) & "', " 
    SQL = SQL & "    K4037_Price      =  " & FormatSQL(z4037.Price) & ", " 
    SQL = SQL & "    K4037_TotalQty      =  " & FormatSQL(z4037.TotalQty) & ", " 
    SQL = SQL & "    K4037_TotalAMT      =  " & FormatSQL(z4037.TotalAMT) & ", " 
    SQL = SQL & "    K4037_InsertDate      = N'" & FormatSQL(z4037.InsertDate) & "', " 
    SQL = SQL & "    K4037_InchargeInsert      = N'" & FormatSQL(z4037.InchargeInsert) & "', " 
    SQL = SQL & "    K4037_UpdateDate      = N'" & FormatSQL(z4037.UpdateDate) & "', " 
    SQL = SQL & "    K4037_InchargeUpdate      = N'" & FormatSQL(z4037.InchargeUpdate) & "', " 
    SQL = SQL & "    K4037_AttachID      = N'" & FormatSQL(z4037.AttachID) & "', " 
    SQL = SQL & "    K4037_RemarkOrder      = N'" & FormatSQL(z4037.RemarkOrder) & "', " 
    SQL = SQL & "    K4037_RemarkCustomer      = N'" & FormatSQL(z4037.RemarkCustomer) & "', " 
    SQL = SQL & "    K4037_Remark      = N'" & FormatSQL(z4037.Remark) & "'  " 
    SQL = SQL & " WHERE K4037_WorkOrder		 = '" & z4037.WorkOrder & "' " 
    SQL = SQL & "   AND K4037_WorkOrderSeq		 = '" & z4037.WorkOrderSeq & "' " 
    SQL = SQL & "   AND K4037_SalesCostSeq		 =  " & z4037.SalesCostSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK4037 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK4037",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK4037(z4037 As T4037_AREA) As Boolean
    DELETE_PFK4037 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK4037 "
    SQL = SQL & " WHERE K4037_WorkOrder		 = '" & z4037.WorkOrder & "' " 
    SQL = SQL & "   AND K4037_WorkOrderSeq		 = '" & z4037.WorkOrderSeq & "' " 
    SQL = SQL & "   AND K4037_SalesCostSeq		 =  " & z4037.SalesCostSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK4037 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK4037",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D4037_CLEAR()
Try
    
   D4037.WorkOrder = ""
   D4037.WorkOrderSeq = ""
    D4037.SalesCostSeq = 0 
   D4037.Status = ""
   D4037.seSalesCost = ""
   D4037.cdSalesCost = ""
   D4037.seCostingType = ""
   D4037.cdCostingType = ""
    D4037.Price = 0 
    D4037.TotalQty = 0 
    D4037.TotalAMT = 0 
   D4037.InsertDate = ""
   D4037.InchargeInsert = ""
   D4037.UpdateDate = ""
   D4037.InchargeUpdate = ""
   D4037.AttachID = ""
   D4037.RemarkOrder = ""
   D4037.RemarkCustomer = ""
   D4037.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D4037_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x4037 As T4037_AREA)
Try
    
    x4037.WorkOrder = trim$(  x4037.WorkOrder)
    x4037.WorkOrderSeq = trim$(  x4037.WorkOrderSeq)
    x4037.SalesCostSeq = trim$(  x4037.SalesCostSeq)
    x4037.Status = trim$(  x4037.Status)
    x4037.seSalesCost = trim$(  x4037.seSalesCost)
    x4037.cdSalesCost = trim$(  x4037.cdSalesCost)
    x4037.seCostingType = trim$(  x4037.seCostingType)
    x4037.cdCostingType = trim$(  x4037.cdCostingType)
    x4037.Price = trim$(  x4037.Price)
    x4037.TotalQty = trim$(  x4037.TotalQty)
    x4037.TotalAMT = trim$(  x4037.TotalAMT)
    x4037.InsertDate = trim$(  x4037.InsertDate)
    x4037.InchargeInsert = trim$(  x4037.InchargeInsert)
    x4037.UpdateDate = trim$(  x4037.UpdateDate)
    x4037.InchargeUpdate = trim$(  x4037.InchargeUpdate)
    x4037.AttachID = trim$(  x4037.AttachID)
    x4037.RemarkOrder = trim$(  x4037.RemarkOrder)
    x4037.RemarkCustomer = trim$(  x4037.RemarkCustomer)
    x4037.Remark = trim$(  x4037.Remark)
     
    If trim$( x4037.WorkOrder ) = "" Then x4037.WorkOrder = Space(1) 
    If trim$( x4037.WorkOrderSeq ) = "" Then x4037.WorkOrderSeq = Space(1) 
    If trim$( x4037.SalesCostSeq ) = "" Then x4037.SalesCostSeq = 0 
    If trim$( x4037.Status ) = "" Then x4037.Status = Space(1) 
    If trim$( x4037.seSalesCost ) = "" Then x4037.seSalesCost = Space(1) 
    If trim$( x4037.cdSalesCost ) = "" Then x4037.cdSalesCost = Space(1) 
    If trim$( x4037.seCostingType ) = "" Then x4037.seCostingType = Space(1) 
    If trim$( x4037.cdCostingType ) = "" Then x4037.cdCostingType = Space(1) 
    If trim$( x4037.Price ) = "" Then x4037.Price = 0 
    If trim$( x4037.TotalQty ) = "" Then x4037.TotalQty = 0 
    If trim$( x4037.TotalAMT ) = "" Then x4037.TotalAMT = 0 
    If trim$( x4037.InsertDate ) = "" Then x4037.InsertDate = Space(1) 
    If trim$( x4037.InchargeInsert ) = "" Then x4037.InchargeInsert = Space(1) 
    If trim$( x4037.UpdateDate ) = "" Then x4037.UpdateDate = Space(1) 
    If trim$( x4037.InchargeUpdate ) = "" Then x4037.InchargeUpdate = Space(1) 
    If trim$( x4037.AttachID ) = "" Then x4037.AttachID = Space(1) 
    If trim$( x4037.RemarkOrder ) = "" Then x4037.RemarkOrder = Space(1) 
    If trim$( x4037.RemarkCustomer ) = "" Then x4037.RemarkCustomer = Space(1) 
    If trim$( x4037.Remark ) = "" Then x4037.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K4037_MOVE(rs4037 As SqlClient.SqlDataReader)
Try

    call D4037_CLEAR()   

    If IsdbNull(rs4037!K4037_WorkOrder) = False Then D4037.WorkOrder = Trim$(rs4037!K4037_WorkOrder)
    If IsdbNull(rs4037!K4037_WorkOrderSeq) = False Then D4037.WorkOrderSeq = Trim$(rs4037!K4037_WorkOrderSeq)
    If IsdbNull(rs4037!K4037_SalesCostSeq) = False Then D4037.SalesCostSeq = Trim$(rs4037!K4037_SalesCostSeq)
    If IsdbNull(rs4037!K4037_Status) = False Then D4037.Status = Trim$(rs4037!K4037_Status)
    If IsdbNull(rs4037!K4037_seSalesCost) = False Then D4037.seSalesCost = Trim$(rs4037!K4037_seSalesCost)
    If IsdbNull(rs4037!K4037_cdSalesCost) = False Then D4037.cdSalesCost = Trim$(rs4037!K4037_cdSalesCost)
    If IsdbNull(rs4037!K4037_seCostingType) = False Then D4037.seCostingType = Trim$(rs4037!K4037_seCostingType)
    If IsdbNull(rs4037!K4037_cdCostingType) = False Then D4037.cdCostingType = Trim$(rs4037!K4037_cdCostingType)
    If IsdbNull(rs4037!K4037_Price) = False Then D4037.Price = Trim$(rs4037!K4037_Price)
    If IsdbNull(rs4037!K4037_TotalQty) = False Then D4037.TotalQty = Trim$(rs4037!K4037_TotalQty)
    If IsdbNull(rs4037!K4037_TotalAMT) = False Then D4037.TotalAMT = Trim$(rs4037!K4037_TotalAMT)
    If IsdbNull(rs4037!K4037_InsertDate) = False Then D4037.InsertDate = Trim$(rs4037!K4037_InsertDate)
    If IsdbNull(rs4037!K4037_InchargeInsert) = False Then D4037.InchargeInsert = Trim$(rs4037!K4037_InchargeInsert)
    If IsdbNull(rs4037!K4037_UpdateDate) = False Then D4037.UpdateDate = Trim$(rs4037!K4037_UpdateDate)
    If IsdbNull(rs4037!K4037_InchargeUpdate) = False Then D4037.InchargeUpdate = Trim$(rs4037!K4037_InchargeUpdate)
    If IsdbNull(rs4037!K4037_AttachID) = False Then D4037.AttachID = Trim$(rs4037!K4037_AttachID)
    If IsdbNull(rs4037!K4037_RemarkOrder) = False Then D4037.RemarkOrder = Trim$(rs4037!K4037_RemarkOrder)
    If IsdbNull(rs4037!K4037_RemarkCustomer) = False Then D4037.RemarkCustomer = Trim$(rs4037!K4037_RemarkCustomer)
    If IsdbNull(rs4037!K4037_Remark) = False Then D4037.Remark = Trim$(rs4037!K4037_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K4037_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K4037_MOVE(rs4037 As DataRow)
Try

    call D4037_CLEAR()   

    If IsdbNull(rs4037!K4037_WorkOrder) = False Then D4037.WorkOrder = Trim$(rs4037!K4037_WorkOrder)
    If IsdbNull(rs4037!K4037_WorkOrderSeq) = False Then D4037.WorkOrderSeq = Trim$(rs4037!K4037_WorkOrderSeq)
    If IsdbNull(rs4037!K4037_SalesCostSeq) = False Then D4037.SalesCostSeq = Trim$(rs4037!K4037_SalesCostSeq)
    If IsdbNull(rs4037!K4037_Status) = False Then D4037.Status = Trim$(rs4037!K4037_Status)
    If IsdbNull(rs4037!K4037_seSalesCost) = False Then D4037.seSalesCost = Trim$(rs4037!K4037_seSalesCost)
    If IsdbNull(rs4037!K4037_cdSalesCost) = False Then D4037.cdSalesCost = Trim$(rs4037!K4037_cdSalesCost)
    If IsdbNull(rs4037!K4037_seCostingType) = False Then D4037.seCostingType = Trim$(rs4037!K4037_seCostingType)
    If IsdbNull(rs4037!K4037_cdCostingType) = False Then D4037.cdCostingType = Trim$(rs4037!K4037_cdCostingType)
    If IsdbNull(rs4037!K4037_Price) = False Then D4037.Price = Trim$(rs4037!K4037_Price)
    If IsdbNull(rs4037!K4037_TotalQty) = False Then D4037.TotalQty = Trim$(rs4037!K4037_TotalQty)
    If IsdbNull(rs4037!K4037_TotalAMT) = False Then D4037.TotalAMT = Trim$(rs4037!K4037_TotalAMT)
    If IsdbNull(rs4037!K4037_InsertDate) = False Then D4037.InsertDate = Trim$(rs4037!K4037_InsertDate)
    If IsdbNull(rs4037!K4037_InchargeInsert) = False Then D4037.InchargeInsert = Trim$(rs4037!K4037_InchargeInsert)
    If IsdbNull(rs4037!K4037_UpdateDate) = False Then D4037.UpdateDate = Trim$(rs4037!K4037_UpdateDate)
    If IsdbNull(rs4037!K4037_InchargeUpdate) = False Then D4037.InchargeUpdate = Trim$(rs4037!K4037_InchargeUpdate)
    If IsdbNull(rs4037!K4037_AttachID) = False Then D4037.AttachID = Trim$(rs4037!K4037_AttachID)
    If IsdbNull(rs4037!K4037_RemarkOrder) = False Then D4037.RemarkOrder = Trim$(rs4037!K4037_RemarkOrder)
    If IsdbNull(rs4037!K4037_RemarkCustomer) = False Then D4037.RemarkCustomer = Trim$(rs4037!K4037_RemarkCustomer)
    If IsdbNull(rs4037!K4037_Remark) = False Then D4037.Remark = Trim$(rs4037!K4037_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K4037_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K4037_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z4037 As T4037_AREA, WORKORDER AS String, WORKORDERSEQ AS String, SALESCOSTSEQ AS Double) as Boolean

K4037_MOVE = False

Try
    If READ_PFK4037(WORKORDER, WORKORDERSEQ, SALESCOSTSEQ) = True Then
                z4037 = D4037
		K4037_MOVE = True
		else
	z4037 = nothing
     End If

     If  getColumIndex(spr,"WorkOrder") > -1 then z4037.WorkOrder = getDataM(spr, getColumIndex(spr,"WorkOrder"), xRow)
     If  getColumIndex(spr,"WorkOrderSeq") > -1 then z4037.WorkOrderSeq = getDataM(spr, getColumIndex(spr,"WorkOrderSeq"), xRow)
     If  getColumIndex(spr,"SalesCostSeq") > -1 then z4037.SalesCostSeq = getDataM(spr, getColumIndex(spr,"SalesCostSeq"), xRow)
     If  getColumIndex(spr,"Status") > -1 then z4037.Status = getDataM(spr, getColumIndex(spr,"Status"), xRow)
     If  getColumIndex(spr,"seSalesCost") > -1 then z4037.seSalesCost = getDataM(spr, getColumIndex(spr,"seSalesCost"), xRow)
     If  getColumIndex(spr,"cdSalesCost") > -1 then z4037.cdSalesCost = getDataM(spr, getColumIndex(spr,"cdSalesCost"), xRow)
     If  getColumIndex(spr,"seCostingType") > -1 then z4037.seCostingType = getDataM(spr, getColumIndex(spr,"seCostingType"), xRow)
     If  getColumIndex(spr,"cdCostingType") > -1 then z4037.cdCostingType = getDataM(spr, getColumIndex(spr,"cdCostingType"), xRow)
     If  getColumIndex(spr,"Price") > -1 then z4037.Price = getDataM(spr, getColumIndex(spr,"Price"), xRow)
     If  getColumIndex(spr,"TotalQty") > -1 then z4037.TotalQty = getDataM(spr, getColumIndex(spr,"TotalQty"), xRow)
     If  getColumIndex(spr,"TotalAMT") > -1 then z4037.TotalAMT = getDataM(spr, getColumIndex(spr,"TotalAMT"), xRow)
     If  getColumIndex(spr,"InsertDate") > -1 then z4037.InsertDate = getDataM(spr, getColumIndex(spr,"InsertDate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z4037.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"UpdateDate") > -1 then z4037.UpdateDate = getDataM(spr, getColumIndex(spr,"UpdateDate"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z4037.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"AttachID") > -1 then z4037.AttachID = getDataM(spr, getColumIndex(spr,"AttachID"), xRow)
     If  getColumIndex(spr,"RemarkOrder") > -1 then z4037.RemarkOrder = getDataM(spr, getColumIndex(spr,"RemarkOrder"), xRow)
     If  getColumIndex(spr,"RemarkCustomer") > -1 then z4037.RemarkCustomer = getDataM(spr, getColumIndex(spr,"RemarkCustomer"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z4037.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K4037_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K4037_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z4037 As T4037_AREA,CheckClear as Boolean,WORKORDER AS String, WORKORDERSEQ AS String, SALESCOSTSEQ AS Double) as Boolean

K4037_MOVE = False

Try
    If READ_PFK4037(WORKORDER, WORKORDERSEQ, SALESCOSTSEQ) = True Then
                z4037 = D4037
		K4037_MOVE = True
		else
	If CheckClear  = True then z4037 = nothing
     End If

     If  getColumIndex(spr,"WorkOrder") > -1 then z4037.WorkOrder = getDataM(spr, getColumIndex(spr,"WorkOrder"), xRow)
     If  getColumIndex(spr,"WorkOrderSeq") > -1 then z4037.WorkOrderSeq = getDataM(spr, getColumIndex(spr,"WorkOrderSeq"), xRow)
     If  getColumIndex(spr,"SalesCostSeq") > -1 then z4037.SalesCostSeq = getDataM(spr, getColumIndex(spr,"SalesCostSeq"), xRow)
     If  getColumIndex(spr,"Status") > -1 then z4037.Status = getDataM(spr, getColumIndex(spr,"Status"), xRow)
     If  getColumIndex(spr,"seSalesCost") > -1 then z4037.seSalesCost = getDataM(spr, getColumIndex(spr,"seSalesCost"), xRow)
     If  getColumIndex(spr,"cdSalesCost") > -1 then z4037.cdSalesCost = getDataM(spr, getColumIndex(spr,"cdSalesCost"), xRow)
     If  getColumIndex(spr,"seCostingType") > -1 then z4037.seCostingType = getDataM(spr, getColumIndex(spr,"seCostingType"), xRow)
     If  getColumIndex(spr,"cdCostingType") > -1 then z4037.cdCostingType = getDataM(spr, getColumIndex(spr,"cdCostingType"), xRow)
     If  getColumIndex(spr,"Price") > -1 then z4037.Price = getDataM(spr, getColumIndex(spr,"Price"), xRow)
     If  getColumIndex(spr,"TotalQty") > -1 then z4037.TotalQty = getDataM(spr, getColumIndex(spr,"TotalQty"), xRow)
     If  getColumIndex(spr,"TotalAMT") > -1 then z4037.TotalAMT = getDataM(spr, getColumIndex(spr,"TotalAMT"), xRow)
     If  getColumIndex(spr,"InsertDate") > -1 then z4037.InsertDate = getDataM(spr, getColumIndex(spr,"InsertDate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z4037.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"UpdateDate") > -1 then z4037.UpdateDate = getDataM(spr, getColumIndex(spr,"UpdateDate"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z4037.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"AttachID") > -1 then z4037.AttachID = getDataM(spr, getColumIndex(spr,"AttachID"), xRow)
     If  getColumIndex(spr,"RemarkOrder") > -1 then z4037.RemarkOrder = getDataM(spr, getColumIndex(spr,"RemarkOrder"), xRow)
     If  getColumIndex(spr,"RemarkCustomer") > -1 then z4037.RemarkCustomer = getDataM(spr, getColumIndex(spr,"RemarkCustomer"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z4037.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K4037_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K4037_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z4037 As T4037_AREA, Job as String, WORKORDER AS String, WORKORDERSEQ AS String, SALESCOSTSEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K4037_MOVE = False

Try
    If READ_PFK4037(WORKORDER, WORKORDERSEQ, SALESCOSTSEQ) = True Then
                z4037 = D4037
		K4037_MOVE = True
		else
	z4037 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4037")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "WORKORDER":z4037.WorkOrder = Children(i).Code
   Case "WORKORDERSEQ":z4037.WorkOrderSeq = Children(i).Code
   Case "SALESCOSTSEQ":z4037.SalesCostSeq = Children(i).Code
   Case "STATUS":z4037.Status = Children(i).Code
   Case "SESALESCOST":z4037.seSalesCost = Children(i).Code
   Case "CDSALESCOST":z4037.cdSalesCost = Children(i).Code
   Case "SECOSTINGTYPE":z4037.seCostingType = Children(i).Code
   Case "CDCOSTINGTYPE":z4037.cdCostingType = Children(i).Code
   Case "PRICE":z4037.Price = Children(i).Code
   Case "TOTALQTY":z4037.TotalQty = Children(i).Code
   Case "TOTALAMT":z4037.TotalAMT = Children(i).Code
   Case "INSERTDATE":z4037.InsertDate = Children(i).Code
   Case "INCHARGEINSERT":z4037.InchargeInsert = Children(i).Code
   Case "UPDATEDATE":z4037.UpdateDate = Children(i).Code
   Case "INCHARGEUPDATE":z4037.InchargeUpdate = Children(i).Code
   Case "ATTACHID":z4037.AttachID = Children(i).Code
   Case "REMARKORDER":z4037.RemarkOrder = Children(i).Code
   Case "REMARKCUSTOMER":z4037.RemarkCustomer = Children(i).Code
   Case "REMARK":z4037.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "WORKORDER":z4037.WorkOrder = Children(i).Data
   Case "WORKORDERSEQ":z4037.WorkOrderSeq = Children(i).Data
   Case "SALESCOSTSEQ":z4037.SalesCostSeq = Children(i).Data
   Case "STATUS":z4037.Status = Children(i).Data
   Case "SESALESCOST":z4037.seSalesCost = Children(i).Data
   Case "CDSALESCOST":z4037.cdSalesCost = Children(i).Data
   Case "SECOSTINGTYPE":z4037.seCostingType = Children(i).Data
   Case "CDCOSTINGTYPE":z4037.cdCostingType = Children(i).Data
   Case "PRICE":z4037.Price = Children(i).Data
   Case "TOTALQTY":z4037.TotalQty = Children(i).Data
   Case "TOTALAMT":z4037.TotalAMT = Children(i).Data
   Case "INSERTDATE":z4037.InsertDate = Children(i).Data
   Case "INCHARGEINSERT":z4037.InchargeInsert = Children(i).Data
   Case "UPDATEDATE":z4037.UpdateDate = Children(i).Data
   Case "INCHARGEUPDATE":z4037.InchargeUpdate = Children(i).Data
   Case "ATTACHID":z4037.AttachID = Children(i).Data
   Case "REMARKORDER":z4037.RemarkOrder = Children(i).Data
   Case "REMARKCUSTOMER":z4037.RemarkCustomer = Children(i).Data
   Case "REMARK":z4037.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K4037_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K4037_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z4037 As T4037_AREA, Job as String, CheckClear as Boolean, WORKORDER AS String, WORKORDERSEQ AS String, SALESCOSTSEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K4037_MOVE = False

Try
    If READ_PFK4037(WORKORDER, WORKORDERSEQ, SALESCOSTSEQ) = True Then
                z4037 = D4037
		K4037_MOVE = True
		else
	If CheckClear  = True then z4037 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4037")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "WORKORDER":z4037.WorkOrder = Children(i).Code
   Case "WORKORDERSEQ":z4037.WorkOrderSeq = Children(i).Code
   Case "SALESCOSTSEQ":z4037.SalesCostSeq = Children(i).Code
   Case "STATUS":z4037.Status = Children(i).Code
   Case "SESALESCOST":z4037.seSalesCost = Children(i).Code
   Case "CDSALESCOST":z4037.cdSalesCost = Children(i).Code
   Case "SECOSTINGTYPE":z4037.seCostingType = Children(i).Code
   Case "CDCOSTINGTYPE":z4037.cdCostingType = Children(i).Code
   Case "PRICE":z4037.Price = Children(i).Code
   Case "TOTALQTY":z4037.TotalQty = Children(i).Code
   Case "TOTALAMT":z4037.TotalAMT = Children(i).Code
   Case "INSERTDATE":z4037.InsertDate = Children(i).Code
   Case "INCHARGEINSERT":z4037.InchargeInsert = Children(i).Code
   Case "UPDATEDATE":z4037.UpdateDate = Children(i).Code
   Case "INCHARGEUPDATE":z4037.InchargeUpdate = Children(i).Code
   Case "ATTACHID":z4037.AttachID = Children(i).Code
   Case "REMARKORDER":z4037.RemarkOrder = Children(i).Code
   Case "REMARKCUSTOMER":z4037.RemarkCustomer = Children(i).Code
   Case "REMARK":z4037.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "WORKORDER":z4037.WorkOrder = Children(i).Data
   Case "WORKORDERSEQ":z4037.WorkOrderSeq = Children(i).Data
   Case "SALESCOSTSEQ":z4037.SalesCostSeq = Children(i).Data
   Case "STATUS":z4037.Status = Children(i).Data
   Case "SESALESCOST":z4037.seSalesCost = Children(i).Data
   Case "CDSALESCOST":z4037.cdSalesCost = Children(i).Data
   Case "SECOSTINGTYPE":z4037.seCostingType = Children(i).Data
   Case "CDCOSTINGTYPE":z4037.cdCostingType = Children(i).Data
   Case "PRICE":z4037.Price = Children(i).Data
   Case "TOTALQTY":z4037.TotalQty = Children(i).Data
   Case "TOTALAMT":z4037.TotalAMT = Children(i).Data
   Case "INSERTDATE":z4037.InsertDate = Children(i).Data
   Case "INCHARGEINSERT":z4037.InchargeInsert = Children(i).Data
   Case "UPDATEDATE":z4037.UpdateDate = Children(i).Data
   Case "INCHARGEUPDATE":z4037.InchargeUpdate = Children(i).Data
   Case "ATTACHID":z4037.AttachID = Children(i).Data
   Case "REMARKORDER":z4037.RemarkOrder = Children(i).Data
   Case "REMARKCUSTOMER":z4037.RemarkCustomer = Children(i).Data
   Case "REMARK":z4037.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K4037_MOVE",vbCritical)
End Try
End Function 
    
End Module 
