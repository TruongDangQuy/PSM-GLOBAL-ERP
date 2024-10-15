'=========================================================================================================================================================
'   TABLE : (PFK7337)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7337

Structure T7337_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	ProcessBOMCode	 AS String	'			nvarchar(6)		*
Public 	ProcessBOMSeq	 AS Double	'			decimal		*
Public 	ProcessBOMSno	 AS Double	'			decimal		*
Public 	Dseq	 AS Double	'			decimal
Public 	ComponentName	 AS String	'			nvarchar(50)
Public 	MaterialCode	 AS String	'			char(6)
Public 	seMaterialUnit	 AS String	'			char(3)
Public 	cdMaterialUnit	 AS String	'			char(3)
Public 	Specification	 AS String	'			nvarchar(20)
Public 	Width	 AS String	'			nvarchar(20)
Public 	Height	 AS String	'			nvarchar(20)
Public 	SizeName	 AS String	'			nvarchar(20)
Public 	ColorName	 AS String	'			nvarchar(30)
Public 	seShoesStatus	 AS String	'			char(3)
Public 	cdShoesStatus	 AS String	'			char(3)
Public 	seDepartment	 AS String	'			char(3)
Public 	cdDepartment	 AS String	'			char(3)
Public 	SupplierCode	 AS String	'			char(6)
Public 	QtyComponent	 AS Double	'			decimal
Public 	Consumption	 AS Double	'			decimal
Public 	Price	 AS Double	'			decimal
Public 	UnitPrice	 AS String	'			char(3)
Public 	Loss	 AS Double	'			decimal
Public 	Usage	 AS String	'			char(1)
Public 	Remark	 AS String	'			nvarchar(200)
'=========================================================================================================================================================
End structure

Public D7337 As T7337_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK7337(PROCESSBOMCODE AS String, PROCESSBOMSEQ AS Double, PROCESSBOMSNO AS Double) As Boolean
    READ_PFK7337 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7337 "
    SQL = SQL & " WHERE K7337_ProcessBOMCode		 = '" & ProcessBOMCode & "' " 
    SQL = SQL & "   AND K7337_ProcessBOMSeq		 =  " & ProcessBOMSeq & "  " 
    SQL = SQL & "   AND K7337_ProcessBOMSno		 =  " & ProcessBOMSno & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D7337_CLEAR: GoTo SKIP_READ_PFK7337
                
    Call K7337_MOVE(rd)
    READ_PFK7337 = True

SKIP_READ_PFK7337:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK7337",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK7337(PROCESSBOMCODE AS String, PROCESSBOMSEQ AS Double, PROCESSBOMSNO AS Double, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7337 "
    SQL = SQL & " WHERE K7337_ProcessBOMCode		 = '" & ProcessBOMCode & "' " 
    SQL = SQL & "   AND K7337_ProcessBOMSeq		 =  " & ProcessBOMSeq & "  " 
    SQL = SQL & "   AND K7337_ProcessBOMSno		 =  " & ProcessBOMSno & "  " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK7337",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK7337(z7337 As T7337_AREA) As Boolean
    WRITE_PFK7337 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z7337)
 
    SQL = " INSERT INTO PFK7337 "
    SQL = SQL & " ( "
    SQL = SQL & " K7337_ProcessBOMCode," 
    SQL = SQL & " K7337_ProcessBOMSeq," 
    SQL = SQL & " K7337_ProcessBOMSno," 
    SQL = SQL & " K7337_Dseq," 
    SQL = SQL & " K7337_ComponentName," 
    SQL = SQL & " K7337_MaterialCode," 
    SQL = SQL & " K7337_seMaterialUnit," 
    SQL = SQL & " K7337_cdMaterialUnit," 
    SQL = SQL & " K7337_Specification," 
    SQL = SQL & " K7337_Width," 
    SQL = SQL & " K7337_Height," 
    SQL = SQL & " K7337_SizeName," 
    SQL = SQL & " K7337_ColorName," 
    SQL = SQL & " K7337_seShoesStatus," 
    SQL = SQL & " K7337_cdShoesStatus," 
    SQL = SQL & " K7337_seDepartment," 
    SQL = SQL & " K7337_cdDepartment," 
    SQL = SQL & " K7337_SupplierCode," 
    SQL = SQL & " K7337_QtyComponent," 
    SQL = SQL & " K7337_Consumption," 
    SQL = SQL & " K7337_Price," 
    SQL = SQL & " K7337_UnitPrice," 
    SQL = SQL & " K7337_Loss," 
    SQL = SQL & " K7337_Usage," 
    SQL = SQL & " K7337_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z7337.ProcessBOMCode) & "', "  
    SQL = SQL & "   " & FormatSQL(z7337.ProcessBOMSeq) & ", "  
    SQL = SQL & "   " & FormatSQL(z7337.ProcessBOMSno) & ", "  
    SQL = SQL & "   " & FormatSQL(z7337.Dseq) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z7337.ComponentName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7337.MaterialCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7337.seMaterialUnit) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7337.cdMaterialUnit) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7337.Specification) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7337.Width) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7337.Height) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7337.SizeName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7337.ColorName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7337.seShoesStatus) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7337.cdShoesStatus) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7337.seDepartment) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7337.cdDepartment) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7337.SupplierCode) & "', "  
    SQL = SQL & "   " & FormatSQL(z7337.QtyComponent) & ", "  
    SQL = SQL & "   " & FormatSQL(z7337.Consumption) & ", "  
    SQL = SQL & "   " & FormatSQL(z7337.Price) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z7337.UnitPrice) & "', "  
    SQL = SQL & "   " & FormatSQL(z7337.Loss) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z7337.Usage) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7337.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK7337 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK7337",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK7337(z7337 As T7337_AREA) As Boolean
    REWRITE_PFK7337 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7337)
   
    SQL = " UPDATE PFK7337 SET "
    SQL = SQL & "    K7337_Dseq      =  " & FormatSQL(z7337.Dseq) & ", " 
    SQL = SQL & "    K7337_ComponentName      = N'" & FormatSQL(z7337.ComponentName) & "', " 
    SQL = SQL & "    K7337_MaterialCode      = N'" & FormatSQL(z7337.MaterialCode) & "', " 
    SQL = SQL & "    K7337_seMaterialUnit      = N'" & FormatSQL(z7337.seMaterialUnit) & "', " 
    SQL = SQL & "    K7337_cdMaterialUnit      = N'" & FormatSQL(z7337.cdMaterialUnit) & "', " 
    SQL = SQL & "    K7337_Specification      = N'" & FormatSQL(z7337.Specification) & "', " 
    SQL = SQL & "    K7337_Width      = N'" & FormatSQL(z7337.Width) & "', " 
    SQL = SQL & "    K7337_Height      = N'" & FormatSQL(z7337.Height) & "', " 
    SQL = SQL & "    K7337_SizeName      = N'" & FormatSQL(z7337.SizeName) & "', " 
    SQL = SQL & "    K7337_ColorName      = N'" & FormatSQL(z7337.ColorName) & "', " 
    SQL = SQL & "    K7337_seShoesStatus      = N'" & FormatSQL(z7337.seShoesStatus) & "', " 
    SQL = SQL & "    K7337_cdShoesStatus      = N'" & FormatSQL(z7337.cdShoesStatus) & "', " 
    SQL = SQL & "    K7337_seDepartment      = N'" & FormatSQL(z7337.seDepartment) & "', " 
    SQL = SQL & "    K7337_cdDepartment      = N'" & FormatSQL(z7337.cdDepartment) & "', " 
    SQL = SQL & "    K7337_SupplierCode      = N'" & FormatSQL(z7337.SupplierCode) & "', " 
    SQL = SQL & "    K7337_QtyComponent      =  " & FormatSQL(z7337.QtyComponent) & ", " 
    SQL = SQL & "    K7337_Consumption      =  " & FormatSQL(z7337.Consumption) & ", " 
    SQL = SQL & "    K7337_Price      =  " & FormatSQL(z7337.Price) & ", " 
    SQL = SQL & "    K7337_UnitPrice      = N'" & FormatSQL(z7337.UnitPrice) & "', " 
    SQL = SQL & "    K7337_Loss      =  " & FormatSQL(z7337.Loss) & ", " 
    SQL = SQL & "    K7337_Usage      = N'" & FormatSQL(z7337.Usage) & "', " 
    SQL = SQL & "    K7337_Remark      = N'" & FormatSQL(z7337.Remark) & "'  " 
    SQL = SQL & " WHERE K7337_ProcessBOMCode		 = '" & z7337.ProcessBOMCode & "' " 
    SQL = SQL & "   AND K7337_ProcessBOMSeq		 =  " & z7337.ProcessBOMSeq & "  " 
    SQL = SQL & "   AND K7337_ProcessBOMSno		 =  " & z7337.ProcessBOMSno & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK7337 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK7337",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK7337(z7337 As T7337_AREA) As Boolean
    DELETE_PFK7337 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK7337 "
    SQL = SQL & " WHERE K7337_ProcessBOMCode		 = '" & z7337.ProcessBOMCode & "' " 
    SQL = SQL & "   AND K7337_ProcessBOMSeq		 =  " & z7337.ProcessBOMSeq & "  " 
    SQL = SQL & "   AND K7337_ProcessBOMSno		 =  " & z7337.ProcessBOMSno & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK7337 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK7337",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D7337_CLEAR()
Try
    
   D7337.ProcessBOMCode = ""
    D7337.ProcessBOMSeq = 0 
    D7337.ProcessBOMSno = 0 
    D7337.Dseq = 0 
   D7337.ComponentName = ""
   D7337.MaterialCode = ""
   D7337.seMaterialUnit = ""
   D7337.cdMaterialUnit = ""
   D7337.Specification = ""
   D7337.Width = ""
   D7337.Height = ""
   D7337.SizeName = ""
   D7337.ColorName = ""
   D7337.seShoesStatus = ""
   D7337.cdShoesStatus = ""
   D7337.seDepartment = ""
   D7337.cdDepartment = ""
   D7337.SupplierCode = ""
    D7337.QtyComponent = 0 
    D7337.Consumption = 0 
    D7337.Price = 0 
   D7337.UnitPrice = ""
    D7337.Loss = 0 
   D7337.Usage = ""
   D7337.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D7337_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x7337 As T7337_AREA)
Try
    
    x7337.ProcessBOMCode = trim$(  x7337.ProcessBOMCode)
    x7337.ProcessBOMSeq = trim$(  x7337.ProcessBOMSeq)
    x7337.ProcessBOMSno = trim$(  x7337.ProcessBOMSno)
    x7337.Dseq = trim$(  x7337.Dseq)
    x7337.ComponentName = trim$(  x7337.ComponentName)
    x7337.MaterialCode = trim$(  x7337.MaterialCode)
    x7337.seMaterialUnit = trim$(  x7337.seMaterialUnit)
    x7337.cdMaterialUnit = trim$(  x7337.cdMaterialUnit)
    x7337.Specification = trim$(  x7337.Specification)
    x7337.Width = trim$(  x7337.Width)
    x7337.Height = trim$(  x7337.Height)
    x7337.SizeName = trim$(  x7337.SizeName)
    x7337.ColorName = trim$(  x7337.ColorName)
    x7337.seShoesStatus = trim$(  x7337.seShoesStatus)
    x7337.cdShoesStatus = trim$(  x7337.cdShoesStatus)
    x7337.seDepartment = trim$(  x7337.seDepartment)
    x7337.cdDepartment = trim$(  x7337.cdDepartment)
    x7337.SupplierCode = trim$(  x7337.SupplierCode)
    x7337.QtyComponent = trim$(  x7337.QtyComponent)
    x7337.Consumption = trim$(  x7337.Consumption)
    x7337.Price = trim$(  x7337.Price)
    x7337.UnitPrice = trim$(  x7337.UnitPrice)
    x7337.Loss = trim$(  x7337.Loss)
    x7337.Usage = trim$(  x7337.Usage)
    x7337.Remark = trim$(  x7337.Remark)
     
    If trim$( x7337.ProcessBOMCode ) = "" Then x7337.ProcessBOMCode = Space(1) 
    If trim$( x7337.ProcessBOMSeq ) = "" Then x7337.ProcessBOMSeq = 0 
    If trim$( x7337.ProcessBOMSno ) = "" Then x7337.ProcessBOMSno = 0 
    If trim$( x7337.Dseq ) = "" Then x7337.Dseq = 0 
    If trim$( x7337.ComponentName ) = "" Then x7337.ComponentName = Space(1) 
    If trim$( x7337.MaterialCode ) = "" Then x7337.MaterialCode = Space(1) 
    If trim$( x7337.seMaterialUnit ) = "" Then x7337.seMaterialUnit = Space(1) 
    If trim$( x7337.cdMaterialUnit ) = "" Then x7337.cdMaterialUnit = Space(1) 
    If trim$( x7337.Specification ) = "" Then x7337.Specification = Space(1) 
    If trim$( x7337.Width ) = "" Then x7337.Width = Space(1) 
    If trim$( x7337.Height ) = "" Then x7337.Height = Space(1) 
    If trim$( x7337.SizeName ) = "" Then x7337.SizeName = Space(1) 
    If trim$( x7337.ColorName ) = "" Then x7337.ColorName = Space(1) 
    If trim$( x7337.seShoesStatus ) = "" Then x7337.seShoesStatus = Space(1) 
    If trim$( x7337.cdShoesStatus ) = "" Then x7337.cdShoesStatus = Space(1) 
    If trim$( x7337.seDepartment ) = "" Then x7337.seDepartment = Space(1) 
    If trim$( x7337.cdDepartment ) = "" Then x7337.cdDepartment = Space(1) 
    If trim$( x7337.SupplierCode ) = "" Then x7337.SupplierCode = Space(1) 
    If trim$( x7337.QtyComponent ) = "" Then x7337.QtyComponent = 0 
    If trim$( x7337.Consumption ) = "" Then x7337.Consumption = 0 
    If trim$( x7337.Price ) = "" Then x7337.Price = 0 
    If trim$( x7337.UnitPrice ) = "" Then x7337.UnitPrice = Space(1) 
    If trim$( x7337.Loss ) = "" Then x7337.Loss = 0 
    If trim$( x7337.Usage ) = "" Then x7337.Usage = Space(1) 
    If trim$( x7337.Remark ) = "" Then x7337.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K7337_MOVE(rs7337 As SqlClient.SqlDataReader)
Try

    call D7337_CLEAR()   

    If IsdbNull(rs7337!K7337_ProcessBOMCode) = False Then D7337.ProcessBOMCode = Trim$(rs7337!K7337_ProcessBOMCode)
    If IsdbNull(rs7337!K7337_ProcessBOMSeq) = False Then D7337.ProcessBOMSeq = Trim$(rs7337!K7337_ProcessBOMSeq)
    If IsdbNull(rs7337!K7337_ProcessBOMSno) = False Then D7337.ProcessBOMSno = Trim$(rs7337!K7337_ProcessBOMSno)
    If IsdbNull(rs7337!K7337_Dseq) = False Then D7337.Dseq = Trim$(rs7337!K7337_Dseq)
    If IsdbNull(rs7337!K7337_ComponentName) = False Then D7337.ComponentName = Trim$(rs7337!K7337_ComponentName)
    If IsdbNull(rs7337!K7337_MaterialCode) = False Then D7337.MaterialCode = Trim$(rs7337!K7337_MaterialCode)
    If IsdbNull(rs7337!K7337_seMaterialUnit) = False Then D7337.seMaterialUnit = Trim$(rs7337!K7337_seMaterialUnit)
    If IsdbNull(rs7337!K7337_cdMaterialUnit) = False Then D7337.cdMaterialUnit = Trim$(rs7337!K7337_cdMaterialUnit)
    If IsdbNull(rs7337!K7337_Specification) = False Then D7337.Specification = Trim$(rs7337!K7337_Specification)
    If IsdbNull(rs7337!K7337_Width) = False Then D7337.Width = Trim$(rs7337!K7337_Width)
    If IsdbNull(rs7337!K7337_Height) = False Then D7337.Height = Trim$(rs7337!K7337_Height)
    If IsdbNull(rs7337!K7337_SizeName) = False Then D7337.SizeName = Trim$(rs7337!K7337_SizeName)
    If IsdbNull(rs7337!K7337_ColorName) = False Then D7337.ColorName = Trim$(rs7337!K7337_ColorName)
    If IsdbNull(rs7337!K7337_seShoesStatus) = False Then D7337.seShoesStatus = Trim$(rs7337!K7337_seShoesStatus)
    If IsdbNull(rs7337!K7337_cdShoesStatus) = False Then D7337.cdShoesStatus = Trim$(rs7337!K7337_cdShoesStatus)
    If IsdbNull(rs7337!K7337_seDepartment) = False Then D7337.seDepartment = Trim$(rs7337!K7337_seDepartment)
    If IsdbNull(rs7337!K7337_cdDepartment) = False Then D7337.cdDepartment = Trim$(rs7337!K7337_cdDepartment)
    If IsdbNull(rs7337!K7337_SupplierCode) = False Then D7337.SupplierCode = Trim$(rs7337!K7337_SupplierCode)
    If IsdbNull(rs7337!K7337_QtyComponent) = False Then D7337.QtyComponent = Trim$(rs7337!K7337_QtyComponent)
    If IsdbNull(rs7337!K7337_Consumption) = False Then D7337.Consumption = Trim$(rs7337!K7337_Consumption)
    If IsdbNull(rs7337!K7337_Price) = False Then D7337.Price = Trim$(rs7337!K7337_Price)
    If IsdbNull(rs7337!K7337_UnitPrice) = False Then D7337.UnitPrice = Trim$(rs7337!K7337_UnitPrice)
    If IsdbNull(rs7337!K7337_Loss) = False Then D7337.Loss = Trim$(rs7337!K7337_Loss)
    If IsdbNull(rs7337!K7337_Usage) = False Then D7337.Usage = Trim$(rs7337!K7337_Usage)
    If IsdbNull(rs7337!K7337_Remark) = False Then D7337.Remark = Trim$(rs7337!K7337_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7337_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K7337_MOVE(rs7337 As DataRow)
Try

    call D7337_CLEAR()   

    If IsdbNull(rs7337!K7337_ProcessBOMCode) = False Then D7337.ProcessBOMCode = Trim$(rs7337!K7337_ProcessBOMCode)
    If IsdbNull(rs7337!K7337_ProcessBOMSeq) = False Then D7337.ProcessBOMSeq = Trim$(rs7337!K7337_ProcessBOMSeq)
    If IsdbNull(rs7337!K7337_ProcessBOMSno) = False Then D7337.ProcessBOMSno = Trim$(rs7337!K7337_ProcessBOMSno)
    If IsdbNull(rs7337!K7337_Dseq) = False Then D7337.Dseq = Trim$(rs7337!K7337_Dseq)
    If IsdbNull(rs7337!K7337_ComponentName) = False Then D7337.ComponentName = Trim$(rs7337!K7337_ComponentName)
    If IsdbNull(rs7337!K7337_MaterialCode) = False Then D7337.MaterialCode = Trim$(rs7337!K7337_MaterialCode)
    If IsdbNull(rs7337!K7337_seMaterialUnit) = False Then D7337.seMaterialUnit = Trim$(rs7337!K7337_seMaterialUnit)
    If IsdbNull(rs7337!K7337_cdMaterialUnit) = False Then D7337.cdMaterialUnit = Trim$(rs7337!K7337_cdMaterialUnit)
    If IsdbNull(rs7337!K7337_Specification) = False Then D7337.Specification = Trim$(rs7337!K7337_Specification)
    If IsdbNull(rs7337!K7337_Width) = False Then D7337.Width = Trim$(rs7337!K7337_Width)
    If IsdbNull(rs7337!K7337_Height) = False Then D7337.Height = Trim$(rs7337!K7337_Height)
    If IsdbNull(rs7337!K7337_SizeName) = False Then D7337.SizeName = Trim$(rs7337!K7337_SizeName)
    If IsdbNull(rs7337!K7337_ColorName) = False Then D7337.ColorName = Trim$(rs7337!K7337_ColorName)
    If IsdbNull(rs7337!K7337_seShoesStatus) = False Then D7337.seShoesStatus = Trim$(rs7337!K7337_seShoesStatus)
    If IsdbNull(rs7337!K7337_cdShoesStatus) = False Then D7337.cdShoesStatus = Trim$(rs7337!K7337_cdShoesStatus)
    If IsdbNull(rs7337!K7337_seDepartment) = False Then D7337.seDepartment = Trim$(rs7337!K7337_seDepartment)
    If IsdbNull(rs7337!K7337_cdDepartment) = False Then D7337.cdDepartment = Trim$(rs7337!K7337_cdDepartment)
    If IsdbNull(rs7337!K7337_SupplierCode) = False Then D7337.SupplierCode = Trim$(rs7337!K7337_SupplierCode)
    If IsdbNull(rs7337!K7337_QtyComponent) = False Then D7337.QtyComponent = Trim$(rs7337!K7337_QtyComponent)
    If IsdbNull(rs7337!K7337_Consumption) = False Then D7337.Consumption = Trim$(rs7337!K7337_Consumption)
    If IsdbNull(rs7337!K7337_Price) = False Then D7337.Price = Trim$(rs7337!K7337_Price)
    If IsdbNull(rs7337!K7337_UnitPrice) = False Then D7337.UnitPrice = Trim$(rs7337!K7337_UnitPrice)
    If IsdbNull(rs7337!K7337_Loss) = False Then D7337.Loss = Trim$(rs7337!K7337_Loss)
    If IsdbNull(rs7337!K7337_Usage) = False Then D7337.Usage = Trim$(rs7337!K7337_Usage)
    If IsdbNull(rs7337!K7337_Remark) = False Then D7337.Remark = Trim$(rs7337!K7337_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7337_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K7337_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7337 As T7337_AREA, PROCESSBOMCODE AS String, PROCESSBOMSEQ AS Double, PROCESSBOMSNO AS Double) as Boolean

K7337_MOVE = False

Try
    If READ_PFK7337(PROCESSBOMCODE, PROCESSBOMSEQ, PROCESSBOMSNO) = True Then
                z7337 = D7337
		K7337_MOVE = True
		else
	z7337 = nothing
     End If

     If  getColumIndex(spr,"ProcessBOMCode") > -1 then z7337.ProcessBOMCode = getDataM(spr, getColumIndex(spr,"ProcessBOMCode"), xRow)
     If  getColumIndex(spr,"ProcessBOMSeq") > -1 then z7337.ProcessBOMSeq = getDataM(spr, getColumIndex(spr,"ProcessBOMSeq"), xRow)
     If  getColumIndex(spr,"ProcessBOMSno") > -1 then z7337.ProcessBOMSno = getDataM(spr, getColumIndex(spr,"ProcessBOMSno"), xRow)
     If  getColumIndex(spr,"Dseq") > -1 then z7337.Dseq = getDataM(spr, getColumIndex(spr,"Dseq"), xRow)
     If  getColumIndex(spr,"ComponentName") > -1 then z7337.ComponentName = getDataM(spr, getColumIndex(spr,"ComponentName"), xRow)
     If  getColumIndex(spr,"MaterialCode") > -1 then z7337.MaterialCode = getDataM(spr, getColumIndex(spr,"MaterialCode"), xRow)
     If  getColumIndex(spr,"seMaterialUnit") > -1 then z7337.seMaterialUnit = getDataM(spr, getColumIndex(spr,"seMaterialUnit"), xRow)
     If  getColumIndex(spr,"cdMaterialUnit") > -1 then z7337.cdMaterialUnit = getDataM(spr, getColumIndex(spr,"cdMaterialUnit"), xRow)
     If  getColumIndex(spr,"Specification") > -1 then z7337.Specification = getDataM(spr, getColumIndex(spr,"Specification"), xRow)
     If  getColumIndex(spr,"Width") > -1 then z7337.Width = getDataM(spr, getColumIndex(spr,"Width"), xRow)
     If  getColumIndex(spr,"Height") > -1 then z7337.Height = getDataM(spr, getColumIndex(spr,"Height"), xRow)
     If  getColumIndex(spr,"SizeName") > -1 then z7337.SizeName = getDataM(spr, getColumIndex(spr,"SizeName"), xRow)
     If  getColumIndex(spr,"ColorName") > -1 then z7337.ColorName = getDataM(spr, getColumIndex(spr,"ColorName"), xRow)
     If  getColumIndex(spr,"seShoesStatus") > -1 then z7337.seShoesStatus = getDataM(spr, getColumIndex(spr,"seShoesStatus"), xRow)
     If  getColumIndex(spr,"cdShoesStatus") > -1 then z7337.cdShoesStatus = getDataM(spr, getColumIndex(spr,"cdShoesStatus"), xRow)
     If  getColumIndex(spr,"seDepartment") > -1 then z7337.seDepartment = getDataM(spr, getColumIndex(spr,"seDepartment"), xRow)
     If  getColumIndex(spr,"cdDepartment") > -1 then z7337.cdDepartment = getDataM(spr, getColumIndex(spr,"cdDepartment"), xRow)
     If  getColumIndex(spr,"SupplierCode") > -1 then z7337.SupplierCode = getDataM(spr, getColumIndex(spr,"SupplierCode"), xRow)
     If  getColumIndex(spr,"QtyComponent") > -1 then z7337.QtyComponent = getDataM(spr, getColumIndex(spr,"QtyComponent"), xRow)
     If  getColumIndex(spr,"Consumption") > -1 then z7337.Consumption = getDataM(spr, getColumIndex(spr,"Consumption"), xRow)
     If  getColumIndex(spr,"Price") > -1 then z7337.Price = getDataM(spr, getColumIndex(spr,"Price"), xRow)
     If  getColumIndex(spr,"UnitPrice") > -1 then z7337.UnitPrice = getDataM(spr, getColumIndex(spr,"UnitPrice"), xRow)
     If  getColumIndex(spr,"Loss") > -1 then z7337.Loss = getDataM(spr, getColumIndex(spr,"Loss"), xRow)
     If  getColumIndex(spr,"Usage") > -1 then z7337.Usage = getDataM(spr, getColumIndex(spr,"Usage"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7337.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7337_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K7337_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7337 As T7337_AREA,CheckClear as Boolean,PROCESSBOMCODE AS String, PROCESSBOMSEQ AS Double, PROCESSBOMSNO AS Double) as Boolean

K7337_MOVE = False

Try
    If READ_PFK7337(PROCESSBOMCODE, PROCESSBOMSEQ, PROCESSBOMSNO) = True Then
                z7337 = D7337
		K7337_MOVE = True
		else
	If CheckClear  = True then z7337 = nothing
     End If

     If  getColumIndex(spr,"ProcessBOMCode") > -1 then z7337.ProcessBOMCode = getDataM(spr, getColumIndex(spr,"ProcessBOMCode"), xRow)
     If  getColumIndex(spr,"ProcessBOMSeq") > -1 then z7337.ProcessBOMSeq = getDataM(spr, getColumIndex(spr,"ProcessBOMSeq"), xRow)
     If  getColumIndex(spr,"ProcessBOMSno") > -1 then z7337.ProcessBOMSno = getDataM(spr, getColumIndex(spr,"ProcessBOMSno"), xRow)
     If  getColumIndex(spr,"Dseq") > -1 then z7337.Dseq = getDataM(spr, getColumIndex(spr,"Dseq"), xRow)
     If  getColumIndex(spr,"ComponentName") > -1 then z7337.ComponentName = getDataM(spr, getColumIndex(spr,"ComponentName"), xRow)
     If  getColumIndex(spr,"MaterialCode") > -1 then z7337.MaterialCode = getDataM(spr, getColumIndex(spr,"MaterialCode"), xRow)
     If  getColumIndex(spr,"seMaterialUnit") > -1 then z7337.seMaterialUnit = getDataM(spr, getColumIndex(spr,"seMaterialUnit"), xRow)
     If  getColumIndex(spr,"cdMaterialUnit") > -1 then z7337.cdMaterialUnit = getDataM(spr, getColumIndex(spr,"cdMaterialUnit"), xRow)
     If  getColumIndex(spr,"Specification") > -1 then z7337.Specification = getDataM(spr, getColumIndex(spr,"Specification"), xRow)
     If  getColumIndex(spr,"Width") > -1 then z7337.Width = getDataM(spr, getColumIndex(spr,"Width"), xRow)
     If  getColumIndex(spr,"Height") > -1 then z7337.Height = getDataM(spr, getColumIndex(spr,"Height"), xRow)
     If  getColumIndex(spr,"SizeName") > -1 then z7337.SizeName = getDataM(spr, getColumIndex(spr,"SizeName"), xRow)
     If  getColumIndex(spr,"ColorName") > -1 then z7337.ColorName = getDataM(spr, getColumIndex(spr,"ColorName"), xRow)
     If  getColumIndex(spr,"seShoesStatus") > -1 then z7337.seShoesStatus = getDataM(spr, getColumIndex(spr,"seShoesStatus"), xRow)
     If  getColumIndex(spr,"cdShoesStatus") > -1 then z7337.cdShoesStatus = getDataM(spr, getColumIndex(spr,"cdShoesStatus"), xRow)
     If  getColumIndex(spr,"seDepartment") > -1 then z7337.seDepartment = getDataM(spr, getColumIndex(spr,"seDepartment"), xRow)
     If  getColumIndex(spr,"cdDepartment") > -1 then z7337.cdDepartment = getDataM(spr, getColumIndex(spr,"cdDepartment"), xRow)
     If  getColumIndex(spr,"SupplierCode") > -1 then z7337.SupplierCode = getDataM(spr, getColumIndex(spr,"SupplierCode"), xRow)
     If  getColumIndex(spr,"QtyComponent") > -1 then z7337.QtyComponent = getDataM(spr, getColumIndex(spr,"QtyComponent"), xRow)
     If  getColumIndex(spr,"Consumption") > -1 then z7337.Consumption = getDataM(spr, getColumIndex(spr,"Consumption"), xRow)
     If  getColumIndex(spr,"Price") > -1 then z7337.Price = getDataM(spr, getColumIndex(spr,"Price"), xRow)
     If  getColumIndex(spr,"UnitPrice") > -1 then z7337.UnitPrice = getDataM(spr, getColumIndex(spr,"UnitPrice"), xRow)
     If  getColumIndex(spr,"Loss") > -1 then z7337.Loss = getDataM(spr, getColumIndex(spr,"Loss"), xRow)
     If  getColumIndex(spr,"Usage") > -1 then z7337.Usage = getDataM(spr, getColumIndex(spr,"Usage"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7337.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7337_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K7337_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7337 As T7337_AREA, Job as String, PROCESSBOMCODE AS String, PROCESSBOMSEQ AS Double, PROCESSBOMSNO AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7337_MOVE = False

Try
    If READ_PFK7337(PROCESSBOMCODE, PROCESSBOMSEQ, PROCESSBOMSNO) = True Then
                z7337 = D7337
		K7337_MOVE = True
		else
	z7337 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7337")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "PROCESSBOMCODE":z7337.ProcessBOMCode = Children(i).Code
   Case "PROCESSBOMSEQ":z7337.ProcessBOMSeq = Children(i).Code
   Case "PROCESSBOMSNO":z7337.ProcessBOMSno = Children(i).Code
   Case "DSEQ":z7337.Dseq = Children(i).Code
   Case "COMPONENTNAME":z7337.ComponentName = Children(i).Code
   Case "MATERIALCODE":z7337.MaterialCode = Children(i).Code
   Case "SEMATERIALUNIT":z7337.seMaterialUnit = Children(i).Code
   Case "CDMATERIALUNIT":z7337.cdMaterialUnit = Children(i).Code
   Case "SPECIFICATION":z7337.Specification = Children(i).Code
   Case "WIDTH":z7337.Width = Children(i).Code
   Case "HEIGHT":z7337.Height = Children(i).Code
   Case "SIZENAME":z7337.SizeName = Children(i).Code
   Case "COLORNAME":z7337.ColorName = Children(i).Code
   Case "SESHOESSTATUS":z7337.seShoesStatus = Children(i).Code
   Case "CDSHOESSTATUS":z7337.cdShoesStatus = Children(i).Code
   Case "SEDEPARTMENT":z7337.seDepartment = Children(i).Code
   Case "CDDEPARTMENT":z7337.cdDepartment = Children(i).Code
   Case "SUPPLIERCODE":z7337.SupplierCode = Children(i).Code
   Case "QTYCOMPONENT":z7337.QtyComponent = Children(i).Code
   Case "CONSUMPTION":z7337.Consumption = Children(i).Code
   Case "PRICE":z7337.Price = Children(i).Code
   Case "UNITPRICE":z7337.UnitPrice = Children(i).Code
   Case "LOSS":z7337.Loss = Children(i).Code
   Case "USAGE":z7337.Usage = Children(i).Code
   Case "REMARK":z7337.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "PROCESSBOMCODE":z7337.ProcessBOMCode = Children(i).Data
   Case "PROCESSBOMSEQ":z7337.ProcessBOMSeq = Children(i).Data
   Case "PROCESSBOMSNO":z7337.ProcessBOMSno = Children(i).Data
   Case "DSEQ":z7337.Dseq = Children(i).Data
   Case "COMPONENTNAME":z7337.ComponentName = Children(i).Data
   Case "MATERIALCODE":z7337.MaterialCode = Children(i).Data
   Case "SEMATERIALUNIT":z7337.seMaterialUnit = Children(i).Data
   Case "CDMATERIALUNIT":z7337.cdMaterialUnit = Children(i).Data
   Case "SPECIFICATION":z7337.Specification = Children(i).Data
   Case "WIDTH":z7337.Width = Children(i).Data
   Case "HEIGHT":z7337.Height = Children(i).Data
   Case "SIZENAME":z7337.SizeName = Children(i).Data
   Case "COLORNAME":z7337.ColorName = Children(i).Data
   Case "SESHOESSTATUS":z7337.seShoesStatus = Children(i).Data
   Case "CDSHOESSTATUS":z7337.cdShoesStatus = Children(i).Data
   Case "SEDEPARTMENT":z7337.seDepartment = Children(i).Data
   Case "CDDEPARTMENT":z7337.cdDepartment = Children(i).Data
   Case "SUPPLIERCODE":z7337.SupplierCode = Children(i).Data
   Case "QTYCOMPONENT":z7337.QtyComponent = Children(i).Data
   Case "CONSUMPTION":z7337.Consumption = Children(i).Data
   Case "PRICE":z7337.Price = Children(i).Data
   Case "UNITPRICE":z7337.UnitPrice = Children(i).Data
   Case "LOSS":z7337.Loss = Children(i).Data
   Case "USAGE":z7337.Usage = Children(i).Data
   Case "REMARK":z7337.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7337_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K7337_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7337 As T7337_AREA, Job as String, CheckClear as Boolean, PROCESSBOMCODE AS String, PROCESSBOMSEQ AS Double, PROCESSBOMSNO AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7337_MOVE = False

Try
    If READ_PFK7337(PROCESSBOMCODE, PROCESSBOMSEQ, PROCESSBOMSNO) = True Then
                z7337 = D7337
		K7337_MOVE = True
		else
	If CheckClear  = True then z7337 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7337")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "PROCESSBOMCODE":z7337.ProcessBOMCode = Children(i).Code
   Case "PROCESSBOMSEQ":z7337.ProcessBOMSeq = Children(i).Code
   Case "PROCESSBOMSNO":z7337.ProcessBOMSno = Children(i).Code
   Case "DSEQ":z7337.Dseq = Children(i).Code
   Case "COMPONENTNAME":z7337.ComponentName = Children(i).Code
   Case "MATERIALCODE":z7337.MaterialCode = Children(i).Code
   Case "SEMATERIALUNIT":z7337.seMaterialUnit = Children(i).Code
   Case "CDMATERIALUNIT":z7337.cdMaterialUnit = Children(i).Code
   Case "SPECIFICATION":z7337.Specification = Children(i).Code
   Case "WIDTH":z7337.Width = Children(i).Code
   Case "HEIGHT":z7337.Height = Children(i).Code
   Case "SIZENAME":z7337.SizeName = Children(i).Code
   Case "COLORNAME":z7337.ColorName = Children(i).Code
   Case "SESHOESSTATUS":z7337.seShoesStatus = Children(i).Code
   Case "CDSHOESSTATUS":z7337.cdShoesStatus = Children(i).Code
   Case "SEDEPARTMENT":z7337.seDepartment = Children(i).Code
   Case "CDDEPARTMENT":z7337.cdDepartment = Children(i).Code
   Case "SUPPLIERCODE":z7337.SupplierCode = Children(i).Code
   Case "QTYCOMPONENT":z7337.QtyComponent = Children(i).Code
   Case "CONSUMPTION":z7337.Consumption = Children(i).Code
   Case "PRICE":z7337.Price = Children(i).Code
   Case "UNITPRICE":z7337.UnitPrice = Children(i).Code
   Case "LOSS":z7337.Loss = Children(i).Code
   Case "USAGE":z7337.Usage = Children(i).Code
   Case "REMARK":z7337.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "PROCESSBOMCODE":z7337.ProcessBOMCode = Children(i).Data
   Case "PROCESSBOMSEQ":z7337.ProcessBOMSeq = Children(i).Data
   Case "PROCESSBOMSNO":z7337.ProcessBOMSno = Children(i).Data
   Case "DSEQ":z7337.Dseq = Children(i).Data
   Case "COMPONENTNAME":z7337.ComponentName = Children(i).Data
   Case "MATERIALCODE":z7337.MaterialCode = Children(i).Data
   Case "SEMATERIALUNIT":z7337.seMaterialUnit = Children(i).Data
   Case "CDMATERIALUNIT":z7337.cdMaterialUnit = Children(i).Data
   Case "SPECIFICATION":z7337.Specification = Children(i).Data
   Case "WIDTH":z7337.Width = Children(i).Data
   Case "HEIGHT":z7337.Height = Children(i).Data
   Case "SIZENAME":z7337.SizeName = Children(i).Data
   Case "COLORNAME":z7337.ColorName = Children(i).Data
   Case "SESHOESSTATUS":z7337.seShoesStatus = Children(i).Data
   Case "CDSHOESSTATUS":z7337.cdShoesStatus = Children(i).Data
   Case "SEDEPARTMENT":z7337.seDepartment = Children(i).Data
   Case "CDDEPARTMENT":z7337.cdDepartment = Children(i).Data
   Case "SUPPLIERCODE":z7337.SupplierCode = Children(i).Data
   Case "QTYCOMPONENT":z7337.QtyComponent = Children(i).Data
   Case "CONSUMPTION":z7337.Consumption = Children(i).Data
   Case "PRICE":z7337.Price = Children(i).Data
   Case "UNITPRICE":z7337.UnitPrice = Children(i).Data
   Case "LOSS":z7337.Loss = Children(i).Data
   Case "USAGE":z7337.Usage = Children(i).Data
   Case "REMARK":z7337.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7337_MOVE",vbCritical)
End Try
End Function 
    
End Module 
