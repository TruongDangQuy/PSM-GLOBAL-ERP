'=========================================================================================================================================================
'   TABLE : (PFK7114)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7114

Structure T7114_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	Autokey	 AS Double	'			decimal		*
Public 	Dseq	 AS Double	'			decimal
Public 	BaseComponentBOM	 AS String	'			char(6)
Public 	ShoesCode	 AS String	'			char(6)
Public 	MaterialSeq	 AS Double	'			decimal
Public 	SizeNo	 AS String	'			char(2)
Public 	SizeNoName	 AS String	'			nvarchar(50)
Public 	MaterialCode	 AS String	'			char(6)
Public 	Color	 AS String	'			nvarchar(200)
Public 	Specification	 AS String	'			nvarchar(20)
Public 	Width	 AS String	'			nvarchar(20)
Public 	Height	 AS String	'			nvarchar(20)
Public 	SizeName	 AS String	'			nvarchar(20)
Public 	ColorName	 AS String	'			nvarchar(100)
Public 	QtySize	 AS Double	'			decimal
Public 	LossSize	 AS Double	'			decimal
Public 	QtyUsage	 AS Double	'			decimal
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
Public 	QtyComponent	 AS Double	'			decimal
Public 	MaterialAMT	 AS Double	'			decimal
Public 	seSubProcess	 AS String	'			char(3)
Public 	cdSubProcess	 AS String	'			char(3)
'=========================================================================================================================================================
End structure

Public D7114 As T7114_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK7114(AUTOKEY AS Double) As Boolean
    READ_PFK7114 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7114 "
    SQL = SQL & " WHERE K7114_Autokey		 =  " & Autokey & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D7114_CLEAR: GoTo SKIP_READ_PFK7114
                
    Call K7114_MOVE(rd)
    READ_PFK7114 = True

SKIP_READ_PFK7114:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK7114",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK7114(AUTOKEY AS Double, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7114 "
    SQL = SQL & " WHERE K7114_Autokey		 =  " & Autokey & "  " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK7114",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK7114(z7114 As T7114_AREA) As Boolean
    WRITE_PFK7114 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z7114)
 
    SQL = " INSERT INTO PFK7114 "
    SQL = SQL & " ( "
            SQL = SQL & " K7114_Dseq,"
    SQL = SQL & " K7114_BaseComponentBOM," 
    SQL = SQL & " K7114_ShoesCode," 
    SQL = SQL & " K7114_MaterialSeq," 
    SQL = SQL & " K7114_SizeNo," 
    SQL = SQL & " K7114_SizeNoName," 
    SQL = SQL & " K7114_MaterialCode," 
    SQL = SQL & " K7114_Color," 
    SQL = SQL & " K7114_Specification," 
    SQL = SQL & " K7114_Width," 
    SQL = SQL & " K7114_Height," 
    SQL = SQL & " K7114_SizeName," 
    SQL = SQL & " K7114_ColorName," 
    SQL = SQL & " K7114_QtySize," 
    SQL = SQL & " K7114_LossSize," 
    SQL = SQL & " K7114_QtyUsage," 
    SQL = SQL & " K7114_seUnitMaterial," 
    SQL = SQL & " K7114_cdUnitmaterial," 
    SQL = SQL & " K7114_seShoesStatus," 
    SQL = SQL & " K7114_cdShoesStatus," 
    SQL = SQL & " K7114_seDepartment," 
    SQL = SQL & " K7114_cdDepartment," 
    SQL = SQL & " K7114_SupplierCode," 
    SQL = SQL & " K7114_Price," 
    SQL = SQL & " K7114_seUnitPrice," 
    SQL = SQL & " K7114_cdUnitPrice," 
    SQL = SQL & " K7114_QtyComponent," 
    SQL = SQL & " K7114_MaterialAMT," 
    SQL = SQL & " K7114_seSubProcess," 
    SQL = SQL & " K7114_cdSubProcess " 
    SQL = SQL & " ) VALUES ( "
            SQL = SQL & "   " & FormatSQL(z7114.Dseq) & ", "
    SQL = SQL & "  N'" & FormatSQL(z7114.BaseComponentBOM) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7114.ShoesCode) & "', "  
    SQL = SQL & "   " & FormatSQL(z7114.MaterialSeq) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z7114.SizeNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7114.SizeNoName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7114.MaterialCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7114.Color) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7114.Specification) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7114.Width) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7114.Height) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7114.SizeName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7114.ColorName) & "', "  
    SQL = SQL & "   " & FormatSQL(z7114.QtySize) & ", "  
    SQL = SQL & "   " & FormatSQL(z7114.LossSize) & ", "  
    SQL = SQL & "   " & FormatSQL(z7114.QtyUsage) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z7114.seUnitMaterial) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7114.cdUnitmaterial) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7114.seShoesStatus) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7114.cdShoesStatus) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7114.seDepartment) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7114.cdDepartment) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7114.SupplierCode) & "', "  
    SQL = SQL & "   " & FormatSQL(z7114.Price) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z7114.seUnitPrice) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7114.cdUnitPrice) & "', "  
    SQL = SQL & "   " & FormatSQL(z7114.QtyComponent) & ", "  
    SQL = SQL & "   " & FormatSQL(z7114.MaterialAMT) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z7114.seSubProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7114.cdSubProcess) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK7114 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK7114",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK7114(z7114 As T7114_AREA) As Boolean
    REWRITE_PFK7114 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7114)
   
    SQL = " UPDATE PFK7114 SET "
    SQL = SQL & "    K7114_Dseq      =  " & FormatSQL(z7114.Dseq) & ", " 
    SQL = SQL & "    K7114_BaseComponentBOM      = N'" & FormatSQL(z7114.BaseComponentBOM) & "', " 
    SQL = SQL & "    K7114_ShoesCode      = N'" & FormatSQL(z7114.ShoesCode) & "', " 
    SQL = SQL & "    K7114_MaterialSeq      =  " & FormatSQL(z7114.MaterialSeq) & ", " 
    SQL = SQL & "    K7114_SizeNo      = N'" & FormatSQL(z7114.SizeNo) & "', " 
    SQL = SQL & "    K7114_SizeNoName      = N'" & FormatSQL(z7114.SizeNoName) & "', " 
    SQL = SQL & "    K7114_MaterialCode      = N'" & FormatSQL(z7114.MaterialCode) & "', " 
    SQL = SQL & "    K7114_Color      = N'" & FormatSQL(z7114.Color) & "', " 
    SQL = SQL & "    K7114_Specification      = N'" & FormatSQL(z7114.Specification) & "', " 
    SQL = SQL & "    K7114_Width      = N'" & FormatSQL(z7114.Width) & "', " 
    SQL = SQL & "    K7114_Height      = N'" & FormatSQL(z7114.Height) & "', " 
    SQL = SQL & "    K7114_SizeName      = N'" & FormatSQL(z7114.SizeName) & "', " 
    SQL = SQL & "    K7114_ColorName      = N'" & FormatSQL(z7114.ColorName) & "', " 
    SQL = SQL & "    K7114_QtySize      =  " & FormatSQL(z7114.QtySize) & ", " 
    SQL = SQL & "    K7114_LossSize      =  " & FormatSQL(z7114.LossSize) & ", " 
    SQL = SQL & "    K7114_QtyUsage      =  " & FormatSQL(z7114.QtyUsage) & ", " 
    SQL = SQL & "    K7114_seUnitMaterial      = N'" & FormatSQL(z7114.seUnitMaterial) & "', " 
    SQL = SQL & "    K7114_cdUnitmaterial      = N'" & FormatSQL(z7114.cdUnitmaterial) & "', " 
    SQL = SQL & "    K7114_seShoesStatus      = N'" & FormatSQL(z7114.seShoesStatus) & "', " 
    SQL = SQL & "    K7114_cdShoesStatus      = N'" & FormatSQL(z7114.cdShoesStatus) & "', " 
    SQL = SQL & "    K7114_seDepartment      = N'" & FormatSQL(z7114.seDepartment) & "', " 
    SQL = SQL & "    K7114_cdDepartment      = N'" & FormatSQL(z7114.cdDepartment) & "', " 
    SQL = SQL & "    K7114_SupplierCode      = N'" & FormatSQL(z7114.SupplierCode) & "', " 
    SQL = SQL & "    K7114_Price      =  " & FormatSQL(z7114.Price) & ", " 
    SQL = SQL & "    K7114_seUnitPrice      = N'" & FormatSQL(z7114.seUnitPrice) & "', " 
    SQL = SQL & "    K7114_cdUnitPrice      = N'" & FormatSQL(z7114.cdUnitPrice) & "', " 
    SQL = SQL & "    K7114_QtyComponent      =  " & FormatSQL(z7114.QtyComponent) & ", " 
    SQL = SQL & "    K7114_MaterialAMT      =  " & FormatSQL(z7114.MaterialAMT) & ", " 
    SQL = SQL & "    K7114_seSubProcess      = N'" & FormatSQL(z7114.seSubProcess) & "', " 
    SQL = SQL & "    K7114_cdSubProcess      = N'" & FormatSQL(z7114.cdSubProcess) & "'  " 
    SQL = SQL & " WHERE K7114_Autokey		 =  " & z7114.Autokey & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK7114 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK7114",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK7114(z7114 As T7114_AREA) As Boolean
    DELETE_PFK7114 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK7114 "
    SQL = SQL & " WHERE K7114_Autokey		 =  " & z7114.Autokey & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK7114 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK7114",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D7114_CLEAR()
Try
    
    D7114.Autokey = 0 
    D7114.Dseq = 0 
   D7114.BaseComponentBOM = ""
   D7114.ShoesCode = ""
    D7114.MaterialSeq = 0 
   D7114.SizeNo = ""
   D7114.SizeNoName = ""
   D7114.MaterialCode = ""
   D7114.Color = ""
   D7114.Specification = ""
   D7114.Width = ""
   D7114.Height = ""
   D7114.SizeName = ""
   D7114.ColorName = ""
    D7114.QtySize = 0 
    D7114.LossSize = 0 
    D7114.QtyUsage = 0 
   D7114.seUnitMaterial = ""
   D7114.cdUnitmaterial = ""
   D7114.seShoesStatus = ""
   D7114.cdShoesStatus = ""
   D7114.seDepartment = ""
   D7114.cdDepartment = ""
   D7114.SupplierCode = ""
    D7114.Price = 0 
   D7114.seUnitPrice = ""
   D7114.cdUnitPrice = ""
    D7114.QtyComponent = 0 
    D7114.MaterialAMT = 0 
   D7114.seSubProcess = ""
   D7114.cdSubProcess = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D7114_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x7114 As T7114_AREA)
Try
    
    x7114.Autokey = trim$(  x7114.Autokey)
    x7114.Dseq = trim$(  x7114.Dseq)
    x7114.BaseComponentBOM = trim$(  x7114.BaseComponentBOM)
    x7114.ShoesCode = trim$(  x7114.ShoesCode)
    x7114.MaterialSeq = trim$(  x7114.MaterialSeq)
    x7114.SizeNo = trim$(  x7114.SizeNo)
    x7114.SizeNoName = trim$(  x7114.SizeNoName)
    x7114.MaterialCode = trim$(  x7114.MaterialCode)
    x7114.Color = trim$(  x7114.Color)
    x7114.Specification = trim$(  x7114.Specification)
    x7114.Width = trim$(  x7114.Width)
    x7114.Height = trim$(  x7114.Height)
    x7114.SizeName = trim$(  x7114.SizeName)
    x7114.ColorName = trim$(  x7114.ColorName)
    x7114.QtySize = trim$(  x7114.QtySize)
    x7114.LossSize = trim$(  x7114.LossSize)
    x7114.QtyUsage = trim$(  x7114.QtyUsage)
    x7114.seUnitMaterial = trim$(  x7114.seUnitMaterial)
    x7114.cdUnitmaterial = trim$(  x7114.cdUnitmaterial)
    x7114.seShoesStatus = trim$(  x7114.seShoesStatus)
    x7114.cdShoesStatus = trim$(  x7114.cdShoesStatus)
    x7114.seDepartment = trim$(  x7114.seDepartment)
    x7114.cdDepartment = trim$(  x7114.cdDepartment)
    x7114.SupplierCode = trim$(  x7114.SupplierCode)
    x7114.Price = trim$(  x7114.Price)
    x7114.seUnitPrice = trim$(  x7114.seUnitPrice)
    x7114.cdUnitPrice = trim$(  x7114.cdUnitPrice)
    x7114.QtyComponent = trim$(  x7114.QtyComponent)
    x7114.MaterialAMT = trim$(  x7114.MaterialAMT)
    x7114.seSubProcess = trim$(  x7114.seSubProcess)
    x7114.cdSubProcess = trim$(  x7114.cdSubProcess)
     
    If trim$( x7114.Autokey ) = "" Then x7114.Autokey = 0 
    If trim$( x7114.Dseq ) = "" Then x7114.Dseq = 0 
    If trim$( x7114.BaseComponentBOM ) = "" Then x7114.BaseComponentBOM = Space(1) 
    If trim$( x7114.ShoesCode ) = "" Then x7114.ShoesCode = Space(1) 
    If trim$( x7114.MaterialSeq ) = "" Then x7114.MaterialSeq = 0 
    If trim$( x7114.SizeNo ) = "" Then x7114.SizeNo = Space(1) 
    If trim$( x7114.SizeNoName ) = "" Then x7114.SizeNoName = Space(1) 
    If trim$( x7114.MaterialCode ) = "" Then x7114.MaterialCode = Space(1) 
    If trim$( x7114.Color ) = "" Then x7114.Color = Space(1) 
    If trim$( x7114.Specification ) = "" Then x7114.Specification = Space(1) 
    If trim$( x7114.Width ) = "" Then x7114.Width = Space(1) 
    If trim$( x7114.Height ) = "" Then x7114.Height = Space(1) 
    If trim$( x7114.SizeName ) = "" Then x7114.SizeName = Space(1) 
    If trim$( x7114.ColorName ) = "" Then x7114.ColorName = Space(1) 
    If trim$( x7114.QtySize ) = "" Then x7114.QtySize = 0 
    If trim$( x7114.LossSize ) = "" Then x7114.LossSize = 0 
    If trim$( x7114.QtyUsage ) = "" Then x7114.QtyUsage = 0 
    If trim$( x7114.seUnitMaterial ) = "" Then x7114.seUnitMaterial = Space(1) 
    If trim$( x7114.cdUnitmaterial ) = "" Then x7114.cdUnitmaterial = Space(1) 
    If trim$( x7114.seShoesStatus ) = "" Then x7114.seShoesStatus = Space(1) 
    If trim$( x7114.cdShoesStatus ) = "" Then x7114.cdShoesStatus = Space(1) 
    If trim$( x7114.seDepartment ) = "" Then x7114.seDepartment = Space(1) 
    If trim$( x7114.cdDepartment ) = "" Then x7114.cdDepartment = Space(1) 
    If trim$( x7114.SupplierCode ) = "" Then x7114.SupplierCode = Space(1) 
    If trim$( x7114.Price ) = "" Then x7114.Price = 0 
    If trim$( x7114.seUnitPrice ) = "" Then x7114.seUnitPrice = Space(1) 
    If trim$( x7114.cdUnitPrice ) = "" Then x7114.cdUnitPrice = Space(1) 
    If trim$( x7114.QtyComponent ) = "" Then x7114.QtyComponent = 0 
    If trim$( x7114.MaterialAMT ) = "" Then x7114.MaterialAMT = 0 
    If trim$( x7114.seSubProcess ) = "" Then x7114.seSubProcess = Space(1) 
    If trim$( x7114.cdSubProcess ) = "" Then x7114.cdSubProcess = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K7114_MOVE(rs7114 As SqlClient.SqlDataReader)
Try

    call D7114_CLEAR()   

    If IsdbNull(rs7114!K7114_Autokey) = False Then D7114.Autokey = Trim$(rs7114!K7114_Autokey)
    If IsdbNull(rs7114!K7114_Dseq) = False Then D7114.Dseq = Trim$(rs7114!K7114_Dseq)
    If IsdbNull(rs7114!K7114_BaseComponentBOM) = False Then D7114.BaseComponentBOM = Trim$(rs7114!K7114_BaseComponentBOM)
    If IsdbNull(rs7114!K7114_ShoesCode) = False Then D7114.ShoesCode = Trim$(rs7114!K7114_ShoesCode)
    If IsdbNull(rs7114!K7114_MaterialSeq) = False Then D7114.MaterialSeq = Trim$(rs7114!K7114_MaterialSeq)
    If IsdbNull(rs7114!K7114_SizeNo) = False Then D7114.SizeNo = Trim$(rs7114!K7114_SizeNo)
    If IsdbNull(rs7114!K7114_SizeNoName) = False Then D7114.SizeNoName = Trim$(rs7114!K7114_SizeNoName)
    If IsdbNull(rs7114!K7114_MaterialCode) = False Then D7114.MaterialCode = Trim$(rs7114!K7114_MaterialCode)
    If IsdbNull(rs7114!K7114_Color) = False Then D7114.Color = Trim$(rs7114!K7114_Color)
    If IsdbNull(rs7114!K7114_Specification) = False Then D7114.Specification = Trim$(rs7114!K7114_Specification)
    If IsdbNull(rs7114!K7114_Width) = False Then D7114.Width = Trim$(rs7114!K7114_Width)
    If IsdbNull(rs7114!K7114_Height) = False Then D7114.Height = Trim$(rs7114!K7114_Height)
    If IsdbNull(rs7114!K7114_SizeName) = False Then D7114.SizeName = Trim$(rs7114!K7114_SizeName)
    If IsdbNull(rs7114!K7114_ColorName) = False Then D7114.ColorName = Trim$(rs7114!K7114_ColorName)
    If IsdbNull(rs7114!K7114_QtySize) = False Then D7114.QtySize = Trim$(rs7114!K7114_QtySize)
    If IsdbNull(rs7114!K7114_LossSize) = False Then D7114.LossSize = Trim$(rs7114!K7114_LossSize)
    If IsdbNull(rs7114!K7114_QtyUsage) = False Then D7114.QtyUsage = Trim$(rs7114!K7114_QtyUsage)
    If IsdbNull(rs7114!K7114_seUnitMaterial) = False Then D7114.seUnitMaterial = Trim$(rs7114!K7114_seUnitMaterial)
    If IsdbNull(rs7114!K7114_cdUnitmaterial) = False Then D7114.cdUnitmaterial = Trim$(rs7114!K7114_cdUnitmaterial)
    If IsdbNull(rs7114!K7114_seShoesStatus) = False Then D7114.seShoesStatus = Trim$(rs7114!K7114_seShoesStatus)
    If IsdbNull(rs7114!K7114_cdShoesStatus) = False Then D7114.cdShoesStatus = Trim$(rs7114!K7114_cdShoesStatus)
    If IsdbNull(rs7114!K7114_seDepartment) = False Then D7114.seDepartment = Trim$(rs7114!K7114_seDepartment)
    If IsdbNull(rs7114!K7114_cdDepartment) = False Then D7114.cdDepartment = Trim$(rs7114!K7114_cdDepartment)
    If IsdbNull(rs7114!K7114_SupplierCode) = False Then D7114.SupplierCode = Trim$(rs7114!K7114_SupplierCode)
    If IsdbNull(rs7114!K7114_Price) = False Then D7114.Price = Trim$(rs7114!K7114_Price)
    If IsdbNull(rs7114!K7114_seUnitPrice) = False Then D7114.seUnitPrice = Trim$(rs7114!K7114_seUnitPrice)
    If IsdbNull(rs7114!K7114_cdUnitPrice) = False Then D7114.cdUnitPrice = Trim$(rs7114!K7114_cdUnitPrice)
    If IsdbNull(rs7114!K7114_QtyComponent) = False Then D7114.QtyComponent = Trim$(rs7114!K7114_QtyComponent)
    If IsdbNull(rs7114!K7114_MaterialAMT) = False Then D7114.MaterialAMT = Trim$(rs7114!K7114_MaterialAMT)
    If IsdbNull(rs7114!K7114_seSubProcess) = False Then D7114.seSubProcess = Trim$(rs7114!K7114_seSubProcess)
    If IsdbNull(rs7114!K7114_cdSubProcess) = False Then D7114.cdSubProcess = Trim$(rs7114!K7114_cdSubProcess)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7114_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K7114_MOVE(rs7114 As DataRow)
Try

    call D7114_CLEAR()   

    If IsdbNull(rs7114!K7114_Autokey) = False Then D7114.Autokey = Trim$(rs7114!K7114_Autokey)
    If IsdbNull(rs7114!K7114_Dseq) = False Then D7114.Dseq = Trim$(rs7114!K7114_Dseq)
    If IsdbNull(rs7114!K7114_BaseComponentBOM) = False Then D7114.BaseComponentBOM = Trim$(rs7114!K7114_BaseComponentBOM)
    If IsdbNull(rs7114!K7114_ShoesCode) = False Then D7114.ShoesCode = Trim$(rs7114!K7114_ShoesCode)
    If IsdbNull(rs7114!K7114_MaterialSeq) = False Then D7114.MaterialSeq = Trim$(rs7114!K7114_MaterialSeq)
    If IsdbNull(rs7114!K7114_SizeNo) = False Then D7114.SizeNo = Trim$(rs7114!K7114_SizeNo)
    If IsdbNull(rs7114!K7114_SizeNoName) = False Then D7114.SizeNoName = Trim$(rs7114!K7114_SizeNoName)
    If IsdbNull(rs7114!K7114_MaterialCode) = False Then D7114.MaterialCode = Trim$(rs7114!K7114_MaterialCode)
    If IsdbNull(rs7114!K7114_Color) = False Then D7114.Color = Trim$(rs7114!K7114_Color)
    If IsdbNull(rs7114!K7114_Specification) = False Then D7114.Specification = Trim$(rs7114!K7114_Specification)
    If IsdbNull(rs7114!K7114_Width) = False Then D7114.Width = Trim$(rs7114!K7114_Width)
    If IsdbNull(rs7114!K7114_Height) = False Then D7114.Height = Trim$(rs7114!K7114_Height)
    If IsdbNull(rs7114!K7114_SizeName) = False Then D7114.SizeName = Trim$(rs7114!K7114_SizeName)
    If IsdbNull(rs7114!K7114_ColorName) = False Then D7114.ColorName = Trim$(rs7114!K7114_ColorName)
    If IsdbNull(rs7114!K7114_QtySize) = False Then D7114.QtySize = Trim$(rs7114!K7114_QtySize)
    If IsdbNull(rs7114!K7114_LossSize) = False Then D7114.LossSize = Trim$(rs7114!K7114_LossSize)
    If IsdbNull(rs7114!K7114_QtyUsage) = False Then D7114.QtyUsage = Trim$(rs7114!K7114_QtyUsage)
    If IsdbNull(rs7114!K7114_seUnitMaterial) = False Then D7114.seUnitMaterial = Trim$(rs7114!K7114_seUnitMaterial)
    If IsdbNull(rs7114!K7114_cdUnitmaterial) = False Then D7114.cdUnitmaterial = Trim$(rs7114!K7114_cdUnitmaterial)
    If IsdbNull(rs7114!K7114_seShoesStatus) = False Then D7114.seShoesStatus = Trim$(rs7114!K7114_seShoesStatus)
    If IsdbNull(rs7114!K7114_cdShoesStatus) = False Then D7114.cdShoesStatus = Trim$(rs7114!K7114_cdShoesStatus)
    If IsdbNull(rs7114!K7114_seDepartment) = False Then D7114.seDepartment = Trim$(rs7114!K7114_seDepartment)
    If IsdbNull(rs7114!K7114_cdDepartment) = False Then D7114.cdDepartment = Trim$(rs7114!K7114_cdDepartment)
    If IsdbNull(rs7114!K7114_SupplierCode) = False Then D7114.SupplierCode = Trim$(rs7114!K7114_SupplierCode)
    If IsdbNull(rs7114!K7114_Price) = False Then D7114.Price = Trim$(rs7114!K7114_Price)
    If IsdbNull(rs7114!K7114_seUnitPrice) = False Then D7114.seUnitPrice = Trim$(rs7114!K7114_seUnitPrice)
    If IsdbNull(rs7114!K7114_cdUnitPrice) = False Then D7114.cdUnitPrice = Trim$(rs7114!K7114_cdUnitPrice)
    If IsdbNull(rs7114!K7114_QtyComponent) = False Then D7114.QtyComponent = Trim$(rs7114!K7114_QtyComponent)
    If IsdbNull(rs7114!K7114_MaterialAMT) = False Then D7114.MaterialAMT = Trim$(rs7114!K7114_MaterialAMT)
    If IsdbNull(rs7114!K7114_seSubProcess) = False Then D7114.seSubProcess = Trim$(rs7114!K7114_seSubProcess)
    If IsdbNull(rs7114!K7114_cdSubProcess) = False Then D7114.cdSubProcess = Trim$(rs7114!K7114_cdSubProcess)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7114_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K7114_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7114 As T7114_AREA, AUTOKEY AS Double) as Boolean

K7114_MOVE = False

Try
    If READ_PFK7114(AUTOKEY) = True Then
                z7114 = D7114
		K7114_MOVE = True
		else
	z7114 = nothing
     End If

     If  getColumIndex(spr,"Autokey") > -1 then z7114.Autokey = getDataM(spr, getColumIndex(spr,"Autokey"), xRow)
     If  getColumIndex(spr,"Dseq") > -1 then z7114.Dseq = getDataM(spr, getColumIndex(spr,"Dseq"), xRow)
     If  getColumIndex(spr,"BaseComponentBOM") > -1 then z7114.BaseComponentBOM = getDataM(spr, getColumIndex(spr,"BaseComponentBOM"), xRow)
     If  getColumIndex(spr,"ShoesCode") > -1 then z7114.ShoesCode = getDataM(spr, getColumIndex(spr,"ShoesCode"), xRow)
     If  getColumIndex(spr,"MaterialSeq") > -1 then z7114.MaterialSeq = getDataM(spr, getColumIndex(spr,"MaterialSeq"), xRow)
     If  getColumIndex(spr,"SizeNo") > -1 then z7114.SizeNo = getDataM(spr, getColumIndex(spr,"SizeNo"), xRow)
     If  getColumIndex(spr,"SizeNoName") > -1 then z7114.SizeNoName = getDataM(spr, getColumIndex(spr,"SizeNoName"), xRow)
     If  getColumIndex(spr,"MaterialCode") > -1 then z7114.MaterialCode = getDataM(spr, getColumIndex(spr,"MaterialCode"), xRow)
     If  getColumIndex(spr,"Color") > -1 then z7114.Color = getDataM(spr, getColumIndex(spr,"Color"), xRow)
     If  getColumIndex(spr,"Specification") > -1 then z7114.Specification = getDataM(spr, getColumIndex(spr,"Specification"), xRow)
     If  getColumIndex(spr,"Width") > -1 then z7114.Width = getDataM(spr, getColumIndex(spr,"Width"), xRow)
     If  getColumIndex(spr,"Height") > -1 then z7114.Height = getDataM(spr, getColumIndex(spr,"Height"), xRow)
     If  getColumIndex(spr,"SizeName") > -1 then z7114.SizeName = getDataM(spr, getColumIndex(spr,"SizeName"), xRow)
     If  getColumIndex(spr,"ColorName") > -1 then z7114.ColorName = getDataM(spr, getColumIndex(spr,"ColorName"), xRow)
     If  getColumIndex(spr,"QtySize") > -1 then z7114.QtySize = getDataM(spr, getColumIndex(spr,"QtySize"), xRow)
     If  getColumIndex(spr,"LossSize") > -1 then z7114.LossSize = getDataM(spr, getColumIndex(spr,"LossSize"), xRow)
     If  getColumIndex(spr,"QtyUsage") > -1 then z7114.QtyUsage = getDataM(spr, getColumIndex(spr,"QtyUsage"), xRow)
     If  getColumIndex(spr,"seUnitMaterial") > -1 then z7114.seUnitMaterial = getDataM(spr, getColumIndex(spr,"seUnitMaterial"), xRow)
     If  getColumIndex(spr,"cdUnitmaterial") > -1 then z7114.cdUnitmaterial = getDataM(spr, getColumIndex(spr,"cdUnitmaterial"), xRow)
     If  getColumIndex(spr,"seShoesStatus") > -1 then z7114.seShoesStatus = getDataM(spr, getColumIndex(spr,"seShoesStatus"), xRow)
     If  getColumIndex(spr,"cdShoesStatus") > -1 then z7114.cdShoesStatus = getDataM(spr, getColumIndex(spr,"cdShoesStatus"), xRow)
     If  getColumIndex(spr,"seDepartment") > -1 then z7114.seDepartment = getDataM(spr, getColumIndex(spr,"seDepartment"), xRow)
     If  getColumIndex(spr,"cdDepartment") > -1 then z7114.cdDepartment = getDataM(spr, getColumIndex(spr,"cdDepartment"), xRow)
     If  getColumIndex(spr,"SupplierCode") > -1 then z7114.SupplierCode = getDataM(spr, getColumIndex(spr,"SupplierCode"), xRow)
     If  getColumIndex(spr,"Price") > -1 then z7114.Price = getDataM(spr, getColumIndex(spr,"Price"), xRow)
     If  getColumIndex(spr,"seUnitPrice") > -1 then z7114.seUnitPrice = getDataM(spr, getColumIndex(spr,"seUnitPrice"), xRow)
     If  getColumIndex(spr,"cdUnitPrice") > -1 then z7114.cdUnitPrice = getDataM(spr, getColumIndex(spr,"cdUnitPrice"), xRow)
     If  getColumIndex(spr,"QtyComponent") > -1 then z7114.QtyComponent = getDataM(spr, getColumIndex(spr,"QtyComponent"), xRow)
     If  getColumIndex(spr,"MaterialAMT") > -1 then z7114.MaterialAMT = getDataM(spr, getColumIndex(spr,"MaterialAMT"), xRow)
     If  getColumIndex(spr,"seSubProcess") > -1 then z7114.seSubProcess = getDataM(spr, getColumIndex(spr,"seSubProcess"), xRow)
     If  getColumIndex(spr,"cdSubProcess") > -1 then z7114.cdSubProcess = getDataM(spr, getColumIndex(spr,"cdSubProcess"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7114_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K7114_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7114 As T7114_AREA,CheckClear as Boolean,AUTOKEY AS Double) as Boolean

K7114_MOVE = False

Try
    If READ_PFK7114(AUTOKEY) = True Then
                z7114 = D7114
		K7114_MOVE = True
		else
	If CheckClear  = True then z7114 = nothing
     End If

     If  getColumIndex(spr,"Autokey") > -1 then z7114.Autokey = getDataM(spr, getColumIndex(spr,"Autokey"), xRow)
     If  getColumIndex(spr,"Dseq") > -1 then z7114.Dseq = getDataM(spr, getColumIndex(spr,"Dseq"), xRow)
     If  getColumIndex(spr,"BaseComponentBOM") > -1 then z7114.BaseComponentBOM = getDataM(spr, getColumIndex(spr,"BaseComponentBOM"), xRow)
     If  getColumIndex(spr,"ShoesCode") > -1 then z7114.ShoesCode = getDataM(spr, getColumIndex(spr,"ShoesCode"), xRow)
     If  getColumIndex(spr,"MaterialSeq") > -1 then z7114.MaterialSeq = getDataM(spr, getColumIndex(spr,"MaterialSeq"), xRow)
     If  getColumIndex(spr,"SizeNo") > -1 then z7114.SizeNo = getDataM(spr, getColumIndex(spr,"SizeNo"), xRow)
     If  getColumIndex(spr,"SizeNoName") > -1 then z7114.SizeNoName = getDataM(spr, getColumIndex(spr,"SizeNoName"), xRow)
     If  getColumIndex(spr,"MaterialCode") > -1 then z7114.MaterialCode = getDataM(spr, getColumIndex(spr,"MaterialCode"), xRow)
     If  getColumIndex(spr,"Color") > -1 then z7114.Color = getDataM(spr, getColumIndex(spr,"Color"), xRow)
     If  getColumIndex(spr,"Specification") > -1 then z7114.Specification = getDataM(spr, getColumIndex(spr,"Specification"), xRow)
     If  getColumIndex(spr,"Width") > -1 then z7114.Width = getDataM(spr, getColumIndex(spr,"Width"), xRow)
     If  getColumIndex(spr,"Height") > -1 then z7114.Height = getDataM(spr, getColumIndex(spr,"Height"), xRow)
     If  getColumIndex(spr,"SizeName") > -1 then z7114.SizeName = getDataM(spr, getColumIndex(spr,"SizeName"), xRow)
     If  getColumIndex(spr,"ColorName") > -1 then z7114.ColorName = getDataM(spr, getColumIndex(spr,"ColorName"), xRow)
     If  getColumIndex(spr,"QtySize") > -1 then z7114.QtySize = getDataM(spr, getColumIndex(spr,"QtySize"), xRow)
     If  getColumIndex(spr,"LossSize") > -1 then z7114.LossSize = getDataM(spr, getColumIndex(spr,"LossSize"), xRow)
     If  getColumIndex(spr,"QtyUsage") > -1 then z7114.QtyUsage = getDataM(spr, getColumIndex(spr,"QtyUsage"), xRow)
     If  getColumIndex(spr,"seUnitMaterial") > -1 then z7114.seUnitMaterial = getDataM(spr, getColumIndex(spr,"seUnitMaterial"), xRow)
     If  getColumIndex(spr,"cdUnitmaterial") > -1 then z7114.cdUnitmaterial = getDataM(spr, getColumIndex(spr,"cdUnitmaterial"), xRow)
     If  getColumIndex(spr,"seShoesStatus") > -1 then z7114.seShoesStatus = getDataM(spr, getColumIndex(spr,"seShoesStatus"), xRow)
     If  getColumIndex(spr,"cdShoesStatus") > -1 then z7114.cdShoesStatus = getDataM(spr, getColumIndex(spr,"cdShoesStatus"), xRow)
     If  getColumIndex(spr,"seDepartment") > -1 then z7114.seDepartment = getDataM(spr, getColumIndex(spr,"seDepartment"), xRow)
     If  getColumIndex(spr,"cdDepartment") > -1 then z7114.cdDepartment = getDataM(spr, getColumIndex(spr,"cdDepartment"), xRow)
     If  getColumIndex(spr,"SupplierCode") > -1 then z7114.SupplierCode = getDataM(spr, getColumIndex(spr,"SupplierCode"), xRow)
     If  getColumIndex(spr,"Price") > -1 then z7114.Price = getDataM(spr, getColumIndex(spr,"Price"), xRow)
     If  getColumIndex(spr,"seUnitPrice") > -1 then z7114.seUnitPrice = getDataM(spr, getColumIndex(spr,"seUnitPrice"), xRow)
     If  getColumIndex(spr,"cdUnitPrice") > -1 then z7114.cdUnitPrice = getDataM(spr, getColumIndex(spr,"cdUnitPrice"), xRow)
     If  getColumIndex(spr,"QtyComponent") > -1 then z7114.QtyComponent = getDataM(spr, getColumIndex(spr,"QtyComponent"), xRow)
     If  getColumIndex(spr,"MaterialAMT") > -1 then z7114.MaterialAMT = getDataM(spr, getColumIndex(spr,"MaterialAMT"), xRow)
     If  getColumIndex(spr,"seSubProcess") > -1 then z7114.seSubProcess = getDataM(spr, getColumIndex(spr,"seSubProcess"), xRow)
     If  getColumIndex(spr,"cdSubProcess") > -1 then z7114.cdSubProcess = getDataM(spr, getColumIndex(spr,"cdSubProcess"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7114_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K7114_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7114 As T7114_AREA, Job as String, AUTOKEY AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7114_MOVE = False

Try
    If READ_PFK7114(AUTOKEY) = True Then
                z7114 = D7114
		K7114_MOVE = True
		else
	z7114 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7114")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "AUTOKEY":z7114.Autokey = Children(i).Code
   Case "DSEQ":z7114.Dseq = Children(i).Code
   Case "BASECOMPONENTBOM":z7114.BaseComponentBOM = Children(i).Code
   Case "SHOESCODE":z7114.ShoesCode = Children(i).Code
   Case "MATERIALSEQ":z7114.MaterialSeq = Children(i).Code
   Case "SIZENO":z7114.SizeNo = Children(i).Code
   Case "SIZENONAME":z7114.SizeNoName = Children(i).Code
   Case "MATERIALCODE":z7114.MaterialCode = Children(i).Code
   Case "COLOR":z7114.Color = Children(i).Code
   Case "SPECIFICATION":z7114.Specification = Children(i).Code
   Case "WIDTH":z7114.Width = Children(i).Code
   Case "HEIGHT":z7114.Height = Children(i).Code
   Case "SIZENAME":z7114.SizeName = Children(i).Code
   Case "COLORNAME":z7114.ColorName = Children(i).Code
   Case "QTYSIZE":z7114.QtySize = Children(i).Code
   Case "LOSSSIZE":z7114.LossSize = Children(i).Code
   Case "QTYUSAGE":z7114.QtyUsage = Children(i).Code
   Case "SEUNITMATERIAL":z7114.seUnitMaterial = Children(i).Code
   Case "CDUNITMATERIAL":z7114.cdUnitmaterial = Children(i).Code
   Case "SESHOESSTATUS":z7114.seShoesStatus = Children(i).Code
   Case "CDSHOESSTATUS":z7114.cdShoesStatus = Children(i).Code
   Case "SEDEPARTMENT":z7114.seDepartment = Children(i).Code
   Case "CDDEPARTMENT":z7114.cdDepartment = Children(i).Code
   Case "SUPPLIERCODE":z7114.SupplierCode = Children(i).Code
   Case "PRICE":z7114.Price = Children(i).Code
   Case "SEUNITPRICE":z7114.seUnitPrice = Children(i).Code
   Case "CDUNITPRICE":z7114.cdUnitPrice = Children(i).Code
   Case "QTYCOMPONENT":z7114.QtyComponent = Children(i).Code
   Case "MATERIALAMT":z7114.MaterialAMT = Children(i).Code
   Case "SESUBPROCESS":z7114.seSubProcess = Children(i).Code
   Case "CDSUBPROCESS":z7114.cdSubProcess = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "AUTOKEY":z7114.Autokey = Children(i).Data
   Case "DSEQ":z7114.Dseq = Children(i).Data
   Case "BASECOMPONENTBOM":z7114.BaseComponentBOM = Children(i).Data
   Case "SHOESCODE":z7114.ShoesCode = Children(i).Data
   Case "MATERIALSEQ":z7114.MaterialSeq = Children(i).Data
   Case "SIZENO":z7114.SizeNo = Children(i).Data
   Case "SIZENONAME":z7114.SizeNoName = Children(i).Data
   Case "MATERIALCODE":z7114.MaterialCode = Children(i).Data
   Case "COLOR":z7114.Color = Children(i).Data
   Case "SPECIFICATION":z7114.Specification = Children(i).Data
   Case "WIDTH":z7114.Width = Children(i).Data
   Case "HEIGHT":z7114.Height = Children(i).Data
   Case "SIZENAME":z7114.SizeName = Children(i).Data
   Case "COLORNAME":z7114.ColorName = Children(i).Data
   Case "QTYSIZE":z7114.QtySize = Children(i).Data
   Case "LOSSSIZE":z7114.LossSize = Children(i).Data
   Case "QTYUSAGE":z7114.QtyUsage = Children(i).Data
   Case "SEUNITMATERIAL":z7114.seUnitMaterial = Children(i).Data
   Case "CDUNITMATERIAL":z7114.cdUnitmaterial = Children(i).Data
   Case "SESHOESSTATUS":z7114.seShoesStatus = Children(i).Data
   Case "CDSHOESSTATUS":z7114.cdShoesStatus = Children(i).Data
   Case "SEDEPARTMENT":z7114.seDepartment = Children(i).Data
   Case "CDDEPARTMENT":z7114.cdDepartment = Children(i).Data
   Case "SUPPLIERCODE":z7114.SupplierCode = Children(i).Data
   Case "PRICE":z7114.Price = Children(i).Data
   Case "SEUNITPRICE":z7114.seUnitPrice = Children(i).Data
   Case "CDUNITPRICE":z7114.cdUnitPrice = Children(i).Data
   Case "QTYCOMPONENT":z7114.QtyComponent = Children(i).Data
   Case "MATERIALAMT":z7114.MaterialAMT = Children(i).Data
   Case "SESUBPROCESS":z7114.seSubProcess = Children(i).Data
   Case "CDSUBPROCESS":z7114.cdSubProcess = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7114_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K7114_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7114 As T7114_AREA, Job as String, CheckClear as Boolean, AUTOKEY AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7114_MOVE = False

Try
    If READ_PFK7114(AUTOKEY) = True Then
                z7114 = D7114
		K7114_MOVE = True
		else
	If CheckClear  = True then z7114 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7114")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "AUTOKEY":z7114.Autokey = Children(i).Code
   Case "DSEQ":z7114.Dseq = Children(i).Code
   Case "BASECOMPONENTBOM":z7114.BaseComponentBOM = Children(i).Code
   Case "SHOESCODE":z7114.ShoesCode = Children(i).Code
   Case "MATERIALSEQ":z7114.MaterialSeq = Children(i).Code
   Case "SIZENO":z7114.SizeNo = Children(i).Code
   Case "SIZENONAME":z7114.SizeNoName = Children(i).Code
   Case "MATERIALCODE":z7114.MaterialCode = Children(i).Code
   Case "COLOR":z7114.Color = Children(i).Code
   Case "SPECIFICATION":z7114.Specification = Children(i).Code
   Case "WIDTH":z7114.Width = Children(i).Code
   Case "HEIGHT":z7114.Height = Children(i).Code
   Case "SIZENAME":z7114.SizeName = Children(i).Code
   Case "COLORNAME":z7114.ColorName = Children(i).Code
   Case "QTYSIZE":z7114.QtySize = Children(i).Code
   Case "LOSSSIZE":z7114.LossSize = Children(i).Code
   Case "QTYUSAGE":z7114.QtyUsage = Children(i).Code
   Case "SEUNITMATERIAL":z7114.seUnitMaterial = Children(i).Code
   Case "CDUNITMATERIAL":z7114.cdUnitmaterial = Children(i).Code
   Case "SESHOESSTATUS":z7114.seShoesStatus = Children(i).Code
   Case "CDSHOESSTATUS":z7114.cdShoesStatus = Children(i).Code
   Case "SEDEPARTMENT":z7114.seDepartment = Children(i).Code
   Case "CDDEPARTMENT":z7114.cdDepartment = Children(i).Code
   Case "SUPPLIERCODE":z7114.SupplierCode = Children(i).Code
   Case "PRICE":z7114.Price = Children(i).Code
   Case "SEUNITPRICE":z7114.seUnitPrice = Children(i).Code
   Case "CDUNITPRICE":z7114.cdUnitPrice = Children(i).Code
   Case "QTYCOMPONENT":z7114.QtyComponent = Children(i).Code
   Case "MATERIALAMT":z7114.MaterialAMT = Children(i).Code
   Case "SESUBPROCESS":z7114.seSubProcess = Children(i).Code
   Case "CDSUBPROCESS":z7114.cdSubProcess = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "AUTOKEY":z7114.Autokey = Children(i).Data
   Case "DSEQ":z7114.Dseq = Children(i).Data
   Case "BASECOMPONENTBOM":z7114.BaseComponentBOM = Children(i).Data
   Case "SHOESCODE":z7114.ShoesCode = Children(i).Data
   Case "MATERIALSEQ":z7114.MaterialSeq = Children(i).Data
   Case "SIZENO":z7114.SizeNo = Children(i).Data
   Case "SIZENONAME":z7114.SizeNoName = Children(i).Data
   Case "MATERIALCODE":z7114.MaterialCode = Children(i).Data
   Case "COLOR":z7114.Color = Children(i).Data
   Case "SPECIFICATION":z7114.Specification = Children(i).Data
   Case "WIDTH":z7114.Width = Children(i).Data
   Case "HEIGHT":z7114.Height = Children(i).Data
   Case "SIZENAME":z7114.SizeName = Children(i).Data
   Case "COLORNAME":z7114.ColorName = Children(i).Data
   Case "QTYSIZE":z7114.QtySize = Children(i).Data
   Case "LOSSSIZE":z7114.LossSize = Children(i).Data
   Case "QTYUSAGE":z7114.QtyUsage = Children(i).Data
   Case "SEUNITMATERIAL":z7114.seUnitMaterial = Children(i).Data
   Case "CDUNITMATERIAL":z7114.cdUnitmaterial = Children(i).Data
   Case "SESHOESSTATUS":z7114.seShoesStatus = Children(i).Data
   Case "CDSHOESSTATUS":z7114.cdShoesStatus = Children(i).Data
   Case "SEDEPARTMENT":z7114.seDepartment = Children(i).Data
   Case "CDDEPARTMENT":z7114.cdDepartment = Children(i).Data
   Case "SUPPLIERCODE":z7114.SupplierCode = Children(i).Data
   Case "PRICE":z7114.Price = Children(i).Data
   Case "SEUNITPRICE":z7114.seUnitPrice = Children(i).Data
   Case "CDUNITPRICE":z7114.cdUnitPrice = Children(i).Data
   Case "QTYCOMPONENT":z7114.QtyComponent = Children(i).Data
   Case "MATERIALAMT":z7114.MaterialAMT = Children(i).Data
   Case "SESUBPROCESS":z7114.seSubProcess = Children(i).Data
   Case "CDSUBPROCESS":z7114.cdSubProcess = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7114_MOVE",vbCritical)
End Try
End Function 
    
End Module 
