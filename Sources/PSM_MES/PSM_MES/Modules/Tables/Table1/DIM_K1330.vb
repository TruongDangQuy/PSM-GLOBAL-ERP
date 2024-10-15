'=========================================================================================================================================================
'   TABLE : (PFK1330)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K1330

Structure T1330_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	OrderNo	 AS String	'			char(9)		*
Public 	OrderNoSeq	 AS String	'			char(3)		*
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
Public 	SupplierCode	 AS String	'			char(6)
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

Public D1330 As T1330_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK1330(ORDERNO AS String, ORDERNOSEQ AS String, MATERIALSEQ AS Double) As Boolean
    READ_PFK1330 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK1330 "
    SQL = SQL & " WHERE K1330_OrderNo		 = '" & OrderNo & "' " 
    SQL = SQL & "   AND K1330_OrderNoSeq		 = '" & OrderNoSeq & "' " 
    SQL = SQL & "   AND K1330_MaterialSeq		 =  " & MaterialSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D1330_CLEAR: GoTo SKIP_READ_PFK1330
                
    Call K1330_MOVE(rd)
    READ_PFK1330 = True

SKIP_READ_PFK1330:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK1330",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK1330(ORDERNO AS String, ORDERNOSEQ AS String, MATERIALSEQ AS Double, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK1330 "
    SQL = SQL & " WHERE K1330_OrderNo		 = '" & OrderNo & "' " 
    SQL = SQL & "   AND K1330_OrderNoSeq		 = '" & OrderNoSeq & "' " 
    SQL = SQL & "   AND K1330_MaterialSeq		 =  " & MaterialSeq & "  " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK1330",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK1330(z1330 As T1330_AREA) As Boolean
    WRITE_PFK1330 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z1330)
 
    SQL = " INSERT INTO PFK1330 "
    SQL = SQL & " ( "
    SQL = SQL & " K1330_OrderNo," 
    SQL = SQL & " K1330_OrderNoSeq," 
    SQL = SQL & " K1330_MaterialSeq," 
    SQL = SQL & " K1330_DSeq," 
    SQL = SQL & " K1330_Status," 
    SQL = SQL & " K1330_seGroupComponent," 
    SQL = SQL & " K1330_cdGroupComponent," 
    SQL = SQL & " K1330_ComponentName," 
    SQL = SQL & " K1330_MaterialCode," 
    SQL = SQL & " K1330_Description," 
    SQL = SQL & " K1330_Color," 
    SQL = SQL & " K1330_Specification," 
    SQL = SQL & " K1330_Width," 
    SQL = SQL & " K1330_Height," 
    SQL = SQL & " K1330_SizeName," 
    SQL = SQL & " K1330_ColorName," 
    SQL = SQL & " K1330_seUnitMaterial," 
    SQL = SQL & " K1330_cdUnitmaterial," 
    SQL = SQL & " K1330_seShoesStatus," 
    SQL = SQL & " K1330_cdShoesStatus," 
    SQL = SQL & " K1330_seDepartment," 
    SQL = SQL & " K1330_cdDepartment," 
    SQL = SQL & " K1330_SupplierCode," 
    SQL = SQL & " K1330_MaterialPrice," 
    SQL = SQL & " K1330_seUnitPrice," 
    SQL = SQL & " K1330_cdUnitPrice," 
    SQL = SQL & " K1330_QtyComponent," 
    SQL = SQL & " K1330_Consumption," 
    SQL = SQL & " K1330_Loss," 
    SQL = SQL & " K1330_GrossUsage," 
    SQL = SQL & " K1330_MaterialAMT," 
    SQL = SQL & " K1330_TotalQty," 
    SQL = SQL & " K1330_TotalMaterialAMT," 
    SQL = SQL & " K1330_InsertDate," 
    SQL = SQL & " K1330_InchargeInsert," 
    SQL = SQL & " K1330_UpdateDate," 
    SQL = SQL & " K1330_InchargeUpdate," 
    SQL = SQL & " K1330_AttachID," 
    SQL = SQL & " K1330_seSubProcess," 
    SQL = SQL & " K1330_cdSubProcess," 
    SQL = SQL & " K1330_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z1330.OrderNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1330.OrderNoSeq) & "', "  
    SQL = SQL & "   " & FormatSQL(z1330.MaterialSeq) & ", "  
    SQL = SQL & "   " & FormatSQL(z1330.DSeq) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z1330.Status) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1330.seGroupComponent) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1330.cdGroupComponent) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1330.ComponentName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1330.MaterialCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1330.Description) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1330.Color) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1330.Specification) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1330.Width) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1330.Height) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1330.SizeName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1330.ColorName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1330.seUnitMaterial) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1330.cdUnitmaterial) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1330.seShoesStatus) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1330.cdShoesStatus) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1330.seDepartment) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1330.cdDepartment) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1330.SupplierCode) & "', "  
    SQL = SQL & "   " & FormatSQL(z1330.MaterialPrice) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z1330.seUnitPrice) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1330.cdUnitPrice) & "', "  
    SQL = SQL & "   " & FormatSQL(z1330.QtyComponent) & ", "  
    SQL = SQL & "   " & FormatSQL(z1330.Consumption) & ", "  
    SQL = SQL & "   " & FormatSQL(z1330.Loss) & ", "  
    SQL = SQL & "   " & FormatSQL(z1330.GrossUsage) & ", "  
    SQL = SQL & "   " & FormatSQL(z1330.MaterialAMT) & ", "  
    SQL = SQL & "   " & FormatSQL(z1330.TotalQty) & ", "  
    SQL = SQL & "   " & FormatSQL(z1330.TotalMaterialAMT) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z1330.InsertDate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1330.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1330.UpdateDate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1330.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1330.AttachID) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1330.seSubProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1330.cdSubProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1330.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK1330 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK1330",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK1330(z1330 As T1330_AREA) As Boolean
    REWRITE_PFK1330 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z1330)
   
    SQL = " UPDATE PFK1330 SET "
    SQL = SQL & "    K1330_DSeq      =  " & FormatSQL(z1330.DSeq) & ", " 
    SQL = SQL & "    K1330_Status      = N'" & FormatSQL(z1330.Status) & "', " 
    SQL = SQL & "    K1330_seGroupComponent      = N'" & FormatSQL(z1330.seGroupComponent) & "', " 
    SQL = SQL & "    K1330_cdGroupComponent      = N'" & FormatSQL(z1330.cdGroupComponent) & "', " 
    SQL = SQL & "    K1330_ComponentName      = N'" & FormatSQL(z1330.ComponentName) & "', " 
    SQL = SQL & "    K1330_MaterialCode      = N'" & FormatSQL(z1330.MaterialCode) & "', " 
    SQL = SQL & "    K1330_Description      = N'" & FormatSQL(z1330.Description) & "', " 
    SQL = SQL & "    K1330_Color      = N'" & FormatSQL(z1330.Color) & "', " 
    SQL = SQL & "    K1330_Specification      = N'" & FormatSQL(z1330.Specification) & "', " 
    SQL = SQL & "    K1330_Width      = N'" & FormatSQL(z1330.Width) & "', " 
    SQL = SQL & "    K1330_Height      = N'" & FormatSQL(z1330.Height) & "', " 
    SQL = SQL & "    K1330_SizeName      = N'" & FormatSQL(z1330.SizeName) & "', " 
    SQL = SQL & "    K1330_ColorName      = N'" & FormatSQL(z1330.ColorName) & "', " 
    SQL = SQL & "    K1330_seUnitMaterial      = N'" & FormatSQL(z1330.seUnitMaterial) & "', " 
    SQL = SQL & "    K1330_cdUnitmaterial      = N'" & FormatSQL(z1330.cdUnitmaterial) & "', " 
    SQL = SQL & "    K1330_seShoesStatus      = N'" & FormatSQL(z1330.seShoesStatus) & "', " 
    SQL = SQL & "    K1330_cdShoesStatus      = N'" & FormatSQL(z1330.cdShoesStatus) & "', " 
    SQL = SQL & "    K1330_seDepartment      = N'" & FormatSQL(z1330.seDepartment) & "', " 
    SQL = SQL & "    K1330_cdDepartment      = N'" & FormatSQL(z1330.cdDepartment) & "', " 
    SQL = SQL & "    K1330_SupplierCode      = N'" & FormatSQL(z1330.SupplierCode) & "', " 
    SQL = SQL & "    K1330_MaterialPrice      =  " & FormatSQL(z1330.MaterialPrice) & ", " 
    SQL = SQL & "    K1330_seUnitPrice      = N'" & FormatSQL(z1330.seUnitPrice) & "', " 
    SQL = SQL & "    K1330_cdUnitPrice      = N'" & FormatSQL(z1330.cdUnitPrice) & "', " 
    SQL = SQL & "    K1330_QtyComponent      =  " & FormatSQL(z1330.QtyComponent) & ", " 
    SQL = SQL & "    K1330_Consumption      =  " & FormatSQL(z1330.Consumption) & ", " 
    SQL = SQL & "    K1330_Loss      =  " & FormatSQL(z1330.Loss) & ", " 
    SQL = SQL & "    K1330_GrossUsage      =  " & FormatSQL(z1330.GrossUsage) & ", " 
    SQL = SQL & "    K1330_MaterialAMT      =  " & FormatSQL(z1330.MaterialAMT) & ", " 
    SQL = SQL & "    K1330_TotalQty      =  " & FormatSQL(z1330.TotalQty) & ", " 
    SQL = SQL & "    K1330_TotalMaterialAMT      =  " & FormatSQL(z1330.TotalMaterialAMT) & ", " 
    SQL = SQL & "    K1330_InsertDate      = N'" & FormatSQL(z1330.InsertDate) & "', " 
    SQL = SQL & "    K1330_InchargeInsert      = N'" & FormatSQL(z1330.InchargeInsert) & "', " 
    SQL = SQL & "    K1330_UpdateDate      = N'" & FormatSQL(z1330.UpdateDate) & "', " 
    SQL = SQL & "    K1330_InchargeUpdate      = N'" & FormatSQL(z1330.InchargeUpdate) & "', " 
    SQL = SQL & "    K1330_AttachID      = N'" & FormatSQL(z1330.AttachID) & "', " 
    SQL = SQL & "    K1330_seSubProcess      = N'" & FormatSQL(z1330.seSubProcess) & "', " 
    SQL = SQL & "    K1330_cdSubProcess      = N'" & FormatSQL(z1330.cdSubProcess) & "', " 
    SQL = SQL & "    K1330_Remark      = N'" & FormatSQL(z1330.Remark) & "'  " 
    SQL = SQL & " WHERE K1330_OrderNo		 = '" & z1330.OrderNo & "' " 
    SQL = SQL & "   AND K1330_OrderNoSeq		 = '" & z1330.OrderNoSeq & "' " 
    SQL = SQL & "   AND K1330_MaterialSeq		 =  " & z1330.MaterialSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK1330 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK1330",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK1330(z1330 As T1330_AREA) As Boolean
    DELETE_PFK1330 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK1330 "
    SQL = SQL & " WHERE K1330_OrderNo		 = '" & z1330.OrderNo & "' " 
    SQL = SQL & "   AND K1330_OrderNoSeq		 = '" & z1330.OrderNoSeq & "' " 
    SQL = SQL & "   AND K1330_MaterialSeq		 =  " & z1330.MaterialSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK1330 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK1330",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D1330_CLEAR()
Try
    
   D1330.OrderNo = ""
   D1330.OrderNoSeq = ""
    D1330.MaterialSeq = 0 
    D1330.DSeq = 0 
   D1330.Status = ""
   D1330.seGroupComponent = ""
   D1330.cdGroupComponent = ""
   D1330.ComponentName = ""
   D1330.MaterialCode = ""
   D1330.Description = ""
   D1330.Color = ""
   D1330.Specification = ""
   D1330.Width = ""
   D1330.Height = ""
   D1330.SizeName = ""
   D1330.ColorName = ""
   D1330.seUnitMaterial = ""
   D1330.cdUnitmaterial = ""
   D1330.seShoesStatus = ""
   D1330.cdShoesStatus = ""
   D1330.seDepartment = ""
   D1330.cdDepartment = ""
   D1330.SupplierCode = ""
    D1330.MaterialPrice = 0 
   D1330.seUnitPrice = ""
   D1330.cdUnitPrice = ""
    D1330.QtyComponent = 0 
    D1330.Consumption = 0 
    D1330.Loss = 0 
    D1330.GrossUsage = 0 
    D1330.MaterialAMT = 0 
    D1330.TotalQty = 0 
    D1330.TotalMaterialAMT = 0 
   D1330.InsertDate = ""
   D1330.InchargeInsert = ""
   D1330.UpdateDate = ""
   D1330.InchargeUpdate = ""
   D1330.AttachID = ""
   D1330.seSubProcess = ""
   D1330.cdSubProcess = ""
   D1330.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D1330_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x1330 As T1330_AREA)
Try
    
    x1330.OrderNo = trim$(  x1330.OrderNo)
    x1330.OrderNoSeq = trim$(  x1330.OrderNoSeq)
    x1330.MaterialSeq = trim$(  x1330.MaterialSeq)
    x1330.DSeq = trim$(  x1330.DSeq)
    x1330.Status = trim$(  x1330.Status)
    x1330.seGroupComponent = trim$(  x1330.seGroupComponent)
    x1330.cdGroupComponent = trim$(  x1330.cdGroupComponent)
    x1330.ComponentName = trim$(  x1330.ComponentName)
    x1330.MaterialCode = trim$(  x1330.MaterialCode)
    x1330.Description = trim$(  x1330.Description)
    x1330.Color = trim$(  x1330.Color)
    x1330.Specification = trim$(  x1330.Specification)
    x1330.Width = trim$(  x1330.Width)
    x1330.Height = trim$(  x1330.Height)
    x1330.SizeName = trim$(  x1330.SizeName)
    x1330.ColorName = trim$(  x1330.ColorName)
    x1330.seUnitMaterial = trim$(  x1330.seUnitMaterial)
    x1330.cdUnitmaterial = trim$(  x1330.cdUnitmaterial)
    x1330.seShoesStatus = trim$(  x1330.seShoesStatus)
    x1330.cdShoesStatus = trim$(  x1330.cdShoesStatus)
    x1330.seDepartment = trim$(  x1330.seDepartment)
    x1330.cdDepartment = trim$(  x1330.cdDepartment)
    x1330.SupplierCode = trim$(  x1330.SupplierCode)
    x1330.MaterialPrice = trim$(  x1330.MaterialPrice)
    x1330.seUnitPrice = trim$(  x1330.seUnitPrice)
    x1330.cdUnitPrice = trim$(  x1330.cdUnitPrice)
    x1330.QtyComponent = trim$(  x1330.QtyComponent)
    x1330.Consumption = trim$(  x1330.Consumption)
    x1330.Loss = trim$(  x1330.Loss)
    x1330.GrossUsage = trim$(  x1330.GrossUsage)
    x1330.MaterialAMT = trim$(  x1330.MaterialAMT)
    x1330.TotalQty = trim$(  x1330.TotalQty)
    x1330.TotalMaterialAMT = trim$(  x1330.TotalMaterialAMT)
    x1330.InsertDate = trim$(  x1330.InsertDate)
    x1330.InchargeInsert = trim$(  x1330.InchargeInsert)
    x1330.UpdateDate = trim$(  x1330.UpdateDate)
    x1330.InchargeUpdate = trim$(  x1330.InchargeUpdate)
    x1330.AttachID = trim$(  x1330.AttachID)
    x1330.seSubProcess = trim$(  x1330.seSubProcess)
    x1330.cdSubProcess = trim$(  x1330.cdSubProcess)
    x1330.Remark = trim$(  x1330.Remark)
     
    If trim$( x1330.OrderNo ) = "" Then x1330.OrderNo = Space(1) 
    If trim$( x1330.OrderNoSeq ) = "" Then x1330.OrderNoSeq = Space(1) 
    If trim$( x1330.MaterialSeq ) = "" Then x1330.MaterialSeq = 0 
    If trim$( x1330.DSeq ) = "" Then x1330.DSeq = 0 
    If trim$( x1330.Status ) = "" Then x1330.Status = Space(1) 
    If trim$( x1330.seGroupComponent ) = "" Then x1330.seGroupComponent = Space(1) 
    If trim$( x1330.cdGroupComponent ) = "" Then x1330.cdGroupComponent = Space(1) 
    If trim$( x1330.ComponentName ) = "" Then x1330.ComponentName = Space(1) 
    If trim$( x1330.MaterialCode ) = "" Then x1330.MaterialCode = Space(1) 
    If trim$( x1330.Description ) = "" Then x1330.Description = Space(1) 
    If trim$( x1330.Color ) = "" Then x1330.Color = Space(1) 
    If trim$( x1330.Specification ) = "" Then x1330.Specification = Space(1) 
    If trim$( x1330.Width ) = "" Then x1330.Width = Space(1) 
    If trim$( x1330.Height ) = "" Then x1330.Height = Space(1) 
    If trim$( x1330.SizeName ) = "" Then x1330.SizeName = Space(1) 
    If trim$( x1330.ColorName ) = "" Then x1330.ColorName = Space(1) 
    If trim$( x1330.seUnitMaterial ) = "" Then x1330.seUnitMaterial = Space(1) 
    If trim$( x1330.cdUnitmaterial ) = "" Then x1330.cdUnitmaterial = Space(1) 
    If trim$( x1330.seShoesStatus ) = "" Then x1330.seShoesStatus = Space(1) 
    If trim$( x1330.cdShoesStatus ) = "" Then x1330.cdShoesStatus = Space(1) 
    If trim$( x1330.seDepartment ) = "" Then x1330.seDepartment = Space(1) 
    If trim$( x1330.cdDepartment ) = "" Then x1330.cdDepartment = Space(1) 
    If trim$( x1330.SupplierCode ) = "" Then x1330.SupplierCode = Space(1) 
    If trim$( x1330.MaterialPrice ) = "" Then x1330.MaterialPrice = 0 
    If trim$( x1330.seUnitPrice ) = "" Then x1330.seUnitPrice = Space(1) 
    If trim$( x1330.cdUnitPrice ) = "" Then x1330.cdUnitPrice = Space(1) 
    If trim$( x1330.QtyComponent ) = "" Then x1330.QtyComponent = 0 
    If trim$( x1330.Consumption ) = "" Then x1330.Consumption = 0 
    If trim$( x1330.Loss ) = "" Then x1330.Loss = 0 
    If trim$( x1330.GrossUsage ) = "" Then x1330.GrossUsage = 0 
    If trim$( x1330.MaterialAMT ) = "" Then x1330.MaterialAMT = 0 
    If trim$( x1330.TotalQty ) = "" Then x1330.TotalQty = 0 
    If trim$( x1330.TotalMaterialAMT ) = "" Then x1330.TotalMaterialAMT = 0 
    If trim$( x1330.InsertDate ) = "" Then x1330.InsertDate = Space(1) 
    If trim$( x1330.InchargeInsert ) = "" Then x1330.InchargeInsert = Space(1) 
    If trim$( x1330.UpdateDate ) = "" Then x1330.UpdateDate = Space(1) 
    If trim$( x1330.InchargeUpdate ) = "" Then x1330.InchargeUpdate = Space(1) 
    If trim$( x1330.AttachID ) = "" Then x1330.AttachID = Space(1) 
    If trim$( x1330.seSubProcess ) = "" Then x1330.seSubProcess = Space(1) 
    If trim$( x1330.cdSubProcess ) = "" Then x1330.cdSubProcess = Space(1) 
    If trim$( x1330.Remark ) = "" Then x1330.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K1330_MOVE(rs1330 As SqlClient.SqlDataReader)
Try

    call D1330_CLEAR()   

    If IsdbNull(rs1330!K1330_OrderNo) = False Then D1330.OrderNo = Trim$(rs1330!K1330_OrderNo)
    If IsdbNull(rs1330!K1330_OrderNoSeq) = False Then D1330.OrderNoSeq = Trim$(rs1330!K1330_OrderNoSeq)
    If IsdbNull(rs1330!K1330_MaterialSeq) = False Then D1330.MaterialSeq = Trim$(rs1330!K1330_MaterialSeq)
    If IsdbNull(rs1330!K1330_DSeq) = False Then D1330.DSeq = Trim$(rs1330!K1330_DSeq)
    If IsdbNull(rs1330!K1330_Status) = False Then D1330.Status = Trim$(rs1330!K1330_Status)
    If IsdbNull(rs1330!K1330_seGroupComponent) = False Then D1330.seGroupComponent = Trim$(rs1330!K1330_seGroupComponent)
    If IsdbNull(rs1330!K1330_cdGroupComponent) = False Then D1330.cdGroupComponent = Trim$(rs1330!K1330_cdGroupComponent)
    If IsdbNull(rs1330!K1330_ComponentName) = False Then D1330.ComponentName = Trim$(rs1330!K1330_ComponentName)
    If IsdbNull(rs1330!K1330_MaterialCode) = False Then D1330.MaterialCode = Trim$(rs1330!K1330_MaterialCode)
    If IsdbNull(rs1330!K1330_Description) = False Then D1330.Description = Trim$(rs1330!K1330_Description)
    If IsdbNull(rs1330!K1330_Color) = False Then D1330.Color = Trim$(rs1330!K1330_Color)
    If IsdbNull(rs1330!K1330_Specification) = False Then D1330.Specification = Trim$(rs1330!K1330_Specification)
    If IsdbNull(rs1330!K1330_Width) = False Then D1330.Width = Trim$(rs1330!K1330_Width)
    If IsdbNull(rs1330!K1330_Height) = False Then D1330.Height = Trim$(rs1330!K1330_Height)
    If IsdbNull(rs1330!K1330_SizeName) = False Then D1330.SizeName = Trim$(rs1330!K1330_SizeName)
    If IsdbNull(rs1330!K1330_ColorName) = False Then D1330.ColorName = Trim$(rs1330!K1330_ColorName)
    If IsdbNull(rs1330!K1330_seUnitMaterial) = False Then D1330.seUnitMaterial = Trim$(rs1330!K1330_seUnitMaterial)
    If IsdbNull(rs1330!K1330_cdUnitmaterial) = False Then D1330.cdUnitmaterial = Trim$(rs1330!K1330_cdUnitmaterial)
    If IsdbNull(rs1330!K1330_seShoesStatus) = False Then D1330.seShoesStatus = Trim$(rs1330!K1330_seShoesStatus)
    If IsdbNull(rs1330!K1330_cdShoesStatus) = False Then D1330.cdShoesStatus = Trim$(rs1330!K1330_cdShoesStatus)
    If IsdbNull(rs1330!K1330_seDepartment) = False Then D1330.seDepartment = Trim$(rs1330!K1330_seDepartment)
    If IsdbNull(rs1330!K1330_cdDepartment) = False Then D1330.cdDepartment = Trim$(rs1330!K1330_cdDepartment)
    If IsdbNull(rs1330!K1330_SupplierCode) = False Then D1330.SupplierCode = Trim$(rs1330!K1330_SupplierCode)
    If IsdbNull(rs1330!K1330_MaterialPrice) = False Then D1330.MaterialPrice = Trim$(rs1330!K1330_MaterialPrice)
    If IsdbNull(rs1330!K1330_seUnitPrice) = False Then D1330.seUnitPrice = Trim$(rs1330!K1330_seUnitPrice)
    If IsdbNull(rs1330!K1330_cdUnitPrice) = False Then D1330.cdUnitPrice = Trim$(rs1330!K1330_cdUnitPrice)
    If IsdbNull(rs1330!K1330_QtyComponent) = False Then D1330.QtyComponent = Trim$(rs1330!K1330_QtyComponent)
    If IsdbNull(rs1330!K1330_Consumption) = False Then D1330.Consumption = Trim$(rs1330!K1330_Consumption)
    If IsdbNull(rs1330!K1330_Loss) = False Then D1330.Loss = Trim$(rs1330!K1330_Loss)
    If IsdbNull(rs1330!K1330_GrossUsage) = False Then D1330.GrossUsage = Trim$(rs1330!K1330_GrossUsage)
    If IsdbNull(rs1330!K1330_MaterialAMT) = False Then D1330.MaterialAMT = Trim$(rs1330!K1330_MaterialAMT)
    If IsdbNull(rs1330!K1330_TotalQty) = False Then D1330.TotalQty = Trim$(rs1330!K1330_TotalQty)
    If IsdbNull(rs1330!K1330_TotalMaterialAMT) = False Then D1330.TotalMaterialAMT = Trim$(rs1330!K1330_TotalMaterialAMT)
    If IsdbNull(rs1330!K1330_InsertDate) = False Then D1330.InsertDate = Trim$(rs1330!K1330_InsertDate)
    If IsdbNull(rs1330!K1330_InchargeInsert) = False Then D1330.InchargeInsert = Trim$(rs1330!K1330_InchargeInsert)
    If IsdbNull(rs1330!K1330_UpdateDate) = False Then D1330.UpdateDate = Trim$(rs1330!K1330_UpdateDate)
    If IsdbNull(rs1330!K1330_InchargeUpdate) = False Then D1330.InchargeUpdate = Trim$(rs1330!K1330_InchargeUpdate)
    If IsdbNull(rs1330!K1330_AttachID) = False Then D1330.AttachID = Trim$(rs1330!K1330_AttachID)
    If IsdbNull(rs1330!K1330_seSubProcess) = False Then D1330.seSubProcess = Trim$(rs1330!K1330_seSubProcess)
    If IsdbNull(rs1330!K1330_cdSubProcess) = False Then D1330.cdSubProcess = Trim$(rs1330!K1330_cdSubProcess)
    If IsdbNull(rs1330!K1330_Remark) = False Then D1330.Remark = Trim$(rs1330!K1330_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K1330_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K1330_MOVE(rs1330 As DataRow)
Try

    call D1330_CLEAR()   

    If IsdbNull(rs1330!K1330_OrderNo) = False Then D1330.OrderNo = Trim$(rs1330!K1330_OrderNo)
    If IsdbNull(rs1330!K1330_OrderNoSeq) = False Then D1330.OrderNoSeq = Trim$(rs1330!K1330_OrderNoSeq)
    If IsdbNull(rs1330!K1330_MaterialSeq) = False Then D1330.MaterialSeq = Trim$(rs1330!K1330_MaterialSeq)
    If IsdbNull(rs1330!K1330_DSeq) = False Then D1330.DSeq = Trim$(rs1330!K1330_DSeq)
    If IsdbNull(rs1330!K1330_Status) = False Then D1330.Status = Trim$(rs1330!K1330_Status)
    If IsdbNull(rs1330!K1330_seGroupComponent) = False Then D1330.seGroupComponent = Trim$(rs1330!K1330_seGroupComponent)
    If IsdbNull(rs1330!K1330_cdGroupComponent) = False Then D1330.cdGroupComponent = Trim$(rs1330!K1330_cdGroupComponent)
    If IsdbNull(rs1330!K1330_ComponentName) = False Then D1330.ComponentName = Trim$(rs1330!K1330_ComponentName)
    If IsdbNull(rs1330!K1330_MaterialCode) = False Then D1330.MaterialCode = Trim$(rs1330!K1330_MaterialCode)
    If IsdbNull(rs1330!K1330_Description) = False Then D1330.Description = Trim$(rs1330!K1330_Description)
    If IsdbNull(rs1330!K1330_Color) = False Then D1330.Color = Trim$(rs1330!K1330_Color)
    If IsdbNull(rs1330!K1330_Specification) = False Then D1330.Specification = Trim$(rs1330!K1330_Specification)
    If IsdbNull(rs1330!K1330_Width) = False Then D1330.Width = Trim$(rs1330!K1330_Width)
    If IsdbNull(rs1330!K1330_Height) = False Then D1330.Height = Trim$(rs1330!K1330_Height)
    If IsdbNull(rs1330!K1330_SizeName) = False Then D1330.SizeName = Trim$(rs1330!K1330_SizeName)
    If IsdbNull(rs1330!K1330_ColorName) = False Then D1330.ColorName = Trim$(rs1330!K1330_ColorName)
    If IsdbNull(rs1330!K1330_seUnitMaterial) = False Then D1330.seUnitMaterial = Trim$(rs1330!K1330_seUnitMaterial)
    If IsdbNull(rs1330!K1330_cdUnitmaterial) = False Then D1330.cdUnitmaterial = Trim$(rs1330!K1330_cdUnitmaterial)
    If IsdbNull(rs1330!K1330_seShoesStatus) = False Then D1330.seShoesStatus = Trim$(rs1330!K1330_seShoesStatus)
    If IsdbNull(rs1330!K1330_cdShoesStatus) = False Then D1330.cdShoesStatus = Trim$(rs1330!K1330_cdShoesStatus)
    If IsdbNull(rs1330!K1330_seDepartment) = False Then D1330.seDepartment = Trim$(rs1330!K1330_seDepartment)
    If IsdbNull(rs1330!K1330_cdDepartment) = False Then D1330.cdDepartment = Trim$(rs1330!K1330_cdDepartment)
    If IsdbNull(rs1330!K1330_SupplierCode) = False Then D1330.SupplierCode = Trim$(rs1330!K1330_SupplierCode)
    If IsdbNull(rs1330!K1330_MaterialPrice) = False Then D1330.MaterialPrice = Trim$(rs1330!K1330_MaterialPrice)
    If IsdbNull(rs1330!K1330_seUnitPrice) = False Then D1330.seUnitPrice = Trim$(rs1330!K1330_seUnitPrice)
    If IsdbNull(rs1330!K1330_cdUnitPrice) = False Then D1330.cdUnitPrice = Trim$(rs1330!K1330_cdUnitPrice)
    If IsdbNull(rs1330!K1330_QtyComponent) = False Then D1330.QtyComponent = Trim$(rs1330!K1330_QtyComponent)
    If IsdbNull(rs1330!K1330_Consumption) = False Then D1330.Consumption = Trim$(rs1330!K1330_Consumption)
    If IsdbNull(rs1330!K1330_Loss) = False Then D1330.Loss = Trim$(rs1330!K1330_Loss)
    If IsdbNull(rs1330!K1330_GrossUsage) = False Then D1330.GrossUsage = Trim$(rs1330!K1330_GrossUsage)
    If IsdbNull(rs1330!K1330_MaterialAMT) = False Then D1330.MaterialAMT = Trim$(rs1330!K1330_MaterialAMT)
    If IsdbNull(rs1330!K1330_TotalQty) = False Then D1330.TotalQty = Trim$(rs1330!K1330_TotalQty)
    If IsdbNull(rs1330!K1330_TotalMaterialAMT) = False Then D1330.TotalMaterialAMT = Trim$(rs1330!K1330_TotalMaterialAMT)
    If IsdbNull(rs1330!K1330_InsertDate) = False Then D1330.InsertDate = Trim$(rs1330!K1330_InsertDate)
    If IsdbNull(rs1330!K1330_InchargeInsert) = False Then D1330.InchargeInsert = Trim$(rs1330!K1330_InchargeInsert)
    If IsdbNull(rs1330!K1330_UpdateDate) = False Then D1330.UpdateDate = Trim$(rs1330!K1330_UpdateDate)
    If IsdbNull(rs1330!K1330_InchargeUpdate) = False Then D1330.InchargeUpdate = Trim$(rs1330!K1330_InchargeUpdate)
    If IsdbNull(rs1330!K1330_AttachID) = False Then D1330.AttachID = Trim$(rs1330!K1330_AttachID)
    If IsdbNull(rs1330!K1330_seSubProcess) = False Then D1330.seSubProcess = Trim$(rs1330!K1330_seSubProcess)
    If IsdbNull(rs1330!K1330_cdSubProcess) = False Then D1330.cdSubProcess = Trim$(rs1330!K1330_cdSubProcess)
    If IsdbNull(rs1330!K1330_Remark) = False Then D1330.Remark = Trim$(rs1330!K1330_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K1330_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K1330_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z1330 As T1330_AREA, ORDERNO AS String, ORDERNOSEQ AS String, MATERIALSEQ AS Double) as Boolean

K1330_MOVE = False

Try
    If READ_PFK1330(ORDERNO, ORDERNOSEQ, MATERIALSEQ) = True Then
                z1330 = D1330
		K1330_MOVE = True
		else
	z1330 = nothing
     End If

     If  getColumIndex(spr,"OrderNo") > -1 then z1330.OrderNo = getDataM(spr, getColumIndex(spr,"OrderNo"), xRow)
     If  getColumIndex(spr,"OrderNoSeq") > -1 then z1330.OrderNoSeq = getDataM(spr, getColumIndex(spr,"OrderNoSeq"), xRow)
     If  getColumIndex(spr,"MaterialSeq") > -1 then z1330.MaterialSeq = getDataM(spr, getColumIndex(spr,"MaterialSeq"), xRow)
     If  getColumIndex(spr,"DSeq") > -1 then z1330.DSeq = getDataM(spr, getColumIndex(spr,"DSeq"), xRow)
     If  getColumIndex(spr,"Status") > -1 then z1330.Status = getDataM(spr, getColumIndex(spr,"Status"), xRow)
     If  getColumIndex(spr,"seGroupComponent") > -1 then z1330.seGroupComponent = getDataM(spr, getColumIndex(spr,"seGroupComponent"), xRow)
     If  getColumIndex(spr,"cdGroupComponent") > -1 then z1330.cdGroupComponent = getDataM(spr, getColumIndex(spr,"cdGroupComponent"), xRow)
     If  getColumIndex(spr,"ComponentName") > -1 then z1330.ComponentName = getDataM(spr, getColumIndex(spr,"ComponentName"), xRow)
     If  getColumIndex(spr,"MaterialCode") > -1 then z1330.MaterialCode = getDataM(spr, getColumIndex(spr,"MaterialCode"), xRow)
     If  getColumIndex(spr,"Description") > -1 then z1330.Description = getDataM(spr, getColumIndex(spr,"Description"), xRow)
     If  getColumIndex(spr,"Color") > -1 then z1330.Color = getDataM(spr, getColumIndex(spr,"Color"), xRow)
     If  getColumIndex(spr,"Specification") > -1 then z1330.Specification = getDataM(spr, getColumIndex(spr,"Specification"), xRow)
     If  getColumIndex(spr,"Width") > -1 then z1330.Width = getDataM(spr, getColumIndex(spr,"Width"), xRow)
     If  getColumIndex(spr,"Height") > -1 then z1330.Height = getDataM(spr, getColumIndex(spr,"Height"), xRow)
     If  getColumIndex(spr,"SizeName") > -1 then z1330.SizeName = getDataM(spr, getColumIndex(spr,"SizeName"), xRow)
     If  getColumIndex(spr,"ColorName") > -1 then z1330.ColorName = getDataM(spr, getColumIndex(spr,"ColorName"), xRow)
     If  getColumIndex(spr,"seUnitMaterial") > -1 then z1330.seUnitMaterial = getDataM(spr, getColumIndex(spr,"seUnitMaterial"), xRow)
     If  getColumIndex(spr,"cdUnitmaterial") > -1 then z1330.cdUnitmaterial = getDataM(spr, getColumIndex(spr,"cdUnitmaterial"), xRow)
     If  getColumIndex(spr,"seShoesStatus") > -1 then z1330.seShoesStatus = getDataM(spr, getColumIndex(spr,"seShoesStatus"), xRow)
     If  getColumIndex(spr,"cdShoesStatus") > -1 then z1330.cdShoesStatus = getDataM(spr, getColumIndex(spr,"cdShoesStatus"), xRow)
     If  getColumIndex(spr,"seDepartment") > -1 then z1330.seDepartment = getDataM(spr, getColumIndex(spr,"seDepartment"), xRow)
     If  getColumIndex(spr,"cdDepartment") > -1 then z1330.cdDepartment = getDataM(spr, getColumIndex(spr,"cdDepartment"), xRow)
     If  getColumIndex(spr,"SupplierCode") > -1 then z1330.SupplierCode = getDataM(spr, getColumIndex(spr,"SupplierCode"), xRow)
     If  getColumIndex(spr,"MaterialPrice") > -1 then z1330.MaterialPrice = getDataM(spr, getColumIndex(spr,"MaterialPrice"), xRow)
     If  getColumIndex(spr,"seUnitPrice") > -1 then z1330.seUnitPrice = getDataM(spr, getColumIndex(spr,"seUnitPrice"), xRow)
     If  getColumIndex(spr,"cdUnitPrice") > -1 then z1330.cdUnitPrice = getDataM(spr, getColumIndex(spr,"cdUnitPrice"), xRow)
     If  getColumIndex(spr,"QtyComponent") > -1 then z1330.QtyComponent = getDataM(spr, getColumIndex(spr,"QtyComponent"), xRow)
     If  getColumIndex(spr,"Consumption") > -1 then z1330.Consumption = getDataM(spr, getColumIndex(spr,"Consumption"), xRow)
     If  getColumIndex(spr,"Loss") > -1 then z1330.Loss = getDataM(spr, getColumIndex(spr,"Loss"), xRow)
     If  getColumIndex(spr,"GrossUsage") > -1 then z1330.GrossUsage = getDataM(spr, getColumIndex(spr,"GrossUsage"), xRow)
     If  getColumIndex(spr,"MaterialAMT") > -1 then z1330.MaterialAMT = getDataM(spr, getColumIndex(spr,"MaterialAMT"), xRow)
     If  getColumIndex(spr,"TotalQty") > -1 then z1330.TotalQty = getDataM(spr, getColumIndex(spr,"TotalQty"), xRow)
     If  getColumIndex(spr,"TotalMaterialAMT") > -1 then z1330.TotalMaterialAMT = getDataM(spr, getColumIndex(spr,"TotalMaterialAMT"), xRow)
     If  getColumIndex(spr,"InsertDate") > -1 then z1330.InsertDate = getDataM(spr, getColumIndex(spr,"InsertDate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z1330.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"UpdateDate") > -1 then z1330.UpdateDate = getDataM(spr, getColumIndex(spr,"UpdateDate"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z1330.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"AttachID") > -1 then z1330.AttachID = getDataM(spr, getColumIndex(spr,"AttachID"), xRow)
     If  getColumIndex(spr,"seSubProcess") > -1 then z1330.seSubProcess = getDataM(spr, getColumIndex(spr,"seSubProcess"), xRow)
     If  getColumIndex(spr,"cdSubProcess") > -1 then z1330.cdSubProcess = getDataM(spr, getColumIndex(spr,"cdSubProcess"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z1330.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K1330_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K1330_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z1330 As T1330_AREA,CheckClear as Boolean,ORDERNO AS String, ORDERNOSEQ AS String, MATERIALSEQ AS Double) as Boolean

K1330_MOVE = False

Try
    If READ_PFK1330(ORDERNO, ORDERNOSEQ, MATERIALSEQ) = True Then
                z1330 = D1330
		K1330_MOVE = True
		else
	If CheckClear  = True then z1330 = nothing
     End If

     If  getColumIndex(spr,"OrderNo") > -1 then z1330.OrderNo = getDataM(spr, getColumIndex(spr,"OrderNo"), xRow)
     If  getColumIndex(spr,"OrderNoSeq") > -1 then z1330.OrderNoSeq = getDataM(spr, getColumIndex(spr,"OrderNoSeq"), xRow)
     If  getColumIndex(spr,"MaterialSeq") > -1 then z1330.MaterialSeq = getDataM(spr, getColumIndex(spr,"MaterialSeq"), xRow)
     If  getColumIndex(spr,"DSeq") > -1 then z1330.DSeq = getDataM(spr, getColumIndex(spr,"DSeq"), xRow)
     If  getColumIndex(spr,"Status") > -1 then z1330.Status = getDataM(spr, getColumIndex(spr,"Status"), xRow)
     If  getColumIndex(spr,"seGroupComponent") > -1 then z1330.seGroupComponent = getDataM(spr, getColumIndex(spr,"seGroupComponent"), xRow)
     If  getColumIndex(spr,"cdGroupComponent") > -1 then z1330.cdGroupComponent = getDataM(spr, getColumIndex(spr,"cdGroupComponent"), xRow)
     If  getColumIndex(spr,"ComponentName") > -1 then z1330.ComponentName = getDataM(spr, getColumIndex(spr,"ComponentName"), xRow)
     If  getColumIndex(spr,"MaterialCode") > -1 then z1330.MaterialCode = getDataM(spr, getColumIndex(spr,"MaterialCode"), xRow)
     If  getColumIndex(spr,"Description") > -1 then z1330.Description = getDataM(spr, getColumIndex(spr,"Description"), xRow)
     If  getColumIndex(spr,"Color") > -1 then z1330.Color = getDataM(spr, getColumIndex(spr,"Color"), xRow)
     If  getColumIndex(spr,"Specification") > -1 then z1330.Specification = getDataM(spr, getColumIndex(spr,"Specification"), xRow)
     If  getColumIndex(spr,"Width") > -1 then z1330.Width = getDataM(spr, getColumIndex(spr,"Width"), xRow)
     If  getColumIndex(spr,"Height") > -1 then z1330.Height = getDataM(spr, getColumIndex(spr,"Height"), xRow)
     If  getColumIndex(spr,"SizeName") > -1 then z1330.SizeName = getDataM(spr, getColumIndex(spr,"SizeName"), xRow)
     If  getColumIndex(spr,"ColorName") > -1 then z1330.ColorName = getDataM(spr, getColumIndex(spr,"ColorName"), xRow)
     If  getColumIndex(spr,"seUnitMaterial") > -1 then z1330.seUnitMaterial = getDataM(spr, getColumIndex(spr,"seUnitMaterial"), xRow)
     If  getColumIndex(spr,"cdUnitmaterial") > -1 then z1330.cdUnitmaterial = getDataM(spr, getColumIndex(spr,"cdUnitmaterial"), xRow)
     If  getColumIndex(spr,"seShoesStatus") > -1 then z1330.seShoesStatus = getDataM(spr, getColumIndex(spr,"seShoesStatus"), xRow)
     If  getColumIndex(spr,"cdShoesStatus") > -1 then z1330.cdShoesStatus = getDataM(spr, getColumIndex(spr,"cdShoesStatus"), xRow)
     If  getColumIndex(spr,"seDepartment") > -1 then z1330.seDepartment = getDataM(spr, getColumIndex(spr,"seDepartment"), xRow)
     If  getColumIndex(spr,"cdDepartment") > -1 then z1330.cdDepartment = getDataM(spr, getColumIndex(spr,"cdDepartment"), xRow)
     If  getColumIndex(spr,"SupplierCode") > -1 then z1330.SupplierCode = getDataM(spr, getColumIndex(spr,"SupplierCode"), xRow)
     If  getColumIndex(spr,"MaterialPrice") > -1 then z1330.MaterialPrice = getDataM(spr, getColumIndex(spr,"MaterialPrice"), xRow)
     If  getColumIndex(spr,"seUnitPrice") > -1 then z1330.seUnitPrice = getDataM(spr, getColumIndex(spr,"seUnitPrice"), xRow)
     If  getColumIndex(spr,"cdUnitPrice") > -1 then z1330.cdUnitPrice = getDataM(spr, getColumIndex(spr,"cdUnitPrice"), xRow)
     If  getColumIndex(spr,"QtyComponent") > -1 then z1330.QtyComponent = getDataM(spr, getColumIndex(spr,"QtyComponent"), xRow)
     If  getColumIndex(spr,"Consumption") > -1 then z1330.Consumption = getDataM(spr, getColumIndex(spr,"Consumption"), xRow)
     If  getColumIndex(spr,"Loss") > -1 then z1330.Loss = getDataM(spr, getColumIndex(spr,"Loss"), xRow)
     If  getColumIndex(spr,"GrossUsage") > -1 then z1330.GrossUsage = getDataM(spr, getColumIndex(spr,"GrossUsage"), xRow)
     If  getColumIndex(spr,"MaterialAMT") > -1 then z1330.MaterialAMT = getDataM(spr, getColumIndex(spr,"MaterialAMT"), xRow)
     If  getColumIndex(spr,"TotalQty") > -1 then z1330.TotalQty = getDataM(spr, getColumIndex(spr,"TotalQty"), xRow)
     If  getColumIndex(spr,"TotalMaterialAMT") > -1 then z1330.TotalMaterialAMT = getDataM(spr, getColumIndex(spr,"TotalMaterialAMT"), xRow)
     If  getColumIndex(spr,"InsertDate") > -1 then z1330.InsertDate = getDataM(spr, getColumIndex(spr,"InsertDate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z1330.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"UpdateDate") > -1 then z1330.UpdateDate = getDataM(spr, getColumIndex(spr,"UpdateDate"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z1330.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"AttachID") > -1 then z1330.AttachID = getDataM(spr, getColumIndex(spr,"AttachID"), xRow)
     If  getColumIndex(spr,"seSubProcess") > -1 then z1330.seSubProcess = getDataM(spr, getColumIndex(spr,"seSubProcess"), xRow)
     If  getColumIndex(spr,"cdSubProcess") > -1 then z1330.cdSubProcess = getDataM(spr, getColumIndex(spr,"cdSubProcess"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z1330.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K1330_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K1330_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z1330 As T1330_AREA, Job as String, ORDERNO AS String, ORDERNOSEQ AS String, MATERIALSEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K1330_MOVE = False

Try
    If READ_PFK1330(ORDERNO, ORDERNOSEQ, MATERIALSEQ) = True Then
                z1330 = D1330
		K1330_MOVE = True
		else
	z1330 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK1330")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "ORDERNO":z1330.OrderNo = Children(i).Code
   Case "ORDERNOSEQ":z1330.OrderNoSeq = Children(i).Code
   Case "MATERIALSEQ":z1330.MaterialSeq = Children(i).Code
   Case "DSEQ":z1330.DSeq = Children(i).Code
   Case "STATUS":z1330.Status = Children(i).Code
   Case "SEGROUPCOMPONENT":z1330.seGroupComponent = Children(i).Code
   Case "CDGROUPCOMPONENT":z1330.cdGroupComponent = Children(i).Code
   Case "COMPONENTNAME":z1330.ComponentName = Children(i).Code
   Case "MATERIALCODE":z1330.MaterialCode = Children(i).Code
   Case "DESCRIPTION":z1330.Description = Children(i).Code
   Case "COLOR":z1330.Color = Children(i).Code
   Case "SPECIFICATION":z1330.Specification = Children(i).Code
   Case "WIDTH":z1330.Width = Children(i).Code
   Case "HEIGHT":z1330.Height = Children(i).Code
   Case "SIZENAME":z1330.SizeName = Children(i).Code
   Case "COLORNAME":z1330.ColorName = Children(i).Code
   Case "SEUNITMATERIAL":z1330.seUnitMaterial = Children(i).Code
   Case "CDUNITMATERIAL":z1330.cdUnitmaterial = Children(i).Code
   Case "SESHOESSTATUS":z1330.seShoesStatus = Children(i).Code
   Case "CDSHOESSTATUS":z1330.cdShoesStatus = Children(i).Code
   Case "SEDEPARTMENT":z1330.seDepartment = Children(i).Code
   Case "CDDEPARTMENT":z1330.cdDepartment = Children(i).Code
   Case "SUPPLIERCODE":z1330.SupplierCode = Children(i).Code
   Case "MATERIALPRICE":z1330.MaterialPrice = Children(i).Code
   Case "SEUNITPRICE":z1330.seUnitPrice = Children(i).Code
   Case "CDUNITPRICE":z1330.cdUnitPrice = Children(i).Code
   Case "QTYCOMPONENT":z1330.QtyComponent = Children(i).Code
   Case "CONSUMPTION":z1330.Consumption = Children(i).Code
   Case "LOSS":z1330.Loss = Children(i).Code
   Case "GROSSUSAGE":z1330.GrossUsage = Children(i).Code
   Case "MATERIALAMT":z1330.MaterialAMT = Children(i).Code
   Case "TOTALQTY":z1330.TotalQty = Children(i).Code
   Case "TOTALMATERIALAMT":z1330.TotalMaterialAMT = Children(i).Code
   Case "INSERTDATE":z1330.InsertDate = Children(i).Code
   Case "INCHARGEINSERT":z1330.InchargeInsert = Children(i).Code
   Case "UPDATEDATE":z1330.UpdateDate = Children(i).Code
   Case "INCHARGEUPDATE":z1330.InchargeUpdate = Children(i).Code
   Case "ATTACHID":z1330.AttachID = Children(i).Code
   Case "SESUBPROCESS":z1330.seSubProcess = Children(i).Code
   Case "CDSUBPROCESS":z1330.cdSubProcess = Children(i).Code
   Case "REMARK":z1330.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "ORDERNO":z1330.OrderNo = Children(i).Data
   Case "ORDERNOSEQ":z1330.OrderNoSeq = Children(i).Data
   Case "MATERIALSEQ":z1330.MaterialSeq = Children(i).Data
   Case "DSEQ":z1330.DSeq = Children(i).Data
   Case "STATUS":z1330.Status = Children(i).Data
   Case "SEGROUPCOMPONENT":z1330.seGroupComponent = Children(i).Data
   Case "CDGROUPCOMPONENT":z1330.cdGroupComponent = Children(i).Data
   Case "COMPONENTNAME":z1330.ComponentName = Children(i).Data
   Case "MATERIALCODE":z1330.MaterialCode = Children(i).Data
   Case "DESCRIPTION":z1330.Description = Children(i).Data
   Case "COLOR":z1330.Color = Children(i).Data
   Case "SPECIFICATION":z1330.Specification = Children(i).Data
   Case "WIDTH":z1330.Width = Children(i).Data
   Case "HEIGHT":z1330.Height = Children(i).Data
   Case "SIZENAME":z1330.SizeName = Children(i).Data
   Case "COLORNAME":z1330.ColorName = Children(i).Data
   Case "SEUNITMATERIAL":z1330.seUnitMaterial = Children(i).Data
   Case "CDUNITMATERIAL":z1330.cdUnitmaterial = Children(i).Data
   Case "SESHOESSTATUS":z1330.seShoesStatus = Children(i).Data
   Case "CDSHOESSTATUS":z1330.cdShoesStatus = Children(i).Data
   Case "SEDEPARTMENT":z1330.seDepartment = Children(i).Data
   Case "CDDEPARTMENT":z1330.cdDepartment = Children(i).Data
   Case "SUPPLIERCODE":z1330.SupplierCode = Children(i).Data
   Case "MATERIALPRICE":z1330.MaterialPrice = Children(i).Data
   Case "SEUNITPRICE":z1330.seUnitPrice = Children(i).Data
   Case "CDUNITPRICE":z1330.cdUnitPrice = Children(i).Data
   Case "QTYCOMPONENT":z1330.QtyComponent = Children(i).Data
   Case "CONSUMPTION":z1330.Consumption = Children(i).Data
   Case "LOSS":z1330.Loss = Children(i).Data
   Case "GROSSUSAGE":z1330.GrossUsage = Children(i).Data
   Case "MATERIALAMT":z1330.MaterialAMT = Children(i).Data
   Case "TOTALQTY":z1330.TotalQty = Children(i).Data
   Case "TOTALMATERIALAMT":z1330.TotalMaterialAMT = Children(i).Data
   Case "INSERTDATE":z1330.InsertDate = Children(i).Data
   Case "INCHARGEINSERT":z1330.InchargeInsert = Children(i).Data
   Case "UPDATEDATE":z1330.UpdateDate = Children(i).Data
   Case "INCHARGEUPDATE":z1330.InchargeUpdate = Children(i).Data
   Case "ATTACHID":z1330.AttachID = Children(i).Data
   Case "SESUBPROCESS":z1330.seSubProcess = Children(i).Data
   Case "CDSUBPROCESS":z1330.cdSubProcess = Children(i).Data
   Case "REMARK":z1330.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K1330_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K1330_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z1330 As T1330_AREA, Job as String, CheckClear as Boolean, ORDERNO AS String, ORDERNOSEQ AS String, MATERIALSEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K1330_MOVE = False

Try
    If READ_PFK1330(ORDERNO, ORDERNOSEQ, MATERIALSEQ) = True Then
                z1330 = D1330
		K1330_MOVE = True
		else
	If CheckClear  = True then z1330 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK1330")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "ORDERNO":z1330.OrderNo = Children(i).Code
   Case "ORDERNOSEQ":z1330.OrderNoSeq = Children(i).Code
   Case "MATERIALSEQ":z1330.MaterialSeq = Children(i).Code
   Case "DSEQ":z1330.DSeq = Children(i).Code
   Case "STATUS":z1330.Status = Children(i).Code
   Case "SEGROUPCOMPONENT":z1330.seGroupComponent = Children(i).Code
   Case "CDGROUPCOMPONENT":z1330.cdGroupComponent = Children(i).Code
   Case "COMPONENTNAME":z1330.ComponentName = Children(i).Code
   Case "MATERIALCODE":z1330.MaterialCode = Children(i).Code
   Case "DESCRIPTION":z1330.Description = Children(i).Code
   Case "COLOR":z1330.Color = Children(i).Code
   Case "SPECIFICATION":z1330.Specification = Children(i).Code
   Case "WIDTH":z1330.Width = Children(i).Code
   Case "HEIGHT":z1330.Height = Children(i).Code
   Case "SIZENAME":z1330.SizeName = Children(i).Code
   Case "COLORNAME":z1330.ColorName = Children(i).Code
   Case "SEUNITMATERIAL":z1330.seUnitMaterial = Children(i).Code
   Case "CDUNITMATERIAL":z1330.cdUnitmaterial = Children(i).Code
   Case "SESHOESSTATUS":z1330.seShoesStatus = Children(i).Code
   Case "CDSHOESSTATUS":z1330.cdShoesStatus = Children(i).Code
   Case "SEDEPARTMENT":z1330.seDepartment = Children(i).Code
   Case "CDDEPARTMENT":z1330.cdDepartment = Children(i).Code
   Case "SUPPLIERCODE":z1330.SupplierCode = Children(i).Code
   Case "MATERIALPRICE":z1330.MaterialPrice = Children(i).Code
   Case "SEUNITPRICE":z1330.seUnitPrice = Children(i).Code
   Case "CDUNITPRICE":z1330.cdUnitPrice = Children(i).Code
   Case "QTYCOMPONENT":z1330.QtyComponent = Children(i).Code
   Case "CONSUMPTION":z1330.Consumption = Children(i).Code
   Case "LOSS":z1330.Loss = Children(i).Code
   Case "GROSSUSAGE":z1330.GrossUsage = Children(i).Code
   Case "MATERIALAMT":z1330.MaterialAMT = Children(i).Code
   Case "TOTALQTY":z1330.TotalQty = Children(i).Code
   Case "TOTALMATERIALAMT":z1330.TotalMaterialAMT = Children(i).Code
   Case "INSERTDATE":z1330.InsertDate = Children(i).Code
   Case "INCHARGEINSERT":z1330.InchargeInsert = Children(i).Code
   Case "UPDATEDATE":z1330.UpdateDate = Children(i).Code
   Case "INCHARGEUPDATE":z1330.InchargeUpdate = Children(i).Code
   Case "ATTACHID":z1330.AttachID = Children(i).Code
   Case "SESUBPROCESS":z1330.seSubProcess = Children(i).Code
   Case "CDSUBPROCESS":z1330.cdSubProcess = Children(i).Code
   Case "REMARK":z1330.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "ORDERNO":z1330.OrderNo = Children(i).Data
   Case "ORDERNOSEQ":z1330.OrderNoSeq = Children(i).Data
   Case "MATERIALSEQ":z1330.MaterialSeq = Children(i).Data
   Case "DSEQ":z1330.DSeq = Children(i).Data
   Case "STATUS":z1330.Status = Children(i).Data
   Case "SEGROUPCOMPONENT":z1330.seGroupComponent = Children(i).Data
   Case "CDGROUPCOMPONENT":z1330.cdGroupComponent = Children(i).Data
   Case "COMPONENTNAME":z1330.ComponentName = Children(i).Data
   Case "MATERIALCODE":z1330.MaterialCode = Children(i).Data
   Case "DESCRIPTION":z1330.Description = Children(i).Data
   Case "COLOR":z1330.Color = Children(i).Data
   Case "SPECIFICATION":z1330.Specification = Children(i).Data
   Case "WIDTH":z1330.Width = Children(i).Data
   Case "HEIGHT":z1330.Height = Children(i).Data
   Case "SIZENAME":z1330.SizeName = Children(i).Data
   Case "COLORNAME":z1330.ColorName = Children(i).Data
   Case "SEUNITMATERIAL":z1330.seUnitMaterial = Children(i).Data
   Case "CDUNITMATERIAL":z1330.cdUnitmaterial = Children(i).Data
   Case "SESHOESSTATUS":z1330.seShoesStatus = Children(i).Data
   Case "CDSHOESSTATUS":z1330.cdShoesStatus = Children(i).Data
   Case "SEDEPARTMENT":z1330.seDepartment = Children(i).Data
   Case "CDDEPARTMENT":z1330.cdDepartment = Children(i).Data
   Case "SUPPLIERCODE":z1330.SupplierCode = Children(i).Data
   Case "MATERIALPRICE":z1330.MaterialPrice = Children(i).Data
   Case "SEUNITPRICE":z1330.seUnitPrice = Children(i).Data
   Case "CDUNITPRICE":z1330.cdUnitPrice = Children(i).Data
   Case "QTYCOMPONENT":z1330.QtyComponent = Children(i).Data
   Case "CONSUMPTION":z1330.Consumption = Children(i).Data
   Case "LOSS":z1330.Loss = Children(i).Data
   Case "GROSSUSAGE":z1330.GrossUsage = Children(i).Data
   Case "MATERIALAMT":z1330.MaterialAMT = Children(i).Data
   Case "TOTALQTY":z1330.TotalQty = Children(i).Data
   Case "TOTALMATERIALAMT":z1330.TotalMaterialAMT = Children(i).Data
   Case "INSERTDATE":z1330.InsertDate = Children(i).Data
   Case "INCHARGEINSERT":z1330.InchargeInsert = Children(i).Data
   Case "UPDATEDATE":z1330.UpdateDate = Children(i).Data
   Case "INCHARGEUPDATE":z1330.InchargeUpdate = Children(i).Data
   Case "ATTACHID":z1330.AttachID = Children(i).Data
   Case "SESUBPROCESS":z1330.seSubProcess = Children(i).Data
   Case "CDSUBPROCESS":z1330.cdSubProcess = Children(i).Data
   Case "REMARK":z1330.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K1330_MOVE",vbCritical)
End Try
End Function 
    
End Module 
