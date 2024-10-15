'=========================================================================================================================================================
'   TABLE : (PFK0111)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K0111

Structure T0111_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	SpecNo	 AS String	'			char(9)		*
Public 	SpecNoSeq	 AS String	'			char(3)		*
Public 	MaterialSeq	 AS Double	'			decimal		*
Public 	DSeq	 AS Double	'			decimal
Public 	Status	 AS String	'			char(1)
Public 	seGroupComponent	 AS String	'			char(3)
Public 	cdGroupComponent	 AS String	'			char(3)
Public 	ComponentName	 AS String	'			nvarchar(50)
Public 	MaterialCode	 AS String	'			char(6)
Public 	Description	 AS String	'			nvarchar(50)
Public 	Color	 AS String	'			nvarchar(50)
Public 	ColorCode	 AS String	'			char(6)
Public 	Specification	 AS String	'			nvarchar(20)
Public 	Width	 AS String	'			nvarchar(20)
Public 	Height	 AS String	'			nvarchar(20)
Public 	SizeName	 AS String	'			nvarchar(20)
Public 	ColorName	 AS String	'			nvarchar(100)
Public 	seUnitMaterial	 AS String	'			char(3)
Public 	cdUnitmaterial	 AS String	'			char(3)
Public 	seShoesStatus	 AS String	'			char(3)
Public 	cdShoesStatus	 AS String	'			char(3)
Public 	seDepartment	 AS String	'			char(3)
Public 	cdDepartment	 AS String	'			char(3)
Public 	SupplierCode	 AS String	'			char(6)
Public 	Price	 AS Double	'			decimal
Public 	seUnitPrice	 AS String	'			char(3)
Public 	cdUnitPrice	 AS String	'			char(3)
Public 	QtyBatchS	 AS Double	'			decimal
Public 	QtyComponent	 AS Double	'			decimal
Public 	Consumption	 AS Double	'			decimal
Public 	Loss	 AS Double	'			decimal
Public 	GrossUsage	 AS Double	'			decimal
Public 	MaterialAMT	 AS Double	'			decimal
Public 	PriceSales	 AS Double	'			decimal
Public 	MaterialAMTSales	 AS Double	'			decimal
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

Public D0111 As T0111_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK0111(SPECNO AS String, SPECNOSEQ AS String, MATERIALSEQ AS Double) As Boolean
    READ_PFK0111 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK0111 "
    SQL = SQL & " WHERE K0111_SpecNo		 = '" & SpecNo & "' " 
    SQL = SQL & "   AND K0111_SpecNoSeq		 = '" & SpecNoSeq & "' " 
    SQL = SQL & "   AND K0111_MaterialSeq		 =  " & MaterialSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D0111_CLEAR: GoTo SKIP_READ_PFK0111
                
    Call K0111_MOVE(rd)
    READ_PFK0111 = True

SKIP_READ_PFK0111:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK0111",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK0111(SPECNO AS String, SPECNOSEQ AS String, MATERIALSEQ AS Double, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK0111 "
    SQL = SQL & " WHERE K0111_SpecNo		 = '" & SpecNo & "' " 
    SQL = SQL & "   AND K0111_SpecNoSeq		 = '" & SpecNoSeq & "' " 
    SQL = SQL & "   AND K0111_MaterialSeq		 =  " & MaterialSeq & "  " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK0111",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK0111(z0111 As T0111_AREA) As Boolean
    WRITE_PFK0111 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z0111)
 
    SQL = " INSERT INTO PFK0111 "
    SQL = SQL & " ( "
    SQL = SQL & " K0111_SpecNo," 
    SQL = SQL & " K0111_SpecNoSeq," 
    SQL = SQL & " K0111_MaterialSeq," 
    SQL = SQL & " K0111_DSeq," 
    SQL = SQL & " K0111_Status," 
    SQL = SQL & " K0111_seGroupComponent," 
    SQL = SQL & " K0111_cdGroupComponent," 
    SQL = SQL & " K0111_ComponentName," 
    SQL = SQL & " K0111_MaterialCode," 
    SQL = SQL & " K0111_Description," 
    SQL = SQL & " K0111_Color," 
    SQL = SQL & " K0111_ColorCode," 
    SQL = SQL & " K0111_Specification," 
    SQL = SQL & " K0111_Width," 
    SQL = SQL & " K0111_Height," 
    SQL = SQL & " K0111_SizeName," 
    SQL = SQL & " K0111_ColorName," 
    SQL = SQL & " K0111_seUnitMaterial," 
    SQL = SQL & " K0111_cdUnitmaterial," 
    SQL = SQL & " K0111_seShoesStatus," 
    SQL = SQL & " K0111_cdShoesStatus," 
    SQL = SQL & " K0111_seDepartment," 
    SQL = SQL & " K0111_cdDepartment," 
    SQL = SQL & " K0111_SupplierCode," 
    SQL = SQL & " K0111_Price," 
    SQL = SQL & " K0111_seUnitPrice," 
    SQL = SQL & " K0111_cdUnitPrice," 
    SQL = SQL & " K0111_QtyBatchS," 
    SQL = SQL & " K0111_QtyComponent," 
    SQL = SQL & " K0111_Consumption," 
    SQL = SQL & " K0111_Loss," 
    SQL = SQL & " K0111_GrossUsage," 
    SQL = SQL & " K0111_MaterialAMT," 
    SQL = SQL & " K0111_PriceSales," 
    SQL = SQL & " K0111_MaterialAMTSales," 
    SQL = SQL & " K0111_InsertDate," 
    SQL = SQL & " K0111_InchargeInsert," 
    SQL = SQL & " K0111_UpdateDate," 
    SQL = SQL & " K0111_InchargeUpdate," 
    SQL = SQL & " K0111_AttachID," 
    SQL = SQL & " K0111_seSubProcess," 
    SQL = SQL & " K0111_cdSubProcess," 
    SQL = SQL & " K0111_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z0111.SpecNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0111.SpecNoSeq) & "', "  
    SQL = SQL & "   " & FormatSQL(z0111.MaterialSeq) & ", "  
    SQL = SQL & "   " & FormatSQL(z0111.DSeq) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z0111.Status) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0111.seGroupComponent) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0111.cdGroupComponent) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0111.ComponentName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0111.MaterialCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0111.Description) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0111.Color) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0111.ColorCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0111.Specification) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0111.Width) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0111.Height) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0111.SizeName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0111.ColorName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0111.seUnitMaterial) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0111.cdUnitmaterial) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0111.seShoesStatus) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0111.cdShoesStatus) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0111.seDepartment) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0111.cdDepartment) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0111.SupplierCode) & "', "  
    SQL = SQL & "   " & FormatSQL(z0111.Price) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z0111.seUnitPrice) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0111.cdUnitPrice) & "', "  
    SQL = SQL & "   " & FormatSQL(z0111.QtyBatchS) & ", "  
    SQL = SQL & "   " & FormatSQL(z0111.QtyComponent) & ", "  
    SQL = SQL & "   " & FormatSQL(z0111.Consumption) & ", "  
    SQL = SQL & "   " & FormatSQL(z0111.Loss) & ", "  
    SQL = SQL & "   " & FormatSQL(z0111.GrossUsage) & ", "  
    SQL = SQL & "   " & FormatSQL(z0111.MaterialAMT) & ", "  
    SQL = SQL & "   " & FormatSQL(z0111.PriceSales) & ", "  
    SQL = SQL & "   " & FormatSQL(z0111.MaterialAMTSales) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z0111.InsertDate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0111.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0111.UpdateDate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0111.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0111.AttachID) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0111.seSubProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0111.cdSubProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0111.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK0111 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK0111",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK0111(z0111 As T0111_AREA) As Boolean
    REWRITE_PFK0111 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z0111)
   
    SQL = " UPDATE PFK0111 SET "
    SQL = SQL & "    K0111_DSeq      =  " & FormatSQL(z0111.DSeq) & ", " 
    SQL = SQL & "    K0111_Status      = N'" & FormatSQL(z0111.Status) & "', " 
    SQL = SQL & "    K0111_seGroupComponent      = N'" & FormatSQL(z0111.seGroupComponent) & "', " 
    SQL = SQL & "    K0111_cdGroupComponent      = N'" & FormatSQL(z0111.cdGroupComponent) & "', " 
    SQL = SQL & "    K0111_ComponentName      = N'" & FormatSQL(z0111.ComponentName) & "', " 
    SQL = SQL & "    K0111_MaterialCode      = N'" & FormatSQL(z0111.MaterialCode) & "', " 
    SQL = SQL & "    K0111_Description      = N'" & FormatSQL(z0111.Description) & "', " 
    SQL = SQL & "    K0111_Color      = N'" & FormatSQL(z0111.Color) & "', " 
    SQL = SQL & "    K0111_ColorCode      = N'" & FormatSQL(z0111.ColorCode) & "', " 
    SQL = SQL & "    K0111_Specification      = N'" & FormatSQL(z0111.Specification) & "', " 
    SQL = SQL & "    K0111_Width      = N'" & FormatSQL(z0111.Width) & "', " 
    SQL = SQL & "    K0111_Height      = N'" & FormatSQL(z0111.Height) & "', " 
    SQL = SQL & "    K0111_SizeName      = N'" & FormatSQL(z0111.SizeName) & "', " 
    SQL = SQL & "    K0111_ColorName      = N'" & FormatSQL(z0111.ColorName) & "', " 
    SQL = SQL & "    K0111_seUnitMaterial      = N'" & FormatSQL(z0111.seUnitMaterial) & "', " 
    SQL = SQL & "    K0111_cdUnitmaterial      = N'" & FormatSQL(z0111.cdUnitmaterial) & "', " 
    SQL = SQL & "    K0111_seShoesStatus      = N'" & FormatSQL(z0111.seShoesStatus) & "', " 
    SQL = SQL & "    K0111_cdShoesStatus      = N'" & FormatSQL(z0111.cdShoesStatus) & "', " 
    SQL = SQL & "    K0111_seDepartment      = N'" & FormatSQL(z0111.seDepartment) & "', " 
    SQL = SQL & "    K0111_cdDepartment      = N'" & FormatSQL(z0111.cdDepartment) & "', " 
    SQL = SQL & "    K0111_SupplierCode      = N'" & FormatSQL(z0111.SupplierCode) & "', " 
    SQL = SQL & "    K0111_Price      =  " & FormatSQL(z0111.Price) & ", " 
    SQL = SQL & "    K0111_seUnitPrice      = N'" & FormatSQL(z0111.seUnitPrice) & "', " 
    SQL = SQL & "    K0111_cdUnitPrice      = N'" & FormatSQL(z0111.cdUnitPrice) & "', " 
    SQL = SQL & "    K0111_QtyBatchS      =  " & FormatSQL(z0111.QtyBatchS) & ", " 
    SQL = SQL & "    K0111_QtyComponent      =  " & FormatSQL(z0111.QtyComponent) & ", " 
    SQL = SQL & "    K0111_Consumption      =  " & FormatSQL(z0111.Consumption) & ", " 
    SQL = SQL & "    K0111_Loss      =  " & FormatSQL(z0111.Loss) & ", " 
    SQL = SQL & "    K0111_GrossUsage      =  " & FormatSQL(z0111.GrossUsage) & ", " 
    SQL = SQL & "    K0111_MaterialAMT      =  " & FormatSQL(z0111.MaterialAMT) & ", " 
    SQL = SQL & "    K0111_PriceSales      =  " & FormatSQL(z0111.PriceSales) & ", " 
    SQL = SQL & "    K0111_MaterialAMTSales      =  " & FormatSQL(z0111.MaterialAMTSales) & ", " 
    SQL = SQL & "    K0111_InsertDate      = N'" & FormatSQL(z0111.InsertDate) & "', " 
    SQL = SQL & "    K0111_InchargeInsert      = N'" & FormatSQL(z0111.InchargeInsert) & "', " 
    SQL = SQL & "    K0111_UpdateDate      = N'" & FormatSQL(z0111.UpdateDate) & "', " 
    SQL = SQL & "    K0111_InchargeUpdate      = N'" & FormatSQL(z0111.InchargeUpdate) & "', " 
    SQL = SQL & "    K0111_AttachID      = N'" & FormatSQL(z0111.AttachID) & "', " 
    SQL = SQL & "    K0111_seSubProcess      = N'" & FormatSQL(z0111.seSubProcess) & "', " 
    SQL = SQL & "    K0111_cdSubProcess      = N'" & FormatSQL(z0111.cdSubProcess) & "', " 
    SQL = SQL & "    K0111_Remark      = N'" & FormatSQL(z0111.Remark) & "'  " 
    SQL = SQL & " WHERE K0111_SpecNo		 = '" & z0111.SpecNo & "' " 
    SQL = SQL & "   AND K0111_SpecNoSeq		 = '" & z0111.SpecNoSeq & "' " 
    SQL = SQL & "   AND K0111_MaterialSeq		 =  " & z0111.MaterialSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK0111 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK0111",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK0111(z0111 As T0111_AREA) As Boolean
    DELETE_PFK0111 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK0111 "
    SQL = SQL & " WHERE K0111_SpecNo		 = '" & z0111.SpecNo & "' " 
    SQL = SQL & "   AND K0111_SpecNoSeq		 = '" & z0111.SpecNoSeq & "' " 
    SQL = SQL & "   AND K0111_MaterialSeq		 =  " & z0111.MaterialSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK0111 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK0111",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D0111_CLEAR()
Try
    
   D0111.SpecNo = ""
   D0111.SpecNoSeq = ""
    D0111.MaterialSeq = 0 
    D0111.DSeq = 0 
   D0111.Status = ""
   D0111.seGroupComponent = ""
   D0111.cdGroupComponent = ""
   D0111.ComponentName = ""
   D0111.MaterialCode = ""
   D0111.Description = ""
   D0111.Color = ""
   D0111.ColorCode = ""
   D0111.Specification = ""
   D0111.Width = ""
   D0111.Height = ""
   D0111.SizeName = ""
   D0111.ColorName = ""
   D0111.seUnitMaterial = ""
   D0111.cdUnitmaterial = ""
   D0111.seShoesStatus = ""
   D0111.cdShoesStatus = ""
   D0111.seDepartment = ""
   D0111.cdDepartment = ""
   D0111.SupplierCode = ""
    D0111.Price = 0 
   D0111.seUnitPrice = ""
   D0111.cdUnitPrice = ""
    D0111.QtyBatchS = 0 
    D0111.QtyComponent = 0 
    D0111.Consumption = 0 
    D0111.Loss = 0 
    D0111.GrossUsage = 0 
    D0111.MaterialAMT = 0 
    D0111.PriceSales = 0 
    D0111.MaterialAMTSales = 0 
   D0111.InsertDate = ""
   D0111.InchargeInsert = ""
   D0111.UpdateDate = ""
   D0111.InchargeUpdate = ""
   D0111.AttachID = ""
   D0111.seSubProcess = ""
   D0111.cdSubProcess = ""
   D0111.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D0111_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x0111 As T0111_AREA)
Try
    
    x0111.SpecNo = trim$(  x0111.SpecNo)
    x0111.SpecNoSeq = trim$(  x0111.SpecNoSeq)
    x0111.MaterialSeq = trim$(  x0111.MaterialSeq)
    x0111.DSeq = trim$(  x0111.DSeq)
    x0111.Status = trim$(  x0111.Status)
    x0111.seGroupComponent = trim$(  x0111.seGroupComponent)
    x0111.cdGroupComponent = trim$(  x0111.cdGroupComponent)
    x0111.ComponentName = trim$(  x0111.ComponentName)
    x0111.MaterialCode = trim$(  x0111.MaterialCode)
    x0111.Description = trim$(  x0111.Description)
    x0111.Color = trim$(  x0111.Color)
    x0111.ColorCode = trim$(  x0111.ColorCode)
    x0111.Specification = trim$(  x0111.Specification)
    x0111.Width = trim$(  x0111.Width)
    x0111.Height = trim$(  x0111.Height)
    x0111.SizeName = trim$(  x0111.SizeName)
    x0111.ColorName = trim$(  x0111.ColorName)
    x0111.seUnitMaterial = trim$(  x0111.seUnitMaterial)
    x0111.cdUnitmaterial = trim$(  x0111.cdUnitmaterial)
    x0111.seShoesStatus = trim$(  x0111.seShoesStatus)
    x0111.cdShoesStatus = trim$(  x0111.cdShoesStatus)
    x0111.seDepartment = trim$(  x0111.seDepartment)
    x0111.cdDepartment = trim$(  x0111.cdDepartment)
    x0111.SupplierCode = trim$(  x0111.SupplierCode)
    x0111.Price = trim$(  x0111.Price)
    x0111.seUnitPrice = trim$(  x0111.seUnitPrice)
    x0111.cdUnitPrice = trim$(  x0111.cdUnitPrice)
    x0111.QtyBatchS = trim$(  x0111.QtyBatchS)
    x0111.QtyComponent = trim$(  x0111.QtyComponent)
    x0111.Consumption = trim$(  x0111.Consumption)
    x0111.Loss = trim$(  x0111.Loss)
    x0111.GrossUsage = trim$(  x0111.GrossUsage)
    x0111.MaterialAMT = trim$(  x0111.MaterialAMT)
    x0111.PriceSales = trim$(  x0111.PriceSales)
    x0111.MaterialAMTSales = trim$(  x0111.MaterialAMTSales)
    x0111.InsertDate = trim$(  x0111.InsertDate)
    x0111.InchargeInsert = trim$(  x0111.InchargeInsert)
    x0111.UpdateDate = trim$(  x0111.UpdateDate)
    x0111.InchargeUpdate = trim$(  x0111.InchargeUpdate)
    x0111.AttachID = trim$(  x0111.AttachID)
    x0111.seSubProcess = trim$(  x0111.seSubProcess)
    x0111.cdSubProcess = trim$(  x0111.cdSubProcess)
    x0111.Remark = trim$(  x0111.Remark)
     
    If trim$( x0111.SpecNo ) = "" Then x0111.SpecNo = Space(1) 
    If trim$( x0111.SpecNoSeq ) = "" Then x0111.SpecNoSeq = Space(1) 
    If trim$( x0111.MaterialSeq ) = "" Then x0111.MaterialSeq = 0 
    If trim$( x0111.DSeq ) = "" Then x0111.DSeq = 0 
    If trim$( x0111.Status ) = "" Then x0111.Status = Space(1) 
    If trim$( x0111.seGroupComponent ) = "" Then x0111.seGroupComponent = Space(1) 
    If trim$( x0111.cdGroupComponent ) = "" Then x0111.cdGroupComponent = Space(1) 
    If trim$( x0111.ComponentName ) = "" Then x0111.ComponentName = Space(1) 
    If trim$( x0111.MaterialCode ) = "" Then x0111.MaterialCode = Space(1) 
    If trim$( x0111.Description ) = "" Then x0111.Description = Space(1) 
    If trim$( x0111.Color ) = "" Then x0111.Color = Space(1) 
    If trim$( x0111.ColorCode ) = "" Then x0111.ColorCode = Space(1) 
    If trim$( x0111.Specification ) = "" Then x0111.Specification = Space(1) 
    If trim$( x0111.Width ) = "" Then x0111.Width = Space(1) 
    If trim$( x0111.Height ) = "" Then x0111.Height = Space(1) 
    If trim$( x0111.SizeName ) = "" Then x0111.SizeName = Space(1) 
    If trim$( x0111.ColorName ) = "" Then x0111.ColorName = Space(1) 
    If trim$( x0111.seUnitMaterial ) = "" Then x0111.seUnitMaterial = Space(1) 
    If trim$( x0111.cdUnitmaterial ) = "" Then x0111.cdUnitmaterial = Space(1) 
    If trim$( x0111.seShoesStatus ) = "" Then x0111.seShoesStatus = Space(1) 
    If trim$( x0111.cdShoesStatus ) = "" Then x0111.cdShoesStatus = Space(1) 
    If trim$( x0111.seDepartment ) = "" Then x0111.seDepartment = Space(1) 
    If trim$( x0111.cdDepartment ) = "" Then x0111.cdDepartment = Space(1) 
    If trim$( x0111.SupplierCode ) = "" Then x0111.SupplierCode = Space(1) 
    If trim$( x0111.Price ) = "" Then x0111.Price = 0 
    If trim$( x0111.seUnitPrice ) = "" Then x0111.seUnitPrice = Space(1) 
    If trim$( x0111.cdUnitPrice ) = "" Then x0111.cdUnitPrice = Space(1) 
    If trim$( x0111.QtyBatchS ) = "" Then x0111.QtyBatchS = 0 
    If trim$( x0111.QtyComponent ) = "" Then x0111.QtyComponent = 0 
    If trim$( x0111.Consumption ) = "" Then x0111.Consumption = 0 
    If trim$( x0111.Loss ) = "" Then x0111.Loss = 0 
    If trim$( x0111.GrossUsage ) = "" Then x0111.GrossUsage = 0 
    If trim$( x0111.MaterialAMT ) = "" Then x0111.MaterialAMT = 0 
    If trim$( x0111.PriceSales ) = "" Then x0111.PriceSales = 0 
    If trim$( x0111.MaterialAMTSales ) = "" Then x0111.MaterialAMTSales = 0 
    If trim$( x0111.InsertDate ) = "" Then x0111.InsertDate = Space(1) 
    If trim$( x0111.InchargeInsert ) = "" Then x0111.InchargeInsert = Space(1) 
    If trim$( x0111.UpdateDate ) = "" Then x0111.UpdateDate = Space(1) 
    If trim$( x0111.InchargeUpdate ) = "" Then x0111.InchargeUpdate = Space(1) 
    If trim$( x0111.AttachID ) = "" Then x0111.AttachID = Space(1) 
    If trim$( x0111.seSubProcess ) = "" Then x0111.seSubProcess = Space(1) 
    If trim$( x0111.cdSubProcess ) = "" Then x0111.cdSubProcess = Space(1) 
    If trim$( x0111.Remark ) = "" Then x0111.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K0111_MOVE(rs0111 As SqlClient.SqlDataReader)
Try

    call D0111_CLEAR()   

    If IsdbNull(rs0111!K0111_SpecNo) = False Then D0111.SpecNo = Trim$(rs0111!K0111_SpecNo)
    If IsdbNull(rs0111!K0111_SpecNoSeq) = False Then D0111.SpecNoSeq = Trim$(rs0111!K0111_SpecNoSeq)
    If IsdbNull(rs0111!K0111_MaterialSeq) = False Then D0111.MaterialSeq = Trim$(rs0111!K0111_MaterialSeq)
    If IsdbNull(rs0111!K0111_DSeq) = False Then D0111.DSeq = Trim$(rs0111!K0111_DSeq)
    If IsdbNull(rs0111!K0111_Status) = False Then D0111.Status = Trim$(rs0111!K0111_Status)
    If IsdbNull(rs0111!K0111_seGroupComponent) = False Then D0111.seGroupComponent = Trim$(rs0111!K0111_seGroupComponent)
    If IsdbNull(rs0111!K0111_cdGroupComponent) = False Then D0111.cdGroupComponent = Trim$(rs0111!K0111_cdGroupComponent)
    If IsdbNull(rs0111!K0111_ComponentName) = False Then D0111.ComponentName = Trim$(rs0111!K0111_ComponentName)
    If IsdbNull(rs0111!K0111_MaterialCode) = False Then D0111.MaterialCode = Trim$(rs0111!K0111_MaterialCode)
    If IsdbNull(rs0111!K0111_Description) = False Then D0111.Description = Trim$(rs0111!K0111_Description)
    If IsdbNull(rs0111!K0111_Color) = False Then D0111.Color = Trim$(rs0111!K0111_Color)
    If IsdbNull(rs0111!K0111_ColorCode) = False Then D0111.ColorCode = Trim$(rs0111!K0111_ColorCode)
    If IsdbNull(rs0111!K0111_Specification) = False Then D0111.Specification = Trim$(rs0111!K0111_Specification)
    If IsdbNull(rs0111!K0111_Width) = False Then D0111.Width = Trim$(rs0111!K0111_Width)
    If IsdbNull(rs0111!K0111_Height) = False Then D0111.Height = Trim$(rs0111!K0111_Height)
    If IsdbNull(rs0111!K0111_SizeName) = False Then D0111.SizeName = Trim$(rs0111!K0111_SizeName)
    If IsdbNull(rs0111!K0111_ColorName) = False Then D0111.ColorName = Trim$(rs0111!K0111_ColorName)
    If IsdbNull(rs0111!K0111_seUnitMaterial) = False Then D0111.seUnitMaterial = Trim$(rs0111!K0111_seUnitMaterial)
    If IsdbNull(rs0111!K0111_cdUnitmaterial) = False Then D0111.cdUnitmaterial = Trim$(rs0111!K0111_cdUnitmaterial)
    If IsdbNull(rs0111!K0111_seShoesStatus) = False Then D0111.seShoesStatus = Trim$(rs0111!K0111_seShoesStatus)
    If IsdbNull(rs0111!K0111_cdShoesStatus) = False Then D0111.cdShoesStatus = Trim$(rs0111!K0111_cdShoesStatus)
    If IsdbNull(rs0111!K0111_seDepartment) = False Then D0111.seDepartment = Trim$(rs0111!K0111_seDepartment)
    If IsdbNull(rs0111!K0111_cdDepartment) = False Then D0111.cdDepartment = Trim$(rs0111!K0111_cdDepartment)
    If IsdbNull(rs0111!K0111_SupplierCode) = False Then D0111.SupplierCode = Trim$(rs0111!K0111_SupplierCode)
    If IsdbNull(rs0111!K0111_Price) = False Then D0111.Price = Trim$(rs0111!K0111_Price)
    If IsdbNull(rs0111!K0111_seUnitPrice) = False Then D0111.seUnitPrice = Trim$(rs0111!K0111_seUnitPrice)
    If IsdbNull(rs0111!K0111_cdUnitPrice) = False Then D0111.cdUnitPrice = Trim$(rs0111!K0111_cdUnitPrice)
    If IsdbNull(rs0111!K0111_QtyBatchS) = False Then D0111.QtyBatchS = Trim$(rs0111!K0111_QtyBatchS)
    If IsdbNull(rs0111!K0111_QtyComponent) = False Then D0111.QtyComponent = Trim$(rs0111!K0111_QtyComponent)
    If IsdbNull(rs0111!K0111_Consumption) = False Then D0111.Consumption = Trim$(rs0111!K0111_Consumption)
    If IsdbNull(rs0111!K0111_Loss) = False Then D0111.Loss = Trim$(rs0111!K0111_Loss)
    If IsdbNull(rs0111!K0111_GrossUsage) = False Then D0111.GrossUsage = Trim$(rs0111!K0111_GrossUsage)
    If IsdbNull(rs0111!K0111_MaterialAMT) = False Then D0111.MaterialAMT = Trim$(rs0111!K0111_MaterialAMT)
    If IsdbNull(rs0111!K0111_PriceSales) = False Then D0111.PriceSales = Trim$(rs0111!K0111_PriceSales)
    If IsdbNull(rs0111!K0111_MaterialAMTSales) = False Then D0111.MaterialAMTSales = Trim$(rs0111!K0111_MaterialAMTSales)
    If IsdbNull(rs0111!K0111_InsertDate) = False Then D0111.InsertDate = Trim$(rs0111!K0111_InsertDate)
    If IsdbNull(rs0111!K0111_InchargeInsert) = False Then D0111.InchargeInsert = Trim$(rs0111!K0111_InchargeInsert)
    If IsdbNull(rs0111!K0111_UpdateDate) = False Then D0111.UpdateDate = Trim$(rs0111!K0111_UpdateDate)
    If IsdbNull(rs0111!K0111_InchargeUpdate) = False Then D0111.InchargeUpdate = Trim$(rs0111!K0111_InchargeUpdate)
    If IsdbNull(rs0111!K0111_AttachID) = False Then D0111.AttachID = Trim$(rs0111!K0111_AttachID)
    If IsdbNull(rs0111!K0111_seSubProcess) = False Then D0111.seSubProcess = Trim$(rs0111!K0111_seSubProcess)
    If IsdbNull(rs0111!K0111_cdSubProcess) = False Then D0111.cdSubProcess = Trim$(rs0111!K0111_cdSubProcess)
    If IsdbNull(rs0111!K0111_Remark) = False Then D0111.Remark = Trim$(rs0111!K0111_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K0111_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K0111_MOVE(rs0111 As DataRow)
Try

    call D0111_CLEAR()   

    If IsdbNull(rs0111!K0111_SpecNo) = False Then D0111.SpecNo = Trim$(rs0111!K0111_SpecNo)
    If IsdbNull(rs0111!K0111_SpecNoSeq) = False Then D0111.SpecNoSeq = Trim$(rs0111!K0111_SpecNoSeq)
    If IsdbNull(rs0111!K0111_MaterialSeq) = False Then D0111.MaterialSeq = Trim$(rs0111!K0111_MaterialSeq)
    If IsdbNull(rs0111!K0111_DSeq) = False Then D0111.DSeq = Trim$(rs0111!K0111_DSeq)
    If IsdbNull(rs0111!K0111_Status) = False Then D0111.Status = Trim$(rs0111!K0111_Status)
    If IsdbNull(rs0111!K0111_seGroupComponent) = False Then D0111.seGroupComponent = Trim$(rs0111!K0111_seGroupComponent)
    If IsdbNull(rs0111!K0111_cdGroupComponent) = False Then D0111.cdGroupComponent = Trim$(rs0111!K0111_cdGroupComponent)
    If IsdbNull(rs0111!K0111_ComponentName) = False Then D0111.ComponentName = Trim$(rs0111!K0111_ComponentName)
    If IsdbNull(rs0111!K0111_MaterialCode) = False Then D0111.MaterialCode = Trim$(rs0111!K0111_MaterialCode)
    If IsdbNull(rs0111!K0111_Description) = False Then D0111.Description = Trim$(rs0111!K0111_Description)
    If IsdbNull(rs0111!K0111_Color) = False Then D0111.Color = Trim$(rs0111!K0111_Color)
    If IsdbNull(rs0111!K0111_ColorCode) = False Then D0111.ColorCode = Trim$(rs0111!K0111_ColorCode)
    If IsdbNull(rs0111!K0111_Specification) = False Then D0111.Specification = Trim$(rs0111!K0111_Specification)
    If IsdbNull(rs0111!K0111_Width) = False Then D0111.Width = Trim$(rs0111!K0111_Width)
    If IsdbNull(rs0111!K0111_Height) = False Then D0111.Height = Trim$(rs0111!K0111_Height)
    If IsdbNull(rs0111!K0111_SizeName) = False Then D0111.SizeName = Trim$(rs0111!K0111_SizeName)
    If IsdbNull(rs0111!K0111_ColorName) = False Then D0111.ColorName = Trim$(rs0111!K0111_ColorName)
    If IsdbNull(rs0111!K0111_seUnitMaterial) = False Then D0111.seUnitMaterial = Trim$(rs0111!K0111_seUnitMaterial)
    If IsdbNull(rs0111!K0111_cdUnitmaterial) = False Then D0111.cdUnitmaterial = Trim$(rs0111!K0111_cdUnitmaterial)
    If IsdbNull(rs0111!K0111_seShoesStatus) = False Then D0111.seShoesStatus = Trim$(rs0111!K0111_seShoesStatus)
    If IsdbNull(rs0111!K0111_cdShoesStatus) = False Then D0111.cdShoesStatus = Trim$(rs0111!K0111_cdShoesStatus)
    If IsdbNull(rs0111!K0111_seDepartment) = False Then D0111.seDepartment = Trim$(rs0111!K0111_seDepartment)
    If IsdbNull(rs0111!K0111_cdDepartment) = False Then D0111.cdDepartment = Trim$(rs0111!K0111_cdDepartment)
    If IsdbNull(rs0111!K0111_SupplierCode) = False Then D0111.SupplierCode = Trim$(rs0111!K0111_SupplierCode)
    If IsdbNull(rs0111!K0111_Price) = False Then D0111.Price = Trim$(rs0111!K0111_Price)
    If IsdbNull(rs0111!K0111_seUnitPrice) = False Then D0111.seUnitPrice = Trim$(rs0111!K0111_seUnitPrice)
    If IsdbNull(rs0111!K0111_cdUnitPrice) = False Then D0111.cdUnitPrice = Trim$(rs0111!K0111_cdUnitPrice)
    If IsdbNull(rs0111!K0111_QtyBatchS) = False Then D0111.QtyBatchS = Trim$(rs0111!K0111_QtyBatchS)
    If IsdbNull(rs0111!K0111_QtyComponent) = False Then D0111.QtyComponent = Trim$(rs0111!K0111_QtyComponent)
    If IsdbNull(rs0111!K0111_Consumption) = False Then D0111.Consumption = Trim$(rs0111!K0111_Consumption)
    If IsdbNull(rs0111!K0111_Loss) = False Then D0111.Loss = Trim$(rs0111!K0111_Loss)
    If IsdbNull(rs0111!K0111_GrossUsage) = False Then D0111.GrossUsage = Trim$(rs0111!K0111_GrossUsage)
    If IsdbNull(rs0111!K0111_MaterialAMT) = False Then D0111.MaterialAMT = Trim$(rs0111!K0111_MaterialAMT)
    If IsdbNull(rs0111!K0111_PriceSales) = False Then D0111.PriceSales = Trim$(rs0111!K0111_PriceSales)
    If IsdbNull(rs0111!K0111_MaterialAMTSales) = False Then D0111.MaterialAMTSales = Trim$(rs0111!K0111_MaterialAMTSales)
    If IsdbNull(rs0111!K0111_InsertDate) = False Then D0111.InsertDate = Trim$(rs0111!K0111_InsertDate)
    If IsdbNull(rs0111!K0111_InchargeInsert) = False Then D0111.InchargeInsert = Trim$(rs0111!K0111_InchargeInsert)
    If IsdbNull(rs0111!K0111_UpdateDate) = False Then D0111.UpdateDate = Trim$(rs0111!K0111_UpdateDate)
    If IsdbNull(rs0111!K0111_InchargeUpdate) = False Then D0111.InchargeUpdate = Trim$(rs0111!K0111_InchargeUpdate)
    If IsdbNull(rs0111!K0111_AttachID) = False Then D0111.AttachID = Trim$(rs0111!K0111_AttachID)
    If IsdbNull(rs0111!K0111_seSubProcess) = False Then D0111.seSubProcess = Trim$(rs0111!K0111_seSubProcess)
    If IsdbNull(rs0111!K0111_cdSubProcess) = False Then D0111.cdSubProcess = Trim$(rs0111!K0111_cdSubProcess)
    If IsdbNull(rs0111!K0111_Remark) = False Then D0111.Remark = Trim$(rs0111!K0111_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K0111_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K0111_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z0111 As T0111_AREA, SPECNO AS String, SPECNOSEQ AS String, MATERIALSEQ AS Double) as Boolean

K0111_MOVE = False

Try
    If READ_PFK0111(SPECNO, SPECNOSEQ, MATERIALSEQ) = True Then
                z0111 = D0111
		K0111_MOVE = True
		else
	z0111 = nothing
     End If

     If  getColumIndex(spr,"SpecNo") > -1 then z0111.SpecNo = getDataM(spr, getColumIndex(spr,"SpecNo"), xRow)
     If  getColumIndex(spr,"SpecNoSeq") > -1 then z0111.SpecNoSeq = getDataM(spr, getColumIndex(spr,"SpecNoSeq"), xRow)
     If  getColumIndex(spr,"MaterialSeq") > -1 then z0111.MaterialSeq = getDataM(spr, getColumIndex(spr,"MaterialSeq"), xRow)
     If  getColumIndex(spr,"DSeq") > -1 then z0111.DSeq = getDataM(spr, getColumIndex(spr,"DSeq"), xRow)
     If  getColumIndex(spr,"Status") > -1 then z0111.Status = getDataM(spr, getColumIndex(spr,"Status"), xRow)
     If  getColumIndex(spr,"seGroupComponent") > -1 then z0111.seGroupComponent = getDataM(spr, getColumIndex(spr,"seGroupComponent"), xRow)
     If  getColumIndex(spr,"cdGroupComponent") > -1 then z0111.cdGroupComponent = getDataM(spr, getColumIndex(spr,"cdGroupComponent"), xRow)
     If  getColumIndex(spr,"ComponentName") > -1 then z0111.ComponentName = getDataM(spr, getColumIndex(spr,"ComponentName"), xRow)
     If  getColumIndex(spr,"MaterialCode") > -1 then z0111.MaterialCode = getDataM(spr, getColumIndex(spr,"MaterialCode"), xRow)
     If  getColumIndex(spr,"Description") > -1 then z0111.Description = getDataM(spr, getColumIndex(spr,"Description"), xRow)
     If  getColumIndex(spr,"Color") > -1 then z0111.Color = getDataM(spr, getColumIndex(spr,"Color"), xRow)
     If  getColumIndex(spr,"ColorCode") > -1 then z0111.ColorCode = getDataM(spr, getColumIndex(spr,"ColorCode"), xRow)
     If  getColumIndex(spr,"Specification") > -1 then z0111.Specification = getDataM(spr, getColumIndex(spr,"Specification"), xRow)
     If  getColumIndex(spr,"Width") > -1 then z0111.Width = getDataM(spr, getColumIndex(spr,"Width"), xRow)
     If  getColumIndex(spr,"Height") > -1 then z0111.Height = getDataM(spr, getColumIndex(spr,"Height"), xRow)
     If  getColumIndex(spr,"SizeName") > -1 then z0111.SizeName = getDataM(spr, getColumIndex(spr,"SizeName"), xRow)
     If  getColumIndex(spr,"ColorName") > -1 then z0111.ColorName = getDataM(spr, getColumIndex(spr,"ColorName"), xRow)
     If  getColumIndex(spr,"seUnitMaterial") > -1 then z0111.seUnitMaterial = getDataM(spr, getColumIndex(spr,"seUnitMaterial"), xRow)
     If  getColumIndex(spr,"cdUnitmaterial") > -1 then z0111.cdUnitmaterial = getDataM(spr, getColumIndex(spr,"cdUnitmaterial"), xRow)
     If  getColumIndex(spr,"seShoesStatus") > -1 then z0111.seShoesStatus = getDataM(spr, getColumIndex(spr,"seShoesStatus"), xRow)
     If  getColumIndex(spr,"cdShoesStatus") > -1 then z0111.cdShoesStatus = getDataM(spr, getColumIndex(spr,"cdShoesStatus"), xRow)
     If  getColumIndex(spr,"seDepartment") > -1 then z0111.seDepartment = getDataM(spr, getColumIndex(spr,"seDepartment"), xRow)
     If  getColumIndex(spr,"cdDepartment") > -1 then z0111.cdDepartment = getDataM(spr, getColumIndex(spr,"cdDepartment"), xRow)
     If  getColumIndex(spr,"SupplierCode") > -1 then z0111.SupplierCode = getDataM(spr, getColumIndex(spr,"SupplierCode"), xRow)
     If  getColumIndex(spr,"Price") > -1 then z0111.Price = getDataM(spr, getColumIndex(spr,"Price"), xRow)
     If  getColumIndex(spr,"seUnitPrice") > -1 then z0111.seUnitPrice = getDataM(spr, getColumIndex(spr,"seUnitPrice"), xRow)
     If  getColumIndex(spr,"cdUnitPrice") > -1 then z0111.cdUnitPrice = getDataM(spr, getColumIndex(spr,"cdUnitPrice"), xRow)
     If  getColumIndex(spr,"QtyBatchS") > -1 then z0111.QtyBatchS = getDataM(spr, getColumIndex(spr,"QtyBatchS"), xRow)
     If  getColumIndex(spr,"QtyComponent") > -1 then z0111.QtyComponent = getDataM(spr, getColumIndex(spr,"QtyComponent"), xRow)
     If  getColumIndex(spr,"Consumption") > -1 then z0111.Consumption = getDataM(spr, getColumIndex(spr,"Consumption"), xRow)
     If  getColumIndex(spr,"Loss") > -1 then z0111.Loss = getDataM(spr, getColumIndex(spr,"Loss"), xRow)
     If  getColumIndex(spr,"GrossUsage") > -1 then z0111.GrossUsage = getDataM(spr, getColumIndex(spr,"GrossUsage"), xRow)
     If  getColumIndex(spr,"MaterialAMT") > -1 then z0111.MaterialAMT = getDataM(spr, getColumIndex(spr,"MaterialAMT"), xRow)
     If  getColumIndex(spr,"PriceSales") > -1 then z0111.PriceSales = getDataM(spr, getColumIndex(spr,"PriceSales"), xRow)
     If  getColumIndex(spr,"MaterialAMTSales") > -1 then z0111.MaterialAMTSales = getDataM(spr, getColumIndex(spr,"MaterialAMTSales"), xRow)
     If  getColumIndex(spr,"InsertDate") > -1 then z0111.InsertDate = getDataM(spr, getColumIndex(spr,"InsertDate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z0111.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"UpdateDate") > -1 then z0111.UpdateDate = getDataM(spr, getColumIndex(spr,"UpdateDate"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z0111.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"AttachID") > -1 then z0111.AttachID = getDataM(spr, getColumIndex(spr,"AttachID"), xRow)
     If  getColumIndex(spr,"seSubProcess") > -1 then z0111.seSubProcess = getDataM(spr, getColumIndex(spr,"seSubProcess"), xRow)
     If  getColumIndex(spr,"cdSubProcess") > -1 then z0111.cdSubProcess = getDataM(spr, getColumIndex(spr,"cdSubProcess"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z0111.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K0111_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K0111_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z0111 As T0111_AREA,CheckClear as Boolean,SPECNO AS String, SPECNOSEQ AS String, MATERIALSEQ AS Double) as Boolean

K0111_MOVE = False

Try
    If READ_PFK0111(SPECNO, SPECNOSEQ, MATERIALSEQ) = True Then
                z0111 = D0111
		K0111_MOVE = True
		else
	If CheckClear  = True then z0111 = nothing
     End If

     If  getColumIndex(spr,"SpecNo") > -1 then z0111.SpecNo = getDataM(spr, getColumIndex(spr,"SpecNo"), xRow)
     If  getColumIndex(spr,"SpecNoSeq") > -1 then z0111.SpecNoSeq = getDataM(spr, getColumIndex(spr,"SpecNoSeq"), xRow)
     If  getColumIndex(spr,"MaterialSeq") > -1 then z0111.MaterialSeq = getDataM(spr, getColumIndex(spr,"MaterialSeq"), xRow)
     If  getColumIndex(spr,"DSeq") > -1 then z0111.DSeq = getDataM(spr, getColumIndex(spr,"DSeq"), xRow)
     If  getColumIndex(spr,"Status") > -1 then z0111.Status = getDataM(spr, getColumIndex(spr,"Status"), xRow)
     If  getColumIndex(spr,"seGroupComponent") > -1 then z0111.seGroupComponent = getDataM(spr, getColumIndex(spr,"seGroupComponent"), xRow)
     If  getColumIndex(spr,"cdGroupComponent") > -1 then z0111.cdGroupComponent = getDataM(spr, getColumIndex(spr,"cdGroupComponent"), xRow)
     If  getColumIndex(spr,"ComponentName") > -1 then z0111.ComponentName = getDataM(spr, getColumIndex(spr,"ComponentName"), xRow)
     If  getColumIndex(spr,"MaterialCode") > -1 then z0111.MaterialCode = getDataM(spr, getColumIndex(spr,"MaterialCode"), xRow)
     If  getColumIndex(spr,"Description") > -1 then z0111.Description = getDataM(spr, getColumIndex(spr,"Description"), xRow)
     If  getColumIndex(spr,"Color") > -1 then z0111.Color = getDataM(spr, getColumIndex(spr,"Color"), xRow)
     If  getColumIndex(spr,"ColorCode") > -1 then z0111.ColorCode = getDataM(spr, getColumIndex(spr,"ColorCode"), xRow)
     If  getColumIndex(spr,"Specification") > -1 then z0111.Specification = getDataM(spr, getColumIndex(spr,"Specification"), xRow)
     If  getColumIndex(spr,"Width") > -1 then z0111.Width = getDataM(spr, getColumIndex(spr,"Width"), xRow)
     If  getColumIndex(spr,"Height") > -1 then z0111.Height = getDataM(spr, getColumIndex(spr,"Height"), xRow)
     If  getColumIndex(spr,"SizeName") > -1 then z0111.SizeName = getDataM(spr, getColumIndex(spr,"SizeName"), xRow)
     If  getColumIndex(spr,"ColorName") > -1 then z0111.ColorName = getDataM(spr, getColumIndex(spr,"ColorName"), xRow)
     If  getColumIndex(spr,"seUnitMaterial") > -1 then z0111.seUnitMaterial = getDataM(spr, getColumIndex(spr,"seUnitMaterial"), xRow)
     If  getColumIndex(spr,"cdUnitmaterial") > -1 then z0111.cdUnitmaterial = getDataM(spr, getColumIndex(spr,"cdUnitmaterial"), xRow)
     If  getColumIndex(spr,"seShoesStatus") > -1 then z0111.seShoesStatus = getDataM(spr, getColumIndex(spr,"seShoesStatus"), xRow)
     If  getColumIndex(spr,"cdShoesStatus") > -1 then z0111.cdShoesStatus = getDataM(spr, getColumIndex(spr,"cdShoesStatus"), xRow)
     If  getColumIndex(spr,"seDepartment") > -1 then z0111.seDepartment = getDataM(spr, getColumIndex(spr,"seDepartment"), xRow)
     If  getColumIndex(spr,"cdDepartment") > -1 then z0111.cdDepartment = getDataM(spr, getColumIndex(spr,"cdDepartment"), xRow)
     If  getColumIndex(spr,"SupplierCode") > -1 then z0111.SupplierCode = getDataM(spr, getColumIndex(spr,"SupplierCode"), xRow)
     If  getColumIndex(spr,"Price") > -1 then z0111.Price = getDataM(spr, getColumIndex(spr,"Price"), xRow)
     If  getColumIndex(spr,"seUnitPrice") > -1 then z0111.seUnitPrice = getDataM(spr, getColumIndex(spr,"seUnitPrice"), xRow)
     If  getColumIndex(spr,"cdUnitPrice") > -1 then z0111.cdUnitPrice = getDataM(spr, getColumIndex(spr,"cdUnitPrice"), xRow)
     If  getColumIndex(spr,"QtyBatchS") > -1 then z0111.QtyBatchS = getDataM(spr, getColumIndex(spr,"QtyBatchS"), xRow)
     If  getColumIndex(spr,"QtyComponent") > -1 then z0111.QtyComponent = getDataM(spr, getColumIndex(spr,"QtyComponent"), xRow)
     If  getColumIndex(spr,"Consumption") > -1 then z0111.Consumption = getDataM(spr, getColumIndex(spr,"Consumption"), xRow)
     If  getColumIndex(spr,"Loss") > -1 then z0111.Loss = getDataM(spr, getColumIndex(spr,"Loss"), xRow)
     If  getColumIndex(spr,"GrossUsage") > -1 then z0111.GrossUsage = getDataM(spr, getColumIndex(spr,"GrossUsage"), xRow)
     If  getColumIndex(spr,"MaterialAMT") > -1 then z0111.MaterialAMT = getDataM(spr, getColumIndex(spr,"MaterialAMT"), xRow)
     If  getColumIndex(spr,"PriceSales") > -1 then z0111.PriceSales = getDataM(spr, getColumIndex(spr,"PriceSales"), xRow)
     If  getColumIndex(spr,"MaterialAMTSales") > -1 then z0111.MaterialAMTSales = getDataM(spr, getColumIndex(spr,"MaterialAMTSales"), xRow)
     If  getColumIndex(spr,"InsertDate") > -1 then z0111.InsertDate = getDataM(spr, getColumIndex(spr,"InsertDate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z0111.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"UpdateDate") > -1 then z0111.UpdateDate = getDataM(spr, getColumIndex(spr,"UpdateDate"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z0111.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"AttachID") > -1 then z0111.AttachID = getDataM(spr, getColumIndex(spr,"AttachID"), xRow)
     If  getColumIndex(spr,"seSubProcess") > -1 then z0111.seSubProcess = getDataM(spr, getColumIndex(spr,"seSubProcess"), xRow)
     If  getColumIndex(spr,"cdSubProcess") > -1 then z0111.cdSubProcess = getDataM(spr, getColumIndex(spr,"cdSubProcess"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z0111.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K0111_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K0111_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z0111 As T0111_AREA, Job as String, SPECNO AS String, SPECNOSEQ AS String, MATERIALSEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K0111_MOVE = False

Try
    If READ_PFK0111(SPECNO, SPECNOSEQ, MATERIALSEQ) = True Then
                z0111 = D0111
		K0111_MOVE = True
		else
	z0111 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK0111")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "SPECNO":z0111.SpecNo = Children(i).Code
   Case "SPECNOSEQ":z0111.SpecNoSeq = Children(i).Code
   Case "MATERIALSEQ":z0111.MaterialSeq = Children(i).Code
   Case "DSEQ":z0111.DSeq = Children(i).Code
   Case "STATUS":z0111.Status = Children(i).Code
   Case "SEGROUPCOMPONENT":z0111.seGroupComponent = Children(i).Code
   Case "CDGROUPCOMPONENT":z0111.cdGroupComponent = Children(i).Code
   Case "COMPONENTNAME":z0111.ComponentName = Children(i).Code
   Case "MATERIALCODE":z0111.MaterialCode = Children(i).Code
   Case "DESCRIPTION":z0111.Description = Children(i).Code
   Case "COLOR":z0111.Color = Children(i).Code
   Case "COLORCODE":z0111.ColorCode = Children(i).Code
   Case "SPECIFICATION":z0111.Specification = Children(i).Code
   Case "WIDTH":z0111.Width = Children(i).Code
   Case "HEIGHT":z0111.Height = Children(i).Code
   Case "SIZENAME":z0111.SizeName = Children(i).Code
   Case "COLORNAME":z0111.ColorName = Children(i).Code
   Case "SEUNITMATERIAL":z0111.seUnitMaterial = Children(i).Code
   Case "CDUNITMATERIAL":z0111.cdUnitmaterial = Children(i).Code
   Case "SESHOESSTATUS":z0111.seShoesStatus = Children(i).Code
   Case "CDSHOESSTATUS":z0111.cdShoesStatus = Children(i).Code
   Case "SEDEPARTMENT":z0111.seDepartment = Children(i).Code
   Case "CDDEPARTMENT":z0111.cdDepartment = Children(i).Code
   Case "SUPPLIERCODE":z0111.SupplierCode = Children(i).Code
   Case "PRICE":z0111.Price = Children(i).Code
   Case "SEUNITPRICE":z0111.seUnitPrice = Children(i).Code
   Case "CDUNITPRICE":z0111.cdUnitPrice = Children(i).Code
   Case "QTYBATCHS":z0111.QtyBatchS = Children(i).Code
   Case "QTYCOMPONENT":z0111.QtyComponent = Children(i).Code
   Case "CONSUMPTION":z0111.Consumption = Children(i).Code
   Case "LOSS":z0111.Loss = Children(i).Code
   Case "GROSSUSAGE":z0111.GrossUsage = Children(i).Code
   Case "MATERIALAMT":z0111.MaterialAMT = Children(i).Code
   Case "PRICESALES":z0111.PriceSales = Children(i).Code
   Case "MATERIALAMTSALES":z0111.MaterialAMTSales = Children(i).Code
   Case "INSERTDATE":z0111.InsertDate = Children(i).Code
   Case "INCHARGEINSERT":z0111.InchargeInsert = Children(i).Code
   Case "UPDATEDATE":z0111.UpdateDate = Children(i).Code
   Case "INCHARGEUPDATE":z0111.InchargeUpdate = Children(i).Code
   Case "ATTACHID":z0111.AttachID = Children(i).Code
   Case "SESUBPROCESS":z0111.seSubProcess = Children(i).Code
   Case "CDSUBPROCESS":z0111.cdSubProcess = Children(i).Code
   Case "REMARK":z0111.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "SPECNO":z0111.SpecNo = Children(i).Data
   Case "SPECNOSEQ":z0111.SpecNoSeq = Children(i).Data
   Case "MATERIALSEQ":z0111.MaterialSeq = Children(i).Data
   Case "DSEQ":z0111.DSeq = Children(i).Data
   Case "STATUS":z0111.Status = Children(i).Data
   Case "SEGROUPCOMPONENT":z0111.seGroupComponent = Children(i).Data
   Case "CDGROUPCOMPONENT":z0111.cdGroupComponent = Children(i).Data
   Case "COMPONENTNAME":z0111.ComponentName = Children(i).Data
   Case "MATERIALCODE":z0111.MaterialCode = Children(i).Data
   Case "DESCRIPTION":z0111.Description = Children(i).Data
   Case "COLOR":z0111.Color = Children(i).Data
   Case "COLORCODE":z0111.ColorCode = Children(i).Data
   Case "SPECIFICATION":z0111.Specification = Children(i).Data
   Case "WIDTH":z0111.Width = Children(i).Data
   Case "HEIGHT":z0111.Height = Children(i).Data
   Case "SIZENAME":z0111.SizeName = Children(i).Data
   Case "COLORNAME":z0111.ColorName = Children(i).Data
   Case "SEUNITMATERIAL":z0111.seUnitMaterial = Children(i).Data
   Case "CDUNITMATERIAL":z0111.cdUnitmaterial = Children(i).Data
   Case "SESHOESSTATUS":z0111.seShoesStatus = Children(i).Data
   Case "CDSHOESSTATUS":z0111.cdShoesStatus = Children(i).Data
   Case "SEDEPARTMENT":z0111.seDepartment = Children(i).Data
   Case "CDDEPARTMENT":z0111.cdDepartment = Children(i).Data
   Case "SUPPLIERCODE":z0111.SupplierCode = Children(i).Data
   Case "PRICE":z0111.Price = Children(i).Data
   Case "SEUNITPRICE":z0111.seUnitPrice = Children(i).Data
   Case "CDUNITPRICE":z0111.cdUnitPrice = Children(i).Data
   Case "QTYBATCHS":z0111.QtyBatchS = Children(i).Data
   Case "QTYCOMPONENT":z0111.QtyComponent = Children(i).Data
   Case "CONSUMPTION":z0111.Consumption = Children(i).Data
   Case "LOSS":z0111.Loss = Children(i).Data
   Case "GROSSUSAGE":z0111.GrossUsage = Children(i).Data
   Case "MATERIALAMT":z0111.MaterialAMT = Children(i).Data
   Case "PRICESALES":z0111.PriceSales = Children(i).Data
   Case "MATERIALAMTSALES":z0111.MaterialAMTSales = Children(i).Data
   Case "INSERTDATE":z0111.InsertDate = Children(i).Data
   Case "INCHARGEINSERT":z0111.InchargeInsert = Children(i).Data
   Case "UPDATEDATE":z0111.UpdateDate = Children(i).Data
   Case "INCHARGEUPDATE":z0111.InchargeUpdate = Children(i).Data
   Case "ATTACHID":z0111.AttachID = Children(i).Data
   Case "SESUBPROCESS":z0111.seSubProcess = Children(i).Data
   Case "CDSUBPROCESS":z0111.cdSubProcess = Children(i).Data
   Case "REMARK":z0111.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K0111_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K0111_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z0111 As T0111_AREA, Job as String, CheckClear as Boolean, SPECNO AS String, SPECNOSEQ AS String, MATERIALSEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K0111_MOVE = False

Try
    If READ_PFK0111(SPECNO, SPECNOSEQ, MATERIALSEQ) = True Then
                z0111 = D0111
		K0111_MOVE = True
		else
	If CheckClear  = True then z0111 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK0111")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "SPECNO":z0111.SpecNo = Children(i).Code
   Case "SPECNOSEQ":z0111.SpecNoSeq = Children(i).Code
   Case "MATERIALSEQ":z0111.MaterialSeq = Children(i).Code
   Case "DSEQ":z0111.DSeq = Children(i).Code
   Case "STATUS":z0111.Status = Children(i).Code
   Case "SEGROUPCOMPONENT":z0111.seGroupComponent = Children(i).Code
   Case "CDGROUPCOMPONENT":z0111.cdGroupComponent = Children(i).Code
   Case "COMPONENTNAME":z0111.ComponentName = Children(i).Code
   Case "MATERIALCODE":z0111.MaterialCode = Children(i).Code
   Case "DESCRIPTION":z0111.Description = Children(i).Code
   Case "COLOR":z0111.Color = Children(i).Code
   Case "COLORCODE":z0111.ColorCode = Children(i).Code
   Case "SPECIFICATION":z0111.Specification = Children(i).Code
   Case "WIDTH":z0111.Width = Children(i).Code
   Case "HEIGHT":z0111.Height = Children(i).Code
   Case "SIZENAME":z0111.SizeName = Children(i).Code
   Case "COLORNAME":z0111.ColorName = Children(i).Code
   Case "SEUNITMATERIAL":z0111.seUnitMaterial = Children(i).Code
   Case "CDUNITMATERIAL":z0111.cdUnitmaterial = Children(i).Code
   Case "SESHOESSTATUS":z0111.seShoesStatus = Children(i).Code
   Case "CDSHOESSTATUS":z0111.cdShoesStatus = Children(i).Code
   Case "SEDEPARTMENT":z0111.seDepartment = Children(i).Code
   Case "CDDEPARTMENT":z0111.cdDepartment = Children(i).Code
   Case "SUPPLIERCODE":z0111.SupplierCode = Children(i).Code
   Case "PRICE":z0111.Price = Children(i).Code
   Case "SEUNITPRICE":z0111.seUnitPrice = Children(i).Code
   Case "CDUNITPRICE":z0111.cdUnitPrice = Children(i).Code
   Case "QTYBATCHS":z0111.QtyBatchS = Children(i).Code
   Case "QTYCOMPONENT":z0111.QtyComponent = Children(i).Code
   Case "CONSUMPTION":z0111.Consumption = Children(i).Code
   Case "LOSS":z0111.Loss = Children(i).Code
   Case "GROSSUSAGE":z0111.GrossUsage = Children(i).Code
   Case "MATERIALAMT":z0111.MaterialAMT = Children(i).Code
   Case "PRICESALES":z0111.PriceSales = Children(i).Code
   Case "MATERIALAMTSALES":z0111.MaterialAMTSales = Children(i).Code
   Case "INSERTDATE":z0111.InsertDate = Children(i).Code
   Case "INCHARGEINSERT":z0111.InchargeInsert = Children(i).Code
   Case "UPDATEDATE":z0111.UpdateDate = Children(i).Code
   Case "INCHARGEUPDATE":z0111.InchargeUpdate = Children(i).Code
   Case "ATTACHID":z0111.AttachID = Children(i).Code
   Case "SESUBPROCESS":z0111.seSubProcess = Children(i).Code
   Case "CDSUBPROCESS":z0111.cdSubProcess = Children(i).Code
   Case "REMARK":z0111.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "SPECNO":z0111.SpecNo = Children(i).Data
   Case "SPECNOSEQ":z0111.SpecNoSeq = Children(i).Data
   Case "MATERIALSEQ":z0111.MaterialSeq = Children(i).Data
   Case "DSEQ":z0111.DSeq = Children(i).Data
   Case "STATUS":z0111.Status = Children(i).Data
   Case "SEGROUPCOMPONENT":z0111.seGroupComponent = Children(i).Data
   Case "CDGROUPCOMPONENT":z0111.cdGroupComponent = Children(i).Data
   Case "COMPONENTNAME":z0111.ComponentName = Children(i).Data
   Case "MATERIALCODE":z0111.MaterialCode = Children(i).Data
   Case "DESCRIPTION":z0111.Description = Children(i).Data
   Case "COLOR":z0111.Color = Children(i).Data
   Case "COLORCODE":z0111.ColorCode = Children(i).Data
   Case "SPECIFICATION":z0111.Specification = Children(i).Data
   Case "WIDTH":z0111.Width = Children(i).Data
   Case "HEIGHT":z0111.Height = Children(i).Data
   Case "SIZENAME":z0111.SizeName = Children(i).Data
   Case "COLORNAME":z0111.ColorName = Children(i).Data
   Case "SEUNITMATERIAL":z0111.seUnitMaterial = Children(i).Data
   Case "CDUNITMATERIAL":z0111.cdUnitmaterial = Children(i).Data
   Case "SESHOESSTATUS":z0111.seShoesStatus = Children(i).Data
   Case "CDSHOESSTATUS":z0111.cdShoesStatus = Children(i).Data
   Case "SEDEPARTMENT":z0111.seDepartment = Children(i).Data
   Case "CDDEPARTMENT":z0111.cdDepartment = Children(i).Data
   Case "SUPPLIERCODE":z0111.SupplierCode = Children(i).Data
   Case "PRICE":z0111.Price = Children(i).Data
   Case "SEUNITPRICE":z0111.seUnitPrice = Children(i).Data
   Case "CDUNITPRICE":z0111.cdUnitPrice = Children(i).Data
   Case "QTYBATCHS":z0111.QtyBatchS = Children(i).Data
   Case "QTYCOMPONENT":z0111.QtyComponent = Children(i).Data
   Case "CONSUMPTION":z0111.Consumption = Children(i).Data
   Case "LOSS":z0111.Loss = Children(i).Data
   Case "GROSSUSAGE":z0111.GrossUsage = Children(i).Data
   Case "MATERIALAMT":z0111.MaterialAMT = Children(i).Data
   Case "PRICESALES":z0111.PriceSales = Children(i).Data
   Case "MATERIALAMTSALES":z0111.MaterialAMTSales = Children(i).Data
   Case "INSERTDATE":z0111.InsertDate = Children(i).Data
   Case "INCHARGEINSERT":z0111.InchargeInsert = Children(i).Data
   Case "UPDATEDATE":z0111.UpdateDate = Children(i).Data
   Case "INCHARGEUPDATE":z0111.InchargeUpdate = Children(i).Data
   Case "ATTACHID":z0111.AttachID = Children(i).Data
   Case "SESUBPROCESS":z0111.seSubProcess = Children(i).Data
   Case "CDSUBPROCESS":z0111.cdSubProcess = Children(i).Data
   Case "REMARK":z0111.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K0111_MOVE",vbCritical)
End Try
End Function 
    
End Module 
