'=========================================================================================================================================================
'   TABLE : (PFK4020)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K4020

Structure T4020_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	WorkOrder	 AS String	'			char(9)		*
Public 	WorkOrderSeq	 AS String	'			char(3)		*
Public 	MaterialSeq	 AS Double	'			decimal		*
Public 	DSeq	 AS Double	'			decimal
Public 	Status	 AS String	'			char(1)
Public 	seGroupComponent	 AS String	'			char(3)
Public 	cdGroupComponent	 AS String	'			char(3)
Public 	ComponentName	 AS String	'			nvarchar(50)
Public 	MaterialCode	 AS String	'			char(6)
Public 	Description	 AS String	'			nvarchar(50)
Public 	Color	 AS String	'			nvarchar(50)
Public 	Specification	 AS String	'			nvarchar(20)
Public 	Width	 AS String	'			nvarchar(20)
Public 	Height	 AS String	'			nvarchar(20)
Public 	SizeName	 AS String	'			nvarchar(20)
Public 	ColorName	 AS String	'			nvarchar(30)
Public 	seUnitMaterial	 AS String	'			char(3)
Public 	cdUnitmaterial	 AS String	'			char(3)
Public 	seShoesStatus	 AS String	'			char(3)
Public 	cdShoesStatus	 AS String	'			char(3)
Public 	seDepartment	 AS String	'			char(3)
Public 	cdDepartment	 AS String	'			char(3)
Public 	SupplierCode	 AS String	'			char(8)
Public 	MaterialPrice	 AS Double	'			decimal
Public 	seUnitPrice	 AS String	'			char(3)
Public 	cdUnitPrice	 AS String	'			char(3)
Public 	QtyComponent	 AS Double	'			decimal
Public 	Consumption	 AS Double	'			decimal
Public 	Loss	 AS Double	'			decimal
Public 	GrossUsage	 AS Double	'			decimal
Public 	MaterialAMT	 AS Double	'			decimal
Public 	TotalQty	 AS Double	'			decimal
Public 	TotalMaterialAMT	 AS Double	'			decimal
Public 	InsertDate	 AS String	'			char(8)
Public 	InchargeInsert	 AS String	'			char(8)
Public 	UpdateDate	 AS String	'			char(8)
Public 	InchargeUpdate	 AS String	'			char(8)
Public 	AttachID	 AS String	'			char(6)
Public 	seSubProcess	 AS String	'			char(3)
Public 	cdSubProcess	 AS String	'			char(3)
Public 	Remark	 AS String	'			nvarchar(50)
'=========================================================================================================================================================
End structure

Public D4020 As T4020_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK4020(WORKORDER AS String, WORKORDERSEQ AS String, MATERIALSEQ AS Double) As Boolean
    READ_PFK4020 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK4020 "
    SQL = SQL & " WHERE K4020_WorkOrder		 = '" & WorkOrder & "' " 
    SQL = SQL & "   AND K4020_WorkOrderSeq		 = '" & WorkOrderSeq & "' " 
    SQL = SQL & "   AND K4020_MaterialSeq		 =  " & MaterialSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D4020_CLEAR: GoTo SKIP_READ_PFK4020
                
    Call K4020_MOVE(rd)
    READ_PFK4020 = True

SKIP_READ_PFK4020:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK4020",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK4020(WORKORDER AS String, WORKORDERSEQ AS String, MATERIALSEQ AS Double, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK4020 "
    SQL = SQL & " WHERE K4020_WorkOrder		 = '" & WorkOrder & "' " 
    SQL = SQL & "   AND K4020_WorkOrderSeq		 = '" & WorkOrderSeq & "' " 
    SQL = SQL & "   AND K4020_MaterialSeq		 =  " & MaterialSeq & "  " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK4020",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK4020(z4020 As T4020_AREA) As Boolean
    WRITE_PFK4020 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z4020)
 
    SQL = " INSERT INTO PFK4020 "
    SQL = SQL & " ( "
    SQL = SQL & " K4020_WorkOrder," 
    SQL = SQL & " K4020_WorkOrderSeq," 
    SQL = SQL & " K4020_MaterialSeq," 
    SQL = SQL & " K4020_DSeq," 
    SQL = SQL & " K4020_Status," 
    SQL = SQL & " K4020_seGroupComponent," 
    SQL = SQL & " K4020_cdGroupComponent," 
    SQL = SQL & " K4020_ComponentName," 
    SQL = SQL & " K4020_MaterialCode," 
    SQL = SQL & " K4020_Description," 
    SQL = SQL & " K4020_Color," 
    SQL = SQL & " K4020_Specification," 
    SQL = SQL & " K4020_Width," 
    SQL = SQL & " K4020_Height," 
    SQL = SQL & " K4020_SizeName," 
    SQL = SQL & " K4020_ColorName," 
    SQL = SQL & " K4020_seUnitMaterial," 
    SQL = SQL & " K4020_cdUnitmaterial," 
    SQL = SQL & " K4020_seShoesStatus," 
    SQL = SQL & " K4020_cdShoesStatus," 
    SQL = SQL & " K4020_seDepartment," 
    SQL = SQL & " K4020_cdDepartment," 
    SQL = SQL & " K4020_SupplierCode," 
    SQL = SQL & " K4020_MaterialPrice," 
    SQL = SQL & " K4020_seUnitPrice," 
    SQL = SQL & " K4020_cdUnitPrice," 
    SQL = SQL & " K4020_QtyComponent," 
    SQL = SQL & " K4020_Consumption," 
    SQL = SQL & " K4020_Loss," 
    SQL = SQL & " K4020_GrossUsage," 
    SQL = SQL & " K4020_MaterialAMT," 
    SQL = SQL & " K4020_TotalQty," 
    SQL = SQL & " K4020_TotalMaterialAMT," 
    SQL = SQL & " K4020_InsertDate," 
    SQL = SQL & " K4020_InchargeInsert," 
    SQL = SQL & " K4020_UpdateDate," 
    SQL = SQL & " K4020_InchargeUpdate," 
    SQL = SQL & " K4020_AttachID," 
    SQL = SQL & " K4020_seSubProcess," 
    SQL = SQL & " K4020_cdSubProcess," 
    SQL = SQL & " K4020_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z4020.WorkOrder) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4020.WorkOrderSeq) & "', "  
    SQL = SQL & "   " & FormatSQL(z4020.MaterialSeq) & ", "  
    SQL = SQL & "   " & FormatSQL(z4020.DSeq) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z4020.Status) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4020.seGroupComponent) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4020.cdGroupComponent) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4020.ComponentName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4020.MaterialCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4020.Description) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4020.Color) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4020.Specification) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4020.Width) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4020.Height) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4020.SizeName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4020.ColorName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4020.seUnitMaterial) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4020.cdUnitmaterial) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4020.seShoesStatus) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4020.cdShoesStatus) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4020.seDepartment) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4020.cdDepartment) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4020.SupplierCode) & "', "  
    SQL = SQL & "   " & FormatSQL(z4020.MaterialPrice) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z4020.seUnitPrice) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4020.cdUnitPrice) & "', "  
    SQL = SQL & "   " & FormatSQL(z4020.QtyComponent) & ", "  
    SQL = SQL & "   " & FormatSQL(z4020.Consumption) & ", "  
    SQL = SQL & "   " & FormatSQL(z4020.Loss) & ", "  
    SQL = SQL & "   " & FormatSQL(z4020.GrossUsage) & ", "  
    SQL = SQL & "   " & FormatSQL(z4020.MaterialAMT) & ", "  
    SQL = SQL & "   " & FormatSQL(z4020.TotalQty) & ", "  
    SQL = SQL & "   " & FormatSQL(z4020.TotalMaterialAMT) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z4020.InsertDate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4020.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4020.UpdateDate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4020.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4020.AttachID) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4020.seSubProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4020.cdSubProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4020.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK4020 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK4020",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK4020(z4020 As T4020_AREA) As Boolean
    REWRITE_PFK4020 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z4020)
   
    SQL = " UPDATE PFK4020 SET "
    SQL = SQL & "    K4020_DSeq      =  " & FormatSQL(z4020.DSeq) & ", " 
    SQL = SQL & "    K4020_Status      = N'" & FormatSQL(z4020.Status) & "', " 
    SQL = SQL & "    K4020_seGroupComponent      = N'" & FormatSQL(z4020.seGroupComponent) & "', " 
    SQL = SQL & "    K4020_cdGroupComponent      = N'" & FormatSQL(z4020.cdGroupComponent) & "', " 
    SQL = SQL & "    K4020_ComponentName      = N'" & FormatSQL(z4020.ComponentName) & "', " 
    SQL = SQL & "    K4020_MaterialCode      = N'" & FormatSQL(z4020.MaterialCode) & "', " 
    SQL = SQL & "    K4020_Description      = N'" & FormatSQL(z4020.Description) & "', " 
    SQL = SQL & "    K4020_Color      = N'" & FormatSQL(z4020.Color) & "', " 
    SQL = SQL & "    K4020_Specification      = N'" & FormatSQL(z4020.Specification) & "', " 
    SQL = SQL & "    K4020_Width      = N'" & FormatSQL(z4020.Width) & "', " 
    SQL = SQL & "    K4020_Height      = N'" & FormatSQL(z4020.Height) & "', " 
    SQL = SQL & "    K4020_SizeName      = N'" & FormatSQL(z4020.SizeName) & "', " 
    SQL = SQL & "    K4020_ColorName      = N'" & FormatSQL(z4020.ColorName) & "', " 
    SQL = SQL & "    K4020_seUnitMaterial      = N'" & FormatSQL(z4020.seUnitMaterial) & "', " 
    SQL = SQL & "    K4020_cdUnitmaterial      = N'" & FormatSQL(z4020.cdUnitmaterial) & "', " 
    SQL = SQL & "    K4020_seShoesStatus      = N'" & FormatSQL(z4020.seShoesStatus) & "', " 
    SQL = SQL & "    K4020_cdShoesStatus      = N'" & FormatSQL(z4020.cdShoesStatus) & "', " 
    SQL = SQL & "    K4020_seDepartment      = N'" & FormatSQL(z4020.seDepartment) & "', " 
    SQL = SQL & "    K4020_cdDepartment      = N'" & FormatSQL(z4020.cdDepartment) & "', " 
    SQL = SQL & "    K4020_SupplierCode      = N'" & FormatSQL(z4020.SupplierCode) & "', " 
    SQL = SQL & "    K4020_MaterialPrice      =  " & FormatSQL(z4020.MaterialPrice) & ", " 
    SQL = SQL & "    K4020_seUnitPrice      = N'" & FormatSQL(z4020.seUnitPrice) & "', " 
    SQL = SQL & "    K4020_cdUnitPrice      = N'" & FormatSQL(z4020.cdUnitPrice) & "', " 
    SQL = SQL & "    K4020_QtyComponent      =  " & FormatSQL(z4020.QtyComponent) & ", " 
    SQL = SQL & "    K4020_Consumption      =  " & FormatSQL(z4020.Consumption) & ", " 
    SQL = SQL & "    K4020_Loss      =  " & FormatSQL(z4020.Loss) & ", " 
    SQL = SQL & "    K4020_GrossUsage      =  " & FormatSQL(z4020.GrossUsage) & ", " 
    SQL = SQL & "    K4020_MaterialAMT      =  " & FormatSQL(z4020.MaterialAMT) & ", " 
    SQL = SQL & "    K4020_TotalQty      =  " & FormatSQL(z4020.TotalQty) & ", " 
    SQL = SQL & "    K4020_TotalMaterialAMT      =  " & FormatSQL(z4020.TotalMaterialAMT) & ", " 
    SQL = SQL & "    K4020_InsertDate      = N'" & FormatSQL(z4020.InsertDate) & "', " 
    SQL = SQL & "    K4020_InchargeInsert      = N'" & FormatSQL(z4020.InchargeInsert) & "', " 
    SQL = SQL & "    K4020_UpdateDate      = N'" & FormatSQL(z4020.UpdateDate) & "', " 
    SQL = SQL & "    K4020_InchargeUpdate      = N'" & FormatSQL(z4020.InchargeUpdate) & "', " 
    SQL = SQL & "    K4020_AttachID      = N'" & FormatSQL(z4020.AttachID) & "', " 
    SQL = SQL & "    K4020_seSubProcess      = N'" & FormatSQL(z4020.seSubProcess) & "', " 
    SQL = SQL & "    K4020_cdSubProcess      = N'" & FormatSQL(z4020.cdSubProcess) & "', " 
    SQL = SQL & "    K4020_Remark      = N'" & FormatSQL(z4020.Remark) & "'  " 
    SQL = SQL & " WHERE K4020_WorkOrder		 = '" & z4020.WorkOrder & "' " 
    SQL = SQL & "   AND K4020_WorkOrderSeq		 = '" & z4020.WorkOrderSeq & "' " 
    SQL = SQL & "   AND K4020_MaterialSeq		 =  " & z4020.MaterialSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK4020 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK4020",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK4020(z4020 As T4020_AREA) As Boolean
    DELETE_PFK4020 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK4020 "
    SQL = SQL & " WHERE K4020_WorkOrder		 = '" & z4020.WorkOrder & "' " 
    SQL = SQL & "   AND K4020_WorkOrderSeq		 = '" & z4020.WorkOrderSeq & "' " 
    SQL = SQL & "   AND K4020_MaterialSeq		 =  " & z4020.MaterialSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK4020 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK4020",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D4020_CLEAR()
Try
    
   D4020.WorkOrder = ""
   D4020.WorkOrderSeq = ""
    D4020.MaterialSeq = 0 
    D4020.DSeq = 0 
   D4020.Status = ""
   D4020.seGroupComponent = ""
   D4020.cdGroupComponent = ""
   D4020.ComponentName = ""
   D4020.MaterialCode = ""
   D4020.Description = ""
   D4020.Color = ""
   D4020.Specification = ""
   D4020.Width = ""
   D4020.Height = ""
   D4020.SizeName = ""
   D4020.ColorName = ""
   D4020.seUnitMaterial = ""
   D4020.cdUnitmaterial = ""
   D4020.seShoesStatus = ""
   D4020.cdShoesStatus = ""
   D4020.seDepartment = ""
   D4020.cdDepartment = ""
   D4020.SupplierCode = ""
    D4020.MaterialPrice = 0 
   D4020.seUnitPrice = ""
   D4020.cdUnitPrice = ""
    D4020.QtyComponent = 0 
    D4020.Consumption = 0 
    D4020.Loss = 0 
    D4020.GrossUsage = 0 
    D4020.MaterialAMT = 0 
    D4020.TotalQty = 0 
    D4020.TotalMaterialAMT = 0 
   D4020.InsertDate = ""
   D4020.InchargeInsert = ""
   D4020.UpdateDate = ""
   D4020.InchargeUpdate = ""
   D4020.AttachID = ""
   D4020.seSubProcess = ""
   D4020.cdSubProcess = ""
   D4020.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D4020_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x4020 As T4020_AREA)
Try
    
    x4020.WorkOrder = trim$(  x4020.WorkOrder)
    x4020.WorkOrderSeq = trim$(  x4020.WorkOrderSeq)
    x4020.MaterialSeq = trim$(  x4020.MaterialSeq)
    x4020.DSeq = trim$(  x4020.DSeq)
    x4020.Status = trim$(  x4020.Status)
    x4020.seGroupComponent = trim$(  x4020.seGroupComponent)
    x4020.cdGroupComponent = trim$(  x4020.cdGroupComponent)
    x4020.ComponentName = trim$(  x4020.ComponentName)
    x4020.MaterialCode = trim$(  x4020.MaterialCode)
    x4020.Description = trim$(  x4020.Description)
    x4020.Color = trim$(  x4020.Color)
    x4020.Specification = trim$(  x4020.Specification)
    x4020.Width = trim$(  x4020.Width)
    x4020.Height = trim$(  x4020.Height)
    x4020.SizeName = trim$(  x4020.SizeName)
    x4020.ColorName = trim$(  x4020.ColorName)
    x4020.seUnitMaterial = trim$(  x4020.seUnitMaterial)
    x4020.cdUnitmaterial = trim$(  x4020.cdUnitmaterial)
    x4020.seShoesStatus = trim$(  x4020.seShoesStatus)
    x4020.cdShoesStatus = trim$(  x4020.cdShoesStatus)
    x4020.seDepartment = trim$(  x4020.seDepartment)
    x4020.cdDepartment = trim$(  x4020.cdDepartment)
    x4020.SupplierCode = trim$(  x4020.SupplierCode)
    x4020.MaterialPrice = trim$(  x4020.MaterialPrice)
    x4020.seUnitPrice = trim$(  x4020.seUnitPrice)
    x4020.cdUnitPrice = trim$(  x4020.cdUnitPrice)
    x4020.QtyComponent = trim$(  x4020.QtyComponent)
    x4020.Consumption = trim$(  x4020.Consumption)
    x4020.Loss = trim$(  x4020.Loss)
    x4020.GrossUsage = trim$(  x4020.GrossUsage)
    x4020.MaterialAMT = trim$(  x4020.MaterialAMT)
    x4020.TotalQty = trim$(  x4020.TotalQty)
    x4020.TotalMaterialAMT = trim$(  x4020.TotalMaterialAMT)
    x4020.InsertDate = trim$(  x4020.InsertDate)
    x4020.InchargeInsert = trim$(  x4020.InchargeInsert)
    x4020.UpdateDate = trim$(  x4020.UpdateDate)
    x4020.InchargeUpdate = trim$(  x4020.InchargeUpdate)
    x4020.AttachID = trim$(  x4020.AttachID)
    x4020.seSubProcess = trim$(  x4020.seSubProcess)
    x4020.cdSubProcess = trim$(  x4020.cdSubProcess)
    x4020.Remark = trim$(  x4020.Remark)
     
    If trim$( x4020.WorkOrder ) = "" Then x4020.WorkOrder = Space(1) 
    If trim$( x4020.WorkOrderSeq ) = "" Then x4020.WorkOrderSeq = Space(1) 
    If trim$( x4020.MaterialSeq ) = "" Then x4020.MaterialSeq = 0 
    If trim$( x4020.DSeq ) = "" Then x4020.DSeq = 0 
    If trim$( x4020.Status ) = "" Then x4020.Status = Space(1) 
    If trim$( x4020.seGroupComponent ) = "" Then x4020.seGroupComponent = Space(1) 
    If trim$( x4020.cdGroupComponent ) = "" Then x4020.cdGroupComponent = Space(1) 
    If trim$( x4020.ComponentName ) = "" Then x4020.ComponentName = Space(1) 
    If trim$( x4020.MaterialCode ) = "" Then x4020.MaterialCode = Space(1) 
    If trim$( x4020.Description ) = "" Then x4020.Description = Space(1) 
    If trim$( x4020.Color ) = "" Then x4020.Color = Space(1) 
    If trim$( x4020.Specification ) = "" Then x4020.Specification = Space(1) 
    If trim$( x4020.Width ) = "" Then x4020.Width = Space(1) 
    If trim$( x4020.Height ) = "" Then x4020.Height = Space(1) 
    If trim$( x4020.SizeName ) = "" Then x4020.SizeName = Space(1) 
    If trim$( x4020.ColorName ) = "" Then x4020.ColorName = Space(1) 
    If trim$( x4020.seUnitMaterial ) = "" Then x4020.seUnitMaterial = Space(1) 
    If trim$( x4020.cdUnitmaterial ) = "" Then x4020.cdUnitmaterial = Space(1) 
    If trim$( x4020.seShoesStatus ) = "" Then x4020.seShoesStatus = Space(1) 
    If trim$( x4020.cdShoesStatus ) = "" Then x4020.cdShoesStatus = Space(1) 
    If trim$( x4020.seDepartment ) = "" Then x4020.seDepartment = Space(1) 
    If trim$( x4020.cdDepartment ) = "" Then x4020.cdDepartment = Space(1) 
    If trim$( x4020.SupplierCode ) = "" Then x4020.SupplierCode = Space(1) 
    If trim$( x4020.MaterialPrice ) = "" Then x4020.MaterialPrice = 0 
    If trim$( x4020.seUnitPrice ) = "" Then x4020.seUnitPrice = Space(1) 
    If trim$( x4020.cdUnitPrice ) = "" Then x4020.cdUnitPrice = Space(1) 
    If trim$( x4020.QtyComponent ) = "" Then x4020.QtyComponent = 0 
    If trim$( x4020.Consumption ) = "" Then x4020.Consumption = 0 
    If trim$( x4020.Loss ) = "" Then x4020.Loss = 0 
    If trim$( x4020.GrossUsage ) = "" Then x4020.GrossUsage = 0 
    If trim$( x4020.MaterialAMT ) = "" Then x4020.MaterialAMT = 0 
    If trim$( x4020.TotalQty ) = "" Then x4020.TotalQty = 0 
    If trim$( x4020.TotalMaterialAMT ) = "" Then x4020.TotalMaterialAMT = 0 
    If trim$( x4020.InsertDate ) = "" Then x4020.InsertDate = Space(1) 
    If trim$( x4020.InchargeInsert ) = "" Then x4020.InchargeInsert = Space(1) 
    If trim$( x4020.UpdateDate ) = "" Then x4020.UpdateDate = Space(1) 
    If trim$( x4020.InchargeUpdate ) = "" Then x4020.InchargeUpdate = Space(1) 
    If trim$( x4020.AttachID ) = "" Then x4020.AttachID = Space(1) 
    If trim$( x4020.seSubProcess ) = "" Then x4020.seSubProcess = Space(1) 
    If trim$( x4020.cdSubProcess ) = "" Then x4020.cdSubProcess = Space(1) 
    If trim$( x4020.Remark ) = "" Then x4020.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K4020_MOVE(rs4020 As SqlClient.SqlDataReader)
Try

    call D4020_CLEAR()   

    If IsdbNull(rs4020!K4020_WorkOrder) = False Then D4020.WorkOrder = Trim$(rs4020!K4020_WorkOrder)
    If IsdbNull(rs4020!K4020_WorkOrderSeq) = False Then D4020.WorkOrderSeq = Trim$(rs4020!K4020_WorkOrderSeq)
    If IsdbNull(rs4020!K4020_MaterialSeq) = False Then D4020.MaterialSeq = Trim$(rs4020!K4020_MaterialSeq)
    If IsdbNull(rs4020!K4020_DSeq) = False Then D4020.DSeq = Trim$(rs4020!K4020_DSeq)
    If IsdbNull(rs4020!K4020_Status) = False Then D4020.Status = Trim$(rs4020!K4020_Status)
    If IsdbNull(rs4020!K4020_seGroupComponent) = False Then D4020.seGroupComponent = Trim$(rs4020!K4020_seGroupComponent)
    If IsdbNull(rs4020!K4020_cdGroupComponent) = False Then D4020.cdGroupComponent = Trim$(rs4020!K4020_cdGroupComponent)
    If IsdbNull(rs4020!K4020_ComponentName) = False Then D4020.ComponentName = Trim$(rs4020!K4020_ComponentName)
    If IsdbNull(rs4020!K4020_MaterialCode) = False Then D4020.MaterialCode = Trim$(rs4020!K4020_MaterialCode)
    If IsdbNull(rs4020!K4020_Description) = False Then D4020.Description = Trim$(rs4020!K4020_Description)
    If IsdbNull(rs4020!K4020_Color) = False Then D4020.Color = Trim$(rs4020!K4020_Color)
    If IsdbNull(rs4020!K4020_Specification) = False Then D4020.Specification = Trim$(rs4020!K4020_Specification)
    If IsdbNull(rs4020!K4020_Width) = False Then D4020.Width = Trim$(rs4020!K4020_Width)
    If IsdbNull(rs4020!K4020_Height) = False Then D4020.Height = Trim$(rs4020!K4020_Height)
    If IsdbNull(rs4020!K4020_SizeName) = False Then D4020.SizeName = Trim$(rs4020!K4020_SizeName)
    If IsdbNull(rs4020!K4020_ColorName) = False Then D4020.ColorName = Trim$(rs4020!K4020_ColorName)
    If IsdbNull(rs4020!K4020_seUnitMaterial) = False Then D4020.seUnitMaterial = Trim$(rs4020!K4020_seUnitMaterial)
    If IsdbNull(rs4020!K4020_cdUnitmaterial) = False Then D4020.cdUnitmaterial = Trim$(rs4020!K4020_cdUnitmaterial)
    If IsdbNull(rs4020!K4020_seShoesStatus) = False Then D4020.seShoesStatus = Trim$(rs4020!K4020_seShoesStatus)
    If IsdbNull(rs4020!K4020_cdShoesStatus) = False Then D4020.cdShoesStatus = Trim$(rs4020!K4020_cdShoesStatus)
    If IsdbNull(rs4020!K4020_seDepartment) = False Then D4020.seDepartment = Trim$(rs4020!K4020_seDepartment)
    If IsdbNull(rs4020!K4020_cdDepartment) = False Then D4020.cdDepartment = Trim$(rs4020!K4020_cdDepartment)
    If IsdbNull(rs4020!K4020_SupplierCode) = False Then D4020.SupplierCode = Trim$(rs4020!K4020_SupplierCode)
    If IsdbNull(rs4020!K4020_MaterialPrice) = False Then D4020.MaterialPrice = Trim$(rs4020!K4020_MaterialPrice)
    If IsdbNull(rs4020!K4020_seUnitPrice) = False Then D4020.seUnitPrice = Trim$(rs4020!K4020_seUnitPrice)
    If IsdbNull(rs4020!K4020_cdUnitPrice) = False Then D4020.cdUnitPrice = Trim$(rs4020!K4020_cdUnitPrice)
    If IsdbNull(rs4020!K4020_QtyComponent) = False Then D4020.QtyComponent = Trim$(rs4020!K4020_QtyComponent)
    If IsdbNull(rs4020!K4020_Consumption) = False Then D4020.Consumption = Trim$(rs4020!K4020_Consumption)
    If IsdbNull(rs4020!K4020_Loss) = False Then D4020.Loss = Trim$(rs4020!K4020_Loss)
    If IsdbNull(rs4020!K4020_GrossUsage) = False Then D4020.GrossUsage = Trim$(rs4020!K4020_GrossUsage)
    If IsdbNull(rs4020!K4020_MaterialAMT) = False Then D4020.MaterialAMT = Trim$(rs4020!K4020_MaterialAMT)
    If IsdbNull(rs4020!K4020_TotalQty) = False Then D4020.TotalQty = Trim$(rs4020!K4020_TotalQty)
    If IsdbNull(rs4020!K4020_TotalMaterialAMT) = False Then D4020.TotalMaterialAMT = Trim$(rs4020!K4020_TotalMaterialAMT)
    If IsdbNull(rs4020!K4020_InsertDate) = False Then D4020.InsertDate = Trim$(rs4020!K4020_InsertDate)
    If IsdbNull(rs4020!K4020_InchargeInsert) = False Then D4020.InchargeInsert = Trim$(rs4020!K4020_InchargeInsert)
    If IsdbNull(rs4020!K4020_UpdateDate) = False Then D4020.UpdateDate = Trim$(rs4020!K4020_UpdateDate)
    If IsdbNull(rs4020!K4020_InchargeUpdate) = False Then D4020.InchargeUpdate = Trim$(rs4020!K4020_InchargeUpdate)
    If IsdbNull(rs4020!K4020_AttachID) = False Then D4020.AttachID = Trim$(rs4020!K4020_AttachID)
    If IsdbNull(rs4020!K4020_seSubProcess) = False Then D4020.seSubProcess = Trim$(rs4020!K4020_seSubProcess)
    If IsdbNull(rs4020!K4020_cdSubProcess) = False Then D4020.cdSubProcess = Trim$(rs4020!K4020_cdSubProcess)
    If IsdbNull(rs4020!K4020_Remark) = False Then D4020.Remark = Trim$(rs4020!K4020_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K4020_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K4020_MOVE(rs4020 As DataRow)
Try

    call D4020_CLEAR()   

    If IsdbNull(rs4020!K4020_WorkOrder) = False Then D4020.WorkOrder = Trim$(rs4020!K4020_WorkOrder)
    If IsdbNull(rs4020!K4020_WorkOrderSeq) = False Then D4020.WorkOrderSeq = Trim$(rs4020!K4020_WorkOrderSeq)
    If IsdbNull(rs4020!K4020_MaterialSeq) = False Then D4020.MaterialSeq = Trim$(rs4020!K4020_MaterialSeq)
    If IsdbNull(rs4020!K4020_DSeq) = False Then D4020.DSeq = Trim$(rs4020!K4020_DSeq)
    If IsdbNull(rs4020!K4020_Status) = False Then D4020.Status = Trim$(rs4020!K4020_Status)
    If IsdbNull(rs4020!K4020_seGroupComponent) = False Then D4020.seGroupComponent = Trim$(rs4020!K4020_seGroupComponent)
    If IsdbNull(rs4020!K4020_cdGroupComponent) = False Then D4020.cdGroupComponent = Trim$(rs4020!K4020_cdGroupComponent)
    If IsdbNull(rs4020!K4020_ComponentName) = False Then D4020.ComponentName = Trim$(rs4020!K4020_ComponentName)
    If IsdbNull(rs4020!K4020_MaterialCode) = False Then D4020.MaterialCode = Trim$(rs4020!K4020_MaterialCode)
    If IsdbNull(rs4020!K4020_Description) = False Then D4020.Description = Trim$(rs4020!K4020_Description)
    If IsdbNull(rs4020!K4020_Color) = False Then D4020.Color = Trim$(rs4020!K4020_Color)
    If IsdbNull(rs4020!K4020_Specification) = False Then D4020.Specification = Trim$(rs4020!K4020_Specification)
    If IsdbNull(rs4020!K4020_Width) = False Then D4020.Width = Trim$(rs4020!K4020_Width)
    If IsdbNull(rs4020!K4020_Height) = False Then D4020.Height = Trim$(rs4020!K4020_Height)
    If IsdbNull(rs4020!K4020_SizeName) = False Then D4020.SizeName = Trim$(rs4020!K4020_SizeName)
    If IsdbNull(rs4020!K4020_ColorName) = False Then D4020.ColorName = Trim$(rs4020!K4020_ColorName)
    If IsdbNull(rs4020!K4020_seUnitMaterial) = False Then D4020.seUnitMaterial = Trim$(rs4020!K4020_seUnitMaterial)
    If IsdbNull(rs4020!K4020_cdUnitmaterial) = False Then D4020.cdUnitmaterial = Trim$(rs4020!K4020_cdUnitmaterial)
    If IsdbNull(rs4020!K4020_seShoesStatus) = False Then D4020.seShoesStatus = Trim$(rs4020!K4020_seShoesStatus)
    If IsdbNull(rs4020!K4020_cdShoesStatus) = False Then D4020.cdShoesStatus = Trim$(rs4020!K4020_cdShoesStatus)
    If IsdbNull(rs4020!K4020_seDepartment) = False Then D4020.seDepartment = Trim$(rs4020!K4020_seDepartment)
    If IsdbNull(rs4020!K4020_cdDepartment) = False Then D4020.cdDepartment = Trim$(rs4020!K4020_cdDepartment)
    If IsdbNull(rs4020!K4020_SupplierCode) = False Then D4020.SupplierCode = Trim$(rs4020!K4020_SupplierCode)
    If IsdbNull(rs4020!K4020_MaterialPrice) = False Then D4020.MaterialPrice = Trim$(rs4020!K4020_MaterialPrice)
    If IsdbNull(rs4020!K4020_seUnitPrice) = False Then D4020.seUnitPrice = Trim$(rs4020!K4020_seUnitPrice)
    If IsdbNull(rs4020!K4020_cdUnitPrice) = False Then D4020.cdUnitPrice = Trim$(rs4020!K4020_cdUnitPrice)
    If IsdbNull(rs4020!K4020_QtyComponent) = False Then D4020.QtyComponent = Trim$(rs4020!K4020_QtyComponent)
    If IsdbNull(rs4020!K4020_Consumption) = False Then D4020.Consumption = Trim$(rs4020!K4020_Consumption)
    If IsdbNull(rs4020!K4020_Loss) = False Then D4020.Loss = Trim$(rs4020!K4020_Loss)
    If IsdbNull(rs4020!K4020_GrossUsage) = False Then D4020.GrossUsage = Trim$(rs4020!K4020_GrossUsage)
    If IsdbNull(rs4020!K4020_MaterialAMT) = False Then D4020.MaterialAMT = Trim$(rs4020!K4020_MaterialAMT)
    If IsdbNull(rs4020!K4020_TotalQty) = False Then D4020.TotalQty = Trim$(rs4020!K4020_TotalQty)
    If IsdbNull(rs4020!K4020_TotalMaterialAMT) = False Then D4020.TotalMaterialAMT = Trim$(rs4020!K4020_TotalMaterialAMT)
    If IsdbNull(rs4020!K4020_InsertDate) = False Then D4020.InsertDate = Trim$(rs4020!K4020_InsertDate)
    If IsdbNull(rs4020!K4020_InchargeInsert) = False Then D4020.InchargeInsert = Trim$(rs4020!K4020_InchargeInsert)
    If IsdbNull(rs4020!K4020_UpdateDate) = False Then D4020.UpdateDate = Trim$(rs4020!K4020_UpdateDate)
    If IsdbNull(rs4020!K4020_InchargeUpdate) = False Then D4020.InchargeUpdate = Trim$(rs4020!K4020_InchargeUpdate)
    If IsdbNull(rs4020!K4020_AttachID) = False Then D4020.AttachID = Trim$(rs4020!K4020_AttachID)
    If IsdbNull(rs4020!K4020_seSubProcess) = False Then D4020.seSubProcess = Trim$(rs4020!K4020_seSubProcess)
    If IsdbNull(rs4020!K4020_cdSubProcess) = False Then D4020.cdSubProcess = Trim$(rs4020!K4020_cdSubProcess)
    If IsdbNull(rs4020!K4020_Remark) = False Then D4020.Remark = Trim$(rs4020!K4020_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K4020_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K4020_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z4020 As T4020_AREA, WORKORDER AS String, WORKORDERSEQ AS String, MATERIALSEQ AS Double) as Boolean

K4020_MOVE = False

Try
    If READ_PFK4020(WORKORDER, WORKORDERSEQ, MATERIALSEQ) = True Then
                z4020 = D4020
		K4020_MOVE = True
		else
	z4020 = nothing
     End If

     If  getColumIndex(spr,"WorkOrder") > -1 then z4020.WorkOrder = getDataM(spr, getColumIndex(spr,"WorkOrder"), xRow)
     If  getColumIndex(spr,"WorkOrderSeq") > -1 then z4020.WorkOrderSeq = getDataM(spr, getColumIndex(spr,"WorkOrderSeq"), xRow)
     If  getColumIndex(spr,"MaterialSeq") > -1 then z4020.MaterialSeq = getDataM(spr, getColumIndex(spr,"MaterialSeq"), xRow)
     If  getColumIndex(spr,"DSeq") > -1 then z4020.DSeq = getDataM(spr, getColumIndex(spr,"DSeq"), xRow)
     If  getColumIndex(spr,"Status") > -1 then z4020.Status = getDataM(spr, getColumIndex(spr,"Status"), xRow)
     If  getColumIndex(spr,"seGroupComponent") > -1 then z4020.seGroupComponent = getDataM(spr, getColumIndex(spr,"seGroupComponent"), xRow)
     If  getColumIndex(spr,"cdGroupComponent") > -1 then z4020.cdGroupComponent = getDataM(spr, getColumIndex(spr,"cdGroupComponent"), xRow)
     If  getColumIndex(spr,"ComponentName") > -1 then z4020.ComponentName = getDataM(spr, getColumIndex(spr,"ComponentName"), xRow)
     If  getColumIndex(spr,"MaterialCode") > -1 then z4020.MaterialCode = getDataM(spr, getColumIndex(spr,"MaterialCode"), xRow)
     If  getColumIndex(spr,"Description") > -1 then z4020.Description = getDataM(spr, getColumIndex(spr,"Description"), xRow)
     If  getColumIndex(spr,"Color") > -1 then z4020.Color = getDataM(spr, getColumIndex(spr,"Color"), xRow)
     If  getColumIndex(spr,"Specification") > -1 then z4020.Specification = getDataM(spr, getColumIndex(spr,"Specification"), xRow)
     If  getColumIndex(spr,"Width") > -1 then z4020.Width = getDataM(spr, getColumIndex(spr,"Width"), xRow)
     If  getColumIndex(spr,"Height") > -1 then z4020.Height = getDataM(spr, getColumIndex(spr,"Height"), xRow)
     If  getColumIndex(spr,"SizeName") > -1 then z4020.SizeName = getDataM(spr, getColumIndex(spr,"SizeName"), xRow)
     If  getColumIndex(spr,"ColorName") > -1 then z4020.ColorName = getDataM(spr, getColumIndex(spr,"ColorName"), xRow)
     If  getColumIndex(spr,"seUnitMaterial") > -1 then z4020.seUnitMaterial = getDataM(spr, getColumIndex(spr,"seUnitMaterial"), xRow)
     If  getColumIndex(spr,"cdUnitmaterial") > -1 then z4020.cdUnitmaterial = getDataM(spr, getColumIndex(spr,"cdUnitmaterial"), xRow)
     If  getColumIndex(spr,"seShoesStatus") > -1 then z4020.seShoesStatus = getDataM(spr, getColumIndex(spr,"seShoesStatus"), xRow)
     If  getColumIndex(spr,"cdShoesStatus") > -1 then z4020.cdShoesStatus = getDataM(spr, getColumIndex(spr,"cdShoesStatus"), xRow)
     If  getColumIndex(spr,"seDepartment") > -1 then z4020.seDepartment = getDataM(spr, getColumIndex(spr,"seDepartment"), xRow)
     If  getColumIndex(spr,"cdDepartment") > -1 then z4020.cdDepartment = getDataM(spr, getColumIndex(spr,"cdDepartment"), xRow)
     If  getColumIndex(spr,"SupplierCode") > -1 then z4020.SupplierCode = getDataM(spr, getColumIndex(spr,"SupplierCode"), xRow)
     If  getColumIndex(spr,"MaterialPrice") > -1 then z4020.MaterialPrice = getDataM(spr, getColumIndex(spr,"MaterialPrice"), xRow)
     If  getColumIndex(spr,"seUnitPrice") > -1 then z4020.seUnitPrice = getDataM(spr, getColumIndex(spr,"seUnitPrice"), xRow)
     If  getColumIndex(spr,"cdUnitPrice") > -1 then z4020.cdUnitPrice = getDataM(spr, getColumIndex(spr,"cdUnitPrice"), xRow)
     If  getColumIndex(spr,"QtyComponent") > -1 then z4020.QtyComponent = getDataM(spr, getColumIndex(spr,"QtyComponent"), xRow)
     If  getColumIndex(spr,"Consumption") > -1 then z4020.Consumption = getDataM(spr, getColumIndex(spr,"Consumption"), xRow)
     If  getColumIndex(spr,"Loss") > -1 then z4020.Loss = getDataM(spr, getColumIndex(spr,"Loss"), xRow)
     If  getColumIndex(spr,"GrossUsage") > -1 then z4020.GrossUsage = getDataM(spr, getColumIndex(spr,"GrossUsage"), xRow)
     If  getColumIndex(spr,"MaterialAMT") > -1 then z4020.MaterialAMT = getDataM(spr, getColumIndex(spr,"MaterialAMT"), xRow)
     If  getColumIndex(spr,"TotalQty") > -1 then z4020.TotalQty = getDataM(spr, getColumIndex(spr,"TotalQty"), xRow)
     If  getColumIndex(spr,"TotalMaterialAMT") > -1 then z4020.TotalMaterialAMT = getDataM(spr, getColumIndex(spr,"TotalMaterialAMT"), xRow)
     If  getColumIndex(spr,"InsertDate") > -1 then z4020.InsertDate = getDataM(spr, getColumIndex(spr,"InsertDate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z4020.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"UpdateDate") > -1 then z4020.UpdateDate = getDataM(spr, getColumIndex(spr,"UpdateDate"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z4020.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"AttachID") > -1 then z4020.AttachID = getDataM(spr, getColumIndex(spr,"AttachID"), xRow)
     If  getColumIndex(spr,"seSubProcess") > -1 then z4020.seSubProcess = getDataM(spr, getColumIndex(spr,"seSubProcess"), xRow)
     If  getColumIndex(spr,"cdSubProcess") > -1 then z4020.cdSubProcess = getDataM(spr, getColumIndex(spr,"cdSubProcess"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z4020.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K4020_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K4020_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z4020 As T4020_AREA,CheckClear as Boolean,WORKORDER AS String, WORKORDERSEQ AS String, MATERIALSEQ AS Double) as Boolean

K4020_MOVE = False

Try
    If READ_PFK4020(WORKORDER, WORKORDERSEQ, MATERIALSEQ) = True Then
                z4020 = D4020
		K4020_MOVE = True
		else
	If CheckClear  = True then z4020 = nothing
     End If

     If  getColumIndex(spr,"WorkOrder") > -1 then z4020.WorkOrder = getDataM(spr, getColumIndex(spr,"WorkOrder"), xRow)
     If  getColumIndex(spr,"WorkOrderSeq") > -1 then z4020.WorkOrderSeq = getDataM(spr, getColumIndex(spr,"WorkOrderSeq"), xRow)
     If  getColumIndex(spr,"MaterialSeq") > -1 then z4020.MaterialSeq = getDataM(spr, getColumIndex(spr,"MaterialSeq"), xRow)
     If  getColumIndex(spr,"DSeq") > -1 then z4020.DSeq = getDataM(spr, getColumIndex(spr,"DSeq"), xRow)
     If  getColumIndex(spr,"Status") > -1 then z4020.Status = getDataM(spr, getColumIndex(spr,"Status"), xRow)
     If  getColumIndex(spr,"seGroupComponent") > -1 then z4020.seGroupComponent = getDataM(spr, getColumIndex(spr,"seGroupComponent"), xRow)
     If  getColumIndex(spr,"cdGroupComponent") > -1 then z4020.cdGroupComponent = getDataM(spr, getColumIndex(spr,"cdGroupComponent"), xRow)
     If  getColumIndex(spr,"ComponentName") > -1 then z4020.ComponentName = getDataM(spr, getColumIndex(spr,"ComponentName"), xRow)
     If  getColumIndex(spr,"MaterialCode") > -1 then z4020.MaterialCode = getDataM(spr, getColumIndex(spr,"MaterialCode"), xRow)
     If  getColumIndex(spr,"Description") > -1 then z4020.Description = getDataM(spr, getColumIndex(spr,"Description"), xRow)
     If  getColumIndex(spr,"Color") > -1 then z4020.Color = getDataM(spr, getColumIndex(spr,"Color"), xRow)
     If  getColumIndex(spr,"Specification") > -1 then z4020.Specification = getDataM(spr, getColumIndex(spr,"Specification"), xRow)
     If  getColumIndex(spr,"Width") > -1 then z4020.Width = getDataM(spr, getColumIndex(spr,"Width"), xRow)
     If  getColumIndex(spr,"Height") > -1 then z4020.Height = getDataM(spr, getColumIndex(spr,"Height"), xRow)
     If  getColumIndex(spr,"SizeName") > -1 then z4020.SizeName = getDataM(spr, getColumIndex(spr,"SizeName"), xRow)
     If  getColumIndex(spr,"ColorName") > -1 then z4020.ColorName = getDataM(spr, getColumIndex(spr,"ColorName"), xRow)
     If  getColumIndex(spr,"seUnitMaterial") > -1 then z4020.seUnitMaterial = getDataM(spr, getColumIndex(spr,"seUnitMaterial"), xRow)
     If  getColumIndex(spr,"cdUnitmaterial") > -1 then z4020.cdUnitmaterial = getDataM(spr, getColumIndex(spr,"cdUnitmaterial"), xRow)
     If  getColumIndex(spr,"seShoesStatus") > -1 then z4020.seShoesStatus = getDataM(spr, getColumIndex(spr,"seShoesStatus"), xRow)
     If  getColumIndex(spr,"cdShoesStatus") > -1 then z4020.cdShoesStatus = getDataM(spr, getColumIndex(spr,"cdShoesStatus"), xRow)
     If  getColumIndex(spr,"seDepartment") > -1 then z4020.seDepartment = getDataM(spr, getColumIndex(spr,"seDepartment"), xRow)
     If  getColumIndex(spr,"cdDepartment") > -1 then z4020.cdDepartment = getDataM(spr, getColumIndex(spr,"cdDepartment"), xRow)
     If  getColumIndex(spr,"SupplierCode") > -1 then z4020.SupplierCode = getDataM(spr, getColumIndex(spr,"SupplierCode"), xRow)
     If  getColumIndex(spr,"MaterialPrice") > -1 then z4020.MaterialPrice = getDataM(spr, getColumIndex(spr,"MaterialPrice"), xRow)
     If  getColumIndex(spr,"seUnitPrice") > -1 then z4020.seUnitPrice = getDataM(spr, getColumIndex(spr,"seUnitPrice"), xRow)
     If  getColumIndex(spr,"cdUnitPrice") > -1 then z4020.cdUnitPrice = getDataM(spr, getColumIndex(spr,"cdUnitPrice"), xRow)
     If  getColumIndex(spr,"QtyComponent") > -1 then z4020.QtyComponent = getDataM(spr, getColumIndex(spr,"QtyComponent"), xRow)
     If  getColumIndex(spr,"Consumption") > -1 then z4020.Consumption = getDataM(spr, getColumIndex(spr,"Consumption"), xRow)
     If  getColumIndex(spr,"Loss") > -1 then z4020.Loss = getDataM(spr, getColumIndex(spr,"Loss"), xRow)
     If  getColumIndex(spr,"GrossUsage") > -1 then z4020.GrossUsage = getDataM(spr, getColumIndex(spr,"GrossUsage"), xRow)
     If  getColumIndex(spr,"MaterialAMT") > -1 then z4020.MaterialAMT = getDataM(spr, getColumIndex(spr,"MaterialAMT"), xRow)
     If  getColumIndex(spr,"TotalQty") > -1 then z4020.TotalQty = getDataM(spr, getColumIndex(spr,"TotalQty"), xRow)
     If  getColumIndex(spr,"TotalMaterialAMT") > -1 then z4020.TotalMaterialAMT = getDataM(spr, getColumIndex(spr,"TotalMaterialAMT"), xRow)
     If  getColumIndex(spr,"InsertDate") > -1 then z4020.InsertDate = getDataM(spr, getColumIndex(spr,"InsertDate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z4020.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"UpdateDate") > -1 then z4020.UpdateDate = getDataM(spr, getColumIndex(spr,"UpdateDate"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z4020.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"AttachID") > -1 then z4020.AttachID = getDataM(spr, getColumIndex(spr,"AttachID"), xRow)
     If  getColumIndex(spr,"seSubProcess") > -1 then z4020.seSubProcess = getDataM(spr, getColumIndex(spr,"seSubProcess"), xRow)
     If  getColumIndex(spr,"cdSubProcess") > -1 then z4020.cdSubProcess = getDataM(spr, getColumIndex(spr,"cdSubProcess"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z4020.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K4020_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K4020_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z4020 As T4020_AREA, Job as String, WORKORDER AS String, WORKORDERSEQ AS String, MATERIALSEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K4020_MOVE = False

Try
    If READ_PFK4020(WORKORDER, WORKORDERSEQ, MATERIALSEQ) = True Then
                z4020 = D4020
		K4020_MOVE = True
		else
	z4020 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4020")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "WORKORDER":z4020.WorkOrder = Children(i).Code
   Case "WORKORDERSEQ":z4020.WorkOrderSeq = Children(i).Code
   Case "MATERIALSEQ":z4020.MaterialSeq = Children(i).Code
   Case "DSEQ":z4020.DSeq = Children(i).Code
   Case "STATUS":z4020.Status = Children(i).Code
   Case "SEGROUPCOMPONENT":z4020.seGroupComponent = Children(i).Code
   Case "CDGROUPCOMPONENT":z4020.cdGroupComponent = Children(i).Code
   Case "COMPONENTNAME":z4020.ComponentName = Children(i).Code
   Case "MATERIALCODE":z4020.MaterialCode = Children(i).Code
   Case "DESCRIPTION":z4020.Description = Children(i).Code
   Case "COLOR":z4020.Color = Children(i).Code
   Case "SPECIFICATION":z4020.Specification = Children(i).Code
   Case "WIDTH":z4020.Width = Children(i).Code
   Case "HEIGHT":z4020.Height = Children(i).Code
   Case "SIZENAME":z4020.SizeName = Children(i).Code
   Case "COLORNAME":z4020.ColorName = Children(i).Code
   Case "SEUNITMATERIAL":z4020.seUnitMaterial = Children(i).Code
   Case "CDUNITMATERIAL":z4020.cdUnitmaterial = Children(i).Code
   Case "SESHOESSTATUS":z4020.seShoesStatus = Children(i).Code
   Case "CDSHOESSTATUS":z4020.cdShoesStatus = Children(i).Code
   Case "SEDEPARTMENT":z4020.seDepartment = Children(i).Code
   Case "CDDEPARTMENT":z4020.cdDepartment = Children(i).Code
   Case "SUPPLIERCODE":z4020.SupplierCode = Children(i).Code
   Case "MATERIALPRICE":z4020.MaterialPrice = Children(i).Code
   Case "SEUNITPRICE":z4020.seUnitPrice = Children(i).Code
   Case "CDUNITPRICE":z4020.cdUnitPrice = Children(i).Code
   Case "QTYCOMPONENT":z4020.QtyComponent = Children(i).Code
   Case "CONSUMPTION":z4020.Consumption = Children(i).Code
   Case "LOSS":z4020.Loss = Children(i).Code
   Case "GROSSUSAGE":z4020.GrossUsage = Children(i).Code
   Case "MATERIALAMT":z4020.MaterialAMT = Children(i).Code
   Case "TOTALQTY":z4020.TotalQty = Children(i).Code
   Case "TOTALMATERIALAMT":z4020.TotalMaterialAMT = Children(i).Code
   Case "INSERTDATE":z4020.InsertDate = Children(i).Code
   Case "INCHARGEINSERT":z4020.InchargeInsert = Children(i).Code
   Case "UPDATEDATE":z4020.UpdateDate = Children(i).Code
   Case "INCHARGEUPDATE":z4020.InchargeUpdate = Children(i).Code
   Case "ATTACHID":z4020.AttachID = Children(i).Code
   Case "SESUBPROCESS":z4020.seSubProcess = Children(i).Code
   Case "CDSUBPROCESS":z4020.cdSubProcess = Children(i).Code
   Case "REMARK":z4020.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "WORKORDER":z4020.WorkOrder = Children(i).Data
   Case "WORKORDERSEQ":z4020.WorkOrderSeq = Children(i).Data
   Case "MATERIALSEQ":z4020.MaterialSeq = Children(i).Data
   Case "DSEQ":z4020.DSeq = Children(i).Data
   Case "STATUS":z4020.Status = Children(i).Data
   Case "SEGROUPCOMPONENT":z4020.seGroupComponent = Children(i).Data
   Case "CDGROUPCOMPONENT":z4020.cdGroupComponent = Children(i).Data
   Case "COMPONENTNAME":z4020.ComponentName = Children(i).Data
   Case "MATERIALCODE":z4020.MaterialCode = Children(i).Data
   Case "DESCRIPTION":z4020.Description = Children(i).Data
   Case "COLOR":z4020.Color = Children(i).Data
   Case "SPECIFICATION":z4020.Specification = Children(i).Data
   Case "WIDTH":z4020.Width = Children(i).Data
   Case "HEIGHT":z4020.Height = Children(i).Data
   Case "SIZENAME":z4020.SizeName = Children(i).Data
   Case "COLORNAME":z4020.ColorName = Children(i).Data
   Case "SEUNITMATERIAL":z4020.seUnitMaterial = Children(i).Data
   Case "CDUNITMATERIAL":z4020.cdUnitmaterial = Children(i).Data
   Case "SESHOESSTATUS":z4020.seShoesStatus = Children(i).Data
   Case "CDSHOESSTATUS":z4020.cdShoesStatus = Children(i).Data
   Case "SEDEPARTMENT":z4020.seDepartment = Children(i).Data
   Case "CDDEPARTMENT":z4020.cdDepartment = Children(i).Data
   Case "SUPPLIERCODE":z4020.SupplierCode = Children(i).Data
   Case "MATERIALPRICE":z4020.MaterialPrice = Children(i).Data
   Case "SEUNITPRICE":z4020.seUnitPrice = Children(i).Data
   Case "CDUNITPRICE":z4020.cdUnitPrice = Children(i).Data
   Case "QTYCOMPONENT":z4020.QtyComponent = Children(i).Data
   Case "CONSUMPTION":z4020.Consumption = Children(i).Data
   Case "LOSS":z4020.Loss = Children(i).Data
   Case "GROSSUSAGE":z4020.GrossUsage = Children(i).Data
   Case "MATERIALAMT":z4020.MaterialAMT = Children(i).Data
   Case "TOTALQTY":z4020.TotalQty = Children(i).Data
   Case "TOTALMATERIALAMT":z4020.TotalMaterialAMT = Children(i).Data
   Case "INSERTDATE":z4020.InsertDate = Children(i).Data
   Case "INCHARGEINSERT":z4020.InchargeInsert = Children(i).Data
   Case "UPDATEDATE":z4020.UpdateDate = Children(i).Data
   Case "INCHARGEUPDATE":z4020.InchargeUpdate = Children(i).Data
   Case "ATTACHID":z4020.AttachID = Children(i).Data
   Case "SESUBPROCESS":z4020.seSubProcess = Children(i).Data
   Case "CDSUBPROCESS":z4020.cdSubProcess = Children(i).Data
   Case "REMARK":z4020.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K4020_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K4020_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z4020 As T4020_AREA, Job as String, CheckClear as Boolean, WORKORDER AS String, WORKORDERSEQ AS String, MATERIALSEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K4020_MOVE = False

Try
    If READ_PFK4020(WORKORDER, WORKORDERSEQ, MATERIALSEQ) = True Then
                z4020 = D4020
		K4020_MOVE = True
		else
	If CheckClear  = True then z4020 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4020")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "WORKORDER":z4020.WorkOrder = Children(i).Code
   Case "WORKORDERSEQ":z4020.WorkOrderSeq = Children(i).Code
   Case "MATERIALSEQ":z4020.MaterialSeq = Children(i).Code
   Case "DSEQ":z4020.DSeq = Children(i).Code
   Case "STATUS":z4020.Status = Children(i).Code
   Case "SEGROUPCOMPONENT":z4020.seGroupComponent = Children(i).Code
   Case "CDGROUPCOMPONENT":z4020.cdGroupComponent = Children(i).Code
   Case "COMPONENTNAME":z4020.ComponentName = Children(i).Code
   Case "MATERIALCODE":z4020.MaterialCode = Children(i).Code
   Case "DESCRIPTION":z4020.Description = Children(i).Code
   Case "COLOR":z4020.Color = Children(i).Code
   Case "SPECIFICATION":z4020.Specification = Children(i).Code
   Case "WIDTH":z4020.Width = Children(i).Code
   Case "HEIGHT":z4020.Height = Children(i).Code
   Case "SIZENAME":z4020.SizeName = Children(i).Code
   Case "COLORNAME":z4020.ColorName = Children(i).Code
   Case "SEUNITMATERIAL":z4020.seUnitMaterial = Children(i).Code
   Case "CDUNITMATERIAL":z4020.cdUnitmaterial = Children(i).Code
   Case "SESHOESSTATUS":z4020.seShoesStatus = Children(i).Code
   Case "CDSHOESSTATUS":z4020.cdShoesStatus = Children(i).Code
   Case "SEDEPARTMENT":z4020.seDepartment = Children(i).Code
   Case "CDDEPARTMENT":z4020.cdDepartment = Children(i).Code
   Case "SUPPLIERCODE":z4020.SupplierCode = Children(i).Code
   Case "MATERIALPRICE":z4020.MaterialPrice = Children(i).Code
   Case "SEUNITPRICE":z4020.seUnitPrice = Children(i).Code
   Case "CDUNITPRICE":z4020.cdUnitPrice = Children(i).Code
   Case "QTYCOMPONENT":z4020.QtyComponent = Children(i).Code
   Case "CONSUMPTION":z4020.Consumption = Children(i).Code
   Case "LOSS":z4020.Loss = Children(i).Code
   Case "GROSSUSAGE":z4020.GrossUsage = Children(i).Code
   Case "MATERIALAMT":z4020.MaterialAMT = Children(i).Code
   Case "TOTALQTY":z4020.TotalQty = Children(i).Code
   Case "TOTALMATERIALAMT":z4020.TotalMaterialAMT = Children(i).Code
   Case "INSERTDATE":z4020.InsertDate = Children(i).Code
   Case "INCHARGEINSERT":z4020.InchargeInsert = Children(i).Code
   Case "UPDATEDATE":z4020.UpdateDate = Children(i).Code
   Case "INCHARGEUPDATE":z4020.InchargeUpdate = Children(i).Code
   Case "ATTACHID":z4020.AttachID = Children(i).Code
   Case "SESUBPROCESS":z4020.seSubProcess = Children(i).Code
   Case "CDSUBPROCESS":z4020.cdSubProcess = Children(i).Code
   Case "REMARK":z4020.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "WORKORDER":z4020.WorkOrder = Children(i).Data
   Case "WORKORDERSEQ":z4020.WorkOrderSeq = Children(i).Data
   Case "MATERIALSEQ":z4020.MaterialSeq = Children(i).Data
   Case "DSEQ":z4020.DSeq = Children(i).Data
   Case "STATUS":z4020.Status = Children(i).Data
   Case "SEGROUPCOMPONENT":z4020.seGroupComponent = Children(i).Data
   Case "CDGROUPCOMPONENT":z4020.cdGroupComponent = Children(i).Data
   Case "COMPONENTNAME":z4020.ComponentName = Children(i).Data
   Case "MATERIALCODE":z4020.MaterialCode = Children(i).Data
   Case "DESCRIPTION":z4020.Description = Children(i).Data
   Case "COLOR":z4020.Color = Children(i).Data
   Case "SPECIFICATION":z4020.Specification = Children(i).Data
   Case "WIDTH":z4020.Width = Children(i).Data
   Case "HEIGHT":z4020.Height = Children(i).Data
   Case "SIZENAME":z4020.SizeName = Children(i).Data
   Case "COLORNAME":z4020.ColorName = Children(i).Data
   Case "SEUNITMATERIAL":z4020.seUnitMaterial = Children(i).Data
   Case "CDUNITMATERIAL":z4020.cdUnitmaterial = Children(i).Data
   Case "SESHOESSTATUS":z4020.seShoesStatus = Children(i).Data
   Case "CDSHOESSTATUS":z4020.cdShoesStatus = Children(i).Data
   Case "SEDEPARTMENT":z4020.seDepartment = Children(i).Data
   Case "CDDEPARTMENT":z4020.cdDepartment = Children(i).Data
   Case "SUPPLIERCODE":z4020.SupplierCode = Children(i).Data
   Case "MATERIALPRICE":z4020.MaterialPrice = Children(i).Data
   Case "SEUNITPRICE":z4020.seUnitPrice = Children(i).Data
   Case "CDUNITPRICE":z4020.cdUnitPrice = Children(i).Data
   Case "QTYCOMPONENT":z4020.QtyComponent = Children(i).Data
   Case "CONSUMPTION":z4020.Consumption = Children(i).Data
   Case "LOSS":z4020.Loss = Children(i).Data
   Case "GROSSUSAGE":z4020.GrossUsage = Children(i).Data
   Case "MATERIALAMT":z4020.MaterialAMT = Children(i).Data
   Case "TOTALQTY":z4020.TotalQty = Children(i).Data
   Case "TOTALMATERIALAMT":z4020.TotalMaterialAMT = Children(i).Data
   Case "INSERTDATE":z4020.InsertDate = Children(i).Data
   Case "INCHARGEINSERT":z4020.InchargeInsert = Children(i).Data
   Case "UPDATEDATE":z4020.UpdateDate = Children(i).Data
   Case "INCHARGEUPDATE":z4020.InchargeUpdate = Children(i).Data
   Case "ATTACHID":z4020.AttachID = Children(i).Data
   Case "SESUBPROCESS":z4020.seSubProcess = Children(i).Data
   Case "CDSUBPROCESS":z4020.cdSubProcess = Children(i).Data
   Case "REMARK":z4020.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K4020_MOVE",vbCritical)
End Try
End Function 
    
End Module 
