'=========================================================================================================================================================
'   TABLE : (PFK1323)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K1323

Structure T1323_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	MatchingAutoKey	 AS String	'			char(8)		*
Public 	GroupComponentBOM	 AS String	'			char(6)		*
Public 	GroupComponentSeq	 AS Double	'			decimal		*
Public 	Dseq	 AS Double	'			decimal
Public 	CustomerCode	 AS String	'			char(6)
Public 	selGroupComponent	 AS String	'			char(3)
Public 	cdGroupComponent	 AS String	'			char(3)
Public 	ComponentName	 AS String	'			nvarchar(100)
Public 	MaterialCode	 AS String	'			char(6)
Public 	seUnitMaterial	 AS String	'			char(3)
Public 	cdUnitMaterial	 AS String	'			char(3)
Public 	Specification	 AS String	'			nvarchar(200)
Public 	Width	 AS String	'			nvarchar(20)
Public 	WidthID	 AS String	'			nvarchar(20)
Public 	Height	 AS String	'			nvarchar(20)
Public 	SizeName	 AS String	'			nvarchar(20)
Public 	cdColorCode	 AS String	'			char(3)
Public 	ColorCode	 AS String	'			char(6)
Public 	ColorName	 AS String	'			nvarchar(100)
Public 	seShoesStatus	 AS String	'			char(3)
Public 	cdShoesStatus	 AS String	'			char(3)
Public 	seDepartment	 AS String	'			char(3)
Public 	cdDepartment	 AS String	'			char(3)
Public 	SupplierCode	 AS String	'			char(6)
Public 	PriceMaterial	 AS Double	'			decimal
Public 	ExchangeCost	 AS Double	'			decimal
Public 	ComplicationCost	 AS Double	'			decimal
Public 	AddedCost	 AS Double	'			decimal
Public 	ShippingRate	 AS Double	'			decimal
Public 	ShippingCost	 AS Double	'			decimal
Public 	PriceRnD	 AS Double	'			decimal
Public 	Price	 AS Double	'			decimal
Public 	seUnitPrice	 AS String	'			char(3)
Public 	cdUnitPrice	 AS String	'			char(3)
Public 	QtyComponent	 AS Double	'			decimal
Public 	Consumption	 AS Double	'			decimal
Public 	Loss	 AS Double	'			decimal
Public 	GrossUsage	 AS Double	'			decimal
Public 	MaterialAMT	 AS Double	'			decimal
Public 	MaterialAMTPurchasing	 AS Double	'			decimal
Public 	MaterialAMTSales	 AS Double	'			decimal
Public 	seSubProcess	 AS String	'			char(3)
Public 	cdSubProcess	 AS String	'			char(3)
Public 	seSpecialProcess	 AS String	'			char(3)
Public 	cdSpecialProcess	 AS String	'			char(3)
Public 	CheckMark	 AS String	'			char(1)
Public 	CheckUse	 AS String	'			char(1)
Public 	Remark	 AS String	'			nvarchar(200)
'=========================================================================================================================================================
End structure

Public D1323 As T1323_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK1323(MATCHINGAUTOKEY AS String, GROUPCOMPONENTBOM AS String, GROUPCOMPONENTSEQ AS Double) As Boolean
    READ_PFK1323 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK1323 "
    SQL = SQL & " WHERE K1322_MatchingAutoKey		 = '" & MatchingAutoKey & "' " 
    SQL = SQL & "   AND K1323_GroupComponentBOM		 = '" & GroupComponentBOM & "' " 
    SQL = SQL & "   AND K1323_GroupComponentSeq		 =  " & GroupComponentSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D1323_CLEAR: GoTo SKIP_READ_PFK1323
                
    Call K1323_MOVE(rd)
    READ_PFK1323 = True

SKIP_READ_PFK1323:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK1323",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK1323(MATCHINGAUTOKEY AS String, GROUPCOMPONENTBOM AS String, GROUPCOMPONENTSEQ AS Double, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK1323 "
    SQL = SQL & " WHERE K1322_MatchingAutoKey		 = '" & MatchingAutoKey & "' " 
    SQL = SQL & "   AND K1323_GroupComponentBOM		 = '" & GroupComponentBOM & "' " 
    SQL = SQL & "   AND K1323_GroupComponentSeq		 =  " & GroupComponentSeq & "  " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK1323",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK1323(z1323 As T1323_AREA) As Boolean
    WRITE_PFK1323 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z1323)
 
    SQL = " INSERT INTO PFK1323 "
    SQL = SQL & " ( "
    SQL = SQL & " K1322_MatchingAutoKey," 
    SQL = SQL & " K1323_GroupComponentBOM," 
    SQL = SQL & " K1323_GroupComponentSeq," 
    SQL = SQL & " K1323_Dseq," 
    SQL = SQL & " K1323_CustomerCode," 
    SQL = SQL & " K1323_selGroupComponent," 
    SQL = SQL & " K1323_cdGroupComponent," 
    SQL = SQL & " K1323_ComponentName," 
    SQL = SQL & " K1323_MaterialCode," 
    SQL = SQL & " K1323_seUnitMaterial," 
    SQL = SQL & " K1323_cdUnitMaterial," 
    SQL = SQL & " K1323_Specification," 
    SQL = SQL & " K1323_Width," 
    SQL = SQL & " K1323_WidthID," 
    SQL = SQL & " K1323_Height," 
    SQL = SQL & " K1323_SizeName," 
    SQL = SQL & " K1323_cdColorCode," 
    SQL = SQL & " K1323_ColorCode," 
    SQL = SQL & " K1323_ColorName," 
    SQL = SQL & " K1323_seShoesStatus," 
    SQL = SQL & " K1323_cdShoesStatus," 
    SQL = SQL & " K1323_seDepartment," 
    SQL = SQL & " K1323_cdDepartment," 
    SQL = SQL & " K1323_SupplierCode," 
    SQL = SQL & " K1323_PriceMaterial," 
    SQL = SQL & " K1323_ExchangeCost," 
    SQL = SQL & " K1323_ComplicationCost," 
    SQL = SQL & " K1323_AddedCost," 
    SQL = SQL & " K1323_ShippingRate," 
    SQL = SQL & " K1323_ShippingCost," 
    SQL = SQL & " K1323_PriceRnD," 
    SQL = SQL & " K1323_Price," 
    SQL = SQL & " K1323_seUnitPrice," 
    SQL = SQL & " K1323_cdUnitPrice," 
    SQL = SQL & " K1323_QtyComponent," 
    SQL = SQL & " K1323_Consumption," 
    SQL = SQL & " K1323_Loss," 
    SQL = SQL & " K1323_GrossUsage," 
    SQL = SQL & " K1323_MaterialAMT," 
    SQL = SQL & " K1323_MaterialAMTPurchasing," 
    SQL = SQL & " K1323_MaterialAMTSales," 
    SQL = SQL & " K1323_seSubProcess," 
    SQL = SQL & " K1323_cdSubProcess," 
    SQL = SQL & " K1323_seSpecialProcess," 
    SQL = SQL & " K1323_cdSpecialProcess," 
    SQL = SQL & " K1323_CheckMark," 
    SQL = SQL & " K1323_CheckUse," 
    SQL = SQL & " K1323_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z1323.MatchingAutoKey) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1323.GroupComponentBOM) & "', "  
    SQL = SQL & "   " & FormatSQL(z1323.GroupComponentSeq) & ", "  
    SQL = SQL & "   " & FormatSQL(z1323.Dseq) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z1323.CustomerCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1323.selGroupComponent) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1323.cdGroupComponent) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1323.ComponentName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1323.MaterialCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1323.seUnitMaterial) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1323.cdUnitMaterial) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1323.Specification) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1323.Width) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1323.WidthID) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1323.Height) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1323.SizeName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1323.cdColorCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1323.ColorCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1323.ColorName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1323.seShoesStatus) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1323.cdShoesStatus) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1323.seDepartment) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1323.cdDepartment) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1323.SupplierCode) & "', "  
    SQL = SQL & "   " & FormatSQL(z1323.PriceMaterial) & ", "  
    SQL = SQL & "   " & FormatSQL(z1323.ExchangeCost) & ", "  
    SQL = SQL & "   " & FormatSQL(z1323.ComplicationCost) & ", "  
    SQL = SQL & "   " & FormatSQL(z1323.AddedCost) & ", "  
    SQL = SQL & "   " & FormatSQL(z1323.ShippingRate) & ", "  
    SQL = SQL & "   " & FormatSQL(z1323.ShippingCost) & ", "  
    SQL = SQL & "   " & FormatSQL(z1323.PriceRnD) & ", "  
    SQL = SQL & "   " & FormatSQL(z1323.Price) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z1323.seUnitPrice) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1323.cdUnitPrice) & "', "  
    SQL = SQL & "   " & FormatSQL(z1323.QtyComponent) & ", "  
    SQL = SQL & "   " & FormatSQL(z1323.Consumption) & ", "  
    SQL = SQL & "   " & FormatSQL(z1323.Loss) & ", "  
    SQL = SQL & "   " & FormatSQL(z1323.GrossUsage) & ", "  
    SQL = SQL & "   " & FormatSQL(z1323.MaterialAMT) & ", "  
    SQL = SQL & "   " & FormatSQL(z1323.MaterialAMTPurchasing) & ", "  
    SQL = SQL & "   " & FormatSQL(z1323.MaterialAMTSales) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z1323.seSubProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1323.cdSubProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1323.seSpecialProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1323.cdSpecialProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1323.CheckMark) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1323.CheckUse) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1323.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK1323 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK1323",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK1323(z1323 As T1323_AREA) As Boolean
    REWRITE_PFK1323 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z1323)
   
    SQL = " UPDATE PFK1323 SET "
    SQL = SQL & "    K1323_Dseq      =  " & FormatSQL(z1323.Dseq) & ", " 
    SQL = SQL & "    K1323_CustomerCode      = N'" & FormatSQL(z1323.CustomerCode) & "', " 
    SQL = SQL & "    K1323_selGroupComponent      = N'" & FormatSQL(z1323.selGroupComponent) & "', " 
    SQL = SQL & "    K1323_cdGroupComponent      = N'" & FormatSQL(z1323.cdGroupComponent) & "', " 
    SQL = SQL & "    K1323_ComponentName      = N'" & FormatSQL(z1323.ComponentName) & "', " 
    SQL = SQL & "    K1323_MaterialCode      = N'" & FormatSQL(z1323.MaterialCode) & "', " 
    SQL = SQL & "    K1323_seUnitMaterial      = N'" & FormatSQL(z1323.seUnitMaterial) & "', " 
    SQL = SQL & "    K1323_cdUnitMaterial      = N'" & FormatSQL(z1323.cdUnitMaterial) & "', " 
    SQL = SQL & "    K1323_Specification      = N'" & FormatSQL(z1323.Specification) & "', " 
    SQL = SQL & "    K1323_Width      = N'" & FormatSQL(z1323.Width) & "', " 
    SQL = SQL & "    K1323_WidthID      = N'" & FormatSQL(z1323.WidthID) & "', " 
    SQL = SQL & "    K1323_Height      = N'" & FormatSQL(z1323.Height) & "', " 
    SQL = SQL & "    K1323_SizeName      = N'" & FormatSQL(z1323.SizeName) & "', " 
    SQL = SQL & "    K1323_cdColorCode      = N'" & FormatSQL(z1323.cdColorCode) & "', " 
    SQL = SQL & "    K1323_ColorCode      = N'" & FormatSQL(z1323.ColorCode) & "', " 
    SQL = SQL & "    K1323_ColorName      = N'" & FormatSQL(z1323.ColorName) & "', " 
    SQL = SQL & "    K1323_seShoesStatus      = N'" & FormatSQL(z1323.seShoesStatus) & "', " 
    SQL = SQL & "    K1323_cdShoesStatus      = N'" & FormatSQL(z1323.cdShoesStatus) & "', " 
    SQL = SQL & "    K1323_seDepartment      = N'" & FormatSQL(z1323.seDepartment) & "', " 
    SQL = SQL & "    K1323_cdDepartment      = N'" & FormatSQL(z1323.cdDepartment) & "', " 
    SQL = SQL & "    K1323_SupplierCode      = N'" & FormatSQL(z1323.SupplierCode) & "', " 
    SQL = SQL & "    K1323_PriceMaterial      =  " & FormatSQL(z1323.PriceMaterial) & ", " 
    SQL = SQL & "    K1323_ExchangeCost      =  " & FormatSQL(z1323.ExchangeCost) & ", " 
    SQL = SQL & "    K1323_ComplicationCost      =  " & FormatSQL(z1323.ComplicationCost) & ", " 
    SQL = SQL & "    K1323_AddedCost      =  " & FormatSQL(z1323.AddedCost) & ", " 
    SQL = SQL & "    K1323_ShippingRate      =  " & FormatSQL(z1323.ShippingRate) & ", " 
    SQL = SQL & "    K1323_ShippingCost      =  " & FormatSQL(z1323.ShippingCost) & ", " 
    SQL = SQL & "    K1323_PriceRnD      =  " & FormatSQL(z1323.PriceRnD) & ", " 
    SQL = SQL & "    K1323_Price      =  " & FormatSQL(z1323.Price) & ", " 
    SQL = SQL & "    K1323_seUnitPrice      = N'" & FormatSQL(z1323.seUnitPrice) & "', " 
    SQL = SQL & "    K1323_cdUnitPrice      = N'" & FormatSQL(z1323.cdUnitPrice) & "', " 
    SQL = SQL & "    K1323_QtyComponent      =  " & FormatSQL(z1323.QtyComponent) & ", " 
    SQL = SQL & "    K1323_Consumption      =  " & FormatSQL(z1323.Consumption) & ", " 
    SQL = SQL & "    K1323_Loss      =  " & FormatSQL(z1323.Loss) & ", " 
    SQL = SQL & "    K1323_GrossUsage      =  " & FormatSQL(z1323.GrossUsage) & ", " 
    SQL = SQL & "    K1323_MaterialAMT      =  " & FormatSQL(z1323.MaterialAMT) & ", " 
    SQL = SQL & "    K1323_MaterialAMTPurchasing      =  " & FormatSQL(z1323.MaterialAMTPurchasing) & ", " 
    SQL = SQL & "    K1323_MaterialAMTSales      =  " & FormatSQL(z1323.MaterialAMTSales) & ", " 
    SQL = SQL & "    K1323_seSubProcess      = N'" & FormatSQL(z1323.seSubProcess) & "', " 
    SQL = SQL & "    K1323_cdSubProcess      = N'" & FormatSQL(z1323.cdSubProcess) & "', " 
    SQL = SQL & "    K1323_seSpecialProcess      = N'" & FormatSQL(z1323.seSpecialProcess) & "', " 
    SQL = SQL & "    K1323_cdSpecialProcess      = N'" & FormatSQL(z1323.cdSpecialProcess) & "', " 
    SQL = SQL & "    K1323_CheckMark      = N'" & FormatSQL(z1323.CheckMark) & "', " 
    SQL = SQL & "    K1323_CheckUse      = N'" & FormatSQL(z1323.CheckUse) & "', " 
    SQL = SQL & "    K1323_Remark      = N'" & FormatSQL(z1323.Remark) & "'  " 
    SQL = SQL & " WHERE K1322_MatchingAutoKey		 = '" & z1323.MatchingAutoKey & "' " 
    SQL = SQL & "   AND K1323_GroupComponentBOM		 = '" & z1323.GroupComponentBOM & "' " 
    SQL = SQL & "   AND K1323_GroupComponentSeq		 =  " & z1323.GroupComponentSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK1323 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK1323",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK1323(z1323 As T1323_AREA) As Boolean
    DELETE_PFK1323 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK1323 "
    SQL = SQL & " WHERE K1322_MatchingAutoKey		 = '" & z1323.MatchingAutoKey & "' " 
    SQL = SQL & "   AND K1323_GroupComponentBOM		 = '" & z1323.GroupComponentBOM & "' " 
    SQL = SQL & "   AND K1323_GroupComponentSeq		 =  " & z1323.GroupComponentSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK1323 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK1323",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D1323_CLEAR()
Try
    
   D1323.MatchingAutoKey = ""
   D1323.GroupComponentBOM = ""
    D1323.GroupComponentSeq = 0 
    D1323.Dseq = 0 
   D1323.CustomerCode = ""
   D1323.selGroupComponent = ""
   D1323.cdGroupComponent = ""
   D1323.ComponentName = ""
   D1323.MaterialCode = ""
   D1323.seUnitMaterial = ""
   D1323.cdUnitMaterial = ""
   D1323.Specification = ""
   D1323.Width = ""
   D1323.WidthID = ""
   D1323.Height = ""
   D1323.SizeName = ""
   D1323.cdColorCode = ""
   D1323.ColorCode = ""
   D1323.ColorName = ""
   D1323.seShoesStatus = ""
   D1323.cdShoesStatus = ""
   D1323.seDepartment = ""
   D1323.cdDepartment = ""
   D1323.SupplierCode = ""
    D1323.PriceMaterial = 0 
    D1323.ExchangeCost = 0 
    D1323.ComplicationCost = 0 
    D1323.AddedCost = 0 
    D1323.ShippingRate = 0 
    D1323.ShippingCost = 0 
    D1323.PriceRnD = 0 
    D1323.Price = 0 
   D1323.seUnitPrice = ""
   D1323.cdUnitPrice = ""
    D1323.QtyComponent = 0 
    D1323.Consumption = 0 
    D1323.Loss = 0 
    D1323.GrossUsage = 0 
    D1323.MaterialAMT = 0 
    D1323.MaterialAMTPurchasing = 0 
    D1323.MaterialAMTSales = 0 
   D1323.seSubProcess = ""
   D1323.cdSubProcess = ""
   D1323.seSpecialProcess = ""
   D1323.cdSpecialProcess = ""
   D1323.CheckMark = ""
   D1323.CheckUse = ""
   D1323.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D1323_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x1323 As T1323_AREA)
Try
    
    x1323.MatchingAutoKey = trim$(  x1323.MatchingAutoKey)
    x1323.GroupComponentBOM = trim$(  x1323.GroupComponentBOM)
    x1323.GroupComponentSeq = trim$(  x1323.GroupComponentSeq)
    x1323.Dseq = trim$(  x1323.Dseq)
    x1323.CustomerCode = trim$(  x1323.CustomerCode)
    x1323.selGroupComponent = trim$(  x1323.selGroupComponent)
    x1323.cdGroupComponent = trim$(  x1323.cdGroupComponent)
    x1323.ComponentName = trim$(  x1323.ComponentName)
    x1323.MaterialCode = trim$(  x1323.MaterialCode)
    x1323.seUnitMaterial = trim$(  x1323.seUnitMaterial)
    x1323.cdUnitMaterial = trim$(  x1323.cdUnitMaterial)
    x1323.Specification = trim$(  x1323.Specification)
    x1323.Width = trim$(  x1323.Width)
    x1323.WidthID = trim$(  x1323.WidthID)
    x1323.Height = trim$(  x1323.Height)
    x1323.SizeName = trim$(  x1323.SizeName)
    x1323.cdColorCode = trim$(  x1323.cdColorCode)
    x1323.ColorCode = trim$(  x1323.ColorCode)
    x1323.ColorName = trim$(  x1323.ColorName)
    x1323.seShoesStatus = trim$(  x1323.seShoesStatus)
    x1323.cdShoesStatus = trim$(  x1323.cdShoesStatus)
    x1323.seDepartment = trim$(  x1323.seDepartment)
    x1323.cdDepartment = trim$(  x1323.cdDepartment)
    x1323.SupplierCode = trim$(  x1323.SupplierCode)
    x1323.PriceMaterial = trim$(  x1323.PriceMaterial)
    x1323.ExchangeCost = trim$(  x1323.ExchangeCost)
    x1323.ComplicationCost = trim$(  x1323.ComplicationCost)
    x1323.AddedCost = trim$(  x1323.AddedCost)
    x1323.ShippingRate = trim$(  x1323.ShippingRate)
    x1323.ShippingCost = trim$(  x1323.ShippingCost)
    x1323.PriceRnD = trim$(  x1323.PriceRnD)
    x1323.Price = trim$(  x1323.Price)
    x1323.seUnitPrice = trim$(  x1323.seUnitPrice)
    x1323.cdUnitPrice = trim$(  x1323.cdUnitPrice)
    x1323.QtyComponent = trim$(  x1323.QtyComponent)
    x1323.Consumption = trim$(  x1323.Consumption)
    x1323.Loss = trim$(  x1323.Loss)
    x1323.GrossUsage = trim$(  x1323.GrossUsage)
    x1323.MaterialAMT = trim$(  x1323.MaterialAMT)
    x1323.MaterialAMTPurchasing = trim$(  x1323.MaterialAMTPurchasing)
    x1323.MaterialAMTSales = trim$(  x1323.MaterialAMTSales)
    x1323.seSubProcess = trim$(  x1323.seSubProcess)
    x1323.cdSubProcess = trim$(  x1323.cdSubProcess)
    x1323.seSpecialProcess = trim$(  x1323.seSpecialProcess)
    x1323.cdSpecialProcess = trim$(  x1323.cdSpecialProcess)
    x1323.CheckMark = trim$(  x1323.CheckMark)
    x1323.CheckUse = trim$(  x1323.CheckUse)
    x1323.Remark = trim$(  x1323.Remark)
     
    If trim$( x1323.MatchingAutoKey ) = "" Then x1323.MatchingAutoKey = Space(1) 
    If trim$( x1323.GroupComponentBOM ) = "" Then x1323.GroupComponentBOM = Space(1) 
    If trim$( x1323.GroupComponentSeq ) = "" Then x1323.GroupComponentSeq = 0 
    If trim$( x1323.Dseq ) = "" Then x1323.Dseq = 0 
    If trim$( x1323.CustomerCode ) = "" Then x1323.CustomerCode = Space(1) 
    If trim$( x1323.selGroupComponent ) = "" Then x1323.selGroupComponent = Space(1) 
    If trim$( x1323.cdGroupComponent ) = "" Then x1323.cdGroupComponent = Space(1) 
    If trim$( x1323.ComponentName ) = "" Then x1323.ComponentName = Space(1) 
    If trim$( x1323.MaterialCode ) = "" Then x1323.MaterialCode = Space(1) 
    If trim$( x1323.seUnitMaterial ) = "" Then x1323.seUnitMaterial = Space(1) 
    If trim$( x1323.cdUnitMaterial ) = "" Then x1323.cdUnitMaterial = Space(1) 
    If trim$( x1323.Specification ) = "" Then x1323.Specification = Space(1) 
    If trim$( x1323.Width ) = "" Then x1323.Width = Space(1) 
    If trim$( x1323.WidthID ) = "" Then x1323.WidthID = Space(1) 
    If trim$( x1323.Height ) = "" Then x1323.Height = Space(1) 
    If trim$( x1323.SizeName ) = "" Then x1323.SizeName = Space(1) 
    If trim$( x1323.cdColorCode ) = "" Then x1323.cdColorCode = Space(1) 
    If trim$( x1323.ColorCode ) = "" Then x1323.ColorCode = Space(1) 
    If trim$( x1323.ColorName ) = "" Then x1323.ColorName = Space(1) 
    If trim$( x1323.seShoesStatus ) = "" Then x1323.seShoesStatus = Space(1) 
    If trim$( x1323.cdShoesStatus ) = "" Then x1323.cdShoesStatus = Space(1) 
    If trim$( x1323.seDepartment ) = "" Then x1323.seDepartment = Space(1) 
    If trim$( x1323.cdDepartment ) = "" Then x1323.cdDepartment = Space(1) 
    If trim$( x1323.SupplierCode ) = "" Then x1323.SupplierCode = Space(1) 
    If trim$( x1323.PriceMaterial ) = "" Then x1323.PriceMaterial = 0 
    If trim$( x1323.ExchangeCost ) = "" Then x1323.ExchangeCost = 0 
    If trim$( x1323.ComplicationCost ) = "" Then x1323.ComplicationCost = 0 
    If trim$( x1323.AddedCost ) = "" Then x1323.AddedCost = 0 
    If trim$( x1323.ShippingRate ) = "" Then x1323.ShippingRate = 0 
    If trim$( x1323.ShippingCost ) = "" Then x1323.ShippingCost = 0 
    If trim$( x1323.PriceRnD ) = "" Then x1323.PriceRnD = 0 
    If trim$( x1323.Price ) = "" Then x1323.Price = 0 
    If trim$( x1323.seUnitPrice ) = "" Then x1323.seUnitPrice = Space(1) 
    If trim$( x1323.cdUnitPrice ) = "" Then x1323.cdUnitPrice = Space(1) 
    If trim$( x1323.QtyComponent ) = "" Then x1323.QtyComponent = 0 
    If trim$( x1323.Consumption ) = "" Then x1323.Consumption = 0 
    If trim$( x1323.Loss ) = "" Then x1323.Loss = 0 
    If trim$( x1323.GrossUsage ) = "" Then x1323.GrossUsage = 0 
    If trim$( x1323.MaterialAMT ) = "" Then x1323.MaterialAMT = 0 
    If trim$( x1323.MaterialAMTPurchasing ) = "" Then x1323.MaterialAMTPurchasing = 0 
    If trim$( x1323.MaterialAMTSales ) = "" Then x1323.MaterialAMTSales = 0 
    If trim$( x1323.seSubProcess ) = "" Then x1323.seSubProcess = Space(1) 
    If trim$( x1323.cdSubProcess ) = "" Then x1323.cdSubProcess = Space(1) 
    If trim$( x1323.seSpecialProcess ) = "" Then x1323.seSpecialProcess = Space(1) 
    If trim$( x1323.cdSpecialProcess ) = "" Then x1323.cdSpecialProcess = Space(1) 
    If trim$( x1323.CheckMark ) = "" Then x1323.CheckMark = Space(1) 
    If trim$( x1323.CheckUse ) = "" Then x1323.CheckUse = Space(1) 
    If trim$( x1323.Remark ) = "" Then x1323.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K1323_MOVE(rs1323 As SqlClient.SqlDataReader)
Try

    call D1323_CLEAR()   

    If IsdbNull(rs1323!K1323_MatchingAutoKey) = False Then D1323.MatchingAutoKey = Trim$(rs1323!K1323_MatchingAutoKey)
    If IsdbNull(rs1323!K1323_GroupComponentBOM) = False Then D1323.GroupComponentBOM = Trim$(rs1323!K1323_GroupComponentBOM)
    If IsdbNull(rs1323!K1323_GroupComponentSeq) = False Then D1323.GroupComponentSeq = Trim$(rs1323!K1323_GroupComponentSeq)
    If IsdbNull(rs1323!K1323_Dseq) = False Then D1323.Dseq = Trim$(rs1323!K1323_Dseq)
    If IsdbNull(rs1323!K1323_CustomerCode) = False Then D1323.CustomerCode = Trim$(rs1323!K1323_CustomerCode)
    If IsdbNull(rs1323!K1323_selGroupComponent) = False Then D1323.selGroupComponent = Trim$(rs1323!K1323_selGroupComponent)
    If IsdbNull(rs1323!K1323_cdGroupComponent) = False Then D1323.cdGroupComponent = Trim$(rs1323!K1323_cdGroupComponent)
    If IsdbNull(rs1323!K1323_ComponentName) = False Then D1323.ComponentName = Trim$(rs1323!K1323_ComponentName)
    If IsdbNull(rs1323!K1323_MaterialCode) = False Then D1323.MaterialCode = Trim$(rs1323!K1323_MaterialCode)
    If IsdbNull(rs1323!K1323_seUnitMaterial) = False Then D1323.seUnitMaterial = Trim$(rs1323!K1323_seUnitMaterial)
    If IsdbNull(rs1323!K1323_cdUnitMaterial) = False Then D1323.cdUnitMaterial = Trim$(rs1323!K1323_cdUnitMaterial)
    If IsdbNull(rs1323!K1323_Specification) = False Then D1323.Specification = Trim$(rs1323!K1323_Specification)
    If IsdbNull(rs1323!K1323_Width) = False Then D1323.Width = Trim$(rs1323!K1323_Width)
    If IsdbNull(rs1323!K1323_WidthID) = False Then D1323.WidthID = Trim$(rs1323!K1323_WidthID)
    If IsdbNull(rs1323!K1323_Height) = False Then D1323.Height = Trim$(rs1323!K1323_Height)
    If IsdbNull(rs1323!K1323_SizeName) = False Then D1323.SizeName = Trim$(rs1323!K1323_SizeName)
    If IsdbNull(rs1323!K1323_cdColorCode) = False Then D1323.cdColorCode = Trim$(rs1323!K1323_cdColorCode)
    If IsdbNull(rs1323!K1323_ColorCode) = False Then D1323.ColorCode = Trim$(rs1323!K1323_ColorCode)
    If IsdbNull(rs1323!K1323_ColorName) = False Then D1323.ColorName = Trim$(rs1323!K1323_ColorName)
    If IsdbNull(rs1323!K1323_seShoesStatus) = False Then D1323.seShoesStatus = Trim$(rs1323!K1323_seShoesStatus)
    If IsdbNull(rs1323!K1323_cdShoesStatus) = False Then D1323.cdShoesStatus = Trim$(rs1323!K1323_cdShoesStatus)
    If IsdbNull(rs1323!K1323_seDepartment) = False Then D1323.seDepartment = Trim$(rs1323!K1323_seDepartment)
    If IsdbNull(rs1323!K1323_cdDepartment) = False Then D1323.cdDepartment = Trim$(rs1323!K1323_cdDepartment)
    If IsdbNull(rs1323!K1323_SupplierCode) = False Then D1323.SupplierCode = Trim$(rs1323!K1323_SupplierCode)
    If IsdbNull(rs1323!K1323_PriceMaterial) = False Then D1323.PriceMaterial = Trim$(rs1323!K1323_PriceMaterial)
    If IsdbNull(rs1323!K1323_ExchangeCost) = False Then D1323.ExchangeCost = Trim$(rs1323!K1323_ExchangeCost)
    If IsdbNull(rs1323!K1323_ComplicationCost) = False Then D1323.ComplicationCost = Trim$(rs1323!K1323_ComplicationCost)
    If IsdbNull(rs1323!K1323_AddedCost) = False Then D1323.AddedCost = Trim$(rs1323!K1323_AddedCost)
    If IsdbNull(rs1323!K1323_ShippingRate) = False Then D1323.ShippingRate = Trim$(rs1323!K1323_ShippingRate)
    If IsdbNull(rs1323!K1323_ShippingCost) = False Then D1323.ShippingCost = Trim$(rs1323!K1323_ShippingCost)
    If IsdbNull(rs1323!K1323_PriceRnD) = False Then D1323.PriceRnD = Trim$(rs1323!K1323_PriceRnD)
    If IsdbNull(rs1323!K1323_Price) = False Then D1323.Price = Trim$(rs1323!K1323_Price)
    If IsdbNull(rs1323!K1323_seUnitPrice) = False Then D1323.seUnitPrice = Trim$(rs1323!K1323_seUnitPrice)
    If IsdbNull(rs1323!K1323_cdUnitPrice) = False Then D1323.cdUnitPrice = Trim$(rs1323!K1323_cdUnitPrice)
    If IsdbNull(rs1323!K1323_QtyComponent) = False Then D1323.QtyComponent = Trim$(rs1323!K1323_QtyComponent)
    If IsdbNull(rs1323!K1323_Consumption) = False Then D1323.Consumption = Trim$(rs1323!K1323_Consumption)
    If IsdbNull(rs1323!K1323_Loss) = False Then D1323.Loss = Trim$(rs1323!K1323_Loss)
    If IsdbNull(rs1323!K1323_GrossUsage) = False Then D1323.GrossUsage = Trim$(rs1323!K1323_GrossUsage)
    If IsdbNull(rs1323!K1323_MaterialAMT) = False Then D1323.MaterialAMT = Trim$(rs1323!K1323_MaterialAMT)
    If IsdbNull(rs1323!K1323_MaterialAMTPurchasing) = False Then D1323.MaterialAMTPurchasing = Trim$(rs1323!K1323_MaterialAMTPurchasing)
    If IsdbNull(rs1323!K1323_MaterialAMTSales) = False Then D1323.MaterialAMTSales = Trim$(rs1323!K1323_MaterialAMTSales)
    If IsdbNull(rs1323!K1323_seSubProcess) = False Then D1323.seSubProcess = Trim$(rs1323!K1323_seSubProcess)
    If IsdbNull(rs1323!K1323_cdSubProcess) = False Then D1323.cdSubProcess = Trim$(rs1323!K1323_cdSubProcess)
    If IsdbNull(rs1323!K1323_seSpecialProcess) = False Then D1323.seSpecialProcess = Trim$(rs1323!K1323_seSpecialProcess)
    If IsdbNull(rs1323!K1323_cdSpecialProcess) = False Then D1323.cdSpecialProcess = Trim$(rs1323!K1323_cdSpecialProcess)
    If IsdbNull(rs1323!K1323_CheckMark) = False Then D1323.CheckMark = Trim$(rs1323!K1323_CheckMark)
    If IsdbNull(rs1323!K1323_CheckUse) = False Then D1323.CheckUse = Trim$(rs1323!K1323_CheckUse)
    If IsdbNull(rs1323!K1323_Remark) = False Then D1323.Remark = Trim$(rs1323!K1323_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K1323_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K1323_MOVE(rs1323 As DataRow)
Try

    call D1323_CLEAR()   

    If IsdbNull(rs1323!K1323_MatchingAutoKey) = False Then D1323.MatchingAutoKey = Trim$(rs1323!K1323_MatchingAutoKey)
    If IsdbNull(rs1323!K1323_GroupComponentBOM) = False Then D1323.GroupComponentBOM = Trim$(rs1323!K1323_GroupComponentBOM)
    If IsdbNull(rs1323!K1323_GroupComponentSeq) = False Then D1323.GroupComponentSeq = Trim$(rs1323!K1323_GroupComponentSeq)
    If IsdbNull(rs1323!K1323_Dseq) = False Then D1323.Dseq = Trim$(rs1323!K1323_Dseq)
    If IsdbNull(rs1323!K1323_CustomerCode) = False Then D1323.CustomerCode = Trim$(rs1323!K1323_CustomerCode)
    If IsdbNull(rs1323!K1323_selGroupComponent) = False Then D1323.selGroupComponent = Trim$(rs1323!K1323_selGroupComponent)
    If IsdbNull(rs1323!K1323_cdGroupComponent) = False Then D1323.cdGroupComponent = Trim$(rs1323!K1323_cdGroupComponent)
    If IsdbNull(rs1323!K1323_ComponentName) = False Then D1323.ComponentName = Trim$(rs1323!K1323_ComponentName)
    If IsdbNull(rs1323!K1323_MaterialCode) = False Then D1323.MaterialCode = Trim$(rs1323!K1323_MaterialCode)
    If IsdbNull(rs1323!K1323_seUnitMaterial) = False Then D1323.seUnitMaterial = Trim$(rs1323!K1323_seUnitMaterial)
    If IsdbNull(rs1323!K1323_cdUnitMaterial) = False Then D1323.cdUnitMaterial = Trim$(rs1323!K1323_cdUnitMaterial)
    If IsdbNull(rs1323!K1323_Specification) = False Then D1323.Specification = Trim$(rs1323!K1323_Specification)
    If IsdbNull(rs1323!K1323_Width) = False Then D1323.Width = Trim$(rs1323!K1323_Width)
    If IsdbNull(rs1323!K1323_WidthID) = False Then D1323.WidthID = Trim$(rs1323!K1323_WidthID)
    If IsdbNull(rs1323!K1323_Height) = False Then D1323.Height = Trim$(rs1323!K1323_Height)
    If IsdbNull(rs1323!K1323_SizeName) = False Then D1323.SizeName = Trim$(rs1323!K1323_SizeName)
    If IsdbNull(rs1323!K1323_cdColorCode) = False Then D1323.cdColorCode = Trim$(rs1323!K1323_cdColorCode)
    If IsdbNull(rs1323!K1323_ColorCode) = False Then D1323.ColorCode = Trim$(rs1323!K1323_ColorCode)
    If IsdbNull(rs1323!K1323_ColorName) = False Then D1323.ColorName = Trim$(rs1323!K1323_ColorName)
    If IsdbNull(rs1323!K1323_seShoesStatus) = False Then D1323.seShoesStatus = Trim$(rs1323!K1323_seShoesStatus)
    If IsdbNull(rs1323!K1323_cdShoesStatus) = False Then D1323.cdShoesStatus = Trim$(rs1323!K1323_cdShoesStatus)
    If IsdbNull(rs1323!K1323_seDepartment) = False Then D1323.seDepartment = Trim$(rs1323!K1323_seDepartment)
    If IsdbNull(rs1323!K1323_cdDepartment) = False Then D1323.cdDepartment = Trim$(rs1323!K1323_cdDepartment)
    If IsdbNull(rs1323!K1323_SupplierCode) = False Then D1323.SupplierCode = Trim$(rs1323!K1323_SupplierCode)
    If IsdbNull(rs1323!K1323_PriceMaterial) = False Then D1323.PriceMaterial = Trim$(rs1323!K1323_PriceMaterial)
    If IsdbNull(rs1323!K1323_ExchangeCost) = False Then D1323.ExchangeCost = Trim$(rs1323!K1323_ExchangeCost)
    If IsdbNull(rs1323!K1323_ComplicationCost) = False Then D1323.ComplicationCost = Trim$(rs1323!K1323_ComplicationCost)
    If IsdbNull(rs1323!K1323_AddedCost) = False Then D1323.AddedCost = Trim$(rs1323!K1323_AddedCost)
    If IsdbNull(rs1323!K1323_ShippingRate) = False Then D1323.ShippingRate = Trim$(rs1323!K1323_ShippingRate)
    If IsdbNull(rs1323!K1323_ShippingCost) = False Then D1323.ShippingCost = Trim$(rs1323!K1323_ShippingCost)
    If IsdbNull(rs1323!K1323_PriceRnD) = False Then D1323.PriceRnD = Trim$(rs1323!K1323_PriceRnD)
    If IsdbNull(rs1323!K1323_Price) = False Then D1323.Price = Trim$(rs1323!K1323_Price)
    If IsdbNull(rs1323!K1323_seUnitPrice) = False Then D1323.seUnitPrice = Trim$(rs1323!K1323_seUnitPrice)
    If IsdbNull(rs1323!K1323_cdUnitPrice) = False Then D1323.cdUnitPrice = Trim$(rs1323!K1323_cdUnitPrice)
    If IsdbNull(rs1323!K1323_QtyComponent) = False Then D1323.QtyComponent = Trim$(rs1323!K1323_QtyComponent)
    If IsdbNull(rs1323!K1323_Consumption) = False Then D1323.Consumption = Trim$(rs1323!K1323_Consumption)
    If IsdbNull(rs1323!K1323_Loss) = False Then D1323.Loss = Trim$(rs1323!K1323_Loss)
    If IsdbNull(rs1323!K1323_GrossUsage) = False Then D1323.GrossUsage = Trim$(rs1323!K1323_GrossUsage)
    If IsdbNull(rs1323!K1323_MaterialAMT) = False Then D1323.MaterialAMT = Trim$(rs1323!K1323_MaterialAMT)
    If IsdbNull(rs1323!K1323_MaterialAMTPurchasing) = False Then D1323.MaterialAMTPurchasing = Trim$(rs1323!K1323_MaterialAMTPurchasing)
    If IsdbNull(rs1323!K1323_MaterialAMTSales) = False Then D1323.MaterialAMTSales = Trim$(rs1323!K1323_MaterialAMTSales)
    If IsdbNull(rs1323!K1323_seSubProcess) = False Then D1323.seSubProcess = Trim$(rs1323!K1323_seSubProcess)
    If IsdbNull(rs1323!K1323_cdSubProcess) = False Then D1323.cdSubProcess = Trim$(rs1323!K1323_cdSubProcess)
    If IsdbNull(rs1323!K1323_seSpecialProcess) = False Then D1323.seSpecialProcess = Trim$(rs1323!K1323_seSpecialProcess)
    If IsdbNull(rs1323!K1323_cdSpecialProcess) = False Then D1323.cdSpecialProcess = Trim$(rs1323!K1323_cdSpecialProcess)
    If IsdbNull(rs1323!K1323_CheckMark) = False Then D1323.CheckMark = Trim$(rs1323!K1323_CheckMark)
    If IsdbNull(rs1323!K1323_CheckUse) = False Then D1323.CheckUse = Trim$(rs1323!K1323_CheckUse)
    If IsdbNull(rs1323!K1323_Remark) = False Then D1323.Remark = Trim$(rs1323!K1323_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K1323_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K1323_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z1323 As T1323_AREA, MATCHINGAUTOKEY AS String, GROUPCOMPONENTBOM AS String, GROUPCOMPONENTSEQ AS Double) as Boolean

K1323_MOVE = False

Try
    If READ_PFK1323(MATCHINGAUTOKEY, GROUPCOMPONENTBOM, GROUPCOMPONENTSEQ) = True Then
                z1323 = D1323
		K1323_MOVE = True
		else
	z1323 = nothing
     End If

     If  getColumIndex(spr,"MatchingAutoKey") > -1 then z1323.MatchingAutoKey = getDataM(spr, getColumIndex(spr,"MatchingAutoKey"), xRow)
     If  getColumIndex(spr,"GroupComponentBOM") > -1 then z1323.GroupComponentBOM = getDataM(spr, getColumIndex(spr,"GroupComponentBOM"), xRow)
     If  getColumIndex(spr,"GroupComponentSeq") > -1 then z1323.GroupComponentSeq = getDataM(spr, getColumIndex(spr,"GroupComponentSeq"), xRow)
     If  getColumIndex(spr,"Dseq") > -1 then z1323.Dseq = getDataM(spr, getColumIndex(spr,"Dseq"), xRow)
     If  getColumIndex(spr,"CustomerCode") > -1 then z1323.CustomerCode = getDataM(spr, getColumIndex(spr,"CustomerCode"), xRow)
     If  getColumIndex(spr,"selGroupComponent") > -1 then z1323.selGroupComponent = getDataM(spr, getColumIndex(spr,"selGroupComponent"), xRow)
     If  getColumIndex(spr,"cdGroupComponent") > -1 then z1323.cdGroupComponent = getDataM(spr, getColumIndex(spr,"cdGroupComponent"), xRow)
     If  getColumIndex(spr,"ComponentName") > -1 then z1323.ComponentName = getDataM(spr, getColumIndex(spr,"ComponentName"), xRow)
     If  getColumIndex(spr,"MaterialCode") > -1 then z1323.MaterialCode = getDataM(spr, getColumIndex(spr,"MaterialCode"), xRow)
     If  getColumIndex(spr,"seUnitMaterial") > -1 then z1323.seUnitMaterial = getDataM(spr, getColumIndex(spr,"seUnitMaterial"), xRow)
     If  getColumIndex(spr,"cdUnitMaterial") > -1 then z1323.cdUnitMaterial = getDataM(spr, getColumIndex(spr,"cdUnitMaterial"), xRow)
     If  getColumIndex(spr,"Specification") > -1 then z1323.Specification = getDataM(spr, getColumIndex(spr,"Specification"), xRow)
     If  getColumIndex(spr,"Width") > -1 then z1323.Width = getDataM(spr, getColumIndex(spr,"Width"), xRow)
     If  getColumIndex(spr,"WidthID") > -1 then z1323.WidthID = getDataM(spr, getColumIndex(spr,"WidthID"), xRow)
     If  getColumIndex(spr,"Height") > -1 then z1323.Height = getDataM(spr, getColumIndex(spr,"Height"), xRow)
     If  getColumIndex(spr,"SizeName") > -1 then z1323.SizeName = getDataM(spr, getColumIndex(spr,"SizeName"), xRow)
     If  getColumIndex(spr,"cdColorCode") > -1 then z1323.cdColorCode = getDataM(spr, getColumIndex(spr,"cdColorCode"), xRow)
     If  getColumIndex(spr,"ColorCode") > -1 then z1323.ColorCode = getDataM(spr, getColumIndex(spr,"ColorCode"), xRow)
     If  getColumIndex(spr,"ColorName") > -1 then z1323.ColorName = getDataM(spr, getColumIndex(spr,"ColorName"), xRow)
     If  getColumIndex(spr,"seShoesStatus") > -1 then z1323.seShoesStatus = getDataM(spr, getColumIndex(spr,"seShoesStatus"), xRow)
     If  getColumIndex(spr,"cdShoesStatus") > -1 then z1323.cdShoesStatus = getDataM(spr, getColumIndex(spr,"cdShoesStatus"), xRow)
     If  getColumIndex(spr,"seDepartment") > -1 then z1323.seDepartment = getDataM(spr, getColumIndex(spr,"seDepartment"), xRow)
     If  getColumIndex(spr,"cdDepartment") > -1 then z1323.cdDepartment = getDataM(spr, getColumIndex(spr,"cdDepartment"), xRow)
     If  getColumIndex(spr,"SupplierCode") > -1 then z1323.SupplierCode = getDataM(spr, getColumIndex(spr,"SupplierCode"), xRow)
     If  getColumIndex(spr,"PriceMaterial") > -1 then z1323.PriceMaterial = getDataM(spr, getColumIndex(spr,"PriceMaterial"), xRow)
     If  getColumIndex(spr,"ExchangeCost") > -1 then z1323.ExchangeCost = getDataM(spr, getColumIndex(spr,"ExchangeCost"), xRow)
     If  getColumIndex(spr,"ComplicationCost") > -1 then z1323.ComplicationCost = getDataM(spr, getColumIndex(spr,"ComplicationCost"), xRow)
     If  getColumIndex(spr,"AddedCost") > -1 then z1323.AddedCost = getDataM(spr, getColumIndex(spr,"AddedCost"), xRow)
     If  getColumIndex(spr,"ShippingRate") > -1 then z1323.ShippingRate = getDataM(spr, getColumIndex(spr,"ShippingRate"), xRow)
     If  getColumIndex(spr,"ShippingCost") > -1 then z1323.ShippingCost = getDataM(spr, getColumIndex(spr,"ShippingCost"), xRow)
     If  getColumIndex(spr,"PriceRnD") > -1 then z1323.PriceRnD = getDataM(spr, getColumIndex(spr,"PriceRnD"), xRow)
     If  getColumIndex(spr,"Price") > -1 then z1323.Price = getDataM(spr, getColumIndex(spr,"Price"), xRow)
     If  getColumIndex(spr,"seUnitPrice") > -1 then z1323.seUnitPrice = getDataM(spr, getColumIndex(spr,"seUnitPrice"), xRow)
     If  getColumIndex(spr,"cdUnitPrice") > -1 then z1323.cdUnitPrice = getDataM(spr, getColumIndex(spr,"cdUnitPrice"), xRow)
     If  getColumIndex(spr,"QtyComponent") > -1 then z1323.QtyComponent = getDataM(spr, getColumIndex(spr,"QtyComponent"), xRow)
     If  getColumIndex(spr,"Consumption") > -1 then z1323.Consumption = getDataM(spr, getColumIndex(spr,"Consumption"), xRow)
     If  getColumIndex(spr,"Loss") > -1 then z1323.Loss = getDataM(spr, getColumIndex(spr,"Loss"), xRow)
     If  getColumIndex(spr,"GrossUsage") > -1 then z1323.GrossUsage = getDataM(spr, getColumIndex(spr,"GrossUsage"), xRow)
     If  getColumIndex(spr,"MaterialAMT") > -1 then z1323.MaterialAMT = getDataM(spr, getColumIndex(spr,"MaterialAMT"), xRow)
     If  getColumIndex(spr,"MaterialAMTPurchasing") > -1 then z1323.MaterialAMTPurchasing = getDataM(spr, getColumIndex(spr,"MaterialAMTPurchasing"), xRow)
     If  getColumIndex(spr,"MaterialAMTSales") > -1 then z1323.MaterialAMTSales = getDataM(spr, getColumIndex(spr,"MaterialAMTSales"), xRow)
     If  getColumIndex(spr,"seSubProcess") > -1 then z1323.seSubProcess = getDataM(spr, getColumIndex(spr,"seSubProcess"), xRow)
     If  getColumIndex(spr,"cdSubProcess") > -1 then z1323.cdSubProcess = getDataM(spr, getColumIndex(spr,"cdSubProcess"), xRow)
     If  getColumIndex(spr,"seSpecialProcess") > -1 then z1323.seSpecialProcess = getDataM(spr, getColumIndex(spr,"seSpecialProcess"), xRow)
     If  getColumIndex(spr,"cdSpecialProcess") > -1 then z1323.cdSpecialProcess = getDataM(spr, getColumIndex(spr,"cdSpecialProcess"), xRow)
     If  getColumIndex(spr,"CheckMark") > -1 then z1323.CheckMark = getDataM(spr, getColumIndex(spr,"CheckMark"), xRow)
     If  getColumIndex(spr,"CheckUse") > -1 then z1323.CheckUse = getDataM(spr, getColumIndex(spr,"CheckUse"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z1323.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K1323_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K1323_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z1323 As T1323_AREA,CheckClear as Boolean,MATCHINGAUTOKEY AS String, GROUPCOMPONENTBOM AS String, GROUPCOMPONENTSEQ AS Double) as Boolean

K1323_MOVE = False

Try
    If READ_PFK1323(MATCHINGAUTOKEY, GROUPCOMPONENTBOM, GROUPCOMPONENTSEQ) = True Then
                z1323 = D1323
		K1323_MOVE = True
		else
	If CheckClear  = True then z1323 = nothing
     End If

     If  getColumIndex(spr,"MatchingAutoKey") > -1 then z1323.MatchingAutoKey = getDataM(spr, getColumIndex(spr,"MatchingAutoKey"), xRow)
     If  getColumIndex(spr,"GroupComponentBOM") > -1 then z1323.GroupComponentBOM = getDataM(spr, getColumIndex(spr,"GroupComponentBOM"), xRow)
     If  getColumIndex(spr,"GroupComponentSeq") > -1 then z1323.GroupComponentSeq = getDataM(spr, getColumIndex(spr,"GroupComponentSeq"), xRow)
     If  getColumIndex(spr,"Dseq") > -1 then z1323.Dseq = getDataM(spr, getColumIndex(spr,"Dseq"), xRow)
     If  getColumIndex(spr,"CustomerCode") > -1 then z1323.CustomerCode = getDataM(spr, getColumIndex(spr,"CustomerCode"), xRow)
     If  getColumIndex(spr,"selGroupComponent") > -1 then z1323.selGroupComponent = getDataM(spr, getColumIndex(spr,"selGroupComponent"), xRow)
     If  getColumIndex(spr,"cdGroupComponent") > -1 then z1323.cdGroupComponent = getDataM(spr, getColumIndex(spr,"cdGroupComponent"), xRow)
     If  getColumIndex(spr,"ComponentName") > -1 then z1323.ComponentName = getDataM(spr, getColumIndex(spr,"ComponentName"), xRow)
     If  getColumIndex(spr,"MaterialCode") > -1 then z1323.MaterialCode = getDataM(spr, getColumIndex(spr,"MaterialCode"), xRow)
     If  getColumIndex(spr,"seUnitMaterial") > -1 then z1323.seUnitMaterial = getDataM(spr, getColumIndex(spr,"seUnitMaterial"), xRow)
     If  getColumIndex(spr,"cdUnitMaterial") > -1 then z1323.cdUnitMaterial = getDataM(spr, getColumIndex(spr,"cdUnitMaterial"), xRow)
     If  getColumIndex(spr,"Specification") > -1 then z1323.Specification = getDataM(spr, getColumIndex(spr,"Specification"), xRow)
     If  getColumIndex(spr,"Width") > -1 then z1323.Width = getDataM(spr, getColumIndex(spr,"Width"), xRow)
     If  getColumIndex(spr,"WidthID") > -1 then z1323.WidthID = getDataM(spr, getColumIndex(spr,"WidthID"), xRow)
     If  getColumIndex(spr,"Height") > -1 then z1323.Height = getDataM(spr, getColumIndex(spr,"Height"), xRow)
     If  getColumIndex(spr,"SizeName") > -1 then z1323.SizeName = getDataM(spr, getColumIndex(spr,"SizeName"), xRow)
     If  getColumIndex(spr,"cdColorCode") > -1 then z1323.cdColorCode = getDataM(spr, getColumIndex(spr,"cdColorCode"), xRow)
     If  getColumIndex(spr,"ColorCode") > -1 then z1323.ColorCode = getDataM(spr, getColumIndex(spr,"ColorCode"), xRow)
     If  getColumIndex(spr,"ColorName") > -1 then z1323.ColorName = getDataM(spr, getColumIndex(spr,"ColorName"), xRow)
     If  getColumIndex(spr,"seShoesStatus") > -1 then z1323.seShoesStatus = getDataM(spr, getColumIndex(spr,"seShoesStatus"), xRow)
     If  getColumIndex(spr,"cdShoesStatus") > -1 then z1323.cdShoesStatus = getDataM(spr, getColumIndex(spr,"cdShoesStatus"), xRow)
     If  getColumIndex(spr,"seDepartment") > -1 then z1323.seDepartment = getDataM(spr, getColumIndex(spr,"seDepartment"), xRow)
     If  getColumIndex(spr,"cdDepartment") > -1 then z1323.cdDepartment = getDataM(spr, getColumIndex(spr,"cdDepartment"), xRow)
     If  getColumIndex(spr,"SupplierCode") > -1 then z1323.SupplierCode = getDataM(spr, getColumIndex(spr,"SupplierCode"), xRow)
     If  getColumIndex(spr,"PriceMaterial") > -1 then z1323.PriceMaterial = getDataM(spr, getColumIndex(spr,"PriceMaterial"), xRow)
     If  getColumIndex(spr,"ExchangeCost") > -1 then z1323.ExchangeCost = getDataM(spr, getColumIndex(spr,"ExchangeCost"), xRow)
     If  getColumIndex(spr,"ComplicationCost") > -1 then z1323.ComplicationCost = getDataM(spr, getColumIndex(spr,"ComplicationCost"), xRow)
     If  getColumIndex(spr,"AddedCost") > -1 then z1323.AddedCost = getDataM(spr, getColumIndex(spr,"AddedCost"), xRow)
     If  getColumIndex(spr,"ShippingRate") > -1 then z1323.ShippingRate = getDataM(spr, getColumIndex(spr,"ShippingRate"), xRow)
     If  getColumIndex(spr,"ShippingCost") > -1 then z1323.ShippingCost = getDataM(spr, getColumIndex(spr,"ShippingCost"), xRow)
     If  getColumIndex(spr,"PriceRnD") > -1 then z1323.PriceRnD = getDataM(spr, getColumIndex(spr,"PriceRnD"), xRow)
     If  getColumIndex(spr,"Price") > -1 then z1323.Price = getDataM(spr, getColumIndex(spr,"Price"), xRow)
     If  getColumIndex(spr,"seUnitPrice") > -1 then z1323.seUnitPrice = getDataM(spr, getColumIndex(spr,"seUnitPrice"), xRow)
     If  getColumIndex(spr,"cdUnitPrice") > -1 then z1323.cdUnitPrice = getDataM(spr, getColumIndex(spr,"cdUnitPrice"), xRow)
     If  getColumIndex(spr,"QtyComponent") > -1 then z1323.QtyComponent = getDataM(spr, getColumIndex(spr,"QtyComponent"), xRow)
     If  getColumIndex(spr,"Consumption") > -1 then z1323.Consumption = getDataM(spr, getColumIndex(spr,"Consumption"), xRow)
     If  getColumIndex(spr,"Loss") > -1 then z1323.Loss = getDataM(spr, getColumIndex(spr,"Loss"), xRow)
     If  getColumIndex(spr,"GrossUsage") > -1 then z1323.GrossUsage = getDataM(spr, getColumIndex(spr,"GrossUsage"), xRow)
     If  getColumIndex(spr,"MaterialAMT") > -1 then z1323.MaterialAMT = getDataM(spr, getColumIndex(spr,"MaterialAMT"), xRow)
     If  getColumIndex(spr,"MaterialAMTPurchasing") > -1 then z1323.MaterialAMTPurchasing = getDataM(spr, getColumIndex(spr,"MaterialAMTPurchasing"), xRow)
     If  getColumIndex(spr,"MaterialAMTSales") > -1 then z1323.MaterialAMTSales = getDataM(spr, getColumIndex(spr,"MaterialAMTSales"), xRow)
     If  getColumIndex(spr,"seSubProcess") > -1 then z1323.seSubProcess = getDataM(spr, getColumIndex(spr,"seSubProcess"), xRow)
     If  getColumIndex(spr,"cdSubProcess") > -1 then z1323.cdSubProcess = getDataM(spr, getColumIndex(spr,"cdSubProcess"), xRow)
     If  getColumIndex(spr,"seSpecialProcess") > -1 then z1323.seSpecialProcess = getDataM(spr, getColumIndex(spr,"seSpecialProcess"), xRow)
     If  getColumIndex(spr,"cdSpecialProcess") > -1 then z1323.cdSpecialProcess = getDataM(spr, getColumIndex(spr,"cdSpecialProcess"), xRow)
     If  getColumIndex(spr,"CheckMark") > -1 then z1323.CheckMark = getDataM(spr, getColumIndex(spr,"CheckMark"), xRow)
     If  getColumIndex(spr,"CheckUse") > -1 then z1323.CheckUse = getDataM(spr, getColumIndex(spr,"CheckUse"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z1323.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K1323_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K1323_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z1323 As T1323_AREA, Job as String, MATCHINGAUTOKEY AS String, GROUPCOMPONENTBOM AS String, GROUPCOMPONENTSEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K1323_MOVE = False

Try
    If READ_PFK1323(MATCHINGAUTOKEY, GROUPCOMPONENTBOM, GROUPCOMPONENTSEQ) = True Then
                z1323 = D1323
		K1323_MOVE = True
		else
	z1323 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK1323")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "MATCHINGAUTOKEY":z1323.MatchingAutoKey = Children(i).Code
   Case "GROUPCOMPONENTBOM":z1323.GroupComponentBOM = Children(i).Code
   Case "GROUPCOMPONENTSEQ":z1323.GroupComponentSeq = Children(i).Code
   Case "DSEQ":z1323.Dseq = Children(i).Code
   Case "CUSTOMERCODE":z1323.CustomerCode = Children(i).Code
   Case "SELGROUPCOMPONENT":z1323.selGroupComponent = Children(i).Code
   Case "CDGROUPCOMPONENT":z1323.cdGroupComponent = Children(i).Code
   Case "COMPONENTNAME":z1323.ComponentName = Children(i).Code
   Case "MATERIALCODE":z1323.MaterialCode = Children(i).Code
   Case "SEUNITMATERIAL":z1323.seUnitMaterial = Children(i).Code
   Case "CDUNITMATERIAL":z1323.cdUnitMaterial = Children(i).Code
   Case "SPECIFICATION":z1323.Specification = Children(i).Code
   Case "WIDTH":z1323.Width = Children(i).Code
   Case "WIDTHID":z1323.WidthID = Children(i).Code
   Case "HEIGHT":z1323.Height = Children(i).Code
   Case "SIZENAME":z1323.SizeName = Children(i).Code
   Case "CDCOLORCODE":z1323.cdColorCode = Children(i).Code
   Case "COLORCODE":z1323.ColorCode = Children(i).Code
   Case "COLORNAME":z1323.ColorName = Children(i).Code
   Case "SESHOESSTATUS":z1323.seShoesStatus = Children(i).Code
   Case "CDSHOESSTATUS":z1323.cdShoesStatus = Children(i).Code
   Case "SEDEPARTMENT":z1323.seDepartment = Children(i).Code
   Case "CDDEPARTMENT":z1323.cdDepartment = Children(i).Code
   Case "SUPPLIERCODE":z1323.SupplierCode = Children(i).Code
   Case "PRICEMATERIAL":z1323.PriceMaterial = Children(i).Code
   Case "EXCHANGECOST":z1323.ExchangeCost = Children(i).Code
   Case "COMPLICATIONCOST":z1323.ComplicationCost = Children(i).Code
   Case "ADDEDCOST":z1323.AddedCost = Children(i).Code
   Case "SHIPPINGRATE":z1323.ShippingRate = Children(i).Code
   Case "SHIPPINGCOST":z1323.ShippingCost = Children(i).Code
   Case "PRICERND":z1323.PriceRnD = Children(i).Code
   Case "PRICE":z1323.Price = Children(i).Code
   Case "SEUNITPRICE":z1323.seUnitPrice = Children(i).Code
   Case "CDUNITPRICE":z1323.cdUnitPrice = Children(i).Code
   Case "QTYCOMPONENT":z1323.QtyComponent = Children(i).Code
   Case "CONSUMPTION":z1323.Consumption = Children(i).Code
   Case "LOSS":z1323.Loss = Children(i).Code
   Case "GROSSUSAGE":z1323.GrossUsage = Children(i).Code
   Case "MATERIALAMT":z1323.MaterialAMT = Children(i).Code
   Case "MATERIALAMTPURCHASING":z1323.MaterialAMTPurchasing = Children(i).Code
   Case "MATERIALAMTSALES":z1323.MaterialAMTSales = Children(i).Code
   Case "SESUBPROCESS":z1323.seSubProcess = Children(i).Code
   Case "CDSUBPROCESS":z1323.cdSubProcess = Children(i).Code
   Case "SESPECIALPROCESS":z1323.seSpecialProcess = Children(i).Code
   Case "CDSPECIALPROCESS":z1323.cdSpecialProcess = Children(i).Code
   Case "CHECKMARK":z1323.CheckMark = Children(i).Code
   Case "CHECKUSE":z1323.CheckUse = Children(i).Code
   Case "REMARK":z1323.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "MATCHINGAUTOKEY":z1323.MatchingAutoKey = Children(i).Data
   Case "GROUPCOMPONENTBOM":z1323.GroupComponentBOM = Children(i).Data
   Case "GROUPCOMPONENTSEQ":z1323.GroupComponentSeq = Children(i).Data
   Case "DSEQ":z1323.Dseq = Children(i).Data
   Case "CUSTOMERCODE":z1323.CustomerCode = Children(i).Data
   Case "SELGROUPCOMPONENT":z1323.selGroupComponent = Children(i).Data
   Case "CDGROUPCOMPONENT":z1323.cdGroupComponent = Children(i).Data
   Case "COMPONENTNAME":z1323.ComponentName = Children(i).Data
   Case "MATERIALCODE":z1323.MaterialCode = Children(i).Data
   Case "SEUNITMATERIAL":z1323.seUnitMaterial = Children(i).Data
   Case "CDUNITMATERIAL":z1323.cdUnitMaterial = Children(i).Data
   Case "SPECIFICATION":z1323.Specification = Children(i).Data
   Case "WIDTH":z1323.Width = Children(i).Data
   Case "WIDTHID":z1323.WidthID = Children(i).Data
   Case "HEIGHT":z1323.Height = Children(i).Data
   Case "SIZENAME":z1323.SizeName = Children(i).Data
   Case "CDCOLORCODE":z1323.cdColorCode = Children(i).Data
   Case "COLORCODE":z1323.ColorCode = Children(i).Data
   Case "COLORNAME":z1323.ColorName = Children(i).Data
   Case "SESHOESSTATUS":z1323.seShoesStatus = Children(i).Data
   Case "CDSHOESSTATUS":z1323.cdShoesStatus = Children(i).Data
   Case "SEDEPARTMENT":z1323.seDepartment = Children(i).Data
   Case "CDDEPARTMENT":z1323.cdDepartment = Children(i).Data
   Case "SUPPLIERCODE":z1323.SupplierCode = Children(i).Data
   Case "PRICEMATERIAL":z1323.PriceMaterial = Children(i).Data
   Case "EXCHANGECOST":z1323.ExchangeCost = Children(i).Data
   Case "COMPLICATIONCOST":z1323.ComplicationCost = Children(i).Data
   Case "ADDEDCOST":z1323.AddedCost = Children(i).Data
   Case "SHIPPINGRATE":z1323.ShippingRate = Children(i).Data
   Case "SHIPPINGCOST":z1323.ShippingCost = Children(i).Data
   Case "PRICERND":z1323.PriceRnD = Children(i).Data
   Case "PRICE":z1323.Price = Children(i).Data
   Case "SEUNITPRICE":z1323.seUnitPrice = Children(i).Data
   Case "CDUNITPRICE":z1323.cdUnitPrice = Children(i).Data
   Case "QTYCOMPONENT":z1323.QtyComponent = Children(i).Data
   Case "CONSUMPTION":z1323.Consumption = Children(i).Data
   Case "LOSS":z1323.Loss = Children(i).Data
   Case "GROSSUSAGE":z1323.GrossUsage = Children(i).Data
   Case "MATERIALAMT":z1323.MaterialAMT = Children(i).Data
   Case "MATERIALAMTPURCHASING":z1323.MaterialAMTPurchasing = Children(i).Data
   Case "MATERIALAMTSALES":z1323.MaterialAMTSales = Children(i).Data
   Case "SESUBPROCESS":z1323.seSubProcess = Children(i).Data
   Case "CDSUBPROCESS":z1323.cdSubProcess = Children(i).Data
   Case "SESPECIALPROCESS":z1323.seSpecialProcess = Children(i).Data
   Case "CDSPECIALPROCESS":z1323.cdSpecialProcess = Children(i).Data
   Case "CHECKMARK":z1323.CheckMark = Children(i).Data
   Case "CHECKUSE":z1323.CheckUse = Children(i).Data
   Case "REMARK":z1323.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K1323_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K1323_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z1323 As T1323_AREA, Job as String, CheckClear as Boolean, MATCHINGAUTOKEY AS String, GROUPCOMPONENTBOM AS String, GROUPCOMPONENTSEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K1323_MOVE = False

Try
    If READ_PFK1323(MATCHINGAUTOKEY, GROUPCOMPONENTBOM, GROUPCOMPONENTSEQ) = True Then
                z1323 = D1323
		K1323_MOVE = True
		else
	If CheckClear  = True then z1323 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK1323")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "MATCHINGAUTOKEY":z1323.MatchingAutoKey = Children(i).Code
   Case "GROUPCOMPONENTBOM":z1323.GroupComponentBOM = Children(i).Code
   Case "GROUPCOMPONENTSEQ":z1323.GroupComponentSeq = Children(i).Code
   Case "DSEQ":z1323.Dseq = Children(i).Code
   Case "CUSTOMERCODE":z1323.CustomerCode = Children(i).Code
   Case "SELGROUPCOMPONENT":z1323.selGroupComponent = Children(i).Code
   Case "CDGROUPCOMPONENT":z1323.cdGroupComponent = Children(i).Code
   Case "COMPONENTNAME":z1323.ComponentName = Children(i).Code
   Case "MATERIALCODE":z1323.MaterialCode = Children(i).Code
   Case "SEUNITMATERIAL":z1323.seUnitMaterial = Children(i).Code
   Case "CDUNITMATERIAL":z1323.cdUnitMaterial = Children(i).Code
   Case "SPECIFICATION":z1323.Specification = Children(i).Code
   Case "WIDTH":z1323.Width = Children(i).Code
   Case "WIDTHID":z1323.WidthID = Children(i).Code
   Case "HEIGHT":z1323.Height = Children(i).Code
   Case "SIZENAME":z1323.SizeName = Children(i).Code
   Case "CDCOLORCODE":z1323.cdColorCode = Children(i).Code
   Case "COLORCODE":z1323.ColorCode = Children(i).Code
   Case "COLORNAME":z1323.ColorName = Children(i).Code
   Case "SESHOESSTATUS":z1323.seShoesStatus = Children(i).Code
   Case "CDSHOESSTATUS":z1323.cdShoesStatus = Children(i).Code
   Case "SEDEPARTMENT":z1323.seDepartment = Children(i).Code
   Case "CDDEPARTMENT":z1323.cdDepartment = Children(i).Code
   Case "SUPPLIERCODE":z1323.SupplierCode = Children(i).Code
   Case "PRICEMATERIAL":z1323.PriceMaterial = Children(i).Code
   Case "EXCHANGECOST":z1323.ExchangeCost = Children(i).Code
   Case "COMPLICATIONCOST":z1323.ComplicationCost = Children(i).Code
   Case "ADDEDCOST":z1323.AddedCost = Children(i).Code
   Case "SHIPPINGRATE":z1323.ShippingRate = Children(i).Code
   Case "SHIPPINGCOST":z1323.ShippingCost = Children(i).Code
   Case "PRICERND":z1323.PriceRnD = Children(i).Code
   Case "PRICE":z1323.Price = Children(i).Code
   Case "SEUNITPRICE":z1323.seUnitPrice = Children(i).Code
   Case "CDUNITPRICE":z1323.cdUnitPrice = Children(i).Code
   Case "QTYCOMPONENT":z1323.QtyComponent = Children(i).Code
   Case "CONSUMPTION":z1323.Consumption = Children(i).Code
   Case "LOSS":z1323.Loss = Children(i).Code
   Case "GROSSUSAGE":z1323.GrossUsage = Children(i).Code
   Case "MATERIALAMT":z1323.MaterialAMT = Children(i).Code
   Case "MATERIALAMTPURCHASING":z1323.MaterialAMTPurchasing = Children(i).Code
   Case "MATERIALAMTSALES":z1323.MaterialAMTSales = Children(i).Code
   Case "SESUBPROCESS":z1323.seSubProcess = Children(i).Code
   Case "CDSUBPROCESS":z1323.cdSubProcess = Children(i).Code
   Case "SESPECIALPROCESS":z1323.seSpecialProcess = Children(i).Code
   Case "CDSPECIALPROCESS":z1323.cdSpecialProcess = Children(i).Code
   Case "CHECKMARK":z1323.CheckMark = Children(i).Code
   Case "CHECKUSE":z1323.CheckUse = Children(i).Code
   Case "REMARK":z1323.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "MATCHINGAUTOKEY":z1323.MatchingAutoKey = Children(i).Data
   Case "GROUPCOMPONENTBOM":z1323.GroupComponentBOM = Children(i).Data
   Case "GROUPCOMPONENTSEQ":z1323.GroupComponentSeq = Children(i).Data
   Case "DSEQ":z1323.Dseq = Children(i).Data
   Case "CUSTOMERCODE":z1323.CustomerCode = Children(i).Data
   Case "SELGROUPCOMPONENT":z1323.selGroupComponent = Children(i).Data
   Case "CDGROUPCOMPONENT":z1323.cdGroupComponent = Children(i).Data
   Case "COMPONENTNAME":z1323.ComponentName = Children(i).Data
   Case "MATERIALCODE":z1323.MaterialCode = Children(i).Data
   Case "SEUNITMATERIAL":z1323.seUnitMaterial = Children(i).Data
   Case "CDUNITMATERIAL":z1323.cdUnitMaterial = Children(i).Data
   Case "SPECIFICATION":z1323.Specification = Children(i).Data
   Case "WIDTH":z1323.Width = Children(i).Data
   Case "WIDTHID":z1323.WidthID = Children(i).Data
   Case "HEIGHT":z1323.Height = Children(i).Data
   Case "SIZENAME":z1323.SizeName = Children(i).Data
   Case "CDCOLORCODE":z1323.cdColorCode = Children(i).Data
   Case "COLORCODE":z1323.ColorCode = Children(i).Data
   Case "COLORNAME":z1323.ColorName = Children(i).Data
   Case "SESHOESSTATUS":z1323.seShoesStatus = Children(i).Data
   Case "CDSHOESSTATUS":z1323.cdShoesStatus = Children(i).Data
   Case "SEDEPARTMENT":z1323.seDepartment = Children(i).Data
   Case "CDDEPARTMENT":z1323.cdDepartment = Children(i).Data
   Case "SUPPLIERCODE":z1323.SupplierCode = Children(i).Data
   Case "PRICEMATERIAL":z1323.PriceMaterial = Children(i).Data
   Case "EXCHANGECOST":z1323.ExchangeCost = Children(i).Data
   Case "COMPLICATIONCOST":z1323.ComplicationCost = Children(i).Data
   Case "ADDEDCOST":z1323.AddedCost = Children(i).Data
   Case "SHIPPINGRATE":z1323.ShippingRate = Children(i).Data
   Case "SHIPPINGCOST":z1323.ShippingCost = Children(i).Data
   Case "PRICERND":z1323.PriceRnD = Children(i).Data
   Case "PRICE":z1323.Price = Children(i).Data
   Case "SEUNITPRICE":z1323.seUnitPrice = Children(i).Data
   Case "CDUNITPRICE":z1323.cdUnitPrice = Children(i).Data
   Case "QTYCOMPONENT":z1323.QtyComponent = Children(i).Data
   Case "CONSUMPTION":z1323.Consumption = Children(i).Data
   Case "LOSS":z1323.Loss = Children(i).Data
   Case "GROSSUSAGE":z1323.GrossUsage = Children(i).Data
   Case "MATERIALAMT":z1323.MaterialAMT = Children(i).Data
   Case "MATERIALAMTPURCHASING":z1323.MaterialAMTPurchasing = Children(i).Data
   Case "MATERIALAMTSALES":z1323.MaterialAMTSales = Children(i).Data
   Case "SESUBPROCESS":z1323.seSubProcess = Children(i).Data
   Case "CDSUBPROCESS":z1323.cdSubProcess = Children(i).Data
   Case "SESPECIALPROCESS":z1323.seSpecialProcess = Children(i).Data
   Case "CDSPECIALPROCESS":z1323.cdSpecialProcess = Children(i).Data
   Case "CHECKMARK":z1323.CheckMark = Children(i).Data
   Case "CHECKUSE":z1323.CheckUse = Children(i).Data
   Case "REMARK":z1323.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K1323_MOVE",vbCritical)
End Try
End Function 
    
End Module 
